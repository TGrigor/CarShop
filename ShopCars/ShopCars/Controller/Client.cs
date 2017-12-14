using ShopCarsInfo;

namespace ShopCars.Controller
{
    class Client : User
    {
        public Client(UserInfo userInfo) : base(userInfo)
        {

        }

        public override void ShowUserInterface()
        {
            FormCarListClient formCarListClient = new FormCarListClient();
            //TODO Dialog
            formCarListClient.ShowDialog();
        }
    }
}
