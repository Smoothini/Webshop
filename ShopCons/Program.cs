using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopCons
{
    class Program
    {
        static void Main(string[] args)
        {
            string user, salt, pass;
            Console.WriteLine("Username: ");
            user = Console.ReadLine();
            Console.WriteLine("Salt: ");
            salt = Console.ReadLine();
            Console.WriteLine("Password");
            pass = Console.ReadLine();
            ShopUserRef.IUser UserRef = new ShopUserRef.UserClient();
            UserRef.AddUser(user, salt, pass);
        }
    }
}
