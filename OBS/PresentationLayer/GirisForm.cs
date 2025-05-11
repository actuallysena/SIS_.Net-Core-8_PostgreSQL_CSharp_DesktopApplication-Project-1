using BusinessLogicLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Packaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
//using Npgsql;
//using DataLayer.Models;

namespace PresentationLayer
{
    public partial class GirisForm : Form
    {
        private readonly ILoginService _loginService;

        public GirisForm()
        {
            InitializeComponent();
            _loginService = Program.serviceProvider.GetRequiredService<ILoginService>();
        }

        private void girisbtn_Click(object sender, EventArgs e)
        {
            string girisIdTextValue = girisIdText.Text.Trim();
            string sifre = sifreText.Text.Trim();

            if (string.IsNullOrEmpty(girisIdTextValue) || string.IsNullOrEmpty(sifre))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Giriş ID'sini int'e çeviriyoruz
            if (!int.TryParse(girisIdTextValue, out int girisId))
            {
                MessageBox.Show("Giriş ID yalnızca sayı olmalıdır!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool girisBasarili = false;

            if (ogr_radioB.Checked)
            {
                girisBasarili = _loginService.OgrenciGirisi(girisId, sifre);
                if (girisBasarili)
                {
                    var form1 = new OgrenciForm();
                    form1.Show();
                    this.Hide();
                    return;
                }
            }
            //else if (aka_radioB.Checked)
            //{
            //    girisBasarili = _loginService.AkademisyenGirisi(girisId, sifre);
            //    if (girisBasarili)
            //    {
            //        var form2 = new AkademisyenForm();
            //        form2.Show();
            //        this.Hide();
            //        return;
            //    }
            //}
            //else if (per_radioB.Checked)
            //{
            //    girisBasarili = _loginService.PersonelGirisi(girisId, sifre);
            //    if (girisBasarili)
            //    {
            //        var form3 = new PersonelForm();
            //        form3.Show();
            //        this.Hide();
            //        return;
            //    }
            //}
            //else if (it_radioB.Checked)
            //{
            //    girisBasarili = _loginService.YoneticiGirisi(girisId, sifre);
            //    if (girisBasarili)
            //    {
            //        var form4 = new YoneticiForm();
            //        form4.Show();
            //        this.Hide();
            //        return;
            //    }
            //}

            // Eğer yukarıdaki hiçbir koşuldan dönülmediyse giriş başarısızdır
            MessageBox.Show("Giriş bilgileri hatalı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }




        //ESKİ KODUMUZ

        //private void girisbtn_Click(object sender, EventArgs e)
        //{
        //    string girisId = girisIdText.Text.Trim();
        //    string sifre = sifreText.Text.Trim();

        //    if (string.IsNullOrEmpty(girisId) || string.IsNullOrEmpty(sifre))
        //    {
        //        MessageBox.Show("Lütfen tüm alanları doldurun!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        return;
        //    }
        //    MessageBox.Show("Giriş başarılı! Hoş geldiniz.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    // Burada kullanıcıyı yönlendirme işlemi yapılabilir
        //    if (ogr_radioB.Checked)
        //    {
        //        // Öğrenci seçiliyse Form1'i aç
        //        var form1 = new OgrenciForm();
        //        form1.Show();
        //        this.Hide(); // Şu anki formu gizle
        //    }
        //    else if (aka_radioB.Checked)
        //    {
        //        // Akademisyen seçiliyse Form3'yi aç
        //        var form2 = new GirisForm();
        //        form2.Show();
        //        this.Hide(); // Şu anki formu gizle
        //    }
        //    else if (per_radioB.Checked)
        //    {
        //        // Personel seçiliyse Form4'yi aç
        //        var form2 = new GirisForm();
        //        form2.Show();
        //        this.Hide(); // Şu anki formu gizle
        //    }
        //    else if (it_radioB.Checked)
        //    {
        //        // Bilgi İşlem seçiliyse Form5'yi aç
        //        var form2 = new GirisForm();
        //        form2.Show();
        //        this.Hide(); // Şu anki formu gizle
        //    }
        //}




        ////Veritabanı ile alakalı olan kısım

        //private string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=123;Database=obs_db";
        //public Form2()
        //{
        //    InitializeComponent();
        //}
        //private void girisbtn_Click(object sender, EventArgs e)
        //{
        //    string kullaniciTuru = GetSelectedUserType();
        //    string girisId = girisIdText.Text.Trim();
        //    string sifre = sifreText.Text.Trim();

        //    if (string.IsNullOrEmpty(kullaniciTuru) || string.IsNullOrEmpty(girisId) || string.IsNullOrEmpty(sifre))
        //    {
        //        MessageBox.Show("Lütfen tüm alanları doldurun!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        return;
        //    }
        //    try
        //    {
        //        using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
        //        {
        //            connection.Open();
        //            // Sorgu: Kullanıcı türüne göre doğru tablodan kontrol
        //            string query = $"SELECT * FROM {kullaniciTuru} WHERE giris_id = @girisId AND sifre = @sifre";

        //            using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
        //            {
        //                command.Parameters.AddWithValue("@girisId", girisId);
        //                command.Parameters.AddWithValue("@sifre", sifre);

        //                using (NpgsqlDataReader reader = command.ExecuteReader())
        //                {
        //                    if (reader.Read())
        //                    {
        //                        MessageBox.Show("Giriş başarılı! Hoş geldiniz.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //                        // Burada kullanıcıyı yönlendirme işlemi yapılabilir
        //                        if (ogr_radioB.Checked)
        //                        {
        //                            // Öğrenci seçiliyse Form1'i aç
        //                            var form1 = new Form1();
        //                            form1.Show();
        //                            this.Hide(); // Şu anki formu gizle
        //                        }
        //                        else if (aka_radioB.Checked)
        //                        {
        //                            // Akademisyen seçiliyse Form3'yi aç
        //                            var form2 = new Form2();
        //                            form2.Show();
        //                            this.Hide(); // Şu anki formu gizle
        //                        }
        //                        else if (per_radioB.Checked)
        //                        {
        //                            // Personel seçiliyse Form4'yi aç
        //                            var form2 = new Form2();
        //                            form2.Show();
        //                            this.Hide(); // Şu anki formu gizle
        //                        }
        //                        else if (it_radioB.Checked)
        //                        {
        //                            // Bilgi İşlem seçiliyse Form5'yi aç
        //                            var form2 = new Form2();
        //                            form2.Show();
        //                            this.Hide(); // Şu anki formu gizle
        //                        }
        //                    }
        //                    else
        //                    {
        //                        MessageBox.Show("Giriş bilgileri hatalı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //                    }
        //                }
        //            }
        //        }
        //    }

        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        //// Seçili kullanıcı türünü döndürür
        //private string GetSelectedUserType()
        //{
        //    if (ogr_radioB.Checked) return "ogrenciler";
        //    if (aka_radioB.Checked) return "akademisyenler";
        //    if (per_radioB.Checked) return "personeller";
        //    if (it_radioB.Checked) return "bilgi_islem";
        //    return null;
        //}
    }
}

