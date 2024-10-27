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
    public partial class FormDestino : Form
    {
        public FormDestino()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void rbCidade_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
                if (rbPraia.Checked)
                {
                    MessageBox.Show("Seu destino preferido é a Praia");
                }
                else if (rbMontanha.Checked)
                {
                    MessageBox.Show("Seu destino preferido é a Montanha");
                }
                else if (rbCidade.Checked)
                {
                    MessageBox.Show("Seu destino preferido é a Cidade");
                }
                else
                {
                    MessageBox.Show("Selecione o destino preferido");
                }
            }

        }

     }
