using AutoMapper;
using Domain.Models.Abstractions;
using Repository.Contexts;
using Repository.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace Repository.Repositories.Abstract {
    public class RepositoryBase<TModel, TEntity> : IRepository<TModel>
        where TModel : IModel
        where TEntity : IEntity {

        protected readonly DbContext _dbContext;
        protected readonly IMapper _mapper;

        public RepositoryBase(IMapper mapper) {
            _dbContext = new MainContext();
            _mapper = mapper;
        }

        public void Add(TModel model) {
            var entity = _mapper.Map<TEntity>(model);
            _dbContext.Set(typeof(TEntity)).Add(entity);
        }

        public void AddRange(IEnumerable<TModel> entities) {
            throw new NotImplementedException();
        }

        public void Commit() {
            _dbContext.SaveChangesAsync();
        }

        public TModel GetById(int id) {
            throw new NotImplementedException();
        }

        public IEnumerable<TModel> GetAll() {
            throw new NotImplementedException();
        }

        public void Remove(TModel entit) {
            throw new NotImplementedException();
        }
    }
}

