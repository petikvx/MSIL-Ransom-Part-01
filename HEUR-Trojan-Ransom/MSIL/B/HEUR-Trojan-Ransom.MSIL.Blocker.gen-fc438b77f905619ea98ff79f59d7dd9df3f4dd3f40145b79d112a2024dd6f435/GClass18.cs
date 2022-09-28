using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

public class GClass18
{
	private int int_0;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private readonly IntPtr intptr_0;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly int int_1;

	public extern IntPtr IntPtr_0
	{
		[CompilerGenerated]
		get;
	}

	public extern int Int32_0
	{
		[CompilerGenerated]
		get;
	}

	public extern int Int32_1 { get; set; }

	public extern GClass18(IntPtr intptr_1, int int_2);

	public void method_0(IntPtr intptr_1, int int_2, int int_3)
	{
		//Discarded unreachable code: IL_000f, IL_0017, IL_001e, IL_0028, IL_002f
		//IL_0004: Expected F4, but got I8
		//IL_0012: Expected I, but got F8
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			int num = (int)/*Error near IL_0001: Stack underflow*/;
			long num2 = ((long[])/*Error near IL_0002: Stack underflow*/)[num];
			((float[])/*Error near IL_0004: Stack underflow*/)[/*Error near IL_0004: Stack underflow*/] = num2;
			if (/*Error near IL_0009: Stack underflow*/ >= /*Error near IL_0009: Stack underflow*/)
			{
			}
		}
	}

	private bool method_1(int int_2, int int_3)
	{
		while (true)
		{
			((object[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/] = (object)/*Error near IL_0001: Stack underflow*/;
			if (/*Error near IL_0006: Stack underflow*/ == /*Error near IL_0006: Stack underflow*/)
			{
				/*Error: Could not find block for branch target IL_0006*/;
			}
		}
	}

	static Exception smethod_0(string string_0)
	{
		//Discarded unreachable code: IL_000a, IL_0015, IL_001a
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected I4, but got Unknown
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			if (/*Error near IL_0005: Stack underflow*/ > /*Error near IL_0005: Stack underflow*/)
			{
			}
		}
	}

	static extern AccessViolationException smethod_1(string string_0);
}
