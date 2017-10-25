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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "User" in both code and config file together.
    public class User : IUser
    {
        UserController userController;
        public User()
        {
            userController = new UserController();
        }
        public void AddUser(string name, string salt, string pass)
        {
            userController.Add(name, salt, pass);
        }
    }
}
