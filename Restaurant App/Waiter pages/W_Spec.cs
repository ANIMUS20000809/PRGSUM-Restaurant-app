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
    public partial class W_Spec : Form
    {
        private int bill;
        private List<int> list = new List<int>();
        public W_Spec()
        {
            InitializeComponent();
        }

        #region Methods
        /// <summary>
        /// Adding item to listbox and list
        /// </summary>
        private void addItem()
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    listBox1.Items.Add(comboBox1.SelectedItem.ToString() + " R100 x" + trackBar1.Value.ToString());
                    list.Add(100 * trackBar1.Value);
                    break;

                case 1:
                    listBox1.Items.Add(comboBox1.SelectedItem.ToString() + " R60 x" + trackBar1.Value.ToString());
                    list.Add(60 * trackBar1.Value);
                    break;

                case 2:
                    listBox1.Items.Add(comboBox1.SelectedItem.ToString() + " R120 x" + trackBar1.Value.ToString());
                    list.Add(120 * trackBar1.Value);
                    break;

                case 3:
                    listBox1.Items.Add(comboBox1.SelectedItem.ToString() + " R70 x" + trackBar1.Value.ToString());
                    list.Add(70 * trackBar1.Value);
                    break;

                case 4:
                    listBox1.Items.Add(comboBox1.SelectedItem.ToString() + " R70 x" + trackBar1.Value.ToString());
                    list.Add(70 * trackBar1.Value);
                    break;

                case -1:
                default:
                    MessageBox.Show("Please select an item from the menu");
                    break;
            }
        }

        private void Delete()
        {
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            list.RemoveAt(listBox1.SelectedIndex);
        }

        /// <summary>
        /// Checking out
        /// </summary>
        private void Checkout()
        {
            if (MessageBox.Show("Are sure you want to proceed? You won't be able to change the bill if you proceed", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
            {
                foreach (int item in list)
                {
                    bill += item;
                }

                label6.Text += "R" + bill.ToString();

                MessageBox.Show("Bill is completed!");
                btnAdd.Enabled = false;
                button1.Enabled = false;
                button2.Enabled = false;
            }
        }

        private void loadTable()
        {
            label1.Text += SessionContext.Table;
            label5.Text = trackBar1.Value.ToString();
        }

        private void changeLbl()
        {
            label5.Text = trackBar1.Value.ToString();
        }
        #endregion

        private void W_Spec_Load(object sender, EventArgs e)
        {
            loadTable();
        }

        private void TrackBar1_ValueChanged(object sender, EventArgs e)
        {
            changeLbl();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            addItem();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Checkout();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Delete();
        }
    }
}
