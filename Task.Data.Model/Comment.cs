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
        [Display(Name = "İçerik")]
        [ForeignKey("User")]
        public int UserId { get; set; }
        [ForeignKey("ProjectTask")]
        public int ProjectTaskId { get; set; }
        public string Content { get; set; }      
        public virtual User User { get; set; }
        public virtual ProjectTask ProjectTask { get; set; }
        // Relations

    }
}