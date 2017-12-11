using System;
using System.Collections.Generic;
using SampleDapper.Models;
using SampleDapper.Repositories;
namespace SampleDapper
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string dbConnectionString = "blah";

            User user;
            using (UserRepo ur = new UserRepo(dbConnectionString))
            {
                user = ur.GetUser(1);
            }
        }
    }
}