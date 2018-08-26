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
            int[] v = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }; // int 다음에 [] 여러개를 선언하겠다. 배열 [0] ~ [9]

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

            int[] m = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

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

            for (x11 = 0; x11 <= 4; x11++)
            {
                Console.Write("*");
            }
            Console.WriteLine("");
            Console.WriteLine("별을 찍기");
            int x12 = 4;       // 0 , 1  , 2    , 3     ,4 
            string[] starArray = { "*", "**", "***", "****", "*****" };
            for (x12 = 4; x12 >= 0; x12--)
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
             *      *   => "   *"
             *     * *  => "  * *"    
             *    * * * => " * * *"
             *   * * * * =>"* * * *"
             *                 C
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
             *   
             *   
             *   
             *   
             *  *   
             *   
             *   3) string input = Console.ReadLine(); 
             *      Console.WriteLine("입력:" + input);
             *    
             *    을 실행하면 사용자가 입력하는 글자를 input이라는 변수에 받아서 찍어줘요. 한 번 해보세요.
             *    
             *    https://blog.naver.com/einsbon/221001261094 여기 한 번 가서 읽어봐요.
             */

            Console.WriteLine("6-1시작");
            Console.WriteLine("   *"); // 1. 직접 찍기
            string str1 = "  * *"; // 한 번 변수를 선언을 하고 
            Console.WriteLine(str1); // 2. 변수
            Console.WriteLine(" * * *");
            Console.WriteLine("* * * *");

            int x19 = 0;
            int y19 = 0;
            Console.WriteLine("6-2 시작");

            for (x19 = 0; x19 <= 4; x19++)
            {
                for (y19 = 0; y19 <= x19; y19++)
                {
                    Console.Write("*");
                }

                Console.WriteLine("");
            }

            int x18 = 4;
            int y18 = 0;

            for (x18 = 4; x18 >= 0; x18--)
            {
                for (y18 = 0; y18 <= x18; y18++)
                {
                    Console.Write("*");
                }

                Console.WriteLine("");
            }

            Console.WriteLine("6-3 시작: 아무거나 입력하세요 !");
            string input = Console.ReadLine();
            Console.WriteLine("당신이 방금 입력한 값은: " + input);

            Console.WriteLine("7-1시작");
            // 함수: function

            int v71 = MultiplyBy2(2);
            Console.WriteLine("2를 입력한 MultiplyBy2 값은 " + v71);

            int v72 = MultiplyBy2(1024);
            Console.WriteLine("1024를 입력한 MultiplyBy2 값은 " + v72);

            int v73 = MultiplyBy2(15000);
            Console.WriteLine("15000를 입력한 MultiplyBy2 값은 " + v73);

            // Day-8 123456 654321 => 777777
            int v81 = Add(30, 50);
            Console.WriteLine("Add 값은 " + v81);

            int v82 = Add(20000, 10000);
            Console.WriteLine("Add 값은 " + v82);
            
            int v83 = Subtract(1000, 700);
            Console.WriteLine("Subtract 값은 " + v83);

            int v84 = Multiply(10, 10);
            Console.WriteLine("Multiply 값은 " + v84);

            int v85 = Divide(10, 2);
            Console.WriteLine("divide 값은 " + v85);

            // Subtract(1000, 300) => 700

            // Day-9
            Console.WriteLine("9일차. 숫자 입력하세요 !!!");
            string v100 = Console.ReadLine();
            int v101 = Convert.ToInt32(v100);
            Console.WriteLine("당신이 방금 입력한 1st 값은: "  + v101);
            Console.WriteLine("숫자 하나더 입력하세요 !!!");
            string v103 = Console.ReadLine();
            int v105 = Convert.ToInt32(v103);
            Console.WriteLine("당신이 방금 입력한 값은: " + v105);
            int v90 = Add(v105, v101);

            Console.WriteLine("숙제 값은" + v90);
            // Day-10
            Console.WriteLine("10일차. 드디어 계산기 !!!");
            Console.WriteLine("원하는 사칙연산은?");
            Console.WriteLine("1) 덧셈");
            Console.WriteLine("2) 뺄셈");
            Console.WriteLine("3) 곱셈");
            Console.WriteLine("4) 나눗셈");

            String str10 = Console.ReadLine();
            int v1000 = Convert.ToInt32(str10);

            Console.WriteLine("첫번째 숫자 입력 하십시오");
            String str1000_2 = Console.ReadLine();
            int v1001 = Convert.ToInt32(str1000_2);

            Console.WriteLine("2번째 숫자 입력 하십시오");
            String str1000_3 = Console.ReadLine();
            int v1002 = Convert.ToInt32(str1000_3);





            int answer1000 = 0;

            if (v1000 == 1 )
            {
                Console.WriteLine("덧셈선택하셨습니다.");
                answer1000 = Add(v1001, v1002);
            }

            if (v1000 == 2)
            {
                Console.WriteLine("뺄셈선택하셨습니다.");
                answer1000 = Subtract(v1001, v1002);
            }

            if (v1000 == 3)
            {
                Console.WriteLine("곱셈선택하셨습니다.");
                answer1000 = Multiply(v1001, v1002);
            }

            if (v1000 == 4)
            {
                Console.WriteLine("나눗셈선택하셨습니다.");
                answer1000 = Divide(v1001, v1002);
            }

            Console.WriteLine("결과값은" + answer1000);
        }

        // 함수의 모양
        // f(x) = 2x + 1;
        // y = 2x + 1
        // (1, 3), (2, 5)
        //  y
        //  |
        //  1         +
        //  1 
        //  |    +    
        //  |
        //  |
        //  ------------------------------- x
        //       1   2   3
        //  
        // 함수의 정의
        static int MultiplyBy2(int firstInput) // 들어오는 값 input. <== x
        {
            int answer = firstInput * 2;
            return answer; // 부른사람한테 보내주는 값 (리턴값) <= y
        }

        // Day 8 문제 두 숫자를 함수에 넣어서 더한 결과값을 리턴하는 함수를 완성하시오
        static int Add(int firstInput, int secondInput) // 들어오는 값 input. <== x
        {
            return firstInput + secondInput;
        }
            

        static int Subtract(int firstInput, int secondInput) // 들어오는 값 input. <== x
        {
            return firstInput - secondInput;

        }
        static int Multiply(int firstInput, int secondInput) // 들어오는 값 input. <== x
        {
            return firstInput * secondInput;

        }

        static int Divide(int firstInput, int secondInput) // 들어오는 값 input. <== x
        {
            return firstInput / secondInput;

        }
    }
}







































