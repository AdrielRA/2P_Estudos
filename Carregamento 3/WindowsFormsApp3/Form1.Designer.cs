namespace WindowsFormsApp3
{
    partial class frm_Supermercado
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
            System.Windows.Forms.Timer tm_Relogio;
            this.lb_Relogio = new System.Windows.Forms.Label();
            this.pb_Carregando = new System.Windows.Forms.ProgressBar();
            this.lb_Titulo = new System.Windows.Forms.Label();
            this.lb_Processo = new System.Windows.Forms.Label();
            this.btn_Rodar = new System.Windows.Forms.Button();
            this.btn_RodarI = new System.Windows.Forms.Button();
            this.lbl_Porcento = new System.Windows.Forms.Label();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            tm_Relogio = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // tm_Relogio
            // 
            tm_Relogio.Enabled = true;
            tm_Relogio.Interval = 1000;
            tm_Relogio.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lb_Relogio
            // 
            this.lb_Relogio.AutoSize = true;
            this.lb_Relogio.Location = new System.Drawing.Point(381, 9);
            this.lb_Relogio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Relogio.Name = "lb_Relogio";
            this.lb_Relogio.Size = new System.Drawing.Size(71, 20);
            this.lb_Relogio.TabIndex = 0;
            this.lb_Relogio.Tag = "Relógio";
            this.lb_Relogio.Text = "Relógio";
            // 
            // pb_Carregando
            // 
            this.pb_Carregando.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_Carregando.Location = new System.Drawing.Point(13, 62);
            this.pb_Carregando.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pb_Carregando.Name = "pb_Carregando";
            this.pb_Carregando.Size = new System.Drawing.Size(439, 35);
            this.pb_Carregando.TabIndex = 1;
            // 
            // lb_Titulo
            // 
            this.lb_Titulo.AutoSize = true;
            this.lb_Titulo.Location = new System.Drawing.Point(13, 37);
            this.lb_Titulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Titulo.Name = "lb_Titulo";
            this.lb_Titulo.Size = new System.Drawing.Size(139, 20);
            this.lb_Titulo.TabIndex = 2;
            this.lb_Titulo.Text = "Iniciando Sistema";
            // 
            // lb_Processo
            // 
            this.lb_Processo.AutoSize = true;
            this.lb_Processo.Location = new System.Drawing.Point(9, 130);
            this.lb_Processo.Name = "lb_Processo";
            this.lb_Processo.Size = new System.Drawing.Size(73, 20);
            this.lb_Processo.TabIndex = 3;
            this.lb_Processo.Text = "Processo";
            // 
            // btn_Rodar
            // 
            this.btn_Rodar.Location = new System.Drawing.Point(13, 153);
            this.btn_Rodar.Name = "btn_Rodar";
            this.btn_Rodar.Size = new System.Drawing.Size(139, 48);
            this.btn_Rodar.TabIndex = 4;
            this.btn_Rodar.Text = "Rodar Processo";
            this.btn_Rodar.UseVisualStyleBackColor = true;
            this.btn_Rodar.Click += new System.EventHandler(this.btn_Rodar_Click);
            // 
            // btn_RodarI
            // 
            this.btn_RodarI.Location = new System.Drawing.Point(163, 153);
            this.btn_RodarI.Name = "btn_RodarI";
            this.btn_RodarI.Size = new System.Drawing.Size(139, 48);
            this.btn_RodarI.TabIndex = 4;
            this.btn_RodarI.Text = "Rodar Imediatamente";
            this.btn_RodarI.UseVisualStyleBackColor = true;
            // 
            // lbl_Porcento
            // 
            this.lbl_Porcento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Porcento.AutoSize = true;
            this.lbl_Porcento.Location = new System.Drawing.Point(459, 77);
            this.lbl_Porcento.Name = "lbl_Porcento";
            this.lbl_Porcento.Size = new System.Drawing.Size(23, 20);
            this.lbl_Porcento.TabIndex = 3;
            this.lbl_Porcento.Text = "%";
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(313, 153);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(139, 48);
            this.btn_Cancelar.TabIndex = 4;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            // 
            // frm_Supermercado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 231);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_RodarI);
            this.Controls.Add(this.btn_Rodar);
            this.Controls.Add(this.lbl_Porcento);
            this.Controls.Add(this.lb_Processo);
            this.Controls.Add(this.lb_Titulo);
            this.Controls.Add(this.pb_Carregando);
            this.Controls.Add(this.lb_Relogio);
            this.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frm_Supermercado";
            this.Text = "Supermercado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lb_Relogio;
        private System.Windows.Forms.ProgressBar pb_Carregando;
        private System.Windows.Forms.Label lb_Titulo;
        private System.Windows.Forms.Label lb_Processo;
        private System.Windows.Forms.Button btn_Rodar;
        private System.Windows.Forms.Button btn_RodarI;
        private System.Windows.Forms.Label lbl_Porcento;
        private System.Windows.Forms.Button btn_Cancelar;
    }
}

