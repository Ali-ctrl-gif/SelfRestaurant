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
        public string BestSellingFood()
        {
            List<MenuItem> allitems = orders.SelectMany(o => o.GetMenuItems()).ToList();
            var BestSelling = allitems.GroupBy(x => x.Name)
                .Select(g => new { Name = g.Key, Count = g.Count() })
                .OrderByDescending(g =>g.Count)
                .FirstOrDefault();
            if(BestSelling == null)
            {
                Console.WriteLine("No orders have been placed.");
            }
            return $"BestSelling Food : {BestSelling.Name} {BestSelling.Count} Nembers";
        }

    }
}
