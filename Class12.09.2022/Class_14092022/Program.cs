using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_14092022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int start,end;
            start = Int32.Parse(Console.ReadLine());
            end = Int32.Parse(Console.ReadLine());
            Console.WriteLine(MyClass.MyMethod(start,end));
            Console.ReadLine(); */
            /*int firstFib = 0, secondFib =1;
            Fibonacci(firstFib, secondFib, Int32.Parse(Console.ReadLine()));*/
            Plane pl = new Plane("Сутулов");
            Plane pl1 = new Plane("Собаков", 2010);
            Plane pl2 = new Plane("СобакоСутулов", 2022, "ТуполевыйСамолетостроительный", "Слаболетательный");
            Console.WriteLine(pl.NameAndType());
            Console.WriteLine(pl.NameAndType(true));
            Console.WriteLine(pl.NameAndType(false));
            Console.WriteLine(pl1.NameAndType());
            Console.WriteLine(pl1.NameAndType(true));
            Console.WriteLine(pl1.NameAndType(false));
            Console.WriteLine(pl2.NameAndType());
            Console.WriteLine(pl2.NameAndType(true));
            Console.WriteLine(pl2.NameAndType(false));
        }
        /*static void Fibonacci(int a, int b, int endNumber)
        {
            int result = 0;
            result = a + b;
            if (result != endNumber && result < endNumber)
            {
                Fibonacci(b, result, endNumber);
            }
            else if (result == endNumber) 
            {
                Console.WriteLine("Это число Фибоначчи!");
                Console.WriteLine("Число простое:{0}", Simple(result));
            }
            else
            {
                Console.WriteLine("Это не число Фибоначчи!");
                Console.WriteLine("Число простое:{0}", Simple(result));
            }
        }
        static bool Simple(int a)
        {
            if (a% 2 == 0||a%3==0||a%5==0||a%7==0||a%9==0) { return false; }
            else { return true; }
        }*/

        

    }
    class Plane
    {
        public string _name { get; set; }
        public string _manufacture { get; set; }
        public int _year { get; set; }
        public string _type { get; set; }
        public Plane(string name)
        {
            _name = name;
            _manufacture = "Аэрофлот";
            _year = 2005;
            _type = "Пассажирский";
        }
        public Plane(string name, int year)
        {
            _name = name;
            _manufacture = "Аэрофлот";
            _year = year;
            _type = "Пассажирский";
        }
        public Plane(string name, int year, string manufucture, string type)
        {
            _name = name;
            _manufacture = manufucture;
            _year = year;
            _type = type;
        }
        public string NameAndType()
        {
            return this._name + this._type;
        }
        public string NameAndType(bool manufacture)
        {
            if (manufacture) return this._name + this._type + this._manufacture;
            else { return this._name + this._type; }

        }


        
    }
    /*class MyClass
        {
            public static int MyMethod(int start,int end )
            {
                int result = 1;
                for(int i = start; i <= end; i++)
                {
                    result*=i;
                }
                return result;
            }
        }*/
}
