using System.Runtime.InteropServices;

public class GClass7
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

	public extern GClass7(byte[] byte_0);

	private unsafe void method_0(ref Struct6 struct6_0)
	{
		//Discarded unreachable code: IL_0009, IL_000f, IL_0020, IL_0028, IL_0029, IL_0035
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Incompatible stack heights: 0 vs 1
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		do
		{
			_003F val = checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/);
			if (/*Error near IL_0003: Stack underflow*/ <= val)
			{
				_ = 2;
				/*Error near IL_0004: Invalid metadata token*/;
			}
		}
		while (/*Error near IL_0017: Stack underflow*/ <= /*Error near IL_0017: Stack underflow*/);
		_ = *(double*)(nint)/*Error near IL_0018: Stack underflow*/;
		/*Error near IL_0018: stloc 2 (out-of-bounds)*/;
		checked
		{
			_ = (ulong)/*Error near IL_001b: Stack underflow*/;
			/*Error near IL_001b: Invalid metadata token*/;
		}
	}

	private extern void method_1(ref Struct6 struct6_0);

	public extern byte[] method_2(byte[] byte_0);

	public extern byte[] method_3(byte[] byte_0);

	public extern void method_4(byte[] byte_0, byte[] byte_1);

	public extern void method_5(byte[] byte_0, byte[] byte_1);
}
