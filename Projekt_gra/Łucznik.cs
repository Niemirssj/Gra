using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_gra
{
    public class Łucznik : Postać
    {
      
       

        public Łucznik(string imię)
            : base(imię, 1, 0, 10, 15, 5, 100, 100, 10, 8)
        {
            SzansaNaUnik = 30;
        }

        public override void OtrzymajObrażenia(int obrażenia)
        {
            Random rng = new Random();
            if (rng.Next(100) < SzansaNaUnik)
            {
                Console.WriteLine($"{Imię} uniknął ataku!");
            }
            else
            {
                base.OtrzymajObrażenia(obrażenia);
            }
        }

        public override int ObrażeniaWRundzie
        {
            get
            {
                return ZadawaneObrażenia * (Zręczność / 2);
            }
        }

        public override void LevelUp()
        {
            Poziom++;
            Siła += 3;
            Zręczność += 5;
            Inteligencja += 2;
            MaksymalnaLiczbaPunktówŻycia += 15;
            AktualnaLiczbaPunktówŻycia = MaksymalnaLiczbaPunktówŻycia;
        }

        public override string ToString()
        {
            return base.ToString() + $", Szansa na unik: {SzansaNaUnik}%";
        }
    }

}
