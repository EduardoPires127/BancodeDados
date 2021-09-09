
namespace Banco_de_Dados
{
    partial class atualiza
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
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbCategoria = new System.Windows.Forms.TextBox();
            this.lbCategoria = new System.Windows.Forms.Label();
            this.tbDescricao = new System.Windows.Forms.TextBox();
            this.lbDescricao = new System.Windows.Forms.Label();
            this.tbAno = new System.Windows.Forms.TextBox();
            this.lbAno = new System.Windows.Forms.Label();
            this.dgCatalogo = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btInserir = new System.Windows.Forms.Button();
            this.lbName = new System.Windows.Forms.Label();
            this.btLimpar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgCatalogo)).BeginInit();
            this.SuspendLayout();
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(116, 45);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 22);
            this.tbName.TabIndex = 3;
            // 
            // tbCategoria
            // 
            this.tbCategoria.Location = new System.Drawing.Point(341, 44);
            this.tbCategoria.Name = "tbCategoria";
            this.tbCategoria.Size = new System.Drawing.Size(100, 22);
            this.tbCategoria.TabIndex = 5;
            // 
            // lbCategoria
            // 
            this.lbCategoria.AutoSize = true;
            this.lbCategoria.Location = new System.Drawing.Point(266, 47);
            this.lbCategoria.Name = "lbCategoria";
            this.lbCategoria.Size = new System.Drawing.Size(69, 17);
            this.lbCategoria.TabIndex = 4;
            this.lbCategoria.Text = "Categoria";
            // 
            // tbDescricao
            // 
            this.tbDescricao.Location = new System.Drawing.Point(562, 44);
            this.tbDescricao.Name = "tbDescricao";
            this.tbDescricao.Size = new System.Drawing.Size(100, 22);
            this.tbDescricao.TabIndex = 7;
            // 
            // lbDescricao
            // 
            this.lbDescricao.AutoSize = true;
            this.lbDescricao.Location = new System.Drawing.Point(485, 47);
            this.lbDescricao.Name = "lbDescricao";
            this.lbDescricao.Size = new System.Drawing.Size(71, 17);
            this.lbDescricao.TabIndex = 6;
            this.lbDescricao.Text = "Descrição";
            // 
            // tbAno
            // 
            this.tbAno.Location = new System.Drawing.Point(738, 45);
            this.tbAno.Name = "tbAno";
            this.tbAno.Size = new System.Drawing.Size(116, 22);
            this.tbAno.TabIndex = 9;
            // 
            // lbAno
            // 
            this.lbAno.AutoSize = true;
            this.lbAno.Location = new System.Drawing.Point(699, 47);
            this.lbAno.Name = "lbAno";
            this.lbAno.Size = new System.Drawing.Size(33, 17);
            this.lbAno.TabIndex = 8;
            this.lbAno.Text = "Ano";
            // 
            // dgCatalogo
            // 
            this.dgCatalogo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCatalogo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colNome,
            this.colCategoria,
            this.colDescricao,
            this.colAno});
            this.dgCatalogo.Location = new System.Drawing.Point(38, 185);
            this.dgCatalogo.Name = "dgCatalogo";
            this.dgCatalogo.RowHeadersWidth = 51;
            this.dgCatalogo.RowTemplate.Height = 24;
            this.dgCatalogo.Size = new System.Drawing.Size(885, 253);
            this.dgCatalogo.TabIndex = 10;
            // 
            // colID
            // 
            this.colID.HeaderText = "ID";
            this.colID.MinimumWidth = 6;
            this.colID.Name = "colID";
            this.colID.Width = 30;
            // 
            // colNome
            // 
            this.colNome.HeaderText = "Nome";
            this.colNome.MinimumWidth = 6;
            this.colNome.Name = "colNome";
            this.colNome.Width = 200;
            // 
            // colCategoria
            // 
            this.colCategoria.HeaderText = "Categoria";
            this.colCategoria.MinimumWidth = 6;
            this.colCategoria.Name = "colCategoria";
            this.colCategoria.Width = 80;
            // 
            // colDescricao
            // 
            this.colDescricao.HeaderText = "Descrição";
            this.colDescricao.MinimumWidth = 6;
            this.colDescricao.Name = "colDescricao";
            this.colDescricao.Width = 250;
            // 
            // colAno
            // 
            this.colAno.HeaderText = "Ano";
            this.colAno.MinimumWidth = 6;
            this.colAno.Name = "colAno";
            this.colAno.Width = 50;
            // 
            // btInserir
            // 
            this.btInserir.Location = new System.Drawing.Point(68, 122);
            this.btInserir.Name = "btInserir";
            this.btInserir.Size = new System.Drawing.Size(75, 23);
            this.btInserir.TabIndex = 11;
            this.btInserir.Text = "Inserir";
            this.btInserir.UseVisualStyleBackColor = true;
            this.btInserir.Click += new System.EventHandler(this.btInserir_Click);
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(65, 47);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(45, 17);
            this.lbName.TabIndex = 13;
            this.lbName.Text = "Nome";
            // 
            // btLimpar
            // 
            this.btLimpar.Location = new System.Drawing.Point(172, 122);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(75, 23);
            this.btLimpar.TabIndex = 14;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.UseVisualStyleBackColor = true;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click_1);
            // 
            // atualiza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 450);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.btInserir);
            this.Controls.Add(this.dgCatalogo);
            this.Controls.Add(this.tbAno);
            this.Controls.Add(this.lbAno);
            this.Controls.Add(this.tbDescricao);
            this.Controls.Add(this.lbDescricao);
            this.Controls.Add(this.tbCategoria);
            this.Controls.Add(this.lbCategoria);
            this.Controls.Add(this.tbName);
            this.Name = "atualiza";
            this.Text = "Banco de Dados";
            this.Load += new System.EventHandler(this.atualiza_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgCatalogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbCategoria;
        private System.Windows.Forms.Label lbCategoria;
        private System.Windows.Forms.TextBox tbDescricao;
        private System.Windows.Forms.Label lbDescricao;
        private System.Windows.Forms.TextBox tbAno;
        private System.Windows.Forms.Label lbAno;
        private System.Windows.Forms.DataGridView dgCatalogo;
        private System.Windows.Forms.Button btInserir;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAno;
        private System.Windows.Forms.Button btLimpar;
    }
}

