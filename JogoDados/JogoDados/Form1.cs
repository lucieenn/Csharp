namespace JogoDados
{
    public partial class Form1 : Form
    {
        int nmrseu = 0, numeroseu = 0;
        int pontoa = 0, pontoi = 0;
        string nome;

        public Form1()
        {
            InitializeComponent();
        }

        private void lblPlayer_Click(object sender, EventArgs e)
        {

        }

        private void lblMaquina_Click(object sender, EventArgs e)
        {

        }

        private void TxtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnPause_Click(object sender, EventArgs e)
        {
            TxtNome.Text = string.Empty;
            cbAvatar1.Text = string.Empty;
            cbAvatar2.Text = string.Empty;
            PboxMaquina.Visible = false;
            lblMaquina.Text = string.Empty;
            PboxVoce.Visible = false;
            lblPlayer.Visible = false;
            BtnPause.Visible = false;
            lblPontos1.Visible = false;
            lblPontos2.Visible = false;
            PboxDadoVoce.Visible = false;
            PboxDadoMaquina.Visible = false;

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PboxVoce_Click(object sender, EventArgs e)
        {

        }

        private void cbAvatar1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbAvatar1.SelectedIndex)
            {

                case 0:

                    PboxVoce.Visible = true;
                    lblPlayer.Visible = true;
                    lblPlayer.Text = "Você";
                    PboxVoce.Image = Properties.Resources.Você130;
                    break;

                case 1:
                    PboxVoce.Visible = true;
                    lblPlayer.Visible = true;
                    lblPlayer.Text = "Bob Esponja";
                    PboxVoce.Image = Properties.Resources.BobEsponja;
                    break;
                case 2:
                    PboxVoce.Visible = true;
                    lblPlayer.Visible = true;
                    lblPlayer.Text = "Você bravo";
                    PboxVoce.Image = Properties.Resources.VocêBravo;
                    break;
                case 3:
                    PboxVoce.Visible = true;
                    lblPlayer.Visible = true;
                    lblPlayer.Text = "Chaves";
                    PboxVoce.Image = Properties.Resources.Chaves130;
                    break;

            }
        }

        private void cbAvatar2_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbAvatar2.SelectedIndex)
            {

                case 0:

                    PboxMaquina.Visible = true;
                    lblMaquina.Visible = true;
                    lblMaquina.Text = "Maquina";
                    PboxMaquina.Image = Properties.Resources.gigachad;
                    break;

                case 1:
                    PboxMaquina.Visible = true;
                    lblMaquina.Visible = true;
                    lblMaquina.Text = "Indiano";
                    PboxMaquina.Image = Properties.Resources.Indiano130;
                    break;
                case 2:
                    PboxMaquina.Visible = true;
                    lblMaquina.Visible = true;
                    lblMaquina.Text = "Seu Madruga";
                    PboxMaquina.Image = Properties.Resources.SeuMadruga130;
                    break;
                case 3:
                    PboxMaquina.Visible = true;
                    lblMaquina.Visible = true;
                    lblMaquina.Text = "Lolizinha fofa";
                    PboxMaquina.Image = Properties.Resources.LolizinhaFofa130;
                    break;

            }
        }

        private void BtnPlay_Click(object sender, EventArgs e)
        {
            Random Dadosinimigo = new Random();
            int nmrinimigo = Dadosinimigo.Next(1, 6);
            Random SeuDados = new Random();
            int nmrseu = SeuDados.Next(1, 6);
            PboxDadoMaquina.Visible = true;
            PboxDadoVoce.Visible = true;
            BtnPause.Visible = true;
            lblPontos1.Visible = true;
            lblPontos2.Visible = true;


            switch (nmrseu)
            {
                case 0:
                    PboxDadoVoce.Visible = true;
                    PboxDadoVoce.Image = Properties.Resources.lado1;
                    break;

                case 1:
                    PboxDadoVoce.Visible = true;
                    PboxDadoVoce.Image = Properties.Resources.lado2;
                    break;

                case 2:
                    PboxDadoVoce.Visible = true;
                    PboxDadoVoce.Image = Properties.Resources.lado3;
                    break;

                case 3:
                    PboxDadoVoce.Visible = true;
                    PboxDadoVoce.Image = Properties.Resources.lado4;
                    break;
                case 4:
                    PboxDadoVoce.Visible = true;
                    PboxDadoVoce.Image = Properties.Resources.lado5;
                    break;
                case 5:
                    PboxDadoVoce.Visible = true;
                    PboxDadoVoce.Image = Properties.Resources.lado6;
                    break;
            }

            switch (nmrinimigo)
            {
                case 0:
                    PboxDadoMaquina.Visible = true;
                    PboxDadoMaquina.Image = Properties.Resources.lado1;
                    break;

                case 1:
                    PboxDadoMaquina.Visible = true;
                    PboxDadoMaquina.Image = Properties.Resources.lado2;
                    break;

                case 2:
                    PboxDadoMaquina.Visible = true;
                    PboxDadoMaquina.Image = Properties.Resources.lado3;
                    break;

                case 3:
                    PboxDadoMaquina.Visible = true;
                    PboxDadoMaquina.Image = Properties.Resources.lado4;
                    break;
                case 4:
                    PboxDadoMaquina.Visible = true;
                    PboxDadoMaquina.Image = Properties.Resources.lado5;
                    break;
                case 5:
                    PboxDadoMaquina.Visible = true;
                    PboxDadoMaquina.Image = Properties.Resources.lado6;
                    break;
            }

            if (nmrseu > nmrinimigo)
            {

                lblPontos1.Visible = true;
                pontoa = pontoa + 1;
                lblPontos2.Text = "" + pontoa;

            }
            else if (nmrseu < nmrinimigo)
            {
                lblPontos2.Visible = true;
                pontoi = pontoi + 1;
                lblPontos2.Text = "" + pontoi;

            }
            else
            {
                pontoa = pontoa + 1;
                pontoi = pontoi + 1;
                lblPontos2.Text = pontoi.ToString();
                lblPontos1.Text = pontoa.ToString();

            }
        }
    }
}
