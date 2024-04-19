using Car_store_theme.Data;
using Car_store_theme.Entity;
using Car_store_theme.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Car_store_theme.Repository
{

    public class UserRepository : IUserRepository
    {
        private readonly IDataFactory _dataFactory;
        private DataFactoryDataContext _dataDataContext;
        public UserRepository(IDataFactory dataFactory)
        {
            _dataFactory = dataFactory;
            _dataDataContext = dataFactory.GetDataFactoryDataContext();
        }

        public User GetUserDetails(User DataLogin)
        {
            var userData = _dataDataContext.GetUserDetails20220910(DataLogin.Email, DataLogin.Password).ToList();
            var UserInformation = (from u in userData
                                   select new User
                                   {

                                       Name = u.Name,
                                       Email = u.Email,
                                       Password = u.Password

                                   }).FirstOrDefault();
            return UserInformation;
        }

        public bool InsertUserDetails(User UserDetails)
        {


            var isselect = _dataDataContext.InsertUserData20220909(UserDetails.Name, UserDetails.Email, UserDetails.Password, UserDetails.Gender, UserDetails.Department, UserDetails.Hobbies).SingleOrDefault();
            bool select = (bool)isselect.Column1;
            return select;
        }

    }
}