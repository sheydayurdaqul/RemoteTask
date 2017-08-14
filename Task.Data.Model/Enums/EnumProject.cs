using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task.Data.Model.Enums
{
   public class EnumProject
    {       
        public enum ProjectSchedule : int
        {
            [Display(Name = "ProjectSchedule_hour", ResourceType = typeof(string))]
            hour = 1,
            [Display(Name = "ProjectSchedule_day", ResourceType = typeof(string))]
            day = 2,
            [Display(Name = "ProjectSchedule_month", ResourceType = typeof(string))]
            month = 3,
            [Display(Name = "ProjectSchedule_year", ResourceType = typeof(string))]
            year = 4,
        }
       

    }
}
