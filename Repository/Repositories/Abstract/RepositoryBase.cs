using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Domain.Models.Abstractions;
using Repository.Contexts;
using Repository.Entities.Abstract;

namespace Repository.Repositories.Abstract {
    public class RepositoryBase<TModel, TEntity> : IRepository<TModel>
        where TModel : IModel
        where TEntity : IEntity
    {

        protected readonly DbContext _dbContext;
        protected readonly IMapper _mapper;
        
        public RepositoryBase(IMapper mapper) {
            _dbContext = new MainContext();
            _mapper = mapper;
        }

        public void Add(TModel model) {
            _dbContext.Set<TEntity>().Add(_mapper.Map<TEntity>(model));
        }

        public void AddRange(IEnumerable<TModel> entities) {
            throw new NotImplementedException();
        }

        public void Commit() {
            throw new NotImplementedException();
        }

        public IEnumerable<TModel> Find(Expression<Func<TModel, bool>> predicate) {
            throw new NotImplementedException();
        }

        public TModel GetById(int id) {
            var result = _dbContext.Set<TEntity>().Find(id);
            return _mapper.Map<TModel>(result);
        }

        public IEnumerable<TModel> GetAll() {
            throw new NotImplementedException();
        }

        public void Remove(TModel entit) {
            throw new NotImplementedException();
        }

        public void RemoveRange(IEnumerable<TModel> entities) {
            throw new NotImplementedException();
        }

        public void RemoveRange(IEnumerable<int> ids) {
            throw new NotImplementedException();
        }
    }
}

