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
				int num = 792347738;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x64DAE7E3u) % 6u)
					{
					case 5u:
						num = ((int)num2 * -322443181) ^ -699501596;
						continue;
					case 4u:
						Dark = dark;
						num = ((int)num2 * -1773882314) ^ 0x50F8F213;
						continue;
					case 3u:
						Square = square;
						Point = point;
						num = (int)(num2 * 1807748522) ^ -1702248530;
						continue;
					case 2u:
						Big = big;
						num = ((int)num2 * -450683290) ^ -52946750;
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
		while (true)
		{
			int num = 2144945581;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x64003EF7u) % 3u)
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
				num = (int)(num2 * 1567454234) ^ -614008402;
			}
		}
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
			int num = -40225721;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE686C533u) % 11u)
				{
				case 9u:
					num = (int)(num2 * 12905827) ^ -733192455;
					continue;
				case 8u:
				{
					Form control_ = menu;
					Form1.smethod_17((Control)(object)control_, Form1.smethod_16((Control)(object)control_) + 5);
					num = (int)((num2 * 1927622590) ^ 0x7D524796);
					continue;
				}
				case 7u:
					num = -1405665224;
					continue;
				case 6u:
					flag = Form1.smethod_16((Control)(object)menu) < 296;
					num = -158937877;
					continue;
				case 5u:
					Form1.smethod_15(timer1);
					num = ((int)num2 * -504377338) ^ 0x4A2CC10D;
					continue;
				case 4u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = 401098245;
						num4 = 401098245;
					}
					else
					{
						num3 = 1675306380;
						num4 = 1675306380;
					}
					num = num3 ^ ((int)num2 * -243331367);
					continue;
				}
				case 3u:
					num = (int)((num2 * 1300967669) ^ 0x3301DE2B);
					continue;
				case 1u:
					Form1.smethod_14(menu);
					num = ((int)num2 * -1790308855) ^ 0x62F4AD82;
					continue;
				case 0u:
					num = (int)((num2 * 1189936484) ^ 0x49BCE2B0);
					continue;
				default:
					return;
				case 2u:
					break;
				case 10u:
					return;
				}
				break;
			}
		}
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		board = new Figurine[4, 4];
		bool flag = default(bool);
		int num3 = default(int);
		int num4 = default(int);
		while (true)
		{
			int num = 1406026654;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x33CD491Bu) % 20u)
				{
				case 19u:
					flag = num3 < 4;
					num = 800661903;
					continue;
				case 18u:
					num = ((int)num2 * -1125100225) ^ -587870378;
					continue;
				case 17u:
					storage = new Figurine[4, 4];
					num = ((int)num2 * -1027676923) ^ 0x6C40901;
					continue;
				case 16u:
				{
					int num6;
					int num7;
					if (flag)
					{
						num6 = 472863151;
						num7 = 472863151;
					}
					else
					{
						num6 = 630812273;
						num7 = 630812273;
					}
					num = num6 ^ ((int)num2 * -622815516);
					continue;
				}
				case 15u:
					num = 1831176610;
					continue;
				case 14u:
					num = ((int)num2 * -1368209737) ^ -11167455;
					continue;
				case 13u:
					storage[num3, num4] = new Figurine(num3 < 2, num4 % 2 == 0, num4 < 2, num3 % 2 == 1);
					Form1.smethod_5((Control)(object)borderBox[num3, num4], Color.White);
					num = (int)((num2 * 457144628) ^ 0x51ECB9AF);
					continue;
				case 12u:
					num4 = 0;
					num = 68404962;
					continue;
				case 11u:
					num4++;
					num = ((int)num2 * -493690276) ^ 0x191B4A75;
					continue;
				case 9u:
					num = (int)(num2 * 1261675558) ^ -1484031481;
					continue;
				case 8u:
					num = (int)(num2 * 1248047021) ^ -1281942396;
					continue;
				case 7u:
					Form1.smethod_7((Control)(object)pictureBox[num3, num4], bool_0: false);
					num = ((int)num2 * -1422185781) ^ 0x6528FD58;
					continue;
				case 6u:
				{
					int num5;
					if (num4 >= 4)
					{
						num = 762749447;
						num5 = 762749447;
					}
					else
					{
						num = 706264048;
						num5 = 706264048;
					}
					continue;
				}
				case 4u:
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: false);
					num = ((int)num2 * -649973621) ^ -241770258;
					continue;
				case 3u:
					num3 = 0;
					num = ((int)num2 * -491119059) ^ -1894566701;
					continue;
				case 2u:
					Paint_Board();
					num = (int)((num2 * 763237352) ^ 0x887AB95);
					continue;
				case 1u:
					Paint_Storage();
					Form1.smethod_7((Control)(object)button2, bool_0: false);
					num = (int)(num2 * 1618901830) ^ -1794985757;
					continue;
				case 0u:
					num3++;
					num = ((int)num2 * -1071582246) ^ -262969588;
					continue;
				default:
					return;
				case 5u:
					break;
				case 10u:
					return;
				}
				break;
			}
		}
	}

	private void Paint_Board()
	{
		float num9 = default(float);
		float num3 = default(float);
		Graphics graphics_ = default(Graphics);
		float num10 = default(float);
		int num6 = default(int);
		int num5 = default(int);
		float num11 = default(float);
		bool dark = default(bool);
		float num4 = default(float);
		bool flag2 = default(bool);
		Brush brush_ = default(Brush);
		bool flag = default(bool);
		while (true)
		{
			int num = -190369998;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB512A696u) % 36u)
				{
				case 35u:
					num9 = 1f - num3 * 0.9f / (float)Form1.smethod_27(2.0);
					num = -1595161600;
					continue;
				case 34u:
					Form1.smethod_24(graphics_, (Brush)(object)Form1.smethod_29(Color.FromArgb(180, Color.Peru)), num10 + (float)(num6 * size), num10 + (float)(num5 * size), num11, num11);
					num = (int)(num2 * 430828235) ^ -1127913541;
					continue;
				case 33u:
					num = -211410955;
					continue;
				case 32u:
					num = -379768624;
					continue;
				case 31u:
				{
					int num20;
					int num21;
					if (dark)
					{
						num20 = 681999068;
						num21 = 681999068;
					}
					else
					{
						num20 = 1954446980;
						num21 = 1954446980;
					}
					num = num20 ^ (int)(num2 * 2111487988);
					continue;
				}
				case 30u:
					num3 = 0.7f;
					num = -1916393919;
					continue;
				case 29u:
					num6++;
					num = ((int)num2 * -1359119973) ^ 0x51F0B42D;
					continue;
				case 28u:
					Form1.smethod_20(pictureBox1, (Image)(object)Form1.smethod_19(Form1.smethod_18((Control)(object)pictureBox1), Form1.smethod_16((Control)(object)pictureBox1)));
					num = ((int)num2 * -1153276021) ^ -1035111699;
					continue;
				case 27u:
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox1));
					num5 = 0;
					num = (int)(num2 * 553268254) ^ -151584277;
					continue;
				case 26u:
					num = (int)((num2 * 763597751) ^ 0x3A32C06B);
					continue;
				case 25u:
				{
					num10 = (float)size * (num9 / 2f);
					num11 = num4 * 0.9f / (float)Form1.smethod_27(2.0);
					int num12;
					int num13;
					if (board[num5, num6].Square)
					{
						num12 = -1073968790;
						num13 = -1073968790;
					}
					else
					{
						num12 = -1995986328;
						num13 = -1995986328;
					}
					num = num12 ^ ((int)num2 * -1419113973);
					continue;
				}
				case 24u:
				{
					int num18;
					int num19;
					if (!flag2)
					{
						num18 = 317379787;
						num19 = 317379787;
					}
					else
					{
						num18 = 1976370451;
						num19 = 1976370451;
					}
					num = num18 ^ ((int)num2 * -47476744);
					continue;
				}
				case 23u:
					flag2 = num5 < 4;
					num = -1132392086;
					continue;
				case 21u:
					Form1.smethod_24(graphics_, brush_, num10 + (float)(num6 * size), num10 + (float)(num5 * size), num11, num11);
					num = -117745378;
					continue;
				case 20u:
					num9 = 1f - num3 * 0.4f / (float)Form1.smethod_27(2.0);
					num10 = (float)size * (num9 / 2f);
					num = -1154409277;
					continue;
				case 19u:
					Form1.smethod_28(graphics_, brush_, num10 + (float)(num6 * size), num10 + (float)(num5 * size), num11, num11);
					num = (int)(num2 * 72284537) ^ -408236935;
					continue;
				case 18u:
					brush_ = Form1.smethod_25();
					num = ((int)num2 * -942220348) ^ -621450459;
					continue;
				case 17u:
					num11 = num4 * 0.4f / (float)Form1.smethod_27(2.0);
					num = (int)(num2 * 1146138657) ^ -1474182316;
					continue;
				case 16u:
					dark = board[num5, num6].Dark;
					num = ((int)num2 * -664303476) ^ 0x69D1189;
					continue;
				case 15u:
					num = (int)((num2 * 1418216344) ^ 0x16ED06CA);
					continue;
				case 14u:
					brush_ = Form1.smethod_26();
					num = -71447056;
					continue;
				case 13u:
					num5++;
					num = ((int)num2 * -1751625096) ^ -538209023;
					continue;
				case 12u:
				{
					int num16;
					int num17;
					if (flag)
					{
						num16 = -579284402;
						num17 = -579284402;
					}
					else
					{
						num16 = -460233820;
						num17 = -460233820;
					}
					num = num16 ^ ((int)num2 * -140429967);
					continue;
				}
				case 11u:
					Form1.smethod_24(graphics_, Form1.smethod_23(), ((float)num6 + 0.05f) * (float)size, ((float)num5 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					num = ((int)num2 * -1442088662) ^ -1828371932;
					continue;
				case 10u:
					num = -766641261;
					continue;
				case 9u:
					Form1.smethod_30((Control)(object)pictureBox1);
					num = ((int)num2 * -2028745598) ^ -896509562;
					continue;
				case 8u:
				{
					int num15;
					if (num6 >= 4)
					{
						num = -2073574405;
						num15 = -2073574405;
					}
					else
					{
						num = -1921626089;
						num15 = -1921626089;
					}
					continue;
				}
				case 7u:
					num = ((int)num2 * -1873579997) ^ 0x4CDC8F11;
					continue;
				case 6u:
				{
					int num14;
					if (!board[num5, num6].Big)
					{
						num = -650688488;
						num14 = -650688488;
					}
					else
					{
						num = -1286450141;
						num14 = -1286450141;
					}
					continue;
				}
				case 5u:
					num6 = 0;
					num = -1403708630;
					continue;
				case 4u:
					flag = board[num5, num6] != null;
					num = (int)((num2 * 80608313) ^ 0x70C1E0E);
					continue;
				case 3u:
				{
					int num7;
					int num8;
					if (!board[num5, num6].Point)
					{
						num7 = -871359874;
						num8 = -871359874;
					}
					else
					{
						num7 = -1422997512;
						num8 = -1422997512;
					}
					num = num7 ^ ((int)num2 * -1409400412);
					continue;
				}
				case 2u:
					num4 = (float)size * num3;
					num = ((int)num2 * -2029889659) ^ -90957775;
					continue;
				case 1u:
					num3 = 1f;
					num = (int)((num2 * 283250159) ^ 0x1649AE4B);
					continue;
				default:
					return;
				case 0u:
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
		bool flag2 = default(bool);
		int num4 = default(int);
		float num7 = default(float);
		float num6 = default(float);
		bool flag = default(bool);
		bool big = default(bool);
		float num14 = default(float);
		float num8 = default(float);
		float num11 = default(float);
		Graphics graphics_ = default(Graphics);
		Brush brush_ = default(Brush);
		while (true)
		{
			int num2 = 494459917;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0x482104F2u) % 31u)
				{
				case 29u:
				{
					int num17;
					int num18;
					if (!flag2)
					{
						num17 = 668333877;
						num18 = 668333877;
					}
					else
					{
						num17 = 1588953683;
						num18 = 1588953683;
					}
					num2 = num17 ^ ((int)num3 * -1601491180);
					continue;
				}
				case 28u:
					num4 = 0;
					num2 = 1259407758;
					continue;
				case 27u:
					num2 = (int)((num3 * 470124922) ^ 0x42B96F36);
					continue;
				case 26u:
					num7 = num6 * 0.9f / (float)Form1.smethod_27(2.0);
					flag = num4 < 2;
					num2 = ((int)num3 * -183100212) ^ 0x52B711FC;
					continue;
				case 25u:
				{
					int num19;
					int num20;
					if (!big)
					{
						num19 = -652928935;
						num20 = -652928935;
					}
					else
					{
						num19 = -872986156;
						num20 = -872986156;
					}
					num2 = num19 ^ ((int)num3 * -1383530771);
					continue;
				}
				case 24u:
					num14 = 1f - num8 * 0.9f / (float)Form1.smethod_27(2.0);
					num6 = (float)size * num8;
					num2 = 273923621;
					continue;
				case 23u:
					flag2 = num < 4;
					num2 = 2030853936;
					continue;
				case 22u:
					num11 = (float)size * (num14 / 2f) - 4f;
					num2 = ((int)num3 * -1720024456) ^ 0x5CE2334;
					continue;
				case 21u:
					Form1.smethod_24(graphics_, (Brush)(object)Form1.smethod_29(Color.FromArgb(180, Color.Peru)), num11, num11, num7, num7);
					num2 = ((int)num3 * -88490666) ^ 0x34B64B9A;
					continue;
				case 20u:
					Form1.smethod_28(graphics_, brush_, num11, num11, num7, num7);
					num2 = ((int)num3 * -68023972) ^ 0x204EB59B;
					continue;
				case 19u:
					num8 = 1f;
					num2 = ((int)num3 * -1109068090) ^ 0x672EF01;
					continue;
				case 18u:
					num2 = ((int)num3 * -425393306) ^ 0x2EB67FD0;
					continue;
				case 17u:
				{
					int num21;
					if (storage[num, num4] == null)
					{
						num2 = 1136567716;
						num21 = 1136567716;
					}
					else
					{
						num2 = 364589290;
						num21 = 364589290;
					}
					continue;
				}
				case 16u:
					num14 = 1f - num8 * 0.4f / (float)Form1.smethod_27(2.0);
					num11 = (float)size * (num14 / 2f) - 4f;
					num7 = num6 * 0.4f / (float)Form1.smethod_27(2.0);
					num2 = 1843003782;
					continue;
				case 15u:
					Form1.smethod_24(graphics_, brush_, num11, num11, num7, num7);
					num2 = 745028522;
					continue;
				case 14u:
				{
					int num15;
					int num16;
					if (!flag)
					{
						num15 = -1955166157;
						num16 = -1955166157;
					}
					else
					{
						num15 = -374605632;
						num16 = -374605632;
					}
					num2 = num15 ^ ((int)num3 * -241667889);
					continue;
				}
				case 13u:
					num2 = (int)(num3 * 199734071) ^ -1547659370;
					continue;
				case 11u:
					brush_ = Form1.smethod_26();
					num2 = 1646147685;
					continue;
				case 10u:
				{
					int num12;
					int num13;
					if (!storage[num, num4].Point)
					{
						num12 = -1325403304;
						num13 = -1325403304;
					}
					else
					{
						num12 = -1684256747;
						num13 = -1684256747;
					}
					num2 = num12 ^ (int)(num3 * 1580920458);
					continue;
				}
				case 9u:
				{
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox[num, num4]));
					int num9;
					int num10;
					if (storage[num, num4].Dark)
					{
						num9 = 529830662;
						num10 = 529830662;
					}
					else
					{
						num9 = 1776649983;
						num10 = 1776649983;
					}
					num2 = num9 ^ (int)(num3 * 650965832);
					continue;
				}
				case 8u:
					num4++;
					num2 = 1259407758;
					continue;
				case 7u:
					brush_ = Form1.smethod_25();
					num2 = (int)((num3 * 1962300533) ^ 0xB308AC1);
					continue;
				case 6u:
					Form1.smethod_30((Control)(object)pictureBox[num, num4]);
					num2 = 1136567716;
					continue;
				case 5u:
					num8 = 0.7f;
					num2 = 477051795;
					continue;
				case 4u:
					Form1.smethod_20(pictureBox[num, num4], (Image)(object)Form1.smethod_19(Form1.smethod_18((Control)(object)pictureBox[num, num4]), Form1.smethod_16((Control)(object)pictureBox[num, num4])));
					num2 = ((int)num3 * -609658314) ^ -343294642;
					continue;
				case 3u:
					big = storage[num, num4].Big;
					num2 = 1968253771;
					continue;
				case 2u:
					num2 = ((int)num3 * -1408721093) ^ -1484012267;
					continue;
				case 1u:
					num++;
					num2 = (int)(num3 * 776130814) ^ -248009574;
					continue;
				case 0u:
				{
					int num5;
					if (num4 < 4)
					{
						num2 = 787648806;
						num5 = 787648806;
					}
					else
					{
						num2 = 966557674;
						num5 = 966557674;
					}
					continue;
				}
				default:
					return;
				case 12u:
					break;
				case 30u:
					return;
				}
				break;
			}
		}
	}

	public void StartGame()
	{
		Form1_Load(this, Form1.smethod_31());
		int num3 = default(int);
		int num8 = default(int);
		bool flag = default(bool);
		int num5 = default(int);
		while (true)
		{
			int num = 1585142284;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB5108DEu) % 27u)
				{
				case 26u:
					step = 0;
					num = ((int)num2 * -2071718954) ^ -125650149;
					continue;
				case 25u:
					num = ((int)num2 * -1904503939) ^ 0x77A771DD;
					continue;
				case 24u:
					Form1.smethod_35(timer1, bool_0: true);
					num = ((int)num2 * -374535602) ^ 0x5C63B9BE;
					continue;
				case 23u:
					Form1.smethod_36(timer1);
					num = (int)(num2 * 1967126804) ^ -1745899833;
					continue;
				case 22u:
					num = (int)((num2 * 43989312) ^ 0xA6DEFD0);
					continue;
				case 21u:
					Form1.smethod_7((Control)(object)pictureBox[num3, num8], bool_0: true);
					num = 1713516842;
					continue;
				case 20u:
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: true);
					num = ((int)num2 * -1894838335) ^ 0x364CE81E;
					continue;
				case 19u:
					num8 = 0;
					num = 981946807;
					continue;
				case 18u:
					num8++;
					num = (int)(num2 * 749137710) ^ -125803409;
					continue;
				case 17u:
				{
					int num10;
					int num11;
					if (!turn)
					{
						num10 = 1894112565;
						num11 = 1894112565;
					}
					else
					{
						num10 = 1068519180;
						num11 = 1068519180;
					}
					num = num10 ^ (int)(num2 * 1960587979);
					continue;
				}
				case 16u:
					Form1.smethod_32((Control)(object)label2, Form1.smethod_34("Ход: ", step.ToString()));
					time = new DateTime(0L, DateTimeKind.Unspecified);
					num = 219030216;
					continue;
				case 15u:
					num = ((int)num2 * -1783937270) ^ -374265253;
					continue;
				case 14u:
					Form1.smethod_32((Control)(object)richTextBox1, "Противник выбрал фигуру. Выберете поле на доске для установки этой фигуры.");
					num = ((int)num2 * -1282321735) ^ -538989591;
					continue;
				case 13u:
					Form1.smethod_32((Control)(object)richTextBox1, "Ваш ход. Выберете фигуру, которой будет играть противник.");
					num = ((int)num2 * -593676563) ^ 0x4167A1CE;
					continue;
				case 12u:
					num = (int)((num2 * 240056061) ^ 0x6C42803);
					continue;
				case 11u:
					num3++;
					num = (int)(num2 * 1889740455) ^ -2037400645;
					continue;
				case 10u:
					flag = num8 < 4;
					num = 2046215296;
					continue;
				case 9u:
					num = ((int)num2 * -1690814222) ^ -1944157474;
					continue;
				case 8u:
					step = 1;
					num = (int)((num2 * 1428100641) ^ 0x37DF9A78);
					continue;
				case 7u:
				{
					int num9;
					if (num3 >= 4)
					{
						num = 1012157241;
						num9 = 1012157241;
					}
					else
					{
						num = 1425943278;
						num9 = 1425943278;
					}
					continue;
				}
				case 6u:
				{
					int num6;
					int num7;
					if (flag)
					{
						num6 = 497430358;
						num7 = 497430358;
					}
					else
					{
						num6 = 550728335;
						num7 = 550728335;
					}
					num = num6 ^ ((int)num2 * -1504639223);
					continue;
				}
				case 5u:
					num5 = Form1.smethod_33(rnd, 4);
					num = 1082800994;
					continue;
				case 4u:
					num = ((int)num2 * -10893145) ^ -1735954199;
					continue;
				case 2u:
				{
					int num4 = Form1.smethod_33(rnd, 4);
					Form1.smethod_5((Control)(object)borderBox[num5, num4], Color.Blue);
					num = (int)((num2 * 645829163) ^ 0x402C634D);
					continue;
				}
				case 1u:
					num3 = 0;
					num = ((int)num2 * -1449899472) ^ 0x13A38815;
					continue;
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

	private void Timer1_Tick(object sender, EventArgs e)
	{
		time = time.AddSeconds(1.0);
		while (true)
		{
			int num = -1158396820;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC4DAAE22u) % 3u)
				{
				case 1u:
					goto IL_001c;
				default:
					return;
				case 0u:
					break;
				case 2u:
					return;
				}
				break;
				IL_001c:
				Form1.smethod_32((Control)(object)label1, Form1.smethod_34("Время: ", time.ToString("HH:mm:ss")));
				num = (int)((num2 * 968790434) ^ 0x2F6A124E);
			}
		}
	}

	private void PictureBoxIJ_MouseDown(object sender, MouseEventArgs e)
	{
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Expected O, but got Unknown
		int num7 = default(int);
		bool flag2 = default(bool);
		int num11 = default(int);
		int num8 = default(int);
		int num6 = default(int);
		Point point = default(Point);
		bool flag3 = default(bool);
		bool flag = default(bool);
		while (true)
		{
			int num = 1526775988;
			while (true)
			{
				uint num2;
				int num5;
				switch ((num2 = (uint)num ^ 0x1AE7AE9u) % 27u)
				{
				case 24u:
					num7 -= 4;
					num = ((int)num2 * -949440665) ^ 0x2B1835CE;
					continue;
				case 23u:
					flag2 = num11 < 4;
					num = 673578140;
					continue;
				case 22u:
					num8++;
					num = (int)(num2 * 1233717782) ^ -1895208537;
					continue;
				case 21u:
					num6 = point.Y / size;
					num = ((int)num2 * -1154673878) ^ 0x2F6CFB6E;
					continue;
				case 20u:
					num = (int)(num2 * 193709227) ^ -947392285;
					continue;
				case 19u:
					flag3 = num8 < 4;
					num = 1183656749;
					continue;
				case 18u:
					num = ((int)num2 * -2039951382) ^ 0xB62C91B;
					continue;
				case 17u:
				{
					int num12;
					int num13;
					if (flag3)
					{
						num12 = 149369048;
						num13 = 149369048;
					}
					else
					{
						num12 = 1018565386;
						num13 = 1018565386;
					}
					num = num12 ^ (int)(num2 * 124519395);
					continue;
				}
				case 16u:
					Form1.smethod_7((Control)(object)button2, bool_0: true);
					num = (int)(num2 * 1805153731) ^ -511210570;
					continue;
				case 15u:
					num5 = ((Form1.smethod_40((Bitmap)Form1.smethod_21(pictureBox[num6, num7]), Form1.smethod_38(e), Form1.smethod_39(e)) != Color.FromArgb(0, 0, 0, 0)) ? 1 : 0);
					goto IL_011e;
				case 14u:
					num = (int)((num2 * 1708464209) ^ 0x354FE300);
					continue;
				case 13u:
					Form1.smethod_32((Control)(object)richTextBox1, "Именно эта фигура? Если да - нажмите \"Подтвердить\".");
					num = (int)((num2 * 854642838) ^ 0x45AF3D26);
					continue;
				case 12u:
					point = Form1.smethod_37((Control)((sender is PictureBox) ? sender : null));
					num = (int)(num2 * 273413692) ^ -1954508665;
					continue;
				case 11u:
					Form1.smethod_5((Control)(object)borderBox[num11, num8], Color.White);
					num = 751974684;
					continue;
				case 10u:
				{
					num7 = point.X / size;
					int num14;
					int num15;
					if (num7 > 1)
					{
						num14 = -909833453;
						num15 = -909833453;
					}
					else
					{
						num14 = -1022110376;
						num15 = -1022110376;
					}
					num = num14 ^ (int)(num2 * 511418688);
					continue;
				}
				case 9u:
					num = (int)((num2 * 679798925) ^ 0x1B0539F5);
					continue;
				case 8u:
					num11++;
					num = (int)(num2 * 1757961981) ^ -481317080;
					continue;
				case 7u:
					num11 = 0;
					num = (int)(num2 * 624525077) ^ -617177599;
					continue;
				case 6u:
					Form1.smethod_5((Control)(object)borderBox[num6, num7], Color.Red);
					num = ((int)num2 * -875960546) ^ -1901497718;
					continue;
				case 5u:
					point = Form1.smethod_37((Control)((sender is PictureBox) ? sender : null));
					num = ((int)num2 * -2101876080) ^ -1198497878;
					continue;
				case 4u:
					num = (int)(num2 * 1634678458) ^ -576070128;
					continue;
				case 3u:
					if (storage[num6, num7] != null)
					{
						num = 1450129990;
						continue;
					}
					num5 = 0;
					goto IL_011e;
				case 2u:
				{
					int num9;
					int num10;
					if (flag2)
					{
						num9 = 2099831811;
						num10 = 2099831811;
					}
					else
					{
						num9 = 1264648048;
						num10 = 1264648048;
					}
					num = num9 ^ ((int)num2 * -420396431);
					continue;
				}
				case 1u:
					num8 = 0;
					num = 1455760425;
					continue;
				case 0u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = 489742133;
						num4 = 489742133;
					}
					else
					{
						num3 = 1247550418;
						num4 = 1247550418;
					}
					num = num3 ^ ((int)num2 * -1043710358);
					continue;
				}
				default:
					return;
				case 25u:
					break;
				case 26u:
					return;
					IL_011e:
					flag = (byte)num5 != 0;
					num = 923972865;
					continue;
				}
				break;
			}
		}
	}

	private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
	{
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Expected O, but got Unknown
		int num6 = default(int);
		int num5 = default(int);
		int num3 = default(int);
		bool flag = default(bool);
		int num4 = default(int);
		bool flag2 = default(bool);
		Graphics graphics_ = default(Graphics);
		while (true)
		{
			int num = 1898003143;
			while (true)
			{
				uint num2;
				int num8;
				switch ((num2 = (uint)num ^ 0x70A34E58u) % 24u)
				{
				case 23u:
					Form1.smethod_7((Control)(object)button2, bool_0: true);
					num = (int)((num2 * 1996231867) ^ 0x78657BFC);
					continue;
				case 21u:
					num8 = ((board[num6, num5] == null) ? 1 : 0);
					goto IL_0035;
				case 20u:
					Paint_Board();
					num = (int)(num2 * 165982814) ^ -1136683509;
					continue;
				case 19u:
					num6 = Form1.smethod_39(e) / size;
					if (Form1.smethod_40((Bitmap)Form1.smethod_21(pictureBox1), Form1.smethod_38(e), Form1.smethod_39(e)) != Color.FromArgb(0, 0, 0, 0))
					{
						num = ((int)num2 * -453112250) ^ -1669649601;
						continue;
					}
					num8 = 0;
					goto IL_0035;
				case 18u:
					num3 = 0;
					num = (int)((num2 * 1351461861) ^ 0x5FBC1DEC);
					continue;
				case 17u:
					flag = Form1.smethod_41((Control)(object)borderBox[num3, num4]) == Color.Blue;
					num = 747657452;
					continue;
				case 16u:
				{
					int num12;
					int num13;
					if (!flag2)
					{
						num12 = 354741062;
						num13 = 354741062;
					}
					else
					{
						num12 = 924987610;
						num13 = 924987610;
					}
					num = num12 ^ (int)(num2 * 625321747);
					continue;
				}
				case 15u:
				{
					int num11;
					if (num4 >= 4)
					{
						num = 2127577077;
						num11 = 2127577077;
					}
					else
					{
						num = 1302891345;
						num11 = 1302891345;
					}
					continue;
				}
				case 14u:
					num = ((int)num2 * -1120974284) ^ -1598120158;
					continue;
				case 13u:
					num3++;
					num = ((int)num2 * -550131705) ^ 0x6DF9FC01;
					continue;
				case 12u:
				{
					int num9;
					int num10;
					if (!flag)
					{
						num9 = -1589735731;
						num10 = -1589735731;
					}
					else
					{
						num9 = -552116220;
						num10 = -552116220;
					}
					num = num9 ^ (int)(num2 * 416400576);
					continue;
				}
				case 11u:
					num = ((int)num2 * -905218030) ^ -1836436391;
					continue;
				case 10u:
					num4 = 0;
					num = 377078960;
					continue;
				case 9u:
					Form1.smethod_32((Control)(object)richTextBox1, "Уверены? Для выполнения данного хода нажмите \"Подтвердить\".");
					num = (int)((num2 * 681245349) ^ 0x3727819B);
					continue;
				case 7u:
					num5 = Form1.smethod_38(e) / size;
					num = ((int)num2 * -2010893679) ^ 0x2D3C0B94;
					continue;
				case 6u:
					num = (int)((num2 * 186040952) ^ 0x41225296);
					continue;
				case 5u:
					num4++;
					num = 1716910711;
					continue;
				case 4u:
					Form1.smethod_43(graphics_, Form1.smethod_42(Color.Red, 3f), ((float)num5 + 0.05f) * (float)size, ((float)num6 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					num = (int)(num2 * 527124480) ^ -528117239;
					continue;
				case 3u:
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox1));
					num = (int)(num2 * 925068071) ^ -786306991;
					continue;
				case 2u:
				{
					int num7;
					if (num3 < 4)
					{
						num = 1412354570;
						num7 = 1412354570;
					}
					else
					{
						num = 1016937222;
						num7 = 1016937222;
					}
					continue;
				}
				case 1u:
					Form1.smethod_44(graphics_, Form1.smethod_21(pictureBox[num3, num4]), num5 * size + 4, num6 * size + 4, new Rectangle(0, 0, size, size), (GraphicsUnit)2);
					Form1.smethod_45(graphics_);
					Form1.smethod_30((Control)(object)pictureBox1);
					num = ((int)num2 * -637011003) ^ 0x4934ABDE;
					continue;
				case 0u:
					num = (int)(num2 * 682049524) ^ -880375977;
					continue;
				default:
					return;
				case 8u:
					break;
				case 22u:
					return;
					IL_0035:
					flag2 = (byte)num8 != 0;
					num = 716503192;
					continue;
				}
				break;
			}
		}
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		//IL_11f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_1223: Expected O, but got Unknown
		Form1.smethod_7((Control)(object)button2, bool_0: false);
		int num17 = default(int);
		int num12 = default(int);
		int num18 = default(int);
		int num21 = default(int);
		int num16 = default(int);
		int num44 = default(int);
		int num15 = default(int);
		int num26 = default(int);
		Figurine[,] array3 = default(Figurine[,]);
		bool flag7 = default(bool);
		bool flag4 = default(bool);
		Graphics graphics_ = default(Graphics);
		int num6 = default(int);
		int num43 = default(int);
		int num25 = default(int);
		int num3 = default(int);
		int num11 = default(int);
		bool flag13 = default(bool);
		bool flag15 = default(bool);
		bool flag = default(bool);
		Figurine[,] array2 = default(Figurine[,]);
		Figurine[,] array = default(Figurine[,]);
		int num24 = default(int);
		bool flag3 = default(bool);
		int num42 = default(int);
		int num56 = default(int);
		bool flag17 = default(bool);
		int num62 = default(int);
		bool flag9 = default(bool);
		bool flag8 = default(bool);
		int num19 = default(int);
		bool flag2 = default(bool);
		bool flag16 = default(bool);
		int num20 = default(int);
		bool flag11 = default(bool);
		bool flag14 = default(bool);
		bool flag5 = default(bool);
		bool flag12 = default(bool);
		bool flag10 = default(bool);
		int num10 = default(int);
		int num9 = default(int);
		bool flag6 = default(bool);
		while (true)
		{
			int num = -1321077311;
			while (true)
			{
				uint num2;
				int num29;
				int num38;
				int num39;
				int num67;
				switch ((num2 = (uint)num ^ 0xBA70EC36u) % 177u)
				{
				case 176u:
					num = -1421324932;
					continue;
				case 175u:
					num29 = ((num17 == num12) ? 1 : 0);
					goto IL_0021;
				case 174u:
					num18 = num21;
					num = ((int)num2 * -1069170813) ^ -744209594;
					continue;
				case 173u:
					num = ((int)num2 * -2077310709) ^ -746543539;
					continue;
				case 172u:
					num = (int)((num2 * 535934242) ^ 0x774FA676);
					continue;
				case 171u:
					if (storage[num16, num17] != null)
					{
						num = ((int)num2 * -1957508991) ^ -1747950308;
						continue;
					}
					num29 = 1;
					goto IL_0021;
				case 170u:
					num = -541565930;
					continue;
				case 169u:
				{
					Form1.smethod_7((Control)(object)pictureBox[num44, num15], bool_0: false);
					int num55;
					if (Form1.smethod_41((Control)(object)borderBox[num44, num15]) == Color.Red)
					{
						num = -55573041;
						num55 = -55573041;
					}
					else
					{
						num = -947215019;
						num55 = -947215019;
					}
					continue;
				}
				case 168u:
					num = -1613116692;
					continue;
				case 167u:
					num44++;
					num = (int)((num2 * 1616332153) ^ 0x71C459C7);
					continue;
				case 166u:
					num26 = 0;
					num = -2123269123;
					continue;
				case 165u:
					if (!Standoff(array3))
					{
						num = -236805858;
						num38 = -236805858;
						continue;
					}
					goto IL_0125;
				case 164u:
				{
					int num30;
					int num31;
					if (flag7)
					{
						num30 = -979405281;
						num31 = -979405281;
					}
					else
					{
						num30 = -428594536;
						num31 = -428594536;
					}
					num = num30 ^ (int)(num2 * 1329170506);
					continue;
				}
				case 162u:
					num = ((int)num2 * -1341633701) ^ 0x5115F96E;
					continue;
				case 161u:
					Form1.smethod_30((Control)(object)borderBox[num16, num17]);
					num = ((int)num2 * -1612101530) ^ -1865932203;
					continue;
				case 160u:
					flag4 = num15 < 4;
					num = -1759165550;
					continue;
				case 159u:
					Form1.smethod_43(graphics_, Form1.smethod_42(Color.LimeGreen, 3f), ((float)num6 + 0.05f) * (float)size, ((float)num43 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					num = (int)((num2 * 502585910) ^ 0x6091A60A);
					continue;
				case 158u:
				{
					int num65;
					int num66;
					if (!(Form1.smethod_41((Control)(object)borderBox[num21, num25]) == Color.Blue))
					{
						num65 = -1119705022;
						num66 = -1119705022;
					}
					else
					{
						num65 = -1864430893;
						num66 = -1864430893;
					}
					num = num65 ^ (int)(num2 * 16715749);
					continue;
				}
				case 157u:
					Form1.smethod_15(timer1);
					num = -2072866455;
					continue;
				case 156u:
					num = ((int)num2 * -972492418) ^ 0x7C7ADC19;
					continue;
				case 155u:
					num = (int)(num2 * 1196783091) ^ -752601461;
					continue;
				case 154u:
					Form1.smethod_32((Control)(object)label2, Form1.smethod_34("Ход: ", step.ToString()));
					num = (int)((num2 * 1031464034) ^ 0x15116C34);
					continue;
				case 153u:
					Form1.smethod_30((Control)(object)richTextBox1);
					num = (int)((num2 * 184884019) ^ 0x1472D723);
					continue;
				case 152u:
					num3++;
					num = -1818682075;
					continue;
				case 151u:
					num = (int)((num2 * 1750216795) ^ 0x2E795FCB);
					continue;
				case 150u:
					Form1.smethod_30((Control)(object)pictureBox[num11, num12]);
					num = ((int)num2 * -912063221) ^ 0x30242422;
					continue;
				case 149u:
					if (!Stop(array3))
					{
						num = (int)(num2 * 628908774) ^ -73254522;
						continue;
					}
					goto IL_0125;
				case 148u:
				{
					int num51;
					int num52;
					if (flag13)
					{
						num51 = -1973747238;
						num52 = -1973747238;
					}
					else
					{
						num51 = -31355035;
						num52 = -31355035;
					}
					num = num51 ^ ((int)num2 * -1851389736);
					continue;
				}
				case 147u:
					step++;
					num = (int)((num2 * 558095301) ^ 0x10FA2A66);
					continue;
				case 146u:
					num = ((int)num2 * -1393228074) ^ -436461061;
					continue;
				case 145u:
					flag15 = num6 < 4;
					num = -1373899973;
					continue;
				case 144u:
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: true);
					num = ((int)num2 * -913136634) ^ -1180148882;
					continue;
				case 143u:
					num = (int)((num2 * 795605017) ^ 0x60BD75CB);
					continue;
				case 142u:
				{
					int num40;
					int num41;
					if (!flag)
					{
						num40 = 1461601601;
						num41 = 1461601601;
					}
					else
					{
						num40 = 950700710;
						num41 = 950700710;
					}
					num = num40 ^ ((int)num2 * -1085296816);
					continue;
				}
				case 141u:
					Form1.smethod_32((Control)(object)richTextBox1, "Противник сделал ход (зелёный). Выберете поле на доске для выбронной противником фигуры (синий).");
					num = (int)(num2 * 660709138) ^ -1288041188;
					continue;
				case 140u:
				{
					int num34;
					int num35;
					if (!Stop(array2))
					{
						num34 = -1294598794;
						num35 = -1294598794;
					}
					else
					{
						num34 = -807810762;
						num35 = -807810762;
					}
					num = num34 ^ ((int)num2 * -1123313160);
					continue;
				}
				case 139u:
					array = (Figurine[,])Form1.smethod_48((Array)board);
					num = ((int)num2 * -1840675259) ^ -2132878311;
					continue;
				case 138u:
					if (num16 == num11)
					{
						num = (int)(num2 * 11946682) ^ -1254818497;
						continue;
					}
					num29 = 0;
					goto IL_0021;
				case 137u:
					(menu as Form3).ContinueLock();
					num = (int)(num2 * 1945743133) ^ -1845715550;
					continue;
				case 136u:
					Form1.smethod_30((Control)(object)borderBox[num11, num12]);
					num = ((int)num2 * -2063153465) ^ 0x18319185;
					continue;
				case 135u:
					num24++;
					num = ((int)num2 * -174524098) ^ -1067883412;
					continue;
				case 134u:
					num = ((int)num2 * -1189713372) ^ -1044194685;
					continue;
				case 133u:
				{
					int num7;
					int num8;
					if (flag3)
					{
						num7 = 572159207;
						num8 = 572159207;
					}
					else
					{
						num7 = 1304176807;
						num8 = 1304176807;
					}
					num = num7 ^ ((int)num2 * -1050501579);
					continue;
				}
				case 132u:
					num6 = 0;
					num = -1045860778;
					continue;
				case 131u:
					num = ((int)num2 * -926472698) ^ -1867578060;
					continue;
				case 130u:
					num39 = ((num24 < 9) ? 1 : 0);
					goto IL_057c;
				case 129u:
				{
					int num68;
					if (num43 >= 4)
					{
						num = -1488561807;
						num68 = -1488561807;
					}
					else
					{
						num = -1102076894;
						num68 = -1102076894;
					}
					continue;
				}
				case 128u:
					num = (int)(num2 * 883248082) ^ -538346049;
					continue;
				case 127u:
					num = ((int)num2 * -1214971620) ^ 0x295955FD;
					continue;
				case 126u:
					if (!Stop(board))
					{
						num = (int)(num2 * 1548625534) ^ -1027406167;
						continue;
					}
					goto IL_05f5;
				case 125u:
					Form1.smethod_32((Control)(object)richTextBox1, "Ничья!");
					num = ((int)num2 * -287265419) ^ -1555469955;
					continue;
				case 124u:
					num = ((int)num2 * -2047687297) ^ -1595801915;
					continue;
				case 123u:
					num = ((int)num2 * -2076583755) ^ 0x7BD7BDA5;
					continue;
				case 122u:
					Form1.smethod_20(pictureBox[num11, num12], (Image)null);
					num = (int)((num2 * 5155498) ^ 0x2BB9851C);
					continue;
				case 121u:
					num = ((int)num2 * -1300297706) ^ -1788667964;
					continue;
				case 120u:
					num42 = num25;
					Form1.smethod_5((Control)(object)borderBox[num21, num25], Color.White);
					num = (int)((num2 * 1390972262) ^ 0x77215B19);
					continue;
				case 119u:
					num = ((int)num2 * -90247722) ^ -1293618657;
					continue;
				case 118u:
					array3 = (Figurine[,])Form1.smethod_48((Array)board);
					array3[num43, num6] = new Figurine(storage[num11, num12]);
					num = ((int)num2 * -1287900661) ^ -1156318498;
					continue;
				case 117u:
					num42 = 0;
					num56 = 0;
					num = ((int)num2 * -2038451638) ^ -69525027;
					continue;
				case 116u:
					board[num43, num6] = new Figurine(storage[num11, num12]);
					num = ((int)num2 * -1917048601) ^ 0x36BBE7F4;
					continue;
				case 115u:
					Form1.smethod_5((Control)(object)borderBox[num11, num12], Color.White);
					num = ((int)num2 * -1126872410) ^ -1186619658;
					continue;
				case 114u:
					Form1.smethod_47(200);
					num = (int)((num2 * 1201552184) ^ 0x601EC992);
					continue;
				case 113u:
					flag17 = num62 < 4;
					num = -472520199;
					continue;
				case 112u:
					flag9 = board[num43, num6] == null;
					num = -84883719;
					continue;
				case 111u:
					if (!Standoff(board))
					{
						num = -1505961240;
						num67 = -1505961240;
						continue;
					}
					goto IL_05f5;
				case 110u:
					num24 = 0;
					num = ((int)num2 * -412812636) ^ -377252187;
					continue;
				case 109u:
					num = ((int)num2 * -1656899346) ^ -1591049484;
					continue;
				case 108u:
					flag8 = array[num19, num3] == null;
					num = -1320342351;
					continue;
				case 107u:
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: false);
					num = ((int)num2 * -990795372) ^ 0x3A73A9EA;
					continue;
				case 106u:
					Form1.smethod_30((Control)(object)borderBox[num11, num12]);
					num = ((int)num2 * -1660182800) ^ 0x7E4524BC;
					continue;
				case 105u:
					num15 = 0;
					num = -515424331;
					continue;
				case 104u:
					num = -21541200;
					continue;
				case 103u:
					num = ((int)num2 * -2043898896) ^ -1103634205;
					continue;
				case 102u:
					num16 = Form1.smethod_33(rnd, 4);
					num17 = Form1.smethod_33(rnd, 4);
					num = -1639236010;
					continue;
				case 101u:
					Form1.smethod_44(graphics_, Form1.smethod_21(pictureBox[num11, num12]), num6 * size + 4, num43 * size + 4, new Rectangle(0, 0, size, size), (GraphicsUnit)2);
					num = (int)(num2 * 2101833105) ^ -1877643638;
					continue;
				case 100u:
					num = (int)((num2 * 1778535509) ^ 0x4245A9B);
					continue;
				case 99u:
					num = ((int)num2 * -974539309) ^ -827545365;
					continue;
				case 98u:
					Form1.smethod_47(1000);
					num = ((int)num2 * -1442351886) ^ 0x2679A29D;
					continue;
				case 97u:
				{
					int num63;
					int num64;
					if (flag17)
					{
						num63 = -916697624;
						num64 = -916697624;
					}
					else
					{
						num63 = -1639845859;
						num64 = -1639845859;
					}
					num = num63 ^ ((int)num2 * -1245129837);
					continue;
				}
				case 96u:
					num62++;
					num = ((int)num2 * -2118268626) ^ -1766773814;
					continue;
				case 95u:
					num = (int)((num2 * 147317880) ^ 0x426A50C0);
					continue;
				case 94u:
					Form1.smethod_32((Control)(object)richTextBox1, "Ничья!");
					num = (int)(num2 * 1315056001) ^ -1104528943;
					continue;
				case 93u:
					Form1.smethod_7((Control)(object)pictureBox[num62, num26], bool_0: true);
					num = -1274425610;
					continue;
				case 92u:
					flag3 = num44 < 4;
					num = -1674248243;
					continue;
				case 91u:
					num = (int)(num2 * 488017709) ^ -722107696;
					continue;
				case 90u:
					num62 = 0;
					num = (int)(num2 * 1597928369) ^ -1762218801;
					continue;
				case 89u:
					num = (int)(num2 * 1797054695) ^ -1196791154;
					continue;
				case 88u:
					num = -1730795240;
					continue;
				case 87u:
					flag2 = num25 < 4;
					num = -152930030;
					continue;
				case 86u:
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox1));
					num43 = 0;
					num = ((int)num2 * -1315575864) ^ -1821817644;
					continue;
				case 85u:
				{
					int num60;
					int num61;
					if (!flag16)
					{
						num60 = -964189231;
						num61 = -964189231;
					}
					else
					{
						num60 = -1747174849;
						num61 = -1747174849;
					}
					num = num60 ^ (int)(num2 * 1975555411);
					continue;
				}
				case 84u:
					num = ((int)num2 * -735104522) ^ -1462445832;
					continue;
				case 83u:
					Form1.smethod_5((Control)(object)borderBox[num44, num15], Color.LimeGreen);
					Form1.smethod_30((Control)(object)borderBox[num44, num15]);
					num = (int)(num2 * 1931325027) ^ -653542742;
					continue;
				case 82u:
				{
					int num59;
					if (num21 < 4)
					{
						num = -351733247;
						num59 = -351733247;
					}
					else
					{
						num = -1843162417;
						num59 = -1843162417;
					}
					continue;
				}
				case 81u:
					board[num56, num20] = new Figurine(storage[num18, num42]);
					num = (int)(num2 * 1588675437) ^ -92436946;
					continue;
				case 80u:
					flag11 = true;
					num = (int)(num2 * 1133739085) ^ -622325226;
					continue;
				case 79u:
				{
					int num57;
					int num58;
					if (flag14)
					{
						num57 = 2141675435;
						num58 = 2141675435;
					}
					else
					{
						num57 = 898233440;
						num58 = 898233440;
					}
					num = num57 ^ ((int)num2 * -399965589);
					continue;
				}
				case 78u:
					num = -1577144376;
					continue;
				case 77u:
					Form1.smethod_32((Control)(object)richTextBox1, "Подождите, компьютер делает свой ход.");
					num = (int)(num2 * 594007979) ^ -1775389068;
					continue;
				case 76u:
					step++;
					Form1.smethod_32((Control)(object)label2, Form1.smethod_34("Ход: ", step.ToString()));
					num = ((int)num2 * -1928507900) ^ -1033180450;
					continue;
				case 75u:
					num = (int)(num2 * 1862898202) ^ -118255645;
					continue;
				case 74u:
					Form1.smethod_32((Control)(object)richTextBox1, "Выберете фигуру, которой будет играть противник.");
					num = (int)(num2 * 846620764) ^ -638046624;
					continue;
				case 73u:
					num25++;
					num = -1516233801;
					continue;
				case 72u:
					num3 = 0;
					num = -284378565;
					continue;
				case 71u:
					Paint_Board();
					num = (int)(num2 * 1126192249) ^ -855391849;
					continue;
				case 70u:
					num20 = num25;
					num = ((int)num2 * -578183160) ^ -1990138047;
					continue;
				case 69u:
					Form1.smethod_20(pictureBox[num21, num25], (Image)null);
					num = ((int)num2 * -814496913) ^ -170883000;
					continue;
				case 68u:
					num15++;
					num = (int)((num2 * 1026203672) ^ 0x7561BDF8);
					continue;
				case 67u:
					num = ((int)num2 * -1144085033) ^ -1746497335;
					continue;
				case 66u:
					Form1.smethod_5((Control)(object)borderBox[num11, num12], Color.White);
					num = ((int)num2 * -358192458) ^ 0x2981CB17;
					continue;
				case 65u:
					num = -1542590019;
					continue;
				case 64u:
					num = ((int)num2 * -1061433786) ^ 0xE59CA04;
					continue;
				case 63u:
					num11 = num44;
					num12 = num15;
					num = (int)((num2 * 289486418) ^ 0x746DE41D);
					continue;
				case 61u:
					num56 = num21;
					num = (int)(num2 * 952587873) ^ -1468954996;
					continue;
				case 60u:
				{
					int num53;
					int num54;
					if (flag15)
					{
						num53 = 993403974;
						num54 = 993403974;
					}
					else
					{
						num53 = 1316197374;
						num54 = 1316197374;
					}
					num = num53 ^ ((int)num2 * -730341740);
					continue;
				}
				case 59u:
					num25 = 0;
					num = -1692649205;
					continue;
				case 58u:
					num26++;
					num = ((int)num2 * -15125861) ^ 0x205983AF;
					continue;
				case 57u:
					num = (int)(num2 * 956486187) ^ -1280176515;
					continue;
				case 56u:
					num = (int)(num2 * 1826633284) ^ -1891941289;
					continue;
				case 55u:
					num = (int)((num2 * 1796931757) ^ 0x53895752);
					continue;
				case 54u:
					num = -1018211654;
					continue;
				case 53u:
				{
					int num49;
					int num50;
					if (!flag5)
					{
						num49 = 420277297;
						num50 = 420277297;
					}
					else
					{
						num49 = 1832450602;
						num50 = 1832450602;
					}
					num = num49 ^ ((int)num2 * -1656260915);
					continue;
				}
				case 52u:
				{
					int num47;
					int num48;
					if (flag12)
					{
						num47 = 83900278;
						num48 = 83900278;
					}
					else
					{
						num47 = 1084211352;
						num48 = 1084211352;
					}
					num = num47 ^ (int)(num2 * 2094226197);
					continue;
				}
				case 51u:
					Form1.smethod_20(pictureBox[num11, num12], (Image)null);
					num = (int)(num2 * 1046147957) ^ -526337728;
					continue;
				case 50u:
					num = ((int)num2 * -1107042010) ^ -1648339475;
					continue;
				case 49u:
				{
					int num45;
					int num46;
					if (!flag10)
					{
						num45 = 1978886686;
						num46 = 1978886686;
					}
					else
					{
						num45 = 792048649;
						num46 = 792048649;
					}
					num = num45 ^ ((int)num2 * -1169846511);
					continue;
				}
				case 48u:
					flag14 = Standoff(board);
					num = -1244338274;
					continue;
				case 47u:
					Form1.smethod_15(timer1);
					(menu as Form3).ContinueLock();
					num = ((int)num2 * -1062091349) ^ 0x72B47308;
					continue;
				case 46u:
					num19++;
					num = (int)((num2 * 459222428) ^ 0x7423FDA3);
					continue;
				case 45u:
					flag11 = false;
					num = (int)((num2 * 301790261) ^ 0x6CF4004B);
					continue;
				case 44u:
					num44 = 0;
					num = (int)((num2 * 855839489) ^ 0x197358B2);
					continue;
				case 43u:
					storage[num11, num12] = null;
					Form1.smethod_5((Control)(object)borderBox[num16, num17], Color.Blue);
					num = ((int)num2 * -1997943220) ^ 0xBD0B6E4;
					continue;
				case 42u:
					flag13 = num19 < 4;
					num = -1394449755;
					continue;
				case 41u:
					Form1.smethod_30((Control)(object)pictureBox[num21, num25]);
					num = (int)(num2 * 1288668676) ^ -522948004;
					continue;
				case 40u:
					num10 = Form1.smethod_33(rnd, 4);
					num = ((int)num2 * -1885185826) ^ 0x5F3676B6;
					continue;
				case 39u:
					Form1.smethod_30((Control)(object)borderBox[num21, num25]);
					num = ((int)num2 * -1087786713) ^ -445678213;
					continue;
				case 38u:
					num43++;
					num = ((int)num2 * -1729427785) ^ 0x224F5E54;
					continue;
				case 37u:
					board[num10, num9] = new Figurine(storage[num11, num12]);
					num = (int)((num2 * 1991033925) ^ 0x2D53E0A);
					continue;
				case 36u:
					flag12 = Form1.smethod_46((Control)(object)pictureBox1);
					num = ((int)num2 * -1289026497) ^ 0x6281BED5;
					continue;
				case 35u:
					num = ((int)num2 * -766359717) ^ -895755070;
					continue;
				case 34u:
					storage[num18, num42] = null;
					num = ((int)num2 * -902568164) ^ -1038788006;
					continue;
				case 33u:
					if (!flag11)
					{
						num = ((int)num2 * -136268495) ^ 0x66C6EDB6;
						continue;
					}
					num39 = 1;
					goto IL_057c;
				case 32u:
				{
					num9 = Form1.smethod_33(rnd, 4);
					int num36;
					int num37;
					if (board[num10, num9] == null)
					{
						num36 = -997356082;
						num37 = -997356082;
					}
					else
					{
						num36 = -1111916283;
						num37 = -1111916283;
					}
					num = num36 ^ ((int)num2 * -1037358680);
					continue;
				}
				case 31u:
					num11 = 0;
					num12 = 0;
					num = ((int)num2 * -339985842) ^ 0x4368BE4E;
					continue;
				case 30u:
				{
					int num32;
					int num33;
					if (flag9)
					{
						num32 = -656005483;
						num33 = -656005483;
					}
					else
					{
						num32 = -1249871245;
						num33 = -1249871245;
					}
					num = num32 ^ (int)(num2 * 1787966162);
					continue;
				}
				case 29u:
					array2[num19, num3] = new Figurine(storage[num16, num17]);
					num = (int)(num2 * 2146632375) ^ -1660428510;
					continue;
				case 28u:
					num = ((int)num2 * -1302390688) ^ -1523165209;
					continue;
				case 27u:
				{
					int num27;
					int num28;
					if (!flag8)
					{
						num27 = -1571541044;
						num28 = -1571541044;
					}
					else
					{
						num27 = -479210296;
						num28 = -479210296;
					}
					num = num27 ^ ((int)num2 * -665410608);
					continue;
				}
				case 26u:
					num6++;
					num = -918556755;
					continue;
				case 25u:
					num = (int)((num2 * 1422166699) ^ 0x4B671760);
					continue;
				case 24u:
					flag7 = num26 < 4;
					num = -1195247042;
					continue;
				case 23u:
					num = (int)((num2 * 448582865) ^ 0x63AC013C);
					continue;
				case 22u:
					flag6 = Form1.smethod_40((Bitmap)Form1.smethod_21(pictureBox1), num25 * size + size / 2, (int)(((float)num21 + 0.05f) * (float)size)) == Color.FromArgb(255, 255, 0, 0);
					num = -1159302142;
					continue;
				case 21u:
				{
					int num22;
					int num23;
					if (!flag6)
					{
						num22 = -467124926;
						num23 = -467124926;
					}
					else
					{
						num22 = -305375484;
						num23 = -305375484;
					}
					num = num22 ^ ((int)num2 * -2045271481);
					continue;
				}
				case 20u:
					num21++;
					num = ((int)num2 * -1069246336) ^ -2031359678;
					continue;
				case 19u:
					num = ((int)num2 * -1294160015) ^ 0x711997B1;
					continue;
				case 18u:
					storage[num11, num12] = null;
					flag5 = Standoff(board);
					num = ((int)num2 * -593654238) ^ -2066895678;
					continue;
				case 17u:
					num20 = 0;
					num21 = 0;
					num = (int)((num2 * 58957507) ^ 0x98D0E6B);
					continue;
				case 16u:
					array[num10, num9] = new Figurine(storage[num11, num12]);
					num19 = 0;
					num = (int)((num2 * 387840040) ^ 0x44043707);
					continue;
				case 15u:
					num = (int)((num2 * 432155859) ^ 0x31A1106A);
					continue;
				case 14u:
					num = ((int)num2 * -604850120) ^ -2074837127;
					continue;
				case 13u:
					num = (int)(num2 * 213184622) ^ -237505989;
					continue;
				case 12u:
					array2 = (Figurine[,])Form1.smethod_48((Array)array);
					num = ((int)num2 * -133330533) ^ 0x1D612A96;
					continue;
				case 11u:
					Form1.smethod_32((Control)(object)richTextBox1, "QUARTO! Компьютер выиграл!");
					num = -139436537;
					continue;
				case 10u:
					Form1.smethod_30((Control)(object)pictureBox[num11, num12]);
					num = ((int)num2 * -2118026152) ^ -277642663;
					continue;
				case 9u:
					num18 = 0;
					num = (int)(num2 * 1170049756) ^ -1866589562;
					continue;
				case 8u:
					Form1.smethod_30((Control)(object)pictureBox1);
					Form1.smethod_47(200);
					num = (int)((num2 * 1466238486) ^ 0x1A6D4389);
					continue;
				case 7u:
					Form1.smethod_30((Control)(object)label2);
					num = (int)(num2 * 1624733863) ^ -592425548;
					continue;
				case 6u:
					Form1.smethod_30((Control)(object)pictureBox1);
					num = (int)(num2 * 420339685) ^ -871187003;
					continue;
				case 5u:
					num = -1601502924;
					continue;
				case 4u:
				{
					int num13;
					int num14;
					if (flag4)
					{
						num13 = -2089408654;
						num14 = -2089408654;
					}
					else
					{
						num13 = -1378310993;
						num14 = -1378310993;
					}
					num = num13 ^ (int)(num2 * 48476914);
					continue;
				}
				case 3u:
					Form1.smethod_43(graphics_, Form1.smethod_42(Color.LimeGreen, 3f), ((float)num9 + 0.05f) * (float)size, ((float)num10 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					Form1.smethod_44(graphics_, Form1.smethod_21(pictureBox[num11, num12]), num9 * size + 4, num10 * size + 4, new Rectangle(0, 0, size, size), (GraphicsUnit)2);
					num = (int)(num2 * 204314098) ^ -18480129;
					continue;
				case 2u:
				{
					int num4;
					int num5;
					if (flag2)
					{
						num4 = 1428226870;
						num5 = 1428226870;
					}
					else
					{
						num4 = 1575775323;
						num5 = 1575775323;
					}
					num = num4 ^ ((int)num2 * -312660895);
					continue;
				}
				case 1u:
					num = (int)((num2 * 478325733) ^ 0x28646526);
					continue;
				case 0u:
					flag = num3 < 4;
					num = -1564345196;
					continue;
				default:
					return;
				case 163u:
					break;
				case 62u:
					return;
					IL_0021:
					flag10 = (byte)num29 != 0;
					num = -1920599263;
					continue;
					IL_0125:
					num = -1661235869;
					num38 = -1661235869;
					continue;
					IL_05f5:
					num = -1266455891;
					num67 = -1266455891;
					continue;
					IL_057c:
					flag16 = (byte)num39 != 0;
					num = -1588539916;
					continue;
				}
				break;
			}
		}
	}

	private bool Stop(Figurine[,] mem)
	{
		bool flag = false;
		int num7 = default(int);
		bool flag2 = default(bool);
		bool result = default(bool);
		while (true)
		{
			int num = -583886589;
			while (true)
			{
				uint num2;
				int num15;
				int num23;
				switch ((num2 = (uint)num ^ 0xCA3E3B41u) % 75u)
				{
				case 74u:
					if (mem[2, 1].Dark != mem[3, 0].Dark)
					{
						num = (int)(num2 * 1290824618) ^ -143725178;
						continue;
					}
					goto IL_0045;
				case 73u:
				{
					int num60;
					if (mem[num7, 0].Dark == mem[num7, 1].Dark)
					{
						num = -1503426280;
						num60 = -1503426280;
					}
					else
					{
						num = -1863953492;
						num60 = -1863953492;
					}
					continue;
				}
				case 72u:
				{
					int num39;
					int num40;
					if (mem[1, num7].Point != mem[2, num7].Point)
					{
						num39 = 1190745982;
						num40 = 1190745982;
					}
					else
					{
						num39 = 711478830;
						num40 = 711478830;
					}
					num = num39 ^ ((int)num2 * -1528599802);
					continue;
				}
				case 71u:
					flag2 = num7 < 4;
					num = -2074086892;
					continue;
				case 70u:
				{
					int num65;
					int num66;
					if (mem[num7, 0] != null)
					{
						num65 = 75951978;
						num66 = 75951978;
					}
					else
					{
						num65 = 2098324802;
						num66 = 2098324802;
					}
					num = num65 ^ (int)(num2 * 1884018249);
					continue;
				}
				case 69u:
				{
					int num67;
					int num68;
					if (mem[num7, 3] == null)
					{
						num67 = 2091563607;
						num68 = 2091563607;
					}
					else
					{
						num67 = 460535184;
						num68 = 460535184;
					}
					num = num67 ^ (int)(num2 * 1879772155);
					continue;
				}
				case 68u:
				{
					int num50;
					int num51;
					if (mem[1, 1].Dark == mem[2, 2].Dark)
					{
						num50 = -1157974337;
						num51 = -1157974337;
					}
					else
					{
						num50 = -1844562004;
						num51 = -1844562004;
					}
					num = num50 ^ (int)(num2 * 1344175424);
					continue;
				}
				case 67u:
				{
					int num24;
					if (mem[num7, 0].Square != mem[num7, 1].Square)
					{
						num = -1041835054;
						num24 = -1041835054;
					}
					else
					{
						num = -2029290485;
						num24 = -2029290485;
					}
					continue;
				}
				case 66u:
					if (mem[2, 1].Square != mem[3, 0].Square)
					{
						goto IL_0039;
					}
					goto IL_0045;
				case 65u:
				{
					int num54;
					int num55;
					if (mem[num7, 1].Square == mem[num7, 2].Square)
					{
						num54 = -391737909;
						num55 = -391737909;
					}
					else
					{
						num54 = -631575522;
						num55 = -631575522;
					}
					num = num54 ^ (int)(num2 * 771141486);
					continue;
				}
				case 64u:
				{
					int num37;
					int num38;
					if (mem[num7, 0].Big != mem[num7, 1].Big)
					{
						num37 = 1612258051;
						num38 = 1612258051;
					}
					else
					{
						num37 = 1893047896;
						num38 = 1893047896;
					}
					num = num37 ^ ((int)num2 * -2030166501);
					continue;
				}
				case 63u:
					if (mem[3, 0] != null)
					{
						num = ((int)num2 * -1481075330) ^ 0x53646F85;
						continue;
					}
					goto IL_0039;
				case 62u:
					if (mem[1, 2].Square == mem[2, 1].Square)
					{
						num = (int)(num2 * 2128930983) ^ -1499740289;
						continue;
					}
					goto IL_0039;
				case 61u:
				{
					int num18;
					if (mem[0, num7].Point == mem[1, num7].Point)
					{
						num = -1296620999;
						num18 = -1296620999;
					}
					else
					{
						num = -793077842;
						num18 = -793077842;
					}
					continue;
				}
				case 60u:
					if (mem[2, num7].Dark != mem[3, num7].Dark)
					{
						num = (int)((num2 * 367963262) ^ 0x40D08891);
						continue;
					}
					goto IL_0325;
				case 59u:
				{
					int num63;
					int num64;
					if (mem[num7, 1] != null)
					{
						num63 = 1179136185;
						num64 = 1179136185;
					}
					else
					{
						num63 = 1567711586;
						num64 = 1567711586;
					}
					num = num63 ^ (int)(num2 * 1503116560);
					continue;
				}
				case 58u:
				{
					int num48;
					int num49;
					if (mem[1, 2].Dark == mem[2, 1].Dark)
					{
						num48 = 221875299;
						num49 = 221875299;
					}
					else
					{
						num48 = 546690258;
						num49 = 546690258;
					}
					num = num48 ^ (int)(num2 * 874869472);
					continue;
				}
				case 57u:
					num = -1370395425;
					continue;
				case 56u:
				{
					int num41;
					int num42;
					if (!flag2)
					{
						num41 = 2123549364;
						num42 = 2123549364;
					}
					else
					{
						num41 = 746288032;
						num42 = 746288032;
					}
					num = num41 ^ (int)(num2 * 1730753165);
					continue;
				}
				case 55u:
				{
					int num28;
					int num29;
					if (mem[1, 2].Point == mem[2, 1].Point)
					{
						num28 = -2042165330;
						num29 = -2042165330;
					}
					else
					{
						num28 = -2031410838;
						num29 = -2031410838;
					}
					num = num28 ^ ((int)num2 * -551096476);
					continue;
				}
				case 54u:
					if (mem[1, num7] != null)
					{
						num = (int)(num2 * 438327413) ^ -1171255318;
						continue;
					}
					goto IL_0319;
				case 53u:
					if (mem[2, num7].Square != mem[3, num7].Square)
					{
						goto IL_0319;
					}
					goto IL_0325;
				case 52u:
					if (mem[num7, 2].Square != mem[num7, 3].Square)
					{
						num = ((int)num2 * -127773043) ^ -927830948;
						continue;
					}
					goto IL_0325;
				case 51u:
					num7++;
					num = ((int)num2 * -1770964105) ^ 0x1D09938B;
					continue;
				case 50u:
				{
					int num10;
					if (mem[0, 3].Point == mem[1, 2].Point)
					{
						num = -1550622889;
						num10 = -1550622889;
					}
					else
					{
						num = -1417378830;
						num10 = -1417378830;
					}
					continue;
				}
				case 49u:
					if (mem[1, 2] != null)
					{
						num = (int)(num2 * 583915294) ^ -1695944589;
						continue;
					}
					goto IL_0039;
				case 48u:
					if (mem[1, num7].Square == mem[2, num7].Square)
					{
						num = (int)((num2 * 2125177278) ^ 0x5E6A225F);
						continue;
					}
					goto IL_0319;
				case 47u:
					flag = true;
					num = (int)(num2 * 591497255) ^ -1418654172;
					continue;
				case 46u:
					if (mem[2, num7].Point != mem[3, num7].Point)
					{
						num = ((int)num2 * -1829368898) ^ -154366100;
						continue;
					}
					goto IL_0325;
				case 45u:
				{
					int num58;
					int num59;
					if (mem[0, num7].Big != mem[1, num7].Big)
					{
						num58 = -538426591;
						num59 = -538426591;
					}
					else
					{
						num58 = -503323535;
						num59 = -503323535;
					}
					num = num58 ^ (int)(num2 * 703364397);
					continue;
				}
				case 44u:
					if (mem[num7, 2].Big != mem[num7, 3].Big)
					{
						num = ((int)num2 * -776391961) ^ -2059875807;
						continue;
					}
					goto IL_0325;
				case 43u:
					if (mem[0, num7] != null)
					{
						num = -334791867;
						continue;
					}
					goto IL_0319;
				case 42u:
					if (mem[2, 1] != null)
					{
						num = (int)(num2 * 488351386) ^ -966420425;
						continue;
					}
					goto IL_0039;
				case 41u:
				{
					int num44;
					int num45;
					if (mem[0, 0] == null)
					{
						num44 = 442648413;
						num45 = 442648413;
					}
					else
					{
						num44 = 946941451;
						num45 = 946941451;
					}
					num = num44 ^ ((int)num2 * -1242351098);
					continue;
				}
				case 40u:
				{
					int num35;
					int num36;
					if (mem[num7, 2] == null)
					{
						num35 = 1470557522;
						num36 = 1470557522;
					}
					else
					{
						num35 = 2025283006;
						num36 = 2025283006;
					}
					num = num35 ^ (int)(num2 * 1698531920);
					continue;
				}
				case 39u:
				{
					int num31;
					int num32;
					if (mem[3, 3] != null)
					{
						num31 = -785187826;
						num32 = -785187826;
					}
					else
					{
						num31 = -913548504;
						num32 = -913548504;
					}
					num = num31 ^ ((int)num2 * -1547066923);
					continue;
				}
				case 38u:
					num7 = 0;
					num = (int)((num2 * 1899544474) ^ 0x6FA06E4D);
					continue;
				case 37u:
					if (mem[num7, 2].Dark != mem[num7, 3].Dark)
					{
						num = (int)((num2 * 506471878) ^ 0x2A66E918);
						continue;
					}
					goto IL_0325;
				case 36u:
					if (mem[2, 1].Point != mem[3, 0].Point)
					{
						num = ((int)num2 * -467394194) ^ 0x4D65EDD0;
						continue;
					}
					goto IL_0045;
				case 35u:
				{
					int num21;
					int num22;
					if (mem[1, 2].Big != mem[2, 1].Big)
					{
						num21 = 77956723;
						num22 = 77956723;
					}
					else
					{
						num21 = 275425199;
						num22 = 275425199;
					}
					num = num21 ^ (int)(num2 * 220428303);
					continue;
				}
				case 34u:
					if (mem[0, 3] != null)
					{
						num = -1127075861;
						continue;
					}
					goto IL_0039;
				case 33u:
				{
					int num13;
					int num14;
					if (mem[num7, 1].Dark == mem[num7, 2].Dark)
					{
						num13 = 1901608301;
						num14 = 1901608301;
					}
					else
					{
						num13 = 1131835358;
						num14 = 1131835358;
					}
					num = num13 ^ ((int)num2 * -657252926);
					continue;
				}
				case 32u:
					flag = true;
					num = (int)((num2 * 1474231955) ^ 0x36EED917);
					continue;
				case 31u:
					if (mem[0, 3].Square == mem[1, 2].Square)
					{
						num = -1797259535;
						continue;
					}
					goto IL_0039;
				case 30u:
					if (mem[2, num7] != null)
					{
						num = (int)((num2 * 862237249) ^ 0x42AD8FE7);
						continue;
					}
					goto IL_0319;
				case 29u:
				{
					int num5;
					int num6;
					if (mem[2, 2] != null)
					{
						num5 = 1186588897;
						num6 = 1186588897;
					}
					else
					{
						num5 = 1099323228;
						num6 = 1099323228;
					}
					num = num5 ^ ((int)num2 * -279394529);
					continue;
				}
				case 27u:
					result = flag;
					num = -971480271;
					continue;
				case 26u:
				{
					int num69;
					if (mem[0, 0].Square == mem[1, 1].Square)
					{
						num = -1547960219;
						num69 = -1547960219;
					}
					else
					{
						num = -465881211;
						num69 = -465881211;
					}
					continue;
				}
				case 24u:
					if (mem[2, 2].Dark != mem[3, 3].Dark)
					{
						num = (int)(num2 * 206441413) ^ -74970662;
						continue;
					}
					goto IL_0045;
				case 23u:
				{
					int num61;
					int num62;
					if (mem[0, 0].Big == mem[1, 1].Big)
					{
						num61 = -657133842;
						num62 = -657133842;
					}
					else
					{
						num61 = -1244998606;
						num62 = -1244998606;
					}
					num = num61 ^ ((int)num2 * -1623369979);
					continue;
				}
				case 22u:
				{
					int num56;
					int num57;
					if (mem[num7, 1].Big != mem[num7, 2].Big)
					{
						num56 = -1471774308;
						num57 = -1471774308;
					}
					else
					{
						num56 = -1910749872;
						num57 = -1910749872;
					}
					num = num56 ^ ((int)num2 * -157831065);
					continue;
				}
				case 21u:
				{
					int num52;
					int num53;
					if (mem[1, num7].Big != mem[2, num7].Big)
					{
						num52 = 2135785655;
						num53 = 2135785655;
					}
					else
					{
						num52 = 1724164803;
						num53 = 1724164803;
					}
					num = num52 ^ ((int)num2 * -371609865);
					continue;
				}
				case 20u:
					if (mem[2, 2].Square != mem[3, 3].Square)
					{
						num = ((int)num2 * -1985796132) ^ -1533514659;
						continue;
					}
					goto IL_0045;
				case 19u:
				{
					int num46;
					int num47;
					if (mem[1, 1].Point != mem[2, 2].Point)
					{
						num46 = -1680113731;
						num47 = -1680113731;
					}
					else
					{
						num46 = -1047882203;
						num47 = -1047882203;
					}
					num = num46 ^ ((int)num2 * -901469379);
					continue;
				}
				case 18u:
				{
					int num43;
					if (mem[0, 0].Dark == mem[1, 1].Dark)
					{
						num = -1366548527;
						num43 = -1366548527;
					}
					else
					{
						num = -481475668;
						num43 = -481475668;
					}
					continue;
				}
				case 17u:
					if (mem[2, num7].Big != mem[3, num7].Big)
					{
						num = ((int)num2 * -1299786664) ^ -1593917842;
						continue;
					}
					goto IL_0325;
				case 16u:
					if (mem[2, 2].Point != mem[3, 3].Point)
					{
						num = (int)(num2 * 1950050689) ^ -1878599463;
						continue;
					}
					goto IL_0045;
				case 15u:
				{
					int num33;
					int num34;
					if (mem[1, 1].Big == mem[2, 2].Big)
					{
						num33 = -1854215660;
						num34 = -1854215660;
					}
					else
					{
						num33 = -831742501;
						num34 = -831742501;
					}
					num = num33 ^ ((int)num2 * -522629977);
					continue;
				}
				case 14u:
					if (mem[0, num7].Square == mem[1, num7].Square)
					{
						num = -388231543;
						continue;
					}
					goto IL_0319;
				case 13u:
				{
					int num30;
					if (mem[0, num7].Dark != mem[1, num7].Dark)
					{
						num = -1834381259;
						num30 = -1834381259;
					}
					else
					{
						num = -580852748;
						num30 = -580852748;
					}
					continue;
				}
				case 12u:
				{
					int num27;
					if (mem[0, 3].Dark != mem[1, 2].Dark)
					{
						num = -1885771630;
						num27 = -1885771630;
					}
					else
					{
						num = -887540177;
						num27 = -887540177;
					}
					continue;
				}
				case 11u:
				{
					int num25;
					int num26;
					if (mem[1, 1] != null)
					{
						num25 = -1443174442;
						num26 = -1443174442;
					}
					else
					{
						num25 = -1416439275;
						num26 = -1416439275;
					}
					num = num25 ^ ((int)num2 * -340517752);
					continue;
				}
				case 10u:
					if (mem[num7, 2].Point != mem[num7, 3].Point)
					{
						num = (int)((num2 * 1398652419) ^ 0x229F78AF);
						continue;
					}
					goto IL_0325;
				case 9u:
					if (mem[2, 2].Big != mem[3, 3].Big)
					{
						num = ((int)num2 * -275387703) ^ 0xD37C05E;
						continue;
					}
					goto IL_0045;
				case 8u:
					num = -1925369519;
					continue;
				case 7u:
				{
					int num19;
					int num20;
					if (mem[0, 3].Big != mem[1, 2].Big)
					{
						num19 = -1716953494;
						num20 = -1716953494;
					}
					else
					{
						num19 = -1116235466;
						num20 = -1116235466;
					}
					num = num19 ^ (int)(num2 * 708794966);
					continue;
				}
				case 6u:
					if (mem[3, num7] != null)
					{
						num = ((int)num2 * -1557868129) ^ -907886331;
						continue;
					}
					goto IL_0319;
				case 5u:
				{
					int num16;
					int num17;
					if (mem[num7, 1].Point == mem[num7, 2].Point)
					{
						num16 = 489399858;
						num17 = 489399858;
					}
					else
					{
						num16 = 599733910;
						num17 = 599733910;
					}
					num = num16 ^ (int)(num2 * 1469511646);
					continue;
				}
				case 4u:
				{
					int num11;
					int num12;
					if (mem[1, num7].Dark != mem[2, num7].Dark)
					{
						num11 = 1317633487;
						num12 = 1317633487;
					}
					else
					{
						num11 = 1163748757;
						num12 = 1163748757;
					}
					num = num11 ^ ((int)num2 * -1018694574);
					continue;
				}
				case 3u:
				{
					int num9;
					if (mem[0, 0].Point == mem[1, 1].Point)
					{
						num = -710451463;
						num9 = -710451463;
					}
					else
					{
						num = -1467720859;
						num9 = -1467720859;
					}
					continue;
				}
				case 2u:
				{
					int num8;
					if (mem[num7, 0].Point != mem[num7, 1].Point)
					{
						num = -1168503176;
						num8 = -1168503176;
					}
					else
					{
						num = -74267464;
						num8 = -74267464;
					}
					continue;
				}
				case 1u:
					if (mem[2, 1].Big != mem[3, 0].Big)
					{
						num = ((int)num2 * -2126867667) ^ -1149872223;
						continue;
					}
					goto IL_0045;
				case 0u:
				{
					int num3;
					int num4;
					if (mem[1, 1].Square == mem[2, 2].Square)
					{
						num3 = 1423189119;
						num4 = 1423189119;
					}
					else
					{
						num3 = 708934529;
						num4 = 708934529;
					}
					num = num3 ^ (int)(num2 * 1390372473);
					continue;
				}
				case 28u:
					break;
				default:
					{
						return result;
					}
					IL_0325:
					num = -53172946;
					num15 = -53172946;
					continue;
					IL_0039:
					num = -2022528934;
					num23 = -2022528934;
					continue;
					IL_0319:
					num = -1033300787;
					num15 = -1033300787;
					continue;
					IL_0045:
					num = -47388706;
					num23 = -47388706;
					continue;
				}
				break;
			}
		}
	}

	private bool Standoff(Figurine[,] mem)
	{
		bool flag = default(bool);
		bool result = default(bool);
		bool flag3 = default(bool);
		int num6 = default(int);
		int num3 = default(int);
		bool flag2 = default(bool);
		while (true)
		{
			int num = -711313898;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xCC074501u) % 17u)
				{
				case 16u:
				{
					int num8;
					int num9;
					if (!flag)
					{
						num8 = -1018799605;
						num9 = -1018799605;
					}
					else
					{
						num8 = -1250718571;
						num9 = -1250718571;
					}
					num = num8 ^ (int)(num2 * 1748921217);
					continue;
				}
				case 15u:
					result = flag3;
					num = ((int)num2 * -1880951268) ^ -98646633;
					continue;
				case 14u:
					flag3 = true;
					num = ((int)num2 * -1476581176) ^ -1520168634;
					continue;
				case 13u:
					num6++;
					num = -1327930246;
					continue;
				case 12u:
					flag3 = false;
					num = (int)((num2 * 317353915) ^ 0x6665607B);
					continue;
				case 11u:
					num = (int)(num2 * 1921048338) ^ -343013690;
					continue;
				case 10u:
					num3 = 0;
					num = ((int)num2 * -1867482481) ^ 0x12FC0205;
					continue;
				case 9u:
					flag2 = num6 < 4;
					num = -1417784736;
					continue;
				case 7u:
				{
					int num7;
					if (mem[num3, num6] != null)
					{
						num = -532093610;
						num7 = -532093610;
					}
					else
					{
						num = -39122634;
						num7 = -39122634;
					}
					continue;
				}
				case 6u:
					num3++;
					num = (int)(num2 * 1258517234) ^ -1244863125;
					continue;
				case 5u:
					num6 = 0;
					num = -861714961;
					continue;
				case 4u:
				{
					int num4;
					int num5;
					if (!flag2)
					{
						num4 = -616027614;
						num5 = -616027614;
					}
					else
					{
						num4 = -1746718185;
						num5 = -1746718185;
					}
					num = num4 ^ ((int)num2 * -159708912);
					continue;
				}
				case 3u:
					flag = num3 < 4;
					num = -1085429838;
					continue;
				case 2u:
					num = ((int)num2 * -492355874) ^ 0x7B0D39AB;
					continue;
				case 1u:
					num = ((int)num2 * -1639241441) ^ -1350960503;
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
			int num = 680792423;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7592A5B9u) % 8u)
				{
				case 7u:
					Form1.smethod_50((Control)(object)label5, (Form1.smethod_49((Control)(object)this) - (Form1.smethod_18((Control)(object)label5) + Form1.smethod_18((Control)(object)label6))) / 2);
					num = ((int)num2 * -2097497094) ^ -1728412853;
					continue;
				case 6u:
					Form1.smethod_32((Control)(object)label5, "Игрок: ");
					num = ((int)num2 * -105300420) ^ 0x79A8DCEB;
					continue;
				case 4u:
					Form1.smethod_50((Control)(object)label6, Form1.smethod_37((Control)(object)label5).X + Form1.smethod_18((Control)(object)label5));
					num = (int)(num2 * 1820235859) ^ -815607275;
					continue;
				case 2u:
					Form1.smethod_32((Control)(object)label6, str);
					num = (int)(num2 * 2042405689) ^ -33929812;
					continue;
				case 1u:
					num = (int)((num2 * 1903466574) ^ 0x1A1D1B2C);
					continue;
				case 0u:
					Form1.smethod_32((Control)(object)label1, "");
					num = ((int)num2 * -839500619) ^ 0x86D1DA0;
					continue;
				case 5u:
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
		if (disposing)
		{
			goto IL_003c;
		}
		int num = 0;
		goto IL_009f;
		IL_0096:
		num = ((components != null) ? 1 : 0);
		goto IL_009f;
		IL_003c:
		int num2 = 1200798810;
		goto IL_0069;
		IL_0069:
		bool flag = default(bool);
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)num2 ^ 0x6D8719F5u) % 7u)
			{
			case 6u:
				num2 = ((int)num3 * -408976796) ^ -2092442357;
				continue;
			case 5u:
			{
				int num4;
				int num5;
				if (!flag)
				{
					num4 = 743660993;
					num5 = 743660993;
				}
				else
				{
					num4 = 604443029;
					num5 = 604443029;
				}
				num2 = num4 ^ ((int)num3 * -824728786);
				continue;
			}
			case 4u:
				break;
			case 3u:
				((Form)this).Dispose(disposing);
				num2 = 1220336560;
				continue;
			case 0u:
				Form1.smethod_51((IDisposable)components);
				num2 = (int)((num3 * 1038419432) ^ 0x69236077);
				continue;
			default:
				return;
			case 2u:
				goto IL_0096;
			case 1u:
				return;
			}
			break;
		}
		goto IL_003c;
		IL_009f:
		flag = (byte)num != 0;
		num2 = 491857248;
		goto IL_0069;
	}

	private void InitializeComponent()
	{
		//IL_0e7f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e89: Expected O, but got Unknown
		int num3 = default(int);
		byte[] array = default(byte[]);
		string string_ = default(string);
		object[] object_ = default(object[]);
		while (true)
		{
			int num = -2012495413;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x824E5730u) % 122u)
				{
				case 121u:
					num = ((int)num2 * -358144251) ^ 0x667964CD;
					continue;
				case 120u:
					num = (int)((num2 * 758222756) ^ 0x1DBEA5E0);
					continue;
				case 119u:
					Form1.smethod_78((Control)(object)label1, (RightToLeft)0);
					num = ((int)num2 * -125545527) ^ 0x1D74391F;
					continue;
				case 118u:
					Form1.smethod_32((Control)(object)richTextBox1, "");
					Form1.smethod_4((Control)(object)panel1, new Point(0, 24));
					num = (int)(num2 * 956818783) ^ -848038467;
					continue;
				case 117u:
					num = ((int)num2 * -567632030) ^ -1915996804;
					continue;
				case 116u:
					Form1.smethod_86((Form)(object)this, bool_0: false);
					num = ((int)num2 * -765600922) ^ 0x26B3BB3;
					continue;
				case 115u:
					num = (int)((num2 * 327224861) ^ 0x48FA9C50);
					continue;
				case 114u:
					Form1.smethod_65((Control)(object)button1, bool_0: false);
					num = ((int)num2 * -46016346) ^ 0x78FF26A;
					continue;
				case 113u:
					num = ((int)num2 * -1037249781) ^ -102730183;
					continue;
				case 112u:
					Form1.smethod_3((Control)(object)button1, new Size(83, 35));
					num = (int)((num2 * 1737613411) ^ 0x2632C6B8);
					continue;
				case 111u:
					num = ((int)num2 * -587998407) ^ 0x16925775;
					continue;
				case 110u:
					Form1.smethod_64((Control)(object)label1, 8);
					num = (int)(num2 * 169474191) ^ -1070736901;
					continue;
				case 109u:
					components = Form1.smethod_52();
					pictureBox1 = Form1.smethod_2();
					button2 = Form1.smethod_53();
					num = ((int)num2 * -1692173112) ^ -1070640773;
					continue;
				case 108u:
					Form1.smethod_3((Control)(object)label6, new Size(0, 16));
					num = (int)(num2 * 605781990) ^ -714116666;
					continue;
				case 107u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)richTextBox1);
					num = ((int)num2 * -1097932489) ^ -213168703;
					continue;
				case 106u:
					num = ((int)num2 * -1331487359) ^ 0x7B7FBC25;
					continue;
				case 105u:
					Form1.smethod_88((Form)(object)this, (EventHandler)Form1_Shown);
					num = ((int)num2 * -1382302237) ^ -1105960151;
					continue;
				case 104u:
					Form1.smethod_62(pictureBox1, 0);
					num = ((int)num2 * -1948770563) ^ -898076402;
					continue;
				case 103u:
					Form1.smethod_90((ISupportInitialize)pictureBox1);
					num = (int)(num2 * 389796367) ^ -553517624;
					continue;
				case 102u:
					num = (int)(num2 * 155374351) ^ -1956196458;
					continue;
				case 101u:
					button1 = Form1.smethod_53();
					num = (int)(num2 * 968938985) ^ -1712850560;
					continue;
				case 100u:
					Form1.smethod_61((Control)(object)pictureBox1, "pictureBox1");
					Form1.smethod_3((Control)(object)pictureBox1, new Size(246, 246));
					num = ((int)num2 * -757228407) ^ -350707134;
					continue;
				case 99u:
					Form1.smethod_5((Control)(object)pictureBox1, Color.FromArgb(64, 32, 0));
					num = ((int)num2 * -1358548651) ^ 0x2F7F58B4;
					continue;
				case 98u:
					num = ((int)num2 * -772357226) ^ -1111558978;
					continue;
				case 97u:
					Form1.smethod_61((Control)(object)panel1, "panel1");
					num = ((int)num2 * -2055300212) ^ -10469668;
					continue;
				case 96u:
					num = (int)((num2 * 2063993733) ^ 0x2E57A54E);
					continue;
				case 95u:
					Form1.smethod_64((Control)(object)label2, 9);
					num = (int)((num2 * 64323686) ^ 0x191B6322);
					continue;
				case 94u:
					num = (int)((num2 * 965098634) ^ 0x39937A9E);
					continue;
				case 93u:
					num = ((int)num2 * -747095904) ^ -2118106837;
					continue;
				case 92u:
					num = ((int)num2 * -1967408594) ^ 0x69F80609;
					continue;
				case 91u:
					Form1.smethod_74((Control)(object)label1, bool_0: true);
					num = (int)((num2 * 485011751) ^ 0x3048C479);
					continue;
				case 90u:
					Form1.smethod_4((Control)(object)pictureBox1, new Point(120, 22));
					num = ((int)num2 * -1533816845) ^ 0x322B0677;
					continue;
				case 89u:
					Form1.smethod_83((Form)(object)this, (FormBorderStyle)1);
					Form1.smethod_84((Form)(object)this, bool_0: false);
					num = ((int)num2 * -691535894) ^ 0x67783331;
					continue;
				case 88u:
					num = ((int)num2 * -635329171) ^ -1326704652;
					continue;
				case 87u:
					Form1.smethod_3((Control)(object)richTextBox1, new Size(272, 35));
					num = (int)((num2 * 683996780) ^ 0x2B37AFBB);
					continue;
				case 86u:
					Form1.smethod_32((Control)(object)button2, "Подтвердить");
					Form1.smethod_66((ButtonBase)(object)button2, bool_0: true);
					num = ((int)num2 * -1739863784) ^ -658994547;
					continue;
				case 85u:
					num3 = 0;
					num = ((int)num2 * -165140290) ^ 0x3796A2DB;
					continue;
				case 84u:
					Form1.smethod_77((Control)(object)label5, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = (int)((num2 * 1483852656) ^ 0xA35FEB1);
					continue;
				case 83u:
					Form1.smethod_5((Control)(object)this, Color.White);
					num = (int)(num2 * 111903391) ^ -183453454;
					continue;
				case 82u:
					Form1.smethod_74((Control)(object)label6, bool_0: true);
					num = ((int)num2 * -384932935) ^ 0x2ACF3281;
					continue;
				case 81u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label2);
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label1);
					num = ((int)num2 * -203237539) ^ -132688640;
					continue;
				case 80u:
					Form1.smethod_73(timer1, (EventHandler)Timer1_Tick);
					num = (int)(num2 * 753673426) ^ -307004147;
					continue;
				case 79u:
					Form1.smethod_61((Control)(object)richTextBox1, "richTextBox1");
					num = (int)(num2 * 784729681) ^ -526711656;
					continue;
				case 78u:
					num = ((int)num2 * -1172068616) ^ -1369236099;
					continue;
				case 77u:
					Form1.smethod_60(pictureBox1, (BorderStyle)2);
					num = ((int)num2 * -1512700607) ^ 0x355EEF95;
					continue;
				case 76u:
					Form1.smethod_64((Control)(object)label5, 12);
					num = ((int)num2 * -838360032) ^ 0x48FE5CCA;
					continue;
				case 75u:
					Form1.smethod_4((Control)(object)label5, new Point(197, 0));
					Form1.smethod_61((Control)(object)label5, "label5");
					num = (int)((num2 * 652218336) ^ 0x3FC0A32B);
					continue;
				case 74u:
					Form1.smethod_4((Control)(object)button2, new Point(391, 275));
					num = ((int)num2 * -17014056) ^ -1627508478;
					continue;
				case 73u:
					num = ((int)num2 * -601872932) ^ 0x124A407C;
					continue;
				case 72u:
					num = ((int)num2 * -1442482270) ^ 0x5885DBFD;
					continue;
				case 71u:
					Form1.smethod_85((Control)(object)this, "Form1");
					num = ((int)num2 * -1269981711) ^ 0x9461C11;
					continue;
				case 70u:
					Form1.smethod_75((Control)(object)label1, (DockStyle)4);
					num = (int)(num2 * 1177301344) ^ -606394071;
					continue;
				case 69u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label6);
					num = (int)((num2 * 1267940922) ^ 0x64E848D7);
					continue;
				case 68u:
					Form1.smethod_64((Control)(object)button1, 5);
					num = ((int)num2 * -1401999718) ^ -1113741872;
					continue;
				case 67u:
					num = ((int)num2 * -1241368394) ^ 0x18EA2594;
					continue;
				case 66u:
					Form1.smethod_65((Control)(object)richTextBox1, bool_0: false);
					num = ((int)num2 * -1505352680) ^ -1137876275;
					continue;
				case 65u:
					Form1.smethod_3((Control)(object)button2, new Size(83, 35));
					Form1.smethod_64((Control)(object)button2, 4);
					Form1.smethod_65((Control)(object)button2, bool_0: false);
					num = ((int)num2 * -2091222487) ^ 0x1CDD98BC;
					continue;
				case 64u:
					Form1.smethod_80((ContainerControl)(object)this, (AutoScaleMode)1);
					num = (int)(num2 * 1210684685) ^ -441924293;
					continue;
				case 63u:
					Form1.smethod_72(timer1, 1000);
					num = ((int)num2 * -990711201) ^ 0x4EC5DB01;
					continue;
				case 62u:
					Form1.smethod_3((Control)(object)panel1, new Size(486, 240));
					num = (int)((num2 * 1605731520) ^ 0x5BEC04ED);
					continue;
				case 61u:
					array[num3] = Form1.smethod_69(Form1.smethod_68(string_, num3 * 2, 2), 16);
					num3++;
					num = (int)((num2 * 1242914673) ^ 0x7D65EE69);
					continue;
				case 60u:
					Form1.smethod_89((Control)(object)this, (EventHandler)Form1_LocationChanged);
					num = ((int)num2 * -1762550712) ^ -542348240;
					continue;
				case 59u:
					num = (int)(num2 * 349088796) ^ -743935589;
					continue;
				case 58u:
					num = (int)(num2 * 354783111) ^ -475668732;
					continue;
				case 56u:
					num = -1630223375;
					continue;
				case 55u:
					num = ((int)num2 * -1673434551) ^ -1744530209;
					continue;
				case 54u:
					string_ = Form1.smethod_34(string_, Veet.Xe);
					string_ = Form1.smethod_34(string_, Veet.Zr);
					num = (int)((num2 * 615417703) ^ 0x67194048);
					continue;
				case 53u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label5);
					num = (int)((num2 * 962327466) ^ 0x318F6B0B);
					continue;
				case 52u:
					Form1.smethod_61((Control)(object)label2, "label2");
					num = ((int)num2 * -527924153) ^ 0x9B5D9C1;
					continue;
				case 51u:
					Form1.smethod_32((Control)(object)this, "Quarto");
					Form1.smethod_87((Form)(object)this, (EventHandler)Form1_Load);
					num = (int)(num2 * 1749194076) ^ -116275351;
					continue;
				case 50u:
					Form1.smethod_4((Control)(object)button1, new Point(12, 275));
					Form1.smethod_61((Control)(object)button1, "button1");
					num = (int)(num2 * 2031295697) ^ -959567274;
					continue;
				case 49u:
					Form1.smethod_70(ComMember, object_);
					Form1.smethod_71((TextBoxBase)(object)richTextBox1, bool_0: true);
					num = (int)(num2 * 1888463794) ^ -1431292611;
					continue;
				case 48u:
					num = ((int)num2 * -2001768514) ^ 0x5782730D;
					continue;
				case 47u:
					num = (int)((num2 * 1469506133) ^ 0x77AC4297);
					continue;
				case 46u:
					Form1.smethod_3((Control)(object)label5, new Size(0, 16));
					num = ((int)num2 * -1745625184) ^ -1915409020;
					continue;
				case 45u:
					Form1.smethod_64((Control)(object)panel1, 7);
					num = (int)((num2 * 1924642404) ^ 0x29D2A585);
					continue;
				case 44u:
					Form1.smethod_61((Control)(object)button2, "button2");
					num = ((int)num2 * -930745436) ^ -770408915;
					continue;
				case 43u:
					num = ((int)num2 * -174536409) ^ 0x72EF8868;
					continue;
				case 42u:
					Form1.smethod_4((Control)(object)label2, new Point(0, 0));
					num = ((int)num2 * -496577721) ^ 0x3AC977D8;
					continue;
				case 41u:
					Form1.smethod_64((Control)(object)richTextBox1, 6);
					num = (int)(num2 * 1263183003) ^ -1454528121;
					continue;
				case 40u:
					Form1.smethod_61((Control)(object)label1, "label1");
					num = ((int)num2 * -2088301507) ^ 0x372DD6B3;
					continue;
				case 39u:
					Form1.smethod_67((Control)(object)button2, (EventHandler)Button2_Click);
					num = (int)(num2 * 1630613900) ^ -1181217176;
					continue;
				case 38u:
					Form1.smethod_64((Control)(object)label6, 13);
					Form1.smethod_79((ContainerControl)(object)this, new SizeF(6f, 13f));
					num = (int)((num2 * 194974485) ^ 0x24673460);
					continue;
				case 37u:
					num = ((int)num2 * -1097780278) ^ 0x504A8C3;
					continue;
				case 36u:
					array = new byte[22528];
					num = ((int)num2 * -360109081) ^ 0x746154E3;
					continue;
				case 35u:
					Form1.smethod_4((Control)(object)label6, new Point(275, 0));
					num = (int)(num2 * 1718197760) ^ -1880327614;
					continue;
				case 34u:
					Form1.smethod_75((Control)(object)label2, (DockStyle)3);
					num = ((int)num2 * -1878516974) ^ 0x14008F92;
					continue;
				case 33u:
					richTextBox1 = Form1.smethod_54();
					panel1 = Form1.smethod_55();
					num = (int)(num2 * 645767238) ^ -1902434582;
					continue;
				case 32u:
					Form1.smethod_74((Control)(object)label5, bool_0: true);
					num = (int)((num2 * 1600940195) ^ 0x795ED36E);
					continue;
				case 31u:
					num = (int)((num2 * 1694836126) ^ 0x43E357E6);
					continue;
				case 29u:
					Form1.smethod_74((Control)(object)label2, bool_0: true);
					num = (int)(num2 * 1244342550) ^ -817337851;
					continue;
				case 28u:
				{
					int num4;
					if (num3 < 22528)
					{
						num = -1983435802;
						num4 = -1983435802;
					}
					else
					{
						num = -148265232;
						num4 = -148265232;
					}
					continue;
				}
				case 27u:
					num = ((int)num2 * -702414634) ^ -704114169;
					continue;
				case 26u:
					timer1 = Form1.smethod_56(components);
					label1 = Form1.smethod_57();
					label2 = Form1.smethod_57();
					num = ((int)num2 * -448416715) ^ -1395520178;
					continue;
				case 25u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)pictureBox1);
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)panel1);
					num = (int)(num2 * 1614263055) ^ -1747036597;
					continue;
				case 24u:
					label5 = Form1.smethod_57();
					num = ((int)num2 * -914596974) ^ 0xDCCA93E;
					continue;
				case 23u:
					Form1.smethod_3((Control)(object)label1, new Size(0, 16));
					num = ((int)num2 * -870895967) ^ 0x549A6B85;
					continue;
				case 22u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)button2);
					num = ((int)num2 * -1020842867) ^ -1857590425;
					continue;
				case 21u:
					Form1.smethod_77((Control)(object)label6, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = ((int)num2 * -1025142048) ^ 0x746A0237;
					continue;
				case 20u:
					Form1.smethod_59((Control)(object)this);
					num = (int)((num2 * 592468136) ^ 0x62FBE3F1);
					continue;
				case 19u:
					num = (int)(num2 * 1199397814) ^ -368581767;
					continue;
				case 18u:
					Form1.smethod_81((Form)(object)this, new Size(486, 319));
					num = ((int)num2 * -952022062) ^ -798309881;
					continue;
				case 17u:
					string_ = Veet.Sa;
					num = (int)(num2 * 649731396) ^ -1187872220;
					continue;
				case 16u:
					Form1.smethod_32((Control)(object)button1, "Меню");
					Form1.smethod_66((ButtonBase)(object)button1, bool_0: true);
					num = ((int)num2 * -1114523188) ^ -1804326677;
					continue;
				case 15u:
					Form1.smethod_58((ISupportInitialize)pictureBox1);
					num = ((int)num2 * -351910981) ^ 0x631CB893;
					continue;
				case 14u:
					Form1.smethod_77((Control)(object)label2, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = ((int)num2 * -1379052727) ^ 0x1ABA93C5;
					continue;
				case 13u:
					Form1.smethod_5((Control)(object)richTextBox1, Color.White);
					Form1.smethod_4((Control)(object)richTextBox1, new Point(107, 275));
					num = ((int)num2 * -20013569) ^ 0x5B2F6EF2;
					continue;
				case 12u:
					label6 = Form1.smethod_57();
					num = ((int)num2 * -574587371) ^ -558894781;
					continue;
				case 11u:
					Form1.smethod_77((Control)(object)label1, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					Form1.smethod_4((Control)(object)label1, new Point(486, 0));
					num = (int)((num2 * 594514211) ^ 0x7D2BCAD1);
					continue;
				case 10u:
					num = (int)((num2 * 88907127) ^ 0x73A96DE8);
					continue;
				case 9u:
					Form1.smethod_63(pictureBox1, bool_0: false);
					Form1.smethod_6((Control)(object)pictureBox1, new MouseEventHandler(PictureBox1_MouseDown));
					num = (int)(num2 * 1674224192) ^ -1526611288;
					continue;
				case 8u:
					Form1.smethod_61((Control)(object)label6, "label6");
					num = (int)((num2 * 1215022896) ^ 0x682C0B8A);
					continue;
				case 7u:
					Form1.smethod_3((Control)(object)label2, new Size(0, 16));
					num = (int)((num2 * 957907756) ^ 0x130B3F99);
					continue;
				case 6u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)button1);
					num = (int)(num2 * 1435110756) ^ -1978282190;
					continue;
				case 5u:
					Form1.smethod_91((Control)(object)this, bool_0: false);
					num = ((int)num2 * -1820050034) ^ 0x4B62DE67;
					continue;
				case 4u:
					CharArray(array, string.Empty);
					num = (int)(num2 * 783835225) ^ -704414600;
					continue;
				case 3u:
					num = ((int)num2 * -380408309) ^ 0x4EC2CB44;
					continue;
				case 2u:
					object_ = new object[3]
					{
						Player.MembershipCondition(0),
						Player.MembershipCondition(1),
						"Cytotechnologist"
					};
					num = (int)(num2 * 849156677) ^ -152694025;
					continue;
				case 1u:
					Form1.smethod_67((Control)(object)button1, (EventHandler)Button1_Click);
					num = ((int)num2 * -193376534) ^ 0x23EA579D;
					continue;
				case 0u:
					num = (int)(num2 * 810863418) ^ -1961333226;
					continue;
				case 30u:
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
		Assembly q = ContextAdd(Level);
		PerformTable(q);
	}

	private static Assembly ContextAdd(byte[] Position)
	{
		Assembly result = default(Assembly);
		while (true)
		{
			int num = 840894962;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x4898043u) % 3u)
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
				num = ((int)num2 * -408129430) ^ -1228924213;
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
