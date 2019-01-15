using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.SQLite;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private SQLiteConnection conn;
        private SQLiteCommand coma;


        public Form1()
        {
            InitializeComponent();
        }

        private void btnwrite_Click(object sender, EventArgs e)
        {
            DB.CreateDb();

            string name = txtname.Text;
            string telephone = txttel.Text;

            DB.WriteData(name, telephone);
      
            MessageBox.Show("successful ! ");

            txtname.Text = "";
            txttel.Text = "";

        }

        private void btnquery_Click(object sender, EventArgs e)
        {
            conn = new SQLiteConnection("Data source=duke.db");
            conn.Open();

            coma = conn.CreateCommand();

            coma.CommandText = " SELECT * FROM custom";//select table

            SQLiteDataReader sqlQuery = coma.ExecuteReader();

            while (sqlQuery.Read())
            {
                string nameload = sqlQuery["Name"].ToString();
                string phoneload = sqlQuery["Phone"].ToString();

                MessageBox.Show(nameload + " :" + phoneload);
            }

            conn.Close();
            conn.Dispose();

        }

        private void btncheckstore_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.ShowDialog();
        }


    }
}
