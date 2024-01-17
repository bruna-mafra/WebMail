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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Projeto_Mercury
{
    public partial class F_Login2 : Form
    {
        private int IdUsuario;
        private string Email;
        private string NomeUsuario;
        public F_Login2(string Email)
        {
            InitializeComponent();
            this.Email = Email;
            NomeUsuario = ObterNomePorEmail(this.Email);
            IdUsuario = int.Parse(obterIdPorEmail(Email));
            lblOla.Text = "Olá, " + this.NomeUsuario + "!";
            txtEmail.Text = this.Email;
            txtEmail.ReadOnly = true;
        }

        private void btnAvancar_Click(object sender, EventArgs e)
        {
            string senha = txtSenha.Text;

            if (!string.IsNullOrEmpty(senha))
            {
                string senhaDigitada = senha; // Substitua pela senha digitada pelo usuário
                string hashSenhaDigitada = HashHelper.CriarHashSenha(senhaDigitada);

                if (verificaSenha(this.Email, hashSenhaDigitada))
                {
                    Form1 entrada = new Form1(IdUsuario, NomeUsuario);
                    entrada.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Senha incorreta");
                }

            }
            else
            {
                MessageBox.Show("Preencha sua senha");
            }
        }

        private bool verificaSenha(string email, string senha)
        {
            Conexao conexao = new Conexao();
            using (SqlConnection con = conexao.AbrirConexao())
            {
                string query = "SELECT Senha FROM Usuario WHERE Email = @Email";
                using (SqlCommand comando = new SqlCommand(query, con))
                {
                    comando.Parameters.AddWithValue("@Email", email);

                    // ExecuteScalar retorna a senha correspondente ao e-mail
                    string senhaDoBanco = comando.ExecuteScalar().ToString();

                    // Verifique se a senha fornecida é igual à senha no banco de dados
                    return senha == senhaDoBanco;
                }
            }
        }

   


        private string ObterNomePorEmail(string email)
        {
            Conexao conexao = new Conexao();
            using (SqlConnection con = conexao.AbrirConexao())
            {
                string query = "SELECT Nome FROM Usuario WHERE Email = @Email";
                using (SqlCommand comando = new SqlCommand(query, con))
                {
                    comando.Parameters.AddWithValue("@Email", email);

                    // ExecuteScalar retorna o nome correspondente ao e-mail
                    object result = comando.ExecuteScalar();

                    // Verifica se o resultado não é nulo antes de retornar
                    return result != null ? result.ToString() : null;
                }
            }
        }

        private void checkSenha_CheckedChanged(object sender, EventArgs e)
        {
            txtSenha.UseSystemPasswordChar = !checkSenha.Checked;

        }
        private string obterIdPorEmail(string email)
        {
            Conexao conexao = new Conexao();
            using (SqlConnection con = conexao.AbrirConexao())
            {
                string query = "SELECT Id FROM Usuario WHERE Email = @Email";
                using (SqlCommand comando = new SqlCommand(query, con))
                {
                    comando.Parameters.AddWithValue("@Email", email);

                    // ExecuteScalar retorna o nome correspondente ao e-mail
                    object result = comando.ExecuteScalar();

                    // Verifica se o resultado não é nulo antes de retornar
                    return result != null ? result.ToString() : null;
                }
            }
        }
    }
}
