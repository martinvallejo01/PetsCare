using System;
using System.Collections.Generic;
using System.Text;

namespace PetsCare.Models
{
    class VisitLog
    {
        public int VisitLogID { get; set; }
        public DateTime VisitDate { get; set; }
        public Double Weight { get; set; }
        public String Details { get; set; }
        public String Reason { get; set; }
        public String Medication { get; set; }
        public VisitKind VisitKind { get; set; }

        public Pet Pet { get; set; }
        public int PetID { get; set; }

        public IList<Shot> Shots { get; set; }
        

    }

    public enum VisitKind { Routine = 0, Emergency = 1}
}
