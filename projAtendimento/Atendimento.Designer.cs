namespace projAtendimento
{
    partial class Atendimento
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
            this.btnGerar = new System.Windows.Forms.Button();
            this.btnListarSenhas = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNumGuiche = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textGuiche = new System.Windows.Forms.TextBox();
            this.btnChamar = new System.Windows.Forms.Button();
            this.btnListarAtend = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txtSenhasGuiche = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnGerar
            // 
            this.btnGerar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerar.Location = new System.Drawing.Point(90, 23);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(57, 23);
            this.btnGerar.TabIndex = 0;
            this.btnGerar.Text = "Gerar";
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // btnListarSenhas
            // 
            this.btnListarSenhas.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarSenhas.Location = new System.Drawing.Point(90, 215);
            this.btnListarSenhas.Name = "btnListarSenhas";
            this.btnListarSenhas.Size = new System.Drawing.Size(69, 24);
            this.btnListarSenhas.TabIndex = 2;
            this.btnListarSenhas.Text = "Senhas";
            this.btnListarSenhas.UseVisualStyleBackColor = true;
            this.btnListarSenhas.Click += new System.EventHandler(this.btnListarSenhas_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(229, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Qtde. guichês";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblNumGuiche
            // 
            this.lblNumGuiche.AutoSize = true;
            this.lblNumGuiche.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumGuiche.Location = new System.Drawing.Point(273, 98);
            this.lblNumGuiche.Name = "lblNumGuiche";
            this.lblNumGuiche.Size = new System.Drawing.Size(15, 16);
            this.lblNumGuiche.TabIndex = 4;
            this.lblNumGuiche.Text = "0";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(232, 126);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Adicionar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(345, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Guichê:";
            // 
            // textGuiche
            // 
            this.textGuiche.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textGuiche.Location = new System.Drawing.Point(396, 23);
            this.textGuiche.Name = "textGuiche";
            this.textGuiche.Size = new System.Drawing.Size(71, 22);
            this.textGuiche.TabIndex = 7;
            this.textGuiche.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btnChamar
            // 
            this.btnChamar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChamar.Location = new System.Drawing.Point(481, 22);
            this.btnChamar.Name = "btnChamar";
            this.btnChamar.Size = new System.Drawing.Size(61, 23);
            this.btnChamar.TabIndex = 8;
            this.btnChamar.Text = "Chamar";
            this.btnChamar.UseVisualStyleBackColor = true;
            this.btnChamar.Click += new System.EventHandler(this.btnChamar_Click);
            // 
            // btnListarAtend
            // 
            this.btnListarAtend.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarAtend.Location = new System.Drawing.Point(421, 215);
            this.btnListarAtend.Name = "btnListarAtend";
            this.btnListarAtend.Size = new System.Drawing.Size(110, 23);
            this.btnListarAtend.TabIndex = 10;
            this.btnListarAtend.Text = "Atendimentos";
            this.btnListarAtend.UseVisualStyleBackColor = true;
            this.btnListarAtend.Click += new System.EventHandler(this.btnListarAtend_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(23, 61);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(200, 148);
            this.listBox1.TabIndex = 11;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // txtSenhasGuiche
            // 
            this.txtSenhasGuiche.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenhasGuiche.FormattingEnabled = true;
            this.txtSenhasGuiche.ItemHeight = 16;
            this.txtSenhasGuiche.Location = new System.Drawing.Point(338, 61);
            this.txtSenhasGuiche.Name = "txtSenhasGuiche";
            this.txtSenhasGuiche.Size = new System.Drawing.Size(271, 148);
            this.txtSenhasGuiche.TabIndex = 12;
            // 
            // Atendimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 248);
            this.Controls.Add(this.txtSenhasGuiche);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnListarAtend);
            this.Controls.Add(this.btnChamar);
            this.Controls.Add(this.textGuiche);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblNumGuiche);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnListarSenhas);
            this.Controls.Add(this.btnGerar);
            this.Name = "Atendimento";
            this.Text = "Atendimento";
            this.Load += new System.EventHandler(this.Atendimento_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.Button btnListarSenhas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNumGuiche;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textGuiche;
        private System.Windows.Forms.Button btnChamar;
        private System.Windows.Forms.Button btnListarAtend;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox txtSenhasGuiche;
    }
}

