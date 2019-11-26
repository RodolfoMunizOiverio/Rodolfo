namespace GE_FISIO.VIEW
{
    partial class financas
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.listadeproduto = new System.Windows.Forms.ListView();
            this.Despesa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Valor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Data = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.botaoNovaReceita = new System.Windows.Forms.PictureBox();
            this.botaoNovaDespesa = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.botaoNovaReceita)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.botaoNovaDespesa)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(431, 122);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(234, 58);
            this.button1.TabIndex = 1;
            this.button1.Text = "Receitas";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Brown;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(662, 122);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(234, 58);
            this.button2.TabIndex = 2;
            this.button2.Text = "Despesas";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // listadeproduto
            // 
            this.listadeproduto.BackColor = System.Drawing.Color.White;
            this.listadeproduto.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Despesa,
            this.Valor,
            this.Data});
            this.listadeproduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listadeproduto.HideSelection = false;
            this.listadeproduto.Location = new System.Drawing.Point(431, 186);
            this.listadeproduto.Name = "listadeproduto";
            this.listadeproduto.Size = new System.Drawing.Size(465, 323);
            this.listadeproduto.TabIndex = 4;
            this.listadeproduto.UseCompatibleStateImageBehavior = false;
            this.listadeproduto.View = System.Windows.Forms.View.Details;
            // 
            // Despesa
            // 
            this.Despesa.Text = "Despesa";
            this.Despesa.Width = 186;
            // 
            // Valor
            // 
            this.Valor.Text = "Valor";
            this.Valor.Width = 165;
            // 
            // Data
            // 
            this.Data.Text = "Data";
            this.Data.Width = 108;
            // 
            // botaoNovaReceita
            // 
            this.botaoNovaReceita.BackColor = System.Drawing.Color.Green;
            this.botaoNovaReceita.Image = global::GE_FISIO.Properties.Resources.icone_mais;
            this.botaoNovaReceita.Location = new System.Drawing.Point(608, 140);
            this.botaoNovaReceita.Name = "botaoNovaReceita";
            this.botaoNovaReceita.Size = new System.Drawing.Size(38, 27);
            this.botaoNovaReceita.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.botaoNovaReceita.TabIndex = 5;
            this.botaoNovaReceita.TabStop = false;
            this.botaoNovaReceita.Click += new System.EventHandler(this.BotaoNovaReceita_Click);
            // 
            // botaoNovaDespesa
            // 
            this.botaoNovaDespesa.BackColor = System.Drawing.Color.Brown;
            this.botaoNovaDespesa.Image = global::GE_FISIO.Properties.Resources.icone_mais;
            this.botaoNovaDespesa.Location = new System.Drawing.Point(849, 140);
            this.botaoNovaDespesa.Name = "botaoNovaDespesa";
            this.botaoNovaDespesa.Size = new System.Drawing.Size(38, 27);
            this.botaoNovaDespesa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.botaoNovaDespesa.TabIndex = 6;
            this.botaoNovaDespesa.TabStop = false;
            this.botaoNovaDespesa.Click += new System.EventHandler(this.BotaoNovaDespesa_Click);
            // 
            // financas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1390, 735);
            this.Controls.Add(this.botaoNovaDespesa);
            this.Controls.Add(this.botaoNovaReceita);
            this.Controls.Add(this.listadeproduto);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(214, 86);
            this.Name = "financas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "financas";
            ((System.ComponentModel.ISupportInitialize)(this.botaoNovaReceita)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.botaoNovaDespesa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListView listadeproduto;
        private System.Windows.Forms.ColumnHeader Despesa;
        private System.Windows.Forms.ColumnHeader Valor;
        private System.Windows.Forms.ColumnHeader Data;
        private System.Windows.Forms.PictureBox botaoNovaReceita;
        private System.Windows.Forms.PictureBox botaoNovaDespesa;
    }
}