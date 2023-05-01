using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class frmCalc : Form
    {
        public frmCalc()
        {
            InitializeComponent();
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            int n1 = int.Parse(txt1.Text);
            int n2 = int.Parse(txt2.Text);

            int res = n1 + n2;

            lblResultado.Text = "Resultado: " + res.ToString();
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            int n1 = int.Parse(txt1.Text);
            int n2 = int.Parse(txt2.Text);

            int res = n1 - n2;

            lblResultado.Text = "Resultado: " + res.ToString();
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            int n1 = int.Parse(txt1.Text);
            int n2 = int.Parse(txt2.Text);

            int res = n1 * n2;

            lblResultado.Text = "Resultado: " + res.ToString();
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            int n1 = int.Parse(txt1.Text);
            int n2 = int.Parse(txt2.Text);

            if (n2 != 0)
            {
                float res = n1 / n2;

                lblResultado.Text = "Resultado: " + res.ToString();
            }
        }

        private void btnPotencia_Click(object sender, EventArgs e)
        {
            if (txt1.Text.Length != 0 && txt2.Text.Length == 0)
            {
                int n1 = int.Parse(txt1.Text);
                int res = n1 * n1;

                lblResultado.Text = "Resultado: " + res.ToString();
            }
            else
            {
                MessageBox.Show("El número debe ingresarlo en la caja 1");
                txt2.Text = "";
            }
        }

        private void btnRaiz_Click(object sender, EventArgs e)
        {
            if (txt1.Text.Length != 0 && txt2.Text.Length == 0)
            {
                int n1 = int.Parse(txt1.Text);
                double res = Math.Sqrt(n1);

                lblResultado.Text = "Resultado: " + res.ToString();
            }
            else
            {
                MessageBox.Show("El número debe ingresarlo en la caja 1");
                txt2.Text = "";
            }
        }

    }
}
