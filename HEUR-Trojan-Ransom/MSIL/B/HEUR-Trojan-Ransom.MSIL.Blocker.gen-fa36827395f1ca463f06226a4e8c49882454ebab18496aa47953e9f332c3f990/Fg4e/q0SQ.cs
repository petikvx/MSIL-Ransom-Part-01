using System;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Fg4e;

[StandardModule]
internal sealed class q0SQ
{
	public static bool w7ME(string Lp5y)
	{
		Console.WriteLine(Lp5y);
		if (Lp5y.Length == 13)
		{
			if ((Operators.CompareString(Conversions.ToString(Lp5y[0]), "9", false) != 0) | (Operators.CompareString(Conversions.ToString(Lp5y[1]), "7", false) != 0) | (Operators.CompareString(Conversions.ToString(Lp5y[2]), "9", false) != 0 && Operators.CompareString(Conversions.ToString(Lp5y[2]), "8", false) != 0))
			{
				return false;
			}
			int num = 0;
			int num2 = 1;
			int num3 = 0;
			checked
			{
				do
				{
					num += num2 * (Strings.Asc(Lp5y[num3]) - 48);
					num2 = ((num2 == 3) ? 1 : 3);
					num3++;
				}
				while (num3 <= 11);
				num = unchecked(num % 10);
				num = 10 - num;
			}
			if (num == checked(Strings.Asc(Lp5y[12]) - 48) || num == 10)
			{
				return true;
			}
			return false;
		}
		Lp5y = Strings.StrReverse(Lp5y);
		int num4 = 0;
		int num5 = 2;
		checked
		{
			do
			{
				num4 += num5 * (Strings.Asc(Lp5y[num5 - 1]) - 48);
				num5++;
			}
			while (num5 <= 10);
			num4 = unchecked(num4 % 11);
			if ((Operators.CompareString(Conversions.ToString(Lp5y[0]), "X", false) == 0) | (Operators.CompareString(Conversions.ToString(Lp5y[0]), "x", false) == 0))
			{
				num4 += 10;
			}
			else
			{
				if (Strings.Asc(Lp5y[0]) - 48 >= 10)
				{
					return true;
				}
				num4 += Strings.Asc(Lp5y[0]) - 48;
			}
		}
		if (num4 == 11 || num4 == 0)
		{
			return true;
		}
		return false;
	}
}
