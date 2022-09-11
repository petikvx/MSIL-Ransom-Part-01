using System;
using System.Runtime.CompilerServices;

namespace PreEmptive.Analytics.Common;

public class ExtendedKey
{
	private const long long_0 = 999999999999999999L;

	private const long long_1 = -999999999999999999L;

	private string string_0;

	[CompilerGenerated]
	private string string_1;

	[CompilerGenerated]
	private bool bool_0;

	public string Key
	{
		get
		{
			if (1 == 0)
			{
			}
			int num = 8425;
			int num2 = num;
			num = 8425;
			switch (num2 == num)
			{
			default:
				if (0 == 0)
				{
				}
				return string_0;
			}
		}
		private set
		{
			int num = 23138;
			int num2 = num;
			num = 23138;
			switch (num2 == num)
			{
			}
			if (1 == 0)
			{
			}
			if (0 == 0)
			{
			}
			string_0 = ((value.Length > 2000) ? value.Substring(0, 2000) : value);
		}
	}

	public string Value
	{
		[CompilerGenerated]
		get
		{
			if (1 == 0)
			{
			}
			int num = 21695;
			int num2 = num;
			num = 21695;
			switch (num2 == num)
			{
			default:
				if (0 == 0)
				{
				}
				return string_1;
			}
		}
		[CompilerGenerated]
		private set
		{
			int num = -17032;
			int num2 = num;
			num = -17032;
			switch (num2 == num)
			{
			}
			if (0 == 0)
			{
			}
			if (1 == 0)
			{
			}
			string_1 = value;
		}
	}

	public bool IsNumeric
	{
		[CompilerGenerated]
		get
		{
			int num = -32372;
			int num2 = num;
			num = -32372;
			switch (num2 == num)
			{
			default:
				if (1 == 0)
				{
				}
				if (0 == 0)
				{
				}
				return bool_0;
			}
		}
		[CompilerGenerated]
		private set
		{
			int num = 2845;
			int num2 = num;
			num = 2845;
			switch (num2 == num)
			{
			}
			if (1 == 0)
			{
			}
			if (0 == 0)
			{
			}
			bool_0 = value;
		}
	}

	public ExtendedKey(string string_2, string value)
	{
		Key = string_2;
		Value = ((value.Length > 4000) ? value.Substring(0, 4000) : value);
		IsNumeric = false;
	}

	public ExtendedKey(string string_2, int value)
	{
		Key = string_2;
		Value = value.ToString();
		IsNumeric = true;
	}

	public ExtendedKey(string string_2, long value)
	{
		Key = string_2;
		if (value > 999999999999999999L)
		{
			Value = 999999999999999999L.ToString();
		}
		else if (value < -999999999999999999L)
		{
			Value = (-999999999999999999L).ToString();
		}
		else
		{
			Value = value.ToString();
		}
		IsNumeric = true;
	}

	public ExtendedKey(string string_2, float value)
	{
		Key = string_2;
		Value = method_0(value);
		IsNumeric = true;
	}

	public ExtendedKey(string string_2, double value)
	{
		Key = string_2;
		Value = method_1(value);
		IsNumeric = true;
	}

	public ExtendedKey(string string_2, decimal value)
	{
		Key = string_2;
		Value = method_2(value);
		IsNumeric = true;
	}

	private string method_0(float float_0)
	{
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				if (float_0 > 1E+18f)
				{
					num = 1;
					num2 = num;
					break;
				}
				if (1 == 0)
				{
				}
				num = 0;
				num2 = num;
				break;
			case 0:
			{
				num = 13581;
				int num3 = num;
				num = 13581;
				switch (num3 == num)
				{
				case false:
				case true:
					break;
				default:
					if (0 == 0)
					{
					}
					if (float_0 < -1E+18f)
					{
						num = 2;
						num2 = num;
						goto end_IL_009d;
					}
					return method_2((decimal)float_0);
				}
				goto default;
			}
			case 1:
				return 999999999999999999L.ToString();
			case 2:
				{
					return (-999999999999999999L).ToString();
				}
				end_IL_009d:
				break;
			}
		}
	}

	private string method_1(double double_0)
	{
		int num = 3;
		int num2 = num;
		while (true)
		{
			if (true)
			{
			}
			switch (num2)
			{
			case 0:
			{
				num = -31201;
				int num3 = num;
				num = -31201;
				switch (num3 == num)
				{
				default:
					if (0 == 0)
					{
					}
					if (double_0 < -1E+18)
					{
						num = 2;
						num2 = num;
						goto end_IL_0015;
					}
					return method_2((decimal)double_0);
				case false:
				case true:
					break;
				}
				goto default;
			}
			default:
				if (double_0 > 1E+18)
				{
					num = 1;
					num2 = num;
				}
				else
				{
					num = 0;
					num2 = num;
				}
				break;
			case 1:
				return 999999999999999999L.ToString();
			case 2:
				{
					return (-999999999999999999L).ToString();
				}
				end_IL_0015:
				break;
			}
		}
	}

	private string method_2(decimal decimal_0)
	{
		int num = 19;
		switch (0)
		{
		default:
		{
			int num2 = 10;
			int num3 = num2;
			string text = default(string);
			while (true)
			{
				string text2;
				switch (num3)
				{
				default:
					if (decimal_0 > new decimal(999999999999999999L))
					{
						num2 = -8025;
						int num4 = num2;
						num2 = -8025;
						switch (num4 == num2)
						{
						default:
							if (0 == 0)
							{
							}
							num2 = 5;
							num3 = num2;
							goto end_IL_01cf;
						case false:
						case true:
							break;
						}
						goto case 2;
					}
					num2 = 1;
					num3 = num2;
					break;
				case 2:
					num2 = 4;
					num3 = num2;
					break;
				case 9:
					num2 = 3;
					num3 = num2;
					break;
				case 6:
					if (text.Contains("늜"))
					{
						num2 = 9;
						num3 = num2;
						break;
					}
					goto case 7;
				case 4:
					text2 = text.Substring(0, Math.Min(19, text.Length));
					goto IL_0113;
				case 3:
					if (!(decimal_0 < 0m))
					{
						num2 = 2;
						num3 = num2;
					}
					else
					{
						num2 = 0;
						num3 = num2;
					}
					break;
				case 1:
					if (1 == 0)
					{
					}
					if (decimal_0 < new decimal(-999999999999999999L))
					{
						num2 = 8;
						num3 = num2;
					}
					else
					{
						text = Math.Round(decimal_0, 5).ToString();
						num2 = 6;
						num3 = num2;
					}
					break;
				case 0:
					text2 = text.Substring(0, Math.Min(20, text.Length));
					goto IL_0113;
				case 5:
					return 999999999999999999L.ToString();
				case 7:
					return text;
				case 8:
					{
						return (-999999999999999999L).ToString();
					}
					IL_0113:
					text = text2;
					num2 = 7;
					num3 = num2;
					break;
					end_IL_01cf:
					break;
				}
			}
		}
		}
	}
}
