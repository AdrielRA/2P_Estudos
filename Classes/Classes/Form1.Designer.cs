namespace Classes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.panPrincipal = new System.Windows.Forms.Panel();
            this.panInfo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lalIdade = new System.Windows.Forms.Label();
            this.lblVida = new System.Windows.Forms.Label();
            this.lblQualidade = new System.Windows.Forms.Label();
            this.btnAtacar = new System.Windows.Forms.Button();
            this.btnRecuperar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.lblNometxt = new System.Windows.Forms.Label();
            this.lblIdadetxt = new System.Windows.Forms.Label();
            this.lblQualidadetxt = new System.Windows.Forms.Label();
            this.lblVidatxt = new System.Windows.Forms.Label();
            this.panPrincipal.SuspendLayout();
            this.panInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panPrincipal
            // 
            this.panPrincipal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panPrincipal.BackgroundImage")));
            this.panPrincipal.Controls.Add(this.btnNovo);
            this.panPrincipal.Controls.Add(this.btnRecuperar);
            this.panPrincipal.Controls.Add(this.btnAtacar);
            this.panPrincipal.Controls.Add(this.panInfo);
            this.panPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panPrincipal.Location = new System.Drawing.Point(0, 0);
            this.panPrincipal.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.panPrincipal.Name = "panPrincipal";
            this.panPrincipal.Size = new System.Drawing.Size(359, 336);
            this.panPrincipal.TabIndex = 1;
            // 
            // panInfo
            // 
            this.panInfo.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panInfo.Controls.Add(this.lblVidatxt);
            this.panInfo.Controls.Add(this.lblQualidadetxt);
            this.panInfo.Controls.Add(this.lblIdadetxt);
            this.panInfo.Controls.Add(this.lblNometxt);
            this.panInfo.Controls.Add(this.lblQualidade);
            this.panInfo.Controls.Add(this.lblVida);
            this.panInfo.Controls.Add(this.lalIdade);
            this.panInfo.Controls.Add(this.lblNome);
            this.panInfo.Controls.Add(this.pictureBox1);
            this.panInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panInfo.Location = new System.Drawing.Point(0, 0);
            this.panInfo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.panInfo.Name = "panInfo";
            this.panInfo.Size = new System.Drawing.Size(359, 138);
            this.panInfo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(111, 137);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(121, 9);
            this.lblNome.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(61, 19);
            this.lblNome.TabIndex = 3;
            this.lblNome.Text = "Nome:";
            // 
            // lalIdade
            // 
            this.lalIdade.AutoSize = true;
            this.lalIdade.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lalIdade.Location = new System.Drawing.Point(121, 41);
            this.lalIdade.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lalIdade.Name = "lalIdade";
            this.lalIdade.Size = new System.Drawing.Size(60, 19);
            this.lalIdade.TabIndex = 4;
            this.lalIdade.Text = "Idade:";
            // 
            // lblVida
            // 
            this.lblVida.AutoSize = true;
            this.lblVida.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVida.Location = new System.Drawing.Point(121, 107);
            this.lblVida.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblVida.Name = "lblVida";
            this.lblVida.Size = new System.Drawing.Size(50, 19);
            this.lblVida.TabIndex = 5;
            this.lblVida.Text = "Vida:";
            // 
            // lblQualidade
            // 
            this.lblQualidade.AutoSize = true;
            this.lblQualidade.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQualidade.Location = new System.Drawing.Point(121, 73);
            this.lblQualidade.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblQualidade.Name = "lblQualidade";
            this.lblQualidade.Size = new System.Drawing.Size(98, 19);
            this.lblQualidade.TabIndex = 6;
            this.lblQualidade.Text = "Qualidade:";
            // 
            // btnAtacar
            // 
            this.btnAtacar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAtacar.Location = new System.Drawing.Point(26, 170);
            this.btnAtacar.Name = "btnAtacar";
            this.btnAtacar.Size = new System.Drawing.Size(296, 33);
            this.btnAtacar.TabIndex = 1;
            this.btnAtacar.Text = "Atacar";
            this.btnAtacar.UseVisualStyleBackColor = true;
            this.btnAtacar.Click += new System.EventHandler(this.btnAtacar_Click);
            // 
            // btnRecuperar
            // 
            this.btnRecuperar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRecuperar.Location = new System.Drawing.Point(26, 209);
            this.btnRecuperar.Name = "btnRecuperar";
            this.btnRecuperar.Size = new System.Drawing.Size(296, 33);
            this.btnRecuperar.TabIndex = 2;
            this.btnRecuperar.Text = "Recuperar";
            this.btnRecuperar.UseVisualStyleBackColor = true;
            this.btnRecuperar.Click += new System.EventHandler(this.btnRecuperar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNovo.Location = new System.Drawing.Point(118, 291);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(108, 33);
            this.btnNovo.TabIndex = 3;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // lblNometxt
            // 
            this.lblNometxt.AutoSize = true;
            this.lblNometxt.Location = new System.Drawing.Point(179, 7);
            this.lblNometxt.Name = "lblNometxt";
            this.lblNometxt.Size = new System.Drawing.Size(63, 21);
            this.lblNometxt.TabIndex = 7;
            this.lblNometxt.Text = "Fulana";
            // 
            // lblIdadetxt
            // 
            this.lblIdadetxt.AutoSize = true;
            this.lblIdadetxt.Location = new System.Drawing.Point(179, 40);
            this.lblIdadetxt.Name = "lblIdadetxt";
            this.lblIdadetxt.Size = new System.Drawing.Size(28, 21);
            this.lblIdadetxt.TabIndex = 8;
            this.lblIdadetxt.Text = "25";
            // 
            // lblQualidadetxt
            // 
            this.lblQualidadetxt.AutoSize = true;
            this.lblQualidadetxt.Location = new System.Drawing.Point(218, 72);
            this.lblQualidadetxt.Name = "lblQualidadetxt";
            this.lblQualidadetxt.Size = new System.Drawing.Size(73, 21);
            this.lblQualidadetxt.TabIndex = 9;
            this.lblQualidadetxt.Text = "Alguma";
            // 
            // lblVidatxt
            // 
            this.lblVidatxt.AutoSize = true;
            this.lblVidatxt.Location = new System.Drawing.Point(170, 106);
            this.lblVidatxt.Name = "lblVidatxt";
            this.lblVidatxt.Size = new System.Drawing.Size(37, 21);
            this.lblVidatxt.TabIndex = 10;
            this.lblVidatxt.Text = "100";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(359, 336);
            this.Controls.Add(this.panPrincipal);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Classes: Pessoa";
            this.panPrincipal.ResumeLayout(false);
            this.panInfo.ResumeLayout(false);
            this.panInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panPrincipal;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnRecuperar;
        private System.Windows.Forms.Button btnAtacar;
        private System.Windows.Forms.Panel panInfo;
        private System.Windows.Forms.Label lblVidatxt;
        private System.Windows.Forms.Label lblQualidadetxt;
        private System.Windows.Forms.Label lblIdadetxt;
        private System.Windows.Forms.Label lblNometxt;
        private System.Windows.Forms.Label lblQualidade;
        private System.Windows.Forms.Label lblVida;
        private System.Windows.Forms.Label lalIdade;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

