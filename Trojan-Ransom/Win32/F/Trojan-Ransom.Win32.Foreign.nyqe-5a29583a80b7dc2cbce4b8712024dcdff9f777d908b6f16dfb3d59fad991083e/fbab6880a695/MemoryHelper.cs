using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace fbab6880a695;

internal class MemoryHelper : DialogType
{
	private new bool nextCaption;

	public MemoryHelper()
	{
		while (true)
		{
			int num = -614781209;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB7C3D383u) % 3u)
				{
				case 1u:
					goto IL_0008;
				default:
					return;
				case 2u:
					break;
				case 0u:
					return;
				}
				break;
				IL_0008:
				DisconnectPlugin();
				num = ((int)num2 * -986332948) ^ -2002371428;
			}
		}
	}

	public override void ToggleDatabase()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Expected O, but got Unknown
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Expected O, but got Unknown
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Expected O, but got Unknown
		((Control)this).set_Font(new Font(PathSet.nextCaption[9], 10f));
		while (true)
		{
			int num = 1427582186;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x300F2639u) % 6u)
				{
				case 4u:
					base.nextCaption.DrawRectangle(new Pen(Color.FromArgb(214, 214, 214)), 0, 0, checked(((Control)this).get_Width() - 1), 30);
					base.nextCaption.DrawString(((Control)this).get_Text(), ((Control)this).get_Font(), (Brush)new SolidBrush(((Control)this).get_ForeColor()), 7f, 6f);
					num = ((int)num2 * -1334056392) ^ 0x50967F6D;
					continue;
				case 3u:
				{
					base.nextCaption.Clear(Color.FromArgb(245, 245, 245));
					Graphics obj = base.nextCaption;
					SolidBrush val = new SolidBrush(Color.FromArgb(231, 231, 231));
					Rectangle rectangle = new Rectangle(0, 0, ((Control)this).get_Width(), 30);
					obj.FillRectangle((Brush)val, rectangle);
					num = (int)(num2 * 1602373422) ^ -1408338309;
					continue;
				}
				case 2u:
					checked
					{
						base.nextCaption.DrawLine(new Pen(Color.FromArgb(233, 238, 240)), 1, 1, ((Control)this).get_Width() - 2, 1);
						base.nextCaption.DrawRectangle(new Pen(Color.FromArgb(214, 214, 214)), 0, 0, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 1);
					}
					num = ((int)num2 * -879152624) ^ -1085700061;
					continue;
				case 1u:
					((Control)this).set_ForeColor(Color.FromArgb(40, 40, 40));
					base.nextCaption.set_SmoothingMode((SmoothingMode)4);
					num = ((int)num2 * -617617283) ^ -1666468691;
					continue;
				default:
					return;
				case 5u:
					break;
				case 0u:
					return;
				}
				break;
			}
		}
	}
}
