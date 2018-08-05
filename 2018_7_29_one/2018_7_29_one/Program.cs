using System;

namespace _2018_7_29_one
{
    class Program
    {
        static void Main(string[] args)
        {
            // Day 1. 

            // 숫자를 나타내는 공간은 int 
            int x = 100; //변수variable
            int y = 200; //변수
            int z = y - x;

            int sum3 = 0;

            int W = 1;

            sum3 = sum3 + W;

            int a = 2;

            sum3 = sum3 + a; 

            int s = 3;

            sum3 = sum3 + s;

            int d = 4;

            sum3 = sum3 + d;

            int q = 5;

            sum3 = sum3 + q;

            Console.WriteLine("sum3 는 " + sum3);


        
            int e = W + a + s + d + q;

            Console.WriteLine("값은: " + e);
            //        v[0], v[1], v[2], v[3], v[4], v[5] , v[6], v[7],  v[8], v[9]
            int[] v = { 1 , 2   , 3    , 4  , 5   , 6    , 7   , 8    , 9   , 10 }; // int 다음에 [] 여러개를 선언하겠다. 배열 [0] ~ [9]

            Console.WriteLine("배열 첫번째: " + v[0]); // 인덱스 
            Console.WriteLine("배열 두번쨰:" + v[1]);
            Console.WriteLine("배열 열번쨰:" + v[9]);

            int i = 0;


            for (i = 0; i <= 9; i++)
            {
                // 반복을 해주는 for 문, ++ 하나씩 증가를 해라
                Console.WriteLine(v[i]);
            }

            int[] g = { 100, 101, 102, 103, 104, 105 };

            int k = 0;
            int sum = 0;
            for (k = 0; k <= 5; k++)
            {
                sum = sum + g[k];
                Console.WriteLine("k 는 " + k + " 배열은 " + g[k] + " sum 은 " + sum); //g[k] 
            }
            Console.WriteLine(sum);

            int some = g[0] + g[1] + g[2] + g[3] + g[4] + g[5];
            Console.WriteLine(some);

            // Day 2. 곱셈

            int[] m= { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            int u = 0;

            int sum4 = 1;

            for (u = 0; u <= 9; u++)
            {
                sum4 = sum4 * m[u];

                Console.WriteLine("곱셈의 값은" + sum4);
            }
                // Day 3 나눗셈

            int[] gh = { 2, 2, 2, 2, 2, 2, 2, 2, 2, 2 };
            int gh_index;
            int sum5 = 1024;

            for (gh_index = 9; gh_index >= 0; gh_index--)
            {
                sum5 = sum5 / gh[gh_index];

                Console.WriteLine("나눗셈의 값은" + sum5);
            }

            // Day 4. 

            /*
             *      *
             *      **
             *      ***
             *      ****
             *      *****
             */
            Console.WriteLine("*");
            Console.WriteLine("**");
            Console.WriteLine("***");
            Console.WriteLine("****");
            Console.WriteLine("*****");

            int x11 = 0;

            for  (x11 = 0; x11 <= 4; x11++)
            {
                Console.Write("*");
            }
            Console.WriteLine("");
            Console.WriteLine("별을 찍기");
            int x12 = 4;       // 0 , 1  , 2    , 3     ,4 
            string[] starArray = {"*","**","***", "****","*****" };
            for (x12 = 4; x12 >= 0; x12 --)
            {
                Console.WriteLine(starArray[x12]);
            }

            int x14 = 0;
            int y14 = 0;

            for (x14 = 0; x14 <= 4; x14++)
            {
                for (y14 = 0; y14 <= 4; y14++)
                {
                    Console.Write("*");
                }

                Console.WriteLine("");
            }

            /*
             **
             **
             **
             **   
                
             *   
             *   
             */
        }  
    }
}







































