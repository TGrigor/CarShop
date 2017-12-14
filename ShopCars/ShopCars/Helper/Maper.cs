using System;
using ShopCarsInfo;

namespace ShopCars.Helper
{
    static class Maper
    {
        public static UserRegistrationInfo MapingRegistrationModel(string login, string pass, string confPass)
        {
            return new UserRegistrationInfo()
            {
                Login = login,
                Password = pass,
                ConfirmPassword = confPass
            };
        }

        public static UserLoginInfo MapingLoginModel(string login, string pass)
        {
            return new UserLoginInfo()
            {
                Login = login,
                Password = pass
            };
        }

        internal static BrandInfo MapingBrandModel(string name)
        {
            return new BrandInfo()
            {
                Name = name
            };
        }

        public static ModelInfo MapModelModel(int brandId, string modelName)
        {
            return new ModelInfo()
            {
                //TODO Change to brandId
                BrandId = brandId,
                ModelName = modelName,
            };
        }

        public static CarInfo MapingCarModel(string modelName, int price, string colorName)
        {
            return new CarInfo()
            {
                ModelName = modelName,
                Price = price,
                ColorName = colorName,
            };
        }
    }
}
