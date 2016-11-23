namespace blackdog
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.moods = new System.Windows.Forms.TextBox();
            this.result = new System.Windows.Forms.TextBox();
            this.commit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.usernames = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // moods
            // 
            this.moods.Location = new System.Drawing.Point(256, 34);
            this.moods.Multiline = true;
            this.moods.Name = "moods";
            this.moods.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.moods.Size = new System.Drawing.Size(208, 167);
            this.moods.TabIndex = 1;
            this.moods.Text = "哈哈哈";
            this.moods.TextChanged += new System.EventHandler(this.moods_TextChanged);
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(12, 278);
            this.result.Multiline = true;
            this.result.Name = "result";
            this.result.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.result.Size = new System.Drawing.Size(452, 171);
            this.result.TabIndex = 2;
            this.result.TextChanged += new System.EventHandler(this.logs_TextChanged);
            // 
            // commit
            // 
            this.commit.Location = new System.Drawing.Point(69, 218);
            this.commit.Name = "commit";
            this.commit.Size = new System.Drawing.Size(338, 32);
            this.commit.TabIndex = 3;
            this.commit.Text = "执行";
            this.commit.UseVisualStyleBackColor = true;
            this.commit.Click += new System.EventHandler(this.commit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "日志";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "用户名";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(254, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "吐槽";
            // 
            // usernames
            // 
            this.usernames.Location = new System.Drawing.Point(12, 34);
            this.usernames.Multiline = true;
            this.usernames.Name = "usernames";
            this.usernames.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.usernames.Size = new System.Drawing.Size(208, 167);
            this.usernames.TabIndex = 7;
            this.usernames.Text = "17346522293";
            this.usernames.TextChanged += new System.EventHandler(this.usernames_TextChanged);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 461);
            this.Controls.Add(this.usernames);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.commit);
            this.Controls.Add(this.result);
            this.Controls.Add(this.moods);
            this.Name = "Main";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox moods;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Button commit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox usernames;
    }
}

