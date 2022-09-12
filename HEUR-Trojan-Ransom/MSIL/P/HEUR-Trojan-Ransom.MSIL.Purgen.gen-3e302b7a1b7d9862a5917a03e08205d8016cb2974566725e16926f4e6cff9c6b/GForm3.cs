using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

[DesignerGenerated]
public class GForm3 : Form
{
	private IContainer icontainer_0;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("MemoryCleaner")]
	private Timer timer_0;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Label1")]
	private Label label_0;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Storytelling")]
	private Timer timer_1;

	private bool bool_0;

	private int int_0;

	private int int_1;

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
				int num = 2146348905;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x2201BBEEu) % 7u)
					{
					case 5u:
						timer_0 = value;
						num = 2139041962;
						continue;
					case 4u:
						GForm3.smethod_33(val, eventHandler_);
						num = ((int)num2 * -302887409) ^ 0x25C6BC26;
						continue;
					case 3u:
					{
						val = timer_0;
						int num5;
						int num6;
						if (val != null)
						{
							num5 = 1347906257;
							num6 = 1347906257;
						}
						else
						{
							num5 = 1476012144;
							num6 = 1476012144;
						}
						num = num5 ^ (int)(num2 * 1701424726);
						continue;
					}
					case 2u:
					{
						val = timer_0;
						int num3;
						int num4;
						if (val == null)
						{
							num3 = 960853365;
							num4 = 960853365;
						}
						else
						{
							num3 = 1660052851;
							num4 = 1660052851;
						}
						num = num3 ^ (int)(num2 * 1199023022);
						continue;
					}
					case 1u:
						GForm3.smethod_34(val, eventHandler_);
						num = ((int)num2 * -42963579) ^ 0x60EC40AB;
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

	internal virtual Label Label_0
	{
		[CompilerGenerated]
		get
		{
			return label_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			label_0 = value;
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
				int num = 2126759259;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x2C2BDCFFu) % 8u)
					{
					case 7u:
						GForm3.smethod_34(val, eventHandler_);
						num = ((int)num2 * -230740079) ^ 0x21006CB8;
						continue;
					case 5u:
						timer_1 = value;
						num = 1435371270;
						continue;
					case 4u:
						val = timer_1;
						num = (int)(num2 * 493450800) ^ -1207704555;
						continue;
					case 3u:
						GForm3.smethod_33(val, eventHandler_);
						num = (int)((num2 * 197288604) ^ 0x2D0E07FE);
						continue;
					case 2u:
					{
						int num5;
						int num6;
						if (val != null)
						{
							num5 = -303971622;
							num6 = -303971622;
						}
						else
						{
							num5 = -1921782652;
							num6 = -1921782652;
						}
						num = num5 ^ ((int)num2 * -1882748085);
						continue;
					}
					case 1u:
					{
						val = timer_1;
						int num3;
						int num4;
						if (val == null)
						{
							num3 = -1952448943;
							num4 = -1952448943;
						}
						else
						{
							num3 = -919270682;
							num4 = -919270682;
						}
						num = num3 ^ (int)(num2 * 1983901070);
						continue;
					}
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

	public GForm3()
	{
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		while (true)
		{
			int num = -1792187349;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD48282EFu) % 7u)
				{
				case 6u:
					int_1 = 0;
					num = ((int)num2 * -571849789) ^ 0x368CC2F2;
					continue;
				case 5u:
					GForm3.smethod_0((Form)(object)this, (EventHandler)method_1);
					num = (int)(num2 * 147679318) ^ -1044676346;
					continue;
				case 2u:
					method_0();
					num = ((int)num2 * -663444976) ^ -1208431132;
					continue;
				case 1u:
					GForm3.smethod_1((Form)(object)this, new FormClosingEventHandler(method_3));
					num = ((int)num2 * -1202310348) ^ 0x5BE5A0CD;
					continue;
				case 0u:
					bool_0 = false;
					int_0 = 0;
					num = ((int)num2 * -405871788) ^ 0x7959C81A;
					continue;
				default:
					return;
				case 4u:
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
			while (true)
			{
				int num = 1706605360;
				while (true)
				{
					uint num2;
					int num3;
					switch ((num2 = (uint)num ^ 0x5FFD95A3u) % 7u)
					{
					case 4u:
						GForm3.smethod_2((IDisposable)icontainer_0);
						num = ((int)num2 * -1661707357) ^ -225416433;
						continue;
					case 3u:
						num = 1064875028;
						continue;
					case 2u:
						if (disposing)
						{
							num = (int)((num2 * 2073848960) ^ 0x21FAC33A);
							continue;
						}
						goto IL_0049;
					case 1u:
						if (icontainer_0 != null)
						{
							num = 818995295;
							num3 = 818995295;
							continue;
						}
						goto IL_0049;
					case 0u:
						num = ((int)num2 * -765620388) ^ 0x408BC34D;
						continue;
					default:
						return;
					case 6u:
						break;
					case 5u:
						return;
						IL_0049:
						num = 1496867565;
						num3 = 1496867565;
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
				int num4 = 1268625281;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num4 ^ 0x5FFD95A3u) % 4u)
					{
					case 2u:
						((Form)this).Dispose(disposing);
						num4 = ((int)num2 * -1801563409) ^ 0x1D76B28C;
						continue;
					case 1u:
						num4 = ((int)num2 * -439224508) ^ 0x68E9D4A3;
						continue;
					default:
						goto end_IL_00ca;
					case 3u:
						break;
					case 0u:
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
		//IL_040c: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			int num = -561966147;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x98C32B49u) % 38u)
				{
				case 37u:
					GForm3.smethod_13((Control)(object)Label_0, new Point(111, 270));
					num = (int)((num2 * 485438820) ^ 0x2E85930B);
					continue;
				case 36u:
					GForm3.smethod_8(Label_0, bool_1: true);
					num = ((int)num2 * -204114449) ^ 0x369A18E6;
					continue;
				case 35u:
					GForm3.smethod_19((ContainerControl)(object)this, (AutoScaleMode)1);
					num = ((int)num2 * -1077303308) ^ 0x6D42D885;
					continue;
				case 34u:
					GForm3.smethod_14((Control)(object)Label_0, "Label1");
					num = ((int)num2 * -1128149639) ^ -1984754719;
					continue;
				case 33u:
					GForm3.smethod_7(Timer_1, 6000);
					num = (int)(num2 * 749780730) ^ -746761803;
					continue;
				case 32u:
					num = (int)((num2 * 1118137796) ^ 0x26BF85E3);
					continue;
				case 31u:
					num = ((int)num2 * -2007207139) ^ -617402179;
					continue;
				case 30u:
					GForm3.smethod_17(Label_0, "Tutto ebbe inizio in un freddo giorno d'inverno...");
					num = ((int)num2 * -883605864) ^ -2049922898;
					continue;
				case 28u:
					GForm3.smethod_29((Form)(object)this, (FormStartPosition)1);
					GForm3.smethod_30((Form)(object)this, "The Omegle Game");
					num = (int)(num2 * 1401571643) ^ -299011586;
					continue;
				case 27u:
					num = (int)(num2 * 1486982354) ^ -472953267;
					continue;
				case 26u:
					GForm3.smethod_11((Control)(object)Label_0, GForm3.smethod_10("Microsoft Sans Serif", 24f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 1720725805) ^ 0x1993797E);
					continue;
				case 25u:
					num = ((int)num2 * -1557435955) ^ 0x3F22EF8B;
					continue;
				case 24u:
					GForm3.smethod_27((Form)(object)this, bool_1: false);
					GForm3.smethod_28((Control)(object)this, "StoryMode");
					num = (int)(num2 * 1049057795) ^ -1631833677;
					continue;
				case 23u:
					num = ((int)num2 * -1200199988) ^ -322007119;
					continue;
				case 22u:
					GForm3.smethod_18((ContainerControl)(object)this, new SizeF(10f, 22f));
					num = ((int)num2 * -1143916624) ^ 0x612FA05D;
					continue;
				case 21u:
					num = ((int)num2 * -1634513686) ^ 0x6498BF82;
					continue;
				case 20u:
					Timer_0 = GForm3.smethod_4(icontainer_0);
					num = (int)(num2 * 178930728) ^ -806841281;
					continue;
				case 19u:
					GForm3.smethod_15((Control)(object)Label_0, new Size(862, 46));
					GForm3.smethod_16((Control)(object)Label_0, 0);
					num = (int)(num2 * 485826855) ^ -254864341;
					continue;
				case 18u:
					GForm3.smethod_24(GForm3.smethod_23((Control)(object)this), (Control)(object)Label_0);
					num = (int)(num2 * 1364070833) ^ -1664038923;
					continue;
				case 17u:
					GForm3.smethod_32((Control)(object)this);
					num = (int)((num2 * 33160427) ^ 0x2F67BCC4);
					continue;
				case 16u:
					Timer_1 = GForm3.smethod_4(icontainer_0);
					GForm3.smethod_6((Control)(object)this);
					num = ((int)num2 * -1711170708) ^ -827308201;
					continue;
				case 15u:
					num = (int)((num2 * 1733627846) ^ 0x1D7EC5F2);
					continue;
				case 13u:
					GForm3.smethod_9((Control)(object)Label_0, Color.Transparent);
					num = (int)(num2 * 2064442029) ^ -1111875164;
					continue;
				case 12u:
					num = (int)((num2 * 1962754557) ^ 0x518F852);
					continue;
				case 11u:
					Label_0 = GForm3.smethod_5();
					num = (int)((num2 * 1548981902) ^ 0x5C28EB2D);
					continue;
				case 10u:
					icontainer_0 = GForm3.smethod_3();
					num = ((int)num2 * -457238056) ^ 0x62E13115;
					continue;
				case 9u:
					GForm3.smethod_12((Control)(object)Label_0, Color.White);
					num = ((int)num2 * -134309026) ^ -1753450396;
					continue;
				case 8u:
					GForm3.smethod_20((Form)(object)this, Color.White);
					num = (int)(num2 * 1788983715) ^ -325897450;
					continue;
				case 7u:
					GForm3.smethod_31((Control)(object)this, bool_1: false);
					num = (int)(num2 * 818188865) ^ -1492490977;
					continue;
				case 6u:
					((Control)this).set_DoubleBuffered(true);
					GForm3.smethod_11((Control)(object)this, GForm3.smethod_10("Consolas", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 445943298) ^ 0x5A798030);
					continue;
				case 5u:
					GForm3.smethod_21((Control)(object)this, (ImageLayout)3);
					GForm3.smethod_22((Form)(object)this, new Size(1025, 638));
					num = ((int)num2 * -2123250561) ^ 0x19969FAB;
					continue;
				case 4u:
					num = (int)((num2 * 302803557) ^ 0x401680E);
					continue;
				case 3u:
					GForm3.smethod_25((Form)(object)this, (FormBorderStyle)1);
					num = (int)((num2 * 1551521493) ^ 0x617A8BFD);
					continue;
				case 2u:
					GForm3.smethod_7(Timer_0, 1000);
					num = (int)((num2 * 633653188) ^ 0x11B63CA5);
					continue;
				case 1u:
					GForm3.smethod_26((Form)(object)this, new Padding(4));
					num = ((int)num2 * -2007730928) ^ 0x3A0E07F3;
					continue;
				case 0u:
					num = (int)((num2 * 333760350) ^ 0x59DE3AB8);
					continue;
				default:
					return;
				case 29u:
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
		bool flag = default(bool);
		while (true)
		{
			int num = 1563935462;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x63BC7340u) % 12u)
				{
				case 11u:
					GForm3.smethod_37(Timer_1);
					num = (int)((num2 * 93836608) ^ 0x47C50222);
					continue;
				case 10u:
					GForm3.smethod_36(GForm3.smethod_35(), ProcessPriorityClass.RealTime);
					num = (int)((num2 * 1148153742) ^ 0x195880B7);
					continue;
				case 9u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = -832579177;
						num4 = -832579177;
					}
					else
					{
						num3 = -1976830738;
						num4 = -1976830738;
					}
					num = num3 ^ ((int)num2 * -739868885);
					continue;
				}
				case 8u:
					num = (int)((num2 * 2063253557) ^ 0x1BC44310);
					continue;
				case 7u:
					GForm3.smethod_37(Timer_0);
					num = (int)((num2 * 1252403867) ^ 0x11FAE08A);
					continue;
				case 6u:
					num = ((int)num2 * -792539716) ^ -1656954420;
					continue;
				case 5u:
					num = (int)(num2 * 1655639164) ^ -324993517;
					continue;
				case 4u:
					GClass1.smethod_2().method_0();
					num = (int)(num2 * 2077794698) ^ -1990094519;
					continue;
				case 3u:
					flag = int_1 == 0;
					num = ((int)num2 * -669592329) ^ 0x2416370;
					continue;
				case 1u:
					GForm3.smethod_17(Label_0, "Tutto ebbe inizio in un freddo giorno d'inverno...");
					num = ((int)num2 * -2106909673) ^ -1467625601;
					continue;
				default:
					return;
				case 2u:
					break;
				case 0u:
					return;
				}
				break;
			}
		}
	}

	private void method_2(object sender, EventArgs e)
	{
		GForm3.smethod_38();
	}

	private void method_3(object sender, FormClosingEventArgs e)
	{
		method_4();
		if (!bool_0)
		{
			goto IL_0038;
		}
		goto IL_0062;
		IL_0062:
		int num = 1401394638;
		goto IL_003d;
		IL_003d:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0x26FBCD66u) % 5u)
			{
			case 3u:
				GForm3.smethod_39((CancelEventArgs)(object)e, bool_1: true);
				num = ((int)num2 * -1572738229) ^ 0x2931842A;
				continue;
			case 1u:
				num = (int)(num2 * 820709485) ^ -522376247;
				continue;
			case 0u:
				break;
			default:
				return;
			case 4u:
				goto IL_0062;
			case 2u:
				return;
			}
			break;
		}
		goto IL_0038;
		IL_0038:
		num = 919221153;
		goto IL_003d;
	}

	public void method_4()
	{
		//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c3: Invalid comparison between Unknown and I4
		bool flag2 = default(bool);
		bool flag = default(bool);
		while (true)
		{
			int num = -309398652;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE99F05DCu) % 22u)
				{
				case 21u:
					GForm3.smethod_42((object)Timer_0);
					num = (int)((num2 * 1940860943) ^ 0xAD573AB);
					continue;
				case 20u:
					flag2 = !bool_0;
					num = ((int)num2 * -1340550016) ^ 0x6CF4784C;
					continue;
				case 19u:
					GForm3.smethod_41(Timer_0);
					num = (int)((num2 * 547816110) ^ 0xB732217);
					continue;
				case 18u:
					GForm3.smethod_42((object)Timer_0);
					num = ((int)num2 * -786653041) ^ -190507037;
					continue;
				case 16u:
					num = (int)((num2 * 174047148) ^ 0x1D94305E);
					continue;
				case 15u:
					GForm3.smethod_42((object)bool_0);
					GForm3.smethod_38();
					num = ((int)num2 * -150150708) ^ -1540240141;
					continue;
				case 14u:
					num = -1323007685;
					continue;
				case 13u:
					GForm3.smethod_38();
					num = ((int)num2 * -1527358501) ^ 0x2183EBE8;
					continue;
				case 11u:
					num = ((int)num2 * -1857051793) ^ 0x290EA73D;
					continue;
				case 10u:
				{
					int num5;
					int num6;
					if (!flag2)
					{
						num5 = 53877144;
						num6 = 53877144;
					}
					else
					{
						num5 = 2088479220;
						num6 = 2088479220;
					}
					num = num5 ^ ((int)num2 * -269068392);
					continue;
				}
				case 9u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = 331842755;
						num4 = 331842755;
					}
					else
					{
						num3 = 152184372;
						num4 = 152184372;
					}
					num = num3 ^ (int)(num2 * 1163356222);
					continue;
				}
				case 8u:
					GForm3.smethod_41(Timer_0);
					num = ((int)num2 * -1771547007) ^ -1796879256;
					continue;
				case 7u:
					num = ((int)num2 * -1052414803) ^ 0x739557B3;
					continue;
				case 6u:
					GForm3.smethod_42((object)bool_0);
					num = ((int)num2 * -1129846277) ^ 0x75785F8D;
					continue;
				case 5u:
					GForm3.smethod_43(GForm3.smethod_35());
					num = (int)((num2 * 455024376) ^ 0xECE406D);
					continue;
				case 4u:
					num = -278599980;
					continue;
				case 3u:
					num = (int)((num2 * 1485251559) ^ 0x18B20210);
					continue;
				case 2u:
					flag = (int)GForm3.smethod_40("Sei sicuro di voler uscire dal gioco?", "The Omegle Game", (MessageBoxButtons)4, (MessageBoxIcon)32) == 6;
					num = (int)((num2 * 617501306) ^ 0x19415483);
					continue;
				case 1u:
					num = (int)((num2 * 1790265930) ^ 0x2A15A10C);
					continue;
				case 0u:
					num = (int)(num2 * 304966471) ^ -1667107484;
					continue;
				default:
					return;
				case 17u:
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
		bool flag3 = default(bool);
		bool flag2 = default(bool);
		bool flag8 = default(bool);
		bool flag7 = default(bool);
		bool flag5 = default(bool);
		bool flag = default(bool);
		bool flag4 = default(bool);
		bool flag6 = default(bool);
		while (true)
		{
			int num = 687387559;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x352BE6E3u) % 87u)
				{
				case 86u:
					GForm3.smethod_17(Label_0, "Che il gioco abbia inizio!");
					num = (int)((num2 * 373906755) ^ 0x45CB60AE);
					continue;
				case 85u:
					num = ((int)num2 * -1909002167) ^ 0x7B0E3CC9;
					continue;
				case 84u:
					num = (int)(num2 * 850339414) ^ -1859563371;
					continue;
				case 83u:
				{
					int num26;
					if (int_0 != 11)
					{
						num = 160513242;
						num26 = 160513242;
					}
					else
					{
						num = 409708425;
						num26 = 409708425;
					}
					continue;
				}
				case 82u:
					GClass1.smethod_2().method_3();
					num = ((int)num2 * -146250306) ^ -1330687383;
					continue;
				case 81u:
					num = ((int)num2 * -262027357) ^ -1622392564;
					continue;
				case 80u:
					flag3 = int_0 == 8;
					num = 273131440;
					continue;
				case 79u:
				{
					int num8;
					if (int_0 != 5)
					{
						num = 91022984;
						num8 = 91022984;
					}
					else
					{
						num = 703003625;
						num8 = 703003625;
					}
					continue;
				}
				case 78u:
					GForm3.smethod_17(Label_0, "Un mago molto misterioso, dagli oscuri segreti... andò\r\nsu OmeTV, quella sera.");
					num = ((int)num2 * -2022801025) ^ 0x63AEA5C2;
					continue;
				case 77u:
					num = (int)((num2 * 412783605) ^ 0x233D7A89);
					continue;
				case 76u:
				{
					int num25;
					if (int_0 != 2)
					{
						num = 1689537799;
						num25 = 1689537799;
					}
					else
					{
						num = 1267527445;
						num25 = 1267527445;
					}
					continue;
				}
				case 75u:
					checked
					{
						int_0++;
					}
					num = ((int)num2 * -1125952596) ^ 0x72EB1795;
					continue;
				case 74u:
					num = (int)(num2 * 980294358) ^ -2135423517;
					continue;
				case 73u:
					num = ((int)num2 * -1457232518) ^ -1033131361;
					continue;
				case 72u:
					num = ((int)num2 * -2089267400) ^ 0x61BA8432;
					continue;
				case 70u:
					GForm3.smethod_45((Control)(object)Class2.Class3_0.GForm0_0);
					num = ((int)num2 * -196588855) ^ 0x26CC0323;
					continue;
				case 69u:
				{
					int num18;
					if (int_0 == 14)
					{
						num = 1466051422;
						num18 = 1466051422;
					}
					else
					{
						num = 42733399;
						num18 = 42733399;
					}
					continue;
				}
				case 68u:
					num = (int)((num2 * 2134953922) ^ 0x305377C9);
					continue;
				case 67u:
					num = (int)((num2 * 668501458) ^ 0x48C1A2EB);
					continue;
				case 66u:
					num = (int)((num2 * 2021685449) ^ 0x4CA8ABA0);
					continue;
				case 65u:
					num = ((int)num2 * -788755651) ^ -1811075557;
					continue;
				case 64u:
					num = (int)(num2 * 1987974647) ^ -487733300;
					continue;
				case 63u:
					GClass1.smethod_2().method_0();
					num = ((int)num2 * -602371682) ^ 0x6DDD72AC;
					continue;
				case 61u:
					num = ((int)num2 * -1593354475) ^ -499933590;
					continue;
				case 60u:
				{
					int num9;
					int num10;
					if (flag2)
					{
						num9 = 307215369;
						num10 = 307215369;
					}
					else
					{
						num9 = 1097041184;
						num10 = 1097041184;
					}
					num = num9 ^ ((int)num2 * -1127199911);
					continue;
				}
				case 59u:
				{
					int num5;
					if (int_0 == 7)
					{
						num = 1464515228;
						num5 = 1464515228;
					}
					else
					{
						num = 1009272413;
						num5 = 1009272413;
					}
					continue;
				}
				case 58u:
				{
					int num27;
					if (int_0 != 6)
					{
						num = 1022941094;
						num27 = 1022941094;
					}
					else
					{
						num = 1245287716;
						num27 = 1245287716;
					}
					continue;
				}
				case 57u:
					num = (int)(num2 * 1457354307) ^ -1321054926;
					continue;
				case 56u:
					flag8 = int_0 == 15;
					num = 1008247572;
					continue;
				case 55u:
					flag7 = int_0 == 1;
					num = (int)(num2 * 278430280) ^ -1079141220;
					continue;
				case 54u:
					num = ((int)num2 * -270011118) ^ -1151134269;
					continue;
				case 53u:
					num = ((int)num2 * -615062280) ^ -1443604139;
					continue;
				case 52u:
				{
					int num23;
					int num24;
					if (flag8)
					{
						num23 = -1595278774;
						num24 = -1595278774;
					}
					else
					{
						num23 = -310263349;
						num24 = -310263349;
					}
					num = num23 ^ ((int)num2 * -174169886);
					continue;
				}
				case 51u:
					GForm3.smethod_17(Label_0, "Sono delle persone che hanno delle grandissime capacità\r\nda disabili, ma non solo.");
					num = ((int)num2 * -88994971) ^ 0x6E8A8D02;
					continue;
				case 50u:
				{
					int num21;
					int num22;
					if (!flag5)
					{
						num21 = 729297451;
						num22 = 729297451;
					}
					else
					{
						num21 = 200675725;
						num22 = 200675725;
					}
					num = num21 ^ (int)(num2 * 491765567);
					continue;
				}
				case 49u:
					GForm3.smethod_17(Label_0, "Il mago e i suoi amici sono sempre pronti ad affrontare\r\nogni nuova sfida ed ogni pericolo.");
					num = ((int)num2 * -52962041) ^ 0x7F8A3C38;
					continue;
				case 48u:
					GForm3.smethod_17(Label_0, "In pochi sanno chi sono, ma lui riuscì a vedere di più:\r\nerano gli imperatori di Omegle.");
					num = ((int)num2 * -2102732463) ^ 0x77269C14;
					continue;
				case 47u:
					num = (int)((num2 * 1745216614) ^ 0xA94E72D);
					continue;
				case 46u:
					flag = int_0 == 13;
					num = 1461948375;
					continue;
				case 45u:
					num = ((int)num2 * -1283926181) ^ 0x35A82E3F;
					continue;
				case 44u:
					num = ((int)num2 * -294529871) ^ -111011;
					continue;
				case 43u:
					GForm3.smethod_17(Label_0, "E il mago pian piano, nel suo tortuoso cammino,\r\nne trovò tanti di tali imperatori.");
					num = (int)((num2 * 1049214690) ^ 0x372A0F31);
					continue;
				case 42u:
				{
					int num19;
					int num20;
					if (flag4)
					{
						num19 = 96337308;
						num20 = 96337308;
					}
					else
					{
						num19 = 142853094;
						num20 = 142853094;
					}
					num = num19 ^ ((int)num2 * -392112867);
					continue;
				}
				case 41u:
					num = ((int)num2 * -1805363967) ^ 0x450B5C70;
					continue;
				case 40u:
					num = (int)((num2 * 1260376937) ^ 0x7BE389EC);
					continue;
				case 39u:
				{
					int num16;
					int num17;
					if (!flag6)
					{
						num16 = 1739288636;
						num17 = 1739288636;
					}
					else
					{
						num16 = 59543252;
						num17 = 59543252;
					}
					num = num16 ^ ((int)num2 * -901817251);
					continue;
				}
				case 38u:
					num = ((int)num2 * -1626388309) ^ 0x5FEFC1A9;
					continue;
				case 37u:
					GForm3.smethod_17(Label_0, "Un mondo pieno di pedofili, maniaci, assassini, pazzi,\r\npersone pluripregiudicate e morti di figa...");
					num = (int)(num2 * 203853818) ^ -1794163880;
					continue;
				case 36u:
					GForm3.smethod_17(Label_0, "Ma non riuscì bene ad orientarsi... c'era tante persone\r\nche gli ostacolavano il cammino...");
					num = (int)(num2 * 77434535) ^ -119092926;
					continue;
				case 35u:
					num = (int)((num2 * 411029133) ^ 0x12D44E9E);
					continue;
				case 34u:
				{
					int num14;
					int num15;
					if (flag7)
					{
						num14 = 1276566949;
						num15 = 1276566949;
					}
					else
					{
						num14 = 1183115297;
						num15 = 1183115297;
					}
					num = num14 ^ ((int)num2 * -1391359022);
					continue;
				}
				case 33u:
					GForm3.smethod_17(Label_0, "Così egli capii che c'era un solo modo di porre fine\r\nad ogni problema...");
					num = ((int)num2 * -473520429) ^ -926883820;
					continue;
				case 32u:
					flag6 = int_0 == 12;
					num = 1269483600;
					continue;
				case 31u:
					num = ((int)num2 * -899115558) ^ -1049815421;
					continue;
				case 30u:
					GForm3.smethod_13((Control)(object)Label_0, new Point(checked(GForm3.smethod_44((Control)(object)Label_0).X + 60), GForm3.smethod_44((Control)(object)Label_0).Y));
					num = ((int)num2 * -478554950) ^ -735044423;
					continue;
				case 29u:
					flag2 = int_0 == 9;
					num = 1436556066;
					continue;
				case 28u:
					num = ((int)num2 * -1515220262) ^ 0x77C85152;
					continue;
				case 27u:
					bool_0 = true;
					num = ((int)num2 * -19797375) ^ -99612852;
					continue;
				case 26u:
					GClass1.smethod_2().method_3();
					num = (int)((num2 * 1476865574) ^ 0x223D5D69);
					continue;
				case 25u:
					num = ((int)num2 * -98610658) ^ 0x61FE742D;
					continue;
				case 24u:
					num = (int)((num2 * 1172609489) ^ 0x73A2EEB0);
					continue;
				case 23u:
					GForm3.smethod_17(Label_0, "Purtroppo la noia è una droga molto cancerosa, ed egli\r\nsi mise alla ricerca di nuove avventure.");
					num = (int)((num2 * 1269535115) ^ 0x37ED9D94);
					continue;
				case 22u:
					GForm3.smethod_17(Label_0, "Non sapeva bene cosa lo attendeva, ma sapeva bene che\r\n era un grande pericolo intrufolarsi là dentro.");
					num = (int)((num2 * 181696523) ^ 0x7083A728);
					continue;
				case 21u:
					GForm3.smethod_17(Label_0, "Egli poteva fare trucchi di magia con le carte e con i\r\ncubi agli sconosciuti... Bello, no?");
					num = ((int)num2 * -15967797) ^ -1172048862;
					continue;
				case 20u:
					num = (int)(num2 * 265360914) ^ -1901942401;
					continue;
				case 19u:
					GForm3.smethod_17(Label_0, "Queste persone trascorrono il loro tempo libero, la loro\r\nintera vita su Omegle, con gli altri.");
					num = ((int)num2 * -1334663482) ^ -1569697335;
					continue;
				case 18u:
					GForm3.smethod_46((Form)(object)this);
					num = (int)(num2 * 1618667636) ^ -1393388774;
					continue;
				case 17u:
					num = ((int)num2 * -1648465595) ^ -1199998098;
					continue;
				case 16u:
					num = ((int)num2 * -960377910) ^ 0x44686142;
					continue;
				case 15u:
					num = ((int)num2 * -1101942165) ^ 0x31B2E1FC;
					continue;
				case 14u:
					GForm3.smethod_17(Label_0, "Insieme a questo mago e ai suoi fantastici amici, \r\npercorrerai tutta la strada di Omegle.");
					num = (int)((num2 * 1970251621) ^ 0x19483EB3);
					continue;
				case 13u:
					num = ((int)num2 * -346307467) ^ -2060172651;
					continue;
				case 12u:
					flag5 = int_0 == 4;
					num = 1432085701;
					continue;
				case 11u:
					GForm3.smethod_17(Label_0, "Ma lui era solo un semplice mago, come poteva riuscire\r\nad affrontare le agonie contenute là dentro?");
					num = ((int)num2 * -277692038) ^ -557974329;
					continue;
				case 10u:
					num = ((int)num2 * -2134254451) ^ 0x19750FA6;
					continue;
				case 9u:
					flag4 = int_0 == 3;
					num = 861339243;
					continue;
				case 8u:
				{
					int num12;
					int num13;
					if (flag3)
					{
						num12 = 1578770158;
						num13 = 1578770158;
					}
					else
					{
						num12 = 675983513;
						num13 = 675983513;
					}
					num = num12 ^ ((int)num2 * -1434676942);
					continue;
				}
				case 7u:
					GClass1.smethod_2().method_4();
					num = ((int)num2 * -1235296824) ^ 0x3E1B15C2;
					continue;
				case 6u:
				{
					int num11;
					if (int_0 == 10)
					{
						num = 276209895;
						num11 = 276209895;
					}
					else
					{
						num = 837790726;
						num11 = 837790726;
					}
					continue;
				}
				case 5u:
				{
					int num6;
					int num7;
					if (flag)
					{
						num6 = 1162449590;
						num7 = 1162449590;
					}
					else
					{
						num6 = 1556174382;
						num7 = 1556174382;
					}
					num = num6 ^ (int)(num2 * 1771436812);
					continue;
				}
				case 4u:
					num = (int)((num2 * 580159902) ^ 0x4C7C2FCB);
					continue;
				case 3u:
					num = 1526977958;
					continue;
				case 2u:
					num = 1823785046;
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (int_1 != 0)
					{
						num3 = -1394348688;
						num4 = -1394348688;
					}
					else
					{
						num3 = -1276201288;
						num4 = -1276201288;
					}
					num = num3 ^ (int)(num2 * 419416593);
					continue;
				}
				case 0u:
					num = (int)((num2 * 1562983058) ^ 0x475DED33);
					continue;
				default:
					return;
				case 71u:
					break;
				case 62u:
					return;
				}
				break;
			}
		}
	}

	static void smethod_0(Form form_0, EventHandler eventHandler_0)
	{
		form_0.add_Load(eventHandler_0);
	}

	static void smethod_1(Form form_0, FormClosingEventHandler formClosingEventHandler_0)
	{
		form_0.add_FormClosing(formClosingEventHandler_0);
	}

	static void smethod_2(IDisposable idisposable_0)
	{
		idisposable_0.Dispose();
	}

	static Container smethod_3()
	{
		return new Container();
	}

	static Timer smethod_4(IContainer icontainer_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		return new Timer(icontainer_1);
	}

	static Label smethod_5()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new Label();
	}

	static void smethod_6(Control control_0)
	{
		control_0.SuspendLayout();
	}

	static void smethod_7(Timer timer_2, int int_2)
	{
		timer_2.set_Interval(int_2);
	}

	static void smethod_8(Label label_1, bool bool_1)
	{
		label_1.set_AutoSize(bool_1);
	}

	static void smethod_9(Control control_0, Color color_0)
	{
		control_0.set_BackColor(color_0);
	}

	static Font smethod_10(string string_0, float float_0, FontStyle fontStyle_0, GraphicsUnit graphicsUnit_0, byte byte_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		return new Font(string_0, float_0, fontStyle_0, graphicsUnit_0, byte_0);
	}

	static void smethod_11(Control control_0, Font font_0)
	{
		control_0.set_Font(font_0);
	}

	static void smethod_12(Control control_0, Color color_0)
	{
		control_0.set_ForeColor(color_0);
	}

	static void smethod_13(Control control_0, Point point_0)
	{
		control_0.set_Location(point_0);
	}

	static void smethod_14(Control control_0, string string_0)
	{
		control_0.set_Name(string_0);
	}

	static void smethod_15(Control control_0, Size size_0)
	{
		control_0.set_Size(size_0);
	}

	static void smethod_16(Control control_0, int int_2)
	{
		control_0.set_TabIndex(int_2);
	}

	static void smethod_17(Label label_1, string string_0)
	{
		label_1.set_Text(string_0);
	}

	static void smethod_18(ContainerControl containerControl_0, SizeF sizeF_0)
	{
		containerControl_0.set_AutoScaleDimensions(sizeF_0);
	}

	static void smethod_19(ContainerControl containerControl_0, AutoScaleMode autoScaleMode_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		containerControl_0.set_AutoScaleMode(autoScaleMode_0);
	}

	static void smethod_20(Form form_0, Color color_0)
	{
		form_0.set_BackColor(color_0);
	}

	static void smethod_21(Control control_0, ImageLayout imageLayout_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		control_0.set_BackgroundImageLayout(imageLayout_0);
	}

	static void smethod_22(Form form_0, Size size_0)
	{
		form_0.set_ClientSize(size_0);
	}

	static ControlCollection smethod_23(Control control_0)
	{
		return control_0.get_Controls();
	}

	static void smethod_24(ControlCollection controlCollection_0, Control control_0)
	{
		controlCollection_0.Add(control_0);
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

	static void smethod_31(Control control_0, bool bool_1)
	{
		control_0.ResumeLayout(bool_1);
	}

	static void smethod_32(Control control_0)
	{
		control_0.PerformLayout();
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

	static void smethod_37(Timer timer_2)
	{
		timer_2.Start();
	}

	static void smethod_38()
	{
		GC.Collect();
	}

	static void smethod_39(CancelEventArgs cancelEventArgs_0, bool bool_1)
	{
		cancelEventArgs_0.Cancel = bool_1;
	}

	static DialogResult smethod_40(string string_0, string string_1, MessageBoxButtons messageBoxButtons_0, MessageBoxIcon messageBoxIcon_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return MessageBox.Show(string_0, string_1, messageBoxButtons_0, messageBoxIcon_0);
	}

	static void smethod_41(Timer timer_2)
	{
		timer_2.Stop();
	}

	static void smethod_42(object object_0)
	{
		GC.SuppressFinalize(object_0);
	}

	static void smethod_43(Process process_0)
	{
		process_0.Kill();
	}

	static Point smethod_44(Control control_0)
	{
		return control_0.get_Location();
	}

	static void smethod_45(Control control_0)
	{
		control_0.Show();
	}

	static void smethod_46(Form form_0)
	{
		form_0.Close();
	}
}
