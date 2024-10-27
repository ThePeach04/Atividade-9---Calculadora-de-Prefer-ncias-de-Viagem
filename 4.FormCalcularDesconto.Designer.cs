namespace Atividade_9___Calculadora_de_Preferências_de_Viagem
{
    partial class FormCalculoDesconto
    {
      
        private System.ComponentModel.IContainer components = null;

        
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

   
        private void InitializeComponent()
        {
            lblValor = new Label();
            lblParcelas = new Label();
            txtValorProduto = new TextBox();
            gbParcelamento = new GroupBox();
            rbAVista = new RadioButton();
            rbAte3Parcelas = new RadioButton();
            rb4a12Parcelas = new RadioButton();
            btnCalcularDesconto = new Button();
            txtResultado = new TextBox();
            gbParcelamento.SuspendLayout();
            SuspendLayout();
            // 
            // lblValor
            // 
            lblValor.AutoSize = true;
            lblValor.Location = new Point(12, 15);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(143, 15);
            lblValor.TabIndex = 0;
            lblValor.Text = "Digite o valor do produto:";
            // 
            // lblParcelas
            // 
            lblParcelas.AutoSize = true;
            lblParcelas.Location = new Point(12, 55);
            lblParcelas.Name = "lblParcelas";
            lblParcelas.Size = new Size(184, 15);
            lblParcelas.TabIndex = 1;
            lblParcelas.Text = "Escolha a quantidade de parcelas:";
            // 
            // txtValorProduto
            // 
            txtValorProduto.Location = new Point(161, 12);
            txtValorProduto.Name = "txtValorProduto";
            txtValorProduto.Size = new Size(100, 23);
            txtValorProduto.TabIndex = 2;
            txtValorProduto.TextChanged += txtValorProduto_TextChanged;
            // 
            // gbParcelamento
            // 
            gbParcelamento.Controls.Add(rb4a12Parcelas);
            gbParcelamento.Controls.Add(rbAte3Parcelas);
            gbParcelamento.Controls.Add(rbAVista);
            gbParcelamento.Location = new Point(12, 73);
            gbParcelamento.Name = "gbParcelamento";
            gbParcelamento.Size = new Size(249, 130);
            gbParcelamento.TabIndex = 3;
            gbParcelamento.TabStop = false;
            gbParcelamento.Text = "Parcelamento";
            // 
            // rbAVista
            // 
            rbAVista.AutoSize = true;
            rbAVista.Location = new Point(0, 22);
            rbAVista.Name = "rbAVista";
            rbAVista.Size = new Size(180, 19);
            rbAVista.TabIndex = 0;
            rbAVista.TabStop = true;
            rbAVista.Text = "À vista com 10% de desconto";
            rbAVista.UseVisualStyleBackColor = true;
            // 
            // rbAte3Parcelas
            // 
            rbAte3Parcelas.AutoSize = true;
            rbAte3Parcelas.Location = new Point(0, 56);
            rbAte3Parcelas.Name = "rbAte3Parcelas";
            rbAte3Parcelas.Size = new Size(175, 19);
            rbAte3Parcelas.TabIndex = 1;
            rbAte3Parcelas.TabStop = true;
            rbAte3Parcelas.Text = "Até 3 parcelas sem desconto";
            rbAte3Parcelas.UseVisualStyleBackColor = true;
            // 
            // rb4a12Parcelas
            // 
            rb4a12Parcelas.AutoSize = true;
            rb4a12Parcelas.Location = new Point(0, 90);
            rb4a12Parcelas.Name = "rb4a12Parcelas";
            rb4a12Parcelas.Size = new Size(223, 19);
            rb4a12Parcelas.TabIndex = 2;
            rb4a12Parcelas.TabStop = true;
            rb4a12Parcelas.Text = "Entre 4 e 12 parcelas com juros de X%";
            rb4a12Parcelas.UseVisualStyleBackColor = true;
            // 
            // btnCalcularDesconto
            // 
            btnCalcularDesconto.Location = new Point(18, 226);
            btnCalcularDesconto.Name = "btnCalcularDesconto";
            btnCalcularDesconto.Size = new Size(115, 23);
            btnCalcularDesconto.TabIndex = 4;
            btnCalcularDesconto.Text = "Calcular Desconto";
            btnCalcularDesconto.UseVisualStyleBackColor = true;
            btnCalcularDesconto.Click += btnCalcularDesconto_Click;
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(161, 226);
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(100, 23);
            txtResultado.TabIndex = 5;
            // 
            // FormCalculoDesconto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(281, 267);
            Controls.Add(txtResultado);
            Controls.Add(btnCalcularDesconto);
            Controls.Add(gbParcelamento);
            Controls.Add(txtValorProduto);
            Controls.Add(lblParcelas);
            Controls.Add(lblValor);
            Name = "FormCalculoDesconto";
            Text = "FormCalculoDesconto";
            gbParcelamento.ResumeLayout(false);
            gbParcelamento.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        

        #endregion

        private Label lblValor;
        private Label lblParcelas;
        private TextBox txtValorProduto;
        private GroupBox gbParcelamento;
        private RadioButton rb4a12Parcelas;
        private RadioButton rbAte3Parcelas;
        private RadioButton rbAVista;
        private Button btnCalcularDesconto;
        private TextBox txtResultado;
    }
}