using System;
using System.Windows.Forms;
using ns4;

namespace ns5;

internal class Class34 : Label
{
	void Label.OnFontChanged(EventArgs e)
	{
		((Label)this).OnFontChanged(e);
		Class24.smethod_191(this);
	}

	void Control.OnResize(EventArgs e)
	{
		((Control)this).OnResize(e);
		Class24.smethod_191(this);
	}

	void Label.OnTextChanged(EventArgs e)
	{
		((Label)this).OnTextChanged(e);
		Class24.smethod_191(this);
	}

	public Class34()
	{
		Class42.hMqjKD0znI7T7();
		((Label)this)._002Ector();
		((Label)this).set_FlatStyle((FlatStyle)3);
		((Label)this).set_UseMnemonic(false);
	}
}
