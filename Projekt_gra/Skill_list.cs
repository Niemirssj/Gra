using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_gra

{
     public class KsiegaCzarow : List<Czar>
    {
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var czar in this)
            {
                sb.AppendLine(czar.ToString());
            }
            return sb.ToString();
        }
    }
}
