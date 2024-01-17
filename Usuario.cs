using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Projeto_Mercury
{
    internal class Usuario
    {
        public int Id { get; set; }
        private string Nome { get; set; }
        private string Email { get; set; }
        private string Senha { get; set; }

        public Usuario() { }

        public Usuario(int id, string nome, string email, string senha)
        {
            Nome = nome;
            Email = email;
            Senha = senha;
        }

        public string getNome()
        {
            return Nome;
        }

        public string getId()
        {
            return Id.ToString();
        }

        public void cadastra()
        {
            Conexao conexao = new Conexao();
            using (SqlConnection con = conexao.AbrirConexao())
            {
                // Construa a consulta SQL para a inserção
                string query = "INSERT INTO Usuario (Nome, Email, Senha) VALUES (@Nome, @Email, @Senha); SELECT SCOPE_IDENTITY()";

                // Crie um objeto SqlCommand e configure os parâmetros
                using (SqlCommand comando = new SqlCommand(query, con))
                {
                    comando.Parameters.AddWithValue("@Nome", Nome);
                    comando.Parameters.AddWithValue("@Email", Email);
                    comando.Parameters.AddWithValue("@Senha", Senha);

                    // Execute a consulta e obtenha o ID gerado automaticamente
                    object result = comando.ExecuteScalar();

                    if (result != null && int.TryParse(result.ToString(), out int novoId))
                    {
                        // Atribua o novo ID à propriedade Id na classe Usuario
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


