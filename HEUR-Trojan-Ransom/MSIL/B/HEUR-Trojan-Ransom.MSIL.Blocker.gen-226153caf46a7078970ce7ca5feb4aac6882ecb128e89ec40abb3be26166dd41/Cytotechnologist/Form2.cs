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
		InitializeComponent();
		Form2.smethod_1((Control)(object)label1, "Введите любое число от 0 до 9 включительно.\nВаш соперник уже загадал число (N) из этого\nже диапазона. Если сумма ваших чисел будет\nчетным числом, то первым ход делаете Вы,\nиначе - ваш соперник Компьютер!");
	}

	private void Form2_FormClosed(object sender, FormClosedEventArgs e)
	{
		Form2.smethod_3((Control)(object)Form2.smethod_2((Form)(object)this), bool_0: true);
	}

	private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
	{
		bool flag = !char.IsDigit(Form2.smethod_4(e));
		bool flag2 = default(bool);
		while (true)
		{
			int num = 803309634;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1847DB4Du) % 12u)
				{
				case 11u:
					num = (int)(num2 * 1500937510) ^ -1806835287;
					continue;
				case 10u:
					num = (int)(num2 * 281653159) ^ -731320603;
					continue;
				case 9u:
					num = ((int)num2 * -391112574) ^ -399662292;
					continue;
				case 7u:
				{
					int num5;
					int num6;
					if (!flag)
					{
						num5 = 1697046717;
						num6 = 1697046717;
					}
					else
					{
						num5 = 716112966;
						num6 = 716112966;
					}
					num = num5 ^ ((int)num2 * -1364180361);
					continue;
				}
				case 6u:
					Form2.smethod_5(e, bool_0: true);
					num = (int)((num2 * 923060764) ^ 0x37721108);
					continue;
				case 5u:
					num = (int)((num2 * 1011226751) ^ 0x44BAAD2E);
					continue;
				case 4u:
					Button1_Click(this, Form2.smethod_6());
					num = ((int)num2 * -1320982492) ^ 0x26A75BCC;
					continue;
				case 3u:
				{
					int num3;
					int num4;
					if (flag2)
					{
						num3 = 1539090871;
						num4 = 1539090871;
					}
					else
					{
						num3 = 493335;
						num4 = 493335;
					}
					num = num3 ^ (int)(num2 * 610345986);
					continue;
				}
				case 2u:
					flag2 = Form2.smethod_4(e) == '\r';
					num = 1706715382;
					continue;
				case 1u:
					Form2.smethod_1((Control)(object)textBox1, "");
					num = 1201729871;
					continue;
				default:
					return;
				case 0u:
					break;
				case 8u:
					return;
				}
				break;
			}
		}
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		int num6 = default(int);
		int num5 = default(int);
		bool flag = default(bool);
		while (true)
		{
			int num = -473122699;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE0A83E79u) % 31u)
				{
				case 30u:
				{
					int num11;
					int num12;
					if (!Form2.smethod_8(Form2.smethod_7((Control)(object)textBox1), ""))
					{
						num11 = -1450452872;
						num12 = -1450452872;
					}
					else
					{
						num11 = -1467363116;
						num12 = -1467363116;
					}
					num = num11 ^ (int)(num2 * 285247794);
					continue;
				}
				case 29u:
					Form2.smethod_14(Form2.smethod_11(Form2.smethod_2((Form)(object)this)));
					num = (int)(num2 * 1284583280) ^ -66032880;
					continue;
				case 28u:
					Form2.smethod_15((Form)(object)this);
					num = (int)(num2 * 1678489594) ^ -48104985;
					continue;
				case 27u:
					num = ((int)num2 * -1575442113) ^ -135772902;
					continue;
				case 26u:
					Form2.smethod_1((Control)(object)label3, "Первым ход делает Компьютер.");
					num = -264354807;
					continue;
				case 25u:
					num = (int)(num2 * 301464792) ^ -965152130;
					continue;
				case 24u:
					num = (int)(num2 * 810781276) ^ -903315730;
					continue;
				case 23u:
					num = (int)((num2 * 1658330686) ^ 0x733E3D3F);
					continue;
				case 22u:
					num6 = Form2.smethod_9(rnd, 10);
					num = (int)((num2 * 1321359569) ^ 0x6C5C1588);
					continue;
				case 21u:
					num = (int)((num2 * 41629662) ^ 0x1FBDA26E);
					continue;
				case 20u:
					num = (int)(num2 * 1815028046) ^ -1146348022;
					continue;
				case 19u:
				{
					Form control_ = Form2.smethod_2((Form)(object)this);
					int num9 = Form2.smethod_12((Control)(object)control_) - 1;
					Form2.smethod_13((Control)(object)control_, num9);
					int num10;
					if (num9 > 1)
					{
						num = -1281345380;
						num10 = -1281345380;
					}
					else
					{
						num = -672287516;
						num10 = -672287516;
					}
					continue;
				}
				case 18u:
					(Form2.smethod_11(Form2.smethod_2((Form)(object)this)) as Form1).turn = true;
					num = (int)((num2 * 1876739568) ^ 0x3E8D0B53);
					continue;
				case 17u:
					Form2.smethod_1((Control)(object)label3, "Поздравляем! Ваш ход первый.");
					num = (int)((num2 * 468921158) ^ 0x6E61FC64);
					continue;
				case 16u:
					(Form2.smethod_2((Form)(object)this) as Form3).Button_Continue();
					num = ((int)num2 * -1523782412) ^ 0x26FBB086;
					continue;
				case 15u:
					num = (int)((num2 * 1553305376) ^ 0x2273C766);
					continue;
				case 14u:
				{
					int num7;
					int num8;
					if (!this.flag)
					{
						num7 = -1844224531;
						num8 = -1844224531;
					}
					else
					{
						num7 = -1002635747;
						num8 = -1002635747;
					}
					num = num7 ^ (int)(num2 * 453587675);
					continue;
				}
				case 13u:
					num = ((int)num2 * -1820268041) ^ -686838946;
					continue;
				case 11u:
					num = -388677088;
					continue;
				case 10u:
					Form2.smethod_1((Control)(object)label2, Form2.smethod_10("+", num6.ToString(), "=", (num5 + num6).ToString()));
					num = (int)(num2 * 495844962) ^ -533090520;
					continue;
				case 9u:
					num = -1346647974;
					continue;
				case 8u:
					(Form2.smethod_11(Form2.smethod_2((Form)(object)this)) as Form1).StartGame();
					num = ((int)num2 * -2051634039) ^ 0x47C2F2E7;
					continue;
				case 7u:
					flag = (num5 + num6) % 2 == 0;
					num = ((int)num2 * -2100922172) ^ 0x46162D2C;
					continue;
				case 6u:
					num = ((int)num2 * -2024110502) ^ -1378559074;
					continue;
				case 5u:
					num = -1852256222;
					continue;
				case 4u:
					num5 = int.Parse(Form2.smethod_7((Control)(object)textBox1));
					num = ((int)num2 * -1753532062) ^ 0x16A9E7B0;
					continue;
				case 3u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = 232825301;
						num4 = 232825301;
					}
					else
					{
						num3 = 1866897060;
						num4 = 1866897060;
					}
					num = num3 ^ (int)(num2 * 618030059);
					continue;
				}
				case 1u:
					(Form2.smethod_11(Form2.smethod_2((Form)(object)this)) as Form1).turn = false;
					num = (int)((num2 * 2104831936) ^ 0x6CC96C3C);
					continue;
				case 0u:
					this.flag = false;
					num = -416907306;
					continue;
				default:
					return;
				case 12u:
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
			int num = 1956905593;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0x1E6942C6u) % 9u)
				{
				case 8u:
					if (disposing)
					{
						num = (int)((num2 * 1850532165) ^ 0x728F259E);
						continue;
					}
					num3 = 0;
					goto IL_0019;
				case 7u:
					((Form)this).Dispose(disposing);
					num = 228474784;
					continue;
				case 6u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = -888878515;
						num5 = -888878515;
					}
					else
					{
						num4 = -2054088078;
						num5 = -2054088078;
					}
					num = num4 ^ ((int)num2 * -1143655171);
					continue;
				}
				case 5u:
					Form2.smethod_16((IDisposable)components);
					num = ((int)num2 * -1316763925) ^ 0x599B586F;
					continue;
				case 4u:
					num = (int)(num2 * 127154348) ^ -1864375638;
					continue;
				case 3u:
					num = (int)((num2 * 195129931) ^ 0x741BFC95);
					continue;
				case 0u:
					num3 = ((components != null) ? 1 : 0);
					goto IL_0019;
				default:
					return;
				case 2u:
					break;
				case 1u:
					return;
					IL_0019:
					flag = (byte)num3 != 0;
					num = 1847361833;
					continue;
				}
				break;
			}
		}
	}

	private void InitializeComponent()
	{
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Expected O, but got Unknown
		//IL_06b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_06bf: Expected O, but got Unknown
		label1 = Form2.smethod_17();
		textBox1 = Form2.smethod_18();
		label2 = Form2.smethod_17();
		while (true)
		{
			int num = -844315358;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD5BEB5D3u) % 70u)
				{
				case 69u:
					num = ((int)num2 * -13718613) ^ 0x35A81904;
					continue;
				case 68u:
					Form2.smethod_24((Control)(object)label3, new Size(0, 13));
					Form2.smethod_25((Control)(object)label3, 4);
					num = (int)(num2 * 1421589056) ^ -277827991;
					continue;
				case 67u:
					Form2.smethod_27((Control)(object)textBox1, Form2.smethod_26("Microsoft Sans Serif", 48f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = (int)(num2 * 1998678980) ^ -49072012;
					continue;
				case 66u:
					num = (int)(num2 * 1336982533) ^ -762572163;
					continue;
				case 65u:
					num = ((int)num2 * -1094080400) ^ -1008300889;
					continue;
				case 64u:
					num = ((int)num2 * -1966162257) ^ -1985118606;
					continue;
				case 63u:
					Form2.smethod_33((Form)(object)this, new Size(255, 224));
					num = ((int)num2 * -814811762) ^ -1486763061;
					continue;
				case 62u:
					Form2.smethod_25((Control)(object)label1, 0);
					num = ((int)num2 * -778557570) ^ 0x6C9C0BFC;
					continue;
				case 61u:
					Form2.smethod_1((Control)(object)this, "Жеребьёвка");
					num = (int)((num2 * 748735053) ^ 0x4F51F07D);
					continue;
				case 60u:
					num = ((int)num2 * -1268618497) ^ -1594943734;
					continue;
				case 59u:
					Form2.smethod_41((Form)(object)this, new FormClosedEventHandler(Form2_FormClosed));
					Form2.smethod_42((Control)(object)this, bool_0: false);
					num = (int)(num2 * 779671745) ^ -1340112504;
					continue;
				case 58u:
					num = ((int)num2 * -461183238) ^ -101446638;
					continue;
				case 56u:
					num = (int)(num2 * 704182990) ^ -593683900;
					continue;
				case 55u:
					Form2.smethod_1((Control)(object)label1, "label1");
					num = (int)((num2 * 367109380) ^ 0x664928DA);
					continue;
				case 54u:
					num = (int)((num2 * 2049680681) ^ 0x16D4199F);
					continue;
				case 53u:
					Form2.smethod_21((Control)(object)label1, bool_0: true);
					num = ((int)num2 * -224760638) ^ 0x6A3B1FB2;
					continue;
				case 52u:
					label3 = Form2.smethod_17();
					Form2.smethod_20((Control)(object)this);
					num = ((int)num2 * -2106466637) ^ 0x465A1917;
					continue;
				case 51u:
					Form2.smethod_39((Control)(object)this, "Form2");
					num = (int)((num2 * 1295989122) ^ 0x5996E4DA);
					continue;
				case 50u:
					num = (int)((num2 * 916363095) ^ 0x517CACEE);
					continue;
				case 49u:
					Form2.smethod_24((Control)(object)textBox1, new Size(42, 80));
					num = (int)(num2 * 1186696271) ^ -1363759243;
					continue;
				case 48u:
					Form2.smethod_25((Control)(object)label2, 2);
					num = ((int)num2 * -753831112) ^ -930323387;
					continue;
				case 47u:
					num = ((int)num2 * -1501164791) ^ -2094649637;
					continue;
				case 46u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)button1);
					num = ((int)num2 * -556475895) ^ 0x2E170BFB;
					continue;
				case 45u:
					Form2.smethod_32((ContainerControl)(object)this, (AutoScaleMode)1);
					num = (int)(num2 * 1916124847) ^ -872423805;
					continue;
				case 44u:
					Form2.smethod_23((Control)(object)label3, "label3");
					num = ((int)num2 * -1089104797) ^ 0x2CC857B3;
					continue;
				case 43u:
					Form2.smethod_1((Control)(object)label2, "+N=?");
					num = ((int)num2 * -1146374307) ^ 0x6C513544;
					continue;
				case 42u:
					Form2.smethod_22((Control)(object)button1, new Point(86, 193));
					Form2.smethod_23((Control)(object)button1, "button1");
					num = (int)((num2 * 1177452976) ^ 0x6E867EBC);
					continue;
				case 41u:
					Form2.smethod_25((Control)(object)textBox1, 1);
					num = ((int)num2 * -164981893) ^ 0x1AF7E0BC;
					continue;
				case 40u:
					Form2.smethod_24((Control)(object)button1, new Size(73, 23));
					num = ((int)num2 * -1852399820) ^ 0x21FB59D7;
					continue;
				case 39u:
					num = (int)((num2 * 1986532488) ^ 0x51129E2E);
					continue;
				case 38u:
					num = (int)((num2 * 252456123) ^ 0x37F4F990);
					continue;
				case 37u:
					Form2.smethod_22((Control)(object)label1, new Point(10, 10));
					num = ((int)num2 * -2129856610) ^ -415158919;
					continue;
				case 36u:
					num = ((int)num2 * -1492508115) ^ 0x62F221F;
					continue;
				case 35u:
					button1 = Form2.smethod_19();
					num = ((int)num2 * -746916590) ^ 0x1E0460AB;
					continue;
				case 34u:
					num = (int)(num2 * 1707440547) ^ -859793876;
					continue;
				case 33u:
					num = ((int)num2 * -1921100916) ^ 0x55A4E912;
					continue;
				case 32u:
					Form2.smethod_43((Control)(object)this);
					num = ((int)num2 * -45916838) ^ -447489230;
					continue;
				case 31u:
					Form2.smethod_27((Control)(object)label2, Form2.smethod_26("Microsoft Sans Serif", 48f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = ((int)num2 * -1951525546) ^ -1385390051;
					continue;
				case 30u:
					num = ((int)num2 * -210930014) ^ 0x40F6F857;
					continue;
				case 29u:
					Form2.smethod_23((Control)(object)label2, "label2");
					num = ((int)num2 * -510416511) ^ -2025715806;
					continue;
				case 28u:
					Form2.smethod_31((ContainerControl)(object)this, new SizeF(6f, 13f));
					num = ((int)num2 * -1686795208) ^ -950254531;
					continue;
				case 27u:
					Form2.smethod_23((Control)(object)label1, "label1");
					num = (int)(num2 * 334865222) ^ -43448475;
					continue;
				case 26u:
					num = (int)((num2 * 1430399635) ^ 0x9F80AAE);
					continue;
				case 25u:
					Form2.smethod_40((Form)(object)this, bool_0: false);
					num = ((int)num2 * -1567195818) ^ 0x3065E250;
					continue;
				case 24u:
					num = (int)(num2 * 391972147) ^ -1028417418;
					continue;
				case 23u:
					Form2.smethod_36((Form)(object)this, (FormBorderStyle)1);
					num = (int)((num2 * 1876790080) ^ 0x42113E31);
					continue;
				case 22u:
					num = ((int)num2 * -338788197) ^ 0x4B9F3864;
					continue;
				case 21u:
					Form2.smethod_24((Control)(object)label1, new Size(35, 13));
					num = ((int)num2 * -1354306302) ^ -1934558231;
					continue;
				case 20u:
					Form2.smethod_1((Control)(object)button1, "OK");
					num = ((int)num2 * -2080626579) ^ 0x63044857;
					continue;
				case 19u:
					num = ((int)num2 * -469407217) ^ 0x1E39A257;
					continue;
				case 18u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)textBox1);
					num = ((int)num2 * -212128919) ^ 0x61E3E1D1;
					continue;
				case 16u:
					Form2.smethod_22((Control)(object)label3, new Point(47, 177));
					num = ((int)num2 * -1062239498) ^ -1298245375;
					continue;
				case 15u:
					num = ((int)num2 * -905960894) ^ -1323722220;
					continue;
				case 14u:
					Form2.smethod_22((Control)(object)label2, new Point(53, 89));
					num = (int)(num2 * 1456089627) ^ -1814976390;
					continue;
				case 13u:
					Form2.smethod_38((Form)(object)this, bool_0: false);
					num = (int)((num2 * 946863187) ^ 0x27228BD5);
					continue;
				case 12u:
					num = (int)(num2 * 1887576989) ^ -353446532;
					continue;
				case 11u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)label2);
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)label1);
					num = (int)((num2 * 1682165200) ^ 0x970C8F0);
					continue;
				case 10u:
					num = ((int)num2 * -1296058865) ^ 0x49A3705F;
					continue;
				case 9u:
					Form2.smethod_28((Control)(object)textBox1, new KeyPressEventHandler(TextBox1_KeyPress));
					Form2.smethod_21((Control)(object)label2, bool_0: true);
					num = (int)((num2 * 93468732) ^ 0x11FD25C8);
					continue;
				case 8u:
					Form2.smethod_24((Control)(object)label2, new Size(188, 73));
					num = (int)(num2 * 221994893) ^ -115887849;
					continue;
				case 7u:
					Form2.smethod_23((Control)(object)textBox1, "textBox1");
					num = ((int)num2 * -1665820126) ^ -541661047;
					continue;
				case 6u:
					Form2.smethod_21((Control)(object)label3, bool_0: true);
					num = (int)(num2 * 174974006) ^ -613522933;
					continue;
				case 5u:
					Form2.smethod_29((ButtonBase)(object)button1, bool_0: true);
					Form2.smethod_30((Control)(object)button1, (EventHandler)Button1_Click);
					num = ((int)num2 * -2099647756) ^ -1078726658;
					continue;
				case 4u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)label3);
					num = ((int)num2 * -803589781) ^ 0x3CAEF869;
					continue;
				case 3u:
					Form2.smethod_22((Control)(object)textBox1, new Point(24, 86));
					num = (int)(num2 * 1283858420) ^ -890898733;
					continue;
				case 2u:
					Form2.smethod_37((Form)(object)this, bool_0: false);
					num = (int)(num2 * 1197518888) ^ -1810572782;
					continue;
				case 1u:
					Form2.smethod_25((Control)(object)button1, 3);
					num = (int)(num2 * 105712037) ^ -361781190;
					continue;
				case 0u:
					num = (int)((num2 * 1383404544) ^ 0x6696DDEF);
					continue;
				default:
					return;
				case 57u:
					break;
				case 17u:
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
