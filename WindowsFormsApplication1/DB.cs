using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.SQLite;
using System.Data.SqlTypes;
using System.Data;
using System.Collections;


namespace WindowsFormsApplication1
{
    class DB
    {
        public static string dbName = string.Empty;
        public static string dbConnStr = string.Empty;


        public static System.Text.Encoding encDefalut = System.Text.Encoding.Default;

        private static void SQL(string str)
        {
            dbConnStr = "Data source=duke.db";

            System.Data.Common.DbConnection conn;
            System.Data.Common.DbCommand cmd;
            System.Data.Common.DbTransaction transaction;


            conn = new SQLiteConnection(dbConnStr);
            cmd = conn.CreateCommand();
            cmd.CommandText = str;


            conn.Open();
            transaction = conn.BeginTransaction();

            try
            {
                cmd.ExecuteNonQuery();
                transaction.Commit();
            }
            catch
            {
                transaction.Rollback();
            }
            finally
            {
                transaction.Dispose();
                transaction = null;
                conn.Close();
                conn.Dispose();
            }
        }  //執行SQL的 Delete 、Update、Insert

        private static DataTable SQL_QUERY(string sql)
        {
            System.Data.Common.DbConnection conn;
            System.Data.Common.DbDataAdapter adap;
            System.Data.Common.DbTransaction transaction;
            System.Data.DataTable dt = null;

            conn = new SQLiteConnection(dbConnStr);
            adap = new SQLiteDataAdapter();
            adap.SelectCommand = conn.CreateCommand();
            adap.SelectCommand.CommandText = sql;

            conn.Open();
            transaction = conn.BeginTransaction();
            try
            {
                dt = new DataTable();
                adap.Fill(dt);
                transaction.Commit();
            }
            catch
            {
                transaction.Rollback();
            }
            finally
            {
                transaction.Dispose();
                transaction = null;
                conn.Close();
                conn.Dispose();
            }
            return dt;
        }    //執行SQL的 Select

        public static void CreateDb()
        {

            if (!File.Exists(Application.StartupPath + @"\duke.db"))
            {
                string sql = @"CREATE TABLE custom (Name nvarchar(10), Phone nvarchar(20))";

                SQL(sql);
            }
        }   //建立一個新的sql資料庫

        public static void WriteData(string name, string phone)  
        {

            SQL("insert into custom Values(" + "'" + name + "'," + "'" + phone + "')");

        }

        public static void DeleteData(string name)
        {
            SQL("delete from custom where Name ='" + name + "'");

        }

        public static void DataUpdate(string search_name, string name, string phone)
        {

            SQL("update custom set Name  = '" + name + "', Phone = '" + phone + "' where Name ='" + search_name + "'");

        }

    }
}
