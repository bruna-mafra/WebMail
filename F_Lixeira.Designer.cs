namespace Projeto_Mercury
{
    partial class F_Lixeira
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
            this.btnFechar = new System.Windows.Forms.Button();
            this.txtMensagem = new System.Windows.Forms.TextBox();
            this.txtAssunto = new System.Windows.Forms.TextBox();
            this.txtRemetente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEncaminhar = new System.Windows.Forms.Button();
            this.dataGridEmail = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Restaurar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEmail)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFechar
            // 
            this.btnFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFechar.Location = new System.Drawing.Point(262, 416);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(134, 23);
            this.btnFechar.TabIndex = 28;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // txtMensagem
            // 
            this.txtMensagem.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtMensagem.Location = new System.Drawing.Point(12, 110);
            this.txtMensagem.Multiline = true;
            this.txtMensagem.Name = "txtMensagem";
            this.txtMensagem.ReadOnly = true;
            this.txtMensagem.Size = new System.Drawing.Size(473, 286);
            this.txtMensagem.TabIndex = 27;
            // 
            // txtAssunto
            // 
            this.txtAssunto.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtAssunto.Location = new System.Drawing.Point(69, 55);
            this.txtAssunto.Name = "txtAssunto";
            this.txtAssunto.ReadOnly = true;
            this.txtAssunto.Size = new System.Drawing.Size(416, 20);
            this.txtAssunto.TabIndex = 26;
            // 
            // txtRemetente
            // 
            this.txtRemetente.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtRemetente.Location = new System.Drawing.Point(69, 14);
            this.txtRemetente.Name = "txtRemetente";
            this.txtRemetente.ReadOnly = true;
            this.txtRemetente.Size = new System.Drawing.Size(416, 20);
            this.txtRemetente.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Mensagem";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Assunto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "De";
            // 
            // btnEncaminhar
            // 
            this.btnEncaminhar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEncaminhar.Location = new System.Drawing.Point(122, 416);
            this.btnEncaminhar.Name = "btnEncaminhar";
            this.btnEncaminhar.Size = new System.Drawing.Size(134, 23);
            this.btnEncaminhar.TabIndex = 20;
            this.btnEncaminhar.Text = "Encaminhar";
            this.btnEncaminhar.UseVisualStyleBackColor = true;
            // 
            // dataGridEmail
            // 
            this.dataGridEmail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEmail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Restaurar});
            this.dataGridEmail.Location = new System.Drawing.Point(516, 12);
            this.dataGridEmail.Name = "dataGridEmail";
            this.dataGridEmail.Size = new System.Drawing.Size(455, 403);
            this.dataGridEmail.TabIndex = 29;
            this.dataGridEmail.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridEmail_CellContentClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // Restaurar
            // 
            this.Restaurar.HeaderText = "Restaurar";
            this.Restaurar.Name = "Restaurar";
            // 
            // F_Lixeira
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(999, 451);
            this.Controls.Add(this.dataGridEmail);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.txtMensagem);
            this.Controls.Add(this.txtAssunto);
            this.Controls.Add(this.txtRemetente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEncaminhar);
            this.Name = "F_Lixeira";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_Lixeira";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEmail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.TextBox txtMensagem;
        private System.Windows.Forms.TextBox txtAssunto;
        private System.Windows.Forms.TextBox txtRemetente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEncaminhar;
        private System.Windows.Forms.DataGridView dataGridEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Restaurar;
    }
}