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
    public partial class FormAddNewBrand : Form
    {
        BrandController _brandController;

        public FormAddNewBrand()
        {
            InitializeComponent();
            _brandController = new BrandController();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            BrandInfo brandInfo = Helper.Maper.MapingBrandModel(txtBrand.Text);
            if (_brandController.AddBrand(brandInfo))
            {
                MessageBox.Show("Brand Successfuly added!!");
            }
            else
            {
                MessageBox.Show("Invalid brand name!!");
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //Hide();
            Close();
        }
    }
}
