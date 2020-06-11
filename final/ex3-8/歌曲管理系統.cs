using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        public DataTable dt;
        public string currentPlayName;

        public Menu()
        {
            InitializeComponent();
            dt = new DataTable();
            screen = new Screen();
            screen.Show();
            MethodInvoker miUpdateDt = new MethodInvoker(updateDt);
            MethodInvoker miSetCurrentPlayName = new MethodInvoker(setCurrentPlayName);
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
