using System;
using System.Runtime.CompilerServices;
using ns6;
using ns8;

namespace ns1;

internal sealed class EventArgs0 : EventArgs
{
	[CompilerGenerated]
	private Class38 class38_0;

	[CompilerGenerated]
	private Enum7 enum7_0;

	public EventArgs0(Enum7 enum7_1, Class38 class38_1)
	{
		method_3(enum7_1);
		method_1(class38_1);
	}

	[SpecialName]
	[CompilerGenerated]
	public Class38 method_0()
	{
		return class38_0;
	}

	[SpecialName]
	[CompilerGenerated]
	private void method_1(Class38 class38_1)
	{
		class38_0 = class38_1;
	}

	[SpecialName]
	[CompilerGenerated]
	public Enum7 method_2()
	{
		return enum7_0;
	}

	[SpecialName]
	[CompilerGenerated]
	private void method_3(Enum7 enum7_1)
	{
		enum7_0 = enum7_1;
	}
}
