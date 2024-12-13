namespace conversaoReais
{
    public partial class Form1 : Form

    {
        double dolar = 5.46, libra = 7, euro = 5.94, iene = 0.037, pesoA = 0.0058, moeda, txt;
        //string dolar = "5.46", libra = "7", euro = "5.94", iene = "0.037", pesoA = "0.0058", moeda;
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (cbxMoeda.SelectedIndex)
            {
                case 0:
                    txt = double.Parse(txtValorR.Text);
                    moeda = txt * dolar;
                    lblValor.Text = "O valor convertido é : " + moeda;
                    break;
                case 1:
                    txt = double.Parse(txtValorR.Text);
                    moeda = txt * euro;
                    lblValor.Text = "O valor convertido é : " + moeda;
                    break;
                case 2:
                    txt = double.Parse(txtValorR.Text);
                    moeda = txt * libra;
                    lblValor.Text = "O valor convertido é : " + moeda;
                    break;
                case 3:
                    txt = double.Parse(txtValorR.Text);
                    moeda = txt * iene;
                    lblValor.Text = "O valor convertido é : " + moeda;
                    break;
                case 4:
                    txt = double.Parse(txtValorR.Text);
                    moeda = txt * pesoA;
                    lblValor.Text = "O valor convertido é : " + moeda;
                    break;
            }
        }

        private void txtValorR_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Show.Dialog(AboutBox1);
        }
    }
}