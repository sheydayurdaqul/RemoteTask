using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Task.Data.Model
{
    public class Page 
    {
        public Page()
        {
           
        }
        public int Id { get; set; }
        [Display(Name = "Sayfa adı")]
        public string Name { get; set; }
        [Display(Name = "Controller adı")]
        public string ControllerName { get; set; }
        public virtual ICollection<Action> Actions { get; set; }
   
     
    }
}