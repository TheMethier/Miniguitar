﻿namespace yyy
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
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.Hitbox3 = new System.Windows.Forms.PictureBox();
            this.Hitbox2 = new System.Windows.Forms.PictureBox();
            this.Hitbox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.Hitbox = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Kanwa = new System.Windows.Forms.PictureBox();
            this.Kanwa1 = new System.Windows.Forms.PictureBox();
            this.Kanwa2 = new System.Windows.Forms.PictureBox();
            this.Kanwa3 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hitbox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hitbox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hitbox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hitbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Kanwa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Kanwa1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Kanwa2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Kanwa3)).BeginInit();
            this.SuspendLayout();
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
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pictureBox6.Location = new System.Drawing.Point(446, 467);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(120, 120);
            this.pictureBox6.TabIndex = 14;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Tag = "note4";
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox10_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Navy;
            this.pictureBox5.Location = new System.Drawing.Point(446, 349);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(120, 120);
            this.pictureBox5.TabIndex = 13;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Tag = "note3";
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox9_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Red;
            this.pictureBox3.InitialImage = global::yyy.Properties.Resources.orange_circle;
            this.pictureBox3.Location = new System.Drawing.Point(446, 97);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(120, 120);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "note1";
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox8_Click);
            // 
            // Hitbox3
            // 
            this.Hitbox3.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.Hitbox3.Location = new System.Drawing.Point(12, 467);
            this.Hitbox3.Name = "Hitbox3";
            this.Hitbox3.Size = new System.Drawing.Size(120, 120);
            this.Hitbox3.TabIndex = 11;
            this.Hitbox3.TabStop = false;
            this.Hitbox3.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // Hitbox2
            // 
            this.Hitbox2.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.Hitbox2.Location = new System.Drawing.Point(12, 349);
            this.Hitbox2.Name = "Hitbox2";
            this.Hitbox2.Size = new System.Drawing.Size(120, 120);
            this.Hitbox2.TabIndex = 10;
            this.Hitbox2.TabStop = false;
            this.Hitbox2.Click += new System.EventHandler(this.pictureBox6_Click_1);
            // 
            // Hitbox1
            // 
            this.Hitbox1.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.Hitbox1.Location = new System.Drawing.Point(12, 223);
            this.Hitbox1.Name = "Hitbox1";
            this.Hitbox1.Size = new System.Drawing.Size(120, 120);
            this.Hitbox1.TabIndex = 9;
            this.Hitbox1.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Yellow;
            this.pictureBox4.Location = new System.Drawing.Point(446, 236);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(120, 120);
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Tag = "note2";
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // Hitbox
            // 
            this.Hitbox.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.Hitbox.Location = new System.Drawing.Point(12, 97);
            this.Hitbox.Name = "Hitbox";
            this.Hitbox.Size = new System.Drawing.Size(130, 130);
            this.Hitbox.TabIndex = 1;
            this.Hitbox.TabStop = false;
            this.Hitbox.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::yyy.Properties.Resources.Plansza3;
            this.pictureBox1.InitialImage = global::yyy.Properties.Resources.Plansza2;
            this.pictureBox1.Location = new System.Drawing.Point(-21, 80);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(2000, 852);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_2);
            // 
            // Kanwa
            // 
            this.Kanwa.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Kanwa.Location = new System.Drawing.Point(12, 97);
            this.Kanwa.Name = "Kanwa";
            this.Kanwa.Size = new System.Drawing.Size(1269, 120);
            this.Kanwa.TabIndex = 0;
            this.Kanwa.TabStop = false;
            this.Kanwa.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Kanwa1
            // 
            this.Kanwa1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Kanwa1.Location = new System.Drawing.Point(12, 223);
            this.Kanwa1.Name = "Kanwa1";
            this.Kanwa1.Size = new System.Drawing.Size(1269, 120);
            this.Kanwa1.TabIndex = 6;
            this.Kanwa1.TabStop = false;
            this.Kanwa1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // Kanwa2
            // 
            this.Kanwa2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Kanwa2.Location = new System.Drawing.Point(12, 349);
            this.Kanwa2.Name = "Kanwa2";
            this.Kanwa2.Size = new System.Drawing.Size(1269, 120);
            this.Kanwa2.TabIndex = 7;
            this.Kanwa2.TabStop = false;
            this.Kanwa2.Click += new System.EventHandler(this.pictureBox2_Click_1);
            // 
            // Kanwa3
            // 
            this.Kanwa3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Kanwa3.Location = new System.Drawing.Point(12, 467);
            this.Kanwa3.Name = "Kanwa3";
            this.Kanwa3.Size = new System.Drawing.Size(1269, 120);
            this.Kanwa3.TabIndex = 8;
            this.Kanwa3.TabStop = false;
            this.Kanwa3.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(418, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(272, 37);
            this.label2.TabIndex = 18;
            this.label2.Text = "Witaj w Basshero!";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(562, 672);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(522, 22);
            this.label3.TabIndex = 19;
            this.label3.Text = "Sterowanie: 1- czerwona, 2-żółta, 3-niebieska, 4-pomarańczowa\r\n";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1266, 703);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Kanwa1);
            this.Controls.Add(this.Kanwa2);
            this.Controls.Add(this.Kanwa3);
            this.Controls.Add(this.Kanwa);
            this.Controls.Add(this.Hitbox);
            this.Controls.Add(this.Hitbox1);
            this.Controls.Add(this.Hitbox2);
            this.Controls.Add(this.Hitbox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "BassHero";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyisDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyp);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyUP);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hitbox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hitbox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hitbox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hitbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Kanwa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Kanwa1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Kanwa2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Kanwa3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Kanwa;
        private System.Windows.Forms.PictureBox Hitbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox Hitbox3;
        private System.Windows.Forms.PictureBox Kanwa3;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox Kanwa2;
        private System.Windows.Forms.PictureBox Hitbox2;
        private System.Windows.Forms.PictureBox Hitbox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox Kanwa1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

