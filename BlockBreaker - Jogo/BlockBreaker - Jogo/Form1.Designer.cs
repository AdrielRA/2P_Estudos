namespace BlockBreaker___Jogo
{
    partial class frm_Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Principal));
            this.img_Principal = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_creditos = new System.Windows.Forms.Label();
            this.lbl_versao = new System.Windows.Forms.Label();
            this.img_titulo = new System.Windows.Forms.PictureBox();
            this.pan_MENU = new System.Windows.Forms.Panel();
            this.lbl_OP4 = new System.Windows.Forms.Label();
            this.lbl_OP3 = new System.Windows.Forms.Label();
            this.lbl_OP2 = new System.Windows.Forms.Label();
            this.lbl_OP1 = new System.Windows.Forms.Label();
            this.img_Atualizacao = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.img_Principal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_titulo)).BeginInit();
            this.pan_MENU.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_Atualizacao)).BeginInit();
            this.SuspendLayout();
            // 
            // img_Principal
            // 
            this.img_Principal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.img_Principal.Image = ((System.Drawing.Image)(resources.GetObject("img_Principal.Image")));
            this.img_Principal.Location = new System.Drawing.Point(0, -400);
            this.img_Principal.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.img_Principal.Name = "img_Principal";
            this.img_Principal.Size = new System.Drawing.Size(3456, 1557);
            this.img_Principal.TabIndex = 0;
            this.img_Principal.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 866);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // lbl_creditos
            // 
            this.lbl_creditos.AutoSize = true;
            this.lbl_creditos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(252)))), ((int)(((byte)(248)))));
            this.lbl_creditos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_creditos.Font = new System.Drawing.Font("04b03", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_creditos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(150)))));
            this.lbl_creditos.Location = new System.Drawing.Point(5, 533);
            this.lbl_creditos.Name = "lbl_creditos";
            this.lbl_creditos.Padding = new System.Windows.Forms.Padding(3);
            this.lbl_creditos.Size = new System.Drawing.Size(234, 25);
            this.lbl_creditos.TabIndex = 2;
            this.lbl_creditos.Text = "dev by Adriel Ricardo";
            this.lbl_creditos.Click += new System.EventHandler(this.lbl_creditos_Click);
            this.lbl_creditos.MouseEnter += new System.EventHandler(this.Credito_MouseEnter);
            this.lbl_creditos.MouseLeave += new System.EventHandler(this.Credito_MouseLeave);
            // 
            // lbl_versao
            // 
            this.lbl_versao.AutoSize = true;
            this.lbl_versao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(252)))), ((int)(((byte)(248)))));
            this.lbl_versao.Cursor = System.Windows.Forms.Cursors.Help;
            this.lbl_versao.Font = new System.Drawing.Font("04b03", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_versao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(150)))));
            this.lbl_versao.Location = new System.Drawing.Point(315, 537);
            this.lbl_versao.Name = "lbl_versao";
            this.lbl_versao.Size = new System.Drawing.Size(61, 13);
            this.lbl_versao.TabIndex = 3;
            this.lbl_versao.Text = "beta 1.0";
            this.lbl_versao.MouseEnter += new System.EventHandler(this.VERSAO_MouseEnter);
            this.lbl_versao.MouseLeave += new System.EventHandler(this.VERSAO_MouseLeave);
            // 
            // img_titulo
            // 
            this.img_titulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.img_titulo.Image = ((System.Drawing.Image)(resources.GetObject("img_titulo.Image")));
            this.img_titulo.Location = new System.Drawing.Point(0, 0);
            this.img_titulo.Name = "img_titulo";
            this.img_titulo.Size = new System.Drawing.Size(384, 97);
            this.img_titulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.img_titulo.TabIndex = 0;
            this.img_titulo.TabStop = false;
            // 
            // pan_MENU
            // 
            this.pan_MENU.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pan_MENU.BackgroundImage")));
            this.pan_MENU.Controls.Add(this.lbl_OP4);
            this.pan_MENU.Controls.Add(this.lbl_OP3);
            this.pan_MENU.Controls.Add(this.lbl_OP2);
            this.pan_MENU.Controls.Add(this.lbl_OP1);
            this.pan_MENU.Location = new System.Drawing.Point(0, 98);
            this.pan_MENU.Name = "pan_MENU";
            this.pan_MENU.Size = new System.Drawing.Size(384, 330);
            this.pan_MENU.TabIndex = 4;
            // 
            // lbl_OP4
            // 
            this.lbl_OP4.AutoSize = true;
            this.lbl_OP4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_OP4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_OP4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(252)))), ((int)(((byte)(248)))));
            this.lbl_OP4.Location = new System.Drawing.Point(166, 223);
            this.lbl_OP4.Name = "lbl_OP4";
            this.lbl_OP4.Padding = new System.Windows.Forms.Padding(5);
            this.lbl_OP4.Size = new System.Drawing.Size(62, 31);
            this.lbl_OP4.TabIndex = 3;
            this.lbl_OP4.Text = "Sair";
            this.lbl_OP4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_OP4.Click += new System.EventHandler(this.lbl_OP4_Click);
            this.lbl_OP4.MouseEnter += new System.EventHandler(this.MENU_mouseHover);
            this.lbl_OP4.MouseLeave += new System.EventHandler(this.MENU_mouseLeave);
            // 
            // lbl_OP3
            // 
            this.lbl_OP3.AutoSize = true;
            this.lbl_OP3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_OP3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_OP3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(252)))), ((int)(((byte)(248)))));
            this.lbl_OP3.Location = new System.Drawing.Point(156, 181);
            this.lbl_OP3.Name = "lbl_OP3";
            this.lbl_OP3.Padding = new System.Windows.Forms.Padding(5);
            this.lbl_OP3.Size = new System.Drawing.Size(83, 31);
            this.lbl_OP3.TabIndex = 2;
            this.lbl_OP3.Text = "Sobre";
            this.lbl_OP3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_OP3.Click += new System.EventHandler(this.lbl_OP3_Click);
            this.lbl_OP3.MouseEnter += new System.EventHandler(this.MENU_mouseHover);
            this.lbl_OP3.MouseLeave += new System.EventHandler(this.MENU_mouseLeave);
            // 
            // lbl_OP2
            // 
            this.lbl_OP2.AutoSize = true;
            this.lbl_OP2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_OP2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_OP2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(252)))), ((int)(((byte)(248)))));
            this.lbl_OP2.Location = new System.Drawing.Point(130, 139);
            this.lbl_OP2.Name = "lbl_OP2";
            this.lbl_OP2.Padding = new System.Windows.Forms.Padding(5);
            this.lbl_OP2.Size = new System.Drawing.Size(135, 31);
            this.lbl_OP2.TabIndex = 1;
            this.lbl_OP2.Text = "Dificuldade";
            this.lbl_OP2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_OP2.Click += new System.EventHandler(this.lbl_OP2_Click);
            this.lbl_OP2.MouseEnter += new System.EventHandler(this.MENU_mouseHover);
            this.lbl_OP2.MouseLeave += new System.EventHandler(this.MENU_mouseLeave);
            // 
            // lbl_OP1
            // 
            this.lbl_OP1.AutoSize = true;
            this.lbl_OP1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_OP1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_OP1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(252)))), ((int)(((byte)(248)))));
            this.lbl_OP1.Location = new System.Drawing.Point(130, 97);
            this.lbl_OP1.Name = "lbl_OP1";
            this.lbl_OP1.Padding = new System.Windows.Forms.Padding(5);
            this.lbl_OP1.Size = new System.Drawing.Size(135, 31);
            this.lbl_OP1.TabIndex = 0;
            this.lbl_OP1.Text = "Novo Jogo";
            this.lbl_OP1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_OP1.Click += new System.EventHandler(this.lbl_OP1_Click);
            this.lbl_OP1.MouseEnter += new System.EventHandler(this.MENU_mouseHover);
            this.lbl_OP1.MouseLeave += new System.EventHandler(this.MENU_mouseLeave);
            // 
            // img_Atualizacao
            // 
            this.img_Atualizacao.Image = ((System.Drawing.Image)(resources.GetObject("img_Atualizacao.Image")));
            this.img_Atualizacao.Location = new System.Drawing.Point(170, 355);
            this.img_Atualizacao.Name = "img_Atualizacao";
            this.img_Atualizacao.Size = new System.Drawing.Size(214, 178);
            this.img_Atualizacao.TabIndex = 5;
            this.img_Atualizacao.TabStop = false;
            this.img_Atualizacao.Visible = false;
            // 
            // frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 561);
            this.Controls.Add(this.img_Atualizacao);
            this.Controls.Add(this.pan_MENU);
            this.Controls.Add(this.img_titulo);
            this.Controls.Add(this.lbl_versao);
            this.Controls.Add(this.lbl_creditos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.img_Principal);
            this.Font = new System.Drawing.Font("04b03", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.Name = "frm_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MENU - Block Breaker";
            ((System.ComponentModel.ISupportInitialize)(this.img_Principal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_titulo)).EndInit();
            this.pan_MENU.ResumeLayout(false);
            this.pan_MENU.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_Atualizacao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox img_Principal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_creditos;
        private System.Windows.Forms.Label lbl_versao;
        private System.Windows.Forms.PictureBox img_titulo;
        private System.Windows.Forms.Panel pan_MENU;
        private System.Windows.Forms.Label lbl_OP4;
        private System.Windows.Forms.Label lbl_OP3;
        private System.Windows.Forms.Label lbl_OP2;
        private System.Windows.Forms.Label lbl_OP1;
        private System.Windows.Forms.PictureBox img_Atualizacao;
    }
}

