using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ogre
{
    class Ogre
    {
        public string regime { get; set; }

        public void SelectPlat()
        {
            ModelesBD.PlatBDContext contexte = new ModelesBD.PlatBDContext();
            try
            {
                    ModelesBD.Plat plat = contexte.Plats.FirstOrDefault();
                    contexte.Plats.Remove(plat);
                    
            }
            catch(Exception e)
            {
                string fin = "Il ny'a plus de plat";
            }
        }
    }
}
