using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace ns10;

[DesignerCategory("Code")]
internal class Class37 : Label
{
	void Label.OnFontChanged(EventArgs e)
	{
		((Label)this).OnFontChanged(e);
		Class42.smethod_73(this);
	}

	void Control.OnResize(EventArgs e)
	{
		((Control)this).OnResize(e);
		Class42.smethod_73(this);
	}

	void Label.OnTextChanged(EventArgs e)
	{
		((Label)this).OnTextChanged(e);
		Class42.smethod_73(this);
	}

	public Class37()
	{
		((Label)this).set_FlatStyle((FlatStyle)3);
		((Label)this).set_UseMnemonic(false);
	}

	internal static bool RfTsfs4VKJjGddd8Roq()
	{
		return true;
	}

	internal static bool Uf4uJK4JhVwTFi9hTlN()
	{
		return false;
	}
}
