using System;

namespace Repository.Entities {
    public class Friend {

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
