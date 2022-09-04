using System;
using System.Drawing;
using System.Windows.Forms;
using ns4;

namespace ns2;

internal class Class36 : Label
{
	private void method_0()
	{
		try
		{
			Graphics val = ((Control)this).CreateGraphics();
			try
			{
				int num = Class40.smethod_7(val, ((Control)this).get_Text(), ((Control)this).get_Font(), ((Control)this).get_Width());
				if (num > 0)
				{
					((Control)this).set_Height(num);
				}
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
		}
		catch
		{
		}
	}

	void Label.OnFontChanged(EventArgs e)
	{
		((Label)this).OnFontChanged(e);
		method_0();
	}

	void Control.OnResize(EventArgs e)
	{
		((Control)this).OnResize(e);
		method_0();
	}

	void Label.OnTextChanged(EventArgs e)
	{
		((Label)this).OnTextChanged(e);
		method_0();
	}

	public Class36()
	{
		((Label)this).set_FlatStyle((FlatStyle)3);
		((Label)this).set_UseMnemonic(false);
	}
}
