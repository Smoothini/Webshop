using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopController;
using ShopModel;

namespace Tester
{
    class Program
    {
        static void Main(string[] args)
        {
            CategoryController cc = new CategoryController();
            Console.WriteLine(cc.Read(4));
        }
    }
}
