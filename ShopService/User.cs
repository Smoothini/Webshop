using ShopBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
//using static ShopBusiness.UserController;

namespace ShopService
{
    public class User : IUser
    {
        UserController userController;
        public User()
        {
            userController = new UserController();
        }
        public void AddUser(string name, string pass)
        {
            userController.Add(name, pass);
        }

        public bool Login(string name, string pass)
        {
            return userController.Login(name, pass);
        }
    }
}
