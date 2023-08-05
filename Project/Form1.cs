using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Form1 : Form
    {
        private bool isDragging = false;  //panel1 move 
        private Point lastLocation;       //panel1 move 

        public Form1()
        {
            InitializeComponent();
        }       

        private void btn會員資料管理_Click(object sender, EventArgs e)
        {
            Member newForm = new Member();
            newForm.Show();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;  //detect mousedown variable           
            lastLocation = e.Location;  //catch sys location
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                //main alogorithm
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X,
                    (this.Location.Y - lastLocation.Y) + e.Y);
                //just update from1
                this.Update();
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;  //將視窗變成迷你視窗
        }

        private void btn商品維護表單_Click(object sender, EventArgs e)
        {
            this.panel使用者表單.Controls.Clear();
            Maintain myMaintain = new Maintain();
            this.panel使用者表單.Controls.Add(myMaintain);
            myMaintain.Show();
        }

        private void btn點餐訂購系統_Click(object sender, EventArgs e)
        {
            this.panel使用者表單.Controls.Clear();
            Order myOrder = new Order();
            this.panel使用者表單.Controls.Add(myOrder);
            myOrder.Show();
        }

        private void btn結帳訂單系統_Click(object sender, EventArgs e)
        {
            this.panel使用者表單.Controls.Clear();
            OrderList orderlist = new OrderList();
            this.panel使用者表單.Controls.Add(orderlist);
            orderlist.Show();
        }

        private void btn登入_Click(object sender, EventArgs e)
        {
            this.panel使用者表單.Controls.Clear();
            LogIn login = new LogIn(this);        //建構子 // 在LogIn內使用Form1的東西

            this.panel使用者表單.Controls.Add(login);
            login.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            按鈕掩蓋();
            //playSimpleSound();
        }

        void 按鈕掩蓋()
        {
            btn商品維護表單.Visible = false;
            btn會員資料管理.Visible = false;
            btn結帳訂單系統.Visible = false;
            btnpicturehide1.Visible = false;
            btnpicturehide2.Visible = false;
            btnpicturehide4.Visible = false;
        }

        private void btn登出_Click(object sender, EventArgs e)
        {
            MessageBox.Show("登出成功");
            this.panel使用者表單.Controls.Clear();
            按鈕掩蓋();
        }

        //private void playSimpleSound()    //音樂播放
        //{
        //    SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\User\Desktop\Project2023完成\CD\a.wav");
        //    simpleSound.Play();
        //}
    }
}
