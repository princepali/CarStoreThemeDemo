using Car_store_theme.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_store_theme.Service
{
    public interface IUserService
    {
        bool InsertUserDetails(User UserDetails);
        User Access(User DataLogin);

        /*   UserModel GetUserByEmail(string email);*/

    }
}
