using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            custome();
        }

        private void custome()
        {
            panelStock.Visible = false;
            panelAdmin.Visible = true;
        }

        private void hideKiri()
        {
            if (panelAdmin.Visible == true)
                panelAdmin.Visible = false;

            if (panelStock.Visible == true)
                panelStock.Visible = false;
        }

        private void munculKiri(Panel KiriUtama)
        {
            if (KiriUtama.Visible == false)
            {
                hideKiri();
                KiriUtama.Visible = true;
            }
            else
                KiriUtama.Visible = false;
        }

        public void loadform(object Form)
        {
            if (this.dashboardPanel.Controls.Count > 0)
                this.dashboardPanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.dashboardPanel.Controls.Add(f);
            this.dashboardPanel.Tag = f;
            f.Show();
        }

        private void adminBtn2_Click(object sender, EventArgs e)
        {
            loadform(new Supplier());

        }

        private void admin_Click(object sender, EventArgs e)
        {
            munculKiri(panelAdmin);
        }

        private void logo_Click(object sender, EventArgs e)
        {

        }

        private void informationLabel_Click(object sender, EventArgs e)
        {

        }

        private void Stock_Click(object sender, EventArgs e)
        {
            munculKiri(panelStock);
        }

        

        private void stockBtn1_Click(object sender, EventArgs e)
        {
            loadform(new Kasir());
        }


        private void bunifuLabel1_Click(object sender, EventArgs e)
        {

        }


        private void adminProductBtn_Click(object sender, EventArgs e)
        {
            loadform(new Produk());
        }

        private void bunifuLabel7_Click(object sender, EventArgs e)
        {

        }

        private void stockBtn3_Click(object sender, EventArgs e)
        {
            loadform(new Gudang());
        }

        private void panelStock_Paint(object sender, PaintEventArgs e)
        {

        }

        private void manageBox_Click(object sender, EventArgs e)
        {
            loadform(new User());
        }
    }
}
