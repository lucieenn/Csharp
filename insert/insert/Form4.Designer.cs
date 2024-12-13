namespace insert
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            cbsexo = new ComboBox();
            mskdata = new MaskedTextBox();
            cbuf = new ComboBox();
            txtrg = new TextBox();
            mskcpf2 = new MaskedTextBox();
            txtnome = new TextBox();
            txtcodigo = new TextBox();
            btnlimpar = new Button();
            lblsexo = new Label();
            lbldata = new Label();
            lbluf = new Label();
            lblRG = new Label();
            lblcpf2 = new Label();
            lblnome = new Label();
            lblCodigo = new Label();
            lblatualizar = new Label();
            btnatualizar = new Button();
            mskCPFvalidar = new MaskedTextBox();
            lblpesquisar = new Label();
            btnPesquisar = new Button();
            SuspendLayout();
            // 
            // cbsexo
            // 
            cbsexo.FormattingEnabled = true;
            cbsexo.Items.AddRange(new object[] { "Masculino", "Feminino" });
            cbsexo.Location = new Point(75, 352);
            cbsexo.Name = "cbsexo";
            cbsexo.Size = new Size(100, 23);
            cbsexo.TabIndex = 32;
            cbsexo.Visible = false;
            // 
            // mskdata
            // 
            mskdata.Location = new Point(157, 317);
            mskdata.Mask = "00/00/0000";
            mskdata.Name = "mskdata";
            mskdata.Size = new Size(87, 23);
            mskdata.TabIndex = 31;
            mskdata.TextAlign = HorizontalAlignment.Center;
            mskdata.Visible = false;
            // 
            // cbuf
            // 
            cbuf.FormattingEnabled = true;
            cbuf.Items.AddRange(new object[] { "", "AC  ", "AL  ", "AP  ", "AM  ", "BA  ", "CE  ", "DF  ", "ES  ", "GO  ", "MA  ", "MT  ", "MS  ", "MG  ", "PA  ", "PB  ", "PR  ", "PE  ", "PI  ", "RJ  ", "RN  ", "RS  ", "RO  ", "RR  ", "SC  ", "SP  ", "SE  ", "TO  " });
            cbuf.Location = new Point(64, 269);
            cbuf.Name = "cbuf";
            cbuf.Size = new Size(121, 23);
            cbuf.TabIndex = 30;
            cbuf.Visible = false;
            // 
            // txtrg
            // 
            txtrg.Location = new Point(65, 233);
            txtrg.Name = "txtrg";
            txtrg.Size = new Size(100, 23);
            txtrg.TabIndex = 29;
            txtrg.Visible = false;
            // 
            // mskcpf2
            // 
            mskcpf2.Enabled = false;
            mskcpf2.Location = new Point(71, 192);
            mskcpf2.Mask = "000,000,000-00";
            mskcpf2.Name = "mskcpf2";
            mskcpf2.Size = new Size(100, 23);
            mskcpf2.TabIndex = 28;
            mskcpf2.TextAlign = HorizontalAlignment.Center;
            mskcpf2.Visible = false;
            // 
            // txtnome
            // 
            txtnome.Location = new Point(137, 153);
            txtnome.Name = "txtnome";
            txtnome.Size = new Size(100, 23);
            txtnome.TabIndex = 27;
            txtnome.Visible = false;
            // 
            // txtcodigo
            // 
            txtcodigo.Location = new Point(144, 119);
            txtcodigo.Name = "txtcodigo";
            txtcodigo.Size = new Size(100, 23);
            txtcodigo.TabIndex = 26;
            txtcodigo.Visible = false;
            // 
            // btnlimpar
            // 
            btnlimpar.Image = Properties.Resources.vassoura;
            btnlimpar.Location = new Point(270, 444);
            btnlimpar.Name = "btnlimpar";
            btnlimpar.Size = new Size(88, 83);
            btnlimpar.TabIndex = 24;
            btnlimpar.UseVisualStyleBackColor = true;
            btnlimpar.Visible = false;
            btnlimpar.Click += button3_Click;
            // 
            // lblsexo
            // 
            lblsexo.AutoSize = true;
            lblsexo.Location = new Point(34, 355);
            lblsexo.Name = "lblsexo";
            lblsexo.Size = new Size(35, 15);
            lblsexo.TabIndex = 23;
            lblsexo.Text = "Sexo:";
            lblsexo.Visible = false;
            // 
            // lbldata
            // 
            lbldata.AutoSize = true;
            lbldata.Location = new Point(34, 320);
            lbldata.Name = "lbldata";
            lbldata.Size = new Size(117, 15);
            lbldata.TabIndex = 22;
            lbldata.Text = "Data de Nascimento:";
            lbldata.Visible = false;
            // 
            // lbluf
            // 
            lbluf.AutoSize = true;
            lbluf.Location = new Point(34, 277);
            lbluf.Name = "lbluf";
            lbluf.Size = new Size(24, 15);
            lbluf.TabIndex = 21;
            lbluf.Text = "UF:";
            lbluf.Visible = false;
            // 
            // lblRG
            // 
            lblRG.AutoSize = true;
            lblRG.Location = new Point(34, 236);
            lblRG.Name = "lblRG";
            lblRG.Size = new Size(25, 15);
            lblRG.TabIndex = 20;
            lblRG.Text = "RG:";
            lblRG.Visible = false;
            // 
            // lblcpf2
            // 
            lblcpf2.AutoSize = true;
            lblcpf2.Location = new Point(34, 195);
            lblcpf2.Name = "lblcpf2";
            lblcpf2.Size = new Size(31, 15);
            lblcpf2.TabIndex = 19;
            lblcpf2.Text = "CPF:";
            lblcpf2.Visible = false;
            // 
            // lblnome
            // 
            lblnome.AutoSize = true;
            lblnome.Location = new Point(34, 161);
            lblnome.Name = "lblnome";
            lblnome.Size = new Size(97, 15);
            lblnome.TabIndex = 18;
            lblnome.Text = "Nome completo:";
            lblnome.Visible = false;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(34, 122);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(104, 15);
            lblCodigo.TabIndex = 17;
            lblCodigo.Text = "Código do cliente:";
            lblCodigo.Visible = false;
            // 
            // lblatualizar
            // 
            lblatualizar.AutoSize = true;
            lblatualizar.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblatualizar.Location = new Point(84, 54);
            lblatualizar.Name = "lblatualizar";
            lblatualizar.Size = new Size(323, 23);
            lblatualizar.TabIndex = 34;
            lblatualizar.Text = "Atualize seu cadastro abaixo:";
            lblatualizar.Visible = false;
            // 
            // btnatualizar
            // 
            btnatualizar.Image = (Image)resources.GetObject("btnatualizar.Image");
            btnatualizar.Location = new Point(156, 444);
            btnatualizar.Name = "btnatualizar";
            btnatualizar.Size = new Size(88, 83);
            btnatualizar.TabIndex = 35;
            btnatualizar.UseVisualStyleBackColor = true;
            btnatualizar.Visible = false;
            btnatualizar.Click += button1_Click;
            // 
            // mskCPFvalidar
            // 
            mskCPFvalidar.Location = new Point(200, 228);
            mskCPFvalidar.Mask = "000,000,000-00";
            mskCPFvalidar.Name = "mskCPFvalidar";
            mskCPFvalidar.Size = new Size(104, 23);
            mskCPFvalidar.TabIndex = 36;
            mskCPFvalidar.TextAlign = HorizontalAlignment.Center;
            // 
            // lblpesquisar
            // 
            lblpesquisar.AutoSize = true;
            lblpesquisar.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblpesquisar.Location = new Point(137, 195);
            lblpesquisar.Name = "lblpesquisar";
            lblpesquisar.Size = new Size(262, 20);
            lblpesquisar.TabIndex = 37;
            lblpesquisar.Text = "Digite o CPF do seu cadastro:";
            // 
            // btnPesquisar
            // 
            btnPesquisar.Location = new Point(200, 270);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(104, 28);
            btnPesquisar.TabIndex = 38;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(508, 552);
            Controls.Add(btnPesquisar);
            Controls.Add(lblpesquisar);
            Controls.Add(mskCPFvalidar);
            Controls.Add(btnatualizar);
            Controls.Add(lblatualizar);
            Controls.Add(cbsexo);
            Controls.Add(mskdata);
            Controls.Add(cbuf);
            Controls.Add(txtrg);
            Controls.Add(mskcpf2);
            Controls.Add(txtnome);
            Controls.Add(txtcodigo);
            Controls.Add(btnlimpar);
            Controls.Add(lblsexo);
            Controls.Add(lbldata);
            Controls.Add(lbluf);
            Controls.Add(lblRG);
            Controls.Add(lblcpf2);
            Controls.Add(lblnome);
            Controls.Add(lblCodigo);
            Name = "Form4";
            Text = "Atualizar cadastro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnCpf;
        private Button button2;
        private Button BtnRG;
        private Button BtnUf;
        private Button btnDataNasc;
        private Button btnSexo;
        private Label lblNovo;
        private TextBox txtNovo;
        private Label lblcpf;
        private Button btnAtualizar;
        private MaskedTextBox mskcpf;
        private ComboBox cbsexo;
        private MaskedTextBox mskdata;
        private ComboBox cbuf;
        private TextBox txtrg;
        private MaskedTextBox maskedTextBox1;
        private TextBox txtnome;
        private TextBox txtcodigo;
        private Button btnlimpar;
        private Label lblsexo;
        private Label lbldata;
        private Label lbluf;
        private Label lblRG;
        private Label label2;
        private Label lblnome;
        private Label lblCodigo;
        private Label lblatualizar;
        private Button btnatualizar;
        private MaskedTextBox mskCPFvalidar;
        private Label lblpesquisar;
        private Button btnPesquisar;
        private MaskedTextBox mskcpf2;
        private Label lblcpf2;
    }
}