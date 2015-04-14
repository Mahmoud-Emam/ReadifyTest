using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace redifyservice
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in both code and config file together.
    public class RedPill : IRedPill
    {
        //static long[] fib = new long[100];
        //static int lastindex = 2;
        public long FibonacciNumber(long n)
        {
            
            bool isNetagive = false;
          
            
            if (n < 0)
            {
                n = n * -1;
                isNetagive = true;
            }
            if (n > 100)
                return 0;
            long a = 0, b = 1;
            
            long sum = 0;
            if (n == 0)
                return 0;
            if (n == 1) return 1;
            for (int i = 2; i <= n; i++)
            {
                sum = a + b;
                a = b;
                b = sum;
                
            }
            if(isNetagive)
                return sum*-1;
            return sum;
        }

        public string ReverseWords(string s)
        {
            
            StringBuilder res = new StringBuilder();
            string[] words = s.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                if(words[i] != " ")
                for (int j = words[i].Length - 1; j >= 0; j--)
                    res .Append( words[i][j]);
                res .Append( " ");
            }
            res.Remove(res.Length - 1,1);
            return res.ToString();
        }

        public Guid WhatIsYourToken()
        {
            return new Guid("104f05f0-b9c1-4e32-b94b-4bace9ee3c8d");
        }

        public TriangleType WhatShapeIsThis(int a, int b, int c)
        {

          
            if (a+b > c && a+c > b && b+c > a)
            {
                if (a == b && b == c)
                    return TriangleType.Equilateral;

                else if (a == b || b == c || a == c)
                    return TriangleType.Isosceles;    
                else
                    return TriangleType.Scalene;


            }

            return TriangleType.Error;            
                                   
        }
    }
}
