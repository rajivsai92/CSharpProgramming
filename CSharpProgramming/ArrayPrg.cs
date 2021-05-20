using System;
using System.Collections.Generic;

namespace CSharpProgramming
{
    class ArrayPrg
    {
        public void primeNumbers()
        {

            List<int> list = new List<int>();
            
            for (int i = 0; i < 10; i++)
            {
                int flag = 1;
                if (i == 0 || i == 1)
                    continue;

                for (int j = 2; j < i; j++)
                {
                    if(i%j==0)
                    {
                        flag = 0;
                        break;
                    }
                }
                if (flag == 1)
                    list.Add(i);


            }



        }
        public void AmstrongNumber()
        {

            int i = 153;
            int temp = i;
            int rem = 0;
            int res = 0;
            while(i>0)
            {
                rem = i % 10;
                res = (rem * rem * rem) + res;
                i = i / 10;
            }

            string isPolindrome = (res == temp) ? "Amstrong" : "Not amstrong";

        }
        public void Polindrome()
        {
            int i = 121;
            int temp = i;
            int rem = 0;
            int res = 0;
            while (i > 0)
            {
                rem = i % 10;
                res = (res * 10) + rem;
                i = i / 10;
            }

            string isPolindrome = (res == temp) ? "Polindorme" : "Not Polindrome";


        }
        public void Sorting()
        {
            int[] a = {4,7,8,3,9,1,0};

            for (int i = 0; i < a.Length-1; i++)
            {
                if(a[i]>a[i+1])
                {
                    int temp = a[i + 1];
                    a[i + 1] = a[i];
                    a[i] = temp;
                    i = -1;
                }
            }

        }
        public void Min_Max_In_Array()
        {
            int[] a = {4,7,8,3,9,1,0};
            int min = a[0];int max = a[0];

            for (int i = 0; i < a.Length; i++)
            {
                if(a[i]<min)
                {
                    min = a[i];
                }
                if(a[i]>max)
                {
                    max = a[i];
                }
            }



        }
        public void NegativeNumbersBeoforePostNum()
        {
            int[] a = {-4, 7, -8, 3, -9, -1, 0 };

            int j = 0, temp;
            for (int i = 0; i < a.Length; i++)
            {

                if(a[i]<0)
                {
                     temp = a[i];
                    a[i] = a[j];
                    a[j] = temp;
                    j++;
                }

            }
        }
        public void AlternateNegNumAndPostNum()
        {

            int[] a = { -4, 7, -8, 3, 9, 1, 0 };
            int j = 0;

            for (int i = 0; i < a.Length; i++)
            {
                if(a[i]<0)
                {
                    int temp = a[i];
                    a[i] = a[j];
                    a[j] = temp;
                    j++;
                }
            }
            int k = 0;
            while (k < a.Length && j < a.Length)
            {

                int temp = a[k];
                a[k] = a[j];
                a[j] = temp;
                k = k + 2;
                j = j + 1;


            }

        }
        public void MaxContinousSubArray()
        {

            int[] a = {-2,-3,4,-1,-2,1,5,-3 };
            int max = 0;
            int start = 0, end = 0;

            for (int i = 0; i < a.Length; i++)
            {
                int sum = 0;

                for (int j = i; j < a.Length; j++)
                {
                    sum += a[j];


                    if (sum>max)
                    {

                        max = sum;
                        start = i;
                        end = j;

                       
                    }
                }


            }




        
        }
        public void AlternateMinMaxNum()
        {
            int[] a = { -4, 7, -8, 3, 9, 1, 0 };

            int[] b = new int[a.Length];
            for (int i = 0; i < a.Length - 1; i++)
            {
                if (a[i] > a[i + 1])
                {
                    int temp = a[i + 1];
                    a[i + 1] = a[i];
                    a[i] = temp;
                    i = -1;
                }
            }


            int large = a.Length - 1;
            int small = 0;
            bool flag = true;
            for (int i = 0; i < a.Length; i++)
            {

                if (flag)
                {
                    b[i] = a[small++];
                }
                else
                {
                    b[i] = a[large--];
                }

                flag = !flag;
            }

        }
        public void ThreeLargestInArray()
        {
            int[] a = { -4, 7, -8, 3, -9, -1, 0 };

            int f=0, s=0, t=0;
            for (int i = 0; i < a.Length; i++)
            {

                if (a[i] > f)
                {
                    t = s;
                    s = f;
                    f = a[i];
                    
                }
                else if(a[i]>s)
                {
                    t = s;
                    s = a[i];

                }
                else
                {
                    t = a[i];
                }


            }

        }
        public void SubArrayCountEqualsToZero()
        {

            int[] a = {2,8,-3,-5,2,-4,6,1,2,-3,4,-1,-3};

           
            int start, end;

            for (int i = 0; i < a.Length; i++)
            {
                int sum = 0;
                for (int j = i; j < a.Length; j++)
                {
                    sum += a[j];
                    if(sum==5)
                    {
                        start = i;
                        end = j;
                        Console.WriteLine("Sum of Sub array is zero for element start at " + start + "end at" + end);

                    }



                }

            }


        }


        //static void Main(string[] args)
        //{
        //    ArrayPrg a = new ArrayPrg();
        //    //a.primeNumbers();
        //    //a.AmstrongNumber();
        //    //a.Polindrome();
        //    //a.Sorting();
        //    //a.Min_Max_In_Array();
        //    // a.NegativeNumbersBeoforePostNum();
        //    //a.AlternateNegNumAndPostNum();
        //    // a.SubArrayCountEqualsToZero();
        //    //a.ThreeLargestInArray();
        //    a.MaxContinousSubArray();
        //}
    }
}
