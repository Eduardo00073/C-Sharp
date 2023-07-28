namespace Netflix_customers_Delta
{
    partial class FRMMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMMenu));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BTNCadastro_de_Clientes = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DGPesquisa_usuario = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.BTNMais = new System.Windows.Forms.Button();
            this.TXTPesquisa = new System.Windows.Forms.TextBox();
            this.BTNPesquisa = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label3 = new System.Windows.Forms.Label();
            this.BTNMenos = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.idUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGPesquisa_usuario)).BeginInit();
            this.SuspendLayout();
            // 
            // BTNCadastro_de_Clientes
            // 
            this.BTNCadastro_de_Clientes.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BTNCadastro_de_Clientes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTNCadastro_de_Clientes.BackgroundImage")));
            this.BTNCadastro_de_Clientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BTNCadastro_de_Clientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNCadastro_de_Clientes.FlatAppearance.BorderSize = 0;
            this.BTNCadastro_de_Clientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.BTNCadastro_de_Clientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.BTNCadastro_de_Clientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNCadastro_de_Clientes.Font = new System.Drawing.Font("Helvetica Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNCadastro_de_Clientes.Location = new System.Drawing.Point(59, 120);
            this.BTNCadastro_de_Clientes.Name = "BTNCadastro_de_Clientes";
            this.BTNCadastro_de_Clientes.Size = new System.Drawing.Size(122, 88);
            this.BTNCadastro_de_Clientes.TabIndex = 0;
            this.BTNCadastro_de_Clientes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BTNCadastro_de_Clientes.UseVisualStyleBackColor = true;
            this.BTNCadastro_de_Clientes.Click += new System.EventHandler(this.BTNCadastro_de_Clientes_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(-4, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1380, 104);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Helvetica Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "Consultar e Cadastrar\r\n          Clientes";
            // 
            // DGPesquisa_usuario
            // 
            this.DGPesquisa_usuario.AllowUserToAddRows = false;
            this.DGPesquisa_usuario.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Helvetica Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGPesquisa_usuario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGPesquisa_usuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGPesquisa_usuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idUsuario,
            this.Column2,
            this.email,
            this.endereco,
            this.telefone,
            this.dtime});
            this.DGPesquisa_usuario.Location = new System.Drawing.Point(261, 162);
            this.DGPesquisa_usuario.Name = "DGPesquisa_usuario";
            this.DGPesquisa_usuario.ReadOnly = true;
            this.DGPesquisa_usuario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGPesquisa_usuario.Size = new System.Drawing.Size(1077, 534);
            this.DGPesquisa_usuario.TabIndex = 40;
            this.DGPesquisa_usuario.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DGPesquisa_usuario_CellFormatting);
            this.DGPesquisa_usuario.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.DGPesquisa_usuario_RowStateChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Helvetica Narrow", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(251, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 57);
            this.label2.TabIndex = 41;
            this.label2.Text = "Lista Cliente";
            // 
            // BTNMais
            // 
            this.BTNMais.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTNMais.BackgroundImage")));
            this.BTNMais.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BTNMais.FlatAppearance.BorderSize = 0;
            this.BTNMais.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BTNMais.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BTNMais.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNMais.Location = new System.Drawing.Point(15, 640);
            this.BTNMais.Name = "BTNMais";
            this.BTNMais.Size = new System.Drawing.Size(50, 49);
            this.BTNMais.TabIndex = 42;
            this.BTNMais.UseVisualStyleBackColor = true;
            this.BTNMais.Click += new System.EventHandler(this.BTNMais_Click);
            // 
            // TXTPesquisa
            // 
            this.TXTPesquisa.Location = new System.Drawing.Point(764, 137);
            this.TXTPesquisa.Name = "TXTPesquisa";
            this.TXTPesquisa.Size = new System.Drawing.Size(527, 20);
            this.TXTPesquisa.TabIndex = 43;
            // 
            // BTNPesquisa
            // 
            this.BTNPesquisa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTNPesquisa.BackgroundImage")));
            this.BTNPesquisa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BTNPesquisa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNPesquisa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNPesquisa.Location = new System.Drawing.Point(1297, 137);
            this.BTNPesquisa.Name = "BTNPesquisa";
            this.BTNPesquisa.Size = new System.Drawing.Size(41, 20);
            this.BTNPesquisa.TabIndex = 44;
            this.BTNPesquisa.UseVisualStyleBackColor = true;
            this.BTNPesquisa.Click += new System.EventHandler(this.BTNPesquisa_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(12, 269);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 45;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Helvetica Narrow", 36F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(2, 502);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 57);
            this.label3.TabIndex = 46;
            this.label3.Text = "Tempo";
            // 
            // BTNMenos
            // 
            this.BTNMenos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTNMenos.BackgroundImage")));
            this.BTNMenos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BTNMenos.FlatAppearance.BorderSize = 0;
            this.BTNMenos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.BTNMenos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral;
            this.BTNMenos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNMenos.Location = new System.Drawing.Point(154, 640);
            this.BTNMenos.Name = "BTNMenos";
            this.BTNMenos.Size = new System.Drawing.Size(50, 49);
            this.BTNMenos.TabIndex = 47;
            this.BTNMenos.UseVisualStyleBackColor = true;
            this.BTNMenos.Click += new System.EventHandler(this.BTNMenos_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 559);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 52);
            this.label4.TabIndex = 48;
            this.label4.Text = "Todos os dias, o botão de menos \r\ndeve ser pressionado uma vez, \r\npara que assim " +
    "Netflix customers Delta \r\nretire um dia de todos usuários.";
            // 
            // idUsuario
            // 
            this.idUsuario.DataPropertyName = "idUsuario";
            this.idUsuario.HeaderText = "ID";
            this.idUsuario.Name = "idUsuario";
            this.idUsuario.ReadOnly = true;
            this.idUsuario.Width = 50;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "nome";
            this.Column2.HeaderText = "Nome";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 350;
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "E-mail";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            this.email.Width = 300;
            // 
            // endereco
            // 
            this.endereco.DataPropertyName = "endereco";
            this.endereco.HeaderText = "Endereco";
            this.endereco.Name = "endereco";
            this.endereco.ReadOnly = true;
            this.endereco.Width = 180;
            // 
            // telefone
            // 
            this.telefone.DataPropertyName = "telefone";
            this.telefone.HeaderText = "Telefone";
            this.telefone.Name = "telefone";
            this.telefone.ReadOnly = true;
            // 
            // dtime
            // 
            this.dtime.DataPropertyName = "dtime";
            this.dtime.HeaderText = "Time";
            this.dtime.Name = "dtime";
            this.dtime.ReadOnly = true;
            this.dtime.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dtime.Width = 53;
            // 
            // FRMMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1362, 701);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BTNMenos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.BTNPesquisa);
            this.Controls.Add(this.TXTPesquisa);
            this.Controls.Add(this.BTNMais);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DGPesquisa_usuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BTNCadastro_de_Clientes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FRMMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Netflix customers Delta";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FRMMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGPesquisa_usuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNCadastro_de_Clientes;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DGPesquisa_usuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BTNMais;
        private System.Windows.Forms.TextBox TXTPesquisa;
        private System.Windows.Forms.Button BTNPesquisa;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BTNMenos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn endereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtime;
    }
}

