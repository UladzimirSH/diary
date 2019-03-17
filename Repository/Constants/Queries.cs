using System;

namespace Repository.Constants {
    internal class Queries {

        public const string ConnectionString = @"Server=us-cdbr-iron-east-03.cleardb.net;Port=3306;Database=ad_808df90daf1e2ee;Uid=b4fae118cb36e3;Pwd=1c646c2a;Convert Zero Datetime=True;";

        //Friend
        public static string SelectAllFriendsQuery = $@"SELECT * FROM {TableNames.Friend}";
        public static string AddFriendQuery(string name, DateTime dateOfBirth, DateTime dateOfWedding) => $@"INSERT INTO {TableNames.Friend}
                                                       ({ColumnNames.Friend_FriendName}
                                                       ,{ColumnNames.Friend_DateOfBirth}
                                                       ,{ColumnNames.Friend_DateOfWedding})
                                                        VALUES
                                                       ('{name}',
                                                        '{dateOfBirth:yyyy-MM-dd HH:mm:ss}',
                                                        '{dateOfWedding:yyyy-MM-dd HH:mm:ss}')";
    }
}
