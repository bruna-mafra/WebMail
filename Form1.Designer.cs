namespace Projeto_Mercury
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnSair = new System.Windows.Forms.Button();
            this.btnLixeira = new System.Windows.Forms.Button();
            this.btnCaixaDeSaida = new System.Windows.Forms.Button();
            this.btnCaixaDeEntrada = new System.Windows.Forms.Button();
            this.btnNovoEmail = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Black;
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.Location = new System.Drawing.Point(64, 417);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(183, 43);
            this.btnSair.TabIndex = 6;
            this.btnSair.Text = "Logout";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnLixeira
            // 
            this.btnLixeira.BackColor = System.Drawing.Color.Black;
            this.btnLixeira.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLixeira.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLixeira.ForeColor = System.Drawing.Color.White;
            this.btnLixeira.Location = new System.Drawing.Point(64, 349);
            this.btnLixeira.Name = "btnLixeira";
            this.btnLixeira.Size = new System.Drawing.Size(183, 43);
            this.btnLixeira.TabIndex = 5;
            this.btnLixeira.Text = "Lixeira";
            this.btnLixeira.UseVisualStyleBackColor = false;
            this.btnLixeira.Click += new System.EventHandler(this.btnLixeira_Click);
            // 
            // btnCaixaDeSaida
            // 
            this.btnCaixaDeSaida.BackColor = System.Drawing.Color.Black;
            this.btnCaixaDeSaida.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCaixaDeSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCaixaDeSaida.ForeColor = System.Drawing.Color.White;
            this.btnCaixaDeSaida.Location = new System.Drawing.Point(64, 280);
            this.btnCaixaDeSaida.Name = "btnCaixaDeSaida";
            this.btnCaixaDeSaida.Size = new System.Drawing.Size(183, 43);
            this.btnCaixaDeSaida.TabIndex = 3;
            this.btnCaixaDeSaida.Text = "Caixa de saída";
            this.btnCaixaDeSaida.UseVisualStyleBackColor = false;
            this.btnCaixaDeSaida.Click += new System.EventHandler(this.btnCaixaDeSaida_Click);
            // 
            // btnCaixaDeEntrada
            // 
            this.btnCaixaDeEntrada.BackColor = System.Drawing.Color.Black;
            this.btnCaixaDeEntrada.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCaixaDeEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCaixaDeEntrada.ForeColor = System.Drawing.Color.White;
            this.btnCaixaDeEntrada.Location = new System.Drawing.Point(64, 209);
            this.btnCaixaDeEntrada.Name = "btnCaixaDeEntrada";
            this.btnCaixaDeEntrada.Size = new System.Drawing.Size(183, 43);
            this.btnCaixaDeEntrada.TabIndex = 2;
            this.btnCaixaDeEntrada.Text = "Caixa de entrada";
            this.btnCaixaDeEntrada.UseVisualStyleBackColor = false;
            this.btnCaixaDeEntrada.Click += new System.EventHandler(this.btnCaixaDeEntrada_Click);
            // 
            // btnNovoEmail
            // 
            this.btnNovoEmail.BackColor = System.Drawing.Color.Black;
            this.btnNovoEmail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNovoEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoEmail.ForeColor = System.Drawing.Color.White;
            this.btnNovoEmail.Location = new System.Drawing.Point(64, 131);
            this.btnNovoEmail.Name = "btnNovoEmail";
            this.btnNovoEmail.Size = new System.Drawing.Size(183, 54);
            this.btnNovoEmail.TabIndex = 1;
            this.btnNovoEmail.Text = "Novo e-mail";
            this.btnNovoEmail.UseVisualStyleBackColor = false;
            this.btnNovoEmail.Click += new System.EventHandler(this.btnNovoEmail_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(58, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 36);
            this.label1.TabIndex = 23;
            this.label1.Text = "MercuryMail";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Modern No. 20", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblNome.Location = new System.Drawing.Point(129, 18);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(136, 22);
            this.lblNome.TabIndex = 33;
            this.lblNome.Text = "ola + nome aqui";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblNome);
            this.panel1.Controls.Add(this.btnNovoEmail);
            this.panel1.Controls.Add(this.btnSair);
            this.panel1.Controls.Add(this.btnCaixaDeEntrada);
            this.panel1.Controls.Add(this.btnLixeira);
            this.panel1.Controls.Add(this.btnCaixaDeSaida);
            this.panel1.Location = new System.Drawing.Point(212, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(309, 511);
            this.panel1.TabIndex = 34;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-243, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(473, 594);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(506, -1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(473, 594);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 36;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(754, 586);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Página Inicial";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnLixeira;
        private System.Windows.Forms.Button btnCaixaDeSaida;
        private System.Windows.Forms.Button btnCaixaDeEntrada;
        private System.Windows.Forms.Button btnNovoEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

