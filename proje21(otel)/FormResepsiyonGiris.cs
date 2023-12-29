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
    public partial class FormResepsiyonGiris : Form
    {
        public FormResepsiyonGiris()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        
        private void btngiris_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select resid,ressifre from tblresepsiyon where resid=@p1 and ressifre=@p2",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",txtid.Text);
            komut.Parameters.AddWithValue("@p2",txtsifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read()) 
            { 
                FormResepsiyonPanel frm = new FormResepsiyonPanel();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("ID ve şifreniz hatalı!!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
