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
    public partial class Member : Form
    {
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
        string strDBConnectionString = "";
        List<int> searchIDs = new List<int>(); //進階搜尋結果 (存ID資料 為整數)
        int int搜尋婚姻狀態 = 0; //0:全部 , 1:已婚 , 2:單身

        public Member()
        {
            InitializeComponent();
        }

        private void Member_Load(object sender, EventArgs e)
        {
            scsb.DataSource = @".";         //伺服器名稱  .為本機伺服器名稱
            scsb.InitialCatalog = "Project";   //資料庫名稱
            scsb.IntegratedSecurity = true; //Windows驗證

            strDBConnectionString = scsb.ConnectionString;  // 用於連結資料庫的字串
            //string connectionString = SqlConnectionStringBuilder.ConnectionString;

            combo資料欄位搜尋.Items.Add("姓名");
            combo資料欄位搜尋.Items.Add("電話");
            combo資料欄位搜尋.Items.Add("地址");
            combo資料欄位搜尋.Items.Add("email");
            combo資料欄位搜尋.SelectedIndex = 0;

            radio不論婚姻.Checked = true;
            int搜尋婚姻狀態 = 0;
            產生會員資料列表DGV();
        }

        void 產生會員資料列表DGV()
        {
            SqlConnection con = new SqlConnection(strDBConnectionString);
            con.Open();
            string strSQL = "select * from Members;";
            //string strSQL = "select id as 身分, 姓名 as name  , 電話 as tel from persons"; //可任意選擇要那些欄位
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows == true)    //有無資料
            {
                DataTable dt = new DataTable();  //類似hashtable
                dt.Load(reader);
                dgv會員資料列表.DataSource = dt;
            }
        }


        private void btn搜尋_Click(object sender, EventArgs e)
        {
            if (txt欄位搜尋關鍵字.Text != "")
            {
                listBox搜尋結果.Items.Clear();
                searchIDs.Clear();     //List<int> searchIDs清空
                string str欄位名稱 = combo資料欄位搜尋.SelectedItem.ToString();
                string sql婚姻狀態查詢語法 = "";
                if (int搜尋婚姻狀態 == 0)  //全部
                {
                    sql婚姻狀態查詢語法 = "";
                }
                else if (int搜尋婚姻狀態 == 1)  //已婚
                {
                    sql婚姻狀態查詢語法 = "and 婚姻狀態 = 1";
                }
                else if (int搜尋婚姻狀態 == 2)  //單身
                {
                    sql婚姻狀態查詢語法 = "and 婚姻狀態 = 0";
                }
                SqlConnection con = new SqlConnection(strDBConnectionString);
                con.Open();
                string strSQL = "select * from Members where 生日>= @BirthdayStart" +
                    $" and 生日<= @BirthdayEnd {sql婚姻狀態查詢語法} and {str欄位名稱} like @SearchKeyword;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@BirthdayStart", dtp起始日期.Value);
                cmd.Parameters.AddWithValue("@BirthdayEnd", dtp結束日期.Value);
                cmd.Parameters.AddWithValue("@SearchKeyword", $"%{txt欄位搜尋關鍵字.Text}%");
                SqlDataReader reader = cmd.ExecuteReader();

                int count = 0;
                while (reader.Read() == true)
                {
                    searchIDs.Add((int)reader["id"]);    //List<int> searchIDs
                    listBox搜尋結果.Items.Add($"{reader["id"]} {reader["姓名"]} {reader["電話"]}");
                    count++;
                }
                if (count == 0)
                {
                    MessageBox.Show("查無此人");
                }
                reader.Close();
                con.Close();
            }
        }

        private void radio單身_CheckedChanged(object sender, EventArgs e)
        {
            int搜尋婚姻狀態 = 2;
        }

        private void radio已婚_CheckedChanged(object sender, EventArgs e)
        {
            int搜尋婚姻狀態 = 1;
        }

        private void radio不論婚姻_CheckedChanged(object sender, EventArgs e)
        {
            int搜尋婚姻狀態 = 0;
        }

        private void listBox搜尋結果_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox搜尋結果.SelectedIndex >= 0)
            {                  //索引值互相對應
                int selectID = searchIDs[listBox搜尋結果.SelectedIndex];

                SqlConnection con = new SqlConnection(strDBConnectionString);
                con.Open();                                          //參數帶入法 paramaters method
                string strSQL = "select * from Members where id = @SearchID;"; //SQL語法一定要正確
                SqlCommand cmd = new SqlCommand(strSQL, con);   //執行SQL命令
                cmd.Parameters.AddWithValue("@SearchID", selectID);
                SqlDataReader reader = cmd.ExecuteReader();
                //reader本身沒有資料，是讀取資料，所以不能用foreach要用while
                //此次只有一筆資料不用while迴圈

                if (reader.Read() == true)
                {
                    lblid.Text = reader["id"].ToString();
                    txt姓名.Text = reader["姓名"].ToString();
                    txt電話.Text = reader["電話"].ToString();
                    txt地址.Text = reader["地址"].ToString();
                    txtemail.Text = reader["email"].ToString();
                    txt會員點數.Text = reader["會員點數"].ToString();
                    dateTimePicker.Value = Convert.ToDateTime(reader["生日"]);
                    chk婚姻狀態.Checked = Convert.ToBoolean(reader["婚姻狀態"]);
                }
                else
                {
                    MessageBox.Show("查無此人");
                    清空欄位();
                }
                reader.Close();
                con.Close();
            }
        }

        void 清空欄位()
        {
            lblid.Text = "";
            txt姓名.Clear();
            txt電話.Clear();
            txtemail.Clear();
            txt地址.Clear();
            txt會員點數.Clear();
            dateTimePicker.Value = DateTime.Now;
            chk婚姻狀態.Checked = false;
        }

        private void btn清空欄位_Click(object sender, EventArgs e)
        {
            清空欄位();
        }

        private void btn新增資料_Click(object sender, EventArgs e)
        {
            if ((txt姓名.Text != "") && (txt電話.Text != "") && (txt地址.Text != "") && (txtemail.Text != "") && (txt會員點數.Text != ""))
            {
                SqlConnection con = new SqlConnection(strDBConnectionString);
                con.Open();                                          //參數帶入法 paramaters method
                string strSQL = "insert into Members values(@NewName,@NewPhone,@NewAddress,@NewEmail,@NewBirthday,@NewMarriage,@NewPoints);";
                SqlCommand cmd = new SqlCommand(strSQL, con);   //執行SQL命令
                cmd.Parameters.AddWithValue("@NewName", txt姓名.Text);
                cmd.Parameters.AddWithValue("@NewPhone", txt電話.Text);
                cmd.Parameters.AddWithValue("@NewAddress", txt地址.Text);
                cmd.Parameters.AddWithValue("@NewEmail", txtemail.Text);
                cmd.Parameters.AddWithValue("@NewBirthday", dateTimePicker.Value);
                cmd.Parameters.AddWithValue("@NewMarriage", chk婚姻狀態.Checked);
                int intpoints = 0;
                Int32.TryParse(txt會員點數.Text, out intpoints);
                cmd.Parameters.AddWithValue("@NewPoints", intpoints);

                int rows = cmd.ExecuteNonQuery();   //執行不查詢
                con.Close();
                MessageBox.Show($"會員資料新增成功,{rows}筆資料受影響");
            }
            else
            {
                MessageBox.Show("請確認資料是否填寫完善!");
            }
            產生會員資料列表DGV();
        }

        private void btn資料修改_Click(object sender, EventArgs e)
        {
            int intID = 0;
            Int32.TryParse(lblid.Text, out intID);
            if ((intID > 0) && (txt姓名.Text != "") && (txt電話.Text != "") && (txt地址.Text != "") && (txtemail.Text != "") && (txt會員點數.Text != ""))
            {
                SqlConnection con = new SqlConnection(strDBConnectionString);
                con.Open();                                          //參數帶入法 paramaters method
                string strSQL = "update Members set 姓名=@NewName,電話=@NewPhone,地址=@NewAddress,email=@NewEmail," +
                    "生日=@NewBirthday,婚姻狀態=@NewMarriage,會員點數=@NewPoints where id = @SearchID;";
                SqlCommand cmd = new SqlCommand(strSQL, con);   //執行SQL命令
                cmd.Parameters.AddWithValue("@SearchID", intID);
                cmd.Parameters.AddWithValue("@NewName", txt姓名.Text);
                cmd.Parameters.AddWithValue("@NewPhone", txt電話.Text);
                cmd.Parameters.AddWithValue("@NewAddress", txt地址.Text);
                cmd.Parameters.AddWithValue("@NewEmail", txtemail.Text);
                cmd.Parameters.AddWithValue("@NewBirthday", dateTimePicker.Value);
                cmd.Parameters.AddWithValue("@NewMarriage", chk婚姻狀態.Checked);
                int intpoints = 0;
                Int32.TryParse(txt會員點數.Text, out intpoints);
                cmd.Parameters.AddWithValue("@NewPoints", intpoints);

                int rows = cmd.ExecuteNonQuery();   //執行不查詢
                con.Close();
                MessageBox.Show($"會員資料修改成功,{rows}筆資料受影響");
            }
            產生會員資料列表DGV();
        }

        private void btn刪除資料_Click(object sender, EventArgs e)
        {
            int intID = 0;
            Int32.TryParse(lblid.Text, out intID);

            if (intID > 0)
            {
                SqlConnection con = new SqlConnection(strDBConnectionString);
                con.Open();                                     //參數帶入法 paramaters method
                string strSQL = "delete from Members where id = @DeleteID;";
                SqlCommand cmd = new SqlCommand(strSQL, con);   //執行SQL命令
                cmd.Parameters.AddWithValue("@DeleteID", intID);
                //防範SQL injection

                int rows = cmd.ExecuteNonQuery();   //執行不查詢
                con.Close();
                清空欄位();
                MessageBox.Show($"會員資料刪除成功,{rows}筆資料受影響");
            }
            產生會員資料列表DGV();
        }

        private void dgv會員資料列表_CellClick(object sender, DataGridViewCellEventArgs e)
        {   //在方法欄位新增的方法
            if (e.RowIndex >= 0)
            {                                                      //第一個儲存格(id)
                string strSeletID = dgv會員資料列表.Rows[e.RowIndex].Cells[0].Value.ToString();
                int selectID = 0;
                Int32.TryParse(strSeletID, out selectID);

                SqlConnection con = new SqlConnection(strDBConnectionString);
                con.Open();                                          //參數帶入法 paramaters method
                string strSQL = "select * from Members where id = @SearchID;"; //SQL語法一定要正確
                SqlCommand cmd = new SqlCommand(strSQL, con);   //執行SQL命令
                cmd.Parameters.AddWithValue("@SearchID", selectID);
                SqlDataReader reader = cmd.ExecuteReader();
                //reader本身沒有資料，是讀取資料，所以不能用foreach要用while
                //此次只有一筆資料不用while迴圈

                if (reader.Read() == true)
                {
                    lblid.Text = reader["id"].ToString();
                    txt姓名.Text = reader["姓名"].ToString();
                    txt電話.Text = reader["電話"].ToString();
                    txt地址.Text = reader["地址"].ToString();
                    txtemail.Text = reader["email"].ToString();
                    txt會員點數.Text = reader["會員點數"].ToString();
                    dateTimePicker.Value = Convert.ToDateTime(reader["生日"]);
                    chk婚姻狀態.Checked = Convert.ToBoolean(reader["婚姻狀態"]);
                }
                else
                {
                    MessageBox.Show("查無此人");
                    清空欄位();
                }
                reader.Close();
                con.Close();
            }
        }
    }
}
