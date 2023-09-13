using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    public class Cane : Animale, INuotante 
    {
        public override void CosaMangi()
        {
            Console.WriteLine("Crocchette e Carne");
        }

        public override void CosaSei()
        {
            Console.WriteLine("Cane");
        }

        public void Nuota()
        {
            Console.WriteLine("Sto Nuotando!!!");
        }

        public override void Verso()
        {
            Console.WriteLine("Bau Bau");
        }

       
    }
}
