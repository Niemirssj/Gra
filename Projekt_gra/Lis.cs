using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_gra
{
    public class Lis : Wrok
    {
        public Lis()
            : base()
        {
            Imię = "Lis";
            Siła = 8;
            Zręczność = 30;
            Inteligencja = 25;
            AktualnaLiczbaPunktówŻycia = 200;
            MaksymalnaLiczbaPunktówŻycia = 200;
            ZadawaneObrażenia = 30;
            OdpornośćNaObrażenia = 15;
            PunktyDoświadczeniaZaPokonanie = 300;
            atrybut = Atrybut.Wodny;
            Zloto = 20;
        }

       

        public override void LevelUp()
        {
           
        }
    }
    
}
