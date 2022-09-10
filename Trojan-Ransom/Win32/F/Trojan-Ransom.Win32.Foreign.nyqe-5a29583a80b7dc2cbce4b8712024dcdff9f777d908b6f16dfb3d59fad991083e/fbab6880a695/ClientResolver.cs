using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace fbab6880a695;

internal class ClientResolver : FileLayout
{
	public override void DisposeDatabase()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected O, but got Unknown
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Expected O, but got Unknown
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Expected O, but got Unknown
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Expected O, but got Unknown
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Expected O, but got Unknown
		//IL_018b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Expected O, but got Unknown
		//IL_01e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f6: Expected O, but got Unknown
		//IL_0319: Unknown result type (might be due to invalid IL or missing references)
		//IL_031f: Expected O, but got Unknown
		//IL_0360: Unknown result type (might be due to invalid IL or missing references)
		//IL_0375: Expected O, but got Unknown
		//IL_03b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b7: Expected O, but got Unknown
		((Control)this).set_Font(new Font(PathSet.nextCaption[7], 10f));
		LinearGradientBrush val4 = default(LinearGradientBrush);
		Pen val5 = default(Pen);
		Pen val6 = default(Pen);
		Pen val2 = default(Pen);
		while (true)
		{
			int num = -1026072077;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF3EC4416u) % 21u)
				{
				case 20u:
					JoinBookmark((HorizontalAlignment)2, Color.FromArgb(240, 240, 240), 0);
					num = ((int)num2 * -1988126145) ^ -2051481845;
					continue;
				case 19u:
					base.nextCaption.set_SmoothingMode((SmoothingMode)2);
					num = (int)(num2 * 1059633073) ^ -714759706;
					continue;
				case 18u:
					num = (int)((num2 * 350854250) ^ 0x70FE4310);
					continue;
				case 17u:
					num = ((int)num2 * -580812084) ^ -1535398718;
					continue;
				case 16u:
					base.nextCaption.DrawLine(new Pen(Color.FromArgb(190, 232, 109)), 2, 1, checked(((Control)this).get_Width() - 3), 1);
					num = ((int)num2 * -770521450) ^ 0x5EB40B74;
					continue;
				case 15u:
					val4 = new LinearGradientBrush(((Control)this).get_ClientRectangle(), Color.FromArgb(125, 171, 25), Color.FromArgb(142, 192, 40), (LinearGradientMode)1);
					num = ((int)num2 * -1307510260) ^ 0x1F3B5B8;
					continue;
				case 14u:
					val5 = new Pen(Color.FromArgb(120, 159, 22), 1f);
					num = -972318704;
					continue;
				case 13u:
					switch (nextCaption)
					{
					case FormList.propStorePosition:
						break;
					default:
						goto IL_0142;
					case FormList.nextCaption:
						goto IL_0154;
					case FormList.parentLog:
						goto IL_0178;
					}
					goto case 14u;
				case 2u:
					goto IL_0154;
				case 8u:
					goto IL_0178;
				case 11u:
					JoinBookmark((HorizontalAlignment)2, Color.FromArgb(250, 250, 250), 1);
					num = (int)((num2 * 1891211700) ^ 0x2541C16B);
					continue;
				case 9u:
					base.nextCaption.DrawLine(new Pen(Color.FromArgb(190, 232, 109)), 2, 1, checked(((Control)this).get_Width() - 3), 1);
					JoinBookmark((HorizontalAlignment)2, Color.FromArgb(240, 240, 240), -1);
					num = (int)((num2 * 1370113480) ^ 0x42442276);
					continue;
				case 7u:
				{
					Graphics obj5 = base.nextCaption;
					Pen obj6 = val6;
					Rectangle rectangle = checked(new Rectangle(0, 0, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 1));
					obj5.DrawPath(obj6, ProjectContext.ToggleDatabase(rectangle, 3));
					num = (int)(num2 * 1450581794) ^ -1120554338;
					continue;
				}
				case 6u:
					num = ((int)num2 * -1056312465) ^ 0x73D47975;
					continue;
				case 5u:
					base.nextCaption.Clear(((Control)this).get_BackColor());
					num = (int)((num2 * 2013301547) ^ 0x31AA4A3C);
					continue;
				case 4u:
				{
					base.nextCaption.FillPath((Brush)(object)val4, ProjectContext.ToggleDatabase(((Control)this).get_ClientRectangle(), 4));
					Graphics obj3 = base.nextCaption;
					Pen obj4 = val5;
					Rectangle rectangle = checked(new Rectangle(0, 0, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 1));
					obj3.DrawPath(obj4, ProjectContext.ToggleDatabase(rectangle, 3));
					num = (int)(num2 * 908614399) ^ -948356653;
					continue;
				}
				case 3u:
				{
					LinearGradientBrush val3 = new LinearGradientBrush(((Control)this).get_ClientRectangle(), Color.FromArgb(165, 220, 59), Color.FromArgb(137, 191, 18), (LinearGradientMode)1);
					base.nextCaption.FillPath((Brush)(object)val3, ProjectContext.ToggleDatabase(((Control)this).get_ClientRectangle(), 4));
					num = ((int)num2 * -1375799410) ^ -1596914882;
					continue;
				}
				case 1u:
					base.nextCaption.DrawLine(new Pen(Color.FromArgb(142, 172, 30)), 2, 1, checked(((Control)this).get_Width() - 3), 1);
					num = (int)((num2 * 1552283404) ^ 0xC53B54E);
					continue;
				case 0u:
				{
					LinearGradientBrush val = new LinearGradientBrush(((Control)this).get_ClientRectangle(), Color.FromArgb(157, 209, 57), Color.FromArgb(130, 181, 18), (LinearGradientMode)1);
					base.nextCaption.FillPath((Brush)(object)val, ProjectContext.ToggleDatabase(((Control)this).get_ClientRectangle(), 4));
					Graphics obj = base.nextCaption;
					Pen obj2 = val2;
					Rectangle rectangle = checked(new Rectangle(0, 0, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 1));
					obj.DrawPath(obj2, ProjectContext.ToggleDatabase(rectangle, 3));
					num = ((int)num2 * -382101681) ^ -572525307;
					continue;
				}
				case 10u:
					break;
				default:
					{
						((Control)this).set_Cursor(Cursors.get_Hand());
						return;
					}
					IL_0178:
					val6 = new Pen(Color.FromArgb(120, 159, 22), 1f);
					num = -1503197409;
					continue;
					IL_0154:
					val2 = new Pen(Color.FromArgb(120, 159, 22), 1f);
					num = -1815912603;
					continue;
					IL_0142:
					num = ((int)num2 * -532140728) ^ 0x581E7F9;
					continue;
				}
				break;
			}
		}
	}
}
