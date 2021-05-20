using System;

namespace CSharpProgramming
{
    class InheritancePrg
    {

        class A
        {
            static A() 
            {
                Console.WriteLine("Class A Static Block");
            }

            public  A()
            {
                Console.WriteLine("Class A Constructor");
            }


            public virtual void method()
            {
                Console.WriteLine("Class A Method");

            }

        }
        class B : A
        {
            static B()
            {
                Console.WriteLine("Class B Static Block");
            }

            public B()
            {
                Console.WriteLine("Class B Constructor");
            }
            public override void method()
            {
                Console.WriteLine("Class B Method");

            }
        }

        class C : B
        {
            static C()
            {
                Console.WriteLine("Class C Static Block");
            }

            public C()
            {
                Console.WriteLine("Class C Constructor");
            }

            public new void method()
            {
                Console.WriteLine("Class C Method");

            }

        }



        //static void Main(string[] args)
        //{
        //    A b = new C();
        //    b.method();
            
        //}
    }
}
