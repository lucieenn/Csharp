namespace WinFormsApp2
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            groupBoxHobbies = new GroupBox();
            checkBoxXadrez = new CheckBox();
            checkBoxProg = new CheckBox();
            checkBoxVolei = new CheckBox();
            checkBoxSeries = new CheckBox();
            checkBoxFut = new CheckBox();
            groupBoxSexo = new GroupBox();
            radioButtonFem = new RadioButton();
            RadioButtonMasc = new RadioButton();
            textEmail = new TextBox();
            textNome = new TextBox();
            textMatricula = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            groupBox4 = new GroupBox();
            lstBoxMes = new ListBox();
            lblMes = new Label();
            groupBoxPeriodo = new GroupBox();
            radioButtonNoite = new RadioButton();
            radioButtonTarde = new RadioButton();
            radioButtonManha = new RadioButton();
            comboBoxCursos = new ComboBox();
            button1 = new Button();
            buttonLimpar = new Button();
            button3 = new Button();
            menuStrip1 = new MenuStrip();
            arquivoToolStripMenuItem = new ToolStripMenuItem();
            sobreToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            toolTip1 = new ToolTip(components);
            pageSetupDialog1 = new PageSetupDialog();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            groupBoxHobbies.SuspendLayout();
            groupBoxSexo.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBoxPeriodo.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.senac_logo_0_1;
            pictureBox1.Location = new Point(12, 46);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(173, 92);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Algerian", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(215, 83);
            label1.Name = "label1";
            label1.Size = new Size(280, 26);
            label1.TabIndex = 2;
            label1.Text = "CADASTRO DE ALUNOS";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBoxHobbies);
            groupBox1.Controls.Add(groupBoxSexo);
            groupBox1.Controls.Add(textEmail);
            groupBox1.Controls.Add(textNome);
            groupBox1.Controls.Add(textMatricula);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 159);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(588, 297);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dados pessoais";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // groupBoxHobbies
            // 
            groupBoxHobbies.Controls.Add(checkBoxXadrez);
            groupBoxHobbies.Controls.Add(checkBoxProg);
            groupBoxHobbies.Controls.Add(checkBoxVolei);
            groupBoxHobbies.Controls.Add(checkBoxSeries);
            groupBoxHobbies.Controls.Add(checkBoxFut);
            groupBoxHobbies.Location = new Point(173, 180);
            groupBoxHobbies.Name = "groupBoxHobbies";
            groupBoxHobbies.Size = new Size(323, 100);
            groupBoxHobbies.TabIndex = 7;
            groupBoxHobbies.TabStop = false;
            groupBoxHobbies.Text = "Hobbies";
            // 
            // checkBoxXadrez
            // 
            checkBoxXadrez.AutoSize = true;
            checkBoxXadrez.Location = new Point(227, 32);
            checkBoxXadrez.Name = "checkBoxXadrez";
            checkBoxXadrez.Size = new Size(61, 19);
            checkBoxXadrez.TabIndex = 4;
            checkBoxXadrez.Text = "Xadrez";
            checkBoxXadrez.UseVisualStyleBackColor = true;
            // 
            // checkBoxProg
            // 
            checkBoxProg.AutoSize = true;
            checkBoxProg.Location = new Point(113, 71);
            checkBoxProg.Name = "checkBoxProg";
            checkBoxProg.Size = new Size(118, 19);
            checkBoxProg.TabIndex = 3;
            checkBoxProg.Text = "Programar em c#";
            checkBoxProg.UseVisualStyleBackColor = true;
            // 
            // checkBoxVolei
            // 
            checkBoxVolei.AutoSize = true;
            checkBoxVolei.Location = new Point(113, 32);
            checkBoxVolei.Name = "checkBoxVolei";
            checkBoxVolei.Size = new Size(51, 19);
            checkBoxVolei.TabIndex = 2;
            checkBoxVolei.Text = "Vôlei";
            checkBoxVolei.UseVisualStyleBackColor = true;
            // 
            // checkBoxSeries
            // 
            checkBoxSeries.AutoSize = true;
            checkBoxSeries.Location = new Point(6, 71);
            checkBoxSeries.Name = "checkBoxSeries";
            checkBoxSeries.Size = new Size(56, 19);
            checkBoxSeries.TabIndex = 1;
            checkBoxSeries.Text = "Séries";
            checkBoxSeries.UseVisualStyleBackColor = true;
            // 
            // checkBoxFut
            // 
            checkBoxFut.AutoSize = true;
            checkBoxFut.Location = new Point(6, 32);
            checkBoxFut.Name = "checkBoxFut";
            checkBoxFut.Size = new Size(66, 19);
            checkBoxFut.TabIndex = 0;
            checkBoxFut.Text = "Futebol";
            checkBoxFut.UseVisualStyleBackColor = true;
            // 
            // groupBoxSexo
            // 
            groupBoxSexo.Controls.Add(radioButtonFem);
            groupBoxSexo.Controls.Add(RadioButtonMasc);
            groupBoxSexo.Location = new Point(15, 198);
            groupBoxSexo.Name = "groupBoxSexo";
            groupBoxSexo.Size = new Size(121, 82);
            groupBoxSexo.TabIndex = 6;
            groupBoxSexo.TabStop = false;
            groupBoxSexo.Text = "Sexo";
            // 
            // radioButtonFem
            // 
            radioButtonFem.AutoSize = true;
            radioButtonFem.Location = new Point(15, 53);
            radioButtonFem.Name = "radioButtonFem";
            radioButtonFem.Size = new Size(75, 19);
            radioButtonFem.TabIndex = 1;
            radioButtonFem.TabStop = true;
            radioButtonFem.Text = "Feminino";
            radioButtonFem.UseVisualStyleBackColor = true;
            // 
            // RadioButtonMasc
            // 
            RadioButtonMasc.AutoSize = true;
            RadioButtonMasc.Location = new Point(15, 28);
            RadioButtonMasc.Name = "RadioButtonMasc";
            RadioButtonMasc.Size = new Size(80, 19);
            RadioButtonMasc.TabIndex = 0;
            RadioButtonMasc.TabStop = true;
            RadioButtonMasc.Text = "Masculino";
            RadioButtonMasc.UseVisualStyleBackColor = true;
            // 
            // textEmail
            // 
            textEmail.Location = new Point(62, 103);
            textEmail.Name = "textEmail";
            textEmail.Size = new Size(422, 23);
            textEmail.TabIndex = 5;
            textEmail.TextChanged += textBox3_TextChanged;
            // 
            // textNome
            // 
            textNome.Location = new Point(61, 72);
            textNome.Name = "textNome";
            textNome.Size = new Size(422, 23);
            textNome.TabIndex = 4;
            // 
            // textMatricula
            // 
            textMatricula.Location = new Point(78, 40);
            textMatricula.Name = "textMatricula";
            textMatricula.Size = new Size(86, 23);
            textMatricula.TabIndex = 3;
            textMatricula.TextChanged += textMatricula_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 106);
            label4.Name = "label4";
            label4.Size = new Size(41, 15);
            label4.TabIndex = 2;
            label4.Text = "E-mail";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 75);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 1;
            label3.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 43);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 0;
            label2.Text = "Matricula";
            label2.Click += label2_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(lstBoxMes);
            groupBox4.Controls.Add(lblMes);
            groupBox4.Controls.Add(groupBoxPeriodo);
            groupBox4.Controls.Add(comboBoxCursos);
            groupBox4.Location = new Point(12, 477);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(444, 160);
            groupBox4.TabIndex = 4;
            groupBox4.TabStop = false;
            groupBox4.Text = "Curso";
            // 
            // lstBoxMes
            // 
            lstBoxMes.FormattingEnabled = true;
            lstBoxMes.ItemHeight = 15;
            lstBoxMes.Location = new Point(318, 22);
            lstBoxMes.Name = "lstBoxMes";
            lstBoxMes.Size = new Size(120, 94);
            lstBoxMes.TabIndex = 3;
            lstBoxMes.SelectedIndexChanged += lstBoxMes_SelectedIndexChanged;
            // 
            // lblMes
            // 
            lblMes.AutoSize = true;
            lblMes.Location = new Point(233, 28);
            lblMes.Name = "lblMes";
            lblMes.Size = new Size(80, 15);
            lblMes.TabIndex = 2;
            lblMes.Text = "Mês de inicio:";
            lblMes.Click += label5_Click;
            // 
            // groupBoxPeriodo
            // 
            groupBoxPeriodo.Controls.Add(radioButtonNoite);
            groupBoxPeriodo.Controls.Add(radioButtonTarde);
            groupBoxPeriodo.Controls.Add(radioButtonManha);
            groupBoxPeriodo.Location = new Point(15, 60);
            groupBoxPeriodo.Name = "groupBoxPeriodo";
            groupBoxPeriodo.Size = new Size(106, 94);
            groupBoxPeriodo.TabIndex = 1;
            groupBoxPeriodo.TabStop = false;
            groupBoxPeriodo.Text = "Período";
            groupBoxPeriodo.Enter += groupBox5_Enter;
            // 
            // radioButtonNoite
            // 
            radioButtonNoite.AutoSize = true;
            radioButtonNoite.Location = new Point(6, 69);
            radioButtonNoite.Name = "radioButtonNoite";
            radioButtonNoite.Size = new Size(54, 19);
            radioButtonNoite.TabIndex = 2;
            radioButtonNoite.TabStop = true;
            radioButtonNoite.Text = "Noite";
            radioButtonNoite.UseVisualStyleBackColor = true;
            // 
            // radioButtonTarde
            // 
            radioButtonTarde.AutoSize = true;
            radioButtonTarde.Location = new Point(6, 44);
            radioButtonTarde.Name = "radioButtonTarde";
            radioButtonTarde.Size = new Size(53, 19);
            radioButtonTarde.TabIndex = 1;
            radioButtonTarde.TabStop = true;
            radioButtonTarde.Text = "Tarde";
            radioButtonTarde.UseVisualStyleBackColor = true;
            // 
            // radioButtonManha
            // 
            radioButtonManha.AutoSize = true;
            radioButtonManha.Location = new Point(6, 22);
            radioButtonManha.Name = "radioButtonManha";
            radioButtonManha.Size = new Size(62, 19);
            radioButtonManha.TabIndex = 0;
            radioButtonManha.TabStop = true;
            radioButtonManha.Text = "Manhã";
            radioButtonManha.UseVisualStyleBackColor = true;
            radioButtonManha.CheckedChanged += radioButtonManha_CheckedChanged;
            // 
            // comboBoxCursos
            // 
            comboBoxCursos.FormattingEnabled = true;
            comboBoxCursos.Items.AddRange(new object[] { "Técnico em Desenvolvimento de sistemas", "Técnico em Informática para internet", "Técnico em Design Gráfico" });
            comboBoxCursos.Location = new Point(6, 22);
            comboBoxCursos.Name = "comboBoxCursos";
            comboBoxCursos.Size = new Size(215, 23);
            comboBoxCursos.TabIndex = 0;
            comboBoxCursos.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(114, 696);
            button1.Name = "button1";
            button1.Size = new Size(104, 93);
            button1.TabIndex = 5;
            button1.Text = "Salvar";
            button1.TextAlign = ContentAlignment.BottomCenter;
            toolTip1.SetToolTip(button1, "Salvar seus dados");
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // buttonLimpar
            // 
            buttonLimpar.Image = (Image)resources.GetObject("buttonLimpar.Image");
            buttonLimpar.ImageAlign = ContentAlignment.MiddleRight;
            buttonLimpar.Location = new Point(245, 696);
            buttonLimpar.Name = "buttonLimpar";
            buttonLimpar.Size = new Size(99, 93);
            buttonLimpar.TabIndex = 6;
            buttonLimpar.Text = "Limpar";
            buttonLimpar.TextAlign = ContentAlignment.BottomCenter;
            toolTip1.SetToolTip(buttonLimpar, "Limpar suas informações");
            buttonLimpar.UseVisualStyleBackColor = true;
            buttonLimpar.Click += button2_Click;
            // 
            // button3
            // 
            button3.Image = Properties.Resources.icons8_sair_80;
            button3.Location = new Point(368, 696);
            button3.Name = "button3";
            button3.Size = new Size(105, 93);
            button3.TabIndex = 7;
            button3.Text = "Sair";
            button3.TextAlign = ContentAlignment.BottomCenter;
            toolTip1.SetToolTip(button3, "Sair do programa");
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { arquivoToolStripMenuItem, sairToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(625, 24);
            menuStrip1.TabIndex = 8;
            menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            arquivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sobreToolStripMenuItem });
            arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            arquivoToolStripMenuItem.Size = new Size(61, 20);
            arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // sobreToolStripMenuItem
            // 
            sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            sobreToolStripMenuItem.Size = new Size(180, 22);
            sobreToolStripMenuItem.Text = "Sobre";
            sobreToolStripMenuItem.Click += sobreToolStripMenuItem_Click;
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(38, 20);
            sairToolStripMenuItem.Text = "Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // toolTip1
            // 
            toolTip1.IsBalloon = true;
            toolTip1.ToolTipTitle = "Informações";
            toolTip1.Popup += toolTip1_Popup_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(625, 796);
            Controls.Add(button3);
            Controls.Add(buttonLimpar);
            Controls.Add(button1);
            Controls.Add(groupBox4);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBoxHobbies.ResumeLayout(false);
            groupBoxHobbies.PerformLayout();
            groupBoxSexo.ResumeLayout(false);
            groupBoxSexo.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBoxPeriodo.ResumeLayout(false);
            groupBoxPeriodo.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private Label label4;
        private GroupBox groupBoxHobbies;
        private GroupBox groupBoxSexo;
        private RadioButton radioButtonFem;
        private RadioButton RadioButtonMasc;
        private TextBox textEmail;
        private TextBox textNome;
        private TextBox textMatricula;
        private CheckBox checkBoxXadrez;
        private CheckBox checkBoxProg;
        private CheckBox checkBoxVolei;
        private CheckBox checkBoxSeries;
        private CheckBox checkBoxFut;
        private GroupBox groupBox4;
        private ComboBox comboBoxCursos;
        private Label lblMes;
        private GroupBox groupBoxPeriodo;
        private RadioButton radioButtonNoite;
        private RadioButton radioButtonTarde;
        private RadioButton radioButtonManha;
        private Button button1;
        private Button buttonLimpar;
        private Button button3;
        private ListBox lstBoxMes;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem arquivoToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolTip toolTip1;
        private ToolStripMenuItem sobreToolStripMenuItem;
        private PageSetupDialog pageSetupDialog1;
    }
}