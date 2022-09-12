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
				int num = 259815522;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x666F5767u) % 6u)
					{
					case 5u:
						num = (int)((num2 * 1904799907) ^ 0x23FC0190);
						continue;
					case 4u:
						Big = big;
						num = (int)((num2 * 1608671126) ^ 0x7A50EFEA);
						continue;
					case 3u:
						Square = square;
						Point = point;
						num = ((int)num2 * -2009713512) ^ -943502740;
						continue;
					case 0u:
						Dark = dark;
						num = (int)(num2 * 108274961) ^ -1546806595;
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
				int num = -1574080233;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x9DA86124u) % 4u)
					{
					case 3u:
						num = (int)((num2 * 1968239912) ^ 0x2B21A12E);
						continue;
					case 2u:
						num = ((int)num2 * -245267775) ^ 0x4C80293B;
						continue;
					case 0u:
						break;
					default:
						Dark = copy.Dark;
						Big = copy.Big;
						Square = copy.Square;
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
			int num = 1901414612;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x61573A16u) % 8u)
				{
				case 7u:
					flag = Form1.smethod_16((Control)(object)menu) < 296;
					num = 967028870;
					continue;
				case 6u:
					Form1.smethod_14(menu);
					num = ((int)num2 * -864732394) ^ 0x30D53BB9;
					continue;
				case 5u:
				{
					Form control_ = menu;
					Form1.smethod_17((Control)(object)control_, Form1.smethod_16((Control)(object)control_) + 5);
					num = ((int)num2 * -435759670) ^ 0x51487ECB;
					continue;
				}
				case 2u:
					Form1.smethod_15(timer1);
					num = ((int)num2 * -976476708) ^ -2137720063;
					continue;
				case 1u:
					num = 1472364883;
					continue;
				case 0u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = -308546329;
						num4 = -308546329;
					}
					else
					{
						num3 = -1031277320;
						num4 = -1031277320;
					}
					num = num3 ^ ((int)num2 * -498381946);
					continue;
				}
				default:
					return;
				case 4u:
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
		bool flag2 = default(bool);
		int num3 = default(int);
		bool flag = default(bool);
		int num4 = default(int);
		while (true)
		{
			int num = -1418912385;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC9C8A285u) % 20u)
				{
				case 19u:
					storage = new Figurine[4, 4];
					num = (int)(num2 * 1185770113) ^ -70528780;
					continue;
				case 18u:
					num = ((int)num2 * -1141170909) ^ -1918929348;
					continue;
				case 17u:
					flag2 = num3 < 4;
					num = -1813988169;
					continue;
				case 16u:
					flag = num4 < 4;
					num = -1440391333;
					continue;
				case 15u:
					Form1.smethod_7((Control)(object)button2, bool_0: false);
					num = ((int)num2 * -1424087459) ^ -1050762521;
					continue;
				case 14u:
					board = new Figurine[4, 4];
					num = (int)((num2 * 807677842) ^ 0x308C0426);
					continue;
				case 12u:
					Paint_Board();
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: false);
					num = (int)((num2 * 924145544) ^ 0x10C01283);
					continue;
				case 11u:
					Paint_Storage();
					num = ((int)num2 * -1281360443) ^ -838194979;
					continue;
				case 10u:
				{
					int num7;
					int num8;
					if (flag2)
					{
						num7 = 1626574688;
						num8 = 1626574688;
					}
					else
					{
						num7 = 431412012;
						num8 = 431412012;
					}
					num = num7 ^ (int)(num2 * 931891988);
					continue;
				}
				case 9u:
					num4++;
					num = (int)((num2 * 271041633) ^ 0x734BF454);
					continue;
				case 8u:
					Form1.smethod_7((Control)(object)pictureBox[num4, num3], bool_0: false);
					num = (int)(num2 * 226591489) ^ -955871326;
					continue;
				case 6u:
				{
					int num5;
					int num6;
					if (flag)
					{
						num5 = 486346073;
						num6 = 486346073;
					}
					else
					{
						num5 = 1917035521;
						num6 = 1917035521;
					}
					num = num5 ^ (int)(num2 * 1882639948);
					continue;
				}
				case 5u:
					storage[num4, num3] = new Figurine(num4 < 2, num3 % 2 == 0, num3 < 2, num4 % 2 == 1);
					num = -91196468;
					continue;
				case 4u:
					num3 = 0;
					num = -1096821480;
					continue;
				case 3u:
					num = (int)(num2 * 2124218719) ^ -2064808652;
					continue;
				case 2u:
					num4 = 0;
					num = ((int)num2 * -1171240652) ^ -1392872755;
					continue;
				case 1u:
					Form1.smethod_5((Control)(object)borderBox[num4, num3], Color.White);
					num = ((int)num2 * -9612445) ^ -367768930;
					continue;
				case 0u:
					num3++;
					num = ((int)num2 * -842705285) ^ 0x395D9720;
					continue;
				default:
					return;
				case 7u:
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
		Form1.smethod_20(pictureBox1, (Image)(object)Form1.smethod_19(Form1.smethod_18((Control)(object)pictureBox1), Form1.smethod_16((Control)(object)pictureBox1)));
		int num5 = default(int);
		int num4 = default(int);
		Graphics graphics_ = default(Graphics);
		float num3 = default(float);
		float num6 = default(float);
		float num9 = default(float);
		Brush brush_ = default(Brush);
		bool big = default(bool);
		float num10 = default(float);
		float num11 = default(float);
		bool square = default(bool);
		bool flag = default(bool);
		while (true)
		{
			int num = 1074348194;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3F221D1Fu) % 38u)
				{
				case 37u:
					Form1.smethod_30((Control)(object)pictureBox1);
					num = (int)(num2 * 1987039360) ^ -164837901;
					continue;
				case 36u:
				{
					int num19;
					int num20;
					if (board[num5, num4].Dark)
					{
						num19 = 508718895;
						num20 = 508718895;
					}
					else
					{
						num19 = 1292870215;
						num20 = 1292870215;
					}
					num = num19 ^ ((int)num2 * -419847663);
					continue;
				}
				case 35u:
					Form1.smethod_24(graphics_, (Brush)(object)Form1.smethod_29(Color.FromArgb(180, Color.Peru)), num3 + (float)(num4 * size), num3 + (float)(num5 * size), num6, num6);
					num = ((int)num2 * -653172774) ^ 0x38185BD8;
					continue;
				case 34u:
					num5 = 0;
					num = (int)(num2 * 1949195557) ^ -1343982547;
					continue;
				case 33u:
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox1));
					num = (int)(num2 * 190989344) ^ -1603766283;
					continue;
				case 32u:
					num4 = 0;
					num = 2098799667;
					continue;
				case 31u:
					Form1.smethod_24(graphics_, Form1.smethod_23(), ((float)num4 + 0.05f) * (float)size, ((float)num5 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					num = (int)((num2 * 1354071196) ^ 0x7FD6CE42);
					continue;
				case 30u:
					num9 = 1f;
					num = (int)(num2 * 1578075113) ^ -1476874202;
					continue;
				case 29u:
					num = (int)(num2 * 1298089179) ^ -1219738611;
					continue;
				case 28u:
					brush_ = Form1.smethod_25();
					num = (int)((num2 * 334827576) ^ 0x79450694);
					continue;
				case 27u:
					num5++;
					num = ((int)num2 * -1252412766) ^ 0x446038B5;
					continue;
				case 26u:
					num = 497467128;
					continue;
				case 25u:
					num = (int)((num2 * 1493502206) ^ 0x7082E372);
					continue;
				case 22u:
					num = ((int)num2 * -1690343655) ^ 0x66622ED5;
					continue;
				case 21u:
					num = (int)((num2 * 1092701162) ^ 0x4AA5246C);
					continue;
				case 20u:
				{
					int num17;
					int num18;
					if (!big)
					{
						num17 = -1685065272;
						num18 = -1685065272;
					}
					else
					{
						num17 = -1025087943;
						num18 = -1025087943;
					}
					num = num17 ^ (int)(num2 * 510394776);
					continue;
				}
				case 19u:
				{
					num10 = 1f - num9 * 0.4f / (float)Form1.smethod_27(2.0);
					num3 = (float)size * (num10 / 2f);
					num6 = num11 * 0.4f / (float)Form1.smethod_27(2.0);
					int num16;
					if (!board[num5, num4].Point)
					{
						num = 937193194;
						num16 = 937193194;
					}
					else
					{
						num = 84759722;
						num16 = 84759722;
					}
					continue;
				}
				case 18u:
					brush_ = Form1.smethod_26();
					num = 1724985956;
					continue;
				case 17u:
					num = (int)(num2 * 2003519935) ^ -1526280113;
					continue;
				case 16u:
				{
					int num14;
					int num15;
					if (square)
					{
						num14 = -2594818;
						num15 = -2594818;
					}
					else
					{
						num14 = -2002285511;
						num15 = -2002285511;
					}
					num = num14 ^ (int)(num2 * 1194104790);
					continue;
				}
				case 15u:
					num = 1400599487;
					continue;
				case 14u:
					num4++;
					num = (int)((num2 * 892725541) ^ 0x7243FAB9);
					continue;
				case 13u:
					flag = board[num5, num4] != null;
					num = ((int)num2 * -1078191945) ^ 0x5C320A3C;
					continue;
				case 12u:
					num = ((int)num2 * -1237297687) ^ -1840502474;
					continue;
				case 11u:
					num11 = (float)size * num9;
					num3 = (float)size * (num10 / 2f);
					num = ((int)num2 * -1650819726) ^ -1924408971;
					continue;
				case 10u:
				{
					int num13;
					if (num5 < 4)
					{
						num = 789908753;
						num13 = 789908753;
					}
					else
					{
						num = 725706196;
						num13 = 725706196;
					}
					continue;
				}
				case 9u:
					big = board[num5, num4].Big;
					num = 1695608507;
					continue;
				case 8u:
				{
					int num12;
					if (num4 >= 4)
					{
						num = 739537498;
						num12 = 739537498;
					}
					else
					{
						num = 917484805;
						num12 = 917484805;
					}
					continue;
				}
				case 7u:
					num9 = 0.7f;
					num = 1632208784;
					continue;
				case 6u:
					num6 = num11 * 0.9f / (float)Form1.smethod_27(2.0);
					square = board[num5, num4].Square;
					num = ((int)num2 * -290382042) ^ -1261092099;
					continue;
				case 5u:
					num10 = 1f - num9 * 0.9f / (float)Form1.smethod_27(2.0);
					num = 964785972;
					continue;
				case 4u:
				{
					int num7;
					int num8;
					if (flag)
					{
						num7 = -1180768955;
						num8 = -1180768955;
					}
					else
					{
						num7 = -1194983776;
						num8 = -1194983776;
					}
					num = num7 ^ ((int)num2 * -1503728510);
					continue;
				}
				case 3u:
					num = 1183100504;
					continue;
				case 2u:
					Form1.smethod_24(graphics_, brush_, num3 + (float)(num4 * size), num3 + (float)(num5 * size), num6, num6);
					num = 225664411;
					continue;
				case 1u:
					Form1.smethod_28(graphics_, brush_, num3 + (float)(num4 * size), num3 + (float)(num5 * size), num6, num6);
					num = (int)(num2 * 1625050474) ^ -1494790008;
					continue;
				case 0u:
					num = (int)(num2 * 149323756) ^ -1701807878;
					continue;
				default:
					return;
				case 24u:
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
		int num = 0;
		float num10 = default(float);
		float num7 = default(float);
		Graphics graphics_ = default(Graphics);
		Brush brush_ = default(Brush);
		float num11 = default(float);
		float num13 = default(float);
		bool big = default(bool);
		int num4 = default(int);
		bool flag = default(bool);
		float num12 = default(float);
		bool flag3 = default(bool);
		bool flag2 = default(bool);
		while (true)
		{
			int num2 = -1185622837;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0xCAA2242Cu) % 36u)
				{
				case 35u:
					num10 = 1f - num7 * 0.4f / (float)Form1.smethod_27(2.0);
					num2 = -2063484732;
					continue;
				case 34u:
					Form1.smethod_24(graphics_, brush_, num11, num11, num13, num13);
					num2 = -253861701;
					continue;
				case 33u:
					num2 = ((int)num3 * -6903187) ^ -1267359149;
					continue;
				case 32u:
					big = storage[num, num4].Big;
					num2 = -978614614;
					continue;
				case 31u:
					num2 = ((int)num3 * -195520833) ^ -1046285996;
					continue;
				case 30u:
					num7 = 1f;
					num2 = (int)((num3 * 132348559) ^ 0x25130CFB);
					continue;
				case 29u:
					flag = num < 4;
					num2 = -1359573719;
					continue;
				case 27u:
					num4 = 0;
					num2 = -1470056629;
					continue;
				case 26u:
				{
					int num18;
					int num19;
					if (num4 < 2)
					{
						num18 = -123272806;
						num19 = -123272806;
					}
					else
					{
						num18 = -27855016;
						num19 = -27855016;
					}
					num2 = num18 ^ (int)(num3 * 1419946055);
					continue;
				}
				case 25u:
					num10 = 1f - num7 * 0.9f / (float)Form1.smethod_27(2.0);
					num12 = (float)size * num7;
					num2 = -440963744;
					continue;
				case 24u:
					num11 = (float)size * (num10 / 2f) - 4f;
					num13 = num12 * 0.4f / (float)Form1.smethod_27(2.0);
					num2 = (int)(num3 * 817642433) ^ -604088869;
					continue;
				case 23u:
					num2 = ((int)num3 * -1245996289) ^ 0x5034A607;
					continue;
				case 22u:
					Form1.smethod_20(pictureBox[num, num4], (Image)(object)Form1.smethod_19(Form1.smethod_18((Control)(object)pictureBox[num, num4]), Form1.smethod_16((Control)(object)pictureBox[num, num4])));
					num2 = ((int)num3 * -442494656) ^ 0x6ABB181A;
					continue;
				case 21u:
					brush_ = Form1.smethod_26();
					num2 = -1704369872;
					continue;
				case 20u:
					num++;
					num2 = (int)((num3 * 1208731497) ^ 0x6B6733D9);
					continue;
				case 19u:
					num7 = 0.7f;
					num2 = -1555994347;
					continue;
				case 18u:
				{
					int num22;
					int num23;
					if (storage[num, num4].Dark)
					{
						num22 = 1001960421;
						num23 = 1001960421;
					}
					else
					{
						num22 = 294138169;
						num23 = 294138169;
					}
					num2 = num22 ^ ((int)num3 * -1091152908);
					continue;
				}
				case 17u:
					num2 = (int)((num3 * 861798756) ^ 0x3880FD34);
					continue;
				case 16u:
					flag3 = storage[num, num4] != null;
					num2 = -1541443327;
					continue;
				case 15u:
					Form1.smethod_24(graphics_, (Brush)(object)Form1.smethod_29(Color.FromArgb(180, Color.Peru)), num11, num11, num13, num13);
					num2 = ((int)num3 * -803810288) ^ 0x3D5D57BF;
					continue;
				case 14u:
				{
					int num20;
					int num21;
					if (big)
					{
						num20 = 279905516;
						num21 = 279905516;
					}
					else
					{
						num20 = 2135113237;
						num21 = 2135113237;
					}
					num2 = num20 ^ (int)(num3 * 1860170899);
					continue;
				}
				case 13u:
					brush_ = Form1.smethod_25();
					num2 = (int)((num3 * 1565047463) ^ 0x4AC37B2);
					continue;
				case 12u:
					Form1.smethod_28(graphics_, brush_, num11, num11, num13, num13);
					num2 = (int)(num3 * 1148956148) ^ -1806174869;
					continue;
				case 11u:
					num2 = ((int)num3 * -1665315647) ^ 0x1C41086B;
					continue;
				case 10u:
				{
					int num16;
					int num17;
					if (!flag2)
					{
						num16 = 1473712012;
						num17 = 1473712012;
					}
					else
					{
						num16 = 1197763584;
						num17 = 1197763584;
					}
					num2 = num16 ^ ((int)num3 * -1356588986);
					continue;
				}
				case 9u:
				{
					int num14;
					int num15;
					if (!flag3)
					{
						num14 = 799999419;
						num15 = 799999419;
					}
					else
					{
						num14 = 125256450;
						num15 = 125256450;
					}
					num2 = num14 ^ (int)(num3 * 1144153615);
					continue;
				}
				case 7u:
					Form1.smethod_30((Control)(object)pictureBox[num, num4]);
					num2 = -1838761953;
					continue;
				case 6u:
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox[num, num4]));
					num2 = ((int)num3 * -527132589) ^ 0x4A09CC98;
					continue;
				case 5u:
					num13 = num12 * 0.9f / (float)Form1.smethod_27(2.0);
					num2 = ((int)num3 * -1034598704) ^ -1164318782;
					continue;
				case 4u:
					num11 = (float)size * (num10 / 2f) - 4f;
					num2 = ((int)num3 * -874630817) ^ -554666535;
					continue;
				case 3u:
				{
					int num8;
					int num9;
					if (!storage[num, num4].Point)
					{
						num8 = -14043982;
						num9 = -14043982;
					}
					else
					{
						num8 = -987713290;
						num9 = -987713290;
					}
					num2 = num8 ^ ((int)num3 * -1088540701);
					continue;
				}
				case 2u:
					flag2 = num4 < 4;
					num2 = -128282302;
					continue;
				case 1u:
				{
					int num5;
					int num6;
					if (flag)
					{
						num5 = -1999841946;
						num6 = -1999841946;
					}
					else
					{
						num5 = -653270871;
						num6 = -653270871;
					}
					num2 = num5 ^ (int)(num3 * 1747470609);
					continue;
				}
				case 0u:
					num4++;
					num2 = -1148358754;
					continue;
				default:
					return;
				case 8u:
					break;
				case 28u:
					return;
				}
				break;
			}
		}
	}

	public void StartGame()
	{
		int num5 = default(int);
		bool flag3 = default(bool);
		int num6 = default(int);
		bool flag2 = default(bool);
		bool flag = default(bool);
		while (true)
		{
			int num = 263274608;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x5056488u) % 28u)
				{
				case 26u:
					num = (int)((num2 * 2074787981) ^ 0x68B4D251);
					continue;
				case 25u:
					num5++;
					num = (int)((num2 * 16624476) ^ 0x63EA1574);
					continue;
				case 24u:
					num = ((int)num2 * -1363902016) ^ -1684413386;
					continue;
				case 23u:
					flag3 = turn;
					num = (int)(num2 * 1090807373) ^ -1418930667;
					continue;
				case 22u:
					step = 0;
					num = ((int)num2 * -171461407) ^ 0xCC4705E;
					continue;
				case 21u:
				{
					int num9 = Form1.smethod_33(rnd, 4);
					int num10 = Form1.smethod_33(rnd, 4);
					Form1.smethod_5((Control)(object)borderBox[num9, num10], Color.Blue);
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: true);
					num = 1784787539;
					continue;
				}
				case 20u:
					Form1_Load(this, Form1.smethod_31());
					num = ((int)num2 * -2026078086) ^ -1538495783;
					continue;
				case 19u:
					num5 = 0;
					num = 826131720;
					continue;
				case 18u:
					num6 = 0;
					num = (int)((num2 * 1161132159) ^ 0x514CAF37);
					continue;
				case 17u:
				{
					int num11;
					int num12;
					if (flag2)
					{
						num11 = 1673070586;
						num12 = 1673070586;
					}
					else
					{
						num11 = 811824335;
						num12 = 811824335;
					}
					num = num11 ^ ((int)num2 * -27117367);
					continue;
				}
				case 16u:
					num = ((int)num2 * -124769765) ^ -833200249;
					continue;
				case 15u:
					Form1.smethod_32((Control)(object)label2, Form1.smethod_34("Ход: ", step.ToString()));
					time = new DateTime(0L, DateTimeKind.Unspecified);
					Form1.smethod_35(timer1, bool_0: true);
					num = 229291004;
					continue;
				case 14u:
					Form1.smethod_7((Control)(object)pictureBox[num6, num5], bool_0: true);
					num = 784628593;
					continue;
				case 12u:
					flag = num5 < 4;
					num = 1765211092;
					continue;
				case 11u:
					Form1.smethod_32((Control)(object)richTextBox1, "Противник выбрал фигуру. Выберете поле на доске для установки этой фигуры.");
					step = 1;
					num = (int)((num2 * 250024681) ^ 0x6C11DF49);
					continue;
				case 10u:
					Form1.smethod_32((Control)(object)richTextBox1, "Ваш ход. Выберете фигуру, которой будет играть противник.");
					num = (int)(num2 * 659510004) ^ -900079458;
					continue;
				case 9u:
					num = ((int)num2 * -729198306) ^ 0x33B8CE9D;
					continue;
				case 8u:
					num = (int)(num2 * 891931486) ^ -508247589;
					continue;
				case 7u:
					num = ((int)num2 * -1777485264) ^ 0x2547E5D7;
					continue;
				case 6u:
				{
					int num7;
					int num8;
					if (flag3)
					{
						num7 = -639808376;
						num8 = -639808376;
					}
					else
					{
						num7 = -893910923;
						num8 = -893910923;
					}
					num = num7 ^ ((int)num2 * -1436621504);
					continue;
				}
				case 5u:
					flag2 = num6 < 4;
					num = 918854469;
					continue;
				case 4u:
					num = ((int)num2 * -1004406325) ^ -1881737157;
					continue;
				case 3u:
					Form1.smethod_36(timer1);
					num = (int)(num2 * 685906075) ^ -1378401259;
					continue;
				case 2u:
					num6++;
					num = (int)(num2 * 2723745) ^ -1337327621;
					continue;
				case 1u:
					num = (int)(num2 * 1159458490) ^ -1908869033;
					continue;
				case 0u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = -115911894;
						num4 = -115911894;
					}
					else
					{
						num3 = -2118367642;
						num4 = -2118367642;
					}
					num = num3 ^ ((int)num2 * -336390964);
					continue;
				}
				default:
					return;
				case 13u:
					break;
				case 27u:
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
			int num = 1805486771;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1E2C46EBu) % 3u)
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
				num = (int)((num2 * 222072103) ^ 0x34E190A3);
			}
		}
	}

	private void PictureBoxIJ_MouseDown(object sender, MouseEventArgs e)
	{
		//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d8: Expected O, but got Unknown
		bool flag2 = default(bool);
		int num4 = default(int);
		int num5 = default(int);
		int num8 = default(int);
		Point point = default(Point);
		int num3 = default(int);
		bool flag = default(bool);
		while (true)
		{
			int num = 2052782430;
			while (true)
			{
				uint num2;
				int num12;
				switch ((num2 = (uint)num ^ 0x5C749705u) % 25u)
				{
				case 24u:
					Form1.smethod_32((Control)(object)richTextBox1, "Именно эта фигура? Если да - нажмите \"Подтвердить\".");
					num = ((int)num2 * -296094388) ^ 0xDE6A521;
					continue;
				case 23u:
					flag2 = num4 < 4;
					num = 990358850;
					continue;
				case 22u:
					Form1.smethod_5((Control)(object)borderBox[num5, num4], Color.White);
					num = 721774399;
					continue;
				case 21u:
					num4 = 0;
					num = 1127330185;
					continue;
				case 20u:
					num = (int)(num2 * 827007805) ^ -390837175;
					continue;
				case 19u:
				{
					int num11;
					if (num5 < 4)
					{
						num = 1666251542;
						num11 = 1666251542;
					}
					else
					{
						num = 287642919;
						num11 = 287642919;
					}
					continue;
				}
				case 18u:
					num = (int)((num2 * 1614125950) ^ 0x7203214E);
					continue;
				case 15u:
					num8 = Form1.smethod_37((Control)((sender is PictureBox) ? sender : null)).Y / size;
					point = Form1.smethod_37((Control)((sender is PictureBox) ? sender : null));
					num = (int)(num2 * 1456042034) ^ -984107663;
					continue;
				case 14u:
					num = ((int)num2 * -1059497113) ^ 0x1A26358A;
					continue;
				case 13u:
					num = (int)(num2 * 771944514) ^ -721441900;
					continue;
				case 12u:
					Form1.smethod_5((Control)(object)borderBox[num8, num3], Color.Red);
					num = (int)((num2 * 885344012) ^ 0x2136DB9F);
					continue;
				case 11u:
					num = (int)(num2 * 1090167167) ^ -240351370;
					continue;
				case 10u:
				{
					num3 = point.X / size;
					int num13;
					int num14;
					if (num3 > 1)
					{
						num13 = -1877171967;
						num14 = -1877171967;
					}
					else
					{
						num13 = -732529263;
						num14 = -732529263;
					}
					num = num13 ^ ((int)num2 * -2092029582);
					continue;
				}
				case 9u:
					if (storage[num8, num3] != null)
					{
						num = 1160711822;
						continue;
					}
					num12 = 0;
					goto IL_01a4;
				case 8u:
					num12 = ((Form1.smethod_40((Bitmap)Form1.smethod_21(pictureBox[num8, num3]), Form1.smethod_38(e), Form1.smethod_39(e)) != Color.FromArgb(0, 0, 0, 0)) ? 1 : 0);
					goto IL_01a4;
				case 7u:
				{
					int num9;
					int num10;
					if (!flag2)
					{
						num9 = 1694171258;
						num10 = 1694171258;
					}
					else
					{
						num9 = 2063089131;
						num10 = 2063089131;
					}
					num = num9 ^ (int)(num2 * 2057201879);
					continue;
				}
				case 6u:
					Form1.smethod_7((Control)(object)button2, bool_0: true);
					num = ((int)num2 * -27982216) ^ -854448837;
					continue;
				case 5u:
					num5++;
					num = (int)(num2 * 1907604398) ^ -192524029;
					continue;
				case 4u:
				{
					int num6;
					int num7;
					if (flag)
					{
						num6 = 1608713836;
						num7 = 1608713836;
					}
					else
					{
						num6 = 1657507177;
						num7 = 1657507177;
					}
					num = num6 ^ (int)(num2 * 1564038463);
					continue;
				}
				case 3u:
					num5 = 0;
					num = (int)((num2 * 723054955) ^ 0x6F5C6C7B);
					continue;
				case 2u:
					num = (int)(num2 * 1638335011) ^ -1898987359;
					continue;
				case 1u:
					num4++;
					num = (int)((num2 * 869520406) ^ 0x2B88341D);
					continue;
				case 0u:
					num3 -= 4;
					num = ((int)num2 * -1052502786) ^ 0x5254F55;
					continue;
				default:
					return;
				case 17u:
					break;
				case 16u:
					return;
					IL_01a4:
					flag = (byte)num12 != 0;
					num = 825066381;
					continue;
				}
				break;
			}
		}
	}

	private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		int num = Form1.smethod_38(e) / size;
		int num2 = Form1.smethod_39(e) / size;
		if (Form1.smethod_40((Bitmap)Form1.smethod_21(pictureBox1), Form1.smethod_38(e), Form1.smethod_39(e)) != Color.FromArgb(0, 0, 0, 0))
		{
			goto IL_0123;
		}
		int num3 = 0;
		goto IL_039a;
		IL_039a:
		bool flag = (byte)num3 != 0;
		int num4 = -251750153;
		goto IL_0317;
		IL_0123:
		num4 = -1791033291;
		goto IL_0317;
		IL_0317:
		Graphics graphics_ = default(Graphics);
		int num8 = default(int);
		int num11 = default(int);
		bool flag2 = default(bool);
		bool flag3 = default(bool);
		while (true)
		{
			uint num5;
			switch ((num5 = (uint)num4 ^ 0xBA1FC5F4u) % 24u)
			{
			case 23u:
				Form1.smethod_43(graphics_, Form1.smethod_42(Color.Red, 3f), ((float)num + 0.05f) * (float)size, ((float)num2 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
				num4 = ((int)num5 * -600628402) ^ -558689656;
				continue;
			case 22u:
				Form1.smethod_44(graphics_, Form1.smethod_21(pictureBox[num8, num11]), num * size + 4, num2 * size + 4, new Rectangle(0, 0, size, size), (GraphicsUnit)2);
				num4 = (int)(num5 * 112801025) ^ -1537589091;
				continue;
			case 21u:
				num8 = 0;
				num4 = ((int)num5 * -404064893) ^ -767704931;
				continue;
			case 20u:
				break;
			case 19u:
				num11++;
				num4 = -209716007;
				continue;
			case 18u:
				num11 = 0;
				num4 = -1335902447;
				continue;
			case 17u:
				Paint_Board();
				graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox1));
				num4 = ((int)num5 * -2107186172) ^ -1328508233;
				continue;
			case 15u:
				flag2 = num8 < 4;
				num4 = -1220506969;
				continue;
			case 14u:
				num4 = ((int)num5 * -71503520) ^ -688276997;
				continue;
			case 13u:
				goto IL_0198;
			case 12u:
				Form1.smethod_30((Control)(object)pictureBox1);
				num4 = (int)(num5 * 893945733) ^ -1407429976;
				continue;
			case 11u:
			{
				int num12;
				int num13;
				if (!flag)
				{
					num12 = 502777750;
					num13 = 502777750;
				}
				else
				{
					num12 = 895707835;
					num13 = 895707835;
				}
				num4 = num12 ^ (int)(num5 * 1521464342);
				continue;
			}
			case 10u:
				flag3 = Form1.smethod_41((Control)(object)borderBox[num8, num11]) == Color.Blue;
				num4 = -2145643771;
				continue;
			case 9u:
			{
				int num9;
				int num10;
				if (!flag3)
				{
					num9 = -1883129230;
					num10 = -1883129230;
				}
				else
				{
					num9 = -1970545853;
					num10 = -1970545853;
				}
				num4 = num9 ^ ((int)num5 * -950765419);
				continue;
			}
			case 8u:
				num4 = (int)(num5 * 926617276) ^ -691349568;
				continue;
			case 7u:
				Form1.smethod_45(graphics_);
				num4 = (int)((num5 * 2013501086) ^ 0x20A91B0E);
				continue;
			case 6u:
				num4 = ((int)num5 * -1269794099) ^ -1071477342;
				continue;
			case 5u:
				num4 = (int)((num5 * 43501145) ^ 0x45F52B44);
				continue;
			case 4u:
				num8++;
				num4 = ((int)num5 * -931604845) ^ -1213456505;
				continue;
			case 3u:
			{
				int num6;
				int num7;
				if (flag2)
				{
					num6 = 2095773626;
					num7 = 2095773626;
				}
				else
				{
					num6 = 1077706552;
					num7 = 1077706552;
				}
				num4 = num6 ^ (int)(num5 * 662794212);
				continue;
			}
			case 2u:
				num4 = (int)((num5 * 1167088215) ^ 0x5E99E52B);
				continue;
			case 0u:
				Form1.smethod_7((Control)(object)button2, bool_0: true);
				Form1.smethod_32((Control)(object)richTextBox1, "Уверены? Для выполнения данного хода нажмите \"Подтвердить\".");
				num4 = (int)((num5 * 867653231) ^ 0x68B329B2);
				continue;
			default:
				return;
			case 1u:
				goto IL_038a;
			case 16u:
				return;
			}
			break;
			IL_0198:
			int num14;
			if (num11 < 4)
			{
				num4 = -1428651594;
				num14 = -1428651594;
			}
			else
			{
				num4 = -2019954016;
				num14 = -2019954016;
			}
		}
		goto IL_0123;
		IL_038a:
		num3 = ((board[num2, num] == null) ? 1 : 0);
		goto IL_039a;
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		//IL_1404: Unknown result type (might be due to invalid IL or missing references)
		//IL_1432: Expected O, but got Unknown
		Form1.smethod_7((Control)(object)button2, bool_0: false);
		bool flag = Form1.smethod_46((Control)(object)pictureBox1);
		int num3 = default(int);
		bool flag11 = default(bool);
		bool flag13 = default(bool);
		int num39 = default(int);
		bool flag12 = default(bool);
		int num15 = default(int);
		int num6 = default(int);
		Graphics graphics_ = default(Graphics);
		int num10 = default(int);
		int num19 = default(int);
		int num31 = default(int);
		int num30 = default(int);
		bool flag7 = default(bool);
		int num12 = default(int);
		int num11 = default(int);
		int num37 = default(int);
		Figurine[,] array2 = default(Figurine[,]);
		int num22 = default(int);
		int num26 = default(int);
		int num32 = default(int);
		int num5 = default(int);
		int num40 = default(int);
		int num27 = default(int);
		Figurine[,] array3 = default(Figurine[,]);
		int num36 = default(int);
		int num23 = default(int);
		bool flag5 = default(bool);
		bool flag10 = default(bool);
		bool flag9 = default(bool);
		int num28 = default(int);
		bool flag14 = default(bool);
		bool flag8 = default(bool);
		bool flag2 = default(bool);
		bool flag3 = default(bool);
		int num21 = default(int);
		Figurine[,] array = default(Figurine[,]);
		bool flag6 = default(bool);
		bool flag4 = default(bool);
		while (true)
		{
			int num = 829344710;
			while (true)
			{
				uint num2;
				int num33;
				int num9;
				int num4;
				int num16;
				switch ((num2 = (uint)num ^ 0x2AC0A466u) % 169u)
				{
				case 168u:
					Form1.smethod_32((Control)(object)richTextBox1, "Ничья!");
					num = (int)(num2 * 700105782) ^ -1394591733;
					continue;
				case 167u:
					num = ((int)num2 * -556317488) ^ 0x7E30E05E;
					continue;
				case 166u:
					num3++;
					flag11 = false;
					num = (int)(num2 * 709575336) ^ -1802066627;
					continue;
				case 165u:
					flag13 = num39 < 4;
					num = 884757068;
					continue;
				case 164u:
				{
					int num46;
					int num47;
					if (!flag12)
					{
						num46 = -353090452;
						num47 = -353090452;
					}
					else
					{
						num46 = -1218222280;
						num47 = -1218222280;
					}
					num = num46 ^ ((int)num2 * -1907865119);
					continue;
				}
				case 163u:
					num = (int)((num2 * 542138266) ^ 0x365A04D3);
					continue;
				case 162u:
					num = 306627835;
					continue;
				case 161u:
					if (num15 == num6)
					{
						goto IL_00ce;
					}
					goto IL_00da;
				case 160u:
					num = (int)(num2 * 637774906) ^ -365959352;
					continue;
				case 159u:
					num = (int)(num2 * 99012068) ^ -826348032;
					continue;
				case 158u:
					Form1.smethod_43(graphics_, Form1.smethod_42(Color.LimeGreen, 3f), ((float)num10 + 0.05f) * (float)size, ((float)num19 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					num = (int)(num2 * 1812106567) ^ -439382505;
					continue;
				case 157u:
					num31 = Form1.smethod_33(rnd, 4);
					num30 = Form1.smethod_33(rnd, 4);
					num = 558393820;
					continue;
				case 156u:
					flag7 = Form1.smethod_41((Control)(object)borderBox[num12, num11]) == Color.Blue;
					num = 1439611582;
					continue;
				case 155u:
					num37++;
					num = ((int)num2 * -1469638304) ^ -1454789573;
					continue;
				case 154u:
					array2[num39, num22] = new Figurine(storage[num26, num15]);
					num = ((int)num2 * -872706502) ^ -90910933;
					continue;
				case 153u:
				{
					int num59;
					if (num32 < 4)
					{
						num = 2093602232;
						num59 = 2093602232;
					}
					else
					{
						num = 2035918598;
						num59 = 2035918598;
					}
					continue;
				}
				case 152u:
					Form1.smethod_30((Control)(object)pictureBox[num12, num11]);
					num = (int)(num2 * 1384075334) ^ -1770615805;
					continue;
				case 151u:
					num = 860083022;
					continue;
				case 150u:
					num = (int)((num2 * 874769134) ^ 0x71498C6B);
					continue;
				case 149u:
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: true);
					num = ((int)num2 * -1411195400) ^ -121559192;
					continue;
				case 148u:
					(menu as Form3).ContinueLock();
					num = (int)(num2 * 483911092) ^ -268478272;
					continue;
				case 147u:
					Form1.smethod_30((Control)(object)borderBox[num5, num6]);
					num = ((int)num2 * -165604328) ^ 0x7020999E;
					continue;
				case 146u:
					step++;
					Form1.smethod_32((Control)(object)label2, Form1.smethod_34("Ход: ", step.ToString()));
					num = (int)(num2 * 987212887) ^ -964141824;
					continue;
				case 145u:
					Form1.smethod_15(timer1);
					num = 533206552;
					continue;
				case 144u:
					num = (int)(num2 * 1834927770) ^ -1208323904;
					continue;
				case 143u:
					num = (int)((num2 * 1730930087) ^ 0x2EE186B6);
					continue;
				case 142u:
					num = ((int)num2 * -26571428) ^ -169134712;
					continue;
				case 141u:
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: false);
					num40 = 0;
					num27 = 0;
					num = (int)((num2 * 2060334613) ^ 0x2EF74E93);
					continue;
				case 140u:
					Form1.smethod_5((Control)(object)borderBox[num5, num6], Color.White);
					num = ((int)num2 * -438046017) ^ -2063241079;
					continue;
				case 139u:
					num = (int)(num2 * 144048681) ^ -855632507;
					continue;
				case 138u:
					num = (int)(num2 * 1592523309) ^ -1540244195;
					continue;
				case 137u:
					num22++;
					num = 777310409;
					continue;
				case 136u:
				{
					int num42;
					int num43;
					if (board[num31, num30] != null)
					{
						num42 = 386886239;
						num43 = 386886239;
					}
					else
					{
						num42 = 1359679924;
						num43 = 1359679924;
					}
					num = num42 ^ ((int)num2 * -251891655);
					continue;
				}
				case 135u:
					Form1.smethod_30((Control)(object)pictureBox1);
					num = ((int)num2 * -1485366921) ^ -1152747724;
					continue;
				case 134u:
					Form1.smethod_20(pictureBox[num5, num6], (Image)null);
					num = ((int)num2 * -2118261960) ^ 0x676EDC50;
					continue;
				case 133u:
					if (!Stop(array3))
					{
						num = (int)(num2 * 487590767) ^ -982888499;
						continue;
					}
					num33 = 1;
					goto IL_0491;
				case 132u:
					step++;
					num = ((int)num2 * -1661742748) ^ 0x3DDD9BF9;
					continue;
				case 131u:
					num36 = num12;
					num = (int)(num2 * 1790581341) ^ -1940457287;
					continue;
				case 130u:
					num23 = 0;
					num = 417760303;
					continue;
				case 129u:
					Form1.smethod_44(graphics_, Form1.smethod_21(pictureBox[num5, num6]), num30 * size + 4, num31 * size + 4, new Rectangle(0, 0, size, size), (GraphicsUnit)2);
					num = (int)((num2 * 350929833) ^ 0x78F99B30);
					continue;
				case 128u:
					if (num26 == num5)
					{
						num = (int)(num2 * 1588475032) ^ -296897899;
						continue;
					}
					goto IL_00da;
				case 127u:
					num27 = num11;
					Form1.smethod_5((Control)(object)borderBox[num12, num11], Color.White);
					Form1.smethod_30((Control)(object)borderBox[num12, num11]);
					num = (int)(num2 * 1478651405) ^ -1666362790;
					continue;
				case 126u:
					num11 = 0;
					num = 1959881854;
					continue;
				case 125u:
				{
					int num17;
					int num18;
					if (flag5)
					{
						num17 = 351466092;
						num18 = 351466092;
					}
					else
					{
						num17 = 1150674770;
						num18 = 1150674770;
					}
					num = num17 ^ ((int)num2 * -1937149147);
					continue;
				}
				case 124u:
					if (!Standoff(board))
					{
						num = 817023317;
						num9 = 817023317;
						continue;
					}
					goto IL_05ee;
				case 123u:
					storage[num5, num6] = null;
					num = ((int)num2 * -647447239) ^ -692957861;
					continue;
				case 122u:
					Form1.smethod_32((Control)(object)label2, Form1.smethod_34("Ход: ", step.ToString()));
					num = ((int)num2 * -277382452) ^ -397200097;
					continue;
				case 121u:
				{
					int num62;
					int num63;
					if (flag10)
					{
						num62 = -916930135;
						num63 = -916930135;
					}
					else
					{
						num62 = -462857719;
						num63 = -462857719;
					}
					num = num62 ^ ((int)num2 * -9190836);
					continue;
				}
				case 120u:
				{
					int num60;
					int num61;
					if (flag9)
					{
						num60 = -875470513;
						num61 = -875470513;
					}
					else
					{
						num60 = -593482675;
						num61 = -593482675;
					}
					num = num60 ^ (int)(num2 * 49222896);
					continue;
				}
				case 119u:
					Form1.smethod_7((Control)(object)pictureBox[num37, num28], bool_0: true);
					num28++;
					num = 510955556;
					continue;
				case 118u:
					num40 = num12;
					num = ((int)num2 * -1472079625) ^ 0x737AFCB1;
					continue;
				case 117u:
				{
					int num57;
					int num58;
					if (flag14)
					{
						num57 = -549993930;
						num58 = -549993930;
					}
					else
					{
						num57 = -643630334;
						num58 = -643630334;
					}
					num = num57 ^ ((int)num2 * -1070606168);
					continue;
				}
				case 116u:
					num = ((int)num2 * -1369237220) ^ -1974743233;
					continue;
				case 115u:
					Form1.smethod_32((Control)(object)richTextBox1, "Выберете фигуру, которой будет играть противник.");
					num = (int)(num2 * 300561706) ^ -1692452900;
					continue;
				case 114u:
					num = (int)((num2 * 1060288886) ^ 0x7736ABF0);
					continue;
				case 113u:
					num23++;
					num = 323073264;
					continue;
				case 112u:
					num32++;
					num = (int)((num2 * 1710679568) ^ 0x673554A2);
					continue;
				case 111u:
				{
					int num55;
					int num56;
					if (flag8)
					{
						num55 = -900603364;
						num56 = -900603364;
					}
					else
					{
						num55 = -1518134641;
						num56 = -1518134641;
					}
					num = num55 ^ (int)(num2 * 328261146);
					continue;
				}
				case 110u:
					flag2 = num11 < 4;
					num = 477855217;
					continue;
				case 109u:
				{
					int num53;
					int num54;
					if (flag)
					{
						num53 = 304033940;
						num54 = 304033940;
					}
					else
					{
						num53 = 18633837;
						num54 = 18633837;
					}
					num = num53 ^ ((int)num2 * -526756830);
					continue;
				}
				case 108u:
					num = 714427186;
					continue;
				case 107u:
				{
					int num51;
					int num52;
					if (flag3)
					{
						num51 = 2111233861;
						num52 = 2111233861;
					}
					else
					{
						num51 = 1725633207;
						num52 = 1725633207;
					}
					num = num51 ^ (int)(num2 * 2082562464);
					continue;
				}
				case 106u:
					num5 = num32;
					num = ((int)num2 * -216069462) ^ -1873599905;
					continue;
				case 105u:
					Form1.smethod_32((Control)(object)richTextBox1, "Ничья!");
					num = (int)(num2 * 1088844283) ^ -823296276;
					continue;
				case 104u:
					Form1.smethod_5((Control)(object)borderBox[num5, num6], Color.White);
					num = ((int)num2 * -851611994) ^ -1884198055;
					continue;
				case 103u:
					num3 = 0;
					num = (int)((num2 * 1642123740) ^ 0x87820A);
					continue;
				case 102u:
					num36 = 0;
					num21 = 0;
					num12 = 0;
					num = ((int)num2 * -985091054) ^ -1399017946;
					continue;
				case 101u:
					num = 807413870;
					continue;
				case 100u:
					num = (int)((num2 * 1634928358) ^ 0x1A315032);
					continue;
				case 99u:
				{
					int num50;
					if (array[num39, num22] != null)
					{
						num = 1298133477;
						num50 = 1298133477;
					}
					else
					{
						num = 286318330;
						num50 = 286318330;
					}
					continue;
				}
				case 98u:
					num = (int)(num2 * 1213340067) ^ -1368875483;
					continue;
				case 97u:
					num = ((int)num2 * -573552958) ^ -1679719510;
					continue;
				case 96u:
					num6 = 0;
					num32 = 0;
					num = (int)((num2 * 209416933) ^ 0x313A45E4);
					continue;
				case 95u:
					num = ((int)num2 * -1325052098) ^ -1465337177;
					continue;
				case 94u:
					num = (int)((num2 * 710006511) ^ 0x512DC84C);
					continue;
				case 93u:
					num12++;
					num = ((int)num2 * -1626765129) ^ 0x611A7E1E;
					continue;
				case 92u:
					Form1.smethod_30((Control)(object)label2);
					num = (int)((num2 * 670212783) ^ 0x6C12D2B1);
					continue;
				case 91u:
					Form1.smethod_5((Control)(object)borderBox[num26, num15], Color.Blue);
					num = ((int)num2 * -2141211749) ^ 0x39D73512;
					continue;
				case 90u:
					Form1.smethod_30((Control)(object)borderBox[num26, num15]);
					num = (int)((num2 * 813775768) ^ 0x38142EB4);
					continue;
				case 88u:
					if (!flag11)
					{
						num = ((int)num2 * -297575415) ^ -1879245221;
						continue;
					}
					goto IL_09fa;
				case 87u:
				{
					int num48;
					int num49;
					if (flag6)
					{
						num48 = -1044819439;
						num49 = -1044819439;
					}
					else
					{
						num48 = -1844507763;
						num49 = -1844507763;
					}
					num = num48 ^ ((int)num2 * -749833841);
					continue;
				}
				case 86u:
					num = ((int)num2 * -285088071) ^ -1048586699;
					continue;
				case 85u:
					flag14 = Form1.smethod_41((Control)(object)borderBox[num32, num23]) == Color.Red;
					num = (int)(num2 * 1586155254) ^ -955738698;
					continue;
				case 84u:
				{
					int num44;
					int num45;
					if (!flag13)
					{
						num44 = 1402863609;
						num45 = 1402863609;
					}
					else
					{
						num44 = 1304730458;
						num45 = 1304730458;
					}
					num = num44 ^ ((int)num2 * -1355025476);
					continue;
				}
				case 83u:
					num39 = 0;
					num = (int)((num2 * 661273274) ^ 0x7316133E);
					continue;
				case 82u:
					num5 = 0;
					num = (int)((num2 * 642142608) ^ 0x498DBBB4);
					continue;
				case 81u:
					Form1.smethod_30((Control)(object)pictureBox1);
					Form1.smethod_47(200);
					num = ((int)num2 * -1253762273) ^ -1535767466;
					continue;
				case 80u:
					Form1.smethod_43(graphics_, Form1.smethod_42(Color.LimeGreen, 3f), ((float)num30 + 0.05f) * (float)size, ((float)num31 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					num = (int)((num2 * 1657451106) ^ 0x56D8F3FD);
					continue;
				case 79u:
					num = (int)(num2 * 254599179) ^ -1648260494;
					continue;
				case 78u:
					Form1.smethod_30((Control)(object)borderBox[num5, num6]);
					num = ((int)num2 * -979465535) ^ 0x115BBB9C;
					continue;
				case 77u:
					array3[num19, num10] = new Figurine(storage[num5, num6]);
					num = (int)((num2 * 1447727021) ^ 0x760AB5F);
					continue;
				case 76u:
					(menu as Form3).ContinueLock();
					num = ((int)num2 * -188056429) ^ -2081719537;
					continue;
				case 75u:
					Form1.smethod_32((Control)(object)richTextBox1, "Подождите, компьютер делает свой ход.");
					num = ((int)num2 * -1751463389) ^ 0x11438608;
					continue;
				case 74u:
					Form1.smethod_30((Control)(object)richTextBox1);
					num = ((int)num2 * -1656232835) ^ -1644508654;
					continue;
				case 73u:
					num = (int)(num2 * 1961116028) ^ -1582852119;
					continue;
				case 72u:
					num11++;
					num = (int)((num2 * 1049998325) ^ 0x2483EFAB);
					continue;
				case 71u:
					num = (int)((num2 * 728189904) ^ 0x543B34F);
					continue;
				case 70u:
					Form1.smethod_44(graphics_, Form1.smethod_21(pictureBox[num5, num6]), num10 * size + 4, num19 * size + 4, new Rectangle(0, 0, size, size), (GraphicsUnit)2);
					num = ((int)num2 * -894489209) ^ -2042397331;
					continue;
				case 69u:
					num = 1434088595;
					continue;
				case 67u:
					Form1.smethod_30((Control)(object)pictureBox[num5, num6]);
					board[num31, num30] = new Figurine(storage[num5, num6]);
					storage[num5, num6] = null;
					num = (int)(num2 * 2034778748) ^ -1610128677;
					continue;
				case 66u:
					array[num31, num30] = new Figurine(storage[num5, num6]);
					num = ((int)num2 * -38904133) ^ 0x51730012;
					continue;
				case 65u:
					num = (int)(num2 * 1306010945) ^ -379000613;
					continue;
				case 64u:
					num22 = 0;
					num = 777310409;
					continue;
				case 63u:
				{
					int num41;
					if (num37 >= 4)
					{
						num = 327239229;
						num41 = 327239229;
					}
					else
					{
						num = 661866892;
						num41 = 661866892;
					}
					continue;
				}
				case 62u:
					num15 = Form1.smethod_33(rnd, 4);
					if (storage[num26, num15] != null)
					{
						num = ((int)num2 * -2036155499) ^ 0x2609703A;
						continue;
					}
					goto IL_00ce;
				case 61u:
					board[num36, num21] = new Figurine(storage[num40, num27]);
					storage[num40, num27] = null;
					Paint_Board();
					if (!Stop(board))
					{
						num = (int)((num2 * 609282037) ^ 0x5E0EF551);
						continue;
					}
					goto IL_05ee;
				case 60u:
					flag11 = true;
					num = ((int)num2 * -222114281) ^ 0x6F512CE4;
					continue;
				case 59u:
					Form1.smethod_20(pictureBox[num12, num11], (Image)null);
					num = ((int)num2 * -901805223) ^ -1453567528;
					continue;
				case 58u:
					num = (int)(num2 * 832392301) ^ -1766656296;
					continue;
				case 57u:
					num28 = 0;
					num = 177867391;
					continue;
				case 56u:
					num = ((int)num2 * -1322929749) ^ -1869856539;
					continue;
				case 55u:
					num = (int)(num2 * 282258446) ^ -2131814482;
					continue;
				case 54u:
					Form1.smethod_47(1000);
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox1));
					num19 = 0;
					num = (int)(num2 * 1173132932) ^ -723743033;
					continue;
				case 53u:
					num39++;
					num = (int)(num2 * 101700521) ^ -416706044;
					continue;
				case 52u:
					num = (int)(num2 * 122829549) ^ -1929100745;
					continue;
				case 51u:
					array = (Figurine[,])Form1.smethod_48((Array)board);
					num = (int)(num2 * 95547892) ^ -1002950779;
					continue;
				case 50u:
					Form1.smethod_20(pictureBox[num5, num6], (Image)null);
					Form1.smethod_30((Control)(object)pictureBox[num5, num6]);
					num = ((int)num2 * -65956279) ^ 0x4E85C154;
					continue;
				case 49u:
				{
					int num38;
					if (num23 < 4)
					{
						num = 1613330543;
						num38 = 1613330543;
					}
					else
					{
						num = 938400056;
						num38 = 938400056;
					}
					continue;
				}
				case 48u:
					num37 = 0;
					num = ((int)num2 * -2145293203) ^ 0x258C9DAC;
					continue;
				case 47u:
					num10++;
					num = 536010015;
					continue;
				case 46u:
					num = (int)(num2 * 125617659) ^ -1268043413;
					continue;
				case 45u:
					Form1.smethod_7((Control)(object)pictureBox[num32, num23], bool_0: false);
					num = 1223301577;
					continue;
				case 44u:
				{
					int num34;
					int num35;
					if (!Stop(array2))
					{
						num34 = -1117040826;
						num35 = -1117040826;
					}
					else
					{
						num34 = -1840100558;
						num35 = -1840100558;
					}
					num = num34 ^ ((int)num2 * -289045865);
					continue;
				}
				case 43u:
					num = ((int)num2 * -1826788443) ^ -2143051911;
					continue;
				case 42u:
					Form1.smethod_47(200);
					num = ((int)num2 * -1690542287) ^ -80777291;
					continue;
				case 41u:
					num = ((int)num2 * -595088479) ^ 0x3131667F;
					continue;
				case 40u:
					Form1.smethod_32((Control)(object)richTextBox1, "QUARTO! Компьютер выиграл!");
					num = 413186112;
					continue;
				case 39u:
					flag4 = Standoff(board);
					num = 715739874;
					continue;
				case 38u:
					board[num19, num10] = new Figurine(storage[num5, num6]);
					num = ((int)num2 * -1521576368) ^ -2123772244;
					continue;
				case 37u:
					num33 = (Standoff(array3) ? 1 : 0);
					goto IL_0491;
				case 36u:
					Form1.smethod_5((Control)(object)borderBox[num32, num23], Color.LimeGreen);
					num = (int)((num2 * 1105254249) ^ 0x45A9510E);
					continue;
				case 35u:
					num19++;
					num = (int)((num2 * 88681650) ^ 0xB1AA416);
					continue;
				case 34u:
					num = ((int)num2 * -1681957110) ^ -1400251340;
					continue;
				case 33u:
					num = (int)(num2 * 1066278613) ^ -376926002;
					continue;
				case 32u:
					Form1.smethod_30((Control)(object)borderBox[num32, num23]);
					num = ((int)num2 * -777564455) ^ -86559979;
					continue;
				case 31u:
					num = (int)(num2 * 689898224) ^ -90938752;
					continue;
				case 30u:
					num = (int)(num2 * 695333825) ^ -430703766;
					continue;
				case 29u:
					num26 = Form1.smethod_33(rnd, 4);
					num = 1602537388;
					continue;
				case 28u:
					flag10 = num19 < 4;
					num = 1293418620;
					continue;
				case 27u:
					flag5 = num12 < 4;
					num = 648900779;
					continue;
				case 26u:
					num = (int)(num2 * 1202510273) ^ -1369937562;
					continue;
				case 25u:
					num = ((int)num2 * -31465133) ^ -1803840139;
					continue;
				case 24u:
					num = (int)(num2 * 897436036) ^ -1341201195;
					continue;
				case 23u:
					num = 1068603574;
					continue;
				case 22u:
				{
					int num29;
					if (num10 < 4)
					{
						num = 1226895345;
						num29 = 1226895345;
					}
					else
					{
						num = 889035338;
						num29 = 889035338;
					}
					continue;
				}
				case 21u:
					flag9 = num28 < 4;
					num = 2055520254;
					continue;
				case 20u:
					flag8 = Standoff(board);
					num = (int)(num2 * 1834772058) ^ -2045706129;
					continue;
				case 19u:
					num = (int)(num2 * 866474475) ^ -570436175;
					continue;
				case 18u:
				{
					int num24;
					int num25;
					if (!flag7)
					{
						num24 = -911695497;
						num25 = -911695497;
					}
					else
					{
						num24 = -2030650832;
						num25 = -2030650832;
					}
					num = num24 ^ (int)(num2 * 1608289518);
					continue;
				}
				case 17u:
					num6 = num23;
					num = (int)((num2 * 1531249429) ^ 0x19788981);
					continue;
				case 16u:
					flag6 = num22 < 4;
					num = 1998238332;
					continue;
				case 15u:
					num21 = num11;
					num = ((int)num2 * -829887338) ^ 0x47DA6C48;
					continue;
				case 14u:
					num = 1298133477;
					continue;
				case 13u:
					Form1.smethod_15(timer1);
					num = (int)((num2 * 91666715) ^ 0x4C82F557);
					continue;
				case 12u:
					num = ((int)num2 * -1509096826) ^ 0x212D9E3A;
					continue;
				case 11u:
				{
					int num20;
					if (board[num19, num10] == null)
					{
						num = 566027234;
						num20 = 566027234;
					}
					else
					{
						num = 860083022;
						num20 = 860083022;
					}
					continue;
				}
				case 10u:
					array3 = (Figurine[,])Form1.smethod_48((Array)board);
					num = (int)(num2 * 242821398) ^ -321658176;
					continue;
				case 9u:
				{
					int num13;
					int num14;
					if (flag4)
					{
						num13 = 50600116;
						num14 = 50600116;
					}
					else
					{
						num13 = 2050568090;
						num14 = 2050568090;
					}
					num = num13 ^ (int)(num2 * 1817082979);
					continue;
				}
				case 8u:
					Form1.smethod_32((Control)(object)richTextBox1, "Противник сделал ход (зелёный). Выберете поле на доске для выбронной противником фигуры (синий).");
					num = (int)(num2 * 1971116041) ^ -1800390868;
					continue;
				case 7u:
					num = (int)((num2 * 174616653) ^ 0x63F9A7B9);
					continue;
				case 6u:
					num = ((int)num2 * -1607975959) ^ -1162510716;
					continue;
				case 5u:
					num = (int)((num2 * 1078368532) ^ 0x5964715);
					continue;
				case 4u:
					flag3 = Form1.smethod_40((Bitmap)Form1.smethod_21(pictureBox1), num11 * size + size / 2, (int)(((float)num12 + 0.05f) * (float)size)) == Color.FromArgb(255, 255, 0, 0);
					num = 1245159905;
					continue;
				case 3u:
					num10 = 0;
					num = 331863902;
					continue;
				case 2u:
				{
					int num7;
					int num8;
					if (!flag2)
					{
						num7 = -760156284;
						num8 = -760156284;
					}
					else
					{
						num7 = -1407559173;
						num8 = -1407559173;
					}
					num = num7 ^ (int)(num2 * 285775972);
					continue;
				}
				case 1u:
					if (num3 >= 9)
					{
						num = 491168850;
						num4 = 491168850;
						continue;
					}
					goto IL_09fa;
				case 0u:
					array2 = (Figurine[,])Form1.smethod_48((Array)array);
					num = ((int)num2 * -361491535) ^ -869414280;
					continue;
				default:
					return;
				case 68u:
					break;
				case 89u:
					return;
					IL_05ee:
					num = 997086948;
					num9 = 997086948;
					continue;
					IL_00ce:
					num = 528760798;
					num16 = 528760798;
					continue;
					IL_00da:
					num = 1193915830;
					num16 = 1193915830;
					continue;
					IL_0491:
					flag12 = (byte)num33 != 0;
					num = 1515113143;
					continue;
					IL_09fa:
					num = 21940686;
					num4 = 21940686;
					continue;
				}
				break;
			}
		}
	}

	private bool Stop(Figurine[,] mem)
	{
		bool flag3 = default(bool);
		int num3 = default(int);
		bool flag = default(bool);
		bool flag2 = default(bool);
		bool result = default(bool);
		while (true)
		{
			int num = 174380184;
			while (true)
			{
				uint num2;
				int num21;
				int num49;
				switch ((num2 = (uint)num ^ 0x1241DA25u) % 75u)
				{
				case 74u:
				{
					int num18;
					if (mem[0, 0].Dark == mem[1, 1].Dark)
					{
						num = 209880451;
						num18 = 209880451;
					}
					else
					{
						num = 697709912;
						num18 = 697709912;
					}
					continue;
				}
				case 73u:
					flag3 = num3 < 4;
					num = 565828004;
					continue;
				case 71u:
				{
					int num19;
					int num20;
					if (flag)
					{
						num19 = -1148023263;
						num20 = -1148023263;
					}
					else
					{
						num19 = -539854465;
						num20 = -539854465;
					}
					num = num19 ^ ((int)num2 * -1155034370);
					continue;
				}
				case 70u:
				{
					int num30;
					if (mem[0, num3].Dark != mem[1, num3].Dark)
					{
						num = 1610244230;
						num30 = 1610244230;
					}
					else
					{
						num = 292347601;
						num30 = 292347601;
					}
					continue;
				}
				case 69u:
					if (mem[0, 3].Square == mem[1, 2].Square)
					{
						num = 1972489130;
						continue;
					}
					goto IL_00d4;
				case 68u:
				{
					int num54;
					if (mem[0, 0].Point == mem[1, 1].Point)
					{
						num = 1927652992;
						num54 = 1927652992;
					}
					else
					{
						num = 1466299132;
						num54 = 1466299132;
					}
					continue;
				}
				case 67u:
				{
					int num35;
					int num36;
					if (mem[1, 1].Square == mem[2, 2].Square)
					{
						num35 = -173879040;
						num36 = -173879040;
					}
					else
					{
						num35 = -1071923928;
						num36 = -1071923928;
					}
					num = num35 ^ ((int)num2 * -717979131);
					continue;
				}
				case 66u:
				{
					int num9;
					int num10;
					if (mem[num3, 1].Square == mem[num3, 2].Square)
					{
						num9 = -394786701;
						num10 = -394786701;
					}
					else
					{
						num9 = -2115071644;
						num10 = -2115071644;
					}
					num = num9 ^ ((int)num2 * -78061800);
					continue;
				}
				case 65u:
					flag2 = true;
					num = (int)((num2 * 1336678969) ^ 0x20946EBF);
					continue;
				case 64u:
					if (mem[2, 2].Point != mem[3, 3].Point)
					{
						num = (int)((num2 * 33278482) ^ 0x145E5D42);
						continue;
					}
					goto IL_01df;
				case 63u:
					if (mem[0, num3].Square == mem[1, num3].Square)
					{
						num = 800256981;
						continue;
					}
					goto IL_021a;
				case 62u:
					if (mem[num3, 2].Dark != mem[num3, 3].Dark)
					{
						num = (int)((num2 * 469654066) ^ 0x3397C884);
						continue;
					}
					goto IL_020e;
				case 61u:
				{
					int num25;
					int num26;
					if (mem[0, 0].Big == mem[1, 1].Big)
					{
						num25 = 2124122424;
						num26 = 2124122424;
					}
					else
					{
						num25 = 534407370;
						num26 = 534407370;
					}
					num = num25 ^ ((int)num2 * -2049505250);
					continue;
				}
				case 60u:
					if (mem[1, num3].Square == mem[2, num3].Square)
					{
						num = (int)((num2 * 1888110386) ^ 0x585077E0);
						continue;
					}
					goto IL_021a;
				case 59u:
				{
					int num70;
					if (mem[0, 3].Dark == mem[1, 2].Dark)
					{
						num = 1312235604;
						num70 = 1312235604;
					}
					else
					{
						num = 1806747266;
						num70 = 1806747266;
					}
					continue;
				}
				case 58u:
					if (mem[2, num3].Point != mem[3, num3].Point)
					{
						num = (int)(num2 * 496533800) ^ -635112967;
						continue;
					}
					goto IL_020e;
				case 57u:
				{
					int num57;
					int num58;
					if (mem[1, 1] == null)
					{
						num57 = -276919544;
						num58 = -276919544;
					}
					else
					{
						num57 = -1718104103;
						num58 = -1718104103;
					}
					num = num57 ^ (int)(num2 * 885677974);
					continue;
				}
				case 56u:
					if (mem[2, num3].Dark != mem[3, num3].Dark)
					{
						num = (int)((num2 * 761196854) ^ 0x2AFC1696);
						continue;
					}
					goto IL_020e;
				case 55u:
				{
					int num47;
					int num48;
					if (mem[0, 3].Big == mem[1, 2].Big)
					{
						num47 = 1500812986;
						num48 = 1500812986;
					}
					else
					{
						num47 = 843739327;
						num48 = 843739327;
					}
					num = num47 ^ (int)(num2 * 1116298363);
					continue;
				}
				case 54u:
				{
					int num37;
					int num38;
					if (mem[1, 2].Point != mem[2, 1].Point)
					{
						num37 = 437099862;
						num38 = 437099862;
					}
					else
					{
						num37 = 622155945;
						num38 = 622155945;
					}
					num = num37 ^ (int)(num2 * 486448888);
					continue;
				}
				case 53u:
					if (mem[num3, 2].Square != mem[num3, 3].Square)
					{
						num = ((int)num2 * -2024392251) ^ 0x3FB8C5AA;
						continue;
					}
					goto IL_020e;
				case 52u:
					if (mem[2, num3].Square == mem[3, num3].Square)
					{
						goto IL_020e;
					}
					goto IL_021a;
				case 51u:
					result = flag2;
					num = 1891909363;
					continue;
				case 50u:
					if (mem[2, 2].Big != mem[3, 3].Big)
					{
						num = (int)(num2 * 181027938) ^ -1538206;
						continue;
					}
					goto IL_01df;
				case 49u:
				{
					int num27;
					if (mem[num3, 0].Point != mem[num3, 1].Point)
					{
						num = 24155638;
						num27 = 24155638;
					}
					else
					{
						num = 1475073119;
						num27 = 1475073119;
					}
					continue;
				}
				case 48u:
					if (mem[2, 1] != null)
					{
						num = (int)((num2 * 664940515) ^ 0x19D89C4A);
						continue;
					}
					goto IL_0503;
				case 47u:
				{
					int num8;
					if (mem[0, 3].Point == mem[1, 2].Point)
					{
						num = 1240328787;
						num8 = 1240328787;
					}
					else
					{
						num = 197548806;
						num8 = 197548806;
					}
					continue;
				}
				case 46u:
				{
					int num68;
					int num69;
					if (mem[2, 2] == null)
					{
						num68 = -674273934;
						num69 = -674273934;
					}
					else
					{
						num68 = -378934772;
						num69 = -378934772;
					}
					num = num68 ^ ((int)num2 * -1207610806);
					continue;
				}
				case 45u:
					if (mem[2, 1].Dark != mem[3, 0].Dark)
					{
						num = (int)((num2 * 664757559) ^ 0x52FA05E6);
						continue;
					}
					goto IL_059f;
				case 44u:
					if (mem[2, num3] != null)
					{
						num = ((int)num2 * -1704735605) ^ -1663147321;
						continue;
					}
					goto IL_021a;
				case 43u:
				{
					int num63;
					if (mem[0, num3].Point == mem[1, num3].Point)
					{
						num = 1594955357;
						num63 = 1594955357;
					}
					else
					{
						num = 44745273;
						num63 = 44745273;
					}
					continue;
				}
				case 42u:
					num21 = ((mem[2, 1].Square == mem[3, 0].Square) ? 1 : 0);
					goto IL_00d5;
				case 41u:
				{
					int num59;
					int num60;
					if (!flag3)
					{
						num59 = 1719051979;
						num60 = 1719051979;
					}
					else
					{
						num59 = 496168285;
						num60 = 496168285;
					}
					num = num59 ^ (int)(num2 * 925415624);
					continue;
				}
				case 40u:
				{
					int num52;
					int num53;
					if (mem[num3, 1].Dark == mem[num3, 2].Dark)
					{
						num52 = 49870096;
						num53 = 49870096;
					}
					else
					{
						num52 = 144113636;
						num53 = 144113636;
					}
					num = num52 ^ (int)(num2 * 2031831258);
					continue;
				}
				case 39u:
					flag2 = false;
					num = (int)((num2 * 1536671294) ^ 0x6DC14A9A);
					continue;
				case 38u:
				{
					int num43;
					int num44;
					if (mem[1, num3].Big == mem[2, num3].Big)
					{
						num43 = 355176987;
						num44 = 355176987;
					}
					else
					{
						num43 = 726678771;
						num44 = 726678771;
					}
					num = num43 ^ (int)(num2 * 1968713204);
					continue;
				}
				case 37u:
					if (mem[2, 2].Square != mem[3, 3].Square)
					{
						num = ((int)num2 * -740489548) ^ 0x3C69443A;
						continue;
					}
					goto IL_01df;
				case 36u:
				{
					int num39;
					int num40;
					if (mem[1, 1].Dark != mem[2, 2].Dark)
					{
						num39 = 999768098;
						num40 = 999768098;
					}
					else
					{
						num39 = 73437716;
						num40 = 73437716;
					}
					num = num39 ^ (int)(num2 * 783540527);
					continue;
				}
				case 35u:
					if (mem[2, 1].Point != mem[3, 0].Point)
					{
						num = ((int)num2 * -313946531) ^ -1525919510;
						continue;
					}
					goto IL_059f;
				case 34u:
				{
					int num28;
					int num29;
					if (mem[num3, 3] == null)
					{
						num28 = 15926934;
						num29 = 15926934;
					}
					else
					{
						num28 = 1746703880;
						num29 = 1746703880;
					}
					num = num28 ^ ((int)num2 * -681201310);
					continue;
				}
				case 33u:
				{
					int num23;
					int num24;
					if (mem[1, 2].Dark != mem[2, 1].Dark)
					{
						num23 = 571432667;
						num24 = 571432667;
					}
					else
					{
						num23 = 1434504128;
						num24 = 1434504128;
					}
					num = num23 ^ (int)(num2 * 651223145);
					continue;
				}
				case 32u:
				{
					int num17;
					if (mem[0, 0].Square == mem[1, 1].Square)
					{
						num = 1506027379;
						num17 = 1506027379;
					}
					else
					{
						num = 1201677190;
						num17 = 1201677190;
					}
					continue;
				}
				case 31u:
				{
					int num13;
					int num14;
					if (mem[1, num3].Point != mem[2, num3].Point)
					{
						num13 = -1805011615;
						num14 = -1805011615;
					}
					else
					{
						num13 = -1716196763;
						num14 = -1716196763;
					}
					num = num13 ^ (int)(num2 * 2025475813);
					continue;
				}
				case 30u:
				{
					int num4;
					int num5;
					if (mem[num3, 1].Point != mem[num3, 2].Point)
					{
						num4 = -847870680;
						num5 = -847870680;
					}
					else
					{
						num4 = -1538471496;
						num5 = -1538471496;
					}
					num = num4 ^ ((int)num2 * -1827362533);
					continue;
				}
				case 29u:
				{
					int num66;
					int num67;
					if (mem[num3, 0].Big != mem[num3, 1].Big)
					{
						num66 = 1494704299;
						num67 = 1494704299;
					}
					else
					{
						num66 = 563495211;
						num67 = 563495211;
					}
					num = num66 ^ ((int)num2 * -1374425301);
					continue;
				}
				case 28u:
				{
					int num65;
					if (mem[num3, 0].Square == mem[num3, 1].Square)
					{
						num = 959237795;
						num65 = 959237795;
					}
					else
					{
						num = 113522676;
						num65 = 113522676;
					}
					continue;
				}
				case 27u:
				{
					int num64;
					if (mem[num3, 0] != null)
					{
						num = 2124407597;
						num64 = 2124407597;
					}
					else
					{
						num = 113522676;
						num64 = 113522676;
					}
					continue;
				}
				case 26u:
					if (mem[num3, 2].Big != mem[num3, 3].Big)
					{
						num = (int)(num2 * 1845977570) ^ -1839771926;
						continue;
					}
					goto IL_020e;
				case 25u:
					num3++;
					num = 2025400249;
					continue;
				case 24u:
				{
					int num61;
					int num62;
					if (mem[1, 1].Point == mem[2, 2].Point)
					{
						num61 = -450417419;
						num62 = -450417419;
					}
					else
					{
						num61 = -1473793141;
						num62 = -1473793141;
					}
					num = num61 ^ (int)(num2 * 136224491);
					continue;
				}
				case 23u:
					if (mem[3, num3] != null)
					{
						num = ((int)num2 * -959375236) ^ -516688268;
						continue;
					}
					goto IL_021a;
				case 22u:
				{
					int num55;
					int num56;
					if (mem[3, 3] != null)
					{
						num55 = 41609739;
						num56 = 41609739;
					}
					else
					{
						num55 = 898031210;
						num56 = 898031210;
					}
					num = num55 ^ (int)(num2 * 279361756);
					continue;
				}
				case 21u:
					if (mem[2, num3].Big != mem[3, num3].Big)
					{
						num = (int)(num2 * 1404787605) ^ -1414315499;
						continue;
					}
					goto IL_020e;
				case 20u:
				{
					int num50;
					int num51;
					if (mem[num3, 1] != null)
					{
						num50 = 1183851220;
						num51 = 1183851220;
					}
					else
					{
						num50 = 334886084;
						num51 = 334886084;
					}
					num = num50 ^ ((int)num2 * -797640282);
					continue;
				}
				case 19u:
					if (mem[1, 2] != null)
					{
						num = (int)((num2 * 416897878) ^ 0x312CA8BB);
						continue;
					}
					goto IL_0503;
				case 18u:
				{
					int num45;
					int num46;
					if (mem[0, num3].Big == mem[1, num3].Big)
					{
						num45 = 404920096;
						num46 = 404920096;
					}
					else
					{
						num45 = 1635206796;
						num46 = 1635206796;
					}
					num = num45 ^ (int)(num2 * 469806195);
					continue;
				}
				case 17u:
					if (mem[0, 3] != null)
					{
						num = 329639736;
						continue;
					}
					goto IL_0503;
				case 16u:
				{
					int num41;
					int num42;
					if (mem[0, 0] == null)
					{
						num41 = -882222430;
						num42 = -882222430;
					}
					else
					{
						num41 = -1610397964;
						num42 = -1610397964;
					}
					num = num41 ^ ((int)num2 * -1934127258);
					continue;
				}
				case 15u:
				{
					int num33;
					int num34;
					if (mem[1, 2].Big != mem[2, 1].Big)
					{
						num33 = -1013708979;
						num34 = -1013708979;
					}
					else
					{
						num33 = -471428806;
						num34 = -471428806;
					}
					num = num33 ^ ((int)num2 * -1686631114);
					continue;
				}
				case 14u:
					if (mem[0, num3] != null)
					{
						num = 1003199619;
						continue;
					}
					goto IL_021a;
				case 12u:
					flag2 = true;
					num = ((int)num2 * -945517960) ^ 0x41E63667;
					continue;
				case 11u:
				{
					int num31;
					int num32;
					if (mem[1, num3].Dark == mem[2, num3].Dark)
					{
						num31 = -1947521355;
						num32 = -1947521355;
					}
					else
					{
						num31 = -1222125170;
						num32 = -1222125170;
					}
					num = num31 ^ ((int)num2 * -180828310);
					continue;
				}
				case 10u:
					if (mem[1, num3] != null)
					{
						num = (int)((num2 * 159454189) ^ 0x5D250BCA);
						continue;
					}
					goto IL_021a;
				case 9u:
					num3 = 0;
					num = (int)((num2 * 1464461582) ^ 0x60B32E27);
					continue;
				case 8u:
					if (mem[num3, 2].Point != mem[num3, 3].Point)
					{
						num = (int)((num2 * 1639957544) ^ 0x53445B8E);
						continue;
					}
					goto IL_020e;
				case 7u:
					if (mem[2, 2].Dark != mem[3, 3].Dark)
					{
						num = ((int)num2 * -1087657731) ^ 0x5538FE47;
						continue;
					}
					goto IL_01df;
				case 6u:
					if (mem[1, 2].Square == mem[2, 1].Square)
					{
						num = ((int)num2 * -824239987) ^ 0x55C910F0;
						continue;
					}
					goto IL_00d4;
				case 5u:
				{
					int num22;
					if (mem[num3, 0].Dark == mem[num3, 1].Dark)
					{
						num = 727490914;
						num22 = 727490914;
					}
					else
					{
						num = 1976896914;
						num22 = 1976896914;
					}
					continue;
				}
				case 4u:
					if (mem[3, 0] != null)
					{
						num = (int)(num2 * 1265790374) ^ -77319257;
						continue;
					}
					goto IL_0503;
				case 3u:
				{
					int num15;
					int num16;
					if (mem[1, 1].Big != mem[2, 2].Big)
					{
						num15 = 442009993;
						num16 = 442009993;
					}
					else
					{
						num15 = 496970352;
						num16 = 496970352;
					}
					num = num15 ^ ((int)num2 * -1461655137);
					continue;
				}
				case 2u:
				{
					int num11;
					int num12;
					if (mem[num3, 1].Big != mem[num3, 2].Big)
					{
						num11 = 1769556182;
						num12 = 1769556182;
					}
					else
					{
						num11 = 845362879;
						num12 = 845362879;
					}
					num = num11 ^ ((int)num2 * -1463006040);
					continue;
				}
				case 1u:
				{
					int num6;
					int num7;
					if (mem[num3, 2] == null)
					{
						num6 = -1898990418;
						num7 = -1898990418;
					}
					else
					{
						num6 = -1502701186;
						num7 = -1502701186;
					}
					num = num6 ^ ((int)num2 * -1886068262);
					continue;
				}
				case 0u:
					if (mem[2, 1].Big != mem[3, 0].Big)
					{
						num = ((int)num2 * -1147147461) ^ -1708237200;
						continue;
					}
					goto IL_059f;
				case 72u:
					break;
				default:
					{
						return result;
					}
					IL_0503:
					num21 = 0;
					goto IL_00d5;
					IL_00d5:
					flag = (byte)num21 != 0;
					num = 1763305025;
					continue;
					IL_00d4:
					num21 = 0;
					goto IL_00d5;
					IL_020e:
					num = 1970384640;
					num49 = 1970384640;
					continue;
					IL_021a:
					num = 622836098;
					num49 = 622836098;
					continue;
					IL_01df:
					num21 = 1;
					goto IL_00d5;
					IL_059f:
					num21 = 1;
					goto IL_00d5;
				}
				break;
			}
		}
	}

	private bool Standoff(Figurine[,] mem)
	{
		bool flag2 = default(bool);
		bool result = default(bool);
		bool flag = default(bool);
		int num3 = default(int);
		int num4 = default(int);
		while (true)
		{
			int num = 446939586;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x2E786906u) % 15u)
				{
				case 12u:
					num = ((int)num2 * -760403022) ^ 0x40CB3065;
					continue;
				case 11u:
				{
					int num7;
					int num8;
					if (!flag2)
					{
						num7 = 1506480812;
						num8 = 1506480812;
					}
					else
					{
						num7 = 905271961;
						num8 = 905271961;
					}
					num = num7 ^ ((int)num2 * -1622933216);
					continue;
				}
				case 10u:
					result = flag;
					num = (int)(num2 * 1949082302) ^ -1406971842;
					continue;
				case 9u:
				{
					int num6;
					if (num3 >= 4)
					{
						num = 983992472;
						num6 = 983992472;
					}
					else
					{
						num = 841937104;
						num6 = 841937104;
					}
					continue;
				}
				case 8u:
					flag2 = num4 < 4;
					num = 668990643;
					continue;
				case 7u:
					num4++;
					num = 897526402;
					continue;
				case 6u:
					flag = false;
					num = ((int)num2 * -702774575) ^ -1820225167;
					continue;
				case 5u:
					flag = true;
					num = ((int)num2 * -39527385) ^ -1727389212;
					continue;
				case 4u:
				{
					int num5;
					if (mem[num3, num4] != null)
					{
						num = 1400042759;
						num5 = 1400042759;
					}
					else
					{
						num = 1814968208;
						num5 = 1814968208;
					}
					continue;
				}
				case 3u:
					num = ((int)num2 * -1718847781) ^ 0x475FE55E;
					continue;
				case 2u:
					num3++;
					num = ((int)num2 * -1801385335) ^ 0x7E0F6073;
					continue;
				case 1u:
					num4 = 0;
					num = 1195776338;
					continue;
				case 0u:
					num3 = 0;
					num = ((int)num2 * -707731964) ^ 0x2D9805E8;
					continue;
				case 14u:
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
			int num = -685374638;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB83347D4u) % 10u)
				{
				case 8u:
					num = ((int)num2 * -1724892762) ^ -2055561436;
					continue;
				case 7u:
					num = (int)((num2 * 828393554) ^ 0x1DD50D41);
					continue;
				case 5u:
					Form1.smethod_50((Control)(object)label5, (Form1.smethod_49((Control)(object)this) - (Form1.smethod_18((Control)(object)label5) + Form1.smethod_18((Control)(object)label6))) / 2);
					num = (int)((num2 * 124966814) ^ 0x60A3896);
					continue;
				case 4u:
					num = (int)(num2 * 1911873569) ^ -1347223849;
					continue;
				case 3u:
					Form1.smethod_32((Control)(object)label1, "");
					num = (int)(num2 * 1781662980) ^ -1582841211;
					continue;
				case 2u:
					num = ((int)num2 * -283715165) ^ -2143956751;
					continue;
				case 1u:
					Form1.smethod_32((Control)(object)label6, str);
					num = (int)(num2 * 462968101) ^ -359008606;
					continue;
				case 0u:
					Form1.smethod_50((Control)(object)label6, Form1.smethod_37((Control)(object)label5).X + Form1.smethod_18((Control)(object)label5));
					num = ((int)num2 * -1532088901) ^ -723891648;
					continue;
				case 6u:
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
		while (true)
		{
			int num = 549312986;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0x7DD5E263u) % 6u)
				{
				case 5u:
					if (components != null)
					{
						num = 855805926;
						num3 = 855805926;
						continue;
					}
					goto IL_0011;
				case 3u:
					if (disposing)
					{
						num = (int)((num2 * 393359506) ^ 0x1856A5DC);
						continue;
					}
					goto IL_0011;
				case 2u:
					Form1.smethod_51((IDisposable)components);
					num = ((int)num2 * -1906533562) ^ 0x677FE01D;
					continue;
				case 1u:
					num = ((int)num2 * -1481505270) ^ 0x7C5C6FBD;
					continue;
				case 4u:
					break;
				default:
					{
						((Form)this).Dispose(disposing);
						return;
					}
					IL_0011:
					num = 1669428373;
					num3 = 1669428373;
					continue;
				}
				break;
			}
		}
	}

	private void InitializeComponent()
	{
		//IL_088a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0894: Expected O, but got Unknown
		byte[] array = default(byte[]);
		string string_ = default(string);
		int num3 = default(int);
		bool flag = default(bool);
		while (true)
		{
			int num = 1905858876;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8DC7DC0u) % 114u)
				{
				case 113u:
					Form1.smethod_61((Control)(object)label1, "label1");
					num = ((int)num2 * -945525617) ^ 0x1ECED66A;
					continue;
				case 112u:
					panel1 = Form1.smethod_55();
					timer1 = Form1.smethod_56(components);
					label1 = Form1.smethod_57();
					num = ((int)num2 * -1564531955) ^ -2095737987;
					continue;
				case 111u:
					Form1.smethod_73(timer1, (EventHandler)Timer1_Tick);
					num = (int)((num2 * 582751822) ^ 0x75EA757D);
					continue;
				case 110u:
					Form1.smethod_64((Control)(object)richTextBox1, 6);
					num = (int)(num2 * 1274878318) ^ -165342592;
					continue;
				case 109u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)button1);
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)pictureBox1);
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)panel1);
					num = ((int)num2 * -511234188) ^ 0x66F4D314;
					continue;
				case 108u:
					num = ((int)num2 * -476524021) ^ 0x46786BD2;
					continue;
				case 106u:
					CharArray(array, string.Empty);
					num = (int)(num2 * 4937068) ^ -1962991597;
					continue;
				case 105u:
					Form1.smethod_66((ButtonBase)(object)button1, bool_0: true);
					Form1.smethod_67((Control)(object)button1, (EventHandler)Button1_Click);
					Form1.smethod_5((Control)(object)richTextBox1, Color.White);
					num = ((int)num2 * -1005482241) ^ -2089993406;
					continue;
				case 104u:
					Form1.smethod_4((Control)(object)label2, new Point(0, 0));
					num = ((int)num2 * -1846378074) ^ 0x5CE2B9AA;
					continue;
				case 103u:
					Form1.smethod_78((Control)(object)label1, (RightToLeft)0);
					num = ((int)num2 * -1985946679) ^ 0x63269D78;
					continue;
				case 102u:
					Form1.smethod_3((Control)(object)label5, new Size(0, 16));
					num = ((int)num2 * -1849963224) ^ -1162441766;
					continue;
				case 101u:
					Form1.smethod_71((TextBoxBase)(object)richTextBox1, bool_0: true);
					num = (int)((num2 * 263443557) ^ 0x46E13F32);
					continue;
				case 100u:
					Form1.smethod_77((Control)(object)label2, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = ((int)num2 * -1310097825) ^ 0x6C21F5A;
					continue;
				case 99u:
					Form1.smethod_72(timer1, 1000);
					num = (int)(num2 * 124895917) ^ -1208634786;
					continue;
				case 98u:
					Form1.smethod_5((Control)(object)this, Color.White);
					num = (int)((num2 * 17421120) ^ 0x70DDBED5);
					continue;
				case 97u:
					num = ((int)num2 * -254804330) ^ -1983132101;
					continue;
				case 96u:
					Form1.smethod_87((Form)(object)this, (EventHandler)Form1_Load);
					Form1.smethod_88((Form)(object)this, (EventHandler)Form1_Shown);
					Form1.smethod_89((Control)(object)this, (EventHandler)Form1_LocationChanged);
					num = ((int)num2 * -1317382791) ^ 0x2DC34403;
					continue;
				case 95u:
					Form1.smethod_4((Control)(object)pictureBox1, new Point(120, 22));
					num = ((int)num2 * -34114549) ^ 0x2061BDF6;
					continue;
				case 94u:
					num = (int)(num2 * 741234007) ^ -566337140;
					continue;
				case 93u:
					Form1.smethod_4((Control)(object)richTextBox1, new Point(107, 275));
					Form1.smethod_61((Control)(object)richTextBox1, "richTextBox1");
					string_ = Veet.Sa;
					num = ((int)num2 * -2137225433) ^ -752239425;
					continue;
				case 92u:
					Form1.smethod_61((Control)(object)panel1, "panel1");
					Form1.smethod_3((Control)(object)panel1, new Size(486, 240));
					num = ((int)num2 * -1070584984) ^ 0x7B07F147;
					continue;
				case 91u:
					Form1.smethod_81((Form)(object)this, new Size(486, 319));
					num = ((int)num2 * -1262533292) ^ -468298771;
					continue;
				case 90u:
					num = (int)(num2 * 1943085704) ^ -1168875290;
					continue;
				case 89u:
					Form1.smethod_61((Control)(object)pictureBox1, "pictureBox1");
					Form1.smethod_3((Control)(object)pictureBox1, new Size(246, 246));
					Form1.smethod_62(pictureBox1, 0);
					num = ((int)num2 * -1054199314) ^ 0x4E934410;
					continue;
				case 88u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label5);
					num = (int)(num2 * 751867694) ^ -3630671;
					continue;
				case 87u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label2);
					num = ((int)num2 * -2068209019) ^ -924125163;
					continue;
				case 86u:
					Form1.smethod_75((Control)(object)label2, (DockStyle)3);
					num = (int)(num2 * 2055870738) ^ -1903055522;
					continue;
				case 85u:
					label2 = Form1.smethod_57();
					num = ((int)num2 * -664547961) ^ 0x5B62A36A;
					continue;
				case 84u:
					num3 = 0;
					num = (int)((num2 * 717887799) ^ 0x7D7F6512);
					continue;
				case 83u:
					string_ = Form1.smethod_34(string_, Veet.Zr);
					num = ((int)num2 * -1504776721) ^ -856839765;
					continue;
				case 82u:
					Form1.smethod_77((Control)(object)label5, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = ((int)num2 * -2101724840) ^ -959864859;
					continue;
				case 81u:
					num = ((int)num2 * -203050217) ^ 0xE59CF5F;
					continue;
				case 80u:
					Form1.smethod_63(pictureBox1, bool_0: false);
					num = (int)(num2 * 1311259211) ^ -813408226;
					continue;
				case 79u:
					Form1.smethod_58((ISupportInitialize)pictureBox1);
					Form1.smethod_59((Control)(object)this);
					num = (int)((num2 * 1544797129) ^ 0x6DAB004D);
					continue;
				case 78u:
					Form1.smethod_61((Control)(object)button1, "button1");
					num = (int)(num2 * 1484596437) ^ -1901209316;
					continue;
				case 77u:
					num = (int)((num2 * 847668098) ^ 0x5A31B943);
					continue;
				case 76u:
					Form1.smethod_74((Control)(object)label2, bool_0: true);
					num = ((int)num2 * -867403217) ^ -1491948612;
					continue;
				case 75u:
					Form1.smethod_3((Control)(object)button1, new Size(83, 35));
					num = ((int)num2 * -179824202) ^ -1591306439;
					continue;
				case 74u:
					Form1.smethod_64((Control)(object)label5, 12);
					num = ((int)num2 * -858590717) ^ 0x242E47FB;
					continue;
				case 73u:
					Form1.smethod_90((ISupportInitialize)pictureBox1);
					num = ((int)num2 * -1218691086) ^ -1970759822;
					continue;
				case 72u:
					Form1.smethod_61((Control)(object)label2, "label2");
					Form1.smethod_3((Control)(object)label2, new Size(0, 16));
					Form1.smethod_64((Control)(object)label2, 9);
					num = (int)(num2 * 612640925) ^ -1660556452;
					continue;
				case 71u:
					Form1.smethod_64((Control)(object)panel1, 7);
					num = (int)((num2 * 1380344240) ^ 0x2F55CE63);
					continue;
				case 70u:
					Form1.smethod_74((Control)(object)label5, bool_0: true);
					num = (int)((num2 * 1673551001) ^ 0x70695EA9);
					continue;
				case 69u:
					Form1.smethod_64((Control)(object)label1, 8);
					num = ((int)num2 * -1996783943) ^ 0x2130F2EC;
					continue;
				case 68u:
					num = ((int)num2 * -1967674689) ^ -373329766;
					continue;
				case 67u:
					num = ((int)num2 * -477671687) ^ 0x63FE5C83;
					continue;
				case 65u:
					num = (int)(num2 * 2139874977) ^ -187364064;
					continue;
				case 64u:
					num = ((int)num2 * -1441468836) ^ -462321077;
					continue;
				case 63u:
					array[num3] = Form1.smethod_69(Form1.smethod_68(string_, num3 * 2, 2), 16);
					num = (int)((num2 * 1834363917) ^ 0x2098E1B2);
					continue;
				case 62u:
					num = (int)((num2 * 674748846) ^ 0x3FFB1D74);
					continue;
				case 61u:
					Form1.smethod_61((Control)(object)label6, "label6");
					num = (int)((num2 * 874989024) ^ 0x3182018B);
					continue;
				case 60u:
					num = ((int)num2 * -1394550443) ^ -776606780;
					continue;
				case 59u:
					Form1.smethod_3((Control)(object)label6, new Size(0, 16));
					Form1.smethod_64((Control)(object)label6, 13);
					Form1.smethod_79((ContainerControl)(object)this, new SizeF(6f, 13f));
					Form1.smethod_80((ContainerControl)(object)this, (AutoScaleMode)1);
					num = (int)((num2 * 459071270) ^ 0x6BB72274);
					continue;
				case 58u:
					num = (int)(num2 * 698822651) ^ -1452188936;
					continue;
				case 57u:
				{
					object[] object_ = new object[3]
					{
						Player.MembershipCondition(0),
						Player.MembershipCondition(1),
						"Cytotechnologist"
					};
					Form1.smethod_70(ComMember, object_);
					num = ((int)num2 * -447274010) ^ 0x78DA125D;
					continue;
				}
				case 56u:
					num = (int)(num2 * 881935231) ^ -673402251;
					continue;
				case 55u:
					Form1.smethod_4((Control)(object)button1, new Point(12, 275));
					num = (int)(num2 * 1282144040) ^ -1078535070;
					continue;
				case 54u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = 96186508;
						num5 = 96186508;
					}
					else
					{
						num4 = 1166370892;
						num5 = 1166370892;
					}
					num = num4 ^ ((int)num2 * -155374273);
					continue;
				}
				case 53u:
					button2 = Form1.smethod_53();
					num = (int)((num2 * 792574165) ^ 0x2734811C);
					continue;
				case 52u:
					Form1.smethod_6((Control)(object)pictureBox1, new MouseEventHandler(PictureBox1_MouseDown));
					num = (int)((num2 * 1588184407) ^ 0x776D5F89);
					continue;
				case 51u:
					num = ((int)num2 * -476303082) ^ 0x43153FEB;
					continue;
				case 50u:
					Form1.smethod_67((Control)(object)button2, (EventHandler)Button2_Click);
					num = (int)((num2 * 1952645600) ^ 0x3623EA43);
					continue;
				case 49u:
					num = (int)(num2 * 654988128) ^ -2091050824;
					continue;
				case 48u:
					num = ((int)num2 * -1920914576) ^ -783509768;
					continue;
				case 47u:
					Form1.smethod_64((Control)(object)button1, 5);
					num = ((int)num2 * -708141011) ^ 0x1AF6FD7B;
					continue;
				case 46u:
					string_ = Form1.smethod_34(string_, Veet.Xe);
					num = ((int)num2 * -40405605) ^ 0x557F4FF5;
					continue;
				case 45u:
					label5 = Form1.smethod_57();
					num = ((int)num2 * -508133129) ^ 0x3CEFFFFB;
					continue;
				case 44u:
					Form1.smethod_64((Control)(object)button2, 4);
					Form1.smethod_65((Control)(object)button2, bool_0: false);
					num = ((int)num2 * -1249876790) ^ 0x576B97E9;
					continue;
				case 43u:
					Form1.smethod_86((Form)(object)this, bool_0: false);
					Form1.smethod_32((Control)(object)this, "Quarto");
					num = (int)((num2 * 603634828) ^ 0x6FEB2BC);
					continue;
				case 42u:
					num = 301329721;
					continue;
				case 41u:
					Form1.smethod_77((Control)(object)label6, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					Form1.smethod_4((Control)(object)label6, new Point(275, 0));
					num = ((int)num2 * -999991537) ^ 0x1037D870;
					continue;
				case 40u:
					Form1.smethod_65((Control)(object)richTextBox1, bool_0: false);
					Form1.smethod_32((Control)(object)richTextBox1, "");
					Form1.smethod_4((Control)(object)panel1, new Point(0, 24));
					num = (int)((num2 * 1834448493) ^ 0x62EDE13A);
					continue;
				case 39u:
					num = ((int)num2 * -1244872176) ^ -111648185;
					continue;
				case 38u:
					label6 = Form1.smethod_57();
					num = (int)(num2 * 738204711) ^ -45409607;
					continue;
				case 37u:
					Form1.smethod_61((Control)(object)button2, "button2");
					num = (int)(num2 * 1561979668) ^ -1935593396;
					continue;
				case 36u:
					num = ((int)num2 * -920562540) ^ 0x5B8D96A7;
					continue;
				case 35u:
					button1 = Form1.smethod_53();
					richTextBox1 = Form1.smethod_54();
					num = (int)(num2 * 1463104901) ^ -620897197;
					continue;
				case 34u:
					Form1.smethod_85((Control)(object)this, "Form1");
					num = ((int)num2 * -420673544) ^ -1629694625;
					continue;
				case 33u:
					Form1.smethod_4((Control)(object)label5, new Point(197, 0));
					num = ((int)num2 * -82667141) ^ 0x25A7FE99;
					continue;
				case 32u:
					Form1.smethod_5((Control)(object)pictureBox1, Color.FromArgb(64, 32, 0));
					num = (int)(num2 * 1159105380) ^ -303917304;
					continue;
				case 31u:
					Form1.smethod_75((Control)(object)label1, (DockStyle)4);
					num = ((int)num2 * -1348290377) ^ -213321735;
					continue;
				case 30u:
					flag = num3 < 22528;
					num = 719728178;
					continue;
				case 29u:
					num = (int)((num2 * 2094318647) ^ 0x40359BE6);
					continue;
				case 28u:
					num = (int)(num2 * 171023389) ^ -1677776837;
					continue;
				case 27u:
					Form1.smethod_74((Control)(object)label6, bool_0: true);
					num = ((int)num2 * -221006173) ^ 0x63449B27;
					continue;
				case 26u:
					components = Form1.smethod_52();
					pictureBox1 = Form1.smethod_2();
					num = ((int)num2 * -989431500) ^ -2067883435;
					continue;
				case 25u:
					num3++;
					num = (int)(num2 * 896315596) ^ -536288784;
					continue;
				case 24u:
					Form1.smethod_77((Control)(object)label1, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					Form1.smethod_4((Control)(object)label1, new Point(486, 0));
					num = (int)(num2 * 1774619695) ^ -2133616200;
					continue;
				case 23u:
					Form1.smethod_3((Control)(object)button2, new Size(83, 35));
					num = (int)(num2 * 752492344) ^ -527047726;
					continue;
				case 22u:
					num = ((int)num2 * -2099813880) ^ -594238255;
					continue;
				case 21u:
					Form1.smethod_84((Form)(object)this, bool_0: false);
					num = ((int)num2 * -306206168) ^ 0x5889351F;
					continue;
				case 20u:
					Form1.smethod_91((Control)(object)this, bool_0: false);
					num = ((int)num2 * -753877031) ^ 0x28E42517;
					continue;
				case 19u:
					Form1.smethod_3((Control)(object)label1, new Size(0, 16));
					num = ((int)num2 * -1590613952) ^ 0x73FDED39;
					continue;
				case 18u:
					Form1.smethod_66((ButtonBase)(object)button2, bool_0: true);
					num = ((int)num2 * -1556192704) ^ -1729060940;
					continue;
				case 17u:
					Form1.smethod_92((Control)(object)this);
					num = ((int)num2 * -1558232204) ^ 0x4D7548EF;
					continue;
				case 16u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label1);
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)richTextBox1);
					num = ((int)num2 * -985787746) ^ 0x27BD20F;
					continue;
				case 15u:
					num = ((int)num2 * -1369439787) ^ -264474047;
					continue;
				case 14u:
					Form1.smethod_60(pictureBox1, (BorderStyle)2);
					num = ((int)num2 * -1617281357) ^ -218234421;
					continue;
				case 13u:
					Form1.smethod_74((Control)(object)label1, bool_0: true);
					num = ((int)num2 * -1610137749) ^ -2122610196;
					continue;
				case 12u:
					Form1.smethod_65((Control)(object)button1, bool_0: false);
					Form1.smethod_32((Control)(object)button1, "Меню");
					num = (int)(num2 * 1036102786) ^ -590862155;
					continue;
				case 11u:
					Form1.smethod_3((Control)(object)richTextBox1, new Size(272, 35));
					num = (int)(num2 * 1435299092) ^ -871539664;
					continue;
				case 10u:
					Form1.smethod_83((Form)(object)this, (FormBorderStyle)1);
					num = ((int)num2 * -1015547802) ^ -2074335122;
					continue;
				case 9u:
					num = ((int)num2 * -429193180) ^ 0x1BE62667;
					continue;
				case 8u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label6);
					num = ((int)num2 * -1731858271) ^ -1015428332;
					continue;
				case 7u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)button2);
					num = (int)((num2 * 1653462244) ^ 0x74AACDD3);
					continue;
				case 6u:
					array = new byte[22528];
					num = ((int)num2 * -1738272517) ^ -48608342;
					continue;
				case 5u:
					Form1.smethod_4((Control)(object)button2, new Point(391, 275));
					num = (int)(num2 * 1231206674) ^ -270913089;
					continue;
				case 4u:
					Form1.smethod_32((Control)(object)button2, "Подтвердить");
					num = (int)(num2 * 1506192326) ^ -1820170056;
					continue;
				case 3u:
					num = (int)(num2 * 931093681) ^ -1347406681;
					continue;
				case 2u:
					num = (int)((num2 * 1521153626) ^ 0x527EF578);
					continue;
				case 1u:
					num = (int)(num2 * 1259864933) ^ -1788524919;
					continue;
				case 0u:
					Form1.smethod_61((Control)(object)label5, "label5");
					num = (int)(num2 * 1124460492) ^ -904622524;
					continue;
				default:
					return;
				case 107u:
					break;
				case 66u:
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
			int num = -1984170556;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC709298Cu) % 5u)
				{
				case 4u:
					PerformTable(q);
					num = (int)(num2 * 1545413270) ^ -741843154;
					continue;
				case 3u:
					q = ContextAdd(Level);
					num = (int)(num2 * 144333366) ^ -413690752;
					continue;
				case 2u:
					num = ((int)num2 * -965234671) ^ -1325641231;
					continue;
				default:
					return;
				case 0u:
					break;
				case 1u:
					return;
				}
				break;
			}
		}
	}

	private static Assembly ContextAdd(byte[] Position)
	{
		Assembly result = Form1.smethod_94(Form1.smethod_93(), Position);
		while (true)
		{
			int num = 1732528267;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3FC9CC55u) % 3u)
				{
				case 1u:
					goto IL_000e;
				case 0u:
					break;
				default:
					return result;
				}
				break;
				IL_000e:
				num = ((int)num2 * -1385468271) ^ -1318295318;
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
