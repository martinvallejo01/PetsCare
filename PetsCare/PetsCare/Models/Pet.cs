using System;
using System.Collections.Generic;
using System.Text;

namespace PetsCare.Models
{
    public class Pet
    {

        public int PetID { get; set; }
        public String Name { get; set; }
        public String Breed { get; set; }
        public String Colors { get; set; }
        public DateTime BirthDate { get; set; }
        public Gender Gender { get; set; }
        public String AllergiesAndIllness { get; set; }
        public String Comments { get; set; }

        public Clinic Clinic { get; set; }
        public int ClinicID { get; set; }

        public Veterinarian Veterinarian { get; set; }
        public int VeterinarianID { get; set; }
    }

    public enum Gender { Male = 0, Female = 1}
}
