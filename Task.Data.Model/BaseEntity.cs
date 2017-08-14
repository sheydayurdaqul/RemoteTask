using System;
using System.Linq;
using System.Linq.Expressions;

namespace Task.Data.Repositories
{
    /// <summary>
    /// Model katmanımızda bulunan her T tipi için aşağıda tanımladığımız fonksiyonları gerçekleştirebilecek generic bir repository tanımlıyoruz.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class BaseEntity
    {
       public int Id { get; set; }
    }
}