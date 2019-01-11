using AutoMapper;
using Domain.Models;
using Repository.Entities;
using Repository.Repositories.Abstract;

namespace Repository.Repositories
{
    public class FriendRepository: RepositoryBase<FriendModel, Friend>, IFriendRepository
    {
        public FriendRepository(IMapper mapper) : base(mapper)
        {
        }
    }
}
