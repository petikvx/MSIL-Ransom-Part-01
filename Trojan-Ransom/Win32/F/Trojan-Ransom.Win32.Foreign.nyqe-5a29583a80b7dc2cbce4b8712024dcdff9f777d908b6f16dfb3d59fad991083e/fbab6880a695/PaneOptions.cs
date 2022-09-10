using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace fbab6880a695;

internal class PaneOptions : FileLayout
{
	public override void DisposeDatabase()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected O, but got Unknown
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Expected O, but got Unknown
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Expected O, but got Unknown
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Expected O, but got Unknown
		//IL_0194: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Expected O, but got Unknown
		//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c7: Expected O, but got Unknown
		//IL_0259: Unknown result type (might be due to invalid IL or missing references)
		//IL_026e: Expected O, but got Unknown
		//IL_02d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02da: Expected O, but got Unknown
		//IL_0334: Unknown result type (might be due to invalid IL or missing references)
		//IL_0349: Expected O, but got Unknown
		((Control)this).set_Font(new Font(PathSet.nextCaption[7], 10f));
		base.nextCaption.Clear(((Control)this).get_BackColor());
		Pen val6 = default(Pen);
		LinearGradientBrush val5 = default(LinearGradientBrush);
		LinearGradientBrush val3 = default(LinearGradientBrush);
		Pen val4 = default(Pen);
		LinearGradientBrush val2 = default(LinearGradientBrush);
		Pen val = default(Pen);
		while (true)
		{
			int num = 1618997925;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x771DDE59u) % 23u)
				{
				case 22u:
				{
					Graphics obj5 = base.nextCaption;
					Pen obj6 = val6;
					Rectangle rectangle = checked(new Rectangle(0, 0, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 1));
					obj5.DrawPath(obj6, ProjectContext.ToggleDatabase(rectangle, 3));
					num = ((int)num2 * -2099110054) ^ 0x2F7C4DC7;
					continue;
				}
				case 21u:
					base.nextCaption.FillPath((Brush)(object)val5, ProjectContext.ToggleDatabase(((Control)this).get_ClientRectangle(), 4));
					num = (int)((num2 * 1587562221) ^ 0x7971A32D);
					continue;
				case 20u:
					num = ((int)num2 * -1192369140) ^ 0x3BD9EEFB;
					continue;
				case 19u:
					num = ((int)num2 * -556024709) ^ -1522682595;
					continue;
				case 18u:
					((Control)this).set_Cursor(Cursors.get_Hand());
					num = 1321775272;
					continue;
				case 17u:
					val3 = new LinearGradientBrush(((Control)this).get_ClientRectangle(), Color.FromArgb(51, 159, 231), Color.FromArgb(33, 128, 206), (LinearGradientMode)1);
					num = (int)(num2 * 1040565489) ^ -1292717222;
					continue;
				case 16u:
					switch (nextCaption)
					{
					case FormList.nextCaption:
						goto IL_013a;
					case FormList.parentLog:
						goto IL_015d;
					case FormList.propStorePosition:
						goto IL_0181;
					}
					num = (int)(num2 * 1770258986) ^ -1957259407;
					continue;
				case 14u:
					goto IL_013a;
				case 0u:
					goto IL_015d;
				case 8u:
					goto IL_0181;
				case 13u:
				{
					Graphics obj3 = base.nextCaption;
					Pen obj4 = val4;
					Rectangle rectangle = checked(new Rectangle(0, 0, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 1));
					obj3.DrawPath(obj4, ProjectContext.ToggleDatabase(rectangle, 3));
					num = (int)(num2 * 252633653) ^ -1020962266;
					continue;
				}
				case 12u:
					JoinBookmark((HorizontalAlignment)2, Color.FromArgb(240, 240, 240), 0);
					num = (int)((num2 * 337276986) ^ 0x3722CD00);
					continue;
				case 11u:
					base.nextCaption.DrawLine(new Pen(Color.FromArgb(131, 197, 241)), 2, 1, checked(((Control)this).get_Width() - 3), 1);
					num = ((int)num2 * -2028071904) ^ 0x5DAA46AE;
					continue;
				case 10u:
					base.nextCaption.FillPath((Brush)(object)val3, ProjectContext.ToggleDatabase(((Control)this).get_ClientRectangle(), 4));
					num = ((int)num2 * -1762912547) ^ -336630205;
					continue;
				case 9u:
					val2 = new LinearGradientBrush(((Control)this).get_ClientRectangle(), Color.FromArgb(54, 167, 243), Color.FromArgb(35, 165, 217), (LinearGradientMode)1);
					num = ((int)num2 * -233923281) ^ 0x19A66798;
					continue;
				case 7u:
					JoinBookmark((HorizontalAlignment)2, Color.FromArgb(240, 240, 240), -1);
					num = ((int)num2 * -761225812) ^ -648401701;
					continue;
				case 6u:
					base.nextCaption.DrawLine(new Pen(Color.FromArgb(131, 197, 241)), 2, 1, checked(((Control)this).get_Width() - 3), 1);
					num = ((int)num2 * -470044860) ^ -613979796;
					continue;
				case 5u:
					num = ((int)num2 * -762492067) ^ 0x190A6EB4;
					continue;
				case 4u:
					base.nextCaption.FillPath((Brush)(object)val2, ProjectContext.ToggleDatabase(((Control)this).get_ClientRectangle(), 4));
					num = ((int)num2 * -384915894) ^ -480246402;
					continue;
				case 3u:
				{
					Graphics obj = base.nextCaption;
					Pen obj2 = val;
					Rectangle rectangle = checked(new Rectangle(0, 0, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 1));
					obj.DrawPath(obj2, ProjectContext.ToggleDatabase(rectangle, 3));
					JoinBookmark((HorizontalAlignment)2, Color.FromArgb(250, 250, 250), 1);
					num = ((int)num2 * -1755785382) ^ 0x174CEF6;
					continue;
				}
				case 1u:
					base.nextCaption.set_SmoothingMode((SmoothingMode)2);
					num = (int)((num2 * 2029536997) ^ 0x176EFE32);
					continue;
				default:
					return;
				case 15u:
					break;
				case 2u:
					return;
					IL_0181:
					val = new Pen(Color.FromArgb(34, 112, 171), 1f);
					val5 = new LinearGradientBrush(((Control)this).get_ClientRectangle(), Color.FromArgb(37, 124, 196), Color.FromArgb(53, 153, 219), (LinearGradientMode)1);
					num = 864916852;
					continue;
					IL_015d:
					val4 = new Pen(Color.FromArgb(34, 112, 171), 1f);
					num = 379183579;
					continue;
					IL_013a:
					val6 = new Pen(Color.FromArgb(34, 112, 171), 1f);
					num = 1053374220;
					continue;
				}
				break;
			}
		}
	}
}
