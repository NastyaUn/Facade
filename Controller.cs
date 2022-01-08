using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
	public class Controller
	{
		Dinnerware Dn; // фабрика, отвечающая за создание посуды. 
		// Конструктор
		public Controller(Dinnerware dn)
		{
			this.Dn = dn;
		}
		// "Создание"
		public void Create()
		{
			Console.WriteLine("Набор из скольки человек вас интересует");
			string n =Console.ReadLine();
			int nn = Convert.ToInt32(n);
			while (nn>0)
			{
				Dn.CreateCups();
				Dn.CreatePlates();
				nn--;
			}
		}
	}
}
