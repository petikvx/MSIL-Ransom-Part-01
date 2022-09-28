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

	public int Int32_1
	{
		get; set
		{
			//Discarded unreachable code: IL_0022, IL_0038, IL_003e
			//IL_000d: Invalid comparison between F4 and I4
			//IL_0016: Invalid comparison between Unknown and I4
			//IL_001b: Unknown result type (might be due to invalid IL or missing references)
			//IL_002c: Expected I4, but got F8
			checked
			{
				while (true)
				{
					if (unchecked((nint)/*Error near IL_0002: Stack underflow*/) != (short)(object)null && (float)/*Error near IL_000b: Stack underflow*/ == (float)(int)/*Error near IL_000b: ldarg 3 (out-of-bounds)*/)
					{
						_ = (ulong)/*Error near IL_0013: Stack underflow*/;
						/*Error near IL_0013: stloc 0 (out-of-bounds)*/;
						ushort num = (ushort)/*Error near IL_0016: Stack underflow*/;
						if (unchecked((int)/*Error near IL_001b: Stack underflow*/ <= (int)num))
						{
							break;
						}
					}
				}
			}
			_ = /*Error near IL_001c: Stack underflow*// /*Error near IL_001c: Stack underflow*/;
			/*Error near IL_001d: Invalid metadata token*/;
		}
	}

	public extern GClass18(IntPtr intptr_1, int int_2);

	public unsafe void method_0(IntPtr intptr_1, int int_2, int int_3)
	{
		//Discarded unreachable code: IL_000f
		//IL_0002: Invalid comparison between Unknown and I
		nuint num;
		do
		{
			((short[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/] = (short)/*Error near IL_0001: Stack underflow*/;
			num = checked((nuint)/*Error near IL_0002: Stack underflow*/);
		}
		while ((nint)/*Error near IL_0007: Stack underflow*/ > (nint)num);
		*(_003F*)(nint)/*Error near IL_0008: Stack underflow*/ = /*Error near IL_0008: Stack underflow*/;
		((sbyte[])/*Error near IL_0009: Stack underflow*/)[/*Error near IL_0009: Stack underflow*/] = (sbyte)/*Error near IL_0009: Stack underflow*/;
		checked
		{
			_ = (int)/*Error near IL_000a: Stack underflow*/;
			/*Error near IL_000a: Invalid metadata token*/;
		}
	}

	private extern bool method_1(int int_2, int int_3);

	unsafe static Exception smethod_0(string string_0)
	{
		//Discarded unreachable code: IL_0024, IL_002a, IL_0030
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Expected I8, but got I4
		//IL_0011: Expected I4, but got F8
		//IL_0013: Invalid comparison between Unknown and I4
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			uint num = ((uint[])/*Error near IL_0003: Stack underflow*/)[/*Error near IL_0003: Stack underflow*/];
			ushort num2 = checked((ushort)(/*Error near IL_0005: Stack underflow*/ + num));
			*(long*)(nint)/*Error near IL_0009: Stack underflow*/ = (int)num2;
			if (/*Error near IL_000e: Stack underflow*/ >= /*Error near IL_000e: Stack underflow*/)
			{
				double num3 = ((double[])/*Error near IL_0010: Stack underflow*/)[/*Error near IL_0010: Stack underflow*/];
				((short[])/*Error near IL_0011: Stack underflow*/)[/*Error near IL_0011: Stack underflow*/] = (short)(int)num3;
				int num4;
				checked
				{
					num4 = (int)(*unchecked((double*)(nint)/*Error near IL_0012: Stack underflow*/));
				}
				if ((int)/*Error near IL_0018: Stack underflow*/ <= num4 && /*Error near IL_001d: Stack underflow*/>= /*Error near IL_001d: Stack underflow*/)
				{
					break;
				}
			}
		}
		*(_003F*)(nint)/*Error near IL_001e: Stack underflow*/ = /*Error near IL_001e: Stack underflow*/;
		/*Error near IL_001f: Invalid metadata token*/;
	}

	unsafe static AccessViolationException smethod_1(string string_0)
	{
		//Discarded unreachable code: IL_0010
		//IL_0004: Invalid comparison between Unknown and I4
		ushort num;
		do
		{
			num = ((ushort[])/*Error near IL_0002: Stack underflow*/)[/*Error near IL_0002: Stack underflow*/];
		}
		while ((int)/*Error near IL_0009: Stack underflow*/ < (int)num);
		*(_003F*)(nint)/*Error near IL_000a: Stack underflow*/ = /*Error near IL_000a: Stack underflow*/;
		/*Error near IL_000b: Invalid metadata token*/;
	}
}
