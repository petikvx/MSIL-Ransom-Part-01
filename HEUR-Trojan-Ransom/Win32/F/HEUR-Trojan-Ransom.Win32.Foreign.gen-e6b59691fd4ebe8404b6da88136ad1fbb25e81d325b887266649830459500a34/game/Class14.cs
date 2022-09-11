using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace game;

internal class Class14
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private readonly int int_0 = 1;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private readonly int int_1 = 1;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private readonly double double_0 = 0.75;

	private readonly Class10 class10_0;

	protected virtual int Int32_0
	{
		[CompilerGenerated]
		get
		{
			return int_0;
		}
	}

	protected virtual int Int32_1
	{
		[CompilerGenerated]
		get
		{
			return int_1;
		}
	}

	protected virtual double Double_0
	{
		[CompilerGenerated]
		get
		{
			return double_0;
		}
	}

	public Class14(Class10 class10_1)
	{
		class10_0 = class10_1;
	}

	public bool method_0()
	{
		return Class12.smethod_0() < Double_0;
	}

	public void method_1(Interface2[] interface2_0)
	{
		int num = 0;
		Interface2 @interface;
		while (true)
		{
			if (num < interface2_0.Length)
			{
				@interface = interface2_0[num];
				if (@interface.Boolean_1 && class10_0.method_2(@interface.Class10_0, Int32_0))
				{
					break;
				}
				num++;
				continue;
			}
			return;
		}
		if (method_0())
		{
			@interface.imethod_1(Int32_1);
			if (@interface.Boolean_2)
			{
				Console.WriteLine("Neutralized an invader!");
			}
		}
		else
		{
			Console.WriteLine("Shot at and missedan invader!");
		}
	}
}
