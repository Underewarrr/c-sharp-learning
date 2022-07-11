using System;

namespace LearningCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            decimal y = 10.33m;
            double z = 10.33;
            float a = 10.33f;
            
            string text = "Hello Worl";
            text = text + 'd';
            
            int[] arr = new int[] {1, 2, 3, 4, 5};
            
            int result = 0;
            foreach (int i in arr)
            {
                result += i;
            }

            MyClass myClass = new MyClass();          
            myClass.name = "Rafhael";
            myClass.lastName = "Gonzalez";
            string classHello = myClass.SayHello();

            if (myClass.name == "Rafhael")
            {
                Console.WriteLine("Primeira Condição");
            }
            else if (myClass.name == "Vasya")
            {
                Console.WriteLine("Segunda Condição");
            }
            else
            {
                Console.WriteLine("Outra Condição");
            }

            Console.WriteLine("Valor de x: " + x);
            Console.WriteLine("Valor de y: " + y);
            Console.WriteLine("Valor de z: " + z);
            Console.WriteLine("Valor de a: " + a);
            Console.WriteLine("Valor de text: " + text);
            Console.WriteLine("Valor de arr: " + result);
            Console.WriteLine("Valor de classHello: " + classHello);
        }
    }

    class MyClass
    {
        public string name;
        public string lastName;
        public string SayHello()
        {
            return "Hello, " + name + " " + lastName;
        }
    }
}