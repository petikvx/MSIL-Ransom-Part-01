using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Permissions;
using System.Text;
using System.Threading;

public static class GClass2
{
	private static Thread thread_0;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private static bool bool_0;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private static string string_0;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private static string string_1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private static bool bool_1;

	private unsafe static bool Boolean_0
	{
		[CompilerGenerated]
		get
		{
			//Discarded unreachable code: IL_000f
			//IL_0004: Invalid comparison between Unknown and I4
			//IL_0012: Expected F4, but got Unknown
			short num2;
			do
			{
				float num = (float)/*Error near IL_0001: Stack underflow*/;
				*(double*)(nint)/*Error near IL_0003: Stack underflow*/ = num;
				num2 = checked((short)/*Error near IL_0004: Stack underflow*/);
			}
			while ((int)/*Error near IL_0009: Stack underflow*/ <= (int)num2 || /*Error near IL_000e: Stack underflow*/< /*Error near IL_000e: Stack underflow*/);
			/*Error near IL_000e: Unknown opcode: 0xFC*/;
		}
		[CompilerGenerated]
		set
		{
			//Discarded unreachable code: IL_001f, IL_0026, IL_002d
			//IL_0014: Invalid comparison between Unknown and I4
			while (true)
			{
				((long[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/] = (long)/*Error near IL_0001: Stack underflow*/;
				if ((byte)checked((nuint)unchecked((ushort)/*Error near IL_0003: Stack underflow*/)) != 0 && /*Error near IL_000f: Stack underflow*/<= /*Error near IL_000f: Stack underflow*/)
				{
					uint num = ((uint[])/*Error near IL_0011: Stack underflow*/)[/*Error near IL_0011: Stack underflow*/];
					_ = -1;
					/*Error near IL_0013: stloc 3 (out-of-bounds)*/;
					if ((int)/*Error near IL_0019: Stack underflow*/ >= (int)num)
					{
					}
				}
			}
		}
	}

	private unsafe static string String_0
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set
		{
			//Discarded unreachable code: IL_000f, IL_0014, IL_001d, IL_0024, IL_002e, IL_0036
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			_003F val = /*Error: ldloc 2 (out-of-bounds)*/;
			/*OpCode not supported: DebugBreak*/;
			short num = *(short*)(int)((ushort[])/*Error near IL_0003: Stack underflow*/)[val];
			short num2 = checked((short)((ushort[])/*Error near IL_0005: Stack underflow*/)[num]);
			uint num3 = ((uint[])/*Error near IL_0007: Stack underflow*/)[num2];
			_ = /*Error near IL_0009: Stack underflow*/- num3;
			/*Error near IL_000a: Invalid metadata token*/;
		}
	}

	public unsafe static string String_1
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set
		{
			//Discarded unreachable code: IL_000b
			_ = ((float[])(*(ushort*)checked((sbyte)/*Error near IL_0001: Stack underflow*/)))[ref *(_003F*)(&value)];
			/*Error near IL_0006: Invalid metadata token*/;
		}
	}

	public static extern bool Boolean_1
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[SecurityPermission(SecurityAction.Demand, ControlThread = true)]
	public static extern void smethod_0();

	[SecurityPermission(SecurityAction.Demand, ControlThread = true)]
	public static extern void smethod_1();

	private static extern void smethod_2();

	private static extern void smethod_3(object sender, DataReceivedEventArgs e);

	static GClass2()
	{
		//Discarded unreachable code: IL_0012, IL_0019, IL_0021, IL_0022, IL_002c, IL_0031
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected F8, but got Unknown
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		_003F val;
		do
		{
			((double[])(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/))[3] = (double)/*Error near IL_0002: ldloca 0 (out-of-bounds)*/;
			val = checked(/*Error near IL_0007: Stack underflow*/ + /*Error near IL_0007: Stack underflow*/);
		}
		while (/*Error near IL_000d: Stack underflow*/ > val);
		/*Error near IL_000d: Invalid metadata token*/;
	}

	static extern void smethod_4(Thread thread_1);

	static extern void smethod_5(Thread thread_1);

