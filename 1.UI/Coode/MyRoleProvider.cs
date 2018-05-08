using _2.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;

namespace _1.UI.Coode
{
    public class MyRoleProvider : RoleProvider
    {
        UserManager manager;
        public MyRoleProvider()
        {
            manager = new UserManager();
        }
        public override string ApplicationName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override void AddUsersToRoles(string[] usernames, string[] roleNames)
        {
            throw new NotImplementedException();
        }

        public override void CreateRole(string roleName)
        {
            throw new NotImplementedException();
        }

        public override bool DeleteRole(string roleName, bool throwOnPopulatedRole)
        {
            throw new NotImplementedException();
        }

        public override string[] FindUsersInRole(string roleName, string usernameToMatch)
        {
            throw new NotImplementedException();
        }

        public override string[] GetAllRoles()
        {
            throw new NotImplementedException();
        }

        public override string[] GetRolesForUser(string userMaile)
        {
            var user = manager.Users.Where(u => u.Email == userMaile).FirstOrDefault();
            string role = user.Roles.roleName;

            string[] roles= new string[] {role.Trim() };
            return roles ;
        }

        public override string[] GetUsersInRole(string roleName)
        {
            throw new NotImplementedException();
        }

        public override bool IsUserInRole(string userMaile, string roleName)
        {
            string[] roles = GetRolesForUser(userMaile);
            return roles.Contains(roleName.Trim());
        }

        public override void RemoveUsersFromRoles(string[] usernames, string[] roleNames)
        {
            throw new NotImplementedException();
        }

        public override bool RoleExists(string roleName)
        {
            throw new NotImplementedException();
        }
    }
}