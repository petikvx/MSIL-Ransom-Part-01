using System;
using System.Diagnostics;

internal struct Struct8
{
	private const int int_0 = 32;

	private int int_1;

	private uint uint_0;

	private uint[] uint_1;

	private bool bool_0;

	internal extern int Int32_0 { get; }

	private extern int Int32_1 { get; }

	[Conditional("DEBUG")]
	private extern void method_0(bool bool_1);

	internal unsafe Struct8(int int_2)
	{
		//IL_000d: Invalid comparison between Unknown and O
		object obj;
		do
		{
			long num = checked((long)/*Error: ldloc 0 (out-of-bounds)*/);
			_ = ((long[])/*Error near IL_0003: Stack underflow*/)[num];
			/*Error near IL_0003: ldloc 3 (out-of-bounds)*/;
			/*Error near IL_0005: stloc 0 (out-of-bounds)*/;
			IntPtr intPtr = *(IntPtr*)4;
			obj = ((object[])/*Error near IL_000c: Stack underflow*/)[(nint)intPtr];
		}
		while (/*Error near IL_0012: Stack underflow*/ >= obj);
		_ = (int)/*Error near IL_0013: Stack underflow*/;
		/*Error: Unexpected end of block*/;
	}

	internal extern Struct8(Struct7 struct7_0, ref int int_2);

	internal unsafe Struct7 method_1(int int_2)
	{
		//Discarded unreachable code: IL_0018, IL_0021, IL_0023, IL_0028, IL_002a, IL_002c
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Expected I4, but got Unknown
		//IL_000e: Incompatible stack heights: 0 vs 1
		while (true)
		{
			/*Error: stloc 1 (out-of-bounds)*/;
			if ((int)/*Error near IL_0006: Stack underflow*/ != 0)
			{
				short num = *(short*)(int)checked((byte)/*Error near IL_0007: Stack underflow*/);
				_003F val = /*Error near IL_0009: Stack underflow*/- num;
				((sbyte[])/*Error near IL_000a: Stack underflow*/)[/*Error near IL_000a: Stack underflow*/] = (sbyte)(int)val;
				_ = 5;
				/*OpCode not supported: DebugBreak*/;
				/*OpCode not supported: DebugBreak*/;
				if (3u != 0)
				{
					break;
				}
			}
		}
		/*Error near IL_0013: Invalid metadata token*/;
	}

	private extern void method_2(int int_2, out int int_3, out uint[] uint_2);

	private unsafe void method_3(uint uint_2)
	{
		//Discarded unreachable code: IL_001f, IL_0026
		//IL_0002: Invalid comparison between Unknown and F8
		//IL_000c: Expected F8, but got I4
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected I4, but got Unknown
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Invalid comparison between Unknown and Ref
		while (true)
		{
			/*OpCode not supported: DebugBreak*/;
			double num = *(double*)(nint)/*Error near IL_0002: Stack underflow*/;
			if (!((double)/*Error near IL_0007: Stack underflow*/ > num))
			{
				short num2 = ((short[])/*Error near IL_0008: Stack underflow*/)[/*Error near IL_0008: Stack underflow*/];
				/*OpCode not supported: DebugBreak*/;
				/*OpCode not supported: DebugBreak*/;
				*(double*)num2 = 4.0;
				long num3 = checked((long)/*Error near IL_000d: Stack underflow*/);
				_003F val = /*Error near IL_000e: Stack underflow*/>> (int)num3;
				((sbyte[])/*Error near IL_000f: Stack underflow*/)[/*Error near IL_000f: Stack underflow*/] = (sbyte)(int)val;
				if ((uint)(short)/*Error near IL_0010: Stack underflow*/ <= (uint)(sbyte)(ref this))
				{
					break;
				}
			}
		}
		_ = /*Error near IL_0019: Stack underflow*// /*Error near IL_0019: Stack underflow*/;
		/*OpCode not supported: DebugBreak*/;
		/*Error near IL_001a: Invalid metadata token*/;
	}

	private extern void method_4(ulong ulong_0);

	private extern void method_5();

	private unsafe void method_6(int int_2)
	{
		/*OpCode not supported: DebugBreak*/;
		/*OpCode not supported: DebugBreak*/;
		*(_003F*)(nint)/*Error near IL_0003: Stack underflow*/ = /*Error near IL_0003: Stack underflow*/;
		checked
		{
			_ = (long)/*Error near IL_0004: Stack underflow*/;
			/*OpCode not supported: DebugBreak*/;
			/*Error: Unexpected end of block*/;
		}
	}

	private extern void method_7(int int_2);

	private extern void method_8(int int_2, int int_3);

	private extern void method_9(int int_2 = 0);

	private extern void method_10(ref Struct8 struct8_0, int int_2);

	private extern void method_11(uint uint_2);

	internal extern void method_12(ref Struct8 struct8_0, ref Struct8 struct8_1);

	private unsafe static uint smethod_0(ref Struct8 struct8_0, uint uint_2)
	{
		//Discarded unreachable code: IL_0010, IL_001f, IL_0026, IL_0028
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unsupported input type for neg.
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		byte num;
		do
		{
			num = *(byte*)(nint)(/*Error near IL_0001: Stack underflow*/ ^ /*Error near IL_0001: Stack underflow*/);
		}
		while (/*Error near IL_0006: Stack underflow*/ * ~num < /*Error near IL_0006: ldloca 0 (out-of-bounds)*/);
		_ = *(byte*)(nint)(0 - /*Error near IL_000e: Stack underflow*/);
		/*Error near IL_000f: Unknown opcode: 0xFF*/;
	}

	internal extern void method_13(ref Struct8 struct8_0);

	private static extern void smethod_1(ref Struct8 struct8_0, ref Struct8 struct8_1, bool bool_1, ref Struct8 struct8_2);

	private static extern uint smethod_2(ref uint uint_2, uint uint_3, uint uint_4);

	private static extern uint smethod_3(ref uint uint_2, uint uint_3, uint uint_4);

	private static extern uint smethod_4(ref uint uint_2, uint uint_3, uint uint_4, uint uint_5);
}
