using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace game;

internal class Class2 : Class1
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

	public Class2(Class8 class8_1)
		: base(class8_1)
	{
	}
}
