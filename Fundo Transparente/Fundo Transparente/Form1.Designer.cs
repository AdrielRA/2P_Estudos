namespace Fundo_Transparente
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
            this.gradientPanel1 = new Fundo_Transparente.GradientPanel();
            this.circularButtom1 = new Fundo_Transparente.CircularButtom();
            this.gradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.ColorBottom = System.Drawing.Color.Teal;
            this.gradientPanel1.ColorTop = System.Drawing.Color.Navy;
            this.gradientPanel1.Controls.Add(this.circularButtom1);
            this.gradientPanel1.Direction = 50F;
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(800, 450);
            this.gradientPanel1.TabIndex = 0;
            // 
            // circularButtom1
            // 
            this.circularButtom1.BackColor = System.Drawing.Color.White;
            this.circularButtom1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.circularButtom1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.circularButtom1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.circularButtom1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularButtom1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.circularButtom1.Location = new System.Drawing.Point(12, 12);
            this.circularButtom1.Name = "circularButtom1";
            this.circularButtom1.Size = new System.Drawing.Size(120, 120);
            this.circularButtom1.TabIndex = 3;
            this.circularButtom1.Text = "Botão Circular";
            this.circularButtom1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.circularButtom1.UseMnemonic = false;
            this.circularButtom1.UseVisualStyleBackColor = false;
            this.circularButtom1.Click += new System.EventHandler(this.circularButtom1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gradientPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GradientPanel gradientPanel1;
        private CircularButtom circularButtom1;
    }
}

