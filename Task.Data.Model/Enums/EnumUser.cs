using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task.Data.Model.Enums
{
   public class EnumUser
    {       
        public enum UserSchedule : int
        {
            [Display(Name = "ResourceSchedule_hour", ResourceType = typeof(string))]
            hour = 1,
            [Display(Name = "ResourceSchedule_day", ResourceType = typeof(string))]
            day = 2,
            [Display(Name = "ResourceSchedule_month", ResourceType = typeof(string))]
            month = 3,
            [Display(Name = "ResourceSchedule_year", ResourceType = typeof(string))]
            year = 4,
        }
       

    }
}
