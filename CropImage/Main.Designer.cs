namespace CropImage
{
    partial class Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.imageSelectBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // imageSelectBtn
            // 
            this.imageSelectBtn.Location = new System.Drawing.Point(96, 103);
            this.imageSelectBtn.Name = "imageSelectBtn";
            this.imageSelectBtn.Size = new System.Drawing.Size(75, 23);
            this.imageSelectBtn.TabIndex = 0;
            this.imageSelectBtn.Text = "请选择图片";
            this.imageSelectBtn.UseVisualStyleBackColor = true;
            this.imageSelectBtn.Click += new System.EventHandler(this.imageSelectBtn_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.imageSelectBtn);
            this.Name = "Main";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button imageSelectBtn;
    }
}

