using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    public class Aquila : Animale, IVolante
    {
        public override void CosaMangi()
        {
            Console.WriteLine("Topi e Chiwawa");
        }

        public override void CosaSei()
        {
            Console.WriteLine("Aquila");
        }

        public override void Verso()
        {
            Console.WriteLine("Cip Cip ma diverso");
        }

        public void Vola()
        {
            Console.WriteLine("Sto Volando!!!!! ");
        }
    }
}
