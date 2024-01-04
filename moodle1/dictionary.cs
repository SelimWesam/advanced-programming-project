using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using iText.Kernel.Pdf;
using System.Diagnostics;

namespace moodle1
{
     class dictionary:dict
    {
        public string[] key = new string[30];
        public string[] value = new string[30];
        public string[] fname= new string[30];
        public dictionary()
        {
            for (int i = 0; i < 30; i++)
            {
                key[i] = null;
                value[i] = null;
                fname[i] = null;
            }
        }
        

        public int Length()
        {
            int c = 0;
            for (int i = 0; i < 30; i++)
            {
                if (this.key[i] != null)
                {
                    c++;
                }
            }
            return c;

        }
       

        public bool IsEmpty(string key)
        {
            int count = 0;
            for (int i = 0; i < 30; i++)
            {
                if (this.key[i] == key)
                {
                    count = 0;
                    break;
                }
                else 
                    count= 1;
            }
            if (count == 1) 
                return true;
            else return false;
        }
        public void Add(string key, string value, string fname)
        {
            int count = 0;
            for (int i = 0; i < 30; i++)
            {
                if (this.key[i] != null)
                    count++;
            }

            this.key[count] = key;
            this.value[count] = value;
            this.fname[count] = fname;
        }
        public bool find(string key)
        {
            bool found = false;
            for (int i = 0; i < 30; i++)
            {
                if (this.key[i] != null)
                    if (this.key[i].Equals(key))
                        found = true;
            }
            return found;
        }
       
        public void edit(string key, string value, string fname)
        {
            int t = 0;
            for (int i = 0; i < 30; i++)
            {
                if (this.key[i] == key && this.value[i] == value)
                {
                    this.fname[i] = fname;
                    t = 0;
                    Console.WriteLine("lecture edited");
                    break;
                }
                else
                    t = 1;
            }
            if (t == 1)
            {
                Console.WriteLine("lecture  not found in the dictionary");
            }
        }
        public void delete(string key, string value)
        {
            int x = 0;
            for (int i = 0; i < 30; i++)
            {
                if (this.key[i] != null)
                    if (this.key[i].Equals(key) && this.value[i] == value)
                    {
                        this.value[i] = null;
                        this.key[i] = null;
                        this.fname[i] = null;
                        Console.WriteLine("lecture deleted");
                     
                        x = 0;
                        break;
                    }
                    else
                    {
                        x = 1;
                    }
            }
            if (x == 1)
            {
                Console.WriteLine("lecture not found");
            }
        }
        
        public void findLect(string key,string value)
        {
            int r = 0;
            for (int i = 0; i < 30; i++)
            {
                if (this.key[i] != null)
                    if (this.key[i].Equals(key) && this.value[i].Equals(value))
                        OpenPdfFile(fname[i]);
                r = 1;
            }
            if (r == 0)
            {
                Console.WriteLine("no lectures in this stubject");
            }

        }
        
        public void sort()
        {
            Array.Sort(key, 0, Length());
        }
        public void OpenPdfFile(string filePath)
        {
            try
            {
                
                Process.Start(filePath);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error opening PDF file: {ex.Message}");
            }
        }
    }
}

    

