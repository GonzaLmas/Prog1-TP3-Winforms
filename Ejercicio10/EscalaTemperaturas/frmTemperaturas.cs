using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EscalaTemperaturas
{
    public partial class frmTemperaturas : Form
    {
        public frmTemperaturas()
        {
            InitializeComponent();

            cboEscalaInicial.Items.Add("Celsius");
            cboEscalaInicial.Items.Add("Fahrenheit");
            cboEscalaInicial.Items.Add("Kelvin");
            cboEscalaInicial.Items.Add("Rankine");
        }

        private void dgvEscalas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cboEscalaInicial_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboEscalaInicial.SelectedItem == "Celsius")
            {
                cboEscalaFinal.Enabled = true;
                cboEscalaFinal.Items.Clear();

                cboEscalaFinal.Items.Add("Fahrenheit");
                cboEscalaFinal.Items.Add("Kelvin");
                cboEscalaFinal.Items.Add("Rankine");
            }
            else if (cboEscalaInicial.SelectedItem == "Fahrenheit")
            {
                cboEscalaFinal.Enabled = true;
                cboEscalaFinal.Items.Clear();

                cboEscalaFinal.Items.Add("Celsius");
                cboEscalaFinal.Items.Add("Kelvin");
                cboEscalaFinal.Items.Add("Rankine");
            }
            else if (cboEscalaInicial.SelectedItem == "Kelvin")
            {
                cboEscalaFinal.Enabled = true;
                cboEscalaFinal.Items.Clear();

                cboEscalaFinal.Items.Add("Celsius");
                cboEscalaFinal.Items.Add("Fahrenheit");
                cboEscalaFinal.Items.Add("Rankine");
            }
            else if (cboEscalaInicial.SelectedItem == "Rankine")
            {
                cboEscalaFinal.Enabled = true;
                cboEscalaFinal.Items.Clear();

                cboEscalaFinal.Items.Add("Celsius");
                cboEscalaFinal.Items.Add("Fahrenheit");
                cboEscalaFinal.Items.Add("Kelvin");
            }
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            double tempInicial = double.Parse(txtValor.Text);
            string escInicial = cboEscalaInicial.Text;
            string escFinal = cboEscalaFinal.Text;

            int n = dgvEscalas.Rows.Add();

            dgvEscalas.Rows[n].Cells[0].Value = escInicial;
            dgvEscalas.Rows[n].Cells[1].Value = escFinal;
            dgvEscalas.Rows[n].Cells[2].Value = tempInicial;

            double cel;
            double farh;
            double kel;
            double rank;
            double tempFinal;

            if (cboEscalaInicial.SelectedItem == "Celsius")
            {
                if (cboEscalaFinal.SelectedItem == "Fahrenheit")
                {
                    farh = (tempInicial * 9 / 5) + 32;

                    tempFinal = farh;

                    dgvEscalas.Rows[n].Cells[3].Value = tempFinal;
                }

                if (cboEscalaFinal.SelectedItem == "Kelvin")
                {
                    kel = tempInicial + 273.15;

                    tempFinal = kel;

                    dgvEscalas.Rows[n].Cells[3].Value = tempFinal;
                }

                if (cboEscalaFinal.SelectedItem == "Rankine")
                {
                    rank = (tempInicial + 273.15) * 9 / 5 + 491.67;

                    tempFinal = rank;

                    dgvEscalas.Rows[n].Cells[3].Value = tempFinal;
                }
            }

            if (cboEscalaInicial.SelectedItem == "Fahrenheit")
            {
                if (cboEscalaFinal.SelectedItem == "Celsius")
                {
                    cel = (tempInicial - 32) * 5 / 9;

                    tempFinal = cel;

                    dgvEscalas.Rows[n].Cells[3].Value = tempFinal;
                }

                if (cboEscalaFinal.SelectedItem == "Kelvin")
                {
                    kel = (tempInicial - 32) * 5 / 9 + 273.15;

                    tempFinal = kel;

                    dgvEscalas.Rows[n].Cells[3].Value = tempFinal;
                }

                if (cboEscalaFinal.SelectedItem == "Rankine")
                {
                    rank = tempInicial + 459.67;

                    tempFinal = rank;

                    dgvEscalas.Rows[n].Cells[3].Value = tempFinal;
                }
            }


            if (cboEscalaInicial.SelectedItem == "Kelvin")
            {
                if (cboEscalaFinal.SelectedItem == "Celsius")
                {
                    cel = tempInicial - 273.15;

                    tempFinal = cel;

                    dgvEscalas.Rows[n].Cells[3].Value = tempFinal;
                }

                if (cboEscalaFinal.SelectedItem == "Fahrenheit")
                {
                    farh = (tempInicial - 273.15) * 9 / 5 + 32;

                    tempFinal = farh;

                    dgvEscalas.Rows[n].Cells[3].Value = tempFinal;
                }

                if (cboEscalaFinal.SelectedItem == "Rankine")
                {
                    rank = tempInicial * 1.8;

                    tempFinal = rank;

                    dgvEscalas.Rows[n].Cells[3].Value = tempFinal;
                }
            }

            if (cboEscalaInicial.SelectedItem == "Rankine")
            {
                if (cboEscalaFinal.SelectedItem == "Celsius")
                {
                    cel = (tempInicial - 491.67) * 5 / 9;

                    tempFinal = cel;

                    dgvEscalas.Rows[n].Cells[3].Value = tempFinal;
                }

                if (cboEscalaFinal.SelectedItem == "Fahrenheit")
                {
                    farh = tempInicial - 459.67;

                    tempFinal = farh;

                    dgvEscalas.Rows[n].Cells[3].Value = tempFinal;
                }

                if (cboEscalaFinal.SelectedItem == "Kelvin")
                {
                    rank = tempInicial * 5 / 9;

                    tempFinal = rank;

                    dgvEscalas.Rows[n].Cells[3].Value = tempFinal;
                }
            }
        }
    }
}
