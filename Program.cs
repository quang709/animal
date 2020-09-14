using System;

namespace animal
{
    class Program
    {
        static void Main(string[] args)
        {
            string sound;
            string nameanimal;
            
            Console.WriteLine("nhap ten  animal:");
             nameanimal = Console.ReadLine();
            Console.WriteLine("nhap tieng keu  animal:");
            sound = Console.ReadLine();

            Animal animal = new Animal(nameanimal,sound);
            Console.WriteLine(animal.GetInfo(nameanimal,sound));
        }

       
    }
}
