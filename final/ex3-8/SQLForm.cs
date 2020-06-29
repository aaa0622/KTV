using System;
using System.Data;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;

namespace ex3_8
{
    public partial class SQLForm : Form
    {
        private Sql sql;
        private Screen s;
        public SQLForm()
        {
            InitializeComponent();

            sql = new Sql();
        }

        private void SQLForm_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = sql.exec("update Box_Data SET 包廂狀態 = '1' , 包廂人數 = '1', 入場時間 = '2020/6/10 14:10', 離場時間 = DATE_ADD('2020/6/10 14:10',INTERVAL 1 HOUR)  where 包廂編號 = '003'");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //sql.exec("select * from Test");
            sql.testModifyDt((DataTable)dataGridView1.DataSource);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            s = new Screen();

            // Show the settings form
            s.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            s.browser.ExecuteScriptAsync("player.playVideo()");
        }
    }
}
