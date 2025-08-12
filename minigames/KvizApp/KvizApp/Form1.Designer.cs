
namespace KvizApp
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
            this.dugme1 = new System.Windows.Forms.Button();
            this.labelPitanje = new System.Windows.Forms.Label();
            this.dugme2 = new System.Windows.Forms.Button();
            this.dugme3 = new System.Windows.Forms.Button();
            this.dugme4 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelPozadinaSlike = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dugme1
            // 
            this.dugme1.BackColor = System.Drawing.Color.White;
            this.dugme1.FlatAppearance.BorderSize = 0;
            this.dugme1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dugme1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dugme1.Location = new System.Drawing.Point(46, 374);
            this.dugme1.Name = "dugme1";
            this.dugme1.Size = new System.Drawing.Size(411, 56);
            this.dugme1.TabIndex = 0;
            this.dugme1.Tag = "1";
            this.dugme1.Text = "button1";
            this.dugme1.UseVisualStyleBackColor = false;
            this.dugme1.Click += new System.EventHandler(this.ProvjeriOdgovorKlikAsync);
            // 
            // labelPitanje
            // 
            this.labelPitanje.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPitanje.Location = new System.Drawing.Point(41, 321);
            this.labelPitanje.Name = "labelPitanje";
            this.labelPitanje.Size = new System.Drawing.Size(840, 36);
            this.labelPitanje.TabIndex = 4;
            this.labelPitanje.Text = "Pitanje";
            this.labelPitanje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dugme2
            // 
            this.dugme2.BackColor = System.Drawing.Color.White;
            this.dugme2.FlatAppearance.BorderSize = 0;
            this.dugme2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dugme2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dugme2.Location = new System.Drawing.Point(463, 374);
            this.dugme2.Name = "dugme2";
            this.dugme2.Size = new System.Drawing.Size(411, 56);
            this.dugme2.TabIndex = 5;
            this.dugme2.Tag = "2";
            this.dugme2.Text = "button2";
            this.dugme2.UseVisualStyleBackColor = false;
            this.dugme2.Click += new System.EventHandler(this.ProvjeriOdgovorKlikAsync);
            // 
            // dugme3
            // 
            this.dugme3.BackColor = System.Drawing.Color.White;
            this.dugme3.FlatAppearance.BorderSize = 0;
            this.dugme3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dugme3.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dugme3.Location = new System.Drawing.Point(46, 436);
            this.dugme3.Name = "dugme3";
            this.dugme3.Size = new System.Drawing.Size(411, 56);
            this.dugme3.TabIndex = 6;
            this.dugme3.Tag = "3";
            this.dugme3.Text = "button3";
            this.dugme3.UseVisualStyleBackColor = false;
            this.dugme3.Click += new System.EventHandler(this.ProvjeriOdgovorKlikAsync);
            // 
            // dugme4
            // 
            this.dugme4.BackColor = System.Drawing.Color.White;
            this.dugme4.FlatAppearance.BorderSize = 0;
            this.dugme4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dugme4.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dugme4.Location = new System.Drawing.Point(463, 436);
            this.dugme4.Name = "dugme4";
            this.dugme4.Size = new System.Drawing.Size(411, 56);
            this.dugme4.TabIndex = 7;
            this.dugme4.Tag = "4";
            this.dugme4.Text = "button4";
            this.dugme4.UseVisualStyleBackColor = false;
            this.dugme4.Click += new System.EventHandler(this.ProvjeriOdgovorKlikAsync);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::KvizApp.Properties.Resources.messi;
            this.pictureBox1.Location = new System.Drawing.Point(230, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(454, 275);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // labelPozadinaSlike
            // 
            this.labelPozadinaSlike.BackColor = System.Drawing.Color.White;
            this.labelPozadinaSlike.Location = new System.Drawing.Point(0, 0);
            this.labelPozadinaSlike.Margin = new System.Windows.Forms.Padding(0);
            this.labelPozadinaSlike.Name = "labelPozadinaSlike";
            this.labelPozadinaSlike.Size = new System.Drawing.Size(924, 312);
            this.labelPozadinaSlike.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 526);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dugme4);
            this.Controls.Add(this.dugme3);
            this.Controls.Add(this.dugme2);
            this.Controls.Add(this.labelPitanje);
            this.Controls.Add(this.dugme1);
            this.Controls.Add(this.labelPozadinaSlike);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Kviz";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button dugme1;
        private System.Windows.Forms.Label labelPitanje;
        private System.Windows.Forms.Button dugme2;
        private System.Windows.Forms.Button dugme3;
        private System.Windows.Forms.Button dugme4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelPozadinaSlike;
    }
}

