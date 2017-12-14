using ShopCars.Helper;
using ShopCarsInfo;
using ShopCarsRepository.Repositories;

namespace ShopCars.Controller
{
    class RegistrationController
    {
        private UserAuthenticationRepository _authenticationRepository;

        public RegistrationController()
        {
            _authenticationRepository = new UserAuthenticationRepository();
        }

        public bool Registrate(UserRegistrationInfo userInfo)
        {
            bool isValid = ValidationHelper.IsRegFieldsCompleted(userInfo) 
                        && ValidationHelper.IsPasswordSame(userInfo.Password, userInfo.ConfirmPassword)
                        && !_authenticationRepository.LoginExists(userInfo.Login);

            if (isValid)
            {
                userInfo.UserId = GetUnicId.GetNewGuid();
                _authenticationRepository.SaveRegistrationDate(userInfo);
            }

            return isValid;
        }
    }
}
