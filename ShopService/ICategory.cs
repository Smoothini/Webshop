using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ShopModel;

namespace ShopService
{
    [ServiceContract]
    public interface ICategory
    {
        [OperationContract]
        bool Create(ShopModel.Category t);

        [OperationContract]
        ShopModel.Category Read(int id);

        [OperationContract]
        List<ShopModel.Category> ReadAll();

        [OperationContract]
        bool Update(ShopModel.Category t);

        [OperationContract]
        bool Delete(ShopModel.Category t);
    }    
}
