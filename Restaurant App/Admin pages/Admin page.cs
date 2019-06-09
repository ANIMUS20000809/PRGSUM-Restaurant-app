using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_App
{
    public partial class Admin_page : Form
    {
        public Admin_page()
        {
            InitializeComponent();
        }

        #region Event Handlers
        private void AccountsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.accountsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.restaurantDataSet);

        }

        private void Admin_page_Load(object sender, EventArgs e)
        {
            this.bookingTableAdapter.Fill(this.restaurantDataSet.Booking);
            this.menuTableAdapter.Fill(this.restaurantDataSet.Menu);
            this.accountsTableAdapter.Fill(this.restaurantDataSet.Accounts);

        }

        private void BookingDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            BindingNavigator.BindingSource = bookingBindingSource;
        }

        private void MenuDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            BindingNavigator.BindingSource = menuBindingSource;
        }

        private void AccountsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            BindingNavigator.BindingSource = accountsBindingSource;
        } 
        #endregion
    }
}
