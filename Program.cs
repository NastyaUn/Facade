using System;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Если вас интересует посуда из глины, введите - pottery \nЕсли вас интересует посуда из керамики, введите - ceramic");
            string n = Console.ReadLine();
            if (n == "pottery")
            {
                Controller hcotn = new Controller(new Pottery());
                hcotn.Create();
            }
            if (n == "ceramic")
            {
                Controller hcotn = new Controller(new CeramicTableware());
                hcotn.Create();
            }
            if ((n != "pottery") && (n != "ceramic"))
            {
                Console.WriteLine("Для оформление заказа на создание набора посуды введите интересующий вас материал корректнее");
            }
        }
    }
}
