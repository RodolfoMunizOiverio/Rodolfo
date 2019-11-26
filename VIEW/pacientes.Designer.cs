namespace GE_FISIO.VIEW
{
    partial class pacientes
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
            this.btnEditar = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.botaoSalvar = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNumeroConvenio = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtConvenio = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.bFeminino = new System.Windows.Forms.RadioButton();
            this.bMasculino = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.selecionaDataNasc = new System.Windows.Forms.DateTimePicker();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtDataNascimento = new System.Windows.Forms.MaskedTextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.sinal = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnExcluirPaciente = new System.Windows.Forms.Button();
            this.lblExcluir = new System.Windows.Forms.Label();
            this.codigo = new System.Windows.Forms.Label();
            this.txtCpf = new System.Windows.Forms.MaskedTextBox();
            this.txtCep = new System.Windows.Forms.MaskedTextBox();
            this.txtPaciente = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.DimGray;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditar.Location = new System.Drawing.Point(801, 635);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(149, 40);
            this.btnEditar.TabIndex = 69;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(533, 521);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(321, 21);
            this.label13.TabIndex = 68;
            this.label13.Text = "Campos marcados com    *   são obrigatórios";
            // 
            // botaoSalvar
            // 
            this.botaoSalvar.BackColor = System.Drawing.Color.DarkGreen;
            this.botaoSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoSalvar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.botaoSalvar.Location = new System.Drawing.Point(1017, 635);
            this.botaoSalvar.Name = "botaoSalvar";
            this.botaoSalvar.Size = new System.Drawing.Size(149, 40);
            this.botaoSalvar.TabIndex = 67;
            this.botaoSalvar.Text = "Salvar";
            this.botaoSalvar.UseVisualStyleBackColor = false;
            this.botaoSalvar.Click += new System.EventHandler(this.BotaoSalvar_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(463, 374);
            this.txtEmail.MaxLength = 35;
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(335, 38);
            this.txtEmail.TabIndex = 66;
            // 
            // txtNumeroConvenio
            // 
            this.txtNumeroConvenio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroConvenio.Location = new System.Drawing.Point(1024, 443);
            this.txtNumeroConvenio.MaxLength = 10;
            this.txtNumeroConvenio.Multiline = true;
            this.txtNumeroConvenio.Name = "txtNumeroConvenio";
            this.txtNumeroConvenio.Size = new System.Drawing.Size(217, 38);
            this.txtNumeroConvenio.TabIndex = 65;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(834, 461);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(184, 20);
            this.label12.TabIndex = 64;
            this.label12.Text = "*Número de convênio:";
            // 
            // txtConvenio
            // 
            this.txtConvenio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConvenio.Location = new System.Drawing.Point(216, 458);
            this.txtConvenio.MaxLength = 30;
            this.txtConvenio.Multiline = true;
            this.txtConvenio.Name = "txtConvenio";
            this.txtConvenio.Size = new System.Drawing.Size(582, 38);
            this.txtConvenio.TabIndex = 63;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(44, 476);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 20);
            this.label11.TabIndex = 62;
            this.label11.Text = "*Convênio";
            // 
            // bFeminino
            // 
            this.bFeminino.AutoSize = true;
            this.bFeminino.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bFeminino.Location = new System.Drawing.Point(820, 141);
            this.bFeminino.Name = "bFeminino";
            this.bFeminino.Size = new System.Drawing.Size(43, 29);
            this.bFeminino.TabIndex = 46;
            this.bFeminino.TabStop = true;
            this.bFeminino.Text = "F";
            this.bFeminino.UseVisualStyleBackColor = true;
            // 
            // bMasculino
            // 
            this.bMasculino.AutoSize = true;
            this.bMasculino.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bMasculino.Location = new System.Drawing.Point(750, 141);
            this.bMasculino.Name = "bMasculino";
            this.bMasculino.Size = new System.Drawing.Size(48, 29);
            this.bMasculino.TabIndex = 45;
            this.bMasculino.TabStop = true;
            this.bMasculino.Text = "M";
            this.bMasculino.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(834, 320);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 20);
            this.label10.TabIndex = 60;
            this.label10.Text = "CEP:";
            this.label10.Click += new System.EventHandler(this.Label10_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(677, 147);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 20);
            this.label9.TabIndex = 59;
            this.label9.Text = "Sexo:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(399, 388);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 20);
            this.label7.TabIndex = 58;
            this.label7.Text = "Email:";
            // 
            // selecionaDataNasc
            // 
            this.selecionaDataNasc.CalendarForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.selecionaDataNasc.CalendarMonthBackground = System.Drawing.Color.Green;
            this.selecionaDataNasc.CalendarTitleBackColor = System.Drawing.Color.Green;
            this.selecionaDataNasc.CalendarTitleForeColor = System.Drawing.Color.DarkRed;
            this.selecionaDataNasc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selecionaDataNasc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.selecionaDataNasc.Location = new System.Drawing.Point(1222, 375);
            this.selecionaDataNasc.Name = "selecionaDataNasc";
            this.selecionaDataNasc.Size = new System.Drawing.Size(19, 31);
            this.selecionaDataNasc.TabIndex = 57;
            this.selecionaDataNasc.ValueChanged += new System.EventHandler(this.SelecionaDataNasc_ValueChanged);
            // 
            // txtTelefone
            // 
            this.txtTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefone.Location = new System.Drawing.Point(216, 381);
            this.txtTelefone.Mask = "(00) 00000-00000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(179, 31);
            this.txtTelefone.TabIndex = 56;
            this.txtTelefone.ValidatingType = typeof(System.DateTime);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(44, 386);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 20);
            this.label6.TabIndex = 55;
            this.label6.Text = "Telefone:";
            // 
            // txtCidade
            // 
            this.txtCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCidade.Location = new System.Drawing.Point(216, 302);
            this.txtCidade.MaxLength = 39;
            this.txtCidade.Multiline = true;
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(582, 38);
            this.txtCidade.TabIndex = 54;
            // 
            // txtDataNascimento
            // 
            this.txtDataNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataNascimento.Location = new System.Drawing.Point(1091, 375);
            this.txtDataNascimento.Mask = "00/00/0000";
            this.txtDataNascimento.Name = "txtDataNascimento";
            this.txtDataNascimento.Size = new System.Drawing.Size(125, 31);
            this.txtDataNascimento.TabIndex = 53;
            this.txtDataNascimento.ValidatingType = typeof(System.DateTime);
            // 
            // txtEndereco
            // 
            this.txtEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndereco.Location = new System.Drawing.Point(216, 216);
            this.txtEndereco.MaxLength = 59;
            this.txtEndereco.Multiline = true;
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(582, 36);
            this.txtEndereco.TabIndex = 52;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(44, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 20);
            this.label5.TabIndex = 51;
            this.label5.Text = "Endereço:";
            // 
            // txtBairro
            // 
            this.txtBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBairro.Location = new System.Drawing.Point(902, 216);
            this.txtBairro.MaxLength = 20;
            this.txtBairro.Multiline = true;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(340, 36);
            this.txtBairro.TabIndex = 50;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(834, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 49;
            this.label3.Text = "Bairro:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(834, 384);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 20);
            this.label2.TabIndex = 48;
            this.label2.Text = "*Data de Nascimento:";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(44, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 20);
            this.label1.TabIndex = 47;
            this.label1.Text = "*Nome Completo: ";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(1409, 70);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(35, 13);
            this.lblCodigo.TabIndex = 70;
            this.lblCodigo.Text = "label4";
            this.lblCodigo.Click += new System.EventHandler(this.LblCodigo_Click);
            // 
            // sinal
            // 
            this.sinal.AutoSize = true;
            this.sinal.ForeColor = System.Drawing.Color.Black;
            this.sinal.Location = new System.Drawing.Point(1368, 751);
            this.sinal.Name = "sinal";
            this.sinal.Size = new System.Drawing.Size(35, 13);
            this.sinal.TabIndex = 72;
            this.sinal.Text = "label8";
            this.sinal.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(44, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 73;
            this.label4.Text = "*Cpf:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(44, 320);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 20);
            this.label8.TabIndex = 74;
            this.label8.Text = "Cidade:";
            // 
            // btnExcluirPaciente
            // 
            this.btnExcluirPaciente.BackColor = System.Drawing.Color.Brown;
            this.btnExcluirPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirPaciente.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExcluirPaciente.Location = new System.Drawing.Point(592, 635);
            this.btnExcluirPaciente.Name = "btnExcluirPaciente";
            this.btnExcluirPaciente.Size = new System.Drawing.Size(149, 40);
            this.btnExcluirPaciente.TabIndex = 75;
            this.btnExcluirPaciente.Text = "Excluir";
            this.btnExcluirPaciente.UseVisualStyleBackColor = false;
            this.btnExcluirPaciente.Click += new System.EventHandler(this.BtnExcluirPaciente_Click);
            // 
            // lblExcluir
            // 
            this.lblExcluir.AutoSize = true;
            this.lblExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExcluir.ForeColor = System.Drawing.Color.Black;
            this.lblExcluir.Location = new System.Drawing.Point(1361, 706);
            this.lblExcluir.Name = "lblExcluir";
            this.lblExcluir.Size = new System.Drawing.Size(45, 16);
            this.lblExcluir.TabIndex = 77;
            this.lblExcluir.Text = "label8";
            this.lblExcluir.Visible = false;
            this.lblExcluir.Click += new System.EventHandler(this.LblExcluir_Click);
            // 
            // codigo
            // 
            this.codigo.AutoSize = true;
            this.codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codigo.ForeColor = System.Drawing.Color.Black;
            this.codigo.Location = new System.Drawing.Point(1358, 735);
            this.codigo.Name = "codigo";
            this.codigo.Size = new System.Drawing.Size(45, 16);
            this.codigo.TabIndex = 78;
            this.codigo.Text = "label8";
            this.codigo.Visible = false;
            // 
            // txtCpf
            // 
            this.txtCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCpf.Location = new System.Drawing.Point(216, 141);
            this.txtCpf.Mask = "000,000,000-00";
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(171, 31);
            this.txtCpf.TabIndex = 79;
            this.txtCpf.ValidatingType = typeof(System.DateTime);
            // 
            // txtCep
            // 
            this.txtCep.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCep.Location = new System.Drawing.Point(901, 309);
            this.txtCep.Mask = "00000-000";
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(128, 31);
            this.txtCep.TabIndex = 80;
            this.txtCep.ValidatingType = typeof(System.DateTime);
            // 
            // txtPaciente
            // 
            this.txtPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaciente.Location = new System.Drawing.Point(216, 74);
            this.txtPaciente.MaxLength = 39;
            this.txtPaciente.Multiline = true;
            this.txtPaciente.Name = "txtPaciente";
            this.txtPaciente.Size = new System.Drawing.Size(1026, 36);
            this.txtPaciente.TabIndex = 81;
            // 
            // pacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.txtPaciente);
            this.Controls.Add(this.txtCep);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.codigo);
            this.Controls.Add(this.lblExcluir);
            this.Controls.Add(this.btnExcluirPaciente);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.sinal);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.botaoSalvar);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNumeroConvenio);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtConvenio);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.bFeminino);
            this.Controls.Add(this.bMasculino);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.selecionaDataNasc);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.txtDataNascimento);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "pacientes";
            this.Size = new System.Drawing.Size(1406, 774);
            this.Load += new System.EventHandler(this.Pacientes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.Button botaoSalvar;
        public System.Windows.Forms.TextBox txtEmail;
        public System.Windows.Forms.TextBox txtNumeroConvenio;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.TextBox txtConvenio;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.RadioButton bFeminino;
        public System.Windows.Forms.RadioButton bMasculino;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker selecionaDataNasc;
        public System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtCidade;
        public System.Windows.Forms.MaskedTextBox txtDataNascimento;
        public System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lblCodigo;
        public System.Windows.Forms.Label sinal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.Button btnExcluirPaciente;
        public System.Windows.Forms.Label lblExcluir;
        public System.Windows.Forms.Label codigo;
        public System.Windows.Forms.MaskedTextBox txtCpf;
        public System.Windows.Forms.MaskedTextBox txtCep;
        public System.Windows.Forms.TextBox txtPaciente;
    }
}
