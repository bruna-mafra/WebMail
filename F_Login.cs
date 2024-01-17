using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Mercury
{
    public partial class F_Login : Form
    {
        public F_Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;

            if (!string.IsNullOrEmpty(email))
            {
                // Realize a verificação no banco de dados
                if (EmailJaCadastrado(email))
                {
                    F_Login2 f_Login2 = new F_Login2(email);
                    f_Login2.ShowDialog();
                    txtEmail.Clear();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("E-mail não cadastrado. Por favor, verifique o e-mail informado.");
                }
            }
            else
            {
                MessageBox.Show("Preencha seu e-mail");
            }
        }

        private bool EmailJaCadastrado(string email)
        {
            // Realize a consulta no banco de dados para verificar se o e-mail já está cadastrado
            Conexao conexao = new Conexao();
            using (SqlConnection con = conexao.AbrirConexao())
            {
                string query = "SELECT COUNT(*) FROM Usuario WHERE Email = @Email";
                using (SqlCommand comando = new SqlCommand(query, con))
                {
                    comando.Parameters.AddWithValue("@Email", email);

                    // ExecuteScalar retorna a contagem de registros que correspondem ao e-mail
                    int contagem = Convert.ToInt32(comando.ExecuteScalar());

                    // Se a contagem for maior que zero, o e-mail já está cadastrado
                    return contagem > 0;
                }
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            F_CriarConta criarConta = new F_CriarConta();
            criarConta.ShowDialog();
        }
    }
}
