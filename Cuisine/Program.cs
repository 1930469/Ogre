using System;

namespace Cuisine
{
    class Program
    {
        static void Main(string[] args)
        {
            Plat platCheval = new Plat
            {
                TypePlat = "Cheval",
                NbrBouchee = 2
            };

            Plat platCochon = new Plat
            {
                TypePlat = "Cochon",
                NbrBouchee = 3
            };
            Contexte contexte = new Contexte();

            contexte.Plats.Add(platCheval);
            contexte.Plats.Add(platCochon);

            contexte.SaveChanges();

            foreach (Plat plat in contexte.Plats)
                Console.WriteLine(plat);
        }
    }
}
