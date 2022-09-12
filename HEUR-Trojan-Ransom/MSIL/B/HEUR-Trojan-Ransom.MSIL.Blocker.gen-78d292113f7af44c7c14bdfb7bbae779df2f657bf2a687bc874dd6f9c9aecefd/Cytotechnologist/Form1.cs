using System;
using System.ComponentModel;
using System.Drawing;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;

namespace Cytotechnologist;

public class Form1 : Form
{
	public class Figurine
	{
		public bool Dark;

		public bool Big;

		public bool Square;

		public bool Point;

		public Figurine(bool dark, bool big, bool square, bool point)
		{
			Dark = dark;
			Big = big;
			Square = square;
			Point = point;
		}

		public Figurine(Figurine copy)
		{
			while (true)
			{
				int num = 1141454719;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x16108566u) % 7u)
					{
					case 5u:
						Dark = copy.Dark;
						num = ((int)num2 * -1905128867) ^ -1571917869;
						continue;
					case 3u:
						Square = copy.Square;
						num = ((int)num2 * -1141754504) ^ -1122872950;
						continue;
					case 2u:
						Big = copy.Big;
						num = ((int)num2 * -1843306922) ^ -1861200296;
						continue;
					case 1u:
						num = ((int)num2 * -4884053) ^ -2140350441;
						continue;
					case 0u:
						Point = copy.Point;
						num = ((int)num2 * -360508522) ^ 0x6D802B7C;
						continue;
					default:
						return;
					case 6u:
						break;
					case 4u:
						return;
					}
					break;
				}
			}
		}
	}

	private Form menu;

	private Random rnd = Form1.smethod_0();

	private Figurine[,] storage;

	private Figurine[,] board;

	private readonly int size = 60;

	public bool turn;

	private DateTime time;

	private int step;

	private PictureBox[,] pictureBox;

	private PictureBox[,] borderBox;

	private IContainer components = null;

	private static Type ComMember;

	private PictureBox pictureBox1;

	private Button button2;

	private Button button1;

	private RichTextBox richTextBox1;

	private Panel panel1;

	private Label label1;

	private Label label2;

	private Label label5;

	private Label label6;

	public Timer timer1;

	public Form1()
	{
		//IL_02c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d2: Expected O, but got Unknown
		int num5 = default(int);
		bool flag2 = default(bool);
		int num6 = default(int);
		double num10 = default(double);
		bool flag = default(bool);
		while (true)
		{
			int num = -1796924024;
			while (true)
			{
				uint num2;
				double num7;
				switch ((num2 = (uint)num ^ 0x940AA0F8u) % 27u)
				{
				case 26u:
					num5++;
					num = (int)((num2 * 65987298) ^ 0x4745B7FF);
					continue;
				case 25u:
				{
					Form3 form_ = new Form3();
					Form1.smethod_10((Form)(object)form_, (Form)(object)this);
					menu = (Form)(object)form_;
					num = ((int)num2 * -236821805) ^ 0x3A093DE3;
					continue;
				}
				case 24u:
					flag2 = num5 < 4;
					num = -1214120656;
					continue;
				case 23u:
					num = -1281730944;
					continue;
				case 22u:
					Form1.smethod_9(Form1.smethod_8((Control)(object)panel1), (Control)(object)pictureBox[num6, num5]);
					num = (int)((num2 * 590226887) ^ 0x7969AD48);
					continue;
				case 21u:
					InitializeComponent();
					num = (int)((num2 * 368165034) ^ 0x3594DC53);
					continue;
				case 20u:
					num5 = 0;
					num = -1010599985;
					continue;
				case 19u:
					Form1.smethod_11((Control)(object)menu);
					num = (int)((num2 * 1743809479) ^ 0x70D6D550);
					continue;
				case 18u:
					if (num5 >= 2)
					{
						num = (int)(num2 * 784832886) ^ -1544156362;
						continue;
					}
					num7 = 0.0;
					goto IL_010d;
				case 17u:
					num = (int)((num2 * 193503266) ^ 0x7F9E8664);
					continue;
				case 16u:
					num = (int)((num2 * 513229469) ^ 0x17B249CF);
					continue;
				case 14u:
					num = ((int)num2 * -1453693975) ^ -464323267;
					continue;
				case 13u:
				{
					int num13;
					int num14;
					if (!flag2)
					{
						num13 = 220366063;
						num14 = 220366063;
					}
					else
					{
						num13 = 351794284;
						num14 = 351794284;
					}
					num = num13 ^ (int)(num2 * 1426459814);
					continue;
				}
				case 12u:
				{
					PictureBox[,] array2 = borderBox;
					int num11 = num6;
					int num12 = num5;
					PictureBox obj2 = Form1.smethod_2();
					Form1.smethod_3((Control)(object)obj2, new Size(size - 2, size - 2));
					Form1.smethod_4((Control)(object)obj2, new Point(1 + (int)(((double)num5 + num10) * (double)size), 1 + num6 * size));
					Form1.smethod_7((Control)(object)obj2, bool_0: false);
					array2[num11, num12] = obj2;
					num = (int)((num2 * 52498828) ^ 0x1038B68D);
					continue;
				}
				case 11u:
				{
					PictureBox[,] array = pictureBox;
					int num8 = num6;
					int num9 = num5;
					PictureBox obj = Form1.smethod_2();
					Form1.smethod_3((Control)(object)obj, new Size(size - 8, size - 8));
					Form1.smethod_4((Control)(object)obj, new Point(4 + (int)(((double)num5 + num10) * (double)size), 4 + num6 * size));
					Form1.smethod_5((Control)(object)obj, Color.White);
					array[num8, num9] = obj;
					num = ((int)num2 * -968419668) ^ 0x5D409A4;
					continue;
				}
				case 10u:
					num = ((int)num2 * -2120354075) ^ -28063093;
					continue;
				case 9u:
					Form1.smethod_1(richTextBox1, (HorizontalAlignment)2);
					num = ((int)num2 * -1618009416) ^ 0x6BD107;
					continue;
				case 8u:
					pictureBox = new PictureBox[4, 4];
					borderBox = new PictureBox[4, 4];
					num6 = 0;
					num = ((int)num2 * -208808467) ^ 0x53767AA7;
					continue;
				case 7u:
					Form1.smethod_6((Control)(object)pictureBox[num6, num5], new MouseEventHandler(PictureBoxIJ_MouseDown));
					num = ((int)num2 * -2018759584) ^ 0x3CB2F6A0;
					continue;
				case 6u:
					num7 = 4.1;
					goto IL_010d;
				case 5u:
					num6++;
					num = (int)(num2 * 387155508) ^ -1484354127;
					continue;
				case 4u:
					Form1.smethod_9(Form1.smethod_8((Control)(object)panel1), (Control)(object)borderBox[num6, num5]);
					num = (int)((num2 * 1461413021) ^ 0x20EE8027);
					continue;
				case 3u:
					num = (int)((num2 * 416759323) ^ 0xEF4FD08);
					continue;
				case 2u:
					flag = num6 < 4;
					num = -1657825816;
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = 1673144797;
						num4 = 1673144797;
					}
					else
					{
						num3 = 250661618;
						num4 = 250661618;
					}
					num = num3 ^ ((int)num2 * -1202031370);
					continue;
				}
				default:
					return;
				case 15u:
					break;
				case 0u:
					return;
					IL_010d:
					num10 = num7;
					num = -672712911;
					continue;
				}
				break;
			}
		}
	}

	private void Form1_LocationChanged(object sender, EventArgs e)
	{
		Form1.smethod_13(menu, new Point(Form1.smethod_12((Form)(object)this).X + 8, Form1.smethod_12((Form)(object)this).Y + 51));
		while (true)
		{
			int num = -808109141;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD05816ADu) % 3u)
				{
				case 1u:
					goto IL_0033;
				default:
					return;
				case 0u:
					break;
				case 2u:
					return;
				}
				break;
				IL_0033:
				num = ((int)num2 * -2054092315) ^ 0x52A8993E;
			}
		}
	}

	private void Form1_Shown(object sender, EventArgs e)
	{
		Form1.smethod_14(menu);
	}

	public void Button1_Click(object sender, EventArgs e)
	{
		bool flag = default(bool);
		while (true)
		{
			int num = -1435679821;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xFF5423B6u) % 10u)
				{
				case 9u:
					flag = Form1.smethod_16((Control)(object)menu) < 296;
					num = -615359745;
					continue;
				case 7u:
					num = -1235980912;
					continue;
				case 6u:
					num = (int)(num2 * 1415133000) ^ -322081959;
					continue;
				case 5u:
					num = (int)(num2 * 151479650) ^ -644155505;
					continue;
				case 4u:
				{
					Form control_ = menu;
					Form1.smethod_17((Control)(object)control_, Form1.smethod_16((Control)(object)control_) + 5);
					num = (int)(num2 * 619328972) ^ -985734406;
					continue;
				}
				case 3u:
					Form1.smethod_15(timer1);
					num = ((int)num2 * -1819361514) ^ -479816269;
					continue;
				case 2u:
					Form1.smethod_14(menu);
					num = ((int)num2 * -343777566) ^ 0x6C260E34;
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = 536724882;
						num4 = 536724882;
					}
					else
					{
						num3 = 1753187621;
						num4 = 1753187621;
					}
					num = num3 ^ (int)(num2 * 1574549902);
					continue;
				}
				default:
					return;
				case 0u:
					break;
				case 8u:
					return;
				}
				break;
			}
		}
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		bool flag2 = default(bool);
		int num4 = default(int);
		bool flag = default(bool);
		int num3 = default(int);
		while (true)
		{
			int num = 648807688;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3DBD613u) % 22u)
				{
				case 21u:
					flag2 = num4 < 4;
					num = 1974277348;
					continue;
				case 20u:
					num = 1272290809;
					continue;
				case 19u:
					num = (int)((num2 * 744605684) ^ 0x7EBEA243);
					continue;
				case 18u:
					num4++;
					num = (int)((num2 * 548177938) ^ 0x3F6457A2);
					continue;
				case 17u:
				{
					int num7;
					int num8;
					if (flag2)
					{
						num7 = -1992157030;
						num8 = -1992157030;
					}
					else
					{
						num7 = -1595560165;
						num8 = -1595560165;
					}
					num = num7 ^ ((int)num2 * -677293577);
					continue;
				}
				case 16u:
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: false);
					num = (int)((num2 * 1991399827) ^ 0x3225F57B);
					continue;
				case 15u:
					num = (int)((num2 * 440557447) ^ 0x113027D2);
					continue;
				case 14u:
					flag = num3 < 4;
					num = 1008451012;
					continue;
				case 13u:
					board = new Figurine[4, 4];
					storage = new Figurine[4, 4];
					num = ((int)num2 * -2106649125) ^ 0x10D5BF36;
					continue;
				case 12u:
					Paint_Storage();
					Form1.smethod_7((Control)(object)button2, bool_0: false);
					num = (int)((num2 * 1897100118) ^ 0x41D05EE9);
					continue;
				case 10u:
					storage[num3, num4] = new Figurine(num3 < 2, num4 % 2 == 0, num4 < 2, num3 % 2 == 1);
					num = ((int)num2 * -1391045294) ^ 0x62AC27F5;
					continue;
				case 9u:
					Paint_Board();
					num = (int)(num2 * 831216374) ^ -714651093;
					continue;
				case 8u:
					num = ((int)num2 * -335558985) ^ -1771365756;
					continue;
				case 6u:
					num = (int)((num2 * 382932279) ^ 0x4E049BB4);
					continue;
				case 5u:
				{
					int num5;
					int num6;
					if (flag)
					{
						num5 = 1286022995;
						num6 = 1286022995;
					}
					else
					{
						num5 = 971679943;
						num6 = 971679943;
					}
					num = num5 ^ ((int)num2 * -1775182211);
					continue;
				}
				case 4u:
					Form1.smethod_7((Control)(object)pictureBox[num3, num4], bool_0: false);
					num = (int)((num2 * 1511023168) ^ 0x1A8FF0F2);
					continue;
				case 3u:
					num3++;
					num = (int)((num2 * 753099260) ^ 0xFB2F4EF);
					continue;
				case 2u:
					Form1.smethod_5((Control)(object)borderBox[num3, num4], Color.White);
					num = ((int)num2 * -404613698) ^ -2142836862;
					continue;
				case 1u:
					num4 = 0;
					num = 1324581765;
					continue;
				case 0u:
					num3 = 0;
					num = ((int)num2 * -784856152) ^ 0x549F7713;
					continue;
				default:
					return;
				case 11u:
					break;
				case 7u:
					return;
				}
				break;
			}
		}
	}

	private void Paint_Board()
	{
		Graphics graphics_ = default(Graphics);
		int num6 = default(int);
		int num12 = default(int);
		bool flag = default(bool);
		bool square = default(bool);
		bool big = default(bool);
		Brush brush_ = default(Brush);
		float num9 = default(float);
		float num4 = default(float);
		bool point = default(bool);
		float num8 = default(float);
		float num5 = default(float);
		float num3 = default(float);
		while (true)
		{
			int num = 243744749;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE7C0B0Du) % 42u)
				{
				case 41u:
					Form1.smethod_24(graphics_, Form1.smethod_23(), ((float)num6 + 0.05f) * (float)size, ((float)num12 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					num = ((int)num2 * -39908785) ^ -69456110;
					continue;
				case 40u:
					flag = board[num12, num6] != null;
					num = ((int)num2 * -1501158381) ^ -1083582377;
					continue;
				case 39u:
				{
					int num20;
					int num21;
					if (square)
					{
						num20 = 103573803;
						num21 = 103573803;
					}
					else
					{
						num20 = 1530194521;
						num21 = 1530194521;
					}
					num = num20 ^ (int)(num2 * 26303123);
					continue;
				}
				case 38u:
					Form1.smethod_20(pictureBox1, (Image)(object)Form1.smethod_19(Form1.smethod_18((Control)(object)pictureBox1), Form1.smethod_16((Control)(object)pictureBox1)));
					num = (int)(num2 * 1145212980) ^ -839708520;
					continue;
				case 37u:
					big = board[num12, num6].Big;
					num = 1088054015;
					continue;
				case 36u:
				{
					int num16;
					int num17;
					if (!big)
					{
						num16 = -275809881;
						num17 = -275809881;
					}
					else
					{
						num16 = -1328702030;
						num17 = -1328702030;
					}
					num = num16 ^ (int)(num2 * 1296711188);
					continue;
				}
				case 35u:
					Form1.smethod_24(graphics_, brush_, num9 + (float)(num6 * size), num9 + (float)(num12 * size), num4, num4);
					num = 588709798;
					continue;
				case 34u:
					point = board[num12, num6].Point;
					num = (int)((num2 * 1960917135) ^ 0x2515D1F6);
					continue;
				case 33u:
					Form1.smethod_24(graphics_, (Brush)(object)Form1.smethod_29(Color.FromArgb(180, Color.Peru)), num9 + (float)(num6 * size), num9 + (float)(num12 * size), num4, num4);
					num = ((int)num2 * -610154910) ^ 0x1864CD5F;
					continue;
				case 32u:
					square = board[num12, num6].Square;
					num = (int)((num2 * 1309708868) ^ 0xC0059A2);
					continue;
				case 31u:
					Form1.smethod_28(graphics_, brush_, num9 + (float)(num6 * size), num9 + (float)(num12 * size), num4, num4);
					num = ((int)num2 * -499875780) ^ -212930535;
					continue;
				case 30u:
					num = ((int)num2 * -1928891247) ^ 0x254332CD;
					continue;
				case 29u:
					num = (int)(num2 * 1101212336) ^ -205550024;
					continue;
				case 28u:
					num = ((int)num2 * -1665981871) ^ 0x5FBF6F86;
					continue;
				case 27u:
					brush_ = Form1.smethod_26();
					num = 703546712;
					continue;
				case 26u:
					num8 = 1f - num5 * 0.9f / (float)Form1.smethod_27(2.0);
					num = 31355788;
					continue;
				case 25u:
					num5 = 1f;
					num = ((int)num2 * -81966856) ^ 0x43B97FB0;
					continue;
				case 24u:
					num12++;
					num = (int)(num2 * 1990921795) ^ -1590974634;
					continue;
				case 23u:
					num = (int)((num2 * 1238458258) ^ 0x7805BD8F);
					continue;
				case 22u:
					num5 = 0.7f;
					num = 1677269813;
					continue;
				case 21u:
				{
					int num18;
					int num19;
					if (!point)
					{
						num18 = -633513085;
						num19 = -633513085;
					}
					else
					{
						num18 = -308414242;
						num19 = -308414242;
					}
					num = num18 ^ ((int)num2 * -1279925572);
					continue;
				}
				case 20u:
					num12 = 0;
					num = (int)(num2 * 131929883) ^ -1791799434;
					continue;
				case 19u:
					num4 = num3 * 0.4f / (float)Form1.smethod_27(2.0);
					num = (int)(num2 * 218647662) ^ -1597795983;
					continue;
				case 18u:
					brush_ = Form1.smethod_25();
					num = (int)(num2 * 831708464) ^ -529165192;
					continue;
				case 16u:
				{
					int num14;
					int num15;
					if (board[num12, num6].Dark)
					{
						num14 = 1211760551;
						num15 = 1211760551;
					}
					else
					{
						num14 = 1504868304;
						num15 = 1504868304;
					}
					num = num14 ^ (int)(num2 * 202422354);
					continue;
				}
				case 15u:
				{
					int num13;
					if (num12 >= 4)
					{
						num = 1298029766;
						num13 = 1298029766;
					}
					else
					{
						num = 116972756;
						num13 = 116972756;
					}
					continue;
				}
				case 14u:
				{
					int num10;
					int num11;
					if (flag)
					{
						num10 = -1395964495;
						num11 = -1395964495;
					}
					else
					{
						num10 = -1327772808;
						num11 = -1327772808;
					}
					num = num10 ^ (int)(num2 * 1858403957);
					continue;
				}
				case 13u:
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox1));
					num = (int)((num2 * 1035625994) ^ 0x3E490FB9);
					continue;
				case 12u:
					num9 = (float)size * (num8 / 2f);
					num = ((int)num2 * -1209590164) ^ -1511077842;
					continue;
				case 11u:
					num8 = 1f - num5 * 0.4f / (float)Form1.smethod_27(2.0);
					num9 = (float)size * (num8 / 2f);
					num = 1537671778;
					continue;
				case 10u:
					num = 1768899420;
					continue;
				case 9u:
					num6++;
					num = 824237457;
					continue;
				case 8u:
					num = ((int)num2 * -1745876016) ^ -1096833253;
					continue;
				case 7u:
					Form1.smethod_30((Control)(object)pictureBox1);
					num = ((int)num2 * -734212305) ^ -219236601;
					continue;
				case 6u:
				{
					int num7;
					if (num6 >= 4)
					{
						num = 1604857927;
						num7 = 1604857927;
					}
					else
					{
						num = 1125524873;
						num7 = 1125524873;
					}
					continue;
				}
				case 5u:
					num6 = 0;
					num = 824237457;
					continue;
				case 4u:
					num = 1578426426;
					continue;
				case 3u:
					num3 = (float)size * num5;
					num = ((int)num2 * -367745589) ^ 0x2C373E1E;
					continue;
				case 1u:
					num4 = num3 * 0.9f / (float)Form1.smethod_27(2.0);
					num = ((int)num2 * -872901581) ^ 0x687A22C2;
					continue;
				case 0u:
					num = (int)(num2 * 2022152653) ^ -2053031965;
					continue;
				default:
					return;
				case 2u:
					break;
				case 17u:
					return;
				}
				break;
			}
		}
	}

	private void Paint_Storage()
	{
		int num = 0;
		Brush brush_ = default(Brush);
		bool big = default(bool);
		int num4 = default(int);
		bool point = default(bool);
		Graphics graphics_ = default(Graphics);
		float num7 = default(float);
		float num8 = default(float);
		float num10 = default(float);
		float num11 = default(float);
		float num9 = default(float);
		bool flag2 = default(bool);
		while (true)
		{
			bool flag = num < 4;
			int num2 = -976501155;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0xEFB0E8ACu) % 38u)
				{
				case 37u:
					num2 = (int)(num3 * 692929358) ^ -1352184058;
					continue;
				case 36u:
					brush_ = Form1.smethod_25();
					num2 = (int)(num3 * 322072921) ^ -1057167313;
					continue;
				case 35u:
					big = storage[num, num4].Big;
					num2 = -156640303;
					continue;
				case 34u:
				{
					int num14;
					if (num4 >= 4)
					{
						num2 = -963203621;
						num14 = -963203621;
					}
					else
					{
						num2 = -1689586621;
						num14 = -1689586621;
					}
					continue;
				}
				case 33u:
				{
					int num21;
					int num22;
					if (!point)
					{
						num21 = 1544542410;
						num22 = 1544542410;
					}
					else
					{
						num21 = 1777511907;
						num22 = 1777511907;
					}
					num2 = num21 ^ ((int)num3 * -914894245);
					continue;
				}
				case 32u:
					Form1.smethod_24(graphics_, (Brush)(object)Form1.smethod_29(Color.FromArgb(180, Color.Peru)), num7, num7, num8, num8);
					num2 = ((int)num3 * -2058688181) ^ 0x644CA595;
					continue;
				case 31u:
					num7 = (float)size * (num10 / 2f) - 4f;
					num8 = num11 * 0.4f / (float)Form1.smethod_27(2.0);
					point = storage[num, num4].Point;
					num2 = (int)((num3 * 200207024) ^ 0x2E3ABA39);
					continue;
				case 30u:
					Form1.smethod_20(pictureBox[num, num4], (Image)(object)Form1.smethod_19(Form1.smethod_18((Control)(object)pictureBox[num, num4]), Form1.smethod_16((Control)(object)pictureBox[num, num4])));
					num2 = ((int)num3 * -1197394679) ^ -1443536588;
					continue;
				case 29u:
				{
					int num15;
					int num16;
					if (!big)
					{
						num15 = -257593413;
						num16 = -257593413;
					}
					else
					{
						num15 = -1114887138;
						num16 = -1114887138;
					}
					num2 = num15 ^ ((int)num3 * -850188507);
					continue;
				}
				case 28u:
					num2 = ((int)num3 * -131100234) ^ -261972717;
					continue;
				case 27u:
				{
					num8 = num11 * 0.9f / (float)Form1.smethod_27(2.0);
					int num19;
					int num20;
					if (num4 >= 2)
					{
						num19 = 320514451;
						num20 = 320514451;
					}
					else
					{
						num19 = 848399567;
						num20 = 848399567;
					}
					num2 = num19 ^ (int)(num3 * 914383409);
					continue;
				}
				case 26u:
					Form1.smethod_24(graphics_, brush_, num7, num7, num8, num8);
					num2 = -188603547;
					continue;
				case 25u:
				{
					int num17;
					int num18;
					if (!flag)
					{
						num17 = -1157768967;
						num18 = -1157768967;
					}
					else
					{
						num17 = -262337727;
						num18 = -262337727;
					}
					num2 = num17 ^ (int)(num3 * 1895605583);
					continue;
				}
				case 24u:
					num9 = 0.7f;
					num2 = -939722373;
					continue;
				case 23u:
					num9 = 1f;
					num2 = (int)(num3 * 535593973) ^ -200845681;
					continue;
				case 22u:
				{
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox[num, num4]));
					int num12;
					int num13;
					if (!storage[num, num4].Dark)
					{
						num12 = -1207305611;
						num13 = -1207305611;
					}
					else
					{
						num12 = -1672639292;
						num13 = -1672639292;
					}
					num2 = num12 ^ ((int)num3 * -1938113306);
					continue;
				}
				case 21u:
					num10 = 1f - num9 * 0.9f / (float)Form1.smethod_27(2.0);
					num11 = (float)size * num9;
					num2 = -454136857;
					continue;
				case 20u:
					num2 = (int)((num3 * 1887180331) ^ 0xC2D70C);
					continue;
				case 19u:
					brush_ = Form1.smethod_26();
					num2 = -549506885;
					continue;
				case 18u:
					num2 = (int)(num3 * 1086309167) ^ -1601067544;
					continue;
				case 17u:
					num2 = ((int)num3 * -987273085) ^ 0x148761D9;
					continue;
				case 16u:
					num2 = ((int)num3 * -1311300660) ^ 0x467CF8CC;
					continue;
				case 15u:
					num7 = (float)size * (num10 / 2f) - 4f;
					num2 = ((int)num3 * -142092571) ^ 0x58682B42;
					continue;
				case 14u:
					num4 = 0;
					num2 = -2043176563;
					continue;
				case 13u:
					num2 = ((int)num3 * -835906267) ^ 0xC0C79A9;
					continue;
				case 12u:
					num2 = -690103778;
					continue;
				case 11u:
					num2 = (int)(num3 * 1349005658) ^ -1442913755;
					continue;
				case 10u:
					Form1.smethod_28(graphics_, brush_, num7, num7, num8, num8);
					num2 = ((int)num3 * -108232021) ^ 0x3BA59458;
					continue;
				case 9u:
					num2 = ((int)num3 * -532558972) ^ -1519690858;
					continue;
				case 7u:
					flag2 = storage[num, num4] != null;
					num2 = -1489421617;
					continue;
				case 6u:
					num10 = 1f - num9 * 0.4f / (float)Form1.smethod_27(2.0);
					num2 = -1991445123;
					continue;
				case 5u:
				{
					int num5;
					int num6;
					if (flag2)
					{
						num5 = 1136885091;
						num6 = 1136885091;
					}
					else
					{
						num5 = 1104343264;
						num6 = 1104343264;
					}
					num2 = num5 ^ (int)(num3 * 1289819290);
					continue;
				}
				case 3u:
					Form1.smethod_30((Control)(object)pictureBox[num, num4]);
					num2 = -2107451638;
					continue;
				case 2u:
					num4++;
					num2 = -863511662;
					continue;
				case 1u:
					num++;
					num2 = (int)(num3 * 1772488082) ^ -1926526740;
					continue;
				case 0u:
					num2 = (int)((num3 * 1248603375) ^ 0x6E2AFDEB);
					continue;
				default:
					return;
				case 4u:
					break;
				case 8u:
					return;
				}
				break;
			}
		}
	}

	public void StartGame()
	{
		Form1_Load(this, Form1.smethod_31());
		int num5 = default(int);
		int num3 = default(int);
		bool flag2 = default(bool);
		bool flag = default(bool);
		int num6 = default(int);
		int num7 = default(int);
		while (true)
		{
			int num = 753302971;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7D0B7B9Au) % 32u)
				{
				case 31u:
					num5 = 0;
					num = ((int)num2 * -748892292) ^ -255934204;
					continue;
				case 30u:
					step = 0;
					num = ((int)num2 * -2109656782) ^ 0x1886628E;
					continue;
				case 29u:
					time = new DateTime(0L, DateTimeKind.Unspecified);
					num = ((int)num2 * -662470161) ^ 0x61F76D35;
					continue;
				case 28u:
					Form1.smethod_35(timer1, bool_0: true);
					Form1.smethod_36(timer1);
					num = (int)((num2 * 1650195106) ^ 0x1E0B745B);
					continue;
				case 27u:
					Form1.smethod_7((Control)(object)pictureBox[num5, num3], bool_0: true);
					num = 314585513;
					continue;
				case 26u:
					num = ((int)num2 * -431030584) ^ -1168900494;
					continue;
				case 24u:
					flag2 = num5 < 4;
					num = 803913361;
					continue;
				case 23u:
					num = (int)(num2 * 2122503830) ^ -2072171342;
					continue;
				case 22u:
					num = (int)((num2 * 1631129823) ^ 0x276F61F2);
					continue;
				case 21u:
					num = ((int)num2 * -2082528000) ^ -114606283;
					continue;
				case 20u:
					num3++;
					num = ((int)num2 * -418218878) ^ -1507714224;
					continue;
				case 19u:
					num = (int)((num2 * 298973457) ^ 0x2905146D);
					continue;
				case 18u:
					Form1.smethod_32((Control)(object)label2, Form1.smethod_34("Ход: ", step.ToString()));
					num = 701550711;
					continue;
				case 17u:
					num5++;
					num = ((int)num2 * -1682484866) ^ 0x3C15C63C;
					continue;
				case 16u:
					num = 1810405276;
					continue;
				case 15u:
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: true);
					num = ((int)num2 * -2018897563) ^ -2117354757;
					continue;
				case 14u:
					num3 = 0;
					num = 1181749292;
					continue;
				case 13u:
					num = (int)(num2 * 1881500085) ^ -1273847562;
					continue;
				case 12u:
					Form1.smethod_32((Control)(object)richTextBox1, "Противник выбрал фигуру. Выберете поле на доске для установки этой фигуры.");
					step = 1;
					num = (int)((num2 * 1244290890) ^ 0x3D49F475);
					continue;
				case 11u:
				{
					int num10;
					int num11;
					if (!flag2)
					{
						num10 = -364521823;
						num11 = -364521823;
					}
					else
					{
						num10 = -2066432984;
						num11 = -2066432984;
					}
					num = num10 ^ (int)(num2 * 1500131732);
					continue;
				}
				case 10u:
					num = ((int)num2 * -131351408) ^ -369049642;
					continue;
				case 9u:
				{
					int num8;
					int num9;
					if (!flag)
					{
						num8 = 1287077468;
						num9 = 1287077468;
					}
					else
					{
						num8 = 1718779059;
						num9 = 1718779059;
					}
					num = num8 ^ (int)(num2 * 292221990);
					continue;
				}
				case 8u:
					num = (int)((num2 * 186979574) ^ 0x598B980A);
					continue;
				case 7u:
					Form1.smethod_32((Control)(object)richTextBox1, "Ваш ход. Выберете фигуру, которой будет играть противник.");
					num = (int)(num2 * 87915772) ^ -2028873926;
					continue;
				case 6u:
					num6 = Form1.smethod_33(rnd, 4);
					num7 = Form1.smethod_33(rnd, 4);
					num = ((int)num2 * -843422230) ^ 0x66EA09E3;
					continue;
				case 5u:
					Form1.smethod_5((Control)(object)borderBox[num6, num7], Color.Blue);
					num = ((int)num2 * -803741754) ^ -10572527;
					continue;
				case 4u:
					num = (int)(num2 * 969802117) ^ -2044762128;
					continue;
				case 2u:
				{
					int num4;
					if (num3 >= 4)
					{
						num = 1491277611;
						num4 = 1491277611;
					}
					else
					{
						num = 2078114305;
						num4 = 2078114305;
					}
					continue;
				}
				case 1u:
					flag = turn;
					num = (int)((num2 * 1039231155) ^ 0x4B0ABE60);
					continue;
				case 0u:
					num = ((int)num2 * -1164117750) ^ 0x662B3008;
					continue;
				default:
					return;
				case 3u:
					break;
				case 25u:
					return;
				}
				break;
			}
		}
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
		while (true)
		{
			int num = -1836480312;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9136AAEFu) % 4u)
				{
				case 3u:
					time = time.AddSeconds(1.0);
					num = ((int)num2 * -659709749) ^ -451182420;
					continue;
				case 2u:
					Form1.smethod_32((Control)(object)label1, Form1.smethod_34("Время: ", time.ToString("HH:mm:ss")));
					num = (int)(num2 * 1473130954) ^ -481035594;
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

	private void PictureBoxIJ_MouseDown(object sender, MouseEventArgs e)
	{
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Expected O, but got Unknown
		int num = Form1.smethod_37((Control)((sender is PictureBox) ? sender : null)).Y / size;
		Point point = Form1.smethod_37((Control)((sender is PictureBox) ? sender : null));
		bool flag2 = default(bool);
		int num6 = default(int);
		bool flag = default(bool);
		int num5 = default(int);
		int num4 = default(int);
		while (true)
		{
			int num2 = -9130080;
			while (true)
			{
				uint num3;
				int num7;
				switch ((num3 = (uint)num2 ^ 0x941E5C36u) % 21u)
				{
				case 20u:
					flag2 = num6 < 4;
					num2 = -157522552;
					continue;
				case 19u:
					Form1.smethod_32((Control)(object)richTextBox1, "Именно эта фигура? Если да - нажмите \"Подтвердить\".");
					num2 = (int)(num3 * 1796490961) ^ -2038962901;
					continue;
				case 17u:
				{
					int num12;
					int num13;
					if (flag)
					{
						num12 = 967532719;
						num13 = 967532719;
					}
					else
					{
						num12 = 45248098;
						num13 = 45248098;
					}
					num2 = num12 ^ ((int)num3 * -1169204102);
					continue;
				}
				case 16u:
				{
					int num8;
					int num9;
					if (num5 <= 1)
					{
						num8 = 289653187;
						num9 = 289653187;
					}
					else
					{
						num8 = 148431589;
						num9 = 148431589;
					}
					num2 = num8 ^ ((int)num3 * -2121194569);
					continue;
				}
				case 15u:
					Form1.smethod_5((Control)(object)borderBox[num, num5], Color.Red);
					num2 = (int)((num3 * 173396437) ^ 0x5BA57A61);
					continue;
				case 14u:
					num2 = ((int)num3 * -1674975864) ^ 0x12EA200C;
					continue;
				case 13u:
				{
					int num10;
					int num11;
					if (flag2)
					{
						num10 = 558041711;
						num11 = 558041711;
					}
					else
					{
						num10 = 1093043602;
						num11 = 1093043602;
					}
					num2 = num10 ^ ((int)num3 * -748483922);
					continue;
				}
				case 12u:
					num6 = 0;
					num2 = -1222681172;
					continue;
				case 11u:
					num5 -= 4;
					num2 = (int)(num3 * 2133846395) ^ -1526481744;
					continue;
				case 10u:
					num4++;
					num2 = (int)(num3 * 1960513244) ^ -1283163920;
					continue;
				case 9u:
					num6++;
					num2 = ((int)num3 * -1438594237) ^ -583378885;
					continue;
				case 8u:
					if (Form1.smethod_40((Bitmap)Form1.smethod_21(pictureBox[num, num5]), Form1.smethod_38(e), Form1.smethod_39(e)) != Color.FromArgb(0, 0, 0, 0))
					{
						num2 = -960497846;
						num7 = -960497846;
						continue;
					}
					goto IL_01a8;
				case 7u:
					num2 = (int)((num3 * 1892851805) ^ 0x4BAF9B8);
					continue;
				case 6u:
					num5 = point.X / size;
					num2 = (int)(num3 * 1163885918) ^ -360306313;
					continue;
				case 4u:
					Form1.smethod_5((Control)(object)borderBox[num4, num6], Color.White);
					num2 = -1751201493;
					continue;
				case 3u:
					if (storage[num, num5] != null)
					{
						num2 = -245021147;
						continue;
					}
					goto IL_01a8;
				case 2u:
					Form1.smethod_7((Control)(object)button2, bool_0: true);
					num2 = ((int)num3 * -1376495944) ^ -1501663447;
					continue;
				case 1u:
					num4 = 0;
					num2 = (int)((num3 * 1217361440) ^ 0x6915645E);
					continue;
				case 0u:
					flag = num4 < 4;
					num2 = -433525178;
					continue;
				default:
					return;
				case 5u:
					break;
				case 18u:
					return;
					IL_01a8:
					num2 = -1167306020;
					num7 = -1167306020;
					continue;
				}
				break;
			}
		}
	}

	private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
	{
		//IL_02b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ce: Expected O, but got Unknown
		int num6 = default(int);
		Graphics graphics_ = default(Graphics);
		int num7 = default(int);
		int num3 = default(int);
		int num4 = default(int);
		bool flag2 = default(bool);
		bool flag3 = default(bool);
		bool flag = default(bool);
		while (true)
		{
			int num = 2079650782;
			while (true)
			{
				uint num2;
				int num5;
				switch ((num2 = (uint)num ^ 0x19CA2DA5u) % 27u)
				{
				case 26u:
					num6 = 0;
					num = 1114718256;
					continue;
				case 25u:
					Form1.smethod_32((Control)(object)richTextBox1, "Уверены? Для выполнения данного хода нажмите \"Подтвердить\".");
					num = (int)((num2 * 1311742190) ^ 0x75278019);
					continue;
				case 24u:
					Form1.smethod_45(graphics_);
					num = ((int)num2 * -1622091602) ^ -1826348274;
					continue;
				case 23u:
					num7 = 0;
					num = (int)(num2 * 660593405) ^ -1856492888;
					continue;
				case 22u:
					num3 = Form1.smethod_38(e) / size;
					num = ((int)num2 * -247033625) ^ -1346133037;
					continue;
				case 21u:
					Form1.smethod_44(graphics_, Form1.smethod_21(pictureBox[num7, num6]), num3 * size + 4, num4 * size + 4, new Rectangle(0, 0, size, size), (GraphicsUnit)2);
					num = ((int)num2 * -860619852) ^ 0x27647769;
					continue;
				case 20u:
					num4 = Form1.smethod_39(e) / size;
					num = (int)(num2 * 641681640) ^ -1160387970;
					continue;
				case 19u:
				{
					int num9;
					int num10;
					if (!flag2)
					{
						num9 = 1105457010;
						num10 = 1105457010;
					}
					else
					{
						num9 = 2043247067;
						num10 = 2043247067;
					}
					num = num9 ^ (int)(num2 * 1437018850);
					continue;
				}
				case 18u:
					Paint_Board();
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox1));
					num = (int)(num2 * 2089789147) ^ -1374305348;
					continue;
				case 17u:
					num = ((int)num2 * -1276022976) ^ 0x60DA2627;
					continue;
				case 16u:
					Form1.smethod_30((Control)(object)pictureBox1);
					num = ((int)num2 * -1432896668) ^ 0x50652CB5;
					continue;
				case 15u:
					num7++;
					num = (int)((num2 * 1854062441) ^ 0x4A467F7D);
					continue;
				case 14u:
					num = ((int)num2 * -1400640839) ^ -937553332;
					continue;
				case 12u:
					flag3 = Form1.smethod_41((Control)(object)borderBox[num7, num6]) == Color.Blue;
					num = 354243392;
					continue;
				case 11u:
					num = (int)((num2 * 309051194) ^ 0x1B501776);
					continue;
				case 10u:
					num = ((int)num2 * -910436237) ^ -1884586507;
					continue;
				case 9u:
				{
					int num13;
					int num14;
					if (flag3)
					{
						num13 = -1161975239;
						num14 = -1161975239;
					}
					else
					{
						num13 = -611109835;
						num14 = -611109835;
					}
					num = num13 ^ ((int)num2 * -1118035743);
					continue;
				}
				case 8u:
					num6++;
					num = 1114718256;
					continue;
				case 7u:
				{
					int num11;
					int num12;
					if (flag)
					{
						num11 = 1796746443;
						num12 = 1796746443;
					}
					else
					{
						num11 = 278681496;
						num12 = 278681496;
					}
					num = num11 ^ ((int)num2 * -1865701569);
					continue;
				}
				case 6u:
				{
					int num8;
					if (num7 >= 4)
					{
						num = 1618042051;
						num8 = 1618042051;
					}
					else
					{
						num = 1346759795;
						num8 = 1346759795;
					}
					continue;
				}
				case 5u:
					flag2 = num6 < 4;
					num = 1875604115;
					continue;
				case 4u:
					Form1.smethod_7((Control)(object)button2, bool_0: true);
					num = ((int)num2 * -527759171) ^ -1143336474;
					continue;
				case 3u:
					if (Form1.smethod_40((Bitmap)Form1.smethod_21(pictureBox1), Form1.smethod_38(e), Form1.smethod_39(e)) != Color.FromArgb(0, 0, 0, 0))
					{
						num = ((int)num2 * -557922743) ^ -186469040;
						continue;
					}
					num5 = 0;
					goto IL_02ef;
				case 2u:
					num5 = ((board[num4, num3] == null) ? 1 : 0);
					goto IL_02ef;
				case 1u:
					Form1.smethod_43(graphics_, Form1.smethod_42(Color.Red, 3f), ((float)num3 + 0.05f) * (float)size, ((float)num4 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					num = (int)((num2 * 132655241) ^ 0x63C6258F);
					continue;
				default:
					return;
				case 0u:
					break;
				case 13u:
					return;
					IL_02ef:
					flag = (byte)num5 != 0;
					num = 1423555904;
					continue;
				}
				break;
			}
		}
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		//IL_14f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_1525: Expected O, but got Unknown
		Figurine[,] array3 = default(Figurine[,]);
		int num19 = default(int);
		int num24 = default(int);
		int num8 = default(int);
		int num7 = default(int);
		Graphics graphics_ = default(Graphics);
		int num6 = default(int);
		int num5 = default(int);
		int num9 = default(int);
		int num3 = default(int);
		int num4 = default(int);
		bool flag12 = default(bool);
		int num57 = default(int);
		bool flag = default(bool);
		int num11 = default(int);
		bool flag10 = default(bool);
		bool flag4 = default(bool);
		int num20 = default(int);
		int num31 = default(int);
		int num18 = default(int);
		int num12 = default(int);
		int num10 = default(int);
		bool flag6 = default(bool);
		int num32 = default(int);
		int num27 = default(int);
		int num13 = default(int);
		int num14 = default(int);
		bool flag13 = default(bool);
		Figurine[,] array = default(Figurine[,]);
		bool flag11 = default(bool);
		bool flag7 = default(bool);
		bool flag9 = default(bool);
		Figurine[,] array2 = default(Figurine[,]);
		bool flag5 = default(bool);
		bool flag8 = default(bool);
		bool flag3 = default(bool);
		int num15 = default(int);
		bool flag2 = default(bool);
		while (true)
		{
			int num = 1825760339;
			while (true)
			{
				uint num2;
				int num26;
				int num30;
				int num25;
				int num23;
				switch ((num2 = (uint)num ^ 0x379925DCu) % 182u)
				{
				case 181u:
				{
					int num48;
					if (array3[num19, num24] != null)
					{
						num = 1429838055;
						num48 = 1429838055;
					}
					else
					{
						num = 2118186788;
						num48 = 2118186788;
					}
					continue;
				}
				case 180u:
					Form1.smethod_5((Control)(object)borderBox[num8, num7], Color.White);
					num = (int)((num2 * 1279922808) ^ 0x3A350720);
					continue;
				case 179u:
					Form1.smethod_15(timer1);
					num = 993541662;
					continue;
				case 178u:
					Form1.smethod_43(graphics_, Form1.smethod_42(Color.LimeGreen, 3f), ((float)num6 + 0.05f) * (float)size, ((float)num5 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					num = (int)((num2 * 1776010259) ^ 0x64135B28);
					continue;
				case 177u:
					num = 1111861926;
					continue;
				case 176u:
					num9 = num3;
					num = ((int)num2 * -1081958710) ^ -992739032;
					continue;
				case 175u:
					num8++;
					num = (int)((num2 * 794893731) ^ 0x50B4CD2F);
					continue;
				case 174u:
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: false);
					num = ((int)num2 * -100595983) ^ 0x5DE574DA;
					continue;
				case 173u:
					num = 437048398;
					continue;
				case 172u:
				{
					int num47;
					if (num4 >= 4)
					{
						num = 501380389;
						num47 = 501380389;
					}
					else
					{
						num = 536672269;
						num47 = 536672269;
					}
					continue;
				}
				case 171u:
					num3++;
					num = (int)(num2 * 1929277824) ^ -535585231;
					continue;
				case 170u:
					num = (int)((num2 * 891240092) ^ 0x79E1B2CA);
					continue;
				case 169u:
				{
					int num61;
					int num62;
					if (!flag12)
					{
						num61 = -579279134;
						num62 = -579279134;
					}
					else
					{
						num61 = -556097026;
						num62 = -556097026;
					}
					num = num61 ^ (int)(num2 * 520170723);
					continue;
				}
				case 168u:
					num57 = num8;
					num = ((int)num2 * -916460497) ^ -1735169557;
					continue;
				case 167u:
					num = (int)(num2 * 419754815) ^ -836694064;
					continue;
				case 166u:
					num7 = 0;
					num = 1784748426;
					continue;
				case 165u:
					num57 = 0;
					num = ((int)num2 * -785346688) ^ -2074901944;
					continue;
				case 164u:
					num = (int)((num2 * 1369738389) ^ 0xA8F3E0E);
					continue;
				case 163u:
				{
					int num52;
					int num53;
					if (flag)
					{
						num52 = -1863197484;
						num53 = -1863197484;
					}
					else
					{
						num52 = -1036293790;
						num53 = -1036293790;
					}
					num = num52 ^ ((int)num2 * -625550886);
					continue;
				}
				case 162u:
					if (num11 == num9)
					{
						num = ((int)num2 * -377509739) ^ -552215105;
						continue;
					}
					goto IL_0262;
				case 161u:
					Form1.smethod_47(200);
					num = (int)((num2 * 2074729722) ^ 0x4FA30360);
					continue;
				case 160u:
					num = (int)(num2 * 108312528) ^ -1946292481;
					continue;
				case 159u:
				{
					int num43;
					int num44;
					if (!flag10)
					{
						num43 = 2037281083;
						num44 = 2037281083;
					}
					else
					{
						num43 = 323281638;
						num44 = 323281638;
					}
					num = num43 ^ ((int)num2 * -137210911);
					continue;
				}
				case 158u:
					num = ((int)num2 * -1760554107) ^ 0x50371E0C;
					continue;
				case 157u:
					num = (int)((num2 * 2064053532) ^ 0x2F022E7D);
					continue;
				case 156u:
					num = (int)((num2 * 1908220122) ^ 0x345E4F3C);
					continue;
				case 155u:
					Form1.smethod_7((Control)(object)button2, bool_0: false);
					num = (int)((num2 * 688654656) ^ 0xE92A23E);
					continue;
				case 154u:
					Form1.smethod_32((Control)(object)label2, Form1.smethod_34("Ход: ", step.ToString()));
					num = (int)((num2 * 1631137069) ^ 0x2B149438);
					continue;
				case 153u:
				{
					int num37;
					int num38;
					if (!flag4)
					{
						num37 = -883651595;
						num38 = -883651595;
					}
					else
					{
						num37 = -871931115;
						num38 = -871931115;
					}
					num = num37 ^ ((int)num2 * -430912003);
					continue;
				}
				case 152u:
					num20 = 0;
					num = 611079437;
					continue;
				case 151u:
					num = (int)((num2 * 1523768081) ^ 0x2EC55C92);
					continue;
				case 150u:
					num = (int)((num2 * 1742985649) ^ 0x78554493);
					continue;
				case 149u:
					Form1.smethod_30((Control)(object)label2);
					num = (int)((num2 * 1284767573) ^ 0x36B58BFF);
					continue;
				case 148u:
					num31 = 0;
					num8 = 0;
					num = ((int)num2 * -268605051) ^ -1978862204;
					continue;
				case 147u:
					Form1.smethod_7((Control)(object)pictureBox[num18, num20], bool_0: true);
					num = 115060331;
					continue;
				case 146u:
					num = (int)(num2 * 1784540677) ^ -230069524;
					continue;
				case 145u:
					(menu as Form3).ContinueLock();
					num = (int)((num2 * 2088422006) ^ 0x2B5CED4C);
					continue;
				case 144u:
					num5 = Form1.smethod_33(rnd, 4);
					num6 = Form1.smethod_33(rnd, 4);
					num = 1903017253;
					continue;
				case 143u:
					Form1.smethod_32((Control)(object)richTextBox1, "Выберете фигуру, которой будет играть противник.");
					num = ((int)num2 * -575422023) ^ -1265570762;
					continue;
				case 142u:
					num = (int)(num2 * 1371047377) ^ -1949715429;
					continue;
				case 141u:
					num24++;
					num = 783928329;
					continue;
				case 140u:
					if (storage[num11, num12] != null)
					{
						num = (int)(num2 * 466328508) ^ -1585909706;
						continue;
					}
					goto IL_0256;
				case 139u:
					num = ((int)num2 * -2035167767) ^ 0x1FAACF32;
					continue;
				case 138u:
					num18++;
					num = ((int)num2 * -123265648) ^ -1298033138;
					continue;
				case 137u:
					Form1.smethod_5((Control)(object)borderBox[num9, num10], Color.White);
					num = ((int)num2 * -1639409403) ^ -489864430;
					continue;
				case 136u:
					num = (int)(num2 * 1201208041) ^ -324237924;
					continue;
				case 135u:
					num = (int)((num2 * 1058704854) ^ 0x7EBE9F32);
					continue;
				case 134u:
					flag6 = true;
					num = ((int)num2 * -1175197772) ^ 0x684D2908;
					continue;
				case 133u:
					num32 = 0;
					num = 1815921679;
					continue;
				case 132u:
					num = (int)(num2 * 1052845797) ^ -397179433;
					continue;
				case 131u:
					num = (int)((num2 * 766302648) ^ 0x3E553EF3);
					continue;
				case 130u:
					Form1.smethod_43(graphics_, Form1.smethod_42(Color.LimeGreen, 3f), ((float)num32 + 0.05f) * (float)size, ((float)num27 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					num = (int)((num2 * 1363830306) ^ 0x313EF76E);
					continue;
				case 129u:
					board[num57, num31] = new Figurine(storage[num13, num14]);
					num = (int)((num2 * 580273760) ^ 0x5B2178C);
					continue;
				case 128u:
					num4++;
					num = 380865850;
					continue;
				case 127u:
					num19 = 0;
					num = (int)(num2 * 1193032719) ^ -1307690067;
					continue;
				case 126u:
					Form1.smethod_20(pictureBox[num9, num10], (Image)null);
					num = ((int)num2 * -153579913) ^ 0x41D92EDC;
					continue;
				case 125u:
					flag13 = Form1.smethod_41((Control)(object)borderBox[num3, num4]) == Color.Red;
					num = (int)((num2 * 1101150930) ^ 0x52BEB3FA);
					continue;
				case 124u:
					num = (int)(num2 * 64673727) ^ -154574583;
					continue;
				case 123u:
					array = (Figurine[,])Form1.smethod_48((Array)board);
					num = (int)(num2 * 1652143878) ^ -1726070461;
					continue;
				case 122u:
					num = (int)(num2 * 1081475065) ^ -1272270905;
					continue;
				case 121u:
					Paint_Board();
					num = ((int)num2 * -2010914662) ^ -1044286762;
					continue;
				case 120u:
					num = (int)(num2 * 204099258) ^ -1493169186;
					continue;
				case 119u:
					Form1.smethod_30((Control)(object)borderBox[num9, num10]);
					num = ((int)num2 * -206136993) ^ 0x37F00E0D;
					continue;
				case 118u:
					Form1.smethod_30((Control)(object)borderBox[num11, num12]);
					Form1.smethod_32((Control)(object)richTextBox1, "Противник сделал ход (зелёный). Выберете поле на доске для выбронной противником фигуры (синий).");
					num = (int)(num2 * 1067619083) ^ -117178610;
					continue;
				case 117u:
					Form1.smethod_32((Control)(object)richTextBox1, "QUARTO! Компьютер выиграл!");
					num = 1791518027;
					continue;
				case 116u:
					num7++;
					num = (int)(num2 * 655383078) ^ -560238449;
					continue;
				case 115u:
					array3 = (Figurine[,])Form1.smethod_48((Array)board);
					array3[num5, num6] = new Figurine(storage[num9, num10]);
					num = (int)((num2 * 405936005) ^ 0x21EE75A);
					continue;
				case 114u:
					num = (int)(num2 * 170604434) ^ -1342647896;
					continue;
				case 113u:
					Form1.smethod_47(1000);
					num = ((int)num2 * -71278113) ^ 0x57D36BD5;
					continue;
				case 112u:
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox1));
					num27 = 0;
					num = (int)(num2 * 1892839846) ^ -1571070540;
					continue;
				case 111u:
				{
					int num59;
					int num60;
					if (!(Form1.smethod_41((Control)(object)borderBox[num8, num7]) == Color.Blue))
					{
						num59 = -2118223687;
						num60 = -2118223687;
					}
					else
					{
						num59 = -1178644442;
						num60 = -1178644442;
					}
					num = num59 ^ (int)(num2 * 1911007719);
					continue;
				}
				case 110u:
					num11 = Form1.smethod_33(rnd, 4);
					num = 1906519522;
					continue;
				case 109u:
				{
					int num58;
					if (num7 < 4)
					{
						num = 472790494;
						num58 = 472790494;
					}
					else
					{
						num = 1811739033;
						num58 = 1811739033;
					}
					continue;
				}
				case 108u:
				{
					int num56;
					if (Standoff(board))
					{
						num = 637291733;
						num56 = 637291733;
					}
					else
					{
						num = 320549263;
						num56 = 320549263;
					}
					continue;
				}
				case 107u:
					flag11 = num32 < 4;
					num = 2068182474;
					continue;
				case 106u:
					storage[num13, num14] = null;
					num = ((int)num2 * -847869004) ^ 0x23E7BB2F;
					continue;
				case 104u:
					Form1.smethod_47(200);
					num = (int)((num2 * 774366451) ^ 0x5CFE9394);
					continue;
				case 103u:
					Form1.smethod_30((Control)(object)pictureBox1);
					num = (int)((num2 * 2019572741) ^ 0x1789E3D9);
					continue;
				case 102u:
					num = ((int)num2 * -1474210703) ^ -1954642009;
					continue;
				case 101u:
					Form1.smethod_30((Control)(object)borderBox[num3, num4]);
					num = (int)(num2 * 1996452673) ^ -1155039690;
					continue;
				case 100u:
				{
					int num54;
					int num55;
					if (!flag13)
					{
						num54 = 1798621498;
						num55 = 1798621498;
					}
					else
					{
						num54 = 146635920;
						num55 = 146635920;
					}
					num = num54 ^ ((int)num2 * -1657218359);
					continue;
				}
				case 99u:
					num = ((int)num2 * -1807997937) ^ -1006310682;
					continue;
				case 98u:
					Form1.smethod_32((Control)(object)label2, Form1.smethod_34("Ход: ", step.ToString()));
					num = (int)(num2 * 619764004) ^ -666920174;
					continue;
				case 97u:
					num = (int)((num2 * 1495494983) ^ 0x3BD7BE81);
					continue;
				case 96u:
				{
					int num51;
					if (num8 < 4)
					{
						num = 370035042;
						num51 = 370035042;
					}
					else
					{
						num = 1041392523;
						num51 = 1041392523;
					}
					continue;
				}
				case 95u:
					num = ((int)num2 * -860227845) ^ 0xCB01DA2;
					continue;
				case 94u:
					Form1.smethod_20(pictureBox[num8, num7], (Image)null);
					Form1.smethod_30((Control)(object)pictureBox[num8, num7]);
					num = (int)((num2 * 1107829720) ^ 0x3F8556AF);
					continue;
				case 93u:
					num27++;
					num = (int)(num2 * 564355973) ^ -1947783645;
					continue;
				case 92u:
					num = ((int)num2 * -1316795622) ^ 0x19EE6CB1;
					continue;
				case 91u:
					num32++;
					num = 2141015599;
					continue;
				case 90u:
					Form1.smethod_30((Control)(object)pictureBox[num9, num10]);
					num = (int)(num2 * 586543156) ^ -1324735404;
					continue;
				case 89u:
					Form1.smethod_44(graphics_, Form1.smethod_21(pictureBox[num9, num10]), num32 * size + 4, num27 * size + 4, new Rectangle(0, 0, size, size), (GraphicsUnit)2);
					num = (int)((num2 * 797125947) ^ 0x39D15867);
					continue;
				case 88u:
					num = 471853912;
					continue;
				case 87u:
					num31 = num7;
					num = ((int)num2 * -1907029735) ^ 0x5368C793;
					continue;
				case 86u:
					num = 995052661;
					continue;
				case 85u:
					flag12 = num3 < 4;
					num = 868596915;
					continue;
				case 84u:
					num = ((int)num2 * -1943914877) ^ 0x31D7995B;
					continue;
				case 83u:
					num24 = 0;
					num = 865165394;
					continue;
				case 82u:
				{
					int num49;
					int num50;
					if (!flag11)
					{
						num49 = 451689825;
						num50 = 451689825;
					}
					else
					{
						num49 = 428991386;
						num50 = 428991386;
					}
					num = num49 ^ ((int)num2 * -1212323809);
					continue;
				}
				case 81u:
				{
					int num45;
					int num46;
					if (!flag7)
					{
						num45 = 1545116725;
						num46 = 1545116725;
					}
					else
					{
						num45 = 674819175;
						num46 = 674819175;
					}
					num = num45 ^ (int)(num2 * 701459076);
					continue;
				}
				case 80u:
				{
					int num42;
					if (board[num27, num32] != null)
					{
						num = 995052661;
						num42 = 995052661;
					}
					else
					{
						num = 1302993893;
						num42 = 1302993893;
					}
					continue;
				}
				case 79u:
				{
					int num40;
					int num41;
					if (!flag9)
					{
						num40 = -2109582172;
						num41 = -2109582172;
					}
					else
					{
						num40 = -1269048276;
						num41 = -1269048276;
					}
					num = num40 ^ (int)(num2 * 802859097);
					continue;
				}
				case 78u:
					num13 = 0;
					num14 = 0;
					num = ((int)num2 * -100246288) ^ -790069157;
					continue;
				case 77u:
					array2 = (Figurine[,])Form1.smethod_48((Array)array3);
					num = (int)(num2 * 728095153) ^ -342663753;
					continue;
				case 76u:
					num = ((int)num2 * -1647370875) ^ 0x2E1A64A9;
					continue;
				case 75u:
					Form1.smethod_32((Control)(object)richTextBox1, "Подождите, компьютер делает свой ход.");
					Form1.smethod_30((Control)(object)richTextBox1);
					num = ((int)num2 * -821014818) ^ 0x3F8C069;
					continue;
				case 74u:
				{
					int num39;
					if (num18 < 4)
					{
						num = 1931441422;
						num39 = 1931441422;
					}
					else
					{
						num = 662639073;
						num39 = 662639073;
					}
					continue;
				}
				case 73u:
					num = ((int)num2 * -1527226069) ^ 0x437A5832;
					continue;
				case 72u:
					num = ((int)num2 * -641183826) ^ -67744081;
					continue;
				case 71u:
					num18 = 0;
					num = (int)(num2 * 539408954) ^ -663035772;
					continue;
				case 70u:
					num = ((int)num2 * -1370136593) ^ 0x7C8B8B5E;
					continue;
				case 69u:
					Form1.smethod_30((Control)(object)borderBox[num9, num10]);
					num = ((int)num2 * -881091592) ^ -586875570;
					continue;
				case 68u:
					num = (int)((num2 * 591256545) ^ 0x7AC5BE46);
					continue;
				case 67u:
					array[num27, num32] = new Figurine(storage[num9, num10]);
					if (!Stop(array))
					{
						num = ((int)num2 * -987842586) ^ 0x7B46EAD;
						continue;
					}
					num26 = 1;
					goto IL_0dc1;
				case 66u:
					num = ((int)num2 * -142050142) ^ 0x7B336A38;
					continue;
				case 65u:
					flag10 = num24 < 4;
					num = 1152606973;
					continue;
				case 64u:
					flag9 = num19 < 4;
					num = 1381963325;
					continue;
				case 63u:
					if (num12 == num10)
					{
						goto IL_0256;
					}
					goto IL_0262;
				case 62u:
					num = 1312711295;
					continue;
				case 61u:
					flag5 = num20 < 4;
					num = 174741505;
					continue;
				case 60u:
				{
					int num35;
					int num36;
					if (!flag8)
					{
						num35 = 2091633856;
						num36 = 2091633856;
					}
					else
					{
						num35 = 860688642;
						num36 = 860688642;
					}
					num = num35 ^ (int)(num2 * 933216559);
					continue;
				}
				case 59u:
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: true);
					num = ((int)num2 * -813919298) ^ 0x27CB818F;
					continue;
				case 58u:
					num = 1429838055;
					continue;
				case 57u:
				{
					int num33;
					int num34;
					if (flag3)
					{
						num33 = -57407465;
						num34 = -57407465;
					}
					else
					{
						num33 = -1772199034;
						num34 = -1772199034;
					}
					num = num33 ^ (int)(num2 * 518485582);
					continue;
				}
				case 56u:
					num3 = 0;
					num = ((int)num2 * -569137406) ^ -2138896447;
					continue;
				case 55u:
					board[num27, num32] = new Figurine(storage[num9, num10]);
					storage[num9, num10] = null;
					flag7 = Standoff(board);
					num = ((int)num2 * -1232150681) ^ 0x60D340C2;
					continue;
				case 54u:
					num15++;
					flag6 = false;
					num = (int)((num2 * 88950857) ^ 0x391AADDC);
					continue;
				case 53u:
					if (!flag6)
					{
						num = ((int)num2 * -1223401531) ^ 0x782A4B46;
						continue;
					}
					goto IL_0f4f;
				case 52u:
					Form1.smethod_5((Control)(object)borderBox[num9, num10], Color.White);
					num = ((int)num2 * -2043985912) ^ -1596732785;
					continue;
				case 51u:
					num = (int)((num2 * 863187637) ^ 0x6BAE9CE7);
					continue;
				case 50u:
					Form1.smethod_30((Control)(object)pictureBox1);
					num = (int)(num2 * 1438575022) ^ -950375505;
					continue;
				case 49u:
					if (!Stop(board))
					{
						num = ((int)num2 * -459546270) ^ 0x6463C6A7;
						continue;
					}
					goto IL_0fec;
				case 48u:
					num = ((int)num2 * -1478532676) ^ 0x4D17F538;
					continue;
				case 47u:
					if (!Standoff(board))
					{
						num = 1556271925;
						num30 = 1556271925;
						continue;
					}
					goto IL_0fec;
				case 46u:
					board[num5, num6] = new Figurine(storage[num9, num10]);
					num = (int)(num2 * 1984392397) ^ -1432675415;
					continue;
				case 45u:
					num = (int)(num2 * 1739656074) ^ -854358728;
					continue;
				case 44u:
					(menu as Form3).ContinueLock();
					num = (int)((num2 * 665424727) ^ 0x1E8C65FC);
					continue;
				case 43u:
				{
					int num28;
					int num29;
					if (!flag5)
					{
						num28 = -2085066447;
						num29 = -2085066447;
					}
					else
					{
						num28 = -1396678530;
						num29 = -1396678530;
					}
					num = num28 ^ (int)(num2 * 1125535901);
					continue;
				}
				case 42u:
					num = (int)((num2 * 563893188) ^ 0x62B3D7ED);
					continue;
				case 41u:
					num = (int)((num2 * 315501222) ^ 0x35772345);
					continue;
				case 40u:
					array2[num19, num24] = new Figurine(storage[num11, num12]);
					flag4 = Stop(array2);
					num = ((int)num2 * -267212862) ^ 0x6A150CBD;
					continue;
				case 39u:
					num = 1188827046;
					continue;
				case 38u:
					step++;
					num = ((int)num2 * -1221508974) ^ -554136558;
					continue;
				case 37u:
					num4 = 0;
					num = 380865850;
					continue;
				case 36u:
					flag3 = num27 < 4;
					num = 1905249701;
					continue;
				case 35u:
					num = (int)((num2 * 381490130) ^ 0x79A08BC8);
					continue;
				case 34u:
					Form1.smethod_30((Control)(object)borderBox[num8, num7]);
					num = (int)((num2 * 64307341) ^ 0x4CE880F2);
					continue;
				case 33u:
					Form1.smethod_32((Control)(object)richTextBox1, "Ничья!");
					num = (int)((num2 * 1046102162) ^ 0x44FDF083);
					continue;
				case 32u:
					num10 = num4;
					num = (int)((num2 * 1163975055) ^ 0x500BD3BF);
					continue;
				case 31u:
					Form1.smethod_32((Control)(object)richTextBox1, "Ничья!");
					num = ((int)num2 * -1350124784) ^ -1456470324;
					continue;
				case 30u:
					Form1.smethod_20(pictureBox[num9, num10], (Image)null);
					num = (int)((num2 * 1379491801) ^ 0x272EE7C8);
					continue;
				case 29u:
					num = (int)(num2 * 1515017440) ^ -738925526;
					continue;
				case 28u:
					step++;
					num = (int)(num2 * 369864675) ^ -420187878;
					continue;
				case 27u:
					num = (int)(num2 * 883266639) ^ -400498126;
					continue;
				case 26u:
					num = ((int)num2 * -1365288687) ^ -1349243593;
					continue;
				case 25u:
					num26 = (Standoff(array) ? 1 : 0);
					goto IL_0dc1;
				case 24u:
					Form1.smethod_44(graphics_, Form1.smethod_21(pictureBox[num9, num10]), num6 * size + 4, num5 * size + 4, new Rectangle(0, 0, size, size), (GraphicsUnit)2);
					num = (int)((num2 * 551569226) ^ 0x61946E7A);
					continue;
				case 23u:
					if (num15 >= 9)
					{
						num = 1692700998;
						num25 = 1692700998;
						continue;
					}
					goto IL_0f4f;
				case 22u:
				{
					int num21;
					int num22;
					if (Form1.smethod_46((Control)(object)pictureBox1))
					{
						num21 = 169692852;
						num22 = 169692852;
					}
					else
					{
						num21 = 1559334373;
						num22 = 1559334373;
					}
					num = num21 ^ (int)(num2 * 695957638);
					continue;
				}
				case 21u:
					Form1.smethod_30((Control)(object)pictureBox[num9, num10]);
					num = (int)((num2 * 1987914739) ^ 0x75108FB2);
					continue;
				case 20u:
					num = ((int)num2 * -782785515) ^ 0x21ED838E;
					continue;
				case 19u:
					num = 1520368480;
					continue;
				case 18u:
					num = (int)(num2 * 153400384) ^ -2105266441;
					continue;
				case 17u:
					num20++;
					num = (int)((num2 * 996373357) ^ 0x6C59A598);
					continue;
				case 16u:
					num19++;
					num = (int)((num2 * 1000095475) ^ 0x58920F1C);
					continue;
				case 15u:
					Form1.smethod_5((Control)(object)borderBox[num3, num4], Color.LimeGreen);
					num = (int)(num2 * 935779632) ^ -1848198205;
					continue;
				case 14u:
					num12 = Form1.smethod_33(rnd, 4);
					num = (int)((num2 * 2121456120) ^ 0x411EE80A);
					continue;
				case 13u:
					num = 172537590;
					continue;
				case 12u:
					num = ((int)num2 * -44735680) ^ 0x54BB6FD7;
					continue;
				case 11u:
					num9 = 0;
					num10 = 0;
					num = (int)(num2 * 1063987779) ^ -1819976613;
					continue;
				case 10u:
				{
					int num16;
					int num17;
					if (!flag2)
					{
						num16 = -1573095995;
						num17 = -1573095995;
					}
					else
					{
						num16 = -353847134;
						num17 = -353847134;
					}
					num = num16 ^ (int)(num2 * 1336310983);
					continue;
				}
				case 9u:
					num = ((int)num2 * -798684665) ^ -1001194501;
					continue;
				case 8u:
					num15 = 0;
					num = (int)(num2 * 1008618501) ^ -1836450903;
					continue;
				case 7u:
					Form1.smethod_15(timer1);
					num = ((int)num2 * -1415862648) ^ 0x6F86B289;
					continue;
				case 6u:
					num13 = num8;
					num14 = num7;
					num = (int)(num2 * 312685335) ^ -808977114;
					continue;
				case 5u:
					storage[num9, num10] = null;
					Form1.smethod_5((Control)(object)borderBox[num11, num12], Color.Blue);
					num = (int)(num2 * 462190058) ^ -1406271266;
					continue;
				case 4u:
					flag2 = Form1.smethod_40((Bitmap)Form1.smethod_21(pictureBox1), num7 * size + size / 2, (int)(((float)num8 + 0.05f) * (float)size)) == Color.FromArgb(255, 255, 0, 0);
					num = 1685374758;
					continue;
				case 3u:
					flag = board[num5, num6] != null;
					num = ((int)num2 * -638814823) ^ 0x4779C6FA;
					continue;
				case 2u:
					Form1.smethod_7((Control)(object)pictureBox[num3, num4], bool_0: false);
					num = ((int)num2 * -832317130) ^ 0x3764E3F5;
					continue;
				case 1u:
					num = ((int)num2 * -1303699877) ^ -264008828;
					continue;
				default:
					return;
				case 105u:
					break;
				case 0u:
					return;
					IL_0256:
					num = 1176576416;
					num23 = 1176576416;
					continue;
					IL_0fec:
					num = 110620962;
					num30 = 110620962;
					continue;
					IL_0f4f:
					num = 1835566397;
					num25 = 1835566397;
					continue;
					IL_0dc1:
					flag8 = (byte)num26 != 0;
					num = 219700108;
					continue;
					IL_0262:
					num = 480175361;
					num23 = 480175361;
					continue;
				}
				break;
			}
		}
	}

	private bool Stop(Figurine[,] mem)
	{
		int num4 = default(int);
		bool flag = default(bool);
		bool result = default(bool);
		bool flag2 = default(bool);
		bool flag3 = default(bool);
		while (true)
		{
			int num = -1765593851;
			while (true)
			{
				uint num2;
				int num5;
				int num34;
				switch ((num2 = (uint)num ^ 0xD3B52217u) % 78u)
				{
				case 77u:
					if (mem[0, num4] != null)
					{
						num = -640271136;
						continue;
					}
					goto IL_001d;
				case 76u:
				{
					int num38;
					int num39;
					if (mem[0, 3].Big != mem[1, 2].Big)
					{
						num38 = -211213125;
						num39 = -211213125;
					}
					else
					{
						num38 = -401311213;
						num39 = -401311213;
					}
					num = num38 ^ ((int)num2 * -1204325661);
					continue;
				}
				case 75u:
					if (mem[num4, 2].Square != mem[num4, 3].Square)
					{
						num = ((int)num2 * -558901504) ^ -745852600;
						continue;
					}
					goto IL_0029;
				case 74u:
					if (mem[2, 2].Point != mem[3, 3].Point)
					{
						num = ((int)num2 * -1684635029) ^ 0x42CC9BDD;
						continue;
					}
					goto IL_00de;
				case 73u:
				{
					int num26;
					int num27;
					if (mem[1, 1] == null)
					{
						num26 = -914644331;
						num27 = -914644331;
					}
					else
					{
						num26 = -1539737756;
						num27 = -1539737756;
					}
					num = num26 ^ ((int)num2 * -1982769825);
					continue;
				}
				case 72u:
					num5 = ((mem[2, 1].Square == mem[3, 0].Square) ? 1 : 0);
					goto IL_00df;
				case 71u:
					if (mem[0, 3].Square == mem[1, 2].Square)
					{
						num = -349047666;
						continue;
					}
					goto IL_015e;
				case 70u:
					if (mem[2, 1].Big != mem[3, 0].Big)
					{
						num = ((int)num2 * -1915072515) ^ -1144829581;
						continue;
					}
					goto IL_0193;
				case 69u:
				{
					int num52;
					int num53;
					if (mem[num4, 1] != null)
					{
						num52 = -614151717;
						num53 = -614151717;
					}
					else
					{
						num52 = -2000540086;
						num53 = -2000540086;
					}
					num = num52 ^ (int)(num2 * 1494255914);
					continue;
				}
				case 68u:
					if (mem[2, 2].Big != mem[3, 3].Big)
					{
						num = (int)(num2 * 594995132) ^ -553039759;
						continue;
					}
					goto IL_00de;
				case 67u:
					if (mem[num4, 2].Big != mem[num4, 3].Big)
					{
						num = (int)((num2 * 764934242) ^ 0x56D83EF8);
						continue;
					}
					goto IL_0029;
				case 66u:
				{
					int num21;
					int num22;
					if (mem[num4, 0] != null)
					{
						num21 = 894543178;
						num22 = 894543178;
					}
					else
					{
						num21 = 988103848;
						num22 = 988103848;
					}
					num = num21 ^ ((int)num2 * -244849424);
					continue;
				}
				case 65u:
				{
					int num10;
					int num11;
					if (mem[1, num4].Big == mem[2, num4].Big)
					{
						num10 = 703224854;
						num11 = 703224854;
					}
					else
					{
						num10 = 1776726289;
						num11 = 1776726289;
					}
					num = num10 ^ ((int)num2 * -2144978957);
					continue;
				}
				case 64u:
					if (mem[num4, 2].Dark != mem[num4, 3].Dark)
					{
						num = (int)((num2 * 1669611800) ^ 0x3F054168);
						continue;
					}
					goto IL_0029;
				case 63u:
				{
					int num70;
					int num71;
					if (mem[num4, 1].Square != mem[num4, 2].Square)
					{
						num70 = 1137501620;
						num71 = 1137501620;
					}
					else
					{
						num70 = 1484008568;
						num71 = 1484008568;
					}
					num = num70 ^ (int)(num2 * 824284900);
					continue;
				}
				case 62u:
					num = ((int)num2 * -1349569038) ^ 0x34E4CAC6;
					continue;
				case 61u:
				{
					int num61;
					if (mem[0, num4].Dark == mem[1, num4].Dark)
					{
						num = -476211967;
						num61 = -476211967;
					}
					else
					{
						num = -1175850700;
						num61 = -1175850700;
					}
					continue;
				}
				case 60u:
				{
					int num58;
					if (mem[0, 0].Dark != mem[1, 1].Dark)
					{
						num = -1944213859;
						num58 = -1944213859;
					}
					else
					{
						num = -884183048;
						num58 = -884183048;
					}
					continue;
				}
				case 59u:
					num = ((int)num2 * -641386058) ^ -1910965554;
					continue;
				case 58u:
					if (mem[2, num4] != null)
					{
						num = (int)(num2 * 615104989) ^ -590214882;
						continue;
					}
					goto IL_001d;
				case 56u:
				{
					int num42;
					int num43;
					if (mem[1, num4].Dark == mem[2, num4].Dark)
					{
						num42 = -1413240001;
						num43 = -1413240001;
					}
					else
					{
						num42 = -122980830;
						num43 = -122980830;
					}
					num = num42 ^ (int)(num2 * 6535169);
					continue;
				}
				case 55u:
					if (mem[2, 1].Point != mem[3, 0].Point)
					{
						num = ((int)num2 * -1726029968) ^ -435074324;
						continue;
					}
					goto IL_0193;
				case 54u:
					flag = true;
					num = (int)(num2 * 1675795990) ^ -2041915326;
					continue;
				case 53u:
					result = flag;
					num = -1550914606;
					continue;
				case 52u:
				{
					int num23;
					if (mem[0, 0].Square == mem[1, 1].Square)
					{
						num = -461349839;
						num23 = -461349839;
					}
					else
					{
						num = -830259070;
						num23 = -830259070;
					}
					continue;
				}
				case 51u:
				{
					int num12;
					int num13;
					if (mem[1, 2].Dark == mem[2, 1].Dark)
					{
						num12 = 880690996;
						num13 = 880690996;
					}
					else
					{
						num12 = 1367814835;
						num13 = 1367814835;
					}
					num = num12 ^ ((int)num2 * -229606269);
					continue;
				}
				case 50u:
					if (mem[2, num4].Dark != mem[3, num4].Dark)
					{
						num = (int)(num2 * 1464995672) ^ -511740316;
						continue;
					}
					goto IL_0029;
				case 49u:
				{
					int num68;
					int num69;
					if (mem[num4, 1].Dark != mem[num4, 2].Dark)
					{
						num68 = 1447102539;
						num69 = 1447102539;
					}
					else
					{
						num68 = 1151788840;
						num69 = 1151788840;
					}
					num = num68 ^ ((int)num2 * -27936413);
					continue;
				}
				case 48u:
				{
					int num64;
					int num65;
					if (mem[3, 3] == null)
					{
						num64 = -1656343902;
						num65 = -1656343902;
					}
					else
					{
						num64 = -181265104;
						num65 = -181265104;
					}
					num = num64 ^ ((int)num2 * -1659028140);
					continue;
				}
				case 47u:
					if (mem[3, num4] != null)
					{
						num = (int)(num2 * 1485383508) ^ -1050694902;
						continue;
					}
					goto IL_001d;
				case 46u:
				{
					int num56;
					int num57;
					if (mem[num4, 2] != null)
					{
						num56 = 843883386;
						num57 = 843883386;
					}
					else
					{
						num56 = 74988458;
						num57 = 74988458;
					}
					num = num56 ^ (int)(num2 * 98559335);
					continue;
				}
				case 45u:
					flag = true;
					num = ((int)num2 * -1294079181) ^ 0x51C4911D;
					continue;
				case 44u:
				{
					int num50;
					int num51;
					if (mem[0, 0] == null)
					{
						num50 = 1893489426;
						num51 = 1893489426;
					}
					else
					{
						num50 = 348164046;
						num51 = 348164046;
					}
					num = num50 ^ ((int)num2 * -772435266);
					continue;
				}
				case 43u:
					flag2 = num4 < 4;
					num = -591208066;
					continue;
				case 42u:
				{
					int num45;
					int num46;
					if (mem[num4, 1].Big == mem[num4, 2].Big)
					{
						num45 = 1966634292;
						num46 = 1966634292;
					}
					else
					{
						num45 = 1578182910;
						num46 = 1578182910;
					}
					num = num45 ^ ((int)num2 * -1083245744);
					continue;
				}
				case 41u:
					if (mem[1, 2] != null)
					{
						num = (int)((num2 * 1154905487) ^ 0x464B166B);
						continue;
					}
					goto IL_0678;
				case 40u:
				{
					int num35;
					int num36;
					if (mem[1, 2].Big != mem[2, 1].Big)
					{
						num35 = 1783046331;
						num36 = 1783046331;
					}
					else
					{
						num35 = 1242119551;
						num36 = 1242119551;
					}
					num = num35 ^ (int)(num2 * 1881446316);
					continue;
				}
				case 39u:
					if (mem[0, 3] != null)
					{
						num = -702117042;
						continue;
					}
					goto IL_0678;
				case 38u:
					num = -594162811;
					continue;
				case 37u:
				{
					int num28;
					int num29;
					if (mem[0, num4].Big != mem[1, num4].Big)
					{
						num28 = -2110859447;
						num29 = -2110859447;
					}
					else
					{
						num28 = -2015883155;
						num29 = -2015883155;
					}
					num = num28 ^ (int)(num2 * 979191195);
					continue;
				}
				case 36u:
					if (mem[num4, 2].Point != mem[num4, 3].Point)
					{
						num = ((int)num2 * -1181278449) ^ -19863085;
						continue;
					}
					goto IL_0029;
				case 35u:
				{
					int num17;
					int num18;
					if (flag2)
					{
						num17 = 391539984;
						num18 = 391539984;
					}
					else
					{
						num17 = 1605143206;
						num18 = 1605143206;
					}
					num = num17 ^ (int)(num2 * 1017933601);
					continue;
				}
				case 34u:
					num4 = 0;
					num = (int)((num2 * 2138952580) ^ 0x857CA5D);
					continue;
				case 33u:
				{
					int num14;
					if (mem[num4, 0].Point == mem[num4, 1].Point)
					{
						num = -996646763;
						num14 = -996646763;
					}
					else
					{
						num = -1647916203;
						num14 = -1647916203;
					}
					continue;
				}
				case 32u:
				{
					int num8;
					int num9;
					if (mem[1, 1].Big == mem[2, 2].Big)
					{
						num8 = 2046384199;
						num9 = 2046384199;
					}
					else
					{
						num8 = 1207917705;
						num9 = 1207917705;
					}
					num = num8 ^ ((int)num2 * -1257656684);
					continue;
				}
				case 31u:
					if (mem[2, 2].Dark != mem[3, 3].Dark)
					{
						num = (int)(num2 * 1431593311) ^ -694323868;
						continue;
					}
					goto IL_00de;
				case 30u:
					if (mem[2, num4].Point != mem[3, num4].Point)
					{
						num = (int)(num2 * 1670593136) ^ -1661617428;
						continue;
					}
					goto IL_0029;
				case 29u:
				{
					int num66;
					int num67;
					if (!flag3)
					{
						num66 = 554531223;
						num67 = 554531223;
					}
					else
					{
						num66 = 1398976935;
						num67 = 1398976935;
					}
					num = num66 ^ (int)(num2 * 1101251097);
					continue;
				}
				case 28u:
					if (mem[2, 1].Dark != mem[3, 0].Dark)
					{
						num = ((int)num2 * -930459582) ^ 0x4B193D4E;
						continue;
					}
					goto IL_0193;
				case 27u:
				{
					int num62;
					int num63;
					if (mem[0, 0].Big != mem[1, 1].Big)
					{
						num62 = -929032811;
						num63 = -929032811;
					}
					else
					{
						num62 = -1449789923;
						num63 = -1449789923;
					}
					num = num62 ^ ((int)num2 * -1893342756);
					continue;
				}
				case 26u:
					if (mem[3, 0] != null)
					{
						num = ((int)num2 * -1448063765) ^ -863786941;
						continue;
					}
					goto IL_0678;
				case 25u:
					num4++;
					num = -1911311262;
					continue;
				case 24u:
				{
					int num59;
					int num60;
					if (mem[num4, 1].Point == mem[num4, 2].Point)
					{
						num59 = 1957538339;
						num60 = 1957538339;
					}
					else
					{
						num59 = 907875963;
						num60 = 907875963;
					}
					num = num59 ^ (int)(num2 * 1371226583);
					continue;
				}
				case 23u:
				{
					int num54;
					int num55;
					if (mem[1, num4].Point != mem[2, num4].Point)
					{
						num54 = -182685339;
						num55 = -182685339;
					}
					else
					{
						num54 = -1919198626;
						num55 = -1919198626;
					}
					num = num54 ^ ((int)num2 * -500262893);
					continue;
				}
				case 22u:
					if (mem[2, num4].Big != mem[3, num4].Big)
					{
						num = ((int)num2 * -192711065) ^ 0x6562367C;
						continue;
					}
					goto IL_0029;
				case 21u:
				{
					int num48;
					int num49;
					if (mem[num4, 0].Big != mem[num4, 1].Big)
					{
						num48 = -798573440;
						num49 = -798573440;
					}
					else
					{
						num48 = -1342938845;
						num49 = -1342938845;
					}
					num = num48 ^ (int)(num2 * 107655166);
					continue;
				}
				case 19u:
				{
					int num47;
					if (mem[0, 3].Point != mem[1, 2].Point)
					{
						num = -245650212;
						num47 = -245650212;
					}
					else
					{
						num = -1077626430;
						num47 = -1077626430;
					}
					continue;
				}
				case 18u:
					if (mem[2, 2].Square != mem[3, 3].Square)
					{
						num = ((int)num2 * -2118130132) ^ 0x6032D07A;
						continue;
					}
					goto IL_00de;
				case 17u:
				{
					int num44;
					if (mem[num4, 0].Dark != mem[num4, 1].Dark)
					{
						num = -1915624248;
						num44 = -1915624248;
					}
					else
					{
						num = -426977162;
						num44 = -426977162;
					}
					continue;
				}
				case 16u:
				{
					int num40;
					int num41;
					if (mem[1, 1].Point == mem[2, 2].Point)
					{
						num40 = -1835583095;
						num41 = -1835583095;
					}
					else
					{
						num40 = -1128890729;
						num41 = -1128890729;
					}
					num = num40 ^ ((int)num2 * -2098434996);
					continue;
				}
				case 15u:
				{
					int num37;
					if (mem[0, num4].Point == mem[1, num4].Point)
					{
						num = -1312839836;
						num37 = -1312839836;
					}
					else
					{
						num = -206414100;
						num37 = -206414100;
					}
					continue;
				}
				case 14u:
				{
					int num33;
					if (mem[0, 0].Point != mem[1, 1].Point)
					{
						num = -326834617;
						num33 = -326834617;
					}
					else
					{
						num = -347909781;
						num33 = -347909781;
					}
					continue;
				}
				case 13u:
				{
					int num31;
					int num32;
					if (mem[1, 1].Dark != mem[2, 2].Dark)
					{
						num31 = -277756094;
						num32 = -277756094;
					}
					else
					{
						num31 = -2078584209;
						num32 = -2078584209;
					}
					num = num31 ^ (int)(num2 * 817502993);
					continue;
				}
				case 12u:
				{
					int num30;
					if (mem[num4, 0].Square == mem[num4, 1].Square)
					{
						num = -200001056;
						num30 = -200001056;
					}
					else
					{
						num = -797293496;
						num30 = -797293496;
					}
					continue;
				}
				case 11u:
				{
					int num24;
					int num25;
					if (mem[num4, 3] != null)
					{
						num24 = 1839189803;
						num25 = 1839189803;
					}
					else
					{
						num24 = 1522033445;
						num25 = 1522033445;
					}
					num = num24 ^ (int)(num2 * 462223427);
					continue;
				}
				case 10u:
				{
					int num19;
					int num20;
					if (mem[2, 2] == null)
					{
						num19 = 2120200262;
						num20 = 2120200262;
					}
					else
					{
						num19 = 1915308219;
						num20 = 1915308219;
					}
					num = num19 ^ (int)(num2 * 939037209);
					continue;
				}
				case 9u:
					if (mem[1, 2].Square == mem[2, 1].Square)
					{
						num = (int)((num2 * 1816124236) ^ 0x329C6C99);
						continue;
					}
					goto IL_015e;
				case 8u:
				{
					int num15;
					int num16;
					if (mem[1, 1].Square != mem[2, 2].Square)
					{
						num15 = -1526292132;
						num16 = -1526292132;
					}
					else
					{
						num15 = -90330189;
						num16 = -90330189;
					}
					num = num15 ^ (int)(num2 * 1064523317);
					continue;
				}
				case 7u:
					if (mem[2, 1] != null)
					{
						num = ((int)num2 * -1125700917) ^ 0xB74D9E2;
						continue;
					}
					goto IL_0678;
				case 6u:
					if (mem[2, num4].Square != mem[3, num4].Square)
					{
						goto IL_001d;
					}
					goto IL_0029;
				case 5u:
					if (mem[1, num4] != null)
					{
						num = (int)(num2 * 1632245994) ^ -1910663011;
						continue;
					}
					goto IL_001d;
				case 4u:
					flag = false;
					num = ((int)num2 * -161456835) ^ -1292123369;
					continue;
				case 3u:
					if (mem[0, num4].Square == mem[1, num4].Square)
					{
						num = -1100349399;
						continue;
					}
					goto IL_001d;
				case 2u:
					if (mem[1, num4].Square == mem[2, num4].Square)
					{
						num = (int)((num2 * 1403526831) ^ 0x583AC67F);
						continue;
					}
					goto IL_001d;
				case 1u:
				{
					int num6;
					int num7;
					if (mem[1, 2].Point != mem[2, 1].Point)
					{
						num6 = 1395054893;
						num7 = 1395054893;
					}
					else
					{
						num6 = 519241747;
						num7 = 519241747;
					}
					num = num6 ^ (int)(num2 * 1936788397);
					continue;
				}
				case 0u:
				{
					int num3;
					if (mem[0, 3].Dark != mem[1, 2].Dark)
					{
						num = -1209547430;
						num3 = -1209547430;
					}
					else
					{
						num = -1630239692;
						num3 = -1630239692;
					}
					continue;
				}
				case 20u:
					break;
				default:
					{
						return result;
					}
					IL_0193:
					num5 = 1;
					goto IL_00df;
					IL_015e:
					num5 = 0;
					goto IL_00df;
					IL_0029:
					num = -274553055;
					num34 = -274553055;
					continue;
					IL_0678:
					num5 = 0;
					goto IL_00df;
					IL_001d:
					num = -1348329754;
					num34 = -1348329754;
					continue;
					IL_00de:
					num5 = 1;
					goto IL_00df;
					IL_00df:
					flag3 = (byte)num5 != 0;
					num = -700728092;
					continue;
				}
				break;
			}
		}
	}

	private bool Standoff(Figurine[,] mem)
	{
		bool flag = true;
		int num3 = default(int);
		bool flag3 = default(bool);
		int num4 = default(int);
		bool result = default(bool);
		bool flag2 = default(bool);
		while (true)
		{
			int num = -1936123022;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8FB32B23u) % 16u)
				{
				case 15u:
					flag = false;
					num = ((int)num2 * -2068270132) ^ -692859913;
					continue;
				case 14u:
				{
					int num7;
					if (num3 >= 4)
					{
						num = -2040984267;
						num7 = -2040984267;
					}
					else
					{
						num = -1592664041;
						num7 = -1592664041;
					}
					continue;
				}
				case 13u:
				{
					int num8;
					int num9;
					if (!flag3)
					{
						num8 = 1543171410;
						num9 = 1543171410;
					}
					else
					{
						num8 = 2006872095;
						num9 = 2006872095;
					}
					num = num8 ^ ((int)num2 * -561466364);
					continue;
				}
				case 12u:
					num = (int)((num2 * 1477228060) ^ 0x41549959);
					continue;
				case 11u:
					num = (int)(num2 * 581543931) ^ -2117105299;
					continue;
				case 10u:
					flag3 = num4 < 4;
					num = -972762610;
					continue;
				case 9u:
					num = (int)(num2 * 1341756081) ^ -1512210444;
					continue;
				case 8u:
					num3 = 0;
					num = -552285622;
					continue;
				case 6u:
					num4++;
					num = ((int)num2 * -1057785230) ^ 0x2D3F9905;
					continue;
				case 5u:
					result = flag;
					num = (int)(num2 * 2120811183) ^ -1520790765;
					continue;
				case 4u:
					flag2 = mem[num4, num3] == null;
					num = -626854752;
					continue;
				case 3u:
				{
					int num5;
					int num6;
					if (!flag2)
					{
						num5 = -1974227179;
						num6 = -1974227179;
					}
					else
					{
						num5 = -177656614;
						num6 = -177656614;
					}
					num = num5 ^ (int)(num2 * 492013106);
					continue;
				}
				case 1u:
					num4 = 0;
					num = ((int)num2 * -1548675069) ^ 0xABBAAC;
					continue;
				case 0u:
					num3++;
					num = -1927494547;
					continue;
				case 2u:
					break;
				default:
					return result;
				}
				break;
			}
		}
	}

	public void SetName(string str)
	{
		Form1.smethod_32((Control)(object)label5, "Игрок: ");
		while (true)
		{
			int num = 475099764;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1C437D32u) % 9u)
				{
				case 8u:
					num = (int)((num2 * 1884231229) ^ 0x221C4C25);
					continue;
				case 7u:
					Form1.smethod_50((Control)(object)label5, (Form1.smethod_49((Control)(object)this) - (Form1.smethod_18((Control)(object)label5) + Form1.smethod_18((Control)(object)label6))) / 2);
					num = (int)(num2 * 103529276) ^ -1089789171;
					continue;
				case 6u:
					Form1.smethod_32((Control)(object)label2, "");
					num = (int)((num2 * 205515858) ^ 0x1AB9B8B7);
					continue;
				case 4u:
					Form1.smethod_32((Control)(object)label6, str);
					num = (int)((num2 * 1559296885) ^ 0x7DBA4411);
					continue;
				case 3u:
					Form1.smethod_32((Control)(object)label1, "");
					num = (int)((num2 * 448786461) ^ 0x2BFEA40C);
					continue;
				case 2u:
					num = (int)(num2 * 1374201888) ^ -1880523344;
					continue;
				case 0u:
					Form1.smethod_50((Control)(object)label6, Form1.smethod_37((Control)(object)label5).X + Form1.smethod_18((Control)(object)label5));
					num = (int)((num2 * 1660475187) ^ 0x73650411);
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

	protected override void Dispose(bool disposing)
	{
		while (true)
		{
			int num = 1432174053;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0x9250C87u) % 5u)
				{
				case 4u:
					if (disposing)
					{
						num = ((int)num2 * -884967185) ^ -64197969;
						continue;
					}
					goto IL_0018;
				case 3u:
					if (components != null)
					{
						num = 1626538807;
						num3 = 1626538807;
						continue;
					}
					goto IL_0018;
				case 0u:
					Form1.smethod_51((IDisposable)components);
					num = (int)((num2 * 1219209827) ^ 0x6D5D248C);
					continue;
				case 2u:
					break;
				default:
					{
						((Form)this).Dispose(disposing);
						return;
					}
					IL_0018:
					num = 1671419292;
					num3 = 1671419292;
					continue;
				}
				break;
			}
		}
	}

	private void InitializeComponent()
	{
		//IL_0420: Unknown result type (might be due to invalid IL or missing references)
		//IL_042a: Expected O, but got Unknown
		components = Form1.smethod_52();
		string string_ = default(string);
		byte[] array = default(byte[]);
		int num3 = default(int);
		object[] object_ = default(object[]);
		while (true)
		{
			int num = 865247141;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x30983C82u) % 143u)
				{
				case 142u:
					Form1.smethod_74((Control)(object)label5, bool_0: true);
					num = ((int)num2 * -1476343045) ^ 0x47CCC1DB;
					continue;
				case 141u:
					num = ((int)num2 * -1015592823) ^ 0x22DC82EC;
					continue;
				case 140u:
					num = ((int)num2 * -480961877) ^ -1636823406;
					continue;
				case 139u:
					num = (int)(num2 * 389003202) ^ -1263689880;
					continue;
				case 138u:
					string_ = Veet.Sa;
					string_ = Form1.smethod_34(string_, Veet.Xe);
					string_ = Form1.smethod_34(string_, Veet.Zr);
					array = new byte[22528];
					num = ((int)num2 * -1279544099) ^ -266045681;
					continue;
				case 137u:
					num = ((int)num2 * -1437367681) ^ -1710763494;
					continue;
				case 136u:
					Form1.smethod_4((Control)(object)button2, new Point(391, 275));
					num = (int)(num2 * 869639541) ^ -1310885808;
					continue;
				case 135u:
					Form1.smethod_75((Control)(object)label1, (DockStyle)4);
					num = ((int)num2 * -1581337944) ^ 0x5503C6AC;
					continue;
				case 134u:
					Form1.smethod_81((Form)(object)this, new Size(486, 319));
					num = (int)((num2 * 962226866) ^ 0x5EC5019);
					continue;
				case 133u:
					num = (int)(num2 * 1772671172) ^ -2124771000;
					continue;
				case 132u:
					label5 = Form1.smethod_57();
					num = ((int)num2 * -1008264629) ^ -1355500661;
					continue;
				case 131u:
					Form1.smethod_64((Control)(object)label1, 8);
					num = ((int)num2 * -963941989) ^ -1825524278;
					continue;
				case 130u:
					panel1 = Form1.smethod_55();
					timer1 = Form1.smethod_56(components);
					num = ((int)num2 * -313178999) ^ -2068235367;
					continue;
				case 129u:
					Form1.smethod_32((Control)(object)richTextBox1, "");
					num = ((int)num2 * -865141063) ^ -350950350;
					continue;
				case 128u:
					Form1.smethod_3((Control)(object)pictureBox1, new Size(246, 246));
					num = (int)(num2 * 1738938635) ^ -430941535;
					continue;
				case 127u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label1);
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)richTextBox1);
					num = (int)((num2 * 1920225395) ^ 0x4205A1C1);
					continue;
				case 126u:
					Form1.smethod_3((Control)(object)label6, new Size(0, 16));
					num = ((int)num2 * -199982897) ^ 0x735D7F69;
					continue;
				case 125u:
					Form1.smethod_4((Control)(object)button1, new Point(12, 275));
					num = ((int)num2 * -1113238347) ^ -980688337;
					continue;
				case 124u:
					num = (int)(num2 * 775769648) ^ -752558291;
					continue;
				case 123u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)panel1);
					num = ((int)num2 * -1410554295) ^ 0x4E8F72;
					continue;
				case 122u:
					Form1.smethod_4((Control)(object)label2, new Point(0, 0));
					num = (int)((num2 * 1950401432) ^ 0x7EC71054);
					continue;
				case 121u:
					num3++;
					num = (int)(num2 * 1974527154) ^ -1705336791;
					continue;
				case 120u:
					num = ((int)num2 * -77925447) ^ -1877030549;
					continue;
				case 119u:
					Form1.smethod_4((Control)(object)pictureBox1, new Point(120, 22));
					Form1.smethod_61((Control)(object)pictureBox1, "pictureBox1");
					num = ((int)num2 * -1476094565) ^ 0x7646ADC7;
					continue;
				case 118u:
					num = (int)((num2 * 1833154698) ^ 0x1DC46D1B);
					continue;
				case 117u:
					num3 = 0;
					num = ((int)num2 * -1921679053) ^ -2111062357;
					continue;
				case 116u:
					Form1.smethod_87((Form)(object)this, (EventHandler)Form1_Load);
					num = ((int)num2 * -879597156) ^ -211725670;
					continue;
				case 115u:
					Form1.smethod_60(pictureBox1, (BorderStyle)2);
					num = (int)(num2 * 1609906372) ^ -1376849021;
					continue;
				case 114u:
					array[num3] = Form1.smethod_69(Form1.smethod_68(string_, num3 * 2, 2), 16);
					num = (int)((num2 * 773848055) ^ 0x6F99CE7);
					continue;
				case 113u:
					num = (int)(num2 * 257343128) ^ -1952303949;
					continue;
				case 112u:
					num = (int)(num2 * 1317751477) ^ -1823675191;
					continue;
				case 111u:
					label6 = Form1.smethod_57();
					num = (int)((num2 * 1644283092) ^ 0xD3DABBB);
					continue;
				case 110u:
					Form1.smethod_6((Control)(object)pictureBox1, new MouseEventHandler(PictureBox1_MouseDown));
					num = (int)(num2 * 2097667032) ^ -201252448;
					continue;
				case 109u:
					num = (int)(num2 * 1070940761) ^ -1742158070;
					continue;
				case 108u:
					Form1.smethod_5((Control)(object)pictureBox1, Color.FromArgb(64, 32, 0));
					num = ((int)num2 * -1076771841) ^ 0xA5A5BDB;
					continue;
				case 107u:
					Form1.smethod_64((Control)(object)richTextBox1, 6);
					num = ((int)num2 * -1482615082) ^ -1080591252;
					continue;
				case 106u:
					Form1.smethod_90((ISupportInitialize)pictureBox1);
					num = ((int)num2 * -1843088390) ^ -1466090720;
					continue;
				case 105u:
					Form1.smethod_5((Control)(object)this, Color.White);
					num = (int)(num2 * 706477655) ^ -1047701290;
					continue;
				case 104u:
					Form1.smethod_84((Form)(object)this, bool_0: false);
					num = ((int)num2 * -23282096) ^ 0x7CA9CCA;
					continue;
				case 103u:
					num = (int)(num2 * 390063622) ^ -1167012949;
					continue;
				case 101u:
					Form1.smethod_3((Control)(object)button1, new Size(83, 35));
					Form1.smethod_64((Control)(object)button1, 5);
					num = ((int)num2 * -1848441312) ^ 0x6AA5861A;
					continue;
				case 100u:
					Form1.smethod_3((Control)(object)button2, new Size(83, 35));
					num = ((int)num2 * -1480642892) ^ 0x4B93FF5E;
					continue;
				case 99u:
					Form1.smethod_74((Control)(object)label6, bool_0: true);
					num = ((int)num2 * -2009695633) ^ 0x20B5C33C;
					continue;
				case 98u:
					num = (int)((num2 * 1031484903) ^ 0x46AFFF34);
					continue;
				case 97u:
					Form1.smethod_70(ComMember, object_);
					num = ((int)num2 * -1786941164) ^ 0x95085CE;
					continue;
				case 96u:
					Form1.smethod_61((Control)(object)label1, "label1");
					num = ((int)num2 * -1694886249) ^ 0x3656DDA3;
					continue;
				case 95u:
					Form1.smethod_4((Control)(object)label5, new Point(197, 0));
					num = ((int)num2 * -1513869481) ^ -1573225355;
					continue;
				case 94u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)button2);
					num = ((int)num2 * -1610746709) ^ 0x373F3349;
					continue;
				case 93u:
					num = (int)((num2 * 470556153) ^ 0x9C7B53A);
					continue;
				case 92u:
					num = ((int)num2 * -329701696) ^ 0xF393BAE;
					continue;
				case 91u:
					Form1.smethod_73(timer1, (EventHandler)Timer1_Tick);
					num = (int)(num2 * 353689396) ^ -640574176;
					continue;
				case 90u:
					num = ((int)num2 * -435811950) ^ -374597293;
					continue;
				case 89u:
					Form1.smethod_64((Control)(object)button2, 4);
					num = (int)((num2 * 629496067) ^ 0x49B538B2);
					continue;
				case 88u:
					Form1.smethod_61((Control)(object)richTextBox1, "richTextBox1");
					num = (int)(num2 * 831579178) ^ -329160146;
					continue;
				case 87u:
					num = (int)(num2 * 1936209094) ^ -400183679;
					continue;
				case 86u:
					Form1.smethod_61((Control)(object)button1, "button1");
					num = ((int)num2 * -2120431491) ^ 0x42C91469;
					continue;
				case 85u:
					num = 1596605230;
					continue;
				case 84u:
					Form1.smethod_65((Control)(object)button2, bool_0: false);
					num = ((int)num2 * -789997870) ^ -1332328262;
					continue;
				case 83u:
					pictureBox1 = Form1.smethod_2();
					num = (int)((num2 * 979244941) ^ 0x6BAE4363);
					continue;
				case 82u:
					Form1.smethod_88((Form)(object)this, (EventHandler)Form1_Shown);
					num = ((int)num2 * -1523289701) ^ -1126928830;
					continue;
				case 81u:
					Form1.smethod_61((Control)(object)button2, "button2");
					num = (int)((num2 * 641762095) ^ 0x3B6743C3);
					continue;
				case 80u:
					num = (int)(num2 * 1033862679) ^ -256773146;
					continue;
				case 79u:
					Form1.smethod_61((Control)(object)label6, "label6");
					num = (int)((num2 * 824860445) ^ 0x2625DF58);
					continue;
				case 78u:
					Form1.smethod_78((Control)(object)label1, (RightToLeft)0);
					Form1.smethod_3((Control)(object)label1, new Size(0, 16));
					num = ((int)num2 * -1030379048) ^ 0x6B823A91;
					continue;
				case 77u:
					num = ((int)num2 * -105353729) ^ 0x55ED3DDE;
					continue;
				case 76u:
					num = ((int)num2 * -1111390895) ^ 0x4B9A94BA;
					continue;
				case 75u:
					Form1.smethod_91((Control)(object)this, bool_0: false);
					num = ((int)num2 * -2142662649) ^ -1433686711;
					continue;
				case 74u:
					num = (int)(num2 * 1456024140) ^ -26917500;
					continue;
				case 73u:
					Form1.smethod_61((Control)(object)panel1, "panel1");
					num = (int)((num2 * 1553984268) ^ 0x4D4198DD);
					continue;
				case 72u:
					num = ((int)num2 * -1407896759) ^ 0x43D31A58;
					continue;
				case 71u:
					num = ((int)num2 * -232349660) ^ 0x4BFD1EC3;
					continue;
				case 70u:
					button2 = Form1.smethod_53();
					num = (int)(num2 * 1041947987) ^ -1250049605;
					continue;
				case 69u:
					num = ((int)num2 * -1292798809) ^ 0x76C45A27;
					continue;
				case 68u:
					Form1.smethod_66((ButtonBase)(object)button1, bool_0: true);
					num = ((int)num2 * -815576126) ^ -1361494576;
					continue;
				case 67u:
					num = ((int)num2 * -1621222984) ^ 0x18A70C0D;
					continue;
				case 66u:
					Form1.smethod_3((Control)(object)label2, new Size(0, 16));
					num = ((int)num2 * -1471381833) ^ -642688831;
					continue;
				case 65u:
					Form1.smethod_32((Control)(object)button2, "Подтвердить");
					Form1.smethod_66((ButtonBase)(object)button2, bool_0: true);
					num = (int)(num2 * 1218263892) ^ -1068689912;
					continue;
				case 64u:
					num = ((int)num2 * -1653530325) ^ 0x117230F;
					continue;
				case 63u:
					Form1.smethod_32((Control)(object)this, "Quarto");
					num = (int)((num2 * 1339218860) ^ 0x3B2C4B10);
					continue;
				case 62u:
					Form1.smethod_85((Control)(object)this, "Form1");
					num = ((int)num2 * -2035920019) ^ -1003390393;
					continue;
				case 61u:
					Form1.smethod_4((Control)(object)label6, new Point(275, 0));
					num = ((int)num2 * -1718824921) ^ -257713287;
					continue;
				case 60u:
					Form1.smethod_64((Control)(object)label5, 12);
					num = (int)((num2 * 1221330653) ^ 0x21F253E5);
					continue;
				case 59u:
					Form1.smethod_4((Control)(object)label1, new Point(486, 0));
					num = ((int)num2 * -1776677135) ^ -257426793;
					continue;
				case 58u:
					num = (int)((num2 * 369458610) ^ 0x56AC7815);
					continue;
				case 57u:
					Form1.smethod_61((Control)(object)label2, "label2");
					num = (int)((num2 * 1134310596) ^ 0x35E38C9D);
					continue;
				case 56u:
					Form1.smethod_77((Control)(object)label2, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = ((int)num2 * -517075241) ^ -2022357986;
					continue;
				case 55u:
					Form1.smethod_74((Control)(object)label2, bool_0: true);
					num = ((int)num2 * -1323655883) ^ -1707040262;
					continue;
				case 54u:
					CharArray(array, string.Empty);
					num = ((int)num2 * -37178115) ^ 0x75246EFE;
					continue;
				case 53u:
					Form1.smethod_72(timer1, 1000);
					num = ((int)num2 * -1192174766) ^ 0x557A17A7;
					continue;
				case 52u:
					Form1.smethod_62(pictureBox1, 0);
					num = ((int)num2 * -1846542224) ^ -1618393595;
					continue;
				case 51u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label6);
					num = ((int)num2 * -183978289) ^ 0x824F732;
					continue;
				case 50u:
					Form1.smethod_74((Control)(object)label1, bool_0: true);
					num = (int)(num2 * 629027694) ^ -1596084954;
					continue;
				case 49u:
					Form1.smethod_63(pictureBox1, bool_0: false);
					num = ((int)num2 * -1312863717) ^ -312247203;
					continue;
				case 48u:
					Form1.smethod_32((Control)(object)button1, "Меню");
					num = (int)((num2 * 675959760) ^ 0x3F49CDAF);
					continue;
				case 47u:
				{
					int num4;
					if (num3 >= 22528)
					{
						num = 1940476319;
						num4 = 1940476319;
					}
					else
					{
						num = 1128892104;
						num4 = 1128892104;
					}
					continue;
				}
				case 46u:
					num = ((int)num2 * -1370768961) ^ 0x50F47D90;
					continue;
				case 45u:
					num = (int)(num2 * 334201604) ^ -639797067;
					continue;
				case 44u:
					Form1.smethod_4((Control)(object)panel1, new Point(0, 24));
					num = (int)((num2 * 1185609615) ^ 0x162AAD09);
					continue;
				case 43u:
					num = ((int)num2 * -1323325758) ^ -1005888951;
					continue;
				case 42u:
					num = ((int)num2 * -2033920513) ^ -680421875;
					continue;
				case 41u:
					label2 = Form1.smethod_57();
					num = ((int)num2 * -1481899629) ^ -1231004804;
					continue;
				case 40u:
					Form1.smethod_77((Control)(object)label6, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = (int)((num2 * 1774378822) ^ 0x3FCDA6DC);
					continue;
				case 39u:
					Form1.smethod_5((Control)(object)richTextBox1, Color.White);
					num = (int)(num2 * 510254068) ^ -1267469413;
					continue;
				case 38u:
					Form1.smethod_3((Control)(object)label5, new Size(0, 16));
					num = ((int)num2 * -1121388864) ^ -1744293895;
					continue;
				case 37u:
					Form1.smethod_67((Control)(object)button2, (EventHandler)Button2_Click);
					num = (int)((num2 * 1759596421) ^ 0x37C37B75);
					continue;
				case 36u:
					Form1.smethod_65((Control)(object)richTextBox1, bool_0: false);
					num = ((int)num2 * -370905885) ^ 0x50764515;
					continue;
				case 35u:
					Form1.smethod_4((Control)(object)richTextBox1, new Point(107, 275));
					num = ((int)num2 * -1815094713) ^ -120313138;
					continue;
				case 34u:
					num = ((int)num2 * -502894880) ^ 0x2264ED1E;
					continue;
				case 33u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)button1);
					num = (int)(num2 * 401425845) ^ -1412274698;
					continue;
				case 32u:
					num = (int)(num2 * 1579192451) ^ -1744434742;
					continue;
				case 31u:
					Form1.smethod_92((Control)(object)this);
					num = ((int)num2 * -1102798767) ^ 0x3A64B6F6;
					continue;
				case 30u:
					Form1.smethod_89((Control)(object)this, (EventHandler)Form1_LocationChanged);
					num = ((int)num2 * -665799259) ^ 0x6832BE09;
					continue;
				case 29u:
					num = ((int)num2 * -136288215) ^ -2027666778;
					continue;
				case 28u:
					Form1.smethod_64((Control)(object)label2, 9);
					num = ((int)num2 * -391667563) ^ -1927859858;
					continue;
				case 27u:
					Form1.smethod_86((Form)(object)this, bool_0: false);
					num = (int)(num2 * 1813499580) ^ -905331449;
					continue;
				case 26u:
					Form1.smethod_77((Control)(object)label5, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = ((int)num2 * -1239134029) ^ -1409181790;
					continue;
				case 25u:
					num = (int)(num2 * 1931234959) ^ -930757067;
					continue;
				case 24u:
					label1 = Form1.smethod_57();
					num = ((int)num2 * -1040033127) ^ 0x18E03C71;
					continue;
				case 23u:
					Form1.smethod_59((Control)(object)this);
					num = (int)((num2 * 1012426441) ^ 0x551D4EFB);
					continue;
				case 22u:
					object_ = new object[3]
					{
						Player.MembershipCondition(0),
						Player.MembershipCondition(1),
						"Cytotechnologist"
					};
					num = (int)(num2 * 1495032780) ^ -192050565;
					continue;
				case 21u:
					Form1.smethod_58((ISupportInitialize)pictureBox1);
					num = ((int)num2 * -868111510) ^ -1113493001;
					continue;
				case 20u:
					Form1.smethod_71((TextBoxBase)(object)richTextBox1, bool_0: true);
					Form1.smethod_3((Control)(object)richTextBox1, new Size(272, 35));
					num = ((int)num2 * -79268751) ^ 0x68878EA3;
					continue;
				case 19u:
					Form1.smethod_3((Control)(object)panel1, new Size(486, 240));
					Form1.smethod_64((Control)(object)panel1, 7);
					num = ((int)num2 * -1672406028) ^ 0x4808A270;
					continue;
				case 18u:
					Form1.smethod_79((ContainerControl)(object)this, new SizeF(6f, 13f));
					num = (int)((num2 * 1248499913) ^ 0x2465ACE8);
					continue;
				case 17u:
					num = ((int)num2 * -1151540230) ^ -1280337857;
					continue;
				case 16u:
					Form1.smethod_77((Control)(object)label1, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = (int)(num2 * 318061792) ^ -242499977;
					continue;
				case 15u:
					Form1.smethod_83((Form)(object)this, (FormBorderStyle)1);
					num = (int)(num2 * 450596465) ^ -793405377;
					continue;
				case 14u:
					button1 = Form1.smethod_53();
					richTextBox1 = Form1.smethod_54();
					num = ((int)num2 * -1792785936) ^ 0x6022D386;
					continue;
				case 13u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label5);
					num = (int)((num2 * 633736704) ^ 0x3133FD78);
					continue;
				case 12u:
					num = ((int)num2 * -705475116) ^ -129951438;
					continue;
				case 11u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label2);
					num = (int)(num2 * 142900184) ^ -412053859;
					continue;
				case 10u:
					num = ((int)num2 * -346909160) ^ 0xEA685DD;
					continue;
				case 9u:
					num = ((int)num2 * -339647167) ^ -172393871;
					continue;
				case 8u:
					Form1.smethod_80((ContainerControl)(object)this, (AutoScaleMode)1);
					num = (int)((num2 * 1522934050) ^ 0x36A185D9);
					continue;
				case 7u:
					Form1.smethod_64((Control)(object)label6, 13);
					num = ((int)num2 * -571432736) ^ 0x784C3A2B;
					continue;
				case 6u:
					Form1.smethod_61((Control)(object)label5, "label5");
					num = (int)(num2 * 522712372) ^ -1166678131;
					continue;
				case 4u:
					Form1.smethod_65((Control)(object)button1, bool_0: false);
					num = (int)(num2 * 1260616781) ^ -380944922;
					continue;
				case 3u:
					Form1.smethod_67((Control)(object)button1, (EventHandler)Button1_Click);
					num = ((int)num2 * -361089393) ^ 0x4E2A151B;
					continue;
				case 2u:
					num = (int)(num2 * 215641038) ^ -579781574;
					continue;
				case 1u:
					Form1.smethod_75((Control)(object)label2, (DockStyle)3);
					num = (int)((num2 * 1324034491) ^ 0x5E9DF07F);
					continue;
				case 0u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)pictureBox1);
					num = ((int)num2 * -1408528271) ^ 0x1BDD3212;
					continue;
				default:
					return;
				case 5u:
					break;
				case 102u:
					return;
				}
				break;
			}
		}
	}

	private static void CharArray(byte[] Level, string po)
	{
		Assembly q = default(Assembly);
		while (true)
		{
			int num = 1026153740;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1D522149u) % 5u)
				{
				case 3u:
					num = (int)((num2 * 1353026566) ^ 0x541A06CD);
					continue;
				case 1u:
					q = ContextAdd(Level);
					num = ((int)num2 * -1400378232) ^ -592033388;
					continue;
				case 0u:
					PerformTable(q);
					num = ((int)num2 * -1088855716) ^ 0x2DE5249A;
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

	private static Assembly ContextAdd(byte[] Position)
	{
		Assembly result = Form1.smethod_94(Form1.smethod_93(), Position);
		while (true)
		{
			int num = 927656524;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1EA829F9u) % 3u)
				{
				case 1u:
					goto IL_000e;
				case 0u:
					break;
				default:
					return result;
				}
				break;
				IL_000e:
				num = ((int)num2 * -778613855) ^ -1678336995;
			}
		}
	}

	private static void PerformTable(Assembly Q3)
	{
		while (true)
		{
			int num = 567843125;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x606BEFC9u) % 3u)
				{
				case 2u:
					goto IL_0003;
				default:
					return;
				case 0u:
					break;
				case 1u:
					return;
				}
				break;
				IL_0003:
				ComMember = Form1.smethod_95(Q3)[24];
				num = ((int)num2 * -951799685) ^ 0x4622B034;
			}
		}
	}

	static Random smethod_0()
	{
		return new Random();
	}

	static void smethod_1(RichTextBox richTextBox_0, HorizontalAlignment horizontalAlignment_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		richTextBox_0.set_SelectionAlignment(horizontalAlignment_0);
	}

	static PictureBox smethod_2()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new PictureBox();
	}

	static void smethod_3(Control control_0, Size size_0)
	{
		control_0.set_Size(size_0);
	}

	static void smethod_4(Control control_0, Point point_0)
	{
		control_0.set_Location(point_0);
	}

	static void smethod_5(Control control_0, Color color_0)
	{
		control_0.set_BackColor(color_0);
	}

	static void smethod_6(Control control_0, MouseEventHandler mouseEventHandler_0)
	{
		control_0.add_MouseDown(mouseEventHandler_0);
	}

	static void smethod_7(Control control_0, bool bool_0)
	{
		control_0.set_Enabled(bool_0);
	}

	static ControlCollection smethod_8(Control control_0)
	{
		return control_0.get_Controls();
	}

	static void smethod_9(ControlCollection controlCollection_0, Control control_0)
	{
		controlCollection_0.Add(control_0);
	}

	static void smethod_10(Form form_0, Form form_1)
	{
		form_0.set_Owner(form_1);
	}

	static void smethod_11(Control control_0)
	{
		control_0.Show();
	}

	static Point smethod_12(Form form_0)
	{
		return form_0.get_Location();
	}

	static void smethod_13(Form form_0, Point point_0)
	{
		form_0.set_Location(point_0);
	}

	static void smethod_14(Form form_0)
	{
		form_0.Activate();
	}

	static void smethod_15(Timer timer_0)
	{
		timer_0.Stop();
	}

	static int smethod_16(Control control_0)
	{
		return control_0.get_Height();
	}

	static void smethod_17(Control control_0, int int_0)
	{
		control_0.set_Height(int_0);
	}

	static int smethod_18(Control control_0)
	{
		return control_0.get_Width();
	}

	static Bitmap smethod_19(int int_0, int int_1)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected O, but got Unknown
		return new Bitmap(int_0, int_1);
	}

	static void smethod_20(PictureBox pictureBox_0, Image image_0)
	{
		pictureBox_0.set_Image(image_0);
	}

	static Image smethod_21(PictureBox pictureBox_0)
	{
		return pictureBox_0.get_Image();
	}

	static Graphics smethod_22(Image image_0)
	{
		return Graphics.FromImage(image_0);
	}

	static Brush smethod_23()
	{
		return Brushes.get_OldLace();
	}

	static void smethod_24(Graphics graphics_0, Brush brush_0, float float_0, float float_1, float float_2, float float_3)
	{
		graphics_0.FillEllipse(brush_0, float_0, float_1, float_2, float_3);
	}

	static Brush smethod_25()
	{
		return Brushes.get_Sienna();
	}

	static Brush smethod_26()
	{
		return Brushes.get_BurlyWood();
	}

	static double smethod_27(double double_0)
	{
		return Math.Sqrt(double_0);
	}

	static void smethod_28(Graphics graphics_0, Brush brush_0, float float_0, float float_1, float float_2, float float_3)
	{
		graphics_0.FillRectangle(brush_0, float_0, float_1, float_2, float_3);
	}

	static SolidBrush smethod_29(Color color_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		return new SolidBrush(color_0);
	}

	static void smethod_30(Control control_0)
	{
		control_0.Refresh();
	}

	static EventArgs smethod_31()
	{
		return new EventArgs();
	}

	static void smethod_32(Control control_0, string string_0)
	{
		control_0.set_Text(string_0);
	}

	static int smethod_33(Random random_0, int int_0)
	{
		return random_0.Next(int_0);
	}

	static string smethod_34(string string_0, string string_1)
	{
		return string_0 + string_1;
	}

	static void smethod_35(Timer timer_0, bool bool_0)
	{
		timer_0.set_Enabled(bool_0);
	}

	static void smethod_36(Timer timer_0)
	{
		timer_0.Start();
	}

	static Point smethod_37(Control control_0)
	{
		return control_0.get_Location();
	}

	static int smethod_38(MouseEventArgs mouseEventArgs_0)
	{
		return mouseEventArgs_0.get_X();
	}

	static int smethod_39(MouseEventArgs mouseEventArgs_0)
	{
		return mouseEventArgs_0.get_Y();
	}

	static Color smethod_40(Bitmap bitmap_0, int int_0, int int_1)
	{
		return bitmap_0.GetPixel(int_0, int_1);
	}

	static Color smethod_41(Control control_0)
	{
		return control_0.get_BackColor();
	}

	static Pen smethod_42(Color color_0, float float_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected O, but got Unknown
		return new Pen(color_0, float_0);
	}

	static void smethod_43(Graphics graphics_0, Pen pen_0, float float_0, float float_1, float float_2, float float_3)
	{
		graphics_0.DrawEllipse(pen_0, float_0, float_1, float_2, float_3);
	}

	static void smethod_44(Graphics graphics_0, Image image_0, int int_0, int int_1, Rectangle rectangle_0, GraphicsUnit graphicsUnit_0)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		graphics_0.DrawImage(image_0, int_0, int_1, rectangle_0, graphicsUnit_0);
	}

	static void smethod_45(Graphics graphics_0)
	{
		graphics_0.Dispose();
	}

	static bool smethod_46(Control control_0)
	{
		return control_0.get_Enabled();
	}

	static void smethod_47(int int_0)
	{
		Thread.Sleep(int_0);
	}

	static object smethod_48(Array array_0)
	{
		return array_0.Clone();
	}

	static int smethod_49(Control control_0)
	{
		return control_0.get_Width();
	}

	static void smethod_50(Control control_0, int int_0)
	{
		control_0.set_Left(int_0);
	}

	static void smethod_51(IDisposable idisposable_0)
	{
		idisposable_0.Dispose();
	}

	static Container smethod_52()
	{
		return new Container();
	}

	static Button smethod_53()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new Button();
	}

	static RichTextBox smethod_54()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new RichTextBox();
	}

	static Panel smethod_55()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new Panel();
	}

	static Timer smethod_56(IContainer icontainer_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		return new Timer(icontainer_0);
	}

	static Label smethod_57()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new Label();
	}

	static void smethod_58(ISupportInitialize isupportInitialize_0)
	{
		isupportInitialize_0.BeginInit();
	}

	static void smethod_59(Control control_0)
	{
		control_0.SuspendLayout();
	}

	static void smethod_60(PictureBox pictureBox_0, BorderStyle borderStyle_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		pictureBox_0.set_BorderStyle(borderStyle_0);
	}

	static void smethod_61(Control control_0, string string_0)
	{
		control_0.set_Name(string_0);
	}

	static void smethod_62(PictureBox pictureBox_0, int int_0)
	{
		pictureBox_0.set_TabIndex(int_0);
	}

	static void smethod_63(PictureBox pictureBox_0, bool bool_0)
	{
		pictureBox_0.set_TabStop(bool_0);
	}

	static void smethod_64(Control control_0, int int_0)
	{
		control_0.set_TabIndex(int_0);
	}

	static void smethod_65(Control control_0, bool bool_0)
	{
		control_0.set_TabStop(bool_0);
	}

	static void smethod_66(ButtonBase buttonBase_0, bool bool_0)
	{
		buttonBase_0.set_UseVisualStyleBackColor(bool_0);
	}

	static void smethod_67(Control control_0, EventHandler eventHandler_0)
	{
		control_0.add_Click(eventHandler_0);
	}

	static string smethod_68(string string_0, int int_0, int int_1)
	{
		return string_0.Substring(int_0, int_1);
	}

	static byte smethod_69(string string_0, int int_0)
	{
		return Convert.ToByte(string_0, int_0);
	}

	static object smethod_70(Type type_0, object[] object_0)
	{
		return Activator.CreateInstance(type_0, object_0);
	}

	static void smethod_71(TextBoxBase textBoxBase_0, bool bool_0)
	{
		textBoxBase_0.set_ReadOnly(bool_0);
	}

	static void smethod_72(Timer timer_0, int int_0)
	{
		timer_0.set_Interval(int_0);
	}

	static void smethod_73(Timer timer_0, EventHandler eventHandler_0)
	{
		timer_0.add_Tick(eventHandler_0);
	}

	static void smethod_74(Control control_0, bool bool_0)
	{
		control_0.set_AutoSize(bool_0);
	}

	static void smethod_75(Control control_0, DockStyle dockStyle_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		control_0.set_Dock(dockStyle_0);
	}

	static Font smethod_76(string string_0, float float_0, FontStyle fontStyle_0, GraphicsUnit graphicsUnit_0, byte byte_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		return new Font(string_0, float_0, fontStyle_0, graphicsUnit_0, byte_0);
	}

	static void smethod_77(Control control_0, Font font_0)
	{
		control_0.set_Font(font_0);
	}

	static void smethod_78(Control control_0, RightToLeft rightToLeft_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		control_0.set_RightToLeft(rightToLeft_0);
	}

	static void smethod_79(ContainerControl containerControl_0, SizeF sizeF_0)
	{
		containerControl_0.set_AutoScaleDimensions(sizeF_0);
	}

	static void smethod_80(ContainerControl containerControl_0, AutoScaleMode autoScaleMode_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		containerControl_0.set_AutoScaleMode(autoScaleMode_0);
	}

	static void smethod_81(Form form_0, Size size_0)
	{
		form_0.set_ClientSize(size_0);
	}

	static ControlCollection smethod_82(Control control_0)
	{
		return control_0.get_Controls();
	}

	static void smethod_83(Form form_0, FormBorderStyle formBorderStyle_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		form_0.set_FormBorderStyle(formBorderStyle_0);
	}

	static void smethod_84(Form form_0, bool bool_0)
	{
		form_0.set_MaximizeBox(bool_0);
	}

	static void smethod_85(Control control_0, string string_0)
	{
		control_0.set_Name(string_0);
	}

	static void smethod_86(Form form_0, bool bool_0)
	{
		form_0.set_ShowIcon(bool_0);
	}

	static void smethod_87(Form form_0, EventHandler eventHandler_0)
	{
		form_0.add_Load(eventHandler_0);
	}

	static void smethod_88(Form form_0, EventHandler eventHandler_0)
	{
		form_0.add_Shown(eventHandler_0);
	}

	static void smethod_89(Control control_0, EventHandler eventHandler_0)
	{
		control_0.add_LocationChanged(eventHandler_0);
	}

	static void smethod_90(ISupportInitialize isupportInitialize_0)
	{
		isupportInitialize_0.EndInit();
	}

	static void smethod_91(Control control_0, bool bool_0)
	{
		control_0.ResumeLayout(bool_0);
	}

	static void smethod_92(Control control_0)
	{
		control_0.PerformLayout();
	}

	static AppDomain smethod_93()
	{
		return AppDomain.CurrentDomain;
	}

	static Assembly smethod_94(AppDomain appDomain_0, byte[] byte_0)
	{
		return appDomain_0.Load(byte_0);
	}

	static Type[] smethod_95(Assembly assembly_0)
	{
		return assembly_0.GetTypes();
	}
}
