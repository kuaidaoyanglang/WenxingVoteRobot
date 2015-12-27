using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WenxingVoteRobot
{
    public partial class CaptchaInput : Form
    {
        public CaptchaInput(Image captcha)
        {
            InitializeComponent();
            pb_Captcha.Image = new Bitmap(captcha);
        }

        public string Captcha { get; set; }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            if(tb_Captcha.Text.Length == 4)
            {
                this.Captcha = tb_Captcha.Text.Trim();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("请输入正确的验证码！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CaptchaInput_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(string.IsNullOrEmpty(this.Captcha))
            {
                this.DialogResult = DialogResult.Cancel;
            }
        }
    }
}
