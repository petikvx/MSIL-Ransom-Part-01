using System;
using System.Drawing;
using System.Windows.Forms;
using LYGYSgYwZZQHi0dvtur;

namespace evyaqFYuXcXeA9jvcrs;

internal sealed class VpuxF8YYD0uCa7rEx2E : Label
{
	private void oAkKPbOSxE()
	{
		try
		{
			Graphics val = ((Control)this).CreateGraphics();
			try
			{
				int num = xAjiqWY1RtDWwMdfIUA.VKcAC4ij3o(val, ((Control)this).get_Text(), ((Control)this).get_Font(), ((Control)this).get_Width());
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
		oAkKPbOSxE();
	}

	void Control.OnResize(EventArgs e)
	{
		((Control)this).OnResize(e);
		oAkKPbOSxE();
	}

	void Label.OnTextChanged(EventArgs e)
	{
		((Label)this).OnTextChanged(e);
		oAkKPbOSxE();
	}

	public VpuxF8YYD0uCa7rEx2E()
	{
		((Label)this).set_FlatStyle((FlatStyle)3);
		((Label)this).set_UseMnemonic(false);
	}

	internal static bool abpwC64fssZu0r9yPX0()
	{
		return true;
	}

	internal static bool lqZMck4WiYETV2Pv1Y3()
	{
		return false;
	}
}
