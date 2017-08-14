using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Linq.Expressions;


namespace Task.Data.Repositories
{
    
    public class EFRepository<T> : IRepository<T> where T : BaseEntity
    {
        DbContext _dbContext;
        private readonly DbSet<T> _dbSet;

        public EFRepository(EFBlogContext EFBlogContext)
        {
            _dbContext = EFBlogContext;
            _dbSet = _dbContext.Set<T>();
        }

        #region IRepository Members
        public IQueryable<T> GetAll()
        {
            return _dbSet;
        }

        public IQueryable<T> GetAll(Expression<Func<T, bool>> predicate)
        {
            return _dbSet.Where(predicate);

        }
        public T GetById(int Id)
        {
            return _dbSet.Find(Id);
          
        }

        public T Get(Expression<Func<T, bool>> predicate)
        {
           
            return _dbSet.Where(predicate).SingleOrDefault();

        }
        public void Add(T entity)
        {
            _dbSet.Add(entity);
            this.SaveChanges();
        }
        public void AddOrUpdate(T entity)
        {
            if(entity.Id==0)
            {
                Add(entity);
            }
            else
            {
                Update(entity);
            }
        }

        public void Update(T entity)
        {
            _dbSet.Attach(entity);
            _dbContext.Entry(entity).State = EntityState.Modified;
            this.SaveChanges();
        }
        //public virtual bool Exists(int id)
        //{
        //    return _dbContext.Set<T>().Any(t => t.Id == id);
        //}

        //public virtual void CreateOrUpdate(T entity)
        //{
        //    if (Exists(entity.Id))
        //    {
        //        var oldEntity = GetById(entity.Id);
        //        _dbContext.Entry(oldEntity).CurrentValues.SetValues(entity);
        //        Update(oldEntity);
        //    }
        //    else
        //    {
        //        Add(entity);
        //    }
        //}



        public void Delete(T entity)
        {
            // Eğer sizlerde genelde bir kayıtı silmek yerine IsDelete şeklinde bool bir flag alanı tutuyorsanız,
            // Küçük bir refleciton kodu yardımı ile bunuda otomatikleştirebiliriz.
            if (entity.GetType().GetProperty("IsDelete") != null)
            {
                T _entity = entity;

                _entity.GetType().GetProperty("IsDelete").SetValue(_entity, true);

                this.Update(_entity);
            }
            else
            {
                // Önce entity'nin state'ini kontrol etmeliyiz.
                DbEntityEntry dbEntityEntry = _dbContext.Entry(entity);

                if (dbEntityEntry.State != EntityState.Deleted)
                {
                    dbEntityEntry.State = EntityState.Deleted;
                }
                else
                {
                    _dbSet.Attach(entity);
                    _dbSet.Remove(entity);
                }
            }
            this.SaveChanges();
        }

        public void Delete(int id)
        {
            var entity = GetById(id);
            if (entity == null) return;
            else
            {
                if (entity.GetType().GetProperty("IsDelete") != null)
                {
                    T _entity = entity;
                    _entity.GetType().GetProperty("IsDelete").SetValue(_entity, true);

                    this.Update(_entity);
                }
                else
                {
                    Delete(entity);
                }
            }
            this.SaveChanges();
        }

        private bool SaveChanges()
        {
            return _dbContext.SaveChanges() > 0;
        }
        #endregion


     
    }
}