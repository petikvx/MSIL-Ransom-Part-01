using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace ns10;

[DesignerCategory("Code")]
internal class Class38 : Label
{
	void Label.OnFontChanged(EventArgs e)
	{
		((Label)this).OnFontChanged(e);
		Class33.smethod_9(this);
	}

	void Control.OnResize(EventArgs e)
	{
		((Control)this).OnResize(e);
		Class33.smethod_9(this);
	}

	void Label.OnTextChanged(EventArgs e)
	{
		((Label)this).OnTextChanged(e);
		Class33.smethod_9(this);
	}

	public Class38()
	{
		((Label)this).set_FlatStyle((FlatStyle)3);
		((Label)this).set_UseMnemonic(false);
	}

	internal static bool DAe7sMrnialyRUg4QUa()
	{
		return true;
	}

	internal static bool OfT8urriJ1XlwvLxw3S()
	{
		return false;
	}
}
