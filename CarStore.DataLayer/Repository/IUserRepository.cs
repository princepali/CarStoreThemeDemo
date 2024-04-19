using Car_store_theme.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarStore.DataLayer.Repository
{
    public interface IUserRepository
    {
        bool InsertUserDetails(User UserDetails);
        User GetUserDetails(User DataLogin);     
    }
}
