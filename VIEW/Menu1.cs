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

namespace GE_FISIO.VIEW
{

    public partial class Menu1 : Form
    {
        int dia1 = 0, dia2 = 1, dia3 = 2, dia4 = 3, dia5 = 4;



        public Menu1()
        {
            InitializeComponent();
        }

        public void limparPainel()
        {
            painel2.Controls.Clear();
        }



        public void mostra_botoes()
        {
            lblSelecionaData.Visible = true;
            txtConsultaData.Visible = true;
            selecionaConsulta.Visible = true;
            bFechar.Visible = true;
            bIr.Visible = true;
            consultaDia.Visible = true;
            btnAgendar.Visible = true;
        }

        public void esconder_botoes()
        {
            lblSelecionaData.Visible = false;
            txtConsultaData.Visible = false;
            selecionaConsulta.Visible = false;
            bFechar.Visible = false;
            bIr.Visible = false;
            consultaDia.Visible = false;
            btnAgendar.Visible = false;
        }

        public void desativa_botoes()
        {
            btnNovoPaciente.Visible = false;
            btnNovaEvolucao.Visible = false;
            btnNovaAnamnese.Visible = false;
            exibirPaciente.Visible = false;
            exibirPaciente.Visible = false;
            
            if (txtPesqPaciente.Text == "")
            {
                lblPesquisarPaciente.Visible = true;
            }
        }

       

        public void fecha_telas()
        {
            if (Application.OpenForms["anamnese"] != null)
                Application.OpenForms["anamnese"].Close();

            if (Application.OpenForms["novoPaciente"] != null)
                Application.OpenForms["novoPaciente"].Close();

            if (Application.OpenForms["financas"] != null)
                Application.OpenForms["financas"].Close();

            if (Application.OpenForms["novaReceita"] != null)
                Application.OpenForms["novaReceita"].Close();

            if (Application.OpenForms["novaDespesa"] != null)
                Application.OpenForms["novaDespesa"].Close();

            if (Application.OpenForms["novaempresa"] != null)
                Application.OpenForms["novaempresa"].Close();

          //  if (Application.OpenForms["Menu1"] != null)
         //       Application.OpenForms["Menu1"].Close();


            

            painel2.Visible = false;





        }

