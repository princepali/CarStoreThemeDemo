using Car_store_theme.Entity;
using Car_store_theme.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_store_theme.Repository
{
    public interface IUserRepository
    {
        bool InsertUserDetails(User UserDetails);
        User GetUserDetails(User DataLogin);

    }
}
