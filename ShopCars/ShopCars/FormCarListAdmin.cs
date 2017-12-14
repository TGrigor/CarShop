using System;
using System.Windows.Forms;

namespace ShopCars
{
    public partial class FormCarListAdmin : Form
    {
        public FormCarListAdmin()
        {
            InitializeComponent();
        }

        private void pictureBoxColor_Click(object sender, EventArgs e)
        {
            colorDialog.ShowDialog();
            pictureBoxColor.BackColor = colorDialog.Color;
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
    }
}
