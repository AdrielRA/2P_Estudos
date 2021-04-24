namespace Jogo_da_Velha
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Modo_PxP = new System.Windows.Forms.ToolStripMenuItem();
            this.Modo_PxC = new System.Windows.Forms.ToolStripMenuItem();
            this.Zerar_Placar = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_A1 = new System.Windows.Forms.Button();
            this.btn_A2 = new System.Windows.Forms.Button();
            this.btn_A3 = new System.Windows.Forms.Button();
            this.btn_B1 = new System.Windows.Forms.Button();
            this.btn_B2 = new System.Windows.Forms.Button();
            this.btn_B3 = new System.Windows.Forms.Button();
            this.btn_C1 = new System.Windows.Forms.Button();
            this.btn_C2 = new System.Windows.Forms.Button();
            this.btn_C3 = new System.Windows.Forms.Button();
            this.lbl_Empate = new System.Windows.Forms.Label();
            this.lbl_VitoriaX = new System.Windows.Forms.Label();
            this.lbl_EmpateCont = new System.Windows.Forms.Label();
            this.lbl_VitoriaO = new System.Windows.Forms.Label();
            this.div1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_P1 = new System.Windows.Forms.TextBox();
            this.txt_P2 = new System.Windows.Forms.TextBox();
            this.lbl_P1 = new System.Windows.Forms.Label();
            this.lbl_P2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(26)))), ((int)(((byte)(44)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.infosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(267, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.AutoToolTip = true;
            this.arquivoToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(26)))), ((int)(((byte)(44)))));
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Modo_PxP,
            this.Modo_PxC,
            this.Zerar_Placar,
            this.sairToolStripMenuItem});
            this.arquivoToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(110)))), ((int)(((byte)(150)))));
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 19);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // Modo_PxP
            // 
            this.Modo_PxP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(110)))), ((int)(((byte)(150)))));
            this.Modo_PxP.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Modo_PxP.Name = "Modo_PxP";
            this.Modo_PxP.Size = new System.Drawing.Size(181, 22);
            this.Modo_PxP.Text = "Contra Amigo";
            this.Modo_PxP.Click += new System.EventHandler(this.Modo_PxP_Click);
            // 
            // Modo_PxC
            // 
            this.Modo_PxC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(110)))), ((int)(((byte)(150)))));
            this.Modo_PxC.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Modo_PxC.Name = "Modo_PxC";
            this.Modo_PxC.Size = new System.Drawing.Size(181, 22);
            this.Modo_PxC.Text = "Contra Computador";
            this.Modo_PxC.Click += new System.EventHandler(this.Modo_PxC_Click);
            // 
            // Zerar_Placar
            // 
            this.Zerar_Placar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(110)))), ((int)(((byte)(150)))));
            this.Zerar_Placar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Zerar_Placar.Name = "Zerar_Placar";
            this.Zerar_Placar.Size = new System.Drawing.Size(181, 22);
            this.Zerar_Placar.Text = "Zerar Placar";
            this.Zerar_Placar.Click += new System.EventHandler(this.Zerar_Placar_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(110)))), ((int)(((byte)(150)))));
            this.sairToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // infosToolStripMenuItem
            // 
            this.infosToolStripMenuItem.AutoToolTip = true;
            this.infosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobreToolStripMenuItem});
            this.infosToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(110)))), ((int)(((byte)(150)))));
            this.infosToolStripMenuItem.Name = "infosToolStripMenuItem";
            this.infosToolStripMenuItem.Size = new System.Drawing.Size(45, 19);
            this.infosToolStripMenuItem.Text = "Infos";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(110)))), ((int)(((byte)(150)))));
            this.sobreToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.sobreToolStripMenuItem.Text = "Sobre";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
            // 
            // btn_A1
            // 
            this.btn_A1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_A1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btn_A1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_A1.Font = new System.Drawing.Font("Corbel", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_A1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_A1.Location = new System.Drawing.Point(13, 36);
            this.btn_A1.Margin = new System.Windows.Forms.Padding(4);
            this.btn_A1.Name = "btn_A1";
            this.btn_A1.Size = new System.Drawing.Size(75, 75);
            this.btn_A1.TabIndex = 1;
            this.btn_A1.TabStop = false;
            this.btn_A1.UseVisualStyleBackColor = false;
            this.btn_A1.Click += new System.EventHandler(this.button_click);
            this.btn_A1.MouseEnter += new System.EventHandler(this.button_enter);
            this.btn_A1.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // btn_A2
            // 
            this.btn_A2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_A2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btn_A2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_A2.Font = new System.Drawing.Font("Corbel", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_A2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_A2.Location = new System.Drawing.Point(96, 36);
            this.btn_A2.Margin = new System.Windows.Forms.Padding(4);
            this.btn_A2.Name = "btn_A2";
            this.btn_A2.Size = new System.Drawing.Size(75, 75);
            this.btn_A2.TabIndex = 2;
            this.btn_A2.TabStop = false;
            this.btn_A2.UseVisualStyleBackColor = false;
            this.btn_A2.Click += new System.EventHandler(this.button_click);
            this.btn_A2.MouseEnter += new System.EventHandler(this.button_enter);
            this.btn_A2.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // btn_A3
            // 
            this.btn_A3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_A3.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btn_A3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_A3.Font = new System.Drawing.Font("Corbel", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_A3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_A3.Location = new System.Drawing.Point(179, 36);
            this.btn_A3.Margin = new System.Windows.Forms.Padding(4);
            this.btn_A3.Name = "btn_A3";
            this.btn_A3.Size = new System.Drawing.Size(75, 75);
            this.btn_A3.TabIndex = 3;
            this.btn_A3.TabStop = false;
            this.btn_A3.UseVisualStyleBackColor = false;
            this.btn_A3.Click += new System.EventHandler(this.button_click);
            this.btn_A3.MouseEnter += new System.EventHandler(this.button_enter);
            this.btn_A3.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // btn_B1
            // 
            this.btn_B1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_B1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btn_B1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_B1.Font = new System.Drawing.Font("Corbel", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_B1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_B1.Location = new System.Drawing.Point(13, 119);
            this.btn_B1.Margin = new System.Windows.Forms.Padding(4);
            this.btn_B1.Name = "btn_B1";
            this.btn_B1.Size = new System.Drawing.Size(75, 75);
            this.btn_B1.TabIndex = 4;
            this.btn_B1.TabStop = false;
            this.btn_B1.UseVisualStyleBackColor = false;
            this.btn_B1.Click += new System.EventHandler(this.button_click);
            this.btn_B1.MouseEnter += new System.EventHandler(this.button_enter);
            this.btn_B1.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // btn_B2
            // 
            this.btn_B2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_B2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btn_B2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_B2.Font = new System.Drawing.Font("Corbel", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_B2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_B2.Location = new System.Drawing.Point(96, 119);
            this.btn_B2.Margin = new System.Windows.Forms.Padding(4);
            this.btn_B2.Name = "btn_B2";
            this.btn_B2.Size = new System.Drawing.Size(75, 75);
            this.btn_B2.TabIndex = 5;
            this.btn_B2.TabStop = false;
            this.btn_B2.UseVisualStyleBackColor = false;
            this.btn_B2.Click += new System.EventHandler(this.button_click);
            this.btn_B2.MouseEnter += new System.EventHandler(this.button_enter);
            this.btn_B2.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // btn_B3
            // 
            this.btn_B3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_B3.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btn_B3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_B3.Font = new System.Drawing.Font("Corbel", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_B3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_B3.Location = new System.Drawing.Point(179, 119);
            this.btn_B3.Margin = new System.Windows.Forms.Padding(4);
            this.btn_B3.Name = "btn_B3";
            this.btn_B3.Size = new System.Drawing.Size(75, 75);
            this.btn_B3.TabIndex = 6;
            this.btn_B3.TabStop = false;
            this.btn_B3.UseVisualStyleBackColor = false;
            this.btn_B3.Click += new System.EventHandler(this.button_click);
            this.btn_B3.MouseEnter += new System.EventHandler(this.button_enter);
            this.btn_B3.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // btn_C1
            // 
            this.btn_C1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_C1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btn_C1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_C1.Font = new System.Drawing.Font("Corbel", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_C1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_C1.Location = new System.Drawing.Point(13, 202);
            this.btn_C1.Margin = new System.Windows.Forms.Padding(4);
            this.btn_C1.Name = "btn_C1";
            this.btn_C1.Size = new System.Drawing.Size(75, 75);
            this.btn_C1.TabIndex = 7;
            this.btn_C1.TabStop = false;
            this.btn_C1.UseVisualStyleBackColor = false;
            this.btn_C1.Click += new System.EventHandler(this.button_click);
            this.btn_C1.MouseEnter += new System.EventHandler(this.button_enter);
            this.btn_C1.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // btn_C2
            // 
            this.btn_C2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_C2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btn_C2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_C2.Font = new System.Drawing.Font("Corbel", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_C2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_C2.Location = new System.Drawing.Point(96, 202);
            this.btn_C2.Margin = new System.Windows.Forms.Padding(4);
            this.btn_C2.Name = "btn_C2";
            this.btn_C2.Size = new System.Drawing.Size(75, 75);
            this.btn_C2.TabIndex = 8;
            this.btn_C2.TabStop = false;
            this.btn_C2.UseVisualStyleBackColor = false;
            this.btn_C2.Click += new System.EventHandler(this.button_click);
            this.btn_C2.MouseEnter += new System.EventHandler(this.button_enter);
            this.btn_C2.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // btn_C3
            // 
            this.btn_C3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_C3.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btn_C3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_C3.Font = new System.Drawing.Font("Corbel", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_C3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_C3.Location = new System.Drawing.Point(179, 202);
            this.btn_C3.Margin = new System.Windows.Forms.Padding(4);
            this.btn_C3.Name = "btn_C3";
            this.btn_C3.Size = new System.Drawing.Size(75, 75);
            this.btn_C3.TabIndex = 9;
            this.btn_C3.TabStop = false;
            this.btn_C3.UseVisualStyleBackColor = false;
            this.btn_C3.Click += new System.EventHandler(this.button_click);
            this.btn_C3.MouseEnter += new System.EventHandler(this.button_enter);
            this.btn_C3.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // lbl_Empate
            // 
            this.lbl_Empate.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Empate.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbl_Empate.Location = new System.Drawing.Point(96, 291);
            this.lbl_Empate.Name = "lbl_Empate";
            this.lbl_Empate.Size = new System.Drawing.Size(75, 18);
            this.lbl_Empate.TabIndex = 11;
            this.lbl_Empate.Text = "EMPATES";
            this.lbl_Empate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_VitoriaX
            // 
            this.lbl_VitoriaX.AutoSize = true;
            this.lbl_VitoriaX.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_VitoriaX.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbl_VitoriaX.Location = new System.Drawing.Point(22, 312);
            this.lbl_VitoriaX.Name = "lbl_VitoriaX";
            this.lbl_VitoriaX.Size = new System.Drawing.Size(41, 48);
            this.lbl_VitoriaX.TabIndex = 13;
            this.lbl_VitoriaX.Text = "0";
            this.lbl_VitoriaX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_EmpateCont
            // 
            this.lbl_EmpateCont.AutoSize = true;
            this.lbl_EmpateCont.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_EmpateCont.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbl_EmpateCont.Location = new System.Drawing.Point(114, 312);
            this.lbl_EmpateCont.Name = "lbl_EmpateCont";
            this.lbl_EmpateCont.Size = new System.Drawing.Size(41, 48);
            this.lbl_EmpateCont.TabIndex = 14;
            this.lbl_EmpateCont.Text = "0";
            this.lbl_EmpateCont.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_VitoriaO
            // 
            this.lbl_VitoriaO.AutoSize = true;
            this.lbl_VitoriaO.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_VitoriaO.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbl_VitoriaO.Location = new System.Drawing.Point(197, 312);
            this.lbl_VitoriaO.Name = "lbl_VitoriaO";
            this.lbl_VitoriaO.Size = new System.Drawing.Size(41, 48);
            this.lbl_VitoriaO.TabIndex = 15;
            this.lbl_VitoriaO.Text = "0";
            this.lbl_VitoriaO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // div1
            // 
            this.div1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(26)))), ((int)(((byte)(44)))));
            this.div1.Location = new System.Drawing.Point(91, 297);
            this.div1.Name = "div1";
            this.div1.Size = new System.Drawing.Size(2, 82);
            this.div1.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(26)))), ((int)(((byte)(44)))));
            this.label1.Location = new System.Drawing.Point(175, 297);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(2, 82);
            this.label1.TabIndex = 17;
            // 
            // txt_P1
            // 
            this.txt_P1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(70)))));
            this.txt_P1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_P1.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_P1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.txt_P1.Location = new System.Drawing.Point(10, 291);
            this.txt_P1.Name = "txt_P1";
            this.txt_P1.Size = new System.Drawing.Size(81, 19);
            this.txt_P1.TabIndex = 18;
            this.txt_P1.Text = "Jogador 1";
            this.txt_P1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_P2
            // 
            this.txt_P2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(70)))));
            this.txt_P2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_P2.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_P2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.txt_P2.Location = new System.Drawing.Point(178, 291);
            this.txt_P2.Name = "txt_P2";
            this.txt_P2.Size = new System.Drawing.Size(78, 19);
            this.txt_P2.TabIndex = 19;
            this.txt_P2.Text = "Jogador 2";
            this.txt_P2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_P1
            // 
            this.lbl_P1.BackColor = System.Drawing.Color.Transparent;
            this.lbl_P1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbl_P1.Location = new System.Drawing.Point(12, 291);
            this.lbl_P1.Name = "lbl_P1";
            this.lbl_P1.Size = new System.Drawing.Size(78, 19);
            this.lbl_P1.TabIndex = 20;
            this.lbl_P1.Text = "Jogador 1";
            this.lbl_P1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_P1.Visible = false;
            // 
            // lbl_P2
            // 
            this.lbl_P2.BackColor = System.Drawing.Color.Transparent;
            this.lbl_P2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbl_P2.Location = new System.Drawing.Point(179, 291);
            this.lbl_P2.Name = "lbl_P2";
            this.lbl_P2.Size = new System.Drawing.Size(77, 19);
            this.lbl_P2.TabIndex = 21;
            this.lbl_P2.Text = "Jogador 2";
            this.lbl_P2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_P2.Visible = false;
            // 
            // frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(267, 375);
            this.Controls.Add(this.txt_P2);
            this.Controls.Add(this.txt_P1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.div1);
            this.Controls.Add(this.lbl_VitoriaO);
            this.Controls.Add(this.lbl_EmpateCont);
            this.Controls.Add(this.lbl_VitoriaX);
            this.Controls.Add(this.lbl_Empate);
            this.Controls.Add(this.btn_C3);
            this.Controls.Add(this.btn_C2);
            this.Controls.Add(this.btn_C1);
            this.Controls.Add(this.btn_B3);
            this.Controls.Add(this.btn_B2);
            this.Controls.Add(this.btn_B1);
            this.Controls.Add(this.btn_A3);
            this.Controls.Add(this.btn_A2);
            this.Controls.Add(this.btn_A1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lbl_P2);
            this.Controls.Add(this.lbl_P1);
            this.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frm_Principal";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jogo da Velha";
            this.Load += new System.EventHandler(this.frm_Principal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Zerar_Placar;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.Button btn_A1;
        private System.Windows.Forms.Button btn_A2;
        private System.Windows.Forms.Button btn_A3;
        private System.Windows.Forms.Button btn_B1;
        private System.Windows.Forms.Button btn_B2;
        private System.Windows.Forms.Button btn_B3;
        private System.Windows.Forms.Button btn_C1;
        private System.Windows.Forms.Button btn_C2;
        private System.Windows.Forms.Button btn_C3;
        private System.Windows.Forms.Label lbl_Empate;
        private System.Windows.Forms.Label lbl_VitoriaX;
        private System.Windows.Forms.Label lbl_EmpateCont;
        private System.Windows.Forms.Label lbl_VitoriaO;
        private System.Windows.Forms.Label div1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_P1;
        private System.Windows.Forms.TextBox txt_P2;
        private System.Windows.Forms.Label lbl_P1;
        private System.Windows.Forms.Label lbl_P2;
        private System.Windows.Forms.ToolStripMenuItem Modo_PxP;
        private System.Windows.Forms.ToolStripMenuItem Modo_PxC;
    }
}

