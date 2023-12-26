using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinTest01_Base
{
    public partial class frm : Form
    {
        public frm()
        {
            InitializeComponent();
            cmb1.SelectedIndex = 0;
            cmb2.SelectedIndex = 1;
            cmb3.SelectedIndex = 2;
            cmb4.SelectedIndex = 3;
        }

        int flag = 0;
        private void btnTest_Click(object sender, EventArgs e)
        {
            //if (++flag == 1) { label2.Text = "안녕하쇼"; }
            //else { label2.Text = "Hello"; flag = 0; }
            //if (label1.Text == "안녕하쇼") label1.Text = "Hello";
            //else { label1.Text = "안녕하쇼"; }
            int n = (flag++) % 4;
            switch(n)
            {
                case 0:
                    if (cb1.Checked == false) break;
                    tb1.Text = $"{n + 1}";
                    tb2.Text = "";
                    tb3.Text = "";
                    tb4.Text = "";
                    break;
                case 1:
                    if (cb2.Checked == false) break;
                    tb1.Text = "";
                    tb2.Text = $"{n + 1}";
                    tb3.Text = "";
                    tb4.Text = "";
                    break;
                case 2:
                    if (cb3.Checked == false) break;
                    tb1.Text = "";
                    tb2.Text = "";
                    tb3.Text = $"{n + 1}";
                    tb4.Text = "";
                    break;
                case 3:
                    if (cb4.Checked == false) break;
                    tb1.Text = "";
                    tb2.Text = "";
                    tb3.Text = "";
                    tb4.Text = $"{n + 1}";
                    break;
            }
        }

        private void cb1_CheckedChanged(object sender, EventArgs e)
        {
            if (cb1.Checked) { cmb1.Enabled = true; }
            else { cmb1.Enabled = false; }
        }

        private void cb2_CheckedChanged(object sender, EventArgs e)
        {
            if (cb2.Checked) { cmb2.Enabled = true; }
            else { cmb2.Enabled = false; }
        }

        private void cb3_CheckedChanged(object sender, EventArgs e)
        {
            if (cb3.Checked) { cmb3.Enabled = true; }
            else { cmb3.Enabled = false; }
        }

        private void cb4_CheckedChanged(object sender, EventArgs e)
        {
            if (cb4.Checked) { cmb4.Enabled = true; }
            else { cmb4.Enabled = false; }
        }

        private void menuE_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mnuUpper_Click(object sender, EventArgs e)
        {
            tb4.Text=tb4.Text.ToUpper();
        }

        private void mnuLower_Click(object sender, EventArgs e)
        {
            tb4.Text = tb4.Text.ToLower();
        }

        private void cmb1_SelectedIndexChanged(object sender, EventArgs e)
        {
            tb1.Text = cmb1.Text;
        }

        private void menuO_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) 
            {
                tbFileName.Text=openFileDialog1.FileName;
            }
        }
    }
}
