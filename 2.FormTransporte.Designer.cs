namespace Atividade_9___Calculadora_de_Preferências_de_Viagem
{
    partial class FormTransporte
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
            lblTransporte = new Label();
            gbTransporte = new GroupBox();
            cbCarro = new CheckBox();
            cbAviao = new CheckBox();
            cbTrem = new CheckBox();
            btnConfirmarTransporte = new Button();
            txtTransporteResultado = new TextBox();
            gbTransporte.SuspendLayout();
            SuspendLayout();
            // 
            // lblTransporte
            // 
            lblTransporte.AutoSize = true;
            lblTransporte.Location = new Point(5, 8);
            lblTransporte.Name = "lblTransporte";
            lblTransporte.Size = new Size(183, 15);
            lblTransporte.TabIndex = 0;
            lblTransporte.Text = "Selecione os meios de transporte:";
           
            // 
            // gbTransporte
            // 
            gbTransporte.Controls.Add(cbTrem);
            gbTransporte.Controls.Add(cbAviao);
            gbTransporte.Controls.Add(cbCarro);
            gbTransporte.Location = new Point(5, 26);
            gbTransporte.Name = "gbTransporte";
            gbTransporte.Size = new Size(223, 149);
            gbTransporte.TabIndex = 1;
            gbTransporte.TabStop = false;
            gbTransporte.Text = "Transporte";
            // 
            // cbCarro
            // 
            cbCarro.AutoSize = true;
            cbCarro.Location = new Point(24, 36);
            cbCarro.Name = "cbCarro";
            cbCarro.Size = new Size(55, 19);
            cbCarro.TabIndex = 0;
            cbCarro.Text = "Carro";
            cbCarro.UseVisualStyleBackColor = true;
            // 
            // cbAviao
            // 
            cbAviao.AutoSize = true;
            cbAviao.Location = new Point(24, 74);
            cbAviao.Name = "cbAviao";
            cbAviao.Size = new Size(56, 19);
            cbAviao.TabIndex = 1;
            cbAviao.Text = "Avião";
            cbAviao.UseVisualStyleBackColor = true;
            // 
            // cbTrem
            // 
            cbTrem.AutoSize = true;
            cbTrem.Location = new Point(24, 113);
            cbTrem.Name = "cbTrem";
            cbTrem.Size = new Size(52, 19);
            cbTrem.TabIndex = 2;
            cbTrem.Text = "Trem";
            cbTrem.UseVisualStyleBackColor = true;
            // 
            // btnConfirmarTransporte
            // 
            btnConfirmarTransporte.Location = new Point(22, 218);
            btnConfirmarTransporte.Name = "btnConfirmarTransporte";
            btnConfirmarTransporte.Size = new Size(75, 23);
            btnConfirmarTransporte.TabIndex = 2;
            btnConfirmarTransporte.Text = "Confirmar";
            btnConfirmarTransporte.UseVisualStyleBackColor = true;
            btnConfirmarTransporte.Click += btnConfirmarTransporte_Click;
            // 
            // txtTransporteResultado
            // 
            txtTransporteResultado.Location = new Point(128, 218);
            txtTransporteResultado.Name = "txtTransporteResultado";
            txtTransporteResultado.Size = new Size(100, 23);
            txtTransporteResultado.TabIndex = 3;
            txtTransporteResultado.TextChanged += txtTransporteResultado_TextChanged;
            // 
            // FormTransporte
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(260, 257);
            Controls.Add(txtTransporteResultado);
            Controls.Add(btnConfirmarTransporte);
            Controls.Add(gbTransporte);
            Controls.Add(lblTransporte);
            Name = "FormTransporte";
            Text = "FormTransporte";
            gbTransporte.ResumeLayout(false);
            gbTransporte.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTransporte;
        private GroupBox gbTransporte;
        private CheckBox cbTrem;
        private CheckBox cbAviao;
        private CheckBox cbCarro;
        private Button btnConfirmarTransporte;
        private TextBox txtTransporteResultado;
    }
}