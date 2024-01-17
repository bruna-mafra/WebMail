using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Mercury
{
    public partial class Form1 : Form
    {
        private int IdUsuario { get; set; }
        private string NomeUsuario { get; set; }

        public Form1(int IdUsuario, string NomeUsuario)
        {
            InitializeComponent();
            this.NomeUsuario = NomeUsuario;
            lblNome.Text = "Olá, " + this.NomeUsuario;
            this.IdUsuario = IdUsuario;
            // vou comecar aqui

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnNovoEmail_Click(object sender, EventArgs e)
        {
            F_NovoEmail novoEmail = new F_NovoEmail(IdUsuario);
            novoEmail.Show();
        }

        private void btnCaixaDeEntrada_Click(object sender, EventArgs e)
        {
            F_CaixaDeEntrada caixaDeEntrada = new F_CaixaDeEntrada(IdUsuario);
            caixaDeEntrada.Show();

        }

        private void btnCaixaDeSaida_Click(object sender, EventArgs e)
        {
            F_CaixaDeSaida caixaDeSaida = new F_CaixaDeSaida(IdUsuario);
            caixaDeSaida.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            F_TelaInicial telaInicial = new F_TelaInicial();
            telaInicial.Show();
            this.Close();

        }

        private void btnLixeira_Click(object sender, EventArgs e)
        {
            F_Lixeira lixeira = new F_Lixeira(IdUsuario);
            lixeira.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
