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
            
            
            List<Animale> animali = new List<Animale>();
            animali.Add(aquila);
            animali.Add(cane);  
            animali.Add(delfino);
            animali.Add(passerotto);  
            

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
        }
    }
}