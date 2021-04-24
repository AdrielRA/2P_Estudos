namespace BlockBreaker___Jogo
{
    partial class frm_Jogo
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Jogo));
            this.btn_Pausar = new System.Windows.Forms.Button();
            this.pan_JOGO = new System.Windows.Forms.Panel();
            this.img_Bola = new System.Windows.Forms.PictureBox();
            this.img_Plataforma = new System.Windows.Forms.PictureBox();
            this.lbl_Morte = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_Placar = new System.Windows.Forms.Label();
            this.lbl_Topo = new System.Windows.Forms.Label();
            this.pan_JOGO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_Bola)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_Plataforma)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Pausar
            // 
            this.btn_Pausar.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btn_Pausar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(190)))), ((int)(((byte)(200)))));
            this.btn_Pausar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_Pausar.Font = new System.Drawing.Font("04b03", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Pausar.Location = new System.Drawing.Point(391, 12);
            this.btn_Pausar.Name = "btn_Pausar";
            this.btn_Pausar.Size = new System.Drawing.Size(47, 42);
            this.btn_Pausar.TabIndex = 0;
            this.btn_Pausar.TabStop = false;
            this.btn_Pausar.Text = "||";
            this.btn_Pausar.UseVisualStyleBackColor = false;
            this.btn_Pausar.Click += new System.EventHandler(this.btn_Pausar_Click);
            // 
            // pan_JOGO
            // 
            this.pan_JOGO.Controls.Add(this.img_Bola);
            this.pan_JOGO.Controls.Add(this.img_Plataforma);
            this.pan_JOGO.Controls.Add(this.lbl_Morte);
            this.pan_JOGO.Location = new System.Drawing.Point(0, 60);
            this.pan_JOGO.Name = "pan_JOGO";
            this.pan_JOGO.Size = new System.Drawing.Size(450, 540);
            this.pan_JOGO.TabIndex = 1;
            this.pan_JOGO.Click += new System.EventHandler(this.click_continuar);
            this.pan_JOGO.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.tecla_pressionada);
            // 
            // img_Bola
            // 
            this.img_Bola.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("img_Bola.BackgroundImage")));
            this.img_Bola.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.img_Bola.Location = new System.Drawing.Point(220, 180);
            this.img_Bola.Name = "img_Bola";
            this.img_Bola.Size = new System.Drawing.Size(12, 15);
            this.img_Bola.TabIndex = 2;
            this.img_Bola.TabStop = false;
            // 
            // img_Plataforma
            // 
            this.img_Plataforma.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.img_Plataforma.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("img_Plataforma.BackgroundImage")));
            this.img_Plataforma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.img_Plataforma.Location = new System.Drawing.Point(173, 470);
            this.img_Plataforma.Name = "img_Plataforma";
            this.img_Plataforma.Size = new System.Drawing.Size(100, 49);
            this.img_Plataforma.TabIndex = 0;
            this.img_Plataforma.TabStop = false;
            // 
            // lbl_Morte
            // 
            this.lbl_Morte.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbl_Morte.Location = new System.Drawing.Point(0, 495);
            this.lbl_Morte.Name = "lbl_Morte";
            this.lbl_Morte.Size = new System.Drawing.Size(450, 2);
            this.lbl_Morte.TabIndex = 4;
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbl_Placar
            // 
            this.lbl_Placar.AutoSize = true;
            this.lbl_Placar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_Placar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Placar.Location = new System.Drawing.Point(13, 24);
            this.lbl_Placar.Name = "lbl_Placar";
            this.lbl_Placar.Size = new System.Drawing.Size(54, 16);
            this.lbl_Placar.TabIndex = 2;
            this.lbl_Placar.Text = "0 pts";
            // 
            // lbl_Topo
            // 
            this.lbl_Topo.Location = new System.Drawing.Point(0, 58);
            this.lbl_Topo.Name = "lbl_Topo";
            this.lbl_Topo.Size = new System.Drawing.Size(450, 2);
            this.lbl_Topo.TabIndex = 3;
            // 
            // frm_Jogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(450, 600);
            this.Controls.Add(this.lbl_Topo);
            this.Controls.Add(this.lbl_Placar);
            this.Controls.Add(this.pan_JOGO);
            this.Controls.Add(this.btn_Pausar);
            this.Font = new System.Drawing.Font("04b03", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_Jogo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Block Breaker - Jogo";
            this.Load += new System.EventHandler(this.frm_Jogo_Load);
            this.pan_JOGO.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.img_Bola)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_Plataforma)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Pausar;
        private System.Windows.Forms.Panel pan_JOGO;
        private System.Windows.Forms.PictureBox img_Plataforma;
        private System.Windows.Forms.PictureBox img_Bola;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_Placar;
        private System.Windows.Forms.Label lbl_Topo;
        private System.Windows.Forms.Label lbl_Morte;
    }
}