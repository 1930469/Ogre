using System;
using System.Collections.Generic;

#nullable disable

namespace Ogre.ModelesBD
{
    public partial class Vaccin
    {
        public int VaccinId { get; set; }
        public DateTime Date { get; set; }
        public string Nom { get; set; }
        public string Nampatient { get; set; }
    }
}
