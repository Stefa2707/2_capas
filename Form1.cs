using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculo
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

        private void Limpiar_Click(object sender, EventArgs e)
        {
            txtN1.Text = "";
            txtN2.Text = "";
            txtN3.Text = "";
            txtR.Text = "";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double N1, N2, N3, R;
            N1 = double.Parse(txtN1.Text);
            N2 = double.Parse(txtN2.Text);
            N3 = double.Parse(txtN3.Text);
            R = (N1 + N2 + N3) / 3;
            txtR.Text = R.ToString(); ;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
