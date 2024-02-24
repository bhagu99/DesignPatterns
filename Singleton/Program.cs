using DesignPatterns;

namespace DesignPatterns
{
    public class SingleTon
    {
        public static SingleTon Instance = new SingleTon();

        public readonly List<string> ListOfStates;
        public SingleTon()
        {
            ListOfStates = new List<string>();
            ListOfStates.Add("India");
            ListOfStates.Add("China");
            ListOfStates.Add("Nepal");
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            foreach (string itm in SingleTon.Instance.ListOfStates)
            {
                Console.WriteLine(itm);
            }
            Console.ReadLine();
        }
    }
}



