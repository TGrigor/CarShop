using ShopCarsInfo;
using ShopCars.Helper;
using ShopCarsRepository.Repositories;
using System.Collections.Generic;

namespace ShopCars.Controller
{
    public class ModelController
    {
        private ModelRepository _modelRepository;

        public ModelController()
        {
            _modelRepository = new ModelRepository();
        }

        public bool SaveNewModel(ModelInfo modelInfo)
        {
            bool isValid = ValidationHelper.IsModelValid(modelInfo);

            if (isValid)
            {
                _modelRepository.SaveModelData(modelInfo);
            }

            return isValid;
        }

        public List<ModelInfo> GetModels()
        {
            return _modelRepository.GetModelsData();
        }
    }
}
