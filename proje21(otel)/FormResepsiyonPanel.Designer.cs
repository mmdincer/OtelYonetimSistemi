namespace proje21_otel_
{
    partial class FormResepsiyonPanel
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
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnsikayet = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btntemizle = new System.Windows.Forms.Button();
            this.btnguncelle = new System.Windows.Forms.Button();
            this.cmbdurum = new System.Windows.Forms.ComboBox();
            this.cmbtemizlik = new System.Windows.Forms.ComboBox();
            this.cmbtip = new System.Windows.Forms.ComboBox();
            this.btnkayit = new System.Windows.Forms.Button();
            this.txtno = new System.Windows.Forms.TextBox();
            this.txtmusisim = new System.Windows.Forms.TextBox();
            this.txtrezid = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btndolu = new System.Windows.Forms.Button();
            this.btnkirli = new System.Windows.Forms.Button();
            this.btnrez = new System.Windows.Forms.Button();
            this.btntemiz = new System.Windows.Forms.Button();
            this.btnbos = new System.Windows.Forms.Button();
            this.btntalep = new System.Windows.Forms.Button();
            this.txtodaid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.btnsikayet);
            this.groupBox2.Controls.Add(this.richTextBox1);
            this.groupBox2.Location = new System.Drawing.Point(14, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(284, 250);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Talep Girişi";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(7, 200);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 33);
            this.button1.TabIndex = 2;
            this.button1.Text = "Temizle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnsikayet
            // 
            this.btnsikayet.Location = new System.Drawing.Point(143, 200);
            this.btnsikayet.Name = "btnsikayet";
            this.btnsikayet.Size = new System.Drawing.Size(135, 33);
            this.btnsikayet.TabIndex = 1;
            this.btnsikayet.Text = "Talep Oluştur";
            this.btnsikayet.UseVisualStyleBackColor = true;
            this.btnsikayet.Click += new System.EventHandler(this.btnsikayet_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(7, 31);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(271, 163);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dataGridView1);
            this.groupBox5.Location = new System.Drawing.Point(13, 446);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(763, 229);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(757, 199);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txtodaid);
            this.groupBox6.Controls.Add(this.label1);
            this.groupBox6.Controls.Add(this.btntemizle);
            this.groupBox6.Controls.Add(this.btnguncelle);
            this.groupBox6.Controls.Add(this.cmbdurum);
            this.groupBox6.Controls.Add(this.cmbtemizlik);
            this.groupBox6.Controls.Add(this.cmbtip);
            this.groupBox6.Controls.Add(this.btnkayit);
            this.groupBox6.Controls.Add(this.txtno);
            this.groupBox6.Controls.Add(this.txtmusisim);
            this.groupBox6.Controls.Add(this.txtrezid);
            this.groupBox6.Controls.Add(this.label10);
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Controls.Add(this.label5);
            this.groupBox6.Location = new System.Drawing.Point(304, 13);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(472, 426);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Kayıt İşlemleri";
            // 
            // btntemizle
            // 
            this.btntemizle.Location = new System.Drawing.Point(122, 358);
            this.btntemizle.Name = "btntemizle";
            this.btntemizle.Size = new System.Drawing.Size(124, 31);
            this.btntemizle.TabIndex = 3;
            this.btntemizle.Text = "Temizle";
            this.btntemizle.UseVisualStyleBackColor = true;
            this.btntemizle.Click += new System.EventHandler(this.btntemizle_Click);
            // 
            // btnguncelle
            // 
            this.btnguncelle.Location = new System.Drawing.Point(252, 358);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(124, 31);
            this.btnguncelle.TabIndex = 16;
            this.btnguncelle.Text = "Güncelle";
            this.btnguncelle.UseVisualStyleBackColor = true;
            this.btnguncelle.Click += new System.EventHandler(this.btnguncelle_Click);
            // 
            // cmbdurum
            // 
            this.cmbdurum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbdurum.FormattingEnabled = true;
            this.cmbdurum.Location = new System.Drawing.Point(187, 284);
            this.cmbdurum.Name = "cmbdurum";
            this.cmbdurum.Size = new System.Drawing.Size(189, 31);
            this.cmbdurum.TabIndex = 15;
            // 
            // cmbtemizlik
            // 
            this.cmbtemizlik.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbtemizlik.FormattingEnabled = true;
            this.cmbtemizlik.Location = new System.Drawing.Point(187, 247);
            this.cmbtemizlik.Name = "cmbtemizlik";
            this.cmbtemizlik.Size = new System.Drawing.Size(189, 31);
            this.cmbtemizlik.TabIndex = 14;
            // 
            // cmbtip
            // 
            this.cmbtip.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbtip.FormattingEnabled = true;
            this.cmbtip.Location = new System.Drawing.Point(187, 207);
            this.cmbtip.Name = "cmbtip";
            this.cmbtip.Size = new System.Drawing.Size(189, 31);
            this.cmbtip.TabIndex = 13;
            // 
            // btnkayit
            // 
            this.btnkayit.Location = new System.Drawing.Point(251, 321);
            this.btnkayit.Name = "btnkayit";
            this.btnkayit.Size = new System.Drawing.Size(124, 31);
            this.btnkayit.TabIndex = 12;
            this.btnkayit.Text = "Kayıt Oluştur";
            this.btnkayit.UseVisualStyleBackColor = true;
            this.btnkayit.Click += new System.EventHandler(this.btnkayit_Click);
            // 
            // txtno
            // 
            this.txtno.Location = new System.Drawing.Point(187, 170);
            this.txtno.Name = "txtno";
            this.txtno.Size = new System.Drawing.Size(189, 31);
            this.txtno.TabIndex = 9;
            // 
            // txtmusisim
            // 
            this.txtmusisim.Location = new System.Drawing.Point(187, 96);
            this.txtmusisim.Name = "txtmusisim";
            this.txtmusisim.Size = new System.Drawing.Size(189, 31);
            this.txtmusisim.TabIndex = 7;
            // 
            // txtrezid
            // 
            this.txtrezid.Location = new System.Drawing.Point(187, 59);
            this.txtrezid.Name = "txtrezid";
            this.txtrezid.Size = new System.Drawing.Size(189, 31);
            this.txtrezid.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(55, 250);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(115, 23);
            this.label10.TabIndex = 5;
            this.label10.Text = "Oda Temizlik:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(63, 287);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 23);
            this.label9.TabIndex = 4;
            this.label9.Text = "Oda Durum:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(95, 173);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 23);
            this.label8.TabIndex = 3;
            this.label8.Text = "Oda No:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(87, 210);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 23);
            this.label7.TabIndex = 2;
            this.label7.Text = "Oda Tipi:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(55, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 23);
            this.label6.TabIndex = 1;
            this.label6.Text = "Müşteri İsim:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "Rezervasyon ID:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btndolu);
            this.groupBox1.Controls.Add(this.btnkirli);
            this.groupBox1.Controls.Add(this.btnrez);
            this.groupBox1.Controls.Add(this.btntemiz);
            this.groupBox1.Controls.Add(this.btnbos);
            this.groupBox1.Controls.Add(this.btntalep);
            this.groupBox1.Location = new System.Drawing.Point(13, 269);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(284, 170);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hızlı İşlemler";
            // 
            // btndolu
            // 
            this.btndolu.Location = new System.Drawing.Point(144, 118);
            this.btndolu.Name = "btndolu";
            this.btndolu.Size = new System.Drawing.Size(130, 36);
            this.btndolu.TabIndex = 5;
            this.btndolu.Text = "Dolu Odalar";
            this.btndolu.UseVisualStyleBackColor = true;
            this.btndolu.Click += new System.EventHandler(this.btndolu_Click);
            // 
            // btnkirli
            // 
            this.btnkirli.Location = new System.Drawing.Point(144, 76);
            this.btnkirli.Name = "btnkirli";
            this.btnkirli.Size = new System.Drawing.Size(130, 36);
            this.btnkirli.TabIndex = 4;
            this.btnkirli.Text = "Kirli Odalar";
            this.btnkirli.UseVisualStyleBackColor = true;
            this.btnkirli.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // btnrez
            // 
            this.btnrez.Location = new System.Drawing.Point(144, 32);
            this.btnrez.Name = "btnrez";
            this.btnrez.Size = new System.Drawing.Size(130, 36);
            this.btnrez.TabIndex = 3;
            this.btnrez.Text = "Rezervasyonlar";
            this.btnrez.UseVisualStyleBackColor = true;
            this.btnrez.Click += new System.EventHandler(this.btnlistele_Click);
            // 
            // btntemiz
            // 
            this.btntemiz.Location = new System.Drawing.Point(8, 76);
            this.btntemiz.Name = "btntemiz";
            this.btntemiz.Size = new System.Drawing.Size(130, 36);
            this.btntemiz.TabIndex = 2;
            this.btntemiz.Text = "Temiz Odalar";
            this.btntemiz.UseVisualStyleBackColor = true;
            this.btntemiz.Click += new System.EventHandler(this.btntemiz_Click);
            // 
            // btnbos
            // 
            this.btnbos.Location = new System.Drawing.Point(8, 118);
            this.btnbos.Name = "btnbos";
            this.btnbos.Size = new System.Drawing.Size(130, 36);
            this.btnbos.TabIndex = 1;
            this.btnbos.Text = "Boş Odalar";
            this.btnbos.UseVisualStyleBackColor = true;
            this.btnbos.Click += new System.EventHandler(this.btnbos_Click);
            // 
            // btntalep
            // 
            this.btntalep.Location = new System.Drawing.Point(8, 32);
            this.btntalep.Name = "btntalep";
            this.btntalep.Size = new System.Drawing.Size(130, 36);
            this.btntalep.TabIndex = 0;
            this.btntalep.Text = "Talepler";
            this.btntalep.UseVisualStyleBackColor = true;
            this.btntalep.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtodaid
            // 
            this.txtodaid.Location = new System.Drawing.Point(187, 133);
            this.txtodaid.Name = "txtodaid";
            this.txtodaid.Size = new System.Drawing.Size(189, 31);
            this.txtodaid.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 23);
            this.label1.TabIndex = 17;
            this.label1.Text = "Oda ID:";
            // 
            // FormResepsiyonPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(787, 687);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormResepsiyonPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormResepsiyonPanel";
            this.Load += new System.EventHandler(this.FormResepsiyonPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnsikayet;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btntalep;
        private System.Windows.Forms.Button btnkayit;
        private System.Windows.Forms.TextBox txtno;
        private System.Windows.Forms.TextBox txtmusisim;
        private System.Windows.Forms.TextBox txtrezid;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnrez;
        private System.Windows.Forms.Button btntemiz;
        private System.Windows.Forms.Button btnbos;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbtip;
        private System.Windows.Forms.ComboBox cmbdurum;
        private System.Windows.Forms.ComboBox cmbtemizlik;
        private System.Windows.Forms.Button btnguncelle;
        private System.Windows.Forms.Button btntemizle;
        private System.Windows.Forms.Button btndolu;
        private System.Windows.Forms.Button btnkirli;
        private System.Windows.Forms.TextBox txtodaid;
        private System.Windows.Forms.Label label1;
    }
}