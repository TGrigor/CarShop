using ShopCarsInfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace ShopCarsRepository.Repositories
{
    public class CarRepository
    {
        private string _dbPath;
        public CarRepository()
        {
            _dbPath = AppDomain.CurrentDomain.BaseDirectory + @"XML\Cars.xml";
        }

        public void SaveCarData(CarInfo carInfo)
        {
            XmlDocument xmlEmloyeeDoc = new XmlDocument();
            xmlEmloyeeDoc.Load(_dbPath);

            XmlElement parentElement = xmlEmloyeeDoc.CreateElement("Car");

            XmlElement carId = xmlEmloyeeDoc.CreateElement("CarId");
            carId.InnerText = carInfo.CarId.ToString();
            XmlElement modelName = xmlEmloyeeDoc.CreateElement("ModelName");
            modelName.InnerText = carInfo.ModelName;
            XmlElement price = xmlEmloyeeDoc.CreateElement("Price");
            price.InnerText = carInfo.Price.ToString();
            XmlElement color = xmlEmloyeeDoc.CreateElement("ColorName");
            color.InnerText = carInfo.ColorName.ToString();

            parentElement.AppendChild(carId);
            parentElement.AppendChild(modelName);
            parentElement.AppendChild(price);
            parentElement.AppendChild(color);

            xmlEmloyeeDoc.DocumentElement.AppendChild(parentElement);
            xmlEmloyeeDoc.Save(_dbPath);
        }

        public List<CarInfo> GetCarsData()
        {
            var doc = XDocument.Load(_dbPath);
            var carList = doc.Root.Elements().Select(x =>
            new CarInfo()
            {
                CarId = Convert.ToInt32(x.Element("CarId").Value),
                ModelName = x.Element("ModelName").Value,
                Price = Convert.ToInt32(x.Element("Price").Value),
                ColorName = x.Element("ColorName").Value,
            }).ToList();

            return carList;
        }
        
    }
}
