using System;
using System.Collections.Generic;
using System.Text;

namespace Lession_10_HM
{
    class Person
    {
        private int _ageIn4Years;

        private const int _ageNow = 4; //через какое количество лет требуется знать возраст человека
        public string Name { get; set; }
        public int Age { get; set; }
        public string Discription { get { return $"Name: {Name}, age in {_ageNow} years: {_ageIn4Years}"; } }
        public void AgeAdder()
        {
            _ageIn4Years = Age + _ageNow;
        }
    }
}
