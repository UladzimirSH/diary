using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Domain.Models.Abstractions;

namespace Repository.Repositories.Abstract {
    public interface IRepository<TModel> where TModel : IModel {
        TModel GetById(int id);
        IEnumerable<TModel> GetAll();
        IEnumerable<TModel> Find(Expression<Func<TModel, bool>> predicate);

        void Add(TModel entity);
        void AddRange(IEnumerable<TModel> entities);

        void Remove(TModel entit);
        void RemoveRange(IEnumerable<TModel> entities);
        void RemoveRange(IEnumerable<int> ids);

        void Commit();
    }
}
