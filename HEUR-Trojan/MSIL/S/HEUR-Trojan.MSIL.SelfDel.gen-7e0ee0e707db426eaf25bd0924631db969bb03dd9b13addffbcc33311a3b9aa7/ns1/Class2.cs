using System;
using System.Runtime.CompilerServices;
using ns0;

namespace ns1;

internal sealed class Class2
{
	[CompilerGenerated]
	private readonly string string_0;

	[CompilerGenerated]
	private readonly string string_1;

	[CompilerGenerated]
	private readonly string string_2;

	[CompilerGenerated]
	private readonly Enum0 enum0_0;

	[CompilerGenerated]
	private readonly string string_3;

	public Class2(string string_4, string string_5, string string_6, Enum0 enum0_1, string string_7)
	{
		if (Enum0.flag_4 == enum0_1 && "IPC$" == string_5)
		{
			enum0_1 |= Enum0.flag_3;
		}
		string_0 = string_4;
		string_1 = string_5;
		string_2 = string_6;
		enum0_0 = enum0_1;
		string_3 = string_7;
	}

	string object.ToString()
	{
		if (string.IsNullOrEmpty(method_0()))
		{
			return $"\\\\{Environment.MachineName}\\{method_1()}";
		}
		return $"\\\\{method_0()}\\{method_1()}";
	}

	[SpecialName]
	[CompilerGenerated]
	public string method_0()
	{
		return string_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public string method_1()
	{
		return string_1;
	}

	[SpecialName]
	[CompilerGenerated]
	public string method_2()
	{
		return string_2;
	}

	[SpecialName]
	[CompilerGenerated]
	public Enum0 method_3()
	{
		return enum0_0;
	}
}
