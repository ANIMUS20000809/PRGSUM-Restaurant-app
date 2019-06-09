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
        public Login()
        {
            InitializeComponent();
        }

        #region Methods
        /// <summary>
        /// Checks the username
        /// </summary>
        private void validate()
        {
            try
            {
                if (usrbx.Text == "Admin")
                {
                    MessageBox.Show($"Welcome back Admin!");
                    Admin_page a = new Admin_page();
                    a.ShowDialog();
                }
                else
                {
                    using (SqlConnection con = new SqlConnection(SessionContext.ConnectionString))
                    {
                        con.Open();

                        if (con.State == ConnectionState.Open)
                        {
                            using (SqlCommand com = new SqlCommand($"SELECT Name, Role FROM Accounts WHERE Name = '{usrbx.Text}'", con))
                            {
                                using (SqlDataReader rd = com.ExecuteReader())
                                {
                                    if (rd.HasRows)
                                    {
                                        rd.Read();
                                        switch (rd["Role"].ToString())
                                        {
                                            case "Customers":
                                                MessageBox.Show($"Welcome back {rd["Name"].ToString()}!");
                                                C_Book c = new C_Book();
                                                c.ShowDialog();
                                                break;

                                            case "Waiters":
                                                MessageBox.Show($"Welcome back {rd["Name"].ToString()}!");
                                                W_Tables w = new W_Tables();
                                                w.ShowDialog();
                                                break;

                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Username or password incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                            }
                        }
                    } 
                }
            }
            catch (FormatException fEx)
            {
                MessageBox.Show(fEx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (InvalidOperationException iex)
            {
                MessageBox.Show(iex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error ocurred. Please try again: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
