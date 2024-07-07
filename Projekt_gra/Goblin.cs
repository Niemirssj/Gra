using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_gra
{
    public class Goblin : Wrok
    {
        public Goblin()
            : base()
        {
            Imię = "Goblin";
            Siła = 8;
            Zręczność = 25;
            Inteligencja = 10;
            AktualnaLiczbaPunktówŻycia = 150;
            MaksymalnaLiczbaPunktówŻycia = 150;
            ZadawaneObrażenia = 25;
            OdpornośćNaObrażenia = 10;
            PunktyDoświadczeniaZaPokonanie = 200;
            atrybut = Atrybut.Normalny;
            Zloto = 20;
        }

       

        public override void LevelUp()
        {
            
        }
    }

}
