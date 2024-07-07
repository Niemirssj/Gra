using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_gra
{
    public abstract class Postać
    {
        public string Imię { get;  set; }
        public int Poziom { get;  set; }
        public int PunktyDoświadczenia { get; set; }
        public int Siła { get; set; }
        public int Zręczność { get;  set; }
        public int Inteligencja { get;  set; }
        public int AktualnaLiczbaPunktówŻycia { get; set; }
        public int MaksymalnaLiczbaPunktówŻycia { get; set; }
        public int ZadawaneObrażenia { get; set; }
        public int OdpornośćNaObrażenia { get;  set; }
        public int AktualnaLiczbaPunktówMany { get; set; }
        public int MaksymalnaLiczbaPunktówMany { get; set; }
        public int LiczbaAtakówNaRundę { get; set; }
        public int SzansaNaUnik { get; set; }
        public KsiegaCzarow KsiegaCzarow { get; set; }

        public int Zloto { get; set; }

        public Postać()
        {
            Imię = "Nieznany";
            Poziom = 1;
            PunktyDoświadczenia = 0;
            Siła = 10;
            Zręczność = 10;
            Inteligencja = 10;
            AktualnaLiczbaPunktówŻycia = 100;
            MaksymalnaLiczbaPunktówŻycia = 100;
            ZadawaneObrażenia = 10;
            OdpornośćNaObrażenia = 5;
            Zloto = 20;
        }

        public Postać(string imię, int poziom, int punktyDoświadczenia, int siła, int zręczność, int inteligencja,
            int aktualnaLiczbaPunktówŻycia, int maksymalnaLiczbaPunktówŻycia, int zadawaneObrażenia, int odpornośćNaObrażenia)
        {
            Imię = imię;
            Poziom = poziom;
            PunktyDoświadczenia = punktyDoświadczenia;
            Siła = siła;
            Zręczność = zręczność;
            Inteligencja = inteligencja;
            AktualnaLiczbaPunktówŻycia = aktualnaLiczbaPunktówŻycia;
            MaksymalnaLiczbaPunktówŻycia = maksymalnaLiczbaPunktówŻycia;
            ZadawaneObrażenia = zadawaneObrażenia;
            OdpornośćNaObrażenia = odpornośćNaObrażenia;
        }

        public override string ToString()
        {
            return $"{Imię}, Poziom: {Poziom}, HP: {AktualnaLiczbaPunktówŻycia}/{MaksymalnaLiczbaPunktówŻycia}, " +
                   $"Siła: {Siła}, Zręczność: {Zręczność}, Inteligencja: {Inteligencja}";
        }

        public virtual void Uzbrój(int dodatkoweObrażenia)
        {
            ZadawaneObrażenia += dodatkoweObrażenia;
        }

        public virtual void ZałóżPancerz(int dodatkowaOdporność)
        {
            OdpornośćNaObrażenia += dodatkowaOdporność;
        }

        public virtual int ObrażeniaWRundzie
        {
            get
            {
                return ZadawaneObrażenia;
            }
        }

        public virtual void OtrzymajObrażenia(int obrażenia)
        {
            obrażenia = Math.Max(0, obrażenia - OdpornośćNaObrażenia);
            AktualnaLiczbaPunktówŻycia = Math.Max(0, AktualnaLiczbaPunktówŻycia - obrażenia);
        }

        public bool CzyNieŻyje
        {
            get
            {
                return AktualnaLiczbaPunktówŻycia == 0;
            }
        }

        public abstract void LevelUp();

        public virtual void ZwiększPunktyDoświadczenia(int punkty)
        {
            PunktyDoświadczenia += punkty;
            while (PunktyDoświadczenia >= Poziom * 100)
            {
                LevelUp();
            }
        }

        public void OdejmijZloto(int kwota)
        {
            if (kwota > Zloto)
            {
                throw new ZlotoException($"Próba odjęcia {kwota} złota przekracza dostępne zasoby. Aktualne złoto: {Zloto}.");
            }
            Zloto -= kwota;
        }

        public void OdejmijMana(int kwota)
        {
            if (kwota > AktualnaLiczbaPunktówMany)
            {
                throw new ManaException($"Próba odjęcia {kwota} many przekracza dostępne zasoby. Aktualna mana: {AktualnaLiczbaPunktówMany}.");
            }
            AktualnaLiczbaPunktówMany -= kwota;
        }

    }

}
