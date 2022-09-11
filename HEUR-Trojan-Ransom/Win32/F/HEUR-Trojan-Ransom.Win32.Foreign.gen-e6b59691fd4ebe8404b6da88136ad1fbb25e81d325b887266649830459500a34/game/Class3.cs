using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace game;

internal class Class3 : Class1
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly int int_2 = 2;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private int int_3 = 2;

	protected override int Int32_3
	{
		[CompilerGenerated]
		get
		{
			return int_2;
		}
	}

	public override int Int32_4
	{
		[CompilerGenerated]
		get
		{
			return int_3;
		}
		[CompilerGenerated]
		protected set
		{
			int_3 = value;
		}
	}

	public Class3(Class8 class8_1)
		: base(class8_1)
	{
	}
}
