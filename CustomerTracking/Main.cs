using CustomerTracking.DAL;
using CustomerTracking.Entities;
using CustomerTracking.Extensions;
using CustomerTracking.Helpers;
using CustomerTracking.IoC;
using CustomerTracking.NonRelationalEntities;
using CustomerTracking.Services;
using CustomerTracking.ViewModels;
using NLog;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace CustomerTracking
{
    public partial class Main : Form
    {
        #region Declarations

        Main frmMain;

        Loading frmLoading;

        private readonly IDbContext _dbContext;

        private readonly IDataExportService _dataExportService;

        private readonly Logger _logger;

        private const string _logFoldersPath = @"C:\Program Files (x86)\Customer-Tracking\";

        private const int _rowCount = 10;

        private int _currentPage = 1;
        private int _pagesCount = 1;

        SortableBindingList<CustomerViewModel> sortableCustomer;

        List<Customer> customerCollection;

        #endregion

        #region Form Initialization

        public Main()
        {
            InitializeComponent();

            #region Dependencies

            _dbContext = Injector.Resolve<IDbContext>();
            _dataExportService = Injector.Resolve<IDataExportService>();

            #endregion

            _logger = LogManager.GetCurrentClassLogger();
        }

        private void frmMain_Load(object sender, EventArgs e)
        { 
            frmMain = (Main)Application.OpenForms["Main"];

            DisableControls();

            SetPickerDateFormat();

            GetCustomerCollection();

            txtCustomerNameSurname.Focus();

            EnableControls();
        }

        #endregion

        #region Button Click Events

        private void btnClear_Click(object sender, EventArgs e)
        {
            InitializeInputs();
            txtCustomerNameSurname.Focus();
        }

        private void btnNewCustomer_Click(object sender, EventArgs e)
        {
            InitializeInputs();
            txtCustomerNameSurname.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DisableControls();

            if (!IsValid())
            {
                EnableControls();
                return;
            }

            Customer currentCustomer = null;

            if (lblCustomerId.Text.IsNotNullOrEmpty())
            {
                var id = Convert.ToInt32(lblCustomerId.Text);

                if (id > 0)
                {
                    currentCustomer = _dbContext.Set<Customer>().IncludeRelations(x => x.Vehicle, x => x.Vehicle.Staff, x => x.Vehicle.Staff.Reparation).FirstOrDefault(x => x.Id == id);
                }
                else
                {
                    MessageBox.Show(new Form() { TopMost = true }, "Kayıt güncellenemedi! Lütfen güncellemek için kayıt seçiniz.", "Uyarı");
                }
            }

            if (currentCustomer.IsNull())
            {
                SaveCustomer();
            }
            else
            {
                UpdateCustomer(currentCustomer);
            }

            InitializeInputs();

            EnableControls();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        { 
            DialogResult result = MessageBox.Show(new Form() { TopMost = true }, "Bu kaydı silmek istediğinizden emin misiniz?", "Uyarı", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                DisableControls();

                if (lblCustomerId.Text.IsNotNullOrEmpty())
                {
                    var id = Convert.ToInt32(lblCustomerId.Text);

                    if (id > 0)
                    {
                        var currentCustomer = _dbContext.Set<Customer>().IncludeRelations(x => x.Vehicle, x => x.Vehicle.Staff, x => x.Vehicle.Staff.Reparation).FirstOrDefault(x => x.Id == id);

                        if (currentCustomer.IsNotNull())
                        {
                            try
                            {
                                _dbContext.Set<Customer>().Remove(currentCustomer);
                                _dbContext.SaveChanges();

                                customerCollection = _dbContext.Set<Customer>().IncludeRelations(x => x.Vehicle, x => x.Vehicle.Staff, x => x.Vehicle.Staff.Reparation).OrderByDescending(x => x.CreatedDate).ToList();

                                ClearGrid();

                                FillGrid(customerCollection);

                                MessageBox.Show(new Form() { TopMost = true }, "Kayıt silindi.", "Uyarı");
                            }
                            catch (Exception ex)
                            {
                                var exception = new AppException("Kaydetme işlemi sırasında hata oluştu. Hata : " + ex, ex);

                                MessageBox.Show(new Form() { TopMost = true }, "Kaydetme işlemi sırasında hata oluştu.", "Hata");
                            }
                        }
                        else
                        {
                            MessageBox.Show(new Form() { TopMost = true }, "Kayıt bulunamadı!", "Hata");
                        }
                    }
                    else
                    {
                        MessageBox.Show(new Form() { TopMost = true }, "Silmek için kayıt seçiniz!", "Uyarı");
                    }
                }
                else
                {
                    MessageBox.Show(new Form() { TopMost = true }, "Silmek için kayıt seçiniz!", "Uyarı");
                }

                EnableControls();

                InitializeInputs();
            } 
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var checkedButton = frmMain.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);

            if (checkedButton.IsNull())
            {
                MessageBox.Show(new Form() { TopMost = true }, "Lütfen arama yapmak için kriter seçiniz!", "Hata");
            }
            else
            {
                if (customerCollection.IsNull() || customerCollection.Count <= 0)
                {
                    MessageBox.Show(new Form() { TopMost = true }, "Müşteri kaydı olmadığı için arama yapılamaz!", "Uyarı");
                }
                else
                {
                    switch (checkedButton.Name)
                    {
                        case "rbCustomerNameSurname":
                            var customersWithName = customerCollection.Where(x => x.NameSurname.Contains(txtSearch.Text.Trim())).ToList();

                            if (customersWithName.IsNull() || customersWithName.Count <= 0)
                            {
                                MessageBox.Show(new Form() { TopMost = true }, txtSearch.Text.Trim() + " isimli müşteri kaydı bulunamadı", "Uyarı");
                            }
                            else
                            {
                                ClearGrid();
                                FillGrid(customersWithName);
                            }
                            break;
                        case "rbVehicleBrandOrModel":
                            var customersWithBrand = customerCollection.Where(x => x.Vehicle.Brand.Contains(txtSearch.Text.Trim())).ToList();

                            if (customersWithBrand.IsNull() || customersWithBrand.Count <= 0)
                            {
                                MessageBox.Show(new Form() { TopMost = true }, txtSearch.Text.Trim() + " model isimli araç kaydı bulunamadı", "Uyarı");
                            }
                            else
                            {
                                ClearGrid();
                                FillGrid(customersWithBrand);
                            }
                            break;
                        case "rbNumberPlate":
                            var customersWithPlateNumber = customerCollection.Where(x => x.Vehicle.NumberPlate.Contains(txtSearch.Text.Trim())).ToList();

                            if (customersWithPlateNumber.IsNull() || customersWithPlateNumber.Count <= 0)
                            {
                                MessageBox.Show(new Form() { TopMost = true }, txtSearch.Text.Trim() + " plakalı araç kaydı bulunamadı", "Uyarı");
                            }
                            else
                            {
                                ClearGrid();
                                FillGrid(customersWithPlateNumber);
                            }
                            break;
                        case "rbReparationOperation":
                            var customersWithReparationOperation = customerCollection.Where(x => x.Vehicle.Staff.Reparation.Operation.Contains(txtSearch.Text.Trim())).ToList();

                            if (customersWithReparationOperation.IsNull() || customersWithReparationOperation.Count <= 0)
                            {
                                MessageBox.Show(new Form() { TopMost = true }, txtSearch.Text.Trim() + " onarımı yapılan araç kaydı bulunamadı", "Uyarı");
                            }
                            else
                            {
                                ClearGrid();
                                FillGrid(customersWithReparationOperation);
                            }
                            break;
                    }
                }
            }
        }

        private void btnCreatePdf_Click(object sender, EventArgs e)
        {
            var selectedCustomer = new CustomerViewModel();

            //Customer
            selectedCustomer.CustomerNameSurname = txtCustomerNameSurname.Text.IsNullOrEmpty() ? string.Empty : txtCustomerNameSurname.Text;
            selectedCustomer.CustomerPhoneNumber = txtCustomerMobileNumber.Text.IsNullOrEmpty() ? string.Empty : txtCustomerMobileNumber.Text;

            //Vehicle
            selectedCustomer.VehicleBrand = txtVehicleBrand.Text.IsNullOrEmpty() ? string.Empty : txtVehicleBrand.Text;
            selectedCustomer.VehicleNumberPlate = txtVehicleNumberPlate.Text.IsNullOrEmpty() ? string.Empty : txtVehicleNumberPlate.Text;

            //Staff
            selectedCustomer.StaffNameSurname = txtStaffNameSurname.Text.IsNullOrEmpty() ? string.Empty : txtStaffNameSurname.Text; 

            //Reparation
            selectedCustomer.ReparationOperation = txtReparationOperation.Text.IsNullOrEmpty() ? string.Empty : txtReparationOperation.Text;

            var response = _dataExportService.ExportData(selectedCustomer);

            if (!response.IsSucceed)
            {
                MessageBox.Show(new Form() { TopMost = true }, "Pdf dosyasına dönüştürme işlemi sırasında hata oluştu!", "Hata");
            }
                        
        }

        private void btnGetCustomers_Click(object sender, EventArgs e)
        {
            GetCustomerCollection();
        }

        #endregion

        #region Events

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result;

                result = MessageBox.Show(new Form() { TopMost = true }, "Programı kapatmak istediğinizden emin misiniz?", "Çıkış", MessageBoxButtons.YesNo);

                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
                else
                {
                    e.Cancel = false;
                    Application.Exit();
                }
            }
        }

        private void dgvCustomers_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCustomers.Focused)
            {
                var id = int.Parse(dgvCustomers.Rows[dgvCustomers.CurrentCell.RowIndex].Cells[6].Value.ToString());

                if (id > 0)
                {
                    var searchedCustomer = customerCollection.FirstOrDefault(x => x.Id == id);

                    if (searchedCustomer.IsNotNull())
                    {
                        //Customer
                        txtCustomerNameSurname.Text = searchedCustomer.NameSurname;
                        txtCustomerMobileNumber.Text = searchedCustomer.PhoneNumber;
                        txtCustomerAddress.Text = searchedCustomer.Address;

                        //Vehicle
                        txtVehicleBrand.Text = searchedCustomer.Vehicle.Brand;
                        txtVehicleModel.Text = searchedCustomer.Vehicle.Model;
                        txtVehicleNumberPlate.Text = searchedCustomer.Vehicle.NumberPlate;

                        //Staff
                        txtStaffNameSurname.Text = searchedCustomer.Vehicle.Staff.NameSurname;
                        txtStaffSpeciality.Text = searchedCustomer.Vehicle.Staff.Speciality;

                        //Reparation
                        txtReparationOperation.Text = searchedCustomer.Vehicle.Staff.Reparation.Operation;
                        txtReparationPrice.Text = searchedCustomer.Vehicle.Staff.Reparation.Price;
                        dtpReparationAcceptanceTime.Value = Convert.ToDateTime(searchedCustomer.Vehicle.Staff.Reparation.AcceptanceTime);
                        dtpReparationDeliverTime.Value = Convert.ToDateTime(searchedCustomer.Vehicle.Staff.Reparation.DeliverTime);

                        lblCustomerId.Text = id.ToString();
                    }
                }
            }

        }

        #endregion

        #region Helper Methods

        #region Grid Methods

        private void RefreshCustomerPagination()
        {
            ToolStripButton[] items = new ToolStripButton[] { toolStripButtonCustomer1, toolStripButtonCustomer2, toolStripButtonCustomer3, toolStripButtonCustomer4, toolStripButtonCustomer5 };

            //pageStartIndex contains the first button number of pagination.
            int pageStartIndex = 1;

            if (_pagesCount > 5 && _currentPage > 2)
                pageStartIndex = _currentPage - 2;

            if (_pagesCount > 5 && _currentPage > _pagesCount - 2)
                pageStartIndex = _pagesCount - 4;

            for (int i = pageStartIndex; i < pageStartIndex + 5; i++)
            {
                if (i > _pagesCount)
                {
                    items[i - pageStartIndex].Visible = false;
                }
                else
                {
                    //Changing the page numbers
                    items[i - pageStartIndex].Text = i.ToString(CultureInfo.InvariantCulture);

                    //Setting the Appearance of the page number buttons
                    if (i == _currentPage)
                    {
                        items[i - pageStartIndex].BackColor = Color.Black;
                        items[i - pageStartIndex].ForeColor = Color.White;
                    }
                    else
                    {
                        items[i - pageStartIndex].BackColor = Color.White;
                        items[i - pageStartIndex].ForeColor = Color.Black;
                    }
                }
            }

            //Enabling or Disalbing pagination first, last, previous , next buttons
            if (_currentPage == 1)
            {
                btnBackwardCustomer.Enabled = btnFirstCustomer.Enabled = false;
            }
            else
            {
                btnBackwardCustomer.Enabled = btnFirstCustomer.Enabled = true;
            }

            if (_currentPage == _pagesCount)
            {
                btnForwardCustomer.Enabled = btnLastCustomer.Enabled = false;
            }
            else
            {
                btnForwardCustomer.Enabled = btnLastCustomer.Enabled = true;
            }
        }

        private void RebindCustomerGridForPageChange()
        {
            //Rebinding the datagridview with data
            int datasourcestartIndex = (_currentPage - 1) * _rowCount;

            var tempList = new SortableBindingList<CustomerViewModel>(new List<CustomerViewModel>());

            for (int i = datasourcestartIndex; i < datasourcestartIndex + _rowCount; i++)
            {
                if (i >= sortableCustomer.Count)
                    break;

                tempList.Add(sortableCustomer[i]);
            }
            
            dgvCustomers.DataSource = tempList; 
            dgvCustomers.Refresh(); 
        }

        private void ClearGrid()
        {
            dgvCustomers.DataSource = null;
            dgvCustomers.Rows.Clear();
            dgvCustomers.Refresh();
        }

        private void CustomerToolStripButtonClick(object sender, EventArgs e)
        {
            try
            {
                ToolStripButton ToolStripButton = ((ToolStripButton)sender);

                //Determining the current page
                if (ToolStripButton == btnBackwardCustomer)
                    _currentPage--;
                else if (ToolStripButton == btnForwardCustomer)
                    _currentPage++;
                else if (ToolStripButton == btnLastCustomer)
                    _currentPage = _pagesCount;
                else if (ToolStripButton == btnFirstCustomer)
                    _currentPage = 1;
                else
                    _currentPage = Convert.ToInt32(ToolStripButton.Text, CultureInfo.InvariantCulture);

                if (_currentPage < 1)
                    _currentPage = 1;
                else if (_currentPage > _pagesCount)
                    _currentPage = _pagesCount;

                //Rebind the Datagridview with the data.
                RebindCustomerGridForPageChange();

                //Change the pagiantions buttons according to page number
                RefreshCustomerPagination();
            }
            catch (Exception ex)
            {
                new AppException("Müşteri Listesi oluşturulurken hata oluştu. Programı yeniden başlatınız!", ex);
            }
        }

        private void FillGrid(List<Customer> searchedCustomerCollection)
        {
            var customerViewModelCollection = new List<CustomerViewModel>();

            foreach (var customer in searchedCustomerCollection)
            {
                var model = new CustomerViewModel();

                model.Id = customer.Id;
                model.CustomerNameSurname = customer.NameSurname;
                model.CustomerPhoneNumber = customer.PhoneNumber;
                model.ReparationOperation = customer.Vehicle.Staff.Reparation.Operation;
                model.StaffNameSurname = customer.Vehicle.Staff.NameSurname;
                model.VehicleBrand = customer.Vehicle.Brand;
                model.VehicleNumberPlate = customer.Vehicle.NumberPlate;

                customerViewModelCollection.Add(model);
            }

            sortableCustomer = new SortableBindingList<CustomerViewModel>(customerViewModelCollection);

            _pagesCount = Convert.ToInt32(Math.Ceiling(sortableCustomer.Count * 1.0 / _rowCount));
            _currentPage = 1;

            RefreshCustomerPagination();
            RebindCustomerGridForPageChange();
             
            dgvCustomers.Columns[0].HeaderText = "Müşteri Adı Soyadı";
            dgvCustomers.Columns[1].HeaderText = "Müşteri Telefon Numarası";
            dgvCustomers.Columns[2].HeaderText = "Araç Markası";
            dgvCustomers.Columns[3].HeaderText = "Araç Plakası";
            dgvCustomers.Columns[4].HeaderText = "Ustanın Adı Soyadı";
            dgvCustomers.Columns[5].HeaderText = "Yapılan Tamirat";
            dgvCustomers.Columns[6].Visible = false;
            dgvCustomers.Columns[6].HeaderText = "ID";

            lblCustomerCount.Text = customerViewModelCollection.Count.ToString();
        }

        #endregion

        private void GetCustomerCollection()
        {
            DisableControls();

            if (customerCollection.IsNull())
            {
                customerCollection = _dbContext.Set<Customer>().IncludeRelations(x => x.Vehicle, x => x.Vehicle.Staff, x => x.Vehicle.Staff.Reparation).OrderByDescending(x => x.CreatedDate).ToList();
            }

            if (customerCollection.Count <= 0)
            {
                MessageBox.Show(new Form() { TopMost = true }, "Müşteri kaydı bulunamadı", "Uyarı");

                lblCustomerCount.Text = "0";
            }
            else
            {
                ClearGrid();

                FillGrid(customerCollection);
            }

            EnableControls();
        }

        private void SaveCustomer()
        {
            var customer = new Customer();

            customer.NameSurname = txtCustomerNameSurname.Text;
            customer.PhoneNumber = txtCustomerMobileNumber.Text;
            customer.Address = txtCustomerAddress.Text;

            var reparation = new Reparation();
            reparation.Operation = txtReparationOperation.Text;
            reparation.Price = txtReparationPrice.Text;
            reparation.AcceptanceTime = dtpReparationAcceptanceTime.Value.Date;
            reparation.DeliverTime = dtpReparationDeliverTime.Value.Date;

            var staff = new Staff();
            staff.NameSurname = txtStaffNameSurname.Text;
            staff.Speciality = txtStaffSpeciality.Text;
            staff.Reparation = reparation;

            var vehicle = new Vehicle();
            vehicle.Brand = txtVehicleBrand.Text;
            vehicle.Model = txtVehicleModel.Text;
            vehicle.NumberPlate = txtVehicleNumberPlate.Text;
            vehicle.Staff = staff;

            customer.Vehicle = vehicle;

            try
            {
                _dbContext.Set<Customer>().Add(customer);
                _dbContext.SaveChanges();

                customerCollection = _dbContext.Set<Customer>().IncludeRelations(x => x.Vehicle, x => x.Vehicle.Staff, x => x.Vehicle.Staff.Reparation).OrderByDescending(x => x.CreatedDate).ToList();

                ClearGrid();

                FillGrid(customerCollection);

                MessageBox.Show(new Form() { TopMost = true }, "Müşteri kaydedildi.", "Bilgilendirme");
            }
            catch (Exception ex)
            {
                var exception = new AppException("Kaydetme işlemi sırasında hata oluştu. Hata : " + ex, ex);

                MessageBox.Show(new Form() { TopMost = true }, "Kaydetme işlemi sırasında hata oluştu.", "Hata");
            }
        }

        private void UpdateCustomer(Customer currentCustomer)
        {
            currentCustomer.NameSurname = txtCustomerNameSurname.Text;
            currentCustomer.PhoneNumber = txtCustomerMobileNumber.Text;
            currentCustomer.Address = txtCustomerAddress.Text;

            currentCustomer.Vehicle.Brand = txtVehicleBrand.Text;
            currentCustomer.Vehicle.Model = txtVehicleModel.Text;
            currentCustomer.Vehicle.NumberPlate = txtVehicleNumberPlate.Text;

            currentCustomer.Vehicle.Staff.NameSurname = txtStaffNameSurname.Text;
            currentCustomer.Vehicle.Staff.Speciality = txtStaffSpeciality.Text;

            currentCustomer.Vehicle.Staff.Reparation.Operation = txtReparationOperation.Text;
            currentCustomer.Vehicle.Staff.Reparation.Price = txtReparationPrice.Text;
            currentCustomer.Vehicle.Staff.Reparation.AcceptanceTime = dtpReparationAcceptanceTime.Value.Date;
            currentCustomer.Vehicle.Staff.Reparation.DeliverTime = dtpReparationDeliverTime.Value.Date;

            try
            {
                _dbContext.SaveChanges();

                customerCollection = _dbContext.Set<Customer>().IncludeRelations(x => x.Vehicle, x => x.Vehicle.Staff, x => x.Vehicle.Staff.Reparation).OrderByDescending(x => x.CreatedDate).ToList();

                ClearGrid();

                FillGrid(customerCollection);

                MessageBox.Show(new Form() { TopMost = true }, "Müşteri güncellendi.", "Bilgilendirme");
            }
            catch (Exception ex)
            {
                var exception = new AppException("Güncelleme işlemi sırasında hata oluştu. Hata : " + ex, ex);

                MessageBox.Show(new Form() { TopMost = true }, "Güncelleme işlemi sırasında hata oluştu.", "Hata");
            }
        }

        private void SetPickerDateFormat()
        {
            dtpReparationAcceptanceTime.Format = DateTimePickerFormat.Custom;
            dtpReparationAcceptanceTime.CustomFormat = "dd.MM.yyyy HH:mm:ss";

            dtpReparationDeliverTime.Format = DateTimePickerFormat.Custom;
            dtpReparationDeliverTime.CustomFormat = "dd.MM.yyyy HH:mm:ss";
        }

        private void EnableControls()
        {
            frmLoading = (Loading)Application.OpenForms["Loading"];
            frmLoading.Close();
            frmMain.Enabled = true;
        }

        private void DisableControls()
        {
            frmMain.Enabled = false;
            frmLoading = new Loading();
            frmLoading.Show();
        }

        private void InitializeInputs()
        {
            txtCustomerNameSurname.Text = string.Empty;
            txtCustomerMobileNumber.Text = string.Empty;
            txtCustomerAddress.Text = string.Empty;
            txtVehicleBrand.Text = string.Empty;
            txtVehicleModel.Text = string.Empty;
            txtVehicleNumberPlate.Text = string.Empty;
            txtStaffNameSurname.Text = string.Empty;
            txtStaffSpeciality.Text = string.Empty;
            txtReparationOperation.Text = string.Empty;
            txtReparationPrice.Text = string.Empty;
            dtpReparationAcceptanceTime.Value = DateTime.Now;
            dtpReparationDeliverTime.Value = DateTime.Now;
            lblCustomerId.Text = string.Empty;
        }

        #region Validations

        private bool IsValid()
        {
            var isValid = true;

            if (!IsCustomerValid())
            {
                MessageBox.Show(new Form() { TopMost = true }, "Lütfen müşteri adı-soyadını ve telefon numarasını giriniz.", "Uyarı");

                isValid = false;
            }

            if (!IsVehicleValid())
            {
                MessageBox.Show(new Form() { TopMost = true }, "Lütfen araç modelini ve plakayı giriniz.", "Uyarı");

                isValid = false;
            }

            if (!IsStaffValid())
            {
                MessageBox.Show(new Form() { TopMost = true }, "Lütfen ustanın adı-soyadını giriniz.", "Uyarı");

                isValid = false;
            }

            if (!IsReparationValid())
            {
                MessageBox.Show(new Form() { TopMost = true }, "Lütfen onarım ile ilgili yapılan işlemi giriniz.", "Uyarı");

                isValid = false;
            }

            return isValid;

        }

        private bool IsCustomerValid()
        {
            var isValid = true;

            if (txtCustomerNameSurname.Text.IsNullOrEmpty() && txtCustomerMobileNumber.Text.IsNullOrEmpty())
            {
                isValid = false;
            }

            return isValid;

        }

        private bool IsVehicleValid()
        {
            var isValid = true;

            if (txtVehicleBrand.Text.IsNullOrEmpty() && txtVehicleNumberPlate.Text.IsNullOrEmpty())
            {
                isValid = false;
            }

            return isValid;
        }

        private bool IsStaffValid()
        {
            var isValid = true;

            if (txtStaffNameSurname.Text.IsNullOrEmpty())
            {
                isValid = false;
            }

            return isValid;

        }

        private bool IsReparationValid()
        {
            var isValid = true;

            if (txtReparationOperation.Text.IsNullOrEmpty())
            {
                isValid = false;
            }

            return isValid;

        }

        #endregion

        #endregion
         
    }
}
