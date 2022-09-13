using System.Diagnostics;
using System.Runtime.CompilerServices;

public class GClass1
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private string string_0;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private string string_1;

	public extern string String_0
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public string String_1
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set
		{
			((float[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/] = (float)/*Error near IL_0001: Stack underflow*/;
			/*Error: Unexpected end of block*/;
		}
	}

	public extern GClass1();
}
