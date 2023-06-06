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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TugasAsdos
{
    public partial class Form3 : Form
    {
        private NpgsqlConnection connection;
        private string connString = "Server=localhost;Port=5432;User Id=postgres;Password=Ilmiana15!;Database=Asdos;";
        private NpgsqlDataAdapter Adapter;
        private DataTable dt;
        public Form3()
        {
            InitializeComponent();
            connection = new NpgsqlConnection(connString);
            dt = new DataTable();
            Adapter = new NpgsqlDataAdapter("SELECT nomor, nama_barang as nama, harga, stok FROM laptop ORDER BY nomor", connection);
            connection.Open();
            Adapter.Fill(dt);
            connection.Close();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = dt;
        }
        private void Editdata()
        {
            NpgsqlConnection connection = new NpgsqlConnection(connString);
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand("UPDATE laptop SET Nama_Barang = @value2, harga = @value3, " +
                "stok = @value4 WHERE nomor = @value1", connection);
            command.Parameters.AddWithValue("value1", Convert.ToInt32(this.textBox1.Text));
            command.Parameters.AddWithValue("value2", textBox2.Text);
            command.Parameters.AddWithValue("value3", textBox3.Text);
            command.Parameters.AddWithValue("value4", textBox4.Text);
            command.ExecuteNonQuery();
            connection.Close();

            connection = new NpgsqlConnection(connString);
            dt = new DataTable();
            Adapter = new NpgsqlDataAdapter("SELECT nomor, nama_barang as nama, harga, stok FROM laptop ORDER BY nomor", connection);
            connection.Open();
            Adapter.Fill(dt);
            connection.Close();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = dt;
            MessageBox.Show("Success update data");
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Editdata();
            textBox1.Text = " ";
            textBox2.Text = " ";
            textBox3.Text = " ";
            textBox4.Text = " ";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            textBox2.Text = " ";
            textBox3.Text = " ";
            textBox4.Text = " ";
        }
    }
}
