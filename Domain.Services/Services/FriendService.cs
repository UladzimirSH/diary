using System;
using System.Collections.Generic;
using System.Linq;
using Domain.Models;
using Domain.Services.Services.Abstract;
using Repository.Repositories.Abstract;

namespace Domain.Services.Services {
    public class FriendService : IFriendService {
        private readonly IFriendRepository _friendRepository;

        public FriendService(IFriendRepository friendRepository) {
            _friendRepository = friendRepository;
        }

        public IReadOnlyCollection<FriendModel> GetFriendsByDayOfBirth(DateTime dateTime) {
            var friends = _friendRepository.GetAll();
            return friends.Where(f => f.DateOfBirth.Date == dateTime.Date).ToList();
        }

        public IReadOnlyCollection<FriendModel> GetAll() {
            return _friendRepository.GetAll().ToList();
        }

        public void AddFriend(FriendModel friend) {
            _friendRepository.Add(friend);
        }
    }
}
