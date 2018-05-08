using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _1.UI.Models
{
    public class UserVM
    {
        public int UserID { get; set; }
        public string NickName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Nullable<int> roleNumber { get; set; }
        public Nullable<bool> IsActiv { get; set; }

        public UserVM(int userid, string nickName, string email, string password, Nullable<int> rolenumber, Nullable<bool> isActiv)
        {
            UserID = userid;
            NickName = nickName;
            Email = email;
            Password = password;
            roleNumber = rolenumber;
            IsActiv = isActiv;
        }
    }
}