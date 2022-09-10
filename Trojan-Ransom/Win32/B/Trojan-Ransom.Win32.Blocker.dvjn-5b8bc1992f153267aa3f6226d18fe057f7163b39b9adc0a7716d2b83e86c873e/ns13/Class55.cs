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
			string text = Class58.smethod_141("AnonymousID");
			while (text.Length == 0)
			{
				while (true)
				{
					Guid result = Guid.NewGuid();
					while (true)
					{
						string string_ = "AnonymousID";
						string text2 = result.ToString("B");
						Class58.smethod_4(text2, string_);
						if (Class58.smethod_141("AnonymousID").Length <= 0)
						{
							Guid empty = Guid.Empty;
							if (!q9UBMrv9D2cKD3Xeq34())
							{
								switch (6)
								{
								case 1:
								case 2:
									goto end_IL_0043;
								case 0:
								case 5:
									goto end_IL_0073;
								case 3:
									goto IL_0085;
								case 6:
									return empty;
								}
							}
							continue;
						}
						goto IL_0085;
						IL_0085:
						return result;
						continue;
						end_IL_0043:
						break;
					}
					continue;
					end_IL_0073:
					break;
				}
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

	internal static bool FFUbyqvxtVPXVqBBiho()
	{
		return true;
	}

	internal static bool q9UBMrv9D2cKD3Xeq34()
	{
		return false;
	}
}
