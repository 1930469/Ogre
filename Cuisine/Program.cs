using System;
using System.Linq;

namespace Cuisine
{
    class Program
    {
        static public void CreePlat(int choix)
        {
            Contexte contexte = new Contexte();
            switch (choix)
            {
                case 1: Plat platCochon = new Plat
                        {
                            TypePlat = "Cochon",
                            NbrBouchee = 3
                        }; contexte.Plats.Add(platCochon); contexte.SaveChanges(); break;
                case 2: Plat platVache = new Plat
                        {
                            TypePlat = "Vache",
                            NbrBouchee = 1
                        }; contexte.Plats.Add(platVache); contexte.SaveChanges(); break;
                case 3: Plat platPoulet = new Plat
                        {
                            TypePlat = "Poulet",
                            NbrBouchee = 2
                        }; contexte.Plats.Add(platPoulet); contexte.SaveChanges(); break;
                
            }
        }
        static void Main(string[] args)
        {
            bool full = false;
            Contexte contexte = new Contexte();
            Random random = new Random();
            


            while (full == false)
            {
                int nbrPlat = contexte.Plats.Count();
                CreePlat(random.Next(1, 3));
                
                if (nbrPlat == 100)
                    full = true;
            }
            
            foreach (Plat plat in contexte.Plats)
                Console.WriteLine(plat);
        }
    }
}
