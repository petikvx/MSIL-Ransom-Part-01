using System.Runtime.InteropServices;

public class GClass10
{
	[StructLayout(LayoutKind.Explicit)]
	private struct Struct13
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

	public extern GClass10(byte[] byte_0);

	private void method_0(ref Struct13 struct13_0)
	{
		//Discarded unreachable code: IL_0005, IL_0007
		/*Error: Invalid metadata token*/;
	}

	private extern void method_1(ref Struct13 struct13_0);

	public extern byte[] method_2(byte[] byte_0);

	public extern byte[] method_3(byte[] byte_0);

	public extern void method_4(byte[] byte_0, byte[] byte_1);

	public void method_5(byte[] byte_0, byte[] byte_1)
	{
		//Discarded unreachable code: IL_000e
		//IL_0008: Invalid comparison between Unknown and I4
		while (true)
		{
			if (/*Error near IL_0006: Stack underflow*/ < /*Error near IL_0006: Stack underflow*/)
			{
				ushort num = ((ushort[])/*Error near IL_0007: Stack underflow*/)[/*Error near IL_0007: Stack underflow*/];
				if ((int)/*Error near IL_000d: Stack underflow*/ == num)
				{
					break;
				}
			}
		}
		/*Error near IL_000d: Unknown opcode: 0xF9*/;
	}
}
