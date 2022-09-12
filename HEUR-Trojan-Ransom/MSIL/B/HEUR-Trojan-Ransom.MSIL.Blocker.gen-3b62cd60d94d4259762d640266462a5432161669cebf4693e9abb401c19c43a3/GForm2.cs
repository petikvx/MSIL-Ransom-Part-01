using System;
using System.ComponentModel;
using System.Text;
using System.Windows.Forms;

public class GForm2 : Form
{
	private IContainer icontainer_0;

	public Panel panel_0;

	public RichTextBox richTextBox_0;

	public TextBox textBox_0;

	private Button button_0;

	public extern GForm2();

	private extern void method_0(object sender, FormClosingEventArgs e);

	private extern void method_1(object sender, EventArgs e);

	private extern void method_2(object sender, KeyEventArgs e);

	private extern void method_3(object sender, EventArgs e);

	extern void Form.Dispose(bool disposing);

	private extern void method_4();

	static extern CloseReason smethod_0(FormClosingEventArgs formClosingEventArgs_0);

	static extern void smethod_1(CancelEventArgs cancelEventArgs_0, bool bool_0);

	static extern string smethod_2(Control control_0);

	static bool smethod_3(string string_0)
	{
		/*Error: Invalid metadata token*/;
	}

	static string smethod_4(string string_0, string string_1)
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

	static extern void smethod_5(Control control_0, string string_0);

	static extern string smethod_6();

	static extern string smethod_7(string string_0, string string_1, string string_2);

	static extern void smethod_8(TextBoxBase textBoxBase_0, string string_0);

	unsafe static Encoding smethod_9()
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

	static byte[] smethod_10(Encoding encoding_0, string string_0)
	{
		//Discarded unreachable code: IL_0006, IL_0014, IL_001a
		//IL_0006: Unsupported input type for neg.
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		/*Error: ldloc 3 (out-of-bounds)*/;
		/*Error near IL_0001: Invalid metadata token*/;
	}

	static extern Keys smethod_11(KeyEventArgs keyEventArgs_0);

	static bool smethod_12(Control control_0)
	{
		//Discarded unreachable code: IL_0011, IL_0018, IL_001d
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Expected O, but got Unknown
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		do
		{
			/*Error: stloc 0 (out-of-bounds)*/;
			_003F val = /*Error near IL_0002: ldloc 0 (out-of-bounds)*/;
			_003F val2 = /*Error near IL_0006: Stack underflow*/+ val;
			/*OpCode not supported: Ckfinite*/;
			control_0 = (Control)val2;
		}
		while (/*Error near IL_000e: Stack underflow*/ != /*Error near IL_000e: Stack underflow*/);
		checked
		{
			_ = /*Error near IL_000f: Stack underflow*/- /*Error near IL_000f: Stack underflow*/;
			/*Error near IL_000f: ldloc 1 (out-of-bounds)*/;
			/*Error near IL_0010: Unknown opcode: 0xF8*/;
		}
	}

	static extern void smethod_13(IDisposable idisposable_0);

	unsafe static Panel smethod_14()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Invalid comparison between Unknown and I4
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			sbyte num = *(sbyte*)(nint)(/*Error near IL_0001: Stack underflow*/ ^ /*Error near IL_0001: Stack underflow*/);
			if ((int)/*Error near IL_0008: Stack underflow*/ >= (int)num)
			{
				float num2 = (float)/*Error near IL_0009: Stack underflow*/;
				_003F val = /*Error near IL_000a: Stack underflow*/| num2;
				if (/*Error near IL_000f: Stack underflow*/ > val && /*Error near IL_0015: Stack underflow*/< /*Error near IL_0015: Stack underflow*/)
				{
					/*Error: Could not find block for branch target IL_0015*/;
				}
			}
		}
	}

	static extern RichTextBox smethod_15();

	static extern TextBox smethod_16();

	static extern Button smethod_17();

	static extern void smethod_18(Control control_0);

	static extern void smethod_19(Control control_0);

	static extern void smethod_20(Panel panel_1, BorderStyle borderStyle_0);

	static extern ControlCollection smethod_21(Control control_0);

	static extern void smethod_22(ControlCollection controlCollection_0, Control control_0);
}
