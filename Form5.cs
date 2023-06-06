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
    public partial class Form5 : Form
    {
        private NpgsqlConnection connection;
        private string connString = "Server=localhost;Port=5432;User Id=postgres;Password=Ilmiana15!;Database=Asdos;";
        private NpgsqlDataAdapter Adapter;
        private DataTable dt;
        public Form5()
        {
            InitializeComponent();
            ShowData();
        }

        private void ShowData()
        {

            try
            {
                connection = new NpgsqlConnection(connString);
                dt = new DataTable();
                Adapter = new NpgsqlDataAdapter("SELECT nomor, nama_barang as nama, harga, stok FROM laptop ORDER BY nomor", connection);
                connection.Open();
                Adapter.Fill(dt);
                connection.Close();
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                connection.Close();
                MessageBox.Show("error" + ex.Message);
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
