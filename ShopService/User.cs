using ShopBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ShopService
{
    public class User : IUser
    {
        UserController userController;
        public User()
        {
            userController = new UserController();
        }
        public bool Login(string name, string pass)
        {
            return userController.Login(name, pass);
        }

        public bool AdminLogin(string name, string pass)
        {
            return userController.AdminLogin(name, pass);
        }

        public bool CreateUser(string name, string pass)
        {
            return userController.Create(name, pass);
        }

        public bool UpdateUser(int id)
        {
            //TODO in webapp
            return true;
        }
        public bool DeleteUser(string user)
        {
            return userController.Delete(user);
        }

        public List<string> GetUsersAsList()
        {
            return userController.GetUsersAsList();
        }

        public string[] GetUserDetails(string user)
        {
            return userController.GetUserDetails(user);
        }
    }
}
