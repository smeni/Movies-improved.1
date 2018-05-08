using _3.DAL;
using _4.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BL
{
    public class UserManager
    {
        //referene to the DB.
        private Movies_Rental_DBEntities ctx;

        public UserManager()
        {
            ctx = new Movies_Rental_DBEntities();
        }

        //return all users from DB.
        public List<Users> Users
        {
            get
            {
                return ctx.Users.Where(u => u.IsActiv == true).ToList();
            }
        }

        public List<Users> GetAllUsers
        {
            get
            {
                return ctx.Users.ToList();
            }

        }

        //return the selected user by his UserID.
        public Users GetById(int userId)
        {
            return ctx.Users.Where(u => u.UserID == userId).FirstOrDefault();
        }

        public bool Update(Users userToUpdate)
        {
            using (ctx = new Movies_Rental_DBEntities())
            {
                // 1) attach the employee to the context (in the memory)
                ctx.Users.Attach(userToUpdate);

                // 2) mark the employee as "need to be updated"
                ctx.Entry(userToUpdate).State = System.Data.Entity.EntityState.Modified;

                // 3) save the changes in the database
                int count = ctx.SaveChanges();

                return count > 0;
            }
        }

        public bool Insert(Users newUser)
        {
            ctx = new Movies_Rental_DBEntities();

            foreach (var user in Users)
            {
                if (user.Email != newUser.Email)
                {
                    ctx.Users.Add(newUser);
                    int count = ctx.SaveChanges();

                    return count > 0;
                }
            }
            return false;
        }

        public List<Roles> Roles
        {
            get
            {
                return ctx.Roles.ToList();
            }
        }

        public List<Roles> GatAllRoles()
        {
            var roles = ctx.Roles.ToList();
            return roles;
        }


    }
}
