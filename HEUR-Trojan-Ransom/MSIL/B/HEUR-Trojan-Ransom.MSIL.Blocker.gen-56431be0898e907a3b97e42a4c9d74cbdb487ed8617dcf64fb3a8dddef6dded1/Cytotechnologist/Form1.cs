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
				int num = -1306884972;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xBD1E0C59u) % 6u)
					{
					case 5u:
						Dark = copy.Dark;
						Big = copy.Big;
						Square = copy.Square;
						num = (int)((num2 * 442482320) ^ 0x29DDD005);
						continue;
					case 4u:
						num = (int)((num2 * 625945703) ^ 0x123C4F6E);
						continue;
					case 3u:
						num = ((int)num2 * -1328746904) ^ -1491768957;
						continue;
					case 0u:
						Point = copy.Point;
						num = (int)((num2 * 146849520) ^ 0x6706A2B0);
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
			int num = -1810301006;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA694058Eu) % 3u)
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
				num = (int)(num2 * 1708659060) ^ -383117141;
			}
		}
	}

	private void Form1_Shown(object sender, EventArgs e)
	{
		Form1.smethod_14(menu);
	}

	public void Button1_Click(object sender, EventArgs e)
	{
		while (true)
		{
			int num = 1325231354;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x5396DA33u) % 8u)
				{
				case 6u:
				{
					Form control_ = menu;
					Form1.smethod_17((Control)(object)control_, Form1.smethod_16((Control)(object)control_) + 5);
					num = ((int)num2 * -1985768878) ^ 0x51C63D7B;
					continue;
				}
				case 5u:
					num = ((int)num2 * -348198024) ^ -1364956080;
					continue;
				case 4u:
					num = ((int)num2 * -494901514) ^ -2134777392;
					continue;
				case 3u:
				{
					int num3;
					if (Form1.smethod_16((Control)(object)menu) >= 296)
					{
						num = 1481296235;
						num3 = 1481296235;
					}
					else
					{
						num = 126638641;
						num3 = 126638641;
					}
					continue;
				}
				case 2u:
					num = 263966933;
					continue;
				case 1u:
					Form1.smethod_15(timer1);
					num = (int)(num2 * 1416277653) ^ -1867802989;
					continue;
				case 7u:
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
		bool flag = default(bool);
		int num4 = default(int);
		int num3 = default(int);
		while (true)
		{
			int num = -1402838265;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xFB5DC8BBu) % 17u)
				{
				case 16u:
					board = new Figurine[4, 4];
					num = ((int)num2 * -180588521) ^ 0x2CB3A666;
					continue;
				case 15u:
				{
					int num6;
					int num7;
					if (!flag)
					{
						num6 = -2064739951;
						num7 = -2064739951;
					}
					else
					{
						num6 = -2046386488;
						num7 = -2046386488;
					}
					num = num6 ^ ((int)num2 * -882590603);
					continue;
				}
				case 14u:
					num = (int)(num2 * 1491721083) ^ -1760508950;
					continue;
				case 13u:
					num = ((int)num2 * -1394072245) ^ -1642733219;
					continue;
				case 12u:
					Paint_Storage();
					num = ((int)num2 * -299488035) ^ -803180062;
					continue;
				case 11u:
					storage = new Figurine[4, 4];
					num4 = 0;
					num = ((int)num2 * -1075330943) ^ -492694133;
					continue;
				case 10u:
					flag = num3 < 4;
					num = -1647835393;
					continue;
				case 9u:
					num4++;
					num = (int)((num2 * 1087710293) ^ 0x62A2C1AF);
					continue;
				case 7u:
					Form1.smethod_7((Control)(object)button2, bool_0: false);
					num = ((int)num2 * -427734822) ^ -200832948;
					continue;
				case 6u:
					Paint_Board();
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: false);
					num = ((int)num2 * -697937279) ^ -1514293427;
					continue;
				case 5u:
					num = ((int)num2 * -1880571563) ^ 0x74FE14A1;
					continue;
				case 4u:
					num3 = 0;
					num = -892184814;
					continue;
				case 3u:
					storage[num4, num3] = new Figurine(num4 < 2, num3 % 2 == 0, num3 < 2, num4 % 2 == 1);
					Form1.smethod_5((Control)(object)borderBox[num4, num3], Color.White);
					Form1.smethod_7((Control)(object)pictureBox[num4, num3], bool_0: false);
					num = -1227358651;
					continue;
				case 2u:
				{
					int num5;
					if (num4 >= 4)
					{
						num = -492135801;
						num5 = -492135801;
					}
					else
					{
						num = -590993583;
						num5 = -590993583;
					}
					continue;
				}
				case 0u:
					num3++;
					num = ((int)num2 * -345482893) ^ -1875968778;
					continue;
				default:
					return;
				case 8u:
					break;
				case 1u:
					return;
				}
				break;
			}
		}
	}

	private void Paint_Board()
	{
		bool square = default(bool);
		int num3 = default(int);
		int num5 = default(int);
		Graphics graphics_ = default(Graphics);
		float num8 = default(float);
		bool dark = default(bool);
		bool flag = default(bool);
		bool point = default(bool);
		float num4 = default(float);
		float num13 = default(float);
		float num6 = default(float);
		float num14 = default(float);
		Brush brush_ = default(Brush);
		while (true)
		{
			int num = -164805436;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9E41F6EFu) % 40u)
				{
				case 39u:
					square = board[num3, num5].Square;
					num = ((int)num2 * -519606508) ^ -1026285023;
					continue;
				case 37u:
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox1));
					num = (int)(num2 * 620841488) ^ -148188962;
					continue;
				case 36u:
				{
					int num16;
					if (num5 >= 4)
					{
						num = -2132264539;
						num16 = -2132264539;
					}
					else
					{
						num = -397356089;
						num16 = -397356089;
					}
					continue;
				}
				case 35u:
					num8 = 1f;
					num = (int)(num2 * 1776151859) ^ -1158139973;
					continue;
				case 34u:
					num5++;
					num = ((int)num2 * -1838868587) ^ 0x551AF481;
					continue;
				case 33u:
					num = ((int)num2 * -985430132) ^ -1868461937;
					continue;
				case 32u:
					Form1.smethod_24(graphics_, Form1.smethod_23(), ((float)num5 + 0.05f) * (float)size, ((float)num3 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					num = -1772211585;
					continue;
				case 31u:
					dark = board[num3, num5].Dark;
					num = ((int)num2 * -1858825756) ^ 0x69265A37;
					continue;
				case 30u:
					flag = board[num3, num5] != null;
					num = ((int)num2 * -853872050) ^ -1365120034;
					continue;
				case 29u:
				{
					int num11;
					int num12;
					if (!flag)
					{
						num11 = 948298132;
						num12 = 948298132;
					}
					else
					{
						num11 = 1480084602;
						num12 = 1480084602;
					}
					num = num11 ^ ((int)num2 * -1806050001);
					continue;
				}
				case 27u:
				{
					int num19;
					int num20;
					if (!point)
					{
						num19 = -55654495;
						num20 = -55654495;
					}
					else
					{
						num19 = -1976609888;
						num20 = -1976609888;
					}
					num = num19 ^ ((int)num2 * -1841558200);
					continue;
				}
				case 26u:
				{
					int num17;
					int num18;
					if (square)
					{
						num17 = 198695656;
						num18 = 198695656;
					}
					else
					{
						num17 = 256200191;
						num18 = 256200191;
					}
					num = num17 ^ (int)(num2 * 1858973723);
					continue;
				}
				case 25u:
					num4 = (float)size * (num13 / 2f);
					num6 = num14 * 0.9f / (float)Form1.smethod_27(2.0);
					num = ((int)num2 * -344854164) ^ -186839476;
					continue;
				case 24u:
					num = (int)((num2 * 259669783) ^ 0x1E71D81);
					continue;
				case 23u:
				{
					int num15;
					if (num3 < 4)
					{
						num = -1263333442;
						num15 = -1263333442;
					}
					else
					{
						num = -1469917637;
						num15 = -1469917637;
					}
					continue;
				}
				case 22u:
					num = (int)(num2 * 1325434955) ^ -502588022;
					continue;
				case 21u:
					num14 = (float)size * num8;
					num = (int)(num2 * 1698679135) ^ -425523739;
					continue;
				case 20u:
					brush_ = Form1.smethod_25();
					num = (int)((num2 * 1597465313) ^ 0x15EC15EB);
					continue;
				case 19u:
					num13 = 1f - num8 * 0.4f / (float)Form1.smethod_27(2.0);
					num4 = (float)size * (num13 / 2f);
					num6 = num14 * 0.4f / (float)Form1.smethod_27(2.0);
					num = -2088659364;
					continue;
				case 18u:
					brush_ = Form1.smethod_26();
					num = -1657556776;
					continue;
				case 17u:
					Form1.smethod_28(graphics_, brush_, num4 + (float)(num5 * size), num4 + (float)(num3 * size), num6, num6);
					num = ((int)num2 * -301437878) ^ 0x5018674;
					continue;
				case 16u:
					num8 = 0.7f;
					num = -295746382;
					continue;
				case 15u:
					Form1.smethod_24(graphics_, (Brush)(object)Form1.smethod_29(Color.FromArgb(180, Color.Peru)), num4 + (float)(num5 * size), num4 + (float)(num3 * size), num6, num6);
					num = ((int)num2 * -46996484) ^ 0x1975E35D;
					continue;
				case 14u:
					num = -2112141233;
					continue;
				case 13u:
					num13 = 1f - num8 * 0.9f / (float)Form1.smethod_27(2.0);
					num = -1056641766;
					continue;
				case 12u:
				{
					int num9;
					int num10;
					if (!dark)
					{
						num9 = 1717396337;
						num10 = 1717396337;
					}
					else
					{
						num9 = 327066551;
						num10 = 327066551;
					}
					num = num9 ^ ((int)num2 * -540935679);
					continue;
				}
				case 11u:
					point = board[num3, num5].Point;
					num = (int)((num2 * 757350508) ^ 0xDCA8918);
					continue;
				case 10u:
					num3++;
					num = ((int)num2 * -1033035635) ^ -915193846;
					continue;
				case 9u:
					num5 = 0;
					num = -874046069;
					continue;
				case 8u:
					num = -2120274803;
					continue;
				case 7u:
				{
					int num7;
					if (!board[num3, num5].Big)
					{
						num = -1703925665;
						num7 = -1703925665;
					}
					else
					{
						num = -15057876;
						num7 = -15057876;
					}
					continue;
				}
				case 6u:
					Form1.smethod_24(graphics_, brush_, num4 + (float)(num5 * size), num4 + (float)(num3 * size), num6, num6);
					num = -1072566172;
					continue;
				case 5u:
					num = (int)((num2 * 1663831887) ^ 0x7A5D9831);
					continue;
				case 4u:
					num = ((int)num2 * -54836173) ^ 0x55F7EE20;
					continue;
				case 3u:
					Form1.smethod_20(pictureBox1, (Image)(object)Form1.smethod_19(Form1.smethod_18((Control)(object)pictureBox1), Form1.smethod_16((Control)(object)pictureBox1)));
					num = ((int)num2 * -935779180) ^ 0x666832F9;
					continue;
				case 2u:
					num = (int)((num2 * 1791013798) ^ 0x3547FABE);
					continue;
				case 1u:
					num3 = 0;
					num = (int)(num2 * 1791424323) ^ -357522389;
					continue;
				case 0u:
					num = ((int)num2 * -712727575) ^ -1164699904;
					continue;
				case 38u:
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
		Brush brush_ = default(Brush);
		float num6 = default(float);
		float num5 = default(float);
		int num3 = default(int);
		float num9 = default(float);
		float num12 = default(float);
		float num7 = default(float);
		bool dark = default(bool);
		int num4 = default(int);
		Graphics graphics_ = default(Graphics);
		bool big = default(bool);
		bool flag2 = default(bool);
		bool flag = default(bool);
		while (true)
		{
			int num = -1750674729;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9FA4B16Du) % 39u)
				{
				case 38u:
					brush_ = Form1.smethod_25();
					num = ((int)num2 * -1968387602) ^ 0xFF3399C;
					continue;
				case 37u:
					num6 = (float)size * (num5 / 2f) - 4f;
					num = (int)((num2 * 1973446564) ^ 0x34B5A18C);
					continue;
				case 36u:
					num3++;
					num = -1652957937;
					continue;
				case 35u:
					num = ((int)num2 * -96510247) ^ 0x47770F6A;
					continue;
				case 34u:
					num9 = (float)size * num12;
					num = ((int)num2 * -1003159513) ^ -323338247;
					continue;
				case 33u:
					num = ((int)num2 * -1123707665) ^ -455544191;
					continue;
				case 32u:
					num = ((int)num2 * -1667664775) ^ -758056220;
					continue;
				case 31u:
					num7 = num9 * 0.9f / (float)Form1.smethod_27(2.0);
					num = (int)((num2 * 1519592616) ^ 0xAC89059);
					continue;
				case 30u:
				{
					int num18;
					int num19;
					if (dark)
					{
						num18 = -365571760;
						num19 = -365571760;
					}
					else
					{
						num18 = -1971559631;
						num19 = -1971559631;
					}
					num = num18 ^ (int)(num2 * 1330252513);
					continue;
				}
				case 29u:
					num = ((int)num2 * -451139924) ^ 0x4818E02D;
					continue;
				case 28u:
				{
					int num13;
					int num14;
					if (storage[num4, num3].Point)
					{
						num13 = -1150574355;
						num14 = -1150574355;
					}
					else
					{
						num13 = -18430860;
						num14 = -18430860;
					}
					num = num13 ^ ((int)num2 * -145345806);
					continue;
				}
				case 27u:
					num7 = num9 * 0.4f / (float)Form1.smethod_27(2.0);
					num = ((int)num2 * -498637936) ^ 0x533B7B74;
					continue;
				case 26u:
					Form1.smethod_28(graphics_, brush_, num6, num6, num7, num7);
					num = (int)((num2 * 259732212) ^ 0x74A4BD9C);
					continue;
				case 25u:
					num4 = 0;
					num = (int)((num2 * 1161561290) ^ 0x12AA170A);
					continue;
				case 24u:
					Form1.smethod_30((Control)(object)pictureBox[num4, num3]);
					num = -1554858875;
					continue;
				case 23u:
					num12 = 0.7f;
					num = -1827122040;
					continue;
				case 22u:
					big = storage[num4, num3].Big;
					num = -1387833877;
					continue;
				case 21u:
					num12 = 1f;
					num = ((int)num2 * -1742037011) ^ 0xD849644;
					continue;
				case 20u:
					num4++;
					num = (int)(num2 * 904458228) ^ -2123220426;
					continue;
				case 19u:
					num5 = 1f - num12 * 0.9f / (float)Form1.smethod_27(2.0);
					num = -1802705033;
					continue;
				case 18u:
				{
					int num20;
					int num21;
					if (!big)
					{
						num20 = -835425796;
						num21 = -835425796;
					}
					else
					{
						num20 = -1893483137;
						num21 = -1893483137;
					}
					num = num20 ^ (int)(num2 * 377259261);
					continue;
				}
				case 17u:
					num = ((int)num2 * -1081740916) ^ -698994709;
					continue;
				case 16u:
					Form1.smethod_20(pictureBox[num4, num3], (Image)(object)Form1.smethod_19(Form1.smethod_18((Control)(object)pictureBox[num4, num3]), Form1.smethod_16((Control)(object)pictureBox[num4, num3])));
					num = (int)((num2 * 372143518) ^ 0x56DCBB39);
					continue;
				case 15u:
				{
					int num16;
					int num17;
					if (flag2)
					{
						num16 = 987961125;
						num17 = 987961125;
					}
					else
					{
						num16 = 2080421923;
						num17 = 2080421923;
					}
					num = num16 ^ (int)(num2 * 1006138504);
					continue;
				}
				case 13u:
					num = ((int)num2 * -274829813) ^ -1778402774;
					continue;
				case 12u:
				{
					int num15;
					if (storage[num4, num3] == null)
					{
						num = -1026764693;
						num15 = -1026764693;
					}
					else
					{
						num = -1608593574;
						num15 = -1608593574;
					}
					continue;
				}
				case 11u:
					num5 = 1f - num12 * 0.4f / (float)Form1.smethod_27(2.0);
					num = -1473555205;
					continue;
				case 10u:
					num3 = 0;
					num = -1652957937;
					continue;
				case 9u:
				{
					int num10;
					int num11;
					if (!flag)
					{
						num10 = -2097153197;
						num11 = -2097153197;
					}
					else
					{
						num10 = -637122130;
						num11 = -637122130;
					}
					num = num10 ^ (int)(num2 * 807915331);
					continue;
				}
				case 8u:
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox[num4, num3]));
					dark = storage[num4, num3].Dark;
					num = (int)(num2 * 1900977344) ^ -421208091;
					continue;
				case 7u:
					Form1.smethod_24(graphics_, brush_, num6, num6, num7, num7);
					num = -1031351262;
					continue;
				case 6u:
				{
					int num8;
					if (num3 >= 4)
					{
						num = -197568069;
						num8 = -197568069;
					}
					else
					{
						num = -135846892;
						num8 = -135846892;
					}
					continue;
				}
				case 5u:
					Form1.smethod_24(graphics_, (Brush)(object)Form1.smethod_29(Color.FromArgb(180, Color.Peru)), num6, num6, num7, num7);
					num = ((int)num2 * -1761050179) ^ 0x3A226635;
					continue;
				case 4u:
					num6 = (float)size * (num5 / 2f) - 4f;
					num = (int)(num2 * 1672956304) ^ -120110859;
					continue;
				case 3u:
					flag2 = num4 < 4;
					num = -1423554644;
					continue;
				case 2u:
					brush_ = Form1.smethod_26();
					num = -2141392808;
					continue;
				case 1u:
					flag = num3 < 2;
					num = ((int)num2 * -948975350) ^ 0x7A2C1F75;
					continue;
				default:
					return;
				case 14u:
					break;
				case 0u:
					return;
				}
				break;
			}
		}
	}

	public void StartGame()
	{
		int num3 = default(int);
		bool flag = default(bool);
		bool flag2 = default(bool);
		int num4 = default(int);
		while (true)
		{
			int num = 1657597288;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7E4D50EDu) % 25u)
				{
				case 24u:
					time = new DateTime(0L, DateTimeKind.Unspecified);
					Form1.smethod_35(timer1, bool_0: true);
					num = (int)(num2 * 533157313) ^ -465138725;
					continue;
				case 23u:
					num = ((int)num2 * -1184290962) ^ -1945533402;
					continue;
				case 22u:
					Form1.smethod_32((Control)(object)richTextBox1, "Ваш ход. Выберете фигуру, которой будет играть противник.");
					num = ((int)num2 * -519950966) ^ -2039321895;
					continue;
				case 21u:
					num3++;
					num = (int)((num2 * 288455624) ^ 0x3231DCB7);
					continue;
				case 20u:
				{
					int num8;
					int num9;
					if (flag)
					{
						num8 = -1136516393;
						num9 = -1136516393;
					}
					else
					{
						num8 = -446305115;
						num9 = -446305115;
					}
					num = num8 ^ ((int)num2 * -2139144820);
					continue;
				}
				case 19u:
					step = 0;
					num = ((int)num2 * -66504644) ^ -1959890053;
					continue;
				case 18u:
					num = (int)(num2 * 392200699) ^ -1180183904;
					continue;
				case 17u:
					Form1.smethod_32((Control)(object)richTextBox1, "Противник выбрал фигуру. Выберете поле на доске для установки этой фигуры.");
					step = 1;
					num = (int)(num2 * 1108437420) ^ -587330850;
					continue;
				case 16u:
				{
					int num10;
					int num11;
					if (flag2)
					{
						num10 = 1201693626;
						num11 = 1201693626;
					}
					else
					{
						num10 = 733676050;
						num11 = 733676050;
					}
					num = num10 ^ ((int)num2 * -545325738);
					continue;
				}
				case 15u:
					flag = num4 < 4;
					num = 644545180;
					continue;
				case 14u:
					num = ((int)num2 * -1466414034) ^ -891303896;
					continue;
				case 13u:
					num = 1579949019;
					continue;
				case 12u:
					flag2 = turn;
					num = ((int)num2 * -1805172097) ^ 0x6FC9C09F;
					continue;
				case 11u:
				{
					int num7;
					if (num3 >= 4)
					{
						num = 302995215;
						num7 = 302995215;
					}
					else
					{
						num = 788574380;
						num7 = 788574380;
					}
					continue;
				}
				case 10u:
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: true);
					num = ((int)num2 * -1878395052) ^ -1611131755;
					continue;
				case 9u:
					Form1_Load(this, Form1.smethod_31());
					num = (int)(num2 * 1501063142) ^ -1532627700;
					continue;
				case 8u:
				{
					int num5 = Form1.smethod_33(rnd, 4);
					int num6 = Form1.smethod_33(rnd, 4);
					Form1.smethod_5((Control)(object)borderBox[num5, num6], Color.Blue);
					num = (int)(num2 * 370434930) ^ -467163907;
					continue;
				}
				case 5u:
					Form1.smethod_32((Control)(object)label2, Form1.smethod_34("Ход: ", step.ToString()));
					num = 1412054057;
					continue;
				case 4u:
					num3 = 0;
					num = ((int)num2 * -169537603) ^ -851460700;
					continue;
				case 3u:
					num = ((int)num2 * -863514818) ^ 0x78E77594;
					continue;
				case 2u:
					num4 = 0;
					num = 862486316;
					continue;
				case 1u:
					num = ((int)num2 * -1673331696) ^ -66686676;
					continue;
				case 0u:
					Form1.smethod_7((Control)(object)pictureBox[num3, num4], bool_0: true);
					num4++;
					num = 598485126;
					continue;
				case 7u:
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
		Form1.smethod_32((Control)(object)label1, Form1.smethod_34("Время: ", time.ToString("HH:mm:ss")));
	}

	private void PictureBoxIJ_MouseDown(object sender, MouseEventArgs e)
	{
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ec: Expected O, but got Unknown
		int num6 = default(int);
		int num9 = default(int);
		int num3 = default(int);
		bool flag = default(bool);
		int num8 = default(int);
		while (true)
		{
			int num = 1972542149;
			while (true)
			{
				uint num2;
				int num7;
				switch ((num2 = (uint)num ^ 0x1B931F2Bu) % 22u)
				{
				case 21u:
					Form1.smethod_32((Control)(object)richTextBox1, "Именно эта фигура? Если да - нажмите \"Подтвердить\".");
					num = ((int)num2 * -1884634876) ^ 0x5A4521FD;
					continue;
				case 20u:
					num6++;
					num = ((int)num2 * -304161151) ^ 0x98F05A1;
					continue;
				case 19u:
					if (storage[num9, num3] != null)
					{
						num = 735885339;
						continue;
					}
					goto IL_006a;
				case 18u:
					num = (int)((num2 * 1837608155) ^ 0x13E03A64);
					continue;
				case 17u:
					num = ((int)num2 * -1755124358) ^ -1014734364;
					continue;
				case 16u:
				{
					int num11;
					int num12;
					if (!flag)
					{
						num11 = -2060505863;
						num12 = -2060505863;
					}
					else
					{
						num11 = -593349413;
						num12 = -593349413;
					}
					num = num11 ^ (int)(num2 * 597434937);
					continue;
				}
				case 15u:
					Form1.smethod_5((Control)(object)borderBox[num9, num3], Color.Red);
					num = ((int)num2 * -1421475030) ^ 0x70FDDAB2;
					continue;
				case 14u:
				{
					int num10;
					if (num6 >= 4)
					{
						num = 665746510;
						num10 = 665746510;
					}
					else
					{
						num = 332998597;
						num10 = 332998597;
					}
					continue;
				}
				case 13u:
					num3 -= 4;
					num = (int)(num2 * 1752115023) ^ -698146917;
					continue;
				case 12u:
					num8 = 0;
					num = 1095961296;
					continue;
				case 10u:
					num = (int)(num2 * 161692899) ^ -670762281;
					continue;
				case 9u:
					Form1.smethod_7((Control)(object)button2, bool_0: true);
					num = ((int)num2 * -1701532531) ^ -1505993793;
					continue;
				case 8u:
					num9 = Form1.smethod_37((Control)((sender is PictureBox) ? sender : null)).Y / size;
					num = (int)(num2 * 409542831) ^ -1016745019;
					continue;
				case 7u:
					flag = num8 < 4;
					num = 1415660523;
					continue;
				case 5u:
					num8++;
					num = ((int)num2 * -58581) ^ -1365904041;
					continue;
				case 4u:
					if (Form1.smethod_40((Bitmap)Form1.smethod_21(pictureBox[num9, num3]), Form1.smethod_38(e), Form1.smethod_39(e)) != Color.FromArgb(0, 0, 0, 0))
					{
						num = 459679971;
						num7 = 459679971;
						continue;
					}
					goto IL_006a;
				case 3u:
					num6 = 0;
					num = (int)(num2 * 1509863780) ^ -150198885;
					continue;
				case 2u:
					Form1.smethod_5((Control)(object)borderBox[num6, num8], Color.White);
					num = 641709356;
					continue;
				case 1u:
					num = (int)((num2 * 615219320) ^ 0x439916F8);
					continue;
				case 0u:
				{
					num3 = Form1.smethod_37((Control)((sender is PictureBox) ? sender : null)).X / size;
					int num4;
					int num5;
					if (num3 <= 1)
					{
						num4 = 961167690;
						num5 = 961167690;
					}
					else
					{
						num4 = 45513204;
						num5 = 45513204;
					}
					num = num4 ^ ((int)num2 * -1998727008);
					continue;
				}
				default:
					return;
				case 11u:
					break;
				case 6u:
					return;
					IL_006a:
					num = 1505035345;
					num7 = 1505035345;
					continue;
				}
				break;
			}
		}
	}

	private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
	{
		//IL_0216: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Expected O, but got Unknown
		int num = Form1.smethod_38(e) / size;
		int num12 = default(int);
		int num7 = default(int);
		bool flag2 = default(bool);
		int num8 = default(int);
		bool flag3 = default(bool);
		Graphics graphics_ = default(Graphics);
		bool flag = default(bool);
		while (true)
		{
			int num2 = 1788160029;
			while (true)
			{
				uint num3;
				int num6;
				switch ((num3 = (uint)num2 ^ 0x5A0E7AE4u) % 24u)
				{
				case 23u:
					num6 = ((board[num12, num] == null) ? 1 : 0);
					goto IL_0023;
				case 22u:
					num7++;
					num2 = 956418031;
					continue;
				case 21u:
				{
					int num13;
					int num14;
					if (!flag2)
					{
						num13 = 245969049;
						num14 = 245969049;
					}
					else
					{
						num13 = 643999948;
						num14 = 643999948;
					}
					num2 = num13 ^ ((int)num3 * -48924197);
					continue;
				}
				case 19u:
					num2 = ((int)num3 * -1563138889) ^ 0x6362026B;
					continue;
				case 18u:
					num2 = ((int)num3 * -1798942099) ^ 0x37A8E426;
					continue;
				case 17u:
					Form1.smethod_32((Control)(object)richTextBox1, "Уверены? Для выполнения данного хода нажмите \"Подтвердить\".");
					num2 = ((int)num3 * -215363783) ^ 0x15AF821C;
					continue;
				case 16u:
				{
					int num9;
					if (num8 < 4)
					{
						num2 = 118923298;
						num9 = 118923298;
					}
					else
					{
						num2 = 565723198;
						num9 = 565723198;
					}
					continue;
				}
				case 15u:
					num8 = 0;
					num2 = (int)((num3 * 1833180744) ^ 0xB275A4E);
					continue;
				case 14u:
					num7 = 0;
					num2 = 956418031;
					continue;
				case 13u:
					flag3 = Form1.smethod_41((Control)(object)borderBox[num8, num7]) == Color.Blue;
					num2 = 1437419191;
					continue;
				case 12u:
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox1));
					Form1.smethod_43(graphics_, Form1.smethod_42(Color.Red, 3f), ((float)num + 0.05f) * (float)size, ((float)num12 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					Form1.smethod_44(graphics_, Form1.smethod_21(pictureBox[num8, num7]), num * size + 4, num12 * size + 4, new Rectangle(0, 0, size, size), (GraphicsUnit)2);
					num2 = ((int)num3 * -933447649) ^ 0x27A67D30;
					continue;
				case 11u:
					flag = num7 < 4;
					num2 = 371419332;
					continue;
				case 10u:
					Paint_Board();
					num2 = (int)((num3 * 2137296231) ^ 0x416A43EE);
					continue;
				case 9u:
					num12 = Form1.smethod_39(e) / size;
					if (Form1.smethod_40((Bitmap)Form1.smethod_21(pictureBox1), Form1.smethod_38(e), Form1.smethod_39(e)) != Color.FromArgb(0, 0, 0, 0))
					{
						num2 = ((int)num3 * -1975085818) ^ 0x4F31FCBD;
						continue;
					}
					num6 = 0;
					goto IL_0023;
				case 8u:
					Form1.smethod_45(graphics_);
					num2 = ((int)num3 * -941380214) ^ 0x5C5E312B;
					continue;
				case 7u:
					num2 = (int)((num3 * 569719236) ^ 0xE1B7935);
					continue;
				case 6u:
					num8++;
					num2 = ((int)num3 * -1310123414) ^ 0x6F2E1350;
					continue;
				case 5u:
					Form1.smethod_30((Control)(object)pictureBox1);
					Form1.smethod_7((Control)(object)button2, bool_0: true);
					num2 = (int)((num3 * 1011608441) ^ 0x52E020C0);
					continue;
				case 4u:
					num2 = (int)((num3 * 1520837254) ^ 0x251D73C6);
					continue;
				case 3u:
				{
					int num10;
					int num11;
					if (flag3)
					{
						num10 = 22352364;
						num11 = 22352364;
					}
					else
					{
						num10 = 60999033;
						num11 = 60999033;
					}
					num2 = num10 ^ (int)(num3 * 1679384641);
					continue;
				}
				case 1u:
					num2 = ((int)num3 * -1334521014) ^ 0xE86EA3A;
					continue;
				case 0u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = 855179346;
						num5 = 855179346;
					}
					else
					{
						num4 = 1689132921;
						num5 = 1689132921;
					}
					num2 = num4 ^ ((int)num3 * -1080379808);
					continue;
				}
				default:
					return;
				case 20u:
					break;
				case 2u:
					return;
					IL_0023:
					flag2 = (byte)num6 != 0;
					num2 = 1082181313;
					continue;
				}
				break;
			}
		}
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		//IL_0436: Unknown result type (might be due to invalid IL or missing references)
		//IL_0464: Expected O, but got Unknown
		int num5 = default(int);
		int num6 = default(int);
		bool flag13 = default(bool);
		int num7 = default(int);
		int num29 = default(int);
		bool flag14 = default(bool);
		bool flag8 = default(bool);
		Figurine[,] array2 = default(Figurine[,]);
		int num21 = default(int);
		bool flag15 = default(bool);
		int num30 = default(int);
		int num17 = default(int);
		int num26 = default(int);
		int num14 = default(int);
		bool flag11 = default(bool);
		bool flag = default(bool);
		int num18 = default(int);
		Figurine[,] array = default(Figurine[,]);
		bool flag6 = default(bool);
		int num9 = default(int);
		int num10 = default(int);
		int num22 = default(int);
		bool flag3 = default(bool);
		int num25 = default(int);
		int num3 = default(int);
		int num4 = default(int);
		int num11 = default(int);
		bool flag12 = default(bool);
		bool flag16 = default(bool);
		bool flag5 = default(bool);
		Graphics graphics_ = default(Graphics);
		int num28 = default(int);
		int num27 = default(int);
		bool flag7 = default(bool);
		bool flag9 = default(bool);
		bool flag10 = default(bool);
		Figurine[,] array3 = default(Figurine[,]);
		bool flag4 = default(bool);
		int num31 = default(int);
		bool flag2 = default(bool);
		int num8 = default(int);
		while (true)
		{
			int num = -1923890857;
			while (true)
			{
				uint num2;
				int num33;
				int num40;
				int num12;
				int num38;
				switch ((num2 = (uint)num ^ 0xDF4BBF6Au) % 183u)
				{
				case 182u:
					Form1.smethod_47(200);
					Form1.smethod_5((Control)(object)borderBox[num5, num6], Color.White);
					num = (int)(num2 * 365746735) ^ -464665526;
					continue;
				case 181u:
					num = -814922352;
					continue;
				case 180u:
				{
					int num45;
					int num46;
					if (!flag13)
					{
						num45 = -1213821452;
						num46 = -1213821452;
					}
					else
					{
						num45 = -715283143;
						num46 = -715283143;
					}
					num = num45 ^ (int)(num2 * 1393920787);
					continue;
				}
				case 179u:
					num7++;
					num = (int)((num2 * 1640754549) ^ 0x2FFD57DA);
					continue;
				case 178u:
					num = ((int)num2 * -1230803675) ^ 0x200D48EC;
					continue;
				case 177u:
					if (!Stop(board))
					{
						num = ((int)num2 * -355955945) ^ 0x33B3BA05;
						continue;
					}
					goto IL_00cb;
				case 176u:
					num29++;
					num = ((int)num2 * -527355251) ^ -1600592309;
					continue;
				case 175u:
					storage[num5, num6] = null;
					num = ((int)num2 * -528455123) ^ -801388780;
					continue;
				case 174u:
					flag14 = Standoff(board);
					num = (int)(num2 * 2103809895) ^ -1217405403;
					continue;
				case 173u:
					(menu as Form3).ContinueLock();
					num = ((int)num2 * -1787905772) ^ -664329558;
					continue;
				case 172u:
				{
					int num36;
					int num37;
					if (flag8)
					{
						num36 = 384384218;
						num37 = 384384218;
					}
					else
					{
						num36 = 1093522132;
						num37 = 1093522132;
					}
					num = num36 ^ ((int)num2 * -1183500635);
					continue;
				}
				case 171u:
					Form1.smethod_32((Control)(object)richTextBox1, "Ничья!");
					Form1.smethod_15(timer1);
					num = (int)((num2 * 841770762) ^ 0x5F45227D);
					continue;
				case 170u:
					array2 = (Figurine[,])Form1.smethod_48((Array)board);
					num = ((int)num2 * -1443731750) ^ -239637007;
					continue;
				case 169u:
					num = (int)(num2 * 1641213832) ^ -873147323;
					continue;
				case 168u:
					num21 = 0;
					num = -483178284;
					continue;
				case 167u:
					Form1.smethod_47(200);
					num = ((int)num2 * -1132729481) ^ -500336236;
					continue;
				case 166u:
					num = (int)(num2 * 214150617) ^ -1496298628;
					continue;
				case 165u:
					num = -619740671;
					continue;
				case 164u:
				{
					int num59;
					int num60;
					if (flag15)
					{
						num59 = -427945208;
						num60 = -427945208;
					}
					else
					{
						num59 = -992951880;
						num60 = -992951880;
					}
					num = num59 ^ ((int)num2 * -31126070);
					continue;
				}
				case 163u:
					num30++;
					num = ((int)num2 * -369333991) ^ 0x7BA62266;
					continue;
				case 162u:
				{
					int num57;
					if (num21 < 4)
					{
						num = -445804594;
						num57 = -445804594;
					}
					else
					{
						num = -1156766856;
						num57 = -1156766856;
					}
					continue;
				}
				case 161u:
					num = ((int)num2 * -1378566668) ^ 0x2B9AF794;
					continue;
				case 160u:
					flag13 = num17 < 4;
					num = -1192778828;
					continue;
				case 159u:
					num26 = Form1.smethod_33(rnd, 4);
					num = (int)(num2 * 927559879) ^ -1431799044;
					continue;
				case 158u:
					num14 = 0;
					num = -32797872;
					continue;
				case 157u:
				{
					int num49;
					int num50;
					if (!Form1.smethod_46((Control)(object)pictureBox1))
					{
						num49 = 1513847601;
						num50 = 1513847601;
					}
					else
					{
						num49 = 2011824049;
						num50 = 2011824049;
					}
					num = num49 ^ ((int)num2 * -427529993);
					continue;
				}
				case 156u:
					num = -1789624707;
					continue;
				case 155u:
				{
					int num41;
					int num42;
					if (flag11)
					{
						num41 = -1768112714;
						num42 = -1768112714;
					}
					else
					{
						num41 = -1149690299;
						num42 = -1149690299;
					}
					num = num41 ^ (int)(num2 * 1319415525);
					continue;
				}
				case 154u:
					flag = Form1.smethod_41((Control)(object)borderBox[num18, num17]) == Color.Red;
					num = ((int)num2 * -1404310668) ^ -1323237191;
					continue;
				case 153u:
					num = ((int)num2 * -1729358487) ^ -2128521422;
					continue;
				case 152u:
					num = ((int)num2 * -390903535) ^ -1542202607;
					continue;
				case 151u:
					if (!Stop(array))
					{
						num = (int)(num2 * 74317988) ^ -1255197123;
						continue;
					}
					num33 = 1;
					goto IL_03c4;
				case 150u:
					flag6 = board[num9, num10] != null;
					num = ((int)num2 * -1978061211) ^ 0x23FCDF6;
					continue;
				case 149u:
					num = -2112232434;
					continue;
				case 148u:
					num22 = num14;
					num = ((int)num2 * -1564199120) ^ 0x2661D1F2;
					continue;
				case 147u:
					num = ((int)num2 * -135662080) ^ -1725908671;
					continue;
				case 146u:
					flag3 = Form1.smethod_40((Bitmap)Form1.smethod_21(pictureBox1), num14 * size + size / 2, (int)(((float)num7 + 0.05f) * (float)size)) == Color.FromArgb(255, 255, 0, 0);
					num = -148182905;
					continue;
				case 145u:
					num25 = num14;
					Form1.smethod_5((Control)(object)borderBox[num7, num14], Color.White);
					num = (int)(num2 * 170544567) ^ -283798771;
					continue;
				case 144u:
					num = ((int)num2 * -2091481903) ^ 0x194E41FF;
					continue;
				case 143u:
					num = ((int)num2 * -1261406866) ^ -805808725;
					continue;
				case 142u:
					Paint_Board();
					num = (int)((num2 * 1481677609) ^ 0x1F9C6D43);
					continue;
				case 141u:
					Form1.smethod_30((Control)(object)richTextBox1);
					num = (int)(num2 * 183934897) ^ -408068981;
					continue;
				case 140u:
					num = ((int)num2 * -430298219) ^ -1813043642;
					continue;
				case 139u:
					num6 = num17;
					num = (int)(num2 * 1543630074) ^ -70956001;
					continue;
				case 138u:
					Form1.smethod_20(pictureBox[num7, num14], (Image)null);
					Form1.smethod_30((Control)(object)pictureBox[num7, num14]);
					num = ((int)num2 * -284603244) ^ -1744069302;
					continue;
				case 137u:
					board[num3, num4] = new Figurine(storage[num5, num6]);
					num = ((int)num2 * -1343318666) ^ 0x1C60FE21;
					continue;
				case 136u:
					num3++;
					num = (int)((num2 * 1407116823) ^ 0xCBA44A);
					continue;
				case 135u:
					flag11 = num11 < 4;
					num = -1184467330;
					continue;
				case 134u:
					Form1.smethod_32((Control)(object)richTextBox1, "QUARTO! Компьютер выиграл!");
					num = -1283221261;
					continue;
				case 133u:
				{
					int num65;
					int num66;
					if (!flag6)
					{
						num65 = -330871297;
						num66 = -330871297;
					}
					else
					{
						num65 = -1712306180;
						num66 = -1712306180;
					}
					num = num65 ^ ((int)num2 * -39302424);
					continue;
				}
				case 132u:
					board[num9, num10] = new Figurine(storage[num5, num6]);
					num = ((int)num2 * -538664076) ^ 0x3D6E1BB6;
					continue;
				case 131u:
					num14++;
					num = -1044820293;
					continue;
				case 130u:
					Form1.smethod_7((Control)(object)pictureBox[num18, num17], bool_0: false);
					num = ((int)num2 * -501510879) ^ 0x3F9A9210;
					continue;
				case 129u:
					Form1.smethod_7((Control)(object)pictureBox[num30, num29], bool_0: true);
					num = -1297769404;
					continue;
				case 128u:
				{
					int num63;
					int num64;
					if (flag3)
					{
						num63 = 2108813020;
						num64 = 2108813020;
					}
					else
					{
						num63 = 351256327;
						num64 = 351256327;
					}
					num = num63 ^ ((int)num2 * -1724520887);
					continue;
				}
				case 127u:
					num = (int)(num2 * 1286201800) ^ -1139441617;
					continue;
				case 126u:
					flag12 = Standoff(board);
					num = -2023580674;
					continue;
				case 125u:
				{
					int num61;
					int num62;
					if (flag16)
					{
						num61 = 342531971;
						num62 = 342531971;
					}
					else
					{
						num61 = 1240093483;
						num62 = 1240093483;
					}
					num = num61 ^ ((int)num2 * -509490798);
					continue;
				}
				case 124u:
					num = (int)(num2 * 90253348) ^ -1745319285;
					continue;
				case 123u:
					num4 = 0;
					num = -242689138;
					continue;
				case 122u:
					num = -1777787353;
					continue;
				case 121u:
					Form1.smethod_32((Control)(object)richTextBox1, "Выберете фигуру, которой будет играть противник.");
					num = (int)((num2 * 610273647) ^ 0x4B975770);
					continue;
				case 120u:
					Form1.smethod_20(pictureBox[num5, num6], (Image)null);
					num = ((int)num2 * -925769635) ^ -166986562;
					continue;
				case 119u:
					flag16 = num14 < 4;
					num = -2073633534;
					continue;
				case 118u:
					flag5 = true;
					num = (int)(num2 * 98672048) ^ -930713427;
					continue;
				case 117u:
					Form1.smethod_44(graphics_, Form1.smethod_21(pictureBox[num5, num6]), num4 * size + 4, num3 * size + 4, new Rectangle(0, 0, size, size), (GraphicsUnit)2);
					num = (int)(num2 * 404049355) ^ -101702244;
					continue;
				case 116u:
					num40 = ((num28 < 9) ? 1 : 0);
					goto IL_081f;
				case 115u:
					Form1.smethod_30((Control)(object)pictureBox[num5, num6]);
					num = ((int)num2 * -655997078) ^ -2085676036;
					continue;
				case 114u:
					num27 = Form1.smethod_33(rnd, 4);
					num = (int)((num2 * 1810643096) ^ 0x354EC67C);
					continue;
				case 113u:
				{
					int num58;
					if (array2[num11, num21] != null)
					{
						num = -814922352;
						num58 = -814922352;
					}
					else
					{
						num = -1376325119;
						num58 = -1376325119;
					}
					continue;
				}
				case 112u:
					num = (int)(num2 * 1402812523) ^ -1671771078;
					continue;
				case 111u:
					Form1.smethod_30((Control)(object)borderBox[num18, num17]);
					num = (int)(num2 * 744591337) ^ -467416186;
					continue;
				case 110u:
					flag7 = num18 < 4;
					num = -1812971552;
					continue;
				case 109u:
					num = ((int)num2 * -1697237411) ^ -2039239732;
					continue;
				case 108u:
				{
					int num55;
					int num56;
					if (!flag14)
					{
						num55 = 707335467;
						num56 = 707335467;
					}
					else
					{
						num55 = 1527048604;
						num56 = 1527048604;
					}
					num = num55 ^ ((int)num2 * -1918199311);
					continue;
				}
				case 107u:
					num33 = (Standoff(array) ? 1 : 0);
					goto IL_03c4;
				case 106u:
					num = (int)((num2 * 1486044365) ^ 0x4C1D7B7D);
					continue;
				case 105u:
					num = ((int)num2 * -1220164612) ^ -1432534236;
					continue;
				case 104u:
					num = ((int)num2 * -78066426) ^ 0x5622BEB7;
					continue;
				case 103u:
					num = (int)(num2 * 1710165920) ^ -396205084;
					continue;
				case 102u:
					Form1.smethod_32((Control)(object)richTextBox1, "Противник сделал ход (зелёный). Выберете поле на доске для выбронной противником фигуры (синий).");
					num = ((int)num2 * -562936821) ^ 0x50624871;
					continue;
				case 101u:
					num = ((int)num2 * -278511623) ^ 0x5DB93089;
					continue;
				case 100u:
					num = (int)((num2 * 1813715843) ^ 0x8EAF12D);
					continue;
				case 99u:
					step++;
					num = ((int)num2 * -303999192) ^ 0x450FCCC6;
					continue;
				case 98u:
					num = ((int)num2 * -454476976) ^ 0x16938AAD;
					continue;
				case 97u:
					num = ((int)num2 * -858473200) ^ -2017521680;
					continue;
				case 96u:
					num = ((int)num2 * -1816822455) ^ 0x148BFD45;
					continue;
				case 95u:
					num = ((int)num2 * -632788548) ^ 0x1C9FB471;
					continue;
				case 94u:
				{
					int num53;
					int num54;
					if (flag9)
					{
						num53 = 942180601;
						num54 = 942180601;
					}
					else
					{
						num53 = 613511915;
						num54 = 613511915;
					}
					num = num53 ^ (int)(num2 * 1186602114);
					continue;
				}
				case 93u:
				{
					int num51;
					int num52;
					if (!flag10)
					{
						num51 = -2012707465;
						num52 = -2012707465;
					}
					else
					{
						num51 = -1459238788;
						num52 = -1459238788;
					}
					num = num51 ^ (int)(num2 * 1733872388);
					continue;
				}
				case 92u:
					num = (int)((num2 * 443188756) ^ 0x118AD032);
					continue;
				case 91u:
					array = (Figurine[,])Form1.smethod_48((Array)board);
					num = (int)(num2 * 1540468073) ^ -1308444830;
					continue;
				case 90u:
					Form1.smethod_44(graphics_, Form1.smethod_21(pictureBox[num5, num6]), num10 * size + 4, num9 * size + 4, new Rectangle(0, 0, size, size), (GraphicsUnit)2);
					num = (int)(num2 * 1263145255) ^ -877740775;
					continue;
				case 89u:
					num = (int)((num2 * 1394145984) ^ 0x2A9EBBE9);
					continue;
				case 88u:
					array3 = (Figurine[,])Form1.smethod_48((Array)array2);
					num = (int)(num2 * 689755138) ^ -616839858;
					continue;
				case 87u:
					num25 = 0;
					num = ((int)num2 * -2031886683) ^ 0x28855CB1;
					continue;
				case 86u:
				{
					int num47;
					int num48;
					if (!flag4)
					{
						num47 = -1553648193;
						num48 = -1553648193;
					}
					else
					{
						num47 = -404609993;
						num48 = -404609993;
					}
					num = num47 ^ ((int)num2 * -1059077371);
					continue;
				}
				case 85u:
					Form1.smethod_15(timer1);
					(menu as Form3).ContinueLock();
					num = -727842813;
					continue;
				case 84u:
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: false);
					num = (int)((num2 * 2025114922) ^ 0x4B99DC7);
					continue;
				case 83u:
					num = ((int)num2 * -1298222611) ^ -594039221;
					continue;
				case 82u:
					Form1.smethod_30((Control)(object)label2);
					num = ((int)num2 * -90576797) ^ 0x4AA84ABA;
					continue;
				case 81u:
					Form1.smethod_32((Control)(object)label2, Form1.smethod_34("Ход: ", step.ToString()));
					num = ((int)num2 * -1305815962) ^ -1194852513;
					continue;
				case 80u:
					Form1.smethod_43(graphics_, Form1.smethod_42(Color.LimeGreen, 3f), ((float)num10 + 0.05f) * (float)size, ((float)num9 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					num = ((int)num2 * -738587359) ^ -926050345;
					continue;
				case 79u:
					num = (int)((num2 * 336911120) ^ 0x7AEF1EB9);
					continue;
				case 78u:
					Form1.smethod_5((Control)(object)borderBox[num26, num27], Color.Blue);
					num = (int)((num2 * 1734882596) ^ 0x499A63B2);
					continue;
				case 77u:
					num5 = 0;
					num = (int)(num2 * 719048353) ^ -66316699;
					continue;
				case 76u:
					Form1.smethod_32((Control)(object)richTextBox1, "Подождите, компьютер делает свой ход.");
					num = ((int)num2 * -18934698) ^ 0x7F75089E;
					continue;
				case 75u:
					num31 = 0;
					num = ((int)num2 * -1029020050) ^ 0x4DA6F5E1;
					continue;
				case 74u:
					num = (int)(num2 * 1669777985) ^ -1190834829;
					continue;
				case 73u:
					flag8 = board[num3, num4] == null;
					num = -1660001704;
					continue;
				case 72u:
					array3[num11, num21] = new Figurine(storage[num26, num27]);
					num = ((int)num2 * -1474255243) ^ -1768013753;
					continue;
				case 71u:
					num = -651757065;
					continue;
				case 70u:
				{
					int num43;
					int num44;
					if (flag12)
					{
						num43 = -1869440554;
						num44 = -1869440554;
					}
					else
					{
						num43 = -1089403219;
						num44 = -1089403219;
					}
					num = num43 ^ (int)(num2 * 1636889328);
					continue;
				}
				case 69u:
					storage[num5, num6] = null;
					num = (int)((num2 * 423127795) ^ 0x68F1BF29);
					continue;
				case 68u:
					flag2 = num7 < 4;
					num = -1907431770;
					continue;
				case 67u:
					num8 = 0;
					num = (int)((num2 * 1926150548) ^ 0x4052B9D3);
					continue;
				case 66u:
					num = (int)(num2 * 1501338082) ^ -297432177;
					continue;
				case 65u:
					if (!flag5)
					{
						num = ((int)num2 * -2365537) ^ -1650477472;
						continue;
					}
					num40 = 1;
					goto IL_081f;
				case 64u:
					num9 = Form1.smethod_33(rnd, 4);
					num10 = Form1.smethod_33(rnd, 4);
					num = -1782890102;
					continue;
				case 63u:
					num4++;
					num = -1849277440;
					continue;
				case 62u:
					num11++;
					num = ((int)num2 * -385725404) ^ 0x1E5392A3;
					continue;
				case 61u:
					num = (int)(num2 * 1738591338) ^ -854987430;
					continue;
				case 60u:
					num = -530428807;
					continue;
				case 59u:
					flag10 = Form1.smethod_41((Control)(object)borderBox[num7, num14]) == Color.Blue;
					num = -1473618645;
					continue;
				case 58u:
				{
					int num39;
					if (num29 >= 4)
					{
						num = -1876255525;
						num39 = -1876255525;
					}
					else
					{
						num = -454182653;
						num39 = -454182653;
					}
					continue;
				}
				case 57u:
					if (num27 != num6)
					{
						goto IL_0ef3;
					}
					goto IL_0eff;
				case 56u:
					Form1.smethod_30((Control)(object)borderBox[num7, num14]);
					num = ((int)num2 * -1163668905) ^ 0x4124379D;
					continue;
				case 55u:
					num = (int)(num2 * 895365790) ^ -1225153992;
					continue;
				case 54u:
					num17 = 0;
					num = -504509097;
					continue;
				case 53u:
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: true);
					num = ((int)num2 * -173238601) ^ -549671368;
					continue;
				case 52u:
					num = -324546578;
					continue;
				case 51u:
					board[num31, num22] = new Figurine(storage[num8, num25]);
					storage[num8, num25] = null;
					num = (int)(num2 * 727564397) ^ -2021275179;
					continue;
				case 50u:
					num = (int)((num2 * 568215087) ^ 0x74EB99DC);
					continue;
				case 49u:
				{
					int num34;
					int num35;
					if (!flag7)
					{
						num34 = -1350693052;
						num35 = -1350693052;
					}
					else
					{
						num34 = -1314254304;
						num35 = -1314254304;
					}
					num = num34 ^ (int)(num2 * 1840661391);
					continue;
				}
				case 47u:
					Form1.smethod_30((Control)(object)borderBox[num26, num27]);
					num = ((int)num2 * -1071810142) ^ 0x27352DBB;
					continue;
				case 46u:
					Form1.smethod_30((Control)(object)pictureBox1);
					num = (int)(num2 * 647778100) ^ -970510282;
					continue;
				case 45u:
				{
					int num32;
					if (num30 < 4)
					{
						num = -132688793;
						num32 = -132688793;
					}
					else
					{
						num = -227702164;
						num32 = -227702164;
					}
					continue;
				}
				case 44u:
					num = ((int)num2 * -1797883786) ^ 0x4726F2D0;
					continue;
				case 43u:
					Form1.smethod_30((Control)(object)pictureBox1);
					num = (int)(num2 * 1918690266) ^ -83238080;
					continue;
				case 42u:
					Form1.smethod_32((Control)(object)richTextBox1, "Ничья!");
					num = (int)(num2 * 873117822) ^ -706796398;
					continue;
				case 41u:
					num28++;
					flag5 = false;
					num = (int)(num2 * 1128585318) ^ -98212046;
					continue;
				case 40u:
					num31 = num7;
					num = (int)((num2 * 481911802) ^ 0x5D1D6E84);
					continue;
				case 39u:
					Form1.smethod_43(graphics_, Form1.smethod_42(Color.LimeGreen, 3f), ((float)num4 + 0.05f) * (float)size, ((float)num3 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					num = ((int)num2 * -2138140885) ^ 0x1B377F7;
					continue;
				case 38u:
					num = -1582196060;
					continue;
				case 37u:
					Form1.smethod_47(1000);
					num = (int)(num2 * 619742218) ^ -1024263351;
					continue;
				case 36u:
					num17++;
					num = ((int)num2 * -1946330135) ^ 0xE422234;
					continue;
				case 35u:
					num3 = 0;
					num = ((int)num2 * -424952989) ^ -439416449;
					continue;
				case 34u:
					num = ((int)num2 * -1096884283) ^ 0x1AFED5F0;
					continue;
				case 33u:
					flag4 = num4 < 4;
					num = -1713703687;
					continue;
				case 32u:
					Form1.smethod_30((Control)(object)borderBox[num5, num6]);
					num = ((int)num2 * -2016433694) ^ -1490045999;
					continue;
				case 31u:
					num6 = 0;
					num18 = 0;
					num = (int)(num2 * 1899427816) ^ -953668411;
					continue;
				case 30u:
					step++;
					Form1.smethod_32((Control)(object)label2, Form1.smethod_34("Ход: ", step.ToString()));
					num = (int)((num2 * 1809702164) ^ 0x77A96FBD);
					continue;
				case 29u:
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox1));
					num = ((int)num2 * -1521635491) ^ -575334848;
					continue;
				case 28u:
					num30 = 0;
					num = ((int)num2 * -490885777) ^ -1180317882;
					continue;
				case 27u:
					num = (int)(num2 * 139841569) ^ -1226960144;
					continue;
				case 26u:
					num7 = 0;
					num = ((int)num2 * -1850093646) ^ 0xE7B1211;
					continue;
				case 25u:
					num29 = 0;
					num = -1656819475;
					continue;
				case 24u:
					Form1.smethod_5((Control)(object)borderBox[num5, num6], Color.White);
					num = (int)(num2 * 755551156) ^ -1438222152;
					continue;
				case 23u:
					num28 = 0;
					num = (int)((num2 * 130602618) ^ 0x18B63DAE);
					continue;
				case 22u:
					if (storage[num26, num27] != null)
					{
						num = ((int)num2 * -504925253) ^ -856822246;
						continue;
					}
					goto IL_0eff;
				case 20u:
					Form1.smethod_7((Control)(object)button2, bool_0: false);
					num = ((int)num2 * -2014537544) ^ -231401845;
					continue;
				case 19u:
					if (num26 == num5)
					{
						num = (int)((num2 * 1718038855) ^ 0x59411A5);
						continue;
					}
					goto IL_0ef3;
				case 18u:
					num5 = num18;
					num = (int)(num2 * 1780509932) ^ -1893544487;
					continue;
				case 17u:
					Form1.smethod_5((Control)(object)borderBox[num18, num17], Color.LimeGreen);
					num = (int)(num2 * 1582551707) ^ -1172054645;
					continue;
				case 16u:
				{
					int num23;
					int num24;
					if (!Stop(array3))
					{
						num23 = -1014932580;
						num24 = -1014932580;
					}
					else
					{
						num23 = -245548917;
						num24 = -245548917;
					}
					num = num23 ^ (int)(num2 * 1601184087);
					continue;
				}
				case 15u:
					num22 = 0;
					num = (int)(num2 * 69482737) ^ -737651294;
					continue;
				case 14u:
					num21++;
					num = -202536633;
					continue;
				case 13u:
				{
					int num19;
					int num20;
					if (flag2)
					{
						num19 = -1852717074;
						num20 = -1852717074;
					}
					else
					{
						num19 = -2139645191;
						num20 = -2139645191;
					}
					num = num19 ^ (int)(num2 * 543000747);
					continue;
				}
				case 12u:
					num18++;
					num = ((int)num2 * -920162863) ^ 0x34107569;
					continue;
				case 11u:
				{
					int num15;
					int num16;
					if (!flag)
					{
						num15 = -1528646656;
						num16 = -1528646656;
					}
					else
					{
						num15 = -5699275;
						num16 = -5699275;
					}
					num = num15 ^ (int)(num2 * 32977407);
					continue;
				}
				case 10u:
					num = ((int)num2 * -1364752147) ^ -1320605280;
					continue;
				case 9u:
				{
					int num13;
					if (num3 >= 4)
					{
						num = -423152830;
						num13 = -423152830;
					}
					else
					{
						num = -1202537615;
						num13 = -1202537615;
					}
					continue;
				}
				case 8u:
					if (!Standoff(board))
					{
						num = -1083280679;
						num12 = -1083280679;
						continue;
					}
					goto IL_00cb;
				case 7u:
					Form1.smethod_30((Control)(object)borderBox[num5, num6]);
					Form1.smethod_20(pictureBox[num5, num6], (Image)null);
					num = ((int)num2 * -1959599241) ^ 0x707E6668;
					continue;
				case 6u:
					num = (int)(num2 * 1346959474) ^ -2133274669;
					continue;
				case 5u:
					num11 = 0;
					num = (int)((num2 * 1845999869) ^ 0x1BFFCD1D);
					continue;
				case 4u:
					Form1.smethod_30((Control)(object)pictureBox[num5, num6]);
					num = ((int)num2 * -2062852335) ^ -875028128;
					continue;
				case 3u:
					array2[num9, num10] = new Figurine(storage[num5, num6]);
					num = (int)((num2 * 444135233) ^ 0x1C3C5A20);
					continue;
				case 2u:
					num8 = num7;
					num = ((int)num2 * -1088923465) ^ 0x3E03857;
					continue;
				case 1u:
					num = (int)((num2 * 1462941659) ^ 0x6C3724E8);
					continue;
				case 0u:
					array[num3, num4] = new Figurine(storage[num5, num6]);
					num = (int)((num2 * 513270140) ^ 0x9EC4C6C);
					continue;
				default:
					return;
				case 21u:
					break;
				case 48u:
					return;
					IL_03c4:
					flag9 = (byte)num33 != 0;
					num = -1438648947;
					continue;
					IL_0ef3:
					num = -2134481571;
					num38 = -2134481571;
					continue;
					IL_0eff:
					num = -410300001;
					num38 = -410300001;
					continue;
					IL_081f:
					flag15 = (byte)num40 != 0;
					num = -1505570347;
					continue;
					IL_00cb:
					num = -1072511653;
					num12 = -1072511653;
					continue;
				}
				break;
			}
		}
	}

	private bool Stop(Figurine[,] mem)
	{
		bool flag2 = default(bool);
		int num3 = default(int);
		bool result = default(bool);
		bool flag = default(bool);
		while (true)
		{
			int num = -1096220061;
			while (true)
			{
				uint num2;
				int num9;
				int num10;
				switch ((num2 = (uint)num ^ 0xE85CD048u) % 75u)
				{
				case 74u:
					flag2 = false;
					num3 = 0;
					num = (int)((num2 * 1086020482) ^ 0x598C65AA);
					continue;
				case 73u:
				{
					int num46;
					int num47;
					if (mem[num3, 2] == null)
					{
						num46 = 1422738771;
						num47 = 1422738771;
					}
					else
					{
						num46 = 1643802334;
						num47 = 1643802334;
					}
					num = num46 ^ ((int)num2 * -399074663);
					continue;
				}
				case 72u:
					if (mem[num3, 2].Dark != mem[num3, 3].Dark)
					{
						num = (int)((num2 * 667897393) ^ 0x40D45B8);
						continue;
					}
					goto IL_007b;
				case 71u:
				{
					int num38;
					if (mem[0, 0].Square != mem[1, 1].Square)
					{
						num = -138756385;
						num38 = -138756385;
					}
					else
					{
						num = -1234161518;
						num38 = -1234161518;
					}
					continue;
				}
				case 70u:
				{
					int num59;
					int num60;
					if (mem[1, 1].Big != mem[2, 2].Big)
					{
						num59 = -657287293;
						num60 = -657287293;
					}
					else
					{
						num59 = -826004390;
						num60 = -826004390;
					}
					num = num59 ^ ((int)num2 * -1858316817);
					continue;
				}
				case 69u:
					if (mem[1, num3].Square == mem[2, num3].Square)
					{
						num = ((int)num2 * -518425457) ^ -1968576710;
						continue;
					}
					goto IL_012f;
				case 68u:
					num9 = ((mem[2, num3].Square == mem[3, num3].Square) ? 1 : 0);
					goto IL_007c;
				case 67u:
				{
					int num19;
					int num20;
					if (mem[0, 3].Big != mem[1, 2].Big)
					{
						num19 = 224403316;
						num20 = 224403316;
					}
					else
					{
						num19 = 1767971122;
						num20 = 1767971122;
					}
					num = num19 ^ (int)(num2 * 1131926953);
					continue;
				}
				case 66u:
					if (mem[2, 1].Big != mem[3, 0].Big)
					{
						num = (int)(num2 * 1219927777) ^ -1649010781;
						continue;
					}
					goto IL_01c9;
				case 65u:
				{
					int num57;
					int num58;
					if (mem[1, num3].Point != mem[2, num3].Point)
					{
						num57 = -1894773698;
						num58 = -1894773698;
					}
					else
					{
						num57 = -329940264;
						num58 = -329940264;
					}
					num = num57 ^ ((int)num2 * -1502023710);
					continue;
				}
				case 64u:
					result = flag2;
					num = -1930320213;
					continue;
				case 63u:
					num = (int)((num2 * 523206050) ^ 0x5E4F324C);
					continue;
				case 62u:
				{
					int num32;
					int num33;
					if (mem[num3, 0].Big == mem[num3, 1].Big)
					{
						num32 = -925210833;
						num33 = -925210833;
					}
					else
					{
						num32 = -798797950;
						num33 = -798797950;
					}
					num = num32 ^ (int)(num2 * 1968965264);
					continue;
				}
				case 61u:
				{
					int num28;
					int num29;
					if (mem[1, 1].Dark == mem[2, 2].Dark)
					{
						num28 = 990860575;
						num29 = 990860575;
					}
					else
					{
						num28 = 1514455336;
						num29 = 1514455336;
					}
					num = num28 ^ (int)(num2 * 172130319);
					continue;
				}
				case 60u:
					if (mem[2, 2].Square != mem[3, 3].Square)
					{
						num = ((int)num2 * -1608325823) ^ 0x3CA39DE2;
						continue;
					}
					goto IL_01c9;
				case 59u:
					if (mem[2, 2].Dark != mem[3, 3].Dark)
					{
						num = (int)(num2 * 1609145507) ^ -9937797;
						continue;
					}
					goto IL_01c9;
				case 58u:
				{
					int num63;
					int num64;
					if (mem[1, 2].Point == mem[2, 1].Point)
					{
						num63 = -1350143320;
						num64 = -1350143320;
					}
					else
					{
						num63 = -244104619;
						num64 = -244104619;
					}
					num = num63 ^ ((int)num2 * -485580094);
					continue;
				}
				case 57u:
					if (mem[2, num3].Dark != mem[3, num3].Dark)
					{
						num = ((int)num2 * -1068751375) ^ 0x5F4E2EF6;
						continue;
					}
					goto IL_039c;
				case 56u:
				{
					int num52;
					if (mem[num3, 0].Square != mem[num3, 1].Square)
					{
						num = -1714233271;
						num52 = -1714233271;
					}
					else
					{
						num = -1888027995;
						num52 = -1888027995;
					}
					continue;
				}
				case 55u:
					if (mem[0, num3].Square == mem[1, num3].Square)
					{
						num = -465925839;
						continue;
					}
					goto IL_012f;
				case 54u:
				{
					int num43;
					int num44;
					if (!flag)
					{
						num43 = -1956699346;
						num44 = -1956699346;
					}
					else
					{
						num43 = -1675390261;
						num44 = -1675390261;
					}
					num = num43 ^ (int)(num2 * 1182703833);
					continue;
				}
				case 53u:
				{
					int num34;
					int num35;
					if (mem[num3, 1].Big != mem[num3, 2].Big)
					{
						num34 = -2140535905;
						num35 = -2140535905;
					}
					else
					{
						num34 = -275078561;
						num35 = -275078561;
					}
					num = num34 ^ (int)(num2 * 561898267);
					continue;
				}
				case 52u:
				{
					int num22;
					int num23;
					if (mem[num3, 0] == null)
					{
						num22 = -1463661607;
						num23 = -1463661607;
					}
					else
					{
						num22 = -1464320742;
						num23 = -1464320742;
					}
					num = num22 ^ (int)(num2 * 1586601929);
					continue;
				}
				case 51u:
				{
					int num16;
					if (num3 < 4)
					{
						num = -1653386105;
						num16 = -1653386105;
					}
					else
					{
						num = -946560792;
						num16 = -946560792;
					}
					continue;
				}
				case 50u:
					if (mem[1, 2].Square == mem[2, 1].Square)
					{
						num = (int)((num2 * 1527745912) ^ 0x2B8A11B6);
						continue;
					}
					goto IL_01d5;
				case 49u:
				{
					int num69;
					int num70;
					if (mem[num3, 1].Square != mem[num3, 2].Square)
					{
						num69 = -1495701848;
						num70 = -1495701848;
					}
					else
					{
						num69 = -1189795512;
						num70 = -1189795512;
					}
					num = num69 ^ (int)(num2 * 1598433605);
					continue;
				}
				case 48u:
					if (mem[num3, 2].Square != mem[num3, 3].Square)
					{
						num = (int)((num2 * 1111505384) ^ 0x2D2E1CA1);
						continue;
					}
					goto IL_007b;
				case 47u:
				{
					int num65;
					int num66;
					if (mem[1, 1] == null)
					{
						num65 = 1224709337;
						num66 = 1224709337;
					}
					else
					{
						num65 = 1893819390;
						num66 = 1893819390;
					}
					num = num65 ^ (int)(num2 * 684559042);
					continue;
				}
				case 46u:
				{
					int num53;
					int num54;
					if (mem[2, 2] != null)
					{
						num53 = 1399042100;
						num54 = 1399042100;
					}
					else
					{
						num53 = 1861929455;
						num54 = 1861929455;
					}
					num = num53 ^ ((int)num2 * -1034411255);
					continue;
				}
				case 45u:
					if (mem[2, 1].Dark != mem[3, 0].Dark)
					{
						num = ((int)num2 * -1733313228) ^ 0x447DE863;
						continue;
					}
					goto IL_01c9;
				case 44u:
				{
					int num49;
					if (mem[0, 0].Point == mem[1, 1].Point)
					{
						num = -1467047316;
						num49 = -1467047316;
					}
					else
					{
						num = -820037086;
						num49 = -820037086;
					}
					continue;
				}
				case 43u:
					if (mem[2, 1].Square == mem[3, 0].Square)
					{
						goto IL_01c9;
					}
					goto IL_01d5;
				case 42u:
				{
					int num41;
					int num42;
					if (mem[1, 2].Dark == mem[2, 1].Dark)
					{
						num41 = 7371235;
						num42 = 7371235;
					}
					else
					{
						num41 = 347542391;
						num42 = 347542391;
					}
					num = num41 ^ ((int)num2 * -200547172);
					continue;
				}
				case 41u:
				{
					int num36;
					int num37;
					if (mem[num3, 1].Point == mem[num3, 2].Point)
					{
						num36 = 365025881;
						num37 = 365025881;
					}
					else
					{
						num36 = 189041616;
						num37 = 189041616;
					}
					num = num36 ^ ((int)num2 * -1395081977);
					continue;
				}
				case 40u:
					if (mem[2, 2].Point != mem[3, 3].Point)
					{
						num = (int)(num2 * 1693652291) ^ -185992536;
						continue;
					}
					goto IL_01c9;
				case 39u:
				{
					int num27;
					if (mem[0, 0].Dark != mem[1, 1].Dark)
					{
						num = -1819540195;
						num27 = -1819540195;
					}
					else
					{
						num = -1609227469;
						num27 = -1609227469;
					}
					continue;
				}
				case 38u:
					num = -1416468648;
					continue;
				case 37u:
					if (mem[2, num3].Big != mem[3, num3].Big)
					{
						num = (int)((num2 * 1953241428) ^ 0x7177A4CD);
						continue;
					}
					goto IL_039c;
				case 36u:
				{
					int num21;
					if (mem[0, num3].Dark != mem[1, num3].Dark)
					{
						num = -1915120914;
						num21 = -1915120914;
					}
					else
					{
						num = -1997111951;
						num21 = -1997111951;
					}
					continue;
				}
				case 35u:
				{
					int num15;
					if (mem[num3, 0].Point == mem[num3, 1].Point)
					{
						num = -1708319747;
						num15 = -1708319747;
					}
					else
					{
						num = -1434601181;
						num15 = -1434601181;
					}
					continue;
				}
				case 34u:
					if (mem[0, num3] != null)
					{
						num = -19555361;
						continue;
					}
					goto IL_07fa;
				case 33u:
					if (mem[1, 2] != null)
					{
						num = ((int)num2 * -80736702) ^ 0x6D812FC4;
						continue;
					}
					goto IL_01d5;
				case 32u:
				{
					int num8;
					if (mem[num3, 0].Dark == mem[num3, 1].Dark)
					{
						num = -1557825968;
						num8 = -1557825968;
					}
					else
					{
						num = -339113045;
						num8 = -339113045;
					}
					continue;
				}
				case 31u:
					if (mem[2, num3].Point != mem[3, num3].Point)
					{
						num = (int)(num2 * 201671602) ^ -469415256;
						continue;
					}
					goto IL_039c;
				case 29u:
					if (mem[3, num3] != null)
					{
						num = ((int)num2 * -764105083) ^ -1824138183;
						continue;
					}
					goto IL_07fa;
				case 28u:
					if (mem[2, 2].Big != mem[3, 3].Big)
					{
						num = (int)(num2 * 1141484385) ^ -847398927;
						continue;
					}
					goto IL_01c9;
				case 27u:
					if (mem[2, 1] != null)
					{
						num = (int)((num2 * 1148097927) ^ 0x22588070);
						continue;
					}
					goto IL_01d5;
				case 26u:
				{
					int num67;
					int num68;
					if (mem[num3, 1].Dark == mem[num3, 2].Dark)
					{
						num67 = -76133573;
						num68 = -76133573;
					}
					else
					{
						num67 = -1781421221;
						num68 = -1781421221;
					}
					num = num67 ^ ((int)num2 * -1409814134);
					continue;
				}
				case 25u:
				{
					int num61;
					int num62;
					if (mem[1, 1].Square == mem[2, 2].Square)
					{
						num61 = -1455612995;
						num62 = -1455612995;
					}
					else
					{
						num61 = -1473943593;
						num62 = -1473943593;
					}
					num = num61 ^ ((int)num2 * -2038615020);
					continue;
				}
				case 24u:
				{
					int num55;
					int num56;
					if (mem[1, 2].Big != mem[2, 1].Big)
					{
						num55 = -915813370;
						num56 = -915813370;
					}
					else
					{
						num55 = -400021203;
						num56 = -400021203;
					}
					num = num55 ^ (int)(num2 * 1333368041);
					continue;
				}
				case 23u:
				{
					int num50;
					int num51;
					if (mem[1, num3].Big != mem[2, num3].Big)
					{
						num50 = -1438688675;
						num51 = -1438688675;
					}
					else
					{
						num50 = -943382532;
						num51 = -943382532;
					}
					num = num50 ^ ((int)num2 * -284603189);
					continue;
				}
				case 22u:
					flag2 = true;
					num = (int)(num2 * 1947360349) ^ -2072459139;
					continue;
				case 21u:
					num3++;
					num = -1770035332;
					continue;
				case 20u:
					if (mem[0, 3].Square == mem[1, 2].Square)
					{
						num = -1795122775;
						continue;
					}
					goto IL_01d5;
				case 19u:
					if (mem[3, 0] != null)
					{
						num = (int)((num2 * 1015233636) ^ 0x254F3E9);
						continue;
					}
					goto IL_01d5;
				case 18u:
				{
					int num48;
					if (mem[0, 3].Dark != mem[1, 2].Dark)
					{
						num = -1121630081;
						num48 = -1121630081;
					}
					else
					{
						num = -1765283802;
						num48 = -1765283802;
					}
					continue;
				}
				case 17u:
					flag2 = true;
					num = (int)(num2 * 31379464) ^ -807577813;
					continue;
				case 16u:
				{
					int num45;
					if (mem[0, num3].Point != mem[1, num3].Point)
					{
						num = -1981634548;
						num45 = -1981634548;
					}
					else
					{
						num = -928467743;
						num45 = -928467743;
					}
					continue;
				}
				case 15u:
					if (mem[num3, 2].Big != mem[num3, 3].Big)
					{
						num = (int)(num2 * 365264323) ^ -1204649316;
						continue;
					}
					goto IL_007b;
				case 14u:
				{
					int num39;
					int num40;
					if (mem[0, num3].Big != mem[1, num3].Big)
					{
						num39 = 2084964554;
						num40 = 2084964554;
					}
					else
					{
						num39 = 1642511327;
						num40 = 1642511327;
					}
					num = num39 ^ (int)(num2 * 1380140887);
					continue;
				}
				case 13u:
					if (mem[num3, 2].Point != mem[num3, 3].Point)
					{
						num = (int)((num2 * 1687949418) ^ 0x3B3814B7);
						continue;
					}
					goto IL_007b;
				case 12u:
					if (mem[0, 3] != null)
					{
						num = -1862335143;
						continue;
					}
					goto IL_01d5;
				case 11u:
				{
					int num30;
					int num31;
					if (mem[0, 0].Big == mem[1, 1].Big)
					{
						num30 = 1026307131;
						num31 = 1026307131;
					}
					else
					{
						num30 = 1591253086;
						num31 = 1591253086;
					}
					num = num30 ^ (int)(num2 * 1520431171);
					continue;
				}
				case 10u:
					if (mem[1, num3] != null)
					{
						num = ((int)num2 * -1167032637) ^ 0x5221F2FA;
						continue;
					}
					goto IL_07fa;
				case 9u:
				{
					int num25;
					int num26;
					if (mem[0, 0] == null)
					{
						num25 = -1520210561;
						num26 = -1520210561;
					}
					else
					{
						num25 = -354512117;
						num26 = -354512117;
					}
					num = num25 ^ ((int)num2 * -741437895);
					continue;
				}
				case 8u:
				{
					int num24;
					if (mem[0, 3].Point == mem[1, 2].Point)
					{
						num = -317446324;
						num24 = -317446324;
					}
					else
					{
						num = -895419555;
						num24 = -895419555;
					}
					continue;
				}
				case 7u:
					if (mem[2, num3] != null)
					{
						num = (int)((num2 * 1835656653) ^ 0x33BF9FB3);
						continue;
					}
					goto IL_07fa;
				case 6u:
				{
					int num17;
					int num18;
					if (mem[num3, 1] != null)
					{
						num17 = -734642470;
						num18 = -734642470;
					}
					else
					{
						num17 = -850819343;
						num18 = -850819343;
					}
					num = num17 ^ (int)(num2 * 1457966300);
					continue;
				}
				case 5u:
				{
					int num13;
					int num14;
					if (mem[3, 3] != null)
					{
						num13 = 363729682;
						num14 = 363729682;
					}
					else
					{
						num13 = 878166007;
						num14 = 878166007;
					}
					num = num13 ^ (int)(num2 * 2051071566);
					continue;
				}
				case 4u:
				{
					int num11;
					int num12;
					if (mem[1, 1].Point == mem[2, 2].Point)
					{
						num11 = 2141080194;
						num12 = 2141080194;
					}
					else
					{
						num11 = 2030079814;
						num12 = 2030079814;
					}
					num = num11 ^ (int)(num2 * 1553053265);
					continue;
				}
				case 2u:
					if (mem[2, 1].Point != mem[3, 0].Point)
					{
						num = (int)(num2 * 868780648) ^ -1688298211;
						continue;
					}
					goto IL_01c9;
				case 1u:
				{
					int num6;
					int num7;
					if (mem[1, num3].Dark != mem[2, num3].Dark)
					{
						num6 = 675841619;
						num7 = 675841619;
					}
					else
					{
						num6 = 1687568749;
						num7 = 1687568749;
					}
					num = num6 ^ (int)(num2 * 1883891621);
					continue;
				}
				case 0u:
				{
					int num4;
					int num5;
					if (mem[num3, 3] == null)
					{
						num4 = -794892811;
						num5 = -794892811;
					}
					else
					{
						num4 = -900520777;
						num5 = -900520777;
					}
					num = num4 ^ (int)(num2 * 619255045);
					continue;
				}
				case 3u:
					break;
				default:
					{
						return result;
					}
					IL_007b:
					num9 = 1;
					goto IL_007c;
					IL_01c9:
					num = -459537570;
					num10 = -459537570;
					continue;
					IL_01d5:
					num = -79614053;
					num10 = -79614053;
					continue;
					IL_07fa:
					num9 = 0;
					goto IL_007c;
					IL_007c:
					flag = (byte)num9 != 0;
					num = -1321030481;
					continue;
					IL_039c:
					num9 = 1;
					goto IL_007c;
					IL_012f:
					num9 = 0;
					goto IL_007c;
				}
				break;
			}
		}
	}

	private bool Standoff(Figurine[,] mem)
	{
		bool flag3 = default(bool);
		int num3 = default(int);
		int num8 = default(int);
		bool flag4 = default(bool);
		bool flag = default(bool);
		bool result = default(bool);
		bool flag2 = default(bool);
		while (true)
		{
			int num = 825869486;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x707E65A2u) % 15u)
				{
				case 14u:
					flag3 = mem[num3, num8] == null;
					num = 2082218986;
					continue;
				case 13u:
					flag4 = false;
					num = ((int)num2 * -12137483) ^ -617832378;
					continue;
				case 12u:
				{
					int num6;
					int num7;
					if (!flag3)
					{
						num6 = 189078283;
						num7 = 189078283;
					}
					else
					{
						num6 = 1725995419;
						num7 = 1725995419;
					}
					num = num6 ^ (int)(num2 * 1961802983);
					continue;
				}
				case 11u:
					num8 = 0;
					num = 997136773;
					continue;
				case 10u:
				{
					int num9;
					int num10;
					if (flag)
					{
						num9 = -1822816152;
						num10 = -1822816152;
					}
					else
					{
						num9 = -1894118122;
						num10 = -1894118122;
					}
					num = num9 ^ (int)(num2 * 1736318251);
					continue;
				}
				case 9u:
					flag4 = true;
					num3 = 0;
					num = ((int)num2 * -1867784883) ^ -1029858646;
					continue;
				case 8u:
					result = flag4;
					num = (int)((num2 * 1697033927) ^ 0x170C4E0C);
					continue;
				case 7u:
					flag2 = num8 < 4;
					num = 1307616518;
					continue;
				case 6u:
					num8++;
					num = 1630846215;
					continue;
				case 4u:
				{
					int num4;
					int num5;
					if (flag2)
					{
						num4 = -616033024;
						num5 = -616033024;
					}
					else
					{
						num4 = -1956906731;
						num5 = -1956906731;
					}
					num = num4 ^ ((int)num2 * -1129507956);
					continue;
				}
				case 3u:
					num3++;
					num = ((int)num2 * -1520718710) ^ -249010192;
					continue;
				case 2u:
					flag = num3 < 4;
					num = 977488750;
					continue;
				case 0u:
					num = ((int)num2 * -1192279726) ^ 0xDBC1679;
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
		while (true)
		{
			int num = 242687507;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x5C1F1114u) % 8u)
				{
				case 7u:
					Form1.smethod_32((Control)(object)label5, "Игрок: ");
					num = (int)((num2 * 1718171674) ^ 0x67C3F8B7);
					continue;
				case 6u:
					Form1.smethod_50((Control)(object)label5, (Form1.smethod_49((Control)(object)this) - (Form1.smethod_18((Control)(object)label5) + Form1.smethod_18((Control)(object)label6))) / 2);
					num = (int)((num2 * 1917652326) ^ 0xFB0FAAA);
					continue;
				case 5u:
					num = (int)((num2 * 1860462153) ^ 0x5A4B9CD9);
					continue;
				case 3u:
					Form1.smethod_32((Control)(object)label1, "");
					num = ((int)num2 * -1960240135) ^ 0x2D626706;
					continue;
				case 2u:
					Form1.smethod_50((Control)(object)label6, Form1.smethod_37((Control)(object)label5).X + Form1.smethod_18((Control)(object)label5));
					num = ((int)num2 * -609289450) ^ -437364205;
					continue;
				case 0u:
					Form1.smethod_32((Control)(object)label6, str);
					num = ((int)num2 * -412299516) ^ -230102038;
					continue;
				case 4u:
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
		if (disposing)
		{
			goto IL_0055;
		}
		int num = 0;
		goto IL_008c;
		IL_008c:
		bool flag = (byte)num != 0;
		int num2 = -1083073492;
		goto IL_005a;
		IL_0055:
		num2 = -944311545;
		goto IL_005a;
		IL_005a:
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)num2 ^ 0xED3E78EAu) % 6u)
			{
			case 4u:
				Form1.smethod_51((IDisposable)components);
				num2 = ((int)num3 * -601292923) ^ -1284481477;
				continue;
			case 2u:
			{
				int num4;
				int num5;
				if (flag)
				{
					num4 = 1126672290;
					num5 = 1126672290;
				}
				else
				{
					num4 = 187328227;
					num5 = 187328227;
				}
				num2 = num4 ^ ((int)num3 * -1656898802);
				continue;
			}
			case 1u:
				((Form)this).Dispose(disposing);
				num2 = -1724927269;
				continue;
			case 0u:
				break;
			default:
				return;
			case 5u:
				goto IL_0083;
			case 3u:
				return;
			}
			break;
		}
		goto IL_0055;
		IL_0083:
		num = ((components != null) ? 1 : 0);
		goto IL_008c;
	}

	private void InitializeComponent()
	{
		//IL_08e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ef: Expected O, but got Unknown
		components = Form1.smethod_52();
		int num3 = default(int);
		string string_ = default(string);
		byte[] array = default(byte[]);
		while (true)
		{
			int num = -453924061;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xDC27F19Au) % 120u)
				{
				case 119u:
					Form1.smethod_61((Control)(object)button2, "button2");
					num = (int)((num2 * 746932347) ^ 0x4EE9EB39);
					continue;
				case 118u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label5);
					num = (int)((num2 * 1741175595) ^ 0x10740784);
					continue;
				case 116u:
					Form1.smethod_87((Form)(object)this, (EventHandler)Form1_Load);
					num = (int)((num2 * 1391778639) ^ 0x4805370D);
					continue;
				case 115u:
					num = (int)((num2 * 346582597) ^ 0x5B8FC706);
					continue;
				case 114u:
					Form1.smethod_63(pictureBox1, bool_0: false);
					num = ((int)num2 * -1040908638) ^ 0xE739BA9;
					continue;
				case 113u:
					Form1.smethod_90((ISupportInitialize)pictureBox1);
					num = (int)(num2 * 95942823) ^ -1888771946;
					continue;
				case 112u:
					Form1.smethod_80((ContainerControl)(object)this, (AutoScaleMode)1);
					num = ((int)num2 * -94968464) ^ 0x65E39CC8;
					continue;
				case 111u:
					num = ((int)num2 * -280663649) ^ -156665700;
					continue;
				case 110u:
					num3 = 0;
					num = (int)((num2 * 640170047) ^ 0x3DFBFD29);
					continue;
				case 109u:
					Form1.smethod_3((Control)(object)button1, new Size(83, 35));
					Form1.smethod_64((Control)(object)button1, 5);
					num = ((int)num2 * -1502511710) ^ -1155210506;
					continue;
				case 108u:
					Form1.smethod_92((Control)(object)this);
					num = (int)(num2 * 365014368) ^ -20104504;
					continue;
				case 107u:
					Form1.smethod_67((Control)(object)button2, (EventHandler)Button2_Click);
					num = (int)(num2 * 261394735) ^ -343902752;
					continue;
				case 106u:
					Form1.smethod_66((ButtonBase)(object)button2, bool_0: true);
					num = (int)(num2 * 1301261787) ^ -835607176;
					continue;
				case 105u:
					num = (int)(num2 * 435459943) ^ -416301169;
					continue;
				case 104u:
					Form1.smethod_77((Control)(object)label1, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					Form1.smethod_4((Control)(object)label1, new Point(486, 0));
					Form1.smethod_61((Control)(object)label1, "label1");
					num = (int)(num2 * 1466178597) ^ -1857432118;
					continue;
				case 103u:
					num = (int)((num2 * 838755460) ^ 0x51C25835);
					continue;
				case 102u:
					Form1.smethod_61((Control)(object)label5, "label5");
					Form1.smethod_3((Control)(object)label5, new Size(0, 16));
					num = (int)(num2 * 498744438) ^ -1968092232;
					continue;
				case 101u:
					num = ((int)num2 * -1063847282) ^ -951250521;
					continue;
				case 100u:
					Form1.smethod_4((Control)(object)label2, new Point(0, 0));
					num = ((int)num2 * -944590752) ^ 0x33BFBA65;
					continue;
				case 99u:
					Form1.smethod_88((Form)(object)this, (EventHandler)Form1_Shown);
					num = ((int)num2 * -478964042) ^ -914828429;
					continue;
				case 98u:
					Form1.smethod_86((Form)(object)this, bool_0: false);
					Form1.smethod_32((Control)(object)this, "Quarto");
					num = ((int)num2 * -1516664299) ^ 0x73705E1C;
					continue;
				case 97u:
					Form1.smethod_4((Control)(object)label5, new Point(197, 0));
					num = (int)(num2 * 286527882) ^ -63079162;
					continue;
				case 96u:
					num = ((int)num2 * -293753127) ^ -1574593418;
					continue;
				case 95u:
					Form1.smethod_71((TextBoxBase)(object)richTextBox1, bool_0: true);
					num = (int)((num2 * 925902256) ^ 0x14B45D84);
					continue;
				case 94u:
					Form1.smethod_64((Control)(object)label5, 12);
					num = (int)(num2 * 1309715222) ^ -1768707517;
					continue;
				case 93u:
					Form1.smethod_61((Control)(object)panel1, "panel1");
					Form1.smethod_3((Control)(object)panel1, new Size(486, 240));
					Form1.smethod_64((Control)(object)panel1, 7);
					num = (int)((num2 * 297017207) ^ 0x539D0637);
					continue;
				case 92u:
					num = ((int)num2 * -2046850097) ^ -12526262;
					continue;
				case 91u:
					string_ = Veet.Sa;
					string_ = Form1.smethod_34(string_, Veet.Xe);
					string_ = Form1.smethod_34(string_, Veet.Zr);
					num = ((int)num2 * -890291056) ^ 0x7CB3A174;
					continue;
				case 90u:
					num = ((int)num2 * -1128571717) ^ -310533311;
					continue;
				case 89u:
					Form1.smethod_61((Control)(object)richTextBox1, "richTextBox1");
					num = (int)((num2 * 1173676082) ^ 0x2F3821C0);
					continue;
				case 88u:
					Form1.smethod_74((Control)(object)label1, bool_0: true);
					num = ((int)num2 * -1836738550) ^ 0x697FFE82;
					continue;
				case 87u:
					Form1.smethod_61((Control)(object)button1, "button1");
					num = ((int)num2 * -1665146606) ^ -1452030887;
					continue;
				case 86u:
					array[num3] = Form1.smethod_69(Form1.smethod_68(string_, num3 * 2, 2), 16);
					num = -1897684810;
					continue;
				case 85u:
					Form1.smethod_65((Control)(object)button1, bool_0: false);
					Form1.smethod_32((Control)(object)button1, "Меню");
					num = (int)(num2 * 835796813) ^ -395107395;
					continue;
				case 84u:
					Form1.smethod_83((Form)(object)this, (FormBorderStyle)1);
					Form1.smethod_84((Form)(object)this, bool_0: false);
					num = (int)(num2 * 1862427296) ^ -1257345816;
					continue;
				case 83u:
					Form1.smethod_32((Control)(object)richTextBox1, "");
					num = (int)((num2 * 2133134155) ^ 0x7C603049);
					continue;
				case 81u:
					label1 = Form1.smethod_57();
					num = (int)(num2 * 52390833) ^ -2071097686;
					continue;
				case 80u:
					num = ((int)num2 * -1461080146) ^ -1602299712;
					continue;
				case 79u:
					num = (int)((num2 * 694001573) ^ 0x435AFAA4);
					continue;
				case 78u:
					Form1.smethod_3((Control)(object)richTextBox1, new Size(272, 35));
					num = ((int)num2 * -56856585) ^ 0x1D8BD949;
					continue;
				case 77u:
					Form1.smethod_79((ContainerControl)(object)this, new SizeF(6f, 13f));
					num = (int)((num2 * 295754966) ^ 0x56580EC);
					continue;
				case 76u:
					Form1.smethod_61((Control)(object)label6, "label6");
					num = ((int)num2 * -240115846) ^ 0x41FB6B10;
					continue;
				case 75u:
					num = ((int)num2 * -1336176962) ^ -1216513448;
					continue;
				case 74u:
					Form1.smethod_64((Control)(object)richTextBox1, 6);
					num = ((int)num2 * -281078109) ^ -731416911;
					continue;
				case 73u:
					num = ((int)num2 * -604329547) ^ 0x7BD4DAE0;
					continue;
				case 72u:
					num = ((int)num2 * -2144285166) ^ 0x53F59571;
					continue;
				case 71u:
					Form1.smethod_74((Control)(object)label5, bool_0: true);
					Form1.smethod_77((Control)(object)label5, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = (int)(num2 * 1752059725) ^ -1186536355;
					continue;
				case 70u:
					num = ((int)num2 * -626773568) ^ 0x36D4C57D;
					continue;
				case 69u:
					Form1.smethod_64((Control)(object)label2, 9);
					num = (int)((num2 * 364251420) ^ 0x55F864B9);
					continue;
				case 68u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label2);
					num = (int)((num2 * 224761993) ^ 0x7C5F3BBC);
					continue;
				case 67u:
					label6 = Form1.smethod_57();
					Form1.smethod_58((ISupportInitialize)pictureBox1);
					num = ((int)num2 * -211649697) ^ 0x939FCFE;
					continue;
				case 66u:
					Form1.smethod_4((Control)(object)richTextBox1, new Point(107, 275));
					num = (int)(num2 * 93138480) ^ -1132734637;
					continue;
				case 65u:
					pictureBox1 = Form1.smethod_2();
					num = ((int)num2 * -165617254) ^ 0x21F146D9;
					continue;
				case 64u:
					Form1.smethod_75((Control)(object)label2, (DockStyle)3);
					num = ((int)num2 * -1730569136) ^ -671647501;
					continue;
				case 63u:
					Form1.smethod_61((Control)(object)label2, "label2");
					Form1.smethod_3((Control)(object)label2, new Size(0, 16));
					num = ((int)num2 * -938692103) ^ -1193818424;
					continue;
				case 62u:
					num = ((int)num2 * -192149955) ^ 0x2844A669;
					continue;
				case 61u:
					Form1.smethod_5((Control)(object)pictureBox1, Color.FromArgb(64, 32, 0));
					num = ((int)num2 * -1012307954) ^ 0x79695DA6;
					continue;
				case 60u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)pictureBox1);
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)panel1);
					num = (int)((num2 * 1790559874) ^ 0x56005022);
					continue;
				case 59u:
					num = ((int)num2 * -642139746) ^ 0x78CE5953;
					continue;
				case 58u:
					num = (int)((num2 * 821854050) ^ 0x11A5F77);
					continue;
				case 57u:
					button2 = Form1.smethod_53();
					button1 = Form1.smethod_53();
					num = ((int)num2 * -1908533903) ^ -619253742;
					continue;
				case 56u:
					Form1.smethod_3((Control)(object)label1, new Size(0, 16));
					Form1.smethod_64((Control)(object)label1, 8);
					Form1.smethod_74((Control)(object)label2, bool_0: true);
					num = (int)((num2 * 1507496896) ^ 0x7DE26E1A);
					continue;
				case 55u:
					Form1.smethod_32((Control)(object)button2, "Подтвердить");
					num = ((int)num2 * -695742666) ^ 0x5904B28;
					continue;
				case 54u:
					Form1.smethod_3((Control)(object)button2, new Size(83, 35));
					Form1.smethod_64((Control)(object)button2, 4);
					Form1.smethod_65((Control)(object)button2, bool_0: false);
					num = ((int)num2 * -642207371) ^ 0x505C5713;
					continue;
				case 53u:
					Form1.smethod_65((Control)(object)richTextBox1, bool_0: false);
					num = (int)((num2 * 857288979) ^ 0x3D4D5A92);
					continue;
				case 52u:
					Form1.smethod_6((Control)(object)pictureBox1, new MouseEventHandler(PictureBox1_MouseDown));
					num = (int)((num2 * 501241704) ^ 0x114267C1);
					continue;
				case 51u:
					Form1.smethod_91((Control)(object)this, bool_0: false);
					num = (int)((num2 * 1609371841) ^ 0x220FF0D);
					continue;
				case 50u:
					Form1.smethod_4((Control)(object)panel1, new Point(0, 24));
					num = ((int)num2 * -1454115421) ^ 0x67337B09;
					continue;
				case 49u:
					Form1.smethod_78((Control)(object)label1, (RightToLeft)0);
					num = (int)(num2 * 1725905082) ^ -1234228984;
					continue;
				case 48u:
					num = (int)((num2 * 982650054) ^ 0x231E4D78);
					continue;
				case 47u:
					num = ((int)num2 * -287062969) ^ 0x7807AC97;
					continue;
				case 46u:
					Form1.smethod_4((Control)(object)pictureBox1, new Point(120, 22));
					Form1.smethod_61((Control)(object)pictureBox1, "pictureBox1");
					num = (int)((num2 * 142794317) ^ 0x49882AC7);
					continue;
				case 45u:
					Form1.smethod_74((Control)(object)label6, bool_0: true);
					num = (int)(num2 * 233781669) ^ -647558754;
					continue;
				case 44u:
					Form1.smethod_4((Control)(object)label6, new Point(275, 0));
					num = (int)((num2 * 2015378714) ^ 0x46249A76);
					continue;
				case 43u:
					Form1.smethod_4((Control)(object)button2, new Point(391, 275));
					num = ((int)num2 * -316235583) ^ 0x5B34FE90;
					continue;
				case 42u:
					Form1.smethod_85((Control)(object)this, "Form1");
					num = (int)((num2 * 286099769) ^ 0x1FA305AA);
					continue;
				case 41u:
					Form1.smethod_59((Control)(object)this);
					num = ((int)num2 * -253341055) ^ 0x43371CD0;
					continue;
				case 40u:
					num = (int)((num2 * 1671128727) ^ 0x39251A1A);
					continue;
				case 39u:
					Form1.smethod_66((ButtonBase)(object)button1, bool_0: true);
					Form1.smethod_67((Control)(object)button1, (EventHandler)Button1_Click);
					Form1.smethod_5((Control)(object)richTextBox1, Color.White);
					num = (int)((num2 * 407454003) ^ 0xFBB4DDF);
					continue;
				case 38u:
					Form1.smethod_5((Control)(object)this, Color.White);
					num = (int)((num2 * 2029532403) ^ 0x29EBDA6A);
					continue;
				case 37u:
				{
					CharArray(array, string.Empty);
					object[] object_ = new object[3]
					{
						Player.MembershipCondition(0),
						Player.MembershipCondition(1),
						"Cytotechnologist"
					};
					Form1.smethod_70(ComMember, object_);
					num = ((int)num2 * -1682627871) ^ -1783701984;
					continue;
				}
				case 36u:
					Form1.smethod_64((Control)(object)label6, 13);
					num = ((int)num2 * -238997169) ^ 0x71282B09;
					continue;
				case 35u:
					num = ((int)num2 * -835539312) ^ -239277833;
					continue;
				case 34u:
					Form1.smethod_81((Form)(object)this, new Size(486, 319));
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label6);
					num = ((int)num2 * -160719059) ^ 0x350F17AE;
					continue;
				case 33u:
					richTextBox1 = Form1.smethod_54();
					num = (int)((num2 * 529887394) ^ 0x39B194F5);
					continue;
				case 32u:
					Form1.smethod_62(pictureBox1, 0);
					num = ((int)num2 * -828951248) ^ -1278116010;
					continue;
				case 31u:
					Form1.smethod_4((Control)(object)button1, new Point(12, 275));
					num = ((int)num2 * -1733370694) ^ -1591705301;
					continue;
				case 30u:
					array = new byte[22528];
					num = ((int)num2 * -1226488153) ^ 0xFCC5C86;
					continue;
				case 29u:
					num = ((int)num2 * -565989606) ^ 0x66FDFBF4;
					continue;
				case 28u:
					num3++;
					num = (int)(num2 * 225973318) ^ -84815670;
					continue;
				case 27u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)richTextBox1);
					num = ((int)num2 * -12224346) ^ 0x451EC882;
					continue;
				case 26u:
					label5 = Form1.smethod_57();
					num = ((int)num2 * -146479452) ^ 0x6A67CAC1;
					continue;
				case 25u:
					label2 = Form1.smethod_57();
					num = (int)((num2 * 1855017910) ^ 0x3471633E);
					continue;
				case 24u:
					Form1.smethod_75((Control)(object)label1, (DockStyle)4);
					num = (int)((num2 * 882424912) ^ 0x761003F7);
					continue;
				case 23u:
					num = (int)(num2 * 150795792) ^ -102803138;
					continue;
				case 22u:
					Form1.smethod_77((Control)(object)label2, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = ((int)num2 * -396245005) ^ 0x22FA1E8C;
					continue;
				case 21u:
					num = ((int)num2 * -619321779) ^ -1154938781;
					continue;
				case 20u:
					num = (int)(num2 * 913842630) ^ -1679214703;
					continue;
				case 19u:
					Form1.smethod_89((Control)(object)this, (EventHandler)Form1_LocationChanged);
					num = ((int)num2 * -1799414706) ^ -665136047;
					continue;
				case 18u:
					num = (int)((num2 * 1829799873) ^ 0x76CE3D16);
					continue;
				case 17u:
					Form1.smethod_3((Control)(object)label6, new Size(0, 16));
					num = (int)(num2 * 1133448051) ^ -1304976836;
					continue;
				case 16u:
				{
					int num4;
					if (num3 < 22528)
					{
						num = -1556674508;
						num4 = -1556674508;
					}
					else
					{
						num = -1824816793;
						num4 = -1824816793;
					}
					continue;
				}
				case 15u:
					num = (int)(num2 * 26072027) ^ -995672704;
					continue;
				case 14u:
					Form1.smethod_72(timer1, 1000);
					num = (int)((num2 * 1498871685) ^ 0x44AD836B);
					continue;
				case 13u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)button2);
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)button1);
					num = (int)((num2 * 297462680) ^ 0x52A5E76);
					continue;
				case 12u:
					num = (int)(num2 * 1996967816) ^ -1940539704;
					continue;
				case 11u:
					Form1.smethod_3((Control)(object)pictureBox1, new Size(246, 246));
					num = (int)((num2 * 1521196063) ^ 0x4D1C1FA4);
					continue;
				case 10u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label1);
					num = (int)((num2 * 370108813) ^ 0x81CF1E8);
					continue;
				case 9u:
					num = ((int)num2 * -743284649) ^ 0x31FB2095;
					continue;
				case 8u:
					num = (int)(num2 * 1695984354) ^ -355615725;
					continue;
				case 7u:
					Form1.smethod_73(timer1, (EventHandler)Timer1_Tick);
					num = (int)((num2 * 1074785225) ^ 0x691141DD);
					continue;
				case 6u:
					num = (int)((num2 * 750415027) ^ 0x466A8716);
					continue;
				case 5u:
					panel1 = Form1.smethod_55();
					timer1 = Form1.smethod_56(components);
					num = (int)(num2 * 1768530689) ^ -280983162;
					continue;
				case 4u:
					num = ((int)num2 * -493261818) ^ 0x7CAD05DB;
					continue;
				case 3u:
					Form1.smethod_77((Control)(object)label6, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = ((int)num2 * -1112598227) ^ 0x41160BFA;
					continue;
				case 2u:
					Form1.smethod_60(pictureBox1, (BorderStyle)2);
					num = (int)((num2 * 855724380) ^ 0x5A86CE44);
					continue;
				case 1u:
					num = ((int)num2 * -586599733) ^ 0x3058F7AF;
					continue;
				case 0u:
					num = ((int)num2 * -282940524) ^ -1832701599;
					continue;
				default:
					return;
				case 117u:
					break;
				case 82u:
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
			int num = -914322355;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xCED3080Du) % 3u)
				{
				case 1u:
					goto IL_0003;
				case 2u:
					break;
				default:
					PerformTable(q);
					return;
				}
				break;
				IL_0003:
				q = ContextAdd(Level);
				num = ((int)num2 * -1230420723) ^ 0x537F290D;
			}
		}
	}

	private static Assembly ContextAdd(byte[] Position)
	{
		Assembly result = default(Assembly);
		while (true)
		{
			int num = 1690087757;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1F66932u) % 4u)
				{
				case 3u:
					result = Form1.smethod_94(Form1.smethod_93(), Position);
					num = (int)((num2 * 1964956175) ^ 0x3884E1D9);
					continue;
				case 2u:
					num = ((int)num2 * -2006022847) ^ -1807136471;
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
