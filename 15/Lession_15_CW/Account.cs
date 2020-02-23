using System;
using System.Collections.Generic;
using System.Text;

namespace Lession_15_CW
{
	class Account<T>
	{
		public T Id { get; }

		public string Name { get; }

		public Account(T id, string name)
		{
			Id = id;
			Name = name;
		}

		public void WriteProperties()
		{
			Console.WriteLine($"ID \t= {Id}\nИмя \t= {Name}\n");
		}
	}
}
