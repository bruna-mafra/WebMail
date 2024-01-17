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
    public partial class F_NovoEmail : Form
    {
        private int IdUsuario;
        private string emailDestinatario;
        private string assuntoEncaminhado;
        private string mensagemEncaminhada;


        public F_NovoEmail(int IdUsuario)
        {
            InitializeComponent();
            this.IdUsuario = IdUsuario;
        }

        public F_NovoEmail(int IdUsuario, string email)
        {
            InitializeComponent();
            this.IdUsuario = IdUsuario;
            this.emailDestinatario = email;
            txtDestinatario.Text = this.emailDestinatario;
        }

        public F_NovoEmail(int IdUsuario, string assunto, string mensagem) {
            InitializeComponent();
            this.IdUsuario = IdUsuario;
            this.assuntoEncaminhado = assunto;
            this.mensagemEncaminhada = mensagem;
            txtAssunto.Text = this.assuntoEncaminhado;
            txtMensagem.Text = this.mensagemEncaminhada;
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            string emailDestinatario = txtDestinatario.Text;

            // Verificar se o email existe e obter o ID
            int IdDestinatario = ObterIdDoEmail(emailDestinatario);

            if (IdDestinatario != -1)
            {
                // O email existe, e idDoEmail contém o ID associado a ele
                // Faça o que for necessário com o ID (por exemplo, envie o email)
                Conexao conexao = new Conexao();
                using (SqlConnection con = conexao.AbrirConexao())
                {
                    // Construa a consulta SQL para a inserção
                    string query = "INSERT INTO Email (IdRemetente, IdDestinatario, Assunto, Mensagem) VALUES (@IdRemetente, @IdDestinatario, @Assunto, @Mensagem); SELECT SCOPE_IDENTITY()";

                    // Crie um objeto SqlCommand e configure os parâmetros
                    using (SqlCommand comando = new SqlCommand(query, con))
                    {
                        comando.Parameters.AddWithValue("@IdRemetente", IdUsuario);
                        comando.Parameters.AddWithValue("@IdDestinatario", IdDestinatario);
                        comando.Parameters.AddWithValue("@Assunto", txtAssunto.Text);
                        comando.Parameters.AddWithValue("@Mensagem", txtMensagem.Text);


                        // Execute a consulta e obtenha o ID gerado automaticamente
                        object result = comando.ExecuteScalar();

                        if (result != null && int.TryParse(result.ToString(), out int novoId))
                        {
                            //Console.WriteLine($"Usuário cadastrado com sucesso! ID: {Id}");
                            MessageBox.Show("Email enviado com sucesso!");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Falha ao cadastrar usuário.");
                        }
                    }
                }

            }
            else
            {
                // O email não foi encontrado no banco de dados
                MessageBox.Show("Email não cadastrado no Mercury");
            }


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtDestinatario.Clear();
            txtAssunto.Clear();
            txtMensagem.Clear();
;        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private int ObterIdDoEmail(string email)
        {
            int idDoEmail = -1; // Valor padrão indicando que o email não foi encontrado

            // Lógica para conectar ao banco de dados e realizar a consulta
            Conexao conexao = new Conexao();
            using (SqlConnection con = conexao.AbrirConexao())
            {

                string query = "SELECT Id FROM Usuario WHERE Email = @Email";

                using (SqlCommand command = new SqlCommand(query, con))
                {
                    command.Parameters.AddWithValue("@Email", email);

                    // ExecuteScalar retorna o valor da primeira coluna da primeira linha do resultado da consulta
                    object result = command.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        idDoEmail = Convert.ToInt32(result);
                    }
                }
            }

            return idDoEmail;

        }
    }
}
