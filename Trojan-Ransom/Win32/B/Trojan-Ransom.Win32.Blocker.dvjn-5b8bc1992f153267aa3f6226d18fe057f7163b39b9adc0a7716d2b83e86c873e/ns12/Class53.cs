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
		Class58.smethod_167(this);
	}

	void Control.OnResize(EventArgs e)
	{
		((Control)this).OnResize(e);
		Class58.smethod_167(this);
	}

	void Label.OnTextChanged(EventArgs e)
	{
		((Label)this).OnTextChanged(e);
		Class58.smethod_167(this);
	}

	public Class53()
	{
		while (true)
		{
			((Label)this)._002Ector();
			while (true)
			{
				((Label)this).set_FlatStyle((FlatStyle)3);
				while (true)
				{
					((Label)this).set_UseMnemonic(false);
					if (FYByFJvyu3IEmBTI6n9())
					{
						switch (5)
						{
						case 1:
						case 4:
							goto end_IL_0003;
						case 0:
						case 2:
							goto end_IL_0035;
						case 5:
							return;
						}
						continue;
					}
					return;
					continue;
					end_IL_0003:
					break;
				}
				continue;
				end_IL_0035:
				break;
			}
		}
	}

	internal static bool FYByFJvyu3IEmBTI6n9()
	{
		return true;
	}

	internal static bool xuQEDXvuByVMc3xBeWL()
	{
		return false;
	}
}
