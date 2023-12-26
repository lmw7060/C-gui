using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinTest03_Com
{
    public partial class frmConfig : Form
    {
        public frmConfig()
        {
            InitializeComponent();
            //ComPort 인덱스값을 가져옴
            string[] sarr = System.IO.Ports.SerialPort.GetPortNames();
            for (int i = 0;i<sarr.Length;i++) cbCom.Items.Add(sarr[i]);
        }
    }
}