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
			Timer val = timer_0;
			if (val != null)
			{
				goto IL_006c;
			}
			goto IL_009a;
			IL_009a:
			timer_0 = value;
			val = timer_0;
			int num = 2104697898;
			goto IL_0071;
			IL_0071:
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x252503Du) % 6u)
				{
				case 5u:
				{
					int num3;
					int num4;
					if (val != null)
					{
						num3 = -789836367;
						num4 = -789836367;
					}
					else
					{
						num3 = -891801954;
						num4 = -891801954;
					}
					num = num3 ^ (int)(num2 * 224212706);
					continue;
				}
				case 3u:
					GForm0.smethod_33(val, eventHandler_);
					num = ((int)num2 * -1629676778) ^ 0x431DEBD5;
					continue;
				case 2u:
					GForm0.smethod_34(val, eventHandler_);
					num = ((int)num2 * -471211738) ^ 0x7F65381C;
					continue;
				case 0u:
					break;
				default:
					return;
				case 4u:
					goto IL_009a;
				case 1u:
					return;
				}
				break;
			}
			goto IL_006c;
			IL_006c:
			num = 161638252;
			goto IL_0071;
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
				int num = 1671683990;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x790CFDDCu) % 8u)
					{
					case 7u:
					{
						int num5;
						int num6;
						if (val != null)
						{
							num5 = -261182446;
							num6 = -261182446;
						}
						else
						{
							num5 = -1273124880;
							num6 = -1273124880;
						}
						num = num5 ^ ((int)num2 * -92942216);
						continue;
					}
					case 6u:
						GForm0.smethod_34(val, eventHandler_);
						num = ((int)num2 * -735920080) ^ -13333992;
						continue;
					case 5u:
						timer_1 = value;
						val = timer_1;
						num = 856017419;
						continue;
					case 3u:
					{
						int num3;
						int num4;
						if (val == null)
						{
							num3 = 39893320;
							num4 = 39893320;
						}
						else
						{
							num3 = 344444684;
							num4 = 344444684;
						}
						num = num3 ^ ((int)num2 * -1337197589);
						continue;
					}
					case 2u:
						val = timer_1;
						num = ((int)num2 * -1940838934) ^ 0x4DD4E29B;
						continue;
					case 1u:
						GForm0.smethod_33(val, eventHandler_);
						num = (int)(num2 * 185295178) ^ -107092989;
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
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Expected O, but got Unknown
		while (true)
		{
			int num = 50604177;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x348C54C7u) % 10u)
				{
				case 9u:
					bool_0 = false;
					float_0 = 0.1f;
					num = (int)(num2 * 1649265004) ^ -962249326;
					continue;
				case 8u:
					num = ((int)num2 * -1151063895) ^ -110010170;
					continue;
				case 7u:
					num = (int)(num2 * 597098855) ^ -1743447342;
					continue;
				case 6u:
					GForm0.smethod_1((Form)(object)this, (EventHandler)method_1);
					num = ((int)num2 * -2010499561) ^ -1573423334;
					continue;
				case 5u:
					num = (int)(num2 * 1180528580) ^ -1107559628;
					continue;
				case 4u:
					method_0();
					num = ((int)num2 * -1289358415) ^ 0x2901A32A;
					continue;
				case 3u:
					int_0 = 0;
					num = (int)((num2 * 1442856490) ^ 0x3BCF164D);
					continue;
				case 1u:
					GForm0.smethod_2((Form)(object)this, new FormClosingEventHandler(method_3));
					num = ((int)num2 * -1356069005) ^ 0xEB6F648;
					continue;
				default:
					return;
				case 0u:
					break;
				case 2u:
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
			bool flag = default(bool);
			while (true)
			{
				int num = -956225803;
				while (true)
				{
					uint num2;
					int num3;
					switch ((num2 = (uint)num ^ 0x8FE71373u) % 9u)
					{
					case 8u:
						num = -1852509380;
						continue;
					case 7u:
						num = ((int)num2 * -2083992773) ^ 0x19D91592;
						continue;
					case 6u:
					{
						int num4;
						int num5;
						if (!flag)
						{
							num4 = -1938016170;
							num5 = -1938016170;
						}
						else
						{
							num4 = -1968175103;
							num5 = -1968175103;
						}
						num = num4 ^ ((int)num2 * -587329772);
						continue;
					}
					case 4u:
						num3 = ((icontainer_0 != null) ? 1 : 0);
						goto IL_004d;
					case 3u:
						if (disposing)
						{
							num = ((int)num2 * -224323769) ^ -239698415;
							continue;
						}
						num3 = 0;
						goto IL_004d;
					case 2u:
						num = ((int)num2 * -814103752) ^ 0x792B6B17;
						continue;
					case 0u:
						GForm0.smethod_3((IDisposable)icontainer_0);
						num = ((int)num2 * -1201147097) ^ -14650859;
						continue;
					default:
						return;
					case 5u:
						break;
					case 1u:
						return;
						IL_004d:
						flag = (byte)num3 != 0;
						num = -1907471143;
						continue;
					}
					break;
				}
			}
		}
		finally
		{
			while (true)
			{
				IL_0117:
				int num6 = -1946938659;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num6 ^ 0x8FE71373u) % 4u)
					{
					case 2u:
						((Form)this).Dispose(disposing);
						num6 = ((int)num2 * -389777527) ^ 0x4B759E10;
						continue;
					case 1u:
						num6 = (int)(num2 * 559869321) ^ -1627007290;
						continue;
					default:
						goto end_IL_00f6;
					case 3u:
						break;
					case 0u:
						goto end_IL_00f6;
					}
					goto IL_0117;
					continue;
					end_IL_00f6:
					break;
				}
				break;
			}
		}
	}

	[DebuggerStepThrough]
	private void method_0()
	{
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			int num = -1825076564;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB051FDE7u) % 42u)
				{
				case 41u:
					GForm0.smethod_15(PictureBox_0, 0);
					num = (int)(num2 * 1805839920) ^ -1435639510;
					continue;
				case 40u:
					GForm0.smethod_7((ISupportInitialize)PictureBox_0);
					GForm0.smethod_8((Control)(object)this);
					num = (int)(num2 * 1240784178) ^ -711386906;
					continue;
				case 39u:
					GForm0.smethod_14((Control)(object)PictureBox_0, new Size(302, 211));
					num = ((int)num2 * -479876492) ^ 0x6B38E88;
					continue;
				case 38u:
					GForm0.smethod_28((Control)(object)this, "Introduction");
					GForm0.smethod_29((Form)(object)this, (FormStartPosition)1);
					num = (int)(num2 * 481496047) ^ -326999752;
					continue;
				case 37u:
					GForm0.smethod_19((Form)(object)this, Color.White);
					num = ((int)num2 * -1463171417) ^ 0x66AB81BA;
					continue;
				case 36u:
					GForm0.smethod_26((Form)(object)this, new Padding(4));
					num = ((int)num2 * -187775112) ^ -22110702;
					continue;
				case 35u:
					GForm0.smethod_16(PictureBox_0, bool_1: false);
					num = ((int)num2 * -1471256088) ^ 0x401B2EEE;
					continue;
				case 34u:
					GForm0.smethod_18((ContainerControl)(object)this, (AutoScaleMode)1);
					num = ((int)num2 * -1099658292) ^ -1080881329;
					continue;
				case 33u:
					num = (int)(num2 * 1703346634) ^ -841262877;
					continue;
				case 32u:
					GForm0.smethod_11((Control)(object)this, (ImageLayout)3);
					num = (int)((num2 * 1395313486) ^ 0x7A0F58B);
					continue;
				case 31u:
					num = ((int)num2 * -963967737) ^ -824561961;
					continue;
				case 30u:
					GForm0.smethod_9(Timer_0, 1000);
					num = ((int)num2 * -907044582) ^ 0x5888FFE1;
					continue;
				case 29u:
					GForm0.smethod_11((Control)(object)PictureBox_0, (ImageLayout)3);
					num = ((int)num2 * -1606216702) ^ -572950700;
					continue;
				case 28u:
					GForm0.smethod_20((Form)(object)this, new Size(1025, 638));
					GForm0.smethod_22(GForm0.smethod_21((Control)(object)this), (Control)(object)PictureBox_0);
					num = ((int)num2 * -1048896703) ^ -1115579052;
					continue;
				case 27u:
					num = ((int)num2 * -574491488) ^ -9022649;
					continue;
				case 26u:
					num = ((int)num2 * -1152723043) ^ 0x78520CBF;
					continue;
				case 25u:
					num = ((int)num2 * -805464066) ^ 0x76044D0F;
					continue;
				case 24u:
					num = ((int)num2 * -2035104659) ^ 0x656BDF2D;
					continue;
				case 22u:
					num = (int)(num2 * 156859691) ^ -2078950350;
					continue;
				case 21u:
					GForm0.smethod_31((ISupportInitialize)PictureBox_0);
					num = (int)((num2 * 702085989) ^ 0x7CF32ECE);
					continue;
				case 20u:
					Timer_1 = GForm0.smethod_5(icontainer_0);
					num = ((int)num2 * -865387938) ^ 0x430CE36;
					continue;
				case 18u:
					((Control)this).set_DoubleBuffered(true);
					num = ((int)num2 * -1784933593) ^ -1673172762;
					continue;
				case 17u:
					num = (int)(num2 * 1437173402) ^ -1657068182;
					continue;
				case 16u:
					GForm0.smethod_27((Form)(object)this, bool_1: false);
					num = (int)((num2 * 1003442559) ^ 0x3CFFDE43);
					continue;
				case 15u:
					num = ((int)num2 * -1485403917) ^ 0x2632609E;
					continue;
				case 14u:
					GForm0.smethod_30((Form)(object)this, "The Omegle Game");
					num = (int)(num2 * 1788748600) ^ -1797587466;
					continue;
				case 13u:
					icontainer_0 = GForm0.smethod_4();
					Timer_0 = GForm0.smethod_5(icontainer_0);
					num = ((int)num2 * -1310828256) ^ -756225520;
					continue;
				case 12u:
					GForm0.smethod_32((Control)(object)this, bool_1: false);
					num = (int)(num2 * 705865645) ^ -164936026;
					continue;
				case 11u:
					num = ((int)num2 * -487605446) ^ 0x554C9347;
					continue;
				case 10u:
					GForm0.smethod_25((Form)(object)this, (FormBorderStyle)1);
					num = (int)((num2 * 751661943) ^ 0x7D5EC805);
					continue;
				case 9u:
					num = ((int)num2 * -1804750466) ^ -605195255;
					continue;
				case 8u:
					num = (int)(num2 * 48437693) ^ -1866395813;
					continue;
				case 7u:
					num = (int)((num2 * 17857025) ^ 0x3BBEB5E0);
					continue;
				case 6u:
					GForm0.smethod_10((Control)(object)PictureBox_0, Color.Transparent);
					num = ((int)num2 * -358735196) ^ 0xAA2904;
					continue;
				case 5u:
					num = ((int)num2 * -1602761268) ^ -2094040536;
					continue;
				case 4u:
					GForm0.smethod_12((Control)(object)PictureBox_0, new Point(365, 415));
					num = (int)(num2 * 227284305) ^ -564369973;
					continue;
				case 3u:
					GForm0.smethod_24((Control)(object)this, GForm0.smethod_23("Consolas", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 768555640) ^ -1488133407;
					continue;
				case 2u:
					PictureBox_0 = GForm0.smethod_6();
					num = ((int)num2 * -9445024) ^ -1095634129;
					continue;
				case 1u:
					GForm0.smethod_9(Timer_1, 500);
					GForm0.smethod_17((ContainerControl)(object)this, new SizeF(10f, 22f));
					num = ((int)num2 * -1755984600) ^ -861692533;
					continue;
				case 0u:
					GForm0.smethod_13((Control)(object)PictureBox_0, "PictureBox1");
					num = ((int)num2 * -1132290233) ^ 0x18A3BE94;
					continue;
				default:
					return;
				case 23u:
					break;
				case 19u:
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
			int num = 984806858;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x19E8D0DDu) % 9u)
				{
				case 8u:
					num = ((int)num2 * -1847610077) ^ -563046750;
					continue;
				case 7u:
					num = (int)((num2 * 102617831) ^ 0x26021832);
					continue;
				case 6u:
					GForm0.smethod_41(Timer_1);
					num = (int)(num2 * 241210429) ^ -1150892200;
					continue;
				case 5u:
					GForm0.smethod_40((Control)(object)PictureBox_0, (Image)(object)smethod_0(GForm0.smethod_39(GForm0.smethod_38(GForm0.smethod_37(), "\\data\\Images\\marco_introduzione.png")), float_0));
					num = (int)((num2 * 988936044) ^ 0xC1E5F7);
					continue;
				case 4u:
					GClass1.smethod_3().method_0();
					num = (int)(num2 * 1922081461) ^ -1303619050;
					continue;
				case 2u:
					GClass1.smethod_0();
					num = ((int)num2 * -555754200) ^ 0x1D2BD5B9;
					continue;
				case 1u:
					GForm0.smethod_40((Control)(object)this, GForm0.smethod_39(GForm0.smethod_38(GForm0.smethod_37(), "\\data\\Images\\schermata_omegle.png")));
					num = (int)(num2 * 1825374465) ^ -623195508;
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

	public static Bitmap smethod_0(Image image_0, float float_1)
	{
		Graphics graphics_ = default(Graphics);
		Bitmap val = default(Bitmap);
		ImageAttributes imageAttributes_ = default(ImageAttributes);
		ColorMatrix colorMatrix_ = default(ColorMatrix);
		Bitmap result = default(Bitmap);
		while (true)
		{
			int num = -1010498831;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD14EE934u) % 12u)
				{
				case 11u:
					num = (int)(num2 * 189628948) ^ -1733967944;
					continue;
				case 8u:
					GForm0.smethod_50(graphics_, image_0, new Rectangle(0, 0, GForm0.smethod_42((Image)(object)val), GForm0.smethod_43((Image)(object)val)), 0, 0, GForm0.smethod_42(image_0), GForm0.smethod_43(image_0), (GraphicsUnit)2, imageAttributes_);
					num = ((int)num2 * -2128182563) ^ -691567718;
					continue;
				case 7u:
					GForm0.smethod_47(colorMatrix_, float_1);
					num = (int)((num2 * 149169074) ^ 0x65BCD1AB);
					continue;
				case 6u:
					num = (int)(num2 * 502163404) ^ -575591256;
					continue;
				case 5u:
					imageAttributes_ = GForm0.smethod_48();
					num = (int)(num2 * 358607769) ^ -39682847;
					continue;
				case 4u:
					GForm0.smethod_49(imageAttributes_, colorMatrix_, (ColorMatrixFlag)0, (ColorAdjustType)1);
					num = ((int)num2 * -1199195918) ^ -1360167381;
					continue;
				case 3u:
					num = (int)((num2 * 1076182517) ^ 0x25D4D511);
					continue;
				case 2u:
					colorMatrix_ = GForm0.smethod_46();
					num = (int)(num2 * 1182591136) ^ -678372973;
					continue;
				case 1u:
					val = GForm0.smethod_44(GForm0.smethod_42(image_0), GForm0.smethod_43(image_0));
					graphics_ = GForm0.smethod_45((Image)(object)val);
					num = ((int)num2 * -1239897849) ^ -951358907;
					continue;
				case 0u:
					GForm0.smethod_51(graphics_);
					result = val;
					num = (int)(num2 * 1300050479) ^ -1179573469;
					continue;
				case 9u:
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
			int num = -1300181151;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA591BDDBu) % 3u)
				{
				case 1u:
					goto IL_0003;
				default:
					return;
				case 2u:
					break;
				case 0u:
					return;
				}
				break;
				IL_0003:
				GForm0.smethod_52();
				num = ((int)num2 * -656281238) ^ 0x6CA41644;
			}
		}
	}

	private void method_3(object sender, FormClosingEventArgs e)
	{
		while (true)
		{
			int num = 485181363;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7925EE91u) % 7u)
				{
				case 5u:
					method_4();
					num = (int)(num2 * 1478426424) ^ -762704292;
					continue;
				case 3u:
					num = (int)(num2 * 354111363) ^ -1992774334;
					continue;
				case 2u:
					GForm0.smethod_53((CancelEventArgs)(object)e, bool_1: true);
					num = (int)(num2 * 1036095164) ^ -1503467210;
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (!bool_0)
					{
						num3 = 293335271;
						num4 = 293335271;
					}
					else
					{
						num3 = 304991813;
						num4 = 304991813;
					}
					num = num3 ^ (int)(num2 * 1935317322);
					continue;
				}
				case 0u:
					num = ((int)num2 * -855974082) ^ -1410595430;
					continue;
				default:
					return;
				case 4u:
					break;
				case 6u:
					return;
				}
				break;
			}
		}
	}

	public void method_4()
	{
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Invalid comparison between Unknown and I4
		bool flag = default(bool);
		while (true)
		{
			int num = 144171794;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x44CDD2FFu) % 21u)
				{
				case 20u:
					GForm0.smethod_55(Timer_0);
					num = ((int)num2 * -1776754984) ^ -213355881;
					continue;
				case 19u:
					GForm0.smethod_56((object)bool_0);
					num = ((int)num2 * -1994202630) ^ -1810925928;
					continue;
				case 17u:
				{
					int num5;
					int num6;
					if (bool_0)
					{
						num5 = -1196470273;
						num6 = -1196470273;
					}
					else
					{
						num5 = -1711487315;
						num6 = -1711487315;
					}
					num = num5 ^ (int)(num2 * 18714427);
					continue;
				}
				case 16u:
					GForm0.smethod_52();
					num = ((int)num2 * -1284342556) ^ 0x14B0784C;
					continue;
				case 15u:
					GForm0.smethod_52();
					num = (int)((num2 * 591562189) ^ 0x15848946);
					continue;
				case 14u:
					num = (int)((num2 * 176249821) ^ 0x469F3EA1);
					continue;
				case 13u:
					num = 1726340515;
					continue;
				case 12u:
					num = (int)(num2 * 1700025436) ^ -866215685;
					continue;
				case 11u:
					flag = (int)GForm0.smethod_54("Sei sicuro di voler uscire dal gioco?", "The Omegle Game", (MessageBoxButtons)4, (MessageBoxIcon)32) == 6;
					num = ((int)num2 * -1735025646) ^ -2140588393;
					continue;
				case 10u:
					GForm0.smethod_56((object)Timer_0);
					num = ((int)num2 * -588107753) ^ -610823120;
					continue;
				case 9u:
					GForm0.smethod_56((object)bool_0);
					num = ((int)num2 * -1642686706) ^ -1780681162;
					continue;
				case 8u:
					num = ((int)num2 * -1860370993) ^ 0x589BB09E;
					continue;
				case 7u:
					num = (int)(num2 * 2109623471) ^ -1374011239;
					continue;
				case 6u:
					GForm0.smethod_55(Timer_0);
					num = ((int)num2 * -21229008) ^ 0x427A1591;
					continue;
				case 5u:
					GForm0.smethod_56((object)Timer_0);
					num = ((int)num2 * -522465645) ^ 0x3E103A7D;
					continue;
				case 4u:
					GForm0.smethod_57(GForm0.smethod_35());
					num = (int)(num2 * 148467774) ^ -1708430733;
					continue;
				case 3u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = 717066778;
						num4 = 717066778;
					}
					else
					{
						num3 = 1028960211;
						num4 = 1028960211;
					}
					num = num3 ^ ((int)num2 * -1351209008);
					continue;
				}
				case 2u:
					num = 839111776;
					continue;
				case 0u:
					num = ((int)num2 * -1614247168) ^ -1955376801;
					continue;
				default:
					return;
				case 18u:
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
		bool flag = int_0 <= 15;
		bool flag2 = default(bool);
		bool flag3 = default(bool);
		while (true)
		{
			int num = 21309107;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x188DD7ADu) % 37u)
				{
				case 36u:
					checked
					{
						int_0++;
					}
					num = ((int)num2 * -1567592033) ^ -680994812;
					continue;
				case 35u:
					GForm0.smethod_56((object)float_0);
					num = ((int)num2 * -595578243) ^ 0x2402FC32;
					continue;
				case 34u:
				{
					GForm0.smethod_40((Control)(object)PictureBox_0, (Image)(object)smethod_0(GForm0.smethod_58((Control)(object)PictureBox_0), float_0));
					ref float reference = ref float_0;
					reference = (float)((double)reference + 0.3);
					num = ((int)num2 * -1321363172) ^ 0x184A37D1;
					continue;
				}
				case 33u:
					num = (int)((num2 * 1638498601) ^ 0x6BCB1E19);
					continue;
				case 32u:
					flag2 = (int_0 >= 16) & (int_0 <= 20);
					num = 1093454289;
					continue;
				case 31u:
					num = (int)(num2 * 281551873) ^ -883933382;
					continue;
				case 30u:
					GClass1.smethod_3().method_3();
					num = (int)(num2 * 1991509487) ^ -27871931;
					continue;
				case 29u:
					GForm0.smethod_55(Timer_1);
					num = (int)(num2 * 1846508056) ^ -1048314231;
					continue;
				case 28u:
				{
					int num5;
					if ((int_0 >= 21) & (int_0 <= 49))
					{
						num = 817903667;
						num5 = 817903667;
					}
					else
					{
						num = 1580257363;
						num5 = 1580257363;
					}
					continue;
				}
				case 27u:
					num = 331312260;
					continue;
				case 25u:
				{
					int num9;
					int num10;
					if (flag)
					{
						num9 = 1844151632;
						num10 = 1844151632;
					}
					else
					{
						num9 = 612777612;
						num10 = 612777612;
					}
					num = num9 ^ ((int)num2 * -1933033303);
					continue;
				}
				case 24u:
					GForm0.smethod_56((object)Timer_1);
					num = (int)((num2 * 1652964817) ^ 0x478D8CDA);
					continue;
				case 23u:
					checked
					{
						GForm0.smethod_12((Control)(object)PictureBox_0, new Point((int)GForm0.smethod_61((double)((float)GForm0.smethod_59((Control)(object)PictureBox_0).X + GForm0.smethod_60() * 10f)), (int)GForm0.smethod_61((double)((float)GForm0.smethod_59((Control)(object)PictureBox_0).Y - GForm0.smethod_60() * 10f))));
						int_0++;
					}
					num = (int)(num2 * 721830426) ^ -2106503332;
					continue;
				case 22u:
					GForm0.smethod_12((Control)(object)PictureBox_0, new Point(512, 0));
					num = ((int)num2 * -703308070) ^ 0x5DBAD2BF;
					continue;
				case 21u:
				{
					PictureBox control_;
					GForm0.smethod_63((Control)(object)(control_ = PictureBox_0), checked(GForm0.smethod_62((Control)(object)control_) + 30));
					num = ((int)num2 * -872751888) ^ 0x66B40DBB;
					continue;
				}
				case 20u:
				{
					PictureBox control_;
					GForm0.smethod_65((Control)(object)(control_ = PictureBox_0), checked(GForm0.smethod_64((Control)(object)control_) + 30));
					num = (int)(num2 * 510728352) ^ -1520562108;
					continue;
				}
				case 19u:
					checked
					{
						int_0++;
					}
					num = (int)((num2 * 1881970363) ^ 0x78F6C5FA);
					continue;
				case 18u:
					num = ((int)num2 * -1330984416) ^ 0x6ED03E70;
					continue;
				case 17u:
				{
					int num8;
					if ((int_0 >= 57) & (int_0 <= 65))
					{
						num = 1014656113;
						num8 = 1014656113;
					}
					else
					{
						num = 2118273858;
						num8 = 2118273858;
					}
					continue;
				}
				case 16u:
					GForm0.smethod_40((Control)(object)PictureBox_0, GForm0.smethod_39(GForm0.smethod_38(GForm0.smethod_37(), "\\data\\Images\\marco_introduzione.png")));
					num = ((int)num2 * -926758227) ^ -1921263372;
					continue;
				case 15u:
					num = (int)(num2 * 2113455971) ^ -491942277;
					continue;
				case 14u:
					GForm0.smethod_40((Control)(object)PictureBox_0, GForm0.smethod_39(GForm0.smethod_38(GForm0.smethod_37(), "\\data\\Images\\marco_introduzione.png")));
					num = (int)(num2 * 1290543025) ^ -794355550;
					continue;
				case 13u:
					GForm0.smethod_56((object)int_0);
					num = ((int)num2 * -1622477242) ^ 0x2FE10C26;
					continue;
				case 12u:
				{
					int num6;
					int num7;
					if (flag3)
					{
						num6 = 2089804135;
						num7 = 2089804135;
					}
					else
					{
						num6 = 287359036;
						num7 = 287359036;
					}
					num = num6 ^ (int)(num2 * 667284903);
					continue;
				}
				case 11u:
					checked
					{
						int_0++;
					}
					num = (int)((num2 * 326856871) ^ 0x724A566);
					continue;
				case 10u:
					num = ((int)num2 * -1443455621) ^ 0x1D326365;
					continue;
				case 9u:
					num = (int)((num2 * 1150950150) ^ 0x566BEBBC);
					continue;
				case 8u:
					num = (int)(num2 * 1188210790) ^ -1357824480;
					continue;
				case 7u:
					flag3 = (int_0 >= 50) & (int_0 <= 57);
					num = 931168838;
					continue;
				case 6u:
					num = (int)((num2 * 476803554) ^ 0x2474B6AA);
					continue;
				case 5u:
				{
					int num3;
					int num4;
					if (flag2)
					{
						num3 = 2001708814;
						num4 = 2001708814;
					}
					else
					{
						num3 = 603100766;
						num4 = 603100766;
					}
					num = num3 ^ (int)(num2 * 1579558895);
					continue;
				}
				case 3u:
				{
					PictureBox control_;
					GForm0.smethod_65((Control)(object)(control_ = PictureBox_0), checked(GForm0.smethod_64((Control)(object)control_) + 22));
					num = (int)((num2 * 903791535) ^ 0x793383F8);
					continue;
				}
				case 2u:
					GClass1.smethod_3().method_4();
					GForm0.smethod_52();
					num = (int)(num2 * 1393741697) ^ -30599049;
					continue;
				case 1u:
					num = ((int)num2 * -1783028093) ^ -569737273;
					continue;
				case 0u:
					checked
					{
						int_0++;
					}
					num = (int)(num2 * 2107930152) ^ -843127856;
					continue;
				default:
					return;
				case 26u:
					break;
				case 4u:
					return;
				}
				break;
			}
		}
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
