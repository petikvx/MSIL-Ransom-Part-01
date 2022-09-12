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
				int num = 1615442459;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x735A047u) % 9u)
					{
					case 8u:
					{
						int num5;
						int num6;
						if (val != null)
						{
							num5 = 914081827;
							num6 = 914081827;
						}
						else
						{
							num5 = 1941197972;
							num6 = 1941197972;
						}
						num = num5 ^ ((int)num2 * -1363207356);
						continue;
					}
					case 6u:
						GForm3.smethod_34(val, eventHandler_);
						num = (int)(num2 * 741195993) ^ -1272538703;
						continue;
					case 4u:
						timer_0 = value;
						num = 1848793636;
						continue;
					case 3u:
					{
						int num3;
						int num4;
						if (val != null)
						{
							num3 = 507748674;
							num4 = 507748674;
						}
						else
						{
							num3 = 1943022340;
							num4 = 1943022340;
						}
						num = num3 ^ ((int)num2 * -1832823765);
						continue;
					}
					case 2u:
						val = timer_0;
						num = (int)(num2 * 799006164) ^ -1424066942;
						continue;
					case 1u:
						val = timer_0;
						num = ((int)num2 * -1224434354) ^ -1647605656;
						continue;
					case 0u:
						GForm3.smethod_33(val, eventHandler_);
						num = (int)(num2 * 664655559) ^ -545523904;
						continue;
					default:
						return;
					case 5u:
						break;
					case 7u:
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
			Timer val = timer_1;
			if (val != null)
			{
				goto IL_0040;
			}
			goto IL_00b4;
			IL_00b4:
			timer_1 = value;
			int num = 1866073419;
			goto IL_0087;
			IL_0087:
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x730AD83Au) % 7u)
				{
				case 6u:
				{
					int num3;
					int num4;
					if (val == null)
					{
						num3 = 332376902;
						num4 = 332376902;
					}
					else
					{
						num3 = 274799268;
						num4 = 274799268;
					}
					num = num3 ^ (int)(num2 * 899921366);
					continue;
				}
				case 5u:
					break;
				case 2u:
					GForm3.smethod_33(val, eventHandler_);
					num = ((int)num2 * -169293458) ^ 0x6AAC9117;
					continue;
				case 1u:
					val = timer_1;
					num = (int)((num2 * 613545589) ^ 0x815A945);
					continue;
				case 0u:
					GForm3.smethod_34(val, eventHandler_);
					num = ((int)num2 * -1765506763) ^ 0x6D8B4AF0;
					continue;
				default:
					return;
				case 3u:
					goto IL_00b4;
				case 4u:
					return;
				}
				break;
			}
			goto IL_0040;
			IL_0040:
			num = 598380070;
			goto IL_0087;
		}
	}

	public GForm3()
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected O, but got Unknown
		while (true)
		{
			int num = -1264679878;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE3889334u) % 8u)
				{
				case 7u:
					GForm3.smethod_0((Form)(object)this, (EventHandler)method_1);
					GForm3.smethod_1((Form)(object)this, new FormClosingEventHandler(method_3));
					num = (int)((num2 * 546177271) ^ 0x50A4AFD7);
					continue;
				case 6u:
					num = (int)(num2 * 1314051813) ^ -1563283131;
					continue;
				case 5u:
					num = ((int)num2 * -666288652) ^ -422048540;
					continue;
				case 3u:
					int_1 = 0;
					num = (int)((num2 * 1127091470) ^ 0x5154F467);
					continue;
				case 2u:
					bool_0 = false;
					int_0 = 0;
					num = ((int)num2 * -521144216) ^ 0x46DCC3F7;
					continue;
				case 1u:
					method_0();
					num = (int)(num2 * 1353814819) ^ -91051742;
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
			bool flag = default(bool);
			while (true)
			{
				int num = -830366462;
				while (true)
				{
					uint num2;
					int num5;
					switch ((num2 = (uint)num ^ 0xD95C4D89u) % 8u)
					{
					case 7u:
						num = (int)((num2 * 1883125351) ^ 0x7B9DDAFE);
						continue;
					case 6u:
						num = ((int)num2 * -2002016105) ^ 0x39F4069E;
						continue;
					case 4u:
						num5 = ((icontainer_0 != null) ? 1 : 0);
						goto IL_002e;
					case 3u:
						if (disposing)
						{
							num = (int)(num2 * 874720387) ^ -1343952860;
							continue;
						}
						num5 = 0;
						goto IL_002e;
					case 2u:
					{
						int num3;
						int num4;
						if (!flag)
						{
							num3 = 286197792;
							num4 = 286197792;
						}
						else
						{
							num3 = 957576540;
							num4 = 957576540;
						}
						num = num3 ^ (int)(num2 * 613073562);
						continue;
					}
					case 1u:
						GForm3.smethod_2((IDisposable)icontainer_0);
						num = (int)(num2 * 1078073540) ^ -1068963110;
						continue;
					default:
						return;
					case 0u:
						break;
					case 5u:
						return;
						IL_002e:
						flag = (byte)num5 != 0;
						num = -1461538413;
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
				IL_00f5:
				int num6 = -939089602;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num6 ^ 0xD95C4D89u) % 3u)
					{
					case 1u:
						goto IL_00c4;
					default:
						goto end_IL_00d8;
					case 2u:
						break;
					case 0u:
						goto end_IL_00d8;
					}
					goto IL_00f5;
					IL_00c4:
					((Form)this).Dispose(disposing);
					num6 = ((int)num2 * -1146749707) ^ -974893953;
					continue;
					end_IL_00d8:
					break;
				}
				break;
			}
		}
	}

	[DebuggerStepThrough]
	private void method_0()
	{
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		icontainer_0 = GForm3.smethod_3();
		while (true)
		{
			int num = 337769762;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1512F15Cu) % 38u)
				{
				case 37u:
					GForm3.smethod_24(GForm3.smethod_23((Control)(object)this), (Control)(object)Label_0);
					((Control)this).set_DoubleBuffered(true);
					num = ((int)num2 * -1390089172) ^ -547504144;
					continue;
				case 36u:
					GForm3.smethod_21((Control)(object)this, (ImageLayout)3);
					num = (int)((num2 * 1381280485) ^ 0x79EDE59A);
					continue;
				case 35u:
					num = ((int)num2 * -861176894) ^ -779173492;
					continue;
				case 34u:
					GForm3.smethod_18((ContainerControl)(object)this, new SizeF(10f, 22f));
					num = (int)((num2 * 1137169504) ^ 0x1BDE9EC1);
					continue;
				case 33u:
					num = ((int)num2 * -155533205) ^ 0x7ED2428C;
					continue;
				case 32u:
					GForm3.smethod_20((Form)(object)this, Color.White);
					num = ((int)num2 * -1186158731) ^ 0x211355C;
					continue;
				case 31u:
					num = (int)(num2 * 1430616228) ^ -459868717;
					continue;
				case 30u:
					num = (int)((num2 * 2135313777) ^ 0x38D3B1F9);
					continue;
				case 29u:
					num = (int)((num2 * 1631580852) ^ 0x36A2EF94);
					continue;
				case 28u:
					num = (int)(num2 * 770636133) ^ -910525100;
					continue;
				case 27u:
					GForm3.smethod_26((Form)(object)this, new Padding(4));
					num = (int)((num2 * 715067345) ^ 0x39A0092E);
					continue;
				case 26u:
					GForm3.smethod_16((Control)(object)Label_0, 0);
					GForm3.smethod_17(Label_0, "Tutto ebbe inizio in un freddo giorno d'inverno...");
					GForm3.smethod_7(Timer_1, 6000);
					num = ((int)num2 * -890996321) ^ 0x20E3C416;
					continue;
				case 25u:
					GForm3.smethod_19((ContainerControl)(object)this, (AutoScaleMode)1);
					num = (int)(num2 * 271777595) ^ -101794205;
					continue;
				case 24u:
					num = ((int)num2 * -2081489919) ^ 0x6B5B8A79;
					continue;
				case 23u:
					Timer_1 = GForm3.smethod_4(icontainer_0);
					num = (int)((num2 * 197388425) ^ 0x66824C6);
					continue;
				case 22u:
					num = (int)(num2 * 1522605308) ^ -26961948;
					continue;
				case 21u:
					GForm3.smethod_14((Control)(object)Label_0, "Label1");
					GForm3.smethod_15((Control)(object)Label_0, new Size(862, 46));
					num = ((int)num2 * -2021346678) ^ 0x67EDB7C4;
					continue;
				case 20u:
					GForm3.smethod_31((Control)(object)this, bool_1: false);
					num = ((int)num2 * -2042313002) ^ -2017005388;
					continue;
				case 19u:
					GForm3.smethod_25((Form)(object)this, (FormBorderStyle)1);
					num = ((int)num2 * -873352588) ^ -74274342;
					continue;
				case 18u:
					GForm3.smethod_22((Form)(object)this, new Size(1025, 638));
					num = (int)((num2 * 632344854) ^ 0x63D69EF);
					continue;
				case 17u:
					GForm3.smethod_8(Label_0, bool_1: true);
					num = ((int)num2 * -600220372) ^ -573664241;
					continue;
				case 16u:
					GForm3.smethod_12((Control)(object)Label_0, Color.White);
					GForm3.smethod_13((Control)(object)Label_0, new Point(111, 270));
					num = (int)(num2 * 544849732) ^ -116800137;
					continue;
				case 15u:
					num = (int)(num2 * 1067958478) ^ -211129617;
					continue;
				case 14u:
					GForm3.smethod_11((Control)(object)Label_0, GForm3.smethod_10("Microsoft Sans Serif", 24f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 1980629708) ^ -982848994;
					continue;
				case 13u:
					GForm3.smethod_28((Control)(object)this, "StoryMode");
					num = ((int)num2 * -998170610) ^ 0x76BF154F;
					continue;
				case 12u:
					GForm3.smethod_29((Form)(object)this, (FormStartPosition)1);
					num = ((int)num2 * -1830274356) ^ 0x57EB6018;
					continue;
				case 11u:
					GForm3.smethod_6((Control)(object)this);
					GForm3.smethod_7(Timer_0, 1000);
					num = (int)((num2 * 414304034) ^ 0x35D0681D);
					continue;
				case 10u:
					GForm3.smethod_30((Form)(object)this, "The Omegle Game");
					num = (int)(num2 * 1070727208) ^ -1331363993;
					continue;
				case 8u:
					GForm3.smethod_9((Control)(object)Label_0, Color.Transparent);
					num = ((int)num2 * -478160267) ^ -1188012340;
					continue;
				case 7u:
					num = ((int)num2 * -1794029929) ^ 0x3BA17BB5;
					continue;
				case 6u:
					Timer_0 = GForm3.smethod_4(icontainer_0);
					num = (int)(num2 * 1122186684) ^ -1024985402;
					continue;
				case 4u:
					Label_0 = GForm3.smethod_5();
					num = (int)(num2 * 1062666451) ^ -750015533;
					continue;
				case 3u:
					GForm3.smethod_27((Form)(object)this, bool_1: false);
					num = (int)((num2 * 1301650658) ^ 0x6DDC85B5);
					continue;
				case 2u:
					num = ((int)num2 * -1429791756) ^ 0xC99E3E6;
					continue;
				case 1u:
					GForm3.smethod_32((Control)(object)this);
					num = ((int)num2 * -2050769261) ^ -1714925610;
					continue;
				case 0u:
					GForm3.smethod_11((Control)(object)this, GForm3.smethod_10("Consolas", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -76992706) ^ -1397858287;
					continue;
				default:
					return;
				case 9u:
					break;
				case 5u:
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
			int num = 120888121;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1B911763u) % 13u)
				{
				case 12u:
					GClass1.smethod_2().method_0();
					num = (int)(num2 * 1254960791) ^ -1008026681;
					continue;
				case 11u:
					GForm3.smethod_37(Timer_0);
					num = ((int)num2 * -1598137708) ^ 0x590313E2;
					continue;
				case 10u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = -882743174;
						num4 = -882743174;
					}
					else
					{
						num3 = -1755728865;
						num4 = -1755728865;
					}
					num = num3 ^ ((int)num2 * -681360124);
					continue;
				}
				case 9u:
					num = 827955162;
					continue;
				case 8u:
					num = (int)((num2 * 445176548) ^ 0x3552BAE8);
					continue;
				case 7u:
					num = ((int)num2 * -592942519) ^ 0x1929C2A5;
					continue;
				case 6u:
					GForm3.smethod_37(Timer_1);
					num = ((int)num2 * -1357500058) ^ 0xC2741E3;
					continue;
				case 4u:
					GForm3.smethod_17(Label_0, "Tutto ebbe inizio in un freddo giorno d'inverno...");
					num = ((int)num2 * -1236189916) ^ 0x40B55327;
					continue;
				case 2u:
					flag = int_1 == 0;
					num = (int)(num2 * 836655420) ^ -250335496;
					continue;
				case 1u:
					GForm3.smethod_36(GForm3.smethod_35(), ProcessPriorityClass.RealTime);
					num = ((int)num2 * -741161826) ^ -629608937;
					continue;
				case 0u:
					num = (int)(num2 * 1928727823) ^ -1326566683;
					continue;
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

	private void method_2(object sender, EventArgs e)
	{
		GForm3.smethod_38();
	}

	private void method_3(object sender, FormClosingEventArgs e)
	{
		bool flag = default(bool);
		while (true)
		{
			int num = -1995107504;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x81982CE3u) % 9u)
				{
				case 8u:
					num = (int)((num2 * 741050891) ^ 0x67561308);
					continue;
				case 6u:
					GForm3.smethod_39((CancelEventArgs)(object)e, bool_1: true);
					num = ((int)num2 * -1729256767) ^ 0x7BF9D327;
					continue;
				case 5u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = -655017265;
						num4 = -655017265;
					}
					else
					{
						num3 = -1727335622;
						num4 = -1727335622;
					}
					num = num3 ^ ((int)num2 * -1288231923);
					continue;
				}
				case 4u:
					method_4();
					num = (int)(num2 * 473558081) ^ -2129158904;
					continue;
				case 3u:
					num = -686950579;
					continue;
				case 2u:
					num = ((int)num2 * -574443316) ^ 0x2FF2C904;
					continue;
				case 0u:
					flag = !bool_0;
					num = ((int)num2 * -881240108) ^ -771200144;
					continue;
				default:
					return;
				case 7u:
					break;
				case 1u:
					return;
				}
				break;
			}
		}
	}

	public void method_4()
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Invalid comparison between Unknown and I4
		bool flag = default(bool);
		while (true)
		{
			int num = -139365822;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC84542F3u) % 18u)
				{
				case 17u:
					num = ((int)num2 * -1465825252) ^ 0x1D3BEEDA;
					continue;
				case 16u:
					GForm3.smethod_42((object)Timer_0);
					num = (int)((num2 * 790985789) ^ 0x365C0655);
					continue;
				case 15u:
				{
					int num5;
					int num6;
					if ((int)GForm3.smethod_40("Sei sicuro di voler uscire dal gioco?", "The Omegle Game", (MessageBoxButtons)4, (MessageBoxIcon)32) != 6)
					{
						num5 = -84498878;
						num6 = -84498878;
					}
					else
					{
						num5 = -493126456;
						num6 = -493126456;
					}
					num = num5 ^ (int)(num2 * 501638513);
					continue;
				}
				case 14u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = -248951936;
						num4 = -248951936;
					}
					else
					{
						num3 = -430182115;
						num4 = -430182115;
					}
					num = num3 ^ (int)(num2 * 1670634500);
					continue;
				}
				case 13u:
					GForm3.smethod_41(Timer_0);
					num = ((int)num2 * -1188538902) ^ 0x766E1653;
					continue;
				case 12u:
					GForm3.smethod_41(Timer_0);
					GForm3.smethod_42((object)Timer_0);
					num = (int)((num2 * 1957881390) ^ 0x33FFEF94);
					continue;
				case 11u:
					GForm3.smethod_43(GForm3.smethod_35());
					num = (int)(num2 * 172350584) ^ -578513407;
					continue;
				case 10u:
					GForm3.smethod_42((object)bool_0);
					num = ((int)num2 * -1261918868) ^ 0x5F042888;
					continue;
				case 7u:
					flag = !bool_0;
					num = (int)(num2 * 1275903032) ^ -535787767;
					continue;
				case 6u:
					num = ((int)num2 * -712029332) ^ -619380189;
					continue;
				case 5u:
					GForm3.smethod_38();
					num = (int)((num2 * 309130871) ^ 0x5631530D);
					continue;
				case 4u:
					GForm3.smethod_38();
					num = (int)(num2 * 1030745022) ^ -319232490;
					continue;
				case 3u:
					GForm3.smethod_42((object)bool_0);
					num = ((int)num2 * -1925518919) ^ 0x6C4610AB;
					continue;
				case 2u:
					num = -2127485108;
					continue;
				case 1u:
					num = (int)(num2 * 892180880) ^ -657161837;
					continue;
				case 0u:
					num = -1935418282;
					continue;
				default:
					return;
				case 8u:
					break;
				case 9u:
					return;
				}
				break;
			}
		}
	}

	private void method_5(object sender, EventArgs e)
	{
		bool flag8 = default(bool);
		bool flag2 = default(bool);
		bool flag4 = default(bool);
		bool flag6 = default(bool);
		bool flag = default(bool);
		bool flag7 = default(bool);
		bool flag5 = default(bool);
		bool flag3 = default(bool);
		while (true)
		{
			int num = 38629943;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x65ED984Au) % 82u)
				{
				case 81u:
					GForm3.smethod_17(Label_0, "In pochi sanno chi sono, ma lui riuscì a vedere di più:\r\nerano gli imperatori di Omegle.");
					num = (int)(num2 * 1754476880) ^ -326276127;
					continue;
				case 80u:
					num = ((int)num2 * -1774576034) ^ -950756382;
					continue;
				case 79u:
					GForm3.smethod_17(Label_0, "Così egli capii che c'era un solo modo di porre fine\r\nad ogni problema...");
					num = ((int)num2 * -1564991642) ^ -506778398;
					continue;
				case 78u:
					num = (int)(num2 * 1468265577) ^ -1361007668;
					continue;
				case 77u:
					GClass1.smethod_2().method_4();
					num = (int)(num2 * 1051549970) ^ -64668256;
					continue;
				case 76u:
					flag8 = int_0 == 2;
					num = 1329151055;
					continue;
				case 75u:
					GForm3.smethod_17(Label_0, "E il mago pian piano, nel suo tortuoso cammino,\r\nne trovò tanti di tali imperatori.");
					num = (int)(num2 * 610117273) ^ -2136034589;
					continue;
				case 74u:
					GClass1.smethod_2().method_3();
					num = ((int)num2 * -343453202) ^ 0x6BA9201A;
					continue;
				case 73u:
					num = ((int)num2 * -2144686535) ^ 0x2E18C72B;
					continue;
				case 72u:
					num = (int)((num2 * 1884921982) ^ 0x7EA3C5F2);
					continue;
				case 71u:
					flag2 = int_0 == 3;
					num = 1061252715;
					continue;
				case 70u:
					GClass1.smethod_2().method_0();
					num = (int)(num2 * 569135142) ^ -1561022648;
					continue;
				case 69u:
				{
					int num8;
					if (int_0 == 12)
					{
						num = 1105113023;
						num8 = 1105113023;
					}
					else
					{
						num = 1003501204;
						num8 = 1003501204;
					}
					continue;
				}
				case 68u:
					num = ((int)num2 * -1400456854) ^ 0x7F7B3D1E;
					continue;
				case 67u:
				{
					int num24;
					int num25;
					if (!flag4)
					{
						num24 = 1848418988;
						num25 = 1848418988;
					}
					else
					{
						num24 = 252941345;
						num25 = 252941345;
					}
					num = num24 ^ ((int)num2 * -1790354262);
					continue;
				}
				case 66u:
				{
					int num21;
					if (int_0 != 6)
					{
						num = 308322843;
						num21 = 308322843;
					}
					else
					{
						num = 1608772671;
						num21 = 1608772671;
					}
					continue;
				}
				case 65u:
				{
					int num16;
					int num17;
					if (!flag8)
					{
						num16 = 358261357;
						num17 = 358261357;
					}
					else
					{
						num16 = 1790212035;
						num17 = 1790212035;
					}
					num = num16 ^ ((int)num2 * -750730094);
					continue;
				}
				case 64u:
					num = ((int)num2 * -1234832593) ^ 0x2774F4E4;
					continue;
				case 63u:
					num = 1678255413;
					continue;
				case 62u:
				{
					int num12;
					int num13;
					if (!flag6)
					{
						num12 = -249193976;
						num13 = -249193976;
					}
					else
					{
						num12 = -585759524;
						num13 = -585759524;
					}
					num = num12 ^ (int)(num2 * 122141315);
					continue;
				}
				case 61u:
					num = ((int)num2 * -733958015) ^ -1413936989;
					continue;
				case 60u:
					num = (int)((num2 * 1828804147) ^ 0x4E169E6C);
					continue;
				case 59u:
				{
					int num4;
					int num5;
					if (!flag2)
					{
						num4 = -1736122335;
						num5 = -1736122335;
					}
					else
					{
						num4 = -583774956;
						num5 = -583774956;
					}
					num = num4 ^ ((int)num2 * -627800373);
					continue;
				}
				case 58u:
					num = ((int)num2 * -1444849804) ^ 0x3F9B157A;
					continue;
				case 57u:
					num = ((int)num2 * -38990932) ^ 0x581E28D9;
					continue;
				case 56u:
					num = ((int)num2 * -1036658631) ^ -1462172374;
					continue;
				case 55u:
					num = (int)(num2 * 1986877404) ^ -149059578;
					continue;
				case 54u:
				{
					int num26;
					if (int_0 == 13)
					{
						num = 1356331118;
						num26 = 1356331118;
					}
					else
					{
						num = 1155420596;
						num26 = 1155420596;
					}
					continue;
				}
				case 53u:
				{
					int num22;
					int num23;
					if (!flag)
					{
						num22 = -1079062762;
						num23 = -1079062762;
					}
					else
					{
						num22 = -1768911459;
						num23 = -1768911459;
					}
					num = num22 ^ ((int)num2 * -743027261);
					continue;
				}
				case 52u:
					flag6 = int_0 == 5;
					num = 726529068;
					continue;
				case 50u:
					num = (int)((num2 * 965847117) ^ 0xFF2C248);
					continue;
				case 49u:
					num = (int)(num2 * 1225645297) ^ -48940303;
					continue;
				case 48u:
					num = ((int)num2 * -1602245520) ^ -1882894840;
					continue;
				case 47u:
					GForm3.smethod_17(Label_0, "Un mago molto misterioso, dagli oscuri segreti... andò\r\nsu OmeTV, quella sera.");
					num = (int)((num2 * 746925225) ^ 0x1EBFD20C);
					continue;
				case 46u:
					num = (int)((num2 * 580892557) ^ 0x7B1525A0);
					continue;
				case 45u:
					GForm3.smethod_17(Label_0, "Ma non riuscì bene ad orientarsi... c'era tante persone\r\nche gli ostacolavano il cammino...");
					num = (int)((num2 * 1096804965) ^ 0x6A4FB089);
					continue;
				case 44u:
					num = ((int)num2 * -1883453967) ^ 0x411277CC;
					continue;
				case 43u:
					GForm3.smethod_46((Form)(object)this);
					num = (int)(num2 * 339367207) ^ -2086489199;
					continue;
				case 42u:
					GForm3.smethod_13((Control)(object)Label_0, new Point(checked(GForm3.smethod_44((Control)(object)Label_0).X + 60), GForm3.smethod_44((Control)(object)Label_0).Y));
					num = ((int)num2 * -31149025) ^ 0x169377E9;
					continue;
				case 41u:
					num = ((int)num2 * -618253641) ^ -1779740072;
					continue;
				case 40u:
				{
					int num20;
					if (int_0 != 11)
					{
						num = 2047255321;
						num20 = 2047255321;
					}
					else
					{
						num = 108808342;
						num20 = 108808342;
					}
					continue;
				}
				case 39u:
					num = ((int)num2 * -904438486) ^ 0x19B1B06B;
					continue;
				case 38u:
					num = (int)(num2 * 1869043617) ^ -284569206;
					continue;
				case 37u:
					GForm3.smethod_17(Label_0, "Egli poteva fare trucchi di magia con le carte e con i\r\ncubi agli sconosciuti... Bello, no?");
					num = ((int)num2 * -1905264141) ^ 0x5C755AEC;
					continue;
				case 36u:
				{
					int num18;
					int num19;
					if (!flag7)
					{
						num18 = -799542130;
						num19 = -799542130;
					}
					else
					{
						num18 = -164587171;
						num19 = -164587171;
					}
					num = num18 ^ (int)(num2 * 1275011186);
					continue;
				}
				case 35u:
					num = ((int)num2 * -785576440) ^ -1537569886;
					continue;
				case 34u:
					GForm3.smethod_45((Control)(object)Class2.Class3_0.GForm0_0);
					num = (int)((num2 * 1576775972) ^ 0x73B72508);
					continue;
				case 33u:
					GForm3.smethod_17(Label_0, "Il mago e i suoi amici sono sempre pronti ad affrontare\r\nogni nuova sfida ed ogni pericolo.");
					num = ((int)num2 * -463330274) ^ 0x732A64A7;
					continue;
				case 32u:
					num = (int)(num2 * 830758039) ^ -1625733862;
					continue;
				case 31u:
					GForm3.smethod_17(Label_0, "Un mondo pieno di pedofili, maniaci, assassini, pazzi,\r\npersone pluripregiudicate e morti di figa...");
					num = ((int)num2 * -687125103) ^ 0x75CF9B99;
					continue;
				case 30u:
				{
					int num15;
					if (int_0 == 4)
					{
						num = 748469875;
						num15 = 748469875;
					}
					else
					{
						num = 1614816372;
						num15 = 1614816372;
					}
					continue;
				}
				case 29u:
					GForm3.smethod_17(Label_0, "Che il gioco abbia inizio!");
					num = (int)((num2 * 1413629004) ^ 0x70CDAA21);
					continue;
				case 28u:
					num = ((int)num2 * -1692948583) ^ -1521715624;
					continue;
				case 27u:
					flag5 = int_0 == 1;
					num = ((int)num2 * -442126707) ^ -1869396373;
					continue;
				case 26u:
				{
					int num14;
					if (int_0 != 8)
					{
						num = 1707209365;
						num14 = 1707209365;
					}
					else
					{
						num = 701426199;
						num14 = 701426199;
					}
					continue;
				}
				case 25u:
					flag7 = int_0 == 9;
					num = 1036155268;
					continue;
				case 24u:
				{
					int num10;
					int num11;
					if (flag5)
					{
						num10 = 18948487;
						num11 = 18948487;
					}
					else
					{
						num10 = 1557101964;
						num11 = 1557101964;
					}
					num = num10 ^ (int)(num2 * 1065477189);
					continue;
				}
				case 23u:
					checked
					{
						int_0++;
						flag4 = int_1 == 0;
					}
					num = ((int)num2 * -1094271896) ^ 0x29D0A5ED;
					continue;
				case 22u:
					num = (int)((num2 * 861316242) ^ 0x5DEAC4E2);
					continue;
				case 21u:
					num = ((int)num2 * -1875631963) ^ -1798785265;
					continue;
				case 20u:
					flag3 = int_0 == 14;
					num = 909049723;
					continue;
				case 19u:
				{
					int num9;
					if (int_0 != 7)
					{
						num = 388686940;
						num9 = 388686940;
					}
					else
					{
						num = 2130321347;
						num9 = 2130321347;
					}
					continue;
				}
				case 18u:
					GForm3.smethod_17(Label_0, "Insieme a questo mago e ai suoi fantastici amici, \r\npercorrerai tutta la strada di Omegle.");
					num = (int)(num2 * 1907504624) ^ -934222403;
					continue;
				case 17u:
					num = (int)((num2 * 21018722) ^ 0x67FF29C4);
					continue;
				case 16u:
					GForm3.smethod_17(Label_0, "Queste persone trascorrono il loro tempo libero, la loro\r\nintera vita su Omegle, con gli altri.");
					num = (int)(num2 * 1835825259) ^ -192502790;
					continue;
				case 15u:
					GForm3.smethod_17(Label_0, "Non sapeva bene cosa lo attendeva, ma sapeva bene che\r\n era un grande pericolo intrufolarsi là dentro.");
					num = (int)(num2 * 1361689606) ^ -1693121106;
					continue;
				case 14u:
					num = 1286711578;
					continue;
				case 13u:
				{
					int num6;
					int num7;
					if (flag3)
					{
						num6 = -1357977642;
						num7 = -1357977642;
					}
					else
					{
						num6 = -1569603560;
						num7 = -1569603560;
					}
					num = num6 ^ ((int)num2 * -2006160067);
					continue;
				}
				case 11u:
					num = ((int)num2 * -881657550) ^ -832123356;
					continue;
				case 10u:
				{
					int num3;
					if (int_0 != 10)
					{
						num = 366702296;
						num3 = 366702296;
					}
					else
					{
						num = 199283612;
						num3 = 199283612;
					}
					continue;
				}
				case 9u:
					flag = int_0 == 15;
					num = 783369683;
					continue;
				case 8u:
					num = (int)((num2 * 398490410) ^ 0x509E9CE1);
					continue;
				case 7u:
					num = ((int)num2 * -435861749) ^ -485625457;
					continue;
				case 6u:
					GForm3.smethod_17(Label_0, "Sono delle persone che hanno delle grandissime capacità\r\nda disabili, ma non solo.");
					num = ((int)num2 * -1770304165) ^ -1638495858;
					continue;
				case 5u:
					bool_0 = true;
					GClass1.smethod_2().method_3();
					num = ((int)num2 * -1987163314) ^ -787306441;
					continue;
				case 4u:
					GForm3.smethod_17(Label_0, "Ma lui era solo un semplice mago, come poteva riuscire\r\nad affrontare le agonie contenute là dentro?");
					num = (int)((num2 * 869809253) ^ 0x78EC1105);
					continue;
				case 3u:
					GForm3.smethod_17(Label_0, "Purtroppo la noia è una droga molto cancerosa, ed egli\r\nsi mise alla ricerca di nuove avventure.");
					num = ((int)num2 * -1694762948) ^ 0x6D38CC47;
					continue;
				case 2u:
					num = ((int)num2 * -201083045) ^ 0x308405AD;
					continue;
				case 1u:
					num = (int)(num2 * 529258631) ^ -2099381002;
					continue;
				case 0u:
					num = (int)(num2 * 2036165444) ^ -791400122;
					continue;
				default:
					return;
				case 51u:
					break;
				case 12u:
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
