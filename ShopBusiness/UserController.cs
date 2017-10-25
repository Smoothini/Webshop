using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopData;
using static ShopData.User;

namespace ShopBusiness
{
    public class UserController
    {
        ShopModel userModel;
        User user;
        public UserController()
        {
            userModel = new ShopModel();
        }

        public void Add(string name, string salt, string pass)
        {
            user = new User();
            user.Username = name;
            user.Salt = salt;
            user.Password = pass;
            userModel.Users.Add(user);
            userModel.SaveChanges();
        }
    }
}
