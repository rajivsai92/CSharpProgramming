using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpProgramming
{
    class StringPrg
    {

        public void Reverse_String()
        {

            string a = "Rajiv Sai";

            string b =  new string(a.Reverse().ToArray());


        }
        public void Unique_Duplicates_In_String()
        {
            string a = "Rajiv Sai Ballapuram";
            StringBuilder duplicate = new StringBuilder();
            StringBuilder Unique = new StringBuilder();
            foreach (char item in a)
            {
                if(a.Count(x=>x==item)>1)
                {
                    if(duplicate.ToString().IndexOf(item)==-1)
                    {
                        duplicate.Append(item);

                    }
                }
                else
                {
                    Unique.Append(item);
                    
                }

               
            }

            string h = duplicate.ToString();
            string j = Unique.ToString();


        }
        public void PrintWordsInStringBasedOnLengthInIncreasingOrder()
        {

            string a = " abcd efg hi j";
            StringBuilder sb = new StringBuilder();
            Dictionary<string, int> dic1 = new Dictionary<string, int>();

            string[] b = a.Split(' ');

            foreach (var item in b)
            {
                if(!dic1.ContainsKey(item))
                {
                    dic1.Add(item, item.Length);

                }
            }


            foreach (KeyValuePair<string, int > item in dic1.OrderBy(y=>y.Value))
            {
                sb.Append(item.Key.ToString()+" ");
            }




        }
        public void Max_Occurance_Of_Char_In_String()
        {
            string a = "rajiv sai Ballapuram";

            Dictionary<char, int> dic1 = new Dictionary<char, int>();
            Dictionary<char, int> dic2 = new Dictionary<char, int>();
            foreach (char item in a)
            {
                if(!dic1.ContainsKey(item))
                {
                    dic1.Add(item, a.Count(x => x == item));
                }           
            }
            foreach (KeyValuePair<char,int> item in dic1.OrderBy(x=>x.Value))
            {
                dic2.Add(item.Key, item.Value);
            }
            

            char f = dic2.Keys.Last();
            int g = dic2.Values.Last();

        }
        public void Polindrome()
        {
            string a = "madam";
            string b = new string(a.Reverse().ToArray());
            if(a==b)
            {
                Console.WriteLine("given string is polindrome");
            }
            else
            {
                Console.WriteLine("given string is not polindrome");

            }
        }
        public void ReverseString_PreserveSpaces()
        {
            string a = "abcd efg hi j";

            StringBuilder sb = new StringBuilder(new string(a.Replace(" ","").Reverse().ToArray()));

            for (int i = 0; i < a.Length; i++)
            {
                if(a[i]==' ')
                {
                    sb.Insert(i, " ");

                }
            }

        }
        public void Substrings()
        {

            string a = "rajiv";
            List<string> lst = new List<string>();
            for (int i = 1; i < a.Length; i++)
            {
                for (int j = 0; j <=a.Length-i; j++)
                {
                    lst.Add(a.Substring(j,i));
                }
            }


        }
        public void CountOf_Int_In_String()
        {
            string a = "r1a2j3i4v5";
            int count = 0;
            a.ToList<char>().ForEach(e =>
             {
                 if (char.IsDigit(e))
                 {
                     count += int.Parse(e.ToString());
                 }

             }) ;


        }



        //static void Main(string[] args)
        //{

        //    StringPrg p = new StringPrg();
        //    //p.Reverse_String();
        //    //p.Unique_Duplicates_In_String();
        //    //p.PrintWordsInStringBasedOnLengthInIncreasingOrder();
        //    //p.Max_Occurance_Of_Char_In_String();
        //    //p.Polindrome();
        //    // p.ReverseString_PreserveSpaces();
        //    //p.Substrings();
        //    //p.CountOf_Int_In_String();
        //}
    }
}
