using System;
using System.Collections.Generic;
using System.Text;

namespace PetsCare.Models
{
    public class Clinic
    {
        public int ClinicID { get; set; }
        public String Name { get; set; }
        public String Address { get; set; }
        public String Phone { get; set; }

        public IList<Pet> Pets { get; set; }
    }
}
