using System;
using System.Runtime.CompilerServices;

internal class EventArgs3 : EventArgs
{
	private Enum0 enum0_0;

	private readonly bool bool_0;

	private readonly string string_0;

	private readonly string DaArodadUa;

	[SpecialName]
	public Enum0 method_0()
	{
		return enum0_0;
	}

	[SpecialName]
	public bool method_1()
	{
		return bool_0;
	}

	[SpecialName]
	public string method_2()
	{
		return string_0;
	}

	internal EventArgs3(Enum0 enum0_1, string string_1)
	{
		Class52.KPUgGmhz2nAeI();
		this._002Ector(enum0_1, string_1, string.Empty);
	}

	internal EventArgs3(Enum0 enum0_1, string string_1, string string_2)
	{
		Class52.KPUgGmhz2nAeI();
		string_0 = string.Empty;
		DaArodadUa = string.Empty;
		base._002Ector();
		enum0_0 = enum0_1;
		bool_0 = string_1 != null && string_1.Length > 0;
		string_0 = string_1;
		DaArodadUa = string_2;
	}
}
