namespace Atividade_9___Calculadora_de_Preferências_de_Viagem
{
    partial class FormDestino
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblDestino = new Label();
            gbDestino = new GroupBox();
            rbPraia = new RadioButton();
            rbMontanha = new RadioButton();
            rbCidade = new RadioButton();
            btnConfirmar = new Button();
            gbDestino.SuspendLayout();
            SuspendLayout();
            // 
            // lblDestino
            // 
            lblDestino.AutoSize = true;
            lblDestino.Location = new Point(11, 12);
            lblDestino.Name = "lblDestino";
            lblDestino.Size = new Size(174, 15);
            lblDestino.TabIndex = 0;
            lblDestino.Text = "Escolha o seu destino preferido:";
            // 
            // gbDestino
            // 
            gbDestino.Controls.Add(rbCidade);
            gbDestino.Controls.Add(rbMontanha);
            gbDestino.Controls.Add(rbPraia);
            gbDestino.Location = new Point(12, 30);
            gbDestino.Name = "gbDestino";
            gbDestino.Size = new Size(173, 131);
            gbDestino.TabIndex = 1;
            gbDestino.TabStop = false;
            gbDestino.Text = "Destino";
            gbDestino.Enter += groupBox1_Enter;
            // 
            // rbPraia
            // 
            rbPraia.AutoSize = true;
            rbPraia.Location = new Point(10, 22);
            rbPraia.Name = "rbPraia";
            rbPraia.Size = new Size(51, 19);
            rbPraia.TabIndex = 0;
            rbPraia.TabStop = true;
            rbPraia.Text = "Praia";
            rbPraia.UseVisualStyleBackColor = true;
            // 
            // rbMontanha
            // 
            rbMontanha.AutoSize = true;
            rbMontanha.Location = new Point(10, 56);
            rbMontanha.Name = "rbMontanha";
            rbMontanha.Size = new Size(80, 19);
            rbMontanha.TabIndex = 1;
            rbMontanha.TabStop = true;
            rbMontanha.Text = "Montanha";
            rbMontanha.UseVisualStyleBackColor = true;
            // 
            // rbCidade
            // 
            rbCidade.AutoSize = true;
            rbCidade.Location = new Point(10, 91);
            rbCidade.Name = "rbCidade";
            rbCidade.Size = new Size(62, 19);
            rbCidade.TabIndex = 2;
            rbCidade.TabStop = true;
            rbCidade.Text = "Cidade";
            rbCidade.UseVisualStyleBackColor = true;
            rbCidade.CheckedChanged += rbCidade_CheckedChanged;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(55, 167);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(75, 23);
            btnConfirmar.TabIndex = 2;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // FormDestino
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(201, 216);
            Controls.Add(btnConfirmar);
            Controls.Add(gbDestino);
            Controls.Add(lblDestino);
            Name = "FormDestino";
            Text = "FormDestino";
            gbDestino.ResumeLayout(false);
            gbDestino.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDestino;
        private GroupBox gbDestino;
        private RadioButton rbCidade;
        private RadioButton rbMontanha;
        private RadioButton rbPraia;
        private Button btnConfirmar;
    }
}