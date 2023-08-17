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
    public partial class login : Form
    {
    
        public login()
        {
            InitializeComponent();
        }

        private void bunifuButton21_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Discord bot\dbFaydMedicine.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter sqa = new SqlDataAdapter("Select count(*) From tblLogin where Username ='" + usernameBox.Text + "' and Password = '" + passwordBox.Text +"'", sqlcon);
            DataTable dt = new DataTable();
            sqa.Fill(dt);

            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                Form1 formUtama = new Form1();
                formUtama.Show();
            }
            else
            {
                MessageBox.Show("Username/password salah");
            }
        }
    }
}
