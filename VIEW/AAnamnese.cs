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
    
    public partial class AAnamnese : UserControl
    {
        public int Codigo { get; set; }

        public AAnamnese()
        {

            InitializeComponent();
        }

        private void digitarPaciente(object sender, KeyEventArgs e)
        {
            listaPaciente.Visible = true;
            SqlConnection conexao = new SqlConnection(@"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=FISIO;Data Source=DESKTOP-1CA9LG5\SQLEXPRESS");
            SqlCommand pesquisaPaciente = new SqlCommand();
            if (txtPaciente.Text == "")
            {
                pesquisaPaciente.CommandText = "pesq_Paciente ''";
                pesquisaPaciente.Connection = conexao;

            }
            else
            {
                pesquisaPaciente.CommandText = "pesq_Paciente @nome";
                pesquisaPaciente.Connection = conexao;
                pesquisaPaciente.Parameters.Add("@nome", SqlDbType.VarChar).Value = txtPaciente.Text;
            }


            conexao.Open();



            SqlDataReader lerPAciente = pesquisaPaciente.ExecuteReader();

            if (lerPAciente != null)
            {
                listaPaciente.Items.Clear();
                while (lerPAciente.Read())
                {
                    ListViewItem lv = new ListViewItem(lerPAciente.GetInt32(0).ToString());
                    lv.SubItems.Add(lerPAciente.GetString(1));
                    listaPaciente.Items.Add(lv);


                }
            }
        }

        private void AAnamnese_Load(object sender, EventArgs e)
        {
            if (Anamnesesinal.Text == "criar")
            {
                btnEditar.Visible = false;
                btnExcluir.Visible = false;
            }
            listaPaciente.Visible = false;
        }

        private void duploclique(object sender, EventArgs e)
        {
            string nome;
            ListView pegar = new ListView();
            nome = listaPaciente.SelectedItems[0].SubItems[1].Text;
            txtPaciente.Text = nome;
            listaPaciente.Visible = false;
            Codigo = Convert.ToInt32(listaPaciente.SelectedItems[0].Text);
        }

        private void MouseSaidoPaciente(object sender, EventArgs e)
        {
            listaPaciente.Visible = false;
        }

        private void mudardData(object sender, EventArgs e)
        {
            txtDataAvaliacao.Text = selecionaData.Text;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection conexao = new SqlConnection(@"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=FISIO;Data Source=DESKTOP-1CA9LG5\SQLEXPRESS");
            SqlCommand novaAnamnese = new SqlCommand("SET   DATEFORMAT DMY INSERT INTO ANAMNESE(idPaciente, dataAvaliacao, queixa, diagnostico, medico, hmp, numeroSessoes, diagnosticoFisio) VALUES (@id, @data, @queixa, @diagnostico, @medico, @hmp, @numeroSessoes, @diagnosticoFisio)", conexao);
            novaAnamnese.Parameters.Add("@id", SqlDbType.Int).Value = Codigo;
            novaAnamnese.Parameters.Add("@data", SqlDbType.Date).Value = txtDataAvaliacao.Text; 
            novaAnamnese.Parameters.Add("@queixa", SqlDbType.Char).Value = txtQueixa.Text;
            novaAnamnese.Parameters.Add("@diagnostico", SqlDbType.VarChar).Value = txtDiagnostico.Text;
            novaAnamnese.Parameters.Add("@medico", SqlDbType.VarChar).Value = txtMedico.Text;
            novaAnamnese.Parameters.Add("@hmp", SqlDbType.VarChar).Value = txtHMA.Text;
            novaAnamnese.Parameters.Add("@numeroSessoes", SqlDbType.Int).Value = txtNumeroSessoes.Text;
            novaAnamnese.Parameters.Add("@diagnosticoFisio", SqlDbType.VarChar).Value = txtDiagnosticoFisio.Text;
             
            if (txtDataAvaliacao.Text == "" & txtQueixa.Text == "" & txtDiagnostico.Text == ""  & txtMedico.Text == "" & txtHMA.Text == "" & txtNumeroSessoes.Text == "" & txtDiagnosticoFisio.Text == "")
                MessageBox.Show("É necessário preencher todos os itens da Ficha", "Caro usuário", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                try
                {
                    conexao.Open();
                    novaAnamnese.ExecuteNonQuery();

                }

                catch
                {
                    MessageBox.Show("Ocorreu algum erro durante a inserção da Ficha de Anamnese.", "Sinto Muito", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                finally
                {

                }
            }
        }

        private void digitouAlgo(object sender, KeyEventArgs e)
        {
            int a;
            if (int.TryParse(txtNumeroSessoes.Text.Trim(), out a))
            {

            }
            else
            {
                MessageBox.Show("Apenas Numeros", "Ops", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
    }
}
