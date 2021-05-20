using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgramming
{/// <summary>
/// GEneric singleTon 
/// </summary>
/// <typeparam name="T"></typeparam>
    public sealed class SingleTon<T>  where T : class , new()
    {
        static int count = 0;
        private static readonly T instance = new T();

        public static  T GetInstance
        {
            get
            {
                //Type t = typeof(T);
                //var info = t.GetConstructors();


                //(T)Activator.CreateInstance(t, true);
                return instance;
            }

        }
        private SingleTon()
         {
            count++;
            Console.WriteLine(count);
        
        }



    }
    public sealed class SingleTon
    {

         static int count = 0;

        private static readonly SingleTon instance = new SingleTon();

        public static SingleTon GetInstance
        {
            get
            {
                return instance;
            }

        }
        private SingleTon() {


            count++;
            Console.WriteLine(count);
            
        }



    }

    public class A
    {
        public void methodA()
        {

        }
    }
   public  class B
    {

    }

    public class C
    {
        public static void Main(string[] args)
        {
            //var f = SingleTon.GetInstance;
            //var g = SingleTon.GetInstance;


            var h = SingleTon<A>.GetInstance;
            var j = SingleTon<A>.GetInstance;


           

        }

    }

}
