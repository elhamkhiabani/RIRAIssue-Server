using RIRA.Core.Presentations.Base;
using RIRA.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RIRA.Core.Repositories
{
    public interface IRepository<T,V> where T : class , IEntity
    {
        MessageViewModel Add(T entity, int creatorId = 0);

        MessageViewModel Delete(int id, int creatorId=0, bool hardDelete = false);

        ResultViewModel<V> GetByID(int id);

        MessageViewModel Update(T entity);

        ResultViewModel<V> GetAll(bool isActive, Expression<Func<T, bool>>? predicate);
        void SaveChange();
    }
}
