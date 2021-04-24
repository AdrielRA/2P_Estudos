namespace Email_Validation1
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
            this.lb_Email = new System.Windows.Forms.Label();
            this.lb_Senha = new System.Windows.Forms.Label();
            this.lb_Titulo = new System.Windows.Forms.Label();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.txt_Senha = new System.Windows.Forms.TextBox();
            this.btn_Val = new System.Windows.Forms.Button();
            this.lb_Recovery = new System.Windows.Forms.Label();
            this.txt_Val = new System.Windows.Forms.Label();
            this.btn_Limpa = new System.Windows.Forms.Button();
            this.lb_Infos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_Email
            // 
            this.lb_Email.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lb_Email.AutoSize = true;
            this.lb_Email.ForeColor = System.Drawing.Color.White;
            this.lb_Email.Location = new System.Drawing.Point(19, 55);
            this.lb_Email.Name = "lb_Email";
            this.lb_Email.Size = new System.Drawing.Size(60, 21);
            this.lb_Email.TabIndex = 0;
            this.lb_Email.Text = "E-mail:";
            this.lb_Email.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_Senha
            // 
            this.lb_Senha.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lb_Senha.AutoSize = true;
            this.lb_Senha.ForeColor = System.Drawing.Color.White;
            this.lb_Senha.Location = new System.Drawing.Point(16, 101);
            this.lb_Senha.Name = "lb_Senha";
            this.lb_Senha.Size = new System.Drawing.Size(63, 21);
            this.lb_Senha.TabIndex = 1;
            this.lb_Senha.Text = "Senha:";
            this.lb_Senha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_Titulo
            // 
            this.lb_Titulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lb_Titulo.AutoSize = true;
            this.lb_Titulo.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Titulo.ForeColor = System.Drawing.Color.White;
            this.lb_Titulo.Location = new System.Drawing.Point(172, 9);
            this.lb_Titulo.Name = "lb_Titulo";
            this.lb_Titulo.Size = new System.Drawing.Size(101, 32);
            this.lb_Titulo.TabIndex = 2;
            this.lb_Titulo.Text = "LOGIN";
            // 
            // txt_Email
            // 
            this.txt_Email.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Email.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txt_Email.BackColor = System.Drawing.Color.White;
            this.txt_Email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(23)))), ((int)(((byte)(30)))));
            this.txt_Email.Location = new System.Drawing.Point(85, 55);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(341, 27);
            this.txt_Email.TabIndex = 3;
            this.txt_Email.Tag = "exemple@exemple.com";
            this.txt_Email.TextChanged += new System.EventHandler(this.txt_Email_TextChanged);
            // 
            // txt_Senha
            // 
            this.txt_Senha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Senha.BackColor = System.Drawing.Color.White;
            this.txt_Senha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(23)))), ((int)(((byte)(30)))));
            this.txt_Senha.Location = new System.Drawing.Point(85, 101);
            this.txt_Senha.Name = "txt_Senha";
            this.txt_Senha.Size = new System.Drawing.Size(341, 27);
            this.txt_Senha.TabIndex = 4;
            this.txt_Senha.UseSystemPasswordChar = true;
            // 
            // btn_Val
            // 
            this.btn_Val.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_Val.BackColor = System.Drawing.Color.White;
            this.btn_Val.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Val.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Val.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(23)))), ((int)(((byte)(30)))));
            this.btn_Val.Location = new System.Drawing.Point(85, 184);
            this.btn_Val.Name = "btn_Val";
            this.btn_Val.Size = new System.Drawing.Size(96, 30);
            this.btn_Val.TabIndex = 6;
            this.btn_Val.Text = "Validar";
            this.btn_Val.UseVisualStyleBackColor = false;
            this.btn_Val.Click += new System.EventHandler(this.btn_Val_Click);
            // 
            // lb_Recovery
            // 
            this.lb_Recovery.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lb_Recovery.AutoSize = true;
            this.lb_Recovery.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lb_Recovery.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lb_Recovery.Location = new System.Drawing.Point(81, 141);
            this.lb_Recovery.Name = "lb_Recovery";
            this.lb_Recovery.Size = new System.Drawing.Size(161, 21);
            this.lb_Recovery.TabIndex = 7;
            this.lb_Recovery.Text = "Esqueceu a senha?";
            this.lb_Recovery.Click += new System.EventHandler(this.lb_Recovery_Click);
            // 
            // txt_Val
            // 
            this.txt_Val.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_Val.AutoSize = true;
            this.txt_Val.Location = new System.Drawing.Point(197, 189);
            this.txt_Val.Name = "txt_Val";
            this.txt_Val.Size = new System.Drawing.Size(0, 21);
            this.txt_Val.TabIndex = 8;
            this.txt_Val.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_Limpa
            // 
            this.btn_Limpa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Limpa.BackColor = System.Drawing.Color.White;
            this.btn_Limpa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Limpa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Limpa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(23)))), ((int)(((byte)(30)))));
            this.btn_Limpa.Location = new System.Drawing.Point(85, 229);
            this.btn_Limpa.Name = "btn_Limpa";
            this.btn_Limpa.Size = new System.Drawing.Size(341, 30);
            this.btn_Limpa.TabIndex = 9;
            this.btn_Limpa.Text = "Limpar";
            this.btn_Limpa.UseVisualStyleBackColor = false;
            this.btn_Limpa.Click += new System.EventHandler(this.btn_Limpa_Click);
            // 
            // lb_Infos
            // 
            this.lb_Infos.AutoSize = true;
            this.lb_Infos.Cursor = System.Windows.Forms.Cursors.Help;
            this.lb_Infos.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Infos.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lb_Infos.Location = new System.Drawing.Point(268, 272);
            this.lb_Infos.Name = "lb_Infos";
            this.lb_Infos.Size = new System.Drawing.Size(158, 17);
            this.lb_Infos.TabIndex = 10;
            this.lb_Infos.Text = "Adriel Ricardo - Beta v1.0";
            this.lb_Infos.Click += new System.EventHandler(this.lb_Infos_Click);
            // 
            // frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(23)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(450, 298);
            this.Controls.Add(this.lb_Infos);
            this.Controls.Add(this.btn_Limpa);
            this.Controls.Add(this.txt_Val);
            this.Controls.Add(this.lb_Recovery);
            this.Controls.Add(this.btn_Val);
            this.Controls.Add(this.txt_Senha);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.lb_Titulo);
            this.Controls.Add(this.lb_Senha);
            this.Controls.Add(this.lb_Email);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "frm_Principal";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Email;
        private System.Windows.Forms.Label lb_Senha;
        private System.Windows.Forms.Label lb_Titulo;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.TextBox txt_Senha;
        private System.Windows.Forms.Button btn_Val;
        private System.Windows.Forms.Label lb_Recovery;
        private System.Windows.Forms.Label txt_Val;
        private System.Windows.Forms.Button btn_Limpa;
        private System.Windows.Forms.Label lb_Infos;
    }
}

