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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
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


            SQL = "SELECT * FROM Cliente WHERE Cpf = " + "'" + mskCPF.Text + "'";
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

                mskCPF.Clear();
                mskCPF.Focus();
            }
            else
            {
                MessageBox.Show("O nome é: " + nome + "\nO cpf é: " + cpf + "\nO rg é: " + rg + "\nbO UF é: " + uf + "\nA Data de nascimento é: " + dataNasc + "\nO sexo é: " + sexo, "Consulta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mskCPF.Text = cpf;
            }
            conexao.Close();
        }
    }
}
