using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Projeto_Mercury
{
    public class Conexao
    {
        private string cadeiaConexao;
        private SqlConnection conexao;
        private string servidor = "(localdb)\\MSSQLLocalDB";
        private string dataBase = "WebMailDB";

        public Conexao()
        {
            // Construa a string de conexão
            cadeiaConexao = $"Server={servidor};Database={dataBase};";
            conexao = new SqlConnection(cadeiaConexao);
        }

        public SqlConnection AbrirConexao()
        {
            try
            {
                if (conexao.State == System.Data.ConnectionState.Closed)
                {
                    conexao.Open();
                    Console.WriteLine("Conexão aberta com sucesso!");
                }
                return conexao;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao abrir a conexão: {ex.Message}");
                return null;
            }
        }

        public void FecharConexao()
        {
            try
            {
                if (conexao.State == System.Data.ConnectionState.Open)
                {
                    conexao.Close();
                    Console.WriteLine("Conexão fechada com sucesso!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao fechar a conexão: {ex.Message}");
            }
        }

        public static void CriarBancoDados()
        {
            try
            {
                using (SqlConnection conexaoMaster = new SqlConnection("Server=(localdb)\\MSSQLLocalDB"))
                {
                    conexaoMaster.Open();

                    string comandoVerificacao = $"SELECT database_id FROM sys.databases WHERE Name = 'WebMailDB'";
                    using (SqlCommand cmdVerificacao = new SqlCommand(comandoVerificacao, conexaoMaster))
                    {
                        object resultado = cmdVerificacao.ExecuteScalar();
                        if (resultado == null || resultado == DBNull.Value)
                        {
                            // O banco de dados não existe, então cria
                            string comandoCriacaoBanco = $"CREATE DATABASE WebMailDB";
                            using (SqlCommand cmdCriacaoBanco = new SqlCommand(comandoCriacaoBanco, conexaoMaster))
                            {
                                cmdCriacaoBanco.ExecuteNonQuery();
                                MessageBox.Show($"Banco de dados 'WebMailDB' criado com sucesso.");
                            }
                        }
                        else
                        {
                            MessageBox.Show($"O banco de dados 'WebMailDB' já existe.");
                        }
                    }
                }

                // Após criar o banco de dados, chama o método para criar as tabelas
                CriarTabelas();
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Erro ao criar o banco de dados: {ex.Message}");
            }
        }

        public static void CriarTabelas()
        {
            try
            {
                // Corrigir a string de conexão para apontar para o banco de dados correto
                using (SqlConnection conexao = new SqlConnection("Server=(localdb)\\MSSQLLocalDB;Database=WebMailDB;"))
                {
                    conexao.Open();

                    string scriptCriacaoTabelas = @"
CREATE TABLE Usuario (
    Id INT IDENTITY(1, 1) PRIMARY KEY,
    nome VARCHAR(100) NOT NULL,
    email VARCHAR(100) NOT NULL,
    senha VARCHAR(100) NOT NULL
);
CREATE TABLE Email (
    Id INT IDENTITY(1, 1) PRIMARY KEY,
    IdRemetente INT NOT NULL,
    IdDestinatario INT NOT NULL,
    Assunto VARCHAR(50) NOT NULL,
    Mensagem VARCHAR(200) NOT NULL,
    LixeiraRemetente BIT DEFAULT (0) NOT NULL,
    LixeiraDestinatario BIT DEFAULT (0) NOT NULL,
    Lido BIT DEFAULT (0) NOT NULL,
    FOREIGN KEY (IdRemetente) REFERENCES Usuario(Id),
    FOREIGN KEY (IdDestinatario) REFERENCES Usuario(Id)
);
";

                    using (SqlCommand cmd = new SqlCommand(scriptCriacaoTabelas, conexao))
                    {
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Tabelas criadas com sucesso!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao criar as tabelas: {ex.Message}");
            }
        }

    }
}

