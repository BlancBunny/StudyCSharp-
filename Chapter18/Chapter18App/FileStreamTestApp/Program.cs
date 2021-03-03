using System;
using System.IO;

namespace FileStreamTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"D:\GitRepository\StudyCSharp21\SampleDir\SubFolder\a.dat";
            using (FileStream fs = new FileStream(filePath, FileMode.Create))
                
            {
                StreamWriter sw = new StreamWriter(fs);
                StreamReader sr = new StreamReader(fs);
                try
                {
                    
                    sw.WriteLine("Hello world!");
                    sw.WriteLine("BlancBunny");
                    sw.Write(int.MaxValue);
                    
                    while (sr.EndOfStream == false)
                    {
                        Console.WriteLine(sr.ReadLine());
                    }
                    Console.WriteLine($"File size : {sr.BaseStream.Length} bytes");
                    sw.Flush();

                }
                catch (Exception ex) { Console.WriteLine($"파일쓰기 예외발생 : {ex.Message}"); }
                finally { sw.Close(); }

                
            }
            
        }
    }
}
