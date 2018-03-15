using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bmi
{
    class Program
    {
        static void Main(string[] args)
        {
            int high, weight;

            Console.Write("請輸入您的身高:");
            high = int.Parse(Console.ReadLine());
            Console.Write("請輸入您的體重:");
            weight = int.Parse(Console.ReadLine());
            Console.Write("請確認您的身高/體重:" + high + weight);
        }
    }
}
