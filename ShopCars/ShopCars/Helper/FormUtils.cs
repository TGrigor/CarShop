using ShopCars.Controller;
using ShopCarsInfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopCars.Helper
{
    static class FormUtils
    {
        public static void AddBrandToList(ref ComboBox comboBoxBrand, ref BrandController _brandController)
        {
            List<BrandInfo> brands = _brandController.GetBrands();
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            foreach (var item in brands)
            {
                dictionary.Add(item.BrandId, item.Name);
            }
            comboBoxBrand.DataSource = new BindingSource(dictionary, null);
            comboBoxBrand.ValueMember = "Key";
            comboBoxBrand.DisplayMember = "Value";
        }

        public static void AddModelToList(int brandId, ref ComboBox comboBoxBrand, ref ModelController _modelController)
        {
            List<ModelInfo> models = _modelController.GetModels();
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            foreach (var item in models)
            {
                if (item.BrandId == brandId)
                {
                    dictionary.Add(item.BrandId, item.ModelName);
                }
            }
            comboBoxBrand.DataSource = new BindingSource(dictionary, null);
            comboBoxBrand.ValueMember = "Key";
            comboBoxBrand.DisplayMember = "Value";
        }

        public static void AddCarsToListView(ListView listView)
        {
            CarController _carController = new CarController();
            List<CarInfo> cars = _carController.GetCars();
            foreach (var car in cars)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.SubItems.Add(car.ModelName);
                lvi.SubItems.Add(car.ColorName);
                lvi.SubItems.Add(car.Price.ToString());
                listView.Items.Add(lvi);
            }
        }
    }
}
