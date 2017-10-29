using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopBusiness;

namespace ShopCons
{
    class Program
    {
        static void Main(string[] args)
        {
            string user, salt, pass;
            Console.WriteLine("Username: ");
            user = Console.ReadLine();
            Console.WriteLine("Password");
            pass = Console.ReadLine();
            UserController uc = new UserController();
            Console.WriteLine(uc.Login(user, pass));
            //uc.Add(user, pass);
            Console.Read();
        }
    }
}
