using System;
using System.Collections.Generic;
using System.Text;

namespace Lession_13_CW
{
    class FlyingObject
    {
        public readonly int MaxHeight; //{ get; private set; }

        public int CurrentHeight { get; private set; }

        public FlyingObject(int maxHeight)
        {
            MaxHeight = maxHeight;
            //CurrentHeight = 0;
        }

        //Логика взлета
        public void TakeUpper(int delta)
        {
            if (delta <= 0)
            {
                throw new ArgumentOutOfRangeException ("Значение должно быть положительным");
            }
            else if (CurrentHeight + delta > MaxHeight)
            {
                CurrentHeight = MaxHeight;
            }
            else
            {
                CurrentHeight = CurrentHeight + delta;
            }
        }

        //Логика снижения
        public void TakeLower(int delta)
        {
            if (delta <= 0)
            {
                throw new ArgumentOutOfRangeException("Значение должно быть положительным");
            }
            else if (CurrentHeight - delta > 0)
            {
                CurrentHeight = delta;
            }
            else if (CurrentHeight - delta == 0)
            {
                CurrentHeight = 0;
            }
            else if (CurrentHeight < 0)
            {
                throw new InvalidOperationException("Crash!");
            }
        }

        public virtual void WriteAllProperties()
        {
            Console.WriteLine(  $"\nObject: {GetType().Name}" +
                                $"\nCurrent hight: {CurrentHeight}" +
                                $"\nMaxHight: {MaxHeight}");
        }
    }
}
