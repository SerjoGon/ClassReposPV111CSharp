using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Class_23_09_BookShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region BOOKSHOPCHICK
            /*
            string[] shop = new string[10] {"Book", "Book1", "Book2", "Book3", "Book4", "Book5", "Book6", "Book7", "Book8", "Book9", };
            Console.WriteLine("Книги в магазине: ");
            foreach(string book in shop)
            {
                Console.WriteLine(book);
            }
            List<string> list = new List<string>();
            list.Add("Book");
            list.Add("Book1");
            list.Add("Book2");
            list.Add("Book3");
            list.Add("Book4");
            list.Add("Book5");
            list.Add("Book6");
            list.Add("Book7");
            list.Add("Book8");
            list.Add("Book9");

            foreach (string book in list)
            {
                Console.WriteLine(book);
            }
            Console.WriteLine("Добавьте книгу написав ее название:");
            list.Add(Console.ReadLine());
            foreach(string book in list)
            {
                Console.WriteLine(book);
            }
            Console.WriteLine("Добавьте книгу написав ее название:");
            list.Remove(Console.ReadLine());
            foreach(string book in list)
            {
                Console.WriteLine(book);
            }*/
            #endregion
            #region BOOKSHOPCHICK2
            List<Book> books = new List<Book>
            {
                new Book("ОНО", "America", "Horror", "Stephen King", 650, 1991, 1000),
                new Book("ОНО2", "America", "Horror", "Stephen King", 700, 1993, 1000),
                new Book("ОНО3", "America", "Horror", "Stephen King", 788, 1995, 1000)
            };
            Shop sh = new Shop(Properties.Resources.ShopName, "ТЦ\"Рассвет\"", books);
            //foreach(Book book in books)
            //{
            //    Console.WriteLine(book);
            //}
            #endregion
            #region BOOKSHOPCHICK2
            //Shop sh1 = new Shop("Читай-Город ", "Тц\"Рассвет\"", books);
            sh.GetShopName();
            sh.GetAllBooks(); Console.WriteLine();
            sh.AddABook(new Book("ОНА4", "America", "Horror", "Stephen King", 288, 1998, 1000));
            sh.GetAllBooks(); Console.WriteLine();
            sh.DeleteBookByName("ОНО");
            sh.GetAllBooks(); Console.WriteLine();
            sh.DeleteBookByIndex(1);
            sh.GetAllBooks(); Console.WriteLine();
            #endregion
            Command.HelpCommand();
            while (true)
            {
                Console.WriteLine("Введите команду: ");
                string command = Console.ReadLine();
                switch (command)
                {
                    case "help": Command.HelpCommand(); break;
                    case "addbook": sh.AddABook(Command.AddBookCommand()); break;
                    case "removebook": sh.DeleteBookByIndex(Command.RemoveBookCommand()); break;
                    case "removebookname": sh.DeleteBookByName(Command.RemoveBookCommandName()); break;
                    case "getallbook": Command.GetAllBookCommand(); sh.GetAllBooks(); break;
                    case "clear": Console.Clear(); break;
                    case "saveshop": Command.SaveShop(sh); break;
                    case "loadshop": break;
                    default: Console.WriteLine("Не удалось распознать команду. Наберите help для списка комманд! "); break;
                }
            }
        }
    }
    [Serializable]
    class Book : IEnumerable, IComparable, ISerializable
    {
        public string Name { get; set; }
        public string Publishing { get; set; }
        public string Genre { get; set; }
        public string Author { get; set; }
        public int NumberPages { get; set; }
        public int YearOfPublishing { get; set; }
        public int Price { get; set; }
        public Book(string name, string publishing, string genre, string author, int yearofpublishing, int nuberpages, int price)
        {
            Name = name;
            Publishing = publishing;
            Genre = genre;
            Author = author;
            YearOfPublishing = yearofpublishing;
            NumberPages = nuberpages;
            Price = price;
        }

        public override string ToString()
        {
            return Name + " " + Publishing + " " + Genre + " " + Author + " " + NumberPages.ToString() + " " + YearOfPublishing.ToString() + " " + Price.ToString();
        }
        public IEnumerator GetEnumerator()
        {
            return ((IEnumerable)Name).GetEnumerator();
        }
        public int CompareTo(object obj)
        {
            return Name.CompareTo((string)obj);
        }
        public int Compare(object obj, object obj2)
        {
            return ((Book)obj).Name.CompareTo((string)obj2);
        }

        private Book(SerializationInfo info, StreamingContext context)
        {
            Name = info.GetString("Название книги");
            Publishing = info.GetString("Издательство");
            Genre = info.GetString("Жанр");
            Author = info.GetString("Автор");
            YearOfPublishing = info.GetString("Год написания");
            NumberPages = info.GetString("Количество страниц");
            Price = info.GetString("Цена");
        }
        void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Имя магазина: ", Name);
            info.AddValue("Адресс магазина: ", Publishing);
            info.AddValue("Список книг магазина: ", Genre);
            info.AddValue("Список книг магазина: ", Author);
            info.AddValue("Список книг магазина: ", YearOfPublishing);
            info.AddValue("Список книг магазина: ", NumberPages);
            info.AddValue("Список книг магазина: ", Price);
        }

        [Serializable]
        class Shop : ISerializable
        {
            readonly List<Book> Books;
            string NameShop { get; set; }
            string Address { get; set; }
            public Shop()
            {

            }
            public Shop(string name, string address, List<Book> books)
            {
                this.NameShop = name;
                this.Address = address;
                this.Books = books;
            }
            public void GetAllBooks()
            {
                foreach (Book book in Books)
                {
                    Console.WriteLine(book);
                }
            }
            public void GetShopName()
            {
                Console.WriteLine("Добро Пожаловать в {0}", NameShop);
            }

            public void AddABook(Book book)
            {
                Books.Add(book);
            }
            public void DeleteBookByName(string name)
            {
                int index = -1;
                foreach (Book book in Books)
                {
                    if (book.CompareTo(name) == 0) index = Books.IndexOf(book);
                }
                if (index >= 0) Books.RemoveAt(index);
            }
            public void DeleteBookByIndex(int index)
            {
                Books.RemoveAt(index - 1);
            }

            private Shop(SerializationInfo info, StreamingContext context)
            {
                NameShop = info.GetString("Имя магазина");
                Address = info.GetString("Адресс магазина");
            }
            void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
            {
                info.AddValue("Имя магазина: ", NameShop);
                info.AddValue("Адресс магазина: ", Address);
                info.AddValue("Список книг магазина: ", Books);
            }
        }
        class Command
        {
            public static void HelpCommand()
            {
                Console.WriteLine("Используйте addbook для добавления книги, removebook для удаления книги,removebookname, getallbook для списка книг!");
            }
            public static Book AddBookCommand()
            {
                Book book;
                Console.Write("Введите имя книги: "); string name = Console.ReadLine();
                Console.Write("Введите издательство книги: "); string publishing = Console.ReadLine();
                Console.Write("Введите жанр книги: "); string genre = Console.ReadLine();
                Console.Write("Введите Автора книги: "); string author = Console.ReadLine();
                Console.Write("Введите количествостраниц книги: "); int numberpages = Int32.Parse(Console.ReadLine());
                Console.Write("Введите год публикации книги: "); int yearofpublish = Int32.Parse(Console.ReadLine());
                Console.Write("Введите цену книги: "); int price = Int32.Parse(Console.ReadLine());
                book = new Book(name, publishing, genre, author, numberpages, yearofpublish, price);
                return book;
            }
            public static int RemoveBookCommand()
            {
                Console.WriteLine("Укажите индекс удаляемой книги!");
                return Int32.Parse(Console.ReadLine());
            }
            public static string RemoveBookCommandName()
            {
                Console.WriteLine("Укажите имя удаляемой книги!");
                return Console.ReadLine();
            }
            public static void GetAllBookCommand()
            {
                Console.WriteLine("Список книг в магазине:");
            }
            public static void SaveShop(Shop shop)
            {
                using (FileStream fs = new FileStream("shop.xml", FileMode.OpenOrCreate))
                {
                    XmlSerializer xml = new XmlSerializer(typeof(Shop));
                    xml.Serialize(fs, shop);
                }
            }
            //public static void LoadShop(Shop shop)
            //{
            //    using ()
            //    {

            //    }
            //}
        }
    }
}

