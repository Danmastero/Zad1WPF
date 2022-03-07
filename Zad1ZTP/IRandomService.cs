using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad1ZTP
{
    public interface IRandomService
    {
        public void AddCoupon(string message);
        public string ReadRandomValue();      
        public bool HaveAvailableCoupons(List<string> list);
        public string ReadAllCoupons();

    }
}
