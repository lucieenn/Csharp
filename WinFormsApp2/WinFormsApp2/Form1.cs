using System.Collections;
using System.Data;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


            switch (comboBoxCursos.SelectedIndex)
            {
                case 0:
                    lstBoxMes.Items.Add("Agosto");
                    lstBoxMes.Items.Add("Novembro");
                    break;
                case 1:

                    lstBoxMes.Items.Add("Setembro");
                    lstBoxMes.Items.Add("Outubro");
                    break;
                case 2:
                    lstBoxMes.Items.Add("Setembro");
                    lstBoxMes.Items.Add("Outubro");
                    lstBoxMes.Items.Add("Novembro");
                    break;

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Salvo com sucesso");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textMatricula.Text = String.Empty;
            textNome.Text = String.Empty;
            textEmail.Text = String.Empty;
            radioButtonFem.Checked = false;
            RadioButtonMasc.Checked = false;
            checkBoxFut.Checked = false;
            checkBoxProg.Checked = false;
            checkBoxSeries.Checked = false;
            checkBoxVolei.Checked = false;
            checkBoxXadrez.Checked = false;
            comboBoxCursos.Text = String.Empty;
            radioButtonManha.Checked = false;
            radioButtonNoite.Checked = false;
            radioButtonTarde.Checked = false;
            lstBoxMes.Text = String.Empty;
            lstBoxMes.Items.Clear();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void textMatricula_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void radioButtonManha_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lstBoxMes_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (comboBoxCursos.SelectedIndex)

            {
                case 0:
                    radioButtonManha.Enabled = true;
                    radioButtonTarde.Enabled = true;
                    radioButtonNoite.Enabled = false;
                    break;
                case 1:
                    radioButtonManha.Enabled = false;
                    radioButtonTarde.Enabled = true;
                    radioButtonNoite.Enabled = true;
                    break;
                case 2:
                    radioButtonManha.Enabled = true;
                    radioButtonTarde.Enabled = true;
                    radioButtonNoite.Enabled = true;
                    break;
            }
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void toolTip1_Popup_1(object sender, PopupEventArgs e)
        {

        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vermelho vermelho = new Vermelho();
            vermelho.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}