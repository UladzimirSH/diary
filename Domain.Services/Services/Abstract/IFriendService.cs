using System.Collections.Generic;
using Domain.Models;

namespace Domain.Services.Services.Abstract {
    public interface IFriendService
    {
        IReadOnlyCollection<FriendModel> GetFriendsByDayOfBirth();
    }
}
