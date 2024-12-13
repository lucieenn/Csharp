namespace insert
{
    partial class Form3
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
            lblPesquisa = new Label();
            label1 = new Label();
            mskCPF = new MaskedTextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // lblPesquisa
            // 
            lblPesquisa.AutoSize = true;
            lblPesquisa.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPesquisa.Location = new Point(58, 23);
            lblPesquisa.Name = "lblPesquisa";
            lblPesquisa.Size = new Size(375, 20);
            lblPesquisa.TabIndex = 0;
            lblPesquisa.Text = "Você deseja informações de um cadastro?";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(122, 79);
            label1.Name = "label1";
            label1.Size = new Size(88, 15);
            label1.TabIndex = 1;
            label1.Text = "Digite o CPF:";
            // 
            // mskCPF
            // 
            mskCPF.Location = new Point(216, 77);
            mskCPF.Mask = "000,000,000-00";
            mskCPF.Name = "mskCPF";
            mskCPF.Size = new Size(100, 23);
            mskCPF.TabIndex = 2;
            mskCPF.TextAlign = HorizontalAlignment.Center;
            // 
            // button1
            // 
            button1.Location = new Point(196, 146);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(509, 181);
            Controls.Add(button1);
            Controls.Add(mskCPF);
            Controls.Add(label1);
            Controls.Add(lblPesquisa);
            Name = "Form3";
            Text = "Pesquisar Cadastro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPesquisa;
        private Label label1;
        private MaskedTextBox mskCPF;
        private Button button1;
    }
}