using System;
using Task.Data.Repositories;

namespace Task.Data.Model
{
    public abstract class ModelBase:BaseEntity
    {

        public ModelBase()
        {
            CreatedDate = DateTime.Now;
        }
        public DateTime CreatedDate { get; set; }


    }
}