using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade_9___Calculadora_de_Preferências_de_Viagem
{
    public partial class FormCalculoDesconto : Form
    {
        public FormCalculoDesconto()
        {
            InitializeComponent();
        }

        private void txtValorProduto_TextChanged(object sender, EventArgs e)
        {

        }

            private void btnCalcularDesconto_Click(object sender, EventArgs e)
        {
            double valorProduto = Double.Parse(txtValorProduto.Text);
            double resultado = 0;

            if (rbAVista.Checked)
            {
                resultado = valorProduto - (valorProduto * 0.1);

            }
            else if (rbAte3Parcelas.Checked)
            {
                resultado = valorProduto;
            }
            else
            {
                resultado = valorProduto + (valorProduto * 0.1);
            }

            txtResultado.Text = resultado.ToString();
        }
    }
}
