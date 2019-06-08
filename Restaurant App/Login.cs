using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Restaurant_App
{
    public partial class Login : Form
    {
        public string constr = "Data Source=ANIMUS;Initial Catalog=Restaurant;Integrated Security=True";
        public Login()
        {
            InitializeComponent();
        }
        #region Methods
        // TODO: Search the user name from the fucking database!!!!
        /// <summary>
        /// Checks the username
        /// </summary>
        private void validate()
        {
            try
            {
                switch (usrbx.Text)
                {
                    case "Admin":
                        SessionContext.Role = SessionContext.SessionContextRole.Admin;
                        MessageBox.Show($"Welcome back {SessionContext.Role}!");
                        Admin_page a = new Admin_page();
                        a.ShowDialog();
                        break;

                    case "Richard":
                        SessionContext.Role = SessionContext.SessionContextRole.Customer;
                        MessageBox.Show($"Welcome back {SessionContext.Role}!");
                        C_Book c = new C_Book();
                        c.ShowDialog();
                        break;

                    case "Donovan":
                        SessionContext.Role = SessionContext.SessionContextRole.Waiter;
                        MessageBox.Show($"Welcome back {SessionContext.Role}!");
                        W_Tables w = new W_Tables();
                        w.ShowDialog();
                        break;

                    default:
                        MessageBox.Show("Username or password is incorrect");
                        break;
                }
            }
            catch (FormatException fEx)
            {
                MessageBox.Show(fEx.Message);
            }
            catch (InvalidOperationException iex)
            {
                MessageBox.Show(iex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error ocurred. Please try again: " + ex.Message);
            }
        }
        /// <summary>
        /// EventHandler for the enter key
        /// </summary>
        /// <param name="e"></param>
        private void enter(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && pwdbx.Text == "")
            {
                pwdbx.Focus();
            }
            else if (e.KeyCode == Keys.Enter && pwdbx.Text != "")
            {
                validate();
            }
        }
        /// <summary>
        /// Code for when the form is loaded
        /// </summary>
        private void Loading()
        {
            SessionContext.Connect();
            this.ActiveControl = usrbx;
            usrbx.Focus();
        }

        #endregion

        #region Event Handlers
        private void Form1_Load(object sender, EventArgs e)
        {
            Loading();
        }

        private void Lgn_Click(object sender, EventArgs e)
        {
            validate();
        }

        private void Usrbx_KeyDown(object sender, KeyEventArgs e)
        {
            enter(e);
        }
        #endregion


    }
}
