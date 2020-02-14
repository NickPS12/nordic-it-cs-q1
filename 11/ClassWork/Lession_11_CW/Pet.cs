using System;
using System.Collections.Generic;
using System.Text;

namespace Lession_11_CW
{
	class Pet
	{
		public Pet() { }
		public Pet(string name, PetKind kind, DateTimeOffset dateOfBirth)
		{
			Name = name;
			Kind = kind;
			DateOfBirth = dateOfBirth;
		}

		public string Name;
		public PetKind Kind;

		//Спрашиваем дату рождения
		public DateTimeOffset DateOfBirth { get; set; }

		//полное описание
		public string Discription { get { return $"{Name} is a {Kind} and {GetAge()} years old. :3"; } }

		//короткое описание
		public string ShortDiscription	{ get {return $"\nИмя: {Name}" + $"\nВозраст: {GetAge()}"; } }

		public void WriteDiscription(bool isFullDiscription) //true - полное описание, false - короткое описание
		{
			Console.WriteLine(isFullDiscription ? Discription : ShortDiscription);
		}

		//Считаем возраст в годах
		public int GetAge()
		{
			DateTimeOffset nowDate = DateTime.Today;
			var period = nowDate - DateOfBirth;
			//365.242 - среднее число дней в году с учетом високосных
			return (int)(period.Days / 365.242);
		}
	}
}
