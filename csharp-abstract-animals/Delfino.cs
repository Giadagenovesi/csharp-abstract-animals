using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    public class Delfino : Animale, INuotante
    {
        public override void CosaMangi()
        {
            Console.WriteLine("Pesci");
        }

        public override void CosaSei()
        {
            Console.WriteLine("Delfino");
        }

        public void Nuota()
        {
            Console.WriteLine("Sto Nuotando!!!");
        }

        public override void Verso()
        {
            Console.WriteLine("Il verso del delfino");
        }
    }
}
