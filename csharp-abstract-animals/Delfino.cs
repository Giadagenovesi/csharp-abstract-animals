using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    public class Delfino : Animale
    {
        public override void CosaMangi()
        {
            Console.WriteLine("Pesci");
        }

        public override void CosaSei()
        {
            Console.WriteLine("Delfino");
        }

        public override void Verso()
        {
            Console.WriteLine("Il verso del delfino");
        }
    }
}
