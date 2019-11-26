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
    public partial class agendamento : UserControl
    {
        int hora = 7, minuto = 0;
        string dataantiga = "", horaantiga = "";
        
        public agendamento()
        {
            InitializeComponent();
        }




        //AJUSTANDO O HORARIO COM FUNCOES



        private void BtnSetaCimaHora_Click(object sender, EventArgs e)
        {
            hora += 1;
            if (hora > 19)
            {
                hora = 19;
            }
            if (hora > 9)
            {
                txtHora.Text = Convert.ToString(hora);
            }
            else
            {
                txtHora.Text = "0" + Convert.ToString(hora);
            }


        }

        private void BtnSetaBaixoHora_Click(object sender, EventArgs e)
        {
            hora -= 1;
            if (hora < 7)
            {
                hora = 7;
            }

            if (hora > 9)
            {
                txtHora.Text = Convert.ToString(hora);
            }
            else
            {
                txtHora.Text = "0" + Convert.ToString(hora);
            }
        }

        private void BtnSetaCimaMinuto_Click(object sender, EventArgs e)
        {
            minuto += 15;
            if (minuto > 45)
            {
                minuto = 45;
            }
            if (minuto == 0)
            {
                txtMinutos.Text = "00";
            }
            else
            {
                txtMinutos.Text = Convert.ToString(minuto);
            }

        }

        private void BtnSetaBaixoMinutos_Click(object sender, EventArgs e)
        {
            minuto -= 15;

            if (minuto < 0)
            {
                minuto = 0;
            }
            if (minuto == 0)
            {
                txtMinutos.Text = "00";
            }
            else
            {
                txtMinutos.Text = Convert.ToString(minuto);
            }
        }

        private void BtnCancelarAgendamento_Click(object sender, EventArgs e)
        {
            hora = 7;
            Menu1 menu = Application.OpenForms["Menu1"] as Menu1;
            menu.mostra_botoes();
            this.Hide();
        }


        public void cancelaragendamento()
        {

        }



        private void Agendamento_Load_1(object sender, EventArgs e)
        {
            if (sinal.Text == "editar")
            {
                hora = Convert.ToInt32(txtHora.Text);
                minuto = Convert.ToInt32(txtMinutos.Text);
                dataantiga = txtConsultaData.Text;
                horaantiga = txtHora.Text + ":" + txtMinutos.Text;
                listaPaciente.Visible = false;
                btnCalcenlarAgendamento.Visible = true;
            }
            else
            {
                hora = 7;
                txtHora.Text = "0" + Convert.ToString(hora);
                listaPaciente.Visible = false;
                btnCalcenlarAgendamento.Visible = false;
            }
            
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

        private void duplo_clique_Paciente(object sender, EventArgs e)
        {
            string nome;
            ListView pegar = new ListView();
            string codigo = listaPaciente.SelectedItems[0].Text;
            nome = listaPaciente.SelectedItems[0].SubItems[1].Text;
            txtPaciente.Text = nome.Substring(0, 25) + "...";
            lblCodigo.Text = codigo;
            listaPaciente.Visible = false;
        }

        private void ListaPaciente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ListaPaciente_MouseLeave(object sender, EventArgs e)
        {
            listaPaciente.Visible = false;
        }

        public void cancelarAgendamento(object sender, EventArgs e)
        {
            string horas = "", minutos = "";
            if (hora < 10)
            {
                horas = "0" + Convert.ToString(hora);
            }
            else
            {
                horas = Convert.ToString(hora); ;
            }

            if (minuto == 0)
            {
                minutos = "00";
            }

            else
            {
                minutos = Convert.ToString(minuto);
            }

            string horario = horas + ":" + minutos;


            SqlConnection conexao = new SqlConnection(@"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=FISIO;Data Source=DESKTOP-1CA9LG5\SQLEXPRESS");
            SqlCommand alterarAgendamenti = new SqlCommand("SET DATEFORMAT DMY DELETE AGENDAMENTO where dataAgendamento = @data AND horarioAgendamento = @hora", conexao);
            alterarAgendamenti.Parameters.Add("@data", SqlDbType.Date).Value = txtConsultaData.Text;
            alterarAgendamenti.Parameters.Add("@hora", SqlDbType.Time).Value = horario;

            if (txtPaciente.Text == "" | txtConsultaData.Text == "")
            {
                MessageBox.Show("Não foi possível cancelar o agendamento", "Essa não", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {

                try
                {
                    conexao.Open();
                    alterarAgendamenti.ExecuteNonQuery();
                    MessageBox.Show("Cancelado com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


                }
                catch
                {
                    MessageBox.Show("Algo deu errado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                finally
                {
                    conexao.Close();
                    Menu1 menu = Application.OpenForms["Menu1"] as Menu1;
                    menu.Menu1_Load(sender, e);
                    this.Hide();
                }


            }
        }

        private void BtnCalcenlarAgendamento_Click(object sender, EventArgs e)
        {
            var resposta = MessageBox.Show("Tem certeza que deseja cancelar este agendamento?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (resposta == DialogResult.Yes)
            {
                cancelarAgendamento(sender, e);
            }
        }

        private void SelecionaConsulta_ValueChanged(object sender, EventArgs e)
        {
            txtConsultaData.Text = selecionaConsulta.Text;
        }

        private void BtnSalvarAgendamento_Click(object sender, EventArgs e)
        {
            if (sinal.Text == "criar")
            { 
            SqlConnection conexao = new SqlConnection(@"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=FISIO;Data Source=DESKTOP-1CA9LG5\SQLEXPRESS");
            string horas = "", minutos = "";
            if (hora < 10)
            {
               horas = "0" + Convert.ToString(hora);
            }
            else
            {
                horas = Convert.ToString(hora); ;
            }

            if (minuto == 0)
            {
                minutos = "00";
            }

            else
            {
                minutos = Convert.ToString(minuto);
            }

            string horario = horas + ":"  + minutos;

            
            SqlCommand novoAgendamento = new SqlCommand("SET DATEFORMAT DMY INSERT INTO AGENDAMENTO( idPaciente, dataAgendamento, horarioAgendamento) VALUES (@paciente, @data, @hora) ", conexao);
            novoAgendamento.Parameters.Add("@paciente", SqlDbType.Int).Value = lblCodigo.Text;
            novoAgendamento.Parameters.Add("@data", SqlDbType.Date).Value = txtConsultaData.Text;
            novoAgendamento.Parameters.Add("@hora", SqlDbType.Time).Value = horario;

            SqlCommand validar = new SqlCommand("SET DATEFORMAT DMY Select  COUNT(*) FROM AGENDAMENTO WHERE dataAgendamento = @data AND horarioAgendamento = @hora", conexao);
            validar.Parameters.Add("@data", SqlDbType.Date).Value = txtConsultaData.Text;
            validar.Parameters.Add("@hora", SqlDbType.Time).Value = horario;

            if (txtPaciente.Text == "" | txtConsultaData.Text == "")
            {
                MessageBox.Show("Não foi possível fazer o agendamento", "Essa não", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                conexao.Open();
                SqlDataReader DiaUm = validar.ExecuteReader();
                DiaUm.Read();
                int numero = 0;
                numero = Convert.ToInt32(DiaUm.GetInt32(0));
                DiaUm.Close();
                conexao.Close();
                if (numero > 0)
                {
                    MessageBox.Show("Esse horário ja está agendado", "Essa não", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else
                {
                    try
                   {
                        conexao.Open();
                        novoAgendamento.ExecuteNonQuery();
                        MessageBox.Show("Agendamento  Realizado com Sucesso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        Menu1 menu = Application.OpenForms["Menu1"] as Menu1;
                        menu.bConsultar.Visible = true;
                        menu.Menu1_Load(sender, e);
                        this.Hide();

                    }
                    catch
                    {
                        MessageBox.Show("Algo deu errado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    finally
                    {
                        conexao.Close();
                    }
                    
                }
            }

            }
            else
            {
                
                string horas = "", minutos = "";
                if (hora < 10)
                {
                    horas = "0" + Convert.ToString(hora);
                }
                else
                {
                    horas = Convert.ToString(hora); ;
                }

                if (minuto == 0)
                {
                    minutos = "00";
                }

                else
                {
                    minutos = Convert.ToString(minuto);
                }

                string horario = horas + ":" + minutos;
                
                SqlConnection conexao = new SqlConnection(@"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=FISIO;Data Source=DESKTOP-1CA9LG5\SQLEXPRESS");
                SqlCommand alterarAgendamenti = new SqlCommand("SET DATEFORMAT DMY UPDATE AGENDAMENTO SET idPaciente = @paciente, dataAgendamento =  @data, horarioAgendamento =  @hora where dataAgendamento = @dataAntiga AND horarioAgendamento = @horaAntiga", conexao);
                alterarAgendamenti.Parameters.Add("@paciente", SqlDbType.Int).Value = lblCodigo.Text;
                alterarAgendamenti.Parameters.Add("@data", SqlDbType.Date).Value = txtConsultaData.Text;
                alterarAgendamenti.Parameters.Add("@hora", SqlDbType.Time).Value = horario;
                alterarAgendamenti.Parameters.Add("@dataAntiga", SqlDbType.Date).Value = dataantiga;
                alterarAgendamenti.Parameters.Add("@horaAntiga", SqlDbType.Time).Value = horaantiga;


                SqlCommand validar = new SqlCommand("SET DATEFORMAT DMY Select  COUNT(*) FROM AGENDAMENTO WHERE dataAgendamento = @data AND horarioAgendamento = @hora", conexao);
                validar.Parameters.Add("@data", SqlDbType.Date).Value = txtConsultaData.Text;
                validar.Parameters.Add("@hora", SqlDbType.Time).Value = horario;

                if (txtPaciente.Text == "" | txtConsultaData.Text == "")
                {
                    MessageBox.Show("Não foi possível fazer o agendamento", "Essa não", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    conexao.Open();
                    SqlDataReader DiaUm = validar.ExecuteReader();
                    DiaUm.Read();
                    int numero = 0;
                    numero = Convert.ToInt32(DiaUm.GetInt32(0));
                    DiaUm.Close();
                    conexao.Close();
                    if (numero > 0)
                    {
                        MessageBox.Show("Esse horário ja está agendado, escolha outro horário para trocar", "Essa não", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }
                    else
                    {
                        try
                        {
                            conexao.Open();
                            alterarAgendamenti.ExecuteNonQuery();
                            MessageBox.Show("Troca de horário realizada com Sucesso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            

                        }
                        catch
                        {
                            MessageBox.Show("Algo deu errado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        finally
                        {
                            conexao.Close();
                            Menu1 menu = Application.OpenForms["Menu1"] as Menu1;
                            menu.bConsultar.Visible = true;
                            menu.Menu1_Load(sender, e);
                            this.Hide();
                               }

                        }
                }
            }


        }

        
    }
}
