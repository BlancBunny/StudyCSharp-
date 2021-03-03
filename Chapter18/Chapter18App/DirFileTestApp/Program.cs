using System;
using System.IO;
namespace DirFileTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string strDir = @"D:\GitRepository\StudyCSharp21\SampleDir"; 
            string strTargetDir = "SubFolder"; // 생성할 폴더명 
            string strTargetFile = "readme.txt"; // 생성할 파일명

            string targetPath = strDir + "\\" + strTargetDir;

            if (Directory.Exists(targetPath))
            {
                Console.WriteLine("이미 폴더가 존재합니다.");
            }
            else { Directory.CreateDirectory(targetPath); }
        }
    }
}

