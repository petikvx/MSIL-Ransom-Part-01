using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Cytotechnologist;

public class Form2 : Form
{
	private Random rnd = Form2.smethod_0();

	private bool flag = true;

	private IContainer components = null;

	private Label label1;

	private Label label2;

	private TextBox textBox1;

	private Button button1;

	private Label label3;

	public Form2()
	{
		while (true)
		{
			int num = -951092758;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xDD2ED409u) % 5u)
				{
				case 3u:
					num = (int)(num2 * 1472625630) ^ -1039185484;
					continue;
				case 2u:
					num = (int)(num2 * 1800184144) ^ -211793081;
					continue;
				case 1u:
					InitializeComponent();
					Form2.smethod_1((Control)(object)label1, "Введите любое число от 0 до 9 включительно.\nВаш соперник уже загадал число (N) из этого\nже диапазона. Если сумма ваших чисел будет\nчетным числом, то первым ход делаете Вы,\nиначе - ваш соперник Компьютер!");
					num = ((int)num2 * -79124866) ^ -719263985;
					continue;
				default:
					return;
				case 0u:
					break;
				case 4u:
					return;
				}
				break;
			}
		}
	}

	private void Form2_FormClosed(object sender, FormClosedEventArgs e)
	{
		Form2.smethod_3((Control)(object)Form2.smethod_2((Form)(object)this), bool_0: true);
		while (true)
		{
			int num = -639374422;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9BB6D0E9u) % 3u)
				{
				case 1u:
					goto IL_000e;
				default:
					return;
				case 2u:
					break;
				case 0u:
					return;
				}
				break;
				IL_000e:
				num = ((int)num2 * -453429324) ^ -1114866885;
			}
		}
	}

	private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
	{
		bool flag = !char.IsDigit(Form2.smethod_4(e));
		while (true)
		{
			int num = 1185829316;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7C757E4Fu) % 9u)
				{
				case 8u:
				{
					int num5;
					if (Form2.smethod_4(e) != '\r')
					{
						num = 286025296;
						num5 = 286025296;
					}
					else
					{
						num = 688347747;
						num5 = 688347747;
					}
					continue;
				}
				case 7u:
					num = (int)(num2 * 1089251002) ^ -1101432634;
					continue;
				case 6u:
					Form2.smethod_5(e, bool_0: true);
					num = ((int)num2 * -1047695265) ^ -63176182;
					continue;
				case 5u:
					num = ((int)num2 * -681957058) ^ 0x6E14BC42;
					continue;
				case 2u:
					Form2.smethod_1((Control)(object)textBox1, "");
					num = 1611431236;
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = 358811116;
						num4 = 358811116;
					}
					else
					{
						num3 = 384742511;
						num4 = 384742511;
					}
					num = num3 ^ ((int)num2 * -728570450);
					continue;
				}
				case 0u:
					Button1_Click(this, Form2.smethod_6());
					num = (int)(num2 * 9251097) ^ -1658785252;
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

	private void Button1_Click(object sender, EventArgs e)
	{
		int num5 = default(int);
		int num7 = default(int);
		int num6 = default(int);
		bool flag2 = default(bool);
		bool flag = default(bool);
		while (true)
		{
			int num = -1388674491;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF1A3E6EDu) % 29u)
				{
				case 27u:
				{
					Label control_ = label2;
					string string_ = num5.ToString();
					num7 = num6 + num5;
					Form2.smethod_1((Control)(object)control_, Form2.smethod_10("+", string_, "=", num7.ToString()));
					num = (int)((num2 * 1525337008) ^ 0x433B1438);
					continue;
				}
				case 26u:
				{
					int num8;
					int num9;
					if (Form2.smethod_8(Form2.smethod_7((Control)(object)textBox1), ""))
					{
						num8 = -629177164;
						num9 = -629177164;
					}
					else
					{
						num8 = -826037833;
						num9 = -826037833;
					}
					num = num8 ^ ((int)num2 * -2017228810);
					continue;
				}
				case 25u:
					num = (int)(num2 * 797449928) ^ -506154669;
					continue;
				case 24u:
					this.flag = false;
					num = -600412706;
					continue;
				case 23u:
					num = -1148306555;
					continue;
				case 22u:
					num = -307169081;
					continue;
				case 21u:
				{
					int num12;
					int num13;
					if (!flag2)
					{
						num12 = 339546807;
						num13 = 339546807;
					}
					else
					{
						num12 = 317686132;
						num13 = 317686132;
					}
					num = num12 ^ ((int)num2 * -1221966311);
					continue;
				}
				case 20u:
				{
					int num10;
					int num11;
					if (!this.flag)
					{
						num10 = -1461133254;
						num11 = -1461133254;
					}
					else
					{
						num10 = -306169879;
						num11 = -306169879;
					}
					num = num10 ^ ((int)num2 * -2125536048);
					continue;
				}
				case 19u:
					num = ((int)num2 * -242425535) ^ 0x4FC7FCF;
					continue;
				case 17u:
					num = (int)((num2 * 935635308) ^ 0x4738C18E);
					continue;
				case 16u:
					num = -1028449079;
					continue;
				case 15u:
					flag2 = num7 > 1;
					num = (int)((num2 * 216939848) ^ 0x4F7273A1);
					continue;
				case 14u:
					flag = (num6 + num5) % 2 == 0;
					num = (int)((num2 * 1734175707) ^ 0x4A021B05);
					continue;
				case 13u:
					num6 = int.Parse(Form2.smethod_7((Control)(object)textBox1));
					num5 = Form2.smethod_9(rnd, 10);
					num = ((int)num2 * -783400494) ^ 0x2C9C7B64;
					continue;
				case 12u:
					num = ((int)num2 * -361371163) ^ -821258524;
					continue;
				case 11u:
					(Form2.smethod_11(Form2.smethod_2((Form)(object)this)) as Form1).turn = true;
					num = ((int)num2 * -806270490) ^ 0x7468D205;
					continue;
				case 10u:
					Form2.smethod_1((Control)(object)label3, "Поздравляем! Ваш ход первый.");
					num = (int)((num2 * 1513399469) ^ 0x2947C2C4);
					continue;
				case 9u:
				{
					Form control_2 = Form2.smethod_2((Form)(object)this);
					num7 = Form2.smethod_12((Control)(object)control_2) - 1;
					Form2.smethod_13((Control)(object)control_2, num7);
					num = -2013403856;
					continue;
				}
				case 8u:
					num = (int)((num2 * 231924618) ^ 0x732CF393);
					continue;
				case 7u:
					Form2.smethod_1((Control)(object)label3, "Первым ход делает Компьютер.");
					(Form2.smethod_11(Form2.smethod_2((Form)(object)this)) as Form1).turn = false;
					num = -1122815287;
					continue;
				case 6u:
					Form2.smethod_15((Form)(object)this);
					num = ((int)num2 * -535578157) ^ 0x35759E6B;
					continue;
				case 5u:
					(Form2.smethod_2((Form)(object)this) as Form3).Button_Continue();
					num = ((int)num2 * -253177929) ^ -1492597735;
					continue;
				case 4u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = 458091366;
						num4 = 458091366;
					}
					else
					{
						num3 = 753759416;
						num4 = 753759416;
					}
					num = num3 ^ ((int)num2 * -142070296);
					continue;
				}
				case 3u:
					num = ((int)num2 * -929250076) ^ -1289985131;
					continue;
				case 2u:
					(Form2.smethod_11(Form2.smethod_2((Form)(object)this)) as Form1).StartGame();
					num = (int)(num2 * 1908221762) ^ -1225567284;
					continue;
				case 1u:
					Form2.smethod_14(Form2.smethod_11(Form2.smethod_2((Form)(object)this)));
					num = (int)((num2 * 2028344836) ^ 0x15D28851);
					continue;
				case 0u:
					num = ((int)num2 * -1041043326) ^ 0x402536B7;
					continue;
				default:
					return;
				case 18u:
					break;
				case 28u:
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
			int num = 901552845;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0x6DF2B0AEu) % 10u)
				{
				case 9u:
					num = (int)((num2 * 279492595) ^ 0x2E769615);
					continue;
				case 8u:
					((Form)this).Dispose(disposing);
					num = 203737801;
					continue;
				case 7u:
					if (disposing)
					{
						num = ((int)num2 * -1302337192) ^ 0x469D806E;
						continue;
					}
					num3 = 0;
					goto IL_003c;
				case 6u:
					Form2.smethod_16((IDisposable)components);
					num = ((int)num2 * -1711085648) ^ 0x37ED1210;
					continue;
				case 5u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = -1334640987;
						num5 = -1334640987;
					}
					else
					{
						num4 = -2106173322;
						num5 = -2106173322;
					}
					num = num4 ^ ((int)num2 * -642330434);
					continue;
				}
				case 3u:
					num = (int)((num2 * 2086977358) ^ 0x44F5BB22);
					continue;
				case 2u:
					num = ((int)num2 * -150055160) ^ 0x1D2490E1;
					continue;
				case 0u:
					num3 = ((components != null) ? 1 : 0);
					goto IL_003c;
				default:
					return;
				case 4u:
					break;
				case 1u:
					return;
					IL_003c:
					flag = (byte)num3 != 0;
					num = 47669735;
					continue;
				}
				break;
			}
		}
	}

	private void InitializeComponent()
	{
		//IL_0251: Unknown result type (might be due to invalid IL or missing references)
		//IL_025b: Expected O, but got Unknown
		//IL_0713: Unknown result type (might be due to invalid IL or missing references)
		//IL_071d: Expected O, but got Unknown
		label1 = Form2.smethod_17();
		while (true)
		{
			int num = 2002445436;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x64B0075Fu) % 71u)
				{
				case 70u:
					num = (int)(num2 * 46990750) ^ -1813494122;
					continue;
				case 69u:
					Form2.smethod_36((Form)(object)this, (FormBorderStyle)1);
					num = (int)((num2 * 1338264930) ^ 0x6CD259F2);
					continue;
				case 68u:
					num = ((int)num2 * -1705220525) ^ 0x7E5B3AFB;
					continue;
				case 67u:
					Form2.smethod_24((Control)(object)label2, new Size(188, 73));
					num = (int)(num2 * 440064886) ^ -1819067673;
					continue;
				case 66u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)textBox1);
					num = ((int)num2 * -104729004) ^ 0x45016759;
					continue;
				case 65u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)button1);
					num = ((int)num2 * -2044711633) ^ -983918055;
					continue;
				case 64u:
					Form2.smethod_1((Control)(object)this, "Жеребьёвка");
					num = (int)((num2 * 1939096330) ^ 0x3275CF87);
					continue;
				case 63u:
					Form2.smethod_30((Control)(object)button1, (EventHandler)Button1_Click);
					num = (int)((num2 * 1804189693) ^ 0xFD80858);
					continue;
				case 62u:
					button1 = Form2.smethod_19();
					num = (int)(num2 * 2128244483) ^ -1734267178;
					continue;
				case 61u:
					num = (int)((num2 * 1428026635) ^ 0x765C4E63);
					continue;
				case 60u:
					num = (int)(num2 * 1420749411) ^ -579381268;
					continue;
				case 59u:
					num = ((int)num2 * -1623885354) ^ -1380176775;
					continue;
				case 58u:
					Form2.smethod_21((Control)(object)label2, bool_0: true);
					Form2.smethod_27((Control)(object)label2, Form2.smethod_26("Microsoft Sans Serif", 48f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = (int)((num2 * 1616182653) ^ 0x67769F);
					continue;
				case 57u:
					num = ((int)num2 * -807359999) ^ -760961588;
					continue;
				case 55u:
					num = (int)((num2 * 872307682) ^ 0x4904A745);
					continue;
				case 54u:
					Form2.smethod_21((Control)(object)label3, bool_0: true);
					num = (int)((num2 * 1976365827) ^ 0x5DA80665);
					continue;
				case 53u:
					Form2.smethod_22((Control)(object)button1, new Point(86, 193));
					num = (int)(num2 * 1313124485) ^ -1740200636;
					continue;
				case 52u:
					Form2.smethod_31((ContainerControl)(object)this, new SizeF(6f, 13f));
					num = (int)(num2 * 526956796) ^ -649314958;
					continue;
				case 51u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)label1);
					num = ((int)num2 * -583681690) ^ -1005073841;
					continue;
				case 50u:
					Form2.smethod_41((Form)(object)this, new FormClosedEventHandler(Form2_FormClosed));
					num = ((int)num2 * -1377740508) ^ -1132802980;
					continue;
				case 49u:
					Form2.smethod_24((Control)(object)textBox1, new Size(42, 80));
					num = ((int)num2 * -1199543232) ^ -1342898565;
					continue;
				case 48u:
					Form2.smethod_32((ContainerControl)(object)this, (AutoScaleMode)1);
					num = (int)(num2 * 639789122) ^ -873153884;
					continue;
				case 47u:
					num = ((int)num2 * -1140550191) ^ 0x7694F4D4;
					continue;
				case 46u:
					num = ((int)num2 * -61928608) ^ -924053706;
					continue;
				case 45u:
					Form2.smethod_20((Control)(object)this);
					Form2.smethod_21((Control)(object)label1, bool_0: true);
					num = ((int)num2 * -285544012) ^ 0x63315831;
					continue;
				case 44u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)label3);
					num = ((int)num2 * -755448798) ^ -1715452798;
					continue;
				case 43u:
					num = (int)(num2 * 875305684) ^ -1636030955;
					continue;
				case 42u:
					Form2.smethod_25((Control)(object)label1, 0);
					num = (int)(num2 * 518676984) ^ -55952506;
					continue;
				case 41u:
					Form2.smethod_25((Control)(object)label2, 2);
					Form2.smethod_1((Control)(object)label2, "+N=?");
					num = ((int)num2 * -172865724) ^ 0x421441E6;
					continue;
				case 40u:
					Form2.smethod_22((Control)(object)label2, new Point(53, 89));
					num = ((int)num2 * -1071522122) ^ -519201329;
					continue;
				case 39u:
					Form2.smethod_1((Control)(object)label1, "label1");
					num = (int)(num2 * 1884190512) ^ -808249424;
					continue;
				case 38u:
					Form2.smethod_43((Control)(object)this);
					num = (int)((num2 * 2025515466) ^ 0x43CC9E4D);
					continue;
				case 37u:
					Form2.smethod_37((Form)(object)this, bool_0: false);
					num = (int)(num2 * 1324202874) ^ -842300463;
					continue;
				case 36u:
					num = (int)(num2 * 1566916659) ^ -456027353;
					continue;
				case 35u:
					Form2.smethod_25((Control)(object)label3, 4);
					num = ((int)num2 * -210954823) ^ 0x396AABDC;
					continue;
				case 33u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)label2);
					num = (int)(num2 * 1888689369) ^ -1170514406;
					continue;
				case 32u:
					num = (int)(num2 * 759705225) ^ -292656839;
					continue;
				case 31u:
					Form2.smethod_23((Control)(object)label3, "label3");
					num = (int)(num2 * 620927062) ^ -1800484822;
					continue;
				case 30u:
					Form2.smethod_27((Control)(object)textBox1, Form2.smethod_26("Microsoft Sans Serif", 48f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = ((int)num2 * -792719568) ^ 0xB60D351;
					continue;
				case 29u:
					Form2.smethod_23((Control)(object)label2, "label2");
					num = (int)(num2 * 1969151152) ^ -1839110251;
					continue;
				case 28u:
					label3 = Form2.smethod_17();
					num = (int)((num2 * 1093088750) ^ 0x5A3DFBCF);
					continue;
				case 27u:
					textBox1 = Form2.smethod_18();
					num = (int)((num2 * 1191924230) ^ 0x22F492BE);
					continue;
				case 26u:
					num = ((int)num2 * -1844709295) ^ 0x13C5D5F3;
					continue;
				case 25u:
					Form2.smethod_22((Control)(object)label3, new Point(47, 177));
					num = ((int)num2 * -1443391881) ^ -1088328563;
					continue;
				case 24u:
					Form2.smethod_24((Control)(object)button1, new Size(73, 23));
					num = ((int)num2 * -1324798071) ^ 0x1A516DA3;
					continue;
				case 23u:
					num = ((int)num2 * -29798798) ^ -2056302517;
					continue;
				case 22u:
					Form2.smethod_25((Control)(object)button1, 3);
					Form2.smethod_1((Control)(object)button1, "OK");
					num = (int)((num2 * 1908861397) ^ 0x39AB0C58);
					continue;
				case 21u:
					num = ((int)num2 * -1325026105) ^ -1458650180;
					continue;
				case 20u:
					Form2.smethod_22((Control)(object)textBox1, new Point(24, 86));
					Form2.smethod_23((Control)(object)textBox1, "textBox1");
					num = (int)((num2 * 1885252174) ^ 0x26FA88A3);
					continue;
				case 19u:
					num = ((int)num2 * -1684708518) ^ 0x189C7FCD;
					continue;
				case 18u:
					Form2.smethod_33((Form)(object)this, new Size(255, 224));
					num = (int)((num2 * 489092080) ^ 0xD77ECA5);
					continue;
				case 17u:
					Form2.smethod_42((Control)(object)this, bool_0: false);
					num = (int)((num2 * 1878257972) ^ 0x56EB4A8D);
					continue;
				case 16u:
					num = (int)((num2 * 451775835) ^ 0x6F298866);
					continue;
				case 15u:
					Form2.smethod_22((Control)(object)label1, new Point(10, 10));
					num = (int)((num2 * 684352242) ^ 0x1E65FD22);
					continue;
				case 14u:
					num = ((int)num2 * -1647224410) ^ -1534220893;
					continue;
				case 13u:
					Form2.smethod_23((Control)(object)button1, "button1");
					num = ((int)num2 * -550973660) ^ 0x792C3A06;
					continue;
				case 12u:
					num = (int)(num2 * 994432251) ^ -703202785;
					continue;
				case 11u:
					Form2.smethod_24((Control)(object)label3, new Size(0, 13));
					num = (int)((num2 * 1334461542) ^ 0x5E6A1104);
					continue;
				case 10u:
					num = (int)((num2 * 1020561345) ^ 0x43F4754C);
					continue;
				case 9u:
					num = ((int)num2 * -32593610) ^ -1624609925;
					continue;
				case 8u:
					Form2.smethod_28((Control)(object)textBox1, new KeyPressEventHandler(TextBox1_KeyPress));
					num = ((int)num2 * -1830118972) ^ -305250313;
					continue;
				case 7u:
					Form2.smethod_24((Control)(object)label1, new Size(35, 13));
					num = (int)(num2 * 779082666) ^ -1176183509;
					continue;
				case 6u:
					Form2.smethod_29((ButtonBase)(object)button1, bool_0: true);
					num = (int)(num2 * 891095647) ^ -868394885;
					continue;
				case 5u:
					num = (int)(num2 * 1554158832) ^ -1591336851;
					continue;
				case 4u:
					Form2.smethod_23((Control)(object)label1, "label1");
					num = ((int)num2 * -1738446027) ^ -870550789;
					continue;
				case 3u:
					Form2.smethod_25((Control)(object)textBox1, 1);
					num = (int)(num2 * 1556748989) ^ -2056731870;
					continue;
				case 2u:
					label2 = Form2.smethod_17();
					num = (int)((num2 * 1274966330) ^ 0x480929B3);
					continue;
				case 1u:
					Form2.smethod_38((Form)(object)this, bool_0: false);
					num = (int)((num2 * 998552306) ^ 0x6B9E9D1);
					continue;
				case 0u:
					Form2.smethod_39((Control)(object)this, "Form2");
					Form2.smethod_40((Form)(object)this, bool_0: false);
					num = (int)((num2 * 734797432) ^ 0x6E102BE4);
					continue;
				default:
					return;
				case 56u:
					break;
				case 34u:
					return;
				}
				break;
			}
		}
	}

	static Random smethod_0()
	{
		return new Random();
	}

	static void smethod_1(Control control_0, string string_0)
	{
		control_0.set_Text(string_0);
	}

	static Form smethod_2(Form form_0)
	{
		return form_0.get_Owner();
	}

	static void smethod_3(Control control_0, bool bool_0)
	{
		control_0.set_Enabled(bool_0);
	}

	static char smethod_4(KeyPressEventArgs keyPressEventArgs_0)
	{
		return keyPressEventArgs_0.get_KeyChar();
	}

	static void smethod_5(KeyPressEventArgs keyPressEventArgs_0, bool bool_0)
	{
		keyPressEventArgs_0.set_Handled(bool_0);
	}

	static EventArgs smethod_6()
	{
		return new EventArgs();
	}

	static string smethod_7(Control control_0)
	{
		return control_0.get_Text();
	}

	static bool smethod_8(string string_0, string string_1)
	{
		return string_0 != string_1;
	}

	static int smethod_9(Random random_0, int int_0)
	{
		return random_0.Next(int_0);
	}

	static string smethod_10(string string_0, string string_1, string string_2, string string_3)
	{
		return string_0 + string_1 + string_2 + string_3;
	}

	static Form smethod_11(Form form_0)
	{
		return form_0.get_Owner();
	}

	static int smethod_12(Control control_0)
	{
		return control_0.get_Height();
	}

	static void smethod_13(Control control_0, int int_0)
	{
		control_0.set_Height(int_0);
	}

	static void smethod_14(Form form_0)
	{
		form_0.Activate();
	}

	static void smethod_15(Form form_0)
	{
		form_0.Close();
	}

	static void smethod_16(IDisposable idisposable_0)
	{
		idisposable_0.Dispose();
	}

	static Label smethod_17()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new Label();
	}

	static TextBox smethod_18()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new TextBox();
	}

	static Button smethod_19()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new Button();
	}

	static void smethod_20(Control control_0)
	{
		control_0.SuspendLayout();
	}

	static void smethod_21(Control control_0, bool bool_0)
	{
		control_0.set_AutoSize(bool_0);
	}

	static void smethod_22(Control control_0, Point point_0)
	{
		control_0.set_Location(point_0);
	}

	static void smethod_23(Control control_0, string string_0)
	{
		control_0.set_Name(string_0);
	}

	static void smethod_24(Control control_0, Size size_0)
	{
		control_0.set_Size(size_0);
	}

	static void smethod_25(Control control_0, int int_0)
	{
		control_0.set_TabIndex(int_0);
	}

	static Font smethod_26(string string_0, float float_0, FontStyle fontStyle_0, GraphicsUnit graphicsUnit_0, byte byte_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		return new Font(string_0, float_0, fontStyle_0, graphicsUnit_0, byte_0);
	}

	static void smethod_27(Control control_0, Font font_0)
	{
		control_0.set_Font(font_0);
	}

	static void smethod_28(Control control_0, KeyPressEventHandler keyPressEventHandler_0)
	{
		control_0.add_KeyPress(keyPressEventHandler_0);
	}

	static void smethod_29(ButtonBase buttonBase_0, bool bool_0)
	{
		buttonBase_0.set_UseVisualStyleBackColor(bool_0);
	}

	static void smethod_30(Control control_0, EventHandler eventHandler_0)
	{
		control_0.add_Click(eventHandler_0);
	}

	static void smethod_31(ContainerControl containerControl_0, SizeF sizeF_0)
	{
		containerControl_0.set_AutoScaleDimensions(sizeF_0);
	}

	static void smethod_32(ContainerControl containerControl_0, AutoScaleMode autoScaleMode_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		containerControl_0.set_AutoScaleMode(autoScaleMode_0);
	}

	static void smethod_33(Form form_0, Size size_0)
	{
		form_0.set_ClientSize(size_0);
	}

	static ControlCollection smethod_34(Control control_0)
	{
		return control_0.get_Controls();
	}

	static void smethod_35(ControlCollection controlCollection_0, Control control_0)
	{
		controlCollection_0.Add(control_0);
	}

	static void smethod_36(Form form_0, FormBorderStyle formBorderStyle_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		form_0.set_FormBorderStyle(formBorderStyle_0);
	}

	static void smethod_37(Form form_0, bool bool_0)
	{
		form_0.set_MaximizeBox(bool_0);
	}

	static void smethod_38(Form form_0, bool bool_0)
	{
		form_0.set_MinimizeBox(bool_0);
	}

	static void smethod_39(Control control_0, string string_0)
	{
		control_0.set_Name(string_0);
	}

	static void smethod_40(Form form_0, bool bool_0)
	{
		form_0.set_ShowIcon(bool_0);
	}

	static void smethod_41(Form form_0, FormClosedEventHandler formClosedEventHandler_0)
	{
		form_0.add_FormClosed(formClosedEventHandler_0);
	}

	static void smethod_42(Control control_0, bool bool_0)
	{
		control_0.ResumeLayout(bool_0);
	}

	static void smethod_43(Control control_0)
	{
		control_0.PerformLayout();
	}
}
