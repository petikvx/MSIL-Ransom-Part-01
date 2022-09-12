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
				int num = -1167829508;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xC2EF2B3Au) % 7u)
					{
					case 6u:
						GForm0.smethod_34(val, eventHandler_);
						num = (int)(num2 * 1387527716) ^ -702123455;
						continue;
					case 5u:
					{
						val = timer_0;
						int num5;
						int num6;
						if (val == null)
						{
							num5 = 1857341679;
							num6 = 1857341679;
						}
						else
						{
							num5 = 38569024;
							num6 = 38569024;
						}
						num = num5 ^ (int)(num2 * 1842963450);
						continue;
					}
					case 3u:
						GForm0.smethod_33(val, eventHandler_);
						num = ((int)num2 * -607362188) ^ 0x5ACDBE63;
						continue;
					case 1u:
					{
						val = timer_0;
						int num3;
						int num4;
						if (val != null)
						{
							num3 = -1392575386;
							num4 = -1392575386;
						}
						else
						{
							num3 = -671024203;
							num4 = -671024203;
						}
						num = num3 ^ ((int)num2 * -648050859);
						continue;
					}
					case 0u:
						timer_0 = value;
						num = -1170492943;
						continue;
					default:
						return;
					case 2u:
						break;
					case 4u:
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
			Timer val = timer_1;
			while (true)
			{
				int num = 1570014975;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x753F6B71u) % 7u)
					{
					case 6u:
					{
						int num5;
						int num6;
						if (val == null)
						{
							num5 = -1304158038;
							num6 = -1304158038;
						}
						else
						{
							num5 = -1967945301;
							num6 = -1967945301;
						}
						num = num5 ^ ((int)num2 * -189347202);
						continue;
					}
					case 3u:
						timer_1 = value;
						val = timer_1;
						num = 522879431;
						continue;
					case 2u:
					{
						int num3;
						int num4;
						if (val != null)
						{
							num3 = 562639099;
							num4 = 562639099;
						}
						else
						{
							num3 = 116519632;
							num4 = 116519632;
						}
						num = num3 ^ (int)(num2 * 1102304614);
						continue;
					}
					case 1u:
						GForm0.smethod_33(val, eventHandler_);
						num = (int)((num2 * 869649890) ^ 0x7BAC5038);
						continue;
					case 0u:
						GForm0.smethod_34(val, eventHandler_);
						num = ((int)num2 * -1462993220) ^ -2084122506;
						continue;
					default:
						return;
					case 5u:
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
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Expected O, but got Unknown
		while (true)
		{
			int num = -442400960;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB389B45Cu) % 8u)
				{
				case 7u:
					method_0();
					num = ((int)num2 * -1585278719) ^ 0x7AFF7E99;
					continue;
				case 6u:
					float_0 = 0.1f;
					num = ((int)num2 * -1128038759) ^ -1453518713;
					continue;
				case 5u:
					int_0 = 0;
					num = ((int)num2 * -2069891523) ^ 0x697A8C2;
					continue;
				case 4u:
					GForm0.smethod_1((Form)(object)this, (EventHandler)method_1);
					num = ((int)num2 * -519711946) ^ -863841995;
					continue;
				case 1u:
					GForm0.smethod_2((Form)(object)this, new FormClosingEventHandler(method_3));
					num = (int)(num2 * 612348033) ^ -598823235;
					continue;
				case 0u:
					bool_0 = false;
					num = ((int)num2 * -2074564113) ^ -1855993358;
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

	[DebuggerNonUserCode]
	void Form.Dispose(bool disposing)
	{
		try
		{
			while (true)
			{
				int num = 523836482;
				while (true)
				{
					uint num2;
					int num3;
					switch ((num2 = (uint)num ^ 0x2136F71Cu) % 7u)
					{
					case 6u:
						if (disposing)
						{
							num = (int)((num2 * 2005157470) ^ 0x2EF1865);
							continue;
						}
						goto IL_001c;
					case 4u:
						GForm0.smethod_3((IDisposable)icontainer_0);
						num = ((int)num2 * -371957627) ^ 0x740672A1;
						continue;
					case 3u:
						num = (int)(num2 * 1929145865) ^ -1594572481;
						continue;
					case 2u:
						if (icontainer_0 != null)
						{
							num = 864418532;
							num3 = 864418532;
							continue;
						}
						goto IL_001c;
					case 0u:
						num = 1636126362;
						continue;
					default:
						return;
					case 5u:
						break;
					case 1u:
						return;
						IL_001c:
						num = 1643482290;
						num3 = 1643482290;
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
				IL_00eb:
				int num4 = 101492867;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num4 ^ 0x2136F71Cu) % 4u)
					{
					case 3u:
						((Form)this).Dispose(disposing);
						num4 = (int)(num2 * 1766060525) ^ -686167989;
						continue;
					case 0u:
						num4 = ((int)num2 * -1056876979) ^ -1138106323;
						continue;
					default:
						goto end_IL_00ca;
					case 2u:
						break;
					case 1u:
						goto end_IL_00ca;
					}
					goto IL_00eb;
					continue;
					end_IL_00ca:
					break;
				}
				break;
			}
		}
	}

	[DebuggerStepThrough]
	private void method_0()
	{
		//IL_03f7: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			int num = -88053329;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9140F0C9u) % 41u)
				{
				case 40u:
					GForm0.smethod_16(PictureBox_0, bool_1: false);
					num = (int)(num2 * 62875547) ^ -1868832314;
					continue;
				case 39u:
					GForm0.smethod_31((ISupportInitialize)PictureBox_0);
					num = ((int)num2 * -1158732010) ^ -87123006;
					continue;
				case 38u:
					GForm0.smethod_30((Form)(object)this, "The Omegle Game");
					num = ((int)num2 * -56552646) ^ 0x9DC9EC9;
					continue;
				case 37u:
					GForm0.smethod_9(Timer_1, 500);
					num = (int)(num2 * 179887794) ^ -388883403;
					continue;
				case 36u:
					GForm0.smethod_15(PictureBox_0, 0);
					num = ((int)num2 * -2110138598) ^ 0x1583E10F;
					continue;
				case 35u:
					num = ((int)num2 * -77900480) ^ 0x483A919A;
					continue;
				case 34u:
					GForm0.smethod_28((Control)(object)this, "Introduction");
					num = (int)(num2 * 1383954166) ^ -1096130877;
					continue;
				case 33u:
					num = (int)((num2 * 667001247) ^ 0x1D7FCDBE);
					continue;
				case 32u:
					GForm0.smethod_20((Form)(object)this, new Size(1025, 638));
					num = ((int)num2 * -1639421756) ^ -1453622556;
					continue;
				case 31u:
					icontainer_0 = GForm0.smethod_4();
					num = (int)((num2 * 51485184) ^ 0x4EE29D8C);
					continue;
				case 30u:
					Timer_1 = GForm0.smethod_5(icontainer_0);
					num = ((int)num2 * -873476817) ^ 0x4B8E748B;
					continue;
				case 29u:
					PictureBox_0 = GForm0.smethod_6();
					num = ((int)num2 * -148550843) ^ -1601077043;
					continue;
				case 28u:
					GForm0.smethod_12((Control)(object)PictureBox_0, new Point(365, 415));
					num = ((int)num2 * -1838996808) ^ 0x2F817B2A;
					continue;
				case 27u:
					GForm0.smethod_11((Control)(object)PictureBox_0, (ImageLayout)3);
					num = (int)((num2 * 467118191) ^ 0x46F92546);
					continue;
				case 26u:
					GForm0.smethod_29((Form)(object)this, (FormStartPosition)1);
					num = ((int)num2 * -2143258210) ^ 0x753DBEB3;
					continue;
				case 25u:
					num = (int)((num2 * 571823155) ^ 0x1FA41231);
					continue;
				case 24u:
					GForm0.smethod_18((ContainerControl)(object)this, (AutoScaleMode)1);
					num = ((int)num2 * -24742923) ^ 0x46C2535D;
					continue;
				case 22u:
					num = (int)(num2 * 527302428) ^ -1957260136;
					continue;
				case 21u:
					GForm0.smethod_22(GForm0.smethod_21((Control)(object)this), (Control)(object)PictureBox_0);
					num = ((int)num2 * -672708597) ^ -755204485;
					continue;
				case 20u:
					GForm0.smethod_17((ContainerControl)(object)this, new SizeF(10f, 22f));
					num = (int)(num2 * 1783560100) ^ -251216969;
					continue;
				case 19u:
					GForm0.smethod_27((Form)(object)this, bool_1: false);
					num = ((int)num2 * -1364673872) ^ -1034441116;
					continue;
				case 18u:
					GForm0.smethod_25((Form)(object)this, (FormBorderStyle)1);
					num = ((int)num2 * -125042259) ^ -694768221;
					continue;
				case 17u:
					GForm0.smethod_24((Control)(object)this, GForm0.smethod_23("Consolas", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 1062614107) ^ 0x2F335B2E);
					continue;
				case 16u:
					num = (int)(num2 * 1798277078) ^ -1788843308;
					continue;
				case 15u:
					GForm0.smethod_32((Control)(object)this, bool_1: false);
					num = ((int)num2 * -222869473) ^ -1856821815;
					continue;
				case 14u:
					GForm0.smethod_13((Control)(object)PictureBox_0, "PictureBox1");
					num = ((int)num2 * -739043845) ^ 0x1A9E294D;
					continue;
				case 13u:
					Timer_0 = GForm0.smethod_5(icontainer_0);
					num = ((int)num2 * -1960953311) ^ 0x76223BEB;
					continue;
				case 12u:
					GForm0.smethod_7((ISupportInitialize)PictureBox_0);
					num = ((int)num2 * -418376104) ^ -1873089847;
					continue;
				case 11u:
					GForm0.smethod_8((Control)(object)this);
					num = ((int)num2 * -1487805190) ^ -1578661016;
					continue;
				case 10u:
					num = (int)((num2 * 2034294355) ^ 0x74E86D2F);
					continue;
				case 9u:
					GForm0.smethod_14((Control)(object)PictureBox_0, new Size(302, 211));
					num = ((int)num2 * -863633315) ^ -1419123212;
					continue;
				case 8u:
					num = ((int)num2 * -1802045144) ^ -1380768071;
					continue;
				case 6u:
					GForm0.smethod_9(Timer_0, 1000);
					num = ((int)num2 * -99870738) ^ 0x4C59DC08;
					continue;
				case 5u:
					GForm0.smethod_10((Control)(object)PictureBox_0, Color.Transparent);
					num = ((int)num2 * -933261286) ^ -2070848915;
					continue;
				case 4u:
					GForm0.smethod_11((Control)(object)this, (ImageLayout)3);
					num = (int)((num2 * 553439949) ^ 0x4E511F79);
					continue;
				case 3u:
					GForm0.smethod_26((Form)(object)this, new Padding(4));
					num = ((int)num2 * -243282266) ^ 0x40D92E73;
					continue;
				case 2u:
					num = ((int)num2 * -1485062704) ^ -2090442732;
					continue;
				case 1u:
					((Control)this).set_DoubleBuffered(true);
					num = (int)((num2 * 1059006484) ^ 0x29576205);
					continue;
				case 0u:
					GForm0.smethod_19((Form)(object)this, Color.White);
					num = ((int)num2 * -1140869582) ^ -116070385;
					continue;
				default:
					return;
				case 7u:
					break;
				case 23u:
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
			int num = 1759075215;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x36F7BF76u) % 10u)
				{
				case 8u:
					num = ((int)num2 * -1420960374) ^ 0x792F1D03;
					continue;
				case 7u:
					num = ((int)num2 * -1969701979) ^ 0x5D2278DA;
					continue;
				case 5u:
					num = (int)((num2 * 141922690) ^ 0x40000EB0);
					continue;
				case 4u:
					GClass1.smethod_0();
					num = (int)(num2 * 1033316899) ^ -1831833705;
					continue;
				case 3u:
					GForm0.smethod_41(Timer_1);
					num = ((int)num2 * -868502530) ^ 0x13F595AA;
					continue;
				case 2u:
					num = ((int)num2 * -1973463416) ^ 0x4A6FF5E4;
					continue;
				case 1u:
					GForm0.smethod_40((Control)(object)this, GForm0.smethod_39(GForm0.smethod_38(GForm0.smethod_37(), "\\data\\Images\\schermata_omegle.png")));
					GForm0.smethod_40((Control)(object)PictureBox_0, (Image)(object)smethod_0(GForm0.smethod_39(GForm0.smethod_38(GForm0.smethod_37(), "\\data\\Images\\marco_introduzione.png")), float_0));
					num = (int)(num2 * 1305012406) ^ -1793164650;
					continue;
				case 0u:
					GClass1.smethod_3().method_0();
					num = ((int)num2 * -2004582696) ^ -1328970953;
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
		Graphics graphics_ = default(Graphics);
		Bitmap val = default(Bitmap);
		ImageAttributes imageAttributes_ = default(ImageAttributes);
		ColorMatrix colorMatrix_ = default(ColorMatrix);
		Bitmap result = default(Bitmap);
		while (true)
		{
			int num = -419605759;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9371BE80u) % 13u)
				{
				case 12u:
					GForm0.smethod_50(graphics_, image_0, new Rectangle(0, 0, GForm0.smethod_42((Image)(object)val), GForm0.smethod_43((Image)(object)val)), 0, 0, GForm0.smethod_42(image_0), GForm0.smethod_43(image_0), (GraphicsUnit)2, imageAttributes_);
					num = (int)(num2 * 679798619) ^ -695220559;
					continue;
				case 11u:
					imageAttributes_ = GForm0.smethod_48();
					num = (int)((num2 * 40725531) ^ 0xCC9EF00);
					continue;
				case 10u:
					GForm0.smethod_47(colorMatrix_, float_1);
					num = ((int)num2 * -1306428401) ^ 0x942D6F8;
					continue;
				case 9u:
					num = ((int)num2 * -129006858) ^ 0x7C4BECD;
					continue;
				case 7u:
					num = ((int)num2 * -1358459548) ^ 0x53AC04DD;
					continue;
				case 6u:
					colorMatrix_ = GForm0.smethod_46();
					num = ((int)num2 * -1262731663) ^ -1653333531;
					continue;
				case 4u:
					val = GForm0.smethod_44(GForm0.smethod_42(image_0), GForm0.smethod_43(image_0));
					num = (int)((num2 * 1093157473) ^ 0x55792F39);
					continue;
				case 3u:
					GForm0.smethod_51(graphics_);
					num = (int)((num2 * 35906444) ^ 0x18A341EF);
					continue;
				case 2u:
					graphics_ = GForm0.smethod_45((Image)(object)val);
					num = ((int)num2 * -1109165393) ^ 0x6C764916;
					continue;
				case 1u:
					result = val;
					num = ((int)num2 * -1933548607) ^ 0x3047AA25;
					continue;
				case 0u:
					GForm0.smethod_49(imageAttributes_, colorMatrix_, (ColorMatrixFlag)0, (ColorAdjustType)1);
					num = (int)(num2 * 681962107) ^ -486151609;
					continue;
				case 5u:
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
			int num = 1379596449;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xAB57847u) % 3u)
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
				num = ((int)num2 * -457657674) ^ 0xE61C617;
			}
		}
	}

	private void method_3(object sender, FormClosingEventArgs e)
	{
		bool flag = default(bool);
		while (true)
		{
			int num = -52310224;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE85B7FEAu) % 9u)
				{
				case 7u:
					num = ((int)num2 * -258463907) ^ 0x558C543D;
					continue;
				case 6u:
					flag = !bool_0;
					num = ((int)num2 * -1832336601) ^ 0x3FB93069;
					continue;
				case 5u:
					GForm0.smethod_53((CancelEventArgs)(object)e, bool_1: true);
					num = (int)((num2 * 1308396079) ^ 0x13F6D2C8);
					continue;
				case 4u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = 380427962;
						num4 = 380427962;
					}
					else
					{
						num3 = 1958748766;
						num4 = 1958748766;
					}
					num = num3 ^ ((int)num2 * -1644930968);
					continue;
				}
				case 3u:
					method_4();
					num = (int)(num2 * 611806819) ^ -1688492003;
					continue;
				case 1u:
					num = (int)(num2 * 815249518) ^ -2073357591;
					continue;
				case 0u:
					num = (int)((num2 * 832372113) ^ 0x522B7786);
					continue;
				default:
					return;
				case 2u:
					break;
				case 8u:
					return;
				}
				break;
			}
		}
	}

	public void method_4()
	{
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Invalid comparison between Unknown and I4
		bool flag = default(bool);
		while (true)
		{
			int num = -1830282229;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x96CFBC9Fu) % 19u)
				{
				case 18u:
					num = (int)(num2 * 1792057664) ^ -110424123;
					continue;
				case 17u:
					GForm0.smethod_55(Timer_0);
					num = ((int)num2 * -2094285219) ^ -1633067526;
					continue;
				case 16u:
					GForm0.smethod_55(Timer_0);
					num = -43744421;
					continue;
				case 15u:
				{
					int num5;
					int num6;
					if (flag)
					{
						num5 = -1350205476;
						num6 = -1350205476;
					}
					else
					{
						num5 = -1503738008;
						num6 = -1503738008;
					}
					num = num5 ^ (int)(num2 * 1691554315);
					continue;
				}
				case 14u:
					GForm0.smethod_52();
					num = ((int)num2 * -1790825341) ^ 0xF6C835F;
					continue;
				case 13u:
					num = ((int)num2 * -1963456411) ^ 0x6CD25FF8;
					continue;
				case 12u:
					num = ((int)num2 * -1451489129) ^ 0x198B3B0F;
					continue;
				case 11u:
					num = (int)(num2 * 352922311) ^ -731893728;
					continue;
				case 10u:
					num = ((int)num2 * -486506690) ^ -1874802941;
					continue;
				case 9u:
					num = (int)((num2 * 2108637228) ^ 0x2F397DEC);
					continue;
				case 8u:
					num = -537257238;
					continue;
				case 7u:
					flag = (int)GForm0.smethod_54("Sei sicuro di voler uscire dal gioco?", "The Omegle Game", (MessageBoxButtons)4, (MessageBoxIcon)32) == 6;
					num = (int)((num2 * 1317605563) ^ 0x5C45BE8B);
					continue;
				case 6u:
				{
					int num3;
					int num4;
					if (!bool_0)
					{
						num3 = -210397806;
						num4 = -210397806;
					}
					else
					{
						num3 = -800898124;
						num4 = -800898124;
					}
					num = num3 ^ (int)(num2 * 1689521621);
					continue;
				}
				case 5u:
					GForm0.smethod_56((object)Timer_0);
					num = (int)(num2 * 650195909) ^ -394568692;
					continue;
				case 3u:
					GForm0.smethod_57(GForm0.smethod_35());
					num = (int)((num2 * 100695469) ^ 0x2E84FA23);
					continue;
				case 2u:
					GForm0.smethod_56((object)bool_0);
					GForm0.smethod_52();
					num = (int)(num2 * 1550393908) ^ -222783289;
					continue;
				case 0u:
					GForm0.smethod_56((object)Timer_0);
					GForm0.smethod_56((object)bool_0);
					num = ((int)num2 * -565899367) ^ -908286105;
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
		bool flag3 = default(bool);
		bool flag2 = default(bool);
		bool flag = default(bool);
		while (true)
		{
			int num = -934773450;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB07A9930u) % 43u)
				{
				case 42u:
					num = ((int)num2 * -2129900205) ^ 0xA79C6E1;
					continue;
				case 41u:
					num = ((int)num2 * -178225555) ^ 0x1FC5C09B;
					continue;
				case 40u:
					num = ((int)num2 * -1347784861) ^ -823950671;
					continue;
				case 39u:
					num = ((int)num2 * -802197930) ^ -1652205092;
					continue;
				case 38u:
					checked
					{
						int_0++;
					}
					num = (int)(num2 * 333606204) ^ -672009992;
					continue;
				case 37u:
				{
					int num8;
					int num9;
					if (int_0 > 15)
					{
						num8 = -403011380;
						num9 = -403011380;
					}
					else
					{
						num8 = -1043799881;
						num9 = -1043799881;
					}
					num = num8 ^ ((int)num2 * -2001615456);
					continue;
				}
				case 36u:
					GForm0.smethod_12((Control)(object)PictureBox_0, checked(new Point((int)GForm0.smethod_61((double)((float)GForm0.smethod_59((Control)(object)PictureBox_0).X + GForm0.smethod_60() * 10f)), (int)GForm0.smethod_61((double)((float)GForm0.smethod_59((Control)(object)PictureBox_0).Y - GForm0.smethod_60() * 10f)))));
					num = ((int)num2 * -523072675) ^ -2022828226;
					continue;
				case 35u:
					num = ((int)num2 * -1850884297) ^ 0x54BB7A5E;
					continue;
				case 34u:
					GForm0.smethod_56((object)Timer_1);
					num = ((int)num2 * -1644497520) ^ -530376645;
					continue;
				case 33u:
					GForm0.smethod_56((object)int_0);
					GClass1.smethod_3().method_3();
					num = ((int)num2 * -1597634092) ^ 0x5472902B;
					continue;
				case 32u:
				{
					ref float reference = ref float_0;
					reference = (float)((double)reference + 0.3);
					num = (int)((num2 * 1351214260) ^ 0x6F3BD41D);
					continue;
				}
				case 31u:
					num = ((int)num2 * -94518602) ^ 0x57E8C4AD;
					continue;
				case 30u:
				{
					int num10;
					int num11;
					if (flag3)
					{
						num10 = -1965680839;
						num11 = -1965680839;
					}
					else
					{
						num10 = -193294738;
						num11 = -193294738;
					}
					num = num10 ^ ((int)num2 * -210611248);
					continue;
				}
				case 29u:
					num = ((int)num2 * -1815419795) ^ 0x419EA580;
					continue;
				case 28u:
					checked
					{
						int_0++;
					}
					num = ((int)num2 * -1383829802) ^ -631714013;
					continue;
				case 27u:
					num = ((int)num2 * -353828672) ^ -829302395;
					continue;
				case 26u:
					flag3 = (int_0 >= 50) & (int_0 <= 57);
					num = -948653991;
					continue;
				case 25u:
				{
					int num6;
					int num7;
					if (flag2)
					{
						num6 = -933742452;
						num7 = -933742452;
					}
					else
					{
						num6 = -556547836;
						num7 = -556547836;
					}
					num = num6 ^ (int)(num2 * 1983232970);
					continue;
				}
				case 24u:
					num = ((int)num2 * -321103740) ^ -167524468;
					continue;
				case 23u:
					GForm0.smethod_56((object)float_0);
					num = ((int)num2 * -185419967) ^ 0x5BA3104;
					continue;
				case 22u:
					checked
					{
						int_0++;
					}
					num = ((int)num2 * -1022935198) ^ 0x99C8D72;
					continue;
				case 21u:
					checked
					{
						int_0++;
					}
					num = (int)(num2 * 662495323) ^ -98122207;
					continue;
				case 19u:
					num = (int)((num2 * 1604795339) ^ 0x7083DB7F);
					continue;
				case 18u:
					GForm0.smethod_40((Control)(object)PictureBox_0, (Image)(object)smethod_0(GForm0.smethod_58((Control)(object)PictureBox_0), float_0));
					num = (int)((num2 * 1220346972) ^ 0x14794C49);
					continue;
				case 17u:
					GForm0.smethod_52();
					num = (int)(num2 * 128596597) ^ -2049784058;
					continue;
				case 16u:
					num = ((int)num2 * -2138501376) ^ -838793290;
					continue;
				case 15u:
					GClass1.smethod_3().method_4();
					num = ((int)num2 * -697100034) ^ -1733684805;
					continue;
				case 14u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = 1218447140;
						num5 = 1218447140;
					}
					else
					{
						num4 = 553847253;
						num5 = 553847253;
					}
					num = num4 ^ (int)(num2 * 1026219054);
					continue;
				}
				case 13u:
					num = ((int)num2 * -465011068) ^ 0x1AE784D9;
					continue;
				case 12u:
					num = -18326781;
					continue;
				case 11u:
				{
					int num3;
					if ((int_0 >= 16) & (int_0 <= 20))
					{
						num = -232697901;
						num3 = -232697901;
					}
					else
					{
						num = -1360189475;
						num3 = -1360189475;
					}
					continue;
				}
				case 10u:
				{
					PictureBox control_;
					GForm0.smethod_65((Control)(object)(control_ = PictureBox_0), checked(GForm0.smethod_64((Control)(object)control_) + 22));
					GForm0.smethod_40((Control)(object)PictureBox_0, GForm0.smethod_39(GForm0.smethod_38(GForm0.smethod_37(), "\\data\\Images\\marco_introduzione.png")));
					num = ((int)num2 * -134725012) ^ -468878362;
					continue;
				}
				case 9u:
					checked
					{
						int_0++;
					}
					num = (int)((num2 * 1951166325) ^ 0x7C92E4AC);
					continue;
				case 8u:
					GForm0.smethod_40((Control)(object)PictureBox_0, GForm0.smethod_39(GForm0.smethod_38(GForm0.smethod_37(), "\\data\\Images\\marco_introduzione.png")));
					num = ((int)num2 * -523363721) ^ 0x3F7DDEB9;
					continue;
				case 7u:
				{
					PictureBox control_;
					GForm0.smethod_63((Control)(object)(control_ = PictureBox_0), checked(GForm0.smethod_62((Control)(object)control_) + 30));
					num = ((int)num2 * -792646827) ^ 0x5C37724C;
					continue;
				}
				case 6u:
					flag2 = (int_0 >= 21) & (int_0 <= 49);
					num = -814099235;
					continue;
				case 5u:
					flag = (int_0 >= 57) & (int_0 <= 65);
					num = -2058328930;
					continue;
				case 3u:
					num = (int)(num2 * 1581128356) ^ -354129353;
					continue;
				case 2u:
					GForm0.smethod_55(Timer_1);
					num = ((int)num2 * -2094387886) ^ 0x78AD9B58;
					continue;
				case 1u:
				{
					GForm0.smethod_12((Control)(object)PictureBox_0, new Point(512, 0));
					PictureBox control_;
					GForm0.smethod_65((Control)(object)(control_ = PictureBox_0), checked(GForm0.smethod_64((Control)(object)control_) + 30));
					num = (int)((num2 * 936549034) ^ 0x6C086E39);
					continue;
				}
				case 0u:
					num = (int)((num2 * 1211148740) ^ 0x354CDAD8);
					continue;
				default:
					return;
				case 20u:
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
