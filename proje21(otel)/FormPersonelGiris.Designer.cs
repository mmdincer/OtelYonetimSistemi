﻿namespace proje21_otel_
{
    partial class FormPersonelGiris
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
            this.label3 = new System.Windows.Forms.Label();
            this.btngiris = new System.Windows.Forms.Button();
            this.txtsifre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(142, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 39);
            this.label3.TabIndex = 17;
            this.label3.Text = "Giriş Paneli";
            // 
            // btngiris
            // 
            this.btngiris.Location = new System.Drawing.Point(222, 246);
            this.btngiris.Name = "btngiris";
            this.btngiris.Size = new System.Drawing.Size(92, 33);
            this.btngiris.TabIndex = 16;
            this.btngiris.Text = "Giriş Yap";
            this.btngiris.UseVisualStyleBackColor = true;
            this.btngiris.Click += new System.EventHandler(this.btngiris_Click);
            // 
            // txtsifre
            // 
            this.txtsifre.Location = new System.Drawing.Point(179, 208);
            this.txtsifre.Name = "txtsifre";
            this.txtsifre.Size = new System.Drawing.Size(135, 31);
            this.txtsifre.TabIndex = 15;
            this.txtsifre.Text = "0303";
            this.txtsifre.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(123, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 23);
            this.label2.TabIndex = 14;
            this.label2.Text = "Şifre:";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(179, 161);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(135, 31);
            this.txtid.TabIndex = 13;
            this.txtid.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(140, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 23);
            this.label1.TabIndex = 12;
            this.label1.Text = "ID:";
            // 
            // FormPersonelGiris
            // 
            this.AcceptButton = this.btngiris;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(466, 397);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btngiris);
            this.Controls.Add(this.txtsifre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormPersonelGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPersonelGiris";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btngiris;
        private System.Windows.Forms.TextBox txtsifre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label1;
    }
}