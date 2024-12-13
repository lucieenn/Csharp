namespace insert
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lblConexão = new Label();
            lblCodigo = new Label();
            lblnome = new Label();
            lblcpf = new Label();
            lblRG = new Label();
            lbluf = new Label();
            lbldata = new Label();
            lblsexo = new Label();
            button1 = new Button();
            button2 = new Button();
            txtcodigo = new TextBox();
            txtnome = new TextBox();
            mskcpf = new MaskedTextBox();
            txtrg = new TextBox();
            cbuf = new ComboBox();
            mskdata = new MaskedTextBox();
            cbsexo = new ComboBox();
            menuStrip1 = new MenuStrip();
            ajustesToolStripMenuItem = new ToolStripMenuItem();
            pesquisarToolStripMenuItem = new ToolStripMenuItem();
            excluirCadastroToolStripMenuItem = new ToolStripMenuItem();
            atualizarCadastroToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // lblConexão
            // 
            lblConexão.AutoSize = true;
            lblConexão.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblConexão.Location = new Point(200, 46);
            lblConexão.Name = "lblConexão";
            lblConexão.Size = new Size(192, 20);
            lblConexão.TabIndex = 0;
            lblConexão.Text = "Cadastro de clientes";
            lblConexão.Click += lblConexão_Click;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(27, 93);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(104, 15);
            lblCodigo.TabIndex = 1;
            lblCodigo.Text = "Código do cliente:";
            // 
            // lblnome
            // 
            lblnome.AutoSize = true;
            lblnome.Location = new Point(27, 132);
            lblnome.Name = "lblnome";
            lblnome.Size = new Size(97, 15);
            lblnome.TabIndex = 2;
            lblnome.Text = "Nome completo:";
            // 
            // lblcpf
            // 
            lblcpf.AutoSize = true;
            lblcpf.Location = new Point(27, 166);
            lblcpf.Name = "lblcpf";
            lblcpf.Size = new Size(31, 15);
            lblcpf.TabIndex = 3;
            lblcpf.Text = "CPF:";
            // 
            // lblRG
            // 
            lblRG.AutoSize = true;
            lblRG.Location = new Point(27, 207);
            lblRG.Name = "lblRG";
            lblRG.Size = new Size(25, 15);
            lblRG.TabIndex = 4;
            lblRG.Text = "RG:";
            // 
            // lbluf
            // 
            lbluf.AutoSize = true;
            lbluf.Location = new Point(27, 248);
            lbluf.Name = "lbluf";
            lbluf.Size = new Size(24, 15);
            lbluf.TabIndex = 5;
            lbluf.Text = "UF:";
            // 
            // lbldata
            // 
            lbldata.AutoSize = true;
            lbldata.Location = new Point(27, 291);
            lbldata.Name = "lbldata";
            lbldata.Size = new Size(117, 15);
            lbldata.TabIndex = 6;
            lbldata.Text = "Data de Nascimento:";
            lbldata.Click += label5_Click;
            // 
            // lblsexo
            // 
            lblsexo.AutoSize = true;
            lblsexo.Location = new Point(27, 326);
            lblsexo.Name = "lblsexo";
            lblsexo.Size = new Size(35, 15);
            lblsexo.TabIndex = 7;
            lblsexo.Text = "Sexo:";
            // 
            // button1
            // 
            button1.Image = Properties.Resources.vassoura;
            button1.Location = new Point(328, 372);
            button1.Name = "button1";
            button1.Size = new Size(88, 83);
            button1.TabIndex = 8;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(200, 372);
            button2.Name = "button2";
            button2.Size = new Size(88, 83);
            button2.TabIndex = 9;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // txtcodigo
            // 
            txtcodigo.Location = new Point(137, 90);
            txtcodigo.Name = "txtcodigo";
            txtcodigo.Size = new Size(100, 23);
            txtcodigo.TabIndex = 10;
            txtcodigo.UseWaitCursor = true;
            // 
            // txtnome
            // 
            txtnome.Location = new Point(130, 129);
            txtnome.Name = "txtnome";
            txtnome.Size = new Size(100, 23);
            txtnome.TabIndex = 11;
            // 
            // mskcpf
            // 
            mskcpf.Location = new Point(64, 163);
            mskcpf.Mask = "000,000,000-00";
            mskcpf.Name = "mskcpf";
            mskcpf.Size = new Size(100, 23);
            mskcpf.TabIndex = 12;
            mskcpf.TextAlign = HorizontalAlignment.Center;
            // 
            // txtrg
            // 
            txtrg.Location = new Point(58, 204);
            txtrg.Name = "txtrg";
            txtrg.Size = new Size(100, 23);
            txtrg.TabIndex = 13;
            // 
            // cbuf
            // 
            cbuf.DropDownStyle = ComboBoxStyle.DropDownList;
            cbuf.FormattingEnabled = true;
            cbuf.Items.AddRange(new object[] { "", "AC  ", "AL  ", "AP  ", "AM  ", "BA  ", "CE  ", "DF  ", "ES  ", "GO  ", "MA  ", "MT  ", "MS  ", "MG  ", "PA  ", "PB  ", "PR  ", "PE  ", "PI  ", "RJ  ", "RN  ", "RS  ", "RO  ", "RR  ", "SC  ", "SP  ", "SE  ", "TO  " });
            cbuf.Location = new Point(57, 240);
            cbuf.Name = "cbuf";
            cbuf.Size = new Size(121, 23);
            cbuf.TabIndex = 14;
            // 
            // mskdata
            // 
            mskdata.Location = new Point(150, 288);
            mskdata.Mask = "00/00/0000";
            mskdata.Name = "mskdata";
            mskdata.Size = new Size(87, 23);
            mskdata.TabIndex = 15;
            mskdata.TextAlign = HorizontalAlignment.Center;
            // 
            // cbsexo
            // 
            cbsexo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbsexo.FormattingEnabled = true;
            cbsexo.Items.AddRange(new object[] { "Masculino", "Feminino" });
            cbsexo.Location = new Point(68, 323);
            cbsexo.Name = "cbsexo";
            cbsexo.Size = new Size(100, 23);
            cbsexo.TabIndex = 16;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Cyan;
            menuStrip1.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            menuStrip1.Items.AddRange(new ToolStripItem[] { ajustesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(610, 25);
            menuStrip1.TabIndex = 22;
            menuStrip1.Text = "menuStrip1";
            // 
            // ajustesToolStripMenuItem
            // 
            ajustesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { pesquisarToolStripMenuItem, excluirCadastroToolStripMenuItem, atualizarCadastroToolStripMenuItem });
            ajustesToolStripMenuItem.Name = "ajustesToolStripMenuItem";
            ajustesToolStripMenuItem.Size = new Size(57, 20);
            ajustesToolStripMenuItem.Text = "Ajustes";
            // 
            // pesquisarToolStripMenuItem
            // 
            pesquisarToolStripMenuItem.Name = "pesquisarToolStripMenuItem";
            pesquisarToolStripMenuItem.Size = new Size(180, 22);
            pesquisarToolStripMenuItem.Text = "Pesquisar";
            pesquisarToolStripMenuItem.Click += pesquisarToolStripMenuItem_Click;
            // 
            // excluirCadastroToolStripMenuItem
            // 
            excluirCadastroToolStripMenuItem.Name = "excluirCadastroToolStripMenuItem";
            excluirCadastroToolStripMenuItem.Size = new Size(180, 22);
            excluirCadastroToolStripMenuItem.Text = "Excluir cadastro";
            excluirCadastroToolStripMenuItem.Click += excluirCadastroToolStripMenuItem_Click;
            // 
            // atualizarCadastroToolStripMenuItem
            // 
            atualizarCadastroToolStripMenuItem.Name = "atualizarCadastroToolStripMenuItem";
            atualizarCadastroToolStripMenuItem.Size = new Size(180, 22);
            atualizarCadastroToolStripMenuItem.Text = "Atualizar cadastro";
            atualizarCadastroToolStripMenuItem.Click += atualizarCadastroToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.Cyan;
            ClientSize = new Size(610, 467);
            Controls.Add(cbsexo);
            Controls.Add(mskdata);
            Controls.Add(cbuf);
            Controls.Add(txtrg);
            Controls.Add(mskcpf);
            Controls.Add(txtnome);
            Controls.Add(txtcodigo);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(lblsexo);
            Controls.Add(lbldata);
            Controls.Add(lbluf);
            Controls.Add(lblRG);
            Controls.Add(lblcpf);
            Controls.Add(lblnome);
            Controls.Add(lblCodigo);
            Controls.Add(lblConexão);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Cadastro";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblConexão;
        private Label lblCodigo;
        private Label lblnome;
        private Label lblcpf;
        private Label lblRG;
        private Label lbluf;
        private Label lbldata;
        private Label lblsexo;
        private Button button1;
        private Button button2;
        private TextBox txtcodigo;
        private TextBox txtnome;
        private MaskedTextBox mskcpf;
        private ComboBox cbuf;
        private MaskedTextBox mskdata;
        private ComboBox cbsexo;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem ajustesToolStripMenuItem;
        private ToolStripMenuItem pesquisarToolStripMenuItem;
        private ToolStripMenuItem excluirCadastroToolStripMenuItem;
        private ToolStripMenuItem atualizarCadastroToolStripMenuItem;
        internal TextBox txtrg;
    }
}