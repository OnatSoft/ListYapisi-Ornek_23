using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListYapisi_Test_Uygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {// String Türüyle List Yapısı

            listBox1.Items.Clear();
            List<string> insanlar = new List<string>();
            insanlar.Add("Mazhar");
            insanlar.Add("Hakan");
            insanlar.Add("Muhammet");
            insanlar.Add("İsmail");
            insanlar.Add("Kemal");
            insanlar.Add("Cengiz");
            insanlar.Add("Ömer");
            insanlar.Add("Lale");
            insanlar.Add("Melisa");
            insanlar.Add("Ümit");
            insanlar.Add("Umut");
            insanlar.Add("Fatih");
            insanlar.Add("Arda");
            insanlar.Add("Zehra");
            insanlar.Add("Samet");
            insanlar.Add("Elif");
            insanlar.Add("Jale");
            insanlar.Add("Deniz");
            insanlar.Add("Salih");
            insanlar.Add("Sinem");
            insanlar.Add("Tuğçe");
            insanlar.Add("Nazlı");
            insanlar.Add("Derya");

            //kisiler.Remove("Muhammet");

            foreach (string i in insanlar)
            {
                listBox1.Items.Add(i);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {// Aritmetik Türüyle List Yapısı
            
            listBox2.Items.Clear();
            List<int> sayilar = new List<int>();
            sayilar.Add(30);
            sayilar.Add(37);
            sayilar.Add(46);
            sayilar.Add(53);
            sayilar.Add(65);
            sayilar.Add(69);
            sayilar.Add(80);
            sayilar.Add(33);
            sayilar.Add(41);
            sayilar.Add(77);
            sayilar.Add(74);
            sayilar.Add(83);
            sayilar.Add(88);
            sayilar.Add(20);
            sayilar.Add(25);
            sayilar.Add(18);
            sayilar.Add(13);
            sayilar.Add(10);

            //sayilar.Remove(65);

            foreach(int s in sayilar)
            {
                listBox2.Items.Add(s);
            }

            if (textBox1.Text == "")
            {
                textBox1.Text = 0.ToString();
            }
            else
            {
                if (sayilar.Contains(int.Parse(textBox1.Text)))
                {
                    MessageBox.Show("Bu sayı listede vardır.", "Sayı Arama");
                }
                else
                {
                    MessageBox.Show("Bu sayı listede yoktur.", "Sayı Arama");
                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {// "Kisiler" Sınıfı ile List Yapısı
            
            listBox3.Items.Clear();
            List<Kisiler> kisi = new List<Kisiler>();
            
            kisi.Add(new Kisiler()
            {
                ADI = "Onat",
                SOYAD="SOMER",
                MESLEK="Yazılım Geliştirici"
            });
            kisi.Add(new Kisiler() { ADI = "Fatih", SOYAD = "AY", MESLEK = "Öğretmen" });

            kisi.Add(new Kisiler() { ADI = "Yağmur", SOYAD = "YILDIZ", MESLEK = "Ürün Sorumlusu" });

            kisi.Add(new Kisiler() { ADI = "Sıla", SOYAD = "FIRTINA", MESLEK = "Halkla İlişkiler Uzm." });

            kisi.Add(new Kisiler() { ADI = "Nazlı", SOYAD = "GÜNEŞ", MESLEK = "Muhasebeci" });

            kisi.Add(new Kisiler() { ADI = "Hasan", SOYAD = "DEMİRKAYA", MESLEK = "Satış Danışmanı" });

            kisi.Add(new Kisiler() { ADI = "Samet", SOYAD = "YILDIZ", MESLEK = "AR-GE Müdürü" });

            kisi.Add(new Kisiler() { ADI = "Tuğçe", SOYAD = "LALE", MESLEK = "İnsan Kaynakları" });

            kisi.Add(new Kisiler() { ADI = "Arda", SOYAD = "DEMİR", MESLEK = "Ürün Geliştirme" });

            kisi.Add(new Kisiler() { ADI = "Tuna", SOYAD = "TOPRAK", MESLEK = "Müdür Yardımcısı AR-GE" });

            kisi.Add(new Kisiler() { ADI = "Burak", SOYAD = "ÇINAR", MESLEK = "Müdür Yardımcısı Satış" });

            kisi.Add(new Kisiler() { ADI = "Cengiz", SOYAD = "ALLIOĞLU", MESLEK = "Öğretmen" });

            foreach (Kisiler k in kisi)
            {
                listBox3.Items.Add(k.ADI + " " + k.SOYAD + " - " + k.MESLEK);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {// Örnek Araba Listesi
            
            listBox4.Items.Clear();
            List<Arabalar> cars = new List<Arabalar>();
            cars.Add(new Arabalar() { MARKA = "Toyota", MODEL = "Hybrid Corolla", RENK = "Beyaz", YİL = 2014 });
            cars.Add(new Arabalar() { MARKA = "Toyota", MODEL = "C-HR", RENK = "Beyaz", YİL = 2020 });
            cars.Add(new Arabalar() { MARKA = "BMW", MODEL = "i5 xDrive", RENK = "Lacivert", YİL = 2020 });
            cars.Add(new Arabalar() { MARKA = "Tesla", MODEL = "Model 3", RENK = "Beyaz", YİL = 2022 });
            cars.Add(new Arabalar() { MARKA = "Tesla", MODEL = "Model X", RENK = "Beyaz", YİL = 2022 });
            cars.Add(new Arabalar() { MARKA = "Ford", MODEL = "Mustang Mach-E", RENK = "Siyah", YİL = 2021 });
            cars.Add(new Arabalar() { MARKA = "BMW", MODEL = "iX e-Tech", RENK = "Siyah", YİL = 2023 });
            cars.Add(new Arabalar() { MARKA = "BMW", MODEL = "The i7 xDrive", RENK = "Siyah", YİL = 2023 });
            cars.Add(new Arabalar() { MARKA = "Ford", MODEL = "Elektrikli Fiesta", RENK = "Gri", YİL = 2021 });
            cars.Add(new Arabalar() { MARKA = "Mercedes-Benz", MODEL = "EQE Sedan", RENK = "Gri", YİL = 2023 });
            cars.Add(new Arabalar() { MARKA = "Mercedes-Benz", MODEL = "S Serisi", RENK = "Gri", YİL =2022  });
            cars.Add(new Arabalar() { MARKA = "Chery", MODEL = "Omoda 5", RENK = "Siyah", YİL = 2023 });
            cars.Add(new Arabalar() { MARKA = "Chery", MODEL = "Tiggo 7 Pro", RENK = "Siyah", YİL = 2023 });
            cars.Add(new Arabalar() { MARKA = "TOGG", MODEL = "T10X", RENK = "Oltu Taşı", YİL = 2023 });

            foreach (Arabalar a in cars)
            {
                listBox4.Items.Add(a.MARKA + ", " + a.MODEL + ", " + a.RENK + ", " + a.YİL);
            }
        }
    }
}
