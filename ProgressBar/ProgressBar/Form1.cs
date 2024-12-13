namespace ProgressBar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            int numero = 0;

            numero = int.Parse(textBox1.Text);

            progressBar1.Value += 10;
            prgNumeros.Text = prgNumeros.Text + textBox1.Text + "\n";
            textBox1.Clear();
            lblNmrPorcent.Visible = true;
            for (int i = 0; i <= 10; i++)
            {
                int porcentagem = 0;
                porcentagem = progressBar1.Value;
                lblNmrPorcent.Text = porcentagem.ToString();

            }
            if (progressBar1.Value >= 100)
            {
                textBox1.Enabled = false;
                prgNumeros.Enabled = false;
                MessageBox.Show("Você ja inseriu 10 números");
            }
        }
        private void prgNumeros_TextChanged(object sender, EventArgs e)
        {
            prgNumeros.Enabled = false;
        }

        private void lblNmrPorcent_Click(object sender, EventArgs e)
        {

        }

        private void lblNumero_Click(object sender, EventArgs e)
        {

        }
    }
}