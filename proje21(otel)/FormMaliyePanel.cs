using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace proje21_otel_
{
    public partial class FormMaliyePanel : Form
    {
        public FormMaliyePanel()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        DataSet1TableAdapters.tblrezervasyonTableAdapter rez = new DataSet1TableAdapters.tblrezervasyonTableAdapter();

        private void FormMaliyePanel_Load(object sender, EventArgs e)
        {
            //listeleme
            dataGridView1.DataSource = rez.RezListele(true);

            //cmbox doldurma
            comboBox1.Items.Add("Küçük");
            comboBox1.Items.Add("Orta");
            comboBox1.Items.Add("Büyük");

            
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            txtid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtodaid.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txtno.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            if (comboBox1.Text == "Küçük")
                txtfiyat.Text = 1000.ToString();
            else if(comboBox1.Text =="Orta")
                txtfiyat.Text = 2000.ToString();
            else
                txtfiyat.Text =3000.ToString();

        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into tblgelirler (rezgelir) values (@p1)", bgl.baglanti());
            cmd.Parameters.AddWithValue("@p1", int.Parse(txtfiyat.Text));
            cmd.ExecuteNonQuery();

            SqlCommand komut = new SqlCommand("select sum(rezgelir) from tblgelirler", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                richTextBox1.Text = "Gelir: " + dr[0] + Environment.NewLine;
            }
            bgl.baglanti().Close();

            SqlCommand komut1 = new SqlCommand("select count(*) from tblgelirler", bgl.baglanti());
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                richTextBox1.Text += "Hesaplanan Oda Sayısı: " + dr1[0] + Environment.NewLine;
            }
            bgl.baglanti().Close();
            dr.Close();
            dr1.Close();
        }


        private void btngoster_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select sum(rezgelir) from tblgelir", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                richTextBox1.Text = "Gelir: " + dr[0] + Environment.NewLine;
            }
            bgl.baglanti().Close();

            SqlCommand komut1 = new SqlCommand("select count(rezgelir) from tblgelir", bgl.baglanti());
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                richTextBox1.Text += "Hesaplanan Oda Sayısı: " + dr1[0] + Environment.NewLine;
            }
            bgl.baglanti().Close();
        }
    }
}
