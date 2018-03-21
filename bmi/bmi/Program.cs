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
            float High, Weight;

            while (true)
            {
                Console.Write("請輸入您的身高:");
                High = float.Parse(Console.ReadLine());
                Console.Write("請輸入您的體重:");
                Weight = float.Parse(Console.ReadLine());
                Console.WriteLine("請確認您的身高/體重:" + High + "/" + Weight);
                Console.WriteLine("資料正確請按Enter鍵，錯誤請按其他鍵。");

                if (Console.ReadKey().Key == ConsoleKey.Enter)//判斷資料的填寫是否正確
                {
                    float Bmi;
                    Bmi = Weight / ((High / 100) * (High / 100));//BMI計算式
                    Console.WriteLine("您的BMI為:" + Bmi);

                    if (Bmi < 16.5)
                    {
                        Console.WriteLine("恭喜您是免役體位。");
                        Console.Read();
                    }


                    else if (16.5 < Bmi && Bmi < 17)
                    {
                        Console.WriteLine("恭喜您是替代役體位。");
                        Console.Read();
                    }

                    else if (17 < Bmi && Bmi < 31)
                    {
                        Console.WriteLine("抱歉，您是常備役體位......");
                        Console.Read();
                    }

                    else if (31 < Bmi && Bmi < 31.5)
                    {
                        Console.WriteLine("恭喜您是替代役體位。");
                        Console.Read();
                    }

                    else
                    {
                        Console.WriteLine("恭喜您是免役體位。");
                        Console.Read();
                    }
                }
                else
                {
                    Console.WriteLine();
                    continue;//跳回While的開頭
                }

                break;//跳出迴圈
            }
        }
    }
}
