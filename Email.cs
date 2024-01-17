using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Mercury
{
    public class Email
    {
        private int Id { get; set; }
        public int IdRemetente { get; set; }
        public int IdDestinatario { get; set; }
        //public string EmailDestinatario { get; set; }
        public string Assunto { get; set; }
        public string Mensagem { get; set; }

        public Email(int IdRemetente, int IdDestinatario, string assunto, string mensagem)
        {
            this.IdRemetente = IdRemetente;
            this.IdDestinatario = IdDestinatario;
            Assunto = assunto;
            Mensagem = mensagem;

            Conexao conexao = new Conexao();

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

        public void Enviar()
        {
            Conexao conexao = new Conexao();
            using (SqlConnection con = conexao.AbrirConexao())
            {
                // Construa a consulta SQL para a inserção
                string query = "INSERT INTO Email (IdRemetente, IdDestinatario, Assunto, Mensagem) VALUES (@IdRemetente, @IdDestinatario, @Assunto, @Mensagem); SELECT SCOPE_IDENTITY()";

                // Crie um objeto SqlCommand e configure os parâmetros
                using (SqlCommand comando = new SqlCommand(query, con))
                {
                    comando.Parameters.AddWithValue("@IdRemetente", IdRemetente);
                    comando.Parameters.AddWithValue("@IdDestinatario", IdDestinatario);
                    comando.Parameters.AddWithValue("@Assunto", Assunto);
                    comando.Parameters.AddWithValue("@Mensagem", Mensagem);


                    // Executa a consulta e obtém o ID gerado pelo BD
                    object result = comando.ExecuteScalar();

                    if (result != null && int.TryParse(result.ToString(), out int novoId))
                    {
                        // Atribui o novo ID à propriedade Id da classe Usuario
                        Id = novoId;

                        Console.WriteLine($"Usuário cadastrado com sucesso! ID: {Id}");
                    }
                    else
                    {
                        Console.WriteLine("Falha ao cadastrar usuário.");
                    }
                }

            }
        }
    }
}
