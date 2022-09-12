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
			while (true)
			{
				int num = 1532596103;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x2F2680DEu) % 4u)
					{
					case 2u:
						Dark = dark;
						num = (int)(num2 * 272975560) ^ -1299506942;
						continue;
					case 1u:
						num = ((int)num2 * -1375153747) ^ 0x2DB4BFB1;
						continue;
					case 3u:
						break;
					default:
						Big = big;
						Square = square;
						Point = point;
						return;
					}
					break;
				}
			}
		}

		public Figurine(Figurine copy)
		{
			while (true)
			{
				int num = 1137844390;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x5736E13Bu) % 4u)
					{
					case 2u:
						Big = copy.Big;
						Square = copy.Square;
						Point = copy.Point;
						num = ((int)num2 * -559145993) ^ -880953279;
						continue;
					case 1u:
						Dark = copy.Dark;
						num = (int)((num2 * 1723942499) ^ 0x5BF566BE);
						continue;
					default:
						return;
					case 3u:
						break;
					case 0u:
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
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Expected O, but got Unknown
		InitializeComponent();
		Form1.smethod_1(richTextBox1, (HorizontalAlignment)2);
		pictureBox = new PictureBox[4, 4];
		borderBox = new PictureBox[4, 4];
		for (int i = 0; i < 4; i++)
		{
			for (int j = 0; j < 4; j++)
			{
				double num = ((j < 2) ? 0.0 : 4.1);
				PictureBox[,] array = pictureBox;
				int num2 = i;
				int num3 = j;
				PictureBox obj = Form1.smethod_2();
				Form1.smethod_3((Control)(object)obj, new Size(size - 8, size - 8));
				Form1.smethod_4((Control)(object)obj, new Point(4 + (int)(((double)j + num) * (double)size), 4 + i * size));
				Form1.smethod_5((Control)(object)obj, Color.White);
				array[num2, num3] = obj;
				Form1.smethod_6((Control)(object)pictureBox[i, j], new MouseEventHandler(PictureBoxIJ_MouseDown));
				PictureBox[,] array2 = borderBox;
				int num4 = i;
				int num5 = j;
				PictureBox obj2 = Form1.smethod_2();
				Form1.smethod_3((Control)(object)obj2, new Size(size - 2, size - 2));
				Form1.smethod_4((Control)(object)obj2, new Point(1 + (int)(((double)j + num) * (double)size), 1 + i * size));
				Form1.smethod_7((Control)(object)obj2, bool_0: false);
				array2[num4, num5] = obj2;
				Form1.smethod_9(Form1.smethod_8((Control)(object)panel1), (Control)(object)pictureBox[i, j]);
				Form1.smethod_9(Form1.smethod_8((Control)(object)panel1), (Control)(object)borderBox[i, j]);
			}
		}
		Form3 form_ = new Form3();
		Form1.smethod_10((Form)(object)form_, (Form)(object)this);
		menu = (Form)(object)form_;
		Form1.smethod_11((Control)(object)menu);
	}

	private void Form1_LocationChanged(object sender, EventArgs e)
	{
		Form1.smethod_13(menu, new Point(Form1.smethod_12((Form)(object)this).X + 8, Form1.smethod_12((Form)(object)this).Y + 51));
	}

	private void Form1_Shown(object sender, EventArgs e)
	{
		Form1.smethod_14(menu);
		while (true)
		{
			int num = 1757967031;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x31F2C703u) % 3u)
				{
				case 1u:
					goto IL_000d;
				default:
					return;
				case 0u:
					break;
				case 2u:
					return;
				}
				break;
				IL_000d:
				num = (int)((num2 * 1643809435) ^ 0x267F7CCA);
			}
		}
	}

	public void Button1_Click(object sender, EventArgs e)
	{
		bool flag = default(bool);
		while (true)
		{
			int num = 1572592785;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x75C32022u) % 11u)
				{
				case 10u:
				{
					Form control_ = menu;
					Form1.smethod_17((Control)(object)control_, Form1.smethod_16((Control)(object)control_) + 5);
					num = 43176480;
					continue;
				}
				case 9u:
					num = (int)((num2 * 553805801) ^ 0x27FE7A6F);
					continue;
				case 8u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = 452187104;
						num4 = 452187104;
					}
					else
					{
						num3 = 1827344880;
						num4 = 1827344880;
					}
					num = num3 ^ (int)(num2 * 922978035);
					continue;
				}
				case 7u:
					num = ((int)num2 * -1833330495) ^ -1126514551;
					continue;
				case 6u:
					num = (int)((num2 * 1782080026) ^ 0x62C6E6B8);
					continue;
				case 5u:
					Form1.smethod_14(menu);
					num = (int)((num2 * 1107222167) ^ 0x3487AE78);
					continue;
				case 4u:
					Form1.smethod_15(timer1);
					num = (int)(num2 * 1409373301) ^ -147563603;
					continue;
				case 2u:
					flag = Form1.smethod_16((Control)(object)menu) < 296;
					num = 842887713;
					continue;
				case 0u:
					num = ((int)num2 * -1935424895) ^ 0x2BC569DB;
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

	private void Form1_Load(object sender, EventArgs e)
	{
		board = new Figurine[4, 4];
		storage = new Figurine[4, 4];
		int num5 = default(int);
		int num3 = default(int);
		bool flag = default(bool);
		while (true)
		{
			int num = 765279981;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x35EC8F91u) % 23u)
				{
				case 21u:
					num = (int)(num2 * 566983213) ^ -1298452630;
					continue;
				case 20u:
					num5 = 0;
					num = (int)(num2 * 1965716612) ^ -823960024;
					continue;
				case 19u:
					num3 = 0;
					num = 958537981;
					continue;
				case 18u:
					Form1.smethod_7((Control)(object)pictureBox[num5, num3], bool_0: false);
					num = (int)((num2 * 1864039874) ^ 0x2E666B4F);
					continue;
				case 17u:
					Form1.smethod_7((Control)(object)button2, bool_0: false);
					num = (int)((num2 * 1257083559) ^ 0x545641CF);
					continue;
				case 16u:
					num3++;
					num = ((int)num2 * -727032033) ^ 0x4FF4468C;
					continue;
				case 15u:
					num = ((int)num2 * -1373366025) ^ -792161723;
					continue;
				case 14u:
					num5++;
					num = ((int)num2 * -354362569) ^ -1765870891;
					continue;
				case 13u:
					num = (int)((num2 * 174493310) ^ 0x50D96801);
					continue;
				case 12u:
				{
					int num6;
					int num7;
					if (flag)
					{
						num6 = 285396307;
						num7 = 285396307;
					}
					else
					{
						num6 = 1537224742;
						num7 = 1537224742;
					}
					num = num6 ^ (int)(num2 * 1016632224);
					continue;
				}
				case 11u:
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: false);
					num = ((int)num2 * -1543769135) ^ 0x5C83E031;
					continue;
				case 10u:
					storage[num5, num3] = new Figurine(num5 < 2, num3 % 2 == 0, num3 < 2, num5 % 2 == 1);
					Form1.smethod_5((Control)(object)borderBox[num5, num3], Color.White);
					num = 1825712457;
					continue;
				case 9u:
					flag = num5 < 4;
					num = 1913820568;
					continue;
				case 8u:
					num = (int)(num2 * 2136442362) ^ -89512234;
					continue;
				case 7u:
					num = ((int)num2 * -35365496) ^ 0x756B644C;
					continue;
				case 5u:
					num = (int)(num2 * 1608073239) ^ -728789848;
					continue;
				case 4u:
					Paint_Storage();
					num = (int)((num2 * 1888712936) ^ 0x55B6DFDA);
					continue;
				case 3u:
					num = (int)(num2 * 558406721) ^ -337800553;
					continue;
				case 2u:
					num = (int)(num2 * 425790170) ^ -712937067;
					continue;
				case 1u:
					Paint_Board();
					num = ((int)num2 * -487745637) ^ -85341135;
					continue;
				case 0u:
				{
					int num4;
					if (num3 < 4)
					{
						num = 1106188736;
						num4 = 1106188736;
					}
					else
					{
						num = 1203825646;
						num4 = 1203825646;
					}
					continue;
				}
				default:
					return;
				case 22u:
					break;
				case 6u:
					return;
				}
				break;
			}
		}
	}

	private void Paint_Board()
	{
		Form1.smethod_20(pictureBox1, (Image)(object)Form1.smethod_19(Form1.smethod_18((Control)(object)pictureBox1), Form1.smethod_16((Control)(object)pictureBox1)));
		bool big = default(bool);
		float num6 = default(float);
		float num7 = default(float);
		float num8 = default(float);
		bool flag = default(bool);
		int num3 = default(int);
		int num13 = default(int);
		float num12 = default(float);
		float num11 = default(float);
		bool point = default(bool);
		Brush brush_ = default(Brush);
		Graphics graphics_ = default(Graphics);
		bool dark = default(bool);
		bool flag2 = default(bool);
		while (true)
		{
			int num = 1916330395;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3FD8285Bu) % 38u)
				{
				case 37u:
				{
					int num18;
					int num19;
					if (!big)
					{
						num18 = 735435814;
						num19 = 735435814;
					}
					else
					{
						num18 = 449771601;
						num19 = 449771601;
					}
					num = num18 ^ (int)(num2 * 113827099);
					continue;
				}
				case 36u:
					num6 = 0.7f;
					num = 53649986;
					continue;
				case 35u:
					num7 = 1f - num6 * 0.4f / (float)Form1.smethod_27(2.0);
					num8 = (float)size * (num7 / 2f);
					num = 2140308153;
					continue;
				case 34u:
					flag = num3 < 4;
					num = 771592939;
					continue;
				case 33u:
					num = 1778791277;
					continue;
				case 32u:
				{
					int num20;
					if (num13 < 4)
					{
						num = 223069887;
						num20 = 223069887;
					}
					else
					{
						num = 1060459900;
						num20 = 1060459900;
					}
					continue;
				}
				case 31u:
					Form1.smethod_30((Control)(object)pictureBox1);
					num = (int)(num2 * 1845125078) ^ -465054960;
					continue;
				case 30u:
					num13++;
					num = ((int)num2 * -515645467) ^ -806691999;
					continue;
				case 29u:
					num8 = (float)size * (num7 / 2f);
					num = ((int)num2 * -919619127) ^ 0x7B76B544;
					continue;
				case 28u:
					num12 = num11 * 0.4f / (float)Form1.smethod_27(2.0);
					point = board[num13, num3].Point;
					num = (int)((num2 * 327742801) ^ 0x5FE5371A);
					continue;
				case 27u:
					brush_ = Form1.smethod_26();
					num = 791669528;
					continue;
				case 26u:
					Form1.smethod_24(graphics_, Form1.smethod_23(), ((float)num3 + 0.05f) * (float)size, ((float)num13 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					num = ((int)num2 * -425412765) ^ -1838485223;
					continue;
				case 24u:
				{
					int num21;
					int num22;
					if (!board[num13, num3].Square)
					{
						num21 = 353956249;
						num22 = 353956249;
					}
					else
					{
						num21 = 1768266590;
						num22 = 1768266590;
					}
					num = num21 ^ (int)(num2 * 414272812);
					continue;
				}
				case 23u:
					num = ((int)num2 * -464081994) ^ -1241987214;
					continue;
				case 22u:
					dark = board[num13, num3].Dark;
					num = (int)(num2 * 695066262) ^ -1703674038;
					continue;
				case 21u:
					Form1.smethod_28(graphics_, brush_, num8 + (float)(num3 * size), num8 + (float)(num13 * size), num12, num12);
					num = ((int)num2 * -408965173) ^ 0x66534CC0;
					continue;
				case 20u:
					num12 = num11 * 0.9f / (float)Form1.smethod_27(2.0);
					num = ((int)num2 * -252144959) ^ 0x48BC599;
					continue;
				case 18u:
					Form1.smethod_24(graphics_, brush_, num8 + (float)(num3 * size), num8 + (float)(num13 * size), num12, num12);
					num = 893644284;
					continue;
				case 17u:
					brush_ = Form1.smethod_25();
					num = ((int)num2 * -1867553733) ^ -1567369845;
					continue;
				case 16u:
					num3 = 0;
					num = 764691953;
					continue;
				case 15u:
					big = board[num13, num3].Big;
					num = 1145410712;
					continue;
				case 14u:
				{
					int num16;
					int num17;
					if (!flag)
					{
						num16 = 991570341;
						num17 = 991570341;
					}
					else
					{
						num16 = 329738498;
						num17 = 329738498;
					}
					num = num16 ^ ((int)num2 * -889317691);
					continue;
				}
				case 13u:
					num11 = (float)size * num6;
					num = ((int)num2 * -1414741538) ^ -10485772;
					continue;
				case 12u:
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox1));
					num13 = 0;
					num = (int)((num2 * 1496676843) ^ 0x6B383127);
					continue;
				case 11u:
					num = ((int)num2 * -577960532) ^ 0x48B94588;
					continue;
				case 10u:
					flag2 = board[num13, num3] != null;
					num = (int)((num2 * 812154119) ^ 0x785D5DB3);
					continue;
				case 9u:
					num6 = 1f;
					num = ((int)num2 * -1582378428) ^ -2072483474;
					continue;
				case 8u:
					num = ((int)num2 * -928731152) ^ -1770073860;
					continue;
				case 7u:
					num7 = 1f - num6 * 0.9f / (float)Form1.smethod_27(2.0);
					num = 562887842;
					continue;
				case 6u:
					Form1.smethod_24(graphics_, (Brush)(object)Form1.smethod_29(Color.FromArgb(180, Color.Peru)), num8 + (float)(num3 * size), num8 + (float)(num13 * size), num12, num12);
					num = (int)(num2 * 236629541) ^ -1551375938;
					continue;
				case 5u:
				{
					int num14;
					int num15;
					if (dark)
					{
						num14 = -2018498118;
						num15 = -2018498118;
					}
					else
					{
						num14 = -534279538;
						num15 = -534279538;
					}
					num = num14 ^ (int)(num2 * 1376298860);
					continue;
				}
				case 4u:
					num = ((int)num2 * -780416669) ^ -1740958011;
					continue;
				case 3u:
					num = 895956629;
					continue;
				case 2u:
				{
					int num9;
					int num10;
					if (!flag2)
					{
						num9 = -522749075;
						num10 = -522749075;
					}
					else
					{
						num9 = -1410888949;
						num10 = -1410888949;
					}
					num = num9 ^ ((int)num2 * -1183071185);
					continue;
				}
				case 1u:
				{
					int num4;
					int num5;
					if (point)
					{
						num4 = -1640027047;
						num5 = -1640027047;
					}
					else
					{
						num4 = -112355892;
						num5 = -112355892;
					}
					num = num4 ^ (int)(num2 * 1308250554);
					continue;
				}
				case 0u:
					num3++;
					num = 141423739;
					continue;
				default:
					return;
				case 19u:
					break;
				case 25u:
					return;
				}
				break;
			}
		}
	}

	private void Paint_Storage()
	{
		Graphics graphics_ = default(Graphics);
		float num9 = default(float);
		float num10 = default(float);
		int num3 = default(int);
		int num4 = default(int);
		Brush brush_ = default(Brush);
		float num13 = default(float);
		float num16 = default(float);
		float num14 = default(float);
		bool dark = default(bool);
		bool flag = default(bool);
		while (true)
		{
			int num = 1714337014;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x4058025Du) % 33u)
				{
				case 32u:
					num = ((int)num2 * -1288847657) ^ 0x76FDCE98;
					continue;
				case 31u:
					Form1.smethod_24(graphics_, (Brush)(object)Form1.smethod_29(Color.FromArgb(180, Color.Peru)), num9, num9, num10, num10);
					num = ((int)num2 * -1791683031) ^ -684025808;
					continue;
				case 30u:
				{
					int num7;
					int num8;
					if (!storage[num3, num4].Point)
					{
						num7 = -927786121;
						num8 = -927786121;
					}
					else
					{
						num7 = -1037508608;
						num8 = -1037508608;
					}
					num = num7 ^ ((int)num2 * -924910688);
					continue;
				}
				case 29u:
					num = (int)(num2 * 1429223199) ^ -303089789;
					continue;
				case 28u:
					Form1.smethod_24(graphics_, brush_, num9, num9, num10, num10);
					num = 1124659210;
					continue;
				case 27u:
					num13 = 0.7f;
					num = 230859342;
					continue;
				case 26u:
					num16 = 1f - num13 * 0.9f / (float)Form1.smethod_27(2.0);
					num = 182785418;
					continue;
				case 25u:
					num3++;
					num = ((int)num2 * -245921166) ^ -1769907485;
					continue;
				case 24u:
					num13 = 1f;
					num = ((int)num2 * -1715540795) ^ -462070530;
					continue;
				case 23u:
					Form1.smethod_20(pictureBox[num3, num4], (Image)(object)Form1.smethod_19(Form1.smethod_18((Control)(object)pictureBox[num3, num4]), Form1.smethod_16((Control)(object)pictureBox[num3, num4])));
					num = ((int)num2 * -1338893550) ^ 0x7BA8E569;
					continue;
				case 22u:
					brush_ = Form1.smethod_25();
					num = ((int)num2 * -423180231) ^ 0x705EA304;
					continue;
				case 21u:
					num4 = 0;
					num = 556145911;
					continue;
				case 20u:
				{
					num9 = (float)size * (num16 / 2f) - 4f;
					num10 = num14 * 0.9f / (float)Form1.smethod_27(2.0);
					int num19;
					int num20;
					if (num4 < 2)
					{
						num19 = -2047237519;
						num20 = -2047237519;
					}
					else
					{
						num19 = -503793516;
						num20 = -503793516;
					}
					num = num19 ^ (int)(num2 * 605614221);
					continue;
				}
				case 19u:
					num16 = 1f - num13 * 0.4f / (float)Form1.smethod_27(2.0);
					num9 = (float)size * (num16 / 2f) - 4f;
					num10 = num14 * 0.4f / (float)Form1.smethod_27(2.0);
					num = 444407592;
					continue;
				case 18u:
					num = (int)(num2 * 283989261) ^ -893794273;
					continue;
				case 17u:
					Form1.smethod_28(graphics_, brush_, num9, num9, num10, num10);
					num = ((int)num2 * -1295198745) ^ 0x3459D6D6;
					continue;
				case 16u:
				{
					int num17;
					int num18;
					if (dark)
					{
						num17 = 593841821;
						num18 = 593841821;
					}
					else
					{
						num17 = 1143503062;
						num18 = 1143503062;
					}
					num = num17 ^ ((int)num2 * -1672708481);
					continue;
				}
				case 15u:
					dark = storage[num3, num4].Dark;
					num = ((int)num2 * -713833247) ^ 0x16C38539;
					continue;
				case 14u:
				{
					int num15;
					if (!storage[num3, num4].Big)
					{
						num = 316494412;
						num15 = 316494412;
					}
					else
					{
						num = 1707494573;
						num15 = 1707494573;
					}
					continue;
				}
				case 13u:
					brush_ = Form1.smethod_26();
					num = 656240905;
					continue;
				case 12u:
					num14 = (float)size * num13;
					num = (int)(num2 * 1014083930) ^ -624241696;
					continue;
				case 11u:
					num3 = 0;
					num = ((int)num2 * -1841474160) ^ 0x4BDCC4D5;
					continue;
				case 10u:
					flag = num4 < 4;
					num = 1478087451;
					continue;
				case 9u:
					num = ((int)num2 * -64262989) ^ -1127006180;
					continue;
				case 8u:
				{
					int num12;
					if (storage[num3, num4] == null)
					{
						num = 2015509865;
						num12 = 2015509865;
					}
					else
					{
						num = 2059563987;
						num12 = 2059563987;
					}
					continue;
				}
				case 7u:
				{
					int num11;
					if (num3 < 4)
					{
						num = 677042476;
						num11 = 677042476;
					}
					else
					{
						num = 324775301;
						num11 = 324775301;
					}
					continue;
				}
				case 5u:
				{
					int num5;
					int num6;
					if (!flag)
					{
						num5 = 158749653;
						num6 = 158749653;
					}
					else
					{
						num5 = 1740185479;
						num6 = 1740185479;
					}
					num = num5 ^ ((int)num2 * -15588662);
					continue;
				}
				case 4u:
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox[num3, num4]));
					num = (int)((num2 * 553358563) ^ 0x21FFF98A);
					continue;
				case 2u:
					num4++;
					num = 1652451522;
					continue;
				case 1u:
					Form1.smethod_30((Control)(object)pictureBox[num3, num4]);
					num = 1215553080;
					continue;
				case 0u:
					num = ((int)num2 * -1472523778) ^ 0x604C5C5F;
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

	public void StartGame()
	{
		int num3 = default(int);
		int num7 = default(int);
		int num5 = default(int);
		bool flag = default(bool);
		int num6 = default(int);
		while (true)
		{
			int num = -600079021;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9334586Bu) % 28u)
				{
				case 27u:
					Form1.smethod_32((Control)(object)richTextBox1, "Ваш ход. Выберете фигуру, которой будет играть противник.");
					num = (int)((num2 * 25778688) ^ 0x343A8594);
					continue;
				case 26u:
					num3++;
					num = ((int)num2 * -1904715969) ^ -777852237;
					continue;
				case 25u:
					num = (int)(num2 * 2044793809) ^ -2036742503;
					continue;
				case 24u:
					num7 = Form1.smethod_33(rnd, 4);
					num = ((int)num2 * -1526364141) ^ 0x27F8E75;
					continue;
				case 23u:
					num = ((int)num2 * -304648644) ^ -1250193430;
					continue;
				case 22u:
					num = (int)(num2 * 164989516) ^ -1946711766;
					continue;
				case 20u:
					Form1_Load(this, Form1.smethod_31());
					num = (int)(num2 * 1359186508) ^ -1700407668;
					continue;
				case 19u:
					Form1.smethod_32((Control)(object)label2, Form1.smethod_34("Ход: ", step.ToString()));
					num = -1676637392;
					continue;
				case 18u:
					step = 0;
					num = (int)(num2 * 705533689) ^ -1814950350;
					continue;
				case 17u:
					num3 = 0;
					num = (int)((num2 * 1206042789) ^ 0x3A312A32);
					continue;
				case 16u:
					num = ((int)num2 * -1065833780) ^ -1922944547;
					continue;
				case 15u:
					Form1.smethod_7((Control)(object)pictureBox[num3, num5], bool_0: true);
					num = -158178950;
					continue;
				case 14u:
					flag = num5 < 4;
					num = -1089965001;
					continue;
				case 13u:
					num5++;
					num = (int)(num2 * 399135581) ^ -900574488;
					continue;
				case 12u:
				{
					int num10;
					int num11;
					if (flag)
					{
						num10 = 1297283152;
						num11 = 1297283152;
					}
					else
					{
						num10 = 156910337;
						num11 = 156910337;
					}
					num = num10 ^ ((int)num2 * -404446834);
					continue;
				}
				case 11u:
				{
					int num8;
					int num9;
					if (!turn)
					{
						num8 = -1921497169;
						num9 = -1921497169;
					}
					else
					{
						num8 = -1566793176;
						num9 = -1566793176;
					}
					num = num8 ^ (int)(num2 * 1327229019);
					continue;
				}
				case 10u:
					Form1.smethod_35(timer1, bool_0: true);
					num = ((int)num2 * -1900686251) ^ 0x5DF46E3D;
					continue;
				case 8u:
					Form1.smethod_36(timer1);
					num = (int)((num2 * 353375657) ^ 0x52A9170A);
					continue;
				case 7u:
					time = new DateTime(0L, DateTimeKind.Unspecified);
					num = ((int)num2 * -201619409) ^ 0x4C40A00;
					continue;
				case 6u:
					Form1.smethod_5((Control)(object)borderBox[num6, num7], Color.Blue);
					num = ((int)num2 * -420846946) ^ 0x38607283;
					continue;
				case 5u:
					num6 = Form1.smethod_33(rnd, 4);
					num = -572369597;
					continue;
				case 4u:
					num5 = 0;
					num = -1440781115;
					continue;
				case 3u:
					num = ((int)num2 * -167811175) ^ -1132933510;
					continue;
				case 2u:
				{
					int num4;
					if (num3 >= 4)
					{
						num = -1888165376;
						num4 = -1888165376;
					}
					else
					{
						num = -1296346233;
						num4 = -1296346233;
					}
					continue;
				}
				case 1u:
					Form1.smethod_32((Control)(object)richTextBox1, "Противник выбрал фигуру. Выберете поле на доске для установки этой фигуры.");
					step = 1;
					num = ((int)num2 * -2041347834) ^ 0x4EE670D2;
					continue;
				case 0u:
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: true);
					num = ((int)num2 * -447929634) ^ 0x1C8AE6;
					continue;
				default:
					return;
				case 21u:
					break;
				case 9u:
					return;
				}
				break;
			}
		}
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
		time = time.AddSeconds(1.0);
		Form1.smethod_32((Control)(object)label1, Form1.smethod_34("Время: ", time.ToString("HH:mm:ss")));
	}

	private void PictureBoxIJ_MouseDown(object sender, MouseEventArgs e)
	{
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Expected O, but got Unknown
		Point point = Form1.smethod_37((Control)((sender is PictureBox) ? sender : null));
		int num = point.Y / size;
		int num6 = default(int);
		int num5 = default(int);
		int num4 = default(int);
		while (true)
		{
			int num2 = -327605486;
			while (true)
			{
				uint num3;
				int num7;
				switch ((num3 = (uint)num2 ^ 0xCE88484Cu) % 23u)
				{
				case 22u:
					num6++;
					num2 = ((int)num3 * -364150319) ^ -1626543893;
					continue;
				case 21u:
					num2 = ((int)num3 * -110965659) ^ 0x400A598D;
					continue;
				case 20u:
					num2 = (int)((num3 * 757717426) ^ 0x308139C6);
					continue;
				case 18u:
				{
					int num10;
					if (num6 < 4)
					{
						num2 = -1175674476;
						num10 = -1175674476;
					}
					else
					{
						num2 = -1446985018;
						num10 = -1446985018;
					}
					continue;
				}
				case 17u:
					num5 -= 4;
					num2 = (int)((num3 * 2064513037) ^ 0x337B187C);
					continue;
				case 16u:
				{
					int num11;
					if (num4 >= 4)
					{
						num2 = -2136177645;
						num11 = -2136177645;
					}
					else
					{
						num2 = -2017147771;
						num11 = -2017147771;
					}
					continue;
				}
				case 15u:
					num2 = (int)(num3 * 1097375759) ^ -982504168;
					continue;
				case 14u:
					Form1.smethod_5((Control)(object)borderBox[num4, num6], Color.White);
					num2 = -2012760948;
					continue;
				case 13u:
				{
					num5 = point.X / size;
					int num8;
					int num9;
					if (num5 > 1)
					{
						num8 = 1440604936;
						num9 = 1440604936;
					}
					else
					{
						num8 = 1487097728;
						num9 = 1487097728;
					}
					num2 = num8 ^ (int)(num3 * 263172309);
					continue;
				}
				case 12u:
					if (Form1.smethod_40((Bitmap)Form1.smethod_21(pictureBox[num, num5]), Form1.smethod_38(e), Form1.smethod_39(e)) != Color.FromArgb(0, 0, 0, 0))
					{
						num2 = -1051710249;
						num7 = -1051710249;
						continue;
					}
					goto IL_0164;
				case 11u:
					if (storage[num, num5] != null)
					{
						num2 = -274819946;
						continue;
					}
					goto IL_0164;
				case 10u:
					num6 = 0;
					num2 = -1461244173;
					continue;
				case 9u:
					Form1.smethod_5((Control)(object)borderBox[num, num5], Color.Red);
					num2 = (int)((num3 * 913563100) ^ 0x66B38AF);
					continue;
				case 8u:
					num2 = ((int)num3 * -1191845650) ^ -799367084;
					continue;
				case 7u:
					num4 = 0;
					num2 = ((int)num3 * -929791711) ^ -826612181;
					continue;
				case 6u:
					point = Form1.smethod_37((Control)((sender is PictureBox) ? sender : null));
					num2 = (int)(num3 * 754893376) ^ -99933678;
					continue;
				case 5u:
					num2 = (int)(num3 * 1121872675) ^ -2013222204;
					continue;
				case 4u:
					num2 = (int)(num3 * 1142792274) ^ -219035776;
					continue;
				case 3u:
					Form1.smethod_32((Control)(object)richTextBox1, "Именно эта фигура? Если да - нажмите \"Подтвердить\".");
					num2 = ((int)num3 * -281557083) ^ -685452407;
					continue;
				case 2u:
					num4++;
					num2 = (int)(num3 * 175998060) ^ -1563893142;
					continue;
				case 0u:
					Form1.smethod_7((Control)(object)button2, bool_0: true);
					num2 = ((int)num3 * -327128523) ^ -1402568482;
					continue;
				default:
					return;
				case 19u:
					break;
				case 1u:
					return;
					IL_0164:
					num2 = -64319126;
					num7 = -64319126;
					continue;
				}
				break;
			}
		}
	}

	private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
	{
		//IL_028a: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a0: Expected O, but got Unknown
		int num = Form1.smethod_38(e) / size;
		int num7 = default(int);
		bool flag = default(bool);
		int num4 = default(int);
		Graphics graphics_ = default(Graphics);
		int num5 = default(int);
		bool flag2 = default(bool);
		while (true)
		{
			int num2 = -947444268;
			while (true)
			{
				uint num3;
				int num6;
				switch ((num3 = (uint)num2 ^ 0x9A0359C7u) % 25u)
				{
				case 24u:
					num7 = 0;
					num2 = ((int)num3 * -1998304197) ^ 0x12EBE2DC;
					continue;
				case 23u:
					num2 = ((int)num3 * -635449997) ^ -203408102;
					continue;
				case 22u:
				{
					int num12;
					int num13;
					if (flag)
					{
						num12 = 1082735241;
						num13 = 1082735241;
					}
					else
					{
						num12 = 1328755166;
						num13 = 1328755166;
					}
					num2 = num12 ^ ((int)num3 * -820460513);
					continue;
				}
				case 21u:
					num2 = (int)((num3 * 1855796904) ^ 0x11EFFC36);
					continue;
				case 20u:
					Form1.smethod_32((Control)(object)richTextBox1, "Уверены? Для выполнения данного хода нажмите \"Подтвердить\".");
					num2 = (int)(num3 * 147214926) ^ -1358020649;
					continue;
				case 19u:
				{
					int num8;
					if (Form1.smethod_41((Control)(object)borderBox[num7, num4]) == Color.Blue)
					{
						num2 = -699069550;
						num8 = -699069550;
					}
					else
					{
						num2 = -1796897814;
						num8 = -1796897814;
					}
					continue;
				}
				case 18u:
					num2 = ((int)num3 * -342589496) ^ -24175867;
					continue;
				case 16u:
					Form1.smethod_44(graphics_, Form1.smethod_21(pictureBox[num7, num4]), num * size + 4, num5 * size + 4, new Rectangle(0, 0, size, size), (GraphicsUnit)2);
					num2 = (int)(num3 * 536220546) ^ -530888944;
					continue;
				case 15u:
				{
					int num11;
					if (num4 >= 4)
					{
						num2 = -1596292147;
						num11 = -1596292147;
					}
					else
					{
						num2 = -1165737509;
						num11 = -1165737509;
					}
					continue;
				}
				case 14u:
					Paint_Board();
					num2 = ((int)num3 * -1772683513) ^ 0x3015877;
					continue;
				case 13u:
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox1));
					num2 = ((int)num3 * -774510465) ^ -1823693714;
					continue;
				case 12u:
					flag2 = num7 < 4;
					num2 = -875416302;
					continue;
				case 11u:
					Form1.smethod_43(graphics_, Form1.smethod_42(Color.Red, 3f), ((float)num + 0.05f) * (float)size, ((float)num5 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					num2 = (int)((num3 * 843944537) ^ 0x4FA6779F);
					continue;
				case 10u:
					Form1.smethod_7((Control)(object)button2, bool_0: true);
					num2 = (int)(num3 * 978879703) ^ -1282510397;
					continue;
				case 8u:
					num7++;
					num2 = ((int)num3 * -413958697) ^ 0x1A2B66D9;
					continue;
				case 7u:
					num4++;
					num2 = -7430723;
					continue;
				case 6u:
				{
					int num9;
					int num10;
					if (!flag2)
					{
						num9 = 741708206;
						num10 = 741708206;
					}
					else
					{
						num9 = 932215468;
						num10 = 932215468;
					}
					num2 = num9 ^ ((int)num3 * -1398411433);
					continue;
				}
				case 5u:
					if (Form1.smethod_40((Bitmap)Form1.smethod_21(pictureBox1), Form1.smethod_38(e), Form1.smethod_39(e)) != Color.FromArgb(0, 0, 0, 0))
					{
						num2 = (int)((num3 * 1996253500) ^ 0x7765A373);
						continue;
					}
					num6 = 0;
					goto IL_02c1;
				case 4u:
					Form1.smethod_45(graphics_);
					Form1.smethod_30((Control)(object)pictureBox1);
					num2 = ((int)num3 * -832067831) ^ 0x396861C3;
					continue;
				case 3u:
					num5 = Form1.smethod_39(e) / size;
					num2 = ((int)num3 * -758768187) ^ 0x581D5860;
					continue;
				case 2u:
					num2 = ((int)num3 * -1236350430) ^ -804641321;
					continue;
				case 1u:
					num6 = ((board[num5, num] == null) ? 1 : 0);
					goto IL_02c1;
				case 0u:
					num4 = 0;
					num2 = -7430723;
					continue;
				default:
					return;
				case 9u:
					break;
				case 17u:
					return;
					IL_02c1:
					flag = (byte)num6 != 0;
					num2 = -1428220086;
					continue;
				}
				break;
			}
		}
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		//IL_0cb5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ce3: Expected O, but got Unknown
		int num26 = default(int);
		int num25 = default(int);
		int num11 = default(int);
		int num4 = default(int);
		int num13 = default(int);
		int num31 = default(int);
		int num44 = default(int);
		bool flag12 = default(bool);
		int num23 = default(int);
		Figurine[,] array = default(Figurine[,]);
		int num22 = default(int);
		bool flag13 = default(bool);
		bool flag7 = default(bool);
		int num3 = default(int);
		int num14 = default(int);
		int num15 = default(int);
		bool flag10 = default(bool);
		int num7 = default(int);
		int num8 = default(int);
		bool flag9 = default(bool);
		Figurine[,] array2 = default(Figurine[,]);
		int num27 = default(int);
		bool flag5 = default(bool);
		int num9 = default(int);
		int num10 = default(int);
		bool flag3 = default(bool);
		Graphics graphics_ = default(Graphics);
		bool flag11 = default(bool);
		int num24 = default(int);
		int num32 = default(int);
		bool flag8 = default(bool);
		bool flag2 = default(bool);
		bool flag4 = default(bool);
		bool flag6 = default(bool);
		int num18 = default(int);
		int num17 = default(int);
		bool flag = default(bool);
		while (true)
		{
			int num = -1192714650;
			while (true)
			{
				uint num2;
				int num12;
				int num37;
				int num30;
				int num43;
				switch ((num2 = (uint)num ^ 0xC10BF7D1u) % 166u)
				{
				case 165u:
					num = (int)((num2 * 2142619366) ^ 0x51B1E73);
					continue;
				case 164u:
					board[num26, num25] = new Figurine(storage[num11, num4]);
					num = (int)(num2 * 71572373) ^ -15122728;
					continue;
				case 163u:
					num13 = 0;
					num = ((int)num2 * -586165755) ^ -761795930;
					continue;
				case 162u:
				{
					int num60;
					int num61;
					if (board[num26, num25] == null)
					{
						num60 = 136145481;
						num61 = 136145481;
					}
					else
					{
						num60 = 479159511;
						num61 = 479159511;
					}
					num = num60 ^ (int)(num2 * 95711856);
					continue;
				}
				case 161u:
					Form1.smethod_7((Control)(object)pictureBox[num31, num44], bool_0: true);
					num = -1429468440;
					continue;
				case 160u:
					num = -1517641823;
					continue;
				case 159u:
					num = (int)(num2 * 1404130637) ^ -622179636;
					continue;
				case 158u:
					num = (int)((num2 * 1681625019) ^ 0x59367A46);
					continue;
				case 157u:
					Form1.smethod_47(200);
					num = (int)(num2 * 2106793079) ^ -1751254459;
					continue;
				case 156u:
					flag12 = num44 < 4;
					num = -281059488;
					continue;
				case 155u:
					num = ((int)num2 * -512996448) ^ 0x30B3D037;
					continue;
				case 154u:
					num23 = 0;
					num = ((int)num2 * -1081661227) ^ -1011553706;
					continue;
				case 153u:
					num12 = (Standoff(array) ? 1 : 0);
					goto IL_014c;
				case 152u:
					num44++;
					num = (int)(num2 * 979990497) ^ -2056208987;
					continue;
				case 151u:
					num22++;
					num = ((int)num2 * -1639334781) ^ -1009309355;
					continue;
				case 150u:
					num = (int)(num2 * 126820965) ^ -286649508;
					continue;
				case 149u:
					Form1.smethod_20(pictureBox[num11, num4], (Image)null);
					Form1.smethod_30((Control)(object)pictureBox[num11, num4]);
					num = (int)((num2 * 722219402) ^ 0x71160DE1);
					continue;
				case 148u:
				{
					int num64;
					int num65;
					if (!Form1.smethod_46((Control)(object)pictureBox1))
					{
						num64 = -85479425;
						num65 = -85479425;
					}
					else
					{
						num64 = -1098006372;
						num65 = -1098006372;
					}
					num = num64 ^ (int)(num2 * 1315865147);
					continue;
				}
				case 147u:
				{
					int num58;
					int num59;
					if (!flag13)
					{
						num58 = 1517718936;
						num59 = 1517718936;
					}
					else
					{
						num58 = 670938079;
						num59 = 670938079;
					}
					num = num58 ^ ((int)num2 * -1963034554);
					continue;
				}
				case 146u:
					num = (int)((num2 * 1154001185) ^ 0x49BBB31C);
					continue;
				case 145u:
				{
					int num54;
					int num55;
					if (!flag7)
					{
						num54 = -328818894;
						num55 = -328818894;
					}
					else
					{
						num54 = -1210101878;
						num55 = -1210101878;
					}
					num = num54 ^ ((int)num2 * -1736364386);
					continue;
				}
				case 144u:
					num3 = 0;
					num = -1304462837;
					continue;
				case 143u:
					Form1.smethod_20(pictureBox[num13, num14], (Image)null);
					num = (int)(num2 * 1960627369) ^ -638243800;
					continue;
				case 142u:
					num11 = num15;
					num = ((int)num2 * -1421325189) ^ -171126859;
					continue;
				case 141u:
				{
					int num48;
					int num49;
					if (!flag10)
					{
						num48 = -165763210;
						num49 = -165763210;
					}
					else
					{
						num48 = -1009812777;
						num49 = -1009812777;
					}
					num = num48 ^ (int)(num2 * 496874792);
					continue;
				}
				case 140u:
					num = (int)((num2 * 342717284) ^ 0x373B0E60);
					continue;
				case 139u:
					Form1.smethod_30((Control)(object)borderBox[num7, num8]);
					Form1.smethod_32((Control)(object)richTextBox1, "Противник сделал ход (зелёный). Выберете поле на доске для выбронной противником фигуры (синий).");
					num = (int)((num2 * 886303112) ^ 0x7CE17972);
					continue;
				case 138u:
					flag9 = true;
					num = ((int)num2 * -1356607515) ^ 0x11E07935;
					continue;
				case 137u:
				{
					Figurine[,] array3 = (Figurine[,])Form1.smethod_48((Array)array2);
					array3[num22, num27] = new Figurine(storage[num7, num8]);
					int num40;
					int num41;
					if (!Stop(array3))
					{
						num40 = -1031539592;
						num41 = -1031539592;
					}
					else
					{
						num40 = -1577890772;
						num41 = -1577890772;
					}
					num = num40 ^ ((int)num2 * -329296295);
					continue;
				}
				case 136u:
					num = (int)(num2 * 1939425925) ^ -284700224;
					continue;
				case 135u:
					if (!flag9)
					{
						num = ((int)num2 * -1692621467) ^ -605205613;
						continue;
					}
					num37 = 1;
					goto IL_03cc;
				case 134u:
					num31 = 0;
					num = ((int)num2 * -183637513) ^ 0x4D6ECEF2;
					continue;
				case 133u:
					Form1.smethod_5((Control)(object)borderBox[num7, num8], Color.Blue);
					num = (int)((num2 * 1164074854) ^ 0x3ACB6598);
					continue;
				case 132u:
					flag7 = array2[num22, num27] == null;
					num = -2119797328;
					continue;
				case 131u:
					flag5 = num27 < 4;
					num = -148185866;
					continue;
				case 130u:
					Form1.smethod_15(timer1);
					num = ((int)num2 * -306525420) ^ -38566302;
					continue;
				case 129u:
					board[num9, num10] = new Figurine(storage[num11, num4]);
					storage[num11, num4] = null;
					num = ((int)num2 * -977117582) ^ -567535123;
					continue;
				case 128u:
				{
					int num20;
					int num21;
					if (!flag3)
					{
						num20 = 1218424889;
						num21 = 1218424889;
					}
					else
					{
						num20 = 1849289131;
						num21 = 1849289131;
					}
					num = num20 ^ ((int)num2 * -1863287702);
					continue;
				}
				case 127u:
					num = ((int)num2 * -538963769) ^ -2062244880;
					continue;
				case 126u:
					num10 = 0;
					num = -2000251411;
					continue;
				case 125u:
					Form1.smethod_30((Control)(object)pictureBox1);
					num = ((int)num2 * -1357397279) ^ 0x21968504;
					continue;
				case 124u:
					Form1.smethod_30((Control)(object)borderBox[num13, num14]);
					num = ((int)num2 * -1736851554) ^ -1141083490;
					continue;
				case 123u:
					storage[num11, num4] = null;
					num = (int)(num2 * 1288678781) ^ -525565879;
					continue;
				case 122u:
					num7 = Form1.smethod_33(rnd, 4);
					num8 = Form1.smethod_33(rnd, 4);
					num = (int)((num2 * 1074764599) ^ 0x1ED87A9C);
					continue;
				case 121u:
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox1));
					num = (int)(num2 * 1935155798) ^ -1512131248;
					continue;
				case 120u:
					num = -57890080;
					continue;
				case 119u:
					num = (int)((num2 * 1837034672) ^ 0x4694DCC7);
					continue;
				case 118u:
					flag11 = Standoff(board);
					num = (int)(num2 * 75817599) ^ -575565937;
					continue;
				case 117u:
					num24 = 0;
					num = (int)((num2 * 165499729) ^ 0x6E22E035);
					continue;
				case 116u:
					num14 = 0;
					num = -1845761088;
					continue;
				case 114u:
					num = -1241204692;
					continue;
				case 113u:
					Form1.smethod_43(graphics_, Form1.smethod_42(Color.LimeGreen, 3f), ((float)num10 + 0.05f) * (float)size, ((float)num9 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					num = ((int)num2 * -508928958) ^ -190292102;
					continue;
				case 112u:
					num32++;
					num = -775903448;
					continue;
				case 111u:
					num = (int)((num2 * 1828506211) ^ 0x2242F9F9);
					continue;
				case 110u:
				{
					int num62;
					int num63;
					if (!flag8)
					{
						num62 = -175740522;
						num63 = -175740522;
					}
					else
					{
						num62 = -946146061;
						num63 = -946146061;
					}
					num = num62 ^ (int)(num2 * 1601545005);
					continue;
				}
				case 109u:
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: true);
					num = (int)(num2 * 1498212024) ^ -1575896360;
					continue;
				case 108u:
					num23 = num14;
					num = ((int)num2 * -605688495) ^ 0x59BFAE4D;
					continue;
				case 107u:
					num = (int)(num2 * 700817553) ^ -938445860;
					continue;
				case 106u:
					Form1.smethod_44(graphics_, Form1.smethod_21(pictureBox[num11, num4]), num10 * size + 4, num9 * size + 4, new Rectangle(0, 0, size, size), (GraphicsUnit)2);
					num = (int)(num2 * 1863001127) ^ -1789129912;
					continue;
				case 105u:
					num = (int)(num2 * 1564392504) ^ -805660273;
					continue;
				case 104u:
					num27 = 0;
					num = -1650706288;
					continue;
				case 103u:
					flag13 = num9 < 4;
					num = -153258312;
					continue;
				case 102u:
					Form1.smethod_30((Control)(object)pictureBox[num13, num14]);
					num = ((int)num2 * -2090754859) ^ -655953286;
					continue;
				case 101u:
					num10++;
					num = -1378067184;
					continue;
				case 100u:
					if (storage[num7, num8] != null)
					{
						num = (int)(num2 * 804752062) ^ -1498224811;
						continue;
					}
					num30 = 1;
					goto IL_07f7;
				case 99u:
					num3++;
					num = -1304462837;
					continue;
				case 98u:
					Paint_Board();
					if (!Stop(board))
					{
						num = ((int)num2 * -95762987) ^ 0x1757D95E;
						continue;
					}
					goto IL_0849;
				case 97u:
					num = (int)(num2 * 837133672) ^ -1434481749;
					continue;
				case 96u:
					num26 = Form1.smethod_33(rnd, 4);
					num = -903587657;
					continue;
				case 95u:
				{
					int num56;
					int num57;
					if (!flag2)
					{
						num56 = 2015754013;
						num57 = 2015754013;
					}
					else
					{
						num56 = 2107234274;
						num57 = 2107234274;
					}
					num = num56 ^ (int)(num2 * 1033012826);
					continue;
				}
				case 94u:
					Form1.smethod_32((Control)(object)richTextBox1, "Подождите, компьютер делает свой ход.");
					Form1.smethod_30((Control)(object)richTextBox1);
					num = ((int)num2 * -887433128) ^ -2116954102;
					continue;
				case 93u:
					Form1.smethod_5((Control)(object)borderBox[num15, num3], Color.LimeGreen);
					num = (int)((num2 * 265249818) ^ 0x71F30327);
					continue;
				case 92u:
					num24 = num13;
					num = (int)(num2 * 940034397) ^ -436318145;
					continue;
				case 91u:
				{
					int num52;
					int num53;
					if (flag12)
					{
						num52 = 1515411281;
						num53 = 1515411281;
					}
					else
					{
						num52 = 377745908;
						num53 = 377745908;
					}
					num = num52 ^ ((int)num2 * -1993274317);
					continue;
				}
				case 90u:
					Form1.smethod_32((Control)(object)richTextBox1, "Ничья!");
					num = (int)(num2 * 1189209284) ^ -671222189;
					continue;
				case 89u:
					Form1.smethod_47(200);
					num = ((int)num2 * -1422891030) ^ 0x1E696CDB;
					continue;
				case 88u:
					num = ((int)num2 * -1763202736) ^ -18969751;
					continue;
				case 87u:
					num = (int)((num2 * 792147280) ^ 0xF659BEC);
					continue;
				case 86u:
					Form1.smethod_30((Control)(object)borderBox[num11, num4]);
					num = ((int)num2 * -1377219565) ^ -318968660;
					continue;
				case 85u:
					num37 = ((num32 < 9) ? 1 : 0);
					goto IL_03cc;
				case 84u:
					num44 = 0;
					num = -802013574;
					continue;
				case 83u:
					Form1.smethod_30((Control)(object)borderBox[num11, num4]);
					num = ((int)num2 * -656034021) ^ -1542309845;
					continue;
				case 82u:
					Form1.smethod_32((Control)(object)label2, Form1.smethod_34("Ход: ", step.ToString()));
					Form1.smethod_30((Control)(object)label2);
					num = ((int)num2 * -1114621772) ^ -948791155;
					continue;
				case 81u:
				{
					int num51;
					if (num22 < 4)
					{
						num = -1940002013;
						num51 = -1940002013;
					}
					else
					{
						num = -1991358192;
						num51 = -1991358192;
					}
					continue;
				}
				case 80u:
					Form1.smethod_15(timer1);
					num = -354862430;
					continue;
				case 79u:
					num = (int)(num2 * 1281620494) ^ -2115319244;
					continue;
				case 78u:
				{
					int num50;
					if (Form1.smethod_41((Control)(object)borderBox[num13, num14]) == Color.Blue)
					{
						num = -101442895;
						num50 = -101442895;
					}
					else
					{
						num = -1430513831;
						num50 = -1430513831;
					}
					continue;
				}
				case 77u:
					Form1.smethod_43(graphics_, Form1.smethod_42(Color.LimeGreen, 3f), ((float)num25 + 0.05f) * (float)size, ((float)num26 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					num = (int)(num2 * 1597814206) ^ -1212771884;
					continue;
				case 76u:
				{
					int num46;
					int num47;
					if (!flag11)
					{
						num46 = -52600144;
						num47 = -52600144;
					}
					else
					{
						num46 = -1629924941;
						num47 = -1629924941;
					}
					num = num46 ^ (int)(num2 * 1670192486);
					continue;
				}
				case 75u:
				{
					int num45;
					if (num10 < 4)
					{
						num = -2003385804;
						num45 = -2003385804;
					}
					else
					{
						num = -1085472115;
						num45 = -1085472115;
					}
					continue;
				}
				case 74u:
					Form1.smethod_30((Control)(object)pictureBox1);
					num = (int)(num2 * 1335621276) ^ -740210837;
					continue;
				case 72u:
					num13++;
					num = ((int)num2 * -791732013) ^ 0x36283F9F;
					continue;
				case 71u:
					num = (int)((num2 * 92567809) ^ 0x45EDA7F5);
					continue;
				case 70u:
					(menu as Form3).ContinueLock();
					num = ((int)num2 * -2015190684) ^ -836114358;
					continue;
				case 69u:
					num15++;
					num = (int)(num2 * 1068620135) ^ -1939429252;
					continue;
				case 68u:
					num = -1895662868;
					continue;
				case 67u:
					array2 = (Figurine[,])Form1.smethod_48((Array)board);
					num = (int)(num2 * 272403413) ^ -1872896777;
					continue;
				case 66u:
					num9++;
					num = ((int)num2 * -295344076) ^ 0xEAEC9EA;
					continue;
				case 65u:
					(menu as Form3).ContinueLock();
					num = ((int)num2 * -277298303) ^ -959064059;
					continue;
				case 64u:
					Form1.smethod_47(1000);
					num = (int)(num2 * 280768395) ^ -499945807;
					continue;
				case 63u:
					if (!Standoff(board))
					{
						num = -453743498;
						num43 = -453743498;
						continue;
					}
					goto IL_0849;
				case 62u:
				{
					int num42;
					if (!(Form1.smethod_40((Bitmap)Form1.smethod_21(pictureBox1), num14 * size + size / 2, (int)(((float)num13 + 0.05f) * (float)size)) == Color.FromArgb(255, 255, 0, 0)))
					{
						num = -1953173211;
						num42 = -1953173211;
					}
					else
					{
						num = -2072053369;
						num42 = -2072053369;
					}
					continue;
				}
				case 61u:
				{
					int num38;
					int num39;
					if (!flag5)
					{
						num38 = 1013098341;
						num39 = 1013098341;
					}
					else
					{
						num38 = 166912982;
						num39 = 166912982;
					}
					num = num38 ^ ((int)num2 * -2059289013);
					continue;
				}
				case 60u:
					num31++;
					num = ((int)num2 * -850001292) ^ 0xE486D5A;
					continue;
				case 59u:
					flag9 = false;
					num = (int)((num2 * 1772918057) ^ 0x10614676);
					continue;
				case 58u:
					num = (int)(num2 * 715093476) ^ -1985894766;
					continue;
				case 57u:
					num = (int)((num2 * 899504161) ^ 0x75722B4E);
					continue;
				case 56u:
					num = (int)(num2 * 933048248) ^ -2139132331;
					continue;
				case 55u:
					step++;
					Form1.smethod_32((Control)(object)label2, Form1.smethod_34("Ход: ", step.ToString()));
					num = ((int)num2 * -1887291416) ^ 0x551F8112;
					continue;
				case 54u:
					Form1.smethod_5((Control)(object)borderBox[num11, num4], Color.White);
					num = ((int)num2 * -1245587067) ^ 0x7B99A585;
					continue;
				case 53u:
				{
					int num35;
					int num36;
					if (flag4)
					{
						num35 = -1166421360;
						num36 = -1166421360;
					}
					else
					{
						num35 = -1389853024;
						num36 = -1389853024;
					}
					num = num35 ^ ((int)num2 * -1973983977);
					continue;
				}
				case 52u:
					Form1.smethod_5((Control)(object)borderBox[num11, num4], Color.White);
					num = (int)((num2 * 1172455567) ^ 0x353FC170);
					continue;
				case 51u:
					Form1.smethod_32((Control)(object)richTextBox1, "QUARTO! Компьютер выиграл!");
					num = -1833339831;
					continue;
				case 50u:
					num30 = ((num8 == num4) ? 1 : 0);
					goto IL_07f7;
				case 49u:
					flag8 = board[num9, num10] == null;
					num = -937007905;
					continue;
				case 48u:
					num = -87418625;
					continue;
				case 47u:
					Form1.smethod_20(pictureBox[num11, num4], (Image)null);
					Form1.smethod_30((Control)(object)pictureBox[num11, num4]);
					num = ((int)num2 * -201910447) ^ -229693590;
					continue;
				case 46u:
				{
					int num33;
					int num34;
					if (flag6)
					{
						num33 = 574265773;
						num34 = 574265773;
					}
					else
					{
						num33 = 1446385107;
						num34 = 1446385107;
					}
					num = num33 ^ ((int)num2 * -205101209);
					continue;
				}
				case 45u:
					num32 = 0;
					num = ((int)num2 * -421050971) ^ 0x4DF12594;
					continue;
				case 44u:
					step++;
					num = (int)(num2 * 186977324) ^ -6332751;
					continue;
				case 43u:
					num = (int)(num2 * 1185501110) ^ -353220655;
					continue;
				case 42u:
					Form1.smethod_32((Control)(object)richTextBox1, "Ничья!");
					num = ((int)num2 * -1287637546) ^ -1243276062;
					continue;
				case 41u:
					flag3 = num31 < 4;
					num = -31546221;
					continue;
				case 40u:
					if (num7 == num11)
					{
						num = ((int)num2 * -354985717) ^ -1926865991;
						continue;
					}
					num30 = 0;
					goto IL_07f7;
				case 39u:
					num = ((int)num2 * -373954048) ^ 0x364D2163;
					continue;
				case 38u:
				{
					int num29;
					if (num3 >= 4)
					{
						num = -719587752;
						num29 = -719587752;
					}
					else
					{
						num = -1953836909;
						num29 = -1953836909;
					}
					continue;
				}
				case 37u:
					Form1.smethod_5((Control)(object)borderBox[num13, num14], Color.White);
					num = ((int)num2 * -311393819) ^ -1564055106;
					continue;
				case 36u:
					num18 = num13;
					num = (int)(num2 * 164800909) ^ -1705569103;
					continue;
				case 35u:
					num = (int)(num2 * 810532223) ^ -1760442498;
					continue;
				case 34u:
					num4 = 0;
					num = ((int)num2 * -122085348) ^ -13423248;
					continue;
				case 33u:
					array2[num26, num25] = new Figurine(storage[num11, num4]);
					num = (int)((num2 * 476088182) ^ 0x2D000600);
					continue;
				case 32u:
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: false);
					num = ((int)num2 * -810438098) ^ 0x4C0C1874;
					continue;
				case 31u:
					Form1.smethod_30((Control)(object)borderBox[num15, num3]);
					num = ((int)num2 * -1178208547) ^ 0x22F4E292;
					continue;
				case 30u:
					num = ((int)num2 * -1662413900) ^ -1676104207;
					continue;
				case 29u:
					num = (int)((num2 * 1319161238) ^ 0x7F999C87);
					continue;
				case 28u:
					num = ((int)num2 * -1897154543) ^ -2113790493;
					continue;
				case 27u:
					flag4 = num14 < 4;
					num = -1394894728;
					continue;
				case 26u:
					num = ((int)num2 * -49425575) ^ 0x5CCF544C;
					continue;
				case 25u:
					num = (int)(num2 * 153205377) ^ -1500493112;
					continue;
				case 24u:
				{
					int num28;
					if (num13 < 4)
					{
						num = -1043770579;
						num28 = -1043770579;
					}
					else
					{
						num = -648395651;
						num28 = -648395651;
					}
					continue;
				}
				case 23u:
					num27++;
					num = -1650706288;
					continue;
				case 22u:
					num = ((int)num2 * -707438427) ^ 0x103E8966;
					continue;
				case 21u:
					num15 = 0;
					num = (int)((num2 * 1805954541) ^ 0x70307983);
					continue;
				case 20u:
					num17 = num14;
					num = ((int)num2 * -2032203132) ^ 0x763A8D08;
					continue;
				case 19u:
					num11 = 0;
					num = ((int)num2 * -1449713687) ^ 0x3B76E22E;
					continue;
				case 18u:
					Form1.smethod_32((Control)(object)richTextBox1, "Выберете фигуру, которой будет играть противник.");
					num = (int)((num2 * 170069827) ^ 0x490906EC);
					continue;
				case 17u:
					Form1.smethod_44(graphics_, Form1.smethod_21(pictureBox[num11, num4]), num25 * size + 4, num26 * size + 4, new Rectangle(0, 0, size, size), (GraphicsUnit)2);
					num = ((int)num2 * -2018565592) ^ -1512452321;
					continue;
				case 16u:
					num25 = Form1.smethod_33(rnd, 4);
					num = ((int)num2 * -721107989) ^ -2120856177;
					continue;
				case 15u:
					num = (int)((num2 * 776299593) ^ 0x6511AAE1);
					continue;
				case 14u:
					board[num18, num23] = new Figurine(storage[num24, num17]);
					storage[num24, num17] = null;
					num = (int)((num2 * 593852682) ^ 0x433301F9);
					continue;
				case 13u:
					num22 = 0;
					num = ((int)num2 * -1482459851) ^ 0x29D9123D;
					continue;
				case 12u:
				{
					int num19;
					if (num15 < 4)
					{
						num = -1161624513;
						num19 = -1161624513;
					}
					else
					{
						num = -612851091;
						num19 = -612851091;
					}
					continue;
				}
				case 11u:
					num = ((int)num2 * -1075831211) ^ 0xDC13A61;
					continue;
				case 10u:
					num14++;
					num = -569015580;
					continue;
				case 9u:
					Form1.smethod_7((Control)(object)button2, bool_0: false);
					num = (int)((num2 * 1921887802) ^ 0x214FF4A1);
					continue;
				case 8u:
					flag2 = Standoff(board);
					num = -878317778;
					continue;
				case 7u:
					num9 = 0;
					num = ((int)num2 * -352836314) ^ -470007152;
					continue;
				case 6u:
					num = -1158031163;
					continue;
				case 5u:
					num17 = 0;
					num18 = 0;
					num = (int)(num2 * 1697045024) ^ -1433835439;
					continue;
				case 4u:
				{
					Form1.smethod_7((Control)(object)pictureBox[num15, num3], bool_0: false);
					int num16;
					if (Form1.smethod_41((Control)(object)borderBox[num15, num3]) == Color.Red)
					{
						num = -1476509690;
						num16 = -1476509690;
					}
					else
					{
						num = -2036377964;
						num16 = -2036377964;
					}
					continue;
				}
				case 3u:
					array = (Figurine[,])Form1.smethod_48((Array)board);
					array[num9, num10] = new Figurine(storage[num11, num4]);
					if (!Stop(array))
					{
						num = ((int)num2 * -377172829) ^ -1458157129;
						continue;
					}
					num12 = 1;
					goto IL_014c;
				case 2u:
				{
					int num5;
					int num6;
					if (flag)
					{
						num5 = 23780111;
						num6 = 23780111;
					}
					else
					{
						num5 = 1106658692;
						num6 = 1106658692;
					}
					num = num5 ^ (int)(num2 * 836217795);
					continue;
				}
				case 1u:
					num = (int)(num2 * 1613251794) ^ -725309848;
					continue;
				case 0u:
					num4 = num3;
					num = (int)((num2 * 136573050) ^ 0x3845A7B8);
					continue;
				default:
					return;
				case 115u:
					break;
				case 73u:
					return;
					IL_03cc:
					flag10 = (byte)num37 != 0;
					num = -551913386;
					continue;
					IL_014c:
					flag6 = (byte)num12 != 0;
					num = -153547153;
					continue;
					IL_0849:
					num = -1069123415;
					num43 = -1069123415;
					continue;
					IL_07f7:
					flag = (byte)num30 != 0;
					num = -1800725165;
					continue;
				}
				break;
			}
		}
	}

	private bool Stop(Figurine[,] mem)
	{
		int num3 = default(int);
		bool flag = default(bool);
		bool flag2 = default(bool);
		bool result = default(bool);
		bool flag3 = default(bool);
		while (true)
		{
			int num = 875161900;
			while (true)
			{
				uint num2;
				int num5;
				int num4;
				switch ((num2 = (uint)num ^ 0x9C0A462u) % 77u)
				{
				case 76u:
				{
					int num52;
					if (mem[num3, 0].Point != mem[num3, 1].Point)
					{
						num = 479386027;
						num52 = 479386027;
					}
					else
					{
						num = 1191651645;
						num52 = 1191651645;
					}
					continue;
				}
				case 75u:
					if (mem[3, num3] != null)
					{
						num = (int)((num2 * 1584699937) ^ 0x46BBA240);
						continue;
					}
					goto IL_005b;
				case 74u:
				{
					int num14;
					int num15;
					if (mem[1, 1].Big == mem[2, 2].Big)
					{
						num14 = 1186772493;
						num15 = 1186772493;
					}
					else
					{
						num14 = 1887096511;
						num15 = 1887096511;
					}
					num = num14 ^ (int)(num2 * 2096278423);
					continue;
				}
				case 73u:
					if (mem[num3, 2].Big != mem[num3, 3].Big)
					{
						num = (int)(num2 * 1367595278) ^ -1421265022;
						continue;
					}
					goto IL_00d7;
				case 72u:
					if (mem[2, num3].Big != mem[3, num3].Big)
					{
						num = (int)(num2 * 1128994634) ^ -812309441;
						continue;
					}
					goto IL_0109;
				case 71u:
					if (mem[2, 1].Big != mem[3, 0].Big)
					{
						num = (int)((num2 * 762812471) ^ 0x2211F7E2);
						continue;
					}
					goto IL_013e;
				case 70u:
				{
					int num12;
					int num13;
					if (flag)
					{
						num12 = -252710896;
						num13 = -252710896;
					}
					else
					{
						num12 = -402213051;
						num13 = -402213051;
					}
					num = num12 ^ (int)(num2 * 327471957);
					continue;
				}
				case 69u:
					if (mem[1, num3].Square == mem[2, num3].Square)
					{
						num = ((int)num2 * -163641512) ^ 0x7A3B2DCA;
						continue;
					}
					goto IL_01a3;
				case 68u:
					if (mem[num3, 2].Point != mem[num3, 3].Point)
					{
						num = ((int)num2 * -67956213) ^ 0x1FE2D18B;
						continue;
					}
					goto IL_00d7;
				case 67u:
				{
					int num50;
					int num51;
					if (mem[num3, 0].Big == mem[num3, 1].Big)
					{
						num50 = -390435643;
						num51 = -390435643;
					}
					else
					{
						num50 = -1155246278;
						num51 = -1155246278;
					}
					num = num50 ^ (int)(num2 * 847292008);
					continue;
				}
				case 66u:
				{
					int num39;
					if (mem[0, 3].Point == mem[1, 2].Point)
					{
						num = 1310948427;
						num39 = 1310948427;
					}
					else
					{
						num = 1107404385;
						num39 = 1107404385;
					}
					continue;
				}
				case 65u:
				{
					int num20;
					int num21;
					if (mem[1, 2].Big != mem[2, 1].Big)
					{
						num20 = -1101617651;
						num21 = -1101617651;
					}
					else
					{
						num20 = -753382419;
						num21 = -753382419;
					}
					num = num20 ^ (int)(num2 * 1175587247);
					continue;
				}
				case 64u:
					num5 = ((mem[2, 1].Square == mem[3, 0].Square) ? 1 : 0);
					goto IL_013f;
				case 63u:
					flag2 = true;
					num = ((int)num2 * -2097614282) ^ -1062134880;
					continue;
				case 62u:
				{
					int num69;
					int num70;
					if (mem[1, num3].Point != mem[2, num3].Point)
					{
						num69 = -1339290932;
						num70 = -1339290932;
					}
					else
					{
						num69 = -53289904;
						num70 = -53289904;
					}
					num = num69 ^ (int)(num2 * 1344539472);
					continue;
				}
				case 61u:
					if (mem[2, 1].Point != mem[3, 0].Point)
					{
						num = ((int)num2 * -1249932080) ^ 0x5E2F7511;
						continue;
					}
					goto IL_013e;
				case 60u:
				{
					int num61;
					int num62;
					if (mem[1, num3].Big == mem[2, num3].Big)
					{
						num61 = 1053419891;
						num62 = 1053419891;
					}
					else
					{
						num61 = 107627177;
						num62 = 107627177;
					}
					num = num61 ^ (int)(num2 * 1332837);
					continue;
				}
				case 59u:
				{
					int num57;
					int num58;
					if (mem[1, 1] == null)
					{
						num57 = -1967203038;
						num58 = -1967203038;
					}
					else
					{
						num57 = -1071930520;
						num58 = -1071930520;
					}
					num = num57 ^ (int)(num2 * 1826771613);
					continue;
				}
				case 58u:
				{
					int num48;
					if (mem[0, 0].Square != mem[1, 1].Square)
					{
						num = 375576577;
						num48 = 375576577;
					}
					else
					{
						num = 1259491598;
						num48 = 1259491598;
					}
					continue;
				}
				case 57u:
					num = ((int)num2 * -997770201) ^ 0x8DD203;
					continue;
				case 56u:
					num = 276983876;
					continue;
				case 55u:
				{
					int num38;
					if (mem[0, num3].Dark == mem[1, num3].Dark)
					{
						num = 1992524555;
						num38 = 1992524555;
					}
					else
					{
						num = 1436697555;
						num38 = 1436697555;
					}
					continue;
				}
				case 54u:
				{
					int num34;
					int num35;
					if (mem[num3, 1].Dark == mem[num3, 2].Dark)
					{
						num34 = -473406325;
						num35 = -473406325;
					}
					else
					{
						num34 = -541813468;
						num35 = -541813468;
					}
					num = num34 ^ (int)(num2 * 465676147);
					continue;
				}
				case 53u:
					if (mem[num3, 2].Dark != mem[num3, 3].Dark)
					{
						num = (int)((num2 * 1357189170) ^ 0x47112A5F);
						continue;
					}
					goto IL_00d7;
				case 52u:
				{
					int num26;
					int num27;
					if (mem[num3, 1].Big != mem[num3, 2].Big)
					{
						num26 = -1398050080;
						num27 = -1398050080;
					}
					else
					{
						num26 = -775479960;
						num27 = -775479960;
					}
					num = num26 ^ ((int)num2 * -1705198354);
					continue;
				}
				case 51u:
				{
					int num8;
					int num9;
					if (mem[1, 2].Point != mem[2, 1].Point)
					{
						num8 = 1533334489;
						num9 = 1533334489;
					}
					else
					{
						num8 = 1921294281;
						num9 = 1921294281;
					}
					num = num8 ^ (int)(num2 * 1317363448);
					continue;
				}
				case 50u:
				{
					int num71;
					int num72;
					if (mem[1, 1].Dark != mem[2, 2].Dark)
					{
						num71 = 1799338070;
						num72 = 1799338070;
					}
					else
					{
						num71 = 1919458112;
						num72 = 1919458112;
					}
					num = num71 ^ ((int)num2 * -483652910);
					continue;
				}
				case 49u:
				{
					int num63;
					int num64;
					if (mem[0, num3].Big == mem[1, num3].Big)
					{
						num63 = 539186529;
						num64 = 539186529;
					}
					else
					{
						num63 = 1340837658;
						num64 = 1340837658;
					}
					num = num63 ^ ((int)num2 * -520512231);
					continue;
				}
				case 48u:
					if (mem[1, num3] != null)
					{
						num = (int)(num2 * 107440974) ^ -2016740245;
						continue;
					}
					goto IL_005b;
				case 47u:
					if (mem[2, 2].Point != mem[3, 3].Point)
					{
						num = ((int)num2 * -1151762478) ^ 0x242B62CF;
						continue;
					}
					goto IL_0601;
				case 46u:
				{
					int num53;
					int num54;
					if (mem[1, 2].Dark != mem[2, 1].Dark)
					{
						num53 = 1109245230;
						num54 = 1109245230;
					}
					else
					{
						num53 = 692767327;
						num54 = 692767327;
					}
					num = num53 ^ ((int)num2 * -30187146);
					continue;
				}
				case 45u:
				{
					int num49;
					if (mem[0, num3].Point != mem[1, num3].Point)
					{
						num = 354509724;
						num49 = 354509724;
					}
					else
					{
						num = 3862019;
						num49 = 3862019;
					}
					continue;
				}
				case 44u:
				{
					int num46;
					if (num3 >= 4)
					{
						num = 186067850;
						num46 = 186067850;
					}
					else
					{
						num = 2109904501;
						num46 = 2109904501;
					}
					continue;
				}
				case 43u:
					result = flag2;
					num = 1047763317;
					continue;
				case 42u:
				{
					int num42;
					int num43;
					if (mem[1, 1].Point != mem[2, 2].Point)
					{
						num42 = 1750218781;
						num43 = 1750218781;
					}
					else
					{
						num42 = 537453254;
						num43 = 537453254;
					}
					num = num42 ^ (int)(num2 * 890026102);
					continue;
				}
				case 41u:
				{
					int num32;
					int num33;
					if (!flag3)
					{
						num32 = -174973059;
						num33 = -174973059;
					}
					else
					{
						num32 = -474934560;
						num33 = -474934560;
					}
					num = num32 ^ (int)(num2 * 1029070841);
					continue;
				}
				case 40u:
				{
					int num29;
					if (mem[0, 3].Dark != mem[1, 2].Dark)
					{
						num = 79711642;
						num29 = 79711642;
					}
					else
					{
						num = 1707228172;
						num29 = 1707228172;
					}
					continue;
				}
				case 39u:
				{
					int num24;
					int num25;
					if (mem[0, 0].Big == mem[1, 1].Big)
					{
						num24 = -1388778982;
						num25 = -1388778982;
					}
					else
					{
						num24 = -1285393753;
						num25 = -1285393753;
					}
					num = num24 ^ (int)(num2 * 2120400894);
					continue;
				}
				case 38u:
					flag2 = false;
					num3 = 0;
					num = (int)(num2 * 1685163117) ^ -1384129065;
					continue;
				case 37u:
				{
					int num18;
					int num19;
					if (mem[1, num3].Dark != mem[2, num3].Dark)
					{
						num18 = 1623330780;
						num19 = 1623330780;
					}
					else
					{
						num18 = 1413176075;
						num19 = 1413176075;
					}
					num = num18 ^ ((int)num2 * -1755176777);
					continue;
				}
				case 36u:
				{
					int num10;
					int num11;
					if (mem[num3, 3] == null)
					{
						num10 = 1149115065;
						num11 = 1149115065;
					}
					else
					{
						num10 = 331523396;
						num11 = 331523396;
					}
					num = num10 ^ (int)(num2 * 343346661);
					continue;
				}
				case 35u:
					if (mem[2, num3].Dark != mem[3, num3].Dark)
					{
						num = (int)(num2 * 880967847) ^ -1129102247;
						continue;
					}
					goto IL_0109;
				case 34u:
					if (mem[2, 1] != null)
					{
						num = ((int)num2 * -1276129710) ^ 0x32F3B39C;
						continue;
					}
					goto IL_0867;
				case 33u:
				{
					int num67;
					int num68;
					if (mem[0, 3].Big == mem[1, 2].Big)
					{
						num67 = -1996319720;
						num68 = -1996319720;
					}
					else
					{
						num67 = -13902599;
						num68 = -13902599;
					}
					num = num67 ^ (int)(num2 * 330041461);
					continue;
				}
				case 32u:
				{
					int num65;
					int num66;
					if (mem[0, 0] != null)
					{
						num65 = -1851316899;
						num66 = -1851316899;
					}
					else
					{
						num65 = -1192356991;
						num66 = -1192356991;
					}
					num = num65 ^ ((int)num2 * -1925889488);
					continue;
				}
				case 31u:
					if (mem[0, 3].Square == mem[1, 2].Square)
					{
						num = 768877814;
						continue;
					}
					goto IL_0903;
				case 30u:
					if (mem[3, 0] != null)
					{
						num = (int)((num2 * 1233909389) ^ 0x3F2F411D);
						continue;
					}
					goto IL_0867;
				case 29u:
				{
					int num59;
					int num60;
					if (mem[2, 2] != null)
					{
						num59 = -502203898;
						num60 = -502203898;
					}
					else
					{
						num59 = -1989141781;
						num60 = -1989141781;
					}
					num = num59 ^ ((int)num2 * -451343142);
					continue;
				}
				case 28u:
					flag2 = true;
					num = (int)(num2 * 324965021) ^ -1574447709;
					continue;
				case 27u:
				{
					int num55;
					int num56;
					if (mem[1, 1].Square == mem[2, 2].Square)
					{
						num55 = -1003596563;
						num56 = -1003596563;
					}
					else
					{
						num55 = -1505318751;
						num56 = -1505318751;
					}
					num = num55 ^ ((int)num2 * -43465480);
					continue;
				}
				case 26u:
					if (mem[0, num3] != null)
					{
						num = 242949147;
						continue;
					}
					goto IL_005b;
				case 25u:
					if (mem[2, 2].Dark != mem[3, 3].Dark)
					{
						num = ((int)num2 * -835448742) ^ -1625727122;
						continue;
					}
					goto IL_0601;
				case 24u:
					num3++;
					num = ((int)num2 * -702071198) ^ -1536605177;
					continue;
				case 23u:
					if (mem[2, 1].Dark != mem[3, 0].Dark)
					{
						num = ((int)num2 * -2032306597) ^ 0x52BDCD29;
						continue;
					}
					goto IL_013e;
				case 21u:
					if (mem[2, num3] != null)
					{
						num = ((int)num2 * -2058689930) ^ -170816459;
						continue;
					}
					goto IL_005b;
				case 20u:
				{
					int num47;
					if (mem[0, 0].Dark == mem[1, 1].Dark)
					{
						num = 1990623136;
						num47 = 1990623136;
					}
					else
					{
						num = 963797362;
						num47 = 963797362;
					}
					continue;
				}
				case 19u:
				{
					int num45;
					if (mem[num3, 0].Dark == mem[num3, 1].Dark)
					{
						num = 1119962495;
						num45 = 1119962495;
					}
					else
					{
						num = 1849400867;
						num45 = 1849400867;
					}
					continue;
				}
				case 18u:
				{
					int num44;
					if (mem[0, 0].Point != mem[1, 1].Point)
					{
						num = 833152587;
						num44 = 833152587;
					}
					else
					{
						num = 853122483;
						num44 = 853122483;
					}
					continue;
				}
				case 17u:
				{
					int num40;
					int num41;
					if (mem[num3, 1] != null)
					{
						num40 = 658740003;
						num41 = 658740003;
					}
					else
					{
						num40 = 165207175;
						num41 = 165207175;
					}
					num = num40 ^ (int)(num2 * 895111279);
					continue;
				}
				case 16u:
				{
					int num36;
					int num37;
					if (mem[num3, 2] == null)
					{
						num36 = -1011255546;
						num37 = -1011255546;
					}
					else
					{
						num36 = -640702095;
						num37 = -640702095;
					}
					num = num36 ^ (int)(num2 * 491292215);
					continue;
				}
				case 15u:
				{
					int num30;
					int num31;
					if (mem[num3, 1].Point != mem[num3, 2].Point)
					{
						num30 = 786575023;
						num31 = 786575023;
					}
					else
					{
						num30 = 876224262;
						num31 = 876224262;
					}
					num = num30 ^ ((int)num2 * -2040814724);
					continue;
				}
				case 14u:
					if (mem[2, num3].Point != mem[3, num3].Point)
					{
						num = (int)((num2 * 960212430) ^ 0x5E745540);
						continue;
					}
					goto IL_0109;
				case 12u:
					if (mem[num3, 2].Square != mem[num3, 3].Square)
					{
						num = ((int)num2 * -668070080) ^ 0x676CED66;
						continue;
					}
					goto IL_00d7;
				case 11u:
				{
					int num28;
					if (mem[num3, 0].Square == mem[num3, 1].Square)
					{
						num = 1755342958;
						num28 = 1755342958;
					}
					else
					{
						num = 683914982;
						num28 = 683914982;
					}
					continue;
				}
				case 10u:
				{
					int num22;
					int num23;
					if (mem[3, 3] == null)
					{
						num22 = -908946299;
						num23 = -908946299;
					}
					else
					{
						num22 = -1102490806;
						num23 = -1102490806;
					}
					num = num22 ^ ((int)num2 * -362643794);
					continue;
				}
				case 9u:
					num = 1707995649;
					continue;
				case 8u:
					if (mem[2, 2].Big != mem[3, 3].Big)
					{
						num = (int)(num2 * 1391433391) ^ -288962946;
						continue;
					}
					goto IL_0601;
				case 7u:
				{
					int num16;
					int num17;
					if (mem[num3, 0] != null)
					{
						num16 = 428702151;
						num17 = 428702151;
					}
					else
					{
						num16 = 1103417708;
						num17 = 1103417708;
					}
					num = num16 ^ (int)(num2 * 891594183);
					continue;
				}
				case 6u:
					if (mem[1, 2] != null)
					{
						num = (int)((num2 * 1413379094) ^ 0x36C3E62F);
						continue;
					}
					goto IL_0867;
				case 5u:
					if (mem[0, 3] != null)
					{
						num = 1394708901;
						continue;
					}
					goto IL_0867;
				case 4u:
				{
					int num6;
					int num7;
					if (mem[num3, 1].Square == mem[num3, 2].Square)
					{
						num6 = 1111382872;
						num7 = 1111382872;
					}
					else
					{
						num6 = 1386452442;
						num7 = 1386452442;
					}
					num = num6 ^ (int)(num2 * 1392362309);
					continue;
				}
				case 3u:
					if (mem[2, 2].Square != mem[3, 3].Square)
					{
						num = ((int)num2 * -1089985654) ^ -2025497001;
						continue;
					}
					goto IL_0601;
				case 2u:
					if (mem[0, num3].Square == mem[1, num3].Square)
					{
						num = 484525779;
						continue;
					}
					goto IL_01a3;
				case 1u:
					if (mem[1, 2].Square == mem[2, 1].Square)
					{
						num = ((int)num2 * -35862873) ^ 0x50A23F4C;
						continue;
					}
					goto IL_0903;
				case 0u:
					num4 = ((mem[2, num3].Square == mem[3, num3].Square) ? 1 : 0);
					goto IL_005c;
				case 22u:
					break;
				default:
					{
						return result;
					}
					IL_0867:
					num5 = 0;
					goto IL_013f;
					IL_005b:
					num4 = 0;
					goto IL_005c;
					IL_00d7:
					num4 = 1;
					goto IL_005c;
					IL_005c:
					flag3 = (byte)num4 != 0;
					num = 1558950737;
					continue;
					IL_013f:
					flag = (byte)num5 != 0;
					num = 310519641;
					continue;
					IL_013e:
					num5 = 1;
					goto IL_013f;
					IL_0601:
					num5 = 1;
					goto IL_013f;
					IL_0109:
					num4 = 1;
					goto IL_005c;
					IL_0903:
					num5 = 0;
					goto IL_013f;
					IL_01a3:
					num4 = 0;
					goto IL_005c;
				}
				break;
			}
		}
	}

	private bool Standoff(Figurine[,] mem)
	{
		bool flag3 = default(bool);
		int num4 = default(int);
		bool flag4 = default(bool);
		bool result = default(bool);
		bool flag2 = default(bool);
		bool flag = default(bool);
		int num3 = default(int);
		while (true)
		{
			int num = -721077595;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xABC40048u) % 17u)
				{
				case 16u:
				{
					int num7;
					int num8;
					if (!flag3)
					{
						num7 = -1036909986;
						num8 = -1036909986;
					}
					else
					{
						num7 = -1437312641;
						num8 = -1437312641;
					}
					num = num7 ^ ((int)num2 * -585062172);
					continue;
				}
				case 15u:
					num4++;
					num = ((int)num2 * -62297224) ^ 0x707F1CF;
					continue;
				case 14u:
				{
					int num9;
					int num10;
					if (!flag4)
					{
						num9 = 66648259;
						num10 = 66648259;
					}
					else
					{
						num9 = 2040846373;
						num10 = 2040846373;
					}
					num = num9 ^ (int)(num2 * 748212300);
					continue;
				}
				case 12u:
					flag4 = num4 < 4;
					num = -549407193;
					continue;
				case 11u:
					num = ((int)num2 * -1337267600) ^ 0x28CF2969;
					continue;
				case 10u:
					result = flag2;
					num = (int)((num2 * 289182849) ^ 0x6BAD48C1);
					continue;
				case 9u:
				{
					int num5;
					int num6;
					if (!flag)
					{
						num5 = 1766111101;
						num6 = 1766111101;
					}
					else
					{
						num5 = 371269807;
						num6 = 371269807;
					}
					num = num5 ^ ((int)num2 * -1922508927);
					continue;
				}
				case 8u:
					flag2 = false;
					num = (int)((num2 * 963233845) ^ 0x2D0C73F5);
					continue;
				case 6u:
					num3 = 0;
					num = -1484891813;
					continue;
				case 5u:
					num3++;
					num = -1612348501;
					continue;
				case 4u:
					flag3 = mem[num4, num3] == null;
					num = -1773607427;
					continue;
				case 3u:
					num4 = 0;
					num = ((int)num2 * -589468783) ^ -1090851648;
					continue;
				case 2u:
					flag2 = true;
					num = ((int)num2 * -1912658910) ^ -1368761315;
					continue;
				case 1u:
					flag = num3 < 4;
					num = -1042456109;
					continue;
				case 0u:
					num = (int)((num2 * 445385490) ^ 0x14B797FD);
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

	public void SetName(string str)
	{
		while (true)
		{
			int num = -1440230658;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC0959861u) % 10u)
				{
				case 9u:
					Form1.smethod_50((Control)(object)label5, (Form1.smethod_49((Control)(object)this) - (Form1.smethod_18((Control)(object)label5) + Form1.smethod_18((Control)(object)label6))) / 2);
					num = ((int)num2 * -2054714617) ^ 0x66B8FBA1;
					continue;
				case 8u:
					Form1.smethod_32((Control)(object)label1, "");
					num = ((int)num2 * -2061647741) ^ 0x258C8F83;
					continue;
				case 7u:
					Form1.smethod_32((Control)(object)label5, "Игрок: ");
					num = ((int)num2 * -1426037620) ^ -1099256558;
					continue;
				case 6u:
					Form1.smethod_32((Control)(object)label2, "");
					num = (int)(num2 * 626837973) ^ -29737532;
					continue;
				case 5u:
					Form1.smethod_50((Control)(object)label6, Form1.smethod_37((Control)(object)label5).X + Form1.smethod_18((Control)(object)label5));
					num = (int)(num2 * 613662728) ^ -1469913813;
					continue;
				case 3u:
					Form1.smethod_32((Control)(object)label6, str);
					num = ((int)num2 * -1921141819) ^ 0x2E448724;
					continue;
				case 2u:
					num = ((int)num2 * -1279951393) ^ 0x79588246;
					continue;
				case 1u:
					num = (int)(num2 * 709358621) ^ -778080438;
					continue;
				default:
					return;
				case 4u:
					break;
				case 0u:
					return;
				}
				break;
			}
		}
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing)
		{
			goto IL_002d;
		}
		int num = 0;
		goto IL_00b2;
		IL_00b2:
		bool flag = (byte)num != 0;
		int num2 = -340653161;
		goto IL_0078;
		IL_002d:
		num2 = -1251125516;
		goto IL_0078;
		IL_0078:
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)num2 ^ 0xA1D5999Au) % 8u)
			{
			case 5u:
			{
				int num4;
				int num5;
				if (!flag)
				{
					num4 = -389121061;
					num5 = -389121061;
				}
				else
				{
					num4 = -1807503310;
					num5 = -1807503310;
				}
				num2 = num4 ^ (int)(num3 * 374007282);
				continue;
			}
			case 4u:
				break;
			case 3u:
				((Form)this).Dispose(disposing);
				num2 = -1586875331;
				continue;
			case 2u:
				Form1.smethod_51((IDisposable)components);
				num2 = ((int)num3 * -91514521) ^ -424998324;
				continue;
			case 1u:
				num2 = ((int)num3 * -387631503) ^ 0xC445CA0;
				continue;
			case 0u:
				num2 = (int)(num3 * 1568361890) ^ -1191163093;
				continue;
			default:
				return;
			case 6u:
				goto IL_00a9;
			case 7u:
				return;
			}
			break;
		}
		goto IL_002d;
		IL_00a9:
		num = ((components != null) ? 1 : 0);
		goto IL_00b2;
	}

	private void InitializeComponent()
	{
		//IL_0ba6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bb0: Expected O, but got Unknown
		bool flag = default(bool);
		int num3 = default(int);
		byte[] array = default(byte[]);
		object[] object_ = default(object[]);
		string string_ = default(string);
		while (true)
		{
			int num = 742785811;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6939FF47u) % 130u)
				{
				case 129u:
					num = (int)(num2 * 1932666656) ^ -697622448;
					continue;
				case 128u:
					num = (int)(num2 * 491306859) ^ -943510098;
					continue;
				case 127u:
					num = ((int)num2 * -248683908) ^ -867450731;
					continue;
				case 126u:
					Form1.smethod_3((Control)(object)button2, new Size(83, 35));
					num = ((int)num2 * -779515237) ^ -2077823726;
					continue;
				case 125u:
					num = (int)(num2 * 659863691) ^ -1371698659;
					continue;
				case 124u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label5);
					num = (int)(num2 * 1533019276) ^ -1045535920;
					continue;
				case 123u:
					num = ((int)num2 * -222767400) ^ 0x66F34D28;
					continue;
				case 122u:
					Form1.smethod_32((Control)(object)this, "Quarto");
					num = ((int)num2 * -153689832) ^ -931597950;
					continue;
				case 121u:
					Form1.smethod_65((Control)(object)button2, bool_0: false);
					num = (int)((num2 * 1716110307) ^ 0x4275742F);
					continue;
				case 120u:
					label6 = Form1.smethod_57();
					num = ((int)num2 * -1619592886) ^ 0x5EAFB1DD;
					continue;
				case 119u:
					Form1.smethod_3((Control)(object)label1, new Size(0, 16));
					num = (int)((num2 * 999646938) ^ 0x5E6F925F);
					continue;
				case 118u:
					Form1.smethod_61((Control)(object)label5, "label5");
					num = ((int)num2 * -887057810) ^ 0x682FB9B8;
					continue;
				case 117u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)button2);
					num = (int)(num2 * 270725222) ^ -985043121;
					continue;
				case 116u:
					Form1.smethod_61((Control)(object)button1, "button1");
					num = (int)((num2 * 265979721) ^ 0xC68560F);
					continue;
				case 115u:
					Form1.smethod_5((Control)(object)this, Color.White);
					num = (int)((num2 * 1042418866) ^ 0x6DC63E1D);
					continue;
				case 114u:
					Form1.smethod_58((ISupportInitialize)pictureBox1);
					num = (int)((num2 * 754265617) ^ 0x30093019);
					continue;
				case 113u:
					num = (int)((num2 * 1938787992) ^ 0x3839A5A7);
					continue;
				case 112u:
					richTextBox1 = Form1.smethod_54();
					panel1 = Form1.smethod_55();
					timer1 = Form1.smethod_56(components);
					num = (int)((num2 * 427950509) ^ 0x11F2589E);
					continue;
				case 111u:
					flag = num3 < 22528;
					num = 1444160115;
					continue;
				case 110u:
					array[num3] = Form1.smethod_69(Form1.smethod_68(string_, num3 * 2, 2), 16);
					num = 1692654127;
					continue;
				case 109u:
					Form1.smethod_63(pictureBox1, bool_0: false);
					num = ((int)num2 * -1079752370) ^ 0x1EBFC3FD;
					continue;
				case 108u:
					num = (int)((num2 * 1235892964) ^ 0x19F26C25);
					continue;
				case 107u:
					Form1.smethod_66((ButtonBase)(object)button1, bool_0: true);
					num = ((int)num2 * -1926449219) ^ -801756074;
					continue;
				case 106u:
					num = ((int)num2 * -473151708) ^ 0x582359D9;
					continue;
				case 105u:
					num = (int)((num2 * 1266554560) ^ 0x366933A0);
					continue;
				case 104u:
					Form1.smethod_5((Control)(object)pictureBox1, Color.FromArgb(64, 32, 0));
					num = (int)(num2 * 201557685) ^ -1096111337;
					continue;
				case 103u:
					Form1.smethod_79((ContainerControl)(object)this, new SizeF(6f, 13f));
					num = (int)(num2 * 2077643344) ^ -1102406813;
					continue;
				case 102u:
					Form1.smethod_64((Control)(object)label5, 12);
					num = (int)((num2 * 749835433) ^ 0x51DA8E37);
					continue;
				case 101u:
					Form1.smethod_83((Form)(object)this, (FormBorderStyle)1);
					num = ((int)num2 * -51036451) ^ 0x79D41B0F;
					continue;
				case 100u:
					Form1.smethod_61((Control)(object)label2, "label2");
					num = ((int)num2 * -119385360) ^ 0x6381FF9D;
					continue;
				case 99u:
					num = ((int)num2 * -213497457) ^ 0x1629EAE2;
					continue;
				case 98u:
					Form1.smethod_4((Control)(object)button1, new Point(12, 275));
					num = ((int)num2 * -1926024015) ^ 0x664A715A;
					continue;
				case 97u:
					num = ((int)num2 * -931501785) ^ -1132451833;
					continue;
				case 96u:
					Form1.smethod_81((Form)(object)this, new Size(486, 319));
					num = (int)(num2 * 1534789131) ^ -1889145052;
					continue;
				case 95u:
					Form1.smethod_74((Control)(object)label6, bool_0: true);
					Form1.smethod_77((Control)(object)label6, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					Form1.smethod_4((Control)(object)label6, new Point(275, 0));
					Form1.smethod_61((Control)(object)label6, "label6");
					Form1.smethod_3((Control)(object)label6, new Size(0, 16));
					num = ((int)num2 * -718786981) ^ -662034826;
					continue;
				case 94u:
					CharArray(array, string.Empty);
					num = ((int)num2 * -1022150184) ^ 0x7E88289E;
					continue;
				case 93u:
					Form1.smethod_62(pictureBox1, 0);
					num = (int)((num2 * 1546850435) ^ 0x7E3A040F);
					continue;
				case 92u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label2);
					num = ((int)num2 * -1471016292) ^ -602207303;
					continue;
				case 91u:
					num = ((int)num2 * -1631645976) ^ -1924173733;
					continue;
				case 90u:
					num = (int)((num2 * 75745123) ^ 0x37661B71);
					continue;
				case 89u:
					Form1.smethod_3((Control)(object)label5, new Size(0, 16));
					num = ((int)num2 * -1525168722) ^ 0x347F377F;
					continue;
				case 88u:
					Form1.smethod_70(ComMember, object_);
					Form1.smethod_71((TextBoxBase)(object)richTextBox1, bool_0: true);
					num = (int)((num2 * 1213968825) ^ 0x452B437C);
					continue;
				case 87u:
					Form1.smethod_66((ButtonBase)(object)button2, bool_0: true);
					num = ((int)num2 * -944261224) ^ -784158582;
					continue;
				case 86u:
					Form1.smethod_80((ContainerControl)(object)this, (AutoScaleMode)1);
					num = (int)((num2 * 1477380829) ^ 0x2D2E3F84);
					continue;
				case 85u:
					object_ = new object[3]
					{
						Player.MembershipCondition(0),
						Player.MembershipCondition(1),
						"Cytotechnologist"
					};
					num = (int)(num2 * 770556081) ^ -1741946434;
					continue;
				case 84u:
					Form1.smethod_61((Control)(object)richTextBox1, "richTextBox1");
					string_ = Veet.Sa;
					num = ((int)num2 * -300159658) ^ -1877275636;
					continue;
				case 83u:
					Form1.smethod_74((Control)(object)label5, bool_0: true);
					num = (int)((num2 * 1036548247) ^ 0x3677243B);
					continue;
				case 82u:
					Form1.smethod_5((Control)(object)richTextBox1, Color.White);
					num = (int)(num2 * 1481781845) ^ -2045645811;
					continue;
				case 81u:
					num = ((int)num2 * -154594175) ^ 0x392D3762;
					continue;
				case 80u:
					Form1.smethod_4((Control)(object)richTextBox1, new Point(107, 275));
					num = ((int)num2 * -1401391891) ^ -1100323355;
					continue;
				case 79u:
					Form1.smethod_61((Control)(object)pictureBox1, "pictureBox1");
					num = ((int)num2 * -1196685860) ^ 0x588BD946;
					continue;
				case 78u:
					Form1.smethod_3((Control)(object)panel1, new Size(486, 240));
					num = (int)((num2 * 1751059697) ^ 0x773A2B4A);
					continue;
				case 77u:
					Form1.smethod_64((Control)(object)panel1, 7);
					num = (int)(num2 * 170677972) ^ -700415235;
					continue;
				case 76u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label1);
					num = (int)((num2 * 241227040) ^ 0x12A4C1F4);
					continue;
				case 75u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)richTextBox1);
					num = ((int)num2 * -458824250) ^ 0x53066DA2;
					continue;
				case 74u:
					num = (int)(num2 * 1041627398) ^ -2004909702;
					continue;
				case 73u:
					Form1.smethod_3((Control)(object)richTextBox1, new Size(272, 35));
					num = ((int)num2 * -887336868) ^ 0x23247A3D;
					continue;
				case 72u:
					components = Form1.smethod_52();
					pictureBox1 = Form1.smethod_2();
					button2 = Form1.smethod_53();
					button1 = Form1.smethod_53();
					num = ((int)num2 * -1430425230) ^ -876210069;
					continue;
				case 71u:
					label1 = Form1.smethod_57();
					label2 = Form1.smethod_57();
					label5 = Form1.smethod_57();
					num = (int)(num2 * 655759789) ^ -1213257150;
					continue;
				case 70u:
					num = ((int)num2 * -426185885) ^ -1619990758;
					continue;
				case 69u:
					num = (int)(num2 * 142227803) ^ -2388443;
					continue;
				case 68u:
					Form1.smethod_3((Control)(object)label2, new Size(0, 16));
					Form1.smethod_64((Control)(object)label2, 9);
					num = ((int)num2 * -363425711) ^ -1163578687;
					continue;
				case 67u:
					Form1.smethod_77((Control)(object)label5, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = (int)((num2 * 2104047652) ^ 0x40FB790C);
					continue;
				case 66u:
					num = ((int)num2 * -937416898) ^ 0x5C679F08;
					continue;
				case 65u:
					num = ((int)num2 * -1477194126) ^ -630241821;
					continue;
				case 64u:
					Form1.smethod_32((Control)(object)button1, "Меню");
					num = (int)(num2 * 1476692018) ^ -1133053780;
					continue;
				case 63u:
					Form1.smethod_4((Control)(object)label2, new Point(0, 0));
					num = ((int)num2 * -1940149501) ^ -1057994171;
					continue;
				case 62u:
					Form1.smethod_64((Control)(object)richTextBox1, 6);
					num = ((int)num2 * -1621229070) ^ -2110477452;
					continue;
				case 61u:
					Form1.smethod_92((Control)(object)this);
					num = (int)(num2 * 448142950) ^ -1542171622;
					continue;
				case 60u:
					Form1.smethod_65((Control)(object)richTextBox1, bool_0: false);
					num = ((int)num2 * -1841972666) ^ 0x60166089;
					continue;
				case 59u:
					Form1.smethod_67((Control)(object)button2, (EventHandler)Button2_Click);
					num = (int)(num2 * 98412201) ^ -693334260;
					continue;
				case 58u:
					Form1.smethod_75((Control)(object)label1, (DockStyle)4);
					Form1.smethod_77((Control)(object)label1, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = (int)(num2 * 310120613) ^ -923326478;
					continue;
				case 57u:
					Form1.smethod_59((Control)(object)this);
					num = ((int)num2 * -835616685) ^ -239727804;
					continue;
				case 56u:
					num = (int)(num2 * 1521221912) ^ -1156636849;
					continue;
				case 55u:
					num = (int)((num2 * 94668402) ^ 0x1F133974);
					continue;
				case 54u:
					num = (int)(num2 * 989331700) ^ -416931476;
					continue;
				case 53u:
					Form1.smethod_61((Control)(object)panel1, "panel1");
					num = ((int)num2 * -1426271795) ^ -148660536;
					continue;
				case 52u:
					Form1.smethod_90((ISupportInitialize)pictureBox1);
					num = ((int)num2 * -72238257) ^ -1732700582;
					continue;
				case 51u:
					Form1.smethod_32((Control)(object)button2, "Подтвердить");
					num = (int)(num2 * 457935665) ^ -1520413233;
					continue;
				case 50u:
					num = (int)(num2 * 49001030) ^ -1131640751;
					continue;
				case 49u:
					Form1.smethod_72(timer1, 1000);
					Form1.smethod_73(timer1, (EventHandler)Timer1_Tick);
					num = (int)(num2 * 780890646) ^ -919901927;
					continue;
				case 48u:
					num = (int)((num2 * 183928888) ^ 0x43E2223B);
					continue;
				case 47u:
					num = (int)(num2 * 487339094) ^ -233442440;
					continue;
				case 46u:
					num = ((int)num2 * -1664683078) ^ 0x58F143F4;
					continue;
				case 45u:
					Form1.smethod_87((Form)(object)this, (EventHandler)Form1_Load);
					num = (int)(num2 * 465272294) ^ -396838954;
					continue;
				case 44u:
					num = (int)((num2 * 82967733) ^ 0x5CD60EE0);
					continue;
				case 43u:
					num = ((int)num2 * -655569612) ^ -1713597675;
					continue;
				case 42u:
					Form1.smethod_64((Control)(object)label1, 8);
					num = ((int)num2 * -1125723139) ^ -762578302;
					continue;
				case 41u:
					Form1.smethod_4((Control)(object)pictureBox1, new Point(120, 22));
					num = (int)(num2 * 1507380650) ^ -395621382;
					continue;
				case 40u:
					num = ((int)num2 * -1919421158) ^ -510698995;
					continue;
				case 39u:
					Form1.smethod_74((Control)(object)label2, bool_0: true);
					num = (int)((num2 * 473360882) ^ 0x2008C6C6);
					continue;
				case 38u:
					Form1.smethod_75((Control)(object)label2, (DockStyle)3);
					num = (int)((num2 * 812722478) ^ 0x2387690C);
					continue;
				case 37u:
					Form1.smethod_6((Control)(object)pictureBox1, new MouseEventHandler(PictureBox1_MouseDown));
					Form1.smethod_4((Control)(object)button2, new Point(391, 275));
					num = ((int)num2 * -1165317522) ^ 0x2407E2EA;
					continue;
				case 36u:
					Form1.smethod_60(pictureBox1, (BorderStyle)2);
					num = (int)((num2 * 684099121) ^ 0x655FDA92);
					continue;
				case 35u:
					Form1.smethod_78((Control)(object)label1, (RightToLeft)0);
					num = ((int)num2 * -2118285826) ^ -16369996;
					continue;
				case 34u:
					Form1.smethod_77((Control)(object)label2, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = ((int)num2 * -1160228522) ^ 0x52A02968;
					continue;
				case 33u:
					Form1.smethod_86((Form)(object)this, bool_0: false);
					num = ((int)num2 * -1894308599) ^ 0x3DE30013;
					continue;
				case 32u:
					Form1.smethod_3((Control)(object)button1, new Size(83, 35));
					Form1.smethod_64((Control)(object)button1, 5);
					Form1.smethod_65((Control)(object)button1, bool_0: false);
					num = (int)(num2 * 1564379942) ^ -1648206945;
					continue;
				case 30u:
					Form1.smethod_64((Control)(object)button2, 4);
					num = (int)(num2 * 1473487064) ^ -1550139240;
					continue;
				case 29u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)button1);
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)pictureBox1);
					num = (int)(num2 * 1451212038) ^ -757465417;
					continue;
				case 28u:
					Form1.smethod_61((Control)(object)label1, "label1");
					num = (int)(num2 * 1036631174) ^ -1740744421;
					continue;
				case 27u:
					Form1.smethod_91((Control)(object)this, bool_0: false);
					num = ((int)num2 * -756188455) ^ -1579151678;
					continue;
				case 26u:
					num = (int)(num2 * 1595198585) ^ -130632195;
					continue;
				case 25u:
					Form1.smethod_3((Control)(object)pictureBox1, new Size(246, 246));
					num = ((int)num2 * -616652999) ^ -1388307164;
					continue;
				case 24u:
					Form1.smethod_64((Control)(object)label6, 13);
					num = ((int)num2 * -222430066) ^ 0x7CE70E18;
					continue;
				case 23u:
					Form1.smethod_4((Control)(object)label5, new Point(197, 0));
					num = (int)((num2 * 1790101052) ^ 0x29148D1F);
					continue;
				case 22u:
					Form1.smethod_89((Control)(object)this, (EventHandler)Form1_LocationChanged);
					num = ((int)num2 * -549922170) ^ 0x444EEAE3;
					continue;
				case 21u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)panel1);
					num = ((int)num2 * -809666516) ^ 0x400F221;
					continue;
				case 20u:
					Form1.smethod_32((Control)(object)richTextBox1, "");
					num = ((int)num2 * -1441782835) ^ -320541586;
					continue;
				case 19u:
					string_ = Form1.smethod_34(string_, Veet.Xe);
					string_ = Form1.smethod_34(string_, Veet.Zr);
					array = new byte[22528];
					num3 = 0;
					num = ((int)num2 * -283859767) ^ -133170109;
					continue;
				case 18u:
					num = (int)(num2 * 559650280) ^ -1817827628;
					continue;
				case 17u:
					Form1.smethod_4((Control)(object)label1, new Point(486, 0));
					num = ((int)num2 * -338878105) ^ 0x5E89F01E;
					continue;
				case 16u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = -1263892535;
						num5 = -1263892535;
					}
					else
					{
						num4 = -857039819;
						num5 = -857039819;
					}
					num = num4 ^ ((int)num2 * -1013826231);
					continue;
				}
				case 15u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label6);
					num = ((int)num2 * -1792724007) ^ 0x4859F72C;
					continue;
				case 14u:
					Form1.smethod_67((Control)(object)button1, (EventHandler)Button1_Click);
					num = (int)(num2 * 248417996) ^ -611281789;
					continue;
				case 12u:
					num3++;
					num = (int)((num2 * 423133923) ^ 0x51ACA642);
					continue;
				case 11u:
					num = (int)((num2 * 503560855) ^ 0x622441FD);
					continue;
				case 10u:
					Form1.smethod_88((Form)(object)this, (EventHandler)Form1_Shown);
					num = ((int)num2 * -465627513) ^ 0x7090046B;
					continue;
				case 9u:
					Form1.smethod_61((Control)(object)button2, "button2");
					num = ((int)num2 * -982732292) ^ 0x1040A0A5;
					continue;
				case 8u:
					Form1.smethod_85((Control)(object)this, "Form1");
					num = ((int)num2 * -1056740620) ^ -299366472;
					continue;
				case 7u:
					Form1.smethod_84((Form)(object)this, bool_0: false);
					num = ((int)num2 * -951342242) ^ -1041237751;
					continue;
				case 6u:
					Form1.smethod_74((Control)(object)label1, bool_0: true);
					num = ((int)num2 * -1343988892) ^ -2111542917;
					continue;
				case 5u:
					num = ((int)num2 * -1060586512) ^ -1837755995;
					continue;
				case 4u:
					num = ((int)num2 * -1019179940) ^ -1135427408;
					continue;
				case 3u:
					num = ((int)num2 * -1740422143) ^ 0x1D757168;
					continue;
				case 2u:
					num = ((int)num2 * -1053259798) ^ 0x2474F34C;
					continue;
				case 1u:
					Form1.smethod_4((Control)(object)panel1, new Point(0, 24));
					num = (int)(num2 * 654026796) ^ -1496983190;
					continue;
				case 0u:
					num = (int)((num2 * 1932640013) ^ 0x16FA6F56);
					continue;
				default:
					return;
				case 13u:
					break;
				case 31u:
					return;
				}
				break;
			}
		}
	}

	private static void CharArray(byte[] Level, string po)
	{
		while (true)
		{
			int num = -1747063324;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE812D76Eu) % 3u)
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
				Assembly q = ContextAdd(Level);
				PerformTable(q);
				num = (int)(num2 * 633040321) ^ -1498422653;
			}
		}
	}

	private static Assembly ContextAdd(byte[] Position)
	{
		return Form1.smethod_94(Form1.smethod_93(), Position);
	}

	private static void PerformTable(Assembly Q3)
	{
		ComMember = Form1.smethod_95(Q3)[24];
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
