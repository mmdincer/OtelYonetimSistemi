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
    public partial class FormTalepler : Form
    {
        public FormTalepler()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        DataSet1TableAdapters.tbltaleplerTableAdapter ds = new DataSet1TableAdapters.tbltaleplerTableAdapter();

        private void FormTalepler_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.TalepListele();
        }
    }
}
