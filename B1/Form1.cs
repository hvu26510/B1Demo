using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            double n = double.Parse(txtN.Text);
            double m = double.Parse(txtM.Text);
            txtKQ.Text = (n+m).ToString();
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            double n = double.Parse(txtN.Text);
            double m = double.Parse(txtM.Text);
            txtKQ.Text = (n - m).ToString();
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            double n = double.Parse(txtN.Text);
            double m = double.Parse(txtM.Text);
            txtKQ.Text = (n * m).ToString();
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            double n = double.Parse(txtN.Text);
            double m = double.Parse(txtM.Text);
            txtKQ.Text = (n / m).ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtM.Text = "";
            txtN.Text = "";
            txtKQ.Text = "";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
