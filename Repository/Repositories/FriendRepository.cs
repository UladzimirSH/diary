using Domain.Models;
using Repository.Repositories.Abstract;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using Repository.Constants;

namespace Repository.Repositories {
    public class FriendRepository : IFriendRepository {

        public void Add(FriendModel model) {
            using (var mySqlConnection = new MySqlConnection(Queries.ConnectionString)) {
                mySqlConnection.Open();
                string mySqlQuery = Queries.AddFriendQuery(model.Name, model.DateOfBirth, model.DateOfWedding);
                using (var mySqlCommand = new MySqlCommand(mySqlQuery, mySqlConnection)) {
                    mySqlCommand.ExecuteNonQuery();
                }
            }
        }

        public IEnumerable<FriendModel> GetAll() {
            List<FriendModel> friends = new List<FriendModel>();

            using (var mySqlConnection = new MySqlConnection(Queries.ConnectionString)) {
                mySqlConnection.Open();
                using (var mySqlCommand = new MySqlCommand(Queries.SelectAllFriendsQuery, mySqlConnection)) {
                    MySqlDataReader mySqlReader = null;

                    mySqlReader = mySqlCommand.ExecuteReader();

                    while (mySqlReader.Read()) {
                        FriendModel friend = new FriendModel() {
                            Id = mySqlReader.GetInt32(ColumnNames.Friend_FriendId),
                            Name = mySqlReader.GetString(ColumnNames.Friend_FriendName),
                            DateOfBirth = mySqlReader.GetDateTime(ColumnNames.Friend_DateOfBirth),
                            DateOfWedding = mySqlReader.GetDateTime(ColumnNames.Friend_DateOfWedding)
                        };
                        friends.Add(friend);
                    }
                }
            }

            return friends;
        }
    }
}
