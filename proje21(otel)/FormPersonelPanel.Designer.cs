namespace proje21_otel_
{
    partial class FormPersonelPanel
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnguncelle = new System.Windows.Forms.Button();
            this.rdkirli = new System.Windows.Forms.RadioButton();
            this.rdtemiz = new System.Windows.Forms.RadioButton();
            this.txtodaid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btncikis = new System.Windows.Forms.Button();
            this.btnkirli = new System.Windows.Forms.Button();
            this.btntemiz = new System.Windows.Forms.Button();
            this.btntalepler = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnguncelle);
            this.groupBox2.Controls.Add(this.rdkirli);
            this.groupBox2.Controls.Add(this.rdtemiz);
            this.groupBox2.Controls.Add(this.txtodaid);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(331, 162);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Temizlik Durumu";
            // 
            // btnguncelle
            // 
            this.btnguncelle.Location = new System.Drawing.Point(150, 102);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(139, 36);
            this.btnguncelle.TabIndex = 5;
            this.btnguncelle.Text = "Güncelle";
            this.btnguncelle.UseVisualStyleBackColor = true;
            this.btnguncelle.Click += new System.EventHandler(this.btnguncelle_Click);
            // 
            // rdkirli
            // 
            this.rdkirli.AutoSize = true;
            this.rdkirli.Location = new System.Drawing.Point(231, 69);
            this.rdkirli.Name = "rdkirli";
            this.rdkirli.Size = new System.Drawing.Size(58, 27);
            this.rdkirli.TabIndex = 4;
            this.rdkirli.TabStop = true;
            this.rdkirli.Text = "Kirli";
            this.rdkirli.UseVisualStyleBackColor = true;
            this.rdkirli.CheckedChanged += new System.EventHandler(this.rdkirli_CheckedChanged);
            // 
            // rdtemiz
            // 
            this.rdtemiz.AutoSize = true;
            this.rdtemiz.Location = new System.Drawing.Point(150, 69);
            this.rdtemiz.Name = "rdtemiz";
            this.rdtemiz.Size = new System.Drawing.Size(75, 27);
            this.rdtemiz.TabIndex = 3;
            this.rdtemiz.TabStop = true;
            this.rdtemiz.Text = "Temiz";
            this.rdtemiz.UseVisualStyleBackColor = true;
            this.rdtemiz.CheckedChanged += new System.EventHandler(this.rdtemiz_CheckedChanged);
            // 
            // txtodaid
            // 
            this.txtodaid.Location = new System.Drawing.Point(150, 32);
            this.txtodaid.Name = "txtodaid";
            this.txtodaid.Size = new System.Drawing.Size(139, 31);
            this.txtodaid.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Durum:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Oda ID:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btncikis);
            this.groupBox1.Controls.Add(this.btnkirli);
            this.groupBox1.Controls.Add(this.btntemiz);
            this.groupBox1.Controls.Add(this.btntalepler);
            this.groupBox1.Location = new System.Drawing.Point(349, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(331, 162);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hızlı İşlemler";
            // 
            // btncikis
            // 
            this.btncikis.Location = new System.Drawing.Point(170, 102);
            this.btncikis.Name = "btncikis";
            this.btncikis.Size = new System.Drawing.Size(130, 36);
            this.btncikis.TabIndex = 4;
            this.btncikis.Text = "Çıkış";
            this.btncikis.UseVisualStyleBackColor = true;
            this.btncikis.Click += new System.EventHandler(this.btncikis_Click);
            // 
            // btnkirli
            // 
            this.btnkirli.Location = new System.Drawing.Point(21, 102);
            this.btnkirli.Name = "btnkirli";
            this.btnkirli.Size = new System.Drawing.Size(130, 36);
            this.btnkirli.TabIndex = 3;
            this.btnkirli.Text = "Kirli Odalar";
            this.btnkirli.UseVisualStyleBackColor = true;
            this.btnkirli.Click += new System.EventHandler(this.btnkirli_Click);
            // 
            // btntemiz
            // 
            this.btntemiz.Location = new System.Drawing.Point(170, 50);
            this.btntemiz.Name = "btntemiz";
            this.btntemiz.Size = new System.Drawing.Size(130, 36);
            this.btntemiz.TabIndex = 2;
            this.btntemiz.Text = "Temiz Odalar";
            this.btntemiz.UseVisualStyleBackColor = true;
            this.btntemiz.Click += new System.EventHandler(this.btntemiz_Click);
            // 
            // btntalepler
            // 
            this.btntalepler.Location = new System.Drawing.Point(21, 50);
            this.btntalepler.Name = "btntalepler";
            this.btntalepler.Size = new System.Drawing.Size(130, 36);
            this.btntalepler.TabIndex = 1;
            this.btntalepler.Text = "Talepler";
            this.btntalepler.UseVisualStyleBackColor = true;
            this.btntalepler.Click += new System.EventHandler(this.btntalepler_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(13, 181);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(667, 183);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(661, 153);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "label3";
            this.label3.Visible = false;
            // 
            // FormPersonelPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(696, 380);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "FormPersonelPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPersonelPanel";
            this.Load += new System.EventHandler(this.FormPersonelPanel_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btntalepler;
        private System.Windows.Forms.Button btnguncelle;
        private System.Windows.Forms.RadioButton rdkirli;
        private System.Windows.Forms.RadioButton rdtemiz;
        private System.Windows.Forms.TextBox txtodaid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btncikis;
        private System.Windows.Forms.Button btnkirli;
        private System.Windows.Forms.Button btntemiz;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
    }
}