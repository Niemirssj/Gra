using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_gra
{
   
    public enum TypCzaru
    {
        Ofensywny,
        Defensywny,
        Uzdrawiajacy
    }

    public enum Atrybut
    {
        Normalny,
        Elektryczny,
        Ognisty,
        Wodny
    }

    public enum Klasa
    {
        Wojownik,
        Czarodziej,
        Łucznik
    }

    public class Czar
    {
        public string Nazwa { get; set; }
        public TypCzaru Typ { get; set; }
        public int KosztMany { get; set; }
        public  Atrybut Atrybut { get; set; }
        public int Efekt { get; set; }

        public Klasa Klasa { get; set; }
        public override string ToString()
        {
            return $"{Nazwa} ({Typ}), Koszt Many: {KosztMany}, Atrybut: {Atrybut}, Efekt: {Efekt}";
        }

        public override bool Equals(object obj)
        {
            if (obj is Czar czar)
            {
                return ToString() == czar.ToString();
            }
            return false;
        }

        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }
    }
}
