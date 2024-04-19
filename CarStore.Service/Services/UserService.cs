using Car_store_theme.Entity;
using Car_store_theme.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CarStore.DataLayer.Repository;

namespace Car_store_theme.Service
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _UserRepository;
        public UserService(IUserRepository UserRepository)
        {
            _UserRepository = UserRepository;
        }

        public User Access(User DataLogin)
        {
            return _UserRepository.GetUserDetails(DataLogin);

        }
        public bool InsertUserDetails(User UserDetails)
        {
            return _UserRepository.InsertUserDetails(UserDetails);

        }
    }
}