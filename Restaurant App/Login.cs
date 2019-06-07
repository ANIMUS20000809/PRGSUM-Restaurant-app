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

        #region Event Handlers
        private void Form1_Load(object sender, EventArgs e)
        {
            load();
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

        #region Functions

        private void validate()
        {
            try
            {
                if (usrbx.Text != "" && pwdbx.Text != "")
                {
                    if (usrbx.Text == "Admin" && pwdbx.Text == "Admin")
                    {
                        SessionContext.Role = SessionContext.SessionContextRole.Admin;
                    }
                    else 
                    {
                        using (SqlConnection con = new SqlConnection(SessionContext.ConnectionString))
                        {
                            using (SqlCommand com = new SqlCommand())
                            {
                                com.Connection = con;
                                com.CommandText = $"SELECT Name, Role FROM Accounts WHERE Name = '{usrbx.Text}'";

                                using (SqlDataReader reader = com.ExecuteReader)
                                {

                                }
                            }
                        }
                    }

                    MessageBox.Show($"Welcome back {SessionContext.Role}!");
                }
                else
                {
                    MessageBox.Show("Username or password is incorrect. Please try again");
                }


            }
            catch (FormatException fEx)
            {
                MessageBox.Show(fEx.Message);
            }
            catch (Exception)
            {
                MessageBox.Show("An error ocurred. Please try again");
            }
        }

        private void enter(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                pwdbx.Focus();
            }
        }

        private void load()
        {
            SessionContext.update();
            this.ActiveControl = usrbx;
            usrbx.Focus();
        }

        #endregion
    }
}
