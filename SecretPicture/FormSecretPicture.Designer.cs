namespace SecretPicture
{
    partial class FormSecretPicture
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSecretPicture));
            this.buttonShowImage1 = new System.Windows.Forms.Button();
            this.buttonShowImage2 = new System.Windows.Forms.Button();
            this.buttonShowImage4 = new System.Windows.Forms.Button();
            this.buttonShowImage3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonShowImage1
            // 
            this.buttonShowImage1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonShowImage1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonShowImage1.Location = new System.Drawing.Point(12, 12);
            this.buttonShowImage1.Name = "buttonShowImage1";
            this.buttonShowImage1.Size = new System.Drawing.Size(101, 31);
            this.buttonShowImage1.TabIndex = 0;
            this.buttonShowImage1.Text = "Ягуар";
            this.buttonShowImage1.UseVisualStyleBackColor = true;
            this.buttonShowImage1.Click += new System.EventHandler(this.buttonShowImage1_Click);
            // 
            // buttonShowImage2
            // 
            this.buttonShowImage2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonShowImage2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonShowImage2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonShowImage2.Location = new System.Drawing.Point(271, 12);
            this.buttonShowImage2.Name = "buttonShowImage2";
            this.buttonShowImage2.Size = new System.Drawing.Size(101, 31);
            this.buttonShowImage2.TabIndex = 0;
            this.buttonShowImage2.Text = "Замок";
            this.buttonShowImage2.UseVisualStyleBackColor = true;
            this.buttonShowImage2.Click += new System.EventHandler(this.buttonShowImage2_Click);
            // 
            // buttonShowImage4
            // 
            this.buttonShowImage4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonShowImage4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonShowImage4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonShowImage4.Location = new System.Drawing.Point(271, 218);
            this.buttonShowImage4.Name = "buttonShowImage4";
            this.buttonShowImage4.Size = new System.Drawing.Size(101, 31);
            this.buttonShowImage4.TabIndex = 0;
            this.buttonShowImage4.Text = "Лебедь";
            this.buttonShowImage4.UseVisualStyleBackColor = true;
            this.buttonShowImage4.Click += new System.EventHandler(this.buttonShowImage4_Click);
            // 
            // buttonShowImage3
            // 
            this.buttonShowImage3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonShowImage3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonShowImage3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonShowImage3.Location = new System.Drawing.Point(12, 221);
            this.buttonShowImage3.Name = "buttonShowImage3";
            this.buttonShowImage3.Size = new System.Drawing.Size(101, 31);
            this.buttonShowImage3.TabIndex = 0;
            this.buttonShowImage3.Text = "Котик";
            this.buttonShowImage3.UseVisualStyleBackColor = true;
            this.buttonShowImage3.Click += new System.EventHandler(this.buttonShowImage3_Click);
            // 
            // FormSecretPicture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.buttonShowImage3);
            this.Controls.Add(this.buttonShowImage4);
            this.Controls.Add(this.buttonShowImage2);
            this.Controls.Add(this.buttonShowImage1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(400, 300);
            this.Name = "FormSecretPicture";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Картинка с секретом";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FormSecretPicture_MouseClick);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormSecretPicture_MouseMove);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonShowImage1;
        private System.Windows.Forms.Button buttonShowImage2;
        private System.Windows.Forms.Button buttonShowImage4;
        private System.Windows.Forms.Button buttonShowImage3;
    }
}

