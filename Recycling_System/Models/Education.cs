using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u21520659_HW4.Models
{
    public class Education : Goal
    {
        public string EducationType { get; set; }
        public string SchoolName { get; set; }
        public int SchoolGrade{ get; set; }
        public int Duration { get; set; }
        public double Donation { get; set; }
        public Education(int sdgID, string sponsor, int duration, double donation, string educationType, string schoolName, int schoolGrade) :base(sdgID, sponsor, duration, donation)
        {
            EducationType = educationType;
            SchoolName = schoolName;
            SchoolGrade = schoolGrade;
            Duration = duration;
            Donation = donation; 
        }

        public Education()
        {

        }
        public override double CalculateCost()
        {
            return 25;
        }
    }
}