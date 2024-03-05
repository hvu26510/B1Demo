using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtBac1.Checked)
            {
                txtC.Text = "";
                txtC.ReadOnly = true;
            }else
            {
                txtC.Text = "";
                txtC.ReadOnly = false;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((!rbtBac1.Checked) && (!rbtBac2.Checked) )
            {
                MessageBox.Show("Chon loai phuong trinh");
            }
            else if (rbtBac1.Checked)
            {
                double a= double.Parse(txtA.Text);
                double b = double.Parse(txtB.Text);
                if (a == 0)
                {
                    txtKQ.Text = "Vo nghiem";
                }
                else
                {
                    txtKQ.Text = ((-b) / a).ToString();
                }
            }
            else
            {
                double a = double.Parse(txtA.Text);
                double b = double.Parse(txtB.Text);
                double c = double.Parse(txtC.Text);
                

                if(a == 0)
                {
                    txtKQ.Text = ((-c) / b).ToString();
                }
                else
                {
                    double delta = b * b - 4 * a * c;
                    if (delta < 0)
                    {
                        txtKQ.Text = "Vo nghiem";
                    }else if(delta == 0)
                    {
                        txtKQ.Text = ((-b) / 2*a).ToString();
                    }
                    else
                    {
                        txtKQ.Text = (((-b) + Math.Sqrt(delta) )/ 2 * a).ToString() + " va "+ (((-b) - Math.Sqrt(delta)) / 2 * a).ToString();
                    }

                }

            }
        }
    }
}
