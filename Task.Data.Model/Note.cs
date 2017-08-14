using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Task.Data.Model
{
    public class Note : ModelBase
    {
        public Note()
        {

        }
        public string Content { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsFlag { get; set; }
        public virtual User OwnerUser { get; set; }
        public virtual ProjectTask Task { get; set; }



    }
}