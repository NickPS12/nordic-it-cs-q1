using System;
using System.Collections.Generic;
using System.Text;

namespace Lession_10_HM
{
    class Person
    {

        public string Name { get; set; }
        public int Age { get; set; }
        private int AgeIn4Years;
        public void SetBirthPlace()
        {
            AgeIn4Years = Age + 4;
        }
        public string Discription { get { return $"Name: {Name}, age in 4 years: {AgeIn4Years}"; } }

    }
}
