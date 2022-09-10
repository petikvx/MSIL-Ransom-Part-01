using System;
using System.ComponentModel;
using System.Windows.Forms;
using ns5;

namespace ns7;

[DesignerCategory("Code")]
internal sealed class Class43 : Label
{
	void Label.OnFontChanged(EventArgs e)
	{
		((Label)this).OnFontChanged(e);
		Class32.smethod_69(this);
	}

	void Control.OnResize(EventArgs e)
	{
		((Control)this).OnResize(e);
		Class32.smethod_69(this);
	}

	void Label.OnTextChanged(EventArgs e)
	{
		((Label)this).OnTextChanged(e);
		Class32.smethod_69(this);
	}

	public Class43()
	{
		((Label)this).set_FlatStyle((FlatStyle)3);
		((Label)this).set_UseMnemonic(false);
	}
}
