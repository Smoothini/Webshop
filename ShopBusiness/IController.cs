using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopBusiness
{
    public interface IController<T>
    {
        T Read(int id);
        List<T> ReadAll();
        bool Update(int id);
        bool Delete(int id);
        //List<T> Search(string keyword);
    }
}
