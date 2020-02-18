using System;

namespace Lession_13_CW
{
    class Program
    {
        static void Main(string[] args)
        {
            Plane plane = new Plane(100, 4);
            plane.TakeUpper(120);
            plane.TakeLower(100);
            plane.WriteAllProperties();

            Helicopter helicopter = new Helicopter(80, 3);
            helicopter.TakeUpper(120);
            helicopter.TakeLower(60);
            helicopter.WriteAllProperties();
        }
    }
}
