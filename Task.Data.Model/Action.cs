using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace Task.Data.Model
{
    public class Action :ModelBase
    {
        public Action()
        {
            Roles = new List<Role>();
        }
        public bool DefaultforAdmins{get;set;}
        [Display(Name = "Adı")]
        public string Name { get; set; }
        [Display(Name = "Açıklama Bilgisi")]
        public string Knowledge { get; set; }
        public int PageId { get; set; }
        public virtual Page page { get; set; }
        public virtual ICollection<Role> Roles { get; set; }
        
    }
}