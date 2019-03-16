using AutoMapper;
using Domain.Models;
using Repository.Entities;

namespace Repository {
    public class MappingProfile : Profile {
        public MappingProfile() {
            // Add as many of these lines as you need to map your objects
            CreateMap<FriendModel, Friend>();
        }
    }
}
