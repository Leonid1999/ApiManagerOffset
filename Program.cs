using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiManeger
{
    class Program
    {
        static void Main(string[] args)
        {
            using (DataContext db = new DataContext())
            {

                // добавляем их в бд
                TypeMessege user1 = new TypeMessege { Id = 1, Name = "Tom", Type = "SMS" };
                TypeMessege user2 = new TypeMessege { Id = 2, Name = "Mark", Type = "MMS" };
                TypeMessege user3 = new TypeMessege { Id = 3, Name = "Lucy", Type = "Voice Messege" };
                db.TypeMessege.Add(user1);
                db.TypeMessege.Add(user2);
                db.TypeMessege.Add(user3);
                db.SaveChanges();
                Console.WriteLine("Объекты успешно сохранены");

                // получаем объекты из бд и выводим на консоль
                var messeges = db.TypeMessege;
                Console.WriteLine("Список объектов:");
                foreach (TypeMessege u in messeges)
                {
                    Console.WriteLine("{0}.{1} - {2}", u.Id, u.Name, u.Type);
                }
                Console.WriteLine("Count():");
                int number1 = db.TypeMessege.Count();
                // найдем кол-во моделей, которые в названии содержат Samsung
                int number2 = db.TypeMessege.Count(p => p.Type.Contains("SMS"));
                Console.Write("Всего обьектов: ");
                Console.WriteLine(number1);
                Console.Write("Колечество обьектов с полем SMS: ");
                Console.WriteLine(number2);
                Console.WriteLine("Union():");
                var mess = db.TypeMessege.Where(p => p.Type.Contains("SMS"))
       .Union(db.TypeMessege.Where(p => p.Name.Contains("Mark")));
                foreach (var item in mess)
                {
                    Console.WriteLine(item.Id+". "+item.Name+"-"+item.Type);
                   
                }

                Console.Read();
            }
        }
    }
}