using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace proje21_otel_
{
    public partial class FormPersonelPanel : Form
    {
        public FormPersonelPanel()
        {
            InitializeComponent();
        }
        DataSet1TableAdapters.tblodalarTableAdapter oda = new DataSet1TableAdapters.tblodalarTableAdapter();

        private void btncikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            txtodaid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            label3.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            if(label3.Text == "True")
            {
                rdtemiz.Checked = true;
                rdkirli.Checked = false;
            }
            else
            {
                rdtemiz.Checked = false;
                rdkirli.Checked = true;
            }
        }

        private void FormPersonelPanel_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = oda.OdaListe();
        }

        private void btntalepler_Click(object sender, EventArgs e)
        {
            FormTalepler frm = new FormTalepler();
            frm.Show();
        }

        private void btntemiz_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = oda.OdaTemizlik(true);
        }

        private void btnkirli_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = oda.OdaTemizlik(false);
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            oda.OdaTemizlikGuncelle(bool.Parse(label3.Text), int.Parse(txtodaid.Text));
        }

        private void rdkirli_CheckedChanged(object sender, EventArgs e)
        {
            if(rdkirli.Checked) 
            {
                label3.Text = "False";
            }
        }

        private void rdtemiz_CheckedChanged(object sender, EventArgs e)
        {
            if(rdtemiz.Checked) 
            {
                label3.Text = "True";
            }
        }
    }
}
