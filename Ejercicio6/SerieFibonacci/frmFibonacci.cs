using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerieFibonacci
{
    public partial class frmFibonacci : Form
    {
        public frmFibonacci()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int cant = int.Parse(txtCant.Text);

            int[] array = new int[cant];
            array[0] = 0;
            array[1] = 1;

            for (int i = 2; i < cant; i++)
            {
                array[i] = array[i - 1] + array[i - 2];
            }
                lbxFibonacci.Items.Clear();

            for (int i = 0; i < cant; i++)
            {
                lbxFibonacci.Items.Add(array[i]);
            }
        }
    }
}