        public void Menu1_Load(object sender, EventArgs e)
        {
            txtPesqPaciente.Text = "";
            txtConsultaData.Text = "";
            fecha_telas();
            desativa_botoes();
            exibirPaciente.Visible = false;
            esconder_botoes();
            panel1.Visible = false;
            bConsultar.Visible = true;
            SqlConnection conexao = new SqlConnection(@"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=FISIO;Data Source=DESKTOP-1CA9LG5\SQLEXPRESS");

            //COMANDOS PARA PREENCHIMENTO DOS DATAGRIDS
            SqlCommand listarDia1 = new SqlCommand(" SET DATEFORMAT DMY SELECT	CONVERT(VARCHAR(5), horarioAgendamento, 108)  AS 'Hora', P.nomePaciente AS 'Paciente'FROM AGENDAMENTO AS A INNER JOIN PACIENTES AS P ON A.idPaciente = P.idPaciente WHERE A.dataAgendamento = DATEADD(D, CONVERT(INT, @dia1), convert(char, GETDATE(), 103)) ORDER BY horarioAgendamento", conexao);
            SqlCommand listarDia2 = new SqlCommand(" SET DATEFORMAT DMY SELECT CONVERT(VARCHAR(5), horarioAgendamento, 108) AS 'Hora', P.nomePaciente AS 'Paciente'FROM AGENDAMENTO AS A INNER JOIN PACIENTES AS P ON A.idPaciente = P.idPaciente WHERE A.dataAgendamento = DATEADD(D, CONVERT(INT, @dia2), convert(char, GETDATE(), 103))  ORDER BY horarioAgendamento", conexao);
            SqlCommand listarDia3 = new SqlCommand(" SET DATEFORMAT DMY SELECT CONVERT(VARCHAR(5), horarioAgendamento, 108) AS 'Hora', P.nomePaciente AS 'Paciente'FROM AGENDAMENTO AS A INNER JOIN PACIENTES AS P ON A.idPaciente = P.idPaciente WHERE A.dataAgendamento = DATEADD(D, CONVERT(INT, @dia3), convert(char, GETDATE(), 103))  ORDER BY horarioAgendamento", conexao);
            SqlCommand listarDia4 = new SqlCommand(" SET DATEFORMAT DMY SELECT CONVERT(VARCHAR(5), horarioAgendamento, 108) AS 'Hora', P.nomePaciente AS 'Paciente'FROM AGENDAMENTO AS A INNER JOIN PACIENTES AS P ON A.idPaciente = P.idPaciente WHERE A.dataAgendamento = DATEADD(D, CONVERT(INT, @dia4), convert(char, GETDATE(), 103))  ORDER BY horarioAgendamento", conexao);
            SqlCommand listarDia5 = new SqlCommand(" SET DATEFORMAT DMY SELECT CONVERT(VARCHAR(5), horarioAgendamento, 108) AS 'Hora', P.nomePaciente AS 'Paciente'FROM AGENDAMENTO AS A INNER JOIN PACIENTES AS P ON A.idPaciente = P.idPaciente WHERE A.dataAgendamento = DATEADD(D, CONVERT(INT, @dia5), convert(char, GETDATE(), 103))  ORDER BY horarioAgendamento", conexao);
            listarDia1.Parameters.Add("@dia1", SqlDbType.Int).Value = dia1;
            listarDia2.Parameters.Add("@dia2", SqlDbType.VarChar).Value = dia2;
            listarDia3.Parameters.Add("@dia3", SqlDbType.VarChar).Value = dia3;
            listarDia4.Parameters.Add("@dia4", SqlDbType.VarChar).Value = dia4;
            listarDia5.Parameters.Add("@dia5", SqlDbType.VarChar).Value = dia5;


            //COMANDO PARA PREENCHIMENTO DOS DIAS DA SEMANA

            SqlCommand diaUm = new SqlCommand("SET LANGUAGE 'brazilian' SELECT DATENAME(weekday, DATEADD(DW, @dia1, convert(char, GETDATE(), 103))) as 'DIA DA SEMANA'", conexao);
            SqlCommand diaDois = new SqlCommand("SET LANGUAGE 'brazilian'  SELECT DATENAME(weekday, DATEADD(DW, @dia2, convert(char, GETDATE(), 103))) AS 'hhh'", conexao);
            SqlCommand diaTres = new SqlCommand("SET LANGUAGE 'brazilian'  SELECT DATENAME(weekday, DATEADD(DW, @dia3, convert(char, GETDATE(), 103))) AS 'hhh'", conexao);
            SqlCommand diaQuatro = new SqlCommand("SET LANGUAGE 'brazilian'  SELECT DATENAME(weekday, DATEADD(DW, @dia4, convert(char, GETDATE(), 103))) AS 'hhh'", conexao);
            SqlCommand diaCinco = new SqlCommand("SET LANGUAGE 'brazilian'  SELECT DATENAME(weekday, DATEADD(DW, @dia5, convert(char, GETDATE(), 103))) AS 'hhh'", conexao);
            diaUm.Parameters.Add("@dia1", SqlDbType.Int).Value = dia1;
            diaDois.Parameters.Add("@dia2", SqlDbType.Int).Value = dia2;
            diaTres.Parameters.Add("@dia3", SqlDbType.Int).Value = dia3;
            diaQuatro.Parameters.Add("@dia4", SqlDbType.Int).Value = dia4;
            diaCinco.Parameters.Add("@dia5", SqlDbType.Int).Value = dia5;

            //COMANDOS PARA PREENCHIMENTO DOS DIAS DO MES
            SqlCommand diaMes1 = new SqlCommand("SET DATEFORMAT DMY SELECT CONVERT(VARCHAR(10), DATEADD(DAY, @dia1, convert(char, GETDATE(), 103)) , 103)", conexao);
            SqlCommand diaMes2 = new SqlCommand("SET DATEFORMAT DMY SELECT CONVERT(VARCHAR(10), DATEADD(DAY, @dia2, convert(char, GETDATE(), 103)) , 103)", conexao);
            SqlCommand diaMes3 = new SqlCommand("SET DATEFORMAT DMY SELECT CONVERT(VARCHAR(10), DATEADD(DAY, @dia3, convert(char, GETDATE(), 103)) , 103)", conexao);
            SqlCommand diaMes4 = new SqlCommand("SET DATEFORMAT DMY SELECT CONVERT(VARCHAR(10), DATEADD(DAY, @dia4, convert(char, GETDATE(), 103)) , 103)", conexao);
            SqlCommand diaMes5 = new SqlCommand("SET DATEFORMAT DMY SELECT CONVERT(VARCHAR(10), DATEADD(DAY, @dia5, convert(char, GETDATE(), 103)) , 103)", conexao);
            diaMes1.Parameters.Add("@dia1", SqlDbType.Int).Value = dia1;
            diaMes2.Parameters.Add("@dia2", SqlDbType.Int).Value = dia2;
            diaMes3.Parameters.Add("@dia3", SqlDbType.Int).Value = dia3;
            diaMes4.Parameters.Add("@dia4", SqlDbType.Int).Value = dia4;
            diaMes5.Parameters.Add("@dia5", SqlDbType.Int).Value = dia5;


            //PREENCHENDO OS DATA GRIDS


            conexao.Open();
            SqlDataAdapter dadosdia1 = new SqlDataAdapter(listarDia1);
            DataTable dtListaDia1 = new DataTable();
            dadosdia1.Fill(dtListaDia1);
            dtDia1.DataSource = dtListaDia1;

            SqlDataAdapter dadosdia2 = new SqlDataAdapter(listarDia2);
            DataTable dtListaDia2 = new DataTable();
            dadosdia2.Fill(dtListaDia2);
            dtDia2.DataSource = dtListaDia2;


            SqlDataAdapter dadosdia3 = new SqlDataAdapter(listarDia3);
            DataTable dtListaDia3 = new DataTable();
            dadosdia3.Fill(dtListaDia3);
            dtDia3.DataSource = dtListaDia3;

            SqlDataAdapter dadosdia4 = new SqlDataAdapter(listarDia4);
            DataTable dtListaDia4 = new DataTable();
            dadosdia4.Fill(dtListaDia4);
            dtDia4.DataSource = dtListaDia4;

            SqlDataAdapter dadosdia5 = new SqlDataAdapter(listarDia5);
            DataTable dtListaDia5 = new DataTable();
            dadosdia5.Fill(dtListaDia5);
            dtDia5.DataSource = dtListaDia5;

            conexao.Close();

            // FIM DO PREENCHIMENTO DOS DATA GRIDS


            //PREENCHENDO OS DIAS DA SEMANA

            conexao.Open();

            SqlDataReader DiaUm = diaUm.ExecuteReader();
            DiaUm.Read();
            lbl2Dia1.Text = Convert.ToString(DiaUm.GetString(0));
            DiaUm.Close();

            SqlDataReader DiaDois = diaDois.ExecuteReader();
            DiaDois.Read();
            lbl2Dia2.Text = Convert.ToString(DiaDois.GetString(0));
            DiaDois.Close();

            SqlDataReader DiaTres = diaTres.ExecuteReader();
            DiaTres.Read();
            lbl2Dia3.Text = Convert.ToString(DiaTres.GetString(0));
            DiaTres.Close();

            SqlDataReader DiaQuatro = diaQuatro.ExecuteReader();
            DiaQuatro.Read();
            lbl2Dia4.Text = Convert.ToString(DiaQuatro.GetString(0));
            DiaQuatro.Close();

            SqlDataReader DiaCinco = diaCinco.ExecuteReader();
            DiaCinco.Read();
            lbl2Dia5.Text = Convert.ToString(DiaCinco.GetString(0));
            DiaCinco.Close();


            conexao.Close();



            //PREENCHENDO O DIA DO MES


            conexao.Open();

            SqlDataReader DiaMesUm = diaMes1.ExecuteReader();
            DiaMesUm.Read();
            string dataHoje = DateTime.Now.ToString("dd'/'MM'/'yyyy");
            if (dataHoje == Convert.ToString(DiaMesUm.GetString(0)))
                lblDia1.Text = "Hoje";
            else
                lblDia1.Text = Convert.ToString(DiaMesUm.GetString(0));
            DiaMesUm.Close();

            SqlDataReader DiaMesDois = diaMes2.ExecuteReader();
            DiaMesDois.Read();
            lblDia2.Text = Convert.ToString(DiaMesDois.GetString(0));
            DiaMesDois.Close();

            SqlDataReader DiaMesTres = diaMes3.ExecuteReader();
            DiaMesTres.Read();
            lblDia3.Text = Convert.ToString(DiaMesTres.GetString(0));
            DiaMesTres.Close();

            SqlDataReader DiaMesQuatro = diaMes4.ExecuteReader();
            DiaMesQuatro.Read();
            lblDia4.Text = Convert.ToString(DiaMesQuatro.GetString(0));
            DiaMesQuatro.Close();

            SqlDataReader DiaMesCinco = diaMes5.ExecuteReader();
            DiaMesCinco.Read();
            lblDia5.Text = Convert.ToString(DiaMesCinco.GetString(0));
            DiaMesCinco.Close();


            conexao.Close();

        }

