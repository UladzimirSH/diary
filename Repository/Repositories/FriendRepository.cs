using System;
using AutoMapper;
using Domain.Models;
using Repository.Contexts;
using Repository.Entities;
using Repository.Repositories.Abstract;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;

namespace Repository.Repositories {
    public class FriendRepository : /*RepositoryBase<FriendModel, Friend>,*/ IFriendRepository
    {

        private IMapper _mapper;
        public FriendRepository(IMapper mapper)
        {
            _mapper = mapper;
        }

        public  void Add(FriendModel model)
        {
            //Friend friend = _mapper.Map<Friend>(model);
            //_mainContext.Friend.Add(friend);
            //_mainContext.SaveChanges();
        }

        public void AddRange(IEnumerable<FriendModel> entities)
        {
            throw new NotImplementedException();
        }

        public void Remove(FriendModel entit)
        {
            throw new NotImplementedException();
        }

        public void Commit()
        {
            throw new NotImplementedException();
        }

        public FriendModel GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<FriendModel> GetAll() {
            try
            {
                using (var sqlConnection = new SqlConnection("Server=.;Database=Diary;Trusted_Connection=True;"))
                {
                    sqlConnection.Open();
                    using (var sqlCommand = new SqlCommand("SELECT * FROM FRIEND", sqlConnection))
                    {
                        SqlDataReader myReader = null;

                        myReader = sqlCommand.ExecuteReader();
                        while (myReader.Read())
                        {
                            Console.WriteLine(myReader["Column1"].ToString());
                            Console.WriteLine(myReader["Column2"].ToString());
                        }
                    }
                }
            }
            catch (Exception e)
            {

            }
          

            return null;
        }
    }
}
