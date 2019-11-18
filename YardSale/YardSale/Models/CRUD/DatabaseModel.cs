using System.Linq;
namespace YardSale.Models.CRUD
{

    public class DatabaseModel
    {
        private YSDatabaseEntities db = new YSDatabaseEntities();

        public User GetUserFromProfile(ProfileModel Profile)
        {
            User newUser = new User();
            //required fields
            newUser.Username = Profile.Username;
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
                //Checks to see if username already exists
                //or if the database is empty
                if (db.Users.Any(u => u.Username != NewUser.Username) || db.Users.Count() == 0)
                {
                    created = true;
                    db.Users.Add(NewUser);
                    db.SaveChanges();
                }
            }
            return created;
        }
    }

    
}