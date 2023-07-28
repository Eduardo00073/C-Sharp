using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Netflix_customers_Delta.Cadastro
{
    public partial class FRMCadastro_de_Clientes : Form
    {
        public FRMCadastro_de_Clientes()
        {
            InitializeComponent();
        }

        #region Função Limpar
        private void BTNLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }
        #endregion

        #region Função Limpar
        private void Limpar()
        {
            Cursor.Current = Cursors.AppStarting;
            lblId.Text = "";
            TXTNome.Text = "";
            TXTEmail.Text = "";
            TXTEndereco.Text = "";
            TXTPesquisa.Text = "";
            TXTTelefone.Text = "";
            TXTDtime.Text = "";
        }
        #endregion

        #region BTNGravar
        private void BTNGravar_Click(object sender, EventArgs e)
        {

            Cursor.Current = Cursors.AppStarting;

            if (validar())
            {

                SqlConnection conexao = new SqlConnection(Config.clsDados.StringDeConexao);
                SqlCommand cmd = new SqlCommand();
                SqlTransaction ts;
                bool gravou = false;
                cmd.Connection = conexao;
                conexao.Open();
                ts = conexao.BeginTransaction();

                try
                {
                    if (lblId.Text == "")
                    {
                        cmd.CommandText = "insert into Usuario (nome, email, telefone, endereco, dtime) values (@nome, @email, @telefone, @endereco, @dtime)";
                    }
                    else
                    {
                        cmd.CommandText = "update Usuario set nome = @nome, email = @email, telefone = @telefone, endereco = @endereco, dtime = @dtime  where idUsuario = @idUsuario";
                        cmd.Parameters.Add("@idUsuario", SqlDbType.Int).Value = Convert.ToInt32(lblId.Text);
                    }
                    cmd.Parameters.Add("@nome", SqlDbType.VarChar).Value = Convert.ToString(TXTNome.Text);
                    cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = Convert.ToString(TXTEmail.Text);
                    cmd.Parameters.Add("@telefone", SqlDbType.VarChar).Value = Convert.ToString(TXTTelefone.Text);
                    cmd.Parameters.Add("@endereco", SqlDbType.VarChar).Value = Convert.ToString(TXTEndereco.Text);
                    cmd.Parameters.Add("@dtime", SqlDbType.VarChar).Value = Convert.ToString(TXTDtime.Text);
                    
                    cmd.Transaction = ts;
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                    gravou = true;

                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Erro: " + ex);
                }

                finally
                {
                    if (ts != null)
                    {
                        if (gravou)
                        {
                            ts.Commit();
                            Limpar();
                            Pesquisa(TXTPesquisa.Text);
                        }
                        else
                            ts.Rollback();
                    }

                    if (conexao.State == ConnectionState.Open)
                        conexao.Close();
                    conexao.Dispose();
                }
            }
        }
        #endregion

        #region Função Validar

        private bool validar()
        {
            if (TXTNome.Text == "")
            {
                MessageBox.Show("Campo Nome deve ser prenchido!");
                TXTNome.Focus();
                return false;
            }
            else if (TXTEmail.Text == "")
            {
                MessageBox.Show("Campo Email deve ser prenchido!");
                TXTEmail.Focus();
                return false;
            }
            else if (TXTTelefone.Text == "")
            {
                MessageBox.Show("Campo Telefone deve ser prenchido!");
                TXTTelefone.Focus();
                return false;
            }
            else if (TXTDtime.Text == "")
            {
                MessageBox.Show("Campo Time deve ser prenchido!");
                TXTDtime.Focus();
                return false;
            }
            else if (TXTEndereco.Text == "")
            {
                MessageBox.Show("Campo Endereço deve ser prenchido!");
                TXTEndereco.Focus();
                return false;
            }
            return true;
        }
        #endregion

        #region BTNExcluir

        private void BTNExcluir_Click(object sender, EventArgs e)
        {
            SqlConnection conexao = new SqlConnection(Config.clsDados.StringDeConexao);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao;
            conexao.Open();

            try
            {
                if (lblId.Text != "")
                {
              
                    cmd.CommandText = "delete from Usuario where idUsuario = @idUsuario";
                    cmd.Parameters.Add("@idUsuario", SqlDbType.Int).Value = Convert.ToInt32(lblId.Text);
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                }
                else
                {
                    MessageBox.Show("Selecione um usuário!");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro: " + ex);
            }
            finally
            {
                if (conexao.State == ConnectionState.Open)
                    conexao.Close();
                conexao.Dispose();
                Limpar();
                Pesquisa("");
            }
        }
        #endregion

        #region BTNPesquisa
        private void BTNPesquisa_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.AppStarting;
            Pesquisa(TXTPesquisa.Text);
        }
        #endregion 

        #region Função Pesquisa

        private void Pesquisa(string nome)
        {
            Cursor.Current = Cursors.AppStarting;
            Limpar();
            SqlConnection conexao = new SqlConnection(Config.clsDados.StringDeConexao);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao;

            DataTable tb = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            conexao.Open();

            try
            {
                if (nome == "")
                {
                    cmd.CommandText = "select * from Usuario";
                }
                else
                {
                    cmd.CommandText = "select * from Usuario where Nome like '%" + nome.ToString() + "%'";
                }

                da.Fill(tb);
                cmd.Parameters.Clear();

                DGPesquisa_usuario.DataSource = tb;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro: " + ex);
            }
            finally
            {
                if (conexao.State == ConnectionState.Open)
                    conexao.Close();
                conexao.Dispose();
            }
        }

        #endregion

        private void DGPesquisa_usuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lblId.Text = DGPesquisa_usuario[0, DGPesquisa_usuario.CurrentRow.Index].Value.ToString();
            TXTNome.Text = DGPesquisa_usuario[1, DGPesquisa_usuario.CurrentRow.Index].Value.ToString();
            TXTEmail.Text = DGPesquisa_usuario[2, DGPesquisa_usuario.CurrentRow.Index].Value.ToString();
            TXTTelefone.Text = DGPesquisa_usuario[3, DGPesquisa_usuario.CurrentRow.Index].Value.ToString();
            TXTDtime.Text = DGPesquisa_usuario[5, DGPesquisa_usuario.CurrentRow.Index].Value.ToString();
            TXTEndereco.Text = DGPesquisa_usuario[4, DGPesquisa_usuario.CurrentRow.Index].Value.ToString();

           
        }
    }
}

