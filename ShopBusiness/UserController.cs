using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopData;
using System.Data.Entity.Validation;
using System.Diagnostics;

namespace ShopBusiness
{
    public class UserController
    {
        ShopModel userModel;
        User user;
        public UserController()
        {
            userModel = new ShopModel();
        }

        public string SaltGenerator(int size)
        {
            string salt = "";
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            Random random = new Random();
            for (int i = 0; i < size; i++)
                salt += chars[random.Next(chars.Length)];
            return salt;
        }

        public string Hasher(string input)
        {
            StringBuilder hash = new StringBuilder();
            System.Security.Cryptography.SHA256Managed sha = new System.Security.Cryptography.SHA256Managed();
            byte[] crypted = sha.ComputeHash(Encoding.UTF8.GetBytes(input), 0, Encoding.UTF8.GetByteCount(input));
            foreach (byte chunk in crypted)
                hash.Append(chunk.ToString("x2"));
            return hash.ToString();
        }

        public void Add(string username, string pass)
        {
            user = new User();
            user.Username = username;
            user.Salt = SaltGenerator(5);
            user.Password = Hasher(pass + user.Salt);
            userModel.Users.Add(user);
            userModel.SaveChanges();
            Console.WriteLine("done");
        }

        public bool Login(string username, string password)
        {
            user = new User();
            user = userModel.Users.SingleOrDefault(x => x.Username == username);
            bool access = String.Equals(user.Password, Hasher(password + user.Salt), StringComparison.Ordinal);
            return access;
        }
    }
}
