using System;
using Domain.Models.Abstractions;

namespace Domain.Models {
    public class FriendModel : ModelBase {

        public string Name {
            get; set;
        }

        public DateTime DateOfBirth {
            get; set;
        }

        public DateTime DateOfWedding {
            get; set;
        }
    }
}