        //CLIQUE DE BOTOES ----------------------------------------------------------------

        private void BtnPacientes_Click(object sender, EventArgs e)
        {
            btnNovaAnamnese.Visible = true;
            btnNovaEvolucao.Visible = true;
            btnNovoPaciente.Visible = true;
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            FormLogin sair = new FormLogin();
            this.Hide();
            sair.Show();
            fecha_telas();
        }

        private void BtnNovaEvolucao_Click(object sender, EventArgs e)
        {
            fecha_telas();
            pacientes novo = new pacientes();
            painel2.Visible = true;
            painel2.Controls.Add(novo);
            desativa_botoes();
        }

        private void BtnNovaAnamnese_Click(object sender, EventArgs e)
        {
            limparPainel();
            fecha_telas();
            AAnamnese novo = new AAnamnese();
            novo.Anamnesesinal.Text = "criar";
            painel2.Visible = true;
            painel2.Controls.Add(novo);
            desativa_botoes();
        }

        private void BtnFinancas_Click(object sender, EventArgs e)
        {
            fecha_telas();
            financas nova = new financas();
            nova.Show();
        }

        private void BtnEmpresa_Click(object sender, EventArgs e)
        {
            fecha_telas();
            novaempresa nova = new novaempresa();
            nova.Show();
        }

