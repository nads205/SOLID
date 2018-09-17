using System;

namespace Solid_Princicles_Class_Library
{
    class Liskov___Correctly_Done
    {
        void Main()
        {
            Apple apple = new Orange();
            Console.WriteLine(apple.GetColor());
        }

        public abstract class Fruit
        {
            public abstract string GetColor();
        }


        public class Apple : Fruit
        {
            public override string GetColor()
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
