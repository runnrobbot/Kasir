using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Edit : Form
    {
        public Edit()
        {
            InitializeComponent();
        }

        private void Edit_Load(object sender, EventArgs e)
        {

        }

        private void bunifuButton21_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Discord bot\dbFaydMedicine.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            SqlCommand cmd = new SqlCommand("Update obatDataTable set NAMA=@Nama, JENIS=@Jenis, JUMLAH=@Jumlah, HARGA=@Harga", con);
            cmd.Parameters.AddWithValue("@Nama", namaBox.Text);
            cmd.Parameters.AddWithValue("@Jenis", jenisBox.Text);
            cmd.Parameters.AddWithValue("@Jumlah", int.Parse(jumlahBox.Text));
            cmd.Parameters.AddWithValue("@Harga", int.Parse(hargaBox.Text));
            
            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Data berhasil di update");
        }

        private void bunifuButton22_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Discord bot\dbFaydMedicine.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            SqlCommand cmd = new SqlCommand("Update supplierDataTable set idsupplier=@Idsupplier, namasupplier=@Namasupplier, idobat=@Idobat, jumlah=@Jumlah, hargabeli=@Hargabeli, tanggalbeli=@Tanggalbeli", con);
            cmd.Parameters.AddWithValue("@Idsupplier", int.Parse(idBox.Text));
            cmd.Parameters.AddWithValue("@Namasupplier", bunifuTextBox3.Text);
            cmd.Parameters.AddWithValue("@Idobat", int.Parse(idobatBox.Text));
            cmd.Parameters.AddWithValue("@Jumlah", int.Parse(bunifuTextBox2.Text));
            cmd.Parameters.AddWithValue("@Hargabeli", int.Parse(bunifuTextBox1.Text));
            cmd.Parameters.AddWithValue("@Tanggalbeli", int.Parse(tanggalBox.Text));

            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data berhasil di update");
        }

        private void bunifuButton23_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Discord bot\dbFaydMedicine.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete obatDataTable where NAMA=@Nama", con);
            cmd.Parameters.AddWithValue("@Nama", namaBox.Text);
            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Data berhasil di delete");
        }

        private void bunifuButton24_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Discord bot\dbFaydMedicine.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete supplierDataTable where idsupplier=@Idsupplier", con);
            cmd.Parameters.AddWithValue("@Idsupplier", int.Parse(idBox.Text));
            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Data berhasil di delete");
        }
    }
}
