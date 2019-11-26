using GE_FISIO.VIEW;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GE_FISIO
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            picAberto.Visible = false;
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click_1(object sender, EventArgs e)
        {

        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click_2(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection conexao = new SqlConnection(@"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=FISIO;Data Source=DESKTOP-1CA9LG5\SQLEXPRESS");

            try
          {
                SqlCommand cmd = new SqlCommand("SELECT COUNT(idFuncionario) FROM FUNCIONARIO WHERE  loginFuncionario = @usuario   AND senhaFuncionario = @senha", conexao);

                cmd.Parameters.Add("@usuario", SqlDbType.VarChar).Value = tLogin.Text;
                cmd.Parameters.Add("@senha", SqlDbType.VarChar).Value = tSenha.Text;
                conexao.Open();
                int v = (int)cmd.ExecuteScalar();

                if (v > 0)
                {
                    Menu1 entrar = new Menu1();
                    this.Hide();
                    entrar.Show();
                }
                else
                {
                    MessageBox.Show("Você não está cadastrado ou teve algum erro de inserção", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            catch
            {
                MessageBox.Show("Erro com banco de dados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        } 
        
            
        

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void PictureBox2_Click_1(object sender, EventArgs e)
        {
            picFechado.Visible = true;
            picAberto.Visible = false;
            tSenha.PasswordChar = '*';
        }

        private void PicFechado_Click(object sender, EventArgs e)
        {
            picAberto.Visible = true;
            picFechado.Visible = false;
            tSenha.PasswordChar = '\0';
        }
    }
}
