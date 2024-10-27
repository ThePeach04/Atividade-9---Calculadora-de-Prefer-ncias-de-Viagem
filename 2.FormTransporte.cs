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
    public partial class FormTransporte : Form
    {
        public FormTransporte()
        {
            InitializeComponent();
        }

        private void lblTransporte_Click(object sender, EventArgs e)
        {

        }

        private void txtTransporteResultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnConfirmarTransporte_Click(object sender, EventArgs e)
        {

            string resultado = "";

            if (cbCarro.Checked)
            {
                resultado += " Carro";
            }

            if (cbAviao.Checked)
            {
                resultado += " Avião";
            }

            if (cbTrem.Checked)
            {
                resultado += " Trem";
            }

            txtTransporteResultado.Text = resultado;

        }
    }
}
