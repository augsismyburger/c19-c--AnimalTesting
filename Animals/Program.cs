using System;

namespace Animals
{
    public class Animal
    {
        public string Name { get; set; }
        public string Species { get; set; }

        public string Walk()
        {
            return $"Walking at {this.Species} Speed";
        }
    }
    public class Dog : Animal
    {
        new public string Species { get; } = "Canine";
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
