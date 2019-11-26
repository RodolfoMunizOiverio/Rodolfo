namespace GE_FISIO.VIEW
{
    partial class AAnamnese
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("");
            this.txtNumeroSessoes = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.selecionaData = new System.Windows.Forms.DateTimePicker();
            this.txtDataAvaliacao = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDiagnosticoFisio = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtMedico = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtHMA = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtQueixa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDiagnostico = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPaciente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listaPaciente = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Anamnesesinal = new System.Windows.Forms.Label();
            this.Anamnesecodigo = new System.Windows.Forms.Label();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNumeroSessoes
            // 
            this.txtNumeroSessoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroSessoes.Location = new System.Drawing.Point(317, 606);
            this.txtNumeroSessoes.Multiline = true;
            this.txtNumeroSessoes.Name = "txtNumeroSessoes";
            this.txtNumeroSessoes.Size = new System.Drawing.Size(54, 39);
            this.txtNumeroSessoes.TabIndex = 46;
            this.txtNumeroSessoes.KeyUp += new System.Windows.Forms.KeyEventHandler(this.digitouAlgo);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(64, 625);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(175, 20);
            this.label8.TabIndex = 45;
            this.label8.Text = "Número de Sessões:";
            // 
            // selecionaData
            // 
            this.selecionaData.CalendarForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.selecionaData.CalendarMonthBackground = System.Drawing.Color.Green;
            this.selecionaData.CalendarTitleBackColor = System.Drawing.Color.Green;
            this.selecionaData.CalendarTitleForeColor = System.Drawing.Color.DarkRed;
            this.selecionaData.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selecionaData.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.selecionaData.Location = new System.Drawing.Point(1232, 614);
            this.selecionaData.Name = "selecionaData";
            this.selecionaData.Size = new System.Drawing.Size(19, 31);
            this.selecionaData.TabIndex = 44;
            this.selecionaData.ValueChanged += new System.EventHandler(this.mudardData);
            // 
            // txtDataAvaliacao
            // 
            this.txtDataAvaliacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataAvaliacao.Location = new System.Drawing.Point(1101, 614);
            this.txtDataAvaliacao.Mask = "00/00/0000";
            this.txtDataAvaliacao.Name = "txtDataAvaliacao";
            this.txtDataAvaliacao.Size = new System.Drawing.Size(125, 31);
            this.txtDataAvaliacao.TabIndex = 43;
            this.txtDataAvaliacao.ValidatingType = typeof(System.DateTime);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(901, 623);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(160, 20);
            this.label7.TabIndex = 42;
            this.label7.Text = "Data da Avaliação:";
            // 
            // txtDiagnosticoFisio
            // 
            this.txtDiagnosticoFisio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiagnosticoFisio.Location = new System.Drawing.Point(317, 534);
            this.txtDiagnosticoFisio.Multiline = true;
            this.txtDiagnosticoFisio.Name = "txtDiagnosticoFisio";
            this.txtDiagnosticoFisio.Size = new System.Drawing.Size(933, 39);
            this.txtDiagnosticoFisio.TabIndex = 41;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(64, 553);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(230, 20);
            this.label6.TabIndex = 40;
            this.label6.Text = "Diagnóstico Fisioterapeuta:";
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.DarkGreen;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSalvar.Location = new System.Drawing.Point(1145, 707);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(149, 40);
            this.btnSalvar.TabIndex = 39;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.Button1_Click);
            // 
            // txtMedico
            // 
            this.txtMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMedico.Location = new System.Drawing.Point(317, 211);
            this.txtMedico.Multiline = true;
            this.txtMedico.Name = "txtMedico";
            this.txtMedico.Size = new System.Drawing.Size(471, 36);
            this.txtMedico.TabIndex = 38;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(64, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 20);
            this.label5.TabIndex = 37;
            this.label5.Text = "Médico Responsável:";
            // 
            // txtHMA
            // 
            this.txtHMA.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtHMA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHMA.Location = new System.Drawing.Point(317, 401);
            this.txtHMA.Multiline = true;
            this.txtHMA.Name = "txtHMA";
            this.txtHMA.Size = new System.Drawing.Size(933, 109);
            this.txtHMA.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(64, 416);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 20);
            this.label4.TabIndex = 35;
            this.label4.Text = "HMA/HMB:";
            // 
            // txtQueixa
            // 
            this.txtQueixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQueixa.Location = new System.Drawing.Point(317, 268);
            this.txtQueixa.Multiline = true;
            this.txtQueixa.Name = "txtQueixa";
            this.txtQueixa.Size = new System.Drawing.Size(933, 109);
            this.txtQueixa.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(64, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 20);
            this.label3.TabIndex = 33;
            this.label3.Text = "Queixa Principal:";
            // 
            // txtDiagnostico
            // 
            this.txtDiagnostico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiagnostico.Location = new System.Drawing.Point(317, 99);
            this.txtDiagnostico.Multiline = true;
            this.txtDiagnostico.Name = "txtDiagnostico";
            this.txtDiagnostico.Size = new System.Drawing.Size(933, 91);
            this.txtDiagnostico.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(64, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 20);
            this.label2.TabIndex = 31;
            this.label2.Text = "Diagnóstico Clínico:";
            // 
            // txtPaciente
            // 
            this.txtPaciente.BackColor = System.Drawing.SystemColors.Window;
            this.txtPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaciente.Location = new System.Drawing.Point(317, 45);
            this.txtPaciente.Multiline = true;
            this.txtPaciente.Name = "txtPaciente";
            this.txtPaciente.Size = new System.Drawing.Size(933, 36);
            this.txtPaciente.TabIndex = 30;
            this.txtPaciente.KeyUp += new System.Windows.Forms.KeyEventHandler(this.digitarPaciente);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(73, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 29;
            this.label1.Text = "Paciente:";
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
            listViewItem2.IndentCount = 1;
            this.listaPaciente.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
            this.listaPaciente.Location = new System.Drawing.Point(316, 74);
            this.listaPaciente.MultiSelect = false;
            this.listaPaciente.Name = "listaPaciente";
            this.listaPaciente.Size = new System.Drawing.Size(934, 173);
            this.listaPaciente.TabIndex = 77;
            this.listaPaciente.UseCompatibleStateImageBehavior = false;
            this.listaPaciente.View = System.Windows.Forms.View.Details;
            this.listaPaciente.DoubleClick += new System.EventHandler(this.duploclique);
            this.listaPaciente.MouseLeave += new System.EventHandler(this.MouseSaidoPaciente);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Tag = "00";
            this.columnHeader1.Text = "Código";
            this.columnHeader1.Width = 70;
            // 
            // nome
            // 
            this.nome.Tag = "01";
            this.nome.Text = "Paciente";
            this.nome.Width = 855;
            // 
            // Anamnesesinal
            // 
            this.Anamnesesinal.AutoSize = true;
            this.Anamnesesinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Anamnesesinal.ForeColor = System.Drawing.Color.Black;
            this.Anamnesesinal.Location = new System.Drawing.Point(917, 769);
            this.Anamnesesinal.Name = "Anamnesesinal";
            this.Anamnesesinal.Size = new System.Drawing.Size(49, 20);
            this.Anamnesesinal.TabIndex = 78;
            this.Anamnesesinal.Text = "Sinal";
            // 
            // Anamnesecodigo
            // 
            this.Anamnesecodigo.AutoSize = true;
            this.Anamnesecodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Anamnesecodigo.ForeColor = System.Drawing.Color.Black;
            this.Anamnesecodigo.Location = new System.Drawing.Point(991, 769);
            this.Anamnesecodigo.Name = "Anamnesecodigo";
            this.Anamnesecodigo.Size = new System.Drawing.Size(62, 20);
            this.Anamnesecodigo.TabIndex = 79;
            this.Anamnesecodigo.Text = "codigo";
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.Brown;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExcluir.Location = new System.Drawing.Point(728, 707);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(149, 40);
            this.btnExcluir.TabIndex = 81;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.DimGray;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditar.Location = new System.Drawing.Point(937, 707);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(149, 40);
            this.btnEditar.TabIndex = 80;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            // 
            // AAnamnese
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.Anamnesecodigo);
            this.Controls.Add(this.Anamnesesinal);
            this.Controls.Add(this.listaPaciente);
            this.Controls.Add(this.txtNumeroSessoes);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.selecionaData);
            this.Controls.Add(this.txtDataAvaliacao);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDiagnosticoFisio);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtMedico);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtHMA);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtQueixa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDiagnostico);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPaciente);
            this.Controls.Add(this.label1);
            this.Name = "AAnamnese";
            this.Size = new System.Drawing.Size(1406, 805);
            this.Load += new System.EventHandler(this.AAnamnese_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumeroSessoes;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker selecionaData;
        private System.Windows.Forms.MaskedTextBox txtDataAvaliacao;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDiagnosticoFisio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtMedico;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtHMA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtQueixa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDiagnostico;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPaciente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listaPaciente;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader nome;
        public System.Windows.Forms.Label Anamnesesinal;
        private System.Windows.Forms.Label Anamnesecodigo;
        public System.Windows.Forms.Button btnExcluir;
        public System.Windows.Forms.Button btnEditar;
    }
}
