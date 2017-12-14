using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopCars.Helper
{
    public static class GetUnicId
    {
        static Random rand = new Random();
        public static int GetNewGuid()
        {
            //TODO change get unic id logic
            return rand.Next();
        }
    }
}
