namespace Projeto_Mercury
{
    partial class F_CaixaDeEntrada
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtMensagem = new System.Windows.Forms.TextBox();
            this.txtAssunto = new System.Windows.Forms.TextBox();
            this.txtRemetente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnResponder = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.dataGridEmail = new System.Windows.Forms.DataGridView();
            this.Lido = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Lixeira = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnEncaminhar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEmail)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMensagem
            // 
            this.txtMensagem.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtMensagem.Location = new System.Drawing.Point(12, 111);
            this.txtMensagem.Multiline = true;
            this.txtMensagem.Name = "txtMensagem";
            this.txtMensagem.ReadOnly = true;
            this.txtMensagem.Size = new System.Drawing.Size(433, 286);
            this.txtMensagem.TabIndex = 17;
            // 
            // txtAssunto
            // 
            this.txtAssunto.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtAssunto.Location = new System.Drawing.Point(69, 56);
            this.txtAssunto.Name = "txtAssunto";
            this.txtAssunto.ReadOnly = true;
            this.txtAssunto.Size = new System.Drawing.Size(376, 20);
            this.txtAssunto.TabIndex = 16;
            this.txtAssunto.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtRemetente
            // 
            this.txtRemetente.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtRemetente.Location = new System.Drawing.Point(69, 15);
            this.txtRemetente.Name = "txtRemetente";
            this.txtRemetente.ReadOnly = true;
            this.txtRemetente.Size = new System.Drawing.Size(376, 20);
            this.txtRemetente.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Mensagem";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Assunto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "De";
            // 
            // btnResponder
            // 
            this.btnResponder.BackColor = System.Drawing.Color.Black;
            this.btnResponder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResponder.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResponder.ForeColor = System.Drawing.Color.White;
            this.btnResponder.Location = new System.Drawing.Point(90, 416);
            this.btnResponder.Name = "btnResponder";
            this.btnResponder.Size = new System.Drawing.Size(134, 23);
            this.btnResponder.TabIndex = 1;
            this.btnResponder.Text = "Responder";
            this.btnResponder.UseVisualStyleBackColor = false;
            this.btnResponder.Click += new System.EventHandler(this.btnResponder_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.Black;
            this.btnFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.ForeColor = System.Drawing.Color.White;
            this.btnFechar.Location = new System.Drawing.Point(823, 416);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(134, 23);
            this.btnFechar.TabIndex = 4;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // dataGridEmail
            // 
            this.dataGridEmail.AllowUserToOrderColumns = true;
            this.dataGridEmail.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridEmail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEmail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Lido,
            this.Lixeira});
            this.dataGridEmail.Location = new System.Drawing.Point(462, 18);
            this.dataGridEmail.Name = "dataGridEmail";
            this.dataGridEmail.Size = new System.Drawing.Size(520, 379);
            this.dataGridEmail.TabIndex = 18;
            this.dataGridEmail.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridEmail_CellContentClick_1);
            // 
            // Lido
            // 
            this.Lido.HeaderText = "Lido";
            this.Lido.Name = "Lido";
            // 
            // Lixeira
            // 
            this.Lixeira.HeaderText = "Lixeira";
            this.Lixeira.Name = "Lixeira";
            // 
            // btnEncaminhar
            // 
            this.btnEncaminhar.BackColor = System.Drawing.Color.Black;
            this.btnEncaminhar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEncaminhar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncaminhar.ForeColor = System.Drawing.Color.White;
            this.btnEncaminhar.Location = new System.Drawing.Point(230, 416);
            this.btnEncaminhar.Name = "btnEncaminhar";
            this.btnEncaminhar.Size = new System.Drawing.Size(134, 23);
            this.btnEncaminhar.TabIndex = 19;
            this.btnEncaminhar.Text = "Encaminhar";
            this.btnEncaminhar.UseVisualStyleBackColor = false;
            this.btnEncaminhar.Click += new System.EventHandler(this.btnEncaminhar_Click);
            // 
            // F_CaixaDeEntrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1008, 451);
            this.Controls.Add(this.btnEncaminhar);
            this.Controls.Add(this.dataGridEmail);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.txtMensagem);
            this.Controls.Add(this.txtAssunto);
            this.Controls.Add(this.txtRemetente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnResponder);
            this.Name = "F_CaixaDeEntrada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Caixa De Entrada";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEmail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMensagem;
        private System.Windows.Forms.TextBox txtAssunto;
        private System.Windows.Forms.TextBox txtRemetente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnResponder;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.DataGridView dataGridEmail;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Lido;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Lixeira;
        private System.Windows.Forms.Button btnEncaminhar;
    }
}