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

	public extern GClass6(byte[] byte_0);

	private void method_0(ref Struct6 struct6_0)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		/*Error: stloc 0 (out-of-bounds)*/;
		_003F val = /*Error near IL_0002: ldloc 0 (out-of-bounds)*/;
		_ = 1417037981 << (int)/*Error near IL_0009: ldloc 0 (out-of-bounds)*/;
		/*Error near IL_0012: stloc 0 (out-of-bounds)*/;
		_ = val * /*Error near IL_0014: ldloc 0 (out-of-bounds)*/;
		/*Error: Unexpected end of block*/;
	}

	private extern void method_1(ref Struct6 struct6_0);

	public extern byte[] method_2(byte[] byte_0);

	public extern byte[] method_3(byte[] byte_0);

	public void method_4(byte[] byte_0, byte[] byte_1)
	{
		//Discarded unreachable code: IL_0006, IL_0007, IL_0008
		_ = -1841618895;
		/*Error near IL_0005: Unknown opcode: 0xFF*/;
	}

	public extern void method_5(byte[] byte_0, byte[] byte_1);
}
