using ShopCars.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShopCars.Controller;

namespace ShopCars
{
    public partial class FormCarListClient : Form
    {
        private string _filePath = @"searchIcon.png";
        private BrandController _brandController;
        private ModelController _modelController;

        public FormCarListClient()
        {
            InitializeComponent();
            btnSearch.Image = Image.FromFile(_filePath);
            _brandController = new BrandController();
            _modelController = new ModelController();
            FormUtils.AddBrandToList(ref comboBoxBrands, ref _brandController);
        }

        private void comboBoxBrands_SelectedIndexChanged(object sender, EventArgs e)
        {
            int brandId = ((KeyValuePair<int, string>)comboBoxBrands.SelectedItem).Key;
            FormUtils.AddModelToList(brandId, ref comboBoxModels, ref _modelController);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //TODO Search logic and view in ListView
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            //TODO Buy logic and creat isDeleted bool in XML
        }
    }
}
