using System;
using System.Collections.Generic;
using System.Text;

namespace Lession_15_CW
{
	class Calculator
	{
		public static T Sum <T> (T a, T b)
		{
			return (T)((dynamic)a) + (dynamic)b;
		}

		public static T Multiply<T>(T a, T b)
		{
			return (T)((dynamic)a) * (dynamic)b;
		}

		public static T Substract<T>(T a, T b)
		{
			return (T)((dynamic)a) - (dynamic)b;
		}

		public static T Divide<T>(T a, T b)
		{
			return (T)((dynamic)a) / (dynamic)b;
		}
	}
}
