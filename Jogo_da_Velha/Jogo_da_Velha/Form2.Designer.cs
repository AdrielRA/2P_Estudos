namespace Jogo_da_Velha
{
    partial class frm_Nome
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
            this.btn_Nomes = new System.Windows.Forms.Button();
            this.lbl_Nome1 = new System.Windows.Forms.Label();
            this.txt_Nome1 = new System.Windows.Forms.TextBox();
            this.txt_Nome2 = new System.Windows.Forms.TextBox();
            this.lbl_Nome2 = new System.Windows.Forms.Label();
            this.lbl_Info1 = new System.Windows.Forms.Label();
            this.lbl_Info2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Nomes
            // 
            this.btn_Nomes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Nomes.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btn_Nomes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Nomes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(26)))), ((int)(((byte)(44)))));
            this.btn_Nomes.Location = new System.Drawing.Point(395, 104);
            this.btn_Nomes.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Nomes.Name = "btn_Nomes";
            this.btn_Nomes.Size = new System.Drawing.Size(100, 32);
            this.btn_Nomes.TabIndex = 0;
            this.btn_Nomes.Text = "Jogar";
            this.btn_Nomes.UseVisualStyleBackColor = false;
            this.btn_Nomes.Click += new System.EventHandler(this.btn_Nomes_Click);
            // 
            // lbl_Nome1
            // 
            this.lbl_Nome1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Nome1.AutoSize = true;
            this.lbl_Nome1.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nome1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Nome1.Location = new System.Drawing.Point(17, 13);
            this.lbl_Nome1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Nome1.Name = "lbl_Nome1";
            this.lbl_Nome1.Size = new System.Drawing.Size(116, 18);
            this.lbl_Nome1.TabIndex = 1;
            this.lbl_Nome1.Text = "Nome Jogador 1:";
            // 
            // txt_Nome1
            // 
            this.txt_Nome1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Nome1.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nome1.Location = new System.Drawing.Point(135, 8);
            this.txt_Nome1.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Nome1.Name = "txt_Nome1";
            this.txt_Nome1.Size = new System.Drawing.Size(360, 26);
            this.txt_Nome1.TabIndex = 2;
            // 
            // txt_Nome2
            // 
            this.txt_Nome2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Nome2.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nome2.Location = new System.Drawing.Point(135, 56);
            this.txt_Nome2.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Nome2.Name = "txt_Nome2";
            this.txt_Nome2.Size = new System.Drawing.Size(360, 26);
            this.txt_Nome2.TabIndex = 4;
            // 
            // lbl_Nome2
            // 
            this.lbl_Nome2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Nome2.AutoSize = true;
            this.lbl_Nome2.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nome2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Nome2.Location = new System.Drawing.Point(17, 61);
            this.lbl_Nome2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Nome2.Name = "lbl_Nome2";
            this.lbl_Nome2.Size = new System.Drawing.Size(116, 18);
            this.lbl_Nome2.TabIndex = 3;
            this.lbl_Nome2.Text = "Nome Jogador 2:";
            // 
            // lbl_Info1
            // 
            this.lbl_Info1.AutoSize = true;
            this.lbl_Info1.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Info1.Location = new System.Drawing.Point(134, 37);
            this.lbl_Info1.Name = "lbl_Info1";
            this.lbl_Info1.Size = new System.Drawing.Size(41, 14);
            this.lbl_Info1.TabIndex = 5;
            this.lbl_Info1.Text = "JG1 = X";
            // 
            // lbl_Info2
            // 
            this.lbl_Info2.AutoSize = true;
            this.lbl_Info2.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Info2.Location = new System.Drawing.Point(133, 86);
            this.lbl_Info2.Name = "lbl_Info2";
            this.lbl_Info2.Size = new System.Drawing.Size(43, 14);
            this.lbl_Info2.TabIndex = 6;
            this.lbl_Info2.Text = "JG2 = O";
            // 
            // frm_Nome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(26)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(511, 145);
            this.Controls.Add(this.lbl_Info2);
            this.Controls.Add(this.lbl_Info1);
            this.Controls.Add(this.txt_Nome2);
            this.Controls.Add(this.lbl_Nome2);
            this.Controls.Add(this.txt_Nome1);
            this.Controls.Add(this.lbl_Nome1);
            this.Controls.Add(this.btn_Nomes);
            this.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Nome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jogo da Velha - Jogadores";
            this.Load += new System.EventHandler(this.frm_Nome_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Nomes;
        private System.Windows.Forms.Label lbl_Nome1;
        private System.Windows.Forms.TextBox txt_Nome1;
        private System.Windows.Forms.TextBox txt_Nome2;
        private System.Windows.Forms.Label lbl_Nome2;
        private System.Windows.Forms.Label lbl_Info1;
        private System.Windows.Forms.Label lbl_Info2;
    }
}