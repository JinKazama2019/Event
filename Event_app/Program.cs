using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_app
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.GoToSleep += Person_GoToSleep;// создание обработчика событий
            person.TakeTime(DateTime.Parse("27.12.2018 21:13:01"));
            person.TakeTime(DateTime.Parse("27.12.2018 4:13:01"));
        }

        // обработчик событий
        private static void Person_GoToSleep()
        {
            Console.WriteLine("The man go to sleep");
            Console.ReadLine();
        }
    }
}
