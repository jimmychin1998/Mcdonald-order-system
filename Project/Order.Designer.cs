namespace Project
{
    partial class Order
    {
        /// <summary> 
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 元件設計工具產生的程式碼

        /// <summary> 
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.listView主餐展示 = new System.Windows.Forms.ListView();
            this.imageList主餐圖檔 = new System.Windows.Forms.ImageList(this.components);
            this.lbl主餐名稱 = new System.Windows.Forms.Label();
            this.lbl主餐價格標題 = new System.Windows.Forms.Label();
            this.lbl主餐份數 = new System.Windows.Forms.Label();
            this.txt主餐份數 = new System.Windows.Forms.TextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.txt訂購人 = new System.Windows.Forms.TextBox();
            this.lbl訂購人 = new System.Windows.Forms.Label();
            this.lbl總價標題 = new System.Windows.Forms.Label();
            this.lbl總價數字 = new System.Windows.Forms.Label();
            this.lbl主餐價格數字 = new System.Windows.Forms.Label();
            this.btn加入購物車 = new System.Windows.Forms.Button();
            this.btn刪除自選 = new System.Windows.Forms.Button();
            this.lbl訂單編號 = new System.Windows.Forms.Label();
            this.lbl訂單編號數字 = new System.Windows.Forms.Label();
            this.btn清空購物車 = new System.Windows.Forms.Button();
            this.btn結帳 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // listView主餐展示
            // 
            this.listView主餐展示.BackColor = System.Drawing.Color.Cornsilk;
            this.listView主餐展示.HideSelection = false;
            this.listView主餐展示.Location = new System.Drawing.Point(3, 3);
            this.listView主餐展示.Name = "listView主餐展示";
            this.listView主餐展示.Size = new System.Drawing.Size(456, 385);
            this.listView主餐展示.TabIndex = 17;
            this.listView主餐展示.UseCompatibleStateImageBehavior = false;
            this.listView主餐展示.ItemActivate += new System.EventHandler(this.listView主餐展示_ItemActivate);
            // 
            // imageList主餐圖檔
            // 
            this.imageList主餐圖檔.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList主餐圖檔.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList主餐圖檔.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // lbl主餐名稱
            // 
            this.lbl主餐名稱.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl主餐名稱.Location = new System.Drawing.Point(460, 53);
            this.lbl主餐名稱.Name = "lbl主餐名稱";
            this.lbl主餐名稱.Size = new System.Drawing.Size(225, 30);
            this.lbl主餐名稱.TabIndex = 16;
            this.lbl主餐名稱.Text = "主餐名稱";
            // 
            // lbl主餐價格標題
            // 
            this.lbl主餐價格標題.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl主餐價格標題.Location = new System.Drawing.Point(460, 93);
            this.lbl主餐價格標題.Name = "lbl主餐價格標題";
            this.lbl主餐價格標題.Size = new System.Drawing.Size(125, 27);
            this.lbl主餐價格標題.TabIndex = 17;
            this.lbl主餐價格標題.Text = "主餐價格";
            // 
            // lbl主餐份數
            // 
            this.lbl主餐份數.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl主餐份數.Location = new System.Drawing.Point(460, 134);
            this.lbl主餐份數.Name = "lbl主餐份數";
            this.lbl主餐份數.Size = new System.Drawing.Size(125, 27);
            this.lbl主餐份數.TabIndex = 18;
            this.lbl主餐份數.Text = "主餐份數";
            // 
            // txt主餐份數
            // 
            this.txt主餐份數.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt主餐份數.Location = new System.Drawing.Point(573, 131);
            this.txt主餐份數.Multiline = true;
            this.txt主餐份數.Name = "txt主餐份數";
            this.txt主餐份數.Size = new System.Drawing.Size(107, 34);
            this.txt主餐份數.TabIndex = 19;
            this.txt主餐份數.Text = "0";
            this.txt主餐份數.TextChanged += new System.EventHandler(this.txt主餐份數_TextChanged);
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.Color.Cornsilk;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(3, 394);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(456, 235);
            this.dataGridView.TabIndex = 20;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            // 
            // txt訂購人
            // 
            this.txt訂購人.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt訂購人.Location = new System.Drawing.Point(573, 12);
            this.txt訂購人.Multiline = true;
            this.txt訂購人.Name = "txt訂購人";
            this.txt訂購人.Size = new System.Drawing.Size(107, 34);
            this.txt訂購人.TabIndex = 22;
            // 
            // lbl訂購人
            // 
            this.lbl訂購人.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl訂購人.Location = new System.Drawing.Point(460, 15);
            this.lbl訂購人.Name = "lbl訂購人";
            this.lbl訂購人.Size = new System.Drawing.Size(107, 27);
            this.lbl訂購人.TabIndex = 21;
            this.lbl訂購人.Text = "訂購人";
            // 
            // lbl總價標題
            // 
            this.lbl總價標題.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl總價標題.Location = new System.Drawing.Point(460, 176);
            this.lbl總價標題.Name = "lbl總價標題";
            this.lbl總價標題.Size = new System.Drawing.Size(93, 27);
            this.lbl總價標題.TabIndex = 23;
            this.lbl總價標題.Text = "總價";
            // 
            // lbl總價數字
            // 
            this.lbl總價數字.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl總價數字.Location = new System.Drawing.Point(574, 176);
            this.lbl總價數字.Name = "lbl總價數字";
            this.lbl總價數字.Size = new System.Drawing.Size(120, 27);
            this.lbl總價數字.TabIndex = 24;
            this.lbl總價數字.Text = "0";
            // 
            // lbl主餐價格數字
            // 
            this.lbl主餐價格數字.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl主餐價格數字.Location = new System.Drawing.Point(574, 93);
            this.lbl主餐價格數字.Name = "lbl主餐價格數字";
            this.lbl主餐價格數字.Size = new System.Drawing.Size(93, 27);
            this.lbl主餐價格數字.TabIndex = 25;
            this.lbl主餐價格數字.Text = "0";
            // 
            // btn加入購物車
            // 
            this.btn加入購物車.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn加入購物車.Location = new System.Drawing.Point(466, 222);
            this.btn加入購物車.Name = "btn加入購物車";
            this.btn加入購物車.Size = new System.Drawing.Size(125, 37);
            this.btn加入購物車.TabIndex = 26;
            this.btn加入購物車.Text = "加入購物車";
            this.btn加入購物車.UseVisualStyleBackColor = true;
            this.btn加入購物車.Click += new System.EventHandler(this.btn加入購物車_Click);
            // 
            // btn刪除自選
            // 
            this.btn刪除自選.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn刪除自選.Location = new System.Drawing.Point(465, 436);
            this.btn刪除自選.Name = "btn刪除自選";
            this.btn刪除自選.Size = new System.Drawing.Size(125, 37);
            this.btn刪除自選.TabIndex = 27;
            this.btn刪除自選.Text = "刪除自選";
            this.btn刪除自選.UseVisualStyleBackColor = true;
            this.btn刪除自選.Click += new System.EventHandler(this.btn刪除自選_Click);
            // 
            // lbl訂單編號
            // 
            this.lbl訂單編號.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl訂單編號.Location = new System.Drawing.Point(460, 394);
            this.lbl訂單編號.Name = "lbl訂單編號";
            this.lbl訂單編號.Size = new System.Drawing.Size(164, 27);
            this.lbl訂單編號.TabIndex = 28;
            this.lbl訂單編號.Text = "所選訂單編號";
            // 
            // lbl訂單編號數字
            // 
            this.lbl訂單編號數字.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl訂單編號數字.Location = new System.Drawing.Point(621, 394);
            this.lbl訂單編號數字.Name = "lbl訂單編號數字";
            this.lbl訂單編號數字.Size = new System.Drawing.Size(73, 27);
            this.lbl訂單編號數字.TabIndex = 29;
            this.lbl訂單編號數字.Text = "0";
            // 
            // btn清空購物車
            // 
            this.btn清空購物車.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn清空購物車.Location = new System.Drawing.Point(466, 488);
            this.btn清空購物車.Name = "btn清空購物車";
            this.btn清空購物車.Size = new System.Drawing.Size(125, 37);
            this.btn清空購物車.TabIndex = 30;
            this.btn清空購物車.Text = "清空購物車";
            this.btn清空購物車.UseVisualStyleBackColor = true;
            this.btn清空購物車.Click += new System.EventHandler(this.btn清空購物車_Click);
            // 
            // btn結帳
            // 
            this.btn結帳.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn結帳.Location = new System.Drawing.Point(466, 543);
            this.btn結帳.Name = "btn結帳";
            this.btn結帳.Size = new System.Drawing.Size(125, 37);
            this.btn結帳.TabIndex = 31;
            this.btn結帳.Text = "結帳";
            this.btn結帳.UseVisualStyleBackColor = true;
            this.btn結帳.Click += new System.EventHandler(this.btn結帳_Click);
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.Controls.Add(this.btn結帳);
            this.Controls.Add(this.btn清空購物車);
            this.Controls.Add(this.lbl訂單編號數字);
            this.Controls.Add(this.lbl訂單編號);
            this.Controls.Add(this.btn刪除自選);
            this.Controls.Add(this.btn加入購物車);
            this.Controls.Add(this.lbl主餐價格數字);
            this.Controls.Add(this.lbl總價數字);
            this.Controls.Add(this.lbl總價標題);
            this.Controls.Add(this.txt訂購人);
            this.Controls.Add(this.lbl訂購人);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.listView主餐展示);
            this.Controls.Add(this.txt主餐份數);
            this.Controls.Add(this.lbl主餐份數);
            this.Controls.Add(this.lbl主餐價格標題);
            this.Controls.Add(this.lbl主餐名稱);
            this.Name = "Order";
            this.Size = new System.Drawing.Size(702, 654);
            this.Load += new System.EventHandler(this.Order_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView listView主餐展示;
        private System.Windows.Forms.ImageList imageList主餐圖檔;
        private System.Windows.Forms.Label lbl主餐名稱;
        private System.Windows.Forms.Label lbl主餐價格標題;
        private System.Windows.Forms.Label lbl主餐份數;
        private System.Windows.Forms.TextBox txt主餐份數;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TextBox txt訂購人;
        private System.Windows.Forms.Label lbl訂購人;
        private System.Windows.Forms.Label lbl總價標題;
        private System.Windows.Forms.Label lbl總價數字;
        private System.Windows.Forms.Label lbl主餐價格數字;
        private System.Windows.Forms.Button btn加入購物車;
        private System.Windows.Forms.Button btn刪除自選;
        private System.Windows.Forms.Label lbl訂單編號;
        private System.Windows.Forms.Label lbl訂單編號數字;
        private System.Windows.Forms.Button btn清空購物車;
        private System.Windows.Forms.Button btn結帳;
    }
}
