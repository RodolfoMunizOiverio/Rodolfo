namespace GE_FISIO.VIEW
{
    partial class agendamento
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("");
            this.lblPaciente = new System.Windows.Forms.Label();
            this.txtPaciente = new System.Windows.Forms.TextBox();
            this.lblHorario = new System.Windows.Forms.Label();
            this.txtHora = new System.Windows.Forms.TextBox();
            this.btnSetaCimaHora = new System.Windows.Forms.PictureBox();
            this.btnSetaBaixoHora = new System.Windows.Forms.PictureBox();
            this.txtMinutos = new System.Windows.Forms.TextBox();
            this.btnSetaCimaMinuto = new System.Windows.Forms.PictureBox();
            this.btnSetaBaixoMinutos = new System.Windows.Forms.PictureBox();
            this.btnCancelarAgendamento = new System.Windows.Forms.Button();
            this.btnSalvarAgendamento = new System.Windows.Forms.Button();
            this.txtConsultaData = new System.Windows.Forms.MaskedTextBox();
            this.selecionaConsulta = new System.Windows.Forms.DateTimePicker();
            this.listaPaciente = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblCodigo = new System.Windows.Forms.Label();
            this.sinal = new System.Windows.Forms.Label();
            this.btnCalcenlarAgendamento = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.btnSetaCimaHora)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSetaBaixoHora)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSetaCimaMinuto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSetaBaixoMinutos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPaciente
            // 
            this.lblPaciente.AutoSize = true;
            this.lblPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaciente.ForeColor = System.Drawing.Color.Black;
            this.lblPaciente.Location = new System.Drawing.Point(6, 81);
            this.lblPaciente.Name = "lblPaciente";
            this.lblPaciente.Size = new System.Drawing.Size(84, 20);
            this.lblPaciente.TabIndex = 57;
            this.lblPaciente.Text = "Paciente:";
            // 
            // txtPaciente
            // 
            this.txtPaciente.BackColor = System.Drawing.SystemColors.Window;
            this.txtPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaciente.Location = new System.Drawing.Point(85, 65);
            this.txtPaciente.Multiline = true;
            this.txtPaciente.Name = "txtPaciente";
            this.txtPaciente.Size = new System.Drawing.Size(236, 36);
            this.txtPaciente.TabIndex = 58;
            this.txtPaciente.KeyUp += new System.Windows.Forms.KeyEventHandler(this.digitarPaciente);
            // 
            // lblHorario
            // 
            this.lblHorario.AutoSize = true;
            this.lblHorario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorario.ForeColor = System.Drawing.Color.Black;
            this.lblHorario.Location = new System.Drawing.Point(6, 128);
            this.lblHorario.Name = "lblHorario";
            this.lblHorario.Size = new System.Drawing.Size(73, 20);
            this.lblHorario.TabIndex = 59;
            this.lblHorario.Text = "Horário:";
            // 
            // txtHora
            // 
            this.txtHora.BackColor = System.Drawing.SystemColors.Window;
            this.txtHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHora.Location = new System.Drawing.Point(97, 118);
            this.txtHora.Multiline = true;
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(39, 30);
            this.txtHora.TabIndex = 60;
            this.txtHora.Text = "00";
            // 
            // btnSetaCimaHora
            // 
            this.btnSetaCimaHora.BackColor = System.Drawing.Color.White;
            this.btnSetaCimaHora.Image = global::GE_FISIO.Properties.Resources.seta_cima;
            this.btnSetaCimaHora.Location = new System.Drawing.Point(131, 107);
            this.btnSetaCimaHora.Name = "btnSetaCimaHora";
            this.btnSetaCimaHora.Size = new System.Drawing.Size(17, 24);
            this.btnSetaCimaHora.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSetaCimaHora.TabIndex = 61;
            this.btnSetaCimaHora.TabStop = false;
            this.btnSetaCimaHora.Click += new System.EventHandler(this.BtnSetaCimaHora_Click);
            // 
            // btnSetaBaixoHora
            // 
            this.btnSetaBaixoHora.BackColor = System.Drawing.Color.White;
            this.btnSetaBaixoHora.Image = global::GE_FISIO.Properties.Resources.seta_baixo;
            this.btnSetaBaixoHora.Location = new System.Drawing.Point(131, 128);
            this.btnSetaBaixoHora.Name = "btnSetaBaixoHora";
            this.btnSetaBaixoHora.Size = new System.Drawing.Size(17, 24);
            this.btnSetaBaixoHora.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSetaBaixoHora.TabIndex = 63;
            this.btnSetaBaixoHora.TabStop = false;
            this.btnSetaBaixoHora.Click += new System.EventHandler(this.BtnSetaBaixoHora_Click);
            // 
            // txtMinutos
            // 
            this.txtMinutos.BackColor = System.Drawing.SystemColors.Window;
            this.txtMinutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMinutos.Location = new System.Drawing.Point(154, 118);
            this.txtMinutos.Multiline = true;
            this.txtMinutos.Name = "txtMinutos";
            this.txtMinutos.Size = new System.Drawing.Size(32, 30);
            this.txtMinutos.TabIndex = 64;
            this.txtMinutos.Text = "00";
            // 
            // btnSetaCimaMinuto
            // 
            this.btnSetaCimaMinuto.BackColor = System.Drawing.Color.White;
            this.btnSetaCimaMinuto.Image = global::GE_FISIO.Properties.Resources.seta_cima;
            this.btnSetaCimaMinuto.Location = new System.Drawing.Point(181, 107);
            this.btnSetaCimaMinuto.Name = "btnSetaCimaMinuto";
            this.btnSetaCimaMinuto.Size = new System.Drawing.Size(17, 24);
            this.btnSetaCimaMinuto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSetaCimaMinuto.TabIndex = 65;
            this.btnSetaCimaMinuto.TabStop = false;
            this.btnSetaCimaMinuto.Click += new System.EventHandler(this.BtnSetaCimaMinuto_Click);
            // 
            // btnSetaBaixoMinutos
            // 
            this.btnSetaBaixoMinutos.BackColor = System.Drawing.Color.White;
            this.btnSetaBaixoMinutos.Image = global::GE_FISIO.Properties.Resources.seta_baixo1;
            this.btnSetaBaixoMinutos.Location = new System.Drawing.Point(181, 130);
            this.btnSetaBaixoMinutos.Name = "btnSetaBaixoMinutos";
            this.btnSetaBaixoMinutos.Size = new System.Drawing.Size(17, 24);
            this.btnSetaBaixoMinutos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSetaBaixoMinutos.TabIndex = 66;
            this.btnSetaBaixoMinutos.TabStop = false;
            this.btnSetaBaixoMinutos.Click += new System.EventHandler(this.BtnSetaBaixoMinutos_Click);
            // 
            // btnCancelarAgendamento
            // 
            this.btnCancelarAgendamento.BackColor = System.Drawing.Color.Firebrick;
            this.btnCancelarAgendamento.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelarAgendamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarAgendamento.ForeColor = System.Drawing.Color.White;
            this.btnCancelarAgendamento.Location = new System.Drawing.Point(10, 185);
            this.btnCancelarAgendamento.Name = "btnCancelarAgendamento";
            this.btnCancelarAgendamento.Size = new System.Drawing.Size(114, 35);
            this.btnCancelarAgendamento.TabIndex = 67;
            this.btnCancelarAgendamento.Text = "Cancelar";
            this.btnCancelarAgendamento.UseVisualStyleBackColor = false;
            this.btnCancelarAgendamento.Click += new System.EventHandler(this.BtnCancelarAgendamento_Click);
            // 
            // btnSalvarAgendamento
            // 
            this.btnSalvarAgendamento.BackColor = System.Drawing.Color.Green;
            this.btnSalvarAgendamento.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalvarAgendamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarAgendamento.ForeColor = System.Drawing.Color.White;
            this.btnSalvarAgendamento.Location = new System.Drawing.Point(130, 185);
            this.btnSalvarAgendamento.Name = "btnSalvarAgendamento";
            this.btnSalvarAgendamento.Size = new System.Drawing.Size(191, 35);
            this.btnSalvarAgendamento.TabIndex = 68;
            this.btnSalvarAgendamento.Text = "Salvar Agendamento";
            this.btnSalvarAgendamento.UseVisualStyleBackColor = false;
            this.btnSalvarAgendamento.Click += new System.EventHandler(this.BtnSalvarAgendamento_Click);
            // 
            // txtConsultaData
            // 
            this.txtConsultaData.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsultaData.Location = new System.Drawing.Point(96, 10);
            this.txtConsultaData.Mask = "00/00/0000";
            this.txtConsultaData.Name = "txtConsultaData";
            this.txtConsultaData.Size = new System.Drawing.Size(131, 31);
            this.txtConsultaData.TabIndex = 69;
            this.txtConsultaData.ValidatingType = typeof(System.DateTime);
            // 
            // selecionaConsulta
            // 
            this.selecionaConsulta.CalendarForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.selecionaConsulta.CalendarMonthBackground = System.Drawing.Color.Green;
            this.selecionaConsulta.CalendarTitleBackColor = System.Drawing.Color.Green;
            this.selecionaConsulta.CalendarTitleForeColor = System.Drawing.Color.DarkRed;
            this.selecionaConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selecionaConsulta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.selecionaConsulta.Location = new System.Drawing.Point(233, 10);
            this.selecionaConsulta.Name = "selecionaConsulta";
            this.selecionaConsulta.Size = new System.Drawing.Size(19, 31);
            this.selecionaConsulta.TabIndex = 70;
            this.selecionaConsulta.ValueChanged += new System.EventHandler(this.SelecionaConsulta_ValueChanged);
            // 
            // listaPaciente
            // 
            this.listaPaciente.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.nome});
            this.listaPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaPaciente.FullRowSelect = true;
            this.listaPaciente.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listaPaciente.HideSelection = false;
            listViewItem4.IndentCount = 1;
            this.listaPaciente.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem3,
            listViewItem4});
            this.listaPaciente.Location = new System.Drawing.Point(85, 94);
            this.listaPaciente.MultiSelect = false;
            this.listaPaciente.Name = "listaPaciente";
            this.listaPaciente.Scrollable = false;
            this.listaPaciente.Size = new System.Drawing.Size(236, 85);
            this.listaPaciente.TabIndex = 76;
            this.listaPaciente.UseCompatibleStateImageBehavior = false;
            this.listaPaciente.View = System.Windows.Forms.View.Details;
            this.listaPaciente.SelectedIndexChanged += new System.EventHandler(this.ListaPaciente_SelectedIndexChanged);
            this.listaPaciente.DoubleClick += new System.EventHandler(this.duplo_clique_Paciente);
            this.listaPaciente.MouseLeave += new System.EventHandler(this.ListaPaciente_MouseLeave);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Tag = "00";
            this.columnHeader1.Text = "Código";
            this.columnHeader1.Width = 67;
            // 
            // nome
            // 
            this.nome.Tag = "01";
            this.nome.Text = "Paciente";
            this.nome.Width = 708;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.ForeColor = System.Drawing.Color.Black;
            this.lblCodigo.Location = new System.Drawing.Point(263, 301);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(62, 20);
            this.lblCodigo.TabIndex = 77;
            this.lblCodigo.Text = "codigo";
            this.lblCodigo.Visible = false;
            // 
            // sinal
            // 
            this.sinal.AutoSize = true;
            this.sinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sinal.ForeColor = System.Drawing.Color.Black;
            this.sinal.Location = new System.Drawing.Point(177, 301);
            this.sinal.Name = "sinal";
            this.sinal.Size = new System.Drawing.Size(46, 20);
            this.sinal.TabIndex = 78;
            this.sinal.Text = "sinal";
            this.sinal.Visible = false;
            // 
            // btnCalcenlarAgendamento
            // 
            this.btnCalcenlarAgendamento.BackColor = System.Drawing.Color.Gold;
            this.btnCalcenlarAgendamento.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCalcenlarAgendamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcenlarAgendamento.ForeColor = System.Drawing.Color.White;
            this.btnCalcenlarAgendamento.Location = new System.Drawing.Point(131, 226);
            this.btnCalcenlarAgendamento.Name = "btnCalcenlarAgendamento";
            this.btnCalcenlarAgendamento.Size = new System.Drawing.Size(190, 35);
            this.btnCalcenlarAgendamento.TabIndex = 79;
            this.btnCalcenlarAgendamento.Text = "Cancelar Agendamento";
            this.btnCalcenlarAgendamento.UseVisualStyleBackColor = false;
            this.btnCalcenlarAgendamento.Click += new System.EventHandler(this.BtnCalcenlarAgendamento_Click);
            // 
            // agendamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCalcenlarAgendamento);
            this.Controls.Add(this.sinal);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.listaPaciente);
            this.Controls.Add(this.selecionaConsulta);
            this.Controls.Add(this.txtConsultaData);
            this.Controls.Add(this.btnSalvarAgendamento);
            this.Controls.Add(this.btnCancelarAgendamento);
            this.Controls.Add(this.btnSetaBaixoMinutos);
            this.Controls.Add(this.btnSetaCimaMinuto);
            this.Controls.Add(this.txtMinutos);
            this.Controls.Add(this.btnSetaBaixoHora);
            this.Controls.Add(this.btnSetaCimaHora);
            this.Controls.Add(this.txtHora);
            this.Controls.Add(this.lblHorario);
            this.Controls.Add(this.txtPaciente);
            this.Controls.Add(this.lblPaciente);
            this.Name = "agendamento";
            this.Size = new System.Drawing.Size(350, 321);
            this.Load += new System.EventHandler(this.Agendamento_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.btnSetaCimaHora)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSetaBaixoHora)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSetaCimaMinuto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSetaBaixoMinutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPaciente;
        private System.Windows.Forms.Label lblHorario;
        private System.Windows.Forms.PictureBox btnSetaCimaHora;
        private System.Windows.Forms.PictureBox btnSetaBaixoHora;
        private System.Windows.Forms.PictureBox btnSetaCimaMinuto;
        private System.Windows.Forms.PictureBox btnSetaBaixoMinutos;
        private System.Windows.Forms.Button btnCancelarAgendamento;
        private System.Windows.Forms.Button btnSalvarAgendamento;
        private System.Windows.Forms.DateTimePicker selecionaConsulta;
        public System.Windows.Forms.MaskedTextBox txtConsultaData;
        private System.Windows.Forms.ListView listaPaciente;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader nome;
        public System.Windows.Forms.TextBox txtHora;
        public System.Windows.Forms.TextBox txtMinutos;
        public System.Windows.Forms.TextBox txtPaciente;
        public System.Windows.Forms.Label lblCodigo;
        public System.Windows.Forms.Label sinal;
        private System.Windows.Forms.Button btnCalcenlarAgendamento;
    }
}
