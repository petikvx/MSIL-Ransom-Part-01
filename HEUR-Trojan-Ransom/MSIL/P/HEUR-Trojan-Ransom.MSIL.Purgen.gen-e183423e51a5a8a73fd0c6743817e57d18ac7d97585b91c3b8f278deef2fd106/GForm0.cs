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
			while (true)
			{
				int num = 432287322;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x13210995u) % 8u)
					{
					case 7u:
					{
						int num5;
						int num6;
						if (val != null)
						{
							num5 = -163716988;
							num6 = -163716988;
						}
						else
						{
							num5 = -1283600030;
							num6 = -1283600030;
						}
						num = num5 ^ ((int)num2 * -104547363);
						continue;
					}
					case 6u:
					{
						int num3;
						int num4;
						if (val != null)
						{
							num3 = 1000860925;
							num4 = 1000860925;
						}
						else
						{
							num3 = 364400684;
							num4 = 364400684;
						}
						num = num3 ^ ((int)num2 * -682715612);
						continue;
					}
					case 4u:
						timer_0 = value;
						num = 835119166;
						continue;
					case 3u:
						val = timer_0;
						num = ((int)num2 * -1460945732) ^ 0x531A6DAF;
						continue;
					case 2u:
						GForm0.smethod_33(val, eventHandler_);
						num = ((int)num2 * -1800548075) ^ 0x4C0259B;
						continue;
					case 0u:
						GForm0.smethod_34(val, eventHandler_);
						num = (int)(num2 * 1467641203) ^ -1249040796;
						continue;
					default:
						return;
					case 5u:
						break;
					case 1u:
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
				int num = 1111981934;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x1FACEF73u) % 8u)
					{
					case 7u:
						GForm0.smethod_33(val, eventHandler_);
						num = (int)((num2 * 2107788055) ^ 0x537BFE5E);
						continue;
					case 6u:
					{
						int num5;
						int num6;
						if (val == null)
						{
							num5 = -2085566799;
							num6 = -2085566799;
						}
						else
						{
							num5 = -704249270;
							num6 = -704249270;
						}
						num = num5 ^ ((int)num2 * -654524079);
						continue;
					}
					case 5u:
						val = timer_1;
						num = ((int)num2 * -1810138324) ^ 0xD438489;
						continue;
					case 4u:
						timer_1 = value;
						val = timer_1;
						num = 1074344049;
						continue;
					case 2u:
					{
						int num3;
						int num4;
						if (val == null)
						{
							num3 = -951398814;
							num4 = -951398814;
						}
						else
						{
							num3 = -625723504;
							num4 = -625723504;
						}
						num = num3 ^ (int)(num2 * 1528340329);
						continue;
					}
					case 1u:
						GForm0.smethod_34(val, eventHandler_);
						num = ((int)num2 * -1250051453) ^ 0x49001A3;
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
	}

	public GForm0()
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected O, but got Unknown
		while (true)
		{
			int num = 1694326383;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x424F3DE1u) % 7u)
				{
				case 6u:
					num = (int)((num2 * 2056303061) ^ 0x382E283B);
					continue;
				case 5u:
					int_0 = 0;
					method_0();
					num = ((int)num2 * -1977932027) ^ 0x369F5C8C;
					continue;
				case 3u:
					float_0 = 0.1f;
					num = (int)(num2 * 741210385) ^ -1167341504;
					continue;
				case 2u:
					GForm0.smethod_2((Form)(object)this, new FormClosingEventHandler(method_3));
					bool_0 = false;
					num = (int)((num2 * 728984972) ^ 0xDC19FFB);
					continue;
				case 1u:
					GForm0.smethod_1((Form)(object)this, (EventHandler)method_1);
					num = ((int)num2 * -1380974486) ^ 0xA8EF35F;
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

	[DebuggerNonUserCode]
	void Form.Dispose(bool disposing)
	{
		try
		{
			while (true)
			{
				int num = 1664288333;
				while (true)
				{
					uint num2;
					int num3;
					switch ((num2 = (uint)num ^ 0x1BC07CF8u) % 7u)
					{
					case 6u:
						num = (int)(num2 * 543379506) ^ -1850190375;
						continue;
					case 5u:
						if (icontainer_0 != null)
						{
							num = 1135967602;
							num3 = 1135967602;
							continue;
						}
						goto IL_0021;
					case 3u:
						num = (int)((num2 * 1798199589) ^ 0x1187B847);
						continue;
					case 2u:
						GForm0.smethod_3((IDisposable)icontainer_0);
						num = ((int)num2 * -2114972057) ^ -330152684;
						continue;
					case 1u:
						if (disposing)
						{
							num = ((int)num2 * -390704267) ^ 0x3FED5E50;
							continue;
						}
						goto IL_0021;
					default:
						return;
					case 4u:
						break;
					case 0u:
						return;
						IL_0021:
						num = 490375630;
						num3 = 490375630;
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
				IL_00e2:
				int num4 = 1316623803;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num4 ^ 0x1BC07CF8u) % 3u)
					{
					case 2u:
						goto IL_00b1;
					default:
						goto end_IL_00c5;
					case 0u:
						break;
					case 1u:
						goto end_IL_00c5;
					}
					goto IL_00e2;
					IL_00b1:
					((Form)this).Dispose(disposing);
					num4 = ((int)num2 * -1764083095) ^ 0x43936067;
					continue;
					end_IL_00c5:
					break;
				}
				break;
			}
		}
	}

	[DebuggerStepThrough]
	private void method_0()
	{
		//IL_0252: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			int num = 1848266983;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xCFEC337u) % 46u)
				{
				case 45u:
					GForm0.smethod_14((Control)(object)PictureBox_0, new Size(302, 211));
					num = ((int)num2 * -374591211) ^ 0x2601EEF9;
					continue;
				case 44u:
					num = (int)(num2 * 1416754120) ^ -538103278;
					continue;
				case 43u:
					GForm0.smethod_11((Control)(object)PictureBox_0, (ImageLayout)3);
					num = ((int)num2 * -1123078252) ^ -1804863303;
					continue;
				case 42u:
					num = ((int)num2 * -2079927482) ^ -361069624;
					continue;
				case 41u:
					num = (int)(num2 * 487901825) ^ -821290623;
					continue;
				case 40u:
					GForm0.smethod_13((Control)(object)PictureBox_0, "PictureBox1");
					num = ((int)num2 * -1450448221) ^ -189398420;
					continue;
				case 39u:
					num = (int)(num2 * 823899794) ^ -852280295;
					continue;
				case 38u:
					GForm0.smethod_30((Form)(object)this, "The Omegle Game");
					num = (int)(num2 * 1258739380) ^ -165766816;
					continue;
				case 37u:
					GForm0.smethod_24((Control)(object)this, GForm0.smethod_23("Consolas", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1911603637) ^ -633665494;
					continue;
				case 36u:
					GForm0.smethod_12((Control)(object)PictureBox_0, new Point(365, 415));
					num = (int)(num2 * 721194843) ^ -769970591;
					continue;
				case 35u:
					num = ((int)num2 * -1528723351) ^ 0x3DFA70D5;
					continue;
				case 34u:
					num = ((int)num2 * -1320811975) ^ -290457375;
					continue;
				case 33u:
					Timer_0 = GForm0.smethod_5(icontainer_0);
					PictureBox_0 = GForm0.smethod_6();
					num = ((int)num2 * -484803283) ^ -266866417;
					continue;
				case 32u:
					GForm0.smethod_9(Timer_1, 500);
					num = ((int)num2 * -1851621607) ^ 0x79CAE321;
					continue;
				case 31u:
					GForm0.smethod_20((Form)(object)this, new Size(1025, 638));
					num = (int)(num2 * 703939085) ^ -43335138;
					continue;
				case 30u:
					num = ((int)num2 * -311549947) ^ -777296634;
					continue;
				case 29u:
					num = ((int)num2 * -107775640) ^ 0x4F7BF4EF;
					continue;
				case 28u:
					icontainer_0 = GForm0.smethod_4();
					num = (int)((num2 * 1924614422) ^ 0x19BD1674);
					continue;
				case 27u:
					GForm0.smethod_25((Form)(object)this, (FormBorderStyle)1);
					num = (int)(num2 * 3183460) ^ -1072818329;
					continue;
				case 25u:
					Timer_1 = GForm0.smethod_5(icontainer_0);
					GForm0.smethod_7((ISupportInitialize)PictureBox_0);
					num = (int)((num2 * 1669284381) ^ 0x4E962FAB);
					continue;
				case 24u:
					GForm0.smethod_26((Form)(object)this, new Padding(4));
					num = ((int)num2 * -1613253159) ^ -1450961447;
					continue;
				case 23u:
					num = ((int)num2 * -2083139677) ^ -954335862;
					continue;
				case 22u:
					GForm0.smethod_19((Form)(object)this, Color.White);
					num = ((int)num2 * -1148760128) ^ 0x4BEE886A;
					continue;
				case 21u:
					num = ((int)num2 * -1276121611) ^ 0x2AAA39E7;
					continue;
				case 20u:
					GForm0.smethod_18((ContainerControl)(object)this, (AutoScaleMode)1);
					num = (int)(num2 * 597789988) ^ -2074079678;
					continue;
				case 19u:
					GForm0.smethod_16(PictureBox_0, bool_1: false);
					num = (int)(num2 * 1699881762) ^ -636217557;
					continue;
				case 18u:
					GForm0.smethod_10((Control)(object)PictureBox_0, Color.Transparent);
					num = (int)((num2 * 479941572) ^ 0xFEB915E);
					continue;
				case 17u:
					num = ((int)num2 * -1434032281) ^ -1710451616;
					continue;
				case 16u:
					GForm0.smethod_29((Form)(object)this, (FormStartPosition)1);
					num = ((int)num2 * -1866307994) ^ 0x3CF2ACEE;
					continue;
				case 15u:
					GForm0.smethod_15(PictureBox_0, 0);
					num = (int)((num2 * 1489651780) ^ 0x663DA808);
					continue;
				case 14u:
					GForm0.smethod_22(GForm0.smethod_21((Control)(object)this), (Control)(object)PictureBox_0);
					num = ((int)num2 * -1900613644) ^ 0x682BE599;
					continue;
				case 13u:
					GForm0.smethod_17((ContainerControl)(object)this, new SizeF(10f, 22f));
					num = ((int)num2 * -1984430903) ^ 0x76EB807C;
					continue;
				case 12u:
					num = ((int)num2 * -170832830) ^ -1866198019;
					continue;
				case 11u:
					num = (int)((num2 * 478050851) ^ 0x56DB1989);
					continue;
				case 10u:
					num = ((int)num2 * -603766029) ^ 0x6DFCCCCB;
					continue;
				case 9u:
					GForm0.smethod_11((Control)(object)this, (ImageLayout)3);
					num = (int)((num2 * 1821151271) ^ 0x3403E5EE);
					continue;
				case 7u:
					num = (int)(num2 * 1266406546) ^ -16928371;
					continue;
				case 6u:
					GForm0.smethod_27((Form)(object)this, bool_1: false);
					num = (int)((num2 * 1295174505) ^ 0x4D5FA1A4);
					continue;
				case 5u:
					GForm0.smethod_32((Control)(object)this, bool_1: false);
					num = (int)((num2 * 419657088) ^ 0x1CBAD3EF);
					continue;
				case 4u:
					((Control)this).set_DoubleBuffered(true);
					num = (int)((num2 * 192800135) ^ 0x5320EE2A);
					continue;
				case 3u:
					GForm0.smethod_8((Control)(object)this);
					GForm0.smethod_9(Timer_0, 1000);
					num = ((int)num2 * -1185272805) ^ -491892635;
					continue;
				case 2u:
					GForm0.smethod_31((ISupportInitialize)PictureBox_0);
					num = (int)(num2 * 1098094149) ^ -1234407966;
					continue;
				case 1u:
					GForm0.smethod_28((Control)(object)this, "Introduction");
					num = ((int)num2 * -950720839) ^ 0x2BB4F3B;
					continue;
				case 0u:
					num = (int)(num2 * 176593778) ^ -1439313193;
					continue;
				default:
					return;
				case 26u:
					break;
				case 8u:
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
			int num = 612723155;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x2CEE6CB8u) % 7u)
				{
				case 6u:
					num = ((int)num2 * -218347317) ^ 0x379B0E8B;
					continue;
				case 5u:
					GClass1.smethod_3().method_0();
					num = (int)((num2 * 1071555520) ^ 0x794DA74B);
					continue;
				case 4u:
					GClass1.smethod_0();
					num = (int)(num2 * 479308104) ^ -1352837153;
					continue;
				case 2u:
					GForm0.smethod_40((Control)(object)this, GForm0.smethod_39(GForm0.smethod_38(GForm0.smethod_37(), "\\data\\Images\\schermata_omegle.png")));
					GForm0.smethod_40((Control)(object)PictureBox_0, (Image)(object)smethod_0(GForm0.smethod_39(GForm0.smethod_38(GForm0.smethod_37(), "\\data\\Images\\marco_introduzione.png")), float_0));
					num = ((int)num2 * -72004778) ^ 0x30B90CD9;
					continue;
				case 1u:
					num = ((int)num2 * -515382825) ^ 0x441D5547;
					continue;
				case 0u:
					break;
				default:
					GForm0.smethod_41(Timer_1);
					return;
				}
				break;
			}
		}
	}

	public static Bitmap smethod_0(Image image_0, float float_1)
	{
		Bitmap val = GForm0.smethod_44(GForm0.smethod_42(image_0), GForm0.smethod_43(image_0));
		Graphics graphics_ = default(Graphics);
		ImageAttributes imageAttributes_ = default(ImageAttributes);
		ColorMatrix colorMatrix_ = default(ColorMatrix);
		Bitmap result = default(Bitmap);
		while (true)
		{
			int num = -110753728;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA85542EDu) % 8u)
				{
				case 7u:
					GForm0.smethod_50(graphics_, image_0, new Rectangle(0, 0, GForm0.smethod_42((Image)(object)val), GForm0.smethod_43((Image)(object)val)), 0, 0, GForm0.smethod_42(image_0), GForm0.smethod_43(image_0), (GraphicsUnit)2, imageAttributes_);
					num = (int)(num2 * 425750233) ^ -215196880;
					continue;
				case 6u:
					colorMatrix_ = GForm0.smethod_46();
					GForm0.smethod_47(colorMatrix_, float_1);
					num = ((int)num2 * -776546533) ^ 0x21191C2E;
					continue;
				case 5u:
					graphics_ = GForm0.smethod_45((Image)(object)val);
					num = ((int)num2 * -987727159) ^ 0x2C97CB1E;
					continue;
				case 4u:
					num = (int)((num2 * 120514523) ^ 0x658F7146);
					continue;
				case 2u:
					GForm0.smethod_51(graphics_);
					result = val;
					num = (int)((num2 * 1841168046) ^ 0x47BE17E2);
					continue;
				case 1u:
					imageAttributes_ = GForm0.smethod_48();
					GForm0.smethod_49(imageAttributes_, colorMatrix_, (ColorMatrixFlag)0, (ColorAdjustType)1);
					num = ((int)num2 * -598537778) ^ -1578773065;
					continue;
				case 0u:
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
			int num = -1786734587;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF31527DCu) % 4u)
				{
				case 3u:
					num = (int)(num2 * 1751700749) ^ -79353295;
					continue;
				case 1u:
					GForm0.smethod_52();
					num = (int)(num2 * 1071769801) ^ -1230470958;
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

	private void method_3(object sender, FormClosingEventArgs e)
	{
		bool flag = default(bool);
		while (true)
		{
			int num = -1696526773;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xBA6DD7BFu) % 8u)
				{
				case 6u:
					num = ((int)num2 * -625615801) ^ 0x6CBABB84;
					continue;
				case 5u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = -1271027059;
						num4 = -1271027059;
					}
					else
					{
						num3 = -1335138298;
						num4 = -1335138298;
					}
					num = num3 ^ ((int)num2 * -1005151345);
					continue;
				}
				case 4u:
					method_4();
					num = (int)(num2 * 178407503) ^ -843356784;
					continue;
				case 3u:
					flag = !bool_0;
					num = ((int)num2 * -981396054) ^ 0x3FFFB014;
					continue;
				case 2u:
					GForm0.smethod_53((CancelEventArgs)(object)e, bool_1: true);
					num = ((int)num2 * -1518519859) ^ -1673055589;
					continue;
				case 1u:
					num = -701356809;
					continue;
				default:
					return;
				case 7u:
					break;
				case 0u:
					return;
				}
				break;
			}
		}
	}

	public void method_4()
	{
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Invalid comparison between Unknown and I4
		bool flag = default(bool);
		while (true)
		{
			int num = -945863436;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD4EEEED1u) % 20u)
				{
				case 19u:
					GForm0.smethod_52();
					num = ((int)num2 * -1713484375) ^ -995499122;
					continue;
				case 18u:
					GForm0.smethod_56((object)Timer_0);
					GForm0.smethod_56((object)bool_0);
					num = ((int)num2 * -1452711996) ^ -155845810;
					continue;
				case 17u:
					GForm0.smethod_56((object)Timer_0);
					num = ((int)num2 * -1991398855) ^ -1540167489;
					continue;
				case 16u:
					flag = (int)GForm0.smethod_54("Sei sicuro di voler uscire dal gioco?", "The Omegle Game", (MessageBoxButtons)4, (MessageBoxIcon)32) == 6;
					num = ((int)num2 * -703392507) ^ 0xEF2887;
					continue;
				case 15u:
					GForm0.smethod_56((object)bool_0);
					num = (int)(num2 * 2083209536) ^ -752549504;
					continue;
				case 14u:
					num = -704932832;
					continue;
				case 13u:
					GForm0.smethod_52();
					num = ((int)num2 * -1042425175) ^ 0x19F45324;
					continue;
				case 11u:
					num = (int)(num2 * 1413765116) ^ -889594223;
					continue;
				case 10u:
					num = -1289738454;
					continue;
				case 9u:
				{
					int num5;
					int num6;
					if (!bool_0)
					{
						num5 = 476865484;
						num6 = 476865484;
					}
					else
					{
						num5 = 676900962;
						num6 = 676900962;
					}
					num = num5 ^ (int)(num2 * 637960121);
					continue;
				}
				case 8u:
					num = (int)((num2 * 1219977059) ^ 0x354DA249);
					continue;
				case 7u:
					num = (int)(num2 * 907896328) ^ -15600842;
					continue;
				case 6u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = 1153859076;
						num4 = 1153859076;
					}
					else
					{
						num3 = 1948257531;
						num4 = 1948257531;
					}
					num = num3 ^ ((int)num2 * -725438290);
					continue;
				}
				case 5u:
					GForm0.smethod_55(Timer_0);
					num = ((int)num2 * -1738540757) ^ 0x359022EF;
					continue;
				case 4u:
					GForm0.smethod_57(GForm0.smethod_35());
					num = ((int)num2 * -1876664961) ^ -285466858;
					continue;
				case 3u:
					num = ((int)num2 * -1791606631) ^ 0x20863EC8;
					continue;
				case 1u:
					GForm0.smethod_55(Timer_0);
					num = ((int)num2 * -1737174978) ^ -2142215695;
					continue;
				case 0u:
					num = (int)((num2 * 1352649303) ^ 0x494C6351);
					continue;
				default:
					return;
				case 2u:
					break;
				case 12u:
					return;
				}
				break;
			}
		}
	}

	private void method_5(object sender, EventArgs e)
	{
		bool flag4 = default(bool);
		bool flag3 = default(bool);
		bool flag = default(bool);
		bool flag2 = default(bool);
		while (true)
		{
			int num = -1426566000;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC66A2213u) % 45u)
				{
				case 44u:
					num = ((int)num2 * -920647360) ^ -376025788;
					continue;
				case 43u:
					GForm0.smethod_52();
					num = ((int)num2 * -833567116) ^ -896758594;
					continue;
				case 42u:
					GForm0.smethod_56((object)Timer_1);
					GForm0.smethod_56((object)int_0);
					num = (int)((num2 * 536839088) ^ 0x7BB16E75);
					continue;
				case 41u:
					flag4 = (int_0 >= 21) & (int_0 <= 49);
					num = -2023405561;
					continue;
				case 40u:
				{
					PictureBox control_;
					GForm0.smethod_65((Control)(object)(control_ = PictureBox_0), checked(GForm0.smethod_64((Control)(object)control_) + 22));
					num = -781755487;
					continue;
				}
				case 39u:
				{
					int num7;
					int num8;
					if (flag3)
					{
						num7 = 1776449938;
						num8 = 1776449938;
					}
					else
					{
						num7 = 831940932;
						num8 = 831940932;
					}
					num = num7 ^ ((int)num2 * -1861229352);
					continue;
				}
				case 38u:
					flag = (int_0 >= 50) & (int_0 <= 57);
					num = -1277073748;
					continue;
				case 37u:
					flag2 = (int_0 >= 16) & (int_0 <= 20);
					num = -1011935062;
					continue;
				case 36u:
					num = ((int)num2 * -789056681) ^ -1738319595;
					continue;
				case 35u:
				{
					PictureBox control_;
					GForm0.smethod_65((Control)(object)(control_ = PictureBox_0), checked(GForm0.smethod_64((Control)(object)control_) + 30));
					num = (int)((num2 * 178797627) ^ 0x7DCD12F);
					continue;
				}
				case 34u:
					checked
					{
						int_0++;
					}
					num = (int)((num2 * 780030174) ^ 0x13855E30);
					continue;
				case 33u:
					num = (int)(num2 * 164414716) ^ -932859020;
					continue;
				case 32u:
					num = ((int)num2 * -1076922347) ^ 0x7F63DB53;
					continue;
				case 31u:
					GForm0.smethod_40((Control)(object)PictureBox_0, (Image)(object)smethod_0(GForm0.smethod_58((Control)(object)PictureBox_0), float_0));
					num = (int)(num2 * 1486860579) ^ -1301362326;
					continue;
				case 30u:
					GForm0.smethod_55(Timer_1);
					num = ((int)num2 * -1520997468) ^ 0x2E988941;
					continue;
				case 29u:
				{
					PictureBox control_;
					GForm0.smethod_63((Control)(object)(control_ = PictureBox_0), checked(GForm0.smethod_62((Control)(object)control_) + 30));
					num = (int)(num2 * 1973790678) ^ -1838261506;
					continue;
				}
				case 28u:
					num = (int)(num2 * 23322227) ^ -1931248580;
					continue;
				case 27u:
					GForm0.smethod_12((Control)(object)PictureBox_0, new Point(512, 0));
					num = ((int)num2 * -1785368157) ^ -1965239438;
					continue;
				case 26u:
					num = ((int)num2 * -1394868499) ^ -1305992852;
					continue;
				case 25u:
					num = (int)(num2 * 1882891687) ^ -1935269800;
					continue;
				case 24u:
				{
					int num11;
					if (!((int_0 >= 57) & (int_0 <= 65)))
					{
						num = -1632209702;
						num11 = -1632209702;
					}
					else
					{
						num = -1039642455;
						num11 = -1039642455;
					}
					continue;
				}
				case 23u:
					flag3 = int_0 <= 15;
					num = (int)((num2 * 1418801607) ^ 0x3DB1DB1A);
					continue;
				case 22u:
					checked
					{
						int_0++;
					}
					num = (int)(num2 * 410139896) ^ -1312494897;
					continue;
				case 20u:
					GForm0.smethod_40((Control)(object)PictureBox_0, GForm0.smethod_39(GForm0.smethod_38(GForm0.smethod_37(), "\\data\\Images\\marco_introduzione.png")));
					num = ((int)num2 * -2045873804) ^ -214260657;
					continue;
				case 19u:
					num = (int)((num2 * 378170943) ^ 0x3E1F2E92);
					continue;
				case 18u:
					num = ((int)num2 * -204863063) ^ 0x2A97744B;
					continue;
				case 17u:
					GForm0.smethod_56((object)float_0);
					num = (int)(num2 * 2134193126) ^ -1982589188;
					continue;
				case 16u:
				{
					ref float reference = ref float_0;
					reference = (float)((double)reference + 0.3);
					num = (int)(num2 * 1470986656) ^ -345830099;
					continue;
				}
				case 15u:
					num = ((int)num2 * -1002606348) ^ -1322955252;
					continue;
				case 14u:
					GClass1.smethod_3().method_3();
					num = (int)(num2 * 284351672) ^ -1185412224;
					continue;
				case 13u:
					num = (int)((num2 * 1857813348) ^ 0x65750840);
					continue;
				case 12u:
					GClass1.smethod_3().method_4();
					num = ((int)num2 * -1612218161) ^ -270022549;
					continue;
				case 11u:
				{
					int num9;
					int num10;
					if (flag4)
					{
						num9 = 197479444;
						num10 = 197479444;
					}
					else
					{
						num9 = 357813978;
						num10 = 357813978;
					}
					num = num9 ^ (int)(num2 * 1687023923);
					continue;
				}
				case 10u:
				{
					int num5;
					int num6;
					if (flag2)
					{
						num5 = 1172580503;
						num6 = 1172580503;
					}
					else
					{
						num5 = 214284736;
						num6 = 214284736;
					}
					num = num5 ^ ((int)num2 * -109583016);
					continue;
				}
				case 9u:
					num = ((int)num2 * -720578900) ^ 0x2D6F93C;
					continue;
				case 8u:
					num = (int)((num2 * 650263871) ^ 0x503D7D70);
					continue;
				case 7u:
					checked
					{
						int_0++;
					}
					num = ((int)num2 * -1023471392) ^ -1127068559;
					continue;
				case 6u:
					num = ((int)num2 * -201867222) ^ -1982016664;
					continue;
				case 5u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = -1211840301;
						num4 = -1211840301;
					}
					else
					{
						num3 = -859105872;
						num4 = -859105872;
					}
					num = num3 ^ (int)(num2 * 204133084);
					continue;
				}
				case 4u:
					GForm0.smethod_40((Control)(object)PictureBox_0, GForm0.smethod_39(GForm0.smethod_38(GForm0.smethod_37(), "\\data\\Images\\marco_introduzione.png")));
					checked
					{
						GForm0.smethod_12((Control)(object)PictureBox_0, new Point((int)GForm0.smethod_61((double)((float)GForm0.smethod_59((Control)(object)PictureBox_0).X + GForm0.smethod_60() * 10f)), (int)GForm0.smethod_61((double)((float)GForm0.smethod_59((Control)(object)PictureBox_0).Y - GForm0.smethod_60() * 10f))));
						int_0++;
					}
					num = ((int)num2 * -311246326) ^ -1824138823;
					continue;
				case 3u:
					num = (int)(num2 * 1615944082) ^ -344085348;
					continue;
				case 2u:
					num = ((int)num2 * -327366831) ^ -1245512643;
					continue;
				case 1u:
					checked
					{
						int_0++;
					}
					num = ((int)num2 * -804018841) ^ 0x3967E221;
					continue;
				default:
					return;
				case 0u:
					break;
				case 21u:
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
