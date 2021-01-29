using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MezunBilgiSistemi
{
    public partial class OgrenciPanel : Form
    {
        public OgrenciPanel()
        {
            InitializeComponent();
         
        }

        private void lblCikis_Click(object sender, EventArgs e)
        {
            Close();
        }
        public int PlakaKod { get; set; }
        public string Sehir { get; set; }
        public String Tc { get; set; }
        cOgrenciPanel cOgrenciPanel = new cOgrenciPanel();
        private void OgrenciPanel_Load(object sender, EventArgs e)
        {
          
            cOgrenciPanel.KullaniciGetir(Tc);
            lblAd.Text = cOgrenciPanel.Ad;
            lblSoyad.Text = cOgrenciPanel.Soyad;

            txtMail.Text = cOgrenciPanel.Email;
            txtAlan.Text = cOgrenciPanel.Alan;
            txtFirma.Text = cOgrenciPanel.Sirket;
            txtPozisyon.Text = cOgrenciPanel.Pozisyon;
            txtSehir.Text = cOgrenciPanel.PlakaKod.ToString();
            txtTelefon.Text = cOgrenciPanel.Telefon.ToString();
         
        }

        private void txtFirma_Click(object sender, EventArgs e)
        {
            
            panel1.BackColor = Color.FromArgb(78, 184, 206);
            txtFirma.ForeColor = Color.FromArgb(78, 184, 206);
            lblFirma.ForeColor = Color.FromArgb(78, 184, 206);

            lblAlan.ForeColor = Color.WhiteSmoke;
            txtAlan.ForeColor = Color.WhiteSmoke;
            panel4.BackColor = Color.WhiteSmoke;

            lblSehir.ForeColor = Color.WhiteSmoke;
            txtSehir.ForeColor = Color.WhiteSmoke;
            panel3.BackColor = Color.WhiteSmoke;

            lblMail.ForeColor = Color.WhiteSmoke;
            txtMail.ForeColor = Color.WhiteSmoke;
            panel5.BackColor = Color.WhiteSmoke;

            lblPozisyon.ForeColor = Color.WhiteSmoke;
            txtPozisyon.ForeColor = Color.WhiteSmoke;
            panel2.BackColor = Color.WhiteSmoke;

            lblTelefon.ForeColor = Color.WhiteSmoke;
            txtTelefon.ForeColor = Color.WhiteSmoke;
            panel6.BackColor = Color.WhiteSmoke;
        }

        private void txtPozisyon_Click(object sender, EventArgs e)
        {
            panel2.BackColor = Color.FromArgb(78, 184, 206);
            txtPozisyon.ForeColor = Color.FromArgb(78, 184, 206);
            lblPozisyon.ForeColor = Color.FromArgb(78, 184, 206);

            lblAlan.ForeColor = Color.WhiteSmoke;
            txtAlan.ForeColor = Color.WhiteSmoke;
            panel4.BackColor = Color.WhiteSmoke;

            lblSehir.ForeColor = Color.WhiteSmoke;
            txtSehir.ForeColor = Color.WhiteSmoke;
            panel3.BackColor = Color.WhiteSmoke;

            lblMail.ForeColor = Color.WhiteSmoke;
            txtMail.ForeColor = Color.WhiteSmoke;
            panel5.BackColor = Color.WhiteSmoke;

            lblFirma.ForeColor = Color.WhiteSmoke;
            txtFirma.ForeColor = Color.WhiteSmoke;
            panel1.BackColor = Color.WhiteSmoke;

            lblTelefon.ForeColor = Color.WhiteSmoke;
            txtTelefon.ForeColor = Color.WhiteSmoke;
            panel6.BackColor = Color.WhiteSmoke;
        }

        private void txtSehir_Click(object sender, EventArgs e)
        {
            panel3.BackColor = Color.FromArgb(78, 184, 206);
            txtSehir.ForeColor = Color.FromArgb(78, 184, 206);
            lblSehir.ForeColor = Color.FromArgb(78, 184, 206);

            lblAlan.ForeColor = Color.WhiteSmoke;
            txtAlan.ForeColor = Color.WhiteSmoke;
            panel4.BackColor = Color.WhiteSmoke;

            lblFirma.ForeColor = Color.WhiteSmoke;
            txtFirma.ForeColor = Color.WhiteSmoke;
            panel1.BackColor = Color.WhiteSmoke;

            lblMail.ForeColor = Color.WhiteSmoke;
            txtMail.ForeColor = Color.WhiteSmoke;
            panel5.BackColor = Color.WhiteSmoke;

            lblPozisyon.ForeColor = Color.WhiteSmoke;
            txtPozisyon.ForeColor = Color.WhiteSmoke;
            panel2.BackColor = Color.WhiteSmoke;

            lblTelefon.ForeColor = Color.WhiteSmoke;
            txtTelefon.ForeColor = Color.WhiteSmoke;
            panel6.BackColor = Color.WhiteSmoke;
        }

        private void txtAlan_Click(object sender, EventArgs e)
        {
            panel4.BackColor = Color.FromArgb(78, 184, 206);
            txtAlan.ForeColor = Color.FromArgb(78, 184, 206);
            lblAlan.ForeColor = Color.FromArgb(78, 184, 206);

            lblFirma.ForeColor = Color.WhiteSmoke;
            txtFirma.ForeColor = Color.WhiteSmoke;
            panel1.BackColor = Color.WhiteSmoke;

            lblSehir.ForeColor = Color.WhiteSmoke;
            txtSehir.ForeColor = Color.WhiteSmoke;
            panel3.BackColor = Color.WhiteSmoke;

            lblMail.ForeColor = Color.WhiteSmoke;
            txtMail.ForeColor = Color.WhiteSmoke;
            panel5.BackColor = Color.WhiteSmoke;

            lblPozisyon.ForeColor = Color.WhiteSmoke;
            txtPozisyon.ForeColor = Color.WhiteSmoke;
            panel2.BackColor = Color.WhiteSmoke;

            lblTelefon.ForeColor = Color.WhiteSmoke;
            txtTelefon.ForeColor = Color.WhiteSmoke;
            panel6.BackColor = Color.WhiteSmoke;
        }

        private void txtMail_Click(object sender, EventArgs e)
        {
            panel5.BackColor = Color.FromArgb(78, 184, 206);
            txtMail.ForeColor = Color.FromArgb(78, 184, 206);
            lblMail.ForeColor = Color.FromArgb(78, 184, 206);

            lblAlan.ForeColor = Color.WhiteSmoke;
            txtAlan.ForeColor = Color.WhiteSmoke;
            panel4.BackColor = Color.WhiteSmoke;

            lblSehir.ForeColor = Color.WhiteSmoke;
            txtSehir.ForeColor = Color.WhiteSmoke;
            panel3.BackColor = Color.WhiteSmoke;

            lblFirma.ForeColor = Color.WhiteSmoke;
            txtFirma.ForeColor = Color.WhiteSmoke;
            panel1.BackColor = Color.WhiteSmoke;

            lblPozisyon.ForeColor = Color.WhiteSmoke;
            txtPozisyon.ForeColor = Color.WhiteSmoke;
            panel2.BackColor = Color.WhiteSmoke;

            lblTelefon.ForeColor = Color.WhiteSmoke;
            txtTelefon.ForeColor = Color.WhiteSmoke;
            panel6.BackColor = Color.WhiteSmoke;
        }

        private void txtTelefon_Click(object sender, EventArgs e)
        {
            panel6.BackColor = Color.FromArgb(78, 184, 206);
            txtTelefon.ForeColor = Color.FromArgb(78, 184, 206);
            lblTelefon.ForeColor = Color.FromArgb(78, 184, 206);

            lblAlan.ForeColor = Color.WhiteSmoke;
            txtAlan.ForeColor = Color.WhiteSmoke;
            panel4.BackColor = Color.WhiteSmoke;

            lblSehir.ForeColor = Color.WhiteSmoke;
            txtSehir.ForeColor = Color.WhiteSmoke;
            panel3.BackColor = Color.WhiteSmoke;

            lblMail.ForeColor = Color.WhiteSmoke;
            txtMail.ForeColor = Color.WhiteSmoke;
            panel5.BackColor = Color.WhiteSmoke;

            lblPozisyon.ForeColor = Color.WhiteSmoke;
            txtPozisyon.ForeColor = Color.WhiteSmoke;
            panel2.BackColor = Color.WhiteSmoke;

            lblFirma.ForeColor = Color.WhiteSmoke;
            txtFirma.ForeColor = Color.WhiteSmoke;
            panel1.BackColor = Color.WhiteSmoke;
        }

     
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (txtAlan.Text == "" || txtFirma.Text == "" || txtMail.Text == "" || txtSehir.Text == "")
            {
                lblHata.Visible = true;
            }
            else
            {
                lblHata.Visible = false;

                cOgrenciPanel.Sirket = txtFirma.Text;
                cOgrenciPanel.Pozisyon = txtPozisyon.Text;
                cOgrenciPanel.PlakaKod = Convert.ToInt32(txtSehir.Text);
                cOgrenciPanel.Alan = txtAlan.Text;
                cOgrenciPanel.Email = txtMail.Text;
               
                cOgrenciPanel.Telefon = Convert.ToInt64(txtTelefon.Text);
                cOgrenciPanel.KartGuncelle(Tc);
                MessageBox.Show("Başaryla güncellendi");
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }
    }
}
