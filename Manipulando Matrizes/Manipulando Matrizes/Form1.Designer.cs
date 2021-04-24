namespace Manipulando_Matrizes
{
    partial class Frm_Principal
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
            this.Pan_Titulo = new System.Windows.Forms.Panel();
            this.Lbl_X = new System.Windows.Forms.Label();
            this.Pan_Base = new System.Windows.Forms.Panel();
            this.Pan_Titulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pan_Titulo
            // 
            this.Pan_Titulo.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Pan_Titulo.Controls.Add(this.Lbl_X);
            this.Pan_Titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pan_Titulo.Location = new System.Drawing.Point(0, 0);
            this.Pan_Titulo.Margin = new System.Windows.Forms.Padding(5);
            this.Pan_Titulo.Name = "Pan_Titulo";
            this.Pan_Titulo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Pan_Titulo.Size = new System.Drawing.Size(800, 35);
            this.Pan_Titulo.TabIndex = 0;
            // 
            // Lbl_X
            // 
            this.Lbl_X.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_X.AutoSize = true;
            this.Lbl_X.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_X.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Lbl_X.Location = new System.Drawing.Point(769, 5);
            this.Lbl_X.Name = "Lbl_X";
            this.Lbl_X.Size = new System.Drawing.Size(26, 25);
            this.Lbl_X.TabIndex = 0;
            this.Lbl_X.Text = "X";
            this.Lbl_X.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Lbl_X.Click += new System.EventHandler(this.Lbl_X_Click);
            this.Lbl_X.MouseEnter += new System.EventHandler(this.Lbl_X_MouseEnter);
            this.Lbl_X.MouseLeave += new System.EventHandler(this.Lbl_X_MouseLeave);
            // 
            // Pan_Base
            // 
            this.Pan_Base.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pan_Base.Location = new System.Drawing.Point(0, 35);
            this.Pan_Base.Name = "Pan_Base";
            this.Pan_Base.Size = new System.Drawing.Size(800, 465);
            this.Pan_Base.TabIndex = 1;
            this.Pan_Base.Paint += new System.Windows.Forms.PaintEventHandler(this.Pan_Base_Paint);
            // 
            // Frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.Pan_Base);
            this.Controls.Add(this.Pan_Titulo);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Frm_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manipulando Matrizes";
            this.Pan_Titulo.ResumeLayout(false);
            this.Pan_Titulo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Pan_Titulo;
        private System.Windows.Forms.Label Lbl_X;
        private System.Windows.Forms.Panel Pan_Base;
    }
}

