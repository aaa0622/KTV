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
        public string currentPlayName;

        public Menu()
        {
            InitializeComponent();
            boxNum = "001";
            sql = new Sql();
            dt = new DataTable();
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
            screen = new Screen();
            screen.Show();
            MethodInvoker miUpdateDt = new MethodInvoker(updateDt);
            MethodInvoker miSetCurrentPlayName = new MethodInvoker(setCurrentPlayName);
            screen.browser.JavascriptObjectRepository.Register("playerCallback", new PlayerCallback(this, miUpdateDt, miSetCurrentPlayName), true);
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

        private void clearBtn_Click(object sender, EventArgs e)
        {
            dt.Rows.Clear();
            dt.AcceptChanges();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            DataRow dr1 = dt.NewRow();
            dr1["name"] = "全放空";
            dr1["id"] = "MJnzEa0FSKk";

            dt.Rows.Add(dr1);
            return;
            DataRow dr2 = dt.NewRow();
            dr2["name"] = "說好不哭";
            dr2["id"] = "HK7SPnGSxLM";
            DataRow dr3 = dt.NewRow();
            dr3["name"] = "等你下課";
            dr3["id"] = "QQucPUfXUQQ";
            dt.Rows.Add(dr2);
            dt.Rows.Add(dr3);
        }

        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            if(sender.ToString().GetHashCode() == 1793703675) // 123456
            {
                新增歌曲ToolStripMenuItem1.Enabled = true;
                刪除歌曲ToolStripMenuItem1.Enabled = true;
                包廂管理系統ToolStripMenuItem.Enabled = true;
            }
        }

        private void 新增歌曲ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DataTable newSongDt = OpenCSV("C:/newSong.csv");
            return;
            Sql sql = new Sql();
            sql.exec("");
        }

        private void 刪除歌曲ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DataTable delSongDt = OpenCSV("C:/delSong.csv");
            return;
            Sql sql = new Sql();
            sql.exec("");
        }
        private void 查詢包廂狀態ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            查詢包廂狀態 box = new 查詢包廂狀態(ref sql, boxNum);
            box.Show();
        }

        /// <summary>
        /// 將CSV文件的數據讀取到DataTable中
        /// http://altoncsharp.blogspot.com/2016/11/ccsv.html
        /// </summary>
        /// <param name="fileName">CSV文件路徑</param>
        /// <returns>返回讀取了CSV數據的DataTable</returns>
        public static DataTable OpenCSV(string filePath)
        {
            DataTable dt = new DataTable();
            FileStream fs = null;
            StreamReader sr = null;
            try
            {
                fs = new FileStream(filePath, System.IO.FileMode.Open, System.IO.FileAccess.Read);
                sr = new StreamReader(fs, Encoding.UTF8);
                //記錄每次讀取的一行記錄
                string strLine = "";
                //記錄每行記錄中的各字段內容
                string[] aryLine = null;
                string[] tableHead = null;
                //標示列數
                int columnCount = 0;
                //標示是否是讀取的第一行
                bool IsFirst = true;
                //逐行讀取CSV中的數據
                while ((strLine = sr.ReadLine()) != null)
                {
                    if (IsFirst == true)
                    {
                        tableHead = strLine.Split(',');
                        IsFirst = false;
                        columnCount = tableHead.Length;
                        //創建列
                        for (int i = 0; i < columnCount; i++)
                        {
                            tableHead[i] = tableHead[i].Replace("\"", "");
                            DataColumn dc = new DataColumn(tableHead[i]);
                            dt.Columns.Add(dc);
                        }
                    }
                    else
                    {
                        aryLine = strLine.Split(',');
                        DataRow dr = dt.NewRow();
                        for (int j = 0; j < columnCount; j++)
                        {
                            dr[j] = aryLine[j].Replace("\"", "");
                        }
                        dt.Rows.Add(dr);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                if(sr != null)
                    sr.Close();
                if(fs != null)
                    fs.Close();
            }
            return dt;
        }

        private void 包廂管理系統ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BoxMenu box = new BoxMenu();
            box.Show();
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
