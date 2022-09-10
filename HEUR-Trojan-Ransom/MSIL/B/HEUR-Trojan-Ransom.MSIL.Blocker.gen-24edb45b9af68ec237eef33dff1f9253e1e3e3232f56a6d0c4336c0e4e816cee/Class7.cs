using System;

internal static class Class7
{
	public static void smethod_0(int int_0, string string_0)
	{
		_ = Console.CursorLeft;
		int num = 0;
		int num5 = default(int);
		int num4 = default(int);
		string[] array = default(string[]);
		int num2 = default(int);
		int num3 = default(int);
		bool flag = default(bool);
		while (true)
		{
			switch (num)
			{
			case 10:
				Console.Write(new string(' ', int_0));
				goto case 9;
			case 9:
				num5++;
				goto case 8;
			case 8:
				if (num5 < num4)
				{
					if (num5 == num4 - 1)
					{
						Console.Write("{0} ", array[num2].Substring(num3 * num5));
						num = 9;
					}
					else
					{
						Console.Write(array[num2].Substring(num3 * num5, num3));
						num = 10;
					}
					break;
				}
				goto default;
			default:
				if (Console.CursorLeft == 0)
				{
					Console.Write(new string(' ', int_0));
				}
				num2++;
				goto case 2;
			case 2:
				if (num2 < array.Length)
				{
					flag = false;
					num = 3;
					break;
				}
				return;
			case 7:
				num5 = 0;
				num = 8;
				break;
			case 6:
				num4 = array[num2].Length / num3 + 1;
				num = 7;
				break;
			case 5:
				flag = true;
				goto IL_00bb;
			case 4:
				Console.Write(new string(' ', int_0));
				num = 5;
				break;
			case 3:
				if (Console.CursorLeft + array[num2].Length > Console.BufferWidth - 1)
				{
					Console.WriteLine();
					num = 4;
					break;
				}
				goto IL_00bb;
			case 1:
				num2 = 0;
				num = 2;
				break;
			case 0:
				{
					if (Console.BufferWidth > int_0)
					{
						array = string_0.Split(new char[1] { ' ' });
						num = 1;
						break;
					}
					throw new ArgumentException("Console buffer width is less than or equal to the indent parameter value, so there is no place to write the text.");
				}
				IL_00bb:
				if (flag)
				{
					if (array[num2].Length > Console.BufferWidth - int_0)
					{
						num3 = Console.BufferWidth - int_0;
						num = 6;
					}
					else
					{
						Console.Write("{0} ", array[num2]);
						num = 11;
					}
					break;
				}
				Console.Write("{0} ", array[num2]);
				goto default;
			}
		}
	}

	public static void smethod_1(int int_0, string string_0)
	{
		smethod_0(int_0, string_0);
		Console.WriteLine();
	}
}
