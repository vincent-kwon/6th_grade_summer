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
             *  Day 5. 오늘의 문제
             *   
             *   *
             *   **
             *   ***
             *   ****
             *   *****
             *   
             *   
             *   
             *   1) 아래를 변형해서 위처럼 찍어보세요. 단 Console.Write("*") 는 별 한 개만 찍을 수 있고 Console.Write("**") 이렇게 두개는 안됨
             *      또한 Console.WriteLine("") 와 같이 줄 바꾸는 것만 허용
             *   
             *   2)  아래를 만들어보세요 (열줄)
             *   
             *   *
             *   **
             *   ***
             *   ****
             *   *****
             *   ******
             *   *******
             *   ********
             *   *********
             *   **********
             *   
             *   3)  역삼각형을 만들어보세요
             *   
             *   *****
             *   ****
             *   ***
             *   **
             *   *
             *   
             */

            // Day 5 - 1)
            int x15 = 0;
            int y15 = 0;
            Console.WriteLine("5-1 시작");
            for (x15 = 0; x15 <= 4; x15++)
            {
                for (y15 = 0; y15 <= x15; y15++)
                {
                    Console.Write("*");
                }

                Console.WriteLine("");
            }
            // Day 5 - 2)
            int x16 = 0;
            int y16 = 0;
            Console.WriteLine("5-2 시작");

            for (x16 = 0; x16 <= 9; x16++)
            {
                for (y16 = 0; y16 <= x16; y16++)
                {
                    Console.Write("*");
                }

                Console.WriteLine("");
            }

            // Day 5 - 3)
            int x17 = 4;
            int y17 = 0;
            Console.WriteLine("5-3 시작");

            for (x17 = 4; x17 >= 0; x17--) 
            {
                for (y17 = 0; y17 <= x17; y17++)
                {
                    Console.Write("*");
                }

                Console.WriteLine("");
            }

            /*
             *  Day 6. 오늘의 문제
             *   
             *      *
             *     * *
             *    * * *
             *   * * * *
             *  
             *   1) 정삼각형을 만들어 보세요 (for 문 사용 없이요)
             *      이미 위에서 for 문 없이 찍은 거랑 비슷해요. Console.Write(" ") 하면 공백이 찍혀요
             *          
             *    
             *   아래를 변형해서 위처럼 찍어보세요. 단 Console.Write("*") 는 별 한 개만 찍을 수 있고 Console.Write("**") 이렇게 두개는 안됨
             *      또한 Console.WriteLine("") 와 같이 줄 바꾸는 것만 허용
             *   
             *   2)  아래를 만들어보세요 (열 한 줄)
             *    
             *    힌트) 이전에 배운 문제 5-2, 5-3 을 연속으로 답을 붙이면 되지 않을까요?
             *   
             *   *
             *   **
             *   ***
             *   ****
             *   *****
             *   ******
             *   *****
             *   ****
             *   ***
             *   **
             *   *
             *   
             *   3) string input = Console.ReadLine(); 
             *      Console.WriteLine("입력:" + input);
             *    
             *    을 실행하면 사용자가 입력하는 글자를 input이라는 변수에 받아서 찍어줘요. 한 번 해보세요.
             *    
             *    https://blog.naver.com/einsbon/221001261094 여기 한 번 가서 읽어봐요.
             */
            string input = Console.ReadLine();
            Console.WriteLine("당신이 방금 입력한 값은: " + input);

        }
    }
}







































