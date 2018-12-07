﻿using System;
using System.Collections.Generic;
using System.CodeDom.Compiler;
using System.CodeDom;
using System.Collections.Concurrent;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Resources;
using System.CodeDom;
using System.Collections;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Deployment;
using System.Diagnostics;
using System.Dynamic;
using System.Globalization;
using System.IO;
using System.Management;
using System.Media;
using System.Net;
using System.Reflection;
using System.Resources;
using System.Runtime;
using System.Security;
using System.StubHelpers;
using System.Threading;


namespace ConsoleApplication1
{
    class Program
    {
        public static void ConsoleWriteImage(Bitmap bmpSrc)
        {
            int sMax = 39;
            decimal percent = Math.Min(decimal.Divide(sMax, bmpSrc.Width), decimal.Divide(sMax, bmpSrc.Height));
            Size resSize = new Size((int)(bmpSrc.Width * percent), (int)(bmpSrc.Height * percent));
            Func<System.Drawing.Color, int> ToConsoleColor = c =>
            {
                int index = (c.R > 128 | c.G > 128 | c.B > 128) ? 8 : 0;
                index |= (c.R > 64) ? 4 : 0;
                index |= (c.G > 64) ? 2 : 0;
                index |= (c.B > 64) ? 1 : 0;
                return index;
            };
            Bitmap bmpMin = new Bitmap(bmpSrc, resSize.Width, resSize.Height);
            Bitmap bmpMax = new Bitmap(bmpSrc, resSize.Width * 2, resSize.Height * 2);
            for (int i = 0; i < resSize.Height; i++)
            {
                for (int j = 0; j < resSize.Width; j++)
                {
                    Console.ForegroundColor = (ConsoleColor)ToConsoleColor(bmpMin.GetPixel(j, i));
                    Console.Write("██");
                }

                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write("    ");

                for (int j = 0; j < resSize.Width; j++)
                {
                    Console.ForegroundColor = (ConsoleColor)ToConsoleColor(bmpMax.GetPixel(j * 2, i * 2));
                    Console.BackgroundColor = (ConsoleColor)ToConsoleColor(bmpMax.GetPixel(j * 2, i * 2 + 1));
                    Console.Write("▀");

                    Console.ForegroundColor = (ConsoleColor)ToConsoleColor(bmpMax.GetPixel(j * 2 + 1, i * 2));
                    Console.BackgroundColor = (ConsoleColor)ToConsoleColor(bmpMax.GetPixel(j * 2 + 1, i * 2 + 1));
                    Console.Write("▀");
                }
                System.Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            System.Console.WindowWidth = 170;
            System.Console.WindowHeight = 40;

            Bitmap bmpSrc = new Bitmap(@"image.bmp", true);

            ConsoleWriteImage(bmpSrc);

            System.Console.ReadLine();
        }
    }
}
