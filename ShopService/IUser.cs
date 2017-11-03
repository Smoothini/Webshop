using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ShopService
{
    [ServiceContract]
    public interface IUser
    {

        [OperationContract]
        bool Login(string name, string pass);

        [OperationContract]
        bool AdminLogin(string name, string pass);

        [OperationContract]
        bool CreateUser(string name, string pass);

        [OperationContract]
        void ReadUser();

        [OperationContract]
        bool UpdateUser(int id);

        [OperationContract]
        bool DeleteUser(int id);
    }
}
