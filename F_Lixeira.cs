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
    public partial class F_Lixeira : Form
    {
        private int IdUsuario;
        public F_Lixeira(int IdUsuario)
        {
            InitializeComponent();
            this.IdUsuario = IdUsuario;

            Conexao conexao = new Conexao();
            using (SqlConnection con = conexao.AbrirConexao())
            {
                // Construa a consulta SQL para a seleção com JOIN entre as tabelas Email e Usuario
                string query = "SELECT E.LixeiraDestinatario, E.Lido, E.Id, E.Assunto, U.Email, E.Mensagem " +
                               "FROM Email E " +
                               "INNER JOIN Usuario U ON E.IdRemetente = U.Id " +
                               "WHERE E.IdDestinatario = @IdDestinatario AND E.LixeiraDestinatario = 1";

                // Crie um objeto SqlCommand e configure os parâmetros
                using (SqlCommand comando = new SqlCommand(query, con))
                {
                    comando.Parameters.AddWithValue("@IdDestinatario", IdUsuario);

                    // Crie um objeto DataTable para armazenar os resultados da consulta
                    DataTable dataTable = new DataTable();

                    // Crie um adaptador de dados para preencher o DataTable com os resultados da consulta
                    using (SqlDataAdapter adaptador = new SqlDataAdapter(comando))
                    {
                        // Preencha o DataTable com os resultados da consulta
                        adaptador.Fill(dataTable);

                    }

                    // Associe o DataTable à DataGridView
                    dataGridEmail.DataSource = dataTable;

                    // Configure manualmente as colunas desejadas
                    ConfigurarDataGridView();

                    //dataGridEmail.SelectionChanged += DataGridEmail_SelectionChanged;
                }
            }
        }

        private void ConfigurarDataGridView()
        {
            // Limpe as colunas existentes (caso já existam)
            dataGridEmail.Columns.Clear();

            // Adicione manualmente as colunas desejadas
            DataGridViewTextBoxColumn colunaAssunto = new DataGridViewTextBoxColumn();
            colunaAssunto.Name = "Assunto";
            colunaAssunto.DataPropertyName = "Assunto";
            colunaAssunto.HeaderText = "Assunto";
            colunaAssunto.ReadOnly = true;
            dataGridEmail.Columns.Add(colunaAssunto);
            

            DataGridViewTextBoxColumn colunaEmail = new DataGridViewTextBoxColumn();
            colunaEmail.Name = "Remetente";
            colunaEmail.DataPropertyName = "Email";
            colunaEmail.HeaderText = "Remetente";
            colunaEmail.ReadOnly = true;
            dataGridEmail.Columns.Add(colunaEmail);

            DataGridViewTextBoxColumn colunaMensagem = new DataGridViewTextBoxColumn();
            colunaMensagem.Name = "Mensagem";
            colunaMensagem.DataPropertyName = "Mensagem";
            colunaMensagem.HeaderText = "Mensagem";
            colunaMensagem.ReadOnly = true;
            dataGridEmail.Columns.Add(colunaMensagem);

            DataGridViewTextBoxColumn colunaId = new DataGridViewTextBoxColumn();
            colunaId.Name = "Id";
            colunaId.DataPropertyName = "Id";
            colunaId.HeaderText = "Id";
            colunaId.ReadOnly = true;
            colunaId.Visible = false;
            dataGridEmail.Columns.Add(colunaId);

            DataGridViewCheckBoxColumn colunaLixeira = new DataGridViewCheckBoxColumn();
            colunaLixeira.HeaderText = "Lixeira";
            colunaLixeira.Name = "Lixeira";
            colunaLixeira.ReadOnly = false;
            colunaLixeira.DataPropertyName = "LixeiraDestinatario"; // Substitua pelo nome real da coluna do seu banco de dados
            dataGridEmail.Columns.Insert(1, colunaLixeira); // Inserir como a primeira coluna

            // Configurações adicionais, se necessário
            dataGridEmail.AutoGenerateColumns = false;
            dataGridEmail.AllowUserToAddRows = false;
        }

        private void AtualizarEstadoLixeiraNoBancoDeDados(int rowIndex, bool novoEstadoLeitura, int Id)
        {
            // Atualizar o banco de dados com o novo estado de leitura
            using (SqlConnection con = new SqlConnection("Server=(localdb)\\MSSQLLocalDB; Database=WebMailDB;"))
            {
                con.Open();
                string query = "UPDATE Email SET LixeiraDestinatario = @Lixeira WHERE Id = @Id";
                using (SqlCommand comando = new SqlCommand(query, con))
                {
                    comando.Parameters.AddWithValue("@Lixeira", novoEstadoLeitura);
                    comando.Parameters.AddWithValue("@Id", Id);
                    comando.ExecuteNonQuery();
                }
            }
        }

        private void dataGridEmail_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dataGridEmail_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


            if (e.ColumnIndex == 1 && e.RowIndex >= 0)
            {
                // Obter o valor atual da célula "Lido"
                bool valorAtual = (bool)dataGridEmail.Rows[e.RowIndex].Cells["Lixeira"].Value;

                // Obter o valor da célula "Id"
                int idEmail = Convert.ToInt32(dataGridEmail.Rows[e.RowIndex].Cells["Id"].Value);

                // Inverter o valor (marcar como lido ou não lido)
                dataGridEmail.Rows[e.RowIndex].Cells["Lixeira"].Value = !valorAtual;

                // Atualizar o banco de dados com o novo estado de leitura
                AtualizarEstadoLixeiraNoBancoDeDados(e.RowIndex, !valorAtual, idEmail);
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
