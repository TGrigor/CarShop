using ShopCars.Controller;
using ShopCarsInfo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopCars
{
    public partial class FormAddNewModel : Form
    {
        private ModelController _modelController;
        private BrandController _brandController;
        private int _brandId;

        public FormAddNewModel()
        {
            InitializeComponent();
            _modelController = new ModelController();
            _brandController = new BrandController();
            AddBrandToList();
        }

        private void AddBrandToList()
        {
            List<BrandInfo> brands = _brandController.GetBrands();
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            foreach (var item in brands)
            {
                dictionary.Add(item.BrandId, item.Name);
            }
            comboBoxBrand.DataSource = new BindingSource(dictionary, null);
            comboBoxBrand.DisplayMember = "Value";
            comboBoxBrand.ValueMember = "Key";
            //comboBoxBrand.Items.AddRange(brands.Select(b=> b.Name).ToArray());
        }

        private void txtModel_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ModelInfo modelInfo = Helper.Maper.MapModelModel(_brandId, txtModel.Text);
            bool isValid = _modelController.SaveNewModel(modelInfo);

            if (isValid)
            {
                MessageBox.Show("Model Successfuly added!!");
            }
            else
            {
                MessageBox.Show("Invalid model name!!");
            }
        }

        private void FormAddNewModel_Load(object sender, EventArgs e)
        {

        }

        private void lblModel_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            _brandId = ((KeyValuePair<int, string>)comboBox.SelectedItem).Key;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //Hide();
            Close();
        }
    }
}
