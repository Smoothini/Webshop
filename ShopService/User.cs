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
        
        public void ReadUser()
        {
            //to be made god pls help me
            throw new NotImplementedException();
        }

        public bool UpdateUser(int id)
        {
            return userController.Update(id);
        }
        public bool DeleteUser(int id)
        {
            return userController.Delete(id);
        }
    }
}
