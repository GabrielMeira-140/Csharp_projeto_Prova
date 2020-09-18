namespace provaPB
{
    partial class Form1
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
            this.mtbVolta = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTamano = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNumCarro = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEscuderia = new System.Windows.Forms.TextBox();
            this.mtbData = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dataVGDados = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.txtExcluir = new System.Windows.Forms.TextBox();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.maskedTB_Prova = new System.Windows.Forms.MaskedTextBox();
            this.txt_Escuderia = new System.Windows.Forms.TextBox();
            this.txt_Numero = new System.Windows.Forms.TextBox();
            this.txt_LarguraCarro = new System.Windows.Forms.TextBox();
            this.maskedTB_Volta = new System.Windows.Forms.MaskedTextBox();
            this.txt_Editar = new System.Windows.Forms.TextBox();
            this.pnlExcluireEditar = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataVGDados)).BeginInit();
            this.pnlExcluireEditar.SuspendLayout();
            this.SuspendLayout();
            // 
            // mtbVolta
            // 
            this.mtbVolta.Font = new System.Drawing.Font("Arial", 12F);
            this.mtbVolta.Location = new System.Drawing.Point(277, 363);
            this.mtbVolta.Mask = "00:00:000";
            this.mtbVolta.Name = "mtbVolta";
            this.mtbVolta.Size = new System.Drawing.Size(331, 26);
            this.mtbVolta.TabIndex = 34;
            this.mtbVolta.ValidatingType = typeof(System.DateTime);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(24, 303);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(178, 18);
            this.label6.TabIndex = 33;
            this.label6.Text = "Largura do carro (metro)";
            // 
            // txtTamano
            // 
            this.txtTamano.Font = new System.Drawing.Font("Arial", 12F);
            this.txtTamano.Location = new System.Drawing.Point(277, 300);
            this.txtTamano.Name = "txtTamano";
            this.txtTamano.Size = new System.Drawing.Size(331, 26);
            this.txtTamano.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(21, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 18);
            this.label5.TabIndex = 31;
            this.label5.Text = "Numero do carro";
            // 
            // txtNumCarro
            // 
            this.txtNumCarro.Font = new System.Drawing.Font("Arial", 12F);
            this.txtNumCarro.Location = new System.Drawing.Point(277, 240);
            this.txtNumCarro.Name = "txtNumCarro";
            this.txtNumCarro.Size = new System.Drawing.Size(331, 26);
            this.txtNumCarro.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(24, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 18);
            this.label4.TabIndex = 29;
            this.label4.Text = "Escuderia";
            // 
            // txtEscuderia
            // 
            this.txtEscuderia.Font = new System.Drawing.Font("Arial", 12F);
            this.txtEscuderia.Location = new System.Drawing.Point(277, 183);
            this.txtEscuderia.Name = "txtEscuderia";
            this.txtEscuderia.Size = new System.Drawing.Size(331, 26);
            this.txtEscuderia.TabIndex = 28;
            // 
            // mtbData
            // 
            this.mtbData.Font = new System.Drawing.Font("Arial", 12F);
            this.mtbData.Location = new System.Drawing.Point(277, 424);
            this.mtbData.Mask = "00/00/0000";
            this.mtbData.Name = "mtbData";
            this.mtbData.Size = new System.Drawing.Size(331, 26);
            this.mtbData.TabIndex = 27;
            this.mtbData.ValidatingType = typeof(System.DateTime);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(24, 427);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 18);
            this.label3.TabIndex = 26;
            this.label3.Text = "Data da prova";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(24, 366);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 18);
            this.label2.TabIndex = 25;
            this.label2.Text = "Tempo da volta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(23, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 18);
            this.label1.TabIndex = 24;
            this.label1.Text = "Nome do piloto";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Arial", 12F);
            this.txtNome.Location = new System.Drawing.Point(277, 124);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(331, 26);
            this.txtNome.TabIndex = 23;
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnAlterar.FlatAppearance.BorderSize = 0;
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.Font = new System.Drawing.Font("Arial", 12F);
            this.btnAlterar.ForeColor = System.Drawing.Color.White;
            this.btnAlterar.Location = new System.Drawing.Point(1076, 510);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(163, 49);
            this.btnAlterar.TabIndex = 22;
            this.btnAlterar.Text = "ALTERAR";
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Arial", 12F);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(907, 510);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(163, 49);
            this.btnClear.TabIndex = 21;
            this.btnClear.Text = "EXCLUIR";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Arial", 12F);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(735, 510);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(166, 49);
            this.btnAdd.TabIndex = 20;
            this.btnAdd.Text = "ADICIONAR";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dataVGDados
            // 
            this.dataVGDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataVGDados.Location = new System.Drawing.Point(635, 29);
            this.dataVGDados.Name = "dataVGDados";
            this.dataVGDados.Size = new System.Drawing.Size(690, 465);
            this.dataVGDados.TabIndex = 38;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(-3, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(251, 18);
            this.label7.TabIndex = 40;
            this.label7.Text = "nome que será editado ou excluido\r\n";
            // 
            // txtExcluir
            // 
            this.txtExcluir.Font = new System.Drawing.Font("Arial", 12F);
            this.txtExcluir.Location = new System.Drawing.Point(253, 3);
            this.txtExcluir.Name = "txtExcluir";
            this.txtExcluir.Size = new System.Drawing.Size(331, 26);
            this.txtExcluir.TabIndex = 39;
            // 
            // txt_Nome
            // 
            this.txt_Nome.Font = new System.Drawing.Font("Arial", 12F);
            this.txt_Nome.Location = new System.Drawing.Point(278, 124);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(331, 26);
            this.txt_Nome.TabIndex = 23;
            // 
            // maskedTB_Prova
            // 
            this.maskedTB_Prova.Font = new System.Drawing.Font("Arial", 12F);
            this.maskedTB_Prova.Location = new System.Drawing.Point(278, 424);
            this.maskedTB_Prova.Mask = "00/00/0000";
            this.maskedTB_Prova.Name = "maskedTB_Prova";
            this.maskedTB_Prova.Size = new System.Drawing.Size(331, 26);
            this.maskedTB_Prova.TabIndex = 27;
            this.maskedTB_Prova.ValidatingType = typeof(System.DateTime);
            // 
            // txt_Escuderia
            // 
            this.txt_Escuderia.Font = new System.Drawing.Font("Arial", 12F);
            this.txt_Escuderia.Location = new System.Drawing.Point(278, 183);
            this.txt_Escuderia.Name = "txt_Escuderia";
            this.txt_Escuderia.Size = new System.Drawing.Size(331, 26);
            this.txt_Escuderia.TabIndex = 28;
            // 
            // txt_Numero
            // 
            this.txt_Numero.Font = new System.Drawing.Font("Arial", 12F);
            this.txt_Numero.Location = new System.Drawing.Point(278, 240);
            this.txt_Numero.Name = "txt_Numero";
            this.txt_Numero.Size = new System.Drawing.Size(331, 26);
            this.txt_Numero.TabIndex = 30;
            // 
            // txt_LarguraCarro
            // 
            this.txt_LarguraCarro.Font = new System.Drawing.Font("Arial", 12F);
            this.txt_LarguraCarro.Location = new System.Drawing.Point(278, 300);
            this.txt_LarguraCarro.Name = "txt_LarguraCarro";
            this.txt_LarguraCarro.Size = new System.Drawing.Size(331, 26);
            this.txt_LarguraCarro.TabIndex = 32;
            // 
            // maskedTB_Volta
            // 
            this.maskedTB_Volta.Font = new System.Drawing.Font("Arial", 12F);
            this.maskedTB_Volta.Location = new System.Drawing.Point(278, 363);
            this.maskedTB_Volta.Mask = "00:00:000";
            this.maskedTB_Volta.Name = "maskedTB_Volta";
            this.maskedTB_Volta.Size = new System.Drawing.Size(331, 26);
            this.maskedTB_Volta.TabIndex = 34;
            this.maskedTB_Volta.ValidatingType = typeof(System.DateTime);
            // 
            // txt_Editar
            // 
            this.txt_Editar.Font = new System.Drawing.Font("Arial", 12F);
            this.txt_Editar.Location = new System.Drawing.Point(254, 3);
            this.txt_Editar.Name = "txt_Editar";
            this.txt_Editar.Size = new System.Drawing.Size(331, 26);
            this.txt_Editar.TabIndex = 39;
            // 
            // pnlExcluireEditar
            // 
            this.pnlExcluireEditar.Controls.Add(this.txt_Editar);
            this.pnlExcluireEditar.Controls.Add(this.label7);
            this.pnlExcluireEditar.Controls.Add(this.txtExcluir);
            this.pnlExcluireEditar.Location = new System.Drawing.Point(24, 63);
            this.pnlExcluireEditar.Name = "pnlExcluireEditar";
            this.pnlExcluireEditar.Size = new System.Drawing.Size(585, 34);
            this.pnlExcluireEditar.TabIndex = 41;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1337, 593);
            this.Controls.Add(this.pnlExcluireEditar);
            this.Controls.Add(this.maskedTB_Volta);
            this.Controls.Add(this.dataVGDados);
            this.Controls.Add(this.mtbVolta);
            this.Controls.Add(this.txt_LarguraCarro);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTamano);
            this.Controls.Add(this.txt_Numero);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNumCarro);
            this.Controls.Add(this.txt_Escuderia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.maskedTB_Prova);
            this.Controls.Add(this.txtEscuderia);
            this.Controls.Add(this.mtbData);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Nome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAdd);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataVGDados)).EndInit();
            this.pnlExcluireEditar.ResumeLayout(false);
            this.pnlExcluireEditar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MaskedTextBox mtbVolta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTamano;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNumCarro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEscuderia;
        private System.Windows.Forms.MaskedTextBox mtbData;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dataVGDados;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtExcluir;
        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.MaskedTextBox maskedTB_Prova;
        private System.Windows.Forms.TextBox txt_Escuderia;
        private System.Windows.Forms.TextBox txt_Numero;
        private System.Windows.Forms.TextBox txt_LarguraCarro;
        private System.Windows.Forms.MaskedTextBox maskedTB_Volta;
        private System.Windows.Forms.TextBox txt_Editar;
        private System.Windows.Forms.Panel pnlExcluireEditar;
    }
}

