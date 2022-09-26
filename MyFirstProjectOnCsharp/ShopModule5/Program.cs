using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopModule5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shop store = new Shop("МармеладкиДжо "," Интузиастов 42в "," Кондитерский универсам "," 8(989)999-22-90 "," candy_store@mail.ru",45);
            Shop store2 = new Shop("МармеладкиБоба "," Непессимистов 50 "," Кондитерский универсам "," 8(928)199-99-22 "," bobs_candy_store@mail.ru",55);
            store.GetShopInfo();
            int newstoreroom = 31; store.Shoparea += newstoreroom;
            store.GetShopInfo();
            int storeroom = 22; store.Shoparea -= storeroom;
            store.GetShopInfo();
            Console.WriteLine(store == store2);
            Shop shop3 = new Shop("", "", "", "", "", 0);
            shop3.AddShop(shop3);
            shop3.GetShopInfo();
        }
    }
    class Shop
    {
        string _nameShop;
        string _addressShop;
        string _profShop;
        string _emailShop;
        string _phoneShop;
        int _shoparea;
        //GetSet Methods
        public string Name
        {
            get => _nameShop; set => _nameShop = value;
        }
        public string Address
        {
            get => _addressShop; set => _addressShop = value;
        }
        public string ProfShop
        {
            get => _profShop; set => _profShop = value;
        }
        public string PhoneNumb
        {
            get => _phoneShop; set => _phoneShop = value;
        }
        public string EmailShop
        {
            get => _emailShop; set => _emailShop = value;
        }
        public int Shoparea
        {
            get => _shoparea; set => _shoparea = value;
        }
        //Constructor
        public Shop(string name, string address, string profshop, string phoneshope, string email, int shoparea)
        {
            _nameShop = name;
            _addressShop = address;
            _profShop = profshop;
            _phoneShop = phoneshope;
            _emailShop = email;
            _shoparea = shoparea;
        }
        public static int operator +(Shop shoparea, int addshoparea)
        {
            shoparea._shoparea += addshoparea;
            return shoparea._shoparea;
        }
        public static bool operator ==(Shop shoparea, Shop othersharea)
        {
            return shoparea._shoparea == othersharea._shoparea;
        }
        public static bool operator !=(Shop shoparea, Shop othersharea)
        {
            return shoparea._shoparea != othersharea._shoparea;
        }
        public static bool operator <(Shop shoparea, Shop othersharea)
        {
            return shoparea._shoparea < othersharea._shoparea;
        }
        public static bool operator >(Shop shoparea, Shop othersharea)
        {
            return shoparea._shoparea > othersharea._shoparea;
        }
        public static int operator -(Shop shoparea, int reduceshoparea)
        {
            shoparea._shoparea -= reduceshoparea;
            return shoparea._shoparea;
        }
        public  Shop AddShop(Shop shop)
        {
            Console.Write("Введите название магазина:"); string shname = Console.ReadLine(); 
            Console.Write("Введите адресс магазина:"); string addres = Console.ReadLine(); 
            Console.Write("Введите профиль магазина:"); string profShop = Console.ReadLine(); 
            Console.Write("Введите номер телефона магазина:"); string phone = Console.ReadLine(); 
            Console.Write("Введите эл.почту магазина:"); string email = Console.ReadLine(); 
            Console.Write("Введите площадь магазина:"); int area = Int32.Parse(Console.ReadLine());
            return shop;
        }
        public override string ToString()
        {
            return " Магазин: " + Name + ";\n Адресс: " + Address + ";\n Профиль магазина: " + ProfShop + ";\n Номер телефона: " + PhoneNumb + ";\n Адресс эл.почты: " + EmailShop + ";\n Площадь: " + Shoparea.ToString()+" квадратных метров";
        }
        public void GetShopInfo()
        {
            Console.WriteLine(ToString());
        }
    }
}
