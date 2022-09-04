using System;
using System.Drawing;
using System.Windows.Forms;

namespace ns0;

internal sealed class Class30 : Label
{
	public Class30()
	{
		((Label)this).set_FlatStyle((FlatStyle)3);
		((Label)this).set_UseMnemonic(false);
	}

	private void method_0()
	{
		try
		{
			do
			{
				if ((7 == 0) ? true : false)
				{
					continue;
				}
				Graphics val = ((Control)this).CreateGraphics();
				try
				{
					int num;
					do
					{
						num = Class34.smethod_7(val, ((Control)this).get_Text(), ((Control)this).get_Font(), ((Control)this).get_Width());
					}
					while (6 == 0);
					if (false || num > 0)
					{
						((Control)this).set_Height(num);
					}
				}
				finally
				{
					((IDisposable)val)?.Dispose();
				}
			}
			while (4 == 0);
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
}
