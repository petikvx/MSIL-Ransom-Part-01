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
				int num = -670716675;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x88C10EF8u) % 9u)
					{
					case 8u:
						val = timer_0;
						num = ((int)num2 * -940717859) ^ -377373096;
						continue;
					case 7u:
						GForm3.smethod_34(val, eventHandler_);
						num = ((int)num2 * -2106013043) ^ -83337458;
						continue;
					case 6u:
						timer_0 = value;
						num = -100182195;
						continue;
					case 3u:
						val = timer_0;
						num = (int)((num2 * 347548412) ^ 0x726C686B);
						continue;
					case 2u:
					{
						int num5;
						int num6;
						if (val == null)
						{
							num5 = 709071815;
							num6 = 709071815;
						}
						else
						{
							num5 = 493997245;
							num6 = 493997245;
						}
						num = num5 ^ ((int)num2 * -1393440580);
						continue;
					}
					case 1u:
						GForm3.smethod_33(val, eventHandler_);
						num = (int)((num2 * 2083457751) ^ 0x5FB49570);
						continue;
					case 0u:
					{
						int num3;
						int num4;
						if (val != null)
						{
							num3 = 227618671;
							num4 = 227618671;
						}
						else
						{
							num3 = 819375063;
							num4 = 819375063;
						}
						num = num3 ^ ((int)num2 * -594933249);
						continue;
					}
					default:
						return;
					case 4u:
						break;
					case 5u:
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
				int num = 1063953303;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x7CD2D986u) % 7u)
					{
					case 6u:
						GForm3.smethod_33(val, eventHandler_);
						num = (int)(num2 * 1194317738) ^ -497532948;
						continue;
					case 3u:
					{
						timer_1 = value;
						val = timer_1;
						int num5;
						if (val == null)
						{
							num = 1613847222;
							num5 = 1613847222;
						}
						else
						{
							num = 913416692;
							num5 = 913416692;
						}
						continue;
					}
					case 2u:
						val = timer_1;
						num = ((int)num2 * -714765365) ^ 0xD03D6CA;
						continue;
					case 1u:
					{
						int num3;
						int num4;
						if (val != null)
						{
							num3 = 618781288;
							num4 = 618781288;
						}
						else
						{
							num3 = 1437691736;
							num4 = 1437691736;
						}
						num = num3 ^ ((int)num2 * -756747208);
						continue;
					}
					case 0u:
						GForm3.smethod_34(val, eventHandler_);
						num = (int)(num2 * 2052257015) ^ -617052344;
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
			if (disposing)
			{
				goto IL_0007;
			}
			int num = 0;
			goto IL_0083;
			IL_007a:
			num = ((icontainer_0 != null) ? 1 : 0);
			goto IL_0083;
			IL_0007:
			int num2 = -833799702;
			goto IL_0051;
			IL_0051:
			bool flag = default(bool);
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0xB2BD391Eu) % 6u)
				{
				case 5u:
					break;
				case 3u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = -185496549;
						num5 = -185496549;
					}
					else
					{
						num4 = -539124622;
						num5 = -539124622;
					}
					num2 = num4 ^ ((int)num3 * -865472491);
					continue;
				}
				case 1u:
					GForm3.smethod_2((IDisposable)icontainer_0);
					num2 = ((int)num3 * -1137746736) ^ 0x3C284608;
					continue;
				case 0u:
					num2 = -949874138;
					continue;
				default:
					return;
				case 2u:
					goto IL_007a;
				case 4u:
					return;
				}
				break;
			}
			goto IL_0007;
			IL_0083:
			flag = (byte)num != 0;
			num2 = -301837751;
			goto IL_0051;
		}
		finally
		{
			((Form)this).Dispose(disposing);
		}
	}

	[DebuggerStepThrough]
	private void method_0()
	{
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		icontainer_0 = GForm3.smethod_3();
		Timer_0 = GForm3.smethod_4(icontainer_0);
		while (true)
		{
			int num = -1235167603;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8594DD65u) % 34u)
				{
				case 33u:
					GForm3.smethod_16((Control)(object)Label_0, 0);
					num = (int)(num2 * 1115419873) ^ -50116755;
					continue;
				case 32u:
					GForm3.smethod_6((Control)(object)this);
					num = (int)(num2 * 829932148) ^ -485297528;
					continue;
				case 31u:
					GForm3.smethod_8(Label_0, bool_1: true);
					num = ((int)num2 * -378289001) ^ -1678312885;
					continue;
				case 29u:
					Timer_1 = GForm3.smethod_4(icontainer_0);
					num = ((int)num2 * -180031102) ^ 0x3C955B8A;
					continue;
				case 28u:
					Label_0 = GForm3.smethod_5();
					num = (int)(num2 * 875712126) ^ -1115779970;
					continue;
				case 26u:
					GForm3.smethod_26((Form)(object)this, new Padding(4));
					num = (int)((num2 * 1093809192) ^ 0x55B6FCFC);
					continue;
				case 25u:
					GForm3.smethod_22((Form)(object)this, new Size(1025, 638));
					num = (int)((num2 * 1990585709) ^ 0x1F5B74EE);
					continue;
				case 24u:
					GForm3.smethod_21((Control)(object)this, (ImageLayout)3);
					num = (int)((num2 * 222513177) ^ 0x242FAD00);
					continue;
				case 23u:
					num = (int)(num2 * 367406345) ^ -278191729;
					continue;
				case 22u:
					num = ((int)num2 * -1776336846) ^ 0x1976ACC6;
					continue;
				case 21u:
					GForm3.smethod_7(Timer_0, 1000);
					num = (int)((num2 * 1466860201) ^ 0x2A335F15);
					continue;
				case 20u:
					num = (int)((num2 * 679567785) ^ 0x5A99CE3B);
					continue;
				case 19u:
					num = (int)(num2 * 683470870) ^ -1132128986;
					continue;
				case 18u:
					GForm3.smethod_25((Form)(object)this, (FormBorderStyle)1);
					num = (int)((num2 * 2035436084) ^ 0x4D1EDECB);
					continue;
				case 17u:
					GForm3.smethod_29((Form)(object)this, (FormStartPosition)1);
					GForm3.smethod_30((Form)(object)this, "The Omegle Game");
					GForm3.smethod_31((Control)(object)this, bool_1: false);
					num = (int)(num2 * 1743214116) ^ -136019944;
					continue;
				case 16u:
					num = (int)(num2 * 789293805) ^ -889109790;
					continue;
				case 15u:
					GForm3.smethod_20((Form)(object)this, Color.White);
					num = ((int)num2 * -1588876703) ^ 0x372FFE10;
					continue;
				case 14u:
					GForm3.smethod_14((Control)(object)Label_0, "Label1");
					GForm3.smethod_15((Control)(object)Label_0, new Size(862, 46));
					num = ((int)num2 * -1875857059) ^ 0x4C0AB8A4;
					continue;
				case 13u:
					num = ((int)num2 * -2060800952) ^ -2056615093;
					continue;
				case 12u:
					GForm3.smethod_11((Control)(object)this, GForm3.smethod_10("Consolas", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -5567808) ^ -888131595;
					continue;
				case 11u:
					num = (int)((num2 * 651158411) ^ 0x7C34F08B);
					continue;
				case 10u:
					num = (int)((num2 * 1910291078) ^ 0x4D7404D7);
					continue;
				case 9u:
					GForm3.smethod_27((Form)(object)this, bool_1: false);
					num = ((int)num2 * -559363041) ^ -138460322;
					continue;
				case 8u:
					GForm3.smethod_28((Control)(object)this, "StoryMode");
					num = (int)(num2 * 815288932) ^ -1692714655;
					continue;
				case 7u:
					GForm3.smethod_9((Control)(object)Label_0, Color.Transparent);
					num = (int)(num2 * 1965998977) ^ -782655032;
					continue;
				case 6u:
					GForm3.smethod_11((Control)(object)Label_0, GForm3.smethod_10("Microsoft Sans Serif", 24f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
					GForm3.smethod_12((Control)(object)Label_0, Color.White);
					GForm3.smethod_13((Control)(object)Label_0, new Point(111, 270));
					num = ((int)num2 * -1479669991) ^ -2117004335;
					continue;
				case 5u:
					GForm3.smethod_17(Label_0, "Tutto ebbe inizio in un freddo giorno d'inverno...");
					GForm3.smethod_7(Timer_1, 6000);
					num = (int)(num2 * 769430997) ^ -722735708;
					continue;
				case 4u:
					GForm3.smethod_18((ContainerControl)(object)this, new SizeF(10f, 22f));
					num = ((int)num2 * -135205855) ^ -1303578259;
					continue;
				case 3u:
					num = ((int)num2 * -154199226) ^ 0x2EEFC064;
					continue;
				case 2u:
					GForm3.smethod_24(GForm3.smethod_23((Control)(object)this), (Control)(object)Label_0);
					((Control)this).set_DoubleBuffered(true);
					num = (int)((num2 * 1158564996) ^ 0x5B11471B);
					continue;
				case 1u:
					num = (int)(num2 * 1469514465) ^ -743410675;
					continue;
				case 0u:
					GForm3.smethod_19((ContainerControl)(object)this, (AutoScaleMode)1);
					num = (int)((num2 * 639251276) ^ 0x3278772F);
					continue;
				case 30u:
					break;
				default:
					GForm3.smethod_32((Control)(object)this);
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
			int num = -1937811030;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xED2ABBEBu) % 13u)
				{
				case 12u:
					GForm3.smethod_17(Label_0, "Tutto ebbe inizio in un freddo giorno d'inverno...");
					num = ((int)num2 * -887461647) ^ 0x3DEFA637;
					continue;
				case 11u:
					num = (int)(num2 * 347181446) ^ -1725269396;
					continue;
				case 9u:
				{
					int num3;
					int num4;
					if (int_1 == 0)
					{
						num3 = 1784592269;
						num4 = 1784592269;
					}
					else
					{
						num3 = 1789103691;
						num4 = 1789103691;
					}
					num = num3 ^ (int)(num2 * 1080297244);
					continue;
				}
				case 8u:
					GClass1.smethod_2().method_0();
					num = (int)(num2 * 1225050781) ^ -505296305;
					continue;
				case 7u:
					GForm3.smethod_36(GForm3.smethod_35(), ProcessPriorityClass.RealTime);
					num = (int)((num2 * 30299655) ^ 0x598422ED);
					continue;
				case 6u:
					num = ((int)num2 * -1365601306) ^ -1828529062;
					continue;
				case 5u:
					num = (int)((num2 * 434128284) ^ 0x54829030);
					continue;
				case 3u:
					GForm3.smethod_37(Timer_1);
					num = ((int)num2 * -452616993) ^ -1258838628;
					continue;
				case 2u:
					num = -294353745;
					continue;
				case 1u:
					GForm3.smethod_37(Timer_0);
					num = (int)(num2 * 1648828820) ^ -2093212858;
					continue;
				case 0u:
					num = ((int)num2 * -483002492) ^ 0x65A5B4A7;
					continue;
				default:
					return;
				case 4u:
					break;
				case 10u:
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
			int num = 1931909630;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x4CD8744Fu) % 4u)
				{
				case 3u:
					num = (int)((num2 * 317724645) ^ 0x2A804F1E);
					continue;
				case 1u:
					GForm3.smethod_38();
					num = (int)(num2 * 1762199184) ^ -367428356;
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
			int num = 1813755096;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x51FC8D82u) % 8u)
				{
				case 7u:
					num = (int)(num2 * 433193936) ^ -1116466474;
					continue;
				case 5u:
					flag = !bool_0;
					num = (int)(num2 * 1917926178) ^ -1995018240;
					continue;
				case 4u:
					num = 64835371;
					continue;
				case 3u:
					GForm3.smethod_39((CancelEventArgs)(object)e, bool_1: true);
					num = ((int)num2 * -389481805) ^ -886098436;
					continue;
				case 2u:
					method_4();
					num = (int)(num2 * 53070820) ^ -1262027609;
					continue;
				case 0u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = 1544184894;
						num4 = 1544184894;
					}
					else
					{
						num3 = 1998483737;
						num4 = 1998483737;
					}
					num = num3 ^ (int)(num2 * 435664253);
					continue;
				}
				default:
					return;
				case 6u:
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
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Invalid comparison between Unknown and I4
		bool flag = !bool_0;
		while (true)
		{
			int num = -1549869978;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA10A4756u) % 19u)
				{
				case 18u:
					GForm3.smethod_42((object)Timer_0);
					num = (int)((num2 * 1025609589) ^ 0x2C92D83B);
					continue;
				case 17u:
					GForm3.smethod_42((object)bool_0);
					num = (int)((num2 * 1403840883) ^ 0x7315E76F);
					continue;
				case 16u:
					GForm3.smethod_42((object)bool_0);
					GForm3.smethod_38();
					num = ((int)num2 * -2100226380) ^ 0x53D33B30;
					continue;
				case 15u:
					num = ((int)num2 * -45802517) ^ -165983136;
					continue;
				case 14u:
					num = -1653533206;
					continue;
				case 13u:
					num = (int)((num2 * 130097693) ^ 0x34F80210);
					continue;
				case 12u:
				{
					int num5;
					int num6;
					if (!flag)
					{
						num5 = 704926256;
						num6 = 704926256;
					}
					else
					{
						num5 = 70162062;
						num6 = 70162062;
					}
					num = num5 ^ (int)(num2 * 600376497);
					continue;
				}
				case 11u:
					GForm3.smethod_41(Timer_0);
					num = -1866747150;
					continue;
				case 10u:
					num = (int)(num2 * 134409768) ^ -1784157919;
					continue;
				case 8u:
					GForm3.smethod_43(GForm3.smethod_35());
					num = (int)(num2 * 1958398021) ^ -911048556;
					continue;
				case 7u:
					GForm3.smethod_41(Timer_0);
					num = (int)(num2 * 206903849) ^ -1149371098;
					continue;
				case 6u:
					GForm3.smethod_42((object)Timer_0);
					num = ((int)num2 * -1119737586) ^ 0x44D56DFB;
					continue;
				case 5u:
					num = ((int)num2 * -774740567) ^ 0x635B01A9;
					continue;
				case 4u:
					num = (int)(num2 * 1813447657) ^ -1627615987;
					continue;
				case 3u:
				{
					int num3;
					int num4;
					if ((int)GForm3.smethod_40("Sei sicuro di voler uscire dal gioco?", "The Omegle Game", (MessageBoxButtons)4, (MessageBoxIcon)32) == 6)
					{
						num3 = 1079412908;
						num4 = 1079412908;
					}
					else
					{
						num3 = 849391008;
						num4 = 849391008;
					}
					num = num3 ^ ((int)num2 * -471579593);
					continue;
				}
				case 1u:
					num = (int)((num2 * 1031650053) ^ 0x4E8C559C);
					continue;
				case 0u:
					GForm3.smethod_38();
					num = ((int)num2 * -1803028858) ^ 0x4B2065E7;
					continue;
				default:
					return;
				case 9u:
					break;
				case 2u:
					return;
				}
				break;
			}
		}
	}

	private void method_5(object sender, EventArgs e)
	{
		bool flag10 = default(bool);
		bool flag4 = default(bool);
		bool flag9 = default(bool);
		bool flag3 = default(bool);
		bool flag8 = default(bool);
		bool flag = default(bool);
		bool flag6 = default(bool);
		bool flag5 = default(bool);
		bool flag7 = default(bool);
		bool flag2 = default(bool);
		while (true)
		{
			int num = -889826885;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x92B9CF64u) % 80u)
				{
				case 79u:
					GForm3.smethod_45((Control)(object)Class2.Class3_0.GForm0_0);
					num = (int)((num2 * 1589168200) ^ 0x5440E981);
					continue;
				case 78u:
					GForm3.smethod_17(Label_0, "Ma non riuscì bene ad orientarsi... c'era tante persone\r\nche gli ostacolavano il cammino...");
					num = (int)(num2 * 2125958448) ^ -1741025774;
					continue;
				case 77u:
				{
					int num18;
					if (int_0 != 8)
					{
						num = -1403251445;
						num18 = -1403251445;
					}
					else
					{
						num = -336116998;
						num18 = -336116998;
					}
					continue;
				}
				case 76u:
				{
					int num25;
					int num26;
					if (!flag10)
					{
						num25 = -1602970141;
						num26 = -1602970141;
					}
					else
					{
						num25 = -726226774;
						num26 = -726226774;
					}
					num = num25 ^ (int)(num2 * 74360061);
					continue;
				}
				case 75u:
					num = ((int)num2 * -1280837703) ^ -205350557;
					continue;
				case 74u:
					num = (int)((num2 * 1527964057) ^ 0x823134A);
					continue;
				case 73u:
				{
					int num11;
					if (int_0 == 10)
					{
						num = -1636716347;
						num11 = -1636716347;
					}
					else
					{
						num = -161180015;
						num11 = -161180015;
					}
					continue;
				}
				case 72u:
					GForm3.smethod_17(Label_0, "Un mago molto misterioso, dagli oscuri segreti... andò\r\nsu OmeTV, quella sera.");
					num = (int)((num2 * 1747489591) ^ 0x3226F2F8);
					continue;
				case 71u:
					num = (int)((num2 * 152801907) ^ 0x152C2935);
					continue;
				case 70u:
					num = (int)(num2 * 1330033664) ^ -626287888;
					continue;
				case 69u:
					GClass1.smethod_2().method_3();
					num = ((int)num2 * -1744288703) ^ 0x1A9F53E2;
					continue;
				case 68u:
					num = (int)(num2 * 1224647288) ^ -1563237653;
					continue;
				case 67u:
				{
					int num23;
					int num24;
					if (!flag4)
					{
						num23 = 480057437;
						num24 = 480057437;
					}
					else
					{
						num23 = 919214337;
						num24 = 919214337;
					}
					num = num23 ^ ((int)num2 * -1248734716);
					continue;
				}
				case 66u:
				{
					int num19;
					int num20;
					if (flag9)
					{
						num19 = 1469625789;
						num20 = 1469625789;
					}
					else
					{
						num19 = 171218828;
						num20 = 171218828;
					}
					num = num19 ^ (int)(num2 * 1941368660);
					continue;
				}
				case 65u:
					GForm3.smethod_17(Label_0, "Sono delle persone che hanno delle grandissime capacità\r\nda disabili, ma non solo.");
					num = (int)(num2 * 624772021) ^ -1590430633;
					continue;
				case 64u:
					num = (int)(num2 * 656735389) ^ -53337100;
					continue;
				case 63u:
				{
					int num12;
					checked
					{
						int_0++;
						int num13;
						if (int_1 == 0)
						{
							num12 = 102706845;
							num13 = 102706845;
						}
						else
						{
							num12 = 127200083;
							num13 = 127200083;
						}
					}
					num = num12 ^ ((int)num2 * -1000934041);
					continue;
				}
				case 62u:
					GForm3.smethod_17(Label_0, "Queste persone trascorrono il loro tempo libero, la loro\r\nintera vita su Omegle, con gli altri.");
					num = (int)((num2 * 504377692) ^ 0x4E7C9904);
					continue;
				case 61u:
					num = (int)(num2 * 1608359016) ^ -1022438258;
					continue;
				case 60u:
					num = (int)(num2 * 401563087) ^ -1870271420;
					continue;
				case 59u:
					num = (int)((num2 * 1512499858) ^ 0x40945EF6);
					continue;
				case 58u:
					flag3 = int_0 == 13;
					num = -590193480;
					continue;
				case 57u:
					GForm3.smethod_17(Label_0, "Ma lui era solo un semplice mago, come poteva riuscire\r\nad affrontare le agonie contenute là dentro?");
					num = ((int)num2 * -2138728295) ^ -1784182196;
					continue;
				case 56u:
					num = (int)(num2 * 1895471407) ^ -1047654018;
					continue;
				case 55u:
					GForm3.smethod_17(Label_0, "E il mago pian piano, nel suo tortuoso cammino,\r\nne trovò tanti di tali imperatori.");
					num = ((int)num2 * -1256713981) ^ 0x7A252C05;
					continue;
				case 54u:
					num = (int)(num2 * 471841647) ^ -549745607;
					continue;
				case 53u:
					GForm3.smethod_17(Label_0, "Egli poteva fare trucchi di magia con le carte e con i\r\ncubi agli sconosciuti... Bello, no?");
					num = ((int)num2 * -539539043) ^ 0x103590CF;
					continue;
				case 52u:
				{
					int num28;
					int num29;
					if (!flag8)
					{
						num28 = 774007201;
						num29 = 774007201;
					}
					else
					{
						num28 = 1137129033;
						num29 = 1137129033;
					}
					num = num28 ^ (int)(num2 * 749112374);
					continue;
				}
				case 51u:
					num = ((int)num2 * -2031926960) ^ -952454318;
					continue;
				case 50u:
					GForm3.smethod_17(Label_0, "Così egli capii che c'era un solo modo di porre fine\r\nad ogni problema...");
					num = ((int)num2 * -723801533) ^ -882993855;
					continue;
				case 49u:
					flag10 = int_0 == 3;
					num = -330158408;
					continue;
				case 48u:
				{
					int num27;
					if (int_0 == 5)
					{
						num = -330738035;
						num27 = -330738035;
					}
					else
					{
						num = -1248271679;
						num27 = -1248271679;
					}
					continue;
				}
				case 47u:
					num = ((int)num2 * -688159276) ^ -1046664065;
					continue;
				case 46u:
					num = -268697016;
					continue;
				case 45u:
					GForm3.smethod_46((Form)(object)this);
					num = ((int)num2 * -1174524171) ^ -1017235372;
					continue;
				case 44u:
				{
					int num21;
					int num22;
					if (!flag)
					{
						num21 = 564457831;
						num22 = 564457831;
					}
					else
					{
						num21 = 672435112;
						num22 = 672435112;
					}
					num = num21 ^ (int)(num2 * 553481491);
					continue;
				}
				case 43u:
					flag9 = int_0 == 4;
					num = -1657359450;
					continue;
				case 42u:
					num = (int)(num2 * 696449585) ^ -1470997384;
					continue;
				case 41u:
					num = (int)(num2 * 1140702085) ^ -5442156;
					continue;
				case 40u:
					GClass1.smethod_2().method_3();
					GClass1.smethod_2().method_4();
					num = ((int)num2 * -1199494981) ^ 0x4096B0F3;
					continue;
				case 39u:
					flag6 = int_0 == 2;
					num = -1472949300;
					continue;
				case 38u:
				{
					int num16;
					int num17;
					if (!flag5)
					{
						num16 = 85009100;
						num17 = 85009100;
					}
					else
					{
						num16 = 766535521;
						num17 = 766535521;
					}
					num = num16 ^ (int)(num2 * 1947195465);
					continue;
				}
				case 37u:
					flag7 = int_0 == 6;
					num = -713975410;
					continue;
				case 36u:
					num = ((int)num2 * -1345925772) ^ -624814497;
					continue;
				case 35u:
					num = (int)((num2 * 987755442) ^ 0x475B857B);
					continue;
				case 34u:
					num = ((int)num2 * -349488295) ^ 0x38C3AE02;
					continue;
				case 33u:
					GForm3.smethod_17(Label_0, "Un mondo pieno di pedofili, maniaci, assassini, pazzi,\r\npersone pluripregiudicate e morti di figa...");
					num = ((int)num2 * -34774599) ^ 0x53B3A8C9;
					continue;
				case 32u:
					num = ((int)num2 * -300624225) ^ -1340535266;
					continue;
				case 31u:
					flag8 = int_0 == 7;
					num = -273394544;
					continue;
				case 30u:
					bool_0 = true;
					num = -843971076;
					continue;
				case 29u:
					num = ((int)num2 * -95183408) ^ -1624378272;
					continue;
				case 26u:
				{
					int num14;
					int num15;
					if (!flag7)
					{
						num14 = 866268773;
						num15 = 866268773;
					}
					else
					{
						num14 = 16839896;
						num15 = 16839896;
					}
					num = num14 ^ ((int)num2 * -1193922773);
					continue;
				}
				case 25u:
					GForm3.smethod_17(Label_0, "Il mago e i suoi amici sono sempre pronti ad affrontare\r\nogni nuova sfida ed ogni pericolo.");
					num = ((int)num2 * -1708260838) ^ -1156331789;
					continue;
				case 24u:
				{
					int num9;
					int num10;
					if (flag6)
					{
						num9 = -1933961280;
						num10 = -1933961280;
					}
					else
					{
						num9 = -1450764539;
						num10 = -1450764539;
					}
					num = num9 ^ ((int)num2 * -63458288);
					continue;
				}
				case 23u:
					num = ((int)num2 * -290506249) ^ 0x1FF22519;
					continue;
				case 22u:
					num = ((int)num2 * -1117328033) ^ 0x26CC843A;
					continue;
				case 21u:
					flag5 = int_0 == 15;
					num = -1014030254;
					continue;
				case 20u:
					num = -764756502;
					continue;
				case 19u:
					GForm3.smethod_13((Control)(object)Label_0, new Point(checked(GForm3.smethod_44((Control)(object)Label_0).X + 60), GForm3.smethod_44((Control)(object)Label_0).Y));
					num = (int)((num2 * 1405081058) ^ 0x35145132);
					continue;
				case 18u:
					GForm3.smethod_17(Label_0, "Non sapeva bene cosa lo attendeva, ma sapeva bene che\r\n era un grande pericolo intrufolarsi là dentro.");
					num = ((int)num2 * -1917369853) ^ 0x16613D42;
					continue;
				case 17u:
					flag4 = int_0 == 14;
					num = -1080358105;
					continue;
				case 16u:
					GForm3.smethod_17(Label_0, "Che il gioco abbia inizio!");
					num = (int)(num2 * 981607706) ^ -1680339440;
					continue;
				case 15u:
				{
					int num8;
					if (int_0 == 9)
					{
						num = -656600310;
						num8 = -656600310;
					}
					else
					{
						num = -158848707;
						num8 = -158848707;
					}
					continue;
				}
				case 14u:
					GForm3.smethod_17(Label_0, "In pochi sanno chi sono, ma lui riuscì a vedere di più:\r\nerano gli imperatori di Omegle.");
					num = (int)(num2 * 2021572641) ^ -1051972407;
					continue;
				case 13u:
					flag2 = int_0 == 12;
					num = -1492961346;
					continue;
				case 12u:
				{
					int num6;
					int num7;
					if (flag3)
					{
						num6 = -1023006068;
						num7 = -1023006068;
					}
					else
					{
						num6 = -486309851;
						num7 = -486309851;
					}
					num = num6 ^ (int)(num2 * 1628629528);
					continue;
				}
				case 11u:
					num = ((int)num2 * -304373480) ^ 0x1EB17478;
					continue;
				case 10u:
				{
					int num4;
					int num5;
					if (flag2)
					{
						num4 = -1576079517;
						num5 = -1576079517;
					}
					else
					{
						num4 = -87710738;
						num5 = -87710738;
					}
					num = num4 ^ (int)(num2 * 1252925616);
					continue;
				}
				case 9u:
					num = ((int)num2 * -1255368629) ^ -1441869005;
					continue;
				case 8u:
					GForm3.smethod_17(Label_0, "Insieme a questo mago e ai suoi fantastici amici, \r\npercorrerai tutta la strada di Omegle.");
					num = ((int)num2 * -1884497442) ^ 0x7F413FF1;
					continue;
				case 7u:
					num = (int)(num2 * 619877007) ^ -1241133559;
					continue;
				case 6u:
					num = ((int)num2 * -1460921815) ^ 0x4176A2B6;
					continue;
				case 5u:
				{
					int num3;
					if (int_0 != 11)
					{
						num = -1426869559;
						num3 = -1426869559;
					}
					else
					{
						num = -1102579174;
						num3 = -1102579174;
					}
					continue;
				}
				case 4u:
					GForm3.smethod_17(Label_0, "Purtroppo la noia è una droga molto cancerosa, ed egli\r\nsi mise alla ricerca di nuove avventure.");
					num = ((int)num2 * -1046273830) ^ -235166105;
					continue;
				case 3u:
					GClass1.smethod_2().method_0();
					num = ((int)num2 * -1488927830) ^ -1545603187;
					continue;
				case 2u:
					num = (int)((num2 * 1784887831) ^ 0x4A17ED11);
					continue;
				case 1u:
					num = ((int)num2 * -307070639) ^ 0x5C2B3471;
					continue;
				case 0u:
					flag = int_0 == 1;
					num = (int)(num2 * 492000196) ^ -2052194344;
					continue;
				default:
					return;
				case 27u:
					break;
				case 28u:
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
