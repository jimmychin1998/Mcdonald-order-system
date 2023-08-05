namespace Project
{
    partial class LogIn
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
            this.btn登入login = new System.Windows.Forms.Button();
            this.lbl帳號 = new System.Windows.Forms.Label();
            this.lbl密碼 = new System.Windows.Forms.Label();
            this.txt密碼 = new System.Windows.Forms.TextBox();
            this.txt帳號 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn登入login
            // 
            this.btn登入login.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn登入login.Location = new System.Drawing.Point(248, 314);
            this.btn登入login.Name = "btn登入login";
            this.btn登入login.Size = new System.Drawing.Size(151, 37);
            this.btn登入login.TabIndex = 37;
            this.btn登入login.Text = "登入";
            this.btn登入login.UseVisualStyleBackColor = true;
            this.btn登入login.Click += new System.EventHandler(this.btn登入login_Click);
            // 
            // lbl帳號
            // 
            this.lbl帳號.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl帳號.Location = new System.Drawing.Point(111, 181);
            this.lbl帳號.Name = "lbl帳號";
            this.lbl帳號.Size = new System.Drawing.Size(164, 27);
            this.lbl帳號.TabIndex = 39;
            this.lbl帳號.Text = "帳號";
            this.lbl帳號.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl密碼
            // 
            this.lbl密碼.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl密碼.Location = new System.Drawing.Point(111, 246);
            this.lbl密碼.Name = "lbl密碼";
            this.lbl密碼.Size = new System.Drawing.Size(164, 27);
            this.lbl密碼.TabIndex = 40;
            this.lbl密碼.Text = "密碼";
            this.lbl密碼.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt密碼
            // 
            this.txt密碼.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt密碼.Location = new System.Drawing.Point(248, 243);
            this.txt密碼.Multiline = true;
            this.txt密碼.Name = "txt密碼";
            this.txt密碼.Size = new System.Drawing.Size(213, 34);
            this.txt密碼.TabIndex = 41;
            // 
            // txt帳號
            // 
            this.txt帳號.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt帳號.Location = new System.Drawing.Point(248, 181);
            this.txt帳號.Multiline = true;
            this.txt帳號.Name = "txt帳號";
            this.txt帳號.Size = new System.Drawing.Size(213, 34);
            this.txt帳號.TabIndex = 42;
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.Controls.Add(this.txt帳號);
            this.Controls.Add(this.txt密碼);
            this.Controls.Add(this.lbl密碼);
            this.Controls.Add(this.lbl帳號);
            this.Controls.Add(this.btn登入login);
            this.Name = "LogIn";
            this.Size = new System.Drawing.Size(702, 654);
            this.Load += new System.EventHandler(this.LogIn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn登入login;
        private System.Windows.Forms.Label lbl帳號;
        private System.Windows.Forms.Label lbl密碼;
        private System.Windows.Forms.TextBox txt密碼;
        private System.Windows.Forms.TextBox txt帳號;
    }
}
