namespace About_Me
{
    partial class Form1
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
            this.Logo = new System.Windows.Forms.PictureBox();
            this.UnKlab = new System.Windows.Forms.Label();
            this.AboutMe = new System.Windows.Forms.Label();
            this.Info = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Logo
            // 
            this.Logo.BackColor = System.Drawing.Color.Transparent;
            this.Logo.Image = global::About_Me.Properties.Resources.LOGO_UNIVERSITAS_KLABAT;
            this.Logo.Location = new System.Drawing.Point(12, 12);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(78, 64);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 0;
            this.Logo.TabStop = false;
            this.Logo.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // UnKlab
            // 
            this.UnKlab.BackColor = System.Drawing.Color.Transparent;
            this.UnKlab.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnKlab.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.UnKlab.Location = new System.Drawing.Point(96, 12);
            this.UnKlab.Name = "UnKlab";
            this.UnKlab.Size = new System.Drawing.Size(409, 44);
            this.UnKlab.TabIndex = 0;
            this.UnKlab.Text = "UNIVERSITAS KLABAT";
            // 
            // AboutMe
            // 
            this.AboutMe.AutoSize = true;
            this.AboutMe.BackColor = System.Drawing.Color.Transparent;
            this.AboutMe.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AboutMe.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AboutMe.Location = new System.Drawing.Point(22, 198);
            this.AboutMe.Name = "AboutMe";
            this.AboutMe.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.AboutMe.Size = new System.Drawing.Size(180, 29);
            this.AboutMe.TabIndex = 1;
            this.AboutMe.Text = "About My self";
            this.AboutMe.Click += new System.EventHandler(this.label2_Click);
            // 
            // Info
            // 
            this.Info.BackColor = System.Drawing.Color.Transparent;
            this.Info.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Info.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Info.Location = new System.Drawing.Point(22, 227);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(409, 238);
            this.Info.TabIndex = 2;
            this.Info.Text = "Nama: Walangitan, Jerrico Caldion Jhenkins\r\nFakultas: Ilmu Komputer\r\nProDi: Infor" +
    "matika\r\nAsal: Sulawesi Utara, Bitung\r\nUmur: 21\r\nTanggal lahir: 12-Sep-2002";
            this.Info.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Info.Click += new System.EventHandler(this.Info_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::About_Me.Properties.Resources._20190108_102427;
            this.pictureBox1.Location = new System.Drawing.Point(465, 120);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(451, 345);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = global::About_Me.Properties.Resources.Intel;
            this.ClientSize = new System.Drawing.Size(928, 550);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Info);
            this.Controls.Add(this.AboutMe);
            this.Controls.Add(this.UnKlab);
            this.Controls.Add(this.Logo);
            this.Name = "Form1";
            this.Text = "About Me";
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Label UnKlab;
        private System.Windows.Forms.Label AboutMe;
        private System.Windows.Forms.Label Info;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

