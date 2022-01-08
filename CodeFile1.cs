using System;
namespace Facade
{
    public abstract class Cups
    {
        public abstract void CreateTeaCup();
        public abstract void CreateCoffeeCup();
    }
    public class ClayCup : Cups
    {
        public ClayCup()
        {
            Console.WriteLine("Чашка из глины");
        }
        public override void CreateTeaCup()
        {
            Console.WriteLine("Глиняная чашка для чая");
        }
        public override void CreateCoffeeCup()
        {
            Console.WriteLine("Глиняная кофейная чашка");
        }
    }
    public class CeramicCups : Cups
    {
        public CeramicCups()
        {
            Console.WriteLine("Керамическая чашка");
        }
        public override void CreateTeaCup()
        {
            Console.WriteLine("Чайная керамиечкая чашка");
        }
        public override void CreateCoffeeCup()
        {
            Console.WriteLine("Кофейная керамическая чашка");
        }
    }
    public abstract class Plates
    {
        public abstract void CreateDinnerPlate();// Столовая тарелка
        public abstract void CreateDessertPlate();//Десертная тарелка
    }
    public class ClayPlate : Plates
    {
        public ClayPlate()
        {
            Console.WriteLine("Глиняная тарелка");
        }
        public override void CreateDinnerPlate()
        {
            Console.WriteLine("Столовая глиняная тарелка");
        }
        public override void CreateDessertPlate()
        {
            Console.WriteLine("Десертная глиняная тарелка");
        }
    }
    public class CeramicPlate : Plates
    {
        public CeramicPlate()
        {
            Console.WriteLine("Керамическая тарелка");
        }
        public override void CreateDinnerPlate()
        {
            Console.WriteLine("Столовая керамическая тарелка");
        }
        public override void CreateDessertPlate()
        {
            Console.WriteLine("Десертная керамическая тарелка");
        }
    }

    public abstract class Dinnerware
    {
        public abstract Cups CreateCups();
        public abstract Plates CreatePlates();
    }
    public class Pottery : Dinnerware //глиняная посуда
    {
        public Pottery()
        {
            Console.WriteLine("Создаём из глины");
        }
        public override Cups CreateCups()
        {
            return new ClayCup();
        }
        public override Plates CreatePlates()
        {
            return new ClayPlate();
        }
    }
    public class CeramicTableware : Dinnerware//керамическая посуда
    {
        public CeramicTableware()
        {
            Console.WriteLine("Создаём из керамики");
        }
        public override Cups CreateCups()
        {
            return new CeramicCups();
        }
        public override Plates CreatePlates()
        {
            return new CeramicPlate();
        }
    }
}