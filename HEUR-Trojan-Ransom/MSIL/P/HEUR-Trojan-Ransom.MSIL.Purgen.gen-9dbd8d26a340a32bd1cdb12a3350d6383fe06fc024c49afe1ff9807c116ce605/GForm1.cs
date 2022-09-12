using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

[DesignerGenerated]
public class GForm1 : Form
{
	private int int_0;

	private int int_1;

	private float float_0;

	private bool bool_0;

	private bool bool_1;

	private IContainer icontainer_0;

	private bool bool_2;

	[AccessedThroughProperty("PictureBox1")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private PictureBox pictureBox_0;

	[AccessedThroughProperty("FadeGame")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Timer timer_0;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("PictureBox2")]
	private PictureBox pictureBox_1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("PictureBox3")]
	private PictureBox pictureBox_2;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("PictureBox4")]
	private PictureBox pictureBox_3;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("PictureBox5")]
	[CompilerGenerated]
	private PictureBox pictureBox_4;

	[AccessedThroughProperty("MemoryCleaner")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Timer timer_1;

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
			EventHandler eventHandler_ = method_1;
			Timer val = timer_0;
			while (true)
			{
				int num = -857170090;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xD1C8F304u) % 7u)
					{
					case 5u:
					{
						int num5;
						int num6;
						if (val != null)
						{
							num5 = -1810689510;
							num6 = -1810689510;
						}
						else
						{
							num5 = -1817742572;
							num6 = -1817742572;
						}
						num = num5 ^ (int)(num2 * 2103258072);
						continue;
					}
					case 4u:
						GForm1.smethod_81(val, eventHandler_);
						num = ((int)num2 * -1162269053) ^ 0x4996F6D6;
						continue;
					case 3u:
						timer_0 = value;
						val = timer_0;
						num = -1218549306;
						continue;
					case 2u:
						GForm1.smethod_80(val, eventHandler_);
						num = (int)((num2 * 1797753331) ^ 0x5228DF8E);
						continue;
					case 1u:
					{
						int num3;
						int num4;
						if (val == null)
						{
							num3 = -1982616405;
							num4 = -1982616405;
						}
						else
						{
							num3 = -180302917;
							num4 = -180302917;
						}
						num = num3 ^ ((int)num2 * -1659190928);
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

	internal virtual PictureBox PictureBox_1
	{
		[CompilerGenerated]
		get
		{
			return pictureBox_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0115: Unknown result type (might be due to invalid IL or missing references)
			//IL_011b: Expected O, but got Unknown
			EventHandler eventHandler_ = method_2;
			EventHandler eventHandler_2 = method_3;
			PictureBox val = default(PictureBox);
			MouseEventHandler mouseEventHandler_ = default(MouseEventHandler);
			while (true)
			{
				int num = 1179642420;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x779D9CF0u) % 11u)
					{
					case 10u:
						GForm1.smethod_85((Control)(object)val, eventHandler_);
						num = (int)(num2 * 1900528767) ^ -212086245;
						continue;
					case 9u:
						GForm1.smethod_87((Control)(object)val, mouseEventHandler_);
						num = ((int)num2 * -502708908) ^ -755770030;
						continue;
					case 8u:
					{
						int num5;
						int num6;
						if (val != null)
						{
							num5 = 738644266;
							num6 = 738644266;
						}
						else
						{
							num5 = 2031991078;
							num6 = 2031991078;
						}
						num = num5 ^ (int)(num2 * 752662231);
						continue;
					}
					case 7u:
						val = pictureBox_1;
						num = (int)((num2 * 605807641) ^ 0x73BA064C);
						continue;
					case 5u:
						pictureBox_1 = value;
						num = 2064456229;
						continue;
					case 4u:
						GForm1.smethod_82((Control)(object)val, eventHandler_);
						GForm1.smethod_83((Control)(object)val, eventHandler_2);
						GForm1.smethod_84((Control)(object)val, mouseEventHandler_);
						num = (int)(num2 * 1850848689) ^ -865870484;
						continue;
					case 3u:
						GForm1.smethod_86((Control)(object)val, eventHandler_2);
						num = ((int)num2 * -479148030) ^ 0x23E9A4D0;
						continue;
					case 2u:
					{
						val = pictureBox_1;
						int num3;
						int num4;
						if (val == null)
						{
							num3 = -1595276350;
							num4 = -1595276350;
						}
						else
						{
							num3 = -221166627;
							num4 = -221166627;
						}
						num = num3 ^ ((int)num2 * -1094780144);
						continue;
					}
					case 1u:
						mouseEventHandler_ = new MouseEventHandler(method_4);
						num = ((int)num2 * -1239746704) ^ 0x114AF38D;
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

	internal virtual PictureBox PictureBox_2
	{
		[CompilerGenerated]
		get
		{
			return pictureBox_2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00dd: Expected O, but got Unknown
			EventHandler eventHandler_ = method_5;
			PictureBox val = default(PictureBox);
			MouseEventHandler mouseEventHandler_ = default(MouseEventHandler);
			EventHandler eventHandler_2 = default(EventHandler);
			while (true)
			{
				int num = -2091783344;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xF91F3A94u) % 11u)
					{
					case 9u:
					{
						int num5;
						int num6;
						if (val != null)
						{
							num5 = 1593783125;
							num6 = 1593783125;
						}
						else
						{
							num5 = 1828582258;
							num6 = 1828582258;
						}
						num = num5 ^ (int)(num2 * 1339342712);
						continue;
					}
					case 8u:
					{
						val = pictureBox_2;
						int num3;
						int num4;
						if (val != null)
						{
							num3 = 1275350867;
							num4 = 1275350867;
						}
						else
						{
							num3 = 216175878;
							num4 = 216175878;
						}
						num = num3 ^ ((int)num2 * -524598329);
						continue;
					}
					case 6u:
						pictureBox_2 = value;
						num = -1409593044;
						continue;
					case 5u:
						GForm1.smethod_87((Control)(object)val, mouseEventHandler_);
						num = ((int)num2 * -2048519285) ^ -1158777099;
						continue;
					case 4u:
						GForm1.smethod_85((Control)(object)val, eventHandler_);
						num = ((int)num2 * -434755240) ^ -416748310;
						continue;
					case 3u:
						GForm1.smethod_82((Control)(object)val, eventHandler_);
						GForm1.smethod_83((Control)(object)val, eventHandler_2);
						GForm1.smethod_84((Control)(object)val, mouseEventHandler_);
						num = ((int)num2 * -1252575200) ^ -1396025966;
						continue;
					case 2u:
						mouseEventHandler_ = new MouseEventHandler(method_7);
						val = pictureBox_2;
						num = ((int)num2 * -1700467492) ^ -1208265668;
						continue;
					case 1u:
						eventHandler_2 = method_6;
						num = ((int)num2 * -473810936) ^ 0xFC161F4;
						continue;
					case 0u:
						GForm1.smethod_86((Control)(object)val, eventHandler_2);
						num = (int)((num2 * 1204982907) ^ 0x66378097);
						continue;
					default:
						return;
					case 7u:
						break;
					case 10u:
						return;
					}
					break;
				}
			}
		}
	}

	internal virtual PictureBox PictureBox_3
	{
		[CompilerGenerated]
		get
		{
			return pictureBox_3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			//IL_001f: Expected O, but got Unknown
			EventHandler eventHandler_ = method_8;
			MouseEventHandler mouseEventHandler_ = default(MouseEventHandler);
			PictureBox val = default(PictureBox);
			EventHandler eventHandler_2 = default(EventHandler);
			while (true)
			{
				int num = -1855015885;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xBBC922D5u) % 14u)
					{
					case 12u:
						mouseEventHandler_ = new MouseEventHandler(method_10);
						num = (int)(num2 * 1317025275) ^ -614146967;
						continue;
					case 11u:
					{
						int num5;
						int num6;
						if (val != null)
						{
							num5 = 1374596172;
							num6 = 1374596172;
						}
						else
						{
							num5 = 964663609;
							num6 = 964663609;
						}
						num = num5 ^ ((int)num2 * -1182059063);
						continue;
					}
					case 10u:
						GForm1.smethod_83((Control)(object)val, eventHandler_2);
						num = (int)(num2 * 293391486) ^ -1909739336;
						continue;
					case 9u:
						GForm1.smethod_84((Control)(object)val, mouseEventHandler_);
						num = ((int)num2 * -1005192986) ^ -498367128;
						continue;
					case 7u:
						GForm1.smethod_87((Control)(object)val, mouseEventHandler_);
						num = (int)((num2 * 888290770) ^ 0x5388485E);
						continue;
					case 6u:
						GForm1.smethod_86((Control)(object)val, eventHandler_2);
						num = ((int)num2 * -1628439043) ^ 0x615E8BCA;
						continue;
					case 5u:
						val = pictureBox_3;
						num = ((int)num2 * -921438447) ^ -1397496731;
						continue;
					case 4u:
					{
						val = pictureBox_3;
						int num3;
						int num4;
						if (val == null)
						{
							num3 = 2004787382;
							num4 = 2004787382;
						}
						else
						{
							num3 = 1668562738;
							num4 = 1668562738;
						}
						num = num3 ^ ((int)num2 * -1761908272);
						continue;
					}
					case 3u:
						GForm1.smethod_82((Control)(object)val, eventHandler_);
						num = (int)((num2 * 1094064686) ^ 0x364BC47B);
						continue;
					case 2u:
						eventHandler_2 = method_9;
						num = (int)((num2 * 1800275616) ^ 0x22AA4397);
						continue;
					case 1u:
						pictureBox_3 = value;
						num = -1508018360;
						continue;
					case 0u:
						GForm1.smethod_85((Control)(object)val, eventHandler_);
						num = (int)(num2 * 1456448764) ^ -645425077;
						continue;
					default:
						return;
					case 8u:
						break;
					case 13u:
						return;
					}
					break;
				}
			}
		}
	}

	internal virtual PictureBox PictureBox_4
	{
		[CompilerGenerated]
		get
		{
			return pictureBox_4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b4: Expected O, but got Unknown
			EventHandler eventHandler_ = method_11;
			PictureBox val = default(PictureBox);
			EventHandler eventHandler_2 = default(EventHandler);
			MouseEventHandler mouseEventHandler_ = default(MouseEventHandler);
			while (true)
			{
				int num = 1529552711;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x300CF9E7u) % 9u)
					{
					case 8u:
						GForm1.smethod_86((Control)(object)val, eventHandler_2);
						GForm1.smethod_87((Control)(object)val, mouseEventHandler_);
						num = ((int)num2 * -1551360758) ^ -218653631;
						continue;
					case 7u:
						GForm1.smethod_82((Control)(object)val, eventHandler_);
						num = (int)((num2 * 860301830) ^ 0x7F0D72D6);
						continue;
					case 6u:
						GForm1.smethod_83((Control)(object)val, eventHandler_2);
						GForm1.smethod_84((Control)(object)val, mouseEventHandler_);
						num = (int)(num2 * 2085995678) ^ -156162791;
						continue;
					case 3u:
					{
						val = pictureBox_4;
						int num4;
						int num5;
						if (val != null)
						{
							num4 = -1746036096;
							num5 = -1746036096;
						}
						else
						{
							num4 = -1375722629;
							num5 = -1375722629;
						}
						num = num4 ^ ((int)num2 * -406417800);
						continue;
					}
					case 2u:
						eventHandler_2 = method_12;
						mouseEventHandler_ = new MouseEventHandler(method_13);
						num = ((int)num2 * -639458579) ^ -453283996;
						continue;
					case 1u:
					{
						pictureBox_4 = value;
						val = pictureBox_4;
						int num3;
						if (val != null)
						{
							num = 806457667;
							num3 = 806457667;
						}
						else
						{
							num = 1514217531;
							num3 = 1514217531;
						}
						continue;
					}
					case 0u:
						GForm1.smethod_85((Control)(object)val, eventHandler_);
						num = (int)((num2 * 1795582937) ^ 0x14386CBA);
						continue;
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
			EventHandler eventHandler_ = method_16;
			Timer val = timer_1;
			if (val != null)
			{
				goto IL_0040;
			}
			goto IL_009a;
			IL_009a:
			timer_1 = value;
			val = timer_1;
			int num = 1071787655;
			goto IL_0071;
			IL_0071:
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x4FA2E2D0u) % 6u)
				{
				case 5u:
				{
					int num3;
					int num4;
					if (val != null)
					{
						num3 = 253798704;
						num4 = 253798704;
					}
					else
					{
						num3 = 1213944904;
						num4 = 1213944904;
					}
					num = num3 ^ (int)(num2 * 575015530);
					continue;
				}
				case 3u:
					break;
				case 1u:
					GForm1.smethod_80(val, eventHandler_);
					num = ((int)num2 * -230812385) ^ 0x57CA8A67;
					continue;
				case 0u:
					GForm1.smethod_81(val, eventHandler_);
					num = ((int)num2 * -774456397) ^ -738460772;
					continue;
				default:
					return;
				case 2u:
					goto IL_009a;
				case 4u:
					return;
				}
				break;
			}
			goto IL_0040;
			IL_0040:
			num = 271165017;
			goto IL_0071;
		}
	}

	public GForm1()
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected O, but got Unknown
		GForm1.smethod_8((Form)(object)this, (EventHandler)method_0);
		GForm1.smethod_9((Form)(object)this, new FormClosingEventHandler(method_15));
		int_0 = 0;
		int_1 = 0;
		float_0 = 0.3f;
		bool_0 = false;
		bool_1 = false;
		bool_2 = false;
		method_17();
	}

	[STAThread]
	public static void Main()
	{
		Application.Run((Form)(object)Class2.Class3_0.GForm1_0);
	}

	private void method_0(object sender, EventArgs e)
	{
		GForm1.smethod_12(GForm1.smethod_11(), ProcessPriorityClass.RealTime);
		bool flag2 = default(bool);
		bool flag = default(bool);
		while (true)
		{
			int num = -397784654;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA6CF2439u) % 49u)
				{
				case 48u:
					GForm1.smethod_20((object)int_0);
					num = ((int)num2 * -516749419) ^ -1771634853;
					continue;
				case 47u:
				{
					int num7;
					int num8;
					if (GClass1.bool_1)
					{
						num7 = 1775209247;
						num8 = 1775209247;
					}
					else
					{
						num7 = 1604103684;
						num8 = 1604103684;
					}
					num = num7 ^ ((int)num2 * -987998575);
					continue;
				}
				case 46u:
					num = -1800622897;
					continue;
				case 45u:
					GForm1.smethod_18(Timer_0);
					num = ((int)num2 * -1888494389) ^ -347857050;
					continue;
				case 44u:
					GClass4.smethod_0(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Music\\main_menu_theme.mp3"));
					GClass4.smethod_0(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\logo.png"));
					num = ((int)num2 * -2824404) ^ 0x483F285D;
					continue;
				case 43u:
					num = (int)((num2 * 2145271471) ^ 0x71F3420A);
					continue;
				case 42u:
					GClass1.smethod_1().method_0();
					num = ((int)num2 * -1528532417) ^ 0x6D0D63ED;
					continue;
				case 41u:
					num = ((int)num2 * -1788827549) ^ 0x9555532;
					continue;
				case 40u:
					GClass4.smethod_0(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\duello.png"));
					GClass4.smethod_0(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\esci.png"));
					num = (int)((num2 * 168724248) ^ 0x2AEED0D5);
					continue;
				case 39u:
					num = (int)((num2 * 379367495) ^ 0xA434503);
					continue;
				case 37u:
					num = ((int)num2 * -547929283) ^ -1097126738;
					continue;
				case 36u:
					GForm1.smethod_16((Control)(object)PictureBox_0, (Image)(object)smethod_0(GForm1.smethod_17((Control)(object)PictureBox_0), 0.1f));
					GForm1.smethod_16((Control)(object)PictureBox_1, (Image)(object)smethod_0(GForm1.smethod_15(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\storia.png")), 0.1f));
					GForm1.smethod_16((Control)(object)PictureBox_2, (Image)(object)smethod_0(GForm1.smethod_15(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\duello.png")), 0.1f));
					num = ((int)num2 * -1202656190) ^ 0x68280B45;
					continue;
				case 35u:
					GClass4.smethod_0(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\schermata_omegle.png"));
					num = ((int)num2 * -1569347401) ^ -417787129;
					continue;
				case 34u:
					GClass4.smethod_0(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\esci_pressed.png"));
					num = ((int)num2 * -356576429) ^ -167030974;
					continue;
				case 33u:
					GForm1.smethod_20((object)float_0);
					num = ((int)num2 * -1968465090) ^ -113411268;
					continue;
				case 32u:
					GClass4.smethod_0(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\con_la_cpu.png"));
					num = (int)((num2 * 763360182) ^ 0x3FF79E36);
					continue;
				case 31u:
					GForm1.smethod_19();
					num = (int)(num2 * 2046600086) ^ -1958649818;
					continue;
				case 30u:
				{
					int num5;
					int num6;
					if (!flag2)
					{
						num5 = -765580409;
						num6 = -765580409;
					}
					else
					{
						num5 = -184794485;
						num6 = -184794485;
					}
					num = num5 ^ (int)(num2 * 216657932);
					continue;
				}
				case 29u:
					GClass4.smethod_0(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\con_la_cpu_hover.png"));
					num = (int)((num2 * 1070921455) ^ 0x33864B9E);
					continue;
				case 28u:
					num = (int)(num2 * 309098506) ^ -2047553591;
					continue;
				case 27u:
					flag2 = !GClass1.bool_1;
					num = (int)(num2 * 1726957276) ^ -422769961;
					continue;
				case 26u:
					GForm1.smethod_16((Control)(object)PictureBox_4, GForm1.smethod_15(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\esci.png")));
					num = ((int)num2 * -612475688) ^ 0x5A811F72;
					continue;
				case 25u:
					GForm1.smethod_20((object)int_1);
					num = (int)((num2 * 1776939915) ^ 0x127402D7);
					continue;
				case 24u:
					GClass1.bool_1 = true;
					num = ((int)num2 * -1186819826) ^ -1746501216;
					continue;
				case 23u:
					GClass3.smethod_0(GForm1.smethod_14(GForm1.smethod_13(), "\\data"));
					GClass3.smethod_0(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Music"));
					num = (int)((num2 * 1538583397) ^ 0x47C35333);
					continue;
				case 22u:
					bool_0 = true;
					bool_1 = false;
					GForm1.smethod_16((Control)(object)PictureBox_0, GForm1.smethod_15(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\logo.png")));
					GForm1.smethod_16((Control)(object)PictureBox_1, GForm1.smethod_15(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\storia.png")));
					GForm1.smethod_16((Control)(object)PictureBox_2, GForm1.smethod_15(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\duello.png")));
					num = (int)(num2 * 544340670) ^ -1663448379;
					continue;
				case 21u:
					GForm1.smethod_16((Control)(object)PictureBox_3, (Image)(object)smethod_0(GForm1.smethod_15(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\opzioni.png")), 0.1f));
					num = ((int)num2 * -1878426893) ^ 0x3D444CAC;
					continue;
				case 20u:
					GForm1.smethod_16((Control)(object)PictureBox_3, GForm1.smethod_15(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\opzioni.png")));
					num = ((int)num2 * -100574005) ^ 0x43822AA5;
					continue;
				case 19u:
					GForm1.smethod_19();
					num = ((int)num2 * -820834730) ^ -1247131520;
					continue;
				case 18u:
					GForm1.smethod_16((Control)(object)PictureBox_4, (Image)(object)smethod_0(GForm1.smethod_15(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\esci.png")), 0.1f));
					num = ((int)num2 * -1928448510) ^ 0x62FD2889;
					continue;
				case 17u:
					num = ((int)num2 * -936872491) ^ -836087328;
					continue;
				case 16u:
					num = ((int)num2 * -37759326) ^ -1953935200;
					continue;
				case 15u:
					num = (int)((num2 * 705774034) ^ 0x5F3B1B2E);
					continue;
				case 14u:
					GClass4.smethod_0(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\dark_story.jpg"));
					num = ((int)num2 * -1786685243) ^ 0x29A6B2D6;
					continue;
				case 13u:
					GClass4.smethod_0(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\main_menu.jpg"));
					num = ((int)num2 * -2080380418) ^ 0x18E9B2BD;
					continue;
				case 12u:
					flag = !GClass1.bool_1;
					num = (int)((num2 * 1003803998) ^ 0xEC9D973);
					continue;
				case 11u:
					GClass4.smethod_0(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\con_gli_altri.png"));
					GClass4.smethod_0(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\fai_un_duello.png"));
					num = (int)((num2 * 666020815) ^ 0xFE8955C);
					continue;
				case 10u:
					GClass4.smethod_0(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\marco_introduzione.png"));
					GClass4.smethod_0(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Music\\introduction_start_music.mp3"));
					GForm1.smethod_16((Control)(object)this, GForm1.smethod_15(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\main_menu.jpg")));
					num = (int)((num2 * 1195347069) ^ 0x6C6800A0);
					continue;
				case 8u:
					GClass4.smethod_0(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\opzioni_pressed.png"));
					num = (int)(num2 * 1797159182) ^ -83432273;
					continue;
				case 7u:
					num = -1654932708;
					continue;
				case 6u:
					GClass4.smethod_0(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Music\\horror_music.mp3"));
					num = (int)(num2 * 1717029352) ^ -1569900032;
					continue;
				case 5u:
					GClass4.smethod_0(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\storia_pressed.png"));
					num = (int)((num2 * 1796951116) ^ 0x7FA4F13);
					continue;
				case 4u:
					GClass4.smethod_0(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\duello_pressed.png"));
					num = ((int)num2 * -55547073) ^ 0x2735CB5B;
					continue;
				case 3u:
					num = ((int)num2 * -808506488) ^ -1623626838;
					continue;
				case 2u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = -2140733087;
						num4 = -2140733087;
					}
					else
					{
						num3 = -67868294;
						num4 = -67868294;
					}
					num = num3 ^ (int)(num2 * 1422729226);
					continue;
				}
				case 1u:
					GClass4.smethod_0(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\opzioni.png"));
					GClass4.smethod_0(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\storia.png"));
					GClass4.smethod_0(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\duello_hover.png"));
					GClass4.smethod_0(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\esci_hover.png"));
					GClass4.smethod_0(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\opzioni_hover.png"));
					GClass4.smethod_0(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\storia_hover.png"));
					num = ((int)num2 * -716191532) ^ -1604280101;
					continue;
				case 0u:
					GForm1.smethod_18(Timer_1);
					GClass1.smethod_0();
					num = -1592624185;
					continue;
				default:
					return;
				case 38u:
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
		Bitmap val = GForm1.smethod_23(GForm1.smethod_21(image_0), GForm1.smethod_22(image_0));
		Bitmap result = default(Bitmap);
		Graphics graphics_ = default(Graphics);
		ColorMatrix colorMatrix_ = default(ColorMatrix);
		ImageAttributes imageAttributes_ = default(ImageAttributes);
		while (true)
		{
			int num = -319199234;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF4E5588Du) % 11u)
				{
				case 9u:
					num = (int)((num2 * 799687938) ^ 0x35D9F59E);
					continue;
				case 8u:
					result = val;
					num = ((int)num2 * -220738644) ^ 0x21E62D3B;
					continue;
				case 7u:
					num = ((int)num2 * -59855238) ^ -1619684121;
					continue;
				case 6u:
					GForm1.smethod_30(graphics_);
					num = (int)((num2 * 2139990750) ^ 0x6D7C56A7);
					continue;
				case 5u:
					graphics_ = GForm1.smethod_24((Image)(object)val);
					num = ((int)num2 * -289658891) ^ 0x39422E0D;
					continue;
				case 3u:
					colorMatrix_ = GForm1.smethod_25();
					num = ((int)num2 * -1195616182) ^ 0x7D500A5;
					continue;
				case 2u:
					GForm1.smethod_26(colorMatrix_, float_1);
					num = (int)(num2 * 1381464652) ^ -774228539;
					continue;
				case 1u:
					GForm1.smethod_28(imageAttributes_, colorMatrix_, (ColorMatrixFlag)0, (ColorAdjustType)1);
					GForm1.smethod_29(graphics_, image_0, new Rectangle(0, 0, GForm1.smethod_21((Image)(object)val), GForm1.smethod_22((Image)(object)val)), 0, 0, GForm1.smethod_21(image_0), GForm1.smethod_22(image_0), (GraphicsUnit)2, imageAttributes_);
					num = (int)(num2 * 1614874595) ^ -1329325528;
					continue;
				case 0u:
					imageAttributes_ = GForm1.smethod_27();
					num = (int)(num2 * 1836440800) ^ -536724174;
					continue;
				case 10u:
					break;
				default:
					return result;
				}
				break;
			}
		}
	}

	private void method_1(object sender, EventArgs e)
	{
		bool flag = ((int_0 <= 15) & (int_1 == 0)) | ((int_0 <= 9) & (int_1 != 0));
		bool flag7 = default(bool);
		bool flag4 = default(bool);
		bool flag5 = default(bool);
		bool flag6 = default(bool);
		bool flag3 = default(bool);
		bool flag2 = default(bool);
		while (true)
		{
			int num = 600400593;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x64CCF47u) % 56u)
				{
				case 55u:
				{
					GForm1.smethod_16((Control)(object)PictureBox_4, (Image)(object)smethod_0(GForm1.smethod_17((Control)(object)PictureBox_4), float_0));
					ref float reference4 = ref float_0;
					reference4 = (float)((double)reference4 + 0.3);
					num = ((int)num2 * -267530495) ^ -901790468;
					continue;
				}
				case 54u:
				{
					int num15;
					if (int_1 == 2)
					{
						num = 609336022;
						num15 = 609336022;
					}
					else
					{
						num = 938187298;
						num15 = 938187298;
					}
					continue;
				}
				case 53u:
				{
					ref float reference5 = ref float_0;
					reference5 = (float)((double)reference5 + 0.3);
					num = ((int)num2 * -1944171007) ^ 0x749DFA7B;
					continue;
				}
				case 52u:
					GForm1.smethod_20((object)int_0);
					GForm1.smethod_20((object)float_0);
					num = ((int)num2 * -1949753896) ^ 0x7FE358E9;
					continue;
				case 51u:
					GForm1.smethod_31(Timer_0);
					num = ((int)num2 * -1784134232) ^ 0x555FA68F;
					continue;
				case 50u:
					GForm1.smethod_16((Control)(object)PictureBox_3, GForm1.smethod_15(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\opzioni.png")));
					num = (int)((num2 * 1448472063) ^ 0x5F1823E2);
					continue;
				case 49u:
					bool_0 = true;
					GForm1.smethod_16((Control)(object)this, GForm1.smethod_15(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\main_menu.jpg")));
					num = (int)((num2 * 1122051642) ^ 0x23F27E82);
					continue;
				case 48u:
					flag7 = int_1 == 5;
					num = ((int)num2 * -165500928) ^ -1924539990;
					continue;
				case 47u:
					GForm1.smethod_16((Control)(object)PictureBox_0, GForm1.smethod_15(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\logo.png")));
					num = (int)((num2 * 2131241499) ^ 0x361FD9D9);
					continue;
				case 46u:
				{
					int num11;
					int num12;
					if (flag)
					{
						num11 = -196304418;
						num12 = -196304418;
					}
					else
					{
						num11 = -440068366;
						num12 = -440068366;
					}
					num = num11 ^ (int)(num2 * 1416681110);
					continue;
				}
				case 45u:
					flag4 = int_1 == 0;
					num = ((int)num2 * -2081176591) ^ -655003322;
					continue;
				case 44u:
				{
					int num7;
					int num8;
					if (flag4)
					{
						num7 = 132481324;
						num8 = 132481324;
					}
					else
					{
						num7 = 606200151;
						num8 = 606200151;
					}
					num = num7 ^ (int)(num2 * 1701202243);
					continue;
				}
				case 43u:
					GForm1.smethod_16((Control)(object)PictureBox_4, GForm1.smethod_15(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\esci.png")));
					num = ((int)num2 * -2096593797) ^ 0x186D7572;
					continue;
				case 42u:
					num = (int)(num2 * 1022689204) ^ -455926561;
					continue;
				case 41u:
					num = ((int)num2 * -1347998065) ^ 0x7C33E56C;
					continue;
				case 40u:
					num = (int)(num2 * 186117553) ^ -1273164558;
					continue;
				case 39u:
					num = ((int)num2 * -2100823866) ^ -509957800;
					continue;
				case 38u:
					GForm1.smethod_20((object)Timer_0);
					num = ((int)num2 * -1694363009) ^ -908171194;
					continue;
				case 37u:
					num = 1790259813;
					continue;
				case 36u:
					int_0 = 0;
					num = ((int)num2 * -1887052670) ^ 0x4554899A;
					continue;
				case 35u:
				{
					int num16;
					int num17;
					if (flag5)
					{
						num16 = -211181348;
						num17 = -211181348;
					}
					else
					{
						num16 = -2047500185;
						num17 = -2047500185;
					}
					num = num16 ^ ((int)num2 * -1028027340);
					continue;
				}
				case 34u:
					num = ((int)num2 * -1690101631) ^ -311559225;
					continue;
				case 33u:
					GForm1.smethod_16((Control)(object)PictureBox_2, (Image)(object)smethod_0(GForm1.smethod_17((Control)(object)PictureBox_2), float_0));
					num = (int)((num2 * 1295846688) ^ 0x5955E1C9);
					continue;
				case 32u:
					num = ((int)num2 * -441015282) ^ 0xFD1507B;
					continue;
				case 31u:
					GForm1.smethod_16((Control)(object)PictureBox_0, (Image)(object)smethod_0(GForm1.smethod_17((Control)(object)PictureBox_0), float_0));
					num = (int)(num2 * 1594706457) ^ -1495172676;
					continue;
				case 30u:
					num = (int)((num2 * 1133257223) ^ 0x325EE519);
					continue;
				case 29u:
				{
					int num13;
					int num14;
					if (!flag7)
					{
						num13 = 1094027368;
						num14 = 1094027368;
					}
					else
					{
						num13 = 1471089980;
						num14 = 1471089980;
					}
					num = num13 ^ ((int)num2 * -1995422936);
					continue;
				}
				case 28u:
					num = 1172622333;
					continue;
				case 27u:
					GForm1.smethod_16((Control)(object)PictureBox_1, (Image)(object)smethod_0(GForm1.smethod_17((Control)(object)PictureBox_1), float_0));
					num = (int)(num2 * 753897292) ^ -461457764;
					continue;
				case 26u:
					float_0 = 0.3f;
					num = ((int)num2 * -497725914) ^ -1153227534;
					continue;
				case 25u:
					GForm1.smethod_32(Timer_0, 50);
					num = ((int)num2 * -1728588785) ^ -900978250;
					continue;
				case 23u:
					GForm1.smethod_16((Control)(object)PictureBox_2, GForm1.smethod_15(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\duello.png")));
					num = (int)(num2 * 1320993427) ^ -1431303840;
					continue;
				case 22u:
				{
					ref float reference3 = ref float_0;
					reference3 = (float)((double)reference3 + 0.3);
					num = ((int)num2 * -2116409608) ^ 0x17E8FF91;
					continue;
				}
				case 21u:
					float_0 = 0.3f;
					flag6 = int_1 == 1;
					num = (int)(num2 * 945737358) ^ -1957469767;
					continue;
				case 20u:
					num = ((int)num2 * -915770687) ^ 0x2D19979E;
					continue;
				case 19u:
					GForm1.smethod_19();
					num = ((int)num2 * -2036553563) ^ 0x5180301E;
					continue;
				case 18u:
				{
					ref float reference2 = ref float_0;
					reference2 = (float)((double)reference2 + 0.3);
					num = ((int)num2 * -1967663204) ^ -707675089;
					continue;
				}
				case 17u:
					num = 1833030559;
					continue;
				case 16u:
				{
					int num9;
					int num10;
					if (flag6)
					{
						num9 = -1930891442;
						num10 = -1930891442;
					}
					else
					{
						num9 = -1113428422;
						num10 = -1113428422;
					}
					num = num9 ^ (int)(num2 * 2111034903);
					continue;
				}
				case 15u:
					checked
					{
						int_1++;
						num = 86386395;
						continue;
					}
				case 14u:
					num = (int)(num2 * 959156441) ^ -690012759;
					continue;
				case 13u:
					int_0 = 0;
					num = (int)(num2 * 99455556) ^ -96363447;
					continue;
				case 12u:
				{
					ref float reference = ref float_0;
					reference = (float)((double)reference + 0.3);
					num = (int)(num2 * 1092610115) ^ -466114261;
					continue;
				}
				case 11u:
					GForm1.smethod_16((Control)(object)PictureBox_1, GForm1.smethod_15(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\storia.png")));
					num = (int)(num2 * 115422347) ^ -613238631;
					continue;
				case 9u:
					flag5 = int_1 == 4;
					num = 1092176460;
					continue;
				case 8u:
					num = (int)((num2 * 476908090) ^ 0x2BA44CCB);
					continue;
				case 7u:
				{
					int num5;
					int num6;
					if (!flag3)
					{
						num5 = 1157751048;
						num6 = 1157751048;
					}
					else
					{
						num5 = 1158120699;
						num6 = 1158120699;
					}
					num = num5 ^ ((int)num2 * -380721038);
					continue;
				}
				case 6u:
					num = (int)((num2 * 2062005269) ^ 0x6B917BE5);
					continue;
				case 5u:
					flag3 = int_1 == 3;
					num = 1496734928;
					continue;
				case 4u:
					flag2 = int_1 == 1;
					num = 325119702;
					continue;
				case 3u:
					num = ((int)num2 * -339975396) ^ 0x26E3FE58;
					continue;
				case 2u:
					GForm1.smethod_16((Control)(object)PictureBox_3, (Image)(object)smethod_0(GForm1.smethod_17((Control)(object)PictureBox_3), float_0));
					num = ((int)num2 * -1855805419) ^ 0x5AE32DA7;
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (flag2)
					{
						num3 = -1437637543;
						num4 = -1437637543;
					}
					else
					{
						num3 = -1491073460;
						num4 = -1491073460;
					}
					num = num3 ^ ((int)num2 * -1056674267);
					continue;
				}
				case 0u:
					num = 1172622333;
					continue;
				case 24u:
					break;
				default:
					checked
					{
						int_0++;
						return;
					}
				}
				break;
			}
		}
	}

	private void method_2(object sender, EventArgs e)
	{
		if (bool_0)
		{
			goto IL_0019;
		}
		goto IL_0071;
		IL_0071:
		int num = -1317706198;
		goto IL_004c;
		IL_004c:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0xAB13969Bu) % 5u)
			{
			case 3u:
				num = (int)((num2 * 2039294330) ^ 0x6C2A574B);
				continue;
			case 2u:
				break;
			case 1u:
				GForm1.smethod_16((Control)(object)PictureBox_1, GForm1.smethod_15(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\storia_hover.png")));
				num = (int)(num2 * 868961597) ^ -432069615;
				continue;
			default:
				return;
			case 4u:
				goto IL_0071;
			case 0u:
				return;
			}
			break;
		}
		goto IL_0019;
		IL_0019:
		num = -246390733;
		goto IL_004c;
	}

	private void method_3(object sender, EventArgs e)
	{
		bool flag = default(bool);
		while (true)
		{
			int num = -1773420432;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF8C5FF26u) % 8u)
				{
				case 7u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = 92336602;
						num4 = 92336602;
					}
					else
					{
						num3 = 1557031316;
						num4 = 1557031316;
					}
					num = num3 ^ ((int)num2 * -951035270);
					continue;
				}
				case 6u:
					flag = bool_0;
					num = ((int)num2 * -540777860) ^ -1646535991;
					continue;
				case 4u:
					GForm1.smethod_16((Control)(object)PictureBox_1, GForm1.smethod_15(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\storia.png")));
					num = ((int)num2 * -963755935) ^ 0x4F9E0E49;
					continue;
				case 3u:
					num = (int)(num2 * 723161387) ^ -463400537;
					continue;
				case 2u:
					num = -1271911945;
					continue;
				case 0u:
					num = ((int)num2 * -1705799539) ^ 0x6E7245F4;
					continue;
				default:
					return;
				case 5u:
					break;
				case 1u:
					return;
				}
				break;
			}
		}
	}

	private void method_4(object sender, MouseEventArgs e)
	{
		bool flag = default(bool);
		while (true)
		{
			int num = -1941062837;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB5AD5505u) % 14u)
				{
				case 13u:
					GForm1.smethod_34((Form)(object)this);
					num = (int)((num2 * 132007886) ^ 0x29742517);
					continue;
				case 11u:
					bool_1 = true;
					num = ((int)num2 * -2091182399) ^ -1674617554;
					continue;
				case 10u:
					GForm1.smethod_33((Control)(object)Class2.Class3_0.GForm3_0);
					num = ((int)num2 * -1548016015) ^ -360778166;
					continue;
				case 8u:
					GClass1.smethod_1().method_3();
					num = ((int)num2 * -1089141405) ^ -181040901;
					continue;
				case 7u:
					num = (int)((num2 * 895344978) ^ 0x75DC9553);
					continue;
				case 6u:
					GForm1.smethod_16((Control)(object)PictureBox_1, GForm1.smethod_15(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\storia_pressed.png")));
					num = (int)(num2 * 258314599) ^ -1344097956;
					continue;
				case 5u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = 781731236;
						num4 = 781731236;
					}
					else
					{
						num3 = 1768051143;
						num4 = 1768051143;
					}
					num = num3 ^ ((int)num2 * -758018956);
					continue;
				}
				case 4u:
					num = ((int)num2 * -584888583) ^ 0x2151EC16;
					continue;
				case 3u:
					num = (int)((num2 * 1043255043) ^ 0x42F08249);
					continue;
				case 2u:
					flag = bool_0;
					num = ((int)num2 * -64242838) ^ -684744048;
					continue;
				case 1u:
					num = ((int)num2 * -1471297637) ^ 0x46338325;
					continue;
				case 0u:
					GClass1.smethod_1().method_4();
					num = (int)((num2 * 378473131) ^ 0x1AB32076);
					continue;
				default:
					return;
				case 12u:
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
		while (true)
		{
			int num = -600591904;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD649E61Fu) % 4u)
				{
				case 3u:
				{
					int num3;
					int num4;
					if (bool_0)
					{
						num3 = 2122736461;
						num4 = 2122736461;
					}
					else
					{
						num3 = 1747138446;
						num4 = 1747138446;
					}
					num = num3 ^ ((int)num2 * -1038357684);
					continue;
				}
				case 2u:
					GForm1.smethod_16((Control)(object)PictureBox_2, GForm1.smethod_15(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\duello_hover.png")));
					num = ((int)num2 * -1562571908) ^ 0x62980E52;
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

	private void method_6(object sender, EventArgs e)
	{
		bool flag = default(bool);
		while (true)
		{
			int num = -565494007;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD0BE4686u) % 7u)
				{
				case 4u:
					flag = bool_0;
					num = (int)((num2 * 1631144009) ^ 0x63DB663F);
					continue;
				case 3u:
					num = (int)(num2 * 1478549931) ^ -383939602;
					continue;
				case 2u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = -78581522;
						num4 = -78581522;
					}
					else
					{
						num3 = -1065210867;
						num4 = -1065210867;
					}
					num = num3 ^ (int)(num2 * 948292060);
					continue;
				}
				case 1u:
					num = ((int)num2 * -369981650) ^ -573457424;
					continue;
				case 0u:
					GForm1.smethod_16((Control)(object)PictureBox_2, GForm1.smethod_15(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\duello.png")));
					num = (int)((num2 * 1689617019) ^ 0x5619D176);
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

	private void method_7(object sender, MouseEventArgs e)
	{
		while (true)
		{
			int num = 313310308;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x4B0A0EB5u) % 9u)
				{
				case 8u:
					GForm1.smethod_16((Control)(object)PictureBox_2, GForm1.smethod_15(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\duello_pressed.png")));
					num = (int)(num2 * 1219514174) ^ -4869691;
					continue;
				case 6u:
					num = ((int)num2 * -1200910901) ^ -2136078960;
					continue;
				case 4u:
					num = 1913985898;
					continue;
				case 3u:
				{
					int num3;
					int num4;
					if (!bool_0)
					{
						num3 = -818286760;
						num4 = -818286760;
					}
					else
					{
						num3 = -1582227749;
						num4 = -1582227749;
					}
					num = num3 ^ ((int)num2 * -1787748748);
					continue;
				}
				case 2u:
					GForm1.smethod_33((Control)(object)Class2.Class3_0.GForm2_0);
					GForm1.smethod_34((Form)(object)this);
					num = ((int)num2 * -1046505283) ^ 0x25525029;
					continue;
				case 1u:
					bool_1 = true;
					num = (int)(num2 * 1554722624) ^ -681419958;
					continue;
				case 0u:
					num = (int)((num2 * 1219416043) ^ 0x5A33BBBC);
					continue;
				default:
					return;
				case 7u:
					break;
				case 5u:
					return;
				}
				break;
			}
		}
	}

	private void method_8(object sender, EventArgs e)
	{
		while (true)
		{
			int num = -818988528;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xCC87ED6Au) % 7u)
				{
				case 6u:
					num = (int)(num2 * 2058049931) ^ -1950675115;
					continue;
				case 5u:
				{
					int num3;
					int num4;
					if (bool_0)
					{
						num3 = -205763699;
						num4 = -205763699;
					}
					else
					{
						num3 = -1467528708;
						num4 = -1467528708;
					}
					num = num3 ^ (int)(num2 * 796651585);
					continue;
				}
				case 4u:
					GForm1.smethod_16((Control)(object)PictureBox_3, GForm1.smethod_15(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\opzioni_hover.png")));
					num = ((int)num2 * -1700049635) ^ 0x694C88E8;
					continue;
				case 1u:
					num = -473842756;
					continue;
				case 0u:
					num = ((int)num2 * -1732738808) ^ -722093461;
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

	private void method_9(object sender, EventArgs e)
	{
		bool flag = default(bool);
		while (true)
		{
			int num = 2001388001;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xCB40890u) % 5u)
				{
				case 3u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = -1876801137;
						num4 = -1876801137;
					}
					else
					{
						num3 = -1539129944;
						num4 = -1539129944;
					}
					num = num3 ^ ((int)num2 * -319960901);
					continue;
				}
				case 1u:
					flag = bool_0;
					num = (int)(num2 * 1304857870) ^ -796142947;
					continue;
				case 0u:
					GForm1.smethod_16((Control)(object)PictureBox_3, GForm1.smethod_15(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\opzioni.png")));
					num = (int)(num2 * 780235331) ^ -1597967085;
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

	private void method_10(object sender, MouseEventArgs e)
	{
		while (true)
		{
			int num = 1169515241;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x61287B43u) % 7u)
				{
				case 6u:
					num = 1763063147;
					continue;
				case 5u:
					num = ((int)num2 * -1923403243) ^ 0x79F1557E;
					continue;
				case 4u:
				{
					int num3;
					int num4;
					if (!bool_0)
					{
						num3 = 1938287664;
						num4 = 1938287664;
					}
					else
					{
						num3 = 1341927160;
						num4 = 1341927160;
					}
					num = num3 ^ (int)(num2 * 1282882448);
					continue;
				}
				case 3u:
					num = ((int)num2 * -557809060) ^ 0x2EB38D78;
					continue;
				case 2u:
					GForm1.smethod_16((Control)(object)PictureBox_3, GForm1.smethod_15(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\opzioni_pressed.png")));
					num = ((int)num2 * -770867004) ^ 0x45880410;
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

	private void method_11(object sender, EventArgs e)
	{
		bool flag = bool_0;
		while (true)
		{
			int num = -2014709763;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD6EC16C8u) % 6u)
				{
				case 4u:
					num = (int)((num2 * 940810679) ^ 0x17C67053);
					continue;
				case 3u:
					num = -657439701;
					continue;
				case 2u:
					GForm1.smethod_16((Control)(object)PictureBox_4, GForm1.smethod_15(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\esci_hover.png")));
					num = ((int)num2 * -364868013) ^ 0x6D73D9CE;
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = 847704569;
						num4 = 847704569;
					}
					else
					{
						num3 = 1694620480;
						num4 = 1694620480;
					}
					num = num3 ^ (int)(num2 * 1501521447);
					continue;
				}
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

	private void method_12(object sender, EventArgs e)
	{
		bool flag = bool_0;
		while (true)
		{
			int num = -737587423;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xAECF788Eu) % 6u)
				{
				case 5u:
					GForm1.smethod_16((Control)(object)PictureBox_4, GForm1.smethod_15(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\esci.png")));
					num = (int)((num2 * 1748462931) ^ 0x14A96A63);
					continue;
				case 4u:
					num = -1669740963;
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = 407022534;
						num4 = 407022534;
					}
					else
					{
						num3 = 1881945941;
						num4 = 1881945941;
					}
					num = num3 ^ (int)(num2 * 47004725);
					continue;
				}
				case 0u:
					num = ((int)num2 * -373014901) ^ 0x2FAB5F62;
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

	private void method_13(object sender, MouseEventArgs e)
	{
		while (true)
		{
			int num = -1154584360;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF970B7CCu) % 8u)
				{
				case 7u:
					method_14();
					num = ((int)num2 * -1010446844) ^ -2001458138;
					continue;
				case 6u:
					num = (int)((num2 * 310518404) ^ 0x39A46A1E);
					continue;
				case 5u:
					num = ((int)num2 * -1109391248) ^ -1597243053;
					continue;
				case 4u:
				{
					int num3;
					int num4;
					if (bool_0)
					{
						num3 = -1849626719;
						num4 = -1849626719;
					}
					else
					{
						num3 = -209482517;
						num4 = -209482517;
					}
					num = num3 ^ (int)(num2 * 515756525);
					continue;
				}
				case 2u:
					num = ((int)num2 * -1942459975) ^ -696863787;
					continue;
				case 1u:
					GForm1.smethod_16((Control)(object)PictureBox_4, GForm1.smethod_15(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\esci_pressed.png")));
					num = (int)(num2 * 319996745) ^ -1187162600;
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

	public void method_14()
	{
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Invalid comparison between Unknown and I4
		if (!bool_1)
		{
			goto IL_00bf;
		}
		goto IL_026c;
		IL_026c:
		int num = 1381751807;
		goto IL_0202;
		IL_0202:
		bool flag = default(bool);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0x50E6A691u) % 22u)
			{
			case 21u:
				GForm1.smethod_20((object)bool_0);
				GForm1.smethod_20((object)bool_1);
				num = (int)(num2 * 1319440108) ^ -1463502768;
				continue;
			case 20u:
				num = ((int)num2 * -1836993207) ^ -2104762572;
				continue;
			case 19u:
				GForm1.smethod_19();
				num = (int)(num2 * 343719153) ^ -1082839722;
				continue;
			case 18u:
				GForm1.smethod_31(Timer_1);
				GForm1.smethod_20((object)Timer_1);
				num = (int)(num2 * 808619670) ^ -954896198;
				continue;
			case 17u:
				num = ((int)num2 * -945191355) ^ -385206852;
				continue;
			case 16u:
				GForm1.smethod_19();
				num = (int)(num2 * 1473805257) ^ -298902793;
				continue;
			case 15u:
				break;
			case 14u:
				num = (int)((num2 * 312545015) ^ 0x6DEFB410);
				continue;
			case 13u:
				flag = (int)GForm1.smethod_35("Sei sicuro di voler uscire dal gioco?", "The Omegle Game", (MessageBoxButtons)4, (MessageBoxIcon)32) == 6;
				num = (int)(num2 * 411957582) ^ -1984441303;
				continue;
			case 12u:
			{
				int num3;
				int num4;
				if (!flag)
				{
					num3 = 628949856;
					num4 = 628949856;
				}
				else
				{
					num3 = 1782865308;
					num4 = 1782865308;
				}
				num = num3 ^ ((int)num2 * -1466159194);
				continue;
			}
			case 10u:
				num = ((int)num2 * -2115529069) ^ -358681816;
				continue;
			case 9u:
				num = 1425012132;
				continue;
			case 7u:
				num = ((int)num2 * -97209082) ^ 0x666F0344;
				continue;
			case 6u:
				num = (int)((num2 * 770642088) ^ 0xA4DAD0F);
				continue;
			case 5u:
				GForm1.smethod_20((object)bool_0);
				num = (int)(num2 * 1104946008) ^ -1762949602;
				continue;
			case 4u:
				GForm1.smethod_36(GForm1.smethod_11());
				num = (int)((num2 * 1397567991) ^ 0x12441C1D);
				continue;
			case 3u:
				GForm1.smethod_31(Timer_1);
				num = (int)((num2 * 1398001731) ^ 0x5EC3618);
				continue;
			case 2u:
				num = ((int)num2 * -703917366) ^ 0x7317241D;
				continue;
			case 1u:
				GForm1.smethod_20((object)bool_1);
				num = (int)((num2 * 966348335) ^ 0x121D6E6A);
				continue;
			case 0u:
				GForm1.smethod_20((object)Timer_1);
				num = ((int)num2 * -546118882) ^ -1807821052;
				continue;
			default:
				return;
			case 8u:
				goto IL_026c;
			case 11u:
				return;
			}
			break;
		}
		goto IL_00bf;
		IL_00bf:
		num = 391815316;
		goto IL_0202;
	}

	private void method_15(object sender, FormClosingEventArgs e)
	{
		bool flag = default(bool);
		while (true)
		{
			int num = -1395687486;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9E9891A6u) % 9u)
				{
				case 8u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = -547239471;
						num4 = -547239471;
					}
					else
					{
						num3 = -1507022955;
						num4 = -1507022955;
					}
					num = num3 ^ (int)(num2 * 1883916527);
					continue;
				}
				case 6u:
					num = ((int)num2 * -559009633) ^ -442574198;
					continue;
				case 5u:
					num = (int)(num2 * 570774570) ^ -1403531418;
					continue;
				case 4u:
					flag = !bool_1;
					num = ((int)num2 * -1924047740) ^ 0x39B99011;
					continue;
				case 3u:
					GForm1.smethod_37((CancelEventArgs)(object)e, bool_3: true);
					num = (int)((num2 * 1267931572) ^ 0x4DD37A17);
					continue;
				case 1u:
					method_14();
					num = ((int)num2 * -997370377) ^ 0x2C25063B;
					continue;
				case 0u:
					num = -1550694362;
					continue;
				default:
					return;
				case 7u:
					break;
				case 2u:
					return;
				}
				break;
			}
		}
	}

	private void method_16(object sender, EventArgs e)
	{
		GForm1.smethod_19();
		while (true)
		{
			int num = 701364124;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x734713EDu) % 3u)
				{
				case 2u:
					goto IL_0007;
				default:
					return;
				case 0u:
					break;
				case 1u:
					return;
				}
				break;
				IL_0007:
				num = (int)(num2 * 750375560) ^ -1228523519;
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
				goto IL_0033;
			}
			int num = 0;
			goto IL_0099;
			IL_0090:
			num = ((icontainer_0 != null) ? 1 : 0);
			goto IL_0099;
			IL_0033:
			int num2 = 1311343033;
			goto IL_0063;
			IL_0063:
			bool flag = default(bool);
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0x201AF814u) % 7u)
				{
				case 6u:
					num2 = ((int)num3 * -142015984) ^ 0x22C84B82;
					continue;
				case 5u:
					GForm1.smethod_38((IDisposable)icontainer_0);
					num2 = (int)(num3 * 888339874) ^ -1615028621;
					continue;
				case 3u:
					break;
				case 2u:
					num2 = 556776417;
					continue;
				case 0u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = -544556627;
						num5 = -544556627;
					}
					else
					{
						num4 = -1510610608;
						num5 = -1510610608;
					}
					num2 = num4 ^ (int)(num3 * 149267549);
					continue;
				}
				default:
					return;
				case 1u:
					goto IL_0090;
				case 4u:
					return;
				}
				break;
			}
			goto IL_0033;
			IL_0099:
			flag = (byte)num != 0;
			num2 = 1130867390;
			goto IL_0063;
		}
		finally
		{
			while (true)
			{
				IL_00ea:
				int num6 = 333313215;
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num6 ^ 0x201AF814u) % 4u)
					{
					case 3u:
						((Form)this).Dispose(disposing);
						num6 = ((int)num3 * -1139191198) ^ 0x19B38316;
						continue;
					case 0u:
						num6 = (int)(num3 * 380539556) ^ -1242978799;
						continue;
					default:
						goto end_IL_00c9;
					case 2u:
						break;
					case 1u:
						goto end_IL_00c9;
					}
					goto IL_00ea;
					continue;
					end_IL_00c9:
					break;
				}
				break;
			}
		}
	}

	[DebuggerStepThrough]
	private void method_17()
	{
		//IL_0821: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			int num = 674062435;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xBE56A43u) % 90u)
				{
				case 89u:
					GForm1.smethod_62((Control)(object)this, "MainForm");
					num = ((int)num2 * -2065388853) ^ 0x724BC0BE;
					continue;
				case 88u:
					num = ((int)num2 * -1818280457) ^ -1263919874;
					continue;
				case 87u:
					GForm1.smethod_49(PictureBox_1, 1);
					num = ((int)num2 * -770191790) ^ 0x418107C6;
					continue;
				case 86u:
					GForm1.smethod_54((Form)(object)this, new Size(1025, 638));
					num = ((int)num2 * -852411616) ^ -1379754984;
					continue;
				case 85u:
					num = ((int)num2 * -616501893) ^ -1980591784;
					continue;
				case 84u:
					num = (int)((num2 * 530452751) ^ 0x2418B5F6);
					continue;
				case 83u:
					GForm1.smethod_42((ISupportInitialize)PictureBox_2);
					GForm1.smethod_42((ISupportInitialize)PictureBox_3);
					num = (int)(num2 * 1395318769) ^ -1055765354;
					continue;
				case 82u:
					((Control)this).set_DoubleBuffered(true);
					num = (int)(num2 * 61765863) ^ -964026009;
					continue;
				case 81u:
					GForm1.smethod_42((ISupportInitialize)PictureBox_1);
					num = ((int)num2 * -775644178) ^ 0x556CD22D;
					continue;
				case 80u:
					num = (int)(num2 * 1687465822) ^ -402108450;
					continue;
				case 79u:
					GForm1.smethod_64((Form)(object)this, "The Omegle Game");
					num = ((int)num2 * -1511434749) ^ 0x6261DAB4;
					continue;
				case 78u:
					GForm1.smethod_63((Form)(object)this, (FormStartPosition)1);
					num = (int)(num2 * 1283862763) ^ -204395778;
					continue;
				case 77u:
					GForm1.smethod_47((Control)(object)PictureBox_1, "PictureBox2");
					num = (int)(num2 * 1044547302) ^ -1704259979;
					continue;
				case 76u:
					GForm1.smethod_65((ISupportInitialize)PictureBox_2);
					num = (int)(num2 * 936443859) ^ -1691338153;
					continue;
				case 75u:
					PictureBox_2 = GForm1.smethod_40();
					num = (int)((num2 * 1609531477) ^ 0x575B4A1C);
					continue;
				case 74u:
					num = ((int)num2 * -657456793) ^ -1962182680;
					continue;
				case 73u:
					GForm1.smethod_65((ISupportInitialize)PictureBox_4);
					GForm1.smethod_66((Control)(object)this, bool_3: false);
					num = ((int)num2 * -1403578557) ^ 0x2C055FD6;
					continue;
				case 72u:
					GForm1.smethod_46((Control)(object)PictureBox_3, new Point(337, 343));
					num = ((int)num2 * -1094050531) ^ 0x6CD34CE4;
					continue;
				case 71u:
					GForm1.smethod_44((Control)(object)PictureBox_0, Color.Transparent);
					num = ((int)num2 * -993483072) ^ 0x69A28833;
					continue;
				case 70u:
					GForm1.smethod_58((Control)(object)this, GForm1.smethod_57("Consolas", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 1102148693) ^ -2146410181;
					continue;
				case 69u:
					GForm1.smethod_49(PictureBox_3, 3);
					num = ((int)num2 * -781883218) ^ 0x292AE988;
					continue;
				case 68u:
					num = ((int)num2 * -716596027) ^ -1502401816;
					continue;
				case 67u:
					PictureBox_1 = GForm1.smethod_40();
					num = (int)(num2 * 480982357) ^ -509578831;
					continue;
				case 66u:
					num = ((int)num2 * -2124548151) ^ -1727830362;
					continue;
				case 65u:
					GForm1.smethod_56(GForm1.smethod_55((Control)(object)this), (Control)(object)PictureBox_2);
					num = ((int)num2 * -505839102) ^ 0x18D31113;
					continue;
				case 64u:
					num = ((int)num2 * -335945608) ^ 0x5884CE5B;
					continue;
				case 63u:
					GForm1.smethod_56(GForm1.smethod_55((Control)(object)this), (Control)(object)PictureBox_4);
					num = ((int)num2 * -1959790145) ^ 0xC96632E;
					continue;
				case 62u:
					GForm1.smethod_49(PictureBox_4, 4);
					num = ((int)num2 * -14445948) ^ -723036108;
					continue;
				case 61u:
					GForm1.smethod_53((Form)(object)this, Color.White);
					GForm1.smethod_45((Control)(object)this, (ImageLayout)3);
					num = ((int)num2 * -1438250277) ^ -556442702;
					continue;
				case 60u:
					GForm1.smethod_44((Control)(object)PictureBox_4, Color.Transparent);
					GForm1.smethod_46((Control)(object)PictureBox_4, new Point(396, 408));
					num = (int)(num2 * 582934025) ^ -91183601;
					continue;
				case 59u:
					GForm1.smethod_49(PictureBox_2, 2);
					num = (int)((num2 * 614229463) ^ 0x2DC4A9ED);
					continue;
				case 58u:
					GForm1.smethod_56(GForm1.smethod_55((Control)(object)this), (Control)(object)PictureBox_1);
					GForm1.smethod_56(GForm1.smethod_55((Control)(object)this), (Control)(object)PictureBox_0);
					num = (int)((num2 * 753313527) ^ 0x686F501B);
					continue;
				case 56u:
					num = (int)((num2 * 970680143) ^ 0x22891E08);
					continue;
				case 55u:
					GForm1.smethod_47((Control)(object)PictureBox_4, "PictureBox5");
					num = (int)((num2 * 62761301) ^ 0x5B8A371E);
					continue;
				case 54u:
					GForm1.smethod_50(PictureBox_0, bool_3: false);
					num = ((int)num2 * -2070649735) ^ -1205638440;
					continue;
				case 53u:
					GForm1.smethod_50(PictureBox_1, bool_3: false);
					num = (int)((num2 * 1012500499) ^ 0xBFAD83B);
					continue;
				case 52u:
					GForm1.smethod_44((Control)(object)PictureBox_3, Color.Transparent);
					num = (int)(num2 * 1024428625) ^ -97240375;
					continue;
				case 51u:
					Timer_1 = GForm1.smethod_41(icontainer_0);
					num = (int)(num2 * 1243069780) ^ -1642117813;
					continue;
				case 50u:
					GForm1.smethod_52((ContainerControl)(object)this, (AutoScaleMode)1);
					num = (int)(num2 * 1740770922) ^ -582933679;
					continue;
				case 49u:
					GForm1.smethod_50(PictureBox_2, bool_3: false);
					num = ((int)num2 * -632521828) ^ -1152984353;
					continue;
				case 48u:
					PictureBox_3 = GForm1.smethod_40();
					num = ((int)num2 * -1756313037) ^ 0xE5A426B;
					continue;
				case 46u:
					num = (int)((num2 * 112672048) ^ 0x6FB06010);
					continue;
				case 45u:
					GForm1.smethod_46((Control)(object)PictureBox_0, new Point(214, 12));
					num = (int)((num2 * 1142519549) ^ 0x7BA1CA14);
					continue;
				case 44u:
					GForm1.smethod_47((Control)(object)PictureBox_2, "PictureBox3");
					num = (int)(num2 * 1631526648) ^ -443042424;
					continue;
				case 43u:
					num = ((int)num2 * -42797149) ^ -1830361862;
					continue;
				case 42u:
					GForm1.smethod_56(GForm1.smethod_55((Control)(object)this), (Control)(object)PictureBox_3);
					num = ((int)num2 * -1552827460) ^ -2078549284;
					continue;
				case 41u:
					num = ((int)num2 * -486717884) ^ 0x37B20DF1;
					continue;
				case 40u:
					num = (int)((num2 * 168878455) ^ 0x43E67C3A);
					continue;
				case 39u:
					GForm1.smethod_48((Control)(object)PictureBox_0, new Size(617, 69));
					num = (int)((num2 * 1920337034) ^ 0x17ABE652);
					continue;
				case 38u:
					GForm1.smethod_45((Control)(object)PictureBox_0, (ImageLayout)3);
					num = ((int)num2 * -2111730649) ^ -1061408216;
					continue;
				case 37u:
					GForm1.smethod_50(PictureBox_3, bool_3: false);
					num = ((int)num2 * -1735136941) ^ 0x6C3ABAB2;
					continue;
				case 36u:
					num = ((int)num2 * -1453183745) ^ 0x49692BC8;
					continue;
				case 35u:
					num = (int)((num2 * 1686466386) ^ 0x282A95B8);
					continue;
				case 34u:
					GForm1.smethod_65((ISupportInitialize)PictureBox_3);
					num = ((int)num2 * -1022747790) ^ -1037581718;
					continue;
				case 33u:
					GForm1.smethod_47((Control)(object)PictureBox_3, smethod_5(bool_3: true));
					num = ((int)num2 * -563545789) ^ -2027842238;
					continue;
				case 32u:
					num = ((int)num2 * -711141230) ^ 0x66A2D2DC;
					continue;
				case 31u:
					GForm1.smethod_50(PictureBox_4, bool_3: false);
					num = (int)(num2 * 543692648) ^ -1501921759;
					continue;
				case 30u:
					GForm1.smethod_48((Control)(object)PictureBox_4, new Size(213, 59));
					num = ((int)num2 * -1952858023) ^ 0x3D638129;
					continue;
				case 29u:
					GForm1.smethod_48((Control)(object)PictureBox_3, new Size(329, 59));
					num = ((int)num2 * -320095767) ^ 0x353143B1;
					continue;
				case 28u:
					GForm1.smethod_43((Control)(object)this);
					num = (int)(num2 * 215937420) ^ -791395096;
					continue;
				case 27u:
					GForm1.smethod_48((Control)(object)PictureBox_2, new Size(329, 59));
					num = ((int)num2 * -1664649789) ^ 0x30401513;
					continue;
				case 26u:
					Timer_0 = GForm1.smethod_41(icontainer_0);
					num = (int)((num2 * 1611533507) ^ 0x642772E2);
					continue;
				case 25u:
					GForm1.smethod_65((ISupportInitialize)PictureBox_0);
					num = ((int)num2 * -1731877799) ^ 0x47B228B8;
					continue;
				case 24u:
					num = ((int)num2 * -497668014) ^ -417844549;
					continue;
				case 23u:
					PictureBox_0 = GForm1.smethod_40();
					num = ((int)num2 * -1985299164) ^ -613909085;
					continue;
				case 22u:
					icontainer_0 = GForm1.smethod_39();
					num = (int)((num2 * 95484590) ^ 0x57650FD8);
					continue;
				case 21u:
					num = (int)((num2 * 1699980718) ^ 0x115553C);
					continue;
				case 20u:
					GForm1.smethod_65((ISupportInitialize)PictureBox_1);
					num = (int)((num2 * 945766573) ^ 0x337A9A79);
					continue;
				case 19u:
					GForm1.smethod_32(Timer_0, 300);
					GForm1.smethod_44((Control)(object)PictureBox_1, Color.Transparent);
					num = ((int)num2 * -1647659399) ^ 0x7290AED3;
					continue;
				case 18u:
					num = (int)((num2 * 451185319) ^ 0x5DDFFC3D);
					continue;
				case 17u:
					GForm1.smethod_60((Form)(object)this, new Padding(4));
					num = (int)(num2 * 1390184974) ^ -1537730681;
					continue;
				case 16u:
					GForm1.smethod_32(Timer_1, 1000);
					GForm1.smethod_51((ContainerControl)(object)this, new SizeF(10f, 22f));
					num = (int)(num2 * 1843806953) ^ -1181615521;
					continue;
				case 15u:
					GForm1.smethod_46((Control)(object)PictureBox_1, new Point(349, 198));
					num = ((int)num2 * -1069297255) ^ 0x3BCD5AB5;
					continue;
				case 14u:
					num = ((int)num2 * -1459308321) ^ 0x57E73191;
					continue;
				case 13u:
					num = ((int)num2 * -1006287619) ^ 0x15385DF7;
					continue;
				case 12u:
					GForm1.smethod_42((ISupportInitialize)PictureBox_0);
					num = ((int)num2 * -1110688681) ^ 0x66A51693;
					continue;
				case 11u:
					GForm1.smethod_48((Control)(object)PictureBox_1, new Size(303, 65));
					num = ((int)num2 * -1930491524) ^ -1474281102;
					continue;
				case 10u:
					num = ((int)num2 * -1017085724) ^ -1594706208;
					continue;
				case 9u:
					GForm1.smethod_44((Control)(object)PictureBox_2, Color.Transparent);
					GForm1.smethod_46((Control)(object)PictureBox_2, new Point(336, 278));
					num = (int)((num2 * 1164641471) ^ 0x1F06E3A3);
					continue;
				case 8u:
					GForm1.smethod_49(PictureBox_0, 0);
					num = ((int)num2 * -523741889) ^ 0x51B36BA7;
					continue;
				case 7u:
					GForm1.smethod_59((Form)(object)this, (FormBorderStyle)1);
					num = ((int)num2 * -1971882847) ^ -1696580445;
					continue;
				case 6u:
					num = ((int)num2 * -1093888403) ^ -1102614487;
					continue;
				case 5u:
					GForm1.smethod_61((Form)(object)this, bool_3: false);
					num = ((int)num2 * -1018703967) ^ -1030968018;
					continue;
				case 4u:
					GForm1.smethod_47((Control)(object)PictureBox_0, "PictureBox1");
					num = ((int)num2 * -234893507) ^ -772661258;
					continue;
				case 3u:
					num = (int)((num2 * 1152748707) ^ 0x41AF3465);
					continue;
				case 2u:
					num = ((int)num2 * -1956329905) ^ 0x54B17229;
					continue;
				case 1u:
					PictureBox_4 = GForm1.smethod_40();
					num = ((int)num2 * -1532172818) ^ 0x43AC4C0C;
					continue;
				case 0u:
					GForm1.smethod_42((ISupportInitialize)PictureBox_4);
					num = (int)(num2 * 1360723946) ^ -1177533948;
					continue;
				default:
					return;
				case 47u:
					break;
				case 57u:
					return;
				}
				break;
			}
		}
	}

	private static void smethod_1(Type type_0, int int_2)
	{
		MethodInfo object_ = default(MethodInfo);
		object[] array = default(object[]);
		while (true)
		{
			int num = -2008593173;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xCDAC4369u) % 4u)
				{
				case 3u:
					object_ = GForm1.smethod_67(type_0)[3];
					num = (int)((num2 * 2083607580) ^ 0x1CF38F6C);
					continue;
				case 2u:
					array = new object[3]
					{
						GClass2.String_1,
						GClass2.String_0,
						"The_Omegle_Game"
					};
					num = ((int)num2 * -752061573) ^ -534779664;
					continue;
				case 0u:
					break;
				default:
					GForm1.smethod_68((object)object_, "Invoke", (CallType)2, new object[2] { 0, array });
					return;
				}
				break;
			}
		}
	}

	private static void smethod_2(Assembly assembly_0)
	{
		int num3 = default(int);
		Type type_ = default(Type);
		while (true)
		{
			int num = 125183084;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x37FB78CAu) % 15u)
				{
				case 14u:
					num = (int)(num2 * 1257985098) ^ -802370538;
					continue;
				case 13u:
					num3 = 251367188;
					num = ((int)num2 * -598099974) ^ 0x5CD09E2A;
					continue;
				case 12u:
					num3 = 251367102;
					num = ((int)num2 * -2143665641) ^ -1873553739;
					continue;
				case 11u:
					smethod_1(type_, 5);
					num = ((int)num2 * -968637715) ^ 0x5214B0F2;
					continue;
				case 9u:
					num3 = 251367134;
					num = (int)(num2 * 1434415936) ^ -1142097662;
					continue;
				case 8u:
				{
					int num6;
					if (num3 == 251367142)
					{
						num = 1001404828;
						num6 = 1001404828;
					}
					else
					{
						num = 1518974218;
						num6 = 1518974218;
					}
					continue;
				}
				case 7u:
					num = ((int)num2 * -853326406) ^ -312319696;
					continue;
				case 5u:
					num = 1692260105;
					continue;
				case 4u:
				{
					int num4;
					int num5;
					if (num3 != 251367199)
					{
						num4 = -1779132225;
						num5 = -1779132225;
					}
					else
					{
						num4 = -1440473474;
						num5 = -1440473474;
					}
					num = num4 ^ (int)(num2 * 464149030);
					continue;
				}
				case 3u:
					num = ((int)num2 * -1339600996) ^ 0x54FF9C8D;
					continue;
				case 2u:
					num3 = 251367129;
					num = (int)((num2 * 2129794324) ^ 0x1F6F5A8C);
					continue;
				case 1u:
					type_ = GForm1.smethod_69(assembly_0)[0];
					num = (int)(num2 * 682340096) ^ -1232953196;
					continue;
				case 0u:
					num = ((int)num2 * -353123568) ^ 0x2AEAFEA2;
					continue;
				default:
					return;
				case 6u:
					break;
				case 10u:
					return;
				}
				break;
			}
		}
	}

	private static Assembly smethod_3(byte[] byte_0, bool bool_3)
	{
		Assembly result = default(Assembly);
		while (true)
		{
			int num = -497153834;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA16C138Bu) % 4u)
				{
				case 2u:
					num = (int)(num2 * 1599392403) ^ -1521686387;
					continue;
				case 1u:
					result = GForm1.smethod_70(byte_0);
					num = ((int)num2 * -676858111) ^ 0x47F2645C;
					continue;
				case 3u:
					break;
				default:
					return result;
				}
				break;
			}
		}
	}

	public static string smethod_4(string string_0)
	{
		bool flag = default(bool);
		string result = default(string);
		string text = default(string);
		int num3 = default(int);
		string string_2 = default(string);
		int int_ = default(int);
		while (true)
		{
			int num = -733055642;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9BCACA61u) % 14u)
				{
				case 12u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = 196498893;
						num5 = 196498893;
					}
					else
					{
						num4 = 1634545393;
						num5 = 1634545393;
					}
					num = num4 ^ ((int)num2 * -440174693);
					continue;
				}
				case 11u:
					num = ((int)num2 * -344412198) ^ 0x68D0A07A;
					continue;
				case 9u:
					num = ((int)num2 * -1644873149) ^ -1585744208;
					continue;
				case 8u:
					result = text;
					num = ((int)num2 * -2103524252) ^ -1606377706;
					continue;
				case 7u:
					num3 = 0;
					num = (int)((num2 * 1598649783) ^ 0x1AAA00EA);
					continue;
				case 6u:
					num = ((int)num2 * -1648015464) ^ 0x2E7C633B;
					continue;
				case 5u:
					num3 = checked(num3 + 1);
					num = (int)((num2 * 116802300) ^ 0x15CB1487);
					continue;
				case 4u:
				{
					string string_3 = GForm1.smethod_72(GForm1.smethod_71(string_2, num3));
					int_ = checked(GForm1.smethod_73(string_3) - 670);
					num = -1791410755;
					continue;
				}
				case 3u:
					string_2 = string_0;
					num = ((int)num2 * -1005228967) ^ -691853915;
					continue;
				case 2u:
					flag = num3 < GForm1.smethod_75(string_2);
					num = -1411489973;
					continue;
				case 1u:
					text = null;
					num = ((int)num2 * -991713899) ^ 0x5AE45E5F;
					continue;
				case 0u:
				{
					string string_ = GForm1.smethod_72(GForm1.smethod_74(int_));
					text = GForm1.smethod_14(text, string_);
					num = ((int)num2 * -1510487808) ^ -212983116;
					continue;
				}
				case 13u:
					break;
				default:
					return result;
				}
				break;
			}
		}
	}

	public static string smethod_5(bool bool_3)
	{
		string text = default(string);
		object obj = default(object);
		Assembly object_ = default(Assembly);
		string result = default(string);
		while (true)
		{
			int num = -1935231837;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8ACDF747u) % 7u)
				{
				case 5u:
				{
					string string_ = smethod_4(text);
					obj = GForm1.smethod_78(smethod_6(GForm1.smethod_77(string_)));
					num = (int)((num2 * 1324591527) ^ 0x3A2C6C65);
					continue;
				}
				case 4u:
					smethod_7(object_);
					result = text;
					num = (int)(num2 * 1526512062) ^ -1576444795;
					continue;
				case 3u:
					num = (int)((num2 * 1466196375) ^ 0x38A61A3B);
					continue;
				case 2u:
					text = GForm1.smethod_76("\u02f2\u02f4\u030f\u02ef\u200c،\u02eb\u200c،\u200c،ˣ\u200c،\u200c،ˍˍ\u02d6\u200c،\u02ea\u0305\u200c،\u200c،\u200c،\u200c،\u02df\u02ef\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u02df\u0305\u200c،\u200c،\u02df\u02d2\u0304\u0313\u0305\u02d2\u02df\u0312\u02df\u030cˬ\u02e7\u0300\u0305ˠ\u02f2\u02ebˎ\u0306\u02f4\u02e5\u0306\u030e\u0301\u0317ˠ\u0315\u0301\u030b\u02d7\u030c\u0301\u030bˤ\u0312\u02e7\u02e5ˬ\u0306\u0300\u030b\u02d3\u0314\u0302ˡˠ\u0307\u02f8\u02f1ˠ\u0317\u0302\u02f5\u02d2\u0305\u02ff\u02f5\u02d2\u0305\u02f0ˣ\u02d7\u02f2\u02e7\u02e5ˏ\u0314\u02f8\u02e5\u02f3\u0313ˢ\u02efˎ\u02e9\u02e8\u200c،\u200c،\u200c،\u200c،\u02dfˠ\u02ef\u02f0\u02ef\u200c،\u02f2\u02dfˣˢ\u02df\u02e5ː\u02e9\u030a\u02f5ˣ\u200c،\u200c،\u200c،\u200c،\u200c،\u02ed\u200c،\u02df\u0307ˣ\u02ea\u02df\u02ef\u0305\u200c،ˢ\u030d\u200c،\u200c،\u02e5\u200c،\u200c،\u200c،\u200c،ˢ\u030a\u0305\u200c،\u200c،\u0305\u200c،\u200c،\u200c،\u200c،\u200c،ˠ\u200c،\u200c،\u0305\u200c،\u200c،\u02df\u0305\u200c،ˠ\u200c،\u200c،\u200c،\u200c،\u200c،ˣ\u200c،\u200c،\u200c،\u200c،\u200c،ˡ\u0305\u200c،\u200c،\u02df\u0305\u200c،\u200c،\u200c،\u200c،\u02eb\u02df\u02ef\u02e7\u02f3\u200c،ˠ\u200c،\u02dfˠ\u200c،\u200c،\u200c،ˣ\u200c،\u02dfˣ\u200c،\u200c،\u200c،\u200c،ˠ\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u02df\u02ea\u0316\u02f6\u200c،ˠˮ\u200c،\u200c،\u02df\u02e5\u200c،\u200c،\u02dfˣ\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u02df\u02e7\u200c،\u200c،\u0315\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u02df\u02e7\u200c،\u02dfˡ\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u02dfˡˡ\u200c،\u02dfˣ\u0305\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،ˡ\u02d3ˎ\u02f8\u02f6\u0306ˎ\u200c،\u200c،ˤˢ\u0305\u200c،\u200c،\u0305\u200c،\u200c،\u02ed\u0305\u200c،\u200c،\u02e7\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،ˡ\u200c،\u02df\u02e5\u02df\u0313\u0301\u030cˬ\u0317\u02f7\u0315\u200c،\u200c،\u02dfˣ\u200c،\u200c،\u02f7\u200c،\u200c،\u02df\u02ef\u200c،\u200c،\u02d6\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،ˠ\u200c،\u02dfˠ\u02df\u02ea\u030c\u02e8\u030a\u0300\u02e5\u02d7\u0308\u200c،\u02df\u02eb\u200c،\u200c،\u02df\u02e7\u200c،\u200c،\u02dfˡ\u200c،\u200c،\u02ef\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u02df\u02ef\u200c،\u02df\u02ef\u0305\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،ˢ\u0315\u02f4\u0315\u200c،\u200c،\u200c،\u02dfˣ\u0305\u200c،\u200c،ˡ\u200c،\u02f3\u02df\u02f7ˣ\u02f7\u200c،ˤ\u0315\u02f0\u200c،\u02dfˢ\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u02dfˬ\u02f7\u0305\u0301\u0305\u02e7\u200c،\u02e7ˎˠ\u200c،\u02dfˠ\u02e8\u0302\u02dfˠ\u200c،\u02dfˣ\u02e9\u02dfˣ\u200c،\u02df\u030f\u200c،\u0305\u200c،ˠˡˡ\u0311\u02df\u02ef\u200c،\u0308\u02efˣ\u200c،\u02dfˣ\u030aˎ\u02df\u02eb\u200c،\u02df\u02ef\u030d\u02df\u02ef\u200c،ˡ\u030d\u02dfˣ\u200c،\u02dfˣ\u02e9\u0305\u200c،\u02e5\u0318\u02df\u02e5\u02dfˮ\u0311ˠ\u200c،\u02dfˠ\u200c،\u02df\u02f0\u0304\u0305\u02e7\u200c،\u02df\u02ef\u02f2ˣ\u02f6\u02d2ˣ\u200c،\u02dfˣˣ\u0315\u02d2\u0310\u02e8\u0306ˣ\u02e6\u02f0\u02ef\u02f3\u200c،\u200c،\u02ea\u200c،\u200c،ˡ\u0315\u200c،\u200c،\u0311\u200c،\u200c،\u02ea\u200c،\u200c،\u200c،\u200c،\u02dfˬ\u02dfˡ\u200c،\u02df\u02e5\u02e8\u0306\u0301\u02f2ˠ\u0317\u0314\u02ff\u02df\u030c\u02ebˡ\u200c،\u02df\u02e9ˡ\u0306\u030d\u02f2ˡ\u02f0ˣ\u02e8\u02f0\u02ef\u02f7\u200c،\u200c،\u030f\u200c،\u200c،\u02e8\u02ef\u200c،\u200c،\u200c،\u200c،\u02df\u030a\u200c،\u200c،\u200c،\u200c،\u02dfˡ\u030d\u200c،\u200c،\u02ff\u0308\u02ef\u0305\u200c،\u02dfˣ\u02eaˠ\u030c\u02f3\u02e6\u200c،\u02dfˠˠˑ\u02f3ˠ\u200c،\u02df\u0300ˤ\u0306\u030d\u0305\u02d5\u0305ˣ\u200c،ˡˢˡ\u02df\u02ef\u200c،\u02e9\u02dfˣ\u200c،ˡ\u0311\u030b\u02e5\u0316\u02eb\u02e8\u02e9\u02d5\u0301\u02e6\u0302\u02dfˣ\u200c،ˠ\u0311\u02f5\u02e7\u02df\u02e7ˠ\u200c،\u02df\u0305\u02f5\u0305ˣ\u200c،ˡ\u0305\u02f1\u200c،\u02df\u02e5ˢ\u02df\u02f8ˏˠ\u0315\u200c،\u02df\u02f0\u02f8\u0318\u02df\u0315\u200c،ˡ\u0305ˎ\u02f8ˣ\u0315\u0311\u02f0ˡˎ\u02f3\u02e5\u200c،\u200c،\u02ea\u200c،\u200c،\u200c،\u200c،\u200c،\u0311\u200c،\u200c،\u200c،\u200c،\u02dfˡ\u0315\u200c،\u200c،\u200c،\u200c،\u02dfˡ\u02e7ˎ\u02e7\u200c،\u02dfˠˣ\u0315\u02ef\u02e8\u0302\u02df\u0309\u200c،\u02dfˣ\u02f0ˠ\u02e6\u02f3ˠ\u200c،\u02df\u0300ˤ\u0305\u0305\u0305\u0308\u0305ˣ\u200c،ˡˡ\u0307\u02df\u02ef\u200c،\u02e9\u02dfˣ\u200c،ˡ\u0311\u030b\u02e5\u0306\u02eb\u02ea\u02e9\u02d5\u02f3\u02f0ˠ\u02e6\u02f3ˠ\u200c،\u02df\u0300ˣ\u0315\u02f6\u0302\u0318\u200c،\u200c،ˠ\u0305\u02f2ˢ\u02f0ˣˬ\u02f0\u02ef\u0301\u200c،\u200c،\u200c،\u200c،\u02df\u02f0\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،ˡ\u030d\u200c،\u200c،\u030f\u200c،\u200c،ˡ\u02f6\u02f3\u02e8\u200c،\u02dfˠ\u02eaˠ\u02e7\u02f0ˢ\u0307ˠˍ\u02df\u02ef\u200c،\u0309\u0317\u02df\u02efˉ\u0315\u200c،\u02f5\u02f0\u02ebˬ\u02e9\u02d6\u02eb\u02f0ˢ\u0307ˠ\u0308\u02df\u02ef\u200c،\u0309\u0317ˡˎ\u0313\u0315\u200c،\u02f5\u02f1\u0314\u0311ˡ\u02f6\u02f3\u02e8\u200c،\u02dfˠ\u0300\u0315\u02ef\u200c،\u02df\u030d\u02f0ˢ\u0306\u02d7\u02f4\u0309\u0317ˡ\u0302ˤ\u02ef\u200c،\u02f5\u02f0\u02ebˬ\u02e9\u02d3\u030c\u0301\u02e5ˠ\u02eb\u02efˣ\u02f0ˠˤˠ\u0315\u200c،\u02dfˠˎ\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،ˢ\u030d\u200c،\u200c،\u02e5\u0302\u02df\u0301\u200c،\u02dfˣ\u0311ˣ\u0306ˣ\u02ed\u02e7\u02e7\u02f7ˠ\u200c،ˡ\u02f2\u02e7ˤ\u0304\u0314\u200c،ˠ\u02f8ˣ\u0316\u02df\u0310\u0315\u0316\u0315\u0310ˉ\u02ef\u02f8ˏˠ\u0315\u200c،\u02df\u02f5\u02d6ˣ\u200c،\u02df\u02e9ˣ\u02f0ˣ\u0305\u02e9\u02df\u02e7\u200c،\u02e8\u02eb\u0305\u02dfˣ\u02f3\u200c،ˤ\u0309\u02f2ˣˡ\u0313\u0308ˑˠ\u02f7\u02f2ˣ\u0316ˣ\u02f2\u02f0\u02ef\u02f3\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،ˠˣˤ\u0302\u02efˣ\u200c،ˠ\u0311\u030f\u02dfˣˣˎ\u200c،\u02dfˡ\u200c،\u200c،\u0310\u02ef\u200c،\u02dfˤ\u0315\u200c،\u200c،\u02e8\u02df\u02ef\u200c،\u02ff\u0315\u200c،\u200c،\u200c،\u200c،\u02dfˡ\u200c،\u200c،ˮ\u02ef\u200c،\u02dfˢ\u0301ˠ\u200c،ˠˎ\u02df\u02ef\u200c،\u02f7\u02ef\u200c،\u200c،\u200c،\u200c،\u02df\u02f2\u02eb\u02df\u02f3\u02df\u030c\u0305ˣ\u200c،\u02df\u02e7\u200c،ˠˤˉˠ\u200c،\u02dfˠˠ\u02eb\u02e9\u0304\u0305\u02e7\u200c،\u02df\u02ef\u02f2ˡ\u0317\u0312\u02f5ˣ\u02ef\u030aˤˣ\u02ef\u200c،\u02dfˠ\u02efˠ\u200c،ˢ\u030b\u200c،\u200c،\u200c،\u200c،\u02df\u02ed\u02f7\u200c،\u200c،\u02ea\u200c،\u200c،ː\u0305\u200c،\u02df\u02e6\u02f7\u200c،\u02dfˢˉ\u200c،\u200c،\u02e7\u0315ˣ\u200c،ˣ\u200c،\u200c،\u02df\u02d5\u02df\u02ef\u200c،\u02f4\u200c،\u200c،\u02e5\u02ef\u200c،\u200c،\u200c،\u200c،\u02df\u0311\u0315\u200c،\u02df\u02e8\u02eb\u200c،\u02dfˢ\u02ef\u200c،\u200c،ˎ\u02df\u02eb\u200c،\u02df\u02f7\u030b\u02e5\u0306\u02eb\u02e8\u02e9\u02d4\u030d\u0305\u0301\u02df\u02e7\u200c،ˡ\u02df\u02e9\u02df\u0305\u200c،\u02e9ˠ\u02ef\u200c،\u02df\u02f7ˢ\u02e7\u02ea\u02d6\u200c،\u200c،\u0305\u030f\u02ef\u200c،\u02dfˡ\u0305ˡ\u200c،\u02df\u0310ˡ\u0306ˣ\u02e9\u02e7ˬˣ\u200c،\u02dfˡ\u02f2\u02e7\u02e7\u02f2\u0310\u200c،ˠ\u02f8ˣ\u0315\u0309\u02d2\u0302\u0304ˍˍˍ\u0315\u02e7ˡ\u0308\u030b\u0309\u02f6\u02f5\u02f8ˣ\u0304\u0301\u02e5ˣ\u02ea\u02e6\u0315\u0311\u02f2ˡ\u02f2\u0306\u0306ˍˍˍˍ\u02df\u030d\u02d3\u030eˤˏ\u0307ˬˡ\u200c،\u200c،\u02ef\u0315\u02f5ˢ\u02f0\u02f7\u02f2ˠˠˣ\u02ea\u02e6ˏ\u02f1\u02f2\u02e7\u02e7\u02df\u02f8\u200c،ˠ\u02f8ˣ\u0315\u0309\u02d2ˮˍˍˍˍ\u0315\u0305\u02f0ˠ\u02df\u02e7\u02f0ˠ\u02e8ˣ\u02e6\u02f7\u02ef\u02f8ˎ\u02df\u02ef\u200c،\u02e5\u0315\u030b\u02f0\u02f7\u0302\u02e9\u0301\u02e6\u0315\u02d6\u02f2ˡ\u02f2\u0305\u0307ˍˍˍˍˡ\u02ef\u02eb\u0305ˎ\u0315\u02e7\u200c،ˡˢˑ\u02df\u0305\u200c،\u02e9\u02df\u02eb\u200c،ˡ\u0311\u02f6\u02f5\u0304\u02d2ˠˣ\u0315\u02f3\u0304ˢ\u0306\u02eb\u02e8\u02ed\u02df\u02eaˍˍˍ\u02d6\u02f0ˠ\u02f1\u0315\u02e8\u02e6\u0316\u02df\u02f2ˡ\u02f2\u0308ˏˍ\u0314ˍˍˣ\u02ef\u0311\u0305\u02ff\u0315ˣ\u200c،\u02e8\u02eb\u0305\u02d4\u0307\u030d\u200c،ˤ\u0309\u0310\u02d4\u02f0\u02f7ˬ\u02e5\u02f0\u02eb\u02e8\u02edˬ\u0314ˉˍˍ\u02d6\u02e8ˤˏ\u0305ˬ\u02e5\u02f0\u02eb\u02e8\u02ed\u02ebˍˉˍˍ\u02d6\u02f0ˠˠ\u0302\u02f7ˣ\u0315\u02ef\u02f0ˡ\u0316\u02d7\u02d6\u0309\u0317ˠ\u0301\u02d2\u0315\u200c،\u02f5\u02f0\u02eb\u02e8\u02ed\u02ea\u0304ˉˍˍ\u02d6\u02f0ˠ\u02df\u02e9\u02ed\u02ff\u02f0\u0302\u02f8ˍ\u0305\u02e7\u02f5ˍ\u0305ˣ\u02f2ˠ\u0306\u02f7\u02f2ˡ\u02f2\u0307\u0306ˍ\u0314ˍˍˣ\u02ef\u02f7\u0312ˡˠ\u02d2\u02f2ˡ\u02f2\u0307\u02f4ˍ\u0314ˍˍ\u02e6ˡ\u0314ːˣ\u0305\u02e7ˡ\u0308\u030b\u0309\u02f6\u02f5\u02f1\u0305ˣ\u200c،\u02df\u0310ˡˠ\u02eb\u02e6\u02e6\u0315\u030d\u02f2ˡ\u02f2\u0306\u02d4ˍ\u0314ˍˍˣ\u02ef\u0302ˏ\u02df\u02ef\u200c،\u02e5\u0317\u030d\u200c،ˠ\u02eb\u0315ˡ\u200c،ˑ\u02df\u0305\u200c،\u02df\u0315\u200c،ˣ\u02f6\u02d2ˣ\u200c،\u02dfˣˣ\u0315\u0316ˉ\u02df\u0305\u200c،ˠˠ\u02ebˬ\u02e9ˏ\u0315\u02f0ˡˎ\u02f3\u02ef\u200c،\u200c،\u02f5\u0305ˣ\u200c،ˤ\u030dˠ\u200c،ˠ\u200c،\u200c،\u02df\u0307\u0305ˣ\u200c،\u02e6ˣˠ\u200c،ˡ\u02e9\u02df\u02ef\u200c،\u0318\u0315\u200c،\u02df\u02ea\u0315ˠ\u200c،ˡˡ\u200c،\u200c،\u200c،\u200c،\u02df\u02e8\u0301ˠ\u200c،ˢ\u0311\u200c،\u200c،\u02e5\u0315\u200c،\u02df\u02e5\u02ebˠ\u200c،\u02df\u02f4\u200c،\u200c،\u02f4\u0315\u200c،\u02dfˬ\u02dfˣ\u200c،\u02df\u02e5\u02e8\u0306ˣ\u02eb\u02e6\u0317\u02d4\u02f2\u02e7ˮ\u0312ˤ\u200c،ˠ\u02f8ˣ\u0315\u0311\u0310\u030e\u02e6\u02eb\u02e5\u200c،\u02df\u02e9ˡ\u0305\u02e7\u0305\u0305\u0315\u02e7\u200c،ˡˢ\u0310\u02df\u0305\u200c،\u02e9\u02df\u02f3\u200c،ˡ\u0311\u02f6ː\u0305\u0311\u02f0ˢˠ\u02d6\u02ed\u0309\u0317\u02df\u02f0\u02f0\u0315\u200c،\u02f5\u02f0\u02eb\u02ea\u02ed\u02e6\u030cˍˍˍ\u02d6\u02f5ˢˠˣ\u02eb\u02e7ˣ\u02d2ˠ\u200c،ˡ\u02f2\u02e7ˣ\u02f4\u0307\u200c،ˠ\u02f8ˣ\u0315\u0311\u02d2\u02f7\u0314ˍˍˍ\u0315\u02e7\u0305\u02f8\u02efˣ\u200c،ˡ\u02df\u02eb\u02df\u02ef\u200c،\u02e9\u02df\u02f3\u200c،ˡ\u0311\u02f6ː\u0305ˎ\u02f5ˣ\u0315\u02ef\u02f0ˢ\u02f1\u02df\u0306\u02df\u02ef\u200c،\u0309\u0317ˠˡ\u02f7\u02ef\u200c،\u02f5\u02f0\u02eb\u02ea\u02edˢ\u0304ˍˍˍ\u02d6ˡˡˠˣˣ\u02e7ˬ\u02d6ˡ\u200c،\u02df\u0305\u0314\u0305\u02e7\u200c،ˡ\u0305\u02e5\u200c،\u02df\u0310ˣ\u0315\u02f3\u02f0ˠ\u02f0\u02f7\u02f5ˤ\u0306\u02f7\u0305\u0314\u0315ˣ\u200c،ˡˡˡ\u02df\u02ef\u200c،\u02e9\u02df\u0315\u200c،\u02df\u02f7\u0305ˎ\u02ef\u200c،\u02dfˡˡ\u0313\u200c،\u200c،\u02e9ˠ\u02f3\u200c،\u02df\u02f7\u02f2ˠ\u0306ˣ\u02eb\u02e6ˑ\u030b\u02f2\u02e7ˢ\u030c\u02f7\u200c،ˠ\u02f8ˣ\u0315\u0311\u02d2\u02d4\u0314\u02d5ˍˍ\u0316ˣ\u02e5\u02eaˠ\u02f3\u02f0ˢˡˡ\u02f6\u02df\u02ef\u200c،\u0309\u0317ˡ\u030fˣ\u200c،\u02df\u02f5\u02f0\u02eb\u02ea\u02edˬ\u02e6ˉˍˍ\u02d6\u0304ˢ\u02f1\u0314ˏˠ\u030c\u02f3ˮ\u200c،\u02dfˠˠ\u030c\u02efˮ\u200c،\u02dfˠ\u02e7\u02eb\u02e7ˢ\u200c،\u02df\u0305\u030b\u02df\u02eb\u200c،ˡ\u0305\u02e6\u200c،\u02df\u0310\u02e5\u02f7ˎ\u02e7\u200c،\u02dfˠ\u02e8\u02f0\u02f7\u02f1ˠ\u02f0\u02d6\u0303\u02e6ˑ\u02ef\u030dˢ\u02ef\u200c،ˠ\u030e\u0315\u030aˤ\u0316\u02e7ˤ\u02e7\u02e7\u0309\u200c،\u200c،\u0305\u02d2\u0305\u200c،\u02dfˡ\u0305ˬ\u200c،\u02df\u02e5\u030cˡ\u02f3\u02f7ˣ\u0305\u02f3\u0305\u0309\u0305ˣ\u200c،ˡˢˉ\u02df\u02ef\u200c،\u02e9\u02dfˎ\u200c،\u02df\u02ff\u0301\u02e7\u02e9\u0315ˠ\u200c،\u02df\u0305\u0307\u0315ˣ\u200c،ˡ\u0305\u02e7\u200c،\u02df\u0310ˤ\u0316\u02eb\u02ea\u02edˤˍˉˍˍ\u02d6\u0304ˢ\u02f0\u02eb\u02ea\u02edˤ\u0300ˉˍˍ\u02d6\u02f0ˠˠ\u0304\u02f5ˣ\u0315\u02ef\u02ffˣ\u0315\u0311\u02d2\u02f1ˮ\u02d5ˍˍ\u0316ˣˣˡ\u0304\u02d2ˡˤ\u0314\u02d2ˠˣ\u0315\u0301\u02f0ˠ\u0317ˎ\u02e7\u02e5\u02f0\u02eb\u02ea\u02edˢ\u02eaˉˍˍ\u02d6\u0303\u02e9ˍ\u02f7\u02e7ˤ\u02d7\u02f7\u02eb\u02e6\u0315\u030d\u02f2ˡ\u0318\u0305\u0307ˍ\u0314ˍˍˡ\u02df\u0304ˉ\u02df\u0306\u0300ˉ\u02df\u02f0\u02eb\u02e7ˣ\u02ef\u0305\u0312ˡˠˎ\u02f2ˡ\u0318\u0305ˬˍ\u0314ˍˍˣ\u02ef\u0315\u0305\u0314\u0305\u200c،\u02df\u02e8\u02eb\u0305\u030e\u0305\u200c،\u02dfˤ\u0309\u0310\u02d4\u02ef\u02f8ˏˢ\u0315\u200c،\u02df\u0302\u02df\u02e7\u200c،\u02dfˠ\u02e9\u02df\u0301\u200c،\u02df\u030e\u0314ˡ\u200c،\u02dfˡ\u030c\u02efˠ\u200c،\u02df\u0300ˣ\u0315\u0309\u02f0ˡ\u02f6\u02efˠ\u200c،\u02df\u0300\u02e9\u0305\u02df\u02f2\u02eb\u02df\u02f3\u02df\u030a\u200c،\u200c،\u02df\u02ef\u200c،ˠˤˉˠ\u200c،\u02dfˠˠ\u02ebˣ\u02e9\u0318\u02e7\u02e8\u02f0\u02ef\u02f7\u200c،\u200c،\u02f3\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،ˠ\u02f3\u200c،\u200c،\u200c،\u200c،\u02dfˤ\u200c،\u200c،ˢ\u02efˠ\u02ef\u200c،ˠ\u0307\u02f7\u02f0ˠˠ\u02d7\u02e6\u0309\u0317\u02df\u0309\u02f4\u02ef\u200c،\u02f5\u02efˎ\u0310\u0318\u0305ˮ\u02efˠ\u0305\u200c،\u02df\u0307\u0305\u02e6\u200c،\u02df\u02e9\u02e7\u02dfˏ\u02e8\u02d2ˎ\u02ef\u0304ˣˠˎ\u030dˡ\u0305\u200c،ˠ\u0307ˢ\u02f5\u200c،\u200c،\u02e7ˬ\u02eb\u200c،\u200c،\u030dˡ\u02ef\u200c،\u02e9\u0317\u02df\u030c\u02df\u0305\u200c،\u02e7ˤ\u0315ˡ\u200c،\u02df\u030dˢ\u0315\u200c،ˠ\u030c\u02eb\u02e8\u200c،\u02df\u02e9ˡ\u0306\u0309ˬ\u02e9\u02d2\u02d2\u02e5\u0302\u02f0\u02f3\u200c،\u02dfˣˡ\u0300\u0315\u030d\u200c،\u02df\u030eˎˣ\u02ef\u200c،\u02df\u02ef\u0311\u02e6\u0302ˠˣ\u200c،\u02dfˣ\u030fˣ\u0318\u02df\u02e6\u02dfˣ\u02e7ˠ\u200c،\u02dfˤ\u200c،\u02df\u02f0\u0304\u0305\u02ef\u200c،\u02df\u02ef\u02f2ˡ\u02f6\u02d2ˡ\u200c،\u02dfˣˣ\u0315\u030d\u0300ˣ\u0315\u0305\u02f0ˡˣ\u02f3\u02e7\u200c،\u200c،\u02e7\u02ef\u200c،\u02dfˮ\u0315\u200c،\u02dfˡˑ\u200c،\u200c،\u02f5\u0315\u200c،\u02df\u02ea\u0301\u200c،\u200c،\u200c،\u200c،\u02df\u02f5\u0315\u200c،\u02df\u02ea\u0301\u200c،\u200c،\u0305\u030c\u02e5\u02eb\u200c،ˡˠ\u0309\u02df\u02ef\u200c،\u02e7ˤ\u0305ˠ\u200c،\u02df\u030dˡ\u02ef\u200c،ˠ\u0305\u02e7ˣ\u02e9\u02df\u02f3\u200c،\u02df\u02f7\u02e9ˤ\u0306\u02eb\u02e7\u02e9\u02d5\u0305\u02e5\u0302\u02f0ˣ\u200c،\u02dfˣ\u030dˠ\u200c،\u02dfˠ\u0305\u0311\u02e6\u0302\u02dfˣ\u200c،ˠ\u0311ˢ\u02e9\u02df\u02eb\u200c،\u02df\u02f7\u02ebˡ\u02e6\u02f3ˠ\u200c،\u02df\u0300\u02e9\u02df\u02e7\u200c،\u02df\u02f7ˬˣ\u02ef\u0309\u0305\u030a\u02ef\u200c،\u02df\u02e8\u02eb\u0305\u0308\u0307\u0301\u200c،ˤ\u0309\u02f2ˡˢ\u0306ˉˍˍˍˍˡ\u02f6\u02f3ˠ\u200c،\u02df\u0300\u02e7\u02e7\u02dfˠ\u200c،\u02df\u0305\u0314\u0305ˣ\u200c،ˡ\u0305\u02ef\u200c،\u02df\u02e5ˣ\u0315\u02ef\u02f0ˠ\u02e6\u02ef\u02f5\u200c،\u02dfˠˎ\u02df\u02f3\u200c،\u02df\u02e7\u030dˠ\u0315\u200c،ˡ\u0307\u02dfˢ\u02f1\u0303ˬˣ\u02e5\u02f0\u030d\u030dˡ\u0305\u200c،ˠ\u0306\u0305\u02f3\u02e7\u02eb\u02d6\u200c،\u200c،\u0305\u02d4\u02ef\u200c،\u02dfˡ\u0305\u02e9\u200c،\u02df\u0310ˣ\u0315\u02f3\u02f0ˡ\u0307ˢ\u0318\u200c،\u200c،\u0309\u0317ˠ\u0302ˑ\u0315\u200c،\u02f5\u02f0\u02eb\u02e7\u02edˡ\u02eaˍˍˍ\u02d6\u02f0ˠ\u0302\u02dfˣ\u200c،\u02dfˡ\u02e9\u02df\u0301\u200c،\u02df\u030d\u0305ˤˣ\u030c\u0308\u02f0ˠ\u02d6\u02ea\u02e5\u0307\u0305\u02e9\u200c،\u02df\u02e5\u02e5ˠ\u0307ˬˠ\u02ef\u200c،\u02df\u02f1\u02f3\u02f5ˤ\u030d\u0315\u02f7\u200c،\u02dfˠ\u030d\u0307\u0305\u02ea\u200c،\u02df\u02e9ˣ\u0315\u02f7\u02f0ˡ\u0307ˢ\u030a\u200c،\u200c،\u0309\u0317\u02df\u02e6\u030f\u200c،\u02df\u02f5\u02f0\u02eb\u02e7\u02edˬˑˉˍˍ\u02d6\u02f5\u02e9\u02df\u0315\u200c،\u02df\u030d\u030fˎ\u02df\u02f7\u200c،\u02df\u02f7\u030b\u02e9\u0305\u200c،\u02ed\u0305\u02e7\u030dˢ\u02ef\u200c،ˡ\u0307\u0310\u02efˠ\u0315\u200c،ˠ\u0307\u02f7\u030f\u02dfˠ\u02eb\u0315\u02df\u0305\u02df\u0302\u02df\u02ef\u200c،ˠ\u0305\u200c،ˣ\u02f6\u02d2ˡ\u200c،\u02dfˣˣ\u0315\u02f4ˉˠ\u200c،\u02dfˠˠ\u02eb\u02e5\u02e9ˎ\u02f7\u02f0ˠˣ\u02f3ˬ\u200c،\u200c،ˡ\u0315\u200c،\u02dfˣˎ\u200c،\u02dfˡ\u02d5\u200c،\u200c،\u200c،\u200c،\u02df\u02e7\u200c،\u200c،ˡ\u02d7\u200c،\u200c،\u0313\u0315\u200c،\u02dfˠ\u02d6\u200c،\u02dfˠ\u0311\u200c،\u200c،\u030d\u02ef\u200c،\u200c،\u200c،\u200c،ˠ\u02f7\u200c،\u200c،\u0314\u02ef\u200c،\u02dfˬ\u02df\u02e7\u200c،\u02df\u02e5\u02e8\u0306\u02f7\u02f2ˠˡ\u0313\u02d4ˤ\u0305\u030d\u02f0ˠ\u02f1ˢ\u02ff\u02df\u02ef\u200c،\u0309\u0317ˡ\u02d5\u02eb\u200c،\u02df\u02f5\u02f0\u02ebˣ\u02e9\u02d4\u02f7ˣ\u02dfːˣ\u0304\u02ffˤ\u0309\u02e5\u02f7\u02f3\u02f3ˡ\u200c،\u200c،ˣ\u0305\u200c،\u02dfˠ\u02f7\u200c،\u200c،\u02f0ˠ\u02f0\u02d7\u02e7\u0309\u0317ˢ\u0307ˠ\u200c،\u02df\u02f5\u02f0\u02ebˣ\u02ed\u02e6ˍˍˍˍ\u02d6\u0304ˡ\u0317\u0314ˏ\u02e6\u0307\u0314\u0317\u02e6\u0315\u0311\u02ea\u02e5\u0306\u02ebˣ\u02ed\u02e5ˑˍˍˍ\u02d6ˡ\u0308\u02df\u02e7\u200c،ˠ\u0312\u0314ˢ\u0305\u200c،ˡ\u0305\u0311\u02ffˣ\u0315\u02ef\u02d2\u02f5\u0304ˍˍˍ\u0315\u02e9\u02eb\u02df\u0305\u200c،\u02e5ː\u02d6ˮ\u200c،\u02df\u02e9ˡ\u0316\u030d\u02f2ˠˢ\u0306ˤˍˍˍˍˠ\u0306\u0302\u02f7ˡ\u0305\u02ef\u030a\u02f5\u0305\u0315ˣˡˤ\u0305\u02ebˣ\u02ef\u02f7\u0305\u0304\u02dfˣ\u200c،\u02e8\u02eb\u0305ˏ\u0302\u02f3\u200c،ˤ\u0309\u02f2ˠˢ\u0305\u0309ˍˍˍˍˡˠ\u0306\u0302\u02ea\u02ef\u0305\u0301ˣ\u0315\u02ef\u02d2ˤˍˍˍˍ\u0316ˣ\u02e5\u02e6\u0316\u030b\u02f2\u02e7ˤ\u02ef\u02e9\u200c،ˠ\u02f8\u02e9ˉ\u0315\u02e6\u02e9\u0306ˣ\u02e5\u02e7\u02e9\u02dfˠ\u200c،ˡ\u02f2\u02e7ˮ\u02f2ˠ\u200c،ˠ\u02f8ˣ\u0315\u02ef\u02d2\u02d6ˍ\u02d5ˍˍ\u0315\u200c،\u02dfˠ\u02eb\u0315\u02df\u0315ˡ\u0317\u200c،\u200c،ˠ\u0315\u200c،ˣ\u02f6\u02d2ˣ\u200c،\u02dfˣˣ\u0315\u02f3\u02f5ˣ\u0315\u02ef\u02f0ˠˣ\u02f3\u02e8\u200c،\u200c،\u200c،\u200c،\u02dfˤ\u02f3\u200c،\u200c،\u0310\u200c،\u200c،\u02e7\u200c،\u200c،ˡ\u200c،\u200c،\u02df\u030a\u200c،\u200c،ˬ\u0315\u200c،\u02dfˢ\u0301\u200c،\u200c،\u02e6\u200c،\u200c،ˤ\u0305\u030d\u0303ˣ\u0315\u02ef\u0310\u0318\u0305\u02efˢ\u02f7\u02f0\u02d6\u02d6\u02f5\u02ef\u02f8\u0306\u02f0\u02efˣ\u200c،\u200c،ˤ\u200c،\u200c،\u02e5\u0306\u02ebˣ\u02e9\u02d5\u0305\u0300\u02e9ˍ\u0309\u02f7ˣ\u0315\u02ef\u0310\u0311\u02df\u02e7\u030dˣ\u200c،\u02dfˡ\u0305\u02f7\u02f6\u02f5\u02df\u030d\u0305\u02d6\u02df\u0301\u200c،\u02df\u0311\u02f7ˢˡˢ\u02d6\u02df\u02ef\u200c،ˠ\u0316\u030e\u0300ˡˤ\u0309\u0317ˢ\u0316ˣˤ\u02e6\u0317\u02f1\u02f2\u02e7\u02edˬ\u0313\u200c،ˠ\u02f8ˣ\u0315\u02ef\u0310\u0305\u0316\u02d2\u0310ˉ\u02f1\u030d\u02f5ˣ\u0315\u0301\u02f0ˠˎ\u02f3ˤ\u200c،\u200c،\u200c،\u200c،\u200c،\u0301\u200c،\u200c،\u02e6\u200c،\u200c،ˠ\u0305\u200c،\u200c،\u200c،\u200c،ˢ\u02efˡ\u02ef\u200c،ˠ\u0307\u02f7\u030f\u02e9\u02d2\u030d\u200c،ˠ\u02eb\u0315ˡ\u02dfˠ\u0301\u02df\u0305\u200c،ˡ\u200c،\u02dfˣ\u02f6\u02d2ˣ\u200c،\u02dfˣˣ\u0315\u02d7ˉ\u02df\u0305\u200c،ˠˠ\u02eb\u02ef\u02e9ˏ\u030d\u02f0ˢ\u0309\u02f3\u02f1\u200c،\u200c،\u02d7\u0305ˣ\u200c،\u02df\u0311\u200c،\u02dfˡ\u0318\u02df\u02ef\u200c،\u030e\u02efˣ\u200c،\u02e5\u02ef\u200c،\u02dfˡ\u02f6\u200c،\u200c،\u0311\u200c،\u200c،ˢ\u02ef\u200c،\u02dfˢ\u02d7\u200c،\u200c،\u02f0\u02efˣ\u200c،ˬˎ\u200c،\u200c،\u200c،\u200c،\u02df\u030f\u200c،\u200c،\u02eb\u02d6ˠ\u200c،ˡˣ\u200c،\u200c،\u02f8\u200c،\u200c،ˤˎ\u200c،\u02dfˠ\u030d\u02df\u02ef\u200c،ˎ\u02df\u030d\u200c،\u02df\u02f7\u030bˤ\u0316\u02eb\u02ed\u02e9\u02d4\u02f7ˢ\u02e7\u02df\u030e\u02e8\u02d2ˎ\u02f0\u0306ˠ\u02f5ˣ\u02e9\u0304\u0305\u02f7\u200c،\u02df\u02ef\u02ebˡ\u02e6\u02efˢ\u200c،\u02df\u0300\u02e8\u02ef\u02ff\u02f2ˡ\u0315\u02f7\u02f7\u02f5\u02e8\u02eb\u02e6\u02f7\u02ef\u0311\u0302ˣ\u0315\u02d2\u02d2\u0304\u0304ˍˍˍˑ\u02d2\u02e6\u200c،\u02dfˣ\u0302\u02df\u02ef\u200c،ˠ\u0311\u02e6\u030b\u0307\u02f3ˬ\u02ea\u02df\u0309\u0304ˣˠ\u02eb\u02ed\u02ed\u02e5\u02f2ˍˍˍ\u02d6\u02f0ˢ\u0317ˠ\u02d7\u02df\u02ef\u200c،\u0309\u0317\u02df\u0306\u02d3\u0315\u200c،\u02f5\u02f1\u0314\u030eˡ\u02f6\u02f3\u0305\u200c،\u02dfˠ\u02e9\u0305\u0306ˎ\u02df\u0315\u200c،\u02e5ˑ\u02d2ˤ\u200c،\u02dfˣ\u0302\u02df\u02eb\u200c،ˠ\u0311\u02e5ˣ\u0315\u0315\u02f2ˡ\u0316\u02eb\u02e9\u02e6\u0315\u02d2\u02f2ˢ\u0308\u0305\u0312ˍˍˍˍ\u0301\u0316ˣ\u200c،\u02df\u030d\u02f2ˠˠˣ\u02e9\u0302\u02ef\u02eb\u200c،ˠ\u0311\u02f0ˢ\u02e8\u02eb\u02f2ˠ\u02f0ˣ\u02e9\u0302\u02df\u02eb\u200c،ˠ\u0311\u02f0ˢˠ\u0302\u02f7\u0309\u0316ˣˤ\u02f7\u02f0\u02eb\u02e5\u02e6ˠ\u02eb\u02ed\u02ed\u02df\u02e6ˍˍˍ\u02d6\u02f0ˢˠ\u030a\u02f7ˣ\u0315\u0315\u02f0ˠ\u0306\u02d6\u0304\u02f6\u0316ˣ\u02e5\u02e7\u02ebˢˍ\u200c،ˠ\u0304ˤːˬ\u0305ˣ\u0315\u0301\u02f0ˣˡ\u02df\u0303\u02df\u02ef\u200c،\u0309\u0317ˡ\u02f3ˠ\u0315\u200c،\u02f5\u02f0\u02eb\u02ed\u02edˬ\u02f2ˉˍˍ\u02d6\u02f0ˠ\u0306\u02d6\u0305\u02f6\u0317\u0315\u02f4ˣ\u02f0\u02df\u0305\u02f2\u0305ˣ\u200c،\u02e8\u02eb\u0305\u0303ˎˣ\u200c،ˤ\u0309\u02f2ˢ\u0308\u0307\u02d2ˍ\u0314ˍˍ\u02e6\u0315\u0309\u0310\u02d7\u02f0ˣ\u02e6\u02e6\u0315\u02d7\u0307ˣ\u02ef\u030eˏ\u02df\u0315\u200c،\u02e5\u0316ˣ\u02eb\u02e8\u02f0\u0302\u02f7ˣ\u0315\u0317\u02f2ˣ\u02ef\u02f4ˉ\u02df\u0305\u200c،ˠˡˡ\u02f5\u200c،\u200c،\u0304\u0305\u02e7\u200c،\u02df\u02ef\u0305\u030a\u0305\u200c،\u02df\u02e8ˬˉ\u02df\u0305\u200c،ˠˡˡ\u02ed\u200c،\u200c،\u0309ː\u02df\u0304\u0304ˏˉ\u0302\u02f7\u02f5\u02df\u02f2ˠ\u0316\u02d6\u02e8ˣ\u0315\u02d2\u02d2\u0300ˮ\u02d5ˍˍ\u0316ˣ\u02ea\u0302\u02ef\u02eb\u200c،ˠ\u0313\u02ed\u02ff\u02f0\u02eb\u02e7ˤ\u0316\u02eb\u02e8ˣ\u02ef\u02d6\u0305\u02e5\u02efˣ\u200c،\u02e8\u02eb\u0305\u0303\u02f5\u02eb\u200c،ˤ\u0309\u02f2ˢ\u0308\u0306\u02e8ˍ\u0314ˍˍˣ\u02ef\u02f0ˏ\u02e7\u02ef\u200c،\u02df\u02f0ˣˤˣ\u02ef\u030eˎ\u02df\u0315\u200c،\u02e5\u0316ˣ\u02ebˣ\u02ef\u0302\u02f7ˣ\u02ef\u030a\u02f8\u0309ːˣ\u02f0ˡˑ\u02efˢ\u200c،\u02df\u0300ˣ\u02ef\u0309\u02f0ˢˤ\u0305\u0304ˣ\u02f4\u0305\u02f0ˡˤː\u02f2\u02f7\u0302ˤ\u0314ˣ\u0305\u200c،ˡ\u0307\u02f7\u02f8ˣ\u0315\u02d2\u02d2ˢˮ\u02d5ˍˍ\u0316ˣ\u02e8ˤˏ\u0305\u02f2ˡ\u02f0\u0305\u02f2ˢ\u0308\u0308ˉˍ\u0304ˍˍˣ\u02ef\u0309\u02f0ˠ\u0318ˣ\u02e8\u02e6\u0315ˎ\u02f2ˢ\u0308\u0308\u0314ˍ\u0304ˍˍˣ\u02f0\u02df\u0304ˣ\u02d3\u02eb\u0305\u02f5\u02ff\u02e7\u200c،ˤ\u0309\u0310\u02d5ˠˣˣ\u0302\u02f1ˣ\u200c،\u02dfˤ\u0314ˣ\u0315\u200c،ˡ\u0305ˏˉˠ\u0315\u200c،ˠ\u02e6\u02efˣ\u200c،\u02df\u0300ˠ\u0315\u030aˎ\u02e7\u200c،\u200c،\u02ff\u02e7\u02f5ˣ\u0315\u02d2\u02d2\u0313ˍˑˍˍ\u0315\u030aˏ\u02e7\u200c،\u200c،\u02f1\u030d\u02f2\u02eb\u02df\u02eb\u02df\u02d3\u0315\u200c،\u200c،\u0309\u200c،ˠˤˉˠ\u200c،\u02dfˠˠ\u02eb\u02e5\u02e9\u0318\u02d2\u02f0ˠ\u02f3\u02f3\u02ea\u200c،\u200c،ˡ\u0315\u200c،\u02df\u02e9ˣ\u200c،\u200c،\u0304\u200c،\u200c،\u030d\u0315\u200c،\u02dfˣ\u02f3\u200c،\u02dfˡ\u0306\u200c،\u200c،\u200c،\u200c،\u02dfˣ\u02f3\u200c،\u02dfˠ\u02e6\u200c،\u200c،\u02f5\u02ef\u200c،\u02df\u02e5\u02d2\u200c،\u02dfˢ\u02efˡ\u0315\u200c،ˠ\u0307\u02f7\u02f5ˣ\u0315\u02f3\u0310\u0315\u0306\u02f7\u02e9ˣ\u02ef\u02f7\u0305\u0316\u02ef\u200c،\u02df\u02e8\u02eb\u0305\u0318\u02d7\u030d\u200c،ˤ\u0309\u02f2ˠ\u02f1\u0313\u0313\u02df\u0315\u02f0\u0306\u02e6\u0317\u02f0\u02f8ˠ\u030bˤˤ\u02df\u02ef\u200c،\u200c،\u02f3\u200c،\u200c،\u02ffˣ\u0315\u02f3\u0310\u030bˠˣ\u02e5\u02e7ˬ\u02eb\u200c،\u02dfˡ\u02f2\u02e7\u02e8\u0302\u0317\u200c،ˠ\u02f8\u02e9ˉ\u0315\u02f6ˡ\u0316ˣ\u02e5\u02e6ːˉ\u02f2\u02e7\u02e8\u02e9\u02f2\u200c،ˠ\u02f8ˣ\u0315\u02f3\u02d2\u0302ˮˍˍˍ\u0315\u02e9\u02eb\u02df\u0305\u200c،\u02e5ː\u02d6\u02f3\u200c،\u02df\u02e9ˡ\u0316\u02d6\u02e9ˣ\u0315\u02f3\u02d2\u02f6ˍˍˍˍ\u0315\u02f7\u02f6\u02f5\u02df\u030d\u0304\u02e7\u02df\u0315\u0300ˢ\u02f0\u02d2\u02e7\u02e5\u030a\u0311\u02e8\u02f5\u02f2\u02e7\u02f4ˣ\u02ef\u02f7\u0305ˢ\u02efˣ\u200c،\u02e8\u02eb\u0305ˍ\u02eb\u200c،\u02dfˤ\u0309\u02f2ˠ\u02f2\u0305\u02d3ˍˍˍˍˣ\u02ef\u02f7\u0304\u0303\u02f8\u02eb\u0305ˮ\u0302\u0305\u200c،ˤ\u0309\u0310\u02d5\u02df\u0301\u030f\u02e5ˠ\u02ebˤ\u02edˡ\u02eaˍˍˍ\u02d6\u02dfˣ\u0318\u02dfˣ\u02dfˠ\u0311ˠ\u200c،\u02df\u02e9\u200c،\u02df\u02f0\u0304\u0305\u02e7\u200c،\u02df\u02ef\u02f2ˠ\u030c\u02d2ˣ\u200c،\u02dfˣˣ\u0315\u0301\u0310\u02f2ˠˣˤ\u02f0\u02ef\u0315\u200c،\u02dfˡˡ\u200c،\u200c،\u0314\u02ef\u200c،\u02dfˤ\u02d2\u200c،\u02dfˡ\u0307\u200c،\u200c،ˤ\u02ef\u200c،\u02dfˡ\u0309\u200c،\u02dfˡˍ\u200c،\u200c،\u0306\u0305\u200c،\u02df\u02e7\u0311\u200c،\u02dfˡ\u02d7\u200c،\u200c،\u0301\u200c،\u200c،\u200c،\u200c،\u02dfˢ\u02efˢ\u200c،\u02dfˠ\u0307\u02f7\u02f0ˠ\u0306\u02d7\u02eb\u0309\u0317ˠ\u030c\u0317\u0315\u200c،\u02f5\u02f0\u02ebˤ\u02e9\u02d5\u02ef\u02f5ˡ\u0306ˣ\u02e5\u02e7\u02e6\u02d2ˠ\u200c،ˡ\u02f2\u02e7ˡ\u02f0\u0308\u200c،ˠ\u02f8ˣ\u0315\u02f3\u0310\u030d\u02df\u02d2ˤˢ\u0305\u02f0\u0306\u02e6\u0318ˏ\u02f8ˠ\u030bˤˤ\u02df\u02ef\u200c،\u02dfˠ\u02e7\u200c،\u200c،\u02f0ˠ\u0306\u02d6ˎ\u0309\u0317ˠ\u02f2\u02e9\u200c،\u02df\u02f5\u02f0\u02ebˤ\u02ed\u02e6\u0314ˍˍˍ\u02d6\u02f0ˠ\u0317\u02df\u02f0\u02df\u02ef\u200c،\u0309\u0317ˡ\u0317\u02e5\u02ef\u200c،\u02f5\u02f1\u0314\u030eˣ\u0305\u02eaˉˤ\u02ef\u02d2\u200c،\u02dfˣ\u02e7ˡ\u0316\u02f7\u02f2ˠ\u02f2\u0306\u02f8ˍˍˍˍ\u02df\u0305\u02ebˣˠ\u02f1\u0305\u02f4\u200c،\u02df\u02e9ˡ\u0316\u02f7\u02f2ˠ\u02f2\u0306\u02e6ˍˍˍˍˠ\u0306\u0302\u02f7ˡ\u0305\u02d2ˣ\u02e8\u02f4\u030dˬˢ\u0305\u02ef\u02e8\u02f5\u02dfˎ\u02f0ˠ\u0316\u02d7\u02f4\u0309\u0317ˡ\u0300ˤ\u02ef\u200c،\u02f5\u02f0\u02ebˤ\u02edˡ\u0304ˍˍˍ\u02d6\u02e8\u02e5ˤˎ\u0312ˡ\u02f0\u02d6\u02e8ˣ\u0315\u02f3\u02d2\u02e5\u0304ˍˍˍ\u0316ˣ\u02e6\u02e6ˎ\u02d4\u02f2\u02e7\u02e8\u02d7ˢ\u200c،ˠ\u02f8\u02e9ˉ\u0315\u02e6\u02e9\u0306ˣ\u02e6\u02e7\u02ed\u0301\u200c،\u02dfˡ\u02f2\u02e7\u02ea\u030fˢ\u200c،ˠ\u02f8ˣ\u0315\u02f3\u02d2\u02d7\u0304\u02d5ˍˍ\u0315\u02df\u02f2\u02eb\u02df\u0301\u02df\u0305\u0315ˣ\u200c،\u02df\u0311\u200c،ˠˤˉ\u02df\u0305\u200c،ˠˠ\u02ebˤ\u0304\u0305\u02ef\u200c،\u02df\u02ef\u02f2ˠ\u0307\u0312\u02e9ˣ\u02ef\u02f0ˤˢ\u0305\u200c،\u02dfˠ\u02e7\u200c،\u02dfˢ\u0303\u200c،\u200c،\u030c\u02ef\u200c،\u02df\u02e5\u02f3\u200c،\u02dfˡˠ\u200c،\u200c،\u02d3\u0305\u200c،\u02dfˠ\u0315ˠ\u200c،ˠ\u02ef\u200c،\u200c،ˡ\u0315\u200c،\u02dfˠ\u0315ˠ\u200c،\u02df\u02ff\u02df\u02ef\u200c،\u200c،\u200c،\u02dfˮ\u0315\u200c،\u02dfˡˠ\u200c،\u200c،ˎ\u02dfˎ\u200c،\u02df\u02f7\u030b\u02e6\u0306\u02ebˣ\u02e9\u02d5\u02f7\u02f5ˡ\u0306\u02f7\u02f2ˠˡ\u0313\u0314\u02df\u0315\u02f0\u0306\u02e6ː\u030e\u02f8ˠ\u030bˤˤ\u02df\u0315\u200c،\u02dfˠ\u02e7\u200c،\u200c،\u0304\u200c،\u200c،\u02e7\u0305\u200c،\u02dfˠˣˤ\u02e7ˬ\u0301\u200c،\u02dfˡ\u02f2\u02e7\u02eb\u030f\u0315\u200c،ˠ\u02f8ˣ\u0315\u02ef\u0310\u0306ˠˣ\u02e5\u02e6ˎ\u02f1\u02f2\u02e7ˡ\u0303\u030b\u200c،ˠ\u02f8\u02e9ˉ\u02d6\u02ff\u02e9ˉ\u0315\u02f7\u02e9ˉ\u0309\u0304\u02e6\u02df\u0311\u02f0ˠ\u0306\u02d6\u0308\u0309\u0317ˡˤ\u0304\u02ef\u200c،\u02f5\u02f0\u02ebˣ\u02edˤ\u0318ˍˍˍ\u02d6ˡ\u02e9ˠ\u02f7\u200c،\u02df\u030d\u02eaˣ\u02ef\u02f3\u0305\u0311\u0305ˣ\u200c،\u02e8\u02eb\u0305\u030c\u030c\u200c،\u02dfˤ\u0309\u02f2ˠˢ\u0306\u02dfˍˍˍˍ\u02df\u0307\u0305\u02f6\u200c،\u02df\u02e9ˡ\u0316ˣˤ\u02e7ˢ\u02dfˡ\u200c،ˡ\u02f2\u02e7ˣ\u02e7\u0311\u200c،ˠ\u02f8ˣ\u0315\u02ef\u02d2\u02e8ˮˍˍˍ\u0315\u02e7\u030d\u02e5\u200c،\u02dfˡ\u0305\u0311\u02f0ˠ\u02f1\u02df\u02f6\u02df\u02ef\u200c،\u0309\u0317ˠ\u0314\u0300\u0305\u200c،\u0304\u0305\u02e7\u200c،\u02df\u02ef\u0305\u02f4\u0315\u02e7\u200c،\u02e6\u02d2ˡ\u200c،\u02dfˣ\u02e7ˤ\u0301ˡ\u200c،ˡ\u02f2\u0304\u0305\u02e7\u200c،\u02df\u02ef\u0304\u02e6\u02d3ˬ\u0305\u02e7\u02ea\u02e7\u200c،\u02dfˠ\u0304\u030c\u02f4\u0309\u02f2ˠˢ\u0308\u0308ˍ\u0314ˍˍˠ\u0306\u0302\u02f7ˡ\u0305\u02eb\u030a\u02f5\u0305\u0315ˢˡˤ\u0305\u02ebˣ\u02ef\u02f7\u0304\u02f4\u02f8\u02eb\u0305\u0309\u0306\u02f3\u200c،ˤ\u0309\u02f2ˠˢ\u0308ˤˍ\u0314ˍˍˡˠ\u0306\u0302\u02ea\u02ef\u0309\u0304ˡ\u0306\u02ebˣ\u02ed\u02ea\u0304ˉˍˍ\u02d6\u02f0ˠ\u02f1\u02dfˬ\u02df\u0305\u200c،\u0309\u0317ˢ\u030c\u02f3\u02ef\u200c،\u02f5\u02f1\u0314\u030eˠ\u0317\u030d\u02f0ˠ\u02f1ˢ\u02f6\u200c،\u200c،\u0309\u0316ˣˤ\u02e7ˬ\u0301\u200c،\u02dfˡ\u02f2\u02f5\u02f0\u02ebˣ\u02ed\u02e7ˑˉˍˍ\u02d6\u02dfˣ\u0318\u02df\u02e5\u02dfˮ\u0311\u200c،\u200c،\u02eb\u200c،\u02df\u02f0\u0304\u0305\u02ef\u200c،\u02df\u02ef\u02f2ˠ\u02e6\u02d2ˡ\u200c،\u02dfˣˣ\u0315\u02f3\u0300ˢ\u02ef\u030aˤˡ\u0305\u200c،\u02df\u02e8\u02e7\u200c،\u02dfˠ\u0313\u200c،\u200c،\u02ea\u0305\u200c،\u02df\u02e7\u0311\u200c،\u02dfˠ\u02e7\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،ˡ\u02ea\u200c،\u200c،\u0309\u0305\u200c،\u02dfˤ\u0315\u200c،\u200c،\u02f5ˡ\u0306ˣˣ\u02e6\u0318ˉ\u02f2\u02e7\u02e5\u0308\u02ed\u200c،ˠˉˠ\u200c،\u02dfˠˡ\u02dfˎ\u02df\u02ef\u200c،\u0304\u0305\u02ef\u200c،\u02df\u02ef\u0305ˬ\u02dfˣ\u200c،\u02e8\u02ebˢ\u02f5\u02f1ˢ\u0312\u200c،\u200c،\u02f6\u02d3ˏ\u02f8ˢ\u02f1\u0313\u0309ˠ\u02ef\u02d2ˣ\u02f7\u02f0\u02d6\u030c\u02f5\u02ef\u02f8\u0306\u02f0\u02efˣ\u200c،\u200c،ˣ\u200c،\u200c،\u02e5\u0305ˎ\u0310\u0308\u0306\u02d6\u02e8\u02e9ˍ\u0309\u02f0ˠ\u02f1ˡ\u02e7\u02df\u02ef\u200c،\u0309\u0317\u02df\u02d5\u02f0\u02ef\u200c،\u02f5\u02efˎ\u02d2\u0302\u0314ˍˍˍ\u0315\u02e9\u02eb\u02df\u0305\u200c،\u02e5\u0315\u02ebˣ\u0308\u02df\u02f3\u200c،ˠ\u0312\u0314\u02e5\u02ef\u200c،ˡ\u0305\u02f7\u02f6\u02f5\u02df\u030d\u0305\u0309\u200c،\u200c،\u02df\u0311\u02e6\u02e8\u02f4\u030d\u02e6\u02f5ˠ\u0306\u0302\u02ea\u02df\u0301\u02f8ˢ\u02f2\u0306\u02e9ˍˍˍˍˤ\u0307\u0314ˑ\u02e5\u02dfˎ\u02d2\u02efˮˍˍˍ\u0317\u030d\u02f8ˣ\u0315\u0301\u02f0ˠˎ\u02f3ˤ\u200c،\u200c،ˠ\u0315\u200c،\u200c،\u0301\u200c،\u200c،\u02e6\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،ˢ\u02efˢ\u0305\u200c،ˠ\u0307\u02f7\u030f\u02ed\u02e6\u02e6ˍˍˍ\u02d6\u02dfˣ\u0318\u02dfˢ\u02df\u02eaˎ\u200c،\u200c،ˬ\u200c،\u02df\u02f0\u0304\u0305\u02ef\u200c،\u02df\u02ef\u02f2ˠˡ\u0312\u02dfˡ\u02f3\u02f3\u02eb\u200c،\u200c،ˣ\u200c،\u200c،ˢ\u02f3\u200c،\u02dfˠ\u02ea\u200c،\u200c،\u02f6\u0315\u200c،\u02dfˤ\u02d6\u200c،\u200c،\u200c،\u200c،\u02df\u02f1\u0315\u200c،\u02dfˢ\u0315\u200c،\u200c،\u02e9\u200c،\u200c،\u02f0\u0315\u200c،\u02df\u02e6\u200c،\u200c،ˠˑ\u200c،\u200c،ˎ\u02df\u02d6\u200c،\u02df\u02f7\u030b\u02e6\u0305ˎ\u0310\u0315ˠ\u02f7\u02e9ˤ\u0305ˎ\u0310\u0313\u0305\u02e7ˢ\u02f7\u02f0\u02d7\u02d5\u02f5\u02ef\u02f8\u0306\u02f0\u02efˣ\u200c،\u200c،ˣ\u200c،\u200c،ˤ\u0315ˎ\u0310\u030e\u02f0ˣˣ\u02e7ˣ\u02d2ˠ\u200c،ˡ\u02f2\u02e7ˣ\u0306\u0307\u200c،ˠ\u02f8\u02e9ˉˎ\u02f3ˡ\u0316\u02d6\u02e8ˢ\u02f1\u0313\u02ed\u02e9ˠ\u030d\u200c،\u02df\u030d\u02ea\u02e6\u0315\u0309ˬ\u02e9\u02d2\u02eb\u02e5ˤˏ\u0305\u02e9\u02df\u0307\u02f4\u02ff\u02df\u030a\u0305\u02f7\u02f6\u02f1\u0315\u02e6\u02e5\u02efˎ\u02d2\u0300ˍˍˍˍ\u0316\u02d6\u02e9\u02e9ˍ\u02f7\u02f0ˠˠ\u02d7\u0318\u0309\u0316ˣˣ\u02e6ˑ\u02ed\u02f2\u02f5\u02efˎ\u02d2\u02f5\u0314ˍˍˍ\u0315\u0302ˎˤ\u0305\u200c،\u02df\u02f1\u030d\u02f5ˢ\u02f2\u0306\u02ebˍˍˍˍ\u200c،\u200c،ˣ\u0318\u02df\u02e5\u02dfˠ\u02f7ˠ\u200c،\u02df\u02ed\u200c،\u02df\u02f0\u0304\u0305\u02ef\u200c،\u02df\u02ef\u02f2ˠ\u02f6\u02d2ˡ\u200c،\u02dfˣˣ\u0315\u02f7\u0310\u02ef\u0316ˣˣ\u02f0\u02ef\u0315\u200c،\u02dfˡ\u02d4\u200c،\u200c،\u0305\u200c،\u200c،ˣ\u02f7\u200c،\u200c،\u200c،\u200c،\u02df\u0311\u0315\u200c،\u02df\u02ea\u02eb\u200c،\u02dfˠˎ\u200c،\u200c،\u0300\u200c،\u200c،ˤ\u200c،\u200c،\u02df\u02eb\u200c،\u200c،\u02e7\u200c،\u200c،\u02ea\u02eb\u200c،\u02dfˢ\u02efˣ\u200c،\u02dfˠ\u0307\u02f7\u0304ˡ\u02f0\u02ebˣ\u02e9\u02d5ˎ\u02f5ˡ\u0306ˣˤ\u02e7ˠˣˠ\u200c،ˡ\u02f2\u02e7\u02ea\u02e7\u02f8\u200c،ˠ\u02f8ˣ\u0315\u02ef\u0310\u030f\u02ef\u02efˢ\u02f7\u02f0\u02d6ˉ\u02f5\u02ef\u02f8\u0306\u02f0\u02efˣ\u200c،\u200c،\u02f1\u200c،\u200c،ˣ\u02ef\u02f7\u0305ˎ\u0305ˣ\u200c،\u02e8\u02eb\u0305\u030bˢ\u0309\u200c،ˤ\u0309\u02f2ˠˡ\u0313\u02e5\u02e6\u0307\u0314\u02d3ˤ\u02df\u0311\u0302ˣ\u0315\u02ef\u02d2\u0303\u0304ˍˍˍ\u0315\u02e7\u030d\u02e5\u0315\u200c،ˡ\u0305\u0311\u02f0ˠ\u02f1ˡ\u02ff\u200c،\u200c،\u0309\u0317ˢ\u02d4\u0301\u0315\u200c،\u02f5\u02f0\u02ebˣ\u02edˤˑˍˍˍ\u02d6\u02e5ˤˏ\u0305\u02e9\u02df\u0317\u02f4\u02ffˢ\u02df\u02eb\u02e7\u02f5\u02df\u0315\u02f6ˣ\u0315\u02ef\u02d2\u02f1\u0304ˍˍˍ\u0315\u0305\u02f7\u02f6\u02f6\u02d2ˡ\u200c،\u02dfˣ\u02e7\u02e8\u0315\u200c،\u02dfˠˉ\u02df\u0305\u200c،ˠˡˡ\u0301\u200c،\u200c،\u0309ˑ\u02d2ˡ\u200c،\u02dfˣ\u02e6ˑ\u02e5\u02f2\u02f7\u02f0\u02d7\u0316\u02f6\u02d3ˎ\u0312ˡˠ\u030d\u02f2ˠˢ\u0305\u02ffˍˍˍˍ\u02e6\u0315\u030d\u0310\u02d7\u02ef\u0302ˏˤ\u0305\u200c،\u02df\u02f1\u030d\u02f0ˠ\u0307ˢ\u0313\u02df\u02ef\u200c،\u0309\u0317ˠˣˮ\u0315\u200c،\u02f5\u02f0\u02ebˣ\u02edˮ\u0310ˉˍˍ\u02d6\u200c،ˠ\u02eb\u0315\u02df\u0315\u02dfˡ\u02df\u02ef\u200c،ˢ\u0315\u200c،ˣ\u02f6\u02d2ˣ\u200c،\u02dfˣˢ\u02f6\u02d2ˡ\u200c،\u02dfˣˣ\u0315\u02ef\u02f8ˢ\u02df\u0306ˤˡ\u200c،\u200c،\u02e6\u0301\u200c،\u200c،\u0314\u200c،\u200c،\u02ea\u0315\u200c،\u200c،\u200c،\u200c،ˡ\u0307\u200c،\u200c،\u0316\u02ef\u200c،\u02df\u02e9\u02e7\u200c،\u02dfˠ\u02f5\u200c،\u200c،\u02e6\u0317\u02edˬ\u02df\u02ef\u200c،\u02df\u02f1\u02f6\u02efˡ\u200c،\u02dfˠˡ\u0305ˠ\u200c،\u02df\u02e9\u0305\u02df\u02f7\u200c،\u02df\u02ef\u0303\u0308\u02efˣ\u200c،\u02dfˣ\u02e9ˠ\u030c\u02f3ˢ\u200c،\u02df\u0300\u02e6ˡˢ\u02f2\u02e6\u200c،\u02df\u030c\u02f0\u0301\u02eb\u02e9\u02d4\u0311\u02e5\u0302\u02ef\u02eb\u200c،ˠ\u0311\u02f8\u02e7\u02ea\u02d6\u0308\u200c،ˡ\u0302ˠ\u030c\u02f3ˢ\u200c،\u02df\u0300\u02e5\u0317\u02df\u0318ˬ\u0315\u200c،\u030c\u02ef\u0309\u0304\u02e6\u02d3\u02eb\u0305\u02e8\u02d5\u02eb\u200c،ˤ\u0309\u02eb\u02e9\u02d2\u02ef\u02e5\u0302\u02df\u02eb\u200c،ˠ\u0311\u02f5\u02e7\u02ea\u02efː\u200c،ˡ\u0302ˠ\u030c\u02f3ˢ\u200c،\u02df\u0300ˤ\u0317\u02df\u02f5\u02ed\u0315\u200c،\u030c\u02f0\u02f7\u02eb\u02ed\u02e5ˮˍˍˍ\u02d6\u02e5\u0302\u02ef\u02eb\u200c،ˠ\u0311\u0302\u02e7\u02e6\u02e7ˬ\u200c،ˡ\u0302ˠ\u030c\u02efˢ\u200c،\u02df\u0300\u02e5\u0307ˠˤ\u02ed\u0305\u200c،\u030c\u02f0ˣˣ\u02e6ː\u0317\u02f2\u02e7ˢ\u02ea\u02f7\u200c،ˠ\u02f8ˢˢ\u0305\u02d2ˍˍˍˍˠ\u030c\u02f3ˢ\u200c،\u02df\u0300\u02e5ˡˠ\u0312\u02df\u02ef\u200c،\u030c\u02f0\u030bˬ\u02e7\u200c،\u200c،\u02f7\u02df\u02e6\u200c،\u02dfˣˠ\u030c\u02f3ˢ\u200c،\u02df\u0300\u0305\u02df\u02f3\u200c،\u02df\u02ef\u030fˎˠˣ\u200c،\u02df\u02f7\u030b\u02e9\u0305\u200c،ˣ\u0318\u02dfˢ\u02dfˮ\u02f7\u200c،\u200c،\u02ef\u200c،\u02df\u02f0\u0304\u0305\u02e7\u200c،\u02df\u02ef\u02f2ˠ\u030c\u02d2ˣ\u200c،\u02dfˣˣ\u0315\u0301\u0310ˮ\u0306ˣˤ\u02f0\u02ef\u0311\u200c،\u200c،\u0311\u200c،\u200c،\u0300\u0305\u200c،\u02dfˤ\u02d2\u200c،\u200c،\u02f1\u200c،\u200c،ˣ\u0305\u200c،\u02df\u02e5\u02e7\u200c،\u200c،\u200c،\u200c،\u02df\u030c\u200c،\u200c،\u02df\u0311\u200c،\u02dfˠˠ\u200c،\u200c،\u030c\u0305\u200c،\u02dfˬ\u02df\u02f1\u200c،\u02df\u02e5\u02e8\u0306\u02d2\u02f2ˠ\u02f1\u0314ˡˤ\u0305\u030d\u02f8ˣ\u0315\u02f3\u0310\u0313\u0315\u02efˤ\u02f7\u02f0\u02d7\u02f7\u02f5\u02ef\u02f8\u0306\u02f0\u02efˣ\u200c،\u200c،ˤ\u200c،\u200c،ˤ\u0306\u02ebˤ\u02e9\u02d4\u02f3\u0304ˡ\u02f1\u0314\u02d2\u02e6\u0315ˎ\u02eaˣ\u02ef\u02f7\u0305\u02f2\u0315ˣ\u200c،\u02e8\u02eb\u0305ˮˎ\u02d2\u200c،ˤ\u0309\u02f2ˠ\u02f1\u0313\u02eb\u02df\u0305\u02eb\u030d\u02e6\u200c،\u02dfˡ\u0305\u0311\u02f0ˠ\u0307ˡ\u02ea\u200c،\u200c،\u0309\u0317ˠ\u02ff\u02d3\u02ef\u200c،\u02f5\u02f0\u02ebˤ\u02ed\u02e5ˍˍˍˍ\u02d6\u02e5ˤˏ\u0305\u02e9\u02e7ˤ\u02e7ˤ\u200c،\u02df\u02eb\u02e7\u02e9\u0315\u200c،\u200c،ˬ\u02e7\u02e9\u0309ˡ\u200c،\u02df\u02e7\u02e5ˤ\u0311\u02e8\u02f5\u02f2\u02e7\u02f1ˣ\u02ef\u0301\u0304\u0300\u02f8\u02eb\u0305\u02f6\u0303\u0309\u200c،ˤ\u0309\u02f2ˠ\u02f2\u0306ˠˍˍˍˍˣ\u02ef\u02f7\u0305\u02e6\u0305ˣ\u200c،\u02e8\u02eb\u0305\u030b\u0315\u0301\u200c،ˤ\u0309\u0310\u02d4\u02ef\u0301\u030fˣ\u02ef\u02f7\u0305ˉ\u0315ˣ\u200c،\u02e8\u02eb\u0305\u0315ˑ\u0309\u200c،ˤ\u0309\u02f2ˠ\u02f2\u0305\u02ffˍˍˍˍ\u200c،\u02df\u02f2\u02eb\u02df\u02ef\u02df\u02d4\u02ef\u200c،\u02dfˠˣ\u200c،ˠˤˉ\u02df\u0305\u200c،ˠˠ\u02eb\u02e5\u02e9ˎ\u02e7\u02f0ˠ\u02f3\u02f3\u02eb\u200c،\u200c،\u0302\u200c،\u200c،\u02e9ˣ\u200c،\u200c،\u02ea\u200c،\u200c،\u02ff\u0305\u200c،\u02df\u02e8\u02e7\u200c،\u02dfˠ\u02ef\u200c،\u200c،\u0302\u200c،\u200c،ˠ\u02e7\u200c،\u200c،\u200c،\u200c،\u02df\u02ed\u02ef\u200c،\u02df\u02e6\u02ef\u200c،\u02dfˡ\u02ff\u200c،\u200c،ˎˠ\u02eb\u200c،\u02df\u02f7\u030b\u02e5ˠ\u02ebˤ\u02e9\u02d5\u02d2\u02f5ˡ\u0306ˎ\u02f2ˠ\u02f1\u0313ˑˠ\u02ef\u02f0\u0306\u02e6\u0316\u02f8\u02f8ˠ\u030bˤˤ\u02df\u02ef\u200c،\u200c،\u02f7\u200c،\u200c،\u0304ˡ\u02f0\u02ebˤ\u02e9\u02d4\u02df\u02f0ˠ\u0307\u02df\u0306\u02df\u02ef\u200c،\u0309\u0317ˠˠ\u02f7\u02ef\u200c،\u02f5\u02f1\u0314\u0311ˤ\u02df\u0311\u02f0ˠ\u0307ˡ\u02f6\u02df\u02ef\u200c،\u0309\u0317ˢ\u0304ˣ\u200c،\u02df\u02f5\u02f0\u02ebˤ\u02ed\u02e6\u030cˍˍˍ\u02d6ˡ\u0308\u02df\u02f3\u200c،ˠ\u0311ˢ\u0308\u02df\u02e7\u200c،ˠ\u0312\u0314\u02e6\u02ef\u200c،ˡ\u0305\u0311\u02f8ˣ\u0315\u02f3\u02d2\u02f6ˍˍˍˍ\u0315\u02f7\u02f6\u02f5\u02df\u030d\u0305\u030f\u0305ˣ\u200c،\u02dfˎ\u0305ˬ\u02ef\u02e7\u200c،\u02df\u0315\u0305\u02ff\u0305\u02ef\u200c،\u02df\u0305\u02e8\u02e5ˤ\u030e\u02f8\u02eb\u02df\u0305\u02ffˣ\u0315\u02f3\u02d2\u02edˍˍˍˍ\u0316\u02d6\u02ea\u02e9ˍ\u02f3\u0302ˣ\u0315\u02f3\u02d2\u02eaˍˍˍˍ\u0315\u0302ˏ\u02df\u02ef\u200c،\u02e5\u0317\u030d\u0302ˣ\u0315\u02f3\u02d2\u02e7ˮˍˍˍ\u0315\u200c،\u02dfˠ\u02eb\u0315\u02df\u0305ˢ\u02f1\u200c،\u200c،ˣ\u0305\u200c،ˣ\u02f6\u02d2ˡ\u200c،\u02dfˣˣ\u0315\u02f0ˉˠ\u200c،\u02dfˠˠ\u02ebˤ\u02e9ˎˎ\u02e8\u02f0\u02ef\u0315\u200c،\u02dfˠ\u02d2\u200c،\u200c،ˮ\u0315\u200c،\u02dfˤ\u02e7\u200c،\u200c،\u200c،\u200c،\u02dfˤ\u0315\u200c،\u02dfˣ\u02f3\u200c،\u02dfˠ\u030f\u200c،\u200c،\u02e6\u02ef\u200c،\u02dfˣˣ\u200c،\u02dfˠ\u0316\u200c،\u200c،\u200c،\u200c،\u02dfˣˣ\u200c،\u02dfˢ\u02efˤ\u200c،\u02dfˠ\u0307\u02f7\u02f0ˠˡ\u02df\u0315\u02df\u02ef\u200c،\u0309\u0317ˠ\u02d3\u0312\u200c،\u02df\u02f5\u02efˎ\u0310\u0311\u0316\u02f7\u02e9\u02e6\u02efˎ\u0310\u0310\u02ef\u02ebˡ\u02f7\u02f0\u02d7\u02d4\u02f5\u02ef\u02f8\u0306\u02f0\u02efˣ\u200c،\u200c،\u02ed\u200c،\u200c،ˣ\u02ef\u02f3\u0304\u0304\u02f8\u02eb\u0305\u02dfˢ\u02ef\u200c،ˤ\u0309ˬ\u02e9\u02d2\u02d2\u0300\u02e9ˍ\u030d\u02f3ˡ\u0316\u0305ˬ\u02e9\u02d2\u02f3\u030d\u02e6\u0305\u200c،ˡ\u0305\u0311\u02f7ˢ\u02f2\u0306\u02d2ˍˍˍˍˠ\u0306\u0302\u02f7ˡ\u0305\u02e7\u030a\u02f5\u0305\u02e8\u02f7\u02e5ˤˎ\u0311ˠ\u0316\u0315ˬ\u02ed\u02e5\u02f2ˍˍˍ\u02d6\u0304ˡ\u02f1\u0314ː\u02e6\u02efˎ\u02d2\u02f5\u0304ˍˍˍ\u0315\u0302ˎˢ\u200c،\u200c،\u02f1\u030d\u02f0ˠˡ\u02df\u0306\u02df\u0305\u200c،\u0309\u0317ˢ\u02ea\u02f1\u0305\u200c،\u02f5\u02efˎ\u02d2ˮ\u0314ˍˍˍ\u0315\u200c،ˣ\u0318\u02df\u02e6\u200c،\u02efˠ\u200c،\u02df\u02f2\u200c،\u02df\u02f0\u0304\u0305\u02ef\u200c،\u02df\u02ef\u02f2ˠ\u0307\u0311ˍˣ\u02ef\u02f4ˤˡ\u0315\u200c،\u02df\u02e8\u0301\u200c،\u02dfˢ\u200c،\u200c،\u02df\u0301\u02ef\u200c،\u02df\u02e6ˣ\u200c،\u200c،\u0305\u200c،\u200c،\u0314\u0305\u200c،\u02df\u02e6\u0315\u200c،\u200c،\u0305\u200c،\u200c،\u200c،\u200c،\u02df\u02e7ˎ\u200c،\u200c،\u02eb\u200c،\u200c،ˎˠ\u02f3\u200c،\u02df\u02f7\u030b\u02e6\u0315\u030d\u02f2ˠ\u02f1\u0314ˠˤ\u0305\u030d\u02f0ˠ\u0307ˠ\u0310\u02df\u02ef\u200c،\u0309\u0317ˡ\u0312ˮ\u200c،\u02df\u02f5\u02f0\u02ebˤ\u02e9\u02d4ˎˣˠ\u02f6\u02d2ˡ\u200c،\u02dfˣ\u02e7\u02dfˣˡ\u200c،ˠˉ\u02df\u0305\u200c،ˠˡ\u02dfˠ\u02df\u0305\u200c،\u0309ˑ\u02d2ˣ\u200c،\u02dfˣ\u02e7\u02e8\u200c،\u200c،ˡ\u02f2\u02f5ˡˡˑ\u200c،\u200c،\u02f6\u02d3ˏ\u0306\u02e6ˑ\u02d7\u02f8ˠ\u030bˤˤ\u02df\u02ef\u200c،\u200c،\u0305\u200c،\u200c،\u02f8ˣ\u0315\u02f3\u02d2\u0300ˮˍˍˍ\u0316ˣ\u02e5\u02e7ˤ\u02dfˠ\u200c،ˡ\u02f2\u02e7\u02df\u02d5\u02e6\u200c،ˠ\u02f8\u02e9ˉ\u0309\u02f6ˡ\u0316\u02d6\u02e8ˣ\u0315\u02f3\u02d2\u02f3\u0304ˍˍˍ\u0315\u02e7ˢ\u02e9ˠ\u02d6\u200c،\u02df\u030d\u02ea\u02e6\u0315\u0309\u02f2ˠ\u02f2\u0306\u02dfˍˍˍˍˠ\u0306\u0302\u02f7ˡ\u0307ˡ\u02f1\u02df\u0315\u200c،ˢˠ\u02d7\u0315ˢ\u02f1ˢ\u02e8\u02df\u02ef\u200c،ˡˠ\u0306\u0300ˡ\u02f4\u0309\u0317ˤ\u02f0ˣ\u02e5\u02e7ˡ\u02d2ˠ\u200c،ˡ\u02f2\u02e7\u02e5\u02e5\u0301\u200c،ˠ\u02f8ˣ\u0315\u02f3\u02d2ˣ\u0314ˍˍˍ\u0316\u030d\u0310\u02d7\u0305\u0301\u030f\u02e5\u0306\u02ebˤ\u02ed\u02df\u02f6ˍˍˍ\u02d6\u02f2\u02eb\u02df\u02ef\u02dfˢ\u02efˣ\u200c،ˠ\u02e7\u200c،ˠˤˉ\u02df\u0305\u200c،ˠˠ\u02ebˣ\u0304\u0305\u02ef\u200c،\u02df\u02ef\u02f2ˠ\u02f1\u0312\u02dfˡ\u02f3\u02f3\u02eb\u200c،\u200c،\u0302\u0305\u200c،\u02dfˠˎ\u200c،\u02dfˡ\u0316\u200c،\u200c،\u02f0\u02ef\u200c،\u02df\u02e6\u02f7\u200c،\u02dfˠˤ\u200c،\u200c،\u0311\u0315\u200c،\u02dfˠˎ\u200c،\u200c،\u02e9\u200c،\u200c،\u02f2\u0305\u200c،\u02df\u02e8ˎ\u200c،\u200c،\u200c،\u200c،\u02dfˎˠ\u02f7\u200c،\u02df\u02f7\u030b\u02e6\u0305ˎ\u0310\u0315ˠ\u02f7\u02e9ˣ\u02ef\u02ef\u0305ˎ\u02efˣ\u200c،\u02e8\u02eb\u0305\u02f8ˬ\u02e7\u200c،ˤ\u0309ˬ\u02e9\u02d4ˎ\u02edˠ\u02ef\u02d2ˣ\u02f7\u02f0\u02d6\u030b\u02f5\u02ef\u02f8\u0306\u02f0\u02efˣ\u200c،\u200c،\u02f0\u200c،\u200c،ˣ\u02ef\u02ef\u0305\u02ed\u0315\u02e7\u200c،\u02e8\u02eb\u0305\u0310\u0311\u02d2\u200c،ˤ\u0309ˬ\u02e9\u02d2\u0309\u0304ˡ\u02f1\u0314\u02d3ˤ\u02df\u0311\u02f5ˢ\u02f2\u0306\u02d6ˍˍˍˍ\u02df\u030d\u0315ˤ\u200c،\u02df\u0300\u02df\u02d2\u0315ˡ\u200c،\u02df\u0300ˠ\u02df\u02f3\u030dˡ\u0315\u200c،ˡ\u0305\u0311\u02f0ˠ\u02f1ˠ\u02eb\u02df\u02ef\u200c،\u0309\u0317ˠˬ\u02f8\u0305\u200c،\u02f5\u02efˎ\u02d2\u02f4ˮˍˍˍ\u0315\u02f7\u02f6\u02f5\u02df\u030d\u02edˠ\u02f1\u02f4\u02ffˢ\u0305\u02f4\u02f7\u02e5ˤˎ\u0311ˡˠ\u02d6\u02e9ˢ\u02f2\u0305\u02d7ˍˍˍˍˣ\u02ef\u02ef\u0305\u02f4\u0315ˣ\u200c،\u02e8\u02eb\u0305\u02e5ˤ\u0301\u200c،ˤ\u0309\u0310\u02d4\u0306ˣˣ\u02e7\u02ebˎ\u200c،\u02dfˡ\u02f2\u02e7ˮ\u0306ˎ\u200c،ˠ\u02f8ˢ\u02f2\u0305\u02f8ˍˍˍˍˠ\u0317\u030d\u02f0ˠ\u02f1ˡ\u0308\u02df\u02ef\u200c،\u0309\u0317ˡ\u0312\u0308\u200c،\u02df\u02f5\u02efˎ\u02d2\u02dfˍˍˍˍ\u0315\u200c،\u02dfˠ\u02eb\u0315ˠ\u02dfˢˎ\u200c،\u200c،ˠ\u0305\u200c،ˣ\u02f6\u02d2ˣ\u200c،\u02dfˣˣ\u0315\u02f4ˉ\u02df\u0305\u200c،ˠˠ\u02eb\u02e5\u02e9ˎ\u02e7\u02f0ˠˣ\u02f3\u02eb\u200c،\u200c،\u0301\u200c،\u200c،\u02e9\u02eb\u200c،\u200c،\u02ea\u200c،\u200c،\u02e6\u200c،\u200c،\u02e9\u02f3\u200c،\u02dfˡ\u02f2\u200c،\u200c،\u030d\u0315\u200c،\u02dfˣˣ\u200c،\u200c،\u0301\u200c،\u200c،\u02f5\u02ef\u200c،\u02df\u02e6\u0309\u200c،\u200c،\u200c،\u200c،\u02dfˎˠ\u0301\u200c،\u02df\u02f7\u030b\u02e5ˠ\u02ebˣ\u02e9\u02d5\u02d2\u02f5ˡ\u0306ˣˤ\u02e6ˑː\u02f2\u02e7ˮ\u02d2\u0318\u200c،ˠ\u02f8ˣ\u0315\u02ef\u0310\u0310\u02ef\u02d2ˣˢ\u0305\u02f4\u0306\u02e6\u0317\u0316\u02f8ˠ\u030bˤˤ\u02df\u02ef\u200c،\u200c،\u02f3\u200c،\u200c،\u0302ˣ\u0315\u02ef\u0310\u030a\u02f0ˣˤ\u02e6\u0317\u02ed\u02f2\u02e7\u02e6ˏ\u02d7\u200c،ˠ\u02f8\u02e9ˉ\u02d6\u02edˠ\u02df\u0311\u02f0ˠ\u02f1ˠ\u02e6\u02df\u02ef\u200c،\u0309\u0317\u02dfˮ\u02f7\u0305\u200c،\u02f5\u02f0\u02ebˣ\u02ed\u02e6ˢˍˍˍ\u02d6ˡ\u0308\u02df\u02e7\u200c،ˠ\u0311ˢˠ\u02df\u02f4\u0314\u02e7\u200c،\u02dfˡ\u0305\u0311\u02f5ˣ\u0315\u02ef\u02d2\u02f5\u0304ˍˍˍ\u0315\u02f7\u02f6\u02f5\u02df\u030d\u02edˠ\u02f1\u02f4\u02ffˢ\u02df\u02d2ˤˡˤ\u0305\u02ebˣ\u02ef\u02f7\u0305\u02d6\u200c،\u200c،\u02e8\u02eb\u0305\u030c\u030a\u0305\u200c،ˤ\u0309\u02f2ˠˢ\u0305ːˍˍˍˍˡˠ\u0306\u0302\u02ea\u02ef\u0305\u02f6ˣ\u0315\u02ef\u02d2\u02e9\u0304ˍˍˍ\u0316\u0309\u0310\u02d7\u0305\u0301\u030f\u02e5\u02f0\u02ebˣ\u02edˠ\u0318ˍˍˍ\u02d6\u02f2\u02eb\u02df\u02eb\u02df\u02d5\u0305\u200c،\u200c،\u030d\u200c،ˠˤˉ\u02df\u0305\u200c،ˠˠ\u02eb\u02e5\u0304\u0305\u02ef\u200c،\u02df\u02ef\u02f2ˠ\u0317\u0312ˢˣ\u02ef\u02f4ˤˢ\u200c،\u200c،\u200c،\u200c،\u02dfˡ\u02f2\u200c،\u200c،ˣ\u0315\u200c،\u02df\u02e7\u02eb\u200c،\u02dfˠ\u02f8\u200c،\u200c،\u0300\u0315\u200c،\u02dfˤ\u0309\u200c،\u02dfˡ\u02f4\u200c،\u200c،\u02f0\u0315\u200c،\u02dfˤ\u0309\u200c،\u200c،\u02eb\u200c،\u200c،\u02f5\u02ef\u200c،\u02dfˬ\u02df\u02f7\u200c،\u02df\u02e5\u02e8\u0306\u02d6\u02e9ˣ\u0315\u02f3\u0310\u0314\u02f0\u02f7\u02e9\u02e5ˠ\u02ebˤ\u02e9\u02d5\u02f7\u02edˠ\u02df\u02f4\u0306\u02e6ːˤ\u02f8ˠ\u030bˤˤ\u02df\u02ef\u200c،\u02dfˠ\u02e7\u200c،\u200c،\u02f0ˠ\u0307\u02df\u0304\u02df\u02ef\u200c،\u0309\u0317\u02df\u02d4ˏ\u02ef\u200c،\u02f5\u02f0\u02ebˤ\u02e9\u02d3\u02e7\u02f0ˠ\u0317ˡˠ\u200c،\u200c،\u0309\u0317ˠ\u0301\u0304\u0315\u200c،\u02f5\u02f1\u0314\u0311ˣ\u0305\u02eaˉˤ\u02ef\u02d2\u200c،\u02dfˣ\u02e7ˡ\u0316\u0311\u02f2ˠ\u02f2\u0306\u0315ˍˍˍˍ\u02df\u030d\u0315ˡ\u200c،\u02df\u0300\u02df\u0315\u02f0\u0314\u02e7\u02ef\u200c،ˡ\u0305\u0311\u0300ˣ\u0315\u02f3\u02d2\u02f5\u0314ˍˍˍ\u0315\u02f7\u02f6\u02f5\u02df\u030dˤ\u02e8\u02f4\u030dˬˠ\u02ef\u030a\u02f7ˢ\u02f0\u0309\u02f2ˠ\u02f2\u0306\u02e5ˍˍˍˍˡ\u02f0\u0306\u0302\u02ea\u02ef\u0305\u02f6ˣ\u0315\u02f3\u02d2\u02ed\u0304ˍˍˍ\u0316\u0305\u0310\u02d7\u0305\u0301\u030fˣ\u02ef\u02f7\u0304ˣ\u02d3\u02eb\u0305\u02ff\u02e9\u02e7\u200c،ˤ\u0309\u02f2ˠ\u02f2\u0305\u0307ˍˍˍˍ\u200c،\u02df\u02f2\u02eb\u02df\u02eb\u200c،\u0315ˣ\u200c،ˠ\u200c،\u02dfˠˤˉˠ\u200c،\u02dfˠˠ\u02eb\u02e5\u0304\u0305\u02e7\u200c،\u02df\u02ef\u02f2ˠ\u0317\u0312\u02eaˣ\u02ef\u02f4ˤˡ\u0315\u200c،\u02df\u02e9\u0315\u200c،\u02dfˡ\u0313\u200c،\u200c،\u0310\u200c،\u200c،ˤˎ\u200c،\u200c،\u02f7\u200c،\u200c،\u02f0\u02ef\u200c،\u200c،\u200c،\u200c،ˠ\u02d5\u200c،\u200c،\u0307\u200c،\u200c،ˡ\u0315\u200c،\u200c،\u0311\u200c،\u200c،ˎˠ\u0309\u200c،\u02df\u02f7\u030bˣ\u02ef\u02f7\u0305\u02f7\u02efˣ\u200c،\u02e8\u02eb\u0305\u0306\u0312\u030d\u200c،ˤ\u0309\u02f2ˠ\u02f1\u0313ˏˤ\u0305\u030d\u02f0ˠ\u0317\u02df\u0314\u02df\u0305\u200c،\u0309\u0317ˢ\u0307\u02f1\u0315\u200c،\u02f5\u02f0\u02ebˤ\u02e9\u02d4ˣˣ\u02dfːˣ\u0304\u02f5\u030a\u0309\u02e5\u02f7\u02f3\u02f3ˠ\u200c،\u200c،ˠ\u02ef\u200c،\u02dfˠ\u0311\u02f2ˠ\u02f1\u0313\u02ea\u02e5\u02f1\u0314\u02d3\u02e6\u0315ˎ\u02eaˣ\u02ef\u02f7\u0305ˎ\u0315\u200c،\u02df\u02e8\u02eb\u0305\u030b\u02f6\u02e7\u200c،ˤ\u0309\u02f2ˠ\u02f2\u0306\u0315ˍˍˍˍ\u02df\u030d\u0315ˡ\u200c،\u02df\u0300\u0300\u0317\u02e7\u200c،\u02df\u030d\u02eaˣ\u02ef\u02f7\u0304\u0300\u02d3\u02eb\u0305\u030a\u02f8\u02eb\u200c،ˤ\u0309\u02f2ˠ\u02f2\u0306\u02f1ˍˍˍˍˠ\u0306\u0302\u02f7ˡ\u0307ˠ\u030cˡ\u200c،\u02dfˢˠ\u02d6\u02e8ˢ\u02f1ˢˬ\u02df\u0305\u200c،ˡˠ\u030a\u0300ˡ\u02f4\u0309\u0317ˡˠ\u02f7\u02f2ˠ\u02f2\u0305\u0316ˍˍˍˍˣ\u02ef\u02f7\u0305ˢ\u02efˣ\u200c،\u02e8\u02eb\u0305\u02d7\u02d6\u200c،\u02dfˤ\u0309\u0310\u02d4\u02ef\u0301\u030fˣ\u02ef\u02f7\u0304\u0303\u02f8\u02eb\u0305ˬ\u0302\u0305\u200c،ˤ\u0309\u02f2ˠ\u02f2\u0305ˬˍˍˍˍ\u02dfˠ\u02eb\u0315\u02df\u0315ˢˉ\u200c،\u200c،ˤ\u200c،\u02dfˣ\u02f6\u02d2ˡ\u200c،\u02dfˣˣ\u0315\u02f8ˉˠ\u200c،\u02dfˠˠ\u02eb\u02e6\u02e9\u0318\u02d6\u02f0ˠ\u02f3\u02f3\u02ea\u200c،\u200c،\u0305\u02ef\u200c،\u02dfˣ\u02ef\u200c،\u02dfˠˡ\u200c،\u200c،\u200c،\u200c،\u02df\u02e6ˎ\u200c،\u02dfˠ\u02f5\u200c،\u200c،\u030f\u02ef\u200c،\u02dfˤ\u02f7\u200c،\u200c،\u02f2\u200c،\u200c،ˢ\u200c،\u200c،\u02e9\u02e7\u200c،\u02dfˢ\u02ef\u02e5\u0305\u200c،ˠ\u0307\u02f7\u0304ˡ\u02f0\u02ebˤ\u02e9\u02d6ˣ\u02f5ˡ\u0306\u02d2\u02f2ˠ\u02f1\u0313\u02d4ˠ\u02ef\u02f0\u0306\u02e5ˏ\u0309\u02e5\u02f7\u02f3\u02f3ˠ\u200c،\u200c،ˢ\u0315\u200c،\u02dfˠˣ\u02e5\u02e6ˎ\u0317\u02f2\u02e7\u02e5\u030c\u02ea\u200c،ˠ\u02f8ˣ\u0315\u02f3\u0310\u030b\u0316ˣ\u02e5\u02e7\u02e6\u02d2ˠ\u200c،ˡ\u02f2\u02e7ˡ\u02e8\u0308\u200c،ˠ\u02f8\u02e9ˉ\u0315\u02f3ˡ\u0316ˣ\u02e5\u02e6\u0318\u02f1\u02f2\u02e7ˤˣ\u030d\u200c،ˠ\u02f8ˣ\u0315\u02f3\u02d2\u0302ˍˍˍˍ\u0315\u02e9\u02ebˠ\u02ef\u200c،\u02e5\u0315\u02ed\u02eb\u02df\u0305\u200c،\u02e5\u0317\u0305\u0308\u200c،\u02df\u02e9ˡ\u0316ˣ\u02e6\u02e7ˠˣˠ\u200c،ˡ\u02f2\u02e7\u02ea\u0305\u02f8\u200c،ˠ\u02f8ˣ\u0315\u02f3\u02d2\u02f3ˮˍˍˍ\u0315\u02f7\u02f6\u02f5\u02df\u030d\u0305ˡ\u02df\u02ef\u200c،\u02df\u0315\u0304ˢ\u0305ˎ\u0305\u02df\u0305ˣ\u200c،\u02df\u0305\u02ff\u02f5\u0315\u030a\u02f8\u02eb\u0305\u0309\u0304ˡ\u0306\u02ebˤ\u02edˡ\u02d5ˍˍˍ\u02d6\u0303\u02e9ˍ\u02f7\u02e6\u0302\u02f1\u200c،\u200c،ˣ\u030fˣ\u02ef\u0301\u0304\u02f4\u02f8\u02eb\u0305\u030a\u0306\u02f3\u200c،ˤ\u0309\u02f2ˠ\u02f2\u0305\u02f1ˍˍˍˍ\u200c،ˢˍ\u030f\u0312\u0316\u0314\u02f1\u0308\u0315\u030b\u030b\u02e9\u02eb\u030dˬ\u02f1\u0315ˉ\u030c\u030e\u0312ˑ\u0314\u02e8\u02e5\u02f8ˍ\u02d2\u0302\u02d6\u02e6\u02d5\u0314\u02d5ˉ\u0312ˎ\u02ff\u02e8\u02eaˏˬˠˬ\u0312\u0304\u030f\u02f4\u02e7\u0314\u0303ː\u030f\u0307\u0304ˠ\u0317\u030d\u02d7\u0314\u0309ˬ\u02e7\u030fˍ\u0302ˮ\u0313ˑ\u02ef\u0302\u02f0\u0312\u0314ˎˣ\u0307\u0300ˬ\u02d2\u0301\u02df\u02d3\u0314ˣ\u0302\u0318ˮ\u02d7\u030b\u02ef\u030bˑˣˎ\u0306ˑ\u02d5\u02f3ˏ\u02ef\u030b\u0316\u02f3ˏ\u0308\u02e7\u0300\u02e5\u0301\u02edˍ\u0301\u02d6\u02e9\u02d5\u02f3\u02dfˏ\u0314ˍˉ\u02f6ˢ\u0302\u02f6\u02f3\u0313\u02f1\u02d3\u02ebˏ\u02eaˮ\u0311\u02e5ˑ\u02d7\u02f8ˤ\u02f3\u030d\u02d6ˬˑ\u02ffˬ\u030a\u02ffˎ\u02d2\u030bˣ\u030c\u0308\u02f3\u030a\u02f8\u0312\u02f4\u0304\u02dfˣ\u02eb\u02d5ˬ\u02f3\u0302\u0317ˣˡ\u030e\u0305\u02f8\u030a\u030a\u02d3\u02f0\u0313\u02d3\u02f1\u02d2\u0300\u030a\u02f8\u02f1\u030cˏ\u02e5\u0315\u0306\u0308\u030c\u0308ˠ\u02eb\u0316\u02f8\u0313\u02ef\u02f3ˍ\u02e8\u02f5\u0314\u02ea\u02ef\u0315ˏ\u02e9\u0310\u02d7ˑ\u0306\u0312\u030c\u0309\u0306ˬ\u02d5\u02f5\u0301\u02d7\u02eb\u0313\u02e6\u02e5\u02ef\u02edˠ\u030b\u0314\u02f6\u0301\u02e7\u02f7\u0311\u02eaˤ\u0316ˢ\u0313\u0313\u02d7ˮ\u02e5ˡ\u0311ˎˮ\u02d7\u030f\u02eb\u02ef\u02d2\u0301\u02d5\u030f\u02e5\u0310\u0305\u0305\u02e5ˉ\u0302\u02df\u030d\u02ff\u0313\u0306\u030d\u02f8\u02d5\u0309\u0308\u02f5\u02f5\u02f3\u02df\u02f0\u02d6\u030eˬˠ\u030a\u0305\u0306\u02d6\u02d2ːː\u02e8\u0311\u02f0\u02d4\u0303\u0307\u0304\u02f4ˬ\u0314\u0302\u02ff\u030c\u0304ˉˑ\u02f8ˑ\u02f8\u02e5\u02f2ˤ\u0301ˣˮ\u0318\u0315\u030a\u02e8\u0308\u02d4\u02ff\u02e6\u02f5\u02f8ˡ\u02e9ˏ\u02f6\u02f0\u030bˮ\u0308\u0304\u02ed\u030a\u02d5\u0300ˬ\u02e7\u02ed\u02e9\u02f3\u030c\u02f5ˬ\u030a\u02f3\u02e9\u0311\u02d4\u030d\u030b\u02e8\u0305\u030d\u02ed\u02eb\u0309\u02df\u02f2ː\u0318\u0317\u030e\u02f2\u0315\u0308\u0318\u0310ˤ\u0318\u030a\u02d4\u02f1\u02df\u02f2\u02e8\u02d4\u02f0\u02e8\u02d5ˍ\u0309\u0311\u02e8ˎ\u02d3\u030c\u02d7\u0313\u0307\u0304\u02f4\u02f0ˣ\u02f7ˠˢ\u0304\u02e7\u030c\u02f7ˎ\u02e9\u0313\u0307ˉ\u02e6\u02f2\u0309\u02f3\u02d2ˬ\u0305\u0307\u02f6\u02d6\u02f7\u0316\u02e6\u02df\u0300\u02e5ˣˬ\u02ffˑ\u02e6\u02f0ˏˤ\u0303\u0306\u02f5ˡ\u0306\u02f0\u0305\u0301ˏˮ\u030c\u0309\u0313ˎ\u0301\u02d6ˑˬˉ\u030dˡ\u02f7\u02f2ˢ\u02e8\u02e9\u02e5\u0306\u0308\u030d\u02df\u0313\u0310\u0302ˉ\u0302ˠˎ\u02f3\u02d6\u02f7\u0311\u0317\u030d\u0304ˤ\u02f6\u0317ˤ\u02dfˬ\u0311\u02f5\u0315ˮ\u02f7\u0309ˣ\u0305\u0317\u02f8\u0316\u0314ˍ\u02d3\u0303\u030e\u02d5\u02f6\u0315\u02d7\u02f6\u02d6ˬˑ\u0314\u030e\u0311\u02e5ˤˬ\u02f4ː\u02d3ˑ\u0310\u0306ː\u0306\u0318\u02d5\u02ed\u0306\u02ef\u030f\u0307\u030e\u02d6\u0314\u0300\u030dˏˢ\u0305\u030a\u02e5\u02f5\u0301\u0303\u02e8\u0316\u02f5\u0308ˠ\u0314\u02d7ˎ\u02e7\u02d4\u0301\u02ff\u02e8ˬ\u0314\u02f5\u02f6\u0304\u02f8\u0309\u0313\u02e6\u02d2ˉ\u02f7\u02f1\u0308\u0310ˬˮ\u02d2ˎˎ\u0300ˡˤ\u02f5\u0308\u030a\u0318\u02f4\u02df\u0306ˉˠ\u0318\u0314ˢː\u030a\u02f7ˬˉ\u0308\u0310ˍ\u0300\u02f0\u030b\u0315\u0318\u030c\u0314\u02f0ˉ\u0303\u0314\u0315\u02d5\u02ef\u0307\u030d\u02eb\u030fˡˬ\u030eː\u02d5\u02df\u02eb\u0318\u02f8\u02df\u02efˏˍ\u030c\u0301\u0314\u0307\u02f8\u02d2\u02f7ˣ\u02eaˢ\u02f1\u02f1\u0308\u02f5ˬ\u02d3\u02f5\u0315\u0305ˠ\u0309ˑ\u02d3\u0302ˍˍ\u02e9\u030e\u02ed\u02ed\u02f5ˣ\u0307\u0300ˎ\u02ea\u0301\u0300ˠ\u0312ˏ\u0303\u02f1\u02d5\u0313\u030c\u0317\u0310\u0310\u0313\u0317\u02f6\u02d3\u02d2\u02f0\u02f7\u0304\u02eaˠˉ\u02d2ˉˍ\u02e7ˑ\u0305\u030f\u02eb\u030e\u0313\u0317\u0309ːˎ\u0307\u02d2\u030f\u02f4\u0312\u02f7\u02efˢˑ\u02d2\u0312\u02d6\u030f\u0310\u0316\u030c\u0309ˏ\u0302\u0313\u02ed\u0312\u02d2\u0313\u02e5\u0302\u02e5\u02d3ˬ\u030f\u0313\u02f6\u02e5\u0315\u02f6\u02f4\u030f\u0305\u02ff\u030dˑ\u02d7\u0315\u0300\u030b\u02e5\u02f4\u02e5\u02ffˉ\u02e8\u030f\u02f0\u02edˠ\u02d5\u02f2\u02e9\u02d3\u0301\u02f8\u02d2\u02e6\u02ef\u0312\u02f4\u02d2ˣˣ\u02f8\u0306\u02f1\u02eb\u0306\u02e5ː\u0302ˍ\u030a\u0308\u0312\u02ed\u02e8\u0305\u02e6\u030b\u0302\u0312ˡˢ\u0314ˎ\u02f2\u030f\u02e8\u0315\u02e5\u02d5\u0311\u02eaˡˠ\u02e6\u0312\u0308ˢ\u02ef\u02d7\u02e6ːˎ\u02ea\u0314\u0318\u02df\u0316\u030f\u0303\u02d5\u02f3ˢ\u0316\u0302\u0313\u0303\u02e9\u02ea\u0300\u0305\u02f1\u02e6\u030cˎ\u0303ˬ\u0308\u02d4\u02e8\u030d\u02d7\u02e9\u02df\u02f0ˤ\u02ea\u02f6\u0309ˉˑˢ\u0309ˬ\u0315\u030c\u02eb\u030f\u02ea\u02f2\u0306\u02f8\u02e8ˠ\u02f4\u0306\u02f0\u0300\u0304ˡ\u030e\u02eb\u030d\u030a\u02ea\u0316\u0308\u02f7\u02f0\u02e5\u030d\u02f1\u0317\u0303ˣ\u0300\u02f8\u02e6\u0308ˣ\u02e7ˬˠ\u02ef\u02f3\u02d3\u0308\u0304\u0310\u0303ˎ\u030a\u0301\u0317\u02d7ˬ\u0314\u0303\u030f\u02d7\u0309\u0314\u0316\u030bˠ\u030e\u02f6\u02f7\u02d7\u02f6\u02ff\u0315\u02d5\u02d6\u02d3\u030bˤ\u0308ˍ\u02ebˡˡ\u02ebː\u02f7\u0313\u0303\u02ff\u0315\u030c\u02f5\u0317\u02ff\u02f1\u02e7\u02f8\u02f0ˉˣ\u02ff\u030b\u02f4\u02f0\u030d\u02e6\u0312\u0314\u02f8\u0312\u02f3\u0309\u02ff\u02f8\u0301\u0317\u02d4\u030a\u0304\u0314\u02e9\u0310\u02f4\u0312\u0313\u0305\u0301\u02df\u0301\u02d4\u02f1\u02ed\u0316ˣ\u0312ˬ\u02f4\u02df\u02f0ː\u02d3ˏ\u0316ˉ\u02d4ˡ\u0304ˤ\u0303ˢ\u030a\u02df\u0314\u0302\u030dˮ\u030b\u030d\u030d\u02df\u0313ˑ\u030cˠ\u02f4\u030f\u02f4\u0317\u02ed\u0307\u030a\u0308\u030b\u02d7\u0303\u02e5\u0306\u02ef\u0308\u0305\u02e6\u02e9\u02d4\u0307\u02d5ˤ\u030b\u0310\u02f7\u02d5ˑ\u02f5\u02d4ˠ\u02e6\u0303ˮˣ\u02f3\u0312\u02d7\u02d3\u0308ˬ\u02f6ˑ\u0305\u02e9\u02d7\u02df\u02e8\u0313\u02f8\u02ed\u030b\u030d\u0318\u0302\u030e\u02ef\u02e5\u030f\u0314\u02f2ˢ\u02eaˢ\u0301\u02e5\u0316\u0300\u0316\u02ea\u0306ˉˢ\u02d2\u0306ˠ\u02ef\u02ffˎ\u02ff\u030d\u02f0\u02e6\u02f2ˮː\u0309ˍ\u030a\u02df\u02e9\u02d2ˮ\u02eb\u02eaˣ\u0313\u0300\u0301\u02d7\u02ed\u0305\u02e5\u0303\u030a\u030f\u02d2ː\u0301\u02f5\u02f4\u0317\u02e5\u02f1\u0303ˬ\u0304\u0308\u030c\u02f8\u0310\u02d6\u02f8\u0303\u0310ˤˏˢ\u0316\u0308\u0314\u0301\u02f6\u0315\u02f2\u02f2\u02e8ˏ\u02d4ˣˎ\u030d\u02f4\u0300\u0312\u030cˑ\u02df\u02d5ˉ\u030e\u02d2\u0312\u0302\u02d2\u02f8ˍ\u0315\u02f8\u02f4\u02f5\u02d4\u02f4\u0315\u02d4\u030c\u02f4\u02e9ˠˣ\u0315\u02eb\u0303\u02f1\u02ef\u02f7\u02ed\u0315ˮ\u0305\u02d4\u030a\u0316ˑ\u02e6\u02d3\u030e\u02d5\u0316\u030f\u02ea\u0316\u0318\u030b\u0301\u0307\u02d2\u02f5\u0315\u0312ˎ\u0304\u02eb\u0310ˮ\u0316ˑ\u02e8ˉ\u02ed\u030cˣ\u030d\u0304\u0309\u02f7\u02f6\u0318\u02f8ˤ\u02f2\u02e5\u02f2\u0307\u030fˣ\u0302\u02d7\u0310ˎ\u030e\u030d\u02d3ˉˮ\u0302\u0305ˮ\u0302\u02e7ˏˣ\u0305\u02e6ˏ\u02f1\u02ebːˉˎ\u0309\u02d5ˡ\u02eb\u02e5\u02e5\u02d6ˡ\u02ef\u02f3ː\u02d2ˣˠˤ\u0300ˏˎ\u0315\u030cːˉ\u02df\u02eb\u0307\u030f\u030c\u02f5ˡ\u02f7\u02f7\u0303ˤ\u02f3\u02d7ː\u02f6\u0316ˤ\u02f1ˑ\u0309\u0306\u030e\u030b\u0311\u0317\u02e9\u030f\u02d6\u02d7ˤ\u02f4\u02f8ˢ\u02f2\u0308\u02d6\u02ff\u0317ˉ\u0303ˢ\u02e5\u0302\u0301\u02df\u02e8\u02ea\u02e8ː\u02ff\u02d7\u02f2\u02e7\u02dfˬ\u030e\u02f8\u02f1\u02d3\u02e6\u02f2\u030c\u0304\u0312\u0304\u02d5\u0310\u02f2\u02e5\u0303\u0304\u02f3\u030f\u030f\u0300\u0302\u0318\u0316\u02f8\u0308\u030c\u02eb\u0308\u030c\u02eaˣˍ\u0304\u0303ˏ\u030e\u02ff\u0300\u02f8\u02d4\u0310\u02dfˣ\u030e\u02e9\u02f7\u0307\u02f1ˑ\u02d3\u02e6ˮ\u02f1\u0311\u0304\u0308ː\u02f6\u02f8\u0305ˮ\u030c\u02f3\u0300\u0305\u0318\u0302\u030c\u0313ˣˢ\u02d4\u0302\u030a\u0303\u0308\u0308\u0314\u02ea\u02f2\u02f5\u02d6\u0308\u0301\u02d2ˡ\u0307\u02f5\u0307\u0303\u030a\u02f1\u0300\u030b\u030bˬ\u02e9\u02d4\u02e9\u0300\u0307\u02e8\u030d\u02e6\u02f8\u0304\u0306\u0316\u030f\u0306\u0315\u02ffˑ\u0305ˎ\u0309\u0310\u02d2\u0302\u02f6\u02e7ˠ\u02f6\u030b\u02f0ː\u030f\u02e6\u02d7\u0308\u02ed\u02d6\u02eb\u02e5\u02f0\u02f5\u0303\u02ff\u0306\u02e6ˏˬ\u02d2ˠ\u030fˡ\u030b\u02d6\u02ea\u0309\u0308\u0303\u0316\u02ea\u02ef\u0317\u0316ˑ\u02ed\u02f3\u02e8\u030f\u02f2\u02eb\u02f3\u0313\u0304\u02d2\u02ed\u02f6\u02f7\u0317\u0313\u0308\u02ff\u0311\u0303\u02e9\u0308ˎˠˠ\u0301\u02eaˮ\u02edː\u02df\u02f6\u030cː\u02ef\u02d5\u030e\u0312\u030e\u030b\u02f4ː\u02ef\u030f\u02d7\u0308\u0310\u02ff\u02f2\u0313\u02edˑ\u0300\u02f0\u0308\u02e7\u02f7ˤ\u0315\u0316\u030c\u02e9\u02df\u02e7ˉ\u0302\u0303\u0304\u030d\u0318\u0307ˣ\u02e8\u02f3\u0300\u02ed\u030d\u02f2\u02f0\u0318\u02d2\u02f7\u0315ˣ\u02ea\u02d3\u030b\u02d5\u030a\u0307\u0316ˤ\u030c\u02eb\u0314\u02f3\u02d3\u02f4\u02f6\u02e8ˡ\u02e9\u0309\u030a\u0313\u02e6ˏ\u02f3\u02ea\u030f\u02f6\u0300ˮ\u02e7\u0318\u02f3\u02d2\u0317\u030e\u02f0\u0308\u0314\u02f0ˏ\u0310\u02f4\u02d5\u02e6\u02eb\u02d2\u02d5\u0305\u02e5ˢ\u0311\u02f3\u02ebˢˣˍ\u02f4ˍ\u030bˍ\u02d5ˉ\u02f4\u02d2\u0307ˬ\u0305\u02eb\u0309\u0315ˍ\u02df\u02e8\u030b\u030f\u02d4\u02f4ˡ\u02f8\u0309\u02f8ˣ\u0313\u02e8ˠ\u02e8ˣ\u0305\u02eb\u02ed\u02f6\u02d2ˣ\u02f2\u02e6\u0305\u0311\u02f5\u0310\u0311\u0310\u0312ˬ\u02e7\u02f1ˉ\u0318\u02eb\u030bˏˬ\u0305\u02f4\u0310\u02edˠ\u02e7ˠ\u02eb\u02d2\u0302ˣ\u0313\u02d5ˏˢˠˬ\u02e6ˍ\u02e5ˣ\u030e\u02f0\u02f5\u0317\u0300\u030d\u0309\u0314\u0307\u02f2ˍ\u0317\u0315\u0303\u02f0\u02e6\u030b\u02ea\u02ff\u030a\u02d6\u02d6\u02f2\u030a\u0300ˡ\u0310\u02ffː\u0305ˤˬ\u02ea\u0316\u02f5\u0316\u02e6\u0313\u02d5\u0315\u0313\u0311\u02d3\u0317\u0312ˏ\u02d5ˢ\u02e8\u02f8\u030d\u02f8\u02d7\u02d3\u02e5\u02d2ˣ\u02d6ˤ\u02df\u0314\u02f5\u030b\u0302\u02d4\u02f5\u02ebˮ\u02f7\u02f5\u030b\u0302\u030a\u030d\u0315\u02f3\u02d3\u0316ˑ\u02d6\u02e8\u02f0\u0309\u0301ˉ\u02d4ˡˮ\u02ed\u02f8ː\u0314\u02f8\u02e6\u02ff\u0304ˍˏ\u02ff\u0311\u02f4\u030c\u02eb\u02e6\u02df\u0300ˠ\u02d2\u0303\u0318\u02ff\u02d7\u030e\u0305\u0301ˉ\u030e\u02e5\u030a\u0316\u02d3\u02d2ˬ\u030d\u02ed\u02ff\u0311\u02d5\u0315\u02e7\u0316\u030a\u02f0\u02eb\u02f6\u02df\u02d5ˮ\u02f1\u030f\u030b\u0308\u02eb\u0309\u02f6\u02d6\u0317\u02f0\u02f4\u02e5ː\u0316\u02e6\u02d3\u02e5\u0304ˑˬ\u02d7\u0305\u0302\u030f\u030dˡ\u02e9\u030eˣ\u02eb\u030d\u0313\u030aˢˣ\u0300ˑ\u0307\u02f6\u02eaˑˏ\u0302\u02df\u02e5\u02d4\u0303ˤ\u02f1ˑ\u0302\u02d6\u02e8\u0301\u02d3\u02d5\u0315\u0308\u02d4\u02ffˤ\u02d6\u02f4\u0314\u02d3\u0312\u0313\u0305\u02e7\u02f3ˍˡˍ\u02d7ˑ\u02d4\u02eb\u030c\u0314\u030b\u02e6\u02f0ˍ\u02d4ˉ\u0303\u02f5ˢ\u02d6\u02d2\u02e7\u02e5\u02d3\u0306\u0300\u02f5\u0310\u02f8ˎ\u02f0\u02d2\u02efˠ\u02ed\u02d5\u0304\u0316\u02ef\u0316\u02d3\u0309\u02d4\u02ff\u02eaˡ\u030c\u02e8\u02eb\u030e\u0300ˢˍ\u02e6\u0304\u0303\u02f5\u030f\u02d2ˉ\u02e5\u0315\u02f6\u02eaˤ\u030f\u02f7ˤˣ\u02ed\u02d4\u030c\u02ebˍː\u02dfˠ\u02ed\u02e7\u02ff\u0315\u0308\u02ff\u0305ˣˎ\u0306ˉ\u02ff\u02ff\u02d3\u0305\u0304\u02f8\u02f8ˑ\u02d7\u02edˢ\u0307\u02d2\u02f0ˡ\u0315\u0313ˑ\u02f5\u02d3\u02e9\u030f\u0305\u0310\u0312\u02f1\u02d2ˢ\u0314\u02f4\u0316\u0313\u0307\u02d2\u02d4\u02f8\u0318\u02ff\u0302\u0303\u0313\u0312\u0303\u0302\u02efˤ\u02f8\u02f2\u0304\u02e9\u0317ˉ\u0312\u02f1\u02f5\u02d4\u0301ˠ\u030d\u02e8\u02ef\u030c\u02e6\u02eb\u0303\u02eb\u02e5\u02e7\u02ef\u02d2\u02e7\u030cˣˠ\u0302ˤ\u02f3ˑ\u0318\u02ea\u0310\u02d2\u02d4\u0318\u0300\u0315\u0312ˣˡˉ\u030c\u02f5\u02f4\u02f3\u0311ˠ\u0308\u0300\u030c\u0306\u0300\u0300\u0302\u02ea\u02e5\u02ef\u0307\u02e6\u02e7\u02ef\u0310ˠ\u0318\u02d5\u02e9\u02f4\u0301ˢ\u030e\u0302\u0313\u02f4\u0317\u02eaˤː\u0312ˢˬ\u0318\u0307\u02e8\u02e8\u0303\u02eaˣ\u0307\u02d6\u0302ˤ\u0307\u0303ˤ\u02edˣ\u0311ˮ\u02d3\u030a\u02e5\u0301\u0310ˤ\u02e9\u0313\u02eb\u02e6ˏ\u030fˬ\u0308\u030d\u030b\u0300\u02f2\u030cˮ\u02e6\u02edˏ\u02dfˤ\u0308ˎ\u02dfˉ\u02f3\u02f0\u030fˮ\u030a\u02eaˬ\u030d\u0300ˤˎ\u0312\u02e6\u02ff\u0314\u02f1\u0310\u0315\u0306\u02f2\u030aˢ\u0303\u02f3\u02e9\u0313\u0307\u0305\u02f8ːˮˡ\u02f0ˏ\u02d4ˍ\u02f4ˮˎ\u0301ˤ\u0312ˮ\u02f7ˑ\u0310\u0315\u0312\u0307\u0305\u0301\u0308\u0316ˑˑ\u030a\u02e5\u0303\u02f6\u02d3ˤ\u0303\u0318\u02dfˎ\u02d6\u02f8\u02d2ˍ\u030b\u02f3ˉ\u02f6\u02e9ː\u02e9\u0304\u0313\u0314ˡ\u0306\u0314\u030f\u02f3\u02f3\u030eˍ\u02ef\u02d4\u0305\u02d7\u030d\u02ef\u0305\u0312\u0317\u030e\u02d7\u0310\u02ffːˏ\u0314\u02d2ˬ\u0313\u02e6\u0301\u0310\u0313\u02e6\u030a\u0313\u0300\u030c\u030cːˎ\u0309\u0302\u02dfˏ\u0308\u0302ˮ\u02eb\u0317\u02d4\u02f6\u02f6ˤ\u030c\u030e\u0301\u02e8\u0314\u0316\u02d2\u030b\u0306\u02ed\u02ed\u02e5ˑˎ\u030a\u0309ˑˬ\u02e7\u02f8\u0313ˏ\u030e\u0303\u02e7\u0306\u0310\u02efˮ\u02f0\u030d\u02f0\u02f1\u02f5\u0312\u0309ˤ\u02f1\u02d6\u02e5\u02f2\u02d5\u0306\u0315ˣ\u0315ˍˤ\u0302ˮˎ\u0301\u02f1\u02d6\u02ff\u030aˉˉˮˑ\u0318\u02f3ˡ\u02f4\u02f2ˤ\u02f4\u0301\u02f7\u0307ˉ\u02d7\u0305\u02e6ˠˣ\u02d4\u030d\u02d3ˮ\u02ef\u02f6\u02ff\u0314ˠ\u030b\u02e7ˮˍˮˠ\u02ea\u02f8\u02e9\u02f4\u02eaˮ\u02f7\u02ed\u02eb\u02e8\u0314\u0305\u0309\u02f6\u0312\u0308ˣˬ\u0306ˮˮ\u02f0\u02ebˏ\u02e8ˣ\u030eˉ\u0308\u0315\u02f6\u02f7\u030e\u02f3\u02e5ˬˠ\u0312ˉˣˮ\u0302ˮ\u02f0\u0305ˍ\u02f8ˑˍ\u0312\u0302\u02f8\u0302\u0310\u0312ˍ\u0307\u0301\u0316\u02e5\u0316\u030c\u02f4ˤ\u02d2\u02f2\u0307\u030e\u02d7\u02e5\u02ff\u0301\u0301\u02e7\u0302\u02f1\u02ef\u0318\u02df\u02d5\u0305\u02f8\u02e5ˣː\u0313\u02dfˤ\u02eb\u0303\u0312\u0307\u0315\u0307\u02f6\u0312\u02f0\u02d7\u02e9\u02ed\u0311\u02f4ːˢ\u02f5\u02e8ˤ\u0305\u02f4\u02d6\u030e\u02f8ːˏ\u030f\u02d4\u02d4\u02d2ˮˤ\u02e9ˑˑ\u02eb\u02f0\u0308ˢ\u0315\u02e7\u0308\u0318\u02f3ˏ\u030b\u0303\u02d3ˢː\u02e9\u02d6\u02ef\u02f1ˑ\u02e8ˬˎ\u02e9\u0307\u0316\u02f3ˏ\u030b\u0304\u02d6\u030aˮ\u02f7\u0308\u02ff\u0302ˤ\u02eb\u0303\u0304\u02f3ˮ\u0318\u02d3\u02d2\u0314\u030b\u0306\u0313ˮ\u030bˎ\u02e8ˬ\u02e8\u0317\u02f4\u0307\u030eˣ\u0313\u02e8\u0304ː\u02dfˣ\u02e6\u02f1\u030bˮ\u02f1\u030b\u02f0\u0314\u0309\u0303\u02d6\u02f1\u02f5\u0313\u0301\u02f7\u0310\u02ff\u02d6\u02f6ˉˏ\u0313\u02d7ː\u0312ˬ\u02e9\u0316ˬ\u02f1ˑˏ\u0311\u0316\u02d2ˤ\u0317\u02ea\u02d6\u0303\u02f7\u0311\u02f2\u0318\u02d3\u030f\u02ea\u02d5\u02d6ː\u02e7\u0300\u02e7ˡˢ\u02d7ˮ\u02e8\u0303\u02f8ˢ\u0317\u0311\u02df\u02e5\u0318\u02f4ˍ\u02d2\u02f7ˠ\u0309\u0318\u0307\u02f0\u02df\u02e5\u030fˏ\u0308\u0315ˠ\u030f\u0316\u030e\u030eˬ\u02d5\u02f4\u02e8\u0303\u0302ˏ\u0300\u02f0\u02f6\u02d5ˬ\u02e9\u030eˤ\u02e6ˮ\u02f0\u02f2\u0315\u02f7\u0313ˬ\u02f1\u02f8\u030b\u030b\u02f4ˉˍ\u0305\u02e5\u030a\u02e7ˤ\u0304\u02d2ˎ\u02ff\u0303ˡ\u02d4\u02e8\u02eb\u0306\u0316\u0318\u030a\u02f6\u0307\u0312\u02ff\u0309\u0304\u0305ˣˡ\u0318\u02d2\u02df\u030dˬ\u0317ˢ\u030b\u02e8\u02d6\u02edˠ\u0305\u0308\u0316\u0310\u02f3\u02ef\u0301\u02ff\u0302\u030c\u0300\u02d4\u02d2\u02ef\u0306\u02eaˎ\u0312\u02df\u02ed\u02ed\u030b\u030c\u02f8\u02ff\u0306\u030b\u0314\u0314ˠ\u0311\u02e8ˏ\u02d6\u0309\u0310\u02f1\u02eb\u0317\u030f\u0305\u02f4ˉ\u0318\u030bˍ\u030e\u02ff\u0308\u02eb\u02d7\u030b\u02ed\u0314\u0300\u0305ˤˬˎ\u0311\u02d4\u02ff\u0316\u02e8\u0310\u02ed\u030b\u030b\u02d4\u02e5\u030b\u02e9ˑ\u030d\u030d\u02df\u02ed\u02d3ˏ\u030e\u0313ˑ\u030d\u02ef\u030b\u0311ː\u02f8\u0302ˮ\u0306\u0312\u02ed\u0312\u02ea\u02d5\u0301\u030a\u0312\u0317\u02d4ˑ\u02d3\u02e8\u02ef\u0311\u0312\u030aˡ\u02eb\u02d7\u02e7ˣˬ\u0313\u030d\u02f5\u0310\u0300\u030d\u02df\u0303\u0308\u0304\u02d4\u02f3ˠ\u02d5\u02f7\u0305\u0304\u0317\u02f8ˍ\u02e7\u030c\u02d6\u02df\u02f0\u0304\u02f0\u0301\u02e7\u030c\u02d3\u02df\u02f0ˮ\u030e\u02e8\u02e5ˑ\u02e7\u200c،ˣ\u02e8\u02f2\u02f1\u0309\u02e7ˠ\u200c،ˣ\u200c،\u200c،\u200c،\u02df\u0315\u200c،\u02dfˠː\u02eb\u0307\u02d2\u0315\u02ea\u0308\u02f3\u0315ˬ\u0318\u02e7ˑ\u200c،\u200c،\u200c،\u02ef\u02df\u02ff\u200c،\u200c،ˮ\u02ef\u02e5\u200c،\u02df\u0308\u0304\u0305\u200c،\u02f6\u02df\u0301\u200c،\u02ed\u02efˤ\u200c،\u02df\u0308\u02f3ˑ\u02f0\u0317\u02ff\u02f5\u02d3\u030c\u0301\u0315\u200c،\u200c،ˠ\u02dfˢ\u02ef\u200c،ˣ\u200c،\u200c،ˡˬ\u02e6\u02f4\u02f3\u030aˣ\u200c،\u200c،\u02f3\u02dfˎ\u200c،\u02df\u0315ˣ\u200c،\u02df\u0308\u02ef\u030b\u0316\u0314\u02f7\u0305\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u02e7\u200c،\u02df\u030e\u02f6\u030a\u02ef\u02e7\u030dˡ\u02f0\u02d2\u200c،\u02dfˢ\u02d4\u02df\u02f2\u02eb\u02dfˤ\u0305\u200c،\u02df\u02ef\u200c،\u02dfˢ\u200c،\u200c،\u02df\u02ea\u200c،\u200c،ˡ\u200c،\u200c،ˠ\u030d\u200c،\u200c،\u02e7\u200c،\u200c،\u02eb\u200c،\u200c،\u02dfˎ\u200c،\u200c،ˢ\u200c،\u200c،ˤ\u200c،\u200c،\u02df\u02f3\u200c،\u200c،ˢ\u200c،\u200c،\u02df\u02ef\u200c،\u200c،\u02ef\u200c،\u200c،ˣ\u200c،\u200c،ˢ\u02ef\u200c،\u200c،\u030d\u200c،\u200c،ˬ\u200c،\u200c،\u200c،\u02dfˠ\u200c،ˣ\u200c،\u200c،\u200c،\u02df\u02f7\u02df\u02f4\u0315\u02df\u0307\u200c،\u02f7\u02df\u02f6\u02dfˠ\u0310\u200c،\u02f7\u02df\u030b\u0315\u02df\u0307\u200c،\u02f7\u02df\u030d\u02ef\u02df\u0307\u200c،\u02f7\u02df\u0316\u0305\u02df\u0307\u200c،\u02f7\u02dfˏ\u02efˢ\u0301\u200c،\u02f7\u02df\u02d3\u0305ˢ\u0301\u200c،\u02f7\u02dfˉ\u02ef\u02df\u0307\u200c،\u030d\u02dfˍ\u0305\u02df\u02e8\u02df\u02ef\u030d\u02df\u02e6\u0315ˣ\u02e8\u02df\u02ef\u02f7\u02df\u02ea\u0315ˣ\u0307\u200c،\u02f7\u02df\u02f3\u0305ˤ\u0300\u02df\u02ef\u02f7\u02df\u0304\u02ef\u02e5\u02e8\u02df\u02ef\u02d2\u02df\u030c\u02dfˣ\u030e\u200c،\u02f7\u02df\u030d\u0305\u02e5\u02e8\u02df\u02ef\u02d2\u02df\u0310\u02dfˣ\u030e\u200c،\u02d2\u02df\u0311\u0305ˣ\u030e\u200c،\u02f7\u02df\u0313\u02ef\u02e5\u02e8\u02df\u02ef\u02f7\u02df\u0316\u02efˣ\u0307\u200c،\u02f7\u02dfˑ\u02dfˣ\u0307\u200c،\u02f7\u02dfˉ\u0305ˣ\u02e9\u02df\u0305\u02f7\u02df\u02e5\u0315\u02e7\u0309\u02df\u0305\u02f7\u02df\u02f4\u0315\u02e7\u0309\u02df\u0305\u02f7\u02df\u0301\u02df\u02e7\u0307\u02dfˠ\u02e7\u02df\u0302\u0305\u02e7\u02d2\u02dfˠ\u02e7\u02df\u0308\u02ef\u02e7\u02d2\u200c،\u02f7\u02df\u030a\u0305\u02e7\u0307\u200c،\u02f7\u02df\u02d3\u02ef\u02e7\u0307\u200c،\u02f7\u02df\u02e5\u0305\u02eb\u0306\u02df\u0315\u02f7\u02df\u02f1\u02df\u02eb\u0307\u200c،\u02f7\u02df\u02f4\u0305ˬ\u0309\u02df\u0315\u02f7\u02df\u0305\u02ef\u02eb\u0307\u200c،\u02f7\u02df\u0307\u02dfˬ\u0300\u02df\u02ef\u02f7\u02df\u02d6\u02dfˮ\u02d4\u02df\u0315\u02f7\u02df\u02eb\u02df\u02ef\u0307\u200c،\u02f7\u02df\u030a\u02df\u02f0\u0310\u200c،\u02f7\u02df\u0312\u02df\u02f0\u0310\u200c،\u02f7\u02dfˎ\u0305\u02ef\u0309\u02df\u0305\u02f7\u02df\u02d4\u02ef\u02ef\u0309\u02df\u0305\u02f7\u02dfˠ\u0305\u02f3\u0309\u02df\u0305\u02f7\u02df\u02e8\u02ef\u02f3\u0309\u02df\u0305\u02f7\u02dfˮ\u0305\u02f3\u0309\u02df\u0305\u02f7\u02df\u02f4\u0315\u02f3\u0309\u02df\u0305\u02f7\u02df\u0301\u0305\u02f3\u0309\u02df\u0305\u02f7\u02df\u0308\u02ef\u02f6\u02d4\u02df\u0315\u02f7\u02df\u030d\u02ef\u02f6\u02d4\u02df\u0315\u02f7\u02df\u0310\u0315\u02f3\u0309\u02df\u0305\u02f7\u02df\u0318\u02df\u02f4\u0310\u200c،\u02dfˠ\u200c،ˠ\u02ed\u200c،\u200c،\u200c،\u02dfˠ\u200c،ˣ\u200c،\u02ef\u02df\u02ef\u02df\u02ea\u0311\u02df\u0315\u200c،\u02f4\u200c،ˣ\u200c،\u0305\u02df\u02ef\u02df\u02ef\u200c،ˑ\u0305\u02ea\u02f0\u02df\u02e6ˣ\u200c،\u0315\u02df\u02e7\u200c،\u02dfˠ\u200c،ˢ\u0314\u02df\u0312ˣ\u02dfˤ\u02ef\u02dfˢ\u200c،\u0305\u02dfˣ\u02dfˣ\u200c،ˮ\u030dˡˎ\u02efˠ\u0316\u200c،\u02f3\u02dfˡ\u200c،\u200c،\u02ef\u200c،\u02df\u02ef\u02eb\u200c،ˠ\u02f3\u02dfˠ\u02ef\u02df\u02e7\u200c،\u02f3ˠ\u200c،\u02df\u02d6\u02df\u0315\u200c،ˤ\u02ef\u02dfˤ\u200c،\u030d\u02dfˣ\u0315ˣ\u200c،ˡ\u02f3ˣ\u200c،ˠ\u0316\u200c،\u0309\u02dfˣ\u0305\u02dfˤ\u02df\u02ef\u200c،\u02e9\u02ef\u02ef\u200c،ˠ\u02f3\u02dfˡ\u02ef\u02df\u02f1\u200c،\u02f3ˠ\u200c،ˠ\u02edˠ\u200c،\u02dfˤ\u02ef\u02df\u02e8\u02dfˠ\u02ef\u200c،\u02dfˣ\u200c،ˣ\u02dfˢ\u200c،\u02df\u02f4\u200c،\u0309\u02dfˤ\u0315\u02df\u02f2\u02df\u0301ˎ\u02df\u02e6\u0315\u02df\u02f2\u02dfˬˣ\u02df\u02e7\u0315\u02df\u02f2\u02df\u0304\u02f7ˡ\u02e8\u0315ˣ\u02f2\u02dfˮ\u02f7ˠ\u02e7\u0315\u02df\u0316\u02dfˣ\u02dfˢ\u02f5\u0305ˣ\u0316\u02dfˢ\u0305ˢ\u02f5\u0305ˣ\u0316\u200c،ˣˢ\u02f5\u0305ˣ\u02f2\u02df\u02f3\u02efˢ\u02f6\u0305ˤ\u02ef\u02e7\u200c،\u200c،\u02dfˡ\u02f0\u02e5\u02ea\u02ef\u02df\u02e5\u0315\u02dfˠ\u02df\u02e7\u0305\u0305\u200c،\u200c،\u02df\u02e8\u02f7\u02df\u02ef\u0315ˤ\u0301\u200c،ˣ\u02df\u0316ˡ\u02e7\u200c،\u200c،\u02df\u030a\u0305ˠ\u0313\u02df\u02f7ˎ\u200c،\u0305ˠ\u0315\u02e8\u200c،\u200c،\u02dfˡ\u02f0\u02dfˮ\u02f7ˠ\u0318\u0315\u02dfˣ\u02df\u02ea\u02ef\u030b\u200c،\u200c،\u02df\u02e8\u02f7\u02df\u02ef\u02df\u02ea\u0316\u200c،\u02ef\u02df\u02f4ˡ\u0301\u200c،\u200c،\u02df\u030a\u0305ˡ\u030c\u02df\u0307\u02dfˠˠ\u0305ˡ\u0309\u02e9\u200c،\u200c،\u02dfˡ\u02e5\u02e5ˮ\u02eb\u02df\u02f5\u200c،\u02e8\u02df\u02ea\u02ef\u030d\u200c،\u200c،\u02dfˠ\u02eb\u02df\u0318\u02ef\u02dfˉ\u02df\u02ef\u0309\u02df\u02d2ˡ\u0309\u200c،\u200c،\u02dfˣ\u0315\u02df\u02d2\u02dfˏ\u02ebˠˡ\u02efˡ\u0305\u02e9\u0305\u200c،\u200c،\u02df\u02f2\u02dfˮ\u02f7ˠ\u0308\u0305ˣ\u02e8\u200c،\u0305\u0312\u200c،\u200c،\u02dfˠ\u02eb\u02dfˎ\u02efˡ\u0307\u02df\u02ef\u0309\u02dfˍˡˎ\u200c،\u200c،\u02dfˣ\u0315ˢˬ\u02df\u02eb\u02ebˠˡ\u02ef\u02df\u0309\u02ea\u0315\u200c،\u200c،\u02df\u02f2\u02dfˮ\u02f7ˡˑ\u0305ˣ\u02e8\u02df\u02ea\u02ef\u0315\u200c،\u200c،\u02dfˠ\u02eb\u02dfː\u02dfˮˉ\u02df\u02ef\u0309\u02df\u0314ˢˣ\u200c،\u200c،\u02dfˣ\u0315ˢ\u0314\u02df\u0306\u0305ˡˡ\u02efˡ\u02e7\u02eb\u0305\u200c،\u200c،\u02df\u02f2\u02dfˠ\u02d2ˣˬ\u02df\u02e7\u02e8\u02df\u02e9\u0315\u0318\u200c،\u200c،\u02df\u02e8ˣ\u02f7\u0312\u200c،\u0300\u200c،\u0309\u02df\u0314ˢ\u02ef\u200c،\u200c،\u02dfˣ\u0315ˢ\u02f0\u02dfˤ\u0311ˡˡ\u02efˢ\u02dfˬ\u02ef\u200c،\u200c،\u02df\u02f2\u02df\u02ebˎ\u02df\u0302\u02ef\u02e7\u02e8\u02df\u02ea\u0305ː\u200c،\u200c،\u02dfˠ\u02eb\u02df\u0318\u02efˡ\u02f0\u02df\u0305\u0309\u02df\u030bˢ\u0301\u200c،\u200c،\u02dfˣ\u0315ˢː\u02df\u030f\u0311ˡˡ\u02efˡ\u030d\u02ed\u200c،\u200c،\u200c،\u02f2\u02dfˢ\u0305ˢ\u0312\u02ef\u02e7\u02e8\u02df\u02eb\u02ef\u02d3\u200c،\u200c،\u02dfˠ\u02eb\u02df\u02ed\u02dfˮ\u02eb\u02df\u0305\u0309\u02df\u0316ˢ\u030d\u200c،\u200c،\u02dfˣ\u0315ˢ\u02f0\u02df\u02ed\u02dfˡˡ\u02efˢ\u02df\u02ed\u0315\u200c،\u200c،\u02df\u02f2\u02df\u02ebˎ\u02df\u02d5\u02df\u02e7\u02e8\u02dfˬ\u02df\u02d6\u200c،\u200c،\u02dfˠ\u02eb\u02df\u02e8\u02ef\u02ef\u02e7\u02df\u0315\u0309\u200c،\u200c،ˠ\u02dfˣ\u0305ˠ\u200c،\u02dfˠ\u02df\u02e6\u02e7ˠ\u200c،\u02dfˡ\u02df\u02e6\u02f7ˠ\u200c،\u02dfˠ\u02dfˣ\u02efˡ\u200c،\u02dfˡ\u02dfˣˎˡ\u200c،\u02dfˠ\u02df\u02ea\u02f7ˡ\u200c،\u02dfˡ\u02df\u02eb\u02efˡ\u200c،\u02dfˢ\u02dfˬˣˡˣ\u02efˡ\u02ea\u02dfˠ\u02eb\u02df\u02ed\u02efˢ\u0318\u02dfˣ\u02e7\u02df\u02f1\u02efˢ\u0318\u02dfˤ\u200c،\u02f5\u02ef\u02df\u02d5\u02df\u02f4\u0305\u02df\u02e5\u02efˠ\u030c\u02df\u02f6\u02d6\u02df\u0303\u02efˢ\u0318\u02dfˤ\u0305\u02df\u030b\u02efˢ\u02e9\u02df\u0301ˣ\u02df\u0303\u02efˢ\u0313\u02df\u0301\u0305\u02df\u030f\u02efˢ\u0318\u02df\u02ed\u02f3\u02df\u030f\u02ef\u02dfː\u02df\u0313\u0315\u02df\u0317\u02efˡˡ\u02df\u0306ˣˠː\u02efˡ\u0307\u02df\u0306\u0311ˠ\u02e9\u02efˢ\u0318\u02dfˤ\u0305\u02df\u0305\u02ef\u02dfˤ\u02df\u0318\u030dˠ\u0305\u02ef\u02dfˮ\u02df\u0318\u030dˠ\u02d4\u02ef\u02df\u0317\u02df\u0316\u0311ˠˡ\u02ef\u02e6\u0318\u02dfˤ\u0305\u02dfˡ\u02ef\u02e5\u02f5\u02df\u02d2\u02ebˠ\u02e9\u02efˡ\u0302\u02df\u02d2\u030dˠ\u02df\u02ef\u02e5\u030b\u02df\u0318\u030dˠ\u0301\u02efˡ\u0316\u02df\u02d5\u030dˠ\u0301\u02efˡ\u02d4\u02df\u02d7\u030dˠ\u0301\u02efˢ\u200c،\u02d7\u030dˠ\u0301\u02efˢ\u02e5\u02df\u02d7\u030dˠ\u0303\u02efˢ\u02eb\u02dfˍ\u0301ˠ\u0311\u02efˢ\u0304\u02df\u0316\u02ebˡ\u0311\u02ef\u02df\u02f8ˠˡˎˡ\u02e5\u02efˣ\u02d7ˠˤ\u02efˡ\u02f7\u02efˠˤˠ\u02e5\u02d6ˡ\u02f7\u02efˠ\u02f4ˠ\u02e7\u0315ˡ\u0301\u02efˠ\u0304ˠ\u02e9\u02ebˡ\u02eb\u02efˠ\u0312ˠ\u02eb\u02efˡ\u0307\u02efˠ\u0317ˠˬ\u0309ˡ\u0303\u02efˠ\u02d5ˠˢ\u030dˠ\u02df\u02ef\u02e5ˤˠ\u02df\u02e7ˢ\u02e7\u02ef\u02e6\u0318\u02dfˠ\u02ebˢ\u02e9\u02ef\u02e6\u0318\u02dfˤ\u0305\u02df\u02eb\u02ef\u02e6\u0318\u02dfˣ\u02dfˢ\u02ed\u02ef\u02e6\u0318\u02dfˣ\u02dfˢ\u02ef\u02ef\u02e6\u0318\u02dfˣ\u02dfˢ\u02f1\u02ef\u02e6\u0318\u02dfˣ\u02dfˢ\u02f3\u02ef\u02e6\u0318\u02dfˣ\u02dfˢ\u02f5\u02ef\u02e6\u0318\u02dfˣ\u02dfˢ\u02f7\u02ef\u02e6\u0318\u02dfˣ\u02dfˢ\u02ff\u02ef\u02e6\u0318\u02df\u02eb\u0311ˢ\u0301\u02ef\u02e6\u0318\u02dfˣ\u02dfˢ\u0303\u02ef\u02e6\u0318\u02dfˣ\u02dfˢ\u0305\u02ef\u02e6\u0318\u02dfˤ\u0305\u02df\u02ea\u0305ˠ\u0310\u02df\u02f7\u02f3ˢ\u02ea\u0305ˠ\u0308\u02df\u02f7\u02f3ˢ\u02ea\u0305ˠ\u0300\u02df\u0300\u02ebˢ\u02ea\u0305ˡˢ\u02df\u02ef\u0301ˣ\u02ea\u0305ˠ\u02d5\u02df\u0304\u030dˢ\u02ea\u0305ˠ\u0318\u02df\u0302\u02dfˢ\u02ea\u0305ˠ\u02f2\u02df\u02ff\u02efˢ\u02ea\u0305\u02df\u0318\u02df\u02f3\u02f3ˢ\u02ea\u0305\u02df\u0310\u02df\u02f1ˣˢ\u02ea\u0305\u02df\u0308\u02df\u02f0\u0305ˢ\u02ea\u0305ˠ\u02ea\u02df\u02f7\u0311ˢ\u02ea\u0305ˠˢ\u02df\u02f7\u02f3ˢ\u02ea\u0305\u02df\u02d5\u02df\u02f5\u02efˢ\u02df\u0305ˢ\u0309ˠ\u200c،\u200c،\u0315\u02dfˡ\u02dfˤ\u0305ˢ\u200c،\u02dfˤ\u200c،ˣ\u02df\u02f0\u0305\u200c،\u200c،\u0305\u02df\u02e8\u0315ˠ\u0308\u02df\u02e8\u02f3\u02dfˏ\u0305ˢ\u02d2\u02dfˡ\u0311ˠ\u02f0\u0315ˤ\u0307\u02df\u02f8\u0301ˠ\u030f\u0315\u02e6\u02ed\u02df\u0303\u0301ˠˡ\u0305\u02e7\u0304\u02df\u0308ˎˡ\u02f0\u0315\u02e8\u0309\u02df\u030dˣˡ\u030b\u02df\u02eaˏ\u02df\u0309\u0305\u02dfˬ\u0315ˤ\u02d7\u02df\u02f7\u02dfˠ\u02d7\u02df\u02e6\u0301ˮ\u02ef\u200c،\u02df\u02efˢ\u02df\u02ef\u0305\u200c،\u02df\u0315\u02df\u02f7\u02f0\u0305\u200c،ˡ\u200c،ˣ\u0305\u200c،\u200c،\u02ef\u02dfˢ\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u02dfˮ\u200c،\u200c،\u02df\u0305\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u02df\u02ef\u02df\u02f8\u200c،\u200c،\u200c،\u02dfˡ\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u02dfˠ\u02dfˡ\u02e7\u200c،\u200c،\u200c،\u02df\u02e7\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u02df\u030d\u02df\u02e9\u02ef\u200c،\u200c،\u200c،ˡ\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u02dfˡ\u0305\u02df\u02d2\u200c،\u200c،\u200c،\u02df\u02e6\u200c،\u02f7\u02dfˡ\u200c،\u02e6\u200c،\u0309\u02dfˠ\u0305\u02df\u02e9\u200c،\u0309\u200c،\u200c،\u200c،ˠˣ\u02df\u0308\u02df\u02ef\u200c،\u200c،\u02dfˤ\u0315ˡ\u02ebˠ\u200c،\u200c،\u200c،\u0302\u02df\u02e7\u0315ˣ\u02df\u02ef\u200c،\u02dfˠˎ\u02df\u0309\u02df\u02ef\u200c،\u200c،\u02df\u02e8\u0315ˡ\u02ebˠ\u02dfˣ\u200c،\u200c،\u030c\u02df\u02e8\u02dfˣ\u200c،\u200c،\u02dfˡˎ\u02df\u0308\u02df\u02efˠ\u200c،\u200c،\u02ea\u02efˡ\u02efˠ\u200c،\u200c،\u200c،\u0314\u02df\u02e7\u0315ˣ\u200c،\u200c،\u02dfˢˣ\u02df\u0308\u02df\u02ef\u200c،\u200c،\u02df\u02eb\u0315ˡ\u02ebˠ\u200c،\u200c،\u200c،ˏ\u02df\u02e7\u0315ˣ\u02df\u02ef\u200c،\u02dfˢ\u02f3\u02df\u0309\u02df\u02ef\u0313\u02dfˣ\u0311\u02df\u02e8\u0305ˠˏ\u02dfˠ\u02f7\u02df\u0303\u0315\u02df\u02ea\u02df\u02e7\u0309\u02dfˣ\u02dfˡ\u0310\u02dfˢ\u200c،\u0311\u200c،\u0317\u02df\u02ea\u02f3\u02df\u02e6\u02dfˡ\u02d4\u02dfˢ\u02ef\u02df\u02d2\u200c،\u0311\u200c،\u0315ˠ\u02df\u02efˠˠ\u200c،\u02e7\u02df\u0305\u02ef\u02dfˢ\u02dfˢˎ\u02dfˠ\u02dfˠ\u02e8\u200c،\u02f3\u02df\u0305\u02ef\u02df\u02e5\u02dfˢˣ\u02dfˠ\u0315ˡˠ\u200c،\u0305\u02dfˤ\u02ef\u02df\u02e8\u02dfˠ\u0309\u02dfˡ\u0305ˠˤ\u200c،\u0311\u02dfˮ\u02ef\u02df\u02eb\u02df\u02e7ˣ\u02dfˢ\u02efˡˠ\u200c،ˠˡ\u0302\u02f5\u02d3\u030e\u02f8\u030c\u02f3\u0313\u02f4\u02f3\u0309\u0313\u02f8\u02e5\u0316\u0311\u02dfˣ\u02e8ˏ\u0300\u030b\u030a\u030b\u0302\u02f1\u02d3\u02f4\u02f1\u02efˠ\u0312\u0301ːˬ\u0314\u0301\u030b\u0316\u030e\u02f7\u0305ˠ\u02f2\u0303\u02f6ˬˎ\u02f8\u02f5ˎ\u02df\u02f3ˑ\u030a\u0318\u0302\u02e5\u02f4\u0312\u02ea\u0309\u02f0\u0317\u02f7\u02f6\u0302\u030e\u0300\u030b\u0301\u02df\u02f2\u02f5\u030a\u0308\u0301\u030b\u02d7\u0318\u0300ː\u02f8ˎ\u02ea\u030a\u02f8\u030e\u0301ˑ\u02f4\u0306\u0300ˣ\u02e8\u0306\u0301ː\u030a\u0308\u02dfˢ\u0316ˬ\u0300ː\u02f0ˏ\u0300\u02e5\u02f3ˉ\u02dfˣˬ\u030d\u02f7\u02f6\u02e7\u02df\u02f3\u030c\u02f4\u0313\u0302\u02e5\u030a\u0312\u02f8\u02f3\u0306\u030a\u0300\u02e6ˠ\u030a\u0301\u030c\u02eb\u02df\u02f3ˑ\u030a\u0318\u0302\u02e5\u02f4\u0312\u02ea\u030a\u02e8ˏ\u0300\u030c\u02f0\u030e\u0300\u02f5\u02f3\u0313\u02efː\u02d7\u0312\u0301\u02e5\u030a\u0311\u02f8\u02f6\u02e8\u02f2\u02f8\u02f6\u02e8ː\u02ff\u02f5ˬ\u030a\u0301\u0315ˠ\u02e8\u0300\u030b\u030aˎ\u02ff\u02f5ˤ\u0311\u02ff\u02f6\u030e\u030a\u02ef\u02f6\u02e8\u0317\u02f7\u02f6\u0309\u02df\u02ef\u02f6\u02e8\u0317\u02f7\u02f6\u0309\u02df\u02f3\u030c\u02f4\u0313\u0302\u02e5\u030a\u0312\u02f8\u02f3\u02f8\u030e\u02f8\u02f5\u0316\u0309\u02f1\u02e5ˤ\u0313\u02f8\u02e5\u0316\u030a\u02dfˡ\u02d3\u0308\u02f7ˑ\u02f0\u0314\u0301\u0305ˠˡ\u02f8\u02f6\u02f0\u0306\u02dfˣˤ\u0311\u0301\u02e5\u0306\u0306\u02dfˣ\u02d7\u0307\u02ff\u030b\u02f4\u0308\u0302\u02dfˢ\u0306\u0305\u030fˎ\u02df\u02d2\u02f7\u02e9\u0305\u02dfˤˬˎ\u0301\u030b\u02f4\u0306\u0300\u02efˠ\u02f2\u0303\u02f6ˬˎ\u02f8\u02f5ˎ\u0313\u02f1\u02f3\u02d6\u02df\u02f2\u02f5\u02f4\u0312\u0300ˑ\u02e8\u02d3\u02f3ˑ\u02f0\u0317\u02f8\u02f5ˤ\u0312\u02dfˡ\u02d3\u0308\u0302\u02e5\u02d7\u0317\u02dfˣ\u02e8\u02d3\u0302\u02e5\u02f3\u02df\u02f0ˏ\u030e\u030e\u0301ˤˬˎ\u0301\u030b\u02f4\u0306\u0300\u02efˠ\u02f2\u0303\u02f6ˬˎ\u02f8\u02f5ˎ\u0313\u02f1\u02f3\u02d6\u0313\u02efː\u02d7\u0312\u0301\u02e6\u02e8\u030a\u0301ˑˬ\u030e\u0300ː\u02d2\u02df\u02efː\u02d7\u0312\u0301\u02e6\u02e8\u030a\u0301ˑˬ\u030e\u0300ː\u02d3ˬ\u0300ː\u02f0\u030a\u02dfˣ\u030aˣ\u02ff\u02f6ˬ\u0315\u0300ˑˬ\u0306\u02f7\u030b\u0316\u030a\u02dfˣ\u02f0\u030e\u0301ˑˠ\u0314\u0301ː\u02f3\u02df\u02f0\u02e6\u02e8\u0306\u0302\u0315ˢ\u030a\u030e\u02e9\u0304\u030b\u0312\u0300\u0304\u0308\u0305\u030e\u02e7\u02df\u02f0\u02f5\u02d3\u0308\u0300ː\u02f0\u030e\u0300\u030b\u0301\u02df\u02f3ˑ\u030a\u0318\u0302\u02e5\u02f4\u0312\u02ea\u030a\u02f0\u030a\u0303\u02e6\u02ef\u02df\u02f3\u030b\u02f4\u0318\u02ff\u02f6\u030e\u030a\u02dfˤˠ\u030a\u0300\u0305ˢ\u0308\u0305\u030d\u0311\u02df\u02d4\u0300\u0303\u02d3\u02d2\u02d2\u02e5\u0314\u02dfˣ\u030aˤ\u0300\u030c\u02f4\u0312\u02f8\u02f6\u02e8\u0306\u02f7\u030b\u0316\u030a\u02dfˤˬ\u02d3\u0301ˑ\u02f0\u030a\u0300\u02f1\u02d3ˢ\u0300ː\u0316\u0311\u02f8\u02f5ˬˎ\u02ff\u02f5\u02d7\u0313\u0301\u0315ˠˢ\u0300ː\u0316\u0314\u0301\u0305ˠˠ\u0301\u030c\u02e8\u0306\u0303\u02f3\u0316\u030e\u0301ˑ\u02ef\u02df\u02f1\u02f5ˏ\u0306\u02f8ː\u02f3\u02df\u02ef\u030b\u030aˎ\u0300\u02f5ˤ\u0315\u02dfˣ\u030aˢ\u0300ː\u0316\u0311\u02f8\u02f5ˬˎ\u02ff\u02f5\u02d7\u0313\u02dfˤ\u02f0\u02d3\u0301\u02e5\u02f3\u02df\u02f0ː\u02f4ˎ\u02f4\u02e6\u030a\u0315\u02f8\u02f3\u02f8\u0317\u0300ːˏ\u02e7\u02f7\u02f5\u02d3\u0309\u0300\u02e5\u02f3\u02df\u02f3\u030c\u02f4\u0313\u0302\u02e5\u030a\u0312\u02f8\u02f4\u02f0\u02d3\u0301\u02e5\u02f4\u02e7\u02f7\u02f5\u02d3\u0309\u0300\u02e5\u02f3\u02df\u02f4\u02e5\u02d7ˠ\u0301\u030c\u02e8\u0306\u0303\u02efˢ\u0306\u0305\u030f\u02ef\u02df\u02f3\u030b\u02f4\u0318\u0300ˑ\u02f4\u0317\u02f7ː\u02f4ˬ\u02f7\u02f5\u02d3\u0306\u02f8ː\u02f4\u0317\u02dfˤˬ\u02d3\u0301ˑ\u02f0\u030a\u0300\u02f1\u02d3\u02f1\u02f8\u02f6ˬ\u0314\u0302\u02f6\u02e8\u0308\u02f8\u02f6\u02eb\u02df\u02ef\u02f6ˬ\u0318\u02f8\u02f5ˏ\u0307\u0300\u02e6\u0309\u02df\u02f3ˑ\u030a\u0318\u0302\u02e5\u02f4\u0312\u02ea\u030a\u02e8\u030a\u02f8\u030b\u0316\u030a\u02f7ˑ\u02f0\u030e\u0300ː\u02d2\u02df\u02f0ː\u02f4ˎ\u02f2ː\u02e8\u030f\u02f8\u02f5ˬˎ\u02dfˣ\u02d5ˢ\u0312\u02dfˠ\u0317\u02f8\u02f6ˬ\u0304\u0300\u030bˤ\u0312\u02f8\u02efˠ\u0315\u0301\u030b\u02d7\u030f\u02f6ː\u02d3\u0306\u0300\u02f5\u02f3\u02df\u02f1\u02f3ˬˏ\u0301ˑ\u02f0\u0314\u0300\u02f3ˤˎ\u0302\u02e6\u02e8\u030e\u02f7\u030c\u02f4ˎ\u02f8\u02f4ˠ\u0317\u0300ˑ\u02f8\u030e\u02f8\u02e5\u02f4\u0317\u02dfˣ\u030a\u0313\u0302ˢ\u02eb\u0317\u02dfˣ\u030a\u0313\u0302\u02e5\u02f4\u0317\u02f7\u02f5ˬˎ\u02ff\u02f5\u02d7\u0313\u02dfˣˬ\u0306\u0300\u02e5\u0316ˡ\u0303\u02f3\u02d3\u0306\u0300\u02f5\u02f3\u02df\u02efːˤ\u0311\u0300ˤ\u02f0\u02d3\u0301\u02e5\u02f3\u02df\u02f0\u02f5\u02d3ː\u02ff\u02f6\u02e8\u0314\u0300\u030bˏ\u030a\u0300\u030c\u02ef\u02df\u02f0\u02f6\u0306\u030e\u0302\u02dfˠˡ\u0302\u02f5\u02d3\u030e\u02f8\u030c\u02f4\u0304\u02f4\u02e5\u02f4\u02d2\u0302ˣ\u02e8\u0314\u0303\u02dfˠ\u0317\u02f8\u02f6ˬ\u0314\u0302\u02f6\u02e8\u0308\u02f8\u02f4\u02d7\u0313\u02f7\u02f5ˏ\u030a\u02df\u02ed\u030bˑ\u0313\u0303\u02edˠ\u0310ˏ\u02d7\u0315\u02f7\u02f6\u02e8\u0306\u0300\u02efˠ\u0315\u0301\u030b\u02d7\u030f\u02f8\u02f5ˬˎ\u02f6ː\u02d3\u0306\u0300\u02f5\u02f3\u02df\u02d2\u02f7\u02e9\u0318\u02d2\u02f7\u02e9\u0312\u02dfˤ\u02f8\u0306\u0300\u02e6\u02f4\u030a\u02f4\u02e6\u030a\u0315\u02f8\u02efˢ\u0306\u0305\u0310ˮ\u0306\u0305\u0310\u02eb\u02df\u02d2\u02f7\u02e9\u030d\u02df\u02ed\u02e5ˡ\u0311ˉ\u02e5ˡ\u030d\u02dfˢ\u0306\u0305\u0310\u200c،\u02f8ː\u02f4ˎ\u02f6ˏ\u0302\u030e\u02f8\u02e6\u02f0\u030d\u02df\u02e5\u0302\u030a\u0302ˤ\u02d7\u02e7\u02f8\u02f5\u030a\u030c\u02ff\u02e6\u02ef\u02df\u02f4\u02e5\u0306\u0317\u02f8\u02f5ˤ\u0309\u02dfˤˬ\u02d3\u0301ˑ\u02f0\u030a\u0300\u02f1\u02d3\u02f3\u02ff\u02e6\u02e8\u030a\u02f7\u02f5\u02f0\u030e\u0300\u030b\u0301\u02df\u02f3ː\u0316\u030a\u02f8\u02f6\u200c،\u02d2\u02f7\u02e9\u0308\u02df\u02ed\u02e5ˡ\u0314\u02dfˢ\u0306\u0305\u0310\u02eb\u02df\u02d2\u02f7\u02e9\u030a\u02dfˣ\u030aˢ\u0300ːˏ\u0315\u02f7\u02f6\u02e8\u0306\u02f7\u030b\u0316\u030a\u02f7ˢˣ\u02df\u02f1\u02f4ˬ\u030a\u0301\u030b\u030a\u0306\u0300\u02e5\u030a\u02d4\u02f7\u02f5\u02e8\u0311\u02f8\u02efˠ\u02f2\u0303\u02f6ˬˎ\u02f8\u02f5ˎ\u0313\u02f3\u030c\u02f4\u0313\u0302\u02e5\u030a\u0312\u02f8\u02f1\u02d3\u02f2\u02f8\u02f6\u02e8\u030e\u02f7\u02f5\u0316\u030e\u0303\u030bˤˎ\u02ff\u02f5\u02d7\u0313\u02dfˤˬˎ\u0301\u030b\u030a\u0313\u02f8\u0315ˠ\u02f2\u0302\u02e6\u02e8\u030e\u0300\u030b\u0302ˡ\u0302\u02f5\u030a\u0311\u02f8\u02e5\u02f4\u0317\u02dfˣˤ\u0315\u0301\u02e5\u02f4\u0313\u02f8\u02dfˠ\u02f3\u0300ˏˬˎ\u0301\u030b\u030a\u0313\u02f8\u0315ˠ\u030c\u02f8\u02f6\u02f0\u0304\u02f2\u02e5\u02f4\u0313\u02f8ˑ\u02f0\u030d\u02dfˣ\u02f8\u0317\u0300ːˏˠ\u0301\u030b\u0302\u0307\u02df\u02e5\u0302\u030a\u0302ˤ\u02d7\u02f1\u02df\u02e5\u0302\u030a\u0302ˤ\u02d7\u02e6\u02df\u02e5\u0302\u030a\u0302ˤ\u02d7ˡ\u02dfˣ\u030a\u0313\u0301ː\u02f4\u0317\u0302ˤ\u02e8\u0306\u0300\u030b\u0302\u030a\u02df\u02ed\u02e5ˡ\u0311ˉ\u02e5ˡ\u030e\u02dfˠ\u02e6\u02f8\u02f6\u02f0ˤ\u0300\u030c\u02f0\u0317\u0303\u02f3ˤ\u0318\u0301ː\u02f4\u0312\u02f7\u030b\u0316\u02d3\u02dfˤ\u02d7ˠ\u0301ˑˬ\u030a\u0300\u02f5\u02e8\u0311\u0303\u02efˠ\u02f2\u0303\u02f6ˬˎ\u02f8\u02f5ˎ\u0313\u02f3\u030c\u02f4\u0313\u0302\u02e5\u030a\u0312\u02f8\u02f1\u02d3\u02e8\u0300\u030c\u02f0\u030a\u0301\u030b\u02d7\u0315\u02f3ː\u02f4\u0317\u0302\u030b\u030a\u0308\u02f8\u02f6\u02eb\u02df\u02f2\u02e5\u02d7\u0306\u02f8\u02dfˢ\u0306\u0305\u0310ˮ\u0306\u0305\u030f\u02eb\u02df\u02d2\u02f7\u02e9ˑ\u02df\u02ed\u02e5ˡ\u0310\u0303\u02e5ˡ\u030e\u02efˠˡ\u02ff\u02f6\u02f0ˢ\u0300ː\u02d3ː\u02f8\u02f6\u02e8ˎ\u02f8\u02f6\u02e7\u02df\u02f4\u02e5\u02d7\u02e8\u0300\u030c\u02ef\u0318\u02eb\u0305ˠ\u02e6\u02f8\u02f6\u02f0ˡ\u0303\u02f6\u02f0\u030a\u0301\u0315ˢ\u0306\u0305\u030fˑ\u0306\u0305\u030fˎ\u02df\u02f8ː\u02f4ˎ\u02f6ˎˤ\u02f2\u02efˎ\u030a\u02e8\u02df\u02e5\u02d7\u0315\u02f6ˎ\u030a\u0313\u02f8\u02f6ˤˏ\u02f7\u02f5\u0316\u030e\u0302\u02e6\u0309\u02df\u02f3\u030b\u02f4\u0306\u02f8\u02dfˠ\u02e6\u02f8\u02f6\u02f0\u02ef\u02ff\u02f6\u0306\u030a\u0300\u02dfˠ\u030c\u02f8\u02f6\u02f0\u0304\u02efː\u02d7ˏ\u0300\u030c\u02ef\u02df\u02efː\u02d7\u0313\u02f7ːˤˎ\u02dfˡˣ\u0306\u02eb\u200c،\u0306\u02e7\u02f2ˣ\u02df\u02efː\u02d7\u0312\u0301\u02e5\u030a\u0311\u02f7\u02f6\u02f0\u030e\u0300ː\u02d3\u02f1\u02f8\u02f5\u0316\u0306\u0303\u02e5ˤˎ\u02ff\u02f5\u02d7\u0313\u0301ˎˤˎ\u0302\u02e6\u02e8\u030e\u02f7\u030c\u02f4ˎ\u02f8\u02efˠ\u02f1\u0302\u02f5\u02d3ˎ\u02ff\u02f5ˏ\u030a\u02efː\u02d7\u0312\u0301\u02e5ˤˎ\u02ff\u02f5\u02e8\u030e\u0300\u02e5\u030aˎ\u0303\u02f3ˤˎ\u0302\u02e6\u02e8\u030e\u02f7\u030c\u02f4ˎ\u02f8\u02efˠˠ\u0301ˑˬ\u030a\u0300\u02f5\u02e8\u0311\u0303\u02f4\u02f0\u030e\u0302\u02e5\u0316\u030a\u02ef\u02f6\u02f0ˎ\u0301\u030b\u030a\u0307\u0302\u02f6\u02f0\u030a\u02dfˣˤ\u0318\u0301ː\u02f4\u0312\u02f7\u030b\u0316\u02d3\u02f0\u02e5\u02f4\u0318\u02f7ˑ\u02e8\u030e\u0301\u02e6\u02f0\u030e\u0300ː\u02d3ˠ\u0302\u02e6\u02f0\u0317\u02ff\u02f5\u02e8ˏ\u0302\u02e5\u02f3\u02df\u02ef\u02f6ˬ\u0318\u02f8\u02f5ˏ\u0307\u0300\u02e6\u030aˢ\u0300ː\u02d3\u030b\u02ff\u02f5\u0302ˏ\u0301\u030bˤˎ\u02ff\u02f5\u02d7\u0313\u02ef\u02f6\u02f0ˎ\u0301\u030b\u030a\u0307\u0302\u02f6\u02f0\u030a\u02dfˣˤ\u0318\u0301ː\u02f4\u0312\u02f7\u030b\u0316\u02d3\u02efː\u02d7\u0312\u0301\u02e5ˤ\u0313\u0303\u02f3ˤˎ\u0302\u02e6\u02e8\u030e\u02f7\u030c\u02f4ˎ\u02f8\u02efˠˠ\u0301ˑˬ\u030a\u0300\u02f5\u02e8\u0311\u0303\u02f4ˠ\u0317\u0300ː\u02f0ˏ\u02f7ˑ\u02f0ˠ\u0302\u02e6\u02f0\u0317\u02ff\u02f5\u02e8ˏ\u0302\u02e5\u02f3\u02df\u02ef\u02f6ˬ\u0318\u02f8\u02f5ˏ\u0307\u0300\u02e6\u030aˢ\u0300ˑˠ\u02d3\u0301\u030b\u030a\u030c\u02ff\u02e6\u02f0ˠ\u0302\u02e6\u02f0\u0317\u02ff\u02f5\u02e8ˏ\u0302\u02e5\u02f3\u02df\u02ef\u02f6ˬ\u0318\u02f8\u02f5ˏ\u0307\u0300\u02e6\u030a\u02f3\u0301\u030bˤ\u0309\u02f8\u02f5ˏ\u0306\u0301\u030b\u0312ˠ\u0302\u02e6\u02f0\u0317\u02ff\u02f5\u02e8ˏ\u0302\u02e5\u02f3\u02df\u02efː\u02d7\u0312\u02f4\u030b\u030a\u0318\u02ff\u02f5\u02e8\u0311\u02f8\u02f3ˤˎ\u0302\u02e6\u02e8\u030e\u02f7\u030c\u02f4ˎ\u02f8\u02efˠ\u02e6\u0302\u02f5\u030a\u0309\u02ef\u02f6\u02f0ˎ\u0301\u030b\u030a\u0307\u0302\u02f6\u02f0\u030a\u02dfˣˤ\u0318\u0301ː\u02f4\u0312\u02f7\u030b\u0316\u02d3\u02f0\u030b\u030a\u0311\u02f8\u02f4\u02f8\u030a\u0301\u030cˬ\u030e\u0300ː\u02d3ˠ\u0302\u02e6\u02f0\u0317\u02ff\u02f5\u02e8ˏ\u0302\u02e5\u02f3\u02df\u02f3ˑ\u02f4\u0315\u0301\u02e6\u02e8\u030a\u0301ˑˬ\u02e8\u0300\u02e5\u02f0\u0306\u0301ːˏˠ\u0302\u02e6\u02f0\u0317\u02ff\u02f5\u02e8ˏ\u0302\u02e5\u02f3\u02dfˡ\u030d\u02df\u0303\u0307\u0316\u030f\u0318\u0300ˣ\u0303\u0318\u0311ˮ\u02d2\u0313\u02e7ˣ\u0316\u030f\u0303\u200c،\u02e7\u0312ˑ\u030e\u0301\u02f4\u0306\u0309ˎ\u02d2\u02e7\u0309\u02e7\u0311ˢ\u02d7\u0304\u0304\u0316\u02e6\u02f4ˡ\u0308\u030d\u02e6\u200c،\u02e7ˠˣ\u0305ˎ\u02f0ˣ\u02ef\u02eb\u200c،\u02dfˣˢˠ\u0306ˣ\u02eb\u02df\u0315\u02f7\u0302\u02df\u0316\u030d\u02e6ˤˠ\u02e7\u02f8ˣ\u0305ˎ\u02e7\u02e6ˠ\u0315\u0301ˡ\u02df\u0305\u02e7ˡ\u02df\u0305\u02e7ˡ\u02df\u0305\u0302\u02df\u0315\u0305\u02e7\u02e6\u02ef\u02eb\u02e7ˡ\u02df\u02f3\u0305\u02df\u02efˣ\u0302ˠ\u02ef\u02e7\u0302ˠ\u02ef\u02ef\u02e9\u02df\u02f0\u02e7\u02f8ˠ\u0317\u02dfˡ\u02df\u02f0\u02e7\u02f8ˣ\u02f1\u0309ˢ\u02e7\u200c،ˠˠ\u0305\u02dfˠ\u02e6\u02ef\u02f3\u0302ˠ\u02f0ˣ\u02e6ˢˠ\u0315\u02e7\u02e6\u02ef\u02f3\u02e7ˡ\u02df\u02e7ˡ\u02e6\u02df\u0305\u02e7\u02e6\u02ef\u02eb\u0302\u02df\u0315\u02f3\u02e9\u02df\u0305\u02d2\u02f1\u02eb\u02ef\u02eb\u02e9\u02df\u02ef\u02d2\u02e8ˣ\u02dfˣˡ\u02df\u02f0\u02df\u0302\u02e6\u0305\u02df\u02e7\u02df\u0315\u030dˠˠ\u02ef\u0301\u200c،\u0306ˎˤ\u02e6\u02ef\u02f3\u02edˤ\u02ef\u0301\u02edˣ\u0308\u02f3\u02e7ˡ\u02df\u0305\u02e7ˣ\u02f2\u0309ˡ\u02df\u0305\u02e7\u02f1ˢ\u02ef\u0305\u02e7\u02e6\u02ef\u02eb\u0302\u02df\u0315\u02ef\u02e9\u02df\u02f0\u02e8ˠˠ\u02df\u030dˠˣ\u0309\u02f3ˣˡ\u0305ˣ\u02f1ˮ\u02ef\u02f7\u02e9\u02df\u0306\u02e7\u02d7ˣ\u0309\u0309\u02e5\u200c،ˣ\u02f1\u02f2\u02f0ˤ\u02f0ˠ\u0307\u02dfˠˣ\u0305ˎ\u02f1\u02f2\u02ef\u02f7\u200c،\u02f0ˎˤˣ\u0309\u02f3\u02e8ˠ\u0315\u02f3\u0301ˣ\u0309ˣ\u02e7ˡˠˎˢˠ\u02df\u030dˡˢ\u0305\u02d2\u02e5\u02e7\u02df\u02e7ˠˢ\u0306\u02e8\u02f8ˠˡ\u02dfˠ\u02e6\u02df\u02d2\u02e5\u200c،\u02e7\u02f1\u02f0\u02ef\u02d2\u02edˣ\u0315\u0301\u02eaˣ\u0309ˣ\u0301ˣ\u0305ˎ\u02f1ˢ\u02f0\u02e8\u0302\u02e6ˠ\u0315\u02e7ˡˠˎˢ\u02e6\u02ef\u02ebˣˡ\u0305\u02e7\u02ed\u02e6\u02df\u0309\u02dfˠˠ\u0315\u0301ˢ\u0306ˤ\u030e\u02e6\u02f0\u0315ˣ\u200c،ˣˠˡ\u02df\u02f7\u200c،\u0315ˣ\u02edˢ\u0305\u02d2ˢˠ\u0306ˣ\u02f3ˡ\u0315\u0301\u02e6ˡ\u02df\u0305\u02e7ˡ\u02df\u0305\u0302\u02df\u0316ˎˢ\u02df\u0306\u02d2\u200c،\u0317\u200c،ˡ\u02df\u0305\u02ef\u02df\u02ef\u02eb\u02e7\u02e6\u0305\u02dfˢ\u02df\u0315\u0311\u02e6ˡ\u02df\u0305\u02e7ˡ\u02df\u0305\u02e7\u02e6\u02ef\u02eb\u02e7ˡ\u02df\u02f7\u200c،\u0315ˣ\u02e7ˡ\u02df\u02ebˢˠ\u0306\u02e7ˬ\u02df\u0315\u02f7\u02f0\u02e7ˠ\u030d\u02e6ˣ\u02ef\u0305\u02e7\u02e6ˠ\u02f3\u02f1\u0303\u02efˣ\u02edˣ\u030cˎˢˡ\u02df\u0305\u02e7ˡˠ\u0315\u0301ˡ\u02df\u0305\u02e7\u02e6\u02ef\u02eb\u0302\u02df\u0315\u02e7\u0302\u02df\u0315\u02e7\u0302ˢ\u0305\u02f7\u0305\u02df\u02f0\u02e9\u02df\u0306\u02ef\u02ebˢ\u02e7\u200c،\u02edˡ\u200c،ˣˢ\u0306\u02e8ˬˡ\u02df\u02f3\u02e7ˡ\u0305\u0301\u02e6ˡ\u02df\u0305\u02e7ˡ\u02df\u0305\u02e7\u02e6\u02ef\u02eb\u02e7ˣ\u02dfˣˢˡˠ\u02d2\u02dfˡ\u02df\u0305\u02edˠ\u0315\u0305\u02e7ˣ\u02f2\u0309\u02f0\u02ed\u02ef\u0305\u02e7ˡˠˎˢ\u02e6\u02ef\u02eb\u02e7\u200c،\u02ef\u02f0\u02ed\u02ef\u0305\u02e7ˡ\u02df\u0305\u02e9\u200c،\u02f7\u02f0\u02ed\u02ef\u0305\u02e7ˡ\u02df\u0305\u02e5\u02df\u0315\u0311\u02e6ˠ\u0315\u0305ˤˡ\u02df\u0305\u02e7\u02e6\u02ef\u02eb\u0302\u02df\u0315\u02eb\u0305\u200c،\u02f3\u02e7\u200c،\u02ebˤˣˠˣ\u02d3\u02df\u0315\u02eb\u02ebˠ\u0315\u0305\u02e7ˡ\u02df\u0305\u02e7\u02e6\u02ef\u02eb\u0302\u02df\u0315\u0305\u02e7\u02df\u0306\u02d2ˠˠ\u0307\u02dfˡ\u02df\u02ef\u0305\u02f1\u02f1\u02ef\u0311\u02ef\u02df\u0305\u02f3ˠ\u02e6\u0305\u02df\u02e7\u02e6\u0305ˣ\u02e7ˡ\u02df\u0305\u02e6ˠ\u02ef\u0305\u0301ˡ\u02df\u0305\u0302\u02df\u0315\u02ef\u200c،ˠ\u02e8\u02f8ˠ\u0305\u02dfˡˣ\u030a\u0309ˢˡ\u02dfˎ\u02e6ˠ\u0315\u0305\u02f1\u0305\u02e7\u0309\u02e7ˡ\u02df\u0305\u0302\u02df\u0316ˎˢˠ\u0305\u02dfˠˣ\u030a\u0309\u0302ˠ\u02ef\u0305\u200c،\u0316\u02e8\u02f8\u02e6\u02ef\u02f3ˢ\u02df\u0315\u0309\u02e6ˠ\u02f0\u0315\u02e7ˡˠˎˢ\u02e6\u02ef\u02eb\u02ebˠ\u0315\u0305\u02e7ˡ\u02df\u0305\u02e7ˡ\u02df\u0305\u0302\u02df\u0316ˎˢˠ\u0305\u02dfˡˡˠˎˤˡ\u02df\u0305\u02dfˠ\u02df\u0305\u0302ˠ\u02ef\u0305\u02e5\u02df\u0315\u030d\u02e6ˠ\u0315\u0305\u0301ˡ\u02df\u0305\u02e7ˡˠˎˢˠ\u02f1\u02dfˠ\u02e6\u02ef\u02f3\u02edˡ\u0316\u02dfˡˠˠˎˤ\u02e6\u0305ˣ\u0303\u200c،\u02eb\u02e5ˡ\u0305\u0301\u02e5ˡˠ\u0315\u02e7ˡˠˎˢ\u02e6\u02ef\u02ebˣ\u200c،\u02df\u02f1\u02eb\u02ef\u02f7\u200c،\u0306\u02e7\u0316\u02df\u0315\u0305\u02e9ˠ\u0315\u0301\u02e7\u02df\u0305\u0305\u02e7ˡ\u02df\u0305\u0302\u02df\u0315\u0301\u200c،\u0305\u02e7\u02f0\u02ed\u02f0ˣ\u02d3ˡ\u02ef\u02dfˣ\u02df\u0306ˣ\u02d3ˣ\u02f2\u0309\u02e5ˠ\u0305\u02d2\u02ef\u02df\u0305\u02f7\u0301\u02e6\u0305ˣ\u0303\u02dfˠˤ\u030e\u02e6\u02f0\u0315\u02e7\u02df\u0315\u0301\u0305\u02df\u0315\u0305\u0302ˠ\u02ef\u0305\u02e7ˢˠ\u02dfˠˠ\u0305\u0305\u0303\u02dfˠˎˤˡ\u02df\u0305\u02e7ˠ\u0305\u02f7\u0305\u02df\u0306ˣ\u02d3ˡ\u02df\u0305\u02eaˣ\u02dfˣˤˣ\u02f2\u0309\u0303\u200c،\u0305\u02e7\u02df\u0315\u0305\u02e7ˣ\u02dfˣˢˡˠ\u02d2\u02dfˠ\u0305\u02f7\u02ebˠ\u0315\u0305\u02e7\u02e6\u02df\u0305\u02e7ˡ\u02df\u0305\u0302\u02df\u0316ˎˢˠ\u02ef\u02dfˡˢ\u0305\u02d2\u02edˡ\u0306\u02dfˡˠ\u02df\u02d2\u0303\u02df\u02f0\u02d2\u200c،\u0315\u02ebˣ\u02e7\u02dfˣˠˡ\u02df\u0305ˠ\u200c،\u0305\u200c،\u200c،\u200c،ˠ\u02d2ˠ\u200c،ˣ\u02df\u02f4\u02df\u02e7\u02f5\u02f4ˑ\u02e8\u0306\u0301ˣ\u02d3\u0314\u0300\u0309\u02f4\u02d2\u02f7ː\u02f4\u0315\u0302\u02e5\u030a\u0314\u0300\u030a\u02f0\u030d\u0301\u030b\u02d7ˑ\u0301\u0315ˣˣ\u02e7\u02dfˣˠˢ\u0306\u02d2ˠ\u02dfˠ\u030aˡ\u0302\u02f5\u02d3\u030e\u02f8\u030c\u02f3\u0305\u02f0\u030c\u02e8\u0306\u0300\u02f5\u02f4ˑ\u0300ˑ\u02e8\u0310\u02e7ˡˎ\u0305\u02f4\u02f3\u0309\u0305\u02f2\u02e5\u030a\u0307\u200c،\u02df\u0305\u02df\u02ef\u02df\u0300\u02efˑ\u02f4\u0318\u0302\u02e5\u02d7\u0312\u02e7ˣ\u02e8ˏ\u0300\u030b\u030a\u030b\u0302\u02f1\u02df\u0313\u02f2\u0309\u02f4\u02f3\u02e7\u02e5ˬ\u0314\u0300\u030c\u02f0\u0317\u0300ː\u0316\u0318\u200c،\u02dfˤ\u02df\u02ef\u200c،\u200c،\u02df\u02f7\u02df\u02ef\u02df\u02f2\u02ef\u030c\u02f4\u0313\u02ff\u02f5\u02f8ˏ\u02e7ˤ\u02f0\u030a\u02f7ː\u0306\u0313\u0300ː\u0316\u0314\u02f8ː\u030a\u030a\u0301\u0315\u200c،ˢ\u0305ˣ\u02dfˡ\u02f3\u02e8ˏ\u0300\u030b\u030a\u030b\u0302\u02f1ˠ\u02f4\u02f1\u02ef\u200c،ˤ\u0315ˣ\u02dfˣ\u0309ˬ\u0314\u0301\u02e6\u030a\u0317\u02ff\u02f5\u0302\u030d\u0302ˡˢˡ\u030f\u02f1\u02df\u0305\u02eb\u0308\u02df\u0316ˬ\u0305\u200c،ˠˡ\u02dfˠ\u02df\u02ef\u02e7\u030e\u02df\u02ef\u02df\u0309\u02ed\u02f5\u02f8\u0307\u02edˢ\u02e7\u0315ˬ\u030b\u02f3\u0312ˬˢ\u02df\u0315\u02f8\u0307ˎˎ\u02eb\u0318\u02f7\u0315\u02ea\u02f2\u0309ˏˬ\u0318\u0309\u0312\u02ebˢ\u0309ː\u02eb\u02f2ˤ\u0306ˬː\u02e8\u030b\u02f7\u02f2\u02f7ˏ\u200c،\u02df\u02eb\u02df\u02ef\u02df\u02e6\u02eb\u02f1\u02d2\u0318\u02ea\u0308\u02df\u0313\u02eb\u200c،\u02dfˠ\u02dfˣ\u200c،\u02dfˢ\u0309\u02f4\u0315\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،ˢˉ\u02f4\u0315\u200c،\u02dfˡ\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u02d6ˤ\u0301\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u02dfˠ\u0304\u02efː\u02d7\u0317\u02f0\u02e5\u0316\u0311\u02f2\u02f5ˤ\u030e\u0300\u0305ˠ\u0312\u0301ːˬ\u0314\u0301\u030b\u02f4\u030a\u02ea\u030b\u02f0\u0311\u0300\u200c،\u200c،\u200c،\u02dfˍ\u0317\u02f3\u02df\u02e7ˣ\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u02dfˠ\u02dfˠ\u200c،\u200c،\u02df\u02f7\u200c،ˡ\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،ˠ\u200c،ˣ\u200c،\u200c،\u0315\u200c،ˡ\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،ˠ\u200c،\u200c،\u200c،ˠ\u02e7\u200c،\u200c،\u02f5\u02e5\u200c،\u02df\u02e8\u02efˢ\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u02df\u02e8\u02efˢˬ\u200c،\u200c،ˤ\u02f7\u02df\u02f3\u0315ˠ\u0304\u02dfˤ\u02f7\u02df\u02f0\u02efˠ\u02f1\u02dfˤ\u02eb\u02df\u02f1\u02efˠˮ\u02dfˣ\u02d2\u02df\u02f6\u0315ˠ\u02e8\u02dfˣ\u02d2\u02df\u02f0\u0305ˠˮ\u200c،\u200c،\u200c،ˡ\u02d7ˠ\u02edˍˉ\u200c،\u02dfˠ\u200c،\u02eb\u200c،\u02ef\u200c،\u200c،\u200c،\u02df\u0315\u02dfˠ\u200c،\u200c،\u200c،\u02dfˍ\u200c،\u200c،\u200c،\u200c،\u200c،\u02ef\u200c،\u200c،ˡ\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u02f0\u200c،\u200c،\u02dfˣ\u02df\u02f4\u0305ˠ\u0306\u02df\u02e6\u02e7\u02df\u02f0\u0305ˠ\u030e\u02df\u02e5\u0315\u02df\u02f8\u02efˠ\u02e8\u02df\u02e5\u02d2\u02df\u02f8\u0305ˠ\u0314\u200c،\u200c،\u200c،\u02df\u0309\u200c،\u02ef\u200c،\u02dfˠ\u02f3\u02df\u02e6\u02e7\u02df\u02f7\u02efˠ\u0313\u02df\u02e6\u02eb\u02df\u0300\u02dfˠ\u0306\u02df\u02e6\u02ef\u02df\u02ff\u02efˠ\u0314\u02df\u02e5\u02d2\u200c،\u200c،\u200c،\u200c،\u02df\u0311\u02df\u02f2ˎ\u02df\u0305\u200c،\u02df\u02efˠ\u02f2\u02df\u02e6\u02ef\u02df\u0301\u0305ˠ\u030e\u02df\u02e5\u02d2\u02df\u02f8\u0315ˠ\u02e5\u02df\u02e5\u0309\u02df\u0300\u02dfˠ\u030a\u02dfˣ\u0309\u02df\u0300\u0305ˠ\u030b\u02df\u02e5\u02d6\u200c،\u02dfˢ\u02ef\u02df\u0305\u200c،\u02df\u02ef\u02df\u0315\u02dfˢ\u200c،\u02eb\u200c،\u0315\u02dfˢ\u200c،ˬ\u02dfˠ\u0307\u02dfˢ\u200c،\u200c،ˠ\u02ef\u02dfˠ\u0315\u200c،\u02efˠˢ\u02df\u02e5\u02d6\u02df\u0300\u02efˠ\u0312\u02df\u02e5\u02f3\u02df\u0300\u0305ˠˎ\u02df\u02e6\u02eb\u200c،\u02dfˠˢ\u02df\u02e6\u02f3\u02df\u0301\u0315ˠˎ\u02df\u02e5\u02d6\u02df\u0300\u02ef\u02df\u0305\u02dfˣ\u02e7\u02df\u0302\u02efˠ\u0313\u02df\u02e5\u0309\u02df\u02f8\u0305ˠˏ\u02dfˡ\u200c،\u02ea\u0305ˠ\u02ed\u02dfˣ\u02f3\u02df\u02f4\u200c،\u0305\u02df\u02e5\u02eb\u02df\u0300\u0315ˠ\u0313\u02df\u02e6\u02ef\u02df\u0301\u0305ˠ\u0314\u02df\u02e5\u0315\u02df\u0301\u0315\u200c،\u02dfˣ\u0305\u02dfˤ\u200c،ˠ\u02dfˣ\u02eb\u02df\u0300\u0315ˠ\u0312\u02df\u02e6\u200c،\u02f7\u02efˠ\u0313\u02df\u02e6\u0309\u02df\u02f2\u0305ˠ\u0306\u02df\u02e5ˎ\u02df\u02f8\u02ef\u200c،\u200c،\u200c،\u02ef\u0305ˠˏ\u02df\u02e5\u02d2\u02df\u02ff\u02efˠ\u030b\u02df\u02e6\u02f3\u02df\u02e7\u02dfˠ\u02f3\u02df\u02e5\u02f3\u02df\u02f7\u0315ˠ\u030d\u02df\u02e5\u02d2\u02df\u0300\u0315ˠ\u0311\u02df\u02e5\u02d6\u02df\u02f8\u0315ˠ\u030e\u02df\u02e5\u02f3\u02df\u0301\u0315\u200c،\u02dfˤ\u0315\u02df\u02e5\u0305\u02dfˠ\u02dfˣ\u02f7\u02df\u02ff\u02efˠ\u0311\u02df\u02e5\u02f3\u02df\u02f0\u02dfˠ\u030a\u02df\u02e6\u02eb\u02df\u02f7\u0315ˠ\u0317\u02df\u02e5\u0309\u02df\u0301\u02dfˠˎ\u02df\u02e5\u0309\u02df\u0300\u0315ˠ\u0313\u200c،\u200c،\u200c،ˠˡ\u02df\u02e6\u02f3\u02df\u0300\u0305ˠ\u030e\u02df\u02e5\u02f7\u02df\u0302\u02ef\u02df\u0305\u02dfˣ\u02f7\u02df\u0301\u0305ˠ\u0306\u02df\u02e5ˎ\u02df\u02f8\u02efˠˑ\u02df\u02e5\u02d6\u02df\u0301\u0305ˠ\u0310\u02dfˡ\u200c،\u02ea\u02ef\u02df\u0305\u02dfˤ\u02f3\u02df\u02f1\u02ef\u02df\u0305\u02dfˣ\u0315\u02df\u02ff\u02efˠ\u0307\u200c،\u200c،\u02eb\u200c،\u02e7\u200c،ˣ\u02df\u02f0\u0305ˠ\u030e\u02df\u02e5\u0315\u02df\u02f8\u02efˠ\u02f5\u02df\u02e5\u02f3\u02df\u0301\u0305ˠ\u0318\u02df\u02e5\u0309\u02df\u0300\u0315ˠ\u0313\u200c،\u200c،\u200c،\u02df\u0316\u02dfˡ\u02d2\u02df\u02eb\u0315\u02df\u0313\u02dfˢ\u200c،\u02ea\u0305\u02df\u0315\u200c،\u200c،ˮ\u200c،\u02ed\u200c،ˣ\u02df\u02f1\u02efˠ\u0313\u02df\u02e6\u02ef\u02df\u02f8\u02efˠ\u0317\u02df\u02e5\u02d2\u02df\u02f7\u02efˠ\u0311\u02dfˣ\u02d2\u02df\u02f7\u02efˠ\u0312\u02df\u02e5\u02f3\u200c،\u02dfˠˡ\u02df\u02e6\u02f3\u02df\u0300\u0305ˠ\u030e\u02df\u02e5\u02f7\u02df\u0302\u02ef\u02df\u0313\u02dfˤ\u02f3\u02df\u02f1\u02ef\u02df\u0313\u02df\u02e5\u02ef\u02df\u0300\u02dfˠ\u0311\u200c،\u200c،\u02f1\u200c،\u02f1\u200c،ˣ\u02df\u02f2\u02dfˠ\u030a\u02df\u02e5\u0301\u02df\u02f7\u02efˠ\u0311\u02dfˣ\u02eb\u02df\u0300\u0315ˠ\u0315\u02df\u02e6\u0309\u02df\u0301\u0305ˠ\u030e\u02df\u02e5\u0301\u02df\u02ff\u02dfˠˎ\u200c،\u200c،\u02ef\u0315ˠ\u0314\u02df\u02e6\u200c،\u0303\u02efˠ\u0317\u02df\u02e5\u0309\u02df\u02f8\u0315ˠ\u030d\u02df\u02e6\u02ef\u02df\u02e7\u02dfˡ\u030e\u02dfˡ\u200c،\u02e7\u200c،\u0317\u02dfˢ\u200c،\u02eb\u02ef\u02dfː\u200c،\u200c،\u02e9\u0305\u02dfˠ\u200c،ˣ\u02df\u02f2\u02dfˠ\u030a\u02df\u02e5\u0301\u02df\u02f7\u02efˠ\u0311\u02dfˤ\u02ef\u02df\u0301\u0305ˠ\u0306\u02df\u02e5\u02ef\u02df\u02f8\u02efˠ\u0312\u02df\u02e5ˣ\u02df\u0301\u0305ˠ\u0310\u02df\u02e6\u02eb\u200c،\u200c،\u200c،\u200c،\u200c،\u02dfˠˣ\u200c،\u02d2\u200c،\u02efˠˮ\u02df\u02e6\u02e7\u02df\u02ff\u02efˠ\u030c\u02df\u02e5\u0309\u02df\u0300\u0305ˠ\u0306\u02df\u02e5\u0315\u02df\u02f0\u0305ˠ\u030e\u02df\u02e5\u0315\u02df\u02f8\u02efˠ\u0313\u02df\u02e5ˣ\u02df\u0300\u02efˠ\u030a\u200c،\u200c،\u02ef\u0305ˠˏ\u02df\u02e5\u02d2\u02df\u02ff\u02efˠ\u030b\u02df\u02e6\u02f3\u02df\u02ea\u0305ˠ\u02f4\u02dfˣ\u0309\u02df\u02ea\u0305ˠ\u0309\u02df\u02e5\u0315\u02df\u0300\u200c،\u200c،ˢ\u02ef\u02dfˡ\u0305\u02dfˠ\u02dfˤ\u200c،\u0301\u0305ˠ\u0314\u02df\u02e5\u02ef\u02df\u0302\u02efˠ\u0308\u02df\u02e6\u02ef\u02df\u02f2\u0305ˠ\u0306\u02df\u02e5ˎ\u02df\u02f8\u02ef\u200c،\u200c،\u200c،\u02ef\u0305ˠˏ\u02df\u02e5\u02d2\u02df\u02ff\u02efˠ\u030b\u02df\u02e6\u02f3\u02df\u02e7\u02dfˠ\u02f4\u02dfˣ\u0309\u200c،\u200c،ˎ\u200c،\u0305\u200c،\u02efˠ\u02ef\u02df\u02e6\u02e7\u02df\u0300\u0315ˠ\u0309\u02df\u02e6\u02f3\u02df\u02f7\u0315ˠˎ\u02dfˤ\u02f7\u02df\u02f8\u02efˠ\u0317\u02df\u02e6\u02eb\u02df\u02ff\u02efˠ\u0314\u02df\u02e5\u02d2\u200c،\u200c،\u0316\u02dfˡ\u02d2\u02df\u02eb\u0315\u02df\u0313\u02dfˢ\u200c،\u02ea\u0305\u02df\u0315\u200c،\u200c،\u02ed\u200c،\u02e7\u200c،ˣ\u02df\u02ef\u02efˠ\u0318\u02df\u02e6\u02eb\u02df\u02f8\u02efˠ\u0312\u02df\u02e5\u02e7\u02df\u0300\u02dfˠ\u02d3\u02dfˡ\u200c،\u02f4\u0305ˠ\u030a\u02df\u02e6\u02e7\u02df\u0301\u0315ˠ\u030e\u02df\u02e5\u02d6\u02df\u0300\u0305\u200c،\u02dfˢˣ\u02df\u02ea\u0305\u02df\u0318\u02dfˡ\u02d2\u02df\u02eb\u200c،\u0313\u02dfˢ\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،ˠ\u02ef\u200c،\u02df\u02eb\u200c،\u200c،ˣˢ\u0305\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u02df", "\u200c،", "\u02df\u02df");
					num = ((int)num2 * -1361132886) ^ -1964317172;
					continue;
				case 1u:
					object_ = smethod_3((byte[])obj, bool_3: true);
					num = ((int)num2 * -108450471) ^ -1226357889;
					continue;
				case 0u:
					break;
				default:
					return result;
				}
				break;
			}
		}
	}

	private static object smethod_6(char[] char_0)
	{
		int num3 = default(int);
		bool flag = default(bool);
		bool flag2 = default(bool);
		object result = default(object);
		while (true)
		{
			int num = 1572138107;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1E9324A8u) % 14u)
				{
				case 13u:
					num3 = 251367199;
					num = ((int)num2 * -342364186) ^ -1720792287;
					continue;
				case 12u:
				{
					int num6;
					int num7;
					if (flag)
					{
						num6 = -386030587;
						num7 = -386030587;
					}
					else
					{
						num6 = -47813766;
						num7 = -47813766;
					}
					num = num6 ^ (int)(num2 * 1118873693);
					continue;
				}
				case 11u:
					num = (int)((num2 * 1547312374) ^ 0xEB6F67B);
					continue;
				case 10u:
					flag2 = num3 == 251367153;
					num = 1650417829;
					continue;
				case 9u:
					num = (int)(num2 * 1111291803) ^ -2125036328;
					continue;
				case 7u:
					result = GForm1.smethod_79(char_0, 0, 22528);
					num = ((int)num2 * -957042635) ^ -1550712541;
					continue;
				case 6u:
					num = 1790786986;
					continue;
				case 5u:
				{
					int num4;
					int num5;
					if (flag2)
					{
						num4 = 1823657494;
						num5 = 1823657494;
					}
					else
					{
						num4 = 1931637804;
						num5 = 1931637804;
					}
					num = num4 ^ (int)(num2 * 1834190260);
					continue;
				}
				case 4u:
					num = (int)((num2 * 224227094) ^ 0x670803E1);
					continue;
				case 2u:
					num3 = 251367175;
					num = ((int)num2 * -131994617) ^ -1337522771;
					continue;
				case 1u:
					num3 = 251367135;
					flag = false;
					num = (int)(num2 * 515371820) ^ -2140712574;
					continue;
				case 0u:
					num3 = 251367192;
					num = ((int)num2 * -724274316) ^ -279494461;
					continue;
				case 8u:
					break;
				default:
					return result;
				}
				break;
			}
		}
	}

	public static object smethod_7(object object_0)
	{
		smethod_2((Assembly)object_0);
		object result = default(object);
		return result;
	}

	static void smethod_8(Form form_0, EventHandler eventHandler_0)
	{
		form_0.add_Load(eventHandler_0);
	}

	static void smethod_9(Form form_0, FormClosingEventHandler formClosingEventHandler_0)
	{
		form_0.add_FormClosing(formClosingEventHandler_0);
	}

	static void smethod_10(Form form_0)
	{
		Application.Run(form_0);
	}

	static Process smethod_11()
	{
		return Process.GetCurrentProcess();
	}

	static void smethod_12(Process process_0, ProcessPriorityClass processPriorityClass_0)
	{
		process_0.PriorityClass = processPriorityClass_0;
	}

	static string smethod_13()
	{
		return Application.get_StartupPath();
	}

	static string smethod_14(string string_0, string string_1)
	{
		return string_0 + string_1;
	}

	static Image smethod_15(string string_0)
	{
		return Image.FromFile(string_0);
	}

	static void smethod_16(Control control_0, Image image_0)
	{
		control_0.set_BackgroundImage(image_0);
	}

	static Image smethod_17(Control control_0)
	{
		return control_0.get_BackgroundImage();
	}

	static void smethod_18(Timer timer_2)
	{
		timer_2.Start();
	}

	static void smethod_19()
	{
		GC.Collect();
	}

	static void smethod_20(object object_0)
	{
		GC.SuppressFinalize(object_0);
	}

	static int smethod_21(Image image_0)
	{
		return image_0.get_Width();
	}

	static int smethod_22(Image image_0)
	{
		return image_0.get_Height();
	}

	static Bitmap smethod_23(int int_2, int int_3)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected O, but got Unknown
		return new Bitmap(int_2, int_3);
	}

	static Graphics smethod_24(Image image_0)
	{
		return Graphics.FromImage(image_0);
	}

	static ColorMatrix smethod_25()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new ColorMatrix();
	}

	static void smethod_26(ColorMatrix colorMatrix_0, float float_1)
	{
		colorMatrix_0.set_Matrix33(float_1);
	}

	static ImageAttributes smethod_27()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new ImageAttributes();
	}

	static void smethod_28(ImageAttributes imageAttributes_0, ColorMatrix colorMatrix_0, ColorMatrixFlag colorMatrixFlag_0, ColorAdjustType colorAdjustType_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		imageAttributes_0.SetColorMatrix(colorMatrix_0, colorMatrixFlag_0, colorAdjustType_0);
	}

	static void smethod_29(Graphics graphics_0, Image image_0, Rectangle rectangle_0, int int_2, int int_3, int int_4, int int_5, GraphicsUnit graphicsUnit_0, ImageAttributes imageAttributes_0)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		graphics_0.DrawImage(image_0, rectangle_0, int_2, int_3, int_4, int_5, graphicsUnit_0, imageAttributes_0);
	}

	static void smethod_30(Graphics graphics_0)
	{
		graphics_0.Dispose();
	}

	static void smethod_31(Timer timer_2)
	{
		timer_2.Stop();
	}

	static void smethod_32(Timer timer_2, int int_2)
	{
		timer_2.set_Interval(int_2);
	}

	static void smethod_33(Control control_0)
	{
		control_0.Show();
	}

	static void smethod_34(Form form_0)
	{
		form_0.Close();
	}

	static DialogResult smethod_35(string string_0, string string_1, MessageBoxButtons messageBoxButtons_0, MessageBoxIcon messageBoxIcon_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return MessageBox.Show(string_0, string_1, messageBoxButtons_0, messageBoxIcon_0);
	}

	static void smethod_36(Process process_0)
	{
		process_0.Kill();
	}

	static void smethod_37(CancelEventArgs cancelEventArgs_0, bool bool_3)
	{
		cancelEventArgs_0.Cancel = bool_3;
	}

	static void smethod_38(IDisposable idisposable_0)
	{
		idisposable_0.Dispose();
	}

	static Container smethod_39()
	{
		return new Container();
	}

	static PictureBox smethod_40()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new PictureBox();
	}

	static Timer smethod_41(IContainer icontainer_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		return new Timer(icontainer_1);
	}

	static void smethod_42(ISupportInitialize isupportInitialize_0)
	{
		isupportInitialize_0.BeginInit();
	}

	static void smethod_43(Control control_0)
	{
		control_0.SuspendLayout();
	}

	static void smethod_44(Control control_0, Color color_0)
	{
		control_0.set_BackColor(color_0);
	}

	static void smethod_45(Control control_0, ImageLayout imageLayout_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		control_0.set_BackgroundImageLayout(imageLayout_0);
	}

	static void smethod_46(Control control_0, Point point_0)
	{
		control_0.set_Location(point_0);
	}

	static void smethod_47(Control control_0, string string_0)
	{
		control_0.set_Name(string_0);
	}

	static void smethod_48(Control control_0, Size size_0)
	{
		control_0.set_Size(size_0);
	}

	static void smethod_49(PictureBox pictureBox_5, int int_2)
	{
		pictureBox_5.set_TabIndex(int_2);
	}

	static void smethod_50(PictureBox pictureBox_5, bool bool_3)
	{
		pictureBox_5.set_TabStop(bool_3);
	}

	static void smethod_51(ContainerControl containerControl_0, SizeF sizeF_0)
	{
		containerControl_0.set_AutoScaleDimensions(sizeF_0);
	}

	static void smethod_52(ContainerControl containerControl_0, AutoScaleMode autoScaleMode_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		containerControl_0.set_AutoScaleMode(autoScaleMode_0);
	}

	static void smethod_53(Form form_0, Color color_0)
	{
		form_0.set_BackColor(color_0);
	}

	static void smethod_54(Form form_0, Size size_0)
	{
		form_0.set_ClientSize(size_0);
	}

	static ControlCollection smethod_55(Control control_0)
	{
		return control_0.get_Controls();
	}

	static void smethod_56(ControlCollection controlCollection_0, Control control_0)
	{
		controlCollection_0.Add(control_0);
	}

	static Font smethod_57(string string_0, float float_1, FontStyle fontStyle_0, GraphicsUnit graphicsUnit_0, byte byte_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		return new Font(string_0, float_1, fontStyle_0, graphicsUnit_0, byte_0);
	}

	static void smethod_58(Control control_0, Font font_0)
	{
		control_0.set_Font(font_0);
	}

	static void smethod_59(Form form_0, FormBorderStyle formBorderStyle_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		form_0.set_FormBorderStyle(formBorderStyle_0);
	}

	static void smethod_60(Form form_0, Padding padding_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		form_0.set_Margin(padding_0);
	}

	static void smethod_61(Form form_0, bool bool_3)
	{
		form_0.set_MaximizeBox(bool_3);
	}

	static void smethod_62(Control control_0, string string_0)
	{
		control_0.set_Name(string_0);
	}

	static void smethod_63(Form form_0, FormStartPosition formStartPosition_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		form_0.set_StartPosition(formStartPosition_0);
	}

	static void smethod_64(Form form_0, string string_0)
	{
		form_0.set_Text(string_0);
	}

	static void smethod_65(ISupportInitialize isupportInitialize_0)
	{
		isupportInitialize_0.EndInit();
	}

	static void smethod_66(Control control_0, bool bool_3)
	{
		control_0.ResumeLayout(bool_3);
	}

	static MethodInfo[] smethod_67(Type type_0)
	{
		return type_0.GetMethods();
	}

	static object smethod_68(object object_0, string string_0, CallType callType_0, object[] object_1)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		return Versioned.CallByName(object_0, string_0, callType_0, object_1);
	}

	static Type[] smethod_69(Assembly assembly_0)
	{
		return assembly_0.GetTypes();
	}

	static Assembly smethod_70(byte[] byte_0)
	{
		return Assembly.Load(byte_0);
	}

	static char smethod_71(string string_0, int int_2)
	{
		return string_0[int_2];
	}

	static string smethod_72(char char_0)
	{
		return Conversions.ToString(char_0);
	}

	static int smethod_73(string string_0)
	{
		return Strings.AscW(string_0);
	}

	static char smethod_74(int int_2)
	{
		return Strings.Chr(int_2);
	}

	static int smethod_75(string string_0)
	{
		return string_0.Length;
	}

	static string smethod_76(string string_0, string string_1, string string_2)
	{
		return string_0.Replace(string_1, string_2);
	}

	static char[] smethod_77(string string_0)
	{
		return string_0.ToCharArray();
	}

	static object smethod_78(object object_0)
	{
		return RuntimeHelpers.GetObjectValue(object_0);
	}

	static byte[] smethod_79(char[] char_0, int int_2, int int_3)
	{
		return Convert.FromBase64CharArray(char_0, int_2, int_3);
	}

	static void smethod_80(Timer timer_2, EventHandler eventHandler_0)
	{
		timer_2.remove_Tick(eventHandler_0);
	}

	static void smethod_81(Timer timer_2, EventHandler eventHandler_0)
	{
		timer_2.add_Tick(eventHandler_0);
	}

	static void smethod_82(Control control_0, EventHandler eventHandler_0)
	{
		control_0.remove_MouseEnter(eventHandler_0);
	}

	static void smethod_83(Control control_0, EventHandler eventHandler_0)
	{
		control_0.remove_MouseLeave(eventHandler_0);
	}

	static void smethod_84(Control control_0, MouseEventHandler mouseEventHandler_0)
	{
		control_0.remove_MouseClick(mouseEventHandler_0);
	}

	static void smethod_85(Control control_0, EventHandler eventHandler_0)
	{
		control_0.add_MouseEnter(eventHandler_0);
	}

	static void smethod_86(Control control_0, EventHandler eventHandler_0)
	{
		control_0.add_MouseLeave(eventHandler_0);
	}

	static void smethod_87(Control control_0, MouseEventHandler mouseEventHandler_0)
	{
		control_0.add_MouseClick(mouseEventHandler_0);
	}
}
