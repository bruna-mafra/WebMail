using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Mercury
{
    public partial class F_CriarConta : Form
    {
        public F_CriarConta()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string senha = txtSenha.Text;
            int pontuacao = AvaliarForcaSenha(senha);

            if (txtConfirmarEmail.Text != txtEmail.Text) {
                MessageBox.Show("Confirme seu e-mail corretamente");
            }

            else if(txtConfirmarSenha.Text != txtSenha.Text) {
                MessageBox.Show("Confirme sua senha corretamente");
            }

            else
            {
                if ((!txtNome.Text.Equals("")) && (!txtSobrenome.Text.Equals("")) && (!txtEmail.Text.Equals("")) && (!txtConfirmarEmail.Text.Equals("")) && (!txtSenha.Text.Equals("")) && (!txtConfirmarSenha.Text.Equals("")))
                {
                    if (txtEmail.Text.Contains("@") && (pontuacao >= 8))
                    {
                        // Antes de armazenar a senha no banco de dados, crie o hash da senha
                        string password = txtSenha.Text; // Substitua pela senha real fornecida pelo usuário
                        string hashSenha = HashHelper.CriarHashSenha(password);

                        // Agora, você pode armazenar o hashSenha no banco de dados
                        // Certifique-se de armazenar apenas o hash, não a senha original

                        Usuario cadUsuario = new Usuario(0, txtNome.Text, txtEmail.Text, hashSenha);
                        cadUsuario.cadastra();
                        //MessageBox.Show("O ID deste usuário é: " + cadUsuario.getId());
                        Form1 entrada = new Form1(int.Parse(cadUsuario.getId()), cadUsuario.getNome());
                        entrada.Show();
                    }
                    else
                    {
                        MessageBox.Show("O campo de e-mail deve conter o caractere '@'");
                    }
                }
                else
                {
                    MessageBox.Show("Preencha todos os campos");
                }
            }
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
            string senha = txtSenha.Text;
            int pontuacao = AvaliarForcaSenha(senha);

            AtualizarForcaSenhaLabel(pontuacao);
        }

        private int AvaliarForcaSenha(string senha)
        {
            int pontuacao = 0;

            // Critérios básicos (pode adicionar mais critérios conforme necessário)
            if (senha.Length >= 8)
                pontuacao += 2;

            if (Regex.IsMatch(senha, "[a-z]"))
                pontuacao += 2;

            if (Regex.IsMatch(senha, "[A-Z]"))
                pontuacao += 2;

            if (Regex.IsMatch(senha, "[0-9]"))
                pontuacao += 2;

            if (Regex.IsMatch(senha, "[!@#$%^&*(),.?\":{}|<>]"))
                pontuacao += 2;

            return pontuacao;
        }

        private void AtualizarForcaSenhaLabel(int pontuacao) 
        {
            if (pontuacao <= 4)
            {
                lblForcaSenha.Text = "Senha Fraca";
                lblForcaSenha.ForeColor = Color.Red;
            }
            else if (pontuacao <= 8)
            {
                lblForcaSenha.Text = "Senha Média";
                lblForcaSenha.ForeColor = Color.Orange;

            }
            else
            {
                lblForcaSenha.Text = "Senha Forte";
                lblForcaSenha.ForeColor = Color.Green;

            }
        }

    }
}
