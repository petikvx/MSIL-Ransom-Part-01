using System;
using System.Runtime.CompilerServices;
using ns1;

namespace ns5;

internal sealed class Class34
{
	private string string_0;

	private string string_1;

	private string string_2;

	private Enum6 enum6_0;

	private string string_3;

	public Class34(string string_4, string string_5, string string_6, Enum6 enum6_1, string string_7)
	{
		if (Enum6.const_4 == enum6_1 && "IPC$" == string_5)
		{
			enum6_1 |= Enum6.const_3;
		}
		string_0 = string_4;
		string_1 = string_5;
		string_2 = string_6;
		enum6_0 = enum6_1;
		string_3 = string_7;
	}

	[SpecialName]
	public string method_0()
	{
		return string_2;
	}

	[SpecialName]
	public Enum6 method_1()
	{
		return enum6_0;
	}

	[SpecialName]
	public bool method_2()
	{
		if ((enum6_0 & Enum6.const_2) != 0)
		{
			return false;
		}
		if ((enum6_0 & Enum6.const_3) != 0)
		{
			return false;
		}
		if ((enum6_0 & Enum6.const_1) != 0)
		{
			return false;
		}
		if ((enum6_0 & Enum6.const_4) == 0)
		{
			return true;
		}
		if (Enum6.const_4 == enum6_0 && string_1 != null && string_1.Length != 0)
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
