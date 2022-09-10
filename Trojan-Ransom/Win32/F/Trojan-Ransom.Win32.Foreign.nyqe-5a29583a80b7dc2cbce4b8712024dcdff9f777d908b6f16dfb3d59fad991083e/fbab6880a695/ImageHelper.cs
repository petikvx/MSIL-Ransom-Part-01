using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace fbab6880a695;

internal class ImageHelper : DialogType
{
	private new bool nextCaption;

	private new int nextCaption;

	private int parentLog;

	private new Size nextCaption;

	public new bool DisconnectPlugin
	{
		get
		{
			return this.nextCaption;
		}
		set
		{
			this.nextCaption = value;
			((Control)this).Invalidate();
		}
	}

	public new Size DisconnectPlugin
	{
		get
		{
			return nextCaption;
		}
		set
		{
			nextCaption = value;
			((Control)this).Invalidate();
		}
	}

	public ImageHelper()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected O, but got Unknown
		while (true)
		{
			int num = 1470888433;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x759328EAu) % 7u)
				{
				case 6u:
					((DialogType)this).DisconnectPlugin();
					num = ((int)num2 * -1884296576) ^ -719088981;
					continue;
				case 4u:
					((Control)this).add_MouseDown((MouseEventHandler)delegate
					{
						DisconnectPlugin();
						while (true)
						{
							int num3 = -1168770794;
							while (true)
							{
								uint num4;
								switch ((num4 = (uint)num3 ^ 0xB1A38768u) % 3u)
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
								num3 = (int)((num4 * 1864301771) ^ 0x54E2CE28);
							}
						}
					});
					num = ((int)num2 * -435315632) ^ 0xFCF3DC6;
					continue;
				case 2u:
				{
					Size size = new Size(5, 30);
					((Control)this).set_MinimumSize(size);
					this.nextCaption = true;
					num = ((int)num2 * -1167325892) ^ 0x3AD39CCC;
					continue;
				}
				case 1u:
					((Control)this).add_Resize((EventHandler)DisconnectPlugin);
					num = ((int)num2 * -678360223) ^ -1829306796;
					continue;
				case 0u:
				{
					Size size = new Size(90, 30);
					((Control)this).set_Size(size);
					num = (int)((num2 * 194779617) ^ 0x402DBC5);
					continue;
				}
				default:
					return;
				case 5u:
					break;
				case 3u:
					return;
				}
				break;
			}
		}
	}

	public override void ToggleDatabase()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected O, but got Unknown
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Expected O, but got Unknown
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Expected O, but got Unknown
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Expected O, but got Unknown
		//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Expected O, but got Unknown
		//IL_0203: Unknown result type (might be due to invalid IL or missing references)
		//IL_021f: Expected O, but got Unknown
		//IL_024b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0261: Expected O, but got Unknown
		//IL_028e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0299: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b2: Expected O, but got Unknown
		//IL_02b2: Expected O, but got Unknown
		//IL_02dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f0: Expected O, but got Unknown
		//IL_035e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0373: Expected O, but got Unknown
		//IL_03b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d4: Expected O, but got Unknown
		//IL_03d4: Expected O, but got Unknown
		((Control)this).set_Font(new Font(PathSet.nextCaption[9], 10f));
		((Control)this).set_ForeColor(Color.FromArgb(40, 40, 40));
		while (true)
		{
			int num = 1454080966;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6642B1C3u) % 16u)
				{
				case 15u:
					num = ((int)num2 * -1325995061) ^ -806540079;
					continue;
				case 14u:
				{
					base.nextCaption.Clear(Color.FromArgb(245, 245, 245));
					Graphics obj = base.nextCaption;
					SolidBrush val = new SolidBrush(Color.FromArgb(231, 231, 231));
					Rectangle rectangle = new Rectangle(0, 0, ((Control)this).get_Width(), 30);
					obj.FillRectangle((Brush)val, rectangle);
					num = (int)((num2 * 664398342) ^ 0x6FC9F07A);
					continue;
				}
				case 13u:
					checked
					{
						base.nextCaption.DrawLine(new Pen(Color.FromArgb(237, 237, 237)), 1, 1, ((Control)this).get_Width() - 2, 1);
						base.nextCaption.DrawRectangle(new Pen(Color.FromArgb(214, 214, 214)), 0, 0, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 1);
						base.nextCaption.DrawRectangle(new Pen(Color.FromArgb(214, 214, 214)), 0, 0, ((Control)this).get_Width() - 1, 30);
						Size size = new Size(((Control)this).get_Width(), 30);
						((Control)this).set_Size(size);
					}
					num = (int)(num2 * 1307759267) ^ -268401828;
					continue;
				case 12u:
					((Control)this).set_Size(nextCaption);
					num = (int)(num2 * 523952603) ^ -220826697;
					continue;
				case 11u:
				{
					base.nextCaption.Clear(Color.FromArgb(245, 245, 245));
					Graphics obj2 = base.nextCaption;
					SolidBrush val2 = new SolidBrush(Color.FromArgb(231, 231, 231));
					Rectangle rectangle = new Rectangle(0, 0, ((Control)this).get_Width(), 30);
					obj2.FillRectangle((Brush)val2, rectangle);
					num = ((int)num2 * -568224776) ^ 0x39D33BB8;
					continue;
				}
				case 10u:
					checked
					{
						base.nextCaption.DrawRectangle(new Pen(Color.FromArgb(214, 214, 214)), 0, 0, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 1);
					}
					num = ((int)num2 * -1384404760) ^ 0x17CA6CCA;
					continue;
				case 9u:
					base.nextCaption.DrawRectangle(new Pen(Color.FromArgb(214, 214, 214)), 0, 0, checked(((Control)this).get_Width() - 1), 30);
					num = ((int)num2 * -936000721) ^ 0x6FFC4B88;
					continue;
				case 8u:
					base.nextCaption.DrawString(PathSet.nextCaption[12], new Font(PathSet.nextCaption[11], 12f), (Brush)new SolidBrush(((Control)this).get_ForeColor()), (float)checked(((Control)this).get_Width() - 25), 5f);
					num = ((int)num2 * -1021485155) ^ 0x62BF45CC;
					continue;
				case 7u:
					base.nextCaption.DrawString(((Control)this).get_Text(), ((Control)this).get_Font(), (Brush)new SolidBrush(((Control)this).get_ForeColor()), 7f, 6f);
					num = 1411196197;
					continue;
				case 5u:
				{
					int num3;
					int num4;
					if (!this.nextCaption)
					{
						num3 = 1838783698;
						num4 = 1838783698;
					}
					else
					{
						num3 = 1072974775;
						num4 = 1072974775;
					}
					num = num3 ^ ((int)num2 * -508549392);
					continue;
				}
				case 4u:
					base.nextCaption.set_SmoothingMode((SmoothingMode)4);
					num = (int)(num2 * 1769897470) ^ -1389563344;
					continue;
				case 3u:
					base.nextCaption.DrawLine(new Pen(Color.FromArgb(237, 237, 237)), 1, 1, checked(((Control)this).get_Width() - 2), 1);
					num = ((int)num2 * -417810500) ^ -436516019;
					continue;
				case 1u:
					base.nextCaption.set_SmoothingMode((SmoothingMode)4);
					num = 1952987645;
					continue;
				case 0u:
					base.nextCaption.DrawString(PathSet.nextCaption[10], new Font(PathSet.nextCaption[11], 12f), (Brush)new SolidBrush(((Control)this).get_ForeColor()), (float)checked(((Control)this).get_Width() - 25), 5f);
					num = ((int)num2 * -861037411) ^ -2061866932;
					continue;
				default:
					return;
				case 2u:
					break;
				case 6u:
					return;
				}
				break;
			}
		}
	}

	private new void DisconnectPlugin(object sender, EventArgs e)
	{
		if (!this.nextCaption)
		{
			return;
		}
		while (true)
		{
			int num = -1200416152;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x965C023Fu) % 4u)
				{
				case 3u:
					nextCaption = ((Control)this).get_Size();
					num = (int)(num2 * 1480190264) ^ -195916885;
					continue;
				case 0u:
					num = (int)((num2 * 1730401833) ^ 0x5CA98CCA);
					continue;
				default:
					return;
				case 2u:
					break;
				case 1u:
					return;
				}
				break;
			}
		}
	}

	protected override void RebuildSolution(MouseEventArgs nextCaption)
	{
		((Control)this).OnMouseMove(nextCaption);
		while (true)
		{
			int num = -689406380;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xDA2F7DE5u) % 4u)
				{
				case 2u:
					((Control)this).Invalidate();
					num = ((int)num2 * -1088181256) ^ -465467051;
					continue;
				case 1u:
					this.nextCaption = nextCaption.get_X();
					parentLog = nextCaption.get_Y();
					num = (int)(num2 * 1749959005) ^ -1518652358;
					continue;
				default:
					return;
				case 3u:
					break;
				case 0u:
					return;
				}
				break;
			}
		}
	}

	public new void DisconnectPlugin()
	{
		if (this.nextCaption < checked(((Control)this).get_Width() - 22))
		{
			return;
		}
		while (true)
		{
			int num = -591878783;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC42B7CA0u) % 8u)
				{
				case 7u:
					num = ((int)num2 * -1402707093) ^ 0x30091EAD;
					continue;
				case 5u:
					switch (this.DisconnectPlugin)
					{
					case false:
						goto IL_004a;
					case true:
						goto IL_0058;
					}
					num = ((int)num2 * -795510821) ^ -267422064;
					continue;
				case 2u:
					goto IL_004a;
				case 3u:
					goto IL_0058;
				case 4u:
					num = ((int)num2 * -824812201) ^ -1043596364;
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (parentLog <= 30)
					{
						num3 = -331895560;
						num4 = -331895560;
					}
					else
					{
						num3 = -499114803;
						num4 = -499114803;
					}
					num = num3 ^ ((int)num2 * -922358371);
					continue;
				}
				default:
					return;
				case 6u:
					break;
				case 0u:
					return;
					IL_004a:
					this.DisconnectPlugin = true;
					num = -82531600;
					continue;
					IL_0058:
					this.DisconnectPlugin = false;
					num = -1801595140;
					continue;
				}
				break;
			}
		}
	}

	[SpecialName]
	[CompilerGenerated]
	[DebuggerStepThrough]
	private new void DisconnectPlugin(object sender, MouseEventArgs e)
	{
		DisconnectPlugin();
		while (true)
		{
			int num = -1168770794;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB1A38768u) % 3u)
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
				num = (int)((num2 * 1864301771) ^ 0x54E2CE28);
			}
		}
	}
}
