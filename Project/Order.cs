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
    public partial class Order : UserControl
    {
        public int select_OrderID = 0;
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
        List<string> listProductName = new List<string>();
        List<int> listPrice = new List<int>();
        List<int> listPid = new List<int>();

        int 總價 = 0;
        int selectID = 0; //確認dgv所選的訂單編號

        public Order()
        {
            InitializeComponent();
        }

        private void Order_Load(object sender, EventArgs e)
        {
            scsb.DataSource = @".";   //伺服器名稱  .為本機伺服器名稱
            scsb.InitialCatalog = "Project";   //資料庫名稱   //不影響讀取同一個資料庫的table
            scsb.IntegratedSecurity = true; //Windows驗證
            GlobalVar.strDBConnectionString = scsb.ConnectionString;  // 用於連結資料庫的字串

            讀取主餐資料庫();
            顯示listView_圖片模式();
            產生購物車列表DGV();
        }
        void 讀取主餐資料庫()
        {
            SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
            con.Open();
            string strSQL = "select top 200 * from products;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();

            int count = 0;

            while (reader.Read())
            {   //將SQL資料依屬性給予相對之值進個別的list
                listPid.Add((int)reader["id"]);
                //Console.WriteLine($"{listPid[count]}"); index0~9 => productsID 1~10
                listProductName.Add((string)reader["pname"]);
                listPrice.Add((int)reader["price"]);
                string image_name = (string)reader["pimage"];
                string 完整圖檔路徑 = $"{GlobalVar.image_dir}\\{image_name}";
                Image img主餐圖檔 = Image.FromFile(完整圖檔路徑);
                imageList主餐圖檔.Images.Add(img主餐圖檔);   //將圖片存放到此
                count++;
            }
            reader.Close();
            con.Close();
            Console.WriteLine($"讀取{count}筆資料");
        }

        void 顯示listView_圖片模式()
        {
            listView主餐展示.Items.Clear();
            listView主餐展示.View = View.LargeIcon; //SmallIcon , List , Title
            imageList主餐圖檔.ImageSize = new Size(170, 150);
            listView主餐展示.LargeImageList = imageList主餐圖檔;
            //listView商品展示.SmallImageList = imageList產品圖檔;

            for (int i = 0; i < imageList主餐圖檔.Images.Count; i++)
            {
                ListViewItem item = new ListViewItem();
                item.ImageIndex = i;   //上方已經存放至LargeImageList的索引值
                item.Text = $"{listProductName[i]} {listPrice[i]}元";
                item.Font = new Font("微軟正黑體", 14, FontStyle.Regular);
                item.Tag = listPid[i];   //重要
                listView主餐展示.Items.Add(item);
            }
        }

        private void listView主餐展示_ItemActivate(object sender, EventArgs e)
        {
            select_OrderID = (int)listView主餐展示.SelectedItems[0].Tag;
            Console.WriteLine(select_OrderID);  //確認在Order點選商品時之selectID的數值為何            
            int listindex = select_OrderID - 1;
            lbl主餐名稱.Text = listProductName[listindex];
            lbl主餐價格數字.Text = Convert.ToString(listPrice[listindex]);
            計算總價();
        }

        void 產生購物車列表DGV()
        {
            SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
            con.Open();
            string strSQL = "select * from Cart;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();

            //if (reader.HasRows == true)    //有無資料
            //{
                DataTable dt = new DataTable();  //類似hashtable
                dt.Load(reader);
                dataGridView.DataSource = dt;
           // }
        }

        void 計算總價()
        {
            int num = 0;
            bool change = int.TryParse(txt主餐份數.Text, out num);

            if (txt主餐份數.Text == "" || change == false)
            {
                總價 = (Convert.ToInt32(lbl主餐價格數字.Text) * 0);
                lbl總價數字.Text = Convert.ToString(總價);
            }
            else if (txt主餐份數.Text != "")
            {
                總價 = (Convert.ToInt32(lbl主餐價格數字.Text)) * (Convert.ToInt32(txt主餐份數.Text));
                lbl總價數字.Text = Convert.ToString(總價);
            }
        }

        private void txt主餐份數_TextChanged(object sender, EventArgs e)
        {
            計算總價();
        }

        private void btn加入購物車_Click(object sender, EventArgs e)
        {
            int NewAmount = 0;
            int NewTotal = 0;
            bool change = int.TryParse(txt主餐份數.Text, out NewAmount);
            bool change2 = int.TryParse(lbl總價數字.Text, out NewTotal);
            if ((txt訂購人.Text != "") && change2 == true && change == true && NewAmount != 0 && NewTotal != 0)
            {
                SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
                con.Open();
                string strSQL = "insert into Cart values(@NewName,@NewProduct,@NewAmount,@NewTotal);";
                SqlCommand cmd = new SqlCommand(strSQL, con);   //執行SQL命令
                cmd.Parameters.AddWithValue("@NewName", txt訂購人.Text);
                cmd.Parameters.AddWithValue("@NewProduct", lbl主餐名稱.Text);
                cmd.Parameters.AddWithValue("@NewAmount", NewAmount);
                cmd.Parameters.AddWithValue("@NewTotal", NewTotal);

                cmd.ExecuteNonQuery(); //執行不查詢
                con.Close();
                MessageBox.Show($"加入購物車成功!!");
            }
            else
            {
                MessageBox.Show("請確認購物資訊是否填寫正確!");
            }
            產生購物車列表DGV();
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {                                                      //第一個儲存格(id)
                string strSeletID = dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();

                Int32.TryParse(strSeletID, out selectID);
                lbl訂單編號數字.Text = Convert.ToString(selectID);
            }
        }

        private void btn刪除自選_Click(object sender, EventArgs e)
        {
            if (selectID > 0)
            {
                SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
                con.Open();
                string strSQL = "delete from Cart where 訂單編號 = @DeleteID;";
                SqlCommand cmd = new SqlCommand(strSQL, con);   //執行SQL命令
                cmd.Parameters.AddWithValue("@DeleteID", selectID);

                cmd.ExecuteNonQuery();   //執行不查詢
                con.Close();
                //dataGridView.ClearSelection();
                MessageBox.Show($"自選購物車資料已刪除!!");
                產生購物車列表DGV();
            }
            else
            {
                MessageBox.Show($"請點選欲刪除之資料行");
            }
        }

        private void btn清空購物車_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
            con.Open();
            string strSQL = "delete from Cart;";
            SqlCommand cmd = new SqlCommand(strSQL, con);   //執行SQL命令

            cmd.ExecuteNonQuery();   //執行不查詢
            con.Close();
            //dataGridView.ClearSelection();
            MessageBox.Show($"購物車已清空!!");
            產生購物車列表DGV();
        }

        private void btn結帳_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
            con.Open();
            string strSQL = "insert into Order_o (Cart.訂單編號,Cart.購物人,Cart.商品,Cart.數量,Cart.總價 , Members.電話,Members.地址,Members.email)\r\nselect Cart.* , Members.電話,Members.地址,Members.email from Cart\r\nleft join Members on Cart.購物人 = Members.姓名";
            SqlCommand cmd = new SqlCommand(strSQL, con);   //執行SQL命令

            cmd.ExecuteNonQuery();   //執行不查詢
            con.Close();

            MessageBox.Show($"結帳成功!!");
            產生購物車列表DGV();
        }
    }
}
