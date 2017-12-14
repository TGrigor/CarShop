using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopCarsInfo
{
    public class UserInfo : UserLoginInfo
    {
        public int UserId { get; set; }
        public bool HasAdminPermission { get; set; }
    }

    public class UserLoginInfo
    {
        public string Login { get; set; }
        public string Password { get; set; }
    }

    public class UserRegistrationInfo
    {
        public int UserId { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
    }
}
