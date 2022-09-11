using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace game;

internal abstract class Class1 : Interface0, Interface1, Interface2
{
	private readonly Class8 class8_0;

	private int int_0 = 0;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private readonly int int_1 = 1;

	protected virtual int Int32_1
	{
		[CompilerGenerated]
		get
		{
			return int_1;
		}
	}

	public Class10 Class10_1 => class8_0.method_0(int_0);

	public abstract int Int32_2 { get; protected set; }

	public bool Boolean_3 => int_0 >= class8_0.Int32_0;

	public bool Boolean_4 => Int32_2 <= 0;

	public bool Boolean_5 => !Boolean_4 && !Boolean_3;

	public Class1(Class8 class8_1)
	{
		class8_0 = class8_1;
	}

	public void vmethod_0()
	{
		int_0 += Int32_1;
	}

	public virtual void vmethod_1(int int_2)
	{
		Int32_2 -= int_2;
		Console.WriteLine("Shot at and hit an invader!");
	}
}
