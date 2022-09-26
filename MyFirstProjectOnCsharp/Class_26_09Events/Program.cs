using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class26_09_Delegate
{
    delegate void DelegateWorkDelegate();
    
    internal class Program
    {
        static void Main(string[] args)
        {
           /* string[] massiveFiles = new string[10]
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
            };*/

            List<AnyDocument> list = new List<AnyDocument>()
            {
                new AnyDocument("First","pdf"),
                new AnyDocument("Second","doc"),
                new AnyDocument("First","txt"),
                new AnyDocument("First","xlsx"),
                new AnyDocument("First","csv")
            };
            WorkWithDocuments wwd = new WorkWithDocuments();

            DelegateWorkDelegate dwd = null;
            foreach (AnyDocument file in list)
            {
                dwd = null;
                dwd += WorkWithDocuments.OutInfoDOC;
                file.ChangeType("doc");
                wwd.DocumentsToDOCX(dwd);
            }
                wwd.Start();
        }
        
    }
    class AnyDocument
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public AnyDocument(string name, string type)
        {
            Name = name;
            Type = type;
        }
        public void ChangeType(string newType)
        {
            Type = newType;
        }
        public override string ToString()
        {
            return Name + "." + Type;
        }
    }
    class WorkWithDocuments
    {
        event DelegateWorkDelegate DelegateEvent;
        public void DocumentsToDOCX(DelegateWorkDelegate dwd)
        {
            if (dwd != null)
            { 
                 DelegateEvent   += dwd;
            }
        }
        public void Start()
        {
            if(DelegateEvent != null)
            {
                DelegateEvent.Invoke();
            }
        }
        public static void OutInfoDOC() 
        {
            Console.WriteLine("Это документ Word "); 
        }
        //public static void OutInfoTXT(string txt) { Console.WriteLine("Это текстовый документ!({0})", txt); }
        //public static void OutInfoPDF(string pdf) { Console.WriteLine("Это документ PDF!({0})", pdf); }
        //public static void OutInfoXLSX(string xlsx) { Console.WriteLine("Это документ MS Excel!({0})", xlsx); }
        //public static void OutInfoCSV(string csv) { Console.WriteLine("Это текстовый документ с разделителем!({0})", csv); }
    }
}
