namespace GE_FISIO
{
    partial class FormLogin
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tLogin = new System.Windows.Forms.TextBox();
            this.tSenha = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.picFechado = new System.Windows.Forms.PictureBox();
            this.picAberto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picFechado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAberto)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(168, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(168, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Senha";
            // 
            // tLogin
            // 
            this.tLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tLogin.Location = new System.Drawing.Point(285, 78);
            this.tLogin.Multiline = true;
            this.tLogin.Name = "tLogin";
            this.tLogin.Size = new System.Drawing.Size(193, 33);
            this.tLogin.TabIndex = 2;
            // 
            // tSenha
            // 
            this.tSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tSenha.Location = new System.Drawing.Point(285, 142);
            this.tSenha.Multiline = true;
            this.tSenha.Name = "tSenha";
            this.tSenha.PasswordChar = '*';
            this.tSenha.Size = new System.Drawing.Size(193, 33);
            this.tSenha.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(329, 197);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 40);
            this.button1.TabIndex = 4;
            this.button1.Text = "Entrar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Crimson;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(171, 197);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 40);
            this.button2.TabIndex = 5;
            this.button2.Text = "Sair";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Image = global::GE_FISIO.Properties.Resources.padlock_77917;
            this.label3.Location = new System.Drawing.Point(23, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 159);
            this.label3.TabIndex = 6;
            this.label3.Click += new System.EventHandler(this.Label3_Click_2);
            // 
            // picFechado
            // 
            this.picFechado.BackColor = System.Drawing.Color.Transparent;
            this.picFechado.Image = global::GE_FISIO.Properties.Resources.olho_fechado;
            this.picFechado.Location = new System.Drawing.Point(480, 144);
            this.picFechado.Name = "picFechado";
            this.picFechado.Size = new System.Drawing.Size(35, 25);
            this.picFechado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFechado.TabIndex = 7;
            this.picFechado.TabStop = false;
            this.picFechado.Click += new System.EventHandler(this.PicFechado_Click);
            // 
            // picAberto
            // 
            this.picAberto.BackColor = System.Drawing.Color.Transparent;
            this.picAberto.Image = global::GE_FISIO.Properties.Resources.olho_aberto;
            this.picAberto.Location = new System.Drawing.Point(480, 144);
            this.picAberto.Name = "picAberto";
            this.picAberto.Size = new System.Drawing.Size(35, 25);
            this.picAberto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAberto.TabIndex = 8;
            this.picAberto.TabStop = false;
            this.picAberto.Click += new System.EventHandler(this.PictureBox2_Click_1);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::GE_FISIO.Properties.Resources.fundo_login1;
            this.ClientSize = new System.Drawing.Size(554, 286);
            this.Controls.Add(this.picAberto);
            this.Controls.Add(this.picFechado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tSenha);
            this.Controls.Add(this.tLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picFechado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAberto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tLogin;
        private System.Windows.Forms.TextBox tSenha;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox picFechado;
        private System.Windows.Forms.PictureBox picAberto;
    }
}

