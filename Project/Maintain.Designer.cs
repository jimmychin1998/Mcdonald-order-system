namespace Project
{
    partial class Maintain
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
            this.btn圖片模式 = new System.Windows.Forms.Button();
            this.btn列表模式 = new System.Windows.Forms.Button();
            this.btn新增商品 = new System.Windows.Forms.Button();
            this.btn重新整理 = new System.Windows.Forms.Button();
            this.listView商品展示 = new System.Windows.Forms.ListView();
            this.imageList產品圖檔 = new System.Windows.Forms.ImageList(this.components);
            this.btnrefreshhide = new System.Windows.Forms.Button();
            this.btnnewhide = new System.Windows.Forms.Button();
            this.btnlisthide = new System.Windows.Forms.Button();
            this.btnpicturehide = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn圖片模式
            // 
            this.btn圖片模式.FlatAppearance.BorderSize = 0;
            this.btn圖片模式.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn圖片模式.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn圖片模式.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btn圖片模式.Location = new System.Drawing.Point(532, 21);
            this.btn圖片模式.Margin = new System.Windows.Forms.Padding(2);
            this.btn圖片模式.Name = "btn圖片模式";
            this.btn圖片模式.Size = new System.Drawing.Size(154, 43);
            this.btn圖片模式.TabIndex = 8;
            this.btn圖片模式.Text = "圖片模式";
            this.btn圖片模式.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn圖片模式.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn圖片模式.UseVisualStyleBackColor = true;
            this.btn圖片模式.Click += new System.EventHandler(this.btn圖片模式_Click);
            // 
            // btn列表模式
            // 
            this.btn列表模式.FlatAppearance.BorderSize = 0;
            this.btn列表模式.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn列表模式.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn列表模式.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btn列表模式.Location = new System.Drawing.Point(532, 79);
            this.btn列表模式.Margin = new System.Windows.Forms.Padding(2);
            this.btn列表模式.Name = "btn列表模式";
            this.btn列表模式.Size = new System.Drawing.Size(154, 43);
            this.btn列表模式.TabIndex = 10;
            this.btn列表模式.Text = "列表模式";
            this.btn列表模式.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn列表模式.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn列表模式.UseVisualStyleBackColor = true;
            this.btn列表模式.Click += new System.EventHandler(this.btn列表模式_Click);
            // 
            // btn新增商品
            // 
            this.btn新增商品.FlatAppearance.BorderSize = 0;
            this.btn新增商品.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn新增商品.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn新增商品.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btn新增商品.Location = new System.Drawing.Point(532, 138);
            this.btn新增商品.Margin = new System.Windows.Forms.Padding(2);
            this.btn新增商品.Name = "btn新增商品";
            this.btn新增商品.Size = new System.Drawing.Size(154, 43);
            this.btn新增商品.TabIndex = 12;
            this.btn新增商品.Text = "新增商品";
            this.btn新增商品.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn新增商品.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn新增商品.UseVisualStyleBackColor = true;
            this.btn新增商品.Click += new System.EventHandler(this.btn新增商品_Click);
            // 
            // btn重新整理
            // 
            this.btn重新整理.FlatAppearance.BorderSize = 0;
            this.btn重新整理.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn重新整理.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn重新整理.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btn重新整理.Location = new System.Drawing.Point(532, 191);
            this.btn重新整理.Margin = new System.Windows.Forms.Padding(2);
            this.btn重新整理.Name = "btn重新整理";
            this.btn重新整理.Size = new System.Drawing.Size(154, 43);
            this.btn重新整理.TabIndex = 14;
            this.btn重新整理.Text = "重新整理";
            this.btn重新整理.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn重新整理.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn重新整理.UseVisualStyleBackColor = true;
            this.btn重新整理.Click += new System.EventHandler(this.btn重新整理_Click);
            // 
            // listView商品展示
            // 
            this.listView商品展示.BackColor = System.Drawing.Color.Cornsilk;
            this.listView商品展示.HideSelection = false;
            this.listView商品展示.Location = new System.Drawing.Point(24, 21);
            this.listView商品展示.Name = "listView商品展示";
            this.listView商品展示.Size = new System.Drawing.Size(492, 614);
            this.listView商品展示.TabIndex = 16;
            this.listView商品展示.UseCompatibleStateImageBehavior = false;
            this.listView商品展示.ItemActivate += new System.EventHandler(this.listView商品展示_ItemActivate);
            // 
            // imageList產品圖檔
            // 
            this.imageList產品圖檔.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList產品圖檔.ImageSize = new System.Drawing.Size(256, 256);
            this.imageList產品圖檔.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // btnrefreshhide
            // 
            this.btnrefreshhide.BackgroundImage = global::Project.Properties.Resources.refresh;
            this.btnrefreshhide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnrefreshhide.FlatAppearance.BorderSize = 0;
            this.btnrefreshhide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnrefreshhide.Location = new System.Drawing.Point(636, 197);
            this.btnrefreshhide.Margin = new System.Windows.Forms.Padding(2);
            this.btnrefreshhide.Name = "btnrefreshhide";
            this.btnrefreshhide.Size = new System.Drawing.Size(33, 29);
            this.btnrefreshhide.TabIndex = 15;
            this.btnrefreshhide.UseVisualStyleBackColor = true;
            // 
            // btnnewhide
            // 
            this.btnnewhide.BackgroundImage = global::Project.Properties.Resources._new;
            this.btnnewhide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnnewhide.FlatAppearance.BorderSize = 0;
            this.btnnewhide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnewhide.Location = new System.Drawing.Point(631, 141);
            this.btnnewhide.Margin = new System.Windows.Forms.Padding(2);
            this.btnnewhide.Name = "btnnewhide";
            this.btnnewhide.Size = new System.Drawing.Size(44, 35);
            this.btnnewhide.TabIndex = 13;
            this.btnnewhide.UseVisualStyleBackColor = true;
            // 
            // btnlisthide
            // 
            this.btnlisthide.BackgroundImage = global::Project.Properties.Resources.list;
            this.btnlisthide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnlisthide.FlatAppearance.BorderSize = 0;
            this.btnlisthide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlisthide.Location = new System.Drawing.Point(636, 82);
            this.btnlisthide.Margin = new System.Windows.Forms.Padding(2);
            this.btnlisthide.Name = "btnlisthide";
            this.btnlisthide.Size = new System.Drawing.Size(30, 32);
            this.btnlisthide.TabIndex = 11;
            this.btnlisthide.UseVisualStyleBackColor = true;
            // 
            // btnpicturehide
            // 
            this.btnpicturehide.BackgroundImage = global::Project.Properties.Resources.picture;
            this.btnpicturehide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnpicturehide.FlatAppearance.BorderSize = 0;
            this.btnpicturehide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnpicturehide.Location = new System.Drawing.Point(629, 13);
            this.btnpicturehide.Margin = new System.Windows.Forms.Padding(2);
            this.btnpicturehide.Name = "btnpicturehide";
            this.btnpicturehide.Size = new System.Drawing.Size(44, 53);
            this.btnpicturehide.TabIndex = 9;
            this.btnpicturehide.UseVisualStyleBackColor = true;
            // 
            // Maintain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.Controls.Add(this.listView商品展示);
            this.Controls.Add(this.btnrefreshhide);
            this.Controls.Add(this.btn重新整理);
            this.Controls.Add(this.btnnewhide);
            this.Controls.Add(this.btn新增商品);
            this.Controls.Add(this.btnlisthide);
            this.Controls.Add(this.btn列表模式);
            this.Controls.Add(this.btnpicturehide);
            this.Controls.Add(this.btn圖片模式);
            this.Name = "Maintain";
            this.Size = new System.Drawing.Size(702, 654);
            this.Load += new System.EventHandler(this.Maintain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnpicturehide;
        private System.Windows.Forms.Button btn圖片模式;
        private System.Windows.Forms.Button btnlisthide;
        private System.Windows.Forms.Button btn列表模式;
        private System.Windows.Forms.Button btnnewhide;
        private System.Windows.Forms.Button btn新增商品;
        private System.Windows.Forms.Button btnrefreshhide;
        private System.Windows.Forms.Button btn重新整理;
        private System.Windows.Forms.ListView listView商品展示;
        private System.Windows.Forms.ImageList imageList產品圖檔;
    }
}
