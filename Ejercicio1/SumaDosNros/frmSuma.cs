using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SumaDosNros
{
    public partial class frmSuma : Form
    {
        public frmSuma()
        {
            InitializeComponent();
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            if (txt1.Text.Length == 0 && txt1.Text.Length == 0)
                MessageBox.Show("Por favor complete los dos campos con números.", "Advertencia");
            else
            {
                int n1 = int.Parse(txt1.Text);
                int n2 = int.Parse(txt2.Text);

                int res = n1 + n2;

                MessageBox.Show("La suma de los números ingresados es: " + res, "Resultado");
            }
        }
    }
}
