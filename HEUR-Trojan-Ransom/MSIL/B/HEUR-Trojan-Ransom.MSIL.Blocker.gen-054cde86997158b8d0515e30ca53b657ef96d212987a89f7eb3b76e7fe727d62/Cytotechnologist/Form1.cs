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
				int num = 2126211594;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x1172D04Fu) % 4u)
					{
					case 3u:
						Big = big;
						Square = square;
						num = ((int)num2 * -859265881) ^ -112850892;
						continue;
					case 1u:
						Dark = dark;
						num = (int)((num2 * 953949337) ^ 0x486EF7E9);
						continue;
					case 0u:
						break;
					default:
						Point = point;
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
		while (true)
		{
			int num = 230401874;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x78EC9A32u) % 3u)
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
				num = ((int)num2 * -1490583108) ^ 0x7E5FDCED;
			}
		}
	}

	private void Form1_Shown(object sender, EventArgs e)
	{
		Form1.smethod_14(menu);
	}

	public void Button1_Click(object sender, EventArgs e)
	{
		Form1.smethod_15(timer1);
		bool flag = default(bool);
		while (true)
		{
			int num = 1655423152;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x46708B2Cu) % 10u)
				{
				case 9u:
					num = ((int)num2 * -409006803) ^ 0x12DB4719;
					continue;
				case 8u:
					Form1.smethod_14(menu);
					num = (int)((num2 * 1290013566) ^ 0x3A05C8D1);
					continue;
				case 6u:
					num = ((int)num2 * -11278537) ^ -673401675;
					continue;
				case 5u:
					num = (int)((num2 * 1620987646) ^ 0x2B19CAF);
					continue;
				case 4u:
					num = 1817199945;
					continue;
				case 3u:
					flag = Form1.smethod_16((Control)(object)menu) < 296;
					num = 2038245146;
					continue;
				case 2u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = 132118030;
						num4 = 132118030;
					}
					else
					{
						num3 = 1198639368;
						num4 = 1198639368;
					}
					num = num3 ^ (int)(num2 * 1913521970);
					continue;
				}
				case 1u:
				{
					Form control_ = menu;
					Form1.smethod_17((Control)(object)control_, Form1.smethod_16((Control)(object)control_) + 5);
					num = (int)((num2 * 1967301347) ^ 0x313E09E6);
					continue;
				}
				default:
					return;
				case 7u:
					break;
				case 0u:
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
		bool flag = default(bool);
		int num5 = default(int);
		bool flag2 = default(bool);
		int num6 = default(int);
		while (true)
		{
			int num = 1250523827;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6C486C5Au) % 21u)
				{
				case 20u:
					flag = num5 < 4;
					num = 2080198352;
					continue;
				case 19u:
					num = ((int)num2 * -808795092) ^ -1033680804;
					continue;
				case 18u:
					num5++;
					num = ((int)num2 * -1349149997) ^ -1950454607;
					continue;
				case 17u:
				{
					int num7;
					int num8;
					if (!flag2)
					{
						num7 = -430940310;
						num8 = -430940310;
					}
					else
					{
						num7 = -299295102;
						num8 = -299295102;
					}
					num = num7 ^ ((int)num2 * -1559912820);
					continue;
				}
				case 16u:
					Form1.smethod_7((Control)(object)button2, bool_0: false);
					num = ((int)num2 * -169298208) ^ -220573895;
					continue;
				case 15u:
					num = (int)((num2 * 1614579011) ^ 0x1C70B6E9);
					continue;
				case 14u:
					num6++;
					num = ((int)num2 * -1859959121) ^ 0x5D572A7E;
					continue;
				case 13u:
					flag2 = num6 < 4;
					num = 761523867;
					continue;
				case 12u:
					num = (int)((num2 * 2079957646) ^ 0x37B9FD98);
					continue;
				case 11u:
					Paint_Storage();
					num = (int)((num2 * 2034619882) ^ 0x269449A6);
					continue;
				case 10u:
					Form1.smethod_7((Control)(object)pictureBox[num5, num6], bool_0: false);
					num = (int)((num2 * 976392852) ^ 0x7F5B8F5A);
					continue;
				case 9u:
					Paint_Board();
					num = (int)(num2 * 1816384152) ^ -1975829216;
					continue;
				case 8u:
					num6 = 0;
					num = 27209071;
					continue;
				case 7u:
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: false);
					num = (int)(num2 * 950486048) ^ -1654211993;
					continue;
				case 5u:
					num = 117144848;
					continue;
				case 4u:
					storage[num5, num6] = new Figurine(num5 < 2, num6 % 2 == 0, num6 < 2, num5 % 2 == 1);
					num = ((int)num2 * -131209508) ^ 0x50CDD9EA;
					continue;
				case 3u:
					num5 = 0;
					num = ((int)num2 * -1941881760) ^ 0x30AA2925;
					continue;
				case 2u:
					Form1.smethod_5((Control)(object)borderBox[num5, num6], Color.White);
					num = ((int)num2 * -1231558957) ^ -1995850449;
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = -1025315679;
						num4 = -1025315679;
					}
					else
					{
						num3 = -747874984;
						num4 = -747874984;
					}
					num = num3 ^ ((int)num2 * -1514349364);
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

	private void Paint_Board()
	{
		Form1.smethod_20(pictureBox1, (Image)(object)Form1.smethod_19(Form1.smethod_18((Control)(object)pictureBox1), Form1.smethod_16((Control)(object)pictureBox1)));
		Graphics graphics_ = default(Graphics);
		Brush brush_ = default(Brush);
		float num6 = default(float);
		int num8 = default(int);
		int num11 = default(int);
		float num7 = default(float);
		bool big = default(bool);
		bool dark = default(bool);
		float num3 = default(float);
		bool flag2 = default(bool);
		bool flag = default(bool);
		float num5 = default(float);
		float num4 = default(float);
		bool square = default(bool);
		while (true)
		{
			int num = -988234206;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xBA5F3507u) % 39u)
				{
				case 38u:
					Form1.smethod_30((Control)(object)pictureBox1);
					num = ((int)num2 * -549030674) ^ -1781347515;
					continue;
				case 37u:
					Form1.smethod_24(graphics_, brush_, num6 + (float)(num8 * size), num6 + (float)(num11 * size), num7, num7);
					num = -1856888939;
					continue;
				case 36u:
					big = board[num11, num8].Big;
					num = -1635064865;
					continue;
				case 35u:
					Form1.smethod_24(graphics_, Form1.smethod_23(), ((float)num8 + 0.05f) * (float)size, ((float)num11 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					num = -5847916;
					continue;
				case 34u:
					num = ((int)num2 * -2080330310) ^ -986383938;
					continue;
				case 33u:
					dark = board[num11, num8].Dark;
					num = ((int)num2 * -1888713444) ^ -1484121808;
					continue;
				case 32u:
					num3 = 1f;
					num = ((int)num2 * -1699147680) ^ -1490656917;
					continue;
				case 31u:
					num = (int)((num2 * 711701312) ^ 0x448F8471);
					continue;
				case 30u:
					flag2 = num11 < 4;
					num = -983833490;
					continue;
				case 29u:
					num = (int)(num2 * 461624187) ^ -327606565;
					continue;
				case 28u:
					num = (int)(num2 * 669981664) ^ -1859554599;
					continue;
				case 27u:
					num = -959180386;
					continue;
				case 26u:
					flag = num8 < 4;
					num = -866220627;
					continue;
				case 25u:
				{
					int num14;
					int num15;
					if (board[num11, num8] != null)
					{
						num14 = 1569750056;
						num15 = 1569750056;
					}
					else
					{
						num14 = 1635052238;
						num15 = 1635052238;
					}
					num = num14 ^ ((int)num2 * -1509697435);
					continue;
				}
				case 24u:
					num = (int)(num2 * 1585858480) ^ -569695798;
					continue;
				case 23u:
					Form1.smethod_28(graphics_, brush_, num6 + (float)(num8 * size), num6 + (float)(num11 * size), num7, num7);
					num = (int)(num2 * 541239445) ^ -556185787;
					continue;
				case 22u:
				{
					int num22;
					int num23;
					if (big)
					{
						num22 = 1626840313;
						num23 = 1626840313;
					}
					else
					{
						num22 = 1748335751;
						num23 = 1748335751;
					}
					num = num22 ^ ((int)num2 * -1874661143);
					continue;
				}
				case 21u:
					num = ((int)num2 * -853122105) ^ 0x7D230111;
					continue;
				case 20u:
					num5 = 1f - num3 * 0.4f / (float)Form1.smethod_27(2.0);
					num6 = (float)size * (num5 / 2f);
					num = -723203467;
					continue;
				case 19u:
				{
					int num20;
					int num21;
					if (!flag2)
					{
						num20 = 1144396918;
						num21 = 1144396918;
					}
					else
					{
						num20 = 1755812453;
						num21 = 1755812453;
					}
					num = num20 ^ ((int)num2 * -1617234210);
					continue;
				}
				case 18u:
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox1));
					num = (int)(num2 * 836568026) ^ -142230984;
					continue;
				case 17u:
					num8++;
					num = (int)(num2 * 2005016706) ^ -916850755;
					continue;
				case 16u:
					num3 = 0.7f;
					num = -1369704359;
					continue;
				case 15u:
					Form1.smethod_24(graphics_, (Brush)(object)Form1.smethod_29(Color.FromArgb(180, Color.Peru)), num6 + (float)(num8 * size), num6 + (float)(num11 * size), num7, num7);
					num = (int)((num2 * 436368096) ^ 0x3B119F2A);
					continue;
				case 14u:
					brush_ = Form1.smethod_26();
					num = -159058389;
					continue;
				case 13u:
					brush_ = Form1.smethod_25();
					num = ((int)num2 * -1368807444) ^ -1818089949;
					continue;
				case 12u:
				{
					num7 = num4 * 0.4f / (float)Form1.smethod_27(2.0);
					int num18;
					int num19;
					if (!board[num11, num8].Point)
					{
						num18 = -813120452;
						num19 = -813120452;
					}
					else
					{
						num18 = -1864752801;
						num19 = -1864752801;
					}
					num = num18 ^ (int)(num2 * 56640547);
					continue;
				}
				case 11u:
					square = board[num11, num8].Square;
					num = ((int)num2 * -952006258) ^ 0x5E22E0D1;
					continue;
				case 10u:
					num11++;
					num = ((int)num2 * -1494368103) ^ -1197835188;
					continue;
				case 9u:
					num11 = 0;
					num = ((int)num2 * -1207982767) ^ -1473461193;
					continue;
				case 8u:
					num5 = 1f - num3 * 0.9f / (float)Form1.smethod_27(2.0);
					num = -80590441;
					continue;
				case 7u:
				{
					int num16;
					int num17;
					if (dark)
					{
						num16 = 1837353739;
						num17 = 1837353739;
					}
					else
					{
						num16 = 779917815;
						num17 = 779917815;
					}
					num = num16 ^ (int)(num2 * 37856870);
					continue;
				}
				case 4u:
				{
					int num12;
					int num13;
					if (square)
					{
						num12 = 1406686423;
						num13 = 1406686423;
					}
					else
					{
						num12 = 220342825;
						num13 = 220342825;
					}
					num = num12 ^ ((int)num2 * -201071837);
					continue;
				}
				case 3u:
				{
					int num9;
					int num10;
					if (flag)
					{
						num9 = -1404610377;
						num10 = -1404610377;
					}
					else
					{
						num9 = -789433399;
						num10 = -789433399;
					}
					num = num9 ^ ((int)num2 * -1146579150);
					continue;
				}
				case 2u:
					num8 = 0;
					num = -1632353777;
					continue;
				case 1u:
					num4 = (float)size * num3;
					num6 = (float)size * (num5 / 2f);
					num7 = num4 * 0.9f / (float)Form1.smethod_27(2.0);
					num = ((int)num2 * -2059735994) ^ 0x465143CA;
					continue;
				case 0u:
					num = -950158287;
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

	private void Paint_Storage()
	{
		int num6 = default(int);
		int num7 = default(int);
		float num10 = default(float);
		float num5 = default(float);
		Graphics graphics_ = default(Graphics);
		Brush brush_ = default(Brush);
		float num16 = default(float);
		float num18 = default(float);
		float num17 = default(float);
		bool flag3 = default(bool);
		bool flag2 = default(bool);
		bool flag4 = default(bool);
		bool point = default(bool);
		bool dark = default(bool);
		bool flag = default(bool);
		while (true)
		{
			int num = 139258541;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x11D8CD7Eu) % 38u)
				{
				case 37u:
					Form1.smethod_30((Control)(object)pictureBox[num6, num7]);
					num = 681085421;
					continue;
				case 36u:
				{
					int num13;
					if (storage[num6, num7].Big)
					{
						num = 1252042760;
						num13 = 1252042760;
					}
					else
					{
						num = 831934627;
						num13 = 831934627;
					}
					continue;
				}
				case 35u:
					num10 = 1f - num5 * 0.9f / (float)Form1.smethod_27(2.0);
					num = 1122302181;
					continue;
				case 34u:
					Form1.smethod_24(graphics_, brush_, num16, num16, num18, num18);
					num = 1482816674;
					continue;
				case 33u:
					num6 = 0;
					num = (int)((num2 * 145926980) ^ 0x1E7524C6);
					continue;
				case 32u:
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox[num6, num7]));
					num = (int)((num2 * 710802931) ^ 0x5807919B);
					continue;
				case 31u:
					num17 = (float)size * num5;
					num16 = (float)size * (num10 / 2f) - 4f;
					num = ((int)num2 * -1035850324) ^ -1869208455;
					continue;
				case 30u:
					num7 = 0;
					num = 866218250;
					continue;
				case 29u:
				{
					int num14;
					int num15;
					if (!flag3)
					{
						num14 = -1579946418;
						num15 = -1579946418;
					}
					else
					{
						num14 = -610743656;
						num15 = -610743656;
					}
					num = num14 ^ ((int)num2 * -202081028);
					continue;
				}
				case 28u:
					brush_ = Form1.smethod_25();
					num = ((int)num2 * -1010239184) ^ 0x35301629;
					continue;
				case 27u:
					num6++;
					num = (int)((num2 * 360631318) ^ 0x478817AC);
					continue;
				case 26u:
					num = (int)((num2 * 8057314) ^ 0x12C499);
					continue;
				case 25u:
					num5 = 0.7f;
					num = 400350269;
					continue;
				case 24u:
					brush_ = Form1.smethod_26();
					num = 2086781350;
					continue;
				case 23u:
					Form1.smethod_20(pictureBox[num6, num7], (Image)(object)Form1.smethod_19(Form1.smethod_18((Control)(object)pictureBox[num6, num7]), Form1.smethod_16((Control)(object)pictureBox[num6, num7])));
					num = ((int)num2 * -853044156) ^ 0x678EE4D2;
					continue;
				case 22u:
					num5 = 1f;
					num = ((int)num2 * -512616109) ^ 0x56A1656D;
					continue;
				case 21u:
				{
					int num21;
					int num22;
					if (flag2)
					{
						num21 = -997709323;
						num22 = -997709323;
					}
					else
					{
						num21 = -1376178005;
						num22 = -1376178005;
					}
					num = num21 ^ (int)(num2 * 1815570318);
					continue;
				}
				case 20u:
					flag4 = num7 < 4;
					num = 276926406;
					continue;
				case 19u:
					num = (int)(num2 * 1566093930) ^ -1958482505;
					continue;
				case 18u:
					Form1.smethod_24(graphics_, (Brush)(object)Form1.smethod_29(Color.FromArgb(180, Color.Peru)), num16, num16, num18, num18);
					num = ((int)num2 * -1653069074) ^ 0x50B24605;
					continue;
				case 17u:
					num18 = num17 * 0.9f / (float)Form1.smethod_27(2.0);
					flag3 = num7 < 2;
					num = ((int)num2 * -1217613619) ^ -2010092880;
					continue;
				case 15u:
					num7++;
					num = 1275921360;
					continue;
				case 14u:
				{
					int num19;
					int num20;
					if (!flag4)
					{
						num19 = 1810939823;
						num20 = 1810939823;
					}
					else
					{
						num19 = 466039132;
						num20 = 466039132;
					}
					num = num19 ^ ((int)num2 * -1338802381);
					continue;
				}
				case 13u:
					num = (int)((num2 * 35977676) ^ 0x71AE8C72);
					continue;
				case 12u:
					Form1.smethod_28(graphics_, brush_, num16, num16, num18, num18);
					num = (int)((num2 * 1983281223) ^ 0x4E2EF2B7);
					continue;
				case 11u:
					point = storage[num6, num7].Point;
					num = ((int)num2 * -1338526595) ^ 0x2491912F;
					continue;
				case 10u:
					num = ((int)num2 * -837206751) ^ 0x7EE1ED24;
					continue;
				case 9u:
					num = (int)((num2 * 931152585) ^ 0x3BB2EE20);
					continue;
				case 7u:
					dark = storage[num6, num7].Dark;
					num = (int)(num2 * 1318130355) ^ -2090241883;
					continue;
				case 6u:
					flag = num6 < 4;
					num = 463802747;
					continue;
				case 5u:
					num16 = (float)size * (num10 / 2f) - 4f;
					num18 = num17 * 0.4f / (float)Form1.smethod_27(2.0);
					num = (int)((num2 * 573494726) ^ 0x6B4EA087);
					continue;
				case 4u:
				{
					int num11;
					int num12;
					if (!point)
					{
						num11 = 1892520817;
						num12 = 1892520817;
					}
					else
					{
						num11 = 333545312;
						num12 = 333545312;
					}
					num = num11 ^ (int)(num2 * 2029901223);
					continue;
				}
				case 3u:
					num10 = 1f - num5 * 0.4f / (float)Form1.smethod_27(2.0);
					num = 1952314065;
					continue;
				case 2u:
					flag2 = storage[num6, num7] != null;
					num = 1928566075;
					continue;
				case 1u:
				{
					int num8;
					int num9;
					if (!flag)
					{
						num8 = -1951807818;
						num9 = -1951807818;
					}
					else
					{
						num8 = -57886564;
						num9 = -57886564;
					}
					num = num8 ^ ((int)num2 * -1098245660);
					continue;
				}
				case 0u:
				{
					int num3;
					int num4;
					if (!dark)
					{
						num3 = -1763137760;
						num4 = -1763137760;
					}
					else
					{
						num3 = -2033454704;
						num4 = -2033454704;
					}
					num = num3 ^ (int)(num2 * 1513389230);
					continue;
				}
				default:
					return;
				case 8u:
					break;
				case 16u:
					return;
				}
				break;
			}
		}
	}

	public void StartGame()
	{
		Form1_Load(this, Form1.smethod_31());
		if (turn)
		{
			goto IL_00fc;
		}
		goto IL_01ef;
		IL_01ef:
		int num = Form1.smethod_33(rnd, 4);
		int num2 = Form1.smethod_33(rnd, 4);
		Form1.smethod_5((Control)(object)borderBox[num, num2], Color.Blue);
		Form1.smethod_7((Control)(object)pictureBox1, bool_0: true);
		Form1.smethod_32((Control)(object)richTextBox1, "Противник выбрал фигуру. Выберете поле на доске для установки этой фигуры.");
		step = 1;
		int num3 = 1053206146;
		goto IL_0198;
		IL_0198:
		int num5 = default(int);
		int num6 = default(int);
		bool flag = default(bool);
		while (true)
		{
			uint num4;
			switch ((num4 = (uint)num3 ^ 0x55C9C15Cu) % 17u)
			{
			case 16u:
				num5++;
				num3 = ((int)num4 * -764111379) ^ -1893508471;
				continue;
			case 15u:
				num3 = ((int)num4 * -471592640) ^ -2095765694;
				continue;
			case 14u:
				Form1.smethod_7((Control)(object)pictureBox[num6, num5], bool_0: true);
				num3 = 1531925010;
				continue;
			case 11u:
				Form1.smethod_32((Control)(object)richTextBox1, "Ваш ход. Выберете фигуру, которой будет играть противник.");
				num3 = ((int)num4 * -950402626) ^ 0xB78A827;
				continue;
			case 10u:
				step = 0;
				num3 = ((int)num4 * -1049243571) ^ -135118600;
				continue;
			case 9u:
				num6 = 0;
				num3 = (int)(num4 * 1582319988) ^ -2116322359;
				continue;
			case 8u:
				num3 = ((int)num4 * -497053342) ^ 0x1FAD1B1F;
				continue;
			case 7u:
				time = new DateTime(0L, DateTimeKind.Unspecified);
				Form1.smethod_35(timer1, bool_0: true);
				num3 = ((int)num4 * -380618552) ^ -984653399;
				continue;
			case 6u:
				break;
			case 5u:
				Form1.smethod_32((Control)(object)label2, Form1.smethod_34("Ход: ", step.ToString()));
				num3 = 847983829;
				continue;
			case 4u:
				goto IL_012d;
			case 3u:
			{
				int num7;
				int num8;
				if (flag)
				{
					num7 = -133736045;
					num8 = -133736045;
				}
				else
				{
					num7 = -419726084;
					num8 = -419726084;
				}
				num3 = num7 ^ (int)(num4 * 1237747338);
				continue;
			}
			case 2u:
				num6++;
				num3 = ((int)num4 * -2043543721) ^ -1810635647;
				continue;
			case 1u:
				num5 = 0;
				num3 = 243900351;
				continue;
			case 0u:
				flag = num5 < 4;
				num3 = 715459230;
				continue;
			case 13u:
				goto IL_01ef;
			default:
				Form1.smethod_36(timer1);
				return;
			}
			break;
			IL_012d:
			int num9;
			if (num6 < 4)
			{
				num3 = 1818678650;
				num9 = 1818678650;
			}
			else
			{
				num3 = 700225948;
				num9 = 700225948;
			}
		}
		goto IL_00fc;
		IL_00fc:
		num3 = 1358328619;
		goto IL_0198;
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
		time = time.AddSeconds(1.0);
		Form1.smethod_32((Control)(object)label1, Form1.smethod_34("Время: ", time.ToString("HH:mm:ss")));
	}

	private void PictureBoxIJ_MouseDown(object sender, MouseEventArgs e)
	{
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Expected O, but got Unknown
		int num = Form1.smethod_37((Control)((sender is PictureBox) ? sender : null)).Y / size;
		int num2 = Form1.smethod_37((Control)((sender is PictureBox) ? sender : null)).X / size;
		int num9 = default(int);
		int num5 = default(int);
		bool flag2 = default(bool);
		bool flag3 = default(bool);
		bool flag = default(bool);
		while (true)
		{
			int num3 = -1495144393;
			while (true)
			{
				uint num4;
				int num8;
				switch ((num4 = (uint)num3 ^ 0xAFB7C3E4u) % 21u)
				{
				case 20u:
				{
					int num12;
					if (num9 >= 4)
					{
						num3 = -194892787;
						num12 = -194892787;
					}
					else
					{
						num3 = -908960327;
						num12 = -908960327;
					}
					continue;
				}
				case 18u:
					Form1.smethod_7((Control)(object)button2, bool_0: true);
					num3 = ((int)num4 * -153187917) ^ -327593568;
					continue;
				case 17u:
					Form1.smethod_5((Control)(object)borderBox[num9, num5], Color.White);
					num3 = -1816420107;
					continue;
				case 16u:
					Form1.smethod_32((Control)(object)richTextBox1, "Именно эта фигура? Если да - нажмите \"Подтвердить\".");
					num3 = (int)((num4 * 119217058) ^ 0x7B5E5359);
					continue;
				case 15u:
					num9++;
					num3 = ((int)num4 * -606011840) ^ -1066218660;
					continue;
				case 14u:
					num5++;
					num3 = (int)((num4 * 1558708552) ^ 0x7DF29183);
					continue;
				case 13u:
					if (storage[num, num2] != null)
					{
						num3 = -1790948995;
						continue;
					}
					num8 = 0;
					goto IL_010f;
				case 12u:
				{
					int num13;
					int num14;
					if (flag2)
					{
						num13 = 321715671;
						num14 = 321715671;
					}
					else
					{
						num13 = 855959353;
						num14 = 855959353;
					}
					num3 = num13 ^ (int)(num4 * 1412258772);
					continue;
				}
				case 11u:
					num8 = ((Form1.smethod_40((Bitmap)Form1.smethod_21(pictureBox[num, num2]), Form1.smethod_38(e), Form1.smethod_39(e)) != Color.FromArgb(0, 0, 0, 0)) ? 1 : 0);
					goto IL_010f;
				case 10u:
					num9 = 0;
					num3 = ((int)num4 * -2112164247) ^ -1127257295;
					continue;
				case 9u:
					num2 -= 4;
					num3 = (int)((num4 * 1133697485) ^ 0x3FA6D06E);
					continue;
				case 8u:
				{
					int num10;
					int num11;
					if (!flag3)
					{
						num10 = -1865630973;
						num11 = -1865630973;
					}
					else
					{
						num10 = -1418437098;
						num11 = -1418437098;
					}
					num3 = num10 ^ ((int)num4 * -1838163449);
					continue;
				}
				case 7u:
					num5 = 0;
					num3 = -1363903413;
					continue;
				case 6u:
					num3 = (int)((num4 * 1935567884) ^ 0x53513EB7);
					continue;
				case 5u:
					Form1.smethod_5((Control)(object)borderBox[num, num2], Color.Red);
					num3 = (int)(num4 * 1403526776) ^ -1000000288;
					continue;
				case 4u:
					flag2 = num2 > 1;
					num3 = (int)(num4 * 842831783) ^ -511278723;
					continue;
				case 3u:
				{
					int num6;
					int num7;
					if (!flag)
					{
						num6 = 531046433;
						num7 = 531046433;
					}
					else
					{
						num6 = 729382677;
						num7 = 729382677;
					}
					num3 = num6 ^ (int)(num4 * 1942608556);
					continue;
				}
				case 2u:
					num3 = ((int)num4 * -1314702658) ^ -341817251;
					continue;
				case 1u:
					flag = num5 < 4;
					num3 = -205155101;
					continue;
				default:
					return;
				case 19u:
					break;
				case 0u:
					return;
					IL_010f:
					flag3 = (byte)num8 != 0;
					num3 = -854784924;
					continue;
				}
				break;
			}
		}
	}

	private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
	{
		//IL_0318: Unknown result type (might be due to invalid IL or missing references)
		//IL_032e: Expected O, but got Unknown
		int num6 = default(int);
		Graphics graphics_ = default(Graphics);
		int num4 = default(int);
		int num5 = default(int);
		int num7 = default(int);
		bool flag = default(bool);
		while (true)
		{
			int num = -716445464;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0xA8936F8Cu) % 26u)
				{
				case 25u:
					Form1.smethod_7((Control)(object)button2, bool_0: true);
					num = ((int)num2 * -1557912103) ^ 0x6E0A9EC7;
					continue;
				case 24u:
					num = (int)(num2 * 2107411580) ^ -1678977663;
					continue;
				case 23u:
					num = (int)((num2 * 41652989) ^ 0x78F18DF1);
					continue;
				case 22u:
					Form1.smethod_32((Control)(object)richTextBox1, "Уверены? Для выполнения данного хода нажмите \"Подтвердить\".");
					num = ((int)num2 * -266622497) ^ -1855291935;
					continue;
				case 20u:
					num6++;
					num = (int)((num2 * 1014505253) ^ 0x5A67F59C);
					continue;
				case 19u:
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox1));
					num = ((int)num2 * -1171741925) ^ 0x4F3E0658;
					continue;
				case 18u:
					Form1.smethod_30((Control)(object)pictureBox1);
					num = ((int)num2 * -1897953557) ^ 0x27E1B0B2;
					continue;
				case 17u:
					num = (int)((num2 * 136339868) ^ 0x46BA9E80);
					continue;
				case 15u:
					Paint_Board();
					num = (int)(num2 * 1950937475) ^ -2072024352;
					continue;
				case 14u:
					num3 = ((board[num4, num5] == null) ? 1 : 0);
					goto IL_0104;
				case 13u:
				{
					int num12;
					if (!(Form1.smethod_41((Control)(object)borderBox[num6, num7]) == Color.Blue))
					{
						num = -1888401493;
						num12 = -1888401493;
					}
					else
					{
						num = -845963035;
						num12 = -845963035;
					}
					continue;
				}
				case 12u:
					num7 = 0;
					num = -1415960532;
					continue;
				case 11u:
					num7++;
					num = -1654729413;
					continue;
				case 10u:
					num = ((int)num2 * -2092415667) ^ -230261221;
					continue;
				case 9u:
					num = (int)((num2 * 1659113516) ^ 0x2EC364C2);
					continue;
				case 8u:
					num5 = Form1.smethod_38(e) / size;
					num4 = Form1.smethod_39(e) / size;
					num = ((int)num2 * -1397874380) ^ 0x66B03CF8;
					continue;
				case 7u:
					Form1.smethod_44(graphics_, Form1.smethod_21(pictureBox[num6, num7]), num5 * size + 4, num4 * size + 4, new Rectangle(0, 0, size, size), (GraphicsUnit)2);
					num = (int)(num2 * 2064313655) ^ -2110285750;
					continue;
				case 6u:
					Form1.smethod_45(graphics_);
					num = (int)(num2 * 385375036) ^ -303362861;
					continue;
				case 5u:
				{
					int num10;
					int num11;
					if (flag)
					{
						num10 = -1584303768;
						num11 = -1584303768;
					}
					else
					{
						num10 = -650424065;
						num11 = -650424065;
					}
					num = num10 ^ (int)(num2 * 559609708);
					continue;
				}
				case 4u:
				{
					int num9;
					if (num6 < 4)
					{
						num = -862760834;
						num9 = -862760834;
					}
					else
					{
						num = -799065565;
						num9 = -799065565;
					}
					continue;
				}
				case 3u:
				{
					int num8;
					if (num7 >= 4)
					{
						num = -74191522;
						num8 = -74191522;
					}
					else
					{
						num = -690469213;
						num8 = -690469213;
					}
					continue;
				}
				case 2u:
					num6 = 0;
					num = (int)(num2 * 929333595) ^ -1526711161;
					continue;
				case 1u:
					Form1.smethod_43(graphics_, Form1.smethod_42(Color.Red, 3f), ((float)num5 + 0.05f) * (float)size, ((float)num4 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					num = ((int)num2 * -1747277707) ^ -1706185746;
					continue;
				case 0u:
					if (Form1.smethod_40((Bitmap)Form1.smethod_21(pictureBox1), Form1.smethod_38(e), Form1.smethod_39(e)) != Color.FromArgb(0, 0, 0, 0))
					{
						num = ((int)num2 * -1705582721) ^ 0x4035E5E6;
						continue;
					}
					num3 = 0;
					goto IL_0104;
				default:
					return;
				case 16u:
					break;
				case 21u:
					return;
					IL_0104:
					flag = (byte)num3 != 0;
					num = -198382375;
					continue;
				}
				break;
			}
		}
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		//IL_0fac: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fda: Expected O, but got Unknown
		int num26 = default(int);
		int num27 = default(int);
		int num24 = default(int);
		int num38 = default(int);
		int num29 = default(int);
		bool flag5 = default(bool);
		int num10 = default(int);
		Graphics graphics_ = default(Graphics);
		int num28 = default(int);
		int num23 = default(int);
		int num8 = default(int);
		bool flag10 = default(bool);
		int num31 = default(int);
		int num4 = default(int);
		int num17 = default(int);
		int num9 = default(int);
		int num3 = default(int);
		int num14 = default(int);
		int num15 = default(int);
		bool flag3 = default(bool);
		bool flag2 = default(bool);
		Figurine[,] array = default(Figurine[,]);
		int num6 = default(int);
		Figurine[,] array3 = default(Figurine[,]);
		int num32 = default(int);
		int num39 = default(int);
		bool flag9 = default(bool);
		Figurine[,] array2 = default(Figurine[,]);
		int num16 = default(int);
		bool flag = default(bool);
		bool flag6 = default(bool);
		bool flag7 = default(bool);
		int num18 = default(int);
		bool flag4 = default(bool);
		bool flag8 = default(bool);
		while (true)
		{
			int num = -1395534826;
			while (true)
			{
				uint num2;
				int num7;
				int num52;
				int num47;
				int num49;
				switch ((num2 = (uint)num ^ 0xB36B5443u) % 161u)
				{
				case 160u:
				{
					int num40;
					int num41;
					if (board[num26, num27] == null)
					{
						num40 = -1574466715;
						num41 = -1574466715;
					}
					else
					{
						num40 = -375704703;
						num41 = -375704703;
					}
					num = num40 ^ (int)(num2 * 1178004052);
					continue;
				}
				case 159u:
					num = ((int)num2 * -435900165) ^ -1292559514;
					continue;
				case 158u:
					num = ((int)num2 * -1298465040) ^ 0x778EABC1;
					continue;
				case 157u:
					num = -1862618668;
					continue;
				case 156u:
					num = ((int)num2 * -1536051140) ^ -1514982801;
					continue;
				case 155u:
					num24++;
					num = (int)(num2 * 2121938086) ^ -1167143481;
					continue;
				case 154u:
					if (num38 == num29)
					{
						goto IL_00a3;
					}
					goto IL_00af;
				case 153u:
				{
					int num21;
					int num22;
					if (!flag5)
					{
						num21 = -850165570;
						num22 = -850165570;
					}
					else
					{
						num21 = -1402923875;
						num22 = -1402923875;
					}
					num = num21 ^ (int)(num2 * 1128832642);
					continue;
				}
				case 152u:
					num10++;
					num = -1096569833;
					continue;
				case 151u:
					Form1.smethod_44(graphics_, Form1.smethod_21(pictureBox[num28, num29]), num10 * size + 4, num23 * size + 4, new Rectangle(0, 0, size, size), (GraphicsUnit)2);
					num = ((int)num2 * -1233859326) ^ -847915301;
					continue;
				case 150u:
					Form1.smethod_20(pictureBox[num28, num29], (Image)null);
					Form1.smethod_30((Control)(object)pictureBox[num28, num29]);
					num = ((int)num2 * -1768629194) ^ 0x5A1EDBE2;
					continue;
				case 149u:
					num8++;
					num = ((int)num2 * -4207320) ^ -569514656;
					continue;
				case 148u:
				{
					int num54;
					int num55;
					if (!flag10)
					{
						num54 = -329986861;
						num55 = -329986861;
					}
					else
					{
						num54 = -494249722;
						num55 = -494249722;
					}
					num = num54 ^ ((int)num2 * -146288352);
					continue;
				}
				case 147u:
					Form1.smethod_47(1000);
					num = ((int)num2 * -1611609296) ^ -55422654;
					continue;
				case 146u:
					Form1.smethod_7((Control)(object)pictureBox[num31, num4], bool_0: true);
					num = -1904066086;
					continue;
				case 145u:
					num17 = num24;
					num = ((int)num2 * -1775571953) ^ -1382695834;
					continue;
				case 144u:
					num29 = num9;
					num = ((int)num2 * -2112950152) ^ 0x79F27A9D;
					continue;
				case 143u:
				{
					int num48;
					if (num31 < 4)
					{
						num = -1028047405;
						num48 = -1028047405;
					}
					else
					{
						num = -649658975;
						num48 = -649658975;
					}
					continue;
				}
				case 142u:
					num = -257394832;
					continue;
				case 141u:
					flag10 = num8 < 4;
					num = -2045822081;
					continue;
				case 140u:
					Form1.smethod_5((Control)(object)borderBox[num3, num24], Color.White);
					num = ((int)num2 * -1204262252) ^ -2077501655;
					continue;
				case 139u:
					num31 = 0;
					num = ((int)num2 * -1303478064) ^ -1378368816;
					continue;
				case 138u:
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: true);
					num = (int)(num2 * 1587612768) ^ -1987000830;
					continue;
				case 137u:
					num17 = 0;
					num14 = 0;
					num15 = 0;
					num3 = 0;
					num = (int)((num2 * 1862184905) ^ 0x548F53C7);
					continue;
				case 136u:
					num = (int)((num2 * 1085698909) ^ 0x607F6DD0);
					continue;
				case 135u:
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox1));
					num23 = 0;
					num = ((int)num2 * -774622776) ^ 0x6F0D3F14;
					continue;
				case 133u:
					num3++;
					num = ((int)num2 * -328666751) ^ 0x51E1ED64;
					continue;
				case 132u:
				{
					int num35;
					int num36;
					if (flag3)
					{
						num35 = -2083937150;
						num36 = -2083937150;
					}
					else
					{
						num35 = -991731527;
						num36 = -991731527;
					}
					num = num35 ^ (int)(num2 * 1993944432);
					continue;
				}
				case 131u:
					num = (int)((num2 * 91049373) ^ 0x3C4CF4A5);
					continue;
				case 130u:
					num = (int)(num2 * 449356340) ^ -968625735;
					continue;
				case 129u:
					step++;
					Form1.smethod_32((Control)(object)label2, Form1.smethod_34("Ход: ", step.ToString()));
					num = (int)((num2 * 1707804893) ^ 0x6DA820B8);
					continue;
				case 128u:
					num = ((int)num2 * -727851821) ^ -2109428635;
					continue;
				case 127u:
					num23++;
					num = ((int)num2 * -878666675) ^ -533850373;
					continue;
				case 126u:
					Form1.smethod_30((Control)(object)pictureBox[num3, num24]);
					num = (int)(num2 * 1904811708) ^ -2088587022;
					continue;
				case 125u:
					num = ((int)num2 * -1746086741) ^ 0x25221DEB;
					continue;
				case 124u:
					num31++;
					num = ((int)num2 * -1769927272) ^ -923948992;
					continue;
				case 123u:
					Form1.smethod_32((Control)(object)richTextBox1, "QUARTO! Компьютер выиграл!");
					num = -407664382;
					continue;
				case 122u:
					Form1.smethod_30((Control)(object)richTextBox1);
					num = (int)(num2 * 874033243) ^ -1552945396;
					continue;
				case 121u:
				{
					int num12;
					int num13;
					if (flag2)
					{
						num12 = -1806341726;
						num13 = -1806341726;
					}
					else
					{
						num12 = -1137425250;
						num13 = -1137425250;
					}
					num = num12 ^ (int)(num2 * 1230378996);
					continue;
				}
				case 120u:
					num7 = (Standoff(array) ? 1 : 0);
					goto IL_04bf;
				case 119u:
					num6++;
					num = -856406639;
					continue;
				case 118u:
				{
					int num58;
					int num59;
					if (!Form1.smethod_46((Control)(object)pictureBox1))
					{
						num58 = -1251610597;
						num59 = -1251610597;
					}
					else
					{
						num58 = -461963047;
						num59 = -461963047;
					}
					num = num58 ^ (int)(num2 * 1968689292);
					continue;
				}
				case 117u:
					Form1.smethod_20(pictureBox[num28, num29], (Image)null);
					Form1.smethod_30((Control)(object)pictureBox[num28, num29]);
					num = ((int)num2 * -1065068438) ^ -1542166775;
					continue;
				case 116u:
					array3[num26, num27] = new Figurine(storage[num28, num29]);
					num32 = 0;
					num = (int)(num2 * 1778020461) ^ -1653343172;
					continue;
				case 115u:
					num39 = Form1.smethod_33(rnd, 4);
					num38 = Form1.smethod_33(rnd, 4);
					num = -1490112803;
					continue;
				case 114u:
				{
					int num56;
					int num57;
					if (!flag9)
					{
						num56 = -1833313215;
						num57 = -1833313215;
					}
					else
					{
						num56 = -1688599095;
						num57 = -1688599095;
					}
					num = num56 ^ ((int)num2 * -672684484);
					continue;
				}
				case 113u:
					array3 = (Figurine[,])Form1.smethod_48((Array)board);
					num = (int)(num2 * 699819919) ^ -1000425692;
					continue;
				case 112u:
					Form1.smethod_30((Control)(object)label2);
					num = (int)((num2 * 204692089) ^ 0x3045269B);
					continue;
				case 111u:
					array2 = (Figurine[,])Form1.smethod_48((Array)array3);
					num = (int)((num2 * 1553847326) ^ 0x704CFC22);
					continue;
				case 110u:
					num4 = 0;
					num = -1354426778;
					continue;
				case 109u:
					num9++;
					num = ((int)num2 * -1775942106) ^ -800943107;
					continue;
				case 108u:
					Form1.smethod_5((Control)(object)borderBox[num28, num29], Color.White);
					Form1.smethod_30((Control)(object)borderBox[num28, num29]);
					num = ((int)num2 * -914900494) ^ -1522745795;
					continue;
				case 107u:
				{
					int num53;
					if (num6 >= 4)
					{
						num = -1543516878;
						num53 = -1543516878;
					}
					else
					{
						num = -1111748693;
						num53 = -1111748693;
					}
					continue;
				}
				case 106u:
					(menu as Form3).ContinueLock();
					num = (int)((num2 * 110862190) ^ 0x23C61BD2);
					continue;
				case 105u:
					if (!Standoff(board))
					{
						num = -199001572;
						num52 = -199001572;
						continue;
					}
					goto IL_06ee;
				case 104u:
					num = -1049173385;
					continue;
				case 103u:
					num16 = 0;
					num = ((int)num2 * -123865379) ^ -101981731;
					continue;
				case 102u:
					Form1.smethod_47(200);
					num = ((int)num2 * -548255639) ^ 0x42E05C4E;
					continue;
				case 101u:
					storage[num28, num29] = null;
					num = ((int)num2 * -1826382010) ^ 0x63D3FF67;
					continue;
				case 100u:
				{
					int num50;
					int num51;
					if (flag)
					{
						num50 = 2002219227;
						num51 = 2002219227;
					}
					else
					{
						num50 = 516582182;
						num51 = 516582182;
					}
					num = num50 ^ ((int)num2 * -424627381);
					continue;
				}
				case 99u:
					num29 = 0;
					num8 = 0;
					num = ((int)num2 * -526345009) ^ 0x7DDA264D;
					continue;
				case 98u:
					num14 = num3;
					num15 = num24;
					num = (int)((num2 * 1850739404) ^ 0x4AA39DEE);
					continue;
				case 97u:
					if (!flag6)
					{
						num = (int)(num2 * 720742773) ^ -1051339095;
						continue;
					}
					goto IL_07eb;
				case 96u:
					Form1.smethod_30((Control)(object)borderBox[num3, num24]);
					num = ((int)num2 * -155189379) ^ -473686553;
					continue;
				case 95u:
					num = -2034927701;
					continue;
				case 94u:
					Form1.smethod_30((Control)(object)pictureBox1);
					num = (int)((num2 * 1955510453) ^ 0x36EB388C);
					continue;
				case 93u:
					flag7 = num23 < 4;
					num = -835275793;
					continue;
				case 92u:
					num9 = 0;
					num = -1682019746;
					continue;
				case 91u:
					if (storage[num39, num38] != null)
					{
						num = ((int)num2 * -586054489) ^ -97488992;
						continue;
					}
					goto IL_00a3;
				case 90u:
					Form1.smethod_32((Control)(object)richTextBox1, "Выберете фигуру, которой будет играть противник.");
					num = (int)(num2 * 1596659569) ^ -1967717610;
					continue;
				case 88u:
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: false);
					num = (int)((num2 * 312431572) ^ 0x415D4DE5);
					continue;
				case 87u:
					if (num18 >= 9)
					{
						num = -588915792;
						num47 = -588915792;
						continue;
					}
					goto IL_07eb;
				case 86u:
					Form1.smethod_5((Control)(object)borderBox[num28, num29], Color.White);
					Form1.smethod_30((Control)(object)borderBox[num28, num29]);
					num = (int)((num2 * 1376875029) ^ 0x54562968);
					continue;
				case 85u:
					Form1.smethod_32((Control)(object)richTextBox1, "Ничья!");
					num = (int)((num2 * 1169240273) ^ 0x69A9581F);
					continue;
				case 84u:
					array[num23, num10] = new Figurine(storage[num28, num29]);
					num = (int)((num2 * 1856762041) ^ 0x3C6D7235);
					continue;
				case 83u:
					num = (int)((num2 * 2141563576) ^ 0x78E27552);
					continue;
				case 82u:
					Form1.smethod_5((Control)(object)borderBox[num8, num9], Color.LimeGreen);
					num = (int)(num2 * 573774427) ^ -173229635;
					continue;
				case 81u:
					flag4 = array3[num32, num6] == null;
					num = -1135870146;
					continue;
				case 80u:
					Form1.smethod_30((Control)(object)borderBox[num8, num9]);
					num = (int)(num2 * 561059456) ^ -648365702;
					continue;
				case 79u:
					num = ((int)num2 * -976726145) ^ -276059059;
					continue;
				case 78u:
					Form1.smethod_7((Control)(object)pictureBox[num8, num9], bool_0: false);
					num = (int)(num2 * 344886505) ^ -1638185725;
					continue;
				case 77u:
					flag8 = num32 < 4;
					num = -1582119235;
					continue;
				case 76u:
					num16 = num3;
					num = (int)(num2 * 445262542) ^ -618493805;
					continue;
				case 75u:
				{
					int num46;
					if (board[num23, num10] == null)
					{
						num = -2098223745;
						num46 = -2098223745;
					}
					else
					{
						num = -2056375305;
						num46 = -2056375305;
					}
					continue;
				}
				case 74u:
					array2[num32, num6] = new Figurine(storage[num39, num38]);
					flag9 = Stop(array2);
					num = (int)((num2 * 1246670169) ^ 0x4CE25939);
					continue;
				case 73u:
					num24 = 0;
					num = -1601798067;
					continue;
				case 72u:
				{
					int num44;
					int num45;
					if (flag8)
					{
						num44 = -1130956438;
						num45 = -1130956438;
					}
					else
					{
						num44 = -906029638;
						num45 = -906029638;
					}
					num = num44 ^ (int)(num2 * 1961924186);
					continue;
				}
				case 71u:
					num = ((int)num2 * -221812303) ^ 0x55772F52;
					continue;
				case 70u:
					Form1.smethod_30((Control)(object)pictureBox1);
					Form1.smethod_47(200);
					num = (int)((num2 * 1336541270) ^ 0x2B66521F);
					continue;
				case 69u:
					num = (int)(num2 * 821691400) ^ -1329785958;
					continue;
				case 68u:
					Form1.smethod_30((Control)(object)borderBox[num39, num38]);
					num = (int)((num2 * 1280959083) ^ 0x7AE9E41F);
					continue;
				case 67u:
					num = ((int)num2 * -195622217) ^ 0x42EE0B0F;
					continue;
				case 66u:
					flag5 = Standoff(board);
					num = ((int)num2 * -863699421) ^ -1220837505;
					continue;
				case 65u:
					num = ((int)num2 * -933826195) ^ -1490553382;
					continue;
				case 64u:
					flag6 = true;
					num = ((int)num2 * -814509081) ^ 0x157D2747;
					continue;
				case 63u:
				{
					int num42;
					int num43;
					if (!flag7)
					{
						num42 = -1693106384;
						num43 = -1693106384;
					}
					else
					{
						num42 = -558920123;
						num43 = -558920123;
					}
					num = num42 ^ (int)(num2 * 2125188016);
					continue;
				}
				case 62u:
					Form1.smethod_20(pictureBox[num3, num24], (Image)null);
					num = (int)(num2 * 1429938590) ^ -1771120761;
					continue;
				case 61u:
					num = (int)((num2 * 436156668) ^ 0x15D0ED72);
					continue;
				case 60u:
					num6 = 0;
					num = -856406639;
					continue;
				case 59u:
					board[num23, num10] = new Figurine(storage[num28, num29]);
					num = ((int)num2 * -1360129113) ^ 0x70264C70;
					continue;
				case 58u:
					num28 = num8;
					num = (int)(num2 * 2146708194) ^ -1671964134;
					continue;
				case 57u:
					if (num39 == num28)
					{
						num = ((int)num2 * -1219736193) ^ 0x588D00F4;
						continue;
					}
					goto IL_00af;
				case 56u:
					Form1.smethod_5((Control)(object)borderBox[num39, num38], Color.Blue);
					num = (int)(num2 * 34952808) ^ -1398252657;
					continue;
				case 55u:
					num28 = 0;
					num = (int)(num2 * 1092032817) ^ -1966698055;
					continue;
				case 54u:
				{
					int num37;
					if (!Standoff(board))
					{
						num = -873007500;
						num37 = -873007500;
					}
					else
					{
						num = -658706153;
						num37 = -658706153;
					}
					continue;
				}
				case 53u:
					num = ((int)num2 * -891082164) ^ -532159073;
					continue;
				case 52u:
					num = (int)((num2 * 2106745767) ^ 0x7EC0327);
					continue;
				case 51u:
					if (!Stop(array))
					{
						num = ((int)num2 * -555727594) ^ -1193132439;
						continue;
					}
					num7 = 1;
					goto IL_04bf;
				case 50u:
					num4++;
					num = ((int)num2 * -206573764) ^ -1865866981;
					continue;
				case 49u:
				{
					int num34;
					if (num9 < 4)
					{
						num = -2008988103;
						num34 = -2008988103;
					}
					else
					{
						num = -2129669285;
						num34 = -2129669285;
					}
					continue;
				}
				case 48u:
					Form1.smethod_43(graphics_, Form1.smethod_42(Color.LimeGreen, 3f), ((float)num27 + 0.05f) * (float)size, ((float)num26 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					Form1.smethod_44(graphics_, Form1.smethod_21(pictureBox[num28, num29]), num27 * size + 4, num26 * size + 4, new Rectangle(0, 0, size, size), (GraphicsUnit)2);
					num = (int)((num2 * 435321312) ^ 0x6AC512F8);
					continue;
				case 47u:
					num = (int)(num2 * 714136938) ^ -401996294;
					continue;
				case 46u:
					storage[num16, num17] = null;
					Paint_Board();
					if (!Stop(board))
					{
						num = (int)(num2 * 30507029) ^ -617658298;
						continue;
					}
					goto IL_06ee;
				case 45u:
					num = -2056375305;
					continue;
				case 44u:
					num = ((int)num2 * -1029223266) ^ 0x2A1B3EA8;
					continue;
				case 43u:
					num = (int)(num2 * 1910005676) ^ -1610352179;
					continue;
				case 42u:
					num = (int)((num2 * 242367668) ^ 0x789D4520);
					continue;
				case 41u:
				{
					int num33;
					if (num24 >= 4)
					{
						num = -1563713498;
						num33 = -1563713498;
					}
					else
					{
						num = -1456110324;
						num33 = -1456110324;
					}
					continue;
				}
				case 40u:
					num18++;
					flag6 = false;
					num = -289553283;
					continue;
				case 39u:
					num = ((int)num2 * -1267955962) ^ -639609710;
					continue;
				case 38u:
					(menu as Form3).ContinueLock();
					num = (int)(num2 * 202439974) ^ -1419248356;
					continue;
				case 37u:
					num = (int)((num2 * 16751834) ^ 0x255179EC);
					continue;
				case 36u:
					num32++;
					num = (int)((num2 * 21107359) ^ 0x567DE32A);
					continue;
				case 35u:
					num = ((int)num2 * -174929590) ^ 0x4487ED67;
					continue;
				case 34u:
					storage[num28, num29] = null;
					num = ((int)num2 * -698901759) ^ -1214352173;
					continue;
				case 33u:
				{
					int num30;
					if (!(Form1.smethod_40((Bitmap)Form1.smethod_21(pictureBox1), num24 * size + size / 2, (int)(((float)num3 + 0.05f) * (float)size)) == Color.FromArgb(255, 255, 0, 0)))
					{
						num = -1886198966;
						num30 = -1886198966;
					}
					else
					{
						num = -1932215436;
						num30 = -1932215436;
					}
					continue;
				}
				case 32u:
					num26 = Form1.smethod_33(rnd, 4);
					num27 = Form1.smethod_33(rnd, 4);
					num = -1644041621;
					continue;
				case 31u:
					Form1.smethod_32((Control)(object)richTextBox1, "Противник сделал ход (зелёный). Выберете поле на доске для выбронной противником фигуры (синий).");
					num = ((int)num2 * -186064454) ^ -1477574798;
					continue;
				case 30u:
					board[num26, num27] = new Figurine(storage[num28, num29]);
					num = ((int)num2 * -1847579659) ^ 0x87296D0;
					continue;
				case 29u:
					num = -1314971402;
					continue;
				case 28u:
					num = ((int)num2 * -1819915384) ^ 0x194C6177;
					continue;
				case 27u:
					array = (Figurine[,])Form1.smethod_48((Array)board);
					num = ((int)num2 * -1594647855) ^ 0x77A1D7E6;
					continue;
				case 26u:
					num = (int)(num2 * 100578981) ^ -59127319;
					continue;
				case 25u:
					step++;
					Form1.smethod_32((Control)(object)label2, Form1.smethod_34("Ход: ", step.ToString()));
					num = (int)((num2 * 1546311604) ^ 0x94DBE2B);
					continue;
				case 24u:
					num10 = 0;
					num = -33059911;
					continue;
				case 23u:
				{
					int num25;
					if (!(Form1.smethod_41((Control)(object)borderBox[num3, num24]) == Color.Blue))
					{
						num = -1937074850;
						num25 = -1937074850;
					}
					else
					{
						num = -1346228620;
						num25 = -1346228620;
					}
					continue;
				}
				case 22u:
					Form1.smethod_43(graphics_, Form1.smethod_42(Color.LimeGreen, 3f), ((float)num10 + 0.05f) * (float)size, ((float)num23 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					num = (int)((num2 * 1514293880) ^ 0x3298E1C0);
					continue;
				case 21u:
					Form1.smethod_32((Control)(object)richTextBox1, "Ничья!");
					num = ((int)num2 * -1663882616) ^ -1653653619;
					continue;
				case 20u:
				{
					int num19;
					int num20;
					if (!flag4)
					{
						num19 = -1229263157;
						num20 = -1229263157;
					}
					else
					{
						num19 = -338163864;
						num20 = -338163864;
					}
					num = num19 ^ (int)(num2 * 723043436);
					continue;
				}
				case 19u:
					num18 = 0;
					num = (int)(num2 * 484973750) ^ -93655298;
					continue;
				case 18u:
					num = ((int)num2 * -1030484144) ^ -97422375;
					continue;
				case 17u:
					board[num14, num15] = new Figurine(storage[num16, num17]);
					num = (int)((num2 * 179331794) ^ 0x580A6D6D);
					continue;
				case 16u:
					num = (int)(num2 * 1787902342) ^ -1257430221;
					continue;
				case 15u:
					num = ((int)num2 * -361427946) ^ -725022191;
					continue;
				case 14u:
					num = ((int)num2 * -1113217952) ^ 0x8D189D7;
					continue;
				case 13u:
					Form1.smethod_7((Control)(object)button2, bool_0: false);
					num = ((int)num2 * -1307260977) ^ 0x5EBDDB1B;
					continue;
				case 12u:
				{
					int num11;
					if (num10 < 4)
					{
						num = -597603333;
						num11 = -597603333;
					}
					else
					{
						num = -1031195648;
						num11 = -1031195648;
					}
					continue;
				}
				case 11u:
					Form1.smethod_15(timer1);
					num = -505444669;
					continue;
				case 10u:
					flag2 = Form1.smethod_41((Control)(object)borderBox[num8, num9]) == Color.Red;
					num = ((int)num2 * -453309802) ^ 0x451E97BF;
					continue;
				case 9u:
					num = -919238822;
					continue;
				case 8u:
					num = -1613288577;
					continue;
				case 7u:
					Form1.smethod_32((Control)(object)richTextBox1, "Подождите, компьютер делает свой ход.");
					num = ((int)num2 * -514268781) ^ -1077903365;
					continue;
				case 6u:
					num = ((int)num2 * -1622136807) ^ 0x7E9745A5;
					continue;
				case 5u:
					num = (int)((num2 * 1179239559) ^ 0xC52F74C);
					continue;
				case 4u:
				{
					int num5;
					if (num4 < 4)
					{
						num = -1177554744;
						num5 = -1177554744;
					}
					else
					{
						num = -1388082585;
						num5 = -1388082585;
					}
					continue;
				}
				case 3u:
					flag = num3 < 4;
					num = -1809082902;
					continue;
				case 2u:
					num = (int)(num2 * 1563819669) ^ -1685393977;
					continue;
				case 1u:
					Form1.smethod_15(timer1);
					num = ((int)num2 * -494976348) ^ 0x141FBB0B;
					continue;
				case 0u:
					num = ((int)num2 * -1107799501) ^ 0x64B98E53;
					continue;
				default:
					return;
				case 89u:
					break;
				case 134u:
					return;
					IL_04bf:
					flag3 = (byte)num7 != 0;
					num = -1796459651;
					continue;
					IL_00a3:
					num = -1526629223;
					num49 = -1526629223;
					continue;
					IL_07eb:
					num = -445906756;
					num47 = -445906756;
					continue;
					IL_00af:
					num = -78754091;
					num49 = -78754091;
					continue;
					IL_06ee:
					num = -670447140;
					num52 = -670447140;
					continue;
				}
				break;
			}
		}
	}

	private bool Stop(Figurine[,] mem)
	{
		int num3 = default(int);
		bool flag2 = default(bool);
		bool flag = default(bool);
		bool result = default(bool);
		while (true)
		{
			int num = -527096204;
			while (true)
			{
				uint num2;
				int num9;
				int num49;
				switch ((num2 = (uint)num ^ 0xECED8801u) % 78u)
				{
				case 77u:
				{
					int num56;
					if (mem[num3, 0].Square != mem[num3, 1].Square)
					{
						num = -934457;
						num56 = -934457;
					}
					else
					{
						num = -2055385115;
						num56 = -2055385115;
					}
					continue;
				}
				case 76u:
					if (mem[0, num3] != null)
					{
						num = -1227463564;
						continue;
					}
					goto IL_0061;
				case 75u:
				{
					int num23;
					int num24;
					if (mem[num3, 0] == null)
					{
						num23 = 1883448469;
						num24 = 1883448469;
					}
					else
					{
						num23 = 2128929102;
						num24 = 2128929102;
					}
					num = num23 ^ ((int)num2 * -2073197366);
					continue;
				}
				case 74u:
				{
					int num35;
					int num36;
					if (mem[num3, 2] == null)
					{
						num35 = -1944177035;
						num36 = -1944177035;
					}
					else
					{
						num35 = -1684267118;
						num36 = -1684267118;
					}
					num = num35 ^ ((int)num2 * -1548163129);
					continue;
				}
				case 73u:
					if (mem[0, 3] != null)
					{
						num = -751418335;
						continue;
					}
					goto IL_00e3;
				case 72u:
				{
					int num47;
					int num48;
					if (mem[1, 1].Big != mem[2, 2].Big)
					{
						num47 = 182161906;
						num48 = 182161906;
					}
					else
					{
						num47 = 1993149131;
						num48 = 1993149131;
					}
					num = num47 ^ ((int)num2 * -1654649677);
					continue;
				}
				case 71u:
				{
					int num14;
					int num15;
					if (mem[1, 2].Point != mem[2, 1].Point)
					{
						num14 = -563733810;
						num15 = -563733810;
					}
					else
					{
						num14 = -1329246111;
						num15 = -1329246111;
					}
					num = num14 ^ ((int)num2 * -948820299);
					continue;
				}
				case 70u:
				{
					int num68;
					if (mem[0, 3].Dark == mem[1, 2].Dark)
					{
						num = -1899614235;
						num68 = -1899614235;
					}
					else
					{
						num = -1555077996;
						num68 = -1555077996;
					}
					continue;
				}
				case 69u:
				{
					int num61;
					int num62;
					if (mem[1, num3].Dark != mem[2, num3].Dark)
					{
						num61 = 614456179;
						num62 = 614456179;
					}
					else
					{
						num61 = 811076341;
						num62 = 811076341;
					}
					num = num61 ^ (int)(num2 * 104684032);
					continue;
				}
				case 68u:
					if (mem[2, num3] != null)
					{
						num = ((int)num2 * -1432280400) ^ 0x27896263;
						continue;
					}
					goto IL_0061;
				case 67u:
					if (mem[2, num3].Square == mem[3, num3].Square)
					{
						goto IL_0055;
					}
					goto IL_0061;
				case 66u:
				{
					int num31;
					if (mem[0, num3].Dark != mem[1, num3].Dark)
					{
						num = -1069846157;
						num31 = -1069846157;
					}
					else
					{
						num = -14174392;
						num31 = -14174392;
					}
					continue;
				}
				case 65u:
				{
					int num7;
					int num8;
					if (mem[1, 1] != null)
					{
						num7 = 1610507216;
						num8 = 1610507216;
					}
					else
					{
						num7 = 9878839;
						num8 = 9878839;
					}
					num = num7 ^ ((int)num2 * -1500504087);
					continue;
				}
				case 64u:
				{
					int num65;
					int num66;
					if (mem[0, 3].Big == mem[1, 2].Big)
					{
						num65 = 1372518846;
						num66 = 1372518846;
					}
					else
					{
						num65 = 1895118213;
						num66 = 1895118213;
					}
					num = num65 ^ (int)(num2 * 1619734917);
					continue;
				}
				case 63u:
					num = (int)((num2 * 951589948) ^ 0x53553BD4);
					continue;
				case 62u:
				{
					int num59;
					int num60;
					if (mem[num3, 1].Point == mem[num3, 2].Point)
					{
						num59 = -2093655781;
						num60 = -2093655781;
					}
					else
					{
						num59 = -1019963396;
						num60 = -1019963396;
					}
					num = num59 ^ ((int)num2 * -2011036266);
					continue;
				}
				case 61u:
				{
					int num41;
					int num42;
					if (mem[num3, 3] == null)
					{
						num41 = -1542506592;
						num42 = -1542506592;
					}
					else
					{
						num41 = -1579501103;
						num42 = -1579501103;
					}
					num = num41 ^ ((int)num2 * -2106649209);
					continue;
				}
				case 60u:
					if (mem[num3, 2].Dark != mem[num3, 3].Dark)
					{
						num = (int)((num2 * 1705249317) ^ 0x7AA2DD2E);
						continue;
					}
					goto IL_0055;
				case 59u:
				{
					int num38;
					if (mem[num3, 0].Point == mem[num3, 1].Point)
					{
						num = -236583609;
						num38 = -236583609;
					}
					else
					{
						num = -219696392;
						num38 = -219696392;
					}
					continue;
				}
				case 58u:
					flag2 = true;
					num = (int)((num2 * 1021175841) ^ 0x5D4D17BB);
					continue;
				case 57u:
					if (mem[2, 1].Dark != mem[3, 0].Dark)
					{
						num = (int)((num2 * 1521998436) ^ 0x4FCDAA58);
						continue;
					}
					goto IL_0408;
				case 56u:
					if (mem[2, 1] != null)
					{
						num = (int)((num2 * 458816286) ^ 0x7D91F5D1);
						continue;
					}
					goto IL_00e3;
				case 55u:
					num = (int)(num2 * 133807371) ^ -46945173;
					continue;
				case 54u:
					num3++;
					num = ((int)num2 * -1196005383) ^ -448549954;
					continue;
				case 53u:
					num = -1294298380;
					continue;
				case 52u:
					if (mem[num3, 2].Point != mem[num3, 3].Point)
					{
						num = ((int)num2 * -857171118) ^ -1925846684;
						continue;
					}
					goto IL_0055;
				case 51u:
					if (mem[2, 1].Point != mem[3, 0].Point)
					{
						num = (int)((num2 * 162908349) ^ 0x7836EE42);
						continue;
					}
					goto IL_0408;
				case 50u:
				{
					int num69;
					int num70;
					if (mem[num3, 1].Big != mem[num3, 2].Big)
					{
						num69 = 864356709;
						num70 = 864356709;
					}
					else
					{
						num69 = 1046205824;
						num70 = 1046205824;
					}
					num = num69 ^ (int)(num2 * 1798214999);
					continue;
				}
				case 49u:
				{
					int num63;
					int num64;
					if (mem[1, 2].Big == mem[2, 1].Big)
					{
						num63 = -250465868;
						num64 = -250465868;
					}
					else
					{
						num63 = -222109232;
						num64 = -222109232;
					}
					num = num63 ^ (int)(num2 * 129978347);
					continue;
				}
				case 48u:
					if (mem[2, num3].Dark != mem[3, num3].Dark)
					{
						num = ((int)num2 * -59256451) ^ 0x5C074257;
						continue;
					}
					goto IL_0055;
				case 47u:
				{
					int num54;
					int num55;
					if (mem[num3, 0].Big == mem[num3, 1].Big)
					{
						num54 = -1821543960;
						num55 = -1821543960;
					}
					else
					{
						num54 = -422712388;
						num55 = -422712388;
					}
					num = num54 ^ ((int)num2 * -702175513);
					continue;
				}
				case 46u:
					num = -565516739;
					continue;
				case 45u:
				{
					int num50;
					int num51;
					if (mem[0, 0].Big != mem[1, 1].Big)
					{
						num50 = 789435966;
						num51 = 789435966;
					}
					else
					{
						num50 = 364001801;
						num51 = 364001801;
					}
					num = num50 ^ ((int)num2 * -767555758);
					continue;
				}
				case 44u:
				{
					int num43;
					int num44;
					if (mem[2, 2] == null)
					{
						num43 = 1518641966;
						num44 = 1518641966;
					}
					else
					{
						num43 = 1110515594;
						num44 = 1110515594;
					}
					num = num43 ^ ((int)num2 * -844135365);
					continue;
				}
				case 43u:
				{
					int num33;
					int num34;
					if (mem[3, 3] != null)
					{
						num33 = 1328105549;
						num34 = 1328105549;
					}
					else
					{
						num33 = 797364819;
						num34 = 797364819;
					}
					num = num33 ^ ((int)num2 * -1414496137);
					continue;
				}
				case 41u:
				{
					int num27;
					int num28;
					if (mem[1, 1].Point != mem[2, 2].Point)
					{
						num27 = 1267886993;
						num28 = 1267886993;
					}
					else
					{
						num27 = 155411826;
						num28 = 155411826;
					}
					num = num27 ^ (int)(num2 * 1109502912);
					continue;
				}
				case 40u:
					if (mem[2, 2].Big != mem[3, 3].Big)
					{
						num = ((int)num2 * -44732856) ^ 0x174A1824;
						continue;
					}
					goto IL_06d7;
				case 39u:
				{
					int num20;
					int num21;
					if (flag)
					{
						num20 = 85052985;
						num21 = 85052985;
					}
					else
					{
						num20 = 69855491;
						num21 = 69855491;
					}
					num = num20 ^ ((int)num2 * -220155516);
					continue;
				}
				case 38u:
					result = flag2;
					num = -632423068;
					continue;
				case 37u:
					if (mem[0, num3].Square == mem[1, num3].Square)
					{
						num = -541851730;
						continue;
					}
					goto IL_0061;
				case 36u:
					if (mem[1, 2].Square == mem[2, 1].Square)
					{
						num = (int)((num2 * 1469452756) ^ 0x2A7615F6);
						continue;
					}
					goto IL_076e;
				case 35u:
					if (mem[2, num3].Point != mem[3, num3].Point)
					{
						num = ((int)num2 * -16321345) ^ -1147869291;
						continue;
					}
					goto IL_0055;
				case 34u:
				{
					int num12;
					int num13;
					if (mem[num3, 1].Square == mem[num3, 2].Square)
					{
						num12 = -921749538;
						num13 = -921749538;
					}
					else
					{
						num12 = -492609873;
						num13 = -492609873;
					}
					num = num12 ^ ((int)num2 * -1448462806);
					continue;
				}
				case 33u:
				{
					int num6;
					if (mem[0, 0].Point != mem[1, 1].Point)
					{
						num = -927493167;
						num6 = -927493167;
					}
					else
					{
						num = -1407654290;
						num6 = -1407654290;
					}
					continue;
				}
				case 32u:
					if (mem[2, 2].Dark != mem[3, 3].Dark)
					{
						num = (int)(num2 * 1699299965) ^ -643131314;
						continue;
					}
					goto IL_06d7;
				case 31u:
					if (mem[2, 2].Point != mem[3, 3].Point)
					{
						num = (int)((num2 * 590919596) ^ 0x25762095);
						continue;
					}
					goto IL_06d7;
				case 30u:
					flag2 = true;
					num = ((int)num2 * -918203146) ^ 0x2B0CB6C7;
					continue;
				case 28u:
				{
					int num67;
					if (mem[num3, 0].Dark != mem[num3, 1].Dark)
					{
						num = -1126817968;
						num67 = -1126817968;
					}
					else
					{
						num = -1970779850;
						num67 = -1970779850;
					}
					continue;
				}
				case 27u:
					flag2 = false;
					num = (int)((num2 * 1208842271) ^ 0x1BF53E30);
					continue;
				case 26u:
					if (mem[3, 0] != null)
					{
						num = ((int)num2 * -571173099) ^ -2054460815;
						continue;
					}
					goto IL_00e3;
				case 25u:
					if (mem[1, num3] != null)
					{
						num = ((int)num2 * -1506701616) ^ 0x1FBD624F;
						continue;
					}
					goto IL_0061;
				case 24u:
					if (mem[3, num3] != null)
					{
						num = ((int)num2 * -1658820210) ^ 0x44B03893;
						continue;
					}
					goto IL_0061;
				case 23u:
				{
					int num57;
					int num58;
					if (mem[num3, 1] == null)
					{
						num57 = 744753243;
						num58 = 744753243;
					}
					else
					{
						num57 = 601126691;
						num58 = 601126691;
					}
					num = num57 ^ ((int)num2 * -640511668);
					continue;
				}
				case 22u:
				{
					int num52;
					int num53;
					if (mem[1, num3].Big == mem[2, num3].Big)
					{
						num52 = 1417310388;
						num53 = 1417310388;
					}
					else
					{
						num52 = 1079718041;
						num53 = 1079718041;
					}
					num = num52 ^ (int)(num2 * 665292517);
					continue;
				}
				case 21u:
					if (mem[2, num3].Big != mem[3, num3].Big)
					{
						num = ((int)num2 * -524567053) ^ 0x764A97F6;
						continue;
					}
					goto IL_0055;
				case 20u:
				{
					int num45;
					int num46;
					if (mem[0, 0] == null)
					{
						num45 = 388699850;
						num46 = 388699850;
					}
					else
					{
						num45 = 1565054452;
						num46 = 1565054452;
					}
					num = num45 ^ (int)(num2 * 1293681610);
					continue;
				}
				case 19u:
					if (mem[1, num3].Square == mem[2, num3].Square)
					{
						num = ((int)num2 * -1797581326) ^ 0x5402A2CE;
						continue;
					}
					goto IL_0061;
				case 18u:
				{
					int num39;
					int num40;
					if (mem[1, num3].Point != mem[2, num3].Point)
					{
						num39 = 1820213742;
						num40 = 1820213742;
					}
					else
					{
						num39 = 150140868;
						num40 = 150140868;
					}
					num = num39 ^ (int)(num2 * 1835888630);
					continue;
				}
				case 17u:
				{
					int num37;
					if (mem[0, 3].Point != mem[1, 2].Point)
					{
						num = -1958901319;
						num37 = -1958901319;
					}
					else
					{
						num = -1623676678;
						num37 = -1623676678;
					}
					continue;
				}
				case 16u:
				{
					int num32;
					if (mem[0, 0].Square == mem[1, 1].Square)
					{
						num = -146949198;
						num32 = -146949198;
					}
					else
					{
						num = -525327190;
						num32 = -525327190;
					}
					continue;
				}
				case 15u:
				{
					int num29;
					int num30;
					if (mem[1, 1].Square == mem[2, 2].Square)
					{
						num29 = 1519163178;
						num30 = 1519163178;
					}
					else
					{
						num29 = 2016496487;
						num30 = 2016496487;
					}
					num = num29 ^ ((int)num2 * -1895035265);
					continue;
				}
				case 14u:
					if (mem[1, 2] != null)
					{
						num = ((int)num2 * -1973935636) ^ 0x3016BB71;
						continue;
					}
					goto IL_00e3;
				case 13u:
				{
					int num25;
					int num26;
					if (mem[num3, 1].Dark == mem[num3, 2].Dark)
					{
						num25 = 1393160327;
						num26 = 1393160327;
					}
					else
					{
						num25 = 530156272;
						num26 = 530156272;
					}
					num = num25 ^ (int)(num2 * 1944479584);
					continue;
				}
				case 12u:
				{
					int num22;
					if (mem[0, num3].Point != mem[1, num3].Point)
					{
						num = -1863552890;
						num22 = -1863552890;
					}
					else
					{
						num = -2033520675;
						num22 = -2033520675;
					}
					continue;
				}
				case 11u:
				{
					int num19;
					if (num3 < 4)
					{
						num = -513457888;
						num19 = -513457888;
					}
					else
					{
						num = -348329615;
						num19 = -348329615;
					}
					continue;
				}
				case 10u:
					if (mem[0, 3].Square == mem[1, 2].Square)
					{
						num = -1936840017;
						continue;
					}
					goto IL_076e;
				case 9u:
					if (mem[num3, 2].Square != mem[num3, 3].Square)
					{
						num = ((int)num2 * -2047382697) ^ 0x7DB142F6;
						continue;
					}
					goto IL_0055;
				case 8u:
				{
					int num17;
					int num18;
					if (mem[1, 2].Dark == mem[2, 1].Dark)
					{
						num17 = 1337386226;
						num18 = 1337386226;
					}
					else
					{
						num17 = 1667989580;
						num18 = 1667989580;
					}
					num = num17 ^ (int)(num2 * 439353446);
					continue;
				}
				case 7u:
				{
					int num16;
					if (mem[0, 0].Dark != mem[1, 1].Dark)
					{
						num = -975376540;
						num16 = -975376540;
					}
					else
					{
						num = -1182787548;
						num16 = -1182787548;
					}
					continue;
				}
				case 6u:
					if (mem[2, 2].Square != mem[3, 3].Square)
					{
						num = ((int)num2 * -1997268596) ^ -1202972830;
						continue;
					}
					goto IL_06d7;
				case 5u:
					if (mem[num3, 2].Big != mem[num3, 3].Big)
					{
						num = (int)((num2 * 400559211) ^ 0xFFB480E);
						continue;
					}
					goto IL_0055;
				case 4u:
					if (mem[2, 1].Big != mem[3, 0].Big)
					{
						num = (int)(num2 * 1459144671) ^ -512894043;
						continue;
					}
					goto IL_0408;
				case 3u:
				{
					int num10;
					int num11;
					if (mem[1, 1].Dark != mem[2, 2].Dark)
					{
						num10 = -1785512922;
						num11 = -1785512922;
					}
					else
					{
						num10 = -1196688719;
						num11 = -1196688719;
					}
					num = num10 ^ (int)(num2 * 1408080282);
					continue;
				}
				case 2u:
					num3 = 0;
					num = (int)(num2 * 1995600548) ^ -568096110;
					continue;
				case 1u:
					num9 = ((mem[2, 1].Square == mem[3, 0].Square) ? 1 : 0);
					goto IL_00e4;
				case 0u:
				{
					int num4;
					int num5;
					if (mem[0, num3].Big == mem[1, num3].Big)
					{
						num4 = -390881151;
						num5 = -390881151;
					}
					else
					{
						num4 = -63196679;
						num5 = -63196679;
					}
					num = num4 ^ (int)(num2 * 916773260);
					continue;
				}
				case 42u:
					break;
				default:
					{
						return result;
					}
					IL_00e4:
					flag = (byte)num9 != 0;
					num = -1485389440;
					continue;
					IL_076e:
					num9 = 0;
					goto IL_00e4;
					IL_06d7:
					num9 = 1;
					goto IL_00e4;
					IL_0408:
					num9 = 1;
					goto IL_00e4;
					IL_00e3:
					num9 = 0;
					goto IL_00e4;
					IL_0055:
					num = -821151023;
					num49 = -821151023;
					continue;
					IL_0061:
					num = -1635343065;
					num49 = -1635343065;
					continue;
				}
				break;
			}
		}
	}

	private bool Standoff(Figurine[,] mem)
	{
		int num6 = default(int);
		int num5 = default(int);
		bool flag2 = default(bool);
		bool flag = default(bool);
		bool result = default(bool);
		while (true)
		{
			int num = -263967879;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x85D833DCu) % 15u)
				{
				case 14u:
					num6++;
					num = -1626833995;
					continue;
				case 13u:
				{
					int num8;
					if (num5 >= 4)
					{
						num = -1977585927;
						num8 = -1977585927;
					}
					else
					{
						num = -486881127;
						num8 = -486881127;
					}
					continue;
				}
				case 12u:
					flag2 = true;
					num = ((int)num2 * -1282875130) ^ -884460879;
					continue;
				case 11u:
					num5 = 0;
					num = (int)((num2 * 566995806) ^ 0x705713F3);
					continue;
				case 10u:
					num5++;
					num = ((int)num2 * -1622114413) ^ -2130746354;
					continue;
				case 9u:
				{
					int num7;
					if (mem[num5, num6] != null)
					{
						num = -797933947;
						num7 = -797933947;
					}
					else
					{
						num = -225162782;
						num7 = -225162782;
					}
					continue;
				}
				case 8u:
					num = ((int)num2 * -444556904) ^ 0x20D5835C;
					continue;
				case 7u:
					num6 = 0;
					num = -1626833995;
					continue;
				case 6u:
					flag = num6 < 4;
					num = -610069936;
					continue;
				case 4u:
					flag2 = false;
					num = (int)(num2 * 1294604332) ^ -1330205651;
					continue;
				case 3u:
					result = flag2;
					num = (int)((num2 * 1399424277) ^ 0x450763CA);
					continue;
				case 1u:
					num = (int)((num2 * 1545626713) ^ 0x7CFA71F8);
					continue;
				case 0u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = -693183770;
						num4 = -693183770;
					}
					else
					{
						num3 = -2022863543;
						num4 = -2022863543;
					}
					num = num3 ^ (int)(num2 * 737432569);
					continue;
				}
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
		while (true)
		{
			int num = 652025017;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x66E9B7F8u) % 12u)
				{
				case 11u:
					num = ((int)num2 * -274108823) ^ 0x3E730B0E;
					continue;
				case 9u:
					num = ((int)num2 * -204736183) ^ 0x1F070FFE;
					continue;
				case 8u:
					num = ((int)num2 * -710749746) ^ -1049110634;
					continue;
				case 7u:
					Form1.smethod_50((Control)(object)label6, Form1.smethod_37((Control)(object)label5).X + Form1.smethod_18((Control)(object)label5));
					num = ((int)num2 * -1305930657) ^ -330910783;
					continue;
				case 6u:
					num = ((int)num2 * -2099295831) ^ -1623148074;
					continue;
				case 5u:
					Form1.smethod_50((Control)(object)label5, (Form1.smethod_49((Control)(object)this) - (Form1.smethod_18((Control)(object)label5) + Form1.smethod_18((Control)(object)label6))) / 2);
					num = (int)(num2 * 318300516) ^ -1158907445;
					continue;
				case 4u:
					Form1.smethod_32((Control)(object)label6, str);
					num = (int)((num2 * 698933162) ^ 0x5957CB7);
					continue;
				case 3u:
					Form1.smethod_32((Control)(object)label2, "");
					num = (int)((num2 * 668256981) ^ 0x7F6FE25D);
					continue;
				case 2u:
					Form1.smethod_32((Control)(object)label1, "");
					num = ((int)num2 * -1662746525) ^ 0x1D9B065B;
					continue;
				case 1u:
					Form1.smethod_32((Control)(object)label5, "Игрок: ");
					num = (int)(num2 * 713590692) ^ -815717112;
					continue;
				default:
					return;
				case 10u:
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
			goto IL_0032;
		}
		int num = 0;
		goto IL_009f;
		IL_009f:
		bool flag = (byte)num != 0;
		int num2 = 1725016713;
		goto IL_0069;
		IL_0032:
		num2 = 157332988;
		goto IL_0069;
		IL_0069:
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)num2 ^ 0x5C371ECEu) % 7u)
			{
			case 4u:
				num2 = ((int)num3 * -91203597) ^ -1291960751;
				continue;
			case 3u:
				Form1.smethod_51((IDisposable)components);
				num2 = ((int)num3 * -1665067915) ^ 0x5B54DF94;
				continue;
			case 2u:
				break;
			case 1u:
				((Form)this).Dispose(disposing);
				num2 = 84170530;
				continue;
			case 0u:
			{
				int num4;
				int num5;
				if (flag)
				{
					num4 = -716406127;
					num5 = -716406127;
				}
				else
				{
					num4 = -489376160;
					num5 = -489376160;
				}
				num2 = num4 ^ (int)(num3 * 754273161);
				continue;
			}
			default:
				return;
			case 6u:
				goto IL_0096;
			case 5u:
				return;
			}
			break;
		}
		goto IL_0032;
		IL_0096:
		num = ((components != null) ? 1 : 0);
		goto IL_009f;
	}

	private void InitializeComponent()
	{
		//IL_0e41: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e4b: Expected O, but got Unknown
		components = Form1.smethod_52();
		bool flag = default(bool);
		object[] object_ = default(object[]);
		int num3 = default(int);
		byte[] array = default(byte[]);
		string string_ = default(string);
		while (true)
		{
			int num = -2099750829;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x87B08CAEu) % 144u)
				{
				case 143u:
					num = (int)((num2 * 1718832289) ^ 0x31AE44B5);
					continue;
				case 142u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = -1445054858;
						num5 = -1445054858;
					}
					else
					{
						num4 = -696602921;
						num5 = -696602921;
					}
					num = num4 ^ ((int)num2 * -1989119309);
					continue;
				}
				case 141u:
					Form1.smethod_90((ISupportInitialize)pictureBox1);
					Form1.smethod_91((Control)(object)this, bool_0: false);
					num = ((int)num2 * -2028703835) ^ -1615453267;
					continue;
				case 140u:
					Form1.smethod_4((Control)(object)pictureBox1, new Point(120, 22));
					num = ((int)num2 * -124613754) ^ -1110262623;
					continue;
				case 139u:
					button2 = Form1.smethod_53();
					num = ((int)num2 * -760240094) ^ -501316897;
					continue;
				case 138u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)button1);
					num = (int)(num2 * 105489431) ^ -347308376;
					continue;
				case 137u:
					Form1.smethod_3((Control)(object)label5, new Size(0, 16));
					num = (int)(num2 * 1012505794) ^ -350029008;
					continue;
				case 136u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)richTextBox1);
					num = (int)(num2 * 1411573094) ^ -2043751909;
					continue;
				case 135u:
					object_ = new object[3]
					{
						Player.MembershipCondition(0),
						Player.MembershipCondition(1),
						"Cytotechnologist"
					};
					num = ((int)num2 * -732389966) ^ -1085637884;
					continue;
				case 134u:
					num = (int)((num2 * 959625569) ^ 0x159E8A05);
					continue;
				case 133u:
					Form1.smethod_67((Control)(object)button1, (EventHandler)Button1_Click);
					num = (int)((num2 * 1796755964) ^ 0x43AEC966);
					continue;
				case 132u:
					Form1.smethod_74((Control)(object)label5, bool_0: true);
					num = ((int)num2 * -1541650203) ^ -2103579864;
					continue;
				case 131u:
					Form1.smethod_64((Control)(object)richTextBox1, 6);
					num = (int)(num2 * 1541321946) ^ -170113943;
					continue;
				case 130u:
					num = ((int)num2 * -841335470) ^ -1196208830;
					continue;
				case 129u:
					flag = num3 < 22528;
					num = -625561664;
					continue;
				case 128u:
					Form1.smethod_61((Control)(object)button2, "button2");
					num = (int)(num2 * 293315643) ^ -1083818019;
					continue;
				case 127u:
					Form1.smethod_61((Control)(object)label5, "label5");
					num = (int)(num2 * 372109450) ^ -909207553;
					continue;
				case 126u:
					num = ((int)num2 * -948683274) ^ 0x788EE37A;
					continue;
				case 125u:
					Form1.smethod_64((Control)(object)panel1, 7);
					num = (int)(num2 * 2026379135) ^ -1646641213;
					continue;
				case 124u:
					num = ((int)num2 * -1307892846) ^ 0x37881ED6;
					continue;
				case 123u:
					Form1.smethod_75((Control)(object)label2, (DockStyle)3);
					num = (int)((num2 * 1656381830) ^ 0xA8661B5);
					continue;
				case 122u:
					num = ((int)num2 * -928989225) ^ 0x733A3444;
					continue;
				case 121u:
					Form1.smethod_65((Control)(object)richTextBox1, bool_0: false);
					num = (int)((num2 * 1145329472) ^ 0x792A9A18);
					continue;
				case 120u:
					num = (int)((num2 * 1841106893) ^ 0x51044507);
					continue;
				case 119u:
					num = (int)((num2 * 2067651109) ^ 0x4C3024E2);
					continue;
				case 118u:
					Form1.smethod_4((Control)(object)label1, new Point(486, 0));
					num = ((int)num2 * -667691220) ^ 0x63672764;
					continue;
				case 117u:
					num = ((int)num2 * -1506567657) ^ 0x37D16448;
					continue;
				case 116u:
					num = ((int)num2 * -639200388) ^ 0x13CE871;
					continue;
				case 115u:
					panel1 = Form1.smethod_55();
					timer1 = Form1.smethod_56(components);
					label1 = Form1.smethod_57();
					label2 = Form1.smethod_57();
					num = ((int)num2 * -1191585022) ^ 0x2F6AC632;
					continue;
				case 114u:
					Form1.smethod_86((Form)(object)this, bool_0: false);
					num = ((int)num2 * -49988609) ^ -266726127;
					continue;
				case 113u:
					Form1.smethod_4((Control)(object)label5, new Point(197, 0));
					num = (int)(num2 * 1759452118) ^ -751160328;
					continue;
				case 112u:
					num = (int)(num2 * 66153822) ^ -622293151;
					continue;
				case 111u:
					Form1.smethod_80((ContainerControl)(object)this, (AutoScaleMode)1);
					num = (int)((num2 * 990112263) ^ 0x1224C0A5);
					continue;
				case 110u:
					Form1.smethod_5((Control)(object)pictureBox1, Color.FromArgb(64, 32, 0));
					num = (int)(num2 * 1978342976) ^ -1172647474;
					continue;
				case 109u:
					richTextBox1 = Form1.smethod_54();
					num = ((int)num2 * -1664338142) ^ -1909896889;
					continue;
				case 108u:
					num = (int)(num2 * 1684016597) ^ -1891291206;
					continue;
				case 107u:
					Form1.smethod_4((Control)(object)button2, new Point(391, 275));
					num = ((int)num2 * -1985204937) ^ -719388177;
					continue;
				case 106u:
					Form1.smethod_63(pictureBox1, bool_0: false);
					num = (int)(num2 * 1684027508) ^ -1441470125;
					continue;
				case 105u:
					Form1.smethod_4((Control)(object)richTextBox1, new Point(107, 275));
					num = ((int)num2 * -2095883214) ^ -698014393;
					continue;
				case 104u:
					Form1.smethod_77((Control)(object)label1, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = ((int)num2 * -1577825343) ^ 0x395CC780;
					continue;
				case 103u:
					num = ((int)num2 * -1329573118) ^ -1883214311;
					continue;
				case 102u:
					Form1.smethod_4((Control)(object)label2, new Point(0, 0));
					num = (int)(num2 * 814438657) ^ -1682821550;
					continue;
				case 101u:
					num = (int)((num2 * 277206328) ^ 0x58A1F43E);
					continue;
				case 100u:
					Form1.smethod_85((Control)(object)this, "Form1");
					num = ((int)num2 * -2124212384) ^ -1078459940;
					continue;
				case 99u:
					Form1.smethod_65((Control)(object)button1, bool_0: false);
					num = ((int)num2 * -1814486940) ^ 0x3C8BB163;
					continue;
				case 98u:
					num = ((int)num2 * -1294136739) ^ -1108169616;
					continue;
				case 97u:
					num = ((int)num2 * -1375863228) ^ -88075037;
					continue;
				case 95u:
					Form1.smethod_87((Form)(object)this, (EventHandler)Form1_Load);
					num = ((int)num2 * -1150891877) ^ -214531508;
					continue;
				case 94u:
					num = ((int)num2 * -753703071) ^ -1878675796;
					continue;
				case 93u:
					num = ((int)num2 * -62297621) ^ -2079161573;
					continue;
				case 92u:
					Form1.smethod_64((Control)(object)button2, 4);
					num = (int)((num2 * 839460066) ^ 0x202610F2);
					continue;
				case 91u:
					Form1.smethod_66((ButtonBase)(object)button2, bool_0: true);
					num = (int)((num2 * 35402723) ^ 0x706D3011);
					continue;
				case 90u:
					num = ((int)num2 * -504563886) ^ -271403447;
					continue;
				case 89u:
					num = ((int)num2 * -1852993725) ^ -103103358;
					continue;
				case 88u:
					Form1.smethod_62(pictureBox1, 0);
					num = (int)(num2 * 683543989) ^ -2035542388;
					continue;
				case 87u:
					num = ((int)num2 * -300684634) ^ 0x34714C6D;
					continue;
				case 86u:
					num = ((int)num2 * -1280549844) ^ -1817125846;
					continue;
				case 85u:
					Form1.smethod_3((Control)(object)panel1, new Size(486, 240));
					num = (int)((num2 * 1278044418) ^ 0x2E127199);
					continue;
				case 84u:
					Form1.smethod_92((Control)(object)this);
					num = (int)(num2 * 270432265) ^ -1719539870;
					continue;
				case 83u:
					num = ((int)num2 * -234322065) ^ -1373864218;
					continue;
				case 82u:
					Form1.smethod_75((Control)(object)label1, (DockStyle)4);
					num = ((int)num2 * -1098301885) ^ 0x6665ACF0;
					continue;
				case 81u:
					Form1.smethod_32((Control)(object)this, "Quarto");
					num = (int)((num2 * 1851144517) ^ 0x5704958C);
					continue;
				case 80u:
					Form1.smethod_81((Form)(object)this, new Size(486, 319));
					num = ((int)num2 * -1427437744) ^ -1587268296;
					continue;
				case 79u:
					Form1.smethod_83((Form)(object)this, (FormBorderStyle)1);
					num = ((int)num2 * -1467083849) ^ -1979505996;
					continue;
				case 78u:
					num = (int)(num2 * 1796555847) ^ -1377512155;
					continue;
				case 77u:
					Form1.smethod_32((Control)(object)richTextBox1, "");
					Form1.smethod_4((Control)(object)panel1, new Point(0, 24));
					num = ((int)num2 * -1559308310) ^ 0x4FAF07C4;
					continue;
				case 76u:
					num = ((int)num2 * -1700111269) ^ 0x654FAF94;
					continue;
				case 75u:
					Form1.smethod_4((Control)(object)label6, new Point(275, 0));
					num = (int)((num2 * 176738607) ^ 0x5F299FB0);
					continue;
				case 74u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label2);
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label1);
					num = ((int)num2 * -793794895) ^ -882877358;
					continue;
				case 73u:
					Form1.smethod_72(timer1, 1000);
					num = ((int)num2 * -1634498384) ^ -1243561238;
					continue;
				case 72u:
					num = (int)(num2 * 454927421) ^ -1386170362;
					continue;
				case 71u:
					num3 = 0;
					num = ((int)num2 * -952113329) ^ 0x72817676;
					continue;
				case 70u:
					num = (int)((num2 * 476998189) ^ 0x44DFDA4E);
					continue;
				case 69u:
					Form1.smethod_66((ButtonBase)(object)button1, bool_0: true);
					num = (int)(num2 * 1406004258) ^ -141491583;
					continue;
				case 68u:
					Form1.smethod_64((Control)(object)label5, 12);
					num = ((int)num2 * -1005411887) ^ -1592235792;
					continue;
				case 67u:
					Form1.smethod_32((Control)(object)button2, "Подтвердить");
					num = ((int)num2 * -954692944) ^ -1807213195;
					continue;
				case 66u:
					CharArray(array, string.Empty);
					num = ((int)num2 * -1468464078) ^ 0x16A38F7D;
					continue;
				case 65u:
					Form1.smethod_61((Control)(object)button1, "button1");
					Form1.smethod_3((Control)(object)button1, new Size(83, 35));
					Form1.smethod_64((Control)(object)button1, 5);
					num = ((int)num2 * -894456110) ^ -1970681227;
					continue;
				case 64u:
					Form1.smethod_32((Control)(object)button1, "Меню");
					num = ((int)num2 * -1028814205) ^ -41108285;
					continue;
				case 63u:
					Form1.smethod_77((Control)(object)label2, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = ((int)num2 * -1467777024) ^ -2038040232;
					continue;
				case 62u:
					Form1.smethod_3((Control)(object)button2, new Size(83, 35));
					num = ((int)num2 * -1707629683) ^ 0x356FD44;
					continue;
				case 61u:
					pictureBox1 = Form1.smethod_2();
					num = (int)(num2 * 514625739) ^ -1277661222;
					continue;
				case 60u:
					num = ((int)num2 * -1074089135) ^ -1733151978;
					continue;
				case 59u:
					Form1.smethod_64((Control)(object)label1, 8);
					num = (int)(num2 * 1204591180) ^ -1329387776;
					continue;
				case 58u:
					num = (int)(num2 * 1001410130) ^ -31648267;
					continue;
				case 57u:
					num = ((int)num2 * -1582862195) ^ 0x73A360E8;
					continue;
				case 56u:
					Form1.smethod_3((Control)(object)label6, new Size(0, 16));
					num = ((int)num2 * -1465046209) ^ -346326680;
					continue;
				case 55u:
					button1 = Form1.smethod_53();
					num = ((int)num2 * -918487654) ^ -1679772587;
					continue;
				case 54u:
					num = ((int)num2 * -122842262) ^ -627527926;
					continue;
				case 53u:
					array = new byte[22528];
					num = (int)((num2 * 1160572705) ^ 0x2EFBDA1C);
					continue;
				case 52u:
					Form1.smethod_73(timer1, (EventHandler)Timer1_Tick);
					num = ((int)num2 * -367573342) ^ 0x1A238C10;
					continue;
				case 51u:
					num = ((int)num2 * -1253372808) ^ -2048855064;
					continue;
				case 50u:
					Form1.smethod_5((Control)(object)this, Color.White);
					num = ((int)num2 * -1274965184) ^ -516562184;
					continue;
				case 49u:
					array[num3] = Form1.smethod_69(Form1.smethod_68(string_, num3 * 2, 2), 16);
					num = ((int)num2 * -1772208525) ^ 0x12430F69;
					continue;
				case 48u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)pictureBox1);
					num = (int)(num2 * 1164955844) ^ -1538476496;
					continue;
				case 47u:
					Form1.smethod_3((Control)(object)richTextBox1, new Size(272, 35));
					num = ((int)num2 * -806434803) ^ -1824071298;
					continue;
				case 46u:
					num = (int)(num2 * 1105134465) ^ -253628134;
					continue;
				case 45u:
					num = (int)(num2 * 876434608) ^ -1220342085;
					continue;
				case 44u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label5);
					num = (int)((num2 * 257879241) ^ 0x3379240C);
					continue;
				case 43u:
					Form1.smethod_61((Control)(object)richTextBox1, "richTextBox1");
					string_ = Veet.Sa;
					num = (int)((num2 * 701704514) ^ 0x6A7FAA71);
					continue;
				case 42u:
					label5 = Form1.smethod_57();
					label6 = Form1.smethod_57();
					Form1.smethod_58((ISupportInitialize)pictureBox1);
					num = ((int)num2 * -127102069) ^ 0x263611A9;
					continue;
				case 41u:
					string_ = Form1.smethod_34(string_, Veet.Xe);
					string_ = Form1.smethod_34(string_, Veet.Zr);
					num = (int)(num2 * 1858374147) ^ -668710480;
					continue;
				case 40u:
					Form1.smethod_64((Control)(object)label6, 13);
					num = (int)(num2 * 341179739) ^ -1886370697;
					continue;
				case 39u:
					num = (int)(num2 * 366102676) ^ -1161225406;
					continue;
				case 38u:
					num = (int)(num2 * 1067760324) ^ -1165463205;
					continue;
				case 37u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)button2);
					num = (int)(num2 * 1115809943) ^ -1905400800;
					continue;
				case 36u:
					num3++;
					num = ((int)num2 * -226086335) ^ 0x4BB99B1B;
					continue;
				case 34u:
					Form1.smethod_61((Control)(object)label1, "label1");
					num = ((int)num2 * -1069996588) ^ 0x35C73D4A;
					continue;
				case 33u:
					Form1.smethod_64((Control)(object)label2, 9);
					num = ((int)num2 * -1280687121) ^ -416272507;
					continue;
				case 32u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)panel1);
					num = (int)(num2 * 493898923) ^ -1370505197;
					continue;
				case 31u:
					Form1.smethod_5((Control)(object)richTextBox1, Color.White);
					num = (int)((num2 * 293904842) ^ 0x4AD206AF);
					continue;
				case 30u:
					num = ((int)num2 * -1144801025) ^ 0x26C517B4;
					continue;
				case 29u:
					Form1.smethod_74((Control)(object)label1, bool_0: true);
					num = ((int)num2 * -1701112418) ^ 0x6BE3FB2A;
					continue;
				case 28u:
					Form1.smethod_67((Control)(object)button2, (EventHandler)Button2_Click);
					num = (int)(num2 * 135866987) ^ -617468836;
					continue;
				case 27u:
					Form1.smethod_77((Control)(object)label6, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = ((int)num2 * -1725389640) ^ -987514035;
					continue;
				case 26u:
					Form1.smethod_61((Control)(object)label2, "label2");
					num = ((int)num2 * -1288767912) ^ 0x57A1AA1;
					continue;
				case 25u:
					num = ((int)num2 * -1122801905) ^ 0x6BE423F6;
					continue;
				case 24u:
					Form1.smethod_6((Control)(object)pictureBox1, new MouseEventHandler(PictureBox1_MouseDown));
					num = ((int)num2 * -206173147) ^ 0x6F0FE25D;
					continue;
				case 23u:
					Form1.smethod_59((Control)(object)this);
					num = (int)((num2 * 445760280) ^ 0x73A27B70);
					continue;
				case 22u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label6);
					num = (int)(num2 * 231443883) ^ -444769546;
					continue;
				case 21u:
					Form1.smethod_84((Form)(object)this, bool_0: false);
					num = (int)((num2 * 1730566333) ^ 0x3350F30);
					continue;
				case 20u:
					Form1.smethod_70(ComMember, object_);
					Form1.smethod_71((TextBoxBase)(object)richTextBox1, bool_0: true);
					num = (int)((num2 * 636430529) ^ 0x13BDE5D5);
					continue;
				case 19u:
					Form1.smethod_74((Control)(object)label2, bool_0: true);
					num = (int)(num2 * 1591147006) ^ -1823364033;
					continue;
				case 18u:
					num = ((int)num2 * -1194914548) ^ -351720483;
					continue;
				case 17u:
					num = (int)(num2 * 2027711599) ^ -1954685935;
					continue;
				case 16u:
					Form1.smethod_61((Control)(object)pictureBox1, "pictureBox1");
					num = ((int)num2 * -432696788) ^ -1650404069;
					continue;
				case 15u:
					Form1.smethod_3((Control)(object)label2, new Size(0, 16));
					num = (int)((num2 * 84879803) ^ 0x5FD96463);
					continue;
				case 14u:
					Form1.smethod_78((Control)(object)label1, (RightToLeft)0);
					num = ((int)num2 * -917939086) ^ -707450861;
					continue;
				case 13u:
					num = ((int)num2 * -678100609) ^ 0x6D8F6492;
					continue;
				case 12u:
					Form1.smethod_4((Control)(object)button1, new Point(12, 275));
					num = ((int)num2 * -414035609) ^ 0x72540B1B;
					continue;
				case 11u:
					Form1.smethod_61((Control)(object)label6, "label6");
					num = ((int)num2 * -126728524) ^ -414484914;
					continue;
				case 10u:
					Form1.smethod_74((Control)(object)label6, bool_0: true);
					num = (int)((num2 * 1351394913) ^ 0x27224D5F);
					continue;
				case 9u:
					Form1.smethod_79((ContainerControl)(object)this, new SizeF(6f, 13f));
					num = ((int)num2 * -469201245) ^ 0x6540067F;
					continue;
				case 8u:
					Form1.smethod_61((Control)(object)panel1, "panel1");
					num = (int)(num2 * 1788835497) ^ -1832422957;
					continue;
				case 7u:
					Form1.smethod_88((Form)(object)this, (EventHandler)Form1_Shown);
					Form1.smethod_89((Control)(object)this, (EventHandler)Form1_LocationChanged);
					num = (int)((num2 * 1896756226) ^ 0x5EF7E74D);
					continue;
				case 6u:
					num = ((int)num2 * -918731831) ^ 0x6E83FA98;
					continue;
				case 5u:
					Form1.smethod_3((Control)(object)pictureBox1, new Size(246, 246));
					num = ((int)num2 * -2020113094) ^ 0x658ED34E;
					continue;
				case 4u:
					Form1.smethod_65((Control)(object)button2, bool_0: false);
					num = ((int)num2 * -1856603276) ^ -1614243347;
					continue;
				case 3u:
					num = -1477214097;
					continue;
				case 2u:
					Form1.smethod_77((Control)(object)label5, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = ((int)num2 * -1514320590) ^ 0x693D64BB;
					continue;
				case 1u:
					Form1.smethod_3((Control)(object)label1, new Size(0, 16));
					num = ((int)num2 * -149705670) ^ -582902202;
					continue;
				case 0u:
					Form1.smethod_60(pictureBox1, (BorderStyle)2);
					num = (int)((num2 * 569329618) ^ 0x434132);
					continue;
				default:
					return;
				case 35u:
					break;
				case 96u:
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
			int num = -1624573253;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF2E32302u) % 4u)
				{
				case 1u:
					PerformTable(q);
					num = (int)((num2 * 1036911369) ^ 0x2F4530B7);
					continue;
				case 0u:
					num = (int)((num2 * 926113414) ^ 0x5A58C2ED);
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

	private static Assembly ContextAdd(byte[] Position)
	{
		Assembly result = default(Assembly);
		while (true)
		{
			int num = -1257970304;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE87850DFu) % 4u)
				{
				case 3u:
					result = Form1.smethod_94(Form1.smethod_93(), Position);
					num = ((int)num2 * -870911429) ^ 0x8BAFFF6;
					continue;
				case 0u:
					num = (int)(num2 * 470261413) ^ -1604964986;
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
