using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

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
                            using (SqlCommand com = new SqlCommand("SELECT * FROM Bookings", con))
                            {

                                using (SqlDataReader rd = com.ExecuteReader())
                                {
                                    while (rd.Read())
                                    {
                                        SessionContext.bookRowCount++;
                                    }
                                }

                                com.CommandText = $"SELECT Name, Role, AcountID FROM Accounts WHERE Name = '{usrbx.Text}'";
                                using (SqlDataReader rd = com.ExecuteReader())
                                {
                                    if (rd.HasRows)
                                    {
                                        rd.Read();
                                        switch (rd["Role"].ToString())
                                        {
                                            case "Customer":
                                                SessionContext.Name = rd["Name"].ToString();
                                                SessionContext.ID = (int)rd["AcountID"];
                                                MessageBox.Show($"Welcome back {rd["Name"].ToString()}!");
                                                C_Book c = new C_Book();
                                                c.ShowDialog();
                                                break;

                                            case "Waiter":
                                                SessionContext.Name = rd["Name"].ToString();
                                                SessionContext.ID = (int)rd["AcountID"];
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
                MessageBox.Show("An error occurred. Please try again: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (e.KeyCode == Keys.Enter)
            {
                enter(e);
            }
        }

        #endregion

    }
}