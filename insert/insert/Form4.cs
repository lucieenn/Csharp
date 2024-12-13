using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace insert
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtcodigo.Text = string.Empty;
            txtnome.Text = string.Empty;
            mskcpf.Text = string.Empty;
            txtrg.Text = string.Empty;
            cbuf.SelectedIndex = -1;
            mskdata.Text = string.Empty;
            cbsexo.SelectedIndex = -1;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            MySqlConnection conexao = new MySqlConnection("Server = localhost; Database= conexao; User ID= root; Password= ; ");
            int RowAffect = 0;
            MySqlCommand comando = new MySqlCommand();
            string SQL;

            SQL = "UPDATE Cliente SET  Nome = '" + txtnome.Text + "', Rg = '" + txtrg.Text + "', Uf= '" + cbuf.Text + "', dataNasc ='" + mskdata.Text + "', Sexo='" + cbsexo.Text + "' where Cpf = " + "'" + mskCPFvalidar.Text + "'" + ";";
            conexao.Open();
            comando.Connection = conexao;
            comando.CommandText = SQL;
           
            //não deixar salvar em brancos
            
             if (txtnome.Text == "")
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
                MessageBox.Show("Cadastro atualizado com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Cadastro não atualizado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            MySqlConnection conexao = new MySqlConnection("Server = localhost; Database= conexao; User ID= root; Password= ; ");
            int RowAffect = 0;
            string nome = "";
            string cpf = "";
            string rg = "";
            string uf = "";
            string dataNasc = "";
            string sexo = "";
            MySqlDataReader dr;
            MySqlCommand comando = new MySqlCommand();
            string SQL;


            SQL = "SELECT * FROM Cliente WHERE Cpf = " + "'" + mskCPFvalidar.Text + "'";
            conexao.Open();
            comando.Connection = conexao;
            comando.CommandText = SQL;
            dr = comando.ExecuteReader();

            while (dr.Read())
            {
                nome = dr.GetString(1);
                cpf = dr.GetString(2);
                rg = dr.GetString(3);
                uf = dr.GetString(4);
                dataNasc = dr.GetString(5);
                sexo = dr.GetString(6);
            }

            if (nome.ToString() == "" && cpf.ToString() == "" && rg.ToString() == "" && uf.ToString() == "" && dataNasc.ToString() == "" && sexo.ToString() == "")
            {
                MessageBox.Show("Não existe esse registro no banco de dados!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                mskCPFvalidar.Clear();
                mskCPFvalidar.Focus();
            }
            else
            {
                //habilitar labels
                lblCodigo.Visible = true;
                lblnome.Visible = true;
                lbldata.Visible = true;
                lblRG.Visible = true;
                lbluf.Visible = true;
                lblcpf2.Visible = true;
                lblatualizar.Visible = true;

                //habilitar caixas de texto
                mskcpf2.Visible = true;
                lblsexo.Visible = true;
                txtcodigo.Visible = true;
                txtnome.Visible = true;
                txtrg.Visible = true;
                cbuf.Visible = true;
                mskdata.Visible = true;
                cbsexo.Visible = true;
                btnlimpar.Visible = true;
                btnatualizar.Visible=true;

                //desabilitar 
                lblpesquisar.Visible = false;
                mskCPFvalidar.Visible = false;
                btnPesquisar.Visible = false;
                txtcodigo.Enabled = false;



                //
                txtnome.Text = nome;
                txtrg.Text = rg;
                cbuf.Text = uf;
                mskdata.Text = dataNasc;
                cbsexo.Text = sexo;

            }
            conexao.Close();
        }
    }
}

