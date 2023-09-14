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

                if (animale is INuotante nuotante)
                {
                    FaiNuotare(nuotante);

                }
            }



            //Creo una lista di tutti gli animali nuotanti
            List<INuotante> nuotanti = new List<INuotante>();
            nuotanti.Add(cane);
            nuotanti.Add(delfino);

            Console.WriteLine("STAMPO SOLO GLI ANIMALI NUOTANTI");
            Console.WriteLine("");

            foreach (INuotante nuotante in nuotanti)
            {

                Console.WriteLine("-------------------------------------------------------");

                if (nuotante is Animale animaleNuotante)
                {
                    Console.Write("Ciao io sono ");
                    animaleNuotante.CosaSei();
                    Console.Write("Il mio verso è ");
                    animaleNuotante.Verso();
                    Console.Write("e mi mangio ");
                    animaleNuotante.CosaMangi();
                    Console.Write("Quando dormo faccio ");
                    animaleNuotante.Dormi();
                    nuotante.Nuota();

                }

            }
            Console.WriteLine("-------------------------------------------------------");


            //Creo una lista di tutti gli animali volanti
            List<IVolante> volanti = new List<IVolante>();
            volanti.Add(passerotto);
            volanti.Add(aquila);

            Console.WriteLine("STAMPO SOLO GLI ANIMALI VOLANTI");
            Console.WriteLine("");

            foreach (var volante in volanti)
            {
                Console.WriteLine("-------------------------------------------------------");

                if (volante is Animale animaleVolante)
                {
                    Console.Write("Ciao io sono ");
                    animaleVolante.CosaSei();
                    Console.Write("Il mio verso è ");
                    animaleVolante.Verso();
                    Console.Write("e mi mangio ");
                    animaleVolante.CosaMangi();
                    Console.Write("Quando dormo faccio ");
                    animaleVolante.Dormi();
                    volante.Vola();

                }
            }

            
            Console.WriteLine("-------------------------------------------------------");
           

            //CREO 2 METODI PER FAR VOLARE E FAR NUOTARE GLI ANIMALI

            static void FaiVolare(IVolante volante)
            {
                volante.Vola();
            }


            static void FaiNuotare(INuotante nuotante)
            {
                nuotante.Nuota();
            }

           
        }
    }
}