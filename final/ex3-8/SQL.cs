using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace ex3_8
{
    public class Sql
    {
        
        private MySqlConnection conn;

        public Sql()
        {
            string connectionString = "server=qf5dic2wzyjf1x5x.cbetxkdyhwsb.us-east-1.rds.amazonaws.com;port=3306;user=hyd7ksnut6l7zu0x;password=p687r5v5xnk9enjb; database=m2mqm08xoxfdrvky;";
            conn = new MySqlConnection(connectionString);
            conn.Open();
        }
        public DataTable query(string sql)
        {
            DataTable dt = new DataTable();
            MySqlTransaction transaction = null;
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                transaction = conn.BeginTransaction();

                Console.WriteLine("已經建立連線");
                //在這裡使用程式碼對資料庫進行增刪查改
                
                MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);

                adapter.Fill(dt);
                
                return dt;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                transaction.Rollback();
                conn.Close();
            }
            finally
            {
                if (conn.State != ConnectionState.Closed)
                {
                    transaction.Commit();
                }
            }
            return dt;
        }
      
        public int exec(string sql)
        {
            int result = -1;
            MySqlTransaction transaction = null;

            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                transaction = conn.BeginTransaction();

                Console.WriteLine("已經建立連線");

                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    result = cmd.ExecuteNonQuery();
                }

                Console.WriteLine(result);
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                transaction.Rollback();
                conn.Close();
            }
            finally
            {
                if (conn.State != ConnectionState.Closed)
                {
                    transaction.Commit();
                }
            }


            return result; // return 受影響資料筆數
        }
        public void btnCreateTB()
        {
            return;
            string createStatement = "CREATE TABLE Test (Field1 VarChar(50), Field2 Integer)";
            string alterStatement = "ALTER TABLE Test ADD Field3 Boolean";

            conn.Open();

            // 建表  
            using (MySqlCommand cmd = new MySqlCommand(createStatement, conn))
            {
                cmd.ExecuteNonQuery();
            }

            // 改表或者增加行  
            using (MySqlCommand cmd = new MySqlCommand(alterStatement, conn))
            {
                cmd.ExecuteNonQuery();
            }
        }
        public void modifyDt()
        {
            DataTable dt = new DataTable("table");
            DataColumn colItem = new DataColumn("item", Type.GetType("System.String"));
            dt.Columns.Add(colItem);

            // Add five items.
            DataRow NewRow;
            for (int i = 0; i < 5; i++)
            {
                NewRow = dt.NewRow();
                NewRow["item"] = "Item " + i;
                dt.Rows.Add(NewRow);
            }

            // Change the values in the table.
            dt.Rows[0]["item"] = "cat";
            dt.Rows[1]["item"] = "dog";
            dt.AcceptChanges();
        }
        public void testModifyDt(DataTable dt)
        {
            // Change the values in the table.
            dt.Rows[0]["Field1"] = "cat";
            dt.AcceptChanges();
        }
    }
}