	unsafe static Thread smethod_6(ThreadStart threadStart_0)
	{
		//Discarded unreachable code: IL_0019, IL_001f, IL_002b, IL_0031, IL_0047
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected I, but got Unknown
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected I4, but got Unknown
		//IL_0026: Invalid comparison between Unknown and I4
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Incompatible stack heights: 0 vs 1
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		do
		{
			((double[])/*Error near IL_0002: Stack underflow*/)[/*Error near IL_0002: Stack underflow*/] = (double)/*Error near IL_0002: Stack underflow*/;
			*(_003F*)(nint)/*Error near IL_0003: Stack underflow*/ = /*Error near IL_0003: Stack underflow*/;
			byte num = ((byte[])/*Error near IL_0004: Stack underflow*/)[/*Error near IL_0004: Stack underflow*/];
			*(short*)(nint)/*Error near IL_0005: Stack underflow*/ = num;
			int num2 = checked((int)/*Error near IL_0006: Stack underflow*/);
			_003F val = /*Error near IL_0007: Stack underflow*/+ num2;
			((IntPtr[])/*Error near IL_0008: Stack underflow*/)[/*Error near IL_0008: Stack underflow*/] = (IntPtr)val;
		}
		while (/*Error near IL_0009: Stack underflow*/ % /*Error near IL_0009: Stack underflow*/>= /*Error near IL_0009: ldarg 3 (out-of-bounds)*/|| /*Error near IL_0014: Stack underflow*/>= /*Error near IL_0014: Stack underflow*/);
		/*Error near IL_0014: Invalid metadata token*/;
	}

	static extern Process smethod_7();

	static extern ProcessStartInfo smethod_8(Process process_0);

	unsafe static void smethod_9(ProcessStartInfo processStartInfo_0, string string_2)
	{
		//Discarded unreachable code: IL_000f, IL_0014
		while (/*Error near IL_0005: Stack underflow*/ >= /*Error near IL_0005: Stack underflow*/)
		{
		}
		checked
		{
			long num = (long)(*unchecked((float*)(nint)/*Error near IL_0006: Stack underflow*/));
			_ = ((byte[])/*Error near IL_0008: Stack underflow*/)[num];
			_ = -1;
			/*Error near IL_000a: Invalid metadata token*/;
		}
	}

	static void smethod_10(ProcessStartInfo processStartInfo_0, bool bool_2)
	{
	}

	static extern void smethod_11(ProcessStartInfo processStartInfo_0, bool bool_2);

	static extern void smethod_12(ProcessStartInfo processStartInfo_0, bool bool_2);

	static extern void smethod_13(ProcessStartInfo processStartInfo_0, bool bool_2);

	static extern void smethod_14(ProcessStartInfo processStartInfo_0, bool bool_2);

	static extern void smethod_15(Process process_0, DataReceivedEventHandler dataReceivedEventHandler_0);

	static extern bool smethod_16(Process process_0);

	static extern void smethod_17(Process process_0);

	static extern StreamWriter smethod_18(Process process_0);

	static extern void smethod_19(TextWriter textWriter_0, string string_2);

	static extern StringBuilder smethod_20();

	static extern string smethod_21(DataReceivedEventArgs dataReceivedEventArgs_0);

	static extern bool smethod_22(string string_2);

	static extern StringBuilder smethod_23(StringBuilder stringBuilder_0, string string_2);

	unsafe static Encoding smethod_24()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Invalid comparison between Unknown and I
		while (true)
		{
			_003F val = checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/);
			long num = ((long[])/*Error near IL_0002: Stack underflow*/)[val];
			((long[])/*Error near IL_0003: Stack underflow*/)[/*Error near IL_0003: Stack underflow*/] = num;
			if (checked((uint)/*Error near IL_0004: Stack underflow*/) != 0)
			{
				IntPtr intPtr = *(IntPtr*)(nint)/*Error near IL_000b: Stack underflow*/;
				if ((nint)/*Error near IL_0010: Stack underflow*/ <= (nint)intPtr)
				{
					/*Error: Could not find block for branch target IL_0010*/;
				}
			}
		}
	}

	static extern string smethod_25(object object_0);

	static byte[] smethod_26(Encoding encoding_0, string string_2)
	{
		//Discarded unreachable code: IL_0006, IL_0014, IL_001a
		//IL_0006: Unsupported input type for neg.
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		/*Error: ldloc 3 (out-of-bounds)*/;
		/*Error near IL_0001: Invalid metadata token*/;
	}
}
