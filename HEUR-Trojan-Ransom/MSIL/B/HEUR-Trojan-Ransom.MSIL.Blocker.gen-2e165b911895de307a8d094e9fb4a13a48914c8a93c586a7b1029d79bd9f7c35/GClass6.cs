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
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = /*Error near IL_0001: Stack underflow*/* /*Error near IL_0001: Stack underflow*/;
		_ = 7;
		/*Error near IL_0002: Invalid metadata token*/;
	}

	private extern void method_0(ref Struct6 struct6_0);

	private unsafe void method_1(ref Struct6 struct6_0)
	{
		//Discarded unreachable code: IL_0015
		while ((int)/*Error near IL_0005: Stack underflow*/ == 0)
		{
		}
		int num = *(int*)(nint)/*Error near IL_0006: Stack underflow*/;
		int num2 = ((int[])/*Error near IL_0007: Stack underflow*/)[num];
		*(int*)((sbyte[])/*Error near IL_0008: Stack underflow*/)[num2] = 1;
		_003F val = /*Error near IL_000a: ldarg 3 (out-of-bounds)*/;
		/*OpCode not supported: Ckfinite*/;
		checked
		{
			_ = (uint)val;
			/*Error near IL_000f: ldloc 0 (out-of-bounds)*/;
			/*Error near IL_0010: Invalid metadata token*/;
		}
	}

	public unsafe byte[] method_2(byte[] byte_0)
	{
		//Discarded unreachable code: IL_0016, IL_001d, IL_0028
		//IL_000c: Invalid comparison between Unknown and I4
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Invalid comparison between Unknown and I8
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			if (*(short*)(&this) == 0)
			{
				/*Error near IL_0008: stloc 2 (out-of-bounds)*/;
				uint num = (uint)/*Error near IL_000b: Stack underflow*/;
				if ((int)/*Error near IL_0011: Stack underflow*/ >= (int)num)
				{
					break;
				}
			}
		}
		/*Error near IL_0011: Invalid metadata token*/;
	}

	public extern byte[] method_3(byte[] byte_0);

	public extern void method_4(byte[] byte_0, byte[] byte_1);

	public extern void method_5(byte[] byte_0, byte[] byte_1);
}
