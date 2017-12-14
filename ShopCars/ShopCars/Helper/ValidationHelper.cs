using ShopCarsInfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopCars.Helper
{
    static class ValidationHelper
    {
        public static bool IsPasswordSame(string pass, string confPass)
        {
            return pass == confPass;
        }

        //TODO Merge repeat code
        public static bool IsRegFieldsCompleted(UserRegistrationInfo userRegInfo)
        {
            userRegInfo.Login = userRegInfo.Login.Trim();
            userRegInfo.Password = userRegInfo.Password.Trim();
            userRegInfo.ConfirmPassword = userRegInfo.ConfirmPassword.Trim();

            return !(string.IsNullOrEmpty(userRegInfo.Login))
                && !(string.IsNullOrEmpty(userRegInfo.Password))
                && !(string.IsNullOrEmpty(userRegInfo.ConfirmPassword));
        }

        public static bool IsCarValid(CarInfo carInfo)
        {
            return !string.IsNullOrEmpty(carInfo.ModelName);
        }

        public static bool IsModelValid(ModelInfo modelInfo)
        {
            //TODO
            return modelInfo.BrandId >= 0 && !string.IsNullOrEmpty(modelInfo.ModelName);
        }

        //TODO Merge repeat code
        public static bool IsLoginFieldsCompleted(UserLoginInfo userLoginInfo)
        {
            userLoginInfo.Login = userLoginInfo.Login.Trim();
            userLoginInfo.Password = userLoginInfo.Password.Trim();

            return (!string.IsNullOrEmpty(userLoginInfo.Login))
                && (!string.IsNullOrEmpty(userLoginInfo.Password));
        }

        public static bool IsBrandNameValid(BrandInfo brandInfo)
        {
            return !string.IsNullOrEmpty(brandInfo.Name);
        }
    }
}
