using System;
using Domain.Models;
using Repository.Repositories.Abstract;
using System.Collections.Generic;
using System.Data.SqlClient;
using Repository.Constants;

namespace Repository.Repositories {
    public class FriendRepository : IFriendRepository {

        public void Add(FriendModel model) {
            try {
                using (var sqlConnection = new SqlConnection(SqlCommandConstants.ConnectionString)) {
                    sqlConnection.Open();
                    using (var sqlCommand = new SqlCommand(
                        SqlCommandConstants.AddFriendQuery(model.Name, model.DateOfBirth, model.DateOfWedding), sqlConnection)) {
                        sqlCommand.ExecuteNonQuery();
                    }
                }

            } catch (Exception e) {
            }
        }

        public IEnumerable<FriendModel> GetAll() {
            try {
                using (var sqlConnection = new SqlConnection(SqlCommandConstants.ConnectionString)) {
                    sqlConnection.Open();
                    using (var sqlCommand = new SqlCommand(SqlCommandConstants.SelectAllFriendsQuery, sqlConnection)) {
                        SqlDataReader myReader = null;

                        myReader = sqlCommand.ExecuteReader();
                        List<FriendModel> friends = new List<FriendModel>();
                        while (myReader.Read()) {
                            FriendModel friend = new FriendModel() {
                                Id = Int32.Parse(myReader["FriendId"].ToString()),
                                Name = myReader["FriendName"].ToString(),
                                DateOfBirth = DateTime.Parse(myReader["DateOfBirth"].ToString()),
                                DateOfWedding = DateTime.Parse(myReader["DateOfWedding"].ToString())
                            };
                            friends.Add(friend);
                        }

                        return friends;
                    }
                }
            } catch (Exception e) {

            }

            return new List<FriendModel>();
        }
    }
}
