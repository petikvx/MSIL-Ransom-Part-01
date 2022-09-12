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
				int num = -1816812607;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xDC090144u) % 5u)
					{
					case 3u:
						Dark = dark;
						num = (int)(num2 * 1311212094) ^ -876299613;
						continue;
					case 2u:
						num = ((int)num2 * -365655144) ^ -770205799;
						continue;
					case 1u:
						num = ((int)num2 * -1730412304) ^ -558980719;
						continue;
					case 0u:
						break;
					default:
						Big = big;
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
			while (true)
			{
				int num = 1687047061;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x6478B346u) % 4u)
					{
					case 3u:
						num = ((int)num2 * -860865270) ^ 0x3E28E49D;
						continue;
					case 1u:
						Dark = copy.Dark;
						Big = copy.Big;
						Square = copy.Square;
						Point = copy.Point;
						num = ((int)num2 * -1756447540) ^ 0x18A0955C;
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
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Expected O, but got Unknown
		int num3 = default(int);
		int num6 = default(int);
		bool flag = default(bool);
		while (true)
		{
			int num = 1204171826;
			while (true)
			{
				uint num2;
				double num7;
				double num9;
				PictureBox[,] array;
				int num10;
				int num11;
				PictureBox obj;
				PictureBox[,] array2;
				int num12;
				int num13;
				PictureBox obj2;
				switch ((num2 = (uint)num ^ 0x19A36D4u) % 24u)
				{
				case 23u:
					num3 = 0;
					num = ((int)num2 * -204424323) ^ -446388657;
					continue;
				case 22u:
					num = (int)(num2 * 1703264385) ^ -734544037;
					continue;
				case 21u:
					num = ((int)num2 * -1886096110) ^ -767426304;
					continue;
				case 20u:
					if (num6 >= 2)
					{
						num = ((int)num2 * -1698802017) ^ -2085038007;
						continue;
					}
					num7 = 0.0;
					goto IL_0080;
				case 19u:
					num = ((int)num2 * -619881866) ^ 0x396ED860;
					continue;
				case 18u:
					num = 387900280;
					continue;
				case 17u:
					num7 = 4.1;
					goto IL_0080;
				case 16u:
					Form1.smethod_11((Control)(object)menu);
					num = ((int)num2 * -1675607901) ^ -1694698888;
					continue;
				case 15u:
					num6 = 0;
					num = 1744037342;
					continue;
				case 14u:
					num6++;
					num = ((int)num2 * -458066465) ^ -819502709;
					continue;
				case 13u:
					borderBox = new PictureBox[4, 4];
					num = (int)((num2 * 2040795016) ^ 0x53F04CDB);
					continue;
				case 12u:
					num = ((int)num2 * -599442003) ^ 0x13C681B4;
					continue;
				case 11u:
					num3++;
					num = (int)((num2 * 551487794) ^ 0xEAF9A42);
					continue;
				case 10u:
					Form1.smethod_1(richTextBox1, (HorizontalAlignment)2);
					num = (int)(num2 * 596037309) ^ -802638543;
					continue;
				case 9u:
					InitializeComponent();
					num = ((int)num2 * -1183800486) ^ -1742047324;
					continue;
				case 7u:
					pictureBox = new PictureBox[4, 4];
					num = ((int)num2 * -336394282) ^ -2137387637;
					continue;
				case 6u:
					Form1.smethod_9(Form1.smethod_8((Control)(object)panel1), (Control)(object)borderBox[num3, num6]);
					num = (int)((num2 * 78502736) ^ 0x2F34AA7F);
					continue;
				case 5u:
				{
					int num8;
					if (num6 >= 4)
					{
						num = 797045743;
						num8 = 797045743;
					}
					else
					{
						num = 271892566;
						num8 = 271892566;
					}
					continue;
				}
				case 3u:
				{
					Form3 form_ = new Form3();
					Form1.smethod_10((Form)(object)form_, (Form)(object)this);
					menu = (Form)(object)form_;
					num = ((int)num2 * -318002298) ^ 0x4EC1473E;
					continue;
				}
				case 2u:
					num = ((int)num2 * -963322704) ^ 0x7C092571;
					continue;
				case 1u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = -1339762737;
						num5 = -1339762737;
					}
					else
					{
						num4 = -1086019229;
						num5 = -1086019229;
					}
					num = num4 ^ ((int)num2 * -1922670356);
					continue;
				}
				case 0u:
					flag = num3 < 4;
					num = 1547897445;
					continue;
				default:
					return;
				case 8u:
					break;
				case 4u:
					return;
					IL_0080:
					num9 = num7;
					array = pictureBox;
					num10 = num3;
					num11 = num6;
					obj = Form1.smethod_2();
					Form1.smethod_3((Control)(object)obj, new Size(size - 8, size - 8));
					Form1.smethod_4((Control)(object)obj, new Point(4 + (int)(((double)num6 + num9) * (double)size), 4 + num3 * size));
					Form1.smethod_5((Control)(object)obj, Color.White);
					array[num10, num11] = obj;
					Form1.smethod_6((Control)(object)pictureBox[num3, num6], new MouseEventHandler(PictureBoxIJ_MouseDown));
					array2 = borderBox;
					num12 = num3;
					num13 = num6;
					obj2 = Form1.smethod_2();
					Form1.smethod_3((Control)(object)obj2, new Size(size - 2, size - 2));
					Form1.smethod_4((Control)(object)obj2, new Point(1 + (int)(((double)num6 + num9) * (double)size), 1 + num3 * size));
					Form1.smethod_7((Control)(object)obj2, bool_0: false);
					array2[num12, num13] = obj2;
					Form1.smethod_9(Form1.smethod_8((Control)(object)panel1), (Control)(object)pictureBox[num3, num6]);
					num = 1244193761;
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
			int num = -2028990939;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF046C197u) % 3u)
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
				num = ((int)num2 * -1367700635) ^ -1361870752;
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
			int num = -1643014236;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD0EC8323u) % 9u)
				{
				case 8u:
					num = -583750641;
					continue;
				case 7u:
					Form1.smethod_14(menu);
					num = ((int)num2 * -872623447) ^ 0x67951608;
					continue;
				case 6u:
					num = ((int)num2 * -396049412) ^ 0x720CEA8D;
					continue;
				case 5u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = -178389939;
						num4 = -178389939;
					}
					else
					{
						num3 = -1039011095;
						num4 = -1039011095;
					}
					num = num3 ^ ((int)num2 * -347923212);
					continue;
				}
				case 4u:
					flag = Form1.smethod_16((Control)(object)menu) < 296;
					num = -313200672;
					continue;
				case 3u:
					num = (int)((num2 * 197494715) ^ 0x3D2E652D);
					continue;
				case 2u:
				{
					Form control_ = menu;
					Form1.smethod_17((Control)(object)control_, Form1.smethod_16((Control)(object)control_) + 5);
					num = (int)((num2 * 1642971180) ^ 0x20FF5120);
					continue;
				}
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

	private void Form1_Load(object sender, EventArgs e)
	{
		int num4 = default(int);
		int num3 = default(int);
		while (true)
		{
			int num = 846788154;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x30748DB0u) % 23u)
				{
				case 22u:
					num4 = 0;
					num = (int)((num2 * 1931901124) ^ 0x3CA9C144);
					continue;
				case 21u:
					num = ((int)num2 * -1477850117) ^ -21290030;
					continue;
				case 20u:
					storage[num4, num3] = new Figurine(num4 < 2, num3 % 2 == 0, num3 < 2, num4 % 2 == 1);
					Form1.smethod_5((Control)(object)borderBox[num4, num3], Color.White);
					num = ((int)num2 * -186777163) ^ 0x498AD60E;
					continue;
				case 19u:
					num3 = 0;
					num = 373330191;
					continue;
				case 17u:
				{
					int num6;
					if (num4 < 4)
					{
						num = 1131542089;
						num6 = 1131542089;
					}
					else
					{
						num = 1854659013;
						num6 = 1854659013;
					}
					continue;
				}
				case 16u:
					Form1.smethod_7((Control)(object)button2, bool_0: false);
					num = (int)((num2 * 1700048366) ^ 0x70A194D2);
					continue;
				case 15u:
					num = ((int)num2 * -522208775) ^ -865818223;
					continue;
				case 14u:
				{
					int num5;
					if (num3 < 4)
					{
						num = 730468854;
						num5 = 730468854;
					}
					else
					{
						num = 560196728;
						num5 = 560196728;
					}
					continue;
				}
				case 13u:
					num = (int)(num2 * 1724250112) ^ -358499862;
					continue;
				case 12u:
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: false);
					num = (int)((num2 * 1219311125) ^ 0x233A9B7E);
					continue;
				case 11u:
					num = 1941530722;
					continue;
				case 10u:
					num = ((int)num2 * -603334535) ^ 0x26AD9773;
					continue;
				case 9u:
					num = (int)(num2 * 914674644) ^ -1211801082;
					continue;
				case 8u:
					storage = new Figurine[4, 4];
					num = (int)(num2 * 616582461) ^ -691926436;
					continue;
				case 7u:
					num4++;
					num = (int)((num2 * 1257816755) ^ 0x5D11013B);
					continue;
				case 6u:
					Form1.smethod_7((Control)(object)pictureBox[num4, num3], bool_0: false);
					num = ((int)num2 * -1715285849) ^ -1086498980;
					continue;
				case 4u:
					Paint_Board();
					num = (int)((num2 * 393568192) ^ 0x4410991C);
					continue;
				case 3u:
					num3++;
					num = ((int)num2 * -2105397881) ^ 0x26F94AE1;
					continue;
				case 2u:
					board = new Figurine[4, 4];
					num = ((int)num2 * -1418735683) ^ 0x4BC6145B;
					continue;
				case 1u:
					num = ((int)num2 * -2068507512) ^ 0x74175FE8;
					continue;
				case 0u:
					Paint_Storage();
					num = (int)(num2 * 863087681) ^ -1825501549;
					continue;
				default:
					return;
				case 18u:
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
		Form1.smethod_20(pictureBox1, (Image)(object)Form1.smethod_19(Form1.smethod_18((Control)(object)pictureBox1), Form1.smethod_16((Control)(object)pictureBox1)));
		bool dark = default(bool);
		bool flag = default(bool);
		int num3 = default(int);
		bool point = default(bool);
		Brush brush_ = default(Brush);
		float num6 = default(float);
		float num9 = default(float);
		float num10 = default(float);
		float num8 = default(float);
		Graphics graphics_ = default(Graphics);
		int num4 = default(int);
		bool big = default(bool);
		bool square = default(bool);
		while (true)
		{
			int num = 1614939697;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x35DE33E0u) % 39u)
				{
				case 38u:
					num = (int)(num2 * 655389867) ^ -1031662768;
					continue;
				case 37u:
				{
					int num21;
					int num22;
					if (!dark)
					{
						num21 = 518297418;
						num22 = 518297418;
					}
					else
					{
						num21 = 1777635954;
						num22 = 1777635954;
					}
					num = num21 ^ ((int)num2 * -1466071080);
					continue;
				}
				case 36u:
					flag = num3 < 4;
					num = 2011544915;
					continue;
				case 35u:
				{
					int num17;
					int num18;
					if (point)
					{
						num17 = -1264017366;
						num18 = -1264017366;
					}
					else
					{
						num17 = -357063515;
						num18 = -357063515;
					}
					num = num17 ^ (int)(num2 * 1809946724);
					continue;
				}
				case 34u:
					num = 1124266927;
					continue;
				case 33u:
					brush_ = Form1.smethod_25();
					num = ((int)num2 * -1715482420) ^ 0x110AF31A;
					continue;
				case 32u:
					num6 = 0.7f;
					num = 1704520286;
					continue;
				case 31u:
					Form1.smethod_30((Control)(object)pictureBox1);
					num = ((int)num2 * -81267366) ^ 0x1F3652CF;
					continue;
				case 30u:
					num6 = 1f;
					num = ((int)num2 * -1653782797) ^ -1554805569;
					continue;
				case 29u:
					num = ((int)num2 * -661901570) ^ 0x1107C924;
					continue;
				case 28u:
					num = ((int)num2 * -1990960377) ^ -512635198;
					continue;
				case 26u:
				{
					float num7 = 1f - num6 * 0.4f / (float)Form1.smethod_27(2.0);
					num9 = (float)size * (num7 / 2f);
					num10 = num8 * 0.4f / (float)Form1.smethod_27(2.0);
					num = 669836737;
					continue;
				}
				case 25u:
					brush_ = Form1.smethod_26();
					num = 474544556;
					continue;
				case 24u:
					Form1.smethod_24(graphics_, Form1.smethod_23(), ((float)num3 + 0.05f) * (float)size, ((float)num4 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					num = (int)((num2 * 949531231) ^ 0x664EBF3B);
					continue;
				case 23u:
				{
					int num19;
					int num20;
					if (flag)
					{
						num19 = 555860511;
						num20 = 555860511;
					}
					else
					{
						num19 = 1845178886;
						num20 = 1845178886;
					}
					num = num19 ^ (int)(num2 * 1880862326);
					continue;
				}
				case 22u:
					dark = board[num4, num3].Dark;
					num = ((int)num2 * -1891215909) ^ 0x7556AEBE;
					continue;
				case 21u:
					point = board[num4, num3].Point;
					num = ((int)num2 * -433322037) ^ 0x26AA2F42;
					continue;
				case 20u:
					Form1.smethod_28(graphics_, brush_, num9 + (float)(num3 * size), num9 + (float)(num4 * size), num10, num10);
					num = ((int)num2 * -1446226825) ^ -2096067578;
					continue;
				case 19u:
					big = board[num4, num3].Big;
					num = 1197203762;
					continue;
				case 18u:
					num4 = 0;
					num = ((int)num2 * -1924564972) ^ -1939152276;
					continue;
				case 17u:
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox1));
					num = ((int)num2 * -1920182107) ^ 0x78DBF385;
					continue;
				case 15u:
					Form1.smethod_24(graphics_, brush_, num9 + (float)(num3 * size), num9 + (float)(num4 * size), num10, num10);
					num = 30995523;
					continue;
				case 14u:
				{
					int num15;
					int num16;
					if (board[num4, num3] == null)
					{
						num15 = -1219512124;
						num16 = -1219512124;
					}
					else
					{
						num15 = -2108190907;
						num16 = -2108190907;
					}
					num = num15 ^ ((int)num2 * -2128851552);
					continue;
				}
				case 13u:
				{
					int num13;
					int num14;
					if (!big)
					{
						num13 = 576269793;
						num14 = 576269793;
					}
					else
					{
						num13 = 603187997;
						num14 = 603187997;
					}
					num = num13 ^ ((int)num2 * -1386570341);
					continue;
				}
				case 12u:
					num4++;
					num = (int)(num2 * 1311616245) ^ -1165780415;
					continue;
				case 11u:
				{
					int num11;
					int num12;
					if (!square)
					{
						num11 = -1443505078;
						num12 = -1443505078;
					}
					else
					{
						num11 = -968562203;
						num12 = -968562203;
					}
					num = num11 ^ (int)(num2 * 1515431579);
					continue;
				}
				case 10u:
					num3++;
					num = 55539165;
					continue;
				case 9u:
					num = ((int)num2 * -1373309309) ^ 0x6E737260;
					continue;
				case 8u:
					num10 = num8 * 0.9f / (float)Form1.smethod_27(2.0);
					square = board[num4, num3].Square;
					num = ((int)num2 * -893321793) ^ 0x78DC5D96;
					continue;
				case 7u:
					num = ((int)num2 * -1777127848) ^ -487164532;
					continue;
				case 6u:
					num = ((int)num2 * -924623184) ^ -37533003;
					continue;
				case 5u:
					num = (int)(num2 * 257008430) ^ -1717165155;
					continue;
				case 4u:
					num = 20915524;
					continue;
				case 3u:
					Form1.smethod_24(graphics_, (Brush)(object)Form1.smethod_29(Color.FromArgb(180, Color.Peru)), num9 + (float)(num3 * size), num9 + (float)(num4 * size), num10, num10);
					num = ((int)num2 * -1696708244) ^ 0x2F4E9BC9;
					continue;
				case 2u:
				{
					float num7 = 1f - num6 * 0.9f / (float)Form1.smethod_27(2.0);
					num8 = (float)size * num6;
					num9 = (float)size * (num7 / 2f);
					num = 2069858306;
					continue;
				}
				case 1u:
				{
					int num5;
					if (num4 < 4)
					{
						num = 479612372;
						num5 = 479612372;
					}
					else
					{
						num = 1137501551;
						num5 = 1137501551;
					}
					continue;
				}
				case 0u:
					num3 = 0;
					num = 55539165;
					continue;
				default:
					return;
				case 16u:
					break;
				case 27u:
					return;
				}
				break;
			}
		}
	}

	private void Paint_Storage()
	{
		int num8 = default(int);
		int num9 = default(int);
		bool dark = default(bool);
		float num6 = default(float);
		float num5 = default(float);
		Graphics graphics_ = default(Graphics);
		float num7 = default(float);
		bool big = default(bool);
		Brush brush_ = default(Brush);
		float num3 = default(float);
		bool flag = default(bool);
		float num4 = default(float);
		while (true)
		{
			int num = -1714845648;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xBAE20364u) % 40u)
				{
				case 39u:
					Form1.smethod_30((Control)(object)pictureBox[num8, num9]);
					num = -1473241778;
					continue;
				case 38u:
					num8++;
					num = (int)(num2 * 550129510) ^ -415795517;
					continue;
				case 37u:
					num = (int)((num2 * 1225218424) ^ 0x49409BBB);
					continue;
				case 36u:
					num8 = 0;
					num = (int)((num2 * 1269806083) ^ 0x52DB483E);
					continue;
				case 35u:
					num9++;
					num = -1910642766;
					continue;
				case 34u:
					dark = storage[num8, num9].Dark;
					num = (int)((num2 * 1252111443) ^ 0x18E3EBE5);
					continue;
				case 33u:
					num = ((int)num2 * -1146397987) ^ 0xA32EF70;
					continue;
				case 32u:
					num6 = (float)size * (num5 / 2f) - 4f;
					num = (int)(num2 * 947668789) ^ -611140305;
					continue;
				case 31u:
					Form1.smethod_24(graphics_, (Brush)(object)Form1.smethod_29(Color.FromArgb(180, Color.Peru)), num6, num6, num7, num7);
					num = (int)((num2 * 230187652) ^ 0xA0A08F7);
					continue;
				case 30u:
					num = (int)(num2 * 969751229) ^ -1698065127;
					continue;
				case 29u:
				{
					int num15;
					int num16;
					if (!big)
					{
						num15 = 1136092613;
						num16 = 1136092613;
					}
					else
					{
						num15 = 1425402648;
						num16 = 1425402648;
					}
					num = num15 ^ (int)(num2 * 1696120386);
					continue;
				}
				case 28u:
					Form1.smethod_24(graphics_, brush_, num6, num6, num7, num7);
					num = -1178554830;
					continue;
				case 26u:
					num = (int)(num2 * 1853991015) ^ -1097682549;
					continue;
				case 25u:
					Form1.smethod_28(graphics_, brush_, num6, num6, num7, num7);
					num = (int)(num2 * 368356740) ^ -976219839;
					continue;
				case 24u:
					num9 = 0;
					num = -1910642766;
					continue;
				case 23u:
				{
					int num20;
					int num21;
					if (dark)
					{
						num20 = -1734334568;
						num21 = -1734334568;
					}
					else
					{
						num20 = -896689676;
						num21 = -896689676;
					}
					num = num20 ^ ((int)num2 * -520216521);
					continue;
				}
				case 22u:
					num3 = 1f;
					num = ((int)num2 * -1182754951) ^ -151468326;
					continue;
				case 21u:
					brush_ = Form1.smethod_25();
					num = (int)(num2 * 240555695) ^ -494316067;
					continue;
				case 20u:
					num = (int)(num2 * 837275525) ^ -954246317;
					continue;
				case 19u:
				{
					int num19;
					if (num8 < 4)
					{
						num = -1057413244;
						num19 = -1057413244;
					}
					else
					{
						num = -511831001;
						num19 = -511831001;
					}
					continue;
				}
				case 18u:
				{
					int num17;
					int num18;
					if (flag)
					{
						num17 = -1881639333;
						num18 = -1881639333;
					}
					else
					{
						num17 = -1714497859;
						num18 = -1714497859;
					}
					num = num17 ^ (int)(num2 * 716492653);
					continue;
				}
				case 17u:
					brush_ = Form1.smethod_26();
					num = -358354291;
					continue;
				case 16u:
				{
					int num13;
					int num14;
					if (num9 < 2)
					{
						num13 = -529233659;
						num14 = -529233659;
					}
					else
					{
						num13 = -14116360;
						num14 = -14116360;
					}
					num = num13 ^ (int)(num2 * 491453480);
					continue;
				}
				case 15u:
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox[num8, num9]));
					num = ((int)num2 * -1392443525) ^ -1880308965;
					continue;
				case 14u:
				{
					int num12;
					if (num9 >= 4)
					{
						num = -1393021494;
						num12 = -1393021494;
					}
					else
					{
						num = -1519699312;
						num12 = -1519699312;
					}
					continue;
				}
				case 13u:
					num5 = 1f - num3 * 0.9f / (float)Form1.smethod_27(2.0);
					num = -966352276;
					continue;
				case 12u:
					Form1.smethod_20(pictureBox[num8, num9], (Image)(object)Form1.smethod_19(Form1.smethod_18((Control)(object)pictureBox[num8, num9]), Form1.smethod_16((Control)(object)pictureBox[num8, num9])));
					num = (int)((num2 * 965220179) ^ 0x7F51CBBD);
					continue;
				case 11u:
				{
					num7 = num4 * 0.4f / (float)Form1.smethod_27(2.0);
					int num10;
					int num11;
					if (storage[num8, num9].Point)
					{
						num10 = -534756436;
						num11 = -534756436;
					}
					else
					{
						num10 = -1630998052;
						num11 = -1630998052;
					}
					num = num10 ^ (int)(num2 * 49339165);
					continue;
				}
				case 10u:
					num = ((int)num2 * -1918541020) ^ -515214704;
					continue;
				case 9u:
					big = storage[num8, num9].Big;
					num = -1906191623;
					continue;
				case 8u:
					num = ((int)num2 * -13020241) ^ -1615083183;
					continue;
				case 6u:
					num = (int)((num2 * 34361530) ^ 0x61642DD2);
					continue;
				case 5u:
					num = (int)((num2 * 1481484677) ^ 0x606BF329);
					continue;
				case 4u:
					flag = storage[num8, num9] != null;
					num = -895388466;
					continue;
				case 3u:
					num3 = 0.7f;
					num = -816453815;
					continue;
				case 2u:
					num5 = 1f - num3 * 0.4f / (float)Form1.smethod_27(2.0);
					num = -465876276;
					continue;
				case 1u:
					num = ((int)num2 * -1122117225) ^ -1258869695;
					continue;
				case 0u:
					num4 = (float)size * num3;
					num6 = (float)size * (num5 / 2f) - 4f;
					num7 = num4 * 0.9f / (float)Form1.smethod_27(2.0);
					num = (int)((num2 * 1002913592) ^ 0x47D06C54);
					continue;
				default:
					return;
				case 7u:
					break;
				case 27u:
					return;
				}
				break;
			}
		}
	}

	public void StartGame()
	{
		Form1_Load(this, Form1.smethod_31());
		int num10 = default(int);
		int num5 = default(int);
		int num6 = default(int);
		int num7 = default(int);
		bool flag2 = default(bool);
		bool flag3 = default(bool);
		bool flag = default(bool);
		while (true)
		{
			int num = 1472063592;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1E2A87Eu) % 30u)
				{
				case 29u:
					num = (int)((num2 * 1032035344) ^ 0x6C806746);
					continue;
				case 28u:
					num10 = Form1.smethod_33(rnd, 4);
					num = ((int)num2 * -14759059) ^ -2147164123;
					continue;
				case 27u:
					num5 = Form1.smethod_33(rnd, 4);
					num = 151288492;
					continue;
				case 26u:
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: true);
					num = (int)((num2 * 721693442) ^ 0x426CDA59);
					continue;
				case 25u:
					num = ((int)num2 * -1763360995) ^ 0xDA15D8;
					continue;
				case 24u:
					num6 = 0;
					num = ((int)num2 * -19078105) ^ -96008331;
					continue;
				case 23u:
					Form1.smethod_7((Control)(object)pictureBox[num6, num7], bool_0: true);
					num = 1923427895;
					continue;
				case 22u:
				{
					int num11;
					int num12;
					if (!flag2)
					{
						num11 = -1414513121;
						num12 = -1414513121;
					}
					else
					{
						num11 = -1481554206;
						num12 = -1481554206;
					}
					num = num11 ^ ((int)num2 * -135259559);
					continue;
				}
				case 21u:
					Form1.smethod_5((Control)(object)borderBox[num5, num10], Color.Blue);
					num = (int)((num2 * 797045030) ^ 0x7F5594C8);
					continue;
				case 20u:
					num = (int)(num2 * 1912410795) ^ -1785833080;
					continue;
				case 19u:
					num = (int)(num2 * 1348519492) ^ -1046630172;
					continue;
				case 18u:
					Form1.smethod_32((Control)(object)label2, Form1.smethod_34("Ход: ", step.ToString()));
					time = new DateTime(0L, DateTimeKind.Unspecified);
					num = 88363505;
					continue;
				case 17u:
					flag3 = num6 < 4;
					num = 897607654;
					continue;
				case 16u:
					Form1.smethod_36(timer1);
					num = ((int)num2 * -635154117) ^ 0x1552785E;
					continue;
				case 15u:
					num = (int)((num2 * 538378875) ^ 0x7F546E85);
					continue;
				case 14u:
				{
					int num8;
					int num9;
					if (flag3)
					{
						num8 = -1622722282;
						num9 = -1622722282;
					}
					else
					{
						num8 = -2068819031;
						num9 = -2068819031;
					}
					num = num8 ^ (int)(num2 * 517995044);
					continue;
				}
				case 13u:
					num6++;
					num = ((int)num2 * -643740552) ^ 0x2D21A087;
					continue;
				case 12u:
					flag2 = turn;
					num = (int)((num2 * 325119209) ^ 0x22E5C9FE);
					continue;
				case 10u:
					num = ((int)num2 * -1339769131) ^ -461581264;
					continue;
				case 9u:
					flag = num7 < 4;
					num = 1677644678;
					continue;
				case 7u:
					Form1.smethod_35(timer1, bool_0: true);
					num = ((int)num2 * -2019736210) ^ 0x796BC6D3;
					continue;
				case 6u:
					num7 = 0;
					num = 884023209;
					continue;
				case 5u:
					Form1.smethod_32((Control)(object)richTextBox1, "Ваш ход. Выберете фигуру, которой будет играть противник.");
					num = (int)(num2 * 573839090) ^ -1160370875;
					continue;
				case 4u:
					Form1.smethod_32((Control)(object)richTextBox1, "Противник выбрал фигуру. Выберете поле на доске для установки этой фигуры.");
					step = 1;
					num = ((int)num2 * -167507837) ^ -674605900;
					continue;
				case 3u:
					num7++;
					num = (int)(num2 * 1715780944) ^ -1588542343;
					continue;
				case 2u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = 1523286315;
						num4 = 1523286315;
					}
					else
					{
						num3 = 1267526373;
						num4 = 1267526373;
					}
					num = num3 ^ ((int)num2 * -2012048219);
					continue;
				}
				case 1u:
					num = ((int)num2 * -2108918817) ^ 0x3B917D69;
					continue;
				case 0u:
					step = 0;
					num = ((int)num2 * -1443388334) ^ -2063850983;
					continue;
				default:
					return;
				case 11u:
					break;
				case 8u:
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
			int num = -120206613;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB2D70E2Eu) % 4u)
				{
				case 3u:
					Form1.smethod_32((Control)(object)label1, Form1.smethod_34("Время: ", time.ToString("HH:mm:ss")));
					num = ((int)num2 * -1727504670) ^ 0x64711F60;
					continue;
				case 1u:
					time = time.AddSeconds(1.0);
					num = (int)(num2 * 563028631) ^ -1719198826;
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

	private void PictureBoxIJ_MouseDown(object sender, MouseEventArgs e)
	{
		//IL_02ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c3: Expected O, but got Unknown
		int num11 = default(int);
		Point point = default(Point);
		bool flag2 = default(bool);
		int num4 = default(int);
		int num3 = default(int);
		int num6 = default(int);
		bool flag = default(bool);
		while (true)
		{
			int num = 1170228130;
			while (true)
			{
				uint num2;
				int num5;
				switch ((num2 = (uint)num ^ 0x6B8B2B43u) % 26u)
				{
				case 25u:
					num = (int)(num2 * 621705448) ^ -1767997768;
					continue;
				case 24u:
					num11++;
					num = ((int)num2 * -1961239988) ^ 0xBA68160;
					continue;
				case 23u:
					num = (int)(num2 * 190061073) ^ -520463190;
					continue;
				case 22u:
					point = Form1.smethod_37((Control)((sender is PictureBox) ? sender : null));
					num = ((int)num2 * -1344408353) ^ 0x5B8002FB;
					continue;
				case 21u:
					num11 = 0;
					num = 1573570769;
					continue;
				case 20u:
					num = ((int)num2 * -1594177490) ^ -349863740;
					continue;
				case 19u:
					num = (int)((num2 * 1175414646) ^ 0x289D4827);
					continue;
				case 18u:
					flag2 = num4 > 1;
					num = (int)((num2 * 933019803) ^ 0xA3C9986);
					continue;
				case 17u:
					Form1.smethod_5((Control)(object)borderBox[num3, num4], Color.Red);
					num = ((int)num2 * -1582186022) ^ -427071974;
					continue;
				case 15u:
					point = Form1.smethod_37((Control)((sender is PictureBox) ? sender : null));
					num = ((int)num2 * -391925701) ^ 0xF97CA87;
					continue;
				case 14u:
				{
					int num12;
					if (num6 >= 4)
					{
						num = 631165756;
						num12 = 631165756;
					}
					else
					{
						num = 1997328162;
						num12 = 1997328162;
					}
					continue;
				}
				case 13u:
					num6 = 0;
					num = ((int)num2 * -205676259) ^ 0x1A604118;
					continue;
				case 12u:
					if (storage[num3, num4] != null)
					{
						num = 1762745347;
						continue;
					}
					goto IL_014d;
				case 11u:
					flag = num11 < 4;
					num = 322381729;
					continue;
				case 10u:
					Form1.smethod_5((Control)(object)borderBox[num6, num11], Color.White);
					num = 1110556033;
					continue;
				case 9u:
					num4 -= 4;
					num = (int)((num2 * 313009435) ^ 0x71F82210);
					continue;
				case 7u:
					num3 = point.Y / size;
					num = ((int)num2 * -208236516) ^ 0x66DA5709;
					continue;
				case 6u:
					Form1.smethod_7((Control)(object)button2, bool_0: true);
					num = (int)((num2 * 1042179947) ^ 0x2E41A38E);
					continue;
				case 5u:
				{
					int num9;
					int num10;
					if (!flag2)
					{
						num9 = 1384097598;
						num10 = 1384097598;
					}
					else
					{
						num9 = 2072350783;
						num10 = 2072350783;
					}
					num = num9 ^ ((int)num2 * -636343285);
					continue;
				}
				case 4u:
				{
					int num7;
					int num8;
					if (!flag)
					{
						num7 = 517731878;
						num8 = 517731878;
					}
					else
					{
						num7 = 1298254317;
						num8 = 1298254317;
					}
					num = num7 ^ ((int)num2 * -1762183324);
					continue;
				}
				case 3u:
					Form1.smethod_32((Control)(object)richTextBox1, "Именно эта фигура? Если да - нажмите \"Подтвердить\".");
					num = (int)(num2 * 428214336) ^ -671657608;
					continue;
				case 2u:
					num4 = point.X / size;
					num = (int)(num2 * 1132713372) ^ -822805357;
					continue;
				case 1u:
					num6++;
					num = ((int)num2 * -2105667899) ^ 0x2295A88E;
					continue;
				case 0u:
					if (Form1.smethod_40((Bitmap)Form1.smethod_21(pictureBox[num3, num4]), Form1.smethod_38(e), Form1.smethod_39(e)) != Color.FromArgb(0, 0, 0, 0))
					{
						num = 1673677900;
						num5 = 1673677900;
						continue;
					}
					goto IL_014d;
				default:
					return;
				case 16u:
					break;
				case 8u:
					return;
					IL_014d:
					num = 1933569;
					num5 = 1933569;
					continue;
				}
				break;
			}
		}
	}

	private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
	{
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Expected O, but got Unknown
		Graphics graphics_ = default(Graphics);
		int num5 = default(int);
		int num6 = default(int);
		int num3 = default(int);
		int num4 = default(int);
		bool flag = default(bool);
		while (true)
		{
			int num = 2054329782;
			while (true)
			{
				uint num2;
				int num9;
				switch ((num2 = (uint)num ^ 0x759DC38Au) % 25u)
				{
				case 24u:
					Form1.smethod_7((Control)(object)button2, bool_0: true);
					num = (int)((num2 * 226982542) ^ 0x24143CC7);
					continue;
				case 23u:
					Form1.smethod_45(graphics_);
					Form1.smethod_30((Control)(object)pictureBox1);
					num = ((int)num2 * -298409713) ^ 0x71B4DF66;
					continue;
				case 22u:
					num = ((int)num2 * -476667252) ^ 0x610A60E9;
					continue;
				case 21u:
					Paint_Board();
					num = (int)(num2 * 733397064) ^ -46206982;
					continue;
				case 20u:
					num5 = Form1.smethod_38(e) / size;
					num6 = Form1.smethod_39(e) / size;
					if (Form1.smethod_40((Bitmap)Form1.smethod_21(pictureBox1), Form1.smethod_38(e), Form1.smethod_39(e)) != Color.FromArgb(0, 0, 0, 0))
					{
						num = ((int)num2 * -1308679827) ^ 0x6666D656;
						continue;
					}
					goto IL_00d9;
				case 19u:
					num = (int)(num2 * 5067063) ^ -929299318;
					continue;
				case 18u:
					num3++;
					num = (int)(num2 * 1681169431) ^ -757347551;
					continue;
				case 17u:
				{
					int num11;
					if (num3 < 4)
					{
						num = 619906699;
						num11 = 619906699;
					}
					else
					{
						num = 1331121626;
						num11 = 1331121626;
					}
					continue;
				}
				case 16u:
					num = (int)((num2 * 1601552559) ^ 0x1350FEE9);
					continue;
				case 15u:
				{
					int num10;
					if (Form1.smethod_41((Control)(object)borderBox[num3, num4]) == Color.Blue)
					{
						num = 541751479;
						num10 = 541751479;
					}
					else
					{
						num = 184799752;
						num10 = 184799752;
					}
					continue;
				}
				case 14u:
					num4 = 0;
					num = 1960601444;
					continue;
				case 13u:
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox1));
					num = (int)(num2 * 1098309775) ^ -939659802;
					continue;
				case 12u:
					num = (int)((num2 * 1836330376) ^ 0x79908356);
					continue;
				case 11u:
					num4++;
					num = 1960601444;
					continue;
				case 10u:
					if (board[num6, num5] == null)
					{
						num = 777274843;
						num9 = 777274843;
						continue;
					}
					goto IL_00d9;
				case 9u:
					Form1.smethod_44(graphics_, Form1.smethod_21(pictureBox[num3, num4]), num5 * size + 4, num6 * size + 4, new Rectangle(0, 0, size, size), (GraphicsUnit)2);
					num = ((int)num2 * -1313149544) ^ -187888166;
					continue;
				case 8u:
					num = (int)((num2 * 1177023812) ^ 0x6C363899);
					continue;
				case 6u:
				{
					int num7;
					int num8;
					if (!flag)
					{
						num7 = -872378491;
						num8 = -872378491;
					}
					else
					{
						num7 = -311982875;
						num8 = -311982875;
					}
					num = num7 ^ ((int)num2 * -818006485);
					continue;
				}
				case 5u:
					Form1.smethod_43(graphics_, Form1.smethod_42(Color.Red, 3f), ((float)num5 + 0.05f) * (float)size, ((float)num6 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					num = ((int)num2 * -348440692) ^ -721650405;
					continue;
				case 4u:
					Form1.smethod_32((Control)(object)richTextBox1, "Уверены? Для выполнения данного хода нажмите \"Подтвердить\".");
					num = ((int)num2 * -635534639) ^ -561158554;
					continue;
				case 3u:
					flag = num4 < 4;
					num = 1793656142;
					continue;
				case 2u:
					num3 = 0;
					num = (int)((num2 * 1675647461) ^ 0x39E10631);
					continue;
				case 1u:
					num = (int)((num2 * 1332707998) ^ 0x518AC167);
					continue;
				default:
					return;
				case 0u:
					break;
				case 7u:
					return;
					IL_00d9:
					num = 1331121626;
					num9 = 1331121626;
					continue;
				}
				break;
			}
		}
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		//IL_0638: Unknown result type (might be due to invalid IL or missing references)
		//IL_0666: Expected O, but got Unknown
		Form1.smethod_7((Control)(object)button2, bool_0: false);
		int num23 = default(int);
		bool flag3 = default(bool);
		int num38 = default(int);
		int num13 = default(int);
		int num3 = default(int);
		int num4 = default(int);
		int num22 = default(int);
		int num32 = default(int);
		int num10 = default(int);
		Figurine[,] array3 = default(Figurine[,]);
		int num6 = default(int);
		int num5 = default(int);
		int num28 = default(int);
		bool flag17 = default(bool);
		bool flag7 = default(bool);
		bool flag12 = default(bool);
		int num15 = default(int);
		bool flag13 = default(bool);
		int num11 = default(int);
		bool flag9 = default(bool);
		int num27 = default(int);
		int num29 = default(int);
		bool flag2 = default(bool);
		int num12 = default(int);
		int num7 = default(int);
		Graphics graphics_ = default(Graphics);
		bool flag15 = default(bool);
		Figurine[,] array = default(Figurine[,]);
		int num43 = default(int);
		int num24 = default(int);
		int num46 = default(int);
		int num47 = default(int);
		bool flag10 = default(bool);
		Figurine[,] array2 = default(Figurine[,]);
		bool flag14 = default(bool);
		bool flag16 = default(bool);
		bool flag = default(bool);
		bool flag6 = default(bool);
		bool flag11 = default(bool);
		bool flag5 = default(bool);
		bool flag4 = default(bool);
		bool flag8 = default(bool);
		while (true)
		{
			int num = -294872255;
			while (true)
			{
				uint num2;
				int num16;
				int num21;
				int num14;
				int num42;
				switch ((num2 = (uint)num ^ 0xF3476BA2u) % 176u)
				{
				case 175u:
					num23 = 0;
					num = -361105270;
					continue;
				case 174u:
					flag3 = num38 < 4;
					num = -1979175071;
					continue;
				case 173u:
				{
					int num64;
					int num65;
					if (!(Form1.smethod_41((Control)(object)borderBox[num13, num23]) == Color.Blue))
					{
						num64 = -1006804552;
						num65 = -1006804552;
					}
					else
					{
						num64 = -1282214102;
						num65 = -1282214102;
					}
					num = num64 ^ (int)(num2 * 822885056);
					continue;
				}
				case 172u:
					num = ((int)num2 * -465498577) ^ 0x2D76D2BD;
					continue;
				case 171u:
					num = ((int)num2 * -431354664) ^ 0x559AA08D;
					continue;
				case 169u:
					num23++;
					num = (int)((num2 * 322319420) ^ 0x20B501AC);
					continue;
				case 168u:
					num = (int)((num2 * 95460346) ^ 0x1F97372D);
					continue;
				case 167u:
					num = ((int)num2 * -557134079) ^ 0x7B98E5FF;
					continue;
				case 166u:
					Form1.smethod_30((Control)(object)label2);
					num = (int)(num2 * 1049663014) ^ -423083792;
					continue;
				case 165u:
					storage[num3, num4] = null;
					num = ((int)num2 * -665715262) ^ -256038305;
					continue;
				case 164u:
					num22++;
					num = ((int)num2 * -497253011) ^ -1119940241;
					continue;
				case 163u:
					storage[num3, num4] = null;
					num = (int)(num2 * 1086623519) ^ -125584788;
					continue;
				case 162u:
				{
					int num41;
					if (num32 >= 4)
					{
						num = -1444562074;
						num41 = -1444562074;
					}
					else
					{
						num = -964734397;
						num41 = -964734397;
					}
					continue;
				}
				case 161u:
					Form1.smethod_7((Control)(object)pictureBox[num22, num10], bool_0: true);
					num = -2107420740;
					continue;
				case 160u:
					num = ((int)num2 * -1167513245) ^ -970836244;
					continue;
				case 159u:
					num = ((int)num2 * -1736940103) ^ -813262265;
					continue;
				case 158u:
					num10++;
					num = ((int)num2 * -1509293898) ^ -726467453;
					continue;
				case 157u:
					num13++;
					num = (int)(num2 * 893792996) ^ -1563807422;
					continue;
				case 156u:
					array3 = (Figurine[,])Form1.smethod_48((Array)board);
					array3[num6, num5] = new Figurine(storage[num3, num4]);
					num38 = 0;
					num = ((int)num2 * -746026068) ^ 0x1C91BBE7;
					continue;
				case 155u:
					if (num28 == num3)
					{
						num = (int)(num2 * 20117569) ^ -982651617;
						continue;
					}
					goto IL_025f;
				case 154u:
				{
					int num60;
					int num61;
					if (!flag17)
					{
						num60 = 1362999523;
						num61 = 1362999523;
					}
					else
					{
						num60 = 1629659654;
						num61 = 1629659654;
					}
					num = num60 ^ ((int)num2 * -1562637829);
					continue;
				}
				case 153u:
				{
					int num56;
					int num57;
					if (flag7)
					{
						num56 = -1719478911;
						num57 = -1719478911;
					}
					else
					{
						num56 = -638132772;
						num57 = -638132772;
					}
					num = num56 ^ (int)(num2 * 504885278);
					continue;
				}
				case 152u:
					num = (int)(num2 * 665209991) ^ -1592286232;
					continue;
				case 151u:
					num = ((int)num2 * -1799615898) ^ -67045566;
					continue;
				case 150u:
					Form1.smethod_30((Control)(object)pictureBox1);
					Form1.smethod_47(200);
					num = (int)((num2 * 1829265025) ^ 0x7F2A9484);
					continue;
				case 149u:
				{
					int num50;
					int num51;
					if (!flag12)
					{
						num50 = -2068739617;
						num51 = -2068739617;
					}
					else
					{
						num50 = -311127686;
						num51 = -311127686;
					}
					num = num50 ^ ((int)num2 * -1901256189);
					continue;
				}
				case 148u:
					num15++;
					num = -511095116;
					continue;
				case 147u:
					num = (int)((num2 * 1899186649) ^ 0x1A759B4E);
					continue;
				case 146u:
					flag13 = num11 < 4;
					num = -2096737098;
					continue;
				case 145u:
					Form1.smethod_30((Control)(object)richTextBox1);
					num = (int)((num2 * 1877186094) ^ 0x454F9B76);
					continue;
				case 144u:
					Form1.smethod_32((Control)(object)richTextBox1, "Выберете фигуру, которой будет играть противник.");
					num = ((int)num2 * -1811480126) ^ 0x5E8DE86A;
					continue;
				case 143u:
				{
					int num36;
					int num37;
					if (flag9)
					{
						num36 = -588896924;
						num37 = -588896924;
					}
					else
					{
						num36 = -783888693;
						num37 = -783888693;
					}
					num = num36 ^ (int)(num2 * 1530531906);
					continue;
				}
				case 142u:
					Form1.smethod_30((Control)(object)pictureBox[num3, num4]);
					num = ((int)num2 * -1533283050) ^ 0x6A6EA29F;
					continue;
				case 140u:
					Form1.smethod_47(200);
					num = (int)((num2 * 1430599957) ^ 0x6DF503DC);
					continue;
				case 139u:
					num = (int)((num2 * 90330911) ^ 0x770AD189);
					continue;
				case 138u:
					Form1.smethod_30((Control)(object)borderBox[num27, num32]);
					num = ((int)num2 * -1992630084) ^ 0x4C496C86;
					continue;
				case 137u:
					flag7 = num22 < 4;
					num = -978487157;
					continue;
				case 136u:
					num = ((int)num2 * -1688231884) ^ -593018455;
					continue;
				case 135u:
					Form1.smethod_5((Control)(object)borderBox[num28, num29], Color.Blue);
					num = ((int)num2 * -1488294315) ^ -599667323;
					continue;
				case 134u:
					num = -815955161;
					continue;
				case 133u:
					Form1.smethod_47(1000);
					num = (int)(num2 * 1837572625) ^ -1940090281;
					continue;
				case 132u:
					num27++;
					num = ((int)num2 * -187376409) ^ -1485342146;
					continue;
				case 131u:
				{
					int num19;
					int num20;
					if (flag3)
					{
						num19 = 2068598415;
						num20 = 2068598415;
					}
					else
					{
						num19 = 774498552;
						num20 = 774498552;
					}
					num = num19 ^ ((int)num2 * -353647745);
					continue;
				}
				case 130u:
					num16 = ((num15 < 9) ? 1 : 0);
					goto IL_0513;
				case 129u:
					flag2 = board[num11, num12] == null;
					num = -1382745311;
					continue;
				case 128u:
				{
					int num67;
					if (num27 < 4)
					{
						num = -1123527871;
						num67 = -1123527871;
					}
					else
					{
						num = -1255299705;
						num67 = -1255299705;
					}
					continue;
				}
				case 127u:
					flag9 = num7 < 4;
					num = -309694851;
					continue;
				case 126u:
					Form1.smethod_43(graphics_, Form1.smethod_42(Color.LimeGreen, 3f), ((float)num12 + 0.05f) * (float)size, ((float)num11 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					num = (int)(num2 * 1019745981) ^ -1126453959;
					continue;
				case 125u:
					flag15 = true;
					num = (int)((num2 * 1013419318) ^ 0x4CB5D4DF);
					continue;
				case 124u:
					Form1.smethod_32((Control)(object)richTextBox1, "Ничья!");
					Form1.smethod_15(timer1);
					num = (int)(num2 * 109594437) ^ -1883792650;
					continue;
				case 123u:
					num = ((int)num2 * -1123716273) ^ -1363449073;
					continue;
				case 122u:
				{
					int num66;
					if (Form1.smethod_40((Bitmap)Form1.smethod_21(pictureBox1), num23 * size + size / 2, (int)(((float)num13 + 0.05f) * (float)size)) == Color.FromArgb(255, 255, 0, 0))
					{
						num = -1062854289;
						num66 = -1062854289;
					}
					else
					{
						num = -588700820;
						num66 = -588700820;
					}
					continue;
				}
				case 121u:
					array = (Figurine[,])Form1.smethod_48((Array)board);
					num = (int)((num2 * 865865597) ^ 0x13F2E1C5);
					continue;
				case 120u:
					Form1.smethod_32((Control)(object)richTextBox1, "QUARTO! Компьютер выиграл!");
					num = -1755264188;
					continue;
				case 119u:
					num43 = 0;
					num = ((int)num2 * -199851514) ^ -5522641;
					continue;
				case 118u:
					num = (int)((num2 * 1805866337) ^ 0x2DAC3BB8);
					continue;
				case 117u:
					num = ((int)num2 * -807505051) ^ 0x6EF0636B;
					continue;
				case 116u:
					board[num43, num24] = new Figurine(storage[num46, num47]);
					num = ((int)num2 * -566973545) ^ 0x3DB2715B;
					continue;
				case 115u:
					num = ((int)num2 * -1214291923) ^ -1696054322;
					continue;
				case 114u:
					array[num11, num12] = new Figurine(storage[num3, num4]);
					num = (int)(num2 * 1429488129) ^ -871463581;
					continue;
				case 113u:
					num = -1330950415;
					continue;
				case 112u:
					Form1.smethod_5((Control)(object)borderBox[num3, num4], Color.White);
					num = (int)(num2 * 1543916083) ^ -499721232;
					continue;
				case 111u:
				{
					int num62;
					int num63;
					if (!flag10)
					{
						num62 = 2139611720;
						num63 = 2139611720;
					}
					else
					{
						num62 = 916564582;
						num63 = 916564582;
					}
					num = num62 ^ ((int)num2 * -227374633);
					continue;
				}
				case 110u:
					num11++;
					num = (int)((num2 * 1075796077) ^ 0x457E3096);
					continue;
				case 109u:
					num10 = 0;
					num = -1117132755;
					continue;
				case 108u:
					flag17 = Standoff(board);
					num = -1832189704;
					continue;
				case 107u:
					Form1.smethod_32((Control)(object)richTextBox1, "Ничья!");
					num = ((int)num2 * -8055745) ^ 0x5269E645;
					continue;
				case 106u:
					array2 = (Figurine[,])Form1.smethod_48((Array)array3);
					num = ((int)num2 * -411888961) ^ 0x4DD68895;
					continue;
				case 105u:
					if (!flag15)
					{
						num = (int)((num2 * 1213264070) ^ 0x4E16D236);
						continue;
					}
					num16 = 1;
					goto IL_0513;
				case 104u:
				{
					int num58;
					int num59;
					if (flag14)
					{
						num58 = 2118646070;
						num59 = 2118646070;
					}
					else
					{
						num58 = 1358541079;
						num59 = 1358541079;
					}
					num = num58 ^ (int)(num2 * 415645361);
					continue;
				}
				case 103u:
					num24 = 0;
					num = ((int)num2 * -977082824) ^ 0x7EA28A06;
					continue;
				case 102u:
					num = ((int)num2 * -1600803147) ^ -535420987;
					continue;
				case 101u:
				{
					int num54;
					int num55;
					if (!flag16)
					{
						num54 = -1972963665;
						num55 = -1972963665;
					}
					else
					{
						num54 = -2124792624;
						num55 = -2124792624;
					}
					num = num54 ^ (int)(num2 * 290142807);
					continue;
				}
				case 100u:
				{
					int num52;
					int num53;
					if (flag13)
					{
						num52 = 1134175430;
						num53 = 1134175430;
					}
					else
					{
						num52 = 156827958;
						num53 = 156827958;
					}
					num = num52 ^ (int)(num2 * 1518168829);
					continue;
				}
				case 99u:
					num32 = 0;
					num = -1216707888;
					continue;
				case 98u:
					Form1.smethod_5((Control)(object)borderBox[num3, num4], Color.White);
					num = (int)(num2 * 1961639971) ^ -182068693;
					continue;
				case 97u:
					num = (int)((num2 * 1443929390) ^ 0x4C038813);
					continue;
				case 96u:
					num7 = 0;
					num = -2075429075;
					continue;
				case 95u:
					Form1.smethod_5((Control)(object)borderBox[num27, num32], Color.LimeGreen);
					num = (int)(num2 * 499576040) ^ -1259891152;
					continue;
				case 94u:
					Form1.smethod_30((Control)(object)pictureBox[num13, num23]);
					num = ((int)num2 * -1299692472) ^ 0x3F38DF88;
					continue;
				case 93u:
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: true);
					step++;
					Form1.smethod_32((Control)(object)label2, Form1.smethod_34("Ход: ", step.ToString()));
					num = ((int)num2 * -1641137597) ^ -1454340165;
					continue;
				case 92u:
					num13 = 0;
					num = ((int)num2 * -1703858051) ^ -628679187;
					continue;
				case 91u:
					num46 = 0;
					num47 = 0;
					num = (int)((num2 * 1856504538) ^ 0x7CD4AB2B);
					continue;
				case 90u:
					num3 = 0;
					num = (int)((num2 * 238002393) ^ 0x6F6BCF4A);
					continue;
				case 89u:
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: false);
					num = ((int)num2 * -206947642) ^ -368622449;
					continue;
				case 88u:
					flag = Form1.smethod_41((Control)(object)borderBox[num27, num32]) == Color.Red;
					num = (int)((num2 * 188951228) ^ 0x157B6B16);
					continue;
				case 87u:
					flag16 = num12 < 4;
					num = -480134361;
					continue;
				case 86u:
					flag15 = false;
					num = (int)((num2 * 802571089) ^ 0x780275CA);
					continue;
				case 85u:
					storage[num46, num47] = null;
					Paint_Board();
					num = ((int)num2 * -830713840) ^ 0x74F97D89;
					continue;
				case 84u:
					num = (int)(num2 * 959304368) ^ -845559877;
					continue;
				case 83u:
				{
					int num48;
					int num49;
					if (flag2)
					{
						num48 = 60781201;
						num49 = 60781201;
					}
					else
					{
						num48 = 1899929439;
						num49 = 1899929439;
					}
					num = num48 ^ (int)(num2 * 160399597);
					continue;
				}
				case 82u:
					flag14 = num23 < 4;
					num = -428724230;
					continue;
				case 81u:
					num = (int)(num2 * 1253200467) ^ -397093327;
					continue;
				case 80u:
					num12 = 0;
					num = -1886873255;
					continue;
				case 79u:
					num = -406173619;
					continue;
				case 78u:
					num = -1318519333;
					continue;
				case 77u:
					num4 = num32;
					num = ((int)num2 * -1175894305) ^ -2094705173;
					continue;
				case 76u:
					num = -1572032513;
					continue;
				case 75u:
					flag6 = Form1.smethod_46((Control)(object)pictureBox1);
					num = ((int)num2 * -1821276043) ^ 0x46CA7013;
					continue;
				case 74u:
					Form1.smethod_30((Control)(object)pictureBox[num3, num4]);
					num = ((int)num2 * -122183082) ^ -363117003;
					continue;
				case 73u:
					Form1.smethod_5((Control)(object)borderBox[num13, num23], Color.White);
					Form1.smethod_30((Control)(object)borderBox[num13, num23]);
					num = (int)((num2 * 1498667942) ^ 0x1B9BB7B1);
					continue;
				case 72u:
					num46 = num13;
					num47 = num23;
					num = (int)(num2 * 116041133) ^ -1764048813;
					continue;
				case 71u:
					num38++;
					num = (int)(num2 * 623595550) ^ -474600770;
					continue;
				case 70u:
					num = (int)(num2 * 1720861562) ^ -1706547670;
					continue;
				case 69u:
					num = ((int)num2 * -1968375079) ^ -844647423;
					continue;
				case 68u:
				{
					int num44;
					int num45;
					if (!flag11)
					{
						num44 = -1360928166;
						num45 = -1360928166;
					}
					else
					{
						num44 = -1141830689;
						num45 = -1141830689;
					}
					num = num44 ^ (int)(num2 * 991616231);
					continue;
				}
				case 67u:
					if (!Stop(array))
					{
						num = ((int)num2 * -2130910952) ^ 0x63AE1F9F;
						continue;
					}
					goto IL_0cd3;
				case 66u:
					Form1.smethod_15(timer1);
					num = -1856104950;
					continue;
				case 65u:
					Form1.smethod_7((Control)(object)pictureBox[num27, num32], bool_0: false);
					num = -1686829990;
					continue;
				case 64u:
					num15 = 0;
					num = (int)(num2 * 865471967) ^ -877425018;
					continue;
				case 63u:
					num = (int)((num2 * 904724342) ^ 0x45F06E17);
					continue;
				case 62u:
					num6 = Form1.smethod_33(rnd, 4);
					num = -1372078572;
					continue;
				case 61u:
					step++;
					num = -2101782224;
					continue;
				case 60u:
					num = ((int)num2 * -587217941) ^ -475994118;
					continue;
				case 59u:
					(menu as Form3).ContinueLock();
					num = (int)((num2 * 1468927398) ^ 0x255AF333);
					continue;
				case 58u:
					num = ((int)num2 * -1575441787) ^ 0x261EF621;
					continue;
				case 57u:
					Form1.smethod_30((Control)(object)borderBox[num3, num4]);
					Form1.smethod_20(pictureBox[num3, num4], (Image)null);
					num = (int)(num2 * 1137659457) ^ -1943621920;
					continue;
				case 56u:
					flag12 = array3[num38, num7] == null;
					num = -685939833;
					continue;
				case 55u:
					num = ((int)num2 * -1924249246) ^ -1649867643;
					continue;
				case 54u:
					num = (int)((num2 * 1838704755) ^ 0x53DD7EF2);
					continue;
				case 53u:
					flag11 = num10 < 4;
					num = -1301961706;
					continue;
				case 52u:
					Form1.smethod_32((Control)(object)richTextBox1, "Подождите, компьютер делает свой ход.");
					num = (int)(num2 * 988963538) ^ -433514069;
					continue;
				case 51u:
					flag5 = Standoff(board);
					num = ((int)num2 * -1774136543) ^ 0x1B90B3BD;
					continue;
				case 50u:
					num4 = 0;
					num = (int)(num2 * 1693964086) ^ -1992479943;
					continue;
				case 49u:
					array2[num38, num7] = new Figurine(storage[num28, num29]);
					flag10 = Stop(array2);
					num = ((int)num2 * -1121095270) ^ 0x249E9B47;
					continue;
				case 48u:
					num = ((int)num2 * -307127419) ^ 0x69FCF1D3;
					continue;
				case 47u:
					num = (int)((num2 * 579959072) ^ 0xFE6A1DB);
					continue;
				case 46u:
					num21 = ((!Standoff(board)) ? 1 : 0);
					goto IL_0f1d;
				case 45u:
					num43 = num13;
					num = ((int)num2 * -556351013) ^ 0x3D3A3B96;
					continue;
				case 44u:
					num22 = 0;
					num = ((int)num2 * -332288217) ^ -1009575264;
					continue;
				case 43u:
					board[num11, num12] = new Figurine(storage[num3, num4]);
					num = ((int)num2 * -788567117) ^ 0x54895C80;
					continue;
				case 42u:
					num12++;
					num = -1728288955;
					continue;
				case 41u:
					num = ((int)num2 * -455413018) ^ -1042203421;
					continue;
				case 40u:
					(menu as Form3).ContinueLock();
					num = ((int)num2 * -225721002) ^ 0x19CC409B;
					continue;
				case 39u:
					board[num6, num5] = new Figurine(storage[num3, num4]);
					num = (int)(num2 * 676954697) ^ -800640696;
					continue;
				case 38u:
					if (num29 == num4)
					{
						goto IL_0253;
					}
					goto IL_025f;
				case 37u:
				{
					int num39;
					int num40;
					if (!flag4)
					{
						num39 = -1214356201;
						num40 = -1214356201;
					}
					else
					{
						num39 = -325750083;
						num40 = -325750083;
					}
					num = num39 ^ (int)(num2 * 696133071);
					continue;
				}
				case 36u:
				{
					int num35;
					if (num13 >= 4)
					{
						num = -2133295786;
						num35 = -2133295786;
					}
					else
					{
						num = -1310665491;
						num35 = -1310665491;
					}
					continue;
				}
				case 35u:
					num32++;
					num = (int)(num2 * 1542231126) ^ -149551310;
					continue;
				case 34u:
					Form1.smethod_32((Control)(object)label2, Form1.smethod_34("Ход: ", step.ToString()));
					num = ((int)num2 * -484126469) ^ 0x39C14B82;
					continue;
				case 33u:
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox1));
					num11 = 0;
					num = ((int)num2 * -1194125161) ^ -965236886;
					continue;
				case 32u:
					num = ((int)num2 * -1259150769) ^ 0x63FC9FC3;
					continue;
				case 31u:
					num = ((int)num2 * -1975900172) ^ -425100133;
					continue;
				case 30u:
					num = ((int)num2 * -18036931) ^ 0x1B8C34E;
					continue;
				case 29u:
					num = (int)((num2 * 74078870) ^ 0x64911D);
					continue;
				case 28u:
					num3 = num27;
					num = ((int)num2 * -30366784) ^ -1675817745;
					continue;
				case 27u:
					Form1.smethod_30((Control)(object)pictureBox1);
					num = ((int)num2 * -2038818782) ^ 0x3F3BCED8;
					continue;
				case 26u:
					num = -1753885160;
					continue;
				case 25u:
					num = ((int)num2 * -164242208) ^ 0x425FAD2B;
					continue;
				case 24u:
				{
					int num33;
					int num34;
					if (flag8)
					{
						num33 = -656508980;
						num34 = -656508980;
					}
					else
					{
						num33 = -1596023738;
						num34 = -1596023738;
					}
					num = num33 ^ ((int)num2 * -1526177657);
					continue;
				}
				case 23u:
					num27 = 0;
					num = ((int)num2 * -281989723) ^ -1975929519;
					continue;
				case 22u:
				{
					int num30;
					int num31;
					if (flag6)
					{
						num30 = 1908063529;
						num31 = 1908063529;
					}
					else
					{
						num30 = 1375669789;
						num31 = 1375669789;
					}
					num = num30 ^ ((int)num2 * -1909728485);
					continue;
				}
				case 21u:
					num28 = Form1.smethod_33(rnd, 4);
					num29 = Form1.smethod_33(rnd, 4);
					num = (int)(num2 * 2021244394) ^ -342854451;
					continue;
				case 20u:
					Form1.smethod_30((Control)(object)borderBox[num28, num29]);
					num = (int)((num2 * 762360000) ^ 0x75A6E465);
					continue;
				case 19u:
					num = -308966480;
					continue;
				case 18u:
					Form1.smethod_30((Control)(object)borderBox[num3, num4]);
					Form1.smethod_20(pictureBox[num3, num4], (Image)null);
					num = (int)(num2 * 163009525) ^ -1327082702;
					continue;
				case 17u:
					Form1.smethod_44(graphics_, Form1.smethod_21(pictureBox[num3, num4]), num12 * size + 4, num11 * size + 4, new Rectangle(0, 0, size, size), (GraphicsUnit)2);
					num = ((int)num2 * -1915813657) ^ -2078071341;
					continue;
				case 16u:
					Form1.smethod_20(pictureBox[num13, num23], (Image)null);
					num = (int)((num2 * 206809389) ^ 0x1FC813A3);
					continue;
				case 15u:
					num = -1664478872;
					continue;
				case 14u:
					Form1.smethod_43(graphics_, Form1.smethod_42(Color.LimeGreen, 3f), ((float)num5 + 0.05f) * (float)size, ((float)num6 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					num = (int)(num2 * 1090906176) ^ -1698663229;
					continue;
				case 13u:
					if (storage[num28, num29] != null)
					{
						num = (int)((num2 * 1869811475) ^ 0x717AC30E);
						continue;
					}
					goto IL_0253;
				case 12u:
				{
					int num25;
					int num26;
					if (!flag5)
					{
						num25 = 127328750;
						num26 = 127328750;
					}
					else
					{
						num25 = 242664989;
						num26 = 242664989;
					}
					num = num25 ^ ((int)num2 * -1025267105);
					continue;
				}
				case 11u:
					num24 = num23;
					num = ((int)num2 * -31015486) ^ -1625184390;
					continue;
				case 10u:
					num = ((int)num2 * -1210017862) ^ 0xA137E1A;
					continue;
				case 9u:
					num = ((int)num2 * -2058756476) ^ -877172186;
					continue;
				case 8u:
					if (!Stop(board))
					{
						num = ((int)num2 * -1012746082) ^ -690908852;
						continue;
					}
					num21 = 0;
					goto IL_0f1d;
				case 7u:
					Form1.smethod_32((Control)(object)richTextBox1, "Противник сделал ход (зелёный). Выберете поле на доске для выбронной противником фигуры (синий).");
					num = (int)(num2 * 14335266) ^ -614867679;
					continue;
				case 6u:
				{
					num5 = Form1.smethod_33(rnd, 4);
					int num17;
					int num18;
					if (board[num6, num5] != null)
					{
						num17 = 498069870;
						num18 = 498069870;
					}
					else
					{
						num17 = 909830438;
						num18 = 909830438;
					}
					num = num17 ^ (int)(num2 * 2056197067);
					continue;
				}
				case 5u:
					if (!Standoff(array))
					{
						num = -324487192;
						num14 = -324487192;
						continue;
					}
					goto IL_0cd3;
				case 4u:
				{
					int num8;
					int num9;
					if (flag)
					{
						num8 = -716415695;
						num9 = -716415695;
					}
					else
					{
						num8 = -338786721;
						num9 = -338786721;
					}
					num = num8 ^ (int)(num2 * 2056588035);
					continue;
				}
				case 3u:
					num = ((int)num2 * -1115105237) ^ 0xB867BC7;
					continue;
				case 2u:
					num7++;
					num = -2075429075;
					continue;
				case 1u:
					num = ((int)num2 * -13463659) ^ 0x5319309;
					continue;
				case 0u:
					Form1.smethod_44(graphics_, Form1.smethod_21(pictureBox[num3, num4]), num5 * size + 4, num6 * size + 4, new Rectangle(0, 0, size, size), (GraphicsUnit)2);
					num = ((int)num2 * -1217462787) ^ 0x3F3DED7E;
					continue;
				default:
					return;
				case 141u:
					break;
				case 170u:
					return;
					IL_0513:
					flag4 = (byte)num16 != 0;
					num = -668115929;
					continue;
					IL_0253:
					num = -1564143500;
					num42 = -1564143500;
					continue;
					IL_0f1d:
					flag8 = (byte)num21 != 0;
					num = -372317174;
					continue;
					IL_0cd3:
					num = -1049347918;
					num14 = -1049347918;
					continue;
					IL_025f:
					num = -433028562;
					num42 = -433028562;
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
		bool result = default(bool);
		bool flag3 = default(bool);
		while (true)
		{
			int num2;
			int num3;
			if (num >= 4)
			{
				num2 = -824350701;
				num3 = -824350701;
			}
			else
			{
				num2 = -1186635295;
				num3 = -1186635295;
			}
			while (true)
			{
				uint num4;
				int num19;
				int num9;
				switch ((num4 = (uint)num2 ^ 0xE48565D8u) % 76u)
				{
				case 75u:
				{
					int num30;
					int num31;
					if (mem[1, 1] == null)
					{
						num30 = -1175665421;
						num31 = -1175665421;
					}
					else
					{
						num30 = -1787174136;
						num31 = -1787174136;
					}
					num2 = num30 ^ (int)(num4 * 436755529);
					continue;
				}
				case 74u:
				{
					int num29;
					if (mem[0, 0].Point != mem[1, 1].Point)
					{
						num2 = -947077194;
						num29 = -947077194;
					}
					else
					{
						num2 = -1294649068;
						num29 = -1294649068;
					}
					continue;
				}
				case 73u:
				{
					int num51;
					if (mem[0, num].Dark != mem[1, num].Dark)
					{
						num2 = -734290927;
						num51 = -734290927;
					}
					else
					{
						num2 = -1248474965;
						num51 = -1248474965;
					}
					continue;
				}
				case 72u:
				{
					int num56;
					int num57;
					if (mem[num, 3] == null)
					{
						num56 = -1861348539;
						num57 = -1861348539;
					}
					else
					{
						num56 = -2034778847;
						num57 = -2034778847;
					}
					num2 = num56 ^ (int)(num4 * 486206934);
					continue;
				}
				case 71u:
					if (mem[3, num] != null)
					{
						num2 = ((int)num4 * -554536254) ^ -833656203;
						continue;
					}
					goto IL_0104;
				case 70u:
				{
					int num34;
					int num35;
					if (flag2)
					{
						num34 = -128483565;
						num35 = -128483565;
					}
					else
					{
						num34 = -1639598231;
						num35 = -1639598231;
					}
					num2 = num34 ^ (int)(num4 * 1850666310);
					continue;
				}
				case 69u:
					result = flag;
					num2 = -1096943739;
					continue;
				case 68u:
					num2 = -1186635295;
					continue;
				case 67u:
					flag = true;
					num2 = (int)(num4 * 1140099435) ^ -369350584;
					continue;
				case 66u:
				{
					int num62;
					if (mem[0, 3].Dark == mem[1, 2].Dark)
					{
						num2 = -452860122;
						num62 = -452860122;
					}
					else
					{
						num2 = -1654554293;
						num62 = -1654554293;
					}
					continue;
				}
				case 65u:
				{
					int num52;
					int num53;
					if (mem[num, 1].Dark == mem[num, 2].Dark)
					{
						num52 = 1514085444;
						num53 = 1514085444;
					}
					else
					{
						num52 = 1526196167;
						num53 = 1526196167;
					}
					num2 = num52 ^ ((int)num4 * -901708818);
					continue;
				}
				case 64u:
				{
					int num44;
					int num45;
					if (mem[0, 3].Big != mem[1, 2].Big)
					{
						num44 = 1523833658;
						num45 = 1523833658;
					}
					else
					{
						num44 = 1614223813;
						num45 = 1614223813;
					}
					num2 = num44 ^ (int)(num4 * 2004361124);
					continue;
				}
				case 63u:
				{
					int num16;
					if (mem[0, 3].Point == mem[1, 2].Point)
					{
						num2 = -613751677;
						num16 = -613751677;
					}
					else
					{
						num2 = -1010740018;
						num16 = -1010740018;
					}
					continue;
				}
				case 62u:
					if (mem[0, num].Square == mem[1, num].Square)
					{
						num2 = -230104331;
						continue;
					}
					goto IL_027d;
				case 61u:
				{
					int num67;
					if (mem[0, num].Point != mem[1, num].Point)
					{
						num2 = -1528403578;
						num67 = -1528403578;
					}
					else
					{
						num2 = -562107865;
						num67 = -562107865;
					}
					continue;
				}
				case 60u:
					if (mem[2, 1].Dark != mem[3, 0].Dark)
					{
						num2 = (int)((num4 * 1015924667) ^ 0x439994D7);
						continue;
					}
					goto IL_02ea;
				case 59u:
					if (mem[2, num].Point != mem[3, num].Point)
					{
						num2 = ((int)num4 * -1537421340) ^ 0x2837A07A;
						continue;
					}
					goto IL_0326;
				case 58u:
				{
					int num42;
					int num43;
					if (mem[1, 2].Dark == mem[2, 1].Dark)
					{
						num42 = -1720778368;
						num43 = -1720778368;
					}
					else
					{
						num42 = -2044615673;
						num43 = -2044615673;
					}
					num2 = num42 ^ ((int)num4 * -2129071014);
					continue;
				}
				case 57u:
					if (mem[2, 2].Point != mem[3, 3].Point)
					{
						num2 = ((int)num4 * -1213358606) ^ 0x74361D64;
						continue;
					}
					goto IL_039c;
				case 56u:
				{
					int num25;
					int num26;
					if (mem[num, 1].Point != mem[num, 2].Point)
					{
						num25 = 390644907;
						num26 = 390644907;
					}
					else
					{
						num25 = 54878408;
						num26 = 54878408;
					}
					num2 = num25 ^ (int)(num4 * 142837657);
					continue;
				}
				case 55u:
					if (mem[num, 2].Big != mem[num, 3].Big)
					{
						num2 = ((int)num4 * -1315339770) ^ -272904142;
						continue;
					}
					goto IL_0412;
				case 54u:
					if (mem[1, 2] != null)
					{
						num2 = (int)((num4 * 1877883654) ^ 0x183DAD50);
						continue;
					}
					goto IL_0435;
				case 53u:
					if (mem[3, 0] != null)
					{
						num2 = (int)((num4 * 457227788) ^ 0x1E58619C);
						continue;
					}
					goto IL_0435;
				case 52u:
					if (mem[2, num] != null)
					{
						num2 = ((int)num4 * -410449780) ^ -322565809;
						continue;
					}
					goto IL_0104;
				case 51u:
					if (mem[2, num].Big != mem[3, num].Big)
					{
						num2 = ((int)num4 * -801312896) ^ -1252612947;
						continue;
					}
					goto IL_0326;
				case 50u:
					if (mem[0, 3].Square == mem[1, 2].Square)
					{
						num2 = -1808098003;
						continue;
					}
					goto IL_04d0;
				case 49u:
					flag = true;
					num2 = (int)(num4 * 995696602) ^ -1013896135;
					continue;
				case 48u:
					if (mem[0, 3] != null)
					{
						num2 = -1450256626;
						continue;
					}
					goto IL_0435;
				case 47u:
				{
					int num65;
					int num66;
					if (mem[0, 0] != null)
					{
						num65 = -1052028644;
						num66 = -1052028644;
					}
					else
					{
						num65 = -2031775841;
						num66 = -2031775841;
					}
					num2 = num65 ^ (int)(num4 * 723439869);
					continue;
				}
				case 46u:
					num19 = ((mem[2, 1].Square == mem[3, 0].Square) ? 1 : 0);
					goto IL_02eb;
				case 45u:
					if (mem[1, num].Square == mem[2, num].Square)
					{
						num2 = (int)((num4 * 757724117) ^ 0x4BB60687);
						continue;
					}
					goto IL_027d;
				case 43u:
				{
					int num58;
					int num59;
					if (mem[0, num].Big == mem[1, num].Big)
					{
						num58 = -786381482;
						num59 = -786381482;
					}
					else
					{
						num58 = -521975194;
						num59 = -521975194;
					}
					num2 = num58 ^ ((int)num4 * -1291513543);
					continue;
				}
				case 42u:
					if (mem[num, 2].Dark != mem[num, 3].Dark)
					{
						num2 = (int)(num4 * 1890539696) ^ -546994711;
						continue;
					}
					goto IL_0412;
				case 41u:
				{
					int num47;
					int num48;
					if (mem[1, num].Big != mem[2, num].Big)
					{
						num47 = -934345897;
						num48 = -934345897;
					}
					else
					{
						num47 = -228504835;
						num48 = -228504835;
					}
					num2 = num47 ^ (int)(num4 * 1014292786);
					continue;
				}
				case 40u:
				{
					int num40;
					int num41;
					if (mem[1, 1].Square == mem[2, 2].Square)
					{
						num40 = -1241076086;
						num41 = -1241076086;
					}
					else
					{
						num40 = -478540544;
						num41 = -478540544;
					}
					num2 = num40 ^ (int)(num4 * 666542691);
					continue;
				}
				case 39u:
				{
					int num36;
					int num37;
					if (mem[1, num].Dark == mem[2, num].Dark)
					{
						num36 = 2059968202;
						num37 = 2059968202;
					}
					else
					{
						num36 = 1684261052;
						num37 = 1684261052;
					}
					num2 = num36 ^ ((int)num4 * -1510314657);
					continue;
				}
				case 38u:
					if (mem[2, 1].Big != mem[3, 0].Big)
					{
						num2 = ((int)num4 * -1780929818) ^ -2073495090;
						continue;
					}
					goto IL_02ea;
				case 37u:
					num++;
					num2 = ((int)num4 * -1228439930) ^ 0x7FE3EB76;
					continue;
				case 35u:
				{
					int num24;
					if (mem[num, 0].Square == mem[num, 1].Square)
					{
						num2 = -1178805277;
						num24 = -1178805277;
					}
					else
					{
						num2 = -1255295907;
						num24 = -1255295907;
					}
					continue;
				}
				case 34u:
				{
					int num21;
					if (mem[0, 0].Dark == mem[1, 1].Dark)
					{
						num2 = -1429285368;
						num21 = -1429285368;
					}
					else
					{
						num2 = -654777918;
						num21 = -654777918;
					}
					continue;
				}
				case 33u:
					if (mem[2, 2].Dark != mem[3, 3].Dark)
					{
						num2 = ((int)num4 * -354714262) ^ -1770411120;
						continue;
					}
					goto IL_039c;
				case 32u:
					if (mem[2, 2].Big != mem[3, 3].Big)
					{
						num2 = (int)(num4 * 1546664561) ^ -490927162;
						continue;
					}
					goto IL_039c;
				case 31u:
				{
					int num12;
					int num13;
					if (mem[num, 0] != null)
					{
						num12 = 1590087470;
						num13 = 1590087470;
					}
					else
					{
						num12 = 574327209;
						num13 = 574327209;
					}
					num2 = num12 ^ ((int)num4 * -1774284484);
					continue;
				}
				case 30u:
				{
					int num7;
					int num8;
					if (mem[num, 1] != null)
					{
						num7 = 2129224846;
						num8 = 2129224846;
					}
					else
					{
						num7 = 1823030261;
						num8 = 1823030261;
					}
					num2 = num7 ^ ((int)num4 * -727301676);
					continue;
				}
				case 29u:
					num2 = (int)((num4 * 407910238) ^ 0x2129029E);
					continue;
				case 28u:
					if (mem[num, 2].Point != mem[num, 3].Point)
					{
						num2 = ((int)num4 * -18190667) ^ -612666037;
						continue;
					}
					goto IL_0412;
				case 27u:
					if (mem[2, num].Dark != mem[3, num].Dark)
					{
						num2 = ((int)num4 * -2055143314) ^ 0x43AB1803;
						continue;
					}
					goto IL_0326;
				case 26u:
				{
					int num71;
					int num72;
					if (mem[num, 2] == null)
					{
						num71 = 978884631;
						num72 = 978884631;
					}
					else
					{
						num71 = 1871046198;
						num72 = 1871046198;
					}
					num2 = num71 ^ ((int)num4 * -313469861);
					continue;
				}
				case 25u:
				{
					int num70;
					if (mem[num, 0].Point != mem[num, 1].Point)
					{
						num2 = -1783812721;
						num70 = -1783812721;
					}
					else
					{
						num2 = -550191844;
						num70 = -550191844;
					}
					continue;
				}
				case 24u:
				{
					int num68;
					int num69;
					if (mem[num, 1].Big != mem[num, 2].Big)
					{
						num68 = -1453111576;
						num69 = -1453111576;
					}
					else
					{
						num68 = -716813717;
						num69 = -716813717;
					}
					num2 = num68 ^ ((int)num4 * -1942769794);
					continue;
				}
				case 23u:
				{
					int num63;
					int num64;
					if (mem[3, 3] != null)
					{
						num63 = -172782240;
						num64 = -172782240;
					}
					else
					{
						num63 = -349701998;
						num64 = -349701998;
					}
					num2 = num63 ^ ((int)num4 * -480262722);
					continue;
				}
				case 22u:
					if (mem[2, 2].Square != mem[3, 3].Square)
					{
						num2 = ((int)num4 * -86797509) ^ 0x5067EEE6;
						continue;
					}
					goto IL_039c;
				case 21u:
					if (mem[1, num] != null)
					{
						num2 = (int)((num4 * 462391052) ^ 0x12095730);
						continue;
					}
					goto IL_0104;
				case 20u:
				{
					int num60;
					int num61;
					if (mem[1, 1].Point == mem[2, 2].Point)
					{
						num60 = -2046112831;
						num61 = -2046112831;
					}
					else
					{
						num60 = -1352495010;
						num61 = -1352495010;
					}
					num2 = num60 ^ ((int)num4 * -246686690);
					continue;
				}
				case 19u:
				{
					int num54;
					int num55;
					if (mem[1, 2].Point == mem[2, 1].Point)
					{
						num54 = 1775904959;
						num55 = 1775904959;
					}
					else
					{
						num54 = 1073695559;
						num55 = 1073695559;
					}
					num2 = num54 ^ (int)(num4 * 488371179);
					continue;
				}
				case 18u:
				{
					int num49;
					int num50;
					if (mem[0, 0].Big != mem[1, 1].Big)
					{
						num49 = -1350652932;
						num50 = -1350652932;
					}
					else
					{
						num49 = -956912040;
						num50 = -956912040;
					}
					num2 = num49 ^ (int)(num4 * 1037156295);
					continue;
				}
				case 17u:
					if (mem[1, 2].Square == mem[2, 1].Square)
					{
						num2 = ((int)num4 * -1839887559) ^ 0x2FE4814F;
						continue;
					}
					goto IL_04d0;
				case 16u:
				{
					int num46;
					if (mem[num, 0].Dark == mem[num, 1].Dark)
					{
						num2 = -984140919;
						num46 = -984140919;
					}
					else
					{
						num2 = -405285495;
						num46 = -405285495;
					}
					continue;
				}
				case 15u:
					num2 = -1132155687;
					continue;
				case 14u:
					num9 = ((mem[2, num].Square == mem[3, num].Square) ? 1 : 0);
					goto IL_0105;
				case 13u:
					num2 = -1293933141;
					continue;
				case 12u:
				{
					int num38;
					int num39;
					if (flag3)
					{
						num38 = -1766102507;
						num39 = -1766102507;
					}
					else
					{
						num38 = -1584512417;
						num39 = -1584512417;
					}
					num2 = num38 ^ ((int)num4 * -1460534131);
					continue;
				}
				case 11u:
				{
					int num32;
					int num33;
					if (mem[1, num].Point == mem[2, num].Point)
					{
						num32 = -1732704109;
						num33 = -1732704109;
					}
					else
					{
						num32 = -1616474886;
						num33 = -1616474886;
					}
					num2 = num32 ^ (int)(num4 * 1863670404);
					continue;
				}
				case 10u:
					if (mem[2, 1].Point != mem[3, 0].Point)
					{
						num2 = ((int)num4 * -748375221) ^ 0x10B6E174;
						continue;
					}
					goto IL_02ea;
				case 9u:
				{
					int num27;
					int num28;
					if (mem[1, 2].Big == mem[2, 1].Big)
					{
						num27 = 868801015;
						num28 = 868801015;
					}
					else
					{
						num27 = 319412059;
						num28 = 319412059;
					}
					num2 = num27 ^ (int)(num4 * 1371163733);
					continue;
				}
				case 8u:
					if (mem[2, 1] != null)
					{
						num2 = ((int)num4 * -213908644) ^ -1936623703;
						continue;
					}
					goto IL_0435;
				case 7u:
				{
					int num22;
					int num23;
					if (mem[num, 1].Square != mem[num, 2].Square)
					{
						num22 = 445282443;
						num23 = 445282443;
					}
					else
					{
						num22 = 474742006;
						num23 = 474742006;
					}
					num2 = num22 ^ (int)(num4 * 997198626);
					continue;
				}
				case 6u:
				{
					int num20;
					if (mem[0, 0].Square != mem[1, 1].Square)
					{
						num2 = -1646191104;
						num20 = -1646191104;
					}
					else
					{
						num2 = -223415080;
						num20 = -223415080;
					}
					continue;
				}
				case 5u:
				{
					int num17;
					int num18;
					if (mem[num, 0].Big == mem[num, 1].Big)
					{
						num17 = 1445999020;
						num18 = 1445999020;
					}
					else
					{
						num17 = 2051599760;
						num18 = 2051599760;
					}
					num2 = num17 ^ ((int)num4 * -186808800);
					continue;
				}
				case 4u:
				{
					int num14;
					int num15;
					if (mem[1, 1].Dark == mem[2, 2].Dark)
					{
						num14 = -487306547;
						num15 = -487306547;
					}
					else
					{
						num14 = -1232982030;
						num15 = -1232982030;
					}
					num2 = num14 ^ (int)(num4 * 672336543);
					continue;
				}
				case 3u:
				{
					int num10;
					int num11;
					if (mem[2, 2] != null)
					{
						num10 = 1629513758;
						num11 = 1629513758;
					}
					else
					{
						num10 = 1232028945;
						num11 = 1232028945;
					}
					num2 = num10 ^ (int)(num4 * 544724283);
					continue;
				}
				case 2u:
				{
					int num5;
					int num6;
					if (mem[1, 1].Big != mem[2, 2].Big)
					{
						num5 = -784191766;
						num6 = -784191766;
					}
					else
					{
						num5 = -1938571212;
						num6 = -1938571212;
					}
					num2 = num5 ^ ((int)num4 * -716129080);
					continue;
				}
				case 1u:
					if (mem[0, num] != null)
					{
						num2 = -893346099;
						continue;
					}
					goto IL_0104;
				case 0u:
					if (mem[num, 2].Square != mem[num, 3].Square)
					{
						num2 = ((int)num4 * -2038502056) ^ 0x5F1911D;
						continue;
					}
					goto IL_0412;
				case 44u:
					break;
				default:
					{
						return result;
					}
					IL_027d:
					num9 = 0;
					goto IL_0105;
					IL_0435:
					num19 = 0;
					goto IL_02eb;
					IL_0412:
					num9 = 1;
					goto IL_0105;
					IL_039c:
					num19 = 1;
					goto IL_02eb;
					IL_0326:
					num9 = 1;
					goto IL_0105;
					IL_02ea:
					num19 = 1;
					goto IL_02eb;
					IL_02eb:
					flag2 = (byte)num19 != 0;
					num2 = -108750954;
					continue;
					IL_0104:
					num9 = 0;
					goto IL_0105;
					IL_0105:
					flag3 = (byte)num9 != 0;
					num2 = -157596972;
					continue;
					IL_04d0:
					num19 = 0;
					goto IL_02eb;
				}
				break;
			}
		}
	}

	private bool Standoff(Figurine[,] mem)
	{
		bool flag2 = default(bool);
		int num6 = default(int);
		int num5 = default(int);
		bool flag3 = default(bool);
		bool flag = default(bool);
		bool result = default(bool);
		while (true)
		{
			int num = -1584623308;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA94F0264u) % 17u)
				{
				case 16u:
					num = ((int)num2 * -679584854) ^ -147285332;
					continue;
				case 14u:
					flag2 = mem[num6, num5] == null;
					num = -245019541;
					continue;
				case 12u:
				{
					int num9;
					if (num6 < 4)
					{
						num = -1566197503;
						num9 = -1566197503;
					}
					else
					{
						num = -2145898111;
						num9 = -2145898111;
					}
					continue;
				}
				case 11u:
					flag3 = num5 < 4;
					num = -263696803;
					continue;
				case 10u:
					num5++;
					num = -157174708;
					continue;
				case 9u:
					num = (int)(num2 * 1384058786) ^ -44387026;
					continue;
				case 8u:
				{
					int num7;
					int num8;
					if (flag3)
					{
						num7 = -816049607;
						num8 = -816049607;
					}
					else
					{
						num7 = -730733139;
						num8 = -730733139;
					}
					num = num7 ^ ((int)num2 * -459139297);
					continue;
				}
				case 7u:
					num = ((int)num2 * -1127621655) ^ 0x480DA3C4;
					continue;
				case 6u:
					num5 = 0;
					num = -201552852;
					continue;
				case 5u:
					flag = true;
					num = ((int)num2 * -994401710) ^ 0x6F7AB69;
					continue;
				case 4u:
					num6++;
					num = ((int)num2 * -1676038291) ^ -1764634636;
					continue;
				case 3u:
					num6 = 0;
					num = (int)(num2 * 341932974) ^ -1259208519;
					continue;
				case 2u:
				{
					int num3;
					int num4;
					if (flag2)
					{
						num3 = -1587098110;
						num4 = -1587098110;
					}
					else
					{
						num3 = -934639119;
						num4 = -934639119;
					}
					num = num3 ^ ((int)num2 * -1713064707);
					continue;
				}
				case 1u:
					flag = false;
					num = ((int)num2 * -806474293) ^ -1402499675;
					continue;
				case 0u:
					result = flag;
					num = (int)((num2 * 1688987348) ^ 0x28B0DEF8);
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
		Form1.smethod_32((Control)(object)label5, "Игрок: ");
		while (true)
		{
			int num = -1946570871;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB585B897u) % 9u)
				{
				case 8u:
					Form1.smethod_32((Control)(object)label6, str);
					num = (int)(num2 * 1428072903) ^ -659490240;
					continue;
				case 7u:
					num = (int)((num2 * 1201389113) ^ 0x366C1369);
					continue;
				case 6u:
					Form1.smethod_32((Control)(object)label2, "");
					num = ((int)num2 * -1356510824) ^ 0x114D2F5E;
					continue;
				case 5u:
					Form1.smethod_50((Control)(object)label6, Form1.smethod_37((Control)(object)label5).X + Form1.smethod_18((Control)(object)label5));
					num = ((int)num2 * -113418726) ^ -1588799785;
					continue;
				case 4u:
					num = (int)(num2 * 858852333) ^ -1683377799;
					continue;
				case 1u:
					Form1.smethod_32((Control)(object)label1, "");
					num = ((int)num2 * -1270798756) ^ -526464323;
					continue;
				case 0u:
					Form1.smethod_50((Control)(object)label5, (Form1.smethod_49((Control)(object)this) - (Form1.smethod_18((Control)(object)label5) + Form1.smethod_18((Control)(object)label6))) / 2);
					num = (int)((num2 * 861553812) ^ 0xD4FEF7D);
					continue;
				default:
					return;
				case 2u:
					break;
				case 3u:
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
			int num = -1465631868;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0x84D04149u) % 11u)
				{
				case 10u:
					num = ((int)num2 * -1480027397) ^ -1905648315;
					continue;
				case 9u:
					if (disposing)
					{
						num = ((int)num2 * -385667908) ^ 0x3480F1DF;
						continue;
					}
					num3 = 0;
					goto IL_002e;
				case 8u:
					Form1.smethod_51((IDisposable)components);
					num = (int)((num2 * 1891877011) ^ 0xED349BE);
					continue;
				case 7u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = -992983582;
						num5 = -992983582;
					}
					else
					{
						num4 = -1256580643;
						num5 = -1256580643;
					}
					num = num4 ^ ((int)num2 * -1398975077);
					continue;
				}
				case 6u:
					((Form)this).Dispose(disposing);
					num = -33437971;
					continue;
				case 4u:
					num = ((int)num2 * -1954289665) ^ 0x5B3D0BC1;
					continue;
				case 2u:
					num = (int)((num2 * 1715530246) ^ 0x11E18E74);
					continue;
				case 1u:
					num3 = ((components != null) ? 1 : 0);
					goto IL_002e;
				case 0u:
					num = ((int)num2 * -2002118031) ^ -1332416237;
					continue;
				default:
					return;
				case 3u:
					break;
				case 5u:
					return;
					IL_002e:
					flag = (byte)num3 != 0;
					num = -322679088;
					continue;
				}
				break;
			}
		}
	}

	private void InitializeComponent()
	{
		//IL_090f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0919: Expected O, but got Unknown
		components = Form1.smethod_52();
		pictureBox1 = Form1.smethod_2();
		string string_ = default(string);
		int num3 = default(int);
		byte[] array = default(byte[]);
		object[] object_ = default(object[]);
		while (true)
		{
			int num = 1640441446;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x10DD3474u) % 141u)
				{
				case 140u:
					num = ((int)num2 * -757560074) ^ -678567014;
					continue;
				case 139u:
					Form1.smethod_3((Control)(object)label1, new Size(0, 16));
					num = (int)((num2 * 1682158968) ^ 0x2E8A17C7);
					continue;
				case 138u:
					Form1.smethod_86((Form)(object)this, bool_0: false);
					Form1.smethod_32((Control)(object)this, "Quarto");
					num = ((int)num2 * -879692684) ^ -970487388;
					continue;
				case 137u:
					Form1.smethod_32((Control)(object)button2, "Подтвердить");
					num = ((int)num2 * -862940131) ^ -1589937044;
					continue;
				case 136u:
					Form1.smethod_89((Control)(object)this, (EventHandler)Form1_LocationChanged);
					num = (int)((num2 * 384840868) ^ 0x540952DC);
					continue;
				case 135u:
					Form1.smethod_61((Control)(object)label2, "label2");
					num = ((int)num2 * -1995853579) ^ -1571703212;
					continue;
				case 134u:
					num = ((int)num2 * -753052412) ^ 0x676EBB8C;
					continue;
				case 133u:
					num = (int)((num2 * 1507661394) ^ 0x4247B907);
					continue;
				case 132u:
					string_ = Form1.smethod_34(string_, Veet.Xe);
					num = (int)(num2 * 613271244) ^ -1033939615;
					continue;
				case 131u:
					Form1.smethod_65((Control)(object)button1, bool_0: false);
					num = (int)((num2 * 1079970603) ^ 0x3EE37F84);
					continue;
				case 130u:
					Form1.smethod_61((Control)(object)label1, "label1");
					num = (int)((num2 * 1060465319) ^ 0xBD6C598);
					continue;
				case 129u:
					num = ((int)num2 * -1034033365) ^ 0x3B9570C4;
					continue;
				case 128u:
					Form1.smethod_74((Control)(object)label6, bool_0: true);
					num = (int)((num2 * 984105846) ^ 0xADF8785);
					continue;
				case 127u:
					num = (int)((num2 * 1841203830) ^ 0x927DB1C);
					continue;
				case 126u:
					Form1.smethod_64((Control)(object)label2, 9);
					Form1.smethod_74((Control)(object)label5, bool_0: true);
					num = (int)((num2 * 2078347713) ^ 0x1ACD8DAB);
					continue;
				case 125u:
					Form1.smethod_3((Control)(object)label6, new Size(0, 16));
					num = (int)(num2 * 289906575) ^ -528393168;
					continue;
				case 124u:
					num = ((int)num2 * -19746896) ^ -1409582181;
					continue;
				case 123u:
					Form1.smethod_5((Control)(object)richTextBox1, Color.White);
					num = (int)(num2 * 1729151341) ^ -774682208;
					continue;
				case 122u:
					num = ((int)num2 * -694285845) ^ -1298322368;
					continue;
				case 121u:
					Form1.smethod_4((Control)(object)label5, new Point(197, 0));
					num = (int)(num2 * 1398368487) ^ -1514435190;
					continue;
				case 120u:
					num = (int)((num2 * 199211650) ^ 0x646B0F71);
					continue;
				case 119u:
					num = (int)(num2 * 553901854) ^ -1689252083;
					continue;
				case 118u:
					num = ((int)num2 * -1123461492) ^ -1852491423;
					continue;
				case 117u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)richTextBox1);
					num = (int)((num2 * 1742126580) ^ 0xCFB7D17);
					continue;
				case 116u:
					Form1.smethod_67((Control)(object)button1, (EventHandler)Button1_Click);
					num = (int)((num2 * 1017199381) ^ 0x18EBE84);
					continue;
				case 115u:
					num = ((int)num2 * -275731326) ^ 0x77DA3A48;
					continue;
				case 114u:
					Form1.smethod_58((ISupportInitialize)pictureBox1);
					Form1.smethod_59((Control)(object)this);
					num = (int)((num2 * 26040088) ^ 0x63B397D);
					continue;
				case 113u:
					Form1.smethod_3((Control)(object)label5, new Size(0, 16));
					num = (int)(num2 * 904513349) ^ -937582297;
					continue;
				case 112u:
					num = ((int)num2 * -464682042) ^ 0x43DCB4EE;
					continue;
				case 111u:
					Form1.smethod_61((Control)(object)button2, "button2");
					num = ((int)num2 * -1466488032) ^ -1600648304;
					continue;
				case 110u:
					num = (int)(num2 * 1170017761) ^ -1414332558;
					continue;
				case 109u:
					Form1.smethod_77((Control)(object)label1, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = ((int)num2 * -1013843543) ^ 0x464A855D;
					continue;
				case 108u:
					Form1.smethod_87((Form)(object)this, (EventHandler)Form1_Load);
					num = ((int)num2 * -1511587141) ^ -1018850105;
					continue;
				case 107u:
					num = ((int)num2 * -1370943919) ^ 0x4CD2D146;
					continue;
				case 106u:
					Form1.smethod_64((Control)(object)label6, 13);
					Form1.smethod_79((ContainerControl)(object)this, new SizeF(6f, 13f));
					num = (int)(num2 * 1453449625) ^ -434394701;
					continue;
				case 105u:
					num3++;
					num = (int)((num2 * 1359536355) ^ 0x2FF18903);
					continue;
				case 104u:
					array[num3] = Form1.smethod_69(Form1.smethod_68(string_, num3 * 2, 2), 16);
					num = (int)(num2 * 437761722) ^ -163671320;
					continue;
				case 103u:
					button2 = Form1.smethod_53();
					num = ((int)num2 * -1388881566) ^ 0x1E27B9D4;
					continue;
				case 102u:
					Form1.smethod_32((Control)(object)button1, "Меню");
					Form1.smethod_66((ButtonBase)(object)button1, bool_0: true);
					num = (int)(num2 * 1625518508) ^ -1094135202;
					continue;
				case 101u:
					num = ((int)num2 * -1079335205) ^ 0x1D47848C;
					continue;
				case 100u:
					Form1.smethod_3((Control)(object)panel1, new Size(486, 240));
					num = ((int)num2 * -489499743) ^ -1098932890;
					continue;
				case 98u:
					Form1.smethod_3((Control)(object)label2, new Size(0, 16));
					num = ((int)num2 * -1552983005) ^ -799806342;
					continue;
				case 97u:
					num = (int)((num2 * 811808885) ^ 0x651A9416);
					continue;
				case 96u:
				{
					int num4;
					if (num3 < 22528)
					{
						num = 1685152378;
						num4 = 1685152378;
					}
					else
					{
						num = 170783458;
						num4 = 170783458;
					}
					continue;
				}
				case 95u:
					Form1.smethod_3((Control)(object)pictureBox1, new Size(246, 246));
					num = (int)((num2 * 1354064260) ^ 0x17A15373);
					continue;
				case 94u:
					Form1.smethod_64((Control)(object)panel1, 7);
					num = ((int)num2 * -997009828) ^ 0x57358657;
					continue;
				case 93u:
					Form1.smethod_4((Control)(object)panel1, new Point(0, 24));
					num = (int)(num2 * 1126051249) ^ -1539870399;
					continue;
				case 92u:
					string_ = Veet.Sa;
					num = (int)(num2 * 2031174111) ^ -1994906126;
					continue;
				case 91u:
					num = ((int)num2 * -1598738952) ^ 0xC2CD82;
					continue;
				case 90u:
					Form1.smethod_75((Control)(object)label2, (DockStyle)3);
					num = ((int)num2 * -2009285441) ^ 0x7DABFE0A;
					continue;
				case 89u:
					Form1.smethod_75((Control)(object)label1, (DockStyle)4);
					num = ((int)num2 * -972134410) ^ -1268001257;
					continue;
				case 88u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)panel1);
					num = ((int)num2 * -1264550591) ^ -607848434;
					continue;
				case 87u:
					Form1.smethod_72(timer1, 1000);
					num = (int)((num2 * 687006223) ^ 0x3D0290E9);
					continue;
				case 86u:
					Form1.smethod_88((Form)(object)this, (EventHandler)Form1_Shown);
					num = (int)(num2 * 700764779) ^ -387835784;
					continue;
				case 85u:
					num = (int)((num2 * 993178614) ^ 0x3992B3C9);
					continue;
				case 84u:
					num = (int)(num2 * 487147048) ^ -1375732189;
					continue;
				case 83u:
					num = ((int)num2 * -1318573495) ^ -1688547945;
					continue;
				case 82u:
					Form1.smethod_61((Control)(object)panel1, "panel1");
					num = (int)((num2 * 1874198841) ^ 0x29A2A669);
					continue;
				case 81u:
					Form1.smethod_61((Control)(object)label5, "label5");
					num = ((int)num2 * -604543713) ^ 0x4C059369;
					continue;
				case 80u:
					num = (int)((num2 * 855004784) ^ 0x7415EDBE);
					continue;
				case 79u:
					Form1.smethod_81((Form)(object)this, new Size(486, 319));
					num = (int)((num2 * 2074690539) ^ 0x78F459EF);
					continue;
				case 78u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label5);
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label2);
					num = ((int)num2 * -152040787) ^ 0x77FB1025;
					continue;
				case 77u:
					num = ((int)num2 * -1673005236) ^ -1638620216;
					continue;
				case 76u:
					Form1.smethod_71((TextBoxBase)(object)richTextBox1, bool_0: true);
					num = (int)((num2 * 1195098719) ^ 0x5CD695E5);
					continue;
				case 75u:
					num = ((int)num2 * -1521435151) ^ -195971437;
					continue;
				case 74u:
					Form1.smethod_80((ContainerControl)(object)this, (AutoScaleMode)1);
					num = ((int)num2 * -3089112) ^ -85896226;
					continue;
				case 73u:
					Form1.smethod_4((Control)(object)pictureBox1, new Point(120, 22));
					num = ((int)num2 * -51935290) ^ 0x10F93B5C;
					continue;
				case 72u:
					Form1.smethod_91((Control)(object)this, bool_0: false);
					Form1.smethod_92((Control)(object)this);
					num = ((int)num2 * -486885298) ^ -1643360312;
					continue;
				case 71u:
					Form1.smethod_32((Control)(object)richTextBox1, "");
					num = (int)(num2 * 1502927173) ^ -1556140339;
					continue;
				case 70u:
					Form1.smethod_61((Control)(object)pictureBox1, "pictureBox1");
					num = ((int)num2 * -624722785) ^ 0x6A6F5442;
					continue;
				case 69u:
					num = ((int)num2 * -1882535779) ^ 0x71562FD;
					continue;
				case 68u:
					num = (int)(num2 * 313709028) ^ -252525167;
					continue;
				case 67u:
					Form1.smethod_64((Control)(object)label5, 12);
					num = ((int)num2 * -1034431383) ^ -1799917449;
					continue;
				case 66u:
					Form1.smethod_4((Control)(object)button2, new Point(391, 275));
					num = ((int)num2 * -1976837399) ^ -1204059018;
					continue;
				case 65u:
					Form1.smethod_6((Control)(object)pictureBox1, new MouseEventHandler(PictureBox1_MouseDown));
					num = (int)(num2 * 1253549761) ^ -1243208206;
					continue;
				case 64u:
					Form1.smethod_61((Control)(object)label6, "label6");
					num = ((int)num2 * -1836367802) ^ 0x787D73AD;
					continue;
				case 63u:
					Form1.smethod_4((Control)(object)label6, new Point(275, 0));
					num = (int)((num2 * 1052815433) ^ 0x220455FB);
					continue;
				case 62u:
					Form1.smethod_64((Control)(object)button2, 4);
					Form1.smethod_65((Control)(object)button2, bool_0: false);
					num = (int)((num2 * 52700333) ^ 0xD5672A8);
					continue;
				case 61u:
					Form1.smethod_66((ButtonBase)(object)button2, bool_0: true);
					num = ((int)num2 * -2056412549) ^ -1500591426;
					continue;
				case 60u:
					num = ((int)num2 * -1371129453) ^ 0x29523755;
					continue;
				case 58u:
					Form1.smethod_4((Control)(object)label1, new Point(486, 0));
					num = (int)((num2 * 472269534) ^ 0x602E35E2);
					continue;
				case 57u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label6);
					num = (int)(num2 * 959450050) ^ -985313048;
					continue;
				case 56u:
					Form1.smethod_61((Control)(object)button1, "button1");
					num = ((int)num2 * -1993724915) ^ 0x49FC6BD7;
					continue;
				case 55u:
					num = ((int)num2 * -519550336) ^ 0x365EA4B2;
					continue;
				case 54u:
					Form1.smethod_60(pictureBox1, (BorderStyle)2);
					num = (int)((num2 * 821761469) ^ 0x8017F9);
					continue;
				case 53u:
					Form1.smethod_64((Control)(object)button1, 5);
					num = ((int)num2 * -1545036494) ^ -2146501376;
					continue;
				case 52u:
					Form1.smethod_5((Control)(object)pictureBox1, Color.FromArgb(64, 32, 0));
					num = (int)(num2 * 1613038372) ^ -97536761;
					continue;
				case 51u:
					Form1.smethod_70(ComMember, object_);
					num = ((int)num2 * -1583402950) ^ 0x232A58A8;
					continue;
				case 50u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)pictureBox1);
					num = ((int)num2 * -2083001571) ^ -1264402622;
					continue;
				case 49u:
					num = (int)((num2 * 1107661829) ^ 0x48D25AE);
					continue;
				case 48u:
					Form1.smethod_78((Control)(object)label1, (RightToLeft)0);
					num = (int)(num2 * 1966404117) ^ -1991730035;
					continue;
				case 47u:
					Form1.smethod_61((Control)(object)richTextBox1, "richTextBox1");
					num = ((int)num2 * -1721848634) ^ 0x32E20BCD;
					continue;
				case 46u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label1);
					num = (int)(num2 * 806061995) ^ -1363072946;
					continue;
				case 45u:
					Form1.smethod_3((Control)(object)richTextBox1, new Size(272, 35));
					num = (int)(num2 * 1459833128) ^ -1489138463;
					continue;
				case 44u:
					Form1.smethod_77((Control)(object)label2, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					Form1.smethod_4((Control)(object)label2, new Point(0, 0));
					num = ((int)num2 * -1218095668) ^ -1752084059;
					continue;
				case 43u:
					num = ((int)num2 * -2143390455) ^ -198338915;
					continue;
				case 42u:
					Form1.smethod_65((Control)(object)richTextBox1, bool_0: false);
					num = ((int)num2 * -304040026) ^ -810924155;
					continue;
				case 41u:
					num = ((int)num2 * -751805141) ^ 0x28DAAA0;
					continue;
				case 40u:
					label2 = Form1.smethod_57();
					num = (int)((num2 * 696865140) ^ 0x67976822);
					continue;
				case 39u:
					num = ((int)num2 * -1705128654) ^ 0x31E9C0BC;
					continue;
				case 38u:
					Form1.smethod_4((Control)(object)richTextBox1, new Point(107, 275));
					num = (int)(num2 * 330117288) ^ -2069562959;
					continue;
				case 37u:
					Form1.smethod_4((Control)(object)button1, new Point(12, 275));
					num = ((int)num2 * -1238083115) ^ -1054067966;
					continue;
				case 36u:
					Form1.smethod_62(pictureBox1, 0);
					num = (int)((num2 * 753029807) ^ 0x7C80E54);
					continue;
				case 35u:
					num = ((int)num2 * -356802430) ^ -9238081;
					continue;
				case 34u:
					Form1.smethod_73(timer1, (EventHandler)Timer1_Tick);
					Form1.smethod_74((Control)(object)label1, bool_0: true);
					num = ((int)num2 * -1098515999) ^ -51656157;
					continue;
				case 33u:
					Form1.smethod_74((Control)(object)label2, bool_0: true);
					num = ((int)num2 * -946158283) ^ 0x7C8588E8;
					continue;
				case 32u:
					CharArray(array, string.Empty);
					object_ = new object[3]
					{
						Player.MembershipCondition(0),
						Player.MembershipCondition(1),
						"Cytotechnologist"
					};
					num = (int)(num2 * 1463094533) ^ -865515479;
					continue;
				case 31u:
					Form1.smethod_64((Control)(object)label1, 8);
					num = ((int)num2 * -410427106) ^ -1719131710;
					continue;
				case 30u:
					num = ((int)num2 * -1302542757) ^ -174783651;
					continue;
				case 29u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)button2);
					num = (int)((num2 * 1042813170) ^ 0x2CE1B151);
					continue;
				case 28u:
					button1 = Form1.smethod_53();
					num = ((int)num2 * -361248138) ^ -2026663560;
					continue;
				case 27u:
					Form1.smethod_5((Control)(object)this, Color.White);
					num = (int)((num2 * 1945103165) ^ 0x5FF48F21);
					continue;
				case 26u:
					num = ((int)num2 * -370583652) ^ -1203483986;
					continue;
				case 25u:
					num = 2023995926;
					continue;
				case 24u:
					Form1.smethod_64((Control)(object)richTextBox1, 6);
					num = (int)(num2 * 576981349) ^ -736518214;
					continue;
				case 23u:
					Form1.smethod_67((Control)(object)button2, (EventHandler)Button2_Click);
					num = ((int)num2 * -5035240) ^ 0x33D33D15;
					continue;
				case 22u:
					Form1.smethod_83((Form)(object)this, (FormBorderStyle)1);
					Form1.smethod_84((Form)(object)this, bool_0: false);
					num = ((int)num2 * -319959688) ^ -838959246;
					continue;
				case 21u:
					Form1.smethod_63(pictureBox1, bool_0: false);
					num = (int)(num2 * 1399904749) ^ -290207742;
					continue;
				case 20u:
					Form1.smethod_77((Control)(object)label6, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = (int)((num2 * 1374427394) ^ 0x190048A1);
					continue;
				case 19u:
					num = ((int)num2 * -687068189) ^ -1523759896;
					continue;
				case 18u:
					num = (int)(num2 * 1582697125) ^ -1793800616;
					continue;
				case 17u:
					num = ((int)num2 * -1109909854) ^ 0xAE7781;
					continue;
				case 16u:
					num = ((int)num2 * -1991302524) ^ -624469407;
					continue;
				case 15u:
					num = (int)(num2 * 547314826) ^ -878687342;
					continue;
				case 14u:
					Form1.smethod_77((Control)(object)label5, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = ((int)num2 * -1638509933) ^ 0x31F23B1A;
					continue;
				case 13u:
					richTextBox1 = Form1.smethod_54();
					panel1 = Form1.smethod_55();
					timer1 = Form1.smethod_56(components);
					label1 = Form1.smethod_57();
					num = ((int)num2 * -1381007291) ^ -727202343;
					continue;
				case 12u:
					string_ = Form1.smethod_34(string_, Veet.Zr);
					array = new byte[22528];
					num = (int)((num2 * 1975079282) ^ 0x6EE1827C);
					continue;
				case 11u:
					num = (int)((num2 * 537603780) ^ 0x4BEED392);
					continue;
				case 10u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)button1);
					num = (int)((num2 * 1139832208) ^ 0x121E6D8A);
					continue;
				case 9u:
					Form1.smethod_3((Control)(object)button2, new Size(83, 35));
					num = ((int)num2 * -1164421109) ^ 0x77C5F792;
					continue;
				case 8u:
					num = ((int)num2 * -1494296708) ^ -1702269384;
					continue;
				case 7u:
					Form1.smethod_85((Control)(object)this, "Form1");
					num = (int)(num2 * 1984890040) ^ -1555308893;
					continue;
				case 6u:
					num = ((int)num2 * -477000399) ^ 0x66E5D8E2;
					continue;
				case 5u:
					Form1.smethod_90((ISupportInitialize)pictureBox1);
					num = (int)((num2 * 1937550794) ^ 0x275FFE2F);
					continue;
				case 4u:
					num = ((int)num2 * -758629261) ^ 0x634F4DD8;
					continue;
				case 3u:
					label5 = Form1.smethod_57();
					label6 = Form1.smethod_57();
					num = (int)((num2 * 1202253982) ^ 0x55897C3D);
					continue;
				case 2u:
					num = ((int)num2 * -1567672701) ^ 0x13E4F95A;
					continue;
				case 1u:
					Form1.smethod_3((Control)(object)button1, new Size(83, 35));
					num = (int)((num2 * 243114499) ^ 0x2C5DEE2);
					continue;
				case 0u:
					num3 = 0;
					num = (int)((num2 * 1584024834) ^ 0x72ECBDB8);
					continue;
				default:
					return;
				case 99u:
					break;
				case 59u:
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
			int num = 191149285;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x2B17D444u) % 4u)
				{
				case 1u:
					result = Form1.smethod_94(Form1.smethod_93(), Position);
					num = ((int)num2 * -2038676162) ^ 0x23A058BA;
					continue;
				case 0u:
					num = (int)(num2 * 1462096691) ^ -472727465;
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
		while (true)
		{
			int num = -578406781;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF7BB3E36u) % 3u)
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
				num = (int)(num2 * 1258214065) ^ -1442071637;
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
