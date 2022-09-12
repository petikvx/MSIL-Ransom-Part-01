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
		if (!char.IsDigit(Form2.smethod_4(e)))
		{
			goto IL_009d;
		}
		goto IL_00ee;
		IL_00ee:
		Form2.smethod_1((Control)(object)textBox1, "");
		int num = -1117470646;
		goto IL_00b4;
		IL_00b4:
		bool flag = default(bool);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0x9408A577u) % 10u)
			{
			case 9u:
				num = (int)((num2 * 547727191) ^ 0x7EA9A8FB);
				continue;
			case 8u:
				Form2.smethod_5(e, bool_0: true);
				num = ((int)num2 * -382262414) ^ 0x3DEDE5D3;
				continue;
			case 7u:
				Button1_Click(this, Form2.smethod_6());
				num = (int)(num2 * 1986939476) ^ -1071365246;
				continue;
			case 6u:
				num = (int)((num2 * 50136271) ^ 0x27274D40);
				continue;
			case 5u:
				num = (int)((num2 * 1559862507) ^ 0x792EE30E);
				continue;
			case 4u:
			{
				int num3;
				int num4;
				if (!flag)
				{
					num3 = -174844411;
					num4 = -174844411;
				}
				else
				{
					num3 = -176260482;
					num4 = -176260482;
				}
				num = num3 ^ ((int)num2 * -2143358310);
				continue;
			}
			case 2u:
				break;
			case 1u:
				flag = Form2.smethod_4(e) == '\r';
				num = -941657081;
				continue;
			default:
				return;
			case 3u:
				goto IL_00ee;
			case 0u:
				return;
			}
			break;
		}
		goto IL_009d;
		IL_009d:
		num = -888842475;
		goto IL_00b4;
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		bool flag = Form2.smethod_8(Form2.smethod_7((Control)(object)textBox1), "");
		int num4 = default(int);
		int num3 = default(int);
		bool flag2 = default(bool);
		while (true)
		{
			int num = -85325870;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x88C41CDDu) % 27u)
				{
				case 26u:
					(Form2.smethod_11(Form2.smethod_2((Form)(object)this)) as Form1).StartGame();
					Form2.smethod_15((Form)(object)this);
					num = (int)((num2 * 2073226302) ^ 0x20C4581F);
					continue;
				case 25u:
					Form2.smethod_1((Control)(object)label2, Form2.smethod_10("+", num4.ToString(), "=", (num3 + num4).ToString()));
					num = (int)(num2 * 129843660) ^ -1368205667;
					continue;
				case 24u:
					(Form2.smethod_2((Form)(object)this) as Form3).Button_Continue();
					num = ((int)num2 * -831199049) ^ -686837005;
					continue;
				case 23u:
					num = ((int)num2 * -1732129633) ^ -462148351;
					continue;
				case 22u:
					num = (int)(num2 * 1738832073) ^ -1251030831;
					continue;
				case 21u:
					num = -124728706;
					continue;
				case 20u:
					num = (int)((num2 * 1381920916) ^ 0x2AF01A0F);
					continue;
				case 19u:
				{
					int num7;
					int num8;
					if (flag)
					{
						num7 = 461863495;
						num8 = 461863495;
					}
					else
					{
						num7 = 166142254;
						num8 = 166142254;
					}
					num = num7 ^ ((int)num2 * -902128085);
					continue;
				}
				case 18u:
					Form2.smethod_14(Form2.smethod_11(Form2.smethod_2((Form)(object)this)));
					num = (int)((num2 * 1276972347) ^ 0x7D3FC795);
					continue;
				case 17u:
					num = (int)((num2 * 1198897386) ^ 0x56A3B934);
					continue;
				case 16u:
					num = -1875841877;
					continue;
				case 15u:
					num = (int)((num2 * 954213064) ^ 0x5C6C10F);
					continue;
				case 14u:
					(Form2.smethod_11(Form2.smethod_2((Form)(object)this)) as Form1).turn = false;
					num = (int)((num2 * 1934449206) ^ 0x41988782);
					continue;
				case 13u:
					Form2.smethod_1((Control)(object)label3, "Поздравляем! Ваш ход первый.");
					(Form2.smethod_11(Form2.smethod_2((Form)(object)this)) as Form1).turn = true;
					num = ((int)num2 * -970085382) ^ 0x6294D590;
					continue;
				case 12u:
					num = -124728706;
					continue;
				case 11u:
				{
					int num12;
					int num13;
					if (flag2)
					{
						num12 = -1852548388;
						num13 = -1852548388;
					}
					else
					{
						num12 = -740677255;
						num13 = -740677255;
					}
					num = num12 ^ ((int)num2 * -1071516588);
					continue;
				}
				case 10u:
				{
					int num10;
					int num11;
					if (!this.flag)
					{
						num10 = 343839592;
						num11 = 343839592;
					}
					else
					{
						num10 = 1185069667;
						num11 = 1185069667;
					}
					num = num10 ^ ((int)num2 * -613919928);
					continue;
				}
				case 9u:
				{
					Form control_ = Form2.smethod_2((Form)(object)this);
					int num9 = Form2.smethod_12((Control)(object)control_) - 1;
					Form2.smethod_13((Control)(object)control_, num9);
					flag2 = num9 > 1;
					num = -153869243;
					continue;
				}
				case 8u:
					Form2.smethod_1((Control)(object)label3, "Первым ход делает Компьютер.");
					num = -946692854;
					continue;
				case 7u:
					this.flag = false;
					num = -1408937;
					continue;
				case 6u:
					num = ((int)num2 * -694077848) ^ -148572470;
					continue;
				case 5u:
					num = (int)((num2 * 726304934) ^ 0x7A3900B9);
					continue;
				case 3u:
				{
					int num5;
					int num6;
					if ((num3 + num4) % 2 == 0)
					{
						num5 = 1843795329;
						num6 = 1843795329;
					}
					else
					{
						num5 = 2042783327;
						num6 = 2042783327;
					}
					num = num5 ^ ((int)num2 * -954940100);
					continue;
				}
				case 1u:
					num4 = Form2.smethod_9(rnd, 10);
					num = ((int)num2 * -1811760097) ^ -406711792;
					continue;
				case 0u:
					num3 = int.Parse(Form2.smethod_7((Control)(object)textBox1));
					num = ((int)num2 * -237949490) ^ 0x4B1EAF6C;
					continue;
				default:
					return;
				case 4u:
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
			int num = -442495754;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0xCA23E682u) % 11u)
				{
				case 10u:
					if (disposing)
					{
						num = ((int)num2 * -1746401097) ^ 0x124F3C77;
						continue;
					}
					num3 = 0;
					goto IL_001c;
				case 9u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = -570062582;
						num5 = -570062582;
					}
					else
					{
						num4 = -1653870767;
						num5 = -1653870767;
					}
					num = num4 ^ (int)(num2 * 1458510934);
					continue;
				}
				case 8u:
					Form2.smethod_16((IDisposable)components);
					num = (int)(num2 * 1750011839) ^ -711589766;
					continue;
				case 6u:
					num3 = ((components != null) ? 1 : 0);
					goto IL_001c;
				case 4u:
					num = ((int)num2 * -853605128) ^ -1055689049;
					continue;
				case 3u:
					((Form)this).Dispose(disposing);
					num = -848044292;
					continue;
				case 2u:
					num = (int)(num2 * 1551268744) ^ -253124577;
					continue;
				case 1u:
					num = (int)((num2 * 422317159) ^ 0x24A0B15B);
					continue;
				case 0u:
					num = ((int)num2 * -713734351) ^ 0x5BC56C34;
					continue;
				default:
					return;
				case 7u:
					break;
				case 5u:
					return;
					IL_001c:
					flag = (byte)num3 != 0;
					num = -179115421;
					continue;
				}
				break;
			}
		}
	}

	private void InitializeComponent()
	{
		//IL_0208: Unknown result type (might be due to invalid IL or missing references)
		//IL_0212: Expected O, but got Unknown
		//IL_06ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f4: Expected O, but got Unknown
		label1 = Form2.smethod_17();
		while (true)
		{
			int num = 84663374;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x2A56DF48u) % 64u)
				{
				case 63u:
					num = (int)(num2 * 692970199) ^ -388252448;
					continue;
				case 62u:
					label3 = Form2.smethod_17();
					num = (int)(num2 * 1120907125) ^ -1283472202;
					continue;
				case 61u:
					num = ((int)num2 * -448136319) ^ -945425864;
					continue;
				case 60u:
					Form2.smethod_23((Control)(object)label3, "label3");
					num = ((int)num2 * -496815039) ^ 0x58AB282C;
					continue;
				case 59u:
					Form2.smethod_22((Control)(object)textBox1, new Point(24, 86));
					num = ((int)num2 * -415291653) ^ 0x3F06C16E;
					continue;
				case 58u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)button1);
					num = (int)((num2 * 1977547492) ^ 0x617C35F1);
					continue;
				case 57u:
					num = ((int)num2 * -1682883711) ^ 0x6DA927D2;
					continue;
				case 56u:
					Form2.smethod_27((Control)(object)label2, Form2.smethod_26("Microsoft Sans Serif", 48f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = ((int)num2 * -2031350100) ^ -1744206340;
					continue;
				case 55u:
					Form2.smethod_43((Control)(object)this);
					num = (int)((num2 * 2015582463) ^ 0x52F5EE21);
					continue;
				case 54u:
					Form2.smethod_25((Control)(object)button1, 3);
					num = ((int)num2 * -1574512347) ^ 0x53554413;
					continue;
				case 53u:
					Form2.smethod_24((Control)(object)textBox1, new Size(42, 80));
					num = (int)(num2 * 1044605570) ^ -2121972330;
					continue;
				case 52u:
					num = (int)((num2 * 1405445019) ^ 0x51DC1D31);
					continue;
				case 51u:
					Form2.smethod_25((Control)(object)label1, 0);
					Form2.smethod_1((Control)(object)label1, "label1");
					num = (int)(num2 * 575638290) ^ -449345067;
					continue;
				case 50u:
					num = (int)(num2 * 2014207094) ^ -188338447;
					continue;
				case 49u:
					Form2.smethod_32((ContainerControl)(object)this, (AutoScaleMode)1);
					Form2.smethod_33((Form)(object)this, new Size(255, 224));
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)label3);
					num = ((int)num2 * -646334523) ^ -1718871302;
					continue;
				case 48u:
					num = ((int)num2 * -949816026) ^ -1116431362;
					continue;
				case 47u:
					Form2.smethod_41((Form)(object)this, new FormClosedEventHandler(Form2_FormClosed));
					num = (int)(num2 * 1788326067) ^ -344300010;
					continue;
				case 46u:
					num = ((int)num2 * -2039110073) ^ 0x7867B639;
					continue;
				case 45u:
					Form2.smethod_40((Form)(object)this, bool_0: false);
					num = (int)(num2 * 584677700) ^ -1719398922;
					continue;
				case 44u:
					Form2.smethod_21((Control)(object)label3, bool_0: true);
					Form2.smethod_22((Control)(object)label3, new Point(47, 177));
					num = (int)(num2 * 1776025841) ^ -1163871144;
					continue;
				case 43u:
					num = ((int)num2 * -2034397615) ^ 0x5050F9D3;
					continue;
				case 42u:
					num = ((int)num2 * -1003893873) ^ 0x131575F2;
					continue;
				case 41u:
					Form2.smethod_24((Control)(object)label2, new Size(188, 73));
					num = (int)(num2 * 190689114) ^ -92503829;
					continue;
				case 40u:
					Form2.smethod_20((Control)(object)this);
					num = (int)(num2 * 2146217331) ^ -362113399;
					continue;
				case 39u:
					Form2.smethod_22((Control)(object)button1, new Point(86, 193));
					num = ((int)num2 * -881766857) ^ 0x5C123461;
					continue;
				case 38u:
					Form2.smethod_38((Form)(object)this, bool_0: false);
					num = ((int)num2 * -623642610) ^ -1388275387;
					continue;
				case 37u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)label1);
					Form2.smethod_36((Form)(object)this, (FormBorderStyle)1);
					num = (int)(num2 * 1538729337) ^ -211347323;
					continue;
				case 36u:
					num = ((int)num2 * -1495517508) ^ 0x207F5557;
					continue;
				case 35u:
					Form2.smethod_21((Control)(object)label1, bool_0: true);
					num = (int)(num2 * 255661478) ^ -2058649868;
					continue;
				case 34u:
					label2 = Form2.smethod_17();
					button1 = Form2.smethod_19();
					num = (int)(num2 * 1059471622) ^ -1609052038;
					continue;
				case 33u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)label2);
					num = (int)((num2 * 187493168) ^ 0x649D73FA);
					continue;
				case 31u:
					Form2.smethod_27((Control)(object)textBox1, Form2.smethod_26("Microsoft Sans Serif", 48f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
					num = (int)(num2 * 129947821) ^ -235547802;
					continue;
				case 30u:
					Form2.smethod_23((Control)(object)label2, "label2");
					num = ((int)num2 * -623915305) ^ -690516973;
					continue;
				case 29u:
					num = ((int)num2 * -1924172655) ^ -631843170;
					continue;
				case 28u:
					Form2.smethod_25((Control)(object)label2, 2);
					Form2.smethod_1((Control)(object)label2, "+N=?");
					num = (int)(num2 * 996346989) ^ -1230894973;
					continue;
				case 26u:
					Form2.smethod_25((Control)(object)label3, 4);
					num = ((int)num2 * -466348987) ^ 0x3AFA0085;
					continue;
				case 25u:
					Form2.smethod_39((Control)(object)this, "Form2");
					num = ((int)num2 * -810720067) ^ 0x42709D90;
					continue;
				case 24u:
					num = ((int)num2 * -440243827) ^ 0xD00AAF4;
					continue;
				case 23u:
					Form2.smethod_24((Control)(object)label1, new Size(35, 13));
					num = (int)(num2 * 831182060) ^ -474801070;
					continue;
				case 22u:
					Form2.smethod_37((Form)(object)this, bool_0: false);
					num = (int)(num2 * 1946139327) ^ -669145468;
					continue;
				case 21u:
					Form2.smethod_1((Control)(object)button1, "OK");
					num = ((int)num2 * -1660496781) ^ 0x537BCEB5;
					continue;
				case 20u:
					Form2.smethod_22((Control)(object)label2, new Point(53, 89));
					num = (int)((num2 * 959087817) ^ 0x2D8490E2);
					continue;
				case 19u:
					Form2.smethod_23((Control)(object)label1, "label1");
					num = (int)((num2 * 474866525) ^ 0x51487EF8);
					continue;
				case 18u:
					Form2.smethod_29((ButtonBase)(object)button1, bool_0: true);
					num = ((int)num2 * -1363548149) ^ -1801064731;
					continue;
				case 17u:
					Form2.smethod_35(Form2.smethod_34((Control)(object)this), (Control)(object)textBox1);
					num = (int)((num2 * 1090021603) ^ 0x26AA4E7A);
					continue;
				case 16u:
					num = ((int)num2 * -17569641) ^ 0x3E161F6B;
					continue;
				case 15u:
					Form2.smethod_31((ContainerControl)(object)this, new SizeF(6f, 13f));
					num = (int)((num2 * 1656591608) ^ 0x1209C9B1);
					continue;
				case 14u:
					Form2.smethod_22((Control)(object)label1, new Point(10, 10));
					num = (int)((num2 * 1338949204) ^ 0x6DFFEA00);
					continue;
				case 13u:
					Form2.smethod_24((Control)(object)button1, new Size(73, 23));
					num = ((int)num2 * -238592676) ^ 0x57AB2292;
					continue;
				case 12u:
					Form2.smethod_21((Control)(object)label2, bool_0: true);
					num = (int)(num2 * 1559044660) ^ -470776256;
					continue;
				case 11u:
					num = ((int)num2 * -1773097345) ^ -747672222;
					continue;
				case 10u:
					Form2.smethod_1((Control)(object)this, "Жеребьёвка");
					num = (int)(num2 * 1067647339) ^ -1900631998;
					continue;
				case 9u:
					num = (int)(num2 * 363749705) ^ -1793420987;
					continue;
				case 8u:
					Form2.smethod_23((Control)(object)button1, "button1");
					num = (int)((num2 * 1554143668) ^ 0x3E395895);
					continue;
				case 7u:
					num = (int)((num2 * 1470563271) ^ 0x44EEFF43);
					continue;
				case 6u:
					textBox1 = Form2.smethod_18();
					num = (int)(num2 * 292320109) ^ -2074843868;
					continue;
				case 5u:
					Form2.smethod_25((Control)(object)textBox1, 1);
					Form2.smethod_28((Control)(object)textBox1, new KeyPressEventHandler(TextBox1_KeyPress));
					num = ((int)num2 * -2087632762) ^ -1408502148;
					continue;
				case 4u:
					Form2.smethod_24((Control)(object)label3, new Size(0, 13));
					num = (int)(num2 * 469851812) ^ -1981729790;
					continue;
				case 3u:
					Form2.smethod_42((Control)(object)this, bool_0: false);
					num = ((int)num2 * -1715862775) ^ 0x62BB90E4;
					continue;
				case 2u:
					num = ((int)num2 * -720728861) ^ -1340222677;
					continue;
				case 1u:
					Form2.smethod_23((Control)(object)textBox1, "textBox1");
					num = (int)((num2 * 1016635223) ^ 0x5CB44AED);
					continue;
				case 0u:
					Form2.smethod_30((Control)(object)button1, (EventHandler)Button1_Click);
					num = ((int)num2 * -824528630) ^ -668114972;
					continue;
				default:
					return;
				case 27u:
					break;
				case 32u:
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
