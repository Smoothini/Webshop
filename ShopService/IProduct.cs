using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ShopService
{
    [ServiceContract]
    public interface IProduct
    {
        [OperationContract]
        bool Create(string name, string description, int category, int stock, decimal price);

        [OperationContract]
        bool Update(string name, string newName, string newDescription, int newCategory, int newStock, decimal newPrice);

        [OperationContract]
        bool Delete(string name);

        [OperationContract]
        List<string> ReadAllAsList();

        [OperationContract]
        string[] GetProductDetails(string name);

        [OperationContract]
        bool Restock(string name, int quantity);

    }
}
