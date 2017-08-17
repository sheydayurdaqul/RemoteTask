using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Task.Data.Model
{
    public class Team : ModelBase
    {
        public Team()
        {
           
        }
        [Key,ForeignKey("Project")]
        public int ProjectId { get; set; }
        public virtual User Owner { get; set; }
        public virtual Project Project { get; set; }
        public virtual ICollection<User> Users { get; set; }
     
    }
}