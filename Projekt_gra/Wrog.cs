using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_gra
{
    public class Wrok : Postać
    {
        public int PunktyDoświadczeniaZaPokonanie { get;  set; }

        public Atrybut atrybut { get; set; }
        public Wrok()
            : base("Vahram", 10, 0, 30, 10, 20, 500, 500, 40, 20)
        {
            PunktyDoświadczeniaZaPokonanie = 500;
            atrybut = Atrybut.Wodny;
        }

        public  Action<int> atak;

        public virtual void OtrzymajObrażenia(int obrażenia, Atrybut at)
        {
            if (atrybut == at) { obrażenia = obrażenia * 2; }
           
            obrażenia = Math.Max(0, obrażenia - OdpornośćNaObrażenia);
            AktualnaLiczbaPunktówŻycia = Math.Max(0, AktualnaLiczbaPunktówŻycia - obrażenia);
        }

        public void Atak()
        {
            int moc = Siła;
            

            atak?.Invoke(moc);
        }

        public override void LevelUp()
        {
           
        }
    }

}
