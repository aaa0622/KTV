﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex3_8
{
    public partial class 查詢包廂狀態 : Form
    {
        private Sql sql;
        public 查詢包廂狀態()
        {
            InitializeComponent();
            sql = new Sql();

            DataTable table = sql.query("update Box_Data SET 包廂狀態 = '2'  where unix_timestamp(離場時間) < unix_timestamp(sysdate()); select * from Box_Data where 包廂編號 = '001'");
            dataGridView1.DataSource = table;
            label5.Text = table.Rows[0][0].ToString();
            label6.Text = table.Rows[0][1].ToString();
            label7.Text = table.Rows[0][4].ToString();
            label8.Text = table.Rows[0][6].ToString() + "小時";
            label10.Text = table.Rows[0][5].ToString();
        }

        private void addTime(object sender, EventArgs e)
        {
            int count = sql.exec("update Box_Data set 是否加時 = true where 包廂編號 = '001'");
            if (count > 0)
            {
                string message = "已通知服務人員";
                string caption = "加時";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;

                // Displays the MessageBox.
                result = MessageBox.Show(message, caption, buttons);
            }
            else
            {
                string message = "加時失敗";
                string caption = "加時";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;

                // Displays the MessageBox.
                result = MessageBox.Show(message, caption, buttons);
            }
        }
    }
}
