using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaTeTi
{
    public partial class frmTaTeTi : Form
    {
        public frmTaTeTi()
        {
            InitializeComponent();

            btn1.BackColor = Color.WhiteSmoke;
            btn2.BackColor = Color.WhiteSmoke;
            btn3.BackColor = Color.WhiteSmoke;
            btn4.BackColor = Color.WhiteSmoke;
            btn5.BackColor = Color.WhiteSmoke;
            btn6.BackColor = Color.WhiteSmoke;
            btn7.BackColor = Color.WhiteSmoke;
            btn8.BackColor = Color.WhiteSmoke;
            btn9.BackColor = Color.WhiteSmoke;
        }



        private void btn1_Click(object sender, EventArgs e)
        {
            if (rdbX.Checked)
            {
                btn1.Text = "X";

                if (btn1.Text == "X" && btn2.Text == "X" && btn3.Text == "X")
                {
                    btn1.BackColor = Color.IndianRed;
                    btn2.BackColor = Color.IndianRed;
                    btn3.BackColor = Color.IndianRed;

                    lblGanador.Text = "Ganador: jugador 1";
                }

                if (btn1.Text == "X" && btn5.Text == "X" && btn9.Text == "X")
                {
                    btn1.BackColor = Color.IndianRed;
                    btn5.BackColor = Color.IndianRed;
                    btn9.BackColor = Color.IndianRed;

                    lblGanador.Text = "Ganador: jugador 1";
                }

                if (btn1.Text == "X" && btn4.Text == "X" && btn7.Text == "X")
                {
                    btn1.BackColor = Color.IndianRed;
                    btn4.BackColor = Color.IndianRed;
                    btn7.BackColor = Color.IndianRed;

                    lblGanador.Text = "Ganador: jugador 1";
                }
            }

            else
            {
                btn1.Text = "O";

                if (btn1.Text == "O" && btn2.Text == "O" && btn3.Text == "O")
                {
                    btn1.BackColor = Color.LightCyan;
                    btn2.BackColor = Color.LightCyan;
                    btn3.BackColor = Color.LightCyan;

                    lblGanador.Text = "Ganador: jugador 2";
                }

                if (btn1.Text == "O" && btn5.Text == "O" && btn9.Text == "O")
                {
                    btn1.BackColor = Color.LightCyan;
                    btn5.BackColor = Color.LightCyan;
                    btn9.BackColor = Color.LightCyan;

                    lblGanador.Text = "Ganador: jugador 2";
                }

                if (btn1.Text == "O" && btn4.Text == "O" && btn7.Text == "O")
                {
                    btn1.BackColor = Color.LightCyan;
                    btn4.BackColor = Color.LightCyan;
                    btn7.BackColor = Color.LightCyan;

                    lblGanador.Text = "Ganador: jugador 2";
                }
            }

            btn1.Enabled = false;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (rdbX.Checked)
            {
                btn2.Text = "X";

                if (btn1.Text == "X" && btn2.Text == "X" && btn3.Text == "X")
                {
                    btn1.BackColor = Color.IndianRed;
                    btn2.BackColor = Color.IndianRed;
                    btn3.BackColor = Color.IndianRed;

                    lblGanador.Text = "Ganador: jugador 1";
                }

                if (btn2.Text == "X" && btn5.Text == "X" && btn8.Text == "X")
                {
                    btn2.BackColor = Color.IndianRed;
                    btn5.BackColor = Color.IndianRed;
                    btn8.BackColor = Color.IndianRed;

                    lblGanador.Text = "Ganador: jugador 1";
                }
            }

            else
            {
                btn2.Text = "O";

                if (btn1.Text == "O" && btn2.Text == "O" && btn3.Text == "O")
                {
                    btn1.BackColor = Color.LightCyan;
                    btn2.BackColor = Color.LightCyan;
                    btn3.BackColor = Color.LightCyan;

                    lblGanador.Text = "Ganador: jugador 2";
                }

                if (btn2.Text == "O" && btn5.Text == "O" && btn8.Text == "O")
                {
                    btn2.BackColor = Color.LightCyan;
                    btn5.BackColor = Color.LightCyan;
                    btn8.BackColor = Color.LightCyan;

                    lblGanador.Text = "Ganador: jugador 2";
                }
            }

            btn2.Enabled = false;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (rdbX.Checked)
            {
                btn3.Text = "X";

                if (btn1.Text == "X" && btn2.Text == "X" && btn3.Text == "X")
                {
                    btn1.BackColor = Color.IndianRed;
                    btn2.BackColor = Color.IndianRed;
                    btn3.BackColor = Color.IndianRed;

                    lblGanador.Text = "Ganador: jugador 1";
                }

                if (btn3.Text == "X" && btn5.Text == "X" && btn7.Text == "X")
                {
                    btn3.BackColor = Color.IndianRed;
                    btn5.BackColor = Color.IndianRed;
                    btn7.BackColor = Color.IndianRed;

                    lblGanador.Text = "Ganador: jugador 1";
                }

                if (btn3.Text == "X" && btn6.Text == "X" && btn9.Text == "X")
                {
                    btn3.BackColor = Color.IndianRed;
                    btn6.BackColor = Color.IndianRed;
                    btn9.BackColor = Color.IndianRed;

                    lblGanador.Text = "Ganador: jugador 1";
                }
            }

            else
            {
                btn3.Text = "O";

                if (btn1.Text == "O" && btn2.Text == "O" && btn3.Text == "O")
                {
                    btn1.BackColor = Color.LightCyan;
                    btn2.BackColor = Color.LightCyan;
                    btn3.BackColor = Color.LightCyan;

                    lblGanador.Text = "Ganador: jugador 2";
                }

                if (btn3.Text == "O" && btn5.Text == "O" && btn7.Text == "O")
                {
                    btn3.BackColor = Color.LightCyan;
                    btn5.BackColor = Color.LightCyan;
                    btn7.BackColor = Color.LightCyan;

                    lblGanador.Text = "Ganador: jugador 2";
                }

                if (btn3.Text == "O" && btn6.Text == "O" && btn9.Text == "O")
                {
                    btn3.BackColor = Color.LightCyan;
                    btn6.BackColor = Color.LightCyan;
                    btn9.BackColor = Color.LightCyan;

                    lblGanador.Text = "Ganador: jugador 2";
                }
            }

            btn3.Enabled = false;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (rdbX.Checked)
            {
                btn4.Text = "X";

                if (btn1.Text == "X" && btn4.Text == "X" && btn7.Text == "X")
                {
                    btn1.BackColor = Color.IndianRed;
                    btn4.BackColor = Color.IndianRed;
                    btn7.BackColor = Color.IndianRed;

                    lblGanador.Text = "Ganador: jugador 1";
                }

                if (btn4.Text == "X" && btn5.Text == "X" && btn6.Text == "X")
                {
                    btn4.BackColor = Color.IndianRed;
                    btn5.BackColor = Color.IndianRed;
                    btn6.BackColor = Color.IndianRed;

                    lblGanador.Text = "Ganador: jugador 1";
                }
            }

            else
            {
                btn4.Text = "O";

                if (btn1.Text == "O" && btn4.Text == "O" && btn7.Text == "O")
                {
                    btn1.BackColor = Color.LightCyan;
                    btn4.BackColor = Color.LightCyan;
                    btn7.BackColor = Color.LightCyan;

                    lblGanador.Text = "Ganador: jugador 2";
                }

                if (btn4.Text == "O" && btn5.Text == "O" && btn6.Text == "O")
                {
                    btn4.BackColor = Color.LightCyan;
                    btn5.BackColor = Color.LightCyan;
                    btn6.BackColor = Color.LightCyan;

                    lblGanador.Text = "Ganador: jugador 2";
                }
            }

            btn4.Enabled = false;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (rdbX.Checked)
            {
                btn5.Text = "X";

                if (btn1.Text == "X" && btn5.Text == "X" && btn9.Text == "X")
                {
                    btn1.BackColor = Color.IndianRed;
                    btn5.BackColor = Color.IndianRed;
                    btn9.BackColor = Color.IndianRed;

                    lblGanador.Text = "Ganador: jugador 1";
                }

                if (btn3.Text == "X" && btn5.Text == "X" && btn7.Text == "X")
                {
                    btn3.BackColor = Color.IndianRed;
                    btn5.BackColor = Color.IndianRed;
                    btn7.BackColor = Color.IndianRed;

                    lblGanador.Text = "Ganador: jugador 1";
                }

                if (btn2.Text == "X" && btn5.Text == "X" && btn8.Text == "X")
                {
                    btn2.BackColor = Color.IndianRed;
                    btn5.BackColor = Color.IndianRed;
                    btn8.BackColor = Color.IndianRed;

                    lblGanador.Text = "Ganador: jugador 1";
                }

                if (btn2.Text == "X" && btn5.Text == "X" && btn8.Text == "X")
                {
                    btn2.BackColor = Color.IndianRed;
                    btn5.BackColor = Color.IndianRed;
                    btn8.BackColor = Color.IndianRed;

                    lblGanador.Text = "Ganador: jugador 1";
                }

                if (btn4.Text == "X" && btn5.Text == "X" && btn6.Text == "X")
                {
                    btn4.BackColor = Color.IndianRed;
                    btn5.BackColor = Color.IndianRed;
                    btn6.BackColor = Color.IndianRed;

                    lblGanador.Text = "Ganador: jugador 1";
                }
            }

            else
            {
                btn5.Text = "O";

                if (btn1.Text == "O" && btn5.Text == "O" && btn9.Text == "O")
                {
                    btn1.BackColor = Color.LightCyan;
                    btn5.BackColor = Color.LightCyan;
                    btn9.BackColor = Color.LightCyan;

                    lblGanador.Text = "Ganador: jugador 2";
                }

                if (btn3.Text == "O" && btn5.Text == "O" && btn7.Text == "O")
                {
                    btn3.BackColor = Color.LightCyan;
                    btn5.BackColor = Color.LightCyan;
                    btn7.BackColor = Color.LightCyan;

                    lblGanador.Text = "Ganador: jugador 2";
                }

                if (btn2.Text == "O" && btn5.Text == "O" && btn8.Text == "O")
                {
                    btn2.BackColor = Color.LightCyan;
                    btn5.BackColor = Color.LightCyan;
                    btn8.BackColor = Color.LightCyan;

                    lblGanador.Text = "Ganador: jugador 2";
                }

                if (btn4.Text == "O" && btn5.Text == "O" && btn6.Text == "O")
                {
                    btn4.BackColor = Color.LightCyan;
                    btn5.BackColor = Color.LightCyan;
                    btn6.BackColor = Color.LightCyan;

                    lblGanador.Text = "Ganador: jugador 2";
                }
            }

            btn5.Enabled = false;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (rdbX.Checked)
            {
                btn6.Text = "X";

                if (btn4.Text == "X" && btn5.Text == "X" && btn6.Text == "X")
                {
                    btn4.BackColor = Color.IndianRed;
                    btn5.BackColor = Color.IndianRed;
                    btn6.BackColor = Color.IndianRed;

                    lblGanador.Text = "Ganador: jugador 1";
                }

                if (btn3.Text == "X" && btn6.Text == "X" && btn9.Text == "X")
                {
                    btn3.BackColor = Color.IndianRed;
                    btn6.BackColor = Color.IndianRed;
                    btn9.BackColor = Color.IndianRed;

                    lblGanador.Text = "Ganador: jugador 1";
                }
            }

            else
            {
                btn6.Text = "O";

                if (btn4.Text == "O" && btn5.Text == "O" && btn6.Text == "O")
                {
                    btn4.BackColor = Color.LightCyan;
                    btn5.BackColor = Color.LightCyan;
                    btn6.BackColor = Color.LightCyan;

                    lblGanador.Text = "Ganador: jugador 2";
                }

                if (btn3.Text == "O" && btn6.Text == "O" && btn9.Text == "O")
                {
                    btn3.BackColor = Color.LightCyan;
                    btn6.BackColor = Color.LightCyan;
                    btn9.BackColor = Color.LightCyan;

                    lblGanador.Text = "Ganador: jugador 2";
                }
            }

            btn6.Enabled = false;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (rdbX.Checked)
            {
                btn7.Text = "X";

                if (btn1.Text == "X" && btn4.Text == "X" && btn7.Text == "X")
                {
                    btn1.BackColor = Color.IndianRed;
                    btn4.BackColor = Color.IndianRed;
                    btn7.BackColor = Color.IndianRed;

                    lblGanador.Text = "Ganador: jugador 1";
                }

                if (btn7.Text == "X" && btn5.Text == "X" && btn3.Text == "X")
                {
                    btn3.BackColor = Color.IndianRed;
                    btn5.BackColor = Color.IndianRed;
                    btn7.BackColor = Color.IndianRed;

                    lblGanador.Text = "Ganador: jugador 1";
                }

                if (btn7.Text == "X" && btn8.Text == "X" && btn9.Text == "X")
                {
                    btn7.BackColor = Color.IndianRed;
                    btn8.BackColor = Color.IndianRed;
                    btn9.BackColor = Color.IndianRed;

                    lblGanador.Text = "Ganador: jugador 1";
                }
            }

            else
            {
                btn7.Text = "O";

                if (btn1.Text == "O" && btn4.Text == "O" && btn7.Text == "O")
                {
                    btn1.BackColor = Color.LightCyan;
                    btn4.BackColor = Color.LightCyan;
                    btn7.BackColor = Color.LightCyan;

                    lblGanador.Text = "Ganador: jugador 2";
                }

                if (btn3.Text == "O" && btn5.Text == "O" && btn7.Text == "O")
                {
                    btn3.BackColor = Color.LightCyan;
                    btn5.BackColor = Color.LightCyan;
                    btn7.BackColor = Color.LightCyan;

                    lblGanador.Text = "Ganador: jugador 2";
                }

                if (btn7.Text == "O" && btn8.Text == "O" && btn9.Text == "O")
                {
                    btn7.BackColor = Color.LightCyan;
                    btn8.BackColor = Color.LightCyan;
                    btn9.BackColor = Color.LightCyan;

                    lblGanador.Text = "Ganador: jugador 2";
                }
            }

            btn7.Enabled = false;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (rdbX.Checked)
            {
                btn8.Text = "X";

                if (btn7.Text == "X" && btn8.Text == "X" && btn9.Text == "X")
                {
                    btn7.BackColor = Color.IndianRed;
                    btn8.BackColor = Color.IndianRed;
                    btn9.BackColor = Color.IndianRed;

                    lblGanador.Text = "Ganador: jugador 1";
                }

                if (btn2.Text == "X" && btn5.Text == "X" && btn8.Text == "X")
                {
                    btn2.BackColor = Color.IndianRed;
                    btn5.BackColor = Color.IndianRed;
                    btn8.BackColor = Color.IndianRed;

                    lblGanador.Text = "Ganador: jugador 1";
                }
            }

            else
            {
                btn8.Text = "O";

                if (btn7.Text == "O" && btn8.Text == "O" && btn9.Text == "O")
                {
                    btn7.BackColor = Color.LightCyan;
                    btn8.BackColor = Color.LightCyan;
                    btn9.BackColor = Color.LightCyan;

                    lblGanador.Text = "Ganador: jugador 2";
                }

                if (btn2.Text == "O" && btn5.Text == "O" && btn8.Text == "O")
                {
                    btn2.BackColor = Color.LightCyan;
                    btn5.BackColor = Color.LightCyan;
                    btn8.BackColor = Color.LightCyan;

                    lblGanador.Text = "Ganador: jugador 2";
                }
            }

            btn8.Enabled = false;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (rdbX.Checked)
            {
                btn9.Text = "X";

                if (btn3.Text == "X" && btn6.Text == "X" && btn9.Text == "X")
                {
                    btn3.BackColor = Color.IndianRed;
                    btn6.BackColor = Color.IndianRed;
                    btn9.BackColor = Color.IndianRed;

                    lblGanador.Text = "Ganador: jugador 1";
                }

                if (btn7.Text == "X" && btn8.Text == "X" && btn9.Text == "X")
                {
                    btn8.BackColor = Color.IndianRed;
                    btn9.BackColor = Color.IndianRed;
                    btn7.BackColor = Color.IndianRed;

                    lblGanador.Text = "Ganador: jugador 1";
                }

                if (btn5.Text == "X" && btn1.Text == "X" && btn9.Text == "X")
                {
                    btn1.BackColor = Color.IndianRed;
                    btn5.BackColor = Color.IndianRed;
                    btn9.BackColor = Color.IndianRed;

                    lblGanador.Text = "Ganador: jugador 1";
                }
            }

            else
            {
                btn9.Text = "O";

                if (btn3.Text == "O" && btn6.Text == "O" && btn9.Text == "O")
                {
                    btn3.BackColor = Color.LightCyan;
                    btn6.BackColor = Color.LightCyan;
                    btn9.BackColor = Color.LightCyan;

                    lblGanador.Text = "Ganador: jugador 2";
                }

                if (btn1.Text == "O" && btn5.Text == "O" && btn9.Text == "O")
                {
                    btn1.BackColor = Color.LightCyan;
                    btn5.BackColor = Color.LightCyan;
                    btn9.BackColor = Color.LightCyan;

                    lblGanador.Text = "Ganador: jugador 2";
                }

                if (btn7.Text == "O" && btn8.Text == "O" && btn9.Text == "O")
                {
                    btn7.BackColor = Color.LightCyan;
                    btn8.BackColor = Color.LightCyan;
                    btn9.BackColor = Color.LightCyan;

                    lblGanador.Text = "Ganador: jugador 2";
                }
            }

            btn9.Enabled = false;
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            btn1.Text = "";
            btn2.Text = "";
            btn3.Text = "";
            btn4.Text = "";
            btn5.Text = "";
            btn6.Text = "";
            btn7.Text = "";
            btn8.Text = "";
            btn9.Text = "";

            btn1.BackColor = Color.WhiteSmoke;
            btn2.BackColor = Color.WhiteSmoke;
            btn3.BackColor = Color.WhiteSmoke;
            btn4.BackColor = Color.WhiteSmoke;
            btn5.BackColor = Color.WhiteSmoke;
            btn6.BackColor = Color.WhiteSmoke;
            btn7.BackColor = Color.WhiteSmoke;
            btn8.BackColor = Color.WhiteSmoke;
            btn9.BackColor = Color.WhiteSmoke;

            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;
            btn9.Enabled = true;

            lblGanador.Text = "";
        }
    }
}
