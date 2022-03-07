using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad1ZTP
{
    internal class CouponManager : IRandomService
    {
       
        private List<string>? _List { get; set; }
       

        public CouponManager()
        {
            _List = new List<string>();
        } 
        public CouponManager(List<string> list)
        {
            _List = list;
        }

        public void AddCoupon(string message)
        {
            if(message != "")
            _List.Add(message);
        }
        public bool HaveAvailableCoupons(List<string> list)
        {
            if (_List.Count > 0) return true;
            return false;  
        }

        public string ReadAllCoupons()
        {
            string listContentStringFormat = null;

            if(HaveAvailableCoupons(_List))
                foreach(var x in _List)
                {
                    listContentStringFormat += x + "\n";
                }
            Console.WriteLine(listContentStringFormat);

            return listContentStringFormat;

        }

        public string ReadRandomValue()
        {
            string randomString = null;
            if(HaveAvailableCoupons(_List) is false)
            {
                randomString = "Brak kuponów w maszynie losującej!";
                return randomString;

            }
            Random r = new Random();
            int index = r.Next(_List.Count);
                randomString = _List[index];
            _List.RemoveAt(index);

            return randomString;
        }      
    }
}
