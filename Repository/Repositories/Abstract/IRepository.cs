using System.Collections.Generic;
using Domain.Models.Abstractions;

namespace Repository.Repositories.Abstract {
    public interface IRepository<TModel> where TModel : IModel {
        TModel GetById(int id);
        IEnumerable<TModel> GetAll();

        void Add(TModel entity);
        void AddRange(IEnumerable<TModel> entities);

        void Remove(TModel entit);

        void Commit();
    }
}
