using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Task.Data.Model.Enums;

namespace Task.Data.Model
{
    public class Project : ModelBase
    {
        [ForeignKey("Team")]
        public int TeamId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public EnumProject.ProjectSchedule EstimatedTimeSchedule { get; set; }
        public int EstimatedTime { get; set; }
        public DateTime StartTime { get; set; }
        public virtual Team Team { get; set; }
        public virtual ICollection<Resource> Recources { get; set; }
        public virtual ICollection<ProjectTask> ProjectTasks { get; set; }
     
    }
}