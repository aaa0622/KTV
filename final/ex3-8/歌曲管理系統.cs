using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;

namespace ex3_8
{
    public partial class Menu : Form
    {
        private Screen screen;
        private Sql sql;
        private string boxNum;
        public DataTable dt;
        public DataTable dtall;

        public string currentPlayName;
        public Menu()
        {
            InitializeComponent();
            boxNum = "001";
            sql = new Sql();
            dtall = new DataTable();
            screen = new Screen();
            screen.Show();
            MethodInvoker miUpdateDt = new MethodInvoker(updateDt);
            MethodInvoker miSetCurrentPlayName = new MethodInvoker(setCurrentPlayName);
            //screen.browser.JavascriptObjectRepository.Register("playerCallback", new PlayerCallback(this, miUpdateDt, miSetCurrentPlayName), true);
            //dtd.RowChanged += new DataRowChangeEventHandler(asd);
            //dtd.Columns.Add("name");
            //dtd.Columns.Add("id");
            //dtd.Columns.Add("singer");
            //dtall.RowChanged += new DataRowChangeEventHandler(asd);
            dtall.Columns.Add("name");
            dtall.Columns.Add("id");
            dtall.Columns.Add("singer");
            listBox1.DataSource = dt;
            listBox1.DisplayMember = "name";



            
            dt = new DataTable();
            screen.browser.JavascriptObjectRepository.Register("playerCallback", new PlayerCallback(this, miUpdateDt, miSetCurrentPlayName), true);
            dt.RowChanged += new DataRowChangeEventHandler(asd);
            dt.Columns.Add("name");
            dt.Columns.Add("id");
            listBox1.DataSource = dt;
            listBox1.DisplayMember = "name";

        }
        
