namespace Carregamento
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
            this.lb_Percentual = new System.Windows.Forms.Label();
            this.pb_Carregamento = new System.Windows.Forms.ProgressBar();
            this.lb_Titulo = new System.Windows.Forms.Label();
            this.tm_Carregando = new System.Windows.Forms.Timer(this.components);
            this.btn_Sair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_Percentual
            // 
            this.lb_Percentual.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Percentual.AutoSize = true;
            this.lb_Percentual.Location = new System.Drawing.Point(705, 105);
            this.lb_Percentual.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Percentual.Name = "lb_Percentual";
            this.lb_Percentual.Size = new System.Drawing.Size(23, 20);
            this.lb_Percentual.TabIndex = 0;
            this.lb_Percentual.Text = "%";
            // 
            // pb_Carregamento
            // 
            this.pb_Carregamento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_Carregamento.Location = new System.Drawing.Point(13, 90);
            this.pb_Carregamento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pb_Carregamento.Name = "pb_Carregamento";
            this.pb_Carregamento.Size = new System.Drawing.Size(684, 35);
            this.pb_Carregamento.TabIndex = 1;
            // 
            // lb_Titulo
            // 
            this.lb_Titulo.AutoSize = true;
            this.lb_Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Titulo.Location = new System.Drawing.Point(12, 56);
            this.lb_Titulo.Name = "lb_Titulo";
            this.lb_Titulo.Size = new System.Drawing.Size(103, 20);
            this.lb_Titulo.TabIndex = 2;
            this.lb_Titulo.Text = "Carregando";
            // 
            // tm_Carregando
            // 
            this.tm_Carregando.Enabled = true;
            this.tm_Carregando.Tick += new System.EventHandler(this.tm_Carregando_Tick);
            // 
            // btn_Sair
            // 
            this.btn_Sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sair.ForeColor = System.Drawing.Color.Black;
            this.btn_Sair.Location = new System.Drawing.Point(727, -2);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(34, 31);
            this.btn_Sair.TabIndex = 3;
            this.btn_Sair.Text = "X";
            this.btn_Sair.UseVisualStyleBackColor = true;
            this.btn_Sair.Click += new System.EventHandler(this.btn_Sair_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(196)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(760, 150);
            this.Controls.Add(this.btn_Sair);
            this.Controls.Add(this.lb_Titulo);
            this.Controls.Add(this.pb_Carregamento);
            this.Controls.Add(this.lb_Percentual);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Percentual;
        private System.Windows.Forms.ProgressBar pb_Carregamento;
        private System.Windows.Forms.Label lb_Titulo;
        private System.Windows.Forms.Timer tm_Carregando;
        private System.Windows.Forms.Button btn_Sair;
    }
}

