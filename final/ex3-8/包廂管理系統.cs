using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex3_8
{
    
    public partial class BoxMenu : Form
    {
        private Sql sql;
        public BoxMenu()
        {
            InitializeComponent();

            sql = new Sql();
            //.btnCreateTB();
            dataGridView1.DataSource = sql.query("update Box_Data SET 包廂狀態 = '2'  where unix_timestamp(離場時間) < unix_timestamp(sysdate()); select * from Box_Data");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataTable box = checkBoxStatus();
            if (box.Rows.Count > 0)
            {
                textBox9.Text = box.Rows[0][0].ToString();
                textBox9.ReadOnly = true;
                textBox8.Text = box.Rows[0][1].ToString();
                textBox7.Text = box.Rows[0][4].ToString();
                textBox7.ReadOnly = true;
                textBox6.Text = box.Rows[0][6].ToString();
                //dataGridView1.DataSource = box;
            }
            else
            {
                string message = "查無該包廂 或是 該包廂目前狀態無法修改";
                string caption = "查詢包廂狀態";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;

                // Displays the MessageBox.
                result = MessageBox.Show(message, caption, buttons);
            }

        }

        private DataTable checkBoxStatus() // 查詢包廂狀態
        {
            DataTable box = sql.query("update Box_Data SET 包廂狀態 = '2'  where unix_timestamp(離場時間) < unix_timestamp(sysdate()); select * from Box_Data where 包廂編號 = '" + textBox5.Text + "' and 包廂狀態 = '1'");
            return box;

        }
        private void checkBox(object sender, EventArgs e) // 檢查是否有空包廂
        {
            dataGridView2.DataSource = sql.query("update Box_Data SET 包廂狀態 = '2'  where unix_timestamp(離場時間) < unix_timestamp(sysdate()); select 包廂編號 from Box_Data where 包廂類型 = '" + textBox2.Text + "' and 包廂狀態 = '2'");
            dataGridView2.Columns["包廂編號"].ReadOnly = true;
        }

        private void dataGridView2_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            button1.Text = dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            
            string message = "是否確定預約該包廂";
            string caption = "預約包廂";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            // Displays the MessageBox.
            result = MessageBox.Show(message, caption, buttons);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || !reservationBox(e))
                {
                    string message2 = "資料不全，預約失敗";
                    string caption2 = "預約包廂";
                    MessageBoxButtons buttons2 = MessageBoxButtons.OK;
                    DialogResult result2;

                    // Displays the MessageBox.
                    result2 = MessageBox.Show(message2, caption2, buttons2);
                }
                else
                {
                    string message2 = "預約成功";
                    string caption2 = "預約包廂";
                    MessageBoxButtons buttons2 = MessageBoxButtons.OK;
                    DialogResult result2;

                    // Displays the MessageBox.
                    result2 = MessageBox.Show(message2, caption2, buttons2);
                }
            }
        }
        private bool reservationBox(DataGridViewCellEventArgs e) // 預約包廂功能
        {
            int count = sql.exec("update Box_Data SET 包廂狀態 = '1' , 包廂人數 = '" + textBox1.Text + "', 入場時間 = '" + textBox3.Text + "', 離場時間 = DATE_ADD('" + textBox3.Text + "',INTERVAL " + textBox4.Text + " HOUR)  where 包廂編號 = " + dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
            if (count > 0)
                return true;
            else
                return false;
        }

        private void modifyBoxStatus(object sender, EventArgs e)
        {
            sql.exec("update Box_Data SET  包廂人數 = '" + textBox8.Text + "', 時數 = '" + textBox6.Text + "' where 包廂編號 = '" + textBox9.Text + "'");
            string message = "修改成功";
            string caption = "修改包廂狀態";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result;

            // Displays the MessageBox.
            result = MessageBox.Show(message, caption, buttons);
        }
    }
}
