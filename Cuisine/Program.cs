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

            Plat platVache = new Plat
            {
                TypePlat = "Vache",
                NbrBouchee = 1
            };

            Plat platDinde = new Plat
            {
                TypePlat = "Dinde",
                NbrBouchee = 1
            };

            Plat platPoulet = new Plat
            {
                TypePlat = "Poulet",
                NbrBouchee = 2
            };
            Contexte contexte = new Contexte();

            contexte.Plats.Add(platCheval);
            contexte.Plats.Add(platCochon);
            contexte.Plats.Add(platPoulet);
            contexte.Plats.Add(platDinde);
            contexte.Plats.Add(platVache);

            contexte.SaveChanges();

            foreach (Plat plat in contexte.Plats)
                Console.WriteLine(plat);
        }
    }
}
