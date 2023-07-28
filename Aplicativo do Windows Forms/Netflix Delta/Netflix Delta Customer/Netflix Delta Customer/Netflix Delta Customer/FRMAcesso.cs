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

namespace Netflix_Delta_Customer
{
    public partial class FRMAcesso : Form
    {
        public FRMAcesso()
        {
            InitializeComponent();
        }

        private void FRMAcesso_Load(object sender, EventArgs e)
        {
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            Cursor.Current = Cursors.AppStarting;
            SqlConnection conexao = new SqlConnection(Config.clsDados.StringDeConexao);

            try
            {
                conexao.Open();
                label1.Text = "Conexão estabelecida com sucesso ao Servidor Delta";
                string _Sql = string.Empty;
                // ID USER
                string id = "1";
                /////////
                _Sql = "SELECT COUNT(idUsuario) FROM Usuario WHERE idUsuario = @idUsuario";
                SqlCommand cmd = new SqlCommand(_Sql, conexao);
                cmd.Parameters.Add("@idUsuario", SqlDbType.VarChar).Value = id;
                int Usuario_tem_permissao_de_acesso = (int)cmd.ExecuteScalar();

                if (Usuario_tem_permissao_de_acesso > 0)
                {
                    label1.Text = "Fazendo acesso do usuário";
                    cmd.Parameters.Clear();
                    // ID USER
                    cmd.CommandText = "SELECT dtime FROM Usuario WHERE idUsuario = 1";
                    //////////
                    Object v;
                    v = cmd.ExecuteScalar();
                    int v1 = Convert.ToInt32(v);  
                    if (v1 > 0)
                    {
                        label1.Text = "Pagamento do usuário está em dia";
                        label1.Text = "Abrindo Netflix";

                        Cursor.Current = Cursors.AppStarting;
                        this.Hide();
                        Netflix frmQuery = new Netflix();
                        frmQuery.ShowDialog();
                        this.Close();
                        this.Dispose();
                    }
                    else
                    {    
                        Cursor.Current = Cursors.AppStarting;
                        this.Hide();
                        FRMPagar frmQuery = new FRMPagar();
                        frmQuery.ShowDialog();
                        this.Close();
                        this.Dispose();
                    }
                }
                else
                {
                    MessageBox.Show("Netflix Delta Customer não cadastrado ou cancelado  !!!\nEntre em contato com a gente e estaremos mandando um técnico no seu estabelecimento para solucionar o seu caso.\nTelefone celular:\nOperadora VIVO: (17) 99680-0648\nOperadora CLARO: (17) 99204-2425\nE-mail: systemdelta@hotmail.com");
                    this.Dispose();
                }
            }

            catch (SqlException)
            {
                MessageBox.Show("Não há conexão com a Internet\nVocê pode tentar diagnosticar o problema realizando as seguintes etapas:\nVá para Iníciar > Painel de Controle > Rede e Internet > Central de Rede e Compartilhamento > Solucionar problemas(na parte inferior) > Conexões com a Internet.\nTente:\nVerificar o cabo de rede ou roteador\nRedefinir o modem ou roteador\nConectar - se à rede Wi - Fi novamente\nApós tiver acesso à internet entra no Netflix Delta Customer novamente.\nCaso tenha internet e não consiga acessar o Netflix Delta Customer entre em contato com a gente e estaremos mandando um técnico no seu estabelecimento.\nTelefone celular:\nOperadora VIVO: (17) 99680-0648\nOperadora CLARO: 17 99204-2425\nE-mail: systemdelta@hotmail.com");
                conexao.Close();
                conexao.Dispose();
                this.Dispose();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.AppStarting;
            FRMPagar frm = new FRMPagar();
            frm.ShowDialog();

        }
    }
}
