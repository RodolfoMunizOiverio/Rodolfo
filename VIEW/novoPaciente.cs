using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GE_FISIO.VIEW
{
    public partial class novoPaciente : Form
    {
        int codigo = 0;
        public novoPaciente()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TxtPaciente_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            txtDataNascimento.Text = selecionaDataNasc.Text;
        }



        private void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label10_Click(object sender, EventArgs e)
        {

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

        private void NovoPaciente_Load(object sender, EventArgs e)
        {
            if (btnEditar.Visible == true)
            {
                botaoSalvar.Visible = false;
                desativarbotoes();
            }
            
        }



        private void BotaoSalvar_Click(object sender, EventArgs e)
        {
            string sexo = "";
            if (btnEditar.Visible == true)
            {
                SqlConnection conexao1 = new SqlConnection(@"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=FISIO;Data Source=DESKTOP-1CA9LG5\SQLEXPRESS");
                SqlCommand alterarPaciente = new SqlCommand("SET   DATEFORMAT DMY UPDATE  PACIENTES SET nomePaciente = @tNome, cpf = @tCpf , Sexo = @tSexo, Telefone = @tTelefone, email = @tEmail , Endereço = @tEndereço , dataNascimento = @tDataNascimento , bairro = @tBairro, cep =  @tCep, Cidade = @tCep, Convênio = @tConvenio, numeroConvênio = @tNumeroConvenio WHERE idPaciente = @codigo", conexao1);


                if (bMasculino.Checked)
                {
                    sexo = "M";
                }

                if (bFeminino.Checked)
                {
                    sexo = "F";
                }

                alterarPaciente.Parameters.Add("@codigo", SqlDbType.Int).Value = lblcodigo.Text;
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
                if (txtPaciente.Text != "" & txtCpf.Text != "" & txtNumeroConvenio.Text != "" & txtConvenio.Text != "")
                {

                    try
                    {
                        conexao1.Open();
                        alterarPaciente.ExecuteNonQuery();
                        MessageBox.Show("PacDados Alterados com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                insertPaciente.Parameters.Add("@tSexo", SqlDbType.Char).Value = sexo;
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
                    }
                }

            }

        }


        private void BtnEditar_Click(object sender, EventArgs e)
        {
            botaoSalvar.Visible = true;
            ativarbotoes();
        }
    }
}
