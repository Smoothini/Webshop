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
        
        //Update user by id
        public bool Update(int id)
        {
            bool isUpdated = true;
            // TO be done in web app
            // will update User_Information
            return isUpdated;
        }
        //Delete user by id
        public bool Delete(string username)
        {
            bool isDeleted = true;
            user = new User();
            user = userModel.Users.SingleOrDefault(x => x.Username == username);
            if (user != null)
            {
                userModel.User_Information.Remove(user.User_Information);
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

        public List<string> GetUsersAsList()
        {
            List<string> usernames = new List<string>();
            users = new List<User>();
            users = userModel.Users.ToList<User>();
            foreach (User u in users)
                usernames.Add(u.Username);
            return usernames;
        }

        public string[] GetUserDetails(string username)
        {
            string[] details = new string[4];
            user = new User();
            User_Information info;
            user = userModel.Users.SingleOrDefault(x => x.Username == username);
            if(user != null)
            {
                info = userModel.User_Information.SingleOrDefault(x => x.User_Id == user.User_ID);
                if (info != null)
                {
                    if (info.Name != null)
                        details[0] = user.User_Information.Name;
                    else
                        details[0] = "NO VALUE SET";


                    if (info.Email != null)
                        details[1] = user.User_Information.Email;
                    else
                        details[1] = "NO VALUE SET";

                    if (info.Address != null)
                        details[2] = user.User_Information.Address;
                    else
                        details[2] = "NO VALUE SET";

                    if (info.Phone != null)
                        details[3] = user.User_Information.Phone;
                    else
                        details[3] = "NO VALUE SET";
                }
            }
            return details;
        }
    }
}
