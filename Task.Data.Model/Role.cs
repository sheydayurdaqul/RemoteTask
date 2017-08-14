using System;
using System.Collections.Generic;

namespace Task.Data.Model
{
    public class Role : ModelBase
    {
        public Role()
        {
            Users = new List<User>();
            Actions = new List<Action>();
        }
        public int Id { get; set; }
        public string Type { get; set; }
        public virtual ICollection<User> Users { get; set; }
        public virtual ICollection<Action> Actions { get; set; }

    }
}