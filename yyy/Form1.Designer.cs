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
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.Hitbox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Kanwa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hitbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hitbox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            // pictureBox10
            // 
            this.pictureBox10.Image = global::yyy.Properties.Resources.note;
            this.pictureBox10.Location = new System.Drawing.Point(377, 573);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(100, 100);
            this.pictureBox10.TabIndex = 14;
            this.pictureBox10.TabStop = false;
            this.pictureBox10.Tag = "note";
            this.pictureBox10.Click += new System.EventHandler(this.pictureBox10_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.pictureBox7.Location = new System.Drawing.Point(63, 573);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(122, 100);
            this.pictureBox7.TabIndex = 11;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox4.Location = new System.Drawing.Point(2, 573);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(1269, 100);
            this.pictureBox4.TabIndex = 8;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::yyy.Properties.Resources.note;
            this.pictureBox9.Location = new System.Drawing.Point(377, 450);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(100, 100);
            this.pictureBox9.TabIndex = 13;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Tag = "note";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox2.Location = new System.Drawing.Point(2, 450);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1269, 100);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click_1);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.pictureBox6.Location = new System.Drawing.Point(63, 450);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(122, 100);
            this.pictureBox6.TabIndex = 10;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click_1);
            // 
            // Hitbox1
            // 
            this.Hitbox1.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.Hitbox1.Location = new System.Drawing.Point(63, 329);
            this.Hitbox1.Name = "Hitbox1";
            this.Hitbox1.Size = new System.Drawing.Size(122, 100);
            this.Hitbox1.TabIndex = 9;
            this.Hitbox1.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::yyy.Properties.Resources.note;
            this.pictureBox8.Location = new System.Drawing.Point(377, 329);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(100, 100);
            this.pictureBox8.TabIndex = 12;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Tag = "note";
            this.pictureBox8.Click += new System.EventHandler(this.pictureBox8_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Location = new System.Drawing.Point(2, 329);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1269, 100);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1266, 703);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.Hitbox1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hitbox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Kanwa;
        private System.Windows.Forms.PictureBox Hitbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox Hitbox1;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

