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


 namespace MezunBilgiSistemi
{
    public partial class OgretmenPanel : Form
    {
        public OgretmenPanel()
        {
            InitializeComponent();
        }
        public string TC { get; set; }

        private void label1_Click(object sender, EventArgs e)
        {
            Close();
        }
  
        private void button1_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex==0)
            {
                AlanKayitGetir();
                
            }
            else if(comboBox1.SelectedIndex==1)
            {
                SehirKayitGetir();
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                SirketKayitGetir();
            }
            else
            {
                MessageBox.Show("Lütfen bilgileri seçiniz");
            }

        }
        cBaglanti baglanti = new cBaglanti();

        public void AlanKayitGetir()
        {
            string kayit = "select Ad,Soyad,MezuniyetYılı,Şehir,Sirket,Pozisyon,Email,Telefon from Mezun inner join Şehir on Mezun.PlakaKod = Şehir.PlakaKod where  Alan like '%' + @alan + '%'";
            SqlCommand komut = new SqlCommand(kayit, baglanti.Baglanti());
            komut.Parameters.AddWithValue("@alan", txtAra.Text);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Baglanti().Close();

        }


        public void SirketKayitGetir()
        {
            string kayit = "select Ad,Soyad,MezuniyetYılı,Şehir,Pozisyon,Alan,Email,Telefon from Mezun inner join Şehir on Mezun.PlakaKod = Şehir.PlakaKod where Sirket like '%' + @sirket + '%'";
            SqlCommand komut = new SqlCommand(kayit, baglanti.Baglanti());
            komut.Parameters.AddWithValue("@sirket", txtAra.Text);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Baglanti().Close();

        }

        public void SehirKayitGetir()
        {
            string kayit = "select Ad,Soyad,MezuniyetYılı,Sirket,Pozisyon,Alan,Email,Telefon from Mezun where PlakaKod = PlakaKod";
            SqlCommand komut = new SqlCommand(kayit, baglanti.Baglanti());
            //komut.Parameters.AddWithValue("@PlakaKod", txtAra.Text);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Baglanti().Close();

        }

        public void KayitGetir()
        {
            string kayit = "select Ad,Soyad,MezuniyetYılı,Şehir,Sirket,Pozisyon,Email,Telefon from Mezun inner join Şehir on Mezun.PlakaKod = Şehir.PlakaKod ";
            SqlCommand komut = new SqlCommand(kayit, baglanti.Baglanti());
           
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Baglanti().Close();

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void OgretmenPanel_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Alan");
            comboBox1.Items.Add("Şehir");
            comboBox1.Items.Add("Şirket");
            KayitGetir();
        }

        private void txtAra_Click(object sender, EventArgs e)
        {
            txtAra.Clear();
            txtAra.ForeColor = Color.FromArgb(78,184,206);
            panel1.BackColor = Color.FromArgb(78,184,206);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }
    }
}
