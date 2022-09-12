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
				int num = -1573476571;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xFA86CC44u) % 5u)
					{
					case 3u:
						num = (int)((num2 * 2058754361) ^ 0x101CF40D);
						continue;
					case 1u:
						Square = copy.Square;
						Point = copy.Point;
						num = ((int)num2 * -1881980284) ^ 0x15BCAF58;
						continue;
					case 0u:
						Dark = copy.Dark;
						Big = copy.Big;
						num = (int)(num2 * 1948490997) ^ -1894761374;
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
		while (true)
		{
			int num = -1721412299;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB59C5341u) % 8u)
				{
				case 6u:
					num = (int)(num2 * 889674490) ^ -2118202697;
					continue;
				case 5u:
					num = ((int)num2 * -1025706248) ^ 0x6678FAA2;
					continue;
				case 4u:
					num = (int)(num2 * 250868231) ^ -1866435224;
					continue;
				case 3u:
				{
					int num3;
					if (Form1.smethod_16((Control)(object)menu) >= 296)
					{
						num = -521693727;
						num3 = -521693727;
					}
					else
					{
						num = -1976953080;
						num3 = -1976953080;
					}
					continue;
				}
				case 1u:
				{
					Form control_ = menu;
					Form1.smethod_17((Control)(object)control_, Form1.smethod_16((Control)(object)control_) + 5);
					num = -410599302;
					continue;
				}
				case 0u:
					Form1.smethod_14(menu);
					num = (int)(num2 * 1936320457) ^ -1428169985;
					continue;
				default:
					return;
				case 7u:
					break;
				case 2u:
					return;
				}
				break;
			}
		}
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		int num3 = default(int);
		int num4 = default(int);
		bool flag = default(bool);
		while (true)
		{
			int num = -1320343130;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x83A5E08Du) % 18u)
				{
				case 16u:
					num3 = 0;
					num = -415291060;
					continue;
				case 15u:
				{
					int num7;
					if (num3 >= 4)
					{
						num = -1251941038;
						num7 = -1251941038;
					}
					else
					{
						num = -1807237829;
						num7 = -1807237829;
					}
					continue;
				}
				case 14u:
					Form1.smethod_7((Control)(object)pictureBox[num4, num3], bool_0: false);
					num = (int)((num2 * 1609282034) ^ 0x7E296D76);
					continue;
				case 13u:
					storage = new Figurine[4, 4];
					num4 = 0;
					num = ((int)num2 * -2117468878) ^ 0x327A8308;
					continue;
				case 11u:
					num4++;
					num = ((int)num2 * -808335914) ^ 0x47514A54;
					continue;
				case 10u:
					Paint_Storage();
					num = (int)(num2 * 382098955) ^ -365093424;
					continue;
				case 9u:
					num = ((int)num2 * -1417088707) ^ -1340347452;
					continue;
				case 8u:
					storage[num4, num3] = new Figurine(num4 < 2, num3 % 2 == 0, num3 < 2, num4 % 2 == 1);
					Form1.smethod_5((Control)(object)borderBox[num4, num3], Color.White);
					num = -1853183375;
					continue;
				case 7u:
					Paint_Board();
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: false);
					num = (int)((num2 * 1787203335) ^ 0x168CB23B);
					continue;
				case 6u:
				{
					int num5;
					int num6;
					if (flag)
					{
						num5 = -625872795;
						num6 = -625872795;
					}
					else
					{
						num5 = -2000311504;
						num6 = -2000311504;
					}
					num = num5 ^ (int)(num2 * 1535585487);
					continue;
				}
				case 5u:
					num = ((int)num2 * -1136794844) ^ 0x754C62B;
					continue;
				case 4u:
					num = (int)((num2 * 792186203) ^ 0x797DA8B);
					continue;
				case 3u:
					flag = num4 < 4;
					num = -1231832173;
					continue;
				case 2u:
					num3++;
					num = ((int)num2 * -1279882009) ^ 0x14996830;
					continue;
				case 1u:
					board = new Figurine[4, 4];
					num = (int)(num2 * 88731843) ^ -461816161;
					continue;
				case 0u:
					num = (int)((num2 * 1436018196) ^ 0x6FCB7D61);
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
		Graphics graphics_ = default(Graphics);
		Brush brush_ = default(Brush);
		float num8 = default(float);
		int num3 = default(int);
		int num4 = default(int);
		float num9 = default(float);
		float num12 = default(float);
		float num7 = default(float);
		float num13 = default(float);
		bool dark = default(bool);
		bool point = default(bool);
		bool flag = default(bool);
		bool flag2 = default(bool);
		while (true)
		{
			int num = -1048453267;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xEB5E6BB0u) % 38u)
				{
				case 37u:
					num = (int)((num2 * 1501300297) ^ 0x56002489);
					continue;
				case 36u:
					num = (int)((num2 * 1908518068) ^ 0x3E7EE122);
					continue;
				case 35u:
					Form1.smethod_28(graphics_, brush_, num8 + (float)(num3 * size), num8 + (float)(num4 * size), num9, num9);
					num = ((int)num2 * -685923585) ^ -1176502641;
					continue;
				case 34u:
					num = -1236841924;
					continue;
				case 33u:
					num = ((int)num2 * -875343232) ^ 0x11C9542F;
					continue;
				case 32u:
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox1));
					num = (int)(num2 * 1832975284) ^ -1348003711;
					continue;
				case 31u:
					num12 = 1f - num7 * 0.9f / (float)Form1.smethod_27(2.0);
					num13 = (float)size * num7;
					num = -1524073224;
					continue;
				case 30u:
					brush_ = Form1.smethod_26();
					num = -126466932;
					continue;
				case 29u:
				{
					int num19;
					int num20;
					if (!dark)
					{
						num19 = -1199545311;
						num20 = -1199545311;
					}
					else
					{
						num19 = -720192658;
						num20 = -720192658;
					}
					num = num19 ^ (int)(num2 * 1902287561);
					continue;
				}
				case 28u:
				{
					num8 = (float)size * (num12 / 2f);
					num9 = num13 * 0.9f / (float)Form1.smethod_27(2.0);
					int num14;
					int num15;
					if (!board[num4, num3].Square)
					{
						num14 = -1384034227;
						num15 = -1384034227;
					}
					else
					{
						num14 = -546297705;
						num15 = -546297705;
					}
					num = num14 ^ ((int)num2 * -1140707739);
					continue;
				}
				case 27u:
					brush_ = Form1.smethod_25();
					num = ((int)num2 * -1222379282) ^ -301397227;
					continue;
				case 26u:
					num3++;
					num = -1716780758;
					continue;
				case 25u:
					num = ((int)num2 * -779379912) ^ -418181766;
					continue;
				case 24u:
					point = board[num4, num3].Point;
					num = (int)(num2 * 983115951) ^ -1415964861;
					continue;
				case 23u:
					num = (int)((num2 * 449123255) ^ 0x6FC36F65);
					continue;
				case 22u:
				{
					int num21;
					int num22;
					if (flag)
					{
						num21 = 1678378660;
						num22 = 1678378660;
					}
					else
					{
						num21 = 188177458;
						num22 = 188177458;
					}
					num = num21 ^ ((int)num2 * -1975549710);
					continue;
				}
				case 21u:
				{
					int num17;
					int num18;
					if (point)
					{
						num17 = -822631324;
						num18 = -822631324;
					}
					else
					{
						num17 = -374335384;
						num18 = -374335384;
					}
					num = num17 ^ (int)(num2 * 1349003078);
					continue;
				}
				case 20u:
					num12 = 1f - num7 * 0.4f / (float)Form1.smethod_27(2.0);
					num8 = (float)size * (num12 / 2f);
					num9 = num13 * 0.4f / (float)Form1.smethod_27(2.0);
					num = -1200170948;
					continue;
				case 19u:
					Form1.smethod_24(graphics_, brush_, num8 + (float)(num3 * size), num8 + (float)(num4 * size), num9, num9);
					num = -1405473030;
					continue;
				case 18u:
				{
					int num16;
					if (board[num4, num3].Big)
					{
						num = -441232333;
						num16 = -441232333;
					}
					else
					{
						num = -1939524439;
						num16 = -1939524439;
					}
					continue;
				}
				case 17u:
					Form1.smethod_30((Control)(object)pictureBox1);
					num = ((int)num2 * -428941888) ^ -174145163;
					continue;
				case 16u:
				{
					Form1.smethod_24(graphics_, Form1.smethod_23(), ((float)num3 + 0.05f) * (float)size, ((float)num4 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					int num10;
					int num11;
					if (board[num4, num3] != null)
					{
						num10 = -1038605121;
						num11 = -1038605121;
					}
					else
					{
						num10 = -1146132130;
						num11 = -1146132130;
					}
					num = num10 ^ (int)(num2 * 1552198149);
					continue;
				}
				case 15u:
					num7 = 0.7f;
					num = -2017867139;
					continue;
				case 14u:
					Form1.smethod_24(graphics_, (Brush)(object)Form1.smethod_29(Color.FromArgb(180, Color.Peru)), num8 + (float)(num3 * size), num8 + (float)(num4 * size), num9, num9);
					num = (int)((num2 * 680319156) ^ 0x49283BD1);
					continue;
				case 13u:
					num = ((int)num2 * -523274618) ^ -395348193;
					continue;
				case 12u:
					dark = board[num4, num3].Dark;
					num = ((int)num2 * -2003761462) ^ 0x5522B09;
					continue;
				case 11u:
					num4 = 0;
					num = ((int)num2 * -50803662) ^ 0x3D275495;
					continue;
				case 10u:
					num = -1503922462;
					continue;
				case 8u:
					num3 = 0;
					num = -1716780758;
					continue;
				case 6u:
					num4++;
					num = ((int)num2 * -2105091739) ^ 0x478790E2;
					continue;
				case 5u:
					num7 = 1f;
					num = (int)((num2 * 1264052030) ^ 0x655011F1);
					continue;
				case 4u:
				{
					int num5;
					int num6;
					if (!flag2)
					{
						num5 = 1107261511;
						num6 = 1107261511;
					}
					else
					{
						num5 = 1941552844;
						num6 = 1941552844;
					}
					num = num5 ^ ((int)num2 * -31478234);
					continue;
				}
				case 3u:
					num = ((int)num2 * -382756155) ^ -1166524909;
					continue;
				case 2u:
					flag2 = num4 < 4;
					num = -1660978838;
					continue;
				case 1u:
					Form1.smethod_20(pictureBox1, (Image)(object)Form1.smethod_19(Form1.smethod_18((Control)(object)pictureBox1), Form1.smethod_16((Control)(object)pictureBox1)));
					num = ((int)num2 * -1478433054) ^ -787866614;
					continue;
				case 0u:
					flag = num3 < 4;
					num = -785373204;
					continue;
				default:
					return;
				case 9u:
					break;
				case 7u:
					return;
				}
				break;
			}
		}
	}

	private void Paint_Storage()
	{
		bool flag = default(bool);
		Brush brush_ = default(Brush);
		Graphics graphics_ = default(Graphics);
		float num6 = default(float);
		float num7 = default(float);
		float num12 = default(float);
		float num10 = default(float);
		bool flag3 = default(bool);
		int num4 = default(int);
		int num3 = default(int);
		bool point = default(bool);
		float num11 = default(float);
		bool dark = default(bool);
		bool flag2 = default(bool);
		while (true)
		{
			int num = 618929180;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3422C314u) % 41u)
				{
				case 40u:
				{
					int num20;
					int num21;
					if (!flag)
					{
						num20 = -1755366573;
						num21 = -1755366573;
					}
					else
					{
						num20 = -1521348765;
						num21 = -1521348765;
					}
					num = num20 ^ ((int)num2 * -1372340764);
					continue;
				}
				case 39u:
					brush_ = Form1.smethod_25();
					num = (int)(num2 * 1915897970) ^ -1446304406;
					continue;
				case 38u:
					Form1.smethod_28(graphics_, brush_, num6, num6, num7, num7);
					num = (int)(num2 * 1768201467) ^ -1010648765;
					continue;
				case 37u:
					num7 = num12 * 0.9f / (float)Form1.smethod_27(2.0);
					num = ((int)num2 * -1965846559) ^ 0x2B9C71F0;
					continue;
				case 35u:
					num12 = (float)size * num10;
					num = (int)((num2 * 1407561135) ^ 0x77BCEC7E);
					continue;
				case 34u:
					flag3 = num4 < 4;
					num = 2135952363;
					continue;
				case 33u:
					num = ((int)num2 * -1523580247) ^ 0x52E06280;
					continue;
				case 32u:
					num4++;
					num = 2040149474;
					continue;
				case 31u:
					num3 = 0;
					num = ((int)num2 * -519434723) ^ -2072347972;
					continue;
				case 30u:
					num = ((int)num2 * -901080533) ^ 0x424813BE;
					continue;
				case 29u:
					num = ((int)num2 * -1991894064) ^ 0x52074721;
					continue;
				case 28u:
					num = (int)(num2 * 1962491266) ^ -213409482;
					continue;
				case 27u:
					num = ((int)num2 * -771487580) ^ 0x6E415F22;
					continue;
				case 26u:
					num10 = 1f;
					num = (int)((num2 * 1807303821) ^ 0x5BD22A6C);
					continue;
				case 25u:
					num = (int)(num2 * 1962357122) ^ -79457863;
					continue;
				case 24u:
					Form1.smethod_24(graphics_, brush_, num6, num6, num7, num7);
					num = 1138287242;
					continue;
				case 23u:
				{
					int num19;
					if (storage[num3, num4] == null)
					{
						num = 499688362;
						num19 = 499688362;
					}
					else
					{
						num = 1557820321;
						num19 = 1557820321;
					}
					continue;
				}
				case 22u:
					Form1.smethod_30((Control)(object)pictureBox[num3, num4]);
					num = 1750883653;
					continue;
				case 21u:
				{
					int num17;
					int num18;
					if (!point)
					{
						num17 = 267779990;
						num18 = 267779990;
					}
					else
					{
						num17 = 1385097066;
						num18 = 1385097066;
					}
					num = num17 ^ ((int)num2 * -1719666035);
					continue;
				}
				case 20u:
					num11 = 1f - num10 * 0.9f / (float)Form1.smethod_27(2.0);
					num = 1608686035;
					continue;
				case 19u:
					num4 = 0;
					num = 1255012388;
					continue;
				case 18u:
					num3++;
					num = (int)((num2 * 968883653) ^ 0x4FD9DBCA);
					continue;
				case 17u:
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox[num3, num4]));
					dark = storage[num3, num4].Dark;
					num = ((int)num2 * -1084346058) ^ 0x6396B035;
					continue;
				case 16u:
					num6 = (float)size * (num11 / 2f) - 4f;
					num = (int)((num2 * 1067921781) ^ 0x71A82521);
					continue;
				case 15u:
					brush_ = Form1.smethod_26();
					num = 2134745529;
					continue;
				case 14u:
				{
					int num15;
					int num16;
					if (!flag2)
					{
						num15 = 88472644;
						num16 = 88472644;
					}
					else
					{
						num15 = 476668578;
						num16 = 476668578;
					}
					num = num15 ^ (int)(num2 * 877694023);
					continue;
				}
				case 13u:
				{
					int num13;
					int num14;
					if (!flag3)
					{
						num13 = -524102048;
						num14 = -524102048;
					}
					else
					{
						num13 = -1788328957;
						num14 = -1788328957;
					}
					num = num13 ^ (int)(num2 * 1913637006);
					continue;
				}
				case 12u:
					Form1.smethod_24(graphics_, (Brush)(object)Form1.smethod_29(Color.FromArgb(180, Color.Peru)), num6, num6, num7, num7);
					num = (int)((num2 * 1118455707) ^ 0x4A2A3EDE);
					continue;
				case 11u:
					num = ((int)num2 * -1401821699) ^ 0x1BE621C7;
					continue;
				case 10u:
					flag2 = num3 < 4;
					num = 1582656801;
					continue;
				case 8u:
					flag = num4 < 2;
					num = ((int)num2 * -1680190779) ^ -1354801051;
					continue;
				case 7u:
					num11 = 1f - num10 * 0.4f / (float)Form1.smethod_27(2.0);
					num6 = (float)size * (num11 / 2f) - 4f;
					num7 = num12 * 0.4f / (float)Form1.smethod_27(2.0);
					point = storage[num3, num4].Point;
					num = 2127955835;
					continue;
				case 6u:
					num = ((int)num2 * -1028267309) ^ -644441558;
					continue;
				case 5u:
					num10 = 0.7f;
					num = 1960326082;
					continue;
				case 4u:
					num = (int)((num2 * 785329826) ^ 0x3062ED6E);
					continue;
				case 3u:
					Form1.smethod_20(pictureBox[num3, num4], (Image)(object)Form1.smethod_19(Form1.smethod_18((Control)(object)pictureBox[num3, num4]), Form1.smethod_16((Control)(object)pictureBox[num3, num4])));
					num = (int)(num2 * 453101392) ^ -1662970748;
					continue;
				case 2u:
				{
					int num8;
					int num9;
					if (!dark)
					{
						num8 = 181369994;
						num9 = 181369994;
					}
					else
					{
						num8 = 882165648;
						num9 = 882165648;
					}
					num = num8 ^ ((int)num2 * -1526788653);
					continue;
				}
				case 1u:
					num = (int)(num2 * 1487816936) ^ -1863507558;
					continue;
				case 0u:
				{
					int num5;
					if (storage[num3, num4].Big)
					{
						num = 112272414;
						num5 = 112272414;
					}
					else
					{
						num = 1435428035;
						num5 = 1435428035;
					}
					continue;
				}
				default:
					return;
				case 9u:
					break;
				case 36u:
					return;
				}
				break;
			}
		}
	}

	public void StartGame()
	{
		bool flag = default(bool);
		int num3 = default(int);
		int num4 = default(int);
		int num9 = default(int);
		int num5 = default(int);
		while (true)
		{
			int num = -574155587;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8CAE8FD6u) % 30u)
				{
				case 29u:
					num = ((int)num2 * -1388138084) ^ -964628138;
					continue;
				case 28u:
					num = ((int)num2 * -664375190) ^ 0x6AF8404;
					continue;
				case 26u:
				{
					int num7;
					int num8;
					if (!flag)
					{
						num7 = 487903159;
						num8 = 487903159;
					}
					else
					{
						num7 = 1934174341;
						num8 = 1934174341;
					}
					num = num7 ^ ((int)num2 * -1339071076);
					continue;
				}
				case 25u:
					num3++;
					num = ((int)num2 * -752574269) ^ 0x21E8E2B9;
					continue;
				case 24u:
				{
					int num10;
					if (num4 >= 4)
					{
						num = -199128447;
						num10 = -199128447;
					}
					else
					{
						num = -253117578;
						num10 = -253117578;
					}
					continue;
				}
				case 23u:
					num = ((int)num2 * -173038892) ^ -225168144;
					continue;
				case 22u:
					step = 1;
					num = (int)(num2 * 1133177744) ^ -455739715;
					continue;
				case 21u:
					num = ((int)num2 * -407242941) ^ -1984649757;
					continue;
				case 20u:
					num3 = 0;
					num = (int)(num2 * 1542190432) ^ -987421277;
					continue;
				case 19u:
					num = (int)(num2 * 2079558942) ^ -1089423649;
					continue;
				case 18u:
					num4++;
					num = (int)((num2 * 730101990) ^ 0x418E2EC4);
					continue;
				case 17u:
					num9 = Form1.smethod_33(rnd, 4);
					num = -1441523781;
					continue;
				case 16u:
					time = new DateTime(0L, DateTimeKind.Unspecified);
					Form1.smethod_35(timer1, bool_0: true);
					num = (int)((num2 * 1859367800) ^ 0x69731113);
					continue;
				case 15u:
					flag = turn;
					num = (int)((num2 * 1270775113) ^ 0x6EC8ADBD);
					continue;
				case 14u:
					Form1.smethod_5((Control)(object)borderBox[num9, num5], Color.Blue);
					num = (int)((num2 * 443218263) ^ 0x3EE41B76);
					continue;
				case 13u:
					Form1_Load(this, Form1.smethod_31());
					num = ((int)num2 * -2039279547) ^ -224188706;
					continue;
				case 12u:
				{
					int num6;
					if (num3 < 4)
					{
						num = -904069887;
						num6 = -904069887;
					}
					else
					{
						num = -629195418;
						num6 = -629195418;
					}
					continue;
				}
				case 11u:
					Form1.smethod_36(timer1);
					num = (int)(num2 * 2023900729) ^ -1304422845;
					continue;
				case 10u:
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: true);
					num = ((int)num2 * -1899080693) ^ 0x5C801F83;
					continue;
				case 9u:
					num = (int)(num2 * 335766801) ^ -515689188;
					continue;
				case 7u:
					num4 = 0;
					num = -422402184;
					continue;
				case 6u:
					num = (int)(num2 * 1718598275) ^ -1268207581;
					continue;
				case 5u:
					num5 = Form1.smethod_33(rnd, 4);
					num = ((int)num2 * -705672953) ^ 0x3F30872D;
					continue;
				case 4u:
					Form1.smethod_32((Control)(object)richTextBox1, "Ваш ход. Выберете фигуру, которой будет играть противник.");
					num = ((int)num2 * -771241271) ^ 0x7233662A;
					continue;
				case 3u:
					Form1.smethod_32((Control)(object)richTextBox1, "Противник выбрал фигуру. Выберете поле на доске для установки этой фигуры.");
					num = ((int)num2 * -24408745) ^ -1798626585;
					continue;
				case 2u:
					Form1.smethod_7((Control)(object)pictureBox[num3, num4], bool_0: true);
					num = -220161343;
					continue;
				case 1u:
					Form1.smethod_32((Control)(object)label2, Form1.smethod_34("Ход: ", step.ToString()));
					num = -722578126;
					continue;
				case 0u:
					step = 0;
					num = ((int)num2 * -347376655) ^ 0x34420BAB;
					continue;
				default:
					return;
				case 8u:
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
			int num = -1847952483;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8916243Bu) % 4u)
				{
				case 2u:
					time = time.AddSeconds(1.0);
					Form1.smethod_32((Control)(object)label1, Form1.smethod_34("Время: ", time.ToString("HH:mm:ss")));
					num = (int)((num2 * 1788490040) ^ 0xB251882);
					continue;
				case 1u:
					num = ((int)num2 * -2103411411) ^ 0x7071D721;
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

	private void PictureBoxIJ_MouseDown(object sender, MouseEventArgs e)
	{
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Expected O, but got Unknown
		int num4 = default(int);
		int num3 = default(int);
		int num9 = default(int);
		int num6 = default(int);
		bool flag = default(bool);
		while (true)
		{
			int num = -1315608319;
			while (true)
			{
				uint num2;
				int num11;
				switch ((num2 = (uint)num ^ 0xBE0D10C7u) % 23u)
				{
				case 22u:
					num4 = 0;
					num = ((int)num2 * -201822141) ^ -144511695;
					continue;
				case 21u:
					num = (int)((num2 * 1027332348) ^ 0x56331829);
					continue;
				case 19u:
					num3 -= 4;
					num = ((int)num2 * -1059629531) ^ 0x23C7068B;
					continue;
				case 18u:
					if (storage[num9, num3] != null)
					{
						num = -210100914;
						continue;
					}
					goto IL_0062;
				case 17u:
					num6 = 0;
					num = -1535999187;
					continue;
				case 16u:
					num = (int)((num2 * 1196334115) ^ 0x24AA8F25);
					continue;
				case 15u:
					num4++;
					num = (int)((num2 * 423244524) ^ 0x79338445);
					continue;
				case 14u:
					if (Form1.smethod_40((Bitmap)Form1.smethod_21(pictureBox[num9, num3]), Form1.smethod_38(e), Form1.smethod_39(e)) != Color.FromArgb(0, 0, 0, 0))
					{
						num = -2147401349;
						num11 = -2147401349;
						continue;
					}
					goto IL_0062;
				case 13u:
					num = ((int)num2 * -913087434) ^ -321959613;
					continue;
				case 12u:
					num6++;
					num = (int)(num2 * 1148489477) ^ -6998687;
					continue;
				case 11u:
					num9 = Form1.smethod_37((Control)((sender is PictureBox) ? sender : null)).Y / size;
					num = ((int)num2 * -488092324) ^ 0x281E0A51;
					continue;
				case 10u:
					num3 = Form1.smethod_37((Control)((sender is PictureBox) ? sender : null)).X / size;
					num = ((int)num2 * -2143462112) ^ -1267459550;
					continue;
				case 9u:
					Form1.smethod_5((Control)(object)borderBox[num9, num3], Color.Red);
					num = (int)((num2 * 1452773144) ^ 0x4413DE26);
					continue;
				case 8u:
				{
					int num10;
					if (num6 < 4)
					{
						num = -1018441651;
						num10 = -1018441651;
					}
					else
					{
						num = -76398199;
						num10 = -76398199;
					}
					continue;
				}
				case 7u:
				{
					int num7;
					int num8;
					if (flag)
					{
						num7 = 29818092;
						num8 = 29818092;
					}
					else
					{
						num7 = 1030807740;
						num8 = 1030807740;
					}
					num = num7 ^ ((int)num2 * -1694647827);
					continue;
				}
				case 5u:
					num = (int)(num2 * 299157695) ^ -1018799945;
					continue;
				case 4u:
					Form1.smethod_5((Control)(object)borderBox[num4, num6], Color.White);
					num = -374027015;
					continue;
				case 3u:
				{
					int num5;
					if (num4 >= 4)
					{
						num = -517409932;
						num5 = -517409932;
					}
					else
					{
						num = -1947540463;
						num5 = -1947540463;
					}
					continue;
				}
				case 2u:
					flag = num3 > 1;
					num = (int)((num2 * 1726341375) ^ 0x4BBC3AA);
					continue;
				case 1u:
					num = ((int)num2 * -816527360) ^ -323301931;
					continue;
				case 0u:
					Form1.smethod_7((Control)(object)button2, bool_0: true);
					Form1.smethod_32((Control)(object)richTextBox1, "Именно эта фигура? Если да - нажмите \"Подтвердить\".");
					num = ((int)num2 * -23896171) ^ -1161346597;
					continue;
				default:
					return;
				case 20u:
					break;
				case 6u:
					return;
					IL_0062:
					num = -1533114923;
					num11 = -1533114923;
					continue;
				}
				break;
			}
		}
	}

	private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
	{
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0185: Expected O, but got Unknown
		int num3 = default(int);
		Graphics graphics_ = default(Graphics);
		int num6 = default(int);
		int num8 = default(int);
		int num7 = default(int);
		bool flag = default(bool);
		bool flag2 = default(bool);
		while (true)
		{
			int num = 1837697586;
			while (true)
			{
				uint num2;
				int num5;
				switch ((num2 = (uint)num ^ 0xF7C79E9u) % 27u)
				{
				case 26u:
					num3 = 0;
					num = (int)(num2 * 386866796) ^ -1463068924;
					continue;
				case 25u:
					num = ((int)num2 * -1371117739) ^ -319862573;
					continue;
				case 24u:
					num = ((int)num2 * -1041758337) ^ 0x3562EAFA;
					continue;
				case 23u:
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox1));
					num = ((int)num2 * -582068051) ^ 0x7CC177E7;
					continue;
				case 22u:
				{
					int num13;
					if (num6 >= 4)
					{
						num = 1198884065;
						num13 = 1198884065;
					}
					else
					{
						num = 1882365176;
						num13 = 1882365176;
					}
					continue;
				}
				case 20u:
					Form1.smethod_43(graphics_, Form1.smethod_42(Color.Red, 3f), ((float)num8 + 0.05f) * (float)size, ((float)num7 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					Form1.smethod_44(graphics_, Form1.smethod_21(pictureBox[num3, num6]), num8 * size + 4, num7 * size + 4, new Rectangle(0, 0, size, size), (GraphicsUnit)2);
					num = ((int)num2 * -1776650918) ^ -12357702;
					continue;
				case 19u:
					num = (int)((num2 * 2117765455) ^ 0x3C28BF80);
					continue;
				case 18u:
					Form1.smethod_32((Control)(object)richTextBox1, "Уверены? Для выполнения данного хода нажмите \"Подтвердить\".");
					num = ((int)num2 * -398607083) ^ -807454320;
					continue;
				case 17u:
					if (Form1.smethod_40((Bitmap)Form1.smethod_21(pictureBox1), Form1.smethod_38(e), Form1.smethod_39(e)) != Color.FromArgb(0, 0, 0, 0))
					{
						num = ((int)num2 * -1062188221) ^ 0x22591F17;
						continue;
					}
					num5 = 0;
					goto IL_01a9;
				case 16u:
					num6 = 0;
					num = 451641221;
					continue;
				case 15u:
				{
					int num11;
					int num12;
					if (flag)
					{
						num11 = -2032966468;
						num12 = -2032966468;
					}
					else
					{
						num11 = -953518111;
						num12 = -953518111;
					}
					num = num11 ^ (int)(num2 * 260301297);
					continue;
				}
				case 14u:
					Form1.smethod_30((Control)(object)pictureBox1);
					num = ((int)num2 * -128127786) ^ -456402633;
					continue;
				case 13u:
					Form1.smethod_45(graphics_);
					num = (int)(num2 * 1004491142) ^ -515126530;
					continue;
				case 12u:
					num = ((int)num2 * -1087514002) ^ -1660779102;
					continue;
				case 11u:
					num7 = Form1.smethod_39(e) / size;
					num = (int)((num2 * 1387746189) ^ 0x14FFA3BD);
					continue;
				case 9u:
				{
					int num9;
					int num10;
					if (flag2)
					{
						num9 = 1367340866;
						num10 = 1367340866;
					}
					else
					{
						num9 = 972820637;
						num10 = 972820637;
					}
					num = num9 ^ ((int)num2 * -898104409);
					continue;
				}
				case 8u:
					num8 = Form1.smethod_38(e) / size;
					num = (int)((num2 * 1184251273) ^ 0x47E8DF41);
					continue;
				case 7u:
					Form1.smethod_7((Control)(object)button2, bool_0: true);
					num = ((int)num2 * -1552911463) ^ 0x4339E2AB;
					continue;
				case 6u:
					Paint_Board();
					num = ((int)num2 * -210792058) ^ -969848716;
					continue;
				case 5u:
					num5 = ((board[num7, num8] == null) ? 1 : 0);
					goto IL_01a9;
				case 4u:
					flag2 = Form1.smethod_41((Control)(object)borderBox[num3, num6]) == Color.Blue;
					num = 1745763535;
					continue;
				case 3u:
					num3++;
					num = (int)(num2 * 1748649815) ^ -753189516;
					continue;
				case 2u:
					num6++;
					num = 451641221;
					continue;
				case 1u:
				{
					int num4;
					if (num3 < 4)
					{
						num = 674338877;
						num4 = 674338877;
					}
					else
					{
						num = 1424097602;
						num4 = 1424097602;
					}
					continue;
				}
				case 0u:
					num = (int)((num2 * 1621434095) ^ 0x462D7736);
					continue;
				default:
					return;
				case 10u:
					break;
				case 21u:
					return;
					IL_01a9:
					flag = (byte)num5 != 0;
					num = 975205434;
					continue;
				}
				break;
			}
		}
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		//IL_0c1c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c4a: Expected O, but got Unknown
		Form1.smethod_7((Control)(object)button2, bool_0: false);
		int num31 = default(int);
		Graphics graphics_ = default(Graphics);
		int num3 = default(int);
		int num4 = default(int);
		int num17 = default(int);
		int num13 = default(int);
		int num30 = default(int);
		int num20 = default(int);
		bool flag15 = default(bool);
		bool flag14 = default(bool);
		int num19 = default(int);
		int num25 = default(int);
		int num12 = default(int);
		bool flag = default(bool);
		int num34 = default(int);
		int num35 = default(int);
		Figurine[,] array = default(Figurine[,]);
		int num16 = default(int);
		bool flag4 = default(bool);
		int num26 = default(int);
		bool flag12 = default(bool);
		int num11 = default(int);
		bool flag13 = default(bool);
		Figurine[,] array2 = default(Figurine[,]);
		bool flag5 = default(bool);
		int num6 = default(int);
		int num7 = default(int);
		bool flag10 = default(bool);
		Figurine[,] array3 = default(Figurine[,]);
		bool flag7 = default(bool);
		int num5 = default(int);
		bool flag6 = default(bool);
		int num15 = default(int);
		int num9 = default(int);
		int num10 = default(int);
		bool flag16 = default(bool);
		bool flag9 = default(bool);
		bool flag2 = default(bool);
		bool flag8 = default(bool);
		bool flag11 = default(bool);
		bool flag3 = default(bool);
		while (true)
		{
			int num = 1547192435;
			while (true)
			{
				uint num2;
				int num42;
				int num60;
				int num37;
				int num36;
				switch ((num2 = (uint)num ^ 0x32CF5A06u) % 171u)
				{
				case 170u:
					num31++;
					num = ((int)num2 * -1836109514) ^ -1345656680;
					continue;
				case 169u:
					Form1.smethod_44(graphics_, Form1.smethod_21(pictureBox[num3, num4]), num17 * size + 4, num13 * size + 4, new Rectangle(0, 0, size, size), (GraphicsUnit)2);
					num = ((int)num2 * -1435784154) ^ 0x23913BB2;
					continue;
				case 168u:
					num30 = 0;
					num = (int)((num2 * 2136300428) ^ 0x3BA7EB89);
					continue;
				case 167u:
					num = (int)((num2 * 1268746042) ^ 0x2B2480BE);
					continue;
				case 166u:
					num42 = ((num20 == num4) ? 1 : 0);
					goto IL_00b1;
				case 165u:
				{
					int num58;
					int num59;
					if (flag15)
					{
						num58 = 1189020359;
						num59 = 1189020359;
					}
					else
					{
						num58 = 1232446792;
						num59 = 1232446792;
					}
					num = num58 ^ (int)(num2 * 98393971);
					continue;
				}
				case 164u:
				{
					int num51;
					int num52;
					if (!flag14)
					{
						num51 = -928208476;
						num52 = -928208476;
					}
					else
					{
						num51 = -1871537933;
						num52 = -1871537933;
					}
					num = num51 ^ ((int)num2 * -1429384783);
					continue;
				}
				case 163u:
					num19 = Form1.smethod_33(rnd, 4);
					num20 = Form1.smethod_33(rnd, 4);
					num = 598987996;
					continue;
				case 162u:
					Form1.smethod_43(graphics_, Form1.smethod_42(Color.LimeGreen, 3f), ((float)num17 + 0.05f) * (float)size, ((float)num13 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					num = ((int)num2 * -1759254910) ^ -546848500;
					continue;
				case 161u:
					num25 = 0;
					num = ((int)num2 * -1510179535) ^ 0xB752F3F;
					continue;
				case 160u:
					num12 = 0;
					num = ((int)num2 * -547082795) ^ -986493405;
					continue;
				case 159u:
				{
					int num63;
					int num64;
					if (flag)
					{
						num63 = 1244631367;
						num64 = 1244631367;
					}
					else
					{
						num63 = 1963990437;
						num64 = 1963990437;
					}
					num = num63 ^ (int)(num2 * 1295431714);
					continue;
				}
				case 158u:
					Form1.smethod_43(graphics_, Form1.smethod_42(Color.LimeGreen, 3f), ((float)num34 + 0.05f) * (float)size, ((float)num35 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					num = ((int)num2 * -1271146775) ^ -935810163;
					continue;
				case 157u:
					array[num35, num34] = new Figurine(storage[num3, num4]);
					num16 = 0;
					num = ((int)num2 * -580899746) ^ -719285894;
					continue;
				case 156u:
					num = (int)(num2 * 56497577) ^ -1042116366;
					continue;
				case 155u:
				{
					int num55;
					int num56;
					if (flag4)
					{
						num55 = -942435274;
						num56 = -942435274;
					}
					else
					{
						num55 = -1514270932;
						num56 = -1514270932;
					}
					num = num55 ^ ((int)num2 * -1530564900);
					continue;
				}
				case 154u:
					num = ((int)num2 * -1929739128) ^ 0x7581B557;
					continue;
				case 153u:
					Form1.smethod_5((Control)(object)borderBox[num25, num26], Color.White);
					num = (int)((num2 * 1709090701) ^ 0x25C353AA);
					continue;
				case 152u:
				{
					int num47;
					int num48;
					if (flag12)
					{
						num47 = -367574198;
						num48 = -367574198;
					}
					else
					{
						num47 = -1005848625;
						num48 = -1005848625;
					}
					num = num47 ^ ((int)num2 * -685798299);
					continue;
				}
				case 151u:
					num26 = 0;
					num = 667332908;
					continue;
				case 150u:
					storage[num11, num12] = null;
					Paint_Board();
					num = ((int)num2 * -339441162) ^ 0x340EE980;
					continue;
				case 149u:
					num25++;
					num = ((int)num2 * -1894993640) ^ 0x21349E93;
					continue;
				case 148u:
					num = (int)((num2 * 102102787) ^ 0x14EA692);
					continue;
				case 147u:
					num = ((int)num2 * -842083480) ^ -1592073592;
					continue;
				case 146u:
					num = (int)(num2 * 918997089) ^ -366393385;
					continue;
				case 145u:
					board[num13, num17] = new Figurine(storage[num3, num4]);
					storage[num3, num4] = null;
					num = (int)((num2 * 246895917) ^ 0x381CF86F);
					continue;
				case 144u:
					flag13 = Stop(array2);
					num = ((int)num2 * -807957878) ^ -1366040325;
					continue;
				case 143u:
					Form1.smethod_30((Control)(object)pictureBox[num3, num4]);
					num = (int)((num2 * 1657922890) ^ 0x4F0B267F);
					continue;
				case 142u:
					num26++;
					num = (int)(num2 * 1160352494) ^ -1592243458;
					continue;
				case 141u:
					flag5 = num25 < 4;
					num = 181121173;
					continue;
				case 140u:
					num3 = num6;
					num4 = num7;
					num = ((int)num2 * -1681575385) ^ -1584653337;
					continue;
				case 139u:
				{
					int num38;
					int num39;
					if (flag10)
					{
						num38 = 794141112;
						num39 = 794141112;
					}
					else
					{
						num38 = 345656407;
						num39 = 345656407;
					}
					num = num38 ^ ((int)num2 * -1058416333);
					continue;
				}
				case 138u:
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox1));
					num = ((int)num2 * -1173772255) ^ 0xB01EF53;
					continue;
				case 137u:
					num = ((int)num2 * -1393484841) ^ 0x89D99FB;
					continue;
				case 136u:
					array3 = (Figurine[,])Form1.smethod_48((Array)board);
					num = (int)(num2 * 837795446) ^ -855853411;
					continue;
				case 135u:
					Form1.smethod_30((Control)(object)label2);
					num = ((int)num2 * -1114292949) ^ 0xAD5336F;
					continue;
				case 134u:
					Form1.smethod_32((Control)(object)richTextBox1, "Подождите, компьютер делает свой ход.");
					Form1.smethod_30((Control)(object)richTextBox1);
					num = (int)(num2 * 1701080850) ^ -310712103;
					continue;
				case 133u:
					Form1.smethod_7((Control)(object)pictureBox[num30, num31], bool_0: true);
					num = 969205933;
					continue;
				case 132u:
					Form1.smethod_47(1000);
					num = (int)(num2 * 1430937615) ^ -1763353685;
					continue;
				case 131u:
					Form1.smethod_32((Control)(object)richTextBox1, "QUARTO! Компьютер выиграл!");
					num = 400774638;
					continue;
				case 130u:
					flag7 = num5 < 4;
					num = 686862954;
					continue;
				case 129u:
					flag6 = Standoff(board);
					num = ((int)num2 * -1810563397) ^ 0x179DF1CB;
					continue;
				case 128u:
					num = (int)(num2 * 1114532125) ^ -633887716;
					continue;
				case 127u:
					num = ((int)num2 * -176364874) ^ -811709640;
					continue;
				case 126u:
					flag4 = num17 < 4;
					num = 1411630909;
					continue;
				case 125u:
					num = (int)(num2 * 230603308) ^ -718853852;
					continue;
				case 124u:
					Form1.smethod_15(timer1);
					num = 1961560328;
					continue;
				case 123u:
					array2 = (Figurine[,])Form1.smethod_48((Array)array);
					array2[num16, num5] = new Figurine(storage[num19, num20]);
					num = ((int)num2 * -1112683073) ^ 0x46E3EC1B;
					continue;
				case 122u:
					num11 = 0;
					num = ((int)num2 * -1307744980) ^ 0x504068B1;
					continue;
				case 121u:
					num15 = 0;
					num = (int)((num2 * 1353363037) ^ 0x405B1B13);
					continue;
				case 120u:
					num3 = 0;
					num4 = 0;
					num = (int)((num2 * 1346351972) ^ 0x709A8E58);
					continue;
				case 119u:
					num = (int)((num2 * 600039088) ^ 0x21CFF7EA);
					continue;
				case 117u:
					board[num9, num10] = new Figurine(storage[num11, num12]);
					num = ((int)num2 * -737856770) ^ 0x745F39AA;
					continue;
				case 116u:
					num31 = 0;
					num = 444369946;
					continue;
				case 114u:
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: true);
					step++;
					Form1.smethod_32((Control)(object)label2, Form1.smethod_34("Ход: ", step.ToString()));
					num = ((int)num2 * -1069330188) ^ 0x7EAA5D34;
					continue;
				case 113u:
					num60 = ((num15 < 9) ? 1 : 0);
					goto IL_0764;
				case 112u:
					num17 = 0;
					num = 1305655563;
					continue;
				case 111u:
					Form1.smethod_32((Control)(object)richTextBox1, "Ничья!");
					Form1.smethod_15(timer1);
					num = (int)(num2 * 1839514436) ^ -1766610130;
					continue;
				case 110u:
					flag16 = board[num35, num34] != null;
					num = ((int)num2 * -351932272) ^ 0x43AAE6EC;
					continue;
				case 109u:
				{
					int num65;
					int num66;
					if (!flag16)
					{
						num65 = -1476276488;
						num66 = -1476276488;
					}
					else
					{
						num65 = -1000966262;
						num66 = -1000966262;
					}
					num = num65 ^ (int)(num2 * 1538733021);
					continue;
				}
				case 108u:
					flag9 = num6 < 4;
					num = 2023689665;
					continue;
				case 107u:
				{
					int num61;
					int num62;
					if (Form1.smethod_46((Control)(object)pictureBox1))
					{
						num61 = 1506830150;
						num62 = 1506830150;
					}
					else
					{
						num61 = 674572537;
						num62 = 674572537;
					}
					num = num61 ^ (int)(num2 * 300518709);
					continue;
				}
				case 106u:
					board[num35, num34] = new Figurine(storage[num3, num4]);
					num = ((int)num2 * -163922542) ^ 0x43BBD559;
					continue;
				case 105u:
					flag10 = num7 < 4;
					num = 289563214;
					continue;
				case 104u:
					num7++;
					num = ((int)num2 * -394174917) ^ -1223545153;
					continue;
				case 103u:
					num5 = 0;
					num = 2020724695;
					continue;
				case 102u:
					if (!flag2)
					{
						num = ((int)num2 * -1562121478) ^ 0x5D897A30;
						continue;
					}
					num60 = 1;
					goto IL_0764;
				case 101u:
					(menu as Form3).ContinueLock();
					num = ((int)num2 * -1054617848) ^ 0x69A393E1;
					continue;
				case 100u:
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: false);
					num = ((int)num2 * -598113380) ^ 0x4383E4D6;
					continue;
				case 99u:
					num34 = Form1.smethod_33(rnd, 4);
					num = ((int)num2 * -415845408) ^ 0x2F13B3D1;
					continue;
				case 98u:
					Form1.smethod_30((Control)(object)borderBox[num3, num4]);
					Form1.smethod_20(pictureBox[num3, num4], (Image)null);
					num = (int)((num2 * 1145111774) ^ 0x5FF74A51);
					continue;
				case 97u:
				{
					int num57;
					if (Form1.smethod_41((Control)(object)borderBox[num25, num26]) == Color.Blue)
					{
						num = 1894209326;
						num57 = 1894209326;
					}
					else
					{
						num = 760962334;
						num57 = 760962334;
					}
					continue;
				}
				case 96u:
				{
					int num53;
					int num54;
					if (!flag13)
					{
						num53 = 578754293;
						num54 = 578754293;
					}
					else
					{
						num53 = 914088353;
						num54 = 914088353;
					}
					num = num53 ^ ((int)num2 * -1748439101);
					continue;
				}
				case 95u:
					array = (Figurine[,])Form1.smethod_48((Array)board);
					num = ((int)num2 * -669992137) ^ -200589741;
					continue;
				case 94u:
					storage[num3, num4] = null;
					Form1.smethod_5((Control)(object)borderBox[num19, num20], Color.Blue);
					Form1.smethod_30((Control)(object)borderBox[num19, num20]);
					num = ((int)num2 * -841812575) ^ -840244937;
					continue;
				case 93u:
					num = (int)(num2 * 1059970865) ^ -1843314051;
					continue;
				case 92u:
					num13++;
					num = ((int)num2 * -1494169924) ^ 0x58CD43DA;
					continue;
				case 91u:
					(menu as Form3).ContinueLock();
					num = (int)((num2 * 695074594) ^ 0x30EB61CE);
					continue;
				case 90u:
				{
					int num49;
					int num50;
					if (!flag7)
					{
						num49 = 97808527;
						num50 = 97808527;
					}
					else
					{
						num49 = 1624334826;
						num50 = 1624334826;
					}
					num = num49 ^ (int)(num2 * 2023610859);
					continue;
				}
				case 89u:
					num = (int)((num2 * 1588830445) ^ 0xAAC41FE);
					continue;
				case 88u:
					num = (int)((num2 * 870779332) ^ 0x215F68C1);
					continue;
				case 87u:
					num = (int)(num2 * 1170638508) ^ -677251019;
					continue;
				case 86u:
					num = (int)((num2 * 1594193165) ^ 0x5F3EFA82);
					continue;
				case 85u:
					Form1.smethod_30((Control)(object)borderBox[num6, num7]);
					num = ((int)num2 * -1777365951) ^ -1665929761;
					continue;
				case 84u:
					num37 = ((!Standoff(board)) ? 1 : 0);
					goto IL_0b3b;
				case 83u:
					num = (int)((num2 * 945603876) ^ 0x558C0912);
					continue;
				case 82u:
					num10 = num26;
					num = (int)(num2 * 131233252) ^ -750366328;
					continue;
				case 81u:
					num = ((int)num2 * -1219961407) ^ 0x18409244;
					continue;
				case 80u:
					num = (int)((num2 * 1334877407) ^ 0x371A92A5);
					continue;
				case 79u:
				{
					int num45;
					int num46;
					if (flag6)
					{
						num45 = -1900213719;
						num46 = -1900213719;
					}
					else
					{
						num45 = -1614386852;
						num46 = -1614386852;
					}
					num = num45 ^ ((int)num2 * -1838279020);
					continue;
				}
				case 78u:
					num11 = num25;
					num = ((int)num2 * -1145531816) ^ 0x2F1B18B5;
					continue;
				case 77u:
					if (storage[num19, num20] != null)
					{
						num = (int)(num2 * 1835098677) ^ -607240112;
						continue;
					}
					num42 = 1;
					goto IL_00b1;
				case 76u:
					flag8 = num16 < 4;
					num = 299494422;
					continue;
				case 75u:
				{
					int num44;
					if (Form1.smethod_40((Bitmap)Form1.smethod_21(pictureBox1), num26 * size + size / 2, (int)(((float)num25 + 0.05f) * (float)size)) == Color.FromArgb(255, 255, 0, 0))
					{
						num = 1631594135;
						num44 = 1631594135;
					}
					else
					{
						num = 1843395274;
						num44 = 1843395274;
					}
					continue;
				}
				case 74u:
					Form1.smethod_20(pictureBox[num3, num4], (Image)null);
					num = ((int)num2 * -922730152) ^ 0x6015F939;
					continue;
				case 73u:
					num = 809526907;
					continue;
				case 72u:
					flag11 = num30 < 4;
					num = 1693707541;
					continue;
				case 71u:
					Form1.smethod_30((Control)(object)pictureBox[num25, num26]);
					num = ((int)num2 * -1828013079) ^ 0x5B39DEE3;
					continue;
				case 70u:
					if (!Stop(array3))
					{
						num = ((int)num2 * -1345097365) ^ -1231193638;
						continue;
					}
					goto IL_0d08;
				case 69u:
					num = (int)(num2 * 959455010) ^ -1765952990;
					continue;
				case 68u:
				{
					int num43;
					if (num31 >= 4)
					{
						num = 832209816;
						num43 = 832209816;
					}
					else
					{
						num = 1691446655;
						num43 = 1691446655;
					}
					continue;
				}
				case 67u:
					num = ((int)num2 * -1429170413) ^ -1348172038;
					continue;
				case 66u:
					if (num19 == num3)
					{
						num = ((int)num2 * -891491181) ^ 0x59B87CC1;
						continue;
					}
					num42 = 0;
					goto IL_00b1;
				case 65u:
					flag12 = Form1.smethod_41((Control)(object)borderBox[num6, num7]) == Color.Red;
					num = ((int)num2 * -550917296) ^ 0x3ECF336E;
					continue;
				case 64u:
					Form1.smethod_32((Control)(object)richTextBox1, "Выберете фигуру, которой будет играть противник.");
					num = ((int)num2 * -894254233) ^ -2006336384;
					continue;
				case 63u:
					num6 = 0;
					num = ((int)num2 * -295747598) ^ -656252264;
					continue;
				case 62u:
					num = (int)(num2 * 923683073) ^ -1126766030;
					continue;
				case 61u:
					num = 955659675;
					continue;
				case 60u:
				{
					int num40;
					int num41;
					if (flag11)
					{
						num40 = 1249471622;
						num41 = 1249471622;
					}
					else
					{
						num40 = 1899784462;
						num41 = 1899784462;
					}
					num = num40 ^ (int)(num2 * 138816670);
					continue;
				}
				case 59u:
					num35 = Form1.smethod_33(rnd, 4);
					num = 718920615;
					continue;
				case 58u:
					num = ((int)num2 * -305343844) ^ 0x2BAA065F;
					continue;
				case 57u:
					flag2 = true;
					num = (int)(num2 * 1907251702) ^ -1258746346;
					continue;
				case 56u:
					num = 1845404999;
					continue;
				case 55u:
					if (!Stop(board))
					{
						num = (int)(num2 * 504651167) ^ -493711812;
						continue;
					}
					num37 = 0;
					goto IL_0b3b;
				case 54u:
					step++;
					num = ((int)num2 * -930830813) ^ 0x4C5FDC7B;
					continue;
				case 53u:
					num = ((int)num2 * -966201590) ^ -434071564;
					continue;
				case 52u:
					num = 2095878553;
					continue;
				case 51u:
					num6++;
					num = ((int)num2 * -321648483) ^ 0x4EB85944;
					continue;
				case 50u:
					num9 = 0;
					num10 = 0;
					num = (int)((num2 * 921393744) ^ 0x535A03FA);
					continue;
				case 49u:
					num30++;
					num = ((int)num2 * -1703165206) ^ -2027688748;
					continue;
				case 48u:
					if (!Standoff(array3))
					{
						num = 2140610329;
						num36 = 2140610329;
						continue;
					}
					goto IL_0d08;
				case 47u:
					Form1.smethod_44(graphics_, Form1.smethod_21(pictureBox[num3, num4]), num34 * size + 4, num35 * size + 4, new Rectangle(0, 0, size, size), (GraphicsUnit)2);
					num = (int)(num2 * 441727914) ^ -1977903289;
					continue;
				case 46u:
					Form1.smethod_5((Control)(object)borderBox[num6, num7], Color.LimeGreen);
					num = ((int)num2 * -1213945824) ^ 0x77BFDC1E;
					continue;
				case 45u:
					num17++;
					num = 1305655563;
					continue;
				case 44u:
					num = ((int)num2 * -1645717563) ^ 0x1E1D5B1F;
					continue;
				case 43u:
					Form1.smethod_32((Control)(object)label2, Form1.smethod_34("Ход: ", step.ToString()));
					num = (int)((num2 * 900376483) ^ 0x263DE4F);
					continue;
				case 42u:
					Form1.smethod_30((Control)(object)pictureBox1);
					num = ((int)num2 * -733217595) ^ -1198989377;
					continue;
				case 41u:
					Form1.smethod_20(pictureBox[num25, num26], (Image)null);
					num = (int)(num2 * 398338634) ^ -1170738425;
					continue;
				case 40u:
					Form1.smethod_32((Control)(object)richTextBox1, "Ничья!");
					num = (int)((num2 * 61070864) ^ 0x22AF73A5);
					continue;
				case 39u:
					num9 = num25;
					num = ((int)num2 * -860529261) ^ 0x2228B305;
					continue;
				case 38u:
				{
					int num32;
					int num33;
					if (flag9)
					{
						num32 = 2024340515;
						num33 = 2024340515;
					}
					else
					{
						num32 = 1518633879;
						num33 = 1518633879;
					}
					num = num32 ^ ((int)num2 * -1497089148);
					continue;
				}
				case 37u:
					num12 = num26;
					num = ((int)num2 * -954648566) ^ 0x6EB30542;
					continue;
				case 36u:
					Form1.smethod_30((Control)(object)borderBox[num3, num4]);
					num = ((int)num2 * -1214794080) ^ -888642542;
					continue;
				case 35u:
					array3[num13, num17] = new Figurine(storage[num3, num4]);
					num = (int)(num2 * 717786546) ^ -276588205;
					continue;
				case 34u:
					num = 911641599;
					continue;
				case 33u:
				{
					int num28;
					int num29;
					if (flag8)
					{
						num28 = 2119378;
						num29 = 2119378;
					}
					else
					{
						num28 = 1002743507;
						num29 = 1002743507;
					}
					num = num28 ^ ((int)num2 * -39652779);
					continue;
				}
				case 32u:
					num = ((int)num2 * -707455956) ^ 0x57D6EFAA;
					continue;
				case 31u:
				{
					int num27;
					if (num26 < 4)
					{
						num = 293882997;
						num27 = 293882997;
					}
					else
					{
						num = 417461948;
						num27 = 417461948;
					}
					continue;
				}
				case 30u:
					num = (int)((num2 * 1459264169) ^ 0x34624A8E);
					continue;
				case 29u:
					num = 2027903337;
					continue;
				case 28u:
					num13 = 0;
					num = (int)((num2 * 268474954) ^ 0x50E8D34D);
					continue;
				case 27u:
					Form1.smethod_30((Control)(object)borderBox[num25, num26]);
					num = (int)((num2 * 401952476) ^ 0x5C17E13C);
					continue;
				case 26u:
					Form1.smethod_47(200);
					num = ((int)num2 * -410095644) ^ -814223821;
					continue;
				case 25u:
					num = (int)((num2 * 1072360267) ^ 0x44C23703);
					continue;
				case 24u:
				{
					int num23;
					int num24;
					if (!flag5)
					{
						num23 = -194448624;
						num24 = -194448624;
					}
					else
					{
						num23 = -1870145516;
						num24 = -1870145516;
					}
					num = num23 ^ ((int)num2 * -1579679080);
					continue;
				}
				case 23u:
					num = ((int)num2 * -1081567187) ^ -370649551;
					continue;
				case 22u:
				{
					int num21;
					int num22;
					if (!flag3)
					{
						num21 = 2015113162;
						num22 = 2015113162;
					}
					else
					{
						num21 = 777446025;
						num22 = 777446025;
					}
					num = num21 ^ ((int)num2 * -1556189551);
					continue;
				}
				case 21u:
					num = (int)((num2 * 591067588) ^ 0x3CBA3969);
					continue;
				case 20u:
					num7 = 0;
					num = 695570002;
					continue;
				case 19u:
					num = (int)((num2 * 1836643801) ^ 0x2285CC);
					continue;
				case 18u:
					num15++;
					flag2 = false;
					num = 857643512;
					continue;
				case 17u:
					num = ((int)num2 * -1635174964) ^ -866261133;
					continue;
				case 16u:
				{
					int num18;
					if (array[num16, num5] == null)
					{
						num = 813270557;
						num18 = 813270557;
					}
					else
					{
						num = 1845404999;
						num18 = 1845404999;
					}
					continue;
				}
				case 15u:
					flag = board[num13, num17] == null;
					num = 1080337401;
					continue;
				case 14u:
					num = 2004092419;
					continue;
				case 13u:
					num16++;
					num = ((int)num2 * -188514140) ^ -995301534;
					continue;
				case 12u:
					Form1.smethod_32((Control)(object)richTextBox1, "Противник сделал ход (зелёный). Выберете поле на доске для выбронной противником фигуры (синий).");
					num = (int)(num2 * 560320930) ^ -761787934;
					continue;
				case 11u:
				{
					int num14;
					if (num13 >= 4)
					{
						num = 635212097;
						num14 = 635212097;
					}
					else
					{
						num = 1368431491;
						num14 = 1368431491;
					}
					continue;
				}
				case 10u:
					num = (int)(num2 * 1713306052) ^ -799046650;
					continue;
				case 9u:
					Form1.smethod_30((Control)(object)pictureBox[num3, num4]);
					num = (int)((num2 * 1484653031) ^ 0x2A0893E5);
					continue;
				case 8u:
					Form1.smethod_47(200);
					Form1.smethod_5((Control)(object)borderBox[num3, num4], Color.White);
					num = (int)((num2 * 690019745) ^ 0x3D35A76C);
					continue;
				case 7u:
				{
					int num8;
					if (Standoff(board))
					{
						num = 898445643;
						num8 = 898445643;
					}
					else
					{
						num = 102169904;
						num8 = 102169904;
					}
					continue;
				}
				case 6u:
					Form1.smethod_7((Control)(object)pictureBox[num6, num7], bool_0: false);
					num = 2008363545;
					continue;
				case 5u:
					num = ((int)num2 * -448436157) ^ 0x15A1880E;
					continue;
				case 4u:
					Form1.smethod_30((Control)(object)pictureBox1);
					num = (int)(num2 * 1068302004) ^ -1171366496;
					continue;
				case 3u:
					num = ((int)num2 * -2020537309) ^ 0x77457EF;
					continue;
				case 2u:
					num5++;
					num = 2020724695;
					continue;
				case 1u:
					num = ((int)num2 * -1231188764) ^ 0x6DEE6759;
					continue;
				case 0u:
					Form1.smethod_5((Control)(object)borderBox[num3, num4], Color.White);
					num = (int)(num2 * 1945480333) ^ -1357820906;
					continue;
				default:
					return;
				case 115u:
					break;
				case 118u:
					return;
					IL_0d08:
					num = 1610732567;
					num36 = 1610732567;
					continue;
					IL_0b3b:
					flag14 = (byte)num37 != 0;
					num = 1597106828;
					continue;
					IL_00b1:
					flag3 = (byte)num42 != 0;
					num = 1054245717;
					continue;
					IL_0764:
					flag15 = (byte)num60 != 0;
					num = 1480282275;
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
			int num = 1813474840;
			while (true)
			{
				uint num2;
				int num8;
				int num67;
				switch ((num2 = (uint)num ^ 0x2569FA78u) % 76u)
				{
				case 75u:
				{
					int num63;
					if (mem[0, num3].Point == mem[1, num3].Point)
					{
						num = 1651614447;
						num63 = 1651614447;
					}
					else
					{
						num = 2054238983;
						num63 = 2054238983;
					}
					continue;
				}
				case 74u:
				{
					int num13;
					int num14;
					if (mem[num3, 1] != null)
					{
						num13 = 1253480187;
						num14 = 1253480187;
					}
					else
					{
						num13 = 867347185;
						num14 = 867347185;
					}
					num = num13 ^ ((int)num2 * -1649623443);
					continue;
				}
				case 73u:
				{
					int num65;
					int num66;
					if (mem[1, 2].Big == mem[2, 1].Big)
					{
						num65 = 1093923713;
						num66 = 1093923713;
					}
					else
					{
						num65 = 2055929097;
						num66 = 2055929097;
					}
					num = num65 ^ (int)(num2 * 1057836655);
					continue;
				}
				case 72u:
					if (mem[2, num3].Big != mem[3, num3].Big)
					{
						num = ((int)num2 * -1662549241) ^ 0x41E72382;
						continue;
					}
					goto IL_00dd;
				case 71u:
					if (mem[num3, 2].Square != mem[num3, 3].Square)
					{
						num = (int)((num2 * 2141887099) ^ 0x1CD5ED86);
						continue;
					}
					goto IL_0118;
				case 70u:
					if (mem[1, num3] != null)
					{
						num = ((int)num2 * -1034837704) ^ 0x7A4E3C0F;
						continue;
					}
					goto IL_0138;
				case 69u:
				{
					int num45;
					int num46;
					if (mem[1, 1] == null)
					{
						num45 = -1438458544;
						num46 = -1438458544;
					}
					else
					{
						num45 = -336360260;
						num46 = -336360260;
					}
					num = num45 ^ ((int)num2 * -1834999272);
					continue;
				}
				case 68u:
					num = ((int)num2 * -277881835) ^ 0x4C6354F4;
					continue;
				case 67u:
					num = 95222080;
					continue;
				case 66u:
				{
					int num29;
					if (mem[0, num3].Dark == mem[1, num3].Dark)
					{
						num = 1984646198;
						num29 = 1984646198;
					}
					else
					{
						num = 100184043;
						num29 = 100184043;
					}
					continue;
				}
				case 65u:
				{
					int num61;
					int num62;
					if (mem[1, 2].Dark != mem[2, 1].Dark)
					{
						num61 = 846513097;
						num62 = 846513097;
					}
					else
					{
						num61 = 166506566;
						num62 = 166506566;
					}
					num = num61 ^ ((int)num2 * -1803453273);
					continue;
				}
				case 64u:
				{
					int num47;
					int num48;
					if (mem[num3, 1].Square == mem[num3, 2].Square)
					{
						num47 = -934264209;
						num48 = -934264209;
					}
					else
					{
						num47 = -510738293;
						num48 = -510738293;
					}
					num = num47 ^ ((int)num2 * -686034368);
					continue;
				}
				case 63u:
				{
					int num39;
					int num40;
					if (mem[num3, 0].Big != mem[num3, 1].Big)
					{
						num39 = -623765061;
						num40 = -623765061;
					}
					else
					{
						num39 = -1982516602;
						num40 = -1982516602;
					}
					num = num39 ^ ((int)num2 * -1816451893);
					continue;
				}
				case 62u:
					num3++;
					num = ((int)num2 * -2118169740) ^ -250864851;
					continue;
				case 61u:
				{
					int num32;
					if (mem[num3, 0].Square != mem[num3, 1].Square)
					{
						num = 435841675;
						num32 = 435841675;
					}
					else
					{
						num = 539384592;
						num32 = 539384592;
					}
					continue;
				}
				case 60u:
				{
					int num21;
					int num22;
					if (mem[2, 2] == null)
					{
						num21 = -1337019908;
						num22 = -1337019908;
					}
					else
					{
						num21 = -1894329360;
						num22 = -1894329360;
					}
					num = num21 ^ ((int)num2 * -57655109);
					continue;
				}
				case 59u:
				{
					int num69;
					int num70;
					if (mem[1, num3].Point != mem[2, num3].Point)
					{
						num69 = -369852270;
						num70 = -369852270;
					}
					else
					{
						num69 = -1890672763;
						num70 = -1890672763;
					}
					num = num69 ^ (int)(num2 * 369397427);
					continue;
				}
				case 58u:
				{
					int num57;
					int num58;
					if (flag2)
					{
						num57 = 2110618897;
						num58 = 2110618897;
					}
					else
					{
						num57 = 775916504;
						num58 = 775916504;
					}
					num = num57 ^ ((int)num2 * -698234391);
					continue;
				}
				case 57u:
					if (mem[2, num3].Dark != mem[3, num3].Dark)
					{
						num = ((int)num2 * -1806228968) ^ -1019744109;
						continue;
					}
					goto IL_00dd;
				case 56u:
				{
					int num51;
					int num52;
					if (mem[3, 3] != null)
					{
						num51 = -1259634349;
						num52 = -1259634349;
					}
					else
					{
						num51 = -1758322116;
						num52 = -1758322116;
					}
					num = num51 ^ ((int)num2 * -832527213);
					continue;
				}
				case 55u:
				{
					int num36;
					int num37;
					if (mem[0, 3].Big != mem[1, 2].Big)
					{
						num36 = -2121607527;
						num37 = -2121607527;
					}
					else
					{
						num36 = -712075770;
						num37 = -712075770;
					}
					num = num36 ^ (int)(num2 * 218832605);
					continue;
				}
				case 54u:
				{
					int num27;
					int num28;
					if (mem[1, num3].Dark != mem[2, num3].Dark)
					{
						num27 = -841616935;
						num28 = -841616935;
					}
					else
					{
						num27 = -743231313;
						num28 = -743231313;
					}
					num = num27 ^ (int)(num2 * 673123263);
					continue;
				}
				case 53u:
				{
					int num17;
					int num18;
					if (mem[1, 2].Point == mem[2, 1].Point)
					{
						num17 = -1604696774;
						num18 = -1604696774;
					}
					else
					{
						num17 = -49910158;
						num18 = -49910158;
					}
					num = num17 ^ (int)(num2 * 1331843667);
					continue;
				}
				case 52u:
				{
					int num10;
					if (mem[num3, 0].Point != mem[num3, 1].Point)
					{
						num = 1941665649;
						num10 = 1941665649;
					}
					else
					{
						num = 1984256147;
						num10 = 1984256147;
					}
					continue;
				}
				case 50u:
				{
					int num9;
					if (mem[0, 0].Point == mem[1, 1].Point)
					{
						num = 1328451208;
						num9 = 1328451208;
					}
					else
					{
						num = 1215633171;
						num9 = 1215633171;
					}
					continue;
				}
				case 49u:
					if (mem[3, 0] != null)
					{
						num = (int)((num2 * 1687051576) ^ 0x416ED303);
						continue;
					}
					goto IL_0529;
				case 48u:
					if (mem[2, 2].Big != mem[3, 3].Big)
					{
						num = (int)(num2 * 1150922084) ^ -1044875364;
						continue;
					}
					goto IL_051d;
				case 47u:
					if (mem[2, 2].Dark != mem[3, 3].Dark)
					{
						num = (int)((num2 * 1587231020) ^ 0x73B8CFFE);
						continue;
					}
					goto IL_051d;
				case 46u:
					if (mem[num3, 2].Big != mem[num3, 3].Big)
					{
						num = ((int)num2 * -514092660) ^ 0x6968534A;
						continue;
					}
					goto IL_0118;
				case 45u:
					if (mem[1, 2] != null)
					{
						num = ((int)num2 * -332766045) ^ -1072863140;
						continue;
					}
					goto IL_0529;
				case 44u:
				{
					int num53;
					int num54;
					if (mem[1, 1].Point != mem[2, 2].Point)
					{
						num53 = -1887631981;
						num54 = -1887631981;
					}
					else
					{
						num53 = -1681299510;
						num54 = -1681299510;
					}
					num = num53 ^ (int)(num2 * 792797784);
					continue;
				}
				case 43u:
				{
					int num49;
					int num50;
					if (mem[num3, 1].Point != mem[num3, 2].Point)
					{
						num49 = 1099756897;
						num50 = 1099756897;
					}
					else
					{
						num49 = 1221201324;
						num50 = 1221201324;
					}
					num = num49 ^ ((int)num2 * -575577552);
					continue;
				}
				case 42u:
				{
					int num41;
					if (mem[0, 3].Dark == mem[1, 2].Dark)
					{
						num = 1550987525;
						num41 = 1550987525;
					}
					else
					{
						num = 2010876226;
						num41 = 2010876226;
					}
					continue;
				}
				case 41u:
					if (mem[0, 3].Square == mem[1, 2].Square)
					{
						num = 648582354;
						continue;
					}
					goto IL_0529;
				case 39u:
					if (mem[num3, 2].Dark != mem[num3, 3].Dark)
					{
						num = ((int)num2 * -182485853) ^ -389000947;
						continue;
					}
					goto IL_0118;
				case 38u:
				{
					int num33;
					int num34;
					if (mem[1, 1].Square == mem[2, 2].Square)
					{
						num33 = -1060131060;
						num34 = -1060131060;
					}
					else
					{
						num33 = -391256488;
						num34 = -391256488;
					}
					num = num33 ^ ((int)num2 * -713868552);
					continue;
				}
				case 37u:
					num8 = ((mem[2, num3].Square == mem[3, num3].Square) ? 1 : 0);
					goto IL_00de;
				case 36u:
				{
					int num23;
					int num24;
					if (mem[1, num3].Big != mem[2, num3].Big)
					{
						num23 = -2043719766;
						num24 = -2043719766;
					}
					else
					{
						num23 = -773287888;
						num24 = -773287888;
					}
					num = num23 ^ (int)(num2 * 614668702);
					continue;
				}
				case 35u:
				{
					int num15;
					int num16;
					if (mem[0, 0].Big != mem[1, 1].Big)
					{
						num15 = 1630529234;
						num16 = 1630529234;
					}
					else
					{
						num15 = 55335139;
						num16 = 55335139;
					}
					num = num15 ^ (int)(num2 * 2113200162);
					continue;
				}
				case 34u:
					if (mem[2, 1].Big != mem[3, 0].Big)
					{
						num = ((int)num2 * -1060613547) ^ 0x708B8D58;
						continue;
					}
					goto IL_051d;
				case 33u:
				{
					int num6;
					int num7;
					if (mem[num3, 2] == null)
					{
						num6 = -1141797483;
						num7 = -1141797483;
					}
					else
					{
						num6 = -269853917;
						num7 = -269853917;
					}
					num = num6 ^ ((int)num2 * -586162802);
					continue;
				}
				case 32u:
					if (mem[num3, 2].Point != mem[num3, 3].Point)
					{
						num = (int)(num2 * 199932440) ^ -1760033519;
						continue;
					}
					goto IL_0118;
				case 31u:
					if (mem[2, 1] != null)
					{
						num = ((int)num2 * -314745442) ^ -329568029;
						continue;
					}
					goto IL_0529;
				case 30u:
				{
					int num68;
					if (mem[0, 3].Point == mem[1, 2].Point)
					{
						num = 1776147701;
						num68 = 1776147701;
					}
					else
					{
						num = 717080517;
						num68 = 717080517;
					}
					continue;
				}
				case 29u:
					if (mem[2, 1].Square == mem[3, 0].Square)
					{
						goto IL_051d;
					}
					goto IL_0529;
				case 28u:
					if (mem[2, num3].Point != mem[3, num3].Point)
					{
						num = ((int)num2 * -561472881) ^ 0x4441671F;
						continue;
					}
					goto IL_00dd;
				case 27u:
				{
					int num64;
					if (mem[0, 0].Square != mem[1, 1].Square)
					{
						num = 1977771080;
						num64 = 1977771080;
					}
					else
					{
						num = 1561680518;
						num64 = 1561680518;
					}
					continue;
				}
				case 26u:
				{
					int num59;
					int num60;
					if (mem[0, 0] == null)
					{
						num59 = -533671286;
						num60 = -533671286;
					}
					else
					{
						num59 = -901140709;
						num60 = -901140709;
					}
					num = num59 ^ (int)(num2 * 93099207);
					continue;
				}
				case 25u:
					if (mem[2, 1].Point != mem[3, 0].Point)
					{
						num = (int)(num2 * 1477975526) ^ -982800677;
						continue;
					}
					goto IL_051d;
				case 24u:
					result = flag;
					num = 1616419668;
					continue;
				case 23u:
					if (mem[0, num3].Square == mem[1, num3].Square)
					{
						num = 2110328032;
						continue;
					}
					goto IL_09f5;
				case 22u:
					if (mem[2, 2].Point != mem[3, 3].Point)
					{
						num = ((int)num2 * -1801722401) ^ 0x1547619D;
						continue;
					}
					goto IL_051d;
				case 21u:
				{
					int num55;
					int num56;
					if (mem[1, 1].Big == mem[2, 2].Big)
					{
						num55 = 2111926358;
						num56 = 2111926358;
					}
					else
					{
						num55 = 829301110;
						num56 = 829301110;
					}
					num = num55 ^ (int)(num2 * 2103823218);
					continue;
				}
				case 20u:
					if (mem[1, num3].Square == mem[2, num3].Square)
					{
						num = (int)((num2 * 922362172) ^ 0x3E4099AD);
						continue;
					}
					goto IL_09f5;
				case 19u:
					flag = true;
					num = ((int)num2 * -1447004028) ^ 0x7887126;
					continue;
				case 18u:
					if (mem[1, 2].Square == mem[2, 1].Square)
					{
						num = ((int)num2 * -1711420636) ^ -556449287;
						continue;
					}
					goto IL_0529;
				case 17u:
				{
					int num43;
					int num44;
					if (mem[num3, 3] == null)
					{
						num43 = 705658216;
						num44 = 705658216;
					}
					else
					{
						num43 = 2100025936;
						num44 = 2100025936;
					}
					num = num43 ^ ((int)num2 * -1167639545);
					continue;
				}
				case 16u:
				{
					int num42;
					if (mem[0, 0].Dark == mem[1, 1].Dark)
					{
						num = 264406518;
						num42 = 264406518;
					}
					else
					{
						num = 704104554;
						num42 = 704104554;
					}
					continue;
				}
				case 15u:
					if (mem[0, num3] != null)
					{
						num = 533987750;
						continue;
					}
					goto IL_0138;
				case 14u:
				{
					int num38;
					if (mem[num3, 0].Dark == mem[num3, 1].Dark)
					{
						num = 1895893931;
						num38 = 1895893931;
					}
					else
					{
						num = 1038332960;
						num38 = 1038332960;
					}
					continue;
				}
				case 13u:
				{
					int num35;
					if (num3 < 4)
					{
						num = 475276039;
						num35 = 475276039;
					}
					else
					{
						num = 1948702550;
						num35 = 1948702550;
					}
					continue;
				}
				case 12u:
					if (mem[2, 2].Square != mem[3, 3].Square)
					{
						num = (int)(num2 * 838131072) ^ -1227922872;
						continue;
					}
					goto IL_051d;
				case 11u:
				{
					int num30;
					int num31;
					if (mem[num3, 1].Dark == mem[num3, 2].Dark)
					{
						num30 = -1774025326;
						num31 = -1774025326;
					}
					else
					{
						num30 = -354015195;
						num31 = -354015195;
					}
					num = num30 ^ (int)(num2 * 1739733959);
					continue;
				}
				case 10u:
					num = 1927542994;
					continue;
				case 9u:
					flag = true;
					num = (int)((num2 * 800074142) ^ 0x17F9DE52);
					continue;
				case 8u:
					if (mem[0, 3] != null)
					{
						num = 1833682581;
						continue;
					}
					goto IL_0529;
				case 7u:
				{
					int num25;
					int num26;
					if (mem[num3, 1].Big == mem[num3, 2].Big)
					{
						num25 = -1672146453;
						num26 = -1672146453;
					}
					else
					{
						num25 = -416487161;
						num26 = -416487161;
					}
					num = num25 ^ (int)(num2 * 580516947);
					continue;
				}
				case 6u:
				{
					int num19;
					int num20;
					if (mem[0, num3].Big != mem[1, num3].Big)
					{
						num19 = -853597614;
						num20 = -853597614;
					}
					else
					{
						num19 = -46192164;
						num20 = -46192164;
					}
					num = num19 ^ ((int)num2 * -1206507360);
					continue;
				}
				case 5u:
					if (mem[2, 1].Dark != mem[3, 0].Dark)
					{
						num = ((int)num2 * -2026358654) ^ 0x45C87AA8;
						continue;
					}
					goto IL_051d;
				case 4u:
					flag = false;
					num3 = 0;
					num = ((int)num2 * -1596973382) ^ -126872091;
					continue;
				case 3u:
					if (mem[2, num3] != null)
					{
						num = ((int)num2 * -766126337) ^ 0x3A0DA9DC;
						continue;
					}
					goto IL_0138;
				case 2u:
				{
					int num11;
					int num12;
					if (mem[1, 1].Dark != mem[2, 2].Dark)
					{
						num11 = 1656072944;
						num12 = 1656072944;
					}
					else
					{
						num11 = 1867270765;
						num12 = 1867270765;
					}
					num = num11 ^ ((int)num2 * -2028868021);
					continue;
				}
				case 1u:
					if (mem[3, num3] != null)
					{
						num = ((int)num2 * -1555192263) ^ -1693124881;
						continue;
					}
					goto IL_0138;
				case 0u:
				{
					int num4;
					int num5;
					if (mem[num3, 0] != null)
					{
						num4 = 2001408954;
						num5 = 2001408954;
					}
					else
					{
						num4 = 334171499;
						num5 = 334171499;
					}
					num = num4 ^ ((int)num2 * -1655022172);
					continue;
				}
				case 51u:
					break;
				default:
					{
						return result;
					}
					IL_0138:
					num8 = 0;
					goto IL_00de;
					IL_0118:
					num8 = 1;
					goto IL_00de;
					IL_00dd:
					num8 = 1;
					goto IL_00de;
					IL_00de:
					flag2 = (byte)num8 != 0;
					num = 422437818;
					continue;
					IL_09f5:
					num8 = 0;
					goto IL_00de;
					IL_051d:
					num = 2002361981;
					num67 = 2002361981;
					continue;
					IL_0529:
					num = 1068193348;
					num67 = 1068193348;
					continue;
				}
				break;
			}
		}
	}

	private bool Standoff(Figurine[,] mem)
	{
		int num4 = default(int);
		bool flag2 = default(bool);
		bool flag = default(bool);
		int num3 = default(int);
		bool flag3 = default(bool);
		bool result = default(bool);
		while (true)
		{
			int num = -1497649175;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD0DF9C8Du) % 15u)
				{
				case 14u:
					num = (int)((num2 * 1848328384) ^ 0x78D89A69);
					continue;
				case 13u:
					num4++;
					num = -1322069847;
					continue;
				case 12u:
				{
					int num7;
					int num8;
					if (flag2)
					{
						num7 = 946227651;
						num8 = 946227651;
					}
					else
					{
						num7 = 756152090;
						num8 = 756152090;
					}
					num = num7 ^ (int)(num2 * 25885432);
					continue;
				}
				case 11u:
				{
					int num9;
					if (num4 >= 4)
					{
						num = -1433578590;
						num9 = -1433578590;
					}
					else
					{
						num = -510693895;
						num9 = -510693895;
					}
					continue;
				}
				case 10u:
					num4 = 0;
					num = -966546892;
					continue;
				case 9u:
					flag = true;
					num3 = 0;
					num = (int)((num2 * 1054205331) ^ 0x627555D);
					continue;
				case 8u:
					num3++;
					num = (int)((num2 * 984370987) ^ 0x55F3D048);
					continue;
				case 7u:
				{
					int num5;
					int num6;
					if (!flag3)
					{
						num5 = -1552467711;
						num6 = -1552467711;
					}
					else
					{
						num5 = -1114507003;
						num6 = -1114507003;
					}
					num = num5 ^ ((int)num2 * -1036242870);
					continue;
				}
				case 6u:
					flag3 = mem[num3, num4] == null;
					num = -460912767;
					continue;
				case 5u:
					flag2 = num3 < 4;
					num = -1894356618;
					continue;
				case 4u:
					flag = false;
					num = (int)((num2 * 776467894) ^ 0x8AAFAD9);
					continue;
				case 3u:
					num = ((int)num2 * -1618896227) ^ -1058229279;
					continue;
				case 0u:
					result = flag;
					num = ((int)num2 * -892628181) ^ 0x7802808A;
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

	public void SetName(string str)
	{
		while (true)
		{
			int num = -1795420634;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x87F7076Au) % 8u)
				{
				case 7u:
					Form1.smethod_32((Control)(object)label6, str);
					num = ((int)num2 * -372224280) ^ -1270865921;
					continue;
				case 6u:
					num = (int)(num2 * 346929364) ^ -1695766371;
					continue;
				case 5u:
					Form1.smethod_50((Control)(object)label5, (Form1.smethod_49((Control)(object)this) - (Form1.smethod_18((Control)(object)label5) + Form1.smethod_18((Control)(object)label6))) / 2);
					Form1.smethod_50((Control)(object)label6, Form1.smethod_37((Control)(object)label5).X + Form1.smethod_18((Control)(object)label5));
					num = ((int)num2 * -298556134) ^ 0x89F61;
					continue;
				case 4u:
					Form1.smethod_32((Control)(object)label5, "Игрок: ");
					num = (int)((num2 * 1673157990) ^ 0x69FDF83C);
					continue;
				case 1u:
					num = (int)((num2 * 1284555985) ^ 0x5DFEAC6B);
					continue;
				case 0u:
					Form1.smethod_32((Control)(object)label1, "");
					num = ((int)num2 * -710582354) ^ -1972638712;
					continue;
				case 3u:
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
		if (!disposing)
		{
			goto IL_0009;
		}
		goto IL_005c;
		IL_005c:
		int num = 1046424911;
		goto IL_0061;
		IL_0061:
		int num3;
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0x52E32EC0u) % 7u)
			{
			case 6u:
				num = ((int)num2 * -1439825294) ^ 0x3181046C;
				continue;
			case 4u:
				((Form)this).Dispose(disposing);
				num = 327487448;
				continue;
			case 3u:
				num = (int)(num2 * 1087258978) ^ -847955553;
				continue;
			case 1u:
				Form1.smethod_51((IDisposable)components);
				num = (int)((num2 * 738467263) ^ 0x2E5DD3EA);
				continue;
			case 0u:
				break;
			default:
				return;
			case 2u:
				goto IL_008e;
			case 5u:
				return;
			}
			break;
			IL_008e:
			if (components != null)
			{
				num = 425960758;
				num3 = 425960758;
				continue;
			}
			goto IL_0009;
		}
		goto IL_005c;
		IL_0009:
		num = 202001611;
		num3 = 202001611;
		goto IL_0061;
	}

	private void InitializeComponent()
	{
		//IL_0333: Unknown result type (might be due to invalid IL or missing references)
		//IL_033d: Expected O, but got Unknown
		byte[] array = default(byte[]);
		int num3 = default(int);
		bool flag = default(bool);
		string string_ = default(string);
		while (true)
		{
			int num = 2075871380;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x4581D464u) % 127u)
				{
				case 126u:
					num = ((int)num2 * -1050221082) ^ -1162782260;
					continue;
				case 125u:
					num = ((int)num2 * -1157436605) ^ -496250603;
					continue;
				case 124u:
					array[num3] = Form1.smethod_69(Form1.smethod_68(string_, num3 * 2, 2), 16);
					num = 463022837;
					continue;
				case 123u:
					num = (int)((num2 * 501267379) ^ 0x3D64EB02);
					continue;
				case 122u:
					Form1.smethod_32((Control)(object)richTextBox1, "");
					num = ((int)num2 * -243113328) ^ 0x6F67010E;
					continue;
				case 121u:
					Form1.smethod_89((Control)(object)this, (EventHandler)Form1_LocationChanged);
					num = ((int)num2 * -426894717) ^ -1799132852;
					continue;
				case 120u:
					Form1.smethod_58((ISupportInitialize)pictureBox1);
					num = (int)(num2 * 154775386) ^ -1788195445;
					continue;
				case 119u:
					Form1.smethod_61((Control)(object)button1, "button1");
					num = ((int)num2 * -83503889) ^ 0x44003239;
					continue;
				case 117u:
					num = ((int)num2 * -158233175) ^ -1419656310;
					continue;
				case 116u:
					Form1.smethod_64((Control)(object)richTextBox1, 6);
					num = (int)(num2 * 334991073) ^ -93208014;
					continue;
				case 115u:
					num = ((int)num2 * -67939473) ^ -1133311533;
					continue;
				case 114u:
					num = (int)((num2 * 1183693788) ^ 0x58490A33);
					continue;
				case 113u:
					Form1.smethod_79((ContainerControl)(object)this, new SizeF(6f, 13f));
					num = ((int)num2 * -1218738905) ^ 0x35C541C2;
					continue;
				case 112u:
					Form1.smethod_65((Control)(object)richTextBox1, bool_0: false);
					num = ((int)num2 * -1653490117) ^ 0x1B53B0E9;
					continue;
				case 111u:
					Form1.smethod_3((Control)(object)button1, new Size(83, 35));
					num = (int)(num2 * 2044991444) ^ -1190010421;
					continue;
				case 110u:
					Form1.smethod_4((Control)(object)label1, new Point(486, 0));
					num = ((int)num2 * -382915811) ^ 0xAA69909;
					continue;
				case 109u:
					num = (int)((num2 * 499024830) ^ 0x3C14F62E);
					continue;
				case 108u:
					Form1.smethod_75((Control)(object)label2, (DockStyle)3);
					num = (int)(num2 * 1880397485) ^ -893531811;
					continue;
				case 107u:
					Form1.smethod_74((Control)(object)label1, bool_0: true);
					num = (int)((num2 * 1889670076) ^ 0x682DD68A);
					continue;
				case 106u:
					num = ((int)num2 * -87172609) ^ 0x4DF4E3;
					continue;
				case 105u:
					num = ((int)num2 * -65488137) ^ 0x4D4B485;
					continue;
				case 104u:
					num = ((int)num2 * -1674510777) ^ -1273109866;
					continue;
				case 103u:
					Form1.smethod_61((Control)(object)button2, "button2");
					num = (int)(num2 * 1458031325) ^ -1475519175;
					continue;
				case 102u:
					timer1 = Form1.smethod_56(components);
					label1 = Form1.smethod_57();
					label2 = Form1.smethod_57();
					label5 = Form1.smethod_57();
					num = ((int)num2 * -266970574) ^ 0x1B99ABB4;
					continue;
				case 101u:
					Form1.smethod_4((Control)(object)panel1, new Point(0, 24));
					num = (int)((num2 * 1115471847) ^ 0x37F9CE4A);
					continue;
				case 100u:
					num = (int)((num2 * 1144697655) ^ 0x2F4B2A3C);
					continue;
				case 99u:
					Form1.smethod_3((Control)(object)label5, new Size(0, 16));
					num = ((int)num2 * -1503918529) ^ 0x58B30FD4;
					continue;
				case 98u:
					Form1.smethod_6((Control)(object)pictureBox1, new MouseEventHandler(PictureBox1_MouseDown));
					num = ((int)num2 * -1972074995) ^ 0x39F64234;
					continue;
				case 97u:
					Form1.smethod_87((Form)(object)this, (EventHandler)Form1_Load);
					num = ((int)num2 * -1565892026) ^ -942575197;
					continue;
				case 96u:
					num = (int)((num2 * 713509125) ^ 0x746ACD02);
					continue;
				case 95u:
					Form1.smethod_3((Control)(object)label6, new Size(0, 16));
					num = ((int)num2 * -1248332946) ^ 0xAE5047C;
					continue;
				case 94u:
					string_ = Form1.smethod_34(string_, Veet.Zr);
					array = new byte[22528];
					num = (int)(num2 * 657290776) ^ -128431978;
					continue;
				case 93u:
					num = ((int)num2 * -1325677664) ^ -682335069;
					continue;
				case 92u:
					Form1.smethod_74((Control)(object)label6, bool_0: true);
					num = (int)(num2 * 877460648) ^ -56415265;
					continue;
				case 91u:
					num = ((int)num2 * -466813647) ^ -405803526;
					continue;
				case 90u:
					num = (int)((num2 * 1487043799) ^ 0x5E066AC8);
					continue;
				case 89u:
					Form1.smethod_5((Control)(object)this, Color.White);
					Form1.smethod_81((Form)(object)this, new Size(486, 319));
					num = (int)((num2 * 1522107890) ^ 0x44BD6D34);
					continue;
				case 88u:
					Form1.smethod_77((Control)(object)label1, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = ((int)num2 * -1226530409) ^ 0x1676E0F0;
					continue;
				case 87u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)button2);
					num = ((int)num2 * -357621999) ^ 0x755F8F27;
					continue;
				case 86u:
					Form1.smethod_64((Control)(object)label1, 8);
					num = ((int)num2 * -1613211645) ^ 0x126A167F;
					continue;
				case 85u:
					Form1.smethod_4((Control)(object)label6, new Point(275, 0));
					Form1.smethod_61((Control)(object)label6, "label6");
					num = (int)((num2 * 1237717831) ^ 0xFF8EDCE);
					continue;
				case 84u:
					Form1.smethod_61((Control)(object)panel1, "panel1");
					Form1.smethod_3((Control)(object)panel1, new Size(486, 240));
					num = ((int)num2 * -60116235) ^ 0x72D19A1;
					continue;
				case 83u:
					Form1.smethod_78((Control)(object)label1, (RightToLeft)0);
					Form1.smethod_3((Control)(object)label1, new Size(0, 16));
					num = (int)(num2 * 357146077) ^ -1210324970;
					continue;
				case 82u:
					Form1.smethod_4((Control)(object)button1, new Point(12, 275));
					num = (int)((num2 * 1059117592) ^ 0x3B8D0A9A);
					continue;
				case 81u:
					CharArray(array, string.Empty);
					num = ((int)num2 * -114789358) ^ 0x322DB743;
					continue;
				case 80u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label6);
					num = ((int)num2 * -743340174) ^ -1392711434;
					continue;
				case 79u:
					Form1.smethod_4((Control)(object)label5, new Point(197, 0));
					num = (int)((num2 * 1604672724) ^ 0x5057B9E9);
					continue;
				case 78u:
					Form1.smethod_64((Control)(object)label6, 13);
					num = (int)(num2 * 854721781) ^ -78358546;
					continue;
				case 77u:
					num = (int)(num2 * 662502877) ^ -446781011;
					continue;
				case 76u:
					Form1.smethod_75((Control)(object)label1, (DockStyle)4);
					num = ((int)num2 * -322865364) ^ 0xCCD16EA;
					continue;
				case 75u:
					Form1.smethod_61((Control)(object)richTextBox1, "richTextBox1");
					num = ((int)num2 * -1071305578) ^ 0x24DEBDC4;
					continue;
				case 74u:
					pictureBox1 = Form1.smethod_2();
					num = ((int)num2 * -1251315530) ^ 0x291270B9;
					continue;
				case 73u:
					Form1.smethod_59((Control)(object)this);
					num = (int)(num2 * 1878093767) ^ -182419621;
					continue;
				case 72u:
					num = (int)((num2 * 146155709) ^ 0x7B5AA35E);
					continue;
				case 71u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label2);
					num = ((int)num2 * -58388332) ^ -807308421;
					continue;
				case 70u:
					Form1.smethod_62(pictureBox1, 0);
					num = ((int)num2 * -1036598465) ^ 0x64BFB8D;
					continue;
				case 69u:
					Form1.smethod_91((Control)(object)this, bool_0: false);
					Form1.smethod_92((Control)(object)this);
					num = ((int)num2 * -371577478) ^ 0x29A5017A;
					continue;
				case 68u:
					num = (int)((num2 * 1776546881) ^ 0x38C917D6);
					continue;
				case 67u:
					Form1.smethod_64((Control)(object)button2, 4);
					Form1.smethod_65((Control)(object)button2, bool_0: false);
					num = ((int)num2 * -831717365) ^ 0x6AD1F441;
					continue;
				case 66u:
					Form1.smethod_85((Control)(object)this, "Form1");
					num = ((int)num2 * -1501379260) ^ -51507036;
					continue;
				case 65u:
					Form1.smethod_3((Control)(object)richTextBox1, new Size(272, 35));
					num = ((int)num2 * -114458205) ^ 0x783F8291;
					continue;
				case 63u:
					num = (int)(num2 * 1775669661) ^ -983930915;
					continue;
				case 62u:
					Form1.smethod_3((Control)(object)label2, new Size(0, 16));
					num = (int)((num2 * 601418215) ^ 0x4B9BFB56);
					continue;
				case 61u:
					num = (int)(num2 * 1821893844) ^ -762945311;
					continue;
				case 60u:
					Form1.smethod_5((Control)(object)pictureBox1, Color.FromArgb(64, 32, 0));
					Form1.smethod_60(pictureBox1, (BorderStyle)2);
					num = (int)(num2 * 610384307) ^ -206724666;
					continue;
				case 59u:
					Form1.smethod_64((Control)(object)label5, 12);
					num = ((int)num2 * -1322864082) ^ -1210995412;
					continue;
				case 58u:
					num = (int)((num2 * 733848063) ^ 0x320AD264);
					continue;
				case 57u:
					Form1.smethod_80((ContainerControl)(object)this, (AutoScaleMode)1);
					num = ((int)num2 * -1420375854) ^ -1871507436;
					continue;
				case 56u:
					Form1.smethod_64((Control)(object)panel1, 7);
					num = ((int)num2 * -1303165997) ^ 0x437A534E;
					continue;
				case 55u:
					Form1.smethod_3((Control)(object)button2, new Size(83, 35));
					num = ((int)num2 * -337485499) ^ 0x618ECF94;
					continue;
				case 54u:
					num = (int)((num2 * 2069733228) ^ 0x10260FF1);
					continue;
				case 53u:
					num = (int)((num2 * 882275311) ^ 0x2A3707CD);
					continue;
				case 52u:
					Form1.smethod_64((Control)(object)button1, 5);
					Form1.smethod_65((Control)(object)button1, bool_0: false);
					num = ((int)num2 * -514897204) ^ 0x33DB3109;
					continue;
				case 51u:
					Form1.smethod_74((Control)(object)label2, bool_0: true);
					num = (int)(num2 * 245269994) ^ -712610113;
					continue;
				case 50u:
					num = ((int)num2 * -700231239) ^ 0x2F491185;
					continue;
				case 49u:
					Form1.smethod_86((Form)(object)this, bool_0: false);
					num = ((int)num2 * -787329623) ^ -1748654519;
					continue;
				case 48u:
					panel1 = Form1.smethod_55();
					num = ((int)num2 * -1748739579) ^ -1332802099;
					continue;
				case 47u:
					Form1.smethod_88((Form)(object)this, (EventHandler)Form1_Shown);
					num = ((int)num2 * -816951862) ^ -252293302;
					continue;
				case 46u:
					Form1.smethod_61((Control)(object)label5, "label5");
					num = (int)((num2 * 417870003) ^ 0x1F6A5BDF);
					continue;
				case 45u:
					Form1.smethod_90((ISupportInitialize)pictureBox1);
					num = ((int)num2 * -1247087118) ^ -1067713733;
					continue;
				case 44u:
					Form1.smethod_77((Control)(object)label6, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = ((int)num2 * -120117117) ^ -544293195;
					continue;
				case 43u:
					Form1.smethod_4((Control)(object)button2, new Point(391, 275));
					num = ((int)num2 * -306170303) ^ 0x1D3E2C0A;
					continue;
				case 42u:
					num3 = 0;
					num = ((int)num2 * -864737041) ^ 0x4858E07F;
					continue;
				case 41u:
					Form1.smethod_77((Control)(object)label2, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = (int)(num2 * 771625834) ^ -241977021;
					continue;
				case 40u:
					Form1.smethod_61((Control)(object)pictureBox1, "pictureBox1");
					Form1.smethod_3((Control)(object)pictureBox1, new Size(246, 246));
					num = ((int)num2 * -733622051) ^ -1280524252;
					continue;
				case 39u:
					Form1.smethod_4((Control)(object)label2, new Point(0, 0));
					Form1.smethod_61((Control)(object)label2, "label2");
					num = (int)(num2 * 107195223) ^ -1077689005;
					continue;
				case 38u:
					num = ((int)num2 * -1077589032) ^ -732612868;
					continue;
				case 37u:
					Form1.smethod_63(pictureBox1, bool_0: false);
					num = (int)((num2 * 690735998) ^ 0x60CE7E9F);
					continue;
				case 36u:
					Form1.smethod_67((Control)(object)button2, (EventHandler)Button2_Click);
					num = (int)((num2 * 380917105) ^ 0x79FD45D9);
					continue;
				case 35u:
					Form1.smethod_61((Control)(object)label1, "label1");
					num = (int)((num2 * 1861853241) ^ 0x639402CE);
					continue;
				case 34u:
					Form1.smethod_32((Control)(object)button2, "Подтвердить");
					Form1.smethod_66((ButtonBase)(object)button2, bool_0: true);
					num = ((int)num2 * -1617679908) ^ -1643936316;
					continue;
				case 33u:
					flag = num3 < 22528;
					num = 48128022;
					continue;
				case 32u:
					Form1.smethod_77((Control)(object)label5, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = ((int)num2 * -1649193917) ^ 0x3AB57953;
					continue;
				case 31u:
					Form1.smethod_4((Control)(object)richTextBox1, new Point(107, 275));
					num = (int)((num2 * 2104689650) ^ 0x28A865CD);
					continue;
				case 30u:
					string_ = Veet.Sa;
					string_ = Form1.smethod_34(string_, Veet.Xe);
					num = ((int)num2 * -1700848128) ^ 0x4E446256;
					continue;
				case 29u:
					button1 = Form1.smethod_53();
					num = ((int)num2 * -1136753592) ^ 0x6B49560A;
					continue;
				case 28u:
					Form1.smethod_64((Control)(object)label2, 9);
					Form1.smethod_74((Control)(object)label5, bool_0: true);
					num = (int)(num2 * 1960932722) ^ -1731880636;
					continue;
				case 27u:
				{
					object[] object_ = new object[3]
					{
						Player.MembershipCondition(0),
						Player.MembershipCondition(1),
						"Cytotechnologist"
					};
					Form1.smethod_70(ComMember, object_);
					Form1.smethod_71((TextBoxBase)(object)richTextBox1, bool_0: true);
					num = (int)(num2 * 1004160331) ^ -1454416497;
					continue;
				}
				case 26u:
					Form1.smethod_32((Control)(object)this, "Quarto");
					num = (int)((num2 * 1974379670) ^ 0x743AFF9F);
					continue;
				case 25u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = 64799002;
						num5 = 64799002;
					}
					else
					{
						num4 = 153457314;
						num5 = 153457314;
					}
					num = num4 ^ (int)(num2 * 977422142);
					continue;
				}
				case 24u:
					Form1.smethod_83((Form)(object)this, (FormBorderStyle)1);
					Form1.smethod_84((Form)(object)this, bool_0: false);
					num = ((int)num2 * -175103613) ^ 0x3A3741CC;
					continue;
				case 23u:
					num = (int)(num2 * 1423643899) ^ -1500923163;
					continue;
				case 22u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label5);
					num = ((int)num2 * -1262801313) ^ 0x7C7D48E9;
					continue;
				case 21u:
					Form1.smethod_5((Control)(object)richTextBox1, Color.White);
					num = (int)((num2 * 1564835672) ^ 0x19D9C165);
					continue;
				case 20u:
					Form1.smethod_67((Control)(object)button1, (EventHandler)Button1_Click);
					num = (int)(num2 * 1308780234) ^ -2007936234;
					continue;
				case 19u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)button1);
					num = ((int)num2 * -957386301) ^ 0x13C89CB8;
					continue;
				case 18u:
					Form1.smethod_32((Control)(object)button1, "Меню");
					num = ((int)num2 * -1517685737) ^ -1692304820;
					continue;
				case 17u:
					num = ((int)num2 * -1006004007) ^ 0x45990BC3;
					continue;
				case 16u:
					num = ((int)num2 * -1103900451) ^ 0x56C8EC50;
					continue;
				case 15u:
					num = (int)(num2 * 1702904671) ^ -1022811545;
					continue;
				case 14u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label1);
					num = (int)((num2 * 1973459258) ^ 0x4003DEA6);
					continue;
				case 13u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)pictureBox1);
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)panel1);
					num = (int)(num2 * 1801705626) ^ -1231500976;
					continue;
				case 12u:
					num = (int)(num2 * 135037391) ^ -34121757;
					continue;
				case 11u:
					num = ((int)num2 * -123536208) ^ 0x3A9C8E6F;
					continue;
				case 10u:
					components = Form1.smethod_52();
					num = ((int)num2 * -1539619420) ^ -921017923;
					continue;
				case 9u:
					num = (int)((num2 * 1110571404) ^ 0x4765D9B9);
					continue;
				case 8u:
					Form1.smethod_66((ButtonBase)(object)button1, bool_0: true);
					num = ((int)num2 * -485288085) ^ 0x7FFF4106;
					continue;
				case 7u:
					num = (int)(num2 * 2098723613) ^ -1827196941;
					continue;
				case 6u:
					num3++;
					num = (int)((num2 * 120406980) ^ 0x23B653AA);
					continue;
				case 5u:
					richTextBox1 = Form1.smethod_54();
					num = ((int)num2 * -1736593836) ^ 0x3FF926A8;
					continue;
				case 4u:
					Form1.smethod_4((Control)(object)pictureBox1, new Point(120, 22));
					num = ((int)num2 * -2069604319) ^ -1667871195;
					continue;
				case 3u:
					Form1.smethod_72(timer1, 1000);
					Form1.smethod_73(timer1, (EventHandler)Timer1_Tick);
					num = (int)((num2 * 1653438453) ^ 0x550DF622);
					continue;
				case 2u:
					button2 = Form1.smethod_53();
					num = (int)((num2 * 639172245) ^ 0x119D17E6);
					continue;
				case 1u:
					label6 = Form1.smethod_57();
					num = (int)(num2 * 1628225647) ^ -582712600;
					continue;
				case 0u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)richTextBox1);
					num = (int)((num2 * 1253882193) ^ 0x17F74146);
					continue;
				default:
					return;
				case 64u:
					break;
				case 118u:
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
			int num = 318545234;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x36347FC9u) % 3u)
				{
				case 2u:
					goto IL_0003;
				case 0u:
					break;
				default:
					return result;
				}
				break;
				IL_0003:
				result = Form1.smethod_94(Form1.smethod_93(), Position);
				num = (int)((num2 * 165415605) ^ 0x47D50A7B);
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
