using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace IntroducingOfProgramming
{
    class Program
    {
        static void HelloWord()
        {
            Console.WriteLine("Hello World!");
            Console.Write("HHii~~");
            Console.Write("\n // HelloWord // \n");
            // Console.WriteLine("Hello World!");
            /*
             *  Console.Write("HHii~~");
             *  Console.Write("HHii~~");
             *  Console.Write("HHii~~");
             */
            int int1 = 2;
            int int2 = 10;
            float float1 = 10.23f;
            float float2 = 3.4f;
            double double1 = 11.0;
            double double2 = 5.234;
            char char1 = 'a';
            char char2 = '$';
            Console.WriteLine(char1 + " ~ z");
            Console.WriteLine(char2);
            Console.WriteLine(int1 + " + " + int2 + " = " + int1 + int2);
            Console.WriteLine(int1 + " - " + int2 + " = " + (int1 - int2));
            Console.WriteLine(float1 + " + " + float2 + " = " + float1 + float2);
            Console.WriteLine(double1 + " - " + double2 + " = " + (double1 - double2));
        }
        static void PrimitiveTypesToBinary()
        {
            Console.Write("\n // primitiveTypesToBinary // \n");
            byte byte11 = byte.MaxValue;
            byte byte22 = byte.MinValue;
            int int11 = int.MaxValue;
            int int22 = int.MaxValue;
            long long11 = long.MaxValue;
            long long22 = long.MinValue;
            char char11 = 'x';
            char char22 = '$';
            Console.Write("\n // primitiveTypesToBinary // \n");
            Console.WriteLine(byte11 + " -> " + Convert.ToString(byte11, 2));
            Console.WriteLine(byte22 + " -> " + Convert.ToString(byte22, 2));
            Console.WriteLine(int11 + " -> " + Convert.ToString(int11, 2));
            Console.WriteLine(int22 + " -> " + Convert.ToString(int22, 2));
            Console.WriteLine(long11 + " -> " + Convert.ToString(long11, 2));
            Console.WriteLine(long22 + " -> " + Convert.ToString(long22, 2));
            Console.WriteLine(char11 + " -> " + Convert.ToString(char11, 2));
            Console.WriteLine(char22 + " -> " + Convert.ToString(char22, 2));
        }
        static void TypeConversion()
        {
            Console.Write("\n // typeConversion // \n");
            char char13 = 'a';
            int int13 = char13;
            Console.WriteLine("char can be converted ASCII code!");
            Console.WriteLine("int13: " + int13);
            long long13 = char13;
            Console.WriteLine("long13: " + long13);
            long ulong13 = char13;
            Console.WriteLine("ulong13: " + ulong13);
            long float13 = char13;
            Console.WriteLine("float13: " + float13);
            long double13 = char13;
            Console.WriteLine("double13: " + double13);
            long long23 = long.MaxValue;
            int long2ToInt = (int)long23;
            Console.WriteLine("long23: " + long23);
            Console.WriteLine("long2ToInt: " + long2ToInt); // 넘어가는 왼쪽 자리수는 다 자르고, 11111111 ~ int형에서 -1
            float float23 = 3.141592f;
            int float2ToInt = (int)float23;
            Console.WriteLine("float23: " + float23);
            Console.WriteLine("float2ToInt: " + float2ToInt); // 정수는 소숫점 자리 버림
            int int23 = -1;
            uint int2ToUInt = (uint)int23;
            Console.WriteLine("int23 " + int23);
            Console.WriteLine("int2ToUInt " + int2ToUInt); // 맨 앞자리 1을 음수로 쓰냐, 최댓값으로 그대로 쓰냐 차이
        }
        static void Calculator()
        {
            Console.Write("\n // calculator // \n");
            int num14 = 10;
            int num24 = 11;
            int result14 = num14 + num24;
            int result24 = num14 - num24;
            Console.WriteLine("result14 " + result14);
            Console.WriteLine("result24 " + result24);
            uint result34 = (uint)num14 - (uint)num24;
            Console.WriteLine("result34 " + result34); // uint로 음수 표현 불가능 ~ 양수 최대치로 표현!
            int num34 = int.MaxValue;
            int result44 = num34 + 1;
            Console.WriteLine("result44 " + result44); // 오버플로우 ( 넘치는 자리수에 따른 최소화.. )
            float num44 = 2.3f;
            float result54 = num14 + num44;
            float result64 = num14 - num44;
            Console.WriteLine("result54 " + result54);
            Console.WriteLine("result64 " + result64); // 정수와 부동소수간의 사칙연산은 묵시적 형변환으로 부동소수화
            float result74 = num24 * num44;
            Console.WriteLine("result74 " + result74);
            float result84 = num24 / num14;
            float result94 = num24 / (float)num14;
            Console.WriteLine("result84 " + result84); // 아무 것도 없이, 정수 나눗셈은 무조건 정수 리턴..
            Console.WriteLine("result94 " + result94); // 부동소수형으로 명시적 변환 필요
            int result104 = num14 % num24;
            int result105 = num24 % num14;
            Console.WriteLine("result104 " + result104);
            Console.WriteLine("result105 " + result105);
        }
        static void IncDecOperator()
        {
            Console.Write("\n // inc/decOperator // \n");
            int num15 = 0;
            int num25 = 10;
            int result15 = num15-- + num15-- - --num25;
            Console.WriteLine("num15 " + num15 + ", " + "num25 " + num25 + ", " + "result15 " + result15);
            int num35 = 0;
            int num45 = 10;
            int result25 = num45++ * num35++ - --num45;
            Console.WriteLine("num35 " + num35 + ", " + "num45 " + num45 + ", " + "result25 " + result25);
        }
        static void BitMultiplicationAndDividation()
        {
            Console.Write("\n // BitMultipplication&Dividation // \n");
            int num16 = 1;
            int result16 = num16 << 1;
            Console.WriteLine("result16 " + result16); // * 단위유닛 한 것!
            int result26 = result16 << 2;
            Console.WriteLine("result26 " + result26);
            int result36 = result26 >> 3;
            Console.WriteLine("result36 " + result36);
            //int result46 = result36 << 2.5f; 부동소수를 단위로 쓰면 컴파일 오류를 내보낸다
            // bitFlag
            const int BIT_FLAG_SIZAE = 8;
            byte bitFlags = 0;
            byte mask1 = 1 << 2;
            bitFlags |= mask1;
            Console.WriteLine("mask1 " + Convert.ToString(bitFlags, 2).PadLeft(BIT_FLAG_SIZAE, '0') + ", " + "result1 " + Convert.ToString(bitFlags, 2).PadLeft(BIT_FLAG_SIZAE, '0'));
            byte mask2 = (1 << 3) | (1 << 5);
            bitFlags |= mask2;
            Console.WriteLine("mask2 " + Convert.ToString(mask2, 2).PadLeft(BIT_FLAG_SIZAE, '0') + ", " + "result2 " + Convert.ToString(bitFlags, 2).PadLeft(BIT_FLAG_SIZAE, '0'));
            bitFlags &= (byte)~mask1;
            Console.WriteLine("~mask1 " + Convert.ToString((byte)~mask1, 2).PadLeft(BIT_FLAG_SIZAE, '0') + ", " + "result3 " + Convert.ToString(bitFlags, 2).PadLeft(BIT_FLAG_SIZAE, '0'));
            bitFlags &= 0;
            Console.WriteLine("result4 " + Convert.ToString(bitFlags, 2).PadLeft(BIT_FLAG_SIZAE, '0'));
            char char17 = 'A';
            int result17 = char17 | ' ';
            Console.WriteLine("char1 " + (byte)char17 + ", " + "' ' " + (byte)' ' + ", " + "result17 " + (char)result17);
            char char27 = 'a';
            int result27 = char27 & '_';
            Console.WriteLine("char2 " + (byte)char27 + ", " + "_ " + (byte)'_' + ", " + "result27 " + (char)result27); // 비트연산으로 대소문자 변경
            byte test = 1;
            test ^= 2;
            Console.Write(test);
        }
        static void StringTypeAndASCIIAndFormatting()
        {
            Console.Write("\n // stringType&ASCII&formatting // \n");
            // ASCII
            Console.WriteLine("Hello World!");
            Console.WriteLine("\x48\x65\x6C\x6C\x6f\x20\x57\x6F\x72\x6C\x64\x21");
            // formating
            int num18 = 48;
            int num28 = 65;
            Console.WriteLine("The sum of " + num18 + " and " + num28 + " is " + (num18 + num28)); // 혹시 num 18, num 28이 그냥 차례로 string으로 붙어버릴까봐 () 안 처/
            Console.WriteLine("The sum of {0} and {1} is {2}", num18, num28, num18 + num28);
            Console.WriteLine($"The sum of {num18} and {num28} is {num18 + num28}");

            Console.WriteLine($"\x48\x65\x6C\x6C\x6f\x20\x57\x6F\x72\x6C\x64\x21");
            Console.WriteLine(@"\x48\x65\x6C\x6C\x6f\x20\x57\x6F\x72\x6C\x64\x21");
            // 음수는 왼쪽정렬 양수는 오른쪽 정렬
            Console.WriteLine("{0, -11} + {1, 11} = {2}", num18, num28, num18 + num28);
            Console.WriteLine("{0, -11} - {1, 11} = {2}", num18, num28, num18 - num28);
            Console.WriteLine("{0, -11} * {1, 11} = {2}", num18, num28, num18 * num28);
            Console.WriteLine("{0, -11} / {1, 11} = {2:f4}", num18, num28, num18 / (float)num28); // 소숫점 4째 자리 표현
            Console.WriteLine("{0, -11} % {1, 11} = {2}", num18, num28, num18 % num28);
            Console.WriteLine();
            Console.WriteLine(string.Format("{0, -11} + {1, 11} = {2}", num18, num28, num18 + num28));
            Console.WriteLine(string.Format("{0, -11} - {1, 11} = {2}", num18, num28, num18 - num28));
            Console.WriteLine(string.Format("{0, -11} * {1, 11} = {2}", num18, num28, num18 * num28));
            Console.WriteLine(string.Format("{0, -11} / {1, 11} = {2}", num18, num28, num18 / (float)num28));
            Console.WriteLine(string.Format("{0, -11} % {1, 11} = {2}", num18, num28, num18 % num28));
            Console.WriteLine(string.Format("[10 -> 16] 10 : {0:x} {0:X} {0:x4} {0:x-2}", 10)); // 10 --> 16진
        }
        static void KeyboardInput()
        {
            Console.WriteLine("Let's fill out student information:");
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Student Number: ");
            string studentNumberString = Console.ReadLine();
            int studentNumber = int.Parse(studentNumberString);

            Console.Write("Grade: ");
            string gradeString = Console.ReadLine();
            int grade = int.Parse(gradeString);
            Console.WriteLine("------------------------------------");
            Console.WriteLine($"{name}\n{studentNumber}\n{grade}%");
            // condition
            Console.Write("\n // condition // \n");
            if (grade >= 90)
            {
                Console.WriteLine("Excellent! You are an A student!");
            }
            else if (grade >= 80)
            {
                Console.WriteLine("Good! You are above average!");
            }
            else if (grade >= 70)
            {
                Console.WriteLine("Meh... You are doing right...");
            }
            else if (grade >= 50)
                Console.WriteLine("Are you even tring? You can do better than that!"); // DON"T DO THIS!! USE {}
            else
            {
                Console.WriteLine("You have no talent...");
            }
        }
        static void LogicalExpressions()
        {
            Console.Write("\n // logicalExpressions // \n");
            int num19 = 1;
            int num29 = 1;
            int num39 = 4;
            bool expression19 = !(num19 == num29 && num19 != num39);
            bool expression29 = num19 != num29 || num19 == num39;
            Console.WriteLine($"expression19 { expression19 }");
            Console.WriteLine($"expression29 { expression29 }");
            bool expression39 = num19 > num29 || num19 == num39 || ++num19 > num29;
            Console.WriteLine($"expression39 { expression39 }"); // 마지막 항 실행
            bool expression49 = num39 > num29 || num19-- == num29;
            Console.WriteLine($"expression49 { expression49 }"); // 마지막 항 실행X
            bool expression59 = num39 == num19 && --num29 > num19;
            Console.WriteLine($"expression59 { expression59 }");
        }
        static void OrderOfExpressionEvaluation()
        {
            Console.Write("\n // orderOfExpressionEvaluation // \n");
            int num110 = 5;
            int num210 = 15;
            int num310 = 2;
            int max110 = num110;
            if (num210 > max110)
            {
                max110 = num210;
            }
            if (num310 > max110)
            {
                max110 = num310;
            }
            Console.WriteLine($"max110: { max110 }");
            int max210 = num110;
            max210 = num210 > max210 ? num210 : max210;
            max210 = num310 > max210 ? num310 : max210;
            Console.WriteLine($"max210: { max210 }");
            int result110 = num310 >= num110 ? num110 : (num310 + num110 * num210);
            Console.WriteLine($"result110: { result110 }");
        }
        static void Iterator()
        {
            // switch
            Console.Write("\n // switch // \n");
            Console.Write("num1: ");
            string num1String = Console.ReadLine();
            int num111 = int.Parse(num1String);
            Console.Write("num2: ");
            string num2String = Console.ReadLine();
            int num211 = int.Parse(num2String);
            Console.Write("operation ( +, -, *, / )");
            string operation211 = Console.ReadLine();
            switch (operation211)
            {
                case "+":
                    Console.WriteLine($"{num111} + {num211} = {num111 + num211}");
                    break;
                case "-":
                    Console.WriteLine($"{num111} - {num211} = {num111 - num211}");
                    break;
                case "*":
                    Console.WriteLine($"{num111} * {num211} = {num111 * num211}");
                    break;
                case "/":
                    Console.WriteLine($"{num111} / {num211} = {num111 / num211}");
                    break;
                default:
                    Console.WriteLine($"You entered a wrong operator: {operation211}");
                    break;
            }

            // array
            Console.Write("\n // array // \n");
            Console.WriteLine("Let's fill out student information:");
            string[] names = new string[3];
            string[] studentNumbers = new string[3];
            int[] grades = new int[3];

            Console.Write("Name: ");
            names[0] = Console.ReadLine();
            Console.Write("Student Number: ");
            studentNumbers[0] = Console.ReadLine();
            Console.Write("Grade: ");
            string gradeString1 = Console.ReadLine();
            grades[0] = int.Parse(gradeString1);
            Console.Write("Name: ");
            names[1] = Console.ReadLine();
            Console.Write("Student Number: ");
            studentNumbers[1] = Console.ReadLine();
            Console.Write("Grade: ");
            string gradeString2 = Console.ReadLine();
            grades[1] = int.Parse(gradeString2);
            Console.Write("Name: ");
            names[2] = Console.ReadLine();
            Console.Write("Student Number: ");
            studentNumbers[2] = Console.ReadLine();
            Console.Write("Grade: ");
            string gradeString3 = Console.ReadLine();
            grades[2] = int.Parse(gradeString3);
            Console.WriteLine("1 {0, -5} {1, -5} {2}%", names[0], studentNumbers[0], grades[0]);
            Console.WriteLine("2 {0, -5} {1, -5} {2}%", names[1], studentNumbers[1], grades[1]);
            Console.WriteLine("3 {0, -5} {1, -5} {2}%", names[2], studentNumbers[2], grades[2]);

            // loop
            Console.Write("\n // loopSum // \n");
            const int MAX = 100;
            Console.WriteLine($"sum of 1 - { MAX }");
            int sum = 0;
            for (int i = 0; i < 100; i++)
            {
                sum += (i + 1);
            }
            Console.WriteLine($"result is { sum }");
            int path = 0;
            while (true)
            {
                Console.Write("which number you love?");
                int answer = int.Parse(Console.ReadLine());
                if (answer == path)
                {
                    Console.WriteLine("Good~");
                    break;
                }
                Console.WriteLine("Liar.. 0x{0:x} in hex", answer);
            }

            // Multi dimensional array  ( 2D 배열 )
            Console.Write("\n // MultiDimensionalArray // \n");
            const int ROW_COUNT = 4;
            const int COLUMN_COUNT = 5;
            int[,] array1 = new int[ROW_COUNT, COLUMN_COUNT]
            {
                { 2,3,4,10,5 },
                { 1,11,-4,4,6 },
                { -11,-4,6,-3,-3 },
                { 7,17,2,-4,2 },
            };
            int[,] array2 = new int[ROW_COUNT, COLUMN_COUNT]
                {
                { -2,7,10,-10,1 },
                { 2,7,-6,-13,6 },
                { 10,6,-6,3,1 },
                { 7,8,7,-9,1 },
            };
            int[,] sumArray = new int[ROW_COUNT, COLUMN_COUNT];
            for (int i = 0; i < ROW_COUNT; i++)
            {
                for (int j = 0; j < COLUMN_COUNT; j++)
                {
                    sumArray[i, j] = array1[i, j] + array2[i, j];
                }
            }
            Console.WriteLine(sumArray);
            for (int i = 0; i < ROW_COUNT; i++)
            {
                for (int j = 0; j < COLUMN_COUNT; j++)
                {
                    Console.WriteLine("{0, 5} + {1, -5} = {2, 5}", array1[i, j], array2[i, j], sumArray[i, j]);
                }
                Console.WriteLine();
            }
        }
        static void Functions()
        {
            Console.Write("\n // Function // \n");
            int x = 4;
            int y = 7;
            static int Add(int num1, int num2)
            {
                return num1 + num2;
            }
            static int Subtract(int num1, int num2)
            {
                int diff = num1 - num2;
                return diff;
            }
            static int Multiply(int num1, int num2)
            {
                return num1 * num2;
            }
            static int A(int num1, int num2) // 이름이 개구리다 바꿔야  
            {
                // 선조건을 걸어줘야 함 ( 이 경우, num2가 음수가 아니어야 하는 ) --> 주석 or uint
                if ( num2 == 0 )
                {
                    return 1;
                }
                int product = 1;
                for ( int i = 0; i < num2; i++ )
                {
                    product *= num1;
                }
                return product;
            }
            int sum1 = x + y;
            int sum2 = Add(x, y);
            Console.WriteLine($"sum1: {sum1} / sum2: {sum2}");
            int minus1 = x - y;
            int minus2 = Subtract(x, y);
            Console.WriteLine($"minus1: {minus1} / minus2: {minus2}");
            int product1 = x * y;
            int product2 = Multiply(x, y);
            Console.WriteLine($"product1: {product1} / product2: {product2}");
            int pow = A(x, y);
            Console.WriteLine($"A: {pow}");

            // scope
            static int GetAverage( int[] numbers )
            {
                int sum = 0;
                for ( int i = 0; i < numbers.Length; i++ )
                {
                    sum += numbers[i];
                }
                return sum / numbers.Length;
            }
            int[] numbers = new int[] { 1, -3, 4, -10, 4, 2, 9, 15 };
            double average = GetAverage(numbers);
            Console.WriteLine($"average: {average}");
            // 이렇게 중괄호를 활용하면, 함수도 아닌데 새 범위를 만들 수 있음
            {
                string message = "Messsage in the first child scope!";
                Console.WriteLine(message);
            }
            {
                string message = "Messsage in the second child scope!"; // 스코프1 과는 완전 독립적!
                //int average = 0; ~ 그렇지만 이렇게, 상위 스코프에서 이미 정의된 변수는 재정의 불가!
                Console.WriteLine(message);
            }

            // call by ref & call by value
            static void Plus( ref int number )
            {
                int plusNumber = 5;
                number += plusNumber;
            }
            //static int Plus( int number ) // 함수명 중복 선언 불가능하다
            //{
            //    int plusNumber = 5;
            //    return number + plusNumber;
            //}
            int testNum = 10;
            Plus(ref testNum);
            // int result2 = Plus(testNum); // 참조 변수 받도록 했으면, 무조건 ref 붙여야 한다.
            Console.WriteLine(testNum);
            
        }
        enum EOperator
        {
            Plus = '+',
            Minus = '-',
            Multiply = '*',
            Divide = '/',
            Mod = '%',
        }
        static void Enums()
        {

            Console.Write("num1: ");
            string num1String = Console.ReadLine();
            int num1 = int.Parse(num1String);
            Console.Write("num2: ");
            string num2String = Console.ReadLine();
            int num2 = int.Parse(num2String);
            Console.Write("operation ( +, -, *, /, % ): ");
            string operationString = Console.ReadLine();
            char operationChar = char.Parse(operationString);
            EOperator operation = (EOperator)operationChar;
            Console.WriteLine($"체크! {operation}, {(int)operationChar}"); // 만약 enum에 걸리지 않으면, ASCII로 나옴!
            switch ( operation )
            {
                case EOperator.Plus:
                    Console.WriteLine(EOperator.Plus);
                    Console.WriteLine(operation);
                    Console.WriteLine($"{num1} {operationChar} {num2} = {num1 + num2}");
                    break;
                case EOperator.Minus:
                    Console.WriteLine($"{num1} {operationChar} {num2} = {num1 - num2}");
                    break;
                case EOperator.Multiply:
                    Console.WriteLine($"{num1} {operationChar} {num2} = {num1 * num2}");
                    break;
                case EOperator.Divide:
                    Console.WriteLine($"{num1} {operationChar} {num2} = {num1 / num2}");
                    break;
                case EOperator.Mod:
                    Console.WriteLine($"{num1} {operationChar} {num2} = {num1 % num2}");
                    break;
                default:
                    Console.WriteLine($"You entered a wrong operator: {operationChar}");
                    break;

            }

        }
        static void Asserts()
        {
            static void printRange( int start, int end, int[] numbers )
            {
                Debug.Assert(start >= 0, "start can't be less than 0"); // 디버그 모드에서만 작동한다!
                Debug.Assert(end >= 0, "end can't be less than 0");
                Console.Write('[');
                for (int i = 0; i < end; i++)
                {
                    Console.Write($"{numbers[i]},");
                }
                if (numbers.Length > 0)
                {
                    Console.Write(numbers[(int)numbers.Length - 1]);

                }
                Console.WriteLine(']');
            }
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            printRange(0, 10, numbers);
            printRange(3, 7, numbers);
            printRange(-1, 5, numbers); // assert 에러! 단언한 내용이 false가 된다!
        }
        static void RecursiveFactorial()
        {
            const ulong FACTORIAL = 10;
            static ulong NonReCursiveFactorial(ulong n)
            {
                if ( n <= 1 )
                {
                    return 1;
                }
                uint factorial = 1;
                for ( uint i = 2; i <= n; i++ )
                {
                    factorial *= i;
                }
                return factorial;
            }

            static ulong IsReCursiveFactorial(ulong n)
            {
                if ( n == 0 )
                {
                    return 1;
                }
                return IsReCursiveFactorial(n - 1) * n;
            }
            Console.WriteLine($"non recursive: {NonReCursiveFactorial(FACTORIAL)}");
            Console.WriteLine($"recursive: {IsReCursiveFactorial(FACTORIAL)}");
        }
        static void RandomSuffling()
        {
            const int SEED = 0;
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            Console.WriteLine("Before shuffling");
            Console.WriteLine($"[ { string.Join(",", numbers) } ]");
            // 시드값이 존재하면, 언제나 값은 같다!
            // 시드값을 안넣으면, 결과도 랜덤하게 나타남!!
            Random random = new Random( SEED );
            for (int i = numbers.Length - 1; i >= 0; i-- )
            {
                int j = random.Next(0, i);
                int temp = numbers[j];
                numbers[j] = numbers[i];
                numbers[i] = temp;
            }
            Console.WriteLine("After shuffling");
            Console.WriteLine($"[ { string.Join(",", numbers) } ]");

        }
        static void ArrayOfArrays()
        {
            const int MONTHS_IN_A_YEAR = 12;
            int[] daysInEachMonth = new int[MONTHS_IN_A_YEAR] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            // 배열의 배열 생성
            string[][] calendar = new string[MONTHS_IN_A_YEAR][];
            // 달 안에 날짜 넣을 배열 세팅 (안쪽배열 초기화)
            for (int i = 0; i < MONTHS_IN_A_YEAR; i++)
            {
                calendar[i] = new string[daysInEachMonth[i]];
            }
            while (true)
            {
                Console.Write("Enter the Month (1 - 12) : ");
                string monthString = Console.ReadLine();
                int month = int.Parse(monthString);
                if (0 >= month || month > 12)
                {
                    Console.WriteLine("Invalid range of month. Terminating program");
                    break;
                }
                Console.Write($"Enter the Day (1 - {calendar[month - 1].Length}) : ");
                string dayString = Console.ReadLine();
                int day = int.Parse(dayString);
                if (0 >= day || day > calendar[month - 1].Length)
                {
                    Console.WriteLine("Invalid range of day. Terminating program");
                    break;
                }
                Console.WriteLine("Enter yout schedule: ");
                string schedule = Console.ReadLine();
                calendar[month - 1][day - 1] = schedule;

                Console.WriteLine("------------------------------------------------------");
                for (int i = 0; i < MONTHS_IN_A_YEAR; i++)
                {
                    for (int j = 0; j < calendar[i].Length; j++)
                    {
                        if (!string.IsNullOrEmpty(calendar[i][j]))
                        {
                            Console.WriteLine($"{i + 1} / {j + 1}: {calendar[i][j]}");
                        }
                    }
                }
                Console.WriteLine("------------------------------------------------------");
            }
        }
        static void TextMessage()
        {
            string textMessage = File.ReadAllText(@"TextMessage.txt", Encoding.UTF8);
            string[] lines = textMessage.Split("\n");
            Array.ForEach(lines, Console.WriteLine); // 배열을 읽으려면 이런 식으로 해야함;;;
            Console.WriteLine("------------------");
            string[] dateTimeString = lines[1].Split(' ');
            string nameOfDay = dateTimeString[0];
            string[] date = dateTimeString[1].Split('-');
            int year = int.Parse(date[0]);
            int month = int.Parse(date[1]);
            int day = int.Parse(date[2]);
            string[] time = dateTimeString[2].Split(':');
            int hours = int.Parse(time[0]);
            int mins = int.Parse(time[1]);
            float seconds = float.Parse(time[2]);
            string email = lines[2].Trim();
            string courseCode = lines[3].Replace("Course", "").Trim();
            string term = lines[4].Replace("Term", "").Trim();
            Console.WriteLine($"Name of Day: { nameOfDay }");
            Console.WriteLine($"Year: { year }");
            Console.WriteLine($"Month: { month }");
            Console.WriteLine($"Day: { day }");
            Console.WriteLine($"Hours: { hours }");
            Console.WriteLine($"Minutes: { mins }");
            Console.WriteLine($"Seconds: { seconds }");
            Console.WriteLine($"Email: { email }");
            Console.WriteLine($"Course Code: { courseCode }");
            Console.WriteLine($"Term: { term }");
        }
        /*
         * 함수 오버로
         */
        static void Foo()
        {
            Console.WriteLine("Foo with no arguments");
        }
        static void Foo(int x)
        {
            Console.WriteLine($"Foo with {typeof(int).Name}: {x} as an argument.");
        }
        //static void Foo(int x) ~ 바로 위 함수와 시그니쳐가 겹쳐 컴파일 에러 발생!
        //{
        //    Console.WriteLine($"Foo with {typeof(int).Name}: {x} as an argument.");
        //}
        static void Foo(string s)
        {
            Console.WriteLine($"Foo with {typeof(string).Name}: {s} as an argument.");
        }
        static void Foo(string s1, string s2, string s3)
        {
            Console.WriteLine($"Foo with {typeof(string).Name}: {s1}, {typeof(string).Name}: {s2}, {typeof(string).Name}: {s3} as an argument.");
        }
        static void FunctionOverloading()
        {
            // 오버로딩은 바깥에서! 로컬함수는 쓸 수 없다! - 그래서 바로 위 정의!
            Foo();
            Foo(10);
            Foo("POCU");
            Foo("POCU", "COMP1500", "Intro to  programming!");
        }
        static void DefaultParameter()
        {
            static void Bar(string s1, string s2 = "", string s3 ="")
            {
                Console.WriteLine($"{s1}, {s2}, {s3}");
            }
            Bar("POCU");
            Bar("POCU", "COMP1500");
            Bar("POCU", "COMP1500", "Intro to  programming!");
        }
        static void OutParameterModifier()
        {
            Console.WriteLine("Enter \"true\" or \"false\":");
            string booleanString = Console.ReadLine();
            bool b;
            if ( bool.TryParse(booleanString, out b) )
            {
                Console.WriteLine($"Successfully parsed: {b}");
            } else
            {
                Console.WriteLine($"Cannot be parsed to boolean: {b}");
            }
            Console.WriteLine("Enter an integer:");
            string intString = Console.ReadLine();
            int num;
            if ( int.TryParse(intString, out num) )
            {
                Console.WriteLine($"Successfully parsed: {num}");
            }
            else
            {
                Console.WriteLine($"Cannot be parsed to boolean: {num}");
            }
            static bool TryGetIntegerGreaterThan(int input, out int output)
            {
                var random = new Random();
                output = random.Next(0, 10);
                return output > input;
            }
            int someNumber = 5;
            int ranNum;
            if (TryGetIntegerGreaterThan(someNumber, out ranNum) )
            {
                Console.WriteLine($"Great! {ranNum} > {someNumber}");
            } else
            {
                Console.WriteLine($"Failed to get an integer greater than {someNumber}");
            }
        }
        static void StringBuilderExample()
        {
            const int CAPACITY = 1000;
            StringBuilder builder = new StringBuilder(CAPACITY); // 초기 용량일 뿐, 늘어날 수 있다! EnsureCapacity
            builder.Append("Hello World!");
            builder.AppendLine(" Welcom to COMP1500!");
            builder.AppendLine("Are you having fun yet?");
            Console.WriteLine(builder.ToString());
            builder.Insert(12, " Going to insert this here."); // hello world! 뒤에 넣자!!
            Console.WriteLine(builder.ToString());
            builder.Replace(" Going to insert this here.", " And replace this.");
            Console.WriteLine(builder.ToString());
            builder.Remove(12, 19);
            Console.WriteLine(builder.ToString());
            builder.Clear();
            Console.WriteLine(builder.ToString());

            // 문자열 붙이기 vs 스트링 빌더
            const int LOOP_COUNT = 1000;
            Stopwatch stopWatch = new Stopwatch(); // 시간 측정ㄴ

            #region USING_CONCATENATION
            stopWatch.Start();
            string concatenated = string.Empty;
            for ( int i = 0; i < LOOP_COUNT; i++ )
            {
                concatenated += "test";
            }
            stopWatch.Stop();
            Console.WriteLine($"Time elapsed in ms (Concatenated): {stopWatch.Elapsed.TotalMilliseconds}");
            #endregion
            stopWatch.Reset();

            #region USING_STRING_BUILDER
            stopWatch.Start();
            StringBuilder stringBuilder = new StringBuilder(4096);
            for (int i = 0; i < LOOP_COUNT; i++)
            {
                stringBuilder.Append("test");
            }
            string s = stringBuilder.ToString();
            stopWatch.Stop();
            Console.WriteLine($"Time elapsed in ms (StringBuilder): {stopWatch.Elapsed.TotalMilliseconds}");
            #endregion
        }
        // 오버로딩
        static float GetAverage(float[] floats)
        {
            float sum = 0;
            foreach (float f in floats)
            {
                sum += f;
            }
            return sum / floats.Length;
        }
        static double GetAverage(double[] doubles)
        {
            double sum = 0;
            foreach (double d in doubles)
            {
                sum += d;
            }
            return sum / doubles.Length;
        }
        static decimal GetAverage(decimal[] decimals)
        {
            decimal sum = 0;
            foreach (decimal d in decimals)
            {
                sum += d;
            }
            return sum / decimals.Length;
        }
        static void FloatVsDoubleVsDecimal ()
        {
            float[] floats = new float[] { 2.342f, 9.326f, 3.445f, 5.713f, 2.458f, 3.689f, 13.121f, 4.786f, 6.664f, 13.341f, 0.123f };
            float averageFloat = GetAverage(floats);
            double[] doubles = new double[] { 2.342, 9.326, 3.445, 5.713, 2.458, 3.689, 13.121, 4.786, 6.664, 13.341, 0.123 };
            double averageDouble = GetAverage(doubles);
            decimal[] decimals  = new decimal[] { 2.342m, 9.326m, 3.445m, 5.713m, 2.458m, 3.689m, 13.121m, 4.786m, 6.664m, 13.341m, 0.123m };
            decimal averageDecimal = GetAverage(decimals);
            Console.WriteLine($"Average in float: {averageFloat:G9}");
            Console.WriteLine($"Average in float: {averageDouble:G17}");
            Console.WriteLine($"Average in float: {averageDecimal}");
        }
        static void ListAndDictionary()
        {
            // list
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("list");
            const int ELEMENTS_COUNT = 10;
            List<int> list = new List<int>( 20 ); // 왠만하면 첫용량 세팅하자
            for ( int i = 0; i < ELEMENTS_COUNT; i++ )
            {
                list.Add(i);
            }
            Console.WriteLine($"[ {string.Join(",", list)} ]");
            List<int> list2 = new List<int> { 1, 2, 3, 4, 5, 6 };
            Console.WriteLine($"[ {string.Join(",", list2)} ]");
            Console.WriteLine($"First element: {list[0]}");
            Console.WriteLine($"Last element: {list[list.Count - 1]}"); // Length 는 배열용!
            list.Insert(2, 2);
            Console.WriteLine($"[ {string.Join(",", list)} ]");
            list.Remove(2);
            Console.WriteLine($"[ {string.Join(",", list)} ]");
            bool bContains5 = list.Contains(5);
            Console.WriteLine($"Contains 5? {bContains5}");
            bool bContains10 = list.Contains(10);
            Console.WriteLine($"Contains 10? {bContains10}");
            int sum = 0;
            for (int i = 0; i < list.Count; i++) // 순차적 읽기 및 쓰기
            {
                sum += list[i];
                list[i] += list[i];
            }
            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"[ {string.Join(",", list)} ]");

            // dictionary
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("dictionary");
            List<int> list3 = new List<int>();
            Random random = new Random();
            for ( int i = 0; i < 20; i++ )
            {
                int number = random.Next(0, 10);
                list3.Add(number);
            }
            Console.WriteLine($"[ {string.Join(",", list3)} ]");
            Dictionary<int, bool> dictionary = new Dictionary<int, bool>();
            for( int i = 0; i < list3.Count; i++ )
            {
                if ( dictionary.ContainsKey(list3[i]) )
                {
                    list3.Remove(list3[i]); // for 문 돌면서 list.Count 망가뜨리면 원하는 값 도출이 힘듦;;
                }
                else
                {
                    dictionary.Add(list3[i], true);
                }
            }
            Console.WriteLine($"[ {string.Join(",", list3)} ]");

            // foreach
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("foreach");
            List<int> list4 = new List<int>();
            for (int i = 0; i < 20; i++)
            {
                int number = random.Next(0, 10);
                list4.Add(number);
            }
            int sum2 = 0;
            foreach(int i in list)
            {
                sum2 += i;
            }
            Console.WriteLine($"Sum2: {sum2}");
            Dictionary<string, int> dict2 = new Dictionary<string, int>
            {
                { "key1", 1 },
                { "key2", 2 },
                { "key3", 3 },
                { "key4", 4 },
                { "key5", 5 },
                { "key6", 6 },
            };
            foreach( KeyValuePair<string, int> entry in dict2 )
            {
                Console.WriteLine($"{entry.Key}: {entry.Value}");
            }
        }
        static void AboutClass()
        {
            Warrior warrior = new Warrior("sunmin");
            warrior.Introduce();
            warrior.GetStatus();

            //warrior.Name = "Peter"; // 프로퍼티 private set은 컴파일 에러

            warrior.SwordStrike();
            warrior.UseWhirlwind();
            warrior.UseWhirlwind();
            warrior.UseWhirlwind();
            warrior.Rest();

            warrior.GetStatus();

            warrior.Health -= 200;
            //warrior.mHealth = 5000; // private 멤버 변수 수정 컴파일 에러

            warrior.GetStatus();
        }
        static void PartialClass()
        {
            Partial1 robot = new Partial1("sunmin");
            Console.WriteLine(robot.Name);
            robot.ShootLaserBeam();
            robot.ShootMissiles();
            robot.Nuke();
            // 다른 클래스와 마찬가지 큰 변화 없다.
        }
        static void StaticMethod()
        {
            CourseCode courseCode1 = new CourseCode(ESubject.COMP, 3200);
            Console.WriteLine($"{courseCode1.Subject} {courseCode1.Number}");
            CourseCode courseCode2 = CourseCode.Parse("MATH1100");
            Console.WriteLine($"{courseCode2.Subject} {courseCode2.Number}");
            //CourseCode courseCode3 = CourseCode.Parse("abcd!@#$");
            CourseCode courseCode4, courseCode5;
            bool bParsed = CourseCode.TryParse("What is this madness!", out courseCode4);
            Console.WriteLine($"Parsed: {bParsed}");
            bool bParsed1 = CourseCode.TryParse("MATH2300", out courseCode5);
            Console.WriteLine($"Parsed: {bParsed1}");
            Console.WriteLine($"{courseCode5.Subject} {courseCode5.Number}");
        }
        static void StaticClass()
        {
            double centimeters = UnitConverter.GetCentimetersFromInches(1.24);
            double feet = UnitConverter.GetFeetFromInches(12);
            double inches = UnitConverter.GetInchesFromCentimeters(5.7);
            double meters = UnitConverter.GetMetersFromCentimeters(254.92);
            Console.WriteLine($"result: {centimeters} {feet} {inches} {meters}");
        }
        static void ExtensionMethod()
        {
            const string HELLO_WORLD = "Hello World!";
            string reversed = HELLO_WORLD.Reverse();
            Console.WriteLine(reversed);
            string reversed2 = HELLO_WORLD.Reverse(2, 8);
            Console.WriteLine(reversed2);

        }
        public static void Increment(ref int num)
        {
            num++;
        }
        public static void Increment(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i]++;
            }
        }
        public static void Increment(Vector vector)
        {
            vector.X++;
            vector.Y++;
        }
        static void ValueVsReference()
        {
            int num = 0;
            Increment(ref num);
            Console.WriteLine(num);
            int[] nums = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Increment(nums);
            Console.WriteLine(string.Join(", ", nums));
            Vector vector = new Vector(0, 0);
            Increment(vector);
            Console.WriteLine($"{vector.X} {vector.Y}");
        }
        //
        static void Struct()
        {
            CartItem cartItem = new CartItem
            {
                Name = "Hello World! Programming Book",
                Price = 10.99m,
                Quantity = 5,
            };
            ModifyCartItem(cartItem);
            // 값형이기 때문에 변하지 않는다!
            Console.WriteLine($"Name: {cartItem.Name}");
            Console.WriteLine($"Price: {cartItem.Price}");
            Console.WriteLine($"Quantity: {cartItem.Quantity}");
            static void ModifyCartItem(CartItem cartItem)
            {
                cartItem.Name = "How to suck at  programming";
                cartItem.Price = 0.99m;
                cartItem.Quantity = 1;
            }
        }
        static void Nullable()
        {
            static Foo First(Foo[] foos, int number)
            {
                foreach (Foo foo in foos)
                {
                    if (foo.Number == number)
                    {
                        return foo;
                    }
                }
                return null;
            }
            // 구조체는 값형이기 때문에, Nullable<T>로 null 활용!
            static Bar? Second(Bar[] bars, int number)
            {
                foreach (Bar bar in bars)
                {
                    if (bar.Number == number)
                    {
                        return bar;
                    }
                }
                return null;
            }
            Foo[] foos = new Foo[]
            {
                new Foo(1),
                new Foo(2),
                new Foo(3),
            };
            Foo foo1 = First(foos, 2);
            if (foo1 == null)
            {
                Console.WriteLine($"foo1 is null!");
            }
            else
            {
                Console.WriteLine($"foo1: {foo1.Number}");
            }
            Foo foo2 = First(foos, 4);
            if (foo2 == null)
            {
                Console.WriteLine($"foo2 is null!");
            }
            else
            {
                Console.WriteLine($"foo2: {foo2.Number}");
            }

            Bar[] bars = new Bar[]
            {
                new Bar(1),
                new Bar(2),
                new Bar(3),
            };
            // Bar bar1 = Second(bars, 2); // 컴파일 오류 ~ Nullable vs 일반 값형
            Bar? bar2 = Second(bars, 2); // Nullable 변수화!
            if (bar2 == null)
            {
                Console.WriteLine($"bar2 is null!");
            }
            else
            {
                Console.WriteLine($"bar2: {bar2.Value.Number}");
            }
            Bar? bar3 = Second(bars, 4); // Nullable 변수화!
            if (bar3 == null)
            {
                Console.WriteLine($"bar3 is null!");
            }
            else
            {
                Console.WriteLine($"bar3: {bar3.Value.Number}");
            }
        }
        static void StudyLinq()
        {
            List<Order> orders = getOrders();
            Console.WriteLine(orders[0].UserID);
            // 피터 주문 한개!
            Order petersFirstOrder = orders.Where(o => o.UserID == "Peter").FirstOrDefault();
            Console.WriteLine($"Peter's first order: {petersFirstOrder.ID}");
            // Where -> FirstOrDefault 를 한번에 처리!
            petersFirstOrder = orders.FirstOrDefault(o => o.UserID == "Peter");
            Console.WriteLine($"Peter's first order: {petersFirstOrder.ID}");
            // 피터 주문 복수개!
            List<Order> petersOrders = orders.Where(o => o.UserID == "Peter").ToList();
            if (petersOrders.Any())
            {
                Console.WriteLine($"Peter has {petersOrders.Count} order!");
            }
            // 각 데이터 안에 배열을 concat 해줌. ( 그냥 Select면 리스트 안에 리스트.. )
            List<OrderItem> petersOrderItems = petersOrders.SelectMany(o => o.OrderItems).ToList();
            printOrderItems(petersOrderItems);
            // 내림차순
            List<OrderItem> petersOrderItemsorderedByIdDesc = petersOrderItems.OrderByDescending(o => o.ID).ToList();
            printOrderItems(petersOrderItemsorderedByIdDesc);
            // 오름차순
            List<OrderItem> orderedByPrice = petersOrderItems.OrderBy(o => o.Price).ToList();
            printOrderItems(orderedByPrice);

            List<string> productList = petersOrderItems.Select(oi => oi.Name).ToList();
            Console.WriteLine($"Peter bought: {string.Join(", ", productList)}");

            List<OrderItem> allOrderItems = orders.SelectMany(o => o.OrderItems).ToList();
            decimal totalPrice = allOrderItems.Sum(oi => oi.Price * oi.Quantity);
            Console.WriteLine($"Total Price of all order items: {totalPrice}");

            #region HELPER_METHODS
            static List<Order> getOrders()
            {
                List<Order> orders = new List<Order>
                {
                    new Order
                    {
                        ID = 1,
                        UserID = "Peter",
                        OrderItems = new List<OrderItem>
                        {
                            new OrderItem
                            {
                                ID = 1,
                                Name = "GTX1080",
                                Price = 809.99m,
                                Quantity = 1
                            },
                            new OrderItem
                            {
                                ID = 2,
                                Name = "Mechanical Keyboard",
                                Price = 99.99m,
                                Quantity = 2
                            },
                            new OrderItem
                            {
                                ID = 3,
                                Name = "Standing Desk",
                                Price = 607.89m,
                                Quantity = 1
                            }
                        }
                    },
                    new Order
                    {
                        ID = 2,
                        UserID = "Peter",
                        OrderItems = new List<OrderItem>
                        {
                            new OrderItem
                            {
                                ID = 4,
                                Name = "Pen",
                                Price = 1.99m,
                                Quantity = 10
                            },
                            new OrderItem
                            {
                                ID = 5,
                                Name = "Notebook",
                                Price = 10.99m,
                                Quantity = 5
                            }
                        }
                    },
                    new Order
                    {
                        ID = 3,
                        UserID = "Jane",
                        OrderItems = new List<OrderItem>
                        {
                            new OrderItem
                            {
                                ID = 6,
                                Name = "GTX1080",
                                Price = 809.99m,
                                Quantity = 2
                            }
                        }
                    },
                    new Order
                    {
                        ID = 4,
                        UserID = "John",
                        OrderItems = new List<OrderItem>
                        {
                            new OrderItem
                            {
                                ID = 7,
                                Name = "GTX1080",
                                Price = 809.99m,
                                Quantity = 1
                            },
                            new OrderItem
                            {
                                ID = 8,
                                Name = "Pen",
                                Price = 1.99m,
                                Quantity = 2
                            },
                            new OrderItem
                            {
                                ID = 9,
                                Name = "Hairspray",
                                Price = 15.99m,
                                Quantity = 3
                            },
                            new OrderItem
                            {
                                ID = 10,
                                Name = "Mechanical Keyboard",
                                Price = 99.99m,
                                Quantity = 1
                            }
                        }
                    }
                };

                return orders;
            }

            static void printOrderItems(List<OrderItem> orderItems)
            {
                Console.WriteLine("----------------------------------");
                Console.WriteLine("{0,-10} {1,-25} {2, -10} {3, -10}", "ID", "Name", "Price", "Quantity");

                foreach (OrderItem oi in orderItems)
                {
                    Console.WriteLine("{0,-10} {1,-25} {2, -10} {3, -10}", oi.ID, oi.Name, oi.Price, oi.Quantity);
                }
                Console.WriteLine("----------------------------------");
            }
            #endregion
        }
        // readonly: 한번 대입하고 활용해야 하는 변수
        // GetCurrentDirectory: 현재 실행 컨텍스트읭 경로 가져옴
        private static readonly string CURRENT_DIRECTORY = Directory.GetCurrentDirectory();
        // string을 붙여, 경로를 만듦
        private static readonly string OUTPUT_FOLDER_PATH = Path.Combine(CURRENT_DIRECTORY, "output");
        private static readonly string INPUT_FILE_FULL_PATH = Path.Combine(CURRENT_DIRECTORY, "input", "inputtext.txt");
        private static readonly string OUTPUT_FILE_FULL_PATH = Path.Combine(CURRENT_DIRECTORY, "output", "outputtext.txt");
        private static readonly string OUTPUT_FILE1_FULL_PATH = Path.Combine(CURRENT_DIRECTORY, "output", "outputtext.txt");
        private static readonly string OUTPUT_FILE2_FULL_PATH = Path.Combine(CURRENT_DIRECTORY, "output", "outputtext2.txt");
        static void ReadAndWriteFile()
        {
            setup();

            Console.WriteLine($"Input file is in: {INPUT_FILE_FULL_PATH}");

            string allText = File.ReadAllText(INPUT_FILE_FULL_PATH);

            Console.WriteLine("----------------------------------");
            Console.WriteLine(allText);
            Console.WriteLine("----------------------------------");

            string[] allLines = File.ReadAllLines(INPUT_FILE_FULL_PATH);

            Console.WriteLine("----------------------------------");
            foreach (string line in allLines)
            {
                Console.WriteLine(line);
            }
            Console.WriteLine("----------------------------------");

            Console.WriteLine($"Output file 1 is in: {OUTPUT_FILE1_FULL_PATH}");
            // 저장
            File.WriteAllText(OUTPUT_FILE1_FULL_PATH, allText);
            // 저장 (덮어씀)
            File.WriteAllLines(OUTPUT_FILE1_FULL_PATH, allLines);
            // 저장 (뒤에 붙여줌)
            File.AppendAllLines(OUTPUT_FILE1_FULL_PATH, allLines);

            byte[] bytes = new byte[12] { 72, 101, 108, 108, 111, 32, 87, 111, 114, 108, 100, 33 };
            // 바이너리 파일 기록 (12자의 아스키코드가 저장될 것)
            File.WriteAllBytes(OUTPUT_FILE2_FULL_PATH, bytes);

            Console.WriteLine($"Output file 2 is in: {OUTPUT_FILE2_FULL_PATH}");
            static void setup()
            {
                // 파일 존재했으면, 지움 & 폴터 세팅
                if (File.Exists(OUTPUT_FILE1_FULL_PATH))
                {
                    File.Delete(OUTPUT_FILE1_FULL_PATH);
                }

                if (File.Exists(OUTPUT_FILE2_FULL_PATH))
                {
                    File.Delete(OUTPUT_FILE2_FULL_PATH);
                }

                if (!Directory.Exists(OUTPUT_FOLDER_PATH))
                {
                    Directory.CreateDirectory(OUTPUT_FOLDER_PATH);
                }
            }
        }
        static void tryCatchFianlly()
        {
            Random random = new Random();
            int dividend = random.Next();
            Console.WriteLine($"Divide {dividend} by a divisor.");

            try
            {
                Console.Write($"Input a divisor? ");
                string integerString = Console.ReadLine();
                int divisor = int.Parse(integerString);

                if (divisor == 10)
                {
                    throw new IntegerIs10Exception("The input integer is 10!!");
                }

                double result = dividend / (double)divisor;

                Console.WriteLine($"Result: {result}");
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine("Argument is null");
                Console.WriteLine(e);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Integer format is wrong");
                Console.WriteLine(e);
            }
            catch (OverflowException e)
            {
                Console.WriteLine("The number is too huge to be an integer");
                Console.WriteLine(e);
            }
            catch (IntegerIs10Exception e)
            {
                Console.WriteLine("The divisor is 10. Oh noez!!");
                Console.WriteLine(e);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("The dividend is being divided by 0");
                Console.WriteLine(e);
            }
            finally
            {
                Console.WriteLine("Finally clause always runs regardless of whether or not there was an exception");
            }
        }
        static void ReadAndWriteFileUsingFileStream()
        {
            setup();

            // 읽기 전용 파일 (접근권한 읽기)로 세팅
            FileStream fsRead = File.Open(INPUT_FILE_FULL_PATH, FileMode.Open, FileAccess.Read);

            //fsRead.Write(new byte[] { 1, 2, 3 }, 0, 3); // 읽기 전용은 쓸 수 없다!

            Console.WriteLine($"CanRead: {fsRead.CanRead}");
            Console.WriteLine($"CanWrite: {fsRead.CanWrite}");
            Console.WriteLine($"CanSeek: {fsRead.CanSeek}");

            byte[] bytes = new byte[fsRead.Length];
            fsRead.Read(bytes, 0, bytes.Length);

            fsRead.Close();
            Console.WriteLine(string.Join(", ", bytes));
            // 쓰기 전용 파일 (접근권한 쓰기)로 세팅
            FileStream fsWrite = File.Open(OUTPUT_FILE_FULL_PATH, FileMode.Create, FileAccess.Write);

            Console.WriteLine($"CanRead: {fsWrite.CanRead}");
            Console.WriteLine($"CanWrite: {fsWrite.CanWrite}");
            Console.WriteLine($"CanSeek: {fsWrite.CanSeek}");

            fsWrite.Write(bytes, 0, bytes.Length);

            fsWrite.Close();
            void setup()
            {
                if (File.Exists(OUTPUT_FILE_FULL_PATH))
                {
                    File.Delete(OUTPUT_FILE_FULL_PATH);
                }

                if (!Directory.Exists(OUTPUT_FOLDER_PATH))
                {
                    Directory.CreateDirectory(OUTPUT_FOLDER_PATH);
                }
            }
        }
        static void UsingStatement()
        {
            setup();

            string allText = string.Empty;

            using (StreamReader reader1 = new StreamReader(File.Open(INPUT_FILE_FULL_PATH, FileMode.Open, FileAccess.Read)))
            {
                Console.WriteLine("----------------------------------");
                allText = reader1.ReadToEnd();
                Console.WriteLine(allText);
                Console.WriteLine("----------------------------------");
            } // 끝나는 순간 사용한 StreamReader 날려줌

            List<string> allLines = new List<string>();
            using (StreamReader reader2 = new StreamReader(File.Open(INPUT_FILE_FULL_PATH, FileMode.Open, FileAccess.Read)))
            {
                allLines = new List<string>();
                while (!reader2.EndOfStream)
                {
                    allLines.Add(reader2.ReadLine());
                }

                foreach (string line in allLines)
                {
                    Console.WriteLine(line);
                }
                Console.WriteLine("----------------------------------");
            } // 스트림 따로 안닫아도 이렇게 바로 다시 쓸 수 있음!

            using (StreamWriter writer = new StreamWriter(File.Open(OUTPUT_FILE_FULL_PATH, FileMode.OpenOrCreate, FileAccess.Write)))
            {
                // 전체 문자열 저장
                writer.Write(allText);

                // 한줄씩 저장
                foreach (string line in allLines)
                {
                    writer.WriteLine(line);
                }
                writer.BaseStream.Seek(0, SeekOrigin.Begin);
                writer.Write("Overwritten text");
            }

            void setup()
            {
                if (File.Exists(OUTPUT_FILE_FULL_PATH))
                {
                    File.Delete(OUTPUT_FILE_FULL_PATH);
                }

                if (!Directory.Exists(OUTPUT_FOLDER_PATH))
                {
                    Directory.CreateDirectory(OUTPUT_FOLDER_PATH);
                }
            }
        }
        public static readonly string INPUT_DIRECTORY = Path.Combine(Directory.GetCurrentDirectory(), "input");
        public static readonly string OUTPUT_DIRECTORY = Path.Combine(Directory.GetCurrentDirectory(), "output");

        static void CopyDirectory()
        {
            cleanDirectory(OUTPUT_DIRECTORY);

            if (!Directory.Exists(OUTPUT_DIRECTORY))
            {
                Directory.CreateDirectory(OUTPUT_DIRECTORY);
            }

            copyDirectory(INPUT_DIRECTORY, OUTPUT_DIRECTORY);

            void copyDirectory(string sourcePath, string destPath)
            {
                var files = Directory.GetFiles(sourcePath);

                foreach (var file in files)
                {
                    var fileName = Path.GetFileName(file);
                    File.Copy(file, Path.Combine(destPath, fileName));
                }

                var directories = Directory.GetDirectories(sourcePath);

                foreach (var directory in directories)
                {
                    var dest = directory.Replace(sourcePath, destPath);
                    Directory.CreateDirectory(dest);
                    copyDirectory(directory, dest);
                }
            }

            void cleanDirectory(string path)
            {
                if (Directory.Exists(path))
                {
                    string[] files = Directory.GetFiles(path);

                    foreach (string filePath in files)
                    {
                        File.Delete(filePath);
                    }

                    string[] directories = Directory.GetDirectories(path);

                    foreach (string directoryPath in directories)
                    {
                        // 재귀함수로 자기 호출
                        cleanDirectory(directoryPath);
                    }

                    Directory.Delete(path);
                }
            }
        }
        static void Main(string[] args)
        {
            //HelloWord();
            //PrimitiveTypesToBinary();
            //TypeConversion();
            //Calculator();
            //IncDecOperator();
            //BitMultiplicationAndDividation();
            //StringTypeAndASCIIAndFormatting();
            //KeyboardInput();
            //LogicalExpressions();
            //OrderOfExpressionEvaluation();
            //Iterator();
            //Functions();
            //Enums();
            //Asserts();
            //RecursiveFactorial();
            //RandomSuffling();
            //ArrayOfArrays();
            //TextMessage();
            //FunctionOverloading();
            //defaultParameter();
            //OutParameterModifier();
            //StringBuilderExample();
            //FloatVsDoubleVsDecimal();
            //ListAndDictionary();
            //AboutClass();
            //PartialClass();
            //StaticMethod();
            //StaticClass();
            //ExtensionMethod();
            //ValueVsReference();
            //Struct();
            //Nullable();
            //StudyLinq();
            //ReadAndWriteFile();
            //tryCatchFianlly();
            //ReadAndWriteFileUsingFileStream();
            //UsingStatement();
            CopyDirectory();
        }
    }
}