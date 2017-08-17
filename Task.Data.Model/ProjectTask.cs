using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Task.Data.Model
{
    public class ProjectTask : ModelBase
    {
        public ProjectTask()
        {
            Comments = new List<Comment>();
            Notes = new List<Note>();
        }

        [ForeignKey("Project")]
        public int ProjectId { get; set; }
        public int ParentId { get; set; }
        public string Content { get; set; }
        public bool IsComplete { get; set; }
        public DateTime CompletedDate { get; set; }
        public virtual Project Project { get; set; }
        public virtual ICollection<User> Users { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<Note> Notes { get; set; }
        // Relations

    }
}