using System.Collections.Generic;
using Domain.Models;

namespace Repository.Repositories.Abstract {
    public interface IFriendRepository {
        void Add(FriendModel friendModel);
        IEnumerable<FriendModel> GetAll();
    }
}
