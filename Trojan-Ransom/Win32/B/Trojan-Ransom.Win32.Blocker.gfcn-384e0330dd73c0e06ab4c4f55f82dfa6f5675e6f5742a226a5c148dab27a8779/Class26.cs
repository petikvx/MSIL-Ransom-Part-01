using System;
using System.Drawing;
using System.Windows.Forms;

internal class Class26 : Label
{
	private void method_0()
	{
		try
		{
			Graphics val = ((Control)this).CreateGraphics();
			try
			{
				int num = Class32.smethod_7(val, ((Control)this).get_Text(), ((Control)this).get_Font(), ((Control)this).get_Width());
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

	public Class26()
	{
		Class52.KPUgGmhz2nAeI();
		((Label)this)._002Ector();
		((Label)this).set_FlatStyle((FlatStyle)3);
		((Label)this).set_UseMnemonic(false);
	}
}
