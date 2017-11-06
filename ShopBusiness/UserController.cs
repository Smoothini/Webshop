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
        List<User> users;
        //Constructor, initializes the EF model
        public UserController()
        {
            userModel = new ShopModel();
        }


        //Generates a salt of the desired size, which for now is 5
        public string SaltGenerator(int size)
        {
            string salt = "";
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            Random random = new Random();
            for (int i = 0; i < size; i++)
                salt += chars[random.Next(chars.Length)];
            return salt;
        }
        //Hashes the input using SHA256
        public string Hasher(string input)
        {
            StringBuilder hash = new StringBuilder();
            System.Security.Cryptography.SHA256Managed sha = new System.Security.Cryptography.SHA256Managed();
            byte[] crypted = sha.ComputeHash(Encoding.UTF8.GetBytes(input), 0, Encoding.UTF8.GetByteCount(input));
            foreach (byte chunk in crypted)
                hash.Append(chunk.ToString("x2"));
            return hash.ToString();
        }


        //Create a new User
        public bool Create(string username, string pass)
        {
            bool isCreated = true;
            user = new User();
            user = userModel.Users.SingleOrDefault(x => x.Username.Equals(username));
            if (user == null)
            {
                user = new User();
                user.Username = username;
                user.Salt = SaltGenerator(5);
                user.Password = Hasher(pass + user.Salt);
                user.Role = false;
                userModel.Users.Add(user);
                userModel.SaveChanges();
            }
            else
                isCreated = false;
            return isCreated;
        }
        //Read user by id
        public User Read(int id)
        {
            user = new User();
            user = userModel.Users.SingleOrDefault(x => x.User_ID == id);
            return user;
        }
        //Read all users to a list
        public List<User> ReadAll()
        {
            users = new List<User>();
            users = userModel.Users.ToList();
            return users;
        }
        //Update user by id
        public bool Update(int id)
        {
            bool isUpdated = true;
            // TO be done later maybe
            return isUpdated;
        }
        //Delete user by id
        public bool Delete(int id)
        {
            bool isDeleted = true;
            user = new User();
            user = userModel.Users.SingleOrDefault(x => x.User_ID == id);
            if (user != null)
            {
                userModel.Users.Remove(user);
                userModel.SaveChanges();
            }
            else
                isDeleted = false;
            return isDeleted;
        }

        //Normal login
        public bool Login(string username, string password)
        {
            user = new User();
            user = userModel.Users.SingleOrDefault(x => x.Username == username);
            bool access = String.Equals(user.Password, Hasher(password + user.Salt), StringComparison.Ordinal);
            return access;
        }
        //Login that checks for administrator privileges
        public bool AdminLogin(string username, string password)
        {
            user = new User();
            user = userModel.Users.SingleOrDefault(x => x.Username == username);
            bool access = String.Equals(user.Password, Hasher(password + user.Salt), StringComparison.Ordinal) && user.Role == true;
            return access;
        }
    }
}
