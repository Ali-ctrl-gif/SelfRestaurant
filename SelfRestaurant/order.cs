using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfRestaurant
{
    public class order
    {
        List<MenuItem> menuItems = new List<MenuItem>();
        //User user;
        
        public DateTime CreatedAt {  get; set; }
        public decimal CalculateTotal()
        {
            var Total = menuItems.Sum(x => x.Price);
            return Total;
        }
        public void AddItem(MenuItem item)
        {
            menuItems.Add(item);
        }
        public void GetTotalAmount()
        {
            menuItems.Sum(x => x.Price);
        }
        public void RemoveItem(MenuItem item)
        {
            menuItems.Remove(item);
        }
        public void PrintReceipt()
        {
            Console.WriteLine("Printing receipt...");
            foreach (var item in menuItems)
            {
                Console.WriteLine($"{item.Name}------{item.Price}");
            }
            Console.WriteLine();
            Console.WriteLine($"Total : {CalculateTotal()}");
        }
        public List<MenuItem> GetMenuItems()
        {
            return menuItems;
        }
    }
}
