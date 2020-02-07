using System;
using System.Linq;

namespace Lession_10_CW
{

	class Program
	{
		static void Main(string[] args)
		{
			Pet pet1 = new Pet();
			pet1.Age = 5;
			pet1.Name = "Bobby";
			pet1.Sex = 'M';
			pet1.Kind = PetKind.Dog;
			pet1.SetBirthPlace("Moscow");

			Console.WriteLine(pet1.Discription);

			Pet pet2 = new Pet();
			pet2.Age = 8;
			pet2.Name = "Mashka";
			pet2.Sex = 'f';
			pet2.Kind = PetKind.Cat;
			pet2.SetBirthPlace("Saratov");

			Console.WriteLine(pet2.Discription);

			Console.ReadKey();
		}
	}
	enum PetKind
	{
		Dog,
		Cat,
		Mouse
	}
	enum AnimalSex
	{
		M,
		F
	}
	class Pet
	{
		private string _birthPlace;
		public string Name;
		public PetKind Kind;
		private char _sex;
		public int Age { get; set; }
		public char Sex
		{	
			get { return _sex; } 
			set 
			{
				if (value == 'f' || value == 'F' || value == 'm' || value == 'M') 
				{ 
					_sex = char.ToUpper(value); 
				} 
				else 
				{
					throw new Exception("Так не бывает...");
				}
			}
		}
		public void SetBirthPlace (string _BirthPlaceAdd)
		{
			_birthPlace = _BirthPlaceAdd;
		}
		
		public string Discription { get { return $"{Name} is a {Kind} ({Sex}) of {Age} years old, was born in {_birthPlace}. :3"; } }
	}
}