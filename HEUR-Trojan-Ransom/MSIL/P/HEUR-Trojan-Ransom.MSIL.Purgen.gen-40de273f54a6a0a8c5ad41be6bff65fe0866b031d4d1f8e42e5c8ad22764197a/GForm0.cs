using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

[DesignerGenerated]
public class GForm0 : Form
{
	private IContainer icontainer_0;

	[AccessedThroughProperty("MemoryCleaner")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Timer timer_0;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("PictureBox1")]
	[CompilerGenerated]
	private PictureBox pictureBox_0;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Introduce")]
	private Timer timer_1;

	private bool bool_0;

	private float float_0;

	private int int_0;

	internal virtual Timer Timer_0
	{
		[CompilerGenerated]
		get
		{
			return timer_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler_ = method_2;
			Timer val = default(Timer);
			while (true)
			{
				int num = 2032838975;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x2CD1DC8u) % 7u)
					{
					case 5u:
					{
						val = timer_0;
						int num5;
						int num6;
						if (val != null)
						{
							num5 = 1705847170;
							num6 = 1705847170;
						}
						else
						{
							num5 = 264261332;
							num6 = 264261332;
						}
						num = num5 ^ ((int)num2 * -510665286);
						continue;
					}
					case 4u:
						GForm0.smethod_34(val, eventHandler_);
						num = ((int)num2 * -372330409) ^ 0x5AD9CD16;
						continue;
					case 3u:
					{
						val = timer_0;
						int num3;
						int num4;
						if (val != null)
						{
							num3 = 212650286;
							num4 = 212650286;
						}
						else
						{
							num3 = 1784163270;
							num4 = 1784163270;
						}
						num = num3 ^ (int)(num2 * 1377555371);
						continue;
					}
					case 2u:
						GForm0.smethod_33(val, eventHandler_);
						num = ((int)num2 * -1111501498) ^ 0x2DCE70CA;
						continue;
					case 1u:
						timer_0 = value;
						num = 1347924815;
						continue;
					default:
						return;
					case 6u:
						break;
					case 0u:
						return;
					}
					break;
				}
			}
		}
	}

	internal virtual PictureBox PictureBox_0
	{
		[CompilerGenerated]
		get
		{
			return pictureBox_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			pictureBox_0 = value;
		}
	}

	internal virtual Timer Timer_1
	{
		[CompilerGenerated]
		get
		{
			return timer_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler_ = method_5;
			Timer val = default(Timer);
			while (true)
			{
				int num = -1843075868;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xA257E9E7u) % 8u)
					{
					case 7u:
						val = timer_1;
						num = ((int)num2 * -1077395688) ^ -1851550966;
						continue;
					case 6u:
						GForm0.smethod_34(val, eventHandler_);
						num = ((int)num2 * -737526329) ^ -1365627287;
						continue;
					case 5u:
					{
						int num5;
						int num6;
						if (val != null)
						{
							num5 = 1947401345;
							num6 = 1947401345;
						}
						else
						{
							num5 = 1112689443;
							num6 = 1112689443;
						}
						num = num5 ^ ((int)num2 * -1397572448);
						continue;
					}
					case 3u:
					{
						val = timer_1;
						int num3;
						int num4;
						if (val == null)
						{
							num3 = 187152844;
							num4 = 187152844;
						}
						else
						{
							num3 = 188628503;
							num4 = 188628503;
						}
						num = num3 ^ ((int)num2 * -386250922);
						continue;
					}
					case 2u:
						GForm0.smethod_33(val, eventHandler_);
						num = (int)(num2 * 746370073) ^ -61675668;
						continue;
					case 1u:
						timer_1 = value;
						num = -1069655456;
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

	public GForm0()
	{
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected O, but got Unknown
		while (true)
		{
			int num = -1685663949;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x92E16034u) % 10u)
				{
				case 9u:
					GForm0.smethod_1((Form)(object)this, (EventHandler)method_1);
					num = ((int)num2 * -490070938) ^ -12387842;
					continue;
				case 8u:
					num = ((int)num2 * -1753878174) ^ -1822373273;
					continue;
				case 7u:
					bool_0 = false;
					float_0 = 0.1f;
					num = ((int)num2 * -576869064) ^ 0x274E7182;
					continue;
				case 6u:
					GForm0.smethod_2((Form)(object)this, new FormClosingEventHandler(method_3));
					num = ((int)num2 * -358752813) ^ -1816414112;
					continue;
				case 4u:
					num = (int)((num2 * 2025084081) ^ 0x40BFE84);
					continue;
				case 3u:
					method_0();
					num = (int)(num2 * 283416479) ^ -180418818;
					continue;
				case 2u:
					int_0 = 0;
					num = (int)(num2 * 191551399) ^ -523132553;
					continue;
				case 1u:
					num = (int)((num2 * 623303890) ^ 0x3DCE07DD);
					continue;
				default:
					return;
				case 0u:
					break;
				case 5u:
					return;
				}
				break;
			}
		}
	}

	[DebuggerNonUserCode]
	void Form.Dispose(bool disposing)
	{
		try
		{
			while (true)
			{
				int num = 1299423163;
				while (true)
				{
					uint num2;
					int num3;
					switch ((num2 = (uint)num ^ 0x3983CF94u) % 5u)
					{
					case 4u:
						if (icontainer_0 != null)
						{
							num = 2057579588;
							num3 = 2057579588;
							continue;
						}
						goto IL_001b;
					case 3u:
						if (disposing)
						{
							num = ((int)num2 * -370426595) ^ 0x7E69D6F8;
							continue;
						}
						goto IL_001b;
					case 1u:
						GForm0.smethod_3((IDisposable)icontainer_0);
						num = ((int)num2 * -1445476042) ^ 0x15E4407E;
						continue;
					default:
						return;
					case 2u:
						break;
					case 0u:
						return;
						IL_001b:
						num = 169614750;
						num3 = 169614750;
						continue;
					}
					break;
				}
			}
		}
		finally
		{
			((Form)this).Dispose(disposing);
		}
	}

	[DebuggerStepThrough]
	private void method_0()
	{
		//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
		icontainer_0 = GForm0.smethod_4();
		while (true)
		{
			int num = 1348409453;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6F267E1Bu) % 37u)
				{
				case 36u:
					GForm0.smethod_25((Form)(object)this, (FormBorderStyle)1);
					num = ((int)num2 * -1634653957) ^ -1851728350;
					continue;
				case 35u:
					GForm0.smethod_7((ISupportInitialize)PictureBox_0);
					num = ((int)num2 * -842880487) ^ -879449290;
					continue;
				case 34u:
					GForm0.smethod_11((Control)(object)this, (ImageLayout)3);
					num = ((int)num2 * -1231921026) ^ 0x282FC25C;
					continue;
				case 33u:
					num = ((int)num2 * -495797680) ^ -586097721;
					continue;
				case 32u:
					GForm0.smethod_15(PictureBox_0, 0);
					num = ((int)num2 * -473413652) ^ -1113297864;
					continue;
				case 31u:
					((Control)this).set_DoubleBuffered(true);
					num = (int)((num2 * 368174184) ^ 0x7889D0F1);
					continue;
				case 29u:
					num = (int)(num2 * 1168800825) ^ -2055878243;
					continue;
				case 28u:
					num = (int)(num2 * 2011383777) ^ -693811666;
					continue;
				case 27u:
					PictureBox_0 = GForm0.smethod_6();
					num = (int)(num2 * 335694588) ^ -1681326532;
					continue;
				case 26u:
					GForm0.smethod_28((Control)(object)this, "Introduction");
					num = ((int)num2 * -290998010) ^ 0x19C94562;
					continue;
				case 25u:
					num = (int)((num2 * 1449078480) ^ 0x1A2AD128);
					continue;
				case 24u:
					GForm0.smethod_11((Control)(object)PictureBox_0, (ImageLayout)3);
					num = (int)((num2 * 33365092) ^ 0x5E5C71BD);
					continue;
				case 23u:
					GForm0.smethod_12((Control)(object)PictureBox_0, new Point(365, 415));
					num = ((int)num2 * -1385687963) ^ -1026009500;
					continue;
				case 22u:
					GForm0.smethod_13((Control)(object)PictureBox_0, "PictureBox1");
					num = ((int)num2 * -1096363790) ^ 0xB6DF20F;
					continue;
				case 21u:
					num = (int)(num2 * 1053673976) ^ -1359638069;
					continue;
				case 20u:
					Timer_1 = GForm0.smethod_5(icontainer_0);
					num = (int)((num2 * 1734097312) ^ 0x31120B75);
					continue;
				case 19u:
					GForm0.smethod_26((Form)(object)this, new Padding(4));
					GForm0.smethod_27((Form)(object)this, bool_1: false);
					num = ((int)num2 * -1527878146) ^ -51722424;
					continue;
				case 18u:
					num = ((int)num2 * -1188142149) ^ -986916442;
					continue;
				case 17u:
					GForm0.smethod_31((ISupportInitialize)PictureBox_0);
					num = ((int)num2 * -2101835213) ^ 0x11620EDB;
					continue;
				case 16u:
					GForm0.smethod_29((Form)(object)this, (FormStartPosition)1);
					GForm0.smethod_30((Form)(object)this, "The Omegle Game");
					num = ((int)num2 * -906717301) ^ -38727739;
					continue;
				case 15u:
					num = (int)(num2 * 659591860) ^ -1595246968;
					continue;
				case 14u:
					Timer_0 = GForm0.smethod_5(icontainer_0);
					num = (int)(num2 * 1647705596) ^ -1683735134;
					continue;
				case 13u:
					GForm0.smethod_22(GForm0.smethod_21((Control)(object)this), (Control)(object)PictureBox_0);
					num = ((int)num2 * -651709748) ^ 0x685ADCA8;
					continue;
				case 12u:
					num = ((int)num2 * -1431084812) ^ -172467977;
					continue;
				case 11u:
					GForm0.smethod_9(Timer_0, 1000);
					num = (int)((num2 * 1380871185) ^ 0x17B916F0);
					continue;
				case 9u:
					num = ((int)num2 * -1286660363) ^ 0x3B460A84;
					continue;
				case 8u:
					GForm0.smethod_10((Control)(object)PictureBox_0, Color.Transparent);
					num = (int)((num2 * 2126589354) ^ 0x2F9E0203);
					continue;
				case 7u:
					GForm0.smethod_16(PictureBox_0, bool_1: false);
					num = (int)(num2 * 1823897623) ^ -1053397487;
					continue;
				case 6u:
					GForm0.smethod_24((Control)(object)this, GForm0.smethod_23("Consolas", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 643721023) ^ 0x2C4AA316);
					continue;
				case 5u:
					GForm0.smethod_8((Control)(object)this);
					num = (int)((num2 * 1773304149) ^ 0x6E16224F);
					continue;
				case 4u:
					GForm0.smethod_32((Control)(object)this, bool_1: false);
					num = (int)((num2 * 1292663694) ^ 0x26610FA0);
					continue;
				case 3u:
					GForm0.smethod_18((ContainerControl)(object)this, (AutoScaleMode)1);
					GForm0.smethod_19((Form)(object)this, Color.White);
					num = ((int)num2 * -712341070) ^ 0x55336064;
					continue;
				case 2u:
					GForm0.smethod_9(Timer_1, 500);
					GForm0.smethod_17((ContainerControl)(object)this, new SizeF(10f, 22f));
					num = (int)(num2 * 1120409551) ^ -574260781;
					continue;
				case 1u:
					GForm0.smethod_20((Form)(object)this, new Size(1025, 638));
					num = ((int)num2 * -1767152635) ^ 0x729A7DC9;
					continue;
				case 0u:
					GForm0.smethod_14((Control)(object)PictureBox_0, new Size(302, 211));
					num = (int)((num2 * 833120791) ^ 0x55A58E12);
					continue;
				default:
					return;
				case 10u:
					break;
				case 30u:
					return;
				}
				break;
			}
		}
	}

	private void method_1(object sender, EventArgs e)
	{
		GForm0.smethod_36(GForm0.smethod_35(), ProcessPriorityClass.RealTime);
		while (true)
		{
			int num = -476940922;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC2AD94AEu) % 6u)
				{
				case 4u:
					num = (int)((num2 * 442723824) ^ 0x75F3F0B5);
					continue;
				case 3u:
					GClass1.smethod_0();
					GClass1.smethod_3().method_0();
					GForm0.smethod_41(Timer_1);
					num = (int)(num2 * 2024604180) ^ -747114574;
					continue;
				case 2u:
					GForm0.smethod_40((Control)(object)PictureBox_0, (Image)(object)smethod_0(GForm0.smethod_39(GForm0.smethod_38(GForm0.smethod_37(), "\\data\\Images\\marco_introduzione.png")), float_0));
					num = (int)(num2 * 1737345414) ^ -2120839245;
					continue;
				case 1u:
					GForm0.smethod_40((Control)(object)this, GForm0.smethod_39(GForm0.smethod_38(GForm0.smethod_37(), "\\data\\Images\\schermata_omegle.png")));
					num = ((int)num2 * -1607515157) ^ -1838556797;
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

	public static Bitmap smethod_0(Image image_0, float float_1)
	{
		Graphics graphics_ = default(Graphics);
		Bitmap val = default(Bitmap);
		ImageAttributes imageAttributes_ = default(ImageAttributes);
		Bitmap result = default(Bitmap);
		ColorMatrix colorMatrix_ = default(ColorMatrix);
		while (true)
		{
			int num = -955415588;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xFC992D85u) % 12u)
				{
				case 10u:
					GForm0.smethod_50(graphics_, image_0, new Rectangle(0, 0, GForm0.smethod_42((Image)(object)val), GForm0.smethod_43((Image)(object)val)), 0, 0, GForm0.smethod_42(image_0), GForm0.smethod_43(image_0), (GraphicsUnit)2, imageAttributes_);
					num = ((int)num2 * -1853934426) ^ 0x1D1EDA2B;
					continue;
				case 9u:
					result = val;
					num = (int)((num2 * 273734268) ^ 0x34F7C4BA);
					continue;
				case 7u:
					num = ((int)num2 * -81163439) ^ -1664866520;
					continue;
				case 6u:
					num = ((int)num2 * -2027175409) ^ 0x758337FC;
					continue;
				case 5u:
					val = GForm0.smethod_44(GForm0.smethod_42(image_0), GForm0.smethod_43(image_0));
					num = ((int)num2 * -1359770183) ^ 0x3D511D96;
					continue;
				case 4u:
					imageAttributes_ = GForm0.smethod_48();
					num = ((int)num2 * -1982702644) ^ 0x550B5E60;
					continue;
				case 3u:
					GForm0.smethod_51(graphics_);
					num = ((int)num2 * -330492371) ^ 0x76909797;
					continue;
				case 2u:
					graphics_ = GForm0.smethod_45((Image)(object)val);
					colorMatrix_ = GForm0.smethod_46();
					num = (int)(num2 * 1479222903) ^ -916613829;
					continue;
				case 1u:
					GForm0.smethod_49(imageAttributes_, colorMatrix_, (ColorMatrixFlag)0, (ColorAdjustType)1);
					num = ((int)num2 * -1126880202) ^ 0x509680A4;
					continue;
				case 0u:
					GForm0.smethod_47(colorMatrix_, float_1);
					num = ((int)num2 * -1916856855) ^ 0x61EEA1A9;
					continue;
				case 8u:
					break;
				default:
					return result;
				}
				break;
			}
		}
	}

	private void method_2(object sender, EventArgs e)
	{
		while (true)
		{
			int num = -525305592;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xBEE2FE7Du) % 4u)
				{
				case 2u:
					num = ((int)num2 * -394564197) ^ 0x76303444;
					continue;
				case 1u:
					GForm0.smethod_52();
					num = (int)((num2 * 1496332927) ^ 0x2FB726B0);
					continue;
				default:
					return;
				case 0u:
					break;
				case 3u:
					return;
				}
				break;
			}
		}
	}

	private void method_3(object sender, FormClosingEventArgs e)
	{
		bool flag = default(bool);
		while (true)
		{
			int num = 1027009895;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA3B0919u) % 7u)
				{
				case 6u:
					method_4();
					flag = !bool_0;
					num = ((int)num2 * -2005936337) ^ -1558093757;
					continue;
				case 5u:
					num = ((int)num2 * -41881909) ^ -1584340991;
					continue;
				case 4u:
					GForm0.smethod_53((CancelEventArgs)(object)e, bool_1: true);
					num = ((int)num2 * -1759919218) ^ 0x7CB2A915;
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = 1114673308;
						num4 = 1114673308;
					}
					else
					{
						num3 = 832903055;
						num4 = 832903055;
					}
					num = num3 ^ ((int)num2 * -1673244364);
					continue;
				}
				case 0u:
					num = 397100268;
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

	public void method_4()
	{
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Invalid comparison between Unknown and I4
		bool flag = default(bool);
		bool flag2 = default(bool);
		while (true)
		{
			int num = -1643903984;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC5442E65u) % 21u)
				{
				case 20u:
					num = (int)(num2 * 145712815) ^ -4008489;
					continue;
				case 19u:
					num = (int)((num2 * 221412636) ^ 0x1102C98A);
					continue;
				case 18u:
					GForm0.smethod_57(GForm0.smethod_35());
					num = (int)(num2 * 1942247911) ^ -376002937;
					continue;
				case 17u:
					num = -2111109459;
					continue;
				case 16u:
					GForm0.smethod_56((object)Timer_0);
					GForm0.smethod_56((object)bool_0);
					num = (int)(num2 * 709065463) ^ -171782041;
					continue;
				case 15u:
					num = ((int)num2 * -26718108) ^ 0x37190D05;
					continue;
				case 14u:
					flag = !bool_0;
					num = (int)(num2 * 17564099) ^ -1430743205;
					continue;
				case 13u:
					GForm0.smethod_55(Timer_0);
					num = (int)(num2 * 2104081102) ^ -495998524;
					continue;
				case 12u:
					GForm0.smethod_56((object)bool_0);
					num = ((int)num2 * -2130763496) ^ -1357232410;
					continue;
				case 11u:
					GForm0.smethod_56((object)Timer_0);
					num = (int)(num2 * 1359639692) ^ -959003452;
					continue;
				case 10u:
					GForm0.smethod_52();
					num = (int)(num2 * 627095812) ^ -1031543315;
					continue;
				case 9u:
				{
					int num5;
					int num6;
					if (!flag2)
					{
						num5 = -186881750;
						num6 = -186881750;
					}
					else
					{
						num5 = -51029956;
						num6 = -51029956;
					}
					num = num5 ^ ((int)num2 * -1742369592);
					continue;
				}
				case 8u:
					flag2 = (int)GForm0.smethod_54("Sei sicuro di voler uscire dal gioco?", "The Omegle Game", (MessageBoxButtons)4, (MessageBoxIcon)32) == 6;
					num = ((int)num2 * -824268914) ^ 0x47B441B8;
					continue;
				case 7u:
					num = -1214863752;
					continue;
				case 6u:
					num = ((int)num2 * -450346983) ^ 0x2CA88049;
					continue;
				case 5u:
					num = ((int)num2 * -457476580) ^ 0x15B7117E;
					continue;
				case 3u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = 2047038971;
						num4 = 2047038971;
					}
					else
					{
						num3 = 1735928856;
						num4 = 1735928856;
					}
					num = num3 ^ ((int)num2 * -756349526);
					continue;
				}
				case 2u:
					GForm0.smethod_55(Timer_0);
					num = (int)((num2 * 689701571) ^ 0x58FD46FA);
					continue;
				case 0u:
					GForm0.smethod_52();
					num = (int)((num2 * 1933054027) ^ 0x4458BD43);
					continue;
				default:
					return;
				case 4u:
					break;
				case 1u:
					return;
				}
				break;
			}
		}
	}

	private void method_5(object sender, EventArgs e)
	{
		if (int_0 <= 15)
		{
			goto IL_03f5;
		}
		goto IL_0568;
		IL_0568:
		bool flag = (int_0 >= 16) & (int_0 <= 20);
		int num = -1427552896;
		goto IL_04c5;
		IL_04c5:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0xCA47FEBFu) % 36u)
			{
			case 35u:
				checked
				{
					int_0++;
				}
				num = (int)(num2 * 702862390) ^ -1084011253;
				continue;
			case 34u:
			{
				PictureBox control_;
				GForm0.smethod_65((Control)(object)(control_ = PictureBox_0), checked(GForm0.smethod_64((Control)(object)control_) + 22));
				num = -1090070931;
				continue;
			}
			case 33u:
				num = ((int)num2 * -804422154) ^ -1213040096;
				continue;
			case 32u:
				break;
			case 31u:
				checked
				{
					int_0++;
				}
				num = (int)(num2 * 288777534) ^ -1158537384;
				continue;
			case 30u:
				num = ((int)num2 * -958546405) ^ -1070993243;
				continue;
			case 29u:
				num = ((int)num2 * -1414955575) ^ 0x3561A9CC;
				continue;
			case 28u:
				GForm0.smethod_40((Control)(object)PictureBox_0, GForm0.smethod_39(GForm0.smethod_38(GForm0.smethod_37(), "\\data\\Images\\marco_introduzione.png")));
				GForm0.smethod_12((Control)(object)PictureBox_0, checked(new Point((int)GForm0.smethod_61((double)((float)GForm0.smethod_59((Control)(object)PictureBox_0).X + GForm0.smethod_60() * 10f)), (int)GForm0.smethod_61((double)((float)GForm0.smethod_59((Control)(object)PictureBox_0).Y - GForm0.smethod_60() * 10f)))));
				num = ((int)num2 * -1338318080) ^ 0x674AD2FD;
				continue;
			case 26u:
				GForm0.smethod_52();
				num = (int)((num2 * 756763725) ^ 0x246B89F4);
				continue;
			case 25u:
				num = (int)(num2 * 1780262059) ^ -1208177901;
				continue;
			case 24u:
				num = (int)((num2 * 597818205) ^ 0x39874628);
				continue;
			case 23u:
				num = (int)((num2 * 284228734) ^ 0x6C6226E6);
				continue;
			case 22u:
				checked
				{
					int_0++;
				}
				num = (int)(num2 * 329724252) ^ -1645813237;
				continue;
			case 21u:
				num = ((int)num2 * -2062483313) ^ 0x87CC3CF;
				continue;
			case 20u:
				checked
				{
					int_0++;
				}
				num = ((int)num2 * -1640950392) ^ 0x3B5C63C8;
				continue;
			case 19u:
			{
				int num3;
				int num4;
				if (flag)
				{
					num3 = 1787570230;
					num4 = 1787570230;
				}
				else
				{
					num3 = 1767545142;
					num4 = 1767545142;
				}
				num = num3 ^ ((int)num2 * -552620117);
				continue;
			}
			case 18u:
			{
				ref float reference = ref float_0;
				reference = (float)((double)reference + 0.3);
				num = (int)((num2 * 1709787005) ^ 0x60CEC5E);
				continue;
			}
			case 17u:
			{
				PictureBox control_;
				GForm0.smethod_65((Control)(object)(control_ = PictureBox_0), checked(GForm0.smethod_64((Control)(object)control_) + 30));
				num = ((int)num2 * -836990827) ^ -122352262;
				continue;
			}
			case 16u:
				checked
				{
					int_0++;
				}
				num = ((int)num2 * -224670391) ^ -2019441574;
				continue;
			case 15u:
				goto IL_02be;
			case 14u:
				num = (int)(num2 * 589546609) ^ -1664034550;
				continue;
			case 13u:
				GForm0.smethod_12((Control)(object)PictureBox_0, new Point(512, 0));
				num = ((int)num2 * -2096746463) ^ 0x5FB402EF;
				continue;
			case 12u:
				GForm0.smethod_56((object)Timer_1);
				num = (int)((num2 * 1874513392) ^ 0x5168E129);
				continue;
			case 11u:
				goto IL_0351;
			case 10u:
				GClass1.smethod_3().method_4();
				num = (int)((num2 * 2017604516) ^ 0x917D991);
				continue;
			case 9u:
			{
				PictureBox control_;
				GForm0.smethod_63((Control)(object)(control_ = PictureBox_0), checked(GForm0.smethod_62((Control)(object)control_) + 30));
				num = ((int)num2 * -387844280) ^ 0x4D950047;
				continue;
			}
			case 8u:
				GForm0.smethod_56((object)int_0);
				num = (int)(num2 * 1974431233) ^ -1850522913;
				continue;
			case 7u:
				goto end_IL_04c5;
			case 6u:
				GForm0.smethod_40((Control)(object)PictureBox_0, GForm0.smethod_39(GForm0.smethod_38(GForm0.smethod_37(), "\\data\\Images\\marco_introduzione.png")));
				GForm0.smethod_55(Timer_1);
				num = ((int)num2 * -1981376378) ^ -175369384;
				continue;
			case 5u:
				GForm0.smethod_40((Control)(object)PictureBox_0, (Image)(object)smethod_0(GForm0.smethod_58((Control)(object)PictureBox_0), float_0));
				num = (int)(num2 * 1215647522) ^ -166787685;
				continue;
			case 4u:
				num = (int)((num2 * 1456572164) ^ 0x1F7BDF50);
				continue;
			case 3u:
				GForm0.smethod_56((object)float_0);
				num = (int)((num2 * 1242901849) ^ 0x541D4B18);
				continue;
			case 2u:
				num = ((int)num2 * -1297190072) ^ 0x4467B264;
				continue;
			case 0u:
				GClass1.smethod_3().method_3();
				num = ((int)num2 * -1037671559) ^ 0x67ECE0D9;
				continue;
			default:
				return;
			case 1u:
				goto IL_0568;
			case 27u:
				return;
			}
			int num5;
			if ((int_0 >= 21) & (int_0 <= 49))
			{
				num = -1042201321;
				num5 = -1042201321;
			}
			else
			{
				num = -1673131608;
				num5 = -1673131608;
			}
			continue;
			IL_0351:
			int num6;
			if ((int_0 >= 57) & (int_0 <= 65))
			{
				num = -2106733022;
				num6 = -2106733022;
			}
			else
			{
				num = -1357462667;
				num6 = -1357462667;
			}
			continue;
			IL_02be:
			int num7;
			if (!((int_0 >= 50) & (int_0 <= 57)))
			{
				num = -1720196616;
				num7 = -1720196616;
			}
			else
			{
				num = -828205910;
				num7 = -828205910;
			}
			continue;
			end_IL_04c5:
			break;
		}
		goto IL_03f5;
		IL_03f5:
		num = -1405682598;
		goto IL_04c5;
	}

	static void smethod_1(Form form_0, EventHandler eventHandler_0)
	{
		form_0.add_Load(eventHandler_0);
	}

	static void smethod_2(Form form_0, FormClosingEventHandler formClosingEventHandler_0)
	{
		form_0.add_FormClosing(formClosingEventHandler_0);
	}

	static void smethod_3(IDisposable idisposable_0)
	{
		idisposable_0.Dispose();
	}

	static Container smethod_4()
	{
		return new Container();
	}

	static Timer smethod_5(IContainer icontainer_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		return new Timer(icontainer_1);
	}

	static PictureBox smethod_6()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new PictureBox();
	}

	static void smethod_7(ISupportInitialize isupportInitialize_0)
	{
		isupportInitialize_0.BeginInit();
	}

	static void smethod_8(Control control_0)
	{
		control_0.SuspendLayout();
	}

	static void smethod_9(Timer timer_2, int int_1)
	{
		timer_2.set_Interval(int_1);
	}

	static void smethod_10(Control control_0, Color color_0)
	{
		control_0.set_BackColor(color_0);
	}

	static void smethod_11(Control control_0, ImageLayout imageLayout_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		control_0.set_BackgroundImageLayout(imageLayout_0);
	}

	static void smethod_12(Control control_0, Point point_0)
	{
		control_0.set_Location(point_0);
	}

	static void smethod_13(Control control_0, string string_0)
	{
		control_0.set_Name(string_0);
	}

	static void smethod_14(Control control_0, Size size_0)
	{
		control_0.set_Size(size_0);
	}

	static void smethod_15(PictureBox pictureBox_1, int int_1)
	{
		pictureBox_1.set_TabIndex(int_1);
	}

	static void smethod_16(PictureBox pictureBox_1, bool bool_1)
	{
		pictureBox_1.set_TabStop(bool_1);
	}

	static void smethod_17(ContainerControl containerControl_0, SizeF sizeF_0)
	{
		containerControl_0.set_AutoScaleDimensions(sizeF_0);
	}

	static void smethod_18(ContainerControl containerControl_0, AutoScaleMode autoScaleMode_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		containerControl_0.set_AutoScaleMode(autoScaleMode_0);
	}

	static void smethod_19(Form form_0, Color color_0)
	{
		form_0.set_BackColor(color_0);
	}

	static void smethod_20(Form form_0, Size size_0)
	{
		form_0.set_ClientSize(size_0);
	}

	static ControlCollection smethod_21(Control control_0)
	{
		return control_0.get_Controls();
	}

	static void smethod_22(ControlCollection controlCollection_0, Control control_0)
	{
		controlCollection_0.Add(control_0);
	}

	static Font smethod_23(string string_0, float float_1, FontStyle fontStyle_0, GraphicsUnit graphicsUnit_0, byte byte_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		return new Font(string_0, float_1, fontStyle_0, graphicsUnit_0, byte_0);
	}

	static void smethod_24(Control control_0, Font font_0)
	{
		control_0.set_Font(font_0);
	}

	static void smethod_25(Form form_0, FormBorderStyle formBorderStyle_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		form_0.set_FormBorderStyle(formBorderStyle_0);
	}

	static void smethod_26(Form form_0, Padding padding_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		form_0.set_Margin(padding_0);
	}

	static void smethod_27(Form form_0, bool bool_1)
	{
		form_0.set_MaximizeBox(bool_1);
	}

	static void smethod_28(Control control_0, string string_0)
	{
		control_0.set_Name(string_0);
	}

	static void smethod_29(Form form_0, FormStartPosition formStartPosition_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		form_0.set_StartPosition(formStartPosition_0);
	}

	static void smethod_30(Form form_0, string string_0)
	{
		form_0.set_Text(string_0);
	}

	static void smethod_31(ISupportInitialize isupportInitialize_0)
	{
		isupportInitialize_0.EndInit();
	}

	static void smethod_32(Control control_0, bool bool_1)
	{
		control_0.ResumeLayout(bool_1);
	}

	static void smethod_33(Timer timer_2, EventHandler eventHandler_0)
	{
		timer_2.remove_Tick(eventHandler_0);
	}

	static void smethod_34(Timer timer_2, EventHandler eventHandler_0)
	{
		timer_2.add_Tick(eventHandler_0);
	}

	static Process smethod_35()
	{
		return Process.GetCurrentProcess();
	}

	static void smethod_36(Process process_0, ProcessPriorityClass processPriorityClass_0)
	{
		process_0.PriorityClass = processPriorityClass_0;
	}

	static string smethod_37()
	{
		return Application.get_StartupPath();
	}

	static string smethod_38(string string_0, string string_1)
	{
		return string_0 + string_1;
	}

	static Image smethod_39(string string_0)
	{
		return Image.FromFile(string_0);
	}

	static void smethod_40(Control control_0, Image image_0)
	{
		control_0.set_BackgroundImage(image_0);
	}

	static void smethod_41(Timer timer_2)
	{
		timer_2.Start();
	}

	static int smethod_42(Image image_0)
	{
		return image_0.get_Width();
	}

	static int smethod_43(Image image_0)
	{
		return image_0.get_Height();
	}

	static Bitmap smethod_44(int int_1, int int_2)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected O, but got Unknown
		return new Bitmap(int_1, int_2);
	}

	static Graphics smethod_45(Image image_0)
	{
		return Graphics.FromImage(image_0);
	}

	static ColorMatrix smethod_46()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new ColorMatrix();
	}

	static void smethod_47(ColorMatrix colorMatrix_0, float float_1)
	{
		colorMatrix_0.set_Matrix33(float_1);
	}

	static ImageAttributes smethod_48()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new ImageAttributes();
	}

	static void smethod_49(ImageAttributes imageAttributes_0, ColorMatrix colorMatrix_0, ColorMatrixFlag colorMatrixFlag_0, ColorAdjustType colorAdjustType_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		imageAttributes_0.SetColorMatrix(colorMatrix_0, colorMatrixFlag_0, colorAdjustType_0);
	}

	static void smethod_50(Graphics graphics_0, Image image_0, Rectangle rectangle_0, int int_1, int int_2, int int_3, int int_4, GraphicsUnit graphicsUnit_0, ImageAttributes imageAttributes_0)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		graphics_0.DrawImage(image_0, rectangle_0, int_1, int_2, int_3, int_4, graphicsUnit_0, imageAttributes_0);
	}

	static void smethod_51(Graphics graphics_0)
	{
		graphics_0.Dispose();
	}

	static void smethod_52()
	{
		GC.Collect();
	}

	static void smethod_53(CancelEventArgs cancelEventArgs_0, bool bool_1)
	{
		cancelEventArgs_0.Cancel = bool_1;
	}

	static DialogResult smethod_54(string string_0, string string_1, MessageBoxButtons messageBoxButtons_0, MessageBoxIcon messageBoxIcon_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return MessageBox.Show(string_0, string_1, messageBoxButtons_0, messageBoxIcon_0);
	}

	static void smethod_55(Timer timer_2)
	{
		timer_2.Stop();
	}

	static void smethod_56(object object_0)
	{
		GC.SuppressFinalize(object_0);
	}

	static void smethod_57(Process process_0)
	{
		process_0.Kill();
	}

	static Image smethod_58(Control control_0)
	{
		return control_0.get_BackgroundImage();
	}

	static Point smethod_59(Control control_0)
	{
		return control_0.get_Location();
	}

	static float smethod_60()
	{
		return VBMath.Rnd();
	}

	static double smethod_61(double double_0)
	{
		return Math.Round(double_0);
	}

	static int smethod_62(Control control_0)
	{
		return control_0.get_Width();
	}

	static void smethod_63(Control control_0, int int_1)
	{
		control_0.set_Width(int_1);
	}

	static int smethod_64(Control control_0)
	{
		return control_0.get_Height();
	}

	static void smethod_65(Control control_0, int int_1)
	{
		control_0.set_Height(int_1);
	}
}
