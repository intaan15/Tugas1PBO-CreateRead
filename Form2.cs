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
    public partial class Form2 : Form
    {
        private NpgsqlConnection connection;
        private string connString = "Server=localhost;Port=5432;User Id=postgres;Password=Ilmiana15!;Database=Asdos;";

        public Form2()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            AllDetailTransaksi.Visible = true;
            AllDetailTransaksi.Text = "=== DATA LAPTOP ===" + "\n" + "\n Laptop yang dipilih     : " + textNamaLepi.Text + "\n Harga Laptop              : " + textHargaLepi.Text + "\n Stok Laptop                : " + textStokLepi.Text;
        }

        private void Createdata()
        {
            NpgsqlConnection connection = new NpgsqlConnection(connString);
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand("INSERT INTO laptop(nama_barang, harga, stok) " +
                "VALUES (@value1, @value2, @value3)", connection);
            command.Parameters.AddWithValue("value1", textNamaLepi.Text);
            command.Parameters.AddWithValue("value2", textHargaLepi.Text);
            command.Parameters.AddWithValue("value3", textStokLepi.Text);

            command.ExecuteNonQuery();
            connection.Close();

            MessageBox.Show("Success Insert data");
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Createdata();
            textNamaLepi.Text = "";
            textHargaLepi.Text = "";
            textStokLepi.Text = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textNamaLepi.Text = "";
            textHargaLepi.Text = "";
            textStokLepi.Text = "";
            AllDetailTransaksi.Text = "";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            textNamaLepi.Text = "";
            textHargaLepi.Text = "";
            textStokLepi.Text = "";
        }
        private void Transaksi_Load(object sender, EventArgs e)
        {

        }

        private void textID_TextChanged(object sender, EventArgs e)
        {

        }

        private void textNamaLepi_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
