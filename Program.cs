﻿using System;
using System.Text;

namespace tinhtienlaichovay
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = 1.0;
            int month = 1;
            double intersetRate = 1.0;
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine("Nhập số tiền gửi: ");
            money = Double.Parse(Console.ReadLine());
            Console.WriteLine("Nhập số tháng gửi: ");
            month = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Nhập lãi suất: ");
            intersetRate = Double.Parse(Console.ReadLine());
            double totalInterset = 0;
            for (int i = 0; i < month; i++)
            {
                totalInterset = money * (intersetRate / 100) / 12 * 3;
            }
            Console.WriteLine("Lãi suất nhận được: " + totalInterset);
        }
    }
}