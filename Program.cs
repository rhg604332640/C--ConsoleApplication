using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
           object o = Facroty.GetObject();
           //SecondType st = (SecondType)o;
           try
           {
               MyType t = (MyType)o;
               if (t!=null)
               {
                   Console.WriteLine("it's a MyType");
               }
               else
               {
                   Console.WriteLine("a null reference fail");
               }
           }
           catch (Exception e)
           {

               Console.WriteLine(e.Message);
           }

           Console.Read();
        }
    }

    public class SecondType
    {
        private MyType value;

        public static implicit operator MyType(SecondType t)
        {
            return t.value;
        }
    }

    public class MyType
    {

    }

    public class Facroty
    {
        public static object GetObject(){
            return new SecondType();
        }
    }
}
