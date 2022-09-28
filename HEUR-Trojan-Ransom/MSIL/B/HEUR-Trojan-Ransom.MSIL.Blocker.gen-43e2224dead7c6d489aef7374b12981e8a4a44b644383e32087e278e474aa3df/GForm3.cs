using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Speech.Synthesis;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;

public class GForm3 : Form
{
	internal struct Struct12
	{
		public uint uint_0;

		public Struct13 struct13_0;
	}

	[StructLayout(LayoutKind.Explicit)]
	internal struct Struct13
	{
		[FieldOffset(0)]
		public Struct14 struct14_0;
	}

	internal struct Struct14
	{
		public int int_0;

		public int int_1;

		public uint uint_0;

		public uint uint_1;

		public uint uint_2;

		public IntPtr intptr_0;
	}

	[CompilerGenerated]
	private sealed class Class18
	{
		public string string_0;

		public extern Class18();

		internal extern void method_0();

		static extern bool smethod_0(TextDataFormat textDataFormat_0);

		unsafe static string smethod_1(TextDataFormat textDataFormat_0)
		{
			//Discarded unreachable code: IL_003a, IL_003f, IL_0044
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0005: Invalid comparison between Unknown and I4
			//IL_0011: Invalid comparison between Unknown and F4
			//IL_001c: Invalid comparison between Unknown and F4
			//IL_002b: Unknown result type (might be due to invalid IL or missing references)
			while (true)
			{
				if ((/*Error near IL_0002: Stack underflow*/ & /*Error near IL_0002: Stack underflow*/) > -98)
				{
					continue;
				}
				((short[])/*Error near IL_000b: Stack underflow*/)[/*Error near IL_000b: Stack underflow*/] = (short)/*Error near IL_000b: Stack underflow*/;
				if (/*Error near IL_0010: Stack underflow*/ <= /*Error near IL_0010: Stack underflow*/)
				{
					continue;
				}
				float num = (float)/*Error near IL_0011: Stack underflow*/;
				if (!((float)/*Error near IL_0016: Stack underflow*/ > num) && (float)/*Error near IL_0021: Stack underflow*/ == 2f)
				{
					/*Error near IL_0023: stloc 0 (out-of-bounds)*/;
					if (/*Error near IL_002a: Stack underflow*/ > /*Error near IL_002a: Stack underflow*/)
					{
						break;
					}
				}
			}
			/*OpCode not supported: Ckfinite*/;
			_ = *(short*)(int)(*(ushort*)(nint)textDataFormat_0);
			/*Error near IL_0035: Invalid metadata token*/;
		}
	}

	public const int int_0 = 513;

	public const int int_1 = 514;

	public const int int_2 = 515;

	public const int int_3 = 516;

	public const int int_4 = 517;

	public const int int_5 = 518;

	private readonly int int_6;

	private readonly int int_7;

	private readonly bool bool_0;

	private readonly bool bool_1;

	private bool bool_2;

	private bool bool_3;

	private bool bool_4;

	private bool bool_5;

	private bool bool_6;

	private string string_0;

	private string string_1;

	private string string_2;

	private readonly string string_3;

	private readonly string string_4;

	private readonly GForm2 gform2_0;

	private readonly GForm1 gform1_0;

	private IContainer icontainer_0;

	[AsyncStateMachine(typeof(Class17))]
	[DebuggerStepThrough]
	private unsafe void method_0()
	{
		//Discarded unreachable code: IL_0008
		//IL_0003: Expected I, but got Unknown
		//IL_000c: Expected I4, but got Unknown
		//IL_000b: Expected native int or pointer, but got F8
		_003F val = /*Error near IL_0001: ldloc 2 (out-of-bounds)*/;
		*(IntPtr*)(nint)/*Error near IL_0003: Stack underflow*/ = (IntPtr)val;
		/*Error near IL_0003: Invalid metadata token*/;
	}

