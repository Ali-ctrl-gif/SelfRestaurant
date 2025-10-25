using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfRestaurant
{
    public class Restaurant
    {
        List<order>orders = new List<order>();
        

        public void AddOrder(order neworder)
        {
            orders.Add(neworder);
        }

    }
}
