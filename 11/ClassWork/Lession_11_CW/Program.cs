using System;

namespace Lession_11_CW
{
	class Program
	{
		static void Main(string[] args)
		{
			Pet pet1 = new Pet();
			pet1.Name = "Sasha";
			pet1.Kind = PetKind.Cat;
			pet1.DateOfBirth = new DateTime(2017, 8, 13);
			//Console.WriteLine(pet1.Discription);
			//pet1.WriteDiscription(false);

			Pet pet2 = new Pet("Bobik", PetKind.Dog, new DateTime(2017, 8, 13));
			Console.WriteLine(pet2.ShortDiscription);
		}
	}

	enum PetKind
	{
		Dog,
		Cat,
		Mouse
	}
}
