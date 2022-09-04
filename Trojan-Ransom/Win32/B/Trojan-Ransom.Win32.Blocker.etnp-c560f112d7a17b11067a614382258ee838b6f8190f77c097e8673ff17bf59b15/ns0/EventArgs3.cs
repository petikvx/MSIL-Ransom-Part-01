using System;
using System.Runtime.CompilerServices;

namespace ns0;

internal sealed class EventArgs3 : EventArgs
{
	private Enum0 enum0_0;

	private readonly bool bool_0;

	private readonly string string_0 = string.Empty;

	private readonly string string_1 = string.Empty;

	internal EventArgs3(Enum0 CO_, string CO_)
		: this(CO_, CO_, string.Empty)
	{
	}

	internal EventArgs3(Enum0 CO_, string CO_, string CO_)
	{
		enum0_0 = CO_;
		bool_0 = CO_ != null && CO_.Length > 0;
		string_0 = CO_;
		string_1 = CO_;
	}

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
}
