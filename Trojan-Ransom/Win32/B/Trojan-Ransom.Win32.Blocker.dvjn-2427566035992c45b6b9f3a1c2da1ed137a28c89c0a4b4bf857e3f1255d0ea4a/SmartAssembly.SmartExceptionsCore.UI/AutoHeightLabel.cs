using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace SmartAssembly.SmartExceptionsCore.UI;

[DesignerCategory("Code")]
public class AutoHeightLabel : Label
{
	private void DoAutoHeight()
	{
		try
		{
			Graphics val = ((Control)this).CreateGraphics();
			try
			{
				int textHeight = Win32.GetTextHeight(val, ((Control)this).get_Text(), ((Control)this).get_Font(), ((Control)this).get_Width());
				if (textHeight > 0)
				{
					((Control)this).set_Height(textHeight);
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
		DoAutoHeight();
	}

	protected override void OnResize(EventArgs e)
	{
		((Control)this).OnResize(e);
		DoAutoHeight();
	}

	protected override void OnTextChanged(EventArgs e)
	{
		((Label)this).OnTextChanged(e);
		DoAutoHeight();
	}

	public AutoHeightLabel()
	{
		Class2.l4t8M9wzGUypc();
		((Label)this)._002Ector();
		((Label)this).set_FlatStyle((FlatStyle)3);
		((Label)this).set_UseMnemonic(false);
	}
}
