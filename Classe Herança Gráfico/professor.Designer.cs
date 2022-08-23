namespace Classe_Herança_Gráfico
{
    partial class frmprofessor
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.txtidade = new System.Windows.Forms.TextBox();
            this.txttitulacao = new System.Windows.Forms.TextBox();
            this.btncalcular = new System.Windows.Forms.Button();
            this.btnexibir = new System.Windows.Forms.Button();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Idade";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Titulação";
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(113, 42);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(285, 26);
            this.txtnome.TabIndex = 3;
            // 
            // txtidade
            // 
            this.txtidade.Location = new System.Drawing.Point(113, 90);
            this.txtidade.Name = "txtidade";
            this.txtidade.Size = new System.Drawing.Size(285, 26);
            this.txtidade.TabIndex = 4;
            // 
            // txttitulacao
            // 
            this.txttitulacao.Location = new System.Drawing.Point(113, 141);
            this.txttitulacao.Name = "txttitulacao";
            this.txttitulacao.Size = new System.Drawing.Size(285, 26);
            this.txttitulacao.TabIndex = 5;
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(71, 244);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(110, 39);
            this.btncalcular.TabIndex = 6;
            this.btncalcular.Text = "Cadastrar";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // btnexibir
            // 
            this.btnexibir.Location = new System.Drawing.Point(205, 244);
            this.btnexibir.Name = "btnexibir";
            this.btnexibir.Size = new System.Drawing.Size(146, 39);
            this.btnexibir.TabIndex = 7;
            this.btnexibir.Text = "Exibir";
            this.btnexibir.UseVisualStyleBackColor = true;
            this.btnexibir.Click += new System.EventHandler(this.btnexibir_Click);
            // 
            // btnvoltar
            // 
            this.btnvoltar.Location = new System.Drawing.Point(382, 244);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(98, 39);
            this.btnvoltar.TabIndex = 8;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // frmprofessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 343);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.btnexibir);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.txttitulacao);
            this.Controls.Add(this.txtidade);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmprofessor";
            this.Text = "professor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.TextBox txtidade;
        private System.Windows.Forms.TextBox txttitulacao;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Button btnexibir;
        private System.Windows.Forms.Button btnvoltar;
    }
}