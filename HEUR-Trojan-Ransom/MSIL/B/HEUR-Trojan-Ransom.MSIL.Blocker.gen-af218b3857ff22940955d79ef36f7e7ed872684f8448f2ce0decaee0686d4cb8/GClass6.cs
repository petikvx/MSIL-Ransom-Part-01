using System;
using System.Runtime.InteropServices;

public class GClass6
{
	[StructLayout(LayoutKind.Explicit)]
	private struct Struct6
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

	public GClass6(byte[] byte_0)
	{
		//Discarded unreachable code: IL_000e, IL_000f, IL_0010, IL_0022, IL_0032, IL_0038, IL_003d
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Incompatible stack heights: 0 vs 1
		//IL_001d: Invalid comparison between Unknown and I4
		//IL_001d: Incompatible stack heights: 0 vs 3
		//IL_0026: Expected I4, but got O
		//IL_002d: Incompatible stack heights: 0 vs 1
		//IL_0045: Expected I4, but got O
		checked
		{
			while (true)
			{
				_ = /*Error near IL_0002: Stack underflow*/* /*Error near IL_0002: Stack underflow*/;
				/*Error near IL_0002: stloc 1 (out-of-bounds)*/;
				if (/*Error near IL_0008: Stack underflow*/ <= /*Error near IL_0008: Stack underflow*/)
				{
					/*Error near IL_0008: Stack underflow*/;
				}
			}
		}
	}

	private extern void method_0(ref Struct6 struct6_0);

	private void method_1(ref Struct6 struct6_0)
	{
		//Discarded unreachable code: IL_0001, IL_0007
		/*Error: Unknown opcode: 0xF9*/;
	}

	public unsafe byte[] method_2(byte[] byte_0)
	{
		//IL_0004: Expected O, but got I4
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected native int or pointer, but got F8
		//IL_000f: Invalid comparison between Unknown and I4
		//IL_001d: Expected O, but got I4
		short num;
		do
		{
			IntPtr intPtr = (nint)((Array)7).LongLength;
			_003F val = /*Error near IL_0006: Stack underflow*// (nint)intPtr;
			_003F val2 = /*Error near IL_0007: ldloc 3 (out-of-bounds)*/;
			num = *(short*)(nint)((double[])/*Error near IL_000b: Stack underflow*/)[val - (long)val2];
		}
		while ((int)/*Error near IL_0014: Stack underflow*/ > (int)num);
		object obj = ((object[])/*Error near IL_0016: Stack underflow*/)[2];
		*(object*)(nint)/*Error near IL_0017: Stack underflow*/ = obj;
		_ = ((Array)(-1568954717)).LongLength;
		_ = 8;
		_ = -1;
		/*Error near IL_0021: Invalid metadata token*/;
	}

	public byte[] method_3(byte[] byte_0)
	{
		//Discarded unreachable code: IL_0008, IL_000d, IL_0012, IL_0015, IL_001b, IL_0020, IL_0025, IL_002b, IL_0033
		//IL_0004: Expected O, but got I4
		_ = -((sbyte[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/];
		/*Error near IL_0003: Invalid metadata token*/;
	}

	public extern void method_4(byte[] byte_0, byte[] byte_1);

	public extern void method_5(byte[] byte_0, byte[] byte_1);
}
