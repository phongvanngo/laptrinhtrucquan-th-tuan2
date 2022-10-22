﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;
using MyUtilityClasses.NBatDongSan;

namespace Bai05
{
    class Program
    {
        static void Main(string[] args)
        {

            int so_dat_dai;
            int so_nha_pho;
            int so_chung_cu;

            List<BatDongSan> bat_dong_san = new List<BatDongSan>();
            Console.Write("Dat dai: ");
            so_dat_dai = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nha pho: ");
            so_nha_pho = Convert.ToInt32(Console.ReadLine());
            Console.Write("Chung cu: ");
            so_chung_cu = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < so_dat_dai; i++)
            {
                DatDai datdai = new DatDai();
                datdai.Input();
                bat_dong_san.Add(datdai);
            }

            for (int i = 0; i < so_nha_pho; i++)
            {
                NhaPho nhapho = new NhaPho();
                nhapho.Input();
                bat_dong_san.Add(nhapho);
            }

            for (int i = 0; i < so_chung_cu; i++)
            {
                ChungCu chungcu = new ChungCu();
                chungcu.Input();
                bat_dong_san.Add(chungcu);
            }


            foreach (var item in bat_dong_san)
            {
                item.Print();
                Console.WriteLine();
            };

            //list 
            foreach (var item in bat_dong_san)
            {
                if (item.GetType() == typeof(NhaPho))
                {
                    if (((NhaPho)item).Year > 2019 && item.Area > 60) item.Print();
                }
                else
                {
                    if (item.Area > 100) item.Print();
                }
            };

            string search_location = Console.ReadLine();
            int search_price = Convert.ToInt32(Console.ReadLine());
            int search_area = Convert.ToInt32(Console.ReadLine()); ;

            foreach (BatDongSan item in bat_dong_san)
            {
                if (item.Location.ToLower() == search_location.ToLower())
                    if (item.Price < search_price && item.Area < search_area)
                        item.Print();
            }

        }
    }
}
