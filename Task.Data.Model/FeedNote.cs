using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Task.Data.Model
{
    public class FeedNote
    {
        public FeedNote()
        {

        }
        public int Id { get; set; }
      
        public DateTime ReadTime { get; set; }
        public virtual Note Note { get; set; }
        public virtual User User { get; set; }
       
    }
}