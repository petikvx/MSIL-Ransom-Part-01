using System;
using System.Windows.Forms;
using ns9;

namespace ns11;

internal class Class49 : Class48
{
	protected override Guid vmethod_3()
	{
		try
		{
			string text = Class17.smethod_11("AnonymousID");
			if (APTpLHbb2IMBmPHknUB())
			{
				switch (4)
				{
				case 4:
					break;
				case 1:
				case 3:
					goto IL_0041;
				default:
					goto IL_006f;
				case 5:
				{
					Guid result = default(Guid);
					return result;
				}
				}
			}
			if (text.Length != 0)
			{
				return new Guid(text);
			}
			goto IL_0041;
			IL_0041:
			Guid result2 = Guid.NewGuid();
			Class17.smethod_54("AnonymousID", result2.ToString("B"));
			if (Class17.smethod_11("AnonymousID").Length <= 0)
			{
				return Guid.Empty;
			}
			goto IL_006f;
			IL_006f:
			return result2;
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

	internal static bool APTpLHbb2IMBmPHknUB()
	{
		return true;
	}

	internal static bool dtFS1CbdhddiuDpMfeN()
	{
		return false;
	}
}
