using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MiniProject
{
    public partial class Game : Form
    {
        SqlConnection sqlConn = new SqlConnection();
        SqlCommand sqlCommand = new SqlCommand();
        static float PenWidth = 1.0f;
        Graphics g = null;
        Pen pen = new Pen(Color.Black, PenWidth);
        Brush brush = null;
        Point p1, p2, p3;
        Point cp1, cp2, cp3;
        int DrawMethod = 0;     //0:free, 1:line, 2:circle 3:rect
        bool DrawMode = false;
        Point clickPoint;
        int good1 = 0;
        int good2 = 0;
        int good3 = 0;
        int good4 = 0;
        string sendText = "";
        public Game()
        {
            InitializeComponent();
            stringRandom();
            namedb();
            g = Canvas.CreateGraphics();
        }
        private void stringRandom()
        {
            Random random = new Random();
            List<string> kword = new List<string>();
            kword.Add("cat");
            kword.Add("dog");
            kword.Add("horse");
            kword.Add("bird");
            kword.Add("lion");
            kword.Add("tiger");
            kword.Add("shark");
            kword.Add("tuttle");
            kword.Add("ant");
            kword.Add("fly");
            kword.Add("panda");
            kword.Add("red panda");
            tbdab.Text = kword[random.Next(11)];
        }//단어 정리
        public void namedb() 
        {
            //Login lo = new Login();
            //string sql = "select Good from Game where idName='HGD'";
            //sqlCommand.CommandText = sql;
            //SqlDataReader sr = sqlCommand.ExecuteReader();
            //tbGood1.Text = sr.GetValue(0).ToString();
            tbId1.Text = "HGD";
            tbGood1.Text = "0";
            tbId2.Text = "JMJ";
            tbGood2.Text = "0";
            tbId3.Text = "SDG";
            tbGood3.Text = "0";
            tbId4.Text = "KJY";
            tbGood4.Text = "0";
        }//방장,고수,중수,하수 아이디,점수
        private void Canvas_MouseUp(object sender, MouseEventArgs e)
        {
            if (DrawMethod == 1)
            {
                g.DrawLine(pen, p1, new Point(e.X, e.Y));
            }
            DrawMode = false;
        }//마우스 뗄떄

        private void Canvas_MouseDown(object sender, MouseEventArgs e)
        {
            p1 = new Point(e.X, e.Y);
            p3 = p1;
            cp1 = ((Control)sender).PointToScreen(p1);
            cp3 = cp1;
            DrawMode = true;
            
            if (e.Button == MouseButtons.Left)
            {
                Point clickPoint = new Point(e.X, e.Y);//마우스 클릭 위치 저장
            }
        }//마우스누를때

        private void Canvas_MouseMove(object sender, MouseEventArgs e)
        {
            float w = Math.Abs(clickPoint.X - e.X);
            float h = Math.Abs(clickPoint.Y - e.Y);
            if (DrawMode)
            {
                p2 = new Point(e.X, e.Y);
                switch (DrawMethod)
                {
                    case 0: //free draw
                        g.DrawLine(pen, p1, p2);
                        p1 = p2;
                        break;
                    case 1: //line draw
                        Point cp2 = ((Control)sender).PointToScreen(p2);
                        ControlPaint.DrawReversibleLine(cp1, cp3, DefaultBackColor);
                        ControlPaint.DrawReversibleLine(cp1, cp2, DefaultBackColor);
                        cp3 = cp2;
                        break;
                    case 2:
                        g.DrawEllipse(pen, p1.X, p1.Y, 100,100);
                        break;
                    case 3:

                        if (e.X > p1.X)
                        {
                            if (e.Y > p1.Y) g.DrawRectangle(pen, p1.X, p1.Y, w, h);
                            else g.DrawRectangle(pen, p1.X, e.Y, w, h);
                        }
                        else
                        {
                            if (e.Y > p1.Y) g.DrawRectangle(pen, e.X, p1.Y, w, h);
                            else g.DrawRectangle(pen, e.X, e.Y, w, h);
                        }


                        break;
                    default: break;
                }
            }
        }//마우스움직일때 포인트
        private void btnPen_Click(object sender, EventArgs e)
        {
            DrawMethod = 0;
        }//마우스에 따라 움직이는펜

        private void btnLine_Click(object sender, EventArgs e)
        {
            DrawMethod = 1;
        }//선형
        private void btnCircle_Click(object sender, EventArgs e)
        {
            DrawMethod = 2;
        }//원형
        private void btnRec_Click(object sender, EventArgs e)
        {
            DrawMethod = 3;
        }//사각형
        private void btnEraser_Click(object sender, EventArgs e)
        {
            g.Clear(DefaultBackColor);
        }//지우개

        private void btnColor_Click(object sender, EventArgs e)
        {
            pen.Color = Color.Black;
        }//검정색 펜
        private void btnRed_Click(object sender, EventArgs e)
        {
            pen.Color = Color.Red;
        }//빨강색 펜
        private void btnYellow_Click(object sender, EventArgs e)
        {
            pen.Color = Color.Yellow;
        }//노랑색 펜
        private void btnGreen_Click(object sender, EventArgs e)
        {
            pen.Color = Color.Green;
        }//초록색 펜
        private void btnBlue_Click(object sender, EventArgs e)
        {
            pen.Color = Color.Blue;
        }//파란색 펜
        private void btnGrey_Click(object sender, EventArgs e)
        {
            pen.Color = Color.Gray;
        }//회색 펜
        private void btnWhite_Click(object sender, EventArgs e)
        {
            pen.Color = Color.White;
        }//하얀색 펜
        private void CanVas_Resize(object sender, EventArgs e)
        {

        }
        private void 연결ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult r = openFileDialog1.ShowDialog();
            if (r == DialogResult.OK)
            {
                sqlConn.ConnectionString = $"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={openFileDialog1.FileName};Integrated Security=True;Connect Timeout=30";
                sqlConn.Open();
                sqlCommand.Connection = sqlConn;
            }
        }//데이터베이스 연결

        private void Game_FormClosing(object sender, FormClosingEventArgs e)
        {
            sqlConn.Close();
            Application.Exit();
        }//게임폼을 닫을때

        private void stm설정ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            serialPort1.PortName = "COM12";
            serialPort1.BaudRate = 115200;
            serialPort1.Parity = Parity.None;
            serialPort1.DataBits = 8;
            serialPort1.StopBits = StopBits.One;
        }//stm설정
        private void stm실행ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen)
            {
                serialPort1.Close();
            }
            serialPort1.Open();
        }//stm실행
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string str = serialPort1.ReadExisting();
        }//stm데이터받기
        private bool serialSend(string strText)
        {
            bool bResult = false;
            byte[] stx = new byte[] { 0x02 };
            byte[] etx = new byte[] { 0x03 };

            byte[] bytes = System.Text.Encoding.ASCII.GetBytes(strText);
            if (serialPort1.IsOpen)
            {
                serialPort1.Write(stx, 0, 1);
                serialPort1.Write(bytes, 0, bytes.Length);
                serialPort1.Write(etx, 0, 1);
                bResult = true;
            }
            else
            {
                return false;
            }
            return bResult;
        }//stm데이터보내기
        private void Send()
        {
            serialSend(sendText);
        }//보내기
        private void btn1_Click(object sender, EventArgs e)
        {
            if (tb1dab.Text == tbdab.Text)//정답일때
            {
                ++good1;
                tbGood1.Text = good1.ToString();
                stringRandom();
                g.Clear(DefaultBackColor);
                MessageBox.Show("정답~!");
                tb1dab.Text = "";
                Send();
                //serialPort1.Write("0");
                serialPort1.WriteLine("HAL_GPIO_TogglePin(LEDg_GPIO_Port, LEDg_Pin)");
            }
            else//틀렸을때
            {
                MessageBox.Show("떙~!");
                tb1dab.Text = "";
                Send();
                //serialPort1.Write("1");
                serialPort1.WriteLine("HAL_GPIO_TogglePin(LEDg_GPIO_Port, LEDg_Pin)");
            }
            if (good1 > 5)//5개 맞추면 우승자 결정
            {
                MessageBox.Show("HGD\n우승~~!!");
                Send();
                //serialPort1.Write("2");
                serialPort1.WriteLine("HAL_GPIO_TogglePin(LEDg_GPIO_Port, LEDg_Pin)");
            }
        }//방장정답버튼
        private void btn2_Click(object sender, EventArgs e)
        {
            if (tb2dab.Text == tbdab.Text)
            {
                ++good2;
                tbGood2.Text = good2.ToString();
                stringRandom();
                g.Clear(DefaultBackColor);
                tb2dab.Text = "";
            }
            else
            {
                MessageBox.Show("떙~!");
                tb2dab.Text = "";
            }
            if (good2 > 5)
            {
                MessageBox.Show("JMJ\n우승~~!!");
            }
        }//고수정답버튼
        private void btn3_Click(object sender, EventArgs e)
        {
             if (tb3dab.Text == tbdab.Text)
            {
                ++good3;
                tbGood3.Text = good3.ToString();
                stringRandom();
                g.Clear(DefaultBackColor);
                tb3dab.Text = "";
            }
            else
            {
                MessageBox.Show("떙~!");
                tb3dab.Text = "";
            }
            if (good3 > 5)
            {
                MessageBox.Show("SDG\n우승~~!!");
            }
        }//중수정답버튼
        private void btn4_Click(object sender, EventArgs e)
        {
            if (tb4dab.Text == tbdab.Text)
            {
                ++good4;
                tbGood4.Text = good4.ToString();
                stringRandom();
                g.Clear(DefaultBackColor);
                tb4dab.Text = "";
            }
            else
            {
                MessageBox.Show("떙~!");
                tb4dab.Text = "";
            }
            if (good4 > 5)
            {
                MessageBox.Show("KJY\n우승~~!!");
            }
        }//하수정답버튼
    }
}
