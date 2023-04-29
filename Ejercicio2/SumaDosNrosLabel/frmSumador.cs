using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SumaDosNrosLabel
{
    public partial class frmSumador : Form
    {
        public frmSumador()
        {
            InitializeComponent();
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            int n1 = int.Parse(txt1.Text);
            int n2 = int.Parse(txt2.Text);

            if(txt1.Text.Length == 0 && txt2.Text.Length == 0)
                MessageBox.Show("Por favor ingrese dos números en cada espacio.", "Advertencia");
            else
            {
                int res = n1 + n2;

                lblRes.Text = "Resultado: " + res.ToString();
            }

        }
    }
}
