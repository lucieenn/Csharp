namespace JogoDados
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
            lblNome = new Label();
            TxtNome = new TextBox();
            BtnPlay = new Button();
            PboxVoce = new PictureBox();
            PboxMaquina = new PictureBox();
            PboxDadoVoce = new PictureBox();
            PboxDadoMaquina = new PictureBox();
            BtnPause = new Button();
            lblPlayer = new Label();
            lblMaquina = new Label();
            lblAvatar1 = new Label();
            lblAvatar2 = new Label();
            cbAvatar1 = new ComboBox();
            cbAvatar2 = new ComboBox();
            menuStrip1 = new MenuStrip();
            sobreToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            lblPontos1 = new Label();
            lblPontos2 = new Label();
            ((System.ComponentModel.ISupportInitialize)PboxVoce).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PboxMaquina).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PboxDadoVoce).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PboxDadoMaquina).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(18, 56);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(102, 15);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome do usuário:";
            // 
            // TxtNome
            // 
            TxtNome.Location = new Point(149, 48);
            TxtNome.Name = "TxtNome";
            TxtNome.Size = new Size(144, 23);
            TxtNome.TabIndex = 1;
            TxtNome.TextChanged += TxtNome_TextChanged;
            // 
            // BtnPlay
            // 
            BtnPlay.Image = Properties.Resources.botao_play60;
            BtnPlay.Location = new Point(32, 271);
            BtnPlay.Name = "BtnPlay";
            BtnPlay.Size = new Size(96, 94);
            BtnPlay.TabIndex = 2;
            BtnPlay.UseVisualStyleBackColor = true;
            BtnPlay.Click += BtnPlay_Click;
            // 
            // PboxVoce
            // 
            PboxVoce.Location = new Point(396, 48);
            PboxVoce.Name = "PboxVoce";
            PboxVoce.Size = new Size(124, 136);
            PboxVoce.SizeMode = PictureBoxSizeMode.StretchImage;
            PboxVoce.TabIndex = 4;
            PboxVoce.TabStop = false;
            PboxVoce.Click += PboxVoce_Click;
            // 
            // PboxMaquina
            // 
            PboxMaquina.Location = new Point(396, 227);
            PboxMaquina.Name = "PboxMaquina";
            PboxMaquina.Size = new Size(124, 138);
            PboxMaquina.SizeMode = PictureBoxSizeMode.StretchImage;
            PboxMaquina.TabIndex = 5;
            PboxMaquina.TabStop = false;
            // 
            // PboxDadoVoce
            // 
            PboxDadoVoce.Location = new Point(624, 75);
            PboxDadoVoce.Name = "PboxDadoVoce";
            PboxDadoVoce.Size = new Size(100, 98);
            PboxDadoVoce.SizeMode = PictureBoxSizeMode.StretchImage;
            PboxDadoVoce.TabIndex = 6;
            PboxDadoVoce.TabStop = false;
            // 
            // PboxDadoMaquina
            // 
            PboxDadoMaquina.Location = new Point(624, 253);
            PboxDadoMaquina.Name = "PboxDadoMaquina";
            PboxDadoMaquina.Size = new Size(100, 98);
            PboxDadoMaquina.SizeMode = PictureBoxSizeMode.StretchImage;
            PboxDadoMaquina.TabIndex = 7;
            PboxDadoMaquina.TabStop = false;
            // 
            // BtnPause
            // 
            BtnPause.Image = Properties.Resources.pause_play60;
            BtnPause.Location = new Point(197, 274);
            BtnPause.Name = "BtnPause";
            BtnPause.Size = new Size(96, 88);
            BtnPause.TabIndex = 8;
            BtnPause.UseVisualStyleBackColor = true;
            BtnPause.Visible = false;
            BtnPause.Click += BtnPause_Click;
            // 
            // lblPlayer
            // 
            lblPlayer.AutoSize = true;
            lblPlayer.Location = new Point(431, 187);
            lblPlayer.Name = "lblPlayer";
            lblPlayer.Size = new Size(39, 15);
            lblPlayer.TabIndex = 9;
            lblPlayer.Text = "Player";
            lblPlayer.Visible = false;
            lblPlayer.Click += lblPlayer_Click;
            // 
            // lblMaquina
            // 
            lblMaquina.AutoSize = true;
            lblMaquina.Location = new Point(431, 368);
            lblMaquina.Name = "lblMaquina";
            lblMaquina.Size = new Size(48, 15);
            lblMaquina.TabIndex = 10;
            lblMaquina.Text = "Inimigo";
            lblMaquina.Visible = false;
            lblMaquina.Click += lblMaquina_Click;
            // 
            // lblAvatar1
            // 
            lblAvatar1.AutoSize = true;
            lblAvatar1.Location = new Point(18, 98);
            lblAvatar1.Name = "lblAvatar1";
            lblAvatar1.Size = new Size(106, 15);
            lblAvatar1.TabIndex = 11;
            lblAvatar1.Text = "Escolha seu avatar:";
            // 
            // lblAvatar2
            // 
            lblAvatar2.AutoSize = true;
            lblAvatar2.Location = new Point(18, 144);
            lblAvatar2.Name = "lblAvatar2";
            lblAvatar2.Size = new Size(125, 15);
            lblAvatar2.TabIndex = 12;
            lblAvatar2.Text = "Escolha seu oponente:";
            // 
            // cbAvatar1
            // 
            cbAvatar1.FormattingEnabled = true;
            cbAvatar1.Items.AddRange(new object[] { "Você", "Bob esponja", "Você Bravo", "Chaves" });
            cbAvatar1.Location = new Point(149, 90);
            cbAvatar1.Name = "cbAvatar1";
            cbAvatar1.Size = new Size(144, 23);
            cbAvatar1.TabIndex = 13;
            cbAvatar1.SelectedIndexChanged += cbAvatar1_SelectedIndexChanged;
            // 
            // cbAvatar2
            // 
            cbAvatar2.FormattingEnabled = true;
            cbAvatar2.Items.AddRange(new object[] { "Maquina", "Indiano", "Seu Madruga", "Lolizinha fofa" });
            cbAvatar2.Location = new Point(149, 136);
            cbAvatar2.Name = "cbAvatar2";
            cbAvatar2.Size = new Size(144, 23);
            cbAvatar2.TabIndex = 14;
            cbAvatar2.SelectedIndexChanged += cbAvatar2_SelectedIndexChanged;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { sobreToolStripMenuItem, sairToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 15;
            menuStrip1.Text = "menuStrip1";
            // 
            // sobreToolStripMenuItem
            // 
            sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            sobreToolStripMenuItem.Size = new Size(49, 20);
            sobreToolStripMenuItem.Text = "Sobre";
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(38, 20);
            sairToolStripMenuItem.Text = "Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // lblPontos1
            // 
            lblPontos1.AutoSize = true;
            lblPontos1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPontos1.Location = new Point(327, 98);
            lblPontos1.Name = "lblPontos1";
            lblPontos1.Size = new Size(19, 21);
            lblPontos1.TabIndex = 16;
            lblPontos1.Text = "0";
            lblPontos1.Visible = false;
            // 
            // lblPontos2
            // 
            lblPontos2.AutoSize = true;
            lblPontos2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPontos2.Location = new Point(327, 292);
            lblPontos2.Name = "lblPontos2";
            lblPontos2.Size = new Size(19, 21);
            lblPontos2.TabIndex = 17;
            lblPontos2.Text = "0";
            lblPontos2.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblPontos2);
            Controls.Add(lblPontos1);
            Controls.Add(cbAvatar2);
            Controls.Add(cbAvatar1);
            Controls.Add(lblAvatar2);
            Controls.Add(lblAvatar1);
            Controls.Add(lblMaquina);
            Controls.Add(lblPlayer);
            Controls.Add(BtnPause);
            Controls.Add(PboxDadoMaquina);
            Controls.Add(PboxDadoVoce);
            Controls.Add(PboxMaquina);
            Controls.Add(PboxVoce);
            Controls.Add(BtnPlay);
            Controls.Add(TxtNome);
            Controls.Add(lblNome);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)PboxVoce).EndInit();
            ((System.ComponentModel.ISupportInitialize)PboxMaquina).EndInit();
            ((System.ComponentModel.ISupportInitialize)PboxDadoVoce).EndInit();
            ((System.ComponentModel.ISupportInitialize)PboxDadoMaquina).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNome;
        private TextBox TxtNome;
        private Button BtnPlay;
        private PictureBox PboxVoce;
        private PictureBox PboxMaquina;
        private PictureBox PboxDadoVoce;
        private PictureBox PboxDadoMaquina;
        private Button BtnPause;
        private Label lblPlayer;
        private Label lblMaquina;
        private Label lblAvatar1;
        private Label lblAvatar2;
        private ComboBox cbAvatar1;
        private ComboBox cbAvatar2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem sobreToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private Label lblPontos1;
        private Label lblPontos2;
    }
}