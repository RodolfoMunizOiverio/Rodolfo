using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GE_FISIO.VIEW
{
    public partial class pacientes : UserControl
    {
        public pacientes()
        {
            InitializeComponent();
        }


        public void excluirPaciente(object sender, EventArgs e, string codigo)
        {
            SqlConnection conexao = new SqlConnection(@"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=FISIO;Data Source=DESKTOP-1CA9LG5\SQLEXPRESS");
            SqlCommand excluirPaciente = new SqlCommand(" DELETE  PACIENTES WHERE idPaciente = @codigo", conexao);
            excluirPaciente.Parameters.Add("@codigo", SqlDbType.Int).Value = codigo;

            try
            {
                conexao.Open();
                excluirPaciente.ExecuteNonQuery();
                MessageBox.Show("Excluido com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch
            {
                MessageBox.Show("Ocorreu algum erro durante a exclusão.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                conexao.Close();
                this.Hide();
                Menu1 menu = Application.OpenForms["Menu1"] as Menu1;
                menu.Menu1_Load(sender, e);
            }

            

        }

        public void ativarbotoes()
        {
            txtBairro.Enabled = true;
            txtCep.Enabled = true;
            txtCidade.Enabled = true;
            txtConvenio.Enabled = true;
            txtCpf.Enabled = true;
            txtDataNascimento.Enabled = true;
            txtEmail.Enabled = true;
            txtEndereco.Enabled = true;
            txtNumeroConvenio.Enabled = true;
            txtPaciente.Enabled = true;
            txtTelefone.Enabled = true;
        }

        public void desativarbotoes()
        {
            txtBairro.Enabled = false;
            txtCep.Enabled = false;
            txtCidade.Enabled = false;
            txtConvenio.Enabled = false;
            txtCpf.Enabled = false;
            txtDataNascimento.Enabled = false;
            txtEmail.Enabled = false;
            txtEndereco.Enabled = false;
            txtNumeroConvenio.Enabled = false;
            txtPaciente.Enabled = false;
            txtTelefone.Enabled = false;
        }


        private void Pacientes_Load(object sender, EventArgs e)
        {
            btnExcluirPaciente.Visible = false;
            botaoSalvar.Visible = true;
            if (sinal.Text == "a")
            {
                btnEditar.Visible = false;
                botaoSalvar.Visible = true;
            }
            else
            {
                botaoSalvar.Visible = false;
                btnEditar.Visible = true;
                btnExcluirPaciente.Visible = true;
                desativarbotoes();
            }
        }

        private void BotaoSalvar_Click(object sender, EventArgs e)
        {
            string sexo = "";
            if (btnEditar.Visible == true)
            {
                SqlConnection conexao1 = new SqlConnection(@"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=FISIO;Data Source=DESKTOP-1CA9LG5\SQLEXPRESS");
                SqlCommand alterarPaciente = new SqlCommand("SET   DATEFORMAT DMY UPDATE  PACIENTES SET nomePaciente = @tNome, cpf = @tCpf , Sexo = @tSexo, Telefone = @tTelefone, email = @tEmail , Endereço = @tEndereço , dataNascimento = @tDataNascimento , bairro = @tBairro, cep =  @tCep, Cidade = @tCidade, Convênio = @tConvenio, numeroConvênio = @tNumeroConvenio WHERE idPaciente = @codigo", conexao1);


                if (bMasculino.Checked)
                {
                    sexo = "M";
                }

                if (bFeminino.Checked)
                {
                    sexo = "F";
                }

                alterarPaciente.Parameters.Add("@codigo", SqlDbType.Int).Value = lblCodigo.Text;
                alterarPaciente.Parameters.Add("@tNome", SqlDbType.Char).Value = txtPaciente.Text;
                alterarPaciente.Parameters.Add("@tCpf", SqlDbType.VarChar).Value = txtCpf.Text;
                alterarPaciente.Parameters.Add("@tSexo", SqlDbType.Char).Value = sexo;
                alterarPaciente.Parameters.Add("@tTelefone", SqlDbType.VarChar).Value = txtTelefone.Text;
                alterarPaciente.Parameters.Add("@tEmail", SqlDbType.VarChar).Value = txtEmail.Text;
                alterarPaciente.Parameters.Add("@tEndereço", SqlDbType.VarChar).Value = txtEndereco.Text;
                alterarPaciente.Parameters.Add("@tDataNascimento", SqlDbType.Date).Value = txtDataNascimento.Text;
                alterarPaciente.Parameters.Add("@tBairro", SqlDbType.VarChar).Value = txtBairro.Text;
                alterarPaciente.Parameters.Add("@tCep", SqlDbType.VarChar).Value = txtCep.Text;
                alterarPaciente.Parameters.Add("@tCidade", SqlDbType.Char).Value = txtCidade.Text;
                alterarPaciente.Parameters.Add("@tConvenio", SqlDbType.VarChar).Value = txtConvenio.Text;
                alterarPaciente.Parameters.Add("@tNumeroConvenio", SqlDbType.Char).Value = txtNumeroConvenio.Text;
                if (txtPaciente.Text == "")
                    MessageBox.Show("É necessário preencher o nome do paciente.", "Ops", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                if (txtCpf.Text == "")
                    MessageBox.Show("É necessário preencher o numero de CPF.", "Ops", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                if (txtNumeroConvenio.Text == "")
                    MessageBox.Show("É necessário preencher o número de cadastro do convênio..", "Ops", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                if (txtConvenio.Text == "")
                    MessageBox.Show("É necessário preencher o o convênio.", "Ops", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                if (txtPaciente.Text != "" & txtCpf.Text != "" & txtNumeroConvenio.Text != "" & txtConvenio.Text != "" & txtDataNascimento.Text != "")
                {

                    try
                    {
                        conexao1.Open();
                        alterarPaciente.ExecuteNonQuery();
                        MessageBox.Show("Dados Alterados com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        desativarbotoes();
                    }
                    catch
                    {
                        MessageBox.Show("Ocorreu algum erro...", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    finally
                    {
                        conexao1.Close();
                    }

                }
            }

            else
            {
                SqlConnection conexao = new SqlConnection(@"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=FISIO;Data Source=DESKTOP-1CA9LG5\SQLEXPRESS");


                SqlCommand insertPaciente = new SqlCommand("SET DATEFORMAT DMY INSERT INTO PACIENTES(nomePaciente, cpf, Sexo, Telefone, email, Endereço, dataNascimento, bairro, cep, Cidade, Convênio, numeroConvênio)" +
                     " VALUES (@tNome, @tCpf, @tSexo, @tTelefone, @tEmail, @tEndereço, @tDataNascimento, @tBairro, @tCep, @tCidade, @tConvenio, @tNumeroConvenio)", conexao);
                if (bMasculino.Checked)
                {
                    sexo = "M";
                }

                if (bFeminino.Checked)
                {
                    sexo = "F";
                }

                insertPaciente.Parameters.Add("@tNome", SqlDbType.Char).Value = txtPaciente.Text;
                insertPaciente.Parameters.Add("@tCpf", SqlDbType.VarChar).Value = txtCpf.Text;
                insertPaciente.Parameters.Add("@tSexo", SqlDbType.VarChar).Value = sexo;
                insertPaciente.Parameters.Add("@tTelefone", SqlDbType.VarChar).Value = txtTelefone.Text;
                insertPaciente.Parameters.Add("@tEmail", SqlDbType.VarChar).Value = txtEmail.Text;
                insertPaciente.Parameters.Add("@tEndereço", SqlDbType.VarChar).Value = txtEndereco.Text;
                insertPaciente.Parameters.Add("@tDataNascimento", SqlDbType.Date).Value = txtDataNascimento.Text;
                insertPaciente.Parameters.Add("@tBairro", SqlDbType.VarChar).Value = txtBairro.Text;
                insertPaciente.Parameters.Add("@tCep", SqlDbType.VarChar).Value = txtCep.Text;
                insertPaciente.Parameters.Add("@tCidade", SqlDbType.Char).Value = txtCidade.Text;
                insertPaciente.Parameters.Add("@tConvenio", SqlDbType.VarChar).Value = txtConvenio.Text;
                insertPaciente.Parameters.Add("@tNumeroConvenio", SqlDbType.Char).Value = txtNumeroConvenio.Text;
                if (txtPaciente.Text == "")
                    MessageBox.Show("É necessário preencher o nome do paciente.", "Ops", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                if (txtCpf.Text == "")
                    MessageBox.Show("É necessário preencher o numero de CPF.", "Ops", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                if (txtNumeroConvenio.Text == "")
                    MessageBox.Show("É necessário preencher o número de cadastro do convênio..", "Ops", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                if (txtConvenio.Text == "")
                    MessageBox.Show("É necessário preencher o o convênio.", "Ops", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                if (txtPaciente.Text != "" & txtCpf.Text != "" & txtNumeroConvenio.Text != "" & txtConvenio.Text != "")
                {

                    try
                    {
                        conexao.Open();
                        insertPaciente.ExecuteNonQuery();
                        MessageBox.Show("Paciente Cadastrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    catch
                    {
                        MessageBox.Show("Por favor, Preencha todos os Campos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    finally
                    {
                        conexao.Close();
                         Menu1 menu = Application.OpenForms["Menu1"] as Menu1;
                        menu.Menu1_Load(sender, e);
                     }

                }

                

            }

        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            botaoSalvar.Visible = true;
            ativarbotoes();
        }

        private void LblCodigo_Click(object sender, EventArgs e)
        {

        }

        private void BtnExcluirPaciente_Click(object sender, EventArgs e)
        {
            var resposta = MessageBox.Show("Tem certeza que deseja excluir permanentemente esse paciente?", "Aviso",  MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (resposta == DialogResult.Yes)
            {
                excluirPaciente(sender, e, lblCodigo.Text);
            }

        }

        private void LblExcluir_Click(object sender, EventArgs e)
        {

        }

        private void SelecionaDataNasc_ValueChanged(object sender, EventArgs e)
        {
            txtDataNascimento.Text = selecionaDataNasc.Text;
        }

        private void Label10_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }
    }


}

