using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    public class Passerotto : Animale, IVolante 
    {
        public override void CosaMangi()
        {
            Console.WriteLine("Vermi"); ;
        }

        public override void CosaSei()
        {
            Console.WriteLine("Passerotto"); ;
        }

        public override void Verso()
        {
            Console.WriteLine("Cip Cip");
        }

        public void Vola()
        {
            Console.WriteLine("Sto Volando!!!!! ");
        }
    }
}
