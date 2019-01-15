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
    public partial class Form2 : Form
    {
     
        DataTable dt = new DataTable();

        public Form2()
        {
            InitializeComponent();
        }

        public void openDb()
        {
            SQLiteConnection conn;
            SQLiteCommand coma;

            conn = new SQLiteConnection("Data source=duke.db");
            conn.Open();

            SQLiteDataAdapter adap = new SQLiteDataAdapter();

            coma = conn.CreateCommand();

            coma.CommandText = " SELECT * FROM custom";//select table

            adap.SelectCommand = coma;

            adap.Fill(dt);

            conn.Close();
            conn.Dispose();

        }

        private void btnViewdata_Click(object sender, EventArgs e)
        {
            openDb();
            dataGridView1.DataSource = dt;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e) 
        {
            openDb();

            DataRow[] dr = dt.Select(" Name ='" + txtsearch.Text + "'");

            foreach (DataRow row in dr)
            {
                textBox1.Text = row[0].ToString();
                textBox2.Text = row[1].ToString();
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string name = txtsearch.Text;

            DB.DeleteData(name);

            MessageBox.Show("delete successful");

            txtsearch.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DB.DataUpdate(txtsearch.Text, textBox1.Text, textBox2.Text);

            MessageBox.Show("update successful");

            txtsearch.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
        }

      
    }
}
