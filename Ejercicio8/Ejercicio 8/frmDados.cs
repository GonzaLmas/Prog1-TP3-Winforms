using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_8
{
    public partial class frmDados : Form
    {
        public frmDados()
        {
            InitializeComponent();
        }
        private readonly Random rand = new Random();

        private void btnTirar_Click(object sender, EventArgs e)
        {
            int nro = rand.Next(1, 7);
            lblRes.Text = "Resultado: " + nro.ToString();
        }
    }
}
