using System;
using System.Collections;
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
    public partial class F_CaixaDeSaida : Form
    {
        private int IdUsuario;
        public F_CaixaDeSaida(int IdUsuario)
        {
            InitializeComponent();
            this.IdUsuario = IdUsuario;

            Conexao conexao = new Conexao();
            using (SqlConnection con = conexao.AbrirConexao())
            {
                // Construa a consulta SQL para a seleção com JOIN entre as tabelas Email e Usuario
                string query = "SELECT E.LixeiraRemetente, E.Id, E.Assunto, U.Email, E.Mensagem " +
                               "FROM Email E " +
                               "INNER JOIN Usuario U ON E.IdDestinatario = U.Id " +
                               "WHERE E.IdRemetente = @IdRemetente AND LixeiraRemetente = 0";

                // Crie um objeto SqlCommand e configure os parâmetros
                using (SqlCommand comando = new SqlCommand(query, con))
                {
                    comando.Parameters.AddWithValue("@IdRemetente", IdUsuario);

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

                    dataGridEmail.SelectionChanged += DataGridEmail_SelectionChanged;

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
            colunaEmail.DataPropertyName = "Email";
            colunaEmail.HeaderText = "Email";
            colunaEmail.Name = "Email";
            colunaEmail.ReadOnly = true;
            dataGridEmail.Columns.Add(colunaEmail);

            DataGridViewTextBoxColumn colunaMensagem = new DataGridViewTextBoxColumn();
            colunaMensagem.DataPropertyName = "Mensagem";
            colunaMensagem.HeaderText = "Mensagem";
            colunaMensagem.Name = "Mensagem";
            colunaMensagem.ReadOnly = true;
            dataGridEmail.Columns.Add(colunaMensagem);


            DataGridViewCheckBoxColumn colunaLixeira = new DataGridViewCheckBoxColumn();
            colunaLixeira.HeaderText = "Lixeira";
            colunaLixeira.Name = "Lixeira";
            colunaLixeira.ReadOnly = false;
            colunaLixeira.DataPropertyName = "LixeiraRemetente"; // Substitua pelo nome real da coluna do seu banco de dados
            dataGridEmail.Columns.Insert(0, colunaLixeira); // Inserir como a primeira coluna

            DataGridViewTextBoxColumn colunaId = new DataGridViewTextBoxColumn();
            colunaId.Name = "Id";
            colunaId.DataPropertyName = "Id";
            colunaId.HeaderText = "Id";
            colunaId.ReadOnly = true;
            colunaId.Visible = false;
            dataGridEmail.Columns.Add(colunaId);

            // Configurações adicionais, se necessário
            dataGridEmail.AutoGenerateColumns = false;
            dataGridEmail.AllowUserToAddRows = false;
        }



        private void DataGridEmail_SelectionChanged(object sender, EventArgs e)
        {
          
        }

        private void LimparTextBoxes()
        {
            txtMensagem.Text = string.Empty;
            txtDestinatario.Text = string.Empty;
            txtMensagem.Text = string.Empty;
        }

        private void dataGridEmail_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
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

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Obter os valores das colunas relevantes
                string assunto = dataGridEmail.Rows[e.RowIndex].Cells["Assunto"].Value.ToString();
                string remetente = dataGridEmail.Rows[e.RowIndex].Cells["Email"].Value.ToString();
                string mensagem = dataGridEmail.Rows[e.RowIndex].Cells["Mensagem"].Value.ToString();

                // Preencher os campos de texto com os detalhes do email
                txtAssunto.Text = assunto;
                txtDestinatario.Text = remetente;
                txtMensagem.Text = mensagem;
            }
        }

        private void AtualizarEstadoLixeiraNoBancoDeDados(int rowIndex, bool novoEstadoLeitura, int Id)
        {
            // Atualizar o banco de dados com o novo estado de leitura
            using (SqlConnection con = new SqlConnection("Server=(localdb)\\MSSQLLocalDB; Database=WebMailDB;"))
            {
                con.Open();
                string query = "UPDATE Email SET LixeiraRemetente = @Lixeira WHERE Id = @Id";
                using (SqlCommand comando = new SqlCommand(query, con))
                {
                    comando.Parameters.AddWithValue("@Lixeira", novoEstadoLeitura);
                    comando.Parameters.AddWithValue("@Id", Id);
                    comando.ExecuteNonQuery();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            F_NovoEmail encaminhar = new F_NovoEmail(IdUsuario, txtAssunto.Text, txtMensagem.Text);
            encaminhar.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}



