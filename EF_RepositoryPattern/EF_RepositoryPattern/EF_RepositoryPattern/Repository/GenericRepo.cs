using EF_Rev.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EF_Rev.Repository
{
    public class GenericRepo<TEntity> : IGenericRepo<TEntity> where TEntity : class
    {
        // App DbContext _context;
        protected readonly ApplicationDbContext _context;
        protected readonly DbSet<TEntity> _dbSet;  // semi cache of the table

        public GenericRepo(ApplicationDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<TEntity>();
        }

        public void Create(TEntity entity)
        {
            _dbSet.Add(entity);
        }

        public void UpdateRaw(TEntity entity)
        {
            _dbSet.Update(entity);
        }

        public void Delete(TEntity entity)
        {
            _dbSet.Remove(entity);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _dbSet.ToList();
        }

        public TEntity getByID(int id)
        {
            return _dbSet.Find(id);
        }

        public IEnumerable<TEntity> FindBy(Expression<Func<TEntity, bool>> predicate)
        {
            return _dbSet.Where(predicate);
        }


        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
