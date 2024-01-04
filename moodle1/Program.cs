using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas.Parser;
using System.Collections;
using System.Diagnostics;
using System.Globalization;
using System.Data.SqlClient;

namespace moodle1
{
     class Program
    {
        static void Main(string[] args)
        {
            dictionary mydict=new dictionary();
            
            //addind math 5
            mydict.Add("math 5", "lecture 1", "D:\\selim\\sem 5\\math\\Math_5_Notes.pdf");
            mydict.Add("math 5", "lecture 2", "D:\\selim\\sem 5\\math\\Formulas you may use.pdf");

            // adding communication theory
            mydict.Add("communication theory", "lecture 1", "D:\\selim\\sem 5\\communication\\EC320 communications theory  updated .pdf");

            // adding electronics
            mydict.Add("electronics", "lecture 1", "D:\\selim\\sem 5\\elect 2\\EC339_Sheet_2_DC.pdf");
            mydict.Add("electronics", "lecture 2", "D:\\selim\\sem 5\\elect 2\\EC339_Sheet_3_AC.pdf");
            mydict.Add("electronics", "lecture 3", "D:\\selim\\sem 5\\elect 2\\EC339_Sheet_5_FB1.pdf");
            mydict.Add("electronics", "lecture 4", "D:\\selim\\sem 5\\elect 2\\EC339_Sheet_6_FB2.pdf");


            // adding power and machines
            mydict.Add("power and machines", "lecture 1", "D:\\selim\\sem 5\\power\\ee328 - lec 5.pdf");
            mydict.Add("power and machines", "lecture 2", "D:\\selim\\sem 5\\power\\IDEAL TRANS_lecture5 (3).pdf");


            // adding digital system 
            mydict.Add("digital systems", "lecture 1", "D:\\selim\\sem 5\\digital\\AAST-CC317-Lec 01.pdf");
            mydict.Add("digital systems", "lecture 2", "D:\\selim\\sem 5\\digital\\AAST-CC317-Lec 02.pdf");
            mydict.Add("digital systems", "lecture 3", "D:\\selim\\sem 5\\digital\\AAST-CC317-Lec 03.pdf");
            mydict.Add("digital systems", "lecture 4", "D:\\selim\\sem 5\\digital\\AAST-CC317-Lec 04.pdf");
            mydict.Add("digital systems", "lecture 5", "D:\\selim\\sem 5\\digital\\AAST-CC317-Lec 05.pdf");
            mydict.Add("digital systems", "lecture 6", "D:\\selim\\sem 5\\digital\\AAST-CC317-Lec 06.pdf");
            // adding advanced programming
            mydict.Add("advanced programming", "lecture 1", "D:\\selim\\sem 5\\prog\\Lecture_1.pdf");
            mydict.Add("advanced programming", "lecture 2", "D:\\selim\\sem 5\\prog\\Lecture 2.pdf");
            mydict.Add("advanced programming", "lecture 3", "D:\\selim\\sem 5\\prog\\Lecture 3.pdf");
            mydict.Add("advanced programming", "lecture 4", "D:\\selim\\sem 5\\prog\\Lecture 4.pdf");


            Console.WriteLine("enter your user name");
            string username=Console.ReadLine();
            if (username != "admin")
            {
                int y = 1;
                while (y == 1)
                {
                    Console.WriteLine(" enter  1. advanced programming  2. electronics  3. digital systems  4. power and machine  5. communication theory  6. math 5");
                    int m = int.Parse(Console.ReadLine());
                    if (m == 1)
                    {
                        int p = 1;
                        while (p == 1)
                        {
                            Console.WriteLine("choose the lecture number you want to open between 1 to 4");
                            int z = int.Parse(Console.ReadLine());
                            mydict.findLect("advanced programming", "lecture " + z);
                            Console.WriteLine("enter 1 to continue in the same subject");
                            int s = int.Parse(Console.ReadLine());
                            p = s;
                        }
                        Console.WriteLine("to choose another subject enter 1");
                        int w = int.Parse(Console.ReadLine());
                        y = w;
                    }
                    else if (m == 2)
                    {
                        int p = 1;
                        while (p == 1)
                        {
                            Console.WriteLine("choose the lecture number you want to open between 1 to 4");
                            int z = int.Parse(Console.ReadLine());
                            mydict.findLect("electronics", "lecture " + z);
                            Console.WriteLine("enter 1 to continue");
                            int s = int.Parse(Console.ReadLine());
                            p = s;
                        }
                        Console.WriteLine("to choose another subject enter 1");
                        int w = int.Parse(Console.ReadLine());
                        y = w;
                    }
                    else if (m == 3)
                    {
                        int p = 1;
                        while (p == 1)
                        {
                            Console.WriteLine("choose the lecture number you want to open between 1 to 6");
                            int z = int.Parse(Console.ReadLine());
                            mydict.findLect("digital systems", "lecture " + z);
                            Console.WriteLine("enter 1 to continue");
                            int s = int.Parse(Console.ReadLine());
                            p = s;

                        }
                        Console.WriteLine("to choose another subject enter 1");
                        int w = int.Parse(Console.ReadLine());
                        y = w;
                    }
                    else if (m == 4)
                    {
                        int p = 1;
                        while (p == 1)
                        {
                            Console.WriteLine("choose the lecture number you want to open between 1 to 2");
                            int z = int.Parse(Console.ReadLine());
                            mydict.findLect("power and machines", "lecture " + z);
                            Console.WriteLine("enter 1 to continue");
                            int s = int.Parse(Console.ReadLine());
                            p = s;
                        }
                        Console.WriteLine("to choose another subject enter 1");
                        int w = int.Parse(Console.ReadLine());
                        y = w;
                    }
                    else if (m == 5)
                    {
                        int p = 1;
                        while (p == 1)
                        {
                            Console.WriteLine("oppening all lectures");
                            mydict.findLect("communication theory", "lecture 1");
                            Console.WriteLine("enter 1 to continue");
                            int s = int.Parse(Console.ReadLine());
                            p = s;

                        }
                        Console.WriteLine("to choose another subject enter 1");
                        int w = int.Parse(Console.ReadLine());
                        y = w;
                    }
                    else if (m == 6)
                    {
                        int p = 1;
                        while (p == 1)
                        {
                            Console.WriteLine("to open all notes enter 1, to open the formula sheet enter 2");
                            int z = int.Parse(Console.ReadLine());
                            mydict.findLect("math 5", "lecture " + z);
                            Console.WriteLine("enter 1 to continue");
                            int s = int.Parse(Console.ReadLine());
                            p = s;

                        }
                        Console.WriteLine("to choose another subject enter 1");
                        int w = int.Parse(Console.ReadLine());
                        y = w;
                    }
                }
            }
            else if (username == "admin")
            {
                int r= 1;
                while (r == 1)
                {
                    Console.WriteLine("enter 1. to edit 2. to delete 3.to find a lecture 4. find the subject  5. to check if it a subject is empty or not 6. to add");
                    int x = int.Parse(Console.ReadLine());
                    if (x == 1)
                    {
                        Console.WriteLine("enter the subject you want to edit in");
                        string key = Console.ReadLine();
                        Console.WriteLine(" enter the lecture you want to edit in it");
                        string value = Console.ReadLine();
                        Console.WriteLine("enter the new file path for the lecture ");
                        string fname = Console.ReadLine();
                        mydict.edit(key, value, fname);
                    }
                    else if (x == 2)
                    {
                        Console.WriteLine("enter the subject you want to delete it");
                        string key = Console.ReadLine();
                        Console.WriteLine(" enter the lecture you want to delete it");
                        string value = Console.ReadLine();
                        mydict.delete(key, value);

                    }
                    else if (x == 4)
                    {
                        Console.WriteLine("enter the subject you are searching for");
                        string key = Console.ReadLine();
                        bool f = mydict.find(key);
                        if (f == true)
                        {
                            Console.WriteLine("found ");
                        }
                        else Console.WriteLine("not found ");
                    }
                    else if (x == 3)
                    {
                        Console.WriteLine("enter the subject you are searching for");
                        string key = Console.ReadLine();
                        Console.WriteLine("enter the lecture you are seraching for");
                        string value = Console.ReadLine();
                        mydict.findLect(key, value);

                    }
                    else if (x == 5)
                    {
                        Console.WriteLine("enter subject you want to check in");
                        string key=Console.ReadLine();
                        bool c=mydict.IsEmpty(key);
                        if (c == false)
                        {
                            Console.WriteLine("this subject is not empty");
                        }
                        else
                            Console.WriteLine("this subject is empty");
                    }
                    else if (x == 6)
                    {
                        Console.WriteLine("enter the subject you want to add");
                        string key = Console.ReadLine();
                        Console.WriteLine(" enter the lecture you want to add in it");
                        string value = Console.ReadLine();
                        Console.WriteLine("enter the new file path for the lecture ");
                        string fname = Console.ReadLine();
                        mydict.Add(key, value,fname);
                    }
                    else if(x>6 || x<1) { 
                        Console.WriteLine("wrong data entry, enter again");
                        r = 1;
                    }
                    Console.WriteLine(" enter 1 to continue");
                    int z = int.Parse(Console.ReadLine());
                    r = z;
                    
                }

            }
            Console.ReadLine();
        }
    }
}

