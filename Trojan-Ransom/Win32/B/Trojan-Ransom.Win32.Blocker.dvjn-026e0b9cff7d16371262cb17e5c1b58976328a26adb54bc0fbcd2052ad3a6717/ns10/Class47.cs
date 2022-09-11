using System;
using System.Windows.Forms;

namespace ns10;

internal class Class47 : Label
{
	void Label.OnFontChanged(EventArgs e)
	{
		((Label)this).OnFontChanged(e);
		Class17.smethod_69(this);
	}

	void Control.OnResize(EventArgs e)
	{
		((Control)this).OnResize(e);
		Class17.smethod_69(this);
	}

	void Label.OnTextChanged(EventArgs e)
	{
		((Label)this).OnTextChanged(e);
		Class17.smethod_69(this);
	}

	public Class47()
	{
		((Label)this).set_FlatStyle((FlatStyle)3);
		((Label)this).set_UseMnemonic(false);
	}

	internal static bool i28CAYGauNdf0tfmbAl()
	{
		return true;
	}

	internal static bool S2mBk4GMnRGDYqs7L8p()
	{
		return false;
	}
}
