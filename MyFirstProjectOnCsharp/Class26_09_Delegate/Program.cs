using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class26_09_Delegate
{
    delegate void DelegateWorkDelegate(string a);
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] massiveFiles = new string[10]
            {   "first.doc",
                "second.doc",
                "third.txt",
                "four.pdf",
                "five.xlsx",
                "six.txt",
                "seven.pdf",
                "eight.xlsx",
                "nine.csv",
                "ten.csv"
            };
            DelegateWorkDelegate dwd = null;
            foreach(string file in massiveFiles)
            {
                dwd = null;
                string[] filemassive = file.Split('.');
                switch(filemassive[1])
                {
                    case "doc":dwd += OutInfoDOC;dwd(file); break;
                    case "txt": dwd += OutInfoTXT; dwd(file); break;
                    case "pdf": dwd += OutInfoPDF; dwd(file); break;
                    case "xlsx": dwd += OutInfoXLSX; dwd(file); break;
                    case "csv": dwd += OutInfoCSV; dwd(file); break;
                        default: Console.WriteLine("Что-то пошло не так!!!");break;
                }
            }
        }
        static void OutInfoDOC(string doc) { Console.WriteLine("Это документ MS Word!({0})",doc); }
        static void OutInfoTXT(string txt) { Console.WriteLine("Это текстовый документ!({0})",txt); }
        static void OutInfoPDF(string pdf) { Console.WriteLine("Это документ PDF!({0})",pdf); }
        static void OutInfoXLSX(string xlsx) { Console.WriteLine("Это документ MS Excel!({0})",xlsx); }
        static void OutInfoCSV(string csv) { Console.WriteLine("Это текстовый документ с разделителем!({0})",csv); }
    }
}
