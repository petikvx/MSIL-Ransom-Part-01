using System.Runtime.InteropServices;

public class GClass8
{
	[StructLayout(LayoutKind.Explicit)]
	private struct Struct8
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

	public extern GClass8(byte[] byte_0);

	private void method_0(ref Struct8 struct8_0)
	{
		//Discarded unreachable code: IL_000d
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Incompatible stack heights: 0 vs 1
		while (true)
		{
			_003F val = checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/);
			if (/*Error near IL_0006: Stack underflow*/ > val)
			{
				_003F val2 = ~/*Error near IL_0007: Stack underflow*/;
				_ = /*Error near IL_0008: Stack underflow*// val2;
			}
		}
	}

	private extern void method_1(ref Struct8 struct8_0);

	public extern byte[] method_2(byte[] byte_0);

	public extern byte[] method_3(byte[] byte_0);

	public extern void method_4(byte[] byte_0, byte[] byte_1);

	public void method_5(byte[] byte_0, byte[] byte_1)
	{
		//Discarded unreachable code: IL_000a, IL_0015, IL_001f, IL_0029, IL_0035
		//IL_0010: Incompatible stack heights: 0 vs 2
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Invalid comparison between Unknown and I4
		//IL_002b: Expected F8, but got I8
		/*Error: stloc 0 (out-of-bounds)*/;
		_ = (short)checked((nuint)((float[])/*Error near IL_0003: Stack underflow*/)[/*Error near IL_0003: Stack underflow*/]);
		/*Error near IL_0005: Invalid metadata token*/;
	}
}
