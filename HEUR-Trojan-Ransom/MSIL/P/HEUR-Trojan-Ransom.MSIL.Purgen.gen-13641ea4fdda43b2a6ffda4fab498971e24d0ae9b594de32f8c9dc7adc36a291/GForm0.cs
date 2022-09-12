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
				int num = -2111966205;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xFD3211D2u) % 9u)
					{
					case 8u:
						GForm0.smethod_34(val, eventHandler_);
						num = (int)(num2 * 66898095) ^ -1308464129;
						continue;
					case 7u:
					{
						int num5;
						int num6;
						if (val == null)
						{
							num5 = 1156183081;
							num6 = 1156183081;
						}
						else
						{
							num5 = 701675324;
							num6 = 701675324;
						}
						num = num5 ^ (int)(num2 * 1051251017);
						continue;
					}
					case 6u:
						val = timer_0;
						num = (int)((num2 * 1492264866) ^ 0x64C4A3B);
						continue;
					case 4u:
						GForm0.smethod_33(val, eventHandler_);
						num = ((int)num2 * -1320879912) ^ -1082844555;
						continue;
					case 3u:
						timer_0 = value;
						num = -2073891082;
						continue;
					case 1u:
					{
						int num3;
						int num4;
						if (val != null)
						{
							num3 = -424816784;
							num4 = -424816784;
						}
						else
						{
							num3 = -1439486618;
							num4 = -1439486618;
						}
						num = num3 ^ ((int)num2 * -1203542879);
						continue;
					}
					case 0u:
						val = timer_0;
						num = (int)((num2 * 1014569998) ^ 0x2487B968);
						continue;
					default:
						return;
					case 5u:
						break;
					case 2u:
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
				int num = -2050314799;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x9FA9C46Au) % 7u)
					{
					case 5u:
					{
						val = timer_1;
						int num5;
						int num6;
						if (val != null)
						{
							num5 = 1632464544;
							num6 = 1632464544;
						}
						else
						{
							num5 = 241979208;
							num6 = 241979208;
						}
						num = num5 ^ (int)(num2 * 1671549270);
						continue;
					}
					case 4u:
						GForm0.smethod_34(val, eventHandler_);
						num = (int)((num2 * 1890256701) ^ 0x15E71CA7);
						continue;
					case 3u:
					{
						val = timer_1;
						int num3;
						int num4;
						if (val != null)
						{
							num3 = 1484123789;
							num4 = 1484123789;
						}
						else
						{
							num3 = 709627860;
							num4 = 709627860;
						}
						num = num3 ^ ((int)num2 * -659339635);
						continue;
					}
					case 2u:
						timer_1 = value;
						num = -37573672;
						continue;
					case 1u:
						GForm0.smethod_33(val, eventHandler_);
						num = (int)(num2 * 1110136261) ^ -1584200734;
						continue;
					default:
						return;
					case 0u:
						break;
					case 6u:
						return;
					}
					break;
				}
			}
		}
	}

	public GForm0()
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected O, but got Unknown
		GForm0.smethod_1((Form)(object)this, (EventHandler)method_1);
		GForm0.smethod_2((Form)(object)this, new FormClosingEventHandler(method_3));
		bool_0 = false;
		float_0 = 0.1f;
		int_0 = 0;
		method_0();
	}

	[DebuggerNonUserCode]
	void Form.Dispose(bool disposing)
	{
		try
		{
			while (true)
			{
				int num = 155212706;
				while (true)
				{
					uint num2;
					int num3;
					switch ((num2 = (uint)num ^ 0x4B7E83DFu) % 6u)
					{
					case 5u:
						if (icontainer_0 != null)
						{
							num = 2095422945;
							num3 = 2095422945;
							continue;
						}
						goto IL_001e;
					case 2u:
						GForm0.smethod_3((IDisposable)icontainer_0);
						num = (int)(num2 * 130921983) ^ -1666557467;
						continue;
					case 1u:
						if (disposing)
						{
							num = ((int)num2 * -2106482495) ^ 0x476F8DE3;
							continue;
						}
						goto IL_001e;
					case 0u:
						num = 1261558149;
						continue;
					default:
						return;
					case 3u:
						break;
					case 4u:
						return;
						IL_001e:
						num = 1696640039;
						num3 = 1696640039;
						continue;
					}
					break;
				}
			}
		}
		finally
		{
			((Form)this).Dispose(disposing);
			while (true)
			{
				IL_00c4:
				int num4 = 373087692;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num4 ^ 0x4B7E83DFu) % 3u)
					{
					case 2u:
						goto IL_009a;
					default:
						goto end_IL_00a7;
					case 0u:
						break;
					case 1u:
						goto end_IL_00a7;
					}
					goto IL_00c4;
					IL_009a:
					num4 = ((int)num2 * -766417607) ^ 0x2BC398F2;
					continue;
					end_IL_00a7:
					break;
				}
				break;
			}
		}
	}

	[DebuggerStepThrough]
	private void method_0()
	{
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		icontainer_0 = GForm0.smethod_4();
		while (true)
		{
			int num = 856486423;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3958933Au) % 41u)
				{
				case 40u:
					GForm0.smethod_16(PictureBox_0, bool_1: false);
					GForm0.smethod_9(Timer_1, 500);
					num = (int)(num2 * 1279776484) ^ -1906004905;
					continue;
				case 39u:
					GForm0.smethod_31((ISupportInitialize)PictureBox_0);
					num = ((int)num2 * -731803226) ^ -1025664214;
					continue;
				case 38u:
					GForm0.smethod_29((Form)(object)this, (FormStartPosition)1);
					num = (int)(num2 * 1192743327) ^ -1679828324;
					continue;
				case 37u:
					GForm0.smethod_19((Form)(object)this, Color.White);
					GForm0.smethod_11((Control)(object)this, (ImageLayout)3);
					num = ((int)num2 * -792727746) ^ 0x3F063485;
					continue;
				case 36u:
					GForm0.smethod_9(Timer_0, 1000);
					num = ((int)num2 * -1850409274) ^ -1900598568;
					continue;
				case 35u:
					GForm0.smethod_11((Control)(object)PictureBox_0, (ImageLayout)3);
					num = ((int)num2 * -2011683418) ^ 0xF61D7AD;
					continue;
				case 34u:
					num = (int)((num2 * 754487809) ^ 0x5FE24AE7);
					continue;
				case 33u:
					GForm0.smethod_7((ISupportInitialize)PictureBox_0);
					num = ((int)num2 * -1661043050) ^ 0x39EB2DA9;
					continue;
				case 32u:
					GForm0.smethod_22(GForm0.smethod_21((Control)(object)this), (Control)(object)PictureBox_0);
					num = ((int)num2 * -1815653685) ^ -1569951976;
					continue;
				case 31u:
					num = (int)(num2 * 1880506708) ^ -1455559094;
					continue;
				case 30u:
					num = ((int)num2 * -28819447) ^ -2096982376;
					continue;
				case 29u:
					num = (int)(num2 * 2058012498) ^ -803299662;
					continue;
				case 28u:
					GForm0.smethod_26((Form)(object)this, new Padding(4));
					num = (int)(num2 * 1002326593) ^ -54109032;
					continue;
				case 27u:
					GForm0.smethod_27((Form)(object)this, bool_1: false);
					GForm0.smethod_28((Control)(object)this, "Introduction");
					num = (int)(num2 * 1379798995) ^ -2054999254;
					continue;
				case 26u:
					GForm0.smethod_17((ContainerControl)(object)this, new SizeF(10f, 22f));
					num = (int)(num2 * 1774000257) ^ -1867900896;
					continue;
				case 25u:
					GForm0.smethod_24((Control)(object)this, GForm0.smethod_23("Consolas", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 1118385822) ^ 0x3E862CC6);
					continue;
				case 24u:
					num = ((int)num2 * -1754738436) ^ 0x106FD13B;
					continue;
				case 23u:
					GForm0.smethod_8((Control)(object)this);
					num = (int)((num2 * 38686832) ^ 0xC4593C6);
					continue;
				case 22u:
					Timer_0 = GForm0.smethod_5(icontainer_0);
					PictureBox_0 = GForm0.smethod_6();
					num = (int)((num2 * 577333200) ^ 0x47BACCBF);
					continue;
				case 21u:
					num = ((int)num2 * -165704089) ^ -1575185182;
					continue;
				case 20u:
					((Control)this).set_DoubleBuffered(true);
					num = (int)(num2 * 1743339268) ^ -139017441;
					continue;
				case 19u:
					GForm0.smethod_30((Form)(object)this, "The Omegle Game");
					num = (int)((num2 * 1418510619) ^ 0x10FD876A);
					continue;
				case 18u:
					GForm0.smethod_12((Control)(object)PictureBox_0, new Point(365, 415));
					GForm0.smethod_13((Control)(object)PictureBox_0, "PictureBox1");
					num = ((int)num2 * -1730349388) ^ -239639928;
					continue;
				case 16u:
					GForm0.smethod_10((Control)(object)PictureBox_0, Color.Transparent);
					num = (int)((num2 * 975568029) ^ 0x490B4924);
					continue;
				case 15u:
					num = ((int)num2 * -1271649955) ^ 0x979E7B7;
					continue;
				case 14u:
					num = ((int)num2 * -843111556) ^ 0x76439718;
					continue;
				case 13u:
					GForm0.smethod_25((Form)(object)this, (FormBorderStyle)1);
					num = ((int)num2 * -1977838583) ^ 0x281B1246;
					continue;
				case 12u:
					GForm0.smethod_20((Form)(object)this, new Size(1025, 638));
					num = (int)(num2 * 608024994) ^ -1019051903;
					continue;
				case 10u:
					GForm0.smethod_14((Control)(object)PictureBox_0, new Size(302, 211));
					num = (int)(num2 * 883803856) ^ -805754067;
					continue;
				case 9u:
					GForm0.smethod_32((Control)(object)this, bool_1: false);
					num = ((int)num2 * -1620579867) ^ -925214021;
					continue;
				case 8u:
					GForm0.smethod_18((ContainerControl)(object)this, (AutoScaleMode)1);
					num = ((int)num2 * -1767025988) ^ 0x35351D52;
					continue;
				case 7u:
					num = ((int)num2 * -1481505240) ^ 0x7BBC6A31;
					continue;
				case 6u:
					Timer_1 = GForm0.smethod_5(icontainer_0);
					num = (int)((num2 * 2070715760) ^ 0xB331063);
					continue;
				case 5u:
					num = ((int)num2 * -1948797277) ^ 0x5ADA7ECD;
					continue;
				case 4u:
					GForm0.smethod_15(PictureBox_0, 0);
					num = (int)((num2 * 701064980) ^ 0x7A9F6631);
					continue;
				case 3u:
					num = ((int)num2 * -627437611) ^ -1903194315;
					continue;
				case 2u:
					num = (int)((num2 * 62383747) ^ 0x50FE6AA3);
					continue;
				case 1u:
					num = ((int)num2 * -396304393) ^ -1459234229;
					continue;
				case 0u:
					num = (int)(num2 * 1885699253) ^ -255676216;
					continue;
				default:
					return;
				case 11u:
					break;
				case 17u:
					return;
				}
				break;
			}
		}
	}

	private void method_1(object sender, EventArgs e)
	{
		GForm0.smethod_36(GForm0.smethod_35(), ProcessPriorityClass.RealTime);
		GForm0.smethod_40((Control)(object)this, GForm0.smethod_39(GForm0.smethod_38(GForm0.smethod_37(), "\\data\\Images\\schermata_omegle.png")));
		while (true)
		{
			int num = 2133750307;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x77129DACu) % 8u)
				{
				case 7u:
					num = ((int)num2 * -364827427) ^ 0x24CC4D9;
					continue;
				case 6u:
					GForm0.smethod_40((Control)(object)PictureBox_0, (Image)(object)smethod_0(GForm0.smethod_39(GForm0.smethod_38(GForm0.smethod_37(), "\\data\\Images\\marco_introduzione.png")), float_0));
					GClass1.smethod_0();
					num = (int)(num2 * 34785538) ^ -1982346844;
					continue;
				case 5u:
					GForm0.smethod_41(Timer_1);
					num = (int)(num2 * 334922295) ^ -1122860498;
					continue;
				case 4u:
					num = ((int)num2 * -1033327085) ^ -1833395749;
					continue;
				case 3u:
					GClass1.smethod_3().method_0();
					num = (int)((num2 * 856498359) ^ 0x367BED53);
					continue;
				case 2u:
					num = (int)((num2 * 831186564) ^ 0x114D5E71);
					continue;
				default:
					return;
				case 0u:
					break;
				case 1u:
					return;
				}
				break;
			}
		}
	}

	public static Bitmap smethod_0(Image image_0, float float_1)
	{
		Bitmap val = GForm0.smethod_44(GForm0.smethod_42(image_0), GForm0.smethod_43(image_0));
		Bitmap result = default(Bitmap);
		Graphics graphics_ = default(Graphics);
		ColorMatrix colorMatrix_ = default(ColorMatrix);
		while (true)
		{
			int num = 890316361;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x2B5981D5u) % 6u)
				{
				case 5u:
					result = val;
					num = ((int)num2 * -1263334079) ^ 0x7C437F06;
					continue;
				case 2u:
					graphics_ = GForm0.smethod_45((Image)(object)val);
					colorMatrix_ = GForm0.smethod_46();
					GForm0.smethod_47(colorMatrix_, float_1);
					num = (int)(num2 * 1807806376) ^ -1740078182;
					continue;
				case 1u:
				{
					ImageAttributes imageAttributes_ = GForm0.smethod_48();
					GForm0.smethod_49(imageAttributes_, colorMatrix_, (ColorMatrixFlag)0, (ColorAdjustType)1);
					GForm0.smethod_50(graphics_, image_0, new Rectangle(0, 0, GForm0.smethod_42((Image)(object)val), GForm0.smethod_43((Image)(object)val)), 0, 0, GForm0.smethod_42(image_0), GForm0.smethod_43(image_0), (GraphicsUnit)2, imageAttributes_);
					GForm0.smethod_51(graphics_);
					num = (int)(num2 * 460901790) ^ -1446341556;
					continue;
				}
				case 0u:
					num = (int)(num2 * 805677423) ^ -1887697438;
					continue;
				case 4u:
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
		GForm0.smethod_52();
	}

	private void method_3(object sender, FormClosingEventArgs e)
	{
		method_4();
		bool flag = default(bool);
		while (true)
		{
			int num = 641547625;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x58A2CDC8u) % 8u)
				{
				case 7u:
					num = (int)(num2 * 157530483) ^ -1310487632;
					continue;
				case 6u:
					num = 1131175916;
					continue;
				case 5u:
					num = ((int)num2 * -474896808) ^ 0x265D0916;
					continue;
				case 2u:
					GForm0.smethod_53((CancelEventArgs)(object)e, bool_1: true);
					num = ((int)num2 * -208435969) ^ -138439191;
					continue;
				case 1u:
					flag = !bool_0;
					num = ((int)num2 * -175197482) ^ -634726986;
					continue;
				case 0u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = -1399721830;
						num4 = -1399721830;
					}
					else
					{
						num3 = -63788930;
						num4 = -63788930;
					}
					num = num3 ^ ((int)num2 * -1976917166);
					continue;
				}
				default:
					return;
				case 3u:
					break;
				case 4u:
					return;
				}
				break;
			}
		}
	}

	public void method_4()
	{
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Invalid comparison between Unknown and I4
		bool flag = default(bool);
		bool flag2 = default(bool);
		while (true)
		{
			int num = -1928921649;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x99D4877Cu) % 23u)
				{
				case 22u:
					GForm0.smethod_57(GForm0.smethod_35());
					num = (int)(num2 * 1205913007) ^ -1179406471;
					continue;
				case 20u:
					num = ((int)num2 * -786955486) ^ 0x6999EEDB;
					continue;
				case 19u:
					GForm0.smethod_56((object)Timer_0);
					num = (int)((num2 * 1315581286) ^ 0x79DB260A);
					continue;
				case 18u:
					num = (int)(num2 * 773980260) ^ -1738810542;
					continue;
				case 17u:
					num = (int)((num2 * 455352552) ^ 0x68223BBB);
					continue;
				case 16u:
					flag = (int)GForm0.smethod_54("Sei sicuro di voler uscire dal gioco?", "The Omegle Game", (MessageBoxButtons)4, (MessageBoxIcon)32) == 6;
					num = ((int)num2 * -1505075161) ^ -1654750899;
					continue;
				case 15u:
					num = -790203754;
					continue;
				case 14u:
					num = ((int)num2 * -1735174447) ^ -950180671;
					continue;
				case 13u:
					GForm0.smethod_52();
					num = ((int)num2 * -641665702) ^ -885746206;
					continue;
				case 12u:
					GForm0.smethod_56((object)bool_0);
					num = ((int)num2 * -101080942) ^ -398137219;
					continue;
				case 11u:
					GForm0.smethod_56((object)bool_0);
					num = ((int)num2 * -545858201) ^ 0x3ACC3D3F;
					continue;
				case 10u:
					GForm0.smethod_55(Timer_0);
					num = (int)((num2 * 1194456008) ^ 0x7650EB8D);
					continue;
				case 9u:
					GForm0.smethod_55(Timer_0);
					GForm0.smethod_56((object)Timer_0);
					num = ((int)num2 * -1005247851) ^ 0x6400C54C;
					continue;
				case 8u:
					flag2 = !bool_0;
					num = (int)(num2 * 956387894) ^ -911180406;
					continue;
				case 7u:
					num = ((int)num2 * -98466809) ^ -431418260;
					continue;
				case 5u:
					num = (int)(num2 * 2042420934) ^ -1049976900;
					continue;
				case 4u:
					num = -664225795;
					continue;
				case 3u:
				{
					int num5;
					int num6;
					if (flag2)
					{
						num5 = -2059845636;
						num6 = -2059845636;
					}
					else
					{
						num5 = -2137221828;
						num6 = -2137221828;
					}
					num = num5 ^ (int)(num2 * 321022383);
					continue;
				}
				case 2u:
					num = (int)(num2 * 332848659) ^ -129220318;
					continue;
				case 1u:
					GForm0.smethod_52();
					num = (int)(num2 * 105041386) ^ -432258134;
					continue;
				case 0u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = 1994952716;
						num4 = 1994952716;
					}
					else
					{
						num3 = 509747468;
						num4 = 509747468;
					}
					num = num3 ^ ((int)num2 * -1579094731);
					continue;
				}
				default:
					return;
				case 21u:
					break;
				case 6u:
					return;
				}
				break;
			}
		}
	}

	private void method_5(object sender, EventArgs e)
	{
		bool flag3 = default(bool);
		bool flag = default(bool);
		bool flag2 = default(bool);
		while (true)
		{
			int num = -1845842341;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB2AC6256u) % 40u)
				{
				case 39u:
					GForm0.smethod_40((Control)(object)PictureBox_0, GForm0.smethod_39(GForm0.smethod_38(GForm0.smethod_37(), "\\data\\Images\\marco_introduzione.png")));
					num = (int)(num2 * 79530664) ^ -1466909505;
					continue;
				case 38u:
					num = ((int)num2 * -1678144271) ^ 0x3740B90A;
					continue;
				case 37u:
					GForm0.smethod_40((Control)(object)PictureBox_0, (Image)(object)smethod_0(GForm0.smethod_58((Control)(object)PictureBox_0), float_0));
					num = (int)((num2 * 1172003695) ^ 0x1986003C);
					continue;
				case 36u:
				{
					PictureBox control_;
					GForm0.smethod_65((Control)(object)(control_ = PictureBox_0), checked(GForm0.smethod_64((Control)(object)control_) + 30));
					num = (int)((num2 * 363378823) ^ 0x1FAF2E75);
					continue;
				}
				case 35u:
					GForm0.smethod_55(Timer_1);
					GForm0.smethod_56((object)float_0);
					num = ((int)num2 * -296439686) ^ -1563012536;
					continue;
				case 34u:
				{
					PictureBox control_;
					GForm0.smethod_65((Control)(object)(control_ = PictureBox_0), checked(GForm0.smethod_64((Control)(object)control_) + 22));
					num = -239758350;
					continue;
				}
				case 33u:
					flag3 = (int_0 >= 50) & (int_0 <= 57);
					num = -253272673;
					continue;
				case 32u:
					num = (int)((num2 * 1362297176) ^ 0x15A69221);
					continue;
				case 31u:
					GClass1.smethod_3().method_4();
					num = ((int)num2 * -676652649) ^ -1163587119;
					continue;
				case 30u:
					num = ((int)num2 * -977078003) ^ -2066982702;
					continue;
				case 29u:
					checked
					{
						int_0++;
					}
					num = ((int)num2 * -402384987) ^ -1244442713;
					continue;
				case 28u:
				{
					int num9;
					int num10;
					if (!flag)
					{
						num9 = -2001158728;
						num10 = -2001158728;
					}
					else
					{
						num9 = -41937895;
						num10 = -41937895;
					}
					num = num9 ^ ((int)num2 * -2141665217);
					continue;
				}
				case 27u:
				{
					int num8;
					if (!((int_0 >= 16) & (int_0 <= 20)))
					{
						num = -11785996;
						num8 = -11785996;
					}
					else
					{
						num = -540674811;
						num8 = -540674811;
					}
					continue;
				}
				case 26u:
				{
					int num6;
					int num7;
					if (!flag2)
					{
						num6 = 1480123331;
						num7 = 1480123331;
					}
					else
					{
						num6 = 584675957;
						num7 = 584675957;
					}
					num = num6 ^ (int)(num2 * 339970431);
					continue;
				}
				case 25u:
				{
					int num4;
					int num5;
					if (flag3)
					{
						num4 = 1828551756;
						num5 = 1828551756;
					}
					else
					{
						num4 = 1216724337;
						num5 = 1216724337;
					}
					num = num4 ^ (int)(num2 * 1254023406);
					continue;
				}
				case 24u:
					GForm0.smethod_12((Control)(object)PictureBox_0, checked(new Point((int)GForm0.smethod_61((double)((float)GForm0.smethod_59((Control)(object)PictureBox_0).X + GForm0.smethod_60() * 10f)), (int)GForm0.smethod_61((double)((float)GForm0.smethod_59((Control)(object)PictureBox_0).Y - GForm0.smethod_60() * 10f)))));
					num = ((int)num2 * -1681176037) ^ 0x1B729693;
					continue;
				case 23u:
					checked
					{
						int_0++;
					}
					num = (int)(num2 * 1068245407) ^ -795656236;
					continue;
				case 22u:
					num = ((int)num2 * -1618625764) ^ 0x4B4DD4B2;
					continue;
				case 21u:
					num = ((int)num2 * -887970779) ^ 0x3C4A5F3;
					continue;
				case 20u:
				{
					PictureBox control_;
					GForm0.smethod_63((Control)(object)(control_ = PictureBox_0), checked(GForm0.smethod_62((Control)(object)control_) + 30));
					num = ((int)num2 * -1151238224) ^ -401931477;
					continue;
				}
				case 19u:
					GForm0.smethod_12((Control)(object)PictureBox_0, new Point(512, 0));
					num = ((int)num2 * -284067730) ^ 0xB27E52A;
					continue;
				case 17u:
					num = ((int)num2 * -1830596025) ^ -712492407;
					continue;
				case 16u:
					num = ((int)num2 * -700529219) ^ 0x677D72C;
					continue;
				case 15u:
					num = ((int)num2 * -1170550502) ^ -1397321414;
					continue;
				case 14u:
					GForm0.smethod_52();
					num = (int)((num2 * 372265607) ^ 0x58AD1384);
					continue;
				case 13u:
					flag2 = int_0 <= 15;
					num = (int)((num2 * 757378269) ^ 0x1A5356DD);
					continue;
				case 12u:
					GForm0.smethod_40((Control)(object)PictureBox_0, GForm0.smethod_39(GForm0.smethod_38(GForm0.smethod_37(), "\\data\\Images\\marco_introduzione.png")));
					num = (int)(num2 * 415544188) ^ -2133534443;
					continue;
				case 11u:
					num = (int)(num2 * 1101905334) ^ -1381446850;
					continue;
				case 10u:
					num = ((int)num2 * -323767412) ^ -2055759916;
					continue;
				case 9u:
					num = ((int)num2 * -814960480) ^ 0x5B03AF8;
					continue;
				case 8u:
					GForm0.smethod_56((object)Timer_1);
					num = (int)((num2 * 59395224) ^ 0x6A8ACE09);
					continue;
				case 7u:
					GForm0.smethod_56((object)int_0);
					GClass1.smethod_3().method_3();
					num = (int)(num2 * 365631604) ^ -2009902739;
					continue;
				case 6u:
				{
					ref float reference = ref float_0;
					reference = (float)((double)reference + 0.3);
					checked
					{
						int_0++;
					}
					num = (int)(num2 * 159009610) ^ -52061520;
					continue;
				}
				case 4u:
					checked
					{
						int_0++;
					}
					num = (int)((num2 * 1758260701) ^ 0x3FEA5474);
					continue;
				case 3u:
					checked
					{
						int_0++;
					}
					num = (int)((num2 * 1168322044) ^ 0x8CDCD94);
					continue;
				case 2u:
				{
					int num3;
					if (!((int_0 >= 21) & (int_0 <= 49)))
					{
						num = -644985033;
						num3 = -644985033;
					}
					else
					{
						num = -1011250135;
						num3 = -1011250135;
					}
					continue;
				}
				case 1u:
					flag = (int_0 >= 57) & (int_0 <= 65);
					num = -1711435646;
					continue;
				case 0u:
					num = ((int)num2 * -60038700) ^ 0x1FEEB576;
					continue;
				default:
					return;
				case 5u:
					break;
				case 18u:
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
