namespace heigou
{
    partial class Heigo
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
            this.button1 = new System.Windows.Forms.Button();
            this.usernames = new System.Windows.Forms.TextBox();
            this.result = new System.Windows.Forms.TextBox();
            this.moodCont = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.inviteFriendCount = new System.Windows.Forms.TextBox();
            this.shareCJCount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(494, 346);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "执行";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // usernames
            // 
            this.usernames.Location = new System.Drawing.Point(12, 29);
            this.usernames.Multiline = true;
            this.usernames.Name = "usernames";
            this.usernames.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.usernames.Size = new System.Drawing.Size(211, 148);
            this.usernames.TabIndex = 4;
            this.usernames.Text = "15811347006";
            this.usernames.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(12, 206);
            this.result.Multiline = true;
            this.result.Name = "result";
            this.result.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.result.Size = new System.Drawing.Size(449, 175);
            this.result.TabIndex = 5;
            this.result.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // moodCont
            // 
            this.moodCont.Location = new System.Drawing.Point(250, 29);
            this.moodCont.Multiline = true;
            this.moodCont.Name = "moodCont";
            this.moodCont.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.moodCont.Size = new System.Drawing.Size(211, 148);
            this.moodCont.TabIndex = 6;
            this.moodCont.Text = "呃呃呃\r\n额。。。。\r\n今天挺冷\r\n降温了\r\n下雪了\r\n没黑币了\r\n没中奖\r\n没中\r\n\r\n";
            this.moodCont.TextChanged += new System.EventHandler(this.moodCont_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(250, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "吐槽内容";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "手机号码";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "日志";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // inviteFriendCount
            // 
            this.inviteFriendCount.Location = new System.Drawing.Point(557, 40);
            this.inviteFriendCount.Name = "inviteFriendCount";
            this.inviteFriendCount.Size = new System.Drawing.Size(100, 21);
            this.inviteFriendCount.TabIndex = 10;
            this.inviteFriendCount.Text = "1";
            this.inviteFriendCount.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // shareCJCount
            // 
            this.shareCJCount.Location = new System.Drawing.Point(557, 76);
            this.shareCJCount.Name = "shareCJCount";
            this.shareCJCount.Size = new System.Drawing.Size(100, 21);
            this.shareCJCount.TabIndex = 11;
            this.shareCJCount.Text = "1";
            this.shareCJCount.TextChanged += new System.EventHandler(this.textBox2_TextChanged_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(468, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 12);
            this.label4.TabIndex = 12;
            this.label4.Text = "邀请好友次数：";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(468, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 12);
            this.label5.TabIndex = 13;
            this.label5.Text = "分享成就次数：";
            // 
            // Heigo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 394);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.shareCJCount);
            this.Controls.Add(this.inviteFriendCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.moodCont);
            this.Controls.Add(this.result);
            this.Controls.Add(this.usernames);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Heigo";
            this.Text = "黑狗自动化软件";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox usernames;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.TextBox moodCont;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox inviteFriendCount;
        private System.Windows.Forms.TextBox shareCJCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

