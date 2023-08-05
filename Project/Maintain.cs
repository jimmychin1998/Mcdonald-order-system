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
    public partial class Maintain : UserControl
    {
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();       
        List<string> listProductName = new List<string>();
        List<int> listPrice = new List<int>();
        List<int> listPid = new List<int>();
        public Maintain()
        {
            InitializeComponent();
        }

        private void Maintain_Load(object sender, EventArgs e)
        {
            scsb.DataSource = @".";   //伺服器名稱  .為本機伺服器名稱
            scsb.InitialCatalog = "Project";   //資料庫名稱   //不影響讀取同一個資料庫的table
            scsb.IntegratedSecurity = true; //Windows驗證
            GlobalVar.strDBConnectionString = scsb.ConnectionString;  // 用於連結資料庫的字串

            讀取商品資料庫();
            顯示listView_圖片模式();
        }

        void 讀取商品資料庫()
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
                listProductName.Add((string)reader["pname"]);
                listPrice.Add((int)reader["price"]);
                string image_name = (string)reader["pimage"];
                string 完整圖檔路徑 = $"{GlobalVar.image_dir}\\{image_name}";
                Image img產品圖檔 = Image.FromFile(完整圖檔路徑);
                imageList產品圖檔.Images.Add(img產品圖檔);   //將圖片存放到此
                count++;
            }
            reader.Close();
            con.Close();
            Console.WriteLine($"讀取{count}筆資料");
        }

        void 顯示listView_圖片模式()
        {
            listView商品展示.Items.Clear();
            listView商品展示.View = View.LargeIcon; //SmallIcon , List , Title
            imageList產品圖檔.ImageSize = new Size(190, 150);
            listView商品展示.LargeImageList = imageList產品圖檔;
            //listView商品展示.SmallImageList = imageList產品圖檔;

            for (int i = 0; i < imageList產品圖檔.Images.Count; i++)
            {
                ListViewItem item = new ListViewItem();
                item.ImageIndex = i;   //上方已經存放至LargeImageList的索引值
                item.Text = $"{listProductName[i]} {listPrice[i]}元";
                item.Font = new Font("微軟正黑體", 14, FontStyle.Regular);
                item.Tag = listPid[i];   //重要
                listView商品展示.Items.Add(item);
            }
        }

        private void btn圖片模式_Click(object sender, EventArgs e)
        {
            顯示listView_圖片模式();
        }

        void 顯示listView_列表模式()
        {
            listView商品展示.Clear();
            listView商品展示.LargeImageList = null;
            listView商品展示.SmallImageList = null;
            listView商品展示.View = View.Details;
            listView商品展示.Columns.Add("id", 100);
            listView商品展示.Columns.Add("商品名稱", 200);
            listView商品展示.Columns.Add("商品價格", 100);
            listView商品展示.GridLines = true;
            listView商品展示.FullRowSelect = true;

            for (int i = 0; i < listPid.Count; i++)
            {
                ListViewItem listItem = new ListViewItem();
                listItem.Font = new Font("微軟正黑體", 12, FontStyle.Regular);
                listItem.Text = listPid[i].ToString();        //Text屬性行的第一行
                listItem.SubItems.Add(listProductName[i]);    //SubItems換屬性行
                listItem.SubItems.Add(listPrice[i].ToString());
                listItem.Tag = listPid[i];  //重要
                //listItem.ForeColor = Color.DarkBlue;
                //listItem.BackColor = Color.LightGray;

                listView商品展示.Items.Add(listItem);
            }
        }

        private void btn列表模式_Click(object sender, EventArgs e)
        {
            顯示listView_列表模式();
        }

        void 重新載入資料()    
        {
            listPid.Clear();
            listProductName.Clear();
            listPrice.Clear();
            imageList產品圖檔.Images.Clear();
            讀取商品資料庫();

            if (listView商品展示.View == View.Details) //??
            {
                顯示listView_列表模式();
            }
            else
            {
                顯示listView_圖片模式();
            }
        }

        private void btn重新整理_Click(object sender, EventArgs e)
        {
            重新載入資料();
        }

        private void listView商品展示_ItemActivate(object sender, EventArgs e) //重要
        {
            MaintainDetail myMaintainDetail = new MaintainDetail();
            myMaintainDetail.selectID = (int)listView商品展示.SelectedItems[0].Tag;  //極為重要
            
            Console.WriteLine(myMaintainDetail.selectID);  //確認在商品維護點選商品時之selectID的數值為何

            myMaintainDetail.ShowDialog();
        }

        private void btn新增商品_Click(object sender, EventArgs e)
        {
            MaintainDetail myMaintainDetail = new MaintainDetail();
            myMaintainDetail.ShowDialog();
        }
    }
}
