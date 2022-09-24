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
		throw /*Error near IL_0001: Stack underflow*/;
	}

	private extern void method_1(ref Struct6 struct6_0);

	public extern byte[] method_2(byte[] byte_0);

	public byte[] method_3(byte[] byte_0)
	{
		//Discarded unreachable code: IL_0002, IL_0007, IL_000c, IL_0011, IL_0016, IL_001b, IL_0020
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected I4, but got Unknown
		/*Error near IL_0001: Unknown opcode: 0xFF*/;
	}

	public void method_4(byte[] byte_0, byte[] byte_1)
	{
		//Discarded unreachable code: IL_0005, IL_000a, IL_0010, IL_0017, IL_001e, IL_0023, IL_002a
		while (true)
		{
		}
	}

	public extern void method_5(byte[] byte_0, byte[] byte_1);
}
