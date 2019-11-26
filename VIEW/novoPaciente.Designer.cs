namespace GE_FISIO.VIEW
{
    partial class novoPaciente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPaciente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDataNascimento = new System.Windows.Forms.MaskedTextBox();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.selecionaDataNasc = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCep = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.bMasculino = new System.Windows.Forms.RadioButton();
            this.bFeminino = new System.Windows.Forms.RadioButton();
            this.txtConvenio = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtNumeroConvenio = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.botaoSalvar = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.lblcodigo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtEndereco
            // 
            this.txtEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndereco.Location = new System.Drawing.Point(259, 232);
            this.txtEndereco.Multiline = true;
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(576, 36);
            this.txtEndereco.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(87, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Endereço:";
            // 
            // txtBairro
            // 
            this.txtBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBairro.Location = new System.Drawing.Point(915, 232);
            this.txtBairro.Multiline = true;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(295, 36);
            this.txtBairro.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(848, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Bairro:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(859, 402);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Data de Nascimento:";
            // 
            // txtPaciente
            // 
            this.txtPaciente.BackColor = System.Drawing.SystemColors.Window;
            this.txtPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaciente.Location = new System.Drawing.Point(259, 78);
            this.txtPaciente.Multiline = true;
            this.txtPaciente.Name = "txtPaciente";
            this.txtPaciente.Size = new System.Drawing.Size(951, 35);
            this.txtPaciente.TabIndex = 1;
            this.txtPaciente.TextChanged += new System.EventHandler(this.TxtPaciente_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(87, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "*Nome Completo: ";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // txtDataNascimento
            // 
            this.txtDataNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataNascimento.Location = new System.Drawing.Point(1059, 393);
            this.txtDataNascimento.Mask = "00/00/0000";
            this.txtDataNascimento.Name = "txtDataNascimento";
            this.txtDataNascimento.Size = new System.Drawing.Size(125, 31);
            this.txtDataNascimento.TabIndex = 18;
            this.txtDataNascimento.ValidatingType = typeof(System.DateTime);
            // 
            // txtTelefone
            // 
            this.txtTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefone.Location = new System.Drawing.Point(259, 397);
            this.txtTelefone.Mask = "(00) 00000-00000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(188, 31);
            this.txtTelefone.TabIndex = 22;
            this.txtTelefone.ValidatingType = typeof(System.DateTime);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(87, 402);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 20);
            this.label6.TabIndex = 21;
            this.label6.Text = "Telefone:";
            // 
            // selecionaDataNasc
            // 
            this.selecionaDataNasc.CalendarForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.selecionaDataNasc.CalendarMonthBackground = System.Drawing.Color.Green;
            this.selecionaDataNasc.CalendarTitleBackColor = System.Drawing.Color.Green;
            this.selecionaDataNasc.CalendarTitleForeColor = System.Drawing.Color.DarkRed;
            this.selecionaDataNasc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selecionaDataNasc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.selecionaDataNasc.Location = new System.Drawing.Point(1190, 393);
            this.selecionaDataNasc.Name = "selecionaDataNasc";
            this.selecionaDataNasc.Size = new System.Drawing.Size(19, 31);
            this.selecionaDataNasc.TabIndex = 23;
            this.selecionaDataNasc.ValueChanged += new System.EventHandler(this.DateTimePicker1_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(457, 404);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 20);
            this.label7.TabIndex = 24;
            this.label7.Text = "Email:";
            // 
            // txtCpf
            // 
            this.txtCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCpf.Location = new System.Drawing.Point(259, 153);
            this.txtCpf.Multiline = true;
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(379, 38);
            this.txtCpf.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(87, 171);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 20);
            this.label8.TabIndex = 26;
            this.label8.Text = "*CPF:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(943, 168);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 20);
            this.label9.TabIndex = 28;
            this.label9.Text = "Sexo:";
            // 
            // txtCep
            // 
            this.txtCep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCep.Location = new System.Drawing.Point(915, 318);
            this.txtCep.Multiline = true;
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(294, 38);
            this.txtCep.TabIndex = 31;
            this.txtCep.TextChanged += new System.EventHandler(this.TextBox4_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(830, 336);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 20);
            this.label10.TabIndex = 30;
            this.label10.Text = "CEP:";
            this.label10.Click += new System.EventHandler(this.Label10_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(87, 336);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Cidade:";
            this.label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // txtCidade
            // 
            this.txtCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCidade.Location = new System.Drawing.Point(259, 318);
            this.txtCidade.Multiline = true;
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(470, 38);
            this.txtCidade.TabIndex = 20;
            this.txtCidade.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // bMasculino
            // 
            this.bMasculino.AutoSize = true;
            this.bMasculino.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bMasculino.Location = new System.Drawing.Point(1016, 162);
            this.bMasculino.Name = "bMasculino";
            this.bMasculino.Size = new System.Drawing.Size(48, 29);
            this.bMasculino.TabIndex = 3;
            this.bMasculino.TabStop = true;
            this.bMasculino.Text = "M";
            this.bMasculino.UseVisualStyleBackColor = true;
            // 
            // bFeminino
            // 
            this.bFeminino.AutoSize = true;
            this.bFeminino.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bFeminino.Location = new System.Drawing.Point(1086, 162);
            this.bFeminino.Name = "bFeminino";
            this.bFeminino.Size = new System.Drawing.Size(43, 29);
            this.bFeminino.TabIndex = 4;
            this.bFeminino.TabStop = true;
            this.bFeminino.Text = "F";
            this.bFeminino.UseVisualStyleBackColor = true;
            // 
            // txtConvenio
            // 
            this.txtConvenio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConvenio.Location = new System.Drawing.Point(259, 474);
            this.txtConvenio.Multiline = true;
            this.txtConvenio.Name = "txtConvenio";
            this.txtConvenio.Size = new System.Drawing.Size(437, 38);
            this.txtConvenio.TabIndex = 35;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(87, 492);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 20);
            this.label11.TabIndex = 34;
            this.label11.Text = "*Convênio";
            // 
            // txtNumeroConvenio
            // 
            this.txtNumeroConvenio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroConvenio.Location = new System.Drawing.Point(992, 474);
            this.txtNumeroConvenio.Multiline = true;
            this.txtNumeroConvenio.Name = "txtNumeroConvenio";
            this.txtNumeroConvenio.Size = new System.Drawing.Size(217, 38);
            this.txtNumeroConvenio.TabIndex = 37;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(809, 492);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(184, 20);
            this.label12.TabIndex = 36;
            this.label12.Text = "*Número de convênio:";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(521, 390);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(314, 38);
            this.txtEmail.TabIndex = 38;
            // 
            // botaoSalvar
            // 
            this.botaoSalvar.BackColor = System.Drawing.Color.DarkGreen;
            this.botaoSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoSalvar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.botaoSalvar.Location = new System.Drawing.Point(1147, 651);
            this.botaoSalvar.Name = "botaoSalvar";
            this.botaoSalvar.Size = new System.Drawing.Size(149, 40);
            this.botaoSalvar.TabIndex = 40;
            this.botaoSalvar.Text = "Salvar";
            this.botaoSalvar.UseVisualStyleBackColor = false;
            this.botaoSalvar.Click += new System.EventHandler(this.BotaoSalvar_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(576, 537);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(321, 21);
            this.label13.TabIndex = 41;
            this.label13.Text = "Campos marcados com    *   são obrigatórios";
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.DimGray;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditar.Location = new System.Drawing.Point(964, 651);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(149, 40);
            this.btnEditar.TabIndex = 42;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // lblcodigo
            // 
            this.lblcodigo.AutoSize = true;
            this.lblcodigo.Location = new System.Drawing.Point(1304, 42);
            this.lblcodigo.Name = "lblcodigo";
            this.lblcodigo.Size = new System.Drawing.Size(40, 13);
            this.lblcodigo.TabIndex = 43;
            this.lblcodigo.Text = "Código";
            // 
            // novoPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1406, 774);
            this.Controls.Add(this.lblcodigo);
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
            this.Controls.Add(this.txtCep);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.selecionaDataNasc);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDataNascimento);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPaciente);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(214, 86);
            this.Name = "novoPaciente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "novoPaciente";
            this.Load += new System.EventHandler(this.NovoPaciente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker selecionaDataNasc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.TextBox txtPaciente;
        public System.Windows.Forms.TextBox txtCpf;
        public System.Windows.Forms.RadioButton bMasculino;
        public System.Windows.Forms.RadioButton bFeminino;
        public System.Windows.Forms.TextBox txtEndereco;
        public System.Windows.Forms.TextBox txtBairro;
        public System.Windows.Forms.MaskedTextBox txtDataNascimento;
        public System.Windows.Forms.MaskedTextBox txtTelefone;
        public System.Windows.Forms.TextBox txtCep;
        public System.Windows.Forms.TextBox txtCidade;
        public System.Windows.Forms.TextBox txtConvenio;
        public System.Windows.Forms.TextBox txtNumeroConvenio;
        public System.Windows.Forms.TextBox txtEmail;
        public System.Windows.Forms.Button btnEditar;
        public System.Windows.Forms.Button botaoSalvar;
        public System.Windows.Forms.Label lblcodigo;
    }
}