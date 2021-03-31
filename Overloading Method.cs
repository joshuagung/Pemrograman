using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanOverloadingMethod
{
    public class Numbers
    {
		public int FindMinimum(int number1, int number2)
		{
			int min=0;
			if( number1 < number2)
            {
				min = number1;
            }
            else
            {
				min = number2;
            }
			return min;
		}

		public int FindMinimum(int number1, int number2, float number3)
		{
			int min = number1;
			if( number2 < min)
            {
				min = number2;
            }
			if (number3 < min)
			{
				min = (int)number3;
			}
			return min;
		}

		public int FindMaximum(int number1, int number2)
		{
			int max = 0;
			if (number1 > number2)
			{
				max = number1;
			}
			else
			{
				max = number2;
			}
			return max;
		}

		public int FindMaximum(int number1, int number2, float number3)
		{
			int max = number1;
			if (number2 > max)
			{
				max = number2;
			}
			if (number3 > max)
			{
				max = (int)number3;
			}
			return max;
		}

		static void Main(string[] args)
        {
            Numbers number = new Numbers();

            Console.WriteLine("Minimum #1: {0}", number.FindMinimum(3,1));
            Console.WriteLine("Minimum #2: {0}", number.FindMinimum(3,2,4));
            Console.WriteLine();
            Console.WriteLine("Maximum #1: {0}", number.FindMaximum(3,1));
            Console.WriteLine("Maximum #2: {0}", number.FindMaximum(3,2,4));

        }
	}
}

