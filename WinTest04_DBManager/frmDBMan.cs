using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinTest04_DBManager
{
    public partial class frmDBMan : Form
    {
        public frmDBMan()
        {
            InitializeComponent();
        }

        SqlConnection sqlConn = new SqlConnection();
        SqlCommand sqlCommand = new SqlCommand();
        List<string> colName = new List<string>();
        private void mnuOpen_Click(object sender, EventArgs e)
        {
            DialogResult r =openFileDialog1.ShowDialog();
            if (r == DialogResult.OK)   
            {
                sqlConn.ConnectionString = $"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={openFileDialog1.FileName};Integrated Security=True;Connect Timeout=30";
                sqlConn.Open();
                sqlCommand.Connection = sqlConn;
                sbLabel1.Text = "DataBase connected...";
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {//test1
            string sql = "select * from Student";
            sqlCommand.CommandText = sql;
            SqlDataReader sr = sqlCommand.ExecuteReader();
            for(int i =0; sr.Read(); i++) 
            {
                for(int j =0; j < sr.FieldCount; j++) 
                {
                    textBox1.Text += sr.GetValue(j).ToString()+" ";
                    //tbSql.Text += sr.GetValue(j).ToString() + " ";
                }
                textBox1.Text += "\r\n";
            }
            sr.Close();
        }
        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {//test2
            dataView1.Rows.Clear();
            dataView1.Columns.Clear();

            List<string> sarr = RunSql("select * from Student");

            for (int i = 0; i < colName.Count; i++)
            {
                dataView1.Columns.Add(colName[i], colName[i]);
            }
            for (int i = 0; i < sarr.Count; i++)
            {
                int rIdx = dataView1.Rows.Add();
                for (int j = 0; j < colName.Count; j++)
                {
                    dataView1.Rows[rIdx].Cells[j].Value = sarr[i].Split(',')[j];
                }
            }
        }
        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {//test3
            ViewSql(RunSql("select * from Student"));
        }
        private void ViewSql(List<string> sarr)
        {
            if (sarr.Count == null) return;
            dataView1.Rows.Clear();
            dataView1.Columns.Clear();

            for (int i = 0; i<colName.Count; i++)
            {
                dataView1.Columns.Add(colName[i], colName[i]);
            }
            for(int i = 0; i<sarr.Count; i++)
            {
                int rIdx = dataView1.Rows.Add();
                for (int j = 0; j<colName.Count;j++)
                {
                    dataView1.Rows[rIdx].Cells[j].Value = sarr[i].Split(',')[j];
                }
            }
        }
        private List<string> RunSql(string sql)
        {
            try
            {
                List<string> sarr = new List<string>();
                sqlCommand.CommandText = sql;
                if (sql.Trim().ToLower().Substring(0, 6) == "select")
                {
                    SqlDataReader sr = sqlCommand.ExecuteReader();
                    colName.Clear();
                    for (int j = 0; j < sr.FieldCount; j++)
                    {
                        colName.Add(sr.GetName(j).ToString());
                    }
                    for (int i = 0; sr.Read(); i++)
                    {
                        string str = "";
                        for (int j = 0; j < sr.FieldCount; j++)
                        {
                            str += sr.GetValue(j).ToString() + ",";
                        }
                        sarr.Add(str);
                    }
                    sr.Close();
                }
                else
                {
                    sqlCommand.ExecuteNonQuery();
                }
                return sarr;
            }
            catch (Exception ex)
            {
                sbLabel1.Text = ex.Message;
                return null;
            }
        }

        private void mnuRunSql_Click(object sender, EventArgs e)
        {
            ViewSql(RunSql(textBox1.SelectedText));
        }
    }
}
