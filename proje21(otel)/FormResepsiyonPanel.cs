using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proje21_otel_
{
    public partial class FormResepsiyonPanel : Form
    {
        public FormResepsiyonPanel()
        {
            InitializeComponent();
        }
        DataSet1TableAdapters.tbltaleplerTableAdapter talep = new DataSet1TableAdapters.tbltaleplerTableAdapter();
        DataSet1TableAdapters.tblodalarTableAdapter oda = new DataSet1TableAdapters.tblodalarTableAdapter();
        DataSet1TableAdapters.tblrezervasyonTableAdapter rez = new DataSet1TableAdapters.tblrezervasyonTableAdapter();

        private void button2_Click(object sender, EventArgs e)
        {
            FormTalepler frm = new FormTalepler();
            frm.Show();
        }

        private void btnsikayet_Click(object sender, EventArgs e)
        {
            talep.TalepEkle(richTextBox1.Text);
            MessageBox.Show("Talebiniz oluşturuldu.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }

        private void FormResepsiyonPanel_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = oda.OdaListe();

            //combobox doldurma
            cmbtip.Items.Add("Küçük");
            cmbtip.Items.Add("Orta");
            cmbtip.Items.Add("Büyük");
            cmbdurum.Items.Add("True");
            cmbdurum.Items.Add("False");
            cmbtemizlik.Items.Add("True");
            cmbtemizlik.Items.Add("False");


        }

        private void btnbos_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = oda.OdaDurum(false);
        }

        private void btntemiz_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = oda.OdaTemizlik(true);
        }

        private void btnlistele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = rez.RezListele(true);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            txtrezid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtmusisim.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtodaid.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txtno.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            cmbtip.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            cmbtemizlik.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            cmbdurum.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();

        }

        private void btnkayit_Click(object sender, EventArgs e)
        {
            rez.RezEkle(txtmusisim.Text,int.Parse(txtodaid.Text),int.Parse(txtno.Text),bool.Parse(cmbdurum.Text),bool.Parse(cmbtemizlik.Text),cmbtip.Text);
            oda.OdaGuncelle(int.Parse(txtno.Text),cmbtip.Text,bool.Parse(cmbdurum.Text),bool.Parse(cmbtemizlik.Text),int.Parse(txtodaid.Text));
            MessageBox.Show("Rezervasyon oluşturuldu.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            txtrezid.Text = "";
            txtmusisim.Text = "";
            txtno.Text = "";
            cmbdurum.Text = "";
            cmbtemizlik.Text = "";
            cmbdurum.Text = "";
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            rez.RezGuncelle(txtmusisim.Text, int.Parse(txtodaid.Text), int.Parse(txtno.Text), bool.Parse(cmbdurum.Text), bool.Parse(cmbtemizlik.Text), cmbtip.Text,int.Parse(txtrezid.Text));
            oda.OdaGuncelle(int.Parse(txtno.Text), cmbtip.Text, bool.Parse(cmbdurum.Text), bool.Parse(cmbtemizlik.Text), int.Parse(txtodaid.Text));
            MessageBox.Show("Güncelleme başarılı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            dataGridView1.DataSource = oda.OdaTemizlik(false);

        }

        private void btndolu_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = oda.OdaDurum(true);

        }
    }
}