	[DllImport("winmm.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int mciSendStringA(string string_5, string string_6, int int_8, int int_9);

	private void method_1()
	{
		//Discarded unreachable code: IL_0001, IL_0006
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Invalid comparison between Unknown and I4
		/*Error: Unknown opcode: 0xFB*/;
	}

	private extern void method_2();

	private bool method_3()
	{
		//Discarded unreachable code: IL_0006
		//IL_0001: Incompatible stack heights: 0 vs 1
		checked
		{
			while (true)
			{
				_ = (nuint)/*Error near IL_0001: Stack underflow*/;
			}
		}
	}

	public extern GForm3();

	private extern void method_4(object sender, FormClosingEventArgs e);

	private extern void method_5(object sender, EventArgs e);

	private unsafe void method_6(object sender, EventArgs e)
	{
		//Discarded unreachable code: IL_0007, IL_000e
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = *(sbyte*)(nint)(/*Error near IL_0001: Stack underflow*/ | /*Error near IL_0001: Stack underflow*/);
		/*Error near IL_0002: Invalid metadata token*/;
	}

	private extern void method_7();

	[SecurityPermission(SecurityAction.Demand, ControlThread = true)]
	private extern void method_8(byte[] byte_0);

	private extern void method_9();

	private void method_10()
	{
		//Discarded unreachable code: IL_0002, IL_0007, IL_000d
		/*Error near IL_0001: Unknown opcode: 0xFC*/;
	}

	private extern void method_11();

	private extern void method_12();

	private void method_13()
	{
		//Discarded unreachable code: IL_0003, IL_000a, IL_0011, IL_0014, IL_001d
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Incompatible stack heights: 0 vs 1
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected I8, but got Unknown
		_ = /*Error near IL_0002: Stack underflow*// /*Error near IL_0002: Stack underflow*/;
		/*Error near IL_0002: Unknown opcode: 0xFC*/;
	}

	private extern void method_14(string string_5);

	private unsafe void method_15(string string_5)
	{
		//Discarded unreachable code: IL_0009
		*(_003F*)(nint)/*Error near IL_0001: Stack underflow*/ = /*Error near IL_0001: Stack underflow*/;
		((long[])/*Error near IL_0002: Stack underflow*/)[/*Error near IL_0002: Stack underflow*/] = (long)/*Error near IL_0002: Stack underflow*/;
		int num = *(int*)(nint)/*Error near IL_0003: Stack underflow*/;
		_ = ((double[])/*Error near IL_0004: Stack underflow*/)[num];
		/*Error near IL_0004: Invalid metadata token*/;
	}

	private extern void method_16(string string_5);

	private extern void method_17(string string_5);

	private extern void method_18(string string_5);

	private extern void method_19(string string_5);

	private extern void method_20(string string_5);

	private extern void method_21(string string_5);

	private extern void method_22(string string_5);

	private extern void method_23(string string_5);

	private extern void method_24(string string_5);

	private void method_25(string string_5)
	{
	}

	private extern void method_26();

	private extern void method_27();

	private extern void method_28();

	private extern void method_29();

	private extern void method_30();

	private extern void method_31();

	private extern void method_32();

	private extern void method_33();

	private extern void method_34();

	private extern void method_35();

	private extern void method_36();

	private unsafe void method_37()
	{
		//IL_0007: Invalid comparison between Unknown and I4
		while (true)
		{
			sbyte num;
			checked
			{
				num = (sbyte)unchecked((ulong)(*(double*)checked((long)/*Error near IL_0002: Stack underflow*/)));
			}
			if ((int)/*Error near IL_000c: Stack underflow*/ >= (int)num)
			{
				/*Error: Could not find block for branch target IL_000c*/;
			}
		}
	}

	private extern void method_38();

	private extern void method_39();

	private void method_40()
	{
		//Discarded unreachable code: IL_0006, IL_000c, IL_0012, IL_0015, IL_0017, IL_0018, IL_001a, IL_0021, IL_0026
		//IL_000d: Invalid comparison between Unknown and I4
		//IL_0015: Invalid comparison between I and Unknown
		//IL_0015: Incompatible stack heights: 2 vs 0
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		((long[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/] = (long)/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0001: Invalid metadata token*/;
	}

	private extern void method_41();

	private extern void method_42();

	private string method_43(string string_5, string string_6, string string_7)
	{
		while ((int)(double)/*Error near IL_0001: Stack underflow*/ != 0)
		{
		}
		/*Error near IL_0006: Invalid metadata token*/;
	}

	extern void Form.Dispose(bool disposing);

	private extern void method_44();

	[CompilerGenerated]
	private extern void method_45();

	static extern RegistryKey smethod_0(RegistryKey registryKey_0, string string_5, bool bool_7);

	static extern string smethod_1();

	static extern string smethod_2(string string_5);

	static extern void smethod_3(RegistryKey registryKey_0, string string_5, bool bool_7);

	static extern bool smethod_4(string string_5, string string_6);

	static void smethod_5(RegistryKey registryKey_0, string string_5, object object_0)
	{
		//IL_0001: Invalid comparison between Unknown and I
		nuint num;
		do
		{
			num = checked((nuint)/*Error near IL_0001: Stack underflow*/);
		}
		while ((nint)/*Error near IL_0006: Stack underflow*/ < (nint)num);
		switch (/*Error near IL_000b: Stack underflow*/)
		{
		default:
			;
			break;
		}
		/*Error: Unexpected end of block*/;
	}

	static extern void smethod_6(string string_5, string string_6, bool bool_7);

	static extern Process smethod_7(string string_5);

	static Process smethod_8()
	{
		//Discarded unreachable code: IL_0006, IL_000b, IL_0013, IL_0021, IL_0027, IL_002c, IL_0032, IL_0033, IL_0037, IL_003e
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected I4, but got Unknown
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Invalid comparison between Unknown and I4
		//IL_0032: Incompatible stack heights: 0 vs 1
		//IL_0039: Invalid comparison between I8 and Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		/*Error near IL_0001: Invalid metadata token*/;
	}

	static extern void smethod_9(Process process_0);

	static extern RegistryKey smethod_10(RegistryHive registryHive_0, RegistryView registryView_0);

	static RegistryKey smethod_11(RegistryKey registryKey_0, string string_5)
	{
		//Discarded unreachable code: IL_0002, IL_000f, IL_001a
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Expected O, but got Unknown
		//IL_0005: Unsupported input type for neg.
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected I4, but got I8
		//IL_0018: Expected I8, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected I4, but got Unknown
		/*Error near IL_0001: Unknown opcode: 0xFB*/;
	}

	static object smethod_12(RegistryKey registryKey_0, string string_5)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = (byte)unchecked(/*Error near IL_0001: Stack underflow*/ / /*Error near IL_0001: Stack underflow*/);
			/*Error near IL_0003: Invalid metadata token*/;
		}
	}

	static extern short smethod_13(string string_5);

	static extern bool smethod_14(string string_5, string string_6, StringComparison stringComparison_0);

	static extern string smethod_15(Environment.SpecialFolder specialFolder_0);

	static extern AppDomain smethod_16();

	static extern string smethod_17(AppDomain appDomain_0);

	static extern string smethod_18(string string_5, string string_6, string string_7);

	static extern string smethod_19(string string_5, string string_6);

	static CloseReason smethod_20(FormClosingEventArgs formClosingEventArgs_0)
	{
		//Discarded unreachable code: IL_0005
		/*Error: Invalid metadata token*/;
	}

	static extern void smethod_21(CancelEventArgs cancelEventArgs_0, bool bool_7);

	static IAsyncResult smethod_22(Control control_0, Delegate delegate_0)
	{
		//Discarded unreachable code: IL_0003
		/*OpCode not supported: DebugBreak*/;
		/*Error near IL_0001: stloc 3 (out-of-bounds)*/;
		/*Error near IL_0002: Unknown opcode: 0xFB*/;
	}

	unsafe static void smethod_23(string string_5)
	{
		//Discarded unreachable code: IL_000e, IL_0018, IL_001a, IL_001b, IL_0024, IL_002d, IL_0034
		//IL_000c: Expected I, but got I8
		//IL_000b: Expected native int or pointer, but got F8
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected I4, but got O
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		*(_003F*)(nint)/*Error near IL_0001: Stack underflow*/ = /*Error near IL_0001: Stack underflow*/;
		*(IntPtr*)(nint)((double[])/*Error near IL_0002: Stack underflow*/)[/*Error near IL_0002: Stack underflow*/] = unchecked((nint)3304756293880508811L);
		/*Error near IL_000c: ldarg 3 (out-of-bounds)*/;
		/*Error near IL_000d: Unknown opcode: 0xFD*/;
	}

	static extern Encoding smethod_24();

	static byte[] smethod_25(Encoding encoding_0, string string_5)
	{
		//Discarded unreachable code: IL_0006, IL_000b, IL_0016, IL_001d, IL_0023
		_ = -746779255;
		/*Error near IL_0005: Unknown opcode: 0xFA*/;
	}

	static extern int smethod_26(string string_5, char char_0);

	static string smethod_27(string string_5, int int_8)
	{
		//Discarded unreachable code: IL_000b, IL_0012
		//IL_0004: Expected O, but got I4
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Incompatible stack heights: 0 vs 1
		string_5 = (string)((uint[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/];
		_ = 3;
		/*Error near IL_0006: Invalid metadata token*/;
	}

	static void smethod_28(string string_5, byte[] byte_0)
	{
		//Discarded unreachable code: IL_0002, IL_0009
		checked
		{
			_ = (ushort)/*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Unknown opcode: 0xFD*/;
		}
	}

	static extern bool smethod_29(string string_5, string string_6);

	static string smethod_30()
	{
		//Discarded unreachable code: IL_0012, IL_0017, IL_001d, IL_002a, IL_003a
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		while ((uint)checked((byte)/*Error near IL_0001: Stack underflow*/) < 8u || /*Error near IL_000d: Stack underflow*/> /*Error near IL_000d: Stack underflow*/)
		{
		}
		/*Error near IL_000d: Invalid metadata token*/;
	}

	static extern string smethod_31(string string_5);

	static extern DirectoryInfo smethod_32(string string_5);

	static extern DirectoryInfo[] smethod_33(DirectoryInfo directoryInfo_0);

	static extern string smethod_34(FileSystemInfo fileSystemInfo_0);

	static extern DateTime smethod_35(FileSystemInfo fileSystemInfo_0);

	static string smethod_36(object[] object_0)
	{
		//IL_000b: Invalid comparison between F8 and Unknown
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		while (/*Error near IL_0005: Stack underflow*/ > /*Error near IL_0005: Stack underflow*/|| (double)(int)checked((byte)/*Error near IL_0008: Stack underflow*/) >= (double)/*Error near IL_0009: ldloca 0 (out-of-bounds)*/)
		{
		}
		checked
		{
			_ = /*Error near IL_0013: Stack underflow*/* /*Error near IL_0013: Stack underflow*/;
			_ = 0;
			/*Error near IL_0015: Invalid metadata token*/;
		}
	}

	static extern FileInfo[] smethod_37(DirectoryInfo directoryInfo_0);

	static extern string smethod_38(FileSystemInfo fileSystemInfo_0);

	static extern string smethod_39(string string_5);

	static extern string smethod_40(Encoding encoding_0, byte[] byte_0);

	static extern bool smethod_41(string string_5, string string_6);

	static extern string smethod_42(string string_5, string string_6, string string_7);

	static extern void smethod_43(int int_8);

	static void smethod_44()
	{
		switch (/*Error near IL_0005: Stack underflow*/)
		{
		default:
			;
			break;
		}
		/*Error: Unexpected end of block*/;
	}

	static extern bool smethod_45(Control control_0);

	static void smethod_46(Control control_0)
	{
		//Discarded unreachable code: IL_0007, IL_000e
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		_ = /*Error near IL_0002: Stack underflow*/^ /*Error near IL_0002: Stack underflow*/;
		/*Error near IL_0002: Invalid metadata token*/;
	}

	static extern void smethod_47();

	static void smethod_48(Control control_0)
	{
		//Discarded unreachable code: IL_0005, IL_0009
		/*Error: Invalid metadata token*/;
	}

	static extern Process[] smethod_49();

	static extern string smethod_50(Process process_0);

	static extern int smethod_51(Process process_0);

	unsafe static string smethod_52(Process process_0)
	{
		//Discarded unreachable code: IL_0014
		//IL_0002: Invalid comparison between I4 and Unknown
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		while ((int)(*(ushort*)(nint)/*Error near IL_0001: Stack underflow*/) <= (int)/*Error near IL_0001: ldarg 1 (out-of-bounds)*/)
		{
		}
		IntPtr intPtr = ((IntPtr[])/*Error near IL_0008: Stack underflow*/)[/*Error near IL_0008: Stack underflow*/];
		float num = *(float*)(nint)checked(/*Error near IL_000a: Stack underflow*/ + (double)unchecked((nuint)(nint)intPtr));
		checked
		{
			_ = /*Error near IL_000d: Stack underflow*/+ num;
			_ = -1;
			/*Error near IL_000f: Invalid metadata token*/;
		}
	}

	static extern Process smethod_53();

	static extern ProcessStartInfo smethod_54(Process process_0);

	static extern void smethod_55(ProcessStartInfo processStartInfo_0, string string_5);

	static extern void smethod_56(ProcessStartInfo processStartInfo_0, bool bool_7);

	static extern void smethod_57(ProcessStartInfo processStartInfo_0, string string_5);

	static bool smethod_58(Process process_0)
	{
		//Discarded unreachable code: IL_0006, IL_000c, IL_0012, IL_0017
		checked
		{
			_ = (nint)/*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Invalid metadata token*/;
		}
	}

	static extern void smethod_59(Point point_0);

	static extern DialogResult smethod_60(string string_5, string string_6, MessageBoxButtons messageBoxButtons_0, MessageBoxIcon messageBoxIcon_0);

	static extern SpeechSynthesizer smethod_61();

	static extern void smethod_62(SpeechSynthesizer speechSynthesizer_0);

	static void smethod_63(SpeechSynthesizer speechSynthesizer_0, string string_5)
	{
		//Discarded unreachable code: IL_0005, IL_000a, IL_0011, IL_0019
		/*Error: Invalid metadata token*/;
	}

	static extern void smethod_64(IDisposable idisposable_0);

	static extern Process smethod_65(int int_8);

	static extern FileStream smethod_66(string string_5, FileMode fileMode_0);

	static extern long smethod_67(Stream stream_0);

	static int smethod_68(Stream stream_0, byte[] byte_0, int int_8, int int_9)
	{
		//Discarded unreachable code: IL_0001, IL_001a, IL_0027, IL_002b
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected I8, but got Unknown
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got I4
		/*Error: Unknown opcode: 0xFF*/;
	}

	static string smethod_69(Exception exception_0)
	{
		//Discarded unreachable code: IL_0008, IL_000e, IL_0015, IL_001c, IL_0025
		//IL_0017: Invalid comparison between Unknown and I4
		//IL_0020: Invalid comparison between Unknown and I4
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		_ = ((IntPtr[])/*Error near IL_0002: Stack underflow*/)[/*Error near IL_0002: Stack underflow*/];
		/*Error near IL_0003: Invalid metadata token*/;
	}

	static extern Random smethod_70();

	static extern int smethod_71(Random random_0, int int_8, int int_9);

	static extern string smethod_72(object object_0, object object_1);

	static extern void smethod_73(string string_5);

	static string smethod_74(Control control_0)
	{
		while (true)
		{
			((sbyte[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/] = (sbyte)/*Error near IL_0001: Stack underflow*/;
		}
	}

	static bool smethod_75(string string_5)
	{
		while (/*Error near IL_0005: Stack underflow*/ == /*Error near IL_0005: Stack underflow*/)
		{
		}
		return true;
	}

	static extern string smethod_76();

	unsafe static void smethod_77(TextBoxBase textBoxBase_0, string string_5)
	{
		//Discarded unreachable code: IL_0007, IL_0010
		//IL_0002: Expected F8, but got I4
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Invalid comparison between Unknown and I4
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		*(double*)(nint)/*Error near IL_0002: Stack underflow*/ = -1.0;
		/*Error near IL_0002: Invalid metadata token*/;
	}

	static extern void smethod_78(Control control_0, string string_5);

	static extern DirectoryInfo smethod_79(string string_5);

	static extern string smethod_80(object object_0);

	static extern Thread smethod_81(ThreadStart threadStart_0);

	static extern void smethod_82(Thread thread_0, ApartmentState apartmentState_0);

	static extern void smethod_83(Thread thread_0);

	static extern void smethod_84(Thread thread_0);

	static extern bool smethod_85(string string_5);

	static extern void smethod_86(int int_8);

	unsafe static int smethod_87(string string_5, string string_6)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected F8, but got Unknown
		((int[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/] = (int)/*Error near IL_0001: Stack underflow*/;
		float num = ((float[])(int)checked((ushort)(*unchecked((ulong*)(nint)/*Error near IL_0002: Stack underflow*/))))[-2126754786];
		_003F val = /*Error near IL_000b: Stack underflow*/- num;
		*(double*)(nint)/*Error near IL_000c: Stack underflow*/ = (double)val;
		switch (*(short*)(nint)/*Error near IL_000e: Stack underflow*/)
		{
		default:
			;
			break;
		}
		/*Error: Unexpected end of block*/;
	}

	static extern int smethod_88(string string_5);

	static extern string smethod_89(string string_5, int int_8, int int_9);

	static extern void smethod_90(Control control_0);

	static extern void smethod_91(Control control_0);
}
