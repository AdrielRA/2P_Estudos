namespace BlockBreaker___Jogo
{
    partial class Form5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.btn_VoltaMENU = new System.Windows.Forms.Button();
            this.btn_VoltaJOGO = new System.Windows.Forms.Button();
            this.lbl_Pausado = new System.Windows.Forms.Label();
            this.btn_NovoJogo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_VoltaMENU
            // 
            this.btn_VoltaMENU.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_VoltaMENU.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_VoltaMENU.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_VoltaMENU.Location = new System.Drawing.Point(78, 284);
            this.btn_VoltaMENU.Name = "btn_VoltaMENU";
            this.btn_VoltaMENU.Size = new System.Drawing.Size(125, 62);
            this.btn_VoltaMENU.TabIndex = 0;
            this.btn_VoltaMENU.Text = "Voltar para o MENU";
            this.btn_VoltaMENU.UseVisualStyleBackColor = false;
            this.btn_VoltaMENU.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_VoltaJOGO
            // 
            this.btn_VoltaJOGO.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_VoltaJOGO.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_VoltaJOGO.Location = new System.Drawing.Point(245, 284);
            this.btn_VoltaJOGO.Name = "btn_VoltaJOGO";
            this.btn_VoltaJOGO.Size = new System.Drawing.Size(125, 62);
            this.btn_VoltaJOGO.TabIndex = 1;
            this.btn_VoltaJOGO.Text = "Voltar ao Jogo";
            this.btn_VoltaJOGO.UseVisualStyleBackColor = true;
            this.btn_VoltaJOGO.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbl_Pausado
            // 
            this.lbl_Pausado.AutoSize = true;
            this.lbl_Pausado.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_Pausado.Font = new System.Drawing.Font("04b03", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Pausado.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_Pausado.Location = new System.Drawing.Point(98, 208);
            this.lbl_Pausado.Name = "lbl_Pausado";
            this.lbl_Pausado.Size = new System.Drawing.Size(251, 32);
            this.lbl_Pausado.TabIndex = 2;
            this.lbl_Pausado.Text = "Jogo Pausado";
            // 
            // btn_NovoJogo
            // 
            this.btn_NovoJogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_NovoJogo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_NovoJogo.Font = new System.Drawing.Font("04b03", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NovoJogo.Location = new System.Drawing.Point(78, 389);
            this.btn_NovoJogo.Name = "btn_NovoJogo";
            this.btn_NovoJogo.Size = new System.Drawing.Size(292, 62);
            this.btn_NovoJogo.TabIndex = 3;
            this.btn_NovoJogo.Text = "Novo Jogo";
            this.btn_NovoJogo.UseVisualStyleBackColor = true;
            this.btn_NovoJogo.Click += new System.EventHandler(this.btn_NovoJogo_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(450, 600);
            this.Controls.Add(this.btn_NovoJogo);
            this.Controls.Add(this.lbl_Pausado);
            this.Controls.Add(this.btn_VoltaJOGO);
            this.Controls.Add(this.btn_VoltaMENU);
            this.Font = new System.Drawing.Font("04b03", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_VoltaMENU;
        private System.Windows.Forms.Button btn_VoltaJOGO;
        private System.Windows.Forms.Label lbl_Pausado;
        private System.Windows.Forms.Button btn_NovoJogo;
    }
}