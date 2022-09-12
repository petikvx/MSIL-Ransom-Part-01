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
			Timer val = timer_0;
			while (true)
			{
				int num = -1150473930;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x861833F1u) % 6u)
					{
					case 5u:
						GForm3.smethod_33(val, eventHandler_);
						num = ((int)num2 * -945238495) ^ 0x1688892D;
						continue;
					case 3u:
					{
						timer_0 = value;
						val = timer_0;
						int num5;
						if (val == null)
						{
							num = -1849553351;
							num5 = -1849553351;
						}
						else
						{
							num = -1617493097;
							num5 = -1617493097;
						}
						continue;
					}
					case 1u:
					{
						int num3;
						int num4;
						if (val != null)
						{
							num3 = -304816891;
							num4 = -304816891;
						}
						else
						{
							num3 = -1240010247;
							num4 = -1240010247;
						}
						num = num3 ^ (int)(num2 * 1668874397);
						continue;
					}
					case 0u:
						GForm3.smethod_34(val, eventHandler_);
						num = (int)((num2 * 280532795) ^ 0x131E5FBB);
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
				int num = -1058170162;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x8BF1154Eu) % 7u)
					{
					case 5u:
						val = timer_1;
						num = (int)((num2 * 255941764) ^ 0x7AEB5C1);
						continue;
					case 4u:
						GForm3.smethod_34(val, eventHandler_);
						num = ((int)num2 * -2137198324) ^ -69058918;
						continue;
					case 3u:
					{
						timer_1 = value;
						val = timer_1;
						int num5;
						if (val == null)
						{
							num = -311100630;
							num5 = -311100630;
						}
						else
						{
							num = -1584169622;
							num5 = -1584169622;
						}
						continue;
					}
					case 2u:
					{
						int num3;
						int num4;
						if (val == null)
						{
							num3 = 762587058;
							num4 = 762587058;
						}
						else
						{
							num3 = 413688573;
							num4 = 413688573;
						}
						num = num3 ^ ((int)num2 * -979682208);
						continue;
					}
					case 1u:
						GForm3.smethod_33(val, eventHandler_);
						num = (int)((num2 * 1766756739) ^ 0x6C26A8AB);
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

	public GForm3()
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected O, but got Unknown
		GForm3.smethod_0((Form)(object)this, (EventHandler)method_1);
		GForm3.smethod_1((Form)(object)this, new FormClosingEventHandler(method_3));
		bool_0 = false;
		int_0 = 0;
		int_1 = 0;
		method_0();
	}

	[DebuggerNonUserCode]
	void Form.Dispose(bool disposing)
	{
		try
		{
			if (!disposing)
			{
				goto IL_000a;
			}
			goto IL_0047;
			IL_0047:
			int num = -1126944303;
			goto IL_004c;
			IL_004c:
			int num3;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB4F6F94Cu) % 6u)
				{
				case 5u:
					GForm3.smethod_2((IDisposable)icontainer_0);
					num = (int)((num2 * 1519608742) ^ 0x2E6FD962);
					continue;
				case 2u:
					num = ((int)num2 * -56989559) ^ 0x2C2C3E1F;
					continue;
				case 1u:
					num = -1927294710;
					continue;
				case 0u:
					break;
				default:
					return;
				case 3u:
					goto IL_0075;
				case 4u:
					return;
				}
				break;
				IL_0075:
				if (icontainer_0 != null)
				{
					num = -1465279511;
					num3 = -1465279511;
					continue;
				}
				goto IL_000a;
			}
			goto IL_0047;
			IL_000a:
			num = -889568689;
			num3 = -889568689;
			goto IL_004c;
		}
		finally
		{
			while (true)
			{
				IL_00dc:
				int num4 = -2017678142;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num4 ^ 0xB4F6F94Cu) % 4u)
					{
					case 2u:
						((Form)this).Dispose(disposing);
						num4 = ((int)num2 * -630645583) ^ 0x4294249F;
						continue;
					case 1u:
						num4 = (int)((num2 * 1965574067) ^ 0x47841EAB);
						continue;
					default:
						goto end_IL_00bb;
					case 3u:
						break;
					case 0u:
						goto end_IL_00bb;
					}
					goto IL_00dc;
					continue;
					end_IL_00bb:
					break;
				}
				break;
			}
		}
	}

	[DebuggerStepThrough]
	private void method_0()
	{
		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			int num = -1279771964;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF2DE4AD8u) % 37u)
				{
				case 36u:
					GForm3.smethod_11((Control)(object)this, GForm3.smethod_10("Consolas", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1802980629) ^ 0xA7D4A5B;
					continue;
				case 35u:
					num = ((int)num2 * -817096720) ^ 0x6389CF3B;
					continue;
				case 34u:
					GForm3.smethod_27((Form)(object)this, bool_1: false);
					num = ((int)num2 * -606054835) ^ 0x67CD9690;
					continue;
				case 33u:
					num = (int)(num2 * 1606750096) ^ -1536089991;
					continue;
				case 32u:
					GForm3.smethod_28((Control)(object)this, "StoryMode");
					num = (int)(num2 * 1293655508) ^ -58487090;
					continue;
				case 31u:
					GForm3.smethod_31((Control)(object)this, bool_1: false);
					num = (int)(num2 * 1359796929) ^ -2142176311;
					continue;
				case 30u:
					((Control)this).set_DoubleBuffered(true);
					num = ((int)num2 * -1343190035) ^ -1158514145;
					continue;
				case 29u:
					GForm3.smethod_30((Form)(object)this, "The Omegle Game");
					num = (int)((num2 * 2071287934) ^ 0xC97F6EF);
					continue;
				case 28u:
					GForm3.smethod_12((Control)(object)Label_0, Color.White);
					num = (int)(num2 * 127162087) ^ -111349239;
					continue;
				case 27u:
					GForm3.smethod_7(Timer_0, 1000);
					num = ((int)num2 * -513360708) ^ 0x24A29344;
					continue;
				case 26u:
					GForm3.smethod_8(Label_0, bool_1: true);
					num = (int)(num2 * 685792206) ^ -2097527106;
					continue;
				case 25u:
					GForm3.smethod_15((Control)(object)Label_0, new Size(862, 46));
					num = (int)((num2 * 16348960) ^ 0x63873AE7);
					continue;
				case 24u:
					num = (int)(num2 * 1837066674) ^ -1785658090;
					continue;
				case 23u:
					num = (int)((num2 * 1955450486) ^ 0x2E51F59C);
					continue;
				case 22u:
					num = ((int)num2 * -594312894) ^ -1599559107;
					continue;
				case 21u:
					GForm3.smethod_6((Control)(object)this);
					num = (int)(num2 * 1880079252) ^ -2086125089;
					continue;
				case 19u:
					GForm3.smethod_24(GForm3.smethod_23((Control)(object)this), (Control)(object)Label_0);
					num = (int)((num2 * 265076794) ^ 0x4B94876F);
					continue;
				case 18u:
					GForm3.smethod_26((Form)(object)this, new Padding(4));
					num = (int)(num2 * 1601515538) ^ -1559984764;
					continue;
				case 17u:
					num = (int)(num2 * 153062879) ^ -752380832;
					continue;
				case 16u:
					GForm3.smethod_21((Control)(object)this, (ImageLayout)3);
					GForm3.smethod_22((Form)(object)this, new Size(1025, 638));
					num = ((int)num2 * -1635171719) ^ -1116141154;
					continue;
				case 15u:
					num = ((int)num2 * -120398229) ^ -269253378;
					continue;
				case 14u:
					GForm3.smethod_29((Form)(object)this, (FormStartPosition)1);
					num = ((int)num2 * -1265682601) ^ 0x56D9621D;
					continue;
				case 13u:
					GForm3.smethod_14((Control)(object)Label_0, "Label1");
					num = (int)(num2 * 2056822536) ^ -1127338328;
					continue;
				case 12u:
					num = (int)(num2 * 776353426) ^ -1668813240;
					continue;
				case 11u:
					num = ((int)num2 * -822227960) ^ -744319940;
					continue;
				case 10u:
					Timer_1 = GForm3.smethod_4(icontainer_0);
					num = ((int)num2 * -1235873520) ^ -596897520;
					continue;
				case 9u:
					GForm3.smethod_13((Control)(object)Label_0, new Point(111, 270));
					num = (int)(num2 * 1865807543) ^ -1374883127;
					continue;
				case 8u:
					GForm3.smethod_19((ContainerControl)(object)this, (AutoScaleMode)1);
					num = ((int)num2 * -66364993) ^ 0x3B896A62;
					continue;
				case 7u:
					GForm3.smethod_9((Control)(object)Label_0, Color.Transparent);
					num = (int)(num2 * 451257149) ^ -180482404;
					continue;
				case 6u:
					GForm3.smethod_20((Form)(object)this, Color.White);
					num = (int)(num2 * 1355994803) ^ -351086064;
					continue;
				case 5u:
					GForm3.smethod_32((Control)(object)this);
					num = ((int)num2 * -640129466) ^ -772847458;
					continue;
				case 4u:
					GForm3.smethod_25((Form)(object)this, (FormBorderStyle)1);
					num = ((int)num2 * -1520602334) ^ 0x781D5298;
					continue;
				case 3u:
					GForm3.smethod_16((Control)(object)Label_0, 0);
					GForm3.smethod_17(Label_0, "Tutto ebbe inizio in un freddo giorno d'inverno...");
					GForm3.smethod_7(Timer_1, 6000);
					GForm3.smethod_18((ContainerControl)(object)this, new SizeF(10f, 22f));
					num = (int)(num2 * 725575045) ^ -417794559;
					continue;
				case 2u:
					icontainer_0 = GForm3.smethod_3();
					Timer_0 = GForm3.smethod_4(icontainer_0);
					Label_0 = GForm3.smethod_5();
					num = ((int)num2 * -1333431829) ^ 0x207F01F6;
					continue;
				case 1u:
					GForm3.smethod_11((Control)(object)Label_0, GForm3.smethod_10("Microsoft Sans Serif", 24f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 578459383) ^ -1069426217;
					continue;
				default:
					return;
				case 0u:
					break;
				case 20u:
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
			int num = -144643871;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xAD75518Eu) % 11u)
				{
				case 10u:
					num = (int)(num2 * 1366728222) ^ -817919709;
					continue;
				case 8u:
					GForm3.smethod_17(Label_0, "Tutto ebbe inizio in un freddo giorno d'inverno...");
					num = ((int)num2 * -572032370) ^ 0x387E1B05;
					continue;
				case 7u:
					GForm3.smethod_36(GForm3.smethod_35(), ProcessPriorityClass.RealTime);
					num = ((int)num2 * -1153289555) ^ -1557555694;
					continue;
				case 5u:
					GClass1.smethod_2().method_0();
					num = (int)((num2 * 1947894410) ^ 0x1A038AC8);
					continue;
				case 4u:
					flag = int_1 == 0;
					num = ((int)num2 * -1924604905) ^ -2010578972;
					continue;
				case 3u:
					num = -2064698749;
					continue;
				case 2u:
					num = (int)((num2 * 1738656406) ^ 0x2ABC0689);
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = 1288625877;
						num4 = 1288625877;
					}
					else
					{
						num3 = 1590824359;
						num4 = 1590824359;
					}
					num = num3 ^ (int)(num2 * 1770332980);
					continue;
				}
				case 0u:
					GForm3.smethod_37(Timer_0);
					GForm3.smethod_37(Timer_1);
					num = ((int)num2 * -967408770) ^ 0x7F8ACCC2;
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

	private void method_2(object sender, EventArgs e)
	{
		while (true)
		{
			int num = -1890312421;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xADFC9DC9u) % 4u)
				{
				case 3u:
					num = ((int)num2 * -267846769) ^ 0x1C72AF59;
					continue;
				case 2u:
					GForm3.smethod_38();
					num = (int)(num2 * 1074277566) ^ -314940538;
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

	private void method_3(object sender, FormClosingEventArgs e)
	{
		method_4();
		while (true)
		{
			int num = -1055042932;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x957D8B2Au) % 7u)
				{
				case 6u:
					GForm3.smethod_39((CancelEventArgs)(object)e, bool_1: true);
					num = ((int)num2 * -1402248214) ^ 0x3D8D555E;
					continue;
				case 4u:
					num = (int)((num2 * 1402524403) ^ 0x751ADC07);
					continue;
				case 3u:
					num = -668910408;
					continue;
				case 2u:
				{
					int num3;
					int num4;
					if (!bool_0)
					{
						num3 = 935831692;
						num4 = 935831692;
					}
					else
					{
						num3 = 116129488;
						num4 = 116129488;
					}
					num = num3 ^ (int)(num2 * 436017783);
					continue;
				}
				case 1u:
					num = (int)((num2 * 667837872) ^ 0x7E7ED8CD);
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

	public void method_4()
	{
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Invalid comparison between Unknown and I4
		bool flag = !bool_0;
		while (true)
		{
			int num = 250723725;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x37B4CD93u) % 24u)
				{
				case 22u:
				{
					int num5;
					int num6;
					if (!flag)
					{
						num5 = 1376038711;
						num6 = 1376038711;
					}
					else
					{
						num5 = 433223075;
						num6 = 433223075;
					}
					num = num5 ^ (int)(num2 * 331739424);
					continue;
				}
				case 21u:
					num = ((int)num2 * -943276163) ^ -293398142;
					continue;
				case 20u:
					GForm3.smethod_42((object)Timer_0);
					GForm3.smethod_42((object)bool_0);
					num = ((int)num2 * -1864573709) ^ -909529318;
					continue;
				case 19u:
					num = (int)(num2 * 860029333) ^ -1913788590;
					continue;
				case 18u:
					num = (int)(num2 * 743337847) ^ -896177841;
					continue;
				case 17u:
					GForm3.smethod_38();
					num = (int)(num2 * 505621670) ^ -1821570136;
					continue;
				case 16u:
					num = (int)(num2 * 327329361) ^ -1187572199;
					continue;
				case 15u:
					num = 1353379650;
					continue;
				case 14u:
					GForm3.smethod_41(Timer_0);
					num = ((int)num2 * -90995536) ^ -1338196088;
					continue;
				case 13u:
					GForm3.smethod_41(Timer_0);
					num = (int)((num2 * 27849974) ^ 0x53EC4F6E);
					continue;
				case 12u:
					num = 503580478;
					continue;
				case 11u:
					num = (int)((num2 * 706522212) ^ 0x65895753);
					continue;
				case 9u:
					GForm3.smethod_38();
					num = (int)((num2 * 2107799533) ^ 0x393B39DD);
					continue;
				case 8u:
				{
					int num3;
					int num4;
					if ((int)GForm3.smethod_40("Sei sicuro di voler uscire dal gioco?", "The Omegle Game", (MessageBoxButtons)4, (MessageBoxIcon)32) == 6)
					{
						num3 = 1173695949;
						num4 = 1173695949;
					}
					else
					{
						num3 = 1187737404;
						num4 = 1187737404;
					}
					num = num3 ^ (int)(num2 * 1211601775);
					continue;
				}
				case 7u:
					GForm3.smethod_42((object)bool_0);
					num = ((int)num2 * -1918640677) ^ 0x21B292B7;
					continue;
				case 6u:
					GForm3.smethod_42((object)Timer_0);
					num = ((int)num2 * -1242621280) ^ 0x1AA4851;
					continue;
				case 5u:
					num = ((int)num2 * -1665718085) ^ -148424795;
					continue;
				case 4u:
					num = (int)((num2 * 1837862221) ^ 0x23E10F00);
					continue;
				case 3u:
					num = (int)((num2 * 1223043904) ^ 0x4A8FCE51);
					continue;
				case 2u:
					num = ((int)num2 * -371272603) ^ 0xC7CF5B6;
					continue;
				case 1u:
					num = (int)((num2 * 1784347335) ^ 0x2AA1E9DC);
					continue;
				case 0u:
					GForm3.smethod_43(GForm3.smethod_35());
					num = (int)(num2 * 401651039) ^ -982311593;
					continue;
				default:
					return;
				case 23u:
					break;
				case 10u:
					return;
				}
				break;
			}
		}
	}

	private void method_5(object sender, EventArgs e)
	{
		checked
		{
			int_0++;
		}
		bool flag4 = default(bool);
		bool flag7 = default(bool);
		bool flag3 = default(bool);
		bool flag5 = default(bool);
		bool flag6 = default(bool);
		bool flag8 = default(bool);
		bool flag9 = default(bool);
		bool flag = default(bool);
		bool flag2 = default(bool);
		while (true)
		{
			int num = 1952646657;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9680FC6u) % 90u)
				{
				case 89u:
					num = ((int)num2 * -1225335897) ^ 0x2AD84DD9;
					continue;
				case 88u:
					num = ((int)num2 * -330437845) ^ -1698657082;
					continue;
				case 86u:
					GClass1.smethod_2().method_0();
					num = ((int)num2 * -687993265) ^ -1579277827;
					continue;
				case 85u:
					flag4 = int_0 == 8;
					num = 983624600;
					continue;
				case 84u:
					num = (int)((num2 * 1007981363) ^ 0x644037D);
					continue;
				case 83u:
					GForm3.smethod_17(Label_0, "In pochi sanno chi sono, ma lui riuscì a vedere di più:\r\nerano gli imperatori di Omegle.");
					num = (int)((num2 * 1180592268) ^ 0x7C00A22F);
					continue;
				case 82u:
					flag7 = int_0 == 12;
					num = 473404406;
					continue;
				case 81u:
					GForm3.smethod_13((Control)(object)Label_0, new Point(checked(GForm3.smethod_44((Control)(object)Label_0).X + 60), GForm3.smethod_44((Control)(object)Label_0).Y));
					num = (int)(num2 * 608255275) ^ -752487119;
					continue;
				case 80u:
				{
					int num28;
					int num29;
					if (!flag7)
					{
						num28 = 1949435235;
						num29 = 1949435235;
					}
					else
					{
						num28 = 1503991323;
						num29 = 1503991323;
					}
					num = num28 ^ ((int)num2 * -2116028508);
					continue;
				}
				case 79u:
					GForm3.smethod_17(Label_0, "Egli poteva fare trucchi di magia con le carte e con i\r\ncubi agli sconosciuti... Bello, no?");
					num = ((int)num2 * -1298736573) ^ -1290891570;
					continue;
				case 78u:
				{
					int num24;
					if (int_0 == 6)
					{
						num = 599985670;
						num24 = 599985670;
					}
					else
					{
						num = 917160398;
						num24 = 917160398;
					}
					continue;
				}
				case 77u:
					num = ((int)num2 * -1310635636) ^ -449195284;
					continue;
				case 76u:
					GForm3.smethod_17(Label_0, "Così egli capii che c'era un solo modo di porre fine\r\nad ogni problema...");
					num = ((int)num2 * -105459189) ^ 0x4CE0F388;
					continue;
				case 75u:
					num = ((int)num2 * -746280697) ^ -1189508813;
					continue;
				case 74u:
					num = ((int)num2 * -135948912) ^ -2040150132;
					continue;
				case 73u:
					GForm3.smethod_17(Label_0, "Il mago e i suoi amici sono sempre pronti ad affrontare\r\nogni nuova sfida ed ogni pericolo.");
					num = ((int)num2 * -581931494) ^ -17029593;
					continue;
				case 72u:
					num = (int)(num2 * 1513232264) ^ -732201762;
					continue;
				case 71u:
					num = ((int)num2 * -845326612) ^ -1979639463;
					continue;
				case 70u:
					num = ((int)num2 * -530820845) ^ -195842073;
					continue;
				case 69u:
				{
					int num17;
					if (int_0 == 9)
					{
						num = 1363540395;
						num17 = 1363540395;
					}
					else
					{
						num = 494654269;
						num17 = 494654269;
					}
					continue;
				}
				case 68u:
					num = (int)((num2 * 888411178) ^ 0x76764B4D);
					continue;
				case 67u:
					num = ((int)num2 * -1432473597) ^ 0x715D15D3;
					continue;
				case 66u:
					flag3 = int_0 == 7;
					num = 539061543;
					continue;
				case 65u:
					GForm3.smethod_17(Label_0, "Non sapeva bene cosa lo attendeva, ma sapeva bene che\r\n era un grande pericolo intrufolarsi là dentro.");
					num = ((int)num2 * -1982649338) ^ -2065194727;
					continue;
				case 64u:
					bool_0 = true;
					num = 570200426;
					continue;
				case 63u:
					num = (int)(num2 * 1298883742) ^ -922575649;
					continue;
				case 62u:
					flag5 = int_0 == 3;
					num = 1764996560;
					continue;
				case 61u:
					GForm3.smethod_17(Label_0, "Sono delle persone che hanno delle grandissime capacità\r\nda disabili, ma non solo.");
					num = (int)((num2 * 2013223470) ^ 0xA2122F3);
					continue;
				case 60u:
					GForm3.smethod_45((Control)(object)Class2.Class3_0.GForm0_0);
					num = (int)(num2 * 357107721) ^ -45582221;
					continue;
				case 59u:
				{
					int num6;
					int num7;
					if (int_1 == 0)
					{
						num6 = 1854223756;
						num7 = 1854223756;
					}
					else
					{
						num6 = 1337006723;
						num7 = 1337006723;
					}
					num = num6 ^ (int)(num2 * 895582199);
					continue;
				}
				case 58u:
					num = (int)((num2 * 246992104) ^ 0x1206112D);
					continue;
				case 57u:
					num = (int)(num2 * 1542045272) ^ -1712922699;
					continue;
				case 56u:
					num = ((int)num2 * -1917203301) ^ 0x6052EDB;
					continue;
				case 55u:
				{
					int num27;
					if (int_0 != 4)
					{
						num = 2101013991;
						num27 = 2101013991;
					}
					else
					{
						num = 453134729;
						num27 = 453134729;
					}
					continue;
				}
				case 54u:
					num = (int)((num2 * 2078100345) ^ 0x774EFD87);
					continue;
				case 53u:
				{
					int num25;
					int num26;
					if (!flag6)
					{
						num25 = 1955212163;
						num26 = 1955212163;
					}
					else
					{
						num25 = 1668671418;
						num26 = 1668671418;
					}
					num = num25 ^ (int)(num2 * 2019300613);
					continue;
				}
				case 51u:
				{
					int num22;
					int num23;
					if (flag8)
					{
						num22 = -1674287594;
						num23 = -1674287594;
					}
					else
					{
						num22 = -190047058;
						num23 = -190047058;
					}
					num = num22 ^ ((int)num2 * -963587757);
					continue;
				}
				case 50u:
				{
					int num20;
					int num21;
					if (!flag5)
					{
						num20 = -280505063;
						num21 = -280505063;
					}
					else
					{
						num20 = -1442415743;
						num21 = -1442415743;
					}
					num = num20 ^ (int)(num2 * 1883118946);
					continue;
				}
				case 49u:
					num = (int)(num2 * 885789767) ^ -1009638273;
					continue;
				case 48u:
					GClass1.smethod_2().method_3();
					num = (int)(num2 * 382069163) ^ -1455351355;
					continue;
				case 47u:
					flag9 = int_0 == 11;
					num = 1172977826;
					continue;
				case 46u:
				{
					int num18;
					int num19;
					if (!flag9)
					{
						num18 = 1221591312;
						num19 = 1221591312;
					}
					else
					{
						num18 = 1040962128;
						num19 = 1040962128;
					}
					num = num18 ^ (int)(num2 * 124956834);
					continue;
				}
				case 45u:
					flag8 = int_0 == 13;
					num = 1324273151;
					continue;
				case 44u:
					GClass1.smethod_2().method_4();
					num = ((int)num2 * -1476692195) ^ 0x39E812D2;
					continue;
				case 43u:
					num = ((int)num2 * -2115319925) ^ -979599327;
					continue;
				case 42u:
				{
					int num15;
					int num16;
					if (flag)
					{
						num15 = 852143013;
						num16 = 852143013;
					}
					else
					{
						num15 = 1428147098;
						num16 = 1428147098;
					}
					num = num15 ^ (int)(num2 * 539325628);
					continue;
				}
				case 41u:
					GForm3.smethod_17(Label_0, "Insieme a questo mago e ai suoi fantastici amici, \r\npercorrerai tutta la strada di Omegle.");
					num = ((int)num2 * -878126742) ^ -331115852;
					continue;
				case 40u:
					num = ((int)num2 * -309774026) ^ -245422550;
					continue;
				case 39u:
					num = (int)((num2 * 1852956658) ^ 0x28D0511A);
					continue;
				case 38u:
					GForm3.smethod_17(Label_0, "Ma non riuscì bene ad orientarsi... c'era tante persone\r\nche gli ostacolavano il cammino...");
					num = ((int)num2 * -1251900564) ^ -539984781;
					continue;
				case 37u:
					num = ((int)num2 * -1540056630) ^ 0x4CFA1C7;
					continue;
				case 36u:
					GForm3.smethod_17(Label_0, "Che il gioco abbia inizio!");
					num = (int)((num2 * 473099010) ^ 0x71D0473B);
					continue;
				case 35u:
				{
					int num13;
					int num14;
					if (int_0 != 1)
					{
						num13 = -193102978;
						num14 = -193102978;
					}
					else
					{
						num13 = -836133646;
						num14 = -836133646;
					}
					num = num13 ^ (int)(num2 * 1787857999);
					continue;
				}
				case 34u:
					num = ((int)num2 * -593020063) ^ -1489375555;
					continue;
				case 33u:
					num = ((int)num2 * -264474222) ^ 0x189ABE2B;
					continue;
				case 32u:
					num = ((int)num2 * -720889956) ^ 0x6482CC96;
					continue;
				case 31u:
					GForm3.smethod_17(Label_0, "E il mago pian piano, nel suo tortuoso cammino,\r\nne trovò tanti di tali imperatori.");
					num = ((int)num2 * -1993582087) ^ -1604530603;
					continue;
				case 30u:
					num = (int)((num2 * 999571184) ^ 0x27276FD);
					continue;
				case 29u:
					GForm3.smethod_17(Label_0, "Ma lui era solo un semplice mago, come poteva riuscire\r\nad affrontare le agonie contenute là dentro?");
					num = ((int)num2 * -973246080) ^ -1237554848;
					continue;
				case 28u:
					num = (int)(num2 * 1443955233) ^ -1312319109;
					continue;
				case 27u:
					flag2 = int_0 == 14;
					num = 1403800669;
					continue;
				case 26u:
					num = ((int)num2 * -31585494) ^ -1429930819;
					continue;
				case 25u:
					num = ((int)num2 * -1850549194) ^ 0x7D6A8F80;
					continue;
				case 24u:
					num = (int)(num2 * 212368327) ^ -1560776914;
					continue;
				case 23u:
					GForm3.smethod_17(Label_0, "Purtroppo la noia è una droga molto cancerosa, ed egli\r\nsi mise alla ricerca di nuove avventure.");
					num = ((int)num2 * -655484832) ^ -992577185;
					continue;
				case 22u:
					num = ((int)num2 * -1930253312) ^ 0x25A3CF5D;
					continue;
				case 21u:
				{
					int num12;
					if (int_0 == 2)
					{
						num = 49172117;
						num12 = 49172117;
					}
					else
					{
						num = 562485068;
						num12 = 562485068;
					}
					continue;
				}
				case 20u:
					num = ((int)num2 * -1207242636) ^ 0x1490BAF4;
					continue;
				case 19u:
					flag6 = int_0 == 15;
					num = 1754143249;
					continue;
				case 18u:
				{
					int num10;
					int num11;
					if (!flag4)
					{
						num10 = 1077853705;
						num11 = 1077853705;
					}
					else
					{
						num10 = 973873258;
						num11 = 973873258;
					}
					num = num10 ^ ((int)num2 * -1421853646);
					continue;
				}
				case 17u:
				{
					int num8;
					int num9;
					if (flag3)
					{
						num8 = -487253279;
						num9 = -487253279;
					}
					else
					{
						num8 = -806352111;
						num9 = -806352111;
					}
					num = num8 ^ ((int)num2 * -969834154);
					continue;
				}
				case 16u:
					num = (int)((num2 * 331423008) ^ 0x5604699D);
					continue;
				case 15u:
				{
					int num5;
					if (int_0 != 10)
					{
						num = 373429237;
						num5 = 373429237;
					}
					else
					{
						num = 1307490183;
						num5 = 1307490183;
					}
					continue;
				}
				case 14u:
					num = (int)(num2 * 314337299) ^ -1279730421;
					continue;
				case 13u:
				{
					int num3;
					int num4;
					if (!flag2)
					{
						num3 = -1295298533;
						num4 = -1295298533;
					}
					else
					{
						num3 = -568622813;
						num4 = -568622813;
					}
					num = num3 ^ (int)(num2 * 895209718);
					continue;
				}
				case 12u:
					num = (int)((num2 * 2123286470) ^ 0x66EE7340);
					continue;
				case 11u:
					GForm3.smethod_46((Form)(object)this);
					num = (int)((num2 * 1187237717) ^ 0x784B7AEF);
					continue;
				case 10u:
					GForm3.smethod_17(Label_0, "Queste persone trascorrono il loro tempo libero, la loro\r\nintera vita su Omegle, con gli altri.");
					num = (int)(num2 * 1903773544) ^ -2022726157;
					continue;
				case 9u:
					GForm3.smethod_17(Label_0, "Un mago molto misterioso, dagli oscuri segreti... andò\r\nsu OmeTV, quella sera.");
					num = ((int)num2 * -1544843145) ^ -1430388075;
					continue;
				case 8u:
					GClass1.smethod_2().method_3();
					num = (int)(num2 * 1523984297) ^ -321700554;
					continue;
				case 7u:
					flag = int_0 == 5;
					num = 10983710;
					continue;
				case 6u:
					num = ((int)num2 * -760387428) ^ 0x1C6355E3;
					continue;
				case 5u:
					num = 1230385794;
					continue;
				case 4u:
					num = (int)(num2 * 1208206718) ^ -1312721576;
					continue;
				case 3u:
					GForm3.smethod_17(Label_0, "Un mondo pieno di pedofili, maniaci, assassini, pazzi,\r\npersone pluripregiudicate e morti di figa...");
					num = ((int)num2 * -1013986049) ^ 0x42061147;
					continue;
				case 2u:
					num = (int)((num2 * 641741653) ^ 0x27581708);
					continue;
				case 1u:
					num = ((int)num2 * -183357745) ^ -785524733;
					continue;
				case 0u:
					num = 204332389;
					continue;
				default:
					return;
				case 52u:
					break;
				case 87u:
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
