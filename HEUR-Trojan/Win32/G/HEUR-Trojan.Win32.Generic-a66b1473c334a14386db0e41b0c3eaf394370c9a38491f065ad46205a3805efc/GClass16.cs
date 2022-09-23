using System;
using System.Runtime.InteropServices;

public class GClass16
{
	[StructLayout(LayoutKind.Explicit)]
	private struct Struct7
	{
		[FieldOffset(0)]
		public ulong ulong_0;

		[FieldOffset(0)]
		public uint uint_0;

		[FieldOffset(4)]
		public uint uint_1;
	}

	private const int int_0 = 15;

	private const int int_1 = 8;

	private const int int_2 = 2;

	private const int int_3 = 32;

	private readonly uint[] uint_0;

	private const uint uint_1 = 4207804417u;

	private const uint uint_2 = 4207804418u;

	public GClass16(byte[] byte_0)
	{
		_ = typeof(float);
	}

	private void method_0(ref Struct7 struct7_0)
	{
		_ = ((GClass28.Class16)this).float_0;
		/*Error: Unexpected end of block*/;
	}

	private extern void method_1(ref Struct7 struct7_0);

	public extern byte[] method_2(byte[] byte_0);

	public extern byte[] method_3(byte[] byte_0);

	public void method_4(byte[] byte_0, byte[] byte_1)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			_ = ((IntPtr[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/];
			/*OpCode not supported: DebugBreak*/;
			/*Error near IL_0002: stloc 0 (out-of-bounds)*/;
			if (/*Error near IL_0008: Stack underflow*/ != /*Error near IL_0008: Stack underflow*/&& (0x2BA33BA4 & /*Error near IL_000d: ldloc 0 (out-of-bounds)*/) != 0)
			{
				/*Error: Could not find block for branch target IL_0014*/;
			}
		}
	}

	public unsafe void method_5(byte[] byte_0, byte[] byte_1)
	{
		//Discarded unreachable code: IL_0006, IL_0007, IL_0008
		_ = *(double*)(nint)/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0001: Invalid metadata token*/;
	}
}
