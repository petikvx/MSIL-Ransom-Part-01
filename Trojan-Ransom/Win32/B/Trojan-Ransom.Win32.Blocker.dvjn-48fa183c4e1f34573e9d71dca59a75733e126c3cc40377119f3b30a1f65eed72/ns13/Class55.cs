using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace ns13;

[DesignerCategory("Code")]
internal class Class55 : Label
{
	void Label.OnFontChanged(EventArgs e)
	{
		((Label)this).OnFontChanged(e);
		Class12.smethod_155(this);
	}

	void Control.OnResize(EventArgs e)
	{
		((Control)this).OnResize(e);
		Class12.smethod_155(this);
	}

	void Label.OnTextChanged(EventArgs e)
	{
		((Label)this).OnTextChanged(e);
		Class12.smethod_155(this);
	}

	public Class55()
	{
		((Label)this).set_FlatStyle((FlatStyle)3);
		((Label)this).set_UseMnemonic(false);
	}

	internal static bool ysMWgdRLa9RvdsybF2k()
	{
		return true;
	}

	internal static bool ECEBZtRBu30alVnZ0VN()
	{
		return false;
	}
}
