using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u21520659_HW4.Models
{
    public abstract class Goal

    {
        public int SDGID { get; set; }
        public string Sponsor { get; set; }
        public int Duration { get; set; }
        public double Donation { get; set; }
                    
   

        public Goal(int sdgID, string sponsor, int duration , double donation)
        {
            SDGID = sdgID;
            Sponsor = sponsor;
            Duration = duration;
            Donation = donation;

        }
        public Goal() { }

        public abstract double CalculateCost();

        public virtual double AccumulatedCost()
        {
          return Donation * Duration;
        }




    }
}