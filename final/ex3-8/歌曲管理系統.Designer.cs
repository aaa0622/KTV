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
            this.刪除歌曲ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button4 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.新增歌曲ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.輸入密碼ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.刪除歌曲ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.包廂管理系統ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(52, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 66);
            this.button1.TabIndex = 0;
            this.button1.Text = "查詢歌曲";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(221, 44);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 66);
            this.button2.TabIndex = 1;
            this.button2.Text = "熱門歌曲";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(52, 126);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 65);
            this.button3.TabIndex = 2;
            this.button3.Text = "新歌爆爆";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新增歌曲ToolStripMenuItem,
            this.刪除歌曲ToolStripMenuItem});
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
            this.刪除歌曲ToolStripMenuItem1,
            this.包廂管理系統ToolStripMenuItem});
            this.新增歌曲ToolStripMenuItem.Name = "新增歌曲ToolStripMenuItem";
            this.新增歌曲ToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.新增歌曲ToolStripMenuItem.Text = "服務人員系統";
            // 
            // 刪除歌曲ToolStripMenuItem
            // 
            this.刪除歌曲ToolStripMenuItem.Name = "刪除歌曲ToolStripMenuItem";
            this.刪除歌曲ToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.刪除歌曲ToolStripMenuItem.Text = "查詢包廂狀態";
            this.刪除歌曲ToolStripMenuItem.Click += new System.EventHandler(this.刪除歌曲ToolStripMenuItem_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(221, 126);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(99, 65);
            this.button4.TabIndex = 4;
            this.button4.Text = "歌星推薦";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("新細明體", 15F);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Items.AddRange(new object[] {
            "告白氣球",
            "喵電感應",
            "觸電"});
            this.listBox1.Location = new System.Drawing.Point(392, 42);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 164);
            this.listBox1.TabIndex = 5;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(221, 212);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(100, 65);
            this.button7.TabIndex = 8;
            this.button7.Text = "清空待播清單";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(52, 212);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 65);
            this.button5.TabIndex = 9;
            this.button5.Text = "切歌";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(402, 212);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(100, 65);
            this.button6.TabIndex = 10;
            this.button6.Text = "播放/暫停";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // 新增歌曲ToolStripMenuItem1
            // 
            this.新增歌曲ToolStripMenuItem1.Name = "新增歌曲ToolStripMenuItem1";
            this.新增歌曲ToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.新增歌曲ToolStripMenuItem1.Text = "新增歌曲";
            // 
            // 輸入密碼ToolStripMenuItem
            // 
            this.輸入密碼ToolStripMenuItem.Name = "輸入密碼ToolStripMenuItem";
            this.輸入密碼ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.輸入密碼ToolStripMenuItem.Text = "輸入密碼";
            // 
            // 刪除歌曲ToolStripMenuItem1
            // 
            this.刪除歌曲ToolStripMenuItem1.Name = "刪除歌曲ToolStripMenuItem1";
            this.刪除歌曲ToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.刪除歌曲ToolStripMenuItem1.Text = "刪除歌曲";
            // 
            // 包廂管理系統ToolStripMenuItem
            // 
            this.包廂管理系統ToolStripMenuItem.Name = "包廂管理系統ToolStripMenuItem";
            this.包廂管理系統ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.包廂管理系統ToolStripMenuItem.Text = "包廂管理系統";
            // 
            // 歌曲管理系統
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 317);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "歌曲管理系統";
            this.Text = "歌曲管理系統";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 新增歌曲ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 刪除歌曲ToolStripMenuItem;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ToolStripMenuItem 新增歌曲ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 輸入密碼ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 刪除歌曲ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 包廂管理系統ToolStripMenuItem;
    }
}

