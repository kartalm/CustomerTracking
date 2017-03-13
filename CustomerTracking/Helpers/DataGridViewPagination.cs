using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerTracking.Helpers
{
    public class DataGridViewPagination
    {
        private int _currentPage = 1;

        private int _pageRows = 10;

        private int _pagesCount = 1;

        private DataGridView _dataGridView;

        ToolStripButton[] _items = new ToolStripButton[] { new ToolStripButton() { Name = "toolStripButton1" }, new ToolStripButton() { Name = "toolStripButton2" }, new ToolStripButton() { Name = "toolStripButton3" }, new ToolStripButton() { Name = "toolStripButton4" }, new ToolStripButton() { Name = "toolStripButton5" } };

        ToolStripButton _btnBackward;
        ToolStripButton _btnForward;
        ToolStripButton _btnLast;
        ToolStripButton _btnFirst;

        DataTable _dataTable;

        public DataGridViewPagination(DataGridView dgv, ToolStripButton[] items, ToolStripButton btnBackward, ToolStripButton btnForward, ToolStripButton btnLast, ToolStripButton btnFirst, DataTable dataTable)
        {
            _dataGridView = dgv;
            _items = items;
            _btnBackward = btnBackward;
            _btnForward = btnForward;
            _btnLast = btnLast;
            _btnFirst = btnFirst;
            _currentPage = 1;
            _dataTable = dataTable;

            RefreshPagination();
            RebindGridForPageChange();
        }

        public void RebindGridForPageChange()
        {
            //Rebinding the Datagridview with data
            int datasourcestartIndex = (_currentPage - 1) * _pageRows;
            
            _dataGridView.Refresh();
        }

        //Method that handles the pagination button clicks
        public void ToolStripButtonClick(object sender, EventArgs e)
        {
            try
            {
                ToolStripButton ToolStripButton = ((ToolStripButton)sender);

                //Determining the current page
                if (ToolStripButton == _btnBackward)
                    _currentPage--;
                else if (ToolStripButton == _btnForward)
                    _currentPage++;
                else if (ToolStripButton == _btnLast)
                    _currentPage = _pagesCount;
                else if (ToolStripButton == _btnFirst)
                    _currentPage = 1;
                else
                    _currentPage = Convert.ToInt32(ToolStripButton.Text, CultureInfo.InvariantCulture);

                if (_currentPage < 1)
                    _currentPage = 1;
                else if (_currentPage > _pagesCount)
                    _currentPage = _pagesCount;

                //Rebind the Datagridview with the data.
                RebindGridForPageChange();

                //Change the pagiantions buttons according to page number
                RefreshPagination();
            }
            catch (Exception) { }
        }

        public void RefreshPagination()
        {
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
                    _items[i - pageStartIndex].Visible = false;
                }
                else
                {
                    //Changing the page numbers
                    _items[i - pageStartIndex].Text = i.ToString(CultureInfo.InvariantCulture);

                    //Setting the Appearance of the page number buttons
                    if (i == _currentPage)
                    {
                        _items[i - pageStartIndex].BackColor = Color.Black;
                        _items[i - pageStartIndex].ForeColor = Color.White;
                    }
                    else
                    {
                        _items[i - pageStartIndex].BackColor = Color.White;
                        _items[i - pageStartIndex].ForeColor = Color.Black;
                    }
                }
            }

            //Enabling or Disalbing pagination first, last, previous , next buttons
            if (_currentPage == 1)
            {
                _btnBackward.Enabled = _btnFirst.Enabled = false;
            }
            else
            {
                _btnBackward.Enabled = _btnFirst.Enabled = true;
            }

            if (_currentPage == _pagesCount)
            {
                _btnForward.Enabled = _btnLast.Enabled = false;
            }
            else
            {
                _btnForward.Enabled = _btnLast.Enabled = true;
            }
        }

    }
}
