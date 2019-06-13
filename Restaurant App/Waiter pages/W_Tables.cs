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
    public partial class W_Tables : Form
    {
        public W_Tables()
        {
            InitializeComponent();
        }

        #region Methods
        private void selectTable(string table)
        {
            SessionContext.Table = table;
            W_Spec s = new W_Spec();
            s.ShowDialog();
        }
        #endregion

        #region Event Handlers
        private void Button1_Click(object sender, EventArgs e)
        {
            selectTable(button1.Text);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            selectTable(button2.Text);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            selectTable(button3.Text);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            selectTable(button4.Text);
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            selectTable(button5.Text);
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            selectTable(button6.Text);
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            selectTable(button7.Text);
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            selectTable(button8.Text);
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            selectTable(button9.Text);
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            selectTable(button10.Text);
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            selectTable(button11.Text);
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            selectTable(button12.Text);
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            selectTable(button13.Text);
        }

        private void Button14_Click(object sender, EventArgs e)
        {
            selectTable(button14.Text);
        }

        private void Button15_Click(object sender, EventArgs e)
        {
            selectTable(button15.Text);
        }

        private void Button16_Click(object sender, EventArgs e)
        {
            selectTable(button16.Text);
        }

        private void Button17_Click(object sender, EventArgs e)
        {
            selectTable(button17.Text);
        }

        private void Button18_Click(object sender, EventArgs e)
        {
            selectTable(button18.Text);
        }

        private void Button19_Click(object sender, EventArgs e)
        {
            selectTable(button19.Text);
        }

        private void Button20_Click(object sender, EventArgs e)
        {
            selectTable(button20.Text);
        }

        private void W_Tables_Load(object sender, EventArgs e)
        {
            switch (SessionContext.ID)
            {
                case 6:
                    button1.Enabled = true;
                    button2.Enabled = true;
                    button3.Enabled = true;
                    button4.Enabled = true;
                    break;
                case 7:
                    button5.Enabled = true;
                    button6.Enabled = true;
                    button7.Enabled = true;
                    button8.Enabled = true;
                    break;
                case 8:
                    button9.Enabled = true;
                    button10.Enabled = true;
                    button11.Enabled = true;
                    button12.Enabled = true;
                    break;
                case 9:
                    button13.Enabled = true;
                    button14.Enabled = true;
                    button15.Enabled = true;
                    button16.Enabled = true;
                    break;
                case 10:
                    button17.Enabled = true;
                    button18.Enabled = true;
                    button19.Enabled = true;
                    button20.Enabled = true;
                    break;

            }
        }
        #endregion
    }
}
