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
				int num = 1538321231;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x63322914u) % 8u)
					{
					case 7u:
					{
						int num5;
						int num6;
						if (val != null)
						{
							num5 = -318451905;
							num6 = -318451905;
						}
						else
						{
							num5 = -1673290550;
							num6 = -1673290550;
						}
						num = num5 ^ ((int)num2 * -2017847474);
						continue;
					}
					case 6u:
						timer_0 = value;
						val = timer_0;
						num = 1546429443;
						continue;
					case 5u:
						GForm3.smethod_33(val, eventHandler_);
						num = ((int)num2 * -181374805) ^ 0x16F824FD;
						continue;
					case 3u:
						val = timer_0;
						num = (int)(num2 * 1450760729) ^ -1834363659;
						continue;
					case 2u:
					{
						int num3;
						int num4;
						if (val != null)
						{
							num3 = 1747152985;
							num4 = 1747152985;
						}
						else
						{
							num3 = 393284882;
							num4 = 393284882;
						}
						num = num3 ^ (int)(num2 * 1592070800);
						continue;
					}
					case 1u:
						GForm3.smethod_34(val, eventHandler_);
						num = ((int)num2 * -1439449348) ^ 0x54BC6494;
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
				int num = 129224112;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x75269593u) % 8u)
					{
					case 7u:
					{
						int num5;
						int num6;
						if (val != null)
						{
							num5 = -789260313;
							num6 = -789260313;
						}
						else
						{
							num5 = -2115215352;
							num6 = -2115215352;
						}
						num = num5 ^ ((int)num2 * -1638189161);
						continue;
					}
					case 6u:
						val = timer_1;
						num = ((int)num2 * -517343769) ^ -1597224594;
						continue;
					case 5u:
						GForm3.smethod_34(val, eventHandler_);
						num = (int)(num2 * 313322360) ^ -1003208735;
						continue;
					case 4u:
						timer_1 = value;
						num = 1129424373;
						continue;
					case 3u:
					{
						int num3;
						int num4;
						if (val == null)
						{
							num3 = -326129594;
							num4 = -326129594;
						}
						else
						{
							num3 = -133212317;
							num4 = -133212317;
						}
						num = num3 ^ (int)(num2 * 333166635);
						continue;
					}
					case 1u:
						GForm3.smethod_33(val, eventHandler_);
						num = (int)(num2 * 87736817) ^ -1938295386;
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

	public GForm3()
	{
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Expected O, but got Unknown
		while (true)
		{
			int num = -667597360;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA09BFD4Bu) % 8u)
				{
				case 7u:
					bool_0 = false;
					int_0 = 0;
					num = ((int)num2 * -284813330) ^ -205187277;
					continue;
				case 4u:
					num = (int)((num2 * 1080815407) ^ 0x6940F1A8);
					continue;
				case 3u:
					GForm3.smethod_0((Form)(object)this, (EventHandler)method_1);
					num = (int)(num2 * 651189487) ^ -616817049;
					continue;
				case 2u:
					int_1 = 0;
					method_0();
					num = (int)((num2 * 1844470510) ^ 0x45431EBF);
					continue;
				case 1u:
					GForm3.smethod_1((Form)(object)this, new FormClosingEventHandler(method_3));
					num = (int)((num2 * 1249088460) ^ 0x1CBFAEE3);
					continue;
				case 0u:
					num = ((int)num2 * -65931286) ^ 0x44936466;
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
			if (disposing)
			{
				goto IL_0047;
			}
			goto IL_0080;
			IL_0047:
			int num = -499476813;
			goto IL_004c;
			IL_004c:
			int num3;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF9448D01u) % 6u)
				{
				case 5u:
					GForm3.smethod_2((IDisposable)icontainer_0);
					num = (int)(num2 * 253478129) ^ -1170440171;
					continue;
				case 3u:
					num = ((int)num2 * -675768156) ^ 0x695935B8;
					continue;
				case 1u:
					num = -527134803;
					continue;
				case 0u:
					break;
				default:
					return;
				case 4u:
					goto IL_0075;
				case 2u:
					return;
				}
				break;
				IL_0075:
				if (icontainer_0 != null)
				{
					num = -858782184;
					num3 = -858782184;
					continue;
				}
				goto IL_0080;
			}
			goto IL_0047;
			IL_0080:
			num = -810820308;
			num3 = -810820308;
			goto IL_004c;
		}
		finally
		{
			((Form)this).Dispose(disposing);
			while (true)
			{
				IL_00c8:
				int num4 = -233880532;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num4 ^ 0xF9448D01u) % 3u)
					{
					case 2u:
						goto IL_009e;
					default:
						goto end_IL_00ab;
					case 0u:
						break;
					case 1u:
						goto end_IL_00ab;
					}
					goto IL_00c8;
					IL_009e:
					num4 = ((int)num2 * -454357979) ^ 0x4871B523;
					continue;
					end_IL_00ab:
					break;
				}
				break;
			}
		}
	}

	[DebuggerStepThrough]
	private void method_0()
	{
		//IL_02c1: Unknown result type (might be due to invalid IL or missing references)
		icontainer_0 = GForm3.smethod_3();
		while (true)
		{
			int num = -609997171;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xDD14FE8Cu) % 35u)
				{
				case 34u:
					GForm3.smethod_9((Control)(object)Label_0, Color.Transparent);
					num = ((int)num2 * -1093719495) ^ 0x617A0F1E;
					continue;
				case 33u:
					GForm3.smethod_14((Control)(object)Label_0, "Label1");
					num = (int)((num2 * 104234462) ^ 0x2F542565);
					continue;
				case 32u:
					num = ((int)num2 * -1998054287) ^ 0x7596F015;
					continue;
				case 31u:
					GForm3.smethod_16((Control)(object)Label_0, 0);
					num = (int)((num2 * 1847831834) ^ 0x6069EEBA);
					continue;
				case 30u:
					num = ((int)num2 * -1314030650) ^ -2141040506;
					continue;
				case 29u:
					GForm3.smethod_21((Control)(object)this, (ImageLayout)3);
					num = ((int)num2 * -1651423832) ^ -1341492487;
					continue;
				case 28u:
					num = (int)(num2 * 1369470017) ^ -10884554;
					continue;
				case 27u:
					GForm3.smethod_24(GForm3.smethod_23((Control)(object)this), (Control)(object)Label_0);
					num = ((int)num2 * -671086417) ^ -2051250920;
					continue;
				case 26u:
					GForm3.smethod_12((Control)(object)Label_0, Color.White);
					num = (int)((num2 * 75496963) ^ 0x2AC4F5B1);
					continue;
				case 25u:
					Timer_1 = GForm3.smethod_4(icontainer_0);
					GForm3.smethod_6((Control)(object)this);
					num = (int)((num2 * 326390605) ^ 0x6A77B1A8);
					continue;
				case 24u:
					GForm3.smethod_11((Control)(object)Label_0, GForm3.smethod_10("Microsoft Sans Serif", 24f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1172456979) ^ -293697982;
					continue;
				case 23u:
					num = ((int)num2 * -708227557) ^ -1527647860;
					continue;
				case 22u:
					GForm3.smethod_15((Control)(object)Label_0, new Size(862, 46));
					num = (int)(num2 * 1861845404) ^ -1427207109;
					continue;
				case 21u:
					GForm3.smethod_8(Label_0, bool_1: true);
					num = (int)(num2 * 1540881916) ^ -686580317;
					continue;
				case 20u:
					GForm3.smethod_19((ContainerControl)(object)this, (AutoScaleMode)1);
					GForm3.smethod_20((Form)(object)this, Color.White);
					num = ((int)num2 * -1771540322) ^ 0x5EC74ED8;
					continue;
				case 19u:
					GForm3.smethod_22((Form)(object)this, new Size(1025, 638));
					num = ((int)num2 * -1995165665) ^ -1328196245;
					continue;
				case 18u:
					GForm3.smethod_11((Control)(object)this, GForm3.smethod_10("Consolas", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
					GForm3.smethod_25((Form)(object)this, (FormBorderStyle)1);
					num = (int)((num2 * 1025500372) ^ 0x32F216E);
					continue;
				case 17u:
					GForm3.smethod_7(Timer_0, 1000);
					num = (int)(num2 * 1129642206) ^ -1463569584;
					continue;
				case 16u:
					((Control)this).set_DoubleBuffered(true);
					num = ((int)num2 * -541992988) ^ -493513041;
					continue;
				case 15u:
					GForm3.smethod_30((Form)(object)this, "The Omegle Game");
					num = ((int)num2 * -1255779860) ^ -1395235715;
					continue;
				case 14u:
					num = (int)(num2 * 1783726191) ^ -554789926;
					continue;
				case 13u:
					GForm3.smethod_7(Timer_1, 6000);
					num = ((int)num2 * -281934450) ^ 0x9A5C043;
					continue;
				case 12u:
					GForm3.smethod_26((Form)(object)this, new Padding(4));
					num = (int)((num2 * 718763308) ^ 0x4E66D38A);
					continue;
				case 11u:
					GForm3.smethod_13((Control)(object)Label_0, new Point(111, 270));
					num = (int)((num2 * 1777580077) ^ 0x42BC2352);
					continue;
				case 8u:
					GForm3.smethod_27((Form)(object)this, bool_1: false);
					GForm3.smethod_28((Control)(object)this, "StoryMode");
					num = ((int)num2 * -367847680) ^ -637357877;
					continue;
				case 7u:
					GForm3.smethod_17(Label_0, "Tutto ebbe inizio in un freddo giorno d'inverno...");
					num = ((int)num2 * -1634103894) ^ 0x3EBDD787;
					continue;
				case 6u:
					GForm3.smethod_18((ContainerControl)(object)this, new SizeF(10f, 22f));
					num = (int)((num2 * 1944402419) ^ 0x2E2C9E7E);
					continue;
				case 5u:
					GForm3.smethod_29((Form)(object)this, (FormStartPosition)1);
					num = (int)(num2 * 1653301970) ^ -1435854733;
					continue;
				case 4u:
					num = ((int)num2 * -714864274) ^ -717111212;
					continue;
				case 3u:
					num = (int)((num2 * 1694118934) ^ 0x2EF629A6);
					continue;
				case 2u:
					num = (int)((num2 * 1774990374) ^ 0x1249E9AD);
					continue;
				case 1u:
					Timer_0 = GForm3.smethod_4(icontainer_0);
					Label_0 = GForm3.smethod_5();
					num = (int)(num2 * 61734783) ^ -1412844863;
					continue;
				case 0u:
					GForm3.smethod_31((Control)(object)this, bool_1: false);
					GForm3.smethod_32((Control)(object)this);
					num = (int)((num2 * 1771736774) ^ 0xA5ADB90);
					continue;
				default:
					return;
				case 10u:
					break;
				case 9u:
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
			int num = 1883464436;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x752D210Cu) % 11u)
				{
				case 10u:
					GForm3.smethod_37(Timer_0);
					num = (int)((num2 * 733557249) ^ 0x60404D5E);
					continue;
				case 9u:
					num = 1282790924;
					continue;
				case 8u:
					GForm3.smethod_37(Timer_1);
					GClass1.smethod_2().method_0();
					num = ((int)num2 * -1031188049) ^ 0x2FA3CABC;
					continue;
				case 6u:
					num = ((int)num2 * -49417230) ^ -866039963;
					continue;
				case 5u:
					num = ((int)num2 * -1920539099) ^ -1723342100;
					continue;
				case 4u:
					num = ((int)num2 * -1128215015) ^ 0x185DDEF2;
					continue;
				case 2u:
					GForm3.smethod_17(Label_0, "Tutto ebbe inizio in un freddo giorno d'inverno...");
					num = ((int)num2 * -530400956) ^ -301207381;
					continue;
				case 1u:
					GForm3.smethod_36(GForm3.smethod_35(), ProcessPriorityClass.RealTime);
					num = (int)(num2 * 909295866) ^ -1504439748;
					continue;
				case 0u:
				{
					int num3;
					int num4;
					if (int_1 != 0)
					{
						num3 = 2128967555;
						num4 = 2128967555;
					}
					else
					{
						num3 = 785729994;
						num4 = 785729994;
					}
					num = num3 ^ (int)(num2 * 61483495);
					continue;
				}
				default:
					return;
				case 7u:
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
		while (true)
		{
			int num = 1561686233;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x102A5FDFu) % 3u)
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
				GForm3.smethod_38();
				num = (int)((num2 * 1295796147) ^ 0x41B6F8E8);
			}
		}
	}

	private void method_3(object sender, FormClosingEventArgs e)
	{
		bool flag = default(bool);
		while (true)
		{
			int num = -661157859;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC7FD5474u) % 9u)
				{
				case 8u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = 1893139093;
						num4 = 1893139093;
					}
					else
					{
						num3 = 1573704178;
						num4 = 1573704178;
					}
					num = num3 ^ ((int)num2 * -1472084807);
					continue;
				}
				case 7u:
					num = -2021636343;
					continue;
				case 4u:
					num = (int)(num2 * 2120732637) ^ -1158762058;
					continue;
				case 3u:
					method_4();
					num = (int)((num2 * 635580969) ^ 0x393D3714);
					continue;
				case 2u:
					flag = !bool_0;
					num = (int)(num2 * 651119132) ^ -1131780890;
					continue;
				case 1u:
					num = ((int)num2 * -581554158) ^ -153205838;
					continue;
				case 0u:
					GForm3.smethod_39((CancelEventArgs)(object)e, bool_1: true);
					num = ((int)num2 * -1558814323) ^ 0x695D0995;
					continue;
				default:
					return;
				case 5u:
					break;
				case 6u:
					return;
				}
				break;
			}
		}
	}

	public void method_4()
	{
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Invalid comparison between Unknown and I4
		bool flag2 = default(bool);
		bool flag = default(bool);
		while (true)
		{
			int num = 551383692;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x72DCA1E7u) % 21u)
				{
				case 20u:
					flag2 = !bool_0;
					num = (int)((num2 * 156893721) ^ 0xCDD5C29);
					continue;
				case 18u:
					num = ((int)num2 * -144582036) ^ -1119153852;
					continue;
				case 17u:
				{
					int num5;
					int num6;
					if (flag2)
					{
						num5 = 1253579082;
						num6 = 1253579082;
					}
					else
					{
						num5 = 1644154745;
						num6 = 1644154745;
					}
					num = num5 ^ (int)(num2 * 1114446938);
					continue;
				}
				case 16u:
					num = ((int)num2 * -381331477) ^ 0x7E2DA3DF;
					continue;
				case 15u:
					GForm3.smethod_38();
					num = ((int)num2 * -1971377775) ^ -468440125;
					continue;
				case 13u:
					GForm3.smethod_42((object)Timer_0);
					GForm3.smethod_42((object)bool_0);
					num = (int)(num2 * 916098648) ^ -246459438;
					continue;
				case 12u:
					GForm3.smethod_42((object)bool_0);
					num = ((int)num2 * -415625158) ^ -1955372905;
					continue;
				case 11u:
					num = 1848358317;
					continue;
				case 10u:
					GForm3.smethod_42((object)Timer_0);
					num = (int)(num2 * 1474310468) ^ -2043004753;
					continue;
				case 9u:
					GForm3.smethod_41(Timer_0);
					num = (int)((num2 * 1902835604) ^ 0x4D0581AF);
					continue;
				case 8u:
					GForm3.smethod_41(Timer_0);
					num = 251311770;
					continue;
				case 7u:
					num = ((int)num2 * -804160383) ^ 0x63ACEED6;
					continue;
				case 6u:
					num = ((int)num2 * -369685038) ^ 0x1CE4CE7A;
					continue;
				case 5u:
					flag = (int)GForm3.smethod_40("Sei sicuro di voler uscire dal gioco?", "The Omegle Game", (MessageBoxButtons)4, (MessageBoxIcon)32) == 6;
					num = (int)(num2 * 1710094650) ^ -1152560899;
					continue;
				case 4u:
					num = ((int)num2 * -2023131939) ^ -1236483395;
					continue;
				case 3u:
					GForm3.smethod_43(GForm3.smethod_35());
					num = (int)((num2 * 606600909) ^ 0x24711ED0);
					continue;
				case 2u:
					GForm3.smethod_38();
					num = (int)((num2 * 175426521) ^ 0x30FF2F81);
					continue;
				case 1u:
					num = (int)((num2 * 2042635165) ^ 0x37086AA2);
					continue;
				case 0u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = -1435475830;
						num4 = -1435475830;
					}
					else
					{
						num3 = -1126206353;
						num4 = -1126206353;
					}
					num = num3 ^ (int)(num2 * 1819642126);
					continue;
				}
				default:
					return;
				case 19u:
					break;
				case 14u:
					return;
				}
				break;
			}
		}
	}

	private void method_5(object sender, EventArgs e)
	{
		bool flag9 = default(bool);
		bool flag5 = default(bool);
		bool flag10 = default(bool);
		bool flag7 = default(bool);
		bool flag4 = default(bool);
		bool flag = default(bool);
		bool flag8 = default(bool);
		bool flag6 = default(bool);
		bool flag2 = default(bool);
		bool flag3 = default(bool);
		while (true)
		{
			int num = -1332509684;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xADC0494Cu) % 87u)
				{
				case 86u:
				{
					int num25;
					int num26;
					if (flag9)
					{
						num25 = -1646035452;
						num26 = -1646035452;
					}
					else
					{
						num25 = -1495330100;
						num26 = -1495330100;
					}
					num = num25 ^ (int)(num2 * 224712826);
					continue;
				}
				case 85u:
				{
					int num21;
					int num22;
					if (!flag5)
					{
						num21 = 1373487145;
						num22 = 1373487145;
					}
					else
					{
						num21 = 1631755942;
						num22 = 1631755942;
					}
					num = num21 ^ ((int)num2 * -1881376021);
					continue;
				}
				case 84u:
					flag10 = int_0 == 3;
					num = -1041782148;
					continue;
				case 83u:
					num = (int)(num2 * 1119984033) ^ -898504124;
					continue;
				case 82u:
					GForm3.smethod_17(Label_0, "Queste persone trascorrono il loro tempo libero, la loro\r\nintera vita su Omegle, con gli altri.");
					num = (int)((num2 * 1813908166) ^ 0x638C9577);
					continue;
				case 81u:
					num = ((int)num2 * -1047927409) ^ 0x751D26D5;
					continue;
				case 80u:
					num = ((int)num2 * -2117378612) ^ -607846588;
					continue;
				case 79u:
					GForm3.smethod_17(Label_0, "Insieme a questo mago e ai suoi fantastici amici, \r\npercorrerai tutta la strada di Omegle.");
					num = ((int)num2 * -1000148721) ^ 0x45366E3C;
					continue;
				case 78u:
					num = ((int)num2 * -608380319) ^ 0x559F57E7;
					continue;
				case 77u:
					GForm3.smethod_17(Label_0, "Ma lui era solo un semplice mago, come poteva riuscire\r\nad affrontare le agonie contenute là dentro?");
					num = ((int)num2 * -2093559834) ^ 0x2C89C4D3;
					continue;
				case 76u:
					GForm3.smethod_17(Label_0, "Un mondo pieno di pedofili, maniaci, assassini, pazzi,\r\npersone pluripregiudicate e morti di figa...");
					num = ((int)num2 * -1795092067) ^ -579323935;
					continue;
				case 75u:
					num = ((int)num2 * -688686885) ^ 0x2909EFEA;
					continue;
				case 74u:
					num = (int)((num2 * 1307598036) ^ 0x7657B970);
					continue;
				case 73u:
					num = (int)(num2 * 2104379404) ^ -1464984651;
					continue;
				case 72u:
					flag7 = int_0 == 12;
					num = -1726467258;
					continue;
				case 71u:
					num = ((int)num2 * -326663906) ^ 0x5B2372BE;
					continue;
				case 70u:
				{
					int num19;
					int num20;
					if (int_0 != 1)
					{
						num19 = 791383329;
						num20 = 791383329;
					}
					else
					{
						num19 = 1603816531;
						num20 = 1603816531;
					}
					num = num19 ^ ((int)num2 * -1062709400);
					continue;
				}
				case 69u:
					num = ((int)num2 * -459819100) ^ -1024199763;
					continue;
				case 68u:
					num = ((int)num2 * -1945850143) ^ -788577122;
					continue;
				case 67u:
					GClass1.smethod_2().method_3();
					num = ((int)num2 * -343904354) ^ 0x5FFEA513;
					continue;
				case 66u:
					num = ((int)num2 * -213944567) ^ 0x5AB97F4A;
					continue;
				case 65u:
					num = (int)((num2 * 2085586593) ^ 0x48096295);
					continue;
				case 64u:
					num = ((int)num2 * -60247864) ^ 0x28CCE50A;
					continue;
				case 63u:
					num = (int)((num2 * 2135174140) ^ 0x7B0BC799);
					continue;
				case 62u:
				{
					int num10;
					int num11;
					if (!flag4)
					{
						num10 = 281258658;
						num11 = 281258658;
					}
					else
					{
						num10 = 1751469653;
						num11 = 1751469653;
					}
					num = num10 ^ (int)(num2 * 409251406);
					continue;
				}
				case 61u:
					GForm3.smethod_17(Label_0, "Così egli capii che c'era un solo modo di porre fine\r\nad ogni problema...");
					num = ((int)num2 * -1040663025) ^ -1988884628;
					continue;
				case 60u:
					num = ((int)num2 * -1938107742) ^ 0x22FE2E2D;
					continue;
				case 59u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = 1058909092;
						num5 = 1058909092;
					}
					else
					{
						num4 = 2068185962;
						num5 = 2068185962;
					}
					num = num4 ^ (int)(num2 * 888118050);
					continue;
				}
				case 58u:
					GForm3.smethod_45((Control)(object)Class2.Class3_0.GForm0_0);
					num = (int)((num2 * 87680591) ^ 0x52BDECA7);
					continue;
				case 57u:
					GForm3.smethod_17(Label_0, "Sono delle persone che hanno delle grandissime capacità\r\nda disabili, ma non solo.");
					num = ((int)num2 * -2046956820) ^ 0x3B43063F;
					continue;
				case 56u:
					GForm3.smethod_17(Label_0, "In pochi sanno chi sono, ma lui riuscì a vedere di più:\r\nerano gli imperatori di Omegle.");
					num = ((int)num2 * -1302192601) ^ 0xAC9B0DE;
					continue;
				case 55u:
				{
					int num29;
					int num30;
					if (flag8)
					{
						num29 = 111480647;
						num30 = 111480647;
					}
					else
					{
						num29 = 171285828;
						num30 = 171285828;
					}
					num = num29 ^ ((int)num2 * -1761739973);
					continue;
				}
				case 54u:
					flag6 = int_0 == 9;
					num = -1325482505;
					continue;
				case 53u:
				{
					int num27;
					int num28;
					if (flag2)
					{
						num27 = 1581797188;
						num28 = 1581797188;
					}
					else
					{
						num27 = 557685091;
						num28 = 557685091;
					}
					num = num27 ^ (int)(num2 * 815867288);
					continue;
				}
				case 52u:
					num = ((int)num2 * -1657250173) ^ 0x78658B69;
					continue;
				case 51u:
					num = (int)(num2 * 1848482079) ^ -767442198;
					continue;
				case 50u:
					bool_0 = true;
					GClass1.smethod_2().method_3();
					num = ((int)num2 * -436818353) ^ -1699821528;
					continue;
				case 49u:
					num = (int)((num2 * 73213630) ^ 0x636CA6E1);
					continue;
				case 48u:
					num = (int)((num2 * 324745744) ^ 0x3A353C12);
					continue;
				case 47u:
				{
					int num23;
					int num24;
					if (!flag10)
					{
						num23 = 200142982;
						num24 = 200142982;
					}
					else
					{
						num23 = 767082131;
						num24 = 767082131;
					}
					num = num23 ^ ((int)num2 * -21816997);
					continue;
				}
				case 46u:
					flag9 = int_0 == 5;
					num = -316651667;
					continue;
				case 45u:
					GForm3.smethod_17(Label_0, "Purtroppo la noia è una droga molto cancerosa, ed egli\r\nsi mise alla ricerca di nuove avventure.");
					num = ((int)num2 * -1551266337) ^ 0x2829D710;
					continue;
				case 44u:
					num = ((int)num2 * -1833549382) ^ 0x658C643A;
					continue;
				case 43u:
				{
					int num17;
					int num18;
					if (int_1 != 0)
					{
						num17 = 1124645498;
						num18 = 1124645498;
					}
					else
					{
						num17 = 549348646;
						num18 = 549348646;
					}
					num = num17 ^ (int)(num2 * 1869197526);
					continue;
				}
				case 42u:
					flag8 = int_0 == 15;
					num = -2034086368;
					continue;
				case 41u:
					GForm3.smethod_17(Label_0, "Ma non riuscì bene ad orientarsi... c'era tante persone\r\nche gli ostacolavano il cammino...");
					num = (int)(num2 * 1203490167) ^ -1830188371;
					continue;
				case 40u:
				{
					int num15;
					int num16;
					if (flag7)
					{
						num15 = 808196625;
						num16 = 808196625;
					}
					else
					{
						num15 = 1553848272;
						num16 = 1553848272;
					}
					num = num15 ^ ((int)num2 * -756027751);
					continue;
				}
				case 39u:
					num = (int)(num2 * 1657014502) ^ -1604886738;
					continue;
				case 38u:
					num = -1735931040;
					continue;
				case 37u:
					num = (int)((num2 * 1948934373) ^ 0x6788728F);
					continue;
				case 36u:
					GClass1.smethod_2().method_4();
					num = ((int)num2 * -1980474115) ^ 0x403D37E6;
					continue;
				case 35u:
					num = ((int)num2 * -1328454969) ^ 0x87C0AB7;
					continue;
				case 34u:
					num = (int)(num2 * 1192819114) ^ -2109234604;
					continue;
				case 33u:
					num = -901875092;
					continue;
				case 32u:
					num = ((int)num2 * -913257490) ^ 0xFC6C81B;
					continue;
				case 31u:
					flag = int_0 == 13;
					num = -598135342;
					continue;
				case 30u:
					num = ((int)num2 * -645580789) ^ -280411517;
					continue;
				case 29u:
				{
					int num14;
					if (int_0 != 8)
					{
						num = -31136682;
						num14 = -31136682;
					}
					else
					{
						num = -269221893;
						num14 = -269221893;
					}
					continue;
				}
				case 28u:
					GForm3.smethod_46((Form)(object)this);
					num = (int)(num2 * 1799279548) ^ -956306847;
					continue;
				case 27u:
					GForm3.smethod_13((Control)(object)Label_0, new Point(checked(GForm3.smethod_44((Control)(object)Label_0).X + 60), GForm3.smethod_44((Control)(object)Label_0).Y));
					num = (int)(num2 * 957332326) ^ -1114164050;
					continue;
				case 26u:
					num = ((int)num2 * -417803594) ^ 0x51124C4;
					continue;
				case 24u:
				{
					int num12;
					int num13;
					if (!flag6)
					{
						num12 = 781583559;
						num13 = 781583559;
					}
					else
					{
						num12 = 1229195171;
						num13 = 1229195171;
					}
					num = num12 ^ (int)(num2 * 1731194213);
					continue;
				}
				case 23u:
					GForm3.smethod_17(Label_0, "Che il gioco abbia inizio!");
					num = (int)(num2 * 1028627927) ^ -1692012253;
					continue;
				case 22u:
					flag3 = int_0 == 6;
					num = -76881727;
					continue;
				case 21u:
					flag5 = int_0 == 14;
					num = -1290428786;
					continue;
				case 20u:
					flag4 = int_0 == 11;
					num = -1795492445;
					continue;
				case 19u:
					GForm3.smethod_17(Label_0, "Il mago e i suoi amici sono sempre pronti ad affrontare\r\nogni nuova sfida ed ogni pericolo.");
					num = (int)((num2 * 645766930) ^ 0x474D2025);
					continue;
				case 18u:
					GForm3.smethod_17(Label_0, "Egli poteva fare trucchi di magia con le carte e con i\r\ncubi agli sconosciuti... Bello, no?");
					num = (int)(num2 * 1516857410) ^ -920653470;
					continue;
				case 17u:
				{
					int num8;
					int num9;
					if (flag3)
					{
						num8 = -1225295941;
						num9 = -1225295941;
					}
					else
					{
						num8 = -1973148943;
						num9 = -1973148943;
					}
					num = num8 ^ (int)(num2 * 608606266);
					continue;
				}
				case 16u:
					num = (int)((num2 * 39791058) ^ 0x50ABEE1C);
					continue;
				case 15u:
					GForm3.smethod_17(Label_0, "Non sapeva bene cosa lo attendeva, ma sapeva bene che\r\n era un grande pericolo intrufolarsi là dentro.");
					num = (int)(num2 * 999239334) ^ -1815283731;
					continue;
				case 14u:
					num = ((int)num2 * -465433777) ^ -383620718;
					continue;
				case 13u:
					flag2 = int_0 == 10;
					num = -997523594;
					continue;
				case 12u:
					checked
					{
						int_0++;
					}
					num = (int)(num2 * 623547103) ^ -1446773395;
					continue;
				case 11u:
					GForm3.smethod_17(Label_0, "E il mago pian piano, nel suo tortuoso cammino,\r\nne trovò tanti di tali imperatori.");
					num = ((int)num2 * -356145597) ^ -1142216530;
					continue;
				case 10u:
					GForm3.smethod_17(Label_0, "Un mago molto misterioso, dagli oscuri segreti... andò\r\nsu OmeTV, quella sera.");
					num = ((int)num2 * -55461156) ^ -1482906115;
					continue;
				case 9u:
				{
					int num7;
					if (int_0 == 2)
					{
						num = -2121024488;
						num7 = -2121024488;
					}
					else
					{
						num = -2033557181;
						num7 = -2033557181;
					}
					continue;
				}
				case 8u:
					num = -1811868284;
					continue;
				case 7u:
					num = (int)(num2 * 933202707) ^ -616330092;
					continue;
				case 6u:
					GClass1.smethod_2().method_0();
					num = ((int)num2 * -267249517) ^ 0x53454E26;
					continue;
				case 5u:
					num = (int)((num2 * 146012050) ^ 0x73033ED2);
					continue;
				case 4u:
				{
					int num6;
					if (int_0 == 7)
					{
						num = -1638094169;
						num6 = -1638094169;
					}
					else
					{
						num = -1926489463;
						num6 = -1926489463;
					}
					continue;
				}
				case 3u:
				{
					int num3;
					if (int_0 != 4)
					{
						num = -538001834;
						num3 = -538001834;
					}
					else
					{
						num = -151878731;
						num3 = -151878731;
					}
					continue;
				}
				case 1u:
					num = ((int)num2 * -1307203710) ^ -2116955664;
					continue;
				case 0u:
					num = (int)(num2 * 227466333) ^ -1722362285;
					continue;
				default:
					return;
				case 2u:
					break;
				case 25u:
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
