using System;

namespace BBSC_TIANHUI_Homework_DAY_1;

internal class Day_1
{
	private static void Main(string[] args)
	{
	}

	private static void typedemo()
	{
		if (int.TryParse("wr2342", out var _))
		{
			Console.WriteLine("true");
		}
		else
		{
			Console.WriteLine("false");
		}
		int value = int.Parse("2145");
		Console.WriteLine(value);
		Console.WriteLine(typeof(char));
		Console.WriteLine(4);
		Console.WriteLine(255);
		Console.WriteLine(0);
		Console.WriteLine(int.MaxValue);
		Console.WriteLine(int.MinValue);
		Console.WriteLine(32767);
		Console.WriteLine(-32768);
		Console.WriteLine(long.MaxValue);
		Console.WriteLine(long.MinValue);
		Console.WriteLine(float.MaxValue);
		Console.WriteLine(float.MinValue);
		Console.WriteLine(double.MaxValue);
		Console.WriteLine(double.MinValue);
	}

	private static void Weekshow()
	{
		for (int i = 0; i < int.MaxValue; i++)
		{
			switch (Console.ReadLine())
			{
			case "1":
				Console.WriteLine("星期一");
				break;
			case "2":
				Console.WriteLine("星期二");
				break;
			case "3":
				Console.WriteLine("星期三");
				break;
			case "4":
				Console.WriteLine("星期四");
				break;
			case "5":
				Console.WriteLine("星期五");
				break;
			case "6":
				Console.WriteLine("星期六");
				break;
			case "7":
				Console.WriteLine("星期天");
				break;
			default:
				Console.WriteLine("非正确数字");
				break;
			case "exit":
				return;
			}
		}
	}

	private static void SquareFunctionDemo()
	{
		double num = double.Parse(Console.ReadLine());
		double value = num * num;
		Console.WriteLine(value);
	}

	private static void NumDemo()
	{
		for (int i = 2; i < 542; i++)
		{
			int j;
			for (j = 2; j <= i / 2 && i % j != 0; j++)
			{
			}
			if (j > i / 2)
			{
				Console.WriteLine("质数: " + i);
			}
		}
	}

	private static void CharCalcDemo()
	{
		Console.WriteLine("请输入一段内容：");
		string text = Console.ReadLine();
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		for (int i = 0; i < text.Length; i++)
		{
			if (char.IsLetter(text, i))
			{
				num2++;
			}
			else if (char.IsNumber(text, i))
			{
				num++;
			}
			else if (char.IsPunctuation(text, i))
			{
				num3++;
			}
		}
		Console.Write("字符个数为：");
		Console.WriteLine(num2);
		Console.Write("数字个数为：");
		Console.WriteLine(num);
		Console.Write("标点个数为：");
		Console.WriteLine(num3);
	}

	private static void CalcExcelColumn(int colnum)
	{
		for (int i = 1; i <= colnum; i++)
		{
			if ((double)colnum <= Math.Pow(26.0, i))
			{
				int num = 64 + colnum;
				char value = (char)num;
				Console.WriteLine(value);
				CalcExcelColumn(colnum - (int)Math.Pow(26.0, i));
			}
		}
	}

	private static void QueeyASCII()
	{
		for (int i = 0; i < 256; i++)
		{
			char value = (char)i;
			Console.Write(value);
			Console.Write(" ");
		}
		Console.WriteLine("请输入要查询的键盘字符：");
		char c = char.Parse(Console.ReadLine());
		for (int i = 0; i < 256; i++)
		{
			if (c == (ushort)i)
			{
				Console.Write("你输入字符相应的ASSII码为：");
				Console.WriteLine(i);
			}
		}
	}

	private static void timeset()
	{
		Console.WriteLine("现在的时间是{0}-{1}-{2}", DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
		Console.WriteLine("现在的时间是{0}/{1}/{2}", DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
	}
}
