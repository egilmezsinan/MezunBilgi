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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtKullaniciAdi_Click(object sender, EventArgs e)
        {
            txtKullaniciAdi.Clear();
            pBoxUser.BackgroundImage = Properties.Resources.user1;
            panel1.BackColor = Color.FromArgb(78, 184, 206);
            txtKullaniciAdi.ForeColor=Color.FromArgb(78, 184, 206);

            pBoxPassword.BackgroundImage = Properties.Resources.padlock;
            panel2.BackColor = Color.WhiteSmoke;
            txtSifre.ForeColor = Color.WhiteSmoke;


        }

        private void txtSifre_Click(object sender, EventArgs e)
        {
            txtSifre.Clear();
            txtSifre.PasswordChar = '*';
            pBoxPassword.BackgroundImage = Properties.Resources.padlock1;
            panel2.BackColor = Color.FromArgb(78, 184, 206);
            txtSifre.ForeColor = Color.FromArgb(78, 184, 206);

            pBoxUser.BackgroundImage = Properties.Resources.user;
            panel1.BackColor = Color.WhiteSmoke;
            txtKullaniciAdi.ForeColor = Color.WhiteSmoke;

        }

        private void Cikis_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            if(txtKullaniciAdi.Text=="" || txtKullaniciAdi.Text=="Kullanıcı Adı")
            {
                lblHataKullanici.Visible = true;
            }
            else if(txtSifre.Text=="" || txtSifre.Text=="Şifre")
            {
                lblHataSifre.Visible = true;
            }
            else
            {
                lblHataKullanici.Visible = false;
                lblHataSifre.Visible = false;

                cGirisKontrolu giris = new cGirisKontrolu();
                Boolean kontrol = giris.KullaniciDogrula(txtKullaniciAdi.Text, txtSifre.Text);
                if(kontrol==true)
                {
                    if(giris.KullaniciTuru==true)
                    {
                        OgretmenPanel ogretmenPanel = new OgretmenPanel();
                        ogretmenPanel.TC = giris.TC;
                        ogretmenPanel.Show();
                        this.Hide();
                    }
                    else if (giris.KullaniciTuru==false)
                    {
                        OgrenciPanel ogrenciPanel = new OgrenciPanel();
                        ogrenciPanel.Tc = txtKullaniciAdi.Text;
                        ogrenciPanel.Show();
                        this.Hide();                   
                    }
                }
                else
                {
                    lblHata.Visible = true;
                }
            }
        }
    }
}
