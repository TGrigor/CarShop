using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopCarsInfo;
using System.Xml;
using System.Xml.Linq;

namespace ShopCarsRepository.Repositories
{
    public class ModelRepository
    {

        private string _dbPath;

        public ModelRepository()
        {
            _dbPath = AppDomain.CurrentDomain.BaseDirectory + @"XML\Models.xml";
        }

        public void SaveModelData(ModelInfo modelInfo)
        {
            XmlDocument xmlEmloyeeDoc = new XmlDocument();
            xmlEmloyeeDoc.Load(_dbPath);

            XmlElement parentElement = xmlEmloyeeDoc.CreateElement("Brand");

            XmlElement brandId = xmlEmloyeeDoc.CreateElement("BrandId");
            brandId.InnerText = modelInfo.BrandId.ToString();
            XmlElement ModelName = xmlEmloyeeDoc.CreateElement("ModelName");
            ModelName.InnerText = modelInfo.ModelName;

            parentElement.AppendChild(brandId);
            parentElement.AppendChild(ModelName);

            xmlEmloyeeDoc.DocumentElement.AppendChild(parentElement);
            xmlEmloyeeDoc.Save(_dbPath);
        }

        public List<ModelInfo> GetModelsData()
        {
            var doc = XDocument.Load(_dbPath);
            var modelList = doc.Root.Elements().Select(x =>
            new ModelInfo()
            {
                BrandId = Convert.ToInt32(x.Element("BrandId").Value),
                ModelName = x.Element("ModelName").Value
            }).ToList();

            return modelList;
        }
    }
}
