using System;
using System.Collections.Generic;
using System.Text;

namespace Lession_13_CW
{
    class Plane : FlyingObject
    {
        public byte EnginesCount { get; private set; }

        public Plane(int maxHeight, byte enginesCount) : base(maxHeight)
        {
            EnginesCount = enginesCount;
        }

        public new void WriteAllProperties()
        {
            base.WriteAllProperties(); //базовый метод
            Console.WriteLine($"Engines Count: {EnginesCount}");
        }
    }
}
