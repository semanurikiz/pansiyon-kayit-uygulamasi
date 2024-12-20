namespace pansiyonkayıt
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAdminGiris = new System.Windows.Forms.Button();
            this.btnYeniMusteri = new System.Windows.Forms.Button();
            this.btnOdalar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(36, -18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(757, 578);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnAdminGiris
            // 
            this.btnAdminGiris.BackColor = System.Drawing.Color.Transparent;
            this.btnAdminGiris.Font = new System.Drawing.Font("Comic Sans MS", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdminGiris.ForeColor = System.Drawing.Color.Purple;
            this.btnAdminGiris.Location = new System.Drawing.Point(75, 65);
            this.btnAdminGiris.Name = "btnAdminGiris";
            this.btnAdminGiris.Size = new System.Drawing.Size(163, 140);
            this.btnAdminGiris.TabIndex = 1;
            this.btnAdminGiris.Text = "Admin Giriş";
            this.btnAdminGiris.UseVisualStyleBackColor = false;
            this.btnAdminGiris.Click += new System.EventHandler(this.btnAdminGiris_Click);
            // 
            // btnYeniMusteri
            // 
            this.btnYeniMusteri.BackColor = System.Drawing.Color.Transparent;
            this.btnYeniMusteri.Font = new System.Drawing.Font("Comic Sans MS", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYeniMusteri.ForeColor = System.Drawing.Color.Purple;
            this.btnYeniMusteri.Location = new System.Drawing.Point(341, 65);
            this.btnYeniMusteri.Name = "btnYeniMusteri";
            this.btnYeniMusteri.Size = new System.Drawing.Size(174, 140);
            this.btnYeniMusteri.TabIndex = 1;
            this.btnYeniMusteri.Text = "Yeni Müşteri";
            this.btnYeniMusteri.UseVisualStyleBackColor = false;
            this.btnYeniMusteri.Click += new System.EventHandler(this.btnYeniMusteri_Click);
            // 
            // btnOdalar
            // 
            this.btnOdalar.Font = new System.Drawing.Font("Comic Sans MS", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOdalar.ForeColor = System.Drawing.Color.Purple;
            this.btnOdalar.Location = new System.Drawing.Point(606, 65);
            this.btnOdalar.Name = "btnOdalar";
            this.btnOdalar.Size = new System.Drawing.Size(167, 140);
            this.btnOdalar.TabIndex = 1;
            this.btnOdalar.Text = "Odalar";
            this.btnOdalar.UseVisualStyleBackColor = true;
            this.btnOdalar.Click += new System.EventHandler(this.btnOdalar_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 561);
            this.Controls.Add(this.btnOdalar);
            this.Controls.Add(this.btnYeniMusteri);
            this.Controls.Add(this.btnAdminGiris);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form3";
            this.Text = "Ana Sayfa";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAdminGiris;
        private System.Windows.Forms.Button btnYeniMusteri;
        private System.Windows.Forms.Button btnOdalar;
    }
}