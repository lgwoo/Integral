using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integral
{
    class Program
    {


        static double Fontion(double x, int[] arr)
        {
            double fx = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (i==0)
                {
                    fx = arr[i];
                }
                else
                {
                    fx = fx + arr[i] * Math.Pow(x,i);
                }
            }
            return fx;
        }



        static void Main(string[] args)
        {
            int HighestOrderTerm;
            int[] function;
            double integral = 0;


            Console.WriteLine("정적분을 구할 함수의 최고차항의 함수를 적어주세요.");
            Console.WriteLine("** 정수만 적어주세요 **");
      

            HighestOrderTerm = int.Parse(Console.ReadLine());
            function = new int[HighestOrderTerm + 1];


            for (int i = 0; i <= HighestOrderTerm; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine("상수항을 입력하세요");
                    function[i] = int.Parse(Console.ReadLine());

                }
                else
                {
                    Console.WriteLine(i + "차항의 계수를 입력해주세요.");
                    function[i] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("적분구간을 정해주세요. 어디서부터 시작할건가요?");
            double start = double.Parse(Console.ReadLine());
            Console.WriteLine("어디까지 할건가요?");
            double end = double.Parse(Console.ReadLine());
            Console.WriteLine("몇개로 쪼개서 더할건지 정하세요.");
            double bar = double.Parse(Console.ReadLine());


            double gap = (end - start) / bar;

            for (int i = 1; i <= bar; i++)
            {
                // Console.WriteLine("함수값에 넣을 x값" + (start + gap * i));
                // Console.WriteLine("함수에 넣고 나온값(y값)" + Fontion((start + gap * i), function));
                integral = integral + gap * Fontion(start + gap * i, function);
                //Console.WriteLine(integral);
            }

            Console.WriteLine("정적분의 값은 " + integral);

            Console.ReadLine();
        }
    }
}
