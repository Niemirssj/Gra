using System;
using Projekt_gra;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Gra
{
    public partial class Form1 : Form
    {
        KsiegaCzarow skills;


        int target = 0;
        int hpotion=3;
        Postać postac;
        int mpotion = 3;
        
        List<Wrok> Wrogi = new List<Wrok>();
        Wrok wrog1, wrog2, wrog3;
        
        public Form1()
        {
            InitializeComponent();

            panel2.Hide();
            panel3.Hide();
            string path = Path.Combine(Application.StartupPath, "Images", "Avram.png");
            pictureBox1.Image = Image.FromFile(path);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

            path = Path.Combine(Application.StartupPath, "Images", "shop.jpg");
            pictureBox8.Image = Image.FromFile(path);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;

            path = Path.Combine(Application.StartupPath, "Images", "Aleister.png");
            pictureBox2.Image = Image.FromFile(path);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;

            path = Path.Combine(Application.StartupPath, "Images", "Kid.png");
            pictureBox3.Image = Image.FromFile(path);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            postac = new Wojownik(textBox1.Text);
            string path = Path.Combine(Application.StartupPath, "Images", "Avram.png");
            pictureBox4.Image = Image.FromFile(path);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;

            skills = new KsiegaCzarow()
            {
                new Czar
                 {
                    Nazwa = "Atak Mieczem",
                    Typ = TypCzaru.Ofensywny,
                    KosztMany = 0,
                    Atrybut = Atrybut.Normalny,
                    Efekt = 50,
                    Klasa = Klasa.Wojownik
                },
                new Czar
                {
                    Nazwa = "Taran",
                    Typ = TypCzaru.Ofensywny,
                    KosztMany = 0,
                    Atrybut = Atrybut.Normalny,
                    Efekt = 40,
                    Klasa = Klasa.Wojownik
                },
                new Czar
                {
                    Nazwa = "Obrona Tarczy",
                    Typ = TypCzaru.Defensywny,
                    KosztMany = 0,
                    Atrybut = Atrybut.Normalny,
                    Efekt = 30, 
                    Klasa = Klasa.Wojownik
                },
                new Czar
                {
                    Nazwa = "Porażenie Elektryczne",
                    Typ = TypCzaru.Ofensywny,
                    KosztMany = 0,
                    Atrybut = Atrybut.Elektryczny,
                    Efekt = 60,
                    Klasa = Klasa.Wojownik
                },
                new Czar
                {
                    Nazwa = "Szał Bitewny",
                    Typ = TypCzaru.Ofensywny,
                    KosztMany = 0,
                    Atrybut = Atrybut.Ognisty,
                    Efekt = 80,
                    Klasa = Klasa.Wojownik
                }
            };
            postac.KsiegaCzarow = skills;


            przygotuj();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            postac = new Czarodziej(textBox1.Text);
            string path = Path.Combine(Application.StartupPath, "Images", "Aleister.png");
            pictureBox4.Image = Image.FromFile(path);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;

            skills = new KsiegaCzarow()
            {
                new Czar
                {
                    Nazwa = "Magiczny Pocisk",
                    Typ = TypCzaru.Ofensywny,
                    KosztMany = 0,
                    Atrybut = Atrybut.Normalny,
                    Efekt = 20,
                    Klasa = Klasa.Czarodziej
                },
                new Czar
                {
                    Nazwa = "Kula Ognia",
                    Typ = TypCzaru.Ofensywny,
                    KosztMany = 20,
                    Atrybut = Atrybut.Ognisty,
                    Efekt = 60,
                    Klasa = Klasa.Czarodziej
                },
                new Czar
                {
                    Nazwa = "Tarcza Energetyczna",
                    Typ = TypCzaru.Defensywny,
                    KosztMany = 15,
                    Atrybut = Atrybut.Normalny,
                    Efekt = 40, // Redukuje obrażenia o 40
                    Klasa = Klasa.Czarodziej
                },
                new Czar
                {
                    Nazwa = "Błyskawica",
                    Typ = TypCzaru.Ofensywny,
                    KosztMany = 25,
                    Atrybut = Atrybut.Elektryczny,
                    Efekt = 80,
                    Klasa = Klasa.Czarodziej
                },
                new Czar
                {
                    Nazwa = "Uzdrawiający Dotyk",
                    Typ = TypCzaru.Uzdrawiajacy,
                    KosztMany = 10,
                    Atrybut = Atrybut.Normalny,
                    Efekt = 50, // Przywraca 50 punktów życia
                    Klasa = Klasa.Czarodziej
                }
            };

            postac.KsiegaCzarow = skills;
            przygotuj();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            postac = new Łucznik(textBox1.Text);
            string path = Path.Combine(Application.StartupPath, "Images", "Kid.png");
            pictureBox4.Image = Image.FromFile(path);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;

            skills = new KsiegaCzarow()
            {
               
                // Zaklęcia dla Łucznika
                new Czar
                {
                    Nazwa = "Strzał z Łuku",
                    Typ = TypCzaru.Ofensywny,
                    KosztMany = 0,
                    Atrybut = Atrybut.Normalny,
                    Efekt = 30,
                    Klasa = Klasa.Łucznik
                },
                new Czar
                {
                    Nazwa = "Strzał Zatrutą Strzałą",
                    Typ = TypCzaru.Ofensywny,
                    KosztMany = 0,
                    Atrybut = Atrybut.Normalny,
                    Efekt = 40, // + efekt zatrucia
                    Klasa = Klasa.Łucznik
                },
                new Czar
                {
                    Nazwa = "Szybki Unik",
                    Typ = TypCzaru.Defensywny,
                    KosztMany = 0,
                    Atrybut = Atrybut.Normalny,
                    Efekt = 20, // Zwiększa szansę na unik
                    Klasa = Klasa.Łucznik
                },
                new Czar
                {
                    Nazwa = "Ognista Strzała",
                    Typ = TypCzaru.Ofensywny,
                    KosztMany = 0,
                    Atrybut = Atrybut.Ognisty,
                    Efekt = 50,
                    Klasa = Klasa.Łucznik
                },
                new Czar
                {
                    Nazwa = "Tropienie",
                    Typ = TypCzaru.Defensywny,
                    KosztMany = 0,
                    Atrybut = Atrybut.Normalny,
                    Efekt = 30, // Zwiększa szanse na znalezienie wroga
                    Klasa = Klasa.Łucznik
                }
            
        };

            postac.KsiegaCzarow = skills;


            przygotuj();
        }


        void przygotuj()
        {
            label5.Text = textBox1.Text;
            foreach (var czar in skills)
            {
                comboBox1.Items.Add(czar.Nazwa);
            }

            progressBar1.Minimum = 0;
            progressBar1.Maximum = postac.MaksymalnaLiczbaPunktówŻycia;
            progressBar1.Value = postac.AktualnaLiczbaPunktówŻycia;

            {
                progressBar2.Minimum = 0;
                progressBar2.Maximum = postac.MaksymalnaLiczbaPunktówMany;
                progressBar2.Value = postac.AktualnaLiczbaPunktówMany;
            }

            przygotuj2();
            
        }

        void przygotuj2()
        {
            losuj();
            panel1.Hide();
            panel2.Show();
            graj();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string selectedCzarNazwa = comboBox1.SelectedItem?.ToString();
            if (!string.IsNullOrEmpty(selectedCzarNazwa))
            {
                Czar wybranyCzar = skills.FirstOrDefault(czar => czar.Nazwa == selectedCzarNazwa);
                if (wybranyCzar != null)
                {
                    TypCzaru typCzaru = wybranyCzar.Typ;
                    Atrybut atrybut = wybranyCzar.Atrybut;
                    int kosztMany = wybranyCzar.KosztMany;
                    int efekt = wybranyCzar.Efekt;

                    try
                    {
                        if (postac.AktualnaLiczbaPunktówMany < kosztMany)
                        {
                            throw new ManaException("Niewystarczająca ilość many.");
                        }

                        if (typCzaru == TypCzaru.Uzdrawiajacy)
                        {
                            postac.AktualnaLiczbaPunktówŻycia += efekt;
                            if (postac.AktualnaLiczbaPunktówŻycia > postac.MaksymalnaLiczbaPunktówŻycia)
                            {
                                postac.AktualnaLiczbaPunktówŻycia = postac.MaksymalnaLiczbaPunktówŻycia;
                            }
                        }
                        else if (typCzaru == TypCzaru.Defensywny)
                        {
                            postac.ZałóżPancerz(efekt);
                        }
                        else
                        {
                            Wrogi[target].OtrzymajObrażenia(efekt + postac.ZadawaneObrażenia, atrybut);
                            
                        }

                        postac.AktualnaLiczbaPunktówMany -= kosztMany;
                    }
                    catch (ManaException ex)
                    {
                        MessageBox.Show(ex.Message, "Błąd many", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            if (wrog1.CzyNieŻyje && wrog2.CzyNieŻyje && wrog3.CzyNieŻyje)
            {
                panel2.Hide();
                panel3.Show();
                int zloto= wrog1.Zloto + wrog2.Zloto + wrog3.Zloto;
                postac.Zloto += zloto;
                label4.Text = $"Posiadane złoto: {postac.Zloto}";
            }
            else
            {
                atakprze();
            }
        }


        void atakprze()
        {
            foreach(var r in Wrogi)
            {
                r.Atak();
                
            }
            aktualizuj();
            if (postac.CzyNieŻyje)
            {
                {
                    MessageBox.Show("Nie żyjesz", "Komunikat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    comboBox1.Items.Clear();
                    mpotion=3;
                   
                    
                    button14.Enabled = true;
                    button14.Text = $"Mana potion: {mpotion}";

                    hpotion = 3;


                    button13.Enabled = true;
                    button13.Text = $"Heal potion: {mpotion}";

                }
                panel2.Hide();
                panel3.Hide();
                panel1.Show();
            }
        }




        void graj()
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            target = 0;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            target = 1;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            target = 2;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            try
            {
                postac.ZałóżPancerz(20);
                postac.OdejmijZloto(50);
                label4.Text = $"Posiadane zloto: {postac.Zloto}";
            }
            catch (ZlotoException ex)
            {
                MessageBox.Show(ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            try
            {
                postac.Uzbrój(20);
                postac.OdejmijZloto(70);
                label4.Text = $"Posiadane zloto: {postac.Zloto}";
            }
            catch (ZlotoException ex)
            {
                MessageBox.Show(ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                postac.MaksymalnaLiczbaPunktówŻycia+=20;
                postac.OdejmijZloto(100);
                label4.Text = $"Posiadane zloto: {postac.Zloto}";
            }
            catch (ZlotoException ex)
            {
                MessageBox.Show(ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                postac.MaksymalnaLiczbaPunktówMany += 20; ;
                postac.OdejmijZloto(100);
                label4.Text = $"Posiadane zloto: {postac.Zloto}";
            }
            catch (ZlotoException ex)
            {
                MessageBox.Show(ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                hpotion++;
                postac.OdejmijZloto(30);
                label4.Text = $"Posiadane zloto: {postac.Zloto}";
                button13.Enabled = true;
                button13.Text = $"Heal potion {mpotion}";
            }
            catch (ZlotoException ex)
            {
                MessageBox.Show(ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            panel3.Hide();
            przygotuj2();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                mpotion++;
                postac.OdejmijZloto(30);
                label4.Text = $"Posiadane zloto: {postac.Zloto}";
                button14.Enabled = true;
                button14.Text = $"Mana potion {mpotion}";
            }
            catch (ZlotoException ex)
            {
                MessageBox.Show(ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string selectedCzarNazwa = comboBox1.SelectedItem?.ToString();
            if (!string.IsNullOrEmpty(selectedCzarNazwa))
            {
                Czar wybranyCzar = skills.FirstOrDefault(czar => czar.Nazwa == selectedCzarNazwa);
                if (wybranyCzar != null)
                {
                    TypCzaru typCzaru = wybranyCzar.Typ;
                    Atrybut atrybut = wybranyCzar.Atrybut;
                    int kosztMany = wybranyCzar.KosztMany;
                    int efekt = wybranyCzar.Efekt;

                    // Wyświetlanie szczegółów czaru w MessageBox
                    MessageBox.Show($"Nazwa: {wybranyCzar.Nazwa}\n" +
                                    $"Typ: {typCzaru}\n" +
                                    $"Atrybut: {atrybut}\n" +
                                    $"Koszt Many: {kosztMany}\n" +
                                    $"Efekt: {efekt}",
                                    "Szczegóły Czaru",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
            }


         }

        private void button13_Click(object sender, EventArgs e)
        {
            postac.AktualnaLiczbaPunktówŻycia += 20;
            if(postac.AktualnaLiczbaPunktówŻycia>postac.MaksymalnaLiczbaPunktówŻycia)
            {
                postac.AktualnaLiczbaPunktówŻycia = postac.MaksymalnaLiczbaPunktówŻycia;
            }

            hpotion--;
            button13.Text = $"Heal potion {hpotion}";
            if (hpotion == 0)
            {
                button13.Enabled = false;
            }

            atakprze();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            postac.AktualnaLiczbaPunktówMany += 20;
            if (postac.AktualnaLiczbaPunktówMany > postac.MaksymalnaLiczbaPunktówMany)
            {
                postac.AktualnaLiczbaPunktówMany= postac.MaksymalnaLiczbaPunktówMany;
            }

            mpotion--;
            button14.Text = $"mana potion {mpotion}";
            if (hpotion == 0)
            {
                button14.Enabled = false;
            }
            atakprze();
        }

        void aktualizuj()
        {
            progressBar1.Value = postac.AktualnaLiczbaPunktówŻycia;
            progressBar2.Value = postac.AktualnaLiczbaPunktówMany;
            progressBar3.Value = Wrogi[0].AktualnaLiczbaPunktówŻycia;
            
            progressBar4.Value = Wrogi[1].AktualnaLiczbaPunktówŻycia;
            
            progressBar5.Value = Wrogi[2].AktualnaLiczbaPunktówŻycia;
        }




        void losuj()
        {
            Random random = new Random();
            int wynik = random.Next(0, 101);
            if (wynik <= 40)
            {
                wrog1 = new Goblin();
                string path = Path.Combine(Application.StartupPath, "Images", "goblin.png");
                pictureBox5.Image = Image.FromFile(path);
                pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;

            }
            else if (wynik <= 90)
            {
                wrog1 = new Lis();
                string path = Path.Combine(Application.StartupPath, "Images", "fox.png");
                pictureBox5.Image = Image.FromFile(path);
                pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else
            {
                wrog1 = new Smok();
                string path = Path.Combine(Application.StartupPath, "Images", "Vahram.png");
                pictureBox5.Image = Image.FromFile(path);
                pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            }

            wynik = random.Next(0, 101);
            if (wynik <= 40)
            {
                wrog2 = new Goblin();
                string path = Path.Combine(Application.StartupPath, "Images", "goblin.png");
                pictureBox6.Image = Image.FromFile(path);
                pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;

            }
            else if (wynik <= 90)
            {
                wrog2 = new Lis();
                string path = Path.Combine(Application.StartupPath, "Images", "fox.png");
                pictureBox6.Image = Image.FromFile(path);
                pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else
            {
                wrog2 = new Smok();
                string path = Path.Combine(Application.StartupPath, "Images", "Vahram.png");
                pictureBox6.Image = Image.FromFile(path);
                pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            }

            wynik = random.Next(0, 101);
            if (wynik <= 40)
            {
                wrog3 = new Goblin();
                string path = Path.Combine(Application.StartupPath, "Images", "goblin.png");
                pictureBox7.Image = Image.FromFile(path);
                pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;

            }
            else if (wynik <= 90)
            {
                wrog3 = new Lis();
                string path = Path.Combine(Application.StartupPath, "Images", "fox.png");
                pictureBox7.Image = Image.FromFile(path);
                pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else
            {
                wrog3 = new Smok();
                string path = Path.Combine(Application.StartupPath, "Images", "Vahram.png");
                pictureBox7.Image = Image.FromFile(path);
                pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            }

            progressBar3.Minimum = 0;
            progressBar3.Maximum = wrog1.MaksymalnaLiczbaPunktówŻycia;
            progressBar3.Value = wrog1.AktualnaLiczbaPunktówŻycia;
            progressBar4.Minimum = 0;
            progressBar4.Maximum = wrog2.MaksymalnaLiczbaPunktówŻycia;
            progressBar4.Value = wrog2.AktualnaLiczbaPunktówŻycia;
            progressBar5.Minimum = 0;
            progressBar5.Maximum = wrog3.MaksymalnaLiczbaPunktówŻycia;
            progressBar5.Value = wrog3.AktualnaLiczbaPunktówŻycia;

            button13.Text = $"Heal potion {hpotion}";
            button14.Text = $"Mana potion {mpotion}";
            if (Wrogi.Count != 0)
            {
                Wrogi.RemoveAt(2);
                Wrogi.RemoveAt(1);
                Wrogi.RemoveAt(0);
            }
            
            Wrogi.Add(wrog1);
            Wrogi.Add(wrog2);
            Wrogi.Add(wrog3);

            foreach(var r in Wrogi)
            {
                r.atak += moc =>
                {
                    postac.OtrzymajObrażenia(moc);
                    
                };
            }

        }
    }
}
