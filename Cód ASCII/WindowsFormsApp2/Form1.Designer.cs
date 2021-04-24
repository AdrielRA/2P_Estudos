namespace WindowsFormsApp2
{
    partial class Tela
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tela));
            this.Texto = new System.Windows.Forms.Label();
            this.Valor = new System.Windows.Forms.Label();
            this.Texto2 = new System.Windows.Forms.Label();
            this.Func = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Texto
            // 
            this.Texto.AutoSize = true;
            this.Texto.BackColor = System.Drawing.Color.Transparent;
            this.Texto.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Texto.ForeColor = System.Drawing.SystemColors.Control;
            this.Texto.Location = new System.Drawing.Point(47, 9);
            this.Texto.Name = "Texto";
            this.Texto.Size = new System.Drawing.Size(205, 31);
            this.Texto.TabIndex = 0;
            this.Texto.Text = "Cód. da Tecla:";
            // 
            // Valor
            // 
            this.Valor.AutoSize = true;
            this.Valor.BackColor = System.Drawing.Color.Transparent;
            this.Valor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Valor.ForeColor = System.Drawing.SystemColors.Control;
            this.Valor.Location = new System.Drawing.Point(258, 15);
            this.Valor.Name = "Valor";
            this.Valor.Size = new System.Drawing.Size(283, 25);
            this.Valor.TabIndex = 1;
            this.Valor.Text = "Nenhum Tecla Pressionada!";
            // 
            // Texto2
            // 
            this.Texto2.AutoSize = true;
            this.Texto2.BackColor = System.Drawing.Color.Transparent;
            this.Texto2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Texto2.ForeColor = System.Drawing.SystemColors.Control;
            this.Texto2.Location = new System.Drawing.Point(12, 35);
            this.Texto2.Name = "Texto2";
            this.Texto2.Size = new System.Drawing.Size(240, 31);
            this.Texto2.TabIndex = 2;
            this.Texto2.Text = "Função da Tecla:";
            this.Texto2.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Func
            // 
            this.Func.AutoSize = true;
            this.Func.BackColor = System.Drawing.Color.Transparent;
            this.Func.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Func.ForeColor = System.Drawing.SystemColors.Control;
            this.Func.Location = new System.Drawing.Point(259, 45);
            this.Func.Name = "Func";
            this.Func.Size = new System.Drawing.Size(207, 20);
            this.Func.TabIndex = 3;
            this.Func.Text = "Nenhum Tecla Pressionada!";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(394, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Beta v1.0 - By Adriel Ricardo";
            // 
            // Tela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(549, 103);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Func);
            this.Controls.Add(this.Texto2);
            this.Controls.Add(this.Valor);
            this.Controls.Add(this.Texto);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Tela";
            this.Text = "Detector de Teclas";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Tela_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Texto;
        private System.Windows.Forms.Label Valor;
        private System.Windows.Forms.Label Texto2;
        private System.Windows.Forms.Label Func;
        private System.Windows.Forms.Label label1;
    }
}

