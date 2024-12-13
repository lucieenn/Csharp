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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            MySqlConnection conexao = new MySqlConnection("Server = localhost; Database= conexao; User ID= root; Password= ; ");
            int RowAffect = 0;
            MySqlCommand comando = new MySqlCommand();
            string SQL;

            SQL = "DELETE FROM Cliente WHERE Cpf = " + "'" + mskCpfCliente.Text + "'";
            conexao.Open();
            comando.Connection = conexao;
            comando.CommandText = SQL;
            RowAffect = comando.ExecuteNonQuery();


            if (RowAffect == 1)
            {
                MessageBox.Show("Cadastro excluido com sucesso! ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            else
            {
                MessageBox.Show("Cadastro não excluido!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            conexao.Close();
        }
    }
}