        private void asd(object sender, DataRowChangeEventArgs e)
        {
            if (e.Action == DataRowAction.Add && screen.browser.CanExecuteJavascriptInMainFrame)
                screen.browser.ExecuteScriptAsync("addNewVideo()");
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            DataRow dr1 = dtall.NewRow();
            dr1["name"] = "全放空";
            dr1["singer"] = "文慧如";
            dr1["id"] = "MJnzEa0FSKk";
            dtall.Rows.Add(dr1);
            /*DataRow dr2 = dtall.NewRow();
            dr2["name"] = "少年";
            dr2["singer"] = "夢然";
            dr2["id"] = "MYviK2-Mk-8";
            dtall.Rows.Add(dr2);*/
            DataRow dr3 = dtall.NewRow();
            dr3["name"] = "晚安";
            dr3["singer"] = "顏人中";
            dr3["id"] = "FcyP7sIeWaE";
            dtall.Rows.Add(dr3);
            DataRow dr4 = dtall.NewRow();
            dr4["name"] = "我很快樂";
            dr4["singer"] = "周興哲";
            dr4["id"] = "Ezd_DLawfHI";
            dtall.Rows.Add(dr4);
            DataRow dr5 = dtall.NewRow();
            dr5["name"] = "最後我們沒在一起";
            dr5["singer"] = "白小白";
            dr5["id"] = "nFAvalt2lsA";
            dtall.Rows.Add(dr5);
            DataRow dr6 = dtall.NewRow();
            dr6["name"] = "世間美好與你環環相扣";
            dr6["singer"] = "柏松";
            dr6["id"] = "Kca3ndEpG0s";
            dtall.Rows.Add(dr6);
            DataRow dr7 = dtall.NewRow();
            dr7["name"] = "懸日";
            dr7["singer"] = "田馥甄";
            dr7["id"] = "Nf1C1fSJG_8";
            dtall.Rows.Add(dr7);
            DataRow dr8 = dtall.NewRow();
            dr8["name"] = "80000(想你想你想我)";
            dr8["singer"] = "PRC巴音汗";
            dr8["id"] = "osD5siLanLU";
            dtall.Rows.Add(dr8);
            DataRow dr9 = dtall.NewRow();
            dr9["name"] = "山楂樹之戀";
            dr9["singer"] = "程佳佳";
            dr9["id"] = "IFMcyb4yxBc";
            dtall.Rows.Add(dr9);
            DataRow dr10 = dtall.NewRow();
            dr10["name"] = "這一生關於你的風景";
            dr10["singer"] = "隔壁老樊";
            dr10["id"] = "6NydAkAavMM";
            dtall.Rows.Add(dr10);
            DataRow dr11 = dtall.NewRow();
            dr11["name"] = "我是真的愛過你";
            dr11["singer"] = "劉增瞳";
            dr11["id"] = "hWwhuvlMhmI";
            dtall.Rows.Add(dr11);
            updateDtall();

        }
        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (sender.ToString().GetHashCode() == 1793703675) // 123456
            {
                新增歌曲ToolStripMenuItem1.Enabled = true;
                刪除歌曲ToolStripMenuItem1.Enabled = true;
                包廂管理系統ToolStripMenuItem.Enabled = true;
            }
        }
        private void 查詢包廂狀態ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            查詢包廂狀態 box = new 查詢包廂狀態(ref sql, boxNum);
            box.Show();
        }
        

        private void nextBtn_Click(object sender, EventArgs e)
        {
            screen.browser.ExecuteScriptAsync("getNextVideo()");
        }

        private void pauseBtn_Click(object sender, EventArgs e)
        {
            screen.browser.ExecuteScriptAsync("player.pauseVideo()");
        }

        private void playBtn_Click(object sender, EventArgs e)
        {
            screen.browser.ExecuteScriptAsync("player.playVideo()");
        }
        
        public void setCurrentPlayName()
        {
            label2.Text = currentPlayName;
        }
        public void updateDt()
        {
            dt.AcceptChanges();
        }

        public void updateDtall()
        {
            dtall.AcceptChanges();
        }
        private void clearBtn_Click(object sender, EventArgs e)
        {
            dt.Rows.Clear();
            dt.AcceptChanges();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            /*
            DataRow dr1 = dtall.NewRow();
            dr1["name"] = "全放空";
            dr1["singer"] = "文慧如";
            dr1["id"] = "MJnzEa0FSKk";
            dtall.Rows.Add(dr1);
            DataRow dr2 = dtall.NewRow();
            dr2["name"] = "少年";
            dr2["singer"] = "夢然";
            dr2["id"] = "LGzDEu7Sh5g";
            dtall.Rows.Add(dr2);
            DataRow dr3 = dtall.NewRow();
            dr3["name"] = "晚安";
            dr3["singer"] = "顏人中";
            dr3["id"] = "FcyP7sIeWaE";
            dtall.Rows.Add(dr3);
            DataRow dr4 = dtall.NewRow();
            dr4["name"] = "我很快樂";
            dr4["singer"] = "周興哲";
            dr4["id"] = "Ezd_DLawfHI";
            dtall.Rows.Add(dr4);
            DataRow dr5 = dtall.NewRow();
            dr5["name"] = "最後我們沒在一起";
            dr5["singer"] = "白小白";
            dr5["id"] = "nFAvalt2lsA";
            dtall.Rows.Add(dr5);
            DataRow dr6 = dtall.NewRow();
            dr6["name"] = "世間美好與你環環相扣";
            dr6["singer"] = "柏松";
            dr6["id"] = "Kca3ndEpG0s";
            dtall.Rows.Add(dr6);
            DataRow dr7 = dtall.NewRow();
            dr7["name"] = "懸日";
            dr7["singer"] = "田馥甄";
            dr7["id"] = "Nf1C1fSJG_8";
            dtall.Rows.Add(dr7);
            DataRow dr8 = dtall.NewRow();
            dr8["name"] = "80000(想你想你想我)";
            dr8["singer"] = "PRC巴音汗";
            dr8["id"] = "osD5siLanLU";
            dtall.Rows.Add(dr8);
            DataRow dr9 = dtall.NewRow();
            dr9["name"] = "山楂樹之戀";
            dr9["singer"] = "程佳佳";
            dr9["id"] = "IFMcyb4yxBc";
            dtall.Rows.Add(dr9);
            DataRow dr10 = dtall.NewRow();
            dr10["name"] = "這一生關於你的風景";
            dr10["singer"] = "隔壁老樊";
            dr10["id"] = "6NydAkAavMM";
            dtall.Rows.Add(dr10);
            DataRow dr11 = dtall.NewRow();
            dr11["name"] = "我是真的愛過你";
            dr11["singer"] = "劉增瞳";
            dr11["id"] = "hWwhuvlMhmI";
            dtall.Rows.Add(dr11);
            updateDtall();

            return;

            */
        }

        private void 新增歌曲ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //listBox2.Visible = true;
            button6.Text = "確認新增";
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            button6.Visible = true;
            button8.Visible = true;
            listBox2.Visible = true;
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //新增
            if (button6.Text == "確認新增")
            {
                DataRow dr1 = dtall.NewRow();

                dr1["name"] = textBox1.Text;
                dr1["id"] = textBox2.Text;
                dr1["singer"] = textBox3.Text;
                dtall.Rows.Add(dr1);
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
            }
            //刪除
            if (button6.Text == "確認刪除")
            {
                for (int i = 0; i < dtall.Rows.Count; i++)
                {
                    if (dtall.Rows[i]["name"].ToString() == textBox1.Text && dtall.Rows[i]["id"].ToString() == textBox2.Text && dtall.Rows[i]["singer"].ToString() == textBox3.Text)//查詢條件
                    {
                        dtall.Rows[i].Delete();
                    }
                }
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
            }
            //查詢歌曲
            if(button6.Text=="查詢歌曲")
            {
                button6.Text = "確認點播";
                for (int i = 0; i < dtall.Rows.Count; i++)
                {
                    if (dtall.Rows[i]["name"].ToString() == textBox1.Text || dtall.Rows[i]["id"].ToString() == textBox2.Text || dtall.Rows[i]["singer"].ToString() == textBox3.Text)//查詢條件
                    {
                        comboBox1.Items.Add(dtall.Rows[i]["name"]+"-"+ dtall.Rows[i]["singer"]);
                    }
                }
                listBox2.Visible = false;
                listBox3.Visible = true;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                label6.Visible = true;
                textBox1.Visible = false;
                textBox2.Visible = false;
                textBox3.Visible = false;
                comboBox1.Visible = true;
                comboBox1.BringToFront();
                label6.BringToFront();

            }
            //點歌
            else if(button6.Text=="確認點播")
            {
                listBox2.Visible = false;
                listBox3.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                textBox1.Visible = false;
                textBox2.Visible = false;
                textBox3.Visible = false;
                button6.Visible = false;
                button8.Visible = false;
                comboBox1.Visible = false;
                string[] addsong = comboBox1.Text.Split('-');
                DataRow dr1 = dt.NewRow();
                for (int i = 0; i < dtall.Rows.Count; i++)
                {
                    if (dtall.Rows[i]["name"].ToString() == addsong[0] && dtall.Rows[i]["singer"].ToString() == addsong[1])//查詢條件
                    {
                        dr1["name"] = dtall.Rows[i]["name"];
                        dr1["id"] = dtall.Rows[i]["id"];
                        break;
                    }
                }
                
                dt.Rows.Add(dr1);
                comboBox1.Items.Clear();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            listBox2.Visible = false;
            listBox3.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            button6.Visible = false;
            button8.Visible = false;
            comboBox1.Visible = false;
            comboBox1.Items.Clear();
        }

        private void 刪除歌曲ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            button6.Text = "確認刪除";
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            button6.Visible = true;
            button8.Visible = true;
            listBox2.Visible = true;
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button6.Text = "查詢歌曲";
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            button6.Visible = true;
            button8.Visible = true;
            listBox2.Visible = true;
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //新歌爆爆
            label6.Text = "新歌爆爆";
            button6.Text = "確認點播";
            button6.Visible = true;
            button8.Visible = true;
            listBox3.Visible = true;
            label6.Visible = true;
            comboBox1.Visible = true;
            comboBox1.BringToFront();
            label6.BringToFront();
            //comboBox1.Items.Add("少年-夢然");
            comboBox1.Items.Add("晚安-顏人中");
            comboBox1.Items.Add("我很快樂-周興哲");
            comboBox1.Items.Add("最後我們沒在一起-白小白");
            comboBox1.Items.Add("世間美好與你環環相扣-柏松");
            comboBox1.Items.Add("懸日-田馥甄");
            comboBox1.Items.Add("80000(想你想你想我)-PRC巴音汗");
            comboBox1.Items.Add("山楂樹之戀-程佳佳");
            comboBox1.Items.Add("這一生關於你的風景-隔壁老樊");
            comboBox1.Items.Add("我是真的愛過你-劉增瞳");
        }
    }
    public class PlayerCallback
    {
        Menu menu;
        MethodInvoker miUpdateDt;
        MethodInvoker miSetCurrentPlayName;
        public PlayerCallback(Menu m, MethodInvoker miUpdateDt, MethodInvoker miSetCurrentPlayName)
        {
            menu = m;
            this.miUpdateDt = miUpdateDt;
            this.miSetCurrentPlayName = miSetCurrentPlayName;
        }
        public void GetNextVideo(IJavascriptCallback Success, IJavascriptCallback Error)
        {
            if (menu.dt.Rows.Count != 0)
            {
                Success.ExecuteAsync(menu.dt.Rows[0]["id"], menu.dt.Rows[0]["name"]);

                menu.dt.Rows[0].Delete();
                menu.BeginInvoke(miUpdateDt);
            }
            else
            {
                Error.ExecuteAsync();
            }
        }
        public void SetCurrentPlayName(string name)
        {
            menu.currentPlayName = name;
            menu.BeginInvoke(miSetCurrentPlayName);
        }
    }
}
