using ShopCars.Controller;
using ShopCars.Helper;
using ShopCarsInfo;
using ShopCarsRepository.Repositories;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ShopCars
{
    public partial class FormCarListAdmin : Form
    {
        public FormCarListAdmin()
        {
            InitializeComponent();
            FormUtils.AddCarsToListView(lvCarList);
        }

        private void btnAddBrand_Click(object sender, EventArgs e)
        {
            FormAddNewBrand formAddNewBrand = new FormAddNewBrand();
            formAddNewBrand.Show();
        }

        private void btnAddModel_Click(object sender, EventArgs e)
        {
            FormAddNewModel formAddNewModel = new FormAddNewModel();
            formAddNewModel.Show();
        }

        private void btbAddCar_Click(object sender, EventArgs e)
        {
            FormAddCar formAddCar = new FormAddCar();
            formAddCar.ShowDialog();
            //TODO ListView
            if (formAddCar.DialogResult == DialogResult.OK)
            {
                
            }
        }

        private void lvCarList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
