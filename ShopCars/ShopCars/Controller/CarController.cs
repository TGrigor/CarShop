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
    public class CarController
    {
        private CarRepository _carRepository;

        public CarController()
        {
            _carRepository = new CarRepository();
        }


        public bool AddCar(CarInfo carInfo)
        {
            bool isValid = ValidationHelper.IsCarValid(carInfo);
            if (isValid)
            {
                carInfo.CarId = GetUnicId.GetNewGuid();
                _carRepository.SaveCarData(carInfo);
            }
            return isValid;
        }

        public List<CarInfo> GetCars()
        {
            return _carRepository.GetCarsData();
        }
    }
}
