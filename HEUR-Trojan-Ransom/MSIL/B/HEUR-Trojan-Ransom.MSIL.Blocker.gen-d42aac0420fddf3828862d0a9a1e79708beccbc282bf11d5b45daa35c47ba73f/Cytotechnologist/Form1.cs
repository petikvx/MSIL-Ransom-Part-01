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
				int num = -1747165638;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xCA9D9D60u) % 5u)
					{
					case 4u:
						Point = copy.Point;
						num = (int)((num2 * 1147463101) ^ 0x65FE2757);
						continue;
					case 3u:
						num = ((int)num2 * -1076718316) ^ 0x2FBD5717;
						continue;
					case 2u:
						Dark = copy.Dark;
						Big = copy.Big;
						Square = copy.Square;
						num = (int)(num2 * 1851748393) ^ -593636407;
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
			int num = 643126815;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x5DFE2EF4u) % 3u)
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
				num = ((int)num2 * -1067574745) ^ -646850505;
			}
		}
	}

	public void Button1_Click(object sender, EventArgs e)
	{
		bool flag = default(bool);
		while (true)
		{
			int num = -1410515635;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xDE6EEB66u) % 10u)
				{
				case 9u:
					flag = Form1.smethod_16((Control)(object)menu) < 296;
					num = -834986097;
					continue;
				case 8u:
					num = ((int)num2 * -1856449643) ^ -583417451;
					continue;
				case 6u:
				{
					Form control_ = menu;
					Form1.smethod_17((Control)(object)control_, Form1.smethod_16((Control)(object)control_) + 5);
					num = (int)((num2 * 2083369005) ^ 0x30B60B71);
					continue;
				}
				case 5u:
					Form1.smethod_15(timer1);
					num = ((int)num2 * -300017493) ^ 0x701B2A2F;
					continue;
				case 4u:
					Form1.smethod_14(menu);
					num = (int)(num2 * 2100017420) ^ -50008586;
					continue;
				case 3u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = 319584243;
						num4 = 319584243;
					}
					else
					{
						num3 = 657426982;
						num4 = 657426982;
					}
					num = num3 ^ ((int)num2 * -174385663);
					continue;
				}
				case 1u:
					num = -608191602;
					continue;
				case 0u:
					num = ((int)num2 * -298014175) ^ -1275558327;
					continue;
				default:
					return;
				case 2u:
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
		bool flag = default(bool);
		int num4 = default(int);
		int num3 = default(int);
		while (true)
		{
			int num = -115705498;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF556A660u) % 21u)
				{
				case 20u:
					Form1.smethod_7((Control)(object)button2, bool_0: false);
					num = (int)((num2 * 795686052) ^ 0x357C7CC7);
					continue;
				case 19u:
				{
					int num6;
					int num7;
					if (flag)
					{
						num6 = -1004834088;
						num7 = -1004834088;
					}
					else
					{
						num6 = -1534859632;
						num7 = -1534859632;
					}
					num = num6 ^ ((int)num2 * -1580821686);
					continue;
				}
				case 18u:
					Paint_Storage();
					num = ((int)num2 * -206829296) ^ -674755632;
					continue;
				case 17u:
					num = (int)((num2 * 799833751) ^ 0x43A3770A);
					continue;
				case 16u:
					num = ((int)num2 * -1388944202) ^ -629973305;
					continue;
				case 13u:
				{
					int num5;
					if (num4 < 4)
					{
						num = -2014626276;
						num5 = -2014626276;
					}
					else
					{
						num = -337676832;
						num5 = -337676832;
					}
					continue;
				}
				case 12u:
					num = (int)((num2 * 2034733720) ^ 0x32A19A2C);
					continue;
				case 11u:
					num4++;
					num = (int)(num2 * 367763727) ^ -1196387302;
					continue;
				case 10u:
					Form1.smethod_7((Control)(object)pictureBox[num3, num4], bool_0: false);
					num = (int)((num2 * 1371701377) ^ 0x4EE45721);
					continue;
				case 9u:
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: false);
					num = ((int)num2 * -2060157043) ^ 0x5895B416;
					continue;
				case 8u:
					storage = new Figurine[4, 4];
					num = ((int)num2 * -938262372) ^ -1273055070;
					continue;
				case 7u:
					num = (int)(num2 * 853801862) ^ -252802400;
					continue;
				case 6u:
					storage[num3, num4] = new Figurine(num3 < 2, num4 % 2 == 0, num4 < 2, num3 % 2 == 1);
					Form1.smethod_5((Control)(object)borderBox[num3, num4], Color.White);
					num = -728568074;
					continue;
				case 5u:
					board = new Figurine[4, 4];
					num = (int)((num2 * 329664238) ^ 0x59FB252E);
					continue;
				case 4u:
					flag = num3 < 4;
					num = -1371988676;
					continue;
				case 3u:
					num4 = 0;
					num = -1132682337;
					continue;
				case 2u:
					num3++;
					num = ((int)num2 * -1308541423) ^ -589082284;
					continue;
				case 1u:
					num3 = 0;
					num = ((int)num2 * -2079579270) ^ -2050333520;
					continue;
				case 0u:
					Paint_Board();
					num = ((int)num2 * -1501089965) ^ 0x2856E30A;
					continue;
				default:
					return;
				case 15u:
					break;
				case 14u:
					return;
				}
				break;
			}
		}
	}

	private void Paint_Board()
	{
		Form1.smethod_20(pictureBox1, (Image)(object)Form1.smethod_19(Form1.smethod_18((Control)(object)pictureBox1), Form1.smethod_16((Control)(object)pictureBox1)));
		Brush brush_ = default(Brush);
		float num9 = default(float);
		float num7 = default(float);
		bool big = default(bool);
		int num3 = default(int);
		int num4 = default(int);
		float num10 = default(float);
		bool flag2 = default(bool);
		bool flag = default(bool);
		float num8 = default(float);
		Graphics graphics_ = default(Graphics);
		float num15 = default(float);
		bool dark = default(bool);
		while (true)
		{
			int num = 1877729980;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x4693DC05u) % 42u)
				{
				case 41u:
					brush_ = Form1.smethod_26();
					num = 330739924;
					continue;
				case 40u:
					num9 = 1f - num7 * 0.9f / (float)Form1.smethod_27(2.0);
					num = 1535151923;
					continue;
				case 39u:
					num = ((int)num2 * -110078091) ^ 0x79BB2A4C;
					continue;
				case 38u:
					num = (int)(num2 * 1960739935) ^ -597124562;
					continue;
				case 37u:
					big = board[num3, num4].Big;
					num = 2060113279;
					continue;
				case 36u:
					num = 253360932;
					continue;
				case 35u:
					num9 = 1f - num7 * 0.4f / (float)Form1.smethod_27(2.0);
					num10 = (float)size * (num9 / 2f);
					num = 1923492798;
					continue;
				case 34u:
				{
					int num20;
					int num21;
					if (!flag2)
					{
						num20 = -2083285278;
						num21 = -2083285278;
					}
					else
					{
						num20 = -1093947680;
						num21 = -1093947680;
					}
					num = num20 ^ ((int)num2 * -2031226435);
					continue;
				}
				case 33u:
					num4 = 0;
					num = 836915958;
					continue;
				case 32u:
					num = 877426223;
					continue;
				case 31u:
				{
					int num13;
					int num14;
					if (board[num3, num4].Square)
					{
						num13 = -1792807139;
						num14 = -1792807139;
					}
					else
					{
						num13 = -362760844;
						num14 = -362760844;
					}
					num = num13 ^ ((int)num2 * -668252792);
					continue;
				}
				case 29u:
					flag = num4 < 4;
					num = 147450045;
					continue;
				case 28u:
					num7 = 1f;
					num = ((int)num2 * -1371051086) ^ -747530770;
					continue;
				case 27u:
					brush_ = Form1.smethod_25();
					num = ((int)num2 * -1275129362) ^ 0x682FF5B1;
					continue;
				case 26u:
					num8 = (float)size * num7;
					num10 = (float)size * (num9 / 2f);
					num = (int)((num2 * 1080591931) ^ 0x56B46137);
					continue;
				case 25u:
					num = ((int)num2 * -1580190434) ^ 0x418C18C7;
					continue;
				case 24u:
					num7 = 0.7f;
					num = 1169648525;
					continue;
				case 23u:
					Form1.smethod_24(graphics_, brush_, num10 + (float)(num4 * size), num10 + (float)(num3 * size), num15, num15);
					num = 693837849;
					continue;
				case 22u:
				{
					int num22;
					int num23;
					if (board[num3, num4] != null)
					{
						num22 = 1746288323;
						num23 = 1746288323;
					}
					else
					{
						num22 = 813027347;
						num23 = 813027347;
					}
					num = num22 ^ (int)(num2 * 982634342);
					continue;
				}
				case 21u:
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox1));
					num3 = 0;
					num = ((int)num2 * -1063715003) ^ -1514915675;
					continue;
				case 20u:
				{
					int num18;
					int num19;
					if (!flag)
					{
						num18 = -317800896;
						num19 = -317800896;
					}
					else
					{
						num18 = -1318095726;
						num19 = -1318095726;
					}
					num = num18 ^ (int)(num2 * 876360556);
					continue;
				}
				case 18u:
					num15 = num8 * 0.9f / (float)Form1.smethod_27(2.0);
					num = (int)(num2 * 1094600250) ^ -1135606748;
					continue;
				case 17u:
					num15 = num8 * 0.4f / (float)Form1.smethod_27(2.0);
					num = ((int)num2 * -1614427341) ^ -851695028;
					continue;
				case 16u:
				{
					int num16;
					int num17;
					if (dark)
					{
						num16 = -2067107398;
						num17 = -2067107398;
					}
					else
					{
						num16 = -594571402;
						num17 = -594571402;
					}
					num = num16 ^ ((int)num2 * -1766865956);
					continue;
				}
				case 15u:
					Form1.smethod_24(graphics_, (Brush)(object)Form1.smethod_29(Color.FromArgb(180, Color.Peru)), num10 + (float)(num4 * size), num10 + (float)(num3 * size), num15, num15);
					num = (int)(num2 * 535923314) ^ -405456254;
					continue;
				case 14u:
					Form1.smethod_28(graphics_, brush_, num10 + (float)(num4 * size), num10 + (float)(num3 * size), num15, num15);
					num = (int)(num2 * 1257580132) ^ -1635931214;
					continue;
				case 13u:
					num4++;
					num = (int)((num2 * 868135321) ^ 0x27FF614F);
					continue;
				case 12u:
					flag2 = num3 < 4;
					num = 1841613395;
					continue;
				case 11u:
					num3++;
					num = ((int)num2 * -1702368656) ^ -1155113271;
					continue;
				case 10u:
					num = (int)((num2 * 839393366) ^ 0x35F1C5F3);
					continue;
				case 9u:
					num = ((int)num2 * -124610873) ^ 0x572132D5;
					continue;
				case 8u:
				{
					int num11;
					int num12;
					if (board[num3, num4].Point)
					{
						num11 = 2015004612;
						num12 = 2015004612;
					}
					else
					{
						num11 = 69716557;
						num12 = 69716557;
					}
					num = num11 ^ (int)(num2 * 2074485849);
					continue;
				}
				case 7u:
					num = 1849873741;
					continue;
				case 6u:
					Form1.smethod_24(graphics_, Form1.smethod_23(), ((float)num4 + 0.05f) * (float)size, ((float)num3 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					num = (int)(num2 * 1567458561) ^ -560546777;
					continue;
				case 5u:
					Form1.smethod_30((Control)(object)pictureBox1);
					num = (int)(num2 * 1941574625) ^ -1724994040;
					continue;
				case 4u:
				{
					int num5;
					int num6;
					if (big)
					{
						num5 = -1117363625;
						num6 = -1117363625;
					}
					else
					{
						num5 = -104273073;
						num6 = -104273073;
					}
					num = num5 ^ ((int)num2 * -1326796283);
					continue;
				}
				case 3u:
					num = ((int)num2 * -1127379769) ^ 0x6F155BD2;
					continue;
				case 2u:
					dark = board[num3, num4].Dark;
					num = ((int)num2 * -796705591) ^ 0x4E8D97FB;
					continue;
				case 1u:
					num = (int)(num2 * 60623284) ^ -1391479048;
					continue;
				case 0u:
					num = (int)(num2 * 151828415) ^ -778332696;
					continue;
				default:
					return;
				case 19u:
					break;
				case 30u:
					return;
				}
				break;
			}
		}
	}

	private void Paint_Storage()
	{
		int num7 = default(int);
		int num8 = default(int);
		float num6 = default(float);
		float num5 = default(float);
		bool point = default(bool);
		bool big = default(bool);
		float num12 = default(float);
		float num9 = default(float);
		Graphics graphics_ = default(Graphics);
		Brush brush_ = default(Brush);
		bool flag2 = default(bool);
		bool flag = default(bool);
		bool dark = default(bool);
		while (true)
		{
			int num = 1805367241;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x31952DE2u) % 37u)
				{
				case 36u:
					Form1.smethod_30((Control)(object)pictureBox[num7, num8]);
					num = 1428657215;
					continue;
				case 35u:
					num6 = num5 * 0.4f / (float)Form1.smethod_27(2.0);
					point = storage[num7, num8].Point;
					num = ((int)num2 * -1364153012) ^ -331561646;
					continue;
				case 34u:
				{
					int num10;
					int num11;
					if (point)
					{
						num10 = -1359273483;
						num11 = -1359273483;
					}
					else
					{
						num10 = -1624628677;
						num11 = -1624628677;
					}
					num = num10 ^ ((int)num2 * -685411744);
					continue;
				}
				case 33u:
				{
					int num18;
					int num19;
					if (!big)
					{
						num18 = 2045090685;
						num19 = 2045090685;
					}
					else
					{
						num18 = 1585314065;
						num19 = 1585314065;
					}
					num = num18 ^ (int)(num2 * 289734671);
					continue;
				}
				case 32u:
				{
					float num15 = 1f - num12 * 0.4f / (float)Form1.smethod_27(2.0);
					num9 = (float)size * (num15 / 2f) - 4f;
					num = 309255480;
					continue;
				}
				case 31u:
					Form1.smethod_20(pictureBox[num7, num8], (Image)(object)Form1.smethod_19(Form1.smethod_18((Control)(object)pictureBox[num7, num8]), Form1.smethod_16((Control)(object)pictureBox[num7, num8])));
					num = ((int)num2 * -308386426) ^ 0x7A1F8687;
					continue;
				case 30u:
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox[num7, num8]));
					num = (int)((num2 * 187468411) ^ 0x5FC19DF);
					continue;
				case 28u:
					brush_ = Form1.smethod_25();
					num = (int)((num2 * 182339722) ^ 0x725D3722);
					continue;
				case 27u:
					Form1.smethod_24(graphics_, brush_, num9, num9, num6, num6);
					num = 382090926;
					continue;
				case 26u:
					num12 = 1f;
					num = ((int)num2 * -841626026) ^ 0x2D4EB8C7;
					continue;
				case 25u:
					Form1.smethod_28(graphics_, brush_, num9, num9, num6, num6);
					num = ((int)num2 * -2136610178) ^ -2103862045;
					continue;
				case 24u:
				{
					int num20;
					int num21;
					if (!flag2)
					{
						num20 = -514302373;
						num21 = -514302373;
					}
					else
					{
						num20 = -455122071;
						num21 = -455122071;
					}
					num = num20 ^ ((int)num2 * -448465759);
					continue;
				}
				case 23u:
					num = (int)(num2 * 951112093) ^ -401214466;
					continue;
				case 22u:
				{
					int num17;
					if (storage[num7, num8] == null)
					{
						num = 1162918720;
						num17 = 1162918720;
					}
					else
					{
						num = 725502979;
						num17 = 725502979;
					}
					continue;
				}
				case 21u:
					num = (int)((num2 * 1177008111) ^ 0xABEA1AF);
					continue;
				case 20u:
					flag = num7 < 4;
					num = 382731985;
					continue;
				case 19u:
				{
					float num15 = 1f - num12 * 0.9f / (float)Form1.smethod_27(2.0);
					num5 = (float)size * num12;
					num9 = (float)size * (num15 / 2f) - 4f;
					num6 = num5 * 0.9f / (float)Form1.smethod_27(2.0);
					int num16;
					if (num8 >= 2)
					{
						num = 267817536;
						num16 = 267817536;
					}
					else
					{
						num = 894634943;
						num16 = 894634943;
					}
					continue;
				}
				case 18u:
					num8++;
					num = 1855477001;
					continue;
				case 17u:
					flag2 = num8 < 4;
					num = 1444399267;
					continue;
				case 16u:
					num = ((int)num2 * -207998183) ^ -6940304;
					continue;
				case 15u:
					num7 = 0;
					num = ((int)num2 * -973520703) ^ -2015226470;
					continue;
				case 14u:
					Form1.smethod_24(graphics_, (Brush)(object)Form1.smethod_29(Color.FromArgb(180, Color.Peru)), num9, num9, num6, num6);
					num = ((int)num2 * -1793561108) ^ -1032652641;
					continue;
				case 12u:
					big = storage[num7, num8].Big;
					num = 312839306;
					continue;
				case 11u:
					num = (int)(num2 * 1874590298) ^ -1030319374;
					continue;
				case 10u:
					num = ((int)num2 * -1507894713) ^ -111042223;
					continue;
				case 9u:
					num = ((int)num2 * -1128362336) ^ -568835109;
					continue;
				case 8u:
				{
					int num13;
					int num14;
					if (flag)
					{
						num13 = 1383424910;
						num14 = 1383424910;
					}
					else
					{
						num13 = 694931729;
						num14 = 694931729;
					}
					num = num13 ^ ((int)num2 * -516523871);
					continue;
				}
				case 7u:
					num8 = 0;
					num = 1855477001;
					continue;
				case 6u:
					num = (int)((num2 * 762592188) ^ 0x36E74FFF);
					continue;
				case 5u:
					num7++;
					num = ((int)num2 * -1437919347) ^ -1861227661;
					continue;
				case 4u:
					num = (int)((num2 * 689395249) ^ 0x1813C64C);
					continue;
				case 3u:
					num12 = 0.7f;
					num = 19357680;
					continue;
				case 2u:
					dark = storage[num7, num8].Dark;
					num = ((int)num2 * -984558520) ^ -147364679;
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (dark)
					{
						num3 = 123261783;
						num4 = 123261783;
					}
					else
					{
						num3 = 1383705416;
						num4 = 1383705416;
					}
					num = num3 ^ ((int)num2 * -1650945651);
					continue;
				}
				case 0u:
					brush_ = Form1.smethod_26();
					num = 96968580;
					continue;
				default:
					return;
				case 13u:
					break;
				case 29u:
					return;
				}
				break;
			}
		}
	}

	public void StartGame()
	{
		int num8 = default(int);
		int num4 = default(int);
		bool flag = default(bool);
		int num3 = default(int);
		int num5 = default(int);
		while (true)
		{
			int num = 2699684;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6EA154Cu) % 34u)
				{
				case 32u:
					num = (int)(num2 * 2071636179) ^ -520860472;
					continue;
				case 31u:
					num8 = 0;
					num = 1591399651;
					continue;
				case 30u:
					Form1.smethod_7((Control)(object)pictureBox[num4, num8], bool_0: true);
					num = 1232325112;
					continue;
				case 29u:
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: true);
					num = ((int)num2 * -1606365955) ^ 0x7AEBD6D3;
					continue;
				case 28u:
					time = new DateTime(0L, DateTimeKind.Unspecified);
					num = (int)(num2 * 1499221146) ^ -286531730;
					continue;
				case 27u:
					num = (int)((num2 * 2012115725) ^ 0xE617358);
					continue;
				case 26u:
					flag = num4 < 4;
					num = 1344956292;
					continue;
				case 25u:
				{
					int num11;
					if (num8 >= 4)
					{
						num = 642596207;
						num11 = 642596207;
					}
					else
					{
						num = 1394814958;
						num11 = 1394814958;
					}
					continue;
				}
				case 24u:
					Form1.smethod_35(timer1, bool_0: true);
					num = (int)(num2 * 1337923346) ^ -382739057;
					continue;
				case 23u:
					num = (int)((num2 * 1887693084) ^ 0x46EA9BEA);
					continue;
				case 21u:
				{
					int num9;
					int num10;
					if (turn)
					{
						num9 = -1638706773;
						num10 = -1638706773;
					}
					else
					{
						num9 = -1499285813;
						num10 = -1499285813;
					}
					num = num9 ^ ((int)num2 * -2015896014);
					continue;
				}
				case 20u:
					num8++;
					num = ((int)num2 * -2072778241) ^ 0x4E3C0737;
					continue;
				case 19u:
					num4++;
					num = ((int)num2 * -1003795278) ^ -291510102;
					continue;
				case 18u:
					step = 0;
					num = ((int)num2 * -1548699585) ^ 0x3728FB5E;
					continue;
				case 17u:
					Form1.smethod_32((Control)(object)richTextBox1, "Противник выбрал фигуру. Выберете поле на доске для установки этой фигуры.");
					num = ((int)num2 * -1150061914) ^ -763271949;
					continue;
				case 16u:
					step = 1;
					num = ((int)num2 * -2036313757) ^ 0x41BBB5E6;
					continue;
				case 15u:
					Form1.smethod_36(timer1);
					num = (int)(num2 * 1858793065) ^ -959105286;
					continue;
				case 14u:
				{
					int num6;
					int num7;
					if (flag)
					{
						num6 = 778890097;
						num7 = 778890097;
					}
					else
					{
						num6 = 1853126751;
						num7 = 1853126751;
					}
					num = num6 ^ ((int)num2 * -2015624920);
					continue;
				}
				case 13u:
					num = ((int)num2 * -138830519) ^ 0x7AA617B3;
					continue;
				case 12u:
					Form1.smethod_5((Control)(object)borderBox[num3, num5], Color.Blue);
					num = ((int)num2 * -1174755866) ^ -1559431385;
					continue;
				case 11u:
					num = ((int)num2 * -2126474713) ^ -564010030;
					continue;
				case 10u:
					Form1_Load(this, Form1.smethod_31());
					num = ((int)num2 * -697856184) ^ -669802953;
					continue;
				case 9u:
					Form1.smethod_32((Control)(object)richTextBox1, "Ваш ход. Выберете фигуру, которой будет играть противник.");
					num = ((int)num2 * -1436937437) ^ -2132096355;
					continue;
				case 8u:
					num5 = Form1.smethod_33(rnd, 4);
					num = ((int)num2 * -1662568388) ^ 0x177ADE3A;
					continue;
				case 7u:
					num = ((int)num2 * -941669897) ^ 0x7E95B9FA;
					continue;
				case 6u:
					Form1.smethod_32((Control)(object)label2, Form1.smethod_34("Ход: ", step.ToString()));
					num = 805562081;
					continue;
				case 5u:
					num = ((int)num2 * -1320563622) ^ 0x482430BE;
					continue;
				case 4u:
					num4 = 0;
					num = ((int)num2 * -752204111) ^ -1964676022;
					continue;
				case 3u:
					num = (int)((num2 * 1787819045) ^ 0x34D08FE3);
					continue;
				case 2u:
					num = ((int)num2 * -1788505546) ^ -759135457;
					continue;
				case 1u:
					num3 = Form1.smethod_33(rnd, 4);
					num = 1660880388;
					continue;
				case 0u:
					num = (int)(num2 * 373832947) ^ -1339737720;
					continue;
				default:
					return;
				case 33u:
					break;
				case 22u:
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
			int num = 1694312724;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x73685BBu) % 5u)
				{
				case 4u:
					time = time.AddSeconds(1.0);
					num = ((int)num2 * -1676564269) ^ 0x34ED82BE;
					continue;
				case 3u:
					Form1.smethod_32((Control)(object)label1, Form1.smethod_34("Время: ", time.ToString("HH:mm:ss")));
					num = ((int)num2 * -1291685862) ^ 0x4BAED792;
					continue;
				case 2u:
					num = ((int)num2 * -1246948601) ^ -1082561342;
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
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected O, but got Unknown
		Point point = Form1.smethod_37((Control)((sender is PictureBox) ? sender : null));
		int num6 = default(int);
		int num7 = default(int);
		bool flag2 = default(bool);
		int num5 = default(int);
		int num13 = default(int);
		bool flag = default(bool);
		bool flag3 = default(bool);
		while (true)
		{
			int num = -1244505257;
			while (true)
			{
				uint num2;
				int num8;
				switch ((num2 = (uint)num ^ 0xF962F9BFu) % 22u)
				{
				case 20u:
					num6 = point.Y / size;
					point = Form1.smethod_37((Control)((sender is PictureBox) ? sender : null));
					num7 = point.X / size;
					num = (int)(num2 * 1934925357) ^ -179711464;
					continue;
				case 19u:
					num8 = ((Form1.smethod_40((Bitmap)Form1.smethod_21(pictureBox[num6, num7]), Form1.smethod_38(e), Form1.smethod_39(e)) != Color.FromArgb(0, 0, 0, 0)) ? 1 : 0);
					goto IL_0084;
				case 17u:
					if (storage[num6, num7] != null)
					{
						num = -231875580;
						continue;
					}
					num8 = 0;
					goto IL_0084;
				case 16u:
					Form1.smethod_7((Control)(object)button2, bool_0: true);
					num = ((int)num2 * -405758586) ^ -824823440;
					continue;
				case 15u:
				{
					int num11;
					int num12;
					if (num7 > 1)
					{
						num11 = 976575478;
						num12 = 976575478;
					}
					else
					{
						num11 = 803622200;
						num12 = 803622200;
					}
					num = num11 ^ (int)(num2 * 761347486);
					continue;
				}
				case 14u:
					Form1.smethod_5((Control)(object)borderBox[num6, num7], Color.Red);
					num = ((int)num2 * -1324171458) ^ -524817155;
					continue;
				case 13u:
					flag2 = num5 < 4;
					num = -899023239;
					continue;
				case 12u:
				{
					int num14;
					int num15;
					if (flag2)
					{
						num14 = 695107965;
						num15 = 695107965;
					}
					else
					{
						num14 = 1336374997;
						num15 = 1336374997;
					}
					num = num14 ^ (int)(num2 * 449196166);
					continue;
				}
				case 11u:
					Form1.smethod_5((Control)(object)borderBox[num5, num13], Color.White);
					num13++;
					num = -568366072;
					continue;
				case 10u:
					num = ((int)num2 * -1587734411) ^ -2016379538;
					continue;
				case 9u:
					num = ((int)num2 * -995260778) ^ -1919837496;
					continue;
				case 8u:
					num = (int)(num2 * 430674464) ^ -974050523;
					continue;
				case 7u:
					num7 -= 4;
					num = (int)(num2 * 878008977) ^ -289755327;
					continue;
				case 6u:
					num13 = 0;
					num = -2140432719;
					continue;
				case 5u:
					Form1.smethod_32((Control)(object)richTextBox1, "Именно эта фигура? Если да - нажмите \"Подтвердить\".");
					num = ((int)num2 * -1597277929) ^ -1317013579;
					continue;
				case 4u:
					num5 = 0;
					num = (int)(num2 * 158439132) ^ -181468372;
					continue;
				case 3u:
					flag = num13 < 4;
					num = -513350773;
					continue;
				case 2u:
					num5++;
					num = (int)((num2 * 1628320547) ^ 0x2683EC48);
					continue;
				case 1u:
				{
					int num9;
					int num10;
					if (flag3)
					{
						num9 = -2057908065;
						num10 = -2057908065;
					}
					else
					{
						num9 = -1258824786;
						num10 = -1258824786;
					}
					num = num9 ^ ((int)num2 * -740483892);
					continue;
				}
				case 0u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = 836422315;
						num4 = 836422315;
					}
					else
					{
						num3 = 1575464778;
						num4 = 1575464778;
					}
					num = num3 ^ ((int)num2 * -1282031968);
					continue;
				}
				default:
					return;
				case 18u:
					break;
				case 21u:
					return;
					IL_0084:
					flag3 = (byte)num8 != 0;
					num = -839382526;
					continue;
				}
				break;
			}
		}
	}

	private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
	{
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected O, but got Unknown
		int num4 = default(int);
		int num5 = default(int);
		int num7 = default(int);
		int num3 = default(int);
		Graphics graphics_ = default(Graphics);
		bool flag2 = default(bool);
		bool flag = default(bool);
		while (true)
		{
			int num = 1861707298;
			while (true)
			{
				uint num2;
				int num10;
				switch ((num2 = (uint)num ^ 0x2FBAB351u) % 26u)
				{
				case 24u:
					num4 = 0;
					num = (int)(num2 * 449695434) ^ -1457849091;
					continue;
				case 23u:
					num5 = 0;
					num = 1243302700;
					continue;
				case 22u:
					Form1.smethod_30((Control)(object)pictureBox1);
					num = (int)((num2 * 212621669) ^ 0x4D81709A);
					continue;
				case 21u:
					if (Form1.smethod_40((Bitmap)Form1.smethod_21(pictureBox1), Form1.smethod_38(e), Form1.smethod_39(e)) != Color.FromArgb(0, 0, 0, 0))
					{
						num = ((int)num2 * -1847774086) ^ 0x40815553;
						continue;
					}
					goto IL_0099;
				case 20u:
					if (board[num7, num3] == null)
					{
						num = 627215449;
						num10 = 627215449;
						continue;
					}
					goto IL_0099;
				case 19u:
					Form1.smethod_7((Control)(object)button2, bool_0: true);
					num = (int)((num2 * 1724046252) ^ 0x101E9BEB);
					continue;
				case 18u:
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox1));
					Form1.smethod_43(graphics_, Form1.smethod_42(Color.Red, 3f), ((float)num3 + 0.05f) * (float)size, ((float)num7 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					Form1.smethod_44(graphics_, Form1.smethod_21(pictureBox[num4, num5]), num3 * size + 4, num7 * size + 4, new Rectangle(0, 0, size, size), (GraphicsUnit)2);
					num = (int)(num2 * 1117772046) ^ -1289271692;
					continue;
				case 17u:
					flag2 = num5 < 4;
					num = 2042943291;
					continue;
				case 16u:
					num7 = Form1.smethod_39(e) / size;
					num = (int)(num2 * 1050829068) ^ -560408098;
					continue;
				case 15u:
					num = ((int)num2 * -489409443) ^ -1147689448;
					continue;
				case 14u:
				{
					int num11;
					int num12;
					if (flag2)
					{
						num11 = -1675235737;
						num12 = -1675235737;
					}
					else
					{
						num11 = -809525172;
						num12 = -809525172;
					}
					num = num11 ^ (int)(num2 * 176673087);
					continue;
				}
				case 13u:
					num = (int)(num2 * 1048685206) ^ -739727615;
					continue;
				case 12u:
					num = (int)(num2 * 689219441) ^ -588160939;
					continue;
				case 11u:
				{
					int num8;
					int num9;
					if (flag)
					{
						num8 = 977822203;
						num9 = 977822203;
					}
					else
					{
						num8 = 1892654274;
						num9 = 1892654274;
					}
					num = num8 ^ ((int)num2 * -1307502578);
					continue;
				}
				case 10u:
					Paint_Board();
					num = (int)(num2 * 710910073) ^ -1495259500;
					continue;
				case 9u:
					Form1.smethod_45(graphics_);
					num = ((int)num2 * -1483313314) ^ 0x32DFEF27;
					continue;
				case 8u:
				{
					int num6;
					if (num4 < 4)
					{
						num = 583897894;
						num6 = 583897894;
					}
					else
					{
						num = 1072022843;
						num6 = 1072022843;
					}
					continue;
				}
				case 7u:
					num4++;
					num = ((int)num2 * -1326142084) ^ 0x3C1278F9;
					continue;
				case 6u:
					num = ((int)num2 * -1515829924) ^ -1930176443;
					continue;
				case 5u:
					num5++;
					num = 284290994;
					continue;
				case 4u:
					flag = Form1.smethod_41((Control)(object)borderBox[num4, num5]) == Color.Blue;
					num = 1001745806;
					continue;
				case 3u:
					num = (int)(num2 * 592493609) ^ -410159177;
					continue;
				case 2u:
					Form1.smethod_32((Control)(object)richTextBox1, "Уверены? Для выполнения данного хода нажмите \"Подтвердить\".");
					num = (int)((num2 * 1109975433) ^ 0xAA242F8);
					continue;
				case 1u:
					num3 = Form1.smethod_38(e) / size;
					num = ((int)num2 * -303615723) ^ 0x5CF1A458;
					continue;
				default:
					return;
				case 25u:
					break;
				case 0u:
					return;
					IL_0099:
					num = 1072022843;
					num10 = 1072022843;
					continue;
				}
				break;
			}
		}
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		//IL_1167: Unknown result type (might be due to invalid IL or missing references)
		//IL_1195: Expected O, but got Unknown
		int num3 = default(int);
		int num10 = default(int);
		bool flag5 = default(bool);
		int num8 = default(int);
		int num9 = default(int);
		bool flag13 = default(bool);
		bool flag12 = default(bool);
		int num30 = default(int);
		int num4 = default(int);
		int num20 = default(int);
		int num21 = default(int);
		int num38 = default(int);
		bool flag3 = default(bool);
		int num24 = default(int);
		int num27 = default(int);
		int num29 = default(int);
		int num28 = default(int);
		int num7 = default(int);
		int num34 = default(int);
		Figurine[,] array2 = default(Figurine[,]);
		Graphics graphics_ = default(Graphics);
		Figurine[,] array = default(Figurine[,]);
		Figurine[,] array3 = default(Figurine[,]);
		int num19 = default(int);
		bool flag2 = default(bool);
		bool flag11 = default(bool);
		int num5 = default(int);
		bool flag4 = default(bool);
		int num33 = default(int);
		int num15 = default(int);
		bool flag7 = default(bool);
		int num25 = default(int);
		int num26 = default(int);
		bool flag8 = default(bool);
		bool flag10 = default(bool);
		bool flag9 = default(bool);
		bool flag6 = default(bool);
		bool flag = default(bool);
		while (true)
		{
			int num = -343452084;
			while (true)
			{
				uint num2;
				int num51;
				int num36;
				int num6;
				int num18;
				switch ((num2 = (uint)num ^ 0x8658BCEFu) % 172u)
				{
				case 171u:
					num3++;
					num = (int)((num2 * 1114966955) ^ 0x4C3A37);
					continue;
				case 170u:
					num10++;
					num = -1405466257;
					continue;
				case 169u:
				{
					int num47;
					int num48;
					if (flag5)
					{
						num47 = -1202714834;
						num48 = -1202714834;
					}
					else
					{
						num47 = -1016689086;
						num48 = -1016689086;
					}
					num = num47 ^ (int)(num2 * 359699023);
					continue;
				}
				case 168u:
					num8 = Form1.smethod_33(rnd, 4);
					num9 = Form1.smethod_33(rnd, 4);
					num = ((int)num2 * -454842840) ^ -1419060248;
					continue;
				case 167u:
				{
					int num60;
					int num61;
					if (!flag13)
					{
						num60 = -538479214;
						num61 = -538479214;
					}
					else
					{
						num60 = -463010283;
						num61 = -463010283;
					}
					num = num60 ^ ((int)num2 * -1961661358);
					continue;
				}
				case 166u:
					num = -863148876;
					continue;
				case 165u:
					flag12 = num3 < 4;
					num = -1255523923;
					continue;
				case 164u:
					num30++;
					num = -385125633;
					continue;
				case 163u:
					num4++;
					num = (int)(num2 * 139384946) ^ -1519612596;
					continue;
				case 162u:
				{
					storage[num20, num21] = null;
					int num22;
					int num23;
					if (Standoff(board))
					{
						num22 = 871824826;
						num23 = 871824826;
					}
					else
					{
						num22 = 474846316;
						num23 = 474846316;
					}
					num = num22 ^ (int)(num2 * 2071825019);
					continue;
				}
				case 161u:
					num = -254598404;
					continue;
				case 160u:
					if (storage[num8, num9] != null)
					{
						num = (int)(num2 * 1598245544) ^ -1228340792;
						continue;
					}
					goto IL_0174;
				case 159u:
					num = -1071477313;
					continue;
				case 158u:
					num = (int)((num2 * 160495265) ^ 0x7B1636D9);
					continue;
				case 157u:
					board[num38, num10] = new Figurine(storage[num20, num21]);
					num = (int)(num2 * 180958465) ^ -202611080;
					continue;
				case 156u:
				{
					int num57;
					int num58;
					if (flag3)
					{
						num57 = 277693568;
						num58 = 277693568;
					}
					else
					{
						num57 = 55958356;
						num58 = 55958356;
					}
					num = num57 ^ (int)(num2 * 280024818);
					continue;
				}
				case 155u:
				{
					int num54;
					if (Standoff(board))
					{
						num = -553315956;
						num54 = -553315956;
					}
					else
					{
						num = -1123524549;
						num54 = -1123524549;
					}
					continue;
				}
				case 154u:
					num24++;
					num = -274322344;
					continue;
				case 153u:
					Form1.smethod_30((Control)(object)pictureBox[num20, num21]);
					num = ((int)num2 * -1213991896) ^ -1989960106;
					continue;
				case 152u:
					Form1.smethod_15(timer1);
					(menu as Form3).ContinueLock();
					num = (int)(num2 * 771684675) ^ -1654359361;
					continue;
				case 151u:
					if (num9 != num21)
					{
						goto IL_0168;
					}
					goto IL_0174;
				case 150u:
					Form1.smethod_32((Control)(object)richTextBox1, "Выберете фигуру, которой будет играть противник.");
					num = (int)(num2 * 799339524) ^ -804271523;
					continue;
				case 149u:
					(menu as Form3).ContinueLock();
					num = (int)(num2 * 513891878) ^ -719373402;
					continue;
				case 148u:
					num27 = num29;
					num28 = num7;
					num = ((int)num2 * -1350880598) ^ 0x4D2A25D3;
					continue;
				case 147u:
					num = -102921878;
					continue;
				case 146u:
					num4 = 0;
					num = (int)((num2 * 1840840038) ^ 0x7AEAB58A);
					continue;
				case 145u:
				{
					int num43;
					int num44;
					if (!(Form1.smethod_41((Control)(object)borderBox[num29, num7]) == Color.Blue))
					{
						num43 = -1634935352;
						num44 = -1634935352;
					}
					else
					{
						num43 = -1085527854;
						num44 = -1085527854;
					}
					num = num43 ^ ((int)num2 * -1855574111);
					continue;
				}
				case 144u:
					num = ((int)num2 * -2136663127) ^ 0x157C62AE;
					continue;
				case 143u:
					num34 = Form1.smethod_33(rnd, 4);
					num = (int)(num2 * 1039336237) ^ -1648890609;
					continue;
				case 142u:
					array2 = (Figurine[,])Form1.smethod_48((Array)board);
					array2[num38, num10] = new Figurine(storage[num20, num21]);
					num = (int)(num2 * 1477944070) ^ -229415647;
					continue;
				case 141u:
					step++;
					Form1.smethod_32((Control)(object)label2, Form1.smethod_34("Ход: ", step.ToString()));
					num = ((int)num2 * -182946987) ^ -700120886;
					continue;
				case 140u:
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox1));
					num38 = 0;
					num = (int)((num2 * 161499521) ^ 0x68ECC2EB);
					continue;
				case 139u:
					num = ((int)num2 * -1413113554) ^ -594711377;
					continue;
				case 138u:
					array = (Figurine[,])Form1.smethod_48((Array)array3);
					num = ((int)num2 * -15759385) ^ 0x2AA47B;
					continue;
				case 137u:
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: true);
					num = ((int)num2 * -510821946) ^ 0x339FAD4C;
					continue;
				case 136u:
					num = -1280597894;
					continue;
				case 135u:
					flag5 = Stop(array);
					num = ((int)num2 * -1708771078) ^ 0x3CB78D34;
					continue;
				case 134u:
					num = ((int)num2 * -352278728) ^ -1632428731;
					continue;
				case 133u:
					Form1.smethod_32((Control)(object)richTextBox1, "Противник сделал ход (зелёный). Выберете поле на доске для выбронной противником фигуры (синий).");
					num = ((int)num2 * -1960678627) ^ -894873857;
					continue;
				case 132u:
					num = (int)((num2 * 495127760) ^ 0x3F9F93E6);
					continue;
				case 131u:
					Form1.smethod_7((Control)(object)pictureBox[num3, num19], bool_0: true);
					num19++;
					num = -1840943817;
					continue;
				case 130u:
				{
					int num13;
					int num14;
					if (!flag2)
					{
						num13 = -1634718154;
						num14 = -1634718154;
					}
					else
					{
						num13 = -1754700768;
						num14 = -1754700768;
					}
					num = num13 ^ ((int)num2 * -689342024);
					continue;
				}
				case 129u:
				{
					int num64;
					int num65;
					if (flag11)
					{
						num64 = 1061104881;
						num65 = 1061104881;
					}
					else
					{
						num64 = 85691454;
						num65 = 85691454;
					}
					num = num64 ^ (int)(num2 * 2120379096);
					continue;
				}
				case 128u:
					Form1.smethod_47(200);
					num = (int)(num2 * 435742835) ^ -1766154902;
					continue;
				case 127u:
				{
					int num62;
					int num63;
					if (!(Form1.smethod_41((Control)(object)borderBox[num4, num5]) == Color.Red))
					{
						num62 = 3276566;
						num63 = 3276566;
					}
					else
					{
						num62 = 1390994499;
						num63 = 1390994499;
					}
					num = num62 ^ ((int)num2 * -820029361);
					continue;
				}
				case 126u:
					num = -1203770717;
					continue;
				case 125u:
					num = -2069108092;
					continue;
				case 124u:
					flag4 = num10 < 4;
					num = -693642500;
					continue;
				case 123u:
					num = (int)(num2 * 1842703782) ^ -1684826191;
					continue;
				case 122u:
					num = ((int)num2 * -671727547) ^ -394997899;
					continue;
				case 121u:
					storage[num20, num21] = null;
					num = (int)(num2 * 1530937123) ^ -1987138987;
					continue;
				case 120u:
					Form1.smethod_30((Control)(object)borderBox[num4, num5]);
					num = ((int)num2 * -828723815) ^ -1296536164;
					continue;
				case 119u:
					flag13 = board[num34, num33] != null;
					num = ((int)num2 * -343480653) ^ 0x7CEADD05;
					continue;
				case 118u:
					num29 = 0;
					num = (int)(num2 * 1815903688) ^ -225053746;
					continue;
				case 117u:
					Form1.smethod_5((Control)(object)borderBox[num20, num21], Color.White);
					Form1.smethod_30((Control)(object)borderBox[num20, num21]);
					num = ((int)num2 * -2121866782) ^ 0x49B27731;
					continue;
				case 116u:
					num = -827391700;
					continue;
				case 115u:
					num15 = 0;
					num = (int)(num2 * 22982654) ^ -1344109571;
					continue;
				case 114u:
					num10 = 0;
					num = -1350042011;
					continue;
				case 113u:
					Form1.smethod_44(graphics_, Form1.smethod_21(pictureBox[num20, num21]), num10 * size + 4, num38 * size + 4, new Rectangle(0, 0, size, size), (GraphicsUnit)2);
					num = (int)(num2 * 374896946) ^ -1528157490;
					continue;
				case 112u:
					num21 = 0;
					num = (int)((num2 * 418491898) ^ 0x33EB202D);
					continue;
				case 111u:
					flag7 = array3[num15, num30] == null;
					num = -1468533716;
					continue;
				case 110u:
					num = ((int)num2 * -611079788) ^ -314229433;
					continue;
				case 109u:
				{
					int num59;
					if (num29 >= 4)
					{
						num = -852193198;
						num59 = -852193198;
					}
					else
					{
						num = -1017475279;
						num59 = -1017475279;
					}
					continue;
				}
				case 108u:
					num = ((int)num2 * -1311939928) ^ 0x5C4C480B;
					continue;
				case 107u:
					Form1.smethod_5((Control)(object)borderBox[num4, num5], Color.LimeGreen);
					num = ((int)num2 * -1838675316) ^ -659130542;
					continue;
				case 106u:
				{
					int num55;
					int num56;
					if (!flag12)
					{
						num55 = 756996921;
						num56 = 756996921;
					}
					else
					{
						num55 = 986668629;
						num56 = 986668629;
					}
					num = num55 ^ (int)(num2 * 512445676);
					continue;
				}
				case 105u:
					board[num27, num28] = new Figurine(storage[num25, num26]);
					storage[num25, num26] = null;
					num = (int)((num2 * 27021910) ^ 0xB50D6CA);
					continue;
				case 104u:
				{
					int num52;
					int num53;
					if (flag8)
					{
						num52 = 570190737;
						num53 = 570190737;
					}
					else
					{
						num52 = 2091664977;
						num53 = 2091664977;
					}
					num = num52 ^ (int)(num2 * 645056259);
					continue;
				}
				case 103u:
					num = ((int)num2 * -1525020651) ^ -1531040883;
					continue;
				case 102u:
					if (num24 >= 9)
					{
						num = -60416458;
						num51 = -60416458;
						continue;
					}
					goto IL_08c6;
				case 101u:
					num = ((int)num2 * -364318858) ^ 0x12EDBE4D;
					continue;
				case 100u:
					num25 = num29;
					num26 = num7;
					Form1.smethod_5((Control)(object)borderBox[num29, num7], Color.White);
					num = (int)(num2 * 467267529) ^ -2138360300;
					continue;
				case 99u:
					if (num8 == num20)
					{
						num = (int)((num2 * 40088000) ^ 0x2B8DEA0);
						continue;
					}
					goto IL_0168;
				case 98u:
					Form1.smethod_44(graphics_, Form1.smethod_21(pictureBox[num20, num21]), num33 * size + 4, num34 * size + 4, new Rectangle(0, 0, size, size), (GraphicsUnit)2);
					num = ((int)num2 * -33656356) ^ -648152744;
					continue;
				case 97u:
				{
					int num50;
					if (num15 < 4)
					{
						num = -259470109;
						num50 = -259470109;
					}
					else
					{
						num = -266013622;
						num50 = -266013622;
					}
					continue;
				}
				case 96u:
					flag10 = num5 < 4;
					num = -492015138;
					continue;
				case 95u:
					num = (int)((num2 * 646403448) ^ 0x2D27C230);
					continue;
				case 94u:
					num5++;
					num = (int)((num2 * 1020608230) ^ 0x2B5BFC6F);
					continue;
				case 93u:
					Form1.smethod_32((Control)(object)richTextBox1, "QUARTO! Компьютер выиграл!");
					num = -67919155;
					continue;
				case 92u:
					num = (int)(num2 * 1897595767) ^ -1058253646;
					continue;
				case 91u:
					step++;
					Form1.smethod_32((Control)(object)label2, Form1.smethod_34("Ход: ", step.ToString()));
					num = ((int)num2 * -1199080878) ^ -2044866686;
					continue;
				case 90u:
					num19 = 0;
					num = -1840943817;
					continue;
				case 89u:
					if (!flag9)
					{
						num = (int)(num2 * 720397950) ^ -334572353;
						continue;
					}
					goto IL_08c6;
				case 88u:
					Form1.smethod_32((Control)(object)richTextBox1, "Ничья!");
					num = (int)((num2 * 1271369589) ^ 0x3684A0F5);
					continue;
				case 86u:
					num = (int)((num2 * 1445105150) ^ 0x51467A69);
					continue;
				case 85u:
					Form1.smethod_5((Control)(object)borderBox[num8, num9], Color.Blue);
					num = (int)(num2 * 245785091) ^ -263971656;
					continue;
				case 83u:
					num5 = 0;
					num = -1015914250;
					continue;
				case 82u:
					array3 = (Figurine[,])Form1.smethod_48((Array)board);
					array3[num34, num33] = new Figurine(storage[num20, num21]);
					num = ((int)num2 * -114651584) ^ -1160551936;
					continue;
				case 81u:
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: false);
					num = (int)((num2 * 1446402220) ^ 0x2A21551);
					continue;
				case 80u:
				{
					int num49;
					if (num30 < 4)
					{
						num = -1486216444;
						num49 = -1486216444;
					}
					else
					{
						num = -874583742;
						num49 = -874583742;
					}
					continue;
				}
				case 79u:
					Form1.smethod_30((Control)(object)pictureBox1);
					num = ((int)num2 * -961598259) ^ -962037002;
					continue;
				case 78u:
					num = (int)(num2 * 1294246706) ^ -1189501718;
					continue;
				case 77u:
					num = (int)((num2 * 2015206598) ^ 0x7720D0AE);
					continue;
				case 76u:
					flag11 = num38 < 4;
					num = -1572056430;
					continue;
				case 75u:
					Form1.smethod_32((Control)(object)richTextBox1, "Ничья!");
					num = ((int)num2 * -221028987) ^ -32332270;
					continue;
				case 74u:
					flag9 = true;
					num = (int)(num2 * 633479918) ^ -730298891;
					continue;
				case 73u:
				{
					int num45;
					int num46;
					if (flag10)
					{
						num45 = 1598197573;
						num46 = 1598197573;
					}
					else
					{
						num45 = 1544452475;
						num46 = 1544452475;
					}
					num = num45 ^ ((int)num2 * -1440270041);
					continue;
				}
				case 72u:
					num = (int)(num2 * 992210879) ^ -1518623030;
					continue;
				case 71u:
					flag9 = false;
					num = ((int)num2 * -235319306) ^ -1749067783;
					continue;
				case 70u:
					num = ((int)num2 * -1900948530) ^ 0x38DD4CF6;
					continue;
				case 69u:
					num36 = (Standoff(array2) ? 1 : 0);
					goto IL_0c86;
				case 68u:
					num = ((int)num2 * -1570365857) ^ -1446606028;
					continue;
				case 67u:
					Form1.smethod_30((Control)(object)borderBox[num29, num7]);
					num = (int)(num2 * 906805699) ^ -1271347817;
					continue;
				case 66u:
					num = ((int)num2 * -828992251) ^ 0x6C67C574;
					continue;
				case 65u:
					Form1.smethod_47(1000);
					num = (int)(num2 * 2066878433) ^ -1936456700;
					continue;
				case 64u:
					num = (int)((num2 * 1128067913) ^ 0x44DC7C22);
					continue;
				case 63u:
					num21 = num5;
					num = ((int)num2 * -1615223792) ^ 0x4E93495;
					continue;
				case 62u:
					num20 = 0;
					num = ((int)num2 * -1221961116) ^ 0x3A5B804F;
					continue;
				case 61u:
					num = (int)(num2 * 1976013324) ^ -1240422657;
					continue;
				case 60u:
					Form1.smethod_47(200);
					num = ((int)num2 * -1873326617) ^ 0x34205818;
					continue;
				case 59u:
					Form1.smethod_7((Control)(object)button2, bool_0: false);
					num = ((int)num2 * -1178438698) ^ -874875735;
					continue;
				case 58u:
					num = ((int)num2 * -1978467999) ^ 0x2991B905;
					continue;
				case 57u:
					num = (int)(num2 * 1040169419) ^ -2142531610;
					continue;
				case 56u:
					num = -1110480699;
					continue;
				case 55u:
					num33 = Form1.smethod_33(rnd, 4);
					num = ((int)num2 * -1778889867) ^ 0x1C29C22F;
					continue;
				case 54u:
					num = (int)(num2 * 160035791) ^ -1850506503;
					continue;
				case 53u:
					flag8 = board[num38, num10] == null;
					num = -2068775197;
					continue;
				case 52u:
					num = ((int)num2 * -334680450) ^ 0x2B3C1CFB;
					continue;
				case 51u:
					Form1.smethod_30((Control)(object)label2);
					num = (int)((num2 * 1456394379) ^ 0x596BFC95);
					continue;
				case 50u:
					Form1.smethod_43(graphics_, Form1.smethod_42(Color.LimeGreen, 3f), ((float)num10 + 0.05f) * (float)size, ((float)num38 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					num = (int)(num2 * 518667657) ^ -344415871;
					continue;
				case 49u:
					num7++;
					num = -537550554;
					continue;
				case 48u:
					num = (int)(num2 * 184033454) ^ -692198418;
					continue;
				case 47u:
					Form1.smethod_30((Control)(object)borderBox[num20, num21]);
					Form1.smethod_20(pictureBox[num20, num21], (Image)null);
					num = (int)((num2 * 1144114863) ^ 0x1A1EF146);
					continue;
				case 46u:
					Form1.smethod_5((Control)(object)borderBox[num20, num21], Color.White);
					num = ((int)num2 * -1986098832) ^ 0x3E4B00BF;
					continue;
				case 45u:
					num = ((int)num2 * -652670938) ^ -387565684;
					continue;
				case 44u:
					Form1.smethod_30((Control)(object)borderBox[num8, num9]);
					num = ((int)num2 * -1712256009) ^ -1117550954;
					continue;
				case 43u:
				{
					int num41;
					int num42;
					if (!flag7)
					{
						num41 = -439000965;
						num42 = -439000965;
					}
					else
					{
						num41 = -1922519755;
						num42 = -1922519755;
					}
					num = num41 ^ ((int)num2 * -1406641080);
					continue;
				}
				case 42u:
					num38++;
					num = ((int)num2 * -839246692) ^ 0x78736403;
					continue;
				case 41u:
					flag2 = num4 < 4;
					num = -1480258763;
					continue;
				case 40u:
					num29++;
					num = ((int)num2 * -1514049514) ^ 0x2A7910F6;
					continue;
				case 39u:
					Form1.smethod_30((Control)(object)pictureBox1);
					num = (int)((num2 * 1755094465) ^ 0x246F2B70);
					continue;
				case 38u:
				{
					int num39;
					int num40;
					if (flag6)
					{
						num39 = -1357291881;
						num40 = -1357291881;
					}
					else
					{
						num39 = -1277375699;
						num40 = -1277375699;
					}
					num = num39 ^ (int)(num2 * 1858508571);
					continue;
				}
				case 37u:
				{
					int num37;
					if (num7 < 4)
					{
						num = -7775032;
						num37 = -7775032;
					}
					else
					{
						num = -1502743693;
						num37 = -1502743693;
					}
					continue;
				}
				case 36u:
					num = (int)(num2 * 61904243) ^ -85227774;
					continue;
				case 35u:
					num = (int)((num2 * 545686148) ^ 0x28A3FBB0);
					continue;
				case 34u:
					if (!Stop(array2))
					{
						num = ((int)num2 * -1361043295) ^ -1179304140;
						continue;
					}
					num36 = 1;
					goto IL_0c86;
				case 33u:
					num = (int)((num2 * 2093653942) ^ 0x46D76692);
					continue;
				case 32u:
					Form1.smethod_20(pictureBox[num20, num21], (Image)null);
					Form1.smethod_30((Control)(object)pictureBox[num20, num21]);
					num = (int)(num2 * 1996077820) ^ -802572916;
					continue;
				case 31u:
					num = (int)((num2 * 1278251021) ^ 0x58A45A37);
					continue;
				case 30u:
					num = (int)(num2 * 1585461089) ^ -1410695493;
					continue;
				case 29u:
					board[num34, num33] = new Figurine(storage[num20, num21]);
					num = (int)(num2 * 547801312) ^ -1230477610;
					continue;
				case 28u:
					num = ((int)num2 * -18514071) ^ 0x76DE13FF;
					continue;
				case 27u:
					num20 = num4;
					num = (int)((num2 * 562528621) ^ 0x4043EDB3);
					continue;
				case 26u:
				{
					int num35;
					if (!(Form1.smethod_40((Bitmap)Form1.smethod_21(pictureBox1), num7 * size + size / 2, (int)(((float)num29 + 0.05f) * (float)size)) == Color.FromArgb(255, 255, 0, 0)))
					{
						num = -948466938;
						num35 = -948466938;
					}
					else
					{
						num = -40061417;
						num35 = -40061417;
					}
					continue;
				}
				case 25u:
					Form1.smethod_43(graphics_, Form1.smethod_42(Color.LimeGreen, 3f), ((float)num33 + 0.05f) * (float)size, ((float)num34 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					num = (int)(num2 * 286011368) ^ -1008850643;
					continue;
				case 24u:
					num = (int)(num2 * 406047825) ^ -43886709;
					continue;
				case 23u:
				{
					int num31;
					int num32;
					if (flag4)
					{
						num31 = -418873615;
						num32 = -418873615;
					}
					else
					{
						num31 = -886223642;
						num32 = -886223642;
					}
					num = num31 ^ (int)(num2 * 1024721765);
					continue;
				}
				case 22u:
					array[num15, num30] = new Figurine(storage[num8, num9]);
					num = ((int)num2 * -905453225) ^ -1852650494;
					continue;
				case 21u:
					Form1.smethod_20(pictureBox[num29, num7], (Image)null);
					num = ((int)num2 * -480824689) ^ -602443974;
					continue;
				case 20u:
					num30 = 0;
					num = -628512293;
					continue;
				case 19u:
					Form1.smethod_32((Control)(object)richTextBox1, "Подождите, компьютер делает свой ход.");
					num = ((int)num2 * -1709086663) ^ 0x3B8EC95A;
					continue;
				case 18u:
					Form1.smethod_30((Control)(object)richTextBox1);
					num = ((int)num2 * -414068469) ^ -312354137;
					continue;
				case 17u:
					Form1.smethod_30((Control)(object)pictureBox[num29, num7]);
					num = ((int)num2 * -768779581) ^ -2033009547;
					continue;
				case 16u:
					num = -1178313611;
					continue;
				case 15u:
					num = ((int)num2 * -1981270237) ^ -1452306842;
					continue;
				case 14u:
					num25 = 0;
					num26 = 0;
					num27 = 0;
					num28 = 0;
					num = (int)(num2 * 254370508) ^ -570596563;
					continue;
				case 13u:
					num24 = 0;
					num = (int)(num2 * 1451411009) ^ -1298893716;
					continue;
				case 12u:
					flag3 = num19 < 4;
					num = -1967100041;
					continue;
				case 11u:
				{
					int num16;
					int num17;
					if (flag)
					{
						num16 = 279903521;
						num17 = 279903521;
					}
					else
					{
						num16 = 1040340428;
						num17 = 1040340428;
					}
					num = num16 ^ (int)(num2 * 1738234352);
					continue;
				}
				case 10u:
					num = ((int)num2 * -727003268) ^ 0x85D5BCF;
					continue;
				case 9u:
					num15++;
					num = (int)(num2 * 199935397) ^ -304009881;
					continue;
				case 8u:
				{
					int num11;
					int num12;
					if (!Form1.smethod_46((Control)(object)pictureBox1))
					{
						num11 = -230626119;
						num12 = -230626119;
					}
					else
					{
						num11 = -1531884515;
						num12 = -1531884515;
					}
					num = num11 ^ ((int)num2 * -1787823980);
					continue;
				}
				case 7u:
					Paint_Board();
					if (!Stop(board))
					{
						num = (int)((num2 * 1650183062) ^ 0x5E22408C);
						continue;
					}
					num6 = 0;
					goto IL_1448;
				case 6u:
					num7 = 0;
					num = -537550554;
					continue;
				case 5u:
					num6 = ((!Standoff(board)) ? 1 : 0);
					goto IL_1448;
				case 4u:
					num = (int)(num2 * 799974565) ^ -507994758;
					continue;
				case 3u:
					Form1.smethod_7((Control)(object)pictureBox[num4, num5], bool_0: false);
					num = (int)((num2 * 196943211) ^ 0x6F57FFC3);
					continue;
				case 2u:
					Form1.smethod_15(timer1);
					num = -1714770329;
					continue;
				case 1u:
					num3 = 0;
					num = ((int)num2 * -1857604474) ^ -1553138795;
					continue;
				case 0u:
					num = (int)((num2 * 551275572) ^ 0x106142BC);
					continue;
				default:
					return;
				case 84u:
					break;
				case 87u:
					return;
					IL_1448:
					flag = (byte)num6 != 0;
					num = -304836744;
					continue;
					IL_0174:
					num = -562451292;
					num18 = -562451292;
					continue;
					IL_0c86:
					flag6 = (byte)num36 != 0;
					num = -1368482967;
					continue;
					IL_0168:
					num = -661599403;
					num18 = -661599403;
					continue;
					IL_08c6:
					num = -262201467;
					num51 = -262201467;
					continue;
				}
				break;
			}
		}
	}

	private bool Stop(Figurine[,] mem)
	{
		bool flag = false;
		int num3 = default(int);
		bool result = default(bool);
		while (true)
		{
			int num = -221725871;
			while (true)
			{
				uint num2;
				int num26;
				int num49;
				switch ((num2 = (uint)num ^ 0xD87CCBDBu) % 76u)
				{
				case 75u:
					if (mem[1, 2] != null)
					{
						num = (int)(num2 * 988422385) ^ -1000561238;
						continue;
					}
					goto IL_0033;
				case 74u:
					if (mem[1, 2].Square == mem[2, 1].Square)
					{
						num = (int)((num2 * 549632100) ^ 0x2578C2B8);
						continue;
					}
					goto IL_0033;
				case 73u:
					if (mem[2, 2].Big != mem[3, 3].Big)
					{
						num = (int)(num2 * 1562809298) ^ -1119687506;
						continue;
					}
					goto IL_0027;
				case 72u:
					if (mem[num3, 2].Point != mem[num3, 3].Point)
					{
						num = (int)((num2 * 479621795) ^ 0x27B02E40);
						continue;
					}
					goto IL_00e8;
				case 71u:
				{
					int num22;
					if (mem[0, num3].Dark != mem[1, num3].Dark)
					{
						num = -65826046;
						num22 = -65826046;
					}
					else
					{
						num = -758577681;
						num22 = -758577681;
					}
					continue;
				}
				case 70u:
					if (mem[2, 2].Dark != mem[3, 3].Dark)
					{
						num = (int)(num2 * 1025113110) ^ -85127405;
						continue;
					}
					goto IL_0027;
				case 69u:
				{
					int num62;
					int num63;
					if (mem[1, 2].Point != mem[2, 1].Point)
					{
						num62 = -1778583387;
						num63 = -1778583387;
					}
					else
					{
						num62 = -1440852453;
						num63 = -1440852453;
					}
					num = num62 ^ ((int)num2 * -2006766878);
					continue;
				}
				case 68u:
					if (mem[0, 3].Square == mem[1, 2].Square)
					{
						num = -556351275;
						continue;
					}
					goto IL_0033;
				case 67u:
					if (mem[2, num3].Dark != mem[3, num3].Dark)
					{
						num = ((int)num2 * -1557605563) ^ 0x70C932B5;
						continue;
					}
					goto IL_00e8;
				case 66u:
				{
					int num35;
					int num36;
					if (mem[1, num3].Big != mem[2, num3].Big)
					{
						num35 = -1996779488;
						num36 = -1996779488;
					}
					else
					{
						num35 = -1650148766;
						num36 = -1650148766;
					}
					num = num35 ^ (int)(num2 * 1987255994);
					continue;
				}
				case 65u:
				{
					int num7;
					int num8;
					if (mem[num3, 2] != null)
					{
						num7 = 223015564;
						num8 = 223015564;
					}
					else
					{
						num7 = 1661937829;
						num8 = 1661937829;
					}
					num = num7 ^ ((int)num2 * -579829726);
					continue;
				}
				case 64u:
				{
					int num55;
					int num56;
					if (mem[3, 3] != null)
					{
						num55 = -54539561;
						num56 = -54539561;
					}
					else
					{
						num55 = -912969987;
						num56 = -912969987;
					}
					num = num55 ^ ((int)num2 * -1798233339);
					continue;
				}
				case 63u:
				{
					int num47;
					if (mem[num3, 0].Square != mem[num3, 1].Square)
					{
						num = -1484756057;
						num47 = -1484756057;
					}
					else
					{
						num = -1433216949;
						num47 = -1433216949;
					}
					continue;
				}
				case 62u:
				{
					int num37;
					if (num3 < 4)
					{
						num = -26215418;
						num37 = -26215418;
					}
					else
					{
						num = -1548106180;
						num37 = -1548106180;
					}
					continue;
				}
				case 61u:
				{
					int num16;
					int num17;
					if (mem[num3, 3] == null)
					{
						num16 = -1448892154;
						num17 = -1448892154;
					}
					else
					{
						num16 = -787555078;
						num17 = -787555078;
					}
					num = num16 ^ ((int)num2 * -1641919715);
					continue;
				}
				case 60u:
					if (mem[num3, 2].Big != mem[num3, 3].Big)
					{
						num = ((int)num2 * -1925806353) ^ 0x5F01B56;
						continue;
					}
					goto IL_00e8;
				case 59u:
				{
					int num66;
					int num67;
					if (mem[num3, 1].Dark == mem[num3, 2].Dark)
					{
						num66 = -851391356;
						num67 = -851391356;
					}
					else
					{
						num66 = -43649905;
						num67 = -43649905;
					}
					num = num66 ^ ((int)num2 * -1935998109);
					continue;
				}
				case 58u:
					if (mem[2, 2].Square != mem[3, 3].Square)
					{
						num = (int)((num2 * 468965550) ^ 0x7B9D1EE5);
						continue;
					}
					goto IL_0027;
				case 57u:
				{
					int num52;
					if (mem[num3, 0].Point == mem[num3, 1].Point)
					{
						num = -889189717;
						num52 = -889189717;
					}
					else
					{
						num = -1084653260;
						num52 = -1084653260;
					}
					continue;
				}
				case 56u:
				{
					int num45;
					int num46;
					if (mem[num3, 1].Point != mem[num3, 2].Point)
					{
						num45 = -1625801996;
						num46 = -1625801996;
					}
					else
					{
						num45 = -692236825;
						num46 = -692236825;
					}
					num = num45 ^ (int)(num2 * 1608428452);
					continue;
				}
				case 55u:
				{
					int num42;
					if (mem[0, 3].Dark == mem[1, 2].Dark)
					{
						num = -1754948099;
						num42 = -1754948099;
					}
					else
					{
						num = -917304784;
						num42 = -917304784;
					}
					continue;
				}
				case 54u:
				{
					int num29;
					int num30;
					if (mem[1, 1].Point != mem[2, 2].Point)
					{
						num29 = -1462844560;
						num30 = -1462844560;
					}
					else
					{
						num29 = -857337312;
						num30 = -857337312;
					}
					num = num29 ^ ((int)num2 * -1037140230);
					continue;
				}
				case 53u:
					num = (int)((num2 * 1576439315) ^ 0x492AC70E);
					continue;
				case 52u:
					if (mem[num3, 2].Square != mem[num3, 3].Square)
					{
						num = ((int)num2 * -1011933550) ^ -1774750193;
						continue;
					}
					goto IL_00e8;
				case 51u:
				{
					int num20;
					int num21;
					if (mem[num3, 0] == null)
					{
						num20 = 172351904;
						num21 = 172351904;
					}
					else
					{
						num20 = 481336669;
						num21 = 481336669;
					}
					num = num20 ^ ((int)num2 * -947128363);
					continue;
				}
				case 50u:
					if (mem[2, 1].Dark != mem[3, 0].Dark)
					{
						num = (int)(num2 * 216234972) ^ -467619048;
						continue;
					}
					goto IL_0027;
				case 49u:
				{
					int num4;
					if (mem[0, num3].Point != mem[1, num3].Point)
					{
						num = -1668883725;
						num4 = -1668883725;
					}
					else
					{
						num = -2034187377;
						num4 = -2034187377;
					}
					continue;
				}
				case 48u:
				{
					int num64;
					int num65;
					if (mem[num3, 0].Big == mem[num3, 1].Big)
					{
						num64 = -161271960;
						num65 = -161271960;
					}
					else
					{
						num64 = -1205285146;
						num65 = -1205285146;
					}
					num = num64 ^ (int)(num2 * 921209568);
					continue;
				}
				case 47u:
				{
					int num58;
					int num59;
					if (mem[0, 0] != null)
					{
						num58 = 69544007;
						num59 = 69544007;
					}
					else
					{
						num58 = 1309433914;
						num59 = 1309433914;
					}
					num = num58 ^ (int)(num2 * 559922677);
					continue;
				}
				case 46u:
				{
					int num53;
					int num54;
					if (mem[1, 2].Dark != mem[2, 1].Dark)
					{
						num53 = -651213450;
						num54 = -651213450;
					}
					else
					{
						num53 = -1694053605;
						num54 = -1694053605;
					}
					num = num53 ^ ((int)num2 * -1597697231);
					continue;
				}
				case 45u:
					if (mem[3, num3] != null)
					{
						num = (int)(num2 * 1188354013) ^ -1182252373;
						continue;
					}
					goto IL_00dc;
				case 44u:
				{
					int num40;
					int num41;
					if (mem[1, num3].Point == mem[2, num3].Point)
					{
						num40 = 1596802860;
						num41 = 1596802860;
					}
					else
					{
						num40 = 74469711;
						num41 = 74469711;
					}
					num = num40 ^ (int)(num2 * 940787187);
					continue;
				}
				case 43u:
				{
					int num33;
					int num34;
					if (mem[0, 3].Big != mem[1, 2].Big)
					{
						num33 = 2073679908;
						num34 = 2073679908;
					}
					else
					{
						num33 = 1809923346;
						num34 = 1809923346;
					}
					num = num33 ^ (int)(num2 * 1922006028);
					continue;
				}
				case 42u:
					if (mem[2, 1].Point != mem[3, 0].Point)
					{
						num = (int)((num2 * 35171362) ^ 0x1AD8557B);
						continue;
					}
					goto IL_0027;
				case 41u:
					if (mem[2, num3].Big != mem[3, num3].Big)
					{
						num = (int)(num2 * 1621250772) ^ -1801300024;
						continue;
					}
					goto IL_00e8;
				case 40u:
				{
					int num23;
					int num24;
					if (mem[0, 0].Big == mem[1, 1].Big)
					{
						num23 = -2129871495;
						num24 = -2129871495;
					}
					else
					{
						num23 = -958596748;
						num24 = -958596748;
					}
					num = num23 ^ (int)(num2 * 894473716);
					continue;
				}
				case 39u:
					if (mem[2, 1].Square == mem[3, 0].Square)
					{
						goto IL_0027;
					}
					goto IL_0033;
				case 38u:
					if (mem[num3, 2].Dark != mem[num3, 3].Dark)
					{
						num = ((int)num2 * -1066349535) ^ 0x10DB9310;
						continue;
					}
					goto IL_00e8;
				case 36u:
				{
					int num14;
					int num15;
					if (mem[1, 1].Square == mem[2, 2].Square)
					{
						num14 = -1360983495;
						num15 = -1360983495;
					}
					else
					{
						num14 = -84565183;
						num15 = -84565183;
					}
					num = num14 ^ (int)(num2 * 1229214311);
					continue;
				}
				case 35u:
					if (mem[2, 2].Point != mem[3, 3].Point)
					{
						num = ((int)num2 * -1712906356) ^ 0x5C8CD3C8;
						continue;
					}
					goto IL_0027;
				case 34u:
					if (mem[1, num3].Square == mem[2, num3].Square)
					{
						num = (int)((num2 * 2076467521) ^ 0x59EDF37);
						continue;
					}
					goto IL_00dc;
				case 33u:
				{
					int num9;
					if (mem[num3, 0].Dark != mem[num3, 1].Dark)
					{
						num = -266705810;
						num9 = -266705810;
					}
					else
					{
						num = -1394766800;
						num9 = -1394766800;
					}
					continue;
				}
				case 32u:
				{
					int num68;
					if (mem[0, 0].Point != mem[1, 1].Point)
					{
						num = -428256932;
						num68 = -428256932;
					}
					else
					{
						num = -1375613291;
						num68 = -1375613291;
					}
					continue;
				}
				case 31u:
					if (mem[2, num3].Point != mem[3, num3].Point)
					{
						num = ((int)num2 * -1095603314) ^ -2040611223;
						continue;
					}
					goto IL_00e8;
				case 30u:
					if (mem[2, 1] != null)
					{
						num = (int)(num2 * 85922370) ^ -639932566;
						continue;
					}
					goto IL_0033;
				case 29u:
				{
					int num60;
					int num61;
					if (mem[2, 2] == null)
					{
						num60 = -1461010912;
						num61 = -1461010912;
					}
					else
					{
						num60 = -1343429610;
						num61 = -1343429610;
					}
					num = num60 ^ ((int)num2 * -358271787);
					continue;
				}
				case 28u:
					flag = true;
					num = (int)((num2 * 1853326096) ^ 0x56A35169);
					continue;
				case 27u:
				{
					int num57;
					if (mem[0, 3].Point == mem[1, 2].Point)
					{
						num = -1200117618;
						num57 = -1200117618;
					}
					else
					{
						num = -1346085969;
						num57 = -1346085969;
					}
					continue;
				}
				case 26u:
					if (mem[2, 1].Big != mem[3, 0].Big)
					{
						num = ((int)num2 * -1636490445) ^ 0x496A7F7A;
						continue;
					}
					goto IL_0027;
				case 25u:
				{
					int num50;
					int num51;
					if (mem[1, 1].Dark == mem[2, 2].Dark)
					{
						num50 = 597472632;
						num51 = 597472632;
					}
					else
					{
						num50 = 1268410094;
						num51 = 1268410094;
					}
					num = num50 ^ (int)(num2 * 830232885);
					continue;
				}
				case 24u:
					num = (int)(num2 * 540424185) ^ -730190158;
					continue;
				case 23u:
				{
					int num48;
					if (mem[0, 0].Square != mem[1, 1].Square)
					{
						num = -1868646103;
						num48 = -1868646103;
					}
					else
					{
						num = -1829213565;
						num48 = -1829213565;
					}
					continue;
				}
				case 22u:
					num3 = 0;
					num = (int)(num2 * 861558857) ^ -1180585032;
					continue;
				case 21u:
					if (mem[1, num3] != null)
					{
						num = ((int)num2 * -1237544175) ^ 0x53AE78C9;
						continue;
					}
					goto IL_00dc;
				case 20u:
					flag = true;
					num = ((int)num2 * -365167164) ^ -1905057876;
					continue;
				case 19u:
					result = flag;
					num = -360468737;
					continue;
				case 18u:
				{
					int num43;
					int num44;
					if (mem[1, 1].Big == mem[2, 2].Big)
					{
						num43 = 566379062;
						num44 = 566379062;
					}
					else
					{
						num43 = 1063192940;
						num44 = 1063192940;
					}
					num = num43 ^ (int)(num2 * 1764388220);
					continue;
				}
				case 17u:
				{
					int num38;
					int num39;
					if (mem[1, 2].Big != mem[2, 1].Big)
					{
						num38 = -694188726;
						num39 = -694188726;
					}
					else
					{
						num38 = -1342173297;
						num39 = -1342173297;
					}
					num = num38 ^ ((int)num2 * -1491856430);
					continue;
				}
				case 16u:
					num3++;
					num = ((int)num2 * -84981791) ^ 0x1CAFBC59;
					continue;
				case 15u:
				{
					int num31;
					int num32;
					if (mem[num3, 1].Big != mem[num3, 2].Big)
					{
						num31 = 308130932;
						num32 = 308130932;
					}
					else
					{
						num31 = 1094628377;
						num32 = 1094628377;
					}
					num = num31 ^ (int)(num2 * 1573898278);
					continue;
				}
				case 14u:
					if (mem[0, 3] != null)
					{
						num = -300634660;
						continue;
					}
					goto IL_0033;
				case 13u:
					num = -364646480;
					continue;
				case 12u:
				{
					int num27;
					int num28;
					if (mem[1, num3].Dark != mem[2, num3].Dark)
					{
						num27 = 1434576542;
						num28 = 1434576542;
					}
					else
					{
						num27 = 2012081292;
						num28 = 2012081292;
					}
					num = num27 ^ (int)(num2 * 351354307);
					continue;
				}
				case 11u:
				{
					int num25;
					if (mem[0, 0].Dark != mem[1, 1].Dark)
					{
						num = -1306443745;
						num25 = -1306443745;
					}
					else
					{
						num = -1010597482;
						num25 = -1010597482;
					}
					continue;
				}
				case 10u:
					num = -777709001;
					continue;
				case 9u:
					if (mem[3, 0] != null)
					{
						num = (int)((num2 * 64322421) ^ 0x21CF49C1);
						continue;
					}
					goto IL_0033;
				case 8u:
					if (mem[0, num3] != null)
					{
						num = -1088095438;
						continue;
					}
					goto IL_00dc;
				case 7u:
					if (mem[2, num3] != null)
					{
						num = ((int)num2 * -1237464530) ^ 0x5678B818;
						continue;
					}
					goto IL_00dc;
				case 5u:
				{
					int num18;
					int num19;
					if (mem[0, num3].Big != mem[1, num3].Big)
					{
						num18 = 739012758;
						num19 = 739012758;
					}
					else
					{
						num18 = 1492005087;
						num19 = 1492005087;
					}
					num = num18 ^ (int)(num2 * 455801842);
					continue;
				}
				case 4u:
				{
					int num12;
					int num13;
					if (mem[num3, 1].Square == mem[num3, 2].Square)
					{
						num12 = -1976336641;
						num13 = -1976336641;
					}
					else
					{
						num12 = -1797977417;
						num13 = -1797977417;
					}
					num = num12 ^ (int)(num2 * 214274969);
					continue;
				}
				case 3u:
				{
					int num10;
					int num11;
					if (mem[1, 1] == null)
					{
						num10 = 1432853520;
						num11 = 1432853520;
					}
					else
					{
						num10 = 237313415;
						num11 = 237313415;
					}
					num = num10 ^ ((int)num2 * -1341020233);
					continue;
				}
				case 2u:
					if (mem[2, num3].Square != mem[3, num3].Square)
					{
						goto IL_00dc;
					}
					goto IL_00e8;
				case 1u:
				{
					int num5;
					int num6;
					if (mem[num3, 1] == null)
					{
						num5 = 1834296282;
						num6 = 1834296282;
					}
					else
					{
						num5 = 106838487;
						num6 = 106838487;
					}
					num = num5 ^ (int)(num2 * 658234877);
					continue;
				}
				case 0u:
					if (mem[0, num3].Square == mem[1, num3].Square)
					{
						num = -580554503;
						continue;
					}
					goto IL_00dc;
				case 6u:
					break;
				default:
					{
						return result;
					}
					IL_0027:
					num = -1559114513;
					num26 = -1559114513;
					continue;
					IL_00dc:
					num = -1093766743;
					num49 = -1093766743;
					continue;
					IL_00e8:
					num = -2091438057;
					num49 = -2091438057;
					continue;
					IL_0033:
					num = -18810756;
					num26 = -18810756;
					continue;
				}
				break;
			}
		}
	}

	private bool Standoff(Figurine[,] mem)
	{
		int num4 = default(int);
		bool flag2 = default(bool);
		bool flag3 = default(bool);
		int num3 = default(int);
		bool result = default(bool);
		bool flag = default(bool);
		while (true)
		{
			int num = 1958106639;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x4E642243u) % 17u)
				{
				case 16u:
					num4++;
					num = ((int)num2 * -792413737) ^ -1342610220;
					continue;
				case 15u:
					num = ((int)num2 * -1553118585) ^ 0x5B7A02F1;
					continue;
				case 14u:
				{
					int num6;
					int num7;
					if (!flag2)
					{
						num6 = 1532518007;
						num7 = 1532518007;
					}
					else
					{
						num6 = 1148637661;
						num7 = 1148637661;
					}
					num = num6 ^ ((int)num2 * -1886897878);
					continue;
				}
				case 13u:
				{
					int num8;
					int num9;
					if (!flag3)
					{
						num8 = -1755487676;
						num9 = -1755487676;
					}
					else
					{
						num8 = -1545052285;
						num9 = -1545052285;
					}
					num = num8 ^ (int)(num2 * 2051565246);
					continue;
				}
				case 12u:
					num4 = 0;
					num = (int)(num2 * 1698662821) ^ -408462590;
					continue;
				case 11u:
				{
					int num5;
					if (mem[num4, num3] != null)
					{
						num = 968990216;
						num5 = 968990216;
					}
					else
					{
						num = 1742801376;
						num5 = 1742801376;
					}
					continue;
				}
				case 10u:
					result = flag;
					num = ((int)num2 * -1867264481) ^ 0x22C134FC;
					continue;
				case 7u:
					num = (int)((num2 * 1718293922) ^ 0x698209A7);
					continue;
				case 6u:
					flag = false;
					num = (int)((num2 * 1931935099) ^ 0x7B8F9059);
					continue;
				case 5u:
					num = (int)((num2 * 571782783) ^ 0x1293A6F5);
					continue;
				case 4u:
					flag3 = num4 < 4;
					num = 522726143;
					continue;
				case 3u:
					num3++;
					num = 1028195226;
					continue;
				case 2u:
					flag2 = num3 < 4;
					num = 1086379542;
					continue;
				case 1u:
					flag = true;
					num = (int)((num2 * 341555485) ^ 0x50200D1B);
					continue;
				case 0u:
					num3 = 0;
					num = 386233534;
					continue;
				case 9u:
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
			int num = 949972689;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1C3DAB22u) % 9u)
				{
				case 8u:
					num = ((int)num2 * -187432344) ^ 0x67A5F433;
					continue;
				case 7u:
					num = (int)(num2 * 1327386288) ^ -900944197;
					continue;
				case 5u:
					Form1.smethod_32((Control)(object)label5, "Игрок: ");
					num = ((int)num2 * -744975199) ^ -213186943;
					continue;
				case 3u:
					Form1.smethod_32((Control)(object)label1, "");
					Form1.smethod_32((Control)(object)label2, "");
					num = ((int)num2 * -1254850343) ^ 0x22FBE7BA;
					continue;
				case 2u:
					Form1.smethod_32((Control)(object)label6, str);
					num = ((int)num2 * -1466460826) ^ 0x38794C6E;
					continue;
				case 1u:
					Form1.smethod_50((Control)(object)label6, Form1.smethod_37((Control)(object)label5).X + Form1.smethod_18((Control)(object)label5));
					num = (int)(num2 * 809494912) ^ -857918042;
					continue;
				case 0u:
					Form1.smethod_50((Control)(object)label5, (Form1.smethod_49((Control)(object)this) - (Form1.smethod_18((Control)(object)label5) + Form1.smethod_18((Control)(object)label6))) / 2);
					num = ((int)num2 * -18878848) ^ 0x120D0D08;
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

	protected override void Dispose(bool disposing)
	{
		if (disposing)
		{
			goto IL_003b;
		}
		int num = 0;
		goto IL_00b2;
		IL_00a9:
		num = ((components != null) ? 1 : 0);
		goto IL_00b2;
		IL_003b:
		int num2 = -1294196397;
		goto IL_0078;
		IL_0078:
		bool flag = default(bool);
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)num2 ^ 0xCC72B281u) % 8u)
			{
			case 7u:
				((Form)this).Dispose(disposing);
				num2 = -1650880366;
				continue;
			case 6u:
			{
				int num4;
				int num5;
				if (flag)
				{
					num4 = -863623636;
					num5 = -863623636;
				}
				else
				{
					num4 = -1604172070;
					num5 = -1604172070;
				}
				num2 = num4 ^ ((int)num3 * -990034378);
				continue;
			}
			case 5u:
				break;
			case 4u:
				num2 = ((int)num3 * -1976391095) ^ 0x3C1C124A;
				continue;
			case 1u:
				num2 = ((int)num3 * -588824179) ^ -1142256620;
				continue;
			case 0u:
				Form1.smethod_51((IDisposable)components);
				num2 = ((int)num3 * -619791461) ^ 0x5AE5A535;
				continue;
			default:
				return;
			case 2u:
				goto IL_00a9;
			case 3u:
				return;
			}
			break;
		}
		goto IL_003b;
		IL_00b2:
		flag = (byte)num != 0;
		num2 = -1218010049;
		goto IL_0078;
	}

	private void InitializeComponent()
	{
		//IL_044c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0456: Expected O, but got Unknown
		byte[] array = default(byte[]);
		int num3 = default(int);
		object[] object_ = default(object[]);
		string sa = default(string);
		while (true)
		{
			int num = 938795677;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x51FD188Eu) % 122u)
				{
				case 121u:
					Form1.smethod_80((ContainerControl)(object)this, (AutoScaleMode)1);
					num = (int)((num2 * 1584808063) ^ 0x19EA829D);
					continue;
				case 120u:
					num = (int)(num2 * 1983816266) ^ -524861124;
					continue;
				case 119u:
					num = ((int)num2 * -1761001268) ^ -1465622031;
					continue;
				case 118u:
					array[num3] = Form1.smethod_69(Form1.smethod_68(sa, num3 * 2, 2), 16);
					num3++;
					num = 920503518;
					continue;
				case 117u:
					num = ((int)num2 * -1040625204) ^ 0x1845819C;
					continue;
				case 116u:
				{
					int num4;
					if (num3 < 22528)
					{
						num = 1679859992;
						num4 = 1679859992;
					}
					else
					{
						num = 85730816;
						num4 = 85730816;
					}
					continue;
				}
				case 115u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)richTextBox1);
					num = ((int)num2 * -1559324442) ^ 0x5AF5203C;
					continue;
				case 114u:
					num = (int)((num2 * 1412306342) ^ 0x691E403F);
					continue;
				case 113u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)panel1);
					num = (int)(num2 * 1917371931) ^ -849212104;
					continue;
				case 112u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label5);
					num = (int)((num2 * 2079624523) ^ 0x161FD12B);
					continue;
				case 111u:
					Form1.smethod_91((Control)(object)this, bool_0: false);
					num = ((int)num2 * -149152334) ^ 0x1C885B38;
					continue;
				case 110u:
					Form1.smethod_3((Control)(object)button2, new Size(83, 35));
					num = ((int)num2 * -278983500) ^ 0x38B28B15;
					continue;
				case 109u:
					Form1.smethod_83((Form)(object)this, (FormBorderStyle)1);
					num = ((int)num2 * -1969801899) ^ -534909164;
					continue;
				case 108u:
					Form1.smethod_77((Control)(object)label6, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = ((int)num2 * -1112884391) ^ 0x686273B8;
					continue;
				case 107u:
					num = ((int)num2 * -981586876) ^ 0x7D4A682;
					continue;
				case 106u:
					Form1.smethod_74((Control)(object)label2, bool_0: true);
					num = ((int)num2 * -101110232) ^ -2053255342;
					continue;
				case 105u:
					num = ((int)num2 * -658107510) ^ -1846675373;
					continue;
				case 104u:
					Form1.smethod_61((Control)(object)label1, "label1");
					num = ((int)num2 * -270193398) ^ -713334639;
					continue;
				case 103u:
					Form1.smethod_64((Control)(object)button2, 4);
					num = (int)(num2 * 753014617) ^ -1904055526;
					continue;
				case 102u:
					Form1.smethod_75((Control)(object)label2, (DockStyle)3);
					Form1.smethod_77((Control)(object)label2, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = ((int)num2 * -218602804) ^ -59897977;
					continue;
				case 101u:
					num = (int)((num2 * 429391919) ^ 0x48750247);
					continue;
				case 100u:
					Form1.smethod_4((Control)(object)richTextBox1, new Point(107, 275));
					num = (int)((num2 * 1219534949) ^ 0xAB3F3CE);
					continue;
				case 99u:
					Form1.smethod_3((Control)(object)label5, new Size(0, 16));
					num = ((int)num2 * -162096346) ^ 0x350D3D89;
					continue;
				case 98u:
					num = ((int)num2 * -876008017) ^ 0x4DA8F2E3;
					continue;
				case 97u:
					Form1.smethod_64((Control)(object)button1, 5);
					num = ((int)num2 * -576485915) ^ -537805552;
					continue;
				case 95u:
					Form1.smethod_67((Control)(object)button2, (EventHandler)Button2_Click);
					num = (int)((num2 * 1375306157) ^ 0x2AD524AB);
					continue;
				case 94u:
					num = (int)((num2 * 1431806095) ^ 0x14CB83B);
					continue;
				case 93u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label2);
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label1);
					num = ((int)num2 * -151203223) ^ -1398937549;
					continue;
				case 92u:
					Form1.smethod_73(timer1, (EventHandler)Timer1_Tick);
					Form1.smethod_74((Control)(object)label1, bool_0: true);
					num = (int)(num2 * 1008762132) ^ -497163409;
					continue;
				case 91u:
					Form1.smethod_65((Control)(object)button1, bool_0: false);
					num = (int)((num2 * 1777961628) ^ 0xF6A6CF4);
					continue;
				case 90u:
					Form1.smethod_81((Form)(object)this, new Size(486, 319));
					num = (int)(num2 * 794498248) ^ -362855582;
					continue;
				case 89u:
					Form1.smethod_60(pictureBox1, (BorderStyle)2);
					num = ((int)num2 * -1973083184) ^ -1324949574;
					continue;
				case 88u:
					num = ((int)num2 * -1510293092) ^ 0x2BE918DE;
					continue;
				case 87u:
					num = ((int)num2 * -801200283) ^ -1075965686;
					continue;
				case 86u:
					Form1.smethod_6((Control)(object)pictureBox1, new MouseEventHandler(PictureBox1_MouseDown));
					num = (int)(num2 * 210055532) ^ -571039627;
					continue;
				case 85u:
					Form1.smethod_3((Control)(object)label6, new Size(0, 16));
					num = (int)(num2 * 231288270) ^ -1823727885;
					continue;
				case 84u:
					panel1 = Form1.smethod_55();
					timer1 = Form1.smethod_56(components);
					num = ((int)num2 * -377055650) ^ 0x7AFF478B;
					continue;
				case 83u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)pictureBox1);
					num = (int)(num2 * 2026391861) ^ -1819622336;
					continue;
				case 82u:
					Form1.smethod_66((ButtonBase)(object)button1, bool_0: true);
					num = (int)((num2 * 2029061083) ^ 0x732806B5);
					continue;
				case 81u:
					Form1.smethod_79((ContainerControl)(object)this, new SizeF(6f, 13f));
					num = ((int)num2 * -1218946093) ^ -1221354715;
					continue;
				case 80u:
					Form1.smethod_61((Control)(object)pictureBox1, "pictureBox1");
					Form1.smethod_3((Control)(object)pictureBox1, new Size(246, 246));
					Form1.smethod_62(pictureBox1, 0);
					Form1.smethod_63(pictureBox1, bool_0: false);
					num = (int)(num2 * 1798295500) ^ -1589237378;
					continue;
				case 79u:
					label1 = Form1.smethod_57();
					label2 = Form1.smethod_57();
					num = (int)(num2 * 373311272) ^ -1103028446;
					continue;
				case 78u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)button2);
					num = (int)((num2 * 1542736423) ^ 0x276E96FA);
					continue;
				case 77u:
					Form1.smethod_65((Control)(object)richTextBox1, bool_0: false);
					num = ((int)num2 * -1658525524) ^ -1793015975;
					continue;
				case 76u:
					num = (int)((num2 * 909080990) ^ 0x756B6B7A);
					continue;
				case 75u:
					Form1.smethod_59((Control)(object)this);
					num = ((int)num2 * -2067040946) ^ -1944335437;
					continue;
				case 74u:
					CharArray(array, string.Empty);
					num = ((int)num2 * -1036327260) ^ -961573251;
					continue;
				case 73u:
					num = (int)((num2 * 1221726065) ^ 0x1CA249F6);
					continue;
				case 72u:
					Form1.smethod_61((Control)(object)label5, "label5");
					num = (int)((num2 * 1375113838) ^ 0x6EA3D97B);
					continue;
				case 71u:
					num = (int)(num2 * 96769739) ^ -991155985;
					continue;
				case 70u:
					button1 = Form1.smethod_53();
					num = ((int)num2 * -590811793) ^ 0x511AF5AE;
					continue;
				case 69u:
					Form1.smethod_64((Control)(object)richTextBox1, 6);
					num = ((int)num2 * -1812784355) ^ -333852892;
					continue;
				case 68u:
					Form1.smethod_85((Control)(object)this, "Form1");
					Form1.smethod_86((Form)(object)this, bool_0: false);
					num = ((int)num2 * -943310908) ^ -958012652;
					continue;
				case 67u:
					Form1.smethod_65((Control)(object)button2, bool_0: false);
					num = (int)((num2 * 196776221) ^ 0x5D8ADBF1);
					continue;
				case 66u:
					Form1.smethod_4((Control)(object)button1, new Point(12, 275));
					Form1.smethod_61((Control)(object)button1, "button1");
					num = ((int)num2 * -1217462825) ^ -1018519730;
					continue;
				case 65u:
					num = (int)((num2 * 435688477) ^ 0x5736D9BD);
					continue;
				case 64u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)button1);
					num = ((int)num2 * -618033015) ^ 0x7BB2002F;
					continue;
				case 63u:
					Form1.smethod_61((Control)(object)richTextBox1, "richTextBox1");
					num = ((int)num2 * -1938019686) ^ -998954428;
					continue;
				case 62u:
					Form1.smethod_64((Control)(object)label1, 8);
					num = ((int)num2 * -535913758) ^ 0x464C7682;
					continue;
				case 61u:
					object_ = new object[3]
					{
						Player.MembershipCondition(0),
						Player.MembershipCondition(1),
						"Cytotechnologist"
					};
					num = (int)(num2 * 1468651023) ^ -1701844111;
					continue;
				case 60u:
					Form1.smethod_70(ComMember, object_);
					num = (int)((num2 * 1534374915) ^ 0x12F56726);
					continue;
				case 59u:
					Form1.smethod_75((Control)(object)label1, (DockStyle)4);
					Form1.smethod_77((Control)(object)label1, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = ((int)num2 * -483386168) ^ -1520324647;
					continue;
				case 58u:
					num = (int)(num2 * 703479325) ^ -384258085;
					continue;
				case 57u:
					Form1.smethod_72(timer1, 1000);
					num = ((int)num2 * -1866792643) ^ 0x3673BCBB;
					continue;
				case 56u:
					Form1.smethod_71((TextBoxBase)(object)richTextBox1, bool_0: true);
					num = (int)((num2 * 980216561) ^ 0x50BDC024);
					continue;
				case 55u:
					Form1.smethod_61((Control)(object)button2, "button2");
					num = (int)(num2 * 2108199742) ^ -148461413;
					continue;
				case 54u:
					num = ((int)num2 * -605230164) ^ -1234704281;
					continue;
				case 53u:
					Form1.smethod_32((Control)(object)richTextBox1, "");
					num = (int)((num2 * 1004783888) ^ 0x487632A0);
					continue;
				case 52u:
					Form1.smethod_64((Control)(object)label2, 9);
					num = ((int)num2 * -1815793415) ^ 0x4706C451;
					continue;
				case 51u:
					Form1.smethod_3((Control)(object)label1, new Size(0, 16));
					num = (int)((num2 * 701136970) ^ 0x6CEAFA3A);
					continue;
				case 50u:
					Form1.smethod_3((Control)(object)button1, new Size(83, 35));
					num = (int)((num2 * 551776761) ^ 0x74DEB13D);
					continue;
				case 49u:
					Form1.smethod_4((Control)(object)button2, new Point(391, 275));
					num = (int)(num2 * 511105152) ^ -1996610795;
					continue;
				case 48u:
					Form1.smethod_32((Control)(object)button2, "Подтвердить");
					num = (int)(num2 * 84209412) ^ -1653749179;
					continue;
				case 47u:
					Form1.smethod_64((Control)(object)label6, 13);
					num = (int)((num2 * 1628276224) ^ 0x6583EE67);
					continue;
				case 46u:
					Form1.smethod_66((ButtonBase)(object)button2, bool_0: true);
					num = (int)(num2 * 2032247249) ^ -736267889;
					continue;
				case 45u:
					Form1.smethod_4((Control)(object)label2, new Point(0, 0));
					num = ((int)num2 * -1624957747) ^ 0x5AFCAD7C;
					continue;
				case 44u:
					Form1.smethod_3((Control)(object)richTextBox1, new Size(272, 35));
					num = (int)(num2 * 1419282861) ^ -1960061471;
					continue;
				case 43u:
					num = ((int)num2 * -395713519) ^ -1896748910;
					continue;
				case 42u:
					num = (int)(num2 * 1131063024) ^ -1200285807;
					continue;
				case 41u:
					Form1.smethod_4((Control)(object)panel1, new Point(0, 24));
					num = (int)((num2 * 779591506) ^ 0x1092BD57);
					continue;
				case 40u:
					num3 = 0;
					num = (int)((num2 * 218322348) ^ 0x27195F06);
					continue;
				case 38u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label6);
					num = (int)(num2 * 43763442) ^ -1945289624;
					continue;
				case 37u:
					Form1.smethod_64((Control)(object)panel1, 7);
					num = ((int)num2 * -469060422) ^ 0x5ED73355;
					continue;
				case 36u:
					label5 = Form1.smethod_57();
					label6 = Form1.smethod_57();
					Form1.smethod_58((ISupportInitialize)pictureBox1);
					num = (int)((num2 * 955875378) ^ 0x31DD85D1);
					continue;
				case 35u:
					Form1.smethod_90((ISupportInitialize)pictureBox1);
					num = ((int)num2 * -724793321) ^ 0x4E18D4C6;
					continue;
				case 34u:
					Form1.smethod_4((Control)(object)label6, new Point(275, 0));
					num = (int)((num2 * 1001010021) ^ 0x7E533844);
					continue;
				case 33u:
					Form1.smethod_84((Form)(object)this, bool_0: false);
					num = (int)((num2 * 1595436753) ^ 0x8A08607);
					continue;
				case 32u:
					Form1.smethod_5((Control)(object)richTextBox1, Color.White);
					num = ((int)num2 * -658621136) ^ 0x760C132C;
					continue;
				case 31u:
					num = ((int)num2 * -283465082) ^ 0x117304DB;
					continue;
				case 30u:
					Form1.smethod_5((Control)(object)this, Color.White);
					num = (int)((num2 * 1496654141) ^ 0x1EF6D402);
					continue;
				case 29u:
					Form1.smethod_77((Control)(object)label5, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = ((int)num2 * -809903032) ^ 0x672FF881;
					continue;
				case 28u:
					num = (int)(num2 * 1678818560) ^ -891248852;
					continue;
				case 27u:
					num = (int)(num2 * 1061118861) ^ -515461485;
					continue;
				case 26u:
					num = ((int)num2 * -50641521) ^ 0x5C709275;
					continue;
				case 25u:
					Form1.smethod_3((Control)(object)panel1, new Size(486, 240));
					num = ((int)num2 * -1451083405) ^ 0x3A2CD646;
					continue;
				case 24u:
					sa = Veet.Sa;
					sa = Form1.smethod_34(sa, Veet.Xe);
					sa = Form1.smethod_34(sa, Veet.Zr);
					num = (int)(num2 * 370830520) ^ -1055953372;
					continue;
				case 23u:
					Form1.smethod_5((Control)(object)pictureBox1, Color.FromArgb(64, 32, 0));
					num = (int)(num2 * 1469691083) ^ -337116302;
					continue;
				case 22u:
					Form1.smethod_67((Control)(object)button1, (EventHandler)Button1_Click);
					num = (int)(num2 * 333272602) ^ -915549739;
					continue;
				case 21u:
					Form1.smethod_61((Control)(object)label2, "label2");
					Form1.smethod_3((Control)(object)label2, new Size(0, 16));
					num = ((int)num2 * -548662764) ^ 0x19E3BEAA;
					continue;
				case 20u:
					Form1.smethod_4((Control)(object)label5, new Point(197, 0));
					num = (int)((num2 * 1268251107) ^ 0x770E470);
					continue;
				case 19u:
					Form1.smethod_78((Control)(object)label1, (RightToLeft)0);
					num = ((int)num2 * -418954821) ^ 0x462D57;
					continue;
				case 18u:
					Form1.smethod_32((Control)(object)this, "Quarto");
					Form1.smethod_87((Form)(object)this, (EventHandler)Form1_Load);
					num = ((int)num2 * -185688941) ^ 0x74E14FC3;
					continue;
				case 17u:
					Form1.smethod_74((Control)(object)label5, bool_0: true);
					num = ((int)num2 * -1315323180) ^ 0x22A9B65B;
					continue;
				case 16u:
					num = ((int)num2 * -831849810) ^ 0x7E0933FD;
					continue;
				case 15u:
					num = ((int)num2 * -1039905898) ^ 0x1D6AF04C;
					continue;
				case 14u:
					array = new byte[22528];
					num = (int)(num2 * 468162773) ^ -300237378;
					continue;
				case 13u:
					Form1.smethod_61((Control)(object)panel1, "panel1");
					num = ((int)num2 * -407399757) ^ 0x3770C4C3;
					continue;
				case 12u:
					num = (int)(num2 * 1387021265) ^ -1389598748;
					continue;
				case 11u:
					components = Form1.smethod_52();
					pictureBox1 = Form1.smethod_2();
					button2 = Form1.smethod_53();
					num = (int)(num2 * 249583075) ^ -1564346557;
					continue;
				case 10u:
					num = ((int)num2 * -1186012849) ^ -255362152;
					continue;
				case 9u:
					Form1.smethod_89((Control)(object)this, (EventHandler)Form1_LocationChanged);
					num = ((int)num2 * -417107883) ^ 0x20018ABB;
					continue;
				case 8u:
					richTextBox1 = Form1.smethod_54();
					num = ((int)num2 * -1960255118) ^ -1827588586;
					continue;
				case 7u:
					Form1.smethod_88((Form)(object)this, (EventHandler)Form1_Shown);
					num = (int)(num2 * 921609696) ^ -1668199815;
					continue;
				case 6u:
					Form1.smethod_32((Control)(object)button1, "Меню");
					num = ((int)num2 * -66070691) ^ -1989849148;
					continue;
				case 5u:
					Form1.smethod_4((Control)(object)pictureBox1, new Point(120, 22));
					num = ((int)num2 * -1558356517) ^ -1904020298;
					continue;
				case 4u:
					Form1.smethod_92((Control)(object)this);
					num = ((int)num2 * -1758027665) ^ 0x2C9FEC45;
					continue;
				case 3u:
					Form1.smethod_64((Control)(object)label5, 12);
					Form1.smethod_74((Control)(object)label6, bool_0: true);
					num = (int)(num2 * 1409244275) ^ -549754711;
					continue;
				case 2u:
					Form1.smethod_61((Control)(object)label6, "label6");
					num = ((int)num2 * -1358400979) ^ 0x4F0DC475;
					continue;
				case 1u:
					num = ((int)num2 * -1262857397) ^ -516084395;
					continue;
				case 0u:
					Form1.smethod_4((Control)(object)label1, new Point(486, 0));
					num = ((int)num2 * -1794213872) ^ 0xEAF29F5;
					continue;
				default:
					return;
				case 96u:
					break;
				case 39u:
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
			int num = 648166481;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x4887B5E0u) % 4u)
				{
				case 1u:
					q = ContextAdd(Level);
					num = (int)(num2 * 1465163013) ^ -1234285479;
					continue;
				case 0u:
					PerformTable(q);
					num = ((int)num2 * -590473938) ^ 0x75665EA7;
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
