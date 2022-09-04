using System;
using System.Windows.Forms;
using ns5;

namespace ns8;

internal class Class35 : Label
{
	void Label.OnFontChanged(EventArgs e)
	{
		((Label)this).OnFontChanged(e);
		Class24.smethod_161(this);
	}

	void Control.OnResize(EventArgs e)
	{
		((Control)this).OnResize(e);
		Class24.smethod_161(this);
	}

	void Label.OnTextChanged(EventArgs e)
	{
		((Label)this).OnTextChanged(e);
		Class24.smethod_161(this);
	}

	public Class35()
	{
		((Label)this).set_FlatStyle((FlatStyle)3);
		((Label)this).set_UseMnemonic(false);
	}
}
