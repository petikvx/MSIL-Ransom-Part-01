using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

public class GForm1 : GForm0
{
	private IContainer icontainer_0;

	private Label label_0;

	public GForm1()
	{
		//Discarded unreachable code: IL_0001, IL_0009
		//IL_0004: Invalid comparison between Unknown and I
		/*Error: Unknown opcode: 0xF9*/;
	}

	private extern void method_0(object sender, FormClosingEventArgs e);

	extern void Form.Dispose(bool disposing);

	private void method_1()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			ulong num = (ulong)/*Error near IL_0001: Stack underflow*/;
			_ = ((float[])(/*Error near IL_0002: Stack underflow*/ - num))[-35];
			/*Error: Unexpected end of block*/;
		}
	}

	unsafe static CloseReason smethod_3(FormClosingEventArgs formClosingEventArgs_0)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		byte num = *(byte*)(nint)(/*Error near IL_0001: Stack underflow*/ % /*Error near IL_0001: Stack underflow*/);
		_003F val = /*Error near IL_0004: Stack underflow*/% num;
		_ = ((double[])/*Error near IL_0005: Stack underflow*/)[val];
		/*Error: Unexpected end of block*/;
	}

	static extern void smethod_4(CancelEventArgs cancelEventArgs_0, bool bool_0);

	static extern void smethod_5(IDisposable idisposable_0);

	static extern Label smethod_6();

	static extern void smethod_7(Control control_0);

	static extern void smethod_8(Control control_0, AnchorStyles anchorStyles_0);

	static extern void smethod_9(Control control_0, bool bool_0);

	static extern Font smethod_10(string string_0, float float_0, FontStyle fontStyle_0, GraphicsUnit graphicsUnit_0, byte byte_0);

	unsafe static void smethod_11(Control control_0, Font font_0)
	{
		//Discarded unreachable code: IL_0008, IL_000d, IL_0013, IL_0022, IL_0030
		//IL_0026: Expected O, but got I4
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected native int or pointer, but got F4
		*(int*)(nint)/*Error near IL_0002: Stack underflow*/ = 4;
		/*Error near IL_0003: Invalid metadata token*/;
	}

	static extern void smethod_12(Control control_0, Color color_0);
}
