using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinTest02_Memo
{
    public partial class frmSearch : Form
    {
        public frmSearch(int op=0)
        {
            InitializeComponent();
            if (op == 1)
            {
                tbReplace.Visible = false;
                label2.Visible = false;
            }
        }
    }
}
