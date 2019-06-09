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

        private void AccountsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.accountsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.restaurantDataSet);

        }

        private void Admin_page_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'restaurantDataSet.Booking' table. You can move, or remove it, as needed.
            this.bookingTableAdapter.Fill(this.restaurantDataSet.Booking);
            // TODO: This line of code loads data into the 'restaurantDataSet.Waiters' table. You can move, or remove it, as needed.
            this.waitersTableAdapter.Fill(this.restaurantDataSet.Waiters);
            // TODO: This line of code loads data into the 'restaurantDataSet.Menu' table. You can move, or remove it, as needed.
            this.menuTableAdapter.Fill(this.restaurantDataSet.Menu);
            // TODO: This line of code loads data into the 'restaurantDataSet.Accounts' table. You can move, or remove it, as needed.
            this.accountsTableAdapter.Fill(this.restaurantDataSet.Accounts);

        }

        private void AccountsDataGridView_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
