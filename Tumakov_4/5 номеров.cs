using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tumakov_4
{
    internal class Exercises_4
    {
        enum Cards
        {
            Шестерка = 6,
            Семерка,
            Восьмерка,
            Девятка,
            Десятка,
            Валет,
            Дама,
            Король,
            Туз
        }

        enum DaysOfWeek
        {
            Понедельник = 1,
            Вторник,
            Среда,
            Четверг, 
            Пятница,
            Суббота,
            Воскресенье
        }
        static void Main(string[] args)
        {

            Console.WriteLine("Задание 2. Определить достоинство карты.\n");

            try
            {
                Console.WriteLine("Введите номер игральной карты.");
                byte cardNumber = byte.Parse(Console.ReadLine());


                if (cardNumber < 6 || cardNumber > 14)
                {
                    Console.WriteLine("Вы ввели несуществующий номер карты!");
                }
                else
                {
                    Console.WriteLine((Cards)cardNumber);
                }

            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.ReadKey();
                Console.Clear();

            }


            Console.WriteLine("Задание 3. Напитки и люди.\n");

            Console.WriteLine("Кто вы? Назовите себя.");
            string person = Console.ReadLine();
            switch (person.ToLower())
            {
                case "jabroni":
                    Console.WriteLine("Patron Tequila");
                    break;
                case "school counselor":
                    Console.WriteLine("Anything with Alcohol");
                    break;
                case "programmer":
                    Console.WriteLine("Hipster Craft Beer");
                    break;
                case "bike gang member":
                    Console.WriteLine("Moonshine");
                    break;
                case "politician":
                    Console.WriteLine("Your tax dollars");
                    break;
                case "rapper":
                    Console.WriteLine("Cristal");
                    break;
                default:
                    Console.WriteLine("Glass of Beer just for you");
                    break;
            }
            Console.ReadKey();
            Console.Clear();


            Console.WriteLine("Задание 4. Дни недели.\n");

            Console.WriteLine("Введите номер дня недели.");
            int numbOfDay = int.Parse(Console.ReadLine());
             if (numbOfDay < 1 || numbOfDay > 7)
             {
                Console.WriteLine("Вы не в Нарнии, у нас 7 дней недели.");
             }
             else
             {
                Console.WriteLine($"Данный номер соответсвует дню недели: {(DaysOfWeek)numbOfDay}");
             }
            Console.ReadKey();
            Console.Clear();


            Console.WriteLine("Задача 5. Куклы в сумке.\n");

            string[] dolls = { "Barbie Doll", "Ken", "Hello Kitty", "Sandra", "MonstrHye", "Hello Kitty", "Babybon", "Molly", "Dora", "Barbie Doll" };
            int bag = 0;
            foreach (string dollsCount in dolls) 
            {
                
                if (dollsCount == "Barbie Doll" || dollsCount == "Hello Kitty")
                {
                    bag++;
                }
                
            }
            Console.WriteLine("В сумке " + bag + " куклы." );
        }
    }
}
