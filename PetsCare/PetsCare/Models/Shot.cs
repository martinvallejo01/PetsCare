using System;
using System.Collections.Generic;
using System.Text;

namespace PetsCare.Models
{
    class Shot
    {
        public int ShotID { get; set; }
        public ShotInformation ShotInformation { get; set; }
        public DateTime NextVaccine { get; set; }
    }
}
