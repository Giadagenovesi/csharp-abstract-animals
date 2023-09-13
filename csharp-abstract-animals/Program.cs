using System.Security.Cryptography.X509Certificates;

namespace csharp_abstract_animals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aquila aquila = new Aquila();
            Cane cane = new Cane();
            Delfino delfino = new Delfino();
            Passerotto passerotto = new Passerotto();
            
            //Creo una lista di tutti gli animali
            List<Animale> animali = new List<Animale>();
            animali.Add(aquila);
            animali.Add(cane);  
            animali.Add(delfino);
            animali.Add(passerotto);

            Console.WriteLine("STAMPO LA LISTA DI TUTTI GLI ANIMALI");
            Console.WriteLine("");

            foreach (Animale animale in animali)
            {
                Console.Write("Ciao io sono ");
                animale.CosaSei();
                Console.Write("Il mio verso è ");
                animale.Verso();
                Console.Write("e mi mangio ");
                animale.CosaMangi();
                Console.Write("Quando dormo faccio ");
                animale.Dormi();

                Console.WriteLine("-------------------------------------------------------");
            }

            

            //Creo una lista di tutti gli animali nuotanti
            List<INuotante> nuotanti = new List<INuotante>();
            nuotanti.Add(cane);
            nuotanti.Add(delfino);

            Console.WriteLine("STAMPO SOLO GLI ANIMALI NUOTANTI");
            Console.WriteLine("");

            foreach (Animale nuotante in nuotanti)
            {
                Console.Write("Ciao io sono ");
                nuotante.CosaSei();
                Console.Write("Il mio verso è ");
                nuotante.Verso();
                Console.Write("e mi mangio ");
                nuotante.CosaMangi();
                Console.Write("Quando dormo faccio ");
                nuotante.Dormi();
                //volante.Vola();
                Console.WriteLine("-------------------------------------------------------");
            }

            //Creo una lista di tutti gli animali volanti
            List<IVolante> volanti = new List<IVolante>();
            volanti.Add(passerotto);
            volanti.Add(aquila);

            Console.WriteLine("STAMPO SOLO GLI ANIMALI VOLANTI");
            Console.WriteLine("");

            foreach (Animale volante in volanti)
            {
                Console.Write("Ciao io sono ");
                volante.CosaSei();
                Console.Write("Il mio verso è ");
                volante.Verso();
                Console.Write("e mi mangio ");
                volante.CosaMangi();
                Console.Write("Quando dormo faccio ");
                volante.Dormi();
                
                
                //volante.Vola();
                Console.WriteLine("-------------------------------------------------------");
            }

           


            //static void FaiVolare(IVolante animale)
            //{
            //    animale.Vola();
            //}

            //FaiVolare(aquila);
        }
    }
}