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
    public partial class MaintainDetail : Form
    {
        public int selectID = 0;
        string image_modify_name = "";
        bool is修改圖檔 = false;

        public MaintainDetail()
        {
            InitializeComponent();
        }

        private void MaintainDetail_Load(object sender, EventArgs e)
        {
            if (selectID == 0)
            {   //新增模式
                groupBox商品修改.Visible = false;
                groupBox商品新增.Visible = true;
            }
            else
            {   //修改模式
                groupBox商品修改.Visible = true;
                groupBox商品新增.Visible = false;
            }

            lblid.Text = selectID.ToString();
            顯示商品詳細資訊();
        }

        void 顯示商品詳細資訊()
        {
            if (selectID > 0)
            {
                SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
                con.Open();
                string strSQL = "select * from products where id = @SearchID;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@searchID", selectID);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read() == true)
                {
                    lblid.Text = reader["id"].ToString();
                    txt商品名稱.Text = reader["pname"].ToString();
                    txt商品價格.Text = reader["price"].ToString();
                    txt商品描述.Text = reader["pinform"].ToString();
                    image_modify_name = reader["pimage"].ToString();
                    string 圖檔完整路徑 = GlobalVar.image_dir + @"\" + image_modify_name;
                    pictureBox商品圖檔.Image = Image.FromFile(圖檔完整路徑);
                }
                reader.Close();
                con.Close();
            }          
        }

        void 選取商品圖片()
        {
            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "檔案類型 (*.jpg, *.jpeg, *.png)|*.jpeg;*.jpg;*.png";

            DialogResult R = f.ShowDialog();

            if (R == DialogResult.OK)
            {
                pictureBox商品圖檔.Image = Image.FromFile(f.FileName);//f.FileName完整檔案路徑
                string 檔案副檔名 = System.IO.Path.GetExtension(f.SafeFileName); //f.SafeFileName檔名
                Random myRnd = new Random();
                image_modify_name = DateTime.Now.ToString("yyMMddHHmmss") + myRnd.Next(1000, 10000).ToString() + 檔案副檔名;
                is修改圖檔 = true;
                Console.WriteLine(image_modify_name);
            }
        }

        private void btn選取商品圖片1_Click(object sender, EventArgs e)
        {
            選取商品圖片();
        }

        private void btn儲存修改_Click(object sender, EventArgs e)
        {
            //修改商品
            if ((txt商品名稱.Text != "") && (txt商品價格.Text != "") && (txt商品描述.Text != "") && (pictureBox商品圖檔.Image != null))
            {
                if (is修改圖檔 == true)
                {
                    pictureBox商品圖檔.Image.Save(GlobalVar.image_dir + @"\" + image_modify_name);
                    is修改圖檔 = false;
                }

                SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
                con.Open();
                string strSQL = "update products set pname=@NewName, price=@NewPrice, pinform=@Newinform, pimage=@NewImage where id=@SearchId;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchId", selectID);
                cmd.Parameters.AddWithValue("@NewName", txt商品名稱.Text);
                int intPrice = 0;
                Int32.TryParse(txt商品價格.Text, out intPrice);
                cmd.Parameters.AddWithValue("@NewPrice", intPrice);
                cmd.Parameters.AddWithValue("@Newinform", txt商品描述.Text);
                cmd.Parameters.AddWithValue("@NewImage", image_modify_name);
                int rows = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show($"資料異動成功, 影響{rows}筆資料!");
            }
            else
            {
                MessageBox.Show("所有欄位必填!");
            }
        }

        private void btn清空欄位_Click(object sender, EventArgs e)
        {
            lblid.Text = "";
            txt商品名稱.Clear();
            txt商品價格.Clear();
            txt商品描述.Clear();
            pictureBox商品圖檔.Image = null;
        }

        private void btn選取商品圖片2_Click(object sender, EventArgs e)
        {
            選取商品圖片();
        }

        private void btn儲存商品_Click(object sender, EventArgs e)
        {
            //新增商品
            if ((txt商品名稱.Text != "") && (txt商品價格.Text != "") && (txt商品描述.Text != "") && (pictureBox商品圖檔.Image != null))
            {
                if (is修改圖檔 == true)
                {
                    pictureBox商品圖檔.Image.Save(GlobalVar.image_dir + @"\" + image_modify_name);
                    is修改圖檔 = false;
                }

                SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
                con.Open();
                string strSQL = "insert into products values(@NewName,@NewPrice,@Newinform,@NewImage);";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@NewName", txt商品名稱.Text);
                int intPrice = 0;
                Int32.TryParse(txt商品價格.Text, out intPrice);
                cmd.Parameters.AddWithValue("@NewPrice", intPrice);
                cmd.Parameters.AddWithValue("@Newinform", txt商品描述.Text);
                cmd.Parameters.AddWithValue("@NewImage", image_modify_name);
                int rows = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show($"資料異動成功, 影響{rows}筆資料!");
            }
            else
            {
                MessageBox.Show("所有欄位必填!");
            }
        }
    }
}
