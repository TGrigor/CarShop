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
    public partial class FormRegistration : Form
    {
        private RegistrationController _regController;
        public FormRegistration()
        {
            InitializeComponent();
            _regController = new RegistrationController();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            UserRegistrationInfo userInfo =  Maper.MapingRegistrationModel(textBoxLogin.Text, textBoxPass.Text, textBoxConfPass.Text);
            if (_regController.Registrate(userInfo))
            {
                //TODO Add message routing
                MessageBox.Show("Successfully completed.");
            }
            else
            {
                MessageBox.Show("Invalid registration!!!");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }
    }
}
