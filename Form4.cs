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
    public partial class Form4 : Form
    {
        private NpgsqlConnection connection;
        private string connString = "Server=localhost;Port=5432;User Id=postgres;Password=Ilmiana15!;Database=Asdos;";
        private NpgsqlDataAdapter Adapter;
        private DataTable dt;
        public Form4()
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

        private void Deletedata()
        {
            NpgsqlConnection connection = new NpgsqlConnection(connString);
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand("DELETE FROM laptop WHERE nomor=@value1", connection);
            command.Parameters.AddWithValue("value1", Convert.ToInt32(this.textBox1.Text));
            command.ExecuteNonQuery();
            connection.Close();

            connection = new NpgsqlConnection(connString);
            dt = new DataTable();
            Adapter = new NpgsqlDataAdapter("SELECT nomor, nama_barang as nama, harga, stok FROM laptop", connection);
            connection.Open();
            Adapter.Fill(dt);
            connection.Close();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = dt;
            MessageBox.Show("Success delete data");
            this.Close();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Deletedata();
            textBox1.Text = " ";
        }
    }
}
