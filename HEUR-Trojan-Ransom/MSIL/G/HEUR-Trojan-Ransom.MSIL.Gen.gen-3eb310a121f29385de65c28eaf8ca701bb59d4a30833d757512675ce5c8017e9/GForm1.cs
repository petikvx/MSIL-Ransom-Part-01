using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

public class GForm1 : Form
{
	private int int_0;

	private string string_0;

	private string[] string_1;

	private Random random_0;

	public static Dictionary<string, string> dictionary_0;

	public static List<string> list_0;

	public static List<string> list_1;

	private int int_1;

	private int int_2;

	private bool bool_0;

	private int int_3;

	private int int_4;

	private int int_5;

	private IContainer icontainer_0;

	private Timer timer_0;

	private Label label_0;

	private Button button_0;

	private Label label_1;

	private PictureBox pictureBox_0;

	private Label label_2;

	private Label label_3;

	private PictureBox pictureBox_1;

	private Label label_4;

	private Label label_5;

	private Button button_1;

	private Button button_2;

	private Button button_3;

	private Label label_6;

	private Button button_4;

	public extern GForm1();

	[DllImport("user32.dll")]
	private static extern IntPtr GetForegroundWindow();

	[DllImport("user32.dll")]
	private static extern int GetWindowText(IntPtr intptr_0, StringBuilder stringBuilder_0, int int_6);

	private string method_0()
	{
		//Discarded unreachable code: IL_000f, IL_0018
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Invalid comparison between Unknown and I8
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		long num;
		do
		{
			num = ((sbyte[])(/*Error near IL_0001: Stack underflow*/ / /*Error near IL_0001: Stack underflow*/))[5];
		}
		while ((long)/*Error near IL_000a: Stack underflow*/ >= num);
		/*Error near IL_000a: Invalid metadata token*/;
	}

	private extern byte[] method_1(byte[] byte_0, byte[] byte_1);

	private unsafe void method_2(object sender, EventArgs e)
	{
		//IL_0002: Expected F4, but got O
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Expected F8, but got Unknown
		//IL_0007: Expected O, but got I4
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		_003F val2;
		do
		{
			((float[])/*Error near IL_0002: Stack underflow*/)[/*Error near IL_0002: Stack underflow*/] = (float)e;
			byte num = ((byte[])/*Error near IL_0003: Stack underflow*/)[/*Error near IL_0003: Stack underflow*/];
			_003F val = /*Error near IL_0004: Stack underflow*// num;
			*(double*)(nint)/*Error near IL_0005: Stack underflow*/ = (double)val;
			*(object*)(nint)/*Error near IL_0007: Stack underflow*/ = 1;
			val2 = /*Error near IL_0007: ldloc 3 (out-of-bounds)*/;
		}
		while (/*Error near IL_000d: Stack underflow*/ >= val2);
		_003F val3 = *(long*)(nint)(/*Error near IL_000e: Stack underflow*/ + /*Error near IL_000e: Stack underflow*/) % /*Error near IL_000f: ldloc 1 (out-of-bounds)*/;
		_003F val4 = /*Error near IL_0014: Stack underflow*/* (nuint)val3;
		throw checked(/*Error near IL_0015: Stack underflow*/ * val4);
	}

	public extern void method_3(string string_2);

	private extern void method_4(object sender, EventArgs e);

	private extern void method_5(object sender, EventArgs e);

	private extern void method_6(object sender, EventArgs e);

	private extern void method_7(object sender, MouseEventArgs e);

	private extern void method_8(object sender, EventArgs e);

	private extern void method_9(object sender, EventArgs e);

	private extern void method_10(object sender, MouseEventArgs e);

	private extern void method_11(object sender, MouseEventArgs e);

	private extern void method_12(object sender, EventArgs e);

	void Form.Dispose(bool disposing)
	{
		//Discarded unreachable code: IL_0006, IL_000b
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		uint num = ((uint[])/*Error near IL_0002: Stack underflow*/)[/*Error near IL_0002: Stack underflow*/];
		int num2 = ((int[])/*Error near IL_0003: Stack underflow*/)[num];
		checked
		{
			_ = /*Error near IL_0004: Stack underflow*/- num2;
			/*Error near IL_0005: Unknown opcode: 0xFD*/;
		}
	}

