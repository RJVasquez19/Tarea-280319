using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea28032019
{
    public partial class frmOperaciones : Form
    {
        double num1, num2, resultado;

        public frmOperaciones()
        {
            InitializeComponent();
        }

        private void chbSuma_CheckedChanged(object sender, EventArgs e)
        {

            num1 = double.Parse(txtValor1.Text);
            num2 = double.Parse(txtValor2.Text);

            resultado = num1 + num2;

            lblResultado.Text = "Resultado: " + resultado.ToString();

            chbResta.Checked = false;
            chbMultiplicacion.Checked = false;
            chbDivision.Checked = false;
        }

        private void chbResta_CheckedChanged(object sender, EventArgs e)
        {
            num1 = double.Parse(txtValor1.Text);
            num2 = double.Parse(txtValor2.Text);

            resultado = num1 - num2;

            lblResultado.Text = "Resultado: " + resultado.ToString();

            chbSuma.Checked = false;
            chbMultiplicacion.Checked = false;
            chbDivision.Checked = false;
        }

        private void chbMultiplicacion_CheckedChanged(object sender, EventArgs e)
        {
            num1 = double.Parse(txtValor1.Text);
            num2 = double.Parse(txtValor2.Text);

            resultado = num1 * num2;

            lblResultado.Text = "Resultado: " + resultado.ToString();

            chbResta.Checked = false;
            chbSuma.Checked = false;
            chbDivision.Checked = false;
        }

        private void chbDivision_CheckedChanged(object sender, EventArgs e)
        {
            num1 = double.Parse(txtValor1.Text);
            num2 = double.Parse(txtValor2.Text);

            resultado = num1 / num2;

            lblResultado.Text = "Resultado: " + resultado.ToString();

            chbResta.Checked = false;
            chbMultiplicacion.Checked = false;
            chbSuma.Checked = false;
        }
    }
}
