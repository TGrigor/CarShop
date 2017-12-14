using ShopCarsInfo;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace ShopCarsRepository.Repositories
{
    public class UserAuthenticationRepository
    {
        private string _dbPath;

        public UserAuthenticationRepository()
        {
            _dbPath = AppDomain.CurrentDomain.BaseDirectory + @"XML\Users.xml";
        }

        public bool LoginExists(string login)
        {
            var doc = XDocument.Load(_dbPath);
            return doc.Root.Elements().Where(u => u.Element("Login").Value == login).Any();
        }

        public bool IsUserDataValid(UserLoginInfo userLoginInfo)
        {
            var doc = XDocument.Load(_dbPath);
            return doc.Root.Elements().Select(x => new UserLoginInfo()
            {
                Login = x.Element("Login").Value,
                Password = x.Element("Password").Value
            }).Where(u => u.Login == userLoginInfo.Login && u.Password == userLoginInfo.Password).Any();
        }

        public UserInfo GetUserData(UserLoginInfo userloginInfo)
        {
            var doc = XDocument.Load(_dbPath);
            var users = doc.Root.Elements().Select(x => 
            new UserInfo()
            {
                Login = x.Element("Login").Value,
                Password = x.Element("Password").Value,
                UserId = Convert.ToInt32(x.Element("UserId").Value),
                HasAdminPermission = Convert.ToBoolean(x.Element("HasAdminPermission").Value)
            }).ToList();

            return users.Where(u => u.Login == userloginInfo.Login && u.Password == userloginInfo.Password).FirstOrDefault();
        }

        public void SaveRegistrationDate(UserRegistrationInfo userRegInfo)
        {
            XmlDocument xmlEmloyeeDoc = new XmlDocument();
            xmlEmloyeeDoc.Load(_dbPath);

            XmlElement parentElement = xmlEmloyeeDoc.CreateElement("User");

            XmlElement userId = xmlEmloyeeDoc.CreateElement("UserId");
            userId.InnerText = userRegInfo.UserId.ToString();
            XmlElement login = xmlEmloyeeDoc.CreateElement("Login");
            login.InnerText = userRegInfo.Login;
            XmlElement password = xmlEmloyeeDoc.CreateElement("Password");
            password.InnerText = userRegInfo.Password;
            XmlElement hasAdminPermission = xmlEmloyeeDoc.CreateElement("HasAdminPermission");
            hasAdminPermission.InnerText = "false";

            parentElement.AppendChild(userId);
            parentElement.AppendChild(login);
            parentElement.AppendChild(password);
            parentElement.AppendChild(hasAdminPermission);

            xmlEmloyeeDoc.DocumentElement.AppendChild(parentElement);
            xmlEmloyeeDoc.Save(_dbPath);
        }
    }
}
