using AutoMapper;
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

        public User GetUserFromProfile(ProfileModel Profile)
        {
            User newUser = new User();
            //required fields
            newUser.UserName = Profile.Username;
            newUser.Password = Profile.Password;
            newUser.Address1 = Profile.Address1;
            newUser.Address2 = Profile.Address2;//This is also optional
            newUser.City = Profile.City;
            newUser.State = Profile.State;
            newUser.Zipcode = Profile.Zipcode;
            //Optional
            newUser.Phone = Profile.Phone;
            newUser.Email = Profile.Email;

            return newUser;
        }
        public bool CreateNewUser(ProfileModel Profile)
        {
            User NewUser = new User();
            NewUser = GetUserFromProfile(Profile);
            return CreateNewUser(NewUser);
        }

        public bool CreateNewUser(User NewUser)
        {
            bool created = false;

            if (NewUser != null)
            {
                if (db.Users.Any(u => u.UserName != NewUser.UserName))
                {
                    db.Users.Add(NewUser);
                    db.SaveChanges();
                }
            }
            return created;
        }
    }

    
}