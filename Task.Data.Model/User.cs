using System;
using System.Collections.Generic;
using Task.Data.Model.Enums;


namespace Task.Data.Model
{
    public class User : ModelBase
    {
        public User()
        {
            Roles = new List<Role>();
            Teams = new List<Team>();
            ProjectTasks = new List<ProjectTask>();
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Alias { get; set; }
        public string Email { get; set; }
        public string PassWord { get; set; }
        public string TicketId { get; set; }
        public DateTime ?LastLoginDate { get; set; }
        public virtual ICollection<ProjectTask> ProjectTasks { get; set; }
        public virtual ICollection<Role> Roles { get; set; }
        public virtual ICollection<Team> Teams { get; set; }
        public EnumUser.UserSchedule Schedule { get; set; }
        public int WorkingTime { get; set; }



    }
}