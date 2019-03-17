using System;

namespace Repository.Constants {
    public class SqlCommandConstants {

        public const string ConnectionString = @"Server=.;Database=Diary;Trusted_Connection=True;";

        //Friend
        public const string SelectAllFriendsQuery = @"SELECT * FROM FRIEND";
        public static string AddFriendQuery(string name, DateTime dateOfBirth, DateTime dateOfWedding) => $@"INSERT INTO [dbo].[Friend]
                                                       ([FriendName]
                                                       ,[DateOfBirth]
                                                       ,[DateOfWedding])
                                                        VALUES
                                                       ('{name}',
                                                        '{dateOfBirth.Date}',
                                                        '{dateOfWedding.Date}')";
    }
}
