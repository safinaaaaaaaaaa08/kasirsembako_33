using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace kasirsembako_33
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == "231")
            {
                txtbarang.Text = "Beras(1kg)";
                Harga.Text = "12000";
            }
            else if (comboBox1.SelectedItem == "482")
            {
                txtbarang.Text = "Gula(1kg)";
                Harga.Text = "27000";
            }
            else if (comboBox1.SelectedItem == "623")
            {
                txtbarang.Text = "Galon";
                Harga.Text = "16000";
            }
            else if (comboBox1.SelectedItem == "326")
            {
                txtbarang.Text = "Minyak(1lt)";
                Harga.Text = "17000";
            }
            else if (comboBox1.SelectedItem == "235")
            {
                txtbarang.Text = "Telur";
                Harga.Text = "20000";
            }
            else if (comboBox1.SelectedItem == "954")
            {
                txtbarang.Text = "LPG";
                Harga.Text = "18000";
            }


        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnhitung_Click(object sender, EventArgs e)
        {
            AddtoDatagrid();
            CalculateTotalHarga();
        }
        private void AddtoDatagrid()
        {
            double txtharga, txtjumlah, txttotal;

            txtharga = double.Parse(Harga.Text);
            txtjumlah = double.Parse(Jumlah.Text);

            txttotal = txtharga * txtjumlah;


            totalHarga.Text = txttotal.ToString();
            dataGridView1.Rows.Add(comboBox1.Text, txtbarang.Text, Harga.Text, Jumlah.Text, totalHarga.Text);
        }

        private void CalculateTotalHarga()
        {
            decimal TotalHarga = 0;
            decimal hargaSatuan;
            int jumlah;

            int baris = dataGridView1.Rows.Count - 1;
            for (int i = 0; i < baris; i++)
            {
                hargaSatuan = Decimal.Parse(dataGridView1.Rows[i].Cells["Column2"].Value.ToString());
                jumlah = int.Parse(dataGridView1.Rows[i].Cells["Column3"].Value.ToString());
                TotalHarga += hargaSatuan * jumlah;
            }
            totalHarga.Text = TotalHarga.ToString();
        } 
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            double bptotalHarga, bptotalBayar, bpKembalian, bpHarga, bpJumlah;
            double Th, Kb, Hr, Jm;

            bptotalHarga = double.Parse(totalHarga.Text);
            bptotalBayar = double.Parse(totalBayar.Text);
            bpJumlah = double.Parse(Jumlah.Text);
            bpHarga = double.Parse(Harga.Text);
            bptotalBayar = double.Parse(totalBayar.Text);


            Th = bpHarga * bpJumlah;
            Kb = bptotalBayar - bptotalHarga;

            bpKembalian = bptotalBayar - bptotalHarga;

            Kembalian.Text = "Rp " + bpKembalian.ToString("N");
            Kembalian.Text = Kb.ToString("N");
        }
        

        private void btnbatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Jumlah_TextChanged(object sender, EventArgs e)
        {

        }

        private void totalHarga_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

