using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TugasAsdos
{
    public partial class Form8 : Form
    {
        private NpgsqlConnection connection;
        private string connString = "Server=localhost;Port=5432;User Id=postgres;Password=Ilmiana15!;Database=Asdos;";

        public Form8()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            NpgsqlConnection connection = new NpgsqlConnection(connString);
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand("INSERT INTO transaksi(nama, alamat, tgl, namalaptop, jml) " +
                "VALUES (@value1, @value2, @value3, @value4, @value5)", connection);
            command.Parameters.AddWithValue("value1", textBox1.Text);
            command.Parameters.AddWithValue("value2", textBox2.Text);
            command.Parameters.AddWithValue("value3", textBox3.Text);
            command.Parameters.AddWithValue("value4", textBox4.Text);
            command.Parameters.AddWithValue("value5", textBox5.Text);

            command.ExecuteNonQuery();
            connection.Close();

            MessageBox.Show("Success Insert Transaction");
            label7.Visible = true;
            label7.Text =
            label7.Text = "=== TRANSAKSI YANG BERLANGSUNG === " + "\n" + "Nama                  : " + textBox1.Text + "\n Alamat               : " + textBox2.Text + "\n Tanggal transaksi       :" + textBox3.Text + "\n Nama Laptop          :" + textBox4.Text + "\n Jumlah Laptop          :" + textBox5.Text;
        }
    }
}
