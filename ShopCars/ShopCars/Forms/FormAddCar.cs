using ShopCars.Controller;
using ShopCars.Helper;
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
    public partial class FormAddCar : Form
    {
        private CarController _carController;
        private BrandController _brandController;
        private ModelController _modelController;
        public FormAddCar()
        {
            InitializeComponent();
            _carController = new CarController();
            _brandController = new BrandController();
            _modelController = new ModelController();
            FormUtils.AddBrandToList(ref comboBoxBrand, ref _brandController);
            
        }

        private void pictureBoxColor_Click(object sender, EventArgs e)
        {
            colorDialog.ShowDialog();
            pictureBoxColor.BackColor = colorDialog.Color;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            CarInfo carInfo = Maper.MapingCarModel
                (comboBoxModel.Text, Int32.Parse(txtPrice.Text), pictureBoxColor.BackColor.Name);
            bool isValid = _carController.AddCar(carInfo);
            if (isValid)
            {
                DialogResult = DialogResult.OK;
                MessageBox.Show("Car Successfuly added!!");
            }
            else
            {
                MessageBox.Show("Invalid model name!!");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //Hide();
            Close();
        }

        private void comboBoxBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            int brandId = ((KeyValuePair<int, string>)comboBoxBrand.SelectedItem).Key;
            FormUtils.AddModelToList(brandId, ref comboBoxModel, ref _modelController);
        }
    }
}
