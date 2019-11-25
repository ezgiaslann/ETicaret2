//using System;
//using System.Collections.Generic;
//using System.Data.Entity;
//using System.Data.Entity.Migrations;
//using System.Linq;
//using System.Threading.Tasks;
//using System.Web;

//namespace ETicaret2.Repository
//{
    
//        public abstract class BaseRepository<C, T>
//             where T : class
//             where C : DbContext, new()
//        {
//            private C context = new C();
//            public C Context
//            {
//                get { return context; }
//                set
//                {
//                    context = value;
//                }
//            }
//            public virtual IQueryable<T> GetAll()
//            {
//                context.Configuration.ProxyCreationEnabled = false;
//                IQueryable<T> query = context.Set<T>();
//                return query;
//            }
//            public IQueryable<T> FindBy(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
//            {
//                context.Configuration.ProxyCreationEnabled = false;
//                IQueryable<T> query = context.Set<T>().Where(predicate);
//                return query;
//            }
//            public T FirstOrDefault(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
//            {
//                context.Configuration.ProxyCreationEnabled = false;
//                T query = context.Set<T>().FirstOrDefault(predicate);
//                return query;

//            }
//            public async Task<T> FirstOrDefaultAsync(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
//            {
//                context.Configuration.ProxyCreationEnabled = false;
//                T query = await context.Set<T>().FirstOrDefaultAsync(predicate);
//                return query;
//            }
//            public virtual void Add(T entity)
//            {
//                context.Set<T>().Add(entity);
//            }
//            public virtual void Delete(T entity)

//            {
//                context.Set<T>().Remove(entity);
//                context.SaveChanges();
//            }
//            public virtual void Edit(T entity)
//            {
//                context.Entry(entity).State = EntityState.Modified;

//                context.SaveChanges();
//            }

//            public virtual void Editv2(T entity)

//            {
//                context.Set<T>().AddOrUpdate<T>(entity);
//            }
//            public virtual void Save()
//            {
//                context.SaveChanges();
//            }

//        }

//    }