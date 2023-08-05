namespace Project
{
    partial class OrderList
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
            this.lbl訂單編號數字 = new System.Windows.Forms.Label();
            this.lbl訂單編號 = new System.Windows.Forms.Label();
            this.btn清空結帳列表 = new System.Windows.Forms.Button();
            this.btn刪除自選 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl訂單編號數字
            // 
            this.lbl訂單編號數字.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl訂單編號數字.Location = new System.Drawing.Point(415, 401);
            this.lbl訂單編號數字.Name = "lbl訂單編號數字";
            this.lbl訂單編號數字.Size = new System.Drawing.Size(73, 27);
            this.lbl訂單編號數字.TabIndex = 39;
            this.lbl訂單編號數字.Text = "0";
            // 
            // lbl訂單編號
            // 
            this.lbl訂單編號.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl訂單編號.Location = new System.Drawing.Point(254, 401);
            this.lbl訂單編號.Name = "lbl訂單編號";
            this.lbl訂單編號.Size = new System.Drawing.Size(164, 27);
            this.lbl訂單編號.TabIndex = 38;
            this.lbl訂單編號.Text = "所選訂單編號";
            // 
            // btn清空結帳列表
            // 
            this.btn清空結帳列表.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn清空結帳列表.Location = new System.Drawing.Point(385, 452);
            this.btn清空結帳列表.Name = "btn清空結帳列表";
            this.btn清空結帳列表.Size = new System.Drawing.Size(151, 37);
            this.btn清空結帳列表.TabIndex = 37;
            this.btn清空結帳列表.Text = "清空結帳列表";
            this.btn清空結帳列表.UseVisualStyleBackColor = true;
            this.btn清空結帳列表.Click += new System.EventHandler(this.btn清空結帳列表_Click);
            // 
            // btn刪除自選
            // 
            this.btn刪除自選.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn刪除自選.Location = new System.Drawing.Point(144, 452);
            this.btn刪除自選.Name = "btn刪除自選";
            this.btn刪除自選.Size = new System.Drawing.Size(151, 37);
            this.btn刪除自選.TabIndex = 36;
            this.btn刪除自選.Text = "刪除自選";
            this.btn刪除自選.UseVisualStyleBackColor = true;
            this.btn刪除自選.Click += new System.EventHandler(this.btn刪除自選_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Cornsilk;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 73);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(672, 295);
            this.dataGridView1.TabIndex = 35;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // OrderList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.Controls.Add(this.lbl訂單編號數字);
            this.Controls.Add(this.lbl訂單編號);
            this.Controls.Add(this.btn清空結帳列表);
            this.Controls.Add(this.btn刪除自選);
            this.Controls.Add(this.dataGridView1);
            this.Name = "OrderList";
            this.Size = new System.Drawing.Size(702, 654);
            this.Load += new System.EventHandler(this.OrderList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl訂單編號數字;
        private System.Windows.Forms.Label lbl訂單編號;
        private System.Windows.Forms.Button btn清空結帳列表;
        private System.Windows.Forms.Button btn刪除自選;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
