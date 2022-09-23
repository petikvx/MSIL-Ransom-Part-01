using System;
using System.Diagnostics;

internal struct Struct6
{
	private const int int_0 = 32;

	private int int_1;

	private uint uint_0;

	private uint[] uint_1;

	private bool bool_0;

	internal int Int32_0
	{
		get
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			_ = /*Error near IL_0001: Stack underflow*/% /*Error near IL_0001: Stack underflow*/;
			/*Error: Unexpected end of block*/;
		}
	}

	private extern int Int32_1 { get; }

	[Conditional("DEBUG")]
	private extern void method_0(bool bool_1);

	internal extern Struct6(int int_2);

	internal extern Struct6(Struct5 struct5_0, ref int int_2);

	internal extern Struct5 method_1(int int_2);

	private extern void method_2(int int_2, out int int_3, out uint[] uint_2);

	private extern void method_3(uint uint_2);

	private void method_4(ulong ulong_0)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			ushort num = checked((ushort)(uint)/*Error near IL_0002: Stack underflow*/);
			_ = ((IntPtr[])/*Error near IL_0005: Stack underflow*/)[num];
			/*Error near IL_0005: stloc 0 (out-of-bounds)*/;
			ushort num2 = ((ushort[])/*Error near IL_0009: Stack underflow*/)[/*Error near IL_0009: Stack underflow*/];
			_003F val = /*Error near IL_000a: Stack underflow*/- num2;
			_003F val2 = /*Error near IL_000c: Stack underflow*/>> (int)val;
			if (/*Error near IL_0011: Stack underflow*/ >= val2 && checked((nuint)/*Error near IL_0012: Stack underflow*/) == 0)
			{
				/*Error: Could not find block for branch target IL_0017*/;
			}
		}
	}

	private unsafe void method_5()
	{
		//Discarded unreachable code: IL_0009, IL_000e, IL_0015, IL_001b, IL_0021, IL_002b
		//IL_0016: Invalid comparison between Unknown and I
		//IL_001c: Invalid comparison between Unknown and I4
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		nuint num = checked((nuint)/*Error near IL_0001: Stack underflow*/);
		((IntPtr[])/*Error near IL_0002: Stack underflow*/)[/*Error near IL_0002: Stack underflow*/] = (nint)num;
		checked
		{
			_ = (long)(*unchecked((int*)(int)/*Error near IL_0002: ldloc 0 (out-of-bounds)*/));
			/*Error near IL_0008: Unknown opcode: 0xFF*/;
		}
	}

	private extern void method_6(int int_2);

	private extern void method_7(int int_2);

	private extern void method_8(int int_2, int int_3);

	private void method_9(int int_2 = 0)
	{
		_ = (nuint)0u;
	}

	private extern void method_10(ref Struct6 struct6_0, int int_2);

	private extern void method_11(uint uint_2);

	internal unsafe void method_12(ref Struct6 struct6_0, ref Struct6 struct6_1)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Invalid comparison between Unknown and F4
		while (true)
		{
			float num = *(float*)(int)((uint[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/];
			float num2 = *(float*)(nint)checked(/*Error near IL_0004: Stack underflow*/ + num);
			if (!((float)/*Error near IL_000a: Stack underflow*/ > num2))
			{
				sbyte num3 = checked((sbyte)/*Error near IL_000d: Stack underflow*/);
				short num4 = *(short*)((sbyte[])/*Error near IL_000e: Stack underflow*/)[num3];
				*(IntPtr*)(nint)/*Error near IL_0010: Stack underflow*/ = (nint)num4;
				if (*(byte*)(nint)/*Error near IL_0011: Stack underflow*/ == 0)
				{
					/*Error: Could not find block for branch target IL_0017*/;
				}
			}
		}
	}

	private static uint smethod_0(ref Struct6 struct6_0, uint uint_2)
	{
		//Discarded unreachable code: IL_0018
		//IL_0006: Invalid comparison between Unknown and I4
		//IL_000e: Invalid comparison between Unknown and I4
		while (true)
		{
			if (/*Error near IL_0005: Stack underflow*/ >= /*Error near IL_0005: Stack underflow*/&& (int)/*Error near IL_000b: Stack underflow*/ >= 7)
			{
				short num = checked((short)/*Error near IL_000c: Stack underflow*/);
				((IntPtr[])/*Error near IL_000d: Stack underflow*/)[/*Error near IL_000d: Stack underflow*/] = (nint)num;
				if ((int)/*Error near IL_0013: Stack underflow*/ >= 6)
				{
				}
			}
		}
	}

	internal extern void method_13(ref Struct6 struct6_0);

	private static extern void smethod_1(ref Struct6 struct6_0, ref Struct6 struct6_1, bool bool_1, ref Struct6 struct6_2);

	private static extern uint smethod_2(ref uint uint_2, uint uint_3, uint uint_4);

	private static extern uint smethod_3(ref uint uint_2, uint uint_3, uint uint_4);

	private static extern uint smethod_4(ref uint uint_2, uint uint_3, uint uint_4, uint uint_5);
}
