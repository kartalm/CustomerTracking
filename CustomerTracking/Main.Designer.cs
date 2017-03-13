namespace CustomerTracking
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.txtCustomerNameSurname = new System.Windows.Forms.TextBox();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCustomerMobileNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCustomerAddress = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtStaffNameSurname = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtStaffSpeciality = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txtReparationOperation = new System.Windows.Forms.RichTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.dtpReparationAcceptanceTime = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.dtpReparationDeliverTime = new System.Windows.Forms.DateTimePicker();
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.CustomerPagingPanel = new System.Windows.Forms.Panel();
            this.toolStripPaging = new System.Windows.Forms.ToolStrip();
            this.btnFirstCustomer = new System.Windows.Forms.ToolStripButton();
            this.btnBackwardCustomer = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonCustomer1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonCustomer2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonCustomer3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonCustomer4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonCustomer5 = new System.Windows.Forms.ToolStripButton();
            this.btnForwardCustomer = new System.Windows.Forms.ToolStripButton();
            this.btnLastCustomer = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtReparationPrice = new System.Windows.Forms.TextBox();
            this.rbCustomerNameSurname = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtVehicleBrand = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtVehicleModel = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtVehicleNumberPlate = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rbVehicleBrandOrModel = new System.Windows.Forms.RadioButton();
            this.rbNumberPlate = new System.Windows.Forms.RadioButton();
            this.rbReparationOperation = new System.Windows.Forms.RadioButton();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblCustomerId = new System.Windows.Forms.Label();
            this.btnGetCustomers = new System.Windows.Forms.Button();
            this.lblCustomerCount = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCreatePdf = new System.Windows.Forms.Button();
            this.btnNewCustomer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            this.CustomerPagingPanel.SuspendLayout();
            this.toolStripPaging.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCustomerNameSurname
            // 
            this.txtCustomerNameSurname.CausesValidation = false;
            this.txtCustomerNameSurname.Location = new System.Drawing.Point(143, 46);
            this.txtCustomerNameSurname.MaxLength = 50;
            this.txtCustomerNameSurname.Name = "txtCustomerNameSurname";
            this.txtCustomerNameSurname.Size = new System.Drawing.Size(214, 23);
            this.txtCustomerNameSurname.TabIndex = 93;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.CausesValidation = false;
            this.lblCustomerName.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCustomerName.Location = new System.Drawing.Point(58, 45);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(79, 19);
            this.lblCustomerName.TabIndex = 94;
            this.lblCustomerName.Text = "Adı Soyadı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.CausesValidation = false;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(16, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 19);
            this.label1.TabIndex = 95;
            this.label1.Text = "Telefon Numarası";
            // 
            // txtCustomerMobileNumber
            // 
            this.txtCustomerMobileNumber.CausesValidation = false;
            this.txtCustomerMobileNumber.Location = new System.Drawing.Point(143, 87);
            this.txtCustomerMobileNumber.MaxLength = 50;
            this.txtCustomerMobileNumber.Name = "txtCustomerMobileNumber";
            this.txtCustomerMobileNumber.Size = new System.Drawing.Size(214, 23);
            this.txtCustomerMobileNumber.TabIndex = 96;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.CausesValidation = false;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(87, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 19);
            this.label2.TabIndex = 97;
            this.label2.Text = "Adresi";
            // 
            // txtCustomerAddress
            // 
            this.txtCustomerAddress.CausesValidation = false;
            this.txtCustomerAddress.Location = new System.Drawing.Point(143, 130);
            this.txtCustomerAddress.MaxLength = 1000;
            this.txtCustomerAddress.Name = "txtCustomerAddress";
            this.txtCustomerAddress.Size = new System.Drawing.Size(214, 83);
            this.txtCustomerAddress.TabIndex = 98;
            this.txtCustomerAddress.Text = "";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.CausesValidation = false;
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(9, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 19);
            this.label9.TabIndex = 109;
            this.label9.Text = "Adı Soyadı";
            // 
            // txtStaffNameSurname
            // 
            this.txtStaffNameSurname.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtStaffNameSurname.CausesValidation = false;
            this.txtStaffNameSurname.Location = new System.Drawing.Point(113, 40);
            this.txtStaffNameSurname.MaxLength = 50;
            this.txtStaffNameSurname.Name = "txtStaffNameSurname";
            this.txtStaffNameSurname.Size = new System.Drawing.Size(214, 23);
            this.txtStaffNameSurname.TabIndex = 102;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.CausesValidation = false;
            this.label10.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(9, 88);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 19);
            this.label10.TabIndex = 111;
            this.label10.Text = "Uzmanlığı";
            // 
            // txtStaffSpeciality
            // 
            this.txtStaffSpeciality.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtStaffSpeciality.CausesValidation = false;
            this.txtStaffSpeciality.Location = new System.Drawing.Point(113, 82);
            this.txtStaffSpeciality.MaxLength = 50;
            this.txtStaffSpeciality.Name = "txtStaffSpeciality";
            this.txtStaffSpeciality.Size = new System.Drawing.Size(214, 23);
            this.txtStaffSpeciality.TabIndex = 103;
            // 
            // btnSave
            // 
            this.btnSave.CausesValidation = false;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Location = new System.Drawing.Point(262, 261);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(106, 75);
            this.btnSave.TabIndex = 110;
            this.btnSave.Text = "Kaydet";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.CausesValidation = false;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClear.Location = new System.Drawing.Point(374, 261);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(115, 75);
            this.btnClear.TabIndex = 111;
            this.btnClear.Text = "Temizle";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.CausesValidation = false;
            this.label12.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(15, 47);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(93, 19);
            this.label12.TabIndex = 115;
            this.label12.Text = "Yapılan İşlem";
            // 
            // txtReparationOperation
            // 
            this.txtReparationOperation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtReparationOperation.CausesValidation = false;
            this.txtReparationOperation.Location = new System.Drawing.Point(114, 41);
            this.txtReparationOperation.MaxLength = 7500;
            this.txtReparationOperation.Name = "txtReparationOperation";
            this.txtReparationOperation.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtReparationOperation.Size = new System.Drawing.Size(302, 168);
            this.txtReparationOperation.TabIndex = 104;
            this.txtReparationOperation.Text = "";
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.CausesValidation = false;
            this.label14.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(56, 254);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(141, 19);
            this.label14.TabIndex = 119;
            this.label14.Text = "Teslim Alınma Tarihi";
            // 
            // dtpReparationAcceptanceTime
            // 
            this.dtpReparationAcceptanceTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpReparationAcceptanceTime.CausesValidation = false;
            this.dtpReparationAcceptanceTime.Location = new System.Drawing.Point(203, 251);
            this.dtpReparationAcceptanceTime.Name = "dtpReparationAcceptanceTime";
            this.dtpReparationAcceptanceTime.Size = new System.Drawing.Size(214, 23);
            this.dtpReparationAcceptanceTime.TabIndex = 106;
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.CausesValidation = false;
            this.label15.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(56, 293);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(140, 19);
            this.label15.TabIndex = 121;
            this.label15.Text = "Teslim Edilme Tarihi";
            // 
            // dtpReparationDeliverTime
            // 
            this.dtpReparationDeliverTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpReparationDeliverTime.CausesValidation = false;
            this.dtpReparationDeliverTime.Location = new System.Drawing.Point(202, 290);
            this.dtpReparationDeliverTime.Name = "dtpReparationDeliverTime";
            this.dtpReparationDeliverTime.Size = new System.Drawing.Size(214, 23);
            this.dtpReparationDeliverTime.TabIndex = 107;
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.AllowUserToAddRows = false;
            this.dgvCustomers.AllowUserToDeleteRows = false;
            this.dgvCustomers.AllowUserToOrderColumns = true;
            this.dgvCustomers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCustomers.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvCustomers.CausesValidation = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCustomers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCustomers.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCustomers.Location = new System.Drawing.Point(7, 377);
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCustomers.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCustomers.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dgvCustomers.Size = new System.Drawing.Size(1457, 315);
            this.dgvCustomers.TabIndex = 120;
            this.dgvCustomers.TabStop = false;
            this.dgvCustomers.SelectionChanged += new System.EventHandler(this.dgvCustomers_SelectionChanged);
            // 
            // CustomerPagingPanel
            // 
            this.CustomerPagingPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CustomerPagingPanel.BackColor = System.Drawing.Color.White;
            this.CustomerPagingPanel.CausesValidation = false;
            this.CustomerPagingPanel.Controls.Add(this.toolStripPaging);
            this.CustomerPagingPanel.Location = new System.Drawing.Point(580, 698);
            this.CustomerPagingPanel.Name = "CustomerPagingPanel";
            this.CustomerPagingPanel.Size = new System.Drawing.Size(231, 23);
            this.CustomerPagingPanel.TabIndex = 121;
            // 
            // toolStripPaging
            // 
            this.toolStripPaging.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.toolStripPaging.BackColor = System.Drawing.Color.White;
            this.toolStripPaging.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStripPaging.CanOverflow = false;
            this.toolStripPaging.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripPaging.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripPaging.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnFirstCustomer,
            this.btnBackwardCustomer,
            this.toolStripButtonCustomer1,
            this.toolStripButtonCustomer2,
            this.toolStripButtonCustomer3,
            this.toolStripButtonCustomer4,
            this.toolStripButtonCustomer5,
            this.btnForwardCustomer,
            this.btnLastCustomer,
            this.toolStripButton1});
            this.toolStripPaging.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStripPaging.Location = new System.Drawing.Point(18, 0);
            this.toolStripPaging.Name = "toolStripPaging";
            this.toolStripPaging.ShowItemToolTips = false;
            this.toolStripPaging.Size = new System.Drawing.Size(210, 25);
            this.toolStripPaging.TabIndex = 0;
            // 
            // btnFirstCustomer
            // 
            this.btnFirstCustomer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnFirstCustomer.Image = global::CustomerTracking.Properties.Resources.fastreverse;
            this.btnFirstCustomer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFirstCustomer.Name = "btnFirstCustomer";
            this.btnFirstCustomer.Size = new System.Drawing.Size(23, 22);
            this.btnFirstCustomer.Click += new System.EventHandler(this.CustomerToolStripButtonClick);
            // 
            // btnBackwardCustomer
            // 
            this.btnBackwardCustomer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnBackwardCustomer.Image = global::CustomerTracking.Properties.Resources.Back;
            this.btnBackwardCustomer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBackwardCustomer.Name = "btnBackwardCustomer";
            this.btnBackwardCustomer.Size = new System.Drawing.Size(23, 22);
            this.btnBackwardCustomer.Text = "<";
            this.btnBackwardCustomer.Click += new System.EventHandler(this.CustomerToolStripButtonClick);
            // 
            // toolStripButtonCustomer1
            // 
            this.toolStripButtonCustomer1.BackColor = System.Drawing.Color.White;
            this.toolStripButtonCustomer1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonCustomer1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCustomer1.Image")));
            this.toolStripButtonCustomer1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCustomer1.Name = "toolStripButtonCustomer1";
            this.toolStripButtonCustomer1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonCustomer1.Text = "1";
            this.toolStripButtonCustomer1.Click += new System.EventHandler(this.CustomerToolStripButtonClick);
            // 
            // toolStripButtonCustomer2
            // 
            this.toolStripButtonCustomer2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonCustomer2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCustomer2.Name = "toolStripButtonCustomer2";
            this.toolStripButtonCustomer2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonCustomer2.Text = "2";
            this.toolStripButtonCustomer2.Click += new System.EventHandler(this.CustomerToolStripButtonClick);
            // 
            // toolStripButtonCustomer3
            // 
            this.toolStripButtonCustomer3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonCustomer3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCustomer3.Name = "toolStripButtonCustomer3";
            this.toolStripButtonCustomer3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonCustomer3.Text = "3";
            this.toolStripButtonCustomer3.Click += new System.EventHandler(this.CustomerToolStripButtonClick);
            // 
            // toolStripButtonCustomer4
            // 
            this.toolStripButtonCustomer4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonCustomer4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCustomer4.Name = "toolStripButtonCustomer4";
            this.toolStripButtonCustomer4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonCustomer4.Text = "4";
            this.toolStripButtonCustomer4.Click += new System.EventHandler(this.CustomerToolStripButtonClick);
            // 
            // toolStripButtonCustomer5
            // 
            this.toolStripButtonCustomer5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonCustomer5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCustomer5.Name = "toolStripButtonCustomer5";
            this.toolStripButtonCustomer5.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonCustomer5.Text = "5";
            this.toolStripButtonCustomer5.Click += new System.EventHandler(this.CustomerToolStripButtonClick);
            // 
            // btnForwardCustomer
            // 
            this.btnForwardCustomer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnForwardCustomer.Image = global::CustomerTracking.Properties.Resources.Forward;
            this.btnForwardCustomer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnForwardCustomer.Name = "btnForwardCustomer";
            this.btnForwardCustomer.Size = new System.Drawing.Size(23, 22);
            this.btnForwardCustomer.Text = ">";
            this.btnForwardCustomer.Click += new System.EventHandler(this.CustomerToolStripButtonClick);
            // 
            // btnLastCustomer
            // 
            this.btnLastCustomer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnLastCustomer.Image = global::CustomerTracking.Properties.Resources.fastforward;
            this.btnLastCustomer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLastCustomer.Name = "btnLastCustomer";
            this.btnLastCustomer.Size = new System.Drawing.Size(23, 22);
            this.btnLastCustomer.Tag = "";
            this.btnLastCustomer.Click += new System.EventHandler(this.CustomerToolStripButtonClick);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Visible = false;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtSearch.CausesValidation = false;
            this.txtSearch.Location = new System.Drawing.Point(7, 341);
            this.txtSearch.MaxLength = 50;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(236, 20);
            this.txtSearch.TabIndex = 114;
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.AutoSize = true;
            this.label17.CausesValidation = false;
            this.label17.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label17.Location = new System.Drawing.Point(147, 216);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(49, 19);
            this.label17.TabIndex = 131;
            this.label17.Text = "Bakiye";
            // 
            // txtReparationPrice
            // 
            this.txtReparationPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtReparationPrice.CausesValidation = false;
            this.txtReparationPrice.Location = new System.Drawing.Point(202, 215);
            this.txtReparationPrice.MaxLength = 50;
            this.txtReparationPrice.Name = "txtReparationPrice";
            this.txtReparationPrice.Size = new System.Drawing.Size(214, 23);
            this.txtReparationPrice.TabIndex = 105;
            // 
            // rbCustomerNameSurname
            // 
            this.rbCustomerNameSurname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rbCustomerNameSurname.AutoSize = true;
            this.rbCustomerNameSurname.CausesValidation = false;
            this.rbCustomerNameSurname.Location = new System.Drawing.Point(252, 342);
            this.rbCustomerNameSurname.Name = "rbCustomerNameSurname";
            this.rbCustomerNameSurname.Size = new System.Drawing.Size(112, 17);
            this.rbCustomerNameSurname.TabIndex = 115;
            this.rbCustomerNameSurname.TabStop = true;
            this.rbCustomerNameSurname.Text = "Müşteri Adı Soyadı";
            this.rbCustomerNameSurname.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCustomerNameSurname);
            this.groupBox1.Controls.Add(this.lblCustomerName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtCustomerMobileNumber);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtCustomerAddress);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(7, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(377, 242);
            this.groupBox1.TabIndex = 134;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MÜŞTERİ BİLGİLERİ";
            // 
            // btnDelete
            // 
            this.btnDelete.CausesValidation = false;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Location = new System.Drawing.Point(495, 261);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(115, 75);
            this.btnDelete.TabIndex = 112;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox2.CausesValidation = false;
            this.groupBox2.Controls.Add(this.txtVehicleBrand);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtVehicleModel);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtVehicleNumberPlate);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(394, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(300, 242);
            this.groupBox2.TabIndex = 136;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ARAÇ BİLGİLERİ";
            // 
            // txtVehicleBrand
            // 
            this.txtVehicleBrand.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtVehicleBrand.CausesValidation = false;
            this.txtVehicleBrand.Location = new System.Drawing.Point(80, 46);
            this.txtVehicleBrand.MaxLength = 50;
            this.txtVehicleBrand.Name = "txtVehicleBrand";
            this.txtVehicleBrand.Size = new System.Drawing.Size(214, 23);
            this.txtVehicleBrand.TabIndex = 99;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.CausesValidation = false;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(18, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 19);
            this.label5.TabIndex = 114;
            this.label5.Text = "Marka";
            // 
            // txtVehicleModel
            // 
            this.txtVehicleModel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtVehicleModel.CausesValidation = false;
            this.txtVehicleModel.Location = new System.Drawing.Point(80, 88);
            this.txtVehicleModel.MaxLength = 50;
            this.txtVehicleModel.Name = "txtVehicleModel";
            this.txtVehicleModel.Size = new System.Drawing.Size(214, 23);
            this.txtVehicleModel.TabIndex = 100;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.CausesValidation = false;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(18, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 19);
            this.label6.TabIndex = 116;
            this.label6.Text = "Model";
            // 
            // txtVehicleNumberPlate
            // 
            this.txtVehicleNumberPlate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtVehicleNumberPlate.CausesValidation = false;
            this.txtVehicleNumberPlate.Location = new System.Drawing.Point(80, 131);
            this.txtVehicleNumberPlate.MaxLength = 50;
            this.txtVehicleNumberPlate.Name = "txtVehicleNumberPlate";
            this.txtVehicleNumberPlate.Size = new System.Drawing.Size(214, 23);
            this.txtVehicleNumberPlate.TabIndex = 101;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.CausesValidation = false;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(23, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 19);
            this.label7.TabIndex = 118;
            this.label7.Text = "Plaka";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox3.CausesValidation = false;
            this.groupBox3.Controls.Add(this.txtStaffNameSurname);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtStaffSpeciality);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(700, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(333, 241);
            this.groupBox3.TabIndex = 137;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "USTA BİLGİLERİ";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.CausesValidation = false;
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.txtReparationOperation);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.txtReparationPrice);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.dtpReparationAcceptanceTime);
            this.groupBox4.Controls.Add(this.dtpReparationDeliverTime);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox4.Location = new System.Drawing.Point(1042, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(422, 323);
            this.groupBox4.TabIndex = 138;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "ONARIM BİLGİLERİ";
            // 
            // rbVehicleBrandOrModel
            // 
            this.rbVehicleBrandOrModel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rbVehicleBrandOrModel.AutoSize = true;
            this.rbVehicleBrandOrModel.CausesValidation = false;
            this.rbVehicleBrandOrModel.Location = new System.Drawing.Point(383, 342);
            this.rbVehicleBrandOrModel.Name = "rbVehicleBrandOrModel";
            this.rbVehicleBrandOrModel.Size = new System.Drawing.Size(138, 17);
            this.rbVehicleBrandOrModel.TabIndex = 116;
            this.rbVehicleBrandOrModel.TabStop = true;
            this.rbVehicleBrandOrModel.Text = "Araç Marka veya Model";
            this.rbVehicleBrandOrModel.UseVisualStyleBackColor = true;
            // 
            // rbNumberPlate
            // 
            this.rbNumberPlate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rbNumberPlate.AutoSize = true;
            this.rbNumberPlate.CausesValidation = false;
            this.rbNumberPlate.Location = new System.Drawing.Point(538, 342);
            this.rbNumberPlate.Name = "rbNumberPlate";
            this.rbNumberPlate.Size = new System.Drawing.Size(52, 17);
            this.rbNumberPlate.TabIndex = 117;
            this.rbNumberPlate.TabStop = true;
            this.rbNumberPlate.Text = "Plaka";
            this.rbNumberPlate.UseVisualStyleBackColor = true;
            // 
            // rbReparationOperation
            // 
            this.rbReparationOperation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rbReparationOperation.AutoSize = true;
            this.rbReparationOperation.CausesValidation = false;
            this.rbReparationOperation.Location = new System.Drawing.Point(607, 342);
            this.rbReparationOperation.Name = "rbReparationOperation";
            this.rbReparationOperation.Size = new System.Drawing.Size(87, 17);
            this.rbReparationOperation.TabIndex = 118;
            this.rbReparationOperation.TabStop = true;
            this.rbReparationOperation.Text = "Yapılan İşlem";
            this.rbReparationOperation.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSearch.CausesValidation = false;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.Location = new System.Drawing.Point(713, 343);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(172, 20);
            this.btnSearch.TabIndex = 119;
            this.btnSearch.Text = "Ara";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblCustomerId
            // 
            this.lblCustomerId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCustomerId.AutoSize = true;
            this.lblCustomerId.CausesValidation = false;
            this.lblCustomerId.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCustomerId.Location = new System.Drawing.Point(3, 261);
            this.lblCustomerId.Name = "lblCustomerId";
            this.lblCustomerId.Size = new System.Drawing.Size(0, 19);
            this.lblCustomerId.TabIndex = 143;
            this.lblCustomerId.Visible = false;
            // 
            // btnGetCustomers
            // 
            this.btnGetCustomers.CausesValidation = false;
            this.btnGetCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGetCustomers.Location = new System.Drawing.Point(7, 261);
            this.btnGetCustomers.Name = "btnGetCustomers";
            this.btnGetCustomers.Size = new System.Drawing.Size(137, 75);
            this.btnGetCustomers.TabIndex = 108;
            this.btnGetCustomers.Text = "Tüm Kayıtları Getir";
            this.btnGetCustomers.UseVisualStyleBackColor = true;
            this.btnGetCustomers.Click += new System.EventHandler(this.btnGetCustomers_Click);
            // 
            // lblCustomerCount
            // 
            this.lblCustomerCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCustomerCount.AutoSize = true;
            this.lblCustomerCount.CausesValidation = false;
            this.lblCustomerCount.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCustomerCount.Location = new System.Drawing.Point(1418, 342);
            this.lblCustomerCount.Name = "lblCustomerCount";
            this.lblCustomerCount.Size = new System.Drawing.Size(17, 19);
            this.lblCustomerCount.TabIndex = 145;
            this.lblCustomerCount.Text = "0";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.CausesValidation = false;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(1266, 343);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 19);
            this.label4.TabIndex = 146;
            this.label4.Text = "Toplam Kayıt Sayısı :";
            // 
            // btnCreatePdf
            // 
            this.btnCreatePdf.CausesValidation = false;
            this.btnCreatePdf.FlatAppearance.BorderSize = 0;
            this.btnCreatePdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreatePdf.Image = global::CustomerTracking.Properties.Resources.pdfimage;
            this.btnCreatePdf.Location = new System.Drawing.Point(616, 260);
            this.btnCreatePdf.Name = "btnCreatePdf";
            this.btnCreatePdf.Size = new System.Drawing.Size(45, 75);
            this.btnCreatePdf.TabIndex = 113;
            this.btnCreatePdf.UseVisualStyleBackColor = true;
            this.btnCreatePdf.Click += new System.EventHandler(this.btnCreatePdf_Click);
            // 
            // btnNewCustomer
            // 
            this.btnNewCustomer.CausesValidation = false;
            this.btnNewCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNewCustomer.Location = new System.Drawing.Point(150, 261);
            this.btnNewCustomer.Name = "btnNewCustomer";
            this.btnNewCustomer.Size = new System.Drawing.Size(106, 75);
            this.btnNewCustomer.TabIndex = 109;
            this.btnNewCustomer.Text = "Yeni Kayıt";
            this.btnNewCustomer.UseVisualStyleBackColor = true;
            this.btnNewCustomer.Click += new System.EventHandler(this.btnNewCustomer_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(1476, 741);
            this.Controls.Add(this.btnNewCustomer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblCustomerCount);
            this.Controls.Add(this.btnGetCustomers);
            this.Controls.Add(this.lblCustomerId);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.rbReparationOperation);
            this.Controls.Add(this.rbNumberPlate);
            this.Controls.Add(this.rbVehicleBrandOrModel);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rbCustomerNameSurname);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnCreatePdf);
            this.Controls.Add(this.CustomerPagingPanel);
            this.Controls.Add(this.dgvCustomers);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müşteri Takip Sistemi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            this.CustomerPagingPanel.ResumeLayout(false);
            this.CustomerPagingPanel.PerformLayout();
            this.toolStripPaging.ResumeLayout(false);
            this.toolStripPaging.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCustomerNameSurname;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCustomerMobileNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox txtCustomerAddress;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtStaffNameSurname;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtStaffSpeciality;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RichTextBox txtReparationOperation;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dtpReparationAcceptanceTime;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker dtpReparationDeliverTime;
        private System.Windows.Forms.DataGridView dgvCustomers;
        private System.Windows.Forms.Panel CustomerPagingPanel;
        private System.Windows.Forms.ToolStrip toolStripPaging;
        public System.Windows.Forms.ToolStripButton btnFirstCustomer;
        public System.Windows.Forms.ToolStripButton btnBackwardCustomer;
        public System.Windows.Forms.ToolStripButton toolStripButtonCustomer1;
        public System.Windows.Forms.ToolStripButton toolStripButtonCustomer2;
        public System.Windows.Forms.ToolStripButton toolStripButtonCustomer3;
        public System.Windows.Forms.ToolStripButton toolStripButtonCustomer4;
        public System.Windows.Forms.ToolStripButton toolStripButtonCustomer5;
        public System.Windows.Forms.ToolStripButton btnForwardCustomer;
        public System.Windows.Forms.ToolStripButton btnLastCustomer;
        private System.Windows.Forms.Button btnCreatePdf;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtReparationPrice;
        private System.Windows.Forms.RadioButton rbCustomerNameSurname;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtVehicleBrand;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtVehicleModel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtVehicleNumberPlate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rbVehicleBrandOrModel;
        private System.Windows.Forms.RadioButton rbNumberPlate;
        private System.Windows.Forms.RadioButton rbReparationOperation;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.Label lblCustomerId;
        private System.Windows.Forms.Button btnGetCustomers;
        private System.Windows.Forms.Label lblCustomerCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnNewCustomer;
    }
}

