using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Task.Data.Model
{
    public class Comment : ModelBase
    {
        public Comment()
        {
           
        }
        public int Id { get; set; }
        [Display(Name = "İçerik")]
        public string Content { get; set; }      
        public virtual User User { get; set; }
        public virtual ProjectTask Task { get; set; }
        // Relations

    }
}