namespace WenxingVoteRobot
{
    partial class MainForm
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_Url = new System.Windows.Forms.TextBox();
            this.pic_Captcha = new System.Windows.Forms.PictureBox();
            this.btn_Start = new System.Windows.Forms.Button();
            this.num_Delay = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_MaxVote = new System.Windows.Forms.CheckBox();
            this.num_MaxVote = new System.Windows.Forms.NumericUpDown();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lb_Status = new System.Windows.Forms.ToolStripStatusLabel();
            this.lb_Operation = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tl_ResetCounter = new System.Windows.Forms.ToolStripStatusLabel();
            this.lb_Counter = new System.Windows.Forms.ToolStripStatusLabel();
            this.pgb_Progress = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.cb_Delay = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Captcha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Delay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_MaxVote)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_Url
            // 
            this.tb_Url.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Url.Location = new System.Drawing.Point(105, 17);
            this.tb_Url.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_Url.Name = "tb_Url";
            this.tb_Url.Size = new System.Drawing.Size(563, 23);
            this.tb_Url.TabIndex = 6;
            // 
            // pic_Captcha
            // 
            this.pic_Captcha.Location = new System.Drawing.Point(12, 20);
            this.pic_Captcha.Name = "pic_Captcha";
            this.pic_Captcha.Size = new System.Drawing.Size(40, 17);
            this.pic_Captcha.TabIndex = 7;
            this.pic_Captcha.TabStop = false;
            // 
            // btn_Start
            // 
            this.btn_Start.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Start.Location = new System.Drawing.Point(12, 105);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(656, 23);
            this.btn_Start.TabIndex = 8;
            this.btn_Start.Text = "开始";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // num_Delay
            // 
            this.num_Delay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.num_Delay.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.num_Delay.Location = new System.Drawing.Point(105, 47);
            this.num_Delay.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.num_Delay.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.num_Delay.Name = "num_Delay";
            this.num_Delay.Size = new System.Drawing.Size(563, 23);
            this.num_Delay.TabIndex = 9;
            this.num_Delay.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "网址：";
            // 
            // cb_MaxVote
            // 
            this.cb_MaxVote.AutoSize = true;
            this.cb_MaxVote.Checked = true;
            this.cb_MaxVote.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_MaxVote.Location = new System.Drawing.Point(12, 77);
            this.cb_MaxVote.Name = "cb_MaxVote";
            this.cb_MaxVote.Size = new System.Drawing.Size(87, 21);
            this.cb_MaxVote.TabIndex = 12;
            this.cb_MaxVote.Text = "最多刷票数";
            this.cb_MaxVote.UseVisualStyleBackColor = true;
            this.cb_MaxVote.CheckedChanged += new System.EventHandler(this.cb_MaxVote_CheckedChanged);
            // 
            // num_MaxVote
            // 
            this.num_MaxVote.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.num_MaxVote.Location = new System.Drawing.Point(105, 76);
            this.num_MaxVote.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.num_MaxVote.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_MaxVote.Name = "num_MaxVote";
            this.num_MaxVote.Size = new System.Drawing.Size(563, 23);
            this.num_MaxVote.TabIndex = 13;
            this.num_MaxVote.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.num_MaxVote.ValueChanged += new System.EventHandler(this.num_MaxVote_ValueChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lb_Status,
            this.lb_Operation,
            this.toolStripStatusLabel2,
            this.tl_ResetCounter,
            this.lb_Counter,
            this.pgb_Progress,
            this.toolStripStatusLabel5});
            this.statusStrip1.Location = new System.Drawing.Point(0, 143);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(680, 22);
            this.statusStrip1.TabIndex = 14;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lb_Status
            // 
            this.lb_Status.Name = "lb_Status";
            this.lb_Status.Size = new System.Drawing.Size(150, 17);
            this.lb_Status.Text = "请单击“开始”按钮来刷票。";
            // 
            // lb_Operation
            // 
            this.lb_Operation.Name = "lb_Operation";
            this.lb_Operation.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(286, 17);
            this.toolStripStatusLabel2.Spring = true;
            // 
            // tl_ResetCounter
            // 
            this.tl_ResetCounter.IsLink = true;
            this.tl_ResetCounter.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.tl_ResetCounter.Name = "tl_ResetCounter";
            this.tl_ResetCounter.Size = new System.Drawing.Size(68, 17);
            this.tl_ResetCounter.Text = "计数器清零";
            this.tl_ResetCounter.Click += new System.EventHandler(this.tl_ResetCounter_Click);
            // 
            // lb_Counter
            // 
            this.lb_Counter.Name = "lb_Counter";
            this.lb_Counter.Size = new System.Drawing.Size(59, 17);
            this.lb_Counter.Text = "已刷 0 票";
            // 
            // pgb_Progress
            // 
            this.pgb_Progress.Maximum = 10000;
            this.pgb_Progress.Name = "pgb_Progress";
            this.pgb_Progress.Size = new System.Drawing.Size(100, 16);
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(0, 17);
            // 
            // cb_Delay
            // 
            this.cb_Delay.AutoSize = true;
            this.cb_Delay.Checked = true;
            this.cb_Delay.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_Delay.Location = new System.Drawing.Point(48, 48);
            this.cb_Delay.Name = "cb_Delay";
            this.cb_Delay.Size = new System.Drawing.Size(51, 21);
            this.cb_Delay.TabIndex = 15;
            this.cb_Delay.Text = "延迟";
            this.cb_Delay.UseVisualStyleBackColor = true;
            this.cb_Delay.CheckedChanged += new System.EventHandler(this.cb_Delay_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 165);
            this.Controls.Add(this.cb_Delay);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.num_MaxVote);
            this.Controls.Add(this.cb_MaxVote);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.num_Delay);
            this.Controls.Add(this.btn_Start);
            this.Controls.Add(this.pic_Captcha);
            this.Controls.Add(this.tb_Url);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "内部工具，切勿外传 by t123yh";
            ((System.ComponentModel.ISupportInitialize)(this.pic_Captcha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Delay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_MaxVote)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tb_Url;
        private System.Windows.Forms.PictureBox pic_Captcha;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.NumericUpDown num_Delay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cb_MaxVote;
        private System.Windows.Forms.NumericUpDown num_MaxVote;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lb_Counter;
        private System.Windows.Forms.ToolStripProgressBar pgb_Progress;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel lb_Status;
        private System.Windows.Forms.ToolStripStatusLabel tl_ResetCounter;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.CheckBox cb_Delay;
        private System.Windows.Forms.ToolStripStatusLabel lb_Operation;
    }
}

