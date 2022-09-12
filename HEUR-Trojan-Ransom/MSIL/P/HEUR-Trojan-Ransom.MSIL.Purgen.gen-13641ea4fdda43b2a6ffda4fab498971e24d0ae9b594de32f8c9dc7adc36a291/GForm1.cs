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
			Timer val = default(Timer);
			while (true)
			{
				int num = -287619569;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xDD246356u) % 8u)
					{
					case 7u:
					{
						int num5;
						int num6;
						if (val != null)
						{
							num5 = 2039640415;
							num6 = 2039640415;
						}
						else
						{
							num5 = 1560067350;
							num6 = 1560067350;
						}
						num = num5 ^ ((int)num2 * -61196155);
						continue;
					}
					case 4u:
					{
						int num3;
						int num4;
						if (val == null)
						{
							num3 = -1819611012;
							num4 = -1819611012;
						}
						else
						{
							num3 = -1271722142;
							num4 = -1271722142;
						}
						num = num3 ^ ((int)num2 * -1633175701);
						continue;
					}
					case 3u:
						timer_0 = value;
						val = timer_0;
						num = -476228358;
						continue;
					case 2u:
						GForm1.smethod_80(val, eventHandler_);
						num = (int)((num2 * 942670363) ^ 0x5370A5B);
						continue;
					case 1u:
						val = timer_0;
						num = ((int)num2 * -1782135521) ^ -1789279338;
						continue;
					case 0u:
						GForm1.smethod_81(val, eventHandler_);
						num = ((int)num2 * -733142139) ^ 0x18A54888;
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
			//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d2: Expected O, but got Unknown
			EventHandler eventHandler_ = method_2;
			EventHandler eventHandler_2 = method_3;
			PictureBox val = default(PictureBox);
			MouseEventHandler mouseEventHandler_ = default(MouseEventHandler);
			while (true)
			{
				int num = 1334302900;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x767C63D1u) % 10u)
					{
					case 9u:
						pictureBox_1 = value;
						num = 31453632;
						continue;
					case 7u:
						GForm1.smethod_82((Control)(object)val, eventHandler_);
						num = (int)((num2 * 1977665832) ^ 0x15524083);
						continue;
					case 6u:
						GForm1.smethod_86((Control)(object)val, eventHandler_2);
						GForm1.smethod_87((Control)(object)val, mouseEventHandler_);
						num = ((int)num2 * -2007728194) ^ 0x31E32275;
						continue;
					case 5u:
					{
						val = pictureBox_1;
						int num5;
						int num6;
						if (val != null)
						{
							num5 = -1626256467;
							num6 = -1626256467;
						}
						else
						{
							num5 = -461100835;
							num6 = -461100835;
						}
						num = num5 ^ ((int)num2 * -1730040080);
						continue;
					}
					case 3u:
						GForm1.smethod_84((Control)(object)val, mouseEventHandler_);
						num = ((int)num2 * -667890435) ^ 0x62F073D1;
						continue;
					case 2u:
						GForm1.smethod_83((Control)(object)val, eventHandler_2);
						num = (int)((num2 * 548398367) ^ 0x792F68D0);
						continue;
					case 1u:
					{
						mouseEventHandler_ = new MouseEventHandler(method_4);
						val = pictureBox_1;
						int num3;
						int num4;
						if (val != null)
						{
							num3 = -1130553590;
							num4 = -1130553590;
						}
						else
						{
							num3 = -172823318;
							num4 = -172823318;
						}
						num = num3 ^ ((int)num2 * -2019720896);
						continue;
					}
					case 0u:
						GForm1.smethod_85((Control)(object)val, eventHandler_);
						num = ((int)num2 * -585891827) ^ -133385703;
						continue;
					default:
						return;
					case 8u:
						break;
					case 4u:
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
			//IL_0040: Unknown result type (might be due to invalid IL or missing references)
			//IL_0046: Expected O, but got Unknown
			EventHandler eventHandler_ = method_5;
			EventHandler eventHandler_2 = method_6;
			PictureBox val = default(PictureBox);
			MouseEventHandler mouseEventHandler_ = default(MouseEventHandler);
			while (true)
			{
				int num = 1302073385;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x4ED0E35Bu) % 10u)
					{
					case 8u:
						GForm1.smethod_87((Control)(object)val, mouseEventHandler_);
						num = ((int)num2 * -1554157862) ^ 0xD7D6686;
						continue;
					case 6u:
					{
						mouseEventHandler_ = new MouseEventHandler(method_7);
						val = pictureBox_2;
						int num5;
						int num6;
						if (val != null)
						{
							num5 = -1969353365;
							num6 = -1969353365;
						}
						else
						{
							num5 = -1001163876;
							num6 = -1001163876;
						}
						num = num5 ^ ((int)num2 * -1597079994);
						continue;
					}
					case 5u:
						pictureBox_2 = value;
						val = pictureBox_2;
						num = 1405416405;
						continue;
					case 4u:
						GForm1.smethod_82((Control)(object)val, eventHandler_);
						num = (int)(num2 * 623852564) ^ -1028025030;
						continue;
					case 3u:
						GForm1.smethod_85((Control)(object)val, eventHandler_);
						num = (int)((num2 * 584593877) ^ 0x639648CE);
						continue;
					case 2u:
					{
						int num3;
						int num4;
						if (val == null)
						{
							num3 = -1150410928;
							num4 = -1150410928;
						}
						else
						{
							num3 = -1546071154;
							num4 = -1546071154;
						}
						num = num3 ^ ((int)num2 * -1115983273);
						continue;
					}
					case 1u:
						GForm1.smethod_83((Control)(object)val, eventHandler_2);
						GForm1.smethod_84((Control)(object)val, mouseEventHandler_);
						num = ((int)num2 * -2011313299) ^ 0x62666BCD;
						continue;
					case 0u:
						GForm1.smethod_86((Control)(object)val, eventHandler_2);
						num = (int)((num2 * 1144994929) ^ 0x49E9D43F);
						continue;
					default:
						return;
					case 9u:
						break;
					case 7u:
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
			//IL_004e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0054: Expected O, but got Unknown
			EventHandler eventHandler_ = method_8;
			EventHandler eventHandler_2 = method_9;
			PictureBox val = default(PictureBox);
			MouseEventHandler mouseEventHandler_ = default(MouseEventHandler);
			while (true)
			{
				int num = -1945583593;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x8B17B518u) % 13u)
					{
					case 12u:
					{
						int num5;
						int num6;
						if (val == null)
						{
							num5 = -473677931;
							num6 = -473677931;
						}
						else
						{
							num5 = -1481761854;
							num6 = -1481761854;
						}
						num = num5 ^ (int)(num2 * 67737397);
						continue;
					}
					case 11u:
						mouseEventHandler_ = new MouseEventHandler(method_10);
						num = (int)((num2 * 1567394739) ^ 0x60A78F14);
						continue;
					case 10u:
						GForm1.smethod_87((Control)(object)val, mouseEventHandler_);
						num = (int)((num2 * 1224401680) ^ 0x6E022B07);
						continue;
					case 9u:
					{
						int num3;
						int num4;
						if (val != null)
						{
							num3 = 1182983543;
							num4 = 1182983543;
						}
						else
						{
							num3 = 324342167;
							num4 = 324342167;
						}
						num = num3 ^ (int)(num2 * 2044249970);
						continue;
					}
					case 8u:
						GForm1.smethod_82((Control)(object)val, eventHandler_);
						num = ((int)num2 * -367922783) ^ -353589811;
						continue;
					case 6u:
						GForm1.smethod_84((Control)(object)val, mouseEventHandler_);
						num = (int)(num2 * 565492923) ^ -1050626339;
						continue;
					case 4u:
						pictureBox_3 = value;
						val = pictureBox_3;
						num = -1384662752;
						continue;
					case 3u:
						val = pictureBox_3;
						num = (int)((num2 * 1806216536) ^ 0x3DB6EB62);
						continue;
					case 2u:
						GForm1.smethod_85((Control)(object)val, eventHandler_);
						num = (int)(num2 * 1884966673) ^ -190644570;
						continue;
					case 1u:
						GForm1.smethod_86((Control)(object)val, eventHandler_2);
						num = ((int)num2 * -880576940) ^ -542694390;
						continue;
					case 0u:
						GForm1.smethod_83((Control)(object)val, eventHandler_2);
						num = (int)(num2 * 2135097894) ^ -63247744;
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
			//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
			//IL_0103: Expected O, but got Unknown
			EventHandler eventHandler_ = method_11;
			PictureBox val = default(PictureBox);
			MouseEventHandler mouseEventHandler_ = default(MouseEventHandler);
			EventHandler eventHandler_2 = default(EventHandler);
			while (true)
			{
				int num = -1638802321;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xE462DFD3u) % 11u)
					{
					case 10u:
					{
						int num5;
						int num6;
						if (val == null)
						{
							num5 = 1022850347;
							num6 = 1022850347;
						}
						else
						{
							num5 = 1086226757;
							num6 = 1086226757;
						}
						num = num5 ^ (int)(num2 * 1183686334);
						continue;
					}
					case 9u:
						GForm1.smethod_85((Control)(object)val, eventHandler_);
						num = (int)(num2 * 1083989932) ^ -1441977735;
						continue;
					case 7u:
						GForm1.smethod_87((Control)(object)val, mouseEventHandler_);
						num = ((int)num2 * -961043605) ^ -2101776391;
						continue;
					case 6u:
						val = pictureBox_4;
						num = ((int)num2 * -558615823) ^ -1139468512;
						continue;
					case 4u:
						GForm1.smethod_82((Control)(object)val, eventHandler_);
						GForm1.smethod_83((Control)(object)val, eventHandler_2);
						GForm1.smethod_84((Control)(object)val, mouseEventHandler_);
						num = ((int)num2 * -602873367) ^ 0x2F888EED;
						continue;
					case 3u:
						GForm1.smethod_86((Control)(object)val, eventHandler_2);
						num = ((int)num2 * -473837183) ^ 0x6599031D;
						continue;
					case 2u:
					{
						int num3;
						int num4;
						if (val != null)
						{
							num3 = 1922842734;
							num4 = 1922842734;
						}
						else
						{
							num3 = 2060312225;
							num4 = 2060312225;
						}
						num = num3 ^ (int)(num2 * 220456144);
						continue;
					}
					case 1u:
						eventHandler_2 = method_12;
						mouseEventHandler_ = new MouseEventHandler(method_13);
						val = pictureBox_4;
						num = (int)((num2 * 704537841) ^ 0x4B1D7E53);
						continue;
					case 0u:
						pictureBox_4 = value;
						num = -1284305075;
						continue;
					default:
						return;
					case 5u:
						break;
					case 8u:
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
			Timer val = default(Timer);
			while (true)
			{
				int num = -389966525;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x8C3A133Bu) % 9u)
					{
					case 8u:
						GForm1.smethod_81(val, eventHandler_);
						num = ((int)num2 * -1704942054) ^ 0x7E1F89C2;
						continue;
					case 7u:
						timer_1 = value;
						num = -1657849134;
						continue;
					case 6u:
					{
						int num5;
						int num6;
						if (val != null)
						{
							num5 = -1369115219;
							num6 = -1369115219;
						}
						else
						{
							num5 = -269233701;
							num6 = -269233701;
						}
						num = num5 ^ (int)(num2 * 924234103);
						continue;
					}
					case 4u:
					{
						int num3;
						int num4;
						if (val != null)
						{
							num3 = 707012678;
							num4 = 707012678;
						}
						else
						{
							num3 = 298771632;
							num4 = 298771632;
						}
						num = num3 ^ ((int)num2 * -1399473741);
						continue;
					}
					case 3u:
						val = timer_1;
						num = ((int)num2 * -1305293178) ^ -637717747;
						continue;
					case 2u:
						val = timer_1;
						num = (int)(num2 * 1469841595) ^ -326743080;
						continue;
					case 0u:
						GForm1.smethod_80(val, eventHandler_);
						num = ((int)num2 * -1213368650) ^ -267577772;
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
	}

	public GForm1()
	{
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		while (true)
		{
			int num = -1987860279;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xCAE88AE8u) % 10u)
				{
				case 9u:
					method_17();
					num = (int)(num2 * 1499499791) ^ -811797438;
					continue;
				case 8u:
					num = (int)((num2 * 1189086040) ^ 0x9155528);
					continue;
				case 7u:
					bool_0 = false;
					bool_1 = false;
					bool_2 = false;
					num = (int)(num2 * 18207513) ^ -1290582046;
					continue;
				case 5u:
					GForm1.smethod_9((Form)(object)this, new FormClosingEventHandler(method_15));
					num = (int)(num2 * 798281924) ^ -1943702242;
					continue;
				case 4u:
					int_0 = 0;
					num = ((int)num2 * -997149370) ^ -2129884572;
					continue;
				case 2u:
					GForm1.smethod_8((Form)(object)this, (EventHandler)method_0);
					num = ((int)num2 * -576853719) ^ 0x6ED13821;
					continue;
				case 1u:
					num = ((int)num2 * -771442429) ^ 0x467C8E07;
					continue;
				case 0u:
					int_1 = 0;
					float_0 = 0.3f;
					num = (int)(num2 * 2035397401) ^ -791174831;
					continue;
				default:
					return;
				case 6u:
					break;
				case 3u:
					return;
				}
				break;
			}
		}
	}

	[STAThread]
	public static void Main()
	{
		Application.Run((Form)(object)Class2.Class3_0.GForm1_0);
	}

	private void method_0(object sender, EventArgs e)
	{
		bool flag3 = default(bool);
		bool flag2 = default(bool);
		bool flag = default(bool);
		while (true)
		{
			int num = -79997166;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xDB9DEF16u) % 56u)
				{
				case 55u:
					GForm1.smethod_20((object)float_0);
					num = ((int)num2 * -1523137757) ^ 0x6930554F;
					continue;
				case 54u:
					GClass4.smethod_0(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\opzioni_hover.png"));
					GClass4.smethod_0(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\storia_hover.png"));
					GClass4.smethod_0(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\duello_pressed.png"));
					GClass4.smethod_0(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\esci_pressed.png"));
					GClass4.smethod_0(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\opzioni_pressed.png"));
					GClass4.smethod_0(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\storia_pressed.png"));
					num = ((int)num2 * -364097170) ^ 0x510284ED;
					continue;
				case 53u:
					GForm1.smethod_19();
					num = ((int)num2 * -719087283) ^ -1292473139;
					continue;
				case 52u:
					num = ((int)num2 * -54468513) ^ -641257442;
					continue;
				case 51u:
					GClass4.smethod_0(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Music\\introduction_start_music.mp3"));
					GForm1.smethod_16((Control)(object)this, GForm1.smethod_15(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\main_menu.jpg")));
					num = (int)((num2 * 1738145627) ^ 0x6C447678);
					continue;
				case 50u:
					num = (int)((num2 * 500930686) ^ 0x2A6325EB);
					continue;
				case 49u:
					GClass4.smethod_0(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\esci_hover.png"));
					num = (int)((num2 * 1620312672) ^ 0x6F0A9BC0);
					continue;
				case 48u:
					GForm1.smethod_16((Control)(object)PictureBox_2, GForm1.smethod_15(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\duello.png")));
					GForm1.smethod_16((Control)(object)PictureBox_3, GForm1.smethod_15(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\opzioni.png")));
					num = (int)(num2 * 1311047320) ^ -475503211;
					continue;
				case 47u:
					GClass4.smethod_0(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\con_la_cpu.png"));
					num = (int)(num2 * 597092992) ^ -2031667283;
					continue;
				case 46u:
					GForm1.smethod_20((object)int_0);
					GForm1.smethod_20((object)int_1);
					num = ((int)num2 * -960247927) ^ 0x609A58FF;
					continue;
				case 45u:
					num = -81987406;
					continue;
				case 44u:
				{
					int num7;
					int num8;
					if (!flag3)
					{
						num7 = -1690778946;
						num8 = -1690778946;
					}
					else
					{
						num7 = -1267588237;
						num8 = -1267588237;
					}
					num = num7 ^ ((int)num2 * -13011326);
					continue;
				}
				case 43u:
					GForm1.smethod_16((Control)(object)PictureBox_4, GForm1.smethod_15(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\esci.png")));
					num = ((int)num2 * -1315896652) ^ 0x73577FF0;
					continue;
				case 42u:
					num = (int)(num2 * 302408830) ^ -1465518468;
					continue;
				case 41u:
					num = (int)(num2 * 1778344894) ^ -668200603;
					continue;
				case 40u:
					GClass4.smethod_0(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\dark_story.jpg"));
					num = (int)(num2 * 555415836) ^ -1954433175;
					continue;
				case 39u:
					GForm1.smethod_16((Control)(object)PictureBox_0, (Image)(object)smethod_0(GForm1.smethod_17((Control)(object)PictureBox_0), 0.1f));
					num = ((int)num2 * -318730551) ^ 0x173D5FAB;
					continue;
				case 37u:
					GClass1.smethod_1().method_0();
					num = ((int)num2 * -1688868999) ^ 0x4742EB8E;
					continue;
				case 36u:
					num = (int)(num2 * 881822936) ^ -1131392615;
					continue;
				case 35u:
					GForm1.smethod_16((Control)(object)PictureBox_4, (Image)(object)smethod_0(GForm1.smethod_15(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\esci.png")), 0.1f));
					num = (int)(num2 * 99274731) ^ -280082356;
					continue;
				case 34u:
					num = ((int)num2 * -703579981) ^ -175598765;
					continue;
				case 33u:
					GForm1.smethod_16((Control)(object)PictureBox_1, (Image)(object)smethod_0(GForm1.smethod_15(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\storia.png")), 0.1f));
					num = (int)((num2 * 1251057372) ^ 0x53370C6A);
					continue;
				case 32u:
					GClass4.smethod_0(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\esci.png"));
					num = (int)((num2 * 1836357900) ^ 0x78CA846D);
					continue;
				case 31u:
					GClass4.smethod_0(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Music\\horror_music.mp3"));
					GClass4.smethod_0(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\schermata_omegle.png"));
					num = ((int)num2 * -1274921811) ^ -759402120;
					continue;
				case 30u:
					GClass4.smethod_0(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Music\\main_menu_theme.mp3"));
					GClass4.smethod_0(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\logo.png"));
					GClass4.smethod_0(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\main_menu.jpg"));
					num = ((int)num2 * -1154222180) ^ 0x74ACA0BE;
					continue;
				case 29u:
					GForm1.smethod_18(Timer_1);
					GClass1.smethod_0();
					num = (int)((num2 * 286896105) ^ 0x1315F22A);
					continue;
				case 28u:
					flag3 = !GClass1.bool_1;
					num = (int)(num2 * 1296348813) ^ -465356442;
					continue;
				case 27u:
					GClass4.smethod_0(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\opzioni.png"));
					GClass4.smethod_0(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\storia.png"));
					GClass4.smethod_0(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\duello_hover.png"));
					num = (int)((num2 * 576275246) ^ 0xCC7692D);
					continue;
				case 25u:
					GForm1.smethod_16((Control)(object)PictureBox_1, GForm1.smethod_15(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\storia.png")));
					num = (int)((num2 * 1696948604) ^ 0x434668BB);
					continue;
				case 24u:
					GClass3.smethod_0(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Music"));
					num = (int)(num2 * 758692993) ^ -1026002712;
					continue;
				case 23u:
					num = -147993917;
					continue;
				case 22u:
					flag2 = GClass1.bool_1;
					num = (int)(num2 * 1181622235) ^ -747051201;
					continue;
				case 21u:
					GClass4.smethod_0(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\marco_introduzione.png"));
					num = (int)((num2 * 547081745) ^ 0x27DE2570);
					continue;
				case 20u:
					num = (int)(num2 * 1590326845) ^ -1988459625;
					continue;
				case 19u:
				{
					int num5;
					int num6;
					if (flag2)
					{
						num5 = -1517155449;
						num6 = -1517155449;
					}
					else
					{
						num5 = -1178198212;
						num6 = -1178198212;
					}
					num = num5 ^ ((int)num2 * -302809131);
					continue;
				}
				case 18u:
					num = (int)(num2 * 1268799463) ^ -1516354507;
					continue;
				case 17u:
					num = (int)(num2 * 884051444) ^ -464472990;
					continue;
				case 16u:
					num = -1534698612;
					continue;
				case 15u:
					flag = !GClass1.bool_1;
					num = (int)(num2 * 166145992) ^ -1726619511;
					continue;
				case 14u:
					GForm1.smethod_18(Timer_0);
					num = (int)(num2 * 1739270854) ^ -141574316;
					continue;
				case 13u:
					GClass3.smethod_0(GForm1.smethod_14(GForm1.smethod_13(), "\\data"));
					num = (int)((num2 * 2109318771) ^ 0x5B7FF69);
					continue;
				case 12u:
					GForm1.smethod_12(GForm1.smethod_11(), ProcessPriorityClass.RealTime);
					num = ((int)num2 * -1789532505) ^ 0x765B2CC0;
					continue;
				case 11u:
					num = ((int)num2 * -1484178200) ^ -1840797991;
					continue;
				case 10u:
					num = (int)((num2 * 791258885) ^ 0x5F6962D5);
					continue;
				case 9u:
					GClass1.bool_1 = true;
					num = (int)((num2 * 1151250772) ^ 0x70C5880B);
					continue;
				case 8u:
					GForm1.smethod_16((Control)(object)PictureBox_2, (Image)(object)smethod_0(GForm1.smethod_15(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\duello.png")), 0.1f));
					GForm1.smethod_16((Control)(object)PictureBox_3, (Image)(object)smethod_0(GForm1.smethod_15(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\opzioni.png")), 0.1f));
					num = ((int)num2 * -1487750354) ^ 0x182214D4;
					continue;
				case 7u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = 1048594652;
						num4 = 1048594652;
					}
					else
					{
						num3 = 1207975669;
						num4 = 1207975669;
					}
					num = num3 ^ (int)(num2 * 1440456147);
					continue;
				}
				case 6u:
					num = (int)(num2 * 2006852475) ^ -1412565720;
					continue;
				case 5u:
					num = (int)((num2 * 1352167310) ^ 0x1E720D41);
					continue;
				case 4u:
					bool_0 = true;
					bool_1 = false;
					GForm1.smethod_16((Control)(object)PictureBox_0, GForm1.smethod_15(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\logo.png")));
					num = ((int)num2 * -345427391) ^ -454527720;
					continue;
				case 3u:
					GClass4.smethod_0(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\con_la_cpu_hover.png"));
					GClass4.smethod_0(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\con_gli_altri.png"));
					GClass4.smethod_0(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\fai_un_duello.png"));
					num = ((int)num2 * -521222648) ^ 0x91ED646;
					continue;
				case 2u:
					GForm1.smethod_19();
					num = ((int)num2 * -1019189963) ^ 0x1058F298;
					continue;
				case 1u:
					num = (int)((num2 * 1971713876) ^ 0x48748002);
					continue;
				case 0u:
					GClass4.smethod_0(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\duello.png"));
					num = ((int)num2 * -1602744430) ^ 0xF91C09E;
					continue;
				default:
					return;
				case 38u:
					break;
				case 26u:
					return;
				}
				break;
			}
		}
	}

	public static Bitmap smethod_0(Image image_0, float float_1)
	{
		Bitmap val = GForm1.smethod_23(GForm1.smethod_21(image_0), GForm1.smethod_22(image_0));
		Graphics graphics_ = default(Graphics);
		ColorMatrix colorMatrix_ = default(ColorMatrix);
		ImageAttributes imageAttributes_ = default(ImageAttributes);
		Bitmap result = default(Bitmap);
		while (true)
		{
			int num = 1237261334;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6FA297C4u) % 8u)
				{
				case 7u:
					GForm1.smethod_30(graphics_);
					num = (int)(num2 * 80071340) ^ -878266983;
					continue;
				case 6u:
					GForm1.smethod_26(colorMatrix_, float_1);
					num = (int)((num2 * 638531600) ^ 0xC92E73C);
					continue;
				case 5u:
					GForm1.smethod_28(imageAttributes_, colorMatrix_, (ColorMatrixFlag)0, (ColorAdjustType)1);
					GForm1.smethod_29(graphics_, image_0, new Rectangle(0, 0, GForm1.smethod_21((Image)(object)val), GForm1.smethod_22((Image)(object)val)), 0, 0, GForm1.smethod_21(image_0), GForm1.smethod_22(image_0), (GraphicsUnit)2, imageAttributes_);
					num = ((int)num2 * -797480811) ^ 0x23BD302;
					continue;
				case 2u:
					graphics_ = GForm1.smethod_24((Image)(object)val);
					colorMatrix_ = GForm1.smethod_25();
					num = ((int)num2 * -1185841107) ^ 0x66DEC100;
					continue;
				case 1u:
					result = val;
					num = (int)((num2 * 1149246471) ^ 0x67F8528);
					continue;
				case 0u:
					imageAttributes_ = GForm1.smethod_27();
					num = (int)(num2 * 224259494) ^ -977056703;
					continue;
				case 4u:
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
		bool flag4 = default(bool);
		bool flag2 = default(bool);
		bool flag = default(bool);
		bool flag3 = default(bool);
		while (true)
		{
			int num = 986661526;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x57579329u) % 61u)
				{
				case 60u:
					flag4 = int_1 == 3;
					num = 179427705;
					continue;
				case 59u:
					num = (int)((num2 * 1898502383) ^ 0x1EB713A1);
					continue;
				case 58u:
					GForm1.smethod_32(Timer_0, 50);
					num = ((int)num2 * -990276798) ^ -929668647;
					continue;
				case 57u:
					num = 988571980;
					continue;
				case 56u:
				{
					ref float reference = ref float_0;
					reference = (float)((double)reference + 0.3);
					num = ((int)num2 * -317170104) ^ -878969678;
					continue;
				}
				case 55u:
					num = (int)(num2 * 896380772) ^ -1857497092;
					continue;
				case 54u:
					num = (int)(num2 * 905156185) ^ -449926273;
					continue;
				case 53u:
					num = ((int)num2 * -188324283) ^ -1186112330;
					continue;
				case 52u:
				{
					ref float reference5 = ref float_0;
					reference5 = (float)((double)reference5 + 0.3);
					num = (int)((num2 * 1161031610) ^ 0xE293299);
					continue;
				}
				case 51u:
				{
					ref float reference4 = ref float_0;
					reference4 = (float)((double)reference4 + 0.3);
					num = ((int)num2 * -74415205) ^ 0x4B8BFC83;
					continue;
				}
				case 50u:
					GForm1.smethod_20((object)Timer_0);
					GForm1.smethod_19();
					num = ((int)num2 * -1183067594) ^ 0x12F51F66;
					continue;
				case 49u:
				{
					int num10;
					int num11;
					if (!(((int_0 <= 15) & (int_1 == 0)) | ((int_0 <= 9) & (int_1 != 0))))
					{
						num10 = 145177309;
						num11 = 145177309;
					}
					else
					{
						num10 = 2076497876;
						num11 = 2076497876;
					}
					num = num10 ^ ((int)num2 * -17902951);
					continue;
				}
				case 48u:
					num = (int)(num2 * 2010566461) ^ -1831722494;
					continue;
				case 47u:
				{
					int num6;
					int num7;
					if (flag2)
					{
						num6 = 895879045;
						num7 = 895879045;
					}
					else
					{
						num6 = 1890733171;
						num7 = 1890733171;
					}
					num = num6 ^ (int)(num2 * 2073646104);
					continue;
				}
				case 46u:
				{
					int num16;
					if (int_1 != 5)
					{
						num = 979981144;
						num16 = 979981144;
					}
					else
					{
						num = 1634972864;
						num16 = 1634972864;
					}
					continue;
				}
				case 45u:
				{
					int num14;
					int num15;
					if (!flag)
					{
						num14 = 38801807;
						num15 = 38801807;
					}
					else
					{
						num14 = 845802182;
						num15 = 845802182;
					}
					num = num14 ^ ((int)num2 * -542237851);
					continue;
				}
				case 44u:
					checked
					{
						int_1++;
						num = 1214926075;
						continue;
					}
				case 43u:
					GForm1.smethod_16((Control)(object)PictureBox_0, (Image)(object)smethod_0(GForm1.smethod_17((Control)(object)PictureBox_0), float_0));
					num = (int)((num2 * 1965061116) ^ 0x2AD5396D);
					continue;
				case 42u:
					GForm1.smethod_16((Control)(object)this, GForm1.smethod_15(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\main_menu.jpg")));
					num = (int)(num2 * 53882865) ^ -1120226141;
					continue;
				case 41u:
				{
					ref float reference3 = ref float_0;
					reference3 = (float)((double)reference3 + 0.3);
					num = ((int)num2 * -1414309036) ^ 0x51922CCB;
					continue;
				}
				case 40u:
					num = (int)((num2 * 666601559) ^ 0x3899DE98);
					continue;
				case 39u:
					num = (int)((num2 * 1847936936) ^ 0x312245C);
					continue;
				case 38u:
					GForm1.smethod_20((object)float_0);
					num = (int)((num2 * 2076850873) ^ 0xC3A4C14);
					continue;
				case 37u:
					num = ((int)num2 * -172628011) ^ -412955898;
					continue;
				case 36u:
					num = 1886259593;
					continue;
				case 35u:
					GForm1.smethod_16((Control)(object)PictureBox_1, (Image)(object)smethod_0(GForm1.smethod_17((Control)(object)PictureBox_1), float_0));
					num = ((int)num2 * -1132083346) ^ 0x10D955C8;
					continue;
				case 34u:
					GForm1.smethod_16((Control)(object)PictureBox_4, (Image)(object)smethod_0(GForm1.smethod_17((Control)(object)PictureBox_4), float_0));
					num = ((int)num2 * -1658944111) ^ -1592467680;
					continue;
				case 33u:
					GForm1.smethod_16((Control)(object)PictureBox_3, GForm1.smethod_15(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\opzioni.png")));
					num = (int)((num2 * 317695239) ^ 0x4E8ADC86);
					continue;
				case 32u:
					int_0 = 0;
					num = (int)((num2 * 384697338) ^ 0x5A0605C9);
					continue;
				case 31u:
					GForm1.smethod_16((Control)(object)PictureBox_2, GForm1.smethod_15(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\duello.png")));
					num = (int)((num2 * 425385171) ^ 0x172CFCC4);
					continue;
				case 30u:
					num = ((int)num2 * -387509999) ^ 0x479233BF;
					continue;
				case 29u:
					int_0 = 0;
					num = (int)((num2 * 206269871) ^ 0x3B385741);
					continue;
				case 28u:
					num = (int)((num2 * 672166105) ^ 0x28EB413D);
					continue;
				case 27u:
					num = ((int)num2 * -1091967147) ^ -841160346;
					continue;
				case 26u:
				{
					ref float reference2 = ref float_0;
					reference2 = (float)((double)reference2 + 0.3);
					num = (int)(num2 * 696834936) ^ -328216754;
					continue;
				}
				case 25u:
				{
					int num12;
					int num13;
					if (int_1 == 1)
					{
						num12 = -2087030967;
						num13 = -2087030967;
					}
					else
					{
						num12 = -1583915985;
						num13 = -1583915985;
					}
					num = num12 ^ (int)(num2 * 2038453964);
					continue;
				}
				case 24u:
					flag3 = int_1 == 2;
					num = 872764349;
					continue;
				case 23u:
					num = (int)(num2 * 1938644608) ^ -1489465702;
					continue;
				case 22u:
					GForm1.smethod_16((Control)(object)PictureBox_4, GForm1.smethod_15(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\esci.png")));
					num = (int)(num2 * 1601940741) ^ -1456559375;
					continue;
				case 21u:
					GForm1.smethod_16((Control)(object)PictureBox_3, (Image)(object)smethod_0(GForm1.smethod_17((Control)(object)PictureBox_3), float_0));
					num = (int)((num2 * 715320975) ^ 0x56010E3A);
					continue;
				case 20u:
					GForm1.smethod_20((object)int_0);
					num = (int)((num2 * 1115462688) ^ 0x777429E8);
					continue;
				case 19u:
				{
					int num8;
					int num9;
					if (!flag4)
					{
						num8 = -194452959;
						num9 = -194452959;
					}
					else
					{
						num8 = -1019817434;
						num9 = -1019817434;
					}
					num = num8 ^ (int)(num2 * 27069887);
					continue;
				}
				case 18u:
					GForm1.smethod_16((Control)(object)PictureBox_0, GForm1.smethod_15(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\logo.png")));
					num = ((int)num2 * -1030651817) ^ 0x708C80AC;
					continue;
				case 17u:
					num = (int)(num2 * 335193098) ^ -1845781625;
					continue;
				case 15u:
					num = ((int)num2 * -1223258295) ^ 0x6E3432D6;
					continue;
				case 14u:
				{
					int num4;
					int num5;
					if (flag3)
					{
						num4 = 239654510;
						num5 = 239654510;
					}
					else
					{
						num4 = 1300669345;
						num5 = 1300669345;
					}
					num = num4 ^ ((int)num2 * -903237190);
					continue;
				}
				case 13u:
					num = ((int)num2 * -434293544) ^ -1261126735;
					continue;
				case 12u:
					flag2 = int_1 == 0;
					num = (int)((num2 * 772867547) ^ 0x533BB9AA);
					continue;
				case 11u:
					GForm1.smethod_31(Timer_0);
					num = (int)(num2 * 424057364) ^ -1757789388;
					continue;
				case 10u:
					GForm1.smethod_16((Control)(object)PictureBox_2, (Image)(object)smethod_0(GForm1.smethod_17((Control)(object)PictureBox_2), float_0));
					num = ((int)num2 * -668296068) ^ 0x4C421E6C;
					continue;
				case 9u:
					num = (int)((num2 * 1444220133) ^ 0x42D53281);
					continue;
				case 8u:
					float_0 = 0.3f;
					num = (int)(num2 * 1377039411) ^ -88841147;
					continue;
				case 7u:
				{
					int num3;
					if (int_1 != 1)
					{
						num = 215045885;
						num3 = 215045885;
					}
					else
					{
						num = 650033195;
						num3 = 650033195;
					}
					continue;
				}
				case 5u:
					float_0 = 0.3f;
					num = ((int)num2 * -1576224975) ^ 0x509F679E;
					continue;
				case 4u:
					GForm1.smethod_16((Control)(object)PictureBox_1, GForm1.smethod_15(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\storia.png")));
					num = (int)((num2 * 2063182226) ^ 0x29704760);
					continue;
				case 3u:
					flag = int_1 == 4;
					num = 380574808;
					continue;
				case 2u:
					bool_0 = true;
					num = (int)((num2 * 803057615) ^ 0x404CF4D2);
					continue;
				case 1u:
					num = ((int)num2 * -1117930113) ^ -22862045;
					continue;
				case 0u:
					num = 1886259593;
					continue;
				case 6u:
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
		while (true)
		{
			int num = -116633553;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x93ECEE78u) % 7u)
				{
				case 5u:
					num = (int)(num2 * 676061232) ^ -1698914666;
					continue;
				case 4u:
					num = (int)(num2 * 1597016838) ^ -1459748780;
					continue;
				case 3u:
					GForm1.smethod_16((Control)(object)PictureBox_1, GForm1.smethod_15(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\storia_hover.png")));
					num = (int)(num2 * 302004776) ^ -1561236235;
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (bool_0)
					{
						num3 = -1113481652;
						num4 = -1113481652;
					}
					else
					{
						num3 = -1999216836;
						num4 = -1999216836;
					}
					num = num3 ^ ((int)num2 * -663990714);
					continue;
				}
				case 0u:
					num = -1574728648;
					continue;
				default:
					return;
				case 6u:
					break;
				case 2u:
					return;
				}
				break;
			}
		}
	}

	private void method_3(object sender, EventArgs e)
	{
		if (!bool_0)
		{
			return;
		}
		while (true)
		{
			int num = -972707164;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x89AA44BBu) % 4u)
				{
				case 3u:
					GForm1.smethod_16((Control)(object)PictureBox_1, GForm1.smethod_15(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\storia.png")));
					num = ((int)num2 * -44979190) ^ -1939051531;
					continue;
				case 0u:
					num = ((int)num2 * -290122091) ^ 0x244F54E;
					continue;
				default:
					return;
				case 2u:
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
		bool flag = bool_0;
		while (true)
		{
			int num = -772016448;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE96A6875u) % 11u)
				{
				case 10u:
					GClass1.smethod_1().method_3();
					num = (int)((num2 * 1349321412) ^ 0x502A4A1A);
					continue;
				case 9u:
					GForm1.smethod_34((Form)(object)this);
					num = ((int)num2 * -1546111010) ^ -1712193933;
					continue;
				case 8u:
					num = (int)((num2 * 1087920202) ^ 0x37F0E179);
					continue;
				case 7u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = -95343475;
						num4 = -95343475;
					}
					else
					{
						num3 = -1941081412;
						num4 = -1941081412;
					}
					num = num3 ^ (int)(num2 * 1039705151);
					continue;
				}
				case 6u:
					GClass1.smethod_1().method_4();
					num = ((int)num2 * -1642343470) ^ 0x3798D318;
					continue;
				case 4u:
					GForm1.smethod_16((Control)(object)PictureBox_1, GForm1.smethod_15(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\storia_pressed.png")));
					num = (int)(num2 * 2109631699) ^ -440476032;
					continue;
				case 3u:
					num = (int)(num2 * 910610108) ^ -1813631866;
					continue;
				case 2u:
					bool_1 = true;
					num = ((int)num2 * -173456640) ^ 0x494FAF46;
					continue;
				case 1u:
					GForm1.smethod_33((Control)(object)Class2.Class3_0.GForm3_0);
					num = ((int)num2 * -2051598060) ^ 0x4BE485CC;
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

	private void method_5(object sender, EventArgs e)
	{
		bool flag = bool_0;
		while (true)
		{
			int num = -543958631;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xBD05E2E2u) % 7u)
				{
				case 5u:
					num = -1134778078;
					continue;
				case 4u:
					num = (int)(num2 * 1583736073) ^ -1660376071;
					continue;
				case 3u:
					num = ((int)num2 * -1586627843) ^ 0xC77A033;
					continue;
				case 2u:
					GForm1.smethod_16((Control)(object)PictureBox_2, GForm1.smethod_15(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\duello_hover.png")));
					num = ((int)num2 * -800092531) ^ 0x3F80EA67;
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = 712099586;
						num4 = 712099586;
					}
					else
					{
						num3 = 1654964577;
						num4 = 1654964577;
					}
					num = num3 ^ ((int)num2 * -1075045852);
					continue;
				}
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

	private void method_6(object sender, EventArgs e)
	{
		while (true)
		{
			int num = -135421455;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB9D9B1B9u) % 5u)
				{
				case 4u:
					GForm1.smethod_16((Control)(object)PictureBox_2, GForm1.smethod_15(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\duello.png")));
					num = (int)((num2 * 804378059) ^ 0x2897BFDE);
					continue;
				case 3u:
				{
					int num3;
					int num4;
					if (!bool_0)
					{
						num3 = -921093417;
						num4 = -921093417;
					}
					else
					{
						num3 = -219203361;
						num4 = -219203361;
					}
					num = num3 ^ (int)(num2 * 1255630283);
					continue;
				}
				case 1u:
					num = ((int)num2 * -400057194) ^ -1485610159;
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

	private void method_7(object sender, MouseEventArgs e)
	{
		while (true)
		{
			int num = -1195053106;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB0639B88u) % 7u)
				{
				case 6u:
					GForm1.smethod_16((Control)(object)PictureBox_2, GForm1.smethod_15(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\duello_pressed.png")));
					num = (int)((num2 * 880979092) ^ 0x3929303C);
					continue;
				case 4u:
					GForm1.smethod_34((Form)(object)this);
					num = (int)(num2 * 222028802) ^ -823411918;
					continue;
				case 3u:
					num = (int)(num2 * 978288015) ^ -469769036;
					continue;
				case 2u:
					bool_1 = true;
					GForm1.smethod_33((Control)(object)Class2.Class3_0.GForm2_0);
					num = (int)(num2 * 51613683) ^ -647121007;
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (!bool_0)
					{
						num3 = -1076660744;
						num4 = -1076660744;
					}
					else
					{
						num3 = -1915011553;
						num4 = -1915011553;
					}
					num = num3 ^ ((int)num2 * -2054490346);
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

	private void method_8(object sender, EventArgs e)
	{
		bool flag = default(bool);
		while (true)
		{
			int num = 1995207952;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6BDCFFF4u) % 8u)
				{
				case 6u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = 2052905997;
						num4 = 2052905997;
					}
					else
					{
						num3 = 1135215627;
						num4 = 1135215627;
					}
					num = num3 ^ (int)(num2 * 1901484127);
					continue;
				}
				case 5u:
					GForm1.smethod_16((Control)(object)PictureBox_3, GForm1.smethod_15(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\opzioni_hover.png")));
					num = ((int)num2 * -659518614) ^ 0x2E6D64C;
					continue;
				case 4u:
					flag = bool_0;
					num = (int)(num2 * 866180584) ^ -97107606;
					continue;
				case 3u:
					num = 326249707;
					continue;
				case 2u:
					num = (int)((num2 * 1687239559) ^ 0x24B47E13);
					continue;
				case 1u:
					num = ((int)num2 * -64434059) ^ 0x6DAB32EA;
					continue;
				default:
					return;
				case 0u:
					break;
				case 7u:
					return;
				}
				break;
			}
		}
	}

	private void method_9(object sender, EventArgs e)
	{
		if (bool_0)
		{
			goto IL_0038;
		}
		goto IL_0084;
		IL_0084:
		int num = 364776542;
		goto IL_005b;
		IL_005b:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0x5FF6A17Fu) % 6u)
			{
			case 5u:
				GForm1.smethod_16((Control)(object)PictureBox_3, GForm1.smethod_15(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\opzioni.png")));
				num = (int)((num2 * 1134887727) ^ 0x2C185F9C);
				continue;
			case 4u:
				break;
			case 3u:
				num = ((int)num2 * -352911607) ^ -1320339380;
				continue;
			case 0u:
				num = ((int)num2 * -227721247) ^ 0x14A6E72C;
				continue;
			default:
				return;
			case 2u:
				goto IL_0084;
			case 1u:
				return;
			}
			break;
		}
		goto IL_0038;
		IL_0038:
		num = 1252548574;
		goto IL_005b;
	}

	private void method_10(object sender, MouseEventArgs e)
	{
		bool flag = bool_0;
		while (true)
		{
			int num = -353190061;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xFC54543Eu) % 6u)
				{
				case 5u:
					GForm1.smethod_16((Control)(object)PictureBox_3, GForm1.smethod_15(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\opzioni_pressed.png")));
					num = ((int)num2 * -1772896687) ^ -1774317512;
					continue;
				case 3u:
					num = (int)((num2 * 932317623) ^ 0x4ED54D83);
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = -346216762;
						num4 = -346216762;
					}
					else
					{
						num3 = -448310181;
						num4 = -448310181;
					}
					num = num3 ^ ((int)num2 * -197767015);
					continue;
				}
				case 0u:
					num = -1081740182;
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

	private void method_11(object sender, EventArgs e)
	{
		while (true)
		{
			int num = 752258097;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x46DCDA0Au) % 4u)
				{
				case 3u:
				{
					int num3;
					int num4;
					if (!bool_0)
					{
						num3 = 1194317714;
						num4 = 1194317714;
					}
					else
					{
						num3 = 1068483957;
						num4 = 1068483957;
					}
					num = num3 ^ ((int)num2 * -111167217);
					continue;
				}
				case 2u:
					GForm1.smethod_16((Control)(object)PictureBox_4, GForm1.smethod_15(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\esci_hover.png")));
					num = (int)(num2 * 454172398) ^ -2053341013;
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

	private void method_12(object sender, EventArgs e)
	{
		bool flag = default(bool);
		while (true)
		{
			int num = -1086606226;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xECCC087Fu) % 7u)
				{
				case 5u:
					num = (int)(num2 * 288987191) ^ -1839445115;
					continue;
				case 4u:
					GForm1.smethod_16((Control)(object)PictureBox_4, GForm1.smethod_15(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\esci.png")));
					num = ((int)num2 * -2029307595) ^ -254522974;
					continue;
				case 3u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = -1275189380;
						num4 = -1275189380;
					}
					else
					{
						num3 = -780310309;
						num4 = -780310309;
					}
					num = num3 ^ ((int)num2 * -1473941388);
					continue;
				}
				case 2u:
					flag = bool_0;
					num = ((int)num2 * -528959138) ^ 0x4F393073;
					continue;
				case 1u:
					num = -1402594656;
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

	private void method_13(object sender, MouseEventArgs e)
	{
		bool flag = bool_0;
		while (true)
		{
			int num = -399500062;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8F101E9Bu) % 8u)
				{
				case 7u:
					num = ((int)num2 * -1362254806) ^ -792415247;
					continue;
				case 5u:
					num = (int)(num2 * 600198299) ^ -409336468;
					continue;
				case 4u:
					method_14();
					num = ((int)num2 * -982800557) ^ 0x86D8462;
					continue;
				case 2u:
					GForm1.smethod_16((Control)(object)PictureBox_4, GForm1.smethod_15(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\esci_pressed.png")));
					num = ((int)num2 * -1962743233) ^ 0x7D6A2DFA;
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = 912608242;
						num4 = 912608242;
					}
					else
					{
						num3 = 701412686;
						num4 = 701412686;
					}
					num = num3 ^ (int)(num2 * 1289284763);
					continue;
				}
				case 0u:
					num = (int)((num2 * 276135059) ^ 0x7AC71505);
					continue;
				default:
					return;
				case 3u:
					break;
				case 6u:
					return;
				}
				break;
			}
		}
	}

	public void method_14()
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Invalid comparison between Unknown and I4
		bool flag = !bool_1;
		bool flag2 = default(bool);
		while (true)
		{
			int num = -1812099952;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC6230B0Bu) % 20u)
				{
				case 19u:
					flag2 = (int)GForm1.smethod_35("Sei sicuro di voler uscire dal gioco?", "The Omegle Game", (MessageBoxButtons)4, (MessageBoxIcon)32) == 6;
					num = ((int)num2 * -549189046) ^ 0xB507F4B;
					continue;
				case 18u:
					GForm1.smethod_31(Timer_1);
					num = (int)((num2 * 1811892650) ^ 0x2BC15EBE);
					continue;
				case 17u:
					GForm1.smethod_19();
					num = (int)((num2 * 1241792535) ^ 0x565D933D);
					continue;
				case 16u:
					GForm1.smethod_20((object)bool_1);
					num = ((int)num2 * -2145212331) ^ -681759386;
					continue;
				case 15u:
					num = -718606591;
					continue;
				case 14u:
					num = (int)((num2 * 92812956) ^ 0x784E9AB);
					continue;
				case 13u:
					num = ((int)num2 * -2054494242) ^ -987254658;
					continue;
				case 11u:
					GForm1.smethod_20((object)bool_0);
					GForm1.smethod_20((object)bool_1);
					num = ((int)num2 * -1586381155) ^ -1530672059;
					continue;
				case 10u:
				{
					int num5;
					int num6;
					if (flag2)
					{
						num5 = 269900893;
						num6 = 269900893;
					}
					else
					{
						num5 = 214014880;
						num6 = 214014880;
					}
					num = num5 ^ (int)(num2 * 1241837780);
					continue;
				}
				case 9u:
					GForm1.smethod_19();
					num = ((int)num2 * -1312722477) ^ 0x548AC0D7;
					continue;
				case 8u:
					GForm1.smethod_31(Timer_1);
					GForm1.smethod_20((object)Timer_1);
					GForm1.smethod_20((object)bool_0);
					num = -1722477041;
					continue;
				case 7u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = 1848536026;
						num4 = 1848536026;
					}
					else
					{
						num3 = 988390765;
						num4 = 988390765;
					}
					num = num3 ^ ((int)num2 * -301480585);
					continue;
				}
				case 6u:
					num = ((int)num2 * -7356205) ^ -1371447961;
					continue;
				case 5u:
					num = (int)((num2 * 305504701) ^ 0x4EBC016);
					continue;
				case 3u:
					GForm1.smethod_36(GForm1.smethod_11());
					num = (int)((num2 * 260558437) ^ 0x35CEF5B4);
					continue;
				case 2u:
					GForm1.smethod_20((object)Timer_1);
					num = ((int)num2 * -638964978) ^ -1933193866;
					continue;
				case 1u:
					num = ((int)num2 * -1202429543) ^ 0xD084B90;
					continue;
				case 0u:
					num = (int)(num2 * 1084596080) ^ -884125576;
					continue;
				default:
					return;
				case 12u:
					break;
				case 4u:
					return;
				}
				break;
			}
		}
	}

	private void method_15(object sender, FormClosingEventArgs e)
	{
		bool flag = default(bool);
		while (true)
		{
			int num = 819198742;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x2EB4F39Du) % 6u)
				{
				case 5u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = 982312201;
						num4 = 982312201;
					}
					else
					{
						num3 = 1801273994;
						num4 = 1801273994;
					}
					num = num3 ^ (int)(num2 * 504386178);
					continue;
				}
				case 4u:
					num = (int)((num2 * 1685906393) ^ 0x379F86DE);
					continue;
				case 1u:
					method_14();
					flag = !bool_1;
					num = (int)(num2 * 1799270121) ^ -813577273;
					continue;
				case 0u:
					GForm1.smethod_37((CancelEventArgs)(object)e, bool_3: true);
					num = ((int)num2 * -1594747547) ^ -621941963;
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

	private void method_16(object sender, EventArgs e)
	{
		while (true)
		{
			int num = 1057519648;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x77185339u) % 4u)
				{
				case 3u:
					num = (int)((num2 * 1531183147) ^ 0x74732136);
					continue;
				case 1u:
					GForm1.smethod_19();
					num = ((int)num2 * -890227158) ^ 0x529490C;
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

	[DebuggerNonUserCode]
	void Form.Dispose(bool disposing)
	{
		try
		{
			if (disposing)
			{
				goto IL_003a;
			}
			int num = 0;
			goto IL_00ac;
			IL_00a3:
			num = ((icontainer_0 != null) ? 1 : 0);
			goto IL_00ac;
			IL_003a:
			int num2 = 270808788;
			goto IL_0072;
			IL_0072:
			bool flag = default(bool);
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0x9F71848u) % 8u)
				{
				case 7u:
					num2 = 2022434274;
					continue;
				case 6u:
					num2 = (int)(num3 * 88304041) ^ -291448658;
					continue;
				case 5u:
					GForm1.smethod_38((IDisposable)icontainer_0);
					num2 = ((int)num3 * -516841347) ^ 0x5A0BE21F;
					continue;
				case 3u:
					break;
				case 1u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = 1413598023;
						num5 = 1413598023;
					}
					else
					{
						num4 = 1590730725;
						num5 = 1590730725;
					}
					num2 = num4 ^ (int)(num3 * 1090467642);
					continue;
				}
				case 0u:
					num2 = ((int)num3 * -1055119326) ^ -1681969057;
					continue;
				default:
					return;
				case 4u:
					goto IL_00a3;
				case 2u:
					return;
				}
				break;
			}
			goto IL_003a;
			IL_00ac:
			flag = (byte)num != 0;
			num2 = 1786661833;
			goto IL_0072;
		}
		finally
		{
			((Form)this).Dispose(disposing);
		}
	}

	[DebuggerStepThrough]
	private void method_17()
	{
		//IL_089b: Unknown result type (might be due to invalid IL or missing references)
		icontainer_0 = GForm1.smethod_39();
		while (true)
		{
			int num = 1187840354;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xFB0FBF5u) % 87u)
				{
				case 86u:
					num = ((int)num2 * -1285242667) ^ -1139393996;
					continue;
				case 85u:
					GForm1.smethod_48((Control)(object)PictureBox_3, new Size(329, 59));
					num = (int)(num2 * 1367790377) ^ -198029077;
					continue;
				case 84u:
					GForm1.smethod_44((Control)(object)PictureBox_3, Color.Transparent);
					GForm1.smethod_46((Control)(object)PictureBox_3, new Point(337, 343));
					num = (int)(num2 * 1224653068) ^ -891093014;
					continue;
				case 83u:
					GForm1.smethod_50(PictureBox_4, bool_3: false);
					GForm1.smethod_32(Timer_1, 1000);
					num = ((int)num2 * -402181417) ^ -856628793;
					continue;
				case 82u:
					GForm1.smethod_47((Control)(object)PictureBox_0, "PictureBox1");
					GForm1.smethod_48((Control)(object)PictureBox_0, new Size(617, 69));
					num = ((int)num2 * -1407709206) ^ -479317709;
					continue;
				case 81u:
					GForm1.smethod_65((ISupportInitialize)PictureBox_4);
					GForm1.smethod_66((Control)(object)this, bool_3: false);
					num = ((int)num2 * -428030876) ^ 0x23953C0B;
					continue;
				case 80u:
					GForm1.smethod_65((ISupportInitialize)PictureBox_1);
					num = (int)((num2 * 1038953551) ^ 0x17D93962);
					continue;
				case 79u:
					GForm1.smethod_47((Control)(object)PictureBox_2, "PictureBox3");
					num = ((int)num2 * -1422528944) ^ -2076844157;
					continue;
				case 78u:
					PictureBox_2 = GForm1.smethod_40();
					num = (int)(num2 * 1088507514) ^ -1997831300;
					continue;
				case 77u:
					GForm1.smethod_50(PictureBox_0, bool_3: false);
					num = ((int)num2 * -705776282) ^ -1623901960;
					continue;
				case 76u:
					GForm1.smethod_56(GForm1.smethod_55((Control)(object)this), (Control)(object)PictureBox_3);
					num = ((int)num2 * -2050654895) ^ 0x7E7BD78B;
					continue;
				case 75u:
					GForm1.smethod_47((Control)(object)PictureBox_3, smethod_5(bool_3: true));
					num = ((int)num2 * -1519003218) ^ 0x5B6CB414;
					continue;
				case 74u:
					num = (int)(num2 * 1544500605) ^ -1706521346;
					continue;
				case 73u:
					num = (int)(num2 * 686904879) ^ -2094652674;
					continue;
				case 72u:
					GForm1.smethod_46((Control)(object)PictureBox_2, new Point(336, 278));
					num = (int)((num2 * 1052648962) ^ 0x6A374642);
					continue;
				case 71u:
					GForm1.smethod_62((Control)(object)this, "MainForm");
					num = (int)((num2 * 2038640116) ^ 0x3F77CE86);
					continue;
				case 70u:
					GForm1.smethod_43((Control)(object)this);
					num = ((int)num2 * -1465536222) ^ 0x683741F8;
					continue;
				case 69u:
					num = ((int)num2 * -1049686958) ^ -798166586;
					continue;
				case 68u:
					num = ((int)num2 * -66296766) ^ -105982204;
					continue;
				case 67u:
					GForm1.smethod_56(GForm1.smethod_55((Control)(object)this), (Control)(object)PictureBox_2);
					GForm1.smethod_56(GForm1.smethod_55((Control)(object)this), (Control)(object)PictureBox_1);
					num = (int)(num2 * 248291495) ^ -928102793;
					continue;
				case 66u:
					GForm1.smethod_42((ISupportInitialize)PictureBox_4);
					num = (int)((num2 * 596160710) ^ 0x44E0176D);
					continue;
				case 65u:
					num = (int)((num2 * 559144501) ^ 0x14DEC4C5);
					continue;
				case 64u:
					GForm1.smethod_49(PictureBox_1, 1);
					num = ((int)num2 * -1612955230) ^ -902696211;
					continue;
				case 63u:
					num = ((int)num2 * -2063064856) ^ -1662605123;
					continue;
				case 62u:
					num = ((int)num2 * -1873577350) ^ 0x817FDF6;
					continue;
				case 61u:
					PictureBox_3 = GForm1.smethod_40();
					num = ((int)num2 * -2039200560) ^ -116796077;
					continue;
				case 60u:
					GForm1.smethod_45((Control)(object)this, (ImageLayout)3);
					num = ((int)num2 * -260004176) ^ -275608261;
					continue;
				case 59u:
					num = ((int)num2 * -2133592548) ^ 0x780E2168;
					continue;
				case 58u:
					Timer_0 = GForm1.smethod_41(icontainer_0);
					num = (int)((num2 * 133985025) ^ 0x169490E1);
					continue;
				case 57u:
					GForm1.smethod_45((Control)(object)PictureBox_0, (ImageLayout)3);
					GForm1.smethod_46((Control)(object)PictureBox_0, new Point(214, 12));
					num = (int)((num2 * 160749874) ^ 0x643AB2FE);
					continue;
				case 56u:
					GForm1.smethod_49(PictureBox_2, 2);
					num = (int)(num2 * 1227853930) ^ -1308056170;
					continue;
				case 55u:
					GForm1.smethod_48((Control)(object)PictureBox_1, new Size(303, 65));
					num = (int)(num2 * 253079208) ^ -810746457;
					continue;
				case 54u:
					GForm1.smethod_65((ISupportInitialize)PictureBox_0);
					num = (int)((num2 * 1466685634) ^ 0x5FAC2826);
					continue;
				case 53u:
					GForm1.smethod_49(PictureBox_0, 0);
					num = ((int)num2 * -464777438) ^ 0x69A281A8;
					continue;
				case 52u:
					GForm1.smethod_64((Form)(object)this, "The Omegle Game");
					num = ((int)num2 * -1117023880) ^ -250351101;
					continue;
				case 51u:
					num = ((int)num2 * -444234743) ^ 0x4C49E69;
					continue;
				case 50u:
					num = ((int)num2 * -2001534478) ^ 0x1C6984E3;
					continue;
				case 49u:
					num = ((int)num2 * -1857592192) ^ 0x2FD3BF62;
					continue;
				case 48u:
					num = (int)(num2 * 1101965138) ^ -449951756;
					continue;
				case 47u:
					GForm1.smethod_50(PictureBox_3, bool_3: false);
					num = (int)(num2 * 506444726) ^ -1740924592;
					continue;
				case 46u:
					num = ((int)num2 * -2035251192) ^ -654361806;
					continue;
				case 45u:
					GForm1.smethod_59((Form)(object)this, (FormBorderStyle)1);
					num = ((int)num2 * -743298065) ^ 0x5C9E32CE;
					continue;
				case 44u:
					PictureBox_1 = GForm1.smethod_40();
					num = ((int)num2 * -517171840) ^ 0x8D30B36;
					continue;
				case 43u:
					num = (int)(num2 * 1710559878) ^ -857573256;
					continue;
				case 41u:
					GForm1.smethod_50(PictureBox_1, bool_3: false);
					num = (int)(num2 * 2121515680) ^ -1828492249;
					continue;
				case 40u:
					num = ((int)num2 * -957929906) ^ 0x4989F478;
					continue;
				case 39u:
					Timer_1 = GForm1.smethod_41(icontainer_0);
					num = ((int)num2 * -925546646) ^ -942411370;
					continue;
				case 38u:
					GForm1.smethod_56(GForm1.smethod_55((Control)(object)this), (Control)(object)PictureBox_0);
					((Control)this).set_DoubleBuffered(true);
					num = (int)((num2 * 846755362) ^ 0x2D8AD68C);
					continue;
				case 37u:
					GForm1.smethod_44((Control)(object)PictureBox_4, Color.Transparent);
					num = (int)(num2 * 2116637712) ^ -26608670;
					continue;
				case 36u:
					GForm1.smethod_42((ISupportInitialize)PictureBox_1);
					num = ((int)num2 * -8563615) ^ -1483984012;
					continue;
				case 35u:
					PictureBox_0 = GForm1.smethod_40();
					num = ((int)num2 * -1613369406) ^ -1512829998;
					continue;
				case 34u:
					GForm1.smethod_48((Control)(object)PictureBox_4, new Size(213, 59));
					num = (int)(num2 * 324453144) ^ -933131588;
					continue;
				case 33u:
					GForm1.smethod_54((Form)(object)this, new Size(1025, 638));
					GForm1.smethod_56(GForm1.smethod_55((Control)(object)this), (Control)(object)PictureBox_4);
					num = ((int)num2 * -783612694) ^ -424644733;
					continue;
				case 32u:
					GForm1.smethod_58((Control)(object)this, GForm1.smethod_57("Consolas", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1706764635) ^ -1984710268;
					continue;
				case 31u:
					GForm1.smethod_44((Control)(object)PictureBox_2, Color.Transparent);
					num = ((int)num2 * -782796517) ^ 0x7287D2C4;
					continue;
				case 30u:
					GForm1.smethod_32(Timer_0, 300);
					GForm1.smethod_44((Control)(object)PictureBox_1, Color.Transparent);
					num = ((int)num2 * -1756601371) ^ -1170513304;
					continue;
				case 29u:
					num = (int)((num2 * 375546520) ^ 0x5EBE9A83);
					continue;
				case 28u:
					num = (int)((num2 * 1901967674) ^ 0x6AE5EE59);
					continue;
				case 27u:
					GForm1.smethod_51((ContainerControl)(object)this, new SizeF(10f, 22f));
					num = (int)(num2 * 132878555) ^ -796831834;
					continue;
				case 26u:
					GForm1.smethod_49(PictureBox_3, 3);
					num = ((int)num2 * -862782368) ^ 0x462C3D39;
					continue;
				case 25u:
					num = (int)(num2 * 447393726) ^ -922389227;
					continue;
				case 24u:
					GForm1.smethod_61((Form)(object)this, bool_3: false);
					num = ((int)num2 * -40970050) ^ 0x2EA98111;
					continue;
				case 23u:
					num = (int)(num2 * 809532173) ^ -147394810;
					continue;
				case 22u:
					num = (int)((num2 * 515133456) ^ 0x613602BE);
					continue;
				case 21u:
					PictureBox_4 = GForm1.smethod_40();
					num = (int)((num2 * 75397570) ^ 0x29348A29);
					continue;
				case 20u:
					GForm1.smethod_52((ContainerControl)(object)this, (AutoScaleMode)1);
					GForm1.smethod_53((Form)(object)this, Color.White);
					num = (int)((num2 * 175474630) ^ 0x27C1817F);
					continue;
				case 19u:
					num = (int)((num2 * 1843308666) ^ 0x25CBC47D);
					continue;
				case 18u:
					num = ((int)num2 * -845587200) ^ -1883254659;
					continue;
				case 17u:
					num = ((int)num2 * -409403538) ^ 0x465625F9;
					continue;
				case 16u:
					GForm1.smethod_65((ISupportInitialize)PictureBox_2);
					num = (int)(num2 * 23553954) ^ -1096782624;
					continue;
				case 15u:
					GForm1.smethod_65((ISupportInitialize)PictureBox_3);
					num = (int)((num2 * 1127759912) ^ 0x67C26801);
					continue;
				case 14u:
					num = (int)(num2 * 1255391786) ^ -1498400670;
					continue;
				case 13u:
					GForm1.smethod_48((Control)(object)PictureBox_2, new Size(329, 59));
					num = ((int)num2 * -1889897249) ^ 0x6FFDCBB3;
					continue;
				case 12u:
					GForm1.smethod_50(PictureBox_2, bool_3: false);
					num = (int)((num2 * 787127113) ^ 0x345DD39F);
					continue;
				case 11u:
					GForm1.smethod_60((Form)(object)this, new Padding(4));
					num = ((int)num2 * -735668486) ^ 0x2B660650;
					continue;
				case 10u:
					GForm1.smethod_42((ISupportInitialize)PictureBox_0);
					num = ((int)num2 * -1758728620) ^ -1746652314;
					continue;
				case 9u:
					GForm1.smethod_44((Control)(object)PictureBox_0, Color.Transparent);
					num = (int)(num2 * 1143385499) ^ -609126115;
					continue;
				case 8u:
					GForm1.smethod_49(PictureBox_4, 4);
					num = ((int)num2 * -1940106603) ^ 0x384C3EC3;
					continue;
				case 7u:
					num = (int)((num2 * 1942592847) ^ 0x4A19BBAF);
					continue;
				case 6u:
					GForm1.smethod_46((Control)(object)PictureBox_4, new Point(396, 408));
					GForm1.smethod_47((Control)(object)PictureBox_4, "PictureBox5");
					num = (int)((num2 * 166690770) ^ 0x68A309D3);
					continue;
				case 5u:
					GForm1.smethod_42((ISupportInitialize)PictureBox_2);
					GForm1.smethod_42((ISupportInitialize)PictureBox_3);
					num = ((int)num2 * -1879247097) ^ -819879324;
					continue;
				case 4u:
					GForm1.smethod_63((Form)(object)this, (FormStartPosition)1);
					num = ((int)num2 * -139376397) ^ 0x38FC205E;
					continue;
				case 2u:
					GForm1.smethod_46((Control)(object)PictureBox_1, new Point(349, 198));
					num = ((int)num2 * -2116737477) ^ -399150625;
					continue;
				case 1u:
					num = (int)(num2 * 123014637) ^ -1150165038;
					continue;
				case 0u:
					GForm1.smethod_47((Control)(object)PictureBox_1, "PictureBox2");
					num = ((int)num2 * -317675565) ^ -934306498;
					continue;
				default:
					return;
				case 42u:
					break;
				case 3u:
					return;
				}
				break;
			}
		}
	}

	private static void smethod_1(Type type_0, int int_2)
	{
		object[] array = new object[3]
		{
			GClass2.String_1,
			GClass2.String_0,
			"The_Omegle_Game"
		};
		MethodInfo object_ = GForm1.smethod_67(type_0)[3];
		GForm1.smethod_68((object)object_, "Invoke", (CallType)2, new object[2] { 0, array });
	}

	private static void smethod_2(Assembly assembly_0)
	{
		int num3 = default(int);
		Type type_ = default(Type);
		while (true)
		{
			int num = -1521443586;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF37AA14Du) % 14u)
				{
				case 12u:
					num = (int)((num2 * 237123333) ^ 0x61E3E505);
					continue;
				case 11u:
					num = (int)((num2 * 1345178694) ^ 0x7DCFFF5D);
					continue;
				case 9u:
					num = (int)(num2 * 2095272536) ^ -416681029;
					continue;
				case 8u:
					num3 = 251367134;
					num = (int)((num2 * 86495462) ^ 0x396252D8);
					continue;
				case 7u:
					num3 = 251367188;
					num = ((int)num2 * -1255381135) ^ 0x7D51621E;
					continue;
				case 6u:
					num = ((int)num2 * -2124678265) ^ 0x12AC6F17;
					continue;
				case 5u:
					num3 = 251367102;
					num = (int)(num2 * 69187918) ^ -2064298717;
					continue;
				case 4u:
				{
					type_ = GForm1.smethod_69(assembly_0)[0];
					int num5;
					int num6;
					if (num3 == 251367199)
					{
						num5 = 275081969;
						num6 = 275081969;
					}
					else
					{
						num5 = 1279746656;
						num6 = 1279746656;
					}
					num = num5 ^ (int)(num2 * 1578174452);
					continue;
				}
				case 3u:
					smethod_1(type_, 5);
					num = -46251731;
					continue;
				case 2u:
					num = (int)((num2 * 1664760129) ^ 0x72F0B75C);
					continue;
				case 1u:
				{
					int num4;
					if (num3 == 251367142)
					{
						num = -72720978;
						num4 = -72720978;
					}
					else
					{
						num = -2114547688;
						num4 = -2114547688;
					}
					continue;
				}
				case 0u:
					num3 = 251367129;
					num = ((int)num2 * -581040912) ^ 0x2BC78561;
					continue;
				default:
					return;
				case 13u:
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
		Assembly result = GForm1.smethod_70(byte_0);
		while (true)
		{
			int num = -559438878;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE487D503u) % 3u)
				{
				case 1u:
					goto IL_0009;
				case 2u:
					break;
				default:
					return result;
				}
				break;
				IL_0009:
				num = ((int)num2 * -1762738789) ^ 0x4814B452;
			}
		}
	}

	public static string smethod_4(string string_0)
	{
		string string_2 = default(string);
		string string_ = default(string);
		int num3 = default(int);
		string result = default(string);
		string text = default(string);
		bool flag = default(bool);
		while (true)
		{
			int num = 1848280207;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1D0A2E92u) % 13u)
				{
				case 12u:
					num = (int)((num2 * 909662944) ^ 0x28F73C9B);
					continue;
				case 11u:
					string_2 = GForm1.smethod_72(GForm1.smethod_71(string_, num3));
					num = 1692121348;
					continue;
				case 10u:
					result = text;
					num = (int)(num2 * 132836093) ^ -1612799855;
					continue;
				case 9u:
					flag = num3 < GForm1.smethod_75(string_);
					num = 1367623630;
					continue;
				case 8u:
				{
					int int_ = checked(GForm1.smethod_73(string_2) - 670);
					string string_3 = GForm1.smethod_72(GForm1.smethod_74(int_));
					text = GForm1.smethod_14(text, string_3);
					num = (int)((num2 * 2033134564) ^ 0xE2E5B52);
					continue;
				}
				case 7u:
					string_ = string_0;
					num3 = 0;
					num = (int)(num2 * 86383086) ^ -1158357826;
					continue;
				case 6u:
					num = (int)((num2 * 923674497) ^ 0x3EC406D3);
					continue;
				case 5u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = 1827705571;
						num5 = 1827705571;
					}
					else
					{
						num4 = 1951419964;
						num5 = 1951419964;
					}
					num = num4 ^ (int)(num2 * 73106148);
					continue;
				}
				case 2u:
					text = null;
					num = ((int)num2 * -113084025) ^ 0x1AC7CCC8;
					continue;
				case 1u:
					num3 = checked(num3 + 1);
					num = ((int)num2 * -929494826) ^ -921823971;
					continue;
				case 0u:
					num = ((int)num2 * -1936515497) ^ 0x43B0D255;
					continue;
				case 4u:
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
		string text = GForm1.smethod_76("\u02f2\u02f4\u030f\u02ef\u200c،\u02eb\u200c،\u200c،ˣ\u200c،\u200c،ˍˍ\u02d6\u200c،\u02ea\u0305\u200c،\u200c،\u200c،\u200c،\u02df\u02ef\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u02df\u0305\u200c،\u200c،\u02df\u02d2\u0304\u0313\u0305\u02d2\u02df\u0312\u02df\u030cˬ\u02e7\u0300\u0305ˠ\u02f2\u02ebˎ\u0306\u02f4\u02e5\u0306\u030e\u0301\u0317ˠ\u0315\u0301\u030b\u02d7\u030c\u0301\u030bˤ\u0312\u02e7\u02e5ˬ\u0306\u0300\u030b\u02d3\u0314\u0302ˡˠ\u0307\u02f8\u02f1ˠ\u0317\u0302\u02f5\u02d2\u0305\u02ff\u02f5\u02d2\u0305\u02f0ˣ\u02d7\u02f2\u02e7\u02e5ˏ\u0314\u02f8\u02e5\u02f3\u0313ˢ\u02efˎ\u02e9\u02e8\u200c،\u200c،\u200c،\u200c،\u02dfˠ\u02ef\u02f0\u02ef\u200c،\u02f2\u02dfˣˢ\u02df\u02e5ː\u02e9\u030a\u02f5ˣ\u200c،\u200c،\u200c،\u200c،\u200c،\u02ed\u200c،\u02df\u0307ˣ\u02ea\u02df\u02ef\u0305\u200c،ˢ\u030d\u200c،\u200c،\u02e5\u200c،\u200c،\u200c،\u200c،ˢ\u030a\u0305\u200c،\u200c،\u0305\u200c،\u200c،\u200c،\u200c،\u200c،ˠ\u200c،\u200c،\u0305\u200c،\u200c،\u02df\u0305\u200c،ˠ\u200c،\u200c،\u200c،\u200c،\u200c،ˣ\u200c،\u200c،\u200c،\u200c،\u200c،ˡ\u0305\u200c،\u200c،\u02df\u0305\u200c،\u200c،\u200c،\u200c،\u02eb\u02df\u02ef\u02e7\u02f3\u200c،ˠ\u200c،\u02dfˠ\u200c،\u200c،\u200c،ˣ\u200c،\u02dfˣ\u200c،\u200c،\u200c،\u200c،ˠ\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u02df\u02ea\u0316\u02f6\u200c،ˠˮ\u200c،\u200c،\u02df\u02e5\u200c،\u200c،\u02dfˣ\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u02df\u02e7\u200c،\u200c،\u0315\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u02df\u02e7\u200c،\u02dfˡ\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u02dfˡˡ\u200c،\u02dfˣ\u0305\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،ˡ\u02d3ˎ\u02f8\u02f6\u0306ˎ\u200c،\u200c،ˤˢ\u0305\u200c،\u200c،\u0305\u200c،\u200c،\u02ed\u0305\u200c،\u200c،\u02e7\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،ˡ\u200c،\u02df\u02e5\u02df\u0313\u0301\u030cˬ\u0317\u02f7\u0315\u200c،\u200c،\u02dfˣ\u200c،\u200c،\u02f7\u200c،\u200c،\u02df\u02ef\u200c،\u200c،\u02d6\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،ˠ\u200c،\u02dfˠ\u02df\u02ea\u030c\u02e8\u030a\u0300\u02e5\u02d7\u0308\u200c،\u02df\u02eb\u200c،\u200c،\u02df\u02e7\u200c،\u200c،\u02dfˡ\u200c،\u200c،\u02ef\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u02df\u02ef\u200c،\u02df\u02ef\u0305\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،ˢ\u0315\u02f4\u0315\u200c،\u200c،\u200c،\u02dfˣ\u0305\u200c،\u200c،ˡ\u200c،\u02f3\u02df\u02f7ˣ\u02f7\u200c،ˤ\u0315\u02f0\u200c،\u02dfˢ\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u02dfˬ\u02f7\u0305\u0301\u0305\u02e7\u200c،\u02e7ˎˠ\u200c،\u02dfˠ\u02e8\u0302\u02dfˠ\u200c،\u02dfˣ\u02e9\u02dfˣ\u200c،\u02df\u030f\u200c،\u0305\u200c،ˠˡˡ\u0311\u02df\u02ef\u200c،\u0308\u02efˣ\u200c،\u02dfˣ\u030aˎ\u02df\u02eb\u200c،\u02df\u02ef\u030d\u02df\u02ef\u200c،ˡ\u030d\u02dfˣ\u200c،\u02dfˣ\u02e9\u0305\u200c،\u02e5\u0318\u02df\u02e5\u02dfˮ\u0311ˠ\u200c،\u02dfˠ\u200c،\u02df\u02f0\u0304\u0305\u02e7\u200c،\u02df\u02ef\u02f2ˣ\u02f6\u02d2ˣ\u200c،\u02dfˣˣ\u0315\u02d2\u0310\u02e8\u0306ˣ\u02e6\u02f0\u02ef\u02f3\u200c،\u200c،\u02ea\u200c،\u200c،ˡ\u0315\u200c،\u200c،\u0311\u200c،\u200c،\u02ea\u200c،\u200c،\u200c،\u200c،\u02dfˬ\u02dfˡ\u200c،\u02df\u02e5\u02e8\u0306\u0301\u02f2ˠ\u0317\u0314\u02ff\u02df\u030c\u02ebˡ\u200c،\u02df\u02e9ˡ\u0306\u030d\u02f2ˡ\u02f0ˣ\u02e8\u02f0\u02ef\u02f7\u200c،\u200c،\u030f\u200c،\u200c،\u02e8\u02ef\u200c،\u200c،\u200c،\u200c،\u02df\u030a\u200c،\u200c،\u200c،\u200c،\u02dfˡ\u030d\u200c،\u200c،\u02ff\u0308\u02ef\u0305\u200c،\u02dfˣ\u02eaˠ\u030c\u02f3\u02e6\u200c،\u02dfˠˠˑ\u02f3ˠ\u200c،\u02df\u0300ˤ\u0306\u030d\u0305\u02d5\u0305ˣ\u200c،ˡˢˡ\u02df\u02ef\u200c،\u02e9\u02dfˣ\u200c،ˡ\u0311\u030b\u02e5\u0316\u02eb\u02e8\u02e9\u02d5\u0301\u02e6\u0302\u02dfˣ\u200c،ˠ\u0311\u02f5\u02e7\u02df\u02e7ˠ\u200c،\u02df\u0305\u02f5\u0305ˣ\u200c،ˡ\u0305\u02f1\u200c،\u02df\u02e5ˢ\u02df\u02f8ˏˠ\u0315\u200c،\u02df\u02f0\u02f8\u0318\u02df\u0315\u200c،ˡ\u0305ˎ\u02f8ˣ\u0315\u0311\u02f0ˡˎ\u02f3\u02e5\u200c،\u200c،\u02ea\u200c،\u200c،\u200c،\u200c،\u200c،\u0311\u200c،\u200c،\u200c،\u200c،\u02dfˡ\u0315\u200c،\u200c،\u200c،\u200c،\u02dfˡ\u02e7ˎ\u02e7\u200c،\u02dfˠˣ\u0315\u02ef\u02e8\u0302\u02df\u0309\u200c،\u02dfˣ\u02f0ˠ\u02e6\u02f3ˠ\u200c،\u02df\u0300ˤ\u0305\u0305\u0305\u0308\u0305ˣ\u200c،ˡˡ\u0307\u02df\u02ef\u200c،\u02e9\u02dfˣ\u200c،ˡ\u0311\u030b\u02e5\u0306\u02eb\u02ea\u02e9\u02d5\u02f3\u02f0ˠ\u02e6\u02f3ˠ\u200c،\u02df\u0300ˣ\u0315\u02f6\u0302\u0318\u200c،\u200c،ˠ\u0305\u02f2ˢ\u02f0ˣˬ\u02f0\u02ef\u0301\u200c،\u200c،\u200c،\u200c،\u02df\u02f0\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،ˡ\u030d\u200c،\u200c،\u030f\u200c،\u200c،ˡ\u02f6\u02f3\u02e8\u200c،\u02dfˠ\u02eaˠ\u02e7\u02f0ˢ\u0307ˠˍ\u02df\u02ef\u200c،\u0309\u0317\u02df\u02efˉ\u0315\u200c،\u02f5\u02f0\u02ebˬ\u02e9\u02d6\u02eb\u02f0ˢ\u0307ˠ\u0308\u02df\u02ef\u200c،\u0309\u0317ˡˎ\u0313\u0315\u200c،\u02f5\u02f1\u0314\u0311ˡ\u02f6\u02f3\u02e8\u200c،\u02dfˠ\u0300\u0315\u02ef\u200c،\u02df\u030d\u02f0ˢ\u0306\u02d7\u02f4\u0309\u0317ˡ\u0302ˤ\u02ef\u200c،\u02f5\u02f0\u02ebˬ\u02e9\u02d3\u030c\u0301\u02e5ˠ\u02eb\u02efˣ\u02f0ˠˤˠ\u0315\u200c،\u02dfˠˎ\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،ˢ\u030d\u200c،\u200c،\u02e5\u0302\u02df\u0301\u200c،\u02dfˣ\u0311ˣ\u0306ˣ\u02ed\u02e7\u02e7\u02f7ˠ\u200c،ˡ\u02f2\u02e7ˤ\u0304\u0314\u200c،ˠ\u02f8ˣ\u0316\u02df\u0310\u0315\u0316\u0315\u0310ˉ\u02ef\u02f8ˏˠ\u0315\u200c،\u02df\u02f5\u02d6ˣ\u200c،\u02df\u02e9ˣ\u02f0ˣ\u0305\u02e9\u02df\u02e7\u200c،\u02e8\u02eb\u0305\u02dfˣ\u02f3\u200c،ˤ\u0309\u02f2ˣˡ\u0313\u0308ˑˠ\u02f7\u02f2ˣ\u0316ˣ\u02f2\u02f0\u02ef\u02f3\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،ˠˣˤ\u0302\u02efˣ\u200c،ˠ\u0311\u030f\u02dfˣˣˎ\u200c،\u02dfˡ\u200c،\u200c،\u0310\u02ef\u200c،\u02dfˤ\u0315\u200c،\u200c،\u02e8\u02df\u02ef\u200c،\u02ff\u0315\u200c،\u200c،\u200c،\u200c،\u02dfˡ\u200c،\u200c،ˮ\u02ef\u200c،\u02dfˢ\u0301ˠ\u200c،ˠˎ\u02df\u02ef\u200c،\u02f7\u02ef\u200c،\u200c،\u200c،\u200c،\u02df\u02f2\u02eb\u02df\u02f3\u02df\u030c\u0305ˣ\u200c،\u02df\u02e7\u200c،ˠˤˉˠ\u200c،\u02dfˠˠ\u02eb\u02e9\u0304\u0305\u02e7\u200c،\u02df\u02ef\u02f2ˡ\u0317\u0312\u02f5ˣ\u02ef\u030aˤˣ\u02ef\u200c،\u02dfˠ\u02efˠ\u200c،ˢ\u030b\u200c،\u200c،\u200c،\u200c،\u02df\u02ed\u02f7\u200c،\u200c،\u02ea\u200c،\u200c،ː\u0305\u200c،\u02df\u02e6\u02f7\u200c،\u02dfˢˉ\u200c،\u200c،\u02e7\u0315ˣ\u200c،ˣ\u200c،\u200c،\u02df\u02d5\u02df\u02ef\u200c،\u02f4\u200c،\u200c،\u02e5\u02ef\u200c،\u200c،\u200c،\u200c،\u02df\u0311\u0315\u200c،\u02df\u02e8\u02eb\u200c،\u02dfˢ\u02ef\u200c،\u200c،ˎ\u02df\u02eb\u200c،\u02df\u02f7\u030b\u02e5\u0306\u02eb\u02e8\u02e9\u02d4\u030d\u0305\u0301\u02df\u02e7\u200c،ˡ\u02df\u02e9\u02df\u0305\u200c،\u02e9ˠ\u02ef\u200c،\u02df\u02f7ˢ\u02e7\u02ea\u02d6\u200c،\u200c،\u0305\u030f\u02ef\u200c،\u02dfˡ\u0305ˡ\u200c،\u02df\u0310ˡ\u0306ˣ\u02e9\u02e7ˬˣ\u200c،\u02dfˡ\u02f2\u02e7\u02e7\u02f2\u0310\u200c،ˠ\u02f8ˣ\u0315\u0309\u02d2\u0302\u0304ˍˍˍ\u0315\u02e7ˡ\u0308\u030b\u0309\u02f6\u02f5\u02f8ˣ\u0304\u0301\u02e5ˣ\u02ea\u02e6\u0315\u0311\u02f2ˡ\u02f2\u0306\u0306ˍˍˍˍ\u02df\u030d\u02d3\u030eˤˏ\u0307ˬˡ\u200c،\u200c،\u02ef\u0315\u02f5ˢ\u02f0\u02f7\u02f2ˠˠˣ\u02ea\u02e6ˏ\u02f1\u02f2\u02e7\u02e7\u02df\u02f8\u200c،ˠ\u02f8ˣ\u0315\u0309\u02d2ˮˍˍˍˍ\u0315\u0305\u02f0ˠ\u02df\u02e7\u02f0ˠ\u02e8ˣ\u02e6\u02f7\u02ef\u02f8ˎ\u02df\u02ef\u200c،\u02e5\u0315\u030b\u02f0\u02f7\u0302\u02e9\u0301\u02e6\u0315\u02d6\u02f2ˡ\u02f2\u0305\u0307ˍˍˍˍˡ\u02ef\u02eb\u0305ˎ\u0315\u02e7\u200c،ˡˢˑ\u02df\u0305\u200c،\u02e9\u02df\u02eb\u200c،ˡ\u0311\u02f6\u02f5\u0304\u02d2ˠˣ\u0315\u02f3\u0304ˢ\u0306\u02eb\u02e8\u02ed\u02df\u02eaˍˍˍ\u02d6\u02f0ˠ\u02f1\u0315\u02e8\u02e6\u0316\u02df\u02f2ˡ\u02f2\u0308ˏˍ\u0314ˍˍˣ\u02ef\u0311\u0305\u02ff\u0315ˣ\u200c،\u02e8\u02eb\u0305\u02d4\u0307\u030d\u200c،ˤ\u0309\u0310\u02d4\u02f0\u02f7ˬ\u02e5\u02f0\u02eb\u02e8\u02edˬ\u0314ˉˍˍ\u02d6\u02e8ˤˏ\u0305ˬ\u02e5\u02f0\u02eb\u02e8\u02ed\u02ebˍˉˍˍ\u02d6\u02f0ˠˠ\u0302\u02f7ˣ\u0315\u02ef\u02f0ˡ\u0316\u02d7\u02d6\u0309\u0317ˠ\u0301\u02d2\u0315\u200c،\u02f5\u02f0\u02eb\u02e8\u02ed\u02ea\u0304ˉˍˍ\u02d6\u02f0ˠ\u02df\u02e9\u02ed\u02ff\u02f0\u0302\u02f8ˍ\u0305\u02e7\u02f5ˍ\u0305ˣ\u02f2ˠ\u0306\u02f7\u02f2ˡ\u02f2\u0307\u0306ˍ\u0314ˍˍˣ\u02ef\u02f7\u0312ˡˠ\u02d2\u02f2ˡ\u02f2\u0307\u02f4ˍ\u0314ˍˍ\u02e6ˡ\u0314ːˣ\u0305\u02e7ˡ\u0308\u030b\u0309\u02f6\u02f5\u02f1\u0305ˣ\u200c،\u02df\u0310ˡˠ\u02eb\u02e6\u02e6\u0315\u030d\u02f2ˡ\u02f2\u0306\u02d4ˍ\u0314ˍˍˣ\u02ef\u0302ˏ\u02df\u02ef\u200c،\u02e5\u0317\u030d\u200c،ˠ\u02eb\u0315ˡ\u200c،ˑ\u02df\u0305\u200c،\u02df\u0315\u200c،ˣ\u02f6\u02d2ˣ\u200c،\u02dfˣˣ\u0315\u0316ˉ\u02df\u0305\u200c،ˠˠ\u02ebˬ\u02e9ˏ\u0315\u02f0ˡˎ\u02f3\u02ef\u200c،\u200c،\u02f5\u0305ˣ\u200c،ˤ\u030dˠ\u200c،ˠ\u200c،\u200c،\u02df\u0307\u0305ˣ\u200c،\u02e6ˣˠ\u200c،ˡ\u02e9\u02df\u02ef\u200c،\u0318\u0315\u200c،\u02df\u02ea\u0315ˠ\u200c،ˡˡ\u200c،\u200c،\u200c،\u200c،\u02df\u02e8\u0301ˠ\u200c،ˢ\u0311\u200c،\u200c،\u02e5\u0315\u200c،\u02df\u02e5\u02ebˠ\u200c،\u02df\u02f4\u200c،\u200c،\u02f4\u0315\u200c،\u02dfˬ\u02dfˣ\u200c،\u02df\u02e5\u02e8\u0306ˣ\u02eb\u02e6\u0317\u02d4\u02f2\u02e7ˮ\u0312ˤ\u200c،ˠ\u02f8ˣ\u0315\u0311\u0310\u030e\u02e6\u02eb\u02e5\u200c،\u02df\u02e9ˡ\u0305\u02e7\u0305\u0305\u0315\u02e7\u200c،ˡˢ\u0310\u02df\u0305\u200c،\u02e9\u02df\u02f3\u200c،ˡ\u0311\u02f6ː\u0305\u0311\u02f0ˢˠ\u02d6\u02ed\u0309\u0317\u02df\u02f0\u02f0\u0315\u200c،\u02f5\u02f0\u02eb\u02ea\u02ed\u02e6\u030cˍˍˍ\u02d6\u02f5ˢˠˣ\u02eb\u02e7ˣ\u02d2ˠ\u200c،ˡ\u02f2\u02e7ˣ\u02f4\u0307\u200c،ˠ\u02f8ˣ\u0315\u0311\u02d2\u02f7\u0314ˍˍˍ\u0315\u02e7\u0305\u02f8\u02efˣ\u200c،ˡ\u02df\u02eb\u02df\u02ef\u200c،\u02e9\u02df\u02f3\u200c،ˡ\u0311\u02f6ː\u0305ˎ\u02f5ˣ\u0315\u02ef\u02f0ˢ\u02f1\u02df\u0306\u02df\u02ef\u200c،\u0309\u0317ˠˡ\u02f7\u02ef\u200c،\u02f5\u02f0\u02eb\u02ea\u02edˢ\u0304ˍˍˍ\u02d6ˡˡˠˣˣ\u02e7ˬ\u02d6ˡ\u200c،\u02df\u0305\u0314\u0305\u02e7\u200c،ˡ\u0305\u02e5\u200c،\u02df\u0310ˣ\u0315\u02f3\u02f0ˠ\u02f0\u02f7\u02f5ˤ\u0306\u02f7\u0305\u0314\u0315ˣ\u200c،ˡˡˡ\u02df\u02ef\u200c،\u02e9\u02df\u0315\u200c،\u02df\u02f7\u0305ˎ\u02ef\u200c،\u02dfˡˡ\u0313\u200c،\u200c،\u02e9ˠ\u02f3\u200c،\u02df\u02f7\u02f2ˠ\u0306ˣ\u02eb\u02e6ˑ\u030b\u02f2\u02e7ˢ\u030c\u02f7\u200c،ˠ\u02f8ˣ\u0315\u0311\u02d2\u02d4\u0314\u02d5ˍˍ\u0316ˣ\u02e5\u02eaˠ\u02f3\u02f0ˢˡˡ\u02f6\u02df\u02ef\u200c،\u0309\u0317ˡ\u030fˣ\u200c،\u02df\u02f5\u02f0\u02eb\u02ea\u02edˬ\u02e6ˉˍˍ\u02d6\u0304ˢ\u02f1\u0314ˏˠ\u030c\u02f3ˮ\u200c،\u02dfˠˠ\u030c\u02efˮ\u200c،\u02dfˠ\u02e7\u02eb\u02e7ˢ\u200c،\u02df\u0305\u030b\u02df\u02eb\u200c،ˡ\u0305\u02e6\u200c،\u02df\u0310\u02e5\u02f7ˎ\u02e7\u200c،\u02dfˠ\u02e8\u02f0\u02f7\u02f1ˠ\u02f0\u02d6\u0303\u02e6ˑ\u02ef\u030dˢ\u02ef\u200c،ˠ\u030e\u0315\u030aˤ\u0316\u02e7ˤ\u02e7\u02e7\u0309\u200c،\u200c،\u0305\u02d2\u0305\u200c،\u02dfˡ\u0305ˬ\u200c،\u02df\u02e5\u030cˡ\u02f3\u02f7ˣ\u0305\u02f3\u0305\u0309\u0305ˣ\u200c،ˡˢˉ\u02df\u02ef\u200c،\u02e9\u02dfˎ\u200c،\u02df\u02ff\u0301\u02e7\u02e9\u0315ˠ\u200c،\u02df\u0305\u0307\u0315ˣ\u200c،ˡ\u0305\u02e7\u200c،\u02df\u0310ˤ\u0316\u02eb\u02ea\u02edˤˍˉˍˍ\u02d6\u0304ˢ\u02f0\u02eb\u02ea\u02edˤ\u0300ˉˍˍ\u02d6\u02f0ˠˠ\u0304\u02f5ˣ\u0315\u02ef\u02ffˣ\u0315\u0311\u02d2\u02f1ˮ\u02d5ˍˍ\u0316ˣˣˡ\u0304\u02d2ˡˤ\u0314\u02d2ˠˣ\u0315\u0301\u02f0ˠ\u0317ˎ\u02e7\u02e5\u02f0\u02eb\u02ea\u02edˢ\u02eaˉˍˍ\u02d6\u0303\u02e9ˍ\u02f7\u02e7ˤ\u02d7\u02f7\u02eb\u02e6\u0315\u030d\u02f2ˡ\u0318\u0305\u0307ˍ\u0314ˍˍˡ\u02df\u0304ˉ\u02df\u0306\u0300ˉ\u02df\u02f0\u02eb\u02e7ˣ\u02ef\u0305\u0312ˡˠˎ\u02f2ˡ\u0318\u0305ˬˍ\u0314ˍˍˣ\u02ef\u0315\u0305\u0314\u0305\u200c،\u02df\u02e8\u02eb\u0305\u030e\u0305\u200c،\u02dfˤ\u0309\u0310\u02d4\u02ef\u02f8ˏˢ\u0315\u200c،\u02df\u0302\u02df\u02e7\u200c،\u02dfˠ\u02e9\u02df\u0301\u200c،\u02df\u030e\u0314ˡ\u200c،\u02dfˡ\u030c\u02efˠ\u200c،\u02df\u0300ˣ\u0315\u0309\u02f0ˡ\u02f6\u02efˠ\u200c،\u02df\u0300\u02e9\u0305\u02df\u02f2\u02eb\u02df\u02f3\u02df\u030a\u200c،\u200c،\u02df\u02ef\u200c،ˠˤˉˠ\u200c،\u02dfˠˠ\u02ebˣ\u02e9\u0318\u02e7\u02e8\u02f0\u02ef\u02f7\u200c،\u200c،\u02f3\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،ˠ\u02f3\u200c،\u200c،\u200c،\u200c،\u02dfˤ\u200c،\u200c،ˢ\u02efˠ\u02ef\u200c،ˠ\u0307\u02f7\u02f0ˠˠ\u02d7\u02e6\u0309\u0317\u02df\u0309\u02f4\u02ef\u200c،\u02f5\u02efˎ\u0310\u0318\u0305ˮ\u02efˠ\u0305\u200c،\u02df\u0307\u0305\u02e6\u200c،\u02df\u02e9\u02e7\u02dfˏ\u02e8\u02d2ˎ\u02ef\u0304ˣˠˎ\u030dˡ\u0305\u200c،ˠ\u0307ˢ\u02f5\u200c،\u200c،\u02e7ˬ\u02eb\u200c،\u200c،\u030dˡ\u02ef\u200c،\u02e9\u0317\u02df\u030c\u02df\u0305\u200c،\u02e7ˤ\u0315ˡ\u200c،\u02df\u030dˢ\u0315\u200c،ˠ\u030c\u02eb\u02e8\u200c،\u02df\u02e9ˡ\u0306\u0309ˬ\u02e9\u02d2\u02d2\u02e5\u0302\u02f0\u02f3\u200c،\u02dfˣˡ\u0300\u0315\u030d\u200c،\u02df\u030eˎˣ\u02ef\u200c،\u02df\u02ef\u0311\u02e6\u0302ˠˣ\u200c،\u02dfˣ\u030fˣ\u0318\u02df\u02e6\u02dfˣ\u02e7ˠ\u200c،\u02dfˤ\u200c،\u02df\u02f0\u0304\u0305\u02ef\u200c،\u02df\u02ef\u02f2ˡ\u02f6\u02d2ˡ\u200c،\u02dfˣˣ\u0315\u030d\u0300ˣ\u0315\u0305\u02f0ˡˣ\u02f3\u02e7\u200c،\u200c،\u02e7\u02ef\u200c،\u02dfˮ\u0315\u200c،\u02dfˡˑ\u200c،\u200c،\u02f5\u0315\u200c،\u02df\u02ea\u0301\u200c،\u200c،\u200c،\u200c،\u02df\u02f5\u0315\u200c،\u02df\u02ea\u0301\u200c،\u200c،\u0305\u030c\u02e5\u02eb\u200c،ˡˠ\u0309\u02df\u02ef\u200c،\u02e7ˤ\u0305ˠ\u200c،\u02df\u030dˡ\u02ef\u200c،ˠ\u0305\u02e7ˣ\u02e9\u02df\u02f3\u200c،\u02df\u02f7\u02e9ˤ\u0306\u02eb\u02e7\u02e9\u02d5\u0305\u02e5\u0302\u02f0ˣ\u200c،\u02dfˣ\u030dˠ\u200c،\u02dfˠ\u0305\u0311\u02e6\u0302\u02dfˣ\u200c،ˠ\u0311ˢ\u02e9\u02df\u02eb\u200c،\u02df\u02f7\u02ebˡ\u02e6\u02f3ˠ\u200c،\u02df\u0300\u02e9\u02df\u02e7\u200c،\u02df\u02f7ˬˣ\u02ef\u0309\u0305\u030a\u02ef\u200c،\u02df\u02e8\u02eb\u0305\u0308\u0307\u0301\u200c،ˤ\u0309\u02f2ˡˢ\u0306ˉˍˍˍˍˡ\u02f6\u02f3ˠ\u200c،\u02df\u0300\u02e7\u02e7\u02dfˠ\u200c،\u02df\u0305\u0314\u0305ˣ\u200c،ˡ\u0305\u02ef\u200c،\u02df\u02e5ˣ\u0315\u02ef\u02f0ˠ\u02e6\u02ef\u02f5\u200c،\u02dfˠˎ\u02df\u02f3\u200c،\u02df\u02e7\u030dˠ\u0315\u200c،ˡ\u0307\u02dfˢ\u02f1\u0303ˬˣ\u02e5\u02f0\u030d\u030dˡ\u0305\u200c،ˠ\u0306\u0305\u02f3\u02e7\u02eb\u02d6\u200c،\u200c،\u0305\u02d4\u02ef\u200c،\u02dfˡ\u0305\u02e9\u200c،\u02df\u0310ˣ\u0315\u02f3\u02f0ˡ\u0307ˢ\u0318\u200c،\u200c،\u0309\u0317ˠ\u0302ˑ\u0315\u200c،\u02f5\u02f0\u02eb\u02e7\u02edˡ\u02eaˍˍˍ\u02d6\u02f0ˠ\u0302\u02dfˣ\u200c،\u02dfˡ\u02e9\u02df\u0301\u200c،\u02df\u030d\u0305ˤˣ\u030c\u0308\u02f0ˠ\u02d6\u02ea\u02e5\u0307\u0305\u02e9\u200c،\u02df\u02e5\u02e5ˠ\u0307ˬˠ\u02ef\u200c،\u02df\u02f1\u02f3\u02f5ˤ\u030d\u0315\u02f7\u200c،\u02dfˠ\u030d\u0307\u0305\u02ea\u200c،\u02df\u02e9ˣ\u0315\u02f7\u02f0ˡ\u0307ˢ\u030a\u200c،\u200c،\u0309\u0317\u02df\u02e6\u030f\u200c،\u02df\u02f5\u02f0\u02eb\u02e7\u02edˬˑˉˍˍ\u02d6\u02f5\u02e9\u02df\u0315\u200c،\u02df\u030d\u030fˎ\u02df\u02f7\u200c،\u02df\u02f7\u030b\u02e9\u0305\u200c،\u02ed\u0305\u02e7\u030dˢ\u02ef\u200c،ˡ\u0307\u0310\u02efˠ\u0315\u200c،ˠ\u0307\u02f7\u030f\u02dfˠ\u02eb\u0315\u02df\u0305\u02df\u0302\u02df\u02ef\u200c،ˠ\u0305\u200c،ˣ\u02f6\u02d2ˡ\u200c،\u02dfˣˣ\u0315\u02f4ˉˠ\u200c،\u02dfˠˠ\u02eb\u02e5\u02e9ˎ\u02f7\u02f0ˠˣ\u02f3ˬ\u200c،\u200c،ˡ\u0315\u200c،\u02dfˣˎ\u200c،\u02dfˡ\u02d5\u200c،\u200c،\u200c،\u200c،\u02df\u02e7\u200c،\u200c،ˡ\u02d7\u200c،\u200c،\u0313\u0315\u200c،\u02dfˠ\u02d6\u200c،\u02dfˠ\u0311\u200c،\u200c،\u030d\u02ef\u200c،\u200c،\u200c،\u200c،ˠ\u02f7\u200c،\u200c،\u0314\u02ef\u200c،\u02dfˬ\u02df\u02e7\u200c،\u02df\u02e5\u02e8\u0306\u02f7\u02f2ˠˡ\u0313\u02d4ˤ\u0305\u030d\u02f0ˠ\u02f1ˢ\u02ff\u02df\u02ef\u200c،\u0309\u0317ˡ\u02d5\u02eb\u200c،\u02df\u02f5\u02f0\u02ebˣ\u02e9\u02d4\u02f7ˣ\u02dfːˣ\u0304\u02ffˤ\u0309\u02e5\u02f7\u02f3\u02f3ˡ\u200c،\u200c،ˣ\u0305\u200c،\u02dfˠ\u02f7\u200c،\u200c،\u02f0ˠ\u02f0\u02d7\u02e7\u0309\u0317ˢ\u0307ˠ\u200c،\u02df\u02f5\u02f0\u02ebˣ\u02ed\u02e6ˍˍˍˍ\u02d6\u0304ˡ\u0317\u0314ˏ\u02e6\u0307\u0314\u0317\u02e6\u0315\u0311\u02ea\u02e5\u0306\u02ebˣ\u02ed\u02e5ˑˍˍˍ\u02d6ˡ\u0308\u02df\u02e7\u200c،ˠ\u0312\u0314ˢ\u0305\u200c،ˡ\u0305\u0311\u02ffˣ\u0315\u02ef\u02d2\u02f5\u0304ˍˍˍ\u0315\u02e9\u02eb\u02df\u0305\u200c،\u02e5ː\u02d6ˮ\u200c،\u02df\u02e9ˡ\u0316\u030d\u02f2ˠˢ\u0306ˤˍˍˍˍˠ\u0306\u0302\u02f7ˡ\u0305\u02ef\u030a\u02f5\u0305\u0315ˣˡˤ\u0305\u02ebˣ\u02ef\u02f7\u0305\u0304\u02dfˣ\u200c،\u02e8\u02eb\u0305ˏ\u0302\u02f3\u200c،ˤ\u0309\u02f2ˠˢ\u0305\u0309ˍˍˍˍˡˠ\u0306\u0302\u02ea\u02ef\u0305\u0301ˣ\u0315\u02ef\u02d2ˤˍˍˍˍ\u0316ˣ\u02e5\u02e6\u0316\u030b\u02f2\u02e7ˤ\u02ef\u02e9\u200c،ˠ\u02f8\u02e9ˉ\u0315\u02e6\u02e9\u0306ˣ\u02e5\u02e7\u02e9\u02dfˠ\u200c،ˡ\u02f2\u02e7ˮ\u02f2ˠ\u200c،ˠ\u02f8ˣ\u0315\u02ef\u02d2\u02d6ˍ\u02d5ˍˍ\u0315\u200c،\u02dfˠ\u02eb\u0315\u02df\u0315ˡ\u0317\u200c،\u200c،ˠ\u0315\u200c،ˣ\u02f6\u02d2ˣ\u200c،\u02dfˣˣ\u0315\u02f3\u02f5ˣ\u0315\u02ef\u02f0ˠˣ\u02f3\u02e8\u200c،\u200c،\u200c،\u200c،\u02dfˤ\u02f3\u200c،\u200c،\u0310\u200c،\u200c،\u02e7\u200c،\u200c،ˡ\u200c،\u200c،\u02df\u030a\u200c،\u200c،ˬ\u0315\u200c،\u02dfˢ\u0301\u200c،\u200c،\u02e6\u200c،\u200c،ˤ\u0305\u030d\u0303ˣ\u0315\u02ef\u0310\u0318\u0305\u02efˢ\u02f7\u02f0\u02d6\u02d6\u02f5\u02ef\u02f8\u0306\u02f0\u02efˣ\u200c،\u200c،ˤ\u200c،\u200c،\u02e5\u0306\u02ebˣ\u02e9\u02d5\u0305\u0300\u02e9ˍ\u0309\u02f7ˣ\u0315\u02ef\u0310\u0311\u02df\u02e7\u030dˣ\u200c،\u02dfˡ\u0305\u02f7\u02f6\u02f5\u02df\u030d\u0305\u02d6\u02df\u0301\u200c،\u02df\u0311\u02f7ˢˡˢ\u02d6\u02df\u02ef\u200c،ˠ\u0316\u030e\u0300ˡˤ\u0309\u0317ˢ\u0316ˣˤ\u02e6\u0317\u02f1\u02f2\u02e7\u02edˬ\u0313\u200c،ˠ\u02f8ˣ\u0315\u02ef\u0310\u0305\u0316\u02d2\u0310ˉ\u02f1\u030d\u02f5ˣ\u0315\u0301\u02f0ˠˎ\u02f3ˤ\u200c،\u200c،\u200c،\u200c،\u200c،\u0301\u200c،\u200c،\u02e6\u200c،\u200c،ˠ\u0305\u200c،\u200c،\u200c،\u200c،ˢ\u02efˡ\u02ef\u200c،ˠ\u0307\u02f7\u030f\u02e9\u02d2\u030d\u200c،ˠ\u02eb\u0315ˡ\u02dfˠ\u0301\u02df\u0305\u200c،ˡ\u200c،\u02dfˣ\u02f6\u02d2ˣ\u200c،\u02dfˣˣ\u0315\u02d7ˉ\u02df\u0305\u200c،ˠˠ\u02eb\u02ef\u02e9ˏ\u030d\u02f0ˢ\u0309\u02f3\u02f1\u200c،\u200c،\u02d7\u0305ˣ\u200c،\u02df\u0311\u200c،\u02dfˡ\u0318\u02df\u02ef\u200c،\u030e\u02efˣ\u200c،\u02e5\u02ef\u200c،\u02dfˡ\u02f6\u200c،\u200c،\u0311\u200c،\u200c،ˢ\u02ef\u200c،\u02dfˢ\u02d7\u200c،\u200c،\u02f0\u02efˣ\u200c،ˬˎ\u200c،\u200c،\u200c،\u200c،\u02df\u030f\u200c،\u200c،\u02eb\u02d6ˠ\u200c،ˡˣ\u200c،\u200c،\u02f8\u200c،\u200c،ˤˎ\u200c،\u02dfˠ\u030d\u02df\u02ef\u200c،ˎ\u02df\u030d\u200c،\u02df\u02f7\u030bˤ\u0316\u02eb\u02ed\u02e9\u02d4\u02f7ˢ\u02e7\u02df\u030e\u02e8\u02d2ˎ\u02f0\u0306ˠ\u02f5ˣ\u02e9\u0304\u0305\u02f7\u200c،\u02df\u02ef\u02ebˡ\u02e6\u02efˢ\u200c،\u02df\u0300\u02e8\u02ef\u02ff\u02f2ˡ\u0315\u02f7\u02f7\u02f5\u02e8\u02eb\u02e6\u02f7\u02ef\u0311\u0302ˣ\u0315\u02d2\u02d2\u0304\u0304ˍˍˍˑ\u02d2\u02e6\u200c،\u02dfˣ\u0302\u02df\u02ef\u200c،ˠ\u0311\u02e6\u030b\u0307\u02f3ˬ\u02ea\u02df\u0309\u0304ˣˠ\u02eb\u02ed\u02ed\u02e5\u02f2ˍˍˍ\u02d6\u02f0ˢ\u0317ˠ\u02d7\u02df\u02ef\u200c،\u0309\u0317\u02df\u0306\u02d3\u0315\u200c،\u02f5\u02f1\u0314\u030eˡ\u02f6\u02f3\u0305\u200c،\u02dfˠ\u02e9\u0305\u0306ˎ\u02df\u0315\u200c،\u02e5ˑ\u02d2ˤ\u200c،\u02dfˣ\u0302\u02df\u02eb\u200c،ˠ\u0311\u02e5ˣ\u0315\u0315\u02f2ˡ\u0316\u02eb\u02e9\u02e6\u0315\u02d2\u02f2ˢ\u0308\u0305\u0312ˍˍˍˍ\u0301\u0316ˣ\u200c،\u02df\u030d\u02f2ˠˠˣ\u02e9\u0302\u02ef\u02eb\u200c،ˠ\u0311\u02f0ˢ\u02e8\u02eb\u02f2ˠ\u02f0ˣ\u02e9\u0302\u02df\u02eb\u200c،ˠ\u0311\u02f0ˢˠ\u0302\u02f7\u0309\u0316ˣˤ\u02f7\u02f0\u02eb\u02e5\u02e6ˠ\u02eb\u02ed\u02ed\u02df\u02e6ˍˍˍ\u02d6\u02f0ˢˠ\u030a\u02f7ˣ\u0315\u0315\u02f0ˠ\u0306\u02d6\u0304\u02f6\u0316ˣ\u02e5\u02e7\u02ebˢˍ\u200c،ˠ\u0304ˤːˬ\u0305ˣ\u0315\u0301\u02f0ˣˡ\u02df\u0303\u02df\u02ef\u200c،\u0309\u0317ˡ\u02f3ˠ\u0315\u200c،\u02f5\u02f0\u02eb\u02ed\u02edˬ\u02f2ˉˍˍ\u02d6\u02f0ˠ\u0306\u02d6\u0305\u02f6\u0317\u0315\u02f4ˣ\u02f0\u02df\u0305\u02f2\u0305ˣ\u200c،\u02e8\u02eb\u0305\u0303ˎˣ\u200c،ˤ\u0309\u02f2ˢ\u0308\u0307\u02d2ˍ\u0314ˍˍ\u02e6\u0315\u0309\u0310\u02d7\u02f0ˣ\u02e6\u02e6\u0315\u02d7\u0307ˣ\u02ef\u030eˏ\u02df\u0315\u200c،\u02e5\u0316ˣ\u02eb\u02e8\u02f0\u0302\u02f7ˣ\u0315\u0317\u02f2ˣ\u02ef\u02f4ˉ\u02df\u0305\u200c،ˠˡˡ\u02f5\u200c،\u200c،\u0304\u0305\u02e7\u200c،\u02df\u02ef\u0305\u030a\u0305\u200c،\u02df\u02e8ˬˉ\u02df\u0305\u200c،ˠˡˡ\u02ed\u200c،\u200c،\u0309ː\u02df\u0304\u0304ˏˉ\u0302\u02f7\u02f5\u02df\u02f2ˠ\u0316\u02d6\u02e8ˣ\u0315\u02d2\u02d2\u0300ˮ\u02d5ˍˍ\u0316ˣ\u02ea\u0302\u02ef\u02eb\u200c،ˠ\u0313\u02ed\u02ff\u02f0\u02eb\u02e7ˤ\u0316\u02eb\u02e8ˣ\u02ef\u02d6\u0305\u02e5\u02efˣ\u200c،\u02e8\u02eb\u0305\u0303\u02f5\u02eb\u200c،ˤ\u0309\u02f2ˢ\u0308\u0306\u02e8ˍ\u0314ˍˍˣ\u02ef\u02f0ˏ\u02e7\u02ef\u200c،\u02df\u02f0ˣˤˣ\u02ef\u030eˎ\u02df\u0315\u200c،\u02e5\u0316ˣ\u02ebˣ\u02ef\u0302\u02f7ˣ\u02ef\u030a\u02f8\u0309ːˣ\u02f0ˡˑ\u02efˢ\u200c،\u02df\u0300ˣ\u02ef\u0309\u02f0ˢˤ\u0305\u0304ˣ\u02f4\u0305\u02f0ˡˤː\u02f2\u02f7\u0302ˤ\u0314ˣ\u0305\u200c،ˡ\u0307\u02f7\u02f8ˣ\u0315\u02d2\u02d2ˢˮ\u02d5ˍˍ\u0316ˣ\u02e8ˤˏ\u0305\u02f2ˡ\u02f0\u0305\u02f2ˢ\u0308\u0308ˉˍ\u0304ˍˍˣ\u02ef\u0309\u02f0ˠ\u0318ˣ\u02e8\u02e6\u0315ˎ\u02f2ˢ\u0308\u0308\u0314ˍ\u0304ˍˍˣ\u02f0\u02df\u0304ˣ\u02d3\u02eb\u0305\u02f5\u02ff\u02e7\u200c،ˤ\u0309\u0310\u02d5ˠˣˣ\u0302\u02f1ˣ\u200c،\u02dfˤ\u0314ˣ\u0315\u200c،ˡ\u0305ˏˉˠ\u0315\u200c،ˠ\u02e6\u02efˣ\u200c،\u02df\u0300ˠ\u0315\u030aˎ\u02e7\u200c،\u200c،\u02ff\u02e7\u02f5ˣ\u0315\u02d2\u02d2\u0313ˍˑˍˍ\u0315\u030aˏ\u02e7\u200c،\u200c،\u02f1\u030d\u02f2\u02eb\u02df\u02eb\u02df\u02d3\u0315\u200c،\u200c،\u0309\u200c،ˠˤˉˠ\u200c،\u02dfˠˠ\u02eb\u02e5\u02e9\u0318\u02d2\u02f0ˠ\u02f3\u02f3\u02ea\u200c،\u200c،ˡ\u0315\u200c،\u02df\u02e9ˣ\u200c،\u200c،\u0304\u200c،\u200c،\u030d\u0315\u200c،\u02dfˣ\u02f3\u200c،\u02dfˡ\u0306\u200c،\u200c،\u200c،\u200c،\u02dfˣ\u02f3\u200c،\u02dfˠ\u02e6\u200c،\u200c،\u02f5\u02ef\u200c،\u02df\u02e5\u02d2\u200c،\u02dfˢ\u02efˡ\u0315\u200c،ˠ\u0307\u02f7\u02f5ˣ\u0315\u02f3\u0310\u0315\u0306\u02f7\u02e9ˣ\u02ef\u02f7\u0305\u0316\u02ef\u200c،\u02df\u02e8\u02eb\u0305\u0318\u02d7\u030d\u200c،ˤ\u0309\u02f2ˠ\u02f1\u0313\u0313\u02df\u0315\u02f0\u0306\u02e6\u0317\u02f0\u02f8ˠ\u030bˤˤ\u02df\u02ef\u200c،\u200c،\u02f3\u200c،\u200c،\u02ffˣ\u0315\u02f3\u0310\u030bˠˣ\u02e5\u02e7ˬ\u02eb\u200c،\u02dfˡ\u02f2\u02e7\u02e8\u0302\u0317\u200c،ˠ\u02f8\u02e9ˉ\u0315\u02f6ˡ\u0316ˣ\u02e5\u02e6ːˉ\u02f2\u02e7\u02e8\u02e9\u02f2\u200c،ˠ\u02f8ˣ\u0315\u02f3\u02d2\u0302ˮˍˍˍ\u0315\u02e9\u02eb\u02df\u0305\u200c،\u02e5ː\u02d6\u02f3\u200c،\u02df\u02e9ˡ\u0316\u02d6\u02e9ˣ\u0315\u02f3\u02d2\u02f6ˍˍˍˍ\u0315\u02f7\u02f6\u02f5\u02df\u030d\u0304\u02e7\u02df\u0315\u0300ˢ\u02f0\u02d2\u02e7\u02e5\u030a\u0311\u02e8\u02f5\u02f2\u02e7\u02f4ˣ\u02ef\u02f7\u0305ˢ\u02efˣ\u200c،\u02e8\u02eb\u0305ˍ\u02eb\u200c،\u02dfˤ\u0309\u02f2ˠ\u02f2\u0305\u02d3ˍˍˍˍˣ\u02ef\u02f7\u0304\u0303\u02f8\u02eb\u0305ˮ\u0302\u0305\u200c،ˤ\u0309\u0310\u02d5\u02df\u0301\u030f\u02e5ˠ\u02ebˤ\u02edˡ\u02eaˍˍˍ\u02d6\u02dfˣ\u0318\u02dfˣ\u02dfˠ\u0311ˠ\u200c،\u02df\u02e9\u200c،\u02df\u02f0\u0304\u0305\u02e7\u200c،\u02df\u02ef\u02f2ˠ\u030c\u02d2ˣ\u200c،\u02dfˣˣ\u0315\u0301\u0310\u02f2ˠˣˤ\u02f0\u02ef\u0315\u200c،\u02dfˡˡ\u200c،\u200c،\u0314\u02ef\u200c،\u02dfˤ\u02d2\u200c،\u02dfˡ\u0307\u200c،\u200c،ˤ\u02ef\u200c،\u02dfˡ\u0309\u200c،\u02dfˡˍ\u200c،\u200c،\u0306\u0305\u200c،\u02df\u02e7\u0311\u200c،\u02dfˡ\u02d7\u200c،\u200c،\u0301\u200c،\u200c،\u200c،\u200c،\u02dfˢ\u02efˢ\u200c،\u02dfˠ\u0307\u02f7\u02f0ˠ\u0306\u02d7\u02eb\u0309\u0317ˠ\u030c\u0317\u0315\u200c،\u02f5\u02f0\u02ebˤ\u02e9\u02d5\u02ef\u02f5ˡ\u0306ˣ\u02e5\u02e7\u02e6\u02d2ˠ\u200c،ˡ\u02f2\u02e7ˡ\u02f0\u0308\u200c،ˠ\u02f8ˣ\u0315\u02f3\u0310\u030d\u02df\u02d2ˤˢ\u0305\u02f0\u0306\u02e6\u0318ˏ\u02f8ˠ\u030bˤˤ\u02df\u02ef\u200c،\u02dfˠ\u02e7\u200c،\u200c،\u02f0ˠ\u0306\u02d6ˎ\u0309\u0317ˠ\u02f2\u02e9\u200c،\u02df\u02f5\u02f0\u02ebˤ\u02ed\u02e6\u0314ˍˍˍ\u02d6\u02f0ˠ\u0317\u02df\u02f0\u02df\u02ef\u200c،\u0309\u0317ˡ\u0317\u02e5\u02ef\u200c،\u02f5\u02f1\u0314\u030eˣ\u0305\u02eaˉˤ\u02ef\u02d2\u200c،\u02dfˣ\u02e7ˡ\u0316\u02f7\u02f2ˠ\u02f2\u0306\u02f8ˍˍˍˍ\u02df\u0305\u02ebˣˠ\u02f1\u0305\u02f4\u200c،\u02df\u02e9ˡ\u0316\u02f7\u02f2ˠ\u02f2\u0306\u02e6ˍˍˍˍˠ\u0306\u0302\u02f7ˡ\u0305\u02d2ˣ\u02e8\u02f4\u030dˬˢ\u0305\u02ef\u02e8\u02f5\u02dfˎ\u02f0ˠ\u0316\u02d7\u02f4\u0309\u0317ˡ\u0300ˤ\u02ef\u200c،\u02f5\u02f0\u02ebˤ\u02edˡ\u0304ˍˍˍ\u02d6\u02e8\u02e5ˤˎ\u0312ˡ\u02f0\u02d6\u02e8ˣ\u0315\u02f3\u02d2\u02e5\u0304ˍˍˍ\u0316ˣ\u02e6\u02e6ˎ\u02d4\u02f2\u02e7\u02e8\u02d7ˢ\u200c،ˠ\u02f8\u02e9ˉ\u0315\u02e6\u02e9\u0306ˣ\u02e6\u02e7\u02ed\u0301\u200c،\u02dfˡ\u02f2\u02e7\u02ea\u030fˢ\u200c،ˠ\u02f8ˣ\u0315\u02f3\u02d2\u02d7\u0304\u02d5ˍˍ\u0315\u02df\u02f2\u02eb\u02df\u0301\u02df\u0305\u0315ˣ\u200c،\u02df\u0311\u200c،ˠˤˉ\u02df\u0305\u200c،ˠˠ\u02ebˤ\u0304\u0305\u02ef\u200c،\u02df\u02ef\u02f2ˠ\u0307\u0312\u02e9ˣ\u02ef\u02f0ˤˢ\u0305\u200c،\u02dfˠ\u02e7\u200c،\u02dfˢ\u0303\u200c،\u200c،\u030c\u02ef\u200c،\u02df\u02e5\u02f3\u200c،\u02dfˡˠ\u200c،\u200c،\u02d3\u0305\u200c،\u02dfˠ\u0315ˠ\u200c،ˠ\u02ef\u200c،\u200c،ˡ\u0315\u200c،\u02dfˠ\u0315ˠ\u200c،\u02df\u02ff\u02df\u02ef\u200c،\u200c،\u200c،\u02dfˮ\u0315\u200c،\u02dfˡˠ\u200c،\u200c،ˎ\u02dfˎ\u200c،\u02df\u02f7\u030b\u02e6\u0306\u02ebˣ\u02e9\u02d5\u02f7\u02f5ˡ\u0306\u02f7\u02f2ˠˡ\u0313\u0314\u02df\u0315\u02f0\u0306\u02e6ː\u030e\u02f8ˠ\u030bˤˤ\u02df\u0315\u200c،\u02dfˠ\u02e7\u200c،\u200c،\u0304\u200c،\u200c،\u02e7\u0305\u200c،\u02dfˠˣˤ\u02e7ˬ\u0301\u200c،\u02dfˡ\u02f2\u02e7\u02eb\u030f\u0315\u200c،ˠ\u02f8ˣ\u0315\u02ef\u0310\u0306ˠˣ\u02e5\u02e6ˎ\u02f1\u02f2\u02e7ˡ\u0303\u030b\u200c،ˠ\u02f8\u02e9ˉ\u02d6\u02ff\u02e9ˉ\u0315\u02f7\u02e9ˉ\u0309\u0304\u02e6\u02df\u0311\u02f0ˠ\u0306\u02d6\u0308\u0309\u0317ˡˤ\u0304\u02ef\u200c،\u02f5\u02f0\u02ebˣ\u02edˤ\u0318ˍˍˍ\u02d6ˡ\u02e9ˠ\u02f7\u200c،\u02df\u030d\u02eaˣ\u02ef\u02f3\u0305\u0311\u0305ˣ\u200c،\u02e8\u02eb\u0305\u030c\u030c\u200c،\u02dfˤ\u0309\u02f2ˠˢ\u0306\u02dfˍˍˍˍ\u02df\u0307\u0305\u02f6\u200c،\u02df\u02e9ˡ\u0316ˣˤ\u02e7ˢ\u02dfˡ\u200c،ˡ\u02f2\u02e7ˣ\u02e7\u0311\u200c،ˠ\u02f8ˣ\u0315\u02ef\u02d2\u02e8ˮˍˍˍ\u0315\u02e7\u030d\u02e5\u200c،\u02dfˡ\u0305\u0311\u02f0ˠ\u02f1\u02df\u02f6\u02df\u02ef\u200c،\u0309\u0317ˠ\u0314\u0300\u0305\u200c،\u0304\u0305\u02e7\u200c،\u02df\u02ef\u0305\u02f4\u0315\u02e7\u200c،\u02e6\u02d2ˡ\u200c،\u02dfˣ\u02e7ˤ\u0301ˡ\u200c،ˡ\u02f2\u0304\u0305\u02e7\u200c،\u02df\u02ef\u0304\u02e6\u02d3ˬ\u0305\u02e7\u02ea\u02e7\u200c،\u02dfˠ\u0304\u030c\u02f4\u0309\u02f2ˠˢ\u0308\u0308ˍ\u0314ˍˍˠ\u0306\u0302\u02f7ˡ\u0305\u02eb\u030a\u02f5\u0305\u0315ˢˡˤ\u0305\u02ebˣ\u02ef\u02f7\u0304\u02f4\u02f8\u02eb\u0305\u0309\u0306\u02f3\u200c،ˤ\u0309\u02f2ˠˢ\u0308ˤˍ\u0314ˍˍˡˠ\u0306\u0302\u02ea\u02ef\u0309\u0304ˡ\u0306\u02ebˣ\u02ed\u02ea\u0304ˉˍˍ\u02d6\u02f0ˠ\u02f1\u02dfˬ\u02df\u0305\u200c،\u0309\u0317ˢ\u030c\u02f3\u02ef\u200c،\u02f5\u02f1\u0314\u030eˠ\u0317\u030d\u02f0ˠ\u02f1ˢ\u02f6\u200c،\u200c،\u0309\u0316ˣˤ\u02e7ˬ\u0301\u200c،\u02dfˡ\u02f2\u02f5\u02f0\u02ebˣ\u02ed\u02e7ˑˉˍˍ\u02d6\u02dfˣ\u0318\u02df\u02e5\u02dfˮ\u0311\u200c،\u200c،\u02eb\u200c،\u02df\u02f0\u0304\u0305\u02ef\u200c،\u02df\u02ef\u02f2ˠ\u02e6\u02d2ˡ\u200c،\u02dfˣˣ\u0315\u02f3\u0300ˢ\u02ef\u030aˤˡ\u0305\u200c،\u02df\u02e8\u02e7\u200c،\u02dfˠ\u0313\u200c،\u200c،\u02ea\u0305\u200c،\u02df\u02e7\u0311\u200c،\u02dfˠ\u02e7\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،ˡ\u02ea\u200c،\u200c،\u0309\u0305\u200c،\u02dfˤ\u0315\u200c،\u200c،\u02f5ˡ\u0306ˣˣ\u02e6\u0318ˉ\u02f2\u02e7\u02e5\u0308\u02ed\u200c،ˠˉˠ\u200c،\u02dfˠˡ\u02dfˎ\u02df\u02ef\u200c،\u0304\u0305\u02ef\u200c،\u02df\u02ef\u0305ˬ\u02dfˣ\u200c،\u02e8\u02ebˢ\u02f5\u02f1ˢ\u0312\u200c،\u200c،\u02f6\u02d3ˏ\u02f8ˢ\u02f1\u0313\u0309ˠ\u02ef\u02d2ˣ\u02f7\u02f0\u02d6\u030c\u02f5\u02ef\u02f8\u0306\u02f0\u02efˣ\u200c،\u200c،ˣ\u200c،\u200c،\u02e5\u0305ˎ\u0310\u0308\u0306\u02d6\u02e8\u02e9ˍ\u0309\u02f0ˠ\u02f1ˡ\u02e7\u02df\u02ef\u200c،\u0309\u0317\u02df\u02d5\u02f0\u02ef\u200c،\u02f5\u02efˎ\u02d2\u0302\u0314ˍˍˍ\u0315\u02e9\u02eb\u02df\u0305\u200c،\u02e5\u0315\u02ebˣ\u0308\u02df\u02f3\u200c،ˠ\u0312\u0314\u02e5\u02ef\u200c،ˡ\u0305\u02f7\u02f6\u02f5\u02df\u030d\u0305\u0309\u200c،\u200c،\u02df\u0311\u02e6\u02e8\u02f4\u030d\u02e6\u02f5ˠ\u0306\u0302\u02ea\u02df\u0301\u02f8ˢ\u02f2\u0306\u02e9ˍˍˍˍˤ\u0307\u0314ˑ\u02e5\u02dfˎ\u02d2\u02efˮˍˍˍ\u0317\u030d\u02f8ˣ\u0315\u0301\u02f0ˠˎ\u02f3ˤ\u200c،\u200c،ˠ\u0315\u200c،\u200c،\u0301\u200c،\u200c،\u02e6\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،ˢ\u02efˢ\u0305\u200c،ˠ\u0307\u02f7\u030f\u02ed\u02e6\u02e6ˍˍˍ\u02d6\u02dfˣ\u0318\u02dfˢ\u02df\u02eaˎ\u200c،\u200c،ˬ\u200c،\u02df\u02f0\u0304\u0305\u02ef\u200c،\u02df\u02ef\u02f2ˠˡ\u0312\u02dfˡ\u02f3\u02f3\u02eb\u200c،\u200c،ˣ\u200c،\u200c،ˢ\u02f3\u200c،\u02dfˠ\u02ea\u200c،\u200c،\u02f6\u0315\u200c،\u02dfˤ\u02d6\u200c،\u200c،\u200c،\u200c،\u02df\u02f1\u0315\u200c،\u02dfˢ\u0315\u200c،\u200c،\u02e9\u200c،\u200c،\u02f0\u0315\u200c،\u02df\u02e6\u200c،\u200c،ˠˑ\u200c،\u200c،ˎ\u02df\u02d6\u200c،\u02df\u02f7\u030b\u02e6\u0305ˎ\u0310\u0315ˠ\u02f7\u02e9ˤ\u0305ˎ\u0310\u0313\u0305\u02e7ˢ\u02f7\u02f0\u02d7\u02d5\u02f5\u02ef\u02f8\u0306\u02f0\u02efˣ\u200c،\u200c،ˣ\u200c،\u200c،ˤ\u0315ˎ\u0310\u030e\u02f0ˣˣ\u02e7ˣ\u02d2ˠ\u200c،ˡ\u02f2\u02e7ˣ\u0306\u0307\u200c،ˠ\u02f8\u02e9ˉˎ\u02f3ˡ\u0316\u02d6\u02e8ˢ\u02f1\u0313\u02ed\u02e9ˠ\u030d\u200c،\u02df\u030d\u02ea\u02e6\u0315\u0309ˬ\u02e9\u02d2\u02eb\u02e5ˤˏ\u0305\u02e9\u02df\u0307\u02f4\u02ff\u02df\u030a\u0305\u02f7\u02f6\u02f1\u0315\u02e6\u02e5\u02efˎ\u02d2\u0300ˍˍˍˍ\u0316\u02d6\u02e9\u02e9ˍ\u02f7\u02f0ˠˠ\u02d7\u0318\u0309\u0316ˣˣ\u02e6ˑ\u02ed\u02f2\u02f5\u02efˎ\u02d2\u02f5\u0314ˍˍˍ\u0315\u0302ˎˤ\u0305\u200c،\u02df\u02f1\u030d\u02f5ˢ\u02f2\u0306\u02ebˍˍˍˍ\u200c،\u200c،ˣ\u0318\u02df\u02e5\u02dfˠ\u02f7ˠ\u200c،\u02df\u02ed\u200c،\u02df\u02f0\u0304\u0305\u02ef\u200c،\u02df\u02ef\u02f2ˠ\u02f6\u02d2ˡ\u200c،\u02dfˣˣ\u0315\u02f7\u0310\u02ef\u0316ˣˣ\u02f0\u02ef\u0315\u200c،\u02dfˡ\u02d4\u200c،\u200c،\u0305\u200c،\u200c،ˣ\u02f7\u200c،\u200c،\u200c،\u200c،\u02df\u0311\u0315\u200c،\u02df\u02ea\u02eb\u200c،\u02dfˠˎ\u200c،\u200c،\u0300\u200c،\u200c،ˤ\u200c،\u200c،\u02df\u02eb\u200c،\u200c،\u02e7\u200c،\u200c،\u02ea\u02eb\u200c،\u02dfˢ\u02efˣ\u200c،\u02dfˠ\u0307\u02f7\u0304ˡ\u02f0\u02ebˣ\u02e9\u02d5ˎ\u02f5ˡ\u0306ˣˤ\u02e7ˠˣˠ\u200c،ˡ\u02f2\u02e7\u02ea\u02e7\u02f8\u200c،ˠ\u02f8ˣ\u0315\u02ef\u0310\u030f\u02ef\u02efˢ\u02f7\u02f0\u02d6ˉ\u02f5\u02ef\u02f8\u0306\u02f0\u02efˣ\u200c،\u200c،\u02f1\u200c،\u200c،ˣ\u02ef\u02f7\u0305ˎ\u0305ˣ\u200c،\u02e8\u02eb\u0305\u030bˢ\u0309\u200c،ˤ\u0309\u02f2ˠˡ\u0313\u02e5\u02e6\u0307\u0314\u02d3ˤ\u02df\u0311\u0302ˣ\u0315\u02ef\u02d2\u0303\u0304ˍˍˍ\u0315\u02e7\u030d\u02e5\u0315\u200c،ˡ\u0305\u0311\u02f0ˠ\u02f1ˡ\u02ff\u200c،\u200c،\u0309\u0317ˢ\u02d4\u0301\u0315\u200c،\u02f5\u02f0\u02ebˣ\u02edˤˑˍˍˍ\u02d6\u02e5ˤˏ\u0305\u02e9\u02df\u0317\u02f4\u02ffˢ\u02df\u02eb\u02e7\u02f5\u02df\u0315\u02f6ˣ\u0315\u02ef\u02d2\u02f1\u0304ˍˍˍ\u0315\u0305\u02f7\u02f6\u02f6\u02d2ˡ\u200c،\u02dfˣ\u02e7\u02e8\u0315\u200c،\u02dfˠˉ\u02df\u0305\u200c،ˠˡˡ\u0301\u200c،\u200c،\u0309ˑ\u02d2ˡ\u200c،\u02dfˣ\u02e6ˑ\u02e5\u02f2\u02f7\u02f0\u02d7\u0316\u02f6\u02d3ˎ\u0312ˡˠ\u030d\u02f2ˠˢ\u0305\u02ffˍˍˍˍ\u02e6\u0315\u030d\u0310\u02d7\u02ef\u0302ˏˤ\u0305\u200c،\u02df\u02f1\u030d\u02f0ˠ\u0307ˢ\u0313\u02df\u02ef\u200c،\u0309\u0317ˠˣˮ\u0315\u200c،\u02f5\u02f0\u02ebˣ\u02edˮ\u0310ˉˍˍ\u02d6\u200c،ˠ\u02eb\u0315\u02df\u0315\u02dfˡ\u02df\u02ef\u200c،ˢ\u0315\u200c،ˣ\u02f6\u02d2ˣ\u200c،\u02dfˣˢ\u02f6\u02d2ˡ\u200c،\u02dfˣˣ\u0315\u02ef\u02f8ˢ\u02df\u0306ˤˡ\u200c،\u200c،\u02e6\u0301\u200c،\u200c،\u0314\u200c،\u200c،\u02ea\u0315\u200c،\u200c،\u200c،\u200c،ˡ\u0307\u200c،\u200c،\u0316\u02ef\u200c،\u02df\u02e9\u02e7\u200c،\u02dfˠ\u02f5\u200c،\u200c،\u02e6\u0317\u02edˬ\u02df\u02ef\u200c،\u02df\u02f1\u02f6\u02efˡ\u200c،\u02dfˠˡ\u0305ˠ\u200c،\u02df\u02e9\u0305\u02df\u02f7\u200c،\u02df\u02ef\u0303\u0308\u02efˣ\u200c،\u02dfˣ\u02e9ˠ\u030c\u02f3ˢ\u200c،\u02df\u0300\u02e6ˡˢ\u02f2\u02e6\u200c،\u02df\u030c\u02f0\u0301\u02eb\u02e9\u02d4\u0311\u02e5\u0302\u02ef\u02eb\u200c،ˠ\u0311\u02f8\u02e7\u02ea\u02d6\u0308\u200c،ˡ\u0302ˠ\u030c\u02f3ˢ\u200c،\u02df\u0300\u02e5\u0317\u02df\u0318ˬ\u0315\u200c،\u030c\u02ef\u0309\u0304\u02e6\u02d3\u02eb\u0305\u02e8\u02d5\u02eb\u200c،ˤ\u0309\u02eb\u02e9\u02d2\u02ef\u02e5\u0302\u02df\u02eb\u200c،ˠ\u0311\u02f5\u02e7\u02ea\u02efː\u200c،ˡ\u0302ˠ\u030c\u02f3ˢ\u200c،\u02df\u0300ˤ\u0317\u02df\u02f5\u02ed\u0315\u200c،\u030c\u02f0\u02f7\u02eb\u02ed\u02e5ˮˍˍˍ\u02d6\u02e5\u0302\u02ef\u02eb\u200c،ˠ\u0311\u0302\u02e7\u02e6\u02e7ˬ\u200c،ˡ\u0302ˠ\u030c\u02efˢ\u200c،\u02df\u0300\u02e5\u0307ˠˤ\u02ed\u0305\u200c،\u030c\u02f0ˣˣ\u02e6ː\u0317\u02f2\u02e7ˢ\u02ea\u02f7\u200c،ˠ\u02f8ˢˢ\u0305\u02d2ˍˍˍˍˠ\u030c\u02f3ˢ\u200c،\u02df\u0300\u02e5ˡˠ\u0312\u02df\u02ef\u200c،\u030c\u02f0\u030bˬ\u02e7\u200c،\u200c،\u02f7\u02df\u02e6\u200c،\u02dfˣˠ\u030c\u02f3ˢ\u200c،\u02df\u0300\u0305\u02df\u02f3\u200c،\u02df\u02ef\u030fˎˠˣ\u200c،\u02df\u02f7\u030b\u02e9\u0305\u200c،ˣ\u0318\u02dfˢ\u02dfˮ\u02f7\u200c،\u200c،\u02ef\u200c،\u02df\u02f0\u0304\u0305\u02e7\u200c،\u02df\u02ef\u02f2ˠ\u030c\u02d2ˣ\u200c،\u02dfˣˣ\u0315\u0301\u0310ˮ\u0306ˣˤ\u02f0\u02ef\u0311\u200c،\u200c،\u0311\u200c،\u200c،\u0300\u0305\u200c،\u02dfˤ\u02d2\u200c،\u200c،\u02f1\u200c،\u200c،ˣ\u0305\u200c،\u02df\u02e5\u02e7\u200c،\u200c،\u200c،\u200c،\u02df\u030c\u200c،\u200c،\u02df\u0311\u200c،\u02dfˠˠ\u200c،\u200c،\u030c\u0305\u200c،\u02dfˬ\u02df\u02f1\u200c،\u02df\u02e5\u02e8\u0306\u02d2\u02f2ˠ\u02f1\u0314ˡˤ\u0305\u030d\u02f8ˣ\u0315\u02f3\u0310\u0313\u0315\u02efˤ\u02f7\u02f0\u02d7\u02f7\u02f5\u02ef\u02f8\u0306\u02f0\u02efˣ\u200c،\u200c،ˤ\u200c،\u200c،ˤ\u0306\u02ebˤ\u02e9\u02d4\u02f3\u0304ˡ\u02f1\u0314\u02d2\u02e6\u0315ˎ\u02eaˣ\u02ef\u02f7\u0305\u02f2\u0315ˣ\u200c،\u02e8\u02eb\u0305ˮˎ\u02d2\u200c،ˤ\u0309\u02f2ˠ\u02f1\u0313\u02eb\u02df\u0305\u02eb\u030d\u02e6\u200c،\u02dfˡ\u0305\u0311\u02f0ˠ\u0307ˡ\u02ea\u200c،\u200c،\u0309\u0317ˠ\u02ff\u02d3\u02ef\u200c،\u02f5\u02f0\u02ebˤ\u02ed\u02e5ˍˍˍˍ\u02d6\u02e5ˤˏ\u0305\u02e9\u02e7ˤ\u02e7ˤ\u200c،\u02df\u02eb\u02e7\u02e9\u0315\u200c،\u200c،ˬ\u02e7\u02e9\u0309ˡ\u200c،\u02df\u02e7\u02e5ˤ\u0311\u02e8\u02f5\u02f2\u02e7\u02f1ˣ\u02ef\u0301\u0304\u0300\u02f8\u02eb\u0305\u02f6\u0303\u0309\u200c،ˤ\u0309\u02f2ˠ\u02f2\u0306ˠˍˍˍˍˣ\u02ef\u02f7\u0305\u02e6\u0305ˣ\u200c،\u02e8\u02eb\u0305\u030b\u0315\u0301\u200c،ˤ\u0309\u0310\u02d4\u02ef\u0301\u030fˣ\u02ef\u02f7\u0305ˉ\u0315ˣ\u200c،\u02e8\u02eb\u0305\u0315ˑ\u0309\u200c،ˤ\u0309\u02f2ˠ\u02f2\u0305\u02ffˍˍˍˍ\u200c،\u02df\u02f2\u02eb\u02df\u02ef\u02df\u02d4\u02ef\u200c،\u02dfˠˣ\u200c،ˠˤˉ\u02df\u0305\u200c،ˠˠ\u02eb\u02e5\u02e9ˎ\u02e7\u02f0ˠ\u02f3\u02f3\u02eb\u200c،\u200c،\u0302\u200c،\u200c،\u02e9ˣ\u200c،\u200c،\u02ea\u200c،\u200c،\u02ff\u0305\u200c،\u02df\u02e8\u02e7\u200c،\u02dfˠ\u02ef\u200c،\u200c،\u0302\u200c،\u200c،ˠ\u02e7\u200c،\u200c،\u200c،\u200c،\u02df\u02ed\u02ef\u200c،\u02df\u02e6\u02ef\u200c،\u02dfˡ\u02ff\u200c،\u200c،ˎˠ\u02eb\u200c،\u02df\u02f7\u030b\u02e5ˠ\u02ebˤ\u02e9\u02d5\u02d2\u02f5ˡ\u0306ˎ\u02f2ˠ\u02f1\u0313ˑˠ\u02ef\u02f0\u0306\u02e6\u0316\u02f8\u02f8ˠ\u030bˤˤ\u02df\u02ef\u200c،\u200c،\u02f7\u200c،\u200c،\u0304ˡ\u02f0\u02ebˤ\u02e9\u02d4\u02df\u02f0ˠ\u0307\u02df\u0306\u02df\u02ef\u200c،\u0309\u0317ˠˠ\u02f7\u02ef\u200c،\u02f5\u02f1\u0314\u0311ˤ\u02df\u0311\u02f0ˠ\u0307ˡ\u02f6\u02df\u02ef\u200c،\u0309\u0317ˢ\u0304ˣ\u200c،\u02df\u02f5\u02f0\u02ebˤ\u02ed\u02e6\u030cˍˍˍ\u02d6ˡ\u0308\u02df\u02f3\u200c،ˠ\u0311ˢ\u0308\u02df\u02e7\u200c،ˠ\u0312\u0314\u02e6\u02ef\u200c،ˡ\u0305\u0311\u02f8ˣ\u0315\u02f3\u02d2\u02f6ˍˍˍˍ\u0315\u02f7\u02f6\u02f5\u02df\u030d\u0305\u030f\u0305ˣ\u200c،\u02dfˎ\u0305ˬ\u02ef\u02e7\u200c،\u02df\u0315\u0305\u02ff\u0305\u02ef\u200c،\u02df\u0305\u02e8\u02e5ˤ\u030e\u02f8\u02eb\u02df\u0305\u02ffˣ\u0315\u02f3\u02d2\u02edˍˍˍˍ\u0316\u02d6\u02ea\u02e9ˍ\u02f3\u0302ˣ\u0315\u02f3\u02d2\u02eaˍˍˍˍ\u0315\u0302ˏ\u02df\u02ef\u200c،\u02e5\u0317\u030d\u0302ˣ\u0315\u02f3\u02d2\u02e7ˮˍˍˍ\u0315\u200c،\u02dfˠ\u02eb\u0315\u02df\u0305ˢ\u02f1\u200c،\u200c،ˣ\u0305\u200c،ˣ\u02f6\u02d2ˡ\u200c،\u02dfˣˣ\u0315\u02f0ˉˠ\u200c،\u02dfˠˠ\u02ebˤ\u02e9ˎˎ\u02e8\u02f0\u02ef\u0315\u200c،\u02dfˠ\u02d2\u200c،\u200c،ˮ\u0315\u200c،\u02dfˤ\u02e7\u200c،\u200c،\u200c،\u200c،\u02dfˤ\u0315\u200c،\u02dfˣ\u02f3\u200c،\u02dfˠ\u030f\u200c،\u200c،\u02e6\u02ef\u200c،\u02dfˣˣ\u200c،\u02dfˠ\u0316\u200c،\u200c،\u200c،\u200c،\u02dfˣˣ\u200c،\u02dfˢ\u02efˤ\u200c،\u02dfˠ\u0307\u02f7\u02f0ˠˡ\u02df\u0315\u02df\u02ef\u200c،\u0309\u0317ˠ\u02d3\u0312\u200c،\u02df\u02f5\u02efˎ\u0310\u0311\u0316\u02f7\u02e9\u02e6\u02efˎ\u0310\u0310\u02ef\u02ebˡ\u02f7\u02f0\u02d7\u02d4\u02f5\u02ef\u02f8\u0306\u02f0\u02efˣ\u200c،\u200c،\u02ed\u200c،\u200c،ˣ\u02ef\u02f3\u0304\u0304\u02f8\u02eb\u0305\u02dfˢ\u02ef\u200c،ˤ\u0309ˬ\u02e9\u02d2\u02d2\u0300\u02e9ˍ\u030d\u02f3ˡ\u0316\u0305ˬ\u02e9\u02d2\u02f3\u030d\u02e6\u0305\u200c،ˡ\u0305\u0311\u02f7ˢ\u02f2\u0306\u02d2ˍˍˍˍˠ\u0306\u0302\u02f7ˡ\u0305\u02e7\u030a\u02f5\u0305\u02e8\u02f7\u02e5ˤˎ\u0311ˠ\u0316\u0315ˬ\u02ed\u02e5\u02f2ˍˍˍ\u02d6\u0304ˡ\u02f1\u0314ː\u02e6\u02efˎ\u02d2\u02f5\u0304ˍˍˍ\u0315\u0302ˎˢ\u200c،\u200c،\u02f1\u030d\u02f0ˠˡ\u02df\u0306\u02df\u0305\u200c،\u0309\u0317ˢ\u02ea\u02f1\u0305\u200c،\u02f5\u02efˎ\u02d2ˮ\u0314ˍˍˍ\u0315\u200c،ˣ\u0318\u02df\u02e6\u200c،\u02efˠ\u200c،\u02df\u02f2\u200c،\u02df\u02f0\u0304\u0305\u02ef\u200c،\u02df\u02ef\u02f2ˠ\u0307\u0311ˍˣ\u02ef\u02f4ˤˡ\u0315\u200c،\u02df\u02e8\u0301\u200c،\u02dfˢ\u200c،\u200c،\u02df\u0301\u02ef\u200c،\u02df\u02e6ˣ\u200c،\u200c،\u0305\u200c،\u200c،\u0314\u0305\u200c،\u02df\u02e6\u0315\u200c،\u200c،\u0305\u200c،\u200c،\u200c،\u200c،\u02df\u02e7ˎ\u200c،\u200c،\u02eb\u200c،\u200c،ˎˠ\u02f3\u200c،\u02df\u02f7\u030b\u02e6\u0315\u030d\u02f2ˠ\u02f1\u0314ˠˤ\u0305\u030d\u02f0ˠ\u0307ˠ\u0310\u02df\u02ef\u200c،\u0309\u0317ˡ\u0312ˮ\u200c،\u02df\u02f5\u02f0\u02ebˤ\u02e9\u02d4ˎˣˠ\u02f6\u02d2ˡ\u200c،\u02dfˣ\u02e7\u02dfˣˡ\u200c،ˠˉ\u02df\u0305\u200c،ˠˡ\u02dfˠ\u02df\u0305\u200c،\u0309ˑ\u02d2ˣ\u200c،\u02dfˣ\u02e7\u02e8\u200c،\u200c،ˡ\u02f2\u02f5ˡˡˑ\u200c،\u200c،\u02f6\u02d3ˏ\u0306\u02e6ˑ\u02d7\u02f8ˠ\u030bˤˤ\u02df\u02ef\u200c،\u200c،\u0305\u200c،\u200c،\u02f8ˣ\u0315\u02f3\u02d2\u0300ˮˍˍˍ\u0316ˣ\u02e5\u02e7ˤ\u02dfˠ\u200c،ˡ\u02f2\u02e7\u02df\u02d5\u02e6\u200c،ˠ\u02f8\u02e9ˉ\u0309\u02f6ˡ\u0316\u02d6\u02e8ˣ\u0315\u02f3\u02d2\u02f3\u0304ˍˍˍ\u0315\u02e7ˢ\u02e9ˠ\u02d6\u200c،\u02df\u030d\u02ea\u02e6\u0315\u0309\u02f2ˠ\u02f2\u0306\u02dfˍˍˍˍˠ\u0306\u0302\u02f7ˡ\u0307ˡ\u02f1\u02df\u0315\u200c،ˢˠ\u02d7\u0315ˢ\u02f1ˢ\u02e8\u02df\u02ef\u200c،ˡˠ\u0306\u0300ˡ\u02f4\u0309\u0317ˤ\u02f0ˣ\u02e5\u02e7ˡ\u02d2ˠ\u200c،ˡ\u02f2\u02e7\u02e5\u02e5\u0301\u200c،ˠ\u02f8ˣ\u0315\u02f3\u02d2ˣ\u0314ˍˍˍ\u0316\u030d\u0310\u02d7\u0305\u0301\u030f\u02e5\u0306\u02ebˤ\u02ed\u02df\u02f6ˍˍˍ\u02d6\u02f2\u02eb\u02df\u02ef\u02dfˢ\u02efˣ\u200c،ˠ\u02e7\u200c،ˠˤˉ\u02df\u0305\u200c،ˠˠ\u02ebˣ\u0304\u0305\u02ef\u200c،\u02df\u02ef\u02f2ˠ\u02f1\u0312\u02dfˡ\u02f3\u02f3\u02eb\u200c،\u200c،\u0302\u0305\u200c،\u02dfˠˎ\u200c،\u02dfˡ\u0316\u200c،\u200c،\u02f0\u02ef\u200c،\u02df\u02e6\u02f7\u200c،\u02dfˠˤ\u200c،\u200c،\u0311\u0315\u200c،\u02dfˠˎ\u200c،\u200c،\u02e9\u200c،\u200c،\u02f2\u0305\u200c،\u02df\u02e8ˎ\u200c،\u200c،\u200c،\u200c،\u02dfˎˠ\u02f7\u200c،\u02df\u02f7\u030b\u02e6\u0305ˎ\u0310\u0315ˠ\u02f7\u02e9ˣ\u02ef\u02ef\u0305ˎ\u02efˣ\u200c،\u02e8\u02eb\u0305\u02f8ˬ\u02e7\u200c،ˤ\u0309ˬ\u02e9\u02d4ˎ\u02edˠ\u02ef\u02d2ˣ\u02f7\u02f0\u02d6\u030b\u02f5\u02ef\u02f8\u0306\u02f0\u02efˣ\u200c،\u200c،\u02f0\u200c،\u200c،ˣ\u02ef\u02ef\u0305\u02ed\u0315\u02e7\u200c،\u02e8\u02eb\u0305\u0310\u0311\u02d2\u200c،ˤ\u0309ˬ\u02e9\u02d2\u0309\u0304ˡ\u02f1\u0314\u02d3ˤ\u02df\u0311\u02f5ˢ\u02f2\u0306\u02d6ˍˍˍˍ\u02df\u030d\u0315ˤ\u200c،\u02df\u0300\u02df\u02d2\u0315ˡ\u200c،\u02df\u0300ˠ\u02df\u02f3\u030dˡ\u0315\u200c،ˡ\u0305\u0311\u02f0ˠ\u02f1ˠ\u02eb\u02df\u02ef\u200c،\u0309\u0317ˠˬ\u02f8\u0305\u200c،\u02f5\u02efˎ\u02d2\u02f4ˮˍˍˍ\u0315\u02f7\u02f6\u02f5\u02df\u030d\u02edˠ\u02f1\u02f4\u02ffˢ\u0305\u02f4\u02f7\u02e5ˤˎ\u0311ˡˠ\u02d6\u02e9ˢ\u02f2\u0305\u02d7ˍˍˍˍˣ\u02ef\u02ef\u0305\u02f4\u0315ˣ\u200c،\u02e8\u02eb\u0305\u02e5ˤ\u0301\u200c،ˤ\u0309\u0310\u02d4\u0306ˣˣ\u02e7\u02ebˎ\u200c،\u02dfˡ\u02f2\u02e7ˮ\u0306ˎ\u200c،ˠ\u02f8ˢ\u02f2\u0305\u02f8ˍˍˍˍˠ\u0317\u030d\u02f0ˠ\u02f1ˡ\u0308\u02df\u02ef\u200c،\u0309\u0317ˡ\u0312\u0308\u200c،\u02df\u02f5\u02efˎ\u02d2\u02dfˍˍˍˍ\u0315\u200c،\u02dfˠ\u02eb\u0315ˠ\u02dfˢˎ\u200c،\u200c،ˠ\u0305\u200c،ˣ\u02f6\u02d2ˣ\u200c،\u02dfˣˣ\u0315\u02f4ˉ\u02df\u0305\u200c،ˠˠ\u02eb\u02e5\u02e9ˎ\u02e7\u02f0ˠˣ\u02f3\u02eb\u200c،\u200c،\u0301\u200c،\u200c،\u02e9\u02eb\u200c،\u200c،\u02ea\u200c،\u200c،\u02e6\u200c،\u200c،\u02e9\u02f3\u200c،\u02dfˡ\u02f2\u200c،\u200c،\u030d\u0315\u200c،\u02dfˣˣ\u200c،\u200c،\u0301\u200c،\u200c،\u02f5\u02ef\u200c،\u02df\u02e6\u0309\u200c،\u200c،\u200c،\u200c،\u02dfˎˠ\u0301\u200c،\u02df\u02f7\u030b\u02e5ˠ\u02ebˣ\u02e9\u02d5\u02d2\u02f5ˡ\u0306ˣˤ\u02e6ˑː\u02f2\u02e7ˮ\u02d2\u0318\u200c،ˠ\u02f8ˣ\u0315\u02ef\u0310\u0310\u02ef\u02d2ˣˢ\u0305\u02f4\u0306\u02e6\u0317\u0316\u02f8ˠ\u030bˤˤ\u02df\u02ef\u200c،\u200c،\u02f3\u200c،\u200c،\u0302ˣ\u0315\u02ef\u0310\u030a\u02f0ˣˤ\u02e6\u0317\u02ed\u02f2\u02e7\u02e6ˏ\u02d7\u200c،ˠ\u02f8\u02e9ˉ\u02d6\u02edˠ\u02df\u0311\u02f0ˠ\u02f1ˠ\u02e6\u02df\u02ef\u200c،\u0309\u0317\u02dfˮ\u02f7\u0305\u200c،\u02f5\u02f0\u02ebˣ\u02ed\u02e6ˢˍˍˍ\u02d6ˡ\u0308\u02df\u02e7\u200c،ˠ\u0311ˢˠ\u02df\u02f4\u0314\u02e7\u200c،\u02dfˡ\u0305\u0311\u02f5ˣ\u0315\u02ef\u02d2\u02f5\u0304ˍˍˍ\u0315\u02f7\u02f6\u02f5\u02df\u030d\u02edˠ\u02f1\u02f4\u02ffˢ\u02df\u02d2ˤˡˤ\u0305\u02ebˣ\u02ef\u02f7\u0305\u02d6\u200c،\u200c،\u02e8\u02eb\u0305\u030c\u030a\u0305\u200c،ˤ\u0309\u02f2ˠˢ\u0305ːˍˍˍˍˡˠ\u0306\u0302\u02ea\u02ef\u0305\u02f6ˣ\u0315\u02ef\u02d2\u02e9\u0304ˍˍˍ\u0316\u0309\u0310\u02d7\u0305\u0301\u030f\u02e5\u02f0\u02ebˣ\u02edˠ\u0318ˍˍˍ\u02d6\u02f2\u02eb\u02df\u02eb\u02df\u02d5\u0305\u200c،\u200c،\u030d\u200c،ˠˤˉ\u02df\u0305\u200c،ˠˠ\u02eb\u02e5\u0304\u0305\u02ef\u200c،\u02df\u02ef\u02f2ˠ\u0317\u0312ˢˣ\u02ef\u02f4ˤˢ\u200c،\u200c،\u200c،\u200c،\u02dfˡ\u02f2\u200c،\u200c،ˣ\u0315\u200c،\u02df\u02e7\u02eb\u200c،\u02dfˠ\u02f8\u200c،\u200c،\u0300\u0315\u200c،\u02dfˤ\u0309\u200c،\u02dfˡ\u02f4\u200c،\u200c،\u02f0\u0315\u200c،\u02dfˤ\u0309\u200c،\u200c،\u02eb\u200c،\u200c،\u02f5\u02ef\u200c،\u02dfˬ\u02df\u02f7\u200c،\u02df\u02e5\u02e8\u0306\u02d6\u02e9ˣ\u0315\u02f3\u0310\u0314\u02f0\u02f7\u02e9\u02e5ˠ\u02ebˤ\u02e9\u02d5\u02f7\u02edˠ\u02df\u02f4\u0306\u02e6ːˤ\u02f8ˠ\u030bˤˤ\u02df\u02ef\u200c،\u02dfˠ\u02e7\u200c،\u200c،\u02f0ˠ\u0307\u02df\u0304\u02df\u02ef\u200c،\u0309\u0317\u02df\u02d4ˏ\u02ef\u200c،\u02f5\u02f0\u02ebˤ\u02e9\u02d3\u02e7\u02f0ˠ\u0317ˡˠ\u200c،\u200c،\u0309\u0317ˠ\u0301\u0304\u0315\u200c،\u02f5\u02f1\u0314\u0311ˣ\u0305\u02eaˉˤ\u02ef\u02d2\u200c،\u02dfˣ\u02e7ˡ\u0316\u0311\u02f2ˠ\u02f2\u0306\u0315ˍˍˍˍ\u02df\u030d\u0315ˡ\u200c،\u02df\u0300\u02df\u0315\u02f0\u0314\u02e7\u02ef\u200c،ˡ\u0305\u0311\u0300ˣ\u0315\u02f3\u02d2\u02f5\u0314ˍˍˍ\u0315\u02f7\u02f6\u02f5\u02df\u030dˤ\u02e8\u02f4\u030dˬˠ\u02ef\u030a\u02f7ˢ\u02f0\u0309\u02f2ˠ\u02f2\u0306\u02e5ˍˍˍˍˡ\u02f0\u0306\u0302\u02ea\u02ef\u0305\u02f6ˣ\u0315\u02f3\u02d2\u02ed\u0304ˍˍˍ\u0316\u0305\u0310\u02d7\u0305\u0301\u030fˣ\u02ef\u02f7\u0304ˣ\u02d3\u02eb\u0305\u02ff\u02e9\u02e7\u200c،ˤ\u0309\u02f2ˠ\u02f2\u0305\u0307ˍˍˍˍ\u200c،\u02df\u02f2\u02eb\u02df\u02eb\u200c،\u0315ˣ\u200c،ˠ\u200c،\u02dfˠˤˉˠ\u200c،\u02dfˠˠ\u02eb\u02e5\u0304\u0305\u02e7\u200c،\u02df\u02ef\u02f2ˠ\u0317\u0312\u02eaˣ\u02ef\u02f4ˤˡ\u0315\u200c،\u02df\u02e9\u0315\u200c،\u02dfˡ\u0313\u200c،\u200c،\u0310\u200c،\u200c،ˤˎ\u200c،\u200c،\u02f7\u200c،\u200c،\u02f0\u02ef\u200c،\u200c،\u200c،\u200c،ˠ\u02d5\u200c،\u200c،\u0307\u200c،\u200c،ˡ\u0315\u200c،\u200c،\u0311\u200c،\u200c،ˎˠ\u0309\u200c،\u02df\u02f7\u030bˣ\u02ef\u02f7\u0305\u02f7\u02efˣ\u200c،\u02e8\u02eb\u0305\u0306\u0312\u030d\u200c،ˤ\u0309\u02f2ˠ\u02f1\u0313ˏˤ\u0305\u030d\u02f0ˠ\u0317\u02df\u0314\u02df\u0305\u200c،\u0309\u0317ˢ\u0307\u02f1\u0315\u200c،\u02f5\u02f0\u02ebˤ\u02e9\u02d4ˣˣ\u02dfːˣ\u0304\u02f5\u030a\u0309\u02e5\u02f7\u02f3\u02f3ˠ\u200c،\u200c،ˠ\u02ef\u200c،\u02dfˠ\u0311\u02f2ˠ\u02f1\u0313\u02ea\u02e5\u02f1\u0314\u02d3\u02e6\u0315ˎ\u02eaˣ\u02ef\u02f7\u0305ˎ\u0315\u200c،\u02df\u02e8\u02eb\u0305\u030b\u02f6\u02e7\u200c،ˤ\u0309\u02f2ˠ\u02f2\u0306\u0315ˍˍˍˍ\u02df\u030d\u0315ˡ\u200c،\u02df\u0300\u0300\u0317\u02e7\u200c،\u02df\u030d\u02eaˣ\u02ef\u02f7\u0304\u0300\u02d3\u02eb\u0305\u030a\u02f8\u02eb\u200c،ˤ\u0309\u02f2ˠ\u02f2\u0306\u02f1ˍˍˍˍˠ\u0306\u0302\u02f7ˡ\u0307ˠ\u030cˡ\u200c،\u02dfˢˠ\u02d6\u02e8ˢ\u02f1ˢˬ\u02df\u0305\u200c،ˡˠ\u030a\u0300ˡ\u02f4\u0309\u0317ˡˠ\u02f7\u02f2ˠ\u02f2\u0305\u0316ˍˍˍˍˣ\u02ef\u02f7\u0305ˢ\u02efˣ\u200c،\u02e8\u02eb\u0305\u02d7\u02d6\u200c،\u02dfˤ\u0309\u0310\u02d4\u02ef\u0301\u030fˣ\u02ef\u02f7\u0304\u0303\u02f8\u02eb\u0305ˬ\u0302\u0305\u200c،ˤ\u0309\u02f2ˠ\u02f2\u0305ˬˍˍˍˍ\u02dfˠ\u02eb\u0315\u02df\u0315ˢˉ\u200c،\u200c،ˤ\u200c،\u02dfˣ\u02f6\u02d2ˡ\u200c،\u02dfˣˣ\u0315\u02f8ˉˠ\u200c،\u02dfˠˠ\u02eb\u02e6\u02e9\u0318\u02d6\u02f0ˠ\u02f3\u02f3\u02ea\u200c،\u200c،\u0305\u02ef\u200c،\u02dfˣ\u02ef\u200c،\u02dfˠˡ\u200c،\u200c،\u200c،\u200c،\u02df\u02e6ˎ\u200c،\u02dfˠ\u02f5\u200c،\u200c،\u030f\u02ef\u200c،\u02dfˤ\u02f7\u200c،\u200c،\u02f2\u200c،\u200c،ˢ\u200c،\u200c،\u02e9\u02e7\u200c،\u02dfˢ\u02ef\u02e5\u0305\u200c،ˠ\u0307\u02f7\u0304ˡ\u02f0\u02ebˤ\u02e9\u02d6ˣ\u02f5ˡ\u0306\u02d2\u02f2ˠ\u02f1\u0313\u02d4ˠ\u02ef\u02f0\u0306\u02e5ˏ\u0309\u02e5\u02f7\u02f3\u02f3ˠ\u200c،\u200c،ˢ\u0315\u200c،\u02dfˠˣ\u02e5\u02e6ˎ\u0317\u02f2\u02e7\u02e5\u030c\u02ea\u200c،ˠ\u02f8ˣ\u0315\u02f3\u0310\u030b\u0316ˣ\u02e5\u02e7\u02e6\u02d2ˠ\u200c،ˡ\u02f2\u02e7ˡ\u02e8\u0308\u200c،ˠ\u02f8\u02e9ˉ\u0315\u02f3ˡ\u0316ˣ\u02e5\u02e6\u0318\u02f1\u02f2\u02e7ˤˣ\u030d\u200c،ˠ\u02f8ˣ\u0315\u02f3\u02d2\u0302ˍˍˍˍ\u0315\u02e9\u02ebˠ\u02ef\u200c،\u02e5\u0315\u02ed\u02eb\u02df\u0305\u200c،\u02e5\u0317\u0305\u0308\u200c،\u02df\u02e9ˡ\u0316ˣ\u02e6\u02e7ˠˣˠ\u200c،ˡ\u02f2\u02e7\u02ea\u0305\u02f8\u200c،ˠ\u02f8ˣ\u0315\u02f3\u02d2\u02f3ˮˍˍˍ\u0315\u02f7\u02f6\u02f5\u02df\u030d\u0305ˡ\u02df\u02ef\u200c،\u02df\u0315\u0304ˢ\u0305ˎ\u0305\u02df\u0305ˣ\u200c،\u02df\u0305\u02ff\u02f5\u0315\u030a\u02f8\u02eb\u0305\u0309\u0304ˡ\u0306\u02ebˤ\u02edˡ\u02d5ˍˍˍ\u02d6\u0303\u02e9ˍ\u02f7\u02e6\u0302\u02f1\u200c،\u200c،ˣ\u030fˣ\u02ef\u0301\u0304\u02f4\u02f8\u02eb\u0305\u030a\u0306\u02f3\u200c،ˤ\u0309\u02f2ˠ\u02f2\u0305\u02f1ˍˍˍˍ\u200c،ˢˍ\u030f\u0312\u0316\u0314\u02f1\u0308\u0315\u030b\u030b\u02e9\u02eb\u030dˬ\u02f1\u0315ˉ\u030c\u030e\u0312ˑ\u0314\u02e8\u02e5\u02f8ˍ\u02d2\u0302\u02d6\u02e6\u02d5\u0314\u02d5ˉ\u0312ˎ\u02ff\u02e8\u02eaˏˬˠˬ\u0312\u0304\u030f\u02f4\u02e7\u0314\u0303ː\u030f\u0307\u0304ˠ\u0317\u030d\u02d7\u0314\u0309ˬ\u02e7\u030fˍ\u0302ˮ\u0313ˑ\u02ef\u0302\u02f0\u0312\u0314ˎˣ\u0307\u0300ˬ\u02d2\u0301\u02df\u02d3\u0314ˣ\u0302\u0318ˮ\u02d7\u030b\u02ef\u030bˑˣˎ\u0306ˑ\u02d5\u02f3ˏ\u02ef\u030b\u0316\u02f3ˏ\u0308\u02e7\u0300\u02e5\u0301\u02edˍ\u0301\u02d6\u02e9\u02d5\u02f3\u02dfˏ\u0314ˍˉ\u02f6ˢ\u0302\u02f6\u02f3\u0313\u02f1\u02d3\u02ebˏ\u02eaˮ\u0311\u02e5ˑ\u02d7\u02f8ˤ\u02f3\u030d\u02d6ˬˑ\u02ffˬ\u030a\u02ffˎ\u02d2\u030bˣ\u030c\u0308\u02f3\u030a\u02f8\u0312\u02f4\u0304\u02dfˣ\u02eb\u02d5ˬ\u02f3\u0302\u0317ˣˡ\u030e\u0305\u02f8\u030a\u030a\u02d3\u02f0\u0313\u02d3\u02f1\u02d2\u0300\u030a\u02f8\u02f1\u030cˏ\u02e5\u0315\u0306\u0308\u030c\u0308ˠ\u02eb\u0316\u02f8\u0313\u02ef\u02f3ˍ\u02e8\u02f5\u0314\u02ea\u02ef\u0315ˏ\u02e9\u0310\u02d7ˑ\u0306\u0312\u030c\u0309\u0306ˬ\u02d5\u02f5\u0301\u02d7\u02eb\u0313\u02e6\u02e5\u02ef\u02edˠ\u030b\u0314\u02f6\u0301\u02e7\u02f7\u0311\u02eaˤ\u0316ˢ\u0313\u0313\u02d7ˮ\u02e5ˡ\u0311ˎˮ\u02d7\u030f\u02eb\u02ef\u02d2\u0301\u02d5\u030f\u02e5\u0310\u0305\u0305\u02e5ˉ\u0302\u02df\u030d\u02ff\u0313\u0306\u030d\u02f8\u02d5\u0309\u0308\u02f5\u02f5\u02f3\u02df\u02f0\u02d6\u030eˬˠ\u030a\u0305\u0306\u02d6\u02d2ːː\u02e8\u0311\u02f0\u02d4\u0303\u0307\u0304\u02f4ˬ\u0314\u0302\u02ff\u030c\u0304ˉˑ\u02f8ˑ\u02f8\u02e5\u02f2ˤ\u0301ˣˮ\u0318\u0315\u030a\u02e8\u0308\u02d4\u02ff\u02e6\u02f5\u02f8ˡ\u02e9ˏ\u02f6\u02f0\u030bˮ\u0308\u0304\u02ed\u030a\u02d5\u0300ˬ\u02e7\u02ed\u02e9\u02f3\u030c\u02f5ˬ\u030a\u02f3\u02e9\u0311\u02d4\u030d\u030b\u02e8\u0305\u030d\u02ed\u02eb\u0309\u02df\u02f2ː\u0318\u0317\u030e\u02f2\u0315\u0308\u0318\u0310ˤ\u0318\u030a\u02d4\u02f1\u02df\u02f2\u02e8\u02d4\u02f0\u02e8\u02d5ˍ\u0309\u0311\u02e8ˎ\u02d3\u030c\u02d7\u0313\u0307\u0304\u02f4\u02f0ˣ\u02f7ˠˢ\u0304\u02e7\u030c\u02f7ˎ\u02e9\u0313\u0307ˉ\u02e6\u02f2\u0309\u02f3\u02d2ˬ\u0305\u0307\u02f6\u02d6\u02f7\u0316\u02e6\u02df\u0300\u02e5ˣˬ\u02ffˑ\u02e6\u02f0ˏˤ\u0303\u0306\u02f5ˡ\u0306\u02f0\u0305\u0301ˏˮ\u030c\u0309\u0313ˎ\u0301\u02d6ˑˬˉ\u030dˡ\u02f7\u02f2ˢ\u02e8\u02e9\u02e5\u0306\u0308\u030d\u02df\u0313\u0310\u0302ˉ\u0302ˠˎ\u02f3\u02d6\u02f7\u0311\u0317\u030d\u0304ˤ\u02f6\u0317ˤ\u02dfˬ\u0311\u02f5\u0315ˮ\u02f7\u0309ˣ\u0305\u0317\u02f8\u0316\u0314ˍ\u02d3\u0303\u030e\u02d5\u02f6\u0315\u02d7\u02f6\u02d6ˬˑ\u0314\u030e\u0311\u02e5ˤˬ\u02f4ː\u02d3ˑ\u0310\u0306ː\u0306\u0318\u02d5\u02ed\u0306\u02ef\u030f\u0307\u030e\u02d6\u0314\u0300\u030dˏˢ\u0305\u030a\u02e5\u02f5\u0301\u0303\u02e8\u0316\u02f5\u0308ˠ\u0314\u02d7ˎ\u02e7\u02d4\u0301\u02ff\u02e8ˬ\u0314\u02f5\u02f6\u0304\u02f8\u0309\u0313\u02e6\u02d2ˉ\u02f7\u02f1\u0308\u0310ˬˮ\u02d2ˎˎ\u0300ˡˤ\u02f5\u0308\u030a\u0318\u02f4\u02df\u0306ˉˠ\u0318\u0314ˢː\u030a\u02f7ˬˉ\u0308\u0310ˍ\u0300\u02f0\u030b\u0315\u0318\u030c\u0314\u02f0ˉ\u0303\u0314\u0315\u02d5\u02ef\u0307\u030d\u02eb\u030fˡˬ\u030eː\u02d5\u02df\u02eb\u0318\u02f8\u02df\u02efˏˍ\u030c\u0301\u0314\u0307\u02f8\u02d2\u02f7ˣ\u02eaˢ\u02f1\u02f1\u0308\u02f5ˬ\u02d3\u02f5\u0315\u0305ˠ\u0309ˑ\u02d3\u0302ˍˍ\u02e9\u030e\u02ed\u02ed\u02f5ˣ\u0307\u0300ˎ\u02ea\u0301\u0300ˠ\u0312ˏ\u0303\u02f1\u02d5\u0313\u030c\u0317\u0310\u0310\u0313\u0317\u02f6\u02d3\u02d2\u02f0\u02f7\u0304\u02eaˠˉ\u02d2ˉˍ\u02e7ˑ\u0305\u030f\u02eb\u030e\u0313\u0317\u0309ːˎ\u0307\u02d2\u030f\u02f4\u0312\u02f7\u02efˢˑ\u02d2\u0312\u02d6\u030f\u0310\u0316\u030c\u0309ˏ\u0302\u0313\u02ed\u0312\u02d2\u0313\u02e5\u0302\u02e5\u02d3ˬ\u030f\u0313\u02f6\u02e5\u0315\u02f6\u02f4\u030f\u0305\u02ff\u030dˑ\u02d7\u0315\u0300\u030b\u02e5\u02f4\u02e5\u02ffˉ\u02e8\u030f\u02f0\u02edˠ\u02d5\u02f2\u02e9\u02d3\u0301\u02f8\u02d2\u02e6\u02ef\u0312\u02f4\u02d2ˣˣ\u02f8\u0306\u02f1\u02eb\u0306\u02e5ː\u0302ˍ\u030a\u0308\u0312\u02ed\u02e8\u0305\u02e6\u030b\u0302\u0312ˡˢ\u0314ˎ\u02f2\u030f\u02e8\u0315\u02e5\u02d5\u0311\u02eaˡˠ\u02e6\u0312\u0308ˢ\u02ef\u02d7\u02e6ːˎ\u02ea\u0314\u0318\u02df\u0316\u030f\u0303\u02d5\u02f3ˢ\u0316\u0302\u0313\u0303\u02e9\u02ea\u0300\u0305\u02f1\u02e6\u030cˎ\u0303ˬ\u0308\u02d4\u02e8\u030d\u02d7\u02e9\u02df\u02f0ˤ\u02ea\u02f6\u0309ˉˑˢ\u0309ˬ\u0315\u030c\u02eb\u030f\u02ea\u02f2\u0306\u02f8\u02e8ˠ\u02f4\u0306\u02f0\u0300\u0304ˡ\u030e\u02eb\u030d\u030a\u02ea\u0316\u0308\u02f7\u02f0\u02e5\u030d\u02f1\u0317\u0303ˣ\u0300\u02f8\u02e6\u0308ˣ\u02e7ˬˠ\u02ef\u02f3\u02d3\u0308\u0304\u0310\u0303ˎ\u030a\u0301\u0317\u02d7ˬ\u0314\u0303\u030f\u02d7\u0309\u0314\u0316\u030bˠ\u030e\u02f6\u02f7\u02d7\u02f6\u02ff\u0315\u02d5\u02d6\u02d3\u030bˤ\u0308ˍ\u02ebˡˡ\u02ebː\u02f7\u0313\u0303\u02ff\u0315\u030c\u02f5\u0317\u02ff\u02f1\u02e7\u02f8\u02f0ˉˣ\u02ff\u030b\u02f4\u02f0\u030d\u02e6\u0312\u0314\u02f8\u0312\u02f3\u0309\u02ff\u02f8\u0301\u0317\u02d4\u030a\u0304\u0314\u02e9\u0310\u02f4\u0312\u0313\u0305\u0301\u02df\u0301\u02d4\u02f1\u02ed\u0316ˣ\u0312ˬ\u02f4\u02df\u02f0ː\u02d3ˏ\u0316ˉ\u02d4ˡ\u0304ˤ\u0303ˢ\u030a\u02df\u0314\u0302\u030dˮ\u030b\u030d\u030d\u02df\u0313ˑ\u030cˠ\u02f4\u030f\u02f4\u0317\u02ed\u0307\u030a\u0308\u030b\u02d7\u0303\u02e5\u0306\u02ef\u0308\u0305\u02e6\u02e9\u02d4\u0307\u02d5ˤ\u030b\u0310\u02f7\u02d5ˑ\u02f5\u02d4ˠ\u02e6\u0303ˮˣ\u02f3\u0312\u02d7\u02d3\u0308ˬ\u02f6ˑ\u0305\u02e9\u02d7\u02df\u02e8\u0313\u02f8\u02ed\u030b\u030d\u0318\u0302\u030e\u02ef\u02e5\u030f\u0314\u02f2ˢ\u02eaˢ\u0301\u02e5\u0316\u0300\u0316\u02ea\u0306ˉˢ\u02d2\u0306ˠ\u02ef\u02ffˎ\u02ff\u030d\u02f0\u02e6\u02f2ˮː\u0309ˍ\u030a\u02df\u02e9\u02d2ˮ\u02eb\u02eaˣ\u0313\u0300\u0301\u02d7\u02ed\u0305\u02e5\u0303\u030a\u030f\u02d2ː\u0301\u02f5\u02f4\u0317\u02e5\u02f1\u0303ˬ\u0304\u0308\u030c\u02f8\u0310\u02d6\u02f8\u0303\u0310ˤˏˢ\u0316\u0308\u0314\u0301\u02f6\u0315\u02f2\u02f2\u02e8ˏ\u02d4ˣˎ\u030d\u02f4\u0300\u0312\u030cˑ\u02df\u02d5ˉ\u030e\u02d2\u0312\u0302\u02d2\u02f8ˍ\u0315\u02f8\u02f4\u02f5\u02d4\u02f4\u0315\u02d4\u030c\u02f4\u02e9ˠˣ\u0315\u02eb\u0303\u02f1\u02ef\u02f7\u02ed\u0315ˮ\u0305\u02d4\u030a\u0316ˑ\u02e6\u02d3\u030e\u02d5\u0316\u030f\u02ea\u0316\u0318\u030b\u0301\u0307\u02d2\u02f5\u0315\u0312ˎ\u0304\u02eb\u0310ˮ\u0316ˑ\u02e8ˉ\u02ed\u030cˣ\u030d\u0304\u0309\u02f7\u02f6\u0318\u02f8ˤ\u02f2\u02e5\u02f2\u0307\u030fˣ\u0302\u02d7\u0310ˎ\u030e\u030d\u02d3ˉˮ\u0302\u0305ˮ\u0302\u02e7ˏˣ\u0305\u02e6ˏ\u02f1\u02ebːˉˎ\u0309\u02d5ˡ\u02eb\u02e5\u02e5\u02d6ˡ\u02ef\u02f3ː\u02d2ˣˠˤ\u0300ˏˎ\u0315\u030cːˉ\u02df\u02eb\u0307\u030f\u030c\u02f5ˡ\u02f7\u02f7\u0303ˤ\u02f3\u02d7ː\u02f6\u0316ˤ\u02f1ˑ\u0309\u0306\u030e\u030b\u0311\u0317\u02e9\u030f\u02d6\u02d7ˤ\u02f4\u02f8ˢ\u02f2\u0308\u02d6\u02ff\u0317ˉ\u0303ˢ\u02e5\u0302\u0301\u02df\u02e8\u02ea\u02e8ː\u02ff\u02d7\u02f2\u02e7\u02dfˬ\u030e\u02f8\u02f1\u02d3\u02e6\u02f2\u030c\u0304\u0312\u0304\u02d5\u0310\u02f2\u02e5\u0303\u0304\u02f3\u030f\u030f\u0300\u0302\u0318\u0316\u02f8\u0308\u030c\u02eb\u0308\u030c\u02eaˣˍ\u0304\u0303ˏ\u030e\u02ff\u0300\u02f8\u02d4\u0310\u02dfˣ\u030e\u02e9\u02f7\u0307\u02f1ˑ\u02d3\u02e6ˮ\u02f1\u0311\u0304\u0308ː\u02f6\u02f8\u0305ˮ\u030c\u02f3\u0300\u0305\u0318\u0302\u030c\u0313ˣˢ\u02d4\u0302\u030a\u0303\u0308\u0308\u0314\u02ea\u02f2\u02f5\u02d6\u0308\u0301\u02d2ˡ\u0307\u02f5\u0307\u0303\u030a\u02f1\u0300\u030b\u030bˬ\u02e9\u02d4\u02e9\u0300\u0307\u02e8\u030d\u02e6\u02f8\u0304\u0306\u0316\u030f\u0306\u0315\u02ffˑ\u0305ˎ\u0309\u0310\u02d2\u0302\u02f6\u02e7ˠ\u02f6\u030b\u02f0ː\u030f\u02e6\u02d7\u0308\u02ed\u02d6\u02eb\u02e5\u02f0\u02f5\u0303\u02ff\u0306\u02e6ˏˬ\u02d2ˠ\u030fˡ\u030b\u02d6\u02ea\u0309\u0308\u0303\u0316\u02ea\u02ef\u0317\u0316ˑ\u02ed\u02f3\u02e8\u030f\u02f2\u02eb\u02f3\u0313\u0304\u02d2\u02ed\u02f6\u02f7\u0317\u0313\u0308\u02ff\u0311\u0303\u02e9\u0308ˎˠˠ\u0301\u02eaˮ\u02edː\u02df\u02f6\u030cː\u02ef\u02d5\u030e\u0312\u030e\u030b\u02f4ː\u02ef\u030f\u02d7\u0308\u0310\u02ff\u02f2\u0313\u02edˑ\u0300\u02f0\u0308\u02e7\u02f7ˤ\u0315\u0316\u030c\u02e9\u02df\u02e7ˉ\u0302\u0303\u0304\u030d\u0318\u0307ˣ\u02e8\u02f3\u0300\u02ed\u030d\u02f2\u02f0\u0318\u02d2\u02f7\u0315ˣ\u02ea\u02d3\u030b\u02d5\u030a\u0307\u0316ˤ\u030c\u02eb\u0314\u02f3\u02d3\u02f4\u02f6\u02e8ˡ\u02e9\u0309\u030a\u0313\u02e6ˏ\u02f3\u02ea\u030f\u02f6\u0300ˮ\u02e7\u0318\u02f3\u02d2\u0317\u030e\u02f0\u0308\u0314\u02f0ˏ\u0310\u02f4\u02d5\u02e6\u02eb\u02d2\u02d5\u0305\u02e5ˢ\u0311\u02f3\u02ebˢˣˍ\u02f4ˍ\u030bˍ\u02d5ˉ\u02f4\u02d2\u0307ˬ\u0305\u02eb\u0309\u0315ˍ\u02df\u02e8\u030b\u030f\u02d4\u02f4ˡ\u02f8\u0309\u02f8ˣ\u0313\u02e8ˠ\u02e8ˣ\u0305\u02eb\u02ed\u02f6\u02d2ˣ\u02f2\u02e6\u0305\u0311\u02f5\u0310\u0311\u0310\u0312ˬ\u02e7\u02f1ˉ\u0318\u02eb\u030bˏˬ\u0305\u02f4\u0310\u02edˠ\u02e7ˠ\u02eb\u02d2\u0302ˣ\u0313\u02d5ˏˢˠˬ\u02e6ˍ\u02e5ˣ\u030e\u02f0\u02f5\u0317\u0300\u030d\u0309\u0314\u0307\u02f2ˍ\u0317\u0315\u0303\u02f0\u02e6\u030b\u02ea\u02ff\u030a\u02d6\u02d6\u02f2\u030a\u0300ˡ\u0310\u02ffː\u0305ˤˬ\u02ea\u0316\u02f5\u0316\u02e6\u0313\u02d5\u0315\u0313\u0311\u02d3\u0317\u0312ˏ\u02d5ˢ\u02e8\u02f8\u030d\u02f8\u02d7\u02d3\u02e5\u02d2ˣ\u02d6ˤ\u02df\u0314\u02f5\u030b\u0302\u02d4\u02f5\u02ebˮ\u02f7\u02f5\u030b\u0302\u030a\u030d\u0315\u02f3\u02d3\u0316ˑ\u02d6\u02e8\u02f0\u0309\u0301ˉ\u02d4ˡˮ\u02ed\u02f8ː\u0314\u02f8\u02e6\u02ff\u0304ˍˏ\u02ff\u0311\u02f4\u030c\u02eb\u02e6\u02df\u0300ˠ\u02d2\u0303\u0318\u02ff\u02d7\u030e\u0305\u0301ˉ\u030e\u02e5\u030a\u0316\u02d3\u02d2ˬ\u030d\u02ed\u02ff\u0311\u02d5\u0315\u02e7\u0316\u030a\u02f0\u02eb\u02f6\u02df\u02d5ˮ\u02f1\u030f\u030b\u0308\u02eb\u0309\u02f6\u02d6\u0317\u02f0\u02f4\u02e5ː\u0316\u02e6\u02d3\u02e5\u0304ˑˬ\u02d7\u0305\u0302\u030f\u030dˡ\u02e9\u030eˣ\u02eb\u030d\u0313\u030aˢˣ\u0300ˑ\u0307\u02f6\u02eaˑˏ\u0302\u02df\u02e5\u02d4\u0303ˤ\u02f1ˑ\u0302\u02d6\u02e8\u0301\u02d3\u02d5\u0315\u0308\u02d4\u02ffˤ\u02d6\u02f4\u0314\u02d3\u0312\u0313\u0305\u02e7\u02f3ˍˡˍ\u02d7ˑ\u02d4\u02eb\u030c\u0314\u030b\u02e6\u02f0ˍ\u02d4ˉ\u0303\u02f5ˢ\u02d6\u02d2\u02e7\u02e5\u02d3\u0306\u0300\u02f5\u0310\u02f8ˎ\u02f0\u02d2\u02efˠ\u02ed\u02d5\u0304\u0316\u02ef\u0316\u02d3\u0309\u02d4\u02ff\u02eaˡ\u030c\u02e8\u02eb\u030e\u0300ˢˍ\u02e6\u0304\u0303\u02f5\u030f\u02d2ˉ\u02e5\u0315\u02f6\u02eaˤ\u030f\u02f7ˤˣ\u02ed\u02d4\u030c\u02ebˍː\u02dfˠ\u02ed\u02e7\u02ff\u0315\u0308\u02ff\u0305ˣˎ\u0306ˉ\u02ff\u02ff\u02d3\u0305\u0304\u02f8\u02f8ˑ\u02d7\u02edˢ\u0307\u02d2\u02f0ˡ\u0315\u0313ˑ\u02f5\u02d3\u02e9\u030f\u0305\u0310\u0312\u02f1\u02d2ˢ\u0314\u02f4\u0316\u0313\u0307\u02d2\u02d4\u02f8\u0318\u02ff\u0302\u0303\u0313\u0312\u0303\u0302\u02efˤ\u02f8\u02f2\u0304\u02e9\u0317ˉ\u0312\u02f1\u02f5\u02d4\u0301ˠ\u030d\u02e8\u02ef\u030c\u02e6\u02eb\u0303\u02eb\u02e5\u02e7\u02ef\u02d2\u02e7\u030cˣˠ\u0302ˤ\u02f3ˑ\u0318\u02ea\u0310\u02d2\u02d4\u0318\u0300\u0315\u0312ˣˡˉ\u030c\u02f5\u02f4\u02f3\u0311ˠ\u0308\u0300\u030c\u0306\u0300\u0300\u0302\u02ea\u02e5\u02ef\u0307\u02e6\u02e7\u02ef\u0310ˠ\u0318\u02d5\u02e9\u02f4\u0301ˢ\u030e\u0302\u0313\u02f4\u0317\u02eaˤː\u0312ˢˬ\u0318\u0307\u02e8\u02e8\u0303\u02eaˣ\u0307\u02d6\u0302ˤ\u0307\u0303ˤ\u02edˣ\u0311ˮ\u02d3\u030a\u02e5\u0301\u0310ˤ\u02e9\u0313\u02eb\u02e6ˏ\u030fˬ\u0308\u030d\u030b\u0300\u02f2\u030cˮ\u02e6\u02edˏ\u02dfˤ\u0308ˎ\u02dfˉ\u02f3\u02f0\u030fˮ\u030a\u02eaˬ\u030d\u0300ˤˎ\u0312\u02e6\u02ff\u0314\u02f1\u0310\u0315\u0306\u02f2\u030aˢ\u0303\u02f3\u02e9\u0313\u0307\u0305\u02f8ːˮˡ\u02f0ˏ\u02d4ˍ\u02f4ˮˎ\u0301ˤ\u0312ˮ\u02f7ˑ\u0310\u0315\u0312\u0307\u0305\u0301\u0308\u0316ˑˑ\u030a\u02e5\u0303\u02f6\u02d3ˤ\u0303\u0318\u02dfˎ\u02d6\u02f8\u02d2ˍ\u030b\u02f3ˉ\u02f6\u02e9ː\u02e9\u0304\u0313\u0314ˡ\u0306\u0314\u030f\u02f3\u02f3\u030eˍ\u02ef\u02d4\u0305\u02d7\u030d\u02ef\u0305\u0312\u0317\u030e\u02d7\u0310\u02ffːˏ\u0314\u02d2ˬ\u0313\u02e6\u0301\u0310\u0313\u02e6\u030a\u0313\u0300\u030c\u030cːˎ\u0309\u0302\u02dfˏ\u0308\u0302ˮ\u02eb\u0317\u02d4\u02f6\u02f6ˤ\u030c\u030e\u0301\u02e8\u0314\u0316\u02d2\u030b\u0306\u02ed\u02ed\u02e5ˑˎ\u030a\u0309ˑˬ\u02e7\u02f8\u0313ˏ\u030e\u0303\u02e7\u0306\u0310\u02efˮ\u02f0\u030d\u02f0\u02f1\u02f5\u0312\u0309ˤ\u02f1\u02d6\u02e5\u02f2\u02d5\u0306\u0315ˣ\u0315ˍˤ\u0302ˮˎ\u0301\u02f1\u02d6\u02ff\u030aˉˉˮˑ\u0318\u02f3ˡ\u02f4\u02f2ˤ\u02f4\u0301\u02f7\u0307ˉ\u02d7\u0305\u02e6ˠˣ\u02d4\u030d\u02d3ˮ\u02ef\u02f6\u02ff\u0314ˠ\u030b\u02e7ˮˍˮˠ\u02ea\u02f8\u02e9\u02f4\u02eaˮ\u02f7\u02ed\u02eb\u02e8\u0314\u0305\u0309\u02f6\u0312\u0308ˣˬ\u0306ˮˮ\u02f0\u02ebˏ\u02e8ˣ\u030eˉ\u0308\u0315\u02f6\u02f7\u030e\u02f3\u02e5ˬˠ\u0312ˉˣˮ\u0302ˮ\u02f0\u0305ˍ\u02f8ˑˍ\u0312\u0302\u02f8\u0302\u0310\u0312ˍ\u0307\u0301\u0316\u02e5\u0316\u030c\u02f4ˤ\u02d2\u02f2\u0307\u030e\u02d7\u02e5\u02ff\u0301\u0301\u02e7\u0302\u02f1\u02ef\u0318\u02df\u02d5\u0305\u02f8\u02e5ˣː\u0313\u02dfˤ\u02eb\u0303\u0312\u0307\u0315\u0307\u02f6\u0312\u02f0\u02d7\u02e9\u02ed\u0311\u02f4ːˢ\u02f5\u02e8ˤ\u0305\u02f4\u02d6\u030e\u02f8ːˏ\u030f\u02d4\u02d4\u02d2ˮˤ\u02e9ˑˑ\u02eb\u02f0\u0308ˢ\u0315\u02e7\u0308\u0318\u02f3ˏ\u030b\u0303\u02d3ˢː\u02e9\u02d6\u02ef\u02f1ˑ\u02e8ˬˎ\u02e9\u0307\u0316\u02f3ˏ\u030b\u0304\u02d6\u030aˮ\u02f7\u0308\u02ff\u0302ˤ\u02eb\u0303\u0304\u02f3ˮ\u0318\u02d3\u02d2\u0314\u030b\u0306\u0313ˮ\u030bˎ\u02e8ˬ\u02e8\u0317\u02f4\u0307\u030eˣ\u0313\u02e8\u0304ː\u02dfˣ\u02e6\u02f1\u030bˮ\u02f1\u030b\u02f0\u0314\u0309\u0303\u02d6\u02f1\u02f5\u0313\u0301\u02f7\u0310\u02ff\u02d6\u02f6ˉˏ\u0313\u02d7ː\u0312ˬ\u02e9\u0316ˬ\u02f1ˑˏ\u0311\u0316\u02d2ˤ\u0317\u02ea\u02d6\u0303\u02f7\u0311\u02f2\u0318\u02d3\u030f\u02ea\u02d5\u02d6ː\u02e7\u0300\u02e7ˡˢ\u02d7ˮ\u02e8\u0303\u02f8ˢ\u0317\u0311\u02df\u02e5\u0318\u02f4ˍ\u02d2\u02f7ˠ\u0309\u0318\u0307\u02f0\u02df\u02e5\u030fˏ\u0308\u0315ˠ\u030f\u0316\u030e\u030eˬ\u02d5\u02f4\u02e8\u0303\u0302ˏ\u0300\u02f0\u02f6\u02d5ˬ\u02e9\u030eˤ\u02e6ˮ\u02f0\u02f2\u0315\u02f7\u0313ˬ\u02f1\u02f8\u030b\u030b\u02f4ˉˍ\u0305\u02e5\u030a\u02e7ˤ\u0304\u02d2ˎ\u02ff\u0303ˡ\u02d4\u02e8\u02eb\u0306\u0316\u0318\u030a\u02f6\u0307\u0312\u02ff\u0309\u0304\u0305ˣˡ\u0318\u02d2\u02df\u030dˬ\u0317ˢ\u030b\u02e8\u02d6\u02edˠ\u0305\u0308\u0316\u0310\u02f3\u02ef\u0301\u02ff\u0302\u030c\u0300\u02d4\u02d2\u02ef\u0306\u02eaˎ\u0312\u02df\u02ed\u02ed\u030b\u030c\u02f8\u02ff\u0306\u030b\u0314\u0314ˠ\u0311\u02e8ˏ\u02d6\u0309\u0310\u02f1\u02eb\u0317\u030f\u0305\u02f4ˉ\u0318\u030bˍ\u030e\u02ff\u0308\u02eb\u02d7\u030b\u02ed\u0314\u0300\u0305ˤˬˎ\u0311\u02d4\u02ff\u0316\u02e8\u0310\u02ed\u030b\u030b\u02d4\u02e5\u030b\u02e9ˑ\u030d\u030d\u02df\u02ed\u02d3ˏ\u030e\u0313ˑ\u030d\u02ef\u030b\u0311ː\u02f8\u0302ˮ\u0306\u0312\u02ed\u0312\u02ea\u02d5\u0301\u030a\u0312\u0317\u02d4ˑ\u02d3\u02e8\u02ef\u0311\u0312\u030aˡ\u02eb\u02d7\u02e7ˣˬ\u0313\u030d\u02f5\u0310\u0300\u030d\u02df\u0303\u0308\u0304\u02d4\u02f3ˠ\u02d5\u02f7\u0305\u0304\u0317\u02f8ˍ\u02e7\u030c\u02d6\u02df\u02f0\u0304\u02f0\u0301\u02e7\u030c\u02d3\u02df\u02f0ˮ\u030e\u02e8\u02e5ˑ\u02e7\u200c،ˣ\u02e8\u02f2\u02f1\u0309\u02e7ˠ\u200c،ˣ\u200c،\u200c،\u200c،\u02df\u0315\u200c،\u02dfˠː\u02eb\u0307\u02d2\u0315\u02ea\u0308\u02f3\u0315ˬ\u0318\u02e7ˑ\u200c،\u200c،\u200c،\u02ef\u02df\u02ff\u200c،\u200c،ˮ\u02ef\u02e5\u200c،\u02df\u0308\u0304\u0305\u200c،\u02f6\u02df\u0301\u200c،\u02ed\u02efˤ\u200c،\u02df\u0308\u02f3ˑ\u02f0\u0317\u02ff\u02f5\u02d3\u030c\u0301\u0315\u200c،\u200c،ˠ\u02dfˢ\u02ef\u200c،ˣ\u200c،\u200c،ˡˬ\u02e6\u02f4\u02f3\u030aˣ\u200c،\u200c،\u02f3\u02dfˎ\u200c،\u02df\u0315ˣ\u200c،\u02df\u0308\u02ef\u030b\u0316\u0314\u02f7\u0305\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u02e7\u200c،\u02df\u030e\u02f6\u030a\u02ef\u02e7\u030dˡ\u02f0\u02d2\u200c،\u02dfˢ\u02d4\u02df\u02f2\u02eb\u02dfˤ\u0305\u200c،\u02df\u02ef\u200c،\u02dfˢ\u200c،\u200c،\u02df\u02ea\u200c،\u200c،ˡ\u200c،\u200c،ˠ\u030d\u200c،\u200c،\u02e7\u200c،\u200c،\u02eb\u200c،\u200c،\u02dfˎ\u200c،\u200c،ˢ\u200c،\u200c،ˤ\u200c،\u200c،\u02df\u02f3\u200c،\u200c،ˢ\u200c،\u200c،\u02df\u02ef\u200c،\u200c،\u02ef\u200c،\u200c،ˣ\u200c،\u200c،ˢ\u02ef\u200c،\u200c،\u030d\u200c،\u200c،ˬ\u200c،\u200c،\u200c،\u02dfˠ\u200c،ˣ\u200c،\u200c،\u200c،\u02df\u02f7\u02df\u02f4\u0315\u02df\u0307\u200c،\u02f7\u02df\u02f6\u02dfˠ\u0310\u200c،\u02f7\u02df\u030b\u0315\u02df\u0307\u200c،\u02f7\u02df\u030d\u02ef\u02df\u0307\u200c،\u02f7\u02df\u0316\u0305\u02df\u0307\u200c،\u02f7\u02dfˏ\u02efˢ\u0301\u200c،\u02f7\u02df\u02d3\u0305ˢ\u0301\u200c،\u02f7\u02dfˉ\u02ef\u02df\u0307\u200c،\u030d\u02dfˍ\u0305\u02df\u02e8\u02df\u02ef\u030d\u02df\u02e6\u0315ˣ\u02e8\u02df\u02ef\u02f7\u02df\u02ea\u0315ˣ\u0307\u200c،\u02f7\u02df\u02f3\u0305ˤ\u0300\u02df\u02ef\u02f7\u02df\u0304\u02ef\u02e5\u02e8\u02df\u02ef\u02d2\u02df\u030c\u02dfˣ\u030e\u200c،\u02f7\u02df\u030d\u0305\u02e5\u02e8\u02df\u02ef\u02d2\u02df\u0310\u02dfˣ\u030e\u200c،\u02d2\u02df\u0311\u0305ˣ\u030e\u200c،\u02f7\u02df\u0313\u02ef\u02e5\u02e8\u02df\u02ef\u02f7\u02df\u0316\u02efˣ\u0307\u200c،\u02f7\u02dfˑ\u02dfˣ\u0307\u200c،\u02f7\u02dfˉ\u0305ˣ\u02e9\u02df\u0305\u02f7\u02df\u02e5\u0315\u02e7\u0309\u02df\u0305\u02f7\u02df\u02f4\u0315\u02e7\u0309\u02df\u0305\u02f7\u02df\u0301\u02df\u02e7\u0307\u02dfˠ\u02e7\u02df\u0302\u0305\u02e7\u02d2\u02dfˠ\u02e7\u02df\u0308\u02ef\u02e7\u02d2\u200c،\u02f7\u02df\u030a\u0305\u02e7\u0307\u200c،\u02f7\u02df\u02d3\u02ef\u02e7\u0307\u200c،\u02f7\u02df\u02e5\u0305\u02eb\u0306\u02df\u0315\u02f7\u02df\u02f1\u02df\u02eb\u0307\u200c،\u02f7\u02df\u02f4\u0305ˬ\u0309\u02df\u0315\u02f7\u02df\u0305\u02ef\u02eb\u0307\u200c،\u02f7\u02df\u0307\u02dfˬ\u0300\u02df\u02ef\u02f7\u02df\u02d6\u02dfˮ\u02d4\u02df\u0315\u02f7\u02df\u02eb\u02df\u02ef\u0307\u200c،\u02f7\u02df\u030a\u02df\u02f0\u0310\u200c،\u02f7\u02df\u0312\u02df\u02f0\u0310\u200c،\u02f7\u02dfˎ\u0305\u02ef\u0309\u02df\u0305\u02f7\u02df\u02d4\u02ef\u02ef\u0309\u02df\u0305\u02f7\u02dfˠ\u0305\u02f3\u0309\u02df\u0305\u02f7\u02df\u02e8\u02ef\u02f3\u0309\u02df\u0305\u02f7\u02dfˮ\u0305\u02f3\u0309\u02df\u0305\u02f7\u02df\u02f4\u0315\u02f3\u0309\u02df\u0305\u02f7\u02df\u0301\u0305\u02f3\u0309\u02df\u0305\u02f7\u02df\u0308\u02ef\u02f6\u02d4\u02df\u0315\u02f7\u02df\u030d\u02ef\u02f6\u02d4\u02df\u0315\u02f7\u02df\u0310\u0315\u02f3\u0309\u02df\u0305\u02f7\u02df\u0318\u02df\u02f4\u0310\u200c،\u02dfˠ\u200c،ˠ\u02ed\u200c،\u200c،\u200c،\u02dfˠ\u200c،ˣ\u200c،\u02ef\u02df\u02ef\u02df\u02ea\u0311\u02df\u0315\u200c،\u02f4\u200c،ˣ\u200c،\u0305\u02df\u02ef\u02df\u02ef\u200c،ˑ\u0305\u02ea\u02f0\u02df\u02e6ˣ\u200c،\u0315\u02df\u02e7\u200c،\u02dfˠ\u200c،ˢ\u0314\u02df\u0312ˣ\u02dfˤ\u02ef\u02dfˢ\u200c،\u0305\u02dfˣ\u02dfˣ\u200c،ˮ\u030dˡˎ\u02efˠ\u0316\u200c،\u02f3\u02dfˡ\u200c،\u200c،\u02ef\u200c،\u02df\u02ef\u02eb\u200c،ˠ\u02f3\u02dfˠ\u02ef\u02df\u02e7\u200c،\u02f3ˠ\u200c،\u02df\u02d6\u02df\u0315\u200c،ˤ\u02ef\u02dfˤ\u200c،\u030d\u02dfˣ\u0315ˣ\u200c،ˡ\u02f3ˣ\u200c،ˠ\u0316\u200c،\u0309\u02dfˣ\u0305\u02dfˤ\u02df\u02ef\u200c،\u02e9\u02ef\u02ef\u200c،ˠ\u02f3\u02dfˡ\u02ef\u02df\u02f1\u200c،\u02f3ˠ\u200c،ˠ\u02edˠ\u200c،\u02dfˤ\u02ef\u02df\u02e8\u02dfˠ\u02ef\u200c،\u02dfˣ\u200c،ˣ\u02dfˢ\u200c،\u02df\u02f4\u200c،\u0309\u02dfˤ\u0315\u02df\u02f2\u02df\u0301ˎ\u02df\u02e6\u0315\u02df\u02f2\u02dfˬˣ\u02df\u02e7\u0315\u02df\u02f2\u02df\u0304\u02f7ˡ\u02e8\u0315ˣ\u02f2\u02dfˮ\u02f7ˠ\u02e7\u0315\u02df\u0316\u02dfˣ\u02dfˢ\u02f5\u0305ˣ\u0316\u02dfˢ\u0305ˢ\u02f5\u0305ˣ\u0316\u200c،ˣˢ\u02f5\u0305ˣ\u02f2\u02df\u02f3\u02efˢ\u02f6\u0305ˤ\u02ef\u02e7\u200c،\u200c،\u02dfˡ\u02f0\u02e5\u02ea\u02ef\u02df\u02e5\u0315\u02dfˠ\u02df\u02e7\u0305\u0305\u200c،\u200c،\u02df\u02e8\u02f7\u02df\u02ef\u0315ˤ\u0301\u200c،ˣ\u02df\u0316ˡ\u02e7\u200c،\u200c،\u02df\u030a\u0305ˠ\u0313\u02df\u02f7ˎ\u200c،\u0305ˠ\u0315\u02e8\u200c،\u200c،\u02dfˡ\u02f0\u02dfˮ\u02f7ˠ\u0318\u0315\u02dfˣ\u02df\u02ea\u02ef\u030b\u200c،\u200c،\u02df\u02e8\u02f7\u02df\u02ef\u02df\u02ea\u0316\u200c،\u02ef\u02df\u02f4ˡ\u0301\u200c،\u200c،\u02df\u030a\u0305ˡ\u030c\u02df\u0307\u02dfˠˠ\u0305ˡ\u0309\u02e9\u200c،\u200c،\u02dfˡ\u02e5\u02e5ˮ\u02eb\u02df\u02f5\u200c،\u02e8\u02df\u02ea\u02ef\u030d\u200c،\u200c،\u02dfˠ\u02eb\u02df\u0318\u02ef\u02dfˉ\u02df\u02ef\u0309\u02df\u02d2ˡ\u0309\u200c،\u200c،\u02dfˣ\u0315\u02df\u02d2\u02dfˏ\u02ebˠˡ\u02efˡ\u0305\u02e9\u0305\u200c،\u200c،\u02df\u02f2\u02dfˮ\u02f7ˠ\u0308\u0305ˣ\u02e8\u200c،\u0305\u0312\u200c،\u200c،\u02dfˠ\u02eb\u02dfˎ\u02efˡ\u0307\u02df\u02ef\u0309\u02dfˍˡˎ\u200c،\u200c،\u02dfˣ\u0315ˢˬ\u02df\u02eb\u02ebˠˡ\u02ef\u02df\u0309\u02ea\u0315\u200c،\u200c،\u02df\u02f2\u02dfˮ\u02f7ˡˑ\u0305ˣ\u02e8\u02df\u02ea\u02ef\u0315\u200c،\u200c،\u02dfˠ\u02eb\u02dfː\u02dfˮˉ\u02df\u02ef\u0309\u02df\u0314ˢˣ\u200c،\u200c،\u02dfˣ\u0315ˢ\u0314\u02df\u0306\u0305ˡˡ\u02efˡ\u02e7\u02eb\u0305\u200c،\u200c،\u02df\u02f2\u02dfˠ\u02d2ˣˬ\u02df\u02e7\u02e8\u02df\u02e9\u0315\u0318\u200c،\u200c،\u02df\u02e8ˣ\u02f7\u0312\u200c،\u0300\u200c،\u0309\u02df\u0314ˢ\u02ef\u200c،\u200c،\u02dfˣ\u0315ˢ\u02f0\u02dfˤ\u0311ˡˡ\u02efˢ\u02dfˬ\u02ef\u200c،\u200c،\u02df\u02f2\u02df\u02ebˎ\u02df\u0302\u02ef\u02e7\u02e8\u02df\u02ea\u0305ː\u200c،\u200c،\u02dfˠ\u02eb\u02df\u0318\u02efˡ\u02f0\u02df\u0305\u0309\u02df\u030bˢ\u0301\u200c،\u200c،\u02dfˣ\u0315ˢː\u02df\u030f\u0311ˡˡ\u02efˡ\u030d\u02ed\u200c،\u200c،\u200c،\u02f2\u02dfˢ\u0305ˢ\u0312\u02ef\u02e7\u02e8\u02df\u02eb\u02ef\u02d3\u200c،\u200c،\u02dfˠ\u02eb\u02df\u02ed\u02dfˮ\u02eb\u02df\u0305\u0309\u02df\u0316ˢ\u030d\u200c،\u200c،\u02dfˣ\u0315ˢ\u02f0\u02df\u02ed\u02dfˡˡ\u02efˢ\u02df\u02ed\u0315\u200c،\u200c،\u02df\u02f2\u02df\u02ebˎ\u02df\u02d5\u02df\u02e7\u02e8\u02dfˬ\u02df\u02d6\u200c،\u200c،\u02dfˠ\u02eb\u02df\u02e8\u02ef\u02ef\u02e7\u02df\u0315\u0309\u200c،\u200c،ˠ\u02dfˣ\u0305ˠ\u200c،\u02dfˠ\u02df\u02e6\u02e7ˠ\u200c،\u02dfˡ\u02df\u02e6\u02f7ˠ\u200c،\u02dfˠ\u02dfˣ\u02efˡ\u200c،\u02dfˡ\u02dfˣˎˡ\u200c،\u02dfˠ\u02df\u02ea\u02f7ˡ\u200c،\u02dfˡ\u02df\u02eb\u02efˡ\u200c،\u02dfˢ\u02dfˬˣˡˣ\u02efˡ\u02ea\u02dfˠ\u02eb\u02df\u02ed\u02efˢ\u0318\u02dfˣ\u02e7\u02df\u02f1\u02efˢ\u0318\u02dfˤ\u200c،\u02f5\u02ef\u02df\u02d5\u02df\u02f4\u0305\u02df\u02e5\u02efˠ\u030c\u02df\u02f6\u02d6\u02df\u0303\u02efˢ\u0318\u02dfˤ\u0305\u02df\u030b\u02efˢ\u02e9\u02df\u0301ˣ\u02df\u0303\u02efˢ\u0313\u02df\u0301\u0305\u02df\u030f\u02efˢ\u0318\u02df\u02ed\u02f3\u02df\u030f\u02ef\u02dfː\u02df\u0313\u0315\u02df\u0317\u02efˡˡ\u02df\u0306ˣˠː\u02efˡ\u0307\u02df\u0306\u0311ˠ\u02e9\u02efˢ\u0318\u02dfˤ\u0305\u02df\u0305\u02ef\u02dfˤ\u02df\u0318\u030dˠ\u0305\u02ef\u02dfˮ\u02df\u0318\u030dˠ\u02d4\u02ef\u02df\u0317\u02df\u0316\u0311ˠˡ\u02ef\u02e6\u0318\u02dfˤ\u0305\u02dfˡ\u02ef\u02e5\u02f5\u02df\u02d2\u02ebˠ\u02e9\u02efˡ\u0302\u02df\u02d2\u030dˠ\u02df\u02ef\u02e5\u030b\u02df\u0318\u030dˠ\u0301\u02efˡ\u0316\u02df\u02d5\u030dˠ\u0301\u02efˡ\u02d4\u02df\u02d7\u030dˠ\u0301\u02efˢ\u200c،\u02d7\u030dˠ\u0301\u02efˢ\u02e5\u02df\u02d7\u030dˠ\u0303\u02efˢ\u02eb\u02dfˍ\u0301ˠ\u0311\u02efˢ\u0304\u02df\u0316\u02ebˡ\u0311\u02ef\u02df\u02f8ˠˡˎˡ\u02e5\u02efˣ\u02d7ˠˤ\u02efˡ\u02f7\u02efˠˤˠ\u02e5\u02d6ˡ\u02f7\u02efˠ\u02f4ˠ\u02e7\u0315ˡ\u0301\u02efˠ\u0304ˠ\u02e9\u02ebˡ\u02eb\u02efˠ\u0312ˠ\u02eb\u02efˡ\u0307\u02efˠ\u0317ˠˬ\u0309ˡ\u0303\u02efˠ\u02d5ˠˢ\u030dˠ\u02df\u02ef\u02e5ˤˠ\u02df\u02e7ˢ\u02e7\u02ef\u02e6\u0318\u02dfˠ\u02ebˢ\u02e9\u02ef\u02e6\u0318\u02dfˤ\u0305\u02df\u02eb\u02ef\u02e6\u0318\u02dfˣ\u02dfˢ\u02ed\u02ef\u02e6\u0318\u02dfˣ\u02dfˢ\u02ef\u02ef\u02e6\u0318\u02dfˣ\u02dfˢ\u02f1\u02ef\u02e6\u0318\u02dfˣ\u02dfˢ\u02f3\u02ef\u02e6\u0318\u02dfˣ\u02dfˢ\u02f5\u02ef\u02e6\u0318\u02dfˣ\u02dfˢ\u02f7\u02ef\u02e6\u0318\u02dfˣ\u02dfˢ\u02ff\u02ef\u02e6\u0318\u02df\u02eb\u0311ˢ\u0301\u02ef\u02e6\u0318\u02dfˣ\u02dfˢ\u0303\u02ef\u02e6\u0318\u02dfˣ\u02dfˢ\u0305\u02ef\u02e6\u0318\u02dfˤ\u0305\u02df\u02ea\u0305ˠ\u0310\u02df\u02f7\u02f3ˢ\u02ea\u0305ˠ\u0308\u02df\u02f7\u02f3ˢ\u02ea\u0305ˠ\u0300\u02df\u0300\u02ebˢ\u02ea\u0305ˡˢ\u02df\u02ef\u0301ˣ\u02ea\u0305ˠ\u02d5\u02df\u0304\u030dˢ\u02ea\u0305ˠ\u0318\u02df\u0302\u02dfˢ\u02ea\u0305ˠ\u02f2\u02df\u02ff\u02efˢ\u02ea\u0305\u02df\u0318\u02df\u02f3\u02f3ˢ\u02ea\u0305\u02df\u0310\u02df\u02f1ˣˢ\u02ea\u0305\u02df\u0308\u02df\u02f0\u0305ˢ\u02ea\u0305ˠ\u02ea\u02df\u02f7\u0311ˢ\u02ea\u0305ˠˢ\u02df\u02f7\u02f3ˢ\u02ea\u0305\u02df\u02d5\u02df\u02f5\u02efˢ\u02df\u0305ˢ\u0309ˠ\u200c،\u200c،\u0315\u02dfˡ\u02dfˤ\u0305ˢ\u200c،\u02dfˤ\u200c،ˣ\u02df\u02f0\u0305\u200c،\u200c،\u0305\u02df\u02e8\u0315ˠ\u0308\u02df\u02e8\u02f3\u02dfˏ\u0305ˢ\u02d2\u02dfˡ\u0311ˠ\u02f0\u0315ˤ\u0307\u02df\u02f8\u0301ˠ\u030f\u0315\u02e6\u02ed\u02df\u0303\u0301ˠˡ\u0305\u02e7\u0304\u02df\u0308ˎˡ\u02f0\u0315\u02e8\u0309\u02df\u030dˣˡ\u030b\u02df\u02eaˏ\u02df\u0309\u0305\u02dfˬ\u0315ˤ\u02d7\u02df\u02f7\u02dfˠ\u02d7\u02df\u02e6\u0301ˮ\u02ef\u200c،\u02df\u02efˢ\u02df\u02ef\u0305\u200c،\u02df\u0315\u02df\u02f7\u02f0\u0305\u200c،ˡ\u200c،ˣ\u0305\u200c،\u200c،\u02ef\u02dfˢ\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u02dfˮ\u200c،\u200c،\u02df\u0305\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u02df\u02ef\u02df\u02f8\u200c،\u200c،\u200c،\u02dfˡ\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u02dfˠ\u02dfˡ\u02e7\u200c،\u200c،\u200c،\u02df\u02e7\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u02df\u030d\u02df\u02e9\u02ef\u200c،\u200c،\u200c،ˡ\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u02dfˡ\u0305\u02df\u02d2\u200c،\u200c،\u200c،\u02df\u02e6\u200c،\u02f7\u02dfˡ\u200c،\u02e6\u200c،\u0309\u02dfˠ\u0305\u02df\u02e9\u200c،\u0309\u200c،\u200c،\u200c،ˠˣ\u02df\u0308\u02df\u02ef\u200c،\u200c،\u02dfˤ\u0315ˡ\u02ebˠ\u200c،\u200c،\u200c،\u0302\u02df\u02e7\u0315ˣ\u02df\u02ef\u200c،\u02dfˠˎ\u02df\u0309\u02df\u02ef\u200c،\u200c،\u02df\u02e8\u0315ˡ\u02ebˠ\u02dfˣ\u200c،\u200c،\u030c\u02df\u02e8\u02dfˣ\u200c،\u200c،\u02dfˡˎ\u02df\u0308\u02df\u02efˠ\u200c،\u200c،\u02ea\u02efˡ\u02efˠ\u200c،\u200c،\u200c،\u0314\u02df\u02e7\u0315ˣ\u200c،\u200c،\u02dfˢˣ\u02df\u0308\u02df\u02ef\u200c،\u200c،\u02df\u02eb\u0315ˡ\u02ebˠ\u200c،\u200c،\u200c،ˏ\u02df\u02e7\u0315ˣ\u02df\u02ef\u200c،\u02dfˢ\u02f3\u02df\u0309\u02df\u02ef\u0313\u02dfˣ\u0311\u02df\u02e8\u0305ˠˏ\u02dfˠ\u02f7\u02df\u0303\u0315\u02df\u02ea\u02df\u02e7\u0309\u02dfˣ\u02dfˡ\u0310\u02dfˢ\u200c،\u0311\u200c،\u0317\u02df\u02ea\u02f3\u02df\u02e6\u02dfˡ\u02d4\u02dfˢ\u02ef\u02df\u02d2\u200c،\u0311\u200c،\u0315ˠ\u02df\u02efˠˠ\u200c،\u02e7\u02df\u0305\u02ef\u02dfˢ\u02dfˢˎ\u02dfˠ\u02dfˠ\u02e8\u200c،\u02f3\u02df\u0305\u02ef\u02df\u02e5\u02dfˢˣ\u02dfˠ\u0315ˡˠ\u200c،\u0305\u02dfˤ\u02ef\u02df\u02e8\u02dfˠ\u0309\u02dfˡ\u0305ˠˤ\u200c،\u0311\u02dfˮ\u02ef\u02df\u02eb\u02df\u02e7ˣ\u02dfˢ\u02efˡˠ\u200c،ˠˡ\u0302\u02f5\u02d3\u030e\u02f8\u030c\u02f3\u0313\u02f4\u02f3\u0309\u0313\u02f8\u02e5\u0316\u0311\u02dfˣ\u02e8ˏ\u0300\u030b\u030a\u030b\u0302\u02f1\u02d3\u02f4\u02f1\u02efˠ\u0312\u0301ːˬ\u0314\u0301\u030b\u0316\u030e\u02f7\u0305ˠ\u02f2\u0303\u02f6ˬˎ\u02f8\u02f5ˎ\u02df\u02f3ˑ\u030a\u0318\u0302\u02e5\u02f4\u0312\u02ea\u0309\u02f0\u0317\u02f7\u02f6\u0302\u030e\u0300\u030b\u0301\u02df\u02f2\u02f5\u030a\u0308\u0301\u030b\u02d7\u0318\u0300ː\u02f8ˎ\u02ea\u030a\u02f8\u030e\u0301ˑ\u02f4\u0306\u0300ˣ\u02e8\u0306\u0301ː\u030a\u0308\u02dfˢ\u0316ˬ\u0300ː\u02f0ˏ\u0300\u02e5\u02f3ˉ\u02dfˣˬ\u030d\u02f7\u02f6\u02e7\u02df\u02f3\u030c\u02f4\u0313\u0302\u02e5\u030a\u0312\u02f8\u02f3\u0306\u030a\u0300\u02e6ˠ\u030a\u0301\u030c\u02eb\u02df\u02f3ˑ\u030a\u0318\u0302\u02e5\u02f4\u0312\u02ea\u030a\u02e8ˏ\u0300\u030c\u02f0\u030e\u0300\u02f5\u02f3\u0313\u02efː\u02d7\u0312\u0301\u02e5\u030a\u0311\u02f8\u02f6\u02e8\u02f2\u02f8\u02f6\u02e8ː\u02ff\u02f5ˬ\u030a\u0301\u0315ˠ\u02e8\u0300\u030b\u030aˎ\u02ff\u02f5ˤ\u0311\u02ff\u02f6\u030e\u030a\u02ef\u02f6\u02e8\u0317\u02f7\u02f6\u0309\u02df\u02ef\u02f6\u02e8\u0317\u02f7\u02f6\u0309\u02df\u02f3\u030c\u02f4\u0313\u0302\u02e5\u030a\u0312\u02f8\u02f3\u02f8\u030e\u02f8\u02f5\u0316\u0309\u02f1\u02e5ˤ\u0313\u02f8\u02e5\u0316\u030a\u02dfˡ\u02d3\u0308\u02f7ˑ\u02f0\u0314\u0301\u0305ˠˡ\u02f8\u02f6\u02f0\u0306\u02dfˣˤ\u0311\u0301\u02e5\u0306\u0306\u02dfˣ\u02d7\u0307\u02ff\u030b\u02f4\u0308\u0302\u02dfˢ\u0306\u0305\u030fˎ\u02df\u02d2\u02f7\u02e9\u0305\u02dfˤˬˎ\u0301\u030b\u02f4\u0306\u0300\u02efˠ\u02f2\u0303\u02f6ˬˎ\u02f8\u02f5ˎ\u0313\u02f1\u02f3\u02d6\u02df\u02f2\u02f5\u02f4\u0312\u0300ˑ\u02e8\u02d3\u02f3ˑ\u02f0\u0317\u02f8\u02f5ˤ\u0312\u02dfˡ\u02d3\u0308\u0302\u02e5\u02d7\u0317\u02dfˣ\u02e8\u02d3\u0302\u02e5\u02f3\u02df\u02f0ˏ\u030e\u030e\u0301ˤˬˎ\u0301\u030b\u02f4\u0306\u0300\u02efˠ\u02f2\u0303\u02f6ˬˎ\u02f8\u02f5ˎ\u0313\u02f1\u02f3\u02d6\u0313\u02efː\u02d7\u0312\u0301\u02e6\u02e8\u030a\u0301ˑˬ\u030e\u0300ː\u02d2\u02df\u02efː\u02d7\u0312\u0301\u02e6\u02e8\u030a\u0301ˑˬ\u030e\u0300ː\u02d3ˬ\u0300ː\u02f0\u030a\u02dfˣ\u030aˣ\u02ff\u02f6ˬ\u0315\u0300ˑˬ\u0306\u02f7\u030b\u0316\u030a\u02dfˣ\u02f0\u030e\u0301ˑˠ\u0314\u0301ː\u02f3\u02df\u02f0\u02e6\u02e8\u0306\u0302\u0315ˢ\u030a\u030e\u02e9\u0304\u030b\u0312\u0300\u0304\u0308\u0305\u030e\u02e7\u02df\u02f0\u02f5\u02d3\u0308\u0300ː\u02f0\u030e\u0300\u030b\u0301\u02df\u02f3ˑ\u030a\u0318\u0302\u02e5\u02f4\u0312\u02ea\u030a\u02f0\u030a\u0303\u02e6\u02ef\u02df\u02f3\u030b\u02f4\u0318\u02ff\u02f6\u030e\u030a\u02dfˤˠ\u030a\u0300\u0305ˢ\u0308\u0305\u030d\u0311\u02df\u02d4\u0300\u0303\u02d3\u02d2\u02d2\u02e5\u0314\u02dfˣ\u030aˤ\u0300\u030c\u02f4\u0312\u02f8\u02f6\u02e8\u0306\u02f7\u030b\u0316\u030a\u02dfˤˬ\u02d3\u0301ˑ\u02f0\u030a\u0300\u02f1\u02d3ˢ\u0300ː\u0316\u0311\u02f8\u02f5ˬˎ\u02ff\u02f5\u02d7\u0313\u0301\u0315ˠˢ\u0300ː\u0316\u0314\u0301\u0305ˠˠ\u0301\u030c\u02e8\u0306\u0303\u02f3\u0316\u030e\u0301ˑ\u02ef\u02df\u02f1\u02f5ˏ\u0306\u02f8ː\u02f3\u02df\u02ef\u030b\u030aˎ\u0300\u02f5ˤ\u0315\u02dfˣ\u030aˢ\u0300ː\u0316\u0311\u02f8\u02f5ˬˎ\u02ff\u02f5\u02d7\u0313\u02dfˤ\u02f0\u02d3\u0301\u02e5\u02f3\u02df\u02f0ː\u02f4ˎ\u02f4\u02e6\u030a\u0315\u02f8\u02f3\u02f8\u0317\u0300ːˏ\u02e7\u02f7\u02f5\u02d3\u0309\u0300\u02e5\u02f3\u02df\u02f3\u030c\u02f4\u0313\u0302\u02e5\u030a\u0312\u02f8\u02f4\u02f0\u02d3\u0301\u02e5\u02f4\u02e7\u02f7\u02f5\u02d3\u0309\u0300\u02e5\u02f3\u02df\u02f4\u02e5\u02d7ˠ\u0301\u030c\u02e8\u0306\u0303\u02efˢ\u0306\u0305\u030f\u02ef\u02df\u02f3\u030b\u02f4\u0318\u0300ˑ\u02f4\u0317\u02f7ː\u02f4ˬ\u02f7\u02f5\u02d3\u0306\u02f8ː\u02f4\u0317\u02dfˤˬ\u02d3\u0301ˑ\u02f0\u030a\u0300\u02f1\u02d3\u02f1\u02f8\u02f6ˬ\u0314\u0302\u02f6\u02e8\u0308\u02f8\u02f6\u02eb\u02df\u02ef\u02f6ˬ\u0318\u02f8\u02f5ˏ\u0307\u0300\u02e6\u0309\u02df\u02f3ˑ\u030a\u0318\u0302\u02e5\u02f4\u0312\u02ea\u030a\u02e8\u030a\u02f8\u030b\u0316\u030a\u02f7ˑ\u02f0\u030e\u0300ː\u02d2\u02df\u02f0ː\u02f4ˎ\u02f2ː\u02e8\u030f\u02f8\u02f5ˬˎ\u02dfˣ\u02d5ˢ\u0312\u02dfˠ\u0317\u02f8\u02f6ˬ\u0304\u0300\u030bˤ\u0312\u02f8\u02efˠ\u0315\u0301\u030b\u02d7\u030f\u02f6ː\u02d3\u0306\u0300\u02f5\u02f3\u02df\u02f1\u02f3ˬˏ\u0301ˑ\u02f0\u0314\u0300\u02f3ˤˎ\u0302\u02e6\u02e8\u030e\u02f7\u030c\u02f4ˎ\u02f8\u02f4ˠ\u0317\u0300ˑ\u02f8\u030e\u02f8\u02e5\u02f4\u0317\u02dfˣ\u030a\u0313\u0302ˢ\u02eb\u0317\u02dfˣ\u030a\u0313\u0302\u02e5\u02f4\u0317\u02f7\u02f5ˬˎ\u02ff\u02f5\u02d7\u0313\u02dfˣˬ\u0306\u0300\u02e5\u0316ˡ\u0303\u02f3\u02d3\u0306\u0300\u02f5\u02f3\u02df\u02efːˤ\u0311\u0300ˤ\u02f0\u02d3\u0301\u02e5\u02f3\u02df\u02f0\u02f5\u02d3ː\u02ff\u02f6\u02e8\u0314\u0300\u030bˏ\u030a\u0300\u030c\u02ef\u02df\u02f0\u02f6\u0306\u030e\u0302\u02dfˠˡ\u0302\u02f5\u02d3\u030e\u02f8\u030c\u02f4\u0304\u02f4\u02e5\u02f4\u02d2\u0302ˣ\u02e8\u0314\u0303\u02dfˠ\u0317\u02f8\u02f6ˬ\u0314\u0302\u02f6\u02e8\u0308\u02f8\u02f4\u02d7\u0313\u02f7\u02f5ˏ\u030a\u02df\u02ed\u030bˑ\u0313\u0303\u02edˠ\u0310ˏ\u02d7\u0315\u02f7\u02f6\u02e8\u0306\u0300\u02efˠ\u0315\u0301\u030b\u02d7\u030f\u02f8\u02f5ˬˎ\u02f6ː\u02d3\u0306\u0300\u02f5\u02f3\u02df\u02d2\u02f7\u02e9\u0318\u02d2\u02f7\u02e9\u0312\u02dfˤ\u02f8\u0306\u0300\u02e6\u02f4\u030a\u02f4\u02e6\u030a\u0315\u02f8\u02efˢ\u0306\u0305\u0310ˮ\u0306\u0305\u0310\u02eb\u02df\u02d2\u02f7\u02e9\u030d\u02df\u02ed\u02e5ˡ\u0311ˉ\u02e5ˡ\u030d\u02dfˢ\u0306\u0305\u0310\u200c،\u02f8ː\u02f4ˎ\u02f6ˏ\u0302\u030e\u02f8\u02e6\u02f0\u030d\u02df\u02e5\u0302\u030a\u0302ˤ\u02d7\u02e7\u02f8\u02f5\u030a\u030c\u02ff\u02e6\u02ef\u02df\u02f4\u02e5\u0306\u0317\u02f8\u02f5ˤ\u0309\u02dfˤˬ\u02d3\u0301ˑ\u02f0\u030a\u0300\u02f1\u02d3\u02f3\u02ff\u02e6\u02e8\u030a\u02f7\u02f5\u02f0\u030e\u0300\u030b\u0301\u02df\u02f3ː\u0316\u030a\u02f8\u02f6\u200c،\u02d2\u02f7\u02e9\u0308\u02df\u02ed\u02e5ˡ\u0314\u02dfˢ\u0306\u0305\u0310\u02eb\u02df\u02d2\u02f7\u02e9\u030a\u02dfˣ\u030aˢ\u0300ːˏ\u0315\u02f7\u02f6\u02e8\u0306\u02f7\u030b\u0316\u030a\u02f7ˢˣ\u02df\u02f1\u02f4ˬ\u030a\u0301\u030b\u030a\u0306\u0300\u02e5\u030a\u02d4\u02f7\u02f5\u02e8\u0311\u02f8\u02efˠ\u02f2\u0303\u02f6ˬˎ\u02f8\u02f5ˎ\u0313\u02f3\u030c\u02f4\u0313\u0302\u02e5\u030a\u0312\u02f8\u02f1\u02d3\u02f2\u02f8\u02f6\u02e8\u030e\u02f7\u02f5\u0316\u030e\u0303\u030bˤˎ\u02ff\u02f5\u02d7\u0313\u02dfˤˬˎ\u0301\u030b\u030a\u0313\u02f8\u0315ˠ\u02f2\u0302\u02e6\u02e8\u030e\u0300\u030b\u0302ˡ\u0302\u02f5\u030a\u0311\u02f8\u02e5\u02f4\u0317\u02dfˣˤ\u0315\u0301\u02e5\u02f4\u0313\u02f8\u02dfˠ\u02f3\u0300ˏˬˎ\u0301\u030b\u030a\u0313\u02f8\u0315ˠ\u030c\u02f8\u02f6\u02f0\u0304\u02f2\u02e5\u02f4\u0313\u02f8ˑ\u02f0\u030d\u02dfˣ\u02f8\u0317\u0300ːˏˠ\u0301\u030b\u0302\u0307\u02df\u02e5\u0302\u030a\u0302ˤ\u02d7\u02f1\u02df\u02e5\u0302\u030a\u0302ˤ\u02d7\u02e6\u02df\u02e5\u0302\u030a\u0302ˤ\u02d7ˡ\u02dfˣ\u030a\u0313\u0301ː\u02f4\u0317\u0302ˤ\u02e8\u0306\u0300\u030b\u0302\u030a\u02df\u02ed\u02e5ˡ\u0311ˉ\u02e5ˡ\u030e\u02dfˠ\u02e6\u02f8\u02f6\u02f0ˤ\u0300\u030c\u02f0\u0317\u0303\u02f3ˤ\u0318\u0301ː\u02f4\u0312\u02f7\u030b\u0316\u02d3\u02dfˤ\u02d7ˠ\u0301ˑˬ\u030a\u0300\u02f5\u02e8\u0311\u0303\u02efˠ\u02f2\u0303\u02f6ˬˎ\u02f8\u02f5ˎ\u0313\u02f3\u030c\u02f4\u0313\u0302\u02e5\u030a\u0312\u02f8\u02f1\u02d3\u02e8\u0300\u030c\u02f0\u030a\u0301\u030b\u02d7\u0315\u02f3ː\u02f4\u0317\u0302\u030b\u030a\u0308\u02f8\u02f6\u02eb\u02df\u02f2\u02e5\u02d7\u0306\u02f8\u02dfˢ\u0306\u0305\u0310ˮ\u0306\u0305\u030f\u02eb\u02df\u02d2\u02f7\u02e9ˑ\u02df\u02ed\u02e5ˡ\u0310\u0303\u02e5ˡ\u030e\u02efˠˡ\u02ff\u02f6\u02f0ˢ\u0300ː\u02d3ː\u02f8\u02f6\u02e8ˎ\u02f8\u02f6\u02e7\u02df\u02f4\u02e5\u02d7\u02e8\u0300\u030c\u02ef\u0318\u02eb\u0305ˠ\u02e6\u02f8\u02f6\u02f0ˡ\u0303\u02f6\u02f0\u030a\u0301\u0315ˢ\u0306\u0305\u030fˑ\u0306\u0305\u030fˎ\u02df\u02f8ː\u02f4ˎ\u02f6ˎˤ\u02f2\u02efˎ\u030a\u02e8\u02df\u02e5\u02d7\u0315\u02f6ˎ\u030a\u0313\u02f8\u02f6ˤˏ\u02f7\u02f5\u0316\u030e\u0302\u02e6\u0309\u02df\u02f3\u030b\u02f4\u0306\u02f8\u02dfˠ\u02e6\u02f8\u02f6\u02f0\u02ef\u02ff\u02f6\u0306\u030a\u0300\u02dfˠ\u030c\u02f8\u02f6\u02f0\u0304\u02efː\u02d7ˏ\u0300\u030c\u02ef\u02df\u02efː\u02d7\u0313\u02f7ːˤˎ\u02dfˡˣ\u0306\u02eb\u200c،\u0306\u02e7\u02f2ˣ\u02df\u02efː\u02d7\u0312\u0301\u02e5\u030a\u0311\u02f7\u02f6\u02f0\u030e\u0300ː\u02d3\u02f1\u02f8\u02f5\u0316\u0306\u0303\u02e5ˤˎ\u02ff\u02f5\u02d7\u0313\u0301ˎˤˎ\u0302\u02e6\u02e8\u030e\u02f7\u030c\u02f4ˎ\u02f8\u02efˠ\u02f1\u0302\u02f5\u02d3ˎ\u02ff\u02f5ˏ\u030a\u02efː\u02d7\u0312\u0301\u02e5ˤˎ\u02ff\u02f5\u02e8\u030e\u0300\u02e5\u030aˎ\u0303\u02f3ˤˎ\u0302\u02e6\u02e8\u030e\u02f7\u030c\u02f4ˎ\u02f8\u02efˠˠ\u0301ˑˬ\u030a\u0300\u02f5\u02e8\u0311\u0303\u02f4\u02f0\u030e\u0302\u02e5\u0316\u030a\u02ef\u02f6\u02f0ˎ\u0301\u030b\u030a\u0307\u0302\u02f6\u02f0\u030a\u02dfˣˤ\u0318\u0301ː\u02f4\u0312\u02f7\u030b\u0316\u02d3\u02f0\u02e5\u02f4\u0318\u02f7ˑ\u02e8\u030e\u0301\u02e6\u02f0\u030e\u0300ː\u02d3ˠ\u0302\u02e6\u02f0\u0317\u02ff\u02f5\u02e8ˏ\u0302\u02e5\u02f3\u02df\u02ef\u02f6ˬ\u0318\u02f8\u02f5ˏ\u0307\u0300\u02e6\u030aˢ\u0300ː\u02d3\u030b\u02ff\u02f5\u0302ˏ\u0301\u030bˤˎ\u02ff\u02f5\u02d7\u0313\u02ef\u02f6\u02f0ˎ\u0301\u030b\u030a\u0307\u0302\u02f6\u02f0\u030a\u02dfˣˤ\u0318\u0301ː\u02f4\u0312\u02f7\u030b\u0316\u02d3\u02efː\u02d7\u0312\u0301\u02e5ˤ\u0313\u0303\u02f3ˤˎ\u0302\u02e6\u02e8\u030e\u02f7\u030c\u02f4ˎ\u02f8\u02efˠˠ\u0301ˑˬ\u030a\u0300\u02f5\u02e8\u0311\u0303\u02f4ˠ\u0317\u0300ː\u02f0ˏ\u02f7ˑ\u02f0ˠ\u0302\u02e6\u02f0\u0317\u02ff\u02f5\u02e8ˏ\u0302\u02e5\u02f3\u02df\u02ef\u02f6ˬ\u0318\u02f8\u02f5ˏ\u0307\u0300\u02e6\u030aˢ\u0300ˑˠ\u02d3\u0301\u030b\u030a\u030c\u02ff\u02e6\u02f0ˠ\u0302\u02e6\u02f0\u0317\u02ff\u02f5\u02e8ˏ\u0302\u02e5\u02f3\u02df\u02ef\u02f6ˬ\u0318\u02f8\u02f5ˏ\u0307\u0300\u02e6\u030a\u02f3\u0301\u030bˤ\u0309\u02f8\u02f5ˏ\u0306\u0301\u030b\u0312ˠ\u0302\u02e6\u02f0\u0317\u02ff\u02f5\u02e8ˏ\u0302\u02e5\u02f3\u02df\u02efː\u02d7\u0312\u02f4\u030b\u030a\u0318\u02ff\u02f5\u02e8\u0311\u02f8\u02f3ˤˎ\u0302\u02e6\u02e8\u030e\u02f7\u030c\u02f4ˎ\u02f8\u02efˠ\u02e6\u0302\u02f5\u030a\u0309\u02ef\u02f6\u02f0ˎ\u0301\u030b\u030a\u0307\u0302\u02f6\u02f0\u030a\u02dfˣˤ\u0318\u0301ː\u02f4\u0312\u02f7\u030b\u0316\u02d3\u02f0\u030b\u030a\u0311\u02f8\u02f4\u02f8\u030a\u0301\u030cˬ\u030e\u0300ː\u02d3ˠ\u0302\u02e6\u02f0\u0317\u02ff\u02f5\u02e8ˏ\u0302\u02e5\u02f3\u02df\u02f3ˑ\u02f4\u0315\u0301\u02e6\u02e8\u030a\u0301ˑˬ\u02e8\u0300\u02e5\u02f0\u0306\u0301ːˏˠ\u0302\u02e6\u02f0\u0317\u02ff\u02f5\u02e8ˏ\u0302\u02e5\u02f3\u02dfˡ\u030d\u02df\u0303\u0307\u0316\u030f\u0318\u0300ˣ\u0303\u0318\u0311ˮ\u02d2\u0313\u02e7ˣ\u0316\u030f\u0303\u200c،\u02e7\u0312ˑ\u030e\u0301\u02f4\u0306\u0309ˎ\u02d2\u02e7\u0309\u02e7\u0311ˢ\u02d7\u0304\u0304\u0316\u02e6\u02f4ˡ\u0308\u030d\u02e6\u200c،\u02e7ˠˣ\u0305ˎ\u02f0ˣ\u02ef\u02eb\u200c،\u02dfˣˢˠ\u0306ˣ\u02eb\u02df\u0315\u02f7\u0302\u02df\u0316\u030d\u02e6ˤˠ\u02e7\u02f8ˣ\u0305ˎ\u02e7\u02e6ˠ\u0315\u0301ˡ\u02df\u0305\u02e7ˡ\u02df\u0305\u02e7ˡ\u02df\u0305\u0302\u02df\u0315\u0305\u02e7\u02e6\u02ef\u02eb\u02e7ˡ\u02df\u02f3\u0305\u02df\u02efˣ\u0302ˠ\u02ef\u02e7\u0302ˠ\u02ef\u02ef\u02e9\u02df\u02f0\u02e7\u02f8ˠ\u0317\u02dfˡ\u02df\u02f0\u02e7\u02f8ˣ\u02f1\u0309ˢ\u02e7\u200c،ˠˠ\u0305\u02dfˠ\u02e6\u02ef\u02f3\u0302ˠ\u02f0ˣ\u02e6ˢˠ\u0315\u02e7\u02e6\u02ef\u02f3\u02e7ˡ\u02df\u02e7ˡ\u02e6\u02df\u0305\u02e7\u02e6\u02ef\u02eb\u0302\u02df\u0315\u02f3\u02e9\u02df\u0305\u02d2\u02f1\u02eb\u02ef\u02eb\u02e9\u02df\u02ef\u02d2\u02e8ˣ\u02dfˣˡ\u02df\u02f0\u02df\u0302\u02e6\u0305\u02df\u02e7\u02df\u0315\u030dˠˠ\u02ef\u0301\u200c،\u0306ˎˤ\u02e6\u02ef\u02f3\u02edˤ\u02ef\u0301\u02edˣ\u0308\u02f3\u02e7ˡ\u02df\u0305\u02e7ˣ\u02f2\u0309ˡ\u02df\u0305\u02e7\u02f1ˢ\u02ef\u0305\u02e7\u02e6\u02ef\u02eb\u0302\u02df\u0315\u02ef\u02e9\u02df\u02f0\u02e8ˠˠ\u02df\u030dˠˣ\u0309\u02f3ˣˡ\u0305ˣ\u02f1ˮ\u02ef\u02f7\u02e9\u02df\u0306\u02e7\u02d7ˣ\u0309\u0309\u02e5\u200c،ˣ\u02f1\u02f2\u02f0ˤ\u02f0ˠ\u0307\u02dfˠˣ\u0305ˎ\u02f1\u02f2\u02ef\u02f7\u200c،\u02f0ˎˤˣ\u0309\u02f3\u02e8ˠ\u0315\u02f3\u0301ˣ\u0309ˣ\u02e7ˡˠˎˢˠ\u02df\u030dˡˢ\u0305\u02d2\u02e5\u02e7\u02df\u02e7ˠˢ\u0306\u02e8\u02f8ˠˡ\u02dfˠ\u02e6\u02df\u02d2\u02e5\u200c،\u02e7\u02f1\u02f0\u02ef\u02d2\u02edˣ\u0315\u0301\u02eaˣ\u0309ˣ\u0301ˣ\u0305ˎ\u02f1ˢ\u02f0\u02e8\u0302\u02e6ˠ\u0315\u02e7ˡˠˎˢ\u02e6\u02ef\u02ebˣˡ\u0305\u02e7\u02ed\u02e6\u02df\u0309\u02dfˠˠ\u0315\u0301ˢ\u0306ˤ\u030e\u02e6\u02f0\u0315ˣ\u200c،ˣˠˡ\u02df\u02f7\u200c،\u0315ˣ\u02edˢ\u0305\u02d2ˢˠ\u0306ˣ\u02f3ˡ\u0315\u0301\u02e6ˡ\u02df\u0305\u02e7ˡ\u02df\u0305\u0302\u02df\u0316ˎˢ\u02df\u0306\u02d2\u200c،\u0317\u200c،ˡ\u02df\u0305\u02ef\u02df\u02ef\u02eb\u02e7\u02e6\u0305\u02dfˢ\u02df\u0315\u0311\u02e6ˡ\u02df\u0305\u02e7ˡ\u02df\u0305\u02e7\u02e6\u02ef\u02eb\u02e7ˡ\u02df\u02f7\u200c،\u0315ˣ\u02e7ˡ\u02df\u02ebˢˠ\u0306\u02e7ˬ\u02df\u0315\u02f7\u02f0\u02e7ˠ\u030d\u02e6ˣ\u02ef\u0305\u02e7\u02e6ˠ\u02f3\u02f1\u0303\u02efˣ\u02edˣ\u030cˎˢˡ\u02df\u0305\u02e7ˡˠ\u0315\u0301ˡ\u02df\u0305\u02e7\u02e6\u02ef\u02eb\u0302\u02df\u0315\u02e7\u0302\u02df\u0315\u02e7\u0302ˢ\u0305\u02f7\u0305\u02df\u02f0\u02e9\u02df\u0306\u02ef\u02ebˢ\u02e7\u200c،\u02edˡ\u200c،ˣˢ\u0306\u02e8ˬˡ\u02df\u02f3\u02e7ˡ\u0305\u0301\u02e6ˡ\u02df\u0305\u02e7ˡ\u02df\u0305\u02e7\u02e6\u02ef\u02eb\u02e7ˣ\u02dfˣˢˡˠ\u02d2\u02dfˡ\u02df\u0305\u02edˠ\u0315\u0305\u02e7ˣ\u02f2\u0309\u02f0\u02ed\u02ef\u0305\u02e7ˡˠˎˢ\u02e6\u02ef\u02eb\u02e7\u200c،\u02ef\u02f0\u02ed\u02ef\u0305\u02e7ˡ\u02df\u0305\u02e9\u200c،\u02f7\u02f0\u02ed\u02ef\u0305\u02e7ˡ\u02df\u0305\u02e5\u02df\u0315\u0311\u02e6ˠ\u0315\u0305ˤˡ\u02df\u0305\u02e7\u02e6\u02ef\u02eb\u0302\u02df\u0315\u02eb\u0305\u200c،\u02f3\u02e7\u200c،\u02ebˤˣˠˣ\u02d3\u02df\u0315\u02eb\u02ebˠ\u0315\u0305\u02e7ˡ\u02df\u0305\u02e7\u02e6\u02ef\u02eb\u0302\u02df\u0315\u0305\u02e7\u02df\u0306\u02d2ˠˠ\u0307\u02dfˡ\u02df\u02ef\u0305\u02f1\u02f1\u02ef\u0311\u02ef\u02df\u0305\u02f3ˠ\u02e6\u0305\u02df\u02e7\u02e6\u0305ˣ\u02e7ˡ\u02df\u0305\u02e6ˠ\u02ef\u0305\u0301ˡ\u02df\u0305\u0302\u02df\u0315\u02ef\u200c،ˠ\u02e8\u02f8ˠ\u0305\u02dfˡˣ\u030a\u0309ˢˡ\u02dfˎ\u02e6ˠ\u0315\u0305\u02f1\u0305\u02e7\u0309\u02e7ˡ\u02df\u0305\u0302\u02df\u0316ˎˢˠ\u0305\u02dfˠˣ\u030a\u0309\u0302ˠ\u02ef\u0305\u200c،\u0316\u02e8\u02f8\u02e6\u02ef\u02f3ˢ\u02df\u0315\u0309\u02e6ˠ\u02f0\u0315\u02e7ˡˠˎˢ\u02e6\u02ef\u02eb\u02ebˠ\u0315\u0305\u02e7ˡ\u02df\u0305\u02e7ˡ\u02df\u0305\u0302\u02df\u0316ˎˢˠ\u0305\u02dfˡˡˠˎˤˡ\u02df\u0305\u02dfˠ\u02df\u0305\u0302ˠ\u02ef\u0305\u02e5\u02df\u0315\u030d\u02e6ˠ\u0315\u0305\u0301ˡ\u02df\u0305\u02e7ˡˠˎˢˠ\u02f1\u02dfˠ\u02e6\u02ef\u02f3\u02edˡ\u0316\u02dfˡˠˠˎˤ\u02e6\u0305ˣ\u0303\u200c،\u02eb\u02e5ˡ\u0305\u0301\u02e5ˡˠ\u0315\u02e7ˡˠˎˢ\u02e6\u02ef\u02ebˣ\u200c،\u02df\u02f1\u02eb\u02ef\u02f7\u200c،\u0306\u02e7\u0316\u02df\u0315\u0305\u02e9ˠ\u0315\u0301\u02e7\u02df\u0305\u0305\u02e7ˡ\u02df\u0305\u0302\u02df\u0315\u0301\u200c،\u0305\u02e7\u02f0\u02ed\u02f0ˣ\u02d3ˡ\u02ef\u02dfˣ\u02df\u0306ˣ\u02d3ˣ\u02f2\u0309\u02e5ˠ\u0305\u02d2\u02ef\u02df\u0305\u02f7\u0301\u02e6\u0305ˣ\u0303\u02dfˠˤ\u030e\u02e6\u02f0\u0315\u02e7\u02df\u0315\u0301\u0305\u02df\u0315\u0305\u0302ˠ\u02ef\u0305\u02e7ˢˠ\u02dfˠˠ\u0305\u0305\u0303\u02dfˠˎˤˡ\u02df\u0305\u02e7ˠ\u0305\u02f7\u0305\u02df\u0306ˣ\u02d3ˡ\u02df\u0305\u02eaˣ\u02dfˣˤˣ\u02f2\u0309\u0303\u200c،\u0305\u02e7\u02df\u0315\u0305\u02e7ˣ\u02dfˣˢˡˠ\u02d2\u02dfˠ\u0305\u02f7\u02ebˠ\u0315\u0305\u02e7\u02e6\u02df\u0305\u02e7ˡ\u02df\u0305\u0302\u02df\u0316ˎˢˠ\u02ef\u02dfˡˢ\u0305\u02d2\u02edˡ\u0306\u02dfˡˠ\u02df\u02d2\u0303\u02df\u02f0\u02d2\u200c،\u0315\u02ebˣ\u02e7\u02dfˣˠˡ\u02df\u0305ˠ\u200c،\u0305\u200c،\u200c،\u200c،ˠ\u02d2ˠ\u200c،ˣ\u02df\u02f4\u02df\u02e7\u02f5\u02f4ˑ\u02e8\u0306\u0301ˣ\u02d3\u0314\u0300\u0309\u02f4\u02d2\u02f7ː\u02f4\u0315\u0302\u02e5\u030a\u0314\u0300\u030a\u02f0\u030d\u0301\u030b\u02d7ˑ\u0301\u0315ˣˣ\u02e7\u02dfˣˠˢ\u0306\u02d2ˠ\u02dfˠ\u030aˡ\u0302\u02f5\u02d3\u030e\u02f8\u030c\u02f3\u0305\u02f0\u030c\u02e8\u0306\u0300\u02f5\u02f4ˑ\u0300ˑ\u02e8\u0310\u02e7ˡˎ\u0305\u02f4\u02f3\u0309\u0305\u02f2\u02e5\u030a\u0307\u200c،\u02df\u0305\u02df\u02ef\u02df\u0300\u02efˑ\u02f4\u0318\u0302\u02e5\u02d7\u0312\u02e7ˣ\u02e8ˏ\u0300\u030b\u030a\u030b\u0302\u02f1\u02df\u0313\u02f2\u0309\u02f4\u02f3\u02e7\u02e5ˬ\u0314\u0300\u030c\u02f0\u0317\u0300ː\u0316\u0318\u200c،\u02dfˤ\u02df\u02ef\u200c،\u200c،\u02df\u02f7\u02df\u02ef\u02df\u02f2\u02ef\u030c\u02f4\u0313\u02ff\u02f5\u02f8ˏ\u02e7ˤ\u02f0\u030a\u02f7ː\u0306\u0313\u0300ː\u0316\u0314\u02f8ː\u030a\u030a\u0301\u0315\u200c،ˢ\u0305ˣ\u02dfˡ\u02f3\u02e8ˏ\u0300\u030b\u030a\u030b\u0302\u02f1ˠ\u02f4\u02f1\u02ef\u200c،ˤ\u0315ˣ\u02dfˣ\u0309ˬ\u0314\u0301\u02e6\u030a\u0317\u02ff\u02f5\u0302\u030d\u0302ˡˢˡ\u030f\u02f1\u02df\u0305\u02eb\u0308\u02df\u0316ˬ\u0305\u200c،ˠˡ\u02dfˠ\u02df\u02ef\u02e7\u030e\u02df\u02ef\u02df\u0309\u02ed\u02f5\u02f8\u0307\u02edˢ\u02e7\u0315ˬ\u030b\u02f3\u0312ˬˢ\u02df\u0315\u02f8\u0307ˎˎ\u02eb\u0318\u02f7\u0315\u02ea\u02f2\u0309ˏˬ\u0318\u0309\u0312\u02ebˢ\u0309ː\u02eb\u02f2ˤ\u0306ˬː\u02e8\u030b\u02f7\u02f2\u02f7ˏ\u200c،\u02df\u02eb\u02df\u02ef\u02df\u02e6\u02eb\u02f1\u02d2\u0318\u02ea\u0308\u02df\u0313\u02eb\u200c،\u02dfˠ\u02dfˣ\u200c،\u02dfˢ\u0309\u02f4\u0315\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،ˢˉ\u02f4\u0315\u200c،\u02dfˡ\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u02d6ˤ\u0301\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u02dfˠ\u0304\u02efː\u02d7\u0317\u02f0\u02e5\u0316\u0311\u02f2\u02f5ˤ\u030e\u0300\u0305ˠ\u0312\u0301ːˬ\u0314\u0301\u030b\u02f4\u030a\u02ea\u030b\u02f0\u0311\u0300\u200c،\u200c،\u200c،\u02dfˍ\u0317\u02f3\u02df\u02e7ˣ\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u02dfˠ\u02dfˠ\u200c،\u200c،\u02df\u02f7\u200c،ˡ\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،ˠ\u200c،ˣ\u200c،\u200c،\u0315\u200c،ˡ\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،ˠ\u200c،\u200c،\u200c،ˠ\u02e7\u200c،\u200c،\u02f5\u02e5\u200c،\u02df\u02e8\u02efˢ\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u02df\u02e8\u02efˢˬ\u200c،\u200c،ˤ\u02f7\u02df\u02f3\u0315ˠ\u0304\u02dfˤ\u02f7\u02df\u02f0\u02efˠ\u02f1\u02dfˤ\u02eb\u02df\u02f1\u02efˠˮ\u02dfˣ\u02d2\u02df\u02f6\u0315ˠ\u02e8\u02dfˣ\u02d2\u02df\u02f0\u0305ˠˮ\u200c،\u200c،\u200c،ˡ\u02d7ˠ\u02edˍˉ\u200c،\u02dfˠ\u200c،\u02eb\u200c،\u02ef\u200c،\u200c،\u200c،\u02df\u0315\u02dfˠ\u200c،\u200c،\u200c،\u02dfˍ\u200c،\u200c،\u200c،\u200c،\u200c،\u02ef\u200c،\u200c،ˡ\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u02f0\u200c،\u200c،\u02dfˣ\u02df\u02f4\u0305ˠ\u0306\u02df\u02e6\u02e7\u02df\u02f0\u0305ˠ\u030e\u02df\u02e5\u0315\u02df\u02f8\u02efˠ\u02e8\u02df\u02e5\u02d2\u02df\u02f8\u0305ˠ\u0314\u200c،\u200c،\u200c،\u02df\u0309\u200c،\u02ef\u200c،\u02dfˠ\u02f3\u02df\u02e6\u02e7\u02df\u02f7\u02efˠ\u0313\u02df\u02e6\u02eb\u02df\u0300\u02dfˠ\u0306\u02df\u02e6\u02ef\u02df\u02ff\u02efˠ\u0314\u02df\u02e5\u02d2\u200c،\u200c،\u200c،\u200c،\u02df\u0311\u02df\u02f2ˎ\u02df\u0305\u200c،\u02df\u02efˠ\u02f2\u02df\u02e6\u02ef\u02df\u0301\u0305ˠ\u030e\u02df\u02e5\u02d2\u02df\u02f8\u0315ˠ\u02e5\u02df\u02e5\u0309\u02df\u0300\u02dfˠ\u030a\u02dfˣ\u0309\u02df\u0300\u0305ˠ\u030b\u02df\u02e5\u02d6\u200c،\u02dfˢ\u02ef\u02df\u0305\u200c،\u02df\u02ef\u02df\u0315\u02dfˢ\u200c،\u02eb\u200c،\u0315\u02dfˢ\u200c،ˬ\u02dfˠ\u0307\u02dfˢ\u200c،\u200c،ˠ\u02ef\u02dfˠ\u0315\u200c،\u02efˠˢ\u02df\u02e5\u02d6\u02df\u0300\u02efˠ\u0312\u02df\u02e5\u02f3\u02df\u0300\u0305ˠˎ\u02df\u02e6\u02eb\u200c،\u02dfˠˢ\u02df\u02e6\u02f3\u02df\u0301\u0315ˠˎ\u02df\u02e5\u02d6\u02df\u0300\u02ef\u02df\u0305\u02dfˣ\u02e7\u02df\u0302\u02efˠ\u0313\u02df\u02e5\u0309\u02df\u02f8\u0305ˠˏ\u02dfˡ\u200c،\u02ea\u0305ˠ\u02ed\u02dfˣ\u02f3\u02df\u02f4\u200c،\u0305\u02df\u02e5\u02eb\u02df\u0300\u0315ˠ\u0313\u02df\u02e6\u02ef\u02df\u0301\u0305ˠ\u0314\u02df\u02e5\u0315\u02df\u0301\u0315\u200c،\u02dfˣ\u0305\u02dfˤ\u200c،ˠ\u02dfˣ\u02eb\u02df\u0300\u0315ˠ\u0312\u02df\u02e6\u200c،\u02f7\u02efˠ\u0313\u02df\u02e6\u0309\u02df\u02f2\u0305ˠ\u0306\u02df\u02e5ˎ\u02df\u02f8\u02ef\u200c،\u200c،\u200c،\u02ef\u0305ˠˏ\u02df\u02e5\u02d2\u02df\u02ff\u02efˠ\u030b\u02df\u02e6\u02f3\u02df\u02e7\u02dfˠ\u02f3\u02df\u02e5\u02f3\u02df\u02f7\u0315ˠ\u030d\u02df\u02e5\u02d2\u02df\u0300\u0315ˠ\u0311\u02df\u02e5\u02d6\u02df\u02f8\u0315ˠ\u030e\u02df\u02e5\u02f3\u02df\u0301\u0315\u200c،\u02dfˤ\u0315\u02df\u02e5\u0305\u02dfˠ\u02dfˣ\u02f7\u02df\u02ff\u02efˠ\u0311\u02df\u02e5\u02f3\u02df\u02f0\u02dfˠ\u030a\u02df\u02e6\u02eb\u02df\u02f7\u0315ˠ\u0317\u02df\u02e5\u0309\u02df\u0301\u02dfˠˎ\u02df\u02e5\u0309\u02df\u0300\u0315ˠ\u0313\u200c،\u200c،\u200c،ˠˡ\u02df\u02e6\u02f3\u02df\u0300\u0305ˠ\u030e\u02df\u02e5\u02f7\u02df\u0302\u02ef\u02df\u0305\u02dfˣ\u02f7\u02df\u0301\u0305ˠ\u0306\u02df\u02e5ˎ\u02df\u02f8\u02efˠˑ\u02df\u02e5\u02d6\u02df\u0301\u0305ˠ\u0310\u02dfˡ\u200c،\u02ea\u02ef\u02df\u0305\u02dfˤ\u02f3\u02df\u02f1\u02ef\u02df\u0305\u02dfˣ\u0315\u02df\u02ff\u02efˠ\u0307\u200c،\u200c،\u02eb\u200c،\u02e7\u200c،ˣ\u02df\u02f0\u0305ˠ\u030e\u02df\u02e5\u0315\u02df\u02f8\u02efˠ\u02f5\u02df\u02e5\u02f3\u02df\u0301\u0305ˠ\u0318\u02df\u02e5\u0309\u02df\u0300\u0315ˠ\u0313\u200c،\u200c،\u200c،\u02df\u0316\u02dfˡ\u02d2\u02df\u02eb\u0315\u02df\u0313\u02dfˢ\u200c،\u02ea\u0305\u02df\u0315\u200c،\u200c،ˮ\u200c،\u02ed\u200c،ˣ\u02df\u02f1\u02efˠ\u0313\u02df\u02e6\u02ef\u02df\u02f8\u02efˠ\u0317\u02df\u02e5\u02d2\u02df\u02f7\u02efˠ\u0311\u02dfˣ\u02d2\u02df\u02f7\u02efˠ\u0312\u02df\u02e5\u02f3\u200c،\u02dfˠˡ\u02df\u02e6\u02f3\u02df\u0300\u0305ˠ\u030e\u02df\u02e5\u02f7\u02df\u0302\u02ef\u02df\u0313\u02dfˤ\u02f3\u02df\u02f1\u02ef\u02df\u0313\u02df\u02e5\u02ef\u02df\u0300\u02dfˠ\u0311\u200c،\u200c،\u02f1\u200c،\u02f1\u200c،ˣ\u02df\u02f2\u02dfˠ\u030a\u02df\u02e5\u0301\u02df\u02f7\u02efˠ\u0311\u02dfˣ\u02eb\u02df\u0300\u0315ˠ\u0315\u02df\u02e6\u0309\u02df\u0301\u0305ˠ\u030e\u02df\u02e5\u0301\u02df\u02ff\u02dfˠˎ\u200c،\u200c،\u02ef\u0315ˠ\u0314\u02df\u02e6\u200c،\u0303\u02efˠ\u0317\u02df\u02e5\u0309\u02df\u02f8\u0315ˠ\u030d\u02df\u02e6\u02ef\u02df\u02e7\u02dfˡ\u030e\u02dfˡ\u200c،\u02e7\u200c،\u0317\u02dfˢ\u200c،\u02eb\u02ef\u02dfː\u200c،\u200c،\u02e9\u0305\u02dfˠ\u200c،ˣ\u02df\u02f2\u02dfˠ\u030a\u02df\u02e5\u0301\u02df\u02f7\u02efˠ\u0311\u02dfˤ\u02ef\u02df\u0301\u0305ˠ\u0306\u02df\u02e5\u02ef\u02df\u02f8\u02efˠ\u0312\u02df\u02e5ˣ\u02df\u0301\u0305ˠ\u0310\u02df\u02e6\u02eb\u200c،\u200c،\u200c،\u200c،\u200c،\u02dfˠˣ\u200c،\u02d2\u200c،\u02efˠˮ\u02df\u02e6\u02e7\u02df\u02ff\u02efˠ\u030c\u02df\u02e5\u0309\u02df\u0300\u0305ˠ\u0306\u02df\u02e5\u0315\u02df\u02f0\u0305ˠ\u030e\u02df\u02e5\u0315\u02df\u02f8\u02efˠ\u0313\u02df\u02e5ˣ\u02df\u0300\u02efˠ\u030a\u200c،\u200c،\u02ef\u0305ˠˏ\u02df\u02e5\u02d2\u02df\u02ff\u02efˠ\u030b\u02df\u02e6\u02f3\u02df\u02ea\u0305ˠ\u02f4\u02dfˣ\u0309\u02df\u02ea\u0305ˠ\u0309\u02df\u02e5\u0315\u02df\u0300\u200c،\u200c،ˢ\u02ef\u02dfˡ\u0305\u02dfˠ\u02dfˤ\u200c،\u0301\u0305ˠ\u0314\u02df\u02e5\u02ef\u02df\u0302\u02efˠ\u0308\u02df\u02e6\u02ef\u02df\u02f2\u0305ˠ\u0306\u02df\u02e5ˎ\u02df\u02f8\u02ef\u200c،\u200c،\u200c،\u02ef\u0305ˠˏ\u02df\u02e5\u02d2\u02df\u02ff\u02efˠ\u030b\u02df\u02e6\u02f3\u02df\u02e7\u02dfˠ\u02f4\u02dfˣ\u0309\u200c،\u200c،ˎ\u200c،\u0305\u200c،\u02efˠ\u02ef\u02df\u02e6\u02e7\u02df\u0300\u0315ˠ\u0309\u02df\u02e6\u02f3\u02df\u02f7\u0315ˠˎ\u02dfˤ\u02f7\u02df\u02f8\u02efˠ\u0317\u02df\u02e6\u02eb\u02df\u02ff\u02efˠ\u0314\u02df\u02e5\u02d2\u200c،\u200c،\u0316\u02dfˡ\u02d2\u02df\u02eb\u0315\u02df\u0313\u02dfˢ\u200c،\u02ea\u0305\u02df\u0315\u200c،\u200c،\u02ed\u200c،\u02e7\u200c،ˣ\u02df\u02ef\u02efˠ\u0318\u02df\u02e6\u02eb\u02df\u02f8\u02efˠ\u0312\u02df\u02e5\u02e7\u02df\u0300\u02dfˠ\u02d3\u02dfˡ\u200c،\u02f4\u0305ˠ\u030a\u02df\u02e6\u02e7\u02df\u0301\u0315ˠ\u030e\u02df\u02e5\u02d6\u02df\u0300\u0305\u200c،\u02dfˢˣ\u02df\u02ea\u0305\u02df\u0318\u02dfˡ\u02d2\u02df\u02eb\u200c،\u0313\u02dfˢ\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،ˠ\u02ef\u200c،\u02df\u02eb\u200c،\u200c،ˣˢ\u0305\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u200c،\u02df", "\u200c،", "\u02df\u02df");
		string result = default(string);
		Assembly object_ = default(Assembly);
		object obj = default(object);
		string string_ = default(string);
		while (true)
		{
			int num = 982324447;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1825FFEDu) % 7u)
				{
				case 6u:
					result = text;
					num = ((int)num2 * -1112204382) ^ 0x18EAB21E;
					continue;
				case 5u:
					object_ = smethod_3((byte[])obj, bool_3: true);
					num = ((int)num2 * -2083553352) ^ -1739920688;
					continue;
				case 3u:
					smethod_7(object_);
					num = ((int)num2 * -1728684112) ^ -1098796015;
					continue;
				case 2u:
					string_ = smethod_4(text);
					num = (int)(num2 * 1522212984) ^ -480077381;
					continue;
				case 1u:
					obj = GForm1.smethod_78(smethod_6(GForm1.smethod_77(string_)));
					num = ((int)num2 * -178851618) ^ 0x1F5A3F22;
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
		int num = 251367135;
		object result = default(object);
		bool flag = default(bool);
		while (true)
		{
			int num2 = -778193062;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0x90898226u) % 12u)
				{
				case 11u:
					result = GForm1.smethod_79(char_0, 0, 22528);
					num2 = (int)((num3 * 645220051) ^ 0x6F703BE2);
					continue;
				case 10u:
				{
					int num6;
					if (num == 251367153)
					{
						num2 = -101709892;
						num6 = -101709892;
					}
					else
					{
						num2 = -938795224;
						num6 = -938795224;
					}
					continue;
				}
				case 8u:
					num2 = ((int)num3 * -2001841073) ^ -176676129;
					continue;
				case 6u:
					num = 251367192;
					num2 = ((int)num3 * -209591002) ^ 0x3674287E;
					continue;
				case 5u:
					num = 251367199;
					num2 = ((int)num3 * -442293611) ^ -299729022;
					continue;
				case 4u:
					flag = num == 251367143;
					num2 = ((int)num3 * -4408442) ^ 0x16B55E61;
					continue;
				case 3u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = -867908909;
						num5 = -867908909;
					}
					else
					{
						num4 = -1969483880;
						num5 = -1969483880;
					}
					num2 = num4 ^ ((int)num3 * -94045283);
					continue;
				}
				case 2u:
					num = 251367175;
					num2 = -405425267;
					continue;
				case 1u:
					num2 = ((int)num3 * -671057823) ^ 0x2C83E667;
					continue;
				case 0u:
					num2 = ((int)num3 * -1980637986) ^ -1465163669;
					continue;
				case 7u:
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
		while (true)
		{
			int num = 969002178;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x24C59BC6u) % 3u)
				{
				case 1u:
					goto IL_000d;
				case 2u:
					break;
				default:
					return result;
				}
				break;
				IL_000d:
				num = (int)((num2 * 649617185) ^ 0xEAADBEC);
			}
		}
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
