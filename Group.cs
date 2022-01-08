using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
	public class Group
	{
		// Коллекция объектов
		ArrayList Dishes = new ArrayList();

		// Метод, реализующий добавление посуды в группу
		public void Add(object dishes)
		{
			Dishes.Add(dishes);
		}
		// Поставить новую посуду
		public void Attack()
		{
			// подсчет количества посуды 
			int countPottery = 0;
			int countCeramicTableware = 0;
			foreach (object obj in Dishes)
			{
				if (obj is Pottery) countPottery++;
				else if (obj is CeramicTableware) countCeramicTableware++;
			}
			Console.WriteLine(countPottery);
			Console.WriteLine(countCeramicTableware);
			// глиняной посуды больше
			if (countPottery > countCeramicTableware)
			{
				// ставим на стелаж глиняную посуду
				foreach (object obj in Dishes)
				{
					if (obj is Cups)
					{
						(obj as Cups).CreateCoffeeCup();
						(obj as Cups).CreateTeaCup();
					}
					if (obj is Plates)
					{
						(obj as Plates).CreateDessertPlate();
						(obj as Plates).CreateDinnerPlate();
					}
				}
			}
			// керамической посуды больше
			if (countPottery < countCeramicTableware)
			{
				// ставим на стелаж керамическую посуду посуду
				foreach (object obj in Dishes)
				{
					if (obj is Cups)
					{
						(obj as Cups).CreateCoffeeCup();
						(obj as Cups).CreateTeaCup();
					}
					if (obj is Plates)
					{
						(obj as Plates).CreateDessertPlate();
						(obj as Plates).CreateDinnerPlate();
					}
				}
			}
		}
	}
}
