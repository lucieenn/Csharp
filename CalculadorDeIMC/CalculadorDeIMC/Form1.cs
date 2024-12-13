using System.Reflection.PortableExecutable;

namespace CalculadorDeIMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblSexo_Click(object sender, EventArgs e)
        {

        }

        private void RadioBtnFem_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioBtnFem.Checked == true)
                pBox.Visible = true;
            pBox.Image = Properties.Resources.CorpoFem;

        }

        private void RadioBtnMasc_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioBtnFem.Checked == true)
                pBox.Visible = true;
            pBox.Image = Properties.Resources.CorpoMasc;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click_1(object sender, EventArgs e)
        {
            double peso = Convert.ToDouble(txtPeso.Text);
            double altura = Convert.ToDouble(txtAltura.Text);

            double imc = peso / (altura * altura);

            lblIMC.Text = "IMC: " + imc.ToString("F2");
            lblIMC.Visible = true;

            if (imc < 16.9)
                lblPesoIdeal.Text = "Abaixo do peso";
            else if (imc >= 17 && imc <= 18.4)
                lblPesoIdeal.Text = "Abaixo do peso";
            else if (imc >= 18.5 && imc <= 24.9)
                lblPesoIdeal.Text = "Peso Ideal";
            else if (imc >= 25 && imc <= 50)
                lblPesoIdeal.Text = "Acima do Peso";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //lblIMC.Visible = false;
            pBox.Visible = false;
            //lblPesoIdeal.Visible = false;


        }

        private void lblPesoIdeal_Click(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void calcularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double peso = Convert.ToDouble(txtPeso.Text);
            double altura = Convert.ToDouble(txtAltura.Text);

            double imc = peso / (altura * altura);

            lblIMC.Text = "IMC: " + imc.ToString("F2");
            lblIMC.Visible = true;

            if (imc < 16.9)
                lblPesoIdeal.Text = "Abaixo do peso";
            else if (imc >= 17 && imc <= 18.4)
                lblPesoIdeal.Text = "Abaixo do peso";
            else if (imc >= 18.5 && imc <= 24.9)
                lblPesoIdeal.Text = "Peso Ideal";
            else if (imc >= 25 && imc <= 50)
                lblPesoIdeal.Text = "Acima do Peso";
        }

        private void limparToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtAltura.Clear();
            txtPeso.Clear();
            pBox.Visible = false;
            RadioBtnFem.Checked = false;
            RadioBtnMasc.Checked = false;
        }

        private void sobreToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AboutBox2 sobre = new AboutBox2();
            sobre.ShowDialog();
        }
    }
}