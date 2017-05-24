using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using iUtils;
using System.IO;

namespace iUtilsTest
{
    class Program
    {
        static FileNFolder fileNFolder = new FileNFolder();

        static void Main(string[] args)
        {
            
            System.Console.WriteLine("TEST-START:.");
            System.Console.WriteLine("============================");

            try {
                String path = null;
                String result = fileNFolder.copyFileNameFromPath(path);

                System.Console.WriteLine(result);

                //String from = @"C:\Users\AFTECH\Desktop\[S]Kanji.jpg";
                //String to = @"C:\Qui\TV\abcd\ax.x";
                String from = null;
                String to = null;
                //fileNFolder.copyFile(from, to);
            }
            catch (Exception e) {
                System.Console.WriteLine(e);
            }

            System.Console.WriteLine("============================");
            System.Console.WriteLine(".:TEST-END");
            Console.ReadLine();
        }
    }
}
