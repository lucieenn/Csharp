namespace ProgressBar
{
    partial class Form1
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
            lblInsiraNumero = new Label();
            lblNumero = new Label();
            prgNumeros = new RichTextBox();
            progressBar1 = new System.Windows.Forms.ProgressBar();
            btnOk = new Button();
            textBox1 = new TextBox();
            lblNmrPorcent = new Label();
            SuspendLayout();
            // 
            // lblInsiraNumero
            // 
            lblInsiraNumero.AutoSize = true;
            lblInsiraNumero.Location = new Point(122, 24);
            lblInsiraNumero.Name = "lblInsiraNumero";
            lblInsiraNumero.Size = new Size(100, 15);
            lblInsiraNumero.TabIndex = 0;
            lblInsiraNumero.Text = "Insira 10 números";
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(12, 91);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(51, 15);
            lblNumero.TabIndex = 1;
            lblNumero.Text = "Número";
            lblNumero.Click += lblNumero_Click;
            // 
            // prgNumeros
            // 
            prgNumeros.Location = new Point(212, 91);
            prgNumeros.Name = "prgNumeros";
            prgNumeros.Size = new Size(118, 168);
            prgNumeros.TabIndex = 2;
            prgNumeros.Text = "";
            prgNumeros.TextChanged += prgNumeros_TextChanged;
            // 
            // progressBar1
            // 
            progressBar1.Dock = DockStyle.Bottom;
            progressBar1.Location = new Point(0, 292);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(360, 26);
            progressBar1.TabIndex = 3;
            progressBar1.Click += progressBar1_Click;
            // 
            // btnOk
            // 
            btnOk.Location = new Point(69, 189);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(75, 23);
            btnOk.TabIndex = 5;
            btnOk.Text = "OK";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(69, 88);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 6;
            // 
            // lblNmrPorcent
            // 
            lblNmrPorcent.AutoSize = true;
            lblNmrPorcent.Location = new Point(163, 294);
            lblNmrPorcent.Name = "lblNmrPorcent";
            lblNmrPorcent.Size = new Size(23, 15);
            lblNmrPorcent.TabIndex = 7;
            lblNmrPorcent.Text = "0%";
            lblNmrPorcent.Click += lblNmrPorcent_Click;
            // 
            // Form1
            // 
            AcceptButton = btnOk;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(360, 318);
            Controls.Add(lblNmrPorcent);
            Controls.Add(textBox1);
            Controls.Add(btnOk);
            Controls.Add(progressBar1);
            Controls.Add(prgNumeros);
            Controls.Add(lblNumero);
            Controls.Add(lblInsiraNumero);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblInsiraNumero;
        private Label lblNumero;
        private RichTextBox prgNumeros;
        private System.Windows.Forms.ProgressBar progressBar1;
        private Button btnOk;
        private TextBox textBox1;
        private Label lblNmrPorcent;
    }
}