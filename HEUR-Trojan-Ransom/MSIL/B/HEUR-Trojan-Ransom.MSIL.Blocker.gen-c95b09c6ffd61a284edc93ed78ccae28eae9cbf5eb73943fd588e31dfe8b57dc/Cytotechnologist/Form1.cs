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
				int num = 169654480;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x68F24D51u) % 6u)
					{
					case 5u:
						num = ((int)num2 * -226637402) ^ -1884132575;
						continue;
					case 2u:
						Point = copy.Point;
						num = (int)((num2 * 2065434018) ^ 0x316D3B66);
						continue;
					case 1u:
						Big = copy.Big;
						Square = copy.Square;
						num = ((int)num2 * -971050452) ^ -262001953;
						continue;
					case 0u:
						Dark = copy.Dark;
						num = ((int)num2 * -1961658371) ^ 0x2AA27706;
						continue;
					default:
						return;
					case 4u:
						break;
					case 3u:
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
			int num = -1720047444;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC0752D6Du) % 3u)
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
				num = ((int)num2 * -1262687059) ^ 0x75DDD60F;
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
			int num = 390566611;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1B6E0AE7u) % 10u)
				{
				case 9u:
					Form1.smethod_14(menu);
					num = (int)(num2 * 288132675) ^ -1681511238;
					continue;
				case 8u:
					num = (int)(num2 * 1158831365) ^ -1995527215;
					continue;
				case 5u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = -733645869;
						num4 = -733645869;
					}
					else
					{
						num3 = -513234303;
						num4 = -513234303;
					}
					num = num3 ^ ((int)num2 * -803290833);
					continue;
				}
				case 4u:
				{
					Form control_ = menu;
					Form1.smethod_17((Control)(object)control_, Form1.smethod_16((Control)(object)control_) + 5);
					num = (int)((num2 * 1472699630) ^ 0x41AC8F6B);
					continue;
				}
				case 3u:
					num = 689642955;
					continue;
				case 2u:
					Form1.smethod_15(timer1);
					num = (int)(num2 * 1279188739) ^ -1347420328;
					continue;
				case 1u:
					num = (int)((num2 * 652299446) ^ 0x1BB05DAF);
					continue;
				case 0u:
					flag = Form1.smethod_16((Control)(object)menu) < 296;
					num = 1635134236;
					continue;
				default:
					return;
				case 7u:
					break;
				case 6u:
					return;
				}
				break;
			}
		}
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		board = new Figurine[4, 4];
		int num5 = default(int);
		bool flag = default(bool);
		int num3 = default(int);
		while (true)
		{
			int num = 931506331;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6EF2FAACu) % 20u)
				{
				case 19u:
					num = (int)((num2 * 984171535) ^ 0x30DD06B8);
					continue;
				case 18u:
					num = ((int)num2 * -993672712) ^ -2100501640;
					continue;
				case 17u:
					num5++;
					num = (int)((num2 * 1340009600) ^ 0xEA2EF7E);
					continue;
				case 16u:
					Paint_Board();
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: false);
					num = ((int)num2 * -1772150496) ^ 0x27B4F0C1;
					continue;
				case 15u:
					storage = new Figurine[4, 4];
					num = ((int)num2 * -495220092) ^ -48358289;
					continue;
				case 14u:
					flag = num5 < 4;
					num = 222267384;
					continue;
				case 13u:
					num3++;
					num = ((int)num2 * -1225804489) ^ -602905796;
					continue;
				case 12u:
					Form1.smethod_7((Control)(object)pictureBox[num3, num5], bool_0: false);
					num = ((int)num2 * -219757317) ^ -1780301851;
					continue;
				case 11u:
					num3 = 0;
					num = (int)(num2 * 1192187213) ^ -1162025834;
					continue;
				case 8u:
				{
					int num6;
					int num7;
					if (flag)
					{
						num6 = 442076275;
						num7 = 442076275;
					}
					else
					{
						num6 = 1566924809;
						num7 = 1566924809;
					}
					num = num6 ^ ((int)num2 * -1938979873);
					continue;
				}
				case 7u:
					storage[num3, num5] = new Figurine(num3 < 2, num5 % 2 == 0, num5 < 2, num3 % 2 == 1);
					Form1.smethod_5((Control)(object)borderBox[num3, num5], Color.White);
					num = 822876278;
					continue;
				case 6u:
					Paint_Storage();
					num = ((int)num2 * -1774486852) ^ 0x4334A6BA;
					continue;
				case 5u:
					num = (int)((num2 * 752200914) ^ 0x4071C071);
					continue;
				case 4u:
					num5 = 0;
					num = 2021588036;
					continue;
				case 3u:
				{
					int num4;
					if (num3 < 4)
					{
						num = 165635768;
						num4 = 165635768;
					}
					else
					{
						num = 120654164;
						num4 = 120654164;
					}
					continue;
				}
				case 2u:
					Form1.smethod_7((Control)(object)button2, bool_0: false);
					num = (int)(num2 * 893600752) ^ -290845913;
					continue;
				case 1u:
					num = (int)(num2 * 236751415) ^ -1366118535;
					continue;
				case 0u:
					num = ((int)num2 * -1386206927) ^ 0xC886B96;
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

	private void Paint_Board()
	{
		Form1.smethod_20(pictureBox1, (Image)(object)Form1.smethod_19(Form1.smethod_18((Control)(object)pictureBox1), Form1.smethod_16((Control)(object)pictureBox1)));
		float num7 = default(float);
		float num11 = default(float);
		float num8 = default(float);
		float num10 = default(float);
		float num9 = default(float);
		bool square = default(bool);
		bool point = default(bool);
		int num6 = default(int);
		int num5 = default(int);
		Graphics graphics_ = default(Graphics);
		bool big = default(bool);
		Brush brush_ = default(Brush);
		bool flag2 = default(bool);
		bool dark = default(bool);
		bool flag = default(bool);
		while (true)
		{
			int num = 1191459166;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x2088165Fu) % 39u)
				{
				case 37u:
					num = 1045926294;
					continue;
				case 36u:
					num = ((int)num2 * -134936960) ^ -240145593;
					continue;
				case 35u:
					num7 = 1f - num11 * 0.4f / (float)Form1.smethod_27(2.0);
					num8 = (float)size * (num7 / 2f);
					num = 1290350110;
					continue;
				case 34u:
					Form1.smethod_30((Control)(object)pictureBox1);
					num = (int)((num2 * 1174998432) ^ 0x6264B722);
					continue;
				case 33u:
					num = ((int)num2 * -1460415488) ^ -320619101;
					continue;
				case 32u:
					num10 = num9 * 0.4f / (float)Form1.smethod_27(2.0);
					num = (int)((num2 * 394311017) ^ 0x61DF6F91);
					continue;
				case 31u:
				{
					int num18;
					int num19;
					if (square)
					{
						num18 = 1423292952;
						num19 = 1423292952;
					}
					else
					{
						num18 = 1889380468;
						num19 = 1889380468;
					}
					num = num18 ^ ((int)num2 * -107089983);
					continue;
				}
				case 30u:
					point = board[num6, num5].Point;
					num = (int)(num2 * 61837) ^ -1981376494;
					continue;
				case 29u:
					num = (int)(num2 * 78440296) ^ -992789169;
					continue;
				case 28u:
					square = board[num6, num5].Square;
					num = ((int)num2 * -980757676) ^ 0x693A447A;
					continue;
				case 27u:
					num11 = 0.7f;
					num = 65323721;
					continue;
				case 26u:
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox1));
					num6 = 0;
					num = ((int)num2 * -188246306) ^ -163636654;
					continue;
				case 25u:
					num7 = 1f - num11 * 0.9f / (float)Form1.smethod_27(2.0);
					num9 = (float)size * num11;
					num = 1960217310;
					continue;
				case 24u:
					num = (int)(num2 * 1873027942) ^ -1982603665;
					continue;
				case 23u:
					num6++;
					num = ((int)num2 * -947899965) ^ -982615540;
					continue;
				case 22u:
					num5++;
					num = 1580867752;
					continue;
				case 21u:
				{
					int num22;
					if (num6 < 4)
					{
						num = 1197982201;
						num22 = 1197982201;
					}
					else
					{
						num = 216181231;
						num22 = 216181231;
					}
					continue;
				}
				case 20u:
					big = board[num6, num5].Big;
					num = 34693808;
					continue;
				case 19u:
					Form1.smethod_24(graphics_, (Brush)(object)Form1.smethod_29(Color.FromArgb(180, Color.Peru)), num8 + (float)(num5 * size), num8 + (float)(num6 * size), num10, num10);
					num = ((int)num2 * -227451495) ^ 0x38031B27;
					continue;
				case 18u:
					brush_ = Form1.smethod_26();
					num = 860998343;
					continue;
				case 17u:
					Form1.smethod_28(graphics_, brush_, num8 + (float)(num5 * size), num8 + (float)(num6 * size), num10, num10);
					num = (int)((num2 * 2025358041) ^ 0xBB9EE21);
					continue;
				case 16u:
					num = (int)(num2 * 2055839816) ^ -59644614;
					continue;
				case 15u:
					Form1.smethod_24(graphics_, Form1.smethod_23(), ((float)num5 + 0.05f) * (float)size, ((float)num6 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					flag2 = board[num6, num5] != null;
					num = 1361080341;
					continue;
				case 14u:
					brush_ = Form1.smethod_25();
					num = (int)((num2 * 921746100) ^ 0x772B0490);
					continue;
				case 13u:
					num = ((int)num2 * -1114029878) ^ 0x37765FC5;
					continue;
				case 12u:
				{
					int num20;
					int num21;
					if (dark)
					{
						num20 = 1664445902;
						num21 = 1664445902;
					}
					else
					{
						num20 = 899587558;
						num21 = 899587558;
					}
					num = num20 ^ ((int)num2 * -219746943);
					continue;
				}
				case 11u:
				{
					int num16;
					int num17;
					if (point)
					{
						num16 = 2098808701;
						num17 = 2098808701;
					}
					else
					{
						num16 = 1827622065;
						num17 = 1827622065;
					}
					num = num16 ^ (int)(num2 * 1882230749);
					continue;
				}
				case 10u:
				{
					int num14;
					int num15;
					if (flag2)
					{
						num14 = -1130025974;
						num15 = -1130025974;
					}
					else
					{
						num14 = -1037159912;
						num15 = -1037159912;
					}
					num = num14 ^ ((int)num2 * -1675455621);
					continue;
				}
				case 9u:
					num5 = 0;
					num = 1580867752;
					continue;
				case 8u:
				{
					int num12;
					int num13;
					if (!big)
					{
						num12 = 1092290094;
						num13 = 1092290094;
					}
					else
					{
						num12 = 246646554;
						num13 = 246646554;
					}
					num = num12 ^ ((int)num2 * -2082889380);
					continue;
				}
				case 7u:
					num = (int)(num2 * 1681710518) ^ -1556125880;
					continue;
				case 5u:
					Form1.smethod_24(graphics_, brush_, num8 + (float)(num5 * size), num8 + (float)(num6 * size), num10, num10);
					num = 651233602;
					continue;
				case 4u:
					dark = board[num6, num5].Dark;
					num = ((int)num2 * -1511075273) ^ 0x5979599A;
					continue;
				case 3u:
					num11 = 1f;
					num = (int)(num2 * 1059269449) ^ -2134235464;
					continue;
				case 2u:
					flag = num5 < 4;
					num = 606298093;
					continue;
				case 1u:
					num8 = (float)size * (num7 / 2f);
					num10 = num9 * 0.9f / (float)Form1.smethod_27(2.0);
					num = ((int)num2 * -1217066274) ^ -793269634;
					continue;
				case 0u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = 738843263;
						num4 = 738843263;
					}
					else
					{
						num3 = 2105852703;
						num4 = 2105852703;
					}
					num = num3 ^ ((int)num2 * -576126865);
					continue;
				}
				default:
					return;
				case 6u:
					break;
				case 38u:
					return;
				}
				break;
			}
		}
	}

	private void Paint_Storage()
	{
		int num = 0;
		bool dark = default(bool);
		int num4 = default(int);
		float num11 = default(float);
		Graphics graphics_ = default(Graphics);
		float num7 = default(float);
		float num10 = default(float);
		Brush brush_ = default(Brush);
		bool flag2 = default(bool);
		float num6 = default(float);
		bool flag = default(bool);
		float num9 = default(float);
		bool point = default(bool);
		while (true)
		{
			int num2 = 1093503664;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0x151D67ACu) % 38u)
				{
				case 37u:
				{
					int num17;
					int num18;
					if (dark)
					{
						num17 = 1541560332;
						num18 = 1541560332;
					}
					else
					{
						num17 = 1567438995;
						num18 = 1567438995;
					}
					num2 = num17 ^ ((int)num3 * -1361591571);
					continue;
				}
				case 36u:
					Form1.smethod_30((Control)(object)pictureBox[num, num4]);
					num2 = 431752873;
					continue;
				case 35u:
					num11 = 0.7f;
					num2 = 80730479;
					continue;
				case 34u:
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox[num, num4]));
					num2 = (int)(num3 * 367892093) ^ -207957219;
					continue;
				case 33u:
					num2 = ((int)num3 * -583681522) ^ 0x40B5CA2B;
					continue;
				case 32u:
					Form1.smethod_24(graphics_, (Brush)(object)Form1.smethod_29(Color.FromArgb(180, Color.Peru)), num7, num7, num10, num10);
					num2 = ((int)num3 * -1532247797) ^ -830885880;
					continue;
				case 31u:
					brush_ = Form1.smethod_25();
					num2 = (int)((num3 * 969562804) ^ 0x1D5D023F);
					continue;
				case 30u:
				{
					int num14;
					int num15;
					if (flag2)
					{
						num14 = 1258757405;
						num15 = 1258757405;
					}
					else
					{
						num14 = 1242900283;
						num15 = 1242900283;
					}
					num2 = num14 ^ (int)(num3 * 1330545815);
					continue;
				}
				case 29u:
				{
					int num8;
					if (num < 4)
					{
						num2 = 1211271143;
						num8 = 1211271143;
					}
					else
					{
						num2 = 1274777302;
						num8 = 1274777302;
					}
					continue;
				}
				case 28u:
					num7 = (float)size * (num6 / 2f) - 4f;
					num2 = (int)((num3 * 771309570) ^ 0xC5643C3);
					continue;
				case 27u:
				{
					int num19;
					int num20;
					if (!flag)
					{
						num19 = 767802564;
						num20 = 767802564;
					}
					else
					{
						num19 = 1593522622;
						num20 = 1593522622;
					}
					num2 = num19 ^ (int)(num3 * 1890461396);
					continue;
				}
				case 26u:
					num2 = ((int)num3 * -1299050912) ^ 0x599D5EEF;
					continue;
				case 25u:
					Form1.smethod_28(graphics_, brush_, num7, num7, num10, num10);
					num2 = ((int)num3 * -434701754) ^ -1481807476;
					continue;
				case 24u:
				{
					int num16;
					if (storage[num, num4] == null)
					{
						num2 = 1822767656;
						num16 = 1822767656;
					}
					else
					{
						num2 = 1847621130;
						num16 = 1847621130;
					}
					continue;
				}
				case 23u:
					Form1.smethod_20(pictureBox[num, num4], (Image)(object)Form1.smethod_19(Form1.smethod_18((Control)(object)pictureBox[num, num4]), Form1.smethod_16((Control)(object)pictureBox[num, num4])));
					num2 = (int)((num3 * 1054118390) ^ 0x72D778A6);
					continue;
				case 22u:
					num2 = ((int)num3 * -1812467053) ^ -1651377101;
					continue;
				case 21u:
					dark = storage[num, num4].Dark;
					num2 = (int)((num3 * 1302744885) ^ 0x2F8DAC8);
					continue;
				case 20u:
					num2 = ((int)num3 * -1273910292) ^ -627813871;
					continue;
				case 19u:
					num2 = ((int)num3 * -1174004727) ^ 0x6CC3CF05;
					continue;
				case 17u:
					num11 = 1f;
					num2 = (int)((num3 * 310462450) ^ 0x5C935722);
					continue;
				case 16u:
					num9 = (float)size * num11;
					num2 = ((int)num3 * -1912920318) ^ 0x79CBBA64;
					continue;
				case 15u:
					num6 = 1f - num11 * 0.9f / (float)Form1.smethod_27(2.0);
					num2 = 1078339450;
					continue;
				case 14u:
					brush_ = Form1.smethod_26();
					num2 = 2071336521;
					continue;
				case 13u:
					num4 = 0;
					num2 = 509835470;
					continue;
				case 12u:
				{
					int num12;
					int num13;
					if (point)
					{
						num12 = -459628980;
						num13 = -459628980;
					}
					else
					{
						num12 = -74038336;
						num13 = -74038336;
					}
					num2 = num12 ^ ((int)num3 * -865136242);
					continue;
				}
				case 11u:
					Form1.smethod_24(graphics_, brush_, num7, num7, num10, num10);
					num2 = 2015858338;
					continue;
				case 10u:
					num6 = 1f - num11 * 0.4f / (float)Form1.smethod_27(2.0);
					num2 = 891044886;
					continue;
				case 8u:
					num7 = (float)size * (num6 / 2f) - 4f;
					num10 = num9 * 0.4f / (float)Form1.smethod_27(2.0);
					num2 = (int)((num3 * 2101795430) ^ 0x2E13E305);
					continue;
				case 7u:
					num10 = num9 * 0.9f / (float)Form1.smethod_27(2.0);
					num2 = ((int)num3 * -828332671) ^ -449209245;
					continue;
				case 6u:
					num2 = ((int)num3 * -640108505) ^ -116486697;
					continue;
				case 5u:
				{
					int num5;
					if (!storage[num, num4].Big)
					{
						num2 = 29905381;
						num5 = 29905381;
					}
					else
					{
						num2 = 2056676857;
						num5 = 2056676857;
					}
					continue;
				}
				case 4u:
					flag2 = num4 < 2;
					num2 = ((int)num3 * -1359275694) ^ 0x50106068;
					continue;
				case 3u:
					point = storage[num, num4].Point;
					num2 = (int)(num3 * 473462963) ^ -1447480435;
					continue;
				case 2u:
					num++;
					num2 = ((int)num3 * -2123915728) ^ -320290349;
					continue;
				case 1u:
					flag = num4 < 4;
					num2 = 161305997;
					continue;
				case 0u:
					num4++;
					num2 = 237581897;
					continue;
				default:
					return;
				case 9u:
					break;
				case 18u:
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
		int num10 = default(int);
		int num9 = default(int);
		int num4 = default(int);
		bool flag = default(bool);
		while (true)
		{
			int num = 1418356844;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7F7E9A8Bu) % 24u)
				{
				case 23u:
				{
					int num7;
					int num8;
					if (!flag2)
					{
						num7 = -203613467;
						num8 = -203613467;
					}
					else
					{
						num7 = -1325929159;
						num8 = -1325929159;
					}
					num = num7 ^ (int)(num2 * 642853569);
					continue;
				}
				case 22u:
					Form1.smethod_32((Control)(object)richTextBox1, "Противник выбрал фигуру. Выберете поле на доске для установки этой фигуры.");
					num = ((int)num2 * -676306952) ^ 0x1084BA1F;
					continue;
				case 21u:
					num3 = 0;
					num = (int)((num2 * 702103926) ^ 0x578A8F2C);
					continue;
				case 20u:
					step = 1;
					num = ((int)num2 * -1741267743) ^ 0x4013B775;
					continue;
				case 19u:
				{
					int num11;
					if (num10 >= 4)
					{
						num = 1061156595;
						num11 = 1061156595;
					}
					else
					{
						num = 11702749;
						num11 = 11702749;
					}
					continue;
				}
				case 17u:
					num = (int)(num2 * 928914611) ^ -626931262;
					continue;
				case 16u:
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: true);
					num = ((int)num2 * -1804919964) ^ -614500771;
					continue;
				case 15u:
					step = 0;
					num = ((int)num2 * -1424006014) ^ -589930956;
					continue;
				case 14u:
					Form1.smethod_7((Control)(object)pictureBox[num3, num10], bool_0: true);
					num10++;
					num = 1794980792;
					continue;
				case 13u:
					Form1.smethod_5((Control)(object)borderBox[num9, num4], Color.Blue);
					num = ((int)num2 * -397313757) ^ -1037533092;
					continue;
				case 12u:
					flag2 = turn;
					num = ((int)num2 * -380157463) ^ 0x1A13B370;
					continue;
				case 11u:
					num10 = 0;
					num = 1794980792;
					continue;
				case 9u:
					num = 485303853;
					continue;
				case 8u:
					flag = num3 < 4;
					num = 2078908222;
					continue;
				case 7u:
					Form1_Load(this, Form1.smethod_31());
					num = (int)(num2 * 1563170187) ^ -1475057358;
					continue;
				case 6u:
					num9 = Form1.smethod_33(rnd, 4);
					num = ((int)num2 * -75414894) ^ -1039010820;
					continue;
				case 5u:
				{
					int num5;
					int num6;
					if (!flag)
					{
						num5 = -191246456;
						num6 = -191246456;
					}
					else
					{
						num5 = -1409714481;
						num6 = -1409714481;
					}
					num = num5 ^ (int)(num2 * 84519187);
					continue;
				}
				case 4u:
					Form1.smethod_32((Control)(object)richTextBox1, "Ваш ход. Выберете фигуру, которой будет играть противник.");
					num = ((int)num2 * -1841026030) ^ -1402586132;
					continue;
				case 3u:
					num4 = Form1.smethod_33(rnd, 4);
					num = ((int)num2 * -1493215320) ^ 0xE082EBE;
					continue;
				case 2u:
					Form1.smethod_32((Control)(object)label2, Form1.smethod_34("Ход: ", step.ToString()));
					time = new DateTime(0L, DateTimeKind.Unspecified);
					Form1.smethod_35(timer1, bool_0: true);
					num = 1060261769;
					continue;
				case 1u:
					num = ((int)num2 * -258914022) ^ 0xE61F411;
					continue;
				case 0u:
					num3++;
					num = (int)(num2 * 733251368) ^ -94754789;
					continue;
				case 18u:
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
			int num = 854644887;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x109E5436u) % 3u)
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
				num = (int)((num2 * 619176472) ^ 0x1072185D);
			}
		}
	}

	private void PictureBoxIJ_MouseDown(object sender, MouseEventArgs e)
	{
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Expected O, but got Unknown
		Point point = default(Point);
		int num5 = default(int);
		int num6 = default(int);
		int num3 = default(int);
		int num4 = default(int);
		bool flag = default(bool);
		while (true)
		{
			int num = -1469568213;
			while (true)
			{
				uint num2;
				int num9;
				switch ((num2 = (uint)num ^ 0xF6057DFCu) % 22u)
				{
				case 21u:
					point = Form1.smethod_37((Control)((sender is PictureBox) ? sender : null));
					num = ((int)num2 * -132712823) ^ -1259714938;
					continue;
				case 20u:
					num5 = 0;
					num = (int)((num2 * 859797501) ^ 0x42046DB9);
					continue;
				case 19u:
					Form1.smethod_7((Control)(object)button2, bool_0: true);
					Form1.smethod_32((Control)(object)richTextBox1, "Именно эта фигура? Если да - нажмите \"Подтвердить\".");
					num = ((int)num2 * -1004474945) ^ -1034374809;
					continue;
				case 18u:
					num = ((int)num2 * -1678977130) ^ 0x6F359507;
					continue;
				case 17u:
					num6 = 0;
					num = -1687671005;
					continue;
				case 16u:
					if (Form1.smethod_40((Bitmap)Form1.smethod_21(pictureBox[num3, num4]), Form1.smethod_38(e), Form1.smethod_39(e)) != Color.FromArgb(0, 0, 0, 0))
					{
						num = -1832255145;
						num9 = -1832255145;
						continue;
					}
					goto IL_00ce;
				case 15u:
					flag = num6 < 4;
					num = -1242824409;
					continue;
				case 14u:
					Form1.smethod_5((Control)(object)borderBox[num5, num6], Color.White);
					num = -1942606302;
					continue;
				case 13u:
					num = ((int)num2 * -1223330254) ^ 0xAA30ADE;
					continue;
				case 12u:
					Form1.smethod_5((Control)(object)borderBox[num3, num4], Color.Red);
					num = (int)(num2 * 1610698940) ^ -2046361017;
					continue;
				case 11u:
					num6++;
					num = ((int)num2 * -1457523355) ^ -1613097960;
					continue;
				case 10u:
					num4 -= 4;
					num = ((int)num2 * -491157936) ^ -378049099;
					continue;
				case 9u:
				{
					int num11;
					int num12;
					if (flag)
					{
						num11 = 1788622883;
						num12 = 1788622883;
					}
					else
					{
						num11 = 699816819;
						num12 = 699816819;
					}
					num = num11 ^ ((int)num2 * -883051311);
					continue;
				}
				case 8u:
					num5++;
					num = ((int)num2 * -1186452115) ^ -2059253127;
					continue;
				case 7u:
				{
					int num10;
					if (num5 < 4)
					{
						num = -1873429521;
						num10 = -1873429521;
					}
					else
					{
						num = -1057786692;
						num10 = -1057786692;
					}
					continue;
				}
				case 6u:
				{
					point = Form1.smethod_37((Control)((sender is PictureBox) ? sender : null));
					num4 = point.X / size;
					int num7;
					int num8;
					if (num4 > 1)
					{
						num7 = -1591566852;
						num8 = -1591566852;
					}
					else
					{
						num7 = -2128738635;
						num8 = -2128738635;
					}
					num = num7 ^ (int)(num2 * 403116612);
					continue;
				}
				case 5u:
					num3 = point.Y / size;
					num = ((int)num2 * -336135757) ^ 0x683651F3;
					continue;
				case 2u:
					num = ((int)num2 * -738543039) ^ 0x301E5DB0;
					continue;
				case 1u:
					if (storage[num3, num4] != null)
					{
						num = -2142969756;
						continue;
					}
					goto IL_00ce;
				case 0u:
					num = (int)((num2 * 137226801) ^ 0x1F5BB09D);
					continue;
				default:
					return;
				case 4u:
					break;
				case 3u:
					return;
					IL_00ce:
					num = -1913478645;
					num9 = -1913478645;
					continue;
				}
				break;
			}
		}
	}

	private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
	{
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ec: Expected O, but got Unknown
		bool flag3 = default(bool);
		int num3 = default(int);
		bool flag2 = default(bool);
		int num5 = default(int);
		int num10 = default(int);
		bool flag = default(bool);
		bool flag4 = default(bool);
		Graphics graphics_ = default(Graphics);
		int num4 = default(int);
		while (true)
		{
			int num = -464564866;
			while (true)
			{
				uint num2;
				int num11;
				switch ((num2 = (uint)num ^ 0xEAB097C3u) % 25u)
				{
				case 23u:
				{
					int num8;
					int num9;
					if (!flag3)
					{
						num8 = -703470934;
						num9 = -703470934;
					}
					else
					{
						num8 = -1920443059;
						num9 = -1920443059;
					}
					num = num8 ^ (int)(num2 * 1478495615);
					continue;
				}
				case 22u:
					Form1.smethod_30((Control)(object)pictureBox1);
					Form1.smethod_7((Control)(object)button2, bool_0: true);
					num = ((int)num2 * -20787629) ^ -394313032;
					continue;
				case 21u:
					num3++;
					num = ((int)num2 * -1935617378) ^ 0x2C0617FC;
					continue;
				case 20u:
					flag2 = Form1.smethod_41((Control)(object)borderBox[num3, num5]) == Color.Blue;
					num = -7824050;
					continue;
				case 19u:
					num = (int)((num2 * 1576889365) ^ 0x244D9676);
					continue;
				case 18u:
					num10 = Form1.smethod_39(e) / size;
					num = ((int)num2 * -1612826882) ^ 0x74E31AEC;
					continue;
				case 17u:
					num = (int)((num2 * 627744953) ^ 0x4B5A35EA);
					continue;
				case 16u:
					Form1.smethod_32((Control)(object)richTextBox1, "Уверены? Для выполнения данного хода нажмите \"Подтвердить\".");
					num = ((int)num2 * -2003517450) ^ -741820166;
					continue;
				case 15u:
				{
					int num14;
					int num15;
					if (!flag)
					{
						num14 = -1684142787;
						num15 = -1684142787;
					}
					else
					{
						num14 = -247239917;
						num15 = -247239917;
					}
					num = num14 ^ ((int)num2 * -1445130401);
					continue;
				}
				case 13u:
				{
					int num12;
					int num13;
					if (flag4)
					{
						num12 = 187083417;
						num13 = 187083417;
					}
					else
					{
						num12 = 1775450275;
						num13 = 1775450275;
					}
					num = num12 ^ (int)(num2 * 1798398522);
					continue;
				}
				case 12u:
					Form1.smethod_44(graphics_, Form1.smethod_21(pictureBox[num3, num5]), num4 * size + 4, num10 * size + 4, new Rectangle(0, 0, size, size), (GraphicsUnit)2);
					Form1.smethod_45(graphics_);
					num = ((int)num2 * -1692399069) ^ 0x214547C;
					continue;
				case 11u:
					num11 = ((board[num10, num4] == null) ? 1 : 0);
					goto IL_01c0;
				case 10u:
					if (Form1.smethod_40((Bitmap)Form1.smethod_21(pictureBox1), Form1.smethod_38(e), Form1.smethod_39(e)) != Color.FromArgb(0, 0, 0, 0))
					{
						num = ((int)num2 * -1777577626) ^ 0x3A989AC6;
						continue;
					}
					num11 = 0;
					goto IL_01c0;
				case 9u:
					Paint_Board();
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox1));
					Form1.smethod_43(graphics_, Form1.smethod_42(Color.Red, 3f), ((float)num4 + 0.05f) * (float)size, ((float)num10 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					num = (int)(num2 * 1494812344) ^ -1978551179;
					continue;
				case 8u:
					num = ((int)num2 * -565101623) ^ -1878529298;
					continue;
				case 7u:
					num5++;
					num = -1786519748;
					continue;
				case 6u:
					num = ((int)num2 * -428777496) ^ -2044572856;
					continue;
				case 5u:
					flag4 = num5 < 4;
					num = -520137781;
					continue;
				case 4u:
					num3 = 0;
					num = ((int)num2 * -1389740065) ^ 0x6EDE473D;
					continue;
				case 3u:
				{
					int num6;
					int num7;
					if (!flag2)
					{
						num6 = -211729606;
						num7 = -211729606;
					}
					else
					{
						num6 = -243644660;
						num7 = -243644660;
					}
					num = num6 ^ (int)(num2 * 1917963571);
					continue;
				}
				case 2u:
					num5 = 0;
					num = -1786519748;
					continue;
				case 1u:
					num4 = Form1.smethod_38(e) / size;
					num = ((int)num2 * -1316222376) ^ -722310951;
					continue;
				case 0u:
					flag = num3 < 4;
					num = -1205195104;
					continue;
				default:
					return;
				case 24u:
					break;
				case 14u:
					return;
					IL_01c0:
					flag3 = (byte)num11 != 0;
					num = -1539056107;
					continue;
				}
				break;
			}
		}
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		int num18 = default(int);
		int num28 = default(int);
		int num33 = default(int);
		Figurine[,] array3 = default(Figurine[,]);
		int num15 = default(int);
		int num42 = default(int);
		bool flag = default(bool);
		bool flag10 = default(bool);
		int num16 = default(int);
		bool flag6 = default(bool);
		int num38 = default(int);
		int num25 = default(int);
		int num29 = default(int);
		int num5 = default(int);
		int num22 = default(int);
		bool flag3 = default(bool);
		int num24 = default(int);
		bool flag11 = default(bool);
		int num20 = default(int);
		Graphics graphics_ = default(Graphics);
		bool flag8 = default(bool);
		int num3 = default(int);
		int num4 = default(int);
		int num34 = default(int);
		int num30 = default(int);
		int num19 = default(int);
		bool flag4 = default(bool);
		int num10 = default(int);
		bool flag2 = default(bool);
		int num6 = default(int);
		int num7 = default(int);
		Figurine[,] array = default(Figurine[,]);
		Figurine[,] array2 = default(Figurine[,]);
		bool flag9 = default(bool);
		bool flag7 = default(bool);
		bool flag5 = default(bool);
		while (true)
		{
			int num = -510273062;
			while (true)
			{
				uint num2;
				int num52;
				int num35;
				int num23;
				int num43;
				switch ((num2 = (uint)num ^ 0xD58731AEu) % 158u)
				{
				case 157u:
					num18 = num28;
					num = (int)((num2 * 1275919783) ^ 0x1F86ADD8);
					continue;
				case 156u:
					num = (int)(num2 * 2048577257) ^ -1027628722;
					continue;
				case 155u:
					num = ((int)num2 * -596900799) ^ -994076760;
					continue;
				case 154u:
					num33++;
					num = -821308400;
					continue;
				case 153u:
					if (!Standoff(array3))
					{
						num = -720544048;
						num52 = -720544048;
						continue;
					}
					goto IL_005c;
				case 152u:
					num = -1528683966;
					continue;
				case 151u:
				{
					int num41;
					if (Form1.smethod_40((Bitmap)Form1.smethod_21(pictureBox1), num15 * size + size / 2, (int)(((float)num28 + 0.05f) * (float)size)) == Color.FromArgb(255, 255, 0, 0))
					{
						num = -1887729441;
						num41 = -1887729441;
					}
					else
					{
						num = -960192264;
						num41 = -960192264;
					}
					continue;
				}
				case 150u:
					num = -2058935939;
					continue;
				case 149u:
					num15 = 0;
					num = -1643577860;
					continue;
				case 148u:
					num = -521088420;
					continue;
				case 147u:
					Form1.smethod_32((Control)(object)richTextBox1, "Противник сделал ход (зелёный). Выберете поле на доске для выбронной противником фигуры (синий).");
					num = (int)(num2 * 1056135741) ^ -1666148990;
					continue;
				case 146u:
					num = (int)((num2 * 1167521381) ^ 0x280A2EE5);
					continue;
				case 145u:
					num42++;
					flag = false;
					num = ((int)num2 * -1488149703) ^ 0x1FD52CC7;
					continue;
				case 144u:
					num = ((int)num2 * -1447555421) ^ -321420858;
					continue;
				case 143u:
					flag10 = num28 < 4;
					num = -1558654535;
					continue;
				case 142u:
					num16 = 0;
					num = -1738184937;
					continue;
				case 141u:
					num35 = ((!Standoff(board)) ? 1 : 0);
					goto IL_01a2;
				case 140u:
					array3 = (Figurine[,])Form1.smethod_48((Array)board);
					num = (int)(num2 * 407622264) ^ -800422443;
					continue;
				case 139u:
				{
					int num57;
					int num58;
					if (!flag6)
					{
						num57 = -130667966;
						num58 = -130667966;
					}
					else
					{
						num57 = -1071851084;
						num58 = -1071851084;
					}
					num = num57 ^ ((int)num2 * -694141540);
					continue;
				}
				case 138u:
					num38++;
					num = ((int)num2 * -1148863233) ^ -499085043;
					continue;
				case 137u:
					num = -1335594347;
					continue;
				case 136u:
					Form1.smethod_47(1000);
					num = ((int)num2 * -1875834690) ^ 0x67CB76FF;
					continue;
				case 135u:
					num16++;
					num = -1738184937;
					continue;
				case 134u:
					num25++;
					num = (int)(num2 * 1501082359) ^ -1595670242;
					continue;
				case 133u:
					num29 = 0;
					num = ((int)num2 * -5897490) ^ 0xFB03E68;
					continue;
				case 132u:
					Form1.smethod_5((Control)(object)borderBox[num5, num22], Color.Blue);
					Form1.smethod_30((Control)(object)borderBox[num5, num22]);
					num = (int)(num2 * 25232571) ^ -472029139;
					continue;
				case 131u:
					Form1.smethod_32((Control)(object)richTextBox1, "QUARTO! Компьютер выиграл!");
					num = -1168360666;
					continue;
				case 130u:
				{
					int num49;
					int num50;
					if (!flag3)
					{
						num49 = 394539394;
						num50 = 394539394;
					}
					else
					{
						num49 = 873546206;
						num50 = 873546206;
					}
					num = num49 ^ ((int)num2 * -544093126);
					continue;
				}
				case 129u:
					num24++;
					num = ((int)num2 * -287389592) ^ -11795021;
					continue;
				case 128u:
					flag11 = num33 < 4;
					num = -807846366;
					continue;
				case 126u:
					num = (int)((num2 * 104069982) ^ 0x3990B575);
					continue;
				case 125u:
					num = (int)((num2 * 857777923) ^ 0x6F892E9);
					continue;
				case 124u:
					num20++;
					num = (int)(num2 * 1545245584) ^ -579215276;
					continue;
				case 123u:
					Form1.smethod_43(graphics_, Form1.smethod_42(Color.LimeGreen, 3f), ((float)num16 + 0.05f) * (float)size, ((float)num38 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					num = (int)((num2 * 1975369581) ^ 0x54776A6E);
					continue;
				case 122u:
					num = (int)(num2 * 379449842) ^ -289706989;
					continue;
				case 121u:
					Form1.smethod_30((Control)(object)borderBox[num28, num15]);
					Form1.smethod_20(pictureBox[num28, num15], (Image)null);
					num = ((int)num2 * -891098045) ^ 0x53245665;
					continue;
				case 120u:
				{
					int num36;
					int num37;
					if (!flag8)
					{
						num36 = -12770906;
						num37 = -12770906;
					}
					else
					{
						num36 = -858168746;
						num37 = -858168746;
					}
					num = num36 ^ (int)(num2 * 783155997);
					continue;
				}
				case 119u:
					num = ((int)num2 * -420326942) ^ 0x13956327;
					continue;
				case 118u:
					num33 = 0;
					num = -821308400;
					continue;
				case 117u:
					Form1.smethod_5((Control)(object)borderBox[num3, num4], Color.White);
					num = ((int)num2 * -574553312) ^ -378123085;
					continue;
				case 116u:
					num34 = 0;
					num = -540652065;
					continue;
				case 115u:
					num = ((int)num2 * -1394164406) ^ -743552472;
					continue;
				case 114u:
					num = (int)((num2 * 1202493002) ^ 0x30EA5002);
					continue;
				case 113u:
					num29 = num28;
					num30 = num15;
					Form1.smethod_5((Control)(object)borderBox[num28, num15], Color.White);
					num = ((int)num2 * -1230945598) ^ -944670784;
					continue;
				case 112u:
					num23 = ((num22 == num4) ? 1 : 0);
					goto IL_04f9;
				case 111u:
					num18 = 0;
					num19 = 0;
					num = ((int)num2 * -1497341349) ^ -1409670021;
					continue;
				case 110u:
					num = ((int)num2 * -1025879001) ^ 0xC38FAA2;
					continue;
				case 109u:
				{
					int num11;
					int num12;
					if (!flag4)
					{
						num11 = -1188679689;
						num12 = -1188679689;
					}
					else
					{
						num11 = -531065009;
						num12 = -531065009;
					}
					num = num11 ^ (int)(num2 * 1063767624);
					continue;
				}
				case 108u:
					flag3 = num10 < 4;
					num = -1377763936;
					continue;
				case 107u:
					num = ((int)num2 * -651820492) ^ -1616528429;
					continue;
				case 106u:
					Form1.smethod_30((Control)(object)pictureBox1);
					Form1.smethod_47(200);
					num = (int)(num2 * 2086032275) ^ -101226141;
					continue;
				case 105u:
					num = ((int)num2 * -656416827) ^ 0x637CBCF7;
					continue;
				case 104u:
				{
					int num61;
					int num62;
					if (!flag11)
					{
						num61 = 402171644;
						num62 = 402171644;
					}
					else
					{
						num61 = 119042578;
						num62 = 119042578;
					}
					num = num61 ^ ((int)num2 * -485082545);
					continue;
				}
				case 103u:
				{
					int num60;
					if (Standoff(board))
					{
						num = -1427933783;
						num60 = -1427933783;
					}
					else
					{
						num = -1322067564;
						num60 = -1322067564;
					}
					continue;
				}
				case 102u:
					num = (int)(num2 * 332759659) ^ -443204322;
					continue;
				case 101u:
					(menu as Form3).ContinueLock();
					num = ((int)num2 * -1983018600) ^ 0x594F2196;
					continue;
				case 100u:
				{
					int num59;
					if (num15 >= 4)
					{
						num = -101388943;
						num59 = -101388943;
					}
					else
					{
						num = -261141615;
						num59 = -261141615;
					}
					continue;
				}
				case 99u:
					num = (int)((num2 * 225322689) ^ 0x1612187);
					continue;
				case 98u:
					num = (int)(num2 * 1920965146) ^ -1685820245;
					continue;
				case 97u:
					num34++;
					num = -57344027;
					continue;
				case 96u:
					Form1.smethod_15(timer1);
					num = -53412383;
					continue;
				case 95u:
					Form1.smethod_32((Control)(object)richTextBox1, "Подождите, компьютер делает свой ход.");
					num = (int)(num2 * 1657625930) ^ -362607508;
					continue;
				case 94u:
					storage[num3, num4] = null;
					num = (int)((num2 * 581534744) ^ 0x4BEE72F6);
					continue;
				case 93u:
					array3[num38, num16] = new Figurine(storage[num3, num4]);
					if (!Stop(array3))
					{
						num = ((int)num2 * -1335377597) ^ 0x659BBB98;
						continue;
					}
					goto IL_005c;
				case 92u:
					num10 = 0;
					num = ((int)num2 * -1945110827) ^ 0x171DAB60;
					continue;
				case 91u:
					Form1.smethod_30((Control)(object)pictureBox1);
					num = (int)(num2 * 183669148) ^ -1985774354;
					continue;
				case 90u:
					if (num5 == num3)
					{
						num = ((int)num2 * -1892840683) ^ -1203016756;
						continue;
					}
					num23 = 0;
					goto IL_04f9;
				case 89u:
					num42 = 0;
					num = ((int)num2 * -1088712296) ^ 0x12D89475;
					continue;
				case 88u:
					Form1.smethod_30((Control)(object)richTextBox1);
					num = ((int)num2 * -113122065) ^ 0x2BF71863;
					continue;
				case 87u:
					num = ((int)num2 * -1111070349) ^ 0x7FC1C9C9;
					continue;
				case 86u:
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: true);
					num = (int)((num2 * 707393449) ^ 0x101A3B9);
					continue;
				case 85u:
					flag2 = board[num6, num7] != null;
					num = ((int)num2 * -735076476) ^ -886639217;
					continue;
				case 83u:
				{
					int num56;
					if (num34 < 4)
					{
						num = -470142878;
						num56 = -470142878;
					}
					else
					{
						num = -288290924;
						num56 = -288290924;
					}
					continue;
				}
				case 82u:
					step++;
					Form1.smethod_32((Control)(object)label2, Form1.smethod_34("Ход: ", step.ToString()));
					num = -1577891726;
					continue;
				case 81u:
					num = ((int)num2 * -1935006237) ^ -1779769738;
					continue;
				case 80u:
				{
					int num55;
					if (num25 < 4)
					{
						num = -1795487829;
						num55 = -1795487829;
					}
					else
					{
						num = -722530907;
						num55 = -722530907;
					}
					continue;
				}
				case 79u:
					if (!flag)
					{
						num = ((int)num2 * -1972648725) ^ -281458882;
						continue;
					}
					num43 = 1;
					goto IL_08c0;
				case 78u:
					num30 = 0;
					num = ((int)num2 * -856012494) ^ 0x515C8B8D;
					continue;
				case 77u:
				{
					int num54;
					if (board[num38, num16] != null)
					{
						num = -2058935939;
						num54 = -2058935939;
					}
					else
					{
						num = -769020496;
						num54 = -769020496;
					}
					continue;
				}
				case 76u:
					num = (int)((num2 * 446198321) ^ 0x692C57D6);
					continue;
				case 75u:
				{
					int num53;
					if (num38 < 4)
					{
						num = -2009702064;
						num53 = -2009702064;
					}
					else
					{
						num = -722128907;
						num53 = -722128907;
					}
					continue;
				}
				case 74u:
					Form1.smethod_30((Control)(object)pictureBox[num28, num15]);
					num = ((int)num2 * -504876057) ^ 0x4FB4C229;
					continue;
				case 73u:
					num19 = num15;
					num = (int)((num2 * 914906382) ^ 0x751BFB7F);
					continue;
				case 72u:
					num = -489775981;
					continue;
				case 71u:
					Form1.smethod_32((Control)(object)richTextBox1, "Ничья!");
					num = ((int)num2 * -146481538) ^ -1808086551;
					continue;
				case 70u:
					board[num18, num19] = new Figurine(storage[num29, num30]);
					num = ((int)num2 * -975133513) ^ 0x43DE8316;
					continue;
				case 69u:
				{
					int num51;
					if (num24 >= 4)
					{
						num = -152422803;
						num51 = -152422803;
					}
					else
					{
						num = -1576131831;
						num51 = -1576131831;
					}
					continue;
				}
				case 68u:
				{
					int num48;
					if (array[num20, num33] != null)
					{
						num = -1153906542;
						num48 = -1153906542;
					}
					else
					{
						num = -895868272;
						num48 = -895868272;
					}
					continue;
				}
				case 67u:
					Form1.smethod_32((Control)(object)richTextBox1, "Ничья!");
					num = ((int)num2 * -541649980) ^ 0x61F13B53;
					continue;
				case 66u:
					num3 = num10;
					num4 = num34;
					num = ((int)num2 * -1899127530) ^ -1635020149;
					continue;
				case 65u:
				{
					int num46;
					int num47;
					if (flag10)
					{
						num46 = 483341925;
						num47 = 483341925;
					}
					else
					{
						num46 = 84394986;
						num47 = 84394986;
					}
					num = num46 ^ (int)(num2 * 1716418692);
					continue;
				}
				case 64u:
					num = (int)(num2 * 1273990463) ^ -344675027;
					continue;
				case 63u:
					num22 = Form1.smethod_33(rnd, 4);
					if (storage[num5, num22] != null)
					{
						num = ((int)num2 * -437892621) ^ -830735241;
						continue;
					}
					num23 = 1;
					goto IL_04f9;
				case 62u:
					num20 = 0;
					num = ((int)num2 * -632847157) ^ 0x4670B27A;
					continue;
				case 61u:
					num = (int)((num2 * 286943265) ^ 0x5003C092);
					continue;
				case 60u:
					num = -2054212601;
					continue;
				case 59u:
					num = (int)((num2 * 348322010) ^ 0x174B0865);
					continue;
				case 58u:
					num4 = 0;
					num = ((int)num2 * -103009581) ^ 0x7B1D03FE;
					continue;
				case 57u:
					num15++;
					num = ((int)num2 * -1396915182) ^ -418827234;
					continue;
				case 56u:
					num = ((int)num2 * -1744337172) ^ -19606701;
					continue;
				case 55u:
					num3 = 0;
					num = (int)((num2 * 2118227323) ^ 0x8FBD533);
					continue;
				case 54u:
					num = -1153906542;
					continue;
				case 53u:
					num = (int)(num2 * 1941541340) ^ -1920717792;
					continue;
				case 52u:
					num28 = 0;
					num = ((int)num2 * -334897341) ^ -1177819584;
					continue;
				case 51u:
				{
					array2[num20, num33] = new Figurine(storage[num5, num22]);
					int num44;
					int num45;
					if (!Stop(array2))
					{
						num44 = 336299632;
						num45 = 336299632;
					}
					else
					{
						num44 = 462795668;
						num45 = 462795668;
					}
					num = num44 ^ ((int)num2 * -756438856);
					continue;
				}
				case 50u:
					num = (int)(num2 * 922114567) ^ -208698799;
					continue;
				case 49u:
					num43 = ((num42 < 9) ? 1 : 0);
					goto IL_08c0;
				case 48u:
					Form1.smethod_30((Control)(object)pictureBox[num3, num4]);
					num = (int)((num2 * 1580248973) ^ 0x635022A);
					continue;
				case 47u:
					num24 = 0;
					num = (int)((num2 * 242247334) ^ 0x26A5894);
					continue;
				case 46u:
					Form1.smethod_47(200);
					Form1.smethod_5((Control)(object)borderBox[num3, num4], Color.White);
					Form1.smethod_30((Control)(object)borderBox[num3, num4]);
					Form1.smethod_20(pictureBox[num3, num4], (Image)null);
					num = ((int)num2 * -1113095279) ^ 0x21580A25;
					continue;
				case 45u:
					(menu as Form3).ContinueLock();
					num = (int)((num2 * 989807961) ^ 0x164F14E8);
					continue;
				case 44u:
					array = (Figurine[,])Form1.smethod_48((Array)board);
					num = (int)(num2 * 1507307573) ^ -2020481125;
					continue;
				case 43u:
					board[num38, num16] = new Figurine(storage[num3, num4]);
					num = ((int)num2 * -1405741744) ^ -2073944004;
					continue;
				case 42u:
					storage[num29, num30] = null;
					Paint_Board();
					num = ((int)num2 * -1940308875) ^ -1337399984;
					continue;
				case 41u:
					num = (int)((num2 * 1802321702) ^ 0x7B498F57);
					continue;
				case 40u:
				{
					int num39;
					int num40;
					if (!flag9)
					{
						num39 = 1585801995;
						num40 = 1585801995;
					}
					else
					{
						num39 = 952006834;
						num40 = 952006834;
					}
					num = num39 ^ (int)(num2 * 1881727393);
					continue;
				}
				case 39u:
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox1));
					num38 = 0;
					num = ((int)num2 * -790770170) ^ -1097542722;
					continue;
				case 38u:
					num7 = Form1.smethod_33(rnd, 4);
					num = (int)(num2 * 240568126) ^ -250228500;
					continue;
				case 37u:
					num = (int)(num2 * 998416454) ^ -2069389640;
					continue;
				case 36u:
					Form1.smethod_7((Control)(object)pictureBox[num10, num34], bool_0: false);
					flag9 = Form1.smethod_41((Control)(object)borderBox[num10, num34]) == Color.Red;
					num = -1709257954;
					continue;
				case 35u:
					num28++;
					num = ((int)num2 * -973917271) ^ 0x6AFCD24C;
					continue;
				case 34u:
					storage[num3, num4] = null;
					flag4 = Standoff(board);
					num = ((int)num2 * -2053526029) ^ 0x1A96F7EF;
					continue;
				case 33u:
					Form1.smethod_44(graphics_, Form1.smethod_21(pictureBox[num3, num4]), num16 * size + 4, num38 * size + 4, new Rectangle(0, 0, size, size), (GraphicsUnit)2);
					num = ((int)num2 * -1814372452) ^ -720937995;
					continue;
				case 32u:
					num = (int)((num2 * 526125357) ^ 0x4531DEE5);
					continue;
				case 31u:
					num25 = 0;
					num = -1452677738;
					continue;
				case 30u:
					array2 = (Figurine[,])Form1.smethod_48((Array)array);
					num = (int)(num2 * 393115376) ^ -1845182803;
					continue;
				case 29u:
					Form1.smethod_44(graphics_, Form1.smethod_21(pictureBox[num3, num4]), num7 * size + 4, num6 * size + 4, new Rectangle(0, 0, size, size), (GraphicsUnit)2);
					num = (int)(num2 * 1149807) ^ -501768941;
					continue;
				case 28u:
					num = ((int)num2 * -1491269986) ^ 0x4AE7B7F7;
					continue;
				case 27u:
					Form1.smethod_15(timer1);
					num = (int)(num2 * 2001739738) ^ -997774531;
					continue;
				case 26u:
					if (!Stop(board))
					{
						num = (int)((num2 * 868454975) ^ 0xA34CAED);
						continue;
					}
					num35 = 0;
					goto IL_01a2;
				case 25u:
					Form1.smethod_30((Control)(object)label2);
					num = (int)((num2 * 1170245339) ^ 0xA8D1CBB);
					continue;
				case 24u:
					Form1.smethod_7((Control)(object)button2, bool_0: false);
					flag8 = Form1.smethod_46((Control)(object)pictureBox1);
					num = ((int)num2 * -467007633) ^ 0x4248350C;
					continue;
				case 23u:
					Form1.smethod_20(pictureBox[num3, num4], (Image)null);
					num = ((int)num2 * -550386657) ^ 0x24B777BC;
					continue;
				case 22u:
					Form1.smethod_5((Control)(object)borderBox[num10, num34], Color.LimeGreen);
					Form1.smethod_30((Control)(object)borderBox[num10, num34]);
					num = (int)(num2 * 2050715806) ^ -390285364;
					continue;
				case 21u:
				{
					int num31;
					int num32;
					if (Form1.smethod_41((Control)(object)borderBox[num28, num15]) == Color.Blue)
					{
						num31 = 39455605;
						num32 = 39455605;
					}
					else
					{
						num31 = 349042862;
						num32 = 349042862;
					}
					num = num31 ^ ((int)num2 * -868153611);
					continue;
				}
				case 20u:
					num10++;
					num = ((int)num2 * -1440227367) ^ -1705186800;
					continue;
				case 19u:
					step++;
					Form1.smethod_32((Control)(object)label2, Form1.smethod_34("Ход: ", step.ToString()));
					num = (int)((num2 * 2008365539) ^ 0x4CE02B2A);
					continue;
				case 18u:
					Form1.smethod_43(graphics_, Form1.smethod_42(Color.LimeGreen, 3f), ((float)num7 + 0.05f) * (float)size, ((float)num6 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					num = (int)((num2 * 1770690948) ^ 0x2DE7E471);
					continue;
				case 17u:
					num = ((int)num2 * -290553028) ^ -271627726;
					continue;
				case 16u:
					num = ((int)num2 * -1803949128) ^ -1033192402;
					continue;
				case 15u:
					num = -1204479187;
					continue;
				case 14u:
				{
					int num26;
					int num27;
					if (flag7)
					{
						num26 = 1003899423;
						num27 = 1003899423;
					}
					else
					{
						num26 = 1347019591;
						num27 = 1347019591;
					}
					num = num26 ^ (int)(num2 * 1721983835);
					continue;
				}
				case 13u:
					Form1.smethod_7((Control)(object)pictureBox[num24, num25], bool_0: true);
					num = -1323863509;
					continue;
				case 12u:
				{
					int num21;
					if (num20 < 4)
					{
						num = -413457514;
						num21 = -413457514;
					}
					else
					{
						num = -1400974614;
						num21 = -1400974614;
					}
					continue;
				}
				case 11u:
					Form1.smethod_30((Control)(object)pictureBox[num3, num4]);
					num = (int)((num2 * 1473212917) ^ 0x2FA446A);
					continue;
				case 10u:
					board[num6, num7] = new Figurine(storage[num3, num4]);
					num = (int)((num2 * 789445742) ^ 0x6D32786E);
					continue;
				case 9u:
				{
					int num17;
					if (num16 >= 4)
					{
						num = -2050640120;
						num17 = -2050640120;
					}
					else
					{
						num = -1828661859;
						num17 = -1828661859;
					}
					continue;
				}
				case 8u:
				{
					int num13;
					int num14;
					if (flag5)
					{
						num13 = 87659237;
						num14 = 87659237;
					}
					else
					{
						num13 = 230098032;
						num14 = 230098032;
					}
					num = num13 ^ ((int)num2 * -2022342743);
					continue;
				}
				case 7u:
				{
					int num8;
					int num9;
					if (flag2)
					{
						num8 = 781743484;
						num9 = 781743484;
					}
					else
					{
						num8 = 703051304;
						num9 = 703051304;
					}
					num = num8 ^ (int)(num2 * 2093245776);
					continue;
				}
				case 6u:
					num6 = Form1.smethod_33(rnd, 4);
					num = -1216213158;
					continue;
				case 5u:
					array[num6, num7] = new Figurine(storage[num3, num4]);
					num = ((int)num2 * -1531770318) ^ -1364085474;
					continue;
				case 4u:
					num5 = Form1.smethod_33(rnd, 4);
					num = (int)(num2 * 142326909) ^ -2052038975;
					continue;
				case 3u:
					Form1.smethod_32((Control)(object)richTextBox1, "Выберете фигуру, которой будет играть противник.");
					num = (int)(num2 * 1502767319) ^ -1304352837;
					continue;
				case 2u:
					flag = true;
					num = ((int)num2 * -1777939673) ^ 0x1893FAE6;
					continue;
				case 1u:
					Form1.smethod_30((Control)(object)borderBox[num3, num4]);
					num = ((int)num2 * -920156850) ^ 0xDF50B69;
					continue;
				case 0u:
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: false);
					num = ((int)num2 * -856532997) ^ 0x47937B5B;
					continue;
				default:
					return;
				case 127u:
					break;
				case 84u:
					return;
					IL_04f9:
					flag6 = (byte)num23 != 0;
					num = -380915157;
					continue;
					IL_08c0:
					flag5 = (byte)num43 != 0;
					num = -1782822794;
					continue;
					IL_005c:
					num = -2083620533;
					num52 = -2083620533;
					continue;
					IL_01a2:
					flag7 = (byte)num35 != 0;
					num = -1251477898;
					continue;
				}
				break;
			}
		}
	}

	private bool Stop(Figurine[,] mem)
	{
		bool flag = false;
		int num = 0;
		bool flag2 = default(bool);
		bool flag3 = default(bool);
		bool result = default(bool);
		while (true)
		{
			int num2;
			int num3;
			if (num < 4)
			{
				num2 = -1675458354;
				num3 = -1675458354;
			}
			else
			{
				num2 = -1468634423;
				num3 = -1468634423;
			}
			while (true)
			{
				uint num4;
				int num17;
				int num22;
				switch ((num4 = (uint)num2 ^ 0xDF06573Cu) % 74u)
				{
				case 73u:
				{
					int num52;
					int num53;
					if (mem[1, num].Big == mem[2, num].Big)
					{
						num52 = 215658103;
						num53 = 215658103;
					}
					else
					{
						num52 = 859086742;
						num53 = 859086742;
					}
					num2 = num52 ^ (int)(num4 * 566560298);
					continue;
				}
				case 72u:
				{
					int num16;
					if (mem[0, num].Dark == mem[1, num].Dark)
					{
						num2 = -105158145;
						num16 = -105158145;
					}
					else
					{
						num2 = -1097686177;
						num16 = -1097686177;
					}
					continue;
				}
				case 71u:
					num++;
					num2 = -965861867;
					continue;
				case 70u:
					if (mem[2, num] != null)
					{
						num2 = (int)(num4 * 1217249350) ^ -837786193;
						continue;
					}
					goto IL_00bd;
				case 69u:
				{
					int num59;
					int num60;
					if (mem[num, 1] != null)
					{
						num59 = -1742198587;
						num60 = -1742198587;
					}
					else
					{
						num59 = -2113638642;
						num60 = -2113638642;
					}
					num2 = num59 ^ ((int)num4 * -321898358);
					continue;
				}
				case 68u:
				{
					int num39;
					int num40;
					if (mem[1, num].Point != mem[2, num].Point)
					{
						num39 = -1688132258;
						num40 = -1688132258;
					}
					else
					{
						num39 = -2069131601;
						num40 = -2069131601;
					}
					num2 = num39 ^ (int)(num4 * 1387413668);
					continue;
				}
				case 67u:
					if (mem[1, 2].Square == mem[2, 1].Square)
					{
						num2 = ((int)num4 * -1675091005) ^ 0x3B4BAF80;
						continue;
					}
					goto IL_0168;
				case 65u:
				{
					int num68;
					if (mem[0, 0].Point != mem[1, 1].Point)
					{
						num2 = -1261819682;
						num68 = -1261819682;
					}
					else
					{
						num2 = -1970938005;
						num68 = -1970938005;
					}
					continue;
				}
				case 64u:
				{
					int num55;
					int num56;
					if (!flag2)
					{
						num55 = 708206581;
						num56 = 708206581;
					}
					else
					{
						num55 = 977745309;
						num56 = 977745309;
					}
					num2 = num55 ^ (int)(num4 * 753131504);
					continue;
				}
				case 63u:
					if (mem[2, num].Big != mem[3, num].Big)
					{
						num2 = (int)((num4 * 1316051484) ^ 0x238AFB90);
						continue;
					}
					goto IL_0204;
				case 62u:
					if (mem[0, 3].Square == mem[1, 2].Square)
					{
						num2 = -1351511511;
						continue;
					}
					goto IL_0168;
				case 61u:
					if (mem[2, 2].Point != mem[3, 3].Point)
					{
						num2 = (int)((num4 * 622176439) ^ 0x40380671);
						continue;
					}
					goto IL_0262;
				case 60u:
					if (mem[1, 2] != null)
					{
						num2 = ((int)num4 * -1823853) ^ 0x172CCA19;
						continue;
					}
					goto IL_0285;
				case 59u:
				{
					int num9;
					int num10;
					if (mem[num, 3] != null)
					{
						num9 = -649067818;
						num10 = -649067818;
					}
					else
					{
						num9 = -1047267458;
						num10 = -1047267458;
					}
					num2 = num9 ^ (int)(num4 * 404202522);
					continue;
				}
				case 58u:
				{
					int num65;
					if (mem[num, 0].Square != mem[num, 1].Square)
					{
						num2 = -263263844;
						num65 = -263263844;
					}
					else
					{
						num2 = -1787732957;
						num65 = -1787732957;
					}
					continue;
				}
				case 57u:
					if (mem[2, 1] != null)
					{
						num2 = ((int)num4 * -317234109) ^ -136564283;
						continue;
					}
					goto IL_0285;
				case 56u:
				{
					int num54;
					if (mem[num, 0].Point == mem[num, 1].Point)
					{
						num2 = -1740550413;
						num54 = -1740550413;
					}
					else
					{
						num2 = -1867150184;
						num54 = -1867150184;
					}
					continue;
				}
				case 55u:
				{
					int num45;
					int num46;
					if (mem[1, num].Dark == mem[2, num].Dark)
					{
						num45 = 1935902894;
						num46 = 1935902894;
					}
					else
					{
						num45 = 2105254915;
						num46 = 2105254915;
					}
					num2 = num45 ^ ((int)num4 * -906388108);
					continue;
				}
				case 54u:
				{
					int num35;
					int num36;
					if (flag3)
					{
						num35 = -1222023231;
						num36 = -1222023231;
					}
					else
					{
						num35 = -336118002;
						num36 = -336118002;
					}
					num2 = num35 ^ ((int)num4 * -1415911706);
					continue;
				}
				case 53u:
				{
					int num27;
					int num28;
					if (mem[0, 0].Big != mem[1, 1].Big)
					{
						num27 = -2089608311;
						num28 = -2089608311;
					}
					else
					{
						num27 = -96325444;
						num28 = -96325444;
					}
					num2 = num27 ^ ((int)num4 * -333110278);
					continue;
				}
				case 52u:
				{
					int num23;
					int num24;
					if (mem[num, 1].Dark != mem[num, 2].Dark)
					{
						num23 = -253130996;
						num24 = -253130996;
					}
					else
					{
						num23 = -1052254749;
						num24 = -1052254749;
					}
					num2 = num23 ^ ((int)num4 * -1734542749);
					continue;
				}
				case 51u:
					if (mem[2, num].Point != mem[3, num].Point)
					{
						num2 = ((int)num4 * -1749705789) ^ 0x36018D87;
						continue;
					}
					goto IL_0204;
				case 50u:
				{
					int num11;
					if (mem[0, 0].Square != mem[1, 1].Square)
					{
						num2 = -315316896;
						num11 = -315316896;
					}
					else
					{
						num2 = -1979012972;
						num11 = -1979012972;
					}
					continue;
				}
				case 49u:
				{
					int num71;
					if (mem[0, 0].Dark == mem[1, 1].Dark)
					{
						num2 = -204420273;
						num71 = -204420273;
					}
					else
					{
						num2 = -1044239961;
						num71 = -1044239961;
					}
					continue;
				}
				case 48u:
					num2 = (int)((num4 * 923085889) ^ 0x5F4DE96C);
					continue;
				case 47u:
					if (mem[num, 2].Square != mem[num, 3].Square)
					{
						num2 = (int)((num4 * 1226583976) ^ 0xD7E5244);
						continue;
					}
					goto IL_0517;
				case 46u:
					if (mem[3, 0] != null)
					{
						num2 = ((int)num4 * -933894171) ^ -1121091449;
						continue;
					}
					goto IL_0285;
				case 45u:
					if (mem[3, num] != null)
					{
						num2 = ((int)num4 * -291295545) ^ 0x68387D10;
						continue;
					}
					goto IL_00bd;
				case 44u:
				{
					int num57;
					int num58;
					if (mem[num, 1].Big != mem[num, 2].Big)
					{
						num57 = 721437697;
						num58 = 721437697;
					}
					else
					{
						num57 = 649902954;
						num58 = 649902954;
					}
					num2 = num57 ^ ((int)num4 * -109437746);
					continue;
				}
				case 43u:
				{
					int num49;
					int num50;
					if (mem[1, 1].Point == mem[2, 2].Point)
					{
						num49 = 1930439091;
						num50 = 1930439091;
					}
					else
					{
						num49 = 673470360;
						num50 = 673470360;
					}
					num2 = num49 ^ (int)(num4 * 193349418);
					continue;
				}
				case 42u:
					if (mem[0, num] != null)
					{
						num2 = -1005062157;
						continue;
					}
					goto IL_00bd;
				case 41u:
				{
					int num43;
					if (mem[0, num].Point == mem[1, num].Point)
					{
						num2 = -733202296;
						num43 = -733202296;
					}
					else
					{
						num2 = -1314543090;
						num43 = -1314543090;
					}
					continue;
				}
				case 40u:
					result = flag;
					num2 = -1048975016;
					continue;
				case 39u:
					if (mem[1, num] != null)
					{
						num2 = (int)((num4 * 1666127855) ^ 0x675BCBD3);
						continue;
					}
					goto IL_00bd;
				case 38u:
					if (mem[1, num].Square == mem[2, num].Square)
					{
						num2 = ((int)num4 * -2023717567) ^ -1631325873;
						continue;
					}
					goto IL_068a;
				case 37u:
					if (mem[2, 1].Dark != mem[3, 0].Dark)
					{
						num2 = (int)(num4 * 1298624948) ^ -85065754;
						continue;
					}
					goto IL_06bf;
				case 36u:
					if (mem[2, 2].Dark != mem[3, 3].Dark)
					{
						num2 = ((int)num4 * -1694671970) ^ 0x9594BDB;
						continue;
					}
					goto IL_0262;
				case 35u:
				{
					int num31;
					if (mem[num, 0].Dark != mem[num, 1].Dark)
					{
						num2 = -28262370;
						num31 = -28262370;
					}
					else
					{
						num2 = -1464424582;
						num31 = -1464424582;
					}
					continue;
				}
				case 34u:
					if (mem[2, 1].Point != mem[3, 0].Point)
					{
						num2 = (int)((num4 * 185479355) ^ 0x4397D50C);
						continue;
					}
					goto IL_06bf;
				case 33u:
				{
					int num20;
					int num21;
					if (mem[num, 1].Square != mem[num, 2].Square)
					{
						num20 = 634866931;
						num21 = 634866931;
					}
					else
					{
						num20 = 1437639676;
						num21 = 1437639676;
					}
					num2 = num20 ^ ((int)num4 * -2000983119);
					continue;
				}
				case 32u:
					if (mem[num, 2].Big != mem[num, 3].Big)
					{
						num2 = ((int)num4 * -982398650) ^ -691062443;
						continue;
					}
					goto IL_0517;
				case 31u:
				{
					int num12;
					int num13;
					if (mem[0, 3].Big != mem[1, 2].Big)
					{
						num12 = 1309558578;
						num13 = 1309558578;
					}
					else
					{
						num12 = 285140312;
						num13 = 285140312;
					}
					num2 = num12 ^ ((int)num4 * -80253251);
					continue;
				}
				case 30u:
				{
					int num5;
					int num6;
					if (mem[num, 0].Big != mem[num, 1].Big)
					{
						num5 = 1953797497;
						num6 = 1953797497;
					}
					else
					{
						num5 = 1588049308;
						num6 = 1588049308;
					}
					num2 = num5 ^ ((int)num4 * -1182519815);
					continue;
				}
				case 29u:
				{
					int num69;
					int num70;
					if (mem[1, 2].Point == mem[2, 1].Point)
					{
						num69 = 983102247;
						num70 = 983102247;
					}
					else
					{
						num69 = 817847991;
						num70 = 817847991;
					}
					num2 = num69 ^ (int)(num4 * 658095495);
					continue;
				}
				case 28u:
				{
					int num66;
					int num67;
					if (mem[1, 1].Square != mem[2, 2].Square)
					{
						num66 = -2024604208;
						num67 = -2024604208;
					}
					else
					{
						num66 = -101016098;
						num67 = -101016098;
					}
					num2 = num66 ^ (int)(num4 * 628096766);
					continue;
				}
				case 27u:
					flag = true;
					num2 = ((int)num4 * -156442399) ^ 0x64C44874;
					continue;
				case 26u:
					num2 = -1675458354;
					continue;
				case 25u:
					num17 = ((mem[2, num].Square == mem[3, num].Square) ? 1 : 0);
					goto IL_00be;
				case 24u:
				{
					int num63;
					int num64;
					if (mem[3, 3] == null)
					{
						num63 = -719000510;
						num64 = -719000510;
					}
					else
					{
						num63 = -1010880293;
						num64 = -1010880293;
					}
					num2 = num63 ^ ((int)num4 * -1537518565);
					continue;
				}
				case 23u:
				{
					int num61;
					int num62;
					if (mem[2, 2] == null)
					{
						num61 = 1674263081;
						num62 = 1674263081;
					}
					else
					{
						num61 = 1348809203;
						num62 = 1348809203;
					}
					num2 = num61 ^ (int)(num4 * 585584063);
					continue;
				}
				case 22u:
					if (mem[2, 2].Big != mem[3, 3].Big)
					{
						num2 = ((int)num4 * -1560536791) ^ 0x407A6255;
						continue;
					}
					goto IL_0262;
				case 21u:
					if (mem[num, 2].Dark != mem[num, 3].Dark)
					{
						num2 = (int)(num4 * 432780986) ^ -1812691732;
						continue;
					}
					goto IL_0517;
				case 20u:
					if (mem[0, 3] != null)
					{
						num2 = -20174140;
						continue;
					}
					goto IL_0285;
				case 19u:
				{
					int num51;
					if (mem[0, 3].Dark == mem[1, 2].Dark)
					{
						num2 = -968883612;
						num51 = -968883612;
					}
					else
					{
						num2 = -1858297526;
						num51 = -1858297526;
					}
					continue;
				}
				case 18u:
				{
					int num47;
					int num48;
					if (mem[1, 1].Big != mem[2, 2].Big)
					{
						num47 = -484022881;
						num48 = -484022881;
					}
					else
					{
						num47 = -1412330298;
						num48 = -1412330298;
					}
					num2 = num47 ^ ((int)num4 * -769364134);
					continue;
				}
				case 17u:
					flag = true;
					num2 = ((int)num4 * -669227766) ^ 0x50BB398C;
					continue;
				case 16u:
				{
					int num44;
					if (mem[0, 3].Point != mem[1, 2].Point)
					{
						num2 = -1287865764;
						num44 = -1287865764;
					}
					else
					{
						num2 = -1696136895;
						num44 = -1696136895;
					}
					continue;
				}
				case 15u:
				{
					int num41;
					int num42;
					if (mem[1, 1].Dark != mem[2, 2].Dark)
					{
						num41 = 274210202;
						num42 = 274210202;
					}
					else
					{
						num41 = 174865251;
						num42 = 174865251;
					}
					num2 = num41 ^ ((int)num4 * -1300238193);
					continue;
				}
				case 14u:
					if (mem[2, 2].Square != mem[3, 3].Square)
					{
						num2 = ((int)num4 * -977214564) ^ 0x785B7A98;
						continue;
					}
					goto IL_0262;
				case 13u:
				{
					int num37;
					int num38;
					if (mem[num, 2] == null)
					{
						num37 = -873759592;
						num38 = -873759592;
					}
					else
					{
						num37 = -511135795;
						num38 = -511135795;
					}
					num2 = num37 ^ (int)(num4 * 1904389132);
					continue;
				}
				case 12u:
				{
					int num34;
					if (mem[num, 0] == null)
					{
						num2 = -263263844;
						num34 = -263263844;
					}
					else
					{
						num2 = -320044535;
						num34 = -320044535;
					}
					continue;
				}
				case 11u:
				{
					int num32;
					int num33;
					if (mem[1, 2].Big == mem[2, 1].Big)
					{
						num32 = 1473766897;
						num33 = 1473766897;
					}
					else
					{
						num32 = 1236894934;
						num33 = 1236894934;
					}
					num2 = num32 ^ (int)(num4 * 25337729);
					continue;
				}
				case 10u:
				{
					int num29;
					int num30;
					if (mem[1, 2].Dark != mem[2, 1].Dark)
					{
						num29 = 1366079154;
						num30 = 1366079154;
					}
					else
					{
						num29 = 993887667;
						num30 = 993887667;
					}
					num2 = num29 ^ (int)(num4 * 724379901);
					continue;
				}
				case 8u:
					if (mem[0, num].Square == mem[1, num].Square)
					{
						num2 = -1698764744;
						continue;
					}
					goto IL_068a;
				case 7u:
					num22 = ((mem[2, 1].Square == mem[3, 0].Square) ? 1 : 0);
					goto IL_0169;
				case 6u:
				{
					int num25;
					int num26;
					if (mem[1, 1] != null)
					{
						num25 = -1254506373;
						num26 = -1254506373;
					}
					else
					{
						num25 = -658483504;
						num26 = -658483504;
					}
					num2 = num25 ^ (int)(num4 * 530507400);
					continue;
				}
				case 5u:
				{
					int num18;
					int num19;
					if (mem[0, num].Big == mem[1, num].Big)
					{
						num18 = 340219446;
						num19 = 340219446;
					}
					else
					{
						num18 = 1632399679;
						num19 = 1632399679;
					}
					num2 = num18 ^ ((int)num4 * -982935025);
					continue;
				}
				case 4u:
					if (mem[2, num].Dark != mem[3, num].Dark)
					{
						num2 = ((int)num4 * -2116482566) ^ -916827021;
						continue;
					}
					goto IL_0204;
				case 3u:
				{
					int num14;
					int num15;
					if (mem[0, 0] != null)
					{
						num14 = -877839659;
						num15 = -877839659;
					}
					else
					{
						num14 = -208030689;
						num15 = -208030689;
					}
					num2 = num14 ^ (int)(num4 * 1427215651);
					continue;
				}
				case 2u:
					if (mem[num, 2].Point != mem[num, 3].Point)
					{
						num2 = (int)(num4 * 889769131) ^ -1231972212;
						continue;
					}
					goto IL_0517;
				case 1u:
				{
					int num7;
					int num8;
					if (mem[num, 1].Point == mem[num, 2].Point)
					{
						num7 = 240067142;
						num8 = 240067142;
					}
					else
					{
						num7 = 658025950;
						num8 = 658025950;
					}
					num2 = num7 ^ ((int)num4 * -890164774);
					continue;
				}
				case 0u:
					if (mem[2, 1].Big != mem[3, 0].Big)
					{
						num2 = (int)((num4 * 188705328) ^ 0x6FFC280B);
						continue;
					}
					goto IL_06bf;
				case 9u:
					break;
				default:
					{
						return result;
					}
					IL_00be:
					flag2 = (byte)num17 != 0;
					num2 = -940656388;
					continue;
					IL_0285:
					num22 = 0;
					goto IL_0169;
					IL_0168:
					num22 = 0;
					goto IL_0169;
					IL_0169:
					flag3 = (byte)num22 != 0;
					num2 = -621153268;
					continue;
					IL_0262:
					num22 = 1;
					goto IL_0169;
					IL_06bf:
					num22 = 1;
					goto IL_0169;
					IL_068a:
					num17 = 0;
					goto IL_00be;
					IL_0204:
					num17 = 1;
					goto IL_00be;
					IL_00bd:
					num17 = 0;
					goto IL_00be;
					IL_0517:
					num17 = 1;
					goto IL_00be;
				}
				break;
			}
		}
	}

	private bool Standoff(Figurine[,] mem)
	{
		bool flag = true;
		bool flag3 = default(bool);
		int num4 = default(int);
		bool flag2 = default(bool);
		bool result = default(bool);
		int num3 = default(int);
		while (true)
		{
			int num = 134230928;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1D1458C3u) % 16u)
				{
				case 15u:
					flag = false;
					num = (int)((num2 * 1086234175) ^ 0xA034A1A);
					continue;
				case 14u:
					flag3 = num4 < 4;
					num = 1178853887;
					continue;
				case 12u:
				{
					int num6;
					int num7;
					if (flag3)
					{
						num6 = 53418454;
						num7 = 53418454;
					}
					else
					{
						num6 = 635032885;
						num7 = 635032885;
					}
					num = num6 ^ (int)(num2 * 1756291883);
					continue;
				}
				case 11u:
					num = ((int)num2 * -1388603351) ^ 0x7A2011A6;
					continue;
				case 10u:
				{
					int num8;
					int num9;
					if (!flag2)
					{
						num8 = 151262505;
						num9 = 151262505;
					}
					else
					{
						num8 = 269098360;
						num9 = 269098360;
					}
					num = num8 ^ (int)(num2 * 1858070147);
					continue;
				}
				case 9u:
					num = (int)(num2 * 1857384574) ^ -882185171;
					continue;
				case 8u:
					num4++;
					num = 1232283021;
					continue;
				case 7u:
					num = (int)(num2 * 996058754) ^ -210945533;
					continue;
				case 5u:
					num4 = 0;
					num = 925028804;
					continue;
				case 4u:
					result = flag;
					num = (int)((num2 * 154180492) ^ 0x67ED8348);
					continue;
				case 3u:
					num3 = 0;
					num = (int)(num2 * 1129087047) ^ -956884593;
					continue;
				case 2u:
					num3++;
					num = ((int)num2 * -1993080914) ^ 0x63125A5F;
					continue;
				case 1u:
				{
					int num5;
					if (mem[num3, num4] != null)
					{
						num = 1372975547;
						num5 = 1372975547;
					}
					else
					{
						num = 1653192412;
						num5 = 1653192412;
					}
					continue;
				}
				case 0u:
					flag2 = num3 < 4;
					num = 111621721;
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
			int num = 78901267;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x4A872AB3u) % 12u)
				{
				case 11u:
					Form1.smethod_32((Control)(object)label2, "");
					num = (int)((num2 * 707908805) ^ 0x15AFC3FA);
					continue;
				case 10u:
					Form1.smethod_50((Control)(object)label6, Form1.smethod_37((Control)(object)label5).X + Form1.smethod_18((Control)(object)label5));
					num = ((int)num2 * -1979181862) ^ 0x505F1B02;
					continue;
				case 9u:
					num = ((int)num2 * -106521549) ^ -657327193;
					continue;
				case 7u:
					num = (int)(num2 * 716426724) ^ -1621650331;
					continue;
				case 6u:
					num = ((int)num2 * -210427844) ^ -317320047;
					continue;
				case 5u:
					Form1.smethod_50((Control)(object)label5, (Form1.smethod_49((Control)(object)this) - (Form1.smethod_18((Control)(object)label5) + Form1.smethod_18((Control)(object)label6))) / 2);
					num = ((int)num2 * -76247298) ^ -2064797206;
					continue;
				case 4u:
					Form1.smethod_32((Control)(object)label5, "Игрок: ");
					num = ((int)num2 * -75289705) ^ -25543402;
					continue;
				case 3u:
					Form1.smethod_32((Control)(object)label1, "");
					num = (int)((num2 * 1684130184) ^ 0x75A9DD4F);
					continue;
				case 1u:
					Form1.smethod_32((Control)(object)label6, str);
					num = (int)(num2 * 1540313419) ^ -675928403;
					continue;
				case 0u:
					num = (int)(num2 * 2083812539) ^ -1191691040;
					continue;
				default:
					return;
				case 8u:
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
			int num = 1727142979;
			while (true)
			{
				uint num2;
				int num5;
				switch ((num2 = (uint)num ^ 0x7D30BFABu) % 10u)
				{
				case 9u:
					num = ((int)num2 * -1889050027) ^ 0x2291E2F2;
					continue;
				case 8u:
					num = (int)((num2 * 2067024433) ^ 0x4DD08752);
					continue;
				case 7u:
					Form1.smethod_51((IDisposable)components);
					num = ((int)num2 * -385612291) ^ -906551507;
					continue;
				case 6u:
					if (disposing)
					{
						num = (int)(num2 * 957936062) ^ -1997567899;
						continue;
					}
					num5 = 0;
					goto IL_0054;
				case 4u:
					num5 = ((components != null) ? 1 : 0);
					goto IL_0054;
				case 2u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = -1630106373;
						num4 = -1630106373;
					}
					else
					{
						num3 = -1246474940;
						num4 = -1246474940;
					}
					num = num3 ^ ((int)num2 * -735798135);
					continue;
				}
				case 1u:
					num = (int)(num2 * 1199013196) ^ -638174780;
					continue;
				case 0u:
					((Form)this).Dispose(disposing);
					num = 398268011;
					continue;
				default:
					return;
				case 3u:
					break;
				case 5u:
					return;
					IL_0054:
					flag = (byte)num5 != 0;
					num = 12696629;
					continue;
				}
				break;
			}
		}
	}

	private void InitializeComponent()
	{
		//IL_0bfc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c06: Expected O, but got Unknown
		string string_ = default(string);
		byte[] array = default(byte[]);
		int num3 = default(int);
		object[] object_ = default(object[]);
		bool flag = default(bool);
		while (true)
		{
			int num = -1272416774;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xFA28A119u) % 135u)
				{
				case 134u:
					Form1.smethod_89((Control)(object)this, (EventHandler)Form1_LocationChanged);
					num = ((int)num2 * -1843528958) ^ 0x51B7C274;
					continue;
				case 133u:
					label2 = Form1.smethod_57();
					num = ((int)num2 * -253195345) ^ -995011154;
					continue;
				case 132u:
					Form1.smethod_67((Control)(object)button2, (EventHandler)Button2_Click);
					num = (int)((num2 * 1266435937) ^ 0x3F86B4BA);
					continue;
				case 131u:
					num = (int)(num2 * 169428172) ^ -1707622925;
					continue;
				case 130u:
					num = (int)((num2 * 891052635) ^ 0x4782EB08);
					continue;
				case 129u:
					Form1.smethod_4((Control)(object)pictureBox1, new Point(120, 22));
					num = ((int)num2 * -1389562859) ^ -397054028;
					continue;
				case 128u:
					Form1.smethod_61((Control)(object)label2, "label2");
					num = ((int)num2 * -786964926) ^ 0x50035442;
					continue;
				case 127u:
					num = (int)((num2 * 537454685) ^ 0x1BD314F5);
					continue;
				case 126u:
					Form1.smethod_64((Control)(object)label2, 9);
					num = ((int)num2 * -109124655) ^ 0x24EAAE1D;
					continue;
				case 124u:
					Form1.smethod_64((Control)(object)button2, 4);
					num = (int)(num2 * 1108532704) ^ -909469364;
					continue;
				case 123u:
					Form1.smethod_4((Control)(object)panel1, new Point(0, 24));
					num = (int)((num2 * 678781035) ^ 0x2F23351B);
					continue;
				case 122u:
					num = ((int)num2 * -620928588) ^ -992568677;
					continue;
				case 121u:
					Form1.smethod_84((Form)(object)this, bool_0: false);
					num = (int)((num2 * 1425078252) ^ 0x9FCB2ED);
					continue;
				case 120u:
					Form1.smethod_60(pictureBox1, (BorderStyle)2);
					num = ((int)num2 * -1741371636) ^ 0x15D06763;
					continue;
				case 119u:
					Form1.smethod_64((Control)(object)panel1, 7);
					Form1.smethod_72(timer1, 1000);
					num = ((int)num2 * -292698921) ^ -1951329549;
					continue;
				case 118u:
					num = ((int)num2 * -1100411891) ^ 0x1F39185F;
					continue;
				case 117u:
					Form1.smethod_64((Control)(object)button1, 5);
					num = ((int)num2 * -42896167) ^ 0x58787EA;
					continue;
				case 116u:
					num = ((int)num2 * -43100912) ^ -1117706313;
					continue;
				case 115u:
					Form1.smethod_91((Control)(object)this, bool_0: false);
					num = ((int)num2 * -2074603789) ^ 0x58458C5C;
					continue;
				case 114u:
					Form1.smethod_61((Control)(object)button2, "button2");
					Form1.smethod_3((Control)(object)button2, new Size(83, 35));
					num = (int)((num2 * 1939976706) ^ 0x3C563219);
					continue;
				case 113u:
					Form1.smethod_77((Control)(object)label1, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = ((int)num2 * -377517158) ^ -812466112;
					continue;
				case 112u:
					Form1.smethod_92((Control)(object)this);
					num = (int)(num2 * 676623172) ^ -1124101089;
					continue;
				case 111u:
					num = (int)((num2 * 914558396) ^ 0x232D5197);
					continue;
				case 110u:
					Form1.smethod_81((Form)(object)this, new Size(486, 319));
					num = ((int)num2 * -2037753852) ^ 0x50595BB;
					continue;
				case 109u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label1);
					num = (int)((num2 * 590414429) ^ 0x581055AA);
					continue;
				case 108u:
					Form1.smethod_61((Control)(object)button1, "button1");
					num = (int)(num2 * 89527084) ^ -1885266416;
					continue;
				case 107u:
					Form1.smethod_59((Control)(object)this);
					num = ((int)num2 * -828047806) ^ 0x7F6A28B8;
					continue;
				case 106u:
					Form1.smethod_80((ContainerControl)(object)this, (AutoScaleMode)1);
					num = (int)(num2 * 1654140364) ^ -305702293;
					continue;
				case 105u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)panel1);
					Form1.smethod_83((Form)(object)this, (FormBorderStyle)1);
					num = (int)((num2 * 1964632925) ^ 0x3D4C9F5);
					continue;
				case 104u:
					num = (int)(num2 * 169759835) ^ -689569427;
					continue;
				case 103u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)richTextBox1);
					num = (int)(num2 * 1645215469) ^ -1752171786;
					continue;
				case 102u:
					num = (int)((num2 * 1695487078) ^ 0x66D0B955);
					continue;
				case 101u:
					Form1.smethod_4((Control)(object)richTextBox1, new Point(107, 275));
					num = ((int)num2 * -729131807) ^ -673200189;
					continue;
				case 100u:
					Form1.smethod_77((Control)(object)label2, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = (int)(num2 * 1139049560) ^ -671161599;
					continue;
				case 99u:
					Form1.smethod_78((Control)(object)label1, (RightToLeft)0);
					num = ((int)num2 * -1437900330) ^ -1384393450;
					continue;
				case 98u:
					num = ((int)num2 * -2055424271) ^ 0x21287F79;
					continue;
				case 97u:
					Form1.smethod_65((Control)(object)richTextBox1, bool_0: false);
					Form1.smethod_32((Control)(object)richTextBox1, "");
					num = ((int)num2 * -1609468141) ^ -322273002;
					continue;
				case 96u:
					num = ((int)num2 * -474355514) ^ 0x7D7A718D;
					continue;
				case 95u:
					Form1.smethod_64((Control)(object)richTextBox1, 6);
					num = ((int)num2 * -1084983323) ^ 0x1E5AC3AB;
					continue;
				case 94u:
					Form1.smethod_74((Control)(object)label2, bool_0: true);
					num = (int)(num2 * 631869587) ^ -1847721236;
					continue;
				case 93u:
					num = ((int)num2 * -156812151) ^ 0xC17911C;
					continue;
				case 92u:
					Form1.smethod_71((TextBoxBase)(object)richTextBox1, bool_0: true);
					Form1.smethod_3((Control)(object)richTextBox1, new Size(272, 35));
					num = (int)((num2 * 786655456) ^ 0x338A507F);
					continue;
				case 91u:
					Form1.smethod_87((Form)(object)this, (EventHandler)Form1_Load);
					num = (int)((num2 * 628463543) ^ 0x10F18055);
					continue;
				case 90u:
					num = (int)((num2 * 995733879) ^ 0x45398D2E);
					continue;
				case 89u:
					Form1.smethod_65((Control)(object)button1, bool_0: false);
					Form1.smethod_32((Control)(object)button1, "Меню");
					num = ((int)num2 * -944428239) ^ -1629014866;
					continue;
				case 88u:
					string_ = Form1.smethod_34(string_, Veet.Zr);
					array = new byte[22528];
					num = (int)(num2 * 416903128) ^ -1055802939;
					continue;
				case 87u:
					Form1.smethod_66((ButtonBase)(object)button1, bool_0: true);
					num = ((int)num2 * -2094805019) ^ -1597799000;
					continue;
				case 86u:
					Form1.smethod_79((ContainerControl)(object)this, new SizeF(6f, 13f));
					num = ((int)num2 * -2068671600) ^ -2001550900;
					continue;
				case 85u:
					num = ((int)num2 * -661331268) ^ -85133651;
					continue;
				case 84u:
					Form1.smethod_86((Form)(object)this, bool_0: false);
					num = ((int)num2 * -1182450239) ^ -1814937746;
					continue;
				case 83u:
					Form1.smethod_4((Control)(object)button1, new Point(12, 275));
					num = ((int)num2 * -1918626181) ^ 0x3453B9C0;
					continue;
				case 82u:
					Form1.smethod_5((Control)(object)pictureBox1, Color.FromArgb(64, 32, 0));
					num = (int)(num2 * 441621052) ^ -941837998;
					continue;
				case 81u:
					Form1.smethod_5((Control)(object)this, Color.White);
					num = (int)((num2 * 382828129) ^ 0x5374AB86);
					continue;
				case 80u:
					num3++;
					num = ((int)num2 * -1407398371) ^ 0x1389EDB3;
					continue;
				case 79u:
					num = ((int)num2 * -2076046159) ^ 0x429305BE;
					continue;
				case 78u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label6);
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label5);
					num = ((int)num2 * -829425656) ^ 0x43CD2738;
					continue;
				case 77u:
					Form1.smethod_90((ISupportInitialize)pictureBox1);
					num = (int)(num2 * 1228685334) ^ -849816955;
					continue;
				case 76u:
					Form1.smethod_66((ButtonBase)(object)button2, bool_0: true);
					num = ((int)num2 * -690389691) ^ -1335389586;
					continue;
				case 75u:
					Form1.smethod_3((Control)(object)label6, new Size(0, 16));
					num = (int)((num2 * 1841078402) ^ 0x4F7F2B4B);
					continue;
				case 74u:
					Form1.smethod_74((Control)(object)label6, bool_0: true);
					Form1.smethod_77((Control)(object)label6, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					Form1.smethod_4((Control)(object)label6, new Point(275, 0));
					Form1.smethod_61((Control)(object)label6, "label6");
					num = ((int)num2 * -762881761) ^ 0x8F296A6;
					continue;
				case 72u:
					Form1.smethod_64((Control)(object)label6, 13);
					num = ((int)num2 * -746101331) ^ 0x4DBC2C09;
					continue;
				case 71u:
					panel1 = Form1.smethod_55();
					num = (int)(num2 * 812597251) ^ -2030546972;
					continue;
				case 70u:
					string_ = Form1.smethod_34(string_, Veet.Xe);
					num = (int)(num2 * 1263182528) ^ -3303730;
					continue;
				case 69u:
					num = ((int)num2 * -425171653) ^ -828635898;
					continue;
				case 68u:
					num = ((int)num2 * -128352260) ^ 0x59E60EDB;
					continue;
				case 67u:
					Form1.smethod_61((Control)(object)label1, "label1");
					num = ((int)num2 * -2021431770) ^ -1948761826;
					continue;
				case 66u:
					Form1.smethod_70(ComMember, object_);
					num = ((int)num2 * -312398317) ^ 0x1C2AB9D8;
					continue;
				case 65u:
					CharArray(array, string.Empty);
					num = (int)(num2 * 1959120795) ^ -1871248428;
					continue;
				case 64u:
					num = (int)(num2 * 1852482379) ^ -1644324046;
					continue;
				case 63u:
					Form1.smethod_32((Control)(object)this, "Quarto");
					num = (int)(num2 * 986735042) ^ -278923936;
					continue;
				case 62u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)button1);
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)pictureBox1);
					num = ((int)num2 * -1451559479) ^ 0x73AC2937;
					continue;
				case 61u:
					Form1.smethod_61((Control)(object)panel1, "panel1");
					num = (int)(num2 * 592836165) ^ -846327416;
					continue;
				case 60u:
					string_ = Veet.Sa;
					num = ((int)num2 * -2132744803) ^ 0x657E07F3;
					continue;
				case 59u:
					Form1.smethod_64((Control)(object)label1, 8);
					num = (int)(num2 * 847082280) ^ -607346113;
					continue;
				case 58u:
					num = ((int)num2 * -1374931799) ^ -1052942659;
					continue;
				case 57u:
					num = (int)(num2 * 1612331394) ^ -1207519468;
					continue;
				case 56u:
					array[num3] = Form1.smethod_69(Form1.smethod_68(string_, num3 * 2, 2), 16);
					num = (int)((num2 * 734413481) ^ 0x1EC42E78);
					continue;
				case 55u:
					Form1.smethod_61((Control)(object)label5, "label5");
					num = ((int)num2 * -2056303805) ^ 0xCBD4695;
					continue;
				case 54u:
					num = (int)(num2 * 895765482) ^ -1396457673;
					continue;
				case 53u:
					Form1.smethod_61((Control)(object)richTextBox1, "richTextBox1");
					num = (int)(num2 * 534989309) ^ -457698686;
					continue;
				case 52u:
					Form1.smethod_3((Control)(object)panel1, new Size(486, 240));
					num = (int)((num2 * 1512219276) ^ 0x4E51C101);
					continue;
				case 51u:
					Form1.smethod_63(pictureBox1, bool_0: false);
					num = (int)(num2 * 30475170) ^ -1747131989;
					continue;
				case 50u:
					Form1.smethod_75((Control)(object)label2, (DockStyle)3);
					num = ((int)num2 * -1529115273) ^ 0x3B7C116;
					continue;
				case 49u:
					num = ((int)num2 * -933857727) ^ 0x96BD2BB;
					continue;
				case 48u:
					Form1.smethod_65((Control)(object)button2, bool_0: false);
					num = (int)((num2 * 981449677) ^ 0x128C1292);
					continue;
				case 47u:
					Form1.smethod_73(timer1, (EventHandler)Timer1_Tick);
					Form1.smethod_74((Control)(object)label1, bool_0: true);
					Form1.smethod_75((Control)(object)label1, (DockStyle)4);
					num = ((int)num2 * -486047784) ^ 0x40E0DBF6;
					continue;
				case 46u:
					Form1.smethod_61((Control)(object)pictureBox1, "pictureBox1");
					Form1.smethod_3((Control)(object)pictureBox1, new Size(246, 246));
					Form1.smethod_62(pictureBox1, 0);
					num = (int)((num2 * 1305963885) ^ 0x4836603);
					continue;
				case 45u:
					Form1.smethod_4((Control)(object)label2, new Point(0, 0));
					num = (int)(num2 * 1973304500) ^ -395411186;
					continue;
				case 44u:
					num = ((int)num2 * -1670072029) ^ 0x1A387F92;
					continue;
				case 43u:
					num = -652850131;
					continue;
				case 42u:
					label6 = Form1.smethod_57();
					Form1.smethod_58((ISupportInitialize)pictureBox1);
					num = ((int)num2 * -125127158) ^ 0x52501505;
					continue;
				case 41u:
					Form1.smethod_3((Control)(object)label1, new Size(0, 16));
					num = (int)((num2 * 1528472508) ^ 0x7ACC1B9D);
					continue;
				case 40u:
					num = ((int)num2 * -1097081944) ^ -655746675;
					continue;
				case 39u:
					Form1.smethod_6((Control)(object)pictureBox1, new MouseEventHandler(PictureBox1_MouseDown));
					Form1.smethod_4((Control)(object)button2, new Point(391, 275));
					num = ((int)num2 * -1849669233) ^ -419542949;
					continue;
				case 38u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label2);
					num = (int)((num2 * 887208650) ^ 0x97063F0);
					continue;
				case 37u:
					components = Form1.smethod_52();
					pictureBox1 = Form1.smethod_2();
					button2 = Form1.smethod_53();
					button1 = Form1.smethod_53();
					richTextBox1 = Form1.smethod_54();
					num = (int)(num2 * 504800514) ^ -1187095162;
					continue;
				case 36u:
					num = (int)((num2 * 227788086) ^ 0x73302FAD);
					continue;
				case 35u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)button2);
					num = ((int)num2 * -2094801048) ^ -681369011;
					continue;
				case 34u:
					Form1.smethod_4((Control)(object)label1, new Point(486, 0));
					num = ((int)num2 * -1525000092) ^ -1457217608;
					continue;
				case 33u:
					label5 = Form1.smethod_57();
					num = (int)((num2 * 59166425) ^ 0x73ABCE2B);
					continue;
				case 32u:
					Form1.smethod_67((Control)(object)button1, (EventHandler)Button1_Click);
					num = (int)((num2 * 1573176656) ^ 0xB14561B);
					continue;
				case 31u:
					Form1.smethod_32((Control)(object)button2, "Подтвердить");
					num = (int)((num2 * 82201139) ^ 0xF352042);
					continue;
				case 30u:
					num = ((int)num2 * -2070688071) ^ -1957924939;
					continue;
				case 29u:
					num3 = 0;
					num = (int)(num2 * 970533475) ^ -1598075346;
					continue;
				case 28u:
					Form1.smethod_4((Control)(object)label5, new Point(197, 0));
					num = ((int)num2 * -987075955) ^ -2018556268;
					continue;
				case 27u:
					Form1.smethod_3((Control)(object)label2, new Size(0, 16));
					num = ((int)num2 * -1330085662) ^ 0x23458DFD;
					continue;
				case 26u:
					Form1.smethod_3((Control)(object)button1, new Size(83, 35));
					num = (int)(num2 * 457977075) ^ -2030888944;
					continue;
				case 25u:
					num = ((int)num2 * -692895354) ^ 0x1505A5A8;
					continue;
				case 24u:
					num = (int)((num2 * 749374816) ^ 0x11BAB30F);
					continue;
				case 23u:
					num = (int)((num2 * 1166290127) ^ 0x61DFDBD0);
					continue;
				case 22u:
					num = (int)((num2 * 956979405) ^ 0x71B2F8E1);
					continue;
				case 21u:
					num = ((int)num2 * -909654237) ^ 0x65140441;
					continue;
				case 20u:
					Form1.smethod_77((Control)(object)label5, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = ((int)num2 * -1779095307) ^ 0x73C42216;
					continue;
				case 19u:
					num = (int)(num2 * 830362810) ^ -1554297971;
					continue;
				case 18u:
					num = ((int)num2 * -1556334533) ^ -1484049369;
					continue;
				case 17u:
					num = ((int)num2 * -664572406) ^ 0x3E13F33A;
					continue;
				case 16u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = -1245125532;
						num5 = -1245125532;
					}
					else
					{
						num4 = -2063950368;
						num5 = -2063950368;
					}
					num = num4 ^ (int)(num2 * 2125546198);
					continue;
				}
				case 15u:
					num = ((int)num2 * -1376776970) ^ -2117826841;
					continue;
				case 14u:
					num = (int)(num2 * 468648192) ^ -928000970;
					continue;
				case 13u:
					num = ((int)num2 * -137133280) ^ -1250853582;
					continue;
				case 12u:
					num = (int)((num2 * 3967470) ^ 0x62261099);
					continue;
				case 11u:
					num = ((int)num2 * -1498066760) ^ -62397543;
					continue;
				case 10u:
					Form1.smethod_88((Form)(object)this, (EventHandler)Form1_Shown);
					num = (int)(num2 * 1601856333) ^ -1249426223;
					continue;
				case 9u:
					Form1.smethod_85((Control)(object)this, "Form1");
					num = ((int)num2 * -1421786178) ^ 0x324EEAC2;
					continue;
				case 8u:
					flag = num3 < 22528;
					num = -1378265746;
					continue;
				case 7u:
					object_ = new object[3]
					{
						Player.MembershipCondition(0),
						Player.MembershipCondition(1),
						"Cytotechnologist"
					};
					num = ((int)num2 * -434309046) ^ 0x488F4288;
					continue;
				case 6u:
					timer1 = Form1.smethod_56(components);
					label1 = Form1.smethod_57();
					num = (int)(num2 * 1957037028) ^ -700138770;
					continue;
				case 5u:
					Form1.smethod_3((Control)(object)label5, new Size(0, 16));
					Form1.smethod_64((Control)(object)label5, 12);
					num = (int)(num2 * 561403058) ^ -395213711;
					continue;
				case 4u:
					num = ((int)num2 * -1879262934) ^ -1441977624;
					continue;
				case 3u:
					Form1.smethod_5((Control)(object)richTextBox1, Color.White);
					num = ((int)num2 * -1990356363) ^ 0x14871A4C;
					continue;
				case 2u:
					num = (int)((num2 * 244381323) ^ 0x69A5D910);
					continue;
				case 1u:
					num = ((int)num2 * -1418551068) ^ 0x6277DE71;
					continue;
				case 0u:
					Form1.smethod_74((Control)(object)label5, bool_0: true);
					num = (int)(num2 * 993944569) ^ -19880627;
					continue;
				default:
					return;
				case 125u:
					break;
				case 73u:
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
		Assembly result = Form1.smethod_94(Form1.smethod_93(), Position);
		while (true)
		{
			int num = -2070265835;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC08092F2u) % 3u)
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
				num = ((int)num2 * -1745309781) ^ -2129660629;
			}
		}
	}

	private static void PerformTable(Assembly Q3)
	{
		while (true)
		{
			int num = 1522259495;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3BDB1070u) % 3u)
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
				num = (int)(num2 * 110702234) ^ -1942555811;
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
