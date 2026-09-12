using Microsoft.EntityFrameworkCore.Migrations.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EF_Rev.Repository
{
    public interface IGenericRepo<TEntity> where TEntity:class
    {
        // CRUD operations  C- Create , R- Read, U- Update, D- Delete
        void Create(TEntity entity);
        void UpdateRaw(TEntity entity);
        void Delete(TEntity entity);
        IEnumerable<TEntity> FindBy(Expression<Func<TEntity, bool>> predicate);
        IEnumerable<TEntity> GetAll(); // Itrate over all the records in the table
        TEntity getByID(int id);  // one object of class (Table) - one Raw of the table

        void SaveChanges(); // commit the changes to the database
    }
}
