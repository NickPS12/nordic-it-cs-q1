using System;
using System.Collections.Generic;
using System.Text;

namespace Lession_8_HM
{
    public class Person
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public int AgePlusFour
        {
            get { return Age + 4; }
        }

        public string STR
        {
            get { return $"Имя: {Name}. Этому человеку, через четыре года, исполниться: {AgePlusFour}."; }
        }
    }
}
