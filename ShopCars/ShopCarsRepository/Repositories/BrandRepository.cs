using ShopCarsInfo;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace ShopCarsRepository.Repositories
{
    public class BrandRepository
    {
        private string _dbPath;

        public BrandRepository()
        {
            _dbPath = AppDomain.CurrentDomain.BaseDirectory + @"XML\Brands.xml";
        }

        public void SaveBrandData(BrandInfo brandInfo)
        {
            XmlDocument xmlEmloyeeDoc = new XmlDocument();
            xmlEmloyeeDoc.Load(_dbPath);

            XmlElement parentElement = xmlEmloyeeDoc.CreateElement("Brand");

            XmlElement brandId = xmlEmloyeeDoc.CreateElement("BrandId");
            brandId.InnerText = brandInfo.BrandId.ToString();
            XmlElement name = xmlEmloyeeDoc.CreateElement("Name");
            name.InnerText = brandInfo.Name;

            parentElement.AppendChild(brandId);
            parentElement.AppendChild(name);

            xmlEmloyeeDoc.DocumentElement.AppendChild(parentElement);
            xmlEmloyeeDoc.Save(_dbPath);
        }

        public List<BrandInfo> GetBrandsData()
        {
            var doc = XDocument.Load(_dbPath);
            var brandList = doc.Root.Elements().Select(x =>
            new BrandInfo()
            {
                BrandId = Convert.ToInt32(x.Element("BrandId").Value),
                Name = x.Element("Name").Value
            }).ToList();

            return brandList;
        }        
    }
}
