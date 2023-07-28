namespace Netflix_customers_Delta.Cadastro
{
    partial class FRMCadastro_de_Clientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMCadastro_de_Clientes));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BTNGravar = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BTNPesquisa = new System.Windows.Forms.Button();
            this.TXTPesquisa = new System.Windows.Forms.TextBox();
            this.DGPesquisa_usuario = new System.Windows.Forms.DataGridView();
            this.idUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TXTTelefone = new System.Windows.Forms.MaskedTextBox();
            this.TXTDtime = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TXTEmail = new System.Windows.Forms.TextBox();
            this.TXTEndereco = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TXTNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BTNLimpar = new System.Windows.Forms.Button();
            this.BTNExcluir = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGPesquisa_usuario)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // BTNGravar
            // 
            this.BTNGravar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.BTNGravar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNGravar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNGravar.Location = new System.Drawing.Point(6, 366);
            this.BTNGravar.Name = "BTNGravar";
            this.BTNGravar.Size = new System.Drawing.Size(82, 41);
            this.BTNGravar.TabIndex = 3;
            this.BTNGravar.Text = "Gravar";
            this.BTNGravar.UseVisualStyleBackColor = false;
            this.BTNGravar.Click += new System.EventHandler(this.BTNGravar_Click);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(433, 40);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(0, 13);
            this.lblId.TabIndex = 41;
            this.lblId.Visible = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BTNPesquisa);
            this.groupBox3.Controls.Add(this.TXTPesquisa);
            this.groupBox3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(449, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(544, 56);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Pesquisar";
            // 
            // BTNPesquisa
            // 
            this.BTNPesquisa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTNPesquisa.BackgroundImage")));
            this.BTNPesquisa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BTNPesquisa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNPesquisa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNPesquisa.Location = new System.Drawing.Point(457, 20);
            this.BTNPesquisa.Name = "BTNPesquisa";
            this.BTNPesquisa.Size = new System.Drawing.Size(41, 28);
            this.BTNPesquisa.TabIndex = 10;
            this.BTNPesquisa.UseVisualStyleBackColor = true;
            this.BTNPesquisa.Click += new System.EventHandler(this.BTNPesquisa_Click);
            // 
            // TXTPesquisa
            // 
            this.TXTPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTPesquisa.Location = new System.Drawing.Point(6, 21);
            this.TXTPesquisa.MaxLength = 100;
            this.TXTPesquisa.Name = "TXTPesquisa";
            this.TXTPesquisa.Size = new System.Drawing.Size(432, 26);
            this.TXTPesquisa.TabIndex = 1;
            // 
            // DGPesquisa_usuario
            // 
            this.DGPesquisa_usuario.AllowUserToAddRows = false;
            this.DGPesquisa_usuario.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Helvetica Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGPesquisa_usuario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGPesquisa_usuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGPesquisa_usuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idUsuario,
            this.email,
            this.endereco,
            this.telefone,
            this.Column2,
            this.dtime});
            this.DGPesquisa_usuario.Location = new System.Drawing.Point(449, 74);
            this.DGPesquisa_usuario.Name = "DGPesquisa_usuario";
            this.DGPesquisa_usuario.ReadOnly = true;
            this.DGPesquisa_usuario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGPesquisa_usuario.Size = new System.Drawing.Size(498, 332);
            this.DGPesquisa_usuario.TabIndex = 2;
            this.DGPesquisa_usuario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGPesquisa_usuario_CellContentClick);
            // 
            // idUsuario
            // 
            this.idUsuario.DataPropertyName = "idUsuario";
            this.idUsuario.HeaderText = "ID";
            this.idUsuario.Name = "idUsuario";
            this.idUsuario.ReadOnly = true;
            this.idUsuario.Width = 50;
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "email";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            this.email.Visible = false;
            // 
            // endereco
            // 
            this.endereco.DataPropertyName = "endereco";
            this.endereco.HeaderText = "endereco";
            this.endereco.Name = "endereco";
            this.endereco.ReadOnly = true;
            this.endereco.Visible = false;
            // 
            // telefone
            // 
            this.telefone.DataPropertyName = "telefone";
            this.telefone.HeaderText = "telefone";
            this.telefone.Name = "telefone";
            this.telefone.ReadOnly = true;
            this.telefone.Visible = false;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "nome";
            this.Column2.HeaderText = "Nome";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 350;
            // 
            // dtime
            // 
            this.dtime.DataPropertyName = "dtime";
            this.dtime.HeaderText = "Time";
            this.dtime.Name = "dtime";
            this.dtime.ReadOnly = true;
            this.dtime.Width = 53;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TXTTelefone);
            this.groupBox2.Controls.Add(this.TXTDtime);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.TXTEmail);
            this.groupBox2.Controls.Add(this.TXTEndereco);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.TXTNome);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(6, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(421, 347);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cadastrar ou alterar";
            // 
            // TXTTelefone
            // 
            this.TXTTelefone.Location = new System.Drawing.Point(88, 130);
            this.TXTTelefone.Mask = "(99)000000000";
            this.TXTTelefone.Name = "TXTTelefone";
            this.TXTTelefone.Size = new System.Drawing.Size(118, 26);
            this.TXTTelefone.TabIndex = 4;
            // 
            // TXTDtime
            // 
            this.TXTDtime.Location = new System.Drawing.Point(63, 177);
            this.TXTDtime.Mask = "00";
            this.TXTDtime.Name = "TXTDtime";
            this.TXTDtime.Size = new System.Drawing.Size(26, 26);
            this.TXTDtime.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 18);
            this.label5.TabIndex = 14;
            this.label5.Text = "Time:";
            // 
            // TXTEmail
            // 
            this.TXTEmail.Location = new System.Drawing.Point(78, 77);
            this.TXTEmail.MaxLength = 100;
            this.TXTEmail.Name = "TXTEmail";
            this.TXTEmail.Size = new System.Drawing.Size(306, 26);
            this.TXTEmail.TabIndex = 3;
            // 
            // TXTEndereco
            // 
            this.TXTEndereco.Location = new System.Drawing.Point(6, 245);
            this.TXTEndereco.MaxLength = 500;
            this.TXTEndereco.Name = "TXTEndereco";
            this.TXTEndereco.Size = new System.Drawing.Size(403, 96);
            this.TXTEndereco.TabIndex = 6;
            this.TXTEndereco.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "Endereço: ";
            // 
            // TXTNome
            // 
            this.TXTNome.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTNome.Location = new System.Drawing.Point(78, 19);
            this.TXTNome.MaxLength = 100;
            this.TXTNome.Name = "TXTNome";
            this.TXTNome.Size = new System.Drawing.Size(306, 26);
            this.TXTNome.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Telefone:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "E-mail:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nome: ";
            // 
            // BTNLimpar
            // 
            this.BTNLimpar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.BTNLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNLimpar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNLimpar.Location = new System.Drawing.Point(169, 365);
            this.BTNLimpar.Name = "BTNLimpar";
            this.BTNLimpar.Size = new System.Drawing.Size(82, 41);
            this.BTNLimpar.TabIndex = 4;
            this.BTNLimpar.Text = "Limpar";
            this.BTNLimpar.UseVisualStyleBackColor = false;
            this.BTNLimpar.Click += new System.EventHandler(this.BTNLimpar_Click);
            // 
            // BTNExcluir
            // 
            this.BTNExcluir.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.BTNExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNExcluir.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNExcluir.Location = new System.Drawing.Point(333, 366);
            this.BTNExcluir.Name = "BTNExcluir";
            this.BTNExcluir.Size = new System.Drawing.Size(82, 41);
            this.BTNExcluir.TabIndex = 5;
            this.BTNExcluir.Text = "Excluir";
            this.BTNExcluir.UseVisualStyleBackColor = false;
            this.BTNExcluir.Click += new System.EventHandler(this.BTNExcluir_Click);
            // 
            // FRMCadastro_de_Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(960, 419);
            this.Controls.Add(this.BTNGravar);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.DGPesquisa_usuario);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.BTNLimpar);
            this.Controls.Add(this.BTNExcluir);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRMCadastro_de_Clientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGPesquisa_usuario)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNGravar;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button BTNPesquisa;
        private System.Windows.Forms.TextBox TXTPesquisa;
        private System.Windows.Forms.DataGridView DGPesquisa_usuario;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TXTEmail;
        private System.Windows.Forms.RichTextBox TXTEndereco;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TXTNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTNLimpar;
        private System.Windows.Forms.Button BTNExcluir;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox TXTTelefone;
        private System.Windows.Forms.MaskedTextBox TXTDtime;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn endereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtime;
    }
}