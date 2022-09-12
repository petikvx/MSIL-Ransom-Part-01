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
				int num = -232202971;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xC3F8A55Au) % 7u)
					{
					case 6u:
						Dark = copy.Dark;
						Big = copy.Big;
						num = (int)(num2 * 976624136) ^ -1217103875;
						continue;
					case 5u:
						num = ((int)num2 * -172840855) ^ 0x650B41E0;
						continue;
					case 4u:
						Point = copy.Point;
						num = ((int)num2 * -337620801) ^ 0x34D942E3;
						continue;
					case 1u:
						num = ((int)num2 * -1782630997) ^ -1452033846;
						continue;
					case 0u:
						Square = copy.Square;
						num = ((int)num2 * -1717059283) ^ 0x2ED3A632;
						continue;
					default:
						return;
					case 3u:
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
		//IL_021d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0227: Expected O, but got Unknown
		int num3 = default(int);
		int num4 = default(int);
		double num8 = default(double);
		bool flag = default(bool);
		while (true)
		{
			int num = -893426260;
			while (true)
			{
				uint num2;
				double num7;
				switch ((num2 = (uint)num ^ 0xD4C769ECu) % 28u)
				{
				case 27u:
					Form1.smethod_9(Form1.smethod_8((Control)(object)panel1), (Control)(object)borderBox[num3, num4]);
					num = (int)(num2 * 425400530) ^ -2121784073;
					continue;
				case 26u:
					num3++;
					num = (int)(num2 * 1800846714) ^ -2037040715;
					continue;
				case 25u:
					num = (int)(num2 * 761534313) ^ -1365709620;
					continue;
				case 24u:
					Form1.smethod_11((Control)(object)menu);
					num = (int)((num2 * 155431468) ^ 0x3F267B84);
					continue;
				case 23u:
					if (num4 >= 2)
					{
						num = (int)((num2 * 111320884) ^ 0x70F6FF9C);
						continue;
					}
					num7 = 0.0;
					goto IL_00bd;
				case 22u:
				{
					PictureBox[,] array2 = pictureBox;
					int num12 = num3;
					int num13 = num4;
					PictureBox obj2 = Form1.smethod_2();
					Form1.smethod_3((Control)(object)obj2, new Size(size - 8, size - 8));
					Form1.smethod_4((Control)(object)obj2, new Point(4 + (int)(((double)num4 + num8) * (double)size), 4 + num3 * size));
					Form1.smethod_5((Control)(object)obj2, Color.White);
					array2[num12, num13] = obj2;
					num = ((int)num2 * -382820288) ^ -1014572291;
					continue;
				}
				case 21u:
					InitializeComponent();
					num = (int)((num2 * 1136146844) ^ 0x7759E7DB);
					continue;
				case 20u:
					num = (int)((num2 * 688493880) ^ 0x37DA1A4E);
					continue;
				case 19u:
					flag = num4 < 4;
					num = -1808216889;
					continue;
				case 18u:
					num = -591746073;
					continue;
				case 17u:
					num = (int)(num2 * 351418081) ^ -668630910;
					continue;
				case 16u:
					num4 = 0;
					num = -15483672;
					continue;
				case 15u:
					num = ((int)num2 * -2066906422) ^ -1417817727;
					continue;
				case 13u:
				{
					int num11;
					if (num3 >= 4)
					{
						num = -1736480283;
						num11 = -1736480283;
					}
					else
					{
						num = -1740719248;
						num11 = -1740719248;
					}
					continue;
				}
				case 12u:
					borderBox = new PictureBox[4, 4];
					num3 = 0;
					num = ((int)num2 * -1211386214) ^ 0x750D7459;
					continue;
				case 11u:
					num4++;
					num = (int)((num2 * 1258285630) ^ 0x23097B6D);
					continue;
				case 9u:
					Form1.smethod_6((Control)(object)pictureBox[num3, num4], new MouseEventHandler(PictureBoxIJ_MouseDown));
					num = ((int)num2 * -387148276) ^ 0x5F7A025A;
					continue;
				case 8u:
					num7 = 4.1;
					goto IL_00bd;
				case 7u:
					Form1.smethod_1(richTextBox1, (HorizontalAlignment)2);
					num = (int)(num2 * 1567232751) ^ -484945785;
					continue;
				case 6u:
				{
					PictureBox[,] array = borderBox;
					int num9 = num3;
					int num10 = num4;
					PictureBox obj = Form1.smethod_2();
					Form1.smethod_3((Control)(object)obj, new Size(size - 2, size - 2));
					Form1.smethod_4((Control)(object)obj, new Point(1 + (int)(((double)num4 + num8) * (double)size), 1 + num3 * size));
					Form1.smethod_7((Control)(object)obj, bool_0: false);
					array[num9, num10] = obj;
					num = ((int)num2 * -2140872669) ^ 0x62DCA0CB;
					continue;
				}
				case 5u:
				{
					Form3 form_ = new Form3();
					Form1.smethod_10((Form)(object)form_, (Form)(object)this);
					menu = (Form)(object)form_;
					num = ((int)num2 * -1581287705) ^ 0x271FF3E3;
					continue;
				}
				case 4u:
					num = (int)((num2 * 1369821731) ^ 0x1A6ECE29);
					continue;
				case 3u:
				{
					int num5;
					int num6;
					if (flag)
					{
						num5 = 615605130;
						num6 = 615605130;
					}
					else
					{
						num5 = 457698926;
						num6 = 457698926;
					}
					num = num5 ^ ((int)num2 * -458938812);
					continue;
				}
				case 2u:
					pictureBox = new PictureBox[4, 4];
					num = ((int)num2 * -1633772239) ^ 0x12C4B1DE;
					continue;
				case 1u:
					Form1.smethod_9(Form1.smethod_8((Control)(object)panel1), (Control)(object)pictureBox[num3, num4]);
					num = ((int)num2 * -1473188497) ^ -1022867048;
					continue;
				case 0u:
					num = ((int)num2 * -1387478790) ^ -277581505;
					continue;
				default:
					return;
				case 10u:
					break;
				case 14u:
					return;
					IL_00bd:
					num8 = num7;
					num = -331439850;
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
			int num = -887203285;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x893BEDF0u) % 3u)
				{
				case 1u:
					goto IL_0033;
				default:
					return;
				case 0u:
					break;
				case 2u:
					return;
				}
				break;
				IL_0033:
				num = ((int)num2 * -1507327115) ^ -602819905;
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
		bool flag = default(bool);
		while (true)
		{
			int num = 1160082686;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x5A9E3B05u) % 8u)
				{
				case 7u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = -1908091292;
						num4 = -1908091292;
					}
					else
					{
						num3 = -1184930679;
						num4 = -1184930679;
					}
					num = num3 ^ (int)(num2 * 465627127);
					continue;
				}
				case 5u:
				{
					Form control_ = menu;
					Form1.smethod_17((Control)(object)control_, Form1.smethod_16((Control)(object)control_) + 5);
					num = 970516913;
					continue;
				}
				case 4u:
					num = ((int)num2 * -1602447813) ^ -1619093893;
					continue;
				case 3u:
					num = (int)((num2 * 1670565731) ^ 0x19C77216);
					continue;
				case 2u:
					flag = Form1.smethod_16((Control)(object)menu) < 296;
					num = 1723346154;
					continue;
				case 0u:
					Form1.smethod_14(menu);
					num = ((int)num2 * -1078128556) ^ -141033244;
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

	private void Form1_Load(object sender, EventArgs e)
	{
		int num6 = default(int);
		int num3 = default(int);
		bool flag = default(bool);
		bool flag2 = default(bool);
		while (true)
		{
			int num = 246082255;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8AF24D4u) % 19u)
				{
				case 18u:
					storage[num6, num3] = new Figurine(num6 < 2, num3 % 2 == 0, num3 < 2, num6 % 2 == 1);
					num = 497376536;
					continue;
				case 17u:
					flag = num3 < 4;
					num = 139019664;
					continue;
				case 16u:
					Form1.smethod_7((Control)(object)pictureBox[num6, num3], bool_0: false);
					num3++;
					num = ((int)num2 * -87716978) ^ -1881023771;
					continue;
				case 15u:
				{
					int num7;
					int num8;
					if (flag2)
					{
						num7 = -430926178;
						num8 = -430926178;
					}
					else
					{
						num7 = -224407532;
						num8 = -224407532;
					}
					num = num7 ^ ((int)num2 * -1351663086);
					continue;
				}
				case 14u:
					storage = new Figurine[4, 4];
					num6 = 0;
					num = (int)(num2 * 875796207) ^ -1004835612;
					continue;
				case 13u:
					num = (int)((num2 * 1071578353) ^ 0x7918DA17);
					continue;
				case 12u:
					num = (int)((num2 * 849405788) ^ 0x2CBED201);
					continue;
				case 11u:
					Paint_Storage();
					Form1.smethod_7((Control)(object)button2, bool_0: false);
					num = ((int)num2 * -871373746) ^ 0x3A85D3E0;
					continue;
				case 10u:
					board = new Figurine[4, 4];
					num = ((int)num2 * -1840116382) ^ 0x47BA72C0;
					continue;
				case 8u:
					Form1.smethod_5((Control)(object)borderBox[num6, num3], Color.White);
					num = (int)((num2 * 890049233) ^ 0x1B57D96A);
					continue;
				case 7u:
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: false);
					num = ((int)num2 * -402117603) ^ 0x39160FE7;
					continue;
				case 6u:
					Paint_Board();
					num = (int)((num2 * 188488496) ^ 0x488980FE);
					continue;
				case 5u:
					num = ((int)num2 * -1779064042) ^ -583430063;
					continue;
				case 3u:
					flag2 = num6 < 4;
					num = 1515883121;
					continue;
				case 2u:
					num6++;
					num = (int)(num2 * 1609081576) ^ -308996391;
					continue;
				case 1u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = 1165018524;
						num5 = 1165018524;
					}
					else
					{
						num4 = 1963403584;
						num5 = 1963403584;
					}
					num = num4 ^ ((int)num2 * -33948259);
					continue;
				}
				case 0u:
					num3 = 0;
					num = 1993131598;
					continue;
				default:
					return;
				case 9u:
					break;
				case 4u:
					return;
				}
				break;
			}
		}
	}

	private void Paint_Board()
	{
		Brush brush_ = default(Brush);
		int num4 = default(int);
		bool dark = default(bool);
		int num5 = default(int);
		bool flag2 = default(bool);
		bool big = default(bool);
		Graphics graphics_ = default(Graphics);
		bool flag = default(bool);
		float num13 = default(float);
		bool square = default(bool);
		float num3 = default(float);
		float num6 = default(float);
		float num7 = default(float);
		float num8 = default(float);
		while (true)
		{
			int num = -1742840780;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF1C23EF3u) % 38u)
				{
				case 37u:
					brush_ = Form1.smethod_25();
					num = ((int)num2 * -577010431) ^ 0x64FA763F;
					continue;
				case 36u:
				{
					int num18;
					if (num4 >= 4)
					{
						num = -1994577859;
						num18 = -1994577859;
					}
					else
					{
						num = -160789644;
						num18 = -160789644;
					}
					continue;
				}
				case 35u:
					num4++;
					num = -1760670257;
					continue;
				case 34u:
					dark = board[num5, num4].Dark;
					num = (int)(num2 * 429527321) ^ -470524378;
					continue;
				case 33u:
					flag2 = board[num5, num4] != null;
					num = ((int)num2 * -1915055409) ^ 0x2ED52408;
					continue;
				case 32u:
				{
					int num19;
					int num20;
					if (!big)
					{
						num19 = -1919010495;
						num20 = -1919010495;
					}
					else
					{
						num19 = -1036422491;
						num20 = -1036422491;
					}
					num = num19 ^ (int)(num2 * 773451880);
					continue;
				}
				case 31u:
					Form1.smethod_24(graphics_, Form1.smethod_23(), ((float)num4 + 0.05f) * (float)size, ((float)num5 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					num = -710246200;
					continue;
				case 30u:
					num = (int)((num2 * 847140567) ^ 0x35E877F1);
					continue;
				case 29u:
					num5 = 0;
					num = (int)((num2 * 992842515) ^ 0x481B4CB2);
					continue;
				case 28u:
					num = -2112021858;
					continue;
				case 27u:
					Form1.smethod_30((Control)(object)pictureBox1);
					num = ((int)num2 * -122805144) ^ 0xE89DF3A;
					continue;
				case 26u:
					num4 = 0;
					num = -1760670257;
					continue;
				case 25u:
					num = (int)(num2 * 1413856028) ^ -995318834;
					continue;
				case 24u:
					flag = num5 < 4;
					num = -1864757036;
					continue;
				case 22u:
					num5++;
					num = ((int)num2 * -125055116) ^ -2070174449;
					continue;
				case 20u:
					num13 = 0.7f;
					num = -324051699;
					continue;
				case 19u:
				{
					int num21;
					int num22;
					if (!square)
					{
						num21 = -503283585;
						num22 = -503283585;
					}
					else
					{
						num21 = -2117832297;
						num22 = -2117832297;
					}
					num = num21 ^ (int)(num2 * 1889408774);
					continue;
				}
				case 18u:
				{
					int num16;
					int num17;
					if (!flag2)
					{
						num16 = 1104496240;
						num17 = 1104496240;
					}
					else
					{
						num16 = 80083652;
						num17 = 80083652;
					}
					num = num16 ^ ((int)num2 * -381348943);
					continue;
				}
				case 17u:
				{
					int num14;
					int num15;
					if (flag)
					{
						num14 = 1031121712;
						num15 = 1031121712;
					}
					else
					{
						num14 = 461134675;
						num15 = 461134675;
					}
					num = num14 ^ (int)(num2 * 1655330671);
					continue;
				}
				case 16u:
					Form1.smethod_24(graphics_, brush_, num3 + (float)(num4 * size), num3 + (float)(num5 * size), num6, num6);
					num = -1117505368;
					continue;
				case 15u:
					num = ((int)num2 * -1034101680) ^ 0x1E1D547B;
					continue;
				case 14u:
					num13 = 1f;
					num = (int)((num2 * 606218996) ^ 0x553729AF);
					continue;
				case 13u:
					num7 = 1f - num13 * 0.4f / (float)Form1.smethod_27(2.0);
					num = -644305959;
					continue;
				case 12u:
					num7 = 1f - num13 * 0.9f / (float)Form1.smethod_27(2.0);
					num8 = (float)size * num13;
					num = -548837253;
					continue;
				case 11u:
					num6 = num8 * 0.9f / (float)Form1.smethod_27(2.0);
					square = board[num5, num4].Square;
					num = (int)(num2 * 84632575) ^ -66644791;
					continue;
				case 10u:
					brush_ = Form1.smethod_26();
					num = -1279221066;
					continue;
				case 9u:
					Form1.smethod_20(pictureBox1, (Image)(object)Form1.smethod_19(Form1.smethod_18((Control)(object)pictureBox1), Form1.smethod_16((Control)(object)pictureBox1)));
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox1));
					num = ((int)num2 * -178674481) ^ 0x7FBCF93D;
					continue;
				case 8u:
					num3 = (float)size * (num7 / 2f);
					num = ((int)num2 * -1934467373) ^ -154776304;
					continue;
				case 7u:
					big = board[num5, num4].Big;
					num = -1072275003;
					continue;
				case 6u:
				{
					int num11;
					int num12;
					if (board[num5, num4].Point)
					{
						num11 = 1931204802;
						num12 = 1931204802;
					}
					else
					{
						num11 = 1239537003;
						num12 = 1239537003;
					}
					num = num11 ^ (int)(num2 * 1470478765);
					continue;
				}
				case 5u:
				{
					int num9;
					int num10;
					if (dark)
					{
						num9 = 1598377040;
						num10 = 1598377040;
					}
					else
					{
						num9 = 1046150817;
						num10 = 1046150817;
					}
					num = num9 ^ ((int)num2 * -1806754606);
					continue;
				}
				case 4u:
					num3 = (float)size * (num7 / 2f);
					num6 = num8 * 0.4f / (float)Form1.smethod_27(2.0);
					num = (int)(num2 * 167919291) ^ -2051122099;
					continue;
				case 3u:
					num = ((int)num2 * -1827309138) ^ 0x17419591;
					continue;
				case 2u:
					num = ((int)num2 * -1668382081) ^ -2141412040;
					continue;
				case 1u:
					Form1.smethod_24(graphics_, (Brush)(object)Form1.smethod_29(Color.FromArgb(180, Color.Peru)), num3 + (float)(num4 * size), num3 + (float)(num5 * size), num6, num6);
					num = ((int)num2 * -565272723) ^ 0x4B82C34D;
					continue;
				case 0u:
					Form1.smethod_28(graphics_, brush_, num3 + (float)(num4 * size), num3 + (float)(num5 * size), num6, num6);
					num = (int)((num2 * 1045175013) ^ 0x2FECEFDB);
					continue;
				default:
					return;
				case 21u:
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
		bool flag2 = default(bool);
		Graphics graphics_ = default(Graphics);
		Brush brush_ = default(Brush);
		float num6 = default(float);
		float num7 = default(float);
		bool big = default(bool);
		int num5 = default(int);
		float num10 = default(float);
		float num9 = default(float);
		float num8 = default(float);
		bool flag = default(bool);
		bool dark = default(bool);
		bool flag3 = default(bool);
		while (true)
		{
			int num2;
			int num3;
			if (num >= 4)
			{
				num2 = -585129012;
				num3 = -585129012;
			}
			else
			{
				num2 = -2083733981;
				num3 = -2083733981;
			}
			while (true)
			{
				uint num4;
				switch ((num4 = (uint)num2 ^ 0xFBF77592u) % 36u)
				{
				case 35u:
				{
					int num21;
					int num22;
					if (flag2)
					{
						num21 = -249768704;
						num22 = -249768704;
					}
					else
					{
						num21 = -1497619556;
						num22 = -1497619556;
					}
					num2 = num21 ^ ((int)num4 * -1914950288);
					continue;
				}
				case 34u:
					Form1.smethod_28(graphics_, brush_, num6, num6, num7, num7);
					num2 = ((int)num4 * -1734649515) ^ -1259670297;
					continue;
				case 33u:
					big = storage[num, num5].Big;
					num2 = -354363;
					continue;
				case 32u:
					num2 = (int)(num4 * 1946516235) ^ -1137008214;
					continue;
				case 31u:
					num2 = -2083733981;
					continue;
				case 30u:
					num5++;
					num2 = -1269148868;
					continue;
				case 29u:
					num10 = 1f - num9 * 0.9f / (float)Form1.smethod_27(2.0);
					num8 = (float)size * num9;
					num2 = -268327478;
					continue;
				case 28u:
				{
					int num17;
					int num18;
					if (!storage[num, num5].Point)
					{
						num17 = 1583932122;
						num18 = 1583932122;
					}
					else
					{
						num17 = 664665446;
						num18 = 664665446;
					}
					num2 = num17 ^ ((int)num4 * -189839499);
					continue;
				}
				case 27u:
				{
					int num13;
					int num14;
					if (flag)
					{
						num13 = -947851936;
						num14 = -947851936;
					}
					else
					{
						num13 = -636713940;
						num14 = -636713940;
					}
					num2 = num13 ^ (int)(num4 * 973935908);
					continue;
				}
				case 26u:
					Form1.smethod_20(pictureBox[num, num5], (Image)(object)Form1.smethod_19(Form1.smethod_18((Control)(object)pictureBox[num, num5]), Form1.smethod_16((Control)(object)pictureBox[num, num5])));
					num2 = (int)(num4 * 2022585658) ^ -635011661;
					continue;
				case 25u:
					num9 = 1f;
					num2 = (int)((num4 * 913057357) ^ 0x7D95A1F6);
					continue;
				case 24u:
					brush_ = Form1.smethod_25();
					num2 = (int)(num4 * 225754156) ^ -1081540401;
					continue;
				case 23u:
				{
					int num19;
					int num20;
					if (dark)
					{
						num19 = 1262977372;
						num20 = 1262977372;
					}
					else
					{
						num19 = 31266686;
						num20 = 31266686;
					}
					num2 = num19 ^ ((int)num4 * -1713076046);
					continue;
				}
				case 22u:
					brush_ = Form1.smethod_26();
					num2 = -1798893457;
					continue;
				case 21u:
					num2 = ((int)num4 * -1849546152) ^ 0x77CCB18D;
					continue;
				case 20u:
					Form1.smethod_30((Control)(object)pictureBox[num, num5]);
					num2 = -2104375866;
					continue;
				case 19u:
					num2 = (int)((num4 * 1770674759) ^ 0x71ABD446);
					continue;
				case 18u:
					num7 = num8 * 0.9f / (float)Form1.smethod_27(2.0);
					num2 = (int)(num4 * 572805231) ^ -566907433;
					continue;
				case 17u:
					num++;
					num2 = ((int)num4 * -2131006686) ^ -1183304692;
					continue;
				case 16u:
					num6 = (float)size * (num10 / 2f) - 4f;
					num2 = (int)(num4 * 653951150) ^ -2061396316;
					continue;
				case 15u:
				{
					int num15;
					int num16;
					if (!big)
					{
						num15 = -1433580020;
						num16 = -1433580020;
					}
					else
					{
						num15 = -186675112;
						num16 = -186675112;
					}
					num2 = num15 ^ ((int)num4 * -549078827);
					continue;
				}
				case 14u:
					flag3 = num5 < 4;
					num2 = -1531039551;
					continue;
				case 13u:
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox[num, num5]));
					dark = storage[num, num5].Dark;
					num2 = (int)((num4 * 1358595684) ^ 0x6A4586F5);
					continue;
				case 12u:
					num2 = (int)((num4 * 567158139) ^ 0x2B34FAD0);
					continue;
				case 11u:
				{
					int num11;
					int num12;
					if (!flag3)
					{
						num11 = -235315595;
						num12 = -235315595;
					}
					else
					{
						num11 = -1299260470;
						num12 = -1299260470;
					}
					num2 = num11 ^ ((int)num4 * -1243753542);
					continue;
				}
				case 10u:
					flag2 = storage[num, num5] != null;
					num2 = -372175739;
					continue;
				case 9u:
					num9 = 0.7f;
					num2 = -71984605;
					continue;
				case 8u:
					num6 = (float)size * (num10 / 2f) - 4f;
					num2 = (int)(num4 * 402068153) ^ -920473689;
					continue;
				case 7u:
					num10 = 1f - num9 * 0.4f / (float)Form1.smethod_27(2.0);
					num2 = -130993986;
					continue;
				case 6u:
					Form1.smethod_24(graphics_, brush_, num6, num6, num7, num7);
					num2 = -507780267;
					continue;
				case 5u:
					num7 = num8 * 0.4f / (float)Form1.smethod_27(2.0);
					num2 = (int)((num4 * 1697549285) ^ 0x3AA1172F);
					continue;
				case 4u:
					Form1.smethod_24(graphics_, (Brush)(object)Form1.smethod_29(Color.FromArgb(180, Color.Peru)), num6, num6, num7, num7);
					num2 = ((int)num4 * -861842652) ^ 0x5E132292;
					continue;
				case 3u:
					flag = num5 < 2;
					num2 = ((int)num4 * -1414493857) ^ -2107780164;
					continue;
				case 1u:
					num5 = 0;
					num2 = -1269148868;
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

	public void StartGame()
	{
		int num7 = default(int);
		bool flag2 = default(bool);
		int num3 = default(int);
		int num9 = default(int);
		bool flag = default(bool);
		while (true)
		{
			int num = -378357979;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8ECB0D91u) % 30u)
				{
				case 29u:
					num7++;
					num = ((int)num2 * -669737280) ^ 0x6A51E810;
					continue;
				case 28u:
					Form1.smethod_32((Control)(object)label2, Form1.smethod_34("Ход: ", step.ToString()));
					num = -351953078;
					continue;
				case 27u:
					time = new DateTime(0L, DateTimeKind.Unspecified);
					num = ((int)num2 * -1396637750) ^ -1987116378;
					continue;
				case 26u:
				{
					int num5;
					int num6;
					if (!flag2)
					{
						num5 = -1781614070;
						num6 = -1781614070;
					}
					else
					{
						num5 = -2107955588;
						num6 = -2107955588;
					}
					num = num5 ^ ((int)num2 * -1803568827);
					continue;
				}
				case 25u:
					Form1.smethod_35(timer1, bool_0: true);
					num = (int)(num2 * 1885709510) ^ -456191611;
					continue;
				case 24u:
					Form1_Load(this, Form1.smethod_31());
					num = (int)((num2 * 230268364) ^ 0x34328C11);
					continue;
				case 23u:
					num3 = 0;
					num = -204380357;
					continue;
				case 22u:
					num = ((int)num2 * -1565854646) ^ 0x4FFA910A;
					continue;
				case 21u:
					num7 = 0;
					num = ((int)num2 * -1730773751) ^ 0x68685D8C;
					continue;
				case 20u:
					Form1.smethod_36(timer1);
					num = (int)(num2 * 605302004) ^ -216004449;
					continue;
				case 18u:
					num = ((int)num2 * -23289798) ^ -915622317;
					continue;
				case 17u:
					Form1.smethod_7((Control)(object)pictureBox[num7, num3], bool_0: true);
					num = -2022023337;
					continue;
				case 16u:
					num3++;
					num = ((int)num2 * -419652551) ^ 0x1A1E5A38;
					continue;
				case 15u:
					num9 = Form1.smethod_33(rnd, 4);
					num = -27436606;
					continue;
				case 14u:
					step = 1;
					num = ((int)num2 * -959119132) ^ -215227575;
					continue;
				case 13u:
				{
					int num10;
					int num11;
					if (!flag)
					{
						num10 = 1771216264;
						num11 = 1771216264;
					}
					else
					{
						num10 = 61737413;
						num11 = 61737413;
					}
					num = num10 ^ ((int)num2 * -500144848);
					continue;
				}
				case 12u:
					num = ((int)num2 * -139738705) ^ 0x4B842F2E;
					continue;
				case 11u:
					Form1.smethod_32((Control)(object)richTextBox1, "Ваш ход. Выберете фигуру, которой будет играть противник.");
					num = (int)(num2 * 1786900595) ^ -1633686024;
					continue;
				case 10u:
					step = 0;
					num = (int)(num2 * 1714430204) ^ -905643809;
					continue;
				case 9u:
				{
					int num8 = Form1.smethod_33(rnd, 4);
					Form1.smethod_5((Control)(object)borderBox[num9, num8], Color.Blue);
					num = (int)(num2 * 1094184442) ^ -385074554;
					continue;
				}
				case 8u:
					num = ((int)num2 * -588191403) ^ 0x3233CDE2;
					continue;
				case 7u:
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: true);
					num = (int)((num2 * 2065377209) ^ 0x573DDBFD);
					continue;
				case 6u:
					num = (int)(num2 * 1237159933) ^ -1727945583;
					continue;
				case 5u:
					flag2 = num7 < 4;
					num = -2016000965;
					continue;
				case 4u:
					num = (int)((num2 * 1282081017) ^ 0x11999947);
					continue;
				case 3u:
				{
					int num4;
					if (num3 < 4)
					{
						num = -270872728;
						num4 = -270872728;
					}
					else
					{
						num = -2120024362;
						num4 = -2120024362;
					}
					continue;
				}
				case 1u:
					Form1.smethod_32((Control)(object)richTextBox1, "Противник выбрал фигуру. Выберете поле на доске для установки этой фигуры.");
					num = ((int)num2 * -1616326861) ^ 0x5A9560EC;
					continue;
				case 0u:
					flag = turn;
					num = ((int)num2 * -813263407) ^ -987102200;
					continue;
				default:
					return;
				case 19u:
					break;
				case 2u:
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
			int num = 4315085;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x2A9714CCu) % 5u)
				{
				case 4u:
					num = (int)((num2 * 2130286242) ^ 0x3DB86460);
					continue;
				case 3u:
					Form1.smethod_32((Control)(object)label1, Form1.smethod_34("Время: ", time.ToString("HH:mm:ss")));
					num = ((int)num2 * -391162710) ^ -1006287359;
					continue;
				case 2u:
					time = time.AddSeconds(1.0);
					num = ((int)num2 * -1410638987) ^ -2112553388;
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
		//IL_022f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0245: Expected O, but got Unknown
		Point point = Form1.smethod_37((Control)((sender is PictureBox) ? sender : null));
		int num3 = default(int);
		int num6 = default(int);
		int num12 = default(int);
		bool flag2 = default(bool);
		int num4 = default(int);
		bool flag = default(bool);
		bool flag3 = default(bool);
		while (true)
		{
			int num = 1300350059;
			while (true)
			{
				uint num2;
				int num9;
				switch ((num2 = (uint)num ^ 0x5F00ADFFu) % 25u)
				{
				case 24u:
					num3 -= 4;
					num = (int)(num2 * 1046836050) ^ -1057543613;
					continue;
				case 23u:
					num6++;
					num = ((int)num2 * -50446470) ^ 0x8F2C5D4;
					continue;
				case 22u:
					num = (int)(num2 * 874825) ^ -1824461659;
					continue;
				case 21u:
					if (storage[num12, num3] != null)
					{
						num = 674754435;
						continue;
					}
					num9 = 0;
					goto IL_006e;
				case 20u:
				{
					int num10;
					int num11;
					if (flag2)
					{
						num10 = -1497943328;
						num11 = -1497943328;
					}
					else
					{
						num10 = -728506254;
						num11 = -728506254;
					}
					num = num10 ^ ((int)num2 * -496383013);
					continue;
				}
				case 18u:
					flag2 = num6 < 4;
					num = 2069100703;
					continue;
				case 17u:
					num6 = 0;
					num = (int)((num2 * 1989101916) ^ 0x70A1117A);
					continue;
				case 16u:
					Form1.smethod_7((Control)(object)button2, bool_0: true);
					Form1.smethod_32((Control)(object)richTextBox1, "Именно эта фигура? Если да - нажмите \"Подтвердить\".");
					num = ((int)num2 * -512686927) ^ 0x4593E656;
					continue;
				case 15u:
					num4 = 0;
					num = 638613071;
					continue;
				case 14u:
					Form1.smethod_5((Control)(object)borderBox[num6, num4], Color.White);
					num = 825768389;
					continue;
				case 13u:
					num4++;
					num = (int)((num2 * 1352326138) ^ 0x491DD76F);
					continue;
				case 12u:
					Form1.smethod_5((Control)(object)borderBox[num12, num3], Color.Red);
					num = ((int)num2 * -355935982) ^ 0x61282242;
					continue;
				case 11u:
					point = Form1.smethod_37((Control)((sender is PictureBox) ? sender : null));
					num3 = point.X / size;
					num = ((int)num2 * -579235196) ^ 0x41FADFA3;
					continue;
				case 10u:
					num12 = point.Y / size;
					num = (int)(num2 * 1956840093) ^ -836855203;
					continue;
				case 9u:
					num = (int)(num2 * 1348934601) ^ -2006567538;
					continue;
				case 8u:
					num = ((int)num2 * -1416113251) ^ 0x16A2DEE9;
					continue;
				case 7u:
				{
					int num13;
					int num14;
					if (flag)
					{
						num13 = -1657648040;
						num14 = -1657648040;
					}
					else
					{
						num13 = -1148702349;
						num14 = -1148702349;
					}
					num = num13 ^ ((int)num2 * -1054461591);
					continue;
				}
				case 6u:
					num = ((int)num2 * -2100254964) ^ -1987966604;
					continue;
				case 4u:
					num9 = ((Form1.smethod_40((Bitmap)Form1.smethod_21(pictureBox[num12, num3]), Form1.smethod_38(e), Form1.smethod_39(e)) != Color.FromArgb(0, 0, 0, 0)) ? 1 : 0);
					goto IL_006e;
				case 3u:
				{
					int num7;
					int num8;
					if (flag3)
					{
						num7 = 1918640650;
						num8 = 1918640650;
					}
					else
					{
						num7 = 817208710;
						num8 = 817208710;
					}
					num = num7 ^ (int)(num2 * 1553674067);
					continue;
				}
				case 2u:
				{
					int num5;
					if (num4 >= 4)
					{
						num = 1989880573;
						num5 = 1989880573;
					}
					else
					{
						num = 895446381;
						num5 = 895446381;
					}
					continue;
				}
				case 1u:
					flag = num3 > 1;
					num = ((int)num2 * -1725676678) ^ -1613796739;
					continue;
				case 0u:
					num = ((int)num2 * -193517202) ^ 0x4663F3D4;
					continue;
				default:
					return;
				case 5u:
					break;
				case 19u:
					return;
					IL_006e:
					flag3 = (byte)num9 != 0;
					num = 1281773914;
					continue;
				}
				break;
			}
		}
	}

	private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
	{
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Expected O, but got Unknown
		bool flag3 = default(bool);
		int num4 = default(int);
		bool flag = default(bool);
		int num3 = default(int);
		int num9 = default(int);
		int num8 = default(int);
		Graphics graphics_ = default(Graphics);
		bool flag2 = default(bool);
		while (true)
		{
			int num = 1689290291;
			while (true)
			{
				uint num2;
				int num10;
				switch ((num2 = (uint)num ^ 0x555B986Au) % 25u)
				{
				case 24u:
					Form1.smethod_30((Control)(object)pictureBox1);
					Form1.smethod_7((Control)(object)button2, bool_0: true);
					num = (int)((num2 * 1431884934) ^ 0x67B2CAB7);
					continue;
				case 23u:
					Paint_Board();
					num = (int)(num2 * 1435649126) ^ -157972272;
					continue;
				case 22u:
				{
					int num13;
					int num14;
					if (!flag3)
					{
						num13 = -153195850;
						num14 = -153195850;
					}
					else
					{
						num13 = -1785914694;
						num14 = -1785914694;
					}
					num = num13 ^ (int)(num2 * 315865069);
					continue;
				}
				case 21u:
					flag3 = num4 < 4;
					num = 21637486;
					continue;
				case 20u:
					num4 = 0;
					num = 374544449;
					continue;
				case 19u:
				{
					int num6;
					int num7;
					if (flag)
					{
						num6 = 519909226;
						num7 = 519909226;
					}
					else
					{
						num6 = 1681211454;
						num7 = 1681211454;
					}
					num = num6 ^ (int)(num2 * 1108235080);
					continue;
				}
				case 18u:
					num = ((int)num2 * -1445217070) ^ -1253603286;
					continue;
				case 17u:
					num3++;
					num = (int)(num2 * 1744098959) ^ -73759223;
					continue;
				case 16u:
					num4++;
					num = 374544449;
					continue;
				case 15u:
					num3 = 0;
					num = (int)((num2 * 202103286) ^ 0x6FAA82F5);
					continue;
				case 14u:
					flag = num3 < 4;
					num = 702793974;
					continue;
				case 13u:
					num9 = Form1.smethod_38(e) / size;
					num8 = Form1.smethod_39(e) / size;
					if (Form1.smethod_40((Bitmap)Form1.smethod_21(pictureBox1), Form1.smethod_38(e), Form1.smethod_39(e)) != Color.FromArgb(0, 0, 0, 0))
					{
						num = ((int)num2 * -1901446963) ^ -1134353137;
						continue;
					}
					num10 = 0;
					goto IL_0179;
				case 12u:
					Form1.smethod_45(graphics_);
					num = ((int)num2 * -130177247) ^ 0x2387E68C;
					continue;
				case 11u:
					Form1.smethod_32((Control)(object)richTextBox1, "Уверены? Для выполнения данного хода нажмите \"Подтвердить\".");
					num = ((int)num2 * -1040439453) ^ -1889918123;
					continue;
				case 10u:
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox1));
					num = ((int)num2 * -1225177859) ^ 0x261B6A7;
					continue;
				case 9u:
					num = ((int)num2 * -938441435) ^ -370031393;
					continue;
				case 7u:
				{
					int num11;
					int num12;
					if (!flag2)
					{
						num11 = 546066950;
						num12 = 546066950;
					}
					else
					{
						num11 = 1620651629;
						num12 = 1620651629;
					}
					num = num11 ^ ((int)num2 * -406709912);
					continue;
				}
				case 5u:
					num = ((int)num2 * -114566327) ^ 0x2EA90AAC;
					continue;
				case 4u:
					num = (int)((num2 * 1825205726) ^ 0x77688391);
					continue;
				case 3u:
					num = (int)(num2 * 1640336183) ^ -935274436;
					continue;
				case 2u:
					Form1.smethod_43(graphics_, Form1.smethod_42(Color.Red, 3f), ((float)num9 + 0.05f) * (float)size, ((float)num8 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					Form1.smethod_44(graphics_, Form1.smethod_21(pictureBox[num3, num4]), num9 * size + 4, num8 * size + 4, new Rectangle(0, 0, size, size), (GraphicsUnit)2);
					num = (int)((num2 * 1871224875) ^ 0x7A978546);
					continue;
				case 1u:
					num10 = ((board[num8, num9] == null) ? 1 : 0);
					goto IL_0179;
				case 0u:
				{
					int num5;
					if (Form1.smethod_41((Control)(object)borderBox[num3, num4]) == Color.Blue)
					{
						num = 1985504637;
						num5 = 1985504637;
					}
					else
					{
						num = 1038476017;
						num5 = 1038476017;
					}
					continue;
				}
				default:
					return;
				case 8u:
					break;
				case 6u:
					return;
					IL_0179:
					flag2 = (byte)num10 != 0;
					num = 557188589;
					continue;
				}
				break;
			}
		}
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Expected O, but got Unknown
		Graphics graphics_ = default(Graphics);
		int num5 = default(int);
		int num16 = default(int);
		bool flag5 = default(bool);
		int num27 = default(int);
		int num28 = default(int);
		bool flag11 = default(bool);
		int num23 = default(int);
		bool flag4 = default(bool);
		int num47 = default(int);
		Figurine[,] array = default(Figurine[,]);
		int num15 = default(int);
		int num44 = default(int);
		int num18 = default(int);
		int num10 = default(int);
		int num37 = default(int);
		int num36 = default(int);
		Figurine[,] array3 = default(Figurine[,]);
		int num19 = default(int);
		int num20 = default(int);
		bool flag16 = default(bool);
		int num29 = default(int);
		int num30 = default(int);
		bool flag13 = default(bool);
		bool flag6 = default(bool);
		bool flag9 = default(bool);
		int num7 = default(int);
		int num13 = default(int);
		Figurine[,] array2 = default(Figurine[,]);
		int num11 = default(int);
		int num12 = default(int);
		int num14 = default(int);
		bool flag14 = default(bool);
		bool flag15 = default(bool);
		bool flag12 = default(bool);
		bool flag3 = default(bool);
		bool flag2 = default(bool);
		bool flag10 = default(bool);
		bool flag8 = default(bool);
		bool flag7 = default(bool);
		bool flag = default(bool);
		while (true)
		{
			int num = 1487726203;
			while (true)
			{
				uint num2;
				int num24;
				int num60;
				int num55;
				int num17;
				switch ((num2 = (uint)num ^ 0x61463B57u) % 163u)
				{
				case 162u:
					Form1.smethod_43(graphics_, Form1.smethod_42(Color.LimeGreen, 3f), ((float)num5 + 0.05f) * (float)size, ((float)num16 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					num = (int)((num2 * 208099143) ^ 0x3204CA23);
					continue;
				case 161u:
					if (!flag5)
					{
						num = (int)(num2 * 445092853) ^ -632144691;
						continue;
					}
					goto IL_0085;
				case 160u:
					num16++;
					num = ((int)num2 * -1853054115) ^ 0x205E5E9C;
					continue;
				case 159u:
					Form1.smethod_30((Control)(object)richTextBox1);
					num = (int)(num2 * 1266940179) ^ -662466887;
					continue;
				case 158u:
					Form1.smethod_30((Control)(object)pictureBox[num27, num28]);
					num = (int)((num2 * 1858389767) ^ 0x3233BCFF);
					continue;
				case 157u:
					flag11 = num23 < 4;
					num = 805227026;
					continue;
				case 156u:
					num = 150577572;
					continue;
				case 155u:
					flag4 = Form1.smethod_40((Bitmap)Form1.smethod_21(pictureBox1), num23 * size + size / 2, (int)(((float)num47 + 0.05f) * (float)size)) == Color.FromArgb(255, 255, 0, 0);
					num = 1509472888;
					continue;
				case 154u:
					array = (Figurine[,])Form1.smethod_48((Array)board);
					array[num15, num44] = new Figurine(storage[num27, num28]);
					num18 = 0;
					num = ((int)num2 * -2129719566) ^ -1373531614;
					continue;
				case 153u:
					num = (int)(num2 * 1076685689) ^ -1590933812;
					continue;
				case 152u:
					Form1.smethod_7((Control)(object)button2, bool_0: false);
					num = ((int)num2 * -1765988609) ^ -1266190109;
					continue;
				case 151u:
					num10++;
					num = 337197372;
					continue;
				case 150u:
					Form1.smethod_7((Control)(object)pictureBox[num37, num36], bool_0: true);
					num = 1834085054;
					continue;
				case 149u:
					num10 = 0;
					num = 1848886731;
					continue;
				case 148u:
					num = (int)((num2 * 1675487212) ^ 0x65B7428A);
					continue;
				case 147u:
					if (!Stop(array3))
					{
						num = (int)(num2 * 58081882) ^ -920985188;
						continue;
					}
					num24 = 1;
					goto IL_025b;
				case 146u:
					num = (int)((num2 * 704166469) ^ 0x73398291);
					continue;
				case 145u:
					num = (int)((num2 * 883604539) ^ 0x7F4BA631);
					continue;
				case 144u:
					Form1.smethod_47(1000);
					num = (int)((num2 * 1268515396) ^ 0x44409376);
					continue;
				case 143u:
					num = (int)((num2 * 1973505413) ^ 0x70B5DCE0);
					continue;
				case 142u:
					if (storage[num19, num20] != null)
					{
						num = (int)((num2 * 1026589204) ^ 0x5E7B754C);
						continue;
					}
					num60 = 1;
					goto IL_02e2;
				case 141u:
					num36 = 0;
					num = 1745237408;
					continue;
				case 140u:
					num = 1253646694;
					continue;
				case 139u:
					flag16 = Form1.smethod_41((Control)(object)borderBox[num29, num30]) == Color.Red;
					num = ((int)num2 * -1263188321) ^ -1784842518;
					continue;
				case 138u:
					num = ((int)num2 * -1371096689) ^ -888537230;
					continue;
				case 137u:
					Form1.smethod_47(200);
					num = (int)((num2 * 783629657) ^ 0x39F62DC6);
					continue;
				case 136u:
					num = ((int)num2 * -435521281) ^ 0x2B6B5D15;
					continue;
				case 135u:
					num = (int)(num2 * 575403833) ^ -1007397328;
					continue;
				case 134u:
				{
					int num53;
					int num54;
					if (flag13)
					{
						num53 = 1928180954;
						num54 = 1928180954;
					}
					else
					{
						num53 = 1994169136;
						num54 = 1994169136;
					}
					num = num53 ^ ((int)num2 * -531078284);
					continue;
				}
				case 133u:
				{
					int num50;
					if (board[num16, num5] == null)
					{
						num = 1104807829;
						num50 = 1104807829;
					}
					else
					{
						num = 1473287664;
						num50 = 1473287664;
					}
					continue;
				}
				case 132u:
					num = ((int)num2 * -19765624) ^ 0x2E9EC3B8;
					continue;
				case 131u:
					num29++;
					num = ((int)num2 * -1593097779) ^ -2014399533;
					continue;
				case 130u:
					Form1.smethod_32((Control)(object)richTextBox1, "Подождите, компьютер делает свой ход.");
					num = (int)(num2 * 2035973015) ^ -1376128936;
					continue;
				case 129u:
					Form1.smethod_32((Control)(object)richTextBox1, "QUARTO! Компьютер выиграл!");
					num = 1533203763;
					continue;
				case 128u:
				{
					int num41;
					int num42;
					if (flag6)
					{
						num41 = -970787782;
						num42 = -970787782;
					}
					else
					{
						num41 = -497779871;
						num42 = -497779871;
					}
					num = num41 ^ (int)(num2 * 1163221944);
					continue;
				}
				case 127u:
					num = (int)((num2 * 627052260) ^ 0x59DDEA02);
					continue;
				case 126u:
					num = (int)((num2 * 998695740) ^ 0x2396E59A);
					continue;
				case 125u:
					board[num16, num5] = new Figurine(storage[num27, num28]);
					num = (int)(num2 * 685923187) ^ -182018495;
					continue;
				case 124u:
					flag9 = num36 < 4;
					num = 1424932715;
					continue;
				case 123u:
				{
					int num33;
					if (num18 < 4)
					{
						num = 842928639;
						num33 = 842928639;
					}
					else
					{
						num = 1372140113;
						num33 = 1372140113;
					}
					continue;
				}
				case 122u:
					num7++;
					num = ((int)num2 * -1460683178) ^ 0x2B7DE9C6;
					continue;
				case 121u:
					num = ((int)num2 * -1436353882) ^ -1253256625;
					continue;
				case 120u:
					flag5 = false;
					num = ((int)num2 * -680383466) ^ 0x18C8B9AB;
					continue;
				case 119u:
					num13 = 0;
					num = (int)(num2 * 1134772560) ^ -1839992817;
					continue;
				case 118u:
					num = 1473287664;
					continue;
				case 117u:
					Form1.smethod_32((Control)(object)richTextBox1, "Ничья!");
					num = (int)(num2 * 1795535327) ^ -1583317285;
					continue;
				case 116u:
					num23++;
					num = 1534112267;
					continue;
				case 115u:
					num24 = (Standoff(array3) ? 1 : 0);
					goto IL_025b;
				case 114u:
					array2 = (Figurine[,])Form1.smethod_48((Array)array);
					array2[num18, num10] = new Figurine(storage[num19, num20]);
					num = ((int)num2 * -152717165) ^ -986342983;
					continue;
				case 113u:
					board[num11, num12] = new Figurine(storage[num13, num14]);
					storage[num13, num14] = null;
					Paint_Board();
					num = ((int)num2 * -8952217) ^ -229057192;
					continue;
				case 112u:
				{
					int num6;
					if (num5 < 4)
					{
						num = 1541770747;
						num6 = 1541770747;
					}
					else
					{
						num = 87078785;
						num6 = 87078785;
					}
					continue;
				}
				case 111u:
					num = (int)((num2 * 1935545539) ^ 0x140A083D);
					continue;
				case 110u:
					num7 = 0;
					num = (int)(num2 * 381478398) ^ -1570851575;
					continue;
				case 109u:
				{
					int num66;
					int num67;
					if (!flag14)
					{
						num66 = -1734685324;
						num67 = -1734685324;
					}
					else
					{
						num66 = -1052772005;
						num67 = -1052772005;
					}
					num = num66 ^ (int)(num2 * 1479733513);
					continue;
				}
				case 108u:
					num = 1869020852;
					continue;
				case 107u:
					num30 = 0;
					num = 1394571303;
					continue;
				case 106u:
					num = ((int)num2 * -1716085817) ^ 0x53B1F39F;
					continue;
				case 105u:
					num28 = 0;
					num29 = 0;
					num = (int)(num2 * 1361574000) ^ -1230094754;
					continue;
				case 104u:
					num = (int)((num2 * 1968247252) ^ 0x6AE20C0C);
					continue;
				case 103u:
					flag13 = Form1.smethod_41((Control)(object)borderBox[num47, num23]) == Color.Blue;
					num = (int)(num2 * 1008340688) ^ -2028375322;
					continue;
				case 102u:
				{
					int num65;
					if (num29 >= 4)
					{
						num = 1834559871;
						num65 = 1834559871;
					}
					else
					{
						num = 1386444822;
						num65 = 1386444822;
					}
					continue;
				}
				case 101u:
					num = 189734234;
					continue;
				case 100u:
					num27 = num29;
					num28 = num30;
					num = (int)(num2 * 408171291) ^ -1614734844;
					continue;
				case 99u:
					array3 = (Figurine[,])Form1.smethod_48((Array)board);
					array3[num16, num5] = new Figurine(storage[num27, num28]);
					num = (int)((num2 * 1283834548) ^ 0x54679ABD);
					continue;
				case 98u:
					num5++;
					num = 1981003167;
					continue;
				case 97u:
					step++;
					num = 1393145166;
					continue;
				case 96u:
					num12 = 0;
					num47 = 0;
					num = ((int)num2 * -1403267645) ^ -1794162456;
					continue;
				case 95u:
					Form1.smethod_30((Control)(object)borderBox[num29, num30]);
					num = (int)(num2 * 158152968) ^ -1089095821;
					continue;
				case 94u:
					num20 = Form1.smethod_33(rnd, 4);
					num = ((int)num2 * -1270374868) ^ -747681770;
					continue;
				case 93u:
					num = (int)((num2 * 1624460350) ^ 0xCBAE0B);
					continue;
				case 92u:
					Form1.smethod_5((Control)(object)borderBox[num27, num28], Color.White);
					Form1.smethod_30((Control)(object)borderBox[num27, num28]);
					num = ((int)num2 * -1826503786) ^ -110311883;
					continue;
				case 91u:
					Form1.smethod_5((Control)(object)borderBox[num29, num30], Color.LimeGreen);
					num = (int)(num2 * 1239423883) ^ -1983857268;
					continue;
				case 90u:
					num36++;
					num = (int)(num2 * 177330020) ^ -315452934;
					continue;
				case 89u:
				{
					int num63;
					int num64;
					if (flag15)
					{
						num63 = 111626637;
						num64 = 111626637;
					}
					else
					{
						num63 = 1972856343;
						num64 = 1972856343;
					}
					num = num63 ^ (int)(num2 * 538665491);
					continue;
				}
				case 88u:
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox1));
					num = ((int)num2 * -791038525) ^ -996017271;
					continue;
				case 87u:
					num = (int)((num2 * 1166274563) ^ 0x47576010);
					continue;
				case 86u:
					num = ((int)num2 * -1634579152) ^ 0xA103120;
					continue;
				case 85u:
					Form1.smethod_15(timer1);
					num = 1461349739;
					continue;
				case 84u:
					Form1.smethod_43(graphics_, Form1.smethod_42(Color.LimeGreen, 3f), ((float)num44 + 0.05f) * (float)size, ((float)num15 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					Form1.smethod_44(graphics_, Form1.smethod_21(pictureBox[num27, num28]), num44 * size + 4, num15 * size + 4, new Rectangle(0, 0, size, size), (GraphicsUnit)2);
					num = ((int)num2 * -884362495) ^ 0x477A7EF5;
					continue;
				case 83u:
					Form1.smethod_30((Control)(object)pictureBox1);
					Form1.smethod_47(200);
					Form1.smethod_5((Control)(object)borderBox[num27, num28], Color.White);
					num = ((int)num2 * -1656818995) ^ -1784696481;
					continue;
				case 82u:
					num23 = 0;
					num = 1534112267;
					continue;
				case 81u:
					num37 = 0;
					num = (int)(num2 * 1882235902) ^ -108156123;
					continue;
				case 80u:
					if (num19 == num27)
					{
						num = (int)(num2 * 1593305548) ^ -241208577;
						continue;
					}
					num60 = 0;
					goto IL_02e2;
				case 79u:
					num = 434212672;
					continue;
				case 78u:
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: false);
					num = ((int)num2 * -1513624431) ^ 0x37CD1F3C;
					continue;
				case 77u:
					Form1.smethod_44(graphics_, Form1.smethod_21(pictureBox[num27, num28]), num5 * size + 4, num16 * size + 4, new Rectangle(0, 0, size, size), (GraphicsUnit)2);
					num = ((int)num2 * -732695455) ^ 0x2B373F9E;
					continue;
				case 76u:
					Form1.smethod_32((Control)(object)richTextBox1, "Выберете фигуру, которой будет играть противник.");
					num = (int)(num2 * 947906887) ^ -865294520;
					continue;
				case 75u:
					num55 = ((!Standoff(board)) ? 1 : 0);
					goto IL_0b45;
				case 74u:
					Form1.smethod_32((Control)(object)richTextBox1, "Ничья!");
					num = ((int)num2 * -1248531611) ^ 0x40F108C3;
					continue;
				case 73u:
				{
					int num61;
					int num62;
					if (flag12)
					{
						num61 = 1048842193;
						num62 = 1048842193;
					}
					else
					{
						num61 = 1040858071;
						num62 = 1040858071;
					}
					num = num61 ^ ((int)num2 * -419372072);
					continue;
				}
				case 72u:
					Form1.smethod_30((Control)(object)pictureBox1);
					num = (int)(num2 * 336427014) ^ -1644277805;
					continue;
				case 71u:
					num60 = ((num20 == num28) ? 1 : 0);
					goto IL_02e2;
				case 70u:
					num13 = num47;
					num14 = num23;
					Form1.smethod_5((Control)(object)borderBox[num47, num23], Color.White);
					num = ((int)num2 * -980706409) ^ 0x2BA6958F;
					continue;
				case 69u:
				{
					int num58;
					int num59;
					if (flag16)
					{
						num58 = -519093080;
						num59 = -519093080;
					}
					else
					{
						num58 = -1050032824;
						num59 = -1050032824;
					}
					num = num58 ^ (int)(num2 * 1933504804);
					continue;
				}
				case 68u:
					Form1.smethod_30((Control)(object)pictureBox[num47, num23]);
					num = ((int)num2 * -95454145) ^ -414295839;
					continue;
				case 67u:
					flag15 = num30 < 4;
					num = 337701312;
					continue;
				case 66u:
					flag14 = board[num15, num44] != null;
					num = (int)(num2 * 991380879) ^ -1453423986;
					continue;
				case 65u:
					num = (int)(num2 * 1354229610) ^ -239787150;
					continue;
				case 64u:
					num44 = Form1.smethod_33(rnd, 4);
					num = (int)(num2 * 97352238) ^ -561932660;
					continue;
				case 63u:
					num = ((int)num2 * -14983569) ^ -17483378;
					continue;
				case 62u:
				{
					int num56;
					int num57;
					if (!flag9)
					{
						num56 = -827533169;
						num57 = -827533169;
					}
					else
					{
						num56 = -1916185354;
						num57 = -1916185354;
					}
					num = num56 ^ (int)(num2 * 551309627);
					continue;
				}
				case 61u:
					if (!Stop(board))
					{
						num = ((int)num2 * -2116249773) ^ 0x2DE226B8;
						continue;
					}
					num55 = 0;
					goto IL_0b45;
				case 60u:
					num = ((int)num2 * -848524633) ^ 0x2853F04B;
					continue;
				case 59u:
					num18++;
					num = (int)((num2 * 1262508305) ^ 0x67EE64F5);
					continue;
				case 58u:
					Form1.smethod_30((Control)(object)borderBox[num47, num23]);
					Form1.smethod_20(pictureBox[num47, num23], (Image)null);
					num = ((int)num2 * -2039747279) ^ 0xED93F9C;
					continue;
				case 57u:
					flag3 = num47 < 4;
					num = 1187564742;
					continue;
				case 56u:
					storage[num27, num28] = null;
					num = (int)((num2 * 1782899366) ^ 0x70BAFC71);
					continue;
				case 55u:
				{
					int num51;
					int num52;
					if (!Standoff(board))
					{
						num51 = -1081240194;
						num52 = -1081240194;
					}
					else
					{
						num51 = -835308627;
						num52 = -835308627;
					}
					num = num51 ^ ((int)num2 * -620254918);
					continue;
				}
				case 54u:
					num37++;
					num = ((int)num2 * -968353188) ^ 0x6DE0A505;
					continue;
				case 53u:
					num = (int)((num2 * 961507285) ^ 0x2D04D9C);
					continue;
				case 52u:
					num = (int)((num2 * 1954755834) ^ 0x68B86137);
					continue;
				case 50u:
					num47++;
					num = ((int)num2 * -1451131194) ^ 0x604CD5AC;
					continue;
				case 49u:
					flag2 = Form1.smethod_46((Control)(object)pictureBox1);
					num = (int)((num2 * 70014273) ^ 0x378F8617);
					continue;
				case 48u:
					Form1.smethod_32((Control)(object)label2, Form1.smethod_34("Ход: ", step.ToString()));
					num = (int)((num2 * 704695263) ^ 0x2EEB20F);
					continue;
				case 47u:
					num = (int)(num2 * 505937532) ^ -2060438608;
					continue;
				case 46u:
					Form1.smethod_30((Control)(object)label2);
					num = ((int)num2 * -1860074797) ^ 0x1E86BA2;
					continue;
				case 45u:
					num14 = 0;
					num11 = 0;
					num = (int)(num2 * 368120386) ^ -1200827237;
					continue;
				case 44u:
					flag12 = num37 < 4;
					num = 1209685006;
					continue;
				case 43u:
					Form1.smethod_30((Control)(object)borderBox[num27, num28]);
					num = (int)((num2 * 1361072934) ^ 0x684925A4);
					continue;
				case 42u:
					Form1.smethod_20(pictureBox[num27, num28], (Image)null);
					num = (int)(num2 * 663872598) ^ -1294262437;
					continue;
				case 41u:
					flag10 = Standoff(board);
					num = 756374919;
					continue;
				case 40u:
				{
					int num48;
					int num49;
					if (!flag11)
					{
						num48 = 1614510164;
						num49 = 1614510164;
					}
					else
					{
						num48 = 1673493597;
						num49 = 1673493597;
					}
					num = num48 ^ ((int)num2 * -401488789);
					continue;
				}
				case 39u:
					num11 = num47;
					num12 = num23;
					num = (int)(num2 * 1077323275) ^ -1336314863;
					continue;
				case 38u:
					num5 = 0;
					num = 55998945;
					continue;
				case 37u:
				{
					int num45;
					int num46;
					if (!Stop(array2))
					{
						num45 = 787529245;
						num46 = 787529245;
					}
					else
					{
						num45 = 1139905621;
						num46 = 1139905621;
					}
					num = num45 ^ (int)(num2 * 910163216);
					continue;
				}
				case 36u:
					flag5 = true;
					num = (int)(num2 * 1163412386) ^ -1796506391;
					continue;
				case 35u:
					board[num15, num44] = new Figurine(storage[num27, num28]);
					num = (int)(num2 * 1727695473) ^ -1040617594;
					continue;
				case 34u:
					num30++;
					num = ((int)num2 * -1015632791) ^ 0x2AD3D486;
					continue;
				case 33u:
				{
					int num43;
					if (array[num18, num10] != null)
					{
						num = 1360402732;
						num43 = 1360402732;
					}
					else
					{
						num = 1436230161;
						num43 = 1436230161;
					}
					continue;
				}
				case 32u:
					num = 1360402732;
					continue;
				case 31u:
					num = (int)(num2 * 2022631700) ^ -658591106;
					continue;
				case 30u:
				{
					int num39;
					int num40;
					if (!flag10)
					{
						num39 = -870407731;
						num40 = -870407731;
					}
					else
					{
						num39 = -977008708;
						num40 = -977008708;
					}
					num = num39 ^ (int)(num2 * 1348357100);
					continue;
				}
				case 29u:
					(menu as Form3).ContinueLock();
					num = (int)(num2 * 1414200016) ^ -1656958888;
					continue;
				case 28u:
				{
					int num38;
					if (num10 >= 4)
					{
						num = 770266524;
						num38 = 770266524;
					}
					else
					{
						num = 1013503812;
						num38 = 1013503812;
					}
					continue;
				}
				case 27u:
				{
					int num34;
					int num35;
					if (flag8)
					{
						num34 = 800756315;
						num35 = 800756315;
					}
					else
					{
						num34 = 474876167;
						num35 = 474876167;
					}
					num = num34 ^ ((int)num2 * -506370315);
					continue;
				}
				case 26u:
					num = 1769905910;
					continue;
				case 25u:
					num19 = Form1.smethod_33(rnd, 4);
					num = (int)((num2 * 945846645) ^ 0x6AA8A23);
					continue;
				case 24u:
					Form1.smethod_30((Control)(object)pictureBox[num27, num28]);
					num = (int)(num2 * 954082819) ^ -183971417;
					continue;
				case 23u:
					num = ((int)num2 * -1621135918) ^ -107485387;
					continue;
				case 22u:
					num = ((int)num2 * -326052568) ^ -1722792098;
					continue;
				case 21u:
					num = ((int)num2 * -1601782757) ^ -1471835971;
					continue;
				case 20u:
				{
					int num31;
					int num32;
					if (!flag7)
					{
						num31 = -1743517383;
						num32 = -1743517383;
					}
					else
					{
						num31 = -813964712;
						num32 = -813964712;
					}
					num = num31 ^ ((int)num2 * -204921199);
					continue;
				}
				case 18u:
					num = ((int)num2 * -634863468) ^ -928600940;
					continue;
				case 17u:
					flag6 = num16 < 4;
					num = 152735862;
					continue;
				case 16u:
					Form1.smethod_7((Control)(object)pictureBox[num29, num30], bool_0: false);
					num = (int)(num2 * 444309199) ^ -1504861406;
					continue;
				case 15u:
					storage[num27, num28] = null;
					num = (int)(num2 * 1104316990) ^ -1291670498;
					continue;
				case 14u:
					Form1.smethod_15(timer1);
					(menu as Form3).ContinueLock();
					num = ((int)num2 * -936748658) ^ 0xF2DE5C0;
					continue;
				case 13u:
					num = ((int)num2 * -1449818498) ^ 0x75E135C5;
					continue;
				case 12u:
					num = ((int)num2 * -1411717802) ^ 0x7CFF06B3;
					continue;
				case 11u:
					num27 = 0;
					num = ((int)num2 * -1074263223) ^ 0x46B68880;
					continue;
				case 10u:
					Form1.smethod_20(pictureBox[num27, num28], (Image)null);
					num = (int)((num2 * 1768182658) ^ 0x79291E7F);
					continue;
				case 9u:
				{
					int num25;
					int num26;
					if (!flag4)
					{
						num25 = -998379840;
						num26 = -998379840;
					}
					else
					{
						num25 = -416993520;
						num26 = -416993520;
					}
					num = num25 ^ ((int)num2 * -128153837);
					continue;
				}
				case 8u:
					Form1.smethod_5((Control)(object)borderBox[num19, num20], Color.Blue);
					Form1.smethod_30((Control)(object)borderBox[num19, num20]);
					Form1.smethod_32((Control)(object)richTextBox1, "Противник сделал ход (зелёный). Выберете поле на доске для выбронной противником фигуры (синий).");
					num = ((int)num2 * -359295040) ^ 0x782D30FE;
					continue;
				case 7u:
				{
					int num21;
					int num22;
					if (!flag3)
					{
						num21 = 247737357;
						num22 = 247737357;
					}
					else
					{
						num21 = 1014113625;
						num22 = 1014113625;
					}
					num = num21 ^ ((int)num2 * -282073782);
					continue;
				}
				case 6u:
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: true);
					step++;
					Form1.smethod_32((Control)(object)label2, Form1.smethod_34("Ход: ", step.ToString()));
					num = (int)(num2 * 57684784) ^ -534959184;
					continue;
				case 5u:
					if (num7 >= 9)
					{
						num = 296592492;
						num17 = 296592492;
						continue;
					}
					goto IL_0085;
				case 4u:
					num16 = 0;
					num = (int)((num2 * 151642954) ^ 0x14F5565E);
					continue;
				case 3u:
					num15 = Form1.smethod_33(rnd, 4);
					num = 1726357166;
					continue;
				case 2u:
				{
					int num8;
					int num9;
					if (flag2)
					{
						num8 = 887928350;
						num9 = 887928350;
					}
					else
					{
						num8 = 1422524326;
						num9 = 1422524326;
					}
					num = num8 ^ (int)(num2 * 1600988860);
					continue;
				}
				case 1u:
					num = 2016704599;
					continue;
				case 0u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = 1504744532;
						num4 = 1504744532;
					}
					else
					{
						num3 = 769314638;
						num4 = 769314638;
					}
					num = num3 ^ ((int)num2 * -818679469);
					continue;
				}
				default:
					return;
				case 51u:
					break;
				case 19u:
					return;
					IL_0b45:
					flag7 = (byte)num55 != 0;
					num = 685374336;
					continue;
					IL_02e2:
					flag = (byte)num60 != 0;
					num = 1615342721;
					continue;
					IL_0085:
					num = 1680550893;
					num17 = 1680550893;
					continue;
					IL_025b:
					flag8 = (byte)num24 != 0;
					num = 113365981;
					continue;
				}
				break;
			}
		}
	}

	private bool Stop(Figurine[,] mem)
	{
		int num3 = default(int);
		bool flag2 = default(bool);
		bool result = default(bool);
		bool flag = default(bool);
		while (true)
		{
			int num = -130655219;
			while (true)
			{
				uint num2;
				int num21;
				int num6;
				switch ((num2 = (uint)num ^ 0xC4225BF3u) % 77u)
				{
				case 76u:
					if (mem[2, 2].Point != mem[3, 3].Point)
					{
						num = (int)((num2 * 909584405) ^ 0x3E7FE2B);
						continue;
					}
					goto IL_0044;
				case 75u:
					num3++;
					num = (int)(num2 * 1338298841) ^ -730380474;
					continue;
				case 74u:
				{
					int num38;
					if (mem[0, 0].Square == mem[1, 1].Square)
					{
						num = -1049800041;
						num38 = -1049800041;
					}
					else
					{
						num = -602021855;
						num38 = -602021855;
					}
					continue;
				}
				case 73u:
					if (mem[num3, 2].Big != mem[num3, 3].Big)
					{
						num = (int)(num2 * 2035365492) ^ -1823658803;
						continue;
					}
					goto IL_00d2;
				case 72u:
					if (mem[0, 3] != null)
					{
						num = -2007573901;
						continue;
					}
					goto IL_0038;
				case 71u:
					if (mem[2, num3] != null)
					{
						num = ((int)num2 * -492720181) ^ 0x118A2926;
						continue;
					}
					goto IL_0115;
				case 70u:
				{
					int num24;
					int num25;
					if (mem[num3, 1] == null)
					{
						num24 = -1262338402;
						num25 = -1262338402;
					}
					else
					{
						num24 = -2061110309;
						num25 = -2061110309;
					}
					num = num24 ^ ((int)num2 * -557888801);
					continue;
				}
				case 69u:
					if (mem[2, num3].Big != mem[3, num3].Big)
					{
						num = (int)(num2 * 2028287706) ^ -601050784;
						continue;
					}
					goto IL_0176;
				case 68u:
				{
					int num62;
					int num63;
					if (mem[0, 0].Big == mem[1, 1].Big)
					{
						num62 = -1814168400;
						num63 = -1814168400;
					}
					else
					{
						num62 = -1293663636;
						num63 = -1293663636;
					}
					num = num62 ^ (int)(num2 * 586476522);
					continue;
				}
				case 67u:
				{
					int num51;
					int num52;
					if (mem[1, 1].Big == mem[2, 2].Big)
					{
						num51 = 758417644;
						num52 = 758417644;
					}
					else
					{
						num51 = 2012961886;
						num52 = 2012961886;
					}
					num = num51 ^ (int)(num2 * 1186247884);
					continue;
				}
				case 66u:
					if (mem[2, 2].Dark != mem[3, 3].Dark)
					{
						num = (int)(num2 * 1027451679) ^ -471193047;
						continue;
					}
					goto IL_0044;
				case 65u:
				{
					int num35;
					if (num3 < 4)
					{
						num = -2046446865;
						num35 = -2046446865;
					}
					else
					{
						num = -1514537038;
						num35 = -1514537038;
					}
					continue;
				}
				case 64u:
				{
					int num22;
					int num23;
					if (mem[1, 2].Dark == mem[2, 1].Dark)
					{
						num22 = 893880026;
						num23 = 893880026;
					}
					else
					{
						num22 = 1022077134;
						num23 = 1022077134;
					}
					num = num22 ^ ((int)num2 * -1714702577);
					continue;
				}
				case 63u:
					if (mem[num3, 2].Point != mem[num3, 3].Point)
					{
						num = ((int)num2 * -921918229) ^ 0x9ED384F;
						continue;
					}
					goto IL_00d2;
				case 62u:
				{
					int num66;
					int num67;
					if (mem[num3, 3] != null)
					{
						num66 = -90028282;
						num67 = -90028282;
					}
					else
					{
						num66 = -1832918077;
						num67 = -1832918077;
					}
					num = num66 ^ (int)(num2 * 18385406);
					continue;
				}
				case 61u:
				{
					int num57;
					int num58;
					if (flag2)
					{
						num57 = 1876895409;
						num58 = 1876895409;
					}
					else
					{
						num57 = 235398965;
						num58 = 235398965;
					}
					num = num57 ^ ((int)num2 * -1440884997);
					continue;
				}
				case 60u:
					if (mem[2, 1] != null)
					{
						num = (int)((num2 * 1697764127) ^ 0x2C763B71);
						continue;
					}
					goto IL_0038;
				case 59u:
				{
					int num45;
					if (mem[0, 3].Dark != mem[1, 2].Dark)
					{
						num = -724606349;
						num45 = -724606349;
					}
					else
					{
						num = -212870528;
						num45 = -212870528;
					}
					continue;
				}
				case 58u:
				{
					int num41;
					int num42;
					if (mem[num3, 1].Square == mem[num3, 2].Square)
					{
						num41 = 1374561642;
						num42 = 1374561642;
					}
					else
					{
						num41 = 812461779;
						num42 = 812461779;
					}
					num = num41 ^ ((int)num2 * -65486400);
					continue;
				}
				case 57u:
					if (mem[2, num3].Point != mem[3, num3].Point)
					{
						num = ((int)num2 * -1882090610) ^ 0x2B0A1FFE;
						continue;
					}
					goto IL_0176;
				case 56u:
				{
					int num28;
					if (mem[0, 0].Point != mem[1, 1].Point)
					{
						num = -636684599;
						num28 = -636684599;
					}
					else
					{
						num = -234511108;
						num28 = -234511108;
					}
					continue;
				}
				case 55u:
				{
					int num16;
					int num17;
					if (mem[1, num3].Big == mem[2, num3].Big)
					{
						num16 = -1794699909;
						num17 = -1794699909;
					}
					else
					{
						num16 = -141774491;
						num17 = -141774491;
					}
					num = num16 ^ (int)(num2 * 1657365371);
					continue;
				}
				case 53u:
					result = flag;
					num = -577631237;
					continue;
				case 52u:
					flag = true;
					num = ((int)num2 * -535098921) ^ 0x69651C2A;
					continue;
				case 51u:
				{
					int num9;
					if (mem[num3, 0].Dark == mem[num3, 1].Dark)
					{
						num = -2035321595;
						num9 = -2035321595;
					}
					else
					{
						num = -631916916;
						num9 = -631916916;
					}
					continue;
				}
				case 50u:
				{
					int num69;
					int num70;
					if (mem[0, 0] == null)
					{
						num69 = -584770860;
						num70 = -584770860;
					}
					else
					{
						num69 = -1246965407;
						num70 = -1246965407;
					}
					num = num69 ^ ((int)num2 * -62678603);
					continue;
				}
				case 49u:
					if (mem[1, num3].Square == mem[2, num3].Square)
					{
						num = ((int)num2 * -1916338906) ^ 0x45BAFCE1;
						continue;
					}
					goto IL_0518;
				case 48u:
				{
					int num61;
					if (mem[0, 3].Point != mem[1, 2].Point)
					{
						num = -1264461558;
						num61 = -1264461558;
					}
					else
					{
						num = -599774917;
						num61 = -599774917;
					}
					continue;
				}
				case 47u:
				{
					int num55;
					int num56;
					if (mem[0, 3].Big != mem[1, 2].Big)
					{
						num55 = 845947891;
						num56 = 845947891;
					}
					else
					{
						num55 = 63604230;
						num56 = 63604230;
					}
					num = num55 ^ ((int)num2 * -482298929);
					continue;
				}
				case 46u:
					if (mem[2, 1].Point != mem[3, 0].Point)
					{
						num = (int)((num2 * 240132412) ^ 0x24F5F12A);
						continue;
					}
					goto IL_0044;
				case 45u:
					if (mem[num3, 2].Square != mem[num3, 3].Square)
					{
						num = ((int)num2 * -24912382) ^ 0x81FF021;
						continue;
					}
					goto IL_00d2;
				case 44u:
					if (mem[2, 2].Big != mem[3, 3].Big)
					{
						num = (int)((num2 * 977648973) ^ 0x6D3EE625);
						continue;
					}
					goto IL_0044;
				case 43u:
					if (mem[2, 1].Square != mem[3, 0].Square)
					{
						goto IL_0038;
					}
					goto IL_0044;
				case 42u:
					num21 = ((mem[2, num3].Square == mem[3, num3].Square) ? 1 : 0);
					goto IL_00d3;
				case 41u:
				{
					int num46;
					if (mem[0, 0].Dark == mem[1, 1].Dark)
					{
						num = -2141057841;
						num46 = -2141057841;
					}
					else
					{
						num = -171020098;
						num46 = -171020098;
					}
					continue;
				}
				case 40u:
				{
					int num36;
					int num37;
					if (mem[num3, 1].Point != mem[num3, 2].Point)
					{
						num36 = 1281972817;
						num37 = 1281972817;
					}
					else
					{
						num36 = 2003652615;
						num37 = 2003652615;
					}
					num = num36 ^ (int)(num2 * 992028589);
					continue;
				}
				case 39u:
				{
					int num31;
					int num32;
					if (mem[num3, 2] == null)
					{
						num31 = 2013381044;
						num32 = 2013381044;
					}
					else
					{
						num31 = 690457868;
						num32 = 690457868;
					}
					num = num31 ^ ((int)num2 * -1137193381);
					continue;
				}
				case 38u:
					if (mem[num3, 2].Dark != mem[num3, 3].Dark)
					{
						num = (int)(num2 * 1568419539) ^ -2144669185;
						continue;
					}
					goto IL_00d2;
				case 37u:
					if (mem[2, num3].Dark != mem[3, num3].Dark)
					{
						num = ((int)num2 * -104657337) ^ -1032253494;
						continue;
					}
					goto IL_0176;
				case 36u:
				{
					int num18;
					int num19;
					if (mem[num3, 1].Dark != mem[num3, 2].Dark)
					{
						num18 = -983250932;
						num19 = -983250932;
					}
					else
					{
						num18 = -566606446;
						num19 = -566606446;
					}
					num = num18 ^ (int)(num2 * 1120565696);
					continue;
				}
				case 35u:
					if (mem[0, num3] != null)
					{
						num = -324501319;
						continue;
					}
					goto IL_0115;
				case 34u:
				{
					int num12;
					int num13;
					if (mem[num3, 0].Big == mem[num3, 1].Big)
					{
						num12 = 1379810319;
						num13 = 1379810319;
					}
					else
					{
						num12 = 1544622126;
						num13 = 1544622126;
					}
					num = num12 ^ (int)(num2 * 1879852811);
					continue;
				}
				case 33u:
					num = -1170420214;
					continue;
				case 32u:
				{
					int num8;
					if (mem[0, num3].Point == mem[1, num3].Point)
					{
						num = -935143710;
						num8 = -935143710;
					}
					else
					{
						num = -936480904;
						num8 = -936480904;
					}
					continue;
				}
				case 31u:
				{
					int num7;
					if (mem[0, num3].Dark != mem[1, num3].Dark)
					{
						num = -2129083586;
						num7 = -2129083586;
					}
					else
					{
						num = -213685506;
						num7 = -213685506;
					}
					continue;
				}
				case 30u:
				{
					int num68;
					if (mem[num3, 0].Square != mem[num3, 1].Square)
					{
						num = -1450679917;
						num68 = -1450679917;
					}
					else
					{
						num = -1608696984;
						num68 = -1608696984;
					}
					continue;
				}
				case 29u:
					if (mem[3, 0] != null)
					{
						num = (int)(num2 * 842224082) ^ -668516222;
						continue;
					}
					goto IL_0038;
				case 28u:
				{
					int num64;
					int num65;
					if (mem[1, 2].Big == mem[2, 1].Big)
					{
						num64 = 327341437;
						num65 = 327341437;
					}
					else
					{
						num64 = 2075509310;
						num65 = 2075509310;
					}
					num = num64 ^ (int)(num2 * 175215968);
					continue;
				}
				case 27u:
					if (mem[2, 2].Square != mem[3, 3].Square)
					{
						num = (int)(num2 * 1459282573) ^ -1167998953;
						continue;
					}
					goto IL_0044;
				case 26u:
				{
					int num59;
					int num60;
					if (mem[1, 1].Point == mem[2, 2].Point)
					{
						num59 = -910847846;
						num60 = -910847846;
					}
					else
					{
						num59 = -1538705798;
						num60 = -1538705798;
					}
					num = num59 ^ (int)(num2 * 1109681181);
					continue;
				}
				case 25u:
				{
					int num53;
					int num54;
					if (mem[3, 3] != null)
					{
						num53 = -1135006720;
						num54 = -1135006720;
					}
					else
					{
						num53 = -2050371735;
						num54 = -2050371735;
					}
					num = num53 ^ (int)(num2 * 691040394);
					continue;
				}
				case 24u:
					if (mem[3, num3] != null)
					{
						num = ((int)num2 * -965320869) ^ 0x50C1E5BD;
						continue;
					}
					goto IL_0115;
				case 23u:
				{
					int num49;
					int num50;
					if (mem[num3, 0] != null)
					{
						num49 = 532813861;
						num50 = 532813861;
					}
					else
					{
						num49 = 1044553174;
						num50 = 1044553174;
					}
					num = num49 ^ ((int)num2 * -1546028115);
					continue;
				}
				case 22u:
				{
					int num47;
					int num48;
					if (mem[1, num3].Point == mem[2, num3].Point)
					{
						num47 = -1429638823;
						num48 = -1429638823;
					}
					else
					{
						num47 = -685033353;
						num48 = -685033353;
					}
					num = num47 ^ (int)(num2 * 1662525983);
					continue;
				}
				case 20u:
				{
					int num43;
					int num44;
					if (mem[2, 2] == null)
					{
						num43 = -1530417615;
						num44 = -1530417615;
					}
					else
					{
						num43 = -1505380169;
						num44 = -1505380169;
					}
					num = num43 ^ (int)(num2 * 1942593494);
					continue;
				}
				case 19u:
				{
					int num39;
					int num40;
					if (mem[1, 1] != null)
					{
						num39 = 1368912031;
						num40 = 1368912031;
					}
					else
					{
						num39 = 2107895893;
						num40 = 2107895893;
					}
					num = num39 ^ (int)(num2 * 817435500);
					continue;
				}
				case 18u:
					flag = false;
					num = (int)(num2 * 940839984) ^ -1742084244;
					continue;
				case 17u:
				{
					int num33;
					int num34;
					if (mem[0, num3].Big == mem[1, num3].Big)
					{
						num33 = 479449689;
						num34 = 479449689;
					}
					else
					{
						num33 = 1575254645;
						num34 = 1575254645;
					}
					num = num33 ^ ((int)num2 * -309603987);
					continue;
				}
				case 16u:
				{
					int num29;
					int num30;
					if (mem[1, 1].Dark == mem[2, 2].Dark)
					{
						num29 = 1595831742;
						num30 = 1595831742;
					}
					else
					{
						num29 = 1600653178;
						num30 = 1600653178;
					}
					num = num29 ^ (int)(num2 * 1649918015);
					continue;
				}
				case 15u:
				{
					int num26;
					int num27;
					if (mem[1, 2].Point != mem[2, 1].Point)
					{
						num26 = 867044562;
						num27 = 867044562;
					}
					else
					{
						num26 = 1915995475;
						num27 = 1915995475;
					}
					num = num26 ^ (int)(num2 * 1924888371);
					continue;
				}
				case 14u:
					if (mem[1, 2] != null)
					{
						num = (int)(num2 * 781130746) ^ -223725074;
						continue;
					}
					goto IL_0038;
				case 13u:
				{
					int num20;
					if (mem[num3, 0].Point == mem[num3, 1].Point)
					{
						num = -1198168308;
						num20 = -1198168308;
					}
					else
					{
						num = -1617474814;
						num20 = -1617474814;
					}
					continue;
				}
				case 12u:
					if (mem[0, num3].Square == mem[1, num3].Square)
					{
						num = -897685547;
						continue;
					}
					goto IL_0518;
				case 11u:
					flag = true;
					num = ((int)num2 * -1221654730) ^ -567335038;
					continue;
				case 10u:
				{
					int num14;
					int num15;
					if (mem[1, num3].Dark != mem[2, num3].Dark)
					{
						num14 = 851271151;
						num15 = 851271151;
					}
					else
					{
						num14 = 1970095182;
						num15 = 1970095182;
					}
					num = num14 ^ ((int)num2 * -1681044523);
					continue;
				}
				case 9u:
					if (mem[2, 1].Big != mem[3, 0].Big)
					{
						num = (int)((num2 * 393323411) ^ 0x74693BB4);
						continue;
					}
					goto IL_0044;
				case 8u:
					num3 = 0;
					num = ((int)num2 * -807452540) ^ -47279366;
					continue;
				case 7u:
					num = -2112955668;
					continue;
				case 6u:
					if (mem[1, num3] != null)
					{
						num = (int)((num2 * 195774811) ^ 0x244C85E7);
						continue;
					}
					goto IL_0115;
				case 5u:
				{
					int num10;
					int num11;
					if (mem[1, 1].Square != mem[2, 2].Square)
					{
						num10 = -787126991;
						num11 = -787126991;
					}
					else
					{
						num10 = -1015869331;
						num11 = -1015869331;
					}
					num = num10 ^ ((int)num2 * -724821276);
					continue;
				}
				case 4u:
					num = ((int)num2 * -669321525) ^ -267418426;
					continue;
				case 3u:
					if (mem[2, 1].Dark != mem[3, 0].Dark)
					{
						num = (int)((num2 * 1233477540) ^ 0x1D9864A3);
						continue;
					}
					goto IL_0044;
				case 2u:
					if (mem[0, 3].Square == mem[1, 2].Square)
					{
						num = -1874987319;
						continue;
					}
					goto IL_0038;
				case 1u:
				{
					int num4;
					int num5;
					if (mem[num3, 1].Big == mem[num3, 2].Big)
					{
						num4 = 2047357468;
						num5 = 2047357468;
					}
					else
					{
						num4 = 1922715895;
						num5 = 1922715895;
					}
					num = num4 ^ (int)(num2 * 1708105962);
					continue;
				}
				case 0u:
					if (mem[1, 2].Square == mem[2, 1].Square)
					{
						num = ((int)num2 * -475295936) ^ 0x21E2F9F2;
						continue;
					}
					goto IL_0038;
				case 21u:
					break;
				default:
					{
						return result;
					}
					IL_0044:
					num = -693424395;
					num6 = -693424395;
					continue;
					IL_00d3:
					flag2 = (byte)num21 != 0;
					num = -2049451372;
					continue;
					IL_0176:
					num21 = 1;
					goto IL_00d3;
					IL_00d2:
					num21 = 1;
					goto IL_00d3;
					IL_0115:
					num21 = 0;
					goto IL_00d3;
					IL_0038:
					num = -1756012000;
					num6 = -1756012000;
					continue;
					IL_0518:
					num21 = 0;
					goto IL_00d3;
				}
				break;
			}
		}
	}

	private bool Standoff(Figurine[,] mem)
	{
		int num5 = default(int);
		bool flag3 = default(bool);
		bool flag2 = default(bool);
		int num8 = default(int);
		bool flag = default(bool);
		bool result = default(bool);
		while (true)
		{
			int num = 1828511484;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x38C9AA8Fu) % 16u)
				{
				case 15u:
					num5 = 0;
					num = 27443281;
					continue;
				case 14u:
					num = (int)(num2 * 1029675718) ^ -95168365;
					continue;
				case 13u:
					num = ((int)num2 * -1089390347) ^ 0x11F5FD6A;
					continue;
				case 12u:
					num = (int)((num2 * 237179376) ^ 0xF4FC8B8);
					continue;
				case 11u:
				{
					int num6;
					int num7;
					if (flag3)
					{
						num6 = 730668370;
						num7 = 730668370;
					}
					else
					{
						num6 = 1172457822;
						num7 = 1172457822;
					}
					num = num6 ^ (int)(num2 * 1562487717);
					continue;
				}
				case 10u:
					flag2 = mem[num8, num5] == null;
					num = 1703224045;
					continue;
				case 9u:
					flag = false;
					num = ((int)num2 * -423371871) ^ 0x104AE8A3;
					continue;
				case 8u:
					flag3 = num5 < 4;
					num = 2009821652;
					continue;
				case 7u:
				{
					int num9;
					if (num8 >= 4)
					{
						num = 761355118;
						num9 = 761355118;
					}
					else
					{
						num = 512862736;
						num9 = 512862736;
					}
					continue;
				}
				case 6u:
					num8++;
					num = (int)(num2 * 1190982643) ^ -1986415622;
					continue;
				case 5u:
					num5++;
					num = 1871964967;
					continue;
				case 3u:
					flag = true;
					num8 = 0;
					num = ((int)num2 * -826955574) ^ 0x733E1B2D;
					continue;
				case 2u:
				{
					int num3;
					int num4;
					if (!flag2)
					{
						num3 = 836723380;
						num4 = 836723380;
					}
					else
					{
						num3 = 1513435704;
						num4 = 1513435704;
					}
					num = num3 ^ ((int)num2 * -604866297);
					continue;
				}
				case 1u:
					result = flag;
					num = ((int)num2 * -1727732828) ^ -761526458;
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

	public void SetName(string str)
	{
		while (true)
		{
			int num = -1209050455;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA29E48D9u) % 11u)
				{
				case 10u:
					Form1.smethod_32((Control)(object)label6, str);
					num = (int)((num2 * 863993035) ^ 0x75E6C45);
					continue;
				case 9u:
					num = (int)(num2 * 171663851) ^ -1583165606;
					continue;
				case 8u:
					Form1.smethod_50((Control)(object)label6, Form1.smethod_37((Control)(object)label5).X + Form1.smethod_18((Control)(object)label5));
					num = (int)((num2 * 1302510671) ^ 0x23C8E0CC);
					continue;
				case 7u:
					Form1.smethod_50((Control)(object)label5, (Form1.smethod_49((Control)(object)this) - (Form1.smethod_18((Control)(object)label5) + Form1.smethod_18((Control)(object)label6))) / 2);
					num = (int)((num2 * 1591423925) ^ 0x50155F51);
					continue;
				case 5u:
					Form1.smethod_32((Control)(object)label2, "");
					num = (int)(num2 * 1635260304) ^ -583665737;
					continue;
				case 4u:
					Form1.smethod_32((Control)(object)label1, "");
					num = (int)(num2 * 2040905450) ^ -1120187744;
					continue;
				case 3u:
					num = (int)((num2 * 1806519838) ^ 0x37C8B810);
					continue;
				case 1u:
					Form1.smethod_32((Control)(object)label5, "Игрок: ");
					num = ((int)num2 * -1795292583) ^ -916104444;
					continue;
				case 0u:
					num = (int)(num2 * 363476406) ^ -85543700;
					continue;
				default:
					return;
				case 6u:
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
		if (disposing)
		{
			goto IL_0025;
		}
		goto IL_00ac;
		IL_0025:
		int num = 1056557503;
		goto IL_0070;
		IL_0070:
		int num3;
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0x36AEE76Au) % 8u)
			{
			case 7u:
				num = (int)(num2 * 1666823943) ^ -1523611261;
				continue;
			case 4u:
				break;
			case 3u:
				num = (int)(num2 * 1805769536) ^ -1960773837;
				continue;
			case 2u:
				((Form)this).Dispose(disposing);
				num = 714660516;
				continue;
			case 1u:
				num = (int)(num2 * 1788884320) ^ -472741696;
				continue;
			case 0u:
				Form1.smethod_51((IDisposable)components);
				num = (int)(num2 * 1908845140) ^ -1332554703;
				continue;
			default:
				return;
			case 5u:
				goto IL_00a1;
			case 6u:
				return;
			}
			break;
			IL_00a1:
			if (components != null)
			{
				num = 2006007541;
				num3 = 2006007541;
				continue;
			}
			goto IL_00ac;
		}
		goto IL_0025;
		IL_00ac:
		num = 232656544;
		num3 = 232656544;
		goto IL_0070;
	}

	private void InitializeComponent()
	{
		//IL_079e: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a8: Expected O, but got Unknown
		bool flag = default(bool);
		int num3 = default(int);
		byte[] array = default(byte[]);
		object[] object_ = default(object[]);
		string sa = default(string);
		while (true)
		{
			int num = -1370333151;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE52E2007u) % 132u)
				{
				case 131u:
					num = ((int)num2 * -1273831310) ^ -448745377;
					continue;
				case 130u:
					Form1.smethod_67((Control)(object)button1, (EventHandler)Button1_Click);
					num = (int)((num2 * 654312928) ^ 0x57675C5D);
					continue;
				case 129u:
					Form1.smethod_64((Control)(object)panel1, 7);
					num = ((int)num2 * -380202327) ^ -488062014;
					continue;
				case 128u:
					Form1.smethod_64((Control)(object)button2, 4);
					num = (int)(num2 * 46608558) ^ -2092017655;
					continue;
				case 127u:
					Form1.smethod_61((Control)(object)panel1, "panel1");
					num = ((int)num2 * -2041899454) ^ 0x302C48E8;
					continue;
				case 126u:
					num = ((int)num2 * -1892209363) ^ -1722559621;
					continue;
				case 125u:
					num = ((int)num2 * -1828743136) ^ -1743575993;
					continue;
				case 124u:
					Form1.smethod_4((Control)(object)button2, new Point(391, 275));
					Form1.smethod_61((Control)(object)button2, "button2");
					num = ((int)num2 * -1843394211) ^ -479690688;
					continue;
				case 123u:
					num = ((int)num2 * -2083270645) ^ -1257330433;
					continue;
				case 121u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)button1);
					num = (int)((num2 * 1217947549) ^ 0x417BFD84);
					continue;
				case 120u:
					Form1.smethod_32((Control)(object)button1, "Меню");
					Form1.smethod_66((ButtonBase)(object)button1, bool_0: true);
					num = ((int)num2 * -1950652756) ^ 0x6230CDEA;
					continue;
				case 119u:
					num = (int)((num2 * 398544511) ^ 0x7FADA317);
					continue;
				case 118u:
					label2 = Form1.smethod_57();
					num = ((int)num2 * -775236056) ^ 0x1C925217;
					continue;
				case 117u:
					num = ((int)num2 * -1122399931) ^ -1134938304;
					continue;
				case 116u:
					Form1.smethod_65((Control)(object)richTextBox1, bool_0: false);
					num = (int)((num2 * 610701440) ^ 0x213A05B8);
					continue;
				case 115u:
					Form1.smethod_32((Control)(object)button2, "Подтвердить");
					num = (int)((num2 * 255972979) ^ 0x5CB23BC2);
					continue;
				case 114u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = 1608074415;
						num5 = 1608074415;
					}
					else
					{
						num4 = 1784642375;
						num5 = 1784642375;
					}
					num = num4 ^ ((int)num2 * -1948782372);
					continue;
				}
				case 113u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label1);
					num = ((int)num2 * -671823217) ^ 0x32E64854;
					continue;
				case 112u:
					num = (int)(num2 * 2141227428) ^ -1270726452;
					continue;
				case 111u:
					Form1.smethod_87((Form)(object)this, (EventHandler)Form1_Load);
					num = ((int)num2 * -1618742797) ^ -560389545;
					continue;
				case 110u:
					Form1.smethod_65((Control)(object)button2, bool_0: false);
					num = (int)(num2 * 924390222) ^ -1777761855;
					continue;
				case 109u:
					Form1.smethod_85((Control)(object)this, "Form1");
					num = (int)((num2 * 344802540) ^ 0x282BB451);
					continue;
				case 108u:
					Form1.smethod_61((Control)(object)button1, "button1");
					num = (int)(num2 * 1368207716) ^ -1625447516;
					continue;
				case 107u:
					Form1.smethod_4((Control)(object)pictureBox1, new Point(120, 22));
					num = ((int)num2 * -197011402) ^ 0x3B4FFF29;
					continue;
				case 106u:
					num = ((int)num2 * -589890616) ^ -1417063685;
					continue;
				case 105u:
					Form1.smethod_77((Control)(object)label6, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = ((int)num2 * -2123084948) ^ 0x330F7E86;
					continue;
				case 104u:
					Form1.smethod_79((ContainerControl)(object)this, new SizeF(6f, 13f));
					num = (int)(num2 * 478902707) ^ -1876510973;
					continue;
				case 103u:
					num = ((int)num2 * -838350293) ^ 0x4D10F51A;
					continue;
				case 102u:
					num = (int)((num2 * 1101668503) ^ 0x435284A1);
					continue;
				case 101u:
					Form1.smethod_77((Control)(object)label2, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = (int)((num2 * 858464714) ^ 0x676D8E3A);
					continue;
				case 100u:
					num = -27609434;
					continue;
				case 99u:
					flag = num3 < 22528;
					num = -1254215767;
					continue;
				case 98u:
					num = ((int)num2 * -1341233855) ^ 0x1B1F86C1;
					continue;
				case 97u:
					Form1.smethod_81((Form)(object)this, new Size(486, 319));
					num = ((int)num2 * -2050367213) ^ 0x38F4B2E5;
					continue;
				case 96u:
					label5 = Form1.smethod_57();
					label6 = Form1.smethod_57();
					num = (int)(num2 * 1402551568) ^ -1742629990;
					continue;
				case 95u:
					Form1.smethod_72(timer1, 1000);
					num = ((int)num2 * -687458027) ^ 0x7BFE58DA;
					continue;
				case 94u:
					num = ((int)num2 * -804887380) ^ -1383256723;
					continue;
				case 93u:
					Form1.smethod_84((Form)(object)this, bool_0: false);
					num = (int)(num2 * 1720734006) ^ -1974655196;
					continue;
				case 92u:
					Form1.smethod_83((Form)(object)this, (FormBorderStyle)1);
					num = ((int)num2 * -325527155) ^ 0x48A56B9A;
					continue;
				case 91u:
					array = new byte[22528];
					num = (int)(num2 * 990340091) ^ -206696841;
					continue;
				case 90u:
					Form1.smethod_64((Control)(object)label1, 8);
					num = (int)(num2 * 147873208) ^ -1643105056;
					continue;
				case 89u:
					Form1.smethod_90((ISupportInitialize)pictureBox1);
					num = ((int)num2 * -648183872) ^ 0x3794870F;
					continue;
				case 88u:
					Form1.smethod_3((Control)(object)label5, new Size(0, 16));
					num = ((int)num2 * -1480114641) ^ 0x4D49D428;
					continue;
				case 87u:
					num = (int)(num2 * 888424368) ^ -233825008;
					continue;
				case 86u:
					Form1.smethod_64((Control)(object)label6, 13);
					num = (int)((num2 * 96249977) ^ 0x1B956A35);
					continue;
				case 85u:
					array[num3] = Form1.smethod_69(Form1.smethod_68(sa, num3 * 2, 2), 16);
					num = (int)(num2 * 1911463257) ^ -814748603;
					continue;
				case 84u:
					Form1.smethod_80((ContainerControl)(object)this, (AutoScaleMode)1);
					num = ((int)num2 * -1587381580) ^ -493027199;
					continue;
				case 82u:
					components = Form1.smethod_52();
					num = (int)((num2 * 1026270020) ^ 0x9288EB5);
					continue;
				case 81u:
					richTextBox1 = Form1.smethod_54();
					num = ((int)num2 * -2028859528) ^ -1854847457;
					continue;
				case 80u:
					num = (int)(num2 * 1411580433) ^ -663454668;
					continue;
				case 79u:
					num = (int)(num2 * 1398895936) ^ -12932690;
					continue;
				case 78u:
					num = ((int)num2 * -619433401) ^ -1890040864;
					continue;
				case 77u:
					Form1.smethod_61((Control)(object)label2, "label2");
					num = ((int)num2 * -1136345668) ^ -1988464817;
					continue;
				case 76u:
					num = (int)(num2 * 1584331638) ^ -528445654;
					continue;
				case 75u:
					num = ((int)num2 * -1013535010) ^ -1535733136;
					continue;
				case 74u:
					num = ((int)num2 * -1295481989) ^ 0x3CDE7916;
					continue;
				case 73u:
					Form1.smethod_3((Control)(object)label2, new Size(0, 16));
					num = (int)(num2 * 1477962302) ^ -789554093;
					continue;
				case 72u:
					Form1.smethod_89((Control)(object)this, (EventHandler)Form1_LocationChanged);
					num = ((int)num2 * -16237722) ^ -1780936578;
					continue;
				case 71u:
					num3++;
					num = ((int)num2 * -1086955899) ^ 0x43184B57;
					continue;
				case 70u:
					num = (int)(num2 * 301313584) ^ -14017332;
					continue;
				case 69u:
					Form1.smethod_4((Control)(object)richTextBox1, new Point(107, 275));
					num = ((int)num2 * -685759906) ^ 0x55D288EF;
					continue;
				case 68u:
					num = ((int)num2 * -2140539728) ^ -1490473912;
					continue;
				case 67u:
					Form1.smethod_60(pictureBox1, (BorderStyle)2);
					num = (int)((num2 * 746790066) ^ 0x2134014E);
					continue;
				case 66u:
					num = ((int)num2 * -430070103) ^ -1811217847;
					continue;
				case 65u:
					Form1.smethod_3((Control)(object)button1, new Size(83, 35));
					Form1.smethod_64((Control)(object)button1, 5);
					num = (int)((num2 * 1854823780) ^ 0x6A1DA031);
					continue;
				case 64u:
					Form1.smethod_6((Control)(object)pictureBox1, new MouseEventHandler(PictureBox1_MouseDown));
					num = ((int)num2 * -1668135737) ^ -1908366606;
					continue;
				case 63u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)button2);
					num = (int)(num2 * 386229687) ^ -1261610716;
					continue;
				case 62u:
					Form1.smethod_64((Control)(object)label2, 9);
					Form1.smethod_74((Control)(object)label5, bool_0: true);
					Form1.smethod_77((Control)(object)label5, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					Form1.smethod_4((Control)(object)label5, new Point(197, 0));
					Form1.smethod_61((Control)(object)label5, "label5");
					num = ((int)num2 * -788763390) ^ -1665275133;
					continue;
				case 61u:
					Form1.smethod_77((Control)(object)label1, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					Form1.smethod_4((Control)(object)label1, new Point(486, 0));
					Form1.smethod_61((Control)(object)label1, "label1");
					num = ((int)num2 * -1729296929) ^ 0x217AD97F;
					continue;
				case 60u:
					Form1.smethod_5((Control)(object)richTextBox1, Color.White);
					num = ((int)num2 * -1276486835) ^ -587741292;
					continue;
				case 59u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)panel1);
					num = (int)(num2 * 721109197) ^ -806165828;
					continue;
				case 58u:
					num = (int)((num2 * 26606304) ^ 0x6B3FBA93);
					continue;
				case 57u:
					Form1.smethod_4((Control)(object)label2, new Point(0, 0));
					num = (int)(num2 * 29937218) ^ -1936251210;
					continue;
				case 56u:
					panel1 = Form1.smethod_55();
					timer1 = Form1.smethod_56(components);
					label1 = Form1.smethod_57();
					num = (int)(num2 * 1104358902) ^ -1275179875;
					continue;
				case 55u:
					num = ((int)num2 * -109903049) ^ 0x10463AAE;
					continue;
				case 54u:
					Form1.smethod_61((Control)(object)richTextBox1, "richTextBox1");
					num = ((int)num2 * -1458480994) ^ -1754749755;
					continue;
				case 53u:
					Form1.smethod_75((Control)(object)label2, (DockStyle)3);
					num = ((int)num2 * -1185080672) ^ -1522529366;
					continue;
				case 52u:
					Form1.smethod_62(pictureBox1, 0);
					Form1.smethod_63(pictureBox1, bool_0: false);
					num = (int)(num2 * 663338859) ^ -521863287;
					continue;
				case 51u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label5);
					num = ((int)num2 * -808530582) ^ -1617088367;
					continue;
				case 50u:
					Form1.smethod_86((Form)(object)this, bool_0: false);
					num = ((int)num2 * -1283890419) ^ 0x23EB38B6;
					continue;
				case 49u:
					num = (int)((num2 * 1654354496) ^ 0x35D20743);
					continue;
				case 48u:
					num = ((int)num2 * -382484553) ^ -936927067;
					continue;
				case 47u:
					num = ((int)num2 * -1750986209) ^ 0x213B637;
					continue;
				case 46u:
					Form1.smethod_73(timer1, (EventHandler)Timer1_Tick);
					Form1.smethod_74((Control)(object)label1, bool_0: true);
					num = (int)(num2 * 1578528986) ^ -773412845;
					continue;
				case 45u:
					Form1.smethod_4((Control)(object)label6, new Point(275, 0));
					num = ((int)num2 * -1694331214) ^ -1803709428;
					continue;
				case 44u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label2);
					num = (int)((num2 * 266272393) ^ 0x70C39EC7);
					continue;
				case 43u:
					Form1.smethod_70(ComMember, object_);
					Form1.smethod_71((TextBoxBase)(object)richTextBox1, bool_0: true);
					num = (int)(num2 * 690729664) ^ -1487433968;
					continue;
				case 42u:
					num = (int)((num2 * 313845363) ^ 0x474E0845);
					continue;
				case 41u:
					Form1.smethod_3((Control)(object)panel1, new Size(486, 240));
					num = ((int)num2 * -569516075) ^ 0x795C963F;
					continue;
				case 40u:
					Form1.smethod_3((Control)(object)pictureBox1, new Size(246, 246));
					num = (int)((num2 * 694188675) ^ 0x49285DA9);
					continue;
				case 39u:
					Form1.smethod_32((Control)(object)this, "Quarto");
					num = (int)(num2 * 2022140745) ^ -67264117;
					continue;
				case 38u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)pictureBox1);
					num = ((int)num2 * -1703055683) ^ 0x56A4BACE;
					continue;
				case 37u:
					Form1.smethod_88((Form)(object)this, (EventHandler)Form1_Shown);
					num = ((int)num2 * -1268616276) ^ 0x655A7A9A;
					continue;
				case 36u:
					CharArray(array, string.Empty);
					num = (int)(num2 * 1336883124) ^ -1118046971;
					continue;
				case 35u:
					num = ((int)num2 * -1759776158) ^ -692319612;
					continue;
				case 34u:
					Form1.smethod_65((Control)(object)button1, bool_0: false);
					num = (int)((num2 * 1195866555) ^ 0x22EB058F);
					continue;
				case 33u:
					num = (int)(num2 * 396959006) ^ -1067295772;
					continue;
				case 32u:
					num = ((int)num2 * -141665798) ^ -1212617142;
					continue;
				case 31u:
					button1 = Form1.smethod_53();
					num = (int)((num2 * 1480588351) ^ 0x60126B23);
					continue;
				case 30u:
					Form1.smethod_64((Control)(object)richTextBox1, 6);
					num = (int)(num2 * 1001346048) ^ -404664923;
					continue;
				case 29u:
					Form1.smethod_4((Control)(object)panel1, new Point(0, 24));
					num = (int)(num2 * 1001948587) ^ -260363929;
					continue;
				case 28u:
					Form1.smethod_61((Control)(object)pictureBox1, "pictureBox1");
					num = (int)(num2 * 960350380) ^ -1913235715;
					continue;
				case 27u:
					Form1.smethod_3((Control)(object)richTextBox1, new Size(272, 35));
					num = ((int)num2 * -443138368) ^ 0x5541E515;
					continue;
				case 26u:
					pictureBox1 = Form1.smethod_2();
					button2 = Form1.smethod_53();
					num = (int)(num2 * 1053309249) ^ -364847982;
					continue;
				case 25u:
					Form1.smethod_3((Control)(object)label6, new Size(0, 16));
					num = (int)(num2 * 2083903052) ^ -232817473;
					continue;
				case 24u:
					Form1.smethod_32((Control)(object)richTextBox1, "");
					num = ((int)num2 * -1271914515) ^ 0x57A2BFD4;
					continue;
				case 23u:
					Form1.smethod_66((ButtonBase)(object)button2, bool_0: true);
					Form1.smethod_67((Control)(object)button2, (EventHandler)Button2_Click);
					num = (int)((num2 * 475483149) ^ 0x6C47C75A);
					continue;
				case 22u:
					Form1.smethod_74((Control)(object)label6, bool_0: true);
					num = ((int)num2 * -563560469) ^ -861273094;
					continue;
				case 21u:
					num = ((int)num2 * -1366514494) ^ -1006712604;
					continue;
				case 20u:
					Form1.smethod_3((Control)(object)button2, new Size(83, 35));
					num = ((int)num2 * -177833340) ^ -1517036589;
					continue;
				case 19u:
					num = ((int)num2 * -343356893) ^ 0x1BC5C01B;
					continue;
				case 18u:
					num = ((int)num2 * -871894592) ^ 0x65A72F18;
					continue;
				case 17u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label6);
					num = ((int)num2 * -986305529) ^ -1433897221;
					continue;
				case 16u:
					Form1.smethod_91((Control)(object)this, bool_0: false);
					num = (int)(num2 * 1123019079) ^ -57069407;
					continue;
				case 15u:
					sa = Veet.Sa;
					sa = Form1.smethod_34(sa, Veet.Xe);
					sa = Form1.smethod_34(sa, Veet.Zr);
					num = ((int)num2 * -1158134521) ^ 0x37783A1D;
					continue;
				case 14u:
					Form1.smethod_5((Control)(object)this, Color.White);
					num = (int)(num2 * 1622298393) ^ -684776971;
					continue;
				case 13u:
					Form1.smethod_61((Control)(object)label6, "label6");
					num = (int)(num2 * 1500075467) ^ -49918531;
					continue;
				case 12u:
					num = ((int)num2 * -993918742) ^ -2070743026;
					continue;
				case 11u:
					object_ = new object[3]
					{
						Player.MembershipCondition(0),
						Player.MembershipCondition(1),
						"Cytotechnologist"
					};
					num = (int)(num2 * 1151150015) ^ -1635976495;
					continue;
				case 10u:
					Form1.smethod_78((Control)(object)label1, (RightToLeft)0);
					num = ((int)num2 * -1844365605) ^ -186114107;
					continue;
				case 9u:
					Form1.smethod_64((Control)(object)label5, 12);
					num = ((int)num2 * -1546974851) ^ -1290975232;
					continue;
				case 8u:
					Form1.smethod_75((Control)(object)label1, (DockStyle)4);
					num = (int)(num2 * 665957464) ^ -1013671494;
					continue;
				case 7u:
					num = ((int)num2 * -1624926762) ^ 0x6A2F2511;
					continue;
				case 6u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)richTextBox1);
					num = ((int)num2 * -612382446) ^ 0x54453530;
					continue;
				case 5u:
					num3 = 0;
					num = (int)(num2 * 671414420) ^ -957302141;
					continue;
				case 4u:
					Form1.smethod_3((Control)(object)label1, new Size(0, 16));
					num = ((int)num2 * -1842463959) ^ -851761359;
					continue;
				case 3u:
					Form1.smethod_74((Control)(object)label2, bool_0: true);
					num = ((int)num2 * -829149872) ^ -1027828682;
					continue;
				case 2u:
					Form1.smethod_4((Control)(object)button1, new Point(12, 275));
					num = ((int)num2 * -776501217) ^ -1545228462;
					continue;
				case 1u:
					Form1.smethod_58((ISupportInitialize)pictureBox1);
					Form1.smethod_59((Control)(object)this);
					Form1.smethod_5((Control)(object)pictureBox1, Color.FromArgb(64, 32, 0));
					num = (int)(num2 * 1016538842) ^ -766934;
					continue;
				case 0u:
					num = (int)((num2 * 109986579) ^ 0x206FD2A9);
					continue;
				case 83u:
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
		while (true)
		{
			int num = 195786220;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x667A88D9u) % 4u)
				{
				case 2u:
					num = (int)((num2 * 1449122504) ^ 0x13C48A09);
					continue;
				case 1u:
				{
					Assembly q = ContextAdd(Level);
					PerformTable(q);
					num = (int)((num2 * 2093248736) ^ 0x37E027BB);
					continue;
				}
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

	private static Assembly ContextAdd(byte[] Position)
	{
		Assembly result = Form1.smethod_94(Form1.smethod_93(), Position);
		while (true)
		{
			int num = 2021547273;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x55392164u) % 3u)
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
				num = ((int)num2 * -604972142) ^ -1304050623;
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
