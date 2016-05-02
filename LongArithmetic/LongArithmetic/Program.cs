using System;
using System.Collections.Generic;

namespace LongArithmetic
{
    class Program
    {
        private static int _orderNumber;

        static void Main(string[] args)
        {

            
            var a = new LongNumber(new List<byte> {255,1});
            var b  = new LongNumber(new List<byte>{1,255});

            ComplexTest(a, b);

          
            a = new LongNumber(new List<byte>{255,255,255,255});
            b = new LongNumber(new List<byte>{1,0,0,0,1});
            
            ComplexTest(a, b);



            a = LongNumber.FromDecString("+1000000000000000000000000000");
            b = LongNumber.FromDecString("+1000000000000000000000000000");

            ComplexTest(a, b);
           

                  }

        static void ComplexTest(LongNumber a, LongNumber b)
        {// общий тест, компелексный так сказать
            Console.ForegroundColor = ConsoleColor.Green; 
            Console.WriteLine("######### Test set #" + (++_orderNumber) + " #########");
            Console.ResetColor();
          
            var st = DateTime.Now;
            var slt = DateTime.Now;
            AddSubTest(a, b);
            var lt = DateTime.Now - slt;
            Console.ForegroundColor = ConsoleColor.Magenta; 
            Console.WriteLine("AddSubTest time " + lt.Seconds + " sec " + lt.Milliseconds + " msec");
            Console.ResetColor();
            slt = DateTime.Now;
            MulTest(a, b);
            lt = DateTime.Now - slt;
            Console.ForegroundColor = ConsoleColor.Magenta; 
            Console.WriteLine("MulTest time " + lt.Seconds + " sec " + lt.Milliseconds + " msec");
            Console.ResetColor();
            slt = DateTime.Now;
            DivTest(a, b);
            lt = DateTime.Now - slt;
            Console.ForegroundColor = ConsoleColor.Magenta; 
            Console.WriteLine("DivTest time " + lt.Seconds + " sec " + lt.Milliseconds + " msec");
            Console.ResetColor();
            var t =  DateTime.Now - st;
            Console.ForegroundColor = ConsoleColor.Red; 
            Console.WriteLine("Total time "+ t.Seconds + " sec " + t.Milliseconds + " msec");
            Console.ResetColor();
            Console.WriteLine();
        }

        private static void DivTest(LongNumber a, LongNumber b)
        { //тесты
            Console.WriteLine("***********************");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Divide test");
            Console.ForegroundColor = ConsoleColor.DarkYellow; 
            Console.Write("a = ");
            Console.ResetColor();
            Console.WriteLine(a + " ( " + a.ToDecString() + " )");
            Console.ForegroundColor = ConsoleColor.DarkYellow; 
            Console.Write("b = ");
            Console.ResetColor();
            Console.WriteLine(b + " ( " + b.ToDecString() + " )");
            var c = a/b;
            Console.ForegroundColor = ConsoleColor.DarkYellow; 
            Console.Write("a / b = ");
            Console.ResetColor();
            Console.WriteLine(c + " ( " + c.First.ToDecString() + " , " + c.Second.ToDecString() + " )");
            var d = (b*c.First + c.Second);
            Console.ForegroundColor = ConsoleColor.DarkYellow; 
            Console.Write("c * a + b = ");
            Console.ResetColor();
            Console.WriteLine(d + " ( " + d.ToDecString() + " )");
            Console.WriteLine("***********************");

        }

        private static void MulTest(LongNumber a, LongNumber b)
        {// тесты
            Console.WriteLine("***********************");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Multiply test");
            Console.ForegroundColor = ConsoleColor.DarkYellow; 
            Console.Write("a = ");
            Console.ResetColor();
            Console.WriteLine(a + " ( " + a.ToDecString() + " )");
            Console.ForegroundColor = ConsoleColor.DarkYellow; 
            Console.Write("b = ");
            Console.ResetColor();
            Console.WriteLine(b + " ( " + b.ToDecString() + " )");
            var c = a*b;
            Console.ForegroundColor = ConsoleColor.DarkYellow; 
            Console.Write("a * b = ");
            Console.ResetColor();
            Console.WriteLine(c + " ( " + c.ToDecString() + " )");
            var d = c/b;
            Console.ForegroundColor = ConsoleColor.DarkYellow; 
            Console.Write("c / b = ");
            Console.ResetColor();
            Console.WriteLine(d + " ( " + d.First.ToDecString() + " , " + d.Second.ToDecString() + " )");
            var e = c/a;
            Console.ForegroundColor = ConsoleColor.DarkYellow; 
            Console.Write("c / a = ");
            Console.ResetColor();
            Console.WriteLine(e + " ( " + e.First.ToDecString() + " , " + e.Second.ToDecString() + " )");
            Console.WriteLine("***********************");

        }

        private static void AddSubTest(LongNumber a, LongNumber b)
        {// всякие тесты
            Console.WriteLine("***********************");
            Console.ForegroundColor = ConsoleColor.DarkRed; 
            Console.WriteLine("add-sub test");
            Console.ForegroundColor = ConsoleColor.DarkYellow; 
            Console.Write("a = ");
            Console.ResetColor();
            Console.WriteLine(a + " ( " + a.ToDecString() + " )");
            Console.ForegroundColor = ConsoleColor.DarkYellow; 
            Console.Write("b = ");
            Console.ResetColor();
            Console.WriteLine(b + " ( " + b.ToDecString() + " )");
            var c = a + b;
            Console.ForegroundColor = ConsoleColor.DarkYellow; 
            Console.Write("a + b = ");
            Console.ResetColor();
            Console.WriteLine(c + " ( " + c.ToDecString() + " )");
            var d = a - b;
            Console.ForegroundColor = ConsoleColor.DarkYellow; 
            Console.Write("a - b = ");
            Console.ResetColor();
            Console.WriteLine(d + " ( " + d.ToDecString() + " )");
            a.ChandgeSing();
            var k = a + b;
            Console.ForegroundColor = ConsoleColor.DarkYellow; 
            Console.Write("-a + b = ");
            Console.ResetColor();
            Console.WriteLine(k + " ( " + k.ToDecString() + " )");
            a.ChandgeSing();
            Console.WriteLine("***********************");

        }


    }
}
