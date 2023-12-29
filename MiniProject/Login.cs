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
using System.Xml.Linq;

namespace MiniProject
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        SqlConnection sqlConn = new SqlConnection();
        int login_status = 0;
        string loginId;
        public void button1_Click(object sender, EventArgs e)
        {
            /*string DbSource = "C:\\C#\\TestDatabase.mdf";// your DB address
            string DbName = "C:\\C#\\TESTDATABASE.MDF";// your DB database name
            string DbUser = "TestDatabase";// your DB user name
            string DbPassword = "1234";// your DB user password
            string connectionString =$"Data Source={DbSource};"+$"Initial Catalog={DbName};" +
            $"User ID={DbUser};" +$"Password={DbPassword};";*/
            //DialogResult = DialogResult.OK;
            //sqlConn.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=
            //C:\\C#\\TestDatabase.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True";
            //sqlConn.Open();
            string loginId = textBox1.Text;
            string loginPw = textBox2.Text;
            string selectQuery = "select * from Game where idName = \'" + loginId + "\' ";
            SqlCommand sqlCommand = new SqlCommand(selectQuery,sqlConn);
            SqlDataReader userAccount = sqlCommand.ExecuteReader();
            while (userAccount.Read())
            {
                if (loginId == (string)userAccount["idName"] && loginPw == (string)userAccount["Pass"])
                {
                    login_status = 1;
                    MessageBox.Show("로그인 완료");
                    Game game = new Game();
                    userAccount.Close();
                    sqlConn.Close();
                    this.Hide();
                    game.Show();
                    break;
                }
                else
                {
                    MessageBox.Show("아이디나 비밀번호를 확인하라");
                    userAccount.Close();
                    sqlConn.Close();
                    break;
                }
            }
            userAccount.Close();
            sqlConn.Close();
        }//로그인 확인
        public void mnu연결_Click(object sender, EventArgs e)//데이터베이스 연결
        {
            DialogResult r = openFileDialog1.ShowDialog();
            if (r == DialogResult.OK)
            {
                sqlConn.ConnectionString = $"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={openFileDialog1.FileName};Integrated Security=True;Connect Timeout=30";
                sqlConn.Open();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }//회원가입

        private void button2_Click(object sender, EventArgs e)
        {

        }//아이디찾기

        private void button3_Click(object sender, EventArgs e)
        {

        }//비밀번호찾기
    }
}
