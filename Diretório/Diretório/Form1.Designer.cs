namespace Diretório
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
            lblCaminho = new Label();
            txtCaminho = new TextBox();
            lblConteúdo = new Label();
            btnAbrir = new Button();
            btnSalvar = new Button();
            groupBox1 = new GroupBox();
            btnCriar = new Button();
            txtCaminho2 = new TextBox();
            lblCaminho2 = new Label();
            openFileDialog1 = new OpenFileDialog();
            txtConteudo = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lblCaminho
            // 
            lblCaminho.AutoSize = true;
            lblCaminho.Location = new Point(25, 24);
            lblCaminho.Name = "lblCaminho";
            lblCaminho.Size = new Size(59, 15);
            lblCaminho.TabIndex = 0;
            lblCaminho.Text = "Caminho:";
            // 
            // txtCaminho
            // 
            txtCaminho.Location = new Point(100, 21);
            txtCaminho.Name = "txtCaminho";
            txtCaminho.Size = new Size(328, 23);
            txtCaminho.TabIndex = 1;
            txtCaminho.TextChanged += txtCaminho_TextChanged;
            // 
            // lblConteúdo
            // 
            lblConteúdo.AutoSize = true;
            lblConteúdo.Location = new Point(25, 67);
            lblConteúdo.Name = "lblConteúdo";
            lblConteúdo.Size = new Size(63, 15);
            lblConteúdo.TabIndex = 2;
            lblConteúdo.Text = "Conteúdo:";
            // 
            // btnAbrir
            // 
            btnAbrir.Location = new Point(157, 271);
            btnAbrir.Name = "btnAbrir";
            btnAbrir.Size = new Size(75, 23);
            btnAbrir.TabIndex = 4;
            btnAbrir.Text = "Abrir TXT";
            btnAbrir.UseVisualStyleBackColor = true;
            btnAbrir.Click += btnAbrir_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(288, 271);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 5;
            btnSalvar.Text = "Salvar TXT";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click_1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnCriar);
            groupBox1.Controls.Add(txtCaminho2);
            groupBox1.Controls.Add(lblCaminho2);
            groupBox1.Location = new Point(450, 24);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(347, 169);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // btnCriar
            // 
            btnCriar.Location = new Point(135, 123);
            btnCriar.Name = "btnCriar";
            btnCriar.Size = new Size(75, 23);
            btnCriar.TabIndex = 2;
            btnCriar.Text = "Criar";
            btnCriar.UseVisualStyleBackColor = true;
            btnCriar.Click += btnCriar_Click_1;
            // 
            // txtCaminho2
            // 
            txtCaminho2.Location = new Point(83, 51);
            txtCaminho2.Name = "txtCaminho2";
            txtCaminho2.Size = new Size(243, 23);
            txtCaminho2.TabIndex = 1;
            // 
            // lblCaminho2
            // 
            lblCaminho2.AutoSize = true;
            lblCaminho2.Location = new Point(18, 54);
            lblCaminho2.Name = "lblCaminho2";
            lblCaminho2.Size = new Size(59, 15);
            lblCaminho2.TabIndex = 0;
            lblCaminho2.Text = "Caminho:";
            // 
            // openFileDialog1
            // 
            openFileDialog1.DefaultExt = "*.txt";
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.InitialDirectory = "D:\\AulaCSharp";
            openFileDialog1.FileOk += openFileDialog1_FileOk;
            // 
            // txtConteudo
            // 
            txtConteudo.Location = new Point(100, 67);
            txtConteudo.Multiline = true;
            txtConteudo.Name = "txtConteudo";
            txtConteudo.Size = new Size(328, 181);
            txtConteudo.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(831, 333);
            Controls.Add(txtConteudo);
            Controls.Add(groupBox1);
            Controls.Add(btnSalvar);
            Controls.Add(btnAbrir);
            Controls.Add(lblConteúdo);
            Controls.Add(txtCaminho);
            Controls.Add(lblCaminho);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCaminho;
        private TextBox txtCaminho;
        private Label lblConteúdo;
        private Button btnAbrir;
        private Button btnSalvar;
        private GroupBox groupBox1;
        private Label lblCaminho2;
        private TextBox txtCaminho2;
        private Button btnCriar;
        private OpenFileDialog openFileDialog1;
        private TextBox txtConteudo;
    }
}
