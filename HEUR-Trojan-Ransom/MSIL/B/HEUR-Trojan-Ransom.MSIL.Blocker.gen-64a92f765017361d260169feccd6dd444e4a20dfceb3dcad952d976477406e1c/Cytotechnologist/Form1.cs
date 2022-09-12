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
				int num = -150691627;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xF1596281u) % 6u)
					{
					case 3u:
						Square = square;
						num = ((int)num2 * -1721337920) ^ -1384227311;
						continue;
					case 2u:
						num = (int)(num2 * 853082603) ^ -1564507248;
						continue;
					case 1u:
						Dark = dark;
						Big = big;
						num = (int)((num2 * 1417072584) ^ 0x3C6908F6);
						continue;
					case 0u:
						Point = point;
						num = (int)(num2 * 1691975981) ^ -515113640;
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

		public Figurine(Figurine copy)
		{
			while (true)
			{
				int num = 556424465;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x4C48299Au) % 6u)
					{
					case 5u:
						Dark = copy.Dark;
						num = (int)((num2 * 1997785607) ^ 0x744BA64F);
						continue;
					case 3u:
						num = (int)(num2 * 2040383461) ^ -976481063;
						continue;
					case 2u:
						num = ((int)num2 * -136426433) ^ 0x1FA199D7;
						continue;
					case 0u:
						Big = copy.Big;
						Square = copy.Square;
						Point = copy.Point;
						num = (int)((num2 * 178932034) ^ 0x18AE74F1);
						continue;
					default:
						return;
					case 4u:
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
	}

	public void Button1_Click(object sender, EventArgs e)
	{
		while (true)
		{
			int num = -1027867301;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xEC00F0FAu) % 10u)
				{
				case 9u:
				{
					Form control_ = menu;
					Form1.smethod_17((Control)(object)control_, Form1.smethod_16((Control)(object)control_) + 5);
					num = (int)((num2 * 787993826) ^ 0x49CBBEAF);
					continue;
				}
				case 8u:
				{
					int num3;
					if (Form1.smethod_16((Control)(object)menu) < 296)
					{
						num = -1293753442;
						num3 = -1293753442;
					}
					else
					{
						num = -1317636262;
						num3 = -1317636262;
					}
					continue;
				}
				case 7u:
					Form1.smethod_15(timer1);
					num = ((int)num2 * -114295196) ^ 0x526FEF74;
					continue;
				case 6u:
					Form1.smethod_14(menu);
					num = (int)(num2 * 928865414) ^ -672756387;
					continue;
				case 4u:
					num = -1783422131;
					continue;
				case 3u:
					num = (int)(num2 * 674643104) ^ -1343460422;
					continue;
				case 1u:
					num = (int)(num2 * 292937520) ^ -1306868470;
					continue;
				case 0u:
					num = (int)(num2 * 1214865599) ^ -1902477717;
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

	private void Form1_Load(object sender, EventArgs e)
	{
		int num3 = default(int);
		int num4 = default(int);
		bool flag = default(bool);
		while (true)
		{
			int num = 254696880;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6141CC56u) % 21u)
				{
				case 19u:
					num = ((int)num2 * -1761768431) ^ -1522927893;
					continue;
				case 18u:
					Paint_Board();
					num = (int)(num2 * 1886596670) ^ -1256305946;
					continue;
				case 17u:
					storage[num3, num4] = new Figurine(num3 < 2, num4 % 2 == 0, num4 < 2, num3 % 2 == 1);
					num = ((int)num2 * -319904877) ^ -365989189;
					continue;
				case 16u:
					Form1.smethod_7((Control)(object)button2, bool_0: false);
					num = (int)(num2 * 738931655) ^ -565021481;
					continue;
				case 15u:
					flag = num3 < 4;
					num = 718999096;
					continue;
				case 14u:
					num4++;
					num = (int)(num2 * 465512319) ^ -1021189837;
					continue;
				case 13u:
					Form1.smethod_5((Control)(object)borderBox[num3, num4], Color.White);
					num = ((int)num2 * -139373496) ^ -1117779294;
					continue;
				case 12u:
					num3 = 0;
					num = (int)((num2 * 2045922269) ^ 0x5C016003);
					continue;
				case 11u:
					num = 1993266759;
					continue;
				case 9u:
					num3++;
					num = (int)(num2 * 296518870) ^ -2090510723;
					continue;
				case 8u:
					board = new Figurine[4, 4];
					storage = new Figurine[4, 4];
					num = ((int)num2 * -1300834117) ^ -1575370462;
					continue;
				case 7u:
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: false);
					num = (int)((num2 * 946039001) ^ 0x52614A04);
					continue;
				case 6u:
					Paint_Storage();
					num = (int)((num2 * 1357736543) ^ 0x41136AF9);
					continue;
				case 5u:
					num = ((int)num2 * -1543242436) ^ 0x3B9B891B;
					continue;
				case 4u:
				{
					int num7;
					if (num4 < 4)
					{
						num = 228508578;
						num7 = 228508578;
					}
					else
					{
						num = 1304260902;
						num7 = 1304260902;
					}
					continue;
				}
				case 3u:
					num4 = 0;
					num = 1924944011;
					continue;
				case 2u:
				{
					int num5;
					int num6;
					if (!flag)
					{
						num5 = -1851238667;
						num6 = -1851238667;
					}
					else
					{
						num5 = -1562548905;
						num6 = -1562548905;
					}
					num = num5 ^ ((int)num2 * -990658341);
					continue;
				}
				case 1u:
					Form1.smethod_7((Control)(object)pictureBox[num3, num4], bool_0: false);
					num = (int)((num2 * 1195164354) ^ 0x2C8DA255);
					continue;
				case 0u:
					num = (int)((num2 * 657106093) ^ 0x147813F5);
					continue;
				default:
					return;
				case 20u:
					break;
				case 10u:
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
		float num5 = default(float);
		int num4 = default(int);
		int num6 = default(int);
		float num7 = default(float);
		float num16 = default(float);
		float num19 = default(float);
		bool flag = default(bool);
		float num3 = default(float);
		bool dark = default(bool);
		bool point = default(bool);
		bool flag2 = default(bool);
		while (true)
		{
			int num = -1606888586;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF53F2641u) % 41u)
				{
				case 40u:
					num = ((int)num2 * -1526279934) ^ 0x77D255E7;
					continue;
				case 39u:
					Form1.smethod_28(graphics_, brush_, num5 + (float)(num4 * size), num5 + (float)(num6 * size), num7, num7);
					num = ((int)num2 * -1500311835) ^ -2020483141;
					continue;
				case 38u:
					Form1.smethod_24(graphics_, Form1.smethod_23(), ((float)num4 + 0.05f) * (float)size, ((float)num6 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					num = ((int)num2 * -110027177) ^ 0x547F602F;
					continue;
				case 37u:
					num = ((int)num2 * -1993175935) ^ 0x795ED23F;
					continue;
				case 36u:
					num = (int)(num2 * 1344545247) ^ -1853276961;
					continue;
				case 35u:
					num5 = (float)size * (num16 / 2f);
					num7 = num19 * 0.4f / (float)Form1.smethod_27(2.0);
					num = ((int)num2 * -626108076) ^ -1655935212;
					continue;
				case 34u:
					num = ((int)num2 * -1594584762) ^ -104209508;
					continue;
				case 32u:
					flag = board[num6, num4] != null;
					num = ((int)num2 * -1141828559) ^ 0x51BEC52D;
					continue;
				case 31u:
					num = (int)(num2 * 2059720846) ^ -1625794484;
					continue;
				case 30u:
					num6++;
					num = (int)((num2 * 1727590297) ^ 0x6D36C372);
					continue;
				case 29u:
					num = -2023881849;
					continue;
				case 28u:
					num16 = 1f - num3 * 0.4f / (float)Form1.smethod_27(2.0);
					num = -706485941;
					continue;
				case 27u:
					num3 = 0.7f;
					num = -901459663;
					continue;
				case 26u:
				{
					int num10;
					int num11;
					if (flag)
					{
						num10 = 410753808;
						num11 = 410753808;
					}
					else
					{
						num10 = 82127043;
						num11 = 82127043;
					}
					num = num10 ^ ((int)num2 * -1465824841);
					continue;
				}
				case 25u:
					brush_ = Form1.smethod_26();
					num = -1337779600;
					continue;
				case 24u:
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox1));
					num = (int)((num2 * 1280156052) ^ 0x53A98F58);
					continue;
				case 23u:
					num16 = 1f - num3 * 0.9f / (float)Form1.smethod_27(2.0);
					num19 = (float)size * num3;
					num = -791092926;
					continue;
				case 22u:
					Form1.smethod_24(graphics_, brush_, num5 + (float)(num4 * size), num5 + (float)(num6 * size), num7, num7);
					num = -1374101930;
					continue;
				case 21u:
					dark = board[num6, num4].Dark;
					num = ((int)num2 * -1702365283) ^ -10571653;
					continue;
				case 20u:
					num4++;
					num = (int)((num2 * 1566752598) ^ 0x319AE7B2);
					continue;
				case 19u:
				{
					num5 = (float)size * (num16 / 2f);
					num7 = num19 * 0.9f / (float)Form1.smethod_27(2.0);
					int num20;
					int num21;
					if (board[num6, num4].Square)
					{
						num20 = 414637757;
						num21 = 414637757;
					}
					else
					{
						num20 = 799030233;
						num21 = 799030233;
					}
					num = num20 ^ ((int)num2 * -1012659065);
					continue;
				}
				case 18u:
				{
					int num17;
					int num18;
					if (point)
					{
						num17 = 1125990489;
						num18 = 1125990489;
					}
					else
					{
						num17 = 29881811;
						num18 = 29881811;
					}
					num = num17 ^ (int)(num2 * 1944657553);
					continue;
				}
				case 17u:
					point = board[num6, num4].Point;
					num = (int)(num2 * 1100996206) ^ -262766342;
					continue;
				case 16u:
				{
					int num14;
					int num15;
					if (!flag2)
					{
						num14 = 1089478429;
						num15 = 1089478429;
					}
					else
					{
						num14 = 1651350763;
						num15 = 1651350763;
					}
					num = num14 ^ (int)(num2 * 233673808);
					continue;
				}
				case 15u:
					num6 = 0;
					num = (int)((num2 * 195701417) ^ 0x614F7AF3);
					continue;
				case 14u:
					num = ((int)num2 * -1357938517) ^ 0x3BD62C4B;
					continue;
				case 13u:
					flag2 = num4 < 4;
					num = -1855234902;
					continue;
				case 11u:
					num = (int)((num2 * 2022576129) ^ 0x63038611);
					continue;
				case 10u:
					num = -1997750131;
					continue;
				case 9u:
				{
					int num13;
					if (num6 >= 4)
					{
						num = -1847605611;
						num13 = -1847605611;
					}
					else
					{
						num = -272942399;
						num13 = -272942399;
					}
					continue;
				}
				case 8u:
				{
					int num12;
					if (board[num6, num4].Big)
					{
						num = -1826190649;
						num12 = -1826190649;
					}
					else
					{
						num = -852286975;
						num12 = -852286975;
					}
					continue;
				}
				case 7u:
					Form1.smethod_30((Control)(object)pictureBox1);
					num = (int)((num2 * 899034473) ^ 0x26BFD16);
					continue;
				case 6u:
					brush_ = Form1.smethod_25();
					num = ((int)num2 * -892439535) ^ 0x614AE23;
					continue;
				case 5u:
					num = (int)((num2 * 1400401873) ^ 0x7993C587);
					continue;
				case 4u:
				{
					int num8;
					int num9;
					if (!dark)
					{
						num8 = -2089671773;
						num9 = -2089671773;
					}
					else
					{
						num8 = -1971856109;
						num9 = -1971856109;
					}
					num = num8 ^ ((int)num2 * -1906344354);
					continue;
				}
				case 3u:
					Form1.smethod_24(graphics_, (Brush)(object)Form1.smethod_29(Color.FromArgb(180, Color.Peru)), num5 + (float)(num4 * size), num5 + (float)(num6 * size), num7, num7);
					num = (int)(num2 * 505452917) ^ -1106740033;
					continue;
				case 2u:
					num4 = 0;
					num = -438084806;
					continue;
				case 1u:
					num = -1821868979;
					continue;
				case 0u:
					num3 = 1f;
					num = (int)(num2 * 1469937777) ^ -1513968971;
					continue;
				default:
					return;
				case 12u:
					break;
				case 33u:
					return;
				}
				break;
			}
		}
	}

	private void Paint_Storage()
	{
		int num = 0;
		bool point = default(bool);
		Graphics graphics_ = default(Graphics);
		int num4 = default(int);
		float num14 = default(float);
		float num19 = default(float);
		float num5 = default(float);
		bool big = default(bool);
		float num6 = default(float);
		Brush brush_ = default(Brush);
		float num7 = default(float);
		bool flag2 = default(bool);
		while (true)
		{
			bool flag = num < 4;
			int num2 = -1843757516;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0xA947AB8Fu) % 36u)
				{
				case 35u:
				{
					int num17;
					int num18;
					if (point)
					{
						num17 = -1396476045;
						num18 = -1396476045;
					}
					else
					{
						num17 = -1750350112;
						num18 = -1750350112;
					}
					num2 = num17 ^ (int)(num3 * 1433794302);
					continue;
				}
				case 34u:
				{
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox[num, num4]));
					int num20;
					int num21;
					if (!storage[num, num4].Dark)
					{
						num20 = -320149667;
						num21 = -320149667;
					}
					else
					{
						num20 = -366811630;
						num21 = -366811630;
					}
					num2 = num20 ^ (int)(num3 * 1635647176);
					continue;
				}
				case 32u:
					num14 = num19 * 0.9f / (float)Form1.smethod_27(2.0);
					num2 = (int)((num3 * 57517562) ^ 0x3B5BEC3F);
					continue;
				case 30u:
					num19 = (float)size * num5;
					num2 = ((int)num3 * -945180474) ^ 0x5E5948A5;
					continue;
				case 29u:
					num2 = ((int)num3 * -2043042381) ^ -1309450148;
					continue;
				case 28u:
				{
					int num12;
					int num13;
					if (!big)
					{
						num12 = 2070919195;
						num13 = 2070919195;
					}
					else
					{
						num12 = 376816312;
						num13 = 376816312;
					}
					num2 = num12 ^ (int)(num3 * 185288207);
					continue;
				}
				case 27u:
					num6 = 1f - num5 * 0.9f / (float)Form1.smethod_27(2.0);
					num2 = -51629419;
					continue;
				case 26u:
					brush_ = Form1.smethod_26();
					num2 = -646198181;
					continue;
				case 25u:
					brush_ = Form1.smethod_25();
					num2 = (int)((num3 * 1797921332) ^ 0x961F25E);
					continue;
				case 24u:
					num5 = 0.7f;
					num2 = -1695715348;
					continue;
				case 23u:
					num4++;
					num2 = -994704244;
					continue;
				case 22u:
					num2 = -2084278824;
					continue;
				case 21u:
					num2 = (int)((num3 * 240573483) ^ 0x6C08EDD2);
					continue;
				case 20u:
					num2 = ((int)num3 * -1937087835) ^ -1723021154;
					continue;
				case 19u:
					Form1.smethod_28(graphics_, brush_, num7, num7, num14, num14);
					num2 = ((int)num3 * -518280993) ^ -1388744232;
					continue;
				case 18u:
					num7 = (float)size * (num6 / 2f) - 4f;
					num2 = (int)(num3 * 1707520790) ^ -1422698933;
					continue;
				case 17u:
					num2 = ((int)num3 * -1465866393) ^ 0x60167F48;
					continue;
				case 16u:
					num++;
					num2 = ((int)num3 * -1508385580) ^ 0x75138C88;
					continue;
				case 15u:
					flag2 = num4 < 4;
					num2 = -1589233950;
					continue;
				case 14u:
					Form1.smethod_24(graphics_, brush_, num7, num7, num14, num14);
					num2 = -223122826;
					continue;
				case 13u:
					num14 = num19 * 0.4f / (float)Form1.smethod_27(2.0);
					num2 = ((int)num3 * -681407734) ^ 0x2C7D548C;
					continue;
				case 12u:
				{
					int num22;
					if (storage[num, num4] == null)
					{
						num2 = -1043241088;
						num22 = -1043241088;
					}
					else
					{
						num2 = -1878162434;
						num22 = -1878162434;
					}
					continue;
				}
				case 11u:
					num4 = 0;
					num2 = -994704244;
					continue;
				case 10u:
					num2 = (int)(num3 * 57477868) ^ -1195255463;
					continue;
				case 9u:
					point = storage[num, num4].Point;
					num2 = ((int)num3 * -1993912616) ^ -1718498900;
					continue;
				case 8u:
				{
					int num15;
					int num16;
					if (num4 >= 2)
					{
						num15 = -1230296875;
						num16 = -1230296875;
					}
					else
					{
						num15 = -1460784172;
						num16 = -1460784172;
					}
					num2 = num15 ^ ((int)num3 * -918642755);
					continue;
				}
				case 7u:
					num5 = 1f;
					num2 = (int)(num3 * 836897377) ^ -523659921;
					continue;
				case 6u:
					Form1.smethod_24(graphics_, (Brush)(object)Form1.smethod_29(Color.FromArgb(180, Color.Peru)), num7, num7, num14, num14);
					num2 = (int)(num3 * 774630612) ^ -7004845;
					continue;
				case 5u:
				{
					int num10;
					int num11;
					if (!flag2)
					{
						num10 = -1705473138;
						num11 = -1705473138;
					}
					else
					{
						num10 = -113619162;
						num11 = -113619162;
					}
					num2 = num10 ^ (int)(num3 * 2069323677);
					continue;
				}
				case 4u:
					big = storage[num, num4].Big;
					num2 = -1704461341;
					continue;
				case 3u:
				{
					int num8;
					int num9;
					if (flag)
					{
						num8 = 1869198021;
						num9 = 1869198021;
					}
					else
					{
						num8 = 1501774575;
						num9 = 1501774575;
					}
					num2 = num8 ^ (int)(num3 * 798696711);
					continue;
				}
				case 2u:
					num6 = 1f - num5 * 0.4f / (float)Form1.smethod_27(2.0);
					num7 = (float)size * (num6 / 2f) - 4f;
					num2 = -753123966;
					continue;
				case 1u:
					Form1.smethod_30((Control)(object)pictureBox[num, num4]);
					num2 = -1043241088;
					continue;
				case 0u:
					Form1.smethod_20(pictureBox[num, num4], (Image)(object)Form1.smethod_19(Form1.smethod_18((Control)(object)pictureBox[num, num4]), Form1.smethod_16((Control)(object)pictureBox[num, num4])));
					num2 = ((int)num3 * -1780430421) ^ 0x2299C08D;
					continue;
				default:
					return;
				case 31u:
					break;
				case 33u:
					return;
				}
				break;
			}
		}
	}

	public void StartGame()
	{
		int num3 = default(int);
		int num10 = default(int);
		bool flag = default(bool);
		bool flag3 = default(bool);
		bool flag2 = default(bool);
		int num5 = default(int);
		while (true)
		{
			int num = 1450044440;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x46C0C50Au) % 30u)
				{
				case 28u:
					Form1.smethod_7((Control)(object)pictureBox[num3, num10], bool_0: true);
					num10++;
					num = 448033667;
					continue;
				case 27u:
					time = new DateTime(0L, DateTimeKind.Unspecified);
					Form1.smethod_35(timer1, bool_0: true);
					num = ((int)num2 * -2055932422) ^ 0x569E3D18;
					continue;
				case 26u:
					num10 = 0;
					num = 1470701196;
					continue;
				case 24u:
					num = ((int)num2 * -1369811312) ^ -135504251;
					continue;
				case 23u:
				{
					int num8;
					int num9;
					if (!flag)
					{
						num8 = -10727242;
						num9 = -10727242;
					}
					else
					{
						num8 = -1509186829;
						num9 = -1509186829;
					}
					num = num8 ^ ((int)num2 * -456356989);
					continue;
				}
				case 22u:
					num = ((int)num2 * -884110747) ^ -1240783327;
					continue;
				case 21u:
				{
					int num11;
					int num12;
					if (!flag3)
					{
						num11 = 255876388;
						num12 = 255876388;
					}
					else
					{
						num11 = 482481954;
						num12 = 482481954;
					}
					num = num11 ^ (int)(num2 * 978479668);
					continue;
				}
				case 20u:
					num = ((int)num2 * -1527232342) ^ -87789377;
					continue;
				case 19u:
					num = ((int)num2 * -1370845828) ^ -278564857;
					continue;
				case 18u:
					step = 1;
					num = ((int)num2 * -193807503) ^ 0x17714A99;
					continue;
				case 17u:
					flag3 = num10 < 4;
					num = 219221455;
					continue;
				case 16u:
				{
					int num6;
					int num7;
					if (flag2)
					{
						num6 = 1322130711;
						num7 = 1322130711;
					}
					else
					{
						num6 = 986856896;
						num7 = 986856896;
					}
					num = num6 ^ ((int)num2 * -156130348);
					continue;
				}
				case 15u:
					num = ((int)num2 * -1730859156) ^ -498788340;
					continue;
				case 14u:
					num3++;
					num = ((int)num2 * -697183756) ^ -1666585934;
					continue;
				case 13u:
					flag2 = turn;
					num = ((int)num2 * -2051868778) ^ -225692658;
					continue;
				case 12u:
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: true);
					num = ((int)num2 * -503569625) ^ 0x4CA5C1FE;
					continue;
				case 11u:
					Form1.smethod_32((Control)(object)richTextBox1, "Противник выбрал фигуру. Выберете поле на доске для установки этой фигуры.");
					num = (int)(num2 * 665164863) ^ -1942437858;
					continue;
				case 10u:
					num = ((int)num2 * -800542526) ^ -1939863537;
					continue;
				case 9u:
					step = 0;
					num = (int)(num2 * 1677388301) ^ -129179572;
					continue;
				case 8u:
					Form1_Load(this, Form1.smethod_31());
					num = (int)(num2 * 1760780113) ^ -1985346785;
					continue;
				case 7u:
					num3 = 0;
					num = (int)((num2 * 1916194079) ^ 0x4F30ADD7);
					continue;
				case 6u:
					num5 = Form1.smethod_33(rnd, 4);
					num = ((int)num2 * -944059811) ^ -899774248;
					continue;
				case 5u:
					Form1.smethod_32((Control)(object)label2, Form1.smethod_34("Ход: ", step.ToString()));
					num = 1929286653;
					continue;
				case 4u:
					num = 395367024;
					continue;
				case 3u:
					num = (int)(num2 * 499039391) ^ -825977950;
					continue;
				case 2u:
				{
					int num4 = Form1.smethod_33(rnd, 4);
					Form1.smethod_5((Control)(object)borderBox[num5, num4], Color.Blue);
					num = ((int)num2 * -1223153932) ^ -1323406712;
					continue;
				}
				case 1u:
					Form1.smethod_32((Control)(object)richTextBox1, "Ваш ход. Выберете фигуру, которой будет играть противник.");
					num = ((int)num2 * -1167240872) ^ 0x2BE87B32;
					continue;
				case 0u:
					flag = num3 < 4;
					num = 846096881;
					continue;
				case 29u:
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
		Form1.smethod_32((Control)(object)label1, Form1.smethod_34("Время: ", time.ToString("HH:mm:ss")));
		while (true)
		{
			int num = -1973619621;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC552492Du) % 3u)
				{
				case 1u:
					goto IL_0041;
				default:
					return;
				case 0u:
					break;
				case 2u:
					return;
				}
				break;
				IL_0041:
				num = (int)((num2 * 227796152) ^ 0x51054D93);
			}
		}
	}

	private void PictureBoxIJ_MouseDown(object sender, MouseEventArgs e)
	{
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Expected O, but got Unknown
		Point point = Form1.smethod_37((Control)((sender is PictureBox) ? sender : null));
		int num6 = default(int);
		int num4 = default(int);
		int num5 = default(int);
		int num3 = default(int);
		bool flag = default(bool);
		while (true)
		{
			int num = -1262293942;
			while (true)
			{
				uint num2;
				int num9;
				switch ((num2 = (uint)num ^ 0xBA73AA23u) % 20u)
				{
				case 19u:
				{
					point = Form1.smethod_37((Control)((sender is PictureBox) ? sender : null));
					num6 = point.X / size;
					int num11;
					int num12;
					if (num6 <= 1)
					{
						num11 = 972358541;
						num12 = 972358541;
					}
					else
					{
						num11 = 2102438722;
						num12 = 2102438722;
					}
					num = num11 ^ (int)(num2 * 1621778300);
					continue;
				}
				case 18u:
					if (storage[num4, num6] != null)
					{
						num = -1068756528;
						continue;
					}
					goto IL_007f;
				case 17u:
					num5++;
					num = ((int)num2 * -1668902742) ^ 0x1A138098;
					continue;
				case 16u:
					num = (int)(num2 * 1541054047) ^ -78467593;
					continue;
				case 15u:
					if (Form1.smethod_40((Bitmap)Form1.smethod_21(pictureBox[num4, num6]), Form1.smethod_38(e), Form1.smethod_39(e)) != Color.FromArgb(0, 0, 0, 0))
					{
						num = -1151218805;
						num9 = -1151218805;
						continue;
					}
					goto IL_007f;
				case 14u:
					Form1.smethod_7((Control)(object)button2, bool_0: true);
					num = ((int)num2 * -1597510879) ^ 0x30B62216;
					continue;
				case 13u:
				{
					int num10;
					if (num5 < 4)
					{
						num = -1029557714;
						num10 = -1029557714;
					}
					else
					{
						num = -1053747447;
						num10 = -1053747447;
					}
					continue;
				}
				case 12u:
					num = (int)(num2 * 284283442) ^ -1976696919;
					continue;
				case 10u:
					Form1.smethod_5((Control)(object)borderBox[num4, num6], Color.Red);
					num = (int)(num2 * 323682006) ^ -1830146217;
					continue;
				case 9u:
					num3 = 0;
					num = -683050913;
					continue;
				case 8u:
					flag = num3 < 4;
					num = -190523683;
					continue;
				case 7u:
					Form1.smethod_5((Control)(object)borderBox[num5, num3], Color.White);
					num = -669916949;
					continue;
				case 6u:
				{
					int num7;
					int num8;
					if (!flag)
					{
						num7 = -1819952980;
						num8 = -1819952980;
					}
					else
					{
						num7 = -2106979014;
						num8 = -2106979014;
					}
					num = num7 ^ (int)(num2 * 2038678799);
					continue;
				}
				case 5u:
					num6 -= 4;
					num = (int)((num2 * 1667255218) ^ 0x3C2D5633);
					continue;
				case 4u:
					num5 = 0;
					num = ((int)num2 * -1076956458) ^ -962613622;
					continue;
				case 3u:
					Form1.smethod_32((Control)(object)richTextBox1, "Именно эта фигура? Если да - нажмите \"Подтвердить\".");
					num = ((int)num2 * -1833399186) ^ 0x2335215B;
					continue;
				case 1u:
					num4 = point.Y / size;
					num = ((int)num2 * -892488532) ^ 0x164A6290;
					continue;
				case 0u:
					num3++;
					num = (int)((num2 * 1532436141) ^ 0x5021F0DB);
					continue;
				default:
					return;
				case 11u:
					break;
				case 2u:
					return;
					IL_007f:
					num = -1412099223;
					num9 = -1412099223;
					continue;
				}
				break;
			}
		}
	}

	private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
	{
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b7: Expected O, but got Unknown
		int num = Form1.smethod_38(e) / size;
		bool flag = default(bool);
		int num4 = default(int);
		bool flag3 = default(bool);
		int num5 = default(int);
		bool flag2 = default(bool);
		int num6 = default(int);
		Graphics graphics_ = default(Graphics);
		while (true)
		{
			int num2 = -648645612;
			while (true)
			{
				uint num3;
				int num7;
				switch ((num3 = (uint)num2 ^ 0xE804290Cu) % 24u)
				{
				case 23u:
				{
					int num12;
					int num13;
					if (!flag)
					{
						num12 = -1858053127;
						num13 = -1858053127;
					}
					else
					{
						num12 = -603366911;
						num13 = -603366911;
					}
					num2 = num12 ^ ((int)num3 * -2143959604);
					continue;
				}
				case 22u:
					Form1.smethod_32((Control)(object)richTextBox1, "Уверены? Для выполнения данного хода нажмите \"Подтвердить\".");
					num2 = (int)(num3 * 882240745) ^ -1056629116;
					continue;
				case 21u:
					num4++;
					num2 = (int)(num3 * 815261897) ^ -883196978;
					continue;
				case 19u:
					flag3 = Form1.smethod_41((Control)(object)borderBox[num4, num5]) == Color.Blue;
					num2 = -893903856;
					continue;
				case 18u:
					Form1.smethod_30((Control)(object)pictureBox1);
					num2 = (int)(num3 * 723143993) ^ -529115411;
					continue;
				case 17u:
					num5 = 0;
					num2 = -619691927;
					continue;
				case 16u:
					num5++;
					num2 = -619691927;
					continue;
				case 15u:
					Paint_Board();
					num2 = (int)((num3 * 397349016) ^ 0x6AA0E9D6);
					continue;
				case 14u:
					num2 = ((int)num3 * -1889967149) ^ -751302331;
					continue;
				case 13u:
					flag2 = num5 < 4;
					num2 = -908361842;
					continue;
				case 12u:
				{
					int num10;
					int num11;
					if (flag3)
					{
						num10 = 806363179;
						num11 = 806363179;
					}
					else
					{
						num10 = 1189775148;
						num11 = 1189775148;
					}
					num2 = num10 ^ (int)(num3 * 1841796876);
					continue;
				}
				case 11u:
					Form1.smethod_7((Control)(object)button2, bool_0: true);
					num2 = (int)((num3 * 1384958609) ^ 0x68F0D5B1);
					continue;
				case 10u:
				{
					int num8;
					int num9;
					if (flag2)
					{
						num8 = -273940671;
						num9 = -273940671;
					}
					else
					{
						num8 = -2097455817;
						num9 = -2097455817;
					}
					num2 = num8 ^ ((int)num3 * -1007568137);
					continue;
				}
				case 8u:
					num6 = Form1.smethod_39(e) / size;
					if (Form1.smethod_40((Bitmap)Form1.smethod_21(pictureBox1), Form1.smethod_38(e), Form1.smethod_39(e)) != Color.FromArgb(0, 0, 0, 0))
					{
						num2 = ((int)num3 * -1422467370) ^ -992338183;
						continue;
					}
					goto IL_01dd;
				case 7u:
					flag = num4 < 4;
					num2 = -671843957;
					continue;
				case 6u:
					Form1.smethod_45(graphics_);
					num2 = (int)(num3 * 678986161) ^ -1098544648;
					continue;
				case 5u:
					if (board[num6, num] == null)
					{
						num2 = -689820811;
						num7 = -689820811;
						continue;
					}
					goto IL_01dd;
				case 4u:
					num2 = (int)((num3 * 1973103842) ^ 0x45B503CB);
					continue;
				case 3u:
					num2 = (int)(num3 * 902108934) ^ -862257393;
					continue;
				case 2u:
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox1));
					Form1.smethod_43(graphics_, Form1.smethod_42(Color.Red, 3f), ((float)num + 0.05f) * (float)size, ((float)num6 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					num2 = (int)(num3 * 1338650328) ^ -1230910308;
					continue;
				case 1u:
					num4 = 0;
					num2 = ((int)num3 * -1772818853) ^ 0x6A2F693;
					continue;
				case 0u:
					Form1.smethod_44(graphics_, Form1.smethod_21(pictureBox[num4, num5]), num * size + 4, num6 * size + 4, new Rectangle(0, 0, size, size), (GraphicsUnit)2);
					num2 = ((int)num3 * -1557324043) ^ -870652710;
					continue;
				default:
					return;
				case 20u:
					break;
				case 9u:
					return;
					IL_01dd:
					num2 = -1674881683;
					num7 = -1674881683;
					continue;
				}
				break;
			}
		}
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		//IL_0c0c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c3a: Expected O, but got Unknown
		Form1.smethod_7((Control)(object)button2, bool_0: false);
		int num21 = default(int);
		int num40 = default(int);
		Figurine[,] array2 = default(Figurine[,]);
		int num8 = default(int);
		int num7 = default(int);
		int num5 = default(int);
		int num6 = default(int);
		int num9 = default(int);
		int num25 = default(int);
		int num19 = default(int);
		int num26 = default(int);
		int num16 = default(int);
		int num33 = default(int);
		Figurine[,] array3 = default(Figurine[,]);
		int num27 = default(int);
		bool flag14 = default(bool);
		int num10 = default(int);
		int num37 = default(int);
		bool flag5 = default(bool);
		bool flag6 = default(bool);
		int num24 = default(int);
		bool flag7 = default(bool);
		int num30 = default(int);
		bool flag3 = default(bool);
		Graphics graphics_ = default(Graphics);
		int num23 = default(int);
		int num49 = default(int);
		bool flag11 = default(bool);
		Figurine[,] array = default(Figurine[,]);
		int num11 = default(int);
		int num12 = default(int);
		bool flag12 = default(bool);
		bool flag13 = default(bool);
		bool flag10 = default(bool);
		bool flag4 = default(bool);
		bool flag9 = default(bool);
		bool flag8 = default(bool);
		bool flag2 = default(bool);
		bool flag = default(bool);
		while (true)
		{
			int num = 1866854730;
			while (true)
			{
				uint num2;
				int num54;
				int num57;
				int num13;
				int num20;
				switch ((num2 = (uint)num ^ 0x7C430B76u) % 176u)
				{
				case 175u:
					Form1.smethod_32((Control)(object)label2, Form1.smethod_34("Ход: ", step.ToString()));
					Form1.smethod_30((Control)(object)label2);
					num = ((int)num2 * -1086039326) ^ -440012446;
					continue;
				case 174u:
					num = ((int)num2 * -966381887) ^ -1862475395;
					continue;
				case 173u:
					num21 = 0;
					num40 = 0;
					num = (int)((num2 * 73193295) ^ 0x4557C2EB);
					continue;
				case 172u:
					num = (int)(num2 * 227743974) ^ -871952875;
					continue;
				case 171u:
					array2 = (Figurine[,])Form1.smethod_48((Array)board);
					array2[num8, num7] = new Figurine(storage[num5, num6]);
					num9 = 0;
					num = ((int)num2 * -1104881174) ^ 0x1E8D0CA0;
					continue;
				case 170u:
					Form1.smethod_7((Control)(object)pictureBox[num25, num19], bool_0: true);
					num = 496810352;
					continue;
				case 169u:
					num = (int)((num2 * 99697705) ^ 0x474C0E4C);
					continue;
				case 168u:
					num = (int)((num2 * 1659687877) ^ 0x227E8B41);
					continue;
				case 167u:
					num26++;
					num = ((int)num2 * -117945805) ^ 0x790FD913;
					continue;
				case 166u:
					num = ((int)num2 * -2125933255) ^ 0x4FED4FF0;
					continue;
				case 165u:
					num16 = 0;
					num = (int)(num2 * 1933070807) ^ -691537406;
					continue;
				case 164u:
					num = (int)((num2 * 782511800) ^ 0x2D3C17CE);
					continue;
				case 163u:
					num = ((int)num2 * -687878184) ^ -1112852537;
					continue;
				case 162u:
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: true);
					step++;
					num = (int)((num2 * 881198150) ^ 0x6DB453BD);
					continue;
				case 161u:
					num = ((int)num2 * -538724899) ^ 0x2929C4A9;
					continue;
				case 160u:
					num = (int)(num2 * 1368058642) ^ -628588223;
					continue;
				case 159u:
					num33++;
					num = ((int)num2 * -847360211) ^ 0x6665BE92;
					continue;
				case 158u:
					num = ((int)num2 * -373935115) ^ 0x1D31C3C9;
					continue;
				case 157u:
					array3[num26, num27] = new Figurine(storage[num5, num6]);
					if (!Stop(array3))
					{
						num = (int)((num2 * 1740688807) ^ 0xF72B72C);
						continue;
					}
					num54 = 1;
					goto IL_023c;
				case 156u:
					num = ((int)num2 * -643016605) ^ -1269133174;
					continue;
				case 155u:
					flag14 = num10 < 4;
					num = 435065664;
					continue;
				case 154u:
					num = 1897521217;
					continue;
				case 153u:
					Form1.smethod_30((Control)(object)pictureBox[num16, num37]);
					num = (int)(num2 * 2055488986) ^ -2070715326;
					continue;
				case 152u:
					if (!flag5)
					{
						num = ((int)num2 * -2125211829) ^ -1960860412;
						continue;
					}
					goto IL_02b7;
				case 151u:
					num = (int)((num2 * 1958972898) ^ 0x5FFED29A);
					continue;
				case 150u:
					num = (int)(num2 * 1057687156) ^ -1702932319;
					continue;
				case 149u:
					num27++;
					num = 850766703;
					continue;
				case 148u:
					num9++;
					num = ((int)num2 * -944910392) ^ -2028430151;
					continue;
				case 147u:
					num = (int)(num2 * 1573829634) ^ -606206741;
					continue;
				case 146u:
					step++;
					num = (int)((num2 * 1226710721) ^ 0x9A764B);
					continue;
				case 145u:
					num16++;
					num = (int)(num2 * 690752198) ^ -1552542553;
					continue;
				case 144u:
					Form1.smethod_32((Control)(object)richTextBox1, "Выберете фигуру, которой будет играть противник.");
					num = ((int)num2 * -1045076830) ^ -976476259;
					continue;
				case 143u:
					Form1.smethod_47(200);
					Form1.smethod_5((Control)(object)borderBox[num5, num6], Color.White);
					num = (int)(num2 * 1549454624) ^ -1805360034;
					continue;
				case 142u:
					num = 1794437379;
					continue;
				case 141u:
					num = 1293545471;
					continue;
				case 140u:
					num = ((int)num2 * -1183308489) ^ 0x4BB73120;
					continue;
				case 139u:
					Form1.smethod_32((Control)(object)richTextBox1, "Ничья!");
					num = (int)((num2 * 716282447) ^ 0xA5AAD81);
					continue;
				case 138u:
					Form1.smethod_30((Control)(object)borderBox[num5, num6]);
					num = (int)((num2 * 756591641) ^ 0x529938A6);
					continue;
				case 137u:
					Form1.smethod_47(200);
					num = ((int)num2 * -1835645282) ^ 0x6CE1F22C;
					continue;
				case 136u:
					num37++;
					num = 1384497995;
					continue;
				case 135u:
					num = (int)(num2 * 2043963975) ^ -1279969389;
					continue;
				case 134u:
					num = ((int)num2 * -602431256) ^ 0x223E1960;
					continue;
				case 133u:
					num40 = num37;
					num = (int)((num2 * 747981382) ^ 0x20DBDDFE);
					continue;
				case 132u:
				{
					int num38;
					int num39;
					if (!flag6)
					{
						num38 = 1922819065;
						num39 = 1922819065;
					}
					else
					{
						num38 = 653546331;
						num39 = 653546331;
					}
					num = num38 ^ (int)(num2 * 652682254);
					continue;
				}
				case 131u:
					num24 = num37;
					num = ((int)num2 * -571616047) ^ 0x4A16F087;
					continue;
				case 130u:
				{
					int num31;
					int num32;
					if (flag7)
					{
						num31 = 1578632113;
						num32 = 1578632113;
					}
					else
					{
						num31 = 572261193;
						num32 = 572261193;
					}
					num = num31 ^ (int)(num2 * 968168399);
					continue;
				}
				case 129u:
					num30 = 0;
					num = 51878389;
					continue;
				case 128u:
					Form1.smethod_5((Control)(object)borderBox[num33, num30], Color.LimeGreen);
					num = ((int)num2 * -1115895622) ^ -209155750;
					continue;
				case 127u:
					num = ((int)num2 * -1934725836) ^ -1892286154;
					continue;
				case 126u:
					Form1.smethod_30((Control)(object)pictureBox1);
					num = (int)(num2 * 155281226) ^ -345903729;
					continue;
				case 125u:
					num = (int)(num2 * 2022894490) ^ -1069715362;
					continue;
				case 124u:
					num19 = 0;
					num = 1644093365;
					continue;
				case 123u:
				{
					int num14;
					int num15;
					if (flag3)
					{
						num14 = -93707583;
						num15 = -93707583;
					}
					else
					{
						num14 = -960985233;
						num15 = -960985233;
					}
					num = num14 ^ (int)(num2 * 1342383122);
					continue;
				}
				case 122u:
					num = ((int)num2 * -860002822) ^ -1517877393;
					continue;
				case 121u:
					num = 1591375666;
					continue;
				case 120u:
					Form1.smethod_44(graphics_, Form1.smethod_21(pictureBox[num5, num6]), num7 * size + 4, num8 * size + 4, new Rectangle(0, 0, size, size), (GraphicsUnit)2);
					Form1.smethod_30((Control)(object)pictureBox1);
					num = ((int)num2 * -1990516666) ^ 0xBC4A62F;
					continue;
				case 119u:
					Form1.smethod_15(timer1);
					num = (int)((num2 * 1643094995) ^ 0xA9E543D);
					continue;
				case 118u:
					Form1.smethod_5((Control)(object)borderBox[num16, num37], Color.White);
					Form1.smethod_30((Control)(object)borderBox[num16, num37]);
					Form1.smethod_20(pictureBox[num16, num37], (Image)null);
					num = (int)((num2 * 590895107) ^ 0x1A1FF0A7);
					continue;
				case 117u:
					storage[num5, num6] = null;
					num = (int)(num2 * 35099750) ^ -2028486815;
					continue;
				case 116u:
					num = ((int)num2 * -856239638) ^ -2076961682;
					continue;
				case 115u:
					num = ((int)num2 * -1806606787) ^ -962383481;
					continue;
				case 114u:
				{
					int num64;
					int num65;
					if (Form1.smethod_41((Control)(object)borderBox[num33, num30]) == Color.Red)
					{
						num64 = 1720010680;
						num65 = 1720010680;
					}
					else
					{
						num64 = 763139337;
						num65 = 763139337;
					}
					num = num64 ^ ((int)num2 * -368414447);
					continue;
				}
				case 113u:
					num23 = num16;
					num = (int)(num2 * 51880267) ^ -299068226;
					continue;
				case 112u:
					Form1.smethod_44(graphics_, Form1.smethod_21(pictureBox[num5, num6]), num27 * size + 4, num26 * size + 4, new Rectangle(0, 0, size, size), (GraphicsUnit)2);
					num = ((int)num2 * -1201110953) ^ 0x394A2656;
					continue;
				case 111u:
					flag5 = false;
					num = ((int)num2 * -1063418442) ^ -1771329161;
					continue;
				case 110u:
					Form1.smethod_30((Control)(object)pictureBox[num5, num6]);
					num = (int)(num2 * 1585959545) ^ -27536708;
					continue;
				case 109u:
					num = (int)((num2 * 117080125) ^ 0x4AB00DD);
					continue;
				case 108u:
					num = ((int)num2 * -42756747) ^ -1975614550;
					continue;
				case 107u:
					num = (int)((num2 * 1444283555) ^ 0x262AA0D8);
					continue;
				case 106u:
					if (num49 >= 9)
					{
						num = 2103339236;
						num57 = 2103339236;
						continue;
					}
					goto IL_02b7;
				case 105u:
					num30++;
					num = (int)(num2 * 2077000407) ^ -2003298054;
					continue;
				case 104u:
				{
					int num62;
					int num63;
					if (!flag11)
					{
						num62 = 2012736542;
						num63 = 2012736542;
					}
					else
					{
						num62 = 1498301010;
						num63 = 1498301010;
					}
					num = num62 ^ ((int)num2 * -2026937541);
					continue;
				}
				case 103u:
				{
					int num61;
					if (num16 >= 4)
					{
						num = 1449601594;
						num61 = 1449601594;
					}
					else
					{
						num = 2139644256;
						num61 = 2139644256;
					}
					continue;
				}
				case 102u:
					num10 = 0;
					num = 620853706;
					continue;
				case 101u:
					num = ((int)num2 * -1846111010) ^ -1253664751;
					continue;
				case 100u:
				{
					int num60;
					if (board[num26, num27] == null)
					{
						num = 435575213;
						num60 = 435575213;
					}
					else
					{
						num = 1794437379;
						num60 = 1794437379;
					}
					continue;
				}
				case 99u:
					Form1.smethod_30((Control)(object)richTextBox1);
					num = (int)((num2 * 1679669097) ^ 0xF157E89);
					continue;
				case 98u:
					Form1.smethod_15(timer1);
					num = 1152843272;
					continue;
				case 97u:
					array = (Figurine[,])Form1.smethod_48((Array)array2);
					num = (int)((num2 * 982649636) ^ 0x6249B161);
					continue;
				case 96u:
					num33 = 0;
					num = (int)(num2 * 892609922) ^ -184188910;
					continue;
				case 95u:
					Form1.smethod_20(pictureBox[num5, num6], (Image)null);
					num = (int)((num2 * 1923816941) ^ 0x3B22CDF6);
					continue;
				case 94u:
					num = ((int)num2 * -426311319) ^ 0x5BB62967;
					continue;
				case 93u:
					Paint_Board();
					num = (int)((num2 * 383888674) ^ 0x6D9B8B95);
					continue;
				case 92u:
				{
					int num58;
					int num59;
					if (board[num8, num7] == null)
					{
						num58 = 340200867;
						num59 = 340200867;
					}
					else
					{
						num58 = 758582241;
						num59 = 758582241;
					}
					num = num58 ^ (int)(num2 * 1954357885);
					continue;
				}
				case 91u:
					array3 = (Figurine[,])Form1.smethod_48((Array)board);
					num = (int)((num2 * 517568007) ^ 0xD9C5706);
					continue;
				case 90u:
					Form1.smethod_43(graphics_, Form1.smethod_42(Color.LimeGreen, 3f), ((float)num27 + 0.05f) * (float)size, ((float)num26 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					num = (int)(num2 * 726022609) ^ -1440327414;
					continue;
				case 89u:
					num11 = Form1.smethod_33(rnd, 4);
					num12 = Form1.smethod_33(rnd, 4);
					num = 417928609;
					continue;
				case 88u:
					num = (int)(num2 * 914657852) ^ -1673432292;
					continue;
				case 87u:
					Form1.smethod_32((Control)(object)label2, Form1.smethod_34("Ход: ", step.ToString()));
					num = ((int)num2 * -1774685823) ^ -811609133;
					continue;
				case 86u:
				{
					int num55;
					int num56;
					if (flag14)
					{
						num55 = -694945300;
						num56 = -694945300;
					}
					else
					{
						num55 = -1633311822;
						num56 = -1633311822;
					}
					num = num55 ^ ((int)num2 * -317974592);
					continue;
				}
				case 85u:
					num = ((int)num2 * -1674080979) ^ -295849922;
					continue;
				case 84u:
					num = ((int)num2 * -11440809) ^ 0x1C4AC50C;
					continue;
				case 83u:
					Form1.smethod_30((Control)(object)pictureBox[num5, num6]);
					board[num8, num7] = new Figurine(storage[num5, num6]);
					num = ((int)num2 * -1086332375) ^ -1992055560;
					continue;
				case 82u:
					Form1.smethod_43(graphics_, Form1.smethod_42(Color.LimeGreen, 3f), ((float)num7 + 0.05f) * (float)size, ((float)num8 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					num = (int)((num2 * 1523648247) ^ 0x6924D130);
					continue;
				case 81u:
					num54 = (Standoff(array3) ? 1 : 0);
					goto IL_023c;
				case 80u:
					num = ((int)num2 * -1690190731) ^ 0xEE64D08;
					continue;
				case 79u:
					num = ((int)num2 * -425762885) ^ -1179682144;
					continue;
				case 78u:
					flag12 = Form1.smethod_40((Bitmap)Form1.smethod_21(pictureBox1), num37 * size + size / 2, (int)(((float)num16 + 0.05f) * (float)size)) == Color.FromArgb(255, 255, 0, 0);
					num = 774276283;
					continue;
				case 77u:
					flag7 = num37 < 4;
					num = 1992947204;
					continue;
				case 76u:
					if (num11 == num5)
					{
						num = ((int)num2 * -1620316161) ^ 0x2F8F3B96;
						continue;
					}
					num13 = 0;
					goto IL_0c87;
				case 75u:
					num49 = 0;
					num = ((int)num2 * -282221204) ^ -1413587184;
					continue;
				case 74u:
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: false);
					num = (int)(num2 * 226996351) ^ -614567078;
					continue;
				case 73u:
				{
					int num53;
					if (num27 < 4)
					{
						num = 471968546;
						num53 = 471968546;
					}
					else
					{
						num = 382349153;
						num53 = 382349153;
					}
					continue;
				}
				case 72u:
				{
					int num51;
					int num52;
					if (!flag13)
					{
						num51 = -1191290691;
						num52 = -1191290691;
					}
					else
					{
						num51 = -226910545;
						num52 = -226910545;
					}
					num = num51 ^ ((int)num2 * -235050846);
					continue;
				}
				case 71u:
					flag10 = num33 < 4;
					num = 1921556457;
					continue;
				case 70u:
					num37 = 0;
					num = 1384497995;
					continue;
				case 69u:
					num25 = 0;
					num = (int)((num2 * 947901035) ^ 0x1DFB8F46);
					continue;
				case 68u:
					num = ((int)num2 * -1786877597) ^ 0x5400A4CD;
					continue;
				case 67u:
				{
					int num50;
					if (!Standoff(board))
					{
						num = 538927807;
						num50 = 538927807;
					}
					else
					{
						num = 1863714262;
						num50 = 1863714262;
					}
					continue;
				}
				case 66u:
					num49++;
					num = 1339928105;
					continue;
				case 65u:
				{
					int num47;
					int num48;
					if (!(Form1.smethod_41((Control)(object)borderBox[num16, num37]) == Color.Blue))
					{
						num47 = -1133205750;
						num48 = -1133205750;
					}
					else
					{
						num47 = -763923427;
						num48 = -763923427;
					}
					num = num47 ^ (int)(num2 * 629556322);
					continue;
				}
				case 64u:
					Form1.smethod_5((Control)(object)borderBox[num5, num6], Color.White);
					num = ((int)num2 * -712625574) ^ 0x44D10213;
					continue;
				case 63u:
					num5 = num33;
					num6 = num30;
					num = ((int)num2 * -217342030) ^ 0x5A99CB48;
					continue;
				case 62u:
					num = (int)((num2 * 1040793881) ^ 0x1B02010D);
					continue;
				case 61u:
				{
					int num45;
					int num46;
					if (flag12)
					{
						num45 = 1851091148;
						num46 = 1851091148;
					}
					else
					{
						num45 = 129276917;
						num46 = 129276917;
					}
					num = num45 ^ ((int)num2 * -573053769);
					continue;
				}
				case 60u:
					board[num23, num24] = new Figurine(storage[num21, num40]);
					num = ((int)num2 * -399549074) ^ 0x852D4B8;
					continue;
				case 59u:
					if (!Stop(board))
					{
						num = ((int)num2 * -2057292476) ^ -420769172;
						continue;
					}
					goto IL_0ec0;
				case 58u:
					Form1.smethod_32((Control)(object)richTextBox1, "Подождите, компьютер делает свой ход.");
					num = (int)(num2 * 1894253481) ^ -181040145;
					continue;
				case 57u:
					num = 345825479;
					continue;
				case 56u:
					num27 = 0;
					num = 2062995256;
					continue;
				case 55u:
					storage[num5, num6] = null;
					flag4 = Standoff(board);
					num = (int)((num2 * 1829481731) ^ 0x319C38B6);
					continue;
				case 54u:
					num = 34120395;
					continue;
				case 53u:
					num = ((int)num2 * -670130964) ^ 0x473761C5;
					continue;
				case 52u:
					num13 = ((num12 == num6) ? 1 : 0);
					goto IL_0c87;
				case 51u:
					flag11 = num25 < 4;
					num = 303989294;
					continue;
				case 50u:
					num = (int)(num2 * 219787044) ^ -666738513;
					continue;
				case 49u:
					num = ((int)num2 * -608811579) ^ -441544639;
					continue;
				case 48u:
					Form1.smethod_7((Control)(object)pictureBox[num33, num30], bool_0: false);
					num = ((int)num2 * -1611631206) ^ 0x198D6041;
					continue;
				case 47u:
				{
					int num43;
					int num44;
					if (flag10)
					{
						num43 = 815954942;
						num44 = 815954942;
					}
					else
					{
						num43 = 793361502;
						num44 = 793361502;
					}
					num = num43 ^ ((int)num2 * -227727289);
					continue;
				}
				case 46u:
					(menu as Form3).ContinueLock();
					num = ((int)num2 * -718717362) ^ 0x7AF48EBE;
					continue;
				case 45u:
					Form1.smethod_30((Control)(object)borderBox[num33, num30]);
					num = ((int)num2 * -130327054) ^ 0x48924622;
					continue;
				case 44u:
					num8 = Form1.smethod_33(rnd, 4);
					num7 = Form1.smethod_33(rnd, 4);
					num = (int)((num2 * 461578091) ^ 0x46ACEA2D);
					continue;
				case 43u:
				{
					int num41;
					int num42;
					if (flag9)
					{
						num41 = -793492453;
						num42 = -793492453;
					}
					else
					{
						num41 = -1260325105;
						num42 = -1260325105;
					}
					num = num41 ^ (int)(num2 * 2035249813);
					continue;
				}
				case 42u:
					Form1.smethod_20(pictureBox[num5, num6], (Image)null);
					num = (int)((num2 * 632460050) ^ 0x4F85224C);
					continue;
				case 41u:
					Form1.smethod_5((Control)(object)borderBox[num11, num12], Color.Blue);
					Form1.smethod_30((Control)(object)borderBox[num11, num12]);
					num = ((int)num2 * -1498703686) ^ -356223534;
					continue;
				case 40u:
					flag8 = Form1.smethod_46((Control)(object)pictureBox1);
					num = ((int)num2 * -930487054) ^ -305500137;
					continue;
				case 39u:
					num = (int)((num2 * 1721564575) ^ 0x72F417BC);
					continue;
				case 38u:
					storage[num21, num40] = null;
					num = (int)(num2 * 392111407) ^ -1919162543;
					continue;
				case 36u:
					num26 = 0;
					num = ((int)num2 * -1397326434) ^ -1361782648;
					continue;
				case 35u:
					flag3 = num30 < 4;
					num = 2002747549;
					continue;
				case 34u:
					num = (int)((num2 * 965319176) ^ 0x6169B7EE);
					continue;
				case 33u:
				{
					int num35;
					int num36;
					if (!flag8)
					{
						num35 = -756285887;
						num36 = -756285887;
					}
					else
					{
						num35 = -2127564730;
						num36 = -2127564730;
					}
					num = num35 ^ ((int)num2 * -1827888355);
					continue;
				}
				case 32u:
				{
					int num34;
					if (num26 >= 4)
					{
						num = 2011843213;
						num34 = 2011843213;
					}
					else
					{
						num = 2000144190;
						num34 = 2000144190;
					}
					continue;
				}
				case 31u:
					num19++;
					num = ((int)num2 * -1279676492) ^ -1077663135;
					continue;
				case 30u:
					Form1.smethod_32((Control)(object)richTextBox1, "Противник сделал ход (зелёный). Выберете поле на доске для выбронной противником фигуры (синий).");
					num = (int)(num2 * 1569733318) ^ -2051452301;
					continue;
				case 29u:
				{
					int num28;
					int num29;
					if (flag2)
					{
						num28 = -75034504;
						num29 = -75034504;
					}
					else
					{
						num28 = -457421378;
						num29 = -457421378;
					}
					num = num28 ^ ((int)num2 * -934730310);
					continue;
				}
				case 28u:
					num = (int)((num2 * 1934716785) ^ 0x6850047);
					continue;
				case 27u:
					num = 677403722;
					continue;
				case 26u:
					flag6 = array2[num9, num10] == null;
					num = 642843442;
					continue;
				case 25u:
					Form1.smethod_30((Control)(object)borderBox[num5, num6]);
					num = ((int)num2 * -1496442633) ^ -976860810;
					continue;
				case 24u:
					num = ((int)num2 * -2028666817) ^ -1669850948;
					continue;
				case 23u:
					Form1.smethod_32((Control)(object)richTextBox1, "Ничья!");
					num = (int)((num2 * 1985072678) ^ 0x6DAA8D5B);
					continue;
				case 22u:
					num = ((int)num2 * -224200710) ^ -107519446;
					continue;
				case 21u:
					(menu as Form3).ContinueLock();
					num = ((int)num2 * -298195865) ^ -1080156077;
					continue;
				case 20u:
					board[num26, num27] = new Figurine(storage[num5, num6]);
					num = ((int)num2 * -334866818) ^ 0x762013C9;
					continue;
				case 19u:
					num25++;
					num = (int)((num2 * 889768883) ^ 0x4107AF9C);
					continue;
				case 17u:
					num = 406187686;
					continue;
				case 16u:
					num = (int)((num2 * 2018507929) ^ 0xCE4E23B);
					continue;
				case 15u:
					flag = num9 < 4;
					num = 188649540;
					continue;
				case 14u:
					num23 = 0;
					num24 = 0;
					num = ((int)num2 * -1544437623) ^ -1312784163;
					continue;
				case 13u:
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox1));
					num = (int)((num2 * 1320331278) ^ 0x6C64C014);
					continue;
				case 12u:
					flag5 = true;
					num = (int)(num2 * 1979585445) ^ -685110368;
					continue;
				case 11u:
				{
					int num22;
					if (num19 < 4)
					{
						num = 1145565260;
						num22 = 1145565260;
					}
					else
					{
						num = 1900920773;
						num22 = 1900920773;
					}
					continue;
				}
				case 10u:
					num = 1643682276;
					continue;
				case 9u:
					num21 = num16;
					num = ((int)num2 * -1227065551) ^ -1087664198;
					continue;
				case 8u:
					num5 = 0;
					num6 = 0;
					num = ((int)num2 * -131116410) ^ -1501518874;
					continue;
				case 7u:
					num10++;
					num = 376421117;
					continue;
				case 6u:
					if (!Standoff(board))
					{
						num = 1434014216;
						num20 = 1434014216;
						continue;
					}
					goto IL_0ec0;
				case 5u:
				{
					int num17;
					int num18;
					if (!flag4)
					{
						num17 = -1575895110;
						num18 = -1575895110;
					}
					else
					{
						num17 = -284576015;
						num18 = -284576015;
					}
					num = num17 ^ ((int)num2 * -1558105316);
					continue;
				}
				case 4u:
					if (storage[num11, num12] != null)
					{
						num = (int)(num2 * 817622269) ^ -683886418;
						continue;
					}
					num13 = 1;
					goto IL_0c87;
				case 3u:
					array[num9, num10] = new Figurine(storage[num11, num12]);
					flag2 = Stop(array);
					num = ((int)num2 * -1142748078) ^ 0x10FD451D;
					continue;
				case 2u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = 1741789796;
						num4 = 1741789796;
					}
					else
					{
						num3 = 1055259466;
						num4 = 1055259466;
					}
					num = num3 ^ (int)(num2 * 146913746);
					continue;
				}
				case 1u:
					Form1.smethod_47(1000);
					num = (int)((num2 * 1092664200) ^ 0x325B0233);
					continue;
				case 0u:
					Form1.smethod_32((Control)(object)richTextBox1, "QUARTO! Компьютер выиграл!");
					num = 212664990;
					continue;
				default:
					return;
				case 37u:
					break;
				case 18u:
					return;
					IL_0ec0:
					num = 1480898405;
					num20 = 1480898405;
					continue;
					IL_0c87:
					flag13 = (byte)num13 != 0;
					num = 215091070;
					continue;
					IL_02b7:
					num = 1521730548;
					num57 = 1521730548;
					continue;
					IL_023c:
					flag9 = (byte)num54 != 0;
					num = 832121661;
					continue;
				}
				break;
			}
		}
	}

	private bool Stop(Figurine[,] mem)
	{
		bool flag = default(bool);
		int num3 = default(int);
		bool flag2 = default(bool);
		bool result = default(bool);
		while (true)
		{
			int num = -156776580;
			while (true)
			{
				uint num2;
				int num23;
				int num59;
				switch ((num2 = (uint)num ^ 0xE6A558CEu) % 77u)
				{
				case 76u:
					flag = num3 < 4;
					num = -377191321;
					continue;
				case 75u:
					if (mem[2, 1].Point != mem[3, 0].Point)
					{
						num = (int)(num2 * 1108545871) ^ -871757921;
						continue;
					}
					goto IL_0047;
				case 74u:
				{
					int num67;
					int num68;
					if (mem[1, 1] == null)
					{
						num67 = 1946945768;
						num68 = 1946945768;
					}
					else
					{
						num67 = 1420708247;
						num68 = 1420708247;
					}
					num = num67 ^ (int)(num2 * 687140382);
					continue;
				}
				case 73u:
					if (mem[2, num3].Dark != mem[3, num3].Dark)
					{
						num = ((int)num2 * -216701877) ^ 0x5CFC898A;
						continue;
					}
					goto IL_00c4;
				case 71u:
					flag2 = false;
					num3 = 0;
					num = (int)(num2 * 1978536835) ^ -626632692;
					continue;
				case 70u:
					if (mem[3, 0] != null)
					{
						num = ((int)num2 * -1661810909) ^ 0x48F83A46;
						continue;
					}
					goto IL_0053;
				case 69u:
					if (mem[num3, 2].Big != mem[num3, 3].Big)
					{
						num = (int)((num2 * 1462048631) ^ 0x1192AF3C);
						continue;
					}
					goto IL_00c4;
				case 68u:
					if (mem[0, 3].Square == mem[1, 2].Square)
					{
						num = -96511815;
						continue;
					}
					goto IL_0053;
				case 67u:
					num3++;
					num = ((int)num2 * -1628075369) ^ -1597595556;
					continue;
				case 66u:
					if (mem[1, num3] != null)
					{
						num = (int)(num2 * 199852156) ^ -616617785;
						continue;
					}
					goto IL_00d0;
				case 65u:
					if (mem[2, 2].Dark != mem[3, 3].Dark)
					{
						num = ((int)num2 * -174803047) ^ 0x10E50992;
						continue;
					}
					goto IL_0047;
				case 64u:
					if (mem[1, 2] != null)
					{
						num = ((int)num2 * -1997919016) ^ 0x4EB4FCC1;
						continue;
					}
					goto IL_0053;
				case 63u:
					if (mem[1, num3].Square == mem[2, num3].Square)
					{
						num = ((int)num2 * -2013845917) ^ -350679787;
						continue;
					}
					goto IL_00d0;
				case 62u:
					if (mem[2, 2].Point != mem[3, 3].Point)
					{
						num = (int)(num2 * 1679791818) ^ -1590957791;
						continue;
					}
					goto IL_0047;
				case 61u:
					num = (int)(num2 * 70521096) ^ -616037843;
					continue;
				case 60u:
					if (mem[2, num3] != null)
					{
						num = (int)(num2 * 270443242) ^ -1883038640;
						continue;
					}
					goto IL_00d0;
				case 59u:
				{
					int num10;
					int num11;
					if (mem[1, 2].Dark == mem[2, 1].Dark)
					{
						num10 = -1007872867;
						num11 = -1007872867;
					}
					else
					{
						num10 = -1864513602;
						num11 = -1864513602;
					}
					num = num10 ^ (int)(num2 * 274719986);
					continue;
				}
				case 58u:
					num = -465889521;
					continue;
				case 57u:
					num = (int)((num2 * 1982573606) ^ 0x685A5F42);
					continue;
				case 56u:
				{
					int num62;
					if (mem[0, 0].Point != mem[1, 1].Point)
					{
						num = -400749333;
						num62 = -400749333;
					}
					else
					{
						num = -217351374;
						num62 = -217351374;
					}
					continue;
				}
				case 55u:
					if (mem[0, 3] != null)
					{
						num = -1850122314;
						continue;
					}
					goto IL_0053;
				case 54u:
				{
					int num54;
					if (mem[0, 3].Dark != mem[1, 2].Dark)
					{
						num = -416058124;
						num54 = -416058124;
					}
					else
					{
						num = -1527993021;
						num54 = -1527993021;
					}
					continue;
				}
				case 53u:
				{
					int num51;
					int num52;
					if (mem[1, num3].Dark == mem[2, num3].Dark)
					{
						num51 = -657794803;
						num52 = -657794803;
					}
					else
					{
						num51 = -1691979751;
						num52 = -1691979751;
					}
					num = num51 ^ (int)(num2 * 490626309);
					continue;
				}
				case 52u:
					if (mem[num3, 2].Dark != mem[num3, 3].Dark)
					{
						num = ((int)num2 * -534901050) ^ 0x6FD95A4;
						continue;
					}
					goto IL_00c4;
				case 51u:
					if (mem[2, 1].Big != mem[3, 0].Big)
					{
						num = (int)((num2 * 213923306) ^ 0x59758BC5);
						continue;
					}
					goto IL_0047;
				case 50u:
				{
					int num34;
					if (mem[0, num3].Point == mem[1, num3].Point)
					{
						num = -1397283357;
						num34 = -1397283357;
					}
					else
					{
						num = -1995833152;
						num34 = -1995833152;
					}
					continue;
				}
				case 49u:
					flag2 = true;
					num = ((int)num2 * -1845885979) ^ 0x5973F6CF;
					continue;
				case 48u:
				{
					int num28;
					int num29;
					if (mem[1, 1].Dark == mem[2, 2].Dark)
					{
						num28 = -693469352;
						num29 = -693469352;
					}
					else
					{
						num28 = -1790307436;
						num29 = -1790307436;
					}
					num = num28 ^ ((int)num2 * -224469384);
					continue;
				}
				case 47u:
				{
					int num24;
					if (mem[num3, 0].Point == mem[num3, 1].Point)
					{
						num = -301850235;
						num24 = -301850235;
					}
					else
					{
						num = -1246604200;
						num24 = -1246604200;
					}
					continue;
				}
				case 46u:
					result = flag2;
					num = -1509290040;
					continue;
				case 45u:
				{
					int num12;
					int num13;
					if (mem[0, 0] != null)
					{
						num12 = -668069249;
						num13 = -668069249;
					}
					else
					{
						num12 = -552249398;
						num13 = -552249398;
					}
					num = num12 ^ (int)(num2 * 650294758);
					continue;
				}
				case 44u:
					if (mem[num3, 2].Square != mem[num3, 3].Square)
					{
						num = ((int)num2 * -1874000612) ^ 0x5CDB42A3;
						continue;
					}
					goto IL_00c4;
				case 43u:
					if (mem[0, num3].Square == mem[1, num3].Square)
					{
						num = -1229397969;
						continue;
					}
					goto IL_00d0;
				case 42u:
				{
					int num63;
					int num64;
					if (mem[num3, 0].Big != mem[num3, 1].Big)
					{
						num63 = -1940358807;
						num64 = -1940358807;
					}
					else
					{
						num63 = -591999832;
						num64 = -591999832;
					}
					num = num63 ^ ((int)num2 * -916335166);
					continue;
				}
				case 41u:
					if (mem[3, num3] != null)
					{
						num = (int)(num2 * 684426144) ^ -53465896;
						continue;
					}
					goto IL_00d0;
				case 40u:
					if (mem[2, 1] != null)
					{
						num = (int)((num2 * 913655203) ^ 0x4FBBEA4D);
						continue;
					}
					goto IL_0053;
				case 39u:
				{
					int num55;
					int num56;
					if (mem[1, num3].Point != mem[2, num3].Point)
					{
						num55 = 1100819058;
						num56 = 1100819058;
					}
					else
					{
						num55 = 1576429301;
						num56 = 1576429301;
					}
					num = num55 ^ (int)(num2 * 1151080634);
					continue;
				}
				case 38u:
				{
					int num50;
					if (mem[0, 3].Point != mem[1, 2].Point)
					{
						num = -289892281;
						num50 = -289892281;
					}
					else
					{
						num = -831223270;
						num50 = -831223270;
					}
					continue;
				}
				case 37u:
				{
					int num46;
					int num47;
					if (mem[num3, 2] == null)
					{
						num46 = 1865031083;
						num47 = 1865031083;
					}
					else
					{
						num46 = 228813762;
						num47 = 228813762;
					}
					num = num46 ^ ((int)num2 * -901491228);
					continue;
				}
				case 36u:
				{
					int num42;
					int num43;
					if (mem[num3, 0] == null)
					{
						num42 = 506834221;
						num43 = 506834221;
					}
					else
					{
						num42 = 947276509;
						num43 = 947276509;
					}
					num = num42 ^ ((int)num2 * -1957799918);
					continue;
				}
				case 35u:
					num = -600839868;
					continue;
				case 34u:
				{
					int num36;
					int num37;
					if (mem[num3, 1] == null)
					{
						num36 = -2138901403;
						num37 = -2138901403;
					}
					else
					{
						num36 = -1653404487;
						num37 = -1653404487;
					}
					num = num36 ^ (int)(num2 * 1087775706);
					continue;
				}
				case 33u:
				{
					int num30;
					int num31;
					if (mem[1, 1].Square == mem[2, 2].Square)
					{
						num30 = 1570249550;
						num31 = 1570249550;
					}
					else
					{
						num30 = 235643248;
						num31 = 235643248;
					}
					num = num30 ^ ((int)num2 * -909481050);
					continue;
				}
				case 32u:
				{
					int num26;
					int num27;
					if (mem[0, num3].Big == mem[1, num3].Big)
					{
						num26 = 657517601;
						num27 = 657517601;
					}
					else
					{
						num26 = 539652231;
						num27 = 539652231;
					}
					num = num26 ^ (int)(num2 * 82735916);
					continue;
				}
				case 31u:
				{
					int num19;
					int num20;
					if (mem[1, num3].Big != mem[2, num3].Big)
					{
						num19 = -1428621736;
						num20 = -1428621736;
					}
					else
					{
						num19 = -27896639;
						num20 = -27896639;
					}
					num = num19 ^ ((int)num2 * -155150191);
					continue;
				}
				case 30u:
				{
					int num16;
					int num17;
					if (mem[3, 3] == null)
					{
						num16 = 1280065614;
						num17 = 1280065614;
					}
					else
					{
						num16 = 1286670835;
						num17 = 1286670835;
					}
					num = num16 ^ ((int)num2 * -267161955);
					continue;
				}
				case 29u:
				{
					int num6;
					int num7;
					if (mem[num3, 1].Big == mem[num3, 2].Big)
					{
						num6 = -2104428313;
						num7 = -2104428313;
					}
					else
					{
						num6 = -1405210397;
						num7 = -1405210397;
					}
					num = num6 ^ (int)(num2 * 332665422);
					continue;
				}
				case 28u:
					if (mem[1, 2].Square == mem[2, 1].Square)
					{
						num = ((int)num2 * -1939232713) ^ -109121229;
						continue;
					}
					goto IL_0053;
				case 27u:
				{
					int num69;
					if (mem[0, 0].Dark == mem[1, 1].Dark)
					{
						num = -2096409976;
						num69 = -2096409976;
					}
					else
					{
						num = -1929668796;
						num69 = -1929668796;
					}
					continue;
				}
				case 26u:
				{
					int num65;
					int num66;
					if (mem[1, 1].Point == mem[2, 2].Point)
					{
						num65 = -1417031289;
						num66 = -1417031289;
					}
					else
					{
						num65 = -841034717;
						num66 = -841034717;
					}
					num = num65 ^ ((int)num2 * -1407825970);
					continue;
				}
				case 25u:
					if (mem[2, num3].Big != mem[3, num3].Big)
					{
						num = ((int)num2 * -365425146) ^ -1267112481;
						continue;
					}
					goto IL_00c4;
				case 24u:
				{
					int num60;
					int num61;
					if (flag)
					{
						num60 = -1946853697;
						num61 = -1946853697;
					}
					else
					{
						num60 = -1871886377;
						num61 = -1871886377;
					}
					num = num60 ^ ((int)num2 * -1143346609);
					continue;
				}
				case 23u:
					if (mem[2, 2].Big != mem[3, 3].Big)
					{
						num = (int)(num2 * 2029195735) ^ -13567255;
						continue;
					}
					goto IL_0047;
				case 22u:
				{
					int num57;
					int num58;
					if (mem[1, 2].Big != mem[2, 1].Big)
					{
						num57 = -2020669559;
						num58 = -2020669559;
					}
					else
					{
						num57 = -191497624;
						num58 = -191497624;
					}
					num = num57 ^ ((int)num2 * -893420080);
					continue;
				}
				case 21u:
				{
					int num53;
					if (mem[0, num3].Dark != mem[1, num3].Dark)
					{
						num = -973094382;
						num53 = -973094382;
					}
					else
					{
						num = -662821119;
						num53 = -662821119;
					}
					continue;
				}
				case 20u:
				{
					int num48;
					int num49;
					if (mem[0, 3].Big == mem[1, 2].Big)
					{
						num48 = -1774088465;
						num49 = -1774088465;
					}
					else
					{
						num48 = -437670003;
						num49 = -437670003;
					}
					num = num48 ^ ((int)num2 * -1181138198);
					continue;
				}
				case 19u:
				{
					int num44;
					int num45;
					if (mem[1, 2].Point == mem[2, 1].Point)
					{
						num44 = -613589986;
						num45 = -613589986;
					}
					else
					{
						num44 = -950804417;
						num45 = -950804417;
					}
					num = num44 ^ ((int)num2 * -1649695130);
					continue;
				}
				case 18u:
					flag2 = true;
					num = (int)((num2 * 1176668532) ^ 0x477598DD);
					continue;
				case 17u:
					if (mem[2, num3].Point != mem[3, num3].Point)
					{
						num = ((int)num2 * -1696481079) ^ -473309359;
						continue;
					}
					goto IL_00c4;
				case 16u:
					if (mem[2, num3].Square == mem[3, num3].Square)
					{
						goto IL_00c4;
					}
					goto IL_00d0;
				case 15u:
				{
					int num40;
					int num41;
					if (mem[2, 2] == null)
					{
						num40 = 173674087;
						num41 = 173674087;
					}
					else
					{
						num40 = 834713383;
						num41 = 834713383;
					}
					num = num40 ^ ((int)num2 * -2109011049);
					continue;
				}
				case 14u:
				{
					int num38;
					int num39;
					if (mem[1, 1].Big != mem[2, 2].Big)
					{
						num38 = 1003166938;
						num39 = 1003166938;
					}
					else
					{
						num38 = 1488673997;
						num39 = 1488673997;
					}
					num = num38 ^ (int)(num2 * 395221897);
					continue;
				}
				case 13u:
				{
					int num35;
					if (mem[0, 0].Square != mem[1, 1].Square)
					{
						num = -1161892738;
						num35 = -1161892738;
					}
					else
					{
						num = -2100113613;
						num35 = -2100113613;
					}
					continue;
				}
				case 12u:
				{
					int num32;
					int num33;
					if (mem[num3, 1].Point != mem[num3, 2].Point)
					{
						num32 = 1470759271;
						num33 = 1470759271;
					}
					else
					{
						num32 = 1643132451;
						num33 = 1643132451;
					}
					num = num32 ^ ((int)num2 * -1129992355);
					continue;
				}
				case 11u:
					if (mem[0, num3] != null)
					{
						num = -968968006;
						continue;
					}
					goto IL_00d0;
				case 10u:
					if (mem[2, 1].Dark != mem[3, 0].Dark)
					{
						num = (int)(num2 * 1127469460) ^ -1661298816;
						continue;
					}
					goto IL_0047;
				case 9u:
					if (mem[2, 2].Square != mem[3, 3].Square)
					{
						num = (int)((num2 * 1252497204) ^ 0x48645AA6);
						continue;
					}
					goto IL_0047;
				case 8u:
				{
					int num25;
					if (mem[num3, 0].Dark != mem[num3, 1].Dark)
					{
						num = -1009087218;
						num25 = -1009087218;
					}
					else
					{
						num = -884135612;
						num25 = -884135612;
					}
					continue;
				}
				case 7u:
				{
					int num21;
					int num22;
					if (mem[num3, 1].Dark != mem[num3, 2].Dark)
					{
						num21 = -845585406;
						num22 = -845585406;
					}
					else
					{
						num21 = -1482586331;
						num22 = -1482586331;
					}
					num = num21 ^ ((int)num2 * -426537266);
					continue;
				}
				case 5u:
				{
					int num18;
					if (mem[num3, 0].Square == mem[num3, 1].Square)
					{
						num = -1763922187;
						num18 = -1763922187;
					}
					else
					{
						num = -1402184001;
						num18 = -1402184001;
					}
					continue;
				}
				case 4u:
				{
					int num14;
					int num15;
					if (mem[num3, 1].Square == mem[num3, 2].Square)
					{
						num14 = -2096363461;
						num15 = -2096363461;
					}
					else
					{
						num14 = -1650777589;
						num15 = -1650777589;
					}
					num = num14 ^ ((int)num2 * -243300644);
					continue;
				}
				case 3u:
				{
					int num8;
					int num9;
					if (mem[num3, 3] == null)
					{
						num8 = -1204392993;
						num9 = -1204392993;
					}
					else
					{
						num8 = -581911833;
						num9 = -581911833;
					}
					num = num8 ^ ((int)num2 * -136166172);
					continue;
				}
				case 2u:
				{
					int num4;
					int num5;
					if (mem[0, 0].Big != mem[1, 1].Big)
					{
						num4 = -670517217;
						num5 = -670517217;
					}
					else
					{
						num4 = -197588173;
						num5 = -197588173;
					}
					num = num4 ^ ((int)num2 * -1214921370);
					continue;
				}
				case 1u:
					if (mem[num3, 2].Point != mem[num3, 3].Point)
					{
						num = ((int)num2 * -523921378) ^ 0x3699E6C4;
						continue;
					}
					goto IL_00c4;
				case 0u:
					if (mem[2, 1].Square == mem[3, 0].Square)
					{
						goto IL_0047;
					}
					goto IL_0053;
				case 72u:
					break;
				default:
					{
						return result;
					}
					IL_0047:
					num = -312924691;
					num23 = -312924691;
					continue;
					IL_0053:
					num = -319639680;
					num23 = -319639680;
					continue;
					IL_00c4:
					num = -1407843700;
					num59 = -1407843700;
					continue;
					IL_00d0:
					num = -1708937419;
					num59 = -1708937419;
					continue;
				}
				break;
			}
		}
	}

	private bool Standoff(Figurine[,] mem)
	{
		bool flag = true;
		int num = 0;
		int num4 = default(int);
		bool result = default(bool);
		while (true)
		{
			int num2 = 239993041;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0xF18A13Fu) % 11u)
				{
				case 10u:
					num4++;
					num2 = 1323775457;
					continue;
				case 9u:
					flag = false;
					num2 = (int)(num3 * 1070826227) ^ -1936750319;
					continue;
				case 8u:
				{
					int num6;
					if (num4 >= 4)
					{
						num2 = 320052236;
						num6 = 320052236;
					}
					else
					{
						num2 = 1286815065;
						num6 = 1286815065;
					}
					continue;
				}
				case 7u:
					num4 = 0;
					num2 = 1323775457;
					continue;
				case 6u:
				{
					int num7;
					if (num < 4)
					{
						num2 = 1191330939;
						num7 = 1191330939;
					}
					else
					{
						num2 = 1234206768;
						num7 = 1234206768;
					}
					continue;
				}
				case 5u:
					result = flag;
					num2 = (int)(num3 * 190084649) ^ -967197968;
					continue;
				case 4u:
					num2 = (int)((num3 * 1039326594) ^ 0x1098FF4D);
					continue;
				case 2u:
				{
					int num5;
					if (mem[num, num4] == null)
					{
						num2 = 1927085601;
						num5 = 1927085601;
					}
					else
					{
						num2 = 1843530859;
						num5 = 1843530859;
					}
					continue;
				}
				case 0u:
					num++;
					num2 = (int)(num3 * 49485889) ^ -94626206;
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

	public void SetName(string str)
	{
		Form1.smethod_32((Control)(object)label5, "Игрок: ");
		Form1.smethod_32((Control)(object)label6, str);
		while (true)
		{
			int num = -387702173;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE309C35Cu) % 9u)
				{
				case 8u:
					num = (int)(num2 * 1835708854) ^ -680420013;
					continue;
				case 6u:
					Form1.smethod_32((Control)(object)label2, "");
					num = ((int)num2 * -1120224844) ^ 0x6DFB243C;
					continue;
				case 5u:
					Form1.smethod_50((Control)(object)label5, (Form1.smethod_49((Control)(object)this) - (Form1.smethod_18((Control)(object)label5) + Form1.smethod_18((Control)(object)label6))) / 2);
					num = (int)((num2 * 61583721) ^ 0x4BADC202);
					continue;
				case 4u:
					Form1.smethod_32((Control)(object)label1, "");
					num = (int)(num2 * 1973108644) ^ -2108492052;
					continue;
				case 2u:
					num = (int)(num2 * 390662159) ^ -429056593;
					continue;
				case 1u:
					num = (int)((num2 * 2054832586) ^ 0x6A962A2);
					continue;
				case 0u:
					Form1.smethod_50((Control)(object)label6, Form1.smethod_37((Control)(object)label5).X + Form1.smethod_18((Control)(object)label5));
					num = (int)(num2 * 1200899557) ^ -654535191;
					continue;
				default:
					return;
				case 7u:
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
			int num = 2080940917;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0x9813302u) % 9u)
				{
				case 8u:
					((Form)this).Dispose(disposing);
					num = 1951381540;
					continue;
				case 7u:
					if (disposing)
					{
						num = ((int)num2 * -1444487860) ^ 0x19B1DE1;
						continue;
					}
					goto IL_0029;
				case 6u:
					num = ((int)num2 * -643660140) ^ -1909902470;
					continue;
				case 5u:
					num = (int)((num2 * 1330438133) ^ 0x191E2037);
					continue;
				case 4u:
					num = (int)((num2 * 1202320990) ^ 0x52126485);
					continue;
				case 2u:
					if (components != null)
					{
						num = 882835627;
						num3 = 882835627;
						continue;
					}
					goto IL_0029;
				case 0u:
					Form1.smethod_51((IDisposable)components);
					num = (int)(num2 * 2103265207) ^ -2056187168;
					continue;
				default:
					return;
				case 3u:
					break;
				case 1u:
					return;
					IL_0029:
					num = 766038437;
					num3 = 766038437;
					continue;
				}
				break;
			}
		}
	}

	private void InitializeComponent()
	{
		//IL_0394: Unknown result type (might be due to invalid IL or missing references)
		//IL_039e: Expected O, but got Unknown
		components = Form1.smethod_52();
		byte[] array = default(byte[]);
		int num3 = default(int);
		string string_ = default(string);
		object[] object_ = default(object[]);
		while (true)
		{
			int num = -1274405926;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF3A6C8CDu) % 120u)
				{
				case 119u:
					CharArray(array, string.Empty);
					num = (int)((num2 * 1299155174) ^ 0x1E08C89E);
					continue;
				case 118u:
					Form1.smethod_32((Control)(object)button2, "Подтвердить");
					num = ((int)num2 * -1722147021) ^ 0x43A0A504;
					continue;
				case 117u:
					Form1.smethod_92((Control)(object)this);
					num = (int)((num2 * 1388001361) ^ 0x30904699);
					continue;
				case 116u:
					num = ((int)num2 * -2070342511) ^ 0x2CCA5B3C;
					continue;
				case 115u:
					Form1.smethod_87((Form)(object)this, (EventHandler)Form1_Load);
					num = ((int)num2 * -1576873104) ^ -2110571032;
					continue;
				case 114u:
					Form1.smethod_75((Control)(object)label1, (DockStyle)4);
					num = (int)((num2 * 853794658) ^ 0x74845155);
					continue;
				case 113u:
					array = new byte[22528];
					num = ((int)num2 * -1059386543) ^ -313055564;
					continue;
				case 112u:
					Form1.smethod_64((Control)(object)richTextBox1, 6);
					num = ((int)num2 * -1228887810) ^ 0x7CF9F5FC;
					continue;
				case 111u:
					button2 = Form1.smethod_53();
					button1 = Form1.smethod_53();
					richTextBox1 = Form1.smethod_54();
					panel1 = Form1.smethod_55();
					timer1 = Form1.smethod_56(components);
					num = ((int)num2 * -1932382425) ^ 0x27E1B7A8;
					continue;
				case 110u:
					Form1.smethod_91((Control)(object)this, bool_0: false);
					num = (int)((num2 * 521100101) ^ 0x7B04FD6);
					continue;
				case 109u:
					Form1.smethod_64((Control)(object)label5, 12);
					num = (int)(num2 * 834648450) ^ -1989472067;
					continue;
				case 108u:
					Form1.smethod_77((Control)(object)label1, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = (int)(num2 * 1979880439) ^ -1837958497;
					continue;
				case 107u:
					Form1.smethod_73(timer1, (EventHandler)Timer1_Tick);
					num = (int)((num2 * 2018224255) ^ 0x68A9B414);
					continue;
				case 106u:
					Form1.smethod_3((Control)(object)label6, new Size(0, 16));
					num = ((int)num2 * -1958526078) ^ 0x506A1E32;
					continue;
				case 105u:
					Form1.smethod_61((Control)(object)button2, "button2");
					num = (int)(num2 * 1200216436) ^ -1104992777;
					continue;
				case 103u:
					Form1.smethod_77((Control)(object)label6, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = ((int)num2 * -709421753) ^ -1346228451;
					continue;
				case 102u:
					num = (int)((num2 * 1479435878) ^ 0x4AD0833F);
					continue;
				case 101u:
					Form1.smethod_74((Control)(object)label1, bool_0: true);
					num = ((int)num2 * -1653215116) ^ 0x58849259;
					continue;
				case 100u:
					num = ((int)num2 * -152074549) ^ -2057299165;
					continue;
				case 99u:
					num3++;
					num = ((int)num2 * -1604040067) ^ -797463289;
					continue;
				case 98u:
					num = (int)(num2 * 981836353) ^ -1194090079;
					continue;
				case 97u:
					Form1.smethod_4((Control)(object)label6, new Point(275, 0));
					Form1.smethod_61((Control)(object)label6, "label6");
					num = ((int)num2 * -1163737822) ^ 0x7896C4D5;
					continue;
				case 96u:
					Form1.smethod_3((Control)(object)panel1, new Size(486, 240));
					Form1.smethod_64((Control)(object)panel1, 7);
					num = ((int)num2 * -566363325) ^ -1902085955;
					continue;
				case 95u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)button2);
					num = ((int)num2 * -2108318182) ^ -400051039;
					continue;
				case 94u:
					Form1.smethod_75((Control)(object)label2, (DockStyle)3);
					num = ((int)num2 * -565939730) ^ 0x60681257;
					continue;
				case 93u:
					Form1.smethod_6((Control)(object)pictureBox1, new MouseEventHandler(PictureBox1_MouseDown));
					num = (int)((num2 * 1411178376) ^ 0x4A7C7CF7);
					continue;
				case 92u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label5);
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label2);
					num = ((int)num2 * -629407) ^ 0x5A957760;
					continue;
				case 91u:
					num = ((int)num2 * -621794472) ^ 0x563961AB;
					continue;
				case 90u:
					Form1.smethod_4((Control)(object)label2, new Point(0, 0));
					num = (int)(num2 * 909239911) ^ -1069909956;
					continue;
				case 89u:
					Form1.smethod_61((Control)(object)richTextBox1, "richTextBox1");
					num = (int)(num2 * 613410463) ^ -1124922760;
					continue;
				case 88u:
					Form1.smethod_80((ContainerControl)(object)this, (AutoScaleMode)1);
					num = ((int)num2 * -2008070753) ^ -476376729;
					continue;
				case 87u:
					pictureBox1 = Form1.smethod_2();
					num = (int)(num2 * 1542760146) ^ -487444052;
					continue;
				case 86u:
					Form1.smethod_60(pictureBox1, (BorderStyle)2);
					num = (int)((num2 * 536836933) ^ 0x7F7F65A5);
					continue;
				case 85u:
					Form1.smethod_64((Control)(object)button2, 4);
					num = (int)((num2 * 2043688747) ^ 0x1C971426);
					continue;
				case 84u:
					Form1.smethod_5((Control)(object)this, Color.White);
					num = (int)((num2 * 2112116991) ^ 0x852EDA);
					continue;
				case 83u:
					array[num3] = Form1.smethod_69(Form1.smethod_68(string_, num3 * 2, 2), 16);
					num = -1237493804;
					continue;
				case 82u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)button1);
					num = (int)((num2 * 45261774) ^ 0x6B18F0A8);
					continue;
				case 81u:
					num = (int)(num2 * 1944889152) ^ -1199309406;
					continue;
				case 80u:
					Form1.smethod_4((Control)(object)richTextBox1, new Point(107, 275));
					num = ((int)num2 * -214335773) ^ 0x6241B92C;
					continue;
				case 79u:
					Form1.smethod_74((Control)(object)label6, bool_0: true);
					num = (int)((num2 * 379256800) ^ 0x54A1166);
					continue;
				case 78u:
					string_ = Form1.smethod_34(string_, Veet.Xe);
					num = ((int)num2 * -1052968679) ^ -54549623;
					continue;
				case 77u:
					num = (int)((num2 * 1272205323) ^ 0x1986F38F);
					continue;
				case 76u:
					Form1.smethod_61((Control)(object)panel1, "panel1");
					num = (int)(num2 * 695208036) ^ -830589815;
					continue;
				case 75u:
					Form1.smethod_3((Control)(object)pictureBox1, new Size(246, 246));
					num = ((int)num2 * -1428882536) ^ -895182040;
					continue;
				case 74u:
					string_ = Form1.smethod_34(string_, Veet.Zr);
					num = (int)(num2 * 10745459) ^ -1578884870;
					continue;
				case 73u:
					Form1.smethod_72(timer1, 1000);
					num = (int)((num2 * 375332712) ^ 0x5BF193B6);
					continue;
				case 72u:
					num = (int)(num2 * 1478920243) ^ -693460692;
					continue;
				case 71u:
					num = (int)(num2 * 165998523) ^ -1952142827;
					continue;
				case 70u:
					Form1.smethod_32((Control)(object)richTextBox1, "");
					num = (int)((num2 * 1937176622) ^ 0xAD345A6);
					continue;
				case 69u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)panel1);
					num = ((int)num2 * -1589331050) ^ 0x4AC9E95A;
					continue;
				case 68u:
					Form1.smethod_4((Control)(object)label1, new Point(486, 0));
					num = ((int)num2 * -960979535) ^ -1322485687;
					continue;
				case 67u:
					Form1.smethod_3((Control)(object)label1, new Size(0, 16));
					Form1.smethod_64((Control)(object)label1, 8);
					Form1.smethod_74((Control)(object)label2, bool_0: true);
					num = ((int)num2 * -2027818757) ^ 0x5FD5BE6A;
					continue;
				case 66u:
					num = (int)(num2 * 542014224) ^ -1837196023;
					continue;
				case 64u:
					num3 = 0;
					num = ((int)num2 * -864709071) ^ -973388992;
					continue;
				case 63u:
					num = (int)(num2 * 842751951) ^ -859293620;
					continue;
				case 62u:
					num = ((int)num2 * -585779156) ^ -1593361446;
					continue;
				case 61u:
					Form1.smethod_88((Form)(object)this, (EventHandler)Form1_Shown);
					Form1.smethod_89((Control)(object)this, (EventHandler)Form1_LocationChanged);
					Form1.smethod_90((ISupportInitialize)pictureBox1);
					num = ((int)num2 * -444928718) ^ -1796923383;
					continue;
				case 60u:
					Form1.smethod_4((Control)(object)button2, new Point(391, 275));
					num = (int)((num2 * 1367603617) ^ 0x14183DF0);
					continue;
				case 59u:
					Form1.smethod_63(pictureBox1, bool_0: false);
					num = ((int)num2 * -706245868) ^ -548602652;
					continue;
				case 58u:
					Form1.smethod_3((Control)(object)label2, new Size(0, 16));
					num = ((int)num2 * -1757370393) ^ 0x126373BC;
					continue;
				case 57u:
					num = ((int)num2 * -1218375312) ^ 0x7F0DB51;
					continue;
				case 56u:
					num = ((int)num2 * -1286904427) ^ 0x378B4E3C;
					continue;
				case 55u:
					num = (int)((num2 * 916849037) ^ 0x3CB6FF56);
					continue;
				case 54u:
					num = (int)(num2 * 2115973334) ^ -1976566835;
					continue;
				case 53u:
				{
					int num4;
					if (num3 >= 22528)
					{
						num = -1288405830;
						num4 = -1288405830;
					}
					else
					{
						num = -1265359818;
						num4 = -1265359818;
					}
					continue;
				}
				case 52u:
					num = (int)(num2 * 1396834059) ^ -1945468943;
					continue;
				case 51u:
					Form1.smethod_66((ButtonBase)(object)button2, bool_0: true);
					num = (int)(num2 * 2059965219) ^ -217968608;
					continue;
				case 50u:
					Form1.smethod_65((Control)(object)button1, bool_0: false);
					num = (int)((num2 * 597019038) ^ 0x10932E5E);
					continue;
				case 49u:
					Form1.smethod_3((Control)(object)label5, new Size(0, 16));
					num = ((int)num2 * -798759200) ^ -696452663;
					continue;
				case 48u:
					Form1.smethod_61((Control)(object)label2, "label2");
					num = ((int)num2 * -1927593890) ^ -701063137;
					continue;
				case 47u:
					Form1.smethod_4((Control)(object)pictureBox1, new Point(120, 22));
					num = ((int)num2 * -913285923) ^ 0x251B124F;
					continue;
				case 46u:
					Form1.smethod_74((Control)(object)label5, bool_0: true);
					num = (int)(num2 * 1915083338) ^ -1414336684;
					continue;
				case 45u:
					Form1.smethod_85((Control)(object)this, "Form1");
					Form1.smethod_86((Form)(object)this, bool_0: false);
					Form1.smethod_32((Control)(object)this, "Quarto");
					num = (int)((num2 * 175163662) ^ 0x47CDA000);
					continue;
				case 44u:
					num = ((int)num2 * -1926094672) ^ -617079384;
					continue;
				case 43u:
					Form1.smethod_64((Control)(object)label6, 13);
					num = ((int)num2 * -471458597) ^ -1421341612;
					continue;
				case 42u:
					Form1.smethod_64((Control)(object)button1, 5);
					num = (int)(num2 * 836326043) ^ -1598667375;
					continue;
				case 41u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)pictureBox1);
					num = ((int)num2 * -835063493) ^ 0x1208A59B;
					continue;
				case 40u:
					num = ((int)num2 * -934316204) ^ -2125680569;
					continue;
				case 39u:
					Form1.smethod_71((TextBoxBase)(object)richTextBox1, bool_0: true);
					Form1.smethod_3((Control)(object)richTextBox1, new Size(272, 35));
					num = (int)((num2 * 452406434) ^ 0x712EBA5B);
					continue;
				case 38u:
					Form1.smethod_70(ComMember, object_);
					num = (int)(num2 * 1566107735) ^ -982361216;
					continue;
				case 37u:
					Form1.smethod_62(pictureBox1, 0);
					num = ((int)num2 * -698518152) ^ 0x3D9932DE;
					continue;
				case 36u:
					Form1.smethod_4((Control)(object)label5, new Point(197, 0));
					Form1.smethod_61((Control)(object)label5, "label5");
					num = (int)((num2 * 1277779250) ^ 0x20E11F5D);
					continue;
				case 35u:
					num = (int)((num2 * 567359470) ^ 0x591A5E68);
					continue;
				case 34u:
					Form1.smethod_79((ContainerControl)(object)this, new SizeF(6f, 13f));
					num = ((int)num2 * -1817199387) ^ -1515749792;
					continue;
				case 33u:
					num = ((int)num2 * -1365176712) ^ -843551602;
					continue;
				case 32u:
					num = ((int)num2 * -1171680476) ^ -1450631787;
					continue;
				case 31u:
					num = ((int)num2 * -663513507) ^ -1187489978;
					continue;
				case 30u:
					Form1.smethod_3((Control)(object)button1, new Size(83, 35));
					num = ((int)num2 * -425443040) ^ -61481297;
					continue;
				case 29u:
					Form1.smethod_77((Control)(object)label5, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = ((int)num2 * -737505609) ^ -1393642932;
					continue;
				case 28u:
					num = (int)(num2 * 1536553222) ^ -1934939894;
					continue;
				case 27u:
					Form1.smethod_81((Form)(object)this, new Size(486, 319));
					num = ((int)num2 * -1402149917) ^ 0x3EB0B037;
					continue;
				case 26u:
					num = ((int)num2 * -801782543) ^ -1398237405;
					continue;
				case 25u:
					num = ((int)num2 * -128176324) ^ -928244132;
					continue;
				case 24u:
					Form1.smethod_5((Control)(object)richTextBox1, Color.White);
					num = (int)((num2 * 975131195) ^ 0xBCA355D);
					continue;
				case 23u:
					Form1.smethod_64((Control)(object)label2, 9);
					num = ((int)num2 * -574907797) ^ -209380741;
					continue;
				case 22u:
					Form1.smethod_84((Form)(object)this, bool_0: false);
					num = ((int)num2 * -1386960128) ^ 0x32864118;
					continue;
				case 21u:
					Form1.smethod_59((Control)(object)this);
					Form1.smethod_5((Control)(object)pictureBox1, Color.FromArgb(64, 32, 0));
					num = (int)((num2 * 567514564) ^ 0x2C82A427);
					continue;
				case 20u:
					Form1.smethod_83((Form)(object)this, (FormBorderStyle)1);
					num = (int)(num2 * 9605152) ^ -584597301;
					continue;
				case 19u:
					label6 = Form1.smethod_57();
					Form1.smethod_58((ISupportInitialize)pictureBox1);
					num = ((int)num2 * -260540375) ^ 0x67AC51FB;
					continue;
				case 18u:
					num = (int)(num2 * 718819111) ^ -653801985;
					continue;
				case 17u:
					Form1.smethod_65((Control)(object)richTextBox1, bool_0: false);
					num = (int)((num2 * 377902586) ^ 0x15531624);
					continue;
				case 16u:
					Form1.smethod_61((Control)(object)label1, "label1");
					Form1.smethod_78((Control)(object)label1, (RightToLeft)0);
					num = (int)(num2 * 931982003) ^ -1098521602;
					continue;
				case 15u:
					Form1.smethod_65((Control)(object)button2, bool_0: false);
					num = (int)((num2 * 745373093) ^ 0x30AA4AF0);
					continue;
				case 14u:
					Form1.smethod_3((Control)(object)button2, new Size(83, 35));
					num = (int)(num2 * 1312353851) ^ -647079198;
					continue;
				case 13u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label1);
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)richTextBox1);
					num = (int)((num2 * 1260791318) ^ 0x3665245A);
					continue;
				case 12u:
					label1 = Form1.smethod_57();
					label2 = Form1.smethod_57();
					label5 = Form1.smethod_57();
					num = (int)((num2 * 575192250) ^ 0x6F78482E);
					continue;
				case 11u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label6);
					num = (int)((num2 * 437957125) ^ 0x484ADCA6);
					continue;
				case 10u:
					string_ = Veet.Sa;
					num = (int)((num2 * 2082549715) ^ 0x6C20AC4D);
					continue;
				case 9u:
					Form1.smethod_61((Control)(object)pictureBox1, "pictureBox1");
					num = ((int)num2 * -1446903911) ^ 0x527AA04F;
					continue;
				case 8u:
					Form1.smethod_32((Control)(object)button1, "Меню");
					Form1.smethod_66((ButtonBase)(object)button1, bool_0: true);
					num = ((int)num2 * -422968285) ^ 0x5C518672;
					continue;
				case 7u:
					Form1.smethod_67((Control)(object)button1, (EventHandler)Button1_Click);
					num = (int)((num2 * 1116258937) ^ 0x374FE8AA);
					continue;
				case 6u:
					Form1.smethod_77((Control)(object)label2, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = (int)((num2 * 373883801) ^ 0x1D56AB1F);
					continue;
				case 5u:
					Form1.smethod_4((Control)(object)panel1, new Point(0, 24));
					num = (int)(num2 * 965537304) ^ -372167671;
					continue;
				case 4u:
					Form1.smethod_67((Control)(object)button2, (EventHandler)Button2_Click);
					Form1.smethod_4((Control)(object)button1, new Point(12, 275));
					Form1.smethod_61((Control)(object)button1, "button1");
					num = (int)(num2 * 426135645) ^ -17071165;
					continue;
				case 3u:
					num = (int)(num2 * 619078057) ^ -358090696;
					continue;
				case 2u:
					num = (int)((num2 * 1445806192) ^ 0x4138EC1A);
					continue;
				case 1u:
					object_ = new object[3]
					{
						Player.MembershipCondition(0),
						Player.MembershipCondition(1),
						"Cytotechnologist"
					};
					num = (int)((num2 * 1409920755) ^ 0x73EB7410);
					continue;
				case 0u:
					num = (int)(num2 * 1789719457) ^ -190220009;
					continue;
				default:
					return;
				case 104u:
					break;
				case 65u:
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
			int num = 456245448;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x551608ADu) % 3u)
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
				num = ((int)num2 * -1001205264) ^ 0x3AED7A40;
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
			int num = -1851814515;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xFE3E3FBCu) % 3u)
				{
				case 1u:
					goto IL_0003;
				default:
					return;
				case 2u:
					break;
				case 0u:
					return;
				}
				break;
				IL_0003:
				ComMember = Form1.smethod_95(Q3)[24];
				num = (int)((num2 * 1258985333) ^ 0x6EBF0030);
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
