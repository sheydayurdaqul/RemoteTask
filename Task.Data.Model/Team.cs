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
        public int Id { get; set; }
        [ForeignKey("Project")]
        public int ProjectId { get; set; }
        public User Owner { get; set; }
        public virtual Project Project { get; set; }
        public virtual ICollection<User> Users { get; set; }
     
    }
}