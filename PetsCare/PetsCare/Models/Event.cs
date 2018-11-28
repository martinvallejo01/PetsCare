using System;
using System.Collections.Generic;
using System.Text;

namespace PetsCare.Models
{
    public class Event
    {
        public int EventID { get; set; }
        public DateTime DueDate { get; set; }
        public Boolean Completed { get; set; }
        public String Reason { get; set; }
        public String Notes { get; set; }

        public Pet Pet { get; set; }
        public int PetID { get; set; }
    }
}
