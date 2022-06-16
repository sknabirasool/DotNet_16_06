using System;

namespace ASP_CORE_16_06
{
    // method overload example
    public class MethodLoad
    {
        public void overload(int a,int b)
        {
            Console.WriteLine("Overload data"+a + b);
        }
        public void overload(int a,int b,int c)
        {
            Console.WriteLine("Overload Data2"+a + b + c);
        }
    }
    //method overload example 2

    public class animal
    {
        public void eat()
        {
            Console.Write("Animal eat Gross");
        }
    }
    public class Dog:animal
    {
        public void eat()
        {
            Console.WriteLine("Dog Eat Bones");
        }
    }


    // single inheritance 
    public class A
    {
        public string color = "black";
        public string name = "Nabi";
        public int age = 25;
    }
    public class D : A
    {
        public void getdata(string name)
        {
            Console.WriteLine("" + name);
        }
    }

    // factorial number 
    public class Facto
    {
        int fact = 1;
        public void cal(int n)
        {

            for(int i=1;i<=n;i++)
            {
                fact = fact * i;
            }
            Console.WriteLine("\n Factorial Number is " + fact);
        }
    }
    
    //while loop

    public class whileloop
    {
        public void whileData(int n)
        {
            int i = 1; 
            while(i<=n)
            {
                Console.WriteLine("while data "+i);
                i++;
            }
        }
    }

    //For loop

    public class forloop
    {
        public void fordemo(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("for data " + i);
            }
        }
    }

    public abstract class Shape
    {
        public abstract void draw();
    }
    

    public  class B:D
    {
       public static void Main(string[] args)
        {
            D a = new D();
            MethodLoad load = new MethodLoad();

            animal ani = new animal();

            Dog d = new Dog();

            Facto f = new Facto();
            whileloop w = new whileloop();
            forloop fr = new forloop();


            Console.WriteLine("I AM A Main Method");
            Console.WriteLine("My Name is"+a.name);
            Console.WriteLine("My age is "+a.age);
            Console.WriteLine("My Color is " + a.color);
            a.getdata("NABI RASOOL SHAIK");
            load.overload(12,30);
            load.overload(12, 34, 40);
            d.eat();
            ani.eat();
            f.cal(5);
            w.whileData(5);
            fr.fordemo(10);

        }
    }
}
