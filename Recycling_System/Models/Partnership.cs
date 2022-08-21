using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u21520659_HW4.Models
{
    public class Partnership : Goal 
    {
        public string PartnershipType { get; set; }    
        public int Duration { get; set; }
        public double  Donation { get; set; }
        public string Programme { get; set; }

 

        public Partnership(int sdgID, string sponsor, string programme, double donation ,string partnershipType, int duration) : base(sdgID, sponsor, duration, donation)
        {
            PartnershipType = partnershipType;
            Duration = duration;
            Donation = donation;
            Programme = programme; 
           
        }

        public Partnership():base()
        {

        }

        public override double CalculateCost()
        {
            return Donation * 1.00;
         }

    }
}