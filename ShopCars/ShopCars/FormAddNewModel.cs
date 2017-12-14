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
        ModelController modelController;
        BrandController brandController;

        public FormAddNewModel()
        {
            InitializeComponent();
            modelController = new ModelController();
            brandController = new BrandController();
            AddBrandToList();
        }

        private void AddBrandToList()
        {
            List<BrandInfo> brands = brandController.GetBrands();
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
            //TODO remove hard code get brand ID
            ModelInfo modelInfo = Helper.Maper.MapModelModel(0, txtModel.Text);
            bool isValid = modelController.SaveNewModel(modelInfo);

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
            //ComboBox comboBox = sender as ComboBox;
            //int a = ((KeyValuePair<int, string>)comboBox.SelectedItem).Key;
            //string b = ((KeyValuePair<int, string>)comboBox.SelectedItem).Value;
        }
    }
}
