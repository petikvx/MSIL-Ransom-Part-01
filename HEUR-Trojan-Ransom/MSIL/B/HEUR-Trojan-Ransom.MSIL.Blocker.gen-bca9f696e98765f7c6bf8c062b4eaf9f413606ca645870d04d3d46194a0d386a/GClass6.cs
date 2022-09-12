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

	public unsafe GClass6(byte[] byte_0)
	{
		//Discarded unreachable code: IL_0015
		//IL_000c: Expected native int or pointer, but got F8
		//IL_0012: Expected F8, but got I4
		//IL_0018: Expected I4, but got Unknown
		//IL_0017: Expected native int or pointer, but got F8
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		ushort num = *(ushort*)unchecked((nint)9.423838577639173E+145);
		ushort num2 = ((ushort[])/*Error near IL_000f: Stack underflow*/)[num];
		/*OpCode not supported: Ckfinite*/;
		*(double*)(nint)/*Error near IL_0012: Stack underflow*/ = (int)num2;
		checked
		{
			_ = (nuint)/*Error near IL_0014: Stack underflow*/;
			/*Error near IL_0014: Unknown opcode: 0xFF*/;
		}
	}

	private extern void method_0(ref Struct6 struct6_0);

	private extern void method_1(ref Struct6 struct6_0);

	public extern byte[] method_2(byte[] byte_0);

	public extern byte[] method_3(byte[] byte_0);

	public extern void method_4(byte[] byte_0, byte[] byte_1);

	public extern void method_5(byte[] byte_0, byte[] byte_1);
}
