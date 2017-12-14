using ShopCars.Controller;
using ShopCars.Helper;
using ShopCarsInfo;
using System;
using System.Windows.Forms;

namespace ShopCars
{
    public partial class FormMain : Form
    {
        LoginController _loginController;
        public FormMain()
        {
            InitializeComponent();
            _loginController = new LoginController();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            UserLoginInfo userLoginInfo = Maper.MapingLoginModel(txtLogin.Text, txtPass.Text);
            if (_loginController.IsValidLogin(userLoginInfo))
            {
                User user = _loginController.GetUserRole(userLoginInfo);
                user.ShowUserInterface();
            }
            else
            {
                //TODO Add message routing
                MessageBox.Show("Invalid Login or Password!!!");
            }
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            //TODO change
            FormRegistration reg = new FormRegistration();
            reg.ShowDialog();
        }
    }
}
