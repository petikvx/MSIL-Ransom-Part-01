using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using ns4;

namespace ns5;

[DesignerCategory("Code")]
public class GClass7 : Label
{
	private void method_0()
	{
		try
		{
			Graphics val = ((Control)this).CreateGraphics();
			try
			{
				int num = GClass10.smethod_7(val, ((Control)this).get_Text(), ((Control)this).get_Font(), ((Control)this).get_Width());
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

	protected override void OnFontChanged(EventArgs e)
	{
		((Label)this).OnFontChanged(e);
		method_0();
	}

	protected override void OnResize(EventArgs e)
	{
		((Control)this).OnResize(e);
		method_0();
	}

	protected override void OnTextChanged(EventArgs e)
	{
		((Label)this).OnTextChanged(e);
		method_0();
	}

	public GClass7()
	{
		((Label)this).set_FlatStyle((FlatStyle)3);
		((Label)this).set_UseMnemonic(false);
	}

	static GClass7()
	{
		GClass11.smethod_0();
	}
}
