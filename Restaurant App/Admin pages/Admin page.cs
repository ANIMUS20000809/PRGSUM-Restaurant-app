using System;
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

        private void Admin_page_Load(object sender, EventArgs e)
        {
            loadData();

        }

        private void BookingsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Focus(sender);
        }

        private void AccountsDataGridView_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            Focus(sender);
        }

        private void MenuDataGridView_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            Focus(sender);
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            saveToDatabase();
        }

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();

                this.accountsBindingSource.EndEdit();
                this.accountsTableAdapter1.Update(this.restaurantFinal);

                this.bookingsBindingSource.EndEdit();
                this.bookingsTableAdapter.Update(this.restaurantFinal);

                this.menuBindingSource.EndEdit();
                this.menuTableAdapter1.Update(this.restaurantFinal);

                this.tableAdapterManager1.UpdateAll(this.restaurantFinal);

                MessageBox.Show("Saved to database!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Linking the bindingnavigator to the tablegridview in focus
        /// </summary>
        /// <param name="sender">Object that sent the event</param>
        private void Focus(object sender)
        {
            DataGridView dgv = (DataGridView)sender;

            switch (dgv.Name)
            {
                case "menuDataGridView":
                    bindingNavigator1.BindingSource = menuBindingSource1;
                    break;
                case "accountsDataGridView":
                    bindingNavigator1.BindingSource = accountsBindingSource1;
                    break;
                case "bookingsDataGridView":
                    bindingNavigator1.BindingSource = bookingsBindingSource;
                    break;
            }
        }
        /// <summary>
        /// Filling the tablegridviews
        /// </summary>
        private void loadData()
        {
            // TODO: This line of code loads data into the 'restaurantFinal.Bookings' table. You can move, or remove it, as needed.
            this.bookingsTableAdapter.Fill(this.restaurantFinal.Bookings);
            // TODO: This line of code loads data into the 'restaurantFinal.Menu' table. You can move, or remove it, as needed.
            this.menuTableAdapter1.Fill(this.restaurantFinal.Menu);
            // TODO: This line of code loads data into the 'restaurantFinal.Accounts' table. You can move, or remove it, as needed.
            this.accountsTableAdapter1.Fill(this.restaurantFinal.Accounts);
        }
        /// <summary>
        /// Saving the Data to the database
        /// </summary>
        private void saveToDatabase()
        {
            try
            {
                this.Validate();

                this.accountsBindingSource.EndEdit();
                this.accountsTableAdapter1.Update(this.restaurantFinal.Accounts);

                this.bookingsBindingSource.EndEdit();
                this.bookingsTableAdapter.Update(this.restaurantFinal.Bookings);

                this.menuBindingSource.EndEdit();
                this.menuTableAdapter1.Update(this.restaurantFinal.Menu);

                this.tableAdapterManager1.UpdateAll(this.restaurantFinal);

                MessageBox.Show("Saved to database!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion
    }
}