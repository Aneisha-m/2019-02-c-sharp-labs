﻿using System.IO;
using System;
using static System.Console;
using System.Text;

namespace lab_08_files
{
    class Program
    {
        static void Main(string[] args)
        {
            //read file
            string data01 = File.ReadAllText("file.txt"); // avoid absolute paths
            WriteLine(data01);
            //add encoding (optional)
            string data02 = File.ReadAllText("file.txt", Encoding.UTF8);
            WriteLine($"\n\n\n {data02}");

            WriteLine($"\n\n\n {data02,30}");

            WriteLine($"\n\n\n {"hi",20}{"there",-20}");
            WriteLine($"\n\n\n {"hi",20}{"are",-20}");
            WriteLine($"\n\n\n {"hi",20}{"???",20}");

            //read array as 
            string[] data03 = File.ReadAllLines("file.txt");
            Console.WriteLine("\n\nReading as array\n\n");
            Console.WriteLine(data03[0]);
            Console.WriteLine(data03[1]);
            Console.WriteLine(data03[2]);

            //write data
            Console.WriteLine("\ncreate new file\n");
            File.WriteAllText("file2.txt", "here is \nsome \ndata");
            Console.WriteLine(File.ReadAllText("file2.txt"));

            Console.WriteLine("\nNow write an array to text \n");
            File.WriteAllLines("file3.txt", data03);
            Console.WriteLine("\n And read it back\n");
            Console.WriteLine(File.ReadAllText("file3.txt"));

            //copy file
            File.Copy("file1.txt", "copyoffile1.txt", true); //overwrite (true)

            //delete
            File.Delete("copyoffile1.txt");

            Console.WriteLine("\ndoes my file exist?\n");
            Console.WriteLine(File.Exists("file.txt"));

            Console.WriteLine(File.GetCreationTime("file.txt"));
            Console.WriteLine(File.GetLastWriteTime("file.txt"));

            //EXTRA INFO
            var fileinfo = new FileInfo("file.txt");
            Console.WriteLine(fileinfo.DirectoryName);
            Console.WriteLine(fileinfo.Extension);

            //directory
            Directory.CreateDirectory("folderA");
            Directory.CreateDirectory("folderB");
            Directory.Delete("folderB");
            File.Create("foldera/abc.txt");
            Console.WriteLine("\nlist files in folder\n");
            var fileArray = Directory.GetFiles("folderA");
            Console.WriteLine(fileArray[0]);

        }

    }
}
