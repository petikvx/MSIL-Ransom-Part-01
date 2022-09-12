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
				int num = -748647760;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x83474881u) % 7u)
					{
					case 6u:
						GForm0.smethod_33(val, eventHandler_);
						num = ((int)num2 * -762440401) ^ -348409532;
						continue;
					case 4u:
					{
						val = timer_0;
						int num5;
						int num6;
						if (val == null)
						{
							num5 = 2005892518;
							num6 = 2005892518;
						}
						else
						{
							num5 = 1621640854;
							num6 = 1621640854;
						}
						num = num5 ^ (int)(num2 * 4878319);
						continue;
					}
					case 3u:
					{
						val = timer_0;
						int num3;
						int num4;
						if (val == null)
						{
							num3 = -1489534435;
							num4 = -1489534435;
						}
						else
						{
							num3 = -902841066;
							num4 = -902841066;
						}
						num = num3 ^ (int)(num2 * 2112515580);
						continue;
					}
					case 1u:
						timer_0 = value;
						num = -200352785;
						continue;
					case 0u:
						GForm0.smethod_34(val, eventHandler_);
						num = ((int)num2 * -91505310) ^ 0x3E48CE3E;
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
				int num = 325610313;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x980D4F5u) % 9u)
					{
					case 8u:
						timer_1 = value;
						num = 1078555282;
						continue;
					case 7u:
					{
						int num5;
						int num6;
						if (val != null)
						{
							num5 = -1834647668;
							num6 = -1834647668;
						}
						else
						{
							num5 = -295032443;
							num6 = -295032443;
						}
						num = num5 ^ (int)(num2 * 658289261);
						continue;
					}
					case 6u:
						val = timer_1;
						num = (int)((num2 * 15924770) ^ 0x7A35D247);
						continue;
					case 5u:
						GForm0.smethod_33(val, eventHandler_);
						num = (int)((num2 * 301760730) ^ 0x9767FC5);
						continue;
					case 4u:
						GForm0.smethod_34(val, eventHandler_);
						num = (int)((num2 * 1575319978) ^ 0x26D8FF6A);
						continue;
					case 3u:
					{
						int num3;
						int num4;
						if (val != null)
						{
							num3 = -1384916928;
							num4 = -1384916928;
						}
						else
						{
							num3 = -1756386080;
							num4 = -1756386080;
						}
						num = num3 ^ ((int)num2 * -70484946);
						continue;
					}
					case 1u:
						val = timer_1;
						num = (int)((num2 * 550907351) ^ 0x11C0846F);
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
	}

	public GForm0()
	{
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected O, but got Unknown
		while (true)
		{
			int num = 588472221;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7F9C4244u) % 7u)
				{
				case 6u:
					bool_0 = false;
					float_0 = 0.1f;
					num = ((int)num2 * -1381280492) ^ -1441212092;
					continue;
				case 5u:
					int_0 = 0;
					num = (int)((num2 * 650311500) ^ 0x41784A23);
					continue;
				case 4u:
					GForm0.smethod_1((Form)(object)this, (EventHandler)method_1);
					num = (int)((num2 * 1902317242) ^ 0x72D6D9D6);
					continue;
				case 2u:
					method_0();
					num = (int)((num2 * 379983982) ^ 0x7D607818);
					continue;
				case 1u:
					GForm0.smethod_2((Form)(object)this, new FormClosingEventHandler(method_3));
					num = ((int)num2 * -1294164625) ^ 0x30C48E8B;
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

	[DebuggerNonUserCode]
	void Form.Dispose(bool disposing)
	{
		try
		{
			bool flag = default(bool);
			while (true)
			{
				int num = -1297645448;
				while (true)
				{
					uint num2;
					int num3;
					switch ((num2 = (uint)num ^ 0xB3DEF608u) % 9u)
					{
					case 6u:
						num = ((int)num2 * -22262364) ^ 0xFB3F86D;
						continue;
					case 5u:
					{
						int num4;
						int num5;
						if (!flag)
						{
							num4 = 576326504;
							num5 = 576326504;
						}
						else
						{
							num4 = 302428696;
							num5 = 302428696;
						}
						num = num4 ^ ((int)num2 * -349374844);
						continue;
					}
					case 4u:
						num = -284347675;
						continue;
					case 3u:
						num = (int)((num2 * 1314493421) ^ 0x9908CC9);
						continue;
					case 2u:
						GForm0.smethod_3((IDisposable)icontainer_0);
						num = ((int)num2 * -588067695) ^ 0x154E3515;
						continue;
					case 1u:
						if (disposing)
						{
							num = ((int)num2 * -299912897) ^ 0x76047399;
							continue;
						}
						num3 = 0;
						goto IL_007d;
					case 0u:
						num3 = ((icontainer_0 != null) ? 1 : 0);
						goto IL_007d;
					default:
						return;
					case 8u:
						break;
					case 7u:
						return;
						IL_007d:
						flag = (byte)num3 != 0;
						num = -1819553237;
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
		//IL_0229: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			int num = -1305719844;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC9784F0Eu) % 39u)
				{
				case 37u:
					GForm0.smethod_24((Control)(object)this, GForm0.smethod_23("Consolas", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 782460834) ^ 0x7A974741);
					continue;
				case 36u:
					GForm0.smethod_13((Control)(object)PictureBox_0, "PictureBox1");
					GForm0.smethod_14((Control)(object)PictureBox_0, new Size(302, 211));
					GForm0.smethod_15(PictureBox_0, 0);
					num = ((int)num2 * -920765543) ^ 0x5A890030;
					continue;
				case 35u:
					((Control)this).set_DoubleBuffered(true);
					num = (int)(num2 * 2110594429) ^ -873913406;
					continue;
				case 34u:
					num = (int)(num2 * 789669248) ^ -975777701;
					continue;
				case 33u:
					GForm0.smethod_29((Form)(object)this, (FormStartPosition)1);
					num = (int)((num2 * 1578180957) ^ 0x2B964B70);
					continue;
				case 32u:
					GForm0.smethod_11((Control)(object)PictureBox_0, (ImageLayout)3);
					num = (int)((num2 * 407865648) ^ 0x4DE04851);
					continue;
				case 31u:
					Timer_0 = GForm0.smethod_5(icontainer_0);
					num = (int)(num2 * 2109715973) ^ -409222099;
					continue;
				case 30u:
					GForm0.smethod_12((Control)(object)PictureBox_0, new Point(365, 415));
					num = (int)(num2 * 64527518) ^ -680209142;
					continue;
				case 29u:
					GForm0.smethod_28((Control)(object)this, "Introduction");
					num = (int)(num2 * 1107438675) ^ -2134991920;
					continue;
				case 28u:
					GForm0.smethod_25((Form)(object)this, (FormBorderStyle)1);
					num = (int)((num2 * 1512577613) ^ 0x512EE07C);
					continue;
				case 27u:
					GForm0.smethod_31((ISupportInitialize)PictureBox_0);
					num = (int)(num2 * 2120347203) ^ -1577644811;
					continue;
				case 26u:
					num = ((int)num2 * -1472445131) ^ -202529833;
					continue;
				case 25u:
					num = ((int)num2 * -552360921) ^ 0x40036945;
					continue;
				case 24u:
					Timer_1 = GForm0.smethod_5(icontainer_0);
					num = (int)((num2 * 628981343) ^ 0x351498B5);
					continue;
				case 23u:
					num = ((int)num2 * -355661308) ^ -864424198;
					continue;
				case 22u:
					GForm0.smethod_10((Control)(object)PictureBox_0, Color.Transparent);
					num = (int)(num2 * 164344564) ^ -10262895;
					continue;
				case 21u:
					num = ((int)num2 * -1081457750) ^ -1291522148;
					continue;
				case 20u:
					GForm0.smethod_16(PictureBox_0, bool_1: false);
					num = ((int)num2 * -695201804) ^ 0x4E5776F4;
					continue;
				case 19u:
					GForm0.smethod_26((Form)(object)this, new Padding(4));
					num = (int)((num2 * 379639021) ^ 0x125E621D);
					continue;
				case 18u:
					PictureBox_0 = GForm0.smethod_6();
					num = (int)(num2 * 1493648171) ^ -576745144;
					continue;
				case 17u:
					GForm0.smethod_7((ISupportInitialize)PictureBox_0);
					num = (int)((num2 * 223716778) ^ 0x483E605E);
					continue;
				case 16u:
					GForm0.smethod_27((Form)(object)this, bool_1: false);
					num = ((int)num2 * -424612675) ^ 0x201EB6BF;
					continue;
				case 15u:
					GForm0.smethod_11((Control)(object)this, (ImageLayout)3);
					num = ((int)num2 * -1069832889) ^ 0x5F52C938;
					continue;
				case 13u:
					GForm0.smethod_18((ContainerControl)(object)this, (AutoScaleMode)1);
					num = ((int)num2 * -612017428) ^ 0x10288E28;
					continue;
				case 12u:
					GForm0.smethod_22(GForm0.smethod_21((Control)(object)this), (Control)(object)PictureBox_0);
					num = (int)((num2 * 254991899) ^ 0x59DB4C49);
					continue;
				case 11u:
					GForm0.smethod_30((Form)(object)this, "The Omegle Game");
					num = (int)((num2 * 654309321) ^ 0x27FA769B);
					continue;
				case 10u:
					icontainer_0 = GForm0.smethod_4();
					num = (int)(num2 * 822234012) ^ -171667873;
					continue;
				case 9u:
					GForm0.smethod_32((Control)(object)this, bool_1: false);
					num = (int)((num2 * 1223448244) ^ 0x577CDAB4);
					continue;
				case 8u:
					GForm0.smethod_9(Timer_0, 1000);
					num = ((int)num2 * -527412785) ^ 0x156BC973;
					continue;
				case 7u:
					GForm0.smethod_8((Control)(object)this);
					num = (int)(num2 * 1212733192) ^ -2105574241;
					continue;
				case 6u:
					num = (int)(num2 * 188619244) ^ -89010933;
					continue;
				case 5u:
					GForm0.smethod_17((ContainerControl)(object)this, new SizeF(10f, 22f));
					num = ((int)num2 * -512610036) ^ 0xF1AB7CB;
					continue;
				case 4u:
					num = (int)(num2 * 1484945009) ^ -1918807481;
					continue;
				case 3u:
					GForm0.smethod_19((Form)(object)this, Color.White);
					num = (int)(num2 * 1176660949) ^ -370616710;
					continue;
				case 2u:
					GForm0.smethod_9(Timer_1, 500);
					num = ((int)num2 * -1709436107) ^ -1929880620;
					continue;
				case 1u:
					num = ((int)num2 * -777525995) ^ 0x708FC02E;
					continue;
				case 0u:
					GForm0.smethod_20((Form)(object)this, new Size(1025, 638));
					num = ((int)num2 * -1735600944) ^ 0x3FDF9024;
					continue;
				default:
					return;
				case 38u:
					break;
				case 14u:
					return;
				}
				break;
			}
		}
	}

	private void method_1(object sender, EventArgs e)
	{
		while (true)
		{
			int num = 1954178423;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1962554u) % 11u)
				{
				case 10u:
					GForm0.smethod_36(GForm0.smethod_35(), ProcessPriorityClass.RealTime);
					num = ((int)num2 * -937446799) ^ 0x34CC6B0F;
					continue;
				case 8u:
					GForm0.smethod_40((Control)(object)PictureBox_0, (Image)(object)smethod_0(GForm0.smethod_39(GForm0.smethod_38(GForm0.smethod_37(), "\\data\\Images\\marco_introduzione.png")), float_0));
					num = (int)((num2 * 1045658412) ^ 0x134760C7);
					continue;
				case 7u:
					GClass1.smethod_3().method_0();
					num = (int)(num2 * 1047291850) ^ -602864856;
					continue;
				case 5u:
					num = (int)((num2 * 1841186566) ^ 0x20405478);
					continue;
				case 4u:
					GClass1.smethod_0();
					num = ((int)num2 * -1681441450) ^ 0x2F8B24B0;
					continue;
				case 3u:
					num = ((int)num2 * -1966371553) ^ 0x617EA701;
					continue;
				case 2u:
					GForm0.smethod_40((Control)(object)this, GForm0.smethod_39(GForm0.smethod_38(GForm0.smethod_37(), "\\data\\Images\\schermata_omegle.png")));
					num = (int)(num2 * 1393831658) ^ -488858655;
					continue;
				case 1u:
					GForm0.smethod_41(Timer_1);
					num = (int)((num2 * 1334229231) ^ 0x14F6FB58);
					continue;
				case 0u:
					num = ((int)num2 * -1219440233) ^ -1453744603;
					continue;
				default:
					return;
				case 6u:
					break;
				case 9u:
					return;
				}
				break;
			}
		}
	}

	public static Bitmap smethod_0(Image image_0, float float_1)
	{
		Bitmap val = GForm0.smethod_44(GForm0.smethod_42(image_0), GForm0.smethod_43(image_0));
		ColorMatrix colorMatrix_ = default(ColorMatrix);
		Graphics graphics_ = default(Graphics);
		Bitmap result = default(Bitmap);
		while (true)
		{
			int num = -1396902230;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x95A28214u) % 7u)
				{
				case 4u:
				{
					ImageAttributes imageAttributes_ = GForm0.smethod_48();
					GForm0.smethod_49(imageAttributes_, colorMatrix_, (ColorMatrixFlag)0, (ColorAdjustType)1);
					GForm0.smethod_50(graphics_, image_0, new Rectangle(0, 0, GForm0.smethod_42((Image)(object)val), GForm0.smethod_43((Image)(object)val)), 0, 0, GForm0.smethod_42(image_0), GForm0.smethod_43(image_0), (GraphicsUnit)2, imageAttributes_);
					GForm0.smethod_51(graphics_);
					num = (int)(num2 * 294160127) ^ -289066295;
					continue;
				}
				case 3u:
					GForm0.smethod_47(colorMatrix_, float_1);
					num = ((int)num2 * -1372928046) ^ 0x44770E78;
					continue;
				case 2u:
					result = val;
					num = ((int)num2 * -1107077394) ^ 0x57DD7225;
					continue;
				case 1u:
					graphics_ = GForm0.smethod_45((Image)(object)val);
					colorMatrix_ = GForm0.smethod_46();
					num = (int)(num2 * 1859746027) ^ -809992163;
					continue;
				case 0u:
					num = (int)(num2 * 2128148448) ^ -1217483596;
					continue;
				case 6u:
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
			int num = -1034036952;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8BB9E5CFu) % 3u)
				{
				case 1u:
					goto IL_0003;
				default:
					return;
				case 0u:
					break;
				case 2u:
					return;
				}
				break;
				IL_0003:
				GForm0.smethod_52();
				num = ((int)num2 * -506814705) ^ -1617019891;
			}
		}
	}

	private void method_3(object sender, FormClosingEventArgs e)
	{
		bool flag = default(bool);
		while (true)
		{
			int num = 1213546685;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3485DE42u) % 9u)
				{
				case 8u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = -1330306326;
						num4 = -1330306326;
					}
					else
					{
						num3 = -170569378;
						num4 = -170569378;
					}
					num = num3 ^ ((int)num2 * -1147808511);
					continue;
				}
				case 7u:
					GForm0.smethod_53((CancelEventArgs)(object)e, bool_1: true);
					num = (int)((num2 * 718488023) ^ 0x4E90CFFB);
					continue;
				case 6u:
					num = 386691795;
					continue;
				case 5u:
					flag = !bool_0;
					num = ((int)num2 * -934975572) ^ -1202298055;
					continue;
				case 3u:
					num = (int)((num2 * 622482799) ^ 0x70AB5979);
					continue;
				case 2u:
					num = (int)((num2 * 886506218) ^ 0x42AB8CD9);
					continue;
				case 1u:
					method_4();
					num = ((int)num2 * -1792496108) ^ -1862490305;
					continue;
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

	public void method_4()
	{
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Invalid comparison between Unknown and I4
		bool flag2 = default(bool);
		bool flag = default(bool);
		while (true)
		{
			int num = -2082085987;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA5B5796Cu) % 26u)
				{
				case 25u:
					num = (int)(num2 * 1129116756) ^ -1532345146;
					continue;
				case 24u:
					GForm0.smethod_57(GForm0.smethod_35());
					num = ((int)num2 * -133129033) ^ -97633154;
					continue;
				case 23u:
					num = ((int)num2 * -1382623568) ^ -1141389179;
					continue;
				case 22u:
					flag2 = (int)GForm0.smethod_54("Sei sicuro di voler uscire dal gioco?", "The Omegle Game", (MessageBoxButtons)4, (MessageBoxIcon)32) == 6;
					num = (int)(num2 * 1439370907) ^ -1143503335;
					continue;
				case 21u:
					num = -1260070383;
					continue;
				case 20u:
					num = ((int)num2 * -1366378156) ^ -1532877004;
					continue;
				case 18u:
					num = ((int)num2 * -572800999) ^ -1892307534;
					continue;
				case 17u:
				{
					int num5;
					int num6;
					if (!flag2)
					{
						num5 = 233124269;
						num6 = 233124269;
					}
					else
					{
						num5 = 1157262516;
						num6 = 1157262516;
					}
					num = num5 ^ (int)(num2 * 568615312);
					continue;
				}
				case 16u:
					num = (int)((num2 * 1389935481) ^ 0x4B004C4E);
					continue;
				case 15u:
					num = ((int)num2 * -96061227) ^ -1839303395;
					continue;
				case 14u:
					GForm0.smethod_56((object)Timer_0);
					num = (int)((num2 * 1359961023) ^ 0x3ED579CA);
					continue;
				case 13u:
					GForm0.smethod_56((object)Timer_0);
					num = (int)(num2 * 340599439) ^ -39855658;
					continue;
				case 12u:
					GForm0.smethod_56((object)bool_0);
					num = (int)((num2 * 727217779) ^ 0x6C666E20);
					continue;
				case 10u:
					num = (int)((num2 * 1313385419) ^ 0x432546D3);
					continue;
				case 9u:
					num = ((int)num2 * -878006827) ^ 0x3BE5EA3C;
					continue;
				case 8u:
					GForm0.smethod_56((object)bool_0);
					num = (int)((num2 * 713144482) ^ 0x11240B0A);
					continue;
				case 7u:
					flag = !bool_0;
					num = ((int)num2 * -318626598) ^ -1226609980;
					continue;
				case 6u:
					GForm0.smethod_55(Timer_0);
					num = (int)(num2 * 412739657) ^ -1404356767;
					continue;
				case 5u:
					num = (int)((num2 * 1141427819) ^ 0x4C6BE5C6);
					continue;
				case 4u:
					GForm0.smethod_52();
					num = (int)((num2 * 1398354968) ^ 0x29CF5E0F);
					continue;
				case 3u:
					GForm0.smethod_55(Timer_0);
					num = ((int)num2 * -602541860) ^ -1188081939;
					continue;
				case 2u:
					GForm0.smethod_52();
					num = ((int)num2 * -948462673) ^ -1656831568;
					continue;
				case 1u:
					num = -2131704129;
					continue;
				case 0u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = 1059069696;
						num4 = 1059069696;
					}
					else
					{
						num3 = 100612543;
						num4 = 100612543;
					}
					num = num3 ^ (int)(num2 * 117736313);
					continue;
				}
				default:
					return;
				case 11u:
					break;
				case 19u:
					return;
				}
				break;
			}
		}
	}

	private void method_5(object sender, EventArgs e)
	{
		bool flag = int_0 <= 15;
		bool flag4 = default(bool);
		bool flag5 = default(bool);
		bool flag3 = default(bool);
		bool flag2 = default(bool);
		while (true)
		{
			int num = 1237035411;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1EA78D1Au) % 42u)
				{
				case 41u:
				{
					int num9;
					int num10;
					if (!flag4)
					{
						num9 = -1152154858;
						num10 = -1152154858;
					}
					else
					{
						num9 = -1425754175;
						num10 = -1425754175;
					}
					num = num9 ^ (int)(num2 * 911726792);
					continue;
				}
				case 40u:
					num = ((int)num2 * -6897199) ^ 0x4F2D0CEC;
					continue;
				case 39u:
				{
					int num11;
					int num12;
					if (!flag)
					{
						num11 = 1430788413;
						num12 = 1430788413;
					}
					else
					{
						num11 = 1706108278;
						num12 = 1706108278;
					}
					num = num11 ^ ((int)num2 * -2005911580);
					continue;
				}
				case 38u:
					flag4 = (int_0 >= 21) & (int_0 <= 49);
					num = 1155502751;
					continue;
				case 37u:
					num = ((int)num2 * -793949157) ^ -162564452;
					continue;
				case 36u:
					num = 82518855;
					continue;
				case 35u:
					GForm0.smethod_12((Control)(object)PictureBox_0, new Point(512, 0));
					num = ((int)num2 * -223995197) ^ -1478721352;
					continue;
				case 34u:
					num = (int)(num2 * 583730844) ^ -307273204;
					continue;
				case 33u:
					num = ((int)num2 * -905587304) ^ -1101501671;
					continue;
				case 32u:
				{
					PictureBox control_;
					GForm0.smethod_63((Control)(object)(control_ = PictureBox_0), checked(GForm0.smethod_62((Control)(object)control_) + 30));
					num = ((int)num2 * -1882722468) ^ 0x1682FE6D;
					continue;
				}
				case 31u:
					GForm0.smethod_12((Control)(object)PictureBox_0, checked(new Point((int)GForm0.smethod_61((double)((float)GForm0.smethod_59((Control)(object)PictureBox_0).X + GForm0.smethod_60() * 10f)), (int)GForm0.smethod_61((double)((float)GForm0.smethod_59((Control)(object)PictureBox_0).Y - GForm0.smethod_60() * 10f)))));
					num = (int)((num2 * 588784108) ^ 0x15ECE443);
					continue;
				case 30u:
					GClass1.smethod_3().method_4();
					num = (int)((num2 * 1112108182) ^ 0x1C84E238);
					continue;
				case 29u:
					num = ((int)num2 * -1461620607) ^ 0x5B02B4B7;
					continue;
				case 28u:
					num = ((int)num2 * -1951137133) ^ 0x7AC73682;
					continue;
				case 27u:
					checked
					{
						int_0++;
					}
					num = ((int)num2 * -569785847) ^ -725503119;
					continue;
				case 26u:
					GForm0.smethod_40((Control)(object)PictureBox_0, GForm0.smethod_39(GForm0.smethod_38(GForm0.smethod_37(), "\\data\\Images\\marco_introduzione.png")));
					GForm0.smethod_55(Timer_1);
					num = (int)(num2 * 1394480283) ^ -344859975;
					continue;
				case 24u:
					flag5 = (int_0 >= 57) & (int_0 <= 65);
					num = 511762479;
					continue;
				case 23u:
					GForm0.smethod_56((object)float_0);
					num = (int)(num2 * 1680793626) ^ -374563576;
					continue;
				case 22u:
				{
					ref float reference = ref float_0;
					reference = (float)((double)reference + 0.3);
					checked
					{
						int_0++;
					}
					num = ((int)num2 * -753699883) ^ 0x5B034CE1;
					continue;
				}
				case 21u:
				{
					int num7;
					int num8;
					if (!flag5)
					{
						num7 = 898496560;
						num8 = 898496560;
					}
					else
					{
						num7 = 669646687;
						num8 = 669646687;
					}
					num = num7 ^ (int)(num2 * 958657722);
					continue;
				}
				case 20u:
					num = ((int)num2 * -1696185777) ^ -930200443;
					continue;
				case 19u:
				{
					int num5;
					int num6;
					if (flag3)
					{
						num5 = 1151665002;
						num6 = 1151665002;
					}
					else
					{
						num5 = 1656637144;
						num6 = 1656637144;
					}
					num = num5 ^ (int)(num2 * 83996734);
					continue;
				}
				case 18u:
					GForm0.smethod_56((object)int_0);
					GClass1.smethod_3().method_3();
					num = (int)(num2 * 879927898) ^ -279368302;
					continue;
				case 17u:
					flag2 = (int_0 >= 16) & (int_0 <= 20);
					num = 832511357;
					continue;
				case 16u:
					checked
					{
						int_0++;
					}
					num = ((int)num2 * -744954162) ^ -664746015;
					continue;
				case 15u:
				{
					PictureBox control_;
					GForm0.smethod_65((Control)(object)(control_ = PictureBox_0), checked(GForm0.smethod_64((Control)(object)control_) + 22));
					num = (int)(num2 * 238310439) ^ -1360896270;
					continue;
				}
				case 14u:
					num = ((int)num2 * -346639468) ^ 0x5383E549;
					continue;
				case 12u:
					GForm0.smethod_40((Control)(object)PictureBox_0, (Image)(object)smethod_0(GForm0.smethod_58((Control)(object)PictureBox_0), float_0));
					num = (int)((num2 * 773296503) ^ 0x4DB21214);
					continue;
				case 11u:
					num = (int)((num2 * 1026485652) ^ 0x2F9E7452);
					continue;
				case 10u:
					flag3 = (int_0 >= 50) & (int_0 <= 57);
					num = 1956457731;
					continue;
				case 9u:
					num = ((int)num2 * -2119005376) ^ 0x71A5D79B;
					continue;
				case 8u:
					GForm0.smethod_52();
					num = ((int)num2 * -1752428747) ^ -1823382969;
					continue;
				case 7u:
					GForm0.smethod_40((Control)(object)PictureBox_0, GForm0.smethod_39(GForm0.smethod_38(GForm0.smethod_37(), "\\data\\Images\\marco_introduzione.png")));
					num = ((int)num2 * -1063275904) ^ -1661494811;
					continue;
				case 6u:
					num = (int)((num2 * 35454434) ^ 0x6079E5A5);
					continue;
				case 5u:
				{
					int num3;
					int num4;
					if (!flag2)
					{
						num3 = 156463088;
						num4 = 156463088;
					}
					else
					{
						num3 = 2059004990;
						num4 = 2059004990;
					}
					num = num3 ^ (int)(num2 * 674289162);
					continue;
				}
				case 4u:
					checked
					{
						int_0++;
					}
					num = ((int)num2 * -953843796) ^ 0x19163030;
					continue;
				case 3u:
					num = ((int)num2 * -228106721) ^ -1573985779;
					continue;
				case 2u:
					GForm0.smethod_56((object)Timer_1);
					num = (int)((num2 * 347490053) ^ 0x6CDD2B7C);
					continue;
				case 1u:
					checked
					{
						int_0++;
					}
					num = ((int)num2 * -367912036) ^ 0x3E53FD02;
					continue;
				case 0u:
				{
					PictureBox control_;
					GForm0.smethod_65((Control)(object)(control_ = PictureBox_0), checked(GForm0.smethod_64((Control)(object)control_) + 30));
					num = ((int)num2 * -267729535) ^ 0x631A5629;
					continue;
				}
				default:
					return;
				case 13u:
					break;
				case 25u:
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
