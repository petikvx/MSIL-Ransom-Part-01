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
			int num = -570997025;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x89C25B77u) % 3u)
				{
				case 1u:
					goto IL_0033;
				default:
					return;
				case 2u:
					break;
				case 0u:
					return;
				}
				break;
				IL_0033:
				num = ((int)num2 * -1328723956) ^ -1654169867;
			}
		}
	}

	private void Form1_Shown(object sender, EventArgs e)
	{
		Form1.smethod_14(menu);
		while (true)
		{
			int num = 1037347669;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1D2511A1u) % 3u)
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
				num = (int)(num2 * 182389559) ^ -1545090165;
			}
		}
	}

	public void Button1_Click(object sender, EventArgs e)
	{
		bool flag = default(bool);
		while (true)
		{
			int num = 769407541;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB8CF639u) % 7u)
				{
				case 6u:
					num = (int)(num2 * 68570715) ^ -492327810;
					continue;
				case 4u:
					Form1.smethod_15(timer1);
					num = (int)(num2 * 751639696) ^ -1414516522;
					continue;
				case 3u:
				{
					Form control_ = menu;
					Form1.smethod_17((Control)(object)control_, Form1.smethod_16((Control)(object)control_) + 5);
					num = 1679297921;
					continue;
				}
				case 2u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = -386434657;
						num4 = -386434657;
					}
					else
					{
						num3 = -1466891855;
						num4 = -1466891855;
					}
					num = num3 ^ ((int)num2 * -1356095797);
					continue;
				}
				case 1u:
					flag = Form1.smethod_16((Control)(object)menu) < 296;
					num = 1763528358;
					continue;
				case 0u:
					break;
				default:
					Form1.smethod_14(menu);
					return;
				}
				break;
			}
		}
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		int num5 = default(int);
		int num3 = default(int);
		while (true)
		{
			int num = -1372334735;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE386005Au) % 19u)
				{
				case 18u:
					storage[num5, num3] = new Figurine(num5 < 2, num3 % 2 == 0, num3 < 2, num5 % 2 == 1);
					Form1.smethod_5((Control)(object)borderBox[num5, num3], Color.White);
					Form1.smethod_7((Control)(object)pictureBox[num5, num3], bool_0: false);
					num = -104939097;
					continue;
				case 17u:
					num5 = 0;
					num = ((int)num2 * -1000438175) ^ -1188175005;
					continue;
				case 15u:
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: false);
					num = ((int)num2 * -936065379) ^ 0x73F380DC;
					continue;
				case 14u:
					num5++;
					num = ((int)num2 * -2013192278) ^ -62977727;
					continue;
				case 13u:
					num3++;
					num = (int)((num2 * 672670857) ^ 0x36FB9D2A);
					continue;
				case 12u:
					num = ((int)num2 * -740444769) ^ 0x2865B3C3;
					continue;
				case 11u:
					num = ((int)num2 * -1484591248) ^ 0x4DA1DB86;
					continue;
				case 9u:
				{
					int num6;
					if (num5 < 4)
					{
						num = -2116348049;
						num6 = -2116348049;
					}
					else
					{
						num = -1329145644;
						num6 = -1329145644;
					}
					continue;
				}
				case 8u:
					num = (int)((num2 * 990753941) ^ 0x6B5BAEF6);
					continue;
				case 7u:
					storage = new Figurine[4, 4];
					num = (int)(num2 * 1074247129) ^ -1762514383;
					continue;
				case 6u:
				{
					int num4;
					if (num3 < 4)
					{
						num = -961661659;
						num4 = -961661659;
					}
					else
					{
						num = -1375235376;
						num4 = -1375235376;
					}
					continue;
				}
				case 5u:
					num3 = 0;
					num = -1300680023;
					continue;
				case 4u:
					Paint_Board();
					num = ((int)num2 * -2133962378) ^ -116615122;
					continue;
				case 3u:
					board = new Figurine[4, 4];
					num = (int)((num2 * 1421433261) ^ 0x58B67620);
					continue;
				case 2u:
					Paint_Storage();
					num = ((int)num2 * -1527794290) ^ 0xFB4AD6E;
					continue;
				case 1u:
					num = (int)((num2 * 1849674080) ^ 0x1EA60DCC);
					continue;
				case 0u:
					num = (int)((num2 * 1266340483) ^ 0x3CCF4663);
					continue;
				case 10u:
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
		int num7 = default(int);
		int num8 = default(int);
		float num11 = default(float);
		float num17 = default(float);
		float num12 = default(float);
		Brush brush_ = default(Brush);
		float num6 = default(float);
		float num5 = default(float);
		Graphics graphics_ = default(Graphics);
		bool square = default(bool);
		bool flag = default(bool);
		while (true)
		{
			int num = 278502945;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x11E7E03Du) % 38u)
				{
				case 37u:
				{
					int num15;
					if (!board[num7, num8].Big)
					{
						num = 542580016;
						num15 = 542580016;
					}
					else
					{
						num = 142988160;
						num15 = 142988160;
					}
					continue;
				}
				case 36u:
					num11 = 1f - num17 * 0.4f / (float)Form1.smethod_27(2.0);
					num12 = (float)size * (num11 / 2f);
					num = 1309610820;
					continue;
				case 35u:
					num12 = (float)size * (num11 / 2f);
					num = (int)((num2 * 2120274910) ^ 0x612EBDE6);
					continue;
				case 34u:
					brush_ = Form1.smethod_25();
					num = ((int)num2 * -825728367) ^ 0x566FACFA;
					continue;
				case 33u:
				{
					int num19;
					int num20;
					if (board[num7, num8].Dark)
					{
						num19 = 287635757;
						num20 = 287635757;
					}
					else
					{
						num19 = 2041797587;
						num20 = 2041797587;
					}
					num = num19 ^ ((int)num2 * -1999977528);
					continue;
				}
				case 32u:
					Form1.smethod_20(pictureBox1, (Image)(object)Form1.smethod_19(Form1.smethod_18((Control)(object)pictureBox1), Form1.smethod_16((Control)(object)pictureBox1)));
					num = ((int)num2 * -1121553687) ^ 0x276CDD54;
					continue;
				case 31u:
					num8++;
					num = (int)(num2 * 759353576) ^ -839466691;
					continue;
				case 30u:
					num8 = 0;
					num = 1878785327;
					continue;
				case 29u:
				{
					num6 = num5 * 0.4f / (float)Form1.smethod_27(2.0);
					int num9;
					int num10;
					if (!board[num7, num8].Point)
					{
						num9 = 1477485730;
						num10 = 1477485730;
					}
					else
					{
						num9 = 505448553;
						num10 = 505448553;
					}
					num = num9 ^ ((int)num2 * -411776849);
					continue;
				}
				case 28u:
					num = ((int)num2 * -1821476295) ^ 0x36944A07;
					continue;
				case 27u:
					num11 = 1f - num17 * 0.9f / (float)Form1.smethod_27(2.0);
					num5 = (float)size * num17;
					num = 343863022;
					continue;
				case 25u:
					Form1.smethod_24(graphics_, (Brush)(object)Form1.smethod_29(Color.FromArgb(180, Color.Peru)), num12 + (float)(num8 * size), num12 + (float)(num7 * size), num6, num6);
					num = ((int)num2 * -1902318427) ^ 0x24333EDF;
					continue;
				case 24u:
					Form1.smethod_30((Control)(object)pictureBox1);
					num = (int)(num2 * 1124917816) ^ -1893053659;
					continue;
				case 23u:
					num = (int)((num2 * 1275710729) ^ 0x2EE6C500);
					continue;
				case 22u:
					square = board[num7, num8].Square;
					num = (int)(num2 * 312100030) ^ -212187774;
					continue;
				case 21u:
					num17 = 1f;
					num = ((int)num2 * -1116394051) ^ 0x67CB5B39;
					continue;
				case 20u:
					num = ((int)num2 * -2127617609) ^ -421944742;
					continue;
				case 19u:
				{
					int num18;
					if (num7 >= 4)
					{
						num = 1364839081;
						num18 = 1364839081;
					}
					else
					{
						num = 1781153125;
						num18 = 1781153125;
					}
					continue;
				}
				case 18u:
					num = 785621246;
					continue;
				case 17u:
					num17 = 0.7f;
					num = 1228026032;
					continue;
				case 16u:
				{
					int num16;
					if (num8 < 4)
					{
						num = 2065279573;
						num16 = 2065279573;
					}
					else
					{
						num = 414980411;
						num16 = 414980411;
					}
					continue;
				}
				case 15u:
					num7 = 0;
					num = (int)((num2 * 52187138) ^ 0xB676F05);
					continue;
				case 13u:
					flag = board[num7, num8] != null;
					num = (int)(num2 * 99103383) ^ -80724657;
					continue;
				case 12u:
					brush_ = Form1.smethod_26();
					num = 1250857730;
					continue;
				case 11u:
					Form1.smethod_28(graphics_, brush_, num12 + (float)(num8 * size), num12 + (float)(num7 * size), num6, num6);
					num = (int)(num2 * 1498979146) ^ -1894818053;
					continue;
				case 10u:
					num7++;
					num = (int)((num2 * 871835881) ^ 0x29C57BD6);
					continue;
				case 9u:
					num = 1367671054;
					continue;
				case 8u:
					num = 1408790877;
					continue;
				case 7u:
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox1));
					num = (int)(num2 * 804917793) ^ -1979399425;
					continue;
				case 6u:
					num = (int)(num2 * 2080886909) ^ -1370067323;
					continue;
				case 5u:
				{
					int num13;
					int num14;
					if (flag)
					{
						num13 = -676730078;
						num14 = -676730078;
					}
					else
					{
						num13 = -664595148;
						num14 = -664595148;
					}
					num = num13 ^ (int)(num2 * 148316654);
					continue;
				}
				case 4u:
					Form1.smethod_24(graphics_, Form1.smethod_23(), ((float)num8 + 0.05f) * (float)size, ((float)num7 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					num = (int)((num2 * 574412648) ^ 0x160859D);
					continue;
				case 3u:
					num6 = num5 * 0.9f / (float)Form1.smethod_27(2.0);
					num = (int)(num2 * 484849831) ^ -1387315984;
					continue;
				case 2u:
					Form1.smethod_24(graphics_, brush_, num12 + (float)(num8 * size), num12 + (float)(num7 * size), num6, num6);
					num = 2004328469;
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (!square)
					{
						num3 = -411023836;
						num4 = -411023836;
					}
					else
					{
						num3 = -418220605;
						num4 = -418220605;
					}
					num = num3 ^ (int)(num2 * 1708845047);
					continue;
				}
				case 0u:
					num = (int)(num2 * 2114075581) ^ -12244694;
					continue;
				default:
					return;
				case 14u:
					break;
				case 26u:
					return;
				}
				break;
			}
		}
	}

	private void Paint_Storage()
	{
		bool flag2 = default(bool);
		int num7 = default(int);
		int num13 = default(int);
		bool flag4 = default(bool);
		bool flag = default(bool);
		Brush brush_ = default(Brush);
		float num8 = default(float);
		Graphics graphics_ = default(Graphics);
		float num3 = default(float);
		float num4 = default(float);
		bool flag3 = default(bool);
		float num10 = default(float);
		bool big = default(bool);
		while (true)
		{
			int num = -905876114;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xCF8BD1CCu) % 38u)
				{
				case 36u:
					num = ((int)num2 * -1776203934) ^ 0x1F7A7F83;
					continue;
				case 35u:
					flag2 = num7 < 4;
					num = -2128283392;
					continue;
				case 34u:
					num7 = 0;
					num = -483897715;
					continue;
				case 33u:
				{
					int num14;
					int num15;
					if (storage[num13, num7].Dark)
					{
						num14 = 632445054;
						num15 = 632445054;
					}
					else
					{
						num14 = 249321152;
						num15 = 249321152;
					}
					num = num14 ^ ((int)num2 * -1279998616);
					continue;
				}
				case 32u:
				{
					int num22;
					int num23;
					if (!flag4)
					{
						num22 = 1952407632;
						num23 = 1952407632;
					}
					else
					{
						num22 = 1585427382;
						num23 = 1585427382;
					}
					num = num22 ^ (int)(num2 * 1452663596);
					continue;
				}
				case 31u:
					num7++;
					num = -483897715;
					continue;
				case 30u:
					num = ((int)num2 * -1168749587) ^ 0x13186F51;
					continue;
				case 29u:
					flag4 = num13 < 4;
					num = -553953866;
					continue;
				case 28u:
				{
					int num16;
					int num17;
					if (!flag2)
					{
						num16 = 831012747;
						num17 = 831012747;
					}
					else
					{
						num16 = 579958208;
						num17 = 579958208;
					}
					num = num16 ^ ((int)num2 * -1272542395);
					continue;
				}
				case 27u:
					flag = num7 < 2;
					num = (int)(num2 * 1828615669) ^ -1384208832;
					continue;
				case 26u:
				{
					int num20;
					int num21;
					if (!storage[num13, num7].Point)
					{
						num20 = -946893388;
						num21 = -946893388;
					}
					else
					{
						num20 = -1256442024;
						num21 = -1256442024;
					}
					num = num20 ^ ((int)num2 * -751958820);
					continue;
				}
				case 25u:
					num13++;
					num = ((int)num2 * -277402111) ^ 0x6CA9F790;
					continue;
				case 24u:
					brush_ = Form1.smethod_25();
					num = (int)(num2 * 1204490440) ^ -1013477770;
					continue;
				case 23u:
					num8 = 0.7f;
					num = -1268613733;
					continue;
				case 22u:
					Form1.smethod_28(graphics_, brush_, num3, num3, num4, num4);
					num = (int)((num2 * 1659418921) ^ 0x532A6723);
					continue;
				case 21u:
					num = (int)(num2 * 70888859) ^ -863476918;
					continue;
				case 20u:
					Form1.smethod_24(graphics_, (Brush)(object)Form1.smethod_29(Color.FromArgb(180, Color.Peru)), num3, num3, num4, num4);
					num = ((int)num2 * -936578877) ^ -1970734473;
					continue;
				case 19u:
					num = ((int)num2 * -1695392818) ^ -1015136429;
					continue;
				case 18u:
				{
					int num18;
					int num19;
					if (!flag3)
					{
						num18 = -1180724851;
						num19 = -1180724851;
					}
					else
					{
						num18 = -733707009;
						num19 = -733707009;
					}
					num = num18 ^ (int)(num2 * 992666649);
					continue;
				}
				case 17u:
					Form1.smethod_20(pictureBox[num13, num7], (Image)(object)Form1.smethod_19(Form1.smethod_18((Control)(object)pictureBox[num13, num7]), Form1.smethod_16((Control)(object)pictureBox[num13, num7])));
					num = (int)(num2 * 61952745) ^ -616005104;
					continue;
				case 16u:
					flag3 = storage[num13, num7] != null;
					num = -400599796;
					continue;
				case 15u:
					num = (int)(num2 * 1073990332) ^ -778742176;
					continue;
				case 14u:
					num13 = 0;
					num = ((int)num2 * -427478324) ^ -105135053;
					continue;
				case 13u:
				{
					float num9 = 1f - num8 * 0.9f / (float)Form1.smethod_27(2.0);
					num10 = (float)size * num8;
					num3 = (float)size * (num9 / 2f) - 4f;
					num4 = num10 * 0.9f / (float)Form1.smethod_27(2.0);
					num = -1268298659;
					continue;
				}
				case 12u:
					num = (int)((num2 * 1820446161) ^ 0x23E423D6);
					continue;
				case 11u:
					num8 = 1f;
					num = ((int)num2 * -395008706) ^ 0x7599C666;
					continue;
				case 10u:
					Form1.smethod_30((Control)(object)pictureBox[num13, num7]);
					num = -1215010219;
					continue;
				case 9u:
					big = storage[num13, num7].Big;
					num = -1373710390;
					continue;
				case 7u:
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox[num13, num7]));
					num = (int)(num2 * 226374010) ^ -652237295;
					continue;
				case 6u:
					brush_ = Form1.smethod_26();
					num = -2030639757;
					continue;
				case 5u:
				{
					int num11;
					int num12;
					if (!flag)
					{
						num11 = -587641105;
						num12 = -587641105;
					}
					else
					{
						num11 = -365024887;
						num12 = -365024887;
					}
					num = num11 ^ (int)(num2 * 742759431);
					continue;
				}
				case 4u:
				{
					float num9 = 1f - num8 * 0.4f / (float)Form1.smethod_27(2.0);
					num3 = (float)size * (num9 / 2f) - 4f;
					num4 = num10 * 0.4f / (float)Form1.smethod_27(2.0);
					num = -2076862440;
					continue;
				}
				case 3u:
					num = (int)((num2 * 1667382978) ^ 0x7147CA6E);
					continue;
				case 2u:
				{
					int num5;
					int num6;
					if (big)
					{
						num5 = 589367371;
						num6 = 589367371;
					}
					else
					{
						num5 = 2141775689;
						num6 = 2141775689;
					}
					num = num5 ^ (int)(num2 * 676495783);
					continue;
				}
				case 1u:
					num = (int)(num2 * 1466310579) ^ -1632830370;
					continue;
				case 0u:
					Form1.smethod_24(graphics_, brush_, num3, num3, num4, num4);
					num = -988041258;
					continue;
				default:
					return;
				case 37u:
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
		int num4 = default(int);
		bool flag2 = default(bool);
		bool flag = default(bool);
		int num7 = default(int);
		int num8 = default(int);
		bool flag3 = default(bool);
		int num3 = default(int);
		while (true)
		{
			int num = -411584886;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x93C2A057u) % 26u)
				{
				case 25u:
					Form1_Load(this, Form1.smethod_31());
					num = (int)(num2 * 1920625442) ^ -1980260008;
					continue;
				case 24u:
					num4++;
					num = ((int)num2 * -2010404342) ^ -1613604834;
					continue;
				case 23u:
				{
					int num11;
					int num12;
					if (flag2)
					{
						num11 = -1378826389;
						num12 = -1378826389;
					}
					else
					{
						num11 = -1921294977;
						num12 = -1921294977;
					}
					num = num11 ^ ((int)num2 * -784222750);
					continue;
				}
				case 22u:
					time = new DateTime(0L, DateTimeKind.Unspecified);
					num = (int)(num2 * 892242082) ^ -2022664886;
					continue;
				case 21u:
					flag = num4 < 4;
					num = -79206328;
					continue;
				case 20u:
					num7 = Form1.smethod_33(rnd, 4);
					num8 = Form1.smethod_33(rnd, 4);
					num = -2134097685;
					continue;
				case 19u:
					num = (int)(num2 * 335088115) ^ -547987743;
					continue;
				case 18u:
					num4 = 0;
					num = (int)(num2 * 1655052829) ^ -2087454825;
					continue;
				case 17u:
				{
					int num9;
					int num10;
					if (!flag3)
					{
						num9 = 976347687;
						num10 = 976347687;
					}
					else
					{
						num9 = 1921992551;
						num10 = 1921992551;
					}
					num = num9 ^ (int)(num2 * 2136877154);
					continue;
				}
				case 16u:
					Form1.smethod_5((Control)(object)borderBox[num7, num8], Color.Blue);
					num = ((int)num2 * -1535232786) ^ 0x14B69B69;
					continue;
				case 15u:
					Form1.smethod_32((Control)(object)label2, Form1.smethod_34("Ход: ", step.ToString()));
					num = -1711855675;
					continue;
				case 14u:
					num = (int)(num2 * 968824520) ^ -1197197862;
					continue;
				case 12u:
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: true);
					num = ((int)num2 * -2033986254) ^ 0x2F9D7685;
					continue;
				case 11u:
					flag3 = turn;
					num = ((int)num2 * -168746061) ^ -393605449;
					continue;
				case 10u:
					flag2 = num3 < 4;
					num = -1380518710;
					continue;
				case 8u:
					num = ((int)num2 * -1845165035) ^ -932442298;
					continue;
				case 7u:
				{
					int num5;
					int num6;
					if (flag)
					{
						num5 = -462920018;
						num6 = -462920018;
					}
					else
					{
						num5 = -50110735;
						num6 = -50110735;
					}
					num = num5 ^ (int)(num2 * 1176775380);
					continue;
				}
				case 6u:
					Form1.smethod_7((Control)(object)pictureBox[num4, num3], bool_0: true);
					num = -1072073072;
					continue;
				case 5u:
					num3++;
					num = (int)((num2 * 515965497) ^ 0x26B9DE66);
					continue;
				case 4u:
					Form1.smethod_32((Control)(object)richTextBox1, "Противник выбрал фигуру. Выберете поле на доске для установки этой фигуры.");
					step = 1;
					num = ((int)num2 * -1709463781) ^ -1902121220;
					continue;
				case 3u:
					num3 = 0;
					num = -2028028375;
					continue;
				case 2u:
					step = 0;
					num = ((int)num2 * -72632691) ^ 0x25683FAC;
					continue;
				case 1u:
					Form1.smethod_35(timer1, bool_0: true);
					Form1.smethod_36(timer1);
					num = (int)(num2 * 1043961757) ^ -802072478;
					continue;
				case 0u:
					Form1.smethod_32((Control)(object)richTextBox1, "Ваш ход. Выберете фигуру, которой будет играть противник.");
					num = (int)(num2 * 938562609) ^ -289890093;
					continue;
				default:
					return;
				case 13u:
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
		while (true)
		{
			int num = -871514948;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xAD037344u) % 3u)
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
				num = ((int)num2 * -1388862081) ^ 0x3FE6ECC1;
			}
		}
	}

	private void PictureBoxIJ_MouseDown(object sender, MouseEventArgs e)
	{
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Expected O, but got Unknown
		int num5 = default(int);
		int num11 = default(int);
		int num10 = default(int);
		int num7 = default(int);
		Point point = default(Point);
		bool flag2 = default(bool);
		bool flag = default(bool);
		while (true)
		{
			int num = 148607439;
			while (true)
			{
				uint num2;
				int num6;
				switch ((num2 = (uint)num ^ 0x4A0FFCD3u) % 24u)
				{
				case 23u:
					num = (int)((num2 * 2145358560) ^ 0x15265EE0);
					continue;
				case 22u:
					num5++;
					num = ((int)num2 * -1375482855) ^ -1381837880;
					continue;
				case 21u:
					if (storage[num11, num10] != null)
					{
						num = 240565761;
						continue;
					}
					goto IL_005a;
				case 20u:
					num10 -= 4;
					num = ((int)num2 * -1650070979) ^ 0x967954A;
					continue;
				case 19u:
					num = (int)((num2 * 15901778) ^ 0x68B5C788);
					continue;
				case 17u:
					num5 = 0;
					num = (int)((num2 * 980297424) ^ 0x342F6BA0);
					continue;
				case 16u:
				{
					int num12;
					if (num7 >= 4)
					{
						num = 681582389;
						num12 = 681582389;
					}
					else
					{
						num = 253815962;
						num12 = 253815962;
					}
					continue;
				}
				case 15u:
					num11 = point.Y / size;
					num = ((int)num2 * -959693785) ^ 0x1068E786;
					continue;
				case 14u:
					num = (int)((num2 * 563460099) ^ 0x41402A86);
					continue;
				case 13u:
					num7++;
					num = ((int)num2 * -509565473) ^ 0x397A5E48;
					continue;
				case 12u:
					point = Form1.smethod_37((Control)((sender is PictureBox) ? sender : null));
					num10 = point.X / size;
					flag2 = num10 > 1;
					num = (int)(num2 * 1952521152) ^ -1250156824;
					continue;
				case 10u:
					if (Form1.smethod_40((Bitmap)Form1.smethod_21(pictureBox[num11, num10]), Form1.smethod_38(e), Form1.smethod_39(e)) != Color.FromArgb(0, 0, 0, 0))
					{
						num = 222142570;
						num6 = 222142570;
						continue;
					}
					goto IL_005a;
				case 9u:
					num = ((int)num2 * -1284005253) ^ -1204488976;
					continue;
				case 8u:
					Form1.smethod_32((Control)(object)richTextBox1, "Именно эта фигура? Если да - нажмите \"Подтвердить\".");
					num = ((int)num2 * -938699687) ^ -1366905691;
					continue;
				case 7u:
					Form1.smethod_5((Control)(object)borderBox[num11, num10], Color.Red);
					num = (int)((num2 * 630422723) ^ 0xD972054);
					continue;
				case 6u:
					num7 = 0;
					num = 505384770;
					continue;
				case 5u:
					flag = num5 < 4;
					num = 1938039907;
					continue;
				case 4u:
					point = Form1.smethod_37((Control)((sender is PictureBox) ? sender : null));
					num = ((int)num2 * -631035401) ^ -126062192;
					continue;
				case 3u:
				{
					int num8;
					int num9;
					if (!flag2)
					{
						num8 = -2093278504;
						num9 = -2093278504;
					}
					else
					{
						num8 = -1630729967;
						num9 = -1630729967;
					}
					num = num8 ^ (int)(num2 * 1456528386);
					continue;
				}
				case 2u:
					Form1.smethod_7((Control)(object)button2, bool_0: true);
					num = ((int)num2 * -1539553591) ^ -95918087;
					continue;
				case 1u:
					Form1.smethod_5((Control)(object)borderBox[num5, num7], Color.White);
					num = 1057570462;
					continue;
				case 0u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = 509934093;
						num4 = 509934093;
					}
					else
					{
						num3 = 1556178604;
						num4 = 1556178604;
					}
					num = num3 ^ ((int)num2 * -835375378);
					continue;
				}
				default:
					return;
				case 18u:
					break;
				case 11u:
					return;
					IL_005a:
					num = 4767936;
					num6 = 4767936;
					continue;
				}
				break;
			}
		}
	}

	private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
	{
		//IL_0213: Unknown result type (might be due to invalid IL or missing references)
		//IL_0229: Expected O, but got Unknown
		int num = Form1.smethod_38(e) / size;
		int num2 = Form1.smethod_39(e) / size;
		Graphics graphics_ = default(Graphics);
		int num7 = default(int);
		bool flag2 = default(bool);
		bool flag = default(bool);
		int num5 = default(int);
		while (true)
		{
			int num3 = -1003925908;
			while (true)
			{
				uint num4;
				int num8;
				switch ((num4 = (uint)num3 ^ 0xD4CC6600u) % 23u)
				{
				case 22u:
					Form1.smethod_32((Control)(object)richTextBox1, "Уверены? Для выполнения данного хода нажмите \"Подтвердить\".");
					num3 = (int)(num4 * 859317025) ^ -1513491370;
					continue;
				case 21u:
					Form1.smethod_45(graphics_);
					num3 = (int)((num4 * 501441115) ^ 0x3FFF8CC6);
					continue;
				case 20u:
				{
					int num13;
					if (num7 >= 4)
					{
						num3 = -1045414060;
						num13 = -1045414060;
					}
					else
					{
						num3 = -98632775;
						num13 = -98632775;
					}
					continue;
				}
				case 19u:
					num3 = (int)((num4 * 1083847206) ^ 0x114C0055);
					continue;
				case 18u:
				{
					int num9;
					int num10;
					if (!flag2)
					{
						num9 = 1735407844;
						num10 = 1735407844;
					}
					else
					{
						num9 = 1561899178;
						num10 = 1561899178;
					}
					num3 = num9 ^ (int)(num4 * 551121406);
					continue;
				}
				case 17u:
					Form1.smethod_30((Control)(object)pictureBox1);
					num3 = (int)(num4 * 56435607) ^ -1970695571;
					continue;
				case 16u:
					flag = Form1.smethod_41((Control)(object)borderBox[num5, num7]) == Color.Blue;
					num3 = -818714009;
					continue;
				case 15u:
					num7 = 0;
					num3 = -792759381;
					continue;
				case 14u:
					num5 = 0;
					num3 = (int)(num4 * 851392988) ^ -2128854943;
					continue;
				case 13u:
					Paint_Board();
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox1));
					num3 = ((int)num4 * -2079735383) ^ 0x63C66176;
					continue;
				case 12u:
				{
					int num11;
					int num12;
					if (flag)
					{
						num11 = 1764919769;
						num12 = 1764919769;
					}
					else
					{
						num11 = 421109630;
						num12 = 421109630;
					}
					num3 = num11 ^ (int)(num4 * 412713016);
					continue;
				}
				case 11u:
					num3 = (int)((num4 * 1425067185) ^ 0x2172B2F);
					continue;
				case 10u:
					num5++;
					num3 = ((int)num4 * -1058434404) ^ -1024871855;
					continue;
				case 9u:
					Form1.smethod_44(graphics_, Form1.smethod_21(pictureBox[num5, num7]), num * size + 4, num2 * size + 4, new Rectangle(0, 0, size, size), (GraphicsUnit)2);
					num3 = (int)((num4 * 678870324) ^ 0x4A05D287);
					continue;
				case 8u:
					num7++;
					num3 = -792759381;
					continue;
				case 7u:
					if (Form1.smethod_40((Bitmap)Form1.smethod_21(pictureBox1), Form1.smethod_38(e), Form1.smethod_39(e)) != Color.FromArgb(0, 0, 0, 0))
					{
						num3 = (int)(num4 * 466262227) ^ -1170832895;
						continue;
					}
					num8 = 0;
					goto IL_024d;
				case 6u:
					num3 = ((int)num4 * -1189809522) ^ 0x14C74DAC;
					continue;
				case 5u:
					Form1.smethod_7((Control)(object)button2, bool_0: true);
					num3 = (int)(num4 * 206963993) ^ -59669703;
					continue;
				case 4u:
					Form1.smethod_43(graphics_, Form1.smethod_42(Color.Red, 3f), ((float)num + 0.05f) * (float)size, ((float)num2 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					num3 = ((int)num4 * -1059468847) ^ -234487336;
					continue;
				case 1u:
					num8 = ((board[num2, num] == null) ? 1 : 0);
					goto IL_024d;
				case 0u:
				{
					int num6;
					if (num5 < 4)
					{
						num3 = -181173832;
						num6 = -181173832;
					}
					else
					{
						num3 = -1653596530;
						num6 = -1653596530;
					}
					continue;
				}
				default:
					return;
				case 3u:
					break;
				case 2u:
					return;
					IL_024d:
					flag2 = (byte)num8 != 0;
					num3 = -774768181;
					continue;
				}
				break;
			}
		}
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		//IL_102c: Unknown result type (might be due to invalid IL or missing references)
		//IL_105a: Expected O, but got Unknown
		Form1.smethod_7((Control)(object)button2, bool_0: false);
		int num24 = default(int);
		int num57 = default(int);
		bool flag4 = default(bool);
		bool flag10 = default(bool);
		int num30 = default(int);
		int num27 = default(int);
		int num38 = default(int);
		int num39 = default(int);
		int num20 = default(int);
		int num21 = default(int);
		bool flag9 = default(bool);
		int num14 = default(int);
		bool flag12 = default(bool);
		bool flag2 = default(bool);
		int num31 = default(int);
		int num5 = default(int);
		bool flag13 = default(bool);
		Graphics graphics_ = default(Graphics);
		int num6 = default(int);
		int num10 = default(int);
		Figurine[,] array3 = default(Figurine[,]);
		Figurine[,] array2 = default(Figurine[,]);
		int num17 = default(int);
		int num25 = default(int);
		int num32 = default(int);
		bool flag8 = default(bool);
		Figurine[,] array = default(Figurine[,]);
		int num18 = default(int);
		int num19 = default(int);
		int num9 = default(int);
		bool flag5 = default(bool);
		bool flag14 = default(bool);
		bool flag7 = default(bool);
		int num28 = default(int);
		bool flag11 = default(bool);
		bool flag = default(bool);
		bool flag3 = default(bool);
		bool flag6 = default(bool);
		int num29 = default(int);
		while (true)
		{
			int num = -2031097672;
			while (true)
			{
				uint num2;
				int num33;
				int num13;
				int num36;
				int num43;
				switch ((num2 = (uint)num ^ 0xA5E66AFEu) % 168u)
				{
				case 167u:
					Form1.smethod_7((Control)(object)pictureBox[num24, num57], bool_0: true);
					num57++;
					num = -1188417955;
					continue;
				case 166u:
					num = ((int)num2 * -7528423) ^ -1735255437;
					continue;
				case 165u:
					num = (int)(num2 * 664288075) ^ -781416810;
					continue;
				case 164u:
					step++;
					Form1.smethod_32((Control)(object)label2, Form1.smethod_34("Ход: ", step.ToString()));
					num = ((int)num2 * -483019431) ^ 0x798B78CF;
					continue;
				case 163u:
					flag4 = true;
					num = ((int)num2 * -1562130348) ^ -1569780092;
					continue;
				case 162u:
					num = ((int)num2 * -522780967) ^ 0x7D2ED1B7;
					continue;
				case 161u:
					num = (int)((num2 * 30742161) ^ 0x15895D0F);
					continue;
				case 160u:
				{
					int num55;
					int num56;
					if (flag10)
					{
						num55 = 1749585052;
						num56 = 1749585052;
					}
					else
					{
						num55 = 1401296052;
						num56 = 1401296052;
					}
					num = num55 ^ ((int)num2 * -1300934447);
					continue;
				}
				case 159u:
					num30 = 0;
					num27 = 0;
					num = (int)(num2 * 234218032) ^ -1798631209;
					continue;
				case 158u:
					num = -1916405448;
					continue;
				case 157u:
					num38 = Form1.smethod_33(rnd, 4);
					num39 = Form1.smethod_33(rnd, 4);
					num = (int)((num2 * 2036293180) ^ 0x32577D09);
					continue;
				case 156u:
					num = -1791253853;
					continue;
				case 155u:
					Form1.smethod_30((Control)(object)borderBox[num20, num21]);
					num = (int)((num2 * 1902283972) ^ 0x58732E61);
					continue;
				case 154u:
					Form1.smethod_47(200);
					num = (int)((num2 * 2147014386) ^ 0x25626ED8);
					continue;
				case 153u:
					flag9 = num14 < 4;
					num = -512585834;
					continue;
				case 152u:
				{
					int num22;
					int num23;
					if (Form1.smethod_41((Control)(object)borderBox[num20, num21]) == Color.Red)
					{
						num22 = 313213226;
						num23 = 313213226;
					}
					else
					{
						num22 = 482366343;
						num23 = 482366343;
					}
					num = num22 ^ ((int)num2 * -762241363);
					continue;
				}
				case 151u:
					num = ((int)num2 * -300201362) ^ 0x1A619CA9;
					continue;
				case 150u:
				{
					int num61;
					int num62;
					if (flag12)
					{
						num61 = -239276815;
						num62 = -239276815;
					}
					else
					{
						num61 = -901875174;
						num62 = -901875174;
					}
					num = num61 ^ ((int)num2 * -959890813);
					continue;
				}
				case 149u:
					num = (int)(num2 * 126379930) ^ -1204480694;
					continue;
				case 148u:
					Form1.smethod_5((Control)(object)borderBox[num20, num21], Color.LimeGreen);
					num = ((int)num2 * -1601324660) ^ -874913259;
					continue;
				case 147u:
					num14 = 0;
					num = (int)((num2 * 1696183621) ^ 0x6C0F288);
					continue;
				case 146u:
				{
					int num53;
					int num54;
					if (!flag2)
					{
						num53 = -1907611441;
						num54 = -1907611441;
					}
					else
					{
						num53 = -2096103264;
						num54 = -2096103264;
					}
					num = num53 ^ ((int)num2 * -1563765588);
					continue;
				}
				case 145u:
					if (num31 == num5)
					{
						num = (int)(num2 * 1325085293) ^ -1824386446;
						continue;
					}
					num33 = 0;
					goto IL_02ca;
				case 144u:
				{
					int num45;
					int num46;
					if (!flag13)
					{
						num45 = -1747850828;
						num46 = -1747850828;
					}
					else
					{
						num45 = -133159695;
						num46 = -133159695;
					}
					num = num45 ^ (int)(num2 * 1386262182);
					continue;
				}
				case 143u:
					Form1.smethod_44(graphics_, Form1.smethod_21(pictureBox[num5, num6]), num39 * size + 4, num38 * size + 4, new Rectangle(0, 0, size, size), (GraphicsUnit)2);
					num = ((int)num2 * -123544865) ^ -1624789688;
					continue;
				case 142u:
					num5 = 0;
					num6 = 0;
					num20 = 0;
					num = ((int)num2 * -2040504358) ^ -555407434;
					continue;
				case 141u:
					num10 = 0;
					num = -16115256;
					continue;
				case 140u:
					num = ((int)num2 * -1859470572) ^ 0x766EE9AE;
					continue;
				case 139u:
					num = ((int)num2 * -366219244) ^ 0x465B3B1F;
					continue;
				case 138u:
					array3 = (Figurine[,])Form1.smethod_48((Array)array2);
					array3[num17, num25] = new Figurine(storage[num31, num32]);
					num = ((int)num2 * -2052572489) ^ -911036490;
					continue;
				case 137u:
					(menu as Form3).ContinueLock();
					num = ((int)num2 * -752076000) ^ 0x514AE2E9;
					continue;
				case 136u:
					flag10 = num21 < 4;
					num = -1635774954;
					continue;
				case 135u:
					board[num38, num39] = new Figurine(storage[num5, num6]);
					num = (int)(num2 * 846526767) ^ -317281092;
					continue;
				case 134u:
				{
					int num34;
					int num35;
					if (flag8)
					{
						num34 = -1282373050;
						num35 = -1282373050;
					}
					else
					{
						num34 = -242394917;
						num35 = -242394917;
					}
					num = num34 ^ ((int)num2 * -1693541665);
					continue;
				}
				case 133u:
					array[num18, num19] = new Figurine(storage[num5, num6]);
					if (!Stop(array))
					{
						num = (int)((num2 * 96422729) ^ 0x3E1363E8);
						continue;
					}
					goto IL_04b8;
				case 132u:
					num17++;
					num = (int)(num2 * 806073919) ^ -545862566;
					continue;
				case 131u:
					if (!Standoff(array))
					{
						num = -1045293966;
						num13 = -1045293966;
						continue;
					}
					goto IL_04b8;
				case 130u:
					num = -1342935677;
					continue;
				case 129u:
					num14++;
					num = ((int)num2 * -68827343) ^ -201454266;
					continue;
				case 128u:
					num = (int)(num2 * 1336933513) ^ -1662640056;
					continue;
				case 127u:
					num9++;
					flag4 = false;
					num = -1029749156;
					continue;
				case 126u:
					num10++;
					num = ((int)num2 * -1851450222) ^ -769919196;
					continue;
				case 125u:
					Form1.smethod_30((Control)(object)borderBox[num5, num6]);
					num = (int)((num2 * 1236670852) ^ 0x239CA3C2);
					continue;
				case 124u:
					flag2 = Standoff(board);
					num = (int)((num2 * 883134829) ^ 0x4ECEE580);
					continue;
				case 123u:
				{
					int num64;
					if (num19 < 4)
					{
						num = -327478132;
						num64 = -327478132;
					}
					else
					{
						num = -1969727606;
						num64 = -1969727606;
					}
					continue;
				}
				case 122u:
					num36 = ((num9 < 9) ? 1 : 0);
					goto IL_05ca;
				case 121u:
					num = -1206996259;
					continue;
				case 120u:
				{
					int num63;
					if (!Standoff(board))
					{
						num = -1109245985;
						num63 = -1109245985;
					}
					else
					{
						num = -706270061;
						num63 = -706270061;
					}
					continue;
				}
				case 119u:
					num = (int)((num2 * 451141712) ^ 0x30CACFD8);
					continue;
				case 118u:
				{
					int num59;
					int num60;
					if (Form1.smethod_46((Control)(object)pictureBox1))
					{
						num59 = 1523361051;
						num60 = 1523361051;
					}
					else
					{
						num59 = 167826218;
						num60 = 167826218;
					}
					num = num59 ^ ((int)num2 * -1780054899);
					continue;
				}
				case 117u:
					board[num18, num19] = new Figurine(storage[num5, num6]);
					num = ((int)num2 * -1050642467) ^ -1213904604;
					continue;
				case 116u:
					num = ((int)num2 * -894433906) ^ -1475072616;
					continue;
				case 115u:
				{
					int num58;
					if (num57 >= 4)
					{
						num = -1254177075;
						num58 = -1254177075;
					}
					else
					{
						num = -847438919;
						num58 = -847438919;
					}
					continue;
				}
				case 114u:
					Form1.smethod_15(timer1);
					num = (int)((num2 * 311388714) ^ 0x50BE0B4C);
					continue;
				case 113u:
					if (!Stop(board))
					{
						num = ((int)num2 * -174278853) ^ 0x1235DAC6;
						continue;
					}
					goto IL_06fd;
				case 112u:
					Form1.smethod_20(pictureBox[num5, num6], (Image)null);
					num = (int)((num2 * 1918952338) ^ 0x52379992);
					continue;
				case 111u:
					array = (Figurine[,])Form1.smethod_48((Array)board);
					num = (int)(num2 * 1774577337) ^ -1563250212;
					continue;
				case 110u:
					num = (int)((num2 * 731694273) ^ 0x14176456);
					continue;
				case 109u:
					num19++;
					num = -1185058667;
					continue;
				case 108u:
					Form1.smethod_5((Control)(object)borderBox[num31, num32], Color.Blue);
					num = (int)((num2 * 1208633639) ^ 0x1C48C530);
					continue;
				case 107u:
					Form1.smethod_30((Control)(object)richTextBox1);
					num = (int)((num2 * 1245889549) ^ 0x1933C4CF);
					continue;
				case 106u:
					num = ((int)num2 * -97238655) ^ -1780792595;
					continue;
				case 105u:
					num57 = 0;
					num = -1188417955;
					continue;
				case 104u:
					Form1.smethod_32((Control)(object)label2, Form1.smethod_34("Ход: ", step.ToString()));
					Form1.smethod_30((Control)(object)label2);
					num = ((int)num2 * -1530241539) ^ -620054378;
					continue;
				case 103u:
					Paint_Board();
					num = (int)(num2 * 2075073404) ^ -1947869425;
					continue;
				case 102u:
					num = -1125643556;
					continue;
				case 101u:
					Form1.smethod_5((Control)(object)borderBox[num5, num6], Color.White);
					Form1.smethod_30((Control)(object)borderBox[num5, num6]);
					num = (int)(num2 * 1021286320) ^ -1227911674;
					continue;
				case 100u:
					num = ((int)num2 * -1499583044) ^ -1316570471;
					continue;
				case 99u:
					flag5 = num25 < 4;
					num = -111473328;
					continue;
				case 98u:
					array2 = (Figurine[,])Form1.smethod_48((Array)board);
					num = (int)(num2 * 506714679) ^ -1569366634;
					continue;
				case 97u:
					num = -2024829287;
					continue;
				case 96u:
				{
					int num51;
					int num52;
					if (!flag9)
					{
						num51 = 1559207498;
						num52 = 1559207498;
					}
					else
					{
						num51 = 994332331;
						num52 = 994332331;
					}
					num = num51 ^ (int)(num2 * 2113847951);
					continue;
				}
				case 95u:
				{
					int num49;
					int num50;
					if (!flag14)
					{
						num49 = 977072092;
						num50 = 977072092;
					}
					else
					{
						num49 = 579326834;
						num50 = 579326834;
					}
					num = num49 ^ ((int)num2 * -1762638032);
					continue;
				}
				case 93u:
					num30 = num10;
					Form1.smethod_5((Control)(object)borderBox[num14, num10], Color.White);
					Form1.smethod_30((Control)(object)borderBox[num14, num10]);
					Form1.smethod_20(pictureBox[num14, num10], (Image)null);
					num = ((int)num2 * -1772409424) ^ 0x37DFCCB6;
					continue;
				case 92u:
					num18++;
					num = (int)((num2 * 809302460) ^ 0x366F530A);
					continue;
				case 91u:
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: false);
					num = (int)(num2 * 252016754) ^ -141212306;
					continue;
				case 90u:
					Form1.smethod_32((Control)(object)richTextBox1, "Противник сделал ход (зелёный). Выберете поле на доске для выбронной противником фигуры (синий).");
					num = (int)((num2 * 596974479) ^ 0x42428BC8);
					continue;
				case 89u:
					num32 = Form1.smethod_33(rnd, 4);
					num = ((int)num2 * -1698558024) ^ -1270541514;
					continue;
				case 88u:
				{
					int num47;
					int num48;
					if (flag7)
					{
						num47 = 1923135394;
						num48 = 1923135394;
					}
					else
					{
						num47 = 650246876;
						num48 = 650246876;
					}
					num = num47 ^ (int)(num2 * 68099712);
					continue;
				}
				case 87u:
					num = (int)(num2 * 483007185) ^ -1619710680;
					continue;
				case 86u:
					Form1.smethod_30((Control)(object)pictureBox1);
					num = (int)((num2 * 111026768) ^ 0x4A244A51);
					continue;
				case 85u:
					num = (int)(num2 * 1696655657) ^ -1194861252;
					continue;
				case 84u:
				{
					int num44;
					if (num18 >= 4)
					{
						num = -1610348859;
						num44 = -1610348859;
					}
					else
					{
						num = -1231988089;
						num44 = -1231988089;
					}
					continue;
				}
				case 83u:
					flag12 = Form1.smethod_41((Control)(object)borderBox[num14, num10]) == Color.Blue;
					num = (int)(num2 * 1672674244) ^ -1773453140;
					continue;
				case 82u:
					Form1.smethod_43(graphics_, Form1.smethod_42(Color.LimeGreen, 3f), ((float)num39 + 0.05f) * (float)size, ((float)num38 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					num = (int)(num2 * 1524957745) ^ -540779149;
					continue;
				case 81u:
					num28 = 0;
					num = (int)((num2 * 1004192275) ^ 0x5EBE263E);
					continue;
				case 80u:
					num = -1375859477;
					continue;
				case 79u:
					num = ((int)num2 * -1752009774) ^ 0x4EE7C64C;
					continue;
				case 78u:
					flag11 = Stop(array3);
					num = ((int)num2 * -1731452093) ^ 0x151AA5E9;
					continue;
				case 77u:
					Form1.smethod_32((Control)(object)richTextBox1, "Подождите, компьютер делает свой ход.");
					num = (int)(num2 * 72525151) ^ -1736548770;
					continue;
				case 76u:
					Form1.smethod_30((Control)(object)pictureBox[num5, num6]);
					num = (int)(num2 * 564367090) ^ -1636197645;
					continue;
				case 75u:
					num5 = num20;
					num6 = num21;
					num = ((int)num2 * -1002790868) ^ 0x57BF2164;
					continue;
				case 74u:
					flag = board[num18, num19] == null;
					num = -603476524;
					continue;
				case 73u:
					num19 = 0;
					num = -438926530;
					continue;
				case 72u:
					num = ((int)num2 * -1852146941) ^ -576579598;
					continue;
				case 71u:
					num = ((int)num2 * -1279672557) ^ -1581977324;
					continue;
				case 70u:
					Form1.smethod_32((Control)(object)richTextBox1, "Ничья!");
					num = ((int)num2 * -274059455) ^ 0x1EE00CBF;
					continue;
				case 69u:
					Form1.smethod_15(timer1);
					num = -1440010935;
					continue;
				case 68u:
					Form1.smethod_30((Control)(object)pictureBox1);
					num = ((int)num2 * -908561365) ^ -1803926304;
					continue;
				case 67u:
					if (!Standoff(board))
					{
						num = -384278441;
						num43 = -384278441;
						continue;
					}
					goto IL_06fd;
				case 66u:
					Form1.smethod_5((Control)(object)borderBox[num5, num6], Color.White);
					num = (int)((num2 * 438774096) ^ 0x5B501A43);
					continue;
				case 65u:
					num24 = 0;
					num = (int)(num2 * 928655125) ^ -186836326;
					continue;
				case 64u:
					Form1.smethod_30((Control)(object)pictureBox[num14, num10]);
					num = ((int)num2 * -1054288301) ^ 0x19DBB77E;
					continue;
				case 63u:
					step++;
					num = (int)((num2 * 796986871) ^ 0x5551F87F);
					continue;
				case 62u:
					Form1.smethod_20(pictureBox[num5, num6], (Image)null);
					num = ((int)num2 * -801525008) ^ 0x5A0A9E47;
					continue;
				case 61u:
					Form1.smethod_44(graphics_, Form1.smethod_21(pictureBox[num5, num6]), num19 * size + 4, num18 * size + 4, new Rectangle(0, 0, size, size), (GraphicsUnit)2);
					num = ((int)num2 * -1624005705) ^ -1895606693;
					continue;
				case 60u:
					num31 = Form1.smethod_33(rnd, 4);
					num = -1536107009;
					continue;
				case 59u:
					num9 = 0;
					num = (int)(num2 * 502405382) ^ -637271309;
					continue;
				case 58u:
					num25++;
					num = -575295187;
					continue;
				case 57u:
					num33 = ((num32 == num6) ? 1 : 0);
					goto IL_02ca;
				case 55u:
					num = ((int)num2 * -1147310286) ^ -1773656515;
					continue;
				case 54u:
					flag3 = num10 < 4;
					num = -1840701115;
					continue;
				case 53u:
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox1));
					num18 = 0;
					num = ((int)num2 * -1366255803) ^ 0x45DBE87;
					continue;
				case 52u:
					Form1.smethod_47(200);
					num = (int)((num2 * 267448231) ^ 0x740B899F);
					continue;
				case 51u:
					Form1.smethod_43(graphics_, Form1.smethod_42(Color.LimeGreen, 3f), ((float)num19 + 0.05f) * (float)size, ((float)num18 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					num = ((int)num2 * -1884626361) ^ -440539504;
					continue;
				case 50u:
					num27 = num14;
					num28 = num10;
					num = ((int)num2 * -1796387398) ^ 0x474E90C;
					continue;
				case 49u:
					num25 = 0;
					num = -1901128748;
					continue;
				case 48u:
				{
					int num42;
					if (num17 >= 4)
					{
						num = -280443870;
						num42 = -280443870;
					}
					else
					{
						num = -882395537;
						num42 = -882395537;
					}
					continue;
				}
				case 47u:
					Form1.smethod_47(1000);
					num = (int)(num2 * 906724113) ^ -281597984;
					continue;
				case 46u:
					array2[num38, num39] = new Figurine(storage[num5, num6]);
					num17 = 0;
					num = (int)((num2 * 1930684842) ^ 0x606BC00A);
					continue;
				case 45u:
				{
					int num40;
					int num41;
					if (flag11)
					{
						num40 = 631004054;
						num41 = 631004054;
					}
					else
					{
						num40 = 741666875;
						num41 = 741666875;
					}
					num = num40 ^ (int)(num2 * 1748903);
					continue;
				}
				case 44u:
					Form1.smethod_32((Control)(object)richTextBox1, "Выберете фигуру, которой будет играть противник.");
					num = ((int)num2 * -679545161) ^ -682190098;
					continue;
				case 43u:
					flag6 = board[num38, num39] != null;
					num = ((int)num2 * -1975286250) ^ -362243700;
					continue;
				case 42u:
					num20++;
					num = ((int)num2 * -155606858) ^ 0x5B02ACB6;
					continue;
				case 41u:
					num = -1503165909;
					continue;
				case 40u:
					num = ((int)num2 * -750770729) ^ 0x41B824B2;
					continue;
				case 39u:
					num29 = num14;
					num = ((int)num2 * -262739805) ^ -1781858354;
					continue;
				case 38u:
				{
					int num37;
					if (!(Form1.smethod_40((Bitmap)Form1.smethod_21(pictureBox1), num10 * size + size / 2, (int)(((float)num14 + 0.05f) * (float)size)) == Color.FromArgb(255, 255, 0, 0)))
					{
						num = -422593016;
						num37 = -422593016;
					}
					else
					{
						num = -2146467467;
						num37 = -2146467467;
					}
					continue;
				}
				case 37u:
					num = ((int)num2 * -705879499) ^ 0xEE22987;
					continue;
				case 36u:
					if (!flag4)
					{
						num = ((int)num2 * -398892812) ^ 0x1863F57C;
						continue;
					}
					num36 = 1;
					goto IL_05ca;
				case 35u:
					num = (int)((num2 * 914738370) ^ 0x7A0B8DC2);
					continue;
				case 34u:
					num21 = 0;
					num = -880803377;
					continue;
				case 33u:
					Form1.smethod_30((Control)(object)borderBox[num31, num32]);
					num = ((int)num2 * -737849989) ^ -1872633209;
					continue;
				case 32u:
					if (storage[num31, num32] != null)
					{
						num = ((int)num2 * -1513698863) ^ 0x2009839F;
						continue;
					}
					num33 = 1;
					goto IL_02ca;
				case 31u:
					num = (int)(num2 * 676770272) ^ -1497848390;
					continue;
				case 30u:
					num29 = 0;
					num = (int)((num2 * 1146608722) ^ 0x1606E83D);
					continue;
				case 29u:
					num = ((int)num2 * -1865871122) ^ -1647715663;
					continue;
				case 28u:
					board[num27, num28] = new Figurine(storage[num29, num30]);
					storage[num29, num30] = null;
					num = (int)(num2 * 1330999598) ^ -1713747967;
					continue;
				case 27u:
					storage[num5, num6] = null;
					num = (int)(num2 * 1905005988) ^ -1595289970;
					continue;
				case 26u:
					num = -1191296943;
					continue;
				case 25u:
				{
					int num26;
					if (num24 < 4)
					{
						num = -1628870169;
						num26 = -1628870169;
					}
					else
					{
						num = -908140374;
						num26 = -908140374;
					}
					continue;
				}
				case 24u:
					num = ((int)num2 * -1138762192) ^ 0x7B7D2495;
					continue;
				case 23u:
					num = (int)((num2 * 297568912) ^ 0x6097DFE1);
					continue;
				case 22u:
					(menu as Form3).ContinueLock();
					num = (int)(num2 * 1107965576) ^ -789815319;
					continue;
				case 21u:
					num = ((int)num2 * -1191148520) ^ 0x664CA7D0;
					continue;
				case 20u:
					flag8 = num20 < 4;
					num = -1322771520;
					continue;
				case 19u:
					storage[num5, num6] = null;
					num = ((int)num2 * -1905541975) ^ -192822279;
					continue;
				case 18u:
					flag7 = array2[num17, num25] == null;
					num = -1136153698;
					continue;
				case 17u:
					Form1.smethod_32((Control)(object)richTextBox1, "QUARTO! Компьютер выиграл!");
					num = -1660407030;
					continue;
				case 16u:
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: true);
					num = ((int)num2 * -2005757849) ^ 0xB8CE612;
					continue;
				case 15u:
					num21++;
					num = ((int)num2 * -358879158) ^ 0x1BED2408;
					continue;
				case 14u:
					num = (int)(num2 * 94334785) ^ -1372597791;
					continue;
				case 13u:
					Form1.smethod_32((Control)(object)richTextBox1, "Ничья!");
					num = (int)((num2 * 682598521) ^ 0xCDBA8C9);
					continue;
				case 12u:
					num = ((int)num2 * -255494317) ^ -1575771249;
					continue;
				case 11u:
					num24++;
					num = (int)((num2 * 2033725779) ^ 0x536013CE);
					continue;
				case 10u:
					Form1.smethod_7((Control)(object)pictureBox[num20, num21], bool_0: false);
					num = -1461975621;
					continue;
				case 9u:
					Form1.smethod_30((Control)(object)pictureBox[num5, num6]);
					num = ((int)num2 * -1748511274) ^ -1366808929;
					continue;
				case 8u:
				{
					int num15;
					int num16;
					if (flag6)
					{
						num15 = -1289985220;
						num16 = -1289985220;
					}
					else
					{
						num15 = -1967232446;
						num16 = -1967232446;
					}
					num = num15 ^ ((int)num2 * -305481119);
					continue;
				}
				case 7u:
					num = (int)(num2 * 429320722) ^ -376618848;
					continue;
				case 6u:
				{
					int num11;
					int num12;
					if (flag5)
					{
						num11 = 546692098;
						num12 = 546692098;
					}
					else
					{
						num11 = 2144602772;
						num12 = 2144602772;
					}
					num = num11 ^ ((int)num2 * -1899251351);
					continue;
				}
				case 5u:
					num = ((int)num2 * -102968798) ^ -1188866740;
					continue;
				case 4u:
					num = (int)((num2 * 706380932) ^ 0x2B05E04C);
					continue;
				case 3u:
				{
					int num7;
					int num8;
					if (flag3)
					{
						num7 = 1023173051;
						num8 = 1023173051;
					}
					else
					{
						num7 = 194880611;
						num8 = 194880611;
					}
					num = num7 ^ ((int)num2 * -2036327188);
					continue;
				}
				case 2u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = -1159981591;
						num4 = -1159981591;
					}
					else
					{
						num3 = -1986232824;
						num4 = -1986232824;
					}
					num = num3 ^ (int)(num2 * 1666061265);
					continue;
				}
				case 1u:
					num = ((int)num2 * -1702841014) ^ -1390247639;
					continue;
				case 0u:
					num = (int)(num2 * 103118939) ^ -939579989;
					continue;
				default:
					return;
				case 56u:
					break;
				case 94u:
					return;
					IL_04b8:
					num = -2020774096;
					num13 = -2020774096;
					continue;
					IL_02ca:
					flag14 = (byte)num33 != 0;
					num = -340449255;
					continue;
					IL_06fd:
					num = -1959961442;
					num43 = -1959961442;
					continue;
					IL_05ca:
					flag13 = (byte)num36 != 0;
					num = -1136448786;
					continue;
				}
				break;
			}
		}
	}

	private bool Stop(Figurine[,] mem)
	{
		bool flag = default(bool);
		int num5 = default(int);
		bool flag2 = default(bool);
		bool result = default(bool);
		while (true)
		{
			int num = 764952732;
			while (true)
			{
				uint num2;
				int num14;
				int num38;
				switch ((num2 = (uint)num ^ 0x73FD9572u) % 74u)
				{
				case 72u:
				{
					int num30;
					int num31;
					if (mem[1, 1].Dark == mem[2, 2].Dark)
					{
						num30 = 1013245980;
						num31 = 1013245980;
					}
					else
					{
						num30 = 962884144;
						num31 = 962884144;
					}
					num = num30 ^ (int)(num2 * 1448372166);
					continue;
				}
				case 71u:
					flag = true;
					num = (int)((num2 * 473438636) ^ 0x5AD1E589);
					continue;
				case 70u:
					if (mem[num5, 2].Big != mem[num5, 3].Big)
					{
						num = ((int)num2 * -1796182243) ^ -995167651;
						continue;
					}
					goto IL_009a;
				case 69u:
					if (mem[0, 3] != null)
					{
						num = 811120253;
						continue;
					}
					goto IL_00cd;
				case 68u:
				{
					int num59;
					if (mem[num5, 0].Point == mem[num5, 1].Point)
					{
						num = 1683666262;
						num59 = 1683666262;
					}
					else
					{
						num = 654311792;
						num59 = 654311792;
					}
					continue;
				}
				case 67u:
					if (mem[1, 2] != null)
					{
						num = ((int)num2 * -1471124413) ^ 0x73F5FE34;
						continue;
					}
					goto IL_00cd;
				case 66u:
					num5++;
					num = (int)(num2 * 1244292190) ^ -748641487;
					continue;
				case 65u:
					if (mem[2, num5].Dark != mem[3, num5].Dark)
					{
						num = (int)((num2 * 1576066532) ^ 0x347EDA4E);
						continue;
					}
					goto IL_009a;
				case 64u:
					if (mem[3, num5] != null)
					{
						num = (int)((num2 * 1993797452) ^ 0x33D9EBF);
						continue;
					}
					goto IL_008e;
				case 63u:
				{
					int num65;
					int num66;
					if (mem[3, 3] == null)
					{
						num65 = 1206006790;
						num66 = 1206006790;
					}
					else
					{
						num65 = 1709456326;
						num66 = 1709456326;
					}
					num = num65 ^ (int)(num2 * 895557925);
					continue;
				}
				case 62u:
					if (mem[0, 3].Square == mem[1, 2].Square)
					{
						num = 1592562641;
						continue;
					}
					goto IL_00cd;
				case 61u:
				{
					int num45;
					int num46;
					if (mem[0, 0] != null)
					{
						num45 = -2074093153;
						num46 = -2074093153;
					}
					else
					{
						num45 = -257104120;
						num46 = -257104120;
					}
					num = num45 ^ ((int)num2 * -7474071);
					continue;
				}
				case 60u:
				{
					int num26;
					int num27;
					if (mem[num5, 1].Square == mem[num5, 2].Square)
					{
						num26 = -2069142371;
						num27 = -2069142371;
					}
					else
					{
						num26 = -1421122517;
						num27 = -1421122517;
					}
					num = num26 ^ ((int)num2 * -191536000);
					continue;
				}
				case 59u:
					flag2 = num5 < 4;
					num = 560223744;
					continue;
				case 58u:
				{
					int num15;
					int num16;
					if (mem[2, 2] == null)
					{
						num15 = -1174342175;
						num16 = -1174342175;
					}
					else
					{
						num15 = -1482990191;
						num16 = -1482990191;
					}
					num = num15 ^ ((int)num2 * -318782757);
					continue;
				}
				case 57u:
				{
					int num4;
					if (mem[0, 3].Point != mem[1, 2].Point)
					{
						num = 1640417908;
						num4 = 1640417908;
					}
					else
					{
						num = 797298174;
						num4 = 797298174;
					}
					continue;
				}
				case 56u:
					flag = true;
					num = ((int)num2 * -1409909495) ^ 0x120B3231;
					continue;
				case 55u:
				{
					int num60;
					int num61;
					if (mem[1, 2].Big != mem[2, 1].Big)
					{
						num60 = -630967462;
						num61 = -630967462;
					}
					else
					{
						num60 = -1816127220;
						num61 = -1816127220;
					}
					num = num60 ^ (int)(num2 * 219793078);
					continue;
				}
				case 54u:
				{
					int num52;
					if (mem[0, 3].Dark != mem[1, 2].Dark)
					{
						num = 936510233;
						num52 = 936510233;
					}
					else
					{
						num = 1760173214;
						num52 = 1760173214;
					}
					continue;
				}
				case 53u:
					if (mem[2, 1] != null)
					{
						num = (int)((num2 * 2132440040) ^ 0x32029FD6);
						continue;
					}
					goto IL_00cd;
				case 52u:
					if (mem[3, 0] != null)
					{
						num = ((int)num2 * -1653792590) ^ -90611056;
						continue;
					}
					goto IL_00cd;
				case 51u:
				{
					int num37;
					if (mem[0, 0].Square == mem[1, 1].Square)
					{
						num = 643083966;
						num37 = 643083966;
					}
					else
					{
						num = 712997701;
						num37 = 712997701;
					}
					continue;
				}
				case 50u:
					if (mem[2, 2].Point != mem[3, 3].Point)
					{
						num = ((int)num2 * -42267319) ^ 0x329A0515;
						continue;
					}
					goto IL_00c1;
				case 49u:
				{
					int num32;
					int num33;
					if (mem[num5, 1] == null)
					{
						num32 = 1278276557;
						num33 = 1278276557;
					}
					else
					{
						num32 = 1960308176;
						num33 = 1960308176;
					}
					num = num32 ^ ((int)num2 * -1382768734);
					continue;
				}
				case 48u:
				{
					int num25;
					if (mem[num5, 0].Square == mem[num5, 1].Square)
					{
						num = 26415380;
						num25 = 26415380;
					}
					else
					{
						num = 18050859;
						num25 = 18050859;
					}
					continue;
				}
				case 47u:
				{
					int num8;
					int num9;
					if (mem[num5, 1].Big != mem[num5, 2].Big)
					{
						num8 = -146647311;
						num9 = -146647311;
					}
					else
					{
						num8 = -1290847826;
						num9 = -1290847826;
					}
					num = num8 ^ ((int)num2 * -940041312);
					continue;
				}
				case 46u:
					if (mem[2, num5].Square != mem[3, num5].Square)
					{
						goto IL_008e;
					}
					goto IL_009a;
				case 45u:
					if (mem[1, 2].Square == mem[2, 1].Square)
					{
						num = (int)((num2 * 1251958991) ^ 0x59969D9A);
						continue;
					}
					goto IL_00cd;
				case 44u:
				{
					int num64;
					if (mem[0, num5].Point != mem[1, num5].Point)
					{
						num = 2139029832;
						num64 = 2139029832;
					}
					else
					{
						num = 1529845325;
						num64 = 1529845325;
					}
					continue;
				}
				case 43u:
					if (mem[2, num5] != null)
					{
						num = ((int)num2 * -1789127805) ^ 0xCFA2443;
						continue;
					}
					goto IL_008e;
				case 42u:
					flag = false;
					num5 = 0;
					num = ((int)num2 * -2129032076) ^ 0xEF5EB0D;
					continue;
				case 41u:
				{
					int num55;
					int num56;
					if (mem[1, 1].Point != mem[2, 2].Point)
					{
						num55 = -282615293;
						num56 = -282615293;
					}
					else
					{
						num55 = -922923532;
						num56 = -922923532;
					}
					num = num55 ^ (int)(num2 * 423620700);
					continue;
				}
				case 40u:
					if (mem[2, 1].Big != mem[3, 0].Big)
					{
						num = ((int)num2 * -1192945586) ^ -186604756;
						continue;
					}
					goto IL_00c1;
				case 39u:
					result = flag;
					num = 263801195;
					continue;
				case 38u:
					if (mem[2, num5].Point != mem[3, num5].Point)
					{
						num = ((int)num2 * -9375868) ^ -1208893968;
						continue;
					}
					goto IL_009a;
				case 37u:
				{
					int num49;
					if (mem[num5, 0].Dark == mem[num5, 1].Dark)
					{
						num = 1028818959;
						num49 = 1028818959;
					}
					else
					{
						num = 758721034;
						num49 = 758721034;
					}
					continue;
				}
				case 36u:
				{
					int num42;
					int num43;
					if (mem[num5, 3] == null)
					{
						num42 = 1314812391;
						num43 = 1314812391;
					}
					else
					{
						num42 = 229010631;
						num43 = 229010631;
					}
					num = num42 ^ ((int)num2 * -417676782);
					continue;
				}
				case 35u:
				{
					int num39;
					int num40;
					if (mem[0, num5].Big != mem[1, num5].Big)
					{
						num39 = 977046736;
						num40 = 977046736;
					}
					else
					{
						num39 = 1950175650;
						num40 = 1950175650;
					}
					num = num39 ^ (int)(num2 * 185475329);
					continue;
				}
				case 34u:
					if (mem[2, 1].Point != mem[3, 0].Point)
					{
						num = (int)((num2 * 653321216) ^ 0x7C8FBA74);
						continue;
					}
					goto IL_00c1;
				case 32u:
					if (mem[2, 2].Dark != mem[3, 3].Dark)
					{
						num = (int)(num2 * 1276852464) ^ -1421822356;
						continue;
					}
					goto IL_00c1;
				case 31u:
					if (mem[0, num5] != null)
					{
						num = 968791437;
						continue;
					}
					goto IL_008e;
				case 30u:
				{
					int num23;
					int num24;
					if (mem[1, 1].Square == mem[2, 2].Square)
					{
						num23 = -21862636;
						num24 = -21862636;
					}
					else
					{
						num23 = -2032368771;
						num24 = -2032368771;
					}
					num = num23 ^ ((int)num2 * -1438303942);
					continue;
				}
				case 29u:
				{
					int num19;
					int num20;
					if (mem[0, 0].Big != mem[1, 1].Big)
					{
						num19 = 264834925;
						num20 = 264834925;
					}
					else
					{
						num19 = 1709860184;
						num20 = 1709860184;
					}
					num = num19 ^ ((int)num2 * -1086707335);
					continue;
				}
				case 28u:
					if (mem[num5, 2].Dark != mem[num5, 3].Dark)
					{
						num = (int)(num2 * 1153173855) ^ -1634162744;
						continue;
					}
					goto IL_009a;
				case 27u:
					if (mem[num5, 2].Square != mem[num5, 3].Square)
					{
						num = (int)((num2 * 164987036) ^ 0x6360068F);
						continue;
					}
					goto IL_009a;
				case 26u:
				{
					int num10;
					int num11;
					if (mem[1, 2].Point == mem[2, 1].Point)
					{
						num10 = -1376278234;
						num11 = -1376278234;
					}
					else
					{
						num10 = -501339364;
						num11 = -501339364;
					}
					num = num10 ^ ((int)num2 * -1580317986);
					continue;
				}
				case 25u:
				{
					int num67;
					int num68;
					if (mem[num5, 1].Dark == mem[num5, 2].Dark)
					{
						num67 = 424610513;
						num68 = 424610513;
					}
					else
					{
						num67 = 116923095;
						num68 = 116923095;
					}
					num = num67 ^ ((int)num2 * -742113567);
					continue;
				}
				case 24u:
				{
					int num62;
					int num63;
					if (!flag2)
					{
						num62 = -911718883;
						num63 = -911718883;
					}
					else
					{
						num62 = -857650400;
						num63 = -857650400;
					}
					num = num62 ^ ((int)num2 * -2056867139);
					continue;
				}
				case 23u:
					if (mem[num5, 2].Point != mem[num5, 3].Point)
					{
						num = (int)((num2 * 1558210856) ^ 0x16B2CC88);
						continue;
					}
					goto IL_009a;
				case 22u:
					if (mem[2, 2].Big != mem[3, 3].Big)
					{
						num = ((int)num2 * -392464395) ^ 0x52FD9C2C;
						continue;
					}
					goto IL_00c1;
				case 21u:
				{
					int num57;
					int num58;
					if (mem[1, 1].Big == mem[2, 2].Big)
					{
						num57 = -541328706;
						num58 = -541328706;
					}
					else
					{
						num57 = -1310577832;
						num58 = -1310577832;
					}
					num = num57 ^ (int)(num2 * 651520482);
					continue;
				}
				case 20u:
				{
					int num53;
					int num54;
					if (mem[num5, 2] == null)
					{
						num53 = -1285798445;
						num54 = -1285798445;
					}
					else
					{
						num53 = -1442839492;
						num54 = -1442839492;
					}
					num = num53 ^ (int)(num2 * 2094132958);
					continue;
				}
				case 19u:
				{
					int num50;
					int num51;
					if (mem[1, num5].Dark != mem[2, num5].Dark)
					{
						num50 = 314260863;
						num51 = 314260863;
					}
					else
					{
						num50 = 1916476142;
						num51 = 1916476142;
					}
					num = num50 ^ ((int)num2 * -1873447081);
					continue;
				}
				case 18u:
				{
					int num47;
					int num48;
					if (mem[0, 3].Big != mem[1, 2].Big)
					{
						num47 = 852778574;
						num48 = 852778574;
					}
					else
					{
						num47 = 782747433;
						num48 = 782747433;
					}
					num = num47 ^ (int)(num2 * 377244285);
					continue;
				}
				case 17u:
					num = 1356052956;
					continue;
				case 16u:
					if (mem[0, num5].Square == mem[1, num5].Square)
					{
						num = 1804460747;
						continue;
					}
					goto IL_008e;
				case 15u:
				{
					int num44;
					if (mem[0, num5].Dark == mem[1, num5].Dark)
					{
						num = 1308567457;
						num44 = 1308567457;
					}
					else
					{
						num = 1990387658;
						num44 = 1990387658;
					}
					continue;
				}
				case 14u:
				{
					int num41;
					if (mem[num5, 0] != null)
					{
						num = 1288583793;
						num41 = 1288583793;
					}
					else
					{
						num = 18050859;
						num41 = 18050859;
					}
					continue;
				}
				case 13u:
				{
					int num35;
					int num36;
					if (mem[1, num5].Point == mem[2, num5].Point)
					{
						num35 = 771776502;
						num36 = 771776502;
					}
					else
					{
						num35 = 394678050;
						num36 = 394678050;
					}
					num = num35 ^ ((int)num2 * -221497066);
					continue;
				}
				case 12u:
					if (mem[2, 1].Dark != mem[3, 0].Dark)
					{
						num = (int)((num2 * 1540530268) ^ 0x243A39F9);
						continue;
					}
					goto IL_00c1;
				case 11u:
					if (mem[2, 1].Square == mem[3, 0].Square)
					{
						goto IL_00c1;
					}
					goto IL_00cd;
				case 10u:
				{
					int num34;
					if (mem[0, 0].Point != mem[1, 1].Point)
					{
						num = 1874635751;
						num34 = 1874635751;
					}
					else
					{
						num = 1513155229;
						num34 = 1513155229;
					}
					continue;
				}
				case 9u:
					if (mem[2, num5].Big != mem[3, num5].Big)
					{
						num = ((int)num2 * -1785284031) ^ -2026798606;
						continue;
					}
					goto IL_009a;
				case 8u:
				{
					int num28;
					int num29;
					if (mem[num5, 1].Point != mem[num5, 2].Point)
					{
						num28 = -449989688;
						num29 = -449989688;
					}
					else
					{
						num28 = -1281505319;
						num29 = -1281505319;
					}
					num = num28 ^ ((int)num2 * -1706899778);
					continue;
				}
				case 7u:
					if (mem[1, num5] != null)
					{
						num = (int)((num2 * 383365207) ^ 0x1453E00);
						continue;
					}
					goto IL_008e;
				case 6u:
				{
					int num21;
					int num22;
					if (mem[1, 2].Dark == mem[2, 1].Dark)
					{
						num21 = 288490330;
						num22 = 288490330;
					}
					else
					{
						num21 = 1903818553;
						num22 = 1903818553;
					}
					num = num21 ^ (int)(num2 * 198200472);
					continue;
				}
				case 5u:
				{
					int num17;
					int num18;
					if (mem[num5, 0].Big == mem[num5, 1].Big)
					{
						num17 = -1423284364;
						num18 = -1423284364;
					}
					else
					{
						num17 = -1476419630;
						num18 = -1476419630;
					}
					num = num17 ^ (int)(num2 * 986100571);
					continue;
				}
				case 4u:
				{
					int num12;
					int num13;
					if (mem[1, 1] != null)
					{
						num12 = -1885773826;
						num13 = -1885773826;
					}
					else
					{
						num12 = -676908315;
						num13 = -676908315;
					}
					num = num12 ^ (int)(num2 * 1100079913);
					continue;
				}
				case 3u:
					if (mem[1, num5].Square == mem[2, num5].Square)
					{
						num = (int)((num2 * 488535401) ^ 0x1D25472B);
						continue;
					}
					goto IL_008e;
				case 2u:
					if (mem[2, 2].Square != mem[3, 3].Square)
					{
						num = ((int)num2 * -1921627017) ^ 0x4F5FC2F7;
						continue;
					}
					goto IL_00c1;
				case 1u:
				{
					int num6;
					int num7;
					if (mem[1, num5].Big == mem[2, num5].Big)
					{
						num6 = -1104876278;
						num7 = -1104876278;
					}
					else
					{
						num6 = -999601334;
						num7 = -999601334;
					}
					num = num6 ^ (int)(num2 * 946828803);
					continue;
				}
				case 0u:
				{
					int num3;
					if (mem[0, 0].Dark != mem[1, 1].Dark)
					{
						num = 1835225740;
						num3 = 1835225740;
					}
					else
					{
						num = 1477189112;
						num3 = 1477189112;
					}
					continue;
				}
				case 73u:
					break;
				default:
					{
						return result;
					}
					IL_009a:
					num = 2071656940;
					num14 = 2071656940;
					continue;
					IL_00cd:
					num = 1761798037;
					num38 = 1761798037;
					continue;
					IL_00c1:
					num = 883558439;
					num38 = 883558439;
					continue;
					IL_008e:
					num = 1150600639;
					num14 = 1150600639;
					continue;
				}
				break;
			}
		}
	}

	private bool Standoff(Figurine[,] mem)
	{
		int num5 = default(int);
		bool flag = default(bool);
		int num3 = default(int);
		bool result = default(bool);
		while (true)
		{
			int num = 1282597859;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3D1CBF0u) % 13u)
				{
				case 12u:
					num5 = 0;
					num = ((int)num2 * -1732699061) ^ 0x70C227D4;
					continue;
				case 11u:
					flag = true;
					num = ((int)num2 * -1631050877) ^ 0x3B131305;
					continue;
				case 10u:
					flag = false;
					num = (int)((num2 * 1894944278) ^ 0x1C3EFEDB);
					continue;
				case 9u:
				{
					int num6;
					if (mem[num5, num3] != null)
					{
						num = 1334572963;
						num6 = 1334572963;
					}
					else
					{
						num = 217421892;
						num6 = 217421892;
					}
					continue;
				}
				case 8u:
					result = flag;
					num = ((int)num2 * -504307982) ^ 0x7A0F302A;
					continue;
				case 7u:
					num3++;
					num = 1588602506;
					continue;
				case 5u:
					num = (int)(num2 * 1118403841) ^ -298405638;
					continue;
				case 4u:
				{
					int num7;
					if (num5 >= 4)
					{
						num = 97382506;
						num7 = 97382506;
					}
					else
					{
						num = 1955893566;
						num7 = 1955893566;
					}
					continue;
				}
				case 3u:
					num3 = 0;
					num = 1588602506;
					continue;
				case 2u:
					num5++;
					num = ((int)num2 * -1063749631) ^ 0x768C141D;
					continue;
				case 0u:
				{
					int num4;
					if (num3 >= 4)
					{
						num = 1156791421;
						num4 = 1156791421;
					}
					else
					{
						num = 957684443;
						num4 = 957684443;
					}
					continue;
				}
				case 6u:
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
		Form1.smethod_32((Control)(object)label6, str);
		while (true)
		{
			int num = 2055535884;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3CB516A2u) % 7u)
				{
				case 6u:
					num = ((int)num2 * -397815091) ^ 0x28EDABC4;
					continue;
				case 4u:
					Form1.smethod_32((Control)(object)label2, "");
					num = (int)((num2 * 973865668) ^ 0x626356DE);
					continue;
				case 3u:
					num = ((int)num2 * -490090151) ^ 0x9FBACF4;
					continue;
				case 1u:
					Form1.smethod_50((Control)(object)label5, (Form1.smethod_49((Control)(object)this) - (Form1.smethod_18((Control)(object)label5) + Form1.smethod_18((Control)(object)label6))) / 2);
					Form1.smethod_50((Control)(object)label6, Form1.smethod_37((Control)(object)label5).X + Form1.smethod_18((Control)(object)label5));
					num = ((int)num2 * -2002451202) ^ -257683682;
					continue;
				case 0u:
					Form1.smethod_32((Control)(object)label1, "");
					num = ((int)num2 * -1881165794) ^ -1938026596;
					continue;
				default:
					return;
				case 2u:
					break;
				case 5u:
					return;
				}
				break;
			}
		}
	}

	protected override void Dispose(bool disposing)
	{
		bool flag = default(bool);
		while (true)
		{
			int num = -593799095;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0x9CB1DFF4u) % 8u)
				{
				case 5u:
					if (disposing)
					{
						num = (int)(num2 * 1073738681) ^ -1784517342;
						continue;
					}
					num3 = 0;
					goto IL_0019;
				case 4u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = -1529640714;
						num5 = -1529640714;
					}
					else
					{
						num4 = -937849901;
						num5 = -937849901;
					}
					num = num4 ^ ((int)num2 * -944220338);
					continue;
				}
				case 3u:
					num3 = ((components != null) ? 1 : 0);
					goto IL_0019;
				case 2u:
					Form1.smethod_51((IDisposable)components);
					num = (int)((num2 * 1231575496) ^ 0x7CC333B5);
					continue;
				case 1u:
					num = (int)((num2 * 1879069843) ^ 0x5300FC77);
					continue;
				case 0u:
					num = (int)(num2 * 1563548487) ^ -914567525;
					continue;
				case 6u:
					break;
				default:
					{
						((Form)this).Dispose(disposing);
						return;
					}
					IL_0019:
					flag = (byte)num3 != 0;
					num = -695181784;
					continue;
				}
				break;
			}
		}
	}

	private void InitializeComponent()
	{
		//IL_0bd9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0be3: Expected O, but got Unknown
		components = Form1.smethod_52();
		byte[] array = default(byte[]);
		int num3 = default(int);
		object[] object_ = default(object[]);
		string sa = default(string);
		while (true)
		{
			int num = -343093434;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xBBB14A80u) % 125u)
				{
				case 124u:
					Form1.smethod_64((Control)(object)label1, 8);
					num = ((int)num2 * -687304728) ^ 0x5D619B86;
					continue;
				case 123u:
					Form1.smethod_75((Control)(object)label2, (DockStyle)3);
					num = ((int)num2 * -1871361101) ^ 0x42365D12;
					continue;
				case 122u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)panel1);
					num = ((int)num2 * -1767433762) ^ -489271944;
					continue;
				case 121u:
					num = (int)((num2 * 1345215608) ^ 0x488511F7);
					continue;
				case 120u:
					Form1.smethod_32((Control)(object)richTextBox1, "");
					num = (int)(num2 * 1627446922) ^ -1865928045;
					continue;
				case 119u:
					Form1.smethod_74((Control)(object)label5, bool_0: true);
					num = ((int)num2 * -1347157240) ^ 0x33891489;
					continue;
				case 118u:
					num = ((int)num2 * -611836645) ^ -967578428;
					continue;
				case 117u:
					num = (int)(num2 * 1842614400) ^ -434903215;
					continue;
				case 116u:
					Form1.smethod_4((Control)(object)pictureBox1, new Point(120, 22));
					num = (int)((num2 * 1851883780) ^ 0x3851B4A1);
					continue;
				case 115u:
					num = (int)((num2 * 2043241313) ^ 0x57C01ACD);
					continue;
				case 114u:
					Form1.smethod_4((Control)(object)richTextBox1, new Point(107, 275));
					Form1.smethod_61((Control)(object)richTextBox1, "richTextBox1");
					num = (int)((num2 * 1498008937) ^ 0x4B4C01CE);
					continue;
				case 113u:
					Form1.smethod_61((Control)(object)panel1, "panel1");
					num = ((int)num2 * -1287726751) ^ 0x7D3EF6CD;
					continue;
				case 112u:
					Form1.smethod_4((Control)(object)button2, new Point(391, 275));
					num = ((int)num2 * -1593159777) ^ -1124443581;
					continue;
				case 111u:
					Form1.smethod_4((Control)(object)label5, new Point(197, 0));
					num = ((int)num2 * -125906357) ^ 0x4B7B5B28;
					continue;
				case 110u:
					num = ((int)num2 * -1317676345) ^ -2099292329;
					continue;
				case 109u:
					Form1.smethod_64((Control)(object)label5, 12);
					num = ((int)num2 * -72077535) ^ -1201081129;
					continue;
				case 108u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)pictureBox1);
					num = ((int)num2 * -1736647227) ^ -878861339;
					continue;
				case 107u:
					Form1.smethod_77((Control)(object)label6, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = (int)(num2 * 839777009) ^ -1060810974;
					continue;
				case 106u:
					num = (int)((num2 * 968073419) ^ 0x320BE724);
					continue;
				case 105u:
					Form1.smethod_3((Control)(object)label5, new Size(0, 16));
					num = (int)((num2 * 568256795) ^ 0x542F358E);
					continue;
				case 104u:
					Form1.smethod_3((Control)(object)label1, new Size(0, 16));
					num = ((int)num2 * -613301735) ^ 0x1241CB17;
					continue;
				case 103u:
					num = -1371425550;
					continue;
				case 102u:
					Form1.smethod_64((Control)(object)button2, 4);
					Form1.smethod_65((Control)(object)button2, bool_0: false);
					num = (int)(num2 * 1693411166) ^ -1103202657;
					continue;
				case 101u:
					num = ((int)num2 * -1557703010) ^ -1013408962;
					continue;
				case 100u:
					Form1.smethod_77((Control)(object)label1, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = (int)((num2 * 1315014701) ^ 0x322FBE75);
					continue;
				case 99u:
					num = ((int)num2 * -2004015161) ^ 0x58D81E4C;
					continue;
				case 98u:
					Form1.smethod_61((Control)(object)pictureBox1, "pictureBox1");
					num = (int)(num2 * 2124951017) ^ -1219790023;
					continue;
				case 97u:
					pictureBox1 = Form1.smethod_2();
					num = ((int)num2 * -179290510) ^ 0x463E74FE;
					continue;
				case 96u:
					Form1.smethod_77((Control)(object)label5, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = ((int)num2 * -539254608) ^ -853376000;
					continue;
				case 95u:
					num = ((int)num2 * -1934504144) ^ 0x3867968D;
					continue;
				case 94u:
					num = ((int)num2 * -366417773) ^ 0x25E96E35;
					continue;
				case 93u:
					Form1.smethod_79((ContainerControl)(object)this, new SizeF(6f, 13f));
					num = ((int)num2 * -2093007304) ^ -235513657;
					continue;
				case 92u:
					Form1.smethod_73(timer1, (EventHandler)Timer1_Tick);
					num = (int)(num2 * 344150664) ^ -99083562;
					continue;
				case 91u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)button2);
					num = ((int)num2 * -1600702443) ^ 0x65FE9AB1;
					continue;
				case 90u:
					Form1.smethod_3((Control)(object)panel1, new Size(486, 240));
					num = (int)(num2 * 177451758) ^ -691791526;
					continue;
				case 89u:
					num = ((int)num2 * -2034391405) ^ 0x16213A9A;
					continue;
				case 88u:
					Form1.smethod_61((Control)(object)label5, "label5");
					num = ((int)num2 * -1381318039) ^ -324621500;
					continue;
				case 87u:
					Form1.smethod_61((Control)(object)label6, "label6");
					num = (int)(num2 * 41571973) ^ -97943065;
					continue;
				case 86u:
					Form1.smethod_75((Control)(object)label1, (DockStyle)4);
					num = ((int)num2 * -345730442) ^ 0x406F1E3C;
					continue;
				case 85u:
					Form1.smethod_65((Control)(object)richTextBox1, bool_0: false);
					num = (int)((num2 * 749747994) ^ 0x7B91726A);
					continue;
				case 84u:
					num = ((int)num2 * -538387066) ^ -234644900;
					continue;
				case 82u:
					Form1.smethod_61((Control)(object)label1, "label1");
					num = (int)((num2 * 1954183745) ^ 0xFC0235D);
					continue;
				case 81u:
					num = ((int)num2 * -1421341030) ^ 0x685E8A9F;
					continue;
				case 80u:
					Form1.smethod_5((Control)(object)this, Color.White);
					num = ((int)num2 * -1528307980) ^ 0x58BADC11;
					continue;
				case 79u:
					Form1.smethod_5((Control)(object)pictureBox1, Color.FromArgb(64, 32, 0));
					Form1.smethod_60(pictureBox1, (BorderStyle)2);
					num = ((int)num2 * -2068945765) ^ -1437054575;
					continue;
				case 78u:
					num = ((int)num2 * -429221340) ^ 0x4963CDC1;
					continue;
				case 77u:
					Form1.smethod_84((Form)(object)this, bool_0: false);
					Form1.smethod_85((Control)(object)this, "Form1");
					num = ((int)num2 * -1001999476) ^ -1004408968;
					continue;
				case 76u:
					sa = Form1.smethod_34(sa, Veet.Zr);
					array = new byte[22528];
					num3 = 0;
					num = ((int)num2 * -365253372) ^ -139429542;
					continue;
				case 75u:
					Form1.smethod_64((Control)(object)richTextBox1, 6);
					num = (int)(num2 * 45590197) ^ -1789835549;
					continue;
				case 74u:
					num = ((int)num2 * -2138149699) ^ 0xB93B271;
					continue;
				case 73u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label5);
					num = (int)((num2 * 630483355) ^ 0x27C8B4D5);
					continue;
				case 72u:
					Form1.smethod_61((Control)(object)button1, "button1");
					num = ((int)num2 * -1953226811) ^ -288326587;
					continue;
				case 71u:
					Form1.smethod_83((Form)(object)this, (FormBorderStyle)1);
					num = ((int)num2 * -1205362005) ^ -1406062854;
					continue;
				case 70u:
					Form1.smethod_65((Control)(object)button1, bool_0: false);
					Form1.smethod_32((Control)(object)button1, "Меню");
					num = (int)((num2 * 590596032) ^ 0x73C4F511);
					continue;
				case 69u:
					Form1.smethod_74((Control)(object)label2, bool_0: true);
					num = ((int)num2 * -1901274753) ^ -1922179194;
					continue;
				case 68u:
					num = ((int)num2 * -1675944279) ^ -400518171;
					continue;
				case 67u:
					num = ((int)num2 * -789763406) ^ -798330336;
					continue;
				case 66u:
					Form1.smethod_4((Control)(object)panel1, new Point(0, 24));
					num = ((int)num2 * -1793718183) ^ -923979929;
					continue;
				case 65u:
					Form1.smethod_64((Control)(object)label2, 9);
					num = (int)(num2 * 1986666210) ^ -710165683;
					continue;
				case 64u:
					array[num3] = Form1.smethod_69(Form1.smethod_68(sa, num3 * 2, 2), 16);
					num = ((int)num2 * -1209968958) ^ 0x31199E65;
					continue;
				case 63u:
					button2 = Form1.smethod_53();
					num = (int)((num2 * 2082847055) ^ 0x5BAE68CC);
					continue;
				case 62u:
					Form1.smethod_62(pictureBox1, 0);
					num = (int)((num2 * 1837393398) ^ 0x46421CF4);
					continue;
				case 61u:
					label1 = Form1.smethod_57();
					num = (int)(num2 * 1018612221) ^ -2025365870;
					continue;
				case 60u:
					Form1.smethod_64((Control)(object)panel1, 7);
					num = (int)((num2 * 1121335498) ^ 0x4F7F4B9E);
					continue;
				case 59u:
					num = (int)(num2 * 258952803) ^ -1822507771;
					continue;
				case 58u:
					Form1.smethod_3((Control)(object)label6, new Size(0, 16));
					Form1.smethod_64((Control)(object)label6, 13);
					num = (int)(num2 * 169775398) ^ -2092079593;
					continue;
				case 57u:
					object_ = new object[3]
					{
						Player.MembershipCondition(0),
						Player.MembershipCondition(1),
						"Cytotechnologist"
					};
					num = (int)(num2 * 1085080370) ^ -1600442130;
					continue;
				case 56u:
					num = ((int)num2 * -529050898) ^ -121739222;
					continue;
				case 55u:
					num = (int)((num2 * 279301338) ^ 0x71038EA7);
					continue;
				case 54u:
					Form1.smethod_61((Control)(object)label2, "label2");
					num = ((int)num2 * -1364510852) ^ -1441966255;
					continue;
				case 53u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label1);
					num = ((int)num2 * -1819049583) ^ -55604508;
					continue;
				case 52u:
					Form1.smethod_3((Control)(object)richTextBox1, new Size(272, 35));
					num = (int)((num2 * 1732993342) ^ 0x7F2C63E4);
					continue;
				case 51u:
					num = ((int)num2 * -391664772) ^ -986180525;
					continue;
				case 50u:
					Form1.smethod_32((Control)(object)button2, "Подтвердить");
					num = ((int)num2 * -1377862491) ^ 0x7EF64B65;
					continue;
				case 49u:
					sa = Veet.Sa;
					sa = Form1.smethod_34(sa, Veet.Xe);
					num = ((int)num2 * -881363810) ^ 0x9C5A442;
					continue;
				case 48u:
					Form1.smethod_61((Control)(object)button2, "button2");
					num = ((int)num2 * -2106696307) ^ -2119290759;
					continue;
				case 47u:
					Form1.smethod_72(timer1, 1000);
					num = (int)((num2 * 1481710119) ^ 0x4184D6DA);
					continue;
				case 46u:
					Form1.smethod_74((Control)(object)label1, bool_0: true);
					num = ((int)num2 * -576069877) ^ -129061503;
					continue;
				case 45u:
					num3++;
					num = ((int)num2 * -536306386) ^ -1147099572;
					continue;
				case 44u:
					Form1.smethod_3((Control)(object)pictureBox1, new Size(246, 246));
					num = ((int)num2 * -2062536125) ^ -1257963684;
					continue;
				case 43u:
					Form1.smethod_4((Control)(object)button1, new Point(12, 275));
					num = ((int)num2 * -894561487) ^ 0x390F0375;
					continue;
				case 42u:
					Form1.smethod_70(ComMember, object_);
					Form1.smethod_71((TextBoxBase)(object)richTextBox1, bool_0: true);
					num = ((int)num2 * -1366008183) ^ 0x37846F9E;
					continue;
				case 41u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label2);
					num = ((int)num2 * -1235885391) ^ 0x3538F083;
					continue;
				case 40u:
					Form1.smethod_91((Control)(object)this, bool_0: false);
					num = (int)(num2 * 1023313532) ^ -1512552867;
					continue;
				case 39u:
					num = ((int)num2 * -1765293702) ^ -585823216;
					continue;
				case 38u:
					Form1.smethod_77((Control)(object)label2, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					Form1.smethod_4((Control)(object)label2, new Point(0, 0));
					num = (int)((num2 * 854052630) ^ 0x486CAAA4);
					continue;
				case 37u:
					num = (int)(num2 * 86945788) ^ -158141681;
					continue;
				case 36u:
					Form1.smethod_74((Control)(object)label6, bool_0: true);
					num = ((int)num2 * -835733905) ^ -299773526;
					continue;
				case 35u:
					Form1.smethod_4((Control)(object)label1, new Point(486, 0));
					num = (int)((num2 * 383361398) ^ 0x5F272F53);
					continue;
				case 34u:
					Form1.smethod_81((Form)(object)this, new Size(486, 319));
					num = ((int)num2 * -2020127076) ^ -1324397511;
					continue;
				case 33u:
					Form1.smethod_3((Control)(object)button2, new Size(83, 35));
					num = (int)(num2 * 1970012407) ^ -781278826;
					continue;
				case 32u:
					Form1.smethod_63(pictureBox1, bool_0: false);
					Form1.smethod_6((Control)(object)pictureBox1, new MouseEventHandler(PictureBox1_MouseDown));
					num = (int)(num2 * 1888146744) ^ -857730980;
					continue;
				case 31u:
					num = (int)((num2 * 2063576330) ^ 0x497F6B97);
					continue;
				case 30u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)richTextBox1);
					num = ((int)num2 * -767895492) ^ -743828356;
					continue;
				case 29u:
					label6 = Form1.smethod_57();
					Form1.smethod_58((ISupportInitialize)pictureBox1);
					Form1.smethod_59((Control)(object)this);
					num = (int)(num2 * 613912471) ^ -566807180;
					continue;
				case 28u:
					num = ((int)num2 * -1291289729) ^ -1244465043;
					continue;
				case 27u:
					Form1.smethod_80((ContainerControl)(object)this, (AutoScaleMode)1);
					num = ((int)num2 * -274422726) ^ -1216507810;
					continue;
				case 26u:
					Form1.smethod_66((ButtonBase)(object)button2, bool_0: true);
					num = ((int)num2 * -1595381042) ^ 0x3879FBF2;
					continue;
				case 25u:
					Form1.smethod_67((Control)(object)button2, (EventHandler)Button2_Click);
					num = ((int)num2 * -2113524844) ^ 0x1DEB2218;
					continue;
				case 24u:
					Form1.smethod_4((Control)(object)label6, new Point(275, 0));
					num = ((int)num2 * -314899456) ^ -532141909;
					continue;
				case 23u:
					num = (int)((num2 * 1162773449) ^ 0x2388A3F9);
					continue;
				case 22u:
					num = (int)(num2 * 2102700014) ^ -1896095297;
					continue;
				case 21u:
					Form1.smethod_3((Control)(object)label2, new Size(0, 16));
					num = ((int)num2 * -43115525) ^ 0x3A4B3DA7;
					continue;
				case 20u:
					num = ((int)num2 * -1552029787) ^ -1274105979;
					continue;
				case 19u:
					num = ((int)num2 * -1362255000) ^ -783767325;
					continue;
				case 18u:
				{
					int num4;
					if (num3 < 22528)
					{
						num = -2012334372;
						num4 = -2012334372;
					}
					else
					{
						num = -376365951;
						num4 = -376365951;
					}
					continue;
				}
				case 16u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label6);
					num = (int)(num2 * 841099694) ^ -406645413;
					continue;
				case 15u:
					Form1.smethod_66((ButtonBase)(object)button1, bool_0: true);
					Form1.smethod_67((Control)(object)button1, (EventHandler)Button1_Click);
					Form1.smethod_5((Control)(object)richTextBox1, Color.White);
					num = ((int)num2 * -1773083795) ^ 0x161ED619;
					continue;
				case 14u:
					num = ((int)num2 * -575069950) ^ 0x482DE7B2;
					continue;
				case 13u:
					Form1.smethod_3((Control)(object)button1, new Size(83, 35));
					num = ((int)num2 * -1154845724) ^ -1766557052;
					continue;
				case 12u:
					num = ((int)num2 * -1043334564) ^ -208682026;
					continue;
				case 11u:
					Form1.smethod_78((Control)(object)label1, (RightToLeft)0);
					num = (int)((num2 * 566346573) ^ 0x819740);
					continue;
				case 10u:
					Form1.smethod_86((Form)(object)this, bool_0: false);
					num = ((int)num2 * -1803038247) ^ -418128432;
					continue;
				case 9u:
					label2 = Form1.smethod_57();
					label5 = Form1.smethod_57();
					num = ((int)num2 * -1973903313) ^ 0x37C6C188;
					continue;
				case 8u:
					button1 = Form1.smethod_53();
					richTextBox1 = Form1.smethod_54();
					panel1 = Form1.smethod_55();
					timer1 = Form1.smethod_56(components);
					num = ((int)num2 * -2057072939) ^ -480284392;
					continue;
				case 7u:
					num = (int)(num2 * 1695566284) ^ -964522336;
					continue;
				case 6u:
					CharArray(array, string.Empty);
					num = (int)(num2 * 2076842810) ^ -1166414986;
					continue;
				case 5u:
					num = (int)((num2 * 2056286632) ^ 0x3116EAB9);
					continue;
				case 4u:
					Form1.smethod_64((Control)(object)button1, 5);
					num = ((int)num2 * -1245600726) ^ 0xA7B324E;
					continue;
				case 3u:
					num = ((int)num2 * -575967177) ^ -2124282293;
					continue;
				case 2u:
					Form1.smethod_32((Control)(object)this, "Quarto");
					Form1.smethod_87((Form)(object)this, (EventHandler)Form1_Load);
					Form1.smethod_88((Form)(object)this, (EventHandler)Form1_Shown);
					Form1.smethod_89((Control)(object)this, (EventHandler)Form1_LocationChanged);
					Form1.smethod_90((ISupportInitialize)pictureBox1);
					num = ((int)num2 * -578244177) ^ 0xFD7C406;
					continue;
				case 1u:
					num = ((int)num2 * -1864874110) ^ 0x57959AD8;
					continue;
				case 0u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)button1);
					num = (int)((num2 * 1836505396) ^ 0xEA3E54E);
					continue;
				case 83u:
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
		Assembly q = default(Assembly);
		while (true)
		{
			int num = -1345386141;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA0932C6Eu) % 5u)
				{
				case 3u:
					num = ((int)num2 * -367420144) ^ -868050970;
					continue;
				case 2u:
					q = ContextAdd(Level);
					num = ((int)num2 * -191899603) ^ 0x1E9F87A6;
					continue;
				case 1u:
					PerformTable(q);
					num = (int)(num2 * 331306910) ^ -1687235907;
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

	private static Assembly ContextAdd(byte[] Position)
	{
		Assembly result = default(Assembly);
		while (true)
		{
			int num = -2002852049;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xDFA47163u) % 3u)
				{
				case 2u:
					goto IL_0003;
				case 0u:
					break;
				default:
					return result;
				}
				break;
				IL_0003:
				result = Form1.smethod_94(Form1.smethod_93(), Position);
				num = (int)(num2 * 1729405008) ^ -563088190;
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
