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
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
            showData();
        }

        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Discord bot\dbFaydMedicine.mdf;Integrated Security=True;Connect Timeout=30";
        private void showData()
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM tblLogin", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                DataGridView1.DataSource = dtbl;
            }
        }
        private void bunifuDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void bunifuLabel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton21_Click(object sender, EventArgs e)
        {
           
        }
    }
}
