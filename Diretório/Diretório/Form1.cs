namespace Diretório
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            try
            {
                txtConteudo.Text = File.ReadAllText(txtCaminho.Text); //Ler do arquivo
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void txtCaminho_TextChanged(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void btnSalvar_Click_1(object sender, EventArgs e)
        {
            try
            {
                File.WriteAllText(txtCaminho.Text, txtConteudo.Text); //Escrever no arquivo
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } 
        }

        private void btnCriar_Click_1(object sender, EventArgs e)
        {
            try
            {
                Directory.CreateDirectory(txtCaminho2.Text); //Criar diretório
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Erro de Arquivo: " + ex.Message);
            }
        }
    }
}

