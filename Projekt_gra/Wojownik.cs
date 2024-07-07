using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_gra
{
    public class Wojownik : Postać
    {
       
      

        public Wojownik(string imię)
            : base(imię, 1, 0, 15, 10, 5, 120, 120, 15, 10)
        {
            LiczbaAtakówNaRundę = 2;
        }

        public override int ObrażeniaWRundzie
        {
            get
            {
                return ZadawaneObrażenia * LiczbaAtakówNaRundę*(Siła/2);
            }
        }

        public override void LevelUp()
        {
            Poziom++;
            Siła += 5;
            Zręczność += 2;
            Inteligencja += 1;
            MaksymalnaLiczbaPunktówŻycia += 20;
            AktualnaLiczbaPunktówŻycia = MaksymalnaLiczbaPunktówŻycia;
        }

        public override string ToString()
        {
            return base.ToString() + $", Liczba ataków: {LiczbaAtakówNaRundę}";
        }
    }

}
