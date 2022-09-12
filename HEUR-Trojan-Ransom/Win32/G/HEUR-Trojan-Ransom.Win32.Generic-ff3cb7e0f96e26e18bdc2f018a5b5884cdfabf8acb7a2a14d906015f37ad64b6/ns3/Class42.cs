using System;
using System.Runtime.CompilerServices;
using ns5;

namespace ns3;

internal sealed class Class42
{
	private string string_0;

	private string string_1;

	private string string_2;

	private Enum7 enum7_0;

	private string string_3;

	public Class42(string string_4, string string_5, string string_6, Enum7 enum7_1, string string_7)
	{
		if (Enum7.const_4 == enum7_1 && "IPC$" == string_5)
		{
			enum7_1 |= Enum7.const_3;
		}
		string_0 = string_4;
		string_1 = string_5;
		string_2 = string_6;
		enum7_0 = enum7_1;
		string_3 = string_7;
	}

	[SpecialName]
	public string method_0()
	{
		return string_2;
	}

	[SpecialName]
	public Enum7 method_1()
	{
		return enum7_0;
	}

	[SpecialName]
	public bool method_2()
	{
		if ((enum7_0 & Enum7.const_2) != 0)
		{
			return false;
		}
		if ((enum7_0 & Enum7.const_3) != 0)
		{
			return false;
		}
		if ((enum7_0 & Enum7.const_1) != 0)
		{
			return false;
		}
		if ((enum7_0 & Enum7.const_4) == 0)
		{
			return true;
		}
		if (Enum7.const_4 == enum7_0 && string_1 != null && string_1.Length != 0)
		{
			return true;
		}
		return false;
	}

	string object.ToString()
	{
		if (string_0 != null && string_0.Length != 0)
		{
			return $"\\\\{string_0}\\{string_1}";
		}
		return $"\\\\{Environment.MachineName}\\{string_1}";
	}

	public bool method_3(string string_4)
	{
		if (!method_2())
		{
			return false;
		}
		if (string_4 != null && string_4.Length != 0)
		{
			return string_4.ToLower().StartsWith(string_2.ToLower());
		}
		return true;
	}
}
