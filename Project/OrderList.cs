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

    public partial class OrderList : UserControl
    {
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
       
        // LogIn mylogin = null;

        int selectID = 0;

        public OrderList()
        {
            InitializeComponent();
        }

        //public OrderList(LogIn login)
        //{
        //    InitializeComponent();
        //    mylogin = login;       
        //}

        private void OrderList_Load(object sender, EventArgs e)
        {
            scsb.DataSource = @".";   //伺服器名稱  .為本機伺服器名稱
            scsb.InitialCatalog = "Project";   //資料庫名稱   //不影響讀取同一個資料庫的table
            scsb.IntegratedSecurity = true; //Windows驗證
            GlobalVar.strDBConnectionString = scsb.ConnectionString;  // 用於連結資料庫的字串

            產生結帳訂單列表DGV();
        }

        void 產生結帳訂單列表DGV()
        {
            SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
            con.Open();
            string strSQL = "select * from Order_o;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();

            //if (reader.HasRows == true)    //有無資料
            //{
            DataTable dt = new DataTable();  //類似hashtable
            dt.Load(reader);
            dataGridView1.DataSource = dt;
            // }
        }

        private void btn刪除自選_Click(object sender, EventArgs e)
        {
            if (selectID > 0)
            {
                SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
                con.Open();
                string strSQL = "delete from Order_o where 訂單編號 = @DeleteID;";
                SqlCommand cmd = new SqlCommand(strSQL, con);   //執行SQL命令
                cmd.Parameters.AddWithValue("@DeleteID", selectID);

                cmd.ExecuteNonQuery();   //執行不查詢
                con.Close();
                //dataGridView.ClearSelection();
                MessageBox.Show($"自選訂單資料已刪除!!");
                產生結帳訂單列表DGV();
            }
            else
            {
                MessageBox.Show($"請點選欲刪除之訂單列");
            }
        }

        private void btn清空結帳列表_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
            con.Open();
            string strSQL = "delete from Order_o;";
            SqlCommand cmd = new SqlCommand(strSQL, con);   //執行SQL命令

            cmd.ExecuteNonQuery();   //執行不查詢
            con.Close();
            //dataGridView.ClearSelection();
            MessageBox.Show($"訂單已清空!!");
            產生結帳訂單列表DGV();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {                                                      //第一個儲存格(id)
                string strSeletID = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();

                Int32.TryParse(strSeletID, out selectID);
                lbl訂單編號數字.Text = Convert.ToString(selectID);
            }
        }
    }
}
