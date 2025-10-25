using SelfRestaurant;

internal class Program
{
    private static void Main(string[] args)
    {
        User user = new User(1245,"Ali");
        User user2 = new User(8445,"AmirReza");

        order FirstOrder = new order();
        order LastOrder = new order();

        MenuItem food1 = new MenuItem() { Name = "Barg",Price = 400.000M};
        MenuItem food2 = new MenuItem() { Name = "Chenche",Price = 300.000M};

        MenuItem Drink = new MenuItem() { Name = "Water", Price = 10.000M};

        FirstOrder.AddItem(food1);
        FirstOrder.AddItem(food2);
        FirstOrder.AddItem(Drink);

        LastOrder.AddItem(food1);
        LastOrder.AddItem(food2);
        LastOrder.AddItem(food2);

        //Console.WriteLine(FirstOrder.CalculateTotal());

        FirstOrder.RemoveItem(food1);
        FirstOrder.AddItem(food2);
        FirstOrder.AddItem(food2);

        //FirstOrder.PrintReceipt(user);
        //LastOrder.PrintReceipt(user);      bug

        FirstOrder.PrintReceipt();
        //Console.WriteLine(FirstOrder.CalculateTotal());

        //Console.WriteLine(FirstOrder.BestSellingFood()); 
    }
}