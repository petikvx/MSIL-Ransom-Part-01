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
				int num = -613401984;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x8C3591EDu) % 6u)
					{
					case 3u:
						Big = copy.Big;
						Square = copy.Square;
						num = (int)((num2 * 1297028932) ^ 0x2903119B);
						continue;
					case 2u:
						Dark = copy.Dark;
						num = ((int)num2 * -1184816928) ^ 0x4B152496;
						continue;
					case 1u:
						num = (int)((num2 * 1515901255) ^ 0x23F35B20);
						continue;
					case 0u:
						Point = copy.Point;
						num = ((int)num2 * -990516048) ^ 0x7BEE42E0;
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
	}

	public void Button1_Click(object sender, EventArgs e)
	{
		bool flag = default(bool);
		while (true)
		{
			int num = -1356939629;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xCB1BEDCFu) % 9u)
				{
				case 8u:
					Form1.smethod_14(menu);
					num = (int)(num2 * 1090783634) ^ -799006727;
					continue;
				case 7u:
					num = (int)((num2 * 272821773) ^ 0x258E7116);
					continue;
				case 5u:
				{
					Form control_ = menu;
					Form1.smethod_17((Control)(object)control_, Form1.smethod_16((Control)(object)control_) + 5);
					num = -514123013;
					continue;
				}
				case 4u:
					num = (int)(num2 * 364353898) ^ -448961939;
					continue;
				case 3u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = 1096236568;
						num4 = 1096236568;
					}
					else
					{
						num3 = 178563919;
						num4 = 178563919;
					}
					num = num3 ^ (int)(num2 * 272493218);
					continue;
				}
				case 1u:
					Form1.smethod_15(timer1);
					num = ((int)num2 * -1926208718) ^ 0x1D9CB2C8;
					continue;
				case 0u:
					flag = Form1.smethod_16((Control)(object)menu) < 296;
					num = -187719344;
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

	private void Form1_Load(object sender, EventArgs e)
	{
		board = new Figurine[4, 4];
		int num3 = default(int);
		int num4 = default(int);
		while (true)
		{
			int num = -1313291312;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x874471FDu) % 20u)
				{
				case 19u:
				{
					int num6;
					if (num3 < 4)
					{
						num = -1822465878;
						num6 = -1822465878;
					}
					else
					{
						num = -1743363272;
						num6 = -1743363272;
					}
					continue;
				}
				case 18u:
					storage[num3, num4] = new Figurine(num3 < 2, num4 % 2 == 0, num4 < 2, num3 % 2 == 1);
					Form1.smethod_5((Control)(object)borderBox[num3, num4], Color.White);
					num = -1480391495;
					continue;
				case 17u:
					num = ((int)num2 * -531020852) ^ -1238264731;
					continue;
				case 16u:
					num4++;
					num = ((int)num2 * -630653562) ^ -2062894829;
					continue;
				case 15u:
					num3++;
					num = ((int)num2 * -1843284556) ^ -1043454082;
					continue;
				case 14u:
					num = ((int)num2 * -1695518292) ^ -788196701;
					continue;
				case 13u:
					Paint_Board();
					num = (int)(num2 * 2143930220) ^ -329228062;
					continue;
				case 12u:
					num = (int)(num2 * 35610250) ^ -2056009143;
					continue;
				case 11u:
					num4 = 0;
					num = -1839200589;
					continue;
				case 10u:
				{
					int num5;
					if (num4 >= 4)
					{
						num = -2016859314;
						num5 = -2016859314;
					}
					else
					{
						num = -330448609;
						num5 = -330448609;
					}
					continue;
				}
				case 9u:
					storage = new Figurine[4, 4];
					num3 = 0;
					num = (int)(num2 * 141944559) ^ -121527563;
					continue;
				case 8u:
					Form1.smethod_7((Control)(object)pictureBox[num3, num4], bool_0: false);
					num = ((int)num2 * -849181847) ^ 0x7BC9DF35;
					continue;
				case 7u:
					num = (int)((num2 * 1126543922) ^ 0x4C69B184);
					continue;
				case 6u:
					num = ((int)num2 * -1470531721) ^ 0x1FBEC78A;
					continue;
				case 4u:
					num = ((int)num2 * -413988276) ^ -1085658583;
					continue;
				case 3u:
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: false);
					num = (int)((num2 * 1121872481) ^ 0x2B573830);
					continue;
				case 1u:
					Paint_Storage();
					num = (int)((num2 * 770735441) ^ 0x7CAF1BD);
					continue;
				case 0u:
					Form1.smethod_7((Control)(object)button2, bool_0: false);
					num = ((int)num2 * -722992393) ^ 0x1A7716C3;
					continue;
				default:
					return;
				case 5u:
					break;
				case 2u:
					return;
				}
				break;
			}
		}
	}

	private void Paint_Board()
	{
		bool big = default(bool);
		int num3 = default(int);
		int num4 = default(int);
		bool square = default(bool);
		bool point = default(bool);
		float num8 = default(float);
		float num16 = default(float);
		float num9 = default(float);
		float num13 = default(float);
		bool flag = default(bool);
		float num5 = default(float);
		Graphics graphics_ = default(Graphics);
		bool flag2 = default(bool);
		Brush brush_ = default(Brush);
		while (true)
		{
			int num = -811514161;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xEED7313Au) % 41u)
				{
				case 40u:
					big = board[num3, num4].Big;
					num = -710434405;
					continue;
				case 39u:
				{
					int num19;
					int num20;
					if (!square)
					{
						num19 = -1802589404;
						num20 = -1802589404;
					}
					else
					{
						num19 = -1896633706;
						num20 = -1896633706;
					}
					num = num19 ^ (int)(num2 * 1651420717);
					continue;
				}
				case 38u:
					num = ((int)num2 * -387351510) ^ 0x3D92AE51;
					continue;
				case 37u:
					point = board[num3, num4].Point;
					num = ((int)num2 * -1721904788) ^ 0x4656FDB3;
					continue;
				case 36u:
					num8 = (float)size * (num16 / 2f);
					num9 = num13 * 0.9f / (float)Form1.smethod_27(2.0);
					num = ((int)num2 * -1602104763) ^ -2117766069;
					continue;
				case 35u:
					num = ((int)num2 * -310231470) ^ -567693724;
					continue;
				case 34u:
				{
					int num14;
					int num15;
					if (!flag)
					{
						num14 = -1644369799;
						num15 = -1644369799;
					}
					else
					{
						num14 = -1790238763;
						num15 = -1790238763;
					}
					num = num14 ^ (int)(num2 * 1687834191);
					continue;
				}
				case 33u:
					num13 = (float)size * num5;
					num = ((int)num2 * -837137697) ^ 0x66BA670E;
					continue;
				case 31u:
					num = (int)(num2 * 1435288172) ^ -801671280;
					continue;
				case 30u:
					num = ((int)num2 * -184138332) ^ 0x2BB5BF17;
					continue;
				case 29u:
					flag = num4 < 4;
					num = -1953777155;
					continue;
				case 28u:
					Form1.smethod_20(pictureBox1, (Image)(object)Form1.smethod_19(Form1.smethod_18((Control)(object)pictureBox1), Form1.smethod_16((Control)(object)pictureBox1)));
					num = (int)((num2 * 981576056) ^ 0x31E7B3C9);
					continue;
				case 27u:
					num = (int)(num2 * 959672418) ^ -226626883;
					continue;
				case 26u:
					Form1.smethod_24(graphics_, (Brush)(object)Form1.smethod_29(Color.FromArgb(180, Color.Peru)), num8 + (float)(num4 * size), num8 + (float)(num3 * size), num9, num9);
					num = ((int)num2 * -659254549) ^ 0x5958513B;
					continue;
				case 25u:
				{
					int num21;
					int num22;
					if (!board[num3, num4].Dark)
					{
						num21 = -187137312;
						num22 = -187137312;
					}
					else
					{
						num21 = -1158328916;
						num22 = -1158328916;
					}
					num = num21 ^ (int)(num2 * 1791976749);
					continue;
				}
				case 24u:
					flag2 = num3 < 4;
					num = -1160031729;
					continue;
				case 23u:
					num = ((int)num2 * -90202096) ^ -1637600003;
					continue;
				case 22u:
					square = board[num3, num4].Square;
					num = (int)(num2 * 1812399734) ^ -1882332170;
					continue;
				case 21u:
					num9 = num13 * 0.4f / (float)Form1.smethod_27(2.0);
					num = ((int)num2 * -2019930378) ^ 0x6876715A;
					continue;
				case 20u:
				{
					int num17;
					int num18;
					if (flag2)
					{
						num17 = 512532046;
						num18 = 512532046;
					}
					else
					{
						num17 = 1599367162;
						num18 = 1599367162;
					}
					num = num17 ^ ((int)num2 * -1807856017);
					continue;
				}
				case 19u:
					num = -520761071;
					continue;
				case 18u:
					num3++;
					num = (int)(num2 * 1263629319) ^ -1494083787;
					continue;
				case 17u:
					Form1.smethod_30((Control)(object)pictureBox1);
					num = ((int)num2 * -198518597) ^ 0x14E017F4;
					continue;
				case 16u:
					num16 = 1f - num5 * 0.4f / (float)Form1.smethod_27(2.0);
					num = -1251366641;
					continue;
				case 15u:
					num4++;
					num = ((int)num2 * -751335265) ^ 0x364A576A;
					continue;
				case 14u:
					Form1.smethod_28(graphics_, brush_, num8 + (float)(num4 * size), num8 + (float)(num3 * size), num9, num9);
					num = (int)((num2 * 513345220) ^ 0x11835825);
					continue;
				case 13u:
					num5 = 1f;
					num = ((int)num2 * -143073366) ^ 0x334AF497;
					continue;
				case 12u:
					num8 = (float)size * (num16 / 2f);
					num = (int)((num2 * 1971920986) ^ 0x34AA7604);
					continue;
				case 11u:
					num16 = 1f - num5 * 0.9f / (float)Form1.smethod_27(2.0);
					num = -388938452;
					continue;
				case 10u:
				{
					int num11;
					int num12;
					if (big)
					{
						num11 = -1519888749;
						num12 = -1519888749;
					}
					else
					{
						num11 = -1806841971;
						num12 = -1806841971;
					}
					num = num11 ^ ((int)num2 * -1664213145);
					continue;
				}
				case 9u:
					brush_ = Form1.smethod_25();
					num = ((int)num2 * -995596015) ^ 0x767D9567;
					continue;
				case 7u:
					Form1.smethod_24(graphics_, brush_, num8 + (float)(num4 * size), num8 + (float)(num3 * size), num9, num9);
					num = -81678960;
					continue;
				case 6u:
				{
					Form1.smethod_24(graphics_, Form1.smethod_23(), ((float)num4 + 0.05f) * (float)size, ((float)num3 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					int num10;
					if (board[num3, num4] == null)
					{
						num = -520761071;
						num10 = -520761071;
					}
					else
					{
						num = -1827060048;
						num10 = -1827060048;
					}
					continue;
				}
				case 5u:
					brush_ = Form1.smethod_26();
					num = -1699934605;
					continue;
				case 4u:
				{
					int num6;
					int num7;
					if (point)
					{
						num6 = 2032152760;
						num7 = 2032152760;
					}
					else
					{
						num6 = 848031955;
						num7 = 848031955;
					}
					num = num6 ^ ((int)num2 * -750567336);
					continue;
				}
				case 3u:
					num = -1798868589;
					continue;
				case 2u:
					num5 = 0.7f;
					num = -1775104965;
					continue;
				case 1u:
					num4 = 0;
					num = -486204404;
					continue;
				case 0u:
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox1));
					num3 = 0;
					num = ((int)num2 * -382749330) ^ -1934387555;
					continue;
				default:
					return;
				case 32u:
					break;
				case 8u:
					return;
				}
				break;
			}
		}
	}

	private void Paint_Storage()
	{
		int num = 0;
		int num5 = default(int);
		bool dark = default(bool);
		bool flag = default(bool);
		Brush brush_ = default(Brush);
		Graphics graphics_ = default(Graphics);
		float num9 = default(float);
		float num10 = default(float);
		bool flag2 = default(bool);
		float num6 = default(float);
		float num8 = default(float);
		while (true)
		{
			int num2;
			int num3;
			if (num < 4)
			{
				num2 = -533667864;
				num3 = -533667864;
			}
			else
			{
				num2 = -1718054166;
				num3 = -1718054166;
			}
			while (true)
			{
				uint num4;
				switch ((num4 = (uint)num2 ^ 0xFB78E523u) % 29u)
				{
				case 28u:
				{
					int num17;
					if (storage[num, num5].Big)
					{
						num2 = -745514469;
						num17 = -745514469;
					}
					else
					{
						num2 = -528402658;
						num17 = -528402658;
					}
					continue;
				}
				case 27u:
				{
					int num18;
					int num19;
					if (!dark)
					{
						num18 = 38753835;
						num19 = 38753835;
					}
					else
					{
						num18 = 1238173244;
						num19 = 1238173244;
					}
					num2 = num18 ^ (int)(num4 * 1560667919);
					continue;
				}
				case 26u:
					num++;
					num2 = (int)((num4 * 1483032534) ^ 0x79181874);
					continue;
				case 25u:
				{
					int num14;
					if (num5 < 4)
					{
						num2 = -935769523;
						num14 = -935769523;
					}
					else
					{
						num2 = -1567950963;
						num14 = -1567950963;
					}
					continue;
				}
				case 24u:
					flag = storage[num, num5] != null;
					num2 = -438523737;
					continue;
				case 23u:
					brush_ = Form1.smethod_26();
					num2 = -1887900566;
					continue;
				case 22u:
					Form1.smethod_28(graphics_, brush_, num9, num9, num10, num10);
					num2 = (int)(num4 * 1078867469) ^ -1834306406;
					continue;
				case 21u:
					brush_ = Form1.smethod_25();
					num2 = (int)((num4 * 271326824) ^ 0x6BED1611);
					continue;
				case 20u:
					num5 = 0;
					num2 = -1607732957;
					continue;
				case 19u:
					num2 = (int)((num4 * 1960760161) ^ 0x5E04C5D5);
					continue;
				case 18u:
				{
					int num15;
					int num16;
					if (!flag2)
					{
						num15 = 1553038969;
						num16 = 1553038969;
					}
					else
					{
						num15 = 1692420689;
						num16 = 1692420689;
					}
					num2 = num15 ^ (int)(num4 * 1587730246);
					continue;
				}
				case 17u:
					num6 = 1f;
					num2 = ((int)num4 * -921076490) ^ 0x745D3011;
					continue;
				case 16u:
					flag2 = num5 < 2;
					num2 = (int)((num4 * 1643014408) ^ 0x200D4A53);
					continue;
				case 15u:
					num2 = ((int)num4 * -255414381) ^ -360450918;
					continue;
				case 14u:
					num2 = ((int)num4 * -2007438035) ^ -1720535008;
					continue;
				case 12u:
					num2 = -533667864;
					continue;
				case 11u:
					Form1.smethod_24(graphics_, (Brush)(object)Form1.smethod_29(Color.FromArgb(180, Color.Peru)), num9, num9, num10, num10);
					num2 = ((int)num4 * -921415869) ^ 0x16121E4A;
					continue;
				case 10u:
				{
					int num12;
					int num13;
					if (flag)
					{
						num12 = 1026932749;
						num13 = 1026932749;
					}
					else
					{
						num12 = 1453974408;
						num13 = 1453974408;
					}
					num2 = num12 ^ (int)(num4 * 612954462);
					continue;
				}
				case 9u:
					Form1.smethod_20(pictureBox[num, num5], (Image)(object)Form1.smethod_19(Form1.smethod_18((Control)(object)pictureBox[num, num5]), Form1.smethod_16((Control)(object)pictureBox[num, num5])));
					num2 = ((int)num4 * -914622078) ^ -84395691;
					continue;
				case 8u:
					Form1.smethod_24(graphics_, brush_, num9, num9, num10, num10);
					num2 = -2072769002;
					continue;
				case 7u:
				{
					float num7 = 1f - num6 * 0.4f / (float)Form1.smethod_27(2.0);
					num9 = (float)size * (num7 / 2f) - 4f;
					num10 = num8 * 0.4f / (float)Form1.smethod_27(2.0);
					int num11;
					if (storage[num, num5].Point)
					{
						num2 = -835594864;
						num11 = -835594864;
					}
					else
					{
						num2 = -1143258742;
						num11 = -1143258742;
					}
					continue;
				}
				case 6u:
					Form1.smethod_30((Control)(object)pictureBox[num, num5]);
					num2 = -37463568;
					continue;
				case 5u:
					num6 = 0.7f;
					num2 = -346015680;
					continue;
				case 4u:
					num2 = (int)((num4 * 236114647) ^ 0x5167BF8E);
					continue;
				case 2u:
					num5++;
					num2 = -1607732957;
					continue;
				case 1u:
				{
					float num7 = 1f - num6 * 0.9f / (float)Form1.smethod_27(2.0);
					num8 = (float)size * num6;
					num9 = (float)size * (num7 / 2f) - 4f;
					num10 = num8 * 0.9f / (float)Form1.smethod_27(2.0);
					num2 = -1064213072;
					continue;
				}
				case 0u:
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox[num, num5]));
					dark = storage[num, num5].Dark;
					num2 = (int)((num4 * 1618344006) ^ 0x755671FE);
					continue;
				default:
					return;
				case 13u:
					break;
				case 3u:
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
		bool flag = default(bool);
		int num6 = default(int);
		int num7 = default(int);
		int num3 = default(int);
		while (true)
		{
			int num = -1697097408;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xBE243794u) % 25u)
				{
				case 24u:
					step = 0;
					num = ((int)num2 * -1445804570) ^ 0x2CE4B38D;
					continue;
				case 23u:
					Form1.smethod_32((Control)(object)label2, Form1.smethod_34("Ход: ", step.ToString()));
					num = -1105991388;
					continue;
				case 22u:
					num8 = 0;
					num = -1552382458;
					continue;
				case 21u:
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: true);
					num = (int)((num2 * 1607918989) ^ 0x3846C6E6);
					continue;
				case 20u:
					flag = turn;
					num = ((int)num2 * -749348743) ^ -2047951213;
					continue;
				case 19u:
					num6 = Form1.smethod_33(rnd, 4);
					num7 = Form1.smethod_33(rnd, 4);
					num = -2055483003;
					continue;
				case 18u:
					step = 1;
					num = ((int)num2 * -907807289) ^ -1659772347;
					continue;
				case 17u:
				{
					int num10;
					if (num3 >= 4)
					{
						num = -1500777668;
						num10 = -1500777668;
					}
					else
					{
						num = -61607332;
						num10 = -61607332;
					}
					continue;
				}
				case 15u:
					num = ((int)num2 * -2082407269) ^ -160623394;
					continue;
				case 14u:
					num = (int)(num2 * 1792298816) ^ -1334526201;
					continue;
				case 13u:
					num = ((int)num2 * -2027114541) ^ -1262902878;
					continue;
				case 12u:
				{
					int num9;
					if (num8 < 4)
					{
						num = -845470479;
						num9 = -845470479;
					}
					else
					{
						num = -1972300922;
						num9 = -1972300922;
					}
					continue;
				}
				case 11u:
					Form1.smethod_5((Control)(object)borderBox[num6, num7], Color.Blue);
					num = ((int)num2 * -1756890860) ^ 0x63DC0B8A;
					continue;
				case 10u:
					num3 = 0;
					num = ((int)num2 * -1413067495) ^ -521751865;
					continue;
				case 9u:
					num = (int)((num2 * 1766344589) ^ 0x2CA7A218);
					continue;
				case 8u:
					num = (int)(num2 * 1618122766) ^ -904392738;
					continue;
				case 7u:
					Form1.smethod_32((Control)(object)richTextBox1, "Противник выбрал фигуру. Выберете поле на доске для установки этой фигуры.");
					num = ((int)num2 * -916123370) ^ 0x495B3A22;
					continue;
				case 6u:
					Form1.smethod_7((Control)(object)pictureBox[num3, num8], bool_0: true);
					num8++;
					num = -1728386702;
					continue;
				case 5u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = 1638279003;
						num5 = 1638279003;
					}
					else
					{
						num4 = 1683821534;
						num5 = 1683821534;
					}
					num = num4 ^ ((int)num2 * -486576639);
					continue;
				}
				case 4u:
					time = new DateTime(0L, DateTimeKind.Unspecified);
					Form1.smethod_35(timer1, bool_0: true);
					num = (int)(num2 * 1261085364) ^ -572830329;
					continue;
				case 3u:
					Form1.smethod_32((Control)(object)richTextBox1, "Ваш ход. Выберете фигуру, которой будет играть противник.");
					num = ((int)num2 * -135480588) ^ 0x6E961793;
					continue;
				case 2u:
					num = ((int)num2 * -447125013) ^ -1186630478;
					continue;
				case 1u:
					num3++;
					num = ((int)num2 * -1953319812) ^ 0x2F923ECB;
					continue;
				case 0u:
					break;
				default:
					Form1.smethod_36(timer1);
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
			int num = 1053342311;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x47254327u) % 3u)
				{
				case 2u:
					goto IL_001c;
				default:
					return;
				case 0u:
					break;
				case 1u:
					return;
				}
				break;
				IL_001c:
				Form1.smethod_32((Control)(object)label1, Form1.smethod_34("Время: ", time.ToString("HH:mm:ss")));
				num = (int)(num2 * 1625285432) ^ -356352171;
			}
		}
	}

	private void PictureBoxIJ_MouseDown(object sender, MouseEventArgs e)
	{
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_0186: Expected O, but got Unknown
		int num3 = default(int);
		Point point = default(Point);
		int num8 = default(int);
		int num5 = default(int);
		int num4 = default(int);
		while (true)
		{
			int num = -2058677680;
			while (true)
			{
				uint num2;
				int num10;
				switch ((num2 = (uint)num ^ 0xACF2DE87u) % 27u)
				{
				case 26u:
					num3 = point.X / size;
					num = (int)((num2 * 2031448527) ^ 0x2421B566);
					continue;
				case 25u:
					num = (int)(num2 * 1101373051) ^ -1478510212;
					continue;
				case 24u:
					num8 = 0;
					num = (int)(num2 * 1497847721) ^ -1566249893;
					continue;
				case 23u:
					num = ((int)num2 * -1732121991) ^ -1196784365;
					continue;
				case 22u:
					num8++;
					num = ((int)num2 * -1162492357) ^ 0x6DD3467B;
					continue;
				case 21u:
				{
					int num9;
					if (num8 < 4)
					{
						num = -151596841;
						num9 = -151596841;
					}
					else
					{
						num = -869477169;
						num9 = -869477169;
					}
					continue;
				}
				case 20u:
					Form1.smethod_7((Control)(object)button2, bool_0: true);
					num = (int)((num2 * 1844789693) ^ 0x10175094);
					continue;
				case 19u:
					num = (int)(num2 * 710113748) ^ -1570387992;
					continue;
				case 18u:
					num = ((int)num2 * -1566871860) ^ 0x6229A70B;
					continue;
				case 16u:
					Form1.smethod_5((Control)(object)borderBox[num5, num3], Color.Red);
					num = ((int)num2 * -2049885042) ^ 0x334D2C61;
					continue;
				case 15u:
					num4++;
					num = ((int)num2 * -1589590242) ^ 0x1CB1DDD3;
					continue;
				case 14u:
					num = ((int)num2 * -1368452537) ^ -1874007511;
					continue;
				case 13u:
				{
					int num11;
					if (num4 < 4)
					{
						num = -458771717;
						num11 = -458771717;
					}
					else
					{
						num = -140036193;
						num11 = -140036193;
					}
					continue;
				}
				case 12u:
					if (Form1.smethod_40((Bitmap)Form1.smethod_21(pictureBox[num5, num3]), Form1.smethod_38(e), Form1.smethod_39(e)) != Color.FromArgb(0, 0, 0, 0))
					{
						num = -2018422815;
						num10 = -2018422815;
						continue;
					}
					goto IL_01a2;
				case 11u:
					Form1.smethod_32((Control)(object)richTextBox1, "Именно эта фигура? Если да - нажмите \"Подтвердить\".");
					num = (int)((num2 * 1498977520) ^ 0x3743C0C6);
					continue;
				case 10u:
					num = ((int)num2 * -842899696) ^ 0x648C41E;
					continue;
				case 9u:
					point = Form1.smethod_37((Control)((sender is PictureBox) ? sender : null));
					num = ((int)num2 * -165260073) ^ -505733968;
					continue;
				case 8u:
					Form1.smethod_5((Control)(object)borderBox[num8, num4], Color.White);
					num = -2046732818;
					continue;
				case 7u:
					point = Form1.smethod_37((Control)((sender is PictureBox) ? sender : null));
					num = (int)(num2 * 1762927623) ^ -1936648642;
					continue;
				case 6u:
					num = ((int)num2 * -410872559) ^ -289213689;
					continue;
				case 5u:
					if (storage[num5, num3] != null)
					{
						num = -1914060882;
						continue;
					}
					goto IL_01a2;
				case 4u:
				{
					int num6;
					int num7;
					if (num3 <= 1)
					{
						num6 = 1529699644;
						num7 = 1529699644;
					}
					else
					{
						num6 = 1667132347;
						num7 = 1667132347;
					}
					num = num6 ^ ((int)num2 * -1827171768);
					continue;
				}
				case 3u:
					num5 = point.Y / size;
					num = (int)((num2 * 2079697970) ^ 0x64826F53);
					continue;
				case 2u:
					num4 = 0;
					num = -1514095596;
					continue;
				case 0u:
					num3 -= 4;
					num = ((int)num2 * -1868978595) ^ 0x1E039FD0;
					continue;
				default:
					return;
				case 17u:
					break;
				case 1u:
					return;
					IL_01a2:
					num = -228046734;
					num10 = -228046734;
					continue;
				}
				break;
			}
		}
	}

	private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
	{
		//IL_018b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Expected O, but got Unknown
		int num = Form1.smethod_38(e) / size;
		bool flag2 = default(bool);
		int num7 = default(int);
		Graphics graphics_ = default(Graphics);
		int num6 = default(int);
		int num4 = default(int);
		bool flag3 = default(bool);
		bool flag = default(bool);
		while (true)
		{
			int num2 = -1648561190;
			while (true)
			{
				uint num3;
				int num5;
				switch ((num3 = (uint)num2 ^ 0xA7466DD3u) % 29u)
				{
				case 28u:
					num2 = ((int)num3 * -1483343785) ^ -1510061713;
					continue;
				case 27u:
					num2 = (int)(num3 * 2104796471) ^ -1977108910;
					continue;
				case 26u:
					num2 = ((int)num3 * -988037783) ^ -1983844395;
					continue;
				case 25u:
					flag2 = num7 < 4;
					num2 = -1615663439;
					continue;
				case 24u:
					Form1.smethod_44(graphics_, Form1.smethod_21(pictureBox[num6, num7]), num * size + 4, num4 * size + 4, new Rectangle(0, 0, size, size), (GraphicsUnit)2);
					num2 = ((int)num3 * -806932803) ^ -2111224152;
					continue;
				case 23u:
					Form1.smethod_45(graphics_);
					num2 = ((int)num3 * -1258781361) ^ -633627907;
					continue;
				case 22u:
				{
					int num11;
					int num12;
					if (flag2)
					{
						num11 = 1180429092;
						num12 = 1180429092;
					}
					else
					{
						num11 = 2077569632;
						num12 = 2077569632;
					}
					num2 = num11 ^ ((int)num3 * -1354359924);
					continue;
				}
				case 21u:
					flag3 = num6 < 4;
					num2 = -1776722866;
					continue;
				case 20u:
					num2 = (int)((num3 * 500845765) ^ 0x176A6D5D);
					continue;
				case 19u:
				{
					int num13;
					int num14;
					if (!flag3)
					{
						num13 = -199015483;
						num14 = -199015483;
					}
					else
					{
						num13 = -988886510;
						num14 = -988886510;
					}
					num2 = num13 ^ ((int)num3 * -1122841201);
					continue;
				}
				case 17u:
					num4 = Form1.smethod_39(e) / size;
					num2 = (int)((num3 * 1217922020) ^ 0x1DBE3EA6);
					continue;
				case 16u:
					Form1.smethod_30((Control)(object)pictureBox1);
					num2 = (int)((num3 * 861706815) ^ 0x5B10E011);
					continue;
				case 15u:
					if (Form1.smethod_40((Bitmap)Form1.smethod_21(pictureBox1), Form1.smethod_38(e), Form1.smethod_39(e)) != Color.FromArgb(0, 0, 0, 0))
					{
						num2 = ((int)num3 * -1751373099) ^ 0x28EC771A;
						continue;
					}
					num5 = 0;
					goto IL_01c5;
				case 14u:
				{
					int num9;
					int num10;
					if (flag)
					{
						num9 = -466333889;
						num10 = -466333889;
					}
					else
					{
						num9 = -1677597196;
						num10 = -1677597196;
					}
					num2 = num9 ^ (int)(num3 * 1444222901);
					continue;
				}
				case 13u:
					num6 = 0;
					num2 = (int)((num3 * 2897926) ^ 0x50248FD8);
					continue;
				case 12u:
					num7++;
					num2 = -320949565;
					continue;
				case 11u:
					Form1.smethod_43(graphics_, Form1.smethod_42(Color.Red, 3f), ((float)num + 0.05f) * (float)size, ((float)num4 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					num2 = ((int)num3 * -1602224437) ^ -1650807797;
					continue;
				case 10u:
					num2 = ((int)num3 * -1752551413) ^ -1629587663;
					continue;
				case 9u:
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox1));
					num2 = (int)((num3 * 360826878) ^ 0x7AB628A8);
					continue;
				case 8u:
				{
					int num8;
					if (!(Form1.smethod_41((Control)(object)borderBox[num6, num7]) == Color.Blue))
					{
						num2 = -1386605108;
						num8 = -1386605108;
					}
					else
					{
						num2 = -697300009;
						num8 = -697300009;
					}
					continue;
				}
				case 7u:
					num7 = 0;
					num2 = -48365335;
					continue;
				case 6u:
					Form1.smethod_32((Control)(object)richTextBox1, "Уверены? Для выполнения данного хода нажмите \"Подтвердить\".");
					num2 = (int)(num3 * 2026266172) ^ -734508212;
					continue;
				case 5u:
					num6++;
					num2 = ((int)num3 * -2086427949) ^ -1694058473;
					continue;
				case 4u:
					num2 = ((int)num3 * -415013501) ^ -430214035;
					continue;
				case 2u:
					Form1.smethod_7((Control)(object)button2, bool_0: true);
					num2 = (int)(num3 * 1494788498) ^ -1980323588;
					continue;
				case 1u:
					Paint_Board();
					num2 = ((int)num3 * -176119432) ^ -865735720;
					continue;
				case 0u:
					num5 = ((board[num4, num] == null) ? 1 : 0);
					goto IL_01c5;
				default:
					return;
				case 18u:
					break;
				case 3u:
					return;
					IL_01c5:
					flag = (byte)num5 != 0;
					num2 = -671203991;
					continue;
				}
				break;
			}
		}
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		//IL_0c8c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cba: Expected O, but got Unknown
		Form1.smethod_7((Control)(object)button2, bool_0: false);
		int num34 = default(int);
		int num7 = default(int);
		int num35 = default(int);
		bool flag4 = default(bool);
		int num14 = default(int);
		bool flag8 = default(bool);
		int num47 = default(int);
		int num9 = default(int);
		bool flag6 = default(bool);
		int num11 = default(int);
		bool flag5 = default(bool);
		int num8 = default(int);
		int num26 = default(int);
		int num23 = default(int);
		int num31 = default(int);
		int num24 = default(int);
		bool flag10 = default(bool);
		bool flag3 = default(bool);
		int num17 = default(int);
		int num3 = default(int);
		Graphics graphics_ = default(Graphics);
		int num4 = default(int);
		int num10 = default(int);
		bool flag13 = default(bool);
		int num43 = default(int);
		int num13 = default(int);
		bool flag11 = default(bool);
		int num21 = default(int);
		int num18 = default(int);
		bool flag2 = default(bool);
		Figurine[,] array3 = default(Figurine[,]);
		Figurine[,] array = default(Figurine[,]);
		Figurine[,] array2 = default(Figurine[,]);
		bool flag12 = default(bool);
		int num12 = default(int);
		bool flag15 = default(bool);
		bool flag = default(bool);
		bool flag14 = default(bool);
		bool flag7 = default(bool);
		bool flag9 = default(bool);
		while (true)
		{
			int num = -181332302;
			while (true)
			{
				uint num2;
				int num57;
				int num25;
				int num42;
				int num22;
				switch ((num2 = (uint)num ^ 0xA762978Bu) % 181u)
				{
				case 180u:
					num34 = num7;
					num = (int)((num2 * 465858107) ^ 0x3C707A8F);
					continue;
				case 179u:
					num34 = 0;
					num35 = 0;
					num = ((int)num2 * -163304818) ^ 0x629AB80C;
					continue;
				case 178u:
					flag4 = num14 < 4;
					num = -746505769;
					continue;
				case 177u:
					num = ((int)num2 * -577473640) ^ 0x7D7D00C9;
					continue;
				case 176u:
					if (!Standoff(board))
					{
						num = -812150054;
						num57 = -812150054;
						continue;
					}
					goto IL_0073;
				case 175u:
					flag8 = true;
					num = ((int)num2 * -1507922073) ^ -1938084946;
					continue;
				case 174u:
					Form1.smethod_5((Control)(object)borderBox[num47, num9], Color.LimeGreen);
					num = (int)((num2 * 1338096702) ^ 0x7A98ED07);
					continue;
				case 173u:
					num = ((int)num2 * -2103429884) ^ -370780035;
					continue;
				case 172u:
					num = (int)((num2 * 1998487714) ^ 0x723B7843);
					continue;
				case 171u:
					flag6 = num11 < 4;
					num = -1333002724;
					continue;
				case 170u:
					flag5 = num8 < 4;
					num = -1334901005;
					continue;
				case 169u:
					board[num26, num23] = new Figurine(storage[num34, num35]);
					storage[num34, num35] = null;
					num = (int)(num2 * 1886184890) ^ -161266170;
					continue;
				case 168u:
					num14++;
					num = ((int)num2 * -275858156) ^ -641155075;
					continue;
				case 167u:
					num = (int)((num2 * 2021666035) ^ 0x76B4DE88);
					continue;
				case 166u:
					Form1.smethod_30((Control)(object)borderBox[num47, num9]);
					num = (int)(num2 * 1670548556) ^ -769005070;
					continue;
				case 165u:
					if (storage[num31, num24] != null)
					{
						num = ((int)num2 * -151284071) ^ 0x2E48B826;
						continue;
					}
					num25 = 1;
					goto IL_01d2;
				case 164u:
				{
					int num60;
					int num61;
					if (!flag10)
					{
						num60 = -1617680861;
						num61 = -1617680861;
					}
					else
					{
						num60 = -1162303390;
						num61 = -1162303390;
					}
					num = num60 ^ (int)(num2 * 1335071198);
					continue;
				}
				case 163u:
					flag3 = num17 < 4;
					num = -2035006616;
					continue;
				case 162u:
					if (num31 == num3)
					{
						num = (int)(num2 * 1420711965) ^ -346465974;
						continue;
					}
					num25 = 0;
					goto IL_01d2;
				case 161u:
					num = (int)(num2 * 1982350657) ^ -2134654772;
					continue;
				case 160u:
					Form1.smethod_44(graphics_, Form1.smethod_21(pictureBox[num3, num4]), num10 * size + 4, num11 * size + 4, new Rectangle(0, 0, size, size), (GraphicsUnit)2);
					num = (int)((num2 * 917128249) ^ 0x1FEA5DE3);
					continue;
				case 159u:
					flag13 = Form1.smethod_46((Control)(object)pictureBox1);
					num = ((int)num2 * -406424303) ^ -732153541;
					continue;
				case 158u:
					Form1.smethod_5((Control)(object)borderBox[num3, num4], Color.White);
					num = (int)((num2 * 292583583) ^ 0x140D42DD);
					continue;
				case 157u:
				{
					int num50;
					if (num43 >= 4)
					{
						num = -1382031719;
						num50 = -1382031719;
					}
					else
					{
						num = -58036149;
						num50 = -58036149;
					}
					continue;
				}
				case 156u:
					num13 = Form1.smethod_33(rnd, 4);
					num = (int)((num2 * 970799242) ^ 0x2C97D4A8);
					continue;
				case 155u:
					flag11 = Form1.smethod_41((Control)(object)borderBox[num47, num9]) == Color.Red;
					num = (int)((num2 * 643033649) ^ 0x6AA1229A);
					continue;
				case 154u:
					Form1.smethod_32((Control)(object)label2, Form1.smethod_34("Ход: ", step.ToString()));
					num = (int)(num2 * 1584871523) ^ -1290014205;
					continue;
				case 153u:
					if (!flag8)
					{
						num = ((int)num2 * -2143789906) ^ 0x7CF28E1;
						continue;
					}
					num42 = 1;
					goto IL_03ac;
				case 152u:
					num21 = 0;
					num = -1853846568;
					continue;
				case 151u:
					storage[num3, num4] = null;
					num = (int)(num2 * 1858544829) ^ -1480735971;
					continue;
				case 150u:
					num = (int)(num2 * 2021352591) ^ -1194211535;
					continue;
				case 149u:
					num = (int)(num2 * 1883737383) ^ -1426324336;
					continue;
				case 148u:
					num4 = 0;
					num = ((int)num2 * -1537605577) ^ 0xF2B6B01;
					continue;
				case 147u:
					num = ((int)num2 * -862653162) ^ -883868162;
					continue;
				case 146u:
					num17 = 0;
					num = (int)((num2 * 1673501281) ^ 0x29E918F2);
					continue;
				case 145u:
					num = (int)((num2 * 1403081369) ^ 0x7806CAC8);
					continue;
				case 144u:
					num = (int)((num2 * 910493782) ^ 0x1EF32778);
					continue;
				case 143u:
				{
					int num29;
					int num30;
					if (flag6)
					{
						num29 = -1274729024;
						num30 = -1274729024;
					}
					else
					{
						num29 = -1137472424;
						num30 = -1137472424;
					}
					num = num29 ^ ((int)num2 * -411138871);
					continue;
				}
				case 142u:
					num = (int)(num2 * 740475616) ^ -1770905071;
					continue;
				case 141u:
					num = (int)(num2 * 1804245342) ^ -1270634035;
					continue;
				case 140u:
					Form1.smethod_15(timer1);
					num = ((int)num2 * -2088817539) ^ -1182473260;
					continue;
				case 139u:
					num = (int)((num2 * 1117101426) ^ 0x2A4A1F8C);
					continue;
				case 138u:
					num = ((int)num2 * -737020208) ^ -1599096231;
					continue;
				case 137u:
					num4 = num9;
					num = (int)((num2 * 805653026) ^ 0x6D4DA20F);
					continue;
				case 136u:
					num21++;
					num = (int)((num2 * 1646101498) ^ 0x42C46D3D);
					continue;
				case 135u:
					num = -1057783807;
					continue;
				case 134u:
					num17++;
					num = ((int)num2 * -1067221927) ^ 0x3C94560E;
					continue;
				case 133u:
					num18 = 0;
					num = ((int)num2 * -1002999102) ^ -271391350;
					continue;
				case 132u:
					flag2 = Form1.smethod_41((Control)(object)borderBox[num7, num8]) == Color.Blue;
					num = -462930085;
					continue;
				case 131u:
					Form1.smethod_30((Control)(object)borderBox[num3, num4]);
					num = ((int)num2 * -376152048) ^ -1319649966;
					continue;
				case 130u:
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: true);
					num = ((int)num2 * -601193303) ^ 0x62DB0A87;
					continue;
				case 129u:
					num3 = 0;
					num = ((int)num2 * -634992735) ^ 0x12C688A3;
					continue;
				case 128u:
					num = (int)((num2 * 618500698) ^ 0x34F03BC0);
					continue;
				case 127u:
					num7++;
					num = (int)((num2 * 1944321971) ^ 0x7E83630);
					continue;
				case 126u:
					num = ((int)num2 * -1213411116) ^ -1839382690;
					continue;
				case 125u:
					num3 = num47;
					num = (int)(num2 * 438948659) ^ -1675758291;
					continue;
				case 124u:
					Form1.smethod_32((Control)(object)richTextBox1, "Ничья!");
					num = ((int)num2 * -1382087735) ^ -1326387732;
					continue;
				case 123u:
					array3 = (Figurine[,])Form1.smethod_48((Array)array);
					array3[num14, num43] = new Figurine(storage[num31, num24]);
					num = ((int)num2 * -1730795643) ^ -1398727697;
					continue;
				case 122u:
				{
					int num64;
					if (num9 < 4)
					{
						num = -1008307228;
						num64 = -1008307228;
					}
					else
					{
						num = -500790239;
						num64 = -500790239;
					}
					continue;
				}
				case 121u:
					array2[num11, num10] = new Figurine(storage[num3, num4]);
					if (!Stop(array2))
					{
						num = (int)(num2 * 1376316896) ^ -564166815;
						continue;
					}
					goto IL_071c;
				case 120u:
					num47++;
					num = ((int)num2 * -1340904210) ^ -667373678;
					continue;
				case 119u:
					num = ((int)num2 * -1280949741) ^ -204404190;
					continue;
				case 118u:
					num = ((int)num2 * -25538440) ^ -1818460258;
					continue;
				case 117u:
					array2 = (Figurine[,])Form1.smethod_48((Array)board);
					num = (int)((num2 * 840686516) ^ 0xE4B1D63);
					continue;
				case 115u:
				{
					int num63;
					if (board[num11, num10] == null)
					{
						num = -1346092168;
						num63 = -1346092168;
					}
					else
					{
						num = -670058469;
						num63 = -670058469;
					}
					continue;
				}
				case 114u:
					num = (int)(num2 * 537313841) ^ -760927953;
					continue;
				case 113u:
				{
					int num62;
					if (array[num14, num43] == null)
					{
						num = -244512193;
						num62 = -244512193;
					}
					else
					{
						num = -769253642;
						num62 = -769253642;
					}
					continue;
				}
				case 112u:
				{
					int num58;
					int num59;
					if (!flag12)
					{
						num58 = -1847624194;
						num59 = -1847624194;
					}
					else
					{
						num58 = -1686560599;
						num59 = -1686560599;
					}
					num = num58 ^ (int)(num2 * 1314611987);
					continue;
				}
				case 111u:
					Form1.smethod_15(timer1);
					num = -584060427;
					continue;
				case 110u:
					Form1.smethod_43(graphics_, Form1.smethod_42(Color.LimeGreen, 3f), ((float)num13 + 0.05f) * (float)size, ((float)num12 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					num = (int)(num2 * 285997574) ^ -1321896908;
					continue;
				case 109u:
					num = ((int)num2 * -1220199958) ^ 0x15E50B9C;
					continue;
				case 108u:
					num42 = ((num18 < 9) ? 1 : 0);
					goto IL_03ac;
				case 107u:
				{
					int num55;
					int num56;
					if (!flag11)
					{
						num55 = -376428313;
						num56 = -376428313;
					}
					else
					{
						num55 = -2137400763;
						num56 = -2137400763;
					}
					num = num55 ^ ((int)num2 * -109785833);
					continue;
				}
				case 106u:
					num35 = num8;
					Form1.smethod_5((Control)(object)borderBox[num7, num8], Color.White);
					Form1.smethod_30((Control)(object)borderBox[num7, num8]);
					num = (int)((num2 * 175408924) ^ 0x94D195F);
					continue;
				case 105u:
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: false);
					num = ((int)num2 * -1804134992) ^ 0x265833CE;
					continue;
				case 104u:
					num = -1475491999;
					continue;
				case 103u:
					num = (int)(num2 * 2028185597) ^ -862987522;
					continue;
				case 102u:
					num = -215094721;
					continue;
				case 101u:
				{
					int num53;
					int num54;
					if (flag15)
					{
						num53 = 1487310167;
						num54 = 1487310167;
					}
					else
					{
						num53 = 1504475925;
						num54 = 1504475925;
					}
					num = num53 ^ (int)(num2 * 237398806);
					continue;
				}
				case 100u:
					num = -670058469;
					continue;
				case 99u:
					Form1.smethod_32((Control)(object)richTextBox1, "Ничья!");
					num = (int)(num2 * 18368152) ^ -462023750;
					continue;
				case 98u:
					num11 = 0;
					num = ((int)num2 * -263754275) ^ 0x4754927E;
					continue;
				case 97u:
					num26 = num7;
					num = (int)((num2 * 475050307) ^ 0x242BBCBF);
					continue;
				case 96u:
					Form1.smethod_32((Control)(object)richTextBox1, "Противник сделал ход (зелёный). Выберете поле на доске для выбронной противником фигуры (синий).");
					num = ((int)num2 * -1767500683) ^ 0x7534B343;
					continue;
				case 95u:
					num47 = 0;
					num = (int)(num2 * 1824107909) ^ -1912286963;
					continue;
				case 94u:
					Form1.smethod_30((Control)(object)borderBox[num3, num4]);
					num = (int)(num2 * 1078349253) ^ -577108334;
					continue;
				case 93u:
					num = -316893104;
					continue;
				case 92u:
					board[num11, num10] = new Figurine(storage[num3, num4]);
					num = ((int)num2 * -1398486071) ^ -586068897;
					continue;
				case 91u:
					flag = Stop(array3);
					num = (int)((num2 * 1872097593) ^ 0x6C14087);
					continue;
				case 90u:
					num = (int)(num2 * 185466215) ^ -495156460;
					continue;
				case 89u:
					num = (int)((num2 * 1793900042) ^ 0x4C8F880D);
					continue;
				case 88u:
					flag14 = Standoff(board);
					num = ((int)num2 * -1586233156) ^ -1372785600;
					continue;
				case 87u:
					Form1.smethod_47(1000);
					num = ((int)num2 * -1004912826) ^ -1073346766;
					continue;
				case 86u:
					num = ((int)num2 * -492114427) ^ 0x4FCF8556;
					continue;
				case 85u:
					num8 = 0;
					num = -974414299;
					continue;
				case 84u:
					Form1.smethod_44(graphics_, Form1.smethod_21(pictureBox[num3, num4]), num13 * size + 4, num12 * size + 4, new Rectangle(0, 0, size, size), (GraphicsUnit)2);
					num = (int)(num2 * 207553379) ^ -1607719479;
					continue;
				case 83u:
				{
					int num51;
					int num52;
					if (flag14)
					{
						num51 = -696270536;
						num52 = -696270536;
					}
					else
					{
						num51 = -1603351451;
						num52 = -1603351451;
					}
					num = num51 ^ ((int)num2 * -1983359844);
					continue;
				}
				case 82u:
					num18++;
					flag8 = false;
					num = ((int)num2 * -1951969738) ^ -1328845036;
					continue;
				case 81u:
					num43++;
					num = -1393415450;
					continue;
				case 80u:
					num10++;
					num = -790693889;
					continue;
				case 79u:
					num = (int)((num2 * 1924212838) ^ 0x6A45B8A8);
					continue;
				case 78u:
					num = (int)(num2 * 1305311677) ^ -1368160007;
					continue;
				case 77u:
					num = (int)((num2 * 1482122780) ^ 0x2C5D31AF);
					continue;
				case 76u:
					num = (int)(num2 * 789840090) ^ -1095277409;
					continue;
				case 75u:
					num = ((int)num2 * -190335129) ^ -1344708458;
					continue;
				case 74u:
					Form1.smethod_7((Control)(object)pictureBox[num47, num9], bool_0: false);
					num = -1629198248;
					continue;
				case 73u:
					flag7 = num47 < 4;
					num = -82135013;
					continue;
				case 72u:
					flag9 = Form1.smethod_40((Bitmap)Form1.smethod_21(pictureBox1), num8 * size + size / 2, (int)(((float)num7 + 0.05f) * (float)size)) == Color.FromArgb(255, 255, 0, 0);
					num = -268706891;
					continue;
				case 71u:
				{
					int num48;
					int num49;
					if (!flag13)
					{
						num48 = 1283652781;
						num49 = 1283652781;
					}
					else
					{
						num48 = 1791363436;
						num49 = 1791363436;
					}
					num = num48 ^ (int)(num2 * 1467871991);
					continue;
				}
				case 70u:
					Form1.smethod_30((Control)(object)pictureBox[num7, num8]);
					num = (int)((num2 * 138728487) ^ 0x7E9D1FE8);
					continue;
				case 69u:
					flag12 = Standoff(board);
					num = -1540198469;
					continue;
				case 68u:
					Form1.smethod_20(pictureBox[num7, num8], (Image)null);
					num = (int)(num2 * 444185373) ^ -1562273920;
					continue;
				case 67u:
					Form1.smethod_30((Control)(object)pictureBox[num3, num4]);
					num = ((int)num2 * -1539111) ^ -1985560660;
					continue;
				case 66u:
					(menu as Form3).ContinueLock();
					num = (int)(num2 * 1496377519) ^ -1581589552;
					continue;
				case 65u:
				{
					int num46;
					if (num21 < 4)
					{
						num = -605989854;
						num46 = -605989854;
					}
					else
					{
						num = -678790301;
						num46 = -678790301;
					}
					continue;
				}
				case 64u:
					num = ((int)num2 * -1647473703) ^ 0x3157CE9A;
					continue;
				case 63u:
				{
					int num44;
					int num45;
					if (flag9)
					{
						num44 = 458354134;
						num45 = 458354134;
					}
					else
					{
						num44 = 2105930639;
						num45 = 2105930639;
					}
					num = num44 ^ ((int)num2 * -215622275);
					continue;
				}
				case 62u:
					num = (int)(num2 * 61759069) ^ -1405292727;
					continue;
				case 61u:
					num = ((int)num2 * -1961207348) ^ -820403252;
					continue;
				case 60u:
					num43 = 0;
					num = -2136944606;
					continue;
				case 59u:
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox1));
					num = (int)(num2 * 993910592) ^ -1366627792;
					continue;
				case 58u:
				{
					int num41;
					if (num7 < 4)
					{
						num = -212750620;
						num41 = -212750620;
					}
					else
					{
						num = -703371126;
						num41 = -703371126;
					}
					continue;
				}
				case 57u:
					num = ((int)num2 * -1484117889) ^ -1473633272;
					continue;
				case 56u:
					Form1.smethod_30((Control)(object)pictureBox1);
					num = (int)(num2 * 1562988310) ^ -1593298687;
					continue;
				case 55u:
					num = -1629966356;
					continue;
				case 54u:
					Form1.smethod_20(pictureBox[num3, num4], (Image)null);
					num = ((int)num2 * -943726017) ^ 0x4DE6917D;
					continue;
				case 53u:
				{
					int num40;
					if (num10 >= 4)
					{
						num = -571352077;
						num40 = -571352077;
					}
					else
					{
						num = -1616077725;
						num40 = -1616077725;
					}
					continue;
				}
				case 52u:
				{
					int num38;
					int num39;
					if (board[num12, num13] != null)
					{
						num38 = 2053595015;
						num39 = 2053595015;
					}
					else
					{
						num38 = 1010989012;
						num39 = 1010989012;
					}
					num = num38 ^ (int)(num2 * 1456792049);
					continue;
				}
				case 51u:
					num = -791868663;
					continue;
				case 50u:
					num = (int)((num2 * 1992083982) ^ 0xA6A5873);
					continue;
				case 49u:
					Form1.smethod_30((Control)(object)pictureBox1);
					num = ((int)num2 * -1734748986) ^ -1334861535;
					continue;
				case 48u:
					num = (int)(num2 * 1345477973) ^ -1612305345;
					continue;
				case 47u:
					num11++;
					num = ((int)num2 * -872083143) ^ -94560663;
					continue;
				case 46u:
				{
					int num36;
					int num37;
					if (flag7)
					{
						num36 = -243730784;
						num37 = -243730784;
					}
					else
					{
						num36 = -1070130787;
						num37 = -1070130787;
					}
					num = num36 ^ (int)(num2 * 891810153);
					continue;
				}
				case 45u:
					num = ((int)num2 * -316389231) ^ -2108258749;
					continue;
				case 44u:
					Form1.smethod_32((Control)(object)richTextBox1, "QUARTO! Компьютер выиграл!");
					num = -1855021604;
					continue;
				case 43u:
					num = ((int)num2 * -689964299) ^ 0x318E8C47;
					continue;
				case 42u:
					num23 = num8;
					num = (int)(num2 * 1736709412) ^ -881275934;
					continue;
				case 41u:
					num31 = Form1.smethod_33(rnd, 4);
					num24 = Form1.smethod_33(rnd, 4);
					num = ((int)num2 * -267585005) ^ 0x1B22027F;
					continue;
				case 40u:
					step++;
					num = -843601315;
					continue;
				case 39u:
					(menu as Form3).ContinueLock();
					num = ((int)num2 * -1651463818) ^ 0x5579BD2F;
					continue;
				case 38u:
				{
					int num32;
					int num33;
					if (flag2)
					{
						num32 = -1363748706;
						num33 = -1363748706;
					}
					else
					{
						num32 = -1269003425;
						num33 = -1269003425;
					}
					num = num32 ^ (int)(num2 * 980737308);
					continue;
				}
				case 37u:
					Form1.smethod_7((Control)(object)pictureBox[num17, num21], bool_0: true);
					num = -828766520;
					continue;
				case 36u:
					Form1.smethod_30((Control)(object)label2);
					Form1.smethod_32((Control)(object)richTextBox1, "Подождите, компьютер делает свой ход.");
					Form1.smethod_30((Control)(object)richTextBox1);
					num = (int)(num2 * 431033140) ^ -289224047;
					continue;
				case 34u:
					Form1.smethod_5((Control)(object)borderBox[num31, num24], Color.Blue);
					Form1.smethod_30((Control)(object)borderBox[num31, num24]);
					num = ((int)num2 * -1239285325) ^ 0x727C9390;
					continue;
				case 33u:
					num = (int)((num2 * 627213841) ^ 0x4D0F49);
					continue;
				case 32u:
				{
					int num27;
					int num28;
					if (!flag5)
					{
						num27 = -1580508359;
						num28 = -1580508359;
					}
					else
					{
						num27 = -896988991;
						num28 = -896988991;
					}
					num = num27 ^ ((int)num2 * -903584528);
					continue;
				}
				case 31u:
					step++;
					Form1.smethod_32((Control)(object)label2, Form1.smethod_34("Ход: ", step.ToString()));
					num = ((int)num2 * -1568875012) ^ 0x55875FEA;
					continue;
				case 30u:
					num9 = 0;
					num = -2044173925;
					continue;
				case 29u:
					num = ((int)num2 * -1682749773) ^ 0x5B61D1A3;
					continue;
				case 28u:
					num26 = 0;
					num = (int)(num2 * 578571655) ^ -1350637842;
					continue;
				case 27u:
					num25 = ((num24 == num4) ? 1 : 0);
					goto IL_01d2;
				case 26u:
					Form1.smethod_20(pictureBox[num3, num4], (Image)null);
					Form1.smethod_30((Control)(object)pictureBox[num3, num4]);
					num = (int)((num2 * 792765430) ^ 0x6E7FB7BB);
					continue;
				case 25u:
					num = (int)(num2 * 1104455158) ^ -1476489432;
					continue;
				case 24u:
					Form1.smethod_47(200);
					num = ((int)num2 * -1302845522) ^ 0x4A385B27;
					continue;
				case 23u:
					num10 = 0;
					num = -790693889;
					continue;
				case 22u:
					Paint_Board();
					if (!Stop(board))
					{
						num = (int)(num2 * 648138772) ^ -613501346;
						continue;
					}
					goto IL_0073;
				case 21u:
					num = -769253642;
					continue;
				case 20u:
					num23 = 0;
					num7 = 0;
					num = ((int)num2 * -1483379649) ^ 0x3CEE368D;
					continue;
				case 19u:
					num = (int)(num2 * 236124521) ^ -758801167;
					continue;
				case 18u:
					if (!Standoff(array2))
					{
						num = -484803779;
						num22 = -484803779;
						continue;
					}
					goto IL_071c;
				case 17u:
				{
					int num19;
					int num20;
					if (!flag4)
					{
						num19 = -1203897168;
						num20 = -1203897168;
					}
					else
					{
						num19 = -1424353178;
						num20 = -1424353178;
					}
					num = num19 ^ ((int)num2 * -689892756);
					continue;
				}
				case 16u:
				{
					int num15;
					int num16;
					if (flag3)
					{
						num15 = 725351576;
						num16 = 725351576;
					}
					else
					{
						num15 = 1078709692;
						num16 = 1078709692;
					}
					num = num15 ^ (int)(num2 * 1337478877);
					continue;
				}
				case 15u:
					num = (int)((num2 * 556256899) ^ 0x438606EF);
					continue;
				case 14u:
					num14 = 0;
					num = (int)((num2 * 1872255577) ^ 0x7A5EE73);
					continue;
				case 13u:
					num = ((int)num2 * -1630103399) ^ 0x2969F05E;
					continue;
				case 12u:
					board[num12, num13] = new Figurine(storage[num3, num4]);
					storage[num3, num4] = null;
					num = ((int)num2 * -1517527025) ^ -1707075265;
					continue;
				case 11u:
					num8++;
					num = -1395681524;
					continue;
				case 10u:
					array[num12, num13] = new Figurine(storage[num3, num4]);
					num = ((int)num2 * -862720309) ^ 0x32708D4;
					continue;
				case 9u:
					array = (Figurine[,])Form1.smethod_48((Array)board);
					num = ((int)num2 * -1666241322) ^ -450565148;
					continue;
				case 8u:
					num12 = Form1.smethod_33(rnd, 4);
					num = ((int)num2 * -1479873595) ^ 0x7E1F48BD;
					continue;
				case 7u:
					Form1.smethod_32((Control)(object)richTextBox1, "Выберете фигуру, которой будет играть противник.");
					num = ((int)num2 * -954178662) ^ 0x20680E7E;
					continue;
				case 6u:
					num = ((int)num2 * -1488247215) ^ -188182689;
					continue;
				case 5u:
					Form1.smethod_43(graphics_, Form1.smethod_42(Color.LimeGreen, 3f), ((float)num10 + 0.05f) * (float)size, ((float)num11 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					num = (int)(num2 * 1622617181) ^ -1450904662;
					continue;
				case 4u:
					num9++;
					num = ((int)num2 * -1619326195) ^ 0x7704985B;
					continue;
				case 3u:
					num = ((int)num2 * -761516161) ^ 0x7BA4BBE8;
					continue;
				case 2u:
				{
					int num5;
					int num6;
					if (flag)
					{
						num5 = -1072612173;
						num6 = -1072612173;
					}
					else
					{
						num5 = -748972554;
						num6 = -748972554;
					}
					num = num5 ^ ((int)num2 * -1728545748);
					continue;
				}
				case 1u:
					Form1.smethod_5((Control)(object)borderBox[num3, num4], Color.White);
					num = (int)(num2 * 649413374) ^ -1241560559;
					continue;
				case 0u:
					Form1.smethod_47(200);
					num = ((int)num2 * -483161269) ^ 0x1FB9C0B8;
					continue;
				default:
					return;
				case 116u:
					break;
				case 35u:
					return;
					IL_03ac:
					flag10 = (byte)num42 != 0;
					num = -95210029;
					continue;
					IL_0073:
					num = -441898193;
					num57 = -441898193;
					continue;
					IL_01d2:
					flag15 = (byte)num25 != 0;
					num = -559470632;
					continue;
					IL_071c:
					num = -151191405;
					num22 = -151191405;
					continue;
				}
				break;
			}
		}
	}

	private bool Stop(Figurine[,] mem)
	{
		bool flag = false;
		int num = 0;
		bool flag2 = default(bool);
		bool result = default(bool);
		while (true)
		{
			int num2 = -879153326;
			while (true)
			{
				uint num3;
				int num15;
				int num12;
				switch ((num3 = (uint)num2 ^ 0xB1286600u) % 73u)
				{
				case 72u:
					if (mem[2, 1] != null)
					{
						num2 = (int)(num3 * 203012551) ^ -1275480915;
						continue;
					}
					goto IL_0026;
				case 71u:
					if (mem[2, 2].Dark != mem[3, 3].Dark)
					{
						num2 = (int)(num3 * 1563613174) ^ -2144358448;
						continue;
					}
					goto IL_0062;
				case 70u:
					flag = true;
					num2 = (int)(num3 * 524330765) ^ -1087647641;
					continue;
				case 69u:
					if (mem[2, 1].Point != mem[3, 0].Point)
					{
						num2 = ((int)num3 * -1015993545) ^ 0x2DB4404C;
						continue;
					}
					goto IL_00a9;
				case 68u:
					if (mem[num, 2].Dark != mem[num, 3].Dark)
					{
						num2 = ((int)num3 * -983262216) ^ 0x77698CB;
						continue;
					}
					goto IL_00ed;
				case 67u:
				{
					int num42;
					int num43;
					if (mem[num, 0].Big != mem[num, 1].Big)
					{
						num42 = -848086912;
						num43 = -848086912;
					}
					else
					{
						num42 = -1872797049;
						num43 = -1872797049;
					}
					num2 = num42 ^ ((int)num3 * -692709477);
					continue;
				}
				case 65u:
				{
					int num20;
					int num21;
					if (mem[1, 1].Square == mem[2, 2].Square)
					{
						num20 = -651920925;
						num21 = -651920925;
					}
					else
					{
						num20 = -1640327794;
						num21 = -1640327794;
					}
					num2 = num20 ^ ((int)num3 * -1269368737);
					continue;
				}
				case 64u:
					if (mem[0, num].Square == mem[1, num].Square)
					{
						num2 = -608086072;
						continue;
					}
					goto IL_00e1;
				case 63u:
					if (mem[2, 1].Big != mem[3, 0].Big)
					{
						num2 = ((int)num3 * -1082134305) ^ 0xCC73DE;
						continue;
					}
					goto IL_00a9;
				case 62u:
					if (mem[2, num].Square != mem[3, num].Square)
					{
						goto IL_00e1;
					}
					goto IL_00ed;
				case 61u:
				{
					int num48;
					int num49;
					if (mem[1, num].Dark == mem[2, num].Dark)
					{
						num48 = 870248845;
						num49 = 870248845;
					}
					else
					{
						num48 = 40972398;
						num49 = 40972398;
					}
					num2 = num48 ^ (int)(num3 * 709307550);
					continue;
				}
				case 60u:
				{
					int num31;
					int num32;
					if (mem[1, 2].Big == mem[2, 1].Big)
					{
						num31 = -1021193183;
						num32 = -1021193183;
					}
					else
					{
						num31 = -707965023;
						num32 = -707965023;
					}
					num2 = num31 ^ (int)(num3 * 880402775);
					continue;
				}
				case 59u:
				{
					int num25;
					int num26;
					if (mem[0, num].Big == mem[1, num].Big)
					{
						num25 = 154693670;
						num26 = 154693670;
					}
					else
					{
						num25 = 402999500;
						num26 = 402999500;
					}
					num2 = num25 ^ (int)(num3 * 1503306885);
					continue;
				}
				case 58u:
					if (mem[2, 1].Dark != mem[3, 0].Dark)
					{
						num2 = ((int)num3 * -1088609446) ^ -272450355;
						continue;
					}
					goto IL_00a9;
				case 57u:
				{
					int num4;
					if (mem[0, 0].Square == mem[1, 1].Square)
					{
						num2 = -1959514445;
						num4 = -1959514445;
					}
					else
					{
						num2 = -1590364189;
						num4 = -1590364189;
					}
					continue;
				}
				case 56u:
					if (mem[0, 3].Square == mem[1, 2].Square)
					{
						num2 = -862545194;
						continue;
					}
					goto IL_0351;
				case 55u:
				{
					int num64;
					int num65;
					if (mem[1, 2].Dark != mem[2, 1].Dark)
					{
						num64 = 1948675623;
						num65 = 1948675623;
					}
					else
					{
						num64 = 608511913;
						num65 = 608511913;
					}
					num2 = num64 ^ (int)(num3 * 1454777064);
					continue;
				}
				case 54u:
				{
					int num56;
					int num57;
					if (mem[num, 1] == null)
					{
						num56 = -1486224083;
						num57 = -1486224083;
					}
					else
					{
						num56 = -1413572253;
						num57 = -1413572253;
					}
					num2 = num56 ^ (int)(num3 * 1656223461);
					continue;
				}
				case 53u:
					if (mem[0, 3] != null)
					{
						num2 = -581441676;
						continue;
					}
					goto IL_0026;
				case 52u:
				{
					int num37;
					int num38;
					if (mem[num, 1].Big == mem[num, 2].Big)
					{
						num37 = 249643084;
						num38 = 249643084;
					}
					else
					{
						num37 = 1136133695;
						num38 = 1136133695;
					}
					num2 = num37 ^ ((int)num3 * -961541707);
					continue;
				}
				case 51u:
				{
					int num33;
					int num34;
					if (mem[2, 2] == null)
					{
						num33 = -1679601073;
						num34 = -1679601073;
					}
					else
					{
						num33 = -1012371806;
						num34 = -1012371806;
					}
					num2 = num33 ^ ((int)num3 * -544818975);
					continue;
				}
				case 50u:
				{
					int num16;
					int num17;
					if (flag2)
					{
						num16 = -1311026940;
						num17 = -1311026940;
					}
					else
					{
						num16 = -423041696;
						num17 = -423041696;
					}
					num2 = num16 ^ (int)(num3 * 1642126188);
					continue;
				}
				case 49u:
					num++;
					num2 = -550381126;
					continue;
				case 48u:
				{
					int num9;
					if (mem[0, 0].Dark == mem[1, 1].Dark)
					{
						num2 = -656299794;
						num9 = -656299794;
					}
					else
					{
						num2 = -1055724298;
						num9 = -1055724298;
					}
					continue;
				}
				case 47u:
					if (mem[2, num].Dark != mem[3, num].Dark)
					{
						num2 = ((int)num3 * -1702067231) ^ 0x56022543;
						continue;
					}
					goto IL_00ed;
				case 46u:
				{
					int num68;
					if (num < 4)
					{
						num2 = -1375451680;
						num68 = -1375451680;
					}
					else
					{
						num2 = -349786170;
						num68 = -349786170;
					}
					continue;
				}
				case 45u:
					if (mem[2, num] != null)
					{
						num2 = ((int)num3 * -797517056) ^ 0x52739685;
						continue;
					}
					goto IL_00e1;
				case 44u:
					if (mem[2, 2].Point != mem[3, 3].Point)
					{
						num2 = (int)(num3 * 1977178017) ^ -362527793;
						continue;
					}
					goto IL_0062;
				case 43u:
					if (mem[num, 2].Square != mem[num, 3].Square)
					{
						num2 = ((int)num3 * -625720168) ^ -2031886857;
						continue;
					}
					goto IL_00ed;
				case 42u:
				{
					int num60;
					int num61;
					if (mem[1, 1] == null)
					{
						num60 = -1148040581;
						num61 = -1148040581;
					}
					else
					{
						num60 = -1471257420;
						num61 = -1471257420;
					}
					num2 = num60 ^ (int)(num3 * 1376583144);
					continue;
				}
				case 41u:
					if (mem[3, num] != null)
					{
						num2 = (int)((num3 * 1489810605) ^ 0x24DF96A2);
						continue;
					}
					goto IL_00e1;
				case 40u:
				{
					int num52;
					int num53;
					if (mem[3, 3] == null)
					{
						num52 = 619316751;
						num53 = 619316751;
					}
					else
					{
						num52 = 1185786579;
						num53 = 1185786579;
					}
					num2 = num52 ^ ((int)num3 * -2011732262);
					continue;
				}
				case 39u:
					flag = true;
					num2 = ((int)num3 * -56090616) ^ -825547452;
					continue;
				case 38u:
					if (mem[num, 2].Point != mem[num, 3].Point)
					{
						num2 = ((int)num3 * -620391892) ^ -474667681;
						continue;
					}
					goto IL_00ed;
				case 37u:
				{
					int num45;
					if (mem[0, num].Point != mem[1, num].Point)
					{
						num2 = -967059771;
						num45 = -967059771;
					}
					else
					{
						num2 = -748452694;
						num45 = -748452694;
					}
					continue;
				}
				case 36u:
					if (mem[1, num] != null)
					{
						num2 = (int)(num3 * 628538377) ^ -1519071167;
						continue;
					}
					goto IL_00e1;
				case 35u:
				{
					int num39;
					int num40;
					if (mem[1, 1].Point != mem[2, 2].Point)
					{
						num39 = 1440876629;
						num40 = 1440876629;
					}
					else
					{
						num39 = 683642234;
						num40 = 683642234;
					}
					num2 = num39 ^ (int)(num3 * 617356085);
					continue;
				}
				case 34u:
				{
					int num27;
					int num28;
					if (mem[0, 3].Big == mem[1, 2].Big)
					{
						num27 = 180049440;
						num28 = 180049440;
					}
					else
					{
						num27 = 1865882137;
						num28 = 1865882137;
					}
					num2 = num27 ^ ((int)num3 * -634505749);
					continue;
				}
				case 33u:
				{
					int num22;
					int num23;
					if (mem[num, 1].Dark == mem[num, 2].Dark)
					{
						num22 = -365887897;
						num23 = -365887897;
					}
					else
					{
						num22 = -1419429443;
						num23 = -1419429443;
					}
					num2 = num22 ^ (int)(num3 * 1724014614);
					continue;
				}
				case 32u:
					num2 = (int)((num3 * 1289250049) ^ 0x7EFF7AE8);
					continue;
				case 31u:
				{
					int num13;
					int num14;
					if (mem[num, 2] == null)
					{
						num13 = 388057615;
						num14 = 388057615;
					}
					else
					{
						num13 = 1531504713;
						num14 = 1531504713;
					}
					num2 = num13 ^ (int)(num3 * 157132488);
					continue;
				}
				case 30u:
					if (mem[2, num].Big != mem[3, num].Big)
					{
						num2 = (int)(num3 * 551389773) ^ -2140311585;
						continue;
					}
					goto IL_00ed;
				case 29u:
					if (mem[1, 2].Square == mem[2, 1].Square)
					{
						num2 = ((int)num3 * -130078850) ^ 0x6D6E7C43;
						continue;
					}
					goto IL_0351;
				case 28u:
				{
					int num7;
					if (mem[0, 3].Dark == mem[1, 2].Dark)
					{
						num2 = -2090148432;
						num7 = -2090148432;
					}
					else
					{
						num2 = -1935599193;
						num7 = -1935599193;
					}
					continue;
				}
				case 27u:
				{
					int num69;
					if (mem[num, 0].Dark != mem[num, 1].Dark)
					{
						num2 = -1995168141;
						num69 = -1995168141;
					}
					else
					{
						num2 = -1515234539;
						num69 = -1515234539;
					}
					continue;
				}
				case 26u:
				{
					int num67;
					if (mem[0, 3].Point != mem[1, 2].Point)
					{
						num2 = -726989103;
						num67 = -726989103;
					}
					else
					{
						num2 = -1801862196;
						num67 = -1801862196;
					}
					continue;
				}
				case 25u:
					if (mem[1, 2] != null)
					{
						num2 = (int)(num3 * 1196203711) ^ -482402846;
						continue;
					}
					goto IL_0026;
				case 24u:
					if (mem[2, num].Point != mem[3, num].Point)
					{
						num2 = (int)(num3 * 1055479536) ^ -1031736187;
						continue;
					}
					goto IL_00ed;
				case 23u:
				{
					int num66;
					if (mem[num, 0].Point == mem[num, 1].Point)
					{
						num2 = -1967940021;
						num66 = -1967940021;
					}
					else
					{
						num2 = -325952065;
						num66 = -325952065;
					}
					continue;
				}
				case 22u:
				{
					int num62;
					int num63;
					if (mem[1, num].Point == mem[2, num].Point)
					{
						num62 = 765632618;
						num63 = 765632618;
					}
					else
					{
						num62 = 661018291;
						num63 = 661018291;
					}
					num2 = num62 ^ ((int)num3 * -857724081);
					continue;
				}
				case 21u:
				{
					int num58;
					int num59;
					if (mem[0, 0].Big == mem[1, 1].Big)
					{
						num58 = -852064254;
						num59 = -852064254;
					}
					else
					{
						num58 = -1834045944;
						num59 = -1834045944;
					}
					num2 = num58 ^ (int)(num3 * 193570037);
					continue;
				}
				case 20u:
				{
					int num54;
					int num55;
					if (mem[num, 3] == null)
					{
						num54 = 458223717;
						num55 = 458223717;
					}
					else
					{
						num54 = 1864064421;
						num55 = 1864064421;
					}
					num2 = num54 ^ ((int)num3 * -268004638);
					continue;
				}
				case 19u:
					result = flag;
					num2 = -1047618761;
					continue;
				case 17u:
				{
					int num50;
					int num51;
					if (mem[num, 1].Point == mem[num, 2].Point)
					{
						num50 = -2034471017;
						num51 = -2034471017;
					}
					else
					{
						num50 = -1813815936;
						num51 = -1813815936;
					}
					num2 = num50 ^ ((int)num3 * -1797175459);
					continue;
				}
				case 16u:
				{
					int num46;
					int num47;
					if (mem[1, 2].Point != mem[2, 1].Point)
					{
						num46 = -1607672499;
						num47 = -1607672499;
					}
					else
					{
						num46 = -1022577833;
						num47 = -1022577833;
					}
					num2 = num46 ^ ((int)num3 * -1118556227);
					continue;
				}
				case 15u:
				{
					int num44;
					if (mem[0, 0].Point != mem[1, 1].Point)
					{
						num2 = -314837444;
						num44 = -314837444;
					}
					else
					{
						num2 = -938184987;
						num44 = -938184987;
					}
					continue;
				}
				case 14u:
				{
					int num41;
					if (mem[num, 0].Square != mem[num, 1].Square)
					{
						num2 = -1912025849;
						num41 = -1912025849;
					}
					else
					{
						num2 = -633303965;
						num41 = -633303965;
					}
					continue;
				}
				case 13u:
					if (mem[3, 0] != null)
					{
						num2 = ((int)num3 * -1346921928) ^ -2103294588;
						continue;
					}
					goto IL_0026;
				case 12u:
				{
					int num35;
					int num36;
					if (mem[1, 1].Dark != mem[2, 2].Dark)
					{
						num35 = 357506244;
						num36 = 357506244;
					}
					else
					{
						num35 = 118506363;
						num36 = 118506363;
					}
					num2 = num35 ^ (int)(num3 * 1809064175);
					continue;
				}
				case 11u:
				{
					int num29;
					int num30;
					if (mem[1, num].Big == mem[2, num].Big)
					{
						num29 = 1324762363;
						num30 = 1324762363;
					}
					else
					{
						num29 = 1389606836;
						num30 = 1389606836;
					}
					num2 = num29 ^ (int)(num3 * 185218463);
					continue;
				}
				case 10u:
				{
					int num24;
					if (mem[num, 0] == null)
					{
						num2 = -1912025849;
						num24 = -1912025849;
					}
					else
					{
						num2 = -18346782;
						num24 = -18346782;
					}
					continue;
				}
				case 9u:
				{
					int num18;
					int num19;
					if (mem[num, 1].Square == mem[num, 2].Square)
					{
						num18 = -1817124472;
						num19 = -1817124472;
					}
					else
					{
						num18 = -422112091;
						num19 = -422112091;
					}
					num2 = num18 ^ (int)(num3 * 961409142);
					continue;
				}
				case 8u:
					if (mem[0, num] != null)
					{
						num2 = -95007706;
						continue;
					}
					goto IL_00e1;
				case 7u:
					if (mem[2, 2].Big != mem[3, 3].Big)
					{
						num2 = (int)((num3 * 584082927) ^ 0x34EDF532);
						continue;
					}
					goto IL_0062;
				case 6u:
					if (mem[2, 2].Square != mem[3, 3].Square)
					{
						num2 = (int)(num3 * 939936410) ^ -1339399025;
						continue;
					}
					goto IL_0062;
				case 5u:
					num15 = ((mem[2, 1].Square == mem[3, 0].Square) ? 1 : 0);
					goto IL_0027;
				case 4u:
					if (mem[1, num].Square == mem[2, num].Square)
					{
						num2 = (int)(num3 * 2125340609) ^ -481466434;
						continue;
					}
					goto IL_00e1;
				case 3u:
				{
					int num10;
					int num11;
					if (mem[0, 0] != null)
					{
						num10 = 2087251365;
						num11 = 2087251365;
					}
					else
					{
						num10 = 1366599785;
						num11 = 1366599785;
					}
					num2 = num10 ^ ((int)num3 * -1458904777);
					continue;
				}
				case 2u:
				{
					int num8;
					if (mem[0, num].Dark != mem[1, num].Dark)
					{
						num2 = -1141510488;
						num8 = -1141510488;
					}
					else
					{
						num2 = -1283915091;
						num8 = -1283915091;
					}
					continue;
				}
				case 1u:
				{
					int num5;
					int num6;
					if (mem[1, 1].Big != mem[2, 2].Big)
					{
						num5 = -447198148;
						num6 = -447198148;
					}
					else
					{
						num5 = -848453408;
						num6 = -848453408;
					}
					num2 = num5 ^ ((int)num3 * -1563609977);
					continue;
				}
				case 0u:
					if (mem[num, 2].Big != mem[num, 3].Big)
					{
						num2 = ((int)num3 * -824140224) ^ -1098103683;
						continue;
					}
					goto IL_00ed;
				case 66u:
					break;
				default:
					{
						return result;
					}
					IL_00e1:
					num2 = -2038031835;
					num12 = -2038031835;
					continue;
					IL_00a9:
					num15 = 1;
					goto IL_0027;
					IL_0062:
					num15 = 1;
					goto IL_0027;
					IL_0027:
					flag2 = (byte)num15 != 0;
					num2 = -1601081685;
					continue;
					IL_0026:
					num15 = 0;
					goto IL_0027;
					IL_00ed:
					num2 = -721746742;
					num12 = -721746742;
					continue;
					IL_0351:
					num15 = 0;
					goto IL_0027;
				}
				break;
			}
		}
	}

	private bool Standoff(Figurine[,] mem)
	{
		int num3 = default(int);
		int num4 = default(int);
		bool flag2 = default(bool);
		bool result = default(bool);
		bool flag = default(bool);
		while (true)
		{
			int num = -122996416;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA88043C7u) % 15u)
				{
				case 14u:
					num = ((int)num2 * -221600707) ^ -1763546417;
					continue;
				case 13u:
				{
					int num8;
					if (mem[num3, num4] == null)
					{
						num = -1657368083;
						num8 = -1657368083;
					}
					else
					{
						num = -2113149436;
						num8 = -2113149436;
					}
					continue;
				}
				case 12u:
					num4 = 0;
					num = -1293834226;
					continue;
				case 10u:
				{
					int num6;
					int num7;
					if (flag2)
					{
						num6 = 1454043687;
						num7 = 1454043687;
					}
					else
					{
						num6 = 602362058;
						num7 = 602362058;
					}
					num = num6 ^ (int)(num2 * 428016683);
					continue;
				}
				case 9u:
					flag2 = num4 < 4;
					num = -976099606;
					continue;
				case 8u:
					result = flag;
					num = (int)((num2 * 1574249511) ^ 0x46048EBB);
					continue;
				case 7u:
					flag = false;
					num = ((int)num2 * -819434840) ^ 0x3D84A994;
					continue;
				case 5u:
					flag = true;
					num3 = 0;
					num = (int)((num2 * 493257524) ^ 0x646172C1);
					continue;
				case 4u:
					num = (int)((num2 * 1041051035) ^ 0x563FEE46);
					continue;
				case 3u:
					num = (int)((num2 * 1168904310) ^ 0x7FD7F098);
					continue;
				case 2u:
				{
					int num5;
					if (num3 >= 4)
					{
						num = -1648283134;
						num5 = -1648283134;
					}
					else
					{
						num = -1166182996;
						num5 = -1166182996;
					}
					continue;
				}
				case 1u:
					num4++;
					num = -2133919243;
					continue;
				case 0u:
					num3++;
					num = ((int)num2 * -344330872) ^ 0x4A8FA154;
					continue;
				case 11u:
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
			int num = -134316223;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xCC2D0328u) % 9u)
				{
				case 8u:
					Form1.smethod_32((Control)(object)label2, "");
					num = ((int)num2 * -1646416012) ^ -352765198;
					continue;
				case 7u:
					num = ((int)num2 * -1721789817) ^ -1412343406;
					continue;
				case 5u:
					Form1.smethod_50((Control)(object)label6, Form1.smethod_37((Control)(object)label5).X + Form1.smethod_18((Control)(object)label5));
					num = ((int)num2 * -233506964) ^ 0x4E7737F6;
					continue;
				case 4u:
					Form1.smethod_32((Control)(object)label6, str);
					num = ((int)num2 * -424869252) ^ -282353109;
					continue;
				case 3u:
					Form1.smethod_32((Control)(object)label1, "");
					num = (int)((num2 * 1970869629) ^ 0x3DC294E);
					continue;
				case 2u:
					Form1.smethod_50((Control)(object)label5, (Form1.smethod_49((Control)(object)this) - (Form1.smethod_18((Control)(object)label5) + Form1.smethod_18((Control)(object)label6))) / 2);
					num = (int)((num2 * 1010110472) ^ 0x1BF072BA);
					continue;
				case 1u:
					num = (int)(num2 * 1311781385) ^ -1599381947;
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

	protected override void Dispose(bool disposing)
	{
		while (true)
		{
			int num = -1245781084;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0xC1A3E3A0u) % 8u)
				{
				case 6u:
					Form1.smethod_51((IDisposable)components);
					num = ((int)num2 * -100663800) ^ -2053981887;
					continue;
				case 4u:
					if (disposing)
					{
						num = ((int)num2 * -1436559697) ^ -938377290;
						continue;
					}
					goto IL_0035;
				case 3u:
					((Form)this).Dispose(disposing);
					num = -1512284744;
					continue;
				case 2u:
					if (components != null)
					{
						num = -1563829794;
						num3 = -1563829794;
						continue;
					}
					goto IL_0035;
				case 1u:
					num = ((int)num2 * -998440608) ^ -806977637;
					continue;
				case 0u:
					num = (int)((num2 * 10325935) ^ 0x3B5E6C55);
					continue;
				default:
					return;
				case 7u:
					break;
				case 5u:
					return;
					IL_0035:
					num = -1542944517;
					num3 = -1542944517;
					continue;
				}
				break;
			}
		}
	}

	private void InitializeComponent()
	{
		//IL_07a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_07aa: Expected O, but got Unknown
		components = Form1.smethod_52();
		byte[] array = default(byte[]);
		int num3 = default(int);
		bool flag = default(bool);
		string sa = default(string);
		object[] object_ = default(object[]);
		while (true)
		{
			int num = 702919738;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x5654CC6Bu) % 126u)
				{
				case 125u:
					Form1.smethod_65((Control)(object)button2, bool_0: false);
					num = (int)(num2 * 1118518901) ^ -1358439458;
					continue;
				case 124u:
					Form1.smethod_4((Control)(object)richTextBox1, new Point(107, 275));
					num = (int)(num2 * 1602498720) ^ -858129010;
					continue;
				case 123u:
					num = ((int)num2 * -985952676) ^ -32853357;
					continue;
				case 122u:
					num = ((int)num2 * -312127229) ^ -85326444;
					continue;
				case 121u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)richTextBox1);
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)button2);
					num = ((int)num2 * -2050493310) ^ -1368125304;
					continue;
				case 120u:
					Form1.smethod_4((Control)(object)label5, new Point(197, 0));
					num = (int)((num2 * 1415774654) ^ 0x4AEAD5DD);
					continue;
				case 119u:
					Form1.smethod_85((Control)(object)this, "Form1");
					num = ((int)num2 * -1191607189) ^ -913774848;
					continue;
				case 118u:
					Form1.smethod_86((Form)(object)this, bool_0: false);
					num = (int)((num2 * 630176819) ^ 0x2FE85B73);
					continue;
				case 117u:
					num = (int)((num2 * 85702389) ^ 0x293F299A);
					continue;
				case 116u:
					Form1.smethod_67((Control)(object)button2, (EventHandler)Button2_Click);
					num = (int)((num2 * 1238388502) ^ 0x5DEB16A6);
					continue;
				case 115u:
					Form1.smethod_64((Control)(object)label1, 8);
					Form1.smethod_74((Control)(object)label2, bool_0: true);
					num = (int)((num2 * 419702222) ^ 0x631F3BB4);
					continue;
				case 114u:
					num = 1264632674;
					continue;
				case 113u:
					Form1.smethod_73(timer1, (EventHandler)Timer1_Tick);
					Form1.smethod_74((Control)(object)label1, bool_0: true);
					num = ((int)num2 * -1662342332) ^ -1726251482;
					continue;
				case 112u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label6);
					num = (int)(num2 * 926147013) ^ -506447699;
					continue;
				case 111u:
					array[num3] = Form1.smethod_69(Form1.smethod_68(sa, num3 * 2, 2), 16);
					num = ((int)num2 * -1968195348) ^ 0x31688252;
					continue;
				case 110u:
					Form1.smethod_61((Control)(object)label1, "label1");
					num = ((int)num2 * -1813708452) ^ 0x3EA2F159;
					continue;
				case 109u:
					Form1.smethod_66((ButtonBase)(object)button1, bool_0: true);
					num = ((int)num2 * -623525286) ^ -178286162;
					continue;
				case 108u:
					label6 = Form1.smethod_57();
					Form1.smethod_58((ISupportInitialize)pictureBox1);
					num = ((int)num2 * -1494973899) ^ -43192628;
					continue;
				case 107u:
					Form1.smethod_87((Form)(object)this, (EventHandler)Form1_Load);
					num = ((int)num2 * -1208614301) ^ -1911079297;
					continue;
				case 106u:
					Form1.smethod_3((Control)(object)label1, new Size(0, 16));
					num = ((int)num2 * -320883348) ^ 0x628452C8;
					continue;
				case 105u:
					num = (int)(num2 * 50213421) ^ -1596880678;
					continue;
				case 104u:
					Form1.smethod_3((Control)(object)button1, new Size(83, 35));
					num = ((int)num2 * -620961571) ^ -2074290292;
					continue;
				case 103u:
					Form1.smethod_90((ISupportInitialize)pictureBox1);
					num = (int)(num2 * 1960437418) ^ -1359037921;
					continue;
				case 102u:
					Form1.smethod_3((Control)(object)label5, new Size(0, 16));
					num = ((int)num2 * -726731934) ^ 0x32E7B954;
					continue;
				case 101u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)pictureBox1);
					num = ((int)num2 * -5327950) ^ 0x58F4B157;
					continue;
				case 100u:
					num = (int)((num2 * 1534970292) ^ 0x136D1F95);
					continue;
				case 99u:
					Form1.smethod_81((Form)(object)this, new Size(486, 319));
					num = ((int)num2 * -1630142335) ^ 0x78A40D10;
					continue;
				case 98u:
					num = (int)(num2 * 1397184738) ^ -1314978473;
					continue;
				case 97u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label2);
					num = (int)((num2 * 560946129) ^ 0x353AADD6);
					continue;
				case 96u:
					Form1.smethod_64((Control)(object)button2, 4);
					num = (int)(num2 * 1057546822) ^ -1386824896;
					continue;
				case 95u:
					Form1.smethod_88((Form)(object)this, (EventHandler)Form1_Shown);
					num = (int)(num2 * 459236645) ^ -198118103;
					continue;
				case 94u:
					num = (int)(num2 * 503205801) ^ -1139505867;
					continue;
				case 93u:
					Form1.smethod_3((Control)(object)panel1, new Size(486, 240));
					num = (int)(num2 * 939677228) ^ -1803860491;
					continue;
				case 92u:
					Form1.smethod_59((Control)(object)this);
					num = ((int)num2 * -1151090431) ^ -2003487329;
					continue;
				case 91u:
					sa = Form1.smethod_34(sa, Veet.Zr);
					num = ((int)num2 * -278588582) ^ 0x3541E37F;
					continue;
				case 90u:
					num = ((int)num2 * -1075123312) ^ -2040789712;
					continue;
				case 89u:
					num = (int)(num2 * 1486160886) ^ -1547736068;
					continue;
				case 88u:
					Form1.smethod_4((Control)(object)label6, new Point(275, 0));
					Form1.smethod_61((Control)(object)label6, "label6");
					num = ((int)num2 * -66057211) ^ 0x1879EF64;
					continue;
				case 87u:
					Form1.smethod_77((Control)(object)label6, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = ((int)num2 * -1764629688) ^ -536844737;
					continue;
				case 86u:
					Form1.smethod_61((Control)(object)panel1, "panel1");
					num = (int)((num2 * 872286932) ^ 0x3956F991);
					continue;
				case 85u:
					Form1.smethod_77((Control)(object)label2, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = (int)((num2 * 1989963888) ^ 0x6F75E4C9);
					continue;
				case 84u:
					flag = num3 < 22528;
					num = 2056371421;
					continue;
				case 83u:
					num = ((int)num2 * -89825987) ^ 0x69340A5D;
					continue;
				case 82u:
					Form1.smethod_3((Control)(object)pictureBox1, new Size(246, 246));
					Form1.smethod_62(pictureBox1, 0);
					num = (int)(num2 * 1184403838) ^ -812340292;
					continue;
				case 81u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label1);
					num = ((int)num2 * -158869643) ^ 0x69263E45;
					continue;
				case 80u:
					sa = Veet.Sa;
					sa = Form1.smethod_34(sa, Veet.Xe);
					num = (int)((num2 * 475478135) ^ 0x5A516974);
					continue;
				case 79u:
					Form1.smethod_84((Form)(object)this, bool_0: false);
					num = ((int)num2 * -1089886736) ^ -164514218;
					continue;
				case 78u:
					num = ((int)num2 * -1399076790) ^ 0x2E7E7B6F;
					continue;
				case 77u:
					Form1.smethod_61((Control)(object)richTextBox1, "richTextBox1");
					num = (int)(num2 * 1643523034) ^ -1427978899;
					continue;
				case 76u:
					Form1.smethod_61((Control)(object)button2, "button2");
					num = (int)(num2 * 1186828781) ^ -1705106204;
					continue;
				case 75u:
					Form1.smethod_64((Control)(object)label2, 9);
					num = (int)(num2 * 928857808) ^ -870141051;
					continue;
				case 74u:
					num = (int)(num2 * 102337515) ^ -1112706018;
					continue;
				case 73u:
					Form1.smethod_3((Control)(object)label6, new Size(0, 16));
					Form1.smethod_64((Control)(object)label6, 13);
					num = (int)((num2 * 2070956672) ^ 0x6ECDFB1A);
					continue;
				case 72u:
					Form1.smethod_66((ButtonBase)(object)button2, bool_0: true);
					num = ((int)num2 * -1161632594) ^ 0x5EEAEA7F;
					continue;
				case 71u:
					num = ((int)num2 * -446489954) ^ -1834879639;
					continue;
				case 70u:
					Form1.smethod_79((ContainerControl)(object)this, new SizeF(6f, 13f));
					Form1.smethod_80((ContainerControl)(object)this, (AutoScaleMode)1);
					num = ((int)num2 * -1902725902) ^ -739088112;
					continue;
				case 69u:
					num = (int)((num2 * 541367789) ^ 0x26A93C0);
					continue;
				case 68u:
					Form1.smethod_4((Control)(object)label2, new Point(0, 0));
					num = (int)(num2 * 1919328027) ^ -733398083;
					continue;
				case 67u:
					Form1.smethod_6((Control)(object)pictureBox1, new MouseEventHandler(PictureBox1_MouseDown));
					Form1.smethod_4((Control)(object)button2, new Point(391, 275));
					num = ((int)num2 * -696473431) ^ 0x56BB82FE;
					continue;
				case 66u:
					Form1.smethod_91((Control)(object)this, bool_0: false);
					Form1.smethod_92((Control)(object)this);
					num = ((int)num2 * -894842779) ^ 0x2926D36C;
					continue;
				case 65u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)button1);
					num = (int)((num2 * 552195989) ^ 0x4985A057);
					continue;
				case 64u:
					Form1.smethod_78((Control)(object)label1, (RightToLeft)0);
					num = (int)(num2 * 938859613) ^ -1650272173;
					continue;
				case 63u:
					Form1.smethod_4((Control)(object)label1, new Point(486, 0));
					num = ((int)num2 * -1770899656) ^ -2064332407;
					continue;
				case 62u:
					num = ((int)num2 * -1026699095) ^ 0x22A99FDD;
					continue;
				case 61u:
					num = ((int)num2 * -1306299947) ^ 0x491A3881;
					continue;
				case 60u:
					num = (int)((num2 * 143936240) ^ 0x1D4E87B9);
					continue;
				case 59u:
					Form1.smethod_4((Control)(object)button1, new Point(12, 275));
					num = (int)(num2 * 1017299755) ^ -236243427;
					continue;
				case 58u:
					Form1.smethod_75((Control)(object)label2, (DockStyle)3);
					num = (int)(num2 * 617821894) ^ -2139700603;
					continue;
				case 57u:
					Form1.smethod_83((Form)(object)this, (FormBorderStyle)1);
					num = ((int)num2 * -65647250) ^ 0x305F3852;
					continue;
				case 56u:
					num = ((int)num2 * -1687487539) ^ 0x4F750525;
					continue;
				case 55u:
					pictureBox1 = Form1.smethod_2();
					num = (int)(num2 * 1555771465) ^ -80198536;
					continue;
				case 54u:
					Form1.smethod_65((Control)(object)button1, bool_0: false);
					Form1.smethod_32((Control)(object)button1, "Меню");
					num = ((int)num2 * -1195287528) ^ 0x50E8601A;
					continue;
				case 53u:
					Form1.smethod_3((Control)(object)label2, new Size(0, 16));
					num = ((int)num2 * -785201788) ^ -2055458606;
					continue;
				case 52u:
					Form1.smethod_64((Control)(object)panel1, 7);
					num = ((int)num2 * -840223347) ^ 0x7614EFCA;
					continue;
				case 51u:
					num = (int)((num2 * 1968678359) ^ 0x75678DF3);
					continue;
				case 50u:
					Form1.smethod_75((Control)(object)label1, (DockStyle)4);
					Form1.smethod_77((Control)(object)label1, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = ((int)num2 * -290025417) ^ -61844132;
					continue;
				case 49u:
					Form1.smethod_70(ComMember, object_);
					Form1.smethod_71((TextBoxBase)(object)richTextBox1, bool_0: true);
					Form1.smethod_3((Control)(object)richTextBox1, new Size(272, 35));
					num = (int)(num2 * 1506989050) ^ -1868927380;
					continue;
				case 48u:
					Form1.smethod_5((Control)(object)this, Color.White);
					num = ((int)num2 * -357686728) ^ 0x42759030;
					continue;
				case 47u:
					num = ((int)num2 * -1804305286) ^ 0x5732BA77;
					continue;
				case 46u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = 1495188328;
						num5 = 1495188328;
					}
					else
					{
						num4 = 1924901247;
						num5 = 1924901247;
					}
					num = num4 ^ ((int)num2 * -1114115277);
					continue;
				}
				case 45u:
					num = (int)(num2 * 2072949148) ^ -256431512;
					continue;
				case 44u:
					num = (int)(num2 * 1807718002) ^ -1450808967;
					continue;
				case 43u:
					object_ = new object[3]
					{
						Player.MembershipCondition(0),
						Player.MembershipCondition(1),
						"Cytotechnologist"
					};
					num = ((int)num2 * -1237911886) ^ -1306478558;
					continue;
				case 42u:
					Form1.smethod_61((Control)(object)label2, "label2");
					num = ((int)num2 * -1408760251) ^ -492305544;
					continue;
				case 41u:
					richTextBox1 = Form1.smethod_54();
					panel1 = Form1.smethod_55();
					num = (int)(num2 * 2088156183) ^ -804977450;
					continue;
				case 40u:
					Form1.smethod_32((Control)(object)richTextBox1, "");
					num = ((int)num2 * -995771206) ^ -1418658927;
					continue;
				case 39u:
					num = (int)((num2 * 1860326559) ^ 0x554A3DC2);
					continue;
				case 38u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)panel1);
					num = ((int)num2 * -1129501371) ^ 0x6E98AFED;
					continue;
				case 37u:
					CharArray(array, string.Empty);
					num = ((int)num2 * -1317378379) ^ -1192511905;
					continue;
				case 36u:
					Form1.smethod_77((Control)(object)label5, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = (int)((num2 * 762958739) ^ 0x7C14FC51);
					continue;
				case 35u:
					num = (int)(num2 * 896455291) ^ -1090087524;
					continue;
				case 34u:
					Form1.smethod_32((Control)(object)this, "Quarto");
					num = ((int)num2 * -1180229082) ^ 0x2E47D426;
					continue;
				case 33u:
					num = ((int)num2 * -560050914) ^ 0x4FB6A077;
					continue;
				case 32u:
					num = ((int)num2 * -108592601) ^ -258191103;
					continue;
				case 31u:
					Form1.smethod_3((Control)(object)button2, new Size(83, 35));
					num = (int)(num2 * 234455600) ^ -455025325;
					continue;
				case 30u:
					num = (int)(num2 * 1674624720) ^ -518017892;
					continue;
				case 29u:
					num = ((int)num2 * -1659467471) ^ 0x4F135DCF;
					continue;
				case 28u:
					Form1.smethod_63(pictureBox1, bool_0: false);
					num = (int)((num2 * 1368505731) ^ 0x3AA3DA06);
					continue;
				case 27u:
					Form1.smethod_4((Control)(object)pictureBox1, new Point(120, 22));
					num = ((int)num2 * -1098918987) ^ 0x161430AC;
					continue;
				case 26u:
					num = (int)((num2 * 664655931) ^ 0x7505ACFA);
					continue;
				case 25u:
					Form1.smethod_64((Control)(object)button1, 5);
					num = (int)((num2 * 1987010073) ^ 0x5251D2E4);
					continue;
				case 24u:
					Form1.smethod_5((Control)(object)pictureBox1, Color.FromArgb(64, 32, 0));
					Form1.smethod_60(pictureBox1, (BorderStyle)2);
					num = (int)(num2 * 80115437) ^ -248707672;
					continue;
				case 23u:
					num = ((int)num2 * -1800479638) ^ 0x33C23410;
					continue;
				case 22u:
					button2 = Form1.smethod_53();
					button1 = Form1.smethod_53();
					num = (int)(num2 * 1197186944) ^ -1024687960;
					continue;
				case 21u:
					num3++;
					num = ((int)num2 * -1626696584) ^ 0x56185063;
					continue;
				case 20u:
					Form1.smethod_61((Control)(object)pictureBox1, "pictureBox1");
					num = (int)((num2 * 1849778349) ^ 0x324B1E15);
					continue;
				case 18u:
					Form1.smethod_67((Control)(object)button1, (EventHandler)Button1_Click);
					Form1.smethod_5((Control)(object)richTextBox1, Color.White);
					num = ((int)num2 * -86772612) ^ -900682443;
					continue;
				case 17u:
					Form1.smethod_89((Control)(object)this, (EventHandler)Form1_LocationChanged);
					num = ((int)num2 * -1210350767) ^ -266076171;
					continue;
				case 16u:
					Form1.smethod_4((Control)(object)panel1, new Point(0, 24));
					num = (int)(num2 * 1284991098) ^ -352665589;
					continue;
				case 15u:
					Form1.smethod_61((Control)(object)label5, "label5");
					num = ((int)num2 * -169795999) ^ -295318766;
					continue;
				case 14u:
					Form1.smethod_64((Control)(object)richTextBox1, 6);
					Form1.smethod_65((Control)(object)richTextBox1, bool_0: false);
					num = (int)(num2 * 1280952129) ^ -181282955;
					continue;
				case 13u:
					Form1.smethod_64((Control)(object)label5, 12);
					Form1.smethod_74((Control)(object)label6, bool_0: true);
					num = (int)((num2 * 2038625886) ^ 0xCF60B62);
					continue;
				case 12u:
					num = (int)(num2 * 1732591813) ^ -989165231;
					continue;
				case 10u:
					array = new byte[22528];
					num3 = 0;
					num = (int)((num2 * 134689466) ^ 0x4C30D5AD);
					continue;
				case 9u:
					Form1.smethod_61((Control)(object)button1, "button1");
					num = ((int)num2 * -1387994835) ^ -1153412746;
					continue;
				case 8u:
					Form1.smethod_32((Control)(object)button2, "Подтвердить");
					num = ((int)num2 * -1333721334) ^ 0xE0EB89F;
					continue;
				case 7u:
					num = (int)(num2 * 1132096126) ^ -765753276;
					continue;
				case 6u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label5);
					num = ((int)num2 * -1902128292) ^ -1965829890;
					continue;
				case 5u:
					num = ((int)num2 * -81477247) ^ -1947373467;
					continue;
				case 4u:
					num = (int)(num2 * 1859002144) ^ -1290720855;
					continue;
				case 3u:
					Form1.smethod_72(timer1, 1000);
					num = (int)(num2 * 587559391) ^ -1066897379;
					continue;
				case 2u:
					Form1.smethod_74((Control)(object)label5, bool_0: true);
					num = (int)((num2 * 1683860812) ^ 0x316520C0);
					continue;
				case 1u:
					label2 = Form1.smethod_57();
					label5 = Form1.smethod_57();
					num = (int)(num2 * 1318782457) ^ -469249344;
					continue;
				case 0u:
					timer1 = Form1.smethod_56(components);
					label1 = Form1.smethod_57();
					num = ((int)num2 * -1260625483) ^ -1128474732;
					continue;
				default:
					return;
				case 11u:
					break;
				case 19u:
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
			int num = -2098509636;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xFA1E54DBu) % 5u)
				{
				case 4u:
					PerformTable(q);
					num = (int)((num2 * 1562565885) ^ 0x32B5D31B);
					continue;
				case 1u:
					q = ContextAdd(Level);
					num = (int)(num2 * 1614888596) ^ -2122845907;
					continue;
				case 0u:
					num = ((int)num2 * -814225729) ^ 0x4DBED652;
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
			int num = -1082103437;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD1B44E32u) % 4u)
				{
				case 1u:
					result = Form1.smethod_94(Form1.smethod_93(), Position);
					num = ((int)num2 * -12707461) ^ -598550511;
					continue;
				case 0u:
					num = (int)((num2 * 1542077990) ^ 0x3A2BC855);
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