        private void BtnNovoPaciente_Click(object sender, EventArgs e)
        {
            fecha_telas();
            limparPainel();
            pacientes novo = new pacientes();
            novo.sinal.Text = "a";
            painel2.Visible = true;
            painel2.Controls.Add(novo);
            novo.Show();
            desativa_botoes();

        }

        private void BtnPróximaSemana_Click(object sender, EventArgs e)
        {
            dia1 += 5;
            dia2 += 5;
            dia3 += 5;
            dia4 += 5;
            dia5 += 5;
            Menu1_Load(sender,e);
            dtDia1.Refresh();
        }

        private void BtnSemanaAnterior_Click(object sender, EventArgs e)
        {
            dia1 -= 5;
            dia2 -= 5;
            dia3 -= 5;
            dia4 -= 5;
            dia5 -= 5;
            Menu1_Load(sender, e);
            
            dtDia1.Refresh();
        }

        //EVENTOS --------------------------------------------------------------

        private void LblPesquisarPaciente_Click(object sender, EventArgs e)
        {

            lblPesquisarPaciente.Visible = false;
        }

        private void txtPesquisarPaciente_Click(object sender, EventArgs e)
        {
            lblPesquisarPaciente.Visible = false;

        }

        private void hover_FundoVerde(object sender, EventArgs e)
        {
            desativa_botoes();
        }

        private void hover_Pacientes(object sender, EventArgs e)
        {
            desativa_botoes();
        }

        private void hover_financas(object sender, EventArgs e)
        {
            desativa_botoes();
        }

        private void hover_relatorio(object sender, EventArgs e)
        {
            desativa_botoes();
        }

        public void abrir_agendamento(object sender)
        {

            esse();
        }

        public void esse()
        {
            panel1.Controls.Clear();
            agendamento novo = new agendamento();
            panel1.Controls.Add(novo);

        }

        public void a()
        {
            b();
        }

        private void b()
        {
            bConsultar.Visible = true;
        }

    

        private void BConsultar_Click(object sender, EventArgs e)
        {
            txtConsultaData.Text = "";
            consultaDia.Items.Clear();
            mostra_botoes();
            bConsultar.Visible = false;

        }


        

        private void BtnCancelarAgendamento_Click(object sender, EventArgs e)
        {
          
            //agendamento

        }

