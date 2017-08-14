using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Resources;
using Task.Data.Model.Enums;

namespace Task.Data.Model
{
    public class Resource : ModelBase
    {
        public Resource()
        {
           
        }
        //yorum
        [Display(Name = "Tipi")]
        public EnumResource.ResourceType ResourceType { get; set; }
        public EnumResource.ResourceSchedule Schedule { get; set; }
        public EnumResource.ResourceOvercomeCurrency Currency { get; set; }
        public double OverCome { get; set; }
        public virtual ICollection<Project> Projects { get; set; }

    }
}