using System;
using System.Collections.Generic;
using System.Text;

namespace PetsCare.Models
{
    public class Veterinarian
    {
        public int VeterinarianID { get; set; }
        public String Name { get; set; }
        public String Address { get; set; }
        public String Phone { get; set; }

        public Clinic Clinic { get; set; }
        public int ClinicID { get; set; }

        public IList<Pet> Pets { get; set; }

    }
}
