using ShopCarsInfo;

namespace ShopCars.Controller
{
    class Admin : User
    {
        public Admin(UserInfo userInfo): base (userInfo)
        {
            
        }
        public override void ShowUserInterface()
        {
            FormCarListAdmin formCarListAdmin = new FormCarListAdmin();
            //TODO Dialog
            formCarListAdmin.ShowDialog();
        }
    }
}
