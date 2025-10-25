using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfRestaurant
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public User(int id, string Name)
        {
            this.Name = Name;
            this.Id = id;
        }
    }
}