        private void cliquePacientes(object sender, KeyEventArgs e)
        {
            exibirPaciente.Visible = true;
            SqlConnection conexao = new SqlConnection(@"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=FISIO;Data Source=DESKTOP-1CA9LG5\SQLEXPRESS");
            SqlCommand pesquisaPaciente = new SqlCommand();
            if (txtPesqPaciente.Text == "" | txtPesqPaciente.Text == " " | txtPesqPaciente.Text == "  " | txtPesqPaciente.Text == "   " | txtPesqPaciente.Text == "    " | txtPesqPaciente.Text == "     ")

            {
                pesquisaPaciente.CommandText = "pesqui_Paciente '@nome1'";
                pesquisaPaciente.Parameters.Add("@nome1", SqlDbType.Char).Value = "";
                pesquisaPaciente.Connection = conexao;

            }
           
            else
            {
                pesquisaPaciente.CommandText = "pesquisaPaciente @nome";
                pesquisaPaciente.Parameters.Add("@nome", SqlDbType.VarChar).Value = txtPesqPaciente.Text;
                pesquisaPaciente.Connection = conexao;

            }


            conexao.Open();
        
            SqlDataReader lerPAciente = pesquisaPaciente.ExecuteReader();


            if (lerPAciente != null)
            {
                exibirPaciente.Items.Clear();
                while (lerPAciente.Read())
                {

                    ListViewItem lv = new ListViewItem(lerPAciente.GetInt32(0).ToString());
                    lv.SubItems.Add(lerPAciente.GetString(1).ToString());
                    if ( lerPAciente[2].ToString() == "")
                        lv.SubItems.Add("Sem agendamentos");
                    else
                        lv.SubItems.Add(lerPAciente.GetString(2));
                    exibirPaciente.Items.Add(lv);



                }

            }

        }

        private void duplocliquePaciente(object sender, EventArgs e)
        {
            limparPainel();
            txtPesqPaciente.Text = "";
            string codigo = exibirPaciente.SelectedItems[0].Text.ToString();

            pacientes novo = new pacientes();
            SqlConnection conexao = new SqlConnection(@"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=FISIO;Data Source=DESKTOP-1CA9LG5\SQLEXPRESS");
            SqlCommand preencherPaciente = new SqlCommand("SELECT	nomePaciente AS ' nome', cpf AS 'CPF', Sexo as 'Sexo', Telefone, email AS 'E-Mail', Convênio, numeroConvênio AS 'Numero do Convenio',dataNascimento AS 'Data de nascimento', Endereço, bairro AS 'Bairro', cep AS 'CEP', Cidade FROM PACIENTES WHERE idPaciente = @CODIGO", conexao);
            preencherPaciente.Parameters.Add("@CODIGO", SqlDbType.Int).Value = codigo; 
            string nome = "", cpf = "", sexo = "", telefone = "", email = "", convenio = "", numeroconvenio = "", data = "", endereco = "", bairro = "", cep = "", cidade = "";
            conexao.Open();
            SqlDataReader dados = preencherPaciente.ExecuteReader();
            while (dados.Read())
            {
                nome = Convert.ToString(dados[0].ToString());
                 cpf = dados[1].ToString();
                 sexo = dados[2].ToString();
                 telefone = dados[3].ToString();
                 email = dados[4].ToString();
                 convenio = dados[5].ToString();
                 numeroconvenio = dados[6].ToString();
                 data = dados[7].ToString();
                 endereco = dados[8].ToString();
                 bairro = dados[9].ToString();
                 cep = dados[10].ToString();
                 cidade = dados[11].ToString();

            }
            novo.txtPaciente.Text = nome;
            novo.txtCpf.Text = cpf;
            if (sexo == "M")
                {
                novo.bMasculino.Checked = true;
                }
            else
            {
                novo.bFeminino.Checked = true;
            }
            novo.txtTelefone.Text = telefone;
            novo.txtEmail.Text = email;
            novo.txtConvenio.Text = convenio;
            novo.txtNumeroConvenio.Text = numeroconvenio;
            novo.txtDataNascimento.Text = data;
            novo.txtEndereco.Text = endereco;
            novo.txtBairro.Text = bairro;
            novo.txtCep.Text = cep;
            novo.txtCidade.Text = cidade;
            novo.sinal.Visible = true;
            novo.lblCodigo.Text = codigo;
            painel2.Visible = true;
            painel2.Controls.Clear();
            novo.sinal.Text = "b";
            painel2.Controls.Add(novo);
            
            desativa_botoes();
            
        }

