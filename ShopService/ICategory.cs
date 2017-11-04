using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ShopService
{
    [ServiceContract]
    public interface ICategory
    {
        [OperationContract]
        bool CreateCategory(string name);

        [OperationContract]
        void ReadCategory(int id);

        [OperationContract]
        bool UpdateCategory(int id);

        [OperationContract]
        bool DeleteCategory(string name);

        [OperationContract]
        List<string> GetCategoriesAsList();
    }
}
