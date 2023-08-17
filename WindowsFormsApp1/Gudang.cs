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
    public partial class Gudang : Form
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Discord bot\dbFaydMedicine.mdf;Integrated Security=True;Connect Timeout=30";
        public Gudang()
        {
            InitializeComponent();
        }

        private void bunifuLabel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton21_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM obatDataTable", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                DataGridView1.DataSource = dtbl;
            }

            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM supplierDataTable", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                DataGridView2.DataSource = dtbl;
            }
        }

        private void Gudang_Load(object sender, EventArgs e)
        {

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            Edit edit = new Edit();
            edit.Show();
        }


        private void bunifuButton22_Click(object sender, EventArgs e)
        {
            bunifuPanelReport1.Visible = true;

        }

        private void bunifuButton23_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();

            dt.Columns.Add("ID SUPPLIER", typeof(string));
            dt.Columns.Add("NAMA SUPPLIER", typeof(string));
            dt.Columns.Add("ID OBAT", typeof(string));
            dt.Columns.Add("JUMLAH", typeof(string));
            dt.Columns.Add("HARGA BELI", typeof(string));
            dt.Columns.Add("TANGGAL BELI", typeof(string));

            foreach (DataGridViewRow dgv in DataGridView2.Rows)
            {
                dt.Rows.Add(dgv.Cells[0].Value, dgv.Cells[1].Value, dgv.Cells[2].Value, dgv.Cells[3].Value, dgv.Cells[4].Value, dgv.Cells[5].Value);
            }
            ds.Tables.Add(dt);
            ds.WriteXmlSchema("applicantproduksi.xml");

            StrukSupplier struk = new StrukSupplier();
            CrystalReport2 cr = new CrystalReport2();
            cr.SetDataSource(ds);
            struk.crystalReportViewer1.ReportSource = cr;
            struk.crystalReportViewer1.Refresh();
            struk.Show();

            bunifuPanelReport1.Visible = false;
            MessageBox.Show("Print sudah di cetak!");
        }

        private void bunifuButton24_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();

            dt.Columns.Add("NAMA OBAT", typeof(string));
            dt.Columns.Add("JENIS OBAT", typeof(string));
            dt.Columns.Add("JUMLAH", typeof(string));
            dt.Columns.Add("HARGA", typeof(string));

            foreach (DataGridViewRow dgv in DataGridView1.Rows)
            {
                dt.Rows.Add(dgv.Cells[0].Value, dgv.Cells[1].Value, dgv.Cells[2].Value, dgv.Cells[3].Value);
            }
            ds.Tables.Add(dt);
            ds.WriteXmlSchema("applicantobat.xml");

            StrukObatGudang struk = new StrukObatGudang();
            CrystalReport3 cr = new CrystalReport3();
            cr.SetDataSource(ds);
            struk.crystalReportViewer1.ReportSource = cr;
            struk.crystalReportViewer1.Refresh();
            struk.Show();

            bunifuPanelReport1.Visible = false;
            MessageBox.Show("Print sudah di cetak!");
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
