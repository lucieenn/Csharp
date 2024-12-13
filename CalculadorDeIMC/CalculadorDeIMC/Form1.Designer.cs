namespace CalculadorDeIMC
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
            menuStrip1 = new MenuStrip();
            sairToolStripMenuItem = new ToolStripMenuItem();
            arquivoToolStripMenuItem = new ToolStripMenuItem();
            calcularToolStripMenuItem = new ToolStripMenuItem();
            limparToolStripMenuItem = new ToolStripMenuItem();
            sobreToolStripMenuItem = new ToolStripMenuItem();
            lblAltura = new Label();
            lblPeso = new Label();
            lblKg = new Label();
            lblMetros = new Label();
            lblSexo = new Label();
            RadioBtnFem = new RadioButton();
            RadioBtnMasc = new RadioButton();
            lblPesoIdeal = new Label();
            lblIMC = new Label();
            pBox = new PictureBox();
            btnCalcular = new Button();
            txtAltura = new TextBox();
            txtPeso = new TextBox();
            sobreToolStripMenuItem1 = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pBox).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { sairToolStripMenuItem, arquivoToolStripMenuItem, sobreToolStripMenuItem, sobreToolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(594, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(38, 20);
            sairToolStripMenuItem.Text = "Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // arquivoToolStripMenuItem
            // 
            arquivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { calcularToolStripMenuItem, limparToolStripMenuItem });
            arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            arquivoToolStripMenuItem.Size = new Size(61, 20);
            arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // calcularToolStripMenuItem
            // 
            calcularToolStripMenuItem.Name = "calcularToolStripMenuItem";
            calcularToolStripMenuItem.Size = new Size(180, 22);
            calcularToolStripMenuItem.Text = "Calcular";
            calcularToolStripMenuItem.Click += calcularToolStripMenuItem_Click;
            // 
            // limparToolStripMenuItem
            // 
            limparToolStripMenuItem.Name = "limparToolStripMenuItem";
            limparToolStripMenuItem.Size = new Size(180, 22);
            limparToolStripMenuItem.Text = "Limpar";
            limparToolStripMenuItem.Click += limparToolStripMenuItem_Click;
            // 
            // sobreToolStripMenuItem
            // 
            sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            sobreToolStripMenuItem.Size = new Size(12, 20);
            // 
            // lblAltura
            // 
            lblAltura.AutoSize = true;
            lblAltura.Location = new Point(34, 73);
            lblAltura.Name = "lblAltura";
            lblAltura.Size = new Size(42, 15);
            lblAltura.TabIndex = 1;
            lblAltura.Text = "Altura:";
            // 
            // lblPeso
            // 
            lblPeso.AutoSize = true;
            lblPeso.Location = new Point(34, 110);
            lblPeso.Name = "lblPeso";
            lblPeso.Size = new Size(35, 15);
            lblPeso.TabIndex = 2;
            lblPeso.Text = "Peso:";
            // 
            // lblKg
            // 
            lblKg.AutoSize = true;
            lblKg.Location = new Point(145, 110);
            lblKg.Name = "lblKg";
            lblKg.Size = new Size(75, 15);
            lblKg.TabIndex = 5;
            lblKg.Text = "Quilogramas";
            // 
            // lblMetros
            // 
            lblMetros.AutoSize = true;
            lblMetros.Location = new Point(145, 73);
            lblMetros.Name = "lblMetros";
            lblMetros.Size = new Size(44, 15);
            lblMetros.TabIndex = 6;
            lblMetros.Text = "Metros";
            // 
            // lblSexo
            // 
            lblSexo.AutoSize = true;
            lblSexo.Location = new Point(34, 167);
            lblSexo.Name = "lblSexo";
            lblSexo.Size = new Size(35, 15);
            lblSexo.TabIndex = 7;
            lblSexo.Text = "Sexo:";
            lblSexo.Click += lblSexo_Click;
            // 
            // RadioBtnFem
            // 
            RadioBtnFem.AutoSize = true;
            RadioBtnFem.Location = new Point(75, 165);
            RadioBtnFem.Name = "RadioBtnFem";
            RadioBtnFem.Size = new Size(75, 19);
            RadioBtnFem.TabIndex = 8;
            RadioBtnFem.TabStop = true;
            RadioBtnFem.Text = "Feminino";
            RadioBtnFem.UseVisualStyleBackColor = true;
            RadioBtnFem.CheckedChanged += RadioBtnFem_CheckedChanged;
            // 
            // RadioBtnMasc
            // 
            RadioBtnMasc.AutoSize = true;
            RadioBtnMasc.Location = new Point(156, 165);
            RadioBtnMasc.Name = "RadioBtnMasc";
            RadioBtnMasc.Size = new Size(80, 19);
            RadioBtnMasc.TabIndex = 9;
            RadioBtnMasc.TabStop = true;
            RadioBtnMasc.Text = "Masculino";
            RadioBtnMasc.UseVisualStyleBackColor = true;
            RadioBtnMasc.CheckedChanged += RadioBtnMasc_CheckedChanged;
            // 
            // lblPesoIdeal
            // 
            lblPesoIdeal.AutoSize = true;
            lblPesoIdeal.Font = new Font("Britannic Bold", 36F, FontStyle.Regular, GraphicsUnit.Point);
            lblPesoIdeal.ForeColor = Color.SteelBlue;
            lblPesoIdeal.Location = new Point(64, 307);
            lblPesoIdeal.Name = "lblPesoIdeal";
            lblPesoIdeal.Size = new Size(125, 53);
            lblPesoIdeal.TabIndex = 10;
            lblPesoIdeal.Text = "Peso";
            lblPesoIdeal.Click += lblPesoIdeal_Click;
            // 
            // lblIMC
            // 
            lblIMC.AutoSize = true;
            lblIMC.Font = new Font("Britannic Bold", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblIMC.ForeColor = Color.LightSkyBlue;
            lblIMC.Location = new Point(167, 382);
            lblIMC.Name = "lblIMC";
            lblIMC.Size = new Size(78, 41);
            lblIMC.TabIndex = 11;
            lblIMC.Text = "IMC";
            // 
            // pBox
            // 
            pBox.Location = new Point(242, 49);
            pBox.Name = "pBox";
            pBox.Size = new Size(340, 236);
            pBox.SizeMode = PictureBoxSizeMode.Zoom;
            pBox.TabIndex = 12;
            pBox.TabStop = false;
            pBox.Click += pictureBox1_Click;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(84, 212);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 15;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click_1;
            // 
            // txtAltura
            // 
            txtAltura.Location = new Point(79, 70);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(60, 23);
            txtAltura.TabIndex = 16;
            // 
            // txtPeso
            // 
            txtPeso.Location = new Point(79, 107);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(60, 23);
            txtPeso.TabIndex = 17;
            // 
            // sobreToolStripMenuItem1
            // 
            sobreToolStripMenuItem1.Name = "sobreToolStripMenuItem1";
            sobreToolStripMenuItem1.Size = new Size(49, 20);
            sobreToolStripMenuItem1.Text = "Sobre";
            sobreToolStripMenuItem1.Click += sobreToolStripMenuItem1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(594, 450);
            Controls.Add(txtPeso);
            Controls.Add(txtAltura);
            Controls.Add(btnCalcular);
            Controls.Add(pBox);
            Controls.Add(lblIMC);
            Controls.Add(lblPesoIdeal);
            Controls.Add(RadioBtnMasc);
            Controls.Add(RadioBtnFem);
            Controls.Add(lblSexo);
            Controls.Add(lblMetros);
            Controls.Add(lblKg);
            Controls.Add(lblPeso);
            Controls.Add(lblAltura);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Cálculo de IMC";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem arquivoToolStripMenuItem;
        private ToolStripMenuItem sobreToolStripMenuItem;
        private Label lblAltura;
        private Label lblPeso;
        private Label lblKg;
        private Label lblMetros;
        private Label lblSexo;
        private RadioButton RadioBtnFem;
        private RadioButton RadioBtnMasc;
        private Label lblPesoIdeal;
        private Label lblIMC;
        private PictureBox pBox;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStripMenuItem calcularToolStripMenuItem;
        private ToolStripMenuItem limparToolStripMenuItem;
        private Button btnCalcular;
        private TextBox txtAltura;
        private TextBox txtPeso;
        private ToolStripMenuItem sobreToolStripMenuItem1;
    }
}