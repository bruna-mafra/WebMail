using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Mercury
{
    public partial class F_TelaInicial : Form
    {
        Form1  form1;

    

        public F_TelaInicial()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            F_Login f_Login = new F_Login();
            f_Login.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            F_CriarConta f_CriarConta = new F_CriarConta();
            f_CriarConta.ShowDialog();
        }
    }
}
