using MySql.Data.MySqlClient;

namespace insert
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtcodigo.Text = string.Empty;
            txtnome.Text = string.Empty;
            mskcpf.Text = string.Empty;
            txtrg.Text = string.Empty;
            cbuf.SelectedIndex = -1;
            mskdata.Text = string.Empty;
            cbsexo.SelectedIndex = -1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection conexao = new MySqlConnection("Server = localhost; Database= conexao; User ID= root; Password= ; ");
                int RowAffect = 0;
                MySqlCommand comando = new MySqlCommand();
                string SQL;

                SQL = "INSERT INTO Cliente (codigo, Nome, Cpf, Rg, Uf, DataNasc, Sexo) VALUES " + "('" + txtcodigo.Text + "', '" + txtnome.Text + "', '" + mskcpf.Text + "', '" + txtrg.Text + "', '" + cbuf.Text + "', '" + mskdata.Text + "', '" + cbsexo.Text + "')";
                conexao.Open();
                comando.Connection = conexao;
                comando.CommandText = SQL;
                

                //não deixar salvar em brancos
                if (txtcodigo.Text == "")
                {
                    MessageBox.Show("Não é possivel salvar: Existe componentes em brancos");
                }
                else if (txtnome.Text == "")
                {
                    MessageBox.Show("Não é possivel salvar: Existe componentes em brancos");
                }
                else if (mskcpf.Text == "")
                {
                    MessageBox.Show("Não é possivel salvar: Existe componentes em brancos");
                }
                else if (txtrg.Text == "")
                {
                    MessageBox.Show("Não é possivel salvar: Existe componentes em brancos");
                }
                else if (cbuf.Text == "")
                {
                    MessageBox.Show("Não é possivel salvar: Existe componentes em brancos");
                }
                else if (mskdata.Text == "")
                {
                    MessageBox.Show("Não é possivel salvar: Existe componentes em brancos");
                }
                else if (cbsexo.Text == "")
                {
                    MessageBox.Show("Não é possivel salvar: Existe componentes em brancos");
                }
                else 
                    RowAffect = comando.ExecuteNonQuery();
                //salvando
                
                if (RowAffect == 1)
                {
                    MessageBox.Show("Cadastro realizado com sucesso! ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtnome.Text = "";
                    txtcodigo.Text = "";
                    mskcpf.Text = "";
                    txtrg.Text = "";
                    cbuf.SelectedIndex = -1;
                    mskdata.Text = "";
                    cbsexo.SelectedIndex = -1;
                }
                //erro ao conectar ao banco de dados
                else
                {
                    MessageBox.Show("Cadastro não realizado!", "Aviso");
                }
                conexao.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao conectar ao banco de dados");
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

            txtcodigo.Visible = false;
            txtnome.Visible = false;
            mskcpf.Visible = false;
            txtrg.Visible = false;
            cbuf.Visible = false;
            mskdata.Visible = false;
            cbsexo.Visible = false;
            lblCodigo.Visible = false;
            lblnome.Visible = false;
            lblcpf.Visible = false;
            lblRG.Visible = false;
            lbluf.Visible = false;
            lblsexo.Visible = false;
            lbldata.Visible = false;
        }

        private void lbl1_Click(object sender, EventArgs e)
        {

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void mskCpfCliente_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void pesquisarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }

        private void excluirCadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void lblConexão_Click(object sender, EventArgs e)
        {

        }

        private void atualizarCadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.ShowDialog();
        }
    }
}