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
    public class BrandController
    {
        BrandRepository _brandRepository;

        public BrandController()
        {
            _brandRepository = new BrandRepository();
        }

        public bool AddBrand(BrandInfo brandInfo)
        {
            bool isValid = ValidationHelper.IsBrandNameValid(brandInfo);
            if (isValid)
            {
                brandInfo.BrandId = GetUnicId.GetNewGuid();
                _brandRepository.SaveBrandData(brandInfo);
            }
            return isValid;
        }

        public List<BrandInfo> GetBrands()
        {
           return _brandRepository.GetBrandsData();
        }
    }
}