	private unsafe void method_13()
	{
		//Discarded unreachable code: IL_0012, IL_0016, IL_001b, IL_0022
		//IL_0003: Expected I8, but got O
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected I8, but got Unknown
		//IL_001d: Invalid comparison between Unknown and I8
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			*(long*)(nint)/*Error near IL_0003: Stack underflow*/ = (long)this;
			if (/*Error near IL_0009: Stack underflow*/ > /*Error near IL_0009: Stack underflow*/)
			{
				_003F val = /*Error near IL_000c: Stack underflow*/>> 7;
				((long[])/*Error near IL_000d: Stack underflow*/)[/*Error near IL_000d: Stack underflow*/] = (long)val;
			}
		}
	}

	static GForm1()
	{
		//Discarded unreachable code: IL_0005
		/*Error: Invalid metadata token*/;
	}

	static extern string[] smethod_0(string string_2, char[] char_0);

	static extern Random smethod_1();

	static extern StringBuilder smethod_2(int int_6);

	static extern string smethod_3(object object_0);

	static char[] smethod_4(string string_2)
	{
		return (char[])/*Error near IL_0001: Stack underflow*/;
	}

	static extern int smethod_5(Random random_1, int int_6, int int_7);

	static extern string[] smethod_6(string string_2);

	static string smethod_7(string string_2, string string_3)
	{
		//Discarded unreachable code: IL_0002, IL_0007, IL_000c, IL_000e, IL_0021, IL_0026, IL_0029, IL_0030, IL_0035, IL_003a
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Invalid comparison between Unknown and I8
		//IL_002b: Invalid comparison between Unknown and F4
		/*Error near IL_0001: Unknown opcode: 0xF8*/;
	}

	static extern void smethod_8(string string_2);

	static string[] smethod_9(string string_2)
	{
		//Discarded unreachable code: IL_0005, IL_000c
		/*Error: Invalid metadata token*/;
	}

	static extern OpenFileDialog smethod_10();

	static extern void smethod_11(FileDialog fileDialog_0, string string_2);

	static extern DialogResult smethod_12(CommonDialog commonDialog_0);

	unsafe static string smethod_13(FileDialog fileDialog_0)
	{
		//Discarded unreachable code: IL_0006
		//IL_001c: Expected I4, but got O
		_ = *(sbyte*)(nint)/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0001: Invalid metadata token*/;
	}

	static extern void smethod_14(Control control_0, bool bool_1);

	static extern byte[] smethod_15(string string_2);

	static extern Encoding smethod_16();

	static extern byte[] smethod_17(Encoding encoding_0, string string_2);

	static extern void smethod_18(string string_2, byte[] byte_0);

	static extern string smethod_19(string string_2, string string_3, string string_4);

	static extern void smethod_20(string string_2, string string_3);

	static extern DialogResult smethod_21(string string_2, string string_3, MessageBoxButtons messageBoxButtons_0, MessageBoxIcon messageBoxIcon_0);

	static extern void smethod_22(IDisposable idisposable_0);

	static extern DialogResult smethod_23(Form form_0);

	static extern string smethod_24();

	static extern string smethod_25(string[] string_2);

	static extern void smethod_26(Control control_0, string string_2);

	static extern void smethod_27(int int_6);

	static extern string smethod_28(string string_2, object object_0, object object_1);

	static extern string smethod_29(string string_2, object object_0);

	static extern string smethod_30(string string_2, string string_3, string string_4);

	static extern DialogResult smethod_31(string string_2, string string_3);

	static extern int smethod_32(MouseEventArgs mouseEventArgs_0);

	static extern int smethod_33(MouseEventArgs mouseEventArgs_0);

	static extern void smethod_34(Form form_0);

	static extern void smethod_35(FileDialog fileDialog_0, string string_2);

	static extern DialogResult smethod_36(string string_2);

	static extern Point smethod_37();

	static extern string smethod_38(string string_2, object object_0, object object_1, object object_2);

	static bool smethod_39(string string_2, string string_3)
	{
		//Discarded unreachable code: IL_0006, IL_000d, IL_001b
		//IL_0008: Invalid comparison between Unknown and O
		//IL_0014: Expected I8, but got I4
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		_ = (ushort)/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0001: Invalid metadata token*/;
	}

	static extern void smethod_40(Control control_0, Color color_0);

	static extern void smethod_41(Timer timer_1);

	static extern Container smethod_42();

	static extern Type smethod_43(RuntimeTypeHandle runtimeTypeHandle_0);

	static extern ComponentResourceManager smethod_44(Type type_0);

	static extern Timer smethod_45(IContainer icontainer_1);

	static extern Label smethod_46();

	static extern Button smethod_47();

	static extern PictureBox smethod_48();

	unsafe static void smethod_49(ISupportInitialize isupportInitialize_0)
	{
		//IL_0004: Expected O, but got Unknown
		//IL_0003: Expected native int or pointer, but got O
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected I4, but got Unknown
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		*(_003F*)unchecked((nint)null) = /*Error near IL_0002: ldloc 0 (out-of-bounds)*/;
		_003F val = /*Error near IL_0005: Stack underflow*/| /*Error near IL_0005: Stack underflow*/;
		((sbyte[])/*Error near IL_0006: Stack underflow*/)[/*Error near IL_0006: Stack underflow*/] = (sbyte)(int)val;
		*(_003F*)(nint)/*Error near IL_0007: Stack underflow*/ = /*Error near IL_0007: Stack underflow*/;
		_ = ~/*Error near IL_0008: Stack underflow*/;
		/*Error near IL_0008: Invalid metadata token*/;
	}

	static extern void smethod_50(Control control_0);

	static extern void smethod_51(Timer timer_1, int int_6);

	static extern void smethod_52(Timer timer_1, EventHandler eventHandler_0);

	static extern Font smethod_53(string string_2, float float_0);

	static extern void smethod_54(Control control_0, Font font_0);
}
