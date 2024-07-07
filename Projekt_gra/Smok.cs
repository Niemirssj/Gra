using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_gra
{
    public class Smok : Wrok
    {
        public Smok()
            : base()
        {
            Imię = "Smok";
            Siła = 8;
            Zręczność = 20;
            Inteligencja = 30;
            AktualnaLiczbaPunktówŻycia = 1000;
            MaksymalnaLiczbaPunktówŻycia = 1000;
            ZadawaneObrażenia = 80;
            OdpornośćNaObrażenia = 40;
            PunktyDoświadczeniaZaPokonanie = 1200;
            atrybut = Atrybut.Ognisty;
            Zloto = 20;
        }

        

        public override void LevelUp()
        {
        }
    }

}
