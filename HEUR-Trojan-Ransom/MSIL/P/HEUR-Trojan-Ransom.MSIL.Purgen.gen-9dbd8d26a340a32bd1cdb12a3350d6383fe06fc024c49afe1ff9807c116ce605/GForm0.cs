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
				int num = 731913680;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x2A87CC02u) % 8u)
					{
					case 7u:
						GForm0.smethod_33(val, eventHandler_);
						num = (int)(num2 * 747803993) ^ -754168325;
						continue;
					case 6u:
						timer_0 = value;
						num = 918183033;
						continue;
					case 5u:
						GForm0.smethod_34(val, eventHandler_);
						num = ((int)num2 * -1039404020) ^ 0x518D48BE;
						continue;
					case 3u:
					{
						val = timer_0;
						int num5;
						int num6;
						if (val == null)
						{
							num5 = 1202006119;
							num6 = 1202006119;
						}
						else
						{
							num5 = 836028586;
							num6 = 836028586;
						}
						num = num5 ^ (int)(num2 * 26803903);
						continue;
					}
					case 2u:
						val = timer_0;
						num = (int)((num2 * 745982696) ^ 0x62DA0A3B);
						continue;
					case 1u:
					{
						int num3;
						int num4;
						if (val == null)
						{
							num3 = -1031689882;
							num4 = -1031689882;
						}
						else
						{
							num3 = -891678601;
							num4 = -891678601;
						}
						num = num3 ^ ((int)num2 * -2055524638);
						continue;
					}
					default:
						return;
					case 4u:
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
				int num = -2079851077;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x82B9946Bu) % 7u)
					{
					case 6u:
						val = timer_1;
						num = ((int)num2 * -1750393023) ^ -1054100126;
						continue;
					case 4u:
					{
						int num4;
						int num5;
						if (val != null)
						{
							num4 = -699001428;
							num5 = -699001428;
						}
						else
						{
							num4 = -1693913344;
							num5 = -1693913344;
						}
						num = num4 ^ (int)(num2 * 216431108);
						continue;
					}
					case 3u:
						GForm0.smethod_34(val, eventHandler_);
						num = (int)(num2 * 1043524942) ^ -1501265029;
						continue;
					case 1u:
					{
						timer_1 = value;
						val = timer_1;
						int num3;
						if (val == null)
						{
							num = -925813649;
							num3 = -925813649;
						}
						else
						{
							num = -1902315763;
							num3 = -1902315763;
						}
						continue;
					}
					case 0u:
						GForm0.smethod_33(val, eventHandler_);
						num = ((int)num2 * -527153953) ^ 0x44D84F99;
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

	public GForm0()
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		while (true)
		{
			int num = -406832666;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x82FBD5ECu) % 7u)
				{
				case 6u:
					bool_0 = false;
					num = ((int)num2 * -154266582) ^ -399288826;
					continue;
				case 4u:
					num = ((int)num2 * -1150238070) ^ 0x710FDED8;
					continue;
				case 3u:
					GForm0.smethod_2((Form)(object)this, new FormClosingEventHandler(method_3));
					num = ((int)num2 * -1957384646) ^ -1636599566;
					continue;
				case 2u:
					GForm0.smethod_1((Form)(object)this, (EventHandler)method_1);
					num = ((int)num2 * -1289361997) ^ -1715280332;
					continue;
				case 1u:
					float_0 = 0.1f;
					num = ((int)num2 * -453726867) ^ -1415519058;
					continue;
				case 0u:
					break;
				default:
					int_0 = 0;
					method_0();
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
				int num = -466210475;
				while (true)
				{
					uint num2;
					int num3;
					switch ((num2 = (uint)num ^ 0x977B82CFu) % 7u)
					{
					case 6u:
						if (icontainer_0 != null)
						{
							num = -1433786354;
							num3 = -1433786354;
							continue;
						}
						goto IL_0012;
					case 5u:
						if (disposing)
						{
							num = ((int)num2 * -2600574) ^ -1986526577;
							continue;
						}
						goto IL_0012;
					case 4u:
						num = -846546108;
						continue;
					case 3u:
						num = ((int)num2 * -1009513067) ^ -828677902;
						continue;
					case 2u:
						GForm0.smethod_3((IDisposable)icontainer_0);
						num = ((int)num2 * -1362955309) ^ -806189918;
						continue;
					default:
						return;
					case 0u:
						break;
					case 1u:
						return;
						IL_0012:
						num = -256000604;
						num3 = -256000604;
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
				IL_00d7:
				int num4 = -704543873;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num4 ^ 0x977B82CFu) % 3u)
					{
					case 1u:
						goto IL_00ad;
					default:
						goto end_IL_00ba;
					case 0u:
						break;
					case 2u:
						goto end_IL_00ba;
					}
					goto IL_00d7;
					IL_00ad:
					num4 = ((int)num2 * -1485747263) ^ 0x6BCF871E;
					continue;
					end_IL_00ba:
					break;
				}
				break;
			}
		}
	}

	[DebuggerStepThrough]
	private void method_0()
	{
		//IL_0328: Unknown result type (might be due to invalid IL or missing references)
		icontainer_0 = GForm0.smethod_4();
		Timer_0 = GForm0.smethod_5(icontainer_0);
		while (true)
		{
			int num = 21502178;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x40937D35u) % 35u)
				{
				case 34u:
					num = ((int)num2 * -1513451743) ^ 0x1F72DB43;
					continue;
				case 33u:
					num = ((int)num2 * -440966309) ^ -1508259709;
					continue;
				case 32u:
					GForm0.smethod_31((ISupportInitialize)PictureBox_0);
					num = (int)(num2 * 269444382) ^ -722883414;
					continue;
				case 31u:
					num = ((int)num2 * -1448643553) ^ -1013459952;
					continue;
				case 30u:
					PictureBox_0 = GForm0.smethod_6();
					num = (int)(num2 * 596640235) ^ -2060228107;
					continue;
				case 29u:
					num = ((int)num2 * -703488117) ^ 0x167DA2C;
					continue;
				case 28u:
					GForm0.smethod_22(GForm0.smethod_21((Control)(object)this), (Control)(object)PictureBox_0);
					num = ((int)num2 * -318215560) ^ -2048615841;
					continue;
				case 26u:
					num = ((int)num2 * -2139581496) ^ -2038183976;
					continue;
				case 25u:
					GForm0.smethod_32((Control)(object)this, bool_1: false);
					num = ((int)num2 * -1303257783) ^ -1725828824;
					continue;
				case 24u:
					GForm0.smethod_29((Form)(object)this, (FormStartPosition)1);
					num = (int)((num2 * 2106515180) ^ 0x3024F26D);
					continue;
				case 23u:
					((Control)this).set_DoubleBuffered(true);
					num = ((int)num2 * -361766019) ^ 0x4EAD48C3;
					continue;
				case 22u:
					GForm0.smethod_14((Control)(object)PictureBox_0, new Size(302, 211));
					num = ((int)num2 * -1732540712) ^ 0x15464458;
					continue;
				case 21u:
					num = (int)(num2 * 1265019615) ^ -1254470593;
					continue;
				case 20u:
					GForm0.smethod_10((Control)(object)PictureBox_0, Color.Transparent);
					GForm0.smethod_11((Control)(object)PictureBox_0, (ImageLayout)3);
					num = (int)((num2 * 959818453) ^ 0x143E1B3F);
					continue;
				case 19u:
					GForm0.smethod_9(Timer_0, 1000);
					num = (int)(num2 * 1766414558) ^ -299757997;
					continue;
				case 18u:
					GForm0.smethod_25((Form)(object)this, (FormBorderStyle)1);
					num = (int)(num2 * 74473819) ^ -146725128;
					continue;
				case 17u:
					GForm0.smethod_18((ContainerControl)(object)this, (AutoScaleMode)1);
					num = (int)(num2 * 1418028481) ^ -20485079;
					continue;
				case 16u:
					GForm0.smethod_24((Control)(object)this, GForm0.smethod_23("Consolas", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1531235988) ^ -1496830140;
					continue;
				case 15u:
					num = ((int)num2 * -1599254820) ^ 0x538FD1A2;
					continue;
				case 14u:
					GForm0.smethod_11((Control)(object)this, (ImageLayout)3);
					num = (int)((num2 * 379666096) ^ 0x10DC21E4);
					continue;
				case 13u:
					GForm0.smethod_20((Form)(object)this, new Size(1025, 638));
					num = ((int)num2 * -2039463121) ^ -1178591151;
					continue;
				case 12u:
					num = ((int)num2 * -447511701) ^ 0x7382A34A;
					continue;
				case 11u:
					GForm0.smethod_13((Control)(object)PictureBox_0, "PictureBox1");
					num = ((int)num2 * -1089122954) ^ -1980255755;
					continue;
				case 10u:
					GForm0.smethod_28((Control)(object)this, "Introduction");
					num = (int)((num2 * 826692239) ^ 0x64844F77);
					continue;
				case 9u:
					num = ((int)num2 * -1014431519) ^ -176588513;
					continue;
				case 8u:
					GForm0.smethod_8((Control)(object)this);
					num = (int)(num2 * 376271970) ^ -826246240;
					continue;
				case 7u:
					Timer_1 = GForm0.smethod_5(icontainer_0);
					GForm0.smethod_7((ISupportInitialize)PictureBox_0);
					num = ((int)num2 * -1575587604) ^ -1840706275;
					continue;
				case 5u:
					GForm0.smethod_15(PictureBox_0, 0);
					num = ((int)num2 * -1771251138) ^ -781431400;
					continue;
				case 4u:
					GForm0.smethod_26((Form)(object)this, new Padding(4));
					GForm0.smethod_27((Form)(object)this, bool_1: false);
					num = ((int)num2 * -584881310) ^ -418067800;
					continue;
				case 3u:
					GForm0.smethod_16(PictureBox_0, bool_1: false);
					GForm0.smethod_9(Timer_1, 500);
					GForm0.smethod_17((ContainerControl)(object)this, new SizeF(10f, 22f));
					num = ((int)num2 * -904403355) ^ -727904245;
					continue;
				case 2u:
					GForm0.smethod_19((Form)(object)this, Color.White);
					num = ((int)num2 * -1144154450) ^ 0x17E062D4;
					continue;
				case 1u:
					GForm0.smethod_30((Form)(object)this, "The Omegle Game");
					num = ((int)num2 * -31784924) ^ 0x6CFFA51A;
					continue;
				case 0u:
					GForm0.smethod_12((Control)(object)PictureBox_0, new Point(365, 415));
					num = ((int)num2 * -494083010) ^ 0x68E99C38;
					continue;
				default:
					return;
				case 27u:
					break;
				case 6u:
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
			int num = 750454709;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1027739Eu) % 7u)
				{
				case 6u:
					GClass1.smethod_0();
					GClass1.smethod_3().method_0();
					num = (int)((num2 * 1417939966) ^ 0x27C8AE28);
					continue;
				case 5u:
					GForm0.smethod_40((Control)(object)this, GForm0.smethod_39(GForm0.smethod_38(GForm0.smethod_37(), "\\data\\Images\\schermata_omegle.png")));
					GForm0.smethod_40((Control)(object)PictureBox_0, (Image)(object)smethod_0(GForm0.smethod_39(GForm0.smethod_38(GForm0.smethod_37(), "\\data\\Images\\marco_introduzione.png")), float_0));
					num = ((int)num2 * -1810898414) ^ -177049112;
					continue;
				case 4u:
					num = (int)((num2 * 1325072110) ^ 0xBDA7353);
					continue;
				case 1u:
					GForm0.smethod_41(Timer_1);
					num = (int)((num2 * 1072827955) ^ 0x6045920E);
					continue;
				case 0u:
					num = ((int)num2 * -52909127) ^ -742884159;
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

	public static Bitmap smethod_0(Image image_0, float float_1)
	{
		Graphics graphics_ = default(Graphics);
		Bitmap val = default(Bitmap);
		ColorMatrix colorMatrix_ = default(ColorMatrix);
		ImageAttributes imageAttributes_ = default(ImageAttributes);
		Bitmap result = default(Bitmap);
		while (true)
		{
			int num = 1425644346;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x126EF6A1u) % 10u)
				{
				case 9u:
					num = (int)((num2 * 1959243822) ^ 0x158EF5A5);
					continue;
				case 8u:
					num = (int)(num2 * 217543881) ^ -1345869733;
					continue;
				case 6u:
					GForm0.smethod_51(graphics_);
					num = (int)(num2 * 1176820804) ^ -944479251;
					continue;
				case 5u:
					val = GForm0.smethod_44(GForm0.smethod_42(image_0), GForm0.smethod_43(image_0));
					graphics_ = GForm0.smethod_45((Image)(object)val);
					colorMatrix_ = GForm0.smethod_46();
					GForm0.smethod_47(colorMatrix_, float_1);
					num = (int)(num2 * 655119318) ^ -1794403160;
					continue;
				case 3u:
					GForm0.smethod_49(imageAttributes_, colorMatrix_, (ColorMatrixFlag)0, (ColorAdjustType)1);
					num = (int)(num2 * 931832543) ^ -430837921;
					continue;
				case 2u:
					result = val;
					num = (int)(num2 * 1697232166) ^ -1456392837;
					continue;
				case 1u:
					GForm0.smethod_50(graphics_, image_0, new Rectangle(0, 0, GForm0.smethod_42((Image)(object)val), GForm0.smethod_43((Image)(object)val)), 0, 0, GForm0.smethod_42(image_0), GForm0.smethod_43(image_0), (GraphicsUnit)2, imageAttributes_);
					num = (int)(num2 * 1541405522) ^ -521831599;
					continue;
				case 0u:
					imageAttributes_ = GForm0.smethod_48();
					num = (int)(num2 * 1705466790) ^ -1308200610;
					continue;
				case 7u:
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
		bool flag = default(bool);
		while (true)
		{
			int num = -359437632;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xAF78C922u) % 5u)
				{
				case 3u:
					method_4();
					flag = !bool_0;
					num = ((int)num2 * -1801470894) ^ 0x792A196C;
					continue;
				case 2u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = 836591672;
						num4 = 836591672;
					}
					else
					{
						num3 = 1787471988;
						num4 = 1787471988;
					}
					num = num3 ^ ((int)num2 * -874811724);
					continue;
				}
				case 1u:
					GForm0.smethod_53((CancelEventArgs)(object)e, bool_1: true);
					num = ((int)num2 * -1121027463) ^ -270453410;
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

	public void method_4()
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Invalid comparison between Unknown and I4
		bool flag = !bool_0;
		bool flag2 = default(bool);
		while (true)
		{
			int num = -821982078;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA599534Du) % 17u)
				{
				case 16u:
					GForm0.smethod_52();
					num = (int)((num2 * 1392991747) ^ 0x6536D06A);
					continue;
				case 15u:
					flag2 = (int)GForm0.smethod_54("Sei sicuro di voler uscire dal gioco?", "The Omegle Game", (MessageBoxButtons)4, (MessageBoxIcon)32) == 6;
					num = ((int)num2 * -510669457) ^ 0x2D440B27;
					continue;
				case 14u:
					GForm0.smethod_57(GForm0.smethod_35());
					num = (int)(num2 * 1941240181) ^ -217490801;
					continue;
				case 12u:
					num = (int)(num2 * 1504166361) ^ -1569130932;
					continue;
				case 11u:
					GForm0.smethod_55(Timer_0);
					num = (int)(num2 * 188500295) ^ -1059438355;
					continue;
				case 10u:
					num = ((int)num2 * -1203259197) ^ -141569240;
					continue;
				case 9u:
					num = (int)(num2 * 1923368202) ^ -2092333050;
					continue;
				case 8u:
				{
					int num5;
					int num6;
					if (flag)
					{
						num5 = 181555806;
						num6 = 181555806;
					}
					else
					{
						num5 = 165785361;
						num6 = 165785361;
					}
					num = num5 ^ (int)(num2 * 1039394409);
					continue;
				}
				case 7u:
					GForm0.smethod_56((object)bool_0);
					GForm0.smethod_52();
					num = ((int)num2 * -1744782949) ^ -1212232431;
					continue;
				case 6u:
					GForm0.smethod_56((object)Timer_0);
					num = ((int)num2 * -1440139847) ^ 0xF64BCA9;
					continue;
				case 5u:
				{
					int num3;
					int num4;
					if (!flag2)
					{
						num3 = -565277277;
						num4 = -565277277;
					}
					else
					{
						num3 = -2008822128;
						num4 = -2008822128;
					}
					num = num3 ^ (int)(num2 * 1488536999);
					continue;
				}
				case 4u:
					num = -34507127;
					continue;
				case 3u:
					GForm0.smethod_56((object)Timer_0);
					GForm0.smethod_56((object)bool_0);
					num = (int)((num2 * 1763909406) ^ 0x829AD1);
					continue;
				case 1u:
					GForm0.smethod_55(Timer_0);
					num = -712504176;
					continue;
				case 0u:
					num = (int)((num2 * 1586379795) ^ 0x3F200F3D);
					continue;
				default:
					return;
				case 2u:
					break;
				case 13u:
					return;
				}
				break;
			}
		}
	}

	private void method_5(object sender, EventArgs e)
	{
		bool flag = int_0 <= 15;
		bool flag3 = default(bool);
		bool flag2 = default(bool);
		while (true)
		{
			int num = 196774029;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x282E1876u) % 43u)
				{
				case 42u:
					num = (int)(num2 * 126234529) ^ -1447404256;
					continue;
				case 41u:
					num = ((int)num2 * -540758733) ^ 0xA1F325D;
					continue;
				case 40u:
				{
					int num9;
					int num10;
					if (flag3)
					{
						num9 = -2007363029;
						num10 = -2007363029;
					}
					else
					{
						num9 = -1275037207;
						num10 = -1275037207;
					}
					num = num9 ^ ((int)num2 * -1876550616);
					continue;
				}
				case 39u:
					num = ((int)num2 * -900307585) ^ 0x6055751B;
					continue;
				case 38u:
					checked
					{
						int_0++;
					}
					num = ((int)num2 * -1929735137) ^ -1228429069;
					continue;
				case 37u:
					num = (int)((num2 * 1798236820) ^ 0x3FB05A86);
					continue;
				case 36u:
					checked
					{
						int_0++;
					}
					num = (int)((num2 * 1185829239) ^ 0x759C9416);
					continue;
				case 35u:
					GForm0.smethod_12((Control)(object)PictureBox_0, new Point(512, 0));
					num = (int)(num2 * 828541517) ^ -1689351424;
					continue;
				case 33u:
					num = (int)((num2 * 1031423845) ^ 0x4A20FB82);
					continue;
				case 32u:
					GForm0.smethod_55(Timer_1);
					num = ((int)num2 * -55472948) ^ -1720077599;
					continue;
				case 31u:
					GClass1.smethod_3().method_4();
					GForm0.smethod_52();
					num = ((int)num2 * -111732066) ^ 0x7A75A0B;
					continue;
				case 30u:
				{
					int num7;
					int num8;
					if (flag2)
					{
						num7 = -406442100;
						num8 = -406442100;
					}
					else
					{
						num7 = -1003178963;
						num8 = -1003178963;
					}
					num = num7 ^ (int)(num2 * 637579784);
					continue;
				}
				case 29u:
					GForm0.smethod_56((object)float_0);
					num = ((int)num2 * -2106503714) ^ -1272423028;
					continue;
				case 28u:
					GForm0.smethod_56((object)Timer_1);
					num = ((int)num2 * -951253552) ^ -313702818;
					continue;
				case 27u:
					checked
					{
						int_0++;
					}
					num = ((int)num2 * -1039179135) ^ -2019081538;
					continue;
				case 26u:
					num = ((int)num2 * -215503403) ^ -678895009;
					continue;
				case 25u:
					GForm0.smethod_40((Control)(object)PictureBox_0, GForm0.smethod_39(GForm0.smethod_38(GForm0.smethod_37(), "\\data\\Images\\marco_introduzione.png")));
					num = ((int)num2 * -652215581) ^ -676404230;
					continue;
				case 24u:
				{
					ref float reference = ref float_0;
					reference = (float)((double)reference + 0.3);
					num = (int)(num2 * 1113666046) ^ -451905478;
					continue;
				}
				case 23u:
					flag3 = (int_0 >= 16) & (int_0 <= 20);
					num = 1776116213;
					continue;
				case 22u:
					GForm0.smethod_40((Control)(object)PictureBox_0, (Image)(object)smethod_0(GForm0.smethod_58((Control)(object)PictureBox_0), float_0));
					num = (int)((num2 * 73459221) ^ 0x2F023232);
					continue;
				case 21u:
					GForm0.smethod_56((object)int_0);
					num = (int)(num2 * 311945114) ^ -1621791924;
					continue;
				case 20u:
					num = ((int)num2 * -1410637664) ^ -1283637572;
					continue;
				case 19u:
				{
					PictureBox control_;
					GForm0.smethod_63((Control)(object)(control_ = PictureBox_0), checked(GForm0.smethod_62((Control)(object)control_) + 30));
					num = (int)(num2 * 2083756687) ^ -2003646560;
					continue;
				}
				case 18u:
					num = (int)(num2 * 1622149718) ^ -1798961626;
					continue;
				case 17u:
				{
					int num5;
					int num6;
					if (flag)
					{
						num5 = -1305512476;
						num6 = -1305512476;
					}
					else
					{
						num5 = -1995585691;
						num6 = -1995585691;
					}
					num = num5 ^ (int)(num2 * 352428591);
					continue;
				}
				case 16u:
					checked
					{
						int_0++;
					}
					num = ((int)num2 * -972452475) ^ 0x38FBCDDB;
					continue;
				case 15u:
					num = (int)((num2 * 1201373804) ^ 0x65A65702);
					continue;
				case 14u:
					flag2 = (int_0 >= 57) & (int_0 <= 65);
					num = 1629919769;
					continue;
				case 13u:
				{
					PictureBox control_;
					GForm0.smethod_65((Control)(object)(control_ = PictureBox_0), checked(GForm0.smethod_64((Control)(object)control_) + 30));
					num = (int)((num2 * 860422625) ^ 0x3576063A);
					continue;
				}
				case 12u:
					num = ((int)num2 * -1989184358) ^ 0xCE4E57B;
					continue;
				case 11u:
					GForm0.smethod_40((Control)(object)PictureBox_0, GForm0.smethod_39(GForm0.smethod_38(GForm0.smethod_37(), "\\data\\Images\\marco_introduzione.png")));
					GForm0.smethod_12((Control)(object)PictureBox_0, checked(new Point((int)GForm0.smethod_61((double)((float)GForm0.smethod_59((Control)(object)PictureBox_0).X + GForm0.smethod_60() * 10f)), (int)GForm0.smethod_61((double)((float)GForm0.smethod_59((Control)(object)PictureBox_0).Y - GForm0.smethod_60() * 10f)))));
					num = ((int)num2 * -1146344881) ^ 0x7F5824E4;
					continue;
				case 10u:
					GClass1.smethod_3().method_3();
					num = (int)(num2 * 1337812644) ^ -1492046978;
					continue;
				case 9u:
					num = ((int)num2 * -697669847) ^ 0x51DDDCBC;
					continue;
				case 8u:
					checked
					{
						int_0++;
					}
					num = ((int)num2 * -1948815891) ^ 0x67ACA8B9;
					continue;
				case 7u:
					num = ((int)num2 * -1057966138) ^ -945067134;
					continue;
				case 6u:
					num = (int)(num2 * 1296647702) ^ -1610288164;
					continue;
				case 5u:
					num = 1698655892;
					continue;
				case 4u:
				{
					int num4;
					if (!((int_0 >= 21) & (int_0 <= 49)))
					{
						num = 1718539763;
						num4 = 1718539763;
					}
					else
					{
						num = 2076734228;
						num4 = 2076734228;
					}
					continue;
				}
				case 2u:
					num = ((int)num2 * -1354837027) ^ 0x4CAC30AC;
					continue;
				case 1u:
				{
					PictureBox control_;
					GForm0.smethod_65((Control)(object)(control_ = PictureBox_0), checked(GForm0.smethod_64((Control)(object)control_) + 22));
					num = (int)((num2 * 261974238) ^ 0x7A7F2C5A);
					continue;
				}
				case 0u:
				{
					int num3;
					if (!((int_0 >= 50) & (int_0 <= 57)))
					{
						num = 1591687003;
						num3 = 1591687003;
					}
					else
					{
						num = 418850975;
						num3 = 418850975;
					}
					continue;
				}
				default:
					return;
				case 3u:
					break;
				case 34u:
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
