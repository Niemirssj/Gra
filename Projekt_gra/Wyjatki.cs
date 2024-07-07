using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_gra
{
    
        public class PostacException : Exception
        {
            public PostacException() { }

            public PostacException(string message) : base(message) { }

            public PostacException(string message, Exception inner) : base(message, inner) { }
        }

        public class ZlotoException : PostacException
        {
            public ZlotoException() : base("Niewystarczająca ilość złota.") { }

            public ZlotoException(string message) : base(message) { }
        }

        public class ManaException : PostacException
        {
            public ManaException() : base("Niewystarczająca ilość many.") { }

            public ManaException(string message) : base(message) { }
        }
    }


