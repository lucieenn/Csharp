namespace conversaoReais
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
            pictureBox1 = new PictureBox();
            lvlConversor = new Label();
            label1 = new Label();
            txtValorR = new TextBox();
            cbxMoeda = new ComboBox();
            label2 = new Label();
            lblAtual = new Label();
            lvlAtual2 = new Label();
            btnSair = new Button();
            lblValor = new Label();
            statusStrip1 = new StatusStrip();
            menuStrip1 = new MenuStrip();
            sobreToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_cifrão_96;
            pictureBox1.Location = new Point(582, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 95);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // lvlConversor
            // 
            lvlConversor.AutoSize = true;
            lvlConversor.Font = new Font("Bodoni Bd BT", 36F, FontStyle.Regular, GraphicsUnit.Point);
            lvlConversor.Location = new Point(81, 21);
            lvlConversor.Name = "lvlConversor";
            lvlConversor.Size = new Size(480, 56);
            lvlConversor.TabIndex = 1;
            lvlConversor.Text = "Conversor de moedas";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bodoni Bd BT", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(12, 101);
            label1.Name = "label1";
            label1.Size = new Size(177, 19);
            label1.TabIndex = 2;
            label1.Text = "Digite um valor em R$:";
            // 
            // txtValorR
            // 
            txtValorR.Location = new Point(195, 97);
            txtValorR.Name = "txtValorR";
            txtValorR.Size = new Size(107, 23);
            txtValorR.TabIndex = 3;
            txtValorR.TextChanged += txtValorR_TextChanged;
            // 
            // cbxMoeda
            // 
            cbxMoeda.FormattingEnabled = true;
            cbxMoeda.Items.AddRange(new object[] { "Dolár", "Euro", "Libra", "Iene", "Peso argentino" });
            cbxMoeda.Location = new Point(181, 163);
            cbxMoeda.Name = "cbxMoeda";
            cbxMoeda.Size = new Size(121, 23);
            cbxMoeda.TabIndex = 4;
            cbxMoeda.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bodoni Bd BT", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(12, 167);
            label2.Name = "label2";
            label2.Size = new Size(160, 19);
            label2.TabIndex = 5;
            label2.Text = "Escolha uma moeda:";
            // 
            // lblAtual
            // 
            lblAtual.AutoSize = true;
            lblAtual.Location = new Point(12, 217);
            lblAtual.Name = "lblAtual";
            lblAtual.Size = new Size(0, 15);
            lblAtual.TabIndex = 6;
            // 
            // lvlAtual2
            // 
            lvlAtual2.AutoSize = true;
            lvlAtual2.Location = new Point(9, 265);
            lvlAtual2.Name = "lvlAtual2";
            lvlAtual2.Size = new Size(0, 15);
            lvlAtual2.TabIndex = 7;
            // 
            // btnSair
            // 
            btnSair.BackColor = SystemColors.ControlLightLight;
            btnSair.BackgroundImage = (Image)resources.GetObject("btnSair.BackgroundImage");
            btnSair.BackgroundImageLayout = ImageLayout.Center;
            btnSair.ForeColor = SystemColors.ControlText;
            btnSair.Location = new Point(577, 351);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(95, 87);
            btnSair.TabIndex = 8;
            btnSair.Text = "Sair";
            btnSair.TextAlign = ContentAlignment.BottomCenter;
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += btnSair_Click;
            // 
            // lblValor
            // 
            lblValor.AutoSize = true;
            lblValor.Location = new Point(389, 148);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(38, 15);
            lblValor.TabIndex = 9;
            lblValor.Text = "label3";
            // 
            // statusStrip1
            // 
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(684, 22);
            statusStrip1.TabIndex = 10;
            statusStrip1.Text = "statusStrip1";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { sobreToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(684, 24);
            menuStrip1.TabIndex = 11;
            menuStrip1.Text = "menuStrip1";
            // 
            // sobreToolStripMenuItem
            // 
            sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            sobreToolStripMenuItem.Size = new Size(49, 20);
            sobreToolStripMenuItem.Text = "Sobre";
            sobreToolStripMenuItem.Click += sobreToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 450);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            Controls.Add(lblValor);
            Controls.Add(btnSair);
            Controls.Add(lvlAtual2);
            Controls.Add(lblAtual);
            Controls.Add(label2);
            Controls.Add(cbxMoeda);
            Controls.Add(txtValorR);
            Controls.Add(label1);
            Controls.Add(lvlConversor);
            Controls.Add(pictureBox1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lvlConversor;
        private Label label1;
        private TextBox txtValorR;
        private ComboBox cbxMoeda;
        private Label label2;
        private Label lblAtual;
        private Label lvlAtual2;
        private Button btnSair;
        private Label lblValor;
        private StatusStrip statusStrip1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem sobreToolStripMenuItem;
    }
}