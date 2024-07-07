using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_gra
{
    public class Czarodziej : Postać
    {
        

        public Czarodziej(string imię)
            : base(imię, 1, 0, 5, 10, 15, 80, 80, 8, 5)
        {
            MaksymalnaLiczbaPunktówMany = 100;
            AktualnaLiczbaPunktówMany = 100;
        }

        public override int ObrażeniaWRundzie
        {
            get
            {
                return ZadawaneObrażenia * (Inteligencja/ 2);
            }
        }

        public override void LevelUp()
        {
            Poziom++;
            Siła += 2;
            Zręczność += 2;
            Inteligencja += 5;
            MaksymalnaLiczbaPunktówŻycia += 10;
            MaksymalnaLiczbaPunktówMany += 20;
            AktualnaLiczbaPunktówŻycia = MaksymalnaLiczbaPunktówŻycia;
            AktualnaLiczbaPunktówMany = MaksymalnaLiczbaPunktówMany;
        }

        public override string ToString()
        {
            return base.ToString() + $", Mana: {AktualnaLiczbaPunktówMany}/{MaksymalnaLiczbaPunktówMany}";
        }
    }

}
