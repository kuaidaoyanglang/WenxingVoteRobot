using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Drawing.Imaging;
using Tesseract;
using System.Text.RegularExpressions;

namespace WenxingFlash
{
    public partial class MainForm : Form
    {
        const string CaptchaUri = "http://www.chinawenxing.com.cn/inc/code.php";
        const string PageUri = "http://www.chinawenxing.com.cn/list.php?act=shownews&id=16&nid={0}";
        const string VoteUri = "http://www.chinawenxing.com.cn/list.php?act=shownews&id=16&nid={0}&yzimg={1}&tuijianccc=%E6%8E%A8%E8%8D%90";

        public MainForm()
        {
            InitializeComponent();
            lb_Counter.Alignment = ToolStripItemAlignment.Right;
        }

        bool stopFlag = false;
        int voteCount = 0;

        private void UpdateProgress()
        {
            lb_Counter.Text = string.Format("已刷 {0} 票", voteCount);
            pgb_Progress.Value = (int)(voteCount / (double)num_MaxVote.Value * 10000.0D);
        }

        private async Task Delay()
        {
            if (cb_Delay.Checked)
            {
                await Task.Delay(TimeSpan.FromMilliseconds((double)num_Delay.Value));
            }
        }

        private async Task Vote(int id)
        {
            lb_Status.Text = "正在刷票  ";
            Random rnd = new Random();
            string userAgent = Utility.RandomUserAgent();
            while (!stopFlag)
            {
                CookieContainer cookies = new CookieContainer();
                RecognizeResult captchaResult;

                int simulateAccess = rnd.Next(1, 3);
                for (int i = 0; i < simulateAccess; i++)
                {
                    lb_Operation.Text = string.Format("正在模拟访问，第 {0} 次，共 {1} 次...", i + 1, simulateAccess);
                    await Utility.HTTPGetStringAsync(userAgent, string.Format(PageUri, id), cookies);
                    await Delay();
                }

                do
                {
                    lb_Operation.Text = "正在获取验证码图像...";
                    Bitmap captcha = await Utility.HTTPGetPngAsync(userAgent, CaptchaUri, cookies);
                    await Delay();
                    pic_Captcha.Image = captcha;
                    lb_Operation.Text = "正在识别...";
                    captchaResult = await CaptchaRecognizer.RecoginzeAsync(captcha);
                }
                while (captchaResult.Confidence < 0.8);

                lb_Operation.Text = string.Format("正在提交，验证码为 {0}", captchaResult.Value);
                string submitResult = await Utility.HTTPGetStringAsync(userAgent, string.Format(VoteUri, id, captchaResult.Value), cookies);
                await Delay();

                bool success = submitResult.Contains("推荐成功");
                if (success)
                {
                    voteCount++;
                    UpdateProgress();
                }

                if (cb_MaxVote.Checked && voteCount >= num_MaxVote.Value)
                {
                    break;
                }
            }
            stopFlag = false;
            btn_Start.Enabled = true;
            btn_Start.Text = "开始";
            lb_Status.Text = "刷票结束";
            lb_Operation.Text = "";
        }

        private async void btn_Start_Click(object sender, EventArgs e)
        {
            if (btn_Start.Tag == null)
            {

                Regex urlRegex = new Regex(@"(?:^|/?|&)nid=([^&]*)(?:&|$)");
                Match m = urlRegex.Match(tb_Url.Text.ToLower());
                if (m.Success)
                {
                    int id;
                    if (int.TryParse(m.Groups[1].Value, out id))
                    {
                        if (MessageBox.Show("此工具仅用于测试网站安全性，禁止用于其他用途。如果主办方检测到作弊行为，则比赛资格可能被取消。你是否愿意承担刷票行为所造成的全部后果？", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            tb_Url.Enabled = false;
                            btn_Start.Text = "停止";
                            btn_Start.Tag = new object();
                            await Vote(id);
                            return;
                        }
                    }
                }
                MessageBox.Show("请输入正确的网址！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                stopFlag = true;
                btn_Start.Enabled = false;
                btn_Start.Text = "正在停止";
                btn_Start.Tag = null;
            }
        }

        private void cb_MaxVote_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_MaxVote.Checked)
            {
                num_MaxVote.Enabled = true;
                pgb_Progress.Visible = true;
            }
            else
            {
                num_MaxVote.Enabled = false;
                pgb_Progress.Visible = false;
            }
        }

        private void cb_Delay_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_Delay.Checked)
            {
                num_Delay.Enabled = true;
            }
            else
            {
                num_Delay.Enabled = false;
            }
        }

        private void num_MaxVote_ValueChanged(object sender, EventArgs e)
        {
            UpdateProgress();
        }

        private void tl_ResetCounter_Click(object sender, EventArgs e)
        {
            voteCount = 0;
            UpdateProgress();
        }
    }
}
