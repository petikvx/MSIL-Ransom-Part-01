using System;
using System.Runtime.CompilerServices;
using ns2;
using ns6;

namespace ns5;

internal sealed class EventArgs0 : EventArgs
{
	[CompilerGenerated]
	private Class12 class12_0;

	[CompilerGenerated]
	private Enum1 enum1_0;

	public EventArgs0(Enum1 enum1_1, Class12 class12_1)
	{
		method_3(enum1_1);
		method_1(class12_1);
	}

	[SpecialName]
	[CompilerGenerated]
	public Class12 method_0()
	{
		return class12_0;
	}

	[SpecialName]
	[CompilerGenerated]
	private void method_1(Class12 class12_1)
	{
		class12_0 = class12_1;
	}

	[SpecialName]
	[CompilerGenerated]
	public Enum1 method_2()
	{
		return enum1_0;
	}

	[SpecialName]
	[CompilerGenerated]
	private void method_3(Enum1 enum1_1)
	{
		enum1_0 = enum1_1;
	}
}
