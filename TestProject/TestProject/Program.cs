using System.Runtime.ExceptionServices;
using TestProject;

internal class Program
{
    public static void Main(string[] args)
    {

        Console.WriteLine("Hello, World!");
        child C = new child(5, 6);
        Test obj = new Test();
        Console.WriteLine("tjdytw",obj.FirstName);
        int s, p,sub;
        sub = Test.cal(5, 6, out s, out p);
        Console.WriteLine("{0} {1} {2}",sub, s, p);
    }
}

namespace TestProject
{
    class Test
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }

        public static int cal(int f, int s, out int su, out int pro)
        {
            {
                su = f + s;
                pro = f * s;
                return f - s;
            }

        }
    }

    class Parent
    {
        int x;
        int y;
       public Parent()
        {
            this.x = 1;
            this.y = 2; 
            Console.WriteLine("In parent"+x + "," + y);

        }
        public Parent(int x , int y)
        {
            this.x = x;
            this.y = y;
        }
    }
    class child : Parent
    {
        public int x;
        public int y;
        public child(int x, int y)
        {
            this.x = x;
            this.y = y;
            Console.WriteLine("In child "+ x + "," + y);

        }
    }


}