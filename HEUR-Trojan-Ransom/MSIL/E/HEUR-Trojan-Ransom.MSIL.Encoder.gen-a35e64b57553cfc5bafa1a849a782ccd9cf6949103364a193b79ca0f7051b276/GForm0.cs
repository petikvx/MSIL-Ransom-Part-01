using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.VisualBasic.MyServices;

[DesignerGenerated]
public class GForm0 : Form
{
	private IContainer icontainer_0;

	[AccessedThroughProperty("Panel1")]
	private Panel panel_0;

	[AccessedThroughProperty("Panel2")]
	private Panel panel_1;

	[AccessedThroughProperty("Label1")]
	private Label label_0;

	[AccessedThroughProperty("Label2")]
	private Label label_1;

	[AccessedThroughProperty("RichTextBox2")]
	private RichTextBox richTextBox_0;

	[AccessedThroughProperty("Label3")]
	private Label label_2;

	[AccessedThroughProperty("TextBox1")]
	private TextBox textBox_0;

	[AccessedThroughProperty("Label10")]
	private Label label_3;

	[AccessedThroughProperty("Label8")]
	private Label label_4;

	[AccessedThroughProperty("Label4")]
	private Label label_5;

	[AccessedThroughProperty("PictureBox1")]
	private PictureBox pictureBox_0;

	private string string_0;

	private string[] string_1;

	private string string_2;

	private string string_3;

	private string string_4;

	private string string_5;

	private string string_6;

	private string string_7;

	private const string string_8 = "abccba";

	private RichTextBox richTextBox_1;

	private const int int_0 = 64;

	private const int int_1 = 128;

	private bool bool_0;

	private Class11 class11_0;

	private object object_0;

	private string string_9;

	private string string_10;

	private string string_11;

	private Random random_0;

	private const int int_2 = 20;

	private const int int_3 = 1;

	private int int_4;

	private int int_5;

	private bool bool_1;

	internal virtual extern Panel Panel_0
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Panel Panel_1
	{
		get
		{
			//Discarded unreachable code: IL_0009, IL_0018, IL_0021, IL_002a
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_0025: Incompatible stack heights: 0 vs 1
			while (true)
			{
				/*Error: stloc 2 (out-of-bounds)*/;
				((float[])/*Error near IL_0002: Stack underflow*/)[/*Error near IL_0002: Stack underflow*/] = (float)/*Error near IL_0002: Stack underflow*/;
				nint num = checked((nint)/*Error near IL_0003: Stack underflow*/);
				((IntPtr[])/*Error near IL_0004: Stack underflow*/)[/*Error near IL_0004: Stack underflow*/] = num;
			}
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual extern Label Label_0
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal unsafe virtual Label Label_1
	{
		get
		{
			//Discarded unreachable code: IL_0008, IL_0010
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000c: Expected O, but got Unknown
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected I, but got O
			//IL_0020: Unknown result type (might be due to invalid IL or missing references)
			//IL_0028: Expected F4, but got Unknown
			//IL_003a: Expected I4, but got I8
			sbyte num = *(sbyte*)(nint)/*Error near IL_0001: Stack underflow*/;
			*(sbyte*)(nint)/*Error near IL_0003: Stack underflow*/ = num;
			/*Error near IL_0003: Invalid metadata token*/;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			_ = /*Error near IL_0001: Stack underflow*/<< (int)/*Error near IL_0001: Stack underflow*/;
			/*Error: Unexpected end of block*/;
		}
	}

	internal virtual RichTextBox RichTextBox_0
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			//Discarded unreachable code: IL_001a, IL_0024, IL_002c, IL_0035
			//IL_0003: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Invalid comparison between Unknown and O
			//IL_001b: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Unknown result type (might be due to invalid IL or missing references)
			//IL_002e: Expected native int or pointer, but got F8
			//IL_0035: Unknown result type (might be due to invalid IL or missing references)
			//IL_0037: Expected I8, but got Unknown
			//IL_0039: Unknown result type (might be due to invalid IL or missing references)
			//IL_003c: Expected O, but got Unknown
			while (true)
			{
				long num = checked((long)/*Error near IL_0002: Stack underflow*/);
				if (/*Error near IL_0004: Stack underflow*/ >> (int)num != 0 && /*Error near IL_000e: Stack underflow*/!= /*Error near IL_000e: Stack underflow*/)
				{
					object obj = ((object[])/*Error near IL_0010: Stack underflow*/)[1];
					if (/*Error near IL_0015: Stack underflow*/ <= obj)
					{
					}
				}
			}
		}
	}

