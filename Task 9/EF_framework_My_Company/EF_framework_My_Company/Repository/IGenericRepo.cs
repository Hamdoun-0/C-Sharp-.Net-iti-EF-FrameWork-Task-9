using EF_framework_My_Company.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;


namespace EF_framework_My_Company.Repository
{
    public interface IGenericRepo<TEntity> where TEntity : class
    {
        void Create(TEntity entity);
        void UpdateRaw(TEntity entity);
        void Delete(TEntity entity);
        //IEnumerable<TEntity> FindBy(Expression<Func<TEntity, bool>> predicate);
        
        TEntity getById(int id);

        void SaveChange();
    }
}
