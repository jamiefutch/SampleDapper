using System.Collections.Generic;
using Dapper;

using SampleDapper.Models;

namespace SampleDapper.Repositories
{
    public class UserRepo :  BaseClasses.RepoBase
    {
        public UserRepo(string dbConnectionString) : base(dbConnectionString)
        { }

        public User GetUser(long Id)
        {
            var user = _conn.Query<User>("select * from Users where Id = @id", new {id = Id}) ?? new List<User>();
            return (User)user;
        }

        public void AddNewUser(User user)
        {
            string sql = @"insert into users (UserName) values (@userName)";
            _conn.Execute(sql, new {userName = user.UserName});
        }
        
    }
}