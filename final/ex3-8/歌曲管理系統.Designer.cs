namespace ex3_8
{
    partial class Menu
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.新增歌曲ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.輸入密碼ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.新增歌曲ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.刪除歌曲ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.查詢包廂狀態ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button4 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button7 = new System.Windows.Forms.Button();
            this.skipBtn = new System.Windows.Forms.Button();
            this.playBtn = new System.Windows.Forms.Button();
            this.pauseBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(289, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "查詢歌曲";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 99);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(289, 30);
            this.button2.TabIndex = 1;
            this.button2.Text = "熱門歌曲";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 63);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(289, 30);
            this.button3.TabIndex = 2;
            this.button3.Text = "新歌爆爆";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新增歌曲ToolStripMenuItem,
            this.查詢包廂狀態ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(577, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 新增歌曲ToolStripMenuItem
            // 
            this.新增歌曲ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.輸入密碼ToolStripMenuItem,
            this.新增歌曲ToolStripMenuItem1,
            this.刪除歌曲ToolStripMenuItem1});
            this.新增歌曲ToolStripMenuItem.Name = "新增歌曲ToolStripMenuItem";
            this.新增歌曲ToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.新增歌曲ToolStripMenuItem.Text = "服務人員系統";
            // 
            // 輸入密碼ToolStripMenuItem
            // 
            this.輸入密碼ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1});
            this.輸入密碼ToolStripMenuItem.Name = "輸入密碼ToolStripMenuItem";
            this.輸入密碼ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.輸入密碼ToolStripMenuItem.Text = "輸入密碼";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.AccessibleDescription = "";
            this.toolStripTextBox1.MaxLength = 20;
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBox1.TextChanged += new System.EventHandler(this.toolStripTextBox1_TextChanged);
            // 
            // 新增歌曲ToolStripMenuItem1
            // 
            this.新增歌曲ToolStripMenuItem1.Enabled = false;
            this.新增歌曲ToolStripMenuItem1.Name = "新增歌曲ToolStripMenuItem1";
            this.新增歌曲ToolStripMenuItem1.Size = new System.Drawing.Size(122, 22);
            this.新增歌曲ToolStripMenuItem1.Text = "新增歌曲";
            this.新增歌曲ToolStripMenuItem1.Click += new System.EventHandler(this.新增歌曲ToolStripMenuItem1_Click);
            // 
            // 刪除歌曲ToolStripMenuItem1
            // 
            this.刪除歌曲ToolStripMenuItem1.Enabled = false;
            this.刪除歌曲ToolStripMenuItem1.Name = "刪除歌曲ToolStripMenuItem1";
            this.刪除歌曲ToolStripMenuItem1.Size = new System.Drawing.Size(122, 22);
            this.刪除歌曲ToolStripMenuItem1.Text = "刪除歌曲";
            this.刪除歌曲ToolStripMenuItem1.Click += new System.EventHandler(this.刪除歌曲ToolStripMenuItem1_Click);
            // 
            // 查詢包廂狀態ToolStripMenuItem
            // 
            this.查詢包廂狀態ToolStripMenuItem.Name = "查詢包廂狀態ToolStripMenuItem";
            this.查詢包廂狀態ToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.查詢包廂狀態ToolStripMenuItem.Text = "查詢包廂狀態";
            this.查詢包廂狀態ToolStripMenuItem.Click += new System.EventHandler(this.查詢包廂狀態ToolStripMenuItem_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 135);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(289, 30);
            this.button4.TabIndex = 4;
            this.button4.Text = "歌星推薦";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("微軟正黑體", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(322, 27);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBox1.Size = new System.Drawing.Size(243, 204);
            this.listBox1.TabIndex = 5;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(322, 229);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(243, 28);
            this.button7.TabIndex = 8;
            this.button7.Text = "清空待播清單";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // skipBtn
            // 
            this.skipBtn.BackgroundImage = global::ex3_8.Properties.Resources.fast_forward_solid;
            this.skipBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.skipBtn.Location = new System.Drawing.Point(502, 3);
            this.skipBtn.Name = "skipBtn";
            this.skipBtn.Size = new System.Drawing.Size(48, 37);
            this.skipBtn.TabIndex = 9;
            this.skipBtn.UseVisualStyleBackColor = true;
            this.skipBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // playBtn
            // 
            this.playBtn.BackgroundImage = global::ex3_8.Properties.Resources.play_solid;
            this.playBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.playBtn.Location = new System.Drawing.Point(448, 3);
            this.playBtn.Name = "playBtn";
            this.playBtn.Size = new System.Drawing.Size(48, 37);
            this.playBtn.TabIndex = 10;
            this.playBtn.UseVisualStyleBackColor = true;
            this.playBtn.Click += new System.EventHandler(this.playBtn_Click);
            // 
            // pauseBtn
            // 
            this.pauseBtn.BackgroundImage = global::ex3_8.Properties.Resources.pause_solid;
            this.pauseBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pauseBtn.Location = new System.Drawing.Point(394, 3);
            this.pauseBtn.Name = "pauseBtn";
            this.pauseBtn.Size = new System.Drawing.Size(48, 37);
            this.pauseBtn.TabIndex = 11;
            this.pauseBtn.UseVisualStyleBackColor = true;
            this.pauseBtn.Click += new System.EventHandler(this.pauseBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.skipBtn);
            this.panel1.Controls.Add(this.pauseBtn);
            this.panel1.Controls.Add(this.playBtn);
            this.panel1.Location = new System.Drawing.Point(12, 263);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(553, 42);
            this.panel1.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(99, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 24);
            this.label2.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "正在播放:";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(204, 215);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 14;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 317);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.Text = "歌曲管理系統";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 新增歌曲ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查詢包廂狀態ToolStripMenuItem;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button skipBtn;
        private System.Windows.Forms.Button playBtn;
        private System.Windows.Forms.ToolStripMenuItem 新增歌曲ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 輸入密碼ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 刪除歌曲ToolStripMenuItem1;
        private System.Windows.Forms.Button pauseBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
    }
}

