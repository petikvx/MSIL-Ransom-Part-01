using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace fbab6880a695;

internal class PageSettings : DialogType
{
	private new bool nextCaption;

	public PageSettings()
	{
		while (true)
		{
			int num = 918229187;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x651B0F96u) % 3u)
				{
				case 2u:
					goto IL_0008;
				default:
					return;
				case 0u:
					break;
				case 1u:
					return;
				}
				break;
				IL_0008:
				DisconnectPlugin();
				num = ((int)num2 * -511152324) ^ 0x5E8A2ED5;
			}
		}
	}

	public override void ToggleDatabase()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected O, but got Unknown
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Expected O, but got Unknown
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Expected O, but got Unknown
		((Control)this).set_Font(new Font(PathSet.nextCaption[9], 10f));
		((Control)this).set_ForeColor(Color.FromArgb(40, 40, 40));
		base.nextCaption.set_SmoothingMode((SmoothingMode)4);
		while (true)
		{
			int num = -704577609;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB9381A33u) % 5u)
				{
				case 3u:
				{
					Graphics obj2 = base.nextCaption;
					SolidBrush val2 = new SolidBrush(Color.FromArgb(235, 235, 235));
					Rectangle rectangle = new Rectangle(2, 0, ((Control)this).get_Width(), ((Control)this).get_Height());
					obj2.FillRectangle((Brush)val2, rectangle);
					num = ((int)num2 * -798470243) ^ -989790859;
					continue;
				}
				case 1u:
					checked
					{
						base.nextCaption.DrawRectangle(new Pen(Color.FromArgb(214, 214, 214)), 0, 0, ((Control)this).get_Width() - 2, ((Control)this).get_Height() - 3);
					}
					num = (int)(num2 * 1884460472) ^ -1854023630;
					continue;
				case 0u:
				{
					Graphics obj = base.nextCaption;
					SolidBrush val = new SolidBrush(Color.FromArgb(249, 249, 249));
					Rectangle rectangle = checked(new Rectangle(1, 0, ((Control)this).get_Width() - 3, ((Control)this).get_Height() - 4));
					obj.FillRectangle((Brush)val, rectangle);
					num = ((int)num2 * -660617903) ^ -2067102145;
					continue;
				}
				default:
					return;
				case 2u:
					break;
				case 4u:
					return;
				}
				break;
			}
		}
	}
}
