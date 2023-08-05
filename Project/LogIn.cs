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

namespace Project
{
    public partial class LogIn : UserControl
    {
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();


        String password = "";

        Form1 myForm1 = null;       //建構子 Form

        public LogIn()              //無建構子時使用
        {
            InitializeComponent();
        }

        public LogIn(Form1 Form)    //LogIn login = new LogIn(this);  從Form1來的
        {
            InitializeComponent();
            //OrderList myorderlist = new OrderList(this);   //假設在LogIn內的東西要在OrderList使用  (OrderList本身也要新增程式碼)
                                                             //OrderList使用LogIn的東西
            myForm1 = Form;      //將Form丟給myForm1
        }

        private void LogIn_Load(object sender, EventArgs e)
        {
            scsb.DataSource = @".";   //伺服器名稱  .為本機伺服器名稱
            scsb.InitialCatalog = "Project";   //資料庫名稱   //不影響讀取同一個資料庫的table
            scsb.IntegratedSecurity = true; //Windows驗證
            GlobalVar.strDBConnectionString = scsb.ConnectionString;  // 用於連結資料庫的字串
        }

        private void btn登入login_Click(object sender, EventArgs e)
        {
            if (txt帳號.Text != "" && txt密碼.Text != "")
            {                
                SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
                con.Open();
                string strSQL = "select 密碼 from Account where 帳號 = @account;";
                SqlCommand cmd = new SqlCommand(strSQL, con);   //執行SQL命令
                cmd.Parameters.AddWithValue("@account", txt帳號.Text);

                //cmd.ExecuteNonQuery();   //執行不查詢
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    password = (String.Format("{0}", reader[0]));
                }
                con.Close();

                if (password == txt密碼.Text)
                {
                    myForm1.btn商品維護表單.Visible = true;
                    myForm1.btn會員資料管理.Visible = true;
                    myForm1.btn結帳訂單系統.Visible = true;
                    myForm1.btnpicturehide1.Visible = true;
                    myForm1.btnpicturehide2.Visible = true;
                    myForm1.btnpicturehide4.Visible = true;
                    MessageBox.Show($"登入成功");
                }
                else 
                {
                    MessageBox.Show($"輸入之帳密有誤");
                }
            }
            else
            {
                MessageBox.Show($"請輸入帳號密碼");

            }
        }
    }
}
