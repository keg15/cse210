using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation2 World!");
        Console.Clear();
        Address address1 = new Address("156 N Bird Street", "Rexburg", "Idaho", "USA");
        Customer customer1 = new Customer("Lisa Smith", address1);
        address1.CompleteAddress();
        Order order = new Order(customer1, address1);
        order.AddOrder("ball", 4565825, 3, 12);
        order.AddOrder("popcorn", 2159692, 1, 7);
        order.OrderList();
        order.ShippingLabel();
        order.PackingLabel();
        order.OverallCost();
        order.ToatlCost();

        Address address2 = new Address("N S Street", "Edmonton", "Alberta", "Canada");
        Customer customer2 = new Customer("Tim Ginto", address2);
        address1.CompleteAddress();
        Order order2 = new Order(customer2, address2);
        order2.AddOrder("yarn", 4889825, 5, 6);
        order2.AddOrder("ham", 2188992, 1, 12);
        order2.AddOrder("cheese", 2843342, 2, 5);
        order2.OrderList();
        order2.ShippingLabel();
        order2.PackingLabel();
        order2.OverallCost();
        order2.ToatlCost();
    }
}