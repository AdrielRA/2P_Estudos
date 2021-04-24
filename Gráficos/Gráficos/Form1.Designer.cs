namespace Gráficos
{
    partial class frmPrincipal
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chtGrafico = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chb3D = new System.Windows.Forms.CheckBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.chtGrafico)).BeginInit();
            this.SuspendLayout();
            // 
            // chtGrafico
            // 
            chartArea2.Name = "ChartArea1";
            this.chtGrafico.ChartAreas.Add(chartArea2);
            this.chtGrafico.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.chtGrafico.Legends.Add(legend2);
            this.chtGrafico.Location = new System.Drawing.Point(0, 26);
            this.chtGrafico.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.chtGrafico.Name = "chtGrafico";
            this.chtGrafico.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chtGrafico.Series.Add(series2);
            this.chtGrafico.Size = new System.Drawing.Size(684, 385);
            this.chtGrafico.TabIndex = 0;
            this.chtGrafico.Text = "Gráfico";
            // 
            // chb3D
            // 
            this.chb3D.AutoSize = true;
            this.chb3D.BackColor = System.Drawing.Color.White;
            this.chb3D.Dock = System.Windows.Forms.DockStyle.Top;
            this.chb3D.Location = new System.Drawing.Point(0, 0);
            this.chb3D.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.chb3D.Name = "chb3D";
            this.chb3D.Size = new System.Drawing.Size(684, 26);
            this.chb3D.TabIndex = 1;
            this.chb3D.Text = "Ativar 3D";
            this.chb3D.UseVisualStyleBackColor = false;
            this.chb3D.CheckedChanged += new System.EventHandler(this.chb3D_CheckedChanged);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 300;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 411);
            this.Controls.Add(this.chtGrafico);
            this.Controls.Add(this.chb3D);
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gráfico";
            ((System.ComponentModel.ISupportInitialize)(this.chtGrafico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chtGrafico;
        private System.Windows.Forms.CheckBox chb3D;
        private System.Windows.Forms.Timer timer;
    }
}

