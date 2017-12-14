using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopCarsInfo
{
    public class BrandInfo
    {
        public int BrandId { get; set; }
        public string Name { get; set; }

        public List<ModelInfo> Models { get; set; }

        public BrandInfo()
        {
            Models = new List<ModelInfo>();
        }
    }
}
