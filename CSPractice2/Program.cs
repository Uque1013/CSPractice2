using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSPractice2
{
    internal class Program
    {
        class Parent
        {
            public int variable = 273;
            public void Method()
            {
                Console.WriteLine("부모 메서드");
            }
        }
        class Child : Parent
        {
            public new string variable = "하이딩";
            public new void Method()
            {
                Console.WriteLine("자식 메서드");
            }
        }

        public static int number = 10;
        static void Main(string[] args)
        {
            // #6 23-7. 새도잉
            int number = 20;
            Console.WriteLine(number);

            // #6 23-7. 하이딩
            Child child = new Child();
            Console.WriteLine(child.variable); // 출력: 하이딩
            child.Method(); // 출력: 자식 메서드
            Console.WriteLine(((Parent)child).variable); // 출력: 273
            ((Parent)child).Method(); // 출력: 부모 메서드
            Parent p = child;
            Console.WriteLine(p.variable); // 출력: 273
            p.Method(); // 출력: 부모 메서드
            ((Child)p).Method(); // 출력: 자식 메서드
        }
    }
} 
