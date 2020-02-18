using System;
using System.Collections.Generic;
using System.Text;

namespace Lession_13_CW
{
    class Helicopter : FlyingObject
    {
        public byte BladesCount { get; private set; }

        public Helicopter(int maxHeight, byte bladesCount) : base(maxHeight)
        {
            BladesCount = bladesCount;
        }

        public new void WriteAllProperties()
        {
            base.WriteAllProperties(); //базовый метод
            Console.WriteLine($"Blades Count: {BladesCount}");
        }
    }
}
