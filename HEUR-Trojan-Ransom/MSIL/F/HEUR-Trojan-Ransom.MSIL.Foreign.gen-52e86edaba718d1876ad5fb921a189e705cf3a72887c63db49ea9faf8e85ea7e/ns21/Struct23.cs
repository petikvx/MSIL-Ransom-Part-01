using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using MySql.Data.MySqlClient;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace ns21;

internal struct Struct23
{
	private readonly string string_0;

	[CompilerGenerated]
	private readonly int int_0;

	[CompilerGenerated]
	private readonly int int_1;

	[CompilerGenerated]
	private readonly int int_2;

	[CompilerGenerated]
	private bool bool_0;

	[NonSerialized]
	internal static GetString getString_0;

	public int Major
	{
		[CompilerGenerated]
		get
		{
			return int_0;
		}
	}

	public int Minor
	{
		[CompilerGenerated]
		get
		{
			return int_1;
		}
	}

	public int Build
	{
		[CompilerGenerated]
		get
		{
			return int_2;
		}
	}

	public bool IsEnterprise
	{
		[CompilerGenerated]
		get
		{
			return bool_0;
		}
		[CompilerGenerated]
		private set
		{
			bool_0 = value;
		}
	}

	public Struct23(string string_1, int int_3, int int_4, int int_5)
	{
		int_0 = int_3;
		int_1 = int_4;
		int_2 = int_5;
		string_0 = string_1;
		IsEnterprise = string_1.ToLowerInvariant().Contains(getString_0(107356834));
	}

	public static Struct23 smethod_0(string string_1)
	{
		int num = 0;
		int num2 = string_1.IndexOf('.', 0);
		if (num2 == -1)
		{
			throw new MySqlException(Class121.BadVersionFormat);
		}
		int int_ = Convert.ToInt32(string_1.Substring(num, num2 - num).Trim(), NumberFormatInfo.InvariantInfo);
		num = num2 + 1;
		num2 = string_1.IndexOf('.', num);
		if (num2 == -1)
		{
			throw new MySqlException(Class121.BadVersionFormat);
		}
		int int_2 = Convert.ToInt32(string_1.Substring(num, num2 - num).Trim(), NumberFormatInfo.InvariantInfo);
		num = num2 + 1;
		int i;
		for (i = num; i < string_1.Length && char.IsDigit(string_1, i); i++)
		{
		}
		int int_3 = Convert.ToInt32(string_1.Substring(num, i - num).Trim(), NumberFormatInfo.InvariantInfo);
		return new Struct23(string_1, int_, int_2, int_3);
	}

	public bool method_0(int int_3, int int_4, int int_5)
	{
		if (Major > int_3)
		{
			return true;
		}
		if (Major == int_3 && Minor > int_4)
		{
			return true;
		}
		if (Major == int_3 && Minor == int_4 && Build >= int_5)
		{
			return true;
		}
		return false;
	}

	string ValueType.ToString()
	{
		return string_0;
	}

	static Struct23()
	{
		Strings.CreateGetStringDelegate(typeof(Struct23));
	}
}
