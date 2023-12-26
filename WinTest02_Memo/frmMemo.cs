using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinTest02_Memo
{
    public partial class frmMemo : Form
    {
        public frmMemo()
        {
            InitializeComponent();
        }
        private void mnuNew_Click(object sender, EventArgs e)
        {
            tbMemo.Clear();
        }
        private void mnuOpen_Click(object sender, EventArgs e)
        {
            DialogResult r = openFileDialog1.ShowDialog();
            if (r == DialogResult.OK)
            {
                string fn = openFileDialog1.FileName;
                FileStream fi = new FileStream(fn,FileMode.Open);
                StreamReader sr = new StreamReader(fi);
                tbMemo.Text = sr.ReadToEnd();
            }
        }
        private void mnuSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog();
            sf.Filter = "텍스트 문서(*.txt)|*.txt|All file (*.*)|";
            if (sf.ShowDialog()==DialogResult.OK)
            {
                this.Text= sf.FileName;
            }
        }
        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void mnuFind_Click(object sender, EventArgs e)
        {
            try
            {
                frmSearch frm = new frmSearch(1);
                frm.ShowDialog();
                string str1 = frm.tbFind.Text;
                tbMemo.Select(tbMemo.Text.IndexOf(str1), str1.Length);
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void mnuFind_Replace_Click(object sender, EventArgs e)
        {
            frmSearch frm = new frmSearch();
            frm.ShowDialog();
            string str1 = frm.tbFind.Text;
            string str2 = frm.tbReplace.Text;
            tbMemo.Text = tbMemo.Text.Replace(str1,str2);
        }

        private void mnuAboutMyName_Click(object sender, EventArgs e)
        {
            frmAbout frm = new frmAbout();
            frm.ShowDialog();
        }
    }
}
