using System.Globalization;

namespace task2
{
    public interface isSpicy
    {
        public int spiciness { get; set; }
    }
    abstract class food
    {
        public string calories;
    }
    abstract class snack : solidfood
    {

    }
    class breadsticks : snack
    {

    }
    abstract class water : food
    {
        public int volume;
    }
    abstract class solidfood : food
    {
        
    }
    class macandcheese : solidfood
    {

    }
    class pizza : solidfood, isSpicy
    {
        public int spiciness { get; set; }
    }
    class soda : carbonatedwater
    {

    }
    class carbonatedwater : water
    {
        public int carbonationIntensity;
    }
    class OJ : water
    {

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}