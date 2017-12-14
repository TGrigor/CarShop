using ShopCarsInfo;

namespace ShopCars.Controller
{
    abstract class User
    {
        public UserInfo Userinfo { get; set; }

        public User(UserInfo userInfo)
        {
            Userinfo = userInfo;
        }

        public abstract void ShowUserInterface();
    }
}
