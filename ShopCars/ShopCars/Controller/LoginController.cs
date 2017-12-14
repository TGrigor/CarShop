using ShopCars.Helper;
using ShopCarsInfo;
using ShopCarsRepository.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopCars.Controller
{
    class LoginController
    {
        private UserAuthenticationRepository _authenticationRepository;
        public LoginController()
        {
            _authenticationRepository = new UserAuthenticationRepository();
        }

        public bool IsValidLogin(UserLoginInfo userLoginInfo)
        {
            bool isValid = ValidationHelper.IsLoginFieldsCompleted(userLoginInfo)
                        && _authenticationRepository.IsUserDataValid(userLoginInfo);

            return isValid;
        }

        public User GetUserRole(UserLoginInfo userLoginInfo)
        {
            User user;
            UserInfo userInfo = _authenticationRepository.GetUserData(userLoginInfo);

            if (userInfo.HasAdminPermission)
            {
                user = new Admin(userInfo);
            }
            else
            {
                user = new Client(userInfo);
            }
            return user;
        }
    }
}
