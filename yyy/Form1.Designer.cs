namespace yyy
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Kanwa = new System.Windows.Forms.PictureBox();
            this.Hitbox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Kanwa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hitbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // Kanwa
            // 
            this.Kanwa.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Kanwa.Location = new System.Drawing.Point(2, 188);
            this.Kanwa.Name = "Kanwa";
            this.Kanwa.Size = new System.Drawing.Size(1069, 135);
            this.Kanwa.TabIndex = 0;
            this.Kanwa.TabStop = false;
            this.Kanwa.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Hitbox
            // 
            this.Hitbox.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.Hitbox.Location = new System.Drawing.Point(63, 188);
            this.Hitbox.Name = "Hitbox";
            this.Hitbox.Size = new System.Drawing.Size(136, 134);
            this.Hitbox.TabIndex = 1;
            this.Hitbox.TabStop = false;
            this.Hitbox.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(53, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Score:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.GameEvent);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::yyy.Properties.Resources.note;
            this.pictureBox3.Location = new System.Drawing.Point(377, 202);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 100);
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "note";
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 450);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Hitbox);
            this.Controls.Add(this.Kanwa);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyisDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyp);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyUP);
            ((System.ComponentModel.ISupportInitialize)(this.Kanwa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hitbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Kanwa;
        private System.Windows.Forms.PictureBox Hitbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

