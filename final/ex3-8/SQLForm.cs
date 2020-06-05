using System;
using System.Data;
using System.Windows.Forms;

namespace ex3_8
{
    public partial class SQLForm : Form
    {
        private Sql sql;
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
            dataGridView1.DataSource = sql.query("select * from Test");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //sql.exec("select * from Test");
            sql.testModifyDt((DataTable)dataGridView1.DataSource);
        }
    }
}
