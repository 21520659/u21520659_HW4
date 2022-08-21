using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u21520659_HW4.Models
{
    public static class List
    {
        public static readonly List<Goal> recycles = new List<Goal> ();

        public static void Add(Goal recycle)
        {
            recycles.Add(recycle);
        }

        public static List<Goal> Recycles()
        {
            return recycles;
        }

        public static void Delete(int id)
        {
           for(int i = 0; i < recycles.Count; i++)
            {
                if (recycles[i].SDGID == id)
                {
                    recycles.Remove(recycles[i]);
                }
            }
          
        }

        public static void Edit(Goal recycle)
        {
            if(recycle.GetType () == typeof(Education))
            {
                Education education = (Education )recycle;
                for(int i = 0; i < recycles.Count; i++)
                {
                    if(recycles[i].SDGID == education.SDGID)
                    {
                        recycles[i] = education;
                    }
                }
               

            }

            if (recycle.GetType() == typeof(Partnership))
            {
                Partnership partnership = (Partnership)recycle;
                for (int i = 0; i < recycles.Count; i++)
                {
                    if (recycles[i].SDGID == partnership.SDGID)
                    {
                        recycles[i] = partnership;
                    }
                }


            }

        }
    }
}