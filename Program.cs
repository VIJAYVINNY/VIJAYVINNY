using System;

namespace DelegateProject
{
    public delegate void Adddelegate(int x, int y);
    public delegate string saydelegates(string str);
    class Program
    {
        public void AddNums(int a,int b)
        {
            Console.WriteLine(a + b);
        }
        public static  string sayHello(string name)
        {
            return "Hello" + name;
        }
        static void Main()
        {
            Program p = new Program();
            Adddelegate ad = new Adddelegate(p.AddNums);
            ad.Invoke(122, 122);
            saydelegates sd = new saydelegates(Program.sayHello);
            string str = sd.Invoke("Raju");
        }
       
    }
}
