using AutoMapper;
using Domain.Models;
using Repository.Contexts;
using Repository.Entities;
using Repository.Repositories.Abstract;
using System.Collections.Generic;
using System.Linq;

namespace Repository.Repositories {
    public class FriendRepository : RepositoryBase<FriendModel, Friend>, IFriendRepository {
        private readonly MainContext _mainContext;

        public FriendRepository(IMapper mapper) : base(mapper) {
            _mainContext = new MainContext();
        }

        public override void Add(FriendModel model)
        {
            Friend friend = _mapper.Map<Friend>(model);
            _mainContext.Friend.Add(friend);
            _mainContext.SaveChanges();
        }

        public override IEnumerable<FriendModel> GetAll() {
            var friends = _mainContext.Friend;

            return friends.Select(f => _mapper.Map<FriendModel>(f));
        }
    }
}
