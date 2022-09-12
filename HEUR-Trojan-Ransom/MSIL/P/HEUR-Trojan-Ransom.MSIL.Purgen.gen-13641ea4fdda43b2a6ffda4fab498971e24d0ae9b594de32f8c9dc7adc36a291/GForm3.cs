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
			if (val != null)
			{
				goto IL_003c;
			}
			goto IL_0088;
			IL_0088:
			timer_0 = value;
			val = timer_0;
			int num;
			int num2;
			if (val != null)
			{
				num = -1390957724;
				num2 = -1390957724;
			}
			else
			{
				num = -1804225576;
				num2 = -1804225576;
			}
			goto IL_0057;
			IL_0057:
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num ^ 0xD0B8B5D0u) % 5u)
				{
				case 4u:
					GForm3.smethod_33(val, eventHandler_);
					num = ((int)num3 * -1348546686) ^ 0x553CB123;
					continue;
				case 3u:
					break;
				case 0u:
					GForm3.smethod_34(val, eventHandler_);
					num = ((int)num3 * -973401203) ^ 0x4342F6FC;
					continue;
				default:
					return;
				case 1u:
					goto IL_0088;
				case 2u:
					return;
				}
				break;
			}
			goto IL_003c;
			IL_003c:
			num = -1322137889;
			goto IL_0057;
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
				int num = -2023163452;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xEC539F27u) % 7u)
					{
					case 6u:
						val = timer_1;
						num = ((int)num2 * -1805250438) ^ -1504058717;
						continue;
					case 5u:
					{
						timer_1 = value;
						val = timer_1;
						int num5;
						if (val != null)
						{
							num = -1341692072;
							num5 = -1341692072;
						}
						else
						{
							num = -1338957975;
							num5 = -1338957975;
						}
						continue;
					}
					case 4u:
					{
						int num3;
						int num4;
						if (val != null)
						{
							num3 = -250866391;
							num4 = -250866391;
						}
						else
						{
							num3 = -523124739;
							num4 = -523124739;
						}
						num = num3 ^ (int)(num2 * 609420273);
						continue;
					}
					case 1u:
						GForm3.smethod_33(val, eventHandler_);
						num = ((int)num2 * -1944128576) ^ -2061655049;
						continue;
					case 0u:
						GForm3.smethod_34(val, eventHandler_);
						num = (int)(num2 * 1303657473) ^ -2098224362;
						continue;
					default:
						return;
					case 2u:
						break;
					case 3u:
						return;
					}
					break;
				}
			}
		}
	}

	public GForm3()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		while (true)
		{
			int num = -1796050162;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB9B950FCu) % 8u)
				{
				case 7u:
					GForm3.smethod_1((Form)(object)this, new FormClosingEventHandler(method_3));
					num = (int)(num2 * 1863773145) ^ -1368027945;
					continue;
				case 6u:
					bool_0 = false;
					int_0 = 0;
					num = ((int)num2 * -505228800) ^ 0x97F281;
					continue;
				case 5u:
					int_1 = 0;
					method_0();
					num = ((int)num2 * -1954405085) ^ -1773400720;
					continue;
				case 4u:
					num = (int)((num2 * 973034035) ^ 0x26B7993E);
					continue;
				case 2u:
					num = (int)((num2 * 120758459) ^ 0x3575CCB3);
					continue;
				case 1u:
					GForm3.smethod_0((Form)(object)this, (EventHandler)method_1);
					num = (int)((num2 * 1813967280) ^ 0x4D2EB3A3);
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
			if (disposing)
			{
				goto IL_002e;
			}
			goto IL_005f;
			IL_002e:
			int num = -202776462;
			goto IL_0033;
			IL_0033:
			int num3;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB78E0CB7u) % 4u)
				{
				case 2u:
					GForm3.smethod_2((IDisposable)icontainer_0);
					num = (int)(num2 * 802726958) ^ -361118128;
					continue;
				case 0u:
					break;
				default:
					return;
				case 1u:
					goto IL_0054;
				case 3u:
					return;
				}
				break;
				IL_0054:
				if (icontainer_0 != null)
				{
					num = -2057147655;
					num3 = -2057147655;
					continue;
				}
				goto IL_005f;
			}
			goto IL_002e;
			IL_005f:
			num = -777151404;
			num3 = -777151404;
			goto IL_0033;
		}
		finally
		{
			((Form)this).Dispose(disposing);
		}
	}

	[DebuggerStepThrough]
	private void method_0()
	{
		//IL_0271: Unknown result type (might be due to invalid IL or missing references)
		icontainer_0 = GForm3.smethod_3();
		Timer_0 = GForm3.smethod_4(icontainer_0);
		while (true)
		{
			int num = 977157299;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1047A284u) % 36u)
				{
				case 34u:
					GForm3.smethod_24(GForm3.smethod_23((Control)(object)this), (Control)(object)Label_0);
					num = ((int)num2 * -1219415919) ^ -1773198460;
					continue;
				case 33u:
					GForm3.smethod_16((Control)(object)Label_0, 0);
					num = ((int)num2 * -1439360901) ^ -1916165741;
					continue;
				case 32u:
					num = ((int)num2 * -799884892) ^ -503476724;
					continue;
				case 31u:
					GForm3.smethod_20((Form)(object)this, Color.White);
					num = (int)(num2 * 391450440) ^ -356942273;
					continue;
				case 30u:
					Label_0 = GForm3.smethod_5();
					num = (int)((num2 * 1386799017) ^ 0x68A91D75);
					continue;
				case 29u:
					GForm3.smethod_22((Form)(object)this, new Size(1025, 638));
					num = ((int)num2 * -1486625099) ^ -411184954;
					continue;
				case 28u:
					GForm3.smethod_17(Label_0, "Tutto ebbe inizio in un freddo giorno d'inverno...");
					GForm3.smethod_7(Timer_1, 6000);
					GForm3.smethod_18((ContainerControl)(object)this, new SizeF(10f, 22f));
					GForm3.smethod_19((ContainerControl)(object)this, (AutoScaleMode)1);
					num = (int)((num2 * 1264186637) ^ 0x51E831B);
					continue;
				case 27u:
					num = (int)((num2 * 579621433) ^ 0x4FFE6EC2);
					continue;
				case 26u:
					num = ((int)num2 * -565442391) ^ 0x6388E8B7;
					continue;
				case 25u:
					GForm3.smethod_11((Control)(object)Label_0, GForm3.smethod_10("Microsoft Sans Serif", 24f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1762074363) ^ 0x68814CF2;
					continue;
				case 24u:
					GForm3.smethod_9((Control)(object)Label_0, Color.Transparent);
					num = ((int)num2 * -609389991) ^ -610509055;
					continue;
				case 23u:
					num = (int)(num2 * 1349102425) ^ -1070533337;
					continue;
				case 22u:
					GForm3.smethod_32((Control)(object)this);
					num = ((int)num2 * -1080142852) ^ -621627116;
					continue;
				case 21u:
					GForm3.smethod_11((Control)(object)this, GForm3.smethod_10("Consolas", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1582271635) ^ -1839526021;
					continue;
				case 19u:
					num = (int)(num2 * 1991151720) ^ -1782189270;
					continue;
				case 18u:
					num = (int)(num2 * 229942716) ^ -1922295606;
					continue;
				case 17u:
					GForm3.smethod_15((Control)(object)Label_0, new Size(862, 46));
					num = ((int)num2 * -500826889) ^ -498234182;
					continue;
				case 16u:
					GForm3.smethod_30((Form)(object)this, "The Omegle Game");
					num = (int)(num2 * 1930848422) ^ -1688132888;
					continue;
				case 15u:
					GForm3.smethod_21((Control)(object)this, (ImageLayout)3);
					num = (int)(num2 * 892834796) ^ -568996349;
					continue;
				case 14u:
					GForm3.smethod_26((Form)(object)this, new Padding(4));
					num = (int)((num2 * 560912483) ^ 0x44712491);
					continue;
				case 13u:
					GForm3.smethod_6((Control)(object)this);
					num = (int)(num2 * 55070679) ^ -1786605302;
					continue;
				case 12u:
					GForm3.smethod_29((Form)(object)this, (FormStartPosition)1);
					num = ((int)num2 * -1932508862) ^ -1628321114;
					continue;
				case 11u:
					num = (int)(num2 * 10700223) ^ -1240117025;
					continue;
				case 10u:
					GForm3.smethod_25((Form)(object)this, (FormBorderStyle)1);
					num = (int)(num2 * 562216662) ^ -1667338366;
					continue;
				case 9u:
					num = ((int)num2 * -242573134) ^ -1710109917;
					continue;
				case 8u:
					GForm3.smethod_31((Control)(object)this, bool_1: false);
					num = ((int)num2 * -891891630) ^ -309407574;
					continue;
				case 7u:
					Timer_1 = GForm3.smethod_4(icontainer_0);
					num = ((int)num2 * -1299891227) ^ 0x41EDB936;
					continue;
				case 6u:
					num = (int)((num2 * 1376484329) ^ 0x211A894E);
					continue;
				case 5u:
					num = (int)(num2 * 1074914844) ^ -1312005507;
					continue;
				case 4u:
					GForm3.smethod_27((Form)(object)this, bool_1: false);
					num = (int)((num2 * 1801964596) ^ 0x541122D0);
					continue;
				case 3u:
					GForm3.smethod_12((Control)(object)Label_0, Color.White);
					GForm3.smethod_13((Control)(object)Label_0, new Point(111, 270));
					GForm3.smethod_14((Control)(object)Label_0, "Label1");
					num = (int)(num2 * 480236220) ^ -1913131443;
					continue;
				case 2u:
					((Control)this).set_DoubleBuffered(true);
					num = ((int)num2 * -1673969807) ^ -2091381064;
					continue;
				case 1u:
					GForm3.smethod_7(Timer_0, 1000);
					GForm3.smethod_8(Label_0, bool_1: true);
					num = ((int)num2 * -273417359) ^ 0x4C7A303D;
					continue;
				case 0u:
					GForm3.smethod_28((Control)(object)this, "StoryMode");
					num = (int)(num2 * 631947495) ^ -430562732;
					continue;
				default:
					return;
				case 35u:
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
		while (true)
		{
			int num = 88170931;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x56F56DC9u) % 11u)
				{
				case 10u:
					GForm3.smethod_17(Label_0, "Tutto ebbe inizio in un freddo giorno d'inverno...");
					num = ((int)num2 * -177324535) ^ -768266005;
					continue;
				case 8u:
					GClass1.smethod_2().method_0();
					num = (int)(num2 * 1025940719) ^ -1432232848;
					continue;
				case 6u:
				{
					int num3;
					int num4;
					if (int_1 == 0)
					{
						num3 = -948411693;
						num4 = -948411693;
					}
					else
					{
						num3 = -940243614;
						num4 = -940243614;
					}
					num = num3 ^ (int)(num2 * 2033070346);
					continue;
				}
				case 5u:
					num = ((int)num2 * -475432792) ^ -2117032512;
					continue;
				case 4u:
					GForm3.smethod_36(GForm3.smethod_35(), ProcessPriorityClass.RealTime);
					num = (int)(num2 * 455446851) ^ -113210697;
					continue;
				case 3u:
					num = ((int)num2 * -1497589090) ^ 0x30C87A02;
					continue;
				case 2u:
					GForm3.smethod_37(Timer_1);
					num = (int)((num2 * 918943962) ^ 0x1BCC145C);
					continue;
				case 1u:
					GForm3.smethod_37(Timer_0);
					num = (int)(num2 * 1171659735) ^ -1776315898;
					continue;
				case 0u:
					num = (int)(num2 * 1997527184) ^ -1421660884;
					continue;
				default:
					return;
				case 7u:
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
		GForm3.smethod_38();
	}

	private void method_3(object sender, FormClosingEventArgs e)
	{
		while (true)
		{
			int num = -478142513;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x80A1B0BBu) % 7u)
				{
				case 6u:
					num = ((int)num2 * -1547461299) ^ -1475062498;
					continue;
				case 5u:
					GForm3.smethod_39((CancelEventArgs)(object)e, bool_1: true);
					num = ((int)num2 * -1436925233) ^ -1036035020;
					continue;
				case 3u:
					num = -3150312;
					continue;
				case 1u:
					method_4();
					num = ((int)num2 * -1027477285) ^ 0x3CCDB7D;
					continue;
				case 0u:
				{
					int num3;
					int num4;
					if (!bool_0)
					{
						num3 = -495361488;
						num4 = -495361488;
					}
					else
					{
						num3 = -297616121;
						num4 = -297616121;
					}
					num = num3 ^ (int)(num2 * 1995117937);
					continue;
				}
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

	public void method_4()
	{
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Invalid comparison between Unknown and I4
		bool flag = default(bool);
		while (true)
		{
			int num = -203171796;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB1EEA7F4u) % 22u)
				{
				case 21u:
					GForm3.smethod_41(Timer_0);
					num = (int)(num2 * 419386447) ^ -396672818;
					continue;
				case 20u:
					GForm3.smethod_41(Timer_0);
					GForm3.smethod_42((object)Timer_0);
					num = (int)(num2 * 688161641) ^ -802450576;
					continue;
				case 19u:
					num = (int)((num2 * 1003737058) ^ 0x76C33017);
					continue;
				case 18u:
				{
					int num5;
					int num6;
					if ((int)GForm3.smethod_40("Sei sicuro di voler uscire dal gioco?", "The Omegle Game", (MessageBoxButtons)4, (MessageBoxIcon)32) == 6)
					{
						num5 = 864387313;
						num6 = 864387313;
					}
					else
					{
						num5 = 317968304;
						num6 = 317968304;
					}
					num = num5 ^ ((int)num2 * -1492973362);
					continue;
				}
				case 17u:
					num = (int)(num2 * 1918908703) ^ -241972433;
					continue;
				case 16u:
					num = (int)((num2 * 1072862244) ^ 0x71F96D55);
					continue;
				case 15u:
					num = (int)((num2 * 980918314) ^ 0x6B2876AB);
					continue;
				case 14u:
					num = -76890753;
					continue;
				case 13u:
					GForm3.smethod_42((object)Timer_0);
					num = ((int)num2 * -1712657116) ^ -393391897;
					continue;
				case 12u:
					num = -1289756878;
					continue;
				case 11u:
					GForm3.smethod_38();
					num = (int)(num2 * 871429715) ^ -1596041625;
					continue;
				case 10u:
					flag = !bool_0;
					num = ((int)num2 * -791365399) ^ -1928857869;
					continue;
				case 9u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = -608267178;
						num4 = -608267178;
					}
					else
					{
						num3 = -922002682;
						num4 = -922002682;
					}
					num = num3 ^ (int)(num2 * 203411888);
					continue;
				}
				case 8u:
					GForm3.smethod_38();
					GForm3.smethod_43(GForm3.smethod_35());
					num = ((int)num2 * -225022050) ^ -2058289934;
					continue;
				case 7u:
					num = (int)(num2 * 1553334909) ^ -1619575070;
					continue;
				case 5u:
					GForm3.smethod_42((object)bool_0);
					num = ((int)num2 * -1764999347) ^ 0xC756EF5;
					continue;
				case 4u:
					GForm3.smethod_42((object)bool_0);
					num = (int)(num2 * 1500270096) ^ -594892925;
					continue;
				case 3u:
					num = (int)(num2 * 252092784) ^ -965289040;
					continue;
				case 1u:
					num = ((int)num2 * -986745142) ^ 0x5125EBE6;
					continue;
				case 0u:
					num = ((int)num2 * -838832857) ^ 0x5F2252F3;
					continue;
				default:
					return;
				case 2u:
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
		bool flag9 = default(bool);
		bool flag4 = default(bool);
		bool flag6 = default(bool);
		bool flag8 = default(bool);
		bool flag5 = default(bool);
		bool flag10 = default(bool);
		bool flag11 = default(bool);
		bool flag = default(bool);
		bool flag7 = default(bool);
		bool flag2 = default(bool);
		while (true)
		{
			int num = -2118670847;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA39BCCBEu) % 79u)
				{
				case 78u:
					num = (int)((num2 * 527016678) ^ 0x15579CC3);
					continue;
				case 77u:
					num = ((int)num2 * -413676839) ^ 0x6F124797;
					continue;
				case 76u:
					flag3 = int_0 == 2;
					num = -1996606262;
					continue;
				case 75u:
					checked
					{
						int_0++;
						flag9 = int_1 == 0;
					}
					num = (int)((num2 * 1566869843) ^ 0x38C34D44);
					continue;
				case 73u:
					num = (int)((num2 * 623313080) ^ 0x5BD0790D);
					continue;
				case 72u:
				{
					int num12;
					int num13;
					if (flag4)
					{
						num12 = -1120812593;
						num13 = -1120812593;
					}
					else
					{
						num12 = -224983960;
						num13 = -224983960;
					}
					num = num12 ^ (int)(num2 * 167474832);
					continue;
				}
				case 71u:
					flag6 = int_0 == 13;
					num = -567218307;
					continue;
				case 70u:
					GClass1.smethod_2().method_3();
					GClass1.smethod_2().method_0();
					num = (int)((num2 * 363542458) ^ 0x7074F16B);
					continue;
				case 69u:
					GForm3.smethod_17(Label_0, "Queste persone trascorrono il loro tempo libero, la loro\r\nintera vita su Omegle, con gli altri.");
					num = ((int)num2 * -581301514) ^ 0x7348D4B9;
					continue;
				case 68u:
					num = (int)(num2 * 48066339) ^ -2035474037;
					continue;
				case 67u:
					GForm3.smethod_17(Label_0, "Il mago e i suoi amici sono sempre pronti ad affrontare\r\nogni nuova sfida ed ogni pericolo.");
					num = ((int)num2 * -1218060357) ^ 0x5A727E37;
					continue;
				case 66u:
					flag8 = int_0 == 15;
					num = -42850769;
					continue;
				case 65u:
					num = ((int)num2 * -159450876) ^ -1697394187;
					continue;
				case 64u:
					GForm3.smethod_17(Label_0, "E il mago pian piano, nel suo tortuoso cammino,\r\nne trovò tanti di tali imperatori.");
					num = ((int)num2 * -2002096102) ^ 0x3C18B9D5;
					continue;
				case 63u:
					GClass1.smethod_2().method_3();
					num = (int)((num2 * 1626478421) ^ 0x5C1D7530);
					continue;
				case 62u:
					num = (int)((num2 * 294592099) ^ 0x5B7E926);
					continue;
				case 61u:
				{
					int num22;
					int num23;
					if (!flag5)
					{
						num22 = -1247485902;
						num23 = -1247485902;
					}
					else
					{
						num22 = -1877394499;
						num23 = -1877394499;
					}
					num = num22 ^ (int)(num2 * 1809814755);
					continue;
				}
				case 60u:
					num = -966742517;
					continue;
				case 59u:
				{
					int num19;
					if (int_0 != 11)
					{
						num = -730474517;
						num19 = -730474517;
					}
					else
					{
						num = -1164050967;
						num19 = -1164050967;
					}
					continue;
				}
				case 58u:
					num = ((int)num2 * -1476921404) ^ 0x419FDF7D;
					continue;
				case 57u:
					num = (int)((num2 * 1382591667) ^ 0xD8AD42B);
					continue;
				case 56u:
					GForm3.smethod_17(Label_0, "Egli poteva fare trucchi di magia con le carte e con i\r\ncubi agli sconosciuti... Bello, no?");
					num = (int)(num2 * 2050845599) ^ -758665701;
					continue;
				case 55u:
					GForm3.smethod_17(Label_0, "In pochi sanno chi sono, ma lui riuscì a vedere di più:\r\nerano gli imperatori di Omegle.");
					num = ((int)num2 * -1898125494) ^ 0x56B4F117;
					continue;
				case 54u:
					flag10 = int_0 == 4;
					num = -1121233244;
					continue;
				case 53u:
					GForm3.smethod_13((Control)(object)Label_0, new Point(checked(GForm3.smethod_44((Control)(object)Label_0).X + 60), GForm3.smethod_44((Control)(object)Label_0).Y));
					num = ((int)num2 * -282266816) ^ 0x2BE4FCED;
					continue;
				case 52u:
					num = ((int)num2 * -949855862) ^ -1545338269;
					continue;
				case 51u:
				{
					int num9;
					if (int_0 == 10)
					{
						num = -669541471;
						num9 = -669541471;
					}
					else
					{
						num = -447331189;
						num9 = -447331189;
					}
					continue;
				}
				case 50u:
					GForm3.smethod_45((Control)(object)Class2.Class3_0.GForm0_0);
					num = (int)(num2 * 1445497034) ^ -7909292;
					continue;
				case 49u:
					num = (int)(num2 * 1404341646) ^ -1827475153;
					continue;
				case 48u:
					num = (int)(num2 * 1941613561) ^ -1125408398;
					continue;
				case 47u:
					flag5 = int_0 == 3;
					num = -1281560075;
					continue;
				case 46u:
					num = (int)(num2 * 1154199387) ^ -1988317102;
					continue;
				case 45u:
					num = ((int)num2 * -741912359) ^ -1141835450;
					continue;
				case 44u:
					num = (int)(num2 * 990275911) ^ -1137334857;
					continue;
				case 43u:
					flag11 = int_0 == 5;
					num = -1998472407;
					continue;
				case 42u:
					GForm3.smethod_17(Label_0, "Ma non riuscì bene ad orientarsi... c'era tante persone\r\nche gli ostacolavano il cammino...");
					num = ((int)num2 * -1043097838) ^ -1517333026;
					continue;
				case 41u:
				{
					int num29;
					int num30;
					if (!flag)
					{
						num29 = 1171085479;
						num30 = 1171085479;
					}
					else
					{
						num29 = 619339555;
						num30 = 619339555;
					}
					num = num29 ^ ((int)num2 * -190624388);
					continue;
				}
				case 40u:
				{
					int num28;
					if (int_0 == 6)
					{
						num = -811472307;
						num28 = -811472307;
					}
					else
					{
						num = -1336521631;
						num28 = -1336521631;
					}
					continue;
				}
				case 39u:
					num = ((int)num2 * -1255265965) ^ -142586436;
					continue;
				case 38u:
				{
					int num26;
					int num27;
					if (flag7)
					{
						num26 = -1108767006;
						num27 = -1108767006;
					}
					else
					{
						num26 = -22126132;
						num27 = -22126132;
					}
					num = num26 ^ ((int)num2 * -1520730826);
					continue;
				}
				case 37u:
					GForm3.smethod_17(Label_0, "Purtroppo la noia è una droga molto cancerosa, ed egli\r\nsi mise alla ricerca di nuove avventure.");
					num = ((int)num2 * -2129197757) ^ -291889766;
					continue;
				case 36u:
					num = ((int)num2 * -223422199) ^ 0x280E644;
					continue;
				case 35u:
					GForm3.smethod_17(Label_0, "Insieme a questo mago e ai suoi fantastici amici, \r\npercorrerai tutta la strada di Omegle.");
					num = ((int)num2 * -389810654) ^ 0x13556D13;
					continue;
				case 34u:
					num = (int)((num2 * 785732911) ^ 0x64459341);
					continue;
				case 33u:
					num = ((int)num2 * -760416499) ^ 0x45D5AB04;
					continue;
				case 32u:
				{
					int num24;
					int num25;
					if (flag11)
					{
						num24 = -136065330;
						num25 = -136065330;
					}
					else
					{
						num24 = -1204856452;
						num25 = -1204856452;
					}
					num = num24 ^ ((int)num2 * -1829255285);
					continue;
				}
				case 31u:
					bool_0 = true;
					num = -1704236680;
					continue;
				case 30u:
					num = (int)((num2 * 1795827381) ^ 0x399B7897);
					continue;
				case 29u:
					num = (int)((num2 * 1941579005) ^ 0x19780C5A);
					continue;
				case 28u:
					num = (int)((num2 * 602017869) ^ 0x1109F3E5);
					continue;
				case 27u:
					GForm3.smethod_17(Label_0, "Che il gioco abbia inizio!");
					num = ((int)num2 * -1190888854) ^ -99171360;
					continue;
				case 26u:
					GForm3.smethod_17(Label_0, "Un mago molto misterioso, dagli oscuri segreti... andò\r\nsu OmeTV, quella sera.");
					num = ((int)num2 * -928095478) ^ -54461564;
					continue;
				case 25u:
					num = ((int)num2 * -902210431) ^ 0x46BAEE93;
					continue;
				case 24u:
				{
					int num20;
					int num21;
					if (!flag10)
					{
						num20 = -1803020616;
						num21 = -1803020616;
					}
					else
					{
						num20 = -1745282549;
						num21 = -1745282549;
					}
					num = num20 ^ (int)(num2 * 91095034);
					continue;
				}
				case 23u:
					num = (int)((num2 * 92514660) ^ 0x2AB474C1);
					continue;
				case 22u:
				{
					int num17;
					int num18;
					if (flag2)
					{
						num17 = -1941473601;
						num18 = -1941473601;
					}
					else
					{
						num17 = -499788251;
						num18 = -499788251;
					}
					num = num17 ^ (int)(num2 * 1017685055);
					continue;
				}
				case 21u:
					GForm3.smethod_17(Label_0, "Sono delle persone che hanno delle grandissime capacità\r\nda disabili, ma non solo.");
					num = (int)(num2 * 387466275) ^ -1784566129;
					continue;
				case 20u:
					num = (int)((num2 * 821854541) ^ 0x5BF01921);
					continue;
				case 19u:
					GClass1.smethod_2().method_4();
					num = ((int)num2 * -269593599) ^ -455546936;
					continue;
				case 18u:
					GForm3.smethod_17(Label_0, "Non sapeva bene cosa lo attendeva, ma sapeva bene che\r\n era un grande pericolo intrufolarsi là dentro.");
					num = (int)(num2 * 778871837) ^ -1691147127;
					continue;
				case 17u:
				{
					int num16;
					if (int_0 != 14)
					{
						num = -483252899;
						num16 = -483252899;
					}
					else
					{
						num = -695814197;
						num16 = -695814197;
					}
					continue;
				}
				case 16u:
					num = (int)((num2 * 1130421083) ^ 0x2962FC96);
					continue;
				case 15u:
				{
					int num14;
					int num15;
					if (!flag9)
					{
						num14 = 493290530;
						num15 = 493290530;
					}
					else
					{
						num14 = 595980614;
						num15 = 595980614;
					}
					num = num14 ^ (int)(num2 * 1175794879);
					continue;
				}
				case 14u:
				{
					int num10;
					int num11;
					if (flag8)
					{
						num10 = 2110976433;
						num11 = 2110976433;
					}
					else
					{
						num10 = 800406958;
						num11 = 800406958;
					}
					num = num10 ^ ((int)num2 * -1357271528);
					continue;
				}
				case 13u:
					GForm3.smethod_17(Label_0, "Un mondo pieno di pedofili, maniaci, assassini, pazzi,\r\npersone pluripregiudicate e morti di figa...");
					num = (int)(num2 * 695015033) ^ -607574374;
					continue;
				case 12u:
					flag7 = int_0 == 8;
					num = -1841674308;
					continue;
				case 11u:
				{
					int num7;
					int num8;
					if (!flag6)
					{
						num7 = -55249258;
						num8 = -55249258;
					}
					else
					{
						num7 = -1319263255;
						num8 = -1319263255;
					}
					num = num7 ^ ((int)num2 * -1919001414);
					continue;
				}
				case 10u:
					num = (int)((num2 * 1923378037) ^ 0x71778152);
					continue;
				case 9u:
					GForm3.smethod_17(Label_0, "Così egli capii che c'era un solo modo di porre fine\r\nad ogni problema...");
					num = ((int)num2 * -877674007) ^ 0xF301DFD;
					continue;
				case 7u:
					GForm3.smethod_46((Form)(object)this);
					num = ((int)num2 * -2075360646) ^ -3579163;
					continue;
				case 6u:
				{
					int num5;
					int num6;
					if (int_0 != 1)
					{
						num5 = 1764219559;
						num6 = 1764219559;
					}
					else
					{
						num5 = 607676911;
						num6 = 607676911;
					}
					num = num5 ^ (int)(num2 * 1398135394);
					continue;
				}
				case 5u:
					GForm3.smethod_17(Label_0, "Ma lui era solo un semplice mago, come poteva riuscire\r\nad affrontare le agonie contenute là dentro?");
					num = ((int)num2 * -1235125730) ^ 0x29989666;
					continue;
				case 4u:
					flag4 = int_0 == 12;
					num = -35180261;
					continue;
				case 3u:
					num = (int)(num2 * 1761490355) ^ -1176407413;
					continue;
				case 2u:
				{
					int num3;
					int num4;
					if (flag3)
					{
						num3 = -833291661;
						num4 = -833291661;
					}
					else
					{
						num3 = -1204346723;
						num4 = -1204346723;
					}
					num = num3 ^ ((int)num2 * -2110735197);
					continue;
				}
				case 1u:
					flag2 = int_0 == 7;
					num = -1058198004;
					continue;
				case 0u:
					flag = int_0 == 9;
					num = -1570609353;
					continue;
				default:
					return;
				case 8u:
					break;
				case 74u:
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
