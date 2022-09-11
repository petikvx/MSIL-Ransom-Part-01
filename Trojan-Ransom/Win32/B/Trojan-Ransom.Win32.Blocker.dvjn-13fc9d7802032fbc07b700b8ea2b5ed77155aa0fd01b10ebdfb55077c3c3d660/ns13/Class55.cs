using System;
using System.Windows.Forms;
using ns11;

namespace ns13;

internal class Class55 : Class54
{
	protected override Guid vmethod_3()
	{
		try
		{
			string text = Class56.smethod_157("AnonymousID");
			if (text.Length == 0)
			{
				Guid result = Guid.NewGuid();
				Class56.smethod_9("AnonymousID", result.ToString("B"));
				if (Class56.smethod_157("AnonymousID").Length > 0)
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

	internal static bool X4Dq9ope4QoDlqbXrLC()
	{
		return true;
	}

	internal static bool MKd69Qpi37B86baV5xN()
	{
		return false;
	}
}
