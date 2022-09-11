using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace ns12;

[DesignerCategory("Code")]
internal class Class53 : Label
{
	void Label.OnFontChanged(EventArgs e)
	{
		((Label)this).OnFontChanged(e);
		Class56.smethod_49(this);
	}

	void Control.OnResize(EventArgs e)
	{
		((Control)this).OnResize(e);
		Class56.smethod_49(this);
	}

	void Label.OnTextChanged(EventArgs e)
	{
		((Label)this).OnTextChanged(e);
		Class56.smethod_49(this);
	}

	public Class53()
	{
		((Label)this).set_FlatStyle((FlatStyle)3);
		((Label)this).set_UseMnemonic(false);
	}

	internal static bool krc4slpm8qaJjcHRDMP()
	{
		return true;
	}

	internal static bool tvvKAJpVP1CHH12U2hn()
	{
		return false;
	}
}
