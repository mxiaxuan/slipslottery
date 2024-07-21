namespace 程式化語法動態建構元件
{
    partial class 程式化語法動態建構元件
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

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btn快選 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn快選
            // 
            this.btn快選.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn快選.Location = new System.Drawing.Point(739, 463);
            this.btn快選.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn快選.Name = "btn快選";
            this.btn快選.Size = new System.Drawing.Size(207, 60);
            this.btn快選.TabIndex = 0;
            this.btn快選.Text = "快選";
            this.btn快選.UseVisualStyleBackColor = true;
            this.btn快選.Click += new System.EventHandler(this.btn快選_Click);
            // 
            // 程式化語法動態建構元件
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(958, 542);
            this.Controls.Add(this.btn快選);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "程式化語法動態建構元件";
            this.Text = "程式化語法動態建構元件";
            this.Load += new System.EventHandler(this.程式化語法動態建構元件_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn快選;
    }
}