	internal virtual extern Label Label_2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual TextBox TextBox_0
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			//Discarded unreachable code: IL_000f
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_001e: Expected native int or pointer, but got F4
			checked
			{
				do
				{
					_ = /*Error near IL_0002: Stack underflow*/- /*Error near IL_0002: Stack underflow*/;
				}
				while (4u != 0);
				int num = (int)/*Error near IL_000a: ldloc 2 (out-of-bounds)*/;
				_ = ((object[])/*Error near IL_000e: Stack underflow*/)[num];
				/*Error near IL_000e: Unknown opcode: 0xF8*/;
			}
		}
	}

	internal virtual extern Label Label_3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Label Label_4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			throw /*Error near IL_0002: Stack underflow*/;
		}
	}

	internal virtual Label Label_5
	{
		get
		{
			//Discarded unreachable code: IL_0015, IL_0016, IL_001b, IL_001c, IL_0024, IL_0025, IL_002f
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_001e: Expected O, but got I4
			//IL_0022: Invalid comparison between Unknown and I
			//IL_0022: Incompatible stack heights: 1 vs 0
			//IL_0025: Unknown result type (might be due to invalid IL or missing references)
			//IL_0028: Expected O, but got Unknown
			//IL_002a: Incompatible stack heights: 0 vs 1
			while ((int)/*Error near IL_0006: Stack underflow*/ != 0)
			{
			}
			_003F val = /*Error near IL_0007: Stack underflow*/^ /*Error near IL_0007: Stack underflow*/;
			_ = /*Error near IL_0008: Stack underflow*/+ val;
			_ = 7;
			checked
			{
				_ = (ulong)(nuint)(-3.7968525E+33f);
				/*Error near IL_0010: Invalid metadata token*/;
			}
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual extern PictureBox PictureBox_0
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public extern GForm0();

	[DebuggerNonUserCode]
	extern void Form.Dispose(bool disposing);

	[DebuggerStepThrough]
	private extern void method_0();

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int SystemParametersInfoA(int int_6, int int_7, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_12, int int_8);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int SetWindowPos(int int_6, int int_7, int int_8, int int_9, int int_10, int int_11, int int_12);

	private extern void method_1();

	public extern void method_2(string string_12);

	[MethodImpl(MethodImplOptions.NoOptimization)]
	public extern void method_3();

	public extern void method_4(string string_12, string string_13);

	public extern void method_5(string string_12, string string_13);

	public extern byte[] method_6(byte[] byte_0, byte[] byte_1);

	public extern void method_7(string string_12, string string_13);

	private extern void method_8(string string_12);

	private extern void method_9();

	private extern void method_10();

	public extern void method_11();

	public extern void method_12();

	private extern void method_13();

	private extern void method_14(object sender, MouseEventArgs e);

	private void method_15(object sender, MouseEventArgs e)
	{
		//Discarded unreachable code: IL_0007, IL_000c
		//IL_0003: Expected O, but got Unknown
		//IL_0013: Expected O, but got Unknown
		/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0002: Invalid metadata token*/;
	}

	private extern void method_16(object sender, MouseEventArgs e);

	public extern string method_17(int int_6);

	public extern void method_18();

	public extern void method_19();

	private extern void method_20(object sender, EventArgs e);

	private unsafe void method_21(object sender, EventArgs e)
	{
		//Discarded unreachable code: IL_000b, IL_0012, IL_0013, IL_001c, IL_0021
		//IL_0024: Invalid comparison between Unknown and F8
		do
		{
			*(_003F*)(nint)/*Error near IL_0001: Stack underflow*/ = /*Error near IL_0001: Stack underflow*/;
		}
		while (/*Error near IL_0006: Stack underflow*/ >= /*Error near IL_0006: Stack underflow*/);
		/*Error near IL_0006: Invalid metadata token*/;
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	private extern void method_22(object sender, FormClosingEventArgs e);

	private extern void method_23();

	private extern void method_24();

	private extern void method_25(object sender, EventArgs e);

	static extern void smethod_0(Form form_0, FormClosingEventHandler formClosingEventHandler_0);

	static extern void smethod_1(Form form_0, EventHandler eventHandler_0);

	static RichTextBox smethod_2()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = (ushort)unchecked(/*Error near IL_0001: Stack underflow*/ % /*Error near IL_0001: Stack underflow*/);
			/*Error near IL_0004: Invalid metadata token*/;
		}
	}

	static extern string smethod_3();

	static extern string smethod_4();

	static string smethod_5(string string_12)
	{
		//Discarded unreachable code: IL_0005
		//IL_0008: Expected native int or pointer, but got F4
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		/*Error: Invalid metadata token*/;
	}

	static extern void smethod_6(IDisposable idisposable_0);

	static extern Type smethod_7(RuntimeTypeHandle runtimeTypeHandle_0);

	unsafe static ComponentResourceManager smethod_8(Type type_0)
	{
		//Discarded unreachable code: IL_000e, IL_0013, IL_001d
		//IL_0004: Incompatible stack heights: 0 vs 1
		do
		{
			_ = *(byte*)(nint)/*Error near IL_0001: Stack underflow*/;
		}
		while ((nuint)2u != 0);
		/*Error near IL_0009: Invalid metadata token*/;
	}

	static extern Panel smethod_9();

	static extern Label smethod_10();

	static extern TextBox smethod_11();

	static extern PictureBox smethod_12();

	unsafe static void smethod_13(Control control_0)
	{
		//IL_0003: Invalid comparison between Unknown and I4
		//IL_0009: Invalid comparison between Unknown and I4
		//IL_001d: Expected O, but got I
		//IL_001d: Invalid comparison between Unknown and I
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			if ((int)/*Error near IL_0008: Stack underflow*/ <= 7)
			{
				continue;
			}
			ushort num = (ushort)/*Error near IL_0009: Stack underflow*/;
			if ((int)/*Error near IL_000e: Stack underflow*/ > (int)num && /*Error near IL_0013: Stack underflow*/< /*Error near IL_0013: Stack underflow*/)
			{
				long num2;
				checked
				{
					num2 = unchecked((long)(int)checked((byte)/*Error near IL_0014: Stack underflow*/)) + unchecked((long)(int)(uint.MaxValue >> (int)(&control_0)));
				}
				IntPtr intPtr = (nint)((Array)(nint)((IntPtr[])/*Error near IL_001c: Stack underflow*/)[num2]).LongLength;
				if ((nint)/*Error near IL_0022: Stack underflow*/ < (nint)intPtr && /*Error near IL_0028: Stack underflow*/<= /*Error near IL_0028: Stack underflow*/)
				{
					break;
				}
			}
		}
		((float[])/*Error near IL_0029: Stack underflow*/)[/*Error near IL_0029: Stack underflow*/] = (float)/*Error near IL_0029: Stack underflow*/;
		checked
		{
			_ = /*Error near IL_002a: Stack underflow*/- /*Error near IL_002a: Stack underflow*/;
			/*Error near IL_002a: Invalid metadata token*/;
		}
	}

	static extern void smethod_14(ISupportInitialize isupportInitialize_0);

	static extern object smethod_15(ResourceManager resourceManager_0, string string_12);

	static extern void smethod_16(Control control_0, Image image_0);

	static extern void smethod_17(Control control_0, ImageLayout imageLayout_0);

	static extern ControlCollection smethod_18(Control control_0);

	static extern void smethod_19(ControlCollection controlCollection_0, Control control_0);

	static extern void smethod_20(Control control_0, DockStyle dockStyle_0);

	static extern void smethod_21(Control control_0, Point point_0);

	static extern void smethod_22(Control control_0, string string_12);

	static extern void smethod_23(Control control_0, Size size_0);

	static extern void smethod_24(Control control_0, int int_6);

	static void smethod_25(Control control_0, Color color_0)
	{
		//Discarded unreachable code: IL_0008
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		_ = (ulong)(/*Error near IL_0002: Stack underflow*/ / /*Error near IL_0002: Stack underflow*/);
		/*Error near IL_0007: Unknown opcode: 0xFC*/;
	}

	static extern void smethod_26(Label label_6, Image image_0);

	static extern void smethod_27(TextBoxBase textBoxBase_0, Color color_0);

	static extern void smethod_28(TextBoxBase textBoxBase_0, BorderStyle borderStyle_0);

	static extern Font smethod_29(string string_12, float float_0, FontStyle fontStyle_0, GraphicsUnit graphicsUnit_0, byte byte_0);

	static extern void smethod_30(RichTextBox richTextBox_2, Font font_0);

	static extern void smethod_31(RichTextBox richTextBox_2, Color color_0);

	static extern void smethod_32(TextBoxBase textBoxBase_0, bool bool_2);

	static string smethod_33(ResourceManager resourceManager_0, string string_12)
	{
		//Discarded unreachable code: IL_001b, IL_001c, IL_0023, IL_002a, IL_002f, IL_0031
		//IL_0007: Incompatible stack heights: 0 vs 1
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			_ = ((IntPtr[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/];
			if ((nuint)checked((nint)unchecked((nuint)null)) > unchecked((nuint)(-92)))
			{
				nint num = (nint)/*Error near IL_000f: Stack underflow*/;
				_003F val = /*Error near IL_0010: Stack underflow*/^ num;
				if (/*Error near IL_0015: Stack underflow*/ > val)
				{
					break;
				}
			}
		}
		checked
		{
			_ = (nint)/*Error near IL_0016: Stack underflow*/;
			/*Error near IL_0016: Invalid metadata token*/;
		}
	}

	static extern void smethod_34(RichTextBox richTextBox_2, string string_12);

	static extern void smethod_35(Label label_6, bool bool_2);

	static extern void smethod_36(Control control_0, Font font_0);

	static extern void smethod_37(Control control_0, Color color_0);

	static extern void smethod_38(Label label_6, string string_12);

	static extern void smethod_39(TextBoxBase textBoxBase_0, Color color_0);

	static extern void smethod_40(TextBox textBox_1, bool bool_2);

	static Color smethod_41()
	{
		//Discarded unreachable code: IL_000b, IL_0012
		//IL_0012: Unsupported input type for neg.
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		_ = ((long[])/*Error near IL_0004: Stack underflow*/)[7];
		/*Error near IL_0005: ldloc 1 (out-of-bounds)*/;
		/*Error near IL_0006: Invalid metadata token*/;
	}

	static extern void smethod_42(PictureBox pictureBox_1, PictureBoxSizeMode pictureBoxSizeMode_0);

	static extern void smethod_43(PictureBox pictureBox_1, int int_6);

	static void smethod_44(PictureBox pictureBox_1, bool bool_2)
	{
		//Discarded unreachable code: IL_0007, IL_000e, IL_0013, IL_0018, IL_001f, IL_0026, IL_002c
		//IL_0003: Expected O, but got I4
		//IL_0021: Incompatible stack heights: 0 vs 1
		//IL_0026: Unsupported input type for neg.
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got I4
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		_ = ((ushort[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/];
		/*Error near IL_0002: Invalid metadata token*/;
	}

	static extern void smethod_45(ContainerControl containerControl_0, SizeF sizeF_0);

	static extern void smethod_46(ContainerControl containerControl_0, AutoScaleMode autoScaleMode_0);

	static void smethod_47(Form form_0, Size size_0)
	{
		//Discarded unreachable code: IL_0006, IL_000c, IL_0019, IL_0025
		while (true)
		{
		}
	}

	unsafe static void smethod_48(Form form_0, FormBorderStyle formBorderStyle_0)
	{
		//Discarded unreachable code: IL_0011, IL_0029
		while (/*Error near IL_0005: Stack underflow*/ >= /*Error near IL_0005: Stack underflow*/)
		{
		}
		checked
		{
			_ = (short)(*unchecked((nint*)((ushort[])/*Error near IL_0006: Stack underflow*/)[/*Error near IL_0006: Stack underflow*/]));
			/*Error near IL_000c: Invalid metadata token*/;
		}
	}

	static extern void smethod_49(Form form_0, string string_12);

	static extern void smethod_50(Control control_0, bool bool_2);

	static extern void smethod_51(ISupportInitialize isupportInitialize_0);

	static extern void smethod_52(Control control_0);

	static extern void smethod_53(Control control_0, MouseEventHandler mouseEventHandler_0);

	static extern void smethod_54(Control control_0, MouseEventHandler mouseEventHandler_0);

	static extern void smethod_55(Control control_0, MouseEventHandler mouseEventHandler_0);

	static extern void smethod_56(Control control_0, MouseEventHandler mouseEventHandler_0);

	static extern void smethod_57(Control control_0, MouseEventHandler mouseEventHandler_0);

	static extern void smethod_58(Control control_0, MouseEventHandler mouseEventHandler_0);

	static void smethod_59(Control control_0, EventHandler eventHandler_0)
	{
		//Discarded unreachable code: IL_0005, IL_000a, IL_000f, IL_0015, IL_0021, IL_0027, IL_002d, IL_0034, IL_0039, IL_003e, IL_0047, IL_0048
		//IL_0010: Invalid comparison between Unknown and I4
		//IL_0028: Invalid comparison between Unknown and I8
		//IL_0041: Expected O, but got I4
		/*Error: Invalid metadata token*/;
	}

	static extern void smethod_60(Control control_0, EventHandler eventHandler_0);

	static string smethod_61(Environment.SpecialFolder specialFolder_0)
	{
		//IL_0002: Invalid comparison between Unknown and I4
		while (true)
		{
			int num = checked((int)/*Error near IL_0001: Stack underflow*/);
			if ((int)/*Error near IL_0007: Stack underflow*/ <= num)
			{
				/*Error: Could not find block for branch target IL_0007*/;
			}
		}
	}

	static extern string smethod_62();

	static string smethod_63(string string_12, string string_13)
	{
		//Discarded unreachable code: IL_0006, IL_0008, IL_000d, IL_001e, IL_0025, IL_002a, IL_002d, IL_0032, IL_003c
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		_ = ((sbyte[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/];
		/*Error near IL_0001: Invalid metadata token*/;
	}

	static extern FileSystemProxy smethod_64(ServerComputer serverComputer_0);

	static FileInfo smethod_65(FileSystemProxy fileSystemProxy_0, string string_12)
	{
		while (/*Error near IL_0002: Stack underflow*/ <= /*Error near IL_0002: Stack underflow*/)
		{
		}
		/*Error near IL_0003: Invalid metadata token*/;
	}

	static extern string smethod_66();

	static extern string smethod_67(string string_12, string string_13, string string_14);

	static extern void smethod_68(string string_12, string string_13, bool bool_2);

	static extern void smethod_69(Exception exception_0);

	static extern void smethod_70();

	static extern Process smethod_71();

	static ProcessStartInfo smethod_72(string string_12)
	{
		//Discarded unreachable code: IL_0006, IL_0007, IL_0013, IL_0018, IL_0023
		//IL_000b: Expected I4, but got Unknown
		//IL_000e: Expected native int or pointer, but got F8
		/*Error near IL_0001: Invalid metadata token*/;
	}

	static extern void smethod_73(ProcessStartInfo processStartInfo_0, string string_12);

	static extern void smethod_74(ProcessStartInfo processStartInfo_0, bool bool_2);

	static extern void smethod_75(Process process_0, ProcessStartInfo processStartInfo_0);

	static extern bool smethod_76(Process process_0);

	static extern void smethod_77(int int_6, string string_12, OpenMode openMode_0, OpenAccess openAccess_0, OpenShare openShare_0, int int_7);

	static extern long smethod_78(int int_6);

	static extern string smethod_79(int int_6);

	static extern void smethod_80(int int_6, ref string string_12, long long_0, bool bool_2);

	static extern void smethod_81(int[] int_6);

	static string[] smethod_82(string string_12, string string_13, int int_6, CompareMethod compareMethod_0)
	{
		//Discarded unreachable code: IL_0006, IL_000d
		checked
		{
			_ = (nuint)/*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Invalid metadata token*/;
		}
	}

	static extern string smethod_83(Label label_6);

	static extern string smethod_84(string string_12, string string_13, string string_14);

	static extern void smethod_85(TextBox textBox_1, string string_12);

	static extern byte[] smethod_86(string string_12);

	static extern MemoryStream smethod_87(byte[] byte_0);

	static extern void smethod_88(object object_1);

	static Image smethod_89(Stream stream_0)
	{
		//Discarded unreachable code: IL_000a, IL_000f
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		_003F val = /*Error: ldarg 3 (out-of-bounds)*/;
		checked
		{
			_ = (byte)unchecked(/*Error near IL_0002: Stack underflow*/ - val);
			/*Error near IL_0005: Invalid metadata token*/;
		}
	}

	static extern void smethod_90(PictureBox pictureBox_1, Image image_0);

	unsafe static Image smethod_91(PictureBox pictureBox_1)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unsupported input type for neg.
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			if (/*Error near IL_0005: Stack underflow*/ != /*Error near IL_0005: Stack underflow*/)
			{
				/*Error near IL_0007: stloc 0 (out-of-bounds)*/;
				_003F val = /*Error near IL_000b: Stack underflow*/* /*Error near IL_000b: Stack underflow*/;
				if (/*Error near IL_0012: Stack underflow*/ > 0 - val)
				{
					break;
				}
			}
		}
		_ = *(byte*)(nint)/*Error near IL_0013: Stack underflow*/;
		/*Error: Unexpected end of block*/;
	}

	static extern void smethod_92(object object_1);

	static extern ImageFormat smethod_93();

	static extern void smethod_94(Image image_0, string string_12, ImageFormat imageFormat_0);

	static extern Thread smethod_95(ThreadStart threadStart_0, int int_6);

	static extern void smethod_96(Thread thread_0);

	unsafe static string[] smethod_97(string string_12)
	{
		while (true)
		{
			*(_003F*)(nint)/*Error near IL_0001: Stack underflow*/ = /*Error near IL_0001: Stack underflow*/;
		}
	}

	static extern string[] smethod_98(string string_12);

	static extern string smethod_99(string string_12);

	static extern bool smethod_100(string string_12, string string_13);

	static Exception smethod_101(int int_6)
	{
		//Discarded unreachable code: IL_0005, IL_0010
		//IL_000a: Expected I4, but got I8
		while (true)
		{
		}
	}

	unsafe static byte[] smethod_102(string string_12)
	{
		//Discarded unreachable code: IL_0009, IL_0010
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Expected O, but got I4
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		_ = *(ushort*)(nint)(/*Error near IL_0001: Stack underflow*/ >> (int)/*Error near IL_0001: Stack underflow*/);
		/*Error near IL_0004: Invalid metadata token*/;
	}

	unsafe static Encoding smethod_103()
	{
		//Discarded unreachable code: IL_000f
		//IL_0002: Expected F8, but got I4
		//IL_0009: Expected F8, but got I4
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected I4, but got Unknown
		do
		{
			uint num = checked((uint)/*Error near IL_0001: Stack underflow*/);
			((double[])/*Error near IL_0002: Stack underflow*/)[/*Error near IL_0002: Stack underflow*/] = (int)num;
		}
		while (/*Error near IL_0007: Stack underflow*/ > /*Error near IL_0007: Stack underflow*/);
		ushort num2 = *(ushort*)(nint)/*Error near IL_0008: Stack underflow*/;
		((double[])/*Error near IL_0009: Stack underflow*/)[/*Error near IL_0009: Stack underflow*/] = (int)num2;
		checked
		{
			_ = (short)(*unchecked((int*)(int)(*(ushort*)(nint)/*Error near IL_000a: Stack underflow*/)));
			/*Error near IL_000e: Unknown opcode: 0xF9*/;
		}
	}

	static extern byte[] smethod_104(Encoding encoding_0, string string_12);

	static extern SHA256 smethod_105();

	unsafe static byte[] smethod_106(HashAlgorithm hashAlgorithm_0, byte[] byte_0)
	{
		//Discarded unreachable code: IL_000b
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Expected F8, but got I4
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		*(*(double**)(nint)(/*Error near IL_0001: Stack underflow*/ % /*Error near IL_0001: Stack underflow*/)) = 1.0;
		_ = /*Error near IL_0006: Stack underflow*// /*Error near IL_0006: Stack underflow*/;
		/*Error near IL_0006: Invalid metadata token*/;
	}

	static extern void smethod_107(string string_12, byte[] byte_0);

	static extern void smethod_108(string string_12, string string_13);

	unsafe static MemoryStream smethod_109()
	{
		//Discarded unreachable code: IL_000c, IL_0014, IL_0019
		//IL_0007: Expected I8, but got Unknown
		//IL_0020: Incompatible stack heights: 0 vs 1
		*(long*)checked((long)/*Error near IL_0005: Stack underflow*/) = (long)/*Error near IL_0005: ldloc 2 (out-of-bounds)*/;
		/*Error near IL_0007: Invalid metadata token*/;
	}

	static extern RijndaelManaged smethod_110();

	static extern void smethod_111(SymmetricAlgorithm symmetricAlgorithm_0, int int_6);

	static extern void smethod_112(SymmetricAlgorithm symmetricAlgorithm_0, int int_6);

	static extern Rfc2898DeriveBytes smethod_113(byte[] byte_0, byte[] byte_1, int int_6);

	static extern int smethod_114(SymmetricAlgorithm symmetricAlgorithm_0);

	static extern byte[] smethod_115(Rfc2898DeriveBytes rfc2898DeriveBytes_0, int int_6);

	static extern void smethod_116(SymmetricAlgorithm symmetricAlgorithm_0, byte[] byte_0);

	static extern int smethod_117(SymmetricAlgorithm symmetricAlgorithm_0);

	static void smethod_118(SymmetricAlgorithm symmetricAlgorithm_0, byte[] byte_0)
	{
		//Discarded unreachable code: IL_0005, IL_000b
		//IL_0006: Invalid comparison between Unknown and I8
		/*Error: Invalid metadata token*/;
	}

	static extern void smethod_119(SymmetricAlgorithm symmetricAlgorithm_0, CipherMode cipherMode_0);

	static extern ICryptoTransform smethod_120(SymmetricAlgorithm symmetricAlgorithm_0);

	static extern CryptoStream smethod_121(Stream stream_0, ICryptoTransform icryptoTransform_0, CryptoStreamMode cryptoStreamMode_0);

	static void smethod_122(CryptoStream cryptoStream_0, byte[] byte_0, int int_6, int int_7)
	{
		//Discarded unreachable code: IL_0005
		//IL_0007: Expected native int or pointer, but got O
		//IL_000b: Expected I4, but got Unknown
		//IL_000a: Expected native int or pointer, but got O
		/*Error: Invalid metadata token*/;
	}

	static extern void smethod_123(Stream stream_0);

	static extern byte[] smethod_124(MemoryStream memoryStream_0);

	static extern int smethod_125(string string_12, AppWinStyle appWinStyle_0, bool bool_2, int int_6);

	static extern Process[] smethod_126();

	static string smethod_127(Process process_0)
	{
		while (true)
		{
			if ((int)/*Error near IL_0005: Stack underflow*/ == 0)
			{
				/*Error: Could not find block for branch target IL_0005*/;
			}
		}
	}

	static void smethod_128(Process process_0)
	{
		//Discarded unreachable code: IL_000c, IL_0016
		//IL_0002: Invalid comparison between Unknown and I
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got I4
		nuint num;
		do
		{
			num = checked((nuint)/*Error near IL_0001: Stack underflow*/);
		}
		while ((nint)/*Error near IL_0007: Stack underflow*/ < (nint)num);
		/*Error near IL_0007: Invalid metadata token*/;
	}

	static extern void smethod_129(ProcessStartInfo processStartInfo_0, ProcessWindowStyle processWindowStyle_0);

	static void smethod_130(ProcessStartInfo processStartInfo_0, bool bool_2)
	{
		//Discarded unreachable code: IL_0003, IL_0008, IL_0016, IL_001c, IL_0025, IL_002b, IL_002f
		//IL_0011: Invalid comparison between Unknown and F8
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		/*Error: stloc 1 (out-of-bounds)*/;
		_ = 1;
		/*Error near IL_0002: Unknown opcode: 0xFA*/;
	}

	static extern void smethod_131(ProcessStartInfo processStartInfo_0, string string_12);

	static extern Process smethod_132(ProcessStartInfo processStartInfo_0);

	static MouseButtons smethod_133(MouseEventArgs mouseEventArgs_0)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Invalid comparison between Unknown and I8
		long num;
		do
		{
			num = /*Error near IL_0001: Stack underflow*/* /*Error near IL_0001: Stack underflow*/;
		}
		while ((long)/*Error near IL_0008: Stack underflow*/ != num || /*Error near IL_000d: Stack underflow*/< /*Error near IL_000d: Stack underflow*/);
		/*Error near IL_000d: Invalid metadata token*/;
	}

	static Point smethod_134()
	{
		//Discarded unreachable code: IL_0008, IL_000e
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Expected O, but got I4
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		short num = (short)/*Error near IL_0001: Stack underflow*/;
		_ = /*Error near IL_0002: Stack underflow*/+ num;
		_ = 5;
		/*Error near IL_0003: Invalid metadata token*/;
	}

	static extern StringBuilder smethod_135();

	static extern Random smethod_136();

	static extern int smethod_137(string string_12);

	static extern int smethod_138(Random random_1, int int_6);

	static extern char smethod_139(string string_12, int int_6);

	static StringBuilder smethod_140(StringBuilder stringBuilder_0, char char_0)
	{
		//Discarded unreachable code: IL_0008, IL_000e, IL_0014, IL_001a, IL_0020, IL_0028, IL_002d, IL_002e
		//IL_0003: Expected F4, but got I4
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Invalid comparison between Unknown and I4
		while (true)
		{
			int num = checked((int)/*Error near IL_0002: Stack underflow*/);
			((float[])/*Error near IL_0003: Stack underflow*/)[/*Error near IL_0003: Stack underflow*/] = num;
		}
	}

	static string smethod_141(StringBuilder stringBuilder_0)
	{
		//Discarded unreachable code: IL_000c, IL_0011, IL_0016, IL_0017, IL_0021, IL_0026
		while (/*Error near IL_0005: Stack underflow*/ > /*Error near IL_0005: Stack underflow*/)
		{
		}
		checked
		{
			_ = (uint)/*Error near IL_0006: Stack underflow*/;
			/*Error near IL_0007: Invalid metadata token*/;
		}
	}

	static extern string[] smethod_142(TextBoxBase textBoxBase_0);

	static extern void smethod_143(string string_12, string[] string_13);

	static extern int smethod_144(Random random_1, int int_6, int int_7);

	static void smethod_145(ConsoleColor consoleColor_0)
	{
		//Discarded unreachable code: IL_0008, IL_000d, IL_0013, IL_001c
		//IL_000d: Unsupported input type for neg.
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Incompatible stack heights: 0 vs 1
		//IL_0019: Expected O, but got I4
		while (5 == 0)
		{
		}
		/*Error near IL_0007: Unknown opcode: 0xF8*/;
	}

	static Process smethod_146()
	{
		//Discarded unreachable code: IL_0006
		//IL_0003: Expected O, but got Unknown
		_ = ((Array)/*Error: ldloc 3 (out-of-bounds)*/).LongLength;
		_ = -1;
		/*Error near IL_0005: Unknown opcode: 0xFB*/;
	}

	static extern ProcessModule smethod_147(Process process_0);

	unsafe static string smethod_148(ProcessModule processModule_0)
	{
		//IL_0003: Expected F4, but got I4
		do
		{
			*(_003F*)(nint)/*Error near IL_0001: Stack underflow*/ = /*Error near IL_0001: Stack underflow*/;
			byte num = checked((byte)/*Error near IL_0002: Stack underflow*/);
			((float[])/*Error near IL_0003: Stack underflow*/)[/*Error near IL_0003: Stack underflow*/] = (int)num;
			((float[])/*Error near IL_0004: Stack underflow*/)[/*Error near IL_0004: Stack underflow*/] = (float)/*Error near IL_0004: Stack underflow*/;
		}
		while (/*Error near IL_0009: Stack underflow*/ <= /*Error near IL_0009: Stack underflow*/);
		/*OpCode not supported: DebugBreak*/;
		*(_003F*)(nint)/*Error near IL_000b: Stack underflow*/ = /*Error near IL_000b: Stack underflow*/;
		/*Error: Unexpected end of block*/;
	}

	static extern Process smethod_149(string string_12);

	unsafe static void smethod_150(string string_12, bool bool_2)
	{
		//Discarded unreachable code: IL_0007, IL_0008
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		/*Error: stloc 0 (out-of-bounds)*/;
		checked
		{
			_ = (nint)unchecked((uint)(*(short*)(nint)/*Error near IL_0003: Stack underflow*/));
			/*Error near IL_0006: Unknown opcode: 0xF8*/;
		}
	}

	unsafe static void smethod_151(string string_12)
	{
		_ = (double)/*Error near IL_0001: Stack underflow*/;
		_ = null;
		_ = *(long*)8;
		/*Error: Unexpected end of block*/;
	}

	static extern string smethod_152(int int_6);

	unsafe static DirectoryInfo smethod_153(string string_12)
	{
		//IL_0008: Expected native int or pointer, but got O
		_ = 0;
		_ = *(sbyte*)unchecked((nint)null);
		/*Error near IL_0009: Invalid metadata token*/;
	}

	static extern void smethod_154(string string_12);

	static extern void smethod_155(bool bool_2);

	static extern bool smethod_156(string string_12);

	static extern void smethod_157();

	static extern CloseReason smethod_158(FormClosingEventArgs formClosingEventArgs_0);

	static extern void smethod_159(CancelEventArgs cancelEventArgs_0, bool bool_2);

	unsafe static DialogResult smethod_160(string string_12, string string_13, MessageBoxButtons messageBoxButtons_0, MessageBoxIcon messageBoxIcon_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			while (true)
			{
				/*Error: stloc 2 (out-of-bounds)*/;
				_003F val = /*Error near IL_0002: Stack underflow*/- /*Error near IL_0002: Stack underflow*/;
				if (/*Error near IL_0007: Stack underflow*/ == val)
				{
					int num;
					unchecked
					{
						num = *(int*)checked((nint)/*Error near IL_0009: Stack underflow*/);
					}
					_003F val2 = /*Error near IL_000b: Stack underflow*/+ num;
					_003F val3 = /*Error near IL_000c: Stack underflow*/& val2;
					if (/*Error near IL_0012: Stack underflow*/ < val3)
					{
						break;
					}
				}
			}
			uint num2 = (uint)/*Error near IL_0013: Stack underflow*/;
			_ = /*Error near IL_0015: Stack underflow*/- num2;
			/*Error: Unexpected end of block*/;
		}
	}

	static extern Array smethod_161(Type type_0);

	static IEnumerator smethod_162(Array array_0)
	{
		//Discarded unreachable code: IL_0005, IL_000a, IL_0015, IL_001b
		/*Error: Invalid metadata token*/;
	}

	static extern object smethod_163(IEnumerator ienumerator_0);

	static extern int smethod_164(object object_1);

	static extern bool smethod_165(IEnumerator ienumerator_0);

	static extern void smethod_166(Form form_0, double double_0);

	static extern void smethod_167(Form form_0, FormWindowState formWindowState_0);

	unsafe static void smethod_168(Form form_0, bool bool_2)
	{
		//Discarded unreachable code: IL_0009, IL_0014
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected O, but got I
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		IntPtr intPtr = *(IntPtr*)(nint)(/*Error near IL_0001: Stack underflow*/ - /*Error near IL_0001: Stack underflow*/);
		*(int*)(nint)/*Error near IL_0003: Stack underflow*/ = (int)(nint)intPtr;
		checked
		{
			_ = /*Error near IL_0004: Stack underflow*/+ /*Error near IL_0004: Stack underflow*/;
			/*Error near IL_0004: Invalid metadata token*/;
		}
	}

	static extern void smethod_169(Form form_0, bool bool_2);
}
