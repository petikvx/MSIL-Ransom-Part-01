using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace fbab6880a695;

internal class TemplateQueue : FileLayout
{
	private new int nextCaption;

	private new bool nextCaption;

	private bool parentLog;

	private int parentLog;

	public new bool JoinBookmark
	{
		get
		{
			return this.parentLog;
		}
		set
		{
			this.parentLog = value;
			while (true)
			{
				int num = 121705792;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x3536366u) % 3u)
					{
					case 1u:
						goto IL_0009;
					default:
						return;
					case 0u:
						break;
					case 2u:
						return;
					}
					break;
					IL_0009:
					((Control)this).Invalidate();
					num = ((int)num2 * -667760274) ^ 0x26F9FBDA;
				}
			}
		}
	}

	public new bool ViewComponent
	{
		get
		{
			bool result = nextCaption;
			while (true)
			{
				int num = 975210082;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x639F9EEu) % 3u)
					{
					case 1u:
						goto IL_0009;
					case 2u:
						break;
					default:
						return result;
					}
					break;
					IL_0009:
					num = (int)((num2 * 1966112957) ^ 0x254738BB);
				}
			}
		}
		set
		{
			nextCaption = value;
			((Control)this).Invalidate();
		}
	}

	public new int JoinBookmark
	{
		get
		{
			return this.nextCaption;
		}
		set
		{
			while (true)
			{
				int num = -1131137237;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xECE69460u) % 6u)
					{
					case 5u:
						parentLog = value;
						num = (int)((num2 * 264503329) ^ 0x7B3DF933);
						continue;
					case 3u:
					{
						int num3;
						int num4;
						if (value < parentLog)
						{
							num3 = -1256760910;
							num4 = -1256760910;
						}
						else
						{
							num3 = -1097772991;
							num4 = -1097772991;
						}
						num = num3 ^ ((int)num2 * -221651661);
						continue;
					}
					case 2u:
						this.nextCaption = value;
						num = -1577418999;
						continue;
					case 1u:
						((Control)this).Invalidate();
						num = ((int)num2 * -742208003) ^ -1460045955;
						continue;
					default:
						return;
					case 0u:
						break;
					case 4u:
						return;
					}
					break;
				}
			}
		}
	}

	public new int ViewComponent
	{
		get
		{
			return parentLog;
		}
		set
		{
			int num = value;
			while (true)
			{
				int num2 = -404929452;
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num2 ^ 0xAF39E119u) % 6u)
					{
					case 5u:
					{
						int num4;
						int num5;
						if (num <= this.nextCaption)
						{
							num4 = -485487017;
							num5 = -485487017;
						}
						else
						{
							num4 = -805633354;
							num5 = -805633354;
						}
						num2 = num4 ^ ((int)num3 * -793542386);
						continue;
					}
					case 4u:
						parentLog = value;
						num2 = -2043431937;
						continue;
					case 1u:
						value = this.nextCaption;
						num2 = (int)(num3 * 2135143912) ^ -958329143;
						continue;
					case 0u:
						((Control)this).Invalidate();
						num2 = ((int)num3 * -904357958) ^ -207584841;
						continue;
					default:
						return;
					case 3u:
						break;
					case 2u:
						return;
					}
					break;
				}
			}
		}
	}

	public TemplateQueue()
	{
		this.parentLog = true;
		ViewComponent = 0;
		JoinBookmark = 100;
		JoinBookmark();
	}

	public override void DisposeDatabase()
	{
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected O, but got Unknown
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected O, but got Unknown
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected O, but got Unknown
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Expected O, but got Unknown
		//IL_0233: Unknown result type (might be due to invalid IL or missing references)
		//IL_025f: Expected O, but got Unknown
		//IL_02c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02df: Expected O, but got Unknown
		//IL_03b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ba: Expected O, but got Unknown
		//IL_04f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_051c: Expected O, but got Unknown
		//IL_0566: Unknown result type (might be due to invalid IL or missing references)
		//IL_056d: Expected O, but got Unknown
		//IL_0661: Unknown result type (might be due to invalid IL or missing references)
		//IL_067a: Expected O, but got Unknown
		//IL_06a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a6: Expected O, but got Unknown
		//IL_06e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e9: Expected O, but got Unknown
		//IL_0754: Unknown result type (might be due to invalid IL or missing references)
		//IL_075b: Expected O, but got Unknown
		//IL_0794: Unknown result type (might be due to invalid IL or missing references)
		//IL_079a: Expected O, but got Unknown
		//IL_085b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0870: Expected O, but got Unknown
		base.nextCaption.set_SmoothingMode((SmoothingMode)2);
		Pen val7 = default(Pen);
		int num5 = default(int);
		Pen val6 = default(Pen);
		Pen val9 = default(Pen);
		LinearGradientBrush val10 = default(LinearGradientBrush);
		Pen val3 = default(Pen);
		while (true)
		{
			int num = -1500057549;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9C14E3AAu) % 29u)
				{
				case 28u:
				{
					int num8;
					if (this.ViewComponent)
					{
						num = -1984222687;
						num8 = -1984222687;
					}
					else
					{
						num = -735130412;
						num8 = -735130412;
					}
					continue;
				}
				case 27u:
				{
					val7 = new Pen(Color.FromArgb(34, 112, 171), 1f);
					LinearGradientBrush val8 = new LinearGradientBrush(((Control)this).get_ClientRectangle(), Color.FromArgb(51, 159, 231), Color.FromArgb(33, 128, 206), (LinearGradientMode)1);
					Graphics obj8 = base.nextCaption;
					Rectangle rectangle = checked(new Rectangle(2, num5 + 3, ((Control)this).get_Width() - 5, (int)Math.Round((double)parentLog / (double)this.nextCaption * (double)((Control)this).get_Height()) - 6));
					obj8.FillPath((Brush)(object)val8, ProjectContext.ToggleDatabase(rectangle, 4));
					num = (int)((num2 * 402223828) ^ 0x17F82986);
					continue;
				}
				case 26u:
				{
					Pen val = new Pen(Color.FromArgb(34, 112, 171), 1f);
					LinearGradientBrush val2 = new LinearGradientBrush(((Control)this).get_ClientRectangle(), Color.FromArgb(51, 159, 231), Color.FromArgb(33, 128, 206), (LinearGradientMode)1);
					Graphics obj = base.nextCaption;
					checked
					{
						Rectangle rectangle = new Rectangle(2, num5 + 3, ((Control)this).get_Width() - 5, (int)Math.Round((double)parentLog / (double)this.nextCaption * (double)((Control)this).get_Height()) - 6);
						obj.FillPath((Brush)(object)val2, ProjectContext.ToggleDatabase(rectangle, 4));
						Graphics obj2 = base.nextCaption;
						rectangle = new Rectangle(2, num5 + 3, ((Control)this).get_Width() - 5, (int)Math.Round((double)parentLog / (double)this.nextCaption * (double)((Control)this).get_Height()) - 6);
						obj2.DrawPath(val, ProjectContext.ToggleDatabase(rectangle, 3));
					}
					num = (int)(num2 * 1175999291) ^ -693419663;
					continue;
				}
				case 25u:
					checked
					{
						JoinBookmark(Color.FromArgb(50, Color.White), Color.Transparent, 4, num5 + 3, 10, (int)Math.Round((double)parentLog / (double)this.nextCaption * (double)((Control)this).get_Height()) - 7, 270f);
					}
					num = ((int)num2 * -1019816224) ^ 0x4B994B2;
					continue;
				case 24u:
					base.nextCaption.DrawLine(new Pen(Color.FromArgb(90, 131, 197, 241)), 4, 3, checked((int)Math.Round((double)parentLog / (double)this.nextCaption * (double)((Control)this).get_Width()) - 7), 3);
					num = ((int)num2 * -1783105269) ^ 0x4978803B;
					continue;
				case 23u:
					num5 = checked(((Control)this).get_Height() - (int)Math.Round((double)parentLog / (double)this.nextCaption * (double)((Control)this).get_Width()));
					num = (int)(num2 * 1861469901) ^ -527903501;
					continue;
				case 22u:
					checked
					{
						base.nextCaption.DrawLine(new Pen(Color.FromArgb(90, 131, 197, 241)), 4, num5 + 4, ((Control)this).get_Width() - 6, num5 + 4);
					}
					num = (int)((num2 * 1131927538) ^ 0x206862B3);
					continue;
				case 21u:
				{
					Graphics obj11 = base.nextCaption;
					Pen obj12 = val6;
					Rectangle rectangle = checked(new Rectangle(0, 0, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 1));
					obj11.DrawPath(obj12, ProjectContext.ToggleDatabase(rectangle, 3));
					num = ((int)num2 * -1456098007) ^ -1399111126;
					continue;
				}
				case 20u:
				{
					Graphics obj9 = base.nextCaption;
					Pen obj10 = val9;
					Rectangle rectangle = checked(new Rectangle(2, 2, (int)Math.Round((double)parentLog / (double)this.nextCaption * (double)((Control)this).get_Width()) - 6, ((Control)this).get_Height() - 5));
					obj9.DrawPath(obj10, ProjectContext.ToggleDatabase(rectangle, 3));
					num = ((int)num2 * -335056975) ^ -87043000;
					continue;
				}
				case 19u:
					val10 = new LinearGradientBrush(((Control)this).get_ClientRectangle(), Color.FromArgb(51, 159, 231), Color.FromArgb(33, 128, 206), (LinearGradientMode)1);
					num = (int)(num2 * 851114939) ^ -392928842;
					continue;
				case 18u:
				{
					int num9;
					if (this.parentLog)
					{
						num = -2096898162;
						num9 = -2096898162;
					}
					else
					{
						num = -1892230409;
						num9 = -1892230409;
					}
					continue;
				}
				case 17u:
					checked
					{
						JoinBookmark(Color.FromArgb(60, Color.White), Color.Transparent, 3, 3, (int)Math.Round((double)parentLog / (double)this.nextCaption * (double)((Control)this).get_Width()) - 7, (int)Math.Round((double)((Control)this).get_Height() / 2.0 - 3.0), 0f);
					}
					num = (int)(num2 * 887408714) ^ -1303225351;
					continue;
				case 16u:
				{
					int num13;
					int num14;
					if (this.ViewComponent)
					{
						num13 = 1552868925;
						num14 = 1552868925;
					}
					else
					{
						num13 = 2085627883;
						num14 = 2085627883;
					}
					num = num13 ^ (int)(num2 * 2025802540);
					continue;
				}
				case 13u:
				{
					Graphics obj13 = base.nextCaption;
					LinearGradientBrush obj14 = val10;
					checked
					{
						Rectangle rectangle = new Rectangle(2, 2, (int)Math.Round((double)parentLog / (double)this.nextCaption * (double)((Control)this).get_Width()) - 6, ((Control)this).get_Height() - 5);
						obj13.FillPath((Brush)(object)obj14, ProjectContext.ToggleDatabase(rectangle, 4));
						base.nextCaption.DrawLine(new Pen(Color.FromArgb(90, 131, 197, 241)), 4, 3, (int)Math.Round((double)parentLog / (double)this.nextCaption * (double)((Control)this).get_Width()) - 7, 3);
					}
					num = ((int)num2 * -624892978) ^ -1112251698;
					continue;
				}
				case 12u:
				{
					int num12;
					if (this.ViewComponent)
					{
						num = -2096898162;
						num12 = -2096898162;
					}
					else
					{
						num = -234751757;
						num12 = -234751757;
					}
					continue;
				}
				case 11u:
					val9 = new Pen(Color.FromArgb(34, 112, 171), 1f);
					num = ((int)num2 * -799932618) ^ -1228933507;
					continue;
				case 10u:
				{
					int num10;
					int num11;
					if (this.parentLog)
					{
						num10 = 880780120;
						num11 = 880780120;
					}
					else
					{
						num10 = 167255591;
						num11 = 167255591;
					}
					num = num10 ^ (int)(num2 * 1894176110);
					continue;
				}
				case 9u:
				{
					num5 = checked(((Control)this).get_Height() - (int)Math.Round((double)parentLog / (double)this.nextCaption * (double)((Control)this).get_Height()));
					int num6;
					int num7;
					if (!this.ViewComponent)
					{
						num6 = -139852329;
						num7 = -139852329;
					}
					else
					{
						num6 = -1978791652;
						num7 = -1978791652;
					}
					num = num6 ^ (int)(num2 * 71610145);
					continue;
				}
				case 8u:
				{
					Graphics obj6 = base.nextCaption;
					Pen obj7 = val7;
					checked
					{
						Rectangle rectangle = new Rectangle(2, num5 + 3, ((Control)this).get_Width() - 5, (int)Math.Round((double)parentLog / (double)this.nextCaption * (double)((Control)this).get_Height()) - 6);
						obj6.DrawPath(obj7, ProjectContext.ToggleDatabase(rectangle, 3));
						base.nextCaption.DrawLine(new Pen(Color.FromArgb(90, 131, 197, 241)), 4, num5 + 4, ((Control)this).get_Width() - 6, num5 + 4);
					}
					num = (int)((num2 * 377982570) ^ 0x124AF8D1);
					continue;
				}
				case 7u:
					val6 = new Pen(Color.FromArgb(34, 112, 171), 1f);
					num = ((int)num2 * -1799705505) ^ -785276029;
					continue;
				case 6u:
				{
					LinearGradientBrush val5 = new LinearGradientBrush(((Control)this).get_ClientRectangle(), Color.FromArgb(51, 159, 231), Color.FromArgb(33, 128, 206), (LinearGradientMode)1);
					Graphics obj5 = base.nextCaption;
					Rectangle rectangle = checked(new Rectangle(2, 2, (int)Math.Round((double)parentLog / (double)this.nextCaption * (double)((Control)this).get_Width()) - 6, ((Control)this).get_Height() - 5));
					obj5.FillPath((Brush)(object)val5, ProjectContext.ToggleDatabase(rectangle, 4));
					num = ((int)num2 * -2069652799) ^ 0x5A0BA3A7;
					continue;
				}
				case 5u:
					val3 = new Pen(Color.FromArgb(34, 112, 171), 1f);
					num = ((int)num2 * -225568100) ^ -813669281;
					continue;
				case 4u:
				{
					LinearGradientBrush val4 = new LinearGradientBrush(((Control)this).get_ClientRectangle(), Color.FromArgb(31, 119, 181), Color.FromArgb(33, 128, 206), (LinearGradientMode)1);
					base.nextCaption.FillPath((Brush)(object)val4, ProjectContext.ToggleDatabase(((Control)this).get_ClientRectangle(), 4));
					num = ((int)num2 * -292466836) ^ -2644296;
					continue;
				}
				case 2u:
					base.nextCaption.Clear(Color.Transparent);
					num5 = 0;
					num = (int)((num2 * 711771179) ^ 0x4767E2FD);
					continue;
				case 1u:
				{
					Graphics obj3 = base.nextCaption;
					Pen obj4 = val3;
					Rectangle rectangle = checked(new Rectangle(2, 2, (int)Math.Round((double)parentLog / (double)this.nextCaption * (double)((Control)this).get_Width()) - 6, ((Control)this).get_Height() - 5));
					obj3.DrawPath(obj4, ProjectContext.ToggleDatabase(rectangle, 3));
					num = (int)(num2 * 553610407) ^ -973115895;
					continue;
				}
				case 0u:
				{
					base.nextCaption.DrawLine(new Pen(Color.FromArgb(65, 131, 197, 241)), 2, 1, checked(((Control)this).get_Width() - 3), 1);
					int num3;
					int num4;
					if (parentLog <= 1)
					{
						num3 = -1668263544;
						num4 = -1668263544;
					}
					else
					{
						num3 = -898035017;
						num4 = -898035017;
					}
					num = num3 ^ (int)(num2 * 793397757);
					continue;
				}
				default:
					return;
				case 15u:
					break;
				case 3u:
				case 14u:
					return;
				}
				break;
			}
		}
	}

	public void ExtractDrive(int nextCaption)
	{
		if (checked(ViewComponent + nextCaption) > JoinBookmark)
		{
			goto IL_0010;
		}
		goto IL_0064;
		IL_0064:
		int num;
		checked
		{
			ViewComponent += nextCaption;
			num = -1389552214;
			goto IL_003f;
		}
		IL_003f:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0xFCDEF6EAu) % 5u)
			{
			case 4u:
				break;
			case 1u:
				ViewComponent = JoinBookmark;
				num = (int)((num2 * 1264162165) ^ 0x2E99BEBD);
				continue;
			case 0u:
				num = (int)((num2 * 1444575624) ^ 0x4E6AC18A);
				continue;
			default:
				return;
			case 2u:
				goto IL_0064;
			case 3u:
				return;
			}
			break;
		}
		goto IL_0010;
		IL_0010:
		num = -2067609587;
		goto IL_003f;
	}
}
