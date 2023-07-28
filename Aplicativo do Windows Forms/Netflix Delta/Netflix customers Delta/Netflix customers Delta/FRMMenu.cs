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

namespace Netflix_customers_Delta
{
    public partial class FRMMenu : Form
    {
        public FRMMenu()
        {
            InitializeComponent();
        }

        private void BTNCadastro_de_Clientes_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.AppStarting;
            Cadastro.FRMCadastro_de_Clientes frm = new Cadastro.FRMCadastro_de_Clientes();
            frm.ShowDialog();
        }

        private void FRMMenu_Load(object sender, EventArgs e)
        {
            Pesquisa(TXTPesquisa.Text);
        }



        private void Pesquisa(string nome)
        {
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

        private void BTNPesquisa_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.AppStarting;
            Pesquisa(TXTPesquisa.Text);
        }

        private void BTNMais_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.AppStarting;
            string mesagem = "Você deseja mesmo aumentar um dia para todos os usuários!";
            string titulo = "Atenção";



            MessageBoxButtons botao = MessageBoxButtons.YesNo;

            DialogResult resultado = MessageBox.Show(mesagem, titulo, botao);

            if (resultado == DialogResult.Yes)
            {
                Cursor.Current = Cursors.AppStarting;

                SqlConnection conexao = new SqlConnection(Config.clsDados.StringDeConexao);
                SqlCommand cmd = new SqlCommand();
                SqlDataReader reader;
                cmd.Connection = conexao;

                conexao.Open();

                cmd.CommandText = "UPDATE Usuario SET dtime = (dtime) + 1 WHERE dtime = dtime";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conexao;

                reader = cmd.ExecuteReader();           
                conexao.Close();
                Pesquisa(TXTPesquisa.Text);
            }
            else
            {

            }
        }

        private void BTNMenos_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.AppStarting;
            string mesagem = "Você deseja mesmo diminuir um dia para todos os usuários!";
            string titulo = "Atenção";



            MessageBoxButtons botao = MessageBoxButtons.YesNo;

            DialogResult resultado = MessageBox.Show(mesagem, titulo, botao);

            if (resultado == DialogResult.Yes)
            {
                Cursor.Current = Cursors.AppStarting;

                SqlConnection conexao = new SqlConnection(Config.clsDados.StringDeConexao);
                SqlCommand cmd = new SqlCommand();
                SqlDataReader reader;
                cmd.Connection = conexao;

                conexao.Open();

                cmd.CommandText = "UPDATE Usuario SET dtime = (dtime) - 1 WHERE dtime = dtime";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conexao;

                reader = cmd.ExecuteReader();
                conexao.Close();
                Pesquisa(TXTPesquisa.Text);
            }
            else
            {

            }
        }

        private void DGPesquisa_usuario_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {


        }

        private void DGPesquisa_usuario_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
                e.Row.DefaultCellStyle.SelectionBackColor = Color.Black;
 
        }
    }
}
