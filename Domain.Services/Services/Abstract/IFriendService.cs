using System;
using System.Collections.Generic;
using Domain.Models;

namespace Domain.Services.Services.Abstract {
    public interface IFriendService {
        IReadOnlyCollection<FriendModel> GetFriendsByDayOfBirth(DateTime dateTime);
        IReadOnlyCollection<FriendModel> GetAll();
        void AddFriend(FriendModel friend);
    }
}
