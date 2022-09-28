using System;
using System.Windows.Forms;

public class GForm0 : Form
{
	extern void Form.OnLoad(EventArgs e);

	public GForm0()
	{
		//IL_0012: Expected I4, but got O
		while (/*Error near IL_0005: Stack underflow*/ == /*Error near IL_0005: Stack underflow*/)
		{
		}
		checked
		{
			_ = (int)/*Error near IL_0007: Stack underflow*/;
		}
		switch ((int)"")
		{
		default:
			;
			break;
		}
		/*Error: Unexpected end of block*/;
	}

	static extern void smethod_0(Form form_0, FormBorderStyle formBorderStyle_0);

	static extern void smethod_1(Form form_0, FormWindowState formWindowState_0);

	static extern void smethod_2(Form form_0, bool bool_0);
}
