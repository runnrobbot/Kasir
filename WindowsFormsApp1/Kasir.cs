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
    public partial class Kasir : Form
    {
        public Kasir()
        {
            InitializeComponent();
            showData();
        
        }

        private void showData()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Discord bot\dbFaydMedicine.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM obatDataTable", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            bunifuDataGridView1.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = bunifuDataGridView1.Rows.Add();
                bunifuDataGridView1.Rows[n].Cells[0].Value = false;
                bunifuDataGridView1.Rows[n].Cells[1].Value = item["NAMA"].ToString();
                bunifuDataGridView1.Rows[n].Cells[2].Value = item["JENIS"].ToString();
                bunifuDataGridView1.Rows[n].Cells[3].Value = item["JUMLAH"].ToString();
                bunifuDataGridView1.Rows[n].Cells[4].Value = item["HARGA"].ToString();
            }
        }

        private void bunifuButton21_Click(object sender, EventArgs e)
        {
            bunifuDataGridView2.Rows.Clear();
            foreach (DataGridViewRow item in bunifuDataGridView1.Rows)
            {
                if ((bool)item.Cells[0].Value == true)
                {
                    int n = bunifuDataGridView2.Rows.Add();
                    bunifuDataGridView2.Rows[n].Cells[0].Value = item.Cells[1].Value.ToString();
                    bunifuDataGridView2.Rows[n].Cells[1].Value = item.Cells[2].Value.ToString();
                    bunifuDataGridView2.Rows[n].Cells[2].Value = item.Cells[3].Value.ToString();
                    bunifuDataGridView2.Rows[n].Cells[3].Value = item.Cells[4].Value.ToString();
                }
            }
        }

        private void kasirLabel_Click(object sender, EventArgs e)
        {

        }

        private void bunifuDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuDataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            if((bool)bunifuDataGridView1.SelectedRows[0].Cells[0].Value == true)
            {
                bunifuDataGridView1.SelectedRows[0].Cells[0].Value = true;
            }
            else
            {
                bunifuDataGridView1.SelectedRows[0].Cells[0].Value = false;
            }
        }

        private void bunifuButton22_Click(object sender, EventArgs e)
        {
            panelTunaiKartu.Visible = true;
        }

        private void bunifuButton24_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pembayaran Berhasil!");
            panelTunaiKartu.Visible = false;
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();

            dt.Columns.Add("NAMA OBAT", typeof(string));
            dt.Columns.Add("JENIS OBAT", typeof(string));
            dt.Columns.Add("JUMLAH", typeof(string));
            dt.Columns.Add("HARGA", typeof(string));

            foreach (DataGridViewRow dgv in bunifuDataGridView1.Rows)
            {
                dt.Rows.Add(dgv.Cells[1].Value, dgv.Cells[2].Value, dgv.Cells[3].Value, dgv.Cells[4].Value);
            }
            ds.Tables.Add(dt);
            ds.WriteXmlSchema("applicant.xml");

            Struk struk = new Struk();
            CrystalReport1 cr = new CrystalReport1();
            cr.SetDataSource(ds);
            struk.crystalReportViewer1.ReportSource = cr;
            struk.crystalReportViewer1.Refresh();
            struk.Show();


        }

        private void Kasir_Load(object sender, EventArgs e)
        {

        }

        private void bunifuButton23_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pembayaran Berhasil!");
            panelTunaiKartu.Visible = false;
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();

            dt.Columns.Add("NAMA OBAT", typeof(string));
            dt.Columns.Add("JENIS OBAT", typeof(string));
            dt.Columns.Add("JUMLAH", typeof(string));
            dt.Columns.Add("HARGA", typeof(string));

            foreach (DataGridViewRow dgv in bunifuDataGridView1.Rows)
            {
                dt.Rows.Add(dgv.Cells[1].Value, dgv.Cells[2].Value, dgv.Cells[3].Value, dgv.Cells[4].Value);
            }
            ds.Tables.Add(dt);
            ds.WriteXmlSchema("applicant.xml");

            Struk struk = new Struk();
            CrystalReport1 cr = new CrystalReport1();
            cr.SetDataSource(ds);
            struk.crystalReportViewer1.ReportSource = cr;
            struk.crystalReportViewer1.Refresh();
            struk.Show();
        }

        private void panelTunaiKartu_Click(object sender, EventArgs e)
        {

        }

    }
}
