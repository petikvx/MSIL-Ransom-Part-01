using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace game;

internal class Class4 : Class1
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private int int_2 = 2;

	public override int Int32_3
	{
		[CompilerGenerated]
		get
		{
			return int_2;
		}
		[CompilerGenerated]
		protected set
		{
			int_2 = value;
		}
	}

	public Class4(Class8 class8_1)
		: base(class8_1)
	{
	}

	public virtual void vmethod_2(int int_3)
	{
		if (Class12.smethod_0() < 0.5)
		{
			base.vmethod_1(int_3);
		}
		else
		{
			Console.WriteLine("Shot at a Shilded invader but it sustained no damage.");
		}
	}
}
