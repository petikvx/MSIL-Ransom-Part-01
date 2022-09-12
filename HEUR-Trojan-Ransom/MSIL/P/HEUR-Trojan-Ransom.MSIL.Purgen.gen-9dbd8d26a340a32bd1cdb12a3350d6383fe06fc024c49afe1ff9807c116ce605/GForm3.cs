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
				int num = 1688850892;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x53A8A73Fu) % 8u)
					{
					case 7u:
						timer_0 = value;
						num = 1484437137;
						continue;
					case 6u:
					{
						val = timer_0;
						int num5;
						int num6;
						if (val != null)
						{
							num5 = 737420331;
							num6 = 737420331;
						}
						else
						{
							num5 = 660594165;
							num6 = 660594165;
						}
						num = num5 ^ (int)(num2 * 1555347677);
						continue;
					}
					case 5u:
					{
						int num3;
						int num4;
						if (val != null)
						{
							num3 = 15854112;
							num4 = 15854112;
						}
						else
						{
							num3 = 1574724486;
							num4 = 1574724486;
						}
						num = num3 ^ (int)(num2 * 1670811830);
						continue;
					}
					case 3u:
						val = timer_0;
						num = ((int)num2 * -548931208) ^ -1962257598;
						continue;
					case 2u:
						GForm3.smethod_34(val, eventHandler_);
						num = ((int)num2 * -1178916633) ^ -1185640339;
						continue;
					case 1u:
						GForm3.smethod_33(val, eventHandler_);
						num = ((int)num2 * -299508198) ^ 0x2F697412;
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
			while (true)
			{
				int num = -185549437;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xAEAA490Bu) % 7u)
					{
					case 6u:
						GForm3.smethod_33(val, eventHandler_);
						num = (int)((num2 * 465998171) ^ 0x74A3D78B);
						continue;
					case 5u:
					{
						val = timer_1;
						int num5;
						int num6;
						if (val == null)
						{
							num5 = -1965921287;
							num6 = -1965921287;
						}
						else
						{
							num5 = -1903788711;
							num6 = -1903788711;
						}
						num = num5 ^ (int)(num2 * 1065862222);
						continue;
					}
					case 3u:
					{
						int num3;
						int num4;
						if (val == null)
						{
							num3 = -814198238;
							num4 = -814198238;
						}
						else
						{
							num3 = -1749217104;
							num4 = -1749217104;
						}
						num = num3 ^ ((int)num2 * -622480271);
						continue;
					}
					case 1u:
						timer_1 = value;
						num = -658210426;
						continue;
					case 0u:
						GForm3.smethod_34(val, eventHandler_);
						num = (int)((num2 * 1294555883) ^ 0x54391983);
						continue;
					default:
						return;
					case 4u:
						break;
					case 2u:
						return;
					}
					break;
				}
			}
		}
	}

	public GForm3()
	{
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Expected O, but got Unknown
		while (true)
		{
			int num = 678934189;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7903532Eu) % 8u)
				{
				case 7u:
					bool_0 = false;
					num = ((int)num2 * -2002087435) ^ -1969054023;
					continue;
				case 4u:
					int_0 = 0;
					num = (int)(num2 * 491873775) ^ -362575984;
					continue;
				case 3u:
					GForm3.smethod_0((Form)(object)this, (EventHandler)method_1);
					num = ((int)num2 * -1558821659) ^ 0x4572EBB8;
					continue;
				case 2u:
					int_1 = 0;
					num = ((int)num2 * -2055658614) ^ -1644874366;
					continue;
				case 1u:
					GForm3.smethod_1((Form)(object)this, new FormClosingEventHandler(method_3));
					num = (int)(num2 * 744186197) ^ -154764428;
					continue;
				case 0u:
					method_0();
					num = ((int)num2 * -706920539) ^ -1331286989;
					continue;
				default:
					return;
				case 6u:
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
				int num = 1043278958;
				while (true)
				{
					uint num2;
					int num3;
					switch ((num2 = (uint)num ^ 0x3F070439u) % 7u)
					{
					case 6u:
						if (disposing)
						{
							num = (int)(num2 * 1373392940) ^ -858234207;
							continue;
						}
						goto IL_001c;
					case 5u:
						num = (int)((num2 * 1242624014) ^ 0x437E2AA0);
						continue;
					case 2u:
						num = ((int)num2 * -1988297733) ^ 0x16860AD4;
						continue;
					case 1u:
						GForm3.smethod_2((IDisposable)icontainer_0);
						num = ((int)num2 * -1387459941) ^ -1135127387;
						continue;
					case 0u:
						if (icontainer_0 != null)
						{
							num = 67047846;
							num3 = 67047846;
							continue;
						}
						goto IL_001c;
					default:
						return;
					case 4u:
						break;
					case 3u:
						return;
						IL_001c:
						num = 1368304969;
						num3 = 1368304969;
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
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			int num = 1903177954;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6DCCDC13u) % 40u)
				{
				case 39u:
					GForm3.smethod_28((Control)(object)this, "StoryMode");
					num = (int)((num2 * 1041553635) ^ 0x31F16FDA);
					continue;
				case 38u:
					GForm3.smethod_17(Label_0, "Tutto ebbe inizio in un freddo giorno d'inverno...");
					GForm3.smethod_7(Timer_1, 6000);
					num = ((int)num2 * -44768257) ^ -1622027779;
					continue;
				case 37u:
					num = ((int)num2 * -1267178757) ^ -2126736445;
					continue;
				case 36u:
					GForm3.smethod_13((Control)(object)Label_0, new Point(111, 270));
					num = (int)(num2 * 230343634) ^ -330140251;
					continue;
				case 34u:
					num = ((int)num2 * -988929694) ^ 0x33AAEF89;
					continue;
				case 33u:
					icontainer_0 = GForm3.smethod_3();
					Timer_0 = GForm3.smethod_4(icontainer_0);
					num = (int)((num2 * 553427048) ^ 0x4ABF1522);
					continue;
				case 32u:
					Timer_1 = GForm3.smethod_4(icontainer_0);
					num = (int)((num2 * 1273311815) ^ 0x3A6F0584);
					continue;
				case 31u:
					GForm3.smethod_25((Form)(object)this, (FormBorderStyle)1);
					GForm3.smethod_26((Form)(object)this, new Padding(4));
					GForm3.smethod_27((Form)(object)this, bool_1: false);
					num = (int)(num2 * 1726871464) ^ -929218924;
					continue;
				case 30u:
					GForm3.smethod_6((Control)(object)this);
					num = ((int)num2 * -1177929496) ^ 0x3744FB1E;
					continue;
				case 29u:
					num = (int)((num2 * 1346833416) ^ 0x3CA941C4);
					continue;
				case 28u:
					GForm3.smethod_18((ContainerControl)(object)this, new SizeF(10f, 22f));
					num = (int)(num2 * 1002963084) ^ -1549317199;
					continue;
				case 27u:
					GForm3.smethod_14((Control)(object)Label_0, "Label1");
					num = ((int)num2 * -1381681029) ^ 0x319F630;
					continue;
				case 26u:
					num = (int)(num2 * 1983338569) ^ -1012681416;
					continue;
				case 25u:
					GForm3.smethod_11((Control)(object)Label_0, GForm3.smethod_10("Microsoft Sans Serif", 24f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
					GForm3.smethod_12((Control)(object)Label_0, Color.White);
					num = (int)((num2 * 1214900715) ^ 0x32D73604);
					continue;
				case 23u:
					num = ((int)num2 * -540041800) ^ 0x38F2722D;
					continue;
				case 22u:
					GForm3.smethod_31((Control)(object)this, bool_1: false);
					num = ((int)num2 * -1875277687) ^ -685080737;
					continue;
				case 21u:
					GForm3.smethod_9((Control)(object)Label_0, Color.Transparent);
					num = (int)((num2 * 1716785371) ^ 0x25A98EED);
					continue;
				case 20u:
					GForm3.smethod_24(GForm3.smethod_23((Control)(object)this), (Control)(object)Label_0);
					num = ((int)num2 * -416215199) ^ -370971428;
					continue;
				case 19u:
					num = ((int)num2 * -1816416518) ^ 0x2251FFB5;
					continue;
				case 18u:
					GForm3.smethod_7(Timer_0, 1000);
					GForm3.smethod_8(Label_0, bool_1: true);
					num = ((int)num2 * -2124048985) ^ -1906624576;
					continue;
				case 17u:
					GForm3.smethod_15((Control)(object)Label_0, new Size(862, 46));
					num = (int)(num2 * 1867476907) ^ -117700795;
					continue;
				case 16u:
					num = (int)((num2 * 290014195) ^ 0x648ECE05);
					continue;
				case 15u:
					GForm3.smethod_16((Control)(object)Label_0, 0);
					num = ((int)num2 * -1206630855) ^ 0x5506B956;
					continue;
				case 14u:
					GForm3.smethod_29((Form)(object)this, (FormStartPosition)1);
					num = ((int)num2 * -679048716) ^ -1549444394;
					continue;
				case 13u:
					num = ((int)num2 * -524014205) ^ -1923061770;
					continue;
				case 12u:
					num = ((int)num2 * -952708273) ^ 0x51C2AE69;
					continue;
				case 11u:
					GForm3.smethod_11((Control)(object)this, GForm3.smethod_10("Consolas", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 569633796) ^ -924659408;
					continue;
				case 10u:
					num = ((int)num2 * -1813287743) ^ -829672820;
					continue;
				case 9u:
					GForm3.smethod_21((Control)(object)this, (ImageLayout)3);
					GForm3.smethod_22((Form)(object)this, new Size(1025, 638));
					num = (int)((num2 * 980740442) ^ 0x7AD0D39A);
					continue;
				case 8u:
					Label_0 = GForm3.smethod_5();
					num = ((int)num2 * -1524283742) ^ 0x7C57B06B;
					continue;
				case 7u:
					GForm3.smethod_30((Form)(object)this, "The Omegle Game");
					num = ((int)num2 * -1824605971) ^ 0x41FA4518;
					continue;
				case 6u:
					num = ((int)num2 * -1467390998) ^ -327872724;
					continue;
				case 5u:
					GForm3.smethod_19((ContainerControl)(object)this, (AutoScaleMode)1);
					GForm3.smethod_20((Form)(object)this, Color.White);
					num = ((int)num2 * -2127297218) ^ 0x73258F84;
					continue;
				case 4u:
					GForm3.smethod_32((Control)(object)this);
					num = ((int)num2 * -1862145803) ^ -1649020916;
					continue;
				case 3u:
					num = ((int)num2 * -1957209088) ^ -863735921;
					continue;
				case 2u:
					num = ((int)num2 * -1132522273) ^ 0x145A4DD9;
					continue;
				case 1u:
					num = ((int)num2 * -248869933) ^ 0x206EF7B8;
					continue;
				case 0u:
					((Control)this).set_DoubleBuffered(true);
					num = (int)((num2 * 1519817644) ^ 0x66A74290);
					continue;
				default:
					return;
				case 24u:
					break;
				case 35u:
					return;
				}
				break;
			}
		}
	}

	private void method_1(object sender, EventArgs e)
	{
		GForm3.smethod_36(GForm3.smethod_35(), ProcessPriorityClass.RealTime);
		bool flag = default(bool);
		while (true)
		{
			int num = 1239473050;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x55EEFD5Du) % 12u)
				{
				case 11u:
					num = 1598177489;
					continue;
				case 10u:
					num = (int)((num2 * 899512408) ^ 0x539D7E64);
					continue;
				case 9u:
					GClass1.smethod_2().method_0();
					num = ((int)num2 * -93354854) ^ 0x358C076A;
					continue;
				case 8u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = 900701242;
						num4 = 900701242;
					}
					else
					{
						num3 = 56181895;
						num4 = 56181895;
					}
					num = num3 ^ ((int)num2 * -550149084);
					continue;
				}
				case 7u:
					GForm3.smethod_37(Timer_1);
					num = (int)(num2 * 1577552762) ^ -50863891;
					continue;
				case 6u:
					num = (int)(num2 * 1237099144) ^ -674571642;
					continue;
				case 3u:
					GForm3.smethod_37(Timer_0);
					num = ((int)num2 * -2030819215) ^ -1826978484;
					continue;
				case 2u:
					GForm3.smethod_17(Label_0, "Tutto ebbe inizio in un freddo giorno d'inverno...");
					num = ((int)num2 * -1050084686) ^ -1465375439;
					continue;
				case 1u:
					flag = int_1 == 0;
					num = (int)((num2 * 641336632) ^ 0x3FFDC4B1);
					continue;
				case 0u:
					num = (int)(num2 * 2121523022) ^ -245592774;
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

	private void method_2(object sender, EventArgs e)
	{
		GForm3.smethod_38();
	}

	private void method_3(object sender, FormClosingEventArgs e)
	{
		bool flag = default(bool);
		while (true)
		{
			int num = -523156031;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xDFDD078Bu) % 8u)
				{
				case 7u:
					flag = !bool_0;
					num = (int)((num2 * 1716762163) ^ 0x478BF50A);
					continue;
				case 6u:
					GForm3.smethod_39((CancelEventArgs)(object)e, bool_1: true);
					num = ((int)num2 * -1250809625) ^ 0x4134DEDC;
					continue;
				case 5u:
					num = ((int)num2 * -335239491) ^ -1517699662;
					continue;
				case 4u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = -1228217573;
						num4 = -1228217573;
					}
					else
					{
						num3 = -1565263571;
						num4 = -1565263571;
					}
					num = num3 ^ (int)(num2 * 1417336180);
					continue;
				}
				case 2u:
					method_4();
					num = ((int)num2 * -1534807257) ^ 0x32102EA2;
					continue;
				case 0u:
					num = -182273598;
					continue;
				default:
					return;
				case 3u:
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
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Invalid comparison between Unknown and I4
		bool flag = default(bool);
		while (true)
		{
			int num = 1655381698;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7FD8649Cu) % 20u)
				{
				case 19u:
					num = 394276972;
					continue;
				case 18u:
					GForm3.smethod_42((object)Timer_0);
					GForm3.smethod_42((object)bool_0);
					GForm3.smethod_38();
					num = ((int)num2 * -1472550359) ^ 0x57E7C108;
					continue;
				case 17u:
					num = ((int)num2 * -1963483730) ^ 0x57D554E2;
					continue;
				case 16u:
					num = (int)((num2 * 2094165941) ^ 0x54F37655);
					continue;
				case 15u:
					num = (int)((num2 * 1819876635) ^ 0x4C1A84EB);
					continue;
				case 14u:
					GForm3.smethod_41(Timer_0);
					num = (int)((num2 * 607432693) ^ 0x2C5777F1);
					continue;
				case 13u:
					num = (int)(num2 * 121780040) ^ -1159090796;
					continue;
				case 11u:
					num = (int)((num2 * 1991891129) ^ 0x7985C872);
					continue;
				case 10u:
					flag = !bool_0;
					num = ((int)num2 * -2104892371) ^ 0x52DCEF14;
					continue;
				case 9u:
					num = (int)(num2 * 1597000446) ^ -1039703334;
					continue;
				case 8u:
					GForm3.smethod_42((object)Timer_0);
					num = ((int)num2 * -1165617122) ^ -256399349;
					continue;
				case 7u:
					GForm3.smethod_42((object)bool_0);
					GForm3.smethod_38();
					num = ((int)num2 * -594277511) ^ -1315512352;
					continue;
				case 6u:
				{
					int num5;
					int num6;
					if (flag)
					{
						num5 = -1928250361;
						num6 = -1928250361;
					}
					else
					{
						num5 = -472252550;
						num6 = -472252550;
					}
					num = num5 ^ (int)(num2 * 1812514851);
					continue;
				}
				case 5u:
				{
					int num3;
					int num4;
					if ((int)GForm3.smethod_40("Sei sicuro di voler uscire dal gioco?", "The Omegle Game", (MessageBoxButtons)4, (MessageBoxIcon)32) == 6)
					{
						num3 = 1075387681;
						num4 = 1075387681;
					}
					else
					{
						num3 = 258332048;
						num4 = 258332048;
					}
					num = num3 ^ ((int)num2 * -1992023709);
					continue;
				}
				case 4u:
					GForm3.smethod_41(Timer_0);
					num = 977175173;
					continue;
				case 3u:
					num = (int)((num2 * 210167859) ^ 0x73ADDFCA);
					continue;
				case 2u:
					GForm3.smethod_43(GForm3.smethod_35());
					num = ((int)num2 * -1524225742) ^ -85296599;
					continue;
				case 1u:
					num = ((int)num2 * -1488807968) ^ 0x56FF66C3;
					continue;
				default:
					return;
				case 0u:
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
		bool flag6 = default(bool);
		bool flag7 = default(bool);
		bool flag3 = default(bool);
		bool flag = default(bool);
		bool flag2 = default(bool);
		bool flag4 = default(bool);
		bool flag5 = default(bool);
		while (true)
		{
			int num = -157536092;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB855CEECu) % 78u)
				{
				case 77u:
					num = ((int)num2 * -1439144152) ^ -609601477;
					continue;
				case 76u:
					bool_0 = true;
					num = ((int)num2 * -438636248) ^ -674223856;
					continue;
				case 75u:
					num = ((int)num2 * -948559436) ^ -2020041006;
					continue;
				case 74u:
					GForm3.smethod_17(Label_0, "Insieme a questo mago e ai suoi fantastici amici, \r\npercorrerai tutta la strada di Omegle.");
					num = (int)((num2 * 318296795) ^ 0x4A5259CA);
					continue;
				case 73u:
				{
					int num19;
					int num20;
					if (flag6)
					{
						num19 = -1682538544;
						num20 = -1682538544;
					}
					else
					{
						num19 = -93284909;
						num20 = -93284909;
					}
					num = num19 ^ ((int)num2 * -1728668962);
					continue;
				}
				case 72u:
				{
					int num14;
					if (int_0 == 13)
					{
						num = -801894328;
						num14 = -801894328;
					}
					else
					{
						num = -1323277916;
						num14 = -1323277916;
					}
					continue;
				}
				case 71u:
					GForm3.smethod_17(Label_0, "Ma non riuscì bene ad orientarsi... c'era tante persone\r\nche gli ostacolavano il cammino...");
					num = (int)((num2 * 537886175) ^ 0x6B82ADB);
					continue;
				case 70u:
				{
					int num9;
					if (int_0 != 14)
					{
						num = -1052612736;
						num9 = -1052612736;
					}
					else
					{
						num = -1381147651;
						num9 = -1381147651;
					}
					continue;
				}
				case 69u:
					GForm3.smethod_17(Label_0, "Il mago e i suoi amici sono sempre pronti ad affrontare\r\nogni nuova sfida ed ogni pericolo.");
					num = (int)(num2 * 503833400) ^ -1982434067;
					continue;
				case 68u:
					num = (int)(num2 * 1928808811) ^ -1104806071;
					continue;
				case 67u:
					flag6 = int_0 == 6;
					num = -1198056827;
					continue;
				case 66u:
					GForm3.smethod_17(Label_0, "Che il gioco abbia inizio!");
					num = (int)(num2 * 1615193837) ^ -1878437454;
					continue;
				case 65u:
					flag7 = int_0 == 11;
					num = -1845534547;
					continue;
				case 64u:
					flag3 = int_0 == 15;
					num = -1254391481;
					continue;
				case 63u:
				{
					int num21;
					int num22;
					if (!flag7)
					{
						num21 = -99654427;
						num22 = -99654427;
					}
					else
					{
						num21 = -503744897;
						num22 = -503744897;
					}
					num = num21 ^ ((int)num2 * -1843843397);
					continue;
				}
				case 62u:
					checked
					{
						int_0++;
					}
					num = (int)((num2 * 442058279) ^ 0x6F77BC71);
					continue;
				case 61u:
					num = (int)((num2 * 1461915618) ^ 0x64972C9B);
					continue;
				case 59u:
					num = -47731222;
					continue;
				case 58u:
				{
					int num12;
					if (int_0 != 12)
					{
						num = -40792982;
						num12 = -40792982;
					}
					else
					{
						num = -883097109;
						num12 = -883097109;
					}
					continue;
				}
				case 57u:
					num = -1518743830;
					continue;
				case 56u:
					num = ((int)num2 * -1026597452) ^ 0x186D5AF3;
					continue;
				case 55u:
				{
					int num6;
					int num7;
					if (flag3)
					{
						num6 = -649347083;
						num7 = -649347083;
					}
					else
					{
						num6 = -1413767166;
						num7 = -1413767166;
					}
					num = num6 ^ ((int)num2 * -19531727);
					continue;
				}
				case 54u:
					GClass1.smethod_2().method_3();
					num = ((int)num2 * -1136882366) ^ 0x669C0124;
					continue;
				case 53u:
					GForm3.smethod_45((Control)(object)Class2.Class3_0.GForm0_0);
					num = ((int)num2 * -95568507) ^ 0x26E4F5D3;
					continue;
				case 52u:
					GForm3.smethod_17(Label_0, "Queste persone trascorrono il loro tempo libero, la loro\r\nintera vita su Omegle, con gli altri.");
					num = ((int)num2 * -526675357) ^ -436322121;
					continue;
				case 51u:
					num = (int)(num2 * 573792623) ^ -1014776551;
					continue;
				case 50u:
					num = (int)(num2 * 957891629) ^ -1709857885;
					continue;
				case 49u:
					flag = int_1 == 0;
					num = ((int)num2 * -1443770916) ^ -1766563734;
					continue;
				case 48u:
				{
					int num26;
					if (int_0 != 10)
					{
						num = -1616918465;
						num26 = -1616918465;
					}
					else
					{
						num = -973140411;
						num26 = -973140411;
					}
					continue;
				}
				case 47u:
					num = (int)(num2 * 253531886) ^ -72759155;
					continue;
				case 46u:
				{
					int num24;
					int num25;
					if (flag2)
					{
						num24 = -798762777;
						num25 = -798762777;
					}
					else
					{
						num24 = -96401390;
						num25 = -96401390;
					}
					num = num24 ^ (int)(num2 * 1829896641);
					continue;
				}
				case 45u:
					num = (int)(num2 * 51425073) ^ -1894784446;
					continue;
				case 44u:
				{
					int num23;
					if (int_0 != 4)
					{
						num = -590941511;
						num23 = -590941511;
					}
					else
					{
						num = -379497059;
						num23 = -379497059;
					}
					continue;
				}
				case 43u:
					GForm3.smethod_17(Label_0, "Ma lui era solo un semplice mago, come poteva riuscire\r\nad affrontare le agonie contenute là dentro?");
					num = ((int)num2 * -2144171121) ^ -180893296;
					continue;
				case 42u:
					flag4 = int_0 == 9;
					num = -891088915;
					continue;
				case 41u:
					GClass1.smethod_2().method_0();
					num = (int)((num2 * 670042074) ^ 0xC0FB341);
					continue;
				case 40u:
					GClass1.smethod_2().method_3();
					num = (int)(num2 * 1146969286) ^ -436369533;
					continue;
				case 39u:
					num = ((int)num2 * -2068155235) ^ -735392584;
					continue;
				case 38u:
				{
					int num17;
					int num18;
					if (!flag5)
					{
						num17 = 1885109857;
						num18 = 1885109857;
					}
					else
					{
						num17 = 861358055;
						num18 = 861358055;
					}
					num = num17 ^ ((int)num2 * -840819491);
					continue;
				}
				case 37u:
				{
					int num15;
					int num16;
					if (int_0 != 1)
					{
						num15 = 844702670;
						num16 = 844702670;
					}
					else
					{
						num15 = 1437781227;
						num16 = 1437781227;
					}
					num = num15 ^ (int)(num2 * 1524972950);
					continue;
				}
				case 36u:
					GForm3.smethod_17(Label_0, "Egli poteva fare trucchi di magia con le carte e con i\r\ncubi agli sconosciuti... Bello, no?");
					num = (int)((num2 * 422172763) ^ 0x4CCC95C5);
					continue;
				case 35u:
					flag5 = int_0 == 5;
					num = -887161742;
					continue;
				case 34u:
					num = ((int)num2 * -1302148841) ^ -1537577608;
					continue;
				case 33u:
					num = (int)(num2 * 1973988957) ^ -1768068521;
					continue;
				case 32u:
					GForm3.smethod_46((Form)(object)this);
					num = ((int)num2 * -995729312) ^ -1657564683;
					continue;
				case 31u:
				{
					int num13;
					if (int_0 == 3)
					{
						num = -1911419104;
						num13 = -1911419104;
					}
					else
					{
						num = -128641364;
						num13 = -128641364;
					}
					continue;
				}
				case 30u:
					num = ((int)num2 * -1406395213) ^ 0x21B64963;
					continue;
				case 29u:
					GForm3.smethod_17(Label_0, "Un mondo pieno di pedofili, maniaci, assassini, pazzi,\r\npersone pluripregiudicate e morti di figa...");
					num = (int)(num2 * 233206179) ^ -381007489;
					continue;
				case 28u:
					num = ((int)num2 * -454018898) ^ -1521430665;
					continue;
				case 27u:
					num = ((int)num2 * -862192366) ^ -281683683;
					continue;
				case 26u:
					num = (int)(num2 * 1227522448) ^ -240936323;
					continue;
				case 25u:
					num = (int)((num2 * 1744167826) ^ 0x22C88D49);
					continue;
				case 24u:
					GForm3.smethod_17(Label_0, "Non sapeva bene cosa lo attendeva, ma sapeva bene che\r\n era un grande pericolo intrufolarsi là dentro.");
					num = ((int)num2 * -1307368829) ^ 0x645BB679;
					continue;
				case 23u:
					GForm3.smethod_17(Label_0, "Sono delle persone che hanno delle grandissime capacità\r\nda disabili, ma non solo.");
					num = (int)(num2 * 786034913) ^ -1856199174;
					continue;
				case 22u:
					num = (int)(num2 * 505900153) ^ -1277754140;
					continue;
				case 21u:
					num = (int)((num2 * 935568913) ^ 0x7007AA);
					continue;
				case 20u:
					GForm3.smethod_13((Control)(object)Label_0, new Point(checked(GForm3.smethod_44((Control)(object)Label_0).X + 60), GForm3.smethod_44((Control)(object)Label_0).Y));
					num = ((int)num2 * -1330602710) ^ 0x48A22DC0;
					continue;
				case 19u:
				{
					int num10;
					int num11;
					if (!flag4)
					{
						num10 = 1683861322;
						num11 = 1683861322;
					}
					else
					{
						num10 = 1116477241;
						num11 = 1116477241;
					}
					num = num10 ^ ((int)num2 * -1333636172);
					continue;
				}
				case 18u:
					GClass1.smethod_2().method_4();
					num = (int)((num2 * 1667001399) ^ 0x7D294503);
					continue;
				case 17u:
					num = ((int)num2 * -1329416720) ^ 0x498EC08F;
					continue;
				case 16u:
					GForm3.smethod_17(Label_0, "Così egli capii che c'era un solo modo di porre fine\r\nad ogni problema...");
					num = ((int)num2 * -1638587982) ^ -1186729869;
					continue;
				case 15u:
					GForm3.smethod_17(Label_0, "In pochi sanno chi sono, ma lui riuscì a vedere di più:\r\nerano gli imperatori di Omegle.");
					num = ((int)num2 * -373249919) ^ 0x31103D2A;
					continue;
				case 14u:
					num = ((int)num2 * -1249628012) ^ 0x69D9D082;
					continue;
				case 13u:
					num = (int)(num2 * 1264135144) ^ -635270645;
					continue;
				case 12u:
				{
					int num8;
					if (int_0 == 2)
					{
						num = -1393152963;
						num8 = -1393152963;
					}
					else
					{
						num = -1480775759;
						num8 = -1480775759;
					}
					continue;
				}
				case 11u:
				{
					int num5;
					if (int_0 != 7)
					{
						num = -309541818;
						num5 = -309541818;
					}
					else
					{
						num = -741318402;
						num5 = -741318402;
					}
					continue;
				}
				case 9u:
					GForm3.smethod_17(Label_0, "Purtroppo la noia è una droga molto cancerosa, ed egli\r\nsi mise alla ricerca di nuove avventure.");
					num = ((int)num2 * -545001089) ^ 0x75E8DDC1;
					continue;
				case 8u:
					flag2 = int_0 == 8;
					num = -1716996130;
					continue;
				case 7u:
					GForm3.smethod_17(Label_0, "E il mago pian piano, nel suo tortuoso cammino,\r\nne trovò tanti di tali imperatori.");
					num = ((int)num2 * -272146728) ^ 0x7DDBAEB4;
					continue;
				case 6u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = -1247426126;
						num4 = -1247426126;
					}
					else
					{
						num3 = -1954312053;
						num4 = -1954312053;
					}
					num = num3 ^ (int)(num2 * 1198368188);
					continue;
				}
				case 5u:
					GForm3.smethod_17(Label_0, "Un mago molto misterioso, dagli oscuri segreti... andò\r\nsu OmeTV, quella sera.");
					num = (int)((num2 * 341823394) ^ 0x6482F7E3);
					continue;
				case 4u:
					num = ((int)num2 * -639269446) ^ 0x72B0B107;
					continue;
				case 3u:
					num = (int)((num2 * 2106443483) ^ 0x15C7DD42);
					continue;
				case 2u:
					num = ((int)num2 * -1536694418) ^ -1934962305;
					continue;
				case 1u:
					num = (int)(num2 * 116038790) ^ -238754667;
					continue;
				case 0u:
					num = ((int)num2 * -979965441) ^ 0x69CA3082;
					continue;
				default:
					return;
				case 10u:
					break;
				case 60u:
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
