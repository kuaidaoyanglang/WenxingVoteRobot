namespace WenxingVoteRobot
{
    partial class CaptchaInput
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pb_Captcha = new System.Windows.Forms.PictureBox();
            this.tb_Captcha = new System.Windows.Forms.TextBox();
            this.btn_OK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Captcha)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_Captcha
            // 
            this.pb_Captcha.Location = new System.Drawing.Point(12, 12);
            this.pb_Captcha.Name = "pb_Captcha";
            this.pb_Captcha.Size = new System.Drawing.Size(40, 17);
            this.pb_Captcha.TabIndex = 0;
            this.pb_Captcha.TabStop = false;
            // 
            // tb_Captcha
            // 
            this.tb_Captcha.Location = new System.Drawing.Point(58, 12);
            this.tb_Captcha.Name = "tb_Captcha";
            this.tb_Captcha.Size = new System.Drawing.Size(57, 21);
            this.tb_Captcha.TabIndex = 1;
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(121, 10);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(75, 23);
            this.btn_OK.TabIndex = 2;
            this.btn_OK.Text = "确定";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // CaptchaInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(207, 44);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.tb_Captcha);
            this.Controls.Add(this.pb_Captcha);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CaptchaInput";
            this.ShowInTaskbar = false;
            this.Text = "请输入验证码";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CaptchaInput_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Captcha)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_Captcha;
        private System.Windows.Forms.TextBox tb_Captcha;
        private System.Windows.Forms.Button btn_OK;
    }
}