        private void BtnAgendar_Click(object sender, EventArgs e)
        {
            if  (txtConsultaData.Text == "  /  /")
            { 
                MessageBox.Show("É necessário escolher um dia para marcar o agendamento", "Ops", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            { 
               esconder_botoes();
               panel1.Visible = true;
               agendamento novo = new agendamento();
                novo.txtConsultaData.Text = txtConsultaData.Text;
                novo.sinal.Text = "criar";
                panel1.Controls.Add(novo);
                novo.Show();
            }

        }

        private void SelecionaConsulta_ValueChanged(object sender, EventArgs e)
        {
            txtConsultaData.Text = selecionaConsulta.Text;
        }

        private void BIr_Click(object sender, EventArgs e)
        {
            SqlConnection conexao = new SqlConnection(@"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=FISIO;Data Source=DESKTOP-1CA9LG5\SQLEXPRESS");
            SqlCommand consultardia = new SqlCommand("SET DATEFORMAT DMY SELECT CONVERT(VARCHAR(5), horarioAgendamento, 108)  AS 'hora', P.nomePaciente AS 'Paciente', A.dataAgendamento as 'data', P.idPaciente as 'id' FROM AGENDAMENTO AS A  INNER JOIN PACIENTES AS P ON A.idPaciente = P.idPaciente WHERE A.dataAgendamento = @data ORDER BY horarioAgendamento ", conexao);
            consultardia.Parameters.Add("@data", SqlDbType.Date).Value = txtConsultaData.Text;
            try   
            {
                conexao.Open(); 
                SqlDataReader consultar = consultardia.ExecuteReader();

                if (consultar != null)
                {
                    consultaDia.Items.Clear();
                    while (consultar.Read())
                    {
                        ListViewItem data = new ListViewItem(consultar.GetString(0).ToString());
                        data.SubItems.Add(consultar.GetString(1));
                        data.SubItems.Add(consultar.GetDateTime(2).ToString());
                        data.SubItems.Add(consultar.GetInt32(3).ToString());
                        consultaDia.Items.Add(data);
                    }
                }      
            }
            catch
            {
                MessageBox.Show("É necessário escolher um dia para a consulta.", "Ops", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            finally
            {
                conexao.Close();
            }

        }


        private void BFechar_Click(object sender, EventArgs e)
        {
            bConsultar.Visible = true;
            esconder_botoes();
        }

        private void ExibirPaciente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            
            Menu1_Load(sender, e);
        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LblGeFisio_Click(object sender, EventArgs e)
        {
            Menu1_Load(sender, e);
        }

        private void painel2_hover(object sender, EventArgs e)
        {
            desativa_botoes();
        }

        private void cliquepainel(object sender, MouseEventArgs e)
        {
            lblGeFisio.BackColor = Color.LimeGreen;;
        }

        private void desclique(object sender, MouseEventArgs e)
        {
          
               lblGeFisio.BackColor = Color.ForestGreen;
     
        }


        private void clique(object sender, EventArgs e)
        {

            
        }

        private void duplp_clique(object sender, EventArgs e)
        {
            esconder_botoes();
            string hora = "", hora1 = "", hora2 = "", hora3 = "", nome ="", codigo="";

            agendamento novo = new agendamento();
            novo.txtConsultaData.Text = txtConsultaData.Text;
            hora = consultaDia.SelectedItems[0].SubItems[0].Text;
            novo.txtConsultaData.Text = consultaDia.SelectedItems[0].SubItems[2].Text;
            nome = consultaDia.SelectedItems[0].SubItems[1].Text.ToString() ;
            novo.txtPaciente.Text = nome.Substring(0, 25);
            codigo = consultaDia.SelectedItems[0].SubItems[3].Text;
            hora1 = hora.Substring(0, 1);
            hora2 = hora.Substring(1, 1);
            hora3 = hora.Substring(3, 2);
            novo.txtHora.Text = hora1 + hora2;
            novo.txtMinutos.Text = hora3;
            novo.lblCodigo.Text = codigo;
            panel1.Visible = true;
            novo.sinal.Text = "editar";
            panel1.Controls.Add(novo);
            novo.Show();
        }

        private void SelecionaConsulta_CloseUp(object sender, EventArgs e)
        {
            txtConsultaData.Text = selecionaConsulta.Text;
        }

        private void hover_equipe(object sender, EventArgs e)
        {
            desativa_botoes();
        }

        private void hover_empresa(object sender, EventArgs e)
        {
            desativa_botoes();
        }

        private void hover_configuracoes(object sender, EventArgs e)
        {
            desativa_botoes();
        }

        private void hover_FundoTela(object sender, EventArgs e)
        {
            desativa_botoes();
        }

        
    }
}
