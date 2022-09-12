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

		static extern string smethod_1(TextDataFormat textDataFormat_0);
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

	public extern GForm3();

	private extern void method_4(object sender, FormClosingEventArgs e);

	private extern void method_5(object sender, EventArgs e);

	private extern void method_6(object sender, EventArgs e);

	private extern void method_7();

	[SecurityPermission(SecurityAction.Demand, ControlThread = true)]
	private void method_8(byte[] byte_0)
	{
		//Discarded unreachable code: IL_0008
		//IL_000b: Expected I4, but got Unknown
		((float[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/] = (float)/*Error near IL_0001: Stack underflow*/;
		_ = ((int[])/*Error near IL_0002: Stack underflow*/)[/*Error near IL_0002: Stack underflow*/];
		/*Error near IL_0003: Invalid metadata token*/;
	}

	private void method_9()
	{
		//Discarded unreachable code: IL_0005, IL_000a, IL_0011
		//IL_000c: Invalid comparison between Unknown and I4
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		/*Error: Invalid metadata token*/;
	}

	private void method_10()
	{
		/*Error: Invalid metadata token*/;
	}

	private void method_11()
	{
		while (/*Error near IL_0005: Stack underflow*/ != /*Error near IL_0005: Stack underflow*/)
		{
		}
		_ = ((Array)/*Error near IL_0006: Stack underflow*/).LongLength;
		/*Error: Unexpected end of block*/;
	}

	private void method_12()
	{
	}

	private extern void method_13();

	private unsafe void method_14(string string_5)
	{
		//Discarded unreachable code: IL_0008, IL_0011
		//IL_0004: Expected O, but got F4
		_ = *(float*)(nint)/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0003: Invalid metadata token*/;
	}

	private extern void method_15(string string_5);

	private extern void method_16(string string_5);

	private extern void method_17(string string_5);

	private extern void method_18(string string_5);

	private void method_19(string string_5)
	{
		//Discarded unreachable code: IL_0008, IL_000f, IL_0015, IL_001b, IL_002b
		//IL_000a: Invalid comparison between Unknown and I4
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got I4
		short num = checked((short)/*Error near IL_0001: Stack underflow*/);
		_ = ((double[])/*Error near IL_0003: Stack underflow*/)[num];
		/*Error near IL_0003: Invalid metadata token*/;
	}

	private extern void method_20(string string_5);

	private extern void method_21(string string_5);

	private extern void method_22(string string_5);

	private extern void method_23(string string_5);

	private void method_24(string string_5)
	{
		//Discarded unreachable code: IL_0006, IL_0013, IL_001a
		//IL_000e: Invalid comparison between Unknown and I4
		//IL_0015: Invalid comparison between Unknown and I4
		//IL_001c: Expected F4, but got I
		_ = (uint)/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0001: Invalid metadata token*/;
	}

	private extern void method_25(string string_5);

	private void method_26()
	{
		//Discarded unreachable code: IL_0007, IL_000d, IL_001c, IL_0022, IL_0026, IL_002e, IL_0034
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unsupported input type for neg.
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Invalid comparison between Unknown and I8
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		/*Error: stloc 0 (out-of-bounds)*/;
		/*Error near IL_0002: Invalid metadata token*/;
	}

	private extern void method_27();

	private extern void method_28();

	private extern void method_29();

	private extern void method_30();

	private extern void method_31();

	private void method_32()
	{
		//Discarded unreachable code: IL_000b, IL_0011, IL_0017, IL_001c, IL_002c, IL_0031
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		while ((int)/*Error near IL_0006: Stack underflow*/ != 0)
		{
		}
		checked
		{
			_ = (int)/*Error near IL_0009: Stack underflow*/;
			/*Error near IL_0009: stloc 1 (out-of-bounds)*/;
			/*Error near IL_000a: Unknown opcode: 0xFA*/;
		}
	}

	private void method_33()
	{
		//Discarded unreachable code: IL_0006, IL_0015
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
		}
	}

	private extern void method_34();

	private extern void method_35();

	private void method_36()
	{
		//Discarded unreachable code: IL_0006, IL_000b, IL_0011, IL_0016
		//IL_000c: Invalid comparison between Unknown and I4
		checked
		{
			_ = (byte)/*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Invalid metadata token*/;
		}
	}

	private extern void method_37();

	private extern void method_38();

	private void method_39()
	{
		//Discarded unreachable code: IL_000c, IL_0018, IL_001e, IL_0028
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = (sbyte)(/*Error near IL_0006: Stack underflow*/ + /*Error near IL_0006: Stack underflow*/);
			/*Error near IL_0007: Invalid metadata token*/;
		}
	}

	private extern void method_40();

	private extern void method_41();

	private void method_42()
	{
		//Discarded unreachable code: IL_0014, IL_001c, IL_0022, IL_0028, IL_002a
		//IL_0002: Invalid comparison between Unknown and I4
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		while ((int)/*Error near IL_0007: Stack underflow*/ > 5)
		{
		}
		this = (GForm3)/*Error near IL_0009: Stack underflow*/;
		double num = ((double[])/*Error near IL_000b: Stack underflow*/)[/*Error near IL_000b: Stack underflow*/];
		_003F val = /*Error near IL_000c: Stack underflow*/% num;
		checked
		{
			_ = (ulong)(/*Error near IL_000d: Stack underflow*/ ^ val);
			/*Error near IL_000f: Invalid metadata token*/;
		}
	}

	private unsafe string method_43(string string_5, string string_6, string string_7)
	{
		//Discarded unreachable code: IL_000b, IL_0010, IL_0018, IL_001e, IL_0027, IL_002e, IL_003f
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Expected O, but got F8
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0033: Expected F4, but got O
		//IL_0035: Expected O, but got I4
		_003F val = ~/*Error near IL_0001: Stack underflow*/;
		_003F val2 = /*Error near IL_0002: Stack underflow*/* val;
		*(object*)(nint)/*Error near IL_0004: Stack underflow*/ = (double)val2;
		_003F val3 = /*Error near IL_0005: Stack underflow*/- /*Error near IL_0005: Stack underflow*/;
		*(_003F*)(nint)/*Error near IL_0006: Stack underflow*/ = val3;
		/*Error near IL_0006: Invalid metadata token*/;
	}

	unsafe void Form.Dispose(bool disposing)
	{
		//Discarded unreachable code: IL_0005, IL_000a
		//IL_0013: Expected F4, but got O
		*(_003F*)(nint)/*Error near IL_0001: Stack underflow*/ = /*Error near IL_0001: Stack underflow*/;
		*(_003F*)(nint)/*Error near IL_0002: Stack underflow*/ = /*Error near IL_0002: Stack underflow*/;
		checked
		{
			_ = (uint)/*Error near IL_0004: Stack underflow*/;
			/*Error near IL_0004: Unknown opcode: 0xFF*/;
		}
	}

	private extern void method_44();

	[CompilerGenerated]
	private extern void method_45();

	static extern RegistryKey smethod_0(RegistryKey registryKey_0, string string_5, bool bool_7);

	static extern string smethod_1();

	static extern string smethod_2(string string_5);

	static extern void smethod_3(RegistryKey registryKey_0, string string_5, bool bool_7);

	static bool smethod_4(string string_5, string string_6)
	{
		//Discarded unreachable code: IL_0006, IL_000b, IL_0011
		while (true)
		{
		}
	}

	static extern void smethod_5(RegistryKey registryKey_0, string string_5, object object_0);

	static extern void smethod_6(string string_5, string string_6, bool bool_7);

	static Process smethod_7(string string_5)
	{
		/*Error: Unexpected end of block*/;
	}

	static extern Process smethod_8();

	static extern void smethod_9(Process process_0);

	static extern RegistryKey smethod_10(RegistryHive registryHive_0, RegistryView registryView_0);

	static extern RegistryKey smethod_11(RegistryKey registryKey_0, string string_5);

	static extern object smethod_12(RegistryKey registryKey_0, string string_5);

	static short smethod_13(string string_5)
	{
		_ = 3;
		/*Error near IL_0003: Invalid metadata token*/;
	}

	static bool smethod_14(string string_5, string string_6, StringComparison stringComparison_0)
	{
		//Discarded unreachable code: IL_0005, IL_000b, IL_0012, IL_001c, IL_0022, IL_0028
		//IL_0013: Unsupported input type for neg.
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Invalid comparison between I4 and Unknown
		/*Error: Invalid metadata token*/;
	}

	unsafe static string smethod_15(Environment.SpecialFolder specialFolder_0)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Invalid comparison between I4 and Unknown
		while (true)
		{
			if ((int)/*Error near IL_0005: Stack underflow*/ == 0)
			{
				continue;
			}
			*(_003F*)(nint)/*Error near IL_0006: Stack underflow*/ = /*Error near IL_0006: Stack underflow*/;
			if (/*Error near IL_000b: Stack underflow*/ < /*Error near IL_000b: Stack underflow*/)
			{
				continue;
			}
			_003F val = /*Error near IL_000c: Stack underflow*/* /*Error near IL_000c: Stack underflow*/;
			if (/*Error near IL_0011: Stack underflow*/ != val)
			{
				((long[])/*Error near IL_0013: Stack underflow*/)[/*Error near IL_0013: Stack underflow*/] = (long)/*Error near IL_0013: Stack underflow*/;
				if ((int)(sbyte)/*Error near IL_0016: Stack underflow*/ > (int)/*Error near IL_0016: ldloc 2 (out-of-bounds)*/)
				{
					/*Error: Could not find block for branch target IL_001c*/;
				}
			}
		}
	}

	static extern AppDomain smethod_16();

	static extern string smethod_17(AppDomain appDomain_0);

	static extern string smethod_18(string string_5, string string_6, string string_7);

	static string smethod_19(string string_5, string string_6)
	{
		//Discarded unreachable code: IL_0005, IL_000c, IL_0016, IL_001d, IL_0023, IL_002d
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected native int or pointer, but got O
		//IL_0012: Expected F4, but got I4
		//IL_0014: Expected I4, but got I8
		//IL_0027: Expected native int or pointer, but got O
		//IL_0033: Expected O, but got I4
		/*Error: Invalid metadata token*/;
	}

	static extern CloseReason smethod_20(FormClosingEventArgs formClosingEventArgs_0);

	static extern void smethod_21(CancelEventArgs cancelEventArgs_0, bool bool_7);

	static extern IAsyncResult smethod_22(Control control_0, Delegate delegate_0);

	static extern void smethod_23(string string_5);

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

	static byte[] smethod_25(Encoding encoding_0, string string_5)
	{
		//Discarded unreachable code: IL_0006, IL_0014, IL_001a
		//IL_0006: Unsupported input type for neg.
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		/*Error: ldloc 3 (out-of-bounds)*/;
		/*Error near IL_0001: Invalid metadata token*/;
	}

	static int smethod_26(string string_5, char char_0)
	{
		//Discarded unreachable code: IL_0001
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Expected I8, but got Unknown
		/*Error: Unknown opcode: 0xFB*/;
	}

	static extern string smethod_27(string string_5, int int_8);

	static extern void smethod_28(string string_5, byte[] byte_0);

	static extern bool smethod_29(string string_5, string string_6);

	static string smethod_30()
	{
		//Discarded unreachable code: IL_000b, IL_000c, IL_0016, IL_001c, IL_0021, IL_0022, IL_002b, IL_0032, IL_003b
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected I4, but got Unknown
		//IL_002d: Invalid comparison between Unknown and F8
		while (/*Error near IL_0005: Stack underflow*/ <= /*Error near IL_0005: Stack underflow*/)
		{
		}
		/*Error near IL_0006: Invalid metadata token*/;
	}

	static string smethod_31(string string_5)
	{
		//Discarded unreachable code: IL_0005, IL_000a, IL_000b, IL_0014, IL_001b, IL_0024
		//IL_000f: Expected I4, but got Unknown
		//IL_0016: Invalid comparison between Unknown and F8
		/*Error: Invalid metadata token*/;
	}

	static extern DirectoryInfo smethod_32(string string_5);

	static extern DirectoryInfo[] smethod_33(DirectoryInfo directoryInfo_0);

	static extern string smethod_34(FileSystemInfo fileSystemInfo_0);

	static extern DateTime smethod_35(FileSystemInfo fileSystemInfo_0);

	static extern string smethod_36(object[] object_0);

	static FileInfo[] smethod_37(DirectoryInfo directoryInfo_0)
	{
		/*Error: Invalid metadata token*/;
	}

	static extern string smethod_38(FileSystemInfo fileSystemInfo_0);

	static extern string smethod_39(string string_5);

	static extern string smethod_40(Encoding encoding_0, byte[] byte_0);

	static extern bool smethod_41(string string_5, string string_6);

	static extern string smethod_42(string string_5, string string_6, string string_7);

	unsafe static void smethod_43(int int_8)
	{
		//Discarded unreachable code: IL_000b, IL_0010, IL_001b, IL_0022, IL_0027
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected I4, but got Unknown
		//IL_0016: Invalid comparison between Unknown and I4
		_ = *(byte*)checked((short)(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/));
		/*Error near IL_0006: Invalid metadata token*/;
	}

	static extern void smethod_44();

	static extern bool smethod_45(Control control_0);

	static extern void smethod_46(Control control_0);

	static extern void smethod_47();

	static extern void smethod_48(Control control_0);

	static extern Process[] smethod_49();

	static extern string smethod_50(Process process_0);

	static extern int smethod_51(Process process_0);

	static extern string smethod_52(Process process_0);

	static extern Process smethod_53();

	static extern ProcessStartInfo smethod_54(Process process_0);

	unsafe static void smethod_55(ProcessStartInfo processStartInfo_0, string string_5)
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

	static extern void smethod_56(ProcessStartInfo processStartInfo_0, bool bool_7);

	static extern void smethod_57(ProcessStartInfo processStartInfo_0, string string_5);

	static extern bool smethod_58(Process process_0);

	static extern void smethod_59(Point point_0);

	static extern DialogResult smethod_60(string string_5, string string_6, MessageBoxButtons messageBoxButtons_0, MessageBoxIcon messageBoxIcon_0);

	static extern SpeechSynthesizer smethod_61();

	static extern void smethod_62(SpeechSynthesizer speechSynthesizer_0);

	static extern void smethod_63(SpeechSynthesizer speechSynthesizer_0, string string_5);

	static extern void smethod_64(IDisposable idisposable_0);

	static extern Process smethod_65(int int_8);

	static extern FileStream smethod_66(string string_5, FileMode fileMode_0);

	static extern long smethod_67(Stream stream_0);

	static extern int smethod_68(Stream stream_0, byte[] byte_0, int int_8, int int_9);

	static extern string smethod_69(Exception exception_0);

	unsafe static Random smethod_70()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected I, but got Unknown
		while (true)
		{
			if (/*Error near IL_0005: Stack underflow*/ <= /*Error near IL_0005: Stack underflow*/)
			{
				continue;
			}
			*(_003F*)(nint)/*Error near IL_0008: Stack underflow*/ = /*Error near IL_0008: Stack underflow*/;
			if (/*Error near IL_000d: Stack underflow*/ != /*Error near IL_000d: Stack underflow*/)
			{
				byte num = ((byte[])/*Error near IL_000f: Stack underflow*/)[/*Error near IL_000f: Stack underflow*/];
				_003F val = checked(/*Error near IL_0011: Stack underflow*/ * num);
				*(IntPtr*)(nint)/*Error near IL_0012: Stack underflow*/ = (IntPtr)val;
				if (/*Error near IL_0017: Stack underflow*/ > /*Error near IL_0017: Stack underflow*/)
				{
					/*Error: Could not find block for branch target IL_0017*/;
				}
			}
		}
	}

	static extern int smethod_71(Random random_0, int int_8, int int_9);

	static extern string smethod_72(object object_0, object object_1);

	static void smethod_73(string string_5)
	{
		//Discarded unreachable code: IL_0007, IL_000c, IL_000e
		//IL_0003: Expected O, but got I4
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		_ = (short)checked((uint)/*Error near IL_0001: Stack underflow*/);
		/*Error near IL_0002: Invalid metadata token*/;
	}

	static extern string smethod_74(Control control_0);

	static bool smethod_75(string string_5)
	{
		/*Error: Invalid metadata token*/;
	}

	static extern string smethod_76();

	static extern void smethod_77(TextBoxBase textBoxBase_0, string string_5);

	static extern void smethod_78(Control control_0, string string_5);

	static extern DirectoryInfo smethod_79(string string_5);

	static extern string smethod_80(object object_0);

	unsafe static Thread smethod_81(ThreadStart threadStart_0)
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

	unsafe static void smethod_82(Thread thread_0, ApartmentState apartmentState_0)
	{
		//Discarded unreachable code: IL_000d, IL_0012, IL_0027, IL_002c, IL_0033, IL_0038, IL_003d, IL_0044
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Invalid comparison between I4 and F8
		//IL_002d: Incompatible stack heights: 0 vs 1
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			_003F val = /*Error: ldloc 0 (out-of-bounds)*/;
			if (/*Error near IL_0003: Stack underflow*/ > val)
			{
				break;
			}
			if (/*Error near IL_0008: Stack underflow*/ >= /*Error near IL_0008: Stack underflow*/)
			{
				((IntPtr[])/*Error near IL_000b: Stack underflow*/)[/*Error near IL_000b: Stack underflow*/] = (IntPtr)/*Error near IL_000b: Stack underflow*/;
				_ = /*Error near IL_000c: Stack underflow*/& /*Error near IL_000c: Stack underflow*/;
				/*Error near IL_000c: Unknown opcode: 0xFC*/;
			}
		}
		_003F val2 = /*Error near IL_002f: Stack underflow*/<< (int)/*Error near IL_002f: Stack underflow*/;
		long num = ((long[])/*Error near IL_0030: Stack underflow*/)[val2];
		_ = *(short*)(nint)checked(/*Error near IL_0031: Stack underflow*/ * num);
		/*Error near IL_0032: Unknown opcode: 0xFD*/;
	}

	static extern void smethod_83(Thread thread_0);

	static void smethod_84(Thread thread_0)
	{
		//IL_000e: Invalid comparison between I4 and F8
		checked
		{
			do
			{
				short num = (short)/*Error near IL_0001: Stack underflow*/;
				((int[])/*Error near IL_0002: Stack underflow*/)[/*Error near IL_0002: Stack underflow*/] = num;
			}
			while ((double)(short)/*Error near IL_0003: Stack underflow*/ > 4.059658204116225E+87);
			/*Error near IL_0013: Invalid metadata token*/;
		}
	}

	static extern bool smethod_85(string string_5);

	static extern void smethod_86(int int_8);

	static extern int smethod_87(string string_5, string string_6);

	static extern int smethod_88(string string_5);

	static extern string smethod_89(string string_5, int int_8, int int_9);

	static extern void smethod_90(Control control_0);

	static void smethod_91(Control control_0)
	{
		//Discarded unreachable code: IL_0010, IL_001b, IL_0020, IL_0025
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected native int or pointer, but got O
		while (/*Error near IL_0005: Stack underflow*/ <= /*Error near IL_0005: Stack underflow*/)
		{
		}
		byte num;
		checked
		{
			num = (byte)unchecked((uint)((int[])/*Error near IL_0006: Stack underflow*/)[/*Error near IL_0006: Stack underflow*/]);
		}
		_ = /*Error near IL_000b: Stack underflow*/>> num + 1;
		/*Error near IL_000b: Invalid metadata token*/;
	}
}
