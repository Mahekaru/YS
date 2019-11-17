using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using YardSale.Models;
namespace YardSale.Models.CRUD
{
    
    public class DatabaseModel
    {
        private YSDatabaseEntities db = new YSDatabaseEntities();

        public User GetUserFromProfile(ProfileModel vm)
        {
            User newUser = new User();
            newUser.UserName = vm.UserName;
            newUser.Password = vm.Password;
            newUser.Address = vm.Address;
            newUser.City = vm.City;
            newUser.State = vm.State;
            newUser.Email = vm.Email;

            return newUser;
        }

        public bool CreateNewUser(User NewUser)
        {
            bool created = false;

            User newUser = new User();
            if (newUser != null)
            {
                if (db.Users.Any(u => u.UserName != NewUser.UserName))
                {
                    db.Users.Add(newUser);
                    db.SaveChanges();
                }
            }
            return created;
        }
    }

    
}