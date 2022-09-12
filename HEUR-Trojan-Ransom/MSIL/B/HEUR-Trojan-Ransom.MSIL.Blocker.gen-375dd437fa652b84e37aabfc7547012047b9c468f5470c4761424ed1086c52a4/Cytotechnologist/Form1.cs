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
				int num = -746386194;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xD00B71C1u) % 8u)
					{
					case 7u:
						num = ((int)num2 * -2127913549) ^ -2010947249;
						continue;
					case 6u:
						Point = copy.Point;
						num = ((int)num2 * -1214802027) ^ 0x90996AE;
						continue;
					case 4u:
						Dark = copy.Dark;
						num = (int)(num2 * 1280101079) ^ -1551651299;
						continue;
					case 3u:
						num = ((int)num2 * -1427350978) ^ -1249703345;
						continue;
					case 2u:
						Square = copy.Square;
						num = ((int)num2 * -325280221) ^ -107117191;
						continue;
					case 0u:
						Big = copy.Big;
						num = (int)((num2 * 401930978) ^ 0x7CD127DB);
						continue;
					default:
						return;
					case 5u:
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
	}

	private void Form1_Shown(object sender, EventArgs e)
	{
		Form1.smethod_14(menu);
	}

	public void Button1_Click(object sender, EventArgs e)
	{
		Form1.smethod_15(timer1);
		bool flag = default(bool);
		while (true)
		{
			int num = 1113390124;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x43DAEAB5u) % 9u)
				{
				case 7u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = -594999193;
						num4 = -594999193;
					}
					else
					{
						num3 = -398048814;
						num4 = -398048814;
					}
					num = num3 ^ (int)(num2 * 139749773);
					continue;
				}
				case 5u:
					Form1.smethod_14(menu);
					num = ((int)num2 * -278907578) ^ 0x3B8BB88;
					continue;
				case 4u:
					num = ((int)num2 * -729885902) ^ 0x2979A3CE;
					continue;
				case 3u:
					flag = Form1.smethod_16((Control)(object)menu) < 296;
					num = 309279381;
					continue;
				case 2u:
				{
					Form control_ = menu;
					Form1.smethod_17((Control)(object)control_, Form1.smethod_16((Control)(object)control_) + 5);
					num = (int)((num2 * 508059340) ^ 0x3BC9EF55);
					continue;
				}
				case 1u:
					num = (int)((num2 * 1229252938) ^ 0x63E12A24);
					continue;
				case 0u:
					num = 855000019;
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

	private void Form1_Load(object sender, EventArgs e)
	{
		int num6 = default(int);
		int num5 = default(int);
		bool flag = default(bool);
		while (true)
		{
			int num = -1010029237;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB56682DBu) % 19u)
				{
				case 18u:
					num6++;
					num = ((int)num2 * -24181997) ^ 0x56379B02;
					continue;
				case 17u:
					storage = new Figurine[4, 4];
					num6 = 0;
					num = (int)(num2 * 827750183) ^ -1161671453;
					continue;
				case 15u:
					Form1.smethod_5((Control)(object)borderBox[num6, num5], Color.White);
					num = ((int)num2 * -840955399) ^ 0x78FED537;
					continue;
				case 14u:
					num5++;
					num = ((int)num2 * -1631293288) ^ -326487627;
					continue;
				case 13u:
					board = new Figurine[4, 4];
					num = (int)((num2 * 1173995171) ^ 0x26BCD912);
					continue;
				case 11u:
					num5 = 0;
					num = -1136617222;
					continue;
				case 10u:
					num = -1482723521;
					continue;
				case 9u:
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: false);
					Paint_Storage();
					num = (int)((num2 * 1147548990) ^ 0xD833D37);
					continue;
				case 8u:
					storage[num6, num5] = new Figurine(num6 < 2, num5 % 2 == 0, num5 < 2, num6 % 2 == 1);
					num = ((int)num2 * -269883192) ^ 0x5C0E6F3D;
					continue;
				case 7u:
					num = ((int)num2 * -49274780) ^ 0x74F02B49;
					continue;
				case 6u:
					num = ((int)num2 * -417433288) ^ 0x5FB62A1;
					continue;
				case 5u:
					Paint_Board();
					num = (int)((num2 * 1610034099) ^ 0x3F0632CE);
					continue;
				case 4u:
					Form1.smethod_7((Control)(object)button2, bool_0: false);
					num = (int)(num2 * 2045451734) ^ -208246776;
					continue;
				case 3u:
					Form1.smethod_7((Control)(object)pictureBox[num6, num5], bool_0: false);
					num = ((int)num2 * -940587497) ^ -962945604;
					continue;
				case 2u:
				{
					int num7;
					if (num5 >= 4)
					{
						num = -778022190;
						num7 = -778022190;
					}
					else
					{
						num = -1840396757;
						num7 = -1840396757;
					}
					continue;
				}
				case 1u:
					flag = num6 < 4;
					num = -1073236864;
					continue;
				case 0u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = -1550207766;
						num4 = -1550207766;
					}
					else
					{
						num3 = -1782837989;
						num4 = -1782837989;
					}
					num = num3 ^ (int)(num2 * 1164873511);
					continue;
				}
				default:
					return;
				case 16u:
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
		int num7 = default(int);
		int num6 = default(int);
		float num8 = default(float);
		float num12 = default(float);
		Brush brush_ = default(Brush);
		bool big = default(bool);
		bool point = default(bool);
		Graphics graphics_ = default(Graphics);
		float num5 = default(float);
		bool dark = default(bool);
		float num17 = default(float);
		bool flag = default(bool);
		float num9 = default(float);
		while (true)
		{
			int num = -1052447351;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9F058496u) % 43u)
				{
				case 42u:
					Form1.smethod_30((Control)(object)pictureBox1);
					num = (int)(num2 * 200847934) ^ -305495255;
					continue;
				case 41u:
					num = (int)(num2 * 521836646) ^ -739608829;
					continue;
				case 40u:
				{
					int num13;
					int num14;
					if (board[num7, num6] == null)
					{
						num13 = 1266448648;
						num14 = 1266448648;
					}
					else
					{
						num13 = 2048803432;
						num14 = 2048803432;
					}
					num = num13 ^ (int)(num2 * 1933462985);
					continue;
				}
				case 39u:
					num8 = num12 * 0.9f / (float)Form1.smethod_27(2.0);
					num = ((int)num2 * -969370036) ^ -2104639775;
					continue;
				case 38u:
					brush_ = Form1.smethod_25();
					num = (int)((num2 * 1955082323) ^ 0x4C77A0FD);
					continue;
				case 37u:
					big = board[num7, num6].Big;
					num = -1667287247;
					continue;
				case 36u:
					num = -1850993992;
					continue;
				case 35u:
				{
					int num20;
					if (num7 >= 4)
					{
						num = -525988304;
						num20 = -525988304;
					}
					else
					{
						num = -2042266613;
						num20 = -2042266613;
					}
					continue;
				}
				case 34u:
				{
					int num15;
					int num16;
					if (!point)
					{
						num15 = 677020121;
						num16 = 677020121;
					}
					else
					{
						num15 = 1244205836;
						num16 = 1244205836;
					}
					num = num15 ^ ((int)num2 * -1978409606);
					continue;
				}
				case 33u:
					Form1.smethod_24(graphics_, (Brush)(object)Form1.smethod_29(Color.FromArgb(180, Color.Peru)), num5 + (float)(num6 * size), num5 + (float)(num7 * size), num8, num8);
					num = (int)(num2 * 202380194) ^ -2137908621;
					continue;
				case 32u:
					num = ((int)num2 * -780407609) ^ 0x4E55EC1;
					continue;
				case 31u:
					num7++;
					num = (int)((num2 * 1689260355) ^ 0x1A8E6906);
					continue;
				case 30u:
					num = (int)(num2 * 1270030504) ^ -1396712329;
					continue;
				case 29u:
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox1));
					num7 = 0;
					num = ((int)num2 * -1121841016) ^ -1236690221;
					continue;
				case 27u:
					Form1.smethod_28(graphics_, brush_, num5 + (float)(num6 * size), num5 + (float)(num7 * size), num8, num8);
					num = ((int)num2 * -1049457688) ^ -620681113;
					continue;
				case 26u:
					num = -814831783;
					continue;
				case 25u:
					dark = board[num7, num6].Dark;
					num = ((int)num2 * -269163570) ^ -680544708;
					continue;
				case 24u:
					num = (int)(num2 * 41502797) ^ -1570956224;
					continue;
				case 23u:
					num = ((int)num2 * -276703626) ^ 0x509C6AD4;
					continue;
				case 22u:
				{
					int num21;
					int num22;
					if (!board[num7, num6].Square)
					{
						num21 = -834641125;
						num22 = -834641125;
					}
					else
					{
						num21 = -329480480;
						num22 = -329480480;
					}
					num = num21 ^ (int)(num2 * 1913098677);
					continue;
				}
				case 21u:
					num5 = (float)size * (num17 / 2f);
					num = ((int)num2 * -80974719) ^ 0x69C2B15F;
					continue;
				case 20u:
					flag = num6 < 4;
					num = -850885601;
					continue;
				case 19u:
					num9 = 1f;
					num = ((int)num2 * -1827728997) ^ 0xF605457;
					continue;
				case 18u:
					num6 = 0;
					num = -308833630;
					continue;
				case 17u:
					Form1.smethod_20(pictureBox1, (Image)(object)Form1.smethod_19(Form1.smethod_18((Control)(object)pictureBox1), Form1.smethod_16((Control)(object)pictureBox1)));
					num = (int)((num2 * 1462687370) ^ 0x23A1555C);
					continue;
				case 16u:
					num12 = (float)size * num9;
					num = (int)(num2 * 13051753) ^ -939382002;
					continue;
				case 15u:
					num = ((int)num2 * -659014526) ^ 0x6C2843C7;
					continue;
				case 14u:
				{
					int num18;
					int num19;
					if (big)
					{
						num18 = 663086094;
						num19 = 663086094;
					}
					else
					{
						num18 = 1139234246;
						num19 = 1139234246;
					}
					num = num18 ^ (int)(num2 * 1545026640);
					continue;
				}
				case 13u:
					num = ((int)num2 * -1868808666) ^ -2051526641;
					continue;
				case 12u:
					num5 = (float)size * (num17 / 2f);
					num = (int)((num2 * 634332725) ^ 0x6086B4A);
					continue;
				case 11u:
					num6++;
					num = -794930716;
					continue;
				case 10u:
					num8 = num12 * 0.4f / (float)Form1.smethod_27(2.0);
					point = board[num7, num6].Point;
					num = ((int)num2 * -726627048) ^ 0x1F8D7828;
					continue;
				case 9u:
					Form1.smethod_24(graphics_, Form1.smethod_23(), ((float)num6 + 0.05f) * (float)size, ((float)num7 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					num = (int)((num2 * 706583026) ^ 0x4826C912);
					continue;
				case 8u:
					num17 = 1f - num9 * 0.9f / (float)Form1.smethod_27(2.0);
					num = -1021132395;
					continue;
				case 7u:
					Form1.smethod_24(graphics_, brush_, num5 + (float)(num6 * size), num5 + (float)(num7 * size), num8, num8);
					num = -1883596334;
					continue;
				case 6u:
					brush_ = Form1.smethod_26();
					num = -1234963881;
					continue;
				case 5u:
					num17 = 1f - num9 * 0.4f / (float)Form1.smethod_27(2.0);
					num = -1119513802;
					continue;
				case 4u:
				{
					int num10;
					int num11;
					if (!flag)
					{
						num10 = -1982686993;
						num11 = -1982686993;
					}
					else
					{
						num10 = -1819716453;
						num11 = -1819716453;
					}
					num = num10 ^ (int)(num2 * 1025209526);
					continue;
				}
				case 3u:
					num9 = 0.7f;
					num = -47292142;
					continue;
				case 2u:
				{
					int num3;
					int num4;
					if (dark)
					{
						num3 = 160465607;
						num4 = 160465607;
					}
					else
					{
						num3 = 288605394;
						num4 = 288605394;
					}
					num = num3 ^ (int)(num2 * 801146086);
					continue;
				}
				case 1u:
					num = (int)((num2 * 757113483) ^ 0x40B33643);
					continue;
				default:
					return;
				case 0u:
					break;
				case 28u:
					return;
				}
				break;
			}
		}
	}

	private void Paint_Storage()
	{
		int num5 = default(int);
		int num6 = default(int);
		bool flag3 = default(bool);
		bool point = default(bool);
		Graphics graphics_ = default(Graphics);
		bool flag = default(bool);
		bool big = default(bool);
		float num7 = default(float);
		float num3 = default(float);
		Brush brush_ = default(Brush);
		float num21 = default(float);
		float num8 = default(float);
		bool flag2 = default(bool);
		float num4 = default(float);
		bool dark = default(bool);
		while (true)
		{
			int num = -1086174643;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF0355827u) % 41u)
				{
				case 40u:
					num = ((int)num2 * -791818692) ^ 0x52F390DD;
					continue;
				case 39u:
					Form1.smethod_30((Control)(object)pictureBox[num5, num6]);
					num = -443802161;
					continue;
				case 38u:
					flag3 = num5 < 4;
					num = -396145776;
					continue;
				case 37u:
					num = (int)(num2 * 305795159) ^ -1928338456;
					continue;
				case 36u:
				{
					int num13;
					int num14;
					if (point)
					{
						num13 = 247165845;
						num14 = 247165845;
					}
					else
					{
						num13 = 1115195772;
						num14 = 1115195772;
					}
					num = num13 ^ ((int)num2 * -980842249);
					continue;
				}
				case 35u:
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox[num5, num6]));
					num = ((int)num2 * -759676837) ^ 0x3EAD4948;
					continue;
				case 34u:
				{
					int num19;
					int num20;
					if (flag)
					{
						num19 = -426430289;
						num20 = -426430289;
					}
					else
					{
						num19 = -836644928;
						num20 = -836644928;
					}
					num = num19 ^ (int)(num2 * 2085888784);
					continue;
				}
				case 33u:
					num5++;
					num = ((int)num2 * -126103544) ^ -2104965974;
					continue;
				case 32u:
				{
					int num15;
					int num16;
					if (big)
					{
						num15 = 1591706113;
						num16 = 1591706113;
					}
					else
					{
						num15 = 2123135958;
						num16 = 2123135958;
					}
					num = num15 ^ ((int)num2 * -669365855);
					continue;
				}
				case 31u:
					num7 = (float)size * num3;
					num = ((int)num2 * -352934215) ^ 0x5BA1E344;
					continue;
				case 29u:
					brush_ = Form1.smethod_26();
					num = -1527801726;
					continue;
				case 28u:
					num = ((int)num2 * -1982161760) ^ -1355801774;
					continue;
				case 26u:
					num = (int)(num2 * 2106630596) ^ -1048345538;
					continue;
				case 25u:
					Form1.smethod_20(pictureBox[num5, num6], (Image)(object)Form1.smethod_19(Form1.smethod_18((Control)(object)pictureBox[num5, num6]), Form1.smethod_16((Control)(object)pictureBox[num5, num6])));
					num = ((int)num2 * -1474367396) ^ -130869577;
					continue;
				case 24u:
				{
					int num22;
					int num23;
					if (num6 >= 2)
					{
						num22 = -1220385740;
						num23 = -1220385740;
					}
					else
					{
						num22 = -1403430285;
						num23 = -1403430285;
					}
					num = num22 ^ ((int)num2 * -738636842);
					continue;
				}
				case 23u:
					Form1.smethod_24(graphics_, (Brush)(object)Form1.smethod_29(Color.FromArgb(180, Color.Peru)), num21, num21, num8, num8);
					num = (int)((num2 * 1204373988) ^ 0x456E6EC7);
					continue;
				case 22u:
					flag2 = num6 < 4;
					num = -25205239;
					continue;
				case 21u:
					Form1.smethod_28(graphics_, brush_, num21, num21, num8, num8);
					num = (int)(num2 * 932567408) ^ -2094072859;
					continue;
				case 20u:
					num3 = 0.7f;
					num = -1405491778;
					continue;
				case 19u:
					brush_ = Form1.smethod_25();
					num = ((int)num2 * -1643036924) ^ 0x5585EC5C;
					continue;
				case 18u:
					num6 = 0;
					num = -1682840297;
					continue;
				case 17u:
					Form1.smethod_24(graphics_, brush_, num21, num21, num8, num8);
					num = -1886563274;
					continue;
				case 16u:
					num = ((int)num2 * -1048464600) ^ 0x4FA10A2;
					continue;
				case 15u:
					num21 = (float)size * (num4 / 2f) - 4f;
					num = (int)((num2 * 211675268) ^ 0x69A31B71);
					continue;
				case 14u:
					big = storage[num5, num6].Big;
					num = -1705273525;
					continue;
				case 13u:
					num3 = 1f;
					num = (int)(num2 * 1724879920) ^ -289657170;
					continue;
				case 12u:
					num6++;
					num = -801413219;
					continue;
				case 11u:
					dark = storage[num5, num6].Dark;
					num = (int)(num2 * 1006512141) ^ -1401060189;
					continue;
				case 10u:
					num4 = 1f - num3 * 0.4f / (float)Form1.smethod_27(2.0);
					num21 = (float)size * (num4 / 2f) - 4f;
					num = -420964742;
					continue;
				case 9u:
				{
					int num17;
					int num18;
					if (flag3)
					{
						num17 = -389704946;
						num18 = -389704946;
					}
					else
					{
						num17 = -1694933170;
						num18 = -1694933170;
					}
					num = num17 ^ (int)(num2 * 1658326508);
					continue;
				}
				case 8u:
				{
					int num11;
					int num12;
					if (!flag2)
					{
						num11 = -2140484565;
						num12 = -2140484565;
					}
					else
					{
						num11 = -1656066792;
						num12 = -1656066792;
					}
					num = num11 ^ ((int)num2 * -407474609);
					continue;
				}
				case 7u:
					num = ((int)num2 * -1527937216) ^ 0x3DAA5642;
					continue;
				case 6u:
				{
					int num9;
					int num10;
					if (!dark)
					{
						num9 = -412880180;
						num10 = -412880180;
					}
					else
					{
						num9 = -1865949452;
						num10 = -1865949452;
					}
					num = num9 ^ ((int)num2 * -1495919168);
					continue;
				}
				case 5u:
					num8 = num7 * 0.4f / (float)Form1.smethod_27(2.0);
					point = storage[num5, num6].Point;
					num = (int)((num2 * 693998161) ^ 0x380F2903);
					continue;
				case 4u:
					num = ((int)num2 * -752627823) ^ 0x334C8C7;
					continue;
				case 3u:
					num8 = num7 * 0.9f / (float)Form1.smethod_27(2.0);
					num = (int)(num2 * 2099699206) ^ -1428011136;
					continue;
				case 2u:
					num5 = 0;
					num = ((int)num2 * -775592235) ^ -1071823748;
					continue;
				case 1u:
					flag = storage[num5, num6] != null;
					num = -71635416;
					continue;
				case 0u:
					num4 = 1f - num3 * 0.9f / (float)Form1.smethod_27(2.0);
					num = -1862624077;
					continue;
				default:
					return;
				case 30u:
					break;
				case 27u:
					return;
				}
				break;
			}
		}
	}

	public void StartGame()
	{
		int num3 = default(int);
		int num7 = default(int);
		int num4 = default(int);
		while (true)
		{
			int num = -624983538;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xBE84C2FBu) % 28u)
				{
				case 27u:
					Form1.smethod_32((Control)(object)richTextBox1, "Противник выбрал фигуру. Выберете поле на доске для установки этой фигуры.");
					num = ((int)num2 * -1922169118) ^ -1619730752;
					continue;
				case 26u:
					num3 = 0;
					num = ((int)num2 * -462516558) ^ -519432881;
					continue;
				case 24u:
				{
					int num8;
					if (num3 >= 4)
					{
						num = -2129263604;
						num8 = -2129263604;
					}
					else
					{
						num = -2079306568;
						num8 = -2079306568;
					}
					continue;
				}
				case 23u:
					num7 = 0;
					num = -465292766;
					continue;
				case 22u:
					num = ((int)num2 * -896249221) ^ -44746692;
					continue;
				case 21u:
				{
					int num10;
					if (num7 < 4)
					{
						num = -1380920485;
						num10 = -1380920485;
					}
					else
					{
						num = -117814935;
						num10 = -117814935;
					}
					continue;
				}
				case 20u:
					num = ((int)num2 * -1777564804) ^ 0x4CDFFAD8;
					continue;
				case 18u:
				{
					int num9 = Form1.smethod_33(rnd, 4);
					Form1.smethod_5((Control)(object)borderBox[num4, num9], Color.Blue);
					num = (int)((num2 * 912599779) ^ 0x623FC91D);
					continue;
				}
				case 17u:
					step = 0;
					num = (int)((num2 * 628604312) ^ 0x2D2DCAA3);
					continue;
				case 16u:
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: true);
					num = (int)((num2 * 1528793009) ^ 0x512EBD28);
					continue;
				case 15u:
					Form1.smethod_32((Control)(object)richTextBox1, "Ваш ход. Выберете фигуру, которой будет играть противник.");
					num = ((int)num2 * -172778419) ^ -351940371;
					continue;
				case 14u:
					num7++;
					num = ((int)num2 * -1831074930) ^ 0x74CBDBDE;
					continue;
				case 13u:
					num = (int)(num2 * 1108119406) ^ -752626956;
					continue;
				case 12u:
					num = -339850492;
					continue;
				case 11u:
					num = ((int)num2 * -1204654653) ^ 0x35E951FC;
					continue;
				case 10u:
					num = (int)((num2 * 1376341726) ^ 0x597E177D);
					continue;
				case 9u:
					Form1.smethod_36(timer1);
					num = ((int)num2 * -283648943) ^ -1670168807;
					continue;
				case 8u:
					Form1.smethod_7((Control)(object)pictureBox[num3, num7], bool_0: true);
					num = -156856144;
					continue;
				case 7u:
					num = (int)((num2 * 1755578363) ^ 0x3C8D693E);
					continue;
				case 6u:
					num = ((int)num2 * -267105958) ^ 0x3984CE3B;
					continue;
				case 5u:
				{
					Form1_Load(this, Form1.smethod_31());
					int num5;
					int num6;
					if (turn)
					{
						num5 = -1354191116;
						num6 = -1354191116;
					}
					else
					{
						num5 = -1937648374;
						num6 = -1937648374;
					}
					num = num5 ^ (int)(num2 * 1299265853);
					continue;
				}
				case 4u:
					time = new DateTime(0L, DateTimeKind.Unspecified);
					Form1.smethod_35(timer1, bool_0: true);
					num = ((int)num2 * -555422756) ^ -1482287947;
					continue;
				case 3u:
					num4 = Form1.smethod_33(rnd, 4);
					num = (int)(num2 * 390402229) ^ -323722062;
					continue;
				case 2u:
					num3++;
					num = ((int)num2 * -292255256) ^ -99556805;
					continue;
				case 1u:
					step = 1;
					num = ((int)num2 * -1562930505) ^ -1260524812;
					continue;
				case 0u:
					Form1.smethod_32((Control)(object)label2, Form1.smethod_34("Ход: ", step.ToString()));
					num = -1949486279;
					continue;
				default:
					return;
				case 25u:
					break;
				case 19u:
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
			int num = -621670838;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB112C55Du) % 4u)
				{
				case 3u:
					time = time.AddSeconds(1.0);
					num = (int)((num2 * 734320599) ^ 0x3ECAD2D2);
					continue;
				case 2u:
					Form1.smethod_32((Control)(object)label1, Form1.smethod_34("Время: ", time.ToString("HH:mm:ss")));
					num = (int)((num2 * 551082964) ^ 0x73B815D0);
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

	private void PictureBoxIJ_MouseDown(object sender, MouseEventArgs e)
	{
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Expected O, but got Unknown
		Point point = Form1.smethod_37((Control)((sender is PictureBox) ? sender : null));
		bool flag = default(bool);
		int num4 = default(int);
		int num6 = default(int);
		int num3 = default(int);
		bool flag2 = default(bool);
		int num5 = default(int);
		while (true)
		{
			int num = 798270929;
			while (true)
			{
				uint num2;
				int num8;
				switch ((num2 = (uint)num ^ 0x3B9E0005u) % 23u)
				{
				case 22u:
					Form1.smethod_7((Control)(object)button2, bool_0: true);
					num = (int)((num2 * 26353814) ^ 0x7E027C79);
					continue;
				case 21u:
				{
					int num11;
					int num12;
					if (!flag)
					{
						num11 = 912624077;
						num12 = 912624077;
					}
					else
					{
						num11 = 1306587744;
						num12 = 1306587744;
					}
					num = num11 ^ ((int)num2 * -1275764184);
					continue;
				}
				case 20u:
					num4 = 0;
					num = ((int)num2 * -1142324020) ^ -1823374570;
					continue;
				case 18u:
					num6 = point.X / size;
					num = ((int)num2 * -163059239) ^ -75468234;
					continue;
				case 17u:
					num3 = 0;
					num = 1572275129;
					continue;
				case 16u:
				{
					int num9;
					int num10;
					if (!flag2)
					{
						num9 = -1915558286;
						num10 = -1915558286;
					}
					else
					{
						num9 = -1436736317;
						num10 = -1436736317;
					}
					num = num9 ^ ((int)num2 * -1918683715);
					continue;
				}
				case 14u:
					flag2 = num6 > 1;
					num = (int)(num2 * 749773599) ^ -107817117;
					continue;
				case 13u:
					Form1.smethod_32((Control)(object)richTextBox1, "Именно эта фигура? Если да - нажмите \"Подтвердить\".");
					num = (int)(num2 * 996424212) ^ -1845734070;
					continue;
				case 12u:
					flag = num3 < 4;
					num = 1213682531;
					continue;
				case 11u:
					if (Form1.smethod_40((Bitmap)Form1.smethod_21(pictureBox[num5, num6]), Form1.smethod_38(e), Form1.smethod_39(e)) != Color.FromArgb(0, 0, 0, 0))
					{
						num = 494188887;
						num8 = 494188887;
						continue;
					}
					goto IL_0156;
				case 10u:
					num6 -= 4;
					num = (int)((num2 * 1244346774) ^ 0xA3535A);
					continue;
				case 9u:
				{
					int num7;
					if (num4 >= 4)
					{
						num = 437566691;
						num7 = 437566691;
					}
					else
					{
						num = 1479469804;
						num7 = 1479469804;
					}
					continue;
				}
				case 8u:
					num = (int)(num2 * 10552916) ^ -963673666;
					continue;
				case 7u:
					num = (int)((num2 * 1112151234) ^ 0x2B36ADD5);
					continue;
				case 6u:
					Form1.smethod_5((Control)(object)borderBox[num5, num6], Color.Red);
					num = (int)(num2 * 146545890) ^ -1573752451;
					continue;
				case 5u:
					Form1.smethod_5((Control)(object)borderBox[num4, num3], Color.White);
					num = 388651312;
					continue;
				case 4u:
					num = (int)(num2 * 820182073) ^ -1713764503;
					continue;
				case 3u:
					num5 = point.Y / size;
					point = Form1.smethod_37((Control)((sender is PictureBox) ? sender : null));
					num = ((int)num2 * -109247930) ^ -987704328;
					continue;
				case 2u:
					if (storage[num5, num6] != null)
					{
						num = 857458339;
						continue;
					}
					goto IL_0156;
				case 1u:
					num4++;
					num = (int)(num2 * 1068106282) ^ -1889038102;
					continue;
				case 0u:
					num3++;
					num = ((int)num2 * -1296941841) ^ -261516171;
					continue;
				default:
					return;
				case 15u:
					break;
				case 19u:
					return;
					IL_0156:
					num = 1491014827;
					num8 = 1491014827;
					continue;
				}
				break;
			}
		}
	}

	private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
	{
		//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Expected O, but got Unknown
		int num = Form1.smethod_38(e) / size;
		int num2 = Form1.smethod_39(e) / size;
		bool flag = default(bool);
		int num5 = default(int);
		int num6 = default(int);
		bool flag3 = default(bool);
		Graphics graphics_ = default(Graphics);
		bool flag2 = default(bool);
		while (true)
		{
			int num3 = 903593697;
			while (true)
			{
				uint num4;
				int num14;
				switch ((num4 = (uint)num3 ^ 0x7CC68D94u) % 25u)
				{
				case 24u:
					flag = num5 < 4;
					num3 = 1046309995;
					continue;
				case 23u:
					num3 = (int)((num4 * 989184072) ^ 0xD1804B9);
					continue;
				case 22u:
					num6++;
					num3 = 1641183511;
					continue;
				case 20u:
					num14 = ((board[num2, num] == null) ? 1 : 0);
					goto IL_0064;
				case 19u:
					num3 = ((int)num4 * -566878054) ^ 0x46A1669A;
					continue;
				case 18u:
					Form1.smethod_32((Control)(object)richTextBox1, "Уверены? Для выполнения данного хода нажмите \"Подтвердить\".");
					num3 = (int)((num4 * 1622688809) ^ 0x540D57A3);
					continue;
				case 17u:
					flag3 = Form1.smethod_41((Control)(object)borderBox[num5, num6]) == Color.Blue;
					num3 = 1214843386;
					continue;
				case 16u:
				{
					int num8;
					int num9;
					if (flag)
					{
						num8 = -667830024;
						num9 = -667830024;
					}
					else
					{
						num8 = -1346448054;
						num9 = -1346448054;
					}
					num3 = num8 ^ ((int)num4 * -521735048);
					continue;
				}
				case 15u:
					num5 = 0;
					num3 = (int)((num4 * 1998074550) ^ 0x5CBC08D7);
					continue;
				case 13u:
					Form1.smethod_43(graphics_, Form1.smethod_42(Color.Red, 3f), ((float)num + 0.05f) * (float)size, ((float)num2 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					num3 = ((int)num4 * -403710916) ^ 0x2FF2CBC6;
					continue;
				case 12u:
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox1));
					num3 = ((int)num4 * -2133685449) ^ 0x578431A5;
					continue;
				case 11u:
					num3 = (int)(num4 * 2038697830) ^ -1449595145;
					continue;
				case 10u:
					if (Form1.smethod_40((Bitmap)Form1.smethod_21(pictureBox1), Form1.smethod_38(e), Form1.smethod_39(e)) != Color.FromArgb(0, 0, 0, 0))
					{
						num3 = (int)((num4 * 314914519) ^ 0x7E999EE7);
						continue;
					}
					num14 = 0;
					goto IL_0064;
				case 9u:
				{
					int num12;
					int num13;
					if (!flag3)
					{
						num12 = -823534934;
						num13 = -823534934;
					}
					else
					{
						num12 = -259279276;
						num13 = -259279276;
					}
					num3 = num12 ^ ((int)num4 * -182183390);
					continue;
				}
				case 8u:
				{
					int num10;
					int num11;
					if (!flag2)
					{
						num10 = 759961931;
						num11 = 759961931;
					}
					else
					{
						num10 = 1731394770;
						num11 = 1731394770;
					}
					num3 = num10 ^ ((int)num4 * -1266379563);
					continue;
				}
				case 7u:
					Paint_Board();
					num3 = ((int)num4 * -1780661963) ^ 0x3374DF78;
					continue;
				case 6u:
					Form1.smethod_45(graphics_);
					num3 = ((int)num4 * -113935704) ^ 0xED80332;
					continue;
				case 5u:
					Form1.smethod_44(graphics_, Form1.smethod_21(pictureBox[num5, num6]), num * size + 4, num2 * size + 4, new Rectangle(0, 0, size, size), (GraphicsUnit)2);
					num3 = (int)(num4 * 1188900098) ^ -112825401;
					continue;
				case 4u:
				{
					int num7;
					if (num6 >= 4)
					{
						num3 = 151254373;
						num7 = 151254373;
					}
					else
					{
						num3 = 290256609;
						num7 = 290256609;
					}
					continue;
				}
				case 3u:
					num6 = 0;
					num3 = 473498052;
					continue;
				case 2u:
					num3 = ((int)num4 * -576469555) ^ -723236197;
					continue;
				case 1u:
					Form1.smethod_30((Control)(object)pictureBox1);
					Form1.smethod_7((Control)(object)button2, bool_0: true);
					num3 = (int)(num4 * 54998602) ^ -1044718709;
					continue;
				case 0u:
					num5++;
					num3 = (int)((num4 * 90332913) ^ 0x7B3481D0);
					continue;
				default:
					return;
				case 21u:
					break;
				case 14u:
					return;
					IL_0064:
					flag2 = (byte)num14 != 0;
					num3 = 55561329;
					continue;
				}
				break;
			}
		}
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		//IL_0f50: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f7e: Expected O, but got Unknown
		bool flag2 = default(bool);
		int num34 = default(int);
		Figurine[,] array2 = default(Figurine[,]);
		bool flag11 = default(bool);
		Figurine[,] array3 = default(Figurine[,]);
		Figurine[,] array = default(Figurine[,]);
		int num12 = default(int);
		int num11 = default(int);
		int num4 = default(int);
		int num5 = default(int);
		bool flag12 = default(bool);
		int num18 = default(int);
		int num25 = default(int);
		int num10 = default(int);
		int num8 = default(int);
		int num3 = default(int);
		int num13 = default(int);
		bool flag6 = default(bool);
		int num16 = default(int);
		int num6 = default(int);
		int num7 = default(int);
		bool flag8 = default(bool);
		int num27 = default(int);
		int num47 = default(int);
		int num17 = default(int);
		bool flag3 = default(bool);
		int num32 = default(int);
		int num33 = default(int);
		bool flag5 = default(bool);
		int num9 = default(int);
		bool flag16 = default(bool);
		bool flag14 = default(bool);
		bool flag15 = default(bool);
		bool flag4 = default(bool);
		Graphics graphics_ = default(Graphics);
		bool flag10 = default(bool);
		int num37 = default(int);
		bool flag13 = default(bool);
		bool flag9 = default(bool);
		bool flag7 = default(bool);
		bool flag = default(bool);
		while (true)
		{
			int num = 969836297;
			while (true)
			{
				uint num2;
				int num64;
				int num15;
				int num44;
				int num28;
				switch ((num2 = (uint)num ^ 0x6E16E16Au) % 179u)
				{
				case 178u:
					Form1.smethod_32((Control)(object)richTextBox1, "Противник сделал ход (зелёный). Выберете поле на доске для выбронной противником фигуры (синий).");
					num = (int)((num2 * 1436184543) ^ 0x5F89C6BE);
					continue;
				case 177u:
				{
					int num56;
					int num57;
					if (flag2)
					{
						num56 = 1572321288;
						num57 = 1572321288;
					}
					else
					{
						num56 = 2039259638;
						num57 = 2039259638;
					}
					num = num56 ^ ((int)num2 * -1171035734);
					continue;
				}
				case 176u:
					num = (int)(num2 * 188661456) ^ -1948953268;
					continue;
				case 175u:
					num34 = 0;
					num = ((int)num2 * -1046397351) ^ -1500948487;
					continue;
				case 174u:
					num = (int)((num2 * 1553023546) ^ 0x6F4A1CB7);
					continue;
				case 173u:
					array2 = (Figurine[,])Form1.smethod_48((Array)board);
					num = (int)((num2 * 721430776) ^ 0x639F0A26);
					continue;
				case 172u:
					num = (int)((num2 * 374465091) ^ 0x9AF82B3);
					continue;
				case 171u:
					flag11 = Stop(array3);
					num = (int)(num2 * 1866230854) ^ -2126786733;
					continue;
				case 170u:
					array[num12, num11] = new Figurine(storage[num4, num5]);
					num = ((int)num2 * -278793023) ^ -737489527;
					continue;
				case 169u:
					flag12 = num18 < 4;
					num = 938329541;
					continue;
				case 168u:
					num = ((int)num2 * -1260333459) ^ 0x6E18B496;
					continue;
				case 167u:
					num25 = num10;
					Form1.smethod_5((Control)(object)borderBox[num8, num10], Color.White);
					num = ((int)num2 * -2126060897) ^ -573881360;
					continue;
				case 166u:
					Form1.smethod_20(pictureBox[num8, num10], (Image)null);
					num = ((int)num2 * -1024470302) ^ 0x6C85CD83;
					continue;
				case 165u:
					Form1.smethod_7((Control)(object)pictureBox[num3, num13], bool_0: false);
					num = ((int)num2 * -1760362396) ^ -909113748;
					continue;
				case 164u:
					num = (int)((num2 * 1956438251) ^ 0x7970E135);
					continue;
				case 163u:
					if (!Standoff(board))
					{
						num = 1298829103;
						num64 = 1298829103;
						continue;
					}
					goto IL_01db;
				case 162u:
					num18 = 0;
					num = (int)(num2 * 2049390268) ^ -2008113928;
					continue;
				case 161u:
					Form1.smethod_47(200);
					num = ((int)num2 * -162555469) ^ -955476995;
					continue;
				case 160u:
					num = (int)(num2 * 1194724076) ^ -1060742808;
					continue;
				case 159u:
					Form1.smethod_32((Control)(object)label2, Form1.smethod_34("Ход: ", step.ToString()));
					num = (int)((num2 * 1250711941) ^ 0x6EF201DF);
					continue;
				case 158u:
					num = (int)((num2 * 897406428) ^ 0x40CD1AC);
					continue;
				case 157u:
					(menu as Form3).ContinueLock();
					num = (int)(num2 * 2021550865) ^ -802470447;
					continue;
				case 156u:
					num = (int)((num2 * 975381161) ^ 0x75FED9E5);
					continue;
				case 155u:
					flag6 = num16 < 4;
					num = 1634431515;
					continue;
				case 154u:
					if (storage[num6, num7] != null)
					{
						num = ((int)num2 * -1333071614) ^ -1525940419;
						continue;
					}
					goto IL_02fd;
				case 153u:
				{
					int num52;
					int num53;
					if (!flag8)
					{
						num52 = -227320930;
						num53 = -227320930;
					}
					else
					{
						num52 = -1905097271;
						num53 = -1905097271;
					}
					num = num52 ^ (int)(num2 * 1816770493);
					continue;
				}
				case 152u:
					Form1.smethod_7((Control)(object)pictureBox[num27, num47], bool_0: true);
					num = 265393064;
					continue;
				case 151u:
					Form1.smethod_30((Control)(object)borderBox[num4, num5]);
					num = ((int)num2 * -454913949) ^ -1139161986;
					continue;
				case 150u:
					num = (int)(num2 * 884207168) ^ -164973115;
					continue;
				case 149u:
					num8++;
					num = (int)((num2 * 351736260) ^ 0xF424BED);
					continue;
				case 148u:
					Form1.smethod_20(pictureBox[num4, num5], (Image)null);
					num = ((int)num2 * -1115714368) ^ 0x5B8950B0;
					continue;
				case 147u:
					num17++;
					num = 802798619;
					continue;
				case 146u:
				{
					int num42;
					int num43;
					if (flag3)
					{
						num42 = 2142905170;
						num43 = 2142905170;
					}
					else
					{
						num42 = 163127448;
						num43 = 163127448;
					}
					num = num42 ^ ((int)num2 * -1044753619);
					continue;
				}
				case 145u:
					Form1.smethod_32((Control)(object)richTextBox1, "Ничья!");
					num = (int)((num2 * 1916867863) ^ 0x5061F6C0);
					continue;
				case 144u:
					num27++;
					num = ((int)num2 * -1794953122) ^ 0x39226597;
					continue;
				case 143u:
				{
					int num35;
					int num36;
					if (board[num12, num11] == null)
					{
						num35 = 809863080;
						num36 = 809863080;
					}
					else
					{
						num35 = 1705071817;
						num36 = 1705071817;
					}
					num = num35 ^ (int)(num2 * 246708297);
					continue;
				}
				case 142u:
					board[num32, num33] = new Figurine(storage[num34, num25]);
					num = (int)(num2 * 772651579) ^ -192761837;
					continue;
				case 141u:
					num = (int)((num2 * 2110446131) ^ 0xC0B9BF8);
					continue;
				case 140u:
					num27 = 0;
					num = ((int)num2 * -2026241883) ^ 0x3F287636;
					continue;
				case 139u:
					num = (int)(num2 * 336008270) ^ -1424158999;
					continue;
				case 138u:
					flag8 = num10 < 4;
					num = 1065333631;
					continue;
				case 137u:
					num4 = 0;
					num5 = 0;
					num = ((int)num2 * -714316059) ^ 0x5D8FA089;
					continue;
				case 136u:
					array3 = (Figurine[,])Form1.smethod_48((Array)array);
					num = (int)((num2 * 1509239011) ^ 0x554B0BDA);
					continue;
				case 135u:
				{
					int num21;
					int num22;
					if (flag5)
					{
						num21 = -1312282039;
						num22 = -1312282039;
					}
					else
					{
						num21 = -1185347078;
						num22 = -1185347078;
					}
					num = num21 ^ ((int)num2 * -766646484);
					continue;
				}
				case 134u:
					(menu as Form3).ContinueLock();
					num = ((int)num2 * -638277766) ^ 0x5CA56D78;
					continue;
				case 133u:
					num18++;
					num = ((int)num2 * -711992248) ^ 0x79D181D6;
					continue;
				case 132u:
					num = ((int)num2 * -642293345) ^ -254131370;
					continue;
				case 131u:
					array3[num16, num9] = new Figurine(storage[num6, num7]);
					num = (int)((num2 * 722880605) ^ 0x38BC4C6);
					continue;
				case 130u:
					num = (int)((num2 * 884141421) ^ 0x6DFF0973);
					continue;
				case 129u:
					num = (int)((num2 * 262324068) ^ 0x5E6B008E);
					continue;
				case 128u:
					board[num12, num11] = new Figurine(storage[num4, num5]);
					storage[num4, num5] = null;
					Form1.smethod_5((Control)(object)borderBox[num6, num7], Color.Blue);
					num = (int)(num2 * 1450946743) ^ -605824887;
					continue;
				case 127u:
					num = (int)(num2 * 1673975866) ^ -590041590;
					continue;
				case 126u:
					Form1.smethod_30((Control)(object)pictureBox1);
					num = ((int)num2 * -1162966546) ^ -802494831;
					continue;
				case 125u:
					num = ((int)num2 * -874908744) ^ -1203115622;
					continue;
				case 124u:
					flag16 = Form1.smethod_41((Control)(object)borderBox[num3, num13]) == Color.Red;
					num = ((int)num2 * -930784292) ^ -376778770;
					continue;
				case 123u:
					num = (int)((num2 * 1678789902) ^ 0x4BAD7BF0);
					continue;
				case 122u:
				{
					int num65;
					int num66;
					if (flag14)
					{
						num65 = -79702046;
						num66 = -79702046;
					}
					else
					{
						num65 = -1911800481;
						num66 = -1911800481;
					}
					num = num65 ^ (int)(num2 * 639690284);
					continue;
				}
				case 121u:
				{
					int num62;
					int num63;
					if (flag16)
					{
						num62 = -1255102789;
						num63 = -1255102789;
					}
					else
					{
						num62 = -248959036;
						num63 = -248959036;
					}
					num = num62 ^ ((int)num2 * -901893921);
					continue;
				}
				case 120u:
					storage[num34, num25] = null;
					Paint_Board();
					if (!Stop(board))
					{
						num = ((int)num2 * -2113615489) ^ 0x1B3C14D5;
						continue;
					}
					goto IL_01db;
				case 119u:
					Form1.smethod_32((Control)(object)richTextBox1, "Ничья!");
					num = ((int)num2 * -147352934) ^ 0x38C67351;
					continue;
				case 118u:
					flag15 = board[num18, num17] == null;
					num = 1377304651;
					continue;
				case 117u:
				{
					int num60;
					int num61;
					if (!Form1.smethod_46((Control)(object)pictureBox1))
					{
						num60 = 964113251;
						num61 = 964113251;
					}
					else
					{
						num60 = 408411581;
						num61 = 408411581;
					}
					num = num60 ^ ((int)num2 * -658364950);
					continue;
				}
				case 116u:
					Form1.smethod_30((Control)(object)pictureBox[num8, num10]);
					num = (int)(num2 * 408928585) ^ -393283400;
					continue;
				case 115u:
					num25 = 0;
					num32 = 0;
					num33 = 0;
					num8 = 0;
					num = ((int)num2 * -38521915) ^ 0x7941E749;
					continue;
				case 114u:
					num15 = (Standoff(array2) ? 1 : 0);
					goto IL_083d;
				case 112u:
					num10++;
					num = ((int)num2 * -774689358) ^ 0x34F40490;
					continue;
				case 111u:
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: true);
					num = ((int)num2 * -1197628668) ^ -1736580767;
					continue;
				case 110u:
					num3 = 0;
					num = ((int)num2 * -603655472) ^ -1236943629;
					continue;
				case 109u:
					num = (int)((num2 * 1937230207) ^ 0x48236675);
					continue;
				case 108u:
					Form1.smethod_32((Control)(object)richTextBox1, "Подождите, компьютер делает свой ход.");
					Form1.smethod_30((Control)(object)richTextBox1);
					num = ((int)num2 * -384776922) ^ 0x5FC0382E;
					continue;
				case 107u:
					num3++;
					num = ((int)num2 * -999357778) ^ -501154977;
					continue;
				case 106u:
					step++;
					num = (int)(num2 * 309741929) ^ -132864470;
					continue;
				case 105u:
					Form1.smethod_15(timer1);
					num = (int)((num2 * 2120608753) ^ 0x46EE8FCF);
					continue;
				case 104u:
				{
					int num58;
					int num59;
					if (flag12)
					{
						num58 = -1125904516;
						num59 = -1125904516;
					}
					else
					{
						num58 = -1527128979;
						num59 = -1527128979;
					}
					num = num58 ^ (int)(num2 * 474087438);
					continue;
				}
				case 103u:
					flag4 = Form1.smethod_41((Control)(object)borderBox[num8, num10]) == Color.Blue;
					num = ((int)num2 * -199891956) ^ -687307964;
					continue;
				case 102u:
					num = ((int)num2 * -1521810500) ^ 0x7FF884B0;
					continue;
				case 100u:
					num47++;
					num = ((int)num2 * -840675523) ^ 0x5007282E;
					continue;
				case 99u:
					num = ((int)num2 * -2015403068) ^ 0x69B968C9;
					continue;
				case 98u:
					Form1.smethod_32((Control)(object)label2, Form1.smethod_34("Ход: ", step.ToString()));
					num = ((int)num2 * -1703434292) ^ -227501920;
					continue;
				case 97u:
					num47 = 0;
					num = 322819131;
					continue;
				case 96u:
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox1));
					num = ((int)num2 * -1015773545) ^ 0x6032E117;
					continue;
				case 95u:
					num = ((int)num2 * -83154932) ^ -678286721;
					continue;
				case 94u:
					num = 747426022;
					continue;
				case 93u:
				{
					int num54;
					int num55;
					if (flag10)
					{
						num54 = 1864978489;
						num55 = 1864978489;
					}
					else
					{
						num54 = 301875493;
						num55 = 301875493;
					}
					num = num54 ^ (int)(num2 * 752853876);
					continue;
				}
				case 92u:
				{
					int num50;
					int num51;
					if (flag15)
					{
						num50 = -1825136586;
						num51 = -1825136586;
					}
					else
					{
						num50 = -959270315;
						num51 = -959270315;
					}
					num = num50 ^ (int)(num2 * 2061911645);
					continue;
				}
				case 91u:
					Form1.smethod_44(graphics_, Form1.smethod_21(pictureBox[num4, num5]), num11 * size + 4, num12 * size + 4, new Rectangle(0, 0, size, size), (GraphicsUnit)2);
					Form1.smethod_30((Control)(object)pictureBox1);
					num = ((int)num2 * -2104300059) ^ -2106652406;
					continue;
				case 90u:
					num = ((int)num2 * -1573117641) ^ 0x3F458691;
					continue;
				case 89u:
					num = (int)((num2 * 1839082650) ^ 0x299AE0AE);
					continue;
				case 88u:
					num = 1065368406;
					continue;
				case 87u:
					num44 = ((num37 < 9) ? 1 : 0);
					goto IL_0b38;
				case 86u:
					num = ((int)num2 * -1295215486) ^ -1679551369;
					continue;
				case 85u:
					num = 752344541;
					continue;
				case 84u:
					num = (int)(num2 * 503769216) ^ -756039596;
					continue;
				case 83u:
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: false);
					num = ((int)num2 * -1731704796) ^ -1726849607;
					continue;
				case 82u:
					flag13 = num9 < 4;
					num = 1816409898;
					continue;
				case 81u:
				{
					int num49;
					if (array[num16, num9] != null)
					{
						num = 747426022;
						num49 = 747426022;
					}
					else
					{
						num = 1188963257;
						num49 = 1188963257;
					}
					continue;
				}
				case 80u:
					step++;
					num = 1402520967;
					continue;
				case 79u:
					num34 = num8;
					num = ((int)num2 * -1493193622) ^ 0x4327680E;
					continue;
				case 78u:
				{
					int num48;
					if (num47 < 4)
					{
						num = 1089900212;
						num48 = 1089900212;
					}
					else
					{
						num = 361335374;
						num48 = 361335374;
					}
					continue;
				}
				case 77u:
					Form1.smethod_5((Control)(object)borderBox[num4, num5], Color.White);
					num = (int)((num2 * 395314585) ^ 0x3289C2E3);
					continue;
				case 76u:
					num13 = 0;
					num = 27763409;
					continue;
				case 75u:
				{
					int num45;
					int num46;
					if (!flag13)
					{
						num45 = -555895259;
						num46 = -555895259;
					}
					else
					{
						num45 = -1672946271;
						num46 = -1672946271;
					}
					num = num45 ^ ((int)num2 * -727626570);
					continue;
				}
				case 74u:
					num = 1475400596;
					continue;
				case 73u:
					Form1.smethod_20(pictureBox[num4, num5], (Image)null);
					Form1.smethod_30((Control)(object)pictureBox[num4, num5]);
					num = ((int)num2 * -1214139087) ^ -1408081606;
					continue;
				case 72u:
					num = (int)((num2 * 1850395904) ^ 0x56B3C672);
					continue;
				case 71u:
					if (!flag9)
					{
						num = (int)((num2 * 1356968286) ^ 0x4B1BBAA3);
						continue;
					}
					num44 = 1;
					goto IL_0b38;
				case 70u:
					num9++;
					num = 26518277;
					continue;
				case 69u:
					Form1.smethod_47(200);
					num = ((int)num2 * -1790827433) ^ 0x48639CD6;
					continue;
				case 68u:
					Form1.smethod_5((Control)(object)borderBox[num3, num13], Color.LimeGreen);
					Form1.smethod_30((Control)(object)borderBox[num3, num13]);
					num4 = num3;
					num = (int)(num2 * 1929774306) ^ -579197900;
					continue;
				case 67u:
					num32 = num8;
					num33 = num10;
					num = ((int)num2 * -1628121757) ^ 0x3C9D84D7;
					continue;
				case 66u:
				{
					int num40;
					int num41;
					if (flag7)
					{
						num40 = 1097648175;
						num41 = 1097648175;
					}
					else
					{
						num40 = 443827670;
						num41 = 443827670;
					}
					num = num40 ^ (int)(num2 * 1955572007);
					continue;
				}
				case 65u:
					num = ((int)num2 * -1049035136) ^ 0x11FA451B;
					continue;
				case 64u:
					num = ((int)num2 * -1272061508) ^ 0xCBAA36;
					continue;
				case 63u:
					Form1.smethod_30((Control)(object)label2);
					num = (int)((num2 * 157628516) ^ 0x7E274DA4);
					continue;
				case 62u:
					num16 = 0;
					num = (int)((num2 * 199972593) ^ 0x73C055B7);
					continue;
				case 61u:
					num17 = 0;
					num = 2014935088;
					continue;
				case 60u:
					num = 522;
					continue;
				case 59u:
					Form1.smethod_32((Control)(object)richTextBox1, "QUARTO! Компьютер выиграл!");
					num = 843502412;
					continue;
				case 58u:
					num37 = 0;
					num = (int)((num2 * 1872367373) ^ 0x562B873F);
					continue;
				case 57u:
					Form1.smethod_7((Control)(object)button2, bool_0: false);
					num = (int)(num2 * 1524016594) ^ -582876168;
					continue;
				case 56u:
					num5 = num13;
					num = (int)((num2 * 748606532) ^ 0x6465F434);
					continue;
				case 55u:
					Form1.smethod_30((Control)(object)borderBox[num8, num10]);
					num = (int)(num2 * 1138688601) ^ -611594577;
					continue;
				case 54u:
					num = 917868165;
					continue;
				case 53u:
				{
					int num38;
					int num39;
					if (flag11)
					{
						num38 = -1389805629;
						num39 = -1389805629;
					}
					else
					{
						num38 = -2009805530;
						num39 = -2009805530;
					}
					num = num38 ^ ((int)num2 * -292944478);
					continue;
				}
				case 52u:
					num37++;
					flag9 = false;
					num = 763214509;
					continue;
				case 51u:
					board[num18, num17] = new Figurine(storage[num4, num5]);
					storage[num4, num5] = null;
					flag10 = Standoff(board);
					num = (int)(num2 * 1261418013) ^ -1695134940;
					continue;
				case 50u:
				{
					int num31;
					if (!(Form1.smethod_40((Bitmap)Form1.smethod_21(pictureBox1), num10 * size + size / 2, (int)(((float)num8 + 0.05f) * (float)size)) == Color.FromArgb(255, 255, 0, 0)))
					{
						num = 1127435624;
						num31 = 1127435624;
					}
					else
					{
						num = 178771444;
						num31 = 178771444;
					}
					continue;
				}
				case 49u:
					flag9 = true;
					num = (int)(num2 * 1739324627) ^ -651418515;
					continue;
				case 48u:
					array2[num18, num17] = new Figurine(storage[num4, num5]);
					num = (int)(num2 * 1778927950) ^ -868827168;
					continue;
				case 47u:
					Form1.smethod_44(graphics_, Form1.smethod_21(pictureBox[num4, num5]), num17 * size + 4, num18 * size + 4, new Rectangle(0, 0, size, size), (GraphicsUnit)2);
					num = (int)((num2 * 1898690364) ^ 0x54A696F);
					continue;
				case 46u:
				{
					int num29;
					int num30;
					if (flag)
					{
						num29 = -135829567;
						num30 = -135829567;
					}
					else
					{
						num29 = -575483145;
						num30 = -575483145;
					}
					num = num29 ^ ((int)num2 * -829912942);
					continue;
				}
				case 45u:
					if (num6 == num4)
					{
						num = (int)(num2 * 2063809525) ^ -126339969;
						continue;
					}
					goto IL_02f1;
				case 44u:
					num = ((int)num2 * -550624511) ^ 0x7720903A;
					continue;
				case 43u:
					Form1.smethod_30((Control)(object)pictureBox[num4, num5]);
					num = (int)(num2 * 1835986618) ^ -1664814942;
					continue;
				case 42u:
					num16++;
					num = ((int)num2 * -254197496) ^ -863320121;
					continue;
				case 41u:
					flag7 = num27 < 4;
					num = 38498842;
					continue;
				case 40u:
					num = ((int)num2 * -2031411644) ^ 0x492CD554;
					continue;
				case 39u:
				{
					int num26;
					if (num17 < 4)
					{
						num = 1890170767;
						num26 = 1890170767;
					}
					else
					{
						num = 1961558455;
						num26 = 1961558455;
					}
					continue;
				}
				case 38u:
					num = (int)(num2 * 129103762) ^ -1717183173;
					continue;
				case 37u:
					num = 441498863;
					continue;
				case 36u:
					num = ((int)num2 * -875904550) ^ 0x4DDA5197;
					continue;
				case 35u:
					num = (int)(num2 * 611894189) ^ -1387069189;
					continue;
				case 34u:
					Form1.smethod_32((Control)(object)richTextBox1, "Выберете фигуру, которой будет играть противник.");
					num = (int)((num2 * 40465941) ^ 0x535F465F);
					continue;
				case 33u:
				{
					int num23;
					int num24;
					if (!flag6)
					{
						num23 = 278145831;
						num24 = 278145831;
					}
					else
					{
						num23 = 2075630655;
						num24 = 2075630655;
					}
					num = num23 ^ (int)(num2 * 2034485943);
					continue;
				}
				case 32u:
				{
					int num19;
					int num20;
					if (flag4)
					{
						num19 = -497374610;
						num20 = -497374610;
					}
					else
					{
						num19 = -1031179294;
						num20 = -1031179294;
					}
					num = num19 ^ ((int)num2 * -1371441223);
					continue;
				}
				case 31u:
					num = (int)(num2 * 1319158339) ^ -1088490592;
					continue;
				case 30u:
					Form1.smethod_43(graphics_, Form1.smethod_42(Color.LimeGreen, 3f), ((float)num17 + 0.05f) * (float)size, ((float)num18 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					num = (int)(num2 * 210489136) ^ -853932430;
					continue;
				case 29u:
					num = (int)((num2 * 1062868153) ^ 0xB4E5B71);
					continue;
				case 28u:
					num12 = Form1.smethod_33(rnd, 4);
					num11 = Form1.smethod_33(rnd, 4);
					num = ((int)num2 * -671545528) ^ -1900751274;
					continue;
				case 27u:
					num = ((int)num2 * -335758150) ^ 0x78F1FDFF;
					continue;
				case 26u:
					num = ((int)num2 * -943987346) ^ 0x6E9399E;
					continue;
				case 25u:
					num6 = Form1.smethod_33(rnd, 4);
					num7 = Form1.smethod_33(rnd, 4);
					num = (int)((num2 * 2041614962) ^ 0x75C01EFD);
					continue;
				case 24u:
					if (!Stop(array2))
					{
						num = ((int)num2 * -581276536) ^ -798735789;
						continue;
					}
					num15 = 1;
					goto IL_083d;
				case 23u:
					if (num7 != num5)
					{
						goto IL_02f1;
					}
					goto IL_02fd;
				case 22u:
					Form1.smethod_15(timer1);
					num = 385731602;
					continue;
				case 21u:
					num = 642677928;
					continue;
				case 20u:
					num = (int)(num2 * 1907824329) ^ -1566558489;
					continue;
				case 19u:
					num13++;
					num = ((int)num2 * -833053958) ^ -1197566903;
					continue;
				case 18u:
					num = 1122562474;
					continue;
				case 17u:
					num = ((int)num2 * -1639340329) ^ 0x28A88C14;
					continue;
				case 16u:
				{
					int num14;
					if (num13 < 4)
					{
						num = 867725460;
						num14 = 867725460;
					}
					else
					{
						num = 1634996144;
						num14 = 1634996144;
					}
					continue;
				}
				case 15u:
					num = 421594199;
					continue;
				case 14u:
					Form1.smethod_43(graphics_, Form1.smethod_42(Color.LimeGreen, 3f), ((float)num11 + 0.05f) * (float)size, ((float)num12 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					num = ((int)num2 * -1217294898) ^ 0xB041D00;
					continue;
				case 13u:
					array = (Figurine[,])Form1.smethod_48((Array)board);
					num = (int)((num2 * 306176700) ^ 0xDB5D719);
					continue;
				case 12u:
					num = (int)((num2 * 718915605) ^ 0x40D6966D);
					continue;
				case 11u:
					Form1.smethod_30((Control)(object)borderBox[num4, num5]);
					num = ((int)num2 * -1093712699) ^ -560297540;
					continue;
				case 10u:
					flag3 = Standoff(board);
					num = 1287013001;
					continue;
				case 9u:
					num10 = 0;
					num = 952132658;
					continue;
				case 8u:
					num9 = 0;
					num = 1635281881;
					continue;
				case 7u:
					flag2 = num8 < 4;
					num = 1887886119;
					continue;
				case 6u:
					Form1.smethod_47(1000);
					num = ((int)num2 * -1019503472) ^ -2027952563;
					continue;
				case 5u:
					Form1.smethod_30((Control)(object)borderBox[num6, num7]);
					num = (int)((num2 * 822498036) ^ 0x6E341AEE);
					continue;
				case 4u:
					num = (int)((num2 * 1926452720) ^ 0x5C3B947);
					continue;
				case 3u:
					Form1.smethod_5((Control)(object)borderBox[num4, num5], Color.White);
					num = (int)((num2 * 320366117) ^ 0x36B06473);
					continue;
				case 2u:
					num = (int)(num2 * 270132901) ^ -1556086202;
					continue;
				case 1u:
					flag = num3 < 4;
					num = 2098860163;
					continue;
				case 0u:
					num = (int)((num2 * 621071950) ^ 0x50B4AAC7);
					continue;
				default:
					return;
				case 113u:
					break;
				case 101u:
					return;
					IL_02f1:
					num = 1631819232;
					num28 = 1631819232;
					continue;
					IL_0b38:
					flag14 = (byte)num44 != 0;
					num = 171039347;
					continue;
					IL_02fd:
					num = 2023320012;
					num28 = 2023320012;
					continue;
					IL_083d:
					flag5 = (byte)num15 != 0;
					num = 2077569676;
					continue;
					IL_01db:
					num = 954167605;
					num64 = 954167605;
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
		bool result = default(bool);
		bool flag = default(bool);
		while (true)
		{
			int num = 229859230;
			while (true)
			{
				uint num2;
				int num10;
				int num14;
				switch ((num2 = (uint)num ^ 0x6097E15Au) % 76u)
				{
				case 75u:
				{
					int num52;
					int num53;
					if (mem[num5, 2] != null)
					{
						num52 = 1535162460;
						num53 = 1535162460;
					}
					else
					{
						num52 = 362678099;
						num53 = 362678099;
					}
					num = num52 ^ ((int)num2 * -384895105);
					continue;
				}
				case 73u:
				{
					int num34;
					int num35;
					if (mem[0, num5].Big == mem[1, num5].Big)
					{
						num34 = 1783092029;
						num35 = 1783092029;
					}
					else
					{
						num34 = 1524789832;
						num35 = 1524789832;
					}
					num = num34 ^ ((int)num2 * -825271644);
					continue;
				}
				case 71u:
				{
					int num56;
					if (mem[0, num5].Point != mem[1, num5].Point)
					{
						num = 250317201;
						num56 = 250317201;
					}
					else
					{
						num = 77391086;
						num56 = 77391086;
					}
					continue;
				}
				case 70u:
				{
					int num43;
					int num44;
					if (mem[num5, 1].Dark == mem[num5, 2].Dark)
					{
						num43 = -1644391197;
						num44 = -1644391197;
					}
					else
					{
						num43 = -1253035145;
						num44 = -1253035145;
					}
					num = num43 ^ ((int)num2 * -1586624412);
					continue;
				}
				case 69u:
				{
					int num64;
					if (mem[num5, 0].Point == mem[num5, 1].Point)
					{
						num = 1068121522;
						num64 = 1068121522;
					}
					else
					{
						num = 1255338299;
						num64 = 1255338299;
					}
					continue;
				}
				case 68u:
				{
					int num6;
					int num7;
					if (mem[1, num5].Point == mem[2, num5].Point)
					{
						num6 = 991985539;
						num7 = 991985539;
					}
					else
					{
						num6 = 191766365;
						num7 = 191766365;
					}
					num = num6 ^ ((int)num2 * -555651169);
					continue;
				}
				case 67u:
				{
					int num38;
					int num39;
					if (mem[num5, 1] != null)
					{
						num38 = -161244663;
						num39 = -161244663;
					}
					else
					{
						num38 = -1583492482;
						num39 = -1583492482;
					}
					num = num38 ^ (int)(num2 * 1609966432);
					continue;
				}
				case 66u:
				{
					int num32;
					if (mem[0, 3].Point == mem[1, 2].Point)
					{
						num = 1534933966;
						num32 = 1534933966;
					}
					else
					{
						num = 237453978;
						num32 = 237453978;
					}
					continue;
				}
				case 65u:
					if (mem[2, 1].Big != mem[3, 0].Big)
					{
						num = ((int)num2 * -1821698546) ^ -1580924852;
						continue;
					}
					goto IL_01fe;
				case 64u:
				{
					int num50;
					int num51;
					if (mem[1, 2].Point == mem[2, 1].Point)
					{
						num50 = -12820663;
						num51 = -12820663;
					}
					else
					{
						num50 = -1482520810;
						num51 = -1482520810;
					}
					num = num50 ^ (int)(num2 * 722276711);
					continue;
				}
				case 63u:
				{
					int num28;
					int num29;
					if (mem[0, 3].Big != mem[1, 2].Big)
					{
						num28 = -1206189546;
						num29 = -1206189546;
					}
					else
					{
						num28 = -70898351;
						num29 = -70898351;
					}
					num = num28 ^ ((int)num2 * -2059029188);
					continue;
				}
				case 62u:
				{
					int num21;
					int num22;
					if (mem[num5, 0].Big == mem[num5, 1].Big)
					{
						num21 = -1620632119;
						num22 = -1620632119;
					}
					else
					{
						num21 = -1100644501;
						num22 = -1100644501;
					}
					num = num21 ^ ((int)num2 * -913715001);
					continue;
				}
				case 61u:
					if (mem[num5, 2].Dark != mem[num5, 3].Dark)
					{
						num = (int)((num2 * 2043848849) ^ 0x2FA27E5E);
						continue;
					}
					goto IL_030c;
				case 60u:
					if (mem[0, 3].Square == mem[1, 2].Square)
					{
						num = 664562813;
						continue;
					}
					goto IL_0342;
				case 59u:
					if (mem[0, num5].Square == mem[1, num5].Square)
					{
						num = 192471045;
						continue;
					}
					goto IL_0300;
				case 58u:
					if (mem[2, 2].Dark != mem[3, 3].Dark)
					{
						num = (int)((num2 * 1168850508) ^ 0x17E5BB9D);
						continue;
					}
					goto IL_03a0;
				case 57u:
					if (mem[num5, 2].Big != mem[num5, 3].Big)
					{
						num = ((int)num2 * -1248370988) ^ 0x3ADD1AAD;
						continue;
					}
					goto IL_030c;
				case 56u:
					flag2 = false;
					num5 = 0;
					num = (int)(num2 * 1089211008) ^ -67980598;
					continue;
				case 55u:
					if (mem[1, 2].Square == mem[2, 1].Square)
					{
						num = ((int)num2 * -1936591581) ^ 0x2B84D47C;
						continue;
					}
					goto IL_0342;
				case 54u:
				{
					int num40;
					if (mem[num5, 0] != null)
					{
						num = 39444145;
						num40 = 39444145;
					}
					else
					{
						num = 1098566494;
						num40 = 1098566494;
					}
					continue;
				}
				case 53u:
				{
					int num26;
					int num27;
					if (mem[2, 2] == null)
					{
						num26 = -460067099;
						num27 = -460067099;
					}
					else
					{
						num26 = -768827708;
						num27 = -768827708;
					}
					num = num26 ^ ((int)num2 * -224085891);
					continue;
				}
				case 52u:
				{
					int num23;
					if (mem[0, 3].Dark == mem[1, 2].Dark)
					{
						num = 1682495095;
						num23 = 1682495095;
					}
					else
					{
						num = 1480961592;
						num23 = 1480961592;
					}
					continue;
				}
				case 51u:
				{
					int num13;
					if (mem[0, 0].Point != mem[1, 1].Point)
					{
						num = 526382235;
						num13 = 526382235;
					}
					else
					{
						num = 343139256;
						num13 = 343139256;
					}
					continue;
				}
				case 50u:
					if (mem[0, 3] != null)
					{
						num = 451409020;
						continue;
					}
					goto IL_04fa;
				case 49u:
				{
					int num66;
					int num67;
					if (mem[1, 2].Dark != mem[2, 1].Dark)
					{
						num66 = 2077152933;
						num67 = 2077152933;
					}
					else
					{
						num66 = 1971648646;
						num67 = 1971648646;
					}
					num = num66 ^ ((int)num2 * -1141166799);
					continue;
				}
				case 48u:
				{
					int num60;
					int num61;
					if (mem[num5, 1].Square != mem[num5, 2].Square)
					{
						num60 = -1172923554;
						num61 = -1172923554;
					}
					else
					{
						num60 = -1237670228;
						num61 = -1237670228;
					}
					num = num60 ^ ((int)num2 * -1191743936);
					continue;
				}
				case 47u:
					if (mem[2, num5].Dark != mem[3, num5].Dark)
					{
						num = (int)((num2 * 1948768022) ^ 0x5E2F84F);
						continue;
					}
					goto IL_030c;
				case 46u:
				{
					int num57;
					int num58;
					if (mem[1, 1].Big != mem[2, 2].Big)
					{
						num57 = 227267684;
						num58 = 227267684;
					}
					else
					{
						num57 = 713785178;
						num58 = 713785178;
					}
					num = num57 ^ ((int)num2 * -1850935731);
					continue;
				}
				case 45u:
					if (mem[2, 2].Point != mem[3, 3].Point)
					{
						num = ((int)num2 * -2069478557) ^ 0x1D338B50;
						continue;
					}
					goto IL_03a0;
				case 44u:
				{
					int num48;
					int num49;
					if (mem[1, 1].Dark != mem[2, 2].Dark)
					{
						num48 = -1007428443;
						num49 = -1007428443;
					}
					else
					{
						num48 = -1244876744;
						num49 = -1244876744;
					}
					num = num48 ^ (int)(num2 * 1855925752);
					continue;
				}
				case 43u:
				{
					int num45;
					if (mem[num5, 0].Dark != mem[num5, 1].Dark)
					{
						num = 364414927;
						num45 = 364414927;
					}
					else
					{
						num = 467093764;
						num45 = 467093764;
					}
					continue;
				}
				case 42u:
					if (mem[num5, 2].Square != mem[num5, 3].Square)
					{
						num = (int)(num2 * 920772871) ^ -1460267292;
						continue;
					}
					goto IL_030c;
				case 41u:
					if (mem[3, 0] != null)
					{
						num = (int)((num2 * 2024238140) ^ 0x4E702F9D);
						continue;
					}
					goto IL_04fa;
				case 40u:
				{
					int num33;
					if (mem[0, 0].Dark != mem[1, 1].Dark)
					{
						num = 1238290949;
						num33 = 1238290949;
					}
					else
					{
						num = 1510537846;
						num33 = 1510537846;
					}
					continue;
				}
				case 39u:
				{
					int num30;
					int num31;
					if (mem[0, 0] == null)
					{
						num30 = 717549443;
						num31 = 717549443;
					}
					else
					{
						num30 = 199728479;
						num31 = 199728479;
					}
					num = num30 ^ ((int)num2 * -1027505939);
					continue;
				}
				case 38u:
				{
					int num17;
					int num18;
					if (mem[1, 1] != null)
					{
						num17 = 1226231635;
						num18 = 1226231635;
					}
					else
					{
						num17 = 442352344;
						num18 = 442352344;
					}
					num = num17 ^ (int)(num2 * 812743746);
					continue;
				}
				case 37u:
					if (mem[2, num5].Square != mem[3, num5].Square)
					{
						goto IL_0300;
					}
					goto IL_030c;
				case 36u:
					flag2 = true;
					num = (int)(num2 * 1021491777) ^ -2051569644;
					continue;
				case 35u:
				{
					int num11;
					if (num5 < 4)
					{
						num = 1318474456;
						num11 = 1318474456;
					}
					else
					{
						num = 1390251505;
						num11 = 1390251505;
					}
					continue;
				}
				case 34u:
					if (mem[3, num5] != null)
					{
						num = ((int)num2 * -1411250642) ^ -591160257;
						continue;
					}
					goto IL_0300;
				case 33u:
					num = 1647855642;
					continue;
				case 32u:
					num = ((int)num2 * -316809780) ^ 0x46DEFCE5;
					continue;
				case 31u:
					if (mem[2, 1].Point != mem[3, 0].Point)
					{
						num = ((int)num2 * -573125956) ^ 0x1FBF7C5E;
						continue;
					}
					goto IL_01fe;
				case 30u:
				{
					int num68;
					int num69;
					if (mem[1, 1].Point != mem[2, 2].Point)
					{
						num68 = -697288669;
						num69 = -697288669;
					}
					else
					{
						num68 = -2078371941;
						num69 = -2078371941;
					}
					num = num68 ^ ((int)num2 * -1191404004);
					continue;
				}
				case 29u:
				{
					int num65;
					if (mem[0, 0].Square == mem[1, 1].Square)
					{
						num = 1766174016;
						num65 = 1766174016;
					}
					else
					{
						num = 1659106764;
						num65 = 1659106764;
					}
					continue;
				}
				case 28u:
				{
					int num62;
					int num63;
					if (mem[num5, 1].Point == mem[num5, 2].Point)
					{
						num62 = 530285514;
						num63 = 530285514;
					}
					else
					{
						num62 = 1584205435;
						num63 = 1584205435;
					}
					num = num62 ^ ((int)num2 * -1176453368);
					continue;
				}
				case 27u:
					num10 = ((mem[2, 1].Square == mem[3, 0].Square) ? 1 : 0);
					goto IL_01ff;
				case 26u:
					if (mem[1, 2] != null)
					{
						num = ((int)num2 * -1993398405) ^ 0x313F0C69;
						continue;
					}
					goto IL_04fa;
				case 25u:
				{
					int num59;
					if (mem[num5, 0].Square == mem[num5, 1].Square)
					{
						num = 126237210;
						num59 = 126237210;
					}
					else
					{
						num = 1098566494;
						num59 = 1098566494;
					}
					continue;
				}
				case 24u:
					if (mem[2, num5] != null)
					{
						num = ((int)num2 * -1249443091) ^ 0x691D1B1C;
						continue;
					}
					goto IL_0300;
				case 23u:
				{
					int num54;
					int num55;
					if (mem[1, 2].Big == mem[2, 1].Big)
					{
						num54 = -1168193433;
						num55 = -1168193433;
					}
					else
					{
						num54 = -1176552450;
						num55 = -1176552450;
					}
					num = num54 ^ ((int)num2 * -2059780924);
					continue;
				}
				case 22u:
					if (mem[2, num5].Big != mem[3, num5].Big)
					{
						num = (int)(num2 * 1973195749) ^ -1753395706;
						continue;
					}
					goto IL_030c;
				case 21u:
					if (mem[1, num5] != null)
					{
						num = (int)((num2 * 1171453757) ^ 0x60317083);
						continue;
					}
					goto IL_0300;
				case 20u:
					if (mem[2, 2].Square != mem[3, 3].Square)
					{
						num = (int)(num2 * 1565001952) ^ -194213300;
						continue;
					}
					goto IL_03a0;
				case 19u:
				{
					int num46;
					int num47;
					if (mem[num5, 3] == null)
					{
						num46 = 345179662;
						num47 = 345179662;
					}
					else
					{
						num46 = 974705700;
						num47 = 974705700;
					}
					num = num46 ^ ((int)num2 * -939517456);
					continue;
				}
				case 18u:
				{
					int num41;
					int num42;
					if (mem[1, 1].Square != mem[2, 2].Square)
					{
						num41 = 1289035510;
						num42 = 1289035510;
					}
					else
					{
						num41 = 1161491524;
						num42 = 1161491524;
					}
					num = num41 ^ ((int)num2 * -1940604463);
					continue;
				}
				case 17u:
				{
					int num36;
					int num37;
					if (mem[1, num5].Dark != mem[2, num5].Dark)
					{
						num36 = 566512334;
						num37 = 566512334;
					}
					else
					{
						num36 = 1819134502;
						num37 = 1819134502;
					}
					num = num36 ^ ((int)num2 * -706534185);
					continue;
				}
				case 16u:
					if (mem[num5, 2].Point != mem[num5, 3].Point)
					{
						num = ((int)num2 * -1055314567) ^ -115222933;
						continue;
					}
					goto IL_030c;
				case 15u:
					if (mem[1, num5].Square == mem[2, num5].Square)
					{
						num = ((int)num2 * -629023220) ^ -102195205;
						continue;
					}
					goto IL_0300;
				case 14u:
					if (mem[2, 2].Big != mem[3, 3].Big)
					{
						num = ((int)num2 * -1000803782) ^ -347307154;
						continue;
					}
					goto IL_03a0;
				case 13u:
					if (mem[2, num5].Point != mem[3, num5].Point)
					{
						num = (int)((num2 * 120898252) ^ 0x3FA9D32D);
						continue;
					}
					goto IL_030c;
				case 12u:
					if (mem[0, num5] != null)
					{
						num = 2001129735;
						continue;
					}
					goto IL_0300;
				case 11u:
				{
					int num24;
					int num25;
					if (mem[3, 3] == null)
					{
						num24 = 903706457;
						num25 = 903706457;
					}
					else
					{
						num24 = 1680422516;
						num25 = 1680422516;
					}
					num = num24 ^ ((int)num2 * -913621229);
					continue;
				}
				case 10u:
					num = (int)((num2 * 1083700806) ^ 0x11E8DB76);
					continue;
				case 9u:
				{
					int num19;
					int num20;
					if (mem[num5, 1].Big != mem[num5, 2].Big)
					{
						num19 = -2019307589;
						num20 = -2019307589;
					}
					else
					{
						num19 = -1562233259;
						num20 = -1562233259;
					}
					num = num19 ^ ((int)num2 * -516847246);
					continue;
				}
				case 8u:
					flag2 = true;
					num = (int)(num2 * 140052489) ^ -1390180677;
					continue;
				case 7u:
				{
					int num15;
					int num16;
					if (mem[0, 0].Big != mem[1, 1].Big)
					{
						num15 = -180712843;
						num16 = -180712843;
					}
					else
					{
						num15 = -1387216013;
						num16 = -1387216013;
					}
					num = num15 ^ ((int)num2 * -766916731);
					continue;
				}
				case 6u:
				{
					int num12;
					if (mem[0, num5].Dark != mem[1, num5].Dark)
					{
						num = 539083541;
						num12 = 539083541;
					}
					else
					{
						num = 1606467527;
						num12 = 1606467527;
					}
					continue;
				}
				case 5u:
					if (mem[2, 1].Dark != mem[3, 0].Dark)
					{
						num = (int)(num2 * 1971157264) ^ -109092056;
						continue;
					}
					goto IL_01fe;
				case 4u:
					num5++;
					num = (int)(num2 * 1812267241) ^ -2100340379;
					continue;
				case 3u:
				{
					int num8;
					int num9;
					if (mem[1, num5].Big != mem[2, num5].Big)
					{
						num8 = 1409557211;
						num9 = 1409557211;
					}
					else
					{
						num8 = 1233033295;
						num9 = 1233033295;
					}
					num = num8 ^ (int)(num2 * 1777366013);
					continue;
				}
				case 2u:
					result = flag2;
					num = 449704368;
					continue;
				case 1u:
					if (mem[2, 1] != null)
					{
						num = (int)((num2 * 604409786) ^ 0x3291A0D9);
						continue;
					}
					goto IL_04fa;
				case 0u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = -107671782;
						num4 = -107671782;
					}
					else
					{
						num3 = -626075564;
						num4 = -626075564;
					}
					num = num3 ^ ((int)num2 * -75321614);
					continue;
				}
				case 74u:
					break;
				default:
					{
						return result;
					}
					IL_04fa:
					num10 = 0;
					goto IL_01ff;
					IL_030c:
					num = 465089274;
					num14 = 465089274;
					continue;
					IL_01ff:
					flag = (byte)num10 != 0;
					num = 1563936958;
					continue;
					IL_01fe:
					num10 = 1;
					goto IL_01ff;
					IL_03a0:
					num10 = 1;
					goto IL_01ff;
					IL_0300:
					num = 1288009243;
					num14 = 1288009243;
					continue;
					IL_0342:
					num10 = 0;
					goto IL_01ff;
				}
				break;
			}
		}
	}

	private bool Standoff(Figurine[,] mem)
	{
		int num6 = default(int);
		bool flag3 = default(bool);
		int num5 = default(int);
		bool flag2 = default(bool);
		bool result = default(bool);
		bool flag = default(bool);
		while (true)
		{
			int num = 566344004;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xCD674B4u) % 15u)
				{
				case 14u:
				{
					int num9;
					if (num6 < 4)
					{
						num = 1326531519;
						num9 = 1326531519;
					}
					else
					{
						num = 1124323716;
						num9 = 1124323716;
					}
					continue;
				}
				case 13u:
					flag3 = num5 < 4;
					num = 1924174612;
					continue;
				case 12u:
					flag2 = false;
					num = (int)(num2 * 1847274551) ^ -1662199056;
					continue;
				case 10u:
					num5++;
					num = ((int)num2 * -2021679060) ^ -770600981;
					continue;
				case 9u:
					result = flag2;
					num = (int)((num2 * 1878850378) ^ 0x7D7EAF87);
					continue;
				case 8u:
					num = ((int)num2 * -400274741) ^ -695011606;
					continue;
				case 7u:
					num = (int)(num2 * 836149322) ^ -728304304;
					continue;
				case 5u:
					num6 = 0;
					num = 922833148;
					continue;
				case 4u:
				{
					int num7;
					int num8;
					if (flag3)
					{
						num7 = -309558871;
						num8 = -309558871;
					}
					else
					{
						num7 = -1372206340;
						num8 = -1372206340;
					}
					num = num7 ^ ((int)num2 * -159142460);
					continue;
				}
				case 3u:
					flag2 = true;
					num5 = 0;
					num = ((int)num2 * -2034745564) ^ -2024739221;
					continue;
				case 2u:
					flag = mem[num5, num6] == null;
					num = 439563137;
					continue;
				case 1u:
					num6++;
					num = 194742656;
					continue;
				case 0u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = 1912723743;
						num4 = 1912723743;
					}
					else
					{
						num3 = 1936269251;
						num4 = 1936269251;
					}
					num = num3 ^ (int)(num2 * 1094745067);
					continue;
				}
				case 11u:
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
			int num = -1378949884;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x909B50CBu) % 9u)
				{
				case 8u:
					Form1.smethod_50((Control)(object)label5, (Form1.smethod_49((Control)(object)this) - (Form1.smethod_18((Control)(object)label5) + Form1.smethod_18((Control)(object)label6))) / 2);
					num = (int)(num2 * 1074196551) ^ -1933882731;
					continue;
				case 6u:
					num = (int)(num2 * 30733867) ^ -778357265;
					continue;
				case 5u:
					Form1.smethod_32((Control)(object)label6, str);
					num = ((int)num2 * -680595019) ^ 0x26FCB238;
					continue;
				case 4u:
					Form1.smethod_32((Control)(object)label1, "");
					num = ((int)num2 * -771054621) ^ -1366204107;
					continue;
				case 3u:
					Form1.smethod_32((Control)(object)label5, "Игрок: ");
					num = ((int)num2 * -581399764) ^ -142405943;
					continue;
				case 2u:
					Form1.smethod_50((Control)(object)label6, Form1.smethod_37((Control)(object)label5).X + Form1.smethod_18((Control)(object)label5));
					num = ((int)num2 * -1572279522) ^ 0x14F54B95;
					continue;
				case 1u:
					num = ((int)num2 * -1111766755) ^ -1403583630;
					continue;
				case 0u:
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
			int num = 1343501383;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0x697DDB1u) % 8u)
				{
				case 6u:
					if (disposing)
					{
						num = (int)((num2 * 38054210) ^ 0x5E309416);
						continue;
					}
					goto IL_0027;
				case 4u:
					Form1.smethod_51((IDisposable)components);
					num = ((int)num2 * -1121680915) ^ -1523219977;
					continue;
				case 3u:
					if (components != null)
					{
						num = 1956593025;
						num3 = 1956593025;
						continue;
					}
					goto IL_0027;
				case 2u:
					num = ((int)num2 * -1951743323) ^ 0x422CA602;
					continue;
				case 1u:
					num = (int)(num2 * 1197834117) ^ -1774244261;
					continue;
				case 0u:
					num = ((int)num2 * -671375702) ^ 0x7DF2379D;
					continue;
				case 5u:
					break;
				default:
					{
						((Form)this).Dispose(disposing);
						return;
					}
					IL_0027:
					num = 2101046638;
					num3 = 2101046638;
					continue;
				}
				break;
			}
		}
	}

	private void InitializeComponent()
	{
		//IL_065e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0668: Expected O, but got Unknown
		string string_ = default(string);
		byte[] array = default(byte[]);
		int num3 = default(int);
		while (true)
		{
			int num = -1639578293;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA23700F3u) % 139u)
				{
				case 138u:
					pictureBox1 = Form1.smethod_2();
					num = ((int)num2 * -912377687) ^ -448924158;
					continue;
				case 137u:
					Form1.smethod_87((Form)(object)this, (EventHandler)Form1_Load);
					num = (int)(num2 * 1199880242) ^ -332389931;
					continue;
				case 136u:
					string_ = Form1.smethod_34(string_, Veet.Zr);
					array = new byte[22528];
					num3 = 0;
					num = ((int)num2 * -902441648) ^ -305769817;
					continue;
				case 135u:
					num = (int)(num2 * 776788260) ^ -913268693;
					continue;
				case 134u:
					num = ((int)num2 * -75939510) ^ -1868572856;
					continue;
				case 133u:
					Form1.smethod_77((Control)(object)label6, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = ((int)num2 * -445517431) ^ -14778159;
					continue;
				case 132u:
					Form1.smethod_3((Control)(object)richTextBox1, new Size(272, 35));
					num = ((int)num2 * -605960078) ^ 0x10BB69E5;
					continue;
				case 131u:
					Form1.smethod_73(timer1, (EventHandler)Timer1_Tick);
					num = (int)(num2 * 1851414873) ^ -362329322;
					continue;
				case 130u:
					Form1.smethod_64((Control)(object)label2, 9);
					num = (int)(num2 * 502248114) ^ -1463691554;
					continue;
				case 129u:
					num = ((int)num2 * -621543) ^ -1871179954;
					continue;
				case 128u:
					Form1.smethod_88((Form)(object)this, (EventHandler)Form1_Shown);
					num = ((int)num2 * -1757201242) ^ 0x3DEF9198;
					continue;
				case 127u:
					Form1.smethod_92((Control)(object)this);
					num = (int)(num2 * 43982747) ^ -1382725318;
					continue;
				case 126u:
				{
					int num4;
					if (num3 >= 22528)
					{
						num = -1739724558;
						num4 = -1739724558;
					}
					else
					{
						num = -774927076;
						num4 = -774927076;
					}
					continue;
				}
				case 125u:
					label2 = Form1.smethod_57();
					num = ((int)num2 * -99738302) ^ 0x7BC5EBBA;
					continue;
				case 124u:
					num = (int)((num2 * 733450805) ^ 0x25AA7677);
					continue;
				case 123u:
					button1 = Form1.smethod_53();
					num = (int)((num2 * 738906535) ^ 0x614BBA29);
					continue;
				case 122u:
					Form1.smethod_32((Control)(object)richTextBox1, "");
					num = ((int)num2 * -1310627906) ^ 0x7834BCF2;
					continue;
				case 121u:
					num = ((int)num2 * -295971684) ^ -1523948625;
					continue;
				case 120u:
					num = ((int)num2 * -583010551) ^ 0x32C0ABF8;
					continue;
				case 119u:
					num = ((int)num2 * -706919334) ^ -816137003;
					continue;
				case 118u:
					label5 = Form1.smethod_57();
					label6 = Form1.smethod_57();
					num = (int)(num2 * 954843581) ^ -1537337323;
					continue;
				case 117u:
					num = ((int)num2 * -324130633) ^ -1257411683;
					continue;
				case 116u:
					num = (int)((num2 * 1275472405) ^ 0x66C22309);
					continue;
				case 115u:
					Form1.smethod_72(timer1, 1000);
					num = ((int)num2 * -561045776) ^ 0xCF98C6E;
					continue;
				case 114u:
					num = (int)(num2 * 2089483190) ^ -843581224;
					continue;
				case 113u:
					Form1.smethod_67((Control)(object)button2, (EventHandler)Button2_Click);
					num = ((int)num2 * -1573333477) ^ 0x45BAED8F;
					continue;
				case 112u:
					Form1.smethod_4((Control)(object)button2, new Point(391, 275));
					num = ((int)num2 * -500681845) ^ -628289107;
					continue;
				case 111u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)button2);
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)button1);
					num = ((int)num2 * -1527241475) ^ 0x1CC3EC6F;
					continue;
				case 110u:
					Form1.smethod_66((ButtonBase)(object)button2, bool_0: true);
					num = (int)((num2 * 494156206) ^ 0x23BD32DC);
					continue;
				case 109u:
					Form1.smethod_74((Control)(object)label5, bool_0: true);
					num = ((int)num2 * -894027462) ^ -1351119699;
					continue;
				case 108u:
					Form1.smethod_64((Control)(object)panel1, 7);
					num = ((int)num2 * -1599129016) ^ -384235441;
					continue;
				case 107u:
					num = ((int)num2 * -185544144) ^ 0x1B25EE99;
					continue;
				case 106u:
					string_ = Veet.Sa;
					num = ((int)num2 * -1951825163) ^ -938921653;
					continue;
				case 105u:
					Form1.smethod_89((Control)(object)this, (EventHandler)Form1_LocationChanged);
					Form1.smethod_90((ISupportInitialize)pictureBox1);
					Form1.smethod_91((Control)(object)this, bool_0: false);
					num = ((int)num2 * -1823492310) ^ 0x12E654AD;
					continue;
				case 104u:
					Form1.smethod_71((TextBoxBase)(object)richTextBox1, bool_0: true);
					num = (int)((num2 * 2140316337) ^ 0x1EAB3CA9);
					continue;
				case 103u:
					components = Form1.smethod_52();
					num = ((int)num2 * -697486171) ^ -189703477;
					continue;
				case 102u:
					num = ((int)num2 * -966990958) ^ -1837692622;
					continue;
				case 101u:
					Form1.smethod_85((Control)(object)this, "Form1");
					num = (int)(num2 * 643462117) ^ -494686716;
					continue;
				case 100u:
					num = (int)(num2 * 362298663) ^ -348421742;
					continue;
				case 99u:
					Form1.smethod_81((Form)(object)this, new Size(486, 319));
					num = (int)(num2 * 1076729378) ^ -695091973;
					continue;
				case 98u:
					num = (int)(num2 * 203586886) ^ -1789368940;
					continue;
				case 97u:
					num = (int)((num2 * 158283721) ^ 0x6408F53B);
					continue;
				case 96u:
					num3++;
					num = ((int)num2 * -732611868) ^ 0x1620EF92;
					continue;
				case 95u:
					Form1.smethod_77((Control)(object)label1, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = (int)((num2 * 1026670751) ^ 0x2857E082);
					continue;
				case 94u:
					Form1.smethod_74((Control)(object)label6, bool_0: true);
					num = ((int)num2 * -1433846800) ^ 0x6B108E23;
					continue;
				case 93u:
					num = (int)((num2 * 1258581319) ^ 0x11DDA3C4);
					continue;
				case 92u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)richTextBox1);
					num = (int)((num2 * 657242198) ^ 0x552C3324);
					continue;
				case 91u:
					num = ((int)num2 * -1833317791) ^ 0x411497DF;
					continue;
				case 90u:
					num = (int)((num2 * 430359562) ^ 0x7CE1E9D8);
					continue;
				case 89u:
					richTextBox1 = Form1.smethod_54();
					panel1 = Form1.smethod_55();
					num = ((int)num2 * -1712965501) ^ -2034912204;
					continue;
				case 88u:
					num = ((int)num2 * -1515464765) ^ 0x3A852C0E;
					continue;
				case 87u:
					Form1.smethod_3((Control)(object)label6, new Size(0, 16));
					num = (int)(num2 * 1505487510) ^ -639633918;
					continue;
				case 85u:
					Form1.smethod_61((Control)(object)button2, "button2");
					num = (int)((num2 * 798630342) ^ 0x583F2BBF);
					continue;
				case 84u:
					Form1.smethod_6((Control)(object)pictureBox1, new MouseEventHandler(PictureBox1_MouseDown));
					num = ((int)num2 * -1425843568) ^ -1259434781;
					continue;
				case 83u:
					Form1.smethod_32((Control)(object)button2, "Подтвердить");
					num = (int)(num2 * 335492400) ^ -583072914;
					continue;
				case 82u:
					Form1.smethod_83((Form)(object)this, (FormBorderStyle)1);
					num = ((int)num2 * -24742177) ^ -1528050683;
					continue;
				case 81u:
					Form1.smethod_79((ContainerControl)(object)this, new SizeF(6f, 13f));
					num = ((int)num2 * -430419008) ^ 0x3662B7B3;
					continue;
				case 80u:
					Form1.smethod_4((Control)(object)label2, new Point(0, 0));
					Form1.smethod_61((Control)(object)label2, "label2");
					num = ((int)num2 * -353411942) ^ -382398117;
					continue;
				case 79u:
					num = (int)((num2 * 402625532) ^ 0x1A47B1F5);
					continue;
				case 78u:
					Form1.smethod_61((Control)(object)panel1, "panel1");
					Form1.smethod_3((Control)(object)panel1, new Size(486, 240));
					num = (int)(num2 * 1018961749) ^ -649890109;
					continue;
				case 77u:
					num = (int)((num2 * 1307795303) ^ 0x52D07F7C);
					continue;
				case 76u:
					num = ((int)num2 * -1691128089) ^ 0x56939371;
					continue;
				case 75u:
					Form1.smethod_3((Control)(object)label1, new Size(0, 16));
					num = (int)(num2 * 1841088073) ^ -1251441652;
					continue;
				case 74u:
					timer1 = Form1.smethod_56(components);
					label1 = Form1.smethod_57();
					num = (int)(num2 * 1953370013) ^ -933226837;
					continue;
				case 73u:
					Form1.smethod_4((Control)(object)panel1, new Point(0, 24));
					num = (int)(num2 * 598629905) ^ -69289862;
					continue;
				case 72u:
					Form1.smethod_3((Control)(object)label2, new Size(0, 16));
					num = (int)(num2 * 740051699) ^ -1433365847;
					continue;
				case 71u:
					Form1.smethod_84((Form)(object)this, bool_0: false);
					num = ((int)num2 * -1255488992) ^ -681853872;
					continue;
				case 70u:
					string_ = Form1.smethod_34(string_, Veet.Xe);
					num = (int)(num2 * 747527020) ^ -405232329;
					continue;
				case 69u:
					Form1.smethod_63(pictureBox1, bool_0: false);
					num = ((int)num2 * -1213934028) ^ -470640768;
					continue;
				case 68u:
					Form1.smethod_77((Control)(object)label5, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = ((int)num2 * -1058867444) ^ 0x59C2C98C;
					continue;
				case 67u:
					num = ((int)num2 * -1027966601) ^ -1844533213;
					continue;
				case 66u:
					button2 = Form1.smethod_53();
					num = (int)((num2 * 1697002226) ^ 0xC03DF2);
					continue;
				case 65u:
					Form1.smethod_4((Control)(object)richTextBox1, new Point(107, 275));
					num = ((int)num2 * -1053818095) ^ 0x607C9E7E;
					continue;
				case 64u:
					Form1.smethod_65((Control)(object)button1, bool_0: false);
					Form1.smethod_32((Control)(object)button1, "Меню");
					Form1.smethod_66((ButtonBase)(object)button1, bool_0: true);
					num = ((int)num2 * -1531228500) ^ -1484747663;
					continue;
				case 63u:
					Form1.smethod_65((Control)(object)button2, bool_0: false);
					num = ((int)num2 * -1676151118) ^ -1816382524;
					continue;
				case 62u:
					num = -1246084600;
					continue;
				case 61u:
					num = ((int)num2 * -1746863390) ^ 0x699106EF;
					continue;
				case 60u:
					Form1.smethod_5((Control)(object)richTextBox1, Color.White);
					num = (int)((num2 * 1267495717) ^ 0xD01E59E);
					continue;
				case 59u:
					array[num3] = Form1.smethod_69(Form1.smethod_68(string_, num3 * 2, 2), 16);
					num = ((int)num2 * -1593490257) ^ 0x5EBBB70;
					continue;
				case 58u:
					Form1.smethod_4((Control)(object)label5, new Point(197, 0));
					num = (int)(num2 * 1341089471) ^ -703281819;
					continue;
				case 57u:
					Form1.smethod_67((Control)(object)button1, (EventHandler)Button1_Click);
					num = (int)((num2 * 1655924788) ^ 0x4D3C19B6);
					continue;
				case 56u:
					Form1.smethod_78((Control)(object)label1, (RightToLeft)0);
					num = (int)((num2 * 2053025024) ^ 0x56737622);
					continue;
				case 55u:
					Form1.smethod_64((Control)(object)label5, 12);
					num = ((int)num2 * -489017222) ^ 0x33788CE;
					continue;
				case 54u:
					num = ((int)num2 * -1659715388) ^ -904982501;
					continue;
				case 53u:
					Form1.smethod_61((Control)(object)label1, "label1");
					num = ((int)num2 * -916417312) ^ -761184866;
					continue;
				case 52u:
					num = (int)((num2 * 862377260) ^ 0x27998D1A);
					continue;
				case 51u:
					num = ((int)num2 * -1293666712) ^ -1572381842;
					continue;
				case 50u:
					num = ((int)num2 * -1667802366) ^ 0x372AD60B;
					continue;
				case 49u:
					Form1.smethod_4((Control)(object)label1, new Point(486, 0));
					num = (int)(num2 * 1400216943) ^ -490001261;
					continue;
				case 48u:
					Form1.smethod_64((Control)(object)button2, 4);
					num = (int)((num2 * 1447318015) ^ 0xD2DA942);
					continue;
				case 47u:
					num = (int)((num2 * 1601319210) ^ 0x488C8533);
					continue;
				case 46u:
					num = ((int)num2 * -1498928928) ^ -500960982;
					continue;
				case 45u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)panel1);
					num = (int)(num2 * 439852414) ^ -2010159569;
					continue;
				case 44u:
					num = (int)(num2 * 314205955) ^ -1306373012;
					continue;
				case 43u:
					Form1.smethod_60(pictureBox1, (BorderStyle)2);
					Form1.smethod_4((Control)(object)pictureBox1, new Point(120, 22));
					Form1.smethod_61((Control)(object)pictureBox1, "pictureBox1");
					num = ((int)num2 * -1959124950) ^ -1187189795;
					continue;
				case 42u:
					Form1.smethod_61((Control)(object)label6, "label6");
					num = ((int)num2 * -48490605) ^ -1019499180;
					continue;
				case 41u:
					Form1.smethod_75((Control)(object)label1, (DockStyle)4);
					num = (int)((num2 * 1209611543) ^ 0x661291E4);
					continue;
				case 40u:
					num = (int)(num2 * 1653810574) ^ -1638551807;
					continue;
				case 39u:
					Form1.smethod_86((Form)(object)this, bool_0: false);
					Form1.smethod_32((Control)(object)this, "Quarto");
					num = (int)(num2 * 1015471684) ^ -1000127553;
					continue;
				case 38u:
					num = ((int)num2 * -1620048306) ^ 0x76D67954;
					continue;
				case 37u:
					num = (int)(num2 * 1092724317) ^ -586009189;
					continue;
				case 36u:
					Form1.smethod_61((Control)(object)richTextBox1, "richTextBox1");
					num = (int)((num2 * 1696792207) ^ 0x7970D81E);
					continue;
				case 35u:
					Form1.smethod_74((Control)(object)label1, bool_0: true);
					num = ((int)num2 * -946809686) ^ 0x3424E9E7;
					continue;
				case 34u:
					Form1.smethod_5((Control)(object)pictureBox1, Color.FromArgb(64, 32, 0));
					num = (int)((num2 * 785053973) ^ 0x53269E4D);
					continue;
				case 33u:
					num = ((int)num2 * -1543863098) ^ 0x52F37D18;
					continue;
				case 32u:
					num = (int)(num2 * 1923842703) ^ -718162987;
					continue;
				case 31u:
					num = ((int)num2 * -1094239447) ^ -1006599939;
					continue;
				case 30u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label6);
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label5);
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label2);
					num = ((int)num2 * -758960513) ^ 0x2E6A8026;
					continue;
				case 29u:
					Form1.smethod_59((Control)(object)this);
					num = (int)(num2 * 1154581443) ^ -1714598871;
					continue;
				case 28u:
					Form1.smethod_3((Control)(object)button1, new Size(83, 35));
					num = (int)(num2 * 2057830964) ^ -410946901;
					continue;
				case 27u:
					Form1.smethod_75((Control)(object)label2, (DockStyle)3);
					num = (int)((num2 * 98297792) ^ 0x254B84C9);
					continue;
				case 26u:
					Form1.smethod_3((Control)(object)pictureBox1, new Size(246, 246));
					num = (int)((num2 * 963490815) ^ 0x4AF520DD);
					continue;
				case 25u:
					Form1.smethod_62(pictureBox1, 0);
					num = (int)(num2 * 1767230393) ^ -1066289807;
					continue;
				case 24u:
					num = ((int)num2 * -1535629158) ^ -1691565946;
					continue;
				case 23u:
					Form1.smethod_65((Control)(object)richTextBox1, bool_0: false);
					num = ((int)num2 * -1916626109) ^ -317972534;
					continue;
				case 22u:
					num = (int)(num2 * 17841823) ^ -947218716;
					continue;
				case 21u:
					Form1.smethod_61((Control)(object)button1, "button1");
					num = ((int)num2 * -1694261125) ^ -1453384069;
					continue;
				case 20u:
					Form1.smethod_77((Control)(object)label2, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = ((int)num2 * -161017613) ^ 0x49AD7F15;
					continue;
				case 19u:
					Form1.smethod_4((Control)(object)label6, new Point(275, 0));
					num = ((int)num2 * -1763521930) ^ -1330231887;
					continue;
				case 18u:
					Form1.smethod_61((Control)(object)label5, "label5");
					Form1.smethod_3((Control)(object)label5, new Size(0, 16));
					num = ((int)num2 * -436002973) ^ 0x5855BF11;
					continue;
				case 17u:
					Form1.smethod_64((Control)(object)button1, 5);
					num = (int)(num2 * 688976432) ^ -2029349587;
					continue;
				case 16u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)pictureBox1);
					num = (int)(num2 * 765253526) ^ -1753751231;
					continue;
				case 15u:
					Form1.smethod_74((Control)(object)label2, bool_0: true);
					num = (int)((num2 * 1391032170) ^ 0x7F64FE58);
					continue;
				case 14u:
					num = (int)((num2 * 1458683117) ^ 0x67D0A238);
					continue;
				case 13u:
					Form1.smethod_58((ISupportInitialize)pictureBox1);
					num = ((int)num2 * -953674258) ^ -1630908249;
					continue;
				case 12u:
					Form1.smethod_80((ContainerControl)(object)this, (AutoScaleMode)1);
					Form1.smethod_5((Control)(object)this, Color.White);
					num = (int)(num2 * 316016279) ^ -1739796592;
					continue;
				case 11u:
					num = (int)((num2 * 1557830092) ^ 0x2CED63B4);
					continue;
				case 10u:
					Form1.smethod_64((Control)(object)label1, 8);
					num = (int)(num2 * 542254275) ^ -177978794;
					continue;
				case 9u:
					Form1.smethod_64((Control)(object)label6, 13);
					num = ((int)num2 * -1579368140) ^ 0x7714EB5C;
					continue;
				case 8u:
					num = ((int)num2 * -490096689) ^ 0x732D0C2A;
					continue;
				case 7u:
					Form1.smethod_3((Control)(object)button2, new Size(83, 35));
					num = ((int)num2 * -811575093) ^ 0x304755D0;
					continue;
				case 6u:
					CharArray(array, string.Empty);
					num = ((int)num2 * -97209643) ^ -1031406590;
					continue;
				case 5u:
					Form1.smethod_4((Control)(object)button1, new Point(12, 275));
					num = (int)(num2 * 1590504905) ^ -1565916485;
					continue;
				case 4u:
					num = ((int)num2 * -945546312) ^ -944831205;
					continue;
				case 3u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label1);
					num = ((int)num2 * -655867312) ^ 0x57074130;
					continue;
				case 1u:
					Form1.smethod_64((Control)(object)richTextBox1, 6);
					num = (int)((num2 * 337215610) ^ 0x2734C917);
					continue;
				case 0u:
				{
					object[] object_ = new object[3]
					{
						Player.MembershipCondition(0),
						Player.MembershipCondition(1),
						"Cytotechnologist"
					};
					Form1.smethod_70(ComMember, object_);
					num = (int)(num2 * 868257963) ^ -2006442615;
					continue;
				}
				default:
					return;
				case 2u:
					break;
				case 86u:
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
			int num = -1451798167;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB784E535u) % 3u)
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
				num = ((int)num2 * -122089491) ^ -744709568;
			}
		}
	}

	private static Assembly ContextAdd(byte[] Position)
	{
		Assembly result = default(Assembly);
		while (true)
		{
			int num = -1464436405;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8CD2E9E0u) % 3u)
				{
				case 1u:
					goto IL_0003;
				case 2u:
					break;
				default:
					return result;
				}
				break;
				IL_0003:
				result = Form1.smethod_94(Form1.smethod_93(), Position);
				num = ((int)num2 * -1544824852) ^ 0x6AF4EAEE;
			}
		}
	}

	private static void PerformTable(Assembly Q3)
	{
		while (true)
		{
			int num = 810627276;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7AFE632Cu) % 3u)
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
				num = ((int)num2 * -1769998757) ^ -1809050924;
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
