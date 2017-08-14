using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task.Data.Model.Enums
{
   public class EnumResource
    {
        public enum ResourceType : int
        {
            [Display(Name = "ResourceType_physical", ResourceType = typeof(string))]
            phyical = 1,
            [Display(Name = "ResourceType_user", ResourceType = typeof(string))]
            user = 2
        }

        public enum ResourceSchedule : int
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
        public enum ResourceOvercomeCurrency : int
        {
           [Display(Name = "ResourceOvercomeCurrency_trl", ResourceType = typeof(string))]
           trl = 1,
           [Display(Name = "ResourceOvercomeCurrency_eur", ResourceType = typeof(string))]
           euro = 2,
           [Display(Name = "ResourceOvercomeCurrency_dolar", ResourceType = typeof(string))]
           dollar = 2
        }

    }
}
