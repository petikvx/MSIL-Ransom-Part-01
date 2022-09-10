using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace ns12;

[DesignerCategory("Code")]
internal class Class54 : Label
{
	void Label.OnFontChanged(EventArgs e)
	{
		((Label)this).OnFontChanged(e);
		Class21.smethod_70(this);
	}

	void Control.OnResize(EventArgs e)
	{
		((Control)this).OnResize(e);
		Class21.smethod_70(this);
	}

	void Label.OnTextChanged(EventArgs e)
	{
		((Label)this).OnTextChanged(e);
		Class21.smethod_70(this);
	}

	public Class54()
	{
		((Label)this).set_FlatStyle((FlatStyle)3);
		((Label)this).set_UseMnemonic(false);
	}

	internal static bool h69nyHXThR7AxlJp7HB()
	{
		return true;
	}

	internal static bool D0PcqTXvoYGtLtl1LO7()
	{
		return false;
	}
}
