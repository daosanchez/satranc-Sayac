namespace satranc_sayac_1313
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
            this.components = new System.ComponentModel.Container();
            this.btnBaslat = new System.Windows.Forms.Button();
            this.btnSiyah = new System.Windows.Forms.Button();
            this.btnBeyaz = new System.Windows.Forms.Button();
            this.lblSiyah = new System.Windows.Forms.Label();
            this.lblBeyaz = new System.Windows.Forms.Label();
            this.tmBeyaz = new System.Windows.Forms.Timer(this.components);
            this.tmSiyah = new System.Windows.Forms.Timer(this.components);
            this.lblMesaj = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBaslat
            // 
            this.btnBaslat.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBaslat.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBaslat.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnBaslat.Location = new System.Drawing.Point(75, 36);
            this.btnBaslat.Name = "btnBaslat";
            this.btnBaslat.Size = new System.Drawing.Size(88, 44);
            this.btnBaslat.TabIndex = 0;
            this.btnBaslat.Text = "Başlat";
            this.btnBaslat.UseVisualStyleBackColor = false;
            this.btnBaslat.Click += new System.EventHandler(this.btnBaslat_Click);
            // 
            // btnSiyah
            // 
            this.btnSiyah.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSiyah.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSiyah.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnSiyah.Location = new System.Drawing.Point(126, 95);
            this.btnSiyah.Name = "btnSiyah";
            this.btnSiyah.Size = new System.Drawing.Size(88, 44);
            this.btnSiyah.TabIndex = 1;
            this.btnSiyah.Text = "Siyah";
            this.btnSiyah.UseVisualStyleBackColor = false;
            this.btnSiyah.Click += new System.EventHandler(this.btnSiyah_Click);
            // 
            // btnBeyaz
            // 
            this.btnBeyaz.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBeyaz.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBeyaz.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnBeyaz.Location = new System.Drawing.Point(21, 95);
            this.btnBeyaz.Name = "btnBeyaz";
            this.btnBeyaz.Size = new System.Drawing.Size(88, 44);
            this.btnBeyaz.TabIndex = 2;
            this.btnBeyaz.Text = "Beyaz";
            this.btnBeyaz.UseVisualStyleBackColor = false;
            this.btnBeyaz.Click += new System.EventHandler(this.btnBeyaz_Click);
            // 
            // lblSiyah
            // 
            this.lblSiyah.AutoSize = true;
            this.lblSiyah.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSiyah.Location = new System.Drawing.Point(150, 156);
            this.lblSiyah.Name = "lblSiyah";
            this.lblSiyah.Size = new System.Drawing.Size(24, 20);
            this.lblSiyah.TabIndex = 4;
            this.lblSiyah.Text = "10";
            // 
            // lblBeyaz
            // 
            this.lblBeyaz.AutoSize = true;
            this.lblBeyaz.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBeyaz.Location = new System.Drawing.Point(47, 156);
            this.lblBeyaz.Name = "lblBeyaz";
            this.lblBeyaz.Size = new System.Drawing.Size(24, 20);
            this.lblBeyaz.TabIndex = 5;
            this.lblBeyaz.Text = "10";
            // 
            // tmBeyaz
            // 
            this.tmBeyaz.Interval = 1000;
            this.tmBeyaz.Tick += new System.EventHandler(this.tmBeyaz_Tick);
            // 
            // tmSiyah
            // 
            this.tmSiyah.Interval = 1000;
            this.tmSiyah.Tick += new System.EventHandler(this.tmSiyah_Tick);
            // 
            // lblMesaj
            // 
            this.lblMesaj.AutoSize = true;
            this.lblMesaj.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMesaj.Location = new System.Drawing.Point(47, 210);
            this.lblMesaj.Name = "lblMesaj";
            this.lblMesaj.Size = new System.Drawing.Size(18, 20);
            this.lblMesaj.TabIndex = 6;
            this.lblMesaj.Text = "...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(270, 255);
            this.Controls.Add(this.lblMesaj);
            this.Controls.Add(this.lblBeyaz);
            this.Controls.Add(this.lblSiyah);
            this.Controls.Add(this.btnBeyaz);
            this.Controls.Add(this.btnSiyah);
            this.Controls.Add(this.btnBaslat);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBaslat;
        private System.Windows.Forms.Button btnSiyah;
        private System.Windows.Forms.Button btnBeyaz;
        private System.Windows.Forms.Label lblSiyah;
        private System.Windows.Forms.Label lblBeyaz;
        private System.Windows.Forms.Timer tmBeyaz;
        private System.Windows.Forms.Timer tmSiyah;
        private System.Windows.Forms.Label lblMesaj;
    }
}

