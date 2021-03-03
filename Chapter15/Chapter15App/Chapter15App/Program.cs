using System;
using System.Collections.Generic;
using System.Linq;
namespace Chapter15App
{
    class Profile {
        public string name;
        public int height;
    }
    class Product
    {
        public string name;
        public string work;
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 9, 2, 6, 4, 5, 3, 7, 8, 1, 10 };
            /*           일반적인 방식
             *           List<int> result = new List<int>();
                       foreach(var item in numbers)
                       {
                           if (item % 2 == 0)
                           {
                               result.Add(item);
                           }
                       }

                       foreach(var item in result)
                       {
                           Console.WriteLine($"짝수 : {item}");
                       }*/

            var result = from item in numbers
                         where item % 2 == 0
                         orderby item
                         select item; 

            foreach (var item in result)
            {
                Console.WriteLine($"짝수 : {item}");
            }

            List<Profile> profiles = new List<Profile>();
            profiles.Add(new Profile() { name = "정우성", height = 186 });
            profiles.Add(new Profile() { name = "김태희", height = 164 });
            profiles.Add(new Profile() { name = "고현정", height = 168 });
            profiles.Add(new Profile() { name = "이문세", height = 180 });
            profiles.Add(new Profile() { name = "하동훈", height = 171 });
            List<Product> products = new List<Product>();
            products.Add(new Product() { name = "정우성", work = "비트" });
            products.Add(new Product() { name = "김태희", work = "아이리스" });
            products.Add(new Product() { name = "고현정", work = "모래시계" });
            products.Add(new Product() { name = "이문세", work = "솔로예찬" });

            var resProfiles = from item in profiles
                              where item.height < 175
                              orderby item.height descending // ascending 
                              select new { name = item.name, 
                                           height = item.height, 
                                           inchHeight = item.height * 0.393 };

            foreach (var item in resProfiles)
            {
                Console.WriteLine($"{item.name}, {item.height}cm, {item.inchHeight}inch");
            }

            // group by 
            var resProfiles3 = from item in profiles
                               orderby item.height
                               group item by item.height < 175 into g 
                               select new
                               {
                                   GroupKey = g.Key,
                                   Items = g
                               };
            foreach (var group in resProfiles3) 
            {
                Console.WriteLine($"175cm 미만 그룹 : {group.GroupKey}");
                foreach(var item in group.Items)
                {
                    Console.WriteLine($"{item.name}, {item.height}");
                }
            }

            // inner join 
            var joinProfiles = from p in profiles
                               join d in products
                               on p.name equals d.name
                               select new
                               {
                                   name = p.name,
                                   work = d.work,
                                   inchHeight = p.height * 0.393
                               };
            Console.WriteLine("내부 조인 결과");
            foreach(var item in joinProfiles)
            {
                Console.WriteLine($"이름 : {item.name}, 작품 : {item.work}, 키 : {item.inchHeight}inch");

            }

        }
    }
}