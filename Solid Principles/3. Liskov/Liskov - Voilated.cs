using System;

namespace Solid_Princicles_Class_Library
{
    class Liskov___Voilated
    {
        static void Main(string[] args)
        {
            Apple apple = new Orange();
            Console.WriteLine(apple.GetColor());
        }

        public class Apple
        {
            public virtual string GetColor()
            {
                return "Red";
            }
        }

        public class Orange : Apple
        {
            public override string GetColor()
            {
                return "Orange";
            }
        }
    }

}
