using System;
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
        }
    }
}
