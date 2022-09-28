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

		internal void method_0()
		{
			//IL_0001: Invalid comparison between Unknown and I4
			//IL_0013: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Incompatible stack heights: 0 vs 1
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			checked
			{
				while (true)
				{
					int num = ((int[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/];
					if (unchecked((int)/*Error near IL_0006: Stack underflow*/) != num && /*Error near IL_000c: Stack underflow*/<= /*Error near IL_000c: Stack underflow*/)
					{
						_ = (sbyte)(/*Error near IL_0014: Stack underflow*/ & -2.1591239E-16f);
						if (2u != 0)
						{
							break;
						}
					}
				}
				_ = /*Error near IL_001d: Stack underflow*/* /*Error near IL_001d: Stack underflow*/;
				_ = -5113292374815755059L;
				/*Error: Unexpected end of block*/;
			}
		}

		static extern bool smethod_0(TextDataFormat textDataFormat_0);

		static string smethod_1(TextDataFormat textDataFormat_0)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			checked
			{
				_ = (short)unchecked(/*Error near IL_0001: Stack underflow*/ % /*Error near IL_0001: Stack underflow*/);
				_ = 8;
				/*Error near IL_0005: Invalid metadata token*/;
			}
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

	[AsyncStateMachine(/*Could not decode attribute arguments.*/)]
	[DebuggerStepThrough]
	private extern void method_0();

	[DllImport("winmm.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int mciSendStringA(string string_5, string string_6, int int_8, int int_9);

	private extern void method_1();

	private extern void method_2();

	private extern bool method_3();

	public GForm3()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			_003F val = checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/);
			if (/*Error near IL_0006: Stack underflow*/ < val)
			{
				/*Error: Could not find block for branch target IL_0006*/;
			}
		}
	}

	private extern void method_4(object sender, FormClosingEventArgs e);

	private extern void method_5(object sender, EventArgs e);

	private extern void method_6(object sender, EventArgs e);

	private extern void method_7();

	[SecurityPermission(SecurityAction.Demand, ControlThread = true)]
	private void method_8(byte[] byte_0)
	{
		//Discarded unreachable code: IL_0006, IL_000b, IL_0010, IL_0017, IL_001d, IL_0027
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/* /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Invalid metadata token*/;
		}
	}

	private extern void method_9();

	private void method_10()
	{
		//Discarded unreachable code: IL_0006, IL_000b, IL_0011
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = /*Error near IL_0001: Stack underflow*/>> (int)/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0001: Invalid metadata token*/;
	}

	private extern void method_11();

	private extern void method_12();

	private void method_13()
	{
		//Discarded unreachable code: IL_0005, IL_000c, IL_0012, IL_0016, IL_001e, IL_001f
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unsupported input type for neg.
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		/*Error: Invalid metadata token*/;
	}

	private extern void method_14(string string_5);

	private extern void method_15(string string_5);

	private extern void method_16(string string_5);

	private extern void method_17(string string_5);

	private extern void method_18(string string_5);

	private extern void method_19(string string_5);

	private extern void method_20(string string_5);

	private void method_21(string string_5)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		_ = /*Error near IL_0003: Stack underflow*/>> (int)/*Error near IL_0003: Stack underflow*/;
		/*Error: Unexpected end of block*/;
	}

	private extern void method_22(string string_5);

	private extern void method_23(string string_5);

	private extern void method_24(string string_5);

	private void method_25(string string_5)
	{
		//Discarded unreachable code: IL_0006, IL_000d, IL_0014, IL_001c, IL_0023, IL_0029
		//IL_000f: Invalid comparison between Unknown and O
		//IL_0017: Invalid comparison between Unknown and O
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		/*Error near IL_0001: Invalid metadata token*/;
	}

	private extern void method_26();

	private extern void method_27();

	private extern void method_28();

	private extern void method_29();

	private unsafe void method_30()
	{
		//IL_0002: Expected native int or pointer, but got O
		//IL_0008: Invalid comparison between Unknown and I
		int num2;
		do
		{
			long num = *(byte*)(nint)this;
			num2 = ((int[])/*Error near IL_0005: Stack underflow*/)[num];
		}
		while ((nint)/*Error near IL_000d: Stack underflow*/ <= (nint)(uint)num2);
		/*Error near IL_000d: Invalid metadata token*/;
	}

	private extern void method_31();

	private extern void method_32();

	private void method_33()
	{
		//Discarded unreachable code: IL_0002, IL_000d, IL_0010
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected I4, but got O
		//IL_001e: Expected native int or pointer, but got O
		_ = (int)/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0001: Unknown opcode: 0xFB*/;
	}

	private extern void method_34();

	private unsafe void method_35()
	{
		//Discarded unreachable code: IL_0007
		_ = *(ushort*)(nint)/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0002: Invalid metadata token*/;
	}

	private extern void method_36();

	private extern void method_37();

	private extern void method_38();

	private extern void method_39();

	private extern void method_40();

	private extern void method_41();

	private extern void method_42();

	private extern string method_43(string string_5, string string_6, string string_7);

	extern void Form.Dispose(bool disposing);

	private void method_44()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/- /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Invalid metadata token*/;
		}
	}

	[CompilerGenerated]
	private extern void method_45();

	static RegistryKey smethod_0(RegistryKey registryKey_0, string string_5, bool bool_7)
	{
		return (RegistryKey)/*OpCode not supported: Nop*/;
	}

	static string smethod_1()
	{
		//Discarded unreachable code: IL_0005, IL_000d, IL_0013, IL_001f
		//IL_0008: Invalid comparison between Unknown and O
		//IL_000e: Invalid comparison between Unknown and I8
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
		}
	}

	static extern string smethod_2(string string_5);

	static extern void smethod_3(RegistryKey registryKey_0, string string_5, bool bool_7);

	static extern bool smethod_4(string string_5, string string_6);

	static extern void smethod_5(RegistryKey registryKey_0, string string_5, object object_0);

	static extern void smethod_6(string string_5, string string_6, bool bool_7);

	static extern Process smethod_7(string string_5);

	static extern Process smethod_8();

	unsafe static void smethod_9(Process process_0)
	{
		//Discarded unreachable code: IL_001d
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Invalid comparison between Unknown and I8
		while (true)
		{
			byte num = *(byte*)(nint)(/*Error near IL_0006: Stack underflow*/ / -1832911452);
			if ((long)checked(/*Error near IL_0009: Stack underflow*/ + num) > 1L)
			{
			}
		}
	}

	static extern RegistryKey smethod_10(RegistryHive registryHive_0, RegistryView registryView_0);

	static extern RegistryKey smethod_11(RegistryKey registryKey_0, string string_5);

	unsafe static object smethod_12(RegistryKey registryKey_0, string string_5)
	{
		//Discarded unreachable code: IL_000d
		//IL_0008: Expected O, but got I4
		//IL_0009: Expected O, but got F8
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		_ = *(double*)(nint)/*Error near IL_0001: Stack underflow*/;
		registryKey_0 = (RegistryKey)826006727;
		/*Error near IL_0008: Invalid metadata token*/;
	}

	static extern short smethod_13(string string_5);

	static extern bool smethod_14(string string_5, string string_6, StringComparison stringComparison_0);

	static extern string smethod_15(Environment.SpecialFolder specialFolder_0);

	static extern AppDomain smethod_16();

	static extern string smethod_17(AppDomain appDomain_0);

	static extern string smethod_18(string string_5, string string_6, string string_7);

	static extern string smethod_19(string string_5, string string_6);

	unsafe static CloseReason smethod_20(FormClosingEventArgs formClosingEventArgs_0)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		byte num = *(byte*)(nint)(/*Error near IL_0001: Stack underflow*/ % /*Error near IL_0001: Stack underflow*/);
		_003F val = /*Error near IL_0004: Stack underflow*/% num;
		_ = ((double[])/*Error near IL_0005: Stack underflow*/)[val];
		/*Error: Unexpected end of block*/;
	}

	static extern void smethod_21(CancelEventArgs cancelEventArgs_0, bool bool_7);

	static extern IAsyncResult smethod_22(Control control_0, Delegate delegate_0);

	static extern void smethod_23(string string_5);

	static extern Encoding smethod_24();

	static byte[] smethod_25(Encoding encoding_0, string string_5)
	{
		//Discarded unreachable code: IL_0006, IL_001b, IL_0020
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Incompatible stack heights: 0 vs 1
		checked
		{
			_ = (int)/*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Invalid metadata token*/;
		}
	}

	static extern int smethod_26(string string_5, char char_0);

	static extern string smethod_27(string string_5, int int_8);

	static extern void smethod_28(string string_5, byte[] byte_0);

	static extern bool smethod_29(string string_5, string string_6);

	static extern string smethod_30();

	static extern string smethod_31(string string_5);

	static extern DirectoryInfo smethod_32(string string_5);

	static extern DirectoryInfo[] smethod_33(DirectoryInfo directoryInfo_0);

	unsafe static string smethod_34(FileSystemInfo fileSystemInfo_0)
	{
		//Discarded unreachable code: IL_0028, IL_0030, IL_0031
		//IL_001b: Expected O, but got I8
		//IL_001c: Expected I4, but got Unknown
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected I4, but got Unknown
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Incompatible stack heights: 0 vs 1
		while (/*Error near IL_0006: Stack underflow*/ != /*Error near IL_0006: Stack underflow*/|| checked((nint)/*Error near IL_0007: Stack underflow*/) != (nint)fileSystemInfo_0)
		{
		}
		_003F val = /*Error near IL_000d: ldloc 3 (out-of-bounds)*/;
		fileSystemInfo_0 = (FileSystemInfo)4615159057211548761L;
		((int[])/*Error near IL_001c: Stack underflow*/)[/*Error near IL_001c: Stack underflow*/] = (int)val;
		fileSystemInfo_0 = (FileSystemInfo)/*Error near IL_001f: Stack underflow*/;
		_003F val2 = /*Error near IL_0020: Stack underflow*/+ /*Error near IL_0020: Stack underflow*/;
		*(sbyte*)(nint)/*Error near IL_0021: Stack underflow*/ = (sbyte)(int)val2;
		_003F val3 = /*Error near IL_0023: ldarg 1 (out-of-bounds)*/;
		_ = /*Error near IL_0027: Stack underflow*/& (short)val3;
		/*Error near IL_0027: Unknown opcode: 0xFC*/;
	}

	static extern DateTime smethod_35(FileSystemInfo fileSystemInfo_0);

	static extern string smethod_36(object[] object_0);

	static extern FileInfo[] smethod_37(DirectoryInfo directoryInfo_0);

	static extern string smethod_38(FileSystemInfo fileSystemInfo_0);

	static extern string smethod_39(string string_5);

	static extern string smethod_40(Encoding encoding_0, byte[] byte_0);

	static bool smethod_41(string string_5, string string_6)
	{
		//Discarded unreachable code: IL_0007, IL_000d, IL_0012, IL_0018, IL_002c
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected I4, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		/*Error near IL_0001: ldloc 0 (out-of-bounds)*/;
		/*Error near IL_0002: Invalid metadata token*/;
	}

	static extern string smethod_42(string string_5, string string_6, string string_7);

	static extern void smethod_43(int int_8);

	static extern void smethod_44();

	static bool smethod_45(Control control_0)
	{
		sbyte num;
		do
		{
			((IntPtr[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/] = (IntPtr)/*Error near IL_0001: Stack underflow*/;
			num = checked((sbyte)/*Error near IL_0002: Stack underflow*/);
		}
		while (num <= num);
		throw 5;
	}

	static extern void smethod_46(Control control_0);

	static extern void smethod_47();

	static extern void smethod_48(Control control_0);

	static Process[] smethod_49()
	{
		//Discarded unreachable code: IL_0005, IL_0014, IL_001e, IL_0026, IL_002b, IL_0034, IL_003c, IL_0041, IL_0046
		//IL_000f: Invalid comparison between Unknown and I8
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Incompatible stack heights: 0 vs 1
		//IL_0021: Invalid comparison between Unknown and F4
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
		}
	}

	static extern string smethod_50(Process process_0);

	static extern int smethod_51(Process process_0);

	static extern string smethod_52(Process process_0);

	static extern Process smethod_53();

	static extern ProcessStartInfo smethod_54(Process process_0);

	static void smethod_55(ProcessStartInfo processStartInfo_0, string string_5)
	{
		//Discarded unreachable code: IL_0005, IL_000a
		_ = ((double[])/*Error near IL_0004: Stack underflow*/)[/*Error near IL_0004: Stack underflow*/];
		/*Error near IL_0004: Unknown opcode: 0xFC*/;
	}

	static void smethod_56(ProcessStartInfo processStartInfo_0, bool bool_7)
	{
		//Discarded unreachable code: IL_0008, IL_000c
		checked
		{
			_ = (nuint)/*Error near IL_0002: Stack underflow*/;
			/*Error near IL_0003: Invalid metadata token*/;
		}
	}

	static void smethod_57(ProcessStartInfo processStartInfo_0, string string_5)
	{
		//Discarded unreachable code: IL_0007, IL_000c, IL_0010
		//IL_0013: Expected I4, but got O
		while (true)
		{
		}
	}

	static bool smethod_58(Process process_0)
	{
		//Discarded unreachable code: IL_0005, IL_0011, IL_0019, IL_0021
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		/*Error: Invalid metadata token*/;
	}

	static extern void smethod_59(Point point_0);

	static extern DialogResult smethod_60(string string_5, string string_6, MessageBoxButtons messageBoxButtons_0, MessageBoxIcon messageBoxIcon_0);

	static extern SpeechSynthesizer smethod_61();

	static void smethod_62(SpeechSynthesizer speechSynthesizer_0)
	{
		((sbyte[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/] = (sbyte)/*Error near IL_0001: Stack underflow*/;
		switch (/*Error near IL_0006: Stack underflow*/)
		{
		default:
			;
			break;
		}
		/*Error: Unexpected end of block*/;
	}

	static void smethod_63(SpeechSynthesizer speechSynthesizer_0, string string_5)
	{
		//Discarded unreachable code: IL_000e, IL_0017, IL_001e, IL_0024, IL_002d, IL_0034
		//IL_0004: Incompatible stack heights: 0 vs 1
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Invalid comparison between Unknown and F4
		//IL_0019: Expected F4, but got I8
		//IL_0028: Incompatible stack heights: 0 vs 1
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		do
		{
			_ = ((sbyte[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/];
		}
		while (0 <= 2);
		/*Error near IL_0009: Invalid metadata token*/;
	}

	static extern void smethod_64(IDisposable idisposable_0);

	static extern Process smethod_65(int int_8);

	static extern FileStream smethod_66(string string_5, FileMode fileMode_0);

	static extern long smethod_67(Stream stream_0);

	static extern int smethod_68(Stream stream_0, byte[] byte_0, int int_8, int int_9);

	static string smethod_69(Exception exception_0)
	{
		//Discarded unreachable code: IL_0005, IL_0007, IL_000c, IL_0014
		//IL_0018: Expected O, but got F8
		/*Error: Invalid metadata token*/;
	}

	static extern Random smethod_70();

	static extern int smethod_71(Random random_0, int int_8, int int_9);

	static extern string smethod_72(object object_0, object object_1);

	static extern void smethod_73(string string_5);

	static extern string smethod_74(Control control_0);

	static extern bool smethod_75(string string_5);

	static extern string smethod_76();

	static extern void smethod_77(TextBoxBase textBoxBase_0, string string_5);

	static extern void smethod_78(Control control_0, string string_5);

	static extern DirectoryInfo smethod_79(string string_5);

	static extern string smethod_80(object object_0);

	static extern Thread smethod_81(ThreadStart threadStart_0);

	static extern void smethod_82(Thread thread_0, ApartmentState apartmentState_0);

	static extern void smethod_83(Thread thread_0);

	static extern void smethod_84(Thread thread_0);

	static extern bool smethod_85(string string_5);

	static extern void smethod_86(int int_8);

	static extern int smethod_87(string string_5, string string_6);

	static extern int smethod_88(string string_5);

	static string smethod_89(string string_5, int int_8, int int_9)
	{
		while (true)
		{
			if (/*Error near IL_0006: Stack underflow*/ <= /*Error near IL_0006: Stack underflow*/)
			{
				checked
				{
					_ = (ushort)/*Error near IL_0007: Stack underflow*/;
					/*Error near IL_0007: stloc 0 (out-of-bounds)*/;
				}
				if ((ushort)((short[])/*Error near IL_000a: Stack underflow*/)[/*Error near IL_000a: Stack underflow*/] == 0)
				{
					break;
				}
			}
		}
		_003F val = /*Error near IL_0010: ldloc 1 (out-of-bounds)*/;
		_ = ((sbyte[])/*Error near IL_0013: Stack underflow*/)[val];
		/*Error: Unexpected end of block*/;
	}

	static extern void smethod_90(Control control_0);

	static void smethod_91(Control control_0)
	{
		//Discarded unreachable code: IL_0001
		/*Error: Unknown opcode: 0xFA*/;
	}
}
