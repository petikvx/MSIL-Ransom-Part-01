using System;
using System.Windows.Forms;
using ns11;

namespace ns13;

internal class Class56 : Class55
{
	protected override Guid vmethod_3()
	{
		try
		{
			string text = Class21.smethod_15("AnonymousID");
			if (text.Length == 0)
			{
				Guid result = Guid.NewGuid();
				Class21.smethod_106("AnonymousID", result.ToString("B"));
				if (Class21.smethod_15("AnonymousID").Length > 0)
				{
					return result;
				}
				return Guid.Empty;
			}
			return new Guid(text);
		}
		catch
		{
			return Guid.Empty;
		}
	}

	protected override void vmethod_2(EventArgs2 eventArgs2_0)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		Form1 form = new Form1(eventArgs2_0);
		((Form)form).ShowDialog();
	}

	protected override void vmethod_0(EventArgs1 eventArgs1_0)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		Form0 form = new Form0(this, eventArgs1_0);
		((Form)form).ShowDialog();
	}

	protected override void vmethod_1(EventArgs0 eventArgs0_0)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show(eventArgs0_0.exception_0.ToString(), string.Format("{0} Fatal Error", "vf"), (MessageBoxButtons)0, (MessageBoxIcon)16);
	}

	internal static bool w0BD0UXbHOmcLd0JVVo()
	{
		return true;
	}

	internal static bool WgfSebXqswMhGlXRAca()
	{
		return false;
	}
}
