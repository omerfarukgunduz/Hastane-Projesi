﻿
namespace Hastane_Projesi
{
    partial class FrmGirisler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGirisler));
            this.BtnHasta = new System.Windows.Forms.Button();
            this.BtnDoktor = new System.Windows.Forms.Button();
            this.BtnSekreter = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnHasta
            // 
            this.BtnHasta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnHasta.BackgroundImage")));
            this.BtnHasta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnHasta.Location = new System.Drawing.Point(53, 247);
            this.BtnHasta.Name = "BtnHasta";
            this.BtnHasta.Size = new System.Drawing.Size(228, 218);
            this.BtnHasta.TabIndex = 0;
            this.BtnHasta.UseVisualStyleBackColor = true;
            this.BtnHasta.Click += new System.EventHandler(this.BtnHasta_Click);
            // 
            // BtnDoktor
            // 
            this.BtnDoktor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnDoktor.BackgroundImage")));
            this.BtnDoktor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnDoktor.Location = new System.Drawing.Point(379, 247);
            this.BtnDoktor.Name = "BtnDoktor";
            this.BtnDoktor.Size = new System.Drawing.Size(228, 218);
            this.BtnDoktor.TabIndex = 1;
            this.BtnDoktor.UseVisualStyleBackColor = true;
            this.BtnDoktor.Click += new System.EventHandler(this.BtnDoktor_Click);
            // 
            // BtnSekreter
            // 
            this.BtnSekreter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnSekreter.BackgroundImage")));
            this.BtnSekreter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnSekreter.Location = new System.Drawing.Point(692, 247);
            this.BtnSekreter.Name = "BtnSekreter";
            this.BtnSekreter.Size = new System.Drawing.Size(228, 218);
            this.BtnSekreter.TabIndex = 2;
            this.BtnSekreter.UseVisualStyleBackColor = true;
            this.BtnSekreter.Click += new System.EventHandler(this.BtnSekreter_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(379, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(232, 229);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(296, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(387, 49);
            this.label1.TabIndex = 4;
            this.label1.Text = "GÜNDÜZ  HASTANESİ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Small", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(92, 469);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 49);
            this.label2.TabIndex = 5;
            this.label2.Text = "HASTA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Small", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(399, 469);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 49);
            this.label3.TabIndex = 6;
            this.label3.Text = "DOKTOR";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Small", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(705, 469);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 49);
            this.label4.TabIndex = 7;
            this.label4.Text = "SEKRETER";
            // 
            // FrmGirisler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(979, 528);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnSekreter);
            this.Controls.Add(this.BtnDoktor);
            this.Controls.Add(this.BtnHasta);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmGirisler";
            this.Text = "GÜNDÜZ HASTANESİ  GİRİŞ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnHasta;
        private System.Windows.Forms.Button BtnDoktor;
        private System.Windows.Forms.Button BtnSekreter;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

