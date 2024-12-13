namespace insert
{
    partial class Form2
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
            mskCpfCliente = new MaskedTextBox();
            btnConfirmar = new Button();
            lblCpfCliente = new Label();
            lblCadastro = new Label();
            SuspendLayout();
            // 
            // mskCpfCliente
            // 
            mskCpfCliente.Location = new Point(122, 103);
            mskCpfCliente.Mask = "000,000,000-00";
            mskCpfCliente.Name = "mskCpfCliente";
            mskCpfCliente.Size = new Size(125, 23);
            mskCpfCliente.TabIndex = 22;
            mskCpfCliente.TextAlign = HorizontalAlignment.Center;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(122, 179);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(98, 23);
            btnConfirmar.TabIndex = 21;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // lblCpfCliente
            // 
            lblCpfCliente.AutoSize = true;
            lblCpfCliente.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblCpfCliente.Location = new Point(12, 105);
            lblCpfCliente.Name = "lblCpfCliente";
            lblCpfCliente.Size = new Size(104, 15);
            lblCpfCliente.TabIndex = 19;
            lblCpfCliente.Text = "CPF do cliente:";
            // 
            // lblCadastro
            // 
            lblCadastro.AutoSize = true;
            lblCadastro.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblCadastro.Location = new Point(90, 33);
            lblCadastro.Name = "lblCadastro";
            lblCadastro.Size = new Size(211, 15);
            lblCadastro.TabIndex = 18;
            lblCadastro.Text = "Você deseja apagar o cadastro?";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(349, 252);
            Controls.Add(lblCadastro);
            Controls.Add(lblCpfCliente);
            Controls.Add(mskCpfCliente);
            Controls.Add(btnConfirmar);
            Name = "Form2";
            Text = "Excluir Cadastro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox mskCpfCliente;
        private Button btnConfirmar;
        private Label lblCpfCliente;
        private Label lblCadastro;
    }
}