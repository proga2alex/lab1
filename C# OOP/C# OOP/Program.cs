using System;

namespace C__OOP
{
    internal class Program
    {
        
        public class bantic
        {
            public uint ID;
            public uint price;
            public double size;
            public string name;
            public string type;
            public string color;
            public string brend;

            public uint Get_id()
            {
                Console.WriteLine(ID);
                return ID;
            }
        }

        // Основний базовий клас для поліморфізму
        public class user
        {
            public uint ID;
            public string role;
            public string email;
            public string name;
            public string phone_num;
            public string password;

            public virtual void i_am()
            {
                Console.WriteLine("я юзер");
            }
        }

        // Похідний клас admin, який перевизначає метод i_am()
        public class Admin : user
        {
            public int admin_level;

            public override void i_am()
            {
                Console.WriteLine("я адмін");
            }
        }

        // Абстрактний клас, який не може бути створений напряму
        public abstract class test_abstraction
        {
            public abstract void test_fun();
        }

        // Клас test успадковує test_abstraction і реалізує його метод
        public class test : test_abstraction
        {
            public override void test_fun()
            {
                Console.WriteLine("абстрактний метод");
            }
        }

        public class ADD // клас виключно для демонстрації статичного поліморфізму
        {
            public int add(int a, int b)
            {
                return (a + b);
            }
            public double add(double a, double b)
            {
                return (a + b);
            }
        }


        static void Main(string[] args)
        {
            
            user us1 = new user();
            user ad1 = new Admin(); 

            bantic bant01 = new bantic();
            test ts = new test(); // Абстрактний клас реалізовано через test
            ADD add = new ADD();

            bant01.ID = 1;
            bant01.price = 300;
            bant01.size = 14.88;
            bant01.name = "бантік червоний";
            bant01.type = "класичний";
            bant01.color = "red";
            bant01.brend = "bantic.inc";

            bant01.Get_id();
            us1.i_am(); // Виведе: "я юзер"
            ad1.i_am(); // Виведе: "я адмін" 
            ts.test_fun(); // Виведе: "абстрактний метод"
            Console.WriteLine(add.add(4, 5));
            Console.WriteLine(add.add(4.5, 5.75));
        }
    }
}
