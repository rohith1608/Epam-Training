using System;
namespace FactoryMethod
{
    abstract class Fooditems
    {
        public int rate;
        public abstract void ItemRate();
        public  void PrintRate(int quantity)
        {
            Console.WriteLine(rate * quantity);
        }
       
    }
    class Burger : Fooditems
    {
        public override void ItemRate()
        {
            rate=100;
        }
    }
    class Pizza : Fooditems
    {
        public override void ItemRate()
        {
            rate=200;
        }
    }
    class Fooditemsfactory
    {
        public Fooditems GetFoodItemsString(String name)
        {
            if (name=="Burger")
            {
                return new Burger();
            }
            else if (name == "Pizza")
            {
                return new Pizza();
            }
            else
            {
                return null;
            }
        }
    }
    class program
    {
        static void main(String[] args)
        {
            Fooditemsfactory factory = new Fooditemsfactory();
            int quantity=Convert.ToInt32(Console.ReadLine());
            String Item=Console.ReadLine();
            Fooditems fooditems=factory.GetFoodItemsString(Item);
            fooditems.PrintRate(quantity);

        }
    }

}