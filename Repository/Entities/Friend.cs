using System;
using Repository.Entities.Abstract;

namespace Repository.Entities {
    public class Friend: EntityBase {

        public int FriendId {
            get;
            set;
        }

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
