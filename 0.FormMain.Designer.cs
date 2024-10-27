namespace Atividade_9___Calculadora_de_Preferências_de_Viagem
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnDestino = new Button();
            btnTransporte = new Button();
            btnInformacoes = new Button();
            btnCalculoDesconto = new Button();
            SuspendLayout();
            // 
            // btnDestino
            // 
            btnDestino.Location = new Point(89, 22);
            btnDestino.Name = "btnDestino";
            btnDestino.Size = new Size(75, 23);
            btnDestino.TabIndex = 0;
            btnDestino.Text = "Destino";
            btnDestino.UseVisualStyleBackColor = true;
            btnDestino.Click += btnDestino_Click;
            // 
            // btnTransporte
            // 
            btnTransporte.Location = new Point(89, 81);
            btnTransporte.Name = "btnTransporte";
            btnTransporte.Size = new Size(75, 23);
            btnTransporte.TabIndex = 1;
            btnTransporte.Text = "Transporte";
            btnTransporte.UseVisualStyleBackColor = true;
            btnTransporte.Click += btnTransporte_Click_1;
            // 
            // btnInformacoes
            // 
            btnInformacoes.Location = new Point(60, 141);
            btnInformacoes.Name = "btnInformacoes";
            btnInformacoes.Size = new Size(131, 23);
            btnInformacoes.TabIndex = 2;
            btnInformacoes.Text = "Informações Pessoais";
            btnInformacoes.UseVisualStyleBackColor = true;
            btnInformacoes.Click += btnInformacoes_Click_1;
            // 
            // btnCalculoDesconto
            // 
            btnCalculoDesconto.Location = new Point(60, 201);
            btnCalculoDesconto.Name = "btnCalculoDesconto";
            btnCalculoDesconto.Size = new Size(131, 23);
            btnCalculoDesconto.TabIndex = 3;
            btnCalculoDesconto.Text = "Cálculo de Desconto";
            btnCalculoDesconto.UseVisualStyleBackColor = true;
            btnCalculoDesconto.Click += btnCalculoDesconto_Click_1;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(269, 251);
            Controls.Add(btnCalculoDesconto);
            Controls.Add(btnInformacoes);
            Controls.Add(btnTransporte);
            Controls.Add(btnDestino);
            Name = "FormMain";
            Text = "FormMain";
            ResumeLayout(false);
        }

        #endregion

        private Button btnDestino;
        private Button btnTransporte;
        private Button btnInformacoes;
        private Button btnCalculoDesconto;
    }
}
