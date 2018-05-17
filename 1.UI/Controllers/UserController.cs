using _1.UI.Models;
using _2.BL;
using _4.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _1.UI.Controllers
{
    public class UserController : Controller
    {
        UserManager manager = new UserManager();


        //get the all users.
        // GET: User
        [Authorize]
        public ActionResult Index()
        {
            return View(manager.Users.ToList());
        }

        public ActionResult ReturnOnlyActivityUsers()
        {
            var all = manager.Users.ToList();
            return PartialView(all);
        }

        public ActionResult ReturnAllUsers()
        {
            var all = manager.GetAllUsers.ToList();
            return PartialView(all);
        }

        public ActionResult EditUser(int id)
        {
            if (ModelState.IsValid)
            {
                var userToUpdate = manager.GetById(id);
                return View(userToUpdate);
            }
            else
            {
                return View("Error");
            }
        }

        public ActionResult UpdateUser(Users userToUpdate)
        {
            var rolName = userToUpdate.Roles.roleName.Trim().ToLower();
                
            var roles = manager.GatAllRoles().Where(r => r.roleName.ToLower() == rolName).FirstOrDefault();
           

            Users user = new Users()
            {
                UserID = userToUpdate.UserID,
                NickName = userToUpdate.NickName,
                Email = userToUpdate.Email,
                Password = userToUpdate.Password,
                roleNumber = roles.roleNumber,
                IsActiv = userToUpdate.IsActiv
            };
            manager.Update(user);

            return RedirectToAction("Index");
        }


    }
}