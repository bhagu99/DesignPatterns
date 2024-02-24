

using System.ComponentModel;
using System.Drawing;

public class Pizza
{
    private  List< string> Ingredients { get; set; }
    private int Size { get;}
    public Pizza(int size)
    {
        Size = size;
        Ingredients = new List< string>();
        Ingredients.Add("Bread");
    }
    public Pizza AddCheese()
    {
        Ingredients.Add("Cheese");
        return this;
    }

    public Pizza AddOlives()
    {
        Ingredients.Add("Olives");
        return this;
    }

    public string GetIngredients()
    {
        string retVal = $"Size: {Size} inch.";
        foreach(string itm in Ingredients)
        {
            retVal += itm + "\n";
        }
        return retVal;
    }
}


public class Program
{
    public static void Main(string[] args)
    {
        var cheesePizza = new Pizza(6).AddCheese().AddOlives();
        Console.WriteLine(cheesePizza.GetIngredients());

        var pizza = new Pizza(4).AddOlives();
        Console.WriteLine(pizza.GetIngredients());

        Console.ReadLine();
    }
}
