namespace WindowsFormsApp4
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
            this.components = new System.ComponentModel.Container();
            this.pb_Carregamento = new System.Windows.Forms.ProgressBar();
            this.tm_Tempo = new System.Windows.Forms.Timer(this.components);
            this.lb_porcent = new System.Windows.Forms.Label();
            this.lb_Titulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pb_Carregamento
            // 
            this.pb_Carregamento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_Carregamento.Location = new System.Drawing.Point(22, 32);
            this.pb_Carregamento.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.pb_Carregamento.Name = "pb_Carregamento";
            this.pb_Carregamento.Size = new System.Drawing.Size(606, 16);
            this.pb_Carregamento.TabIndex = 0;
            // 
            // tm_Tempo
            // 
            this.tm_Tempo.Enabled = true;
            this.tm_Tempo.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lb_porcent
            // 
            this.lb_porcent.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lb_porcent.AutoSize = true;
            this.lb_porcent.Location = new System.Drawing.Point(640, 32);
            this.lb_porcent.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lb_porcent.Name = "lb_porcent";
            this.lb_porcent.Size = new System.Drawing.Size(25, 22);
            this.lb_porcent.TabIndex = 1;
            this.lb_porcent.Text = "%";
            // 
            // lb_Titulo
            // 
            this.lb_Titulo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lb_Titulo.AutoSize = true;
            this.lb_Titulo.Location = new System.Drawing.Point(18, 7);
            this.lb_Titulo.Name = "lb_Titulo";
            this.lb_Titulo.Size = new System.Drawing.Size(125, 22);
            this.lb_Titulo.TabIndex = 2;
            this.lb_Titulo.Text = "Carregando";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(22)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(691, 79);
            this.Controls.Add(this.lb_Titulo);
            this.Controls.Add(this.lb_porcent);
            this.Controls.Add(this.pb_Carregamento);
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar pb_Carregamento;
        private System.Windows.Forms.Timer tm_Tempo;
        private System.Windows.Forms.Label lb_porcent;
        private System.Windows.Forms.Label lb_Titulo;
    }
}

