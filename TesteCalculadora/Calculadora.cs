using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesteCalculadora
{
    public partial class Calculadora : Form
    {
        Calculos calculos = new Calculos();

        public Calculadora()
        {
            InitializeComponent();
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            calculos.calculoAtiv = "soma";
            calculos.numeroAtivo = 2;
            txtVisor.Text = "0";
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            calculos.calculoAtiv = "subtracao";
            calculos.numeroAtivo = 2;
            txtVisor.Text = "0";
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            calculos.calculoAtiv = "divisao";
            calculos.numeroAtivo = 2;
            txtVisor.Text = "0";
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            calculos.calculoAtiv = "multiplicacao";
            calculos.numeroAtivo = 2;
            txtVisor.Text = "0";
        }

        private void Calculadora_Load(object sender, EventArgs e)
        {
            txtVisor.Text = calculos.resultado.ToString();
            calculos.calculoAtiv = "indefinido";
            calculos.numeroAtivo = 1;
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            if(calculos.numeroAtivo == 1)
            {
                calculos.numero1 = (calculos.numero1 * 10) + 1;
                txtVisor.Text = calculos.numero1.ToString();
            } else
            {
                calculos.numero2 = (calculos.numero2 * 10) + 1;
                txtVisor.Text = calculos.numero2.ToString();
            }
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            if (calculos.numeroAtivo == 1)
            {
                calculos.numero1 = (calculos.numero1 * 10) + 2;
                txtVisor.Text = calculos.numero1.ToString();
            }
            else
            {
                calculos.numero2 = (calculos.numero2 * 10) + 2;
                txtVisor.Text = calculos.numero2.ToString();
            }
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            if (calculos.numeroAtivo == 1)
            {
                calculos.numero1 = (calculos.numero1 * 10) + 3;
                txtVisor.Text = calculos.numero1.ToString();
            }
            else
            {
                calculos.numero2 = (calculos.numero2 * 10) + 3;
                txtVisor.Text = calculos.numero2.ToString();
            }
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            if (calculos.numeroAtivo == 1)
            {
                calculos.numero1 = (calculos.numero1 * 10) + 4;
                txtVisor.Text = calculos.numero1.ToString();
            }
            else
            {
                calculos.numero2 = (calculos.numero2 * 10) + 4;
                txtVisor.Text = calculos.numero2.ToString();
            }
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            if (calculos.numeroAtivo == 1)
            {
                calculos.numero1 = (calculos.numero1 * 10) + 5;
                txtVisor.Text = calculos.numero1.ToString();
            }
            else
            {
                calculos.numero2 = (calculos.numero2 * 10) + 5;
                txtVisor.Text = calculos.numero2.ToString();
            }
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            if (calculos.numeroAtivo == 1)
            {
                calculos.numero1 = (calculos.numero1 * 10) + 6;
                txtVisor.Text = calculos.numero1.ToString();
            }
            else
            {
                calculos.numero2 = (calculos.numero2 * 10) + 6;
                txtVisor.Text = calculos.numero2.ToString();
            }
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            if (calculos.numeroAtivo == 1)
            {
                calculos.numero1 = (calculos.numero1 * 10) + 7;
                txtVisor.Text = calculos.numero1.ToString();
            }
            else
            {
                calculos.numero2 = (calculos.numero2 * 10) + 7;
                txtVisor.Text = calculos.numero2.ToString();
            }
        }

        private void btnEleven_Click(object sender, EventArgs e)
        {
            if (calculos.numeroAtivo == 1)
            {
                calculos.numero1 = (calculos.numero1 * 10) + 8;
                txtVisor.Text = calculos.numero1.ToString();
            }
            else
            {
                calculos.numero2 = (calculos.numero2 * 10) + 8;
                txtVisor.Text = calculos.numero2.ToString();
            }
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            if (calculos.numeroAtivo == 1)
            {
                calculos.numero1 = (calculos.numero1 * 10) + 9;
                txtVisor.Text = calculos.numero1.ToString();
            }
            else
            {
                calculos.numero2 = (calculos.numero2 * 10) + 9;
                txtVisor.Text = calculos.numero2.ToString();
            }
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            txtVisor.Text = calculos.checarResultado();
        }
    }
}